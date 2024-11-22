
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clscc_KnowledgeStuTeachLogBL
 表名:cc_KnowledgeStuTeachLog(01120973)
 * 版本:2024.11.13.1(服务器:WIN-SRV103-116)
 日期:2024/11/13 05:58:47
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:研究生学习游戏化后台(000055, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:知识点相关(Knowledges)
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
public static class  clscc_KnowledgeStuTeachLogBL_Static
{

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_AddNewRecord)
 /// </summary>
 /// <param name = "objcc_KnowledgeStuTeachLogEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clscc_KnowledgeStuTeachLogEN objcc_KnowledgeStuTeachLogEN, bool bolIsNeedCheckUniqueness = true)
{
try
{
bool bolResult = clscc_KnowledgeStuTeachLogBL.cc_KnowledgeStuTeachLogDA.AddNewRecordBySQL2(objcc_KnowledgeStuTeachLogEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clscc_KnowledgeStuTeachLogBL.ReFreshCache();

if (clscc_KnowledgeStuTeachLogBL.relatedActions != null)
{
clscc_KnowledgeStuTeachLogBL.relatedActions.UpdRelaTabDate(objcc_KnowledgeStuTeachLogEN.QuestionId,objcc_KnowledgeStuTeachLogEN.IdStudentInfo, objcc_KnowledgeStuTeachLogEN.UpdUserId);
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
public static bool AddRecordEx(this clscc_KnowledgeStuTeachLogEN objcc_KnowledgeStuTeachLogEN, bool bolIsNeedCheckUniqueness = true)
{
//操作步骤:
//1、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在
//2、检查唯一性
//3、检查传进去的对象属性是否合法
//4、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
//1、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在
if (clscc_KnowledgeStuTeachLogBL.IsExist(objcc_KnowledgeStuTeachLogEN.QuestionId,objcc_KnowledgeStuTeachLogEN.IdStudentInfo))	//判断是否有相同的关键字
{
strMsg = "(errid:Busi000151)关键字字段已有相同的值";
throw new Exception(strMsg);
}
try
{
 //2、检查传进去的对象属性是否合法
objcc_KnowledgeStuTeachLogEN.CheckPropertyNew();
//6、把数据实体层的数据存贮到数据库中
objcc_KnowledgeStuTeachLogEN.AddNewRecord();
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
 /// <param name = "objcc_KnowledgeStuTeachLogEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordWithReturnKey(this clscc_KnowledgeStuTeachLogEN objcc_KnowledgeStuTeachLogEN, bool bolIsNeedCheckUniqueness = true)
{
try
{
string strKey = clscc_KnowledgeStuTeachLogBL.cc_KnowledgeStuTeachLogDA.AddNewRecordBySQL2WithReturnKey(objcc_KnowledgeStuTeachLogEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clscc_KnowledgeStuTeachLogBL.ReFreshCache();

if (clscc_KnowledgeStuTeachLogBL.relatedActions != null)
{
clscc_KnowledgeStuTeachLogBL.relatedActions.UpdRelaTabDate(objcc_KnowledgeStuTeachLogEN.QuestionId,objcc_KnowledgeStuTeachLogEN.IdStudentInfo, objcc_KnowledgeStuTeachLogEN.UpdUserId);
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
 /// <param name = "objcc_KnowledgeStuTeachLogEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clscc_KnowledgeStuTeachLogEN SetQuestionId(this clscc_KnowledgeStuTeachLogEN objcc_KnowledgeStuTeachLogEN, long lngQuestionId, string strComparisonOp="")
	{
objcc_KnowledgeStuTeachLogEN.QuestionId = lngQuestionId; //题目Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_KnowledgeStuTeachLogEN.dicFldComparisonOp.ContainsKey(concc_KnowledgeStuTeachLog.QuestionId) == false)
{
objcc_KnowledgeStuTeachLogEN.dicFldComparisonOp.Add(concc_KnowledgeStuTeachLog.QuestionId, strComparisonOp);
}
else
{
objcc_KnowledgeStuTeachLogEN.dicFldComparisonOp[concc_KnowledgeStuTeachLog.QuestionId] = strComparisonOp;
}
}
return objcc_KnowledgeStuTeachLogEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_KnowledgeStuTeachLogEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clscc_KnowledgeStuTeachLogEN SetIdStudentInfo(this clscc_KnowledgeStuTeachLogEN objcc_KnowledgeStuTeachLogEN, string strIdStudentInfo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdStudentInfo, 8, concc_KnowledgeStuTeachLog.IdStudentInfo);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdStudentInfo, 8, concc_KnowledgeStuTeachLog.IdStudentInfo);
}
objcc_KnowledgeStuTeachLogEN.IdStudentInfo = strIdStudentInfo; //学生流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_KnowledgeStuTeachLogEN.dicFldComparisonOp.ContainsKey(concc_KnowledgeStuTeachLog.IdStudentInfo) == false)
{
objcc_KnowledgeStuTeachLogEN.dicFldComparisonOp.Add(concc_KnowledgeStuTeachLog.IdStudentInfo, strComparisonOp);
}
else
{
objcc_KnowledgeStuTeachLogEN.dicFldComparisonOp[concc_KnowledgeStuTeachLog.IdStudentInfo] = strComparisonOp;
}
}
return objcc_KnowledgeStuTeachLogEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_KnowledgeStuTeachLogEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clscc_KnowledgeStuTeachLogEN SetTeachingLog(this clscc_KnowledgeStuTeachLogEN objcc_KnowledgeStuTeachLogEN, string strTeachingLog, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strTeachingLog, concc_KnowledgeStuTeachLog.TeachingLog);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTeachingLog, 5000, concc_KnowledgeStuTeachLog.TeachingLog);
}
objcc_KnowledgeStuTeachLogEN.TeachingLog = strTeachingLog; //教学日志
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_KnowledgeStuTeachLogEN.dicFldComparisonOp.ContainsKey(concc_KnowledgeStuTeachLog.TeachingLog) == false)
{
objcc_KnowledgeStuTeachLogEN.dicFldComparisonOp.Add(concc_KnowledgeStuTeachLog.TeachingLog, strComparisonOp);
}
else
{
objcc_KnowledgeStuTeachLogEN.dicFldComparisonOp[concc_KnowledgeStuTeachLog.TeachingLog] = strComparisonOp;
}
}
return objcc_KnowledgeStuTeachLogEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_KnowledgeStuTeachLogEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clscc_KnowledgeStuTeachLogEN SetCourseId(this clscc_KnowledgeStuTeachLogEN objcc_KnowledgeStuTeachLogEN, string strCourseId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCourseId, 8, concc_KnowledgeStuTeachLog.CourseId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strCourseId, 8, concc_KnowledgeStuTeachLog.CourseId);
}
objcc_KnowledgeStuTeachLogEN.CourseId = strCourseId; //课程Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_KnowledgeStuTeachLogEN.dicFldComparisonOp.ContainsKey(concc_KnowledgeStuTeachLog.CourseId) == false)
{
objcc_KnowledgeStuTeachLogEN.dicFldComparisonOp.Add(concc_KnowledgeStuTeachLog.CourseId, strComparisonOp);
}
else
{
objcc_KnowledgeStuTeachLogEN.dicFldComparisonOp[concc_KnowledgeStuTeachLog.CourseId] = strComparisonOp;
}
}
return objcc_KnowledgeStuTeachLogEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_KnowledgeStuTeachLogEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clscc_KnowledgeStuTeachLogEN SetUpdDate(this clscc_KnowledgeStuTeachLogEN objcc_KnowledgeStuTeachLogEN, string strUpdDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strUpdDate, concc_KnowledgeStuTeachLog.UpdDate);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdDate, 20, concc_KnowledgeStuTeachLog.UpdDate);
}
objcc_KnowledgeStuTeachLogEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_KnowledgeStuTeachLogEN.dicFldComparisonOp.ContainsKey(concc_KnowledgeStuTeachLog.UpdDate) == false)
{
objcc_KnowledgeStuTeachLogEN.dicFldComparisonOp.Add(concc_KnowledgeStuTeachLog.UpdDate, strComparisonOp);
}
else
{
objcc_KnowledgeStuTeachLogEN.dicFldComparisonOp[concc_KnowledgeStuTeachLog.UpdDate] = strComparisonOp;
}
}
return objcc_KnowledgeStuTeachLogEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_KnowledgeStuTeachLogEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clscc_KnowledgeStuTeachLogEN SetUpdUserId(this clscc_KnowledgeStuTeachLogEN objcc_KnowledgeStuTeachLogEN, string strUpdUserId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdUserId, 20, concc_KnowledgeStuTeachLog.UpdUserId);
}
objcc_KnowledgeStuTeachLogEN.UpdUserId = strUpdUserId; //修改用户Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_KnowledgeStuTeachLogEN.dicFldComparisonOp.ContainsKey(concc_KnowledgeStuTeachLog.UpdUserId) == false)
{
objcc_KnowledgeStuTeachLogEN.dicFldComparisonOp.Add(concc_KnowledgeStuTeachLog.UpdUserId, strComparisonOp);
}
else
{
objcc_KnowledgeStuTeachLogEN.dicFldComparisonOp[concc_KnowledgeStuTeachLog.UpdUserId] = strComparisonOp;
}
}
return objcc_KnowledgeStuTeachLogEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_KnowledgeStuTeachLogEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clscc_KnowledgeStuTeachLogEN SetMemo(this clscc_KnowledgeStuTeachLogEN objcc_KnowledgeStuTeachLogEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, concc_KnowledgeStuTeachLog.Memo);
}
objcc_KnowledgeStuTeachLogEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_KnowledgeStuTeachLogEN.dicFldComparisonOp.ContainsKey(concc_KnowledgeStuTeachLog.Memo) == false)
{
objcc_KnowledgeStuTeachLogEN.dicFldComparisonOp.Add(concc_KnowledgeStuTeachLog.Memo, strComparisonOp);
}
else
{
objcc_KnowledgeStuTeachLogEN.dicFldComparisonOp[concc_KnowledgeStuTeachLog.Memo] = strComparisonOp;
}
}
return objcc_KnowledgeStuTeachLogEN;
	}

 /// <summary>
 /// 修改记录存盘到数据表中
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_UpdateRecordEx)
 /// </summary>
 /// <param name = "objcc_KnowledgeStuTeachLogEN">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool UpdateRecordEx(this clscc_KnowledgeStuTeachLogEN objcc_KnowledgeStuTeachLogEN)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
try
{
//1、检查传进去的对象属性是否合法
objcc_KnowledgeStuTeachLogEN.CheckPropertyNew();
clscc_KnowledgeStuTeachLogEN objcc_KnowledgeStuTeachLogCond = new clscc_KnowledgeStuTeachLogEN();
string strCondition = objcc_KnowledgeStuTeachLogCond
.SetQuestionId(objcc_KnowledgeStuTeachLogEN.QuestionId, "=")
.GetCombineCondition();
objcc_KnowledgeStuTeachLogEN._IsCheckProperty = true;
bool bolIsExist = clscc_KnowledgeStuTeachLogBL.IsExistRecord(strCondition);
if (bolIsExist)
{
strMsg = "()不能重复!";
throw new Exception(strMsg);
}
//4、把数据实体层的数据存贮到数据库中
objcc_KnowledgeStuTeachLogEN.Update();
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
 /// <param name = "objcc_KnowledgeStuTeachLogEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clscc_KnowledgeStuTeachLogEN objcc_KnowledgeStuTeachLogEN)
{
 if (objcc_KnowledgeStuTeachLogEN.QuestionId == 0)
 {
string strMsg = string.Format("(errid:Busi000095)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clscc_KnowledgeStuTeachLogBL.cc_KnowledgeStuTeachLogDA.UpdateBySql2(objcc_KnowledgeStuTeachLogEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clscc_KnowledgeStuTeachLogBL.ReFreshCache();

if (clscc_KnowledgeStuTeachLogBL.relatedActions != null)
{
clscc_KnowledgeStuTeachLogBL.relatedActions.UpdRelaTabDate(objcc_KnowledgeStuTeachLogEN.QuestionId,objcc_KnowledgeStuTeachLogEN.IdStudentInfo, objcc_KnowledgeStuTeachLogEN.UpdUserId);
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
 /// <param name = "objcc_KnowledgeStuTeachLogEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clscc_KnowledgeStuTeachLogEN objcc_KnowledgeStuTeachLogEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (objcc_KnowledgeStuTeachLogEN.QuestionId == 0)
 {
string strMsg = string.Format("(errid:Busi000087)修改记录时关键字不能为空!(带事务处理)(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clscc_KnowledgeStuTeachLogBL.cc_KnowledgeStuTeachLogDA.UpdateBySql2(objcc_KnowledgeStuTeachLogEN, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clscc_KnowledgeStuTeachLogBL.ReFreshCache();

if (clscc_KnowledgeStuTeachLogBL.relatedActions != null)
{
clscc_KnowledgeStuTeachLogBL.relatedActions.UpdRelaTabDate(objcc_KnowledgeStuTeachLogEN.QuestionId,objcc_KnowledgeStuTeachLogEN.IdStudentInfo, objcc_KnowledgeStuTeachLogEN.UpdUserId);
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
 /// <param name = "objcc_KnowledgeStuTeachLogEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clscc_KnowledgeStuTeachLogEN objcc_KnowledgeStuTeachLogEN, string strWhereCond)
{
try
{
bool bolResult = clscc_KnowledgeStuTeachLogBL.cc_KnowledgeStuTeachLogDA.UpdateBySqlWithCondition(objcc_KnowledgeStuTeachLogEN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clscc_KnowledgeStuTeachLogBL.ReFreshCache();

if (clscc_KnowledgeStuTeachLogBL.relatedActions != null)
{
clscc_KnowledgeStuTeachLogBL.relatedActions.UpdRelaTabDate(objcc_KnowledgeStuTeachLogEN.QuestionId,objcc_KnowledgeStuTeachLogEN.IdStudentInfo, objcc_KnowledgeStuTeachLogEN.UpdUserId);
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
 /// <param name = "objcc_KnowledgeStuTeachLogEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clscc_KnowledgeStuTeachLogEN objcc_KnowledgeStuTeachLogEN, string strWhereCond, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
bool bolResult = clscc_KnowledgeStuTeachLogBL.cc_KnowledgeStuTeachLogDA.UpdateBySqlWithConditionTransaction(objcc_KnowledgeStuTeachLogEN, strWhereCond, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clscc_KnowledgeStuTeachLogBL.ReFreshCache();

if (clscc_KnowledgeStuTeachLogBL.relatedActions != null)
{
clscc_KnowledgeStuTeachLogBL.relatedActions.UpdRelaTabDate(objcc_KnowledgeStuTeachLogEN.QuestionId,objcc_KnowledgeStuTeachLogEN.IdStudentInfo, objcc_KnowledgeStuTeachLogEN.UpdUserId);
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
 /// <param name = "lngQuestionId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int Delete(this clscc_KnowledgeStuTeachLogEN objcc_KnowledgeStuTeachLogEN)
{
try
{
int intRecNum = clscc_KnowledgeStuTeachLogBL.cc_KnowledgeStuTeachLogDA.DelRecord(objcc_KnowledgeStuTeachLogEN.QuestionId,objcc_KnowledgeStuTeachLogEN.IdStudentInfo);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clscc_KnowledgeStuTeachLogBL.ReFreshCache();

if (clscc_KnowledgeStuTeachLogBL.relatedActions != null)
{
clscc_KnowledgeStuTeachLogBL.relatedActions.UpdRelaTabDate(objcc_KnowledgeStuTeachLogEN.QuestionId,objcc_KnowledgeStuTeachLogEN.IdStudentInfo, objcc_KnowledgeStuTeachLogEN.UpdUserId);
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
 /// <param name = "objcc_KnowledgeStuTeachLogENS">源对象</param>
 /// <param name = "objcc_KnowledgeStuTeachLogENT">目标对象</param>
 public static void CopyTo(this clscc_KnowledgeStuTeachLogEN objcc_KnowledgeStuTeachLogENS, clscc_KnowledgeStuTeachLogEN objcc_KnowledgeStuTeachLogENT)
{
try
{
objcc_KnowledgeStuTeachLogENT.QuestionId = objcc_KnowledgeStuTeachLogENS.QuestionId; //题目Id
objcc_KnowledgeStuTeachLogENT.IdStudentInfo = objcc_KnowledgeStuTeachLogENS.IdStudentInfo; //学生流水号
objcc_KnowledgeStuTeachLogENT.TeachingLog = objcc_KnowledgeStuTeachLogENS.TeachingLog; //教学日志
objcc_KnowledgeStuTeachLogENT.CourseId = objcc_KnowledgeStuTeachLogENS.CourseId; //课程Id
objcc_KnowledgeStuTeachLogENT.UpdDate = objcc_KnowledgeStuTeachLogENS.UpdDate; //修改日期
objcc_KnowledgeStuTeachLogENT.UpdUserId = objcc_KnowledgeStuTeachLogENS.UpdUserId; //修改用户Id
objcc_KnowledgeStuTeachLogENT.Memo = objcc_KnowledgeStuTeachLogENS.Memo; //备注
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
 /// <param name = "objcc_KnowledgeStuTeachLogENS">源对象</param>
 /// <returns>目标对象=>clscc_KnowledgeStuTeachLogEN:objcc_KnowledgeStuTeachLogENT</returns>
 public static clscc_KnowledgeStuTeachLogEN CopyTo(this clscc_KnowledgeStuTeachLogEN objcc_KnowledgeStuTeachLogENS)
{
try
{
 clscc_KnowledgeStuTeachLogEN objcc_KnowledgeStuTeachLogENT = new clscc_KnowledgeStuTeachLogEN()
{
QuestionId = objcc_KnowledgeStuTeachLogENS.QuestionId, //题目Id
IdStudentInfo = objcc_KnowledgeStuTeachLogENS.IdStudentInfo, //学生流水号
TeachingLog = objcc_KnowledgeStuTeachLogENS.TeachingLog, //教学日志
CourseId = objcc_KnowledgeStuTeachLogENS.CourseId, //课程Id
UpdDate = objcc_KnowledgeStuTeachLogENS.UpdDate, //修改日期
UpdUserId = objcc_KnowledgeStuTeachLogENS.UpdUserId, //修改用户Id
Memo = objcc_KnowledgeStuTeachLogENS.Memo, //备注
};
 return objcc_KnowledgeStuTeachLogENT;
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
public static void CheckPropertyNew(this clscc_KnowledgeStuTeachLogEN objcc_KnowledgeStuTeachLogEN)
{
 clscc_KnowledgeStuTeachLogBL.cc_KnowledgeStuTeachLogDA.CheckPropertyNew(objcc_KnowledgeStuTeachLogEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(this clscc_KnowledgeStuTeachLogEN objcc_KnowledgeStuTeachLogEN)
{
 clscc_KnowledgeStuTeachLogBL.cc_KnowledgeStuTeachLogDA.CheckProperty4Condition(objcc_KnowledgeStuTeachLogEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clscc_KnowledgeStuTeachLogEN objcc_KnowledgeStuTeachLogCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objcc_KnowledgeStuTeachLogCond.IsUpdated(concc_KnowledgeStuTeachLog.QuestionId) == true)
{
string strComparisonOpQuestionId = objcc_KnowledgeStuTeachLogCond.dicFldComparisonOp[concc_KnowledgeStuTeachLog.QuestionId];
strWhereCond += string.Format(" And {0} {2} {1}", concc_KnowledgeStuTeachLog.QuestionId, objcc_KnowledgeStuTeachLogCond.QuestionId, strComparisonOpQuestionId);
}
if (objcc_KnowledgeStuTeachLogCond.IsUpdated(concc_KnowledgeStuTeachLog.IdStudentInfo) == true)
{
string strComparisonOpIdStudentInfo = objcc_KnowledgeStuTeachLogCond.dicFldComparisonOp[concc_KnowledgeStuTeachLog.IdStudentInfo];
strWhereCond += string.Format(" And {0} {2} '{1}'", concc_KnowledgeStuTeachLog.IdStudentInfo, objcc_KnowledgeStuTeachLogCond.IdStudentInfo, strComparisonOpIdStudentInfo);
}
if (objcc_KnowledgeStuTeachLogCond.IsUpdated(concc_KnowledgeStuTeachLog.TeachingLog) == true)
{
string strComparisonOpTeachingLog = objcc_KnowledgeStuTeachLogCond.dicFldComparisonOp[concc_KnowledgeStuTeachLog.TeachingLog];
strWhereCond += string.Format(" And {0} {2} '{1}'", concc_KnowledgeStuTeachLog.TeachingLog, objcc_KnowledgeStuTeachLogCond.TeachingLog, strComparisonOpTeachingLog);
}
if (objcc_KnowledgeStuTeachLogCond.IsUpdated(concc_KnowledgeStuTeachLog.CourseId) == true)
{
string strComparisonOpCourseId = objcc_KnowledgeStuTeachLogCond.dicFldComparisonOp[concc_KnowledgeStuTeachLog.CourseId];
strWhereCond += string.Format(" And {0} {2} '{1}'", concc_KnowledgeStuTeachLog.CourseId, objcc_KnowledgeStuTeachLogCond.CourseId, strComparisonOpCourseId);
}
if (objcc_KnowledgeStuTeachLogCond.IsUpdated(concc_KnowledgeStuTeachLog.UpdDate) == true)
{
string strComparisonOpUpdDate = objcc_KnowledgeStuTeachLogCond.dicFldComparisonOp[concc_KnowledgeStuTeachLog.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", concc_KnowledgeStuTeachLog.UpdDate, objcc_KnowledgeStuTeachLogCond.UpdDate, strComparisonOpUpdDate);
}
if (objcc_KnowledgeStuTeachLogCond.IsUpdated(concc_KnowledgeStuTeachLog.UpdUserId) == true)
{
string strComparisonOpUpdUserId = objcc_KnowledgeStuTeachLogCond.dicFldComparisonOp[concc_KnowledgeStuTeachLog.UpdUserId];
strWhereCond += string.Format(" And {0} {2} '{1}'", concc_KnowledgeStuTeachLog.UpdUserId, objcc_KnowledgeStuTeachLogCond.UpdUserId, strComparisonOpUpdUserId);
}
if (objcc_KnowledgeStuTeachLogCond.IsUpdated(concc_KnowledgeStuTeachLog.Memo) == true)
{
string strComparisonOpMemo = objcc_KnowledgeStuTeachLogCond.dicFldComparisonOp[concc_KnowledgeStuTeachLog.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", concc_KnowledgeStuTeachLog.Memo, objcc_KnowledgeStuTeachLogCond.Memo, strComparisonOpMemo);
}
 return strWhereCond;
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_cc_KnowledgeStuTeachLog
{
public virtual bool UpdRelaTabDate(long lngQuestionId,string strIdStudentInfo, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// 学生知识点教学日志(cc_KnowledgeStuTeachLog)
 /// 数据源类型:表
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clscc_KnowledgeStuTeachLogBL
{
public static RelatedActions_cc_KnowledgeStuTeachLog relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clscc_KnowledgeStuTeachLogDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clscc_KnowledgeStuTeachLogDA cc_KnowledgeStuTeachLogDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clscc_KnowledgeStuTeachLogDA();
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
 public clscc_KnowledgeStuTeachLogBL()
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
if (string.IsNullOrEmpty(clscc_KnowledgeStuTeachLogEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clscc_KnowledgeStuTeachLogEN._ConnectString);
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
public static DataTable GetDataTable_cc_KnowledgeStuTeachLog(string strWhereCond)
{
DataTable objDT;
try
{
objDT = cc_KnowledgeStuTeachLogDA.GetDataTable_cc_KnowledgeStuTeachLog(strWhereCond);
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
objDT = cc_KnowledgeStuTeachLogDA.GetDataTable(strWhereCond);
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
objDT = cc_KnowledgeStuTeachLogDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = cc_KnowledgeStuTeachLogDA.GetDataTable(strWhereCond, strTabName);
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
objDT = cc_KnowledgeStuTeachLogDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = cc_KnowledgeStuTeachLogDA.GetDataTable_Top(objTopPara);
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
objDT = cc_KnowledgeStuTeachLogDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = cc_KnowledgeStuTeachLogDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = cc_KnowledgeStuTeachLogDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
 /// 把多个关键字段的值连接起来,用|连接(Join)--cc_KnowledgeStuTeachLog(学生知识点教学日志)
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_JoinByKeyLst)
 /// </summary>
 /// <param name = "objcc_KnowledgeStuTeachLogEN">需要连接的对象</param>
 /// <returns></returns>
public static string JoinByKeyLst(clscc_KnowledgeStuTeachLogEN objcc_KnowledgeStuTeachLogEN)
{
//检测记录是否存在
string strResult = "";
strResult += objcc_KnowledgeStuTeachLogEN.QuestionId;
strResult += "|" + objcc_KnowledgeStuTeachLogEN.IdStudentInfo;
return strResult;
}
 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrKeyLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clscc_KnowledgeStuTeachLogEN> GetObjLstByKeyLstsCache(List<string> arrKeyLst)
{
string strKey = string.Format("{0}", clscc_KnowledgeStuTeachLogEN._CurrTabName);
List<clscc_KnowledgeStuTeachLogEN> arrcc_KnowledgeStuTeachLogObjLstCache = GetObjLstCache();
IEnumerable <clscc_KnowledgeStuTeachLogEN> arrcc_KnowledgeStuTeachLogObjLst_Sel =
arrcc_KnowledgeStuTeachLogObjLstCache
.Where(x => arrKeyLst.Contains(JoinByKeyLst(x)));
return arrcc_KnowledgeStuTeachLogObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clscc_KnowledgeStuTeachLogEN> GetObjLst(string strWhereCond)
{
List<clscc_KnowledgeStuTeachLogEN> arrObjLst = new List<clscc_KnowledgeStuTeachLogEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clscc_KnowledgeStuTeachLogEN objcc_KnowledgeStuTeachLogEN = new clscc_KnowledgeStuTeachLogEN();
try
{
objcc_KnowledgeStuTeachLogEN.QuestionId = Int32.Parse(objRow[concc_KnowledgeStuTeachLog.QuestionId].ToString().Trim()); //题目Id
objcc_KnowledgeStuTeachLogEN.IdStudentInfo = objRow[concc_KnowledgeStuTeachLog.IdStudentInfo].ToString().Trim(); //学生流水号
objcc_KnowledgeStuTeachLogEN.TeachingLog = objRow[concc_KnowledgeStuTeachLog.TeachingLog].ToString().Trim(); //教学日志
objcc_KnowledgeStuTeachLogEN.CourseId = objRow[concc_KnowledgeStuTeachLog.CourseId] == DBNull.Value ? null : objRow[concc_KnowledgeStuTeachLog.CourseId].ToString().Trim(); //课程Id
objcc_KnowledgeStuTeachLogEN.UpdDate = objRow[concc_KnowledgeStuTeachLog.UpdDate].ToString().Trim(); //修改日期
objcc_KnowledgeStuTeachLogEN.UpdUserId = objRow[concc_KnowledgeStuTeachLog.UpdUserId] == DBNull.Value ? null : objRow[concc_KnowledgeStuTeachLog.UpdUserId].ToString().Trim(); //修改用户Id
objcc_KnowledgeStuTeachLogEN.Memo = objRow[concc_KnowledgeStuTeachLog.Memo] == DBNull.Value ? null : objRow[concc_KnowledgeStuTeachLog.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objcc_KnowledgeStuTeachLogEN.QuestionId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objcc_KnowledgeStuTeachLogEN);
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
public static List<clscc_KnowledgeStuTeachLogEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clscc_KnowledgeStuTeachLogEN> arrObjLst = new List<clscc_KnowledgeStuTeachLogEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clscc_KnowledgeStuTeachLogEN objcc_KnowledgeStuTeachLogEN = new clscc_KnowledgeStuTeachLogEN();
try
{
objcc_KnowledgeStuTeachLogEN.QuestionId = Int32.Parse(objRow[concc_KnowledgeStuTeachLog.QuestionId].ToString().Trim()); //题目Id
objcc_KnowledgeStuTeachLogEN.IdStudentInfo = objRow[concc_KnowledgeStuTeachLog.IdStudentInfo].ToString().Trim(); //学生流水号
objcc_KnowledgeStuTeachLogEN.TeachingLog = objRow[concc_KnowledgeStuTeachLog.TeachingLog].ToString().Trim(); //教学日志
objcc_KnowledgeStuTeachLogEN.CourseId = objRow[concc_KnowledgeStuTeachLog.CourseId] == DBNull.Value ? null : objRow[concc_KnowledgeStuTeachLog.CourseId].ToString().Trim(); //课程Id
objcc_KnowledgeStuTeachLogEN.UpdDate = objRow[concc_KnowledgeStuTeachLog.UpdDate].ToString().Trim(); //修改日期
objcc_KnowledgeStuTeachLogEN.UpdUserId = objRow[concc_KnowledgeStuTeachLog.UpdUserId] == DBNull.Value ? null : objRow[concc_KnowledgeStuTeachLog.UpdUserId].ToString().Trim(); //修改用户Id
objcc_KnowledgeStuTeachLogEN.Memo = objRow[concc_KnowledgeStuTeachLog.Memo] == DBNull.Value ? null : objRow[concc_KnowledgeStuTeachLog.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objcc_KnowledgeStuTeachLogEN.QuestionId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objcc_KnowledgeStuTeachLogEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objcc_KnowledgeStuTeachLogCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clscc_KnowledgeStuTeachLogEN> GetSubObjLstCache(clscc_KnowledgeStuTeachLogEN objcc_KnowledgeStuTeachLogCond)
{
List<clscc_KnowledgeStuTeachLogEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clscc_KnowledgeStuTeachLogEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in concc_KnowledgeStuTeachLog.AttributeName)
{
if (objcc_KnowledgeStuTeachLogCond.IsUpdated(strFldName) == false) continue;
if (objcc_KnowledgeStuTeachLogCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objcc_KnowledgeStuTeachLogCond[strFldName].ToString());
}
else
{
if (objcc_KnowledgeStuTeachLogCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objcc_KnowledgeStuTeachLogCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objcc_KnowledgeStuTeachLogCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objcc_KnowledgeStuTeachLogCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objcc_KnowledgeStuTeachLogCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objcc_KnowledgeStuTeachLogCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objcc_KnowledgeStuTeachLogCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objcc_KnowledgeStuTeachLogCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objcc_KnowledgeStuTeachLogCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objcc_KnowledgeStuTeachLogCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objcc_KnowledgeStuTeachLogCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objcc_KnowledgeStuTeachLogCond[strFldName]));
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
public static List<clscc_KnowledgeStuTeachLogEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clscc_KnowledgeStuTeachLogEN> arrObjLst = new List<clscc_KnowledgeStuTeachLogEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clscc_KnowledgeStuTeachLogEN objcc_KnowledgeStuTeachLogEN = new clscc_KnowledgeStuTeachLogEN();
try
{
objcc_KnowledgeStuTeachLogEN.QuestionId = Int32.Parse(objRow[concc_KnowledgeStuTeachLog.QuestionId].ToString().Trim()); //题目Id
objcc_KnowledgeStuTeachLogEN.IdStudentInfo = objRow[concc_KnowledgeStuTeachLog.IdStudentInfo].ToString().Trim(); //学生流水号
objcc_KnowledgeStuTeachLogEN.TeachingLog = objRow[concc_KnowledgeStuTeachLog.TeachingLog].ToString().Trim(); //教学日志
objcc_KnowledgeStuTeachLogEN.CourseId = objRow[concc_KnowledgeStuTeachLog.CourseId] == DBNull.Value ? null : objRow[concc_KnowledgeStuTeachLog.CourseId].ToString().Trim(); //课程Id
objcc_KnowledgeStuTeachLogEN.UpdDate = objRow[concc_KnowledgeStuTeachLog.UpdDate].ToString().Trim(); //修改日期
objcc_KnowledgeStuTeachLogEN.UpdUserId = objRow[concc_KnowledgeStuTeachLog.UpdUserId] == DBNull.Value ? null : objRow[concc_KnowledgeStuTeachLog.UpdUserId].ToString().Trim(); //修改用户Id
objcc_KnowledgeStuTeachLogEN.Memo = objRow[concc_KnowledgeStuTeachLog.Memo] == DBNull.Value ? null : objRow[concc_KnowledgeStuTeachLog.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objcc_KnowledgeStuTeachLogEN.QuestionId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objcc_KnowledgeStuTeachLogEN);
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
public static List<clscc_KnowledgeStuTeachLogEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clscc_KnowledgeStuTeachLogEN> arrObjLst = new List<clscc_KnowledgeStuTeachLogEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clscc_KnowledgeStuTeachLogEN objcc_KnowledgeStuTeachLogEN = new clscc_KnowledgeStuTeachLogEN();
try
{
objcc_KnowledgeStuTeachLogEN.QuestionId = Int32.Parse(objRow[concc_KnowledgeStuTeachLog.QuestionId].ToString().Trim()); //题目Id
objcc_KnowledgeStuTeachLogEN.IdStudentInfo = objRow[concc_KnowledgeStuTeachLog.IdStudentInfo].ToString().Trim(); //学生流水号
objcc_KnowledgeStuTeachLogEN.TeachingLog = objRow[concc_KnowledgeStuTeachLog.TeachingLog].ToString().Trim(); //教学日志
objcc_KnowledgeStuTeachLogEN.CourseId = objRow[concc_KnowledgeStuTeachLog.CourseId] == DBNull.Value ? null : objRow[concc_KnowledgeStuTeachLog.CourseId].ToString().Trim(); //课程Id
objcc_KnowledgeStuTeachLogEN.UpdDate = objRow[concc_KnowledgeStuTeachLog.UpdDate].ToString().Trim(); //修改日期
objcc_KnowledgeStuTeachLogEN.UpdUserId = objRow[concc_KnowledgeStuTeachLog.UpdUserId] == DBNull.Value ? null : objRow[concc_KnowledgeStuTeachLog.UpdUserId].ToString().Trim(); //修改用户Id
objcc_KnowledgeStuTeachLogEN.Memo = objRow[concc_KnowledgeStuTeachLog.Memo] == DBNull.Value ? null : objRow[concc_KnowledgeStuTeachLog.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objcc_KnowledgeStuTeachLogEN.QuestionId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objcc_KnowledgeStuTeachLogEN);
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
List<clscc_KnowledgeStuTeachLogEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clscc_KnowledgeStuTeachLogEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clscc_KnowledgeStuTeachLogEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clscc_KnowledgeStuTeachLogEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clscc_KnowledgeStuTeachLogEN> arrObjLst = new List<clscc_KnowledgeStuTeachLogEN>(); 
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
	clscc_KnowledgeStuTeachLogEN objcc_KnowledgeStuTeachLogEN = new clscc_KnowledgeStuTeachLogEN();
try
{
objcc_KnowledgeStuTeachLogEN.QuestionId = Int32.Parse(objRow[concc_KnowledgeStuTeachLog.QuestionId].ToString().Trim()); //题目Id
objcc_KnowledgeStuTeachLogEN.IdStudentInfo = objRow[concc_KnowledgeStuTeachLog.IdStudentInfo].ToString().Trim(); //学生流水号
objcc_KnowledgeStuTeachLogEN.TeachingLog = objRow[concc_KnowledgeStuTeachLog.TeachingLog].ToString().Trim(); //教学日志
objcc_KnowledgeStuTeachLogEN.CourseId = objRow[concc_KnowledgeStuTeachLog.CourseId] == DBNull.Value ? null : objRow[concc_KnowledgeStuTeachLog.CourseId].ToString().Trim(); //课程Id
objcc_KnowledgeStuTeachLogEN.UpdDate = objRow[concc_KnowledgeStuTeachLog.UpdDate].ToString().Trim(); //修改日期
objcc_KnowledgeStuTeachLogEN.UpdUserId = objRow[concc_KnowledgeStuTeachLog.UpdUserId] == DBNull.Value ? null : objRow[concc_KnowledgeStuTeachLog.UpdUserId].ToString().Trim(); //修改用户Id
objcc_KnowledgeStuTeachLogEN.Memo = objRow[concc_KnowledgeStuTeachLog.Memo] == DBNull.Value ? null : objRow[concc_KnowledgeStuTeachLog.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objcc_KnowledgeStuTeachLogEN.QuestionId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objcc_KnowledgeStuTeachLogEN);
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
public static List<clscc_KnowledgeStuTeachLogEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clscc_KnowledgeStuTeachLogEN> arrObjLst = new List<clscc_KnowledgeStuTeachLogEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clscc_KnowledgeStuTeachLogEN objcc_KnowledgeStuTeachLogEN = new clscc_KnowledgeStuTeachLogEN();
try
{
objcc_KnowledgeStuTeachLogEN.QuestionId = Int32.Parse(objRow[concc_KnowledgeStuTeachLog.QuestionId].ToString().Trim()); //题目Id
objcc_KnowledgeStuTeachLogEN.IdStudentInfo = objRow[concc_KnowledgeStuTeachLog.IdStudentInfo].ToString().Trim(); //学生流水号
objcc_KnowledgeStuTeachLogEN.TeachingLog = objRow[concc_KnowledgeStuTeachLog.TeachingLog].ToString().Trim(); //教学日志
objcc_KnowledgeStuTeachLogEN.CourseId = objRow[concc_KnowledgeStuTeachLog.CourseId] == DBNull.Value ? null : objRow[concc_KnowledgeStuTeachLog.CourseId].ToString().Trim(); //课程Id
objcc_KnowledgeStuTeachLogEN.UpdDate = objRow[concc_KnowledgeStuTeachLog.UpdDate].ToString().Trim(); //修改日期
objcc_KnowledgeStuTeachLogEN.UpdUserId = objRow[concc_KnowledgeStuTeachLog.UpdUserId] == DBNull.Value ? null : objRow[concc_KnowledgeStuTeachLog.UpdUserId].ToString().Trim(); //修改用户Id
objcc_KnowledgeStuTeachLogEN.Memo = objRow[concc_KnowledgeStuTeachLog.Memo] == DBNull.Value ? null : objRow[concc_KnowledgeStuTeachLog.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objcc_KnowledgeStuTeachLogEN.QuestionId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objcc_KnowledgeStuTeachLogEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clscc_KnowledgeStuTeachLogEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clscc_KnowledgeStuTeachLogEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clscc_KnowledgeStuTeachLogEN> arrObjLst = new List<clscc_KnowledgeStuTeachLogEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clscc_KnowledgeStuTeachLogEN objcc_KnowledgeStuTeachLogEN = new clscc_KnowledgeStuTeachLogEN();
try
{
objcc_KnowledgeStuTeachLogEN.QuestionId = Int32.Parse(objRow[concc_KnowledgeStuTeachLog.QuestionId].ToString().Trim()); //题目Id
objcc_KnowledgeStuTeachLogEN.IdStudentInfo = objRow[concc_KnowledgeStuTeachLog.IdStudentInfo].ToString().Trim(); //学生流水号
objcc_KnowledgeStuTeachLogEN.TeachingLog = objRow[concc_KnowledgeStuTeachLog.TeachingLog].ToString().Trim(); //教学日志
objcc_KnowledgeStuTeachLogEN.CourseId = objRow[concc_KnowledgeStuTeachLog.CourseId] == DBNull.Value ? null : objRow[concc_KnowledgeStuTeachLog.CourseId].ToString().Trim(); //课程Id
objcc_KnowledgeStuTeachLogEN.UpdDate = objRow[concc_KnowledgeStuTeachLog.UpdDate].ToString().Trim(); //修改日期
objcc_KnowledgeStuTeachLogEN.UpdUserId = objRow[concc_KnowledgeStuTeachLog.UpdUserId] == DBNull.Value ? null : objRow[concc_KnowledgeStuTeachLog.UpdUserId].ToString().Trim(); //修改用户Id
objcc_KnowledgeStuTeachLogEN.Memo = objRow[concc_KnowledgeStuTeachLog.Memo] == DBNull.Value ? null : objRow[concc_KnowledgeStuTeachLog.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objcc_KnowledgeStuTeachLogEN.QuestionId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objcc_KnowledgeStuTeachLogEN);
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
public static List<clscc_KnowledgeStuTeachLogEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clscc_KnowledgeStuTeachLogEN> arrObjLst = new List<clscc_KnowledgeStuTeachLogEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clscc_KnowledgeStuTeachLogEN objcc_KnowledgeStuTeachLogEN = new clscc_KnowledgeStuTeachLogEN();
try
{
objcc_KnowledgeStuTeachLogEN.QuestionId = Int32.Parse(objRow[concc_KnowledgeStuTeachLog.QuestionId].ToString().Trim()); //题目Id
objcc_KnowledgeStuTeachLogEN.IdStudentInfo = objRow[concc_KnowledgeStuTeachLog.IdStudentInfo].ToString().Trim(); //学生流水号
objcc_KnowledgeStuTeachLogEN.TeachingLog = objRow[concc_KnowledgeStuTeachLog.TeachingLog].ToString().Trim(); //教学日志
objcc_KnowledgeStuTeachLogEN.CourseId = objRow[concc_KnowledgeStuTeachLog.CourseId] == DBNull.Value ? null : objRow[concc_KnowledgeStuTeachLog.CourseId].ToString().Trim(); //课程Id
objcc_KnowledgeStuTeachLogEN.UpdDate = objRow[concc_KnowledgeStuTeachLog.UpdDate].ToString().Trim(); //修改日期
objcc_KnowledgeStuTeachLogEN.UpdUserId = objRow[concc_KnowledgeStuTeachLog.UpdUserId] == DBNull.Value ? null : objRow[concc_KnowledgeStuTeachLog.UpdUserId].ToString().Trim(); //修改用户Id
objcc_KnowledgeStuTeachLogEN.Memo = objRow[concc_KnowledgeStuTeachLog.Memo] == DBNull.Value ? null : objRow[concc_KnowledgeStuTeachLog.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objcc_KnowledgeStuTeachLogEN.QuestionId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objcc_KnowledgeStuTeachLogEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clscc_KnowledgeStuTeachLogEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clscc_KnowledgeStuTeachLogEN> arrObjLst = new List<clscc_KnowledgeStuTeachLogEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clscc_KnowledgeStuTeachLogEN objcc_KnowledgeStuTeachLogEN = new clscc_KnowledgeStuTeachLogEN();
try
{
objcc_KnowledgeStuTeachLogEN.QuestionId = Int32.Parse(objRow[concc_KnowledgeStuTeachLog.QuestionId].ToString().Trim()); //题目Id
objcc_KnowledgeStuTeachLogEN.IdStudentInfo = objRow[concc_KnowledgeStuTeachLog.IdStudentInfo].ToString().Trim(); //学生流水号
objcc_KnowledgeStuTeachLogEN.TeachingLog = objRow[concc_KnowledgeStuTeachLog.TeachingLog].ToString().Trim(); //教学日志
objcc_KnowledgeStuTeachLogEN.CourseId = objRow[concc_KnowledgeStuTeachLog.CourseId] == DBNull.Value ? null : objRow[concc_KnowledgeStuTeachLog.CourseId].ToString().Trim(); //课程Id
objcc_KnowledgeStuTeachLogEN.UpdDate = objRow[concc_KnowledgeStuTeachLog.UpdDate].ToString().Trim(); //修改日期
objcc_KnowledgeStuTeachLogEN.UpdUserId = objRow[concc_KnowledgeStuTeachLog.UpdUserId] == DBNull.Value ? null : objRow[concc_KnowledgeStuTeachLog.UpdUserId].ToString().Trim(); //修改用户Id
objcc_KnowledgeStuTeachLogEN.Memo = objRow[concc_KnowledgeStuTeachLog.Memo] == DBNull.Value ? null : objRow[concc_KnowledgeStuTeachLog.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objcc_KnowledgeStuTeachLogEN.QuestionId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objcc_KnowledgeStuTeachLogEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objcc_KnowledgeStuTeachLogEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool Getcc_KnowledgeStuTeachLog(ref clscc_KnowledgeStuTeachLogEN objcc_KnowledgeStuTeachLogEN)
{
bool bolResult = cc_KnowledgeStuTeachLogDA.Getcc_KnowledgeStuTeachLog(ref objcc_KnowledgeStuTeachLogEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "lngQuestionId">表关键字</param>
 /// <param name = "strIdStudentInfo">表关键字</param>
 /// <returns>表对象</returns>
public static clscc_KnowledgeStuTeachLogEN GetObjByKeyLst(long lngQuestionId,string strIdStudentInfo)
{
if (strIdStudentInfo.IndexOf(' ') >=0)
{
var strMsg = string.Format("(errid:Busi000168)在表中,关键字[lngQuestionId,strIdStudentInfo]中不能有空格!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
if (lngQuestionId == 0)
{
var strMsg = string.Format("(errid:Busi000169)在表中,关键字[lngQuestionId]不能为空!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
if (string.IsNullOrEmpty(strIdStudentInfo) == true)
{
var strMsg = string.Format("(errid:Busi000169)在表中,关键字[strIdStudentInfo]不能为空!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
clscc_KnowledgeStuTeachLogEN objcc_KnowledgeStuTeachLogEN = cc_KnowledgeStuTeachLogDA.GetObjByKeyLst(lngQuestionId,strIdStudentInfo);
return objcc_KnowledgeStuTeachLogEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clscc_KnowledgeStuTeachLogEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clscc_KnowledgeStuTeachLogEN objcc_KnowledgeStuTeachLogEN = cc_KnowledgeStuTeachLogDA.GetFirstObj(strWhereCond);
 return objcc_KnowledgeStuTeachLogEN;
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
public static clscc_KnowledgeStuTeachLogEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clscc_KnowledgeStuTeachLogEN objcc_KnowledgeStuTeachLogEN = cc_KnowledgeStuTeachLogDA.GetObjByDataRow(objRow);
 return objcc_KnowledgeStuTeachLogEN;
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
public static clscc_KnowledgeStuTeachLogEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clscc_KnowledgeStuTeachLogEN objcc_KnowledgeStuTeachLogEN = cc_KnowledgeStuTeachLogDA.GetObjByDataRow(objRow);
 return objcc_KnowledgeStuTeachLogEN;
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
 /// <param name = "lngQuestionId">表关键字</param>
 /// <param name = "strIdStudentInfo">表关键字</param>
 /// <param name = "lstcc_KnowledgeStuTeachLogObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clscc_KnowledgeStuTeachLogEN GetObjByKeyLstFromList(long lngQuestionId,string strIdStudentInfo, List<clscc_KnowledgeStuTeachLogEN> lstcc_KnowledgeStuTeachLogObjLst)
{
foreach (clscc_KnowledgeStuTeachLogEN objcc_KnowledgeStuTeachLogEN in lstcc_KnowledgeStuTeachLogObjLst)
{
if (objcc_KnowledgeStuTeachLogEN.QuestionId == lngQuestionId 
 && objcc_KnowledgeStuTeachLogEN.IdStudentInfo == strIdStudentInfo 
)
{
return objcc_KnowledgeStuTeachLogEN;
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
 long lngQuestionId;
 try
 {
 lngQuestionId = new clscc_KnowledgeStuTeachLogDA().GetFirstID(strWhereCond);
 return lngQuestionId;
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
 arrList = cc_KnowledgeStuTeachLogDA.GetID(strWhereCond);
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
bool bolIsExist = cc_KnowledgeStuTeachLogDA.IsExistCondRec(strWhereCond);
return bolIsExist;
}

 /// <summary>
 /// 判断当前表中是否存在给定关键字值的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExist)
 /// </summary>
 /// <param name = "lngQuestionId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public static bool IsExist(long lngQuestionId,string strIdStudentInfo)
{
//检测记录是否存在
bool bolIsExist = cc_KnowledgeStuTeachLogDA.IsExist(lngQuestionId,strIdStudentInfo);
return bolIsExist;
}

/// <summary>
/// 设置修改时间
/// </summary>
/// <param name = "lngQuestionId">题目Id</param>
/// <param name = "strIdStudentInfo">学生流水号</param>
/// <param name = "strOpUser">修改用户</param>
/// <returns>是否成功？</returns>
public static bool SetUpdDate(long lngQuestionId , string strIdStudentInfo, string strOpUser)
{
clscc_KnowledgeStuTeachLogEN objcc_KnowledgeStuTeachLogEN = clscc_KnowledgeStuTeachLogBL.GetObjByKeyLst(lngQuestionId,strIdStudentInfo);
objcc_KnowledgeStuTeachLogEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
objcc_KnowledgeStuTeachLogEN.UpdUserId = strOpUser;
return clscc_KnowledgeStuTeachLogBL.UpdateBySql2(objcc_KnowledgeStuTeachLogEN);
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
 bolIsExist = clscc_KnowledgeStuTeachLogDA.IsExistTable();
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
 bolIsExist = cc_KnowledgeStuTeachLogDA.IsExistTable(strTabName);
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
 /// <param name = "objcc_KnowledgeStuTeachLogEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecordBySql2(clscc_KnowledgeStuTeachLogEN objcc_KnowledgeStuTeachLogEN, bool bolIsNeedCheckUniqueness=true)
{
try
{
bool bolResult = cc_KnowledgeStuTeachLogDA.AddNewRecordBySQL2(objcc_KnowledgeStuTeachLogEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clscc_KnowledgeStuTeachLogBL.ReFreshCache();

if (clscc_KnowledgeStuTeachLogBL.relatedActions != null)
{
clscc_KnowledgeStuTeachLogBL.relatedActions.UpdRelaTabDate(objcc_KnowledgeStuTeachLogEN.QuestionId,objcc_KnowledgeStuTeachLogEN.IdStudentInfo, objcc_KnowledgeStuTeachLogEN.UpdUserId);
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
 /// <param name = "objcc_KnowledgeStuTeachLogEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordBySql2WithReturnKey(clscc_KnowledgeStuTeachLogEN objcc_KnowledgeStuTeachLogEN, bool bolIsNeedCheckUniqueness=true)
{
try
{
string strKey = cc_KnowledgeStuTeachLogDA.AddNewRecordBySQL2WithReturnKey(objcc_KnowledgeStuTeachLogEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clscc_KnowledgeStuTeachLogBL.ReFreshCache();

if (clscc_KnowledgeStuTeachLogBL.relatedActions != null)
{
clscc_KnowledgeStuTeachLogBL.relatedActions.UpdRelaTabDate(objcc_KnowledgeStuTeachLogEN.QuestionId,objcc_KnowledgeStuTeachLogEN.IdStudentInfo, objcc_KnowledgeStuTeachLogEN.UpdUserId);
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
 /// <param name = "objcc_KnowledgeStuTeachLogEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(clscc_KnowledgeStuTeachLogEN objcc_KnowledgeStuTeachLogEN)
{
try
{
bool bolResult = cc_KnowledgeStuTeachLogDA.Update(objcc_KnowledgeStuTeachLogEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clscc_KnowledgeStuTeachLogBL.ReFreshCache();

if (clscc_KnowledgeStuTeachLogBL.relatedActions != null)
{
clscc_KnowledgeStuTeachLogBL.relatedActions.UpdRelaTabDate(objcc_KnowledgeStuTeachLogEN.QuestionId,objcc_KnowledgeStuTeachLogEN.IdStudentInfo, objcc_KnowledgeStuTeachLogEN.UpdUserId);
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
 /// <param name = "objcc_KnowledgeStuTeachLogEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateBySql2(clscc_KnowledgeStuTeachLogEN objcc_KnowledgeStuTeachLogEN)
{
 if (objcc_KnowledgeStuTeachLogEN.QuestionId == 0)
 {
var strMsg = string.Format("(errid:Busi000065)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = cc_KnowledgeStuTeachLogDA.UpdateBySql2(objcc_KnowledgeStuTeachLogEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clscc_KnowledgeStuTeachLogBL.ReFreshCache();

if (clscc_KnowledgeStuTeachLogBL.relatedActions != null)
{
clscc_KnowledgeStuTeachLogBL.relatedActions.UpdRelaTabDate(objcc_KnowledgeStuTeachLogEN.QuestionId,objcc_KnowledgeStuTeachLogEN.IdStudentInfo, objcc_KnowledgeStuTeachLogEN.UpdUserId);
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
 /// <param name = "lngQuestionId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int DelRecord(long lngQuestionId,string strIdStudentInfo)
{
try
{
 clscc_KnowledgeStuTeachLogEN objcc_KnowledgeStuTeachLogEN = clscc_KnowledgeStuTeachLogBL.GetObjByKeyLst(lngQuestionId,strIdStudentInfo);

if (clscc_KnowledgeStuTeachLogBL.relatedActions != null)
{
clscc_KnowledgeStuTeachLogBL.relatedActions.UpdRelaTabDate(objcc_KnowledgeStuTeachLogEN.QuestionId,objcc_KnowledgeStuTeachLogEN.IdStudentInfo, objcc_KnowledgeStuTeachLogEN.UpdUserId);
}
if (objcc_KnowledgeStuTeachLogEN != null)
{
int intRecNum = cc_KnowledgeStuTeachLogDA.DelRecord(lngQuestionId,strIdStudentInfo);
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
/// <param name="lngQuestionId">表关键字</param>
/// <returns></returns>
public static bool DelRecordEx(long lngQuestionId,string strIdStudentInfo )
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clscc_KnowledgeStuTeachLogDA.GetSpecSQLObj();
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
//删除与表:[cc_KnowledgeStuTeachLog]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//concc_KnowledgeStuTeachLog.QuestionId,
//lngQuestionId);
//        clscc_KnowledgeStuTeachLogBL.Delcc_KnowledgeStuTeachLogsByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clscc_KnowledgeStuTeachLogBL.DelRecord(lngQuestionId,strIdStudentInfo, objConnection, objSqlTransaction);
objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clscc_KnowledgeStuTeachLogBLEx", "DelRecordEx", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("扩展删除记录出错:{0}!keyId = {1}.({2})",
objException.Message,
lngQuestionId, clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "lngQuestionId">给定的关键字值</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回删除是否成功?</returns>
public static bool DelRecord(long lngQuestionId,string strIdStudentInfo, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
if (clscc_KnowledgeStuTeachLogBL.relatedActions != null)
{
clscc_KnowledgeStuTeachLogBL.relatedActions.UpdRelaTabDate(lngQuestionId,strIdStudentInfo, "UpdRelaTabDate");
}
bool bolResult = cc_KnowledgeStuTeachLogDA.DelRecord(lngQuestionId,strIdStudentInfo,objSqlConnection,objSqlTransaction);
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
 /// <param name = "arrQuestionIdLst">给定的关键字值列表</param>
 /// <returns>返回删除的记录数</returns>
public static int DelRecKeyLsts(List<string> arrKeyLsts)
{
if (arrKeyLsts.Count == 0) return 0;
try
{
string[] sstrKey;
long lngQuestionId;
string strIdStudentInfo;
if (clscc_KnowledgeStuTeachLogBL.relatedActions != null)
{
foreach (var strKeyLst in arrKeyLsts)
{
sstrKey = strKeyLst.Split('|');
lngQuestionId = long.Parse(sstrKey[0]);
strIdStudentInfo = sstrKey[1];
clscc_KnowledgeStuTeachLogBL.relatedActions.UpdRelaTabDate(lngQuestionId,strIdStudentInfo, "UpdRelaTabDate");
}
}
sstrKey = arrKeyLsts[0].Split('|');
lngQuestionId = long.Parse(sstrKey[0]);
strIdStudentInfo = sstrKey[1];
int intDelRecNum = cc_KnowledgeStuTeachLogDA.DelRecKeyLsts(arrKeyLsts);
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
public static int Delcc_KnowledgeStuTeachLogsByCond(string strWhereCond)
{
try
{
int intRecNum = cc_KnowledgeStuTeachLogDA.Delcc_KnowledgeStuTeachLog(strWhereCond);
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
/// 这里仅仅是演示函数,使用时请复制到扩展类:[cc_KnowledgeStuTeachLog]中改名为:[DelRecord4MultiTabEx]使用
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DelRecord4MultiTab)
/// </summary>
/// <param name="lngQuestionId">表关键字</param>
/// <returns></returns>
public static bool DelRecord4MultiTab(long lngQuestionId,string strIdStudentInfo)
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clscc_KnowledgeStuTeachLogDA.GetSpecSQLObj();
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
//删除与表:[cc_KnowledgeStuTeachLog]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conStudent.id_College,
//strid_College);
//        clsStudentBL.DelStudentsByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clscc_KnowledgeStuTeachLogBL.DelRecord(lngQuestionId,strIdStudentInfo, objConnection, objSqlTransaction);
                objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clscc_KnowledgeStuTeachLogBL", "DelRecord4MultiTab", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("删除多表记录出错:{0}!keyId = {1}.({2})",
objException.Message,
lngQuestionId, clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "objcc_KnowledgeStuTeachLogENS">源对象</param>
 /// <param name = "objcc_KnowledgeStuTeachLogENT">目标对象</param>
 public static void CopyTo(clscc_KnowledgeStuTeachLogEN objcc_KnowledgeStuTeachLogENS, clscc_KnowledgeStuTeachLogEN objcc_KnowledgeStuTeachLogENT)
{
try
{
objcc_KnowledgeStuTeachLogENT.QuestionId = objcc_KnowledgeStuTeachLogENS.QuestionId; //题目Id
objcc_KnowledgeStuTeachLogENT.IdStudentInfo = objcc_KnowledgeStuTeachLogENS.IdStudentInfo; //学生流水号
objcc_KnowledgeStuTeachLogENT.TeachingLog = objcc_KnowledgeStuTeachLogENS.TeachingLog; //教学日志
objcc_KnowledgeStuTeachLogENT.CourseId = objcc_KnowledgeStuTeachLogENS.CourseId; //课程Id
objcc_KnowledgeStuTeachLogENT.UpdDate = objcc_KnowledgeStuTeachLogENS.UpdDate; //修改日期
objcc_KnowledgeStuTeachLogENT.UpdUserId = objcc_KnowledgeStuTeachLogENS.UpdUserId; //修改用户Id
objcc_KnowledgeStuTeachLogENT.Memo = objcc_KnowledgeStuTeachLogENS.Memo; //备注
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
 /// <param name = "objcc_KnowledgeStuTeachLogEN">源简化对象</param>
 public static void SetUpdFlag(clscc_KnowledgeStuTeachLogEN objcc_KnowledgeStuTeachLogEN)
{
try
{
objcc_KnowledgeStuTeachLogEN.ClearUpdateState();
   string strsfUpdFldSetStr = objcc_KnowledgeStuTeachLogEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(concc_KnowledgeStuTeachLog.QuestionId, new clsStrCompareIgnoreCase())  ==  true)
{
objcc_KnowledgeStuTeachLogEN.QuestionId = objcc_KnowledgeStuTeachLogEN.QuestionId; //题目Id
}
if (arrFldSet.Contains(concc_KnowledgeStuTeachLog.IdStudentInfo, new clsStrCompareIgnoreCase())  ==  true)
{
objcc_KnowledgeStuTeachLogEN.IdStudentInfo = objcc_KnowledgeStuTeachLogEN.IdStudentInfo; //学生流水号
}
if (arrFldSet.Contains(concc_KnowledgeStuTeachLog.TeachingLog, new clsStrCompareIgnoreCase())  ==  true)
{
objcc_KnowledgeStuTeachLogEN.TeachingLog = objcc_KnowledgeStuTeachLogEN.TeachingLog; //教学日志
}
if (arrFldSet.Contains(concc_KnowledgeStuTeachLog.CourseId, new clsStrCompareIgnoreCase())  ==  true)
{
objcc_KnowledgeStuTeachLogEN.CourseId = objcc_KnowledgeStuTeachLogEN.CourseId == "[null]" ? null :  objcc_KnowledgeStuTeachLogEN.CourseId; //课程Id
}
if (arrFldSet.Contains(concc_KnowledgeStuTeachLog.UpdDate, new clsStrCompareIgnoreCase())  ==  true)
{
objcc_KnowledgeStuTeachLogEN.UpdDate = objcc_KnowledgeStuTeachLogEN.UpdDate; //修改日期
}
if (arrFldSet.Contains(concc_KnowledgeStuTeachLog.UpdUserId, new clsStrCompareIgnoreCase())  ==  true)
{
objcc_KnowledgeStuTeachLogEN.UpdUserId = objcc_KnowledgeStuTeachLogEN.UpdUserId == "[null]" ? null :  objcc_KnowledgeStuTeachLogEN.UpdUserId; //修改用户Id
}
if (arrFldSet.Contains(concc_KnowledgeStuTeachLog.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objcc_KnowledgeStuTeachLogEN.Memo = objcc_KnowledgeStuTeachLogEN.Memo == "[null]" ? null :  objcc_KnowledgeStuTeachLogEN.Memo; //备注
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
 /// <param name = "objcc_KnowledgeStuTeachLogEN">源简化对象</param>
 public static void AccessFldValueNull(clscc_KnowledgeStuTeachLogEN objcc_KnowledgeStuTeachLogEN)
{
try
{
if (objcc_KnowledgeStuTeachLogEN.CourseId == "[null]") objcc_KnowledgeStuTeachLogEN.CourseId = null; //课程Id
if (objcc_KnowledgeStuTeachLogEN.UpdUserId == "[null]") objcc_KnowledgeStuTeachLogEN.UpdUserId = null; //修改用户Id
if (objcc_KnowledgeStuTeachLogEN.Memo == "[null]") objcc_KnowledgeStuTeachLogEN.Memo = null; //备注
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
public static void CheckPropertyNew(clscc_KnowledgeStuTeachLogEN objcc_KnowledgeStuTeachLogEN)
{
 cc_KnowledgeStuTeachLogDA.CheckPropertyNew(objcc_KnowledgeStuTeachLogEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(clscc_KnowledgeStuTeachLogEN objcc_KnowledgeStuTeachLogEN)
{
 cc_KnowledgeStuTeachLogDA.CheckProperty4Condition(objcc_KnowledgeStuTeachLogEN);
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
if (clscc_KnowledgeStuTeachLogBL.objCommFun4BL == null)
{
strMsg = string.Format("类clscc_KnowledgeStuTeachLogBL没有刷新缓存机制(clscc_KnowledgeStuTeachLogBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by QuestionId");
//if (arrcc_KnowledgeStuTeachLogObjLstCache == null)
//{
//arrcc_KnowledgeStuTeachLogObjLstCache = cc_KnowledgeStuTeachLogDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "lngQuestionId">表关键字</param>
 /// <param name = "strIdStudentInfo">表关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clscc_KnowledgeStuTeachLogEN GetObjByKeyLstCache(long lngQuestionId,string strIdStudentInfo)
{
//获取缓存中的对象列表
string strKey = string.Format("{0}", clscc_KnowledgeStuTeachLogEN._CurrTabName);
List<clscc_KnowledgeStuTeachLogEN> arrcc_KnowledgeStuTeachLogObjLstCache = GetObjLstCache();
IEnumerable <clscc_KnowledgeStuTeachLogEN> arrcc_KnowledgeStuTeachLogObjLst_Sel =
arrcc_KnowledgeStuTeachLogObjLstCache
.Where(x=> x.QuestionId == lngQuestionId 
 && x.IdStudentInfo == strIdStudentInfo 
);
if (arrcc_KnowledgeStuTeachLogObjLst_Sel.Count() == 0)
{
   clscc_KnowledgeStuTeachLogEN obj = clscc_KnowledgeStuTeachLogBL.GetObjByKeyLst(lngQuestionId,strIdStudentInfo);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
 }
return null;
}
return arrcc_KnowledgeStuTeachLogObjLst_Sel.First();
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clscc_KnowledgeStuTeachLogEN> GetAllcc_KnowledgeStuTeachLogObjLstCache()
{
//获取缓存中的对象列表
List<clscc_KnowledgeStuTeachLogEN> arrcc_KnowledgeStuTeachLogObjLstCache = GetObjLstCache(); 
return arrcc_KnowledgeStuTeachLogObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clscc_KnowledgeStuTeachLogEN> GetObjLstCache()
{
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}", clscc_KnowledgeStuTeachLogEN._CurrTabName);
List<clscc_KnowledgeStuTeachLogEN> arrcc_KnowledgeStuTeachLogObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrcc_KnowledgeStuTeachLogObjLstCache;
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
string strKey = string.Format("{0}", clscc_KnowledgeStuTeachLogEN._CurrTabName);
CacheHelper.Remove(strKey);
clscc_KnowledgeStuTeachLogEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
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
if (clscc_KnowledgeStuTeachLogEN._RefreshTimeLst.Count == 0) return "";
return clscc_KnowledgeStuTeachLogEN._RefreshTimeLst[clscc_KnowledgeStuTeachLogEN._RefreshTimeLst.Count - 1];
}

 /// <summary>
 /// 刷新缓存.把当前表的缓存以及该表相关视图的缓存清空.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ReFreshCache)
 /// </summary>
public static void ReFreshCache()
{
if (clscc_KnowledgeStuTeachLogBL.objCommFun4BL != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}", clscc_KnowledgeStuTeachLogEN._CurrTabName);
CacheHelper.Remove(strKey);
clscc_KnowledgeStuTeachLogEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
clscc_KnowledgeStuTeachLogBL.objCommFun4BL.ReFreshCache();
}
}


 #endregion 缓存操作


 #region 检查唯一性


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
public static string Func(string strInFldName, string strOutFldName, long lngQuestionId,string strIdStudentInfo)
{
if (strInFldName != concc_KnowledgeStuTeachLog.QuestionId)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (concc_KnowledgeStuTeachLog.AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", concc_KnowledgeStuTeachLog.AttributeName));
throw new Exception(strMsg);
}
var objcc_KnowledgeStuTeachLog = clscc_KnowledgeStuTeachLogBL.GetObjByKeyLstCache(lngQuestionId,strIdStudentInfo);
if (objcc_KnowledgeStuTeachLog == null) return "";
return objcc_KnowledgeStuTeachLog[strOutFldName].ToString();
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
int intRecCount = clscc_KnowledgeStuTeachLogDA.GetRecCount(strTabName);
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
int intRecCount = clscc_KnowledgeStuTeachLogDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clscc_KnowledgeStuTeachLogDA.GetRecCount();
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
int intRecCount = clscc_KnowledgeStuTeachLogDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objcc_KnowledgeStuTeachLogCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clscc_KnowledgeStuTeachLogEN objcc_KnowledgeStuTeachLogCond)
{
List<clscc_KnowledgeStuTeachLogEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clscc_KnowledgeStuTeachLogEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in concc_KnowledgeStuTeachLog.AttributeName)
{
if (objcc_KnowledgeStuTeachLogCond.IsUpdated(strFldName) == false) continue;
if (objcc_KnowledgeStuTeachLogCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objcc_KnowledgeStuTeachLogCond[strFldName].ToString());
}
else
{
if (objcc_KnowledgeStuTeachLogCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objcc_KnowledgeStuTeachLogCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objcc_KnowledgeStuTeachLogCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objcc_KnowledgeStuTeachLogCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objcc_KnowledgeStuTeachLogCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objcc_KnowledgeStuTeachLogCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objcc_KnowledgeStuTeachLogCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objcc_KnowledgeStuTeachLogCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objcc_KnowledgeStuTeachLogCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objcc_KnowledgeStuTeachLogCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objcc_KnowledgeStuTeachLogCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objcc_KnowledgeStuTeachLogCond[strFldName]));
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
 List<string> arrList = clscc_KnowledgeStuTeachLogDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = cc_KnowledgeStuTeachLogDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = cc_KnowledgeStuTeachLogDA.GetFldValueNoDistinct(strFldName, strWhereCond);
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
int intRecCount = cc_KnowledgeStuTeachLogDA.SetFldValue(strFldName, strValue, strWhereCond);
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
int intRecCount = clscc_KnowledgeStuTeachLogDA.SetFldValue(clscc_KnowledgeStuTeachLogEN._CurrTabName, strFldName, fltValue, strWhereCond);
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
int intRecCount = cc_KnowledgeStuTeachLogDA.SetFldValue( strFldName, intValue, strWhereCond);
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
int intRecCount = clscc_KnowledgeStuTeachLogDA.SetFldValue(strTabName, strFldName, strValue, strWhereCond);
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
int intRecCount = clscc_KnowledgeStuTeachLogDA.SetFldValue(strTabName, strFldName, intValue, strWhereCond);
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
int intRecCount = clscc_KnowledgeStuTeachLogDA.SetFldValue(strTabName, strFldName, fltValue, strWhereCond);
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
  strCreateTabCode.Append("CREATE table [dbo].[cc_KnowledgeStuTeachLog] "); 
 strCreateTabCode.Append(" ( "); 
 // /**题目Id*/ 
 strCreateTabCode.Append(" QuestionId bigint primary key, "); 
 // /**学生流水号*/ 
 strCreateTabCode.Append(" IdStudentInfo char(8) primary key, "); 
 // /**教学日志*/ 
 strCreateTabCode.Append(" TeachingLog varchar(5000) not Null, "); 
 // /**课程Id*/ 
 strCreateTabCode.Append(" CourseId char(8) Null, "); 
 // /**修改日期*/ 
 strCreateTabCode.Append(" UpdDate varchar(20) not Null, "); 
 // /**修改用户Id*/ 
 strCreateTabCode.Append(" UpdUserId varchar(20) Null, "); 
 // /**备注*/ 
 strCreateTabCode.Append(" Memo varchar(1000) Null, "); 
 // /**课程名称*/ 
 strCreateTabCode.Append(" CourseName varchar(100) Null, "); 
 // /**学号*/ 
 strCreateTabCode.Append(" StuId varchar(20) Null, "); 
 // /**姓名*/ 
 strCreateTabCode.Append(" StuName varchar(50) Null, "); 
 // /**题目名称*/ 
 strCreateTabCode.Append(" QuestionName varchar(500) Null ");
 strCreateTabCode.Append(") "); 
  strCreateTabCode.Append("ON [PRIMARY] ");
  return strCreateTabCode.ToString();
}



 #endregion 表操作
}
 /// <summary>
 /// 学生知识点教学日志(cc_KnowledgeStuTeachLog)
 /// 数据源类型:表
 /// (AutoGCLib.CommFun4BL4CSharp:GeneCode_This)
 /// </summary>
public class  clsCommFun4BL4cc_KnowledgeStuTeachLog : clsCommFun4BL
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
clscc_KnowledgeStuTeachLogBL.ReFreshThisCache();
}
}

}