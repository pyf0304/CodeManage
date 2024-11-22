
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clscc_WorkStuRelation4CorrectBL
 表名:cc_WorkStuRelation4Correct(01120182)
 * 版本:2024.11.13.1(服务器:WIN-SRV103-116)
 日期:2024/11/13 06:00:47
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
public static class  clscc_WorkStuRelation4CorrectBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public static clscc_WorkStuRelation4CorrectEN GetObj(this K_mId_cc_WorkStuRelation4Correct myKey)
{
clscc_WorkStuRelation4CorrectEN objcc_WorkStuRelation4CorrectEN = clscc_WorkStuRelation4CorrectBL.cc_WorkStuRelation4CorrectDA.GetObjBymId(myKey.Value);
return objcc_WorkStuRelation4CorrectEN;
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_AddNewRecord)
 /// </summary>
 /// <param name = "objcc_WorkStuRelation4CorrectEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clscc_WorkStuRelation4CorrectEN objcc_WorkStuRelation4CorrectEN, bool bolIsNeedCheckUniqueness = true)
{
if (bolIsNeedCheckUniqueness == true && CheckUniqueness(objcc_WorkStuRelation4CorrectEN) == false)
{
var strMsg = string.Format("记录已经存在!题目Id = [{0}],学生流水号 = [{1}]的数据已经存在!(in clscc_WorkStuRelation4CorrectBL.AddNewRecord)", objcc_WorkStuRelation4CorrectEN.QuestionId,objcc_WorkStuRelation4CorrectEN.IdStudentInfo);
throw new Exception(strMsg);
}
try
{
bool bolResult = clscc_WorkStuRelation4CorrectBL.cc_WorkStuRelation4CorrectDA.AddNewRecordBySQL2(objcc_WorkStuRelation4CorrectEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clscc_WorkStuRelation4CorrectBL.ReFreshCache(objcc_WorkStuRelation4CorrectEN.CourseId);

if (clscc_WorkStuRelation4CorrectBL.relatedActions != null)
{
clscc_WorkStuRelation4CorrectBL.relatedActions.UpdRelaTabDate(objcc_WorkStuRelation4CorrectEN.mId, objcc_WorkStuRelation4CorrectEN.UpdUser);
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
public static bool AddRecordEx(this clscc_WorkStuRelation4CorrectEN objcc_WorkStuRelation4CorrectEN, bool bolIsNeedCheckUniqueness = true)
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
objcc_WorkStuRelation4CorrectEN.CheckPropertyNew();
 ///5.2、检查唯一性
if (bolIsNeedCheckUniqueness == true && objcc_WorkStuRelation4CorrectEN.CheckUniqueness() == false)
{
strMsg = string.Format("(题目Id(QuestionId)=[{0}],学生流水号(IdStudentInfo)=[{1}])已经存在,不能重复!", objcc_WorkStuRelation4CorrectEN.QuestionId, objcc_WorkStuRelation4CorrectEN.IdStudentInfo);
throw new Exception(strMsg);
}
//6、把数据实体层的数据存贮到数据库中
objcc_WorkStuRelation4CorrectEN.AddNewRecord();
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
 /// <param name = "objcc_WorkStuRelation4CorrectEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordWithReturnKey(this clscc_WorkStuRelation4CorrectEN objcc_WorkStuRelation4CorrectEN, bool bolIsNeedCheckUniqueness = true)
{
if (bolIsNeedCheckUniqueness == true && CheckUniqueness(objcc_WorkStuRelation4CorrectEN) == false)
{
var strMsg = string.Format("记录已经存在!题目Id = [{0}],学生流水号 = [{1}]的数据已经存在!(in clscc_WorkStuRelation4CorrectBL.AddNewRecordWithReturnKey)", objcc_WorkStuRelation4CorrectEN.QuestionId,objcc_WorkStuRelation4CorrectEN.IdStudentInfo);
throw new Exception(strMsg);
}
try
{
string strKey = clscc_WorkStuRelation4CorrectBL.cc_WorkStuRelation4CorrectDA.AddNewRecordBySQL2WithReturnKey(objcc_WorkStuRelation4CorrectEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clscc_WorkStuRelation4CorrectBL.ReFreshCache(objcc_WorkStuRelation4CorrectEN.CourseId);

if (clscc_WorkStuRelation4CorrectBL.relatedActions != null)
{
clscc_WorkStuRelation4CorrectBL.relatedActions.UpdRelaTabDate(objcc_WorkStuRelation4CorrectEN.mId, objcc_WorkStuRelation4CorrectEN.UpdUser);
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
 /// <param name = "objcc_WorkStuRelation4CorrectEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clscc_WorkStuRelation4CorrectEN SetmId(this clscc_WorkStuRelation4CorrectEN objcc_WorkStuRelation4CorrectEN, long lngmId, string strComparisonOp="")
	{
objcc_WorkStuRelation4CorrectEN.mId = lngmId; //mId
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_WorkStuRelation4CorrectEN.dicFldComparisonOp.ContainsKey(concc_WorkStuRelation4Correct.mId) == false)
{
objcc_WorkStuRelation4CorrectEN.dicFldComparisonOp.Add(concc_WorkStuRelation4Correct.mId, strComparisonOp);
}
else
{
objcc_WorkStuRelation4CorrectEN.dicFldComparisonOp[concc_WorkStuRelation4Correct.mId] = strComparisonOp;
}
}
return objcc_WorkStuRelation4CorrectEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_WorkStuRelation4CorrectEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clscc_WorkStuRelation4CorrectEN SetCourseId(this clscc_WorkStuRelation4CorrectEN objcc_WorkStuRelation4CorrectEN, string strCourseId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strCourseId, concc_WorkStuRelation4Correct.CourseId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCourseId, 8, concc_WorkStuRelation4Correct.CourseId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strCourseId, 8, concc_WorkStuRelation4Correct.CourseId);
}
objcc_WorkStuRelation4CorrectEN.CourseId = strCourseId; //课程Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_WorkStuRelation4CorrectEN.dicFldComparisonOp.ContainsKey(concc_WorkStuRelation4Correct.CourseId) == false)
{
objcc_WorkStuRelation4CorrectEN.dicFldComparisonOp.Add(concc_WorkStuRelation4Correct.CourseId, strComparisonOp);
}
else
{
objcc_WorkStuRelation4CorrectEN.dicFldComparisonOp[concc_WorkStuRelation4Correct.CourseId] = strComparisonOp;
}
}
return objcc_WorkStuRelation4CorrectEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_WorkStuRelation4CorrectEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clscc_WorkStuRelation4CorrectEN SetIdStudentInfo(this clscc_WorkStuRelation4CorrectEN objcc_WorkStuRelation4CorrectEN, string strIdStudentInfo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strIdStudentInfo, concc_WorkStuRelation4Correct.IdStudentInfo);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdStudentInfo, 8, concc_WorkStuRelation4Correct.IdStudentInfo);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdStudentInfo, 8, concc_WorkStuRelation4Correct.IdStudentInfo);
}
objcc_WorkStuRelation4CorrectEN.IdStudentInfo = strIdStudentInfo; //学生流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_WorkStuRelation4CorrectEN.dicFldComparisonOp.ContainsKey(concc_WorkStuRelation4Correct.IdStudentInfo) == false)
{
objcc_WorkStuRelation4CorrectEN.dicFldComparisonOp.Add(concc_WorkStuRelation4Correct.IdStudentInfo, strComparisonOp);
}
else
{
objcc_WorkStuRelation4CorrectEN.dicFldComparisonOp[concc_WorkStuRelation4Correct.IdStudentInfo] = strComparisonOp;
}
}
return objcc_WorkStuRelation4CorrectEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_WorkStuRelation4CorrectEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clscc_WorkStuRelation4CorrectEN SetQuestionId(this clscc_WorkStuRelation4CorrectEN objcc_WorkStuRelation4CorrectEN, long lngQuestionId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(lngQuestionId, concc_WorkStuRelation4Correct.QuestionId);
objcc_WorkStuRelation4CorrectEN.QuestionId = lngQuestionId; //题目Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_WorkStuRelation4CorrectEN.dicFldComparisonOp.ContainsKey(concc_WorkStuRelation4Correct.QuestionId) == false)
{
objcc_WorkStuRelation4CorrectEN.dicFldComparisonOp.Add(concc_WorkStuRelation4Correct.QuestionId, strComparisonOp);
}
else
{
objcc_WorkStuRelation4CorrectEN.dicFldComparisonOp[concc_WorkStuRelation4Correct.QuestionId] = strComparisonOp;
}
}
return objcc_WorkStuRelation4CorrectEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_WorkStuRelation4CorrectEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clscc_WorkStuRelation4CorrectEN SetRightId(this clscc_WorkStuRelation4CorrectEN objcc_WorkStuRelation4CorrectEN, string strRightId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strRightId, concc_WorkStuRelation4Correct.RightId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strRightId, 8, concc_WorkStuRelation4Correct.RightId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strRightId, 8, concc_WorkStuRelation4Correct.RightId);
}
objcc_WorkStuRelation4CorrectEN.RightId = strRightId; //权限编号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_WorkStuRelation4CorrectEN.dicFldComparisonOp.ContainsKey(concc_WorkStuRelation4Correct.RightId) == false)
{
objcc_WorkStuRelation4CorrectEN.dicFldComparisonOp.Add(concc_WorkStuRelation4Correct.RightId, strComparisonOp);
}
else
{
objcc_WorkStuRelation4CorrectEN.dicFldComparisonOp[concc_WorkStuRelation4Correct.RightId] = strComparisonOp;
}
}
return objcc_WorkStuRelation4CorrectEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_WorkStuRelation4CorrectEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clscc_WorkStuRelation4CorrectEN SetAuthorizer(this clscc_WorkStuRelation4CorrectEN objcc_WorkStuRelation4CorrectEN, string strAuthorizer, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strAuthorizer, concc_WorkStuRelation4Correct.Authorizer);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strAuthorizer, 18, concc_WorkStuRelation4Correct.Authorizer);
}
objcc_WorkStuRelation4CorrectEN.Authorizer = strAuthorizer; //授权人
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_WorkStuRelation4CorrectEN.dicFldComparisonOp.ContainsKey(concc_WorkStuRelation4Correct.Authorizer) == false)
{
objcc_WorkStuRelation4CorrectEN.dicFldComparisonOp.Add(concc_WorkStuRelation4Correct.Authorizer, strComparisonOp);
}
else
{
objcc_WorkStuRelation4CorrectEN.dicFldComparisonOp[concc_WorkStuRelation4Correct.Authorizer] = strComparisonOp;
}
}
return objcc_WorkStuRelation4CorrectEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_WorkStuRelation4CorrectEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clscc_WorkStuRelation4CorrectEN SetUpdDate(this clscc_WorkStuRelation4CorrectEN objcc_WorkStuRelation4CorrectEN, string strUpdDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdDate, 20, concc_WorkStuRelation4Correct.UpdDate);
}
objcc_WorkStuRelation4CorrectEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_WorkStuRelation4CorrectEN.dicFldComparisonOp.ContainsKey(concc_WorkStuRelation4Correct.UpdDate) == false)
{
objcc_WorkStuRelation4CorrectEN.dicFldComparisonOp.Add(concc_WorkStuRelation4Correct.UpdDate, strComparisonOp);
}
else
{
objcc_WorkStuRelation4CorrectEN.dicFldComparisonOp[concc_WorkStuRelation4Correct.UpdDate] = strComparisonOp;
}
}
return objcc_WorkStuRelation4CorrectEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_WorkStuRelation4CorrectEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clscc_WorkStuRelation4CorrectEN SetUpdUser(this clscc_WorkStuRelation4CorrectEN objcc_WorkStuRelation4CorrectEN, string strUpdUser, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdUser, 20, concc_WorkStuRelation4Correct.UpdUser);
}
objcc_WorkStuRelation4CorrectEN.UpdUser = strUpdUser; //修改人
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_WorkStuRelation4CorrectEN.dicFldComparisonOp.ContainsKey(concc_WorkStuRelation4Correct.UpdUser) == false)
{
objcc_WorkStuRelation4CorrectEN.dicFldComparisonOp.Add(concc_WorkStuRelation4Correct.UpdUser, strComparisonOp);
}
else
{
objcc_WorkStuRelation4CorrectEN.dicFldComparisonOp[concc_WorkStuRelation4Correct.UpdUser] = strComparisonOp;
}
}
return objcc_WorkStuRelation4CorrectEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_WorkStuRelation4CorrectEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clscc_WorkStuRelation4CorrectEN SetMemo(this clscc_WorkStuRelation4CorrectEN objcc_WorkStuRelation4CorrectEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, concc_WorkStuRelation4Correct.Memo);
}
objcc_WorkStuRelation4CorrectEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_WorkStuRelation4CorrectEN.dicFldComparisonOp.ContainsKey(concc_WorkStuRelation4Correct.Memo) == false)
{
objcc_WorkStuRelation4CorrectEN.dicFldComparisonOp.Add(concc_WorkStuRelation4Correct.Memo, strComparisonOp);
}
else
{
objcc_WorkStuRelation4CorrectEN.dicFldComparisonOp[concc_WorkStuRelation4Correct.Memo] = strComparisonOp;
}
}
return objcc_WorkStuRelation4CorrectEN;
	}

 /// <summary>
 /// 修改记录存盘到数据表中
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_UpdateRecordEx)
 /// </summary>
 /// <param name = "objcc_WorkStuRelation4CorrectEN">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool UpdateRecordEx(this clscc_WorkStuRelation4CorrectEN objcc_WorkStuRelation4CorrectEN)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
try
{
//1、检查传进去的对象属性是否合法
objcc_WorkStuRelation4CorrectEN.CheckPropertyNew();
clscc_WorkStuRelation4CorrectEN objcc_WorkStuRelation4CorrectCond = new clscc_WorkStuRelation4CorrectEN();
string strCondition = objcc_WorkStuRelation4CorrectCond
.SetmId(objcc_WorkStuRelation4CorrectEN.mId, "<>")
.SetQuestionId(objcc_WorkStuRelation4CorrectEN.QuestionId, "=")
.SetIdStudentInfo(objcc_WorkStuRelation4CorrectEN.IdStudentInfo, "=")
.GetCombineCondition();
objcc_WorkStuRelation4CorrectEN._IsCheckProperty = true;
bool bolIsExist = clscc_WorkStuRelation4CorrectBL.IsExistRecord(strCondition);
if (bolIsExist)
{
strMsg = "(QuestionID_id_StudentInfo)不能重复!";
throw new Exception(strMsg);
}
//4、把数据实体层的数据存贮到数据库中
objcc_WorkStuRelation4CorrectEN.Update();
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
 /// <param name = "objcc_WorkStuRelation4Correct">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool EditRecordEx(this clscc_WorkStuRelation4CorrectEN objcc_WorkStuRelation4Correct)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
clscc_WorkStuRelation4CorrectEN objcc_WorkStuRelation4CorrectCond = new clscc_WorkStuRelation4CorrectEN();
string strCondition = objcc_WorkStuRelation4CorrectCond
.SetQuestionId(objcc_WorkStuRelation4Correct.QuestionId, "=")
.SetIdStudentInfo(objcc_WorkStuRelation4Correct.IdStudentInfo, "=")
.GetCombineCondition();
objcc_WorkStuRelation4Correct._IsCheckProperty = true;
bool bolIsExist = clscc_WorkStuRelation4CorrectBL.IsExistRecord(strCondition);
if (bolIsExist)
{
objcc_WorkStuRelation4Correct.mId = clscc_WorkStuRelation4CorrectBL.GetFirstID_S(strCondition);
objcc_WorkStuRelation4Correct.UpdateWithCondition(strCondition);
}
else
{
objcc_WorkStuRelation4Correct.AddNewRecord();
}
return true; 
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_Update)
 /// </summary>
 /// <param name = "objcc_WorkStuRelation4CorrectEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clscc_WorkStuRelation4CorrectEN objcc_WorkStuRelation4CorrectEN)
{
 if (objcc_WorkStuRelation4CorrectEN.mId == 0)
 {
string strMsg = string.Format("(errid:Busi000095)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clscc_WorkStuRelation4CorrectBL.cc_WorkStuRelation4CorrectDA.UpdateBySql2(objcc_WorkStuRelation4CorrectEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clscc_WorkStuRelation4CorrectBL.ReFreshCache(objcc_WorkStuRelation4CorrectEN.CourseId);

if (clscc_WorkStuRelation4CorrectBL.relatedActions != null)
{
clscc_WorkStuRelation4CorrectBL.relatedActions.UpdRelaTabDate(objcc_WorkStuRelation4CorrectEN.mId, objcc_WorkStuRelation4CorrectEN.UpdUser);
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
 /// <param name = "objcc_WorkStuRelation4CorrectEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clscc_WorkStuRelation4CorrectEN objcc_WorkStuRelation4CorrectEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (objcc_WorkStuRelation4CorrectEN.mId == 0)
 {
string strMsg = string.Format("(errid:Busi000087)修改记录时关键字不能为空!(带事务处理)(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clscc_WorkStuRelation4CorrectBL.cc_WorkStuRelation4CorrectDA.UpdateBySql2(objcc_WorkStuRelation4CorrectEN, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clscc_WorkStuRelation4CorrectBL.ReFreshCache(objcc_WorkStuRelation4CorrectEN.CourseId);

if (clscc_WorkStuRelation4CorrectBL.relatedActions != null)
{
clscc_WorkStuRelation4CorrectBL.relatedActions.UpdRelaTabDate(objcc_WorkStuRelation4CorrectEN.mId, objcc_WorkStuRelation4CorrectEN.UpdUser);
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
 /// <param name = "objcc_WorkStuRelation4CorrectEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clscc_WorkStuRelation4CorrectEN objcc_WorkStuRelation4CorrectEN, string strWhereCond)
{
try
{
bool bolResult = clscc_WorkStuRelation4CorrectBL.cc_WorkStuRelation4CorrectDA.UpdateBySqlWithCondition(objcc_WorkStuRelation4CorrectEN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clscc_WorkStuRelation4CorrectBL.ReFreshCache(objcc_WorkStuRelation4CorrectEN.CourseId);

if (clscc_WorkStuRelation4CorrectBL.relatedActions != null)
{
clscc_WorkStuRelation4CorrectBL.relatedActions.UpdRelaTabDate(objcc_WorkStuRelation4CorrectEN.mId, objcc_WorkStuRelation4CorrectEN.UpdUser);
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
 /// <param name = "objcc_WorkStuRelation4CorrectEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clscc_WorkStuRelation4CorrectEN objcc_WorkStuRelation4CorrectEN, string strWhereCond, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
bool bolResult = clscc_WorkStuRelation4CorrectBL.cc_WorkStuRelation4CorrectDA.UpdateBySqlWithConditionTransaction(objcc_WorkStuRelation4CorrectEN, strWhereCond, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clscc_WorkStuRelation4CorrectBL.ReFreshCache(objcc_WorkStuRelation4CorrectEN.CourseId);

if (clscc_WorkStuRelation4CorrectBL.relatedActions != null)
{
clscc_WorkStuRelation4CorrectBL.relatedActions.UpdRelaTabDate(objcc_WorkStuRelation4CorrectEN.mId, objcc_WorkStuRelation4CorrectEN.UpdUser);
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
 /// <param name = "lngmId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int Delete(this clscc_WorkStuRelation4CorrectEN objcc_WorkStuRelation4CorrectEN)
{
try
{
int intRecNum = clscc_WorkStuRelation4CorrectBL.cc_WorkStuRelation4CorrectDA.DelRecord(objcc_WorkStuRelation4CorrectEN.mId);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clscc_WorkStuRelation4CorrectBL.ReFreshCache(objcc_WorkStuRelation4CorrectEN.CourseId);

if (clscc_WorkStuRelation4CorrectBL.relatedActions != null)
{
clscc_WorkStuRelation4CorrectBL.relatedActions.UpdRelaTabDate(objcc_WorkStuRelation4CorrectEN.mId, objcc_WorkStuRelation4CorrectEN.UpdUser);
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
 /// <param name = "objcc_WorkStuRelation4CorrectENS">源对象</param>
 /// <param name = "objcc_WorkStuRelation4CorrectENT">目标对象</param>
 public static void CopyTo(this clscc_WorkStuRelation4CorrectEN objcc_WorkStuRelation4CorrectENS, clscc_WorkStuRelation4CorrectEN objcc_WorkStuRelation4CorrectENT)
{
try
{
objcc_WorkStuRelation4CorrectENT.mId = objcc_WorkStuRelation4CorrectENS.mId; //mId
objcc_WorkStuRelation4CorrectENT.CourseId = objcc_WorkStuRelation4CorrectENS.CourseId; //课程Id
objcc_WorkStuRelation4CorrectENT.IdStudentInfo = objcc_WorkStuRelation4CorrectENS.IdStudentInfo; //学生流水号
objcc_WorkStuRelation4CorrectENT.QuestionId = objcc_WorkStuRelation4CorrectENS.QuestionId; //题目Id
objcc_WorkStuRelation4CorrectENT.RightId = objcc_WorkStuRelation4CorrectENS.RightId; //权限编号
objcc_WorkStuRelation4CorrectENT.Authorizer = objcc_WorkStuRelation4CorrectENS.Authorizer; //授权人
objcc_WorkStuRelation4CorrectENT.UpdDate = objcc_WorkStuRelation4CorrectENS.UpdDate; //修改日期
objcc_WorkStuRelation4CorrectENT.UpdUser = objcc_WorkStuRelation4CorrectENS.UpdUser; //修改人
objcc_WorkStuRelation4CorrectENT.Memo = objcc_WorkStuRelation4CorrectENS.Memo; //备注
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
 /// <param name = "objcc_WorkStuRelation4CorrectENS">源对象</param>
 /// <returns>目标对象=>clscc_WorkStuRelation4CorrectEN:objcc_WorkStuRelation4CorrectENT</returns>
 public static clscc_WorkStuRelation4CorrectEN CopyTo(this clscc_WorkStuRelation4CorrectEN objcc_WorkStuRelation4CorrectENS)
{
try
{
 clscc_WorkStuRelation4CorrectEN objcc_WorkStuRelation4CorrectENT = new clscc_WorkStuRelation4CorrectEN()
{
mId = objcc_WorkStuRelation4CorrectENS.mId, //mId
CourseId = objcc_WorkStuRelation4CorrectENS.CourseId, //课程Id
IdStudentInfo = objcc_WorkStuRelation4CorrectENS.IdStudentInfo, //学生流水号
QuestionId = objcc_WorkStuRelation4CorrectENS.QuestionId, //题目Id
RightId = objcc_WorkStuRelation4CorrectENS.RightId, //权限编号
Authorizer = objcc_WorkStuRelation4CorrectENS.Authorizer, //授权人
UpdDate = objcc_WorkStuRelation4CorrectENS.UpdDate, //修改日期
UpdUser = objcc_WorkStuRelation4CorrectENS.UpdUser, //修改人
Memo = objcc_WorkStuRelation4CorrectENS.Memo, //备注
};
 return objcc_WorkStuRelation4CorrectENT;
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
public static void CheckPropertyNew(this clscc_WorkStuRelation4CorrectEN objcc_WorkStuRelation4CorrectEN)
{
 clscc_WorkStuRelation4CorrectBL.cc_WorkStuRelation4CorrectDA.CheckPropertyNew(objcc_WorkStuRelation4CorrectEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(this clscc_WorkStuRelation4CorrectEN objcc_WorkStuRelation4CorrectEN)
{
 clscc_WorkStuRelation4CorrectBL.cc_WorkStuRelation4CorrectDA.CheckProperty4Condition(objcc_WorkStuRelation4CorrectEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clscc_WorkStuRelation4CorrectEN objcc_WorkStuRelation4CorrectCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objcc_WorkStuRelation4CorrectCond.IsUpdated(concc_WorkStuRelation4Correct.mId) == true)
{
string strComparisonOpmId = objcc_WorkStuRelation4CorrectCond.dicFldComparisonOp[concc_WorkStuRelation4Correct.mId];
strWhereCond += string.Format(" And {0} {2} {1}", concc_WorkStuRelation4Correct.mId, objcc_WorkStuRelation4CorrectCond.mId, strComparisonOpmId);
}
if (objcc_WorkStuRelation4CorrectCond.IsUpdated(concc_WorkStuRelation4Correct.CourseId) == true)
{
string strComparisonOpCourseId = objcc_WorkStuRelation4CorrectCond.dicFldComparisonOp[concc_WorkStuRelation4Correct.CourseId];
strWhereCond += string.Format(" And {0} {2} '{1}'", concc_WorkStuRelation4Correct.CourseId, objcc_WorkStuRelation4CorrectCond.CourseId, strComparisonOpCourseId);
}
if (objcc_WorkStuRelation4CorrectCond.IsUpdated(concc_WorkStuRelation4Correct.IdStudentInfo) == true)
{
string strComparisonOpIdStudentInfo = objcc_WorkStuRelation4CorrectCond.dicFldComparisonOp[concc_WorkStuRelation4Correct.IdStudentInfo];
strWhereCond += string.Format(" And {0} {2} '{1}'", concc_WorkStuRelation4Correct.IdStudentInfo, objcc_WorkStuRelation4CorrectCond.IdStudentInfo, strComparisonOpIdStudentInfo);
}
if (objcc_WorkStuRelation4CorrectCond.IsUpdated(concc_WorkStuRelation4Correct.QuestionId) == true)
{
string strComparisonOpQuestionId = objcc_WorkStuRelation4CorrectCond.dicFldComparisonOp[concc_WorkStuRelation4Correct.QuestionId];
strWhereCond += string.Format(" And {0} {2} {1}", concc_WorkStuRelation4Correct.QuestionId, objcc_WorkStuRelation4CorrectCond.QuestionId, strComparisonOpQuestionId);
}
if (objcc_WorkStuRelation4CorrectCond.IsUpdated(concc_WorkStuRelation4Correct.RightId) == true)
{
string strComparisonOpRightId = objcc_WorkStuRelation4CorrectCond.dicFldComparisonOp[concc_WorkStuRelation4Correct.RightId];
strWhereCond += string.Format(" And {0} {2} '{1}'", concc_WorkStuRelation4Correct.RightId, objcc_WorkStuRelation4CorrectCond.RightId, strComparisonOpRightId);
}
if (objcc_WorkStuRelation4CorrectCond.IsUpdated(concc_WorkStuRelation4Correct.Authorizer) == true)
{
string strComparisonOpAuthorizer = objcc_WorkStuRelation4CorrectCond.dicFldComparisonOp[concc_WorkStuRelation4Correct.Authorizer];
strWhereCond += string.Format(" And {0} {2} '{1}'", concc_WorkStuRelation4Correct.Authorizer, objcc_WorkStuRelation4CorrectCond.Authorizer, strComparisonOpAuthorizer);
}
if (objcc_WorkStuRelation4CorrectCond.IsUpdated(concc_WorkStuRelation4Correct.UpdDate) == true)
{
string strComparisonOpUpdDate = objcc_WorkStuRelation4CorrectCond.dicFldComparisonOp[concc_WorkStuRelation4Correct.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", concc_WorkStuRelation4Correct.UpdDate, objcc_WorkStuRelation4CorrectCond.UpdDate, strComparisonOpUpdDate);
}
if (objcc_WorkStuRelation4CorrectCond.IsUpdated(concc_WorkStuRelation4Correct.UpdUser) == true)
{
string strComparisonOpUpdUser = objcc_WorkStuRelation4CorrectCond.dicFldComparisonOp[concc_WorkStuRelation4Correct.UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", concc_WorkStuRelation4Correct.UpdUser, objcc_WorkStuRelation4CorrectCond.UpdUser, strComparisonOpUpdUser);
}
if (objcc_WorkStuRelation4CorrectCond.IsUpdated(concc_WorkStuRelation4Correct.Memo) == true)
{
string strComparisonOpMemo = objcc_WorkStuRelation4CorrectCond.dicFldComparisonOp[concc_WorkStuRelation4Correct.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", concc_WorkStuRelation4Correct.Memo, objcc_WorkStuRelation4CorrectCond.Memo, strComparisonOpMemo);
}
 return strWhereCond;
}

 /// <summary>
 /// 检查唯一性(Uniqueness)--cc_WorkStuRelation4Correct(学生批改作业关系), 如果不唯一,即存在相同的记录,就返回False
 /// 唯一性条件:QuestionID_id_StudentInfo
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckConstraint)
 /// </summary>
 /// <param name = "objcc_WorkStuRelation4CorrectEN">要求唯一的对象</param>
 /// <returns></returns>
public static bool CheckUniqueness(this clscc_WorkStuRelation4CorrectEN objcc_WorkStuRelation4CorrectEN)
{
//检测记录是否存在
bool bolIsUniqueness;
StringBuilder sbCondition = new StringBuilder();
if (objcc_WorkStuRelation4CorrectEN == null) return true;
if (objcc_WorkStuRelation4CorrectEN.mId == 0)
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and QuestionId = '{0}'", objcc_WorkStuRelation4CorrectEN.QuestionId);
 sbCondition.AppendFormat(" and IdStudentInfo = '{0}'", objcc_WorkStuRelation4CorrectEN.IdStudentInfo);
if (clscc_WorkStuRelation4CorrectBL.IsExistRecord(sbCondition.ToString())  ==  true)
{
 bolIsUniqueness = false;
}
else
{
 bolIsUniqueness = true;
}
}
 else {
sbCondition.AppendFormat("mId !=  {0}", objcc_WorkStuRelation4CorrectEN.mId);
 sbCondition.AppendFormat(" and QuestionId = '{0}'", objcc_WorkStuRelation4CorrectEN.QuestionId);
 sbCondition.AppendFormat(" and IdStudentInfo = '{0}'", objcc_WorkStuRelation4CorrectEN.IdStudentInfo);
if (clscc_WorkStuRelation4CorrectBL.IsExistRecord(sbCondition.ToString())  ==  true)
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
 /// 获取唯一性条件串--cc_WorkStuRelation4Correct(学生批改作业关系), 即由对象中唯一性条件字段关键字与值组成的条件串
 /// 唯一性条件:QuestionID_id_StudentInfo
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetConditionString4Constraint)
 /// </summary>
 /// <param name = "objcc_WorkStuRelation4CorrectEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(this clscc_WorkStuRelation4CorrectEN objcc_WorkStuRelation4CorrectEN)
{
//检测记录是否存在
StringBuilder sbCondition = new StringBuilder();
if (objcc_WorkStuRelation4CorrectEN == null) return "";
if (objcc_WorkStuRelation4CorrectEN.mId == 0)
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and QuestionId = '{0}'", objcc_WorkStuRelation4CorrectEN.QuestionId);
 sbCondition.AppendFormat(" and IdStudentInfo = '{0}'", objcc_WorkStuRelation4CorrectEN.IdStudentInfo);
return sbCondition.ToString();
}
 else {
sbCondition.AppendFormat("mId !=  {0}", objcc_WorkStuRelation4CorrectEN.mId);
 sbCondition.AppendFormat(" and QuestionId = '{0}'", objcc_WorkStuRelation4CorrectEN.QuestionId);
 sbCondition.AppendFormat(" and IdStudentInfo = '{0}'", objcc_WorkStuRelation4CorrectEN.IdStudentInfo);
 return sbCondition.ToString();
}
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_cc_WorkStuRelation4Correct
{
public virtual bool UpdRelaTabDate(long lngmId, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// 学生批改作业关系(cc_WorkStuRelation4Correct)
 /// 数据源类型:表
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clscc_WorkStuRelation4CorrectBL
{
public static RelatedActions_cc_WorkStuRelation4Correct relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clscc_WorkStuRelation4CorrectDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clscc_WorkStuRelation4CorrectDA cc_WorkStuRelation4CorrectDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clscc_WorkStuRelation4CorrectDA();
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
 public clscc_WorkStuRelation4CorrectBL()
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
if (string.IsNullOrEmpty(clscc_WorkStuRelation4CorrectEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clscc_WorkStuRelation4CorrectEN._ConnectString);
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
public static DataTable GetDataTable_cc_WorkStuRelation4Correct(string strWhereCond)
{
DataTable objDT;
try
{
objDT = cc_WorkStuRelation4CorrectDA.GetDataTable_cc_WorkStuRelation4Correct(strWhereCond);
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
objDT = cc_WorkStuRelation4CorrectDA.GetDataTable(strWhereCond);
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
objDT = cc_WorkStuRelation4CorrectDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = cc_WorkStuRelation4CorrectDA.GetDataTable(strWhereCond, strTabName);
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
objDT = cc_WorkStuRelation4CorrectDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = cc_WorkStuRelation4CorrectDA.GetDataTable_Top(objTopPara);
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
objDT = cc_WorkStuRelation4CorrectDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = cc_WorkStuRelation4CorrectDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = cc_WorkStuRelation4CorrectDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
 /// <param name = "arrMIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static List<clscc_WorkStuRelation4CorrectEN> GetObjLstByMIdLst(List<long> arrMIdLst)
{
List<clscc_WorkStuRelation4CorrectEN> arrObjLst = new List<clscc_WorkStuRelation4CorrectEN>(); 
System.Data.DataTable objDT; 
 string strSqlConditionStr = clsArray.GetSqlInStrByArray(arrMIdLst);
 string strWhereCond = string.Format("mId in ({0})", strSqlConditionStr);
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clscc_WorkStuRelation4CorrectEN objcc_WorkStuRelation4CorrectEN = new clscc_WorkStuRelation4CorrectEN();
try
{
objcc_WorkStuRelation4CorrectEN.mId = Int32.Parse(objRow[concc_WorkStuRelation4Correct.mId].ToString().Trim()); //mId
objcc_WorkStuRelation4CorrectEN.CourseId = objRow[concc_WorkStuRelation4Correct.CourseId].ToString().Trim(); //课程Id
objcc_WorkStuRelation4CorrectEN.IdStudentInfo = objRow[concc_WorkStuRelation4Correct.IdStudentInfo].ToString().Trim(); //学生流水号
objcc_WorkStuRelation4CorrectEN.QuestionId = Int32.Parse(objRow[concc_WorkStuRelation4Correct.QuestionId].ToString().Trim()); //题目Id
objcc_WorkStuRelation4CorrectEN.RightId = objRow[concc_WorkStuRelation4Correct.RightId].ToString().Trim(); //权限编号
objcc_WorkStuRelation4CorrectEN.Authorizer = objRow[concc_WorkStuRelation4Correct.Authorizer].ToString().Trim(); //授权人
objcc_WorkStuRelation4CorrectEN.UpdDate = objRow[concc_WorkStuRelation4Correct.UpdDate] == DBNull.Value ? null : objRow[concc_WorkStuRelation4Correct.UpdDate].ToString().Trim(); //修改日期
objcc_WorkStuRelation4CorrectEN.UpdUser = objRow[concc_WorkStuRelation4Correct.UpdUser] == DBNull.Value ? null : objRow[concc_WorkStuRelation4Correct.UpdUser].ToString().Trim(); //修改人
objcc_WorkStuRelation4CorrectEN.Memo = objRow[concc_WorkStuRelation4Correct.Memo] == DBNull.Value ? null : objRow[concc_WorkStuRelation4Correct.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objcc_WorkStuRelation4CorrectEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objcc_WorkStuRelation4CorrectEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrMIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clscc_WorkStuRelation4CorrectEN> GetObjLstByMIdLstCache(List<long> arrMIdLst, string strCourseId)
{
string strKey = string.Format("{0}_{1}", clscc_WorkStuRelation4CorrectEN._CurrTabName, strCourseId);
List<clscc_WorkStuRelation4CorrectEN> arrcc_WorkStuRelation4CorrectObjLstCache = GetObjLstCache(strCourseId);
IEnumerable <clscc_WorkStuRelation4CorrectEN> arrcc_WorkStuRelation4CorrectObjLst_Sel =
arrcc_WorkStuRelation4CorrectObjLstCache
.Where(x => arrMIdLst.Contains(x.mId));
return arrcc_WorkStuRelation4CorrectObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clscc_WorkStuRelation4CorrectEN> GetObjLst(string strWhereCond)
{
List<clscc_WorkStuRelation4CorrectEN> arrObjLst = new List<clscc_WorkStuRelation4CorrectEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clscc_WorkStuRelation4CorrectEN objcc_WorkStuRelation4CorrectEN = new clscc_WorkStuRelation4CorrectEN();
try
{
objcc_WorkStuRelation4CorrectEN.mId = Int32.Parse(objRow[concc_WorkStuRelation4Correct.mId].ToString().Trim()); //mId
objcc_WorkStuRelation4CorrectEN.CourseId = objRow[concc_WorkStuRelation4Correct.CourseId].ToString().Trim(); //课程Id
objcc_WorkStuRelation4CorrectEN.IdStudentInfo = objRow[concc_WorkStuRelation4Correct.IdStudentInfo].ToString().Trim(); //学生流水号
objcc_WorkStuRelation4CorrectEN.QuestionId = Int32.Parse(objRow[concc_WorkStuRelation4Correct.QuestionId].ToString().Trim()); //题目Id
objcc_WorkStuRelation4CorrectEN.RightId = objRow[concc_WorkStuRelation4Correct.RightId].ToString().Trim(); //权限编号
objcc_WorkStuRelation4CorrectEN.Authorizer = objRow[concc_WorkStuRelation4Correct.Authorizer].ToString().Trim(); //授权人
objcc_WorkStuRelation4CorrectEN.UpdDate = objRow[concc_WorkStuRelation4Correct.UpdDate] == DBNull.Value ? null : objRow[concc_WorkStuRelation4Correct.UpdDate].ToString().Trim(); //修改日期
objcc_WorkStuRelation4CorrectEN.UpdUser = objRow[concc_WorkStuRelation4Correct.UpdUser] == DBNull.Value ? null : objRow[concc_WorkStuRelation4Correct.UpdUser].ToString().Trim(); //修改人
objcc_WorkStuRelation4CorrectEN.Memo = objRow[concc_WorkStuRelation4Correct.Memo] == DBNull.Value ? null : objRow[concc_WorkStuRelation4Correct.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objcc_WorkStuRelation4CorrectEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objcc_WorkStuRelation4CorrectEN);
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
public static List<clscc_WorkStuRelation4CorrectEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clscc_WorkStuRelation4CorrectEN> arrObjLst = new List<clscc_WorkStuRelation4CorrectEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clscc_WorkStuRelation4CorrectEN objcc_WorkStuRelation4CorrectEN = new clscc_WorkStuRelation4CorrectEN();
try
{
objcc_WorkStuRelation4CorrectEN.mId = Int32.Parse(objRow[concc_WorkStuRelation4Correct.mId].ToString().Trim()); //mId
objcc_WorkStuRelation4CorrectEN.CourseId = objRow[concc_WorkStuRelation4Correct.CourseId].ToString().Trim(); //课程Id
objcc_WorkStuRelation4CorrectEN.IdStudentInfo = objRow[concc_WorkStuRelation4Correct.IdStudentInfo].ToString().Trim(); //学生流水号
objcc_WorkStuRelation4CorrectEN.QuestionId = Int32.Parse(objRow[concc_WorkStuRelation4Correct.QuestionId].ToString().Trim()); //题目Id
objcc_WorkStuRelation4CorrectEN.RightId = objRow[concc_WorkStuRelation4Correct.RightId].ToString().Trim(); //权限编号
objcc_WorkStuRelation4CorrectEN.Authorizer = objRow[concc_WorkStuRelation4Correct.Authorizer].ToString().Trim(); //授权人
objcc_WorkStuRelation4CorrectEN.UpdDate = objRow[concc_WorkStuRelation4Correct.UpdDate] == DBNull.Value ? null : objRow[concc_WorkStuRelation4Correct.UpdDate].ToString().Trim(); //修改日期
objcc_WorkStuRelation4CorrectEN.UpdUser = objRow[concc_WorkStuRelation4Correct.UpdUser] == DBNull.Value ? null : objRow[concc_WorkStuRelation4Correct.UpdUser].ToString().Trim(); //修改人
objcc_WorkStuRelation4CorrectEN.Memo = objRow[concc_WorkStuRelation4Correct.Memo] == DBNull.Value ? null : objRow[concc_WorkStuRelation4Correct.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objcc_WorkStuRelation4CorrectEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objcc_WorkStuRelation4CorrectEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objcc_WorkStuRelation4CorrectCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clscc_WorkStuRelation4CorrectEN> GetSubObjLstCache(clscc_WorkStuRelation4CorrectEN objcc_WorkStuRelation4CorrectCond)
{
 string strCourseId = objcc_WorkStuRelation4CorrectCond.CourseId;
 if (string.IsNullOrEmpty(strCourseId) == true)
{
string strMsg = string.Format("(errid:Busi000172)在表中,缓存分类字段值不能为空!(clscc_WorkStuRelation4CorrectBL:GetSubObjLstCache)");
throw new Exception(strMsg);
}
List<clscc_WorkStuRelation4CorrectEN> arrObjLstCache = GetObjLstCache(strCourseId);
IEnumerable <clscc_WorkStuRelation4CorrectEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in concc_WorkStuRelation4Correct.AttributeName)
{
if (objcc_WorkStuRelation4CorrectCond.IsUpdated(strFldName) == false) continue;
if (objcc_WorkStuRelation4CorrectCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objcc_WorkStuRelation4CorrectCond[strFldName].ToString());
}
else
{
if (objcc_WorkStuRelation4CorrectCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objcc_WorkStuRelation4CorrectCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objcc_WorkStuRelation4CorrectCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objcc_WorkStuRelation4CorrectCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objcc_WorkStuRelation4CorrectCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objcc_WorkStuRelation4CorrectCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objcc_WorkStuRelation4CorrectCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objcc_WorkStuRelation4CorrectCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objcc_WorkStuRelation4CorrectCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objcc_WorkStuRelation4CorrectCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objcc_WorkStuRelation4CorrectCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objcc_WorkStuRelation4CorrectCond[strFldName]));
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
public static List<clscc_WorkStuRelation4CorrectEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clscc_WorkStuRelation4CorrectEN> arrObjLst = new List<clscc_WorkStuRelation4CorrectEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clscc_WorkStuRelation4CorrectEN objcc_WorkStuRelation4CorrectEN = new clscc_WorkStuRelation4CorrectEN();
try
{
objcc_WorkStuRelation4CorrectEN.mId = Int32.Parse(objRow[concc_WorkStuRelation4Correct.mId].ToString().Trim()); //mId
objcc_WorkStuRelation4CorrectEN.CourseId = objRow[concc_WorkStuRelation4Correct.CourseId].ToString().Trim(); //课程Id
objcc_WorkStuRelation4CorrectEN.IdStudentInfo = objRow[concc_WorkStuRelation4Correct.IdStudentInfo].ToString().Trim(); //学生流水号
objcc_WorkStuRelation4CorrectEN.QuestionId = Int32.Parse(objRow[concc_WorkStuRelation4Correct.QuestionId].ToString().Trim()); //题目Id
objcc_WorkStuRelation4CorrectEN.RightId = objRow[concc_WorkStuRelation4Correct.RightId].ToString().Trim(); //权限编号
objcc_WorkStuRelation4CorrectEN.Authorizer = objRow[concc_WorkStuRelation4Correct.Authorizer].ToString().Trim(); //授权人
objcc_WorkStuRelation4CorrectEN.UpdDate = objRow[concc_WorkStuRelation4Correct.UpdDate] == DBNull.Value ? null : objRow[concc_WorkStuRelation4Correct.UpdDate].ToString().Trim(); //修改日期
objcc_WorkStuRelation4CorrectEN.UpdUser = objRow[concc_WorkStuRelation4Correct.UpdUser] == DBNull.Value ? null : objRow[concc_WorkStuRelation4Correct.UpdUser].ToString().Trim(); //修改人
objcc_WorkStuRelation4CorrectEN.Memo = objRow[concc_WorkStuRelation4Correct.Memo] == DBNull.Value ? null : objRow[concc_WorkStuRelation4Correct.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objcc_WorkStuRelation4CorrectEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objcc_WorkStuRelation4CorrectEN);
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
public static List<clscc_WorkStuRelation4CorrectEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clscc_WorkStuRelation4CorrectEN> arrObjLst = new List<clscc_WorkStuRelation4CorrectEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clscc_WorkStuRelation4CorrectEN objcc_WorkStuRelation4CorrectEN = new clscc_WorkStuRelation4CorrectEN();
try
{
objcc_WorkStuRelation4CorrectEN.mId = Int32.Parse(objRow[concc_WorkStuRelation4Correct.mId].ToString().Trim()); //mId
objcc_WorkStuRelation4CorrectEN.CourseId = objRow[concc_WorkStuRelation4Correct.CourseId].ToString().Trim(); //课程Id
objcc_WorkStuRelation4CorrectEN.IdStudentInfo = objRow[concc_WorkStuRelation4Correct.IdStudentInfo].ToString().Trim(); //学生流水号
objcc_WorkStuRelation4CorrectEN.QuestionId = Int32.Parse(objRow[concc_WorkStuRelation4Correct.QuestionId].ToString().Trim()); //题目Id
objcc_WorkStuRelation4CorrectEN.RightId = objRow[concc_WorkStuRelation4Correct.RightId].ToString().Trim(); //权限编号
objcc_WorkStuRelation4CorrectEN.Authorizer = objRow[concc_WorkStuRelation4Correct.Authorizer].ToString().Trim(); //授权人
objcc_WorkStuRelation4CorrectEN.UpdDate = objRow[concc_WorkStuRelation4Correct.UpdDate] == DBNull.Value ? null : objRow[concc_WorkStuRelation4Correct.UpdDate].ToString().Trim(); //修改日期
objcc_WorkStuRelation4CorrectEN.UpdUser = objRow[concc_WorkStuRelation4Correct.UpdUser] == DBNull.Value ? null : objRow[concc_WorkStuRelation4Correct.UpdUser].ToString().Trim(); //修改人
objcc_WorkStuRelation4CorrectEN.Memo = objRow[concc_WorkStuRelation4Correct.Memo] == DBNull.Value ? null : objRow[concc_WorkStuRelation4Correct.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objcc_WorkStuRelation4CorrectEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objcc_WorkStuRelation4CorrectEN);
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
List<clscc_WorkStuRelation4CorrectEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clscc_WorkStuRelation4CorrectEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clscc_WorkStuRelation4CorrectEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clscc_WorkStuRelation4CorrectEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clscc_WorkStuRelation4CorrectEN> arrObjLst = new List<clscc_WorkStuRelation4CorrectEN>(); 
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
	clscc_WorkStuRelation4CorrectEN objcc_WorkStuRelation4CorrectEN = new clscc_WorkStuRelation4CorrectEN();
try
{
objcc_WorkStuRelation4CorrectEN.mId = Int32.Parse(objRow[concc_WorkStuRelation4Correct.mId].ToString().Trim()); //mId
objcc_WorkStuRelation4CorrectEN.CourseId = objRow[concc_WorkStuRelation4Correct.CourseId].ToString().Trim(); //课程Id
objcc_WorkStuRelation4CorrectEN.IdStudentInfo = objRow[concc_WorkStuRelation4Correct.IdStudentInfo].ToString().Trim(); //学生流水号
objcc_WorkStuRelation4CorrectEN.QuestionId = Int32.Parse(objRow[concc_WorkStuRelation4Correct.QuestionId].ToString().Trim()); //题目Id
objcc_WorkStuRelation4CorrectEN.RightId = objRow[concc_WorkStuRelation4Correct.RightId].ToString().Trim(); //权限编号
objcc_WorkStuRelation4CorrectEN.Authorizer = objRow[concc_WorkStuRelation4Correct.Authorizer].ToString().Trim(); //授权人
objcc_WorkStuRelation4CorrectEN.UpdDate = objRow[concc_WorkStuRelation4Correct.UpdDate] == DBNull.Value ? null : objRow[concc_WorkStuRelation4Correct.UpdDate].ToString().Trim(); //修改日期
objcc_WorkStuRelation4CorrectEN.UpdUser = objRow[concc_WorkStuRelation4Correct.UpdUser] == DBNull.Value ? null : objRow[concc_WorkStuRelation4Correct.UpdUser].ToString().Trim(); //修改人
objcc_WorkStuRelation4CorrectEN.Memo = objRow[concc_WorkStuRelation4Correct.Memo] == DBNull.Value ? null : objRow[concc_WorkStuRelation4Correct.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objcc_WorkStuRelation4CorrectEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objcc_WorkStuRelation4CorrectEN);
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
public static List<clscc_WorkStuRelation4CorrectEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clscc_WorkStuRelation4CorrectEN> arrObjLst = new List<clscc_WorkStuRelation4CorrectEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clscc_WorkStuRelation4CorrectEN objcc_WorkStuRelation4CorrectEN = new clscc_WorkStuRelation4CorrectEN();
try
{
objcc_WorkStuRelation4CorrectEN.mId = Int32.Parse(objRow[concc_WorkStuRelation4Correct.mId].ToString().Trim()); //mId
objcc_WorkStuRelation4CorrectEN.CourseId = objRow[concc_WorkStuRelation4Correct.CourseId].ToString().Trim(); //课程Id
objcc_WorkStuRelation4CorrectEN.IdStudentInfo = objRow[concc_WorkStuRelation4Correct.IdStudentInfo].ToString().Trim(); //学生流水号
objcc_WorkStuRelation4CorrectEN.QuestionId = Int32.Parse(objRow[concc_WorkStuRelation4Correct.QuestionId].ToString().Trim()); //题目Id
objcc_WorkStuRelation4CorrectEN.RightId = objRow[concc_WorkStuRelation4Correct.RightId].ToString().Trim(); //权限编号
objcc_WorkStuRelation4CorrectEN.Authorizer = objRow[concc_WorkStuRelation4Correct.Authorizer].ToString().Trim(); //授权人
objcc_WorkStuRelation4CorrectEN.UpdDate = objRow[concc_WorkStuRelation4Correct.UpdDate] == DBNull.Value ? null : objRow[concc_WorkStuRelation4Correct.UpdDate].ToString().Trim(); //修改日期
objcc_WorkStuRelation4CorrectEN.UpdUser = objRow[concc_WorkStuRelation4Correct.UpdUser] == DBNull.Value ? null : objRow[concc_WorkStuRelation4Correct.UpdUser].ToString().Trim(); //修改人
objcc_WorkStuRelation4CorrectEN.Memo = objRow[concc_WorkStuRelation4Correct.Memo] == DBNull.Value ? null : objRow[concc_WorkStuRelation4Correct.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objcc_WorkStuRelation4CorrectEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objcc_WorkStuRelation4CorrectEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clscc_WorkStuRelation4CorrectEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clscc_WorkStuRelation4CorrectEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clscc_WorkStuRelation4CorrectEN> arrObjLst = new List<clscc_WorkStuRelation4CorrectEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clscc_WorkStuRelation4CorrectEN objcc_WorkStuRelation4CorrectEN = new clscc_WorkStuRelation4CorrectEN();
try
{
objcc_WorkStuRelation4CorrectEN.mId = Int32.Parse(objRow[concc_WorkStuRelation4Correct.mId].ToString().Trim()); //mId
objcc_WorkStuRelation4CorrectEN.CourseId = objRow[concc_WorkStuRelation4Correct.CourseId].ToString().Trim(); //课程Id
objcc_WorkStuRelation4CorrectEN.IdStudentInfo = objRow[concc_WorkStuRelation4Correct.IdStudentInfo].ToString().Trim(); //学生流水号
objcc_WorkStuRelation4CorrectEN.QuestionId = Int32.Parse(objRow[concc_WorkStuRelation4Correct.QuestionId].ToString().Trim()); //题目Id
objcc_WorkStuRelation4CorrectEN.RightId = objRow[concc_WorkStuRelation4Correct.RightId].ToString().Trim(); //权限编号
objcc_WorkStuRelation4CorrectEN.Authorizer = objRow[concc_WorkStuRelation4Correct.Authorizer].ToString().Trim(); //授权人
objcc_WorkStuRelation4CorrectEN.UpdDate = objRow[concc_WorkStuRelation4Correct.UpdDate] == DBNull.Value ? null : objRow[concc_WorkStuRelation4Correct.UpdDate].ToString().Trim(); //修改日期
objcc_WorkStuRelation4CorrectEN.UpdUser = objRow[concc_WorkStuRelation4Correct.UpdUser] == DBNull.Value ? null : objRow[concc_WorkStuRelation4Correct.UpdUser].ToString().Trim(); //修改人
objcc_WorkStuRelation4CorrectEN.Memo = objRow[concc_WorkStuRelation4Correct.Memo] == DBNull.Value ? null : objRow[concc_WorkStuRelation4Correct.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objcc_WorkStuRelation4CorrectEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objcc_WorkStuRelation4CorrectEN);
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
public static List<clscc_WorkStuRelation4CorrectEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clscc_WorkStuRelation4CorrectEN> arrObjLst = new List<clscc_WorkStuRelation4CorrectEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clscc_WorkStuRelation4CorrectEN objcc_WorkStuRelation4CorrectEN = new clscc_WorkStuRelation4CorrectEN();
try
{
objcc_WorkStuRelation4CorrectEN.mId = Int32.Parse(objRow[concc_WorkStuRelation4Correct.mId].ToString().Trim()); //mId
objcc_WorkStuRelation4CorrectEN.CourseId = objRow[concc_WorkStuRelation4Correct.CourseId].ToString().Trim(); //课程Id
objcc_WorkStuRelation4CorrectEN.IdStudentInfo = objRow[concc_WorkStuRelation4Correct.IdStudentInfo].ToString().Trim(); //学生流水号
objcc_WorkStuRelation4CorrectEN.QuestionId = Int32.Parse(objRow[concc_WorkStuRelation4Correct.QuestionId].ToString().Trim()); //题目Id
objcc_WorkStuRelation4CorrectEN.RightId = objRow[concc_WorkStuRelation4Correct.RightId].ToString().Trim(); //权限编号
objcc_WorkStuRelation4CorrectEN.Authorizer = objRow[concc_WorkStuRelation4Correct.Authorizer].ToString().Trim(); //授权人
objcc_WorkStuRelation4CorrectEN.UpdDate = objRow[concc_WorkStuRelation4Correct.UpdDate] == DBNull.Value ? null : objRow[concc_WorkStuRelation4Correct.UpdDate].ToString().Trim(); //修改日期
objcc_WorkStuRelation4CorrectEN.UpdUser = objRow[concc_WorkStuRelation4Correct.UpdUser] == DBNull.Value ? null : objRow[concc_WorkStuRelation4Correct.UpdUser].ToString().Trim(); //修改人
objcc_WorkStuRelation4CorrectEN.Memo = objRow[concc_WorkStuRelation4Correct.Memo] == DBNull.Value ? null : objRow[concc_WorkStuRelation4Correct.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objcc_WorkStuRelation4CorrectEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objcc_WorkStuRelation4CorrectEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clscc_WorkStuRelation4CorrectEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clscc_WorkStuRelation4CorrectEN> arrObjLst = new List<clscc_WorkStuRelation4CorrectEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clscc_WorkStuRelation4CorrectEN objcc_WorkStuRelation4CorrectEN = new clscc_WorkStuRelation4CorrectEN();
try
{
objcc_WorkStuRelation4CorrectEN.mId = Int32.Parse(objRow[concc_WorkStuRelation4Correct.mId].ToString().Trim()); //mId
objcc_WorkStuRelation4CorrectEN.CourseId = objRow[concc_WorkStuRelation4Correct.CourseId].ToString().Trim(); //课程Id
objcc_WorkStuRelation4CorrectEN.IdStudentInfo = objRow[concc_WorkStuRelation4Correct.IdStudentInfo].ToString().Trim(); //学生流水号
objcc_WorkStuRelation4CorrectEN.QuestionId = Int32.Parse(objRow[concc_WorkStuRelation4Correct.QuestionId].ToString().Trim()); //题目Id
objcc_WorkStuRelation4CorrectEN.RightId = objRow[concc_WorkStuRelation4Correct.RightId].ToString().Trim(); //权限编号
objcc_WorkStuRelation4CorrectEN.Authorizer = objRow[concc_WorkStuRelation4Correct.Authorizer].ToString().Trim(); //授权人
objcc_WorkStuRelation4CorrectEN.UpdDate = objRow[concc_WorkStuRelation4Correct.UpdDate] == DBNull.Value ? null : objRow[concc_WorkStuRelation4Correct.UpdDate].ToString().Trim(); //修改日期
objcc_WorkStuRelation4CorrectEN.UpdUser = objRow[concc_WorkStuRelation4Correct.UpdUser] == DBNull.Value ? null : objRow[concc_WorkStuRelation4Correct.UpdUser].ToString().Trim(); //修改人
objcc_WorkStuRelation4CorrectEN.Memo = objRow[concc_WorkStuRelation4Correct.Memo] == DBNull.Value ? null : objRow[concc_WorkStuRelation4Correct.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objcc_WorkStuRelation4CorrectEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objcc_WorkStuRelation4CorrectEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objcc_WorkStuRelation4CorrectEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool Getcc_WorkStuRelation4Correct(ref clscc_WorkStuRelation4CorrectEN objcc_WorkStuRelation4CorrectEN)
{
bool bolResult = cc_WorkStuRelation4CorrectDA.Getcc_WorkStuRelation4Correct(ref objcc_WorkStuRelation4CorrectEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public static clscc_WorkStuRelation4CorrectEN GetObjBymId(long lngmId)
{
clscc_WorkStuRelation4CorrectEN objcc_WorkStuRelation4CorrectEN = cc_WorkStuRelation4CorrectDA.GetObjBymId(lngmId);
return objcc_WorkStuRelation4CorrectEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clscc_WorkStuRelation4CorrectEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clscc_WorkStuRelation4CorrectEN objcc_WorkStuRelation4CorrectEN = cc_WorkStuRelation4CorrectDA.GetFirstObj(strWhereCond);
 return objcc_WorkStuRelation4CorrectEN;
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
public static clscc_WorkStuRelation4CorrectEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clscc_WorkStuRelation4CorrectEN objcc_WorkStuRelation4CorrectEN = cc_WorkStuRelation4CorrectDA.GetObjByDataRow(objRow);
 return objcc_WorkStuRelation4CorrectEN;
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
public static clscc_WorkStuRelation4CorrectEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clscc_WorkStuRelation4CorrectEN objcc_WorkStuRelation4CorrectEN = cc_WorkStuRelation4CorrectDA.GetObjByDataRow(objRow);
 return objcc_WorkStuRelation4CorrectEN;
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
 /// <param name = "lngmId">所给的关键字</param>
 /// <param name = "lstcc_WorkStuRelation4CorrectObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clscc_WorkStuRelation4CorrectEN GetObjBymIdFromList(long lngmId, List<clscc_WorkStuRelation4CorrectEN> lstcc_WorkStuRelation4CorrectObjLst)
{
foreach (clscc_WorkStuRelation4CorrectEN objcc_WorkStuRelation4CorrectEN in lstcc_WorkStuRelation4CorrectObjLst)
{
if (objcc_WorkStuRelation4CorrectEN.mId == lngmId)
{
return objcc_WorkStuRelation4CorrectEN;
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
 long lngmId;
 try
 {
 lngmId = new clscc_WorkStuRelation4CorrectDA().GetFirstID(strWhereCond);
 return lngmId;
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
 arrList = cc_WorkStuRelation4CorrectDA.GetID(strWhereCond);
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
bool bolIsExist = cc_WorkStuRelation4CorrectDA.IsExistCondRec(strWhereCond);
return bolIsExist;
}

 /// <summary>
 /// 判断当前表中是否存在给定关键字值的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExist)
 /// </summary>
 /// <param name = "lngmId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public static bool IsExist(long lngmId)
{
//检测记录是否存在
bool bolIsExist = cc_WorkStuRelation4CorrectDA.IsExist(lngmId);
return bolIsExist;
}

/// <summary>
/// 设置修改时间
/// </summary>
/// <param name = "lngmId">mId</param>
/// <param name = "strOpUser">修改用户</param>
/// <returns>是否成功？</returns>
public static bool SetUpdDate(long lngmId, string strOpUser)
{
clscc_WorkStuRelation4CorrectEN objcc_WorkStuRelation4CorrectEN = clscc_WorkStuRelation4CorrectBL.GetObjBymId(lngmId);
objcc_WorkStuRelation4CorrectEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
objcc_WorkStuRelation4CorrectEN.UpdUser = strOpUser;
return clscc_WorkStuRelation4CorrectBL.UpdateBySql2(objcc_WorkStuRelation4CorrectEN);
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
 bolIsExist = clscc_WorkStuRelation4CorrectDA.IsExistTable();
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
 bolIsExist = cc_WorkStuRelation4CorrectDA.IsExistTable(strTabName);
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
 /// <param name = "objcc_WorkStuRelation4CorrectEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecordBySql2(clscc_WorkStuRelation4CorrectEN objcc_WorkStuRelation4CorrectEN, bool bolIsNeedCheckUniqueness=true)
{
if (bolIsNeedCheckUniqueness == true && objcc_WorkStuRelation4CorrectEN.CheckUniqueness() == false)
{
var strMsg = string.Format("记录已经存在!题目Id = [{0}],学生流水号 = [{1}]的数据已经存在!(in clscc_WorkStuRelation4CorrectBL.AddNewRecordBySql2)", objcc_WorkStuRelation4CorrectEN.QuestionId,objcc_WorkStuRelation4CorrectEN.IdStudentInfo);
throw new Exception(strMsg);
}
try
{
bool bolResult = cc_WorkStuRelation4CorrectDA.AddNewRecordBySQL2(objcc_WorkStuRelation4CorrectEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clscc_WorkStuRelation4CorrectBL.ReFreshCache(objcc_WorkStuRelation4CorrectEN.CourseId);

if (clscc_WorkStuRelation4CorrectBL.relatedActions != null)
{
clscc_WorkStuRelation4CorrectBL.relatedActions.UpdRelaTabDate(objcc_WorkStuRelation4CorrectEN.mId, objcc_WorkStuRelation4CorrectEN.UpdUser);
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
 /// <param name = "objcc_WorkStuRelation4CorrectEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordBySql2WithReturnKey(clscc_WorkStuRelation4CorrectEN objcc_WorkStuRelation4CorrectEN, bool bolIsNeedCheckUniqueness=true)
{
if (bolIsNeedCheckUniqueness == true && objcc_WorkStuRelation4CorrectEN.CheckUniqueness() == false)
{
var strMsg = string.Format("记录已经存在!题目Id = [{0}],学生流水号 = [{1}]的数据已经存在!(in clscc_WorkStuRelation4CorrectBL.AddNewRecordBySql2WithReturnKey)", objcc_WorkStuRelation4CorrectEN.QuestionId,objcc_WorkStuRelation4CorrectEN.IdStudentInfo);
throw new Exception(strMsg);
}
try
{
string strKey = cc_WorkStuRelation4CorrectDA.AddNewRecordBySQL2WithReturnKey(objcc_WorkStuRelation4CorrectEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clscc_WorkStuRelation4CorrectBL.ReFreshCache(objcc_WorkStuRelation4CorrectEN.CourseId);

if (clscc_WorkStuRelation4CorrectBL.relatedActions != null)
{
clscc_WorkStuRelation4CorrectBL.relatedActions.UpdRelaTabDate(objcc_WorkStuRelation4CorrectEN.mId, objcc_WorkStuRelation4CorrectEN.UpdUser);
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
 /// <param name = "objcc_WorkStuRelation4CorrectEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(clscc_WorkStuRelation4CorrectEN objcc_WorkStuRelation4CorrectEN)
{
try
{
bool bolResult = cc_WorkStuRelation4CorrectDA.Update(objcc_WorkStuRelation4CorrectEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clscc_WorkStuRelation4CorrectBL.ReFreshCache(objcc_WorkStuRelation4CorrectEN.CourseId);

if (clscc_WorkStuRelation4CorrectBL.relatedActions != null)
{
clscc_WorkStuRelation4CorrectBL.relatedActions.UpdRelaTabDate(objcc_WorkStuRelation4CorrectEN.mId, objcc_WorkStuRelation4CorrectEN.UpdUser);
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
 /// <param name = "objcc_WorkStuRelation4CorrectEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateBySql2(clscc_WorkStuRelation4CorrectEN objcc_WorkStuRelation4CorrectEN)
{
 if (objcc_WorkStuRelation4CorrectEN.mId == 0)
 {
var strMsg = string.Format("(errid:Busi000065)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = cc_WorkStuRelation4CorrectDA.UpdateBySql2(objcc_WorkStuRelation4CorrectEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clscc_WorkStuRelation4CorrectBL.ReFreshCache(objcc_WorkStuRelation4CorrectEN.CourseId);

if (clscc_WorkStuRelation4CorrectBL.relatedActions != null)
{
clscc_WorkStuRelation4CorrectBL.relatedActions.UpdRelaTabDate(objcc_WorkStuRelation4CorrectEN.mId, objcc_WorkStuRelation4CorrectEN.UpdUser);
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
 /// <param name = "lngmId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int DelRecord(long lngmId)
{
try
{
 clscc_WorkStuRelation4CorrectEN objcc_WorkStuRelation4CorrectEN = clscc_WorkStuRelation4CorrectBL.GetObjBymId(lngmId);

if (clscc_WorkStuRelation4CorrectBL.relatedActions != null)
{
clscc_WorkStuRelation4CorrectBL.relatedActions.UpdRelaTabDate(objcc_WorkStuRelation4CorrectEN.mId, objcc_WorkStuRelation4CorrectEN.UpdUser);
}
if (objcc_WorkStuRelation4CorrectEN != null)
{
int intRecNum = cc_WorkStuRelation4CorrectDA.DelRecord(lngmId);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
ReFreshCache(objcc_WorkStuRelation4CorrectEN.CourseId);
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
/// <param name="lngmId">表关键字</param>
 /// <param name = "strCourseId">缓存的分类字段</param>
/// <returns></returns>
public static bool DelRecordEx(long lngmId , string strCourseId)
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clscc_WorkStuRelation4CorrectDA.GetSpecSQLObj();
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
//删除与表:[cc_WorkStuRelation4Correct]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//concc_WorkStuRelation4Correct.mId,
//lngmId);
//        clscc_WorkStuRelation4CorrectBL.Delcc_WorkStuRelation4CorrectsByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clscc_WorkStuRelation4CorrectBL.DelRecord(lngmId, strCourseId, objConnection, objSqlTransaction);
objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clscc_WorkStuRelation4CorrectBLEx", "DelRecordEx", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("扩展删除记录出错:{0}!keyId = {1}.({2})",
objException.Message,
lngmId, clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "lngmId">给定的关键字值</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回删除是否成功?</returns>
public static bool DelRecord(long lngmId, string strCourseId, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
if (clscc_WorkStuRelation4CorrectBL.relatedActions != null)
{
clscc_WorkStuRelation4CorrectBL.relatedActions.UpdRelaTabDate(lngmId, "UpdRelaTabDate");
}
bool bolResult = cc_WorkStuRelation4CorrectDA.DelRecord(lngmId,objSqlConnection,objSqlTransaction);
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
 /// <param name = "arrmIdLst">给定的关键字值列表</param>
 /// <returns>返回删除的记录数</returns>
public static int Delcc_WorkStuRelation4Corrects(List<string> arrmIdLst)
{
if (arrmIdLst.Count == 0) return 0;
try
{
if (clscc_WorkStuRelation4CorrectBL.relatedActions != null)
{
foreach (var strmId in arrmIdLst)
{
long lngmId = long.Parse(strmId);
clscc_WorkStuRelation4CorrectBL.relatedActions.UpdRelaTabDate(lngmId, "UpdRelaTabDate");
}
}
 clscc_WorkStuRelation4CorrectEN objcc_WorkStuRelation4CorrectEN = clscc_WorkStuRelation4CorrectBL.GetObjBymId(long.Parse(arrmIdLst[0]));
int intDelRecNum = cc_WorkStuRelation4CorrectDA.Delcc_WorkStuRelation4Correct(arrmIdLst);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
ReFreshCache(objcc_WorkStuRelation4CorrectEN.CourseId);
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
public static int Delcc_WorkStuRelation4CorrectsByCond(string strWhereCond)
{
try
{
if (clscc_WorkStuRelation4CorrectBL.relatedActions != null)
{
List<string> arrmId = GetPrimaryKeyID_S(strWhereCond);
foreach (var strmId in arrmId)
{
long lngmId = long.Parse(strmId);
clscc_WorkStuRelation4CorrectBL.relatedActions.UpdRelaTabDate(lngmId, "UpdRelaTabDate");
}
}
List<string> arrCourseId = GetFldValue(concc_WorkStuRelation4Correct.CourseId, strWhereCond);
int intRecNum = cc_WorkStuRelation4CorrectDA.Delcc_WorkStuRelation4Correct(strWhereCond);
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
/// 这里仅仅是演示函数,使用时请复制到扩展类:[cc_WorkStuRelation4Correct]中改名为:[DelRecord4MultiTabEx]使用
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DelRecord4MultiTab)
/// </summary>
/// <param name="lngmId">表关键字</param>
 /// <param name = "strCourseId">缓存的分类字段</param>
/// <returns></returns>
public static bool DelRecord4MultiTab(long lngmId, string strCourseId)
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clscc_WorkStuRelation4CorrectDA.GetSpecSQLObj();
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
//删除与表:[cc_WorkStuRelation4Correct]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conStudent.id_College,
//strid_College);
//        clsStudentBL.DelStudentsByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clscc_WorkStuRelation4CorrectBL.DelRecord(lngmId, strCourseId, objConnection, objSqlTransaction);
                objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clscc_WorkStuRelation4CorrectBL", "DelRecord4MultiTab", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("删除多表记录出错:{0}!keyId = {1}.({2})",
objException.Message,
lngmId, clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "objcc_WorkStuRelation4CorrectENS">源对象</param>
 /// <param name = "objcc_WorkStuRelation4CorrectENT">目标对象</param>
 public static void CopyTo(clscc_WorkStuRelation4CorrectEN objcc_WorkStuRelation4CorrectENS, clscc_WorkStuRelation4CorrectEN objcc_WorkStuRelation4CorrectENT)
{
try
{
objcc_WorkStuRelation4CorrectENT.mId = objcc_WorkStuRelation4CorrectENS.mId; //mId
objcc_WorkStuRelation4CorrectENT.CourseId = objcc_WorkStuRelation4CorrectENS.CourseId; //课程Id
objcc_WorkStuRelation4CorrectENT.IdStudentInfo = objcc_WorkStuRelation4CorrectENS.IdStudentInfo; //学生流水号
objcc_WorkStuRelation4CorrectENT.QuestionId = objcc_WorkStuRelation4CorrectENS.QuestionId; //题目Id
objcc_WorkStuRelation4CorrectENT.RightId = objcc_WorkStuRelation4CorrectENS.RightId; //权限编号
objcc_WorkStuRelation4CorrectENT.Authorizer = objcc_WorkStuRelation4CorrectENS.Authorizer; //授权人
objcc_WorkStuRelation4CorrectENT.UpdDate = objcc_WorkStuRelation4CorrectENS.UpdDate; //修改日期
objcc_WorkStuRelation4CorrectENT.UpdUser = objcc_WorkStuRelation4CorrectENS.UpdUser; //修改人
objcc_WorkStuRelation4CorrectENT.Memo = objcc_WorkStuRelation4CorrectENS.Memo; //备注
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
 /// <param name = "objcc_WorkStuRelation4CorrectEN">源简化对象</param>
 public static void SetUpdFlag(clscc_WorkStuRelation4CorrectEN objcc_WorkStuRelation4CorrectEN)
{
try
{
objcc_WorkStuRelation4CorrectEN.ClearUpdateState();
   string strsfUpdFldSetStr = objcc_WorkStuRelation4CorrectEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(concc_WorkStuRelation4Correct.mId, new clsStrCompareIgnoreCase())  ==  true)
{
objcc_WorkStuRelation4CorrectEN.mId = objcc_WorkStuRelation4CorrectEN.mId; //mId
}
if (arrFldSet.Contains(concc_WorkStuRelation4Correct.CourseId, new clsStrCompareIgnoreCase())  ==  true)
{
objcc_WorkStuRelation4CorrectEN.CourseId = objcc_WorkStuRelation4CorrectEN.CourseId; //课程Id
}
if (arrFldSet.Contains(concc_WorkStuRelation4Correct.IdStudentInfo, new clsStrCompareIgnoreCase())  ==  true)
{
objcc_WorkStuRelation4CorrectEN.IdStudentInfo = objcc_WorkStuRelation4CorrectEN.IdStudentInfo; //学生流水号
}
if (arrFldSet.Contains(concc_WorkStuRelation4Correct.QuestionId, new clsStrCompareIgnoreCase())  ==  true)
{
objcc_WorkStuRelation4CorrectEN.QuestionId = objcc_WorkStuRelation4CorrectEN.QuestionId; //题目Id
}
if (arrFldSet.Contains(concc_WorkStuRelation4Correct.RightId, new clsStrCompareIgnoreCase())  ==  true)
{
objcc_WorkStuRelation4CorrectEN.RightId = objcc_WorkStuRelation4CorrectEN.RightId; //权限编号
}
if (arrFldSet.Contains(concc_WorkStuRelation4Correct.Authorizer, new clsStrCompareIgnoreCase())  ==  true)
{
objcc_WorkStuRelation4CorrectEN.Authorizer = objcc_WorkStuRelation4CorrectEN.Authorizer; //授权人
}
if (arrFldSet.Contains(concc_WorkStuRelation4Correct.UpdDate, new clsStrCompareIgnoreCase())  ==  true)
{
objcc_WorkStuRelation4CorrectEN.UpdDate = objcc_WorkStuRelation4CorrectEN.UpdDate == "[null]" ? null :  objcc_WorkStuRelation4CorrectEN.UpdDate; //修改日期
}
if (arrFldSet.Contains(concc_WorkStuRelation4Correct.UpdUser, new clsStrCompareIgnoreCase())  ==  true)
{
objcc_WorkStuRelation4CorrectEN.UpdUser = objcc_WorkStuRelation4CorrectEN.UpdUser == "[null]" ? null :  objcc_WorkStuRelation4CorrectEN.UpdUser; //修改人
}
if (arrFldSet.Contains(concc_WorkStuRelation4Correct.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objcc_WorkStuRelation4CorrectEN.Memo = objcc_WorkStuRelation4CorrectEN.Memo == "[null]" ? null :  objcc_WorkStuRelation4CorrectEN.Memo; //备注
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
 /// <param name = "objcc_WorkStuRelation4CorrectEN">源简化对象</param>
 public static void AccessFldValueNull(clscc_WorkStuRelation4CorrectEN objcc_WorkStuRelation4CorrectEN)
{
try
{
if (objcc_WorkStuRelation4CorrectEN.UpdDate == "[null]") objcc_WorkStuRelation4CorrectEN.UpdDate = null; //修改日期
if (objcc_WorkStuRelation4CorrectEN.UpdUser == "[null]") objcc_WorkStuRelation4CorrectEN.UpdUser = null; //修改人
if (objcc_WorkStuRelation4CorrectEN.Memo == "[null]") objcc_WorkStuRelation4CorrectEN.Memo = null; //备注
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
public static void CheckPropertyNew(clscc_WorkStuRelation4CorrectEN objcc_WorkStuRelation4CorrectEN)
{
 cc_WorkStuRelation4CorrectDA.CheckPropertyNew(objcc_WorkStuRelation4CorrectEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(clscc_WorkStuRelation4CorrectEN objcc_WorkStuRelation4CorrectEN)
{
 cc_WorkStuRelation4CorrectDA.CheckProperty4Condition(objcc_WorkStuRelation4CorrectEN);
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
if (clscc_WorkStuRelation4CorrectBL.objCommFun4BL == null)
{
strMsg = string.Format("类clscc_WorkStuRelation4CorrectBL没有刷新缓存机制(clscc_WorkStuRelation4CorrectBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by mId");
//if (arrcc_WorkStuRelation4CorrectObjLstCache == null)
//{
//arrcc_WorkStuRelation4CorrectObjLstCache = cc_WorkStuRelation4CorrectDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "lngmId">所给的关键字</param>
 /// <param name = "strCourseId">缓存的分类字段</param>
 /// <returns>根据关键字获取的对象</returns>
public static clscc_WorkStuRelation4CorrectEN GetObjBymIdCache(long lngmId, string strCourseId)
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
string strKey = string.Format("{0}_{1}", clscc_WorkStuRelation4CorrectEN._CurrTabName, strCourseId);
List<clscc_WorkStuRelation4CorrectEN> arrcc_WorkStuRelation4CorrectObjLstCache = GetObjLstCache(strCourseId);
IEnumerable <clscc_WorkStuRelation4CorrectEN> arrcc_WorkStuRelation4CorrectObjLst_Sel =
arrcc_WorkStuRelation4CorrectObjLstCache
.Where(x=> x.mId == lngmId 
);
if (arrcc_WorkStuRelation4CorrectObjLst_Sel.Count() == 0)
{
   clscc_WorkStuRelation4CorrectEN obj = clscc_WorkStuRelation4CorrectBL.GetObjBymId(lngmId);
   if (obj != null)
 {
if (obj.CourseId == strCourseId)
{
CacheHelper.Remove(strKey);
     return obj;
}
else
{
string strMsg = string.Format("错误: 关键字:{0}不属于分类:{1},请检查!(In {2})", lngmId, strCourseId, clsStackTrace.GetCurrClassFunction());
clsSysParaEN.objLog.WriteDebugLog(strMsg);
throw new Exception(strMsg);
}
 }
return null;
}
return arrcc_WorkStuRelation4CorrectObjLst_Sel.First();
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clscc_WorkStuRelation4CorrectEN> GetAllcc_WorkStuRelation4CorrectObjLstCache(string strCourseId)
{
//获取缓存中的对象列表
List<clscc_WorkStuRelation4CorrectEN> arrcc_WorkStuRelation4CorrectObjLstCache = GetObjLstCache(strCourseId); 
return arrcc_WorkStuRelation4CorrectObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clscc_WorkStuRelation4CorrectEN> GetObjLstCache(string strCourseId)
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
string strKey = string.Format("{0}_{1}", clscc_WorkStuRelation4CorrectEN._CurrTabName, strCourseId);
string strCondition = string.Format("CourseId='{0}'", strCourseId);
List<clscc_WorkStuRelation4CorrectEN> arrcc_WorkStuRelation4CorrectObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst(strCondition); });
return arrcc_WorkStuRelation4CorrectObjLstCache;
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
string strKey = string.Format("{0}_{1}", clscc_WorkStuRelation4CorrectEN._CurrTabName, strCourseId);
CacheHelper.Remove(strKey);
clscc_WorkStuRelation4CorrectEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
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
if (clscc_WorkStuRelation4CorrectEN._RefreshTimeLst.Count == 0) return "";
return clscc_WorkStuRelation4CorrectEN._RefreshTimeLst[clscc_WorkStuRelation4CorrectEN._RefreshTimeLst.Count - 1];
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
if (clscc_WorkStuRelation4CorrectBL.objCommFun4BL != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}_{1}", clscc_WorkStuRelation4CorrectEN._CurrTabName, strCourseId);
CacheHelper.Remove(strKey);
clscc_WorkStuRelation4CorrectEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
clscc_WorkStuRelation4CorrectBL.objCommFun4BL.ReFreshCache(strCourseId);
}
}


 #endregion 缓存操作


 #region 检查唯一性

 /// <summary>
 /// 获取检查唯一性条件串(Uniqueness)--cc_WorkStuRelation4Correct(学生批改作业关系)
 /// 唯一性条件:QuestionID_id_StudentInfo
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetUniquenessConditionString)
 /// </summary>
 /// <param name = "objcc_WorkStuRelation4CorrectEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(clscc_WorkStuRelation4CorrectEN objcc_WorkStuRelation4CorrectEN)
{
//检测记录是否存在
string strResult = cc_WorkStuRelation4CorrectDA.GetUniCondStr(objcc_WorkStuRelation4CorrectEN);
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
public static string Func(string strInFldName, string strOutFldName, long lngmId, string strCourseId)
{
if (strInFldName != concc_WorkStuRelation4Correct.mId)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (concc_WorkStuRelation4Correct.AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", concc_WorkStuRelation4Correct.AttributeName));
throw new Exception(strMsg);
}
var objcc_WorkStuRelation4Correct = clscc_WorkStuRelation4CorrectBL.GetObjBymIdCache(lngmId, strCourseId);
if (objcc_WorkStuRelation4Correct == null) return "";
return objcc_WorkStuRelation4Correct[strOutFldName].ToString();
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
int intRecCount = clscc_WorkStuRelation4CorrectDA.GetRecCount(strTabName);
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
int intRecCount = clscc_WorkStuRelation4CorrectDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clscc_WorkStuRelation4CorrectDA.GetRecCount();
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
int intRecCount = clscc_WorkStuRelation4CorrectDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objcc_WorkStuRelation4CorrectCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clscc_WorkStuRelation4CorrectEN objcc_WorkStuRelation4CorrectCond)
{
 string strCourseId = objcc_WorkStuRelation4CorrectCond.CourseId;
 if (string.IsNullOrEmpty(strCourseId) == true)
{
string strMsg = string.Format("(errid:Busi000174)在表中,缓存分类字段值不能为空!(clscc_WorkStuRelation4CorrectBL:GetRecCountByCondCache)");
throw new Exception(strMsg);
}
List<clscc_WorkStuRelation4CorrectEN> arrObjLstCache = GetObjLstCache(strCourseId);
IEnumerable <clscc_WorkStuRelation4CorrectEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in concc_WorkStuRelation4Correct.AttributeName)
{
if (objcc_WorkStuRelation4CorrectCond.IsUpdated(strFldName) == false) continue;
if (objcc_WorkStuRelation4CorrectCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objcc_WorkStuRelation4CorrectCond[strFldName].ToString());
}
else
{
if (objcc_WorkStuRelation4CorrectCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objcc_WorkStuRelation4CorrectCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objcc_WorkStuRelation4CorrectCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objcc_WorkStuRelation4CorrectCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objcc_WorkStuRelation4CorrectCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objcc_WorkStuRelation4CorrectCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objcc_WorkStuRelation4CorrectCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objcc_WorkStuRelation4CorrectCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objcc_WorkStuRelation4CorrectCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objcc_WorkStuRelation4CorrectCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objcc_WorkStuRelation4CorrectCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objcc_WorkStuRelation4CorrectCond[strFldName]));
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
 List<string> arrList = clscc_WorkStuRelation4CorrectDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = cc_WorkStuRelation4CorrectDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = cc_WorkStuRelation4CorrectDA.GetFldValueNoDistinct(strFldName, strWhereCond);
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
int intRecCount = cc_WorkStuRelation4CorrectDA.SetFldValue(strFldName, strValue, strWhereCond);
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
int intRecCount = clscc_WorkStuRelation4CorrectDA.SetFldValue(clscc_WorkStuRelation4CorrectEN._CurrTabName, strFldName, fltValue, strWhereCond);
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
int intRecCount = cc_WorkStuRelation4CorrectDA.SetFldValue( strFldName, intValue, strWhereCond);
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
int intRecCount = clscc_WorkStuRelation4CorrectDA.SetFldValue(strTabName, strFldName, strValue, strWhereCond);
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
int intRecCount = clscc_WorkStuRelation4CorrectDA.SetFldValue(strTabName, strFldName, intValue, strWhereCond);
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
int intRecCount = clscc_WorkStuRelation4CorrectDA.SetFldValue(strTabName, strFldName, fltValue, strWhereCond);
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
  strCreateTabCode.Append("CREATE table [dbo].[cc_WorkStuRelation4Correct] "); 
 strCreateTabCode.Append(" ( "); 
 // /**mId*/ 
 strCreateTabCode.Append(" mId bigint primary key identity, "); 
 // /**课程Id*/ 
 strCreateTabCode.Append(" CourseId char(8) not Null, "); 
 // /**学生流水号*/ 
 strCreateTabCode.Append(" IdStudentInfo char(8) not Null, "); 
 // /**题目Id*/ 
 strCreateTabCode.Append(" QuestionId bigint not Null, "); 
 // /**权限编号*/ 
 strCreateTabCode.Append(" RightId char(8) not Null, "); 
 // /**授权人*/ 
 strCreateTabCode.Append(" Authorizer varchar(18) not Null, "); 
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
 /// 学生批改作业关系(cc_WorkStuRelation4Correct)
 /// 数据源类型:表
 /// (AutoGCLib.CommFun4BL4CSharp:GeneCode_This)
 /// </summary>
public class  clsCommFun4BL4cc_WorkStuRelation4Correct : clsCommFun4BLV2
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
clscc_WorkStuRelation4CorrectBL.ReFreshThisCache(strCourseId);
}
}

}