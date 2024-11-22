
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clscc_WorkBL
 表名:cc_Work(01120144)
 * 版本:2024.11.13.1(服务器:WIN-SRV103-116)
 日期:2024/11/13 06:19:36
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
public static class  clscc_WorkBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "strIdWork">表关键字</param>
 /// <returns>表对象</returns>
public static clscc_WorkEN GetObj(this K_IdWork_cc_Work myKey)
{
clscc_WorkEN objcc_WorkEN = clscc_WorkBL.cc_WorkDA.GetObjByIdWork(myKey.Value);
return objcc_WorkEN;
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_AddNewRecord)
 /// </summary>
 /// <param name = "objcc_WorkEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clscc_WorkEN objcc_WorkEN, bool bolIsNeedCheckUniqueness = true)
{
if (bolIsNeedCheckUniqueness == true && CheckUniqueness(objcc_WorkEN) == false)
{
var strMsg = string.Format("记录已经存在!作业名称 = [{0}],课程Id = [{1}]的数据已经存在!(in clscc_WorkBL.AddNewRecord)", objcc_WorkEN.WorkName,objcc_WorkEN.CourseId);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objcc_WorkEN.IdWork) == true || clscc_WorkBL.IsExist(objcc_WorkEN.IdWork) == true)
 {
     objcc_WorkEN.IdWork = clscc_WorkBL.GetMaxStrId_S();
 }
bool bolResult = clscc_WorkBL.cc_WorkDA.AddNewRecordBySQL2(objcc_WorkEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clscc_WorkBL.ReFreshCache();

if (clscc_WorkBL.relatedActions != null)
{
clscc_WorkBL.relatedActions.UpdRelaTabDate(objcc_WorkEN.IdWork, objcc_WorkEN.UpdUserId);
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
public static bool AddRecordEx(this clscc_WorkEN objcc_WorkEN, bool bolIsNeedCheckUniqueness = true)
{
//操作步骤:
//1、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在
//2、检查唯一性
//3、检查传进去的对象属性是否合法
//4、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
//1、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在

//因为是字符型自增主键,不需要检查主键是否已经存在,在添加时,再获取 最大值作为主键
//if (clscc_WorkBL.IsExist(objcc_WorkEN.IdWork))	//判断是否有相同的关键字
//{
//strMsg = "(errid:Busi000151)关键字字段已有相同的值";
//throw new Exception(strMsg);
//}
try
{
 //2、检查传进去的对象属性是否合法
objcc_WorkEN.CheckPropertyNew();
 ///5.2、检查唯一性
if (bolIsNeedCheckUniqueness == true && objcc_WorkEN.CheckUniqueness() == false)
{
strMsg = string.Format("(作业名称(WorkName)=[{0}],课程Id(CourseId)=[{1}])已经存在,不能重复!", objcc_WorkEN.WorkName, objcc_WorkEN.CourseId);
throw new Exception(strMsg);
}
//因为是字符型自增主键,所以在添加时,自动获取主键值。
 if (string.IsNullOrEmpty(objcc_WorkEN.IdWork) == true || clscc_WorkBL.IsExist(objcc_WorkEN.IdWork) == true)
 {
     objcc_WorkEN.IdWork = clscc_WorkBL.GetMaxStrId_S();
 }
//6、把数据实体层的数据存贮到数据库中
objcc_WorkEN.AddNewRecord();
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
 /// <param name = "objcc_WorkEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static string AddNewRecordWithMaxId(this clscc_WorkEN objcc_WorkEN, bool bolIsNeedCheckUniqueness = true)
{
if (bolIsNeedCheckUniqueness == true && CheckUniqueness(objcc_WorkEN) == false)
{
var strMsg = string.Format("记录已经存在!作业名称 = [{0}],课程Id = [{1}]的数据已经存在!(in clscc_WorkBL.AddNewRecordWithMaxId)", objcc_WorkEN.WorkName,objcc_WorkEN.CourseId);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objcc_WorkEN.IdWork) == true || clscc_WorkBL.IsExist(objcc_WorkEN.IdWork) == true)
 {
     objcc_WorkEN.IdWork = clscc_WorkBL.GetMaxStrId_S();
 }
string strIdWork = clscc_WorkBL.cc_WorkDA.AddNewRecordBySQL2WithReturnKey(objcc_WorkEN);
     objcc_WorkEN.IdWork = strIdWork;
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clscc_WorkBL.ReFreshCache();

if (clscc_WorkBL.relatedActions != null)
{
clscc_WorkBL.relatedActions.UpdRelaTabDate(objcc_WorkEN.IdWork, objcc_WorkEN.UpdUserId);
}
return strIdWork;
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
 /// <param name = "objcc_WorkEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordWithReturnKey(this clscc_WorkEN objcc_WorkEN, bool bolIsNeedCheckUniqueness = true)
{
if (bolIsNeedCheckUniqueness == true && CheckUniqueness(objcc_WorkEN) == false)
{
var strMsg = string.Format("记录已经存在!作业名称 = [{0}],课程Id = [{1}]的数据已经存在!(in clscc_WorkBL.AddNewRecordWithReturnKey)", objcc_WorkEN.WorkName,objcc_WorkEN.CourseId);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objcc_WorkEN.IdWork) == true || clscc_WorkBL.IsExist(objcc_WorkEN.IdWork) == true)
 {
     objcc_WorkEN.IdWork = clscc_WorkBL.GetMaxStrId_S();
 }
string strKey = clscc_WorkBL.cc_WorkDA.AddNewRecordBySQL2WithReturnKey(objcc_WorkEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clscc_WorkBL.ReFreshCache();

if (clscc_WorkBL.relatedActions != null)
{
clscc_WorkBL.relatedActions.UpdRelaTabDate(objcc_WorkEN.IdWork, objcc_WorkEN.UpdUserId);
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
 /// <param name = "objcc_WorkEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clscc_WorkEN SetIdWork(this clscc_WorkEN objcc_WorkEN, string strIdWork, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdWork, 8, concc_Work.IdWork);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdWork, 8, concc_Work.IdWork);
}
objcc_WorkEN.IdWork = strIdWork; //作业流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_WorkEN.dicFldComparisonOp.ContainsKey(concc_Work.IdWork) == false)
{
objcc_WorkEN.dicFldComparisonOp.Add(concc_Work.IdWork, strComparisonOp);
}
else
{
objcc_WorkEN.dicFldComparisonOp[concc_Work.IdWork] = strComparisonOp;
}
}
return objcc_WorkEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_WorkEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clscc_WorkEN SetWorkIndex(this clscc_WorkEN objcc_WorkEN, int? intWorkIndex, string strComparisonOp="")
	{
objcc_WorkEN.WorkIndex = intWorkIndex; //作业序号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_WorkEN.dicFldComparisonOp.ContainsKey(concc_Work.WorkIndex) == false)
{
objcc_WorkEN.dicFldComparisonOp.Add(concc_Work.WorkIndex, strComparisonOp);
}
else
{
objcc_WorkEN.dicFldComparisonOp[concc_Work.WorkIndex] = strComparisonOp;
}
}
return objcc_WorkEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_WorkEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clscc_WorkEN SetWorkName(this clscc_WorkEN objcc_WorkEN, string strWorkName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strWorkName, concc_Work.WorkName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strWorkName, 5000, concc_Work.WorkName);
}
objcc_WorkEN.WorkName = strWorkName; //作业名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_WorkEN.dicFldComparisonOp.ContainsKey(concc_Work.WorkName) == false)
{
objcc_WorkEN.dicFldComparisonOp.Add(concc_Work.WorkName, strComparisonOp);
}
else
{
objcc_WorkEN.dicFldComparisonOp[concc_Work.WorkName] = strComparisonOp;
}
}
return objcc_WorkEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_WorkEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clscc_WorkEN SetWorkDesc(this clscc_WorkEN objcc_WorkEN, string strWorkDesc, string strComparisonOp="")
	{
objcc_WorkEN.WorkDesc = strWorkDesc; //作业说明
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_WorkEN.dicFldComparisonOp.ContainsKey(concc_Work.WorkDesc) == false)
{
objcc_WorkEN.dicFldComparisonOp.Add(concc_Work.WorkDesc, strComparisonOp);
}
else
{
objcc_WorkEN.dicFldComparisonOp[concc_Work.WorkDesc] = strComparisonOp;
}
}
return objcc_WorkEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_WorkEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clscc_WorkEN SetCourseId(this clscc_WorkEN objcc_WorkEN, string strCourseId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strCourseId, concc_Work.CourseId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCourseId, 8, concc_Work.CourseId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strCourseId, 8, concc_Work.CourseId);
}
objcc_WorkEN.CourseId = strCourseId; //课程Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_WorkEN.dicFldComparisonOp.ContainsKey(concc_Work.CourseId) == false)
{
objcc_WorkEN.dicFldComparisonOp.Add(concc_Work.CourseId, strComparisonOp);
}
else
{
objcc_WorkEN.dicFldComparisonOp[concc_Work.CourseId] = strComparisonOp;
}
}
return objcc_WorkEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_WorkEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clscc_WorkEN SetCourseChapterId(this clscc_WorkEN objcc_WorkEN, string strCourseChapterId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCourseChapterId, 8, concc_Work.CourseChapterId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strCourseChapterId, 8, concc_Work.CourseChapterId);
}
objcc_WorkEN.CourseChapterId = strCourseChapterId; //课程章节ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_WorkEN.dicFldComparisonOp.ContainsKey(concc_Work.CourseChapterId) == false)
{
objcc_WorkEN.dicFldComparisonOp.Add(concc_Work.CourseChapterId, strComparisonOp);
}
else
{
objcc_WorkEN.dicFldComparisonOp[concc_Work.CourseChapterId] = strComparisonOp;
}
}
return objcc_WorkEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_WorkEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clscc_WorkEN SetCreator(this clscc_WorkEN objcc_WorkEN, string strCreator, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCreator, 18, concc_Work.Creator);
}
objcc_WorkEN.Creator = strCreator; //创建者
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_WorkEN.dicFldComparisonOp.ContainsKey(concc_Work.Creator) == false)
{
objcc_WorkEN.dicFldComparisonOp.Add(concc_Work.Creator, strComparisonOp);
}
else
{
objcc_WorkEN.dicFldComparisonOp[concc_Work.Creator] = strComparisonOp;
}
}
return objcc_WorkEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_WorkEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clscc_WorkEN SetCreateDate(this clscc_WorkEN objcc_WorkEN, string strCreateDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCreateDate, 20, concc_Work.CreateDate);
}
objcc_WorkEN.CreateDate = strCreateDate; //建立日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_WorkEN.dicFldComparisonOp.ContainsKey(concc_Work.CreateDate) == false)
{
objcc_WorkEN.dicFldComparisonOp.Add(concc_Work.CreateDate, strComparisonOp);
}
else
{
objcc_WorkEN.dicFldComparisonOp[concc_Work.CreateDate] = strComparisonOp;
}
}
return objcc_WorkEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_WorkEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clscc_WorkEN SetAnswerAttLimitSize(this clscc_WorkEN objcc_WorkEN, long? lngAnswerAttLimitSize, string strComparisonOp="")
	{
objcc_WorkEN.AnswerAttLimitSize = lngAnswerAttLimitSize; //回答附件限制大小
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_WorkEN.dicFldComparisonOp.ContainsKey(concc_Work.AnswerAttLimitSize) == false)
{
objcc_WorkEN.dicFldComparisonOp.Add(concc_Work.AnswerAttLimitSize, strComparisonOp);
}
else
{
objcc_WorkEN.dicFldComparisonOp[concc_Work.AnswerAttLimitSize] = strComparisonOp;
}
}
return objcc_WorkEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_WorkEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clscc_WorkEN SetLimitedResourceType(this clscc_WorkEN objcc_WorkEN, string strLimitedResourceType, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strLimitedResourceType, 100, concc_Work.LimitedResourceType);
}
objcc_WorkEN.LimitedResourceType = strLimitedResourceType; //限制资源类型
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_WorkEN.dicFldComparisonOp.ContainsKey(concc_Work.LimitedResourceType) == false)
{
objcc_WorkEN.dicFldComparisonOp.Add(concc_Work.LimitedResourceType, strComparisonOp);
}
else
{
objcc_WorkEN.dicFldComparisonOp[concc_Work.LimitedResourceType] = strComparisonOp;
}
}
return objcc_WorkEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_WorkEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clscc_WorkEN SetUpdDate(this clscc_WorkEN objcc_WorkEN, string strUpdDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strUpdDate, concc_Work.UpdDate);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdDate, 20, concc_Work.UpdDate);
}
objcc_WorkEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_WorkEN.dicFldComparisonOp.ContainsKey(concc_Work.UpdDate) == false)
{
objcc_WorkEN.dicFldComparisonOp.Add(concc_Work.UpdDate, strComparisonOp);
}
else
{
objcc_WorkEN.dicFldComparisonOp[concc_Work.UpdDate] = strComparisonOp;
}
}
return objcc_WorkEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_WorkEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clscc_WorkEN SetUpdUserId(this clscc_WorkEN objcc_WorkEN, string strUpdUserId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdUserId, 20, concc_Work.UpdUserId);
}
objcc_WorkEN.UpdUserId = strUpdUserId; //修改用户Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_WorkEN.dicFldComparisonOp.ContainsKey(concc_Work.UpdUserId) == false)
{
objcc_WorkEN.dicFldComparisonOp.Add(concc_Work.UpdUserId, strComparisonOp);
}
else
{
objcc_WorkEN.dicFldComparisonOp[concc_Work.UpdUserId] = strComparisonOp;
}
}
return objcc_WorkEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_WorkEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clscc_WorkEN SetMemo(this clscc_WorkEN objcc_WorkEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, concc_Work.Memo);
}
objcc_WorkEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_WorkEN.dicFldComparisonOp.ContainsKey(concc_Work.Memo) == false)
{
objcc_WorkEN.dicFldComparisonOp.Add(concc_Work.Memo, strComparisonOp);
}
else
{
objcc_WorkEN.dicFldComparisonOp[concc_Work.Memo] = strComparisonOp;
}
}
return objcc_WorkEN;
	}

 /// <summary>
 /// 修改记录存盘到数据表中
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_UpdateRecordEx)
 /// </summary>
 /// <param name = "objcc_WorkEN">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool UpdateRecordEx(this clscc_WorkEN objcc_WorkEN)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
try
{
//1、检查传进去的对象属性是否合法
objcc_WorkEN.CheckPropertyNew();
clscc_WorkEN objcc_WorkCond = new clscc_WorkEN();
string strCondition = objcc_WorkCond
.SetIdWork(objcc_WorkEN.IdWork, "<>")
.SetWorkName(objcc_WorkEN.WorkName, "=")
.SetCourseId(objcc_WorkEN.CourseId, "=")
.GetCombineCondition();
objcc_WorkEN._IsCheckProperty = true;
bool bolIsExist = clscc_WorkBL.IsExistRecord(strCondition);
if (bolIsExist)
{
strMsg = "(WorkName_CourseId)不能重复!";
throw new Exception(strMsg);
}
//4、把数据实体层的数据存贮到数据库中
objcc_WorkEN.Update();
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
 /// <param name = "objcc_Work">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool EditRecordEx(this clscc_WorkEN objcc_Work)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
clscc_WorkEN objcc_WorkCond = new clscc_WorkEN();
string strCondition = objcc_WorkCond
.SetWorkName(objcc_Work.WorkName, "=")
.SetCourseId(objcc_Work.CourseId, "=")
.GetCombineCondition();
objcc_Work._IsCheckProperty = true;
bool bolIsExist = clscc_WorkBL.IsExistRecord(strCondition);
if (bolIsExist)
{
objcc_Work.IdWork = clscc_WorkBL.GetFirstID_S(strCondition);
objcc_Work.UpdateWithCondition(strCondition);
}
else
{
objcc_Work.IdWork = clscc_WorkBL.GetMaxStrId_S();
objcc_Work.AddNewRecord();
}
return true; 
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_Update)
 /// </summary>
 /// <param name = "objcc_WorkEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clscc_WorkEN objcc_WorkEN)
{
 if (string.IsNullOrEmpty(objcc_WorkEN.IdWork) == true)
 {
string strMsg = string.Format("(errid:Busi000095)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clscc_WorkBL.cc_WorkDA.UpdateBySql2(objcc_WorkEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clscc_WorkBL.ReFreshCache();

if (clscc_WorkBL.relatedActions != null)
{
clscc_WorkBL.relatedActions.UpdRelaTabDate(objcc_WorkEN.IdWork, objcc_WorkEN.UpdUserId);
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
 /// <param name = "objcc_WorkEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clscc_WorkEN objcc_WorkEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (string.IsNullOrEmpty(objcc_WorkEN.IdWork) == true)
 {
string strMsg = string.Format("(errid:Busi000087)修改记录时关键字不能为空!(带事务处理)(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clscc_WorkBL.cc_WorkDA.UpdateBySql2(objcc_WorkEN, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clscc_WorkBL.ReFreshCache();

if (clscc_WorkBL.relatedActions != null)
{
clscc_WorkBL.relatedActions.UpdRelaTabDate(objcc_WorkEN.IdWork, objcc_WorkEN.UpdUserId);
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
 /// <param name = "objcc_WorkEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clscc_WorkEN objcc_WorkEN, string strWhereCond)
{
try
{
bool bolResult = clscc_WorkBL.cc_WorkDA.UpdateBySqlWithCondition(objcc_WorkEN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clscc_WorkBL.ReFreshCache();

if (clscc_WorkBL.relatedActions != null)
{
clscc_WorkBL.relatedActions.UpdRelaTabDate(objcc_WorkEN.IdWork, objcc_WorkEN.UpdUserId);
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
 /// <param name = "objcc_WorkEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clscc_WorkEN objcc_WorkEN, string strWhereCond, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
bool bolResult = clscc_WorkBL.cc_WorkDA.UpdateBySqlWithConditionTransaction(objcc_WorkEN, strWhereCond, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clscc_WorkBL.ReFreshCache();

if (clscc_WorkBL.relatedActions != null)
{
clscc_WorkBL.relatedActions.UpdRelaTabDate(objcc_WorkEN.IdWork, objcc_WorkEN.UpdUserId);
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
 /// <param name = "strIdWork">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int Delete(this clscc_WorkEN objcc_WorkEN)
{
try
{
int intRecNum = clscc_WorkBL.cc_WorkDA.DelRecord(objcc_WorkEN.IdWork);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clscc_WorkBL.ReFreshCache();

if (clscc_WorkBL.relatedActions != null)
{
clscc_WorkBL.relatedActions.UpdRelaTabDate(objcc_WorkEN.IdWork, objcc_WorkEN.UpdUserId);
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
 /// <param name = "objcc_WorkENS">源对象</param>
 /// <param name = "objcc_WorkENT">目标对象</param>
 public static void CopyTo(this clscc_WorkEN objcc_WorkENS, clscc_WorkEN objcc_WorkENT)
{
try
{
objcc_WorkENT.IdWork = objcc_WorkENS.IdWork; //作业流水号
objcc_WorkENT.WorkIndex = objcc_WorkENS.WorkIndex; //作业序号
objcc_WorkENT.WorkName = objcc_WorkENS.WorkName; //作业名称
objcc_WorkENT.WorkDesc = objcc_WorkENS.WorkDesc; //作业说明
objcc_WorkENT.CourseId = objcc_WorkENS.CourseId; //课程Id
objcc_WorkENT.CourseChapterId = objcc_WorkENS.CourseChapterId; //课程章节ID
objcc_WorkENT.Creator = objcc_WorkENS.Creator; //创建者
objcc_WorkENT.CreateDate = objcc_WorkENS.CreateDate; //建立日期
objcc_WorkENT.AnswerAttLimitSize = objcc_WorkENS.AnswerAttLimitSize; //回答附件限制大小
objcc_WorkENT.LimitedResourceType = objcc_WorkENS.LimitedResourceType; //限制资源类型
objcc_WorkENT.UpdDate = objcc_WorkENS.UpdDate; //修改日期
objcc_WorkENT.UpdUserId = objcc_WorkENS.UpdUserId; //修改用户Id
objcc_WorkENT.Memo = objcc_WorkENS.Memo; //备注
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
 /// <param name = "objcc_WorkENS">源对象</param>
 /// <returns>目标对象=>clscc_WorkEN:objcc_WorkENT</returns>
 public static clscc_WorkEN CopyTo(this clscc_WorkEN objcc_WorkENS)
{
try
{
 clscc_WorkEN objcc_WorkENT = new clscc_WorkEN()
{
IdWork = objcc_WorkENS.IdWork, //作业流水号
WorkIndex = objcc_WorkENS.WorkIndex, //作业序号
WorkName = objcc_WorkENS.WorkName, //作业名称
WorkDesc = objcc_WorkENS.WorkDesc, //作业说明
CourseId = objcc_WorkENS.CourseId, //课程Id
CourseChapterId = objcc_WorkENS.CourseChapterId, //课程章节ID
Creator = objcc_WorkENS.Creator, //创建者
CreateDate = objcc_WorkENS.CreateDate, //建立日期
AnswerAttLimitSize = objcc_WorkENS.AnswerAttLimitSize, //回答附件限制大小
LimitedResourceType = objcc_WorkENS.LimitedResourceType, //限制资源类型
UpdDate = objcc_WorkENS.UpdDate, //修改日期
UpdUserId = objcc_WorkENS.UpdUserId, //修改用户Id
Memo = objcc_WorkENS.Memo, //备注
};
 return objcc_WorkENT;
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
public static void CheckPropertyNew(this clscc_WorkEN objcc_WorkEN)
{
 clscc_WorkBL.cc_WorkDA.CheckPropertyNew(objcc_WorkEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(this clscc_WorkEN objcc_WorkEN)
{
 clscc_WorkBL.cc_WorkDA.CheckProperty4Condition(objcc_WorkEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clscc_WorkEN objcc_WorkCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objcc_WorkCond.IsUpdated(concc_Work.IdWork) == true)
{
string strComparisonOpIdWork = objcc_WorkCond.dicFldComparisonOp[concc_Work.IdWork];
strWhereCond += string.Format(" And {0} {2} '{1}'", concc_Work.IdWork, objcc_WorkCond.IdWork, strComparisonOpIdWork);
}
if (objcc_WorkCond.IsUpdated(concc_Work.WorkIndex) == true)
{
string strComparisonOpWorkIndex = objcc_WorkCond.dicFldComparisonOp[concc_Work.WorkIndex];
strWhereCond += string.Format(" And {0} {2} {1}", concc_Work.WorkIndex, objcc_WorkCond.WorkIndex, strComparisonOpWorkIndex);
}
if (objcc_WorkCond.IsUpdated(concc_Work.WorkName) == true)
{
string strComparisonOpWorkName = objcc_WorkCond.dicFldComparisonOp[concc_Work.WorkName];
strWhereCond += string.Format(" And {0} {2} '{1}'", concc_Work.WorkName, objcc_WorkCond.WorkName, strComparisonOpWorkName);
}
//数据类型string(text)在函数:[AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj]中没有处理!
if (objcc_WorkCond.IsUpdated(concc_Work.CourseId) == true)
{
string strComparisonOpCourseId = objcc_WorkCond.dicFldComparisonOp[concc_Work.CourseId];
strWhereCond += string.Format(" And {0} {2} '{1}'", concc_Work.CourseId, objcc_WorkCond.CourseId, strComparisonOpCourseId);
}
if (objcc_WorkCond.IsUpdated(concc_Work.CourseChapterId) == true)
{
string strComparisonOpCourseChapterId = objcc_WorkCond.dicFldComparisonOp[concc_Work.CourseChapterId];
strWhereCond += string.Format(" And {0} {2} '{1}'", concc_Work.CourseChapterId, objcc_WorkCond.CourseChapterId, strComparisonOpCourseChapterId);
}
if (objcc_WorkCond.IsUpdated(concc_Work.Creator) == true)
{
string strComparisonOpCreator = objcc_WorkCond.dicFldComparisonOp[concc_Work.Creator];
strWhereCond += string.Format(" And {0} {2} '{1}'", concc_Work.Creator, objcc_WorkCond.Creator, strComparisonOpCreator);
}
if (objcc_WorkCond.IsUpdated(concc_Work.CreateDate) == true)
{
string strComparisonOpCreateDate = objcc_WorkCond.dicFldComparisonOp[concc_Work.CreateDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", concc_Work.CreateDate, objcc_WorkCond.CreateDate, strComparisonOpCreateDate);
}
if (objcc_WorkCond.IsUpdated(concc_Work.AnswerAttLimitSize) == true)
{
string strComparisonOpAnswerAttLimitSize = objcc_WorkCond.dicFldComparisonOp[concc_Work.AnswerAttLimitSize];
strWhereCond += string.Format(" And {0} {2} {1}", concc_Work.AnswerAttLimitSize, objcc_WorkCond.AnswerAttLimitSize, strComparisonOpAnswerAttLimitSize);
}
if (objcc_WorkCond.IsUpdated(concc_Work.LimitedResourceType) == true)
{
string strComparisonOpLimitedResourceType = objcc_WorkCond.dicFldComparisonOp[concc_Work.LimitedResourceType];
strWhereCond += string.Format(" And {0} {2} '{1}'", concc_Work.LimitedResourceType, objcc_WorkCond.LimitedResourceType, strComparisonOpLimitedResourceType);
}
if (objcc_WorkCond.IsUpdated(concc_Work.UpdDate) == true)
{
string strComparisonOpUpdDate = objcc_WorkCond.dicFldComparisonOp[concc_Work.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", concc_Work.UpdDate, objcc_WorkCond.UpdDate, strComparisonOpUpdDate);
}
if (objcc_WorkCond.IsUpdated(concc_Work.UpdUserId) == true)
{
string strComparisonOpUpdUserId = objcc_WorkCond.dicFldComparisonOp[concc_Work.UpdUserId];
strWhereCond += string.Format(" And {0} {2} '{1}'", concc_Work.UpdUserId, objcc_WorkCond.UpdUserId, strComparisonOpUpdUserId);
}
if (objcc_WorkCond.IsUpdated(concc_Work.Memo) == true)
{
string strComparisonOpMemo = objcc_WorkCond.dicFldComparisonOp[concc_Work.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", concc_Work.Memo, objcc_WorkCond.Memo, strComparisonOpMemo);
}
 return strWhereCond;
}

 /// <summary>
 /// 检查唯一性(Uniqueness)--cc_Work(作业), 如果不唯一,即存在相同的记录,就返回False
 /// 唯一性条件:WorkName_CourseId
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckConstraint)
 /// </summary>
 /// <param name = "objcc_WorkEN">要求唯一的对象</param>
 /// <returns></returns>
public static bool CheckUniqueness(this clscc_WorkEN objcc_WorkEN)
{
//检测记录是否存在
bool bolIsUniqueness;
StringBuilder sbCondition = new StringBuilder();
if (objcc_WorkEN == null) return true;
if (objcc_WorkEN.IdWork == null || objcc_WorkEN.IdWork == "")
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and WorkName = '{0}'", objcc_WorkEN.WorkName);
 sbCondition.AppendFormat(" and CourseId = '{0}'", objcc_WorkEN.CourseId);
if (clscc_WorkBL.IsExistRecord(sbCondition.ToString())  ==  true)
{
 bolIsUniqueness = false;
}
else
{
 bolIsUniqueness = true;
}
}
 else {
sbCondition.AppendFormat("IdWork !=  '{0}'", objcc_WorkEN.IdWork);
 sbCondition.AppendFormat(" and WorkName = '{0}'", objcc_WorkEN.WorkName);
 sbCondition.AppendFormat(" and CourseId = '{0}'", objcc_WorkEN.CourseId);
if (clscc_WorkBL.IsExistRecord(sbCondition.ToString())  ==  true)
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
 /// 获取唯一性条件串--cc_Work(作业), 即由对象中唯一性条件字段关键字与值组成的条件串
 /// 唯一性条件:WorkName_CourseId
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetConditionString4Constraint)
 /// </summary>
 /// <param name = "objcc_WorkEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(this clscc_WorkEN objcc_WorkEN)
{
//检测记录是否存在
StringBuilder sbCondition = new StringBuilder();
if (objcc_WorkEN == null) return "";
if (objcc_WorkEN.IdWork == null || objcc_WorkEN.IdWork == "")
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and WorkName = '{0}'", objcc_WorkEN.WorkName);
 sbCondition.AppendFormat(" and CourseId = '{0}'", objcc_WorkEN.CourseId);
return sbCondition.ToString();
}
 else {
sbCondition.AppendFormat("IdWork !=  '{0}'", objcc_WorkEN.IdWork);
 sbCondition.AppendFormat(" and WorkName = '{0}'", objcc_WorkEN.WorkName);
 sbCondition.AppendFormat(" and CourseId = '{0}'", objcc_WorkEN.CourseId);
 return sbCondition.ToString();
}
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_cc_Work
{
public virtual bool UpdRelaTabDate(string strIdWork, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// 作业(cc_Work)
 /// 数据源类型:表
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clscc_WorkBL
{
public static RelatedActions_cc_Work relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clscc_WorkDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clscc_WorkDA cc_WorkDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clscc_WorkDA();
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
 public clscc_WorkBL()
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
if (string.IsNullOrEmpty(clscc_WorkEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clscc_WorkEN._ConnectString);
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
public static DataTable GetDataTable_cc_Work(string strWhereCond)
{
DataTable objDT;
try
{
objDT = cc_WorkDA.GetDataTable_cc_Work(strWhereCond);
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
objDT = cc_WorkDA.GetDataTable(strWhereCond);
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
objDT = cc_WorkDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = cc_WorkDA.GetDataTable(strWhereCond, strTabName);
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
objDT = cc_WorkDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = cc_WorkDA.GetDataTable_Top(objTopPara);
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
objDT = cc_WorkDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = cc_WorkDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = cc_WorkDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
 /// <param name = "arrIdWorkLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static List<clscc_WorkEN> GetObjLstByIdWorkLst(List<string> arrIdWorkLst)
{
List<clscc_WorkEN> arrObjLst = new List<clscc_WorkEN>(); 
System.Data.DataTable objDT; 
 string strSqlConditionStr = clsArray.GetSqlInStrByArray(arrIdWorkLst, true);
 string strWhereCond = string.Format("IdWork in ({0})", strSqlConditionStr);
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clscc_WorkEN objcc_WorkEN = new clscc_WorkEN();
try
{
objcc_WorkEN.IdWork = objRow[concc_Work.IdWork].ToString().Trim(); //作业流水号
objcc_WorkEN.WorkIndex = objRow[concc_Work.WorkIndex] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[concc_Work.WorkIndex].ToString().Trim()); //作业序号
objcc_WorkEN.WorkName = objRow[concc_Work.WorkName].ToString().Trim(); //作业名称
objcc_WorkEN.WorkDesc = objRow[concc_Work.WorkDesc] == DBNull.Value ? null : objRow[concc_Work.WorkDesc].ToString().Trim(); //作业说明
objcc_WorkEN.CourseId = objRow[concc_Work.CourseId].ToString().Trim(); //课程Id
objcc_WorkEN.CourseChapterId = objRow[concc_Work.CourseChapterId] == DBNull.Value ? null : objRow[concc_Work.CourseChapterId].ToString().Trim(); //课程章节ID
objcc_WorkEN.Creator = objRow[concc_Work.Creator] == DBNull.Value ? null : objRow[concc_Work.Creator].ToString().Trim(); //创建者
objcc_WorkEN.CreateDate = objRow[concc_Work.CreateDate] == DBNull.Value ? null : objRow[concc_Work.CreateDate].ToString().Trim(); //建立日期
objcc_WorkEN.AnswerAttLimitSize = objRow[concc_Work.AnswerAttLimitSize] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[concc_Work.AnswerAttLimitSize].ToString().Trim()); //回答附件限制大小
objcc_WorkEN.LimitedResourceType = objRow[concc_Work.LimitedResourceType] == DBNull.Value ? null : objRow[concc_Work.LimitedResourceType].ToString().Trim(); //限制资源类型
objcc_WorkEN.UpdDate = objRow[concc_Work.UpdDate].ToString().Trim(); //修改日期
objcc_WorkEN.UpdUserId = objRow[concc_Work.UpdUserId] == DBNull.Value ? null : objRow[concc_Work.UpdUserId].ToString().Trim(); //修改用户Id
objcc_WorkEN.Memo = objRow[concc_Work.Memo] == DBNull.Value ? null : objRow[concc_Work.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objcc_WorkEN.IdWork, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objcc_WorkEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrIdWorkLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clscc_WorkEN> GetObjLstByIdWorkLstCache(List<string> arrIdWorkLst)
{
string strKey = string.Format("{0}", clscc_WorkEN._CurrTabName);
List<clscc_WorkEN> arrcc_WorkObjLstCache = GetObjLstCache();
IEnumerable <clscc_WorkEN> arrcc_WorkObjLst_Sel =
arrcc_WorkObjLstCache
.Where(x => arrIdWorkLst.Contains(x.IdWork));
return arrcc_WorkObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clscc_WorkEN> GetObjLst(string strWhereCond)
{
List<clscc_WorkEN> arrObjLst = new List<clscc_WorkEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clscc_WorkEN objcc_WorkEN = new clscc_WorkEN();
try
{
objcc_WorkEN.IdWork = objRow[concc_Work.IdWork].ToString().Trim(); //作业流水号
objcc_WorkEN.WorkIndex = objRow[concc_Work.WorkIndex] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[concc_Work.WorkIndex].ToString().Trim()); //作业序号
objcc_WorkEN.WorkName = objRow[concc_Work.WorkName].ToString().Trim(); //作业名称
objcc_WorkEN.WorkDesc = objRow[concc_Work.WorkDesc] == DBNull.Value ? null : objRow[concc_Work.WorkDesc].ToString().Trim(); //作业说明
objcc_WorkEN.CourseId = objRow[concc_Work.CourseId].ToString().Trim(); //课程Id
objcc_WorkEN.CourseChapterId = objRow[concc_Work.CourseChapterId] == DBNull.Value ? null : objRow[concc_Work.CourseChapterId].ToString().Trim(); //课程章节ID
objcc_WorkEN.Creator = objRow[concc_Work.Creator] == DBNull.Value ? null : objRow[concc_Work.Creator].ToString().Trim(); //创建者
objcc_WorkEN.CreateDate = objRow[concc_Work.CreateDate] == DBNull.Value ? null : objRow[concc_Work.CreateDate].ToString().Trim(); //建立日期
objcc_WorkEN.AnswerAttLimitSize = objRow[concc_Work.AnswerAttLimitSize] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[concc_Work.AnswerAttLimitSize].ToString().Trim()); //回答附件限制大小
objcc_WorkEN.LimitedResourceType = objRow[concc_Work.LimitedResourceType] == DBNull.Value ? null : objRow[concc_Work.LimitedResourceType].ToString().Trim(); //限制资源类型
objcc_WorkEN.UpdDate = objRow[concc_Work.UpdDate].ToString().Trim(); //修改日期
objcc_WorkEN.UpdUserId = objRow[concc_Work.UpdUserId] == DBNull.Value ? null : objRow[concc_Work.UpdUserId].ToString().Trim(); //修改用户Id
objcc_WorkEN.Memo = objRow[concc_Work.Memo] == DBNull.Value ? null : objRow[concc_Work.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objcc_WorkEN.IdWork, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objcc_WorkEN);
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
public static List<clscc_WorkEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clscc_WorkEN> arrObjLst = new List<clscc_WorkEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clscc_WorkEN objcc_WorkEN = new clscc_WorkEN();
try
{
objcc_WorkEN.IdWork = objRow[concc_Work.IdWork].ToString().Trim(); //作业流水号
objcc_WorkEN.WorkIndex = objRow[concc_Work.WorkIndex] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[concc_Work.WorkIndex].ToString().Trim()); //作业序号
objcc_WorkEN.WorkName = objRow[concc_Work.WorkName].ToString().Trim(); //作业名称
objcc_WorkEN.WorkDesc = objRow[concc_Work.WorkDesc] == DBNull.Value ? null : objRow[concc_Work.WorkDesc].ToString().Trim(); //作业说明
objcc_WorkEN.CourseId = objRow[concc_Work.CourseId].ToString().Trim(); //课程Id
objcc_WorkEN.CourseChapterId = objRow[concc_Work.CourseChapterId] == DBNull.Value ? null : objRow[concc_Work.CourseChapterId].ToString().Trim(); //课程章节ID
objcc_WorkEN.Creator = objRow[concc_Work.Creator] == DBNull.Value ? null : objRow[concc_Work.Creator].ToString().Trim(); //创建者
objcc_WorkEN.CreateDate = objRow[concc_Work.CreateDate] == DBNull.Value ? null : objRow[concc_Work.CreateDate].ToString().Trim(); //建立日期
objcc_WorkEN.AnswerAttLimitSize = objRow[concc_Work.AnswerAttLimitSize] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[concc_Work.AnswerAttLimitSize].ToString().Trim()); //回答附件限制大小
objcc_WorkEN.LimitedResourceType = objRow[concc_Work.LimitedResourceType] == DBNull.Value ? null : objRow[concc_Work.LimitedResourceType].ToString().Trim(); //限制资源类型
objcc_WorkEN.UpdDate = objRow[concc_Work.UpdDate].ToString().Trim(); //修改日期
objcc_WorkEN.UpdUserId = objRow[concc_Work.UpdUserId] == DBNull.Value ? null : objRow[concc_Work.UpdUserId].ToString().Trim(); //修改用户Id
objcc_WorkEN.Memo = objRow[concc_Work.Memo] == DBNull.Value ? null : objRow[concc_Work.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objcc_WorkEN.IdWork, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objcc_WorkEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objcc_WorkCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clscc_WorkEN> GetSubObjLstCache(clscc_WorkEN objcc_WorkCond)
{
List<clscc_WorkEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clscc_WorkEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in concc_Work.AttributeName)
{
if (objcc_WorkCond.IsUpdated(strFldName) == false) continue;
if (objcc_WorkCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objcc_WorkCond[strFldName].ToString());
}
else
{
if (objcc_WorkCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objcc_WorkCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objcc_WorkCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objcc_WorkCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objcc_WorkCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objcc_WorkCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objcc_WorkCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objcc_WorkCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objcc_WorkCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objcc_WorkCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objcc_WorkCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objcc_WorkCond[strFldName]));
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
public static List<clscc_WorkEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clscc_WorkEN> arrObjLst = new List<clscc_WorkEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clscc_WorkEN objcc_WorkEN = new clscc_WorkEN();
try
{
objcc_WorkEN.IdWork = objRow[concc_Work.IdWork].ToString().Trim(); //作业流水号
objcc_WorkEN.WorkIndex = objRow[concc_Work.WorkIndex] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[concc_Work.WorkIndex].ToString().Trim()); //作业序号
objcc_WorkEN.WorkName = objRow[concc_Work.WorkName].ToString().Trim(); //作业名称
objcc_WorkEN.WorkDesc = objRow[concc_Work.WorkDesc] == DBNull.Value ? null : objRow[concc_Work.WorkDesc].ToString().Trim(); //作业说明
objcc_WorkEN.CourseId = objRow[concc_Work.CourseId].ToString().Trim(); //课程Id
objcc_WorkEN.CourseChapterId = objRow[concc_Work.CourseChapterId] == DBNull.Value ? null : objRow[concc_Work.CourseChapterId].ToString().Trim(); //课程章节ID
objcc_WorkEN.Creator = objRow[concc_Work.Creator] == DBNull.Value ? null : objRow[concc_Work.Creator].ToString().Trim(); //创建者
objcc_WorkEN.CreateDate = objRow[concc_Work.CreateDate] == DBNull.Value ? null : objRow[concc_Work.CreateDate].ToString().Trim(); //建立日期
objcc_WorkEN.AnswerAttLimitSize = objRow[concc_Work.AnswerAttLimitSize] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[concc_Work.AnswerAttLimitSize].ToString().Trim()); //回答附件限制大小
objcc_WorkEN.LimitedResourceType = objRow[concc_Work.LimitedResourceType] == DBNull.Value ? null : objRow[concc_Work.LimitedResourceType].ToString().Trim(); //限制资源类型
objcc_WorkEN.UpdDate = objRow[concc_Work.UpdDate].ToString().Trim(); //修改日期
objcc_WorkEN.UpdUserId = objRow[concc_Work.UpdUserId] == DBNull.Value ? null : objRow[concc_Work.UpdUserId].ToString().Trim(); //修改用户Id
objcc_WorkEN.Memo = objRow[concc_Work.Memo] == DBNull.Value ? null : objRow[concc_Work.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objcc_WorkEN.IdWork, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objcc_WorkEN);
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
public static List<clscc_WorkEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clscc_WorkEN> arrObjLst = new List<clscc_WorkEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clscc_WorkEN objcc_WorkEN = new clscc_WorkEN();
try
{
objcc_WorkEN.IdWork = objRow[concc_Work.IdWork].ToString().Trim(); //作业流水号
objcc_WorkEN.WorkIndex = objRow[concc_Work.WorkIndex] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[concc_Work.WorkIndex].ToString().Trim()); //作业序号
objcc_WorkEN.WorkName = objRow[concc_Work.WorkName].ToString().Trim(); //作业名称
objcc_WorkEN.WorkDesc = objRow[concc_Work.WorkDesc] == DBNull.Value ? null : objRow[concc_Work.WorkDesc].ToString().Trim(); //作业说明
objcc_WorkEN.CourseId = objRow[concc_Work.CourseId].ToString().Trim(); //课程Id
objcc_WorkEN.CourseChapterId = objRow[concc_Work.CourseChapterId] == DBNull.Value ? null : objRow[concc_Work.CourseChapterId].ToString().Trim(); //课程章节ID
objcc_WorkEN.Creator = objRow[concc_Work.Creator] == DBNull.Value ? null : objRow[concc_Work.Creator].ToString().Trim(); //创建者
objcc_WorkEN.CreateDate = objRow[concc_Work.CreateDate] == DBNull.Value ? null : objRow[concc_Work.CreateDate].ToString().Trim(); //建立日期
objcc_WorkEN.AnswerAttLimitSize = objRow[concc_Work.AnswerAttLimitSize] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[concc_Work.AnswerAttLimitSize].ToString().Trim()); //回答附件限制大小
objcc_WorkEN.LimitedResourceType = objRow[concc_Work.LimitedResourceType] == DBNull.Value ? null : objRow[concc_Work.LimitedResourceType].ToString().Trim(); //限制资源类型
objcc_WorkEN.UpdDate = objRow[concc_Work.UpdDate].ToString().Trim(); //修改日期
objcc_WorkEN.UpdUserId = objRow[concc_Work.UpdUserId] == DBNull.Value ? null : objRow[concc_Work.UpdUserId].ToString().Trim(); //修改用户Id
objcc_WorkEN.Memo = objRow[concc_Work.Memo] == DBNull.Value ? null : objRow[concc_Work.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objcc_WorkEN.IdWork, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objcc_WorkEN);
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
List<clscc_WorkEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clscc_WorkEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clscc_WorkEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clscc_WorkEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clscc_WorkEN> arrObjLst = new List<clscc_WorkEN>(); 
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
	clscc_WorkEN objcc_WorkEN = new clscc_WorkEN();
try
{
objcc_WorkEN.IdWork = objRow[concc_Work.IdWork].ToString().Trim(); //作业流水号
objcc_WorkEN.WorkIndex = objRow[concc_Work.WorkIndex] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[concc_Work.WorkIndex].ToString().Trim()); //作业序号
objcc_WorkEN.WorkName = objRow[concc_Work.WorkName].ToString().Trim(); //作业名称
objcc_WorkEN.WorkDesc = objRow[concc_Work.WorkDesc] == DBNull.Value ? null : objRow[concc_Work.WorkDesc].ToString().Trim(); //作业说明
objcc_WorkEN.CourseId = objRow[concc_Work.CourseId].ToString().Trim(); //课程Id
objcc_WorkEN.CourseChapterId = objRow[concc_Work.CourseChapterId] == DBNull.Value ? null : objRow[concc_Work.CourseChapterId].ToString().Trim(); //课程章节ID
objcc_WorkEN.Creator = objRow[concc_Work.Creator] == DBNull.Value ? null : objRow[concc_Work.Creator].ToString().Trim(); //创建者
objcc_WorkEN.CreateDate = objRow[concc_Work.CreateDate] == DBNull.Value ? null : objRow[concc_Work.CreateDate].ToString().Trim(); //建立日期
objcc_WorkEN.AnswerAttLimitSize = objRow[concc_Work.AnswerAttLimitSize] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[concc_Work.AnswerAttLimitSize].ToString().Trim()); //回答附件限制大小
objcc_WorkEN.LimitedResourceType = objRow[concc_Work.LimitedResourceType] == DBNull.Value ? null : objRow[concc_Work.LimitedResourceType].ToString().Trim(); //限制资源类型
objcc_WorkEN.UpdDate = objRow[concc_Work.UpdDate].ToString().Trim(); //修改日期
objcc_WorkEN.UpdUserId = objRow[concc_Work.UpdUserId] == DBNull.Value ? null : objRow[concc_Work.UpdUserId].ToString().Trim(); //修改用户Id
objcc_WorkEN.Memo = objRow[concc_Work.Memo] == DBNull.Value ? null : objRow[concc_Work.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objcc_WorkEN.IdWork, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objcc_WorkEN);
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
public static List<clscc_WorkEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clscc_WorkEN> arrObjLst = new List<clscc_WorkEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clscc_WorkEN objcc_WorkEN = new clscc_WorkEN();
try
{
objcc_WorkEN.IdWork = objRow[concc_Work.IdWork].ToString().Trim(); //作业流水号
objcc_WorkEN.WorkIndex = objRow[concc_Work.WorkIndex] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[concc_Work.WorkIndex].ToString().Trim()); //作业序号
objcc_WorkEN.WorkName = objRow[concc_Work.WorkName].ToString().Trim(); //作业名称
objcc_WorkEN.WorkDesc = objRow[concc_Work.WorkDesc] == DBNull.Value ? null : objRow[concc_Work.WorkDesc].ToString().Trim(); //作业说明
objcc_WorkEN.CourseId = objRow[concc_Work.CourseId].ToString().Trim(); //课程Id
objcc_WorkEN.CourseChapterId = objRow[concc_Work.CourseChapterId] == DBNull.Value ? null : objRow[concc_Work.CourseChapterId].ToString().Trim(); //课程章节ID
objcc_WorkEN.Creator = objRow[concc_Work.Creator] == DBNull.Value ? null : objRow[concc_Work.Creator].ToString().Trim(); //创建者
objcc_WorkEN.CreateDate = objRow[concc_Work.CreateDate] == DBNull.Value ? null : objRow[concc_Work.CreateDate].ToString().Trim(); //建立日期
objcc_WorkEN.AnswerAttLimitSize = objRow[concc_Work.AnswerAttLimitSize] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[concc_Work.AnswerAttLimitSize].ToString().Trim()); //回答附件限制大小
objcc_WorkEN.LimitedResourceType = objRow[concc_Work.LimitedResourceType] == DBNull.Value ? null : objRow[concc_Work.LimitedResourceType].ToString().Trim(); //限制资源类型
objcc_WorkEN.UpdDate = objRow[concc_Work.UpdDate].ToString().Trim(); //修改日期
objcc_WorkEN.UpdUserId = objRow[concc_Work.UpdUserId] == DBNull.Value ? null : objRow[concc_Work.UpdUserId].ToString().Trim(); //修改用户Id
objcc_WorkEN.Memo = objRow[concc_Work.Memo] == DBNull.Value ? null : objRow[concc_Work.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objcc_WorkEN.IdWork, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objcc_WorkEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clscc_WorkEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clscc_WorkEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clscc_WorkEN> arrObjLst = new List<clscc_WorkEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clscc_WorkEN objcc_WorkEN = new clscc_WorkEN();
try
{
objcc_WorkEN.IdWork = objRow[concc_Work.IdWork].ToString().Trim(); //作业流水号
objcc_WorkEN.WorkIndex = objRow[concc_Work.WorkIndex] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[concc_Work.WorkIndex].ToString().Trim()); //作业序号
objcc_WorkEN.WorkName = objRow[concc_Work.WorkName].ToString().Trim(); //作业名称
objcc_WorkEN.WorkDesc = objRow[concc_Work.WorkDesc] == DBNull.Value ? null : objRow[concc_Work.WorkDesc].ToString().Trim(); //作业说明
objcc_WorkEN.CourseId = objRow[concc_Work.CourseId].ToString().Trim(); //课程Id
objcc_WorkEN.CourseChapterId = objRow[concc_Work.CourseChapterId] == DBNull.Value ? null : objRow[concc_Work.CourseChapterId].ToString().Trim(); //课程章节ID
objcc_WorkEN.Creator = objRow[concc_Work.Creator] == DBNull.Value ? null : objRow[concc_Work.Creator].ToString().Trim(); //创建者
objcc_WorkEN.CreateDate = objRow[concc_Work.CreateDate] == DBNull.Value ? null : objRow[concc_Work.CreateDate].ToString().Trim(); //建立日期
objcc_WorkEN.AnswerAttLimitSize = objRow[concc_Work.AnswerAttLimitSize] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[concc_Work.AnswerAttLimitSize].ToString().Trim()); //回答附件限制大小
objcc_WorkEN.LimitedResourceType = objRow[concc_Work.LimitedResourceType] == DBNull.Value ? null : objRow[concc_Work.LimitedResourceType].ToString().Trim(); //限制资源类型
objcc_WorkEN.UpdDate = objRow[concc_Work.UpdDate].ToString().Trim(); //修改日期
objcc_WorkEN.UpdUserId = objRow[concc_Work.UpdUserId] == DBNull.Value ? null : objRow[concc_Work.UpdUserId].ToString().Trim(); //修改用户Id
objcc_WorkEN.Memo = objRow[concc_Work.Memo] == DBNull.Value ? null : objRow[concc_Work.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objcc_WorkEN.IdWork, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objcc_WorkEN);
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
public static List<clscc_WorkEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clscc_WorkEN> arrObjLst = new List<clscc_WorkEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clscc_WorkEN objcc_WorkEN = new clscc_WorkEN();
try
{
objcc_WorkEN.IdWork = objRow[concc_Work.IdWork].ToString().Trim(); //作业流水号
objcc_WorkEN.WorkIndex = objRow[concc_Work.WorkIndex] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[concc_Work.WorkIndex].ToString().Trim()); //作业序号
objcc_WorkEN.WorkName = objRow[concc_Work.WorkName].ToString().Trim(); //作业名称
objcc_WorkEN.WorkDesc = objRow[concc_Work.WorkDesc] == DBNull.Value ? null : objRow[concc_Work.WorkDesc].ToString().Trim(); //作业说明
objcc_WorkEN.CourseId = objRow[concc_Work.CourseId].ToString().Trim(); //课程Id
objcc_WorkEN.CourseChapterId = objRow[concc_Work.CourseChapterId] == DBNull.Value ? null : objRow[concc_Work.CourseChapterId].ToString().Trim(); //课程章节ID
objcc_WorkEN.Creator = objRow[concc_Work.Creator] == DBNull.Value ? null : objRow[concc_Work.Creator].ToString().Trim(); //创建者
objcc_WorkEN.CreateDate = objRow[concc_Work.CreateDate] == DBNull.Value ? null : objRow[concc_Work.CreateDate].ToString().Trim(); //建立日期
objcc_WorkEN.AnswerAttLimitSize = objRow[concc_Work.AnswerAttLimitSize] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[concc_Work.AnswerAttLimitSize].ToString().Trim()); //回答附件限制大小
objcc_WorkEN.LimitedResourceType = objRow[concc_Work.LimitedResourceType] == DBNull.Value ? null : objRow[concc_Work.LimitedResourceType].ToString().Trim(); //限制资源类型
objcc_WorkEN.UpdDate = objRow[concc_Work.UpdDate].ToString().Trim(); //修改日期
objcc_WorkEN.UpdUserId = objRow[concc_Work.UpdUserId] == DBNull.Value ? null : objRow[concc_Work.UpdUserId].ToString().Trim(); //修改用户Id
objcc_WorkEN.Memo = objRow[concc_Work.Memo] == DBNull.Value ? null : objRow[concc_Work.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objcc_WorkEN.IdWork, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objcc_WorkEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clscc_WorkEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clscc_WorkEN> arrObjLst = new List<clscc_WorkEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clscc_WorkEN objcc_WorkEN = new clscc_WorkEN();
try
{
objcc_WorkEN.IdWork = objRow[concc_Work.IdWork].ToString().Trim(); //作业流水号
objcc_WorkEN.WorkIndex = objRow[concc_Work.WorkIndex] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[concc_Work.WorkIndex].ToString().Trim()); //作业序号
objcc_WorkEN.WorkName = objRow[concc_Work.WorkName].ToString().Trim(); //作业名称
objcc_WorkEN.WorkDesc = objRow[concc_Work.WorkDesc] == DBNull.Value ? null : objRow[concc_Work.WorkDesc].ToString().Trim(); //作业说明
objcc_WorkEN.CourseId = objRow[concc_Work.CourseId].ToString().Trim(); //课程Id
objcc_WorkEN.CourseChapterId = objRow[concc_Work.CourseChapterId] == DBNull.Value ? null : objRow[concc_Work.CourseChapterId].ToString().Trim(); //课程章节ID
objcc_WorkEN.Creator = objRow[concc_Work.Creator] == DBNull.Value ? null : objRow[concc_Work.Creator].ToString().Trim(); //创建者
objcc_WorkEN.CreateDate = objRow[concc_Work.CreateDate] == DBNull.Value ? null : objRow[concc_Work.CreateDate].ToString().Trim(); //建立日期
objcc_WorkEN.AnswerAttLimitSize = objRow[concc_Work.AnswerAttLimitSize] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[concc_Work.AnswerAttLimitSize].ToString().Trim()); //回答附件限制大小
objcc_WorkEN.LimitedResourceType = objRow[concc_Work.LimitedResourceType] == DBNull.Value ? null : objRow[concc_Work.LimitedResourceType].ToString().Trim(); //限制资源类型
objcc_WorkEN.UpdDate = objRow[concc_Work.UpdDate].ToString().Trim(); //修改日期
objcc_WorkEN.UpdUserId = objRow[concc_Work.UpdUserId] == DBNull.Value ? null : objRow[concc_Work.UpdUserId].ToString().Trim(); //修改用户Id
objcc_WorkEN.Memo = objRow[concc_Work.Memo] == DBNull.Value ? null : objRow[concc_Work.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objcc_WorkEN.IdWork, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objcc_WorkEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objcc_WorkEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool Getcc_Work(ref clscc_WorkEN objcc_WorkEN)
{
bool bolResult = cc_WorkDA.Getcc_Work(ref objcc_WorkEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "strIdWork">表关键字</param>
 /// <returns>表对象</returns>
public static clscc_WorkEN GetObjByIdWork(string strIdWork)
{
if (strIdWork.IndexOf(' ') >=0)
{
var strMsg = string.Format("(errid:Busi000079)在表中,关键字[strIdWork]中不能有空格!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
if (string.IsNullOrEmpty(strIdWork) == true)
{
var strMsg = string.Format("(errid:Busi000020)在表中,关键字[strIdWork]不能为空!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
clscc_WorkEN objcc_WorkEN = cc_WorkDA.GetObjByIdWork(strIdWork);
return objcc_WorkEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clscc_WorkEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clscc_WorkEN objcc_WorkEN = cc_WorkDA.GetFirstObj(strWhereCond);
 return objcc_WorkEN;
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
public static clscc_WorkEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clscc_WorkEN objcc_WorkEN = cc_WorkDA.GetObjByDataRow(objRow);
 return objcc_WorkEN;
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
public static clscc_WorkEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clscc_WorkEN objcc_WorkEN = cc_WorkDA.GetObjByDataRow(objRow);
 return objcc_WorkEN;
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
 /// <param name = "strIdWork">所给的关键字</param>
 /// <param name = "lstcc_WorkObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clscc_WorkEN GetObjByIdWorkFromList(string strIdWork, List<clscc_WorkEN> lstcc_WorkObjLst)
{
foreach (clscc_WorkEN objcc_WorkEN in lstcc_WorkObjLst)
{
if (objcc_WorkEN.IdWork == strIdWork)
{
return objcc_WorkEN;
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
 string strMaxIdWork;
 try
 {
 strMaxIdWork = clscc_WorkDA.GetMaxStrId();
 return strMaxIdWork;
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
 string strIdWork;
 try
 {
 strIdWork = new clscc_WorkDA().GetFirstID(strWhereCond);
 return strIdWork;
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
 arrList = cc_WorkDA.GetID(strWhereCond);
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
bool bolIsExist = cc_WorkDA.IsExistCondRec(strWhereCond);
return bolIsExist;
}

 /// <summary>
 /// 判断当前表中是否存在给定关键字值的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExist)
 /// </summary>
 /// <param name = "strIdWork">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public static bool IsExist(string strIdWork)
{
if (string.IsNullOrEmpty(strIdWork) == true)
{
var strMsg = string.Format("(errid:Busi000027)在表中,关键字[strIdWork]不能为空!!(from {0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
//检测记录是否存在
bool bolIsExist = cc_WorkDA.IsExist(strIdWork);
return bolIsExist;
}

/// <summary>
/// 设置修改时间
/// </summary>
/// <param name = "strIdWork">作业流水号</param>
/// <param name = "strOpUser">修改用户</param>
/// <returns>是否成功？</returns>
public static bool SetUpdDate(string strIdWork, string strOpUser)
{
clscc_WorkEN objcc_WorkEN = clscc_WorkBL.GetObjByIdWork(strIdWork);
objcc_WorkEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
objcc_WorkEN.UpdUserId = strOpUser;
return clscc_WorkBL.UpdateBySql2(objcc_WorkEN);
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
 bolIsExist = clscc_WorkDA.IsExistTable();
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
 bolIsExist = cc_WorkDA.IsExistTable(strTabName);
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
 /// <param name = "objcc_WorkEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecordBySql2(clscc_WorkEN objcc_WorkEN, bool bolIsNeedCheckUniqueness=true)
{
if (bolIsNeedCheckUniqueness == true && objcc_WorkEN.CheckUniqueness() == false)
{
var strMsg = string.Format("记录已经存在!作业名称 = [{0}],课程Id = [{1}]的数据已经存在!(in clscc_WorkBL.AddNewRecordBySql2)", objcc_WorkEN.WorkName,objcc_WorkEN.CourseId);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objcc_WorkEN.IdWork) == true || clscc_WorkBL.IsExist(objcc_WorkEN.IdWork) == true)
 {
     objcc_WorkEN.IdWork = clscc_WorkBL.GetMaxStrId_S();
 }
bool bolResult = cc_WorkDA.AddNewRecordBySQL2(objcc_WorkEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clscc_WorkBL.ReFreshCache();

if (clscc_WorkBL.relatedActions != null)
{
clscc_WorkBL.relatedActions.UpdRelaTabDate(objcc_WorkEN.IdWork, objcc_WorkEN.UpdUserId);
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
 /// <param name = "objcc_WorkEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordBySql2WithReturnKey(clscc_WorkEN objcc_WorkEN, bool bolIsNeedCheckUniqueness=true)
{
if (bolIsNeedCheckUniqueness == true && objcc_WorkEN.CheckUniqueness() == false)
{
var strMsg = string.Format("记录已经存在!作业名称 = [{0}],课程Id = [{1}]的数据已经存在!(in clscc_WorkBL.AddNewRecordBySql2WithReturnKey)", objcc_WorkEN.WorkName,objcc_WorkEN.CourseId);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objcc_WorkEN.IdWork) == true || clscc_WorkBL.IsExist(objcc_WorkEN.IdWork) == true)
 {
     objcc_WorkEN.IdWork = clscc_WorkBL.GetMaxStrId_S();
 }
string strKey = cc_WorkDA.AddNewRecordBySQL2WithReturnKey(objcc_WorkEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clscc_WorkBL.ReFreshCache();

if (clscc_WorkBL.relatedActions != null)
{
clscc_WorkBL.relatedActions.UpdRelaTabDate(objcc_WorkEN.IdWork, objcc_WorkEN.UpdUserId);
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
 /// <param name = "objcc_WorkEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(clscc_WorkEN objcc_WorkEN)
{
try
{
bool bolResult = cc_WorkDA.Update(objcc_WorkEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clscc_WorkBL.ReFreshCache();

if (clscc_WorkBL.relatedActions != null)
{
clscc_WorkBL.relatedActions.UpdRelaTabDate(objcc_WorkEN.IdWork, objcc_WorkEN.UpdUserId);
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
 /// <param name = "objcc_WorkEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateBySql2(clscc_WorkEN objcc_WorkEN)
{
 if (string.IsNullOrEmpty(objcc_WorkEN.IdWork) == true)
 {
var strMsg = string.Format("(errid:Busi000065)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = cc_WorkDA.UpdateBySql2(objcc_WorkEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clscc_WorkBL.ReFreshCache();

if (clscc_WorkBL.relatedActions != null)
{
clscc_WorkBL.relatedActions.UpdRelaTabDate(objcc_WorkEN.IdWork, objcc_WorkEN.UpdUserId);
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
 /// <param name = "strIdWork">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int DelRecord(string strIdWork)
{
try
{
 clscc_WorkEN objcc_WorkEN = clscc_WorkBL.GetObjByIdWork(strIdWork);

if (clscc_WorkBL.relatedActions != null)
{
clscc_WorkBL.relatedActions.UpdRelaTabDate(objcc_WorkEN.IdWork, objcc_WorkEN.UpdUserId);
}
if (objcc_WorkEN != null)
{
int intRecNum = cc_WorkDA.DelRecord(strIdWork);
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
/// <param name="strIdWork">表关键字</param>
/// <returns></returns>
public static bool DelRecordEx(string strIdWork )
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clscc_WorkDA.GetSpecSQLObj();
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
//删除与表:[cc_Work]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//concc_Work.IdWork,
//strIdWork);
//        clscc_WorkBL.Delcc_WorksByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clscc_WorkBL.DelRecord(strIdWork, objConnection, objSqlTransaction);
objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clscc_WorkBLEx", "DelRecordEx", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("扩展删除记录出错:{0}!keyId = {1}.({2})",
objException.Message,
strIdWork, clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "strIdWork">给定的关键字值</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回删除是否成功?</returns>
public static bool DelRecord(string strIdWork, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
if (clscc_WorkBL.relatedActions != null)
{
clscc_WorkBL.relatedActions.UpdRelaTabDate(strIdWork, "UpdRelaTabDate");
}
bool bolResult = cc_WorkDA.DelRecord(strIdWork,objSqlConnection,objSqlTransaction);
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
 /// <param name = "arrIdWorkLst">给定的关键字值列表</param>
 /// <returns>返回删除的记录数</returns>
public static int Delcc_Works(List<string> arrIdWorkLst)
{
if (arrIdWorkLst.Count == 0) return 0;
try
{
if (clscc_WorkBL.relatedActions != null)
{
foreach (var strIdWork in arrIdWorkLst)
{
clscc_WorkBL.relatedActions.UpdRelaTabDate(strIdWork, "UpdRelaTabDate");
}
}
int intDelRecNum = cc_WorkDA.Delcc_Work(arrIdWorkLst);
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
public static int Delcc_WorksByCond(string strWhereCond)
{
try
{
if (clscc_WorkBL.relatedActions != null)
{
List<string> arrIdWork = GetPrimaryKeyID_S(strWhereCond);
foreach (var strIdWork in arrIdWork)
{
clscc_WorkBL.relatedActions.UpdRelaTabDate(strIdWork, "UpdRelaTabDate");
}
}
int intRecNum = cc_WorkDA.Delcc_Work(strWhereCond);
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
/// 这里仅仅是演示函数,使用时请复制到扩展类:[cc_Work]中改名为:[DelRecord4MultiTabEx]使用
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DelRecord4MultiTab)
/// </summary>
/// <param name="strIdWork">表关键字</param>
/// <returns></returns>
public static bool DelRecord4MultiTab(string strIdWork)
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clscc_WorkDA.GetSpecSQLObj();
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
//删除与表:[cc_Work]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conStudent.id_College,
//strid_College);
//        clsStudentBL.DelStudentsByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clscc_WorkBL.DelRecord(strIdWork, objConnection, objSqlTransaction);
                objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clscc_WorkBL", "DelRecord4MultiTab", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("删除多表记录出错:{0}!keyId = {1}.({2})",
objException.Message,
strIdWork, clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "objcc_WorkENS">源对象</param>
 /// <param name = "objcc_WorkENT">目标对象</param>
 public static void CopyTo(clscc_WorkEN objcc_WorkENS, clscc_WorkEN objcc_WorkENT)
{
try
{
objcc_WorkENT.IdWork = objcc_WorkENS.IdWork; //作业流水号
objcc_WorkENT.WorkIndex = objcc_WorkENS.WorkIndex; //作业序号
objcc_WorkENT.WorkName = objcc_WorkENS.WorkName; //作业名称
objcc_WorkENT.WorkDesc = objcc_WorkENS.WorkDesc; //作业说明
objcc_WorkENT.CourseId = objcc_WorkENS.CourseId; //课程Id
objcc_WorkENT.CourseChapterId = objcc_WorkENS.CourseChapterId; //课程章节ID
objcc_WorkENT.Creator = objcc_WorkENS.Creator; //创建者
objcc_WorkENT.CreateDate = objcc_WorkENS.CreateDate; //建立日期
objcc_WorkENT.AnswerAttLimitSize = objcc_WorkENS.AnswerAttLimitSize; //回答附件限制大小
objcc_WorkENT.LimitedResourceType = objcc_WorkENS.LimitedResourceType; //限制资源类型
objcc_WorkENT.UpdDate = objcc_WorkENS.UpdDate; //修改日期
objcc_WorkENT.UpdUserId = objcc_WorkENS.UpdUserId; //修改用户Id
objcc_WorkENT.Memo = objcc_WorkENS.Memo; //备注
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
 /// <param name = "objcc_WorkEN">源简化对象</param>
 public static void SetUpdFlag(clscc_WorkEN objcc_WorkEN)
{
try
{
objcc_WorkEN.ClearUpdateState();
   string strsfUpdFldSetStr = objcc_WorkEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(concc_Work.IdWork, new clsStrCompareIgnoreCase())  ==  true)
{
objcc_WorkEN.IdWork = objcc_WorkEN.IdWork; //作业流水号
}
if (arrFldSet.Contains(concc_Work.WorkIndex, new clsStrCompareIgnoreCase())  ==  true)
{
objcc_WorkEN.WorkIndex = objcc_WorkEN.WorkIndex; //作业序号
}
if (arrFldSet.Contains(concc_Work.WorkName, new clsStrCompareIgnoreCase())  ==  true)
{
objcc_WorkEN.WorkName = objcc_WorkEN.WorkName; //作业名称
}
if (arrFldSet.Contains(concc_Work.WorkDesc, new clsStrCompareIgnoreCase())  ==  true)
{
objcc_WorkEN.WorkDesc = objcc_WorkEN.WorkDesc == "[null]" ? null :  objcc_WorkEN.WorkDesc; //作业说明
}
if (arrFldSet.Contains(concc_Work.CourseId, new clsStrCompareIgnoreCase())  ==  true)
{
objcc_WorkEN.CourseId = objcc_WorkEN.CourseId; //课程Id
}
if (arrFldSet.Contains(concc_Work.CourseChapterId, new clsStrCompareIgnoreCase())  ==  true)
{
objcc_WorkEN.CourseChapterId = objcc_WorkEN.CourseChapterId == "[null]" ? null :  objcc_WorkEN.CourseChapterId; //课程章节ID
}
if (arrFldSet.Contains(concc_Work.Creator, new clsStrCompareIgnoreCase())  ==  true)
{
objcc_WorkEN.Creator = objcc_WorkEN.Creator == "[null]" ? null :  objcc_WorkEN.Creator; //创建者
}
if (arrFldSet.Contains(concc_Work.CreateDate, new clsStrCompareIgnoreCase())  ==  true)
{
objcc_WorkEN.CreateDate = objcc_WorkEN.CreateDate == "[null]" ? null :  objcc_WorkEN.CreateDate; //建立日期
}
if (arrFldSet.Contains(concc_Work.AnswerAttLimitSize, new clsStrCompareIgnoreCase())  ==  true)
{
objcc_WorkEN.AnswerAttLimitSize = objcc_WorkEN.AnswerAttLimitSize; //回答附件限制大小
}
if (arrFldSet.Contains(concc_Work.LimitedResourceType, new clsStrCompareIgnoreCase())  ==  true)
{
objcc_WorkEN.LimitedResourceType = objcc_WorkEN.LimitedResourceType == "[null]" ? null :  objcc_WorkEN.LimitedResourceType; //限制资源类型
}
if (arrFldSet.Contains(concc_Work.UpdDate, new clsStrCompareIgnoreCase())  ==  true)
{
objcc_WorkEN.UpdDate = objcc_WorkEN.UpdDate; //修改日期
}
if (arrFldSet.Contains(concc_Work.UpdUserId, new clsStrCompareIgnoreCase())  ==  true)
{
objcc_WorkEN.UpdUserId = objcc_WorkEN.UpdUserId == "[null]" ? null :  objcc_WorkEN.UpdUserId; //修改用户Id
}
if (arrFldSet.Contains(concc_Work.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objcc_WorkEN.Memo = objcc_WorkEN.Memo == "[null]" ? null :  objcc_WorkEN.Memo; //备注
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
 /// <param name = "objcc_WorkEN">源简化对象</param>
 public static void AccessFldValueNull(clscc_WorkEN objcc_WorkEN)
{
try
{
if (objcc_WorkEN.WorkDesc == "[null]") objcc_WorkEN.WorkDesc = null; //作业说明
if (objcc_WorkEN.CourseChapterId == "[null]") objcc_WorkEN.CourseChapterId = null; //课程章节ID
if (objcc_WorkEN.Creator == "[null]") objcc_WorkEN.Creator = null; //创建者
if (objcc_WorkEN.CreateDate == "[null]") objcc_WorkEN.CreateDate = null; //建立日期
if (objcc_WorkEN.LimitedResourceType == "[null]") objcc_WorkEN.LimitedResourceType = null; //限制资源类型
if (objcc_WorkEN.UpdUserId == "[null]") objcc_WorkEN.UpdUserId = null; //修改用户Id
if (objcc_WorkEN.Memo == "[null]") objcc_WorkEN.Memo = null; //备注
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
public static void CheckPropertyNew(clscc_WorkEN objcc_WorkEN)
{
 cc_WorkDA.CheckPropertyNew(objcc_WorkEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(clscc_WorkEN objcc_WorkEN)
{
 cc_WorkDA.CheckProperty4Condition(objcc_WorkEN);
 }


 #endregion 检查对象属性


 #region 绑定下拉框

 /// <summary>
 /// 绑定基于Win的下拉框
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_TabFeature_ComboBoxBindFunction)
 /// </summary>
 /// <param name = "objComboBox">需要绑定当前表的下拉框</param>

public static void BindCbo_IdWork(System.Windows.Forms.ComboBox objComboBox )
{
//为数据源为表的下拉框设置内容
string strCondition = string.Format("1 =1 Order By {0}", concc_Work.IdWork); 
List<clscc_WorkEN> arrObjLst = clscc_WorkBL.GetObjLst(strCondition);
//初始化一个对象列表
//插入第0项。在第0项中插入“请选择...”,为了方便用户,与WEB方式类似。
clscc_WorkEN objcc_WorkEN = new clscc_WorkEN()
{
IdWork = "0",
WorkName = "选[作业]..."
};
arrObjLst.Insert(0, objcc_WorkEN);
//设置下拉框的数据源、以及设置值项、显示项
objComboBox.ValueMember = concc_Work.IdWork;
objComboBox.DisplayMember = concc_Work.WorkName;
objComboBox.DataSource = arrObjLst;
objComboBox.SelectedIndex = 0;
}

 /// <summary>
 /// 绑定基于Web的下拉框
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_TabFeature_DdlBindFunction)
 /// </summary>
 /// <param name = "objDDL">需要绑定当前表的下拉框</param>

public static void BindDdl_IdWork(System.Web.UI.WebControls.DropDownList objDDL )
{
//为数据源于表的下拉框设置内容
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[作业]...","0");
string strCondition = string.Format("1 =1 Order By {0}", concc_Work.IdWork); 
IEnumerable<clscc_WorkEN> arrObjLst = clscc_WorkBL.GetObjLst(strCondition);
objDDL.DataValueField = concc_Work.IdWork;
objDDL.DataTextField = concc_Work.WorkName;
objDDL.DataSource = arrObjLst;
objDDL.DataBind();
objDDL.Items.Insert(0, li);
objDDL.SelectedIndex = 0;
}

 /// <summary>
 /// 绑定基于Web的下拉框-使用Cache
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DdlBindFunctionCache)
 /// </summary>
 /// <param name = "objDDL">需要绑定当前表的下拉框</param>
public static void BindDdl_IdWorkCache(System.Web.UI.WebControls.DropDownList objDDL)
{
//为数据源于表的下拉框设置内容
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[作业]...","0");
List<clscc_WorkEN> arrcc_WorkObjLst = GetAllcc_WorkObjLstCache(); 
objDDL.DataValueField = concc_Work.IdWork;
objDDL.DataTextField = concc_Work.WorkName;
objDDL.DataSource = arrcc_WorkObjLst;
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
if (clscc_WorkBL.objCommFun4BL == null)
{
strMsg = string.Format("类clscc_WorkBL没有刷新缓存机制(clscc_WorkBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by IdWork");
//if (arrcc_WorkObjLstCache == null)
//{
//arrcc_WorkObjLstCache = cc_WorkDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "strIdWork">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clscc_WorkEN GetObjByIdWorkCache(string strIdWork)
{
//获取缓存中的对象列表
string strKey = string.Format("{0}", clscc_WorkEN._CurrTabName);
List<clscc_WorkEN> arrcc_WorkObjLstCache = GetObjLstCache();
IEnumerable <clscc_WorkEN> arrcc_WorkObjLst_Sel =
arrcc_WorkObjLstCache
.Where(x=> x.IdWork == strIdWork 
);
if (arrcc_WorkObjLst_Sel.Count() == 0)
{
   clscc_WorkEN obj = clscc_WorkBL.GetObjByIdWork(strIdWork);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
 }
return null;
}
return arrcc_WorkObjLst_Sel.First();
}

 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecNameByKeyCache)
 /// </summary>
 /// <param name = "strIdWork">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetWorkNameByIdWorkCache(string strIdWork)
{
if (string.IsNullOrEmpty(strIdWork) == true) return "";
//获取缓存中的对象列表
clscc_WorkEN objcc_Work = GetObjByIdWorkCache(strIdWork);
if (objcc_Work == null) return "";
return objcc_Work.WorkName;
}
 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecNameByKeyCache)
 /// </summary>
 /// <param name = "strIdWork">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetNameByIdWorkCache(string strIdWork)
{
if (string.IsNullOrEmpty(strIdWork) == true) return "";
//获取缓存中的对象列表
clscc_WorkEN objcc_Work = GetObjByIdWorkCache(strIdWork);
if (objcc_Work == null) return "";
return objcc_Work.WorkName;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clscc_WorkEN> GetAllcc_WorkObjLstCache()
{
//获取缓存中的对象列表
List<clscc_WorkEN> arrcc_WorkObjLstCache = GetObjLstCache(); 
return arrcc_WorkObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clscc_WorkEN> GetObjLstCache()
{
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}", clscc_WorkEN._CurrTabName);
List<clscc_WorkEN> arrcc_WorkObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrcc_WorkObjLstCache;
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
string strKey = string.Format("{0}", clscc_WorkEN._CurrTabName);
CacheHelper.Remove(strKey);
clscc_WorkEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
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
if (clscc_WorkEN._RefreshTimeLst.Count == 0) return "";
return clscc_WorkEN._RefreshTimeLst[clscc_WorkEN._RefreshTimeLst.Count - 1];
}

 /// <summary>
 /// 刷新缓存.把当前表的缓存以及该表相关视图的缓存清空.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ReFreshCache)
 /// </summary>
public static void ReFreshCache()
{
if (clscc_WorkBL.objCommFun4BL != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}", clscc_WorkEN._CurrTabName);
CacheHelper.Remove(strKey);
clscc_WorkEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
clscc_WorkBL.objCommFun4BL.ReFreshCache();
}
}


 #endregion 缓存操作


 #region 检查唯一性

 /// <summary>
 /// 获取检查唯一性条件串(Uniqueness)--cc_Work(作业)
 /// 唯一性条件:WorkName_CourseId
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetUniquenessConditionString)
 /// </summary>
 /// <param name = "objcc_WorkEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(clscc_WorkEN objcc_WorkEN)
{
//检测记录是否存在
string strResult = cc_WorkDA.GetUniCondStr(objcc_WorkEN);
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
public static string Func(string strInFldName, string strOutFldName, string strIdWork)
{
if (strInFldName != concc_Work.IdWork)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (concc_Work.AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", concc_Work.AttributeName));
throw new Exception(strMsg);
}
var objcc_Work = clscc_WorkBL.GetObjByIdWorkCache(strIdWork);
if (objcc_Work == null) return "";
return objcc_Work[strOutFldName].ToString();
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
int intRecCount = clscc_WorkDA.GetRecCount(strTabName);
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
int intRecCount = clscc_WorkDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clscc_WorkDA.GetRecCount();
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
int intRecCount = clscc_WorkDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objcc_WorkCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clscc_WorkEN objcc_WorkCond)
{
List<clscc_WorkEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clscc_WorkEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in concc_Work.AttributeName)
{
if (objcc_WorkCond.IsUpdated(strFldName) == false) continue;
if (objcc_WorkCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objcc_WorkCond[strFldName].ToString());
}
else
{
if (objcc_WorkCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objcc_WorkCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objcc_WorkCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objcc_WorkCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objcc_WorkCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objcc_WorkCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objcc_WorkCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objcc_WorkCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objcc_WorkCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objcc_WorkCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objcc_WorkCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objcc_WorkCond[strFldName]));
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
 List<string> arrList = clscc_WorkDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = cc_WorkDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = cc_WorkDA.GetFldValueNoDistinct(strFldName, strWhereCond);
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
int intRecCount = cc_WorkDA.SetFldValue(strFldName, strValue, strWhereCond);
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
int intRecCount = clscc_WorkDA.SetFldValue(clscc_WorkEN._CurrTabName, strFldName, fltValue, strWhereCond);
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
int intRecCount = cc_WorkDA.SetFldValue( strFldName, intValue, strWhereCond);
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
int intRecCount = clscc_WorkDA.SetFldValue(strTabName, strFldName, strValue, strWhereCond);
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
int intRecCount = clscc_WorkDA.SetFldValue(strTabName, strFldName, intValue, strWhereCond);
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
int intRecCount = clscc_WorkDA.SetFldValue(strTabName, strFldName, fltValue, strWhereCond);
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
  strCreateTabCode.Append("CREATE table [dbo].[cc_Work] "); 
 strCreateTabCode.Append(" ( "); 
 // /**作业流水号*/ 
 strCreateTabCode.Append(" IdWork char(8) primary key, "); 
 // /**作业序号*/ 
 strCreateTabCode.Append(" WorkIndex int Null, "); 
 // /**作业名称*/ 
 strCreateTabCode.Append(" WorkName varchar(5000) not Null, "); 
 // /**作业说明*/ 
 strCreateTabCode.Append(" WorkDesc text Null, "); 
 // /**课程Id*/ 
 strCreateTabCode.Append(" CourseId char(8) not Null, "); 
 // /**课程章节ID*/ 
 strCreateTabCode.Append(" CourseChapterId char(8) Null, "); 
 // /**创建者*/ 
 strCreateTabCode.Append(" Creator varchar(18) Null, "); 
 // /**建立日期*/ 
 strCreateTabCode.Append(" CreateDate varchar(20) Null, "); 
 // /**回答附件限制大小*/ 
 strCreateTabCode.Append(" AnswerAttLimitSize bigint Null, "); 
 // /**限制资源类型*/ 
 strCreateTabCode.Append(" LimitedResourceType varchar(100) Null, "); 
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
 /// 作业(cc_Work)
 /// 数据源类型:表
 /// (AutoGCLib.CommFun4BL4CSharp:GeneCode_This)
 /// </summary>
public class  clsCommFun4BL4cc_Work : clsCommFun4BL
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
clscc_WorkBL.ReFreshThisCache();
}
}

}