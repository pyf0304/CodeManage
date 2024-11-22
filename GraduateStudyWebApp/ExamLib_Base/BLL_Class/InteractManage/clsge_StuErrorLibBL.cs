
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsge_StuErrorLibBL
 表名:ge_StuErrorLib(01120887)
 * 版本:2024.11.13.1(服务器:WIN-SRV103-116)
 日期:2024/11/13 06:00:38
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
public static class  clsge_StuErrorLibBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public static clsge_StuErrorLibEN GetObj(this K_mId_ge_StuErrorLib myKey)
{
clsge_StuErrorLibEN objge_StuErrorLibEN = clsge_StuErrorLibBL.ge_StuErrorLibDA.GetObjBymId(myKey.Value);
return objge_StuErrorLibEN;
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_AddNewRecord)
 /// </summary>
 /// <param name = "objge_StuErrorLibEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clsge_StuErrorLibEN objge_StuErrorLibEN, bool bolIsNeedCheckUniqueness = true)
{
if (bolIsNeedCheckUniqueness == true && CheckUniqueness(objge_StuErrorLibEN) == false)
{
var strMsg = string.Format("记录已经存在!学生流水号 = [{0}],题目Id = [{1}]的数据已经存在!(in clsge_StuErrorLibBL.AddNewRecord)", objge_StuErrorLibEN.IdStudentInfo,objge_StuErrorLibEN.QuestionId);
throw new Exception(strMsg);
}
try
{
bool bolResult = clsge_StuErrorLibBL.ge_StuErrorLibDA.AddNewRecordBySQL2(objge_StuErrorLibEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsge_StuErrorLibBL.ReFreshCache(objge_StuErrorLibEN.CourseId, objge_StuErrorLibEN.IdStudentInfo);

if (clsge_StuErrorLibBL.relatedActions != null)
{
clsge_StuErrorLibBL.relatedActions.UpdRelaTabDate(objge_StuErrorLibEN.mId, objge_StuErrorLibEN.UpdUser);
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
public static bool AddRecordEx(this clsge_StuErrorLibEN objge_StuErrorLibEN, bool bolIsNeedCheckUniqueness = true)
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
objge_StuErrorLibEN.CheckPropertyNew();
 ///5.2、检查唯一性
if (bolIsNeedCheckUniqueness == true && objge_StuErrorLibEN.CheckUniqueness() == false)
{
strMsg = string.Format("(学生流水号(IdStudentInfo)=[{0}],题目Id(QuestionId)=[{1}])已经存在,不能重复!", objge_StuErrorLibEN.IdStudentInfo, objge_StuErrorLibEN.QuestionId);
throw new Exception(strMsg);
}
//6、把数据实体层的数据存贮到数据库中
objge_StuErrorLibEN.AddNewRecord();
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
 /// <param name = "objge_StuErrorLibEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordWithReturnKey(this clsge_StuErrorLibEN objge_StuErrorLibEN, bool bolIsNeedCheckUniqueness = true)
{
if (bolIsNeedCheckUniqueness == true && CheckUniqueness(objge_StuErrorLibEN) == false)
{
var strMsg = string.Format("记录已经存在!学生流水号 = [{0}],题目Id = [{1}]的数据已经存在!(in clsge_StuErrorLibBL.AddNewRecordWithReturnKey)", objge_StuErrorLibEN.IdStudentInfo,objge_StuErrorLibEN.QuestionId);
throw new Exception(strMsg);
}
try
{
string strKey = clsge_StuErrorLibBL.ge_StuErrorLibDA.AddNewRecordBySQL2WithReturnKey(objge_StuErrorLibEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsge_StuErrorLibBL.ReFreshCache(objge_StuErrorLibEN.CourseId, objge_StuErrorLibEN.IdStudentInfo);

if (clsge_StuErrorLibBL.relatedActions != null)
{
clsge_StuErrorLibBL.relatedActions.UpdRelaTabDate(objge_StuErrorLibEN.mId, objge_StuErrorLibEN.UpdUser);
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
 /// <param name = "objge_StuErrorLibEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsge_StuErrorLibEN SetmId(this clsge_StuErrorLibEN objge_StuErrorLibEN, long lngmId, string strComparisonOp="")
	{
objge_StuErrorLibEN.mId = lngmId; //mId
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objge_StuErrorLibEN.dicFldComparisonOp.ContainsKey(conge_StuErrorLib.mId) == false)
{
objge_StuErrorLibEN.dicFldComparisonOp.Add(conge_StuErrorLib.mId, strComparisonOp);
}
else
{
objge_StuErrorLibEN.dicFldComparisonOp[conge_StuErrorLib.mId] = strComparisonOp;
}
}
return objge_StuErrorLibEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objge_StuErrorLibEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsge_StuErrorLibEN SetCourseId(this clsge_StuErrorLibEN objge_StuErrorLibEN, string strCourseId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strCourseId, conge_StuErrorLib.CourseId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCourseId, 8, conge_StuErrorLib.CourseId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strCourseId, 8, conge_StuErrorLib.CourseId);
}
objge_StuErrorLibEN.CourseId = strCourseId; //课程Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objge_StuErrorLibEN.dicFldComparisonOp.ContainsKey(conge_StuErrorLib.CourseId) == false)
{
objge_StuErrorLibEN.dicFldComparisonOp.Add(conge_StuErrorLib.CourseId, strComparisonOp);
}
else
{
objge_StuErrorLibEN.dicFldComparisonOp[conge_StuErrorLib.CourseId] = strComparisonOp;
}
}
return objge_StuErrorLibEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objge_StuErrorLibEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsge_StuErrorLibEN SetIdStudentInfo(this clsge_StuErrorLibEN objge_StuErrorLibEN, string strIdStudentInfo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strIdStudentInfo, conge_StuErrorLib.IdStudentInfo);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdStudentInfo, 8, conge_StuErrorLib.IdStudentInfo);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdStudentInfo, 8, conge_StuErrorLib.IdStudentInfo);
}
objge_StuErrorLibEN.IdStudentInfo = strIdStudentInfo; //学生流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objge_StuErrorLibEN.dicFldComparisonOp.ContainsKey(conge_StuErrorLib.IdStudentInfo) == false)
{
objge_StuErrorLibEN.dicFldComparisonOp.Add(conge_StuErrorLib.IdStudentInfo, strComparisonOp);
}
else
{
objge_StuErrorLibEN.dicFldComparisonOp[conge_StuErrorLib.IdStudentInfo] = strComparisonOp;
}
}
return objge_StuErrorLibEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objge_StuErrorLibEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsge_StuErrorLibEN SetQuestionId(this clsge_StuErrorLibEN objge_StuErrorLibEN, long lngQuestionId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(lngQuestionId, conge_StuErrorLib.QuestionId);
objge_StuErrorLibEN.QuestionId = lngQuestionId; //题目Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objge_StuErrorLibEN.dicFldComparisonOp.ContainsKey(conge_StuErrorLib.QuestionId) == false)
{
objge_StuErrorLibEN.dicFldComparisonOp.Add(conge_StuErrorLib.QuestionId, strComparisonOp);
}
else
{
objge_StuErrorLibEN.dicFldComparisonOp[conge_StuErrorLib.QuestionId] = strComparisonOp;
}
}
return objge_StuErrorLibEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objge_StuErrorLibEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsge_StuErrorLibEN SetCreator(this clsge_StuErrorLibEN objge_StuErrorLibEN, string strCreator, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCreator, 18, conge_StuErrorLib.Creator);
}
objge_StuErrorLibEN.Creator = strCreator; //创建者
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objge_StuErrorLibEN.dicFldComparisonOp.ContainsKey(conge_StuErrorLib.Creator) == false)
{
objge_StuErrorLibEN.dicFldComparisonOp.Add(conge_StuErrorLib.Creator, strComparisonOp);
}
else
{
objge_StuErrorLibEN.dicFldComparisonOp[conge_StuErrorLib.Creator] = strComparisonOp;
}
}
return objge_StuErrorLibEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objge_StuErrorLibEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsge_StuErrorLibEN SetCreateDate(this clsge_StuErrorLibEN objge_StuErrorLibEN, string strCreateDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCreateDate, 20, conge_StuErrorLib.CreateDate);
}
objge_StuErrorLibEN.CreateDate = strCreateDate; //建立日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objge_StuErrorLibEN.dicFldComparisonOp.ContainsKey(conge_StuErrorLib.CreateDate) == false)
{
objge_StuErrorLibEN.dicFldComparisonOp.Add(conge_StuErrorLib.CreateDate, strComparisonOp);
}
else
{
objge_StuErrorLibEN.dicFldComparisonOp[conge_StuErrorLib.CreateDate] = strComparisonOp;
}
}
return objge_StuErrorLibEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objge_StuErrorLibEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsge_StuErrorLibEN SetSourceTypeId(this clsge_StuErrorLibEN objge_StuErrorLibEN, string strSourceTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strSourceTypeId, conge_StuErrorLib.SourceTypeId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strSourceTypeId, 2, conge_StuErrorLib.SourceTypeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strSourceTypeId, 2, conge_StuErrorLib.SourceTypeId);
}
objge_StuErrorLibEN.SourceTypeId = strSourceTypeId; //来源类型Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objge_StuErrorLibEN.dicFldComparisonOp.ContainsKey(conge_StuErrorLib.SourceTypeId) == false)
{
objge_StuErrorLibEN.dicFldComparisonOp.Add(conge_StuErrorLib.SourceTypeId, strComparisonOp);
}
else
{
objge_StuErrorLibEN.dicFldComparisonOp[conge_StuErrorLib.SourceTypeId] = strComparisonOp;
}
}
return objge_StuErrorLibEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objge_StuErrorLibEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsge_StuErrorLibEN SetIsRedo(this clsge_StuErrorLibEN objge_StuErrorLibEN, bool bolIsRedo, string strComparisonOp="")
	{
objge_StuErrorLibEN.IsRedo = bolIsRedo; //是否重做
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objge_StuErrorLibEN.dicFldComparisonOp.ContainsKey(conge_StuErrorLib.IsRedo) == false)
{
objge_StuErrorLibEN.dicFldComparisonOp.Add(conge_StuErrorLib.IsRedo, strComparisonOp);
}
else
{
objge_StuErrorLibEN.dicFldComparisonOp[conge_StuErrorLib.IsRedo] = strComparisonOp;
}
}
return objge_StuErrorLibEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objge_StuErrorLibEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsge_StuErrorLibEN SetRedoDate(this clsge_StuErrorLibEN objge_StuErrorLibEN, string strRedoDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strRedoDate, 8, conge_StuErrorLib.RedoDate);
}
objge_StuErrorLibEN.RedoDate = strRedoDate; //重做日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objge_StuErrorLibEN.dicFldComparisonOp.ContainsKey(conge_StuErrorLib.RedoDate) == false)
{
objge_StuErrorLibEN.dicFldComparisonOp.Add(conge_StuErrorLib.RedoDate, strComparisonOp);
}
else
{
objge_StuErrorLibEN.dicFldComparisonOp[conge_StuErrorLib.RedoDate] = strComparisonOp;
}
}
return objge_StuErrorLibEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objge_StuErrorLibEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsge_StuErrorLibEN SetIsPassed(this clsge_StuErrorLibEN objge_StuErrorLibEN, bool bolIsPassed, string strComparisonOp="")
	{
objge_StuErrorLibEN.IsPassed = bolIsPassed; //是否通过
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objge_StuErrorLibEN.dicFldComparisonOp.ContainsKey(conge_StuErrorLib.IsPassed) == false)
{
objge_StuErrorLibEN.dicFldComparisonOp.Add(conge_StuErrorLib.IsPassed, strComparisonOp);
}
else
{
objge_StuErrorLibEN.dicFldComparisonOp[conge_StuErrorLib.IsPassed] = strComparisonOp;
}
}
return objge_StuErrorLibEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objge_StuErrorLibEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsge_StuErrorLibEN SetUpdDate(this clsge_StuErrorLibEN objge_StuErrorLibEN, string strUpdDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdDate, 20, conge_StuErrorLib.UpdDate);
}
objge_StuErrorLibEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objge_StuErrorLibEN.dicFldComparisonOp.ContainsKey(conge_StuErrorLib.UpdDate) == false)
{
objge_StuErrorLibEN.dicFldComparisonOp.Add(conge_StuErrorLib.UpdDate, strComparisonOp);
}
else
{
objge_StuErrorLibEN.dicFldComparisonOp[conge_StuErrorLib.UpdDate] = strComparisonOp;
}
}
return objge_StuErrorLibEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objge_StuErrorLibEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsge_StuErrorLibEN SetUpdUser(this clsge_StuErrorLibEN objge_StuErrorLibEN, string strUpdUser, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdUser, 20, conge_StuErrorLib.UpdUser);
}
objge_StuErrorLibEN.UpdUser = strUpdUser; //修改人
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objge_StuErrorLibEN.dicFldComparisonOp.ContainsKey(conge_StuErrorLib.UpdUser) == false)
{
objge_StuErrorLibEN.dicFldComparisonOp.Add(conge_StuErrorLib.UpdUser, strComparisonOp);
}
else
{
objge_StuErrorLibEN.dicFldComparisonOp[conge_StuErrorLib.UpdUser] = strComparisonOp;
}
}
return objge_StuErrorLibEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objge_StuErrorLibEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsge_StuErrorLibEN SetMemo(this clsge_StuErrorLibEN objge_StuErrorLibEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, conge_StuErrorLib.Memo);
}
objge_StuErrorLibEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objge_StuErrorLibEN.dicFldComparisonOp.ContainsKey(conge_StuErrorLib.Memo) == false)
{
objge_StuErrorLibEN.dicFldComparisonOp.Add(conge_StuErrorLib.Memo, strComparisonOp);
}
else
{
objge_StuErrorLibEN.dicFldComparisonOp[conge_StuErrorLib.Memo] = strComparisonOp;
}
}
return objge_StuErrorLibEN;
	}

 /// <summary>
 /// 修改记录存盘到数据表中
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_UpdateRecordEx)
 /// </summary>
 /// <param name = "objge_StuErrorLibEN">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool UpdateRecordEx(this clsge_StuErrorLibEN objge_StuErrorLibEN)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
try
{
//1、检查传进去的对象属性是否合法
objge_StuErrorLibEN.CheckPropertyNew();
clsge_StuErrorLibEN objge_StuErrorLibCond = new clsge_StuErrorLibEN();
string strCondition = objge_StuErrorLibCond
.SetmId(objge_StuErrorLibEN.mId, "<>")
.SetIdStudentInfo(objge_StuErrorLibEN.IdStudentInfo, "=")
.SetQuestionId(objge_StuErrorLibEN.QuestionId, "=")
.GetCombineCondition();
objge_StuErrorLibEN._IsCheckProperty = true;
bool bolIsExist = clsge_StuErrorLibBL.IsExistRecord(strCondition);
if (bolIsExist)
{
strMsg = "(id_StudentInfo_QuestionID)不能重复!";
throw new Exception(strMsg);
}
//4、把数据实体层的数据存贮到数据库中
objge_StuErrorLibEN.Update();
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
 /// <param name = "objge_StuErrorLib">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool EditRecordEx(this clsge_StuErrorLibEN objge_StuErrorLib)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
clsge_StuErrorLibEN objge_StuErrorLibCond = new clsge_StuErrorLibEN();
string strCondition = objge_StuErrorLibCond
.SetIdStudentInfo(objge_StuErrorLib.IdStudentInfo, "=")
.SetQuestionId(objge_StuErrorLib.QuestionId, "=")
.GetCombineCondition();
objge_StuErrorLib._IsCheckProperty = true;
bool bolIsExist = clsge_StuErrorLibBL.IsExistRecord(strCondition);
if (bolIsExist)
{
objge_StuErrorLib.mId = clsge_StuErrorLibBL.GetFirstID_S(strCondition);
objge_StuErrorLib.UpdateWithCondition(strCondition);
}
else
{
objge_StuErrorLib.AddNewRecord();
}
return true; 
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_Update)
 /// </summary>
 /// <param name = "objge_StuErrorLibEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsge_StuErrorLibEN objge_StuErrorLibEN)
{
 if (objge_StuErrorLibEN.mId == 0)
 {
string strMsg = string.Format("(errid:Busi000095)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsge_StuErrorLibBL.ge_StuErrorLibDA.UpdateBySql2(objge_StuErrorLibEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsge_StuErrorLibBL.ReFreshCache(objge_StuErrorLibEN.CourseId, objge_StuErrorLibEN.IdStudentInfo);

if (clsge_StuErrorLibBL.relatedActions != null)
{
clsge_StuErrorLibBL.relatedActions.UpdRelaTabDate(objge_StuErrorLibEN.mId, objge_StuErrorLibEN.UpdUser);
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
 /// <param name = "objge_StuErrorLibEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsge_StuErrorLibEN objge_StuErrorLibEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (objge_StuErrorLibEN.mId == 0)
 {
string strMsg = string.Format("(errid:Busi000087)修改记录时关键字不能为空!(带事务处理)(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsge_StuErrorLibBL.ge_StuErrorLibDA.UpdateBySql2(objge_StuErrorLibEN, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsge_StuErrorLibBL.ReFreshCache(objge_StuErrorLibEN.CourseId, objge_StuErrorLibEN.IdStudentInfo);

if (clsge_StuErrorLibBL.relatedActions != null)
{
clsge_StuErrorLibBL.relatedActions.UpdRelaTabDate(objge_StuErrorLibEN.mId, objge_StuErrorLibEN.UpdUser);
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
 /// <param name = "objge_StuErrorLibEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsge_StuErrorLibEN objge_StuErrorLibEN, string strWhereCond)
{
try
{
bool bolResult = clsge_StuErrorLibBL.ge_StuErrorLibDA.UpdateBySqlWithCondition(objge_StuErrorLibEN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsge_StuErrorLibBL.ReFreshCache(objge_StuErrorLibEN.CourseId, objge_StuErrorLibEN.IdStudentInfo);

if (clsge_StuErrorLibBL.relatedActions != null)
{
clsge_StuErrorLibBL.relatedActions.UpdRelaTabDate(objge_StuErrorLibEN.mId, objge_StuErrorLibEN.UpdUser);
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
 /// <param name = "objge_StuErrorLibEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsge_StuErrorLibEN objge_StuErrorLibEN, string strWhereCond, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
bool bolResult = clsge_StuErrorLibBL.ge_StuErrorLibDA.UpdateBySqlWithConditionTransaction(objge_StuErrorLibEN, strWhereCond, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsge_StuErrorLibBL.ReFreshCache(objge_StuErrorLibEN.CourseId, objge_StuErrorLibEN.IdStudentInfo);

if (clsge_StuErrorLibBL.relatedActions != null)
{
clsge_StuErrorLibBL.relatedActions.UpdRelaTabDate(objge_StuErrorLibEN.mId, objge_StuErrorLibEN.UpdUser);
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
public static int Delete(this clsge_StuErrorLibEN objge_StuErrorLibEN)
{
try
{
int intRecNum = clsge_StuErrorLibBL.ge_StuErrorLibDA.DelRecord(objge_StuErrorLibEN.mId);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsge_StuErrorLibBL.ReFreshCache(objge_StuErrorLibEN.CourseId, objge_StuErrorLibEN.IdStudentInfo);

if (clsge_StuErrorLibBL.relatedActions != null)
{
clsge_StuErrorLibBL.relatedActions.UpdRelaTabDate(objge_StuErrorLibEN.mId, objge_StuErrorLibEN.UpdUser);
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
 /// <param name = "objge_StuErrorLibENS">源对象</param>
 /// <param name = "objge_StuErrorLibENT">目标对象</param>
 public static void CopyTo(this clsge_StuErrorLibEN objge_StuErrorLibENS, clsge_StuErrorLibEN objge_StuErrorLibENT)
{
try
{
objge_StuErrorLibENT.mId = objge_StuErrorLibENS.mId; //mId
objge_StuErrorLibENT.CourseId = objge_StuErrorLibENS.CourseId; //课程Id
objge_StuErrorLibENT.IdStudentInfo = objge_StuErrorLibENS.IdStudentInfo; //学生流水号
objge_StuErrorLibENT.QuestionId = objge_StuErrorLibENS.QuestionId; //题目Id
objge_StuErrorLibENT.Creator = objge_StuErrorLibENS.Creator; //创建者
objge_StuErrorLibENT.CreateDate = objge_StuErrorLibENS.CreateDate; //建立日期
objge_StuErrorLibENT.SourceTypeId = objge_StuErrorLibENS.SourceTypeId; //来源类型Id
objge_StuErrorLibENT.IsRedo = objge_StuErrorLibENS.IsRedo; //是否重做
objge_StuErrorLibENT.RedoDate = objge_StuErrorLibENS.RedoDate; //重做日期
objge_StuErrorLibENT.IsPassed = objge_StuErrorLibENS.IsPassed; //是否通过
objge_StuErrorLibENT.UpdDate = objge_StuErrorLibENS.UpdDate; //修改日期
objge_StuErrorLibENT.UpdUser = objge_StuErrorLibENS.UpdUser; //修改人
objge_StuErrorLibENT.Memo = objge_StuErrorLibENS.Memo; //备注
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
 /// <param name = "objge_StuErrorLibENS">源对象</param>
 /// <returns>目标对象=>clsge_StuErrorLibEN:objge_StuErrorLibENT</returns>
 public static clsge_StuErrorLibEN CopyTo(this clsge_StuErrorLibEN objge_StuErrorLibENS)
{
try
{
 clsge_StuErrorLibEN objge_StuErrorLibENT = new clsge_StuErrorLibEN()
{
mId = objge_StuErrorLibENS.mId, //mId
CourseId = objge_StuErrorLibENS.CourseId, //课程Id
IdStudentInfo = objge_StuErrorLibENS.IdStudentInfo, //学生流水号
QuestionId = objge_StuErrorLibENS.QuestionId, //题目Id
Creator = objge_StuErrorLibENS.Creator, //创建者
CreateDate = objge_StuErrorLibENS.CreateDate, //建立日期
SourceTypeId = objge_StuErrorLibENS.SourceTypeId, //来源类型Id
IsRedo = objge_StuErrorLibENS.IsRedo, //是否重做
RedoDate = objge_StuErrorLibENS.RedoDate, //重做日期
IsPassed = objge_StuErrorLibENS.IsPassed, //是否通过
UpdDate = objge_StuErrorLibENS.UpdDate, //修改日期
UpdUser = objge_StuErrorLibENS.UpdUser, //修改人
Memo = objge_StuErrorLibENS.Memo, //备注
};
 return objge_StuErrorLibENT;
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
public static void CheckPropertyNew(this clsge_StuErrorLibEN objge_StuErrorLibEN)
{
 clsge_StuErrorLibBL.ge_StuErrorLibDA.CheckPropertyNew(objge_StuErrorLibEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(this clsge_StuErrorLibEN objge_StuErrorLibEN)
{
 clsge_StuErrorLibBL.ge_StuErrorLibDA.CheckProperty4Condition(objge_StuErrorLibEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsge_StuErrorLibEN objge_StuErrorLibCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objge_StuErrorLibCond.IsUpdated(conge_StuErrorLib.mId) == true)
{
string strComparisonOpmId = objge_StuErrorLibCond.dicFldComparisonOp[conge_StuErrorLib.mId];
strWhereCond += string.Format(" And {0} {2} {1}", conge_StuErrorLib.mId, objge_StuErrorLibCond.mId, strComparisonOpmId);
}
if (objge_StuErrorLibCond.IsUpdated(conge_StuErrorLib.CourseId) == true)
{
string strComparisonOpCourseId = objge_StuErrorLibCond.dicFldComparisonOp[conge_StuErrorLib.CourseId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conge_StuErrorLib.CourseId, objge_StuErrorLibCond.CourseId, strComparisonOpCourseId);
}
if (objge_StuErrorLibCond.IsUpdated(conge_StuErrorLib.IdStudentInfo) == true)
{
string strComparisonOpIdStudentInfo = objge_StuErrorLibCond.dicFldComparisonOp[conge_StuErrorLib.IdStudentInfo];
strWhereCond += string.Format(" And {0} {2} '{1}'", conge_StuErrorLib.IdStudentInfo, objge_StuErrorLibCond.IdStudentInfo, strComparisonOpIdStudentInfo);
}
if (objge_StuErrorLibCond.IsUpdated(conge_StuErrorLib.QuestionId) == true)
{
string strComparisonOpQuestionId = objge_StuErrorLibCond.dicFldComparisonOp[conge_StuErrorLib.QuestionId];
strWhereCond += string.Format(" And {0} {2} {1}", conge_StuErrorLib.QuestionId, objge_StuErrorLibCond.QuestionId, strComparisonOpQuestionId);
}
if (objge_StuErrorLibCond.IsUpdated(conge_StuErrorLib.Creator) == true)
{
string strComparisonOpCreator = objge_StuErrorLibCond.dicFldComparisonOp[conge_StuErrorLib.Creator];
strWhereCond += string.Format(" And {0} {2} '{1}'", conge_StuErrorLib.Creator, objge_StuErrorLibCond.Creator, strComparisonOpCreator);
}
if (objge_StuErrorLibCond.IsUpdated(conge_StuErrorLib.CreateDate) == true)
{
string strComparisonOpCreateDate = objge_StuErrorLibCond.dicFldComparisonOp[conge_StuErrorLib.CreateDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conge_StuErrorLib.CreateDate, objge_StuErrorLibCond.CreateDate, strComparisonOpCreateDate);
}
if (objge_StuErrorLibCond.IsUpdated(conge_StuErrorLib.SourceTypeId) == true)
{
string strComparisonOpSourceTypeId = objge_StuErrorLibCond.dicFldComparisonOp[conge_StuErrorLib.SourceTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conge_StuErrorLib.SourceTypeId, objge_StuErrorLibCond.SourceTypeId, strComparisonOpSourceTypeId);
}
if (objge_StuErrorLibCond.IsUpdated(conge_StuErrorLib.IsRedo) == true)
{
if (objge_StuErrorLibCond.IsRedo == true)
{
strWhereCond += string.Format(" And {0} = '1'", conge_StuErrorLib.IsRedo);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conge_StuErrorLib.IsRedo);
}
}
if (objge_StuErrorLibCond.IsUpdated(conge_StuErrorLib.RedoDate) == true)
{
string strComparisonOpRedoDate = objge_StuErrorLibCond.dicFldComparisonOp[conge_StuErrorLib.RedoDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conge_StuErrorLib.RedoDate, objge_StuErrorLibCond.RedoDate, strComparisonOpRedoDate);
}
if (objge_StuErrorLibCond.IsUpdated(conge_StuErrorLib.IsPassed) == true)
{
if (objge_StuErrorLibCond.IsPassed == true)
{
strWhereCond += string.Format(" And {0} = '1'", conge_StuErrorLib.IsPassed);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conge_StuErrorLib.IsPassed);
}
}
if (objge_StuErrorLibCond.IsUpdated(conge_StuErrorLib.UpdDate) == true)
{
string strComparisonOpUpdDate = objge_StuErrorLibCond.dicFldComparisonOp[conge_StuErrorLib.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conge_StuErrorLib.UpdDate, objge_StuErrorLibCond.UpdDate, strComparisonOpUpdDate);
}
if (objge_StuErrorLibCond.IsUpdated(conge_StuErrorLib.UpdUser) == true)
{
string strComparisonOpUpdUser = objge_StuErrorLibCond.dicFldComparisonOp[conge_StuErrorLib.UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", conge_StuErrorLib.UpdUser, objge_StuErrorLibCond.UpdUser, strComparisonOpUpdUser);
}
if (objge_StuErrorLibCond.IsUpdated(conge_StuErrorLib.Memo) == true)
{
string strComparisonOpMemo = objge_StuErrorLibCond.dicFldComparisonOp[conge_StuErrorLib.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", conge_StuErrorLib.Memo, objge_StuErrorLibCond.Memo, strComparisonOpMemo);
}
 return strWhereCond;
}

 /// <summary>
 /// 检查唯一性(Uniqueness)--ge_StuErrorLib(学生错误作业集), 如果不唯一,即存在相同的记录,就返回False
 /// 唯一性条件:IdStudentInfo_QuestionId
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckConstraint)
 /// </summary>
 /// <param name = "objge_StuErrorLibEN">要求唯一的对象</param>
 /// <returns></returns>
public static bool CheckUniqueness(this clsge_StuErrorLibEN objge_StuErrorLibEN)
{
//检测记录是否存在
bool bolIsUniqueness;
StringBuilder sbCondition = new StringBuilder();
if (objge_StuErrorLibEN == null) return true;
if (objge_StuErrorLibEN.mId == 0)
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and IdStudentInfo = '{0}'", objge_StuErrorLibEN.IdStudentInfo);
 sbCondition.AppendFormat(" and QuestionId = '{0}'", objge_StuErrorLibEN.QuestionId);
if (clsge_StuErrorLibBL.IsExistRecord(sbCondition.ToString())  ==  true)
{
 bolIsUniqueness = false;
}
else
{
 bolIsUniqueness = true;
}
}
 else {
sbCondition.AppendFormat("mId !=  {0}", objge_StuErrorLibEN.mId);
 sbCondition.AppendFormat(" and IdStudentInfo = '{0}'", objge_StuErrorLibEN.IdStudentInfo);
 sbCondition.AppendFormat(" and QuestionId = '{0}'", objge_StuErrorLibEN.QuestionId);
if (clsge_StuErrorLibBL.IsExistRecord(sbCondition.ToString())  ==  true)
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
 /// 获取唯一性条件串--ge_StuErrorLib(学生错误作业集), 即由对象中唯一性条件字段关键字与值组成的条件串
 /// 唯一性条件:IdStudentInfo_QuestionId
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetConditionString4Constraint)
 /// </summary>
 /// <param name = "objge_StuErrorLibEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(this clsge_StuErrorLibEN objge_StuErrorLibEN)
{
//检测记录是否存在
StringBuilder sbCondition = new StringBuilder();
if (objge_StuErrorLibEN == null) return "";
if (objge_StuErrorLibEN.mId == 0)
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and IdStudentInfo = '{0}'", objge_StuErrorLibEN.IdStudentInfo);
 sbCondition.AppendFormat(" and QuestionId = '{0}'", objge_StuErrorLibEN.QuestionId);
return sbCondition.ToString();
}
 else {
sbCondition.AppendFormat("mId !=  {0}", objge_StuErrorLibEN.mId);
 sbCondition.AppendFormat(" and IdStudentInfo = '{0}'", objge_StuErrorLibEN.IdStudentInfo);
 sbCondition.AppendFormat(" and QuestionId = '{0}'", objge_StuErrorLibEN.QuestionId);
 return sbCondition.ToString();
}
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_ge_StuErrorLib
{
public virtual bool UpdRelaTabDate(long lngmId, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// 学生错误作业集(ge_StuErrorLib)
 /// 数据源类型:表
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsge_StuErrorLibBL
{
public static RelatedActions_ge_StuErrorLib relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsge_StuErrorLibDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsge_StuErrorLibDA ge_StuErrorLibDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsge_StuErrorLibDA();
}
return uniqueInstance;
}
}

 /// <summary>
/// 专门在逻辑层用于处理缓存等公共函数的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineObjCommFun4BL)
/// </summary>
public static clsCommFun4BLV3 objCommFun4BL = null;

 /// <summary>
 /// 类的构造函数
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ClassConstructor1)
 /// </summary>
 public clsge_StuErrorLibBL()
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
if (string.IsNullOrEmpty(clsge_StuErrorLibEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsge_StuErrorLibEN._ConnectString);
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
public static DataTable GetDataTable_ge_StuErrorLib(string strWhereCond)
{
DataTable objDT;
try
{
objDT = ge_StuErrorLibDA.GetDataTable_ge_StuErrorLib(strWhereCond);
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
objDT = ge_StuErrorLibDA.GetDataTable(strWhereCond);
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
objDT = ge_StuErrorLibDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = ge_StuErrorLibDA.GetDataTable(strWhereCond, strTabName);
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
objDT = ge_StuErrorLibDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = ge_StuErrorLibDA.GetDataTable_Top(objTopPara);
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
objDT = ge_StuErrorLibDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = ge_StuErrorLibDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = ge_StuErrorLibDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
public static List<clsge_StuErrorLibEN> GetObjLstByMIdLst(List<long> arrMIdLst)
{
List<clsge_StuErrorLibEN> arrObjLst = new List<clsge_StuErrorLibEN>(); 
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
	clsge_StuErrorLibEN objge_StuErrorLibEN = new clsge_StuErrorLibEN();
try
{
objge_StuErrorLibEN.mId = Int32.Parse(objRow[conge_StuErrorLib.mId].ToString().Trim()); //mId
objge_StuErrorLibEN.CourseId = objRow[conge_StuErrorLib.CourseId].ToString().Trim(); //课程Id
objge_StuErrorLibEN.IdStudentInfo = objRow[conge_StuErrorLib.IdStudentInfo].ToString().Trim(); //学生流水号
objge_StuErrorLibEN.QuestionId = Int32.Parse(objRow[conge_StuErrorLib.QuestionId].ToString().Trim()); //题目Id
objge_StuErrorLibEN.Creator = objRow[conge_StuErrorLib.Creator] == DBNull.Value ? null : objRow[conge_StuErrorLib.Creator].ToString().Trim(); //创建者
objge_StuErrorLibEN.CreateDate = objRow[conge_StuErrorLib.CreateDate] == DBNull.Value ? null : objRow[conge_StuErrorLib.CreateDate].ToString().Trim(); //建立日期
objge_StuErrorLibEN.SourceTypeId = objRow[conge_StuErrorLib.SourceTypeId].ToString().Trim(); //来源类型Id
objge_StuErrorLibEN.IsRedo = clsEntityBase2.TransNullToBool_S(objRow[conge_StuErrorLib.IsRedo].ToString().Trim()); //是否重做
objge_StuErrorLibEN.RedoDate = objRow[conge_StuErrorLib.RedoDate] == DBNull.Value ? null : objRow[conge_StuErrorLib.RedoDate].ToString().Trim(); //重做日期
objge_StuErrorLibEN.IsPassed = clsEntityBase2.TransNullToBool_S(objRow[conge_StuErrorLib.IsPassed].ToString().Trim()); //是否通过
objge_StuErrorLibEN.UpdDate = objRow[conge_StuErrorLib.UpdDate] == DBNull.Value ? null : objRow[conge_StuErrorLib.UpdDate].ToString().Trim(); //修改日期
objge_StuErrorLibEN.UpdUser = objRow[conge_StuErrorLib.UpdUser] == DBNull.Value ? null : objRow[conge_StuErrorLib.UpdUser].ToString().Trim(); //修改人
objge_StuErrorLibEN.Memo = objRow[conge_StuErrorLib.Memo] == DBNull.Value ? null : objRow[conge_StuErrorLib.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objge_StuErrorLibEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objge_StuErrorLibEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrMIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsge_StuErrorLibEN> GetObjLstByMIdLstCache(List<long> arrMIdLst, string strCourseId, string strIdStudentInfo)
{
string strKey = string.Format("{0}_{1}_{2}", clsge_StuErrorLibEN._CurrTabName, strCourseId, strIdStudentInfo);
List<clsge_StuErrorLibEN> arrge_StuErrorLibObjLstCache = GetObjLstCache(strCourseId, strIdStudentInfo);
IEnumerable <clsge_StuErrorLibEN> arrge_StuErrorLibObjLst_Sel =
arrge_StuErrorLibObjLstCache
.Where(x => arrMIdLst.Contains(x.mId));
return arrge_StuErrorLibObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsge_StuErrorLibEN> GetObjLst(string strWhereCond)
{
List<clsge_StuErrorLibEN> arrObjLst = new List<clsge_StuErrorLibEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsge_StuErrorLibEN objge_StuErrorLibEN = new clsge_StuErrorLibEN();
try
{
objge_StuErrorLibEN.mId = Int32.Parse(objRow[conge_StuErrorLib.mId].ToString().Trim()); //mId
objge_StuErrorLibEN.CourseId = objRow[conge_StuErrorLib.CourseId].ToString().Trim(); //课程Id
objge_StuErrorLibEN.IdStudentInfo = objRow[conge_StuErrorLib.IdStudentInfo].ToString().Trim(); //学生流水号
objge_StuErrorLibEN.QuestionId = Int32.Parse(objRow[conge_StuErrorLib.QuestionId].ToString().Trim()); //题目Id
objge_StuErrorLibEN.Creator = objRow[conge_StuErrorLib.Creator] == DBNull.Value ? null : objRow[conge_StuErrorLib.Creator].ToString().Trim(); //创建者
objge_StuErrorLibEN.CreateDate = objRow[conge_StuErrorLib.CreateDate] == DBNull.Value ? null : objRow[conge_StuErrorLib.CreateDate].ToString().Trim(); //建立日期
objge_StuErrorLibEN.SourceTypeId = objRow[conge_StuErrorLib.SourceTypeId].ToString().Trim(); //来源类型Id
objge_StuErrorLibEN.IsRedo = clsEntityBase2.TransNullToBool_S(objRow[conge_StuErrorLib.IsRedo].ToString().Trim()); //是否重做
objge_StuErrorLibEN.RedoDate = objRow[conge_StuErrorLib.RedoDate] == DBNull.Value ? null : objRow[conge_StuErrorLib.RedoDate].ToString().Trim(); //重做日期
objge_StuErrorLibEN.IsPassed = clsEntityBase2.TransNullToBool_S(objRow[conge_StuErrorLib.IsPassed].ToString().Trim()); //是否通过
objge_StuErrorLibEN.UpdDate = objRow[conge_StuErrorLib.UpdDate] == DBNull.Value ? null : objRow[conge_StuErrorLib.UpdDate].ToString().Trim(); //修改日期
objge_StuErrorLibEN.UpdUser = objRow[conge_StuErrorLib.UpdUser] == DBNull.Value ? null : objRow[conge_StuErrorLib.UpdUser].ToString().Trim(); //修改人
objge_StuErrorLibEN.Memo = objRow[conge_StuErrorLib.Memo] == DBNull.Value ? null : objRow[conge_StuErrorLib.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objge_StuErrorLibEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objge_StuErrorLibEN);
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
public static List<clsge_StuErrorLibEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsge_StuErrorLibEN> arrObjLst = new List<clsge_StuErrorLibEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsge_StuErrorLibEN objge_StuErrorLibEN = new clsge_StuErrorLibEN();
try
{
objge_StuErrorLibEN.mId = Int32.Parse(objRow[conge_StuErrorLib.mId].ToString().Trim()); //mId
objge_StuErrorLibEN.CourseId = objRow[conge_StuErrorLib.CourseId].ToString().Trim(); //课程Id
objge_StuErrorLibEN.IdStudentInfo = objRow[conge_StuErrorLib.IdStudentInfo].ToString().Trim(); //学生流水号
objge_StuErrorLibEN.QuestionId = Int32.Parse(objRow[conge_StuErrorLib.QuestionId].ToString().Trim()); //题目Id
objge_StuErrorLibEN.Creator = objRow[conge_StuErrorLib.Creator] == DBNull.Value ? null : objRow[conge_StuErrorLib.Creator].ToString().Trim(); //创建者
objge_StuErrorLibEN.CreateDate = objRow[conge_StuErrorLib.CreateDate] == DBNull.Value ? null : objRow[conge_StuErrorLib.CreateDate].ToString().Trim(); //建立日期
objge_StuErrorLibEN.SourceTypeId = objRow[conge_StuErrorLib.SourceTypeId].ToString().Trim(); //来源类型Id
objge_StuErrorLibEN.IsRedo = clsEntityBase2.TransNullToBool_S(objRow[conge_StuErrorLib.IsRedo].ToString().Trim()); //是否重做
objge_StuErrorLibEN.RedoDate = objRow[conge_StuErrorLib.RedoDate] == DBNull.Value ? null : objRow[conge_StuErrorLib.RedoDate].ToString().Trim(); //重做日期
objge_StuErrorLibEN.IsPassed = clsEntityBase2.TransNullToBool_S(objRow[conge_StuErrorLib.IsPassed].ToString().Trim()); //是否通过
objge_StuErrorLibEN.UpdDate = objRow[conge_StuErrorLib.UpdDate] == DBNull.Value ? null : objRow[conge_StuErrorLib.UpdDate].ToString().Trim(); //修改日期
objge_StuErrorLibEN.UpdUser = objRow[conge_StuErrorLib.UpdUser] == DBNull.Value ? null : objRow[conge_StuErrorLib.UpdUser].ToString().Trim(); //修改人
objge_StuErrorLibEN.Memo = objRow[conge_StuErrorLib.Memo] == DBNull.Value ? null : objRow[conge_StuErrorLib.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objge_StuErrorLibEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objge_StuErrorLibEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objge_StuErrorLibCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsge_StuErrorLibEN> GetSubObjLstCache(clsge_StuErrorLibEN objge_StuErrorLibCond)
{
 string strCourseId = objge_StuErrorLibCond.CourseId;
 if (string.IsNullOrEmpty(strCourseId) == true)
{
string strMsg = string.Format("(errid:Busi000172)在表中,缓存分类字段值不能为空!(clsge_StuErrorLibBL:GetSubObjLstCache)");
throw new Exception(strMsg);
}
 string strIdStudentInfo = objge_StuErrorLibCond.IdStudentInfo;
 if (string.IsNullOrEmpty(strIdStudentInfo) == true)
{
string strMsg = string.Format("(errid:Busi000175)在表中,缓存分类字段值2不能为空!(clsge_StuErrorLibBL:GetSubObjLstCache)");
throw new Exception(strMsg);
}
List<clsge_StuErrorLibEN> arrObjLstCache = GetObjLstCache(strCourseId, strIdStudentInfo);
IEnumerable <clsge_StuErrorLibEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conge_StuErrorLib.AttributeName)
{
if (objge_StuErrorLibCond.IsUpdated(strFldName) == false) continue;
if (objge_StuErrorLibCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objge_StuErrorLibCond[strFldName].ToString());
}
else
{
if (objge_StuErrorLibCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objge_StuErrorLibCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objge_StuErrorLibCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objge_StuErrorLibCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objge_StuErrorLibCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objge_StuErrorLibCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objge_StuErrorLibCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objge_StuErrorLibCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objge_StuErrorLibCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objge_StuErrorLibCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objge_StuErrorLibCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objge_StuErrorLibCond[strFldName]));
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
public static List<clsge_StuErrorLibEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsge_StuErrorLibEN> arrObjLst = new List<clsge_StuErrorLibEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsge_StuErrorLibEN objge_StuErrorLibEN = new clsge_StuErrorLibEN();
try
{
objge_StuErrorLibEN.mId = Int32.Parse(objRow[conge_StuErrorLib.mId].ToString().Trim()); //mId
objge_StuErrorLibEN.CourseId = objRow[conge_StuErrorLib.CourseId].ToString().Trim(); //课程Id
objge_StuErrorLibEN.IdStudentInfo = objRow[conge_StuErrorLib.IdStudentInfo].ToString().Trim(); //学生流水号
objge_StuErrorLibEN.QuestionId = Int32.Parse(objRow[conge_StuErrorLib.QuestionId].ToString().Trim()); //题目Id
objge_StuErrorLibEN.Creator = objRow[conge_StuErrorLib.Creator] == DBNull.Value ? null : objRow[conge_StuErrorLib.Creator].ToString().Trim(); //创建者
objge_StuErrorLibEN.CreateDate = objRow[conge_StuErrorLib.CreateDate] == DBNull.Value ? null : objRow[conge_StuErrorLib.CreateDate].ToString().Trim(); //建立日期
objge_StuErrorLibEN.SourceTypeId = objRow[conge_StuErrorLib.SourceTypeId].ToString().Trim(); //来源类型Id
objge_StuErrorLibEN.IsRedo = clsEntityBase2.TransNullToBool_S(objRow[conge_StuErrorLib.IsRedo].ToString().Trim()); //是否重做
objge_StuErrorLibEN.RedoDate = objRow[conge_StuErrorLib.RedoDate] == DBNull.Value ? null : objRow[conge_StuErrorLib.RedoDate].ToString().Trim(); //重做日期
objge_StuErrorLibEN.IsPassed = clsEntityBase2.TransNullToBool_S(objRow[conge_StuErrorLib.IsPassed].ToString().Trim()); //是否通过
objge_StuErrorLibEN.UpdDate = objRow[conge_StuErrorLib.UpdDate] == DBNull.Value ? null : objRow[conge_StuErrorLib.UpdDate].ToString().Trim(); //修改日期
objge_StuErrorLibEN.UpdUser = objRow[conge_StuErrorLib.UpdUser] == DBNull.Value ? null : objRow[conge_StuErrorLib.UpdUser].ToString().Trim(); //修改人
objge_StuErrorLibEN.Memo = objRow[conge_StuErrorLib.Memo] == DBNull.Value ? null : objRow[conge_StuErrorLib.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objge_StuErrorLibEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objge_StuErrorLibEN);
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
public static List<clsge_StuErrorLibEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsge_StuErrorLibEN> arrObjLst = new List<clsge_StuErrorLibEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsge_StuErrorLibEN objge_StuErrorLibEN = new clsge_StuErrorLibEN();
try
{
objge_StuErrorLibEN.mId = Int32.Parse(objRow[conge_StuErrorLib.mId].ToString().Trim()); //mId
objge_StuErrorLibEN.CourseId = objRow[conge_StuErrorLib.CourseId].ToString().Trim(); //课程Id
objge_StuErrorLibEN.IdStudentInfo = objRow[conge_StuErrorLib.IdStudentInfo].ToString().Trim(); //学生流水号
objge_StuErrorLibEN.QuestionId = Int32.Parse(objRow[conge_StuErrorLib.QuestionId].ToString().Trim()); //题目Id
objge_StuErrorLibEN.Creator = objRow[conge_StuErrorLib.Creator] == DBNull.Value ? null : objRow[conge_StuErrorLib.Creator].ToString().Trim(); //创建者
objge_StuErrorLibEN.CreateDate = objRow[conge_StuErrorLib.CreateDate] == DBNull.Value ? null : objRow[conge_StuErrorLib.CreateDate].ToString().Trim(); //建立日期
objge_StuErrorLibEN.SourceTypeId = objRow[conge_StuErrorLib.SourceTypeId].ToString().Trim(); //来源类型Id
objge_StuErrorLibEN.IsRedo = clsEntityBase2.TransNullToBool_S(objRow[conge_StuErrorLib.IsRedo].ToString().Trim()); //是否重做
objge_StuErrorLibEN.RedoDate = objRow[conge_StuErrorLib.RedoDate] == DBNull.Value ? null : objRow[conge_StuErrorLib.RedoDate].ToString().Trim(); //重做日期
objge_StuErrorLibEN.IsPassed = clsEntityBase2.TransNullToBool_S(objRow[conge_StuErrorLib.IsPassed].ToString().Trim()); //是否通过
objge_StuErrorLibEN.UpdDate = objRow[conge_StuErrorLib.UpdDate] == DBNull.Value ? null : objRow[conge_StuErrorLib.UpdDate].ToString().Trim(); //修改日期
objge_StuErrorLibEN.UpdUser = objRow[conge_StuErrorLib.UpdUser] == DBNull.Value ? null : objRow[conge_StuErrorLib.UpdUser].ToString().Trim(); //修改人
objge_StuErrorLibEN.Memo = objRow[conge_StuErrorLib.Memo] == DBNull.Value ? null : objRow[conge_StuErrorLib.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objge_StuErrorLibEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objge_StuErrorLibEN);
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
List<clsge_StuErrorLibEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsge_StuErrorLibEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsge_StuErrorLibEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsge_StuErrorLibEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsge_StuErrorLibEN> arrObjLst = new List<clsge_StuErrorLibEN>(); 
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
	clsge_StuErrorLibEN objge_StuErrorLibEN = new clsge_StuErrorLibEN();
try
{
objge_StuErrorLibEN.mId = Int32.Parse(objRow[conge_StuErrorLib.mId].ToString().Trim()); //mId
objge_StuErrorLibEN.CourseId = objRow[conge_StuErrorLib.CourseId].ToString().Trim(); //课程Id
objge_StuErrorLibEN.IdStudentInfo = objRow[conge_StuErrorLib.IdStudentInfo].ToString().Trim(); //学生流水号
objge_StuErrorLibEN.QuestionId = Int32.Parse(objRow[conge_StuErrorLib.QuestionId].ToString().Trim()); //题目Id
objge_StuErrorLibEN.Creator = objRow[conge_StuErrorLib.Creator] == DBNull.Value ? null : objRow[conge_StuErrorLib.Creator].ToString().Trim(); //创建者
objge_StuErrorLibEN.CreateDate = objRow[conge_StuErrorLib.CreateDate] == DBNull.Value ? null : objRow[conge_StuErrorLib.CreateDate].ToString().Trim(); //建立日期
objge_StuErrorLibEN.SourceTypeId = objRow[conge_StuErrorLib.SourceTypeId].ToString().Trim(); //来源类型Id
objge_StuErrorLibEN.IsRedo = clsEntityBase2.TransNullToBool_S(objRow[conge_StuErrorLib.IsRedo].ToString().Trim()); //是否重做
objge_StuErrorLibEN.RedoDate = objRow[conge_StuErrorLib.RedoDate] == DBNull.Value ? null : objRow[conge_StuErrorLib.RedoDate].ToString().Trim(); //重做日期
objge_StuErrorLibEN.IsPassed = clsEntityBase2.TransNullToBool_S(objRow[conge_StuErrorLib.IsPassed].ToString().Trim()); //是否通过
objge_StuErrorLibEN.UpdDate = objRow[conge_StuErrorLib.UpdDate] == DBNull.Value ? null : objRow[conge_StuErrorLib.UpdDate].ToString().Trim(); //修改日期
objge_StuErrorLibEN.UpdUser = objRow[conge_StuErrorLib.UpdUser] == DBNull.Value ? null : objRow[conge_StuErrorLib.UpdUser].ToString().Trim(); //修改人
objge_StuErrorLibEN.Memo = objRow[conge_StuErrorLib.Memo] == DBNull.Value ? null : objRow[conge_StuErrorLib.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objge_StuErrorLibEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objge_StuErrorLibEN);
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
public static List<clsge_StuErrorLibEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsge_StuErrorLibEN> arrObjLst = new List<clsge_StuErrorLibEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsge_StuErrorLibEN objge_StuErrorLibEN = new clsge_StuErrorLibEN();
try
{
objge_StuErrorLibEN.mId = Int32.Parse(objRow[conge_StuErrorLib.mId].ToString().Trim()); //mId
objge_StuErrorLibEN.CourseId = objRow[conge_StuErrorLib.CourseId].ToString().Trim(); //课程Id
objge_StuErrorLibEN.IdStudentInfo = objRow[conge_StuErrorLib.IdStudentInfo].ToString().Trim(); //学生流水号
objge_StuErrorLibEN.QuestionId = Int32.Parse(objRow[conge_StuErrorLib.QuestionId].ToString().Trim()); //题目Id
objge_StuErrorLibEN.Creator = objRow[conge_StuErrorLib.Creator] == DBNull.Value ? null : objRow[conge_StuErrorLib.Creator].ToString().Trim(); //创建者
objge_StuErrorLibEN.CreateDate = objRow[conge_StuErrorLib.CreateDate] == DBNull.Value ? null : objRow[conge_StuErrorLib.CreateDate].ToString().Trim(); //建立日期
objge_StuErrorLibEN.SourceTypeId = objRow[conge_StuErrorLib.SourceTypeId].ToString().Trim(); //来源类型Id
objge_StuErrorLibEN.IsRedo = clsEntityBase2.TransNullToBool_S(objRow[conge_StuErrorLib.IsRedo].ToString().Trim()); //是否重做
objge_StuErrorLibEN.RedoDate = objRow[conge_StuErrorLib.RedoDate] == DBNull.Value ? null : objRow[conge_StuErrorLib.RedoDate].ToString().Trim(); //重做日期
objge_StuErrorLibEN.IsPassed = clsEntityBase2.TransNullToBool_S(objRow[conge_StuErrorLib.IsPassed].ToString().Trim()); //是否通过
objge_StuErrorLibEN.UpdDate = objRow[conge_StuErrorLib.UpdDate] == DBNull.Value ? null : objRow[conge_StuErrorLib.UpdDate].ToString().Trim(); //修改日期
objge_StuErrorLibEN.UpdUser = objRow[conge_StuErrorLib.UpdUser] == DBNull.Value ? null : objRow[conge_StuErrorLib.UpdUser].ToString().Trim(); //修改人
objge_StuErrorLibEN.Memo = objRow[conge_StuErrorLib.Memo] == DBNull.Value ? null : objRow[conge_StuErrorLib.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objge_StuErrorLibEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objge_StuErrorLibEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsge_StuErrorLibEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsge_StuErrorLibEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsge_StuErrorLibEN> arrObjLst = new List<clsge_StuErrorLibEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsge_StuErrorLibEN objge_StuErrorLibEN = new clsge_StuErrorLibEN();
try
{
objge_StuErrorLibEN.mId = Int32.Parse(objRow[conge_StuErrorLib.mId].ToString().Trim()); //mId
objge_StuErrorLibEN.CourseId = objRow[conge_StuErrorLib.CourseId].ToString().Trim(); //课程Id
objge_StuErrorLibEN.IdStudentInfo = objRow[conge_StuErrorLib.IdStudentInfo].ToString().Trim(); //学生流水号
objge_StuErrorLibEN.QuestionId = Int32.Parse(objRow[conge_StuErrorLib.QuestionId].ToString().Trim()); //题目Id
objge_StuErrorLibEN.Creator = objRow[conge_StuErrorLib.Creator] == DBNull.Value ? null : objRow[conge_StuErrorLib.Creator].ToString().Trim(); //创建者
objge_StuErrorLibEN.CreateDate = objRow[conge_StuErrorLib.CreateDate] == DBNull.Value ? null : objRow[conge_StuErrorLib.CreateDate].ToString().Trim(); //建立日期
objge_StuErrorLibEN.SourceTypeId = objRow[conge_StuErrorLib.SourceTypeId].ToString().Trim(); //来源类型Id
objge_StuErrorLibEN.IsRedo = clsEntityBase2.TransNullToBool_S(objRow[conge_StuErrorLib.IsRedo].ToString().Trim()); //是否重做
objge_StuErrorLibEN.RedoDate = objRow[conge_StuErrorLib.RedoDate] == DBNull.Value ? null : objRow[conge_StuErrorLib.RedoDate].ToString().Trim(); //重做日期
objge_StuErrorLibEN.IsPassed = clsEntityBase2.TransNullToBool_S(objRow[conge_StuErrorLib.IsPassed].ToString().Trim()); //是否通过
objge_StuErrorLibEN.UpdDate = objRow[conge_StuErrorLib.UpdDate] == DBNull.Value ? null : objRow[conge_StuErrorLib.UpdDate].ToString().Trim(); //修改日期
objge_StuErrorLibEN.UpdUser = objRow[conge_StuErrorLib.UpdUser] == DBNull.Value ? null : objRow[conge_StuErrorLib.UpdUser].ToString().Trim(); //修改人
objge_StuErrorLibEN.Memo = objRow[conge_StuErrorLib.Memo] == DBNull.Value ? null : objRow[conge_StuErrorLib.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objge_StuErrorLibEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objge_StuErrorLibEN);
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
public static List<clsge_StuErrorLibEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsge_StuErrorLibEN> arrObjLst = new List<clsge_StuErrorLibEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsge_StuErrorLibEN objge_StuErrorLibEN = new clsge_StuErrorLibEN();
try
{
objge_StuErrorLibEN.mId = Int32.Parse(objRow[conge_StuErrorLib.mId].ToString().Trim()); //mId
objge_StuErrorLibEN.CourseId = objRow[conge_StuErrorLib.CourseId].ToString().Trim(); //课程Id
objge_StuErrorLibEN.IdStudentInfo = objRow[conge_StuErrorLib.IdStudentInfo].ToString().Trim(); //学生流水号
objge_StuErrorLibEN.QuestionId = Int32.Parse(objRow[conge_StuErrorLib.QuestionId].ToString().Trim()); //题目Id
objge_StuErrorLibEN.Creator = objRow[conge_StuErrorLib.Creator] == DBNull.Value ? null : objRow[conge_StuErrorLib.Creator].ToString().Trim(); //创建者
objge_StuErrorLibEN.CreateDate = objRow[conge_StuErrorLib.CreateDate] == DBNull.Value ? null : objRow[conge_StuErrorLib.CreateDate].ToString().Trim(); //建立日期
objge_StuErrorLibEN.SourceTypeId = objRow[conge_StuErrorLib.SourceTypeId].ToString().Trim(); //来源类型Id
objge_StuErrorLibEN.IsRedo = clsEntityBase2.TransNullToBool_S(objRow[conge_StuErrorLib.IsRedo].ToString().Trim()); //是否重做
objge_StuErrorLibEN.RedoDate = objRow[conge_StuErrorLib.RedoDate] == DBNull.Value ? null : objRow[conge_StuErrorLib.RedoDate].ToString().Trim(); //重做日期
objge_StuErrorLibEN.IsPassed = clsEntityBase2.TransNullToBool_S(objRow[conge_StuErrorLib.IsPassed].ToString().Trim()); //是否通过
objge_StuErrorLibEN.UpdDate = objRow[conge_StuErrorLib.UpdDate] == DBNull.Value ? null : objRow[conge_StuErrorLib.UpdDate].ToString().Trim(); //修改日期
objge_StuErrorLibEN.UpdUser = objRow[conge_StuErrorLib.UpdUser] == DBNull.Value ? null : objRow[conge_StuErrorLib.UpdUser].ToString().Trim(); //修改人
objge_StuErrorLibEN.Memo = objRow[conge_StuErrorLib.Memo] == DBNull.Value ? null : objRow[conge_StuErrorLib.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objge_StuErrorLibEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objge_StuErrorLibEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsge_StuErrorLibEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsge_StuErrorLibEN> arrObjLst = new List<clsge_StuErrorLibEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsge_StuErrorLibEN objge_StuErrorLibEN = new clsge_StuErrorLibEN();
try
{
objge_StuErrorLibEN.mId = Int32.Parse(objRow[conge_StuErrorLib.mId].ToString().Trim()); //mId
objge_StuErrorLibEN.CourseId = objRow[conge_StuErrorLib.CourseId].ToString().Trim(); //课程Id
objge_StuErrorLibEN.IdStudentInfo = objRow[conge_StuErrorLib.IdStudentInfo].ToString().Trim(); //学生流水号
objge_StuErrorLibEN.QuestionId = Int32.Parse(objRow[conge_StuErrorLib.QuestionId].ToString().Trim()); //题目Id
objge_StuErrorLibEN.Creator = objRow[conge_StuErrorLib.Creator] == DBNull.Value ? null : objRow[conge_StuErrorLib.Creator].ToString().Trim(); //创建者
objge_StuErrorLibEN.CreateDate = objRow[conge_StuErrorLib.CreateDate] == DBNull.Value ? null : objRow[conge_StuErrorLib.CreateDate].ToString().Trim(); //建立日期
objge_StuErrorLibEN.SourceTypeId = objRow[conge_StuErrorLib.SourceTypeId].ToString().Trim(); //来源类型Id
objge_StuErrorLibEN.IsRedo = clsEntityBase2.TransNullToBool_S(objRow[conge_StuErrorLib.IsRedo].ToString().Trim()); //是否重做
objge_StuErrorLibEN.RedoDate = objRow[conge_StuErrorLib.RedoDate] == DBNull.Value ? null : objRow[conge_StuErrorLib.RedoDate].ToString().Trim(); //重做日期
objge_StuErrorLibEN.IsPassed = clsEntityBase2.TransNullToBool_S(objRow[conge_StuErrorLib.IsPassed].ToString().Trim()); //是否通过
objge_StuErrorLibEN.UpdDate = objRow[conge_StuErrorLib.UpdDate] == DBNull.Value ? null : objRow[conge_StuErrorLib.UpdDate].ToString().Trim(); //修改日期
objge_StuErrorLibEN.UpdUser = objRow[conge_StuErrorLib.UpdUser] == DBNull.Value ? null : objRow[conge_StuErrorLib.UpdUser].ToString().Trim(); //修改人
objge_StuErrorLibEN.Memo = objRow[conge_StuErrorLib.Memo] == DBNull.Value ? null : objRow[conge_StuErrorLib.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objge_StuErrorLibEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objge_StuErrorLibEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objge_StuErrorLibEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool Getge_StuErrorLib(ref clsge_StuErrorLibEN objge_StuErrorLibEN)
{
bool bolResult = ge_StuErrorLibDA.Getge_StuErrorLib(ref objge_StuErrorLibEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public static clsge_StuErrorLibEN GetObjBymId(long lngmId)
{
clsge_StuErrorLibEN objge_StuErrorLibEN = ge_StuErrorLibDA.GetObjBymId(lngmId);
return objge_StuErrorLibEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsge_StuErrorLibEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsge_StuErrorLibEN objge_StuErrorLibEN = ge_StuErrorLibDA.GetFirstObj(strWhereCond);
 return objge_StuErrorLibEN;
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
public static clsge_StuErrorLibEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsge_StuErrorLibEN objge_StuErrorLibEN = ge_StuErrorLibDA.GetObjByDataRow(objRow);
 return objge_StuErrorLibEN;
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
public static clsge_StuErrorLibEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsge_StuErrorLibEN objge_StuErrorLibEN = ge_StuErrorLibDA.GetObjByDataRow(objRow);
 return objge_StuErrorLibEN;
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
 /// <param name = "lstge_StuErrorLibObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsge_StuErrorLibEN GetObjBymIdFromList(long lngmId, List<clsge_StuErrorLibEN> lstge_StuErrorLibObjLst)
{
foreach (clsge_StuErrorLibEN objge_StuErrorLibEN in lstge_StuErrorLibObjLst)
{
if (objge_StuErrorLibEN.mId == lngmId)
{
return objge_StuErrorLibEN;
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
 lngmId = new clsge_StuErrorLibDA().GetFirstID(strWhereCond);
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
 arrList = ge_StuErrorLibDA.GetID(strWhereCond);
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
bool bolIsExist = ge_StuErrorLibDA.IsExistCondRec(strWhereCond);
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
bool bolIsExist = ge_StuErrorLibDA.IsExist(lngmId);
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
clsge_StuErrorLibEN objge_StuErrorLibEN = clsge_StuErrorLibBL.GetObjBymId(lngmId);
objge_StuErrorLibEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
objge_StuErrorLibEN.UpdUser = strOpUser;
return clsge_StuErrorLibBL.UpdateBySql2(objge_StuErrorLibEN);
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
 bolIsExist = clsge_StuErrorLibDA.IsExistTable();
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
 bolIsExist = ge_StuErrorLibDA.IsExistTable(strTabName);
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
 /// <param name = "objge_StuErrorLibEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecordBySql2(clsge_StuErrorLibEN objge_StuErrorLibEN, bool bolIsNeedCheckUniqueness=true)
{
if (bolIsNeedCheckUniqueness == true && objge_StuErrorLibEN.CheckUniqueness() == false)
{
var strMsg = string.Format("记录已经存在!学生流水号 = [{0}],题目Id = [{1}]的数据已经存在!(in clsge_StuErrorLibBL.AddNewRecordBySql2)", objge_StuErrorLibEN.IdStudentInfo,objge_StuErrorLibEN.QuestionId);
throw new Exception(strMsg);
}
try
{
bool bolResult = ge_StuErrorLibDA.AddNewRecordBySQL2(objge_StuErrorLibEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsge_StuErrorLibBL.ReFreshCache(objge_StuErrorLibEN.CourseId, objge_StuErrorLibEN.IdStudentInfo);

if (clsge_StuErrorLibBL.relatedActions != null)
{
clsge_StuErrorLibBL.relatedActions.UpdRelaTabDate(objge_StuErrorLibEN.mId, objge_StuErrorLibEN.UpdUser);
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
 /// <param name = "objge_StuErrorLibEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordBySql2WithReturnKey(clsge_StuErrorLibEN objge_StuErrorLibEN, bool bolIsNeedCheckUniqueness=true)
{
if (bolIsNeedCheckUniqueness == true && objge_StuErrorLibEN.CheckUniqueness() == false)
{
var strMsg = string.Format("记录已经存在!学生流水号 = [{0}],题目Id = [{1}]的数据已经存在!(in clsge_StuErrorLibBL.AddNewRecordBySql2WithReturnKey)", objge_StuErrorLibEN.IdStudentInfo,objge_StuErrorLibEN.QuestionId);
throw new Exception(strMsg);
}
try
{
string strKey = ge_StuErrorLibDA.AddNewRecordBySQL2WithReturnKey(objge_StuErrorLibEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsge_StuErrorLibBL.ReFreshCache(objge_StuErrorLibEN.CourseId, objge_StuErrorLibEN.IdStudentInfo);

if (clsge_StuErrorLibBL.relatedActions != null)
{
clsge_StuErrorLibBL.relatedActions.UpdRelaTabDate(objge_StuErrorLibEN.mId, objge_StuErrorLibEN.UpdUser);
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
 /// <param name = "objge_StuErrorLibEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(clsge_StuErrorLibEN objge_StuErrorLibEN)
{
try
{
bool bolResult = ge_StuErrorLibDA.Update(objge_StuErrorLibEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsge_StuErrorLibBL.ReFreshCache(objge_StuErrorLibEN.CourseId, objge_StuErrorLibEN.IdStudentInfo);

if (clsge_StuErrorLibBL.relatedActions != null)
{
clsge_StuErrorLibBL.relatedActions.UpdRelaTabDate(objge_StuErrorLibEN.mId, objge_StuErrorLibEN.UpdUser);
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
 /// <param name = "objge_StuErrorLibEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateBySql2(clsge_StuErrorLibEN objge_StuErrorLibEN)
{
 if (objge_StuErrorLibEN.mId == 0)
 {
var strMsg = string.Format("(errid:Busi000065)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = ge_StuErrorLibDA.UpdateBySql2(objge_StuErrorLibEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsge_StuErrorLibBL.ReFreshCache(objge_StuErrorLibEN.CourseId, objge_StuErrorLibEN.IdStudentInfo);

if (clsge_StuErrorLibBL.relatedActions != null)
{
clsge_StuErrorLibBL.relatedActions.UpdRelaTabDate(objge_StuErrorLibEN.mId, objge_StuErrorLibEN.UpdUser);
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
 clsge_StuErrorLibEN objge_StuErrorLibEN = clsge_StuErrorLibBL.GetObjBymId(lngmId);

if (clsge_StuErrorLibBL.relatedActions != null)
{
clsge_StuErrorLibBL.relatedActions.UpdRelaTabDate(objge_StuErrorLibEN.mId, objge_StuErrorLibEN.UpdUser);
}
if (objge_StuErrorLibEN != null)
{
int intRecNum = ge_StuErrorLibDA.DelRecord(lngmId);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
ReFreshCache(objge_StuErrorLibEN.CourseId, objge_StuErrorLibEN.IdStudentInfo);
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
 /// <param name = "strIdStudentInfo">缓存的分类字段</param>
/// <returns></returns>
public static bool DelRecordEx(long lngmId , string strCourseId, string strIdStudentInfo)
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsge_StuErrorLibDA.GetSpecSQLObj();
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
//删除与表:[ge_StuErrorLib]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conge_StuErrorLib.mId,
//lngmId);
//        clsge_StuErrorLibBL.Delge_StuErrorLibsByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsge_StuErrorLibBL.DelRecord(lngmId, strCourseId, strIdStudentInfo, objConnection, objSqlTransaction);
objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsge_StuErrorLibBLEx", "DelRecordEx", objException.Message, clsSysParaEN.strUserId);
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
public static bool DelRecord(long lngmId, string strCourseId, string strIdStudentInfo, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
if (clsge_StuErrorLibBL.relatedActions != null)
{
clsge_StuErrorLibBL.relatedActions.UpdRelaTabDate(lngmId, "UpdRelaTabDate");
}
bool bolResult = ge_StuErrorLibDA.DelRecord(lngmId,objSqlConnection,objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
ReFreshCache(strCourseId, strIdStudentInfo);
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
public static int Delge_StuErrorLibs(List<string> arrmIdLst)
{
if (arrmIdLst.Count == 0) return 0;
try
{
if (clsge_StuErrorLibBL.relatedActions != null)
{
foreach (var strmId in arrmIdLst)
{
long lngmId = long.Parse(strmId);
clsge_StuErrorLibBL.relatedActions.UpdRelaTabDate(lngmId, "UpdRelaTabDate");
}
}
 clsge_StuErrorLibEN objge_StuErrorLibEN = clsge_StuErrorLibBL.GetObjBymId(long.Parse(arrmIdLst[0]));
int intDelRecNum = ge_StuErrorLibDA.Delge_StuErrorLib(arrmIdLst);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
ReFreshCache(objge_StuErrorLibEN.CourseId, objge_StuErrorLibEN.IdStudentInfo);
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
public static int Delge_StuErrorLibsByCond(string strWhereCond)
{
try
{
if (clsge_StuErrorLibBL.relatedActions != null)
{
List<string> arrmId = GetPrimaryKeyID_S(strWhereCond);
foreach (var strmId in arrmId)
{
long lngmId = long.Parse(strmId);
clsge_StuErrorLibBL.relatedActions.UpdRelaTabDate(lngmId, "UpdRelaTabDate");
}
}
List<string> arrCourseId = GetFldValue(conge_StuErrorLib.CourseId, strWhereCond);
List<string> arrIdStudentInfo = GetFldValue(conge_StuErrorLib.IdStudentInfo, strWhereCond);
int intRecNum = ge_StuErrorLibDA.Delge_StuErrorLib(strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
foreach (var x in arrCourseId)
{
foreach (var y in arrIdStudentInfo)
{
              ReFreshCache(x, y);
}
}
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
/// 这里仅仅是演示函数,使用时请复制到扩展类:[ge_StuErrorLib]中改名为:[DelRecord4MultiTabEx]使用
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DelRecord4MultiTab)
/// </summary>
/// <param name="lngmId">表关键字</param>
 /// <param name = "strCourseId">缓存的分类字段</param>
 /// <param name = "strIdStudentInfo">缓存的分类字段</param>
/// <returns></returns>
public static bool DelRecord4MultiTab(long lngmId, string strCourseId, string strIdStudentInfo)
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsge_StuErrorLibDA.GetSpecSQLObj();
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
//删除与表:[ge_StuErrorLib]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conStudent.id_College,
//strid_College);
//        clsStudentBL.DelStudentsByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsge_StuErrorLibBL.DelRecord(lngmId, strCourseId, strIdStudentInfo, objConnection, objSqlTransaction);
                objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsge_StuErrorLibBL", "DelRecord4MultiTab", objException.Message, clsSysParaEN.strUserId);
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
 /// <param name = "objge_StuErrorLibENS">源对象</param>
 /// <param name = "objge_StuErrorLibENT">目标对象</param>
 public static void CopyTo(clsge_StuErrorLibEN objge_StuErrorLibENS, clsge_StuErrorLibEN objge_StuErrorLibENT)
{
try
{
objge_StuErrorLibENT.mId = objge_StuErrorLibENS.mId; //mId
objge_StuErrorLibENT.CourseId = objge_StuErrorLibENS.CourseId; //课程Id
objge_StuErrorLibENT.IdStudentInfo = objge_StuErrorLibENS.IdStudentInfo; //学生流水号
objge_StuErrorLibENT.QuestionId = objge_StuErrorLibENS.QuestionId; //题目Id
objge_StuErrorLibENT.Creator = objge_StuErrorLibENS.Creator; //创建者
objge_StuErrorLibENT.CreateDate = objge_StuErrorLibENS.CreateDate; //建立日期
objge_StuErrorLibENT.SourceTypeId = objge_StuErrorLibENS.SourceTypeId; //来源类型Id
objge_StuErrorLibENT.IsRedo = objge_StuErrorLibENS.IsRedo; //是否重做
objge_StuErrorLibENT.RedoDate = objge_StuErrorLibENS.RedoDate; //重做日期
objge_StuErrorLibENT.IsPassed = objge_StuErrorLibENS.IsPassed; //是否通过
objge_StuErrorLibENT.UpdDate = objge_StuErrorLibENS.UpdDate; //修改日期
objge_StuErrorLibENT.UpdUser = objge_StuErrorLibENS.UpdUser; //修改人
objge_StuErrorLibENT.Memo = objge_StuErrorLibENS.Memo; //备注
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
 /// <param name = "objge_StuErrorLibEN">源简化对象</param>
 public static void SetUpdFlag(clsge_StuErrorLibEN objge_StuErrorLibEN)
{
try
{
objge_StuErrorLibEN.ClearUpdateState();
   string strsfUpdFldSetStr = objge_StuErrorLibEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(conge_StuErrorLib.mId, new clsStrCompareIgnoreCase())  ==  true)
{
objge_StuErrorLibEN.mId = objge_StuErrorLibEN.mId; //mId
}
if (arrFldSet.Contains(conge_StuErrorLib.CourseId, new clsStrCompareIgnoreCase())  ==  true)
{
objge_StuErrorLibEN.CourseId = objge_StuErrorLibEN.CourseId; //课程Id
}
if (arrFldSet.Contains(conge_StuErrorLib.IdStudentInfo, new clsStrCompareIgnoreCase())  ==  true)
{
objge_StuErrorLibEN.IdStudentInfo = objge_StuErrorLibEN.IdStudentInfo; //学生流水号
}
if (arrFldSet.Contains(conge_StuErrorLib.QuestionId, new clsStrCompareIgnoreCase())  ==  true)
{
objge_StuErrorLibEN.QuestionId = objge_StuErrorLibEN.QuestionId; //题目Id
}
if (arrFldSet.Contains(conge_StuErrorLib.Creator, new clsStrCompareIgnoreCase())  ==  true)
{
objge_StuErrorLibEN.Creator = objge_StuErrorLibEN.Creator == "[null]" ? null :  objge_StuErrorLibEN.Creator; //创建者
}
if (arrFldSet.Contains(conge_StuErrorLib.CreateDate, new clsStrCompareIgnoreCase())  ==  true)
{
objge_StuErrorLibEN.CreateDate = objge_StuErrorLibEN.CreateDate == "[null]" ? null :  objge_StuErrorLibEN.CreateDate; //建立日期
}
if (arrFldSet.Contains(conge_StuErrorLib.SourceTypeId, new clsStrCompareIgnoreCase())  ==  true)
{
objge_StuErrorLibEN.SourceTypeId = objge_StuErrorLibEN.SourceTypeId; //来源类型Id
}
if (arrFldSet.Contains(conge_StuErrorLib.IsRedo, new clsStrCompareIgnoreCase())  ==  true)
{
objge_StuErrorLibEN.IsRedo = objge_StuErrorLibEN.IsRedo; //是否重做
}
if (arrFldSet.Contains(conge_StuErrorLib.RedoDate, new clsStrCompareIgnoreCase())  ==  true)
{
objge_StuErrorLibEN.RedoDate = objge_StuErrorLibEN.RedoDate == "[null]" ? null :  objge_StuErrorLibEN.RedoDate; //重做日期
}
if (arrFldSet.Contains(conge_StuErrorLib.IsPassed, new clsStrCompareIgnoreCase())  ==  true)
{
objge_StuErrorLibEN.IsPassed = objge_StuErrorLibEN.IsPassed; //是否通过
}
if (arrFldSet.Contains(conge_StuErrorLib.UpdDate, new clsStrCompareIgnoreCase())  ==  true)
{
objge_StuErrorLibEN.UpdDate = objge_StuErrorLibEN.UpdDate == "[null]" ? null :  objge_StuErrorLibEN.UpdDate; //修改日期
}
if (arrFldSet.Contains(conge_StuErrorLib.UpdUser, new clsStrCompareIgnoreCase())  ==  true)
{
objge_StuErrorLibEN.UpdUser = objge_StuErrorLibEN.UpdUser == "[null]" ? null :  objge_StuErrorLibEN.UpdUser; //修改人
}
if (arrFldSet.Contains(conge_StuErrorLib.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objge_StuErrorLibEN.Memo = objge_StuErrorLibEN.Memo == "[null]" ? null :  objge_StuErrorLibEN.Memo; //备注
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
 /// <param name = "objge_StuErrorLibEN">源简化对象</param>
 public static void AccessFldValueNull(clsge_StuErrorLibEN objge_StuErrorLibEN)
{
try
{
if (objge_StuErrorLibEN.Creator == "[null]") objge_StuErrorLibEN.Creator = null; //创建者
if (objge_StuErrorLibEN.CreateDate == "[null]") objge_StuErrorLibEN.CreateDate = null; //建立日期
if (objge_StuErrorLibEN.RedoDate == "[null]") objge_StuErrorLibEN.RedoDate = null; //重做日期
if (objge_StuErrorLibEN.UpdDate == "[null]") objge_StuErrorLibEN.UpdDate = null; //修改日期
if (objge_StuErrorLibEN.UpdUser == "[null]") objge_StuErrorLibEN.UpdUser = null; //修改人
if (objge_StuErrorLibEN.Memo == "[null]") objge_StuErrorLibEN.Memo = null; //备注
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
public static void CheckPropertyNew(clsge_StuErrorLibEN objge_StuErrorLibEN)
{
 ge_StuErrorLibDA.CheckPropertyNew(objge_StuErrorLibEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(clsge_StuErrorLibEN objge_StuErrorLibEN)
{
 ge_StuErrorLibDA.CheckProperty4Condition(objge_StuErrorLibEN);
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
if (clsge_StuErrorLibBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsge_StuErrorLibBL没有刷新缓存机制(clsge_StuErrorLibBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by mId");
//if (arrge_StuErrorLibObjLstCache == null)
//{
//arrge_StuErrorLibObjLstCache = ge_StuErrorLibDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "lngmId">所给的关键字</param>
 /// <param name = "strCourseId">缓存的分类字段</param>
 /// <param name = "strIdStudentInfo">缓存的分类字段</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsge_StuErrorLibEN GetObjBymIdCache(long lngmId, string strCourseId, string strIdStudentInfo)
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

if (string.IsNullOrEmpty(strIdStudentInfo) == true)
{
  var strMsg = string.Format("参数:[strIdStudentInfo]不能为空!(In {0})", clsStackTrace.GetCurrClassFunction());
clsSysParaEN.objLog.WriteDebugLog(strMsg);
 throw new Exception (strMsg);
}
if (strIdStudentInfo.Length != 8)
{
var strMsg = string.Format("缓存分类变量:[strIdStudentInfo]的长度:[{0}]不正确!(In {1})", strIdStudentInfo.Length, clsStackTrace.GetCurrClassFunction());
clsSysParaEN.objLog.WriteDebugLog(strMsg);
 throw new Exception (strMsg);
}
//获取缓存中的对象列表
string strKey = string.Format("{0}_{1}_{2}", clsge_StuErrorLibEN._CurrTabName, strCourseId, strIdStudentInfo);
List<clsge_StuErrorLibEN> arrge_StuErrorLibObjLstCache = GetObjLstCache(strCourseId, strIdStudentInfo);
IEnumerable <clsge_StuErrorLibEN> arrge_StuErrorLibObjLst_Sel =
arrge_StuErrorLibObjLstCache
.Where(x=> x.mId == lngmId 
);
if (arrge_StuErrorLibObjLst_Sel.Count() == 0)
{
   clsge_StuErrorLibEN obj = clsge_StuErrorLibBL.GetObjBymId(lngmId);
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
return arrge_StuErrorLibObjLst_Sel.First();
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsge_StuErrorLibEN> GetAllge_StuErrorLibObjLstCache(string strCourseId, string strIdStudentInfo)
{
//获取缓存中的对象列表
List<clsge_StuErrorLibEN> arrge_StuErrorLibObjLstCache = GetObjLstCache(strCourseId, strIdStudentInfo); 
return arrge_StuErrorLibObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsge_StuErrorLibEN> GetObjLstCache(string strCourseId, string strIdStudentInfo)
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

if (string.IsNullOrEmpty(strIdStudentInfo) == true)
{
  var strMsg = string.Format("参数:[strIdStudentInfo]不能为空!(In {0})", clsStackTrace.GetCurrClassFunction());
clsSysParaEN.objLog.WriteDebugLog(strMsg);
 throw new Exception (strMsg);
}
if (strIdStudentInfo.Length != 8)
{
var strMsg = string.Format("缓存分类变量:[strIdStudentInfo]的长度:[{0}]不正确!(In {1})", strIdStudentInfo.Length, clsStackTrace.GetCurrClassFunction());
clsSysParaEN.objLog.WriteDebugLog(strMsg);
 throw new Exception (strMsg);
}
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}_{1}_{2}", clsge_StuErrorLibEN._CurrTabName, strCourseId, strIdStudentInfo);
string strCondition = string.Format("CourseId='{0}'", strCourseId);
strCondition += string.Format(" and IdStudentInfo='{0}'", strIdStudentInfo); 
List<clsge_StuErrorLibEN> arrge_StuErrorLibObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst(strCondition);});
return arrge_StuErrorLibObjLstCache;
}

 /// <summary>
 /// 刷新本类中的缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ReFreshThisCache)
 /// </summary>
public static void ReFreshThisCache(string strCourseId, string strIdStudentInfo)
{
string strMsg;
if (clsSysParaEN.spSetRefreshCacheOn == true)
{
string strKey = string.Format("{0}_{1}_{2}", clsge_StuErrorLibEN._CurrTabName, strCourseId, strIdStudentInfo);
CacheHelper.Remove(strKey);
clsge_StuErrorLibEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
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
if (clsge_StuErrorLibEN._RefreshTimeLst.Count == 0) return "";
return clsge_StuErrorLibEN._RefreshTimeLst[clsge_StuErrorLibEN._RefreshTimeLst.Count - 1];
}

 /// <summary>
 /// 刷新缓存.把当前表的缓存以及该表相关视图的缓存清空.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ReFreshCache)
 /// </summary>
public static void ReFreshCache(string strCourseId, string strIdStudentInfo)
{
if (string.IsNullOrEmpty(strCourseId) == true)
{
string strMsg = string.Format("缓存分类字段:[CourseId]不能为空!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (string.IsNullOrEmpty(strIdStudentInfo) == true)
{
string strMsg = string.Format("缓存分类字段:[IdStudentInfo]不能为空!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsge_StuErrorLibBL.objCommFun4BL != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}_{1}_{2}", clsge_StuErrorLibEN._CurrTabName, strCourseId, strIdStudentInfo);
CacheHelper.Remove(strKey);
clsge_StuErrorLibEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
clsge_StuErrorLibBL.objCommFun4BL.ReFreshCache(strCourseId, strIdStudentInfo);
}
}


 #endregion 缓存操作


 #region 检查唯一性

 /// <summary>
 /// 获取检查唯一性条件串(Uniqueness)--ge_StuErrorLib(学生错误作业集)
 /// 唯一性条件:IdStudentInfo_QuestionId
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetUniquenessConditionString)
 /// </summary>
 /// <param name = "objge_StuErrorLibEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(clsge_StuErrorLibEN objge_StuErrorLibEN)
{
//检测记录是否存在
string strResult = ge_StuErrorLibDA.GetUniCondStr(objge_StuErrorLibEN);
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
 /// <param name = "strIdStudentInfo">缓存的分类字段</param>
 /// <returns>返回一个输出字段值</returns>
public static string Func(string strInFldName, string strOutFldName, long lngmId, string strCourseId, string strIdStudentInfo)
{
if (strInFldName != conge_StuErrorLib.mId)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (conge_StuErrorLib.AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", conge_StuErrorLib.AttributeName));
throw new Exception(strMsg);
}
var objge_StuErrorLib = clsge_StuErrorLibBL.GetObjBymIdCache(lngmId, strCourseId, strIdStudentInfo);
if (objge_StuErrorLib == null) return "";
return objge_StuErrorLib[strOutFldName].ToString();
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
int intRecCount = clsge_StuErrorLibDA.GetRecCount(strTabName);
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
int intRecCount = clsge_StuErrorLibDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsge_StuErrorLibDA.GetRecCount();
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
int intRecCount = clsge_StuErrorLibDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objge_StuErrorLibCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsge_StuErrorLibEN objge_StuErrorLibCond)
{
 string strCourseId = objge_StuErrorLibCond.CourseId;
 if (string.IsNullOrEmpty(strCourseId) == true)
{
string strMsg = string.Format("(errid:Busi000174)在表中,缓存分类字段值不能为空!(clsge_StuErrorLibBL:GetRecCountByCondCache)");
throw new Exception(strMsg);
}
 string strIdStudentInfo = objge_StuErrorLibCond.IdStudentInfo;
 if (string.IsNullOrEmpty(strIdStudentInfo) == true)
{
string strMsg = string.Format("(errid:Busi000176)在表中,缓存分类字段值2不能为空!(clsge_StuErrorLibBL:GetRecCountByCondCache)");
throw new Exception(strMsg);
}
List<clsge_StuErrorLibEN> arrObjLstCache = GetObjLstCache(strCourseId, strIdStudentInfo);
IEnumerable <clsge_StuErrorLibEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conge_StuErrorLib.AttributeName)
{
if (objge_StuErrorLibCond.IsUpdated(strFldName) == false) continue;
if (objge_StuErrorLibCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objge_StuErrorLibCond[strFldName].ToString());
}
else
{
if (objge_StuErrorLibCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objge_StuErrorLibCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objge_StuErrorLibCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objge_StuErrorLibCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objge_StuErrorLibCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objge_StuErrorLibCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objge_StuErrorLibCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objge_StuErrorLibCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objge_StuErrorLibCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objge_StuErrorLibCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objge_StuErrorLibCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objge_StuErrorLibCond[strFldName]));
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
 List<string> arrList = clsge_StuErrorLibDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = ge_StuErrorLibDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = ge_StuErrorLibDA.GetFldValueNoDistinct(strFldName, strWhereCond);
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
int intRecCount = ge_StuErrorLibDA.SetFldValue(strFldName, strValue, strWhereCond);
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
int intRecCount = clsge_StuErrorLibDA.SetFldValue(clsge_StuErrorLibEN._CurrTabName, strFldName, fltValue, strWhereCond);
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
int intRecCount = ge_StuErrorLibDA.SetFldValue( strFldName, intValue, strWhereCond);
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
int intRecCount = clsge_StuErrorLibDA.SetFldValue(strTabName, strFldName, strValue, strWhereCond);
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
int intRecCount = clsge_StuErrorLibDA.SetFldValue(strTabName, strFldName, intValue, strWhereCond);
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
int intRecCount = clsge_StuErrorLibDA.SetFldValue(strTabName, strFldName, fltValue, strWhereCond);
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
  strCreateTabCode.Append("CREATE table [dbo].[ge_StuErrorLib] "); 
 strCreateTabCode.Append(" ( "); 
 // /**mId*/ 
 strCreateTabCode.Append(" mId bigint primary key identity, "); 
 // /**课程Id*/ 
 strCreateTabCode.Append(" CourseId char(8) not Null, "); 
 // /**学生流水号*/ 
 strCreateTabCode.Append(" IdStudentInfo char(8) not Null, "); 
 // /**题目Id*/ 
 strCreateTabCode.Append(" QuestionId bigint not Null, "); 
 // /**创建者*/ 
 strCreateTabCode.Append(" Creator varchar(18) Null, "); 
 // /**建立日期*/ 
 strCreateTabCode.Append(" CreateDate varchar(20) Null, "); 
 // /**来源类型Id*/ 
 strCreateTabCode.Append(" SourceTypeId char(2) not Null, "); 
 // /**是否重做*/ 
 strCreateTabCode.Append(" IsRedo bit Null, "); 
 // /**重做日期*/ 
 strCreateTabCode.Append(" RedoDate varchar(8) Null, "); 
 // /**是否通过*/ 
 strCreateTabCode.Append(" IsPassed bit Null, "); 
 // /**修改日期*/ 
 strCreateTabCode.Append(" UpdDate varchar(20) Null, "); 
 // /**修改人*/ 
 strCreateTabCode.Append(" UpdUser varchar(20) Null, "); 
 // /**备注*/ 
 strCreateTabCode.Append(" Memo varchar(1000) Null, "); 
 // /**来源类型名称*/ 
 strCreateTabCode.Append(" SourceTypeName varchar(20) Null, "); 
 // /**课程名称*/ 
 strCreateTabCode.Append(" CourseName varchar(100) Null, "); 
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
 /// 学生错误作业集(ge_StuErrorLib)
 /// 数据源类型:表
 /// (AutoGCLib.CommFun4BL4CSharp:GeneCode_This)
 /// </summary>
public class  clsCommFun4BL4ge_StuErrorLib : clsCommFun4BLV3
{

 /// <summary>
 /// 刷新缓存.把当前表的缓存以及该表相关视图的缓存清空.
 /// (AutoGCLib.CommFun4BL4CSharp:Gen_4CFBL_ReFreshCache)
 /// </summary>
public override void ReFreshCache(string strCourseId,string strIdStudentInfo)
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
clsge_StuErrorLibBL.ReFreshThisCache(strCourseId, strIdStudentInfo);
}
}

}