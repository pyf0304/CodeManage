
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clscc_ExamPaperStuBatchRelaBL
 表名:cc_ExamPaperStuBatchRela(01120239)
 * 版本:2024.11.13.1(服务器:WIN-SRV103-116)
 日期:2024/11/13 06:09:24
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
public static class  clscc_ExamPaperStuBatchRelaBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "strIdPaperStuBatch">表关键字</param>
 /// <returns>表对象</returns>
public static clscc_ExamPaperStuBatchRelaEN GetObj(this K_IdPaperStuBatch_cc_ExamPaperStuBatchRela myKey)
{
clscc_ExamPaperStuBatchRelaEN objcc_ExamPaperStuBatchRelaEN = clscc_ExamPaperStuBatchRelaBL.cc_ExamPaperStuBatchRelaDA.GetObjByIdPaperStuBatch(myKey.Value);
return objcc_ExamPaperStuBatchRelaEN;
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_AddNewRecord)
 /// </summary>
 /// <param name = "objcc_ExamPaperStuBatchRelaEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clscc_ExamPaperStuBatchRelaEN objcc_ExamPaperStuBatchRelaEN, bool bolIsNeedCheckUniqueness = true)
{
if (bolIsNeedCheckUniqueness == true && CheckUniqueness(objcc_ExamPaperStuBatchRelaEN) == false)
{
var strMsg = string.Format("记录已经存在!考卷流水号 = [{0}],学生流水号 = [{1}]的数据已经存在!(in clscc_ExamPaperStuBatchRelaBL.AddNewRecord)", objcc_ExamPaperStuBatchRelaEN.CourseExamPaperId,objcc_ExamPaperStuBatchRelaEN.IdStudentInfo);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objcc_ExamPaperStuBatchRelaEN.IdPaperStuBatch) == true || clscc_ExamPaperStuBatchRelaBL.IsExist(objcc_ExamPaperStuBatchRelaEN.IdPaperStuBatch) == true)
 {
     objcc_ExamPaperStuBatchRelaEN.IdPaperStuBatch = clscc_ExamPaperStuBatchRelaBL.GetMaxStrId_S();
 }
bool bolResult = clscc_ExamPaperStuBatchRelaBL.cc_ExamPaperStuBatchRelaDA.AddNewRecordBySQL2(objcc_ExamPaperStuBatchRelaEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clscc_ExamPaperStuBatchRelaBL.ReFreshCache(objcc_ExamPaperStuBatchRelaEN.IdCurrEduCls);

if (clscc_ExamPaperStuBatchRelaBL.relatedActions != null)
{
clscc_ExamPaperStuBatchRelaBL.relatedActions.UpdRelaTabDate(objcc_ExamPaperStuBatchRelaEN.IdPaperStuBatch, objcc_ExamPaperStuBatchRelaEN.UpdUserId);
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
public static bool AddRecordEx(this clscc_ExamPaperStuBatchRelaEN objcc_ExamPaperStuBatchRelaEN, bool bolIsNeedCheckUniqueness = true)
{
//操作步骤:
//1、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在
//2、检查唯一性
//3、检查传进去的对象属性是否合法
//4、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
//1、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在

//因为是字符型自增主键,不需要检查主键是否已经存在,在添加时,再获取 最大值作为主键
//if (clscc_ExamPaperStuBatchRelaBL.IsExist(objcc_ExamPaperStuBatchRelaEN.IdPaperStuBatch))	//判断是否有相同的关键字
//{
//strMsg = "(errid:Busi000151)关键字字段已有相同的值";
//throw new Exception(strMsg);
//}
try
{
 //2、检查传进去的对象属性是否合法
objcc_ExamPaperStuBatchRelaEN.CheckPropertyNew();
 ///5.2、检查唯一性
if (bolIsNeedCheckUniqueness == true && objcc_ExamPaperStuBatchRelaEN.CheckUniqueness() == false)
{
strMsg = string.Format("(考卷流水号(CourseExamPaperId)=[{0}],学生流水号(IdStudentInfo)=[{1}])已经存在,不能重复!", objcc_ExamPaperStuBatchRelaEN.CourseExamPaperId, objcc_ExamPaperStuBatchRelaEN.IdStudentInfo);
throw new Exception(strMsg);
}
//因为是字符型自增主键,所以在添加时,自动获取主键值。
 if (string.IsNullOrEmpty(objcc_ExamPaperStuBatchRelaEN.IdPaperStuBatch) == true || clscc_ExamPaperStuBatchRelaBL.IsExist(objcc_ExamPaperStuBatchRelaEN.IdPaperStuBatch) == true)
 {
     objcc_ExamPaperStuBatchRelaEN.IdPaperStuBatch = clscc_ExamPaperStuBatchRelaBL.GetMaxStrId_S();
 }
//6、把数据实体层的数据存贮到数据库中
objcc_ExamPaperStuBatchRelaEN.AddNewRecord();
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
 /// <param name = "objcc_ExamPaperStuBatchRelaEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static string AddNewRecordWithMaxId(this clscc_ExamPaperStuBatchRelaEN objcc_ExamPaperStuBatchRelaEN, bool bolIsNeedCheckUniqueness = true)
{
if (bolIsNeedCheckUniqueness == true && CheckUniqueness(objcc_ExamPaperStuBatchRelaEN) == false)
{
var strMsg = string.Format("记录已经存在!考卷流水号 = [{0}],学生流水号 = [{1}]的数据已经存在!(in clscc_ExamPaperStuBatchRelaBL.AddNewRecordWithMaxId)", objcc_ExamPaperStuBatchRelaEN.CourseExamPaperId,objcc_ExamPaperStuBatchRelaEN.IdStudentInfo);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objcc_ExamPaperStuBatchRelaEN.IdPaperStuBatch) == true || clscc_ExamPaperStuBatchRelaBL.IsExist(objcc_ExamPaperStuBatchRelaEN.IdPaperStuBatch) == true)
 {
     objcc_ExamPaperStuBatchRelaEN.IdPaperStuBatch = clscc_ExamPaperStuBatchRelaBL.GetMaxStrId_S();
 }
string strIdPaperStuBatch = clscc_ExamPaperStuBatchRelaBL.cc_ExamPaperStuBatchRelaDA.AddNewRecordBySQL2WithReturnKey(objcc_ExamPaperStuBatchRelaEN);
     objcc_ExamPaperStuBatchRelaEN.IdPaperStuBatch = strIdPaperStuBatch;
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clscc_ExamPaperStuBatchRelaBL.ReFreshCache(objcc_ExamPaperStuBatchRelaEN.IdCurrEduCls);

if (clscc_ExamPaperStuBatchRelaBL.relatedActions != null)
{
clscc_ExamPaperStuBatchRelaBL.relatedActions.UpdRelaTabDate(objcc_ExamPaperStuBatchRelaEN.IdPaperStuBatch, objcc_ExamPaperStuBatchRelaEN.UpdUserId);
}
return strIdPaperStuBatch;
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
 /// <param name = "objcc_ExamPaperStuBatchRelaEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordWithReturnKey(this clscc_ExamPaperStuBatchRelaEN objcc_ExamPaperStuBatchRelaEN, bool bolIsNeedCheckUniqueness = true)
{
if (bolIsNeedCheckUniqueness == true && CheckUniqueness(objcc_ExamPaperStuBatchRelaEN) == false)
{
var strMsg = string.Format("记录已经存在!考卷流水号 = [{0}],学生流水号 = [{1}]的数据已经存在!(in clscc_ExamPaperStuBatchRelaBL.AddNewRecordWithReturnKey)", objcc_ExamPaperStuBatchRelaEN.CourseExamPaperId,objcc_ExamPaperStuBatchRelaEN.IdStudentInfo);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objcc_ExamPaperStuBatchRelaEN.IdPaperStuBatch) == true || clscc_ExamPaperStuBatchRelaBL.IsExist(objcc_ExamPaperStuBatchRelaEN.IdPaperStuBatch) == true)
 {
     objcc_ExamPaperStuBatchRelaEN.IdPaperStuBatch = clscc_ExamPaperStuBatchRelaBL.GetMaxStrId_S();
 }
string strKey = clscc_ExamPaperStuBatchRelaBL.cc_ExamPaperStuBatchRelaDA.AddNewRecordBySQL2WithReturnKey(objcc_ExamPaperStuBatchRelaEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clscc_ExamPaperStuBatchRelaBL.ReFreshCache(objcc_ExamPaperStuBatchRelaEN.IdCurrEduCls);

if (clscc_ExamPaperStuBatchRelaBL.relatedActions != null)
{
clscc_ExamPaperStuBatchRelaBL.relatedActions.UpdRelaTabDate(objcc_ExamPaperStuBatchRelaEN.IdPaperStuBatch, objcc_ExamPaperStuBatchRelaEN.UpdUserId);
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
 /// <param name = "objcc_ExamPaperStuBatchRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clscc_ExamPaperStuBatchRelaEN SetIdPaperStuBatch(this clscc_ExamPaperStuBatchRelaEN objcc_ExamPaperStuBatchRelaEN, string strIdPaperStuBatch, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdPaperStuBatch, 10, concc_ExamPaperStuBatchRela.IdPaperStuBatch);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdPaperStuBatch, 10, concc_ExamPaperStuBatchRela.IdPaperStuBatch);
}
objcc_ExamPaperStuBatchRelaEN.IdPaperStuBatch = strIdPaperStuBatch; //学生试卷批次流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_ExamPaperStuBatchRelaEN.dicFldComparisonOp.ContainsKey(concc_ExamPaperStuBatchRela.IdPaperStuBatch) == false)
{
objcc_ExamPaperStuBatchRelaEN.dicFldComparisonOp.Add(concc_ExamPaperStuBatchRela.IdPaperStuBatch, strComparisonOp);
}
else
{
objcc_ExamPaperStuBatchRelaEN.dicFldComparisonOp[concc_ExamPaperStuBatchRela.IdPaperStuBatch] = strComparisonOp;
}
}
return objcc_ExamPaperStuBatchRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_ExamPaperStuBatchRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clscc_ExamPaperStuBatchRelaEN SetCourseExamPaperId(this clscc_ExamPaperStuBatchRelaEN objcc_ExamPaperStuBatchRelaEN, string strCourseExamPaperId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCourseExamPaperId, 8, concc_ExamPaperStuBatchRela.CourseExamPaperId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strCourseExamPaperId, 8, concc_ExamPaperStuBatchRela.CourseExamPaperId);
}
objcc_ExamPaperStuBatchRelaEN.CourseExamPaperId = strCourseExamPaperId; //考卷流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_ExamPaperStuBatchRelaEN.dicFldComparisonOp.ContainsKey(concc_ExamPaperStuBatchRela.CourseExamPaperId) == false)
{
objcc_ExamPaperStuBatchRelaEN.dicFldComparisonOp.Add(concc_ExamPaperStuBatchRela.CourseExamPaperId, strComparisonOp);
}
else
{
objcc_ExamPaperStuBatchRelaEN.dicFldComparisonOp[concc_ExamPaperStuBatchRela.CourseExamPaperId] = strComparisonOp;
}
}
return objcc_ExamPaperStuBatchRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_ExamPaperStuBatchRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clscc_ExamPaperStuBatchRelaEN SetIdStudentInfo(this clscc_ExamPaperStuBatchRelaEN objcc_ExamPaperStuBatchRelaEN, string strIdStudentInfo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strIdStudentInfo, concc_ExamPaperStuBatchRela.IdStudentInfo);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdStudentInfo, 8, concc_ExamPaperStuBatchRela.IdStudentInfo);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdStudentInfo, 8, concc_ExamPaperStuBatchRela.IdStudentInfo);
}
objcc_ExamPaperStuBatchRelaEN.IdStudentInfo = strIdStudentInfo; //学生流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_ExamPaperStuBatchRelaEN.dicFldComparisonOp.ContainsKey(concc_ExamPaperStuBatchRela.IdStudentInfo) == false)
{
objcc_ExamPaperStuBatchRelaEN.dicFldComparisonOp.Add(concc_ExamPaperStuBatchRela.IdStudentInfo, strComparisonOp);
}
else
{
objcc_ExamPaperStuBatchRelaEN.dicFldComparisonOp[concc_ExamPaperStuBatchRela.IdStudentInfo] = strComparisonOp;
}
}
return objcc_ExamPaperStuBatchRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_ExamPaperStuBatchRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clscc_ExamPaperStuBatchRelaEN SetBatchTime(this clscc_ExamPaperStuBatchRelaEN objcc_ExamPaperStuBatchRelaEN, string strBatchTime, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strBatchTime, 14, concc_ExamPaperStuBatchRela.BatchTime);
}
objcc_ExamPaperStuBatchRelaEN.BatchTime = strBatchTime; //批次
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_ExamPaperStuBatchRelaEN.dicFldComparisonOp.ContainsKey(concc_ExamPaperStuBatchRela.BatchTime) == false)
{
objcc_ExamPaperStuBatchRelaEN.dicFldComparisonOp.Add(concc_ExamPaperStuBatchRela.BatchTime, strComparisonOp);
}
else
{
objcc_ExamPaperStuBatchRelaEN.dicFldComparisonOp[concc_ExamPaperStuBatchRela.BatchTime] = strComparisonOp;
}
}
return objcc_ExamPaperStuBatchRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_ExamPaperStuBatchRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clscc_ExamPaperStuBatchRelaEN SetIdCurrEduCls(this clscc_ExamPaperStuBatchRelaEN objcc_ExamPaperStuBatchRelaEN, string strIdCurrEduCls, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strIdCurrEduCls, concc_ExamPaperStuBatchRela.IdCurrEduCls);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdCurrEduCls, 8, concc_ExamPaperStuBatchRela.IdCurrEduCls);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdCurrEduCls, 8, concc_ExamPaperStuBatchRela.IdCurrEduCls);
}
objcc_ExamPaperStuBatchRelaEN.IdCurrEduCls = strIdCurrEduCls; //教学班流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_ExamPaperStuBatchRelaEN.dicFldComparisonOp.ContainsKey(concc_ExamPaperStuBatchRela.IdCurrEduCls) == false)
{
objcc_ExamPaperStuBatchRelaEN.dicFldComparisonOp.Add(concc_ExamPaperStuBatchRela.IdCurrEduCls, strComparisonOp);
}
else
{
objcc_ExamPaperStuBatchRelaEN.dicFldComparisonOp[concc_ExamPaperStuBatchRela.IdCurrEduCls] = strComparisonOp;
}
}
return objcc_ExamPaperStuBatchRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_ExamPaperStuBatchRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clscc_ExamPaperStuBatchRelaEN SetScores(this clscc_ExamPaperStuBatchRelaEN objcc_ExamPaperStuBatchRelaEN, double? dblScores, string strComparisonOp="")
	{
objcc_ExamPaperStuBatchRelaEN.Scores = dblScores; //分值
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_ExamPaperStuBatchRelaEN.dicFldComparisonOp.ContainsKey(concc_ExamPaperStuBatchRela.Scores) == false)
{
objcc_ExamPaperStuBatchRelaEN.dicFldComparisonOp.Add(concc_ExamPaperStuBatchRela.Scores, strComparisonOp);
}
else
{
objcc_ExamPaperStuBatchRelaEN.dicFldComparisonOp[concc_ExamPaperStuBatchRela.Scores] = strComparisonOp;
}
}
return objcc_ExamPaperStuBatchRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_ExamPaperStuBatchRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clscc_ExamPaperStuBatchRelaEN SetIsSave(this clscc_ExamPaperStuBatchRelaEN objcc_ExamPaperStuBatchRelaEN, bool bolIsSave, string strComparisonOp="")
	{
objcc_ExamPaperStuBatchRelaEN.IsSave = bolIsSave; //是否保存
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_ExamPaperStuBatchRelaEN.dicFldComparisonOp.ContainsKey(concc_ExamPaperStuBatchRela.IsSave) == false)
{
objcc_ExamPaperStuBatchRelaEN.dicFldComparisonOp.Add(concc_ExamPaperStuBatchRela.IsSave, strComparisonOp);
}
else
{
objcc_ExamPaperStuBatchRelaEN.dicFldComparisonOp[concc_ExamPaperStuBatchRela.IsSave] = strComparisonOp;
}
}
return objcc_ExamPaperStuBatchRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_ExamPaperStuBatchRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clscc_ExamPaperStuBatchRelaEN SetIsSubmit(this clscc_ExamPaperStuBatchRelaEN objcc_ExamPaperStuBatchRelaEN, bool bolIsSubmit, string strComparisonOp="")
	{
objcc_ExamPaperStuBatchRelaEN.IsSubmit = bolIsSubmit; //是否提交
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_ExamPaperStuBatchRelaEN.dicFldComparisonOp.ContainsKey(concc_ExamPaperStuBatchRela.IsSubmit) == false)
{
objcc_ExamPaperStuBatchRelaEN.dicFldComparisonOp.Add(concc_ExamPaperStuBatchRela.IsSubmit, strComparisonOp);
}
else
{
objcc_ExamPaperStuBatchRelaEN.dicFldComparisonOp[concc_ExamPaperStuBatchRela.IsSubmit] = strComparisonOp;
}
}
return objcc_ExamPaperStuBatchRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_ExamPaperStuBatchRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clscc_ExamPaperStuBatchRelaEN SetRealFinishDate(this clscc_ExamPaperStuBatchRelaEN objcc_ExamPaperStuBatchRelaEN, string strRealFinishDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strRealFinishDate, 14, concc_ExamPaperStuBatchRela.RealFinishDate);
}
objcc_ExamPaperStuBatchRelaEN.RealFinishDate = strRealFinishDate; //实际完成日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_ExamPaperStuBatchRelaEN.dicFldComparisonOp.ContainsKey(concc_ExamPaperStuBatchRela.RealFinishDate) == false)
{
objcc_ExamPaperStuBatchRelaEN.dicFldComparisonOp.Add(concc_ExamPaperStuBatchRela.RealFinishDate, strComparisonOp);
}
else
{
objcc_ExamPaperStuBatchRelaEN.dicFldComparisonOp[concc_ExamPaperStuBatchRela.RealFinishDate] = strComparisonOp;
}
}
return objcc_ExamPaperStuBatchRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_ExamPaperStuBatchRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clscc_ExamPaperStuBatchRelaEN SetOperateTime(this clscc_ExamPaperStuBatchRelaEN objcc_ExamPaperStuBatchRelaEN, string strOperateTime, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strOperateTime, 14, concc_ExamPaperStuBatchRela.OperateTime);
}
objcc_ExamPaperStuBatchRelaEN.OperateTime = strOperateTime; //操作时间
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_ExamPaperStuBatchRelaEN.dicFldComparisonOp.ContainsKey(concc_ExamPaperStuBatchRela.OperateTime) == false)
{
objcc_ExamPaperStuBatchRelaEN.dicFldComparisonOp.Add(concc_ExamPaperStuBatchRela.OperateTime, strComparisonOp);
}
else
{
objcc_ExamPaperStuBatchRelaEN.dicFldComparisonOp[concc_ExamPaperStuBatchRela.OperateTime] = strComparisonOp;
}
}
return objcc_ExamPaperStuBatchRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_ExamPaperStuBatchRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clscc_ExamPaperStuBatchRelaEN SetIsMarking(this clscc_ExamPaperStuBatchRelaEN objcc_ExamPaperStuBatchRelaEN, bool bolIsMarking, string strComparisonOp="")
	{
objcc_ExamPaperStuBatchRelaEN.IsMarking = bolIsMarking; //是否批阅
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_ExamPaperStuBatchRelaEN.dicFldComparisonOp.ContainsKey(concc_ExamPaperStuBatchRela.IsMarking) == false)
{
objcc_ExamPaperStuBatchRelaEN.dicFldComparisonOp.Add(concc_ExamPaperStuBatchRela.IsMarking, strComparisonOp);
}
else
{
objcc_ExamPaperStuBatchRelaEN.dicFldComparisonOp[concc_ExamPaperStuBatchRela.IsMarking] = strComparisonOp;
}
}
return objcc_ExamPaperStuBatchRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_ExamPaperStuBatchRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clscc_ExamPaperStuBatchRelaEN SetMarkerId(this clscc_ExamPaperStuBatchRelaEN objcc_ExamPaperStuBatchRelaEN, string strMarkerId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMarkerId, 20, concc_ExamPaperStuBatchRela.MarkerId);
}
objcc_ExamPaperStuBatchRelaEN.MarkerId = strMarkerId; //打分者
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_ExamPaperStuBatchRelaEN.dicFldComparisonOp.ContainsKey(concc_ExamPaperStuBatchRela.MarkerId) == false)
{
objcc_ExamPaperStuBatchRelaEN.dicFldComparisonOp.Add(concc_ExamPaperStuBatchRela.MarkerId, strComparisonOp);
}
else
{
objcc_ExamPaperStuBatchRelaEN.dicFldComparisonOp[concc_ExamPaperStuBatchRela.MarkerId] = strComparisonOp;
}
}
return objcc_ExamPaperStuBatchRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_ExamPaperStuBatchRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clscc_ExamPaperStuBatchRelaEN SetMarkDate(this clscc_ExamPaperStuBatchRelaEN objcc_ExamPaperStuBatchRelaEN, string strMarkDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMarkDate, 14, concc_ExamPaperStuBatchRela.MarkDate);
}
objcc_ExamPaperStuBatchRelaEN.MarkDate = strMarkDate; //打分日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_ExamPaperStuBatchRelaEN.dicFldComparisonOp.ContainsKey(concc_ExamPaperStuBatchRela.MarkDate) == false)
{
objcc_ExamPaperStuBatchRelaEN.dicFldComparisonOp.Add(concc_ExamPaperStuBatchRela.MarkDate, strComparisonOp);
}
else
{
objcc_ExamPaperStuBatchRelaEN.dicFldComparisonOp[concc_ExamPaperStuBatchRela.MarkDate] = strComparisonOp;
}
}
return objcc_ExamPaperStuBatchRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_ExamPaperStuBatchRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clscc_ExamPaperStuBatchRelaEN SetAnswerIP(this clscc_ExamPaperStuBatchRelaEN objcc_ExamPaperStuBatchRelaEN, string strAnswerIP, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strAnswerIP, 30, concc_ExamPaperStuBatchRela.AnswerIP);
}
objcc_ExamPaperStuBatchRelaEN.AnswerIP = strAnswerIP; //回答IP
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_ExamPaperStuBatchRelaEN.dicFldComparisonOp.ContainsKey(concc_ExamPaperStuBatchRela.AnswerIP) == false)
{
objcc_ExamPaperStuBatchRelaEN.dicFldComparisonOp.Add(concc_ExamPaperStuBatchRela.AnswerIP, strComparisonOp);
}
else
{
objcc_ExamPaperStuBatchRelaEN.dicFldComparisonOp[concc_ExamPaperStuBatchRela.AnswerIP] = strComparisonOp;
}
}
return objcc_ExamPaperStuBatchRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_ExamPaperStuBatchRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clscc_ExamPaperStuBatchRelaEN SetAnswerDate(this clscc_ExamPaperStuBatchRelaEN objcc_ExamPaperStuBatchRelaEN, string strAnswerDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strAnswerDate, 8, concc_ExamPaperStuBatchRela.AnswerDate);
}
objcc_ExamPaperStuBatchRelaEN.AnswerDate = strAnswerDate; //回答日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_ExamPaperStuBatchRelaEN.dicFldComparisonOp.ContainsKey(concc_ExamPaperStuBatchRela.AnswerDate) == false)
{
objcc_ExamPaperStuBatchRelaEN.dicFldComparisonOp.Add(concc_ExamPaperStuBatchRela.AnswerDate, strComparisonOp);
}
else
{
objcc_ExamPaperStuBatchRelaEN.dicFldComparisonOp[concc_ExamPaperStuBatchRela.AnswerDate] = strComparisonOp;
}
}
return objcc_ExamPaperStuBatchRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_ExamPaperStuBatchRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clscc_ExamPaperStuBatchRelaEN SetAnswerTime(this clscc_ExamPaperStuBatchRelaEN objcc_ExamPaperStuBatchRelaEN, string strAnswerTime, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strAnswerTime, 10, concc_ExamPaperStuBatchRela.AnswerTime);
}
objcc_ExamPaperStuBatchRelaEN.AnswerTime = strAnswerTime; //回答时间
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_ExamPaperStuBatchRelaEN.dicFldComparisonOp.ContainsKey(concc_ExamPaperStuBatchRela.AnswerTime) == false)
{
objcc_ExamPaperStuBatchRelaEN.dicFldComparisonOp.Add(concc_ExamPaperStuBatchRela.AnswerTime, strComparisonOp);
}
else
{
objcc_ExamPaperStuBatchRelaEN.dicFldComparisonOp[concc_ExamPaperStuBatchRela.AnswerTime] = strComparisonOp;
}
}
return objcc_ExamPaperStuBatchRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_ExamPaperStuBatchRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clscc_ExamPaperStuBatchRelaEN SetTotalGetScore(this clscc_ExamPaperStuBatchRelaEN objcc_ExamPaperStuBatchRelaEN, double? dblTotalGetScore, string strComparisonOp="")
	{
objcc_ExamPaperStuBatchRelaEN.TotalGetScore = dblTotalGetScore; //考生获取总分
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_ExamPaperStuBatchRelaEN.dicFldComparisonOp.ContainsKey(concc_ExamPaperStuBatchRela.TotalGetScore) == false)
{
objcc_ExamPaperStuBatchRelaEN.dicFldComparisonOp.Add(concc_ExamPaperStuBatchRela.TotalGetScore, strComparisonOp);
}
else
{
objcc_ExamPaperStuBatchRelaEN.dicFldComparisonOp[concc_ExamPaperStuBatchRela.TotalGetScore] = strComparisonOp;
}
}
return objcc_ExamPaperStuBatchRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_ExamPaperStuBatchRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clscc_ExamPaperStuBatchRelaEN SetUpdDate(this clscc_ExamPaperStuBatchRelaEN objcc_ExamPaperStuBatchRelaEN, string strUpdDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strUpdDate, concc_ExamPaperStuBatchRela.UpdDate);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdDate, 20, concc_ExamPaperStuBatchRela.UpdDate);
}
objcc_ExamPaperStuBatchRelaEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_ExamPaperStuBatchRelaEN.dicFldComparisonOp.ContainsKey(concc_ExamPaperStuBatchRela.UpdDate) == false)
{
objcc_ExamPaperStuBatchRelaEN.dicFldComparisonOp.Add(concc_ExamPaperStuBatchRela.UpdDate, strComparisonOp);
}
else
{
objcc_ExamPaperStuBatchRelaEN.dicFldComparisonOp[concc_ExamPaperStuBatchRela.UpdDate] = strComparisonOp;
}
}
return objcc_ExamPaperStuBatchRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_ExamPaperStuBatchRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clscc_ExamPaperStuBatchRelaEN SetUpdUserId(this clscc_ExamPaperStuBatchRelaEN objcc_ExamPaperStuBatchRelaEN, string strUpdUserId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdUserId, 20, concc_ExamPaperStuBatchRela.UpdUserId);
}
objcc_ExamPaperStuBatchRelaEN.UpdUserId = strUpdUserId; //修改用户Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_ExamPaperStuBatchRelaEN.dicFldComparisonOp.ContainsKey(concc_ExamPaperStuBatchRela.UpdUserId) == false)
{
objcc_ExamPaperStuBatchRelaEN.dicFldComparisonOp.Add(concc_ExamPaperStuBatchRela.UpdUserId, strComparisonOp);
}
else
{
objcc_ExamPaperStuBatchRelaEN.dicFldComparisonOp[concc_ExamPaperStuBatchRela.UpdUserId] = strComparisonOp;
}
}
return objcc_ExamPaperStuBatchRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_ExamPaperStuBatchRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clscc_ExamPaperStuBatchRelaEN SetMemo(this clscc_ExamPaperStuBatchRelaEN objcc_ExamPaperStuBatchRelaEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, concc_ExamPaperStuBatchRela.Memo);
}
objcc_ExamPaperStuBatchRelaEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_ExamPaperStuBatchRelaEN.dicFldComparisonOp.ContainsKey(concc_ExamPaperStuBatchRela.Memo) == false)
{
objcc_ExamPaperStuBatchRelaEN.dicFldComparisonOp.Add(concc_ExamPaperStuBatchRela.Memo, strComparisonOp);
}
else
{
objcc_ExamPaperStuBatchRelaEN.dicFldComparisonOp[concc_ExamPaperStuBatchRela.Memo] = strComparisonOp;
}
}
return objcc_ExamPaperStuBatchRelaEN;
	}

 /// <summary>
 /// 修改记录存盘到数据表中
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_UpdateRecordEx)
 /// </summary>
 /// <param name = "objcc_ExamPaperStuBatchRelaEN">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool UpdateRecordEx(this clscc_ExamPaperStuBatchRelaEN objcc_ExamPaperStuBatchRelaEN)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
try
{
//1、检查传进去的对象属性是否合法
objcc_ExamPaperStuBatchRelaEN.CheckPropertyNew();
clscc_ExamPaperStuBatchRelaEN objcc_ExamPaperStuBatchRelaCond = new clscc_ExamPaperStuBatchRelaEN();
string strCondition = objcc_ExamPaperStuBatchRelaCond
.SetIdPaperStuBatch(objcc_ExamPaperStuBatchRelaEN.IdPaperStuBatch, "<>")
.SetCourseExamPaperId(objcc_ExamPaperStuBatchRelaEN.CourseExamPaperId, "=")
.SetIdStudentInfo(objcc_ExamPaperStuBatchRelaEN.IdStudentInfo, "=")
.GetCombineCondition();
objcc_ExamPaperStuBatchRelaEN._IsCheckProperty = true;
bool bolIsExist = clscc_ExamPaperStuBatchRelaBL.IsExistRecord(strCondition);
if (bolIsExist)
{
strMsg = "(CourseExamPaperId_id_StudentInfo)不能重复!";
throw new Exception(strMsg);
}
//4、把数据实体层的数据存贮到数据库中
objcc_ExamPaperStuBatchRelaEN.Update();
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
 /// <param name = "objcc_ExamPaperStuBatchRela">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool EditRecordEx(this clscc_ExamPaperStuBatchRelaEN objcc_ExamPaperStuBatchRela)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
clscc_ExamPaperStuBatchRelaEN objcc_ExamPaperStuBatchRelaCond = new clscc_ExamPaperStuBatchRelaEN();
string strCondition = objcc_ExamPaperStuBatchRelaCond
.SetCourseExamPaperId(objcc_ExamPaperStuBatchRela.CourseExamPaperId, "=")
.SetIdStudentInfo(objcc_ExamPaperStuBatchRela.IdStudentInfo, "=")
.GetCombineCondition();
objcc_ExamPaperStuBatchRela._IsCheckProperty = true;
bool bolIsExist = clscc_ExamPaperStuBatchRelaBL.IsExistRecord(strCondition);
if (bolIsExist)
{
objcc_ExamPaperStuBatchRela.IdPaperStuBatch = clscc_ExamPaperStuBatchRelaBL.GetFirstID_S(strCondition);
objcc_ExamPaperStuBatchRela.UpdateWithCondition(strCondition);
}
else
{
objcc_ExamPaperStuBatchRela.IdPaperStuBatch = clscc_ExamPaperStuBatchRelaBL.GetMaxStrId_S();
objcc_ExamPaperStuBatchRela.AddNewRecord();
}
return true; 
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_Update)
 /// </summary>
 /// <param name = "objcc_ExamPaperStuBatchRelaEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clscc_ExamPaperStuBatchRelaEN objcc_ExamPaperStuBatchRelaEN)
{
 if (string.IsNullOrEmpty(objcc_ExamPaperStuBatchRelaEN.IdPaperStuBatch) == true)
 {
string strMsg = string.Format("(errid:Busi000095)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clscc_ExamPaperStuBatchRelaBL.cc_ExamPaperStuBatchRelaDA.UpdateBySql2(objcc_ExamPaperStuBatchRelaEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clscc_ExamPaperStuBatchRelaBL.ReFreshCache(objcc_ExamPaperStuBatchRelaEN.IdCurrEduCls);

if (clscc_ExamPaperStuBatchRelaBL.relatedActions != null)
{
clscc_ExamPaperStuBatchRelaBL.relatedActions.UpdRelaTabDate(objcc_ExamPaperStuBatchRelaEN.IdPaperStuBatch, objcc_ExamPaperStuBatchRelaEN.UpdUserId);
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
 /// <param name = "objcc_ExamPaperStuBatchRelaEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clscc_ExamPaperStuBatchRelaEN objcc_ExamPaperStuBatchRelaEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (string.IsNullOrEmpty(objcc_ExamPaperStuBatchRelaEN.IdPaperStuBatch) == true)
 {
string strMsg = string.Format("(errid:Busi000087)修改记录时关键字不能为空!(带事务处理)(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clscc_ExamPaperStuBatchRelaBL.cc_ExamPaperStuBatchRelaDA.UpdateBySql2(objcc_ExamPaperStuBatchRelaEN, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clscc_ExamPaperStuBatchRelaBL.ReFreshCache(objcc_ExamPaperStuBatchRelaEN.IdCurrEduCls);

if (clscc_ExamPaperStuBatchRelaBL.relatedActions != null)
{
clscc_ExamPaperStuBatchRelaBL.relatedActions.UpdRelaTabDate(objcc_ExamPaperStuBatchRelaEN.IdPaperStuBatch, objcc_ExamPaperStuBatchRelaEN.UpdUserId);
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
 /// <param name = "objcc_ExamPaperStuBatchRelaEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clscc_ExamPaperStuBatchRelaEN objcc_ExamPaperStuBatchRelaEN, string strWhereCond)
{
try
{
bool bolResult = clscc_ExamPaperStuBatchRelaBL.cc_ExamPaperStuBatchRelaDA.UpdateBySqlWithCondition(objcc_ExamPaperStuBatchRelaEN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clscc_ExamPaperStuBatchRelaBL.ReFreshCache(objcc_ExamPaperStuBatchRelaEN.IdCurrEduCls);

if (clscc_ExamPaperStuBatchRelaBL.relatedActions != null)
{
clscc_ExamPaperStuBatchRelaBL.relatedActions.UpdRelaTabDate(objcc_ExamPaperStuBatchRelaEN.IdPaperStuBatch, objcc_ExamPaperStuBatchRelaEN.UpdUserId);
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
 /// <param name = "objcc_ExamPaperStuBatchRelaEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clscc_ExamPaperStuBatchRelaEN objcc_ExamPaperStuBatchRelaEN, string strWhereCond, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
bool bolResult = clscc_ExamPaperStuBatchRelaBL.cc_ExamPaperStuBatchRelaDA.UpdateBySqlWithConditionTransaction(objcc_ExamPaperStuBatchRelaEN, strWhereCond, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clscc_ExamPaperStuBatchRelaBL.ReFreshCache(objcc_ExamPaperStuBatchRelaEN.IdCurrEduCls);

if (clscc_ExamPaperStuBatchRelaBL.relatedActions != null)
{
clscc_ExamPaperStuBatchRelaBL.relatedActions.UpdRelaTabDate(objcc_ExamPaperStuBatchRelaEN.IdPaperStuBatch, objcc_ExamPaperStuBatchRelaEN.UpdUserId);
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
 /// <param name = "strIdPaperStuBatch">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int Delete(this clscc_ExamPaperStuBatchRelaEN objcc_ExamPaperStuBatchRelaEN)
{
try
{
int intRecNum = clscc_ExamPaperStuBatchRelaBL.cc_ExamPaperStuBatchRelaDA.DelRecord(objcc_ExamPaperStuBatchRelaEN.IdPaperStuBatch);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clscc_ExamPaperStuBatchRelaBL.ReFreshCache(objcc_ExamPaperStuBatchRelaEN.IdCurrEduCls);

if (clscc_ExamPaperStuBatchRelaBL.relatedActions != null)
{
clscc_ExamPaperStuBatchRelaBL.relatedActions.UpdRelaTabDate(objcc_ExamPaperStuBatchRelaEN.IdPaperStuBatch, objcc_ExamPaperStuBatchRelaEN.UpdUserId);
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
 /// <param name = "objcc_ExamPaperStuBatchRelaENS">源对象</param>
 /// <param name = "objcc_ExamPaperStuBatchRelaENT">目标对象</param>
 public static void CopyTo(this clscc_ExamPaperStuBatchRelaEN objcc_ExamPaperStuBatchRelaENS, clscc_ExamPaperStuBatchRelaEN objcc_ExamPaperStuBatchRelaENT)
{
try
{
objcc_ExamPaperStuBatchRelaENT.IdPaperStuBatch = objcc_ExamPaperStuBatchRelaENS.IdPaperStuBatch; //学生试卷批次流水号
objcc_ExamPaperStuBatchRelaENT.CourseExamPaperId = objcc_ExamPaperStuBatchRelaENS.CourseExamPaperId; //考卷流水号
objcc_ExamPaperStuBatchRelaENT.IdStudentInfo = objcc_ExamPaperStuBatchRelaENS.IdStudentInfo; //学生流水号
objcc_ExamPaperStuBatchRelaENT.BatchTime = objcc_ExamPaperStuBatchRelaENS.BatchTime; //批次
objcc_ExamPaperStuBatchRelaENT.IdCurrEduCls = objcc_ExamPaperStuBatchRelaENS.IdCurrEduCls; //教学班流水号
objcc_ExamPaperStuBatchRelaENT.Scores = objcc_ExamPaperStuBatchRelaENS.Scores; //分值
objcc_ExamPaperStuBatchRelaENT.IsSave = objcc_ExamPaperStuBatchRelaENS.IsSave; //是否保存
objcc_ExamPaperStuBatchRelaENT.IsSubmit = objcc_ExamPaperStuBatchRelaENS.IsSubmit; //是否提交
objcc_ExamPaperStuBatchRelaENT.RealFinishDate = objcc_ExamPaperStuBatchRelaENS.RealFinishDate; //实际完成日期
objcc_ExamPaperStuBatchRelaENT.OperateTime = objcc_ExamPaperStuBatchRelaENS.OperateTime; //操作时间
objcc_ExamPaperStuBatchRelaENT.IsMarking = objcc_ExamPaperStuBatchRelaENS.IsMarking; //是否批阅
objcc_ExamPaperStuBatchRelaENT.MarkerId = objcc_ExamPaperStuBatchRelaENS.MarkerId; //打分者
objcc_ExamPaperStuBatchRelaENT.MarkDate = objcc_ExamPaperStuBatchRelaENS.MarkDate; //打分日期
objcc_ExamPaperStuBatchRelaENT.AnswerIP = objcc_ExamPaperStuBatchRelaENS.AnswerIP; //回答IP
objcc_ExamPaperStuBatchRelaENT.AnswerDate = objcc_ExamPaperStuBatchRelaENS.AnswerDate; //回答日期
objcc_ExamPaperStuBatchRelaENT.AnswerTime = objcc_ExamPaperStuBatchRelaENS.AnswerTime; //回答时间
objcc_ExamPaperStuBatchRelaENT.TotalGetScore = objcc_ExamPaperStuBatchRelaENS.TotalGetScore; //考生获取总分
objcc_ExamPaperStuBatchRelaENT.UpdDate = objcc_ExamPaperStuBatchRelaENS.UpdDate; //修改日期
objcc_ExamPaperStuBatchRelaENT.UpdUserId = objcc_ExamPaperStuBatchRelaENS.UpdUserId; //修改用户Id
objcc_ExamPaperStuBatchRelaENT.Memo = objcc_ExamPaperStuBatchRelaENS.Memo; //备注
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
 /// <param name = "objcc_ExamPaperStuBatchRelaENS">源对象</param>
 /// <returns>目标对象=>clscc_ExamPaperStuBatchRelaEN:objcc_ExamPaperStuBatchRelaENT</returns>
 public static clscc_ExamPaperStuBatchRelaEN CopyTo(this clscc_ExamPaperStuBatchRelaEN objcc_ExamPaperStuBatchRelaENS)
{
try
{
 clscc_ExamPaperStuBatchRelaEN objcc_ExamPaperStuBatchRelaENT = new clscc_ExamPaperStuBatchRelaEN()
{
IdPaperStuBatch = objcc_ExamPaperStuBatchRelaENS.IdPaperStuBatch, //学生试卷批次流水号
CourseExamPaperId = objcc_ExamPaperStuBatchRelaENS.CourseExamPaperId, //考卷流水号
IdStudentInfo = objcc_ExamPaperStuBatchRelaENS.IdStudentInfo, //学生流水号
BatchTime = objcc_ExamPaperStuBatchRelaENS.BatchTime, //批次
IdCurrEduCls = objcc_ExamPaperStuBatchRelaENS.IdCurrEduCls, //教学班流水号
Scores = objcc_ExamPaperStuBatchRelaENS.Scores, //分值
IsSave = objcc_ExamPaperStuBatchRelaENS.IsSave, //是否保存
IsSubmit = objcc_ExamPaperStuBatchRelaENS.IsSubmit, //是否提交
RealFinishDate = objcc_ExamPaperStuBatchRelaENS.RealFinishDate, //实际完成日期
OperateTime = objcc_ExamPaperStuBatchRelaENS.OperateTime, //操作时间
IsMarking = objcc_ExamPaperStuBatchRelaENS.IsMarking, //是否批阅
MarkerId = objcc_ExamPaperStuBatchRelaENS.MarkerId, //打分者
MarkDate = objcc_ExamPaperStuBatchRelaENS.MarkDate, //打分日期
AnswerIP = objcc_ExamPaperStuBatchRelaENS.AnswerIP, //回答IP
AnswerDate = objcc_ExamPaperStuBatchRelaENS.AnswerDate, //回答日期
AnswerTime = objcc_ExamPaperStuBatchRelaENS.AnswerTime, //回答时间
TotalGetScore = objcc_ExamPaperStuBatchRelaENS.TotalGetScore, //考生获取总分
UpdDate = objcc_ExamPaperStuBatchRelaENS.UpdDate, //修改日期
UpdUserId = objcc_ExamPaperStuBatchRelaENS.UpdUserId, //修改用户Id
Memo = objcc_ExamPaperStuBatchRelaENS.Memo, //备注
};
 return objcc_ExamPaperStuBatchRelaENT;
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
public static void CheckPropertyNew(this clscc_ExamPaperStuBatchRelaEN objcc_ExamPaperStuBatchRelaEN)
{
 clscc_ExamPaperStuBatchRelaBL.cc_ExamPaperStuBatchRelaDA.CheckPropertyNew(objcc_ExamPaperStuBatchRelaEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(this clscc_ExamPaperStuBatchRelaEN objcc_ExamPaperStuBatchRelaEN)
{
 clscc_ExamPaperStuBatchRelaBL.cc_ExamPaperStuBatchRelaDA.CheckProperty4Condition(objcc_ExamPaperStuBatchRelaEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clscc_ExamPaperStuBatchRelaEN objcc_ExamPaperStuBatchRelaCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objcc_ExamPaperStuBatchRelaCond.IsUpdated(concc_ExamPaperStuBatchRela.IdPaperStuBatch) == true)
{
string strComparisonOpIdPaperStuBatch = objcc_ExamPaperStuBatchRelaCond.dicFldComparisonOp[concc_ExamPaperStuBatchRela.IdPaperStuBatch];
strWhereCond += string.Format(" And {0} {2} '{1}'", concc_ExamPaperStuBatchRela.IdPaperStuBatch, objcc_ExamPaperStuBatchRelaCond.IdPaperStuBatch, strComparisonOpIdPaperStuBatch);
}
if (objcc_ExamPaperStuBatchRelaCond.IsUpdated(concc_ExamPaperStuBatchRela.CourseExamPaperId) == true)
{
string strComparisonOpCourseExamPaperId = objcc_ExamPaperStuBatchRelaCond.dicFldComparisonOp[concc_ExamPaperStuBatchRela.CourseExamPaperId];
strWhereCond += string.Format(" And {0} {2} '{1}'", concc_ExamPaperStuBatchRela.CourseExamPaperId, objcc_ExamPaperStuBatchRelaCond.CourseExamPaperId, strComparisonOpCourseExamPaperId);
}
if (objcc_ExamPaperStuBatchRelaCond.IsUpdated(concc_ExamPaperStuBatchRela.IdStudentInfo) == true)
{
string strComparisonOpIdStudentInfo = objcc_ExamPaperStuBatchRelaCond.dicFldComparisonOp[concc_ExamPaperStuBatchRela.IdStudentInfo];
strWhereCond += string.Format(" And {0} {2} '{1}'", concc_ExamPaperStuBatchRela.IdStudentInfo, objcc_ExamPaperStuBatchRelaCond.IdStudentInfo, strComparisonOpIdStudentInfo);
}
if (objcc_ExamPaperStuBatchRelaCond.IsUpdated(concc_ExamPaperStuBatchRela.BatchTime) == true)
{
string strComparisonOpBatchTime = objcc_ExamPaperStuBatchRelaCond.dicFldComparisonOp[concc_ExamPaperStuBatchRela.BatchTime];
strWhereCond += string.Format(" And {0} {2} '{1}'", concc_ExamPaperStuBatchRela.BatchTime, objcc_ExamPaperStuBatchRelaCond.BatchTime, strComparisonOpBatchTime);
}
if (objcc_ExamPaperStuBatchRelaCond.IsUpdated(concc_ExamPaperStuBatchRela.IdCurrEduCls) == true)
{
string strComparisonOpIdCurrEduCls = objcc_ExamPaperStuBatchRelaCond.dicFldComparisonOp[concc_ExamPaperStuBatchRela.IdCurrEduCls];
strWhereCond += string.Format(" And {0} {2} '{1}'", concc_ExamPaperStuBatchRela.IdCurrEduCls, objcc_ExamPaperStuBatchRelaCond.IdCurrEduCls, strComparisonOpIdCurrEduCls);
}
if (objcc_ExamPaperStuBatchRelaCond.IsUpdated(concc_ExamPaperStuBatchRela.Scores) == true)
{
string strComparisonOpScores = objcc_ExamPaperStuBatchRelaCond.dicFldComparisonOp[concc_ExamPaperStuBatchRela.Scores];
strWhereCond += string.Format(" And {0} {2} {1}", concc_ExamPaperStuBatchRela.Scores, objcc_ExamPaperStuBatchRelaCond.Scores, strComparisonOpScores);
}
if (objcc_ExamPaperStuBatchRelaCond.IsUpdated(concc_ExamPaperStuBatchRela.IsSave) == true)
{
if (objcc_ExamPaperStuBatchRelaCond.IsSave == true)
{
strWhereCond += string.Format(" And {0} = '1'", concc_ExamPaperStuBatchRela.IsSave);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", concc_ExamPaperStuBatchRela.IsSave);
}
}
if (objcc_ExamPaperStuBatchRelaCond.IsUpdated(concc_ExamPaperStuBatchRela.IsSubmit) == true)
{
if (objcc_ExamPaperStuBatchRelaCond.IsSubmit == true)
{
strWhereCond += string.Format(" And {0} = '1'", concc_ExamPaperStuBatchRela.IsSubmit);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", concc_ExamPaperStuBatchRela.IsSubmit);
}
}
if (objcc_ExamPaperStuBatchRelaCond.IsUpdated(concc_ExamPaperStuBatchRela.RealFinishDate) == true)
{
string strComparisonOpRealFinishDate = objcc_ExamPaperStuBatchRelaCond.dicFldComparisonOp[concc_ExamPaperStuBatchRela.RealFinishDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", concc_ExamPaperStuBatchRela.RealFinishDate, objcc_ExamPaperStuBatchRelaCond.RealFinishDate, strComparisonOpRealFinishDate);
}
if (objcc_ExamPaperStuBatchRelaCond.IsUpdated(concc_ExamPaperStuBatchRela.OperateTime) == true)
{
string strComparisonOpOperateTime = objcc_ExamPaperStuBatchRelaCond.dicFldComparisonOp[concc_ExamPaperStuBatchRela.OperateTime];
strWhereCond += string.Format(" And {0} {2} '{1}'", concc_ExamPaperStuBatchRela.OperateTime, objcc_ExamPaperStuBatchRelaCond.OperateTime, strComparisonOpOperateTime);
}
if (objcc_ExamPaperStuBatchRelaCond.IsUpdated(concc_ExamPaperStuBatchRela.IsMarking) == true)
{
if (objcc_ExamPaperStuBatchRelaCond.IsMarking == true)
{
strWhereCond += string.Format(" And {0} = '1'", concc_ExamPaperStuBatchRela.IsMarking);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", concc_ExamPaperStuBatchRela.IsMarking);
}
}
if (objcc_ExamPaperStuBatchRelaCond.IsUpdated(concc_ExamPaperStuBatchRela.MarkerId) == true)
{
string strComparisonOpMarkerId = objcc_ExamPaperStuBatchRelaCond.dicFldComparisonOp[concc_ExamPaperStuBatchRela.MarkerId];
strWhereCond += string.Format(" And {0} {2} '{1}'", concc_ExamPaperStuBatchRela.MarkerId, objcc_ExamPaperStuBatchRelaCond.MarkerId, strComparisonOpMarkerId);
}
if (objcc_ExamPaperStuBatchRelaCond.IsUpdated(concc_ExamPaperStuBatchRela.MarkDate) == true)
{
string strComparisonOpMarkDate = objcc_ExamPaperStuBatchRelaCond.dicFldComparisonOp[concc_ExamPaperStuBatchRela.MarkDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", concc_ExamPaperStuBatchRela.MarkDate, objcc_ExamPaperStuBatchRelaCond.MarkDate, strComparisonOpMarkDate);
}
if (objcc_ExamPaperStuBatchRelaCond.IsUpdated(concc_ExamPaperStuBatchRela.AnswerIP) == true)
{
string strComparisonOpAnswerIP = objcc_ExamPaperStuBatchRelaCond.dicFldComparisonOp[concc_ExamPaperStuBatchRela.AnswerIP];
strWhereCond += string.Format(" And {0} {2} '{1}'", concc_ExamPaperStuBatchRela.AnswerIP, objcc_ExamPaperStuBatchRelaCond.AnswerIP, strComparisonOpAnswerIP);
}
if (objcc_ExamPaperStuBatchRelaCond.IsUpdated(concc_ExamPaperStuBatchRela.AnswerDate) == true)
{
string strComparisonOpAnswerDate = objcc_ExamPaperStuBatchRelaCond.dicFldComparisonOp[concc_ExamPaperStuBatchRela.AnswerDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", concc_ExamPaperStuBatchRela.AnswerDate, objcc_ExamPaperStuBatchRelaCond.AnswerDate, strComparisonOpAnswerDate);
}
if (objcc_ExamPaperStuBatchRelaCond.IsUpdated(concc_ExamPaperStuBatchRela.AnswerTime) == true)
{
string strComparisonOpAnswerTime = objcc_ExamPaperStuBatchRelaCond.dicFldComparisonOp[concc_ExamPaperStuBatchRela.AnswerTime];
strWhereCond += string.Format(" And {0} {2} '{1}'", concc_ExamPaperStuBatchRela.AnswerTime, objcc_ExamPaperStuBatchRelaCond.AnswerTime, strComparisonOpAnswerTime);
}
if (objcc_ExamPaperStuBatchRelaCond.IsUpdated(concc_ExamPaperStuBatchRela.TotalGetScore) == true)
{
string strComparisonOpTotalGetScore = objcc_ExamPaperStuBatchRelaCond.dicFldComparisonOp[concc_ExamPaperStuBatchRela.TotalGetScore];
strWhereCond += string.Format(" And {0} {2} {1}", concc_ExamPaperStuBatchRela.TotalGetScore, objcc_ExamPaperStuBatchRelaCond.TotalGetScore, strComparisonOpTotalGetScore);
}
if (objcc_ExamPaperStuBatchRelaCond.IsUpdated(concc_ExamPaperStuBatchRela.UpdDate) == true)
{
string strComparisonOpUpdDate = objcc_ExamPaperStuBatchRelaCond.dicFldComparisonOp[concc_ExamPaperStuBatchRela.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", concc_ExamPaperStuBatchRela.UpdDate, objcc_ExamPaperStuBatchRelaCond.UpdDate, strComparisonOpUpdDate);
}
if (objcc_ExamPaperStuBatchRelaCond.IsUpdated(concc_ExamPaperStuBatchRela.UpdUserId) == true)
{
string strComparisonOpUpdUserId = objcc_ExamPaperStuBatchRelaCond.dicFldComparisonOp[concc_ExamPaperStuBatchRela.UpdUserId];
strWhereCond += string.Format(" And {0} {2} '{1}'", concc_ExamPaperStuBatchRela.UpdUserId, objcc_ExamPaperStuBatchRelaCond.UpdUserId, strComparisonOpUpdUserId);
}
if (objcc_ExamPaperStuBatchRelaCond.IsUpdated(concc_ExamPaperStuBatchRela.Memo) == true)
{
string strComparisonOpMemo = objcc_ExamPaperStuBatchRelaCond.dicFldComparisonOp[concc_ExamPaperStuBatchRela.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", concc_ExamPaperStuBatchRela.Memo, objcc_ExamPaperStuBatchRelaCond.Memo, strComparisonOpMemo);
}
 return strWhereCond;
}

 /// <summary>
 /// 检查唯一性(Uniqueness)--cc_ExamPaperStuBatchRela(考卷与学生批次关系), 如果不唯一,即存在相同的记录,就返回False
 /// 唯一性条件:CourseExamPaperId_id_StudentInfo
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckConstraint)
 /// </summary>
 /// <param name = "objcc_ExamPaperStuBatchRelaEN">要求唯一的对象</param>
 /// <returns></returns>
public static bool CheckUniqueness(this clscc_ExamPaperStuBatchRelaEN objcc_ExamPaperStuBatchRelaEN)
{
//检测记录是否存在
bool bolIsUniqueness;
StringBuilder sbCondition = new StringBuilder();
if (objcc_ExamPaperStuBatchRelaEN == null) return true;
if (objcc_ExamPaperStuBatchRelaEN.IdPaperStuBatch == null || objcc_ExamPaperStuBatchRelaEN.IdPaperStuBatch == "")
{
sbCondition.AppendFormat("1 = 1");
 if (objcc_ExamPaperStuBatchRelaEN.CourseExamPaperId == null)
{
 sbCondition.AppendFormat(" and CourseExamPaperId is null", objcc_ExamPaperStuBatchRelaEN.CourseExamPaperId);
}
else
{
 sbCondition.AppendFormat(" and CourseExamPaperId = '{0}'", objcc_ExamPaperStuBatchRelaEN.CourseExamPaperId);
}
 sbCondition.AppendFormat(" and IdStudentInfo = '{0}'", objcc_ExamPaperStuBatchRelaEN.IdStudentInfo);
if (clscc_ExamPaperStuBatchRelaBL.IsExistRecord(sbCondition.ToString())  ==  true)
{
 bolIsUniqueness = false;
}
else
{
 bolIsUniqueness = true;
}
}
 else {
sbCondition.AppendFormat("IdPaperStuBatch !=  '{0}'", objcc_ExamPaperStuBatchRelaEN.IdPaperStuBatch);
 sbCondition.AppendFormat(" and CourseExamPaperId = '{0}'", objcc_ExamPaperStuBatchRelaEN.CourseExamPaperId);
 sbCondition.AppendFormat(" and IdStudentInfo = '{0}'", objcc_ExamPaperStuBatchRelaEN.IdStudentInfo);
if (clscc_ExamPaperStuBatchRelaBL.IsExistRecord(sbCondition.ToString())  ==  true)
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
 /// 获取唯一性条件串--cc_ExamPaperStuBatchRela(考卷与学生批次关系), 即由对象中唯一性条件字段关键字与值组成的条件串
 /// 唯一性条件:CourseExamPaperId_id_StudentInfo
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetConditionString4Constraint)
 /// </summary>
 /// <param name = "objcc_ExamPaperStuBatchRelaEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(this clscc_ExamPaperStuBatchRelaEN objcc_ExamPaperStuBatchRelaEN)
{
//检测记录是否存在
StringBuilder sbCondition = new StringBuilder();
if (objcc_ExamPaperStuBatchRelaEN == null) return "";
if (objcc_ExamPaperStuBatchRelaEN.IdPaperStuBatch == null || objcc_ExamPaperStuBatchRelaEN.IdPaperStuBatch == "")
{
sbCondition.AppendFormat("1 = 1");
 if (objcc_ExamPaperStuBatchRelaEN.CourseExamPaperId == null)
{
 sbCondition.AppendFormat(" and CourseExamPaperId is null", objcc_ExamPaperStuBatchRelaEN.CourseExamPaperId);
}
else
{
 sbCondition.AppendFormat(" and CourseExamPaperId = '{0}'", objcc_ExamPaperStuBatchRelaEN.CourseExamPaperId);
}
 sbCondition.AppendFormat(" and IdStudentInfo = '{0}'", objcc_ExamPaperStuBatchRelaEN.IdStudentInfo);
return sbCondition.ToString();
}
 else {
sbCondition.AppendFormat("IdPaperStuBatch !=  '{0}'", objcc_ExamPaperStuBatchRelaEN.IdPaperStuBatch);
 sbCondition.AppendFormat(" and CourseExamPaperId = '{0}'", objcc_ExamPaperStuBatchRelaEN.CourseExamPaperId);
 sbCondition.AppendFormat(" and IdStudentInfo = '{0}'", objcc_ExamPaperStuBatchRelaEN.IdStudentInfo);
 return sbCondition.ToString();
}
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_cc_ExamPaperStuBatchRela
{
public virtual bool UpdRelaTabDate(string strIdPaperStuBatch, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// 考卷与学生批次关系(cc_ExamPaperStuBatchRela)
 /// 数据源类型:表
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clscc_ExamPaperStuBatchRelaBL
{
public static RelatedActions_cc_ExamPaperStuBatchRela relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clscc_ExamPaperStuBatchRelaDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clscc_ExamPaperStuBatchRelaDA cc_ExamPaperStuBatchRelaDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clscc_ExamPaperStuBatchRelaDA();
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
 public clscc_ExamPaperStuBatchRelaBL()
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
if (string.IsNullOrEmpty(clscc_ExamPaperStuBatchRelaEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clscc_ExamPaperStuBatchRelaEN._ConnectString);
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
public static DataTable GetDataTable_cc_ExamPaperStuBatchRela(string strWhereCond)
{
DataTable objDT;
try
{
objDT = cc_ExamPaperStuBatchRelaDA.GetDataTable_cc_ExamPaperStuBatchRela(strWhereCond);
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
objDT = cc_ExamPaperStuBatchRelaDA.GetDataTable(strWhereCond);
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
objDT = cc_ExamPaperStuBatchRelaDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = cc_ExamPaperStuBatchRelaDA.GetDataTable(strWhereCond, strTabName);
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
objDT = cc_ExamPaperStuBatchRelaDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = cc_ExamPaperStuBatchRelaDA.GetDataTable_Top(objTopPara);
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
objDT = cc_ExamPaperStuBatchRelaDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = cc_ExamPaperStuBatchRelaDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = cc_ExamPaperStuBatchRelaDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
 /// <param name = "arrIdPaperStuBatchLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static List<clscc_ExamPaperStuBatchRelaEN> GetObjLstByIdPaperStuBatchLst(List<string> arrIdPaperStuBatchLst)
{
List<clscc_ExamPaperStuBatchRelaEN> arrObjLst = new List<clscc_ExamPaperStuBatchRelaEN>(); 
System.Data.DataTable objDT; 
 string strSqlConditionStr = clsArray.GetSqlInStrByArray(arrIdPaperStuBatchLst, true);
 string strWhereCond = string.Format("IdPaperStuBatch in ({0})", strSqlConditionStr);
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clscc_ExamPaperStuBatchRelaEN objcc_ExamPaperStuBatchRelaEN = new clscc_ExamPaperStuBatchRelaEN();
try
{
objcc_ExamPaperStuBatchRelaEN.IdPaperStuBatch = objRow[concc_ExamPaperStuBatchRela.IdPaperStuBatch].ToString().Trim(); //学生试卷批次流水号
objcc_ExamPaperStuBatchRelaEN.CourseExamPaperId = objRow[concc_ExamPaperStuBatchRela.CourseExamPaperId] == DBNull.Value ? null : objRow[concc_ExamPaperStuBatchRela.CourseExamPaperId].ToString().Trim(); //考卷流水号
objcc_ExamPaperStuBatchRelaEN.IdStudentInfo = objRow[concc_ExamPaperStuBatchRela.IdStudentInfo].ToString().Trim(); //学生流水号
objcc_ExamPaperStuBatchRelaEN.BatchTime = objRow[concc_ExamPaperStuBatchRela.BatchTime] == DBNull.Value ? null : objRow[concc_ExamPaperStuBatchRela.BatchTime].ToString().Trim(); //批次
objcc_ExamPaperStuBatchRelaEN.IdCurrEduCls = objRow[concc_ExamPaperStuBatchRela.IdCurrEduCls].ToString().Trim(); //教学班流水号
objcc_ExamPaperStuBatchRelaEN.Scores = objRow[concc_ExamPaperStuBatchRela.Scores] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[concc_ExamPaperStuBatchRela.Scores].ToString().Trim()); //分值
objcc_ExamPaperStuBatchRelaEN.IsSave = clsEntityBase2.TransNullToBool_S(objRow[concc_ExamPaperStuBatchRela.IsSave].ToString().Trim()); //是否保存
objcc_ExamPaperStuBatchRelaEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[concc_ExamPaperStuBatchRela.IsSubmit].ToString().Trim()); //是否提交
objcc_ExamPaperStuBatchRelaEN.RealFinishDate = objRow[concc_ExamPaperStuBatchRela.RealFinishDate] == DBNull.Value ? null : objRow[concc_ExamPaperStuBatchRela.RealFinishDate].ToString().Trim(); //实际完成日期
objcc_ExamPaperStuBatchRelaEN.OperateTime = objRow[concc_ExamPaperStuBatchRela.OperateTime] == DBNull.Value ? null : objRow[concc_ExamPaperStuBatchRela.OperateTime].ToString().Trim(); //操作时间
objcc_ExamPaperStuBatchRelaEN.IsMarking = clsEntityBase2.TransNullToBool_S(objRow[concc_ExamPaperStuBatchRela.IsMarking].ToString().Trim()); //是否批阅
objcc_ExamPaperStuBatchRelaEN.MarkerId = objRow[concc_ExamPaperStuBatchRela.MarkerId] == DBNull.Value ? null : objRow[concc_ExamPaperStuBatchRela.MarkerId].ToString().Trim(); //打分者
objcc_ExamPaperStuBatchRelaEN.MarkDate = objRow[concc_ExamPaperStuBatchRela.MarkDate] == DBNull.Value ? null : objRow[concc_ExamPaperStuBatchRela.MarkDate].ToString().Trim(); //打分日期
objcc_ExamPaperStuBatchRelaEN.AnswerIP = objRow[concc_ExamPaperStuBatchRela.AnswerIP] == DBNull.Value ? null : objRow[concc_ExamPaperStuBatchRela.AnswerIP].ToString().Trim(); //回答IP
objcc_ExamPaperStuBatchRelaEN.AnswerDate = objRow[concc_ExamPaperStuBatchRela.AnswerDate] == DBNull.Value ? null : objRow[concc_ExamPaperStuBatchRela.AnswerDate].ToString().Trim(); //回答日期
objcc_ExamPaperStuBatchRelaEN.AnswerTime = objRow[concc_ExamPaperStuBatchRela.AnswerTime] == DBNull.Value ? null : objRow[concc_ExamPaperStuBatchRela.AnswerTime].ToString().Trim(); //回答时间
objcc_ExamPaperStuBatchRelaEN.TotalGetScore = objRow[concc_ExamPaperStuBatchRela.TotalGetScore] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[concc_ExamPaperStuBatchRela.TotalGetScore].ToString().Trim()); //考生获取总分
objcc_ExamPaperStuBatchRelaEN.UpdDate = objRow[concc_ExamPaperStuBatchRela.UpdDate].ToString().Trim(); //修改日期
objcc_ExamPaperStuBatchRelaEN.UpdUserId = objRow[concc_ExamPaperStuBatchRela.UpdUserId] == DBNull.Value ? null : objRow[concc_ExamPaperStuBatchRela.UpdUserId].ToString().Trim(); //修改用户Id
objcc_ExamPaperStuBatchRelaEN.Memo = objRow[concc_ExamPaperStuBatchRela.Memo] == DBNull.Value ? null : objRow[concc_ExamPaperStuBatchRela.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objcc_ExamPaperStuBatchRelaEN.IdPaperStuBatch, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objcc_ExamPaperStuBatchRelaEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrIdPaperStuBatchLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clscc_ExamPaperStuBatchRelaEN> GetObjLstByIdPaperStuBatchLstCache(List<string> arrIdPaperStuBatchLst, string strIdCurrEduCls)
{
string strKey = string.Format("{0}_{1}", clscc_ExamPaperStuBatchRelaEN._CurrTabName, strIdCurrEduCls);
List<clscc_ExamPaperStuBatchRelaEN> arrcc_ExamPaperStuBatchRelaObjLstCache = GetObjLstCache(strIdCurrEduCls);
IEnumerable <clscc_ExamPaperStuBatchRelaEN> arrcc_ExamPaperStuBatchRelaObjLst_Sel =
arrcc_ExamPaperStuBatchRelaObjLstCache
.Where(x => arrIdPaperStuBatchLst.Contains(x.IdPaperStuBatch));
return arrcc_ExamPaperStuBatchRelaObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clscc_ExamPaperStuBatchRelaEN> GetObjLst(string strWhereCond)
{
List<clscc_ExamPaperStuBatchRelaEN> arrObjLst = new List<clscc_ExamPaperStuBatchRelaEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clscc_ExamPaperStuBatchRelaEN objcc_ExamPaperStuBatchRelaEN = new clscc_ExamPaperStuBatchRelaEN();
try
{
objcc_ExamPaperStuBatchRelaEN.IdPaperStuBatch = objRow[concc_ExamPaperStuBatchRela.IdPaperStuBatch].ToString().Trim(); //学生试卷批次流水号
objcc_ExamPaperStuBatchRelaEN.CourseExamPaperId = objRow[concc_ExamPaperStuBatchRela.CourseExamPaperId] == DBNull.Value ? null : objRow[concc_ExamPaperStuBatchRela.CourseExamPaperId].ToString().Trim(); //考卷流水号
objcc_ExamPaperStuBatchRelaEN.IdStudentInfo = objRow[concc_ExamPaperStuBatchRela.IdStudentInfo].ToString().Trim(); //学生流水号
objcc_ExamPaperStuBatchRelaEN.BatchTime = objRow[concc_ExamPaperStuBatchRela.BatchTime] == DBNull.Value ? null : objRow[concc_ExamPaperStuBatchRela.BatchTime].ToString().Trim(); //批次
objcc_ExamPaperStuBatchRelaEN.IdCurrEduCls = objRow[concc_ExamPaperStuBatchRela.IdCurrEduCls].ToString().Trim(); //教学班流水号
objcc_ExamPaperStuBatchRelaEN.Scores = objRow[concc_ExamPaperStuBatchRela.Scores] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[concc_ExamPaperStuBatchRela.Scores].ToString().Trim()); //分值
objcc_ExamPaperStuBatchRelaEN.IsSave = clsEntityBase2.TransNullToBool_S(objRow[concc_ExamPaperStuBatchRela.IsSave].ToString().Trim()); //是否保存
objcc_ExamPaperStuBatchRelaEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[concc_ExamPaperStuBatchRela.IsSubmit].ToString().Trim()); //是否提交
objcc_ExamPaperStuBatchRelaEN.RealFinishDate = objRow[concc_ExamPaperStuBatchRela.RealFinishDate] == DBNull.Value ? null : objRow[concc_ExamPaperStuBatchRela.RealFinishDate].ToString().Trim(); //实际完成日期
objcc_ExamPaperStuBatchRelaEN.OperateTime = objRow[concc_ExamPaperStuBatchRela.OperateTime] == DBNull.Value ? null : objRow[concc_ExamPaperStuBatchRela.OperateTime].ToString().Trim(); //操作时间
objcc_ExamPaperStuBatchRelaEN.IsMarking = clsEntityBase2.TransNullToBool_S(objRow[concc_ExamPaperStuBatchRela.IsMarking].ToString().Trim()); //是否批阅
objcc_ExamPaperStuBatchRelaEN.MarkerId = objRow[concc_ExamPaperStuBatchRela.MarkerId] == DBNull.Value ? null : objRow[concc_ExamPaperStuBatchRela.MarkerId].ToString().Trim(); //打分者
objcc_ExamPaperStuBatchRelaEN.MarkDate = objRow[concc_ExamPaperStuBatchRela.MarkDate] == DBNull.Value ? null : objRow[concc_ExamPaperStuBatchRela.MarkDate].ToString().Trim(); //打分日期
objcc_ExamPaperStuBatchRelaEN.AnswerIP = objRow[concc_ExamPaperStuBatchRela.AnswerIP] == DBNull.Value ? null : objRow[concc_ExamPaperStuBatchRela.AnswerIP].ToString().Trim(); //回答IP
objcc_ExamPaperStuBatchRelaEN.AnswerDate = objRow[concc_ExamPaperStuBatchRela.AnswerDate] == DBNull.Value ? null : objRow[concc_ExamPaperStuBatchRela.AnswerDate].ToString().Trim(); //回答日期
objcc_ExamPaperStuBatchRelaEN.AnswerTime = objRow[concc_ExamPaperStuBatchRela.AnswerTime] == DBNull.Value ? null : objRow[concc_ExamPaperStuBatchRela.AnswerTime].ToString().Trim(); //回答时间
objcc_ExamPaperStuBatchRelaEN.TotalGetScore = objRow[concc_ExamPaperStuBatchRela.TotalGetScore] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[concc_ExamPaperStuBatchRela.TotalGetScore].ToString().Trim()); //考生获取总分
objcc_ExamPaperStuBatchRelaEN.UpdDate = objRow[concc_ExamPaperStuBatchRela.UpdDate].ToString().Trim(); //修改日期
objcc_ExamPaperStuBatchRelaEN.UpdUserId = objRow[concc_ExamPaperStuBatchRela.UpdUserId] == DBNull.Value ? null : objRow[concc_ExamPaperStuBatchRela.UpdUserId].ToString().Trim(); //修改用户Id
objcc_ExamPaperStuBatchRelaEN.Memo = objRow[concc_ExamPaperStuBatchRela.Memo] == DBNull.Value ? null : objRow[concc_ExamPaperStuBatchRela.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objcc_ExamPaperStuBatchRelaEN.IdPaperStuBatch, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objcc_ExamPaperStuBatchRelaEN);
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
public static List<clscc_ExamPaperStuBatchRelaEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clscc_ExamPaperStuBatchRelaEN> arrObjLst = new List<clscc_ExamPaperStuBatchRelaEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clscc_ExamPaperStuBatchRelaEN objcc_ExamPaperStuBatchRelaEN = new clscc_ExamPaperStuBatchRelaEN();
try
{
objcc_ExamPaperStuBatchRelaEN.IdPaperStuBatch = objRow[concc_ExamPaperStuBatchRela.IdPaperStuBatch].ToString().Trim(); //学生试卷批次流水号
objcc_ExamPaperStuBatchRelaEN.CourseExamPaperId = objRow[concc_ExamPaperStuBatchRela.CourseExamPaperId] == DBNull.Value ? null : objRow[concc_ExamPaperStuBatchRela.CourseExamPaperId].ToString().Trim(); //考卷流水号
objcc_ExamPaperStuBatchRelaEN.IdStudentInfo = objRow[concc_ExamPaperStuBatchRela.IdStudentInfo].ToString().Trim(); //学生流水号
objcc_ExamPaperStuBatchRelaEN.BatchTime = objRow[concc_ExamPaperStuBatchRela.BatchTime] == DBNull.Value ? null : objRow[concc_ExamPaperStuBatchRela.BatchTime].ToString().Trim(); //批次
objcc_ExamPaperStuBatchRelaEN.IdCurrEduCls = objRow[concc_ExamPaperStuBatchRela.IdCurrEduCls].ToString().Trim(); //教学班流水号
objcc_ExamPaperStuBatchRelaEN.Scores = objRow[concc_ExamPaperStuBatchRela.Scores] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[concc_ExamPaperStuBatchRela.Scores].ToString().Trim()); //分值
objcc_ExamPaperStuBatchRelaEN.IsSave = clsEntityBase2.TransNullToBool_S(objRow[concc_ExamPaperStuBatchRela.IsSave].ToString().Trim()); //是否保存
objcc_ExamPaperStuBatchRelaEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[concc_ExamPaperStuBatchRela.IsSubmit].ToString().Trim()); //是否提交
objcc_ExamPaperStuBatchRelaEN.RealFinishDate = objRow[concc_ExamPaperStuBatchRela.RealFinishDate] == DBNull.Value ? null : objRow[concc_ExamPaperStuBatchRela.RealFinishDate].ToString().Trim(); //实际完成日期
objcc_ExamPaperStuBatchRelaEN.OperateTime = objRow[concc_ExamPaperStuBatchRela.OperateTime] == DBNull.Value ? null : objRow[concc_ExamPaperStuBatchRela.OperateTime].ToString().Trim(); //操作时间
objcc_ExamPaperStuBatchRelaEN.IsMarking = clsEntityBase2.TransNullToBool_S(objRow[concc_ExamPaperStuBatchRela.IsMarking].ToString().Trim()); //是否批阅
objcc_ExamPaperStuBatchRelaEN.MarkerId = objRow[concc_ExamPaperStuBatchRela.MarkerId] == DBNull.Value ? null : objRow[concc_ExamPaperStuBatchRela.MarkerId].ToString().Trim(); //打分者
objcc_ExamPaperStuBatchRelaEN.MarkDate = objRow[concc_ExamPaperStuBatchRela.MarkDate] == DBNull.Value ? null : objRow[concc_ExamPaperStuBatchRela.MarkDate].ToString().Trim(); //打分日期
objcc_ExamPaperStuBatchRelaEN.AnswerIP = objRow[concc_ExamPaperStuBatchRela.AnswerIP] == DBNull.Value ? null : objRow[concc_ExamPaperStuBatchRela.AnswerIP].ToString().Trim(); //回答IP
objcc_ExamPaperStuBatchRelaEN.AnswerDate = objRow[concc_ExamPaperStuBatchRela.AnswerDate] == DBNull.Value ? null : objRow[concc_ExamPaperStuBatchRela.AnswerDate].ToString().Trim(); //回答日期
objcc_ExamPaperStuBatchRelaEN.AnswerTime = objRow[concc_ExamPaperStuBatchRela.AnswerTime] == DBNull.Value ? null : objRow[concc_ExamPaperStuBatchRela.AnswerTime].ToString().Trim(); //回答时间
objcc_ExamPaperStuBatchRelaEN.TotalGetScore = objRow[concc_ExamPaperStuBatchRela.TotalGetScore] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[concc_ExamPaperStuBatchRela.TotalGetScore].ToString().Trim()); //考生获取总分
objcc_ExamPaperStuBatchRelaEN.UpdDate = objRow[concc_ExamPaperStuBatchRela.UpdDate].ToString().Trim(); //修改日期
objcc_ExamPaperStuBatchRelaEN.UpdUserId = objRow[concc_ExamPaperStuBatchRela.UpdUserId] == DBNull.Value ? null : objRow[concc_ExamPaperStuBatchRela.UpdUserId].ToString().Trim(); //修改用户Id
objcc_ExamPaperStuBatchRelaEN.Memo = objRow[concc_ExamPaperStuBatchRela.Memo] == DBNull.Value ? null : objRow[concc_ExamPaperStuBatchRela.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objcc_ExamPaperStuBatchRelaEN.IdPaperStuBatch, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objcc_ExamPaperStuBatchRelaEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objcc_ExamPaperStuBatchRelaCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clscc_ExamPaperStuBatchRelaEN> GetSubObjLstCache(clscc_ExamPaperStuBatchRelaEN objcc_ExamPaperStuBatchRelaCond)
{
 string strIdCurrEduCls = objcc_ExamPaperStuBatchRelaCond.IdCurrEduCls;
 if (string.IsNullOrEmpty(strIdCurrEduCls) == true)
{
string strMsg = string.Format("(errid:Busi000172)在表中,缓存分类字段值不能为空!(clscc_ExamPaperStuBatchRelaBL:GetSubObjLstCache)");
throw new Exception(strMsg);
}
List<clscc_ExamPaperStuBatchRelaEN> arrObjLstCache = GetObjLstCache(strIdCurrEduCls);
IEnumerable <clscc_ExamPaperStuBatchRelaEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in concc_ExamPaperStuBatchRela.AttributeName)
{
if (objcc_ExamPaperStuBatchRelaCond.IsUpdated(strFldName) == false) continue;
if (objcc_ExamPaperStuBatchRelaCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objcc_ExamPaperStuBatchRelaCond[strFldName].ToString());
}
else
{
if (objcc_ExamPaperStuBatchRelaCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objcc_ExamPaperStuBatchRelaCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objcc_ExamPaperStuBatchRelaCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objcc_ExamPaperStuBatchRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objcc_ExamPaperStuBatchRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objcc_ExamPaperStuBatchRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objcc_ExamPaperStuBatchRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objcc_ExamPaperStuBatchRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objcc_ExamPaperStuBatchRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objcc_ExamPaperStuBatchRelaCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objcc_ExamPaperStuBatchRelaCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objcc_ExamPaperStuBatchRelaCond[strFldName]));
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
public static List<clscc_ExamPaperStuBatchRelaEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clscc_ExamPaperStuBatchRelaEN> arrObjLst = new List<clscc_ExamPaperStuBatchRelaEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clscc_ExamPaperStuBatchRelaEN objcc_ExamPaperStuBatchRelaEN = new clscc_ExamPaperStuBatchRelaEN();
try
{
objcc_ExamPaperStuBatchRelaEN.IdPaperStuBatch = objRow[concc_ExamPaperStuBatchRela.IdPaperStuBatch].ToString().Trim(); //学生试卷批次流水号
objcc_ExamPaperStuBatchRelaEN.CourseExamPaperId = objRow[concc_ExamPaperStuBatchRela.CourseExamPaperId] == DBNull.Value ? null : objRow[concc_ExamPaperStuBatchRela.CourseExamPaperId].ToString().Trim(); //考卷流水号
objcc_ExamPaperStuBatchRelaEN.IdStudentInfo = objRow[concc_ExamPaperStuBatchRela.IdStudentInfo].ToString().Trim(); //学生流水号
objcc_ExamPaperStuBatchRelaEN.BatchTime = objRow[concc_ExamPaperStuBatchRela.BatchTime] == DBNull.Value ? null : objRow[concc_ExamPaperStuBatchRela.BatchTime].ToString().Trim(); //批次
objcc_ExamPaperStuBatchRelaEN.IdCurrEduCls = objRow[concc_ExamPaperStuBatchRela.IdCurrEduCls].ToString().Trim(); //教学班流水号
objcc_ExamPaperStuBatchRelaEN.Scores = objRow[concc_ExamPaperStuBatchRela.Scores] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[concc_ExamPaperStuBatchRela.Scores].ToString().Trim()); //分值
objcc_ExamPaperStuBatchRelaEN.IsSave = clsEntityBase2.TransNullToBool_S(objRow[concc_ExamPaperStuBatchRela.IsSave].ToString().Trim()); //是否保存
objcc_ExamPaperStuBatchRelaEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[concc_ExamPaperStuBatchRela.IsSubmit].ToString().Trim()); //是否提交
objcc_ExamPaperStuBatchRelaEN.RealFinishDate = objRow[concc_ExamPaperStuBatchRela.RealFinishDate] == DBNull.Value ? null : objRow[concc_ExamPaperStuBatchRela.RealFinishDate].ToString().Trim(); //实际完成日期
objcc_ExamPaperStuBatchRelaEN.OperateTime = objRow[concc_ExamPaperStuBatchRela.OperateTime] == DBNull.Value ? null : objRow[concc_ExamPaperStuBatchRela.OperateTime].ToString().Trim(); //操作时间
objcc_ExamPaperStuBatchRelaEN.IsMarking = clsEntityBase2.TransNullToBool_S(objRow[concc_ExamPaperStuBatchRela.IsMarking].ToString().Trim()); //是否批阅
objcc_ExamPaperStuBatchRelaEN.MarkerId = objRow[concc_ExamPaperStuBatchRela.MarkerId] == DBNull.Value ? null : objRow[concc_ExamPaperStuBatchRela.MarkerId].ToString().Trim(); //打分者
objcc_ExamPaperStuBatchRelaEN.MarkDate = objRow[concc_ExamPaperStuBatchRela.MarkDate] == DBNull.Value ? null : objRow[concc_ExamPaperStuBatchRela.MarkDate].ToString().Trim(); //打分日期
objcc_ExamPaperStuBatchRelaEN.AnswerIP = objRow[concc_ExamPaperStuBatchRela.AnswerIP] == DBNull.Value ? null : objRow[concc_ExamPaperStuBatchRela.AnswerIP].ToString().Trim(); //回答IP
objcc_ExamPaperStuBatchRelaEN.AnswerDate = objRow[concc_ExamPaperStuBatchRela.AnswerDate] == DBNull.Value ? null : objRow[concc_ExamPaperStuBatchRela.AnswerDate].ToString().Trim(); //回答日期
objcc_ExamPaperStuBatchRelaEN.AnswerTime = objRow[concc_ExamPaperStuBatchRela.AnswerTime] == DBNull.Value ? null : objRow[concc_ExamPaperStuBatchRela.AnswerTime].ToString().Trim(); //回答时间
objcc_ExamPaperStuBatchRelaEN.TotalGetScore = objRow[concc_ExamPaperStuBatchRela.TotalGetScore] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[concc_ExamPaperStuBatchRela.TotalGetScore].ToString().Trim()); //考生获取总分
objcc_ExamPaperStuBatchRelaEN.UpdDate = objRow[concc_ExamPaperStuBatchRela.UpdDate].ToString().Trim(); //修改日期
objcc_ExamPaperStuBatchRelaEN.UpdUserId = objRow[concc_ExamPaperStuBatchRela.UpdUserId] == DBNull.Value ? null : objRow[concc_ExamPaperStuBatchRela.UpdUserId].ToString().Trim(); //修改用户Id
objcc_ExamPaperStuBatchRelaEN.Memo = objRow[concc_ExamPaperStuBatchRela.Memo] == DBNull.Value ? null : objRow[concc_ExamPaperStuBatchRela.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objcc_ExamPaperStuBatchRelaEN.IdPaperStuBatch, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objcc_ExamPaperStuBatchRelaEN);
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
public static List<clscc_ExamPaperStuBatchRelaEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clscc_ExamPaperStuBatchRelaEN> arrObjLst = new List<clscc_ExamPaperStuBatchRelaEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clscc_ExamPaperStuBatchRelaEN objcc_ExamPaperStuBatchRelaEN = new clscc_ExamPaperStuBatchRelaEN();
try
{
objcc_ExamPaperStuBatchRelaEN.IdPaperStuBatch = objRow[concc_ExamPaperStuBatchRela.IdPaperStuBatch].ToString().Trim(); //学生试卷批次流水号
objcc_ExamPaperStuBatchRelaEN.CourseExamPaperId = objRow[concc_ExamPaperStuBatchRela.CourseExamPaperId] == DBNull.Value ? null : objRow[concc_ExamPaperStuBatchRela.CourseExamPaperId].ToString().Trim(); //考卷流水号
objcc_ExamPaperStuBatchRelaEN.IdStudentInfo = objRow[concc_ExamPaperStuBatchRela.IdStudentInfo].ToString().Trim(); //学生流水号
objcc_ExamPaperStuBatchRelaEN.BatchTime = objRow[concc_ExamPaperStuBatchRela.BatchTime] == DBNull.Value ? null : objRow[concc_ExamPaperStuBatchRela.BatchTime].ToString().Trim(); //批次
objcc_ExamPaperStuBatchRelaEN.IdCurrEduCls = objRow[concc_ExamPaperStuBatchRela.IdCurrEduCls].ToString().Trim(); //教学班流水号
objcc_ExamPaperStuBatchRelaEN.Scores = objRow[concc_ExamPaperStuBatchRela.Scores] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[concc_ExamPaperStuBatchRela.Scores].ToString().Trim()); //分值
objcc_ExamPaperStuBatchRelaEN.IsSave = clsEntityBase2.TransNullToBool_S(objRow[concc_ExamPaperStuBatchRela.IsSave].ToString().Trim()); //是否保存
objcc_ExamPaperStuBatchRelaEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[concc_ExamPaperStuBatchRela.IsSubmit].ToString().Trim()); //是否提交
objcc_ExamPaperStuBatchRelaEN.RealFinishDate = objRow[concc_ExamPaperStuBatchRela.RealFinishDate] == DBNull.Value ? null : objRow[concc_ExamPaperStuBatchRela.RealFinishDate].ToString().Trim(); //实际完成日期
objcc_ExamPaperStuBatchRelaEN.OperateTime = objRow[concc_ExamPaperStuBatchRela.OperateTime] == DBNull.Value ? null : objRow[concc_ExamPaperStuBatchRela.OperateTime].ToString().Trim(); //操作时间
objcc_ExamPaperStuBatchRelaEN.IsMarking = clsEntityBase2.TransNullToBool_S(objRow[concc_ExamPaperStuBatchRela.IsMarking].ToString().Trim()); //是否批阅
objcc_ExamPaperStuBatchRelaEN.MarkerId = objRow[concc_ExamPaperStuBatchRela.MarkerId] == DBNull.Value ? null : objRow[concc_ExamPaperStuBatchRela.MarkerId].ToString().Trim(); //打分者
objcc_ExamPaperStuBatchRelaEN.MarkDate = objRow[concc_ExamPaperStuBatchRela.MarkDate] == DBNull.Value ? null : objRow[concc_ExamPaperStuBatchRela.MarkDate].ToString().Trim(); //打分日期
objcc_ExamPaperStuBatchRelaEN.AnswerIP = objRow[concc_ExamPaperStuBatchRela.AnswerIP] == DBNull.Value ? null : objRow[concc_ExamPaperStuBatchRela.AnswerIP].ToString().Trim(); //回答IP
objcc_ExamPaperStuBatchRelaEN.AnswerDate = objRow[concc_ExamPaperStuBatchRela.AnswerDate] == DBNull.Value ? null : objRow[concc_ExamPaperStuBatchRela.AnswerDate].ToString().Trim(); //回答日期
objcc_ExamPaperStuBatchRelaEN.AnswerTime = objRow[concc_ExamPaperStuBatchRela.AnswerTime] == DBNull.Value ? null : objRow[concc_ExamPaperStuBatchRela.AnswerTime].ToString().Trim(); //回答时间
objcc_ExamPaperStuBatchRelaEN.TotalGetScore = objRow[concc_ExamPaperStuBatchRela.TotalGetScore] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[concc_ExamPaperStuBatchRela.TotalGetScore].ToString().Trim()); //考生获取总分
objcc_ExamPaperStuBatchRelaEN.UpdDate = objRow[concc_ExamPaperStuBatchRela.UpdDate].ToString().Trim(); //修改日期
objcc_ExamPaperStuBatchRelaEN.UpdUserId = objRow[concc_ExamPaperStuBatchRela.UpdUserId] == DBNull.Value ? null : objRow[concc_ExamPaperStuBatchRela.UpdUserId].ToString().Trim(); //修改用户Id
objcc_ExamPaperStuBatchRelaEN.Memo = objRow[concc_ExamPaperStuBatchRela.Memo] == DBNull.Value ? null : objRow[concc_ExamPaperStuBatchRela.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objcc_ExamPaperStuBatchRelaEN.IdPaperStuBatch, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objcc_ExamPaperStuBatchRelaEN);
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
List<clscc_ExamPaperStuBatchRelaEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clscc_ExamPaperStuBatchRelaEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clscc_ExamPaperStuBatchRelaEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clscc_ExamPaperStuBatchRelaEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clscc_ExamPaperStuBatchRelaEN> arrObjLst = new List<clscc_ExamPaperStuBatchRelaEN>(); 
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
	clscc_ExamPaperStuBatchRelaEN objcc_ExamPaperStuBatchRelaEN = new clscc_ExamPaperStuBatchRelaEN();
try
{
objcc_ExamPaperStuBatchRelaEN.IdPaperStuBatch = objRow[concc_ExamPaperStuBatchRela.IdPaperStuBatch].ToString().Trim(); //学生试卷批次流水号
objcc_ExamPaperStuBatchRelaEN.CourseExamPaperId = objRow[concc_ExamPaperStuBatchRela.CourseExamPaperId] == DBNull.Value ? null : objRow[concc_ExamPaperStuBatchRela.CourseExamPaperId].ToString().Trim(); //考卷流水号
objcc_ExamPaperStuBatchRelaEN.IdStudentInfo = objRow[concc_ExamPaperStuBatchRela.IdStudentInfo].ToString().Trim(); //学生流水号
objcc_ExamPaperStuBatchRelaEN.BatchTime = objRow[concc_ExamPaperStuBatchRela.BatchTime] == DBNull.Value ? null : objRow[concc_ExamPaperStuBatchRela.BatchTime].ToString().Trim(); //批次
objcc_ExamPaperStuBatchRelaEN.IdCurrEduCls = objRow[concc_ExamPaperStuBatchRela.IdCurrEduCls].ToString().Trim(); //教学班流水号
objcc_ExamPaperStuBatchRelaEN.Scores = objRow[concc_ExamPaperStuBatchRela.Scores] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[concc_ExamPaperStuBatchRela.Scores].ToString().Trim()); //分值
objcc_ExamPaperStuBatchRelaEN.IsSave = clsEntityBase2.TransNullToBool_S(objRow[concc_ExamPaperStuBatchRela.IsSave].ToString().Trim()); //是否保存
objcc_ExamPaperStuBatchRelaEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[concc_ExamPaperStuBatchRela.IsSubmit].ToString().Trim()); //是否提交
objcc_ExamPaperStuBatchRelaEN.RealFinishDate = objRow[concc_ExamPaperStuBatchRela.RealFinishDate] == DBNull.Value ? null : objRow[concc_ExamPaperStuBatchRela.RealFinishDate].ToString().Trim(); //实际完成日期
objcc_ExamPaperStuBatchRelaEN.OperateTime = objRow[concc_ExamPaperStuBatchRela.OperateTime] == DBNull.Value ? null : objRow[concc_ExamPaperStuBatchRela.OperateTime].ToString().Trim(); //操作时间
objcc_ExamPaperStuBatchRelaEN.IsMarking = clsEntityBase2.TransNullToBool_S(objRow[concc_ExamPaperStuBatchRela.IsMarking].ToString().Trim()); //是否批阅
objcc_ExamPaperStuBatchRelaEN.MarkerId = objRow[concc_ExamPaperStuBatchRela.MarkerId] == DBNull.Value ? null : objRow[concc_ExamPaperStuBatchRela.MarkerId].ToString().Trim(); //打分者
objcc_ExamPaperStuBatchRelaEN.MarkDate = objRow[concc_ExamPaperStuBatchRela.MarkDate] == DBNull.Value ? null : objRow[concc_ExamPaperStuBatchRela.MarkDate].ToString().Trim(); //打分日期
objcc_ExamPaperStuBatchRelaEN.AnswerIP = objRow[concc_ExamPaperStuBatchRela.AnswerIP] == DBNull.Value ? null : objRow[concc_ExamPaperStuBatchRela.AnswerIP].ToString().Trim(); //回答IP
objcc_ExamPaperStuBatchRelaEN.AnswerDate = objRow[concc_ExamPaperStuBatchRela.AnswerDate] == DBNull.Value ? null : objRow[concc_ExamPaperStuBatchRela.AnswerDate].ToString().Trim(); //回答日期
objcc_ExamPaperStuBatchRelaEN.AnswerTime = objRow[concc_ExamPaperStuBatchRela.AnswerTime] == DBNull.Value ? null : objRow[concc_ExamPaperStuBatchRela.AnswerTime].ToString().Trim(); //回答时间
objcc_ExamPaperStuBatchRelaEN.TotalGetScore = objRow[concc_ExamPaperStuBatchRela.TotalGetScore] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[concc_ExamPaperStuBatchRela.TotalGetScore].ToString().Trim()); //考生获取总分
objcc_ExamPaperStuBatchRelaEN.UpdDate = objRow[concc_ExamPaperStuBatchRela.UpdDate].ToString().Trim(); //修改日期
objcc_ExamPaperStuBatchRelaEN.UpdUserId = objRow[concc_ExamPaperStuBatchRela.UpdUserId] == DBNull.Value ? null : objRow[concc_ExamPaperStuBatchRela.UpdUserId].ToString().Trim(); //修改用户Id
objcc_ExamPaperStuBatchRelaEN.Memo = objRow[concc_ExamPaperStuBatchRela.Memo] == DBNull.Value ? null : objRow[concc_ExamPaperStuBatchRela.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objcc_ExamPaperStuBatchRelaEN.IdPaperStuBatch, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objcc_ExamPaperStuBatchRelaEN);
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
public static List<clscc_ExamPaperStuBatchRelaEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clscc_ExamPaperStuBatchRelaEN> arrObjLst = new List<clscc_ExamPaperStuBatchRelaEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clscc_ExamPaperStuBatchRelaEN objcc_ExamPaperStuBatchRelaEN = new clscc_ExamPaperStuBatchRelaEN();
try
{
objcc_ExamPaperStuBatchRelaEN.IdPaperStuBatch = objRow[concc_ExamPaperStuBatchRela.IdPaperStuBatch].ToString().Trim(); //学生试卷批次流水号
objcc_ExamPaperStuBatchRelaEN.CourseExamPaperId = objRow[concc_ExamPaperStuBatchRela.CourseExamPaperId] == DBNull.Value ? null : objRow[concc_ExamPaperStuBatchRela.CourseExamPaperId].ToString().Trim(); //考卷流水号
objcc_ExamPaperStuBatchRelaEN.IdStudentInfo = objRow[concc_ExamPaperStuBatchRela.IdStudentInfo].ToString().Trim(); //学生流水号
objcc_ExamPaperStuBatchRelaEN.BatchTime = objRow[concc_ExamPaperStuBatchRela.BatchTime] == DBNull.Value ? null : objRow[concc_ExamPaperStuBatchRela.BatchTime].ToString().Trim(); //批次
objcc_ExamPaperStuBatchRelaEN.IdCurrEduCls = objRow[concc_ExamPaperStuBatchRela.IdCurrEduCls].ToString().Trim(); //教学班流水号
objcc_ExamPaperStuBatchRelaEN.Scores = objRow[concc_ExamPaperStuBatchRela.Scores] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[concc_ExamPaperStuBatchRela.Scores].ToString().Trim()); //分值
objcc_ExamPaperStuBatchRelaEN.IsSave = clsEntityBase2.TransNullToBool_S(objRow[concc_ExamPaperStuBatchRela.IsSave].ToString().Trim()); //是否保存
objcc_ExamPaperStuBatchRelaEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[concc_ExamPaperStuBatchRela.IsSubmit].ToString().Trim()); //是否提交
objcc_ExamPaperStuBatchRelaEN.RealFinishDate = objRow[concc_ExamPaperStuBatchRela.RealFinishDate] == DBNull.Value ? null : objRow[concc_ExamPaperStuBatchRela.RealFinishDate].ToString().Trim(); //实际完成日期
objcc_ExamPaperStuBatchRelaEN.OperateTime = objRow[concc_ExamPaperStuBatchRela.OperateTime] == DBNull.Value ? null : objRow[concc_ExamPaperStuBatchRela.OperateTime].ToString().Trim(); //操作时间
objcc_ExamPaperStuBatchRelaEN.IsMarking = clsEntityBase2.TransNullToBool_S(objRow[concc_ExamPaperStuBatchRela.IsMarking].ToString().Trim()); //是否批阅
objcc_ExamPaperStuBatchRelaEN.MarkerId = objRow[concc_ExamPaperStuBatchRela.MarkerId] == DBNull.Value ? null : objRow[concc_ExamPaperStuBatchRela.MarkerId].ToString().Trim(); //打分者
objcc_ExamPaperStuBatchRelaEN.MarkDate = objRow[concc_ExamPaperStuBatchRela.MarkDate] == DBNull.Value ? null : objRow[concc_ExamPaperStuBatchRela.MarkDate].ToString().Trim(); //打分日期
objcc_ExamPaperStuBatchRelaEN.AnswerIP = objRow[concc_ExamPaperStuBatchRela.AnswerIP] == DBNull.Value ? null : objRow[concc_ExamPaperStuBatchRela.AnswerIP].ToString().Trim(); //回答IP
objcc_ExamPaperStuBatchRelaEN.AnswerDate = objRow[concc_ExamPaperStuBatchRela.AnswerDate] == DBNull.Value ? null : objRow[concc_ExamPaperStuBatchRela.AnswerDate].ToString().Trim(); //回答日期
objcc_ExamPaperStuBatchRelaEN.AnswerTime = objRow[concc_ExamPaperStuBatchRela.AnswerTime] == DBNull.Value ? null : objRow[concc_ExamPaperStuBatchRela.AnswerTime].ToString().Trim(); //回答时间
objcc_ExamPaperStuBatchRelaEN.TotalGetScore = objRow[concc_ExamPaperStuBatchRela.TotalGetScore] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[concc_ExamPaperStuBatchRela.TotalGetScore].ToString().Trim()); //考生获取总分
objcc_ExamPaperStuBatchRelaEN.UpdDate = objRow[concc_ExamPaperStuBatchRela.UpdDate].ToString().Trim(); //修改日期
objcc_ExamPaperStuBatchRelaEN.UpdUserId = objRow[concc_ExamPaperStuBatchRela.UpdUserId] == DBNull.Value ? null : objRow[concc_ExamPaperStuBatchRela.UpdUserId].ToString().Trim(); //修改用户Id
objcc_ExamPaperStuBatchRelaEN.Memo = objRow[concc_ExamPaperStuBatchRela.Memo] == DBNull.Value ? null : objRow[concc_ExamPaperStuBatchRela.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objcc_ExamPaperStuBatchRelaEN.IdPaperStuBatch, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objcc_ExamPaperStuBatchRelaEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clscc_ExamPaperStuBatchRelaEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clscc_ExamPaperStuBatchRelaEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clscc_ExamPaperStuBatchRelaEN> arrObjLst = new List<clscc_ExamPaperStuBatchRelaEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clscc_ExamPaperStuBatchRelaEN objcc_ExamPaperStuBatchRelaEN = new clscc_ExamPaperStuBatchRelaEN();
try
{
objcc_ExamPaperStuBatchRelaEN.IdPaperStuBatch = objRow[concc_ExamPaperStuBatchRela.IdPaperStuBatch].ToString().Trim(); //学生试卷批次流水号
objcc_ExamPaperStuBatchRelaEN.CourseExamPaperId = objRow[concc_ExamPaperStuBatchRela.CourseExamPaperId] == DBNull.Value ? null : objRow[concc_ExamPaperStuBatchRela.CourseExamPaperId].ToString().Trim(); //考卷流水号
objcc_ExamPaperStuBatchRelaEN.IdStudentInfo = objRow[concc_ExamPaperStuBatchRela.IdStudentInfo].ToString().Trim(); //学生流水号
objcc_ExamPaperStuBatchRelaEN.BatchTime = objRow[concc_ExamPaperStuBatchRela.BatchTime] == DBNull.Value ? null : objRow[concc_ExamPaperStuBatchRela.BatchTime].ToString().Trim(); //批次
objcc_ExamPaperStuBatchRelaEN.IdCurrEduCls = objRow[concc_ExamPaperStuBatchRela.IdCurrEduCls].ToString().Trim(); //教学班流水号
objcc_ExamPaperStuBatchRelaEN.Scores = objRow[concc_ExamPaperStuBatchRela.Scores] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[concc_ExamPaperStuBatchRela.Scores].ToString().Trim()); //分值
objcc_ExamPaperStuBatchRelaEN.IsSave = clsEntityBase2.TransNullToBool_S(objRow[concc_ExamPaperStuBatchRela.IsSave].ToString().Trim()); //是否保存
objcc_ExamPaperStuBatchRelaEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[concc_ExamPaperStuBatchRela.IsSubmit].ToString().Trim()); //是否提交
objcc_ExamPaperStuBatchRelaEN.RealFinishDate = objRow[concc_ExamPaperStuBatchRela.RealFinishDate] == DBNull.Value ? null : objRow[concc_ExamPaperStuBatchRela.RealFinishDate].ToString().Trim(); //实际完成日期
objcc_ExamPaperStuBatchRelaEN.OperateTime = objRow[concc_ExamPaperStuBatchRela.OperateTime] == DBNull.Value ? null : objRow[concc_ExamPaperStuBatchRela.OperateTime].ToString().Trim(); //操作时间
objcc_ExamPaperStuBatchRelaEN.IsMarking = clsEntityBase2.TransNullToBool_S(objRow[concc_ExamPaperStuBatchRela.IsMarking].ToString().Trim()); //是否批阅
objcc_ExamPaperStuBatchRelaEN.MarkerId = objRow[concc_ExamPaperStuBatchRela.MarkerId] == DBNull.Value ? null : objRow[concc_ExamPaperStuBatchRela.MarkerId].ToString().Trim(); //打分者
objcc_ExamPaperStuBatchRelaEN.MarkDate = objRow[concc_ExamPaperStuBatchRela.MarkDate] == DBNull.Value ? null : objRow[concc_ExamPaperStuBatchRela.MarkDate].ToString().Trim(); //打分日期
objcc_ExamPaperStuBatchRelaEN.AnswerIP = objRow[concc_ExamPaperStuBatchRela.AnswerIP] == DBNull.Value ? null : objRow[concc_ExamPaperStuBatchRela.AnswerIP].ToString().Trim(); //回答IP
objcc_ExamPaperStuBatchRelaEN.AnswerDate = objRow[concc_ExamPaperStuBatchRela.AnswerDate] == DBNull.Value ? null : objRow[concc_ExamPaperStuBatchRela.AnswerDate].ToString().Trim(); //回答日期
objcc_ExamPaperStuBatchRelaEN.AnswerTime = objRow[concc_ExamPaperStuBatchRela.AnswerTime] == DBNull.Value ? null : objRow[concc_ExamPaperStuBatchRela.AnswerTime].ToString().Trim(); //回答时间
objcc_ExamPaperStuBatchRelaEN.TotalGetScore = objRow[concc_ExamPaperStuBatchRela.TotalGetScore] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[concc_ExamPaperStuBatchRela.TotalGetScore].ToString().Trim()); //考生获取总分
objcc_ExamPaperStuBatchRelaEN.UpdDate = objRow[concc_ExamPaperStuBatchRela.UpdDate].ToString().Trim(); //修改日期
objcc_ExamPaperStuBatchRelaEN.UpdUserId = objRow[concc_ExamPaperStuBatchRela.UpdUserId] == DBNull.Value ? null : objRow[concc_ExamPaperStuBatchRela.UpdUserId].ToString().Trim(); //修改用户Id
objcc_ExamPaperStuBatchRelaEN.Memo = objRow[concc_ExamPaperStuBatchRela.Memo] == DBNull.Value ? null : objRow[concc_ExamPaperStuBatchRela.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objcc_ExamPaperStuBatchRelaEN.IdPaperStuBatch, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objcc_ExamPaperStuBatchRelaEN);
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
public static List<clscc_ExamPaperStuBatchRelaEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clscc_ExamPaperStuBatchRelaEN> arrObjLst = new List<clscc_ExamPaperStuBatchRelaEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clscc_ExamPaperStuBatchRelaEN objcc_ExamPaperStuBatchRelaEN = new clscc_ExamPaperStuBatchRelaEN();
try
{
objcc_ExamPaperStuBatchRelaEN.IdPaperStuBatch = objRow[concc_ExamPaperStuBatchRela.IdPaperStuBatch].ToString().Trim(); //学生试卷批次流水号
objcc_ExamPaperStuBatchRelaEN.CourseExamPaperId = objRow[concc_ExamPaperStuBatchRela.CourseExamPaperId] == DBNull.Value ? null : objRow[concc_ExamPaperStuBatchRela.CourseExamPaperId].ToString().Trim(); //考卷流水号
objcc_ExamPaperStuBatchRelaEN.IdStudentInfo = objRow[concc_ExamPaperStuBatchRela.IdStudentInfo].ToString().Trim(); //学生流水号
objcc_ExamPaperStuBatchRelaEN.BatchTime = objRow[concc_ExamPaperStuBatchRela.BatchTime] == DBNull.Value ? null : objRow[concc_ExamPaperStuBatchRela.BatchTime].ToString().Trim(); //批次
objcc_ExamPaperStuBatchRelaEN.IdCurrEduCls = objRow[concc_ExamPaperStuBatchRela.IdCurrEduCls].ToString().Trim(); //教学班流水号
objcc_ExamPaperStuBatchRelaEN.Scores = objRow[concc_ExamPaperStuBatchRela.Scores] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[concc_ExamPaperStuBatchRela.Scores].ToString().Trim()); //分值
objcc_ExamPaperStuBatchRelaEN.IsSave = clsEntityBase2.TransNullToBool_S(objRow[concc_ExamPaperStuBatchRela.IsSave].ToString().Trim()); //是否保存
objcc_ExamPaperStuBatchRelaEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[concc_ExamPaperStuBatchRela.IsSubmit].ToString().Trim()); //是否提交
objcc_ExamPaperStuBatchRelaEN.RealFinishDate = objRow[concc_ExamPaperStuBatchRela.RealFinishDate] == DBNull.Value ? null : objRow[concc_ExamPaperStuBatchRela.RealFinishDate].ToString().Trim(); //实际完成日期
objcc_ExamPaperStuBatchRelaEN.OperateTime = objRow[concc_ExamPaperStuBatchRela.OperateTime] == DBNull.Value ? null : objRow[concc_ExamPaperStuBatchRela.OperateTime].ToString().Trim(); //操作时间
objcc_ExamPaperStuBatchRelaEN.IsMarking = clsEntityBase2.TransNullToBool_S(objRow[concc_ExamPaperStuBatchRela.IsMarking].ToString().Trim()); //是否批阅
objcc_ExamPaperStuBatchRelaEN.MarkerId = objRow[concc_ExamPaperStuBatchRela.MarkerId] == DBNull.Value ? null : objRow[concc_ExamPaperStuBatchRela.MarkerId].ToString().Trim(); //打分者
objcc_ExamPaperStuBatchRelaEN.MarkDate = objRow[concc_ExamPaperStuBatchRela.MarkDate] == DBNull.Value ? null : objRow[concc_ExamPaperStuBatchRela.MarkDate].ToString().Trim(); //打分日期
objcc_ExamPaperStuBatchRelaEN.AnswerIP = objRow[concc_ExamPaperStuBatchRela.AnswerIP] == DBNull.Value ? null : objRow[concc_ExamPaperStuBatchRela.AnswerIP].ToString().Trim(); //回答IP
objcc_ExamPaperStuBatchRelaEN.AnswerDate = objRow[concc_ExamPaperStuBatchRela.AnswerDate] == DBNull.Value ? null : objRow[concc_ExamPaperStuBatchRela.AnswerDate].ToString().Trim(); //回答日期
objcc_ExamPaperStuBatchRelaEN.AnswerTime = objRow[concc_ExamPaperStuBatchRela.AnswerTime] == DBNull.Value ? null : objRow[concc_ExamPaperStuBatchRela.AnswerTime].ToString().Trim(); //回答时间
objcc_ExamPaperStuBatchRelaEN.TotalGetScore = objRow[concc_ExamPaperStuBatchRela.TotalGetScore] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[concc_ExamPaperStuBatchRela.TotalGetScore].ToString().Trim()); //考生获取总分
objcc_ExamPaperStuBatchRelaEN.UpdDate = objRow[concc_ExamPaperStuBatchRela.UpdDate].ToString().Trim(); //修改日期
objcc_ExamPaperStuBatchRelaEN.UpdUserId = objRow[concc_ExamPaperStuBatchRela.UpdUserId] == DBNull.Value ? null : objRow[concc_ExamPaperStuBatchRela.UpdUserId].ToString().Trim(); //修改用户Id
objcc_ExamPaperStuBatchRelaEN.Memo = objRow[concc_ExamPaperStuBatchRela.Memo] == DBNull.Value ? null : objRow[concc_ExamPaperStuBatchRela.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objcc_ExamPaperStuBatchRelaEN.IdPaperStuBatch, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objcc_ExamPaperStuBatchRelaEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clscc_ExamPaperStuBatchRelaEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clscc_ExamPaperStuBatchRelaEN> arrObjLst = new List<clscc_ExamPaperStuBatchRelaEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clscc_ExamPaperStuBatchRelaEN objcc_ExamPaperStuBatchRelaEN = new clscc_ExamPaperStuBatchRelaEN();
try
{
objcc_ExamPaperStuBatchRelaEN.IdPaperStuBatch = objRow[concc_ExamPaperStuBatchRela.IdPaperStuBatch].ToString().Trim(); //学生试卷批次流水号
objcc_ExamPaperStuBatchRelaEN.CourseExamPaperId = objRow[concc_ExamPaperStuBatchRela.CourseExamPaperId] == DBNull.Value ? null : objRow[concc_ExamPaperStuBatchRela.CourseExamPaperId].ToString().Trim(); //考卷流水号
objcc_ExamPaperStuBatchRelaEN.IdStudentInfo = objRow[concc_ExamPaperStuBatchRela.IdStudentInfo].ToString().Trim(); //学生流水号
objcc_ExamPaperStuBatchRelaEN.BatchTime = objRow[concc_ExamPaperStuBatchRela.BatchTime] == DBNull.Value ? null : objRow[concc_ExamPaperStuBatchRela.BatchTime].ToString().Trim(); //批次
objcc_ExamPaperStuBatchRelaEN.IdCurrEduCls = objRow[concc_ExamPaperStuBatchRela.IdCurrEduCls].ToString().Trim(); //教学班流水号
objcc_ExamPaperStuBatchRelaEN.Scores = objRow[concc_ExamPaperStuBatchRela.Scores] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[concc_ExamPaperStuBatchRela.Scores].ToString().Trim()); //分值
objcc_ExamPaperStuBatchRelaEN.IsSave = clsEntityBase2.TransNullToBool_S(objRow[concc_ExamPaperStuBatchRela.IsSave].ToString().Trim()); //是否保存
objcc_ExamPaperStuBatchRelaEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[concc_ExamPaperStuBatchRela.IsSubmit].ToString().Trim()); //是否提交
objcc_ExamPaperStuBatchRelaEN.RealFinishDate = objRow[concc_ExamPaperStuBatchRela.RealFinishDate] == DBNull.Value ? null : objRow[concc_ExamPaperStuBatchRela.RealFinishDate].ToString().Trim(); //实际完成日期
objcc_ExamPaperStuBatchRelaEN.OperateTime = objRow[concc_ExamPaperStuBatchRela.OperateTime] == DBNull.Value ? null : objRow[concc_ExamPaperStuBatchRela.OperateTime].ToString().Trim(); //操作时间
objcc_ExamPaperStuBatchRelaEN.IsMarking = clsEntityBase2.TransNullToBool_S(objRow[concc_ExamPaperStuBatchRela.IsMarking].ToString().Trim()); //是否批阅
objcc_ExamPaperStuBatchRelaEN.MarkerId = objRow[concc_ExamPaperStuBatchRela.MarkerId] == DBNull.Value ? null : objRow[concc_ExamPaperStuBatchRela.MarkerId].ToString().Trim(); //打分者
objcc_ExamPaperStuBatchRelaEN.MarkDate = objRow[concc_ExamPaperStuBatchRela.MarkDate] == DBNull.Value ? null : objRow[concc_ExamPaperStuBatchRela.MarkDate].ToString().Trim(); //打分日期
objcc_ExamPaperStuBatchRelaEN.AnswerIP = objRow[concc_ExamPaperStuBatchRela.AnswerIP] == DBNull.Value ? null : objRow[concc_ExamPaperStuBatchRela.AnswerIP].ToString().Trim(); //回答IP
objcc_ExamPaperStuBatchRelaEN.AnswerDate = objRow[concc_ExamPaperStuBatchRela.AnswerDate] == DBNull.Value ? null : objRow[concc_ExamPaperStuBatchRela.AnswerDate].ToString().Trim(); //回答日期
objcc_ExamPaperStuBatchRelaEN.AnswerTime = objRow[concc_ExamPaperStuBatchRela.AnswerTime] == DBNull.Value ? null : objRow[concc_ExamPaperStuBatchRela.AnswerTime].ToString().Trim(); //回答时间
objcc_ExamPaperStuBatchRelaEN.TotalGetScore = objRow[concc_ExamPaperStuBatchRela.TotalGetScore] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[concc_ExamPaperStuBatchRela.TotalGetScore].ToString().Trim()); //考生获取总分
objcc_ExamPaperStuBatchRelaEN.UpdDate = objRow[concc_ExamPaperStuBatchRela.UpdDate].ToString().Trim(); //修改日期
objcc_ExamPaperStuBatchRelaEN.UpdUserId = objRow[concc_ExamPaperStuBatchRela.UpdUserId] == DBNull.Value ? null : objRow[concc_ExamPaperStuBatchRela.UpdUserId].ToString().Trim(); //修改用户Id
objcc_ExamPaperStuBatchRelaEN.Memo = objRow[concc_ExamPaperStuBatchRela.Memo] == DBNull.Value ? null : objRow[concc_ExamPaperStuBatchRela.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objcc_ExamPaperStuBatchRelaEN.IdPaperStuBatch, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objcc_ExamPaperStuBatchRelaEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objcc_ExamPaperStuBatchRelaEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool Getcc_ExamPaperStuBatchRela(ref clscc_ExamPaperStuBatchRelaEN objcc_ExamPaperStuBatchRelaEN)
{
bool bolResult = cc_ExamPaperStuBatchRelaDA.Getcc_ExamPaperStuBatchRela(ref objcc_ExamPaperStuBatchRelaEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "strIdPaperStuBatch">表关键字</param>
 /// <returns>表对象</returns>
public static clscc_ExamPaperStuBatchRelaEN GetObjByIdPaperStuBatch(string strIdPaperStuBatch)
{
if (strIdPaperStuBatch.IndexOf(' ') >=0)
{
var strMsg = string.Format("(errid:Busi000079)在表中,关键字[strIdPaperStuBatch]中不能有空格!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
if (string.IsNullOrEmpty(strIdPaperStuBatch) == true)
{
var strMsg = string.Format("(errid:Busi000020)在表中,关键字[strIdPaperStuBatch]不能为空!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
clscc_ExamPaperStuBatchRelaEN objcc_ExamPaperStuBatchRelaEN = cc_ExamPaperStuBatchRelaDA.GetObjByIdPaperStuBatch(strIdPaperStuBatch);
return objcc_ExamPaperStuBatchRelaEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clscc_ExamPaperStuBatchRelaEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clscc_ExamPaperStuBatchRelaEN objcc_ExamPaperStuBatchRelaEN = cc_ExamPaperStuBatchRelaDA.GetFirstObj(strWhereCond);
 return objcc_ExamPaperStuBatchRelaEN;
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
public static clscc_ExamPaperStuBatchRelaEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clscc_ExamPaperStuBatchRelaEN objcc_ExamPaperStuBatchRelaEN = cc_ExamPaperStuBatchRelaDA.GetObjByDataRow(objRow);
 return objcc_ExamPaperStuBatchRelaEN;
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
public static clscc_ExamPaperStuBatchRelaEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clscc_ExamPaperStuBatchRelaEN objcc_ExamPaperStuBatchRelaEN = cc_ExamPaperStuBatchRelaDA.GetObjByDataRow(objRow);
 return objcc_ExamPaperStuBatchRelaEN;
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
 /// <param name = "strIdPaperStuBatch">所给的关键字</param>
 /// <param name = "lstcc_ExamPaperStuBatchRelaObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clscc_ExamPaperStuBatchRelaEN GetObjByIdPaperStuBatchFromList(string strIdPaperStuBatch, List<clscc_ExamPaperStuBatchRelaEN> lstcc_ExamPaperStuBatchRelaObjLst)
{
foreach (clscc_ExamPaperStuBatchRelaEN objcc_ExamPaperStuBatchRelaEN in lstcc_ExamPaperStuBatchRelaObjLst)
{
if (objcc_ExamPaperStuBatchRelaEN.IdPaperStuBatch == strIdPaperStuBatch)
{
return objcc_ExamPaperStuBatchRelaEN;
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
 string strMaxIdPaperStuBatch;
 try
 {
 strMaxIdPaperStuBatch = clscc_ExamPaperStuBatchRelaDA.GetMaxStrId();
 return strMaxIdPaperStuBatch;
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
 string strIdPaperStuBatch;
 try
 {
 strIdPaperStuBatch = new clscc_ExamPaperStuBatchRelaDA().GetFirstID(strWhereCond);
 return strIdPaperStuBatch;
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
 arrList = cc_ExamPaperStuBatchRelaDA.GetID(strWhereCond);
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
bool bolIsExist = cc_ExamPaperStuBatchRelaDA.IsExistCondRec(strWhereCond);
return bolIsExist;
}

 /// <summary>
 /// 判断当前表中是否存在给定关键字值的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExist)
 /// </summary>
 /// <param name = "strIdPaperStuBatch">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public static bool IsExist(string strIdPaperStuBatch)
{
if (string.IsNullOrEmpty(strIdPaperStuBatch) == true)
{
var strMsg = string.Format("(errid:Busi000027)在表中,关键字[strIdPaperStuBatch]不能为空!!(from {0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
//检测记录是否存在
bool bolIsExist = cc_ExamPaperStuBatchRelaDA.IsExist(strIdPaperStuBatch);
return bolIsExist;
}

/// <summary>
/// 设置修改时间
/// </summary>
/// <param name = "strIdPaperStuBatch">学生试卷批次流水号</param>
/// <param name = "strOpUser">修改用户</param>
/// <returns>是否成功？</returns>
public static bool SetUpdDate(string strIdPaperStuBatch, string strOpUser)
{
clscc_ExamPaperStuBatchRelaEN objcc_ExamPaperStuBatchRelaEN = clscc_ExamPaperStuBatchRelaBL.GetObjByIdPaperStuBatch(strIdPaperStuBatch);
objcc_ExamPaperStuBatchRelaEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
objcc_ExamPaperStuBatchRelaEN.UpdUserId = strOpUser;
return clscc_ExamPaperStuBatchRelaBL.UpdateBySql2(objcc_ExamPaperStuBatchRelaEN);
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
 bolIsExist = clscc_ExamPaperStuBatchRelaDA.IsExistTable();
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
 bolIsExist = cc_ExamPaperStuBatchRelaDA.IsExistTable(strTabName);
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
 /// <param name = "objcc_ExamPaperStuBatchRelaEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecordBySql2(clscc_ExamPaperStuBatchRelaEN objcc_ExamPaperStuBatchRelaEN, bool bolIsNeedCheckUniqueness=true)
{
if (bolIsNeedCheckUniqueness == true && objcc_ExamPaperStuBatchRelaEN.CheckUniqueness() == false)
{
var strMsg = string.Format("记录已经存在!考卷流水号 = [{0}],学生流水号 = [{1}]的数据已经存在!(in clscc_ExamPaperStuBatchRelaBL.AddNewRecordBySql2)", objcc_ExamPaperStuBatchRelaEN.CourseExamPaperId,objcc_ExamPaperStuBatchRelaEN.IdStudentInfo);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objcc_ExamPaperStuBatchRelaEN.IdPaperStuBatch) == true || clscc_ExamPaperStuBatchRelaBL.IsExist(objcc_ExamPaperStuBatchRelaEN.IdPaperStuBatch) == true)
 {
     objcc_ExamPaperStuBatchRelaEN.IdPaperStuBatch = clscc_ExamPaperStuBatchRelaBL.GetMaxStrId_S();
 }
bool bolResult = cc_ExamPaperStuBatchRelaDA.AddNewRecordBySQL2(objcc_ExamPaperStuBatchRelaEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clscc_ExamPaperStuBatchRelaBL.ReFreshCache(objcc_ExamPaperStuBatchRelaEN.IdCurrEduCls);

if (clscc_ExamPaperStuBatchRelaBL.relatedActions != null)
{
clscc_ExamPaperStuBatchRelaBL.relatedActions.UpdRelaTabDate(objcc_ExamPaperStuBatchRelaEN.IdPaperStuBatch, objcc_ExamPaperStuBatchRelaEN.UpdUserId);
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
 /// <param name = "objcc_ExamPaperStuBatchRelaEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordBySql2WithReturnKey(clscc_ExamPaperStuBatchRelaEN objcc_ExamPaperStuBatchRelaEN, bool bolIsNeedCheckUniqueness=true)
{
if (bolIsNeedCheckUniqueness == true && objcc_ExamPaperStuBatchRelaEN.CheckUniqueness() == false)
{
var strMsg = string.Format("记录已经存在!考卷流水号 = [{0}],学生流水号 = [{1}]的数据已经存在!(in clscc_ExamPaperStuBatchRelaBL.AddNewRecordBySql2WithReturnKey)", objcc_ExamPaperStuBatchRelaEN.CourseExamPaperId,objcc_ExamPaperStuBatchRelaEN.IdStudentInfo);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objcc_ExamPaperStuBatchRelaEN.IdPaperStuBatch) == true || clscc_ExamPaperStuBatchRelaBL.IsExist(objcc_ExamPaperStuBatchRelaEN.IdPaperStuBatch) == true)
 {
     objcc_ExamPaperStuBatchRelaEN.IdPaperStuBatch = clscc_ExamPaperStuBatchRelaBL.GetMaxStrId_S();
 }
string strKey = cc_ExamPaperStuBatchRelaDA.AddNewRecordBySQL2WithReturnKey(objcc_ExamPaperStuBatchRelaEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clscc_ExamPaperStuBatchRelaBL.ReFreshCache(objcc_ExamPaperStuBatchRelaEN.IdCurrEduCls);

if (clscc_ExamPaperStuBatchRelaBL.relatedActions != null)
{
clscc_ExamPaperStuBatchRelaBL.relatedActions.UpdRelaTabDate(objcc_ExamPaperStuBatchRelaEN.IdPaperStuBatch, objcc_ExamPaperStuBatchRelaEN.UpdUserId);
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
 /// <param name = "objcc_ExamPaperStuBatchRelaEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(clscc_ExamPaperStuBatchRelaEN objcc_ExamPaperStuBatchRelaEN)
{
try
{
bool bolResult = cc_ExamPaperStuBatchRelaDA.Update(objcc_ExamPaperStuBatchRelaEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clscc_ExamPaperStuBatchRelaBL.ReFreshCache(objcc_ExamPaperStuBatchRelaEN.IdCurrEduCls);

if (clscc_ExamPaperStuBatchRelaBL.relatedActions != null)
{
clscc_ExamPaperStuBatchRelaBL.relatedActions.UpdRelaTabDate(objcc_ExamPaperStuBatchRelaEN.IdPaperStuBatch, objcc_ExamPaperStuBatchRelaEN.UpdUserId);
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
 /// <param name = "objcc_ExamPaperStuBatchRelaEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateBySql2(clscc_ExamPaperStuBatchRelaEN objcc_ExamPaperStuBatchRelaEN)
{
 if (string.IsNullOrEmpty(objcc_ExamPaperStuBatchRelaEN.IdPaperStuBatch) == true)
 {
var strMsg = string.Format("(errid:Busi000065)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = cc_ExamPaperStuBatchRelaDA.UpdateBySql2(objcc_ExamPaperStuBatchRelaEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clscc_ExamPaperStuBatchRelaBL.ReFreshCache(objcc_ExamPaperStuBatchRelaEN.IdCurrEduCls);

if (clscc_ExamPaperStuBatchRelaBL.relatedActions != null)
{
clscc_ExamPaperStuBatchRelaBL.relatedActions.UpdRelaTabDate(objcc_ExamPaperStuBatchRelaEN.IdPaperStuBatch, objcc_ExamPaperStuBatchRelaEN.UpdUserId);
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
 /// <param name = "strIdPaperStuBatch">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int DelRecord(string strIdPaperStuBatch)
{
try
{
 clscc_ExamPaperStuBatchRelaEN objcc_ExamPaperStuBatchRelaEN = clscc_ExamPaperStuBatchRelaBL.GetObjByIdPaperStuBatch(strIdPaperStuBatch);

if (clscc_ExamPaperStuBatchRelaBL.relatedActions != null)
{
clscc_ExamPaperStuBatchRelaBL.relatedActions.UpdRelaTabDate(objcc_ExamPaperStuBatchRelaEN.IdPaperStuBatch, objcc_ExamPaperStuBatchRelaEN.UpdUserId);
}
if (objcc_ExamPaperStuBatchRelaEN != null)
{
int intRecNum = cc_ExamPaperStuBatchRelaDA.DelRecord(strIdPaperStuBatch);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
ReFreshCache(objcc_ExamPaperStuBatchRelaEN.IdCurrEduCls);
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
/// <param name="strIdPaperStuBatch">表关键字</param>
 /// <param name = "strIdCurrEduCls">缓存的分类字段</param>
/// <returns></returns>
public static bool DelRecordEx(string strIdPaperStuBatch , string strIdCurrEduCls)
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clscc_ExamPaperStuBatchRelaDA.GetSpecSQLObj();
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
//删除与表:[cc_ExamPaperStuBatchRela]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//concc_ExamPaperStuBatchRela.IdPaperStuBatch,
//strIdPaperStuBatch);
//        clscc_ExamPaperStuBatchRelaBL.Delcc_ExamPaperStuBatchRelasByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clscc_ExamPaperStuBatchRelaBL.DelRecord(strIdPaperStuBatch, strIdCurrEduCls, objConnection, objSqlTransaction);
objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clscc_ExamPaperStuBatchRelaBLEx", "DelRecordEx", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("扩展删除记录出错:{0}!keyId = {1}.({2})",
objException.Message,
strIdPaperStuBatch, clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "strIdPaperStuBatch">给定的关键字值</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回删除是否成功?</returns>
public static bool DelRecord(string strIdPaperStuBatch, string strIdCurrEduCls, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
if (clscc_ExamPaperStuBatchRelaBL.relatedActions != null)
{
clscc_ExamPaperStuBatchRelaBL.relatedActions.UpdRelaTabDate(strIdPaperStuBatch, "UpdRelaTabDate");
}
bool bolResult = cc_ExamPaperStuBatchRelaDA.DelRecord(strIdPaperStuBatch,objSqlConnection,objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
ReFreshCache(strIdCurrEduCls);
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
 /// <param name = "arrIdPaperStuBatchLst">给定的关键字值列表</param>
 /// <returns>返回删除的记录数</returns>
public static int Delcc_ExamPaperStuBatchRelas(List<string> arrIdPaperStuBatchLst)
{
if (arrIdPaperStuBatchLst.Count == 0) return 0;
try
{
if (clscc_ExamPaperStuBatchRelaBL.relatedActions != null)
{
foreach (var strIdPaperStuBatch in arrIdPaperStuBatchLst)
{
clscc_ExamPaperStuBatchRelaBL.relatedActions.UpdRelaTabDate(strIdPaperStuBatch, "UpdRelaTabDate");
}
}
 clscc_ExamPaperStuBatchRelaEN objcc_ExamPaperStuBatchRelaEN = clscc_ExamPaperStuBatchRelaBL.GetObjByIdPaperStuBatch(arrIdPaperStuBatchLst[0]);
int intDelRecNum = cc_ExamPaperStuBatchRelaDA.Delcc_ExamPaperStuBatchRela(arrIdPaperStuBatchLst);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
ReFreshCache(objcc_ExamPaperStuBatchRelaEN.IdCurrEduCls);
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
public static int Delcc_ExamPaperStuBatchRelasByCond(string strWhereCond)
{
try
{
if (clscc_ExamPaperStuBatchRelaBL.relatedActions != null)
{
List<string> arrIdPaperStuBatch = GetPrimaryKeyID_S(strWhereCond);
foreach (var strIdPaperStuBatch in arrIdPaperStuBatch)
{
clscc_ExamPaperStuBatchRelaBL.relatedActions.UpdRelaTabDate(strIdPaperStuBatch, "UpdRelaTabDate");
}
}
List<string> arrIdCurrEduCls = GetFldValue(concc_ExamPaperStuBatchRela.IdCurrEduCls, strWhereCond);
int intRecNum = cc_ExamPaperStuBatchRelaDA.Delcc_ExamPaperStuBatchRela(strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
arrIdCurrEduCls.ForEach(x => ReFreshCache(x));
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
/// 这里仅仅是演示函数,使用时请复制到扩展类:[cc_ExamPaperStuBatchRela]中改名为:[DelRecord4MultiTabEx]使用
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DelRecord4MultiTab)
/// </summary>
/// <param name="strIdPaperStuBatch">表关键字</param>
 /// <param name = "strIdCurrEduCls">缓存的分类字段</param>
/// <returns></returns>
public static bool DelRecord4MultiTab(string strIdPaperStuBatch, string strIdCurrEduCls)
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clscc_ExamPaperStuBatchRelaDA.GetSpecSQLObj();
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
//删除与表:[cc_ExamPaperStuBatchRela]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conStudent.id_College,
//strid_College);
//        clsStudentBL.DelStudentsByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clscc_ExamPaperStuBatchRelaBL.DelRecord(strIdPaperStuBatch, strIdCurrEduCls, objConnection, objSqlTransaction);
                objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clscc_ExamPaperStuBatchRelaBL", "DelRecord4MultiTab", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("删除多表记录出错:{0}!keyId = {1}.({2})",
objException.Message,
strIdPaperStuBatch, clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "objcc_ExamPaperStuBatchRelaENS">源对象</param>
 /// <param name = "objcc_ExamPaperStuBatchRelaENT">目标对象</param>
 public static void CopyTo(clscc_ExamPaperStuBatchRelaEN objcc_ExamPaperStuBatchRelaENS, clscc_ExamPaperStuBatchRelaEN objcc_ExamPaperStuBatchRelaENT)
{
try
{
objcc_ExamPaperStuBatchRelaENT.IdPaperStuBatch = objcc_ExamPaperStuBatchRelaENS.IdPaperStuBatch; //学生试卷批次流水号
objcc_ExamPaperStuBatchRelaENT.CourseExamPaperId = objcc_ExamPaperStuBatchRelaENS.CourseExamPaperId; //考卷流水号
objcc_ExamPaperStuBatchRelaENT.IdStudentInfo = objcc_ExamPaperStuBatchRelaENS.IdStudentInfo; //学生流水号
objcc_ExamPaperStuBatchRelaENT.BatchTime = objcc_ExamPaperStuBatchRelaENS.BatchTime; //批次
objcc_ExamPaperStuBatchRelaENT.IdCurrEduCls = objcc_ExamPaperStuBatchRelaENS.IdCurrEduCls; //教学班流水号
objcc_ExamPaperStuBatchRelaENT.Scores = objcc_ExamPaperStuBatchRelaENS.Scores; //分值
objcc_ExamPaperStuBatchRelaENT.IsSave = objcc_ExamPaperStuBatchRelaENS.IsSave; //是否保存
objcc_ExamPaperStuBatchRelaENT.IsSubmit = objcc_ExamPaperStuBatchRelaENS.IsSubmit; //是否提交
objcc_ExamPaperStuBatchRelaENT.RealFinishDate = objcc_ExamPaperStuBatchRelaENS.RealFinishDate; //实际完成日期
objcc_ExamPaperStuBatchRelaENT.OperateTime = objcc_ExamPaperStuBatchRelaENS.OperateTime; //操作时间
objcc_ExamPaperStuBatchRelaENT.IsMarking = objcc_ExamPaperStuBatchRelaENS.IsMarking; //是否批阅
objcc_ExamPaperStuBatchRelaENT.MarkerId = objcc_ExamPaperStuBatchRelaENS.MarkerId; //打分者
objcc_ExamPaperStuBatchRelaENT.MarkDate = objcc_ExamPaperStuBatchRelaENS.MarkDate; //打分日期
objcc_ExamPaperStuBatchRelaENT.AnswerIP = objcc_ExamPaperStuBatchRelaENS.AnswerIP; //回答IP
objcc_ExamPaperStuBatchRelaENT.AnswerDate = objcc_ExamPaperStuBatchRelaENS.AnswerDate; //回答日期
objcc_ExamPaperStuBatchRelaENT.AnswerTime = objcc_ExamPaperStuBatchRelaENS.AnswerTime; //回答时间
objcc_ExamPaperStuBatchRelaENT.TotalGetScore = objcc_ExamPaperStuBatchRelaENS.TotalGetScore; //考生获取总分
objcc_ExamPaperStuBatchRelaENT.UpdDate = objcc_ExamPaperStuBatchRelaENS.UpdDate; //修改日期
objcc_ExamPaperStuBatchRelaENT.UpdUserId = objcc_ExamPaperStuBatchRelaENS.UpdUserId; //修改用户Id
objcc_ExamPaperStuBatchRelaENT.Memo = objcc_ExamPaperStuBatchRelaENS.Memo; //备注
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
 /// <param name = "objcc_ExamPaperStuBatchRelaEN">源简化对象</param>
 public static void SetUpdFlag(clscc_ExamPaperStuBatchRelaEN objcc_ExamPaperStuBatchRelaEN)
{
try
{
objcc_ExamPaperStuBatchRelaEN.ClearUpdateState();
   string strsfUpdFldSetStr = objcc_ExamPaperStuBatchRelaEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(concc_ExamPaperStuBatchRela.IdPaperStuBatch, new clsStrCompareIgnoreCase())  ==  true)
{
objcc_ExamPaperStuBatchRelaEN.IdPaperStuBatch = objcc_ExamPaperStuBatchRelaEN.IdPaperStuBatch; //学生试卷批次流水号
}
if (arrFldSet.Contains(concc_ExamPaperStuBatchRela.CourseExamPaperId, new clsStrCompareIgnoreCase())  ==  true)
{
objcc_ExamPaperStuBatchRelaEN.CourseExamPaperId = objcc_ExamPaperStuBatchRelaEN.CourseExamPaperId == "[null]" ? null :  objcc_ExamPaperStuBatchRelaEN.CourseExamPaperId; //考卷流水号
}
if (arrFldSet.Contains(concc_ExamPaperStuBatchRela.IdStudentInfo, new clsStrCompareIgnoreCase())  ==  true)
{
objcc_ExamPaperStuBatchRelaEN.IdStudentInfo = objcc_ExamPaperStuBatchRelaEN.IdStudentInfo; //学生流水号
}
if (arrFldSet.Contains(concc_ExamPaperStuBatchRela.BatchTime, new clsStrCompareIgnoreCase())  ==  true)
{
objcc_ExamPaperStuBatchRelaEN.BatchTime = objcc_ExamPaperStuBatchRelaEN.BatchTime == "[null]" ? null :  objcc_ExamPaperStuBatchRelaEN.BatchTime; //批次
}
if (arrFldSet.Contains(concc_ExamPaperStuBatchRela.IdCurrEduCls, new clsStrCompareIgnoreCase())  ==  true)
{
objcc_ExamPaperStuBatchRelaEN.IdCurrEduCls = objcc_ExamPaperStuBatchRelaEN.IdCurrEduCls; //教学班流水号
}
if (arrFldSet.Contains(concc_ExamPaperStuBatchRela.Scores, new clsStrCompareIgnoreCase())  ==  true)
{
objcc_ExamPaperStuBatchRelaEN.Scores = objcc_ExamPaperStuBatchRelaEN.Scores; //分值
}
if (arrFldSet.Contains(concc_ExamPaperStuBatchRela.IsSave, new clsStrCompareIgnoreCase())  ==  true)
{
objcc_ExamPaperStuBatchRelaEN.IsSave = objcc_ExamPaperStuBatchRelaEN.IsSave; //是否保存
}
if (arrFldSet.Contains(concc_ExamPaperStuBatchRela.IsSubmit, new clsStrCompareIgnoreCase())  ==  true)
{
objcc_ExamPaperStuBatchRelaEN.IsSubmit = objcc_ExamPaperStuBatchRelaEN.IsSubmit; //是否提交
}
if (arrFldSet.Contains(concc_ExamPaperStuBatchRela.RealFinishDate, new clsStrCompareIgnoreCase())  ==  true)
{
objcc_ExamPaperStuBatchRelaEN.RealFinishDate = objcc_ExamPaperStuBatchRelaEN.RealFinishDate == "[null]" ? null :  objcc_ExamPaperStuBatchRelaEN.RealFinishDate; //实际完成日期
}
if (arrFldSet.Contains(concc_ExamPaperStuBatchRela.OperateTime, new clsStrCompareIgnoreCase())  ==  true)
{
objcc_ExamPaperStuBatchRelaEN.OperateTime = objcc_ExamPaperStuBatchRelaEN.OperateTime == "[null]" ? null :  objcc_ExamPaperStuBatchRelaEN.OperateTime; //操作时间
}
if (arrFldSet.Contains(concc_ExamPaperStuBatchRela.IsMarking, new clsStrCompareIgnoreCase())  ==  true)
{
objcc_ExamPaperStuBatchRelaEN.IsMarking = objcc_ExamPaperStuBatchRelaEN.IsMarking; //是否批阅
}
if (arrFldSet.Contains(concc_ExamPaperStuBatchRela.MarkerId, new clsStrCompareIgnoreCase())  ==  true)
{
objcc_ExamPaperStuBatchRelaEN.MarkerId = objcc_ExamPaperStuBatchRelaEN.MarkerId == "[null]" ? null :  objcc_ExamPaperStuBatchRelaEN.MarkerId; //打分者
}
if (arrFldSet.Contains(concc_ExamPaperStuBatchRela.MarkDate, new clsStrCompareIgnoreCase())  ==  true)
{
objcc_ExamPaperStuBatchRelaEN.MarkDate = objcc_ExamPaperStuBatchRelaEN.MarkDate == "[null]" ? null :  objcc_ExamPaperStuBatchRelaEN.MarkDate; //打分日期
}
if (arrFldSet.Contains(concc_ExamPaperStuBatchRela.AnswerIP, new clsStrCompareIgnoreCase())  ==  true)
{
objcc_ExamPaperStuBatchRelaEN.AnswerIP = objcc_ExamPaperStuBatchRelaEN.AnswerIP == "[null]" ? null :  objcc_ExamPaperStuBatchRelaEN.AnswerIP; //回答IP
}
if (arrFldSet.Contains(concc_ExamPaperStuBatchRela.AnswerDate, new clsStrCompareIgnoreCase())  ==  true)
{
objcc_ExamPaperStuBatchRelaEN.AnswerDate = objcc_ExamPaperStuBatchRelaEN.AnswerDate == "[null]" ? null :  objcc_ExamPaperStuBatchRelaEN.AnswerDate; //回答日期
}
if (arrFldSet.Contains(concc_ExamPaperStuBatchRela.AnswerTime, new clsStrCompareIgnoreCase())  ==  true)
{
objcc_ExamPaperStuBatchRelaEN.AnswerTime = objcc_ExamPaperStuBatchRelaEN.AnswerTime == "[null]" ? null :  objcc_ExamPaperStuBatchRelaEN.AnswerTime; //回答时间
}
if (arrFldSet.Contains(concc_ExamPaperStuBatchRela.TotalGetScore, new clsStrCompareIgnoreCase())  ==  true)
{
objcc_ExamPaperStuBatchRelaEN.TotalGetScore = objcc_ExamPaperStuBatchRelaEN.TotalGetScore; //考生获取总分
}
if (arrFldSet.Contains(concc_ExamPaperStuBatchRela.UpdDate, new clsStrCompareIgnoreCase())  ==  true)
{
objcc_ExamPaperStuBatchRelaEN.UpdDate = objcc_ExamPaperStuBatchRelaEN.UpdDate; //修改日期
}
if (arrFldSet.Contains(concc_ExamPaperStuBatchRela.UpdUserId, new clsStrCompareIgnoreCase())  ==  true)
{
objcc_ExamPaperStuBatchRelaEN.UpdUserId = objcc_ExamPaperStuBatchRelaEN.UpdUserId == "[null]" ? null :  objcc_ExamPaperStuBatchRelaEN.UpdUserId; //修改用户Id
}
if (arrFldSet.Contains(concc_ExamPaperStuBatchRela.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objcc_ExamPaperStuBatchRelaEN.Memo = objcc_ExamPaperStuBatchRelaEN.Memo == "[null]" ? null :  objcc_ExamPaperStuBatchRelaEN.Memo; //备注
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
 /// <param name = "objcc_ExamPaperStuBatchRelaEN">源简化对象</param>
 public static void AccessFldValueNull(clscc_ExamPaperStuBatchRelaEN objcc_ExamPaperStuBatchRelaEN)
{
try
{
if (objcc_ExamPaperStuBatchRelaEN.CourseExamPaperId == "[null]") objcc_ExamPaperStuBatchRelaEN.CourseExamPaperId = null; //考卷流水号
if (objcc_ExamPaperStuBatchRelaEN.BatchTime == "[null]") objcc_ExamPaperStuBatchRelaEN.BatchTime = null; //批次
if (objcc_ExamPaperStuBatchRelaEN.RealFinishDate == "[null]") objcc_ExamPaperStuBatchRelaEN.RealFinishDate = null; //实际完成日期
if (objcc_ExamPaperStuBatchRelaEN.OperateTime == "[null]") objcc_ExamPaperStuBatchRelaEN.OperateTime = null; //操作时间
if (objcc_ExamPaperStuBatchRelaEN.MarkerId == "[null]") objcc_ExamPaperStuBatchRelaEN.MarkerId = null; //打分者
if (objcc_ExamPaperStuBatchRelaEN.MarkDate == "[null]") objcc_ExamPaperStuBatchRelaEN.MarkDate = null; //打分日期
if (objcc_ExamPaperStuBatchRelaEN.AnswerIP == "[null]") objcc_ExamPaperStuBatchRelaEN.AnswerIP = null; //回答IP
if (objcc_ExamPaperStuBatchRelaEN.AnswerDate == "[null]") objcc_ExamPaperStuBatchRelaEN.AnswerDate = null; //回答日期
if (objcc_ExamPaperStuBatchRelaEN.AnswerTime == "[null]") objcc_ExamPaperStuBatchRelaEN.AnswerTime = null; //回答时间
if (objcc_ExamPaperStuBatchRelaEN.UpdUserId == "[null]") objcc_ExamPaperStuBatchRelaEN.UpdUserId = null; //修改用户Id
if (objcc_ExamPaperStuBatchRelaEN.Memo == "[null]") objcc_ExamPaperStuBatchRelaEN.Memo = null; //备注
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
public static void CheckPropertyNew(clscc_ExamPaperStuBatchRelaEN objcc_ExamPaperStuBatchRelaEN)
{
 cc_ExamPaperStuBatchRelaDA.CheckPropertyNew(objcc_ExamPaperStuBatchRelaEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(clscc_ExamPaperStuBatchRelaEN objcc_ExamPaperStuBatchRelaEN)
{
 cc_ExamPaperStuBatchRelaDA.CheckProperty4Condition(objcc_ExamPaperStuBatchRelaEN);
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
if (clscc_ExamPaperStuBatchRelaBL.objCommFun4BL == null)
{
strMsg = string.Format("类clscc_ExamPaperStuBatchRelaBL没有刷新缓存机制(clscc_ExamPaperStuBatchRelaBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by IdPaperStuBatch");
//if (arrcc_ExamPaperStuBatchRelaObjLstCache == null)
//{
//arrcc_ExamPaperStuBatchRelaObjLstCache = cc_ExamPaperStuBatchRelaDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "strIdPaperStuBatch">所给的关键字</param>
 /// <param name = "strIdCurrEduCls">缓存的分类字段</param>
 /// <returns>根据关键字获取的对象</returns>
public static clscc_ExamPaperStuBatchRelaEN GetObjByIdPaperStuBatchCache(string strIdPaperStuBatch, string strIdCurrEduCls)
{

if (string.IsNullOrEmpty(strIdCurrEduCls) == true)
{
  var strMsg = string.Format("参数:[strIdCurrEduCls]不能为空!(In {0})", clsStackTrace.GetCurrClassFunction());
clsSysParaEN.objLog.WriteDebugLog(strMsg);
 throw new Exception (strMsg);
}
if (strIdCurrEduCls.Length != 8)
{
var strMsg = string.Format("缓存分类变量:[strIdCurrEduCls]的长度:[{0}]不正确!(In {1})", strIdCurrEduCls.Length, clsStackTrace.GetCurrClassFunction());
clsSysParaEN.objLog.WriteDebugLog(strMsg);
 throw new Exception (strMsg);
}
//获取缓存中的对象列表
string strKey = string.Format("{0}_{1}", clscc_ExamPaperStuBatchRelaEN._CurrTabName, strIdCurrEduCls);
List<clscc_ExamPaperStuBatchRelaEN> arrcc_ExamPaperStuBatchRelaObjLstCache = GetObjLstCache(strIdCurrEduCls);
IEnumerable <clscc_ExamPaperStuBatchRelaEN> arrcc_ExamPaperStuBatchRelaObjLst_Sel =
arrcc_ExamPaperStuBatchRelaObjLstCache
.Where(x=> x.IdPaperStuBatch == strIdPaperStuBatch 
);
if (arrcc_ExamPaperStuBatchRelaObjLst_Sel.Count() == 0)
{
   clscc_ExamPaperStuBatchRelaEN obj = clscc_ExamPaperStuBatchRelaBL.GetObjByIdPaperStuBatch(strIdPaperStuBatch);
   if (obj != null)
 {
if (obj.IdCurrEduCls == strIdCurrEduCls)
{
CacheHelper.Remove(strKey);
     return obj;
}
else
{
string strMsg = string.Format("错误: 关键字:{0}不属于分类:{1},请检查!(In {2})", strIdPaperStuBatch, strIdCurrEduCls, clsStackTrace.GetCurrClassFunction());
clsSysParaEN.objLog.WriteDebugLog(strMsg);
throw new Exception(strMsg);
}
 }
return null;
}
return arrcc_ExamPaperStuBatchRelaObjLst_Sel.First();
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clscc_ExamPaperStuBatchRelaEN> GetAllcc_ExamPaperStuBatchRelaObjLstCache(string strIdCurrEduCls)
{
//获取缓存中的对象列表
List<clscc_ExamPaperStuBatchRelaEN> arrcc_ExamPaperStuBatchRelaObjLstCache = GetObjLstCache(strIdCurrEduCls); 
return arrcc_ExamPaperStuBatchRelaObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clscc_ExamPaperStuBatchRelaEN> GetObjLstCache(string strIdCurrEduCls)
{

if (string.IsNullOrEmpty(strIdCurrEduCls) == true)
{
  var strMsg = string.Format("参数:[strIdCurrEduCls]不能为空!(In {0})", clsStackTrace.GetCurrClassFunction());
clsSysParaEN.objLog.WriteDebugLog(strMsg);
 throw new Exception (strMsg);
}
if (strIdCurrEduCls.Length != 8)
{
var strMsg = string.Format("缓存分类变量:[strIdCurrEduCls]的长度:[{0}]不正确!(In {1})", strIdCurrEduCls.Length, clsStackTrace.GetCurrClassFunction());
clsSysParaEN.objLog.WriteDebugLog(strMsg);
 throw new Exception (strMsg);
}
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}_{1}", clscc_ExamPaperStuBatchRelaEN._CurrTabName, strIdCurrEduCls);
string strCondition = string.Format("IdCurrEduCls='{0}'", strIdCurrEduCls);
List<clscc_ExamPaperStuBatchRelaEN> arrcc_ExamPaperStuBatchRelaObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst(strCondition); });
return arrcc_ExamPaperStuBatchRelaObjLstCache;
}

 /// <summary>
 /// 根据分类字段获取缓存中对象列表的子集,根据:IdCurrEduCls字段
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubSet4ObjLst)
 /// </summary>
 /// <param name = "parrcc_ExamPaperStuBatchRelaObjLst">需要排序的对象列表</param>
public static List <clscc_ExamPaperStuBatchRelaEN> GetSubSet4cc_ExamPaperStuBatchRelaObjLstByIdCurrEduClsCache(string strIdCurrEduCls)
{
   if (string.IsNullOrEmpty(strIdCurrEduCls) == true) return null;
//初始化列表缓存
string strKey = string.Format("{0}_{1}", clscc_ExamPaperStuBatchRelaEN._CurrTabName, strIdCurrEduCls);
List<clscc_ExamPaperStuBatchRelaEN> arrcc_ExamPaperStuBatchRelaObjLstCache = GetObjLstCache(strIdCurrEduCls);
IEnumerable <clscc_ExamPaperStuBatchRelaEN> arrcc_ExamPaperStuBatchRelaObjLst_Sel1 =
from objcc_ExamPaperStuBatchRelaEN in arrcc_ExamPaperStuBatchRelaObjLstCache
where objcc_ExamPaperStuBatchRelaEN.IdCurrEduCls == strIdCurrEduCls
select objcc_ExamPaperStuBatchRelaEN;
List <clscc_ExamPaperStuBatchRelaEN> arrcc_ExamPaperStuBatchRelaObjLst_Sel = new List<clscc_ExamPaperStuBatchRelaEN>();
foreach (clscc_ExamPaperStuBatchRelaEN obj in arrcc_ExamPaperStuBatchRelaObjLst_Sel1)
{
arrcc_ExamPaperStuBatchRelaObjLst_Sel.Add(obj);
}
return arrcc_ExamPaperStuBatchRelaObjLst_Sel;
}

 /// <summary>
 /// 刷新本类中的缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ReFreshThisCache)
 /// </summary>
public static void ReFreshThisCache(string strIdCurrEduCls = "")
{
string strMsg;
if (clsSysParaEN.spSetRefreshCacheOn == true)
{
string strKey = string.Format("{0}_{1}", clscc_ExamPaperStuBatchRelaEN._CurrTabName, strIdCurrEduCls);
CacheHelper.Remove(strKey);
clscc_ExamPaperStuBatchRelaEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
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
if (clscc_ExamPaperStuBatchRelaEN._RefreshTimeLst.Count == 0) return "";
return clscc_ExamPaperStuBatchRelaEN._RefreshTimeLst[clscc_ExamPaperStuBatchRelaEN._RefreshTimeLst.Count - 1];
}

 /// <summary>
 /// 刷新缓存.把当前表的缓存以及该表相关视图的缓存清空.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ReFreshCache)
 /// </summary>
public static void ReFreshCache(string strIdCurrEduCls)
{
if (string.IsNullOrEmpty(strIdCurrEduCls) == true)
{
string strMsg = string.Format("缓存分类字段:[IdCurrEduCls]不能为空!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clscc_ExamPaperStuBatchRelaBL.objCommFun4BL != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}_{1}", clscc_ExamPaperStuBatchRelaEN._CurrTabName, strIdCurrEduCls);
CacheHelper.Remove(strKey);
clscc_ExamPaperStuBatchRelaEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
clscc_ExamPaperStuBatchRelaBL.objCommFun4BL.ReFreshCache(strIdCurrEduCls);
}
}


 #endregion 缓存操作


 #region 检查唯一性

 /// <summary>
 /// 获取检查唯一性条件串(Uniqueness)--cc_ExamPaperStuBatchRela(考卷与学生批次关系)
 /// 唯一性条件:CourseExamPaperId_id_StudentInfo
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetUniquenessConditionString)
 /// </summary>
 /// <param name = "objcc_ExamPaperStuBatchRelaEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(clscc_ExamPaperStuBatchRelaEN objcc_ExamPaperStuBatchRelaEN)
{
//检测记录是否存在
string strResult = cc_ExamPaperStuBatchRelaDA.GetUniCondStr(objcc_ExamPaperStuBatchRelaEN);
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
 /// <param name = "strIdCurrEduCls">缓存的分类字段</param>
 /// <returns>返回一个输出字段值</returns>
public static string Func(string strInFldName, string strOutFldName, string strIdPaperStuBatch, string strIdCurrEduCls)
{
if (strInFldName != concc_ExamPaperStuBatchRela.IdPaperStuBatch)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (concc_ExamPaperStuBatchRela.AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", concc_ExamPaperStuBatchRela.AttributeName));
throw new Exception(strMsg);
}
var objcc_ExamPaperStuBatchRela = clscc_ExamPaperStuBatchRelaBL.GetObjByIdPaperStuBatchCache(strIdPaperStuBatch, strIdCurrEduCls);
if (objcc_ExamPaperStuBatchRela == null) return "";
return objcc_ExamPaperStuBatchRela[strOutFldName].ToString();
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
int intRecCount = clscc_ExamPaperStuBatchRelaDA.GetRecCount(strTabName);
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
int intRecCount = clscc_ExamPaperStuBatchRelaDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clscc_ExamPaperStuBatchRelaDA.GetRecCount();
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
int intRecCount = clscc_ExamPaperStuBatchRelaDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objcc_ExamPaperStuBatchRelaCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clscc_ExamPaperStuBatchRelaEN objcc_ExamPaperStuBatchRelaCond)
{
 string strIdCurrEduCls = objcc_ExamPaperStuBatchRelaCond.IdCurrEduCls;
 if (string.IsNullOrEmpty(strIdCurrEduCls) == true)
{
string strMsg = string.Format("(errid:Busi000174)在表中,缓存分类字段值不能为空!(clscc_ExamPaperStuBatchRelaBL:GetRecCountByCondCache)");
throw new Exception(strMsg);
}
List<clscc_ExamPaperStuBatchRelaEN> arrObjLstCache = GetObjLstCache(strIdCurrEduCls);
IEnumerable <clscc_ExamPaperStuBatchRelaEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in concc_ExamPaperStuBatchRela.AttributeName)
{
if (objcc_ExamPaperStuBatchRelaCond.IsUpdated(strFldName) == false) continue;
if (objcc_ExamPaperStuBatchRelaCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objcc_ExamPaperStuBatchRelaCond[strFldName].ToString());
}
else
{
if (objcc_ExamPaperStuBatchRelaCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objcc_ExamPaperStuBatchRelaCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objcc_ExamPaperStuBatchRelaCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objcc_ExamPaperStuBatchRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objcc_ExamPaperStuBatchRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objcc_ExamPaperStuBatchRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objcc_ExamPaperStuBatchRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objcc_ExamPaperStuBatchRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objcc_ExamPaperStuBatchRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objcc_ExamPaperStuBatchRelaCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objcc_ExamPaperStuBatchRelaCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objcc_ExamPaperStuBatchRelaCond[strFldName]));
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
 List<string> arrList = clscc_ExamPaperStuBatchRelaDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = cc_ExamPaperStuBatchRelaDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = cc_ExamPaperStuBatchRelaDA.GetFldValueNoDistinct(strFldName, strWhereCond);
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
int intRecCount = cc_ExamPaperStuBatchRelaDA.SetFldValue(strFldName, strValue, strWhereCond);
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
int intRecCount = clscc_ExamPaperStuBatchRelaDA.SetFldValue(clscc_ExamPaperStuBatchRelaEN._CurrTabName, strFldName, fltValue, strWhereCond);
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
int intRecCount = cc_ExamPaperStuBatchRelaDA.SetFldValue( strFldName, intValue, strWhereCond);
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
int intRecCount = clscc_ExamPaperStuBatchRelaDA.SetFldValue(strTabName, strFldName, strValue, strWhereCond);
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
int intRecCount = clscc_ExamPaperStuBatchRelaDA.SetFldValue(strTabName, strFldName, intValue, strWhereCond);
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
int intRecCount = clscc_ExamPaperStuBatchRelaDA.SetFldValue(strTabName, strFldName, fltValue, strWhereCond);
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
  strCreateTabCode.Append("CREATE table [dbo].[cc_ExamPaperStuBatchRela] "); 
 strCreateTabCode.Append(" ( "); 
 // /**学生试卷批次流水号*/ 
 strCreateTabCode.Append(" IdPaperStuBatch char(10) primary key, "); 
 // /**考卷流水号*/ 
 strCreateTabCode.Append(" CourseExamPaperId char(8) Null, "); 
 // /**学生流水号*/ 
 strCreateTabCode.Append(" IdStudentInfo char(8) not Null, "); 
 // /**批次*/ 
 strCreateTabCode.Append(" BatchTime varchar(14) Null, "); 
 // /**教学班流水号*/ 
 strCreateTabCode.Append(" IdCurrEduCls char(8) not Null, "); 
 // /**分值*/ 
 strCreateTabCode.Append(" Scores decimal(8,2) Null, "); 
 // /**是否保存*/ 
 strCreateTabCode.Append(" IsSave bit Null, "); 
 // /**是否提交*/ 
 strCreateTabCode.Append(" IsSubmit bit Null, "); 
 // /**实际完成日期*/ 
 strCreateTabCode.Append(" RealFinishDate varchar(14) Null, "); 
 // /**操作时间*/ 
 strCreateTabCode.Append(" OperateTime varchar(14) Null, "); 
 // /**是否批阅*/ 
 strCreateTabCode.Append(" IsMarking bit Null, "); 
 // /**打分者*/ 
 strCreateTabCode.Append(" MarkerId varchar(20) Null, "); 
 // /**打分日期*/ 
 strCreateTabCode.Append(" MarkDate varchar(14) Null, "); 
 // /**回答IP*/ 
 strCreateTabCode.Append(" AnswerIP varchar(30) Null, "); 
 // /**回答日期*/ 
 strCreateTabCode.Append(" AnswerDate varchar(8) Null, "); 
 // /**回答时间*/ 
 strCreateTabCode.Append(" AnswerTime varchar(10) Null, "); 
 // /**考生获取总分*/ 
 strCreateTabCode.Append(" TotalGetScore decimal(12,1) Null, "); 
 // /**修改日期*/ 
 strCreateTabCode.Append(" UpdDate varchar(20) not Null, "); 
 // /**修改用户Id*/ 
 strCreateTabCode.Append(" UpdUserId varchar(20) Null, "); 
 // /**备注*/ 
 strCreateTabCode.Append(" Memo varchar(1000) Null, "); 
 // /**姓名*/ 
 strCreateTabCode.Append(" StuName varchar(50) Null, "); 
 // /**教学班名*/ 
 strCreateTabCode.Append(" EduClsName varchar(100) Null, "); 
 // /**课程Id*/ 
 strCreateTabCode.Append(" CourseId char(8) Null ");
 strCreateTabCode.Append(") "); 
  strCreateTabCode.Append("ON [PRIMARY] ");
  return strCreateTabCode.ToString();
}



 #endregion 表操作
}
 /// <summary>
 /// 考卷与学生批次关系(cc_ExamPaperStuBatchRela)
 /// 数据源类型:表
 /// (AutoGCLib.CommFun4BL4CSharp:GeneCode_This)
 /// </summary>
public class  clsCommFun4BL4cc_ExamPaperStuBatchRela : clsCommFun4BLV2
{

 /// <summary>
 /// 刷新缓存.把当前表的缓存以及该表相关视图的缓存清空.
 /// (AutoGCLib.CommFun4BL4CSharp:Gen_4CFBL_ReFreshCache)
 /// </summary>
public override void ReFreshCache(string strIdCurrEduCls)
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
clscc_ExamPaperStuBatchRelaBL.ReFreshThisCache(strIdCurrEduCls);
}
}

}