
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsBigConceptBL
 表名:BigConcept(01120972)
 * 版本:2024.11.13.1(服务器:WIN-SRV103-116)
 日期:2024/11/13 06:01:23
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:研究生学习游戏化后台(000055, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:大概念教学(BigConceptTeaching)
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
public static class  clsBigConceptBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "strIdBigConcept">表关键字</param>
 /// <returns>表对象</returns>
public static clsBigConceptEN GetObj(this K_IdBigConcept_BigConcept myKey)
{
clsBigConceptEN objBigConceptEN = clsBigConceptBL.BigConceptDA.GetObjByIdBigConcept(myKey.Value);
return objBigConceptEN;
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_AddNewRecord)
 /// </summary>
 /// <param name = "objBigConceptEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clsBigConceptEN objBigConceptEN, bool bolIsNeedCheckUniqueness = true)
{
if (bolIsNeedCheckUniqueness == true && CheckUniqueness(objBigConceptEN) == false)
{
var strMsg = string.Format("记录已经存在!大概念名称 = [{0}],年级流水号 = [{1}]的数据已经存在!(in clsBigConceptBL.AddNewRecord)", objBigConceptEN.BigConceptName,objBigConceptEN.IdGrade);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objBigConceptEN.IdBigConcept) == true || clsBigConceptBL.IsExist(objBigConceptEN.IdBigConcept) == true)
 {
     objBigConceptEN.IdBigConcept = clsBigConceptBL.GetMaxStrId_S();
 }
bool bolResult = clsBigConceptBL.BigConceptDA.AddNewRecordBySQL2(objBigConceptEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsBigConceptBL.ReFreshCache();

if (clsBigConceptBL.relatedActions != null)
{
clsBigConceptBL.relatedActions.UpdRelaTabDate(objBigConceptEN.IdBigConcept, "SetUpdDate");
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
public static bool AddRecordEx(this clsBigConceptEN objBigConceptEN, bool bolIsNeedCheckUniqueness = true)
{
//操作步骤:
//1、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在
//2、检查唯一性
//3、检查传进去的对象属性是否合法
//4、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
//1、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在

//因为是字符型自增主键,不需要检查主键是否已经存在,在添加时,再获取 最大值作为主键
//if (clsBigConceptBL.IsExist(objBigConceptEN.IdBigConcept))	//判断是否有相同的关键字
//{
//strMsg = "(errid:Busi000151)关键字字段已有相同的值";
//throw new Exception(strMsg);
//}
try
{
 //2、检查传进去的对象属性是否合法
objBigConceptEN.CheckPropertyNew();
 ///5.2、检查唯一性
if (bolIsNeedCheckUniqueness == true && objBigConceptEN.CheckUniqueness() == false)
{
strMsg = string.Format("(大概念名称(BigConceptName)=[{0}],年级流水号(IdGrade)=[{1}])已经存在,不能重复!", objBigConceptEN.BigConceptName, objBigConceptEN.IdGrade);
throw new Exception(strMsg);
}
//因为是字符型自增主键,所以在添加时,自动获取主键值。
 if (string.IsNullOrEmpty(objBigConceptEN.IdBigConcept) == true || clsBigConceptBL.IsExist(objBigConceptEN.IdBigConcept) == true)
 {
     objBigConceptEN.IdBigConcept = clsBigConceptBL.GetMaxStrId_S();
 }
//6、把数据实体层的数据存贮到数据库中
objBigConceptEN.AddNewRecord();
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
 /// <param name = "objBigConceptEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static string AddNewRecordWithMaxId(this clsBigConceptEN objBigConceptEN, bool bolIsNeedCheckUniqueness = true)
{
if (bolIsNeedCheckUniqueness == true && CheckUniqueness(objBigConceptEN) == false)
{
var strMsg = string.Format("记录已经存在!大概念名称 = [{0}],年级流水号 = [{1}]的数据已经存在!(in clsBigConceptBL.AddNewRecordWithMaxId)", objBigConceptEN.BigConceptName,objBigConceptEN.IdGrade);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objBigConceptEN.IdBigConcept) == true || clsBigConceptBL.IsExist(objBigConceptEN.IdBigConcept) == true)
 {
     objBigConceptEN.IdBigConcept = clsBigConceptBL.GetMaxStrId_S();
 }
string strIdBigConcept = clsBigConceptBL.BigConceptDA.AddNewRecordBySQL2WithReturnKey(objBigConceptEN);
     objBigConceptEN.IdBigConcept = strIdBigConcept;
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsBigConceptBL.ReFreshCache();

if (clsBigConceptBL.relatedActions != null)
{
clsBigConceptBL.relatedActions.UpdRelaTabDate(objBigConceptEN.IdBigConcept, "SetUpdDate");
}
return strIdBigConcept;
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
 /// <param name = "objBigConceptEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordWithReturnKey(this clsBigConceptEN objBigConceptEN, bool bolIsNeedCheckUniqueness = true)
{
if (bolIsNeedCheckUniqueness == true && CheckUniqueness(objBigConceptEN) == false)
{
var strMsg = string.Format("记录已经存在!大概念名称 = [{0}],年级流水号 = [{1}]的数据已经存在!(in clsBigConceptBL.AddNewRecordWithReturnKey)", objBigConceptEN.BigConceptName,objBigConceptEN.IdGrade);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objBigConceptEN.IdBigConcept) == true || clsBigConceptBL.IsExist(objBigConceptEN.IdBigConcept) == true)
 {
     objBigConceptEN.IdBigConcept = clsBigConceptBL.GetMaxStrId_S();
 }
string strKey = clsBigConceptBL.BigConceptDA.AddNewRecordBySQL2WithReturnKey(objBigConceptEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsBigConceptBL.ReFreshCache();

if (clsBigConceptBL.relatedActions != null)
{
clsBigConceptBL.relatedActions.UpdRelaTabDate(objBigConceptEN.IdBigConcept, "SetUpdDate");
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
 /// <param name = "objBigConceptEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsBigConceptEN SetIdBigConcept(this clsBigConceptEN objBigConceptEN, string strIdBigConcept, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdBigConcept, 8, conBigConcept.IdBigConcept);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdBigConcept, 8, conBigConcept.IdBigConcept);
}
objBigConceptEN.IdBigConcept = strIdBigConcept; //大概念流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objBigConceptEN.dicFldComparisonOp.ContainsKey(conBigConcept.IdBigConcept) == false)
{
objBigConceptEN.dicFldComparisonOp.Add(conBigConcept.IdBigConcept, strComparisonOp);
}
else
{
objBigConceptEN.dicFldComparisonOp[conBigConcept.IdBigConcept] = strComparisonOp;
}
}
return objBigConceptEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objBigConceptEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsBigConceptEN SetBigConceptId(this clsBigConceptEN objBigConceptEN, string strBigConceptId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strBigConceptId, conBigConcept.BigConceptId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strBigConceptId, 12, conBigConcept.BigConceptId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strBigConceptId, 12, conBigConcept.BigConceptId);
}
objBigConceptEN.BigConceptId = strBigConceptId; //大概念编号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objBigConceptEN.dicFldComparisonOp.ContainsKey(conBigConcept.BigConceptId) == false)
{
objBigConceptEN.dicFldComparisonOp.Add(conBigConcept.BigConceptId, strComparisonOp);
}
else
{
objBigConceptEN.dicFldComparisonOp[conBigConcept.BigConceptId] = strComparisonOp;
}
}
return objBigConceptEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objBigConceptEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsBigConceptEN SetBigConceptName(this clsBigConceptEN objBigConceptEN, string strBigConceptName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strBigConceptName, conBigConcept.BigConceptName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strBigConceptName, 100, conBigConcept.BigConceptName);
}
objBigConceptEN.BigConceptName = strBigConceptName; //大概念名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objBigConceptEN.dicFldComparisonOp.ContainsKey(conBigConcept.BigConceptName) == false)
{
objBigConceptEN.dicFldComparisonOp.Add(conBigConcept.BigConceptName, strComparisonOp);
}
else
{
objBigConceptEN.dicFldComparisonOp[conBigConcept.BigConceptName] = strComparisonOp;
}
}
return objBigConceptEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objBigConceptEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsBigConceptEN SetIdGrade(this clsBigConceptEN objBigConceptEN, string strIdGrade, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strIdGrade, conBigConcept.IdGrade);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdGrade, 4, conBigConcept.IdGrade);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdGrade, 4, conBigConcept.IdGrade);
}
objBigConceptEN.IdGrade = strIdGrade; //年级流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objBigConceptEN.dicFldComparisonOp.ContainsKey(conBigConcept.IdGrade) == false)
{
objBigConceptEN.dicFldComparisonOp.Add(conBigConcept.IdGrade, strComparisonOp);
}
else
{
objBigConceptEN.dicFldComparisonOp[conBigConcept.IdGrade] = strComparisonOp;
}
}
return objBigConceptEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objBigConceptEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsBigConceptEN SetSchoolTerm(this clsBigConceptEN objBigConceptEN, string strSchoolTerm, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strSchoolTerm, conBigConcept.SchoolTerm);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strSchoolTerm, 1, conBigConcept.SchoolTerm);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strSchoolTerm, 1, conBigConcept.SchoolTerm);
}
objBigConceptEN.SchoolTerm = strSchoolTerm; //学期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objBigConceptEN.dicFldComparisonOp.ContainsKey(conBigConcept.SchoolTerm) == false)
{
objBigConceptEN.dicFldComparisonOp.Add(conBigConcept.SchoolTerm, strComparisonOp);
}
else
{
objBigConceptEN.dicFldComparisonOp[conBigConcept.SchoolTerm] = strComparisonOp;
}
}
return objBigConceptEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objBigConceptEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsBigConceptEN SetCourseId(this clsBigConceptEN objBigConceptEN, string strCourseId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strCourseId, conBigConcept.CourseId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCourseId, 8, conBigConcept.CourseId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strCourseId, 8, conBigConcept.CourseId);
}
objBigConceptEN.CourseId = strCourseId; //课程Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objBigConceptEN.dicFldComparisonOp.ContainsKey(conBigConcept.CourseId) == false)
{
objBigConceptEN.dicFldComparisonOp.Add(conBigConcept.CourseId, strComparisonOp);
}
else
{
objBigConceptEN.dicFldComparisonOp[conBigConcept.CourseId] = strComparisonOp;
}
}
return objBigConceptEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objBigConceptEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsBigConceptEN SetIsClgCheck(this clsBigConceptEN objBigConceptEN, bool bolIsClgCheck, string strComparisonOp="")
	{
objBigConceptEN.IsClgCheck = bolIsClgCheck; //是否学院审批
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objBigConceptEN.dicFldComparisonOp.ContainsKey(conBigConcept.IsClgCheck) == false)
{
objBigConceptEN.dicFldComparisonOp.Add(conBigConcept.IsClgCheck, strComparisonOp);
}
else
{
objBigConceptEN.dicFldComparisonOp[conBigConcept.IsClgCheck] = strComparisonOp;
}
}
return objBigConceptEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objBigConceptEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsBigConceptEN SetClgNote(this clsBigConceptEN objBigConceptEN, string strClgNote, string strComparisonOp="")
	{
objBigConceptEN.ClgNote = strClgNote; //学院审批意见
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objBigConceptEN.dicFldComparisonOp.ContainsKey(conBigConcept.ClgNote) == false)
{
objBigConceptEN.dicFldComparisonOp.Add(conBigConcept.ClgNote, strComparisonOp);
}
else
{
objBigConceptEN.dicFldComparisonOp[conBigConcept.ClgNote] = strComparisonOp;
}
}
return objBigConceptEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objBigConceptEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsBigConceptEN SetClgCheckerId(this clsBigConceptEN objBigConceptEN, string strClgCheckerId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strClgCheckerId, 18, conBigConcept.ClgCheckerId);
}
objBigConceptEN.ClgCheckerId = strClgCheckerId; //学院审批人id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objBigConceptEN.dicFldComparisonOp.ContainsKey(conBigConcept.ClgCheckerId) == false)
{
objBigConceptEN.dicFldComparisonOp.Add(conBigConcept.ClgCheckerId, strComparisonOp);
}
else
{
objBigConceptEN.dicFldComparisonOp[conBigConcept.ClgCheckerId] = strComparisonOp;
}
}
return objBigConceptEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objBigConceptEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsBigConceptEN SetClgCheckDate(this clsBigConceptEN objBigConceptEN, string strClgCheckDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strClgCheckDate, 8, conBigConcept.ClgCheckDate);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strClgCheckDate, 8, conBigConcept.ClgCheckDate);
}
objBigConceptEN.ClgCheckDate = strClgCheckDate; //学院审批日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objBigConceptEN.dicFldComparisonOp.ContainsKey(conBigConcept.ClgCheckDate) == false)
{
objBigConceptEN.dicFldComparisonOp.Add(conBigConcept.ClgCheckDate, strComparisonOp);
}
else
{
objBigConceptEN.dicFldComparisonOp[conBigConcept.ClgCheckDate] = strComparisonOp;
}
}
return objBigConceptEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objBigConceptEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsBigConceptEN SetIsSchCheck(this clsBigConceptEN objBigConceptEN, bool bolIsSchCheck, string strComparisonOp="")
	{
objBigConceptEN.IsSchCheck = bolIsSchCheck; //是否学校审批
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objBigConceptEN.dicFldComparisonOp.ContainsKey(conBigConcept.IsSchCheck) == false)
{
objBigConceptEN.dicFldComparisonOp.Add(conBigConcept.IsSchCheck, strComparisonOp);
}
else
{
objBigConceptEN.dicFldComparisonOp[conBigConcept.IsSchCheck] = strComparisonOp;
}
}
return objBigConceptEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objBigConceptEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsBigConceptEN SetSchNote(this clsBigConceptEN objBigConceptEN, string strSchNote, string strComparisonOp="")
	{
objBigConceptEN.SchNote = strSchNote; //学校审批意见
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objBigConceptEN.dicFldComparisonOp.ContainsKey(conBigConcept.SchNote) == false)
{
objBigConceptEN.dicFldComparisonOp.Add(conBigConcept.SchNote, strComparisonOp);
}
else
{
objBigConceptEN.dicFldComparisonOp[conBigConcept.SchNote] = strComparisonOp;
}
}
return objBigConceptEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objBigConceptEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsBigConceptEN SetSchCheckerId(this clsBigConceptEN objBigConceptEN, string strSchCheckerId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strSchCheckerId, 18, conBigConcept.SchCheckerId);
}
objBigConceptEN.SchCheckerId = strSchCheckerId; //学校审批人Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objBigConceptEN.dicFldComparisonOp.ContainsKey(conBigConcept.SchCheckerId) == false)
{
objBigConceptEN.dicFldComparisonOp.Add(conBigConcept.SchCheckerId, strComparisonOp);
}
else
{
objBigConceptEN.dicFldComparisonOp[conBigConcept.SchCheckerId] = strComparisonOp;
}
}
return objBigConceptEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objBigConceptEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsBigConceptEN SetSchCheckDate(this clsBigConceptEN objBigConceptEN, string strSchCheckDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strSchCheckDate, 8, conBigConcept.SchCheckDate);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strSchCheckDate, 8, conBigConcept.SchCheckDate);
}
objBigConceptEN.SchCheckDate = strSchCheckDate; //学校审批日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objBigConceptEN.dicFldComparisonOp.ContainsKey(conBigConcept.SchCheckDate) == false)
{
objBigConceptEN.dicFldComparisonOp.Add(conBigConcept.SchCheckDate, strComparisonOp);
}
else
{
objBigConceptEN.dicFldComparisonOp[conBigConcept.SchCheckDate] = strComparisonOp;
}
}
return objBigConceptEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objBigConceptEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsBigConceptEN SetIdSubmitStatus(this clsBigConceptEN objBigConceptEN, string strIdSubmitStatus, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strIdSubmitStatus, conBigConcept.IdSubmitStatus);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdSubmitStatus, 2, conBigConcept.IdSubmitStatus);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdSubmitStatus, 2, conBigConcept.IdSubmitStatus);
}
objBigConceptEN.IdSubmitStatus = strIdSubmitStatus; //送审状态流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objBigConceptEN.dicFldComparisonOp.ContainsKey(conBigConcept.IdSubmitStatus) == false)
{
objBigConceptEN.dicFldComparisonOp.Add(conBigConcept.IdSubmitStatus, strComparisonOp);
}
else
{
objBigConceptEN.dicFldComparisonOp[conBigConcept.IdSubmitStatus] = strComparisonOp;
}
}
return objBigConceptEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objBigConceptEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsBigConceptEN SetMemo(this clsBigConceptEN objBigConceptEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, conBigConcept.Memo);
}
objBigConceptEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objBigConceptEN.dicFldComparisonOp.ContainsKey(conBigConcept.Memo) == false)
{
objBigConceptEN.dicFldComparisonOp.Add(conBigConcept.Memo, strComparisonOp);
}
else
{
objBigConceptEN.dicFldComparisonOp[conBigConcept.Memo] = strComparisonOp;
}
}
return objBigConceptEN;
	}

 /// <summary>
 /// 修改记录存盘到数据表中
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_UpdateRecordEx)
 /// </summary>
 /// <param name = "objBigConceptEN">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool UpdateRecordEx(this clsBigConceptEN objBigConceptEN)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
try
{
//1、检查传进去的对象属性是否合法
objBigConceptEN.CheckPropertyNew();
clsBigConceptEN objBigConceptCond = new clsBigConceptEN();
string strCondition = objBigConceptCond
.SetIdBigConcept(objBigConceptEN.IdBigConcept, "<>")
.SetBigConceptName(objBigConceptEN.BigConceptName, "=")
.SetIdGrade(objBigConceptEN.IdGrade, "=")
.GetCombineCondition();
objBigConceptEN._IsCheckProperty = true;
bool bolIsExist = clsBigConceptBL.IsExistRecord(strCondition);
if (bolIsExist)
{
strMsg = "(aa1)不能重复!";
throw new Exception(strMsg);
}
//4、把数据实体层的数据存贮到数据库中
objBigConceptEN.Update();
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
 /// <param name = "objBigConcept">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool EditRecordEx(this clsBigConceptEN objBigConcept)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
clsBigConceptEN objBigConceptCond = new clsBigConceptEN();
string strCondition = objBigConceptCond
.SetBigConceptName(objBigConcept.BigConceptName, "=")
.SetIdGrade(objBigConcept.IdGrade, "=")
.GetCombineCondition();
objBigConcept._IsCheckProperty = true;
bool bolIsExist = clsBigConceptBL.IsExistRecord(strCondition);
if (bolIsExist)
{
objBigConcept.IdBigConcept = clsBigConceptBL.GetFirstID_S(strCondition);
objBigConcept.UpdateWithCondition(strCondition);
}
else
{
objBigConcept.IdBigConcept = clsBigConceptBL.GetMaxStrId_S();
objBigConcept.AddNewRecord();
}
return true; 
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_Update)
 /// </summary>
 /// <param name = "objBigConceptEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsBigConceptEN objBigConceptEN)
{
 if (string.IsNullOrEmpty(objBigConceptEN.IdBigConcept) == true)
 {
string strMsg = string.Format("(errid:Busi000095)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsBigConceptBL.BigConceptDA.UpdateBySql2(objBigConceptEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsBigConceptBL.ReFreshCache();

if (clsBigConceptBL.relatedActions != null)
{
clsBigConceptBL.relatedActions.UpdRelaTabDate(objBigConceptEN.IdBigConcept, "SetUpdDate");
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
 /// <param name = "objBigConceptEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsBigConceptEN objBigConceptEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (string.IsNullOrEmpty(objBigConceptEN.IdBigConcept) == true)
 {
string strMsg = string.Format("(errid:Busi000087)修改记录时关键字不能为空!(带事务处理)(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsBigConceptBL.BigConceptDA.UpdateBySql2(objBigConceptEN, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsBigConceptBL.ReFreshCache();

if (clsBigConceptBL.relatedActions != null)
{
clsBigConceptBL.relatedActions.UpdRelaTabDate(objBigConceptEN.IdBigConcept, "SetUpdDate");
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
 /// <param name = "objBigConceptEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsBigConceptEN objBigConceptEN, string strWhereCond)
{
try
{
bool bolResult = clsBigConceptBL.BigConceptDA.UpdateBySqlWithCondition(objBigConceptEN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsBigConceptBL.ReFreshCache();

if (clsBigConceptBL.relatedActions != null)
{
clsBigConceptBL.relatedActions.UpdRelaTabDate(objBigConceptEN.IdBigConcept, "SetUpdDate");
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
 /// <param name = "objBigConceptEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsBigConceptEN objBigConceptEN, string strWhereCond, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
bool bolResult = clsBigConceptBL.BigConceptDA.UpdateBySqlWithConditionTransaction(objBigConceptEN, strWhereCond, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsBigConceptBL.ReFreshCache();

if (clsBigConceptBL.relatedActions != null)
{
clsBigConceptBL.relatedActions.UpdRelaTabDate(objBigConceptEN.IdBigConcept, "SetUpdDate");
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
 /// <param name = "strIdBigConcept">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int Delete(this clsBigConceptEN objBigConceptEN)
{
try
{
int intRecNum = clsBigConceptBL.BigConceptDA.DelRecord(objBigConceptEN.IdBigConcept);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsBigConceptBL.ReFreshCache();

if (clsBigConceptBL.relatedActions != null)
{
clsBigConceptBL.relatedActions.UpdRelaTabDate(objBigConceptEN.IdBigConcept, "SetUpdDate");
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
 /// <param name = "objBigConceptENS">源对象</param>
 /// <param name = "objBigConceptENT">目标对象</param>
 public static void CopyTo(this clsBigConceptEN objBigConceptENS, clsBigConceptEN objBigConceptENT)
{
try
{
objBigConceptENT.IdBigConcept = objBigConceptENS.IdBigConcept; //大概念流水号
objBigConceptENT.BigConceptId = objBigConceptENS.BigConceptId; //大概念编号
objBigConceptENT.BigConceptName = objBigConceptENS.BigConceptName; //大概念名称
objBigConceptENT.IdGrade = objBigConceptENS.IdGrade; //年级流水号
objBigConceptENT.SchoolTerm = objBigConceptENS.SchoolTerm; //学期
objBigConceptENT.CourseId = objBigConceptENS.CourseId; //课程Id
objBigConceptENT.IsClgCheck = objBigConceptENS.IsClgCheck; //是否学院审批
objBigConceptENT.ClgNote = objBigConceptENS.ClgNote; //学院审批意见
objBigConceptENT.ClgCheckerId = objBigConceptENS.ClgCheckerId; //学院审批人id
objBigConceptENT.ClgCheckDate = objBigConceptENS.ClgCheckDate; //学院审批日期
objBigConceptENT.IsSchCheck = objBigConceptENS.IsSchCheck; //是否学校审批
objBigConceptENT.SchNote = objBigConceptENS.SchNote; //学校审批意见
objBigConceptENT.SchCheckerId = objBigConceptENS.SchCheckerId; //学校审批人Id
objBigConceptENT.SchCheckDate = objBigConceptENS.SchCheckDate; //学校审批日期
objBigConceptENT.IdSubmitStatus = objBigConceptENS.IdSubmitStatus; //送审状态流水号
objBigConceptENT.Memo = objBigConceptENS.Memo; //备注
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
 /// <param name = "objBigConceptENS">源对象</param>
 /// <returns>目标对象=>clsBigConceptEN:objBigConceptENT</returns>
 public static clsBigConceptEN CopyTo(this clsBigConceptEN objBigConceptENS)
{
try
{
 clsBigConceptEN objBigConceptENT = new clsBigConceptEN()
{
IdBigConcept = objBigConceptENS.IdBigConcept, //大概念流水号
BigConceptId = objBigConceptENS.BigConceptId, //大概念编号
BigConceptName = objBigConceptENS.BigConceptName, //大概念名称
IdGrade = objBigConceptENS.IdGrade, //年级流水号
SchoolTerm = objBigConceptENS.SchoolTerm, //学期
CourseId = objBigConceptENS.CourseId, //课程Id
IsClgCheck = objBigConceptENS.IsClgCheck, //是否学院审批
ClgNote = objBigConceptENS.ClgNote, //学院审批意见
ClgCheckerId = objBigConceptENS.ClgCheckerId, //学院审批人id
ClgCheckDate = objBigConceptENS.ClgCheckDate, //学院审批日期
IsSchCheck = objBigConceptENS.IsSchCheck, //是否学校审批
SchNote = objBigConceptENS.SchNote, //学校审批意见
SchCheckerId = objBigConceptENS.SchCheckerId, //学校审批人Id
SchCheckDate = objBigConceptENS.SchCheckDate, //学校审批日期
IdSubmitStatus = objBigConceptENS.IdSubmitStatus, //送审状态流水号
Memo = objBigConceptENS.Memo, //备注
};
 return objBigConceptENT;
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
public static void CheckPropertyNew(this clsBigConceptEN objBigConceptEN)
{
 clsBigConceptBL.BigConceptDA.CheckPropertyNew(objBigConceptEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(this clsBigConceptEN objBigConceptEN)
{
 clsBigConceptBL.BigConceptDA.CheckProperty4Condition(objBigConceptEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsBigConceptEN objBigConceptCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objBigConceptCond.IsUpdated(conBigConcept.IdBigConcept) == true)
{
string strComparisonOpIdBigConcept = objBigConceptCond.dicFldComparisonOp[conBigConcept.IdBigConcept];
strWhereCond += string.Format(" And {0} {2} '{1}'", conBigConcept.IdBigConcept, objBigConceptCond.IdBigConcept, strComparisonOpIdBigConcept);
}
if (objBigConceptCond.IsUpdated(conBigConcept.BigConceptId) == true)
{
string strComparisonOpBigConceptId = objBigConceptCond.dicFldComparisonOp[conBigConcept.BigConceptId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conBigConcept.BigConceptId, objBigConceptCond.BigConceptId, strComparisonOpBigConceptId);
}
if (objBigConceptCond.IsUpdated(conBigConcept.BigConceptName) == true)
{
string strComparisonOpBigConceptName = objBigConceptCond.dicFldComparisonOp[conBigConcept.BigConceptName];
strWhereCond += string.Format(" And {0} {2} '{1}'", conBigConcept.BigConceptName, objBigConceptCond.BigConceptName, strComparisonOpBigConceptName);
}
if (objBigConceptCond.IsUpdated(conBigConcept.IdGrade) == true)
{
string strComparisonOpIdGrade = objBigConceptCond.dicFldComparisonOp[conBigConcept.IdGrade];
strWhereCond += string.Format(" And {0} {2} '{1}'", conBigConcept.IdGrade, objBigConceptCond.IdGrade, strComparisonOpIdGrade);
}
if (objBigConceptCond.IsUpdated(conBigConcept.SchoolTerm) == true)
{
string strComparisonOpSchoolTerm = objBigConceptCond.dicFldComparisonOp[conBigConcept.SchoolTerm];
strWhereCond += string.Format(" And {0} {2} '{1}'", conBigConcept.SchoolTerm, objBigConceptCond.SchoolTerm, strComparisonOpSchoolTerm);
}
if (objBigConceptCond.IsUpdated(conBigConcept.CourseId) == true)
{
string strComparisonOpCourseId = objBigConceptCond.dicFldComparisonOp[conBigConcept.CourseId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conBigConcept.CourseId, objBigConceptCond.CourseId, strComparisonOpCourseId);
}
if (objBigConceptCond.IsUpdated(conBigConcept.IsClgCheck) == true)
{
if (objBigConceptCond.IsClgCheck == true)
{
strWhereCond += string.Format(" And {0} = '1'", conBigConcept.IsClgCheck);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conBigConcept.IsClgCheck);
}
}
//数据类型string(text)在函数:[AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj]中没有处理!
if (objBigConceptCond.IsUpdated(conBigConcept.ClgCheckerId) == true)
{
string strComparisonOpClgCheckerId = objBigConceptCond.dicFldComparisonOp[conBigConcept.ClgCheckerId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conBigConcept.ClgCheckerId, objBigConceptCond.ClgCheckerId, strComparisonOpClgCheckerId);
}
if (objBigConceptCond.IsUpdated(conBigConcept.ClgCheckDate) == true)
{
string strComparisonOpClgCheckDate = objBigConceptCond.dicFldComparisonOp[conBigConcept.ClgCheckDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conBigConcept.ClgCheckDate, objBigConceptCond.ClgCheckDate, strComparisonOpClgCheckDate);
}
if (objBigConceptCond.IsUpdated(conBigConcept.IsSchCheck) == true)
{
if (objBigConceptCond.IsSchCheck == true)
{
strWhereCond += string.Format(" And {0} = '1'", conBigConcept.IsSchCheck);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conBigConcept.IsSchCheck);
}
}
//数据类型string(text)在函数:[AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj]中没有处理!
if (objBigConceptCond.IsUpdated(conBigConcept.SchCheckerId) == true)
{
string strComparisonOpSchCheckerId = objBigConceptCond.dicFldComparisonOp[conBigConcept.SchCheckerId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conBigConcept.SchCheckerId, objBigConceptCond.SchCheckerId, strComparisonOpSchCheckerId);
}
if (objBigConceptCond.IsUpdated(conBigConcept.SchCheckDate) == true)
{
string strComparisonOpSchCheckDate = objBigConceptCond.dicFldComparisonOp[conBigConcept.SchCheckDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conBigConcept.SchCheckDate, objBigConceptCond.SchCheckDate, strComparisonOpSchCheckDate);
}
if (objBigConceptCond.IsUpdated(conBigConcept.IdSubmitStatus) == true)
{
string strComparisonOpIdSubmitStatus = objBigConceptCond.dicFldComparisonOp[conBigConcept.IdSubmitStatus];
strWhereCond += string.Format(" And {0} {2} '{1}'", conBigConcept.IdSubmitStatus, objBigConceptCond.IdSubmitStatus, strComparisonOpIdSubmitStatus);
}
if (objBigConceptCond.IsUpdated(conBigConcept.Memo) == true)
{
string strComparisonOpMemo = objBigConceptCond.dicFldComparisonOp[conBigConcept.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", conBigConcept.Memo, objBigConceptCond.Memo, strComparisonOpMemo);
}
 return strWhereCond;
}

 /// <summary>
 /// 检查唯一性(Uniqueness)--BigConcept(大概念), 如果不唯一,即存在相同的记录,就返回False
 /// 唯一性条件:BigConceptName_IdGrade
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckConstraint)
 /// </summary>
 /// <param name = "objBigConceptEN">要求唯一的对象</param>
 /// <returns></returns>
public static bool CheckUniqueness(this clsBigConceptEN objBigConceptEN)
{
//检测记录是否存在
bool bolIsUniqueness;
StringBuilder sbCondition = new StringBuilder();
if (objBigConceptEN == null) return true;
if (objBigConceptEN.IdBigConcept == null || objBigConceptEN.IdBigConcept == "")
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and BigConceptName = '{0}'", objBigConceptEN.BigConceptName);
 sbCondition.AppendFormat(" and IdGrade = '{0}'", objBigConceptEN.IdGrade);
if (clsBigConceptBL.IsExistRecord(sbCondition.ToString())  ==  true)
{
 bolIsUniqueness = false;
}
else
{
 bolIsUniqueness = true;
}
}
 else {
sbCondition.AppendFormat("IdBigConcept !=  '{0}'", objBigConceptEN.IdBigConcept);
 sbCondition.AppendFormat(" and BigConceptName = '{0}'", objBigConceptEN.BigConceptName);
 sbCondition.AppendFormat(" and IdGrade = '{0}'", objBigConceptEN.IdGrade);
if (clsBigConceptBL.IsExistRecord(sbCondition.ToString())  ==  true)
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
 /// 获取唯一性条件串--BigConcept(大概念), 即由对象中唯一性条件字段关键字与值组成的条件串
 /// 唯一性条件:BigConceptName_IdGrade
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetConditionString4Constraint)
 /// </summary>
 /// <param name = "objBigConceptEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(this clsBigConceptEN objBigConceptEN)
{
//检测记录是否存在
StringBuilder sbCondition = new StringBuilder();
if (objBigConceptEN == null) return "";
if (objBigConceptEN.IdBigConcept == null || objBigConceptEN.IdBigConcept == "")
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and BigConceptName = '{0}'", objBigConceptEN.BigConceptName);
 sbCondition.AppendFormat(" and IdGrade = '{0}'", objBigConceptEN.IdGrade);
return sbCondition.ToString();
}
 else {
sbCondition.AppendFormat("IdBigConcept !=  '{0}'", objBigConceptEN.IdBigConcept);
 sbCondition.AppendFormat(" and BigConceptName = '{0}'", objBigConceptEN.BigConceptName);
 sbCondition.AppendFormat(" and IdGrade = '{0}'", objBigConceptEN.IdGrade);
 return sbCondition.ToString();
}
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_BigConcept
{
public virtual bool UpdRelaTabDate(string strIdBigConcept, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// 大概念(BigConcept)
 /// 数据源类型:表
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsBigConceptBL
{
public static RelatedActions_BigConcept relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsBigConceptDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsBigConceptDA BigConceptDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsBigConceptDA();
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
 public clsBigConceptBL()
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
if (string.IsNullOrEmpty(clsBigConceptEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsBigConceptEN._ConnectString);
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
public static DataTable GetDataTable_BigConcept(string strWhereCond)
{
DataTable objDT;
try
{
objDT = BigConceptDA.GetDataTable_BigConcept(strWhereCond);
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
objDT = BigConceptDA.GetDataTable(strWhereCond);
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
objDT = BigConceptDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = BigConceptDA.GetDataTable(strWhereCond, strTabName);
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
objDT = BigConceptDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = BigConceptDA.GetDataTable_Top(objTopPara);
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
objDT = BigConceptDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = BigConceptDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = BigConceptDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
 /// <param name = "arrIdBigConceptLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static List<clsBigConceptEN> GetObjLstByIdBigConceptLst(List<string> arrIdBigConceptLst)
{
List<clsBigConceptEN> arrObjLst = new List<clsBigConceptEN>(); 
System.Data.DataTable objDT; 
 string strSqlConditionStr = clsArray.GetSqlInStrByArray(arrIdBigConceptLst, true);
 string strWhereCond = string.Format("IdBigConcept in ({0})", strSqlConditionStr);
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsBigConceptEN objBigConceptEN = new clsBigConceptEN();
try
{
objBigConceptEN.IdBigConcept = objRow[conBigConcept.IdBigConcept].ToString().Trim(); //大概念流水号
objBigConceptEN.BigConceptId = objRow[conBigConcept.BigConceptId].ToString().Trim(); //大概念编号
objBigConceptEN.BigConceptName = objRow[conBigConcept.BigConceptName].ToString().Trim(); //大概念名称
objBigConceptEN.IdGrade = objRow[conBigConcept.IdGrade].ToString().Trim(); //年级流水号
objBigConceptEN.SchoolTerm = objRow[conBigConcept.SchoolTerm].ToString().Trim(); //学期
objBigConceptEN.CourseId = objRow[conBigConcept.CourseId].ToString().Trim(); //课程Id
objBigConceptEN.IsClgCheck = clsEntityBase2.TransNullToBool_S(objRow[conBigConcept.IsClgCheck].ToString().Trim()); //是否学院审批
objBigConceptEN.ClgNote = objRow[conBigConcept.ClgNote] == DBNull.Value ? null : objRow[conBigConcept.ClgNote].ToString().Trim(); //学院审批意见
objBigConceptEN.ClgCheckerId = objRow[conBigConcept.ClgCheckerId] == DBNull.Value ? null : objRow[conBigConcept.ClgCheckerId].ToString().Trim(); //学院审批人id
objBigConceptEN.ClgCheckDate = objRow[conBigConcept.ClgCheckDate] == DBNull.Value ? null : objRow[conBigConcept.ClgCheckDate].ToString().Trim(); //学院审批日期
objBigConceptEN.IsSchCheck = clsEntityBase2.TransNullToBool_S(objRow[conBigConcept.IsSchCheck].ToString().Trim()); //是否学校审批
objBigConceptEN.SchNote = objRow[conBigConcept.SchNote] == DBNull.Value ? null : objRow[conBigConcept.SchNote].ToString().Trim(); //学校审批意见
objBigConceptEN.SchCheckerId = objRow[conBigConcept.SchCheckerId] == DBNull.Value ? null : objRow[conBigConcept.SchCheckerId].ToString().Trim(); //学校审批人Id
objBigConceptEN.SchCheckDate = objRow[conBigConcept.SchCheckDate] == DBNull.Value ? null : objRow[conBigConcept.SchCheckDate].ToString().Trim(); //学校审批日期
objBigConceptEN.IdSubmitStatus = objRow[conBigConcept.IdSubmitStatus].ToString().Trim(); //送审状态流水号
objBigConceptEN.Memo = objRow[conBigConcept.Memo] == DBNull.Value ? null : objRow[conBigConcept.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objBigConceptEN.IdBigConcept, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objBigConceptEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrIdBigConceptLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsBigConceptEN> GetObjLstByIdBigConceptLstCache(List<string> arrIdBigConceptLst)
{
string strKey = string.Format("{0}", clsBigConceptEN._CurrTabName);
List<clsBigConceptEN> arrBigConceptObjLstCache = GetObjLstCache();
IEnumerable <clsBigConceptEN> arrBigConceptObjLst_Sel =
arrBigConceptObjLstCache
.Where(x => arrIdBigConceptLst.Contains(x.IdBigConcept));
return arrBigConceptObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsBigConceptEN> GetObjLst(string strWhereCond)
{
List<clsBigConceptEN> arrObjLst = new List<clsBigConceptEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsBigConceptEN objBigConceptEN = new clsBigConceptEN();
try
{
objBigConceptEN.IdBigConcept = objRow[conBigConcept.IdBigConcept].ToString().Trim(); //大概念流水号
objBigConceptEN.BigConceptId = objRow[conBigConcept.BigConceptId].ToString().Trim(); //大概念编号
objBigConceptEN.BigConceptName = objRow[conBigConcept.BigConceptName].ToString().Trim(); //大概念名称
objBigConceptEN.IdGrade = objRow[conBigConcept.IdGrade].ToString().Trim(); //年级流水号
objBigConceptEN.SchoolTerm = objRow[conBigConcept.SchoolTerm].ToString().Trim(); //学期
objBigConceptEN.CourseId = objRow[conBigConcept.CourseId].ToString().Trim(); //课程Id
objBigConceptEN.IsClgCheck = clsEntityBase2.TransNullToBool_S(objRow[conBigConcept.IsClgCheck].ToString().Trim()); //是否学院审批
objBigConceptEN.ClgNote = objRow[conBigConcept.ClgNote] == DBNull.Value ? null : objRow[conBigConcept.ClgNote].ToString().Trim(); //学院审批意见
objBigConceptEN.ClgCheckerId = objRow[conBigConcept.ClgCheckerId] == DBNull.Value ? null : objRow[conBigConcept.ClgCheckerId].ToString().Trim(); //学院审批人id
objBigConceptEN.ClgCheckDate = objRow[conBigConcept.ClgCheckDate] == DBNull.Value ? null : objRow[conBigConcept.ClgCheckDate].ToString().Trim(); //学院审批日期
objBigConceptEN.IsSchCheck = clsEntityBase2.TransNullToBool_S(objRow[conBigConcept.IsSchCheck].ToString().Trim()); //是否学校审批
objBigConceptEN.SchNote = objRow[conBigConcept.SchNote] == DBNull.Value ? null : objRow[conBigConcept.SchNote].ToString().Trim(); //学校审批意见
objBigConceptEN.SchCheckerId = objRow[conBigConcept.SchCheckerId] == DBNull.Value ? null : objRow[conBigConcept.SchCheckerId].ToString().Trim(); //学校审批人Id
objBigConceptEN.SchCheckDate = objRow[conBigConcept.SchCheckDate] == DBNull.Value ? null : objRow[conBigConcept.SchCheckDate].ToString().Trim(); //学校审批日期
objBigConceptEN.IdSubmitStatus = objRow[conBigConcept.IdSubmitStatus].ToString().Trim(); //送审状态流水号
objBigConceptEN.Memo = objRow[conBigConcept.Memo] == DBNull.Value ? null : objRow[conBigConcept.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objBigConceptEN.IdBigConcept, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objBigConceptEN);
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
public static List<clsBigConceptEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsBigConceptEN> arrObjLst = new List<clsBigConceptEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsBigConceptEN objBigConceptEN = new clsBigConceptEN();
try
{
objBigConceptEN.IdBigConcept = objRow[conBigConcept.IdBigConcept].ToString().Trim(); //大概念流水号
objBigConceptEN.BigConceptId = objRow[conBigConcept.BigConceptId].ToString().Trim(); //大概念编号
objBigConceptEN.BigConceptName = objRow[conBigConcept.BigConceptName].ToString().Trim(); //大概念名称
objBigConceptEN.IdGrade = objRow[conBigConcept.IdGrade].ToString().Trim(); //年级流水号
objBigConceptEN.SchoolTerm = objRow[conBigConcept.SchoolTerm].ToString().Trim(); //学期
objBigConceptEN.CourseId = objRow[conBigConcept.CourseId].ToString().Trim(); //课程Id
objBigConceptEN.IsClgCheck = clsEntityBase2.TransNullToBool_S(objRow[conBigConcept.IsClgCheck].ToString().Trim()); //是否学院审批
objBigConceptEN.ClgNote = objRow[conBigConcept.ClgNote] == DBNull.Value ? null : objRow[conBigConcept.ClgNote].ToString().Trim(); //学院审批意见
objBigConceptEN.ClgCheckerId = objRow[conBigConcept.ClgCheckerId] == DBNull.Value ? null : objRow[conBigConcept.ClgCheckerId].ToString().Trim(); //学院审批人id
objBigConceptEN.ClgCheckDate = objRow[conBigConcept.ClgCheckDate] == DBNull.Value ? null : objRow[conBigConcept.ClgCheckDate].ToString().Trim(); //学院审批日期
objBigConceptEN.IsSchCheck = clsEntityBase2.TransNullToBool_S(objRow[conBigConcept.IsSchCheck].ToString().Trim()); //是否学校审批
objBigConceptEN.SchNote = objRow[conBigConcept.SchNote] == DBNull.Value ? null : objRow[conBigConcept.SchNote].ToString().Trim(); //学校审批意见
objBigConceptEN.SchCheckerId = objRow[conBigConcept.SchCheckerId] == DBNull.Value ? null : objRow[conBigConcept.SchCheckerId].ToString().Trim(); //学校审批人Id
objBigConceptEN.SchCheckDate = objRow[conBigConcept.SchCheckDate] == DBNull.Value ? null : objRow[conBigConcept.SchCheckDate].ToString().Trim(); //学校审批日期
objBigConceptEN.IdSubmitStatus = objRow[conBigConcept.IdSubmitStatus].ToString().Trim(); //送审状态流水号
objBigConceptEN.Memo = objRow[conBigConcept.Memo] == DBNull.Value ? null : objRow[conBigConcept.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objBigConceptEN.IdBigConcept, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objBigConceptEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objBigConceptCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsBigConceptEN> GetSubObjLstCache(clsBigConceptEN objBigConceptCond)
{
List<clsBigConceptEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsBigConceptEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conBigConcept.AttributeName)
{
if (objBigConceptCond.IsUpdated(strFldName) == false) continue;
if (objBigConceptCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objBigConceptCond[strFldName].ToString());
}
else
{
if (objBigConceptCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objBigConceptCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objBigConceptCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objBigConceptCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objBigConceptCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objBigConceptCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objBigConceptCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objBigConceptCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objBigConceptCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objBigConceptCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objBigConceptCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objBigConceptCond[strFldName]));
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
public static List<clsBigConceptEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsBigConceptEN> arrObjLst = new List<clsBigConceptEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsBigConceptEN objBigConceptEN = new clsBigConceptEN();
try
{
objBigConceptEN.IdBigConcept = objRow[conBigConcept.IdBigConcept].ToString().Trim(); //大概念流水号
objBigConceptEN.BigConceptId = objRow[conBigConcept.BigConceptId].ToString().Trim(); //大概念编号
objBigConceptEN.BigConceptName = objRow[conBigConcept.BigConceptName].ToString().Trim(); //大概念名称
objBigConceptEN.IdGrade = objRow[conBigConcept.IdGrade].ToString().Trim(); //年级流水号
objBigConceptEN.SchoolTerm = objRow[conBigConcept.SchoolTerm].ToString().Trim(); //学期
objBigConceptEN.CourseId = objRow[conBigConcept.CourseId].ToString().Trim(); //课程Id
objBigConceptEN.IsClgCheck = clsEntityBase2.TransNullToBool_S(objRow[conBigConcept.IsClgCheck].ToString().Trim()); //是否学院审批
objBigConceptEN.ClgNote = objRow[conBigConcept.ClgNote] == DBNull.Value ? null : objRow[conBigConcept.ClgNote].ToString().Trim(); //学院审批意见
objBigConceptEN.ClgCheckerId = objRow[conBigConcept.ClgCheckerId] == DBNull.Value ? null : objRow[conBigConcept.ClgCheckerId].ToString().Trim(); //学院审批人id
objBigConceptEN.ClgCheckDate = objRow[conBigConcept.ClgCheckDate] == DBNull.Value ? null : objRow[conBigConcept.ClgCheckDate].ToString().Trim(); //学院审批日期
objBigConceptEN.IsSchCheck = clsEntityBase2.TransNullToBool_S(objRow[conBigConcept.IsSchCheck].ToString().Trim()); //是否学校审批
objBigConceptEN.SchNote = objRow[conBigConcept.SchNote] == DBNull.Value ? null : objRow[conBigConcept.SchNote].ToString().Trim(); //学校审批意见
objBigConceptEN.SchCheckerId = objRow[conBigConcept.SchCheckerId] == DBNull.Value ? null : objRow[conBigConcept.SchCheckerId].ToString().Trim(); //学校审批人Id
objBigConceptEN.SchCheckDate = objRow[conBigConcept.SchCheckDate] == DBNull.Value ? null : objRow[conBigConcept.SchCheckDate].ToString().Trim(); //学校审批日期
objBigConceptEN.IdSubmitStatus = objRow[conBigConcept.IdSubmitStatus].ToString().Trim(); //送审状态流水号
objBigConceptEN.Memo = objRow[conBigConcept.Memo] == DBNull.Value ? null : objRow[conBigConcept.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objBigConceptEN.IdBigConcept, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objBigConceptEN);
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
public static List<clsBigConceptEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsBigConceptEN> arrObjLst = new List<clsBigConceptEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsBigConceptEN objBigConceptEN = new clsBigConceptEN();
try
{
objBigConceptEN.IdBigConcept = objRow[conBigConcept.IdBigConcept].ToString().Trim(); //大概念流水号
objBigConceptEN.BigConceptId = objRow[conBigConcept.BigConceptId].ToString().Trim(); //大概念编号
objBigConceptEN.BigConceptName = objRow[conBigConcept.BigConceptName].ToString().Trim(); //大概念名称
objBigConceptEN.IdGrade = objRow[conBigConcept.IdGrade].ToString().Trim(); //年级流水号
objBigConceptEN.SchoolTerm = objRow[conBigConcept.SchoolTerm].ToString().Trim(); //学期
objBigConceptEN.CourseId = objRow[conBigConcept.CourseId].ToString().Trim(); //课程Id
objBigConceptEN.IsClgCheck = clsEntityBase2.TransNullToBool_S(objRow[conBigConcept.IsClgCheck].ToString().Trim()); //是否学院审批
objBigConceptEN.ClgNote = objRow[conBigConcept.ClgNote] == DBNull.Value ? null : objRow[conBigConcept.ClgNote].ToString().Trim(); //学院审批意见
objBigConceptEN.ClgCheckerId = objRow[conBigConcept.ClgCheckerId] == DBNull.Value ? null : objRow[conBigConcept.ClgCheckerId].ToString().Trim(); //学院审批人id
objBigConceptEN.ClgCheckDate = objRow[conBigConcept.ClgCheckDate] == DBNull.Value ? null : objRow[conBigConcept.ClgCheckDate].ToString().Trim(); //学院审批日期
objBigConceptEN.IsSchCheck = clsEntityBase2.TransNullToBool_S(objRow[conBigConcept.IsSchCheck].ToString().Trim()); //是否学校审批
objBigConceptEN.SchNote = objRow[conBigConcept.SchNote] == DBNull.Value ? null : objRow[conBigConcept.SchNote].ToString().Trim(); //学校审批意见
objBigConceptEN.SchCheckerId = objRow[conBigConcept.SchCheckerId] == DBNull.Value ? null : objRow[conBigConcept.SchCheckerId].ToString().Trim(); //学校审批人Id
objBigConceptEN.SchCheckDate = objRow[conBigConcept.SchCheckDate] == DBNull.Value ? null : objRow[conBigConcept.SchCheckDate].ToString().Trim(); //学校审批日期
objBigConceptEN.IdSubmitStatus = objRow[conBigConcept.IdSubmitStatus].ToString().Trim(); //送审状态流水号
objBigConceptEN.Memo = objRow[conBigConcept.Memo] == DBNull.Value ? null : objRow[conBigConcept.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objBigConceptEN.IdBigConcept, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objBigConceptEN);
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
List<clsBigConceptEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsBigConceptEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsBigConceptEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsBigConceptEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsBigConceptEN> arrObjLst = new List<clsBigConceptEN>(); 
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
	clsBigConceptEN objBigConceptEN = new clsBigConceptEN();
try
{
objBigConceptEN.IdBigConcept = objRow[conBigConcept.IdBigConcept].ToString().Trim(); //大概念流水号
objBigConceptEN.BigConceptId = objRow[conBigConcept.BigConceptId].ToString().Trim(); //大概念编号
objBigConceptEN.BigConceptName = objRow[conBigConcept.BigConceptName].ToString().Trim(); //大概念名称
objBigConceptEN.IdGrade = objRow[conBigConcept.IdGrade].ToString().Trim(); //年级流水号
objBigConceptEN.SchoolTerm = objRow[conBigConcept.SchoolTerm].ToString().Trim(); //学期
objBigConceptEN.CourseId = objRow[conBigConcept.CourseId].ToString().Trim(); //课程Id
objBigConceptEN.IsClgCheck = clsEntityBase2.TransNullToBool_S(objRow[conBigConcept.IsClgCheck].ToString().Trim()); //是否学院审批
objBigConceptEN.ClgNote = objRow[conBigConcept.ClgNote] == DBNull.Value ? null : objRow[conBigConcept.ClgNote].ToString().Trim(); //学院审批意见
objBigConceptEN.ClgCheckerId = objRow[conBigConcept.ClgCheckerId] == DBNull.Value ? null : objRow[conBigConcept.ClgCheckerId].ToString().Trim(); //学院审批人id
objBigConceptEN.ClgCheckDate = objRow[conBigConcept.ClgCheckDate] == DBNull.Value ? null : objRow[conBigConcept.ClgCheckDate].ToString().Trim(); //学院审批日期
objBigConceptEN.IsSchCheck = clsEntityBase2.TransNullToBool_S(objRow[conBigConcept.IsSchCheck].ToString().Trim()); //是否学校审批
objBigConceptEN.SchNote = objRow[conBigConcept.SchNote] == DBNull.Value ? null : objRow[conBigConcept.SchNote].ToString().Trim(); //学校审批意见
objBigConceptEN.SchCheckerId = objRow[conBigConcept.SchCheckerId] == DBNull.Value ? null : objRow[conBigConcept.SchCheckerId].ToString().Trim(); //学校审批人Id
objBigConceptEN.SchCheckDate = objRow[conBigConcept.SchCheckDate] == DBNull.Value ? null : objRow[conBigConcept.SchCheckDate].ToString().Trim(); //学校审批日期
objBigConceptEN.IdSubmitStatus = objRow[conBigConcept.IdSubmitStatus].ToString().Trim(); //送审状态流水号
objBigConceptEN.Memo = objRow[conBigConcept.Memo] == DBNull.Value ? null : objRow[conBigConcept.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objBigConceptEN.IdBigConcept, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objBigConceptEN);
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
public static List<clsBigConceptEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsBigConceptEN> arrObjLst = new List<clsBigConceptEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsBigConceptEN objBigConceptEN = new clsBigConceptEN();
try
{
objBigConceptEN.IdBigConcept = objRow[conBigConcept.IdBigConcept].ToString().Trim(); //大概念流水号
objBigConceptEN.BigConceptId = objRow[conBigConcept.BigConceptId].ToString().Trim(); //大概念编号
objBigConceptEN.BigConceptName = objRow[conBigConcept.BigConceptName].ToString().Trim(); //大概念名称
objBigConceptEN.IdGrade = objRow[conBigConcept.IdGrade].ToString().Trim(); //年级流水号
objBigConceptEN.SchoolTerm = objRow[conBigConcept.SchoolTerm].ToString().Trim(); //学期
objBigConceptEN.CourseId = objRow[conBigConcept.CourseId].ToString().Trim(); //课程Id
objBigConceptEN.IsClgCheck = clsEntityBase2.TransNullToBool_S(objRow[conBigConcept.IsClgCheck].ToString().Trim()); //是否学院审批
objBigConceptEN.ClgNote = objRow[conBigConcept.ClgNote] == DBNull.Value ? null : objRow[conBigConcept.ClgNote].ToString().Trim(); //学院审批意见
objBigConceptEN.ClgCheckerId = objRow[conBigConcept.ClgCheckerId] == DBNull.Value ? null : objRow[conBigConcept.ClgCheckerId].ToString().Trim(); //学院审批人id
objBigConceptEN.ClgCheckDate = objRow[conBigConcept.ClgCheckDate] == DBNull.Value ? null : objRow[conBigConcept.ClgCheckDate].ToString().Trim(); //学院审批日期
objBigConceptEN.IsSchCheck = clsEntityBase2.TransNullToBool_S(objRow[conBigConcept.IsSchCheck].ToString().Trim()); //是否学校审批
objBigConceptEN.SchNote = objRow[conBigConcept.SchNote] == DBNull.Value ? null : objRow[conBigConcept.SchNote].ToString().Trim(); //学校审批意见
objBigConceptEN.SchCheckerId = objRow[conBigConcept.SchCheckerId] == DBNull.Value ? null : objRow[conBigConcept.SchCheckerId].ToString().Trim(); //学校审批人Id
objBigConceptEN.SchCheckDate = objRow[conBigConcept.SchCheckDate] == DBNull.Value ? null : objRow[conBigConcept.SchCheckDate].ToString().Trim(); //学校审批日期
objBigConceptEN.IdSubmitStatus = objRow[conBigConcept.IdSubmitStatus].ToString().Trim(); //送审状态流水号
objBigConceptEN.Memo = objRow[conBigConcept.Memo] == DBNull.Value ? null : objRow[conBigConcept.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objBigConceptEN.IdBigConcept, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objBigConceptEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsBigConceptEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsBigConceptEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsBigConceptEN> arrObjLst = new List<clsBigConceptEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsBigConceptEN objBigConceptEN = new clsBigConceptEN();
try
{
objBigConceptEN.IdBigConcept = objRow[conBigConcept.IdBigConcept].ToString().Trim(); //大概念流水号
objBigConceptEN.BigConceptId = objRow[conBigConcept.BigConceptId].ToString().Trim(); //大概念编号
objBigConceptEN.BigConceptName = objRow[conBigConcept.BigConceptName].ToString().Trim(); //大概念名称
objBigConceptEN.IdGrade = objRow[conBigConcept.IdGrade].ToString().Trim(); //年级流水号
objBigConceptEN.SchoolTerm = objRow[conBigConcept.SchoolTerm].ToString().Trim(); //学期
objBigConceptEN.CourseId = objRow[conBigConcept.CourseId].ToString().Trim(); //课程Id
objBigConceptEN.IsClgCheck = clsEntityBase2.TransNullToBool_S(objRow[conBigConcept.IsClgCheck].ToString().Trim()); //是否学院审批
objBigConceptEN.ClgNote = objRow[conBigConcept.ClgNote] == DBNull.Value ? null : objRow[conBigConcept.ClgNote].ToString().Trim(); //学院审批意见
objBigConceptEN.ClgCheckerId = objRow[conBigConcept.ClgCheckerId] == DBNull.Value ? null : objRow[conBigConcept.ClgCheckerId].ToString().Trim(); //学院审批人id
objBigConceptEN.ClgCheckDate = objRow[conBigConcept.ClgCheckDate] == DBNull.Value ? null : objRow[conBigConcept.ClgCheckDate].ToString().Trim(); //学院审批日期
objBigConceptEN.IsSchCheck = clsEntityBase2.TransNullToBool_S(objRow[conBigConcept.IsSchCheck].ToString().Trim()); //是否学校审批
objBigConceptEN.SchNote = objRow[conBigConcept.SchNote] == DBNull.Value ? null : objRow[conBigConcept.SchNote].ToString().Trim(); //学校审批意见
objBigConceptEN.SchCheckerId = objRow[conBigConcept.SchCheckerId] == DBNull.Value ? null : objRow[conBigConcept.SchCheckerId].ToString().Trim(); //学校审批人Id
objBigConceptEN.SchCheckDate = objRow[conBigConcept.SchCheckDate] == DBNull.Value ? null : objRow[conBigConcept.SchCheckDate].ToString().Trim(); //学校审批日期
objBigConceptEN.IdSubmitStatus = objRow[conBigConcept.IdSubmitStatus].ToString().Trim(); //送审状态流水号
objBigConceptEN.Memo = objRow[conBigConcept.Memo] == DBNull.Value ? null : objRow[conBigConcept.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objBigConceptEN.IdBigConcept, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objBigConceptEN);
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
public static List<clsBigConceptEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsBigConceptEN> arrObjLst = new List<clsBigConceptEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsBigConceptEN objBigConceptEN = new clsBigConceptEN();
try
{
objBigConceptEN.IdBigConcept = objRow[conBigConcept.IdBigConcept].ToString().Trim(); //大概念流水号
objBigConceptEN.BigConceptId = objRow[conBigConcept.BigConceptId].ToString().Trim(); //大概念编号
objBigConceptEN.BigConceptName = objRow[conBigConcept.BigConceptName].ToString().Trim(); //大概念名称
objBigConceptEN.IdGrade = objRow[conBigConcept.IdGrade].ToString().Trim(); //年级流水号
objBigConceptEN.SchoolTerm = objRow[conBigConcept.SchoolTerm].ToString().Trim(); //学期
objBigConceptEN.CourseId = objRow[conBigConcept.CourseId].ToString().Trim(); //课程Id
objBigConceptEN.IsClgCheck = clsEntityBase2.TransNullToBool_S(objRow[conBigConcept.IsClgCheck].ToString().Trim()); //是否学院审批
objBigConceptEN.ClgNote = objRow[conBigConcept.ClgNote] == DBNull.Value ? null : objRow[conBigConcept.ClgNote].ToString().Trim(); //学院审批意见
objBigConceptEN.ClgCheckerId = objRow[conBigConcept.ClgCheckerId] == DBNull.Value ? null : objRow[conBigConcept.ClgCheckerId].ToString().Trim(); //学院审批人id
objBigConceptEN.ClgCheckDate = objRow[conBigConcept.ClgCheckDate] == DBNull.Value ? null : objRow[conBigConcept.ClgCheckDate].ToString().Trim(); //学院审批日期
objBigConceptEN.IsSchCheck = clsEntityBase2.TransNullToBool_S(objRow[conBigConcept.IsSchCheck].ToString().Trim()); //是否学校审批
objBigConceptEN.SchNote = objRow[conBigConcept.SchNote] == DBNull.Value ? null : objRow[conBigConcept.SchNote].ToString().Trim(); //学校审批意见
objBigConceptEN.SchCheckerId = objRow[conBigConcept.SchCheckerId] == DBNull.Value ? null : objRow[conBigConcept.SchCheckerId].ToString().Trim(); //学校审批人Id
objBigConceptEN.SchCheckDate = objRow[conBigConcept.SchCheckDate] == DBNull.Value ? null : objRow[conBigConcept.SchCheckDate].ToString().Trim(); //学校审批日期
objBigConceptEN.IdSubmitStatus = objRow[conBigConcept.IdSubmitStatus].ToString().Trim(); //送审状态流水号
objBigConceptEN.Memo = objRow[conBigConcept.Memo] == DBNull.Value ? null : objRow[conBigConcept.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objBigConceptEN.IdBigConcept, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objBigConceptEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsBigConceptEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsBigConceptEN> arrObjLst = new List<clsBigConceptEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsBigConceptEN objBigConceptEN = new clsBigConceptEN();
try
{
objBigConceptEN.IdBigConcept = objRow[conBigConcept.IdBigConcept].ToString().Trim(); //大概念流水号
objBigConceptEN.BigConceptId = objRow[conBigConcept.BigConceptId].ToString().Trim(); //大概念编号
objBigConceptEN.BigConceptName = objRow[conBigConcept.BigConceptName].ToString().Trim(); //大概念名称
objBigConceptEN.IdGrade = objRow[conBigConcept.IdGrade].ToString().Trim(); //年级流水号
objBigConceptEN.SchoolTerm = objRow[conBigConcept.SchoolTerm].ToString().Trim(); //学期
objBigConceptEN.CourseId = objRow[conBigConcept.CourseId].ToString().Trim(); //课程Id
objBigConceptEN.IsClgCheck = clsEntityBase2.TransNullToBool_S(objRow[conBigConcept.IsClgCheck].ToString().Trim()); //是否学院审批
objBigConceptEN.ClgNote = objRow[conBigConcept.ClgNote] == DBNull.Value ? null : objRow[conBigConcept.ClgNote].ToString().Trim(); //学院审批意见
objBigConceptEN.ClgCheckerId = objRow[conBigConcept.ClgCheckerId] == DBNull.Value ? null : objRow[conBigConcept.ClgCheckerId].ToString().Trim(); //学院审批人id
objBigConceptEN.ClgCheckDate = objRow[conBigConcept.ClgCheckDate] == DBNull.Value ? null : objRow[conBigConcept.ClgCheckDate].ToString().Trim(); //学院审批日期
objBigConceptEN.IsSchCheck = clsEntityBase2.TransNullToBool_S(objRow[conBigConcept.IsSchCheck].ToString().Trim()); //是否学校审批
objBigConceptEN.SchNote = objRow[conBigConcept.SchNote] == DBNull.Value ? null : objRow[conBigConcept.SchNote].ToString().Trim(); //学校审批意见
objBigConceptEN.SchCheckerId = objRow[conBigConcept.SchCheckerId] == DBNull.Value ? null : objRow[conBigConcept.SchCheckerId].ToString().Trim(); //学校审批人Id
objBigConceptEN.SchCheckDate = objRow[conBigConcept.SchCheckDate] == DBNull.Value ? null : objRow[conBigConcept.SchCheckDate].ToString().Trim(); //学校审批日期
objBigConceptEN.IdSubmitStatus = objRow[conBigConcept.IdSubmitStatus].ToString().Trim(); //送审状态流水号
objBigConceptEN.Memo = objRow[conBigConcept.Memo] == DBNull.Value ? null : objRow[conBigConcept.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objBigConceptEN.IdBigConcept, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objBigConceptEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objBigConceptEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetBigConcept(ref clsBigConceptEN objBigConceptEN)
{
bool bolResult = BigConceptDA.GetBigConcept(ref objBigConceptEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "strIdBigConcept">表关键字</param>
 /// <returns>表对象</returns>
public static clsBigConceptEN GetObjByIdBigConcept(string strIdBigConcept)
{
if (strIdBigConcept.IndexOf(' ') >=0)
{
var strMsg = string.Format("(errid:Busi000079)在表中,关键字[strIdBigConcept]中不能有空格!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
if (string.IsNullOrEmpty(strIdBigConcept) == true)
{
var strMsg = string.Format("(errid:Busi000020)在表中,关键字[strIdBigConcept]不能为空!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
clsBigConceptEN objBigConceptEN = BigConceptDA.GetObjByIdBigConcept(strIdBigConcept);
return objBigConceptEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsBigConceptEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsBigConceptEN objBigConceptEN = BigConceptDA.GetFirstObj(strWhereCond);
 return objBigConceptEN;
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
public static clsBigConceptEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsBigConceptEN objBigConceptEN = BigConceptDA.GetObjByDataRow(objRow);
 return objBigConceptEN;
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
public static clsBigConceptEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsBigConceptEN objBigConceptEN = BigConceptDA.GetObjByDataRow(objRow);
 return objBigConceptEN;
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
 /// <param name = "strIdBigConcept">所给的关键字</param>
 /// <param name = "lstBigConceptObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsBigConceptEN GetObjByIdBigConceptFromList(string strIdBigConcept, List<clsBigConceptEN> lstBigConceptObjLst)
{
foreach (clsBigConceptEN objBigConceptEN in lstBigConceptObjLst)
{
if (objBigConceptEN.IdBigConcept == strIdBigConcept)
{
return objBigConceptEN;
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
 string strMaxIdBigConcept;
 try
 {
 strMaxIdBigConcept = clsBigConceptDA.GetMaxStrId();
 return strMaxIdBigConcept;
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
 string strIdBigConcept;
 try
 {
 strIdBigConcept = new clsBigConceptDA().GetFirstID(strWhereCond);
 return strIdBigConcept;
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
 arrList = BigConceptDA.GetID(strWhereCond);
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
bool bolIsExist = BigConceptDA.IsExistCondRec(strWhereCond);
return bolIsExist;
}

 /// <summary>
 /// 判断当前表中是否存在给定关键字值的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExist)
 /// </summary>
 /// <param name = "strIdBigConcept">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public static bool IsExist(string strIdBigConcept)
{
if (string.IsNullOrEmpty(strIdBigConcept) == true)
{
var strMsg = string.Format("(errid:Busi000027)在表中,关键字[strIdBigConcept]不能为空!!(from {0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
//检测记录是否存在
bool bolIsExist = BigConceptDA.IsExist(strIdBigConcept);
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
 bolIsExist = clsBigConceptDA.IsExistTable();
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
 bolIsExist = BigConceptDA.IsExistTable(strTabName);
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
 /// <param name = "objBigConceptEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecordBySql2(clsBigConceptEN objBigConceptEN, bool bolIsNeedCheckUniqueness=true)
{
if (bolIsNeedCheckUniqueness == true && objBigConceptEN.CheckUniqueness() == false)
{
var strMsg = string.Format("记录已经存在!大概念名称 = [{0}],年级流水号 = [{1}]的数据已经存在!(in clsBigConceptBL.AddNewRecordBySql2)", objBigConceptEN.BigConceptName,objBigConceptEN.IdGrade);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objBigConceptEN.IdBigConcept) == true || clsBigConceptBL.IsExist(objBigConceptEN.IdBigConcept) == true)
 {
     objBigConceptEN.IdBigConcept = clsBigConceptBL.GetMaxStrId_S();
 }
bool bolResult = BigConceptDA.AddNewRecordBySQL2(objBigConceptEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsBigConceptBL.ReFreshCache();

if (clsBigConceptBL.relatedActions != null)
{
clsBigConceptBL.relatedActions.UpdRelaTabDate(objBigConceptEN.IdBigConcept, "SetUpdDate");
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
 /// <param name = "objBigConceptEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordBySql2WithReturnKey(clsBigConceptEN objBigConceptEN, bool bolIsNeedCheckUniqueness=true)
{
if (bolIsNeedCheckUniqueness == true && objBigConceptEN.CheckUniqueness() == false)
{
var strMsg = string.Format("记录已经存在!大概念名称 = [{0}],年级流水号 = [{1}]的数据已经存在!(in clsBigConceptBL.AddNewRecordBySql2WithReturnKey)", objBigConceptEN.BigConceptName,objBigConceptEN.IdGrade);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objBigConceptEN.IdBigConcept) == true || clsBigConceptBL.IsExist(objBigConceptEN.IdBigConcept) == true)
 {
     objBigConceptEN.IdBigConcept = clsBigConceptBL.GetMaxStrId_S();
 }
string strKey = BigConceptDA.AddNewRecordBySQL2WithReturnKey(objBigConceptEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsBigConceptBL.ReFreshCache();

if (clsBigConceptBL.relatedActions != null)
{
clsBigConceptBL.relatedActions.UpdRelaTabDate(objBigConceptEN.IdBigConcept, "SetUpdDate");
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
 /// <param name = "objBigConceptEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(clsBigConceptEN objBigConceptEN)
{
try
{
bool bolResult = BigConceptDA.Update(objBigConceptEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsBigConceptBL.ReFreshCache();

if (clsBigConceptBL.relatedActions != null)
{
clsBigConceptBL.relatedActions.UpdRelaTabDate(objBigConceptEN.IdBigConcept, "SetUpdDate");
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
 /// <param name = "objBigConceptEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateBySql2(clsBigConceptEN objBigConceptEN)
{
 if (string.IsNullOrEmpty(objBigConceptEN.IdBigConcept) == true)
 {
var strMsg = string.Format("(errid:Busi000065)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = BigConceptDA.UpdateBySql2(objBigConceptEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsBigConceptBL.ReFreshCache();

if (clsBigConceptBL.relatedActions != null)
{
clsBigConceptBL.relatedActions.UpdRelaTabDate(objBigConceptEN.IdBigConcept, "SetUpdDate");
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
 /// <param name = "strIdBigConcept">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int DelRecord(string strIdBigConcept)
{
try
{
 clsBigConceptEN objBigConceptEN = clsBigConceptBL.GetObjByIdBigConcept(strIdBigConcept);

if (clsBigConceptBL.relatedActions != null)
{
clsBigConceptBL.relatedActions.UpdRelaTabDate(objBigConceptEN.IdBigConcept, "SetUpdDate");
}
if (objBigConceptEN != null)
{
int intRecNum = BigConceptDA.DelRecord(strIdBigConcept);
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
/// <param name="strIdBigConcept">表关键字</param>
/// <returns></returns>
public static bool DelRecordEx(string strIdBigConcept )
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsBigConceptDA.GetSpecSQLObj();
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
//删除与表:[BigConcept]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conBigConcept.IdBigConcept,
//strIdBigConcept);
//        clsBigConceptBL.DelBigConceptsByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsBigConceptBL.DelRecord(strIdBigConcept, objConnection, objSqlTransaction);
objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsBigConceptBLEx", "DelRecordEx", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("扩展删除记录出错:{0}!keyId = {1}.({2})",
objException.Message,
strIdBigConcept, clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "strIdBigConcept">给定的关键字值</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回删除是否成功?</returns>
public static bool DelRecord(string strIdBigConcept, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
if (clsBigConceptBL.relatedActions != null)
{
clsBigConceptBL.relatedActions.UpdRelaTabDate(strIdBigConcept, "UpdRelaTabDate");
}
bool bolResult = BigConceptDA.DelRecord(strIdBigConcept,objSqlConnection,objSqlTransaction);
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
 /// <param name = "arrIdBigConceptLst">给定的关键字值列表</param>
 /// <returns>返回删除的记录数</returns>
public static int DelBigConcepts(List<string> arrIdBigConceptLst)
{
if (arrIdBigConceptLst.Count == 0) return 0;
try
{
if (clsBigConceptBL.relatedActions != null)
{
foreach (var strIdBigConcept in arrIdBigConceptLst)
{
clsBigConceptBL.relatedActions.UpdRelaTabDate(strIdBigConcept, "UpdRelaTabDate");
}
}
int intDelRecNum = BigConceptDA.DelBigConcept(arrIdBigConceptLst);
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
public static int DelBigConceptsByCond(string strWhereCond)
{
try
{
if (clsBigConceptBL.relatedActions != null)
{
List<string> arrIdBigConcept = GetPrimaryKeyID_S(strWhereCond);
foreach (var strIdBigConcept in arrIdBigConcept)
{
clsBigConceptBL.relatedActions.UpdRelaTabDate(strIdBigConcept, "UpdRelaTabDate");
}
}
int intRecNum = BigConceptDA.DelBigConcept(strWhereCond);
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
/// 这里仅仅是演示函数,使用时请复制到扩展类:[BigConcept]中改名为:[DelRecord4MultiTabEx]使用
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DelRecord4MultiTab)
/// </summary>
/// <param name="strIdBigConcept">表关键字</param>
/// <returns></returns>
public static bool DelRecord4MultiTab(string strIdBigConcept)
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsBigConceptDA.GetSpecSQLObj();
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
//删除与表:[BigConcept]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conStudent.id_College,
//strid_College);
//        clsStudentBL.DelStudentsByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsBigConceptBL.DelRecord(strIdBigConcept, objConnection, objSqlTransaction);
                objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsBigConceptBL", "DelRecord4MultiTab", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("删除多表记录出错:{0}!keyId = {1}.({2})",
objException.Message,
strIdBigConcept, clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "objBigConceptENS">源对象</param>
 /// <param name = "objBigConceptENT">目标对象</param>
 public static void CopyTo(clsBigConceptEN objBigConceptENS, clsBigConceptEN objBigConceptENT)
{
try
{
objBigConceptENT.IdBigConcept = objBigConceptENS.IdBigConcept; //大概念流水号
objBigConceptENT.BigConceptId = objBigConceptENS.BigConceptId; //大概念编号
objBigConceptENT.BigConceptName = objBigConceptENS.BigConceptName; //大概念名称
objBigConceptENT.IdGrade = objBigConceptENS.IdGrade; //年级流水号
objBigConceptENT.SchoolTerm = objBigConceptENS.SchoolTerm; //学期
objBigConceptENT.CourseId = objBigConceptENS.CourseId; //课程Id
objBigConceptENT.IsClgCheck = objBigConceptENS.IsClgCheck; //是否学院审批
objBigConceptENT.ClgNote = objBigConceptENS.ClgNote; //学院审批意见
objBigConceptENT.ClgCheckerId = objBigConceptENS.ClgCheckerId; //学院审批人id
objBigConceptENT.ClgCheckDate = objBigConceptENS.ClgCheckDate; //学院审批日期
objBigConceptENT.IsSchCheck = objBigConceptENS.IsSchCheck; //是否学校审批
objBigConceptENT.SchNote = objBigConceptENS.SchNote; //学校审批意见
objBigConceptENT.SchCheckerId = objBigConceptENS.SchCheckerId; //学校审批人Id
objBigConceptENT.SchCheckDate = objBigConceptENS.SchCheckDate; //学校审批日期
objBigConceptENT.IdSubmitStatus = objBigConceptENS.IdSubmitStatus; //送审状态流水号
objBigConceptENT.Memo = objBigConceptENS.Memo; //备注
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
 /// <param name = "objBigConceptEN">源简化对象</param>
 public static void SetUpdFlag(clsBigConceptEN objBigConceptEN)
{
try
{
objBigConceptEN.ClearUpdateState();
   string strsfUpdFldSetStr = objBigConceptEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(conBigConcept.IdBigConcept, new clsStrCompareIgnoreCase())  ==  true)
{
objBigConceptEN.IdBigConcept = objBigConceptEN.IdBigConcept; //大概念流水号
}
if (arrFldSet.Contains(conBigConcept.BigConceptId, new clsStrCompareIgnoreCase())  ==  true)
{
objBigConceptEN.BigConceptId = objBigConceptEN.BigConceptId; //大概念编号
}
if (arrFldSet.Contains(conBigConcept.BigConceptName, new clsStrCompareIgnoreCase())  ==  true)
{
objBigConceptEN.BigConceptName = objBigConceptEN.BigConceptName; //大概念名称
}
if (arrFldSet.Contains(conBigConcept.IdGrade, new clsStrCompareIgnoreCase())  ==  true)
{
objBigConceptEN.IdGrade = objBigConceptEN.IdGrade; //年级流水号
}
if (arrFldSet.Contains(conBigConcept.SchoolTerm, new clsStrCompareIgnoreCase())  ==  true)
{
objBigConceptEN.SchoolTerm = objBigConceptEN.SchoolTerm; //学期
}
if (arrFldSet.Contains(conBigConcept.CourseId, new clsStrCompareIgnoreCase())  ==  true)
{
objBigConceptEN.CourseId = objBigConceptEN.CourseId; //课程Id
}
if (arrFldSet.Contains(conBigConcept.IsClgCheck, new clsStrCompareIgnoreCase())  ==  true)
{
objBigConceptEN.IsClgCheck = objBigConceptEN.IsClgCheck; //是否学院审批
}
if (arrFldSet.Contains(conBigConcept.ClgNote, new clsStrCompareIgnoreCase())  ==  true)
{
objBigConceptEN.ClgNote = objBigConceptEN.ClgNote == "[null]" ? null :  objBigConceptEN.ClgNote; //学院审批意见
}
if (arrFldSet.Contains(conBigConcept.ClgCheckerId, new clsStrCompareIgnoreCase())  ==  true)
{
objBigConceptEN.ClgCheckerId = objBigConceptEN.ClgCheckerId == "[null]" ? null :  objBigConceptEN.ClgCheckerId; //学院审批人id
}
if (arrFldSet.Contains(conBigConcept.ClgCheckDate, new clsStrCompareIgnoreCase())  ==  true)
{
objBigConceptEN.ClgCheckDate = objBigConceptEN.ClgCheckDate == "[null]" ? null :  objBigConceptEN.ClgCheckDate; //学院审批日期
}
if (arrFldSet.Contains(conBigConcept.IsSchCheck, new clsStrCompareIgnoreCase())  ==  true)
{
objBigConceptEN.IsSchCheck = objBigConceptEN.IsSchCheck; //是否学校审批
}
if (arrFldSet.Contains(conBigConcept.SchNote, new clsStrCompareIgnoreCase())  ==  true)
{
objBigConceptEN.SchNote = objBigConceptEN.SchNote == "[null]" ? null :  objBigConceptEN.SchNote; //学校审批意见
}
if (arrFldSet.Contains(conBigConcept.SchCheckerId, new clsStrCompareIgnoreCase())  ==  true)
{
objBigConceptEN.SchCheckerId = objBigConceptEN.SchCheckerId == "[null]" ? null :  objBigConceptEN.SchCheckerId; //学校审批人Id
}
if (arrFldSet.Contains(conBigConcept.SchCheckDate, new clsStrCompareIgnoreCase())  ==  true)
{
objBigConceptEN.SchCheckDate = objBigConceptEN.SchCheckDate == "[null]" ? null :  objBigConceptEN.SchCheckDate; //学校审批日期
}
if (arrFldSet.Contains(conBigConcept.IdSubmitStatus, new clsStrCompareIgnoreCase())  ==  true)
{
objBigConceptEN.IdSubmitStatus = objBigConceptEN.IdSubmitStatus; //送审状态流水号
}
if (arrFldSet.Contains(conBigConcept.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objBigConceptEN.Memo = objBigConceptEN.Memo == "[null]" ? null :  objBigConceptEN.Memo; //备注
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
 /// <param name = "objBigConceptEN">源简化对象</param>
 public static void AccessFldValueNull(clsBigConceptEN objBigConceptEN)
{
try
{
if (objBigConceptEN.ClgNote == "[null]") objBigConceptEN.ClgNote = null; //学院审批意见
if (objBigConceptEN.ClgCheckerId == "[null]") objBigConceptEN.ClgCheckerId = null; //学院审批人id
if (objBigConceptEN.ClgCheckDate == "[null]") objBigConceptEN.ClgCheckDate = null; //学院审批日期
if (objBigConceptEN.SchNote == "[null]") objBigConceptEN.SchNote = null; //学校审批意见
if (objBigConceptEN.SchCheckerId == "[null]") objBigConceptEN.SchCheckerId = null; //学校审批人Id
if (objBigConceptEN.SchCheckDate == "[null]") objBigConceptEN.SchCheckDate = null; //学校审批日期
if (objBigConceptEN.Memo == "[null]") objBigConceptEN.Memo = null; //备注
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
public static void CheckPropertyNew(clsBigConceptEN objBigConceptEN)
{
 BigConceptDA.CheckPropertyNew(objBigConceptEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(clsBigConceptEN objBigConceptEN)
{
 BigConceptDA.CheckProperty4Condition(objBigConceptEN);
 }


 #endregion 检查对象属性


 #region 绑定下拉框

 /// <summary>
 /// 绑定基于Web的下拉框-使用Cache
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DdlBindFunctionCache)
 /// </summary>
 /// <param name = "objDDL">需要绑定当前表的下拉框</param>
public static void BindDdl_IdBigConceptCache(System.Web.UI.WebControls.DropDownList objDDL)
{
//为数据源于表的下拉框设置内容
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[大概念]...","0");
List<clsBigConceptEN> arrBigConceptObjLst = GetAllBigConceptObjLstCache(); 
objDDL.DataValueField = conBigConcept.IdBigConcept;
objDDL.DataTextField = conBigConcept.BigConceptName;
objDDL.DataSource = arrBigConceptObjLst;
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
if (clsBigConceptBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsBigConceptBL没有刷新缓存机制(clsBigConceptBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by IdBigConcept");
//if (arrBigConceptObjLstCache == null)
//{
//arrBigConceptObjLstCache = BigConceptDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "strIdBigConcept">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsBigConceptEN GetObjByIdBigConceptCache(string strIdBigConcept)
{
//获取缓存中的对象列表
string strKey = string.Format("{0}", clsBigConceptEN._CurrTabName);
List<clsBigConceptEN> arrBigConceptObjLstCache = GetObjLstCache();
IEnumerable <clsBigConceptEN> arrBigConceptObjLst_Sel =
arrBigConceptObjLstCache
.Where(x=> x.IdBigConcept == strIdBigConcept 
);
if (arrBigConceptObjLst_Sel.Count() == 0)
{
   clsBigConceptEN obj = clsBigConceptBL.GetObjByIdBigConcept(strIdBigConcept);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
 }
return null;
}
return arrBigConceptObjLst_Sel.First();
}

 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecNameByKeyCache)
 /// </summary>
 /// <param name = "strIdBigConcept">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetBigConceptNameByIdBigConceptCache(string strIdBigConcept)
{
if (string.IsNullOrEmpty(strIdBigConcept) == true) return "";
//获取缓存中的对象列表
clsBigConceptEN objBigConcept = GetObjByIdBigConceptCache(strIdBigConcept);
if (objBigConcept == null) return "";
return objBigConcept.BigConceptName;
}
 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecNameByKeyCache)
 /// </summary>
 /// <param name = "strIdBigConcept">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetNameByIdBigConceptCache(string strIdBigConcept)
{
if (string.IsNullOrEmpty(strIdBigConcept) == true) return "";
//获取缓存中的对象列表
clsBigConceptEN objBigConcept = GetObjByIdBigConceptCache(strIdBigConcept);
if (objBigConcept == null) return "";
return objBigConcept.BigConceptName;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsBigConceptEN> GetAllBigConceptObjLstCache()
{
//获取缓存中的对象列表
List<clsBigConceptEN> arrBigConceptObjLstCache = GetObjLstCache(); 
return arrBigConceptObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsBigConceptEN> GetObjLstCache()
{
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}", clsBigConceptEN._CurrTabName);
List<clsBigConceptEN> arrBigConceptObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrBigConceptObjLstCache;
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
string strKey = string.Format("{0}", clsBigConceptEN._CurrTabName);
CacheHelper.Remove(strKey);
clsBigConceptEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
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
if (clsBigConceptEN._RefreshTimeLst.Count == 0) return "";
return clsBigConceptEN._RefreshTimeLst[clsBigConceptEN._RefreshTimeLst.Count - 1];
}

 /// <summary>
 /// 刷新缓存.把当前表的缓存以及该表相关视图的缓存清空.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ReFreshCache)
 /// </summary>
public static void ReFreshCache()
{
if (clsBigConceptBL.objCommFun4BL != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}", clsBigConceptEN._CurrTabName);
CacheHelper.Remove(strKey);
clsBigConceptEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
clsBigConceptBL.objCommFun4BL.ReFreshCache();
}
}


 #endregion 缓存操作


 #region 检查唯一性

 /// <summary>
 /// 获取检查唯一性条件串(Uniqueness)--BigConcept(大概念)
 /// 唯一性条件:BigConceptName_IdGrade
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetUniquenessConditionString)
 /// </summary>
 /// <param name = "objBigConceptEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(clsBigConceptEN objBigConceptEN)
{
//检测记录是否存在
string strResult = BigConceptDA.GetUniCondStr(objBigConceptEN);
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
public static string Func(string strInFldName, string strOutFldName, string strIdBigConcept)
{
if (strInFldName != conBigConcept.IdBigConcept)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (conBigConcept.AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", conBigConcept.AttributeName));
throw new Exception(strMsg);
}
var objBigConcept = clsBigConceptBL.GetObjByIdBigConceptCache(strIdBigConcept);
if (objBigConcept == null) return "";
return objBigConcept[strOutFldName].ToString();
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
int intRecCount = clsBigConceptDA.GetRecCount(strTabName);
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
int intRecCount = clsBigConceptDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsBigConceptDA.GetRecCount();
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
int intRecCount = clsBigConceptDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objBigConceptCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsBigConceptEN objBigConceptCond)
{
List<clsBigConceptEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsBigConceptEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conBigConcept.AttributeName)
{
if (objBigConceptCond.IsUpdated(strFldName) == false) continue;
if (objBigConceptCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objBigConceptCond[strFldName].ToString());
}
else
{
if (objBigConceptCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objBigConceptCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objBigConceptCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objBigConceptCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objBigConceptCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objBigConceptCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objBigConceptCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objBigConceptCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objBigConceptCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objBigConceptCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objBigConceptCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objBigConceptCond[strFldName]));
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
 List<string> arrList = clsBigConceptDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = BigConceptDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = BigConceptDA.GetFldValueNoDistinct(strFldName, strWhereCond);
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
int intRecCount = BigConceptDA.SetFldValue(strFldName, strValue, strWhereCond);
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
int intRecCount = clsBigConceptDA.SetFldValue(clsBigConceptEN._CurrTabName, strFldName, fltValue, strWhereCond);
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
int intRecCount = BigConceptDA.SetFldValue( strFldName, intValue, strWhereCond);
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
int intRecCount = clsBigConceptDA.SetFldValue(strTabName, strFldName, strValue, strWhereCond);
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
int intRecCount = clsBigConceptDA.SetFldValue(strTabName, strFldName, intValue, strWhereCond);
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
int intRecCount = clsBigConceptDA.SetFldValue(strTabName, strFldName, fltValue, strWhereCond);
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
  strCreateTabCode.Append("CREATE table [dbo].[BigConcept] "); 
 strCreateTabCode.Append(" ( "); 
 // /**大概念流水号*/ 
 strCreateTabCode.Append(" IdBigConcept char(8) primary key, "); 
 // /**大概念编号*/ 
 strCreateTabCode.Append(" BigConceptId char(12) not Null, "); 
 // /**大概念名称*/ 
 strCreateTabCode.Append(" BigConceptName varchar(100) not Null, "); 
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
 /// 大概念(BigConcept)
 /// 数据源类型:表
 /// (AutoGCLib.CommFun4BL4CSharp:GeneCode_This)
 /// </summary>
public class  clsCommFun4BL4BigConcept : clsCommFun4BL
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
clsBigConceptBL.ReFreshThisCache();
}
}

}