
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clscc_WorkStuRelation_TotalByQuTypeBL
 表名:cc_WorkStuRelation_TotalByQuType(01120354)
 * 版本:2024.11.13.1(服务器:WIN-SRV103-116)
 日期:2024/11/13 06:13:34
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:研究生学习游戏化后台(000055, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:互动管理(InteractManage)
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
public static class  clscc_WorkStuRelation_TotalByQuTypeBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "lngIdWorkStuRelationTotal">表关键字</param>
 /// <returns>表对象</returns>
public static clscc_WorkStuRelation_TotalByQuTypeEN GetObj(this K_IdWorkStuRelationTotal_cc_WorkStuRelation_TotalByQuType myKey)
{
clscc_WorkStuRelation_TotalByQuTypeEN objcc_WorkStuRelation_TotalByQuTypeEN = clscc_WorkStuRelation_TotalByQuTypeBL.cc_WorkStuRelation_TotalByQuTypeDA.GetObjByIdWorkStuRelationTotal(myKey.Value);
return objcc_WorkStuRelation_TotalByQuTypeEN;
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_AddNewRecord)
 /// </summary>
 /// <param name = "objcc_WorkStuRelation_TotalByQuTypeEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clscc_WorkStuRelation_TotalByQuTypeEN objcc_WorkStuRelation_TotalByQuTypeEN, bool bolIsNeedCheckUniqueness = true)
{
if (bolIsNeedCheckUniqueness == true && CheckUniqueness(objcc_WorkStuRelation_TotalByQuTypeEN) == false)
{
var strMsg = string.Format("记录已经存在!教学班流水号 = [{0}],学生流水号 = [{1}]的数据已经存在!(in clscc_WorkStuRelation_TotalByQuTypeBL.AddNewRecord)", objcc_WorkStuRelation_TotalByQuTypeEN.IdCurrEduCls,objcc_WorkStuRelation_TotalByQuTypeEN.IdStudentInfo);
throw new Exception(strMsg);
}
try
{
bool bolResult = clscc_WorkStuRelation_TotalByQuTypeBL.cc_WorkStuRelation_TotalByQuTypeDA.AddNewRecordBySQL2(objcc_WorkStuRelation_TotalByQuTypeEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clscc_WorkStuRelation_TotalByQuTypeBL.ReFreshCache();

if (clscc_WorkStuRelation_TotalByQuTypeBL.relatedActions != null)
{
clscc_WorkStuRelation_TotalByQuTypeBL.relatedActions.UpdRelaTabDate(objcc_WorkStuRelation_TotalByQuTypeEN.IdWorkStuRelationTotal, objcc_WorkStuRelation_TotalByQuTypeEN.UpdUserId);
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
public static bool AddRecordEx(this clscc_WorkStuRelation_TotalByQuTypeEN objcc_WorkStuRelation_TotalByQuTypeEN, bool bolIsNeedCheckUniqueness = true)
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
objcc_WorkStuRelation_TotalByQuTypeEN.CheckPropertyNew();
 ///5.2、检查唯一性
if (bolIsNeedCheckUniqueness == true && objcc_WorkStuRelation_TotalByQuTypeEN.CheckUniqueness() == false)
{
strMsg = string.Format("(教学班流水号(IdCurrEduCls)=[{0}],学生流水号(IdStudentInfo)=[{1}])已经存在,不能重复!", objcc_WorkStuRelation_TotalByQuTypeEN.IdCurrEduCls, objcc_WorkStuRelation_TotalByQuTypeEN.IdStudentInfo);
throw new Exception(strMsg);
}
//6、把数据实体层的数据存贮到数据库中
objcc_WorkStuRelation_TotalByQuTypeEN.AddNewRecord();
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
 /// <param name = "objcc_WorkStuRelation_TotalByQuTypeEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordWithReturnKey(this clscc_WorkStuRelation_TotalByQuTypeEN objcc_WorkStuRelation_TotalByQuTypeEN, bool bolIsNeedCheckUniqueness = true)
{
if (bolIsNeedCheckUniqueness == true && CheckUniqueness(objcc_WorkStuRelation_TotalByQuTypeEN) == false)
{
var strMsg = string.Format("记录已经存在!教学班流水号 = [{0}],学生流水号 = [{1}]的数据已经存在!(in clscc_WorkStuRelation_TotalByQuTypeBL.AddNewRecordWithReturnKey)", objcc_WorkStuRelation_TotalByQuTypeEN.IdCurrEduCls,objcc_WorkStuRelation_TotalByQuTypeEN.IdStudentInfo);
throw new Exception(strMsg);
}
try
{
string strKey = clscc_WorkStuRelation_TotalByQuTypeBL.cc_WorkStuRelation_TotalByQuTypeDA.AddNewRecordBySQL2WithReturnKey(objcc_WorkStuRelation_TotalByQuTypeEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clscc_WorkStuRelation_TotalByQuTypeBL.ReFreshCache();

if (clscc_WorkStuRelation_TotalByQuTypeBL.relatedActions != null)
{
clscc_WorkStuRelation_TotalByQuTypeBL.relatedActions.UpdRelaTabDate(objcc_WorkStuRelation_TotalByQuTypeEN.IdWorkStuRelationTotal, objcc_WorkStuRelation_TotalByQuTypeEN.UpdUserId);
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
 /// <param name = "objcc_WorkStuRelation_TotalByQuTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clscc_WorkStuRelation_TotalByQuTypeEN SetIdWorkStuRelationTotal(this clscc_WorkStuRelation_TotalByQuTypeEN objcc_WorkStuRelation_TotalByQuTypeEN, long lngIdWorkStuRelationTotal, string strComparisonOp="")
	{
objcc_WorkStuRelation_TotalByQuTypeEN.IdWorkStuRelationTotal = lngIdWorkStuRelationTotal; //流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_WorkStuRelation_TotalByQuTypeEN.dicFldComparisonOp.ContainsKey(concc_WorkStuRelation_TotalByQuType.IdWorkStuRelationTotal) == false)
{
objcc_WorkStuRelation_TotalByQuTypeEN.dicFldComparisonOp.Add(concc_WorkStuRelation_TotalByQuType.IdWorkStuRelationTotal, strComparisonOp);
}
else
{
objcc_WorkStuRelation_TotalByQuTypeEN.dicFldComparisonOp[concc_WorkStuRelation_TotalByQuType.IdWorkStuRelationTotal] = strComparisonOp;
}
}
return objcc_WorkStuRelation_TotalByQuTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_WorkStuRelation_TotalByQuTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clscc_WorkStuRelation_TotalByQuTypeEN SetIdCurrEduCls(this clscc_WorkStuRelation_TotalByQuTypeEN objcc_WorkStuRelation_TotalByQuTypeEN, string strIdCurrEduCls, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strIdCurrEduCls, concc_WorkStuRelation_TotalByQuType.IdCurrEduCls);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdCurrEduCls, 8, concc_WorkStuRelation_TotalByQuType.IdCurrEduCls);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdCurrEduCls, 8, concc_WorkStuRelation_TotalByQuType.IdCurrEduCls);
}
objcc_WorkStuRelation_TotalByQuTypeEN.IdCurrEduCls = strIdCurrEduCls; //教学班流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_WorkStuRelation_TotalByQuTypeEN.dicFldComparisonOp.ContainsKey(concc_WorkStuRelation_TotalByQuType.IdCurrEduCls) == false)
{
objcc_WorkStuRelation_TotalByQuTypeEN.dicFldComparisonOp.Add(concc_WorkStuRelation_TotalByQuType.IdCurrEduCls, strComparisonOp);
}
else
{
objcc_WorkStuRelation_TotalByQuTypeEN.dicFldComparisonOp[concc_WorkStuRelation_TotalByQuType.IdCurrEduCls] = strComparisonOp;
}
}
return objcc_WorkStuRelation_TotalByQuTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_WorkStuRelation_TotalByQuTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clscc_WorkStuRelation_TotalByQuTypeEN SetIdStudentInfo(this clscc_WorkStuRelation_TotalByQuTypeEN objcc_WorkStuRelation_TotalByQuTypeEN, string strIdStudentInfo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strIdStudentInfo, concc_WorkStuRelation_TotalByQuType.IdStudentInfo);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdStudentInfo, 8, concc_WorkStuRelation_TotalByQuType.IdStudentInfo);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdStudentInfo, 8, concc_WorkStuRelation_TotalByQuType.IdStudentInfo);
}
objcc_WorkStuRelation_TotalByQuTypeEN.IdStudentInfo = strIdStudentInfo; //学生流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_WorkStuRelation_TotalByQuTypeEN.dicFldComparisonOp.ContainsKey(concc_WorkStuRelation_TotalByQuType.IdStudentInfo) == false)
{
objcc_WorkStuRelation_TotalByQuTypeEN.dicFldComparisonOp.Add(concc_WorkStuRelation_TotalByQuType.IdStudentInfo, strComparisonOp);
}
else
{
objcc_WorkStuRelation_TotalByQuTypeEN.dicFldComparisonOp[concc_WorkStuRelation_TotalByQuType.IdStudentInfo] = strComparisonOp;
}
}
return objcc_WorkStuRelation_TotalByQuTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_WorkStuRelation_TotalByQuTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clscc_WorkStuRelation_TotalByQuTypeEN SetQuestionTypeId(this clscc_WorkStuRelation_TotalByQuTypeEN objcc_WorkStuRelation_TotalByQuTypeEN, string strQuestionTypeId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strQuestionTypeId, 2, concc_WorkStuRelation_TotalByQuType.QuestionTypeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strQuestionTypeId, 2, concc_WorkStuRelation_TotalByQuType.QuestionTypeId);
}
objcc_WorkStuRelation_TotalByQuTypeEN.QuestionTypeId = strQuestionTypeId; //题目类型Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_WorkStuRelation_TotalByQuTypeEN.dicFldComparisonOp.ContainsKey(concc_WorkStuRelation_TotalByQuType.QuestionTypeId) == false)
{
objcc_WorkStuRelation_TotalByQuTypeEN.dicFldComparisonOp.Add(concc_WorkStuRelation_TotalByQuType.QuestionTypeId, strComparisonOp);
}
else
{
objcc_WorkStuRelation_TotalByQuTypeEN.dicFldComparisonOp[concc_WorkStuRelation_TotalByQuType.QuestionTypeId] = strComparisonOp;
}
}
return objcc_WorkStuRelation_TotalByQuTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_WorkStuRelation_TotalByQuTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clscc_WorkStuRelation_TotalByQuTypeEN SetQuestionTypeId4Course(this clscc_WorkStuRelation_TotalByQuTypeEN objcc_WorkStuRelation_TotalByQuTypeEN, string strQuestionTypeId4Course, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strQuestionTypeId4Course, 8, concc_WorkStuRelation_TotalByQuType.QuestionTypeId4Course);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strQuestionTypeId4Course, 8, concc_WorkStuRelation_TotalByQuType.QuestionTypeId4Course);
}
objcc_WorkStuRelation_TotalByQuTypeEN.QuestionTypeId4Course = strQuestionTypeId4Course; //题目类型Id4课程
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_WorkStuRelation_TotalByQuTypeEN.dicFldComparisonOp.ContainsKey(concc_WorkStuRelation_TotalByQuType.QuestionTypeId4Course) == false)
{
objcc_WorkStuRelation_TotalByQuTypeEN.dicFldComparisonOp.Add(concc_WorkStuRelation_TotalByQuType.QuestionTypeId4Course, strComparisonOp);
}
else
{
objcc_WorkStuRelation_TotalByQuTypeEN.dicFldComparisonOp[concc_WorkStuRelation_TotalByQuType.QuestionTypeId4Course] = strComparisonOp;
}
}
return objcc_WorkStuRelation_TotalByQuTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_WorkStuRelation_TotalByQuTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clscc_WorkStuRelation_TotalByQuTypeEN SetWorkNum(this clscc_WorkStuRelation_TotalByQuTypeEN objcc_WorkStuRelation_TotalByQuTypeEN, int intWorkNum, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(intWorkNum, concc_WorkStuRelation_TotalByQuType.WorkNum);
objcc_WorkStuRelation_TotalByQuTypeEN.WorkNum = intWorkNum; //作业数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_WorkStuRelation_TotalByQuTypeEN.dicFldComparisonOp.ContainsKey(concc_WorkStuRelation_TotalByQuType.WorkNum) == false)
{
objcc_WorkStuRelation_TotalByQuTypeEN.dicFldComparisonOp.Add(concc_WorkStuRelation_TotalByQuType.WorkNum, strComparisonOp);
}
else
{
objcc_WorkStuRelation_TotalByQuTypeEN.dicFldComparisonOp[concc_WorkStuRelation_TotalByQuType.WorkNum] = strComparisonOp;
}
}
return objcc_WorkStuRelation_TotalByQuTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_WorkStuRelation_TotalByQuTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clscc_WorkStuRelation_TotalByQuTypeEN SetWorkNumSubmit(this clscc_WorkStuRelation_TotalByQuTypeEN objcc_WorkStuRelation_TotalByQuTypeEN, int? intWorkNumSubmit, string strComparisonOp="")
	{
objcc_WorkStuRelation_TotalByQuTypeEN.WorkNumSubmit = intWorkNumSubmit; //提交作业数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_WorkStuRelation_TotalByQuTypeEN.dicFldComparisonOp.ContainsKey(concc_WorkStuRelation_TotalByQuType.WorkNumSubmit) == false)
{
objcc_WorkStuRelation_TotalByQuTypeEN.dicFldComparisonOp.Add(concc_WorkStuRelation_TotalByQuType.WorkNumSubmit, strComparisonOp);
}
else
{
objcc_WorkStuRelation_TotalByQuTypeEN.dicFldComparisonOp[concc_WorkStuRelation_TotalByQuType.WorkNumSubmit] = strComparisonOp;
}
}
return objcc_WorkStuRelation_TotalByQuTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_WorkStuRelation_TotalByQuTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clscc_WorkStuRelation_TotalByQuTypeEN SetWorkNumSave(this clscc_WorkStuRelation_TotalByQuTypeEN objcc_WorkStuRelation_TotalByQuTypeEN, int? intWorkNumSave, string strComparisonOp="")
	{
objcc_WorkStuRelation_TotalByQuTypeEN.WorkNumSave = intWorkNumSave; //保存作业数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_WorkStuRelation_TotalByQuTypeEN.dicFldComparisonOp.ContainsKey(concc_WorkStuRelation_TotalByQuType.WorkNumSave) == false)
{
objcc_WorkStuRelation_TotalByQuTypeEN.dicFldComparisonOp.Add(concc_WorkStuRelation_TotalByQuType.WorkNumSave, strComparisonOp);
}
else
{
objcc_WorkStuRelation_TotalByQuTypeEN.dicFldComparisonOp[concc_WorkStuRelation_TotalByQuType.WorkNumSave] = strComparisonOp;
}
}
return objcc_WorkStuRelation_TotalByQuTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_WorkStuRelation_TotalByQuTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clscc_WorkStuRelation_TotalByQuTypeEN SetWorkNumNoFinish(this clscc_WorkStuRelation_TotalByQuTypeEN objcc_WorkStuRelation_TotalByQuTypeEN, int? intWorkNumNoFinish, string strComparisonOp="")
	{
objcc_WorkStuRelation_TotalByQuTypeEN.WorkNumNoFinish = intWorkNumNoFinish; //未完成作业数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_WorkStuRelation_TotalByQuTypeEN.dicFldComparisonOp.ContainsKey(concc_WorkStuRelation_TotalByQuType.WorkNumNoFinish) == false)
{
objcc_WorkStuRelation_TotalByQuTypeEN.dicFldComparisonOp.Add(concc_WorkStuRelation_TotalByQuType.WorkNumNoFinish, strComparisonOp);
}
else
{
objcc_WorkStuRelation_TotalByQuTypeEN.dicFldComparisonOp[concc_WorkStuRelation_TotalByQuType.WorkNumNoFinish] = strComparisonOp;
}
}
return objcc_WorkStuRelation_TotalByQuTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_WorkStuRelation_TotalByQuTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clscc_WorkStuRelation_TotalByQuTypeEN SetWorkNumSendBack(this clscc_WorkStuRelation_TotalByQuTypeEN objcc_WorkStuRelation_TotalByQuTypeEN, int? intWorkNumSendBack, string strComparisonOp="")
	{
objcc_WorkStuRelation_TotalByQuTypeEN.WorkNumSendBack = intWorkNumSendBack; //退回作业数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_WorkStuRelation_TotalByQuTypeEN.dicFldComparisonOp.ContainsKey(concc_WorkStuRelation_TotalByQuType.WorkNumSendBack) == false)
{
objcc_WorkStuRelation_TotalByQuTypeEN.dicFldComparisonOp.Add(concc_WorkStuRelation_TotalByQuType.WorkNumSendBack, strComparisonOp);
}
else
{
objcc_WorkStuRelation_TotalByQuTypeEN.dicFldComparisonOp[concc_WorkStuRelation_TotalByQuType.WorkNumSendBack] = strComparisonOp;
}
}
return objcc_WorkStuRelation_TotalByQuTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_WorkStuRelation_TotalByQuTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clscc_WorkStuRelation_TotalByQuTypeEN SetWorkNumMark(this clscc_WorkStuRelation_TotalByQuTypeEN objcc_WorkStuRelation_TotalByQuTypeEN, int? intWorkNumMark, string strComparisonOp="")
	{
objcc_WorkStuRelation_TotalByQuTypeEN.WorkNumMark = intWorkNumMark; //批改作业数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_WorkStuRelation_TotalByQuTypeEN.dicFldComparisonOp.ContainsKey(concc_WorkStuRelation_TotalByQuType.WorkNumMark) == false)
{
objcc_WorkStuRelation_TotalByQuTypeEN.dicFldComparisonOp.Add(concc_WorkStuRelation_TotalByQuType.WorkNumMark, strComparisonOp);
}
else
{
objcc_WorkStuRelation_TotalByQuTypeEN.dicFldComparisonOp[concc_WorkStuRelation_TotalByQuType.WorkNumMark] = strComparisonOp;
}
}
return objcc_WorkStuRelation_TotalByQuTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_WorkStuRelation_TotalByQuTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clscc_WorkStuRelation_TotalByQuTypeEN SetWorkNumLook(this clscc_WorkStuRelation_TotalByQuTypeEN objcc_WorkStuRelation_TotalByQuTypeEN, int? intWorkNumLook, string strComparisonOp="")
	{
objcc_WorkStuRelation_TotalByQuTypeEN.WorkNumLook = intWorkNumLook; //查看作业数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_WorkStuRelation_TotalByQuTypeEN.dicFldComparisonOp.ContainsKey(concc_WorkStuRelation_TotalByQuType.WorkNumLook) == false)
{
objcc_WorkStuRelation_TotalByQuTypeEN.dicFldComparisonOp.Add(concc_WorkStuRelation_TotalByQuType.WorkNumLook, strComparisonOp);
}
else
{
objcc_WorkStuRelation_TotalByQuTypeEN.dicFldComparisonOp[concc_WorkStuRelation_TotalByQuType.WorkNumLook] = strComparisonOp;
}
}
return objcc_WorkStuRelation_TotalByQuTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_WorkStuRelation_TotalByQuTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clscc_WorkStuRelation_TotalByQuTypeEN SetWorkNumOverdue(this clscc_WorkStuRelation_TotalByQuTypeEN objcc_WorkStuRelation_TotalByQuTypeEN, int? intWorkNumOverdue, string strComparisonOp="")
	{
objcc_WorkStuRelation_TotalByQuTypeEN.WorkNumOverdue = intWorkNumOverdue; //逾期作业数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_WorkStuRelation_TotalByQuTypeEN.dicFldComparisonOp.ContainsKey(concc_WorkStuRelation_TotalByQuType.WorkNumOverdue) == false)
{
objcc_WorkStuRelation_TotalByQuTypeEN.dicFldComparisonOp.Add(concc_WorkStuRelation_TotalByQuType.WorkNumOverdue, strComparisonOp);
}
else
{
objcc_WorkStuRelation_TotalByQuTypeEN.dicFldComparisonOp[concc_WorkStuRelation_TotalByQuType.WorkNumOverdue] = strComparisonOp;
}
}
return objcc_WorkStuRelation_TotalByQuTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_WorkStuRelation_TotalByQuTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clscc_WorkStuRelation_TotalByQuTypeEN SetTotalScore(this clscc_WorkStuRelation_TotalByQuTypeEN objcc_WorkStuRelation_TotalByQuTypeEN, double? dblTotalScore, string strComparisonOp="")
	{
objcc_WorkStuRelation_TotalByQuTypeEN.TotalScore = dblTotalScore; //总得分
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_WorkStuRelation_TotalByQuTypeEN.dicFldComparisonOp.ContainsKey(concc_WorkStuRelation_TotalByQuType.TotalScore) == false)
{
objcc_WorkStuRelation_TotalByQuTypeEN.dicFldComparisonOp.Add(concc_WorkStuRelation_TotalByQuType.TotalScore, strComparisonOp);
}
else
{
objcc_WorkStuRelation_TotalByQuTypeEN.dicFldComparisonOp[concc_WorkStuRelation_TotalByQuType.TotalScore] = strComparisonOp;
}
}
return objcc_WorkStuRelation_TotalByQuTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_WorkStuRelation_TotalByQuTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clscc_WorkStuRelation_TotalByQuTypeEN SetTotalScores(this clscc_WorkStuRelation_TotalByQuTypeEN objcc_WorkStuRelation_TotalByQuTypeEN, double? dblTotalScores, string strComparisonOp="")
	{
objcc_WorkStuRelation_TotalByQuTypeEN.TotalScores = dblTotalScores; //总分值
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_WorkStuRelation_TotalByQuTypeEN.dicFldComparisonOp.ContainsKey(concc_WorkStuRelation_TotalByQuType.TotalScores) == false)
{
objcc_WorkStuRelation_TotalByQuTypeEN.dicFldComparisonOp.Add(concc_WorkStuRelation_TotalByQuType.TotalScores, strComparisonOp);
}
else
{
objcc_WorkStuRelation_TotalByQuTypeEN.dicFldComparisonOp[concc_WorkStuRelation_TotalByQuType.TotalScores] = strComparisonOp;
}
}
return objcc_WorkStuRelation_TotalByQuTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_WorkStuRelation_TotalByQuTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clscc_WorkStuRelation_TotalByQuTypeEN SetSchoolYear(this clscc_WorkStuRelation_TotalByQuTypeEN objcc_WorkStuRelation_TotalByQuTypeEN, string strSchoolYear, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strSchoolYear, 10, concc_WorkStuRelation_TotalByQuType.SchoolYear);
}
objcc_WorkStuRelation_TotalByQuTypeEN.SchoolYear = strSchoolYear; //学年
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_WorkStuRelation_TotalByQuTypeEN.dicFldComparisonOp.ContainsKey(concc_WorkStuRelation_TotalByQuType.SchoolYear) == false)
{
objcc_WorkStuRelation_TotalByQuTypeEN.dicFldComparisonOp.Add(concc_WorkStuRelation_TotalByQuType.SchoolYear, strComparisonOp);
}
else
{
objcc_WorkStuRelation_TotalByQuTypeEN.dicFldComparisonOp[concc_WorkStuRelation_TotalByQuType.SchoolYear] = strComparisonOp;
}
}
return objcc_WorkStuRelation_TotalByQuTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_WorkStuRelation_TotalByQuTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clscc_WorkStuRelation_TotalByQuTypeEN SetSchoolTerm(this clscc_WorkStuRelation_TotalByQuTypeEN objcc_WorkStuRelation_TotalByQuTypeEN, string strSchoolTerm, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strSchoolTerm, 1, concc_WorkStuRelation_TotalByQuType.SchoolTerm);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strSchoolTerm, 1, concc_WorkStuRelation_TotalByQuType.SchoolTerm);
}
objcc_WorkStuRelation_TotalByQuTypeEN.SchoolTerm = strSchoolTerm; //学期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_WorkStuRelation_TotalByQuTypeEN.dicFldComparisonOp.ContainsKey(concc_WorkStuRelation_TotalByQuType.SchoolTerm) == false)
{
objcc_WorkStuRelation_TotalByQuTypeEN.dicFldComparisonOp.Add(concc_WorkStuRelation_TotalByQuType.SchoolTerm, strComparisonOp);
}
else
{
objcc_WorkStuRelation_TotalByQuTypeEN.dicFldComparisonOp[concc_WorkStuRelation_TotalByQuType.SchoolTerm] = strComparisonOp;
}
}
return objcc_WorkStuRelation_TotalByQuTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_WorkStuRelation_TotalByQuTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clscc_WorkStuRelation_TotalByQuTypeEN SetUpdDate(this clscc_WorkStuRelation_TotalByQuTypeEN objcc_WorkStuRelation_TotalByQuTypeEN, string strUpdDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strUpdDate, concc_WorkStuRelation_TotalByQuType.UpdDate);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdDate, 20, concc_WorkStuRelation_TotalByQuType.UpdDate);
}
objcc_WorkStuRelation_TotalByQuTypeEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_WorkStuRelation_TotalByQuTypeEN.dicFldComparisonOp.ContainsKey(concc_WorkStuRelation_TotalByQuType.UpdDate) == false)
{
objcc_WorkStuRelation_TotalByQuTypeEN.dicFldComparisonOp.Add(concc_WorkStuRelation_TotalByQuType.UpdDate, strComparisonOp);
}
else
{
objcc_WorkStuRelation_TotalByQuTypeEN.dicFldComparisonOp[concc_WorkStuRelation_TotalByQuType.UpdDate] = strComparisonOp;
}
}
return objcc_WorkStuRelation_TotalByQuTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_WorkStuRelation_TotalByQuTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clscc_WorkStuRelation_TotalByQuTypeEN SetUpdUserId(this clscc_WorkStuRelation_TotalByQuTypeEN objcc_WorkStuRelation_TotalByQuTypeEN, string strUpdUserId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdUserId, 20, concc_WorkStuRelation_TotalByQuType.UpdUserId);
}
objcc_WorkStuRelation_TotalByQuTypeEN.UpdUserId = strUpdUserId; //修改用户Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_WorkStuRelation_TotalByQuTypeEN.dicFldComparisonOp.ContainsKey(concc_WorkStuRelation_TotalByQuType.UpdUserId) == false)
{
objcc_WorkStuRelation_TotalByQuTypeEN.dicFldComparisonOp.Add(concc_WorkStuRelation_TotalByQuType.UpdUserId, strComparisonOp);
}
else
{
objcc_WorkStuRelation_TotalByQuTypeEN.dicFldComparisonOp[concc_WorkStuRelation_TotalByQuType.UpdUserId] = strComparisonOp;
}
}
return objcc_WorkStuRelation_TotalByQuTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_WorkStuRelation_TotalByQuTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clscc_WorkStuRelation_TotalByQuTypeEN SetMemo(this clscc_WorkStuRelation_TotalByQuTypeEN objcc_WorkStuRelation_TotalByQuTypeEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, concc_WorkStuRelation_TotalByQuType.Memo);
}
objcc_WorkStuRelation_TotalByQuTypeEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_WorkStuRelation_TotalByQuTypeEN.dicFldComparisonOp.ContainsKey(concc_WorkStuRelation_TotalByQuType.Memo) == false)
{
objcc_WorkStuRelation_TotalByQuTypeEN.dicFldComparisonOp.Add(concc_WorkStuRelation_TotalByQuType.Memo, strComparisonOp);
}
else
{
objcc_WorkStuRelation_TotalByQuTypeEN.dicFldComparisonOp[concc_WorkStuRelation_TotalByQuType.Memo] = strComparisonOp;
}
}
return objcc_WorkStuRelation_TotalByQuTypeEN;
	}

 /// <summary>
 /// 修改记录存盘到数据表中
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_UpdateRecordEx)
 /// </summary>
 /// <param name = "objcc_WorkStuRelation_TotalByQuTypeEN">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool UpdateRecordEx(this clscc_WorkStuRelation_TotalByQuTypeEN objcc_WorkStuRelation_TotalByQuTypeEN)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
try
{
//1、检查传进去的对象属性是否合法
objcc_WorkStuRelation_TotalByQuTypeEN.CheckPropertyNew();
clscc_WorkStuRelation_TotalByQuTypeEN objcc_WorkStuRelation_TotalByQuTypeCond = new clscc_WorkStuRelation_TotalByQuTypeEN();
string strCondition = objcc_WorkStuRelation_TotalByQuTypeCond
.SetIdWorkStuRelationTotal(objcc_WorkStuRelation_TotalByQuTypeEN.IdWorkStuRelationTotal, "<>")
.SetIdCurrEduCls(objcc_WorkStuRelation_TotalByQuTypeEN.IdCurrEduCls, "=")
.SetIdStudentInfo(objcc_WorkStuRelation_TotalByQuTypeEN.IdStudentInfo, "=")
.GetCombineCondition();
objcc_WorkStuRelation_TotalByQuTypeEN._IsCheckProperty = true;
bool bolIsExist = clscc_WorkStuRelation_TotalByQuTypeBL.IsExistRecord(strCondition);
if (bolIsExist)
{
strMsg = "(id_CurrEduCls_id_StudentInfo)不能重复!";
throw new Exception(strMsg);
}
//4、把数据实体层的数据存贮到数据库中
objcc_WorkStuRelation_TotalByQuTypeEN.Update();
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
 /// <param name = "objcc_WorkStuRelation_TotalByQuType">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool EditRecordEx(this clscc_WorkStuRelation_TotalByQuTypeEN objcc_WorkStuRelation_TotalByQuType)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
clscc_WorkStuRelation_TotalByQuTypeEN objcc_WorkStuRelation_TotalByQuTypeCond = new clscc_WorkStuRelation_TotalByQuTypeEN();
string strCondition = objcc_WorkStuRelation_TotalByQuTypeCond
.SetIdCurrEduCls(objcc_WorkStuRelation_TotalByQuType.IdCurrEduCls, "=")
.SetIdStudentInfo(objcc_WorkStuRelation_TotalByQuType.IdStudentInfo, "=")
.GetCombineCondition();
objcc_WorkStuRelation_TotalByQuType._IsCheckProperty = true;
bool bolIsExist = clscc_WorkStuRelation_TotalByQuTypeBL.IsExistRecord(strCondition);
if (bolIsExist)
{
objcc_WorkStuRelation_TotalByQuType.IdWorkStuRelationTotal = clscc_WorkStuRelation_TotalByQuTypeBL.GetFirstID_S(strCondition);
objcc_WorkStuRelation_TotalByQuType.UpdateWithCondition(strCondition);
}
else
{
objcc_WorkStuRelation_TotalByQuType.AddNewRecord();
}
return true; 
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_Update)
 /// </summary>
 /// <param name = "objcc_WorkStuRelation_TotalByQuTypeEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clscc_WorkStuRelation_TotalByQuTypeEN objcc_WorkStuRelation_TotalByQuTypeEN)
{
 if (objcc_WorkStuRelation_TotalByQuTypeEN.IdWorkStuRelationTotal == 0)
 {
string strMsg = string.Format("(errid:Busi000095)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clscc_WorkStuRelation_TotalByQuTypeBL.cc_WorkStuRelation_TotalByQuTypeDA.UpdateBySql2(objcc_WorkStuRelation_TotalByQuTypeEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clscc_WorkStuRelation_TotalByQuTypeBL.ReFreshCache();

if (clscc_WorkStuRelation_TotalByQuTypeBL.relatedActions != null)
{
clscc_WorkStuRelation_TotalByQuTypeBL.relatedActions.UpdRelaTabDate(objcc_WorkStuRelation_TotalByQuTypeEN.IdWorkStuRelationTotal, objcc_WorkStuRelation_TotalByQuTypeEN.UpdUserId);
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
 /// <param name = "objcc_WorkStuRelation_TotalByQuTypeEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clscc_WorkStuRelation_TotalByQuTypeEN objcc_WorkStuRelation_TotalByQuTypeEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (objcc_WorkStuRelation_TotalByQuTypeEN.IdWorkStuRelationTotal == 0)
 {
string strMsg = string.Format("(errid:Busi000087)修改记录时关键字不能为空!(带事务处理)(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clscc_WorkStuRelation_TotalByQuTypeBL.cc_WorkStuRelation_TotalByQuTypeDA.UpdateBySql2(objcc_WorkStuRelation_TotalByQuTypeEN, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clscc_WorkStuRelation_TotalByQuTypeBL.ReFreshCache();

if (clscc_WorkStuRelation_TotalByQuTypeBL.relatedActions != null)
{
clscc_WorkStuRelation_TotalByQuTypeBL.relatedActions.UpdRelaTabDate(objcc_WorkStuRelation_TotalByQuTypeEN.IdWorkStuRelationTotal, objcc_WorkStuRelation_TotalByQuTypeEN.UpdUserId);
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
 /// <param name = "objcc_WorkStuRelation_TotalByQuTypeEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clscc_WorkStuRelation_TotalByQuTypeEN objcc_WorkStuRelation_TotalByQuTypeEN, string strWhereCond)
{
try
{
bool bolResult = clscc_WorkStuRelation_TotalByQuTypeBL.cc_WorkStuRelation_TotalByQuTypeDA.UpdateBySqlWithCondition(objcc_WorkStuRelation_TotalByQuTypeEN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clscc_WorkStuRelation_TotalByQuTypeBL.ReFreshCache();

if (clscc_WorkStuRelation_TotalByQuTypeBL.relatedActions != null)
{
clscc_WorkStuRelation_TotalByQuTypeBL.relatedActions.UpdRelaTabDate(objcc_WorkStuRelation_TotalByQuTypeEN.IdWorkStuRelationTotal, objcc_WorkStuRelation_TotalByQuTypeEN.UpdUserId);
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
 /// <param name = "objcc_WorkStuRelation_TotalByQuTypeEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clscc_WorkStuRelation_TotalByQuTypeEN objcc_WorkStuRelation_TotalByQuTypeEN, string strWhereCond, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
bool bolResult = clscc_WorkStuRelation_TotalByQuTypeBL.cc_WorkStuRelation_TotalByQuTypeDA.UpdateBySqlWithConditionTransaction(objcc_WorkStuRelation_TotalByQuTypeEN, strWhereCond, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clscc_WorkStuRelation_TotalByQuTypeBL.ReFreshCache();

if (clscc_WorkStuRelation_TotalByQuTypeBL.relatedActions != null)
{
clscc_WorkStuRelation_TotalByQuTypeBL.relatedActions.UpdRelaTabDate(objcc_WorkStuRelation_TotalByQuTypeEN.IdWorkStuRelationTotal, objcc_WorkStuRelation_TotalByQuTypeEN.UpdUserId);
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
 /// <param name = "lngIdWorkStuRelationTotal">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int Delete(this clscc_WorkStuRelation_TotalByQuTypeEN objcc_WorkStuRelation_TotalByQuTypeEN)
{
try
{
int intRecNum = clscc_WorkStuRelation_TotalByQuTypeBL.cc_WorkStuRelation_TotalByQuTypeDA.DelRecord(objcc_WorkStuRelation_TotalByQuTypeEN.IdWorkStuRelationTotal);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clscc_WorkStuRelation_TotalByQuTypeBL.ReFreshCache();

if (clscc_WorkStuRelation_TotalByQuTypeBL.relatedActions != null)
{
clscc_WorkStuRelation_TotalByQuTypeBL.relatedActions.UpdRelaTabDate(objcc_WorkStuRelation_TotalByQuTypeEN.IdWorkStuRelationTotal, objcc_WorkStuRelation_TotalByQuTypeEN.UpdUserId);
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
 /// <param name = "objcc_WorkStuRelation_TotalByQuTypeENS">源对象</param>
 /// <param name = "objcc_WorkStuRelation_TotalByQuTypeENT">目标对象</param>
 public static void CopyTo(this clscc_WorkStuRelation_TotalByQuTypeEN objcc_WorkStuRelation_TotalByQuTypeENS, clscc_WorkStuRelation_TotalByQuTypeEN objcc_WorkStuRelation_TotalByQuTypeENT)
{
try
{
objcc_WorkStuRelation_TotalByQuTypeENT.IdWorkStuRelationTotal = objcc_WorkStuRelation_TotalByQuTypeENS.IdWorkStuRelationTotal; //流水号
objcc_WorkStuRelation_TotalByQuTypeENT.IdCurrEduCls = objcc_WorkStuRelation_TotalByQuTypeENS.IdCurrEduCls; //教学班流水号
objcc_WorkStuRelation_TotalByQuTypeENT.IdStudentInfo = objcc_WorkStuRelation_TotalByQuTypeENS.IdStudentInfo; //学生流水号
objcc_WorkStuRelation_TotalByQuTypeENT.QuestionTypeId = objcc_WorkStuRelation_TotalByQuTypeENS.QuestionTypeId; //题目类型Id
objcc_WorkStuRelation_TotalByQuTypeENT.QuestionTypeId4Course = objcc_WorkStuRelation_TotalByQuTypeENS.QuestionTypeId4Course; //题目类型Id4课程
objcc_WorkStuRelation_TotalByQuTypeENT.WorkNum = objcc_WorkStuRelation_TotalByQuTypeENS.WorkNum; //作业数
objcc_WorkStuRelation_TotalByQuTypeENT.WorkNumSubmit = objcc_WorkStuRelation_TotalByQuTypeENS.WorkNumSubmit; //提交作业数
objcc_WorkStuRelation_TotalByQuTypeENT.WorkNumSave = objcc_WorkStuRelation_TotalByQuTypeENS.WorkNumSave; //保存作业数
objcc_WorkStuRelation_TotalByQuTypeENT.WorkNumNoFinish = objcc_WorkStuRelation_TotalByQuTypeENS.WorkNumNoFinish; //未完成作业数
objcc_WorkStuRelation_TotalByQuTypeENT.WorkNumSendBack = objcc_WorkStuRelation_TotalByQuTypeENS.WorkNumSendBack; //退回作业数
objcc_WorkStuRelation_TotalByQuTypeENT.WorkNumMark = objcc_WorkStuRelation_TotalByQuTypeENS.WorkNumMark; //批改作业数
objcc_WorkStuRelation_TotalByQuTypeENT.WorkNumLook = objcc_WorkStuRelation_TotalByQuTypeENS.WorkNumLook; //查看作业数
objcc_WorkStuRelation_TotalByQuTypeENT.WorkNumOverdue = objcc_WorkStuRelation_TotalByQuTypeENS.WorkNumOverdue; //逾期作业数
objcc_WorkStuRelation_TotalByQuTypeENT.TotalScore = objcc_WorkStuRelation_TotalByQuTypeENS.TotalScore; //总得分
objcc_WorkStuRelation_TotalByQuTypeENT.TotalScores = objcc_WorkStuRelation_TotalByQuTypeENS.TotalScores; //总分值
objcc_WorkStuRelation_TotalByQuTypeENT.SchoolYear = objcc_WorkStuRelation_TotalByQuTypeENS.SchoolYear; //学年
objcc_WorkStuRelation_TotalByQuTypeENT.SchoolTerm = objcc_WorkStuRelation_TotalByQuTypeENS.SchoolTerm; //学期
objcc_WorkStuRelation_TotalByQuTypeENT.UpdDate = objcc_WorkStuRelation_TotalByQuTypeENS.UpdDate; //修改日期
objcc_WorkStuRelation_TotalByQuTypeENT.UpdUserId = objcc_WorkStuRelation_TotalByQuTypeENS.UpdUserId; //修改用户Id
objcc_WorkStuRelation_TotalByQuTypeENT.Memo = objcc_WorkStuRelation_TotalByQuTypeENS.Memo; //备注
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
 /// <param name = "objcc_WorkStuRelation_TotalByQuTypeENS">源对象</param>
 /// <returns>目标对象=>clscc_WorkStuRelation_TotalByQuTypeEN:objcc_WorkStuRelation_TotalByQuTypeENT</returns>
 public static clscc_WorkStuRelation_TotalByQuTypeEN CopyTo(this clscc_WorkStuRelation_TotalByQuTypeEN objcc_WorkStuRelation_TotalByQuTypeENS)
{
try
{
 clscc_WorkStuRelation_TotalByQuTypeEN objcc_WorkStuRelation_TotalByQuTypeENT = new clscc_WorkStuRelation_TotalByQuTypeEN()
{
IdWorkStuRelationTotal = objcc_WorkStuRelation_TotalByQuTypeENS.IdWorkStuRelationTotal, //流水号
IdCurrEduCls = objcc_WorkStuRelation_TotalByQuTypeENS.IdCurrEduCls, //教学班流水号
IdStudentInfo = objcc_WorkStuRelation_TotalByQuTypeENS.IdStudentInfo, //学生流水号
QuestionTypeId = objcc_WorkStuRelation_TotalByQuTypeENS.QuestionTypeId, //题目类型Id
QuestionTypeId4Course = objcc_WorkStuRelation_TotalByQuTypeENS.QuestionTypeId4Course, //题目类型Id4课程
WorkNum = objcc_WorkStuRelation_TotalByQuTypeENS.WorkNum, //作业数
WorkNumSubmit = objcc_WorkStuRelation_TotalByQuTypeENS.WorkNumSubmit, //提交作业数
WorkNumSave = objcc_WorkStuRelation_TotalByQuTypeENS.WorkNumSave, //保存作业数
WorkNumNoFinish = objcc_WorkStuRelation_TotalByQuTypeENS.WorkNumNoFinish, //未完成作业数
WorkNumSendBack = objcc_WorkStuRelation_TotalByQuTypeENS.WorkNumSendBack, //退回作业数
WorkNumMark = objcc_WorkStuRelation_TotalByQuTypeENS.WorkNumMark, //批改作业数
WorkNumLook = objcc_WorkStuRelation_TotalByQuTypeENS.WorkNumLook, //查看作业数
WorkNumOverdue = objcc_WorkStuRelation_TotalByQuTypeENS.WorkNumOverdue, //逾期作业数
TotalScore = objcc_WorkStuRelation_TotalByQuTypeENS.TotalScore, //总得分
TotalScores = objcc_WorkStuRelation_TotalByQuTypeENS.TotalScores, //总分值
SchoolYear = objcc_WorkStuRelation_TotalByQuTypeENS.SchoolYear, //学年
SchoolTerm = objcc_WorkStuRelation_TotalByQuTypeENS.SchoolTerm, //学期
UpdDate = objcc_WorkStuRelation_TotalByQuTypeENS.UpdDate, //修改日期
UpdUserId = objcc_WorkStuRelation_TotalByQuTypeENS.UpdUserId, //修改用户Id
Memo = objcc_WorkStuRelation_TotalByQuTypeENS.Memo, //备注
};
 return objcc_WorkStuRelation_TotalByQuTypeENT;
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
public static void CheckPropertyNew(this clscc_WorkStuRelation_TotalByQuTypeEN objcc_WorkStuRelation_TotalByQuTypeEN)
{
 clscc_WorkStuRelation_TotalByQuTypeBL.cc_WorkStuRelation_TotalByQuTypeDA.CheckPropertyNew(objcc_WorkStuRelation_TotalByQuTypeEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(this clscc_WorkStuRelation_TotalByQuTypeEN objcc_WorkStuRelation_TotalByQuTypeEN)
{
 clscc_WorkStuRelation_TotalByQuTypeBL.cc_WorkStuRelation_TotalByQuTypeDA.CheckProperty4Condition(objcc_WorkStuRelation_TotalByQuTypeEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clscc_WorkStuRelation_TotalByQuTypeEN objcc_WorkStuRelation_TotalByQuTypeCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objcc_WorkStuRelation_TotalByQuTypeCond.IsUpdated(concc_WorkStuRelation_TotalByQuType.IdWorkStuRelationTotal) == true)
{
string strComparisonOpIdWorkStuRelationTotal = objcc_WorkStuRelation_TotalByQuTypeCond.dicFldComparisonOp[concc_WorkStuRelation_TotalByQuType.IdWorkStuRelationTotal];
strWhereCond += string.Format(" And {0} {2} {1}", concc_WorkStuRelation_TotalByQuType.IdWorkStuRelationTotal, objcc_WorkStuRelation_TotalByQuTypeCond.IdWorkStuRelationTotal, strComparisonOpIdWorkStuRelationTotal);
}
if (objcc_WorkStuRelation_TotalByQuTypeCond.IsUpdated(concc_WorkStuRelation_TotalByQuType.IdCurrEduCls) == true)
{
string strComparisonOpIdCurrEduCls = objcc_WorkStuRelation_TotalByQuTypeCond.dicFldComparisonOp[concc_WorkStuRelation_TotalByQuType.IdCurrEduCls];
strWhereCond += string.Format(" And {0} {2} '{1}'", concc_WorkStuRelation_TotalByQuType.IdCurrEduCls, objcc_WorkStuRelation_TotalByQuTypeCond.IdCurrEduCls, strComparisonOpIdCurrEduCls);
}
if (objcc_WorkStuRelation_TotalByQuTypeCond.IsUpdated(concc_WorkStuRelation_TotalByQuType.IdStudentInfo) == true)
{
string strComparisonOpIdStudentInfo = objcc_WorkStuRelation_TotalByQuTypeCond.dicFldComparisonOp[concc_WorkStuRelation_TotalByQuType.IdStudentInfo];
strWhereCond += string.Format(" And {0} {2} '{1}'", concc_WorkStuRelation_TotalByQuType.IdStudentInfo, objcc_WorkStuRelation_TotalByQuTypeCond.IdStudentInfo, strComparisonOpIdStudentInfo);
}
if (objcc_WorkStuRelation_TotalByQuTypeCond.IsUpdated(concc_WorkStuRelation_TotalByQuType.QuestionTypeId) == true)
{
string strComparisonOpQuestionTypeId = objcc_WorkStuRelation_TotalByQuTypeCond.dicFldComparisonOp[concc_WorkStuRelation_TotalByQuType.QuestionTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", concc_WorkStuRelation_TotalByQuType.QuestionTypeId, objcc_WorkStuRelation_TotalByQuTypeCond.QuestionTypeId, strComparisonOpQuestionTypeId);
}
if (objcc_WorkStuRelation_TotalByQuTypeCond.IsUpdated(concc_WorkStuRelation_TotalByQuType.QuestionTypeId4Course) == true)
{
string strComparisonOpQuestionTypeId4Course = objcc_WorkStuRelation_TotalByQuTypeCond.dicFldComparisonOp[concc_WorkStuRelation_TotalByQuType.QuestionTypeId4Course];
strWhereCond += string.Format(" And {0} {2} '{1}'", concc_WorkStuRelation_TotalByQuType.QuestionTypeId4Course, objcc_WorkStuRelation_TotalByQuTypeCond.QuestionTypeId4Course, strComparisonOpQuestionTypeId4Course);
}
if (objcc_WorkStuRelation_TotalByQuTypeCond.IsUpdated(concc_WorkStuRelation_TotalByQuType.WorkNum) == true)
{
string strComparisonOpWorkNum = objcc_WorkStuRelation_TotalByQuTypeCond.dicFldComparisonOp[concc_WorkStuRelation_TotalByQuType.WorkNum];
strWhereCond += string.Format(" And {0} {2} {1}", concc_WorkStuRelation_TotalByQuType.WorkNum, objcc_WorkStuRelation_TotalByQuTypeCond.WorkNum, strComparisonOpWorkNum);
}
if (objcc_WorkStuRelation_TotalByQuTypeCond.IsUpdated(concc_WorkStuRelation_TotalByQuType.WorkNumSubmit) == true)
{
string strComparisonOpWorkNumSubmit = objcc_WorkStuRelation_TotalByQuTypeCond.dicFldComparisonOp[concc_WorkStuRelation_TotalByQuType.WorkNumSubmit];
strWhereCond += string.Format(" And {0} {2} {1}", concc_WorkStuRelation_TotalByQuType.WorkNumSubmit, objcc_WorkStuRelation_TotalByQuTypeCond.WorkNumSubmit, strComparisonOpWorkNumSubmit);
}
if (objcc_WorkStuRelation_TotalByQuTypeCond.IsUpdated(concc_WorkStuRelation_TotalByQuType.WorkNumSave) == true)
{
string strComparisonOpWorkNumSave = objcc_WorkStuRelation_TotalByQuTypeCond.dicFldComparisonOp[concc_WorkStuRelation_TotalByQuType.WorkNumSave];
strWhereCond += string.Format(" And {0} {2} {1}", concc_WorkStuRelation_TotalByQuType.WorkNumSave, objcc_WorkStuRelation_TotalByQuTypeCond.WorkNumSave, strComparisonOpWorkNumSave);
}
if (objcc_WorkStuRelation_TotalByQuTypeCond.IsUpdated(concc_WorkStuRelation_TotalByQuType.WorkNumNoFinish) == true)
{
string strComparisonOpWorkNumNoFinish = objcc_WorkStuRelation_TotalByQuTypeCond.dicFldComparisonOp[concc_WorkStuRelation_TotalByQuType.WorkNumNoFinish];
strWhereCond += string.Format(" And {0} {2} {1}", concc_WorkStuRelation_TotalByQuType.WorkNumNoFinish, objcc_WorkStuRelation_TotalByQuTypeCond.WorkNumNoFinish, strComparisonOpWorkNumNoFinish);
}
if (objcc_WorkStuRelation_TotalByQuTypeCond.IsUpdated(concc_WorkStuRelation_TotalByQuType.WorkNumSendBack) == true)
{
string strComparisonOpWorkNumSendBack = objcc_WorkStuRelation_TotalByQuTypeCond.dicFldComparisonOp[concc_WorkStuRelation_TotalByQuType.WorkNumSendBack];
strWhereCond += string.Format(" And {0} {2} {1}", concc_WorkStuRelation_TotalByQuType.WorkNumSendBack, objcc_WorkStuRelation_TotalByQuTypeCond.WorkNumSendBack, strComparisonOpWorkNumSendBack);
}
if (objcc_WorkStuRelation_TotalByQuTypeCond.IsUpdated(concc_WorkStuRelation_TotalByQuType.WorkNumMark) == true)
{
string strComparisonOpWorkNumMark = objcc_WorkStuRelation_TotalByQuTypeCond.dicFldComparisonOp[concc_WorkStuRelation_TotalByQuType.WorkNumMark];
strWhereCond += string.Format(" And {0} {2} {1}", concc_WorkStuRelation_TotalByQuType.WorkNumMark, objcc_WorkStuRelation_TotalByQuTypeCond.WorkNumMark, strComparisonOpWorkNumMark);
}
if (objcc_WorkStuRelation_TotalByQuTypeCond.IsUpdated(concc_WorkStuRelation_TotalByQuType.WorkNumLook) == true)
{
string strComparisonOpWorkNumLook = objcc_WorkStuRelation_TotalByQuTypeCond.dicFldComparisonOp[concc_WorkStuRelation_TotalByQuType.WorkNumLook];
strWhereCond += string.Format(" And {0} {2} {1}", concc_WorkStuRelation_TotalByQuType.WorkNumLook, objcc_WorkStuRelation_TotalByQuTypeCond.WorkNumLook, strComparisonOpWorkNumLook);
}
if (objcc_WorkStuRelation_TotalByQuTypeCond.IsUpdated(concc_WorkStuRelation_TotalByQuType.WorkNumOverdue) == true)
{
string strComparisonOpWorkNumOverdue = objcc_WorkStuRelation_TotalByQuTypeCond.dicFldComparisonOp[concc_WorkStuRelation_TotalByQuType.WorkNumOverdue];
strWhereCond += string.Format(" And {0} {2} {1}", concc_WorkStuRelation_TotalByQuType.WorkNumOverdue, objcc_WorkStuRelation_TotalByQuTypeCond.WorkNumOverdue, strComparisonOpWorkNumOverdue);
}
if (objcc_WorkStuRelation_TotalByQuTypeCond.IsUpdated(concc_WorkStuRelation_TotalByQuType.TotalScore) == true)
{
string strComparisonOpTotalScore = objcc_WorkStuRelation_TotalByQuTypeCond.dicFldComparisonOp[concc_WorkStuRelation_TotalByQuType.TotalScore];
strWhereCond += string.Format(" And {0} {2} {1}", concc_WorkStuRelation_TotalByQuType.TotalScore, objcc_WorkStuRelation_TotalByQuTypeCond.TotalScore, strComparisonOpTotalScore);
}
if (objcc_WorkStuRelation_TotalByQuTypeCond.IsUpdated(concc_WorkStuRelation_TotalByQuType.TotalScores) == true)
{
string strComparisonOpTotalScores = objcc_WorkStuRelation_TotalByQuTypeCond.dicFldComparisonOp[concc_WorkStuRelation_TotalByQuType.TotalScores];
strWhereCond += string.Format(" And {0} {2} {1}", concc_WorkStuRelation_TotalByQuType.TotalScores, objcc_WorkStuRelation_TotalByQuTypeCond.TotalScores, strComparisonOpTotalScores);
}
if (objcc_WorkStuRelation_TotalByQuTypeCond.IsUpdated(concc_WorkStuRelation_TotalByQuType.SchoolYear) == true)
{
string strComparisonOpSchoolYear = objcc_WorkStuRelation_TotalByQuTypeCond.dicFldComparisonOp[concc_WorkStuRelation_TotalByQuType.SchoolYear];
strWhereCond += string.Format(" And {0} {2} '{1}'", concc_WorkStuRelation_TotalByQuType.SchoolYear, objcc_WorkStuRelation_TotalByQuTypeCond.SchoolYear, strComparisonOpSchoolYear);
}
if (objcc_WorkStuRelation_TotalByQuTypeCond.IsUpdated(concc_WorkStuRelation_TotalByQuType.SchoolTerm) == true)
{
string strComparisonOpSchoolTerm = objcc_WorkStuRelation_TotalByQuTypeCond.dicFldComparisonOp[concc_WorkStuRelation_TotalByQuType.SchoolTerm];
strWhereCond += string.Format(" And {0} {2} '{1}'", concc_WorkStuRelation_TotalByQuType.SchoolTerm, objcc_WorkStuRelation_TotalByQuTypeCond.SchoolTerm, strComparisonOpSchoolTerm);
}
if (objcc_WorkStuRelation_TotalByQuTypeCond.IsUpdated(concc_WorkStuRelation_TotalByQuType.UpdDate) == true)
{
string strComparisonOpUpdDate = objcc_WorkStuRelation_TotalByQuTypeCond.dicFldComparisonOp[concc_WorkStuRelation_TotalByQuType.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", concc_WorkStuRelation_TotalByQuType.UpdDate, objcc_WorkStuRelation_TotalByQuTypeCond.UpdDate, strComparisonOpUpdDate);
}
if (objcc_WorkStuRelation_TotalByQuTypeCond.IsUpdated(concc_WorkStuRelation_TotalByQuType.UpdUserId) == true)
{
string strComparisonOpUpdUserId = objcc_WorkStuRelation_TotalByQuTypeCond.dicFldComparisonOp[concc_WorkStuRelation_TotalByQuType.UpdUserId];
strWhereCond += string.Format(" And {0} {2} '{1}'", concc_WorkStuRelation_TotalByQuType.UpdUserId, objcc_WorkStuRelation_TotalByQuTypeCond.UpdUserId, strComparisonOpUpdUserId);
}
if (objcc_WorkStuRelation_TotalByQuTypeCond.IsUpdated(concc_WorkStuRelation_TotalByQuType.Memo) == true)
{
string strComparisonOpMemo = objcc_WorkStuRelation_TotalByQuTypeCond.dicFldComparisonOp[concc_WorkStuRelation_TotalByQuType.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", concc_WorkStuRelation_TotalByQuType.Memo, objcc_WorkStuRelation_TotalByQuTypeCond.Memo, strComparisonOpMemo);
}
 return strWhereCond;
}

 /// <summary>
 /// 检查唯一性(Uniqueness)--cc_WorkStuRelation_TotalByQuType(作业完成情况汇总表ByQuType), 如果不唯一,即存在相同的记录,就返回False
 /// 唯一性条件:id_CurrEduCls_id_StudentInfo
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckConstraint)
 /// </summary>
 /// <param name = "objcc_WorkStuRelation_TotalByQuTypeEN">要求唯一的对象</param>
 /// <returns></returns>
public static bool CheckUniqueness(this clscc_WorkStuRelation_TotalByQuTypeEN objcc_WorkStuRelation_TotalByQuTypeEN)
{
//检测记录是否存在
bool bolIsUniqueness;
StringBuilder sbCondition = new StringBuilder();
if (objcc_WorkStuRelation_TotalByQuTypeEN == null) return true;
if (objcc_WorkStuRelation_TotalByQuTypeEN.IdWorkStuRelationTotal == 0)
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and IdCurrEduCls = '{0}'", objcc_WorkStuRelation_TotalByQuTypeEN.IdCurrEduCls);
 sbCondition.AppendFormat(" and IdStudentInfo = '{0}'", objcc_WorkStuRelation_TotalByQuTypeEN.IdStudentInfo);
if (clscc_WorkStuRelation_TotalByQuTypeBL.IsExistRecord(sbCondition.ToString())  ==  true)
{
 bolIsUniqueness = false;
}
else
{
 bolIsUniqueness = true;
}
}
 else {
sbCondition.AppendFormat("IdWorkStuRelationTotal !=  {0}", objcc_WorkStuRelation_TotalByQuTypeEN.IdWorkStuRelationTotal);
 sbCondition.AppendFormat(" and IdCurrEduCls = '{0}'", objcc_WorkStuRelation_TotalByQuTypeEN.IdCurrEduCls);
 sbCondition.AppendFormat(" and IdStudentInfo = '{0}'", objcc_WorkStuRelation_TotalByQuTypeEN.IdStudentInfo);
if (clscc_WorkStuRelation_TotalByQuTypeBL.IsExistRecord(sbCondition.ToString())  ==  true)
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
 /// 获取唯一性条件串--cc_WorkStuRelation_TotalByQuType(作业完成情况汇总表ByQuType), 即由对象中唯一性条件字段关键字与值组成的条件串
 /// 唯一性条件:id_CurrEduCls_id_StudentInfo
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetConditionString4Constraint)
 /// </summary>
 /// <param name = "objcc_WorkStuRelation_TotalByQuTypeEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(this clscc_WorkStuRelation_TotalByQuTypeEN objcc_WorkStuRelation_TotalByQuTypeEN)
{
//检测记录是否存在
StringBuilder sbCondition = new StringBuilder();
if (objcc_WorkStuRelation_TotalByQuTypeEN == null) return "";
if (objcc_WorkStuRelation_TotalByQuTypeEN.IdWorkStuRelationTotal == 0)
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and IdCurrEduCls = '{0}'", objcc_WorkStuRelation_TotalByQuTypeEN.IdCurrEduCls);
 sbCondition.AppendFormat(" and IdStudentInfo = '{0}'", objcc_WorkStuRelation_TotalByQuTypeEN.IdStudentInfo);
return sbCondition.ToString();
}
 else {
sbCondition.AppendFormat("IdWorkStuRelationTotal !=  {0}", objcc_WorkStuRelation_TotalByQuTypeEN.IdWorkStuRelationTotal);
 sbCondition.AppendFormat(" and IdCurrEduCls = '{0}'", objcc_WorkStuRelation_TotalByQuTypeEN.IdCurrEduCls);
 sbCondition.AppendFormat(" and IdStudentInfo = '{0}'", objcc_WorkStuRelation_TotalByQuTypeEN.IdStudentInfo);
 return sbCondition.ToString();
}
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_cc_WorkStuRelation_TotalByQuType
{
public virtual bool UpdRelaTabDate(long lngIdWorkStuRelationTotal, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// 作业完成情况汇总表ByQuType(cc_WorkStuRelation_TotalByQuType)
 /// 数据源类型:表
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clscc_WorkStuRelation_TotalByQuTypeBL
{
public static RelatedActions_cc_WorkStuRelation_TotalByQuType relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clscc_WorkStuRelation_TotalByQuTypeDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clscc_WorkStuRelation_TotalByQuTypeDA cc_WorkStuRelation_TotalByQuTypeDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clscc_WorkStuRelation_TotalByQuTypeDA();
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
 public clscc_WorkStuRelation_TotalByQuTypeBL()
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
if (string.IsNullOrEmpty(clscc_WorkStuRelation_TotalByQuTypeEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clscc_WorkStuRelation_TotalByQuTypeEN._ConnectString);
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
public static DataTable GetDataTable_cc_WorkStuRelation_TotalByQuType(string strWhereCond)
{
DataTable objDT;
try
{
objDT = cc_WorkStuRelation_TotalByQuTypeDA.GetDataTable_cc_WorkStuRelation_TotalByQuType(strWhereCond);
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
objDT = cc_WorkStuRelation_TotalByQuTypeDA.GetDataTable(strWhereCond);
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
objDT = cc_WorkStuRelation_TotalByQuTypeDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = cc_WorkStuRelation_TotalByQuTypeDA.GetDataTable(strWhereCond, strTabName);
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
objDT = cc_WorkStuRelation_TotalByQuTypeDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = cc_WorkStuRelation_TotalByQuTypeDA.GetDataTable_Top(objTopPara);
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
objDT = cc_WorkStuRelation_TotalByQuTypeDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = cc_WorkStuRelation_TotalByQuTypeDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = cc_WorkStuRelation_TotalByQuTypeDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
 /// <param name = "arrIdWorkStuRelationTotalLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static List<clscc_WorkStuRelation_TotalByQuTypeEN> GetObjLstByIdWorkStuRelationTotalLst(List<long> arrIdWorkStuRelationTotalLst)
{
List<clscc_WorkStuRelation_TotalByQuTypeEN> arrObjLst = new List<clscc_WorkStuRelation_TotalByQuTypeEN>(); 
System.Data.DataTable objDT; 
 string strSqlConditionStr = clsArray.GetSqlInStrByArray(arrIdWorkStuRelationTotalLst);
 string strWhereCond = string.Format("IdWorkStuRelationTotal in ({0})", strSqlConditionStr);
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clscc_WorkStuRelation_TotalByQuTypeEN objcc_WorkStuRelation_TotalByQuTypeEN = new clscc_WorkStuRelation_TotalByQuTypeEN();
try
{
objcc_WorkStuRelation_TotalByQuTypeEN.IdWorkStuRelationTotal = Int32.Parse(objRow[concc_WorkStuRelation_TotalByQuType.IdWorkStuRelationTotal].ToString().Trim()); //流水号
objcc_WorkStuRelation_TotalByQuTypeEN.IdCurrEduCls = objRow[concc_WorkStuRelation_TotalByQuType.IdCurrEduCls].ToString().Trim(); //教学班流水号
objcc_WorkStuRelation_TotalByQuTypeEN.IdStudentInfo = objRow[concc_WorkStuRelation_TotalByQuType.IdStudentInfo].ToString().Trim(); //学生流水号
objcc_WorkStuRelation_TotalByQuTypeEN.QuestionTypeId = objRow[concc_WorkStuRelation_TotalByQuType.QuestionTypeId] == DBNull.Value ? null : objRow[concc_WorkStuRelation_TotalByQuType.QuestionTypeId].ToString().Trim(); //题目类型Id
objcc_WorkStuRelation_TotalByQuTypeEN.QuestionTypeId4Course = objRow[concc_WorkStuRelation_TotalByQuType.QuestionTypeId4Course] == DBNull.Value ? null : objRow[concc_WorkStuRelation_TotalByQuType.QuestionTypeId4Course].ToString().Trim(); //题目类型Id4课程
objcc_WorkStuRelation_TotalByQuTypeEN.WorkNum = Int32.Parse(objRow[concc_WorkStuRelation_TotalByQuType.WorkNum].ToString().Trim()); //作业数
objcc_WorkStuRelation_TotalByQuTypeEN.WorkNumSubmit = objRow[concc_WorkStuRelation_TotalByQuType.WorkNumSubmit] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[concc_WorkStuRelation_TotalByQuType.WorkNumSubmit].ToString().Trim()); //提交作业数
objcc_WorkStuRelation_TotalByQuTypeEN.WorkNumSave = objRow[concc_WorkStuRelation_TotalByQuType.WorkNumSave] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[concc_WorkStuRelation_TotalByQuType.WorkNumSave].ToString().Trim()); //保存作业数
objcc_WorkStuRelation_TotalByQuTypeEN.WorkNumNoFinish = objRow[concc_WorkStuRelation_TotalByQuType.WorkNumNoFinish] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[concc_WorkStuRelation_TotalByQuType.WorkNumNoFinish].ToString().Trim()); //未完成作业数
objcc_WorkStuRelation_TotalByQuTypeEN.WorkNumSendBack = objRow[concc_WorkStuRelation_TotalByQuType.WorkNumSendBack] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[concc_WorkStuRelation_TotalByQuType.WorkNumSendBack].ToString().Trim()); //退回作业数
objcc_WorkStuRelation_TotalByQuTypeEN.WorkNumMark = objRow[concc_WorkStuRelation_TotalByQuType.WorkNumMark] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[concc_WorkStuRelation_TotalByQuType.WorkNumMark].ToString().Trim()); //批改作业数
objcc_WorkStuRelation_TotalByQuTypeEN.WorkNumLook = objRow[concc_WorkStuRelation_TotalByQuType.WorkNumLook] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[concc_WorkStuRelation_TotalByQuType.WorkNumLook].ToString().Trim()); //查看作业数
objcc_WorkStuRelation_TotalByQuTypeEN.WorkNumOverdue = objRow[concc_WorkStuRelation_TotalByQuType.WorkNumOverdue] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[concc_WorkStuRelation_TotalByQuType.WorkNumOverdue].ToString().Trim()); //逾期作业数
objcc_WorkStuRelation_TotalByQuTypeEN.TotalScore = objRow[concc_WorkStuRelation_TotalByQuType.TotalScore] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[concc_WorkStuRelation_TotalByQuType.TotalScore].ToString().Trim()); //总得分
objcc_WorkStuRelation_TotalByQuTypeEN.TotalScores = objRow[concc_WorkStuRelation_TotalByQuType.TotalScores] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[concc_WorkStuRelation_TotalByQuType.TotalScores].ToString().Trim()); //总分值
objcc_WorkStuRelation_TotalByQuTypeEN.SchoolYear = objRow[concc_WorkStuRelation_TotalByQuType.SchoolYear] == DBNull.Value ? null : objRow[concc_WorkStuRelation_TotalByQuType.SchoolYear].ToString().Trim(); //学年
objcc_WorkStuRelation_TotalByQuTypeEN.SchoolTerm = objRow[concc_WorkStuRelation_TotalByQuType.SchoolTerm] == DBNull.Value ? null : objRow[concc_WorkStuRelation_TotalByQuType.SchoolTerm].ToString().Trim(); //学期
objcc_WorkStuRelation_TotalByQuTypeEN.UpdDate = objRow[concc_WorkStuRelation_TotalByQuType.UpdDate].ToString().Trim(); //修改日期
objcc_WorkStuRelation_TotalByQuTypeEN.UpdUserId = objRow[concc_WorkStuRelation_TotalByQuType.UpdUserId] == DBNull.Value ? null : objRow[concc_WorkStuRelation_TotalByQuType.UpdUserId].ToString().Trim(); //修改用户Id
objcc_WorkStuRelation_TotalByQuTypeEN.Memo = objRow[concc_WorkStuRelation_TotalByQuType.Memo] == DBNull.Value ? null : objRow[concc_WorkStuRelation_TotalByQuType.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objcc_WorkStuRelation_TotalByQuTypeEN.IdWorkStuRelationTotal, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objcc_WorkStuRelation_TotalByQuTypeEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrIdWorkStuRelationTotalLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clscc_WorkStuRelation_TotalByQuTypeEN> GetObjLstByIdWorkStuRelationTotalLstCache(List<long> arrIdWorkStuRelationTotalLst)
{
string strKey = string.Format("{0}", clscc_WorkStuRelation_TotalByQuTypeEN._CurrTabName);
List<clscc_WorkStuRelation_TotalByQuTypeEN> arrcc_WorkStuRelation_TotalByQuTypeObjLstCache = GetObjLstCache();
IEnumerable <clscc_WorkStuRelation_TotalByQuTypeEN> arrcc_WorkStuRelation_TotalByQuTypeObjLst_Sel =
arrcc_WorkStuRelation_TotalByQuTypeObjLstCache
.Where(x => arrIdWorkStuRelationTotalLst.Contains(x.IdWorkStuRelationTotal));
return arrcc_WorkStuRelation_TotalByQuTypeObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clscc_WorkStuRelation_TotalByQuTypeEN> GetObjLst(string strWhereCond)
{
List<clscc_WorkStuRelation_TotalByQuTypeEN> arrObjLst = new List<clscc_WorkStuRelation_TotalByQuTypeEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clscc_WorkStuRelation_TotalByQuTypeEN objcc_WorkStuRelation_TotalByQuTypeEN = new clscc_WorkStuRelation_TotalByQuTypeEN();
try
{
objcc_WorkStuRelation_TotalByQuTypeEN.IdWorkStuRelationTotal = Int32.Parse(objRow[concc_WorkStuRelation_TotalByQuType.IdWorkStuRelationTotal].ToString().Trim()); //流水号
objcc_WorkStuRelation_TotalByQuTypeEN.IdCurrEduCls = objRow[concc_WorkStuRelation_TotalByQuType.IdCurrEduCls].ToString().Trim(); //教学班流水号
objcc_WorkStuRelation_TotalByQuTypeEN.IdStudentInfo = objRow[concc_WorkStuRelation_TotalByQuType.IdStudentInfo].ToString().Trim(); //学生流水号
objcc_WorkStuRelation_TotalByQuTypeEN.QuestionTypeId = objRow[concc_WorkStuRelation_TotalByQuType.QuestionTypeId] == DBNull.Value ? null : objRow[concc_WorkStuRelation_TotalByQuType.QuestionTypeId].ToString().Trim(); //题目类型Id
objcc_WorkStuRelation_TotalByQuTypeEN.QuestionTypeId4Course = objRow[concc_WorkStuRelation_TotalByQuType.QuestionTypeId4Course] == DBNull.Value ? null : objRow[concc_WorkStuRelation_TotalByQuType.QuestionTypeId4Course].ToString().Trim(); //题目类型Id4课程
objcc_WorkStuRelation_TotalByQuTypeEN.WorkNum = Int32.Parse(objRow[concc_WorkStuRelation_TotalByQuType.WorkNum].ToString().Trim()); //作业数
objcc_WorkStuRelation_TotalByQuTypeEN.WorkNumSubmit = objRow[concc_WorkStuRelation_TotalByQuType.WorkNumSubmit] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[concc_WorkStuRelation_TotalByQuType.WorkNumSubmit].ToString().Trim()); //提交作业数
objcc_WorkStuRelation_TotalByQuTypeEN.WorkNumSave = objRow[concc_WorkStuRelation_TotalByQuType.WorkNumSave] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[concc_WorkStuRelation_TotalByQuType.WorkNumSave].ToString().Trim()); //保存作业数
objcc_WorkStuRelation_TotalByQuTypeEN.WorkNumNoFinish = objRow[concc_WorkStuRelation_TotalByQuType.WorkNumNoFinish] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[concc_WorkStuRelation_TotalByQuType.WorkNumNoFinish].ToString().Trim()); //未完成作业数
objcc_WorkStuRelation_TotalByQuTypeEN.WorkNumSendBack = objRow[concc_WorkStuRelation_TotalByQuType.WorkNumSendBack] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[concc_WorkStuRelation_TotalByQuType.WorkNumSendBack].ToString().Trim()); //退回作业数
objcc_WorkStuRelation_TotalByQuTypeEN.WorkNumMark = objRow[concc_WorkStuRelation_TotalByQuType.WorkNumMark] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[concc_WorkStuRelation_TotalByQuType.WorkNumMark].ToString().Trim()); //批改作业数
objcc_WorkStuRelation_TotalByQuTypeEN.WorkNumLook = objRow[concc_WorkStuRelation_TotalByQuType.WorkNumLook] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[concc_WorkStuRelation_TotalByQuType.WorkNumLook].ToString().Trim()); //查看作业数
objcc_WorkStuRelation_TotalByQuTypeEN.WorkNumOverdue = objRow[concc_WorkStuRelation_TotalByQuType.WorkNumOverdue] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[concc_WorkStuRelation_TotalByQuType.WorkNumOverdue].ToString().Trim()); //逾期作业数
objcc_WorkStuRelation_TotalByQuTypeEN.TotalScore = objRow[concc_WorkStuRelation_TotalByQuType.TotalScore] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[concc_WorkStuRelation_TotalByQuType.TotalScore].ToString().Trim()); //总得分
objcc_WorkStuRelation_TotalByQuTypeEN.TotalScores = objRow[concc_WorkStuRelation_TotalByQuType.TotalScores] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[concc_WorkStuRelation_TotalByQuType.TotalScores].ToString().Trim()); //总分值
objcc_WorkStuRelation_TotalByQuTypeEN.SchoolYear = objRow[concc_WorkStuRelation_TotalByQuType.SchoolYear] == DBNull.Value ? null : objRow[concc_WorkStuRelation_TotalByQuType.SchoolYear].ToString().Trim(); //学年
objcc_WorkStuRelation_TotalByQuTypeEN.SchoolTerm = objRow[concc_WorkStuRelation_TotalByQuType.SchoolTerm] == DBNull.Value ? null : objRow[concc_WorkStuRelation_TotalByQuType.SchoolTerm].ToString().Trim(); //学期
objcc_WorkStuRelation_TotalByQuTypeEN.UpdDate = objRow[concc_WorkStuRelation_TotalByQuType.UpdDate].ToString().Trim(); //修改日期
objcc_WorkStuRelation_TotalByQuTypeEN.UpdUserId = objRow[concc_WorkStuRelation_TotalByQuType.UpdUserId] == DBNull.Value ? null : objRow[concc_WorkStuRelation_TotalByQuType.UpdUserId].ToString().Trim(); //修改用户Id
objcc_WorkStuRelation_TotalByQuTypeEN.Memo = objRow[concc_WorkStuRelation_TotalByQuType.Memo] == DBNull.Value ? null : objRow[concc_WorkStuRelation_TotalByQuType.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objcc_WorkStuRelation_TotalByQuTypeEN.IdWorkStuRelationTotal, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objcc_WorkStuRelation_TotalByQuTypeEN);
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
public static List<clscc_WorkStuRelation_TotalByQuTypeEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clscc_WorkStuRelation_TotalByQuTypeEN> arrObjLst = new List<clscc_WorkStuRelation_TotalByQuTypeEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clscc_WorkStuRelation_TotalByQuTypeEN objcc_WorkStuRelation_TotalByQuTypeEN = new clscc_WorkStuRelation_TotalByQuTypeEN();
try
{
objcc_WorkStuRelation_TotalByQuTypeEN.IdWorkStuRelationTotal = Int32.Parse(objRow[concc_WorkStuRelation_TotalByQuType.IdWorkStuRelationTotal].ToString().Trim()); //流水号
objcc_WorkStuRelation_TotalByQuTypeEN.IdCurrEduCls = objRow[concc_WorkStuRelation_TotalByQuType.IdCurrEduCls].ToString().Trim(); //教学班流水号
objcc_WorkStuRelation_TotalByQuTypeEN.IdStudentInfo = objRow[concc_WorkStuRelation_TotalByQuType.IdStudentInfo].ToString().Trim(); //学生流水号
objcc_WorkStuRelation_TotalByQuTypeEN.QuestionTypeId = objRow[concc_WorkStuRelation_TotalByQuType.QuestionTypeId] == DBNull.Value ? null : objRow[concc_WorkStuRelation_TotalByQuType.QuestionTypeId].ToString().Trim(); //题目类型Id
objcc_WorkStuRelation_TotalByQuTypeEN.QuestionTypeId4Course = objRow[concc_WorkStuRelation_TotalByQuType.QuestionTypeId4Course] == DBNull.Value ? null : objRow[concc_WorkStuRelation_TotalByQuType.QuestionTypeId4Course].ToString().Trim(); //题目类型Id4课程
objcc_WorkStuRelation_TotalByQuTypeEN.WorkNum = Int32.Parse(objRow[concc_WorkStuRelation_TotalByQuType.WorkNum].ToString().Trim()); //作业数
objcc_WorkStuRelation_TotalByQuTypeEN.WorkNumSubmit = objRow[concc_WorkStuRelation_TotalByQuType.WorkNumSubmit] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[concc_WorkStuRelation_TotalByQuType.WorkNumSubmit].ToString().Trim()); //提交作业数
objcc_WorkStuRelation_TotalByQuTypeEN.WorkNumSave = objRow[concc_WorkStuRelation_TotalByQuType.WorkNumSave] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[concc_WorkStuRelation_TotalByQuType.WorkNumSave].ToString().Trim()); //保存作业数
objcc_WorkStuRelation_TotalByQuTypeEN.WorkNumNoFinish = objRow[concc_WorkStuRelation_TotalByQuType.WorkNumNoFinish] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[concc_WorkStuRelation_TotalByQuType.WorkNumNoFinish].ToString().Trim()); //未完成作业数
objcc_WorkStuRelation_TotalByQuTypeEN.WorkNumSendBack = objRow[concc_WorkStuRelation_TotalByQuType.WorkNumSendBack] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[concc_WorkStuRelation_TotalByQuType.WorkNumSendBack].ToString().Trim()); //退回作业数
objcc_WorkStuRelation_TotalByQuTypeEN.WorkNumMark = objRow[concc_WorkStuRelation_TotalByQuType.WorkNumMark] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[concc_WorkStuRelation_TotalByQuType.WorkNumMark].ToString().Trim()); //批改作业数
objcc_WorkStuRelation_TotalByQuTypeEN.WorkNumLook = objRow[concc_WorkStuRelation_TotalByQuType.WorkNumLook] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[concc_WorkStuRelation_TotalByQuType.WorkNumLook].ToString().Trim()); //查看作业数
objcc_WorkStuRelation_TotalByQuTypeEN.WorkNumOverdue = objRow[concc_WorkStuRelation_TotalByQuType.WorkNumOverdue] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[concc_WorkStuRelation_TotalByQuType.WorkNumOverdue].ToString().Trim()); //逾期作业数
objcc_WorkStuRelation_TotalByQuTypeEN.TotalScore = objRow[concc_WorkStuRelation_TotalByQuType.TotalScore] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[concc_WorkStuRelation_TotalByQuType.TotalScore].ToString().Trim()); //总得分
objcc_WorkStuRelation_TotalByQuTypeEN.TotalScores = objRow[concc_WorkStuRelation_TotalByQuType.TotalScores] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[concc_WorkStuRelation_TotalByQuType.TotalScores].ToString().Trim()); //总分值
objcc_WorkStuRelation_TotalByQuTypeEN.SchoolYear = objRow[concc_WorkStuRelation_TotalByQuType.SchoolYear] == DBNull.Value ? null : objRow[concc_WorkStuRelation_TotalByQuType.SchoolYear].ToString().Trim(); //学年
objcc_WorkStuRelation_TotalByQuTypeEN.SchoolTerm = objRow[concc_WorkStuRelation_TotalByQuType.SchoolTerm] == DBNull.Value ? null : objRow[concc_WorkStuRelation_TotalByQuType.SchoolTerm].ToString().Trim(); //学期
objcc_WorkStuRelation_TotalByQuTypeEN.UpdDate = objRow[concc_WorkStuRelation_TotalByQuType.UpdDate].ToString().Trim(); //修改日期
objcc_WorkStuRelation_TotalByQuTypeEN.UpdUserId = objRow[concc_WorkStuRelation_TotalByQuType.UpdUserId] == DBNull.Value ? null : objRow[concc_WorkStuRelation_TotalByQuType.UpdUserId].ToString().Trim(); //修改用户Id
objcc_WorkStuRelation_TotalByQuTypeEN.Memo = objRow[concc_WorkStuRelation_TotalByQuType.Memo] == DBNull.Value ? null : objRow[concc_WorkStuRelation_TotalByQuType.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objcc_WorkStuRelation_TotalByQuTypeEN.IdWorkStuRelationTotal, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objcc_WorkStuRelation_TotalByQuTypeEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objcc_WorkStuRelation_TotalByQuTypeCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clscc_WorkStuRelation_TotalByQuTypeEN> GetSubObjLstCache(clscc_WorkStuRelation_TotalByQuTypeEN objcc_WorkStuRelation_TotalByQuTypeCond)
{
List<clscc_WorkStuRelation_TotalByQuTypeEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clscc_WorkStuRelation_TotalByQuTypeEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in concc_WorkStuRelation_TotalByQuType.AttributeName)
{
if (objcc_WorkStuRelation_TotalByQuTypeCond.IsUpdated(strFldName) == false) continue;
if (objcc_WorkStuRelation_TotalByQuTypeCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objcc_WorkStuRelation_TotalByQuTypeCond[strFldName].ToString());
}
else
{
if (objcc_WorkStuRelation_TotalByQuTypeCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objcc_WorkStuRelation_TotalByQuTypeCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objcc_WorkStuRelation_TotalByQuTypeCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objcc_WorkStuRelation_TotalByQuTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objcc_WorkStuRelation_TotalByQuTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objcc_WorkStuRelation_TotalByQuTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objcc_WorkStuRelation_TotalByQuTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objcc_WorkStuRelation_TotalByQuTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objcc_WorkStuRelation_TotalByQuTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objcc_WorkStuRelation_TotalByQuTypeCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objcc_WorkStuRelation_TotalByQuTypeCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objcc_WorkStuRelation_TotalByQuTypeCond[strFldName]));
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
public static List<clscc_WorkStuRelation_TotalByQuTypeEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clscc_WorkStuRelation_TotalByQuTypeEN> arrObjLst = new List<clscc_WorkStuRelation_TotalByQuTypeEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clscc_WorkStuRelation_TotalByQuTypeEN objcc_WorkStuRelation_TotalByQuTypeEN = new clscc_WorkStuRelation_TotalByQuTypeEN();
try
{
objcc_WorkStuRelation_TotalByQuTypeEN.IdWorkStuRelationTotal = Int32.Parse(objRow[concc_WorkStuRelation_TotalByQuType.IdWorkStuRelationTotal].ToString().Trim()); //流水号
objcc_WorkStuRelation_TotalByQuTypeEN.IdCurrEduCls = objRow[concc_WorkStuRelation_TotalByQuType.IdCurrEduCls].ToString().Trim(); //教学班流水号
objcc_WorkStuRelation_TotalByQuTypeEN.IdStudentInfo = objRow[concc_WorkStuRelation_TotalByQuType.IdStudentInfo].ToString().Trim(); //学生流水号
objcc_WorkStuRelation_TotalByQuTypeEN.QuestionTypeId = objRow[concc_WorkStuRelation_TotalByQuType.QuestionTypeId] == DBNull.Value ? null : objRow[concc_WorkStuRelation_TotalByQuType.QuestionTypeId].ToString().Trim(); //题目类型Id
objcc_WorkStuRelation_TotalByQuTypeEN.QuestionTypeId4Course = objRow[concc_WorkStuRelation_TotalByQuType.QuestionTypeId4Course] == DBNull.Value ? null : objRow[concc_WorkStuRelation_TotalByQuType.QuestionTypeId4Course].ToString().Trim(); //题目类型Id4课程
objcc_WorkStuRelation_TotalByQuTypeEN.WorkNum = Int32.Parse(objRow[concc_WorkStuRelation_TotalByQuType.WorkNum].ToString().Trim()); //作业数
objcc_WorkStuRelation_TotalByQuTypeEN.WorkNumSubmit = objRow[concc_WorkStuRelation_TotalByQuType.WorkNumSubmit] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[concc_WorkStuRelation_TotalByQuType.WorkNumSubmit].ToString().Trim()); //提交作业数
objcc_WorkStuRelation_TotalByQuTypeEN.WorkNumSave = objRow[concc_WorkStuRelation_TotalByQuType.WorkNumSave] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[concc_WorkStuRelation_TotalByQuType.WorkNumSave].ToString().Trim()); //保存作业数
objcc_WorkStuRelation_TotalByQuTypeEN.WorkNumNoFinish = objRow[concc_WorkStuRelation_TotalByQuType.WorkNumNoFinish] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[concc_WorkStuRelation_TotalByQuType.WorkNumNoFinish].ToString().Trim()); //未完成作业数
objcc_WorkStuRelation_TotalByQuTypeEN.WorkNumSendBack = objRow[concc_WorkStuRelation_TotalByQuType.WorkNumSendBack] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[concc_WorkStuRelation_TotalByQuType.WorkNumSendBack].ToString().Trim()); //退回作业数
objcc_WorkStuRelation_TotalByQuTypeEN.WorkNumMark = objRow[concc_WorkStuRelation_TotalByQuType.WorkNumMark] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[concc_WorkStuRelation_TotalByQuType.WorkNumMark].ToString().Trim()); //批改作业数
objcc_WorkStuRelation_TotalByQuTypeEN.WorkNumLook = objRow[concc_WorkStuRelation_TotalByQuType.WorkNumLook] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[concc_WorkStuRelation_TotalByQuType.WorkNumLook].ToString().Trim()); //查看作业数
objcc_WorkStuRelation_TotalByQuTypeEN.WorkNumOverdue = objRow[concc_WorkStuRelation_TotalByQuType.WorkNumOverdue] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[concc_WorkStuRelation_TotalByQuType.WorkNumOverdue].ToString().Trim()); //逾期作业数
objcc_WorkStuRelation_TotalByQuTypeEN.TotalScore = objRow[concc_WorkStuRelation_TotalByQuType.TotalScore] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[concc_WorkStuRelation_TotalByQuType.TotalScore].ToString().Trim()); //总得分
objcc_WorkStuRelation_TotalByQuTypeEN.TotalScores = objRow[concc_WorkStuRelation_TotalByQuType.TotalScores] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[concc_WorkStuRelation_TotalByQuType.TotalScores].ToString().Trim()); //总分值
objcc_WorkStuRelation_TotalByQuTypeEN.SchoolYear = objRow[concc_WorkStuRelation_TotalByQuType.SchoolYear] == DBNull.Value ? null : objRow[concc_WorkStuRelation_TotalByQuType.SchoolYear].ToString().Trim(); //学年
objcc_WorkStuRelation_TotalByQuTypeEN.SchoolTerm = objRow[concc_WorkStuRelation_TotalByQuType.SchoolTerm] == DBNull.Value ? null : objRow[concc_WorkStuRelation_TotalByQuType.SchoolTerm].ToString().Trim(); //学期
objcc_WorkStuRelation_TotalByQuTypeEN.UpdDate = objRow[concc_WorkStuRelation_TotalByQuType.UpdDate].ToString().Trim(); //修改日期
objcc_WorkStuRelation_TotalByQuTypeEN.UpdUserId = objRow[concc_WorkStuRelation_TotalByQuType.UpdUserId] == DBNull.Value ? null : objRow[concc_WorkStuRelation_TotalByQuType.UpdUserId].ToString().Trim(); //修改用户Id
objcc_WorkStuRelation_TotalByQuTypeEN.Memo = objRow[concc_WorkStuRelation_TotalByQuType.Memo] == DBNull.Value ? null : objRow[concc_WorkStuRelation_TotalByQuType.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objcc_WorkStuRelation_TotalByQuTypeEN.IdWorkStuRelationTotal, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objcc_WorkStuRelation_TotalByQuTypeEN);
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
public static List<clscc_WorkStuRelation_TotalByQuTypeEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clscc_WorkStuRelation_TotalByQuTypeEN> arrObjLst = new List<clscc_WorkStuRelation_TotalByQuTypeEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clscc_WorkStuRelation_TotalByQuTypeEN objcc_WorkStuRelation_TotalByQuTypeEN = new clscc_WorkStuRelation_TotalByQuTypeEN();
try
{
objcc_WorkStuRelation_TotalByQuTypeEN.IdWorkStuRelationTotal = Int32.Parse(objRow[concc_WorkStuRelation_TotalByQuType.IdWorkStuRelationTotal].ToString().Trim()); //流水号
objcc_WorkStuRelation_TotalByQuTypeEN.IdCurrEduCls = objRow[concc_WorkStuRelation_TotalByQuType.IdCurrEduCls].ToString().Trim(); //教学班流水号
objcc_WorkStuRelation_TotalByQuTypeEN.IdStudentInfo = objRow[concc_WorkStuRelation_TotalByQuType.IdStudentInfo].ToString().Trim(); //学生流水号
objcc_WorkStuRelation_TotalByQuTypeEN.QuestionTypeId = objRow[concc_WorkStuRelation_TotalByQuType.QuestionTypeId] == DBNull.Value ? null : objRow[concc_WorkStuRelation_TotalByQuType.QuestionTypeId].ToString().Trim(); //题目类型Id
objcc_WorkStuRelation_TotalByQuTypeEN.QuestionTypeId4Course = objRow[concc_WorkStuRelation_TotalByQuType.QuestionTypeId4Course] == DBNull.Value ? null : objRow[concc_WorkStuRelation_TotalByQuType.QuestionTypeId4Course].ToString().Trim(); //题目类型Id4课程
objcc_WorkStuRelation_TotalByQuTypeEN.WorkNum = Int32.Parse(objRow[concc_WorkStuRelation_TotalByQuType.WorkNum].ToString().Trim()); //作业数
objcc_WorkStuRelation_TotalByQuTypeEN.WorkNumSubmit = objRow[concc_WorkStuRelation_TotalByQuType.WorkNumSubmit] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[concc_WorkStuRelation_TotalByQuType.WorkNumSubmit].ToString().Trim()); //提交作业数
objcc_WorkStuRelation_TotalByQuTypeEN.WorkNumSave = objRow[concc_WorkStuRelation_TotalByQuType.WorkNumSave] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[concc_WorkStuRelation_TotalByQuType.WorkNumSave].ToString().Trim()); //保存作业数
objcc_WorkStuRelation_TotalByQuTypeEN.WorkNumNoFinish = objRow[concc_WorkStuRelation_TotalByQuType.WorkNumNoFinish] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[concc_WorkStuRelation_TotalByQuType.WorkNumNoFinish].ToString().Trim()); //未完成作业数
objcc_WorkStuRelation_TotalByQuTypeEN.WorkNumSendBack = objRow[concc_WorkStuRelation_TotalByQuType.WorkNumSendBack] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[concc_WorkStuRelation_TotalByQuType.WorkNumSendBack].ToString().Trim()); //退回作业数
objcc_WorkStuRelation_TotalByQuTypeEN.WorkNumMark = objRow[concc_WorkStuRelation_TotalByQuType.WorkNumMark] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[concc_WorkStuRelation_TotalByQuType.WorkNumMark].ToString().Trim()); //批改作业数
objcc_WorkStuRelation_TotalByQuTypeEN.WorkNumLook = objRow[concc_WorkStuRelation_TotalByQuType.WorkNumLook] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[concc_WorkStuRelation_TotalByQuType.WorkNumLook].ToString().Trim()); //查看作业数
objcc_WorkStuRelation_TotalByQuTypeEN.WorkNumOverdue = objRow[concc_WorkStuRelation_TotalByQuType.WorkNumOverdue] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[concc_WorkStuRelation_TotalByQuType.WorkNumOverdue].ToString().Trim()); //逾期作业数
objcc_WorkStuRelation_TotalByQuTypeEN.TotalScore = objRow[concc_WorkStuRelation_TotalByQuType.TotalScore] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[concc_WorkStuRelation_TotalByQuType.TotalScore].ToString().Trim()); //总得分
objcc_WorkStuRelation_TotalByQuTypeEN.TotalScores = objRow[concc_WorkStuRelation_TotalByQuType.TotalScores] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[concc_WorkStuRelation_TotalByQuType.TotalScores].ToString().Trim()); //总分值
objcc_WorkStuRelation_TotalByQuTypeEN.SchoolYear = objRow[concc_WorkStuRelation_TotalByQuType.SchoolYear] == DBNull.Value ? null : objRow[concc_WorkStuRelation_TotalByQuType.SchoolYear].ToString().Trim(); //学年
objcc_WorkStuRelation_TotalByQuTypeEN.SchoolTerm = objRow[concc_WorkStuRelation_TotalByQuType.SchoolTerm] == DBNull.Value ? null : objRow[concc_WorkStuRelation_TotalByQuType.SchoolTerm].ToString().Trim(); //学期
objcc_WorkStuRelation_TotalByQuTypeEN.UpdDate = objRow[concc_WorkStuRelation_TotalByQuType.UpdDate].ToString().Trim(); //修改日期
objcc_WorkStuRelation_TotalByQuTypeEN.UpdUserId = objRow[concc_WorkStuRelation_TotalByQuType.UpdUserId] == DBNull.Value ? null : objRow[concc_WorkStuRelation_TotalByQuType.UpdUserId].ToString().Trim(); //修改用户Id
objcc_WorkStuRelation_TotalByQuTypeEN.Memo = objRow[concc_WorkStuRelation_TotalByQuType.Memo] == DBNull.Value ? null : objRow[concc_WorkStuRelation_TotalByQuType.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objcc_WorkStuRelation_TotalByQuTypeEN.IdWorkStuRelationTotal, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objcc_WorkStuRelation_TotalByQuTypeEN);
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
List<clscc_WorkStuRelation_TotalByQuTypeEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clscc_WorkStuRelation_TotalByQuTypeEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clscc_WorkStuRelation_TotalByQuTypeEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clscc_WorkStuRelation_TotalByQuTypeEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clscc_WorkStuRelation_TotalByQuTypeEN> arrObjLst = new List<clscc_WorkStuRelation_TotalByQuTypeEN>(); 
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
	clscc_WorkStuRelation_TotalByQuTypeEN objcc_WorkStuRelation_TotalByQuTypeEN = new clscc_WorkStuRelation_TotalByQuTypeEN();
try
{
objcc_WorkStuRelation_TotalByQuTypeEN.IdWorkStuRelationTotal = Int32.Parse(objRow[concc_WorkStuRelation_TotalByQuType.IdWorkStuRelationTotal].ToString().Trim()); //流水号
objcc_WorkStuRelation_TotalByQuTypeEN.IdCurrEduCls = objRow[concc_WorkStuRelation_TotalByQuType.IdCurrEduCls].ToString().Trim(); //教学班流水号
objcc_WorkStuRelation_TotalByQuTypeEN.IdStudentInfo = objRow[concc_WorkStuRelation_TotalByQuType.IdStudentInfo].ToString().Trim(); //学生流水号
objcc_WorkStuRelation_TotalByQuTypeEN.QuestionTypeId = objRow[concc_WorkStuRelation_TotalByQuType.QuestionTypeId] == DBNull.Value ? null : objRow[concc_WorkStuRelation_TotalByQuType.QuestionTypeId].ToString().Trim(); //题目类型Id
objcc_WorkStuRelation_TotalByQuTypeEN.QuestionTypeId4Course = objRow[concc_WorkStuRelation_TotalByQuType.QuestionTypeId4Course] == DBNull.Value ? null : objRow[concc_WorkStuRelation_TotalByQuType.QuestionTypeId4Course].ToString().Trim(); //题目类型Id4课程
objcc_WorkStuRelation_TotalByQuTypeEN.WorkNum = Int32.Parse(objRow[concc_WorkStuRelation_TotalByQuType.WorkNum].ToString().Trim()); //作业数
objcc_WorkStuRelation_TotalByQuTypeEN.WorkNumSubmit = objRow[concc_WorkStuRelation_TotalByQuType.WorkNumSubmit] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[concc_WorkStuRelation_TotalByQuType.WorkNumSubmit].ToString().Trim()); //提交作业数
objcc_WorkStuRelation_TotalByQuTypeEN.WorkNumSave = objRow[concc_WorkStuRelation_TotalByQuType.WorkNumSave] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[concc_WorkStuRelation_TotalByQuType.WorkNumSave].ToString().Trim()); //保存作业数
objcc_WorkStuRelation_TotalByQuTypeEN.WorkNumNoFinish = objRow[concc_WorkStuRelation_TotalByQuType.WorkNumNoFinish] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[concc_WorkStuRelation_TotalByQuType.WorkNumNoFinish].ToString().Trim()); //未完成作业数
objcc_WorkStuRelation_TotalByQuTypeEN.WorkNumSendBack = objRow[concc_WorkStuRelation_TotalByQuType.WorkNumSendBack] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[concc_WorkStuRelation_TotalByQuType.WorkNumSendBack].ToString().Trim()); //退回作业数
objcc_WorkStuRelation_TotalByQuTypeEN.WorkNumMark = objRow[concc_WorkStuRelation_TotalByQuType.WorkNumMark] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[concc_WorkStuRelation_TotalByQuType.WorkNumMark].ToString().Trim()); //批改作业数
objcc_WorkStuRelation_TotalByQuTypeEN.WorkNumLook = objRow[concc_WorkStuRelation_TotalByQuType.WorkNumLook] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[concc_WorkStuRelation_TotalByQuType.WorkNumLook].ToString().Trim()); //查看作业数
objcc_WorkStuRelation_TotalByQuTypeEN.WorkNumOverdue = objRow[concc_WorkStuRelation_TotalByQuType.WorkNumOverdue] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[concc_WorkStuRelation_TotalByQuType.WorkNumOverdue].ToString().Trim()); //逾期作业数
objcc_WorkStuRelation_TotalByQuTypeEN.TotalScore = objRow[concc_WorkStuRelation_TotalByQuType.TotalScore] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[concc_WorkStuRelation_TotalByQuType.TotalScore].ToString().Trim()); //总得分
objcc_WorkStuRelation_TotalByQuTypeEN.TotalScores = objRow[concc_WorkStuRelation_TotalByQuType.TotalScores] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[concc_WorkStuRelation_TotalByQuType.TotalScores].ToString().Trim()); //总分值
objcc_WorkStuRelation_TotalByQuTypeEN.SchoolYear = objRow[concc_WorkStuRelation_TotalByQuType.SchoolYear] == DBNull.Value ? null : objRow[concc_WorkStuRelation_TotalByQuType.SchoolYear].ToString().Trim(); //学年
objcc_WorkStuRelation_TotalByQuTypeEN.SchoolTerm = objRow[concc_WorkStuRelation_TotalByQuType.SchoolTerm] == DBNull.Value ? null : objRow[concc_WorkStuRelation_TotalByQuType.SchoolTerm].ToString().Trim(); //学期
objcc_WorkStuRelation_TotalByQuTypeEN.UpdDate = objRow[concc_WorkStuRelation_TotalByQuType.UpdDate].ToString().Trim(); //修改日期
objcc_WorkStuRelation_TotalByQuTypeEN.UpdUserId = objRow[concc_WorkStuRelation_TotalByQuType.UpdUserId] == DBNull.Value ? null : objRow[concc_WorkStuRelation_TotalByQuType.UpdUserId].ToString().Trim(); //修改用户Id
objcc_WorkStuRelation_TotalByQuTypeEN.Memo = objRow[concc_WorkStuRelation_TotalByQuType.Memo] == DBNull.Value ? null : objRow[concc_WorkStuRelation_TotalByQuType.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objcc_WorkStuRelation_TotalByQuTypeEN.IdWorkStuRelationTotal, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objcc_WorkStuRelation_TotalByQuTypeEN);
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
public static List<clscc_WorkStuRelation_TotalByQuTypeEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clscc_WorkStuRelation_TotalByQuTypeEN> arrObjLst = new List<clscc_WorkStuRelation_TotalByQuTypeEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clscc_WorkStuRelation_TotalByQuTypeEN objcc_WorkStuRelation_TotalByQuTypeEN = new clscc_WorkStuRelation_TotalByQuTypeEN();
try
{
objcc_WorkStuRelation_TotalByQuTypeEN.IdWorkStuRelationTotal = Int32.Parse(objRow[concc_WorkStuRelation_TotalByQuType.IdWorkStuRelationTotal].ToString().Trim()); //流水号
objcc_WorkStuRelation_TotalByQuTypeEN.IdCurrEduCls = objRow[concc_WorkStuRelation_TotalByQuType.IdCurrEduCls].ToString().Trim(); //教学班流水号
objcc_WorkStuRelation_TotalByQuTypeEN.IdStudentInfo = objRow[concc_WorkStuRelation_TotalByQuType.IdStudentInfo].ToString().Trim(); //学生流水号
objcc_WorkStuRelation_TotalByQuTypeEN.QuestionTypeId = objRow[concc_WorkStuRelation_TotalByQuType.QuestionTypeId] == DBNull.Value ? null : objRow[concc_WorkStuRelation_TotalByQuType.QuestionTypeId].ToString().Trim(); //题目类型Id
objcc_WorkStuRelation_TotalByQuTypeEN.QuestionTypeId4Course = objRow[concc_WorkStuRelation_TotalByQuType.QuestionTypeId4Course] == DBNull.Value ? null : objRow[concc_WorkStuRelation_TotalByQuType.QuestionTypeId4Course].ToString().Trim(); //题目类型Id4课程
objcc_WorkStuRelation_TotalByQuTypeEN.WorkNum = Int32.Parse(objRow[concc_WorkStuRelation_TotalByQuType.WorkNum].ToString().Trim()); //作业数
objcc_WorkStuRelation_TotalByQuTypeEN.WorkNumSubmit = objRow[concc_WorkStuRelation_TotalByQuType.WorkNumSubmit] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[concc_WorkStuRelation_TotalByQuType.WorkNumSubmit].ToString().Trim()); //提交作业数
objcc_WorkStuRelation_TotalByQuTypeEN.WorkNumSave = objRow[concc_WorkStuRelation_TotalByQuType.WorkNumSave] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[concc_WorkStuRelation_TotalByQuType.WorkNumSave].ToString().Trim()); //保存作业数
objcc_WorkStuRelation_TotalByQuTypeEN.WorkNumNoFinish = objRow[concc_WorkStuRelation_TotalByQuType.WorkNumNoFinish] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[concc_WorkStuRelation_TotalByQuType.WorkNumNoFinish].ToString().Trim()); //未完成作业数
objcc_WorkStuRelation_TotalByQuTypeEN.WorkNumSendBack = objRow[concc_WorkStuRelation_TotalByQuType.WorkNumSendBack] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[concc_WorkStuRelation_TotalByQuType.WorkNumSendBack].ToString().Trim()); //退回作业数
objcc_WorkStuRelation_TotalByQuTypeEN.WorkNumMark = objRow[concc_WorkStuRelation_TotalByQuType.WorkNumMark] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[concc_WorkStuRelation_TotalByQuType.WorkNumMark].ToString().Trim()); //批改作业数
objcc_WorkStuRelation_TotalByQuTypeEN.WorkNumLook = objRow[concc_WorkStuRelation_TotalByQuType.WorkNumLook] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[concc_WorkStuRelation_TotalByQuType.WorkNumLook].ToString().Trim()); //查看作业数
objcc_WorkStuRelation_TotalByQuTypeEN.WorkNumOverdue = objRow[concc_WorkStuRelation_TotalByQuType.WorkNumOverdue] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[concc_WorkStuRelation_TotalByQuType.WorkNumOverdue].ToString().Trim()); //逾期作业数
objcc_WorkStuRelation_TotalByQuTypeEN.TotalScore = objRow[concc_WorkStuRelation_TotalByQuType.TotalScore] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[concc_WorkStuRelation_TotalByQuType.TotalScore].ToString().Trim()); //总得分
objcc_WorkStuRelation_TotalByQuTypeEN.TotalScores = objRow[concc_WorkStuRelation_TotalByQuType.TotalScores] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[concc_WorkStuRelation_TotalByQuType.TotalScores].ToString().Trim()); //总分值
objcc_WorkStuRelation_TotalByQuTypeEN.SchoolYear = objRow[concc_WorkStuRelation_TotalByQuType.SchoolYear] == DBNull.Value ? null : objRow[concc_WorkStuRelation_TotalByQuType.SchoolYear].ToString().Trim(); //学年
objcc_WorkStuRelation_TotalByQuTypeEN.SchoolTerm = objRow[concc_WorkStuRelation_TotalByQuType.SchoolTerm] == DBNull.Value ? null : objRow[concc_WorkStuRelation_TotalByQuType.SchoolTerm].ToString().Trim(); //学期
objcc_WorkStuRelation_TotalByQuTypeEN.UpdDate = objRow[concc_WorkStuRelation_TotalByQuType.UpdDate].ToString().Trim(); //修改日期
objcc_WorkStuRelation_TotalByQuTypeEN.UpdUserId = objRow[concc_WorkStuRelation_TotalByQuType.UpdUserId] == DBNull.Value ? null : objRow[concc_WorkStuRelation_TotalByQuType.UpdUserId].ToString().Trim(); //修改用户Id
objcc_WorkStuRelation_TotalByQuTypeEN.Memo = objRow[concc_WorkStuRelation_TotalByQuType.Memo] == DBNull.Value ? null : objRow[concc_WorkStuRelation_TotalByQuType.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objcc_WorkStuRelation_TotalByQuTypeEN.IdWorkStuRelationTotal, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objcc_WorkStuRelation_TotalByQuTypeEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clscc_WorkStuRelation_TotalByQuTypeEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clscc_WorkStuRelation_TotalByQuTypeEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clscc_WorkStuRelation_TotalByQuTypeEN> arrObjLst = new List<clscc_WorkStuRelation_TotalByQuTypeEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clscc_WorkStuRelation_TotalByQuTypeEN objcc_WorkStuRelation_TotalByQuTypeEN = new clscc_WorkStuRelation_TotalByQuTypeEN();
try
{
objcc_WorkStuRelation_TotalByQuTypeEN.IdWorkStuRelationTotal = Int32.Parse(objRow[concc_WorkStuRelation_TotalByQuType.IdWorkStuRelationTotal].ToString().Trim()); //流水号
objcc_WorkStuRelation_TotalByQuTypeEN.IdCurrEduCls = objRow[concc_WorkStuRelation_TotalByQuType.IdCurrEduCls].ToString().Trim(); //教学班流水号
objcc_WorkStuRelation_TotalByQuTypeEN.IdStudentInfo = objRow[concc_WorkStuRelation_TotalByQuType.IdStudentInfo].ToString().Trim(); //学生流水号
objcc_WorkStuRelation_TotalByQuTypeEN.QuestionTypeId = objRow[concc_WorkStuRelation_TotalByQuType.QuestionTypeId] == DBNull.Value ? null : objRow[concc_WorkStuRelation_TotalByQuType.QuestionTypeId].ToString().Trim(); //题目类型Id
objcc_WorkStuRelation_TotalByQuTypeEN.QuestionTypeId4Course = objRow[concc_WorkStuRelation_TotalByQuType.QuestionTypeId4Course] == DBNull.Value ? null : objRow[concc_WorkStuRelation_TotalByQuType.QuestionTypeId4Course].ToString().Trim(); //题目类型Id4课程
objcc_WorkStuRelation_TotalByQuTypeEN.WorkNum = Int32.Parse(objRow[concc_WorkStuRelation_TotalByQuType.WorkNum].ToString().Trim()); //作业数
objcc_WorkStuRelation_TotalByQuTypeEN.WorkNumSubmit = objRow[concc_WorkStuRelation_TotalByQuType.WorkNumSubmit] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[concc_WorkStuRelation_TotalByQuType.WorkNumSubmit].ToString().Trim()); //提交作业数
objcc_WorkStuRelation_TotalByQuTypeEN.WorkNumSave = objRow[concc_WorkStuRelation_TotalByQuType.WorkNumSave] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[concc_WorkStuRelation_TotalByQuType.WorkNumSave].ToString().Trim()); //保存作业数
objcc_WorkStuRelation_TotalByQuTypeEN.WorkNumNoFinish = objRow[concc_WorkStuRelation_TotalByQuType.WorkNumNoFinish] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[concc_WorkStuRelation_TotalByQuType.WorkNumNoFinish].ToString().Trim()); //未完成作业数
objcc_WorkStuRelation_TotalByQuTypeEN.WorkNumSendBack = objRow[concc_WorkStuRelation_TotalByQuType.WorkNumSendBack] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[concc_WorkStuRelation_TotalByQuType.WorkNumSendBack].ToString().Trim()); //退回作业数
objcc_WorkStuRelation_TotalByQuTypeEN.WorkNumMark = objRow[concc_WorkStuRelation_TotalByQuType.WorkNumMark] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[concc_WorkStuRelation_TotalByQuType.WorkNumMark].ToString().Trim()); //批改作业数
objcc_WorkStuRelation_TotalByQuTypeEN.WorkNumLook = objRow[concc_WorkStuRelation_TotalByQuType.WorkNumLook] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[concc_WorkStuRelation_TotalByQuType.WorkNumLook].ToString().Trim()); //查看作业数
objcc_WorkStuRelation_TotalByQuTypeEN.WorkNumOverdue = objRow[concc_WorkStuRelation_TotalByQuType.WorkNumOverdue] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[concc_WorkStuRelation_TotalByQuType.WorkNumOverdue].ToString().Trim()); //逾期作业数
objcc_WorkStuRelation_TotalByQuTypeEN.TotalScore = objRow[concc_WorkStuRelation_TotalByQuType.TotalScore] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[concc_WorkStuRelation_TotalByQuType.TotalScore].ToString().Trim()); //总得分
objcc_WorkStuRelation_TotalByQuTypeEN.TotalScores = objRow[concc_WorkStuRelation_TotalByQuType.TotalScores] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[concc_WorkStuRelation_TotalByQuType.TotalScores].ToString().Trim()); //总分值
objcc_WorkStuRelation_TotalByQuTypeEN.SchoolYear = objRow[concc_WorkStuRelation_TotalByQuType.SchoolYear] == DBNull.Value ? null : objRow[concc_WorkStuRelation_TotalByQuType.SchoolYear].ToString().Trim(); //学年
objcc_WorkStuRelation_TotalByQuTypeEN.SchoolTerm = objRow[concc_WorkStuRelation_TotalByQuType.SchoolTerm] == DBNull.Value ? null : objRow[concc_WorkStuRelation_TotalByQuType.SchoolTerm].ToString().Trim(); //学期
objcc_WorkStuRelation_TotalByQuTypeEN.UpdDate = objRow[concc_WorkStuRelation_TotalByQuType.UpdDate].ToString().Trim(); //修改日期
objcc_WorkStuRelation_TotalByQuTypeEN.UpdUserId = objRow[concc_WorkStuRelation_TotalByQuType.UpdUserId] == DBNull.Value ? null : objRow[concc_WorkStuRelation_TotalByQuType.UpdUserId].ToString().Trim(); //修改用户Id
objcc_WorkStuRelation_TotalByQuTypeEN.Memo = objRow[concc_WorkStuRelation_TotalByQuType.Memo] == DBNull.Value ? null : objRow[concc_WorkStuRelation_TotalByQuType.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objcc_WorkStuRelation_TotalByQuTypeEN.IdWorkStuRelationTotal, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objcc_WorkStuRelation_TotalByQuTypeEN);
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
public static List<clscc_WorkStuRelation_TotalByQuTypeEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clscc_WorkStuRelation_TotalByQuTypeEN> arrObjLst = new List<clscc_WorkStuRelation_TotalByQuTypeEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clscc_WorkStuRelation_TotalByQuTypeEN objcc_WorkStuRelation_TotalByQuTypeEN = new clscc_WorkStuRelation_TotalByQuTypeEN();
try
{
objcc_WorkStuRelation_TotalByQuTypeEN.IdWorkStuRelationTotal = Int32.Parse(objRow[concc_WorkStuRelation_TotalByQuType.IdWorkStuRelationTotal].ToString().Trim()); //流水号
objcc_WorkStuRelation_TotalByQuTypeEN.IdCurrEduCls = objRow[concc_WorkStuRelation_TotalByQuType.IdCurrEduCls].ToString().Trim(); //教学班流水号
objcc_WorkStuRelation_TotalByQuTypeEN.IdStudentInfo = objRow[concc_WorkStuRelation_TotalByQuType.IdStudentInfo].ToString().Trim(); //学生流水号
objcc_WorkStuRelation_TotalByQuTypeEN.QuestionTypeId = objRow[concc_WorkStuRelation_TotalByQuType.QuestionTypeId] == DBNull.Value ? null : objRow[concc_WorkStuRelation_TotalByQuType.QuestionTypeId].ToString().Trim(); //题目类型Id
objcc_WorkStuRelation_TotalByQuTypeEN.QuestionTypeId4Course = objRow[concc_WorkStuRelation_TotalByQuType.QuestionTypeId4Course] == DBNull.Value ? null : objRow[concc_WorkStuRelation_TotalByQuType.QuestionTypeId4Course].ToString().Trim(); //题目类型Id4课程
objcc_WorkStuRelation_TotalByQuTypeEN.WorkNum = Int32.Parse(objRow[concc_WorkStuRelation_TotalByQuType.WorkNum].ToString().Trim()); //作业数
objcc_WorkStuRelation_TotalByQuTypeEN.WorkNumSubmit = objRow[concc_WorkStuRelation_TotalByQuType.WorkNumSubmit] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[concc_WorkStuRelation_TotalByQuType.WorkNumSubmit].ToString().Trim()); //提交作业数
objcc_WorkStuRelation_TotalByQuTypeEN.WorkNumSave = objRow[concc_WorkStuRelation_TotalByQuType.WorkNumSave] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[concc_WorkStuRelation_TotalByQuType.WorkNumSave].ToString().Trim()); //保存作业数
objcc_WorkStuRelation_TotalByQuTypeEN.WorkNumNoFinish = objRow[concc_WorkStuRelation_TotalByQuType.WorkNumNoFinish] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[concc_WorkStuRelation_TotalByQuType.WorkNumNoFinish].ToString().Trim()); //未完成作业数
objcc_WorkStuRelation_TotalByQuTypeEN.WorkNumSendBack = objRow[concc_WorkStuRelation_TotalByQuType.WorkNumSendBack] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[concc_WorkStuRelation_TotalByQuType.WorkNumSendBack].ToString().Trim()); //退回作业数
objcc_WorkStuRelation_TotalByQuTypeEN.WorkNumMark = objRow[concc_WorkStuRelation_TotalByQuType.WorkNumMark] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[concc_WorkStuRelation_TotalByQuType.WorkNumMark].ToString().Trim()); //批改作业数
objcc_WorkStuRelation_TotalByQuTypeEN.WorkNumLook = objRow[concc_WorkStuRelation_TotalByQuType.WorkNumLook] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[concc_WorkStuRelation_TotalByQuType.WorkNumLook].ToString().Trim()); //查看作业数
objcc_WorkStuRelation_TotalByQuTypeEN.WorkNumOverdue = objRow[concc_WorkStuRelation_TotalByQuType.WorkNumOverdue] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[concc_WorkStuRelation_TotalByQuType.WorkNumOverdue].ToString().Trim()); //逾期作业数
objcc_WorkStuRelation_TotalByQuTypeEN.TotalScore = objRow[concc_WorkStuRelation_TotalByQuType.TotalScore] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[concc_WorkStuRelation_TotalByQuType.TotalScore].ToString().Trim()); //总得分
objcc_WorkStuRelation_TotalByQuTypeEN.TotalScores = objRow[concc_WorkStuRelation_TotalByQuType.TotalScores] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[concc_WorkStuRelation_TotalByQuType.TotalScores].ToString().Trim()); //总分值
objcc_WorkStuRelation_TotalByQuTypeEN.SchoolYear = objRow[concc_WorkStuRelation_TotalByQuType.SchoolYear] == DBNull.Value ? null : objRow[concc_WorkStuRelation_TotalByQuType.SchoolYear].ToString().Trim(); //学年
objcc_WorkStuRelation_TotalByQuTypeEN.SchoolTerm = objRow[concc_WorkStuRelation_TotalByQuType.SchoolTerm] == DBNull.Value ? null : objRow[concc_WorkStuRelation_TotalByQuType.SchoolTerm].ToString().Trim(); //学期
objcc_WorkStuRelation_TotalByQuTypeEN.UpdDate = objRow[concc_WorkStuRelation_TotalByQuType.UpdDate].ToString().Trim(); //修改日期
objcc_WorkStuRelation_TotalByQuTypeEN.UpdUserId = objRow[concc_WorkStuRelation_TotalByQuType.UpdUserId] == DBNull.Value ? null : objRow[concc_WorkStuRelation_TotalByQuType.UpdUserId].ToString().Trim(); //修改用户Id
objcc_WorkStuRelation_TotalByQuTypeEN.Memo = objRow[concc_WorkStuRelation_TotalByQuType.Memo] == DBNull.Value ? null : objRow[concc_WorkStuRelation_TotalByQuType.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objcc_WorkStuRelation_TotalByQuTypeEN.IdWorkStuRelationTotal, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objcc_WorkStuRelation_TotalByQuTypeEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clscc_WorkStuRelation_TotalByQuTypeEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clscc_WorkStuRelation_TotalByQuTypeEN> arrObjLst = new List<clscc_WorkStuRelation_TotalByQuTypeEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clscc_WorkStuRelation_TotalByQuTypeEN objcc_WorkStuRelation_TotalByQuTypeEN = new clscc_WorkStuRelation_TotalByQuTypeEN();
try
{
objcc_WorkStuRelation_TotalByQuTypeEN.IdWorkStuRelationTotal = Int32.Parse(objRow[concc_WorkStuRelation_TotalByQuType.IdWorkStuRelationTotal].ToString().Trim()); //流水号
objcc_WorkStuRelation_TotalByQuTypeEN.IdCurrEduCls = objRow[concc_WorkStuRelation_TotalByQuType.IdCurrEduCls].ToString().Trim(); //教学班流水号
objcc_WorkStuRelation_TotalByQuTypeEN.IdStudentInfo = objRow[concc_WorkStuRelation_TotalByQuType.IdStudentInfo].ToString().Trim(); //学生流水号
objcc_WorkStuRelation_TotalByQuTypeEN.QuestionTypeId = objRow[concc_WorkStuRelation_TotalByQuType.QuestionTypeId] == DBNull.Value ? null : objRow[concc_WorkStuRelation_TotalByQuType.QuestionTypeId].ToString().Trim(); //题目类型Id
objcc_WorkStuRelation_TotalByQuTypeEN.QuestionTypeId4Course = objRow[concc_WorkStuRelation_TotalByQuType.QuestionTypeId4Course] == DBNull.Value ? null : objRow[concc_WorkStuRelation_TotalByQuType.QuestionTypeId4Course].ToString().Trim(); //题目类型Id4课程
objcc_WorkStuRelation_TotalByQuTypeEN.WorkNum = Int32.Parse(objRow[concc_WorkStuRelation_TotalByQuType.WorkNum].ToString().Trim()); //作业数
objcc_WorkStuRelation_TotalByQuTypeEN.WorkNumSubmit = objRow[concc_WorkStuRelation_TotalByQuType.WorkNumSubmit] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[concc_WorkStuRelation_TotalByQuType.WorkNumSubmit].ToString().Trim()); //提交作业数
objcc_WorkStuRelation_TotalByQuTypeEN.WorkNumSave = objRow[concc_WorkStuRelation_TotalByQuType.WorkNumSave] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[concc_WorkStuRelation_TotalByQuType.WorkNumSave].ToString().Trim()); //保存作业数
objcc_WorkStuRelation_TotalByQuTypeEN.WorkNumNoFinish = objRow[concc_WorkStuRelation_TotalByQuType.WorkNumNoFinish] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[concc_WorkStuRelation_TotalByQuType.WorkNumNoFinish].ToString().Trim()); //未完成作业数
objcc_WorkStuRelation_TotalByQuTypeEN.WorkNumSendBack = objRow[concc_WorkStuRelation_TotalByQuType.WorkNumSendBack] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[concc_WorkStuRelation_TotalByQuType.WorkNumSendBack].ToString().Trim()); //退回作业数
objcc_WorkStuRelation_TotalByQuTypeEN.WorkNumMark = objRow[concc_WorkStuRelation_TotalByQuType.WorkNumMark] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[concc_WorkStuRelation_TotalByQuType.WorkNumMark].ToString().Trim()); //批改作业数
objcc_WorkStuRelation_TotalByQuTypeEN.WorkNumLook = objRow[concc_WorkStuRelation_TotalByQuType.WorkNumLook] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[concc_WorkStuRelation_TotalByQuType.WorkNumLook].ToString().Trim()); //查看作业数
objcc_WorkStuRelation_TotalByQuTypeEN.WorkNumOverdue = objRow[concc_WorkStuRelation_TotalByQuType.WorkNumOverdue] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[concc_WorkStuRelation_TotalByQuType.WorkNumOverdue].ToString().Trim()); //逾期作业数
objcc_WorkStuRelation_TotalByQuTypeEN.TotalScore = objRow[concc_WorkStuRelation_TotalByQuType.TotalScore] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[concc_WorkStuRelation_TotalByQuType.TotalScore].ToString().Trim()); //总得分
objcc_WorkStuRelation_TotalByQuTypeEN.TotalScores = objRow[concc_WorkStuRelation_TotalByQuType.TotalScores] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[concc_WorkStuRelation_TotalByQuType.TotalScores].ToString().Trim()); //总分值
objcc_WorkStuRelation_TotalByQuTypeEN.SchoolYear = objRow[concc_WorkStuRelation_TotalByQuType.SchoolYear] == DBNull.Value ? null : objRow[concc_WorkStuRelation_TotalByQuType.SchoolYear].ToString().Trim(); //学年
objcc_WorkStuRelation_TotalByQuTypeEN.SchoolTerm = objRow[concc_WorkStuRelation_TotalByQuType.SchoolTerm] == DBNull.Value ? null : objRow[concc_WorkStuRelation_TotalByQuType.SchoolTerm].ToString().Trim(); //学期
objcc_WorkStuRelation_TotalByQuTypeEN.UpdDate = objRow[concc_WorkStuRelation_TotalByQuType.UpdDate].ToString().Trim(); //修改日期
objcc_WorkStuRelation_TotalByQuTypeEN.UpdUserId = objRow[concc_WorkStuRelation_TotalByQuType.UpdUserId] == DBNull.Value ? null : objRow[concc_WorkStuRelation_TotalByQuType.UpdUserId].ToString().Trim(); //修改用户Id
objcc_WorkStuRelation_TotalByQuTypeEN.Memo = objRow[concc_WorkStuRelation_TotalByQuType.Memo] == DBNull.Value ? null : objRow[concc_WorkStuRelation_TotalByQuType.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objcc_WorkStuRelation_TotalByQuTypeEN.IdWorkStuRelationTotal, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objcc_WorkStuRelation_TotalByQuTypeEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objcc_WorkStuRelation_TotalByQuTypeEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool Getcc_WorkStuRelation_TotalByQuType(ref clscc_WorkStuRelation_TotalByQuTypeEN objcc_WorkStuRelation_TotalByQuTypeEN)
{
bool bolResult = cc_WorkStuRelation_TotalByQuTypeDA.Getcc_WorkStuRelation_TotalByQuType(ref objcc_WorkStuRelation_TotalByQuTypeEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "lngIdWorkStuRelationTotal">表关键字</param>
 /// <returns>表对象</returns>
public static clscc_WorkStuRelation_TotalByQuTypeEN GetObjByIdWorkStuRelationTotal(long lngIdWorkStuRelationTotal)
{
clscc_WorkStuRelation_TotalByQuTypeEN objcc_WorkStuRelation_TotalByQuTypeEN = cc_WorkStuRelation_TotalByQuTypeDA.GetObjByIdWorkStuRelationTotal(lngIdWorkStuRelationTotal);
return objcc_WorkStuRelation_TotalByQuTypeEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clscc_WorkStuRelation_TotalByQuTypeEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clscc_WorkStuRelation_TotalByQuTypeEN objcc_WorkStuRelation_TotalByQuTypeEN = cc_WorkStuRelation_TotalByQuTypeDA.GetFirstObj(strWhereCond);
 return objcc_WorkStuRelation_TotalByQuTypeEN;
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
public static clscc_WorkStuRelation_TotalByQuTypeEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clscc_WorkStuRelation_TotalByQuTypeEN objcc_WorkStuRelation_TotalByQuTypeEN = cc_WorkStuRelation_TotalByQuTypeDA.GetObjByDataRow(objRow);
 return objcc_WorkStuRelation_TotalByQuTypeEN;
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
public static clscc_WorkStuRelation_TotalByQuTypeEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clscc_WorkStuRelation_TotalByQuTypeEN objcc_WorkStuRelation_TotalByQuTypeEN = cc_WorkStuRelation_TotalByQuTypeDA.GetObjByDataRow(objRow);
 return objcc_WorkStuRelation_TotalByQuTypeEN;
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
 /// <param name = "lngIdWorkStuRelationTotal">所给的关键字</param>
 /// <param name = "lstcc_WorkStuRelation_TotalByQuTypeObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clscc_WorkStuRelation_TotalByQuTypeEN GetObjByIdWorkStuRelationTotalFromList(long lngIdWorkStuRelationTotal, List<clscc_WorkStuRelation_TotalByQuTypeEN> lstcc_WorkStuRelation_TotalByQuTypeObjLst)
{
foreach (clscc_WorkStuRelation_TotalByQuTypeEN objcc_WorkStuRelation_TotalByQuTypeEN in lstcc_WorkStuRelation_TotalByQuTypeObjLst)
{
if (objcc_WorkStuRelation_TotalByQuTypeEN.IdWorkStuRelationTotal == lngIdWorkStuRelationTotal)
{
return objcc_WorkStuRelation_TotalByQuTypeEN;
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
 long lngIdWorkStuRelationTotal;
 try
 {
 lngIdWorkStuRelationTotal = new clscc_WorkStuRelation_TotalByQuTypeDA().GetFirstID(strWhereCond);
 return lngIdWorkStuRelationTotal;
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
 arrList = cc_WorkStuRelation_TotalByQuTypeDA.GetID(strWhereCond);
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
bool bolIsExist = cc_WorkStuRelation_TotalByQuTypeDA.IsExistCondRec(strWhereCond);
return bolIsExist;
}

 /// <summary>
 /// 判断当前表中是否存在给定关键字值的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExist)
 /// </summary>
 /// <param name = "lngIdWorkStuRelationTotal">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public static bool IsExist(long lngIdWorkStuRelationTotal)
{
//检测记录是否存在
bool bolIsExist = cc_WorkStuRelation_TotalByQuTypeDA.IsExist(lngIdWorkStuRelationTotal);
return bolIsExist;
}

/// <summary>
/// 设置修改时间
/// </summary>
/// <param name = "lngIdWorkStuRelationTotal">流水号</param>
/// <param name = "strOpUser">修改用户</param>
/// <returns>是否成功？</returns>
public static bool SetUpdDate(long lngIdWorkStuRelationTotal, string strOpUser)
{
clscc_WorkStuRelation_TotalByQuTypeEN objcc_WorkStuRelation_TotalByQuTypeEN = clscc_WorkStuRelation_TotalByQuTypeBL.GetObjByIdWorkStuRelationTotal(lngIdWorkStuRelationTotal);
objcc_WorkStuRelation_TotalByQuTypeEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
objcc_WorkStuRelation_TotalByQuTypeEN.UpdUserId = strOpUser;
return clscc_WorkStuRelation_TotalByQuTypeBL.UpdateBySql2(objcc_WorkStuRelation_TotalByQuTypeEN);
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
 bolIsExist = clscc_WorkStuRelation_TotalByQuTypeDA.IsExistTable();
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
 bolIsExist = cc_WorkStuRelation_TotalByQuTypeDA.IsExistTable(strTabName);
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
 /// <param name = "objcc_WorkStuRelation_TotalByQuTypeEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecordBySql2(clscc_WorkStuRelation_TotalByQuTypeEN objcc_WorkStuRelation_TotalByQuTypeEN, bool bolIsNeedCheckUniqueness=true)
{
if (bolIsNeedCheckUniqueness == true && objcc_WorkStuRelation_TotalByQuTypeEN.CheckUniqueness() == false)
{
var strMsg = string.Format("记录已经存在!教学班流水号 = [{0}],学生流水号 = [{1}]的数据已经存在!(in clscc_WorkStuRelation_TotalByQuTypeBL.AddNewRecordBySql2)", objcc_WorkStuRelation_TotalByQuTypeEN.IdCurrEduCls,objcc_WorkStuRelation_TotalByQuTypeEN.IdStudentInfo);
throw new Exception(strMsg);
}
try
{
bool bolResult = cc_WorkStuRelation_TotalByQuTypeDA.AddNewRecordBySQL2(objcc_WorkStuRelation_TotalByQuTypeEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clscc_WorkStuRelation_TotalByQuTypeBL.ReFreshCache();

if (clscc_WorkStuRelation_TotalByQuTypeBL.relatedActions != null)
{
clscc_WorkStuRelation_TotalByQuTypeBL.relatedActions.UpdRelaTabDate(objcc_WorkStuRelation_TotalByQuTypeEN.IdWorkStuRelationTotal, objcc_WorkStuRelation_TotalByQuTypeEN.UpdUserId);
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
 /// <param name = "objcc_WorkStuRelation_TotalByQuTypeEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordBySql2WithReturnKey(clscc_WorkStuRelation_TotalByQuTypeEN objcc_WorkStuRelation_TotalByQuTypeEN, bool bolIsNeedCheckUniqueness=true)
{
if (bolIsNeedCheckUniqueness == true && objcc_WorkStuRelation_TotalByQuTypeEN.CheckUniqueness() == false)
{
var strMsg = string.Format("记录已经存在!教学班流水号 = [{0}],学生流水号 = [{1}]的数据已经存在!(in clscc_WorkStuRelation_TotalByQuTypeBL.AddNewRecordBySql2WithReturnKey)", objcc_WorkStuRelation_TotalByQuTypeEN.IdCurrEduCls,objcc_WorkStuRelation_TotalByQuTypeEN.IdStudentInfo);
throw new Exception(strMsg);
}
try
{
string strKey = cc_WorkStuRelation_TotalByQuTypeDA.AddNewRecordBySQL2WithReturnKey(objcc_WorkStuRelation_TotalByQuTypeEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clscc_WorkStuRelation_TotalByQuTypeBL.ReFreshCache();

if (clscc_WorkStuRelation_TotalByQuTypeBL.relatedActions != null)
{
clscc_WorkStuRelation_TotalByQuTypeBL.relatedActions.UpdRelaTabDate(objcc_WorkStuRelation_TotalByQuTypeEN.IdWorkStuRelationTotal, objcc_WorkStuRelation_TotalByQuTypeEN.UpdUserId);
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
 /// <param name = "objcc_WorkStuRelation_TotalByQuTypeEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(clscc_WorkStuRelation_TotalByQuTypeEN objcc_WorkStuRelation_TotalByQuTypeEN)
{
try
{
bool bolResult = cc_WorkStuRelation_TotalByQuTypeDA.Update(objcc_WorkStuRelation_TotalByQuTypeEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clscc_WorkStuRelation_TotalByQuTypeBL.ReFreshCache();

if (clscc_WorkStuRelation_TotalByQuTypeBL.relatedActions != null)
{
clscc_WorkStuRelation_TotalByQuTypeBL.relatedActions.UpdRelaTabDate(objcc_WorkStuRelation_TotalByQuTypeEN.IdWorkStuRelationTotal, objcc_WorkStuRelation_TotalByQuTypeEN.UpdUserId);
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
 /// <param name = "objcc_WorkStuRelation_TotalByQuTypeEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateBySql2(clscc_WorkStuRelation_TotalByQuTypeEN objcc_WorkStuRelation_TotalByQuTypeEN)
{
 if (objcc_WorkStuRelation_TotalByQuTypeEN.IdWorkStuRelationTotal == 0)
 {
var strMsg = string.Format("(errid:Busi000065)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = cc_WorkStuRelation_TotalByQuTypeDA.UpdateBySql2(objcc_WorkStuRelation_TotalByQuTypeEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clscc_WorkStuRelation_TotalByQuTypeBL.ReFreshCache();

if (clscc_WorkStuRelation_TotalByQuTypeBL.relatedActions != null)
{
clscc_WorkStuRelation_TotalByQuTypeBL.relatedActions.UpdRelaTabDate(objcc_WorkStuRelation_TotalByQuTypeEN.IdWorkStuRelationTotal, objcc_WorkStuRelation_TotalByQuTypeEN.UpdUserId);
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
 /// <param name = "lngIdWorkStuRelationTotal">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int DelRecord(long lngIdWorkStuRelationTotal)
{
try
{
 clscc_WorkStuRelation_TotalByQuTypeEN objcc_WorkStuRelation_TotalByQuTypeEN = clscc_WorkStuRelation_TotalByQuTypeBL.GetObjByIdWorkStuRelationTotal(lngIdWorkStuRelationTotal);

if (clscc_WorkStuRelation_TotalByQuTypeBL.relatedActions != null)
{
clscc_WorkStuRelation_TotalByQuTypeBL.relatedActions.UpdRelaTabDate(objcc_WorkStuRelation_TotalByQuTypeEN.IdWorkStuRelationTotal, objcc_WorkStuRelation_TotalByQuTypeEN.UpdUserId);
}
if (objcc_WorkStuRelation_TotalByQuTypeEN != null)
{
int intRecNum = cc_WorkStuRelation_TotalByQuTypeDA.DelRecord(lngIdWorkStuRelationTotal);
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
/// <param name="lngIdWorkStuRelationTotal">表关键字</param>
/// <returns></returns>
public static bool DelRecordEx(long lngIdWorkStuRelationTotal )
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clscc_WorkStuRelation_TotalByQuTypeDA.GetSpecSQLObj();
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
//删除与表:[cc_WorkStuRelation_TotalByQuType]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//concc_WorkStuRelation_TotalByQuType.IdWorkStuRelationTotal,
//lngIdWorkStuRelationTotal);
//        clscc_WorkStuRelation_TotalByQuTypeBL.Delcc_WorkStuRelation_TotalByQuTypesByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clscc_WorkStuRelation_TotalByQuTypeBL.DelRecord(lngIdWorkStuRelationTotal, objConnection, objSqlTransaction);
objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clscc_WorkStuRelation_TotalByQuTypeBLEx", "DelRecordEx", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("扩展删除记录出错:{0}!keyId = {1}.({2})",
objException.Message,
lngIdWorkStuRelationTotal, clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "lngIdWorkStuRelationTotal">给定的关键字值</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回删除是否成功?</returns>
public static bool DelRecord(long lngIdWorkStuRelationTotal, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
if (clscc_WorkStuRelation_TotalByQuTypeBL.relatedActions != null)
{
clscc_WorkStuRelation_TotalByQuTypeBL.relatedActions.UpdRelaTabDate(lngIdWorkStuRelationTotal, "UpdRelaTabDate");
}
bool bolResult = cc_WorkStuRelation_TotalByQuTypeDA.DelRecord(lngIdWorkStuRelationTotal,objSqlConnection,objSqlTransaction);
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
 /// <param name = "arrIdWorkStuRelationTotalLst">给定的关键字值列表</param>
 /// <returns>返回删除的记录数</returns>
public static int Delcc_WorkStuRelation_TotalByQuTypes(List<string> arrIdWorkStuRelationTotalLst)
{
if (arrIdWorkStuRelationTotalLst.Count == 0) return 0;
try
{
if (clscc_WorkStuRelation_TotalByQuTypeBL.relatedActions != null)
{
foreach (var strIdWorkStuRelationTotal in arrIdWorkStuRelationTotalLst)
{
long lngIdWorkStuRelationTotal = long.Parse(strIdWorkStuRelationTotal);
clscc_WorkStuRelation_TotalByQuTypeBL.relatedActions.UpdRelaTabDate(lngIdWorkStuRelationTotal, "UpdRelaTabDate");
}
}
int intDelRecNum = cc_WorkStuRelation_TotalByQuTypeDA.Delcc_WorkStuRelation_TotalByQuType(arrIdWorkStuRelationTotalLst);
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
public static int Delcc_WorkStuRelation_TotalByQuTypesByCond(string strWhereCond)
{
try
{
if (clscc_WorkStuRelation_TotalByQuTypeBL.relatedActions != null)
{
List<string> arrIdWorkStuRelationTotal = GetPrimaryKeyID_S(strWhereCond);
foreach (var strIdWorkStuRelationTotal in arrIdWorkStuRelationTotal)
{
long lngIdWorkStuRelationTotal = long.Parse(strIdWorkStuRelationTotal);
clscc_WorkStuRelation_TotalByQuTypeBL.relatedActions.UpdRelaTabDate(lngIdWorkStuRelationTotal, "UpdRelaTabDate");
}
}
int intRecNum = cc_WorkStuRelation_TotalByQuTypeDA.Delcc_WorkStuRelation_TotalByQuType(strWhereCond);
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
/// 这里仅仅是演示函数,使用时请复制到扩展类:[cc_WorkStuRelation_TotalByQuType]中改名为:[DelRecord4MultiTabEx]使用
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DelRecord4MultiTab)
/// </summary>
/// <param name="lngIdWorkStuRelationTotal">表关键字</param>
/// <returns></returns>
public static bool DelRecord4MultiTab(long lngIdWorkStuRelationTotal)
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clscc_WorkStuRelation_TotalByQuTypeDA.GetSpecSQLObj();
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
//删除与表:[cc_WorkStuRelation_TotalByQuType]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conStudent.id_College,
//strid_College);
//        clsStudentBL.DelStudentsByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clscc_WorkStuRelation_TotalByQuTypeBL.DelRecord(lngIdWorkStuRelationTotal, objConnection, objSqlTransaction);
                objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clscc_WorkStuRelation_TotalByQuTypeBL", "DelRecord4MultiTab", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("删除多表记录出错:{0}!keyId = {1}.({2})",
objException.Message,
lngIdWorkStuRelationTotal, clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "objcc_WorkStuRelation_TotalByQuTypeENS">源对象</param>
 /// <param name = "objcc_WorkStuRelation_TotalByQuTypeENT">目标对象</param>
 public static void CopyTo(clscc_WorkStuRelation_TotalByQuTypeEN objcc_WorkStuRelation_TotalByQuTypeENS, clscc_WorkStuRelation_TotalByQuTypeEN objcc_WorkStuRelation_TotalByQuTypeENT)
{
try
{
objcc_WorkStuRelation_TotalByQuTypeENT.IdWorkStuRelationTotal = objcc_WorkStuRelation_TotalByQuTypeENS.IdWorkStuRelationTotal; //流水号
objcc_WorkStuRelation_TotalByQuTypeENT.IdCurrEduCls = objcc_WorkStuRelation_TotalByQuTypeENS.IdCurrEduCls; //教学班流水号
objcc_WorkStuRelation_TotalByQuTypeENT.IdStudentInfo = objcc_WorkStuRelation_TotalByQuTypeENS.IdStudentInfo; //学生流水号
objcc_WorkStuRelation_TotalByQuTypeENT.QuestionTypeId = objcc_WorkStuRelation_TotalByQuTypeENS.QuestionTypeId; //题目类型Id
objcc_WorkStuRelation_TotalByQuTypeENT.QuestionTypeId4Course = objcc_WorkStuRelation_TotalByQuTypeENS.QuestionTypeId4Course; //题目类型Id4课程
objcc_WorkStuRelation_TotalByQuTypeENT.WorkNum = objcc_WorkStuRelation_TotalByQuTypeENS.WorkNum; //作业数
objcc_WorkStuRelation_TotalByQuTypeENT.WorkNumSubmit = objcc_WorkStuRelation_TotalByQuTypeENS.WorkNumSubmit; //提交作业数
objcc_WorkStuRelation_TotalByQuTypeENT.WorkNumSave = objcc_WorkStuRelation_TotalByQuTypeENS.WorkNumSave; //保存作业数
objcc_WorkStuRelation_TotalByQuTypeENT.WorkNumNoFinish = objcc_WorkStuRelation_TotalByQuTypeENS.WorkNumNoFinish; //未完成作业数
objcc_WorkStuRelation_TotalByQuTypeENT.WorkNumSendBack = objcc_WorkStuRelation_TotalByQuTypeENS.WorkNumSendBack; //退回作业数
objcc_WorkStuRelation_TotalByQuTypeENT.WorkNumMark = objcc_WorkStuRelation_TotalByQuTypeENS.WorkNumMark; //批改作业数
objcc_WorkStuRelation_TotalByQuTypeENT.WorkNumLook = objcc_WorkStuRelation_TotalByQuTypeENS.WorkNumLook; //查看作业数
objcc_WorkStuRelation_TotalByQuTypeENT.WorkNumOverdue = objcc_WorkStuRelation_TotalByQuTypeENS.WorkNumOverdue; //逾期作业数
objcc_WorkStuRelation_TotalByQuTypeENT.TotalScore = objcc_WorkStuRelation_TotalByQuTypeENS.TotalScore; //总得分
objcc_WorkStuRelation_TotalByQuTypeENT.TotalScores = objcc_WorkStuRelation_TotalByQuTypeENS.TotalScores; //总分值
objcc_WorkStuRelation_TotalByQuTypeENT.SchoolYear = objcc_WorkStuRelation_TotalByQuTypeENS.SchoolYear; //学年
objcc_WorkStuRelation_TotalByQuTypeENT.SchoolTerm = objcc_WorkStuRelation_TotalByQuTypeENS.SchoolTerm; //学期
objcc_WorkStuRelation_TotalByQuTypeENT.UpdDate = objcc_WorkStuRelation_TotalByQuTypeENS.UpdDate; //修改日期
objcc_WorkStuRelation_TotalByQuTypeENT.UpdUserId = objcc_WorkStuRelation_TotalByQuTypeENS.UpdUserId; //修改用户Id
objcc_WorkStuRelation_TotalByQuTypeENT.Memo = objcc_WorkStuRelation_TotalByQuTypeENS.Memo; //备注
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
 /// <param name = "objcc_WorkStuRelation_TotalByQuTypeEN">源简化对象</param>
 public static void SetUpdFlag(clscc_WorkStuRelation_TotalByQuTypeEN objcc_WorkStuRelation_TotalByQuTypeEN)
{
try
{
objcc_WorkStuRelation_TotalByQuTypeEN.ClearUpdateState();
   string strsfUpdFldSetStr = objcc_WorkStuRelation_TotalByQuTypeEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(concc_WorkStuRelation_TotalByQuType.IdWorkStuRelationTotal, new clsStrCompareIgnoreCase())  ==  true)
{
objcc_WorkStuRelation_TotalByQuTypeEN.IdWorkStuRelationTotal = objcc_WorkStuRelation_TotalByQuTypeEN.IdWorkStuRelationTotal; //流水号
}
if (arrFldSet.Contains(concc_WorkStuRelation_TotalByQuType.IdCurrEduCls, new clsStrCompareIgnoreCase())  ==  true)
{
objcc_WorkStuRelation_TotalByQuTypeEN.IdCurrEduCls = objcc_WorkStuRelation_TotalByQuTypeEN.IdCurrEduCls; //教学班流水号
}
if (arrFldSet.Contains(concc_WorkStuRelation_TotalByQuType.IdStudentInfo, new clsStrCompareIgnoreCase())  ==  true)
{
objcc_WorkStuRelation_TotalByQuTypeEN.IdStudentInfo = objcc_WorkStuRelation_TotalByQuTypeEN.IdStudentInfo; //学生流水号
}
if (arrFldSet.Contains(concc_WorkStuRelation_TotalByQuType.QuestionTypeId, new clsStrCompareIgnoreCase())  ==  true)
{
objcc_WorkStuRelation_TotalByQuTypeEN.QuestionTypeId = objcc_WorkStuRelation_TotalByQuTypeEN.QuestionTypeId == "[null]" ? null :  objcc_WorkStuRelation_TotalByQuTypeEN.QuestionTypeId; //题目类型Id
}
if (arrFldSet.Contains(concc_WorkStuRelation_TotalByQuType.QuestionTypeId4Course, new clsStrCompareIgnoreCase())  ==  true)
{
objcc_WorkStuRelation_TotalByQuTypeEN.QuestionTypeId4Course = objcc_WorkStuRelation_TotalByQuTypeEN.QuestionTypeId4Course == "[null]" ? null :  objcc_WorkStuRelation_TotalByQuTypeEN.QuestionTypeId4Course; //题目类型Id4课程
}
if (arrFldSet.Contains(concc_WorkStuRelation_TotalByQuType.WorkNum, new clsStrCompareIgnoreCase())  ==  true)
{
objcc_WorkStuRelation_TotalByQuTypeEN.WorkNum = objcc_WorkStuRelation_TotalByQuTypeEN.WorkNum; //作业数
}
if (arrFldSet.Contains(concc_WorkStuRelation_TotalByQuType.WorkNumSubmit, new clsStrCompareIgnoreCase())  ==  true)
{
objcc_WorkStuRelation_TotalByQuTypeEN.WorkNumSubmit = objcc_WorkStuRelation_TotalByQuTypeEN.WorkNumSubmit; //提交作业数
}
if (arrFldSet.Contains(concc_WorkStuRelation_TotalByQuType.WorkNumSave, new clsStrCompareIgnoreCase())  ==  true)
{
objcc_WorkStuRelation_TotalByQuTypeEN.WorkNumSave = objcc_WorkStuRelation_TotalByQuTypeEN.WorkNumSave; //保存作业数
}
if (arrFldSet.Contains(concc_WorkStuRelation_TotalByQuType.WorkNumNoFinish, new clsStrCompareIgnoreCase())  ==  true)
{
objcc_WorkStuRelation_TotalByQuTypeEN.WorkNumNoFinish = objcc_WorkStuRelation_TotalByQuTypeEN.WorkNumNoFinish; //未完成作业数
}
if (arrFldSet.Contains(concc_WorkStuRelation_TotalByQuType.WorkNumSendBack, new clsStrCompareIgnoreCase())  ==  true)
{
objcc_WorkStuRelation_TotalByQuTypeEN.WorkNumSendBack = objcc_WorkStuRelation_TotalByQuTypeEN.WorkNumSendBack; //退回作业数
}
if (arrFldSet.Contains(concc_WorkStuRelation_TotalByQuType.WorkNumMark, new clsStrCompareIgnoreCase())  ==  true)
{
objcc_WorkStuRelation_TotalByQuTypeEN.WorkNumMark = objcc_WorkStuRelation_TotalByQuTypeEN.WorkNumMark; //批改作业数
}
if (arrFldSet.Contains(concc_WorkStuRelation_TotalByQuType.WorkNumLook, new clsStrCompareIgnoreCase())  ==  true)
{
objcc_WorkStuRelation_TotalByQuTypeEN.WorkNumLook = objcc_WorkStuRelation_TotalByQuTypeEN.WorkNumLook; //查看作业数
}
if (arrFldSet.Contains(concc_WorkStuRelation_TotalByQuType.WorkNumOverdue, new clsStrCompareIgnoreCase())  ==  true)
{
objcc_WorkStuRelation_TotalByQuTypeEN.WorkNumOverdue = objcc_WorkStuRelation_TotalByQuTypeEN.WorkNumOverdue; //逾期作业数
}
if (arrFldSet.Contains(concc_WorkStuRelation_TotalByQuType.TotalScore, new clsStrCompareIgnoreCase())  ==  true)
{
objcc_WorkStuRelation_TotalByQuTypeEN.TotalScore = objcc_WorkStuRelation_TotalByQuTypeEN.TotalScore; //总得分
}
if (arrFldSet.Contains(concc_WorkStuRelation_TotalByQuType.TotalScores, new clsStrCompareIgnoreCase())  ==  true)
{
objcc_WorkStuRelation_TotalByQuTypeEN.TotalScores = objcc_WorkStuRelation_TotalByQuTypeEN.TotalScores; //总分值
}
if (arrFldSet.Contains(concc_WorkStuRelation_TotalByQuType.SchoolYear, new clsStrCompareIgnoreCase())  ==  true)
{
objcc_WorkStuRelation_TotalByQuTypeEN.SchoolYear = objcc_WorkStuRelation_TotalByQuTypeEN.SchoolYear == "[null]" ? null :  objcc_WorkStuRelation_TotalByQuTypeEN.SchoolYear; //学年
}
if (arrFldSet.Contains(concc_WorkStuRelation_TotalByQuType.SchoolTerm, new clsStrCompareIgnoreCase())  ==  true)
{
objcc_WorkStuRelation_TotalByQuTypeEN.SchoolTerm = objcc_WorkStuRelation_TotalByQuTypeEN.SchoolTerm == "[null]" ? null :  objcc_WorkStuRelation_TotalByQuTypeEN.SchoolTerm; //学期
}
if (arrFldSet.Contains(concc_WorkStuRelation_TotalByQuType.UpdDate, new clsStrCompareIgnoreCase())  ==  true)
{
objcc_WorkStuRelation_TotalByQuTypeEN.UpdDate = objcc_WorkStuRelation_TotalByQuTypeEN.UpdDate; //修改日期
}
if (arrFldSet.Contains(concc_WorkStuRelation_TotalByQuType.UpdUserId, new clsStrCompareIgnoreCase())  ==  true)
{
objcc_WorkStuRelation_TotalByQuTypeEN.UpdUserId = objcc_WorkStuRelation_TotalByQuTypeEN.UpdUserId == "[null]" ? null :  objcc_WorkStuRelation_TotalByQuTypeEN.UpdUserId; //修改用户Id
}
if (arrFldSet.Contains(concc_WorkStuRelation_TotalByQuType.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objcc_WorkStuRelation_TotalByQuTypeEN.Memo = objcc_WorkStuRelation_TotalByQuTypeEN.Memo == "[null]" ? null :  objcc_WorkStuRelation_TotalByQuTypeEN.Memo; //备注
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
 /// <param name = "objcc_WorkStuRelation_TotalByQuTypeEN">源简化对象</param>
 public static void AccessFldValueNull(clscc_WorkStuRelation_TotalByQuTypeEN objcc_WorkStuRelation_TotalByQuTypeEN)
{
try
{
if (objcc_WorkStuRelation_TotalByQuTypeEN.QuestionTypeId == "[null]") objcc_WorkStuRelation_TotalByQuTypeEN.QuestionTypeId = null; //题目类型Id
if (objcc_WorkStuRelation_TotalByQuTypeEN.QuestionTypeId4Course == "[null]") objcc_WorkStuRelation_TotalByQuTypeEN.QuestionTypeId4Course = null; //题目类型Id4课程
if (objcc_WorkStuRelation_TotalByQuTypeEN.SchoolYear == "[null]") objcc_WorkStuRelation_TotalByQuTypeEN.SchoolYear = null; //学年
if (objcc_WorkStuRelation_TotalByQuTypeEN.SchoolTerm == "[null]") objcc_WorkStuRelation_TotalByQuTypeEN.SchoolTerm = null; //学期
if (objcc_WorkStuRelation_TotalByQuTypeEN.UpdUserId == "[null]") objcc_WorkStuRelation_TotalByQuTypeEN.UpdUserId = null; //修改用户Id
if (objcc_WorkStuRelation_TotalByQuTypeEN.Memo == "[null]") objcc_WorkStuRelation_TotalByQuTypeEN.Memo = null; //备注
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
public static void CheckPropertyNew(clscc_WorkStuRelation_TotalByQuTypeEN objcc_WorkStuRelation_TotalByQuTypeEN)
{
 cc_WorkStuRelation_TotalByQuTypeDA.CheckPropertyNew(objcc_WorkStuRelation_TotalByQuTypeEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(clscc_WorkStuRelation_TotalByQuTypeEN objcc_WorkStuRelation_TotalByQuTypeEN)
{
 cc_WorkStuRelation_TotalByQuTypeDA.CheckProperty4Condition(objcc_WorkStuRelation_TotalByQuTypeEN);
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
if (clscc_WorkStuRelation_TotalByQuTypeBL.objCommFun4BL == null)
{
strMsg = string.Format("类clscc_WorkStuRelation_TotalByQuTypeBL没有刷新缓存机制(clscc_WorkStuRelation_TotalByQuTypeBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by IdWorkStuRelationTotal");
//if (arrcc_WorkStuRelation_TotalByQuTypeObjLstCache == null)
//{
//arrcc_WorkStuRelation_TotalByQuTypeObjLstCache = cc_WorkStuRelation_TotalByQuTypeDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "lngIdWorkStuRelationTotal">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clscc_WorkStuRelation_TotalByQuTypeEN GetObjByIdWorkStuRelationTotalCache(long lngIdWorkStuRelationTotal)
{
//获取缓存中的对象列表
string strKey = string.Format("{0}", clscc_WorkStuRelation_TotalByQuTypeEN._CurrTabName);
List<clscc_WorkStuRelation_TotalByQuTypeEN> arrcc_WorkStuRelation_TotalByQuTypeObjLstCache = GetObjLstCache();
IEnumerable <clscc_WorkStuRelation_TotalByQuTypeEN> arrcc_WorkStuRelation_TotalByQuTypeObjLst_Sel =
arrcc_WorkStuRelation_TotalByQuTypeObjLstCache
.Where(x=> x.IdWorkStuRelationTotal == lngIdWorkStuRelationTotal 
);
if (arrcc_WorkStuRelation_TotalByQuTypeObjLst_Sel.Count() == 0)
{
   clscc_WorkStuRelation_TotalByQuTypeEN obj = clscc_WorkStuRelation_TotalByQuTypeBL.GetObjByIdWorkStuRelationTotal(lngIdWorkStuRelationTotal);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
 }
return null;
}
return arrcc_WorkStuRelation_TotalByQuTypeObjLst_Sel.First();
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clscc_WorkStuRelation_TotalByQuTypeEN> GetAllcc_WorkStuRelation_TotalByQuTypeObjLstCache()
{
//获取缓存中的对象列表
List<clscc_WorkStuRelation_TotalByQuTypeEN> arrcc_WorkStuRelation_TotalByQuTypeObjLstCache = GetObjLstCache(); 
return arrcc_WorkStuRelation_TotalByQuTypeObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clscc_WorkStuRelation_TotalByQuTypeEN> GetObjLstCache()
{
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}", clscc_WorkStuRelation_TotalByQuTypeEN._CurrTabName);
List<clscc_WorkStuRelation_TotalByQuTypeEN> arrcc_WorkStuRelation_TotalByQuTypeObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrcc_WorkStuRelation_TotalByQuTypeObjLstCache;
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
string strKey = string.Format("{0}", clscc_WorkStuRelation_TotalByQuTypeEN._CurrTabName);
CacheHelper.Remove(strKey);
clscc_WorkStuRelation_TotalByQuTypeEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
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
if (clscc_WorkStuRelation_TotalByQuTypeEN._RefreshTimeLst.Count == 0) return "";
return clscc_WorkStuRelation_TotalByQuTypeEN._RefreshTimeLst[clscc_WorkStuRelation_TotalByQuTypeEN._RefreshTimeLst.Count - 1];
}

 /// <summary>
 /// 刷新缓存.把当前表的缓存以及该表相关视图的缓存清空.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ReFreshCache)
 /// </summary>
public static void ReFreshCache()
{
if (clscc_WorkStuRelation_TotalByQuTypeBL.objCommFun4BL != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}", clscc_WorkStuRelation_TotalByQuTypeEN._CurrTabName);
CacheHelper.Remove(strKey);
clscc_WorkStuRelation_TotalByQuTypeEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
clscc_WorkStuRelation_TotalByQuTypeBL.objCommFun4BL.ReFreshCache();
}
}


 #endregion 缓存操作


 #region 检查唯一性

 /// <summary>
 /// 获取检查唯一性条件串(Uniqueness)--cc_WorkStuRelation_TotalByQuType(作业完成情况汇总表ByQuType)
 /// 唯一性条件:id_CurrEduCls_id_StudentInfo
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetUniquenessConditionString)
 /// </summary>
 /// <param name = "objcc_WorkStuRelation_TotalByQuTypeEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(clscc_WorkStuRelation_TotalByQuTypeEN objcc_WorkStuRelation_TotalByQuTypeEN)
{
//检测记录是否存在
string strResult = cc_WorkStuRelation_TotalByQuTypeDA.GetUniCondStr(objcc_WorkStuRelation_TotalByQuTypeEN);
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
public static string Func(string strInFldName, string strOutFldName, long lngIdWorkStuRelationTotal)
{
if (strInFldName != concc_WorkStuRelation_TotalByQuType.IdWorkStuRelationTotal)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (concc_WorkStuRelation_TotalByQuType.AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", concc_WorkStuRelation_TotalByQuType.AttributeName));
throw new Exception(strMsg);
}
var objcc_WorkStuRelation_TotalByQuType = clscc_WorkStuRelation_TotalByQuTypeBL.GetObjByIdWorkStuRelationTotalCache(lngIdWorkStuRelationTotal);
if (objcc_WorkStuRelation_TotalByQuType == null) return "";
return objcc_WorkStuRelation_TotalByQuType[strOutFldName].ToString();
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
int intRecCount = clscc_WorkStuRelation_TotalByQuTypeDA.GetRecCount(strTabName);
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
int intRecCount = clscc_WorkStuRelation_TotalByQuTypeDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clscc_WorkStuRelation_TotalByQuTypeDA.GetRecCount();
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
int intRecCount = clscc_WorkStuRelation_TotalByQuTypeDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objcc_WorkStuRelation_TotalByQuTypeCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clscc_WorkStuRelation_TotalByQuTypeEN objcc_WorkStuRelation_TotalByQuTypeCond)
{
List<clscc_WorkStuRelation_TotalByQuTypeEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clscc_WorkStuRelation_TotalByQuTypeEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in concc_WorkStuRelation_TotalByQuType.AttributeName)
{
if (objcc_WorkStuRelation_TotalByQuTypeCond.IsUpdated(strFldName) == false) continue;
if (objcc_WorkStuRelation_TotalByQuTypeCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objcc_WorkStuRelation_TotalByQuTypeCond[strFldName].ToString());
}
else
{
if (objcc_WorkStuRelation_TotalByQuTypeCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objcc_WorkStuRelation_TotalByQuTypeCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objcc_WorkStuRelation_TotalByQuTypeCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objcc_WorkStuRelation_TotalByQuTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objcc_WorkStuRelation_TotalByQuTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objcc_WorkStuRelation_TotalByQuTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objcc_WorkStuRelation_TotalByQuTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objcc_WorkStuRelation_TotalByQuTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objcc_WorkStuRelation_TotalByQuTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objcc_WorkStuRelation_TotalByQuTypeCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objcc_WorkStuRelation_TotalByQuTypeCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objcc_WorkStuRelation_TotalByQuTypeCond[strFldName]));
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
 List<string> arrList = clscc_WorkStuRelation_TotalByQuTypeDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = cc_WorkStuRelation_TotalByQuTypeDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = cc_WorkStuRelation_TotalByQuTypeDA.GetFldValueNoDistinct(strFldName, strWhereCond);
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
int intRecCount = cc_WorkStuRelation_TotalByQuTypeDA.SetFldValue(strFldName, strValue, strWhereCond);
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
int intRecCount = clscc_WorkStuRelation_TotalByQuTypeDA.SetFldValue(clscc_WorkStuRelation_TotalByQuTypeEN._CurrTabName, strFldName, fltValue, strWhereCond);
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
int intRecCount = cc_WorkStuRelation_TotalByQuTypeDA.SetFldValue( strFldName, intValue, strWhereCond);
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
int intRecCount = clscc_WorkStuRelation_TotalByQuTypeDA.SetFldValue(strTabName, strFldName, strValue, strWhereCond);
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
int intRecCount = clscc_WorkStuRelation_TotalByQuTypeDA.SetFldValue(strTabName, strFldName, intValue, strWhereCond);
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
int intRecCount = clscc_WorkStuRelation_TotalByQuTypeDA.SetFldValue(strTabName, strFldName, fltValue, strWhereCond);
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
  strCreateTabCode.Append("CREATE table [dbo].[cc_WorkStuRelation_TotalByQuType] "); 
 strCreateTabCode.Append(" ( "); 
 // /**流水号*/ 
 strCreateTabCode.Append(" IdWorkStuRelationTotal bigint primary key identity, "); 
 // /**教学班流水号*/ 
 strCreateTabCode.Append(" IdCurrEduCls char(8) not Null, "); 
 // /**学生流水号*/ 
 strCreateTabCode.Append(" IdStudentInfo char(8) not Null, "); 
 // /**题目类型Id*/ 
 strCreateTabCode.Append(" QuestionTypeId char(2) Null, "); 
 // /**题目类型Id4课程*/ 
 strCreateTabCode.Append(" QuestionTypeId4Course char(8) Null, "); 
 // /**作业数*/ 
 strCreateTabCode.Append(" WorkNum int not Null, "); 
 // /**提交作业数*/ 
 strCreateTabCode.Append(" WorkNumSubmit int Null, "); 
 // /**保存作业数*/ 
 strCreateTabCode.Append(" WorkNumSave int Null, "); 
 // /**未完成作业数*/ 
 strCreateTabCode.Append(" WorkNumNoFinish int Null, "); 
 // /**退回作业数*/ 
 strCreateTabCode.Append(" WorkNumSendBack int Null, "); 
 // /**批改作业数*/ 
 strCreateTabCode.Append(" WorkNumMark int Null, "); 
 // /**查看作业数*/ 
 strCreateTabCode.Append(" WorkNumLook int Null, "); 
 // /**逾期作业数*/ 
 strCreateTabCode.Append(" WorkNumOverdue int Null, "); 
 // /**总得分*/ 
 strCreateTabCode.Append(" TotalScore decimal(10,1) Null, "); 
 // /**总分值*/ 
 strCreateTabCode.Append(" TotalScores decimal(10,2) Null, "); 
 // /**学年*/ 
 strCreateTabCode.Append(" SchoolYear varchar(10) Null, "); 
 // /**学期*/ 
 strCreateTabCode.Append(" SchoolTerm char(1) Null, "); 
 // /**修改日期*/ 
 strCreateTabCode.Append(" UpdDate varchar(20) not Null, "); 
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
 /// 作业完成情况汇总表ByQuType(cc_WorkStuRelation_TotalByQuType)
 /// 数据源类型:表
 /// (AutoGCLib.CommFun4BL4CSharp:GeneCode_This)
 /// </summary>
public class  clsCommFun4BL4cc_WorkStuRelation_TotalByQuType : clsCommFun4BL
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
clscc_WorkStuRelation_TotalByQuTypeBL.ReFreshThisCache();
}
}

}