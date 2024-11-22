
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clscc_PaperStuBatchQuesRela_TotalBL
 表名:cc_PaperStuBatchQuesRela_Total(01120243)
 * 版本:2024.11.13.1(服务器:WIN-SRV103-116)
 日期:2024/11/13 06:09:27
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
public static class  clscc_PaperStuBatchQuesRela_TotalBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "lngIdPaperStuBatchQuesRelaTotal">表关键字</param>
 /// <returns>表对象</returns>
public static clscc_PaperStuBatchQuesRela_TotalEN GetObj(this K_IdPaperStuBatchQuesRelaTotal_cc_PaperStuBatchQuesRela_Total myKey)
{
clscc_PaperStuBatchQuesRela_TotalEN objcc_PaperStuBatchQuesRela_TotalEN = clscc_PaperStuBatchQuesRela_TotalBL.cc_PaperStuBatchQuesRela_TotalDA.GetObjByIdPaperStuBatchQuesRelaTotal(myKey.Value);
return objcc_PaperStuBatchQuesRela_TotalEN;
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_AddNewRecord)
 /// </summary>
 /// <param name = "objcc_PaperStuBatchQuesRela_TotalEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clscc_PaperStuBatchQuesRela_TotalEN objcc_PaperStuBatchQuesRela_TotalEN, bool bolIsNeedCheckUniqueness = true)
{
if (bolIsNeedCheckUniqueness == true && CheckUniqueness(objcc_PaperStuBatchQuesRela_TotalEN) == false)
{
var strMsg = string.Format("记录已经存在!学生试卷批次流水号 = [{0}],学期 = [{1}],学年 = [{2}]的数据已经存在!(in clscc_PaperStuBatchQuesRela_TotalBL.AddNewRecord)", objcc_PaperStuBatchQuesRela_TotalEN.IdPaperStuBatch,objcc_PaperStuBatchQuesRela_TotalEN.SchoolTerm,objcc_PaperStuBatchQuesRela_TotalEN.SchoolYear);
throw new Exception(strMsg);
}
try
{
bool bolResult = clscc_PaperStuBatchQuesRela_TotalBL.cc_PaperStuBatchQuesRela_TotalDA.AddNewRecordBySQL2(objcc_PaperStuBatchQuesRela_TotalEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clscc_PaperStuBatchQuesRela_TotalBL.ReFreshCache();

if (clscc_PaperStuBatchQuesRela_TotalBL.relatedActions != null)
{
clscc_PaperStuBatchQuesRela_TotalBL.relatedActions.UpdRelaTabDate(objcc_PaperStuBatchQuesRela_TotalEN.IdPaperStuBatchQuesRelaTotal, objcc_PaperStuBatchQuesRela_TotalEN.UpdUserId);
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
public static bool AddRecordEx(this clscc_PaperStuBatchQuesRela_TotalEN objcc_PaperStuBatchQuesRela_TotalEN, bool bolIsNeedCheckUniqueness = true)
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
objcc_PaperStuBatchQuesRela_TotalEN.CheckPropertyNew();
 ///5.2、检查唯一性
if (bolIsNeedCheckUniqueness == true && objcc_PaperStuBatchQuesRela_TotalEN.CheckUniqueness() == false)
{
strMsg = string.Format("(学生试卷批次流水号(IdPaperStuBatch)=[{0}],学期(SchoolTerm)=[{1}],学年(SchoolYear)=[{2}])已经存在,不能重复!", objcc_PaperStuBatchQuesRela_TotalEN.IdPaperStuBatch, objcc_PaperStuBatchQuesRela_TotalEN.SchoolTerm, objcc_PaperStuBatchQuesRela_TotalEN.SchoolYear);
throw new Exception(strMsg);
}
//6、把数据实体层的数据存贮到数据库中
objcc_PaperStuBatchQuesRela_TotalEN.AddNewRecord();
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
 /// <param name = "objcc_PaperStuBatchQuesRela_TotalEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordWithReturnKey(this clscc_PaperStuBatchQuesRela_TotalEN objcc_PaperStuBatchQuesRela_TotalEN, bool bolIsNeedCheckUniqueness = true)
{
if (bolIsNeedCheckUniqueness == true && CheckUniqueness(objcc_PaperStuBatchQuesRela_TotalEN) == false)
{
var strMsg = string.Format("记录已经存在!学生试卷批次流水号 = [{0}],学期 = [{1}],学年 = [{2}]的数据已经存在!(in clscc_PaperStuBatchQuesRela_TotalBL.AddNewRecordWithReturnKey)", objcc_PaperStuBatchQuesRela_TotalEN.IdPaperStuBatch,objcc_PaperStuBatchQuesRela_TotalEN.SchoolTerm,objcc_PaperStuBatchQuesRela_TotalEN.SchoolYear);
throw new Exception(strMsg);
}
try
{
string strKey = clscc_PaperStuBatchQuesRela_TotalBL.cc_PaperStuBatchQuesRela_TotalDA.AddNewRecordBySQL2WithReturnKey(objcc_PaperStuBatchQuesRela_TotalEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clscc_PaperStuBatchQuesRela_TotalBL.ReFreshCache();

if (clscc_PaperStuBatchQuesRela_TotalBL.relatedActions != null)
{
clscc_PaperStuBatchQuesRela_TotalBL.relatedActions.UpdRelaTabDate(objcc_PaperStuBatchQuesRela_TotalEN.IdPaperStuBatchQuesRelaTotal, objcc_PaperStuBatchQuesRela_TotalEN.UpdUserId);
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
 /// <param name = "objcc_PaperStuBatchQuesRela_TotalEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clscc_PaperStuBatchQuesRela_TotalEN SetIdPaperStuBatchQuesRelaTotal(this clscc_PaperStuBatchQuesRela_TotalEN objcc_PaperStuBatchQuesRela_TotalEN, long lngIdPaperStuBatchQuesRelaTotal, string strComparisonOp="")
	{
objcc_PaperStuBatchQuesRela_TotalEN.IdPaperStuBatchQuesRelaTotal = lngIdPaperStuBatchQuesRelaTotal; //学生试卷完成汇总流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_PaperStuBatchQuesRela_TotalEN.dicFldComparisonOp.ContainsKey(concc_PaperStuBatchQuesRela_Total.IdPaperStuBatchQuesRelaTotal) == false)
{
objcc_PaperStuBatchQuesRela_TotalEN.dicFldComparisonOp.Add(concc_PaperStuBatchQuesRela_Total.IdPaperStuBatchQuesRelaTotal, strComparisonOp);
}
else
{
objcc_PaperStuBatchQuesRela_TotalEN.dicFldComparisonOp[concc_PaperStuBatchQuesRela_Total.IdPaperStuBatchQuesRelaTotal] = strComparisonOp;
}
}
return objcc_PaperStuBatchQuesRela_TotalEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_PaperStuBatchQuesRela_TotalEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clscc_PaperStuBatchQuesRela_TotalEN SetIdPaperStuBatch(this clscc_PaperStuBatchQuesRela_TotalEN objcc_PaperStuBatchQuesRela_TotalEN, string strIdPaperStuBatch, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdPaperStuBatch, 10, concc_PaperStuBatchQuesRela_Total.IdPaperStuBatch);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdPaperStuBatch, 10, concc_PaperStuBatchQuesRela_Total.IdPaperStuBatch);
}
objcc_PaperStuBatchQuesRela_TotalEN.IdPaperStuBatch = strIdPaperStuBatch; //学生试卷批次流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_PaperStuBatchQuesRela_TotalEN.dicFldComparisonOp.ContainsKey(concc_PaperStuBatchQuesRela_Total.IdPaperStuBatch) == false)
{
objcc_PaperStuBatchQuesRela_TotalEN.dicFldComparisonOp.Add(concc_PaperStuBatchQuesRela_Total.IdPaperStuBatch, strComparisonOp);
}
else
{
objcc_PaperStuBatchQuesRela_TotalEN.dicFldComparisonOp[concc_PaperStuBatchQuesRela_Total.IdPaperStuBatch] = strComparisonOp;
}
}
return objcc_PaperStuBatchQuesRela_TotalEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_PaperStuBatchQuesRela_TotalEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clscc_PaperStuBatchQuesRela_TotalEN SetQuesNum(this clscc_PaperStuBatchQuesRela_TotalEN objcc_PaperStuBatchQuesRela_TotalEN, int intQuesNum, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(intQuesNum, concc_PaperStuBatchQuesRela_Total.QuesNum);
objcc_PaperStuBatchQuesRela_TotalEN.QuesNum = intQuesNum; //题目数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_PaperStuBatchQuesRela_TotalEN.dicFldComparisonOp.ContainsKey(concc_PaperStuBatchQuesRela_Total.QuesNum) == false)
{
objcc_PaperStuBatchQuesRela_TotalEN.dicFldComparisonOp.Add(concc_PaperStuBatchQuesRela_Total.QuesNum, strComparisonOp);
}
else
{
objcc_PaperStuBatchQuesRela_TotalEN.dicFldComparisonOp[concc_PaperStuBatchQuesRela_Total.QuesNum] = strComparisonOp;
}
}
return objcc_PaperStuBatchQuesRela_TotalEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_PaperStuBatchQuesRela_TotalEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clscc_PaperStuBatchQuesRela_TotalEN SetQuesNumLook(this clscc_PaperStuBatchQuesRela_TotalEN objcc_PaperStuBatchQuesRela_TotalEN, int? intQuesNumLook, string strComparisonOp="")
	{
objcc_PaperStuBatchQuesRela_TotalEN.QuesNumLook = intQuesNumLook; //查看题目数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_PaperStuBatchQuesRela_TotalEN.dicFldComparisonOp.ContainsKey(concc_PaperStuBatchQuesRela_Total.QuesNumLook) == false)
{
objcc_PaperStuBatchQuesRela_TotalEN.dicFldComparisonOp.Add(concc_PaperStuBatchQuesRela_Total.QuesNumLook, strComparisonOp);
}
else
{
objcc_PaperStuBatchQuesRela_TotalEN.dicFldComparisonOp[concc_PaperStuBatchQuesRela_Total.QuesNumLook] = strComparisonOp;
}
}
return objcc_PaperStuBatchQuesRela_TotalEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_PaperStuBatchQuesRela_TotalEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clscc_PaperStuBatchQuesRela_TotalEN SetQuesNumMark(this clscc_PaperStuBatchQuesRela_TotalEN objcc_PaperStuBatchQuesRela_TotalEN, int? intQuesNumMark, string strComparisonOp="")
	{
objcc_PaperStuBatchQuesRela_TotalEN.QuesNumMark = intQuesNumMark; //打分题目数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_PaperStuBatchQuesRela_TotalEN.dicFldComparisonOp.ContainsKey(concc_PaperStuBatchQuesRela_Total.QuesNumMark) == false)
{
objcc_PaperStuBatchQuesRela_TotalEN.dicFldComparisonOp.Add(concc_PaperStuBatchQuesRela_Total.QuesNumMark, strComparisonOp);
}
else
{
objcc_PaperStuBatchQuesRela_TotalEN.dicFldComparisonOp[concc_PaperStuBatchQuesRela_Total.QuesNumMark] = strComparisonOp;
}
}
return objcc_PaperStuBatchQuesRela_TotalEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_PaperStuBatchQuesRela_TotalEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clscc_PaperStuBatchQuesRela_TotalEN SetQuesNumNoFinish(this clscc_PaperStuBatchQuesRela_TotalEN objcc_PaperStuBatchQuesRela_TotalEN, int? intQuesNumNoFinish, string strComparisonOp="")
	{
objcc_PaperStuBatchQuesRela_TotalEN.QuesNumNoFinish = intQuesNumNoFinish; //未完成题目数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_PaperStuBatchQuesRela_TotalEN.dicFldComparisonOp.ContainsKey(concc_PaperStuBatchQuesRela_Total.QuesNumNoFinish) == false)
{
objcc_PaperStuBatchQuesRela_TotalEN.dicFldComparisonOp.Add(concc_PaperStuBatchQuesRela_Total.QuesNumNoFinish, strComparisonOp);
}
else
{
objcc_PaperStuBatchQuesRela_TotalEN.dicFldComparisonOp[concc_PaperStuBatchQuesRela_Total.QuesNumNoFinish] = strComparisonOp;
}
}
return objcc_PaperStuBatchQuesRela_TotalEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_PaperStuBatchQuesRela_TotalEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clscc_PaperStuBatchQuesRela_TotalEN SetQuesNumOverdue(this clscc_PaperStuBatchQuesRela_TotalEN objcc_PaperStuBatchQuesRela_TotalEN, int? intQuesNumOverdue, string strComparisonOp="")
	{
objcc_PaperStuBatchQuesRela_TotalEN.QuesNumOverdue = intQuesNumOverdue; //逾期题目数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_PaperStuBatchQuesRela_TotalEN.dicFldComparisonOp.ContainsKey(concc_PaperStuBatchQuesRela_Total.QuesNumOverdue) == false)
{
objcc_PaperStuBatchQuesRela_TotalEN.dicFldComparisonOp.Add(concc_PaperStuBatchQuesRela_Total.QuesNumOverdue, strComparisonOp);
}
else
{
objcc_PaperStuBatchQuesRela_TotalEN.dicFldComparisonOp[concc_PaperStuBatchQuesRela_Total.QuesNumOverdue] = strComparisonOp;
}
}
return objcc_PaperStuBatchQuesRela_TotalEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_PaperStuBatchQuesRela_TotalEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clscc_PaperStuBatchQuesRela_TotalEN SetQuesNumSave(this clscc_PaperStuBatchQuesRela_TotalEN objcc_PaperStuBatchQuesRela_TotalEN, int? intQuesNumSave, string strComparisonOp="")
	{
objcc_PaperStuBatchQuesRela_TotalEN.QuesNumSave = intQuesNumSave; //保存题目数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_PaperStuBatchQuesRela_TotalEN.dicFldComparisonOp.ContainsKey(concc_PaperStuBatchQuesRela_Total.QuesNumSave) == false)
{
objcc_PaperStuBatchQuesRela_TotalEN.dicFldComparisonOp.Add(concc_PaperStuBatchQuesRela_Total.QuesNumSave, strComparisonOp);
}
else
{
objcc_PaperStuBatchQuesRela_TotalEN.dicFldComparisonOp[concc_PaperStuBatchQuesRela_Total.QuesNumSave] = strComparisonOp;
}
}
return objcc_PaperStuBatchQuesRela_TotalEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_PaperStuBatchQuesRela_TotalEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clscc_PaperStuBatchQuesRela_TotalEN SetQuesNumSendBack(this clscc_PaperStuBatchQuesRela_TotalEN objcc_PaperStuBatchQuesRela_TotalEN, int? intQuesNumSendBack, string strComparisonOp="")
	{
objcc_PaperStuBatchQuesRela_TotalEN.QuesNumSendBack = intQuesNumSendBack; //退回题目数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_PaperStuBatchQuesRela_TotalEN.dicFldComparisonOp.ContainsKey(concc_PaperStuBatchQuesRela_Total.QuesNumSendBack) == false)
{
objcc_PaperStuBatchQuesRela_TotalEN.dicFldComparisonOp.Add(concc_PaperStuBatchQuesRela_Total.QuesNumSendBack, strComparisonOp);
}
else
{
objcc_PaperStuBatchQuesRela_TotalEN.dicFldComparisonOp[concc_PaperStuBatchQuesRela_Total.QuesNumSendBack] = strComparisonOp;
}
}
return objcc_PaperStuBatchQuesRela_TotalEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_PaperStuBatchQuesRela_TotalEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clscc_PaperStuBatchQuesRela_TotalEN SetQuesNumSubmit(this clscc_PaperStuBatchQuesRela_TotalEN objcc_PaperStuBatchQuesRela_TotalEN, int? intQuesNumSubmit, string strComparisonOp="")
	{
objcc_PaperStuBatchQuesRela_TotalEN.QuesNumSubmit = intQuesNumSubmit; //提交题目数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_PaperStuBatchQuesRela_TotalEN.dicFldComparisonOp.ContainsKey(concc_PaperStuBatchQuesRela_Total.QuesNumSubmit) == false)
{
objcc_PaperStuBatchQuesRela_TotalEN.dicFldComparisonOp.Add(concc_PaperStuBatchQuesRela_Total.QuesNumSubmit, strComparisonOp);
}
else
{
objcc_PaperStuBatchQuesRela_TotalEN.dicFldComparisonOp[concc_PaperStuBatchQuesRela_Total.QuesNumSubmit] = strComparisonOp;
}
}
return objcc_PaperStuBatchQuesRela_TotalEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_PaperStuBatchQuesRela_TotalEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clscc_PaperStuBatchQuesRela_TotalEN SetTotalScore(this clscc_PaperStuBatchQuesRela_TotalEN objcc_PaperStuBatchQuesRela_TotalEN, double? dblTotalScore, string strComparisonOp="")
	{
objcc_PaperStuBatchQuesRela_TotalEN.TotalScore = dblTotalScore; //总得分
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_PaperStuBatchQuesRela_TotalEN.dicFldComparisonOp.ContainsKey(concc_PaperStuBatchQuesRela_Total.TotalScore) == false)
{
objcc_PaperStuBatchQuesRela_TotalEN.dicFldComparisonOp.Add(concc_PaperStuBatchQuesRela_Total.TotalScore, strComparisonOp);
}
else
{
objcc_PaperStuBatchQuesRela_TotalEN.dicFldComparisonOp[concc_PaperStuBatchQuesRela_Total.TotalScore] = strComparisonOp;
}
}
return objcc_PaperStuBatchQuesRela_TotalEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_PaperStuBatchQuesRela_TotalEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clscc_PaperStuBatchQuesRela_TotalEN SetTotalScores(this clscc_PaperStuBatchQuesRela_TotalEN objcc_PaperStuBatchQuesRela_TotalEN, double? dblTotalScores, string strComparisonOp="")
	{
objcc_PaperStuBatchQuesRela_TotalEN.TotalScores = dblTotalScores; //总分值
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_PaperStuBatchQuesRela_TotalEN.dicFldComparisonOp.ContainsKey(concc_PaperStuBatchQuesRela_Total.TotalScores) == false)
{
objcc_PaperStuBatchQuesRela_TotalEN.dicFldComparisonOp.Add(concc_PaperStuBatchQuesRela_Total.TotalScores, strComparisonOp);
}
else
{
objcc_PaperStuBatchQuesRela_TotalEN.dicFldComparisonOp[concc_PaperStuBatchQuesRela_Total.TotalScores] = strComparisonOp;
}
}
return objcc_PaperStuBatchQuesRela_TotalEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_PaperStuBatchQuesRela_TotalEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clscc_PaperStuBatchQuesRela_TotalEN SetSchoolYear(this clscc_PaperStuBatchQuesRela_TotalEN objcc_PaperStuBatchQuesRela_TotalEN, string strSchoolYear, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strSchoolYear, 10, concc_PaperStuBatchQuesRela_Total.SchoolYear);
}
objcc_PaperStuBatchQuesRela_TotalEN.SchoolYear = strSchoolYear; //学年
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_PaperStuBatchQuesRela_TotalEN.dicFldComparisonOp.ContainsKey(concc_PaperStuBatchQuesRela_Total.SchoolYear) == false)
{
objcc_PaperStuBatchQuesRela_TotalEN.dicFldComparisonOp.Add(concc_PaperStuBatchQuesRela_Total.SchoolYear, strComparisonOp);
}
else
{
objcc_PaperStuBatchQuesRela_TotalEN.dicFldComparisonOp[concc_PaperStuBatchQuesRela_Total.SchoolYear] = strComparisonOp;
}
}
return objcc_PaperStuBatchQuesRela_TotalEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_PaperStuBatchQuesRela_TotalEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clscc_PaperStuBatchQuesRela_TotalEN SetSchoolTerm(this clscc_PaperStuBatchQuesRela_TotalEN objcc_PaperStuBatchQuesRela_TotalEN, string strSchoolTerm, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strSchoolTerm, 1, concc_PaperStuBatchQuesRela_Total.SchoolTerm);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strSchoolTerm, 1, concc_PaperStuBatchQuesRela_Total.SchoolTerm);
}
objcc_PaperStuBatchQuesRela_TotalEN.SchoolTerm = strSchoolTerm; //学期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_PaperStuBatchQuesRela_TotalEN.dicFldComparisonOp.ContainsKey(concc_PaperStuBatchQuesRela_Total.SchoolTerm) == false)
{
objcc_PaperStuBatchQuesRela_TotalEN.dicFldComparisonOp.Add(concc_PaperStuBatchQuesRela_Total.SchoolTerm, strComparisonOp);
}
else
{
objcc_PaperStuBatchQuesRela_TotalEN.dicFldComparisonOp[concc_PaperStuBatchQuesRela_Total.SchoolTerm] = strComparisonOp;
}
}
return objcc_PaperStuBatchQuesRela_TotalEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_PaperStuBatchQuesRela_TotalEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clscc_PaperStuBatchQuesRela_TotalEN SetUpdDate(this clscc_PaperStuBatchQuesRela_TotalEN objcc_PaperStuBatchQuesRela_TotalEN, string strUpdDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strUpdDate, concc_PaperStuBatchQuesRela_Total.UpdDate);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdDate, 20, concc_PaperStuBatchQuesRela_Total.UpdDate);
}
objcc_PaperStuBatchQuesRela_TotalEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_PaperStuBatchQuesRela_TotalEN.dicFldComparisonOp.ContainsKey(concc_PaperStuBatchQuesRela_Total.UpdDate) == false)
{
objcc_PaperStuBatchQuesRela_TotalEN.dicFldComparisonOp.Add(concc_PaperStuBatchQuesRela_Total.UpdDate, strComparisonOp);
}
else
{
objcc_PaperStuBatchQuesRela_TotalEN.dicFldComparisonOp[concc_PaperStuBatchQuesRela_Total.UpdDate] = strComparisonOp;
}
}
return objcc_PaperStuBatchQuesRela_TotalEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_PaperStuBatchQuesRela_TotalEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clscc_PaperStuBatchQuesRela_TotalEN SetUpdUserId(this clscc_PaperStuBatchQuesRela_TotalEN objcc_PaperStuBatchQuesRela_TotalEN, string strUpdUserId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdUserId, 20, concc_PaperStuBatchQuesRela_Total.UpdUserId);
}
objcc_PaperStuBatchQuesRela_TotalEN.UpdUserId = strUpdUserId; //修改用户Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_PaperStuBatchQuesRela_TotalEN.dicFldComparisonOp.ContainsKey(concc_PaperStuBatchQuesRela_Total.UpdUserId) == false)
{
objcc_PaperStuBatchQuesRela_TotalEN.dicFldComparisonOp.Add(concc_PaperStuBatchQuesRela_Total.UpdUserId, strComparisonOp);
}
else
{
objcc_PaperStuBatchQuesRela_TotalEN.dicFldComparisonOp[concc_PaperStuBatchQuesRela_Total.UpdUserId] = strComparisonOp;
}
}
return objcc_PaperStuBatchQuesRela_TotalEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_PaperStuBatchQuesRela_TotalEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clscc_PaperStuBatchQuesRela_TotalEN SetMemo(this clscc_PaperStuBatchQuesRela_TotalEN objcc_PaperStuBatchQuesRela_TotalEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, concc_PaperStuBatchQuesRela_Total.Memo);
}
objcc_PaperStuBatchQuesRela_TotalEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_PaperStuBatchQuesRela_TotalEN.dicFldComparisonOp.ContainsKey(concc_PaperStuBatchQuesRela_Total.Memo) == false)
{
objcc_PaperStuBatchQuesRela_TotalEN.dicFldComparisonOp.Add(concc_PaperStuBatchQuesRela_Total.Memo, strComparisonOp);
}
else
{
objcc_PaperStuBatchQuesRela_TotalEN.dicFldComparisonOp[concc_PaperStuBatchQuesRela_Total.Memo] = strComparisonOp;
}
}
return objcc_PaperStuBatchQuesRela_TotalEN;
	}

 /// <summary>
 /// 修改记录存盘到数据表中
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_UpdateRecordEx)
 /// </summary>
 /// <param name = "objcc_PaperStuBatchQuesRela_TotalEN">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool UpdateRecordEx(this clscc_PaperStuBatchQuesRela_TotalEN objcc_PaperStuBatchQuesRela_TotalEN)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
try
{
//1、检查传进去的对象属性是否合法
objcc_PaperStuBatchQuesRela_TotalEN.CheckPropertyNew();
clscc_PaperStuBatchQuesRela_TotalEN objcc_PaperStuBatchQuesRela_TotalCond = new clscc_PaperStuBatchQuesRela_TotalEN();
string strCondition = objcc_PaperStuBatchQuesRela_TotalCond
.SetIdPaperStuBatchQuesRelaTotal(objcc_PaperStuBatchQuesRela_TotalEN.IdPaperStuBatchQuesRelaTotal, "<>")
.SetIdPaperStuBatch(objcc_PaperStuBatchQuesRela_TotalEN.IdPaperStuBatch, "=")
.SetSchoolTerm(objcc_PaperStuBatchQuesRela_TotalEN.SchoolTerm, "=")
.SetSchoolYear(objcc_PaperStuBatchQuesRela_TotalEN.SchoolYear, "=")
.GetCombineCondition();
objcc_PaperStuBatchQuesRela_TotalEN._IsCheckProperty = true;
bool bolIsExist = clscc_PaperStuBatchQuesRela_TotalBL.IsExistRecord(strCondition);
if (bolIsExist)
{
strMsg = "(Id_PaperStuBatch_SchoolTerm_SchoolYear)不能重复!";
throw new Exception(strMsg);
}
//4、把数据实体层的数据存贮到数据库中
objcc_PaperStuBatchQuesRela_TotalEN.Update();
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
 /// <param name = "objcc_PaperStuBatchQuesRela_Total">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool EditRecordEx(this clscc_PaperStuBatchQuesRela_TotalEN objcc_PaperStuBatchQuesRela_Total)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
clscc_PaperStuBatchQuesRela_TotalEN objcc_PaperStuBatchQuesRela_TotalCond = new clscc_PaperStuBatchQuesRela_TotalEN();
string strCondition = objcc_PaperStuBatchQuesRela_TotalCond
.SetIdPaperStuBatch(objcc_PaperStuBatchQuesRela_Total.IdPaperStuBatch, "=")
.SetSchoolTerm(objcc_PaperStuBatchQuesRela_Total.SchoolTerm, "=")
.SetSchoolYear(objcc_PaperStuBatchQuesRela_Total.SchoolYear, "=")
.GetCombineCondition();
objcc_PaperStuBatchQuesRela_Total._IsCheckProperty = true;
bool bolIsExist = clscc_PaperStuBatchQuesRela_TotalBL.IsExistRecord(strCondition);
if (bolIsExist)
{
objcc_PaperStuBatchQuesRela_Total.IdPaperStuBatchQuesRelaTotal = clscc_PaperStuBatchQuesRela_TotalBL.GetFirstID_S(strCondition);
objcc_PaperStuBatchQuesRela_Total.UpdateWithCondition(strCondition);
}
else
{
objcc_PaperStuBatchQuesRela_Total.AddNewRecord();
}
return true; 
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_Update)
 /// </summary>
 /// <param name = "objcc_PaperStuBatchQuesRela_TotalEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clscc_PaperStuBatchQuesRela_TotalEN objcc_PaperStuBatchQuesRela_TotalEN)
{
 if (objcc_PaperStuBatchQuesRela_TotalEN.IdPaperStuBatchQuesRelaTotal == 0)
 {
string strMsg = string.Format("(errid:Busi000095)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clscc_PaperStuBatchQuesRela_TotalBL.cc_PaperStuBatchQuesRela_TotalDA.UpdateBySql2(objcc_PaperStuBatchQuesRela_TotalEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clscc_PaperStuBatchQuesRela_TotalBL.ReFreshCache();

if (clscc_PaperStuBatchQuesRela_TotalBL.relatedActions != null)
{
clscc_PaperStuBatchQuesRela_TotalBL.relatedActions.UpdRelaTabDate(objcc_PaperStuBatchQuesRela_TotalEN.IdPaperStuBatchQuesRelaTotal, objcc_PaperStuBatchQuesRela_TotalEN.UpdUserId);
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
 /// <param name = "objcc_PaperStuBatchQuesRela_TotalEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clscc_PaperStuBatchQuesRela_TotalEN objcc_PaperStuBatchQuesRela_TotalEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (objcc_PaperStuBatchQuesRela_TotalEN.IdPaperStuBatchQuesRelaTotal == 0)
 {
string strMsg = string.Format("(errid:Busi000087)修改记录时关键字不能为空!(带事务处理)(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clscc_PaperStuBatchQuesRela_TotalBL.cc_PaperStuBatchQuesRela_TotalDA.UpdateBySql2(objcc_PaperStuBatchQuesRela_TotalEN, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clscc_PaperStuBatchQuesRela_TotalBL.ReFreshCache();

if (clscc_PaperStuBatchQuesRela_TotalBL.relatedActions != null)
{
clscc_PaperStuBatchQuesRela_TotalBL.relatedActions.UpdRelaTabDate(objcc_PaperStuBatchQuesRela_TotalEN.IdPaperStuBatchQuesRelaTotal, objcc_PaperStuBatchQuesRela_TotalEN.UpdUserId);
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
 /// <param name = "objcc_PaperStuBatchQuesRela_TotalEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clscc_PaperStuBatchQuesRela_TotalEN objcc_PaperStuBatchQuesRela_TotalEN, string strWhereCond)
{
try
{
bool bolResult = clscc_PaperStuBatchQuesRela_TotalBL.cc_PaperStuBatchQuesRela_TotalDA.UpdateBySqlWithCondition(objcc_PaperStuBatchQuesRela_TotalEN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clscc_PaperStuBatchQuesRela_TotalBL.ReFreshCache();

if (clscc_PaperStuBatchQuesRela_TotalBL.relatedActions != null)
{
clscc_PaperStuBatchQuesRela_TotalBL.relatedActions.UpdRelaTabDate(objcc_PaperStuBatchQuesRela_TotalEN.IdPaperStuBatchQuesRelaTotal, objcc_PaperStuBatchQuesRela_TotalEN.UpdUserId);
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
 /// <param name = "objcc_PaperStuBatchQuesRela_TotalEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clscc_PaperStuBatchQuesRela_TotalEN objcc_PaperStuBatchQuesRela_TotalEN, string strWhereCond, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
bool bolResult = clscc_PaperStuBatchQuesRela_TotalBL.cc_PaperStuBatchQuesRela_TotalDA.UpdateBySqlWithConditionTransaction(objcc_PaperStuBatchQuesRela_TotalEN, strWhereCond, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clscc_PaperStuBatchQuesRela_TotalBL.ReFreshCache();

if (clscc_PaperStuBatchQuesRela_TotalBL.relatedActions != null)
{
clscc_PaperStuBatchQuesRela_TotalBL.relatedActions.UpdRelaTabDate(objcc_PaperStuBatchQuesRela_TotalEN.IdPaperStuBatchQuesRelaTotal, objcc_PaperStuBatchQuesRela_TotalEN.UpdUserId);
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
 /// <param name = "lngIdPaperStuBatchQuesRelaTotal">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int Delete(this clscc_PaperStuBatchQuesRela_TotalEN objcc_PaperStuBatchQuesRela_TotalEN)
{
try
{
int intRecNum = clscc_PaperStuBatchQuesRela_TotalBL.cc_PaperStuBatchQuesRela_TotalDA.DelRecord(objcc_PaperStuBatchQuesRela_TotalEN.IdPaperStuBatchQuesRelaTotal);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clscc_PaperStuBatchQuesRela_TotalBL.ReFreshCache();

if (clscc_PaperStuBatchQuesRela_TotalBL.relatedActions != null)
{
clscc_PaperStuBatchQuesRela_TotalBL.relatedActions.UpdRelaTabDate(objcc_PaperStuBatchQuesRela_TotalEN.IdPaperStuBatchQuesRelaTotal, objcc_PaperStuBatchQuesRela_TotalEN.UpdUserId);
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
 /// <param name = "objcc_PaperStuBatchQuesRela_TotalENS">源对象</param>
 /// <param name = "objcc_PaperStuBatchQuesRela_TotalENT">目标对象</param>
 public static void CopyTo(this clscc_PaperStuBatchQuesRela_TotalEN objcc_PaperStuBatchQuesRela_TotalENS, clscc_PaperStuBatchQuesRela_TotalEN objcc_PaperStuBatchQuesRela_TotalENT)
{
try
{
objcc_PaperStuBatchQuesRela_TotalENT.IdPaperStuBatchQuesRelaTotal = objcc_PaperStuBatchQuesRela_TotalENS.IdPaperStuBatchQuesRelaTotal; //学生试卷完成汇总流水号
objcc_PaperStuBatchQuesRela_TotalENT.IdPaperStuBatch = objcc_PaperStuBatchQuesRela_TotalENS.IdPaperStuBatch; //学生试卷批次流水号
objcc_PaperStuBatchQuesRela_TotalENT.QuesNum = objcc_PaperStuBatchQuesRela_TotalENS.QuesNum; //题目数
objcc_PaperStuBatchQuesRela_TotalENT.QuesNumLook = objcc_PaperStuBatchQuesRela_TotalENS.QuesNumLook; //查看题目数
objcc_PaperStuBatchQuesRela_TotalENT.QuesNumMark = objcc_PaperStuBatchQuesRela_TotalENS.QuesNumMark; //打分题目数
objcc_PaperStuBatchQuesRela_TotalENT.QuesNumNoFinish = objcc_PaperStuBatchQuesRela_TotalENS.QuesNumNoFinish; //未完成题目数
objcc_PaperStuBatchQuesRela_TotalENT.QuesNumOverdue = objcc_PaperStuBatchQuesRela_TotalENS.QuesNumOverdue; //逾期题目数
objcc_PaperStuBatchQuesRela_TotalENT.QuesNumSave = objcc_PaperStuBatchQuesRela_TotalENS.QuesNumSave; //保存题目数
objcc_PaperStuBatchQuesRela_TotalENT.QuesNumSendBack = objcc_PaperStuBatchQuesRela_TotalENS.QuesNumSendBack; //退回题目数
objcc_PaperStuBatchQuesRela_TotalENT.QuesNumSubmit = objcc_PaperStuBatchQuesRela_TotalENS.QuesNumSubmit; //提交题目数
objcc_PaperStuBatchQuesRela_TotalENT.TotalScore = objcc_PaperStuBatchQuesRela_TotalENS.TotalScore; //总得分
objcc_PaperStuBatchQuesRela_TotalENT.TotalScores = objcc_PaperStuBatchQuesRela_TotalENS.TotalScores; //总分值
objcc_PaperStuBatchQuesRela_TotalENT.SchoolYear = objcc_PaperStuBatchQuesRela_TotalENS.SchoolYear; //学年
objcc_PaperStuBatchQuesRela_TotalENT.SchoolTerm = objcc_PaperStuBatchQuesRela_TotalENS.SchoolTerm; //学期
objcc_PaperStuBatchQuesRela_TotalENT.UpdDate = objcc_PaperStuBatchQuesRela_TotalENS.UpdDate; //修改日期
objcc_PaperStuBatchQuesRela_TotalENT.UpdUserId = objcc_PaperStuBatchQuesRela_TotalENS.UpdUserId; //修改用户Id
objcc_PaperStuBatchQuesRela_TotalENT.Memo = objcc_PaperStuBatchQuesRela_TotalENS.Memo; //备注
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
 /// <param name = "objcc_PaperStuBatchQuesRela_TotalENS">源对象</param>
 /// <returns>目标对象=>clscc_PaperStuBatchQuesRela_TotalEN:objcc_PaperStuBatchQuesRela_TotalENT</returns>
 public static clscc_PaperStuBatchQuesRela_TotalEN CopyTo(this clscc_PaperStuBatchQuesRela_TotalEN objcc_PaperStuBatchQuesRela_TotalENS)
{
try
{
 clscc_PaperStuBatchQuesRela_TotalEN objcc_PaperStuBatchQuesRela_TotalENT = new clscc_PaperStuBatchQuesRela_TotalEN()
{
IdPaperStuBatchQuesRelaTotal = objcc_PaperStuBatchQuesRela_TotalENS.IdPaperStuBatchQuesRelaTotal, //学生试卷完成汇总流水号
IdPaperStuBatch = objcc_PaperStuBatchQuesRela_TotalENS.IdPaperStuBatch, //学生试卷批次流水号
QuesNum = objcc_PaperStuBatchQuesRela_TotalENS.QuesNum, //题目数
QuesNumLook = objcc_PaperStuBatchQuesRela_TotalENS.QuesNumLook, //查看题目数
QuesNumMark = objcc_PaperStuBatchQuesRela_TotalENS.QuesNumMark, //打分题目数
QuesNumNoFinish = objcc_PaperStuBatchQuesRela_TotalENS.QuesNumNoFinish, //未完成题目数
QuesNumOverdue = objcc_PaperStuBatchQuesRela_TotalENS.QuesNumOverdue, //逾期题目数
QuesNumSave = objcc_PaperStuBatchQuesRela_TotalENS.QuesNumSave, //保存题目数
QuesNumSendBack = objcc_PaperStuBatchQuesRela_TotalENS.QuesNumSendBack, //退回题目数
QuesNumSubmit = objcc_PaperStuBatchQuesRela_TotalENS.QuesNumSubmit, //提交题目数
TotalScore = objcc_PaperStuBatchQuesRela_TotalENS.TotalScore, //总得分
TotalScores = objcc_PaperStuBatchQuesRela_TotalENS.TotalScores, //总分值
SchoolYear = objcc_PaperStuBatchQuesRela_TotalENS.SchoolYear, //学年
SchoolTerm = objcc_PaperStuBatchQuesRela_TotalENS.SchoolTerm, //学期
UpdDate = objcc_PaperStuBatchQuesRela_TotalENS.UpdDate, //修改日期
UpdUserId = objcc_PaperStuBatchQuesRela_TotalENS.UpdUserId, //修改用户Id
Memo = objcc_PaperStuBatchQuesRela_TotalENS.Memo, //备注
};
 return objcc_PaperStuBatchQuesRela_TotalENT;
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
public static void CheckPropertyNew(this clscc_PaperStuBatchQuesRela_TotalEN objcc_PaperStuBatchQuesRela_TotalEN)
{
 clscc_PaperStuBatchQuesRela_TotalBL.cc_PaperStuBatchQuesRela_TotalDA.CheckPropertyNew(objcc_PaperStuBatchQuesRela_TotalEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(this clscc_PaperStuBatchQuesRela_TotalEN objcc_PaperStuBatchQuesRela_TotalEN)
{
 clscc_PaperStuBatchQuesRela_TotalBL.cc_PaperStuBatchQuesRela_TotalDA.CheckProperty4Condition(objcc_PaperStuBatchQuesRela_TotalEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clscc_PaperStuBatchQuesRela_TotalEN objcc_PaperStuBatchQuesRela_TotalCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objcc_PaperStuBatchQuesRela_TotalCond.IsUpdated(concc_PaperStuBatchQuesRela_Total.IdPaperStuBatchQuesRelaTotal) == true)
{
string strComparisonOpIdPaperStuBatchQuesRelaTotal = objcc_PaperStuBatchQuesRela_TotalCond.dicFldComparisonOp[concc_PaperStuBatchQuesRela_Total.IdPaperStuBatchQuesRelaTotal];
strWhereCond += string.Format(" And {0} {2} {1}", concc_PaperStuBatchQuesRela_Total.IdPaperStuBatchQuesRelaTotal, objcc_PaperStuBatchQuesRela_TotalCond.IdPaperStuBatchQuesRelaTotal, strComparisonOpIdPaperStuBatchQuesRelaTotal);
}
if (objcc_PaperStuBatchQuesRela_TotalCond.IsUpdated(concc_PaperStuBatchQuesRela_Total.IdPaperStuBatch) == true)
{
string strComparisonOpIdPaperStuBatch = objcc_PaperStuBatchQuesRela_TotalCond.dicFldComparisonOp[concc_PaperStuBatchQuesRela_Total.IdPaperStuBatch];
strWhereCond += string.Format(" And {0} {2} '{1}'", concc_PaperStuBatchQuesRela_Total.IdPaperStuBatch, objcc_PaperStuBatchQuesRela_TotalCond.IdPaperStuBatch, strComparisonOpIdPaperStuBatch);
}
if (objcc_PaperStuBatchQuesRela_TotalCond.IsUpdated(concc_PaperStuBatchQuesRela_Total.QuesNum) == true)
{
string strComparisonOpQuesNum = objcc_PaperStuBatchQuesRela_TotalCond.dicFldComparisonOp[concc_PaperStuBatchQuesRela_Total.QuesNum];
strWhereCond += string.Format(" And {0} {2} {1}", concc_PaperStuBatchQuesRela_Total.QuesNum, objcc_PaperStuBatchQuesRela_TotalCond.QuesNum, strComparisonOpQuesNum);
}
if (objcc_PaperStuBatchQuesRela_TotalCond.IsUpdated(concc_PaperStuBatchQuesRela_Total.QuesNumLook) == true)
{
string strComparisonOpQuesNumLook = objcc_PaperStuBatchQuesRela_TotalCond.dicFldComparisonOp[concc_PaperStuBatchQuesRela_Total.QuesNumLook];
strWhereCond += string.Format(" And {0} {2} {1}", concc_PaperStuBatchQuesRela_Total.QuesNumLook, objcc_PaperStuBatchQuesRela_TotalCond.QuesNumLook, strComparisonOpQuesNumLook);
}
if (objcc_PaperStuBatchQuesRela_TotalCond.IsUpdated(concc_PaperStuBatchQuesRela_Total.QuesNumMark) == true)
{
string strComparisonOpQuesNumMark = objcc_PaperStuBatchQuesRela_TotalCond.dicFldComparisonOp[concc_PaperStuBatchQuesRela_Total.QuesNumMark];
strWhereCond += string.Format(" And {0} {2} {1}", concc_PaperStuBatchQuesRela_Total.QuesNumMark, objcc_PaperStuBatchQuesRela_TotalCond.QuesNumMark, strComparisonOpQuesNumMark);
}
if (objcc_PaperStuBatchQuesRela_TotalCond.IsUpdated(concc_PaperStuBatchQuesRela_Total.QuesNumNoFinish) == true)
{
string strComparisonOpQuesNumNoFinish = objcc_PaperStuBatchQuesRela_TotalCond.dicFldComparisonOp[concc_PaperStuBatchQuesRela_Total.QuesNumNoFinish];
strWhereCond += string.Format(" And {0} {2} {1}", concc_PaperStuBatchQuesRela_Total.QuesNumNoFinish, objcc_PaperStuBatchQuesRela_TotalCond.QuesNumNoFinish, strComparisonOpQuesNumNoFinish);
}
if (objcc_PaperStuBatchQuesRela_TotalCond.IsUpdated(concc_PaperStuBatchQuesRela_Total.QuesNumOverdue) == true)
{
string strComparisonOpQuesNumOverdue = objcc_PaperStuBatchQuesRela_TotalCond.dicFldComparisonOp[concc_PaperStuBatchQuesRela_Total.QuesNumOverdue];
strWhereCond += string.Format(" And {0} {2} {1}", concc_PaperStuBatchQuesRela_Total.QuesNumOverdue, objcc_PaperStuBatchQuesRela_TotalCond.QuesNumOverdue, strComparisonOpQuesNumOverdue);
}
if (objcc_PaperStuBatchQuesRela_TotalCond.IsUpdated(concc_PaperStuBatchQuesRela_Total.QuesNumSave) == true)
{
string strComparisonOpQuesNumSave = objcc_PaperStuBatchQuesRela_TotalCond.dicFldComparisonOp[concc_PaperStuBatchQuesRela_Total.QuesNumSave];
strWhereCond += string.Format(" And {0} {2} {1}", concc_PaperStuBatchQuesRela_Total.QuesNumSave, objcc_PaperStuBatchQuesRela_TotalCond.QuesNumSave, strComparisonOpQuesNumSave);
}
if (objcc_PaperStuBatchQuesRela_TotalCond.IsUpdated(concc_PaperStuBatchQuesRela_Total.QuesNumSendBack) == true)
{
string strComparisonOpQuesNumSendBack = objcc_PaperStuBatchQuesRela_TotalCond.dicFldComparisonOp[concc_PaperStuBatchQuesRela_Total.QuesNumSendBack];
strWhereCond += string.Format(" And {0} {2} {1}", concc_PaperStuBatchQuesRela_Total.QuesNumSendBack, objcc_PaperStuBatchQuesRela_TotalCond.QuesNumSendBack, strComparisonOpQuesNumSendBack);
}
if (objcc_PaperStuBatchQuesRela_TotalCond.IsUpdated(concc_PaperStuBatchQuesRela_Total.QuesNumSubmit) == true)
{
string strComparisonOpQuesNumSubmit = objcc_PaperStuBatchQuesRela_TotalCond.dicFldComparisonOp[concc_PaperStuBatchQuesRela_Total.QuesNumSubmit];
strWhereCond += string.Format(" And {0} {2} {1}", concc_PaperStuBatchQuesRela_Total.QuesNumSubmit, objcc_PaperStuBatchQuesRela_TotalCond.QuesNumSubmit, strComparisonOpQuesNumSubmit);
}
if (objcc_PaperStuBatchQuesRela_TotalCond.IsUpdated(concc_PaperStuBatchQuesRela_Total.TotalScore) == true)
{
string strComparisonOpTotalScore = objcc_PaperStuBatchQuesRela_TotalCond.dicFldComparisonOp[concc_PaperStuBatchQuesRela_Total.TotalScore];
strWhereCond += string.Format(" And {0} {2} {1}", concc_PaperStuBatchQuesRela_Total.TotalScore, objcc_PaperStuBatchQuesRela_TotalCond.TotalScore, strComparisonOpTotalScore);
}
if (objcc_PaperStuBatchQuesRela_TotalCond.IsUpdated(concc_PaperStuBatchQuesRela_Total.TotalScores) == true)
{
string strComparisonOpTotalScores = objcc_PaperStuBatchQuesRela_TotalCond.dicFldComparisonOp[concc_PaperStuBatchQuesRela_Total.TotalScores];
strWhereCond += string.Format(" And {0} {2} {1}", concc_PaperStuBatchQuesRela_Total.TotalScores, objcc_PaperStuBatchQuesRela_TotalCond.TotalScores, strComparisonOpTotalScores);
}
if (objcc_PaperStuBatchQuesRela_TotalCond.IsUpdated(concc_PaperStuBatchQuesRela_Total.SchoolYear) == true)
{
string strComparisonOpSchoolYear = objcc_PaperStuBatchQuesRela_TotalCond.dicFldComparisonOp[concc_PaperStuBatchQuesRela_Total.SchoolYear];
strWhereCond += string.Format(" And {0} {2} '{1}'", concc_PaperStuBatchQuesRela_Total.SchoolYear, objcc_PaperStuBatchQuesRela_TotalCond.SchoolYear, strComparisonOpSchoolYear);
}
if (objcc_PaperStuBatchQuesRela_TotalCond.IsUpdated(concc_PaperStuBatchQuesRela_Total.SchoolTerm) == true)
{
string strComparisonOpSchoolTerm = objcc_PaperStuBatchQuesRela_TotalCond.dicFldComparisonOp[concc_PaperStuBatchQuesRela_Total.SchoolTerm];
strWhereCond += string.Format(" And {0} {2} '{1}'", concc_PaperStuBatchQuesRela_Total.SchoolTerm, objcc_PaperStuBatchQuesRela_TotalCond.SchoolTerm, strComparisonOpSchoolTerm);
}
if (objcc_PaperStuBatchQuesRela_TotalCond.IsUpdated(concc_PaperStuBatchQuesRela_Total.UpdDate) == true)
{
string strComparisonOpUpdDate = objcc_PaperStuBatchQuesRela_TotalCond.dicFldComparisonOp[concc_PaperStuBatchQuesRela_Total.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", concc_PaperStuBatchQuesRela_Total.UpdDate, objcc_PaperStuBatchQuesRela_TotalCond.UpdDate, strComparisonOpUpdDate);
}
if (objcc_PaperStuBatchQuesRela_TotalCond.IsUpdated(concc_PaperStuBatchQuesRela_Total.UpdUserId) == true)
{
string strComparisonOpUpdUserId = objcc_PaperStuBatchQuesRela_TotalCond.dicFldComparisonOp[concc_PaperStuBatchQuesRela_Total.UpdUserId];
strWhereCond += string.Format(" And {0} {2} '{1}'", concc_PaperStuBatchQuesRela_Total.UpdUserId, objcc_PaperStuBatchQuesRela_TotalCond.UpdUserId, strComparisonOpUpdUserId);
}
if (objcc_PaperStuBatchQuesRela_TotalCond.IsUpdated(concc_PaperStuBatchQuesRela_Total.Memo) == true)
{
string strComparisonOpMemo = objcc_PaperStuBatchQuesRela_TotalCond.dicFldComparisonOp[concc_PaperStuBatchQuesRela_Total.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", concc_PaperStuBatchQuesRela_Total.Memo, objcc_PaperStuBatchQuesRela_TotalCond.Memo, strComparisonOpMemo);
}
 return strWhereCond;
}

 /// <summary>
 /// 检查唯一性(Uniqueness)--cc_PaperStuBatchQuesRela_Total(学生试卷完成汇总), 如果不唯一,即存在相同的记录,就返回False
 /// 唯一性条件:Id_PaperStuBatch_SchoolTerm_SchoolYear
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckConstraint)
 /// </summary>
 /// <param name = "objcc_PaperStuBatchQuesRela_TotalEN">要求唯一的对象</param>
 /// <returns></returns>
public static bool CheckUniqueness(this clscc_PaperStuBatchQuesRela_TotalEN objcc_PaperStuBatchQuesRela_TotalEN)
{
//检测记录是否存在
bool bolIsUniqueness;
StringBuilder sbCondition = new StringBuilder();
if (objcc_PaperStuBatchQuesRela_TotalEN == null) return true;
if (objcc_PaperStuBatchQuesRela_TotalEN.IdPaperStuBatchQuesRelaTotal == 0)
{
sbCondition.AppendFormat("1 = 1");
 if (objcc_PaperStuBatchQuesRela_TotalEN.IdPaperStuBatch == null)
{
 sbCondition.AppendFormat(" and IdPaperStuBatch is null", objcc_PaperStuBatchQuesRela_TotalEN.IdPaperStuBatch);
}
else
{
 sbCondition.AppendFormat(" and IdPaperStuBatch = '{0}'", objcc_PaperStuBatchQuesRela_TotalEN.IdPaperStuBatch);
}
 if (objcc_PaperStuBatchQuesRela_TotalEN.SchoolTerm == null)
{
 sbCondition.AppendFormat(" and SchoolTerm is null", objcc_PaperStuBatchQuesRela_TotalEN.SchoolTerm);
}
else
{
 sbCondition.AppendFormat(" and SchoolTerm = '{0}'", objcc_PaperStuBatchQuesRela_TotalEN.SchoolTerm);
}
 if (objcc_PaperStuBatchQuesRela_TotalEN.SchoolYear == null)
{
 sbCondition.AppendFormat(" and SchoolYear is null", objcc_PaperStuBatchQuesRela_TotalEN.SchoolYear);
}
else
{
 sbCondition.AppendFormat(" and SchoolYear = '{0}'", objcc_PaperStuBatchQuesRela_TotalEN.SchoolYear);
}
if (clscc_PaperStuBatchQuesRela_TotalBL.IsExistRecord(sbCondition.ToString())  ==  true)
{
 bolIsUniqueness = false;
}
else
{
 bolIsUniqueness = true;
}
}
 else {
sbCondition.AppendFormat("IdPaperStuBatchQuesRelaTotal !=  {0}", objcc_PaperStuBatchQuesRela_TotalEN.IdPaperStuBatchQuesRelaTotal);
 sbCondition.AppendFormat(" and IdPaperStuBatch = '{0}'", objcc_PaperStuBatchQuesRela_TotalEN.IdPaperStuBatch);
 sbCondition.AppendFormat(" and SchoolTerm = '{0}'", objcc_PaperStuBatchQuesRela_TotalEN.SchoolTerm);
 sbCondition.AppendFormat(" and SchoolYear = '{0}'", objcc_PaperStuBatchQuesRela_TotalEN.SchoolYear);
if (clscc_PaperStuBatchQuesRela_TotalBL.IsExistRecord(sbCondition.ToString())  ==  true)
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
 /// 获取唯一性条件串--cc_PaperStuBatchQuesRela_Total(学生试卷完成汇总), 即由对象中唯一性条件字段关键字与值组成的条件串
 /// 唯一性条件:Id_PaperStuBatch_SchoolTerm_SchoolYear
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetConditionString4Constraint)
 /// </summary>
 /// <param name = "objcc_PaperStuBatchQuesRela_TotalEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(this clscc_PaperStuBatchQuesRela_TotalEN objcc_PaperStuBatchQuesRela_TotalEN)
{
//检测记录是否存在
StringBuilder sbCondition = new StringBuilder();
if (objcc_PaperStuBatchQuesRela_TotalEN == null) return "";
if (objcc_PaperStuBatchQuesRela_TotalEN.IdPaperStuBatchQuesRelaTotal == 0)
{
sbCondition.AppendFormat("1 = 1");
 if (objcc_PaperStuBatchQuesRela_TotalEN.IdPaperStuBatch == null)
{
 sbCondition.AppendFormat(" and IdPaperStuBatch is null", objcc_PaperStuBatchQuesRela_TotalEN.IdPaperStuBatch);
}
else
{
 sbCondition.AppendFormat(" and IdPaperStuBatch = '{0}'", objcc_PaperStuBatchQuesRela_TotalEN.IdPaperStuBatch);
}
 if (objcc_PaperStuBatchQuesRela_TotalEN.SchoolTerm == null)
{
 sbCondition.AppendFormat(" and SchoolTerm is null", objcc_PaperStuBatchQuesRela_TotalEN.SchoolTerm);
}
else
{
 sbCondition.AppendFormat(" and SchoolTerm = '{0}'", objcc_PaperStuBatchQuesRela_TotalEN.SchoolTerm);
}
 if (objcc_PaperStuBatchQuesRela_TotalEN.SchoolYear == null)
{
 sbCondition.AppendFormat(" and SchoolYear is null", objcc_PaperStuBatchQuesRela_TotalEN.SchoolYear);
}
else
{
 sbCondition.AppendFormat(" and SchoolYear = '{0}'", objcc_PaperStuBatchQuesRela_TotalEN.SchoolYear);
}
return sbCondition.ToString();
}
 else {
sbCondition.AppendFormat("IdPaperStuBatchQuesRelaTotal !=  {0}", objcc_PaperStuBatchQuesRela_TotalEN.IdPaperStuBatchQuesRelaTotal);
 sbCondition.AppendFormat(" and IdPaperStuBatch = '{0}'", objcc_PaperStuBatchQuesRela_TotalEN.IdPaperStuBatch);
 sbCondition.AppendFormat(" and SchoolTerm = '{0}'", objcc_PaperStuBatchQuesRela_TotalEN.SchoolTerm);
 sbCondition.AppendFormat(" and SchoolYear = '{0}'", objcc_PaperStuBatchQuesRela_TotalEN.SchoolYear);
 return sbCondition.ToString();
}
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_cc_PaperStuBatchQuesRela_Total
{
public virtual bool UpdRelaTabDate(long lngIdPaperStuBatchQuesRelaTotal, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// 学生试卷完成汇总(cc_PaperStuBatchQuesRela_Total)
 /// 数据源类型:表
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clscc_PaperStuBatchQuesRela_TotalBL
{
public static RelatedActions_cc_PaperStuBatchQuesRela_Total relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clscc_PaperStuBatchQuesRela_TotalDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clscc_PaperStuBatchQuesRela_TotalDA cc_PaperStuBatchQuesRela_TotalDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clscc_PaperStuBatchQuesRela_TotalDA();
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
 public clscc_PaperStuBatchQuesRela_TotalBL()
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
if (string.IsNullOrEmpty(clscc_PaperStuBatchQuesRela_TotalEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clscc_PaperStuBatchQuesRela_TotalEN._ConnectString);
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
public static DataTable GetDataTable_cc_PaperStuBatchQuesRela_Total(string strWhereCond)
{
DataTable objDT;
try
{
objDT = cc_PaperStuBatchQuesRela_TotalDA.GetDataTable_cc_PaperStuBatchQuesRela_Total(strWhereCond);
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
objDT = cc_PaperStuBatchQuesRela_TotalDA.GetDataTable(strWhereCond);
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
objDT = cc_PaperStuBatchQuesRela_TotalDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = cc_PaperStuBatchQuesRela_TotalDA.GetDataTable(strWhereCond, strTabName);
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
objDT = cc_PaperStuBatchQuesRela_TotalDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = cc_PaperStuBatchQuesRela_TotalDA.GetDataTable_Top(objTopPara);
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
objDT = cc_PaperStuBatchQuesRela_TotalDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = cc_PaperStuBatchQuesRela_TotalDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = cc_PaperStuBatchQuesRela_TotalDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
 /// <param name = "arrIdPaperStuBatchQuesRelaTotalLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static List<clscc_PaperStuBatchQuesRela_TotalEN> GetObjLstByIdPaperStuBatchQuesRelaTotalLst(List<long> arrIdPaperStuBatchQuesRelaTotalLst)
{
List<clscc_PaperStuBatchQuesRela_TotalEN> arrObjLst = new List<clscc_PaperStuBatchQuesRela_TotalEN>(); 
System.Data.DataTable objDT; 
 string strSqlConditionStr = clsArray.GetSqlInStrByArray(arrIdPaperStuBatchQuesRelaTotalLst);
 string strWhereCond = string.Format("IdPaperStuBatchQuesRelaTotal in ({0})", strSqlConditionStr);
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clscc_PaperStuBatchQuesRela_TotalEN objcc_PaperStuBatchQuesRela_TotalEN = new clscc_PaperStuBatchQuesRela_TotalEN();
try
{
objcc_PaperStuBatchQuesRela_TotalEN.IdPaperStuBatchQuesRelaTotal = Int32.Parse(objRow[concc_PaperStuBatchQuesRela_Total.IdPaperStuBatchQuesRelaTotal].ToString().Trim()); //学生试卷完成汇总流水号
objcc_PaperStuBatchQuesRela_TotalEN.IdPaperStuBatch = objRow[concc_PaperStuBatchQuesRela_Total.IdPaperStuBatch] == DBNull.Value ? null : objRow[concc_PaperStuBatchQuesRela_Total.IdPaperStuBatch].ToString().Trim(); //学生试卷批次流水号
objcc_PaperStuBatchQuesRela_TotalEN.QuesNum = Int32.Parse(objRow[concc_PaperStuBatchQuesRela_Total.QuesNum].ToString().Trim()); //题目数
objcc_PaperStuBatchQuesRela_TotalEN.QuesNumLook = objRow[concc_PaperStuBatchQuesRela_Total.QuesNumLook] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[concc_PaperStuBatchQuesRela_Total.QuesNumLook].ToString().Trim()); //查看题目数
objcc_PaperStuBatchQuesRela_TotalEN.QuesNumMark = objRow[concc_PaperStuBatchQuesRela_Total.QuesNumMark] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[concc_PaperStuBatchQuesRela_Total.QuesNumMark].ToString().Trim()); //打分题目数
objcc_PaperStuBatchQuesRela_TotalEN.QuesNumNoFinish = objRow[concc_PaperStuBatchQuesRela_Total.QuesNumNoFinish] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[concc_PaperStuBatchQuesRela_Total.QuesNumNoFinish].ToString().Trim()); //未完成题目数
objcc_PaperStuBatchQuesRela_TotalEN.QuesNumOverdue = objRow[concc_PaperStuBatchQuesRela_Total.QuesNumOverdue] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[concc_PaperStuBatchQuesRela_Total.QuesNumOverdue].ToString().Trim()); //逾期题目数
objcc_PaperStuBatchQuesRela_TotalEN.QuesNumSave = objRow[concc_PaperStuBatchQuesRela_Total.QuesNumSave] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[concc_PaperStuBatchQuesRela_Total.QuesNumSave].ToString().Trim()); //保存题目数
objcc_PaperStuBatchQuesRela_TotalEN.QuesNumSendBack = objRow[concc_PaperStuBatchQuesRela_Total.QuesNumSendBack] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[concc_PaperStuBatchQuesRela_Total.QuesNumSendBack].ToString().Trim()); //退回题目数
objcc_PaperStuBatchQuesRela_TotalEN.QuesNumSubmit = objRow[concc_PaperStuBatchQuesRela_Total.QuesNumSubmit] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[concc_PaperStuBatchQuesRela_Total.QuesNumSubmit].ToString().Trim()); //提交题目数
objcc_PaperStuBatchQuesRela_TotalEN.TotalScore = objRow[concc_PaperStuBatchQuesRela_Total.TotalScore] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[concc_PaperStuBatchQuesRela_Total.TotalScore].ToString().Trim()); //总得分
objcc_PaperStuBatchQuesRela_TotalEN.TotalScores = objRow[concc_PaperStuBatchQuesRela_Total.TotalScores] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[concc_PaperStuBatchQuesRela_Total.TotalScores].ToString().Trim()); //总分值
objcc_PaperStuBatchQuesRela_TotalEN.SchoolYear = objRow[concc_PaperStuBatchQuesRela_Total.SchoolYear] == DBNull.Value ? null : objRow[concc_PaperStuBatchQuesRela_Total.SchoolYear].ToString().Trim(); //学年
objcc_PaperStuBatchQuesRela_TotalEN.SchoolTerm = objRow[concc_PaperStuBatchQuesRela_Total.SchoolTerm] == DBNull.Value ? null : objRow[concc_PaperStuBatchQuesRela_Total.SchoolTerm].ToString().Trim(); //学期
objcc_PaperStuBatchQuesRela_TotalEN.UpdDate = objRow[concc_PaperStuBatchQuesRela_Total.UpdDate].ToString().Trim(); //修改日期
objcc_PaperStuBatchQuesRela_TotalEN.UpdUserId = objRow[concc_PaperStuBatchQuesRela_Total.UpdUserId] == DBNull.Value ? null : objRow[concc_PaperStuBatchQuesRela_Total.UpdUserId].ToString().Trim(); //修改用户Id
objcc_PaperStuBatchQuesRela_TotalEN.Memo = objRow[concc_PaperStuBatchQuesRela_Total.Memo] == DBNull.Value ? null : objRow[concc_PaperStuBatchQuesRela_Total.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objcc_PaperStuBatchQuesRela_TotalEN.IdPaperStuBatchQuesRelaTotal, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objcc_PaperStuBatchQuesRela_TotalEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrIdPaperStuBatchQuesRelaTotalLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clscc_PaperStuBatchQuesRela_TotalEN> GetObjLstByIdPaperStuBatchQuesRelaTotalLstCache(List<long> arrIdPaperStuBatchQuesRelaTotalLst)
{
string strKey = string.Format("{0}", clscc_PaperStuBatchQuesRela_TotalEN._CurrTabName);
List<clscc_PaperStuBatchQuesRela_TotalEN> arrcc_PaperStuBatchQuesRela_TotalObjLstCache = GetObjLstCache();
IEnumerable <clscc_PaperStuBatchQuesRela_TotalEN> arrcc_PaperStuBatchQuesRela_TotalObjLst_Sel =
arrcc_PaperStuBatchQuesRela_TotalObjLstCache
.Where(x => arrIdPaperStuBatchQuesRelaTotalLst.Contains(x.IdPaperStuBatchQuesRelaTotal));
return arrcc_PaperStuBatchQuesRela_TotalObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clscc_PaperStuBatchQuesRela_TotalEN> GetObjLst(string strWhereCond)
{
List<clscc_PaperStuBatchQuesRela_TotalEN> arrObjLst = new List<clscc_PaperStuBatchQuesRela_TotalEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clscc_PaperStuBatchQuesRela_TotalEN objcc_PaperStuBatchQuesRela_TotalEN = new clscc_PaperStuBatchQuesRela_TotalEN();
try
{
objcc_PaperStuBatchQuesRela_TotalEN.IdPaperStuBatchQuesRelaTotal = Int32.Parse(objRow[concc_PaperStuBatchQuesRela_Total.IdPaperStuBatchQuesRelaTotal].ToString().Trim()); //学生试卷完成汇总流水号
objcc_PaperStuBatchQuesRela_TotalEN.IdPaperStuBatch = objRow[concc_PaperStuBatchQuesRela_Total.IdPaperStuBatch] == DBNull.Value ? null : objRow[concc_PaperStuBatchQuesRela_Total.IdPaperStuBatch].ToString().Trim(); //学生试卷批次流水号
objcc_PaperStuBatchQuesRela_TotalEN.QuesNum = Int32.Parse(objRow[concc_PaperStuBatchQuesRela_Total.QuesNum].ToString().Trim()); //题目数
objcc_PaperStuBatchQuesRela_TotalEN.QuesNumLook = objRow[concc_PaperStuBatchQuesRela_Total.QuesNumLook] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[concc_PaperStuBatchQuesRela_Total.QuesNumLook].ToString().Trim()); //查看题目数
objcc_PaperStuBatchQuesRela_TotalEN.QuesNumMark = objRow[concc_PaperStuBatchQuesRela_Total.QuesNumMark] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[concc_PaperStuBatchQuesRela_Total.QuesNumMark].ToString().Trim()); //打分题目数
objcc_PaperStuBatchQuesRela_TotalEN.QuesNumNoFinish = objRow[concc_PaperStuBatchQuesRela_Total.QuesNumNoFinish] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[concc_PaperStuBatchQuesRela_Total.QuesNumNoFinish].ToString().Trim()); //未完成题目数
objcc_PaperStuBatchQuesRela_TotalEN.QuesNumOverdue = objRow[concc_PaperStuBatchQuesRela_Total.QuesNumOverdue] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[concc_PaperStuBatchQuesRela_Total.QuesNumOverdue].ToString().Trim()); //逾期题目数
objcc_PaperStuBatchQuesRela_TotalEN.QuesNumSave = objRow[concc_PaperStuBatchQuesRela_Total.QuesNumSave] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[concc_PaperStuBatchQuesRela_Total.QuesNumSave].ToString().Trim()); //保存题目数
objcc_PaperStuBatchQuesRela_TotalEN.QuesNumSendBack = objRow[concc_PaperStuBatchQuesRela_Total.QuesNumSendBack] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[concc_PaperStuBatchQuesRela_Total.QuesNumSendBack].ToString().Trim()); //退回题目数
objcc_PaperStuBatchQuesRela_TotalEN.QuesNumSubmit = objRow[concc_PaperStuBatchQuesRela_Total.QuesNumSubmit] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[concc_PaperStuBatchQuesRela_Total.QuesNumSubmit].ToString().Trim()); //提交题目数
objcc_PaperStuBatchQuesRela_TotalEN.TotalScore = objRow[concc_PaperStuBatchQuesRela_Total.TotalScore] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[concc_PaperStuBatchQuesRela_Total.TotalScore].ToString().Trim()); //总得分
objcc_PaperStuBatchQuesRela_TotalEN.TotalScores = objRow[concc_PaperStuBatchQuesRela_Total.TotalScores] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[concc_PaperStuBatchQuesRela_Total.TotalScores].ToString().Trim()); //总分值
objcc_PaperStuBatchQuesRela_TotalEN.SchoolYear = objRow[concc_PaperStuBatchQuesRela_Total.SchoolYear] == DBNull.Value ? null : objRow[concc_PaperStuBatchQuesRela_Total.SchoolYear].ToString().Trim(); //学年
objcc_PaperStuBatchQuesRela_TotalEN.SchoolTerm = objRow[concc_PaperStuBatchQuesRela_Total.SchoolTerm] == DBNull.Value ? null : objRow[concc_PaperStuBatchQuesRela_Total.SchoolTerm].ToString().Trim(); //学期
objcc_PaperStuBatchQuesRela_TotalEN.UpdDate = objRow[concc_PaperStuBatchQuesRela_Total.UpdDate].ToString().Trim(); //修改日期
objcc_PaperStuBatchQuesRela_TotalEN.UpdUserId = objRow[concc_PaperStuBatchQuesRela_Total.UpdUserId] == DBNull.Value ? null : objRow[concc_PaperStuBatchQuesRela_Total.UpdUserId].ToString().Trim(); //修改用户Id
objcc_PaperStuBatchQuesRela_TotalEN.Memo = objRow[concc_PaperStuBatchQuesRela_Total.Memo] == DBNull.Value ? null : objRow[concc_PaperStuBatchQuesRela_Total.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objcc_PaperStuBatchQuesRela_TotalEN.IdPaperStuBatchQuesRelaTotal, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objcc_PaperStuBatchQuesRela_TotalEN);
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
public static List<clscc_PaperStuBatchQuesRela_TotalEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clscc_PaperStuBatchQuesRela_TotalEN> arrObjLst = new List<clscc_PaperStuBatchQuesRela_TotalEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clscc_PaperStuBatchQuesRela_TotalEN objcc_PaperStuBatchQuesRela_TotalEN = new clscc_PaperStuBatchQuesRela_TotalEN();
try
{
objcc_PaperStuBatchQuesRela_TotalEN.IdPaperStuBatchQuesRelaTotal = Int32.Parse(objRow[concc_PaperStuBatchQuesRela_Total.IdPaperStuBatchQuesRelaTotal].ToString().Trim()); //学生试卷完成汇总流水号
objcc_PaperStuBatchQuesRela_TotalEN.IdPaperStuBatch = objRow[concc_PaperStuBatchQuesRela_Total.IdPaperStuBatch] == DBNull.Value ? null : objRow[concc_PaperStuBatchQuesRela_Total.IdPaperStuBatch].ToString().Trim(); //学生试卷批次流水号
objcc_PaperStuBatchQuesRela_TotalEN.QuesNum = Int32.Parse(objRow[concc_PaperStuBatchQuesRela_Total.QuesNum].ToString().Trim()); //题目数
objcc_PaperStuBatchQuesRela_TotalEN.QuesNumLook = objRow[concc_PaperStuBatchQuesRela_Total.QuesNumLook] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[concc_PaperStuBatchQuesRela_Total.QuesNumLook].ToString().Trim()); //查看题目数
objcc_PaperStuBatchQuesRela_TotalEN.QuesNumMark = objRow[concc_PaperStuBatchQuesRela_Total.QuesNumMark] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[concc_PaperStuBatchQuesRela_Total.QuesNumMark].ToString().Trim()); //打分题目数
objcc_PaperStuBatchQuesRela_TotalEN.QuesNumNoFinish = objRow[concc_PaperStuBatchQuesRela_Total.QuesNumNoFinish] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[concc_PaperStuBatchQuesRela_Total.QuesNumNoFinish].ToString().Trim()); //未完成题目数
objcc_PaperStuBatchQuesRela_TotalEN.QuesNumOverdue = objRow[concc_PaperStuBatchQuesRela_Total.QuesNumOverdue] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[concc_PaperStuBatchQuesRela_Total.QuesNumOverdue].ToString().Trim()); //逾期题目数
objcc_PaperStuBatchQuesRela_TotalEN.QuesNumSave = objRow[concc_PaperStuBatchQuesRela_Total.QuesNumSave] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[concc_PaperStuBatchQuesRela_Total.QuesNumSave].ToString().Trim()); //保存题目数
objcc_PaperStuBatchQuesRela_TotalEN.QuesNumSendBack = objRow[concc_PaperStuBatchQuesRela_Total.QuesNumSendBack] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[concc_PaperStuBatchQuesRela_Total.QuesNumSendBack].ToString().Trim()); //退回题目数
objcc_PaperStuBatchQuesRela_TotalEN.QuesNumSubmit = objRow[concc_PaperStuBatchQuesRela_Total.QuesNumSubmit] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[concc_PaperStuBatchQuesRela_Total.QuesNumSubmit].ToString().Trim()); //提交题目数
objcc_PaperStuBatchQuesRela_TotalEN.TotalScore = objRow[concc_PaperStuBatchQuesRela_Total.TotalScore] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[concc_PaperStuBatchQuesRela_Total.TotalScore].ToString().Trim()); //总得分
objcc_PaperStuBatchQuesRela_TotalEN.TotalScores = objRow[concc_PaperStuBatchQuesRela_Total.TotalScores] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[concc_PaperStuBatchQuesRela_Total.TotalScores].ToString().Trim()); //总分值
objcc_PaperStuBatchQuesRela_TotalEN.SchoolYear = objRow[concc_PaperStuBatchQuesRela_Total.SchoolYear] == DBNull.Value ? null : objRow[concc_PaperStuBatchQuesRela_Total.SchoolYear].ToString().Trim(); //学年
objcc_PaperStuBatchQuesRela_TotalEN.SchoolTerm = objRow[concc_PaperStuBatchQuesRela_Total.SchoolTerm] == DBNull.Value ? null : objRow[concc_PaperStuBatchQuesRela_Total.SchoolTerm].ToString().Trim(); //学期
objcc_PaperStuBatchQuesRela_TotalEN.UpdDate = objRow[concc_PaperStuBatchQuesRela_Total.UpdDate].ToString().Trim(); //修改日期
objcc_PaperStuBatchQuesRela_TotalEN.UpdUserId = objRow[concc_PaperStuBatchQuesRela_Total.UpdUserId] == DBNull.Value ? null : objRow[concc_PaperStuBatchQuesRela_Total.UpdUserId].ToString().Trim(); //修改用户Id
objcc_PaperStuBatchQuesRela_TotalEN.Memo = objRow[concc_PaperStuBatchQuesRela_Total.Memo] == DBNull.Value ? null : objRow[concc_PaperStuBatchQuesRela_Total.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objcc_PaperStuBatchQuesRela_TotalEN.IdPaperStuBatchQuesRelaTotal, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objcc_PaperStuBatchQuesRela_TotalEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objcc_PaperStuBatchQuesRela_TotalCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clscc_PaperStuBatchQuesRela_TotalEN> GetSubObjLstCache(clscc_PaperStuBatchQuesRela_TotalEN objcc_PaperStuBatchQuesRela_TotalCond)
{
List<clscc_PaperStuBatchQuesRela_TotalEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clscc_PaperStuBatchQuesRela_TotalEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in concc_PaperStuBatchQuesRela_Total.AttributeName)
{
if (objcc_PaperStuBatchQuesRela_TotalCond.IsUpdated(strFldName) == false) continue;
if (objcc_PaperStuBatchQuesRela_TotalCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objcc_PaperStuBatchQuesRela_TotalCond[strFldName].ToString());
}
else
{
if (objcc_PaperStuBatchQuesRela_TotalCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objcc_PaperStuBatchQuesRela_TotalCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objcc_PaperStuBatchQuesRela_TotalCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objcc_PaperStuBatchQuesRela_TotalCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objcc_PaperStuBatchQuesRela_TotalCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objcc_PaperStuBatchQuesRela_TotalCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objcc_PaperStuBatchQuesRela_TotalCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objcc_PaperStuBatchQuesRela_TotalCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objcc_PaperStuBatchQuesRela_TotalCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objcc_PaperStuBatchQuesRela_TotalCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objcc_PaperStuBatchQuesRela_TotalCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objcc_PaperStuBatchQuesRela_TotalCond[strFldName]));
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
public static List<clscc_PaperStuBatchQuesRela_TotalEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clscc_PaperStuBatchQuesRela_TotalEN> arrObjLst = new List<clscc_PaperStuBatchQuesRela_TotalEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clscc_PaperStuBatchQuesRela_TotalEN objcc_PaperStuBatchQuesRela_TotalEN = new clscc_PaperStuBatchQuesRela_TotalEN();
try
{
objcc_PaperStuBatchQuesRela_TotalEN.IdPaperStuBatchQuesRelaTotal = Int32.Parse(objRow[concc_PaperStuBatchQuesRela_Total.IdPaperStuBatchQuesRelaTotal].ToString().Trim()); //学生试卷完成汇总流水号
objcc_PaperStuBatchQuesRela_TotalEN.IdPaperStuBatch = objRow[concc_PaperStuBatchQuesRela_Total.IdPaperStuBatch] == DBNull.Value ? null : objRow[concc_PaperStuBatchQuesRela_Total.IdPaperStuBatch].ToString().Trim(); //学生试卷批次流水号
objcc_PaperStuBatchQuesRela_TotalEN.QuesNum = Int32.Parse(objRow[concc_PaperStuBatchQuesRela_Total.QuesNum].ToString().Trim()); //题目数
objcc_PaperStuBatchQuesRela_TotalEN.QuesNumLook = objRow[concc_PaperStuBatchQuesRela_Total.QuesNumLook] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[concc_PaperStuBatchQuesRela_Total.QuesNumLook].ToString().Trim()); //查看题目数
objcc_PaperStuBatchQuesRela_TotalEN.QuesNumMark = objRow[concc_PaperStuBatchQuesRela_Total.QuesNumMark] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[concc_PaperStuBatchQuesRela_Total.QuesNumMark].ToString().Trim()); //打分题目数
objcc_PaperStuBatchQuesRela_TotalEN.QuesNumNoFinish = objRow[concc_PaperStuBatchQuesRela_Total.QuesNumNoFinish] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[concc_PaperStuBatchQuesRela_Total.QuesNumNoFinish].ToString().Trim()); //未完成题目数
objcc_PaperStuBatchQuesRela_TotalEN.QuesNumOverdue = objRow[concc_PaperStuBatchQuesRela_Total.QuesNumOverdue] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[concc_PaperStuBatchQuesRela_Total.QuesNumOverdue].ToString().Trim()); //逾期题目数
objcc_PaperStuBatchQuesRela_TotalEN.QuesNumSave = objRow[concc_PaperStuBatchQuesRela_Total.QuesNumSave] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[concc_PaperStuBatchQuesRela_Total.QuesNumSave].ToString().Trim()); //保存题目数
objcc_PaperStuBatchQuesRela_TotalEN.QuesNumSendBack = objRow[concc_PaperStuBatchQuesRela_Total.QuesNumSendBack] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[concc_PaperStuBatchQuesRela_Total.QuesNumSendBack].ToString().Trim()); //退回题目数
objcc_PaperStuBatchQuesRela_TotalEN.QuesNumSubmit = objRow[concc_PaperStuBatchQuesRela_Total.QuesNumSubmit] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[concc_PaperStuBatchQuesRela_Total.QuesNumSubmit].ToString().Trim()); //提交题目数
objcc_PaperStuBatchQuesRela_TotalEN.TotalScore = objRow[concc_PaperStuBatchQuesRela_Total.TotalScore] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[concc_PaperStuBatchQuesRela_Total.TotalScore].ToString().Trim()); //总得分
objcc_PaperStuBatchQuesRela_TotalEN.TotalScores = objRow[concc_PaperStuBatchQuesRela_Total.TotalScores] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[concc_PaperStuBatchQuesRela_Total.TotalScores].ToString().Trim()); //总分值
objcc_PaperStuBatchQuesRela_TotalEN.SchoolYear = objRow[concc_PaperStuBatchQuesRela_Total.SchoolYear] == DBNull.Value ? null : objRow[concc_PaperStuBatchQuesRela_Total.SchoolYear].ToString().Trim(); //学年
objcc_PaperStuBatchQuesRela_TotalEN.SchoolTerm = objRow[concc_PaperStuBatchQuesRela_Total.SchoolTerm] == DBNull.Value ? null : objRow[concc_PaperStuBatchQuesRela_Total.SchoolTerm].ToString().Trim(); //学期
objcc_PaperStuBatchQuesRela_TotalEN.UpdDate = objRow[concc_PaperStuBatchQuesRela_Total.UpdDate].ToString().Trim(); //修改日期
objcc_PaperStuBatchQuesRela_TotalEN.UpdUserId = objRow[concc_PaperStuBatchQuesRela_Total.UpdUserId] == DBNull.Value ? null : objRow[concc_PaperStuBatchQuesRela_Total.UpdUserId].ToString().Trim(); //修改用户Id
objcc_PaperStuBatchQuesRela_TotalEN.Memo = objRow[concc_PaperStuBatchQuesRela_Total.Memo] == DBNull.Value ? null : objRow[concc_PaperStuBatchQuesRela_Total.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objcc_PaperStuBatchQuesRela_TotalEN.IdPaperStuBatchQuesRelaTotal, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objcc_PaperStuBatchQuesRela_TotalEN);
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
public static List<clscc_PaperStuBatchQuesRela_TotalEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clscc_PaperStuBatchQuesRela_TotalEN> arrObjLst = new List<clscc_PaperStuBatchQuesRela_TotalEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clscc_PaperStuBatchQuesRela_TotalEN objcc_PaperStuBatchQuesRela_TotalEN = new clscc_PaperStuBatchQuesRela_TotalEN();
try
{
objcc_PaperStuBatchQuesRela_TotalEN.IdPaperStuBatchQuesRelaTotal = Int32.Parse(objRow[concc_PaperStuBatchQuesRela_Total.IdPaperStuBatchQuesRelaTotal].ToString().Trim()); //学生试卷完成汇总流水号
objcc_PaperStuBatchQuesRela_TotalEN.IdPaperStuBatch = objRow[concc_PaperStuBatchQuesRela_Total.IdPaperStuBatch] == DBNull.Value ? null : objRow[concc_PaperStuBatchQuesRela_Total.IdPaperStuBatch].ToString().Trim(); //学生试卷批次流水号
objcc_PaperStuBatchQuesRela_TotalEN.QuesNum = Int32.Parse(objRow[concc_PaperStuBatchQuesRela_Total.QuesNum].ToString().Trim()); //题目数
objcc_PaperStuBatchQuesRela_TotalEN.QuesNumLook = objRow[concc_PaperStuBatchQuesRela_Total.QuesNumLook] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[concc_PaperStuBatchQuesRela_Total.QuesNumLook].ToString().Trim()); //查看题目数
objcc_PaperStuBatchQuesRela_TotalEN.QuesNumMark = objRow[concc_PaperStuBatchQuesRela_Total.QuesNumMark] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[concc_PaperStuBatchQuesRela_Total.QuesNumMark].ToString().Trim()); //打分题目数
objcc_PaperStuBatchQuesRela_TotalEN.QuesNumNoFinish = objRow[concc_PaperStuBatchQuesRela_Total.QuesNumNoFinish] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[concc_PaperStuBatchQuesRela_Total.QuesNumNoFinish].ToString().Trim()); //未完成题目数
objcc_PaperStuBatchQuesRela_TotalEN.QuesNumOverdue = objRow[concc_PaperStuBatchQuesRela_Total.QuesNumOverdue] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[concc_PaperStuBatchQuesRela_Total.QuesNumOverdue].ToString().Trim()); //逾期题目数
objcc_PaperStuBatchQuesRela_TotalEN.QuesNumSave = objRow[concc_PaperStuBatchQuesRela_Total.QuesNumSave] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[concc_PaperStuBatchQuesRela_Total.QuesNumSave].ToString().Trim()); //保存题目数
objcc_PaperStuBatchQuesRela_TotalEN.QuesNumSendBack = objRow[concc_PaperStuBatchQuesRela_Total.QuesNumSendBack] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[concc_PaperStuBatchQuesRela_Total.QuesNumSendBack].ToString().Trim()); //退回题目数
objcc_PaperStuBatchQuesRela_TotalEN.QuesNumSubmit = objRow[concc_PaperStuBatchQuesRela_Total.QuesNumSubmit] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[concc_PaperStuBatchQuesRela_Total.QuesNumSubmit].ToString().Trim()); //提交题目数
objcc_PaperStuBatchQuesRela_TotalEN.TotalScore = objRow[concc_PaperStuBatchQuesRela_Total.TotalScore] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[concc_PaperStuBatchQuesRela_Total.TotalScore].ToString().Trim()); //总得分
objcc_PaperStuBatchQuesRela_TotalEN.TotalScores = objRow[concc_PaperStuBatchQuesRela_Total.TotalScores] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[concc_PaperStuBatchQuesRela_Total.TotalScores].ToString().Trim()); //总分值
objcc_PaperStuBatchQuesRela_TotalEN.SchoolYear = objRow[concc_PaperStuBatchQuesRela_Total.SchoolYear] == DBNull.Value ? null : objRow[concc_PaperStuBatchQuesRela_Total.SchoolYear].ToString().Trim(); //学年
objcc_PaperStuBatchQuesRela_TotalEN.SchoolTerm = objRow[concc_PaperStuBatchQuesRela_Total.SchoolTerm] == DBNull.Value ? null : objRow[concc_PaperStuBatchQuesRela_Total.SchoolTerm].ToString().Trim(); //学期
objcc_PaperStuBatchQuesRela_TotalEN.UpdDate = objRow[concc_PaperStuBatchQuesRela_Total.UpdDate].ToString().Trim(); //修改日期
objcc_PaperStuBatchQuesRela_TotalEN.UpdUserId = objRow[concc_PaperStuBatchQuesRela_Total.UpdUserId] == DBNull.Value ? null : objRow[concc_PaperStuBatchQuesRela_Total.UpdUserId].ToString().Trim(); //修改用户Id
objcc_PaperStuBatchQuesRela_TotalEN.Memo = objRow[concc_PaperStuBatchQuesRela_Total.Memo] == DBNull.Value ? null : objRow[concc_PaperStuBatchQuesRela_Total.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objcc_PaperStuBatchQuesRela_TotalEN.IdPaperStuBatchQuesRelaTotal, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objcc_PaperStuBatchQuesRela_TotalEN);
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
List<clscc_PaperStuBatchQuesRela_TotalEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clscc_PaperStuBatchQuesRela_TotalEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clscc_PaperStuBatchQuesRela_TotalEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clscc_PaperStuBatchQuesRela_TotalEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clscc_PaperStuBatchQuesRela_TotalEN> arrObjLst = new List<clscc_PaperStuBatchQuesRela_TotalEN>(); 
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
	clscc_PaperStuBatchQuesRela_TotalEN objcc_PaperStuBatchQuesRela_TotalEN = new clscc_PaperStuBatchQuesRela_TotalEN();
try
{
objcc_PaperStuBatchQuesRela_TotalEN.IdPaperStuBatchQuesRelaTotal = Int32.Parse(objRow[concc_PaperStuBatchQuesRela_Total.IdPaperStuBatchQuesRelaTotal].ToString().Trim()); //学生试卷完成汇总流水号
objcc_PaperStuBatchQuesRela_TotalEN.IdPaperStuBatch = objRow[concc_PaperStuBatchQuesRela_Total.IdPaperStuBatch] == DBNull.Value ? null : objRow[concc_PaperStuBatchQuesRela_Total.IdPaperStuBatch].ToString().Trim(); //学生试卷批次流水号
objcc_PaperStuBatchQuesRela_TotalEN.QuesNum = Int32.Parse(objRow[concc_PaperStuBatchQuesRela_Total.QuesNum].ToString().Trim()); //题目数
objcc_PaperStuBatchQuesRela_TotalEN.QuesNumLook = objRow[concc_PaperStuBatchQuesRela_Total.QuesNumLook] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[concc_PaperStuBatchQuesRela_Total.QuesNumLook].ToString().Trim()); //查看题目数
objcc_PaperStuBatchQuesRela_TotalEN.QuesNumMark = objRow[concc_PaperStuBatchQuesRela_Total.QuesNumMark] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[concc_PaperStuBatchQuesRela_Total.QuesNumMark].ToString().Trim()); //打分题目数
objcc_PaperStuBatchQuesRela_TotalEN.QuesNumNoFinish = objRow[concc_PaperStuBatchQuesRela_Total.QuesNumNoFinish] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[concc_PaperStuBatchQuesRela_Total.QuesNumNoFinish].ToString().Trim()); //未完成题目数
objcc_PaperStuBatchQuesRela_TotalEN.QuesNumOverdue = objRow[concc_PaperStuBatchQuesRela_Total.QuesNumOverdue] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[concc_PaperStuBatchQuesRela_Total.QuesNumOverdue].ToString().Trim()); //逾期题目数
objcc_PaperStuBatchQuesRela_TotalEN.QuesNumSave = objRow[concc_PaperStuBatchQuesRela_Total.QuesNumSave] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[concc_PaperStuBatchQuesRela_Total.QuesNumSave].ToString().Trim()); //保存题目数
objcc_PaperStuBatchQuesRela_TotalEN.QuesNumSendBack = objRow[concc_PaperStuBatchQuesRela_Total.QuesNumSendBack] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[concc_PaperStuBatchQuesRela_Total.QuesNumSendBack].ToString().Trim()); //退回题目数
objcc_PaperStuBatchQuesRela_TotalEN.QuesNumSubmit = objRow[concc_PaperStuBatchQuesRela_Total.QuesNumSubmit] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[concc_PaperStuBatchQuesRela_Total.QuesNumSubmit].ToString().Trim()); //提交题目数
objcc_PaperStuBatchQuesRela_TotalEN.TotalScore = objRow[concc_PaperStuBatchQuesRela_Total.TotalScore] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[concc_PaperStuBatchQuesRela_Total.TotalScore].ToString().Trim()); //总得分
objcc_PaperStuBatchQuesRela_TotalEN.TotalScores = objRow[concc_PaperStuBatchQuesRela_Total.TotalScores] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[concc_PaperStuBatchQuesRela_Total.TotalScores].ToString().Trim()); //总分值
objcc_PaperStuBatchQuesRela_TotalEN.SchoolYear = objRow[concc_PaperStuBatchQuesRela_Total.SchoolYear] == DBNull.Value ? null : objRow[concc_PaperStuBatchQuesRela_Total.SchoolYear].ToString().Trim(); //学年
objcc_PaperStuBatchQuesRela_TotalEN.SchoolTerm = objRow[concc_PaperStuBatchQuesRela_Total.SchoolTerm] == DBNull.Value ? null : objRow[concc_PaperStuBatchQuesRela_Total.SchoolTerm].ToString().Trim(); //学期
objcc_PaperStuBatchQuesRela_TotalEN.UpdDate = objRow[concc_PaperStuBatchQuesRela_Total.UpdDate].ToString().Trim(); //修改日期
objcc_PaperStuBatchQuesRela_TotalEN.UpdUserId = objRow[concc_PaperStuBatchQuesRela_Total.UpdUserId] == DBNull.Value ? null : objRow[concc_PaperStuBatchQuesRela_Total.UpdUserId].ToString().Trim(); //修改用户Id
objcc_PaperStuBatchQuesRela_TotalEN.Memo = objRow[concc_PaperStuBatchQuesRela_Total.Memo] == DBNull.Value ? null : objRow[concc_PaperStuBatchQuesRela_Total.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objcc_PaperStuBatchQuesRela_TotalEN.IdPaperStuBatchQuesRelaTotal, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objcc_PaperStuBatchQuesRela_TotalEN);
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
public static List<clscc_PaperStuBatchQuesRela_TotalEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clscc_PaperStuBatchQuesRela_TotalEN> arrObjLst = new List<clscc_PaperStuBatchQuesRela_TotalEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clscc_PaperStuBatchQuesRela_TotalEN objcc_PaperStuBatchQuesRela_TotalEN = new clscc_PaperStuBatchQuesRela_TotalEN();
try
{
objcc_PaperStuBatchQuesRela_TotalEN.IdPaperStuBatchQuesRelaTotal = Int32.Parse(objRow[concc_PaperStuBatchQuesRela_Total.IdPaperStuBatchQuesRelaTotal].ToString().Trim()); //学生试卷完成汇总流水号
objcc_PaperStuBatchQuesRela_TotalEN.IdPaperStuBatch = objRow[concc_PaperStuBatchQuesRela_Total.IdPaperStuBatch] == DBNull.Value ? null : objRow[concc_PaperStuBatchQuesRela_Total.IdPaperStuBatch].ToString().Trim(); //学生试卷批次流水号
objcc_PaperStuBatchQuesRela_TotalEN.QuesNum = Int32.Parse(objRow[concc_PaperStuBatchQuesRela_Total.QuesNum].ToString().Trim()); //题目数
objcc_PaperStuBatchQuesRela_TotalEN.QuesNumLook = objRow[concc_PaperStuBatchQuesRela_Total.QuesNumLook] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[concc_PaperStuBatchQuesRela_Total.QuesNumLook].ToString().Trim()); //查看题目数
objcc_PaperStuBatchQuesRela_TotalEN.QuesNumMark = objRow[concc_PaperStuBatchQuesRela_Total.QuesNumMark] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[concc_PaperStuBatchQuesRela_Total.QuesNumMark].ToString().Trim()); //打分题目数
objcc_PaperStuBatchQuesRela_TotalEN.QuesNumNoFinish = objRow[concc_PaperStuBatchQuesRela_Total.QuesNumNoFinish] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[concc_PaperStuBatchQuesRela_Total.QuesNumNoFinish].ToString().Trim()); //未完成题目数
objcc_PaperStuBatchQuesRela_TotalEN.QuesNumOverdue = objRow[concc_PaperStuBatchQuesRela_Total.QuesNumOverdue] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[concc_PaperStuBatchQuesRela_Total.QuesNumOverdue].ToString().Trim()); //逾期题目数
objcc_PaperStuBatchQuesRela_TotalEN.QuesNumSave = objRow[concc_PaperStuBatchQuesRela_Total.QuesNumSave] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[concc_PaperStuBatchQuesRela_Total.QuesNumSave].ToString().Trim()); //保存题目数
objcc_PaperStuBatchQuesRela_TotalEN.QuesNumSendBack = objRow[concc_PaperStuBatchQuesRela_Total.QuesNumSendBack] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[concc_PaperStuBatchQuesRela_Total.QuesNumSendBack].ToString().Trim()); //退回题目数
objcc_PaperStuBatchQuesRela_TotalEN.QuesNumSubmit = objRow[concc_PaperStuBatchQuesRela_Total.QuesNumSubmit] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[concc_PaperStuBatchQuesRela_Total.QuesNumSubmit].ToString().Trim()); //提交题目数
objcc_PaperStuBatchQuesRela_TotalEN.TotalScore = objRow[concc_PaperStuBatchQuesRela_Total.TotalScore] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[concc_PaperStuBatchQuesRela_Total.TotalScore].ToString().Trim()); //总得分
objcc_PaperStuBatchQuesRela_TotalEN.TotalScores = objRow[concc_PaperStuBatchQuesRela_Total.TotalScores] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[concc_PaperStuBatchQuesRela_Total.TotalScores].ToString().Trim()); //总分值
objcc_PaperStuBatchQuesRela_TotalEN.SchoolYear = objRow[concc_PaperStuBatchQuesRela_Total.SchoolYear] == DBNull.Value ? null : objRow[concc_PaperStuBatchQuesRela_Total.SchoolYear].ToString().Trim(); //学年
objcc_PaperStuBatchQuesRela_TotalEN.SchoolTerm = objRow[concc_PaperStuBatchQuesRela_Total.SchoolTerm] == DBNull.Value ? null : objRow[concc_PaperStuBatchQuesRela_Total.SchoolTerm].ToString().Trim(); //学期
objcc_PaperStuBatchQuesRela_TotalEN.UpdDate = objRow[concc_PaperStuBatchQuesRela_Total.UpdDate].ToString().Trim(); //修改日期
objcc_PaperStuBatchQuesRela_TotalEN.UpdUserId = objRow[concc_PaperStuBatchQuesRela_Total.UpdUserId] == DBNull.Value ? null : objRow[concc_PaperStuBatchQuesRela_Total.UpdUserId].ToString().Trim(); //修改用户Id
objcc_PaperStuBatchQuesRela_TotalEN.Memo = objRow[concc_PaperStuBatchQuesRela_Total.Memo] == DBNull.Value ? null : objRow[concc_PaperStuBatchQuesRela_Total.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objcc_PaperStuBatchQuesRela_TotalEN.IdPaperStuBatchQuesRelaTotal, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objcc_PaperStuBatchQuesRela_TotalEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clscc_PaperStuBatchQuesRela_TotalEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clscc_PaperStuBatchQuesRela_TotalEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clscc_PaperStuBatchQuesRela_TotalEN> arrObjLst = new List<clscc_PaperStuBatchQuesRela_TotalEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clscc_PaperStuBatchQuesRela_TotalEN objcc_PaperStuBatchQuesRela_TotalEN = new clscc_PaperStuBatchQuesRela_TotalEN();
try
{
objcc_PaperStuBatchQuesRela_TotalEN.IdPaperStuBatchQuesRelaTotal = Int32.Parse(objRow[concc_PaperStuBatchQuesRela_Total.IdPaperStuBatchQuesRelaTotal].ToString().Trim()); //学生试卷完成汇总流水号
objcc_PaperStuBatchQuesRela_TotalEN.IdPaperStuBatch = objRow[concc_PaperStuBatchQuesRela_Total.IdPaperStuBatch] == DBNull.Value ? null : objRow[concc_PaperStuBatchQuesRela_Total.IdPaperStuBatch].ToString().Trim(); //学生试卷批次流水号
objcc_PaperStuBatchQuesRela_TotalEN.QuesNum = Int32.Parse(objRow[concc_PaperStuBatchQuesRela_Total.QuesNum].ToString().Trim()); //题目数
objcc_PaperStuBatchQuesRela_TotalEN.QuesNumLook = objRow[concc_PaperStuBatchQuesRela_Total.QuesNumLook] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[concc_PaperStuBatchQuesRela_Total.QuesNumLook].ToString().Trim()); //查看题目数
objcc_PaperStuBatchQuesRela_TotalEN.QuesNumMark = objRow[concc_PaperStuBatchQuesRela_Total.QuesNumMark] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[concc_PaperStuBatchQuesRela_Total.QuesNumMark].ToString().Trim()); //打分题目数
objcc_PaperStuBatchQuesRela_TotalEN.QuesNumNoFinish = objRow[concc_PaperStuBatchQuesRela_Total.QuesNumNoFinish] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[concc_PaperStuBatchQuesRela_Total.QuesNumNoFinish].ToString().Trim()); //未完成题目数
objcc_PaperStuBatchQuesRela_TotalEN.QuesNumOverdue = objRow[concc_PaperStuBatchQuesRela_Total.QuesNumOverdue] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[concc_PaperStuBatchQuesRela_Total.QuesNumOverdue].ToString().Trim()); //逾期题目数
objcc_PaperStuBatchQuesRela_TotalEN.QuesNumSave = objRow[concc_PaperStuBatchQuesRela_Total.QuesNumSave] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[concc_PaperStuBatchQuesRela_Total.QuesNumSave].ToString().Trim()); //保存题目数
objcc_PaperStuBatchQuesRela_TotalEN.QuesNumSendBack = objRow[concc_PaperStuBatchQuesRela_Total.QuesNumSendBack] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[concc_PaperStuBatchQuesRela_Total.QuesNumSendBack].ToString().Trim()); //退回题目数
objcc_PaperStuBatchQuesRela_TotalEN.QuesNumSubmit = objRow[concc_PaperStuBatchQuesRela_Total.QuesNumSubmit] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[concc_PaperStuBatchQuesRela_Total.QuesNumSubmit].ToString().Trim()); //提交题目数
objcc_PaperStuBatchQuesRela_TotalEN.TotalScore = objRow[concc_PaperStuBatchQuesRela_Total.TotalScore] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[concc_PaperStuBatchQuesRela_Total.TotalScore].ToString().Trim()); //总得分
objcc_PaperStuBatchQuesRela_TotalEN.TotalScores = objRow[concc_PaperStuBatchQuesRela_Total.TotalScores] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[concc_PaperStuBatchQuesRela_Total.TotalScores].ToString().Trim()); //总分值
objcc_PaperStuBatchQuesRela_TotalEN.SchoolYear = objRow[concc_PaperStuBatchQuesRela_Total.SchoolYear] == DBNull.Value ? null : objRow[concc_PaperStuBatchQuesRela_Total.SchoolYear].ToString().Trim(); //学年
objcc_PaperStuBatchQuesRela_TotalEN.SchoolTerm = objRow[concc_PaperStuBatchQuesRela_Total.SchoolTerm] == DBNull.Value ? null : objRow[concc_PaperStuBatchQuesRela_Total.SchoolTerm].ToString().Trim(); //学期
objcc_PaperStuBatchQuesRela_TotalEN.UpdDate = objRow[concc_PaperStuBatchQuesRela_Total.UpdDate].ToString().Trim(); //修改日期
objcc_PaperStuBatchQuesRela_TotalEN.UpdUserId = objRow[concc_PaperStuBatchQuesRela_Total.UpdUserId] == DBNull.Value ? null : objRow[concc_PaperStuBatchQuesRela_Total.UpdUserId].ToString().Trim(); //修改用户Id
objcc_PaperStuBatchQuesRela_TotalEN.Memo = objRow[concc_PaperStuBatchQuesRela_Total.Memo] == DBNull.Value ? null : objRow[concc_PaperStuBatchQuesRela_Total.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objcc_PaperStuBatchQuesRela_TotalEN.IdPaperStuBatchQuesRelaTotal, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objcc_PaperStuBatchQuesRela_TotalEN);
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
public static List<clscc_PaperStuBatchQuesRela_TotalEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clscc_PaperStuBatchQuesRela_TotalEN> arrObjLst = new List<clscc_PaperStuBatchQuesRela_TotalEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clscc_PaperStuBatchQuesRela_TotalEN objcc_PaperStuBatchQuesRela_TotalEN = new clscc_PaperStuBatchQuesRela_TotalEN();
try
{
objcc_PaperStuBatchQuesRela_TotalEN.IdPaperStuBatchQuesRelaTotal = Int32.Parse(objRow[concc_PaperStuBatchQuesRela_Total.IdPaperStuBatchQuesRelaTotal].ToString().Trim()); //学生试卷完成汇总流水号
objcc_PaperStuBatchQuesRela_TotalEN.IdPaperStuBatch = objRow[concc_PaperStuBatchQuesRela_Total.IdPaperStuBatch] == DBNull.Value ? null : objRow[concc_PaperStuBatchQuesRela_Total.IdPaperStuBatch].ToString().Trim(); //学生试卷批次流水号
objcc_PaperStuBatchQuesRela_TotalEN.QuesNum = Int32.Parse(objRow[concc_PaperStuBatchQuesRela_Total.QuesNum].ToString().Trim()); //题目数
objcc_PaperStuBatchQuesRela_TotalEN.QuesNumLook = objRow[concc_PaperStuBatchQuesRela_Total.QuesNumLook] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[concc_PaperStuBatchQuesRela_Total.QuesNumLook].ToString().Trim()); //查看题目数
objcc_PaperStuBatchQuesRela_TotalEN.QuesNumMark = objRow[concc_PaperStuBatchQuesRela_Total.QuesNumMark] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[concc_PaperStuBatchQuesRela_Total.QuesNumMark].ToString().Trim()); //打分题目数
objcc_PaperStuBatchQuesRela_TotalEN.QuesNumNoFinish = objRow[concc_PaperStuBatchQuesRela_Total.QuesNumNoFinish] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[concc_PaperStuBatchQuesRela_Total.QuesNumNoFinish].ToString().Trim()); //未完成题目数
objcc_PaperStuBatchQuesRela_TotalEN.QuesNumOverdue = objRow[concc_PaperStuBatchQuesRela_Total.QuesNumOverdue] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[concc_PaperStuBatchQuesRela_Total.QuesNumOverdue].ToString().Trim()); //逾期题目数
objcc_PaperStuBatchQuesRela_TotalEN.QuesNumSave = objRow[concc_PaperStuBatchQuesRela_Total.QuesNumSave] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[concc_PaperStuBatchQuesRela_Total.QuesNumSave].ToString().Trim()); //保存题目数
objcc_PaperStuBatchQuesRela_TotalEN.QuesNumSendBack = objRow[concc_PaperStuBatchQuesRela_Total.QuesNumSendBack] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[concc_PaperStuBatchQuesRela_Total.QuesNumSendBack].ToString().Trim()); //退回题目数
objcc_PaperStuBatchQuesRela_TotalEN.QuesNumSubmit = objRow[concc_PaperStuBatchQuesRela_Total.QuesNumSubmit] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[concc_PaperStuBatchQuesRela_Total.QuesNumSubmit].ToString().Trim()); //提交题目数
objcc_PaperStuBatchQuesRela_TotalEN.TotalScore = objRow[concc_PaperStuBatchQuesRela_Total.TotalScore] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[concc_PaperStuBatchQuesRela_Total.TotalScore].ToString().Trim()); //总得分
objcc_PaperStuBatchQuesRela_TotalEN.TotalScores = objRow[concc_PaperStuBatchQuesRela_Total.TotalScores] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[concc_PaperStuBatchQuesRela_Total.TotalScores].ToString().Trim()); //总分值
objcc_PaperStuBatchQuesRela_TotalEN.SchoolYear = objRow[concc_PaperStuBatchQuesRela_Total.SchoolYear] == DBNull.Value ? null : objRow[concc_PaperStuBatchQuesRela_Total.SchoolYear].ToString().Trim(); //学年
objcc_PaperStuBatchQuesRela_TotalEN.SchoolTerm = objRow[concc_PaperStuBatchQuesRela_Total.SchoolTerm] == DBNull.Value ? null : objRow[concc_PaperStuBatchQuesRela_Total.SchoolTerm].ToString().Trim(); //学期
objcc_PaperStuBatchQuesRela_TotalEN.UpdDate = objRow[concc_PaperStuBatchQuesRela_Total.UpdDate].ToString().Trim(); //修改日期
objcc_PaperStuBatchQuesRela_TotalEN.UpdUserId = objRow[concc_PaperStuBatchQuesRela_Total.UpdUserId] == DBNull.Value ? null : objRow[concc_PaperStuBatchQuesRela_Total.UpdUserId].ToString().Trim(); //修改用户Id
objcc_PaperStuBatchQuesRela_TotalEN.Memo = objRow[concc_PaperStuBatchQuesRela_Total.Memo] == DBNull.Value ? null : objRow[concc_PaperStuBatchQuesRela_Total.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objcc_PaperStuBatchQuesRela_TotalEN.IdPaperStuBatchQuesRelaTotal, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objcc_PaperStuBatchQuesRela_TotalEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clscc_PaperStuBatchQuesRela_TotalEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clscc_PaperStuBatchQuesRela_TotalEN> arrObjLst = new List<clscc_PaperStuBatchQuesRela_TotalEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clscc_PaperStuBatchQuesRela_TotalEN objcc_PaperStuBatchQuesRela_TotalEN = new clscc_PaperStuBatchQuesRela_TotalEN();
try
{
objcc_PaperStuBatchQuesRela_TotalEN.IdPaperStuBatchQuesRelaTotal = Int32.Parse(objRow[concc_PaperStuBatchQuesRela_Total.IdPaperStuBatchQuesRelaTotal].ToString().Trim()); //学生试卷完成汇总流水号
objcc_PaperStuBatchQuesRela_TotalEN.IdPaperStuBatch = objRow[concc_PaperStuBatchQuesRela_Total.IdPaperStuBatch] == DBNull.Value ? null : objRow[concc_PaperStuBatchQuesRela_Total.IdPaperStuBatch].ToString().Trim(); //学生试卷批次流水号
objcc_PaperStuBatchQuesRela_TotalEN.QuesNum = Int32.Parse(objRow[concc_PaperStuBatchQuesRela_Total.QuesNum].ToString().Trim()); //题目数
objcc_PaperStuBatchQuesRela_TotalEN.QuesNumLook = objRow[concc_PaperStuBatchQuesRela_Total.QuesNumLook] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[concc_PaperStuBatchQuesRela_Total.QuesNumLook].ToString().Trim()); //查看题目数
objcc_PaperStuBatchQuesRela_TotalEN.QuesNumMark = objRow[concc_PaperStuBatchQuesRela_Total.QuesNumMark] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[concc_PaperStuBatchQuesRela_Total.QuesNumMark].ToString().Trim()); //打分题目数
objcc_PaperStuBatchQuesRela_TotalEN.QuesNumNoFinish = objRow[concc_PaperStuBatchQuesRela_Total.QuesNumNoFinish] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[concc_PaperStuBatchQuesRela_Total.QuesNumNoFinish].ToString().Trim()); //未完成题目数
objcc_PaperStuBatchQuesRela_TotalEN.QuesNumOverdue = objRow[concc_PaperStuBatchQuesRela_Total.QuesNumOverdue] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[concc_PaperStuBatchQuesRela_Total.QuesNumOverdue].ToString().Trim()); //逾期题目数
objcc_PaperStuBatchQuesRela_TotalEN.QuesNumSave = objRow[concc_PaperStuBatchQuesRela_Total.QuesNumSave] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[concc_PaperStuBatchQuesRela_Total.QuesNumSave].ToString().Trim()); //保存题目数
objcc_PaperStuBatchQuesRela_TotalEN.QuesNumSendBack = objRow[concc_PaperStuBatchQuesRela_Total.QuesNumSendBack] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[concc_PaperStuBatchQuesRela_Total.QuesNumSendBack].ToString().Trim()); //退回题目数
objcc_PaperStuBatchQuesRela_TotalEN.QuesNumSubmit = objRow[concc_PaperStuBatchQuesRela_Total.QuesNumSubmit] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[concc_PaperStuBatchQuesRela_Total.QuesNumSubmit].ToString().Trim()); //提交题目数
objcc_PaperStuBatchQuesRela_TotalEN.TotalScore = objRow[concc_PaperStuBatchQuesRela_Total.TotalScore] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[concc_PaperStuBatchQuesRela_Total.TotalScore].ToString().Trim()); //总得分
objcc_PaperStuBatchQuesRela_TotalEN.TotalScores = objRow[concc_PaperStuBatchQuesRela_Total.TotalScores] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[concc_PaperStuBatchQuesRela_Total.TotalScores].ToString().Trim()); //总分值
objcc_PaperStuBatchQuesRela_TotalEN.SchoolYear = objRow[concc_PaperStuBatchQuesRela_Total.SchoolYear] == DBNull.Value ? null : objRow[concc_PaperStuBatchQuesRela_Total.SchoolYear].ToString().Trim(); //学年
objcc_PaperStuBatchQuesRela_TotalEN.SchoolTerm = objRow[concc_PaperStuBatchQuesRela_Total.SchoolTerm] == DBNull.Value ? null : objRow[concc_PaperStuBatchQuesRela_Total.SchoolTerm].ToString().Trim(); //学期
objcc_PaperStuBatchQuesRela_TotalEN.UpdDate = objRow[concc_PaperStuBatchQuesRela_Total.UpdDate].ToString().Trim(); //修改日期
objcc_PaperStuBatchQuesRela_TotalEN.UpdUserId = objRow[concc_PaperStuBatchQuesRela_Total.UpdUserId] == DBNull.Value ? null : objRow[concc_PaperStuBatchQuesRela_Total.UpdUserId].ToString().Trim(); //修改用户Id
objcc_PaperStuBatchQuesRela_TotalEN.Memo = objRow[concc_PaperStuBatchQuesRela_Total.Memo] == DBNull.Value ? null : objRow[concc_PaperStuBatchQuesRela_Total.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objcc_PaperStuBatchQuesRela_TotalEN.IdPaperStuBatchQuesRelaTotal, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objcc_PaperStuBatchQuesRela_TotalEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objcc_PaperStuBatchQuesRela_TotalEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool Getcc_PaperStuBatchQuesRela_Total(ref clscc_PaperStuBatchQuesRela_TotalEN objcc_PaperStuBatchQuesRela_TotalEN)
{
bool bolResult = cc_PaperStuBatchQuesRela_TotalDA.Getcc_PaperStuBatchQuesRela_Total(ref objcc_PaperStuBatchQuesRela_TotalEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "lngIdPaperStuBatchQuesRelaTotal">表关键字</param>
 /// <returns>表对象</returns>
public static clscc_PaperStuBatchQuesRela_TotalEN GetObjByIdPaperStuBatchQuesRelaTotal(long lngIdPaperStuBatchQuesRelaTotal)
{
clscc_PaperStuBatchQuesRela_TotalEN objcc_PaperStuBatchQuesRela_TotalEN = cc_PaperStuBatchQuesRela_TotalDA.GetObjByIdPaperStuBatchQuesRelaTotal(lngIdPaperStuBatchQuesRelaTotal);
return objcc_PaperStuBatchQuesRela_TotalEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clscc_PaperStuBatchQuesRela_TotalEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clscc_PaperStuBatchQuesRela_TotalEN objcc_PaperStuBatchQuesRela_TotalEN = cc_PaperStuBatchQuesRela_TotalDA.GetFirstObj(strWhereCond);
 return objcc_PaperStuBatchQuesRela_TotalEN;
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
public static clscc_PaperStuBatchQuesRela_TotalEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clscc_PaperStuBatchQuesRela_TotalEN objcc_PaperStuBatchQuesRela_TotalEN = cc_PaperStuBatchQuesRela_TotalDA.GetObjByDataRow(objRow);
 return objcc_PaperStuBatchQuesRela_TotalEN;
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
public static clscc_PaperStuBatchQuesRela_TotalEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clscc_PaperStuBatchQuesRela_TotalEN objcc_PaperStuBatchQuesRela_TotalEN = cc_PaperStuBatchQuesRela_TotalDA.GetObjByDataRow(objRow);
 return objcc_PaperStuBatchQuesRela_TotalEN;
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
 /// <param name = "lngIdPaperStuBatchQuesRelaTotal">所给的关键字</param>
 /// <param name = "lstcc_PaperStuBatchQuesRela_TotalObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clscc_PaperStuBatchQuesRela_TotalEN GetObjByIdPaperStuBatchQuesRelaTotalFromList(long lngIdPaperStuBatchQuesRelaTotal, List<clscc_PaperStuBatchQuesRela_TotalEN> lstcc_PaperStuBatchQuesRela_TotalObjLst)
{
foreach (clscc_PaperStuBatchQuesRela_TotalEN objcc_PaperStuBatchQuesRela_TotalEN in lstcc_PaperStuBatchQuesRela_TotalObjLst)
{
if (objcc_PaperStuBatchQuesRela_TotalEN.IdPaperStuBatchQuesRelaTotal == lngIdPaperStuBatchQuesRelaTotal)
{
return objcc_PaperStuBatchQuesRela_TotalEN;
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
 long lngIdPaperStuBatchQuesRelaTotal;
 try
 {
 lngIdPaperStuBatchQuesRelaTotal = new clscc_PaperStuBatchQuesRela_TotalDA().GetFirstID(strWhereCond);
 return lngIdPaperStuBatchQuesRelaTotal;
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
 arrList = cc_PaperStuBatchQuesRela_TotalDA.GetID(strWhereCond);
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
bool bolIsExist = cc_PaperStuBatchQuesRela_TotalDA.IsExistCondRec(strWhereCond);
return bolIsExist;
}

 /// <summary>
 /// 判断当前表中是否存在给定关键字值的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExist)
 /// </summary>
 /// <param name = "lngIdPaperStuBatchQuesRelaTotal">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public static bool IsExist(long lngIdPaperStuBatchQuesRelaTotal)
{
//检测记录是否存在
bool bolIsExist = cc_PaperStuBatchQuesRela_TotalDA.IsExist(lngIdPaperStuBatchQuesRelaTotal);
return bolIsExist;
}

/// <summary>
/// 设置修改时间
/// </summary>
/// <param name = "lngIdPaperStuBatchQuesRelaTotal">学生试卷完成汇总流水号</param>
/// <param name = "strOpUser">修改用户</param>
/// <returns>是否成功？</returns>
public static bool SetUpdDate(long lngIdPaperStuBatchQuesRelaTotal, string strOpUser)
{
clscc_PaperStuBatchQuesRela_TotalEN objcc_PaperStuBatchQuesRela_TotalEN = clscc_PaperStuBatchQuesRela_TotalBL.GetObjByIdPaperStuBatchQuesRelaTotal(lngIdPaperStuBatchQuesRelaTotal);
objcc_PaperStuBatchQuesRela_TotalEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
objcc_PaperStuBatchQuesRela_TotalEN.UpdUserId = strOpUser;
return clscc_PaperStuBatchQuesRela_TotalBL.UpdateBySql2(objcc_PaperStuBatchQuesRela_TotalEN);
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
 bolIsExist = clscc_PaperStuBatchQuesRela_TotalDA.IsExistTable();
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
 bolIsExist = cc_PaperStuBatchQuesRela_TotalDA.IsExistTable(strTabName);
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
 /// <param name = "objcc_PaperStuBatchQuesRela_TotalEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecordBySql2(clscc_PaperStuBatchQuesRela_TotalEN objcc_PaperStuBatchQuesRela_TotalEN, bool bolIsNeedCheckUniqueness=true)
{
if (bolIsNeedCheckUniqueness == true && objcc_PaperStuBatchQuesRela_TotalEN.CheckUniqueness() == false)
{
var strMsg = string.Format("记录已经存在!学生试卷批次流水号 = [{0}],学期 = [{1}],学年 = [{2}]的数据已经存在!(in clscc_PaperStuBatchQuesRela_TotalBL.AddNewRecordBySql2)", objcc_PaperStuBatchQuesRela_TotalEN.IdPaperStuBatch,objcc_PaperStuBatchQuesRela_TotalEN.SchoolTerm,objcc_PaperStuBatchQuesRela_TotalEN.SchoolYear);
throw new Exception(strMsg);
}
try
{
bool bolResult = cc_PaperStuBatchQuesRela_TotalDA.AddNewRecordBySQL2(objcc_PaperStuBatchQuesRela_TotalEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clscc_PaperStuBatchQuesRela_TotalBL.ReFreshCache();

if (clscc_PaperStuBatchQuesRela_TotalBL.relatedActions != null)
{
clscc_PaperStuBatchQuesRela_TotalBL.relatedActions.UpdRelaTabDate(objcc_PaperStuBatchQuesRela_TotalEN.IdPaperStuBatchQuesRelaTotal, objcc_PaperStuBatchQuesRela_TotalEN.UpdUserId);
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
 /// <param name = "objcc_PaperStuBatchQuesRela_TotalEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordBySql2WithReturnKey(clscc_PaperStuBatchQuesRela_TotalEN objcc_PaperStuBatchQuesRela_TotalEN, bool bolIsNeedCheckUniqueness=true)
{
if (bolIsNeedCheckUniqueness == true && objcc_PaperStuBatchQuesRela_TotalEN.CheckUniqueness() == false)
{
var strMsg = string.Format("记录已经存在!学生试卷批次流水号 = [{0}],学期 = [{1}],学年 = [{2}]的数据已经存在!(in clscc_PaperStuBatchQuesRela_TotalBL.AddNewRecordBySql2WithReturnKey)", objcc_PaperStuBatchQuesRela_TotalEN.IdPaperStuBatch,objcc_PaperStuBatchQuesRela_TotalEN.SchoolTerm,objcc_PaperStuBatchQuesRela_TotalEN.SchoolYear);
throw new Exception(strMsg);
}
try
{
string strKey = cc_PaperStuBatchQuesRela_TotalDA.AddNewRecordBySQL2WithReturnKey(objcc_PaperStuBatchQuesRela_TotalEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clscc_PaperStuBatchQuesRela_TotalBL.ReFreshCache();

if (clscc_PaperStuBatchQuesRela_TotalBL.relatedActions != null)
{
clscc_PaperStuBatchQuesRela_TotalBL.relatedActions.UpdRelaTabDate(objcc_PaperStuBatchQuesRela_TotalEN.IdPaperStuBatchQuesRelaTotal, objcc_PaperStuBatchQuesRela_TotalEN.UpdUserId);
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
 /// <param name = "objcc_PaperStuBatchQuesRela_TotalEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(clscc_PaperStuBatchQuesRela_TotalEN objcc_PaperStuBatchQuesRela_TotalEN)
{
try
{
bool bolResult = cc_PaperStuBatchQuesRela_TotalDA.Update(objcc_PaperStuBatchQuesRela_TotalEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clscc_PaperStuBatchQuesRela_TotalBL.ReFreshCache();

if (clscc_PaperStuBatchQuesRela_TotalBL.relatedActions != null)
{
clscc_PaperStuBatchQuesRela_TotalBL.relatedActions.UpdRelaTabDate(objcc_PaperStuBatchQuesRela_TotalEN.IdPaperStuBatchQuesRelaTotal, objcc_PaperStuBatchQuesRela_TotalEN.UpdUserId);
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
 /// <param name = "objcc_PaperStuBatchQuesRela_TotalEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateBySql2(clscc_PaperStuBatchQuesRela_TotalEN objcc_PaperStuBatchQuesRela_TotalEN)
{
 if (objcc_PaperStuBatchQuesRela_TotalEN.IdPaperStuBatchQuesRelaTotal == 0)
 {
var strMsg = string.Format("(errid:Busi000065)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = cc_PaperStuBatchQuesRela_TotalDA.UpdateBySql2(objcc_PaperStuBatchQuesRela_TotalEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clscc_PaperStuBatchQuesRela_TotalBL.ReFreshCache();

if (clscc_PaperStuBatchQuesRela_TotalBL.relatedActions != null)
{
clscc_PaperStuBatchQuesRela_TotalBL.relatedActions.UpdRelaTabDate(objcc_PaperStuBatchQuesRela_TotalEN.IdPaperStuBatchQuesRelaTotal, objcc_PaperStuBatchQuesRela_TotalEN.UpdUserId);
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
 /// <param name = "lngIdPaperStuBatchQuesRelaTotal">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int DelRecord(long lngIdPaperStuBatchQuesRelaTotal)
{
try
{
 clscc_PaperStuBatchQuesRela_TotalEN objcc_PaperStuBatchQuesRela_TotalEN = clscc_PaperStuBatchQuesRela_TotalBL.GetObjByIdPaperStuBatchQuesRelaTotal(lngIdPaperStuBatchQuesRelaTotal);

if (clscc_PaperStuBatchQuesRela_TotalBL.relatedActions != null)
{
clscc_PaperStuBatchQuesRela_TotalBL.relatedActions.UpdRelaTabDate(objcc_PaperStuBatchQuesRela_TotalEN.IdPaperStuBatchQuesRelaTotal, objcc_PaperStuBatchQuesRela_TotalEN.UpdUserId);
}
if (objcc_PaperStuBatchQuesRela_TotalEN != null)
{
int intRecNum = cc_PaperStuBatchQuesRela_TotalDA.DelRecord(lngIdPaperStuBatchQuesRelaTotal);
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
/// <param name="lngIdPaperStuBatchQuesRelaTotal">表关键字</param>
/// <returns></returns>
public static bool DelRecordEx(long lngIdPaperStuBatchQuesRelaTotal )
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clscc_PaperStuBatchQuesRela_TotalDA.GetSpecSQLObj();
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
//删除与表:[cc_PaperStuBatchQuesRela_Total]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//concc_PaperStuBatchQuesRela_Total.IdPaperStuBatchQuesRelaTotal,
//lngIdPaperStuBatchQuesRelaTotal);
//        clscc_PaperStuBatchQuesRela_TotalBL.Delcc_PaperStuBatchQuesRela_TotalsByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clscc_PaperStuBatchQuesRela_TotalBL.DelRecord(lngIdPaperStuBatchQuesRelaTotal, objConnection, objSqlTransaction);
objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clscc_PaperStuBatchQuesRela_TotalBLEx", "DelRecordEx", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("扩展删除记录出错:{0}!keyId = {1}.({2})",
objException.Message,
lngIdPaperStuBatchQuesRelaTotal, clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "lngIdPaperStuBatchQuesRelaTotal">给定的关键字值</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回删除是否成功?</returns>
public static bool DelRecord(long lngIdPaperStuBatchQuesRelaTotal, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
if (clscc_PaperStuBatchQuesRela_TotalBL.relatedActions != null)
{
clscc_PaperStuBatchQuesRela_TotalBL.relatedActions.UpdRelaTabDate(lngIdPaperStuBatchQuesRelaTotal, "UpdRelaTabDate");
}
bool bolResult = cc_PaperStuBatchQuesRela_TotalDA.DelRecord(lngIdPaperStuBatchQuesRelaTotal,objSqlConnection,objSqlTransaction);
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
 /// <param name = "arrIdPaperStuBatchQuesRelaTotalLst">给定的关键字值列表</param>
 /// <returns>返回删除的记录数</returns>
public static int Delcc_PaperStuBatchQuesRela_Totals(List<string> arrIdPaperStuBatchQuesRelaTotalLst)
{
if (arrIdPaperStuBatchQuesRelaTotalLst.Count == 0) return 0;
try
{
if (clscc_PaperStuBatchQuesRela_TotalBL.relatedActions != null)
{
foreach (var strIdPaperStuBatchQuesRelaTotal in arrIdPaperStuBatchQuesRelaTotalLst)
{
long lngIdPaperStuBatchQuesRelaTotal = long.Parse(strIdPaperStuBatchQuesRelaTotal);
clscc_PaperStuBatchQuesRela_TotalBL.relatedActions.UpdRelaTabDate(lngIdPaperStuBatchQuesRelaTotal, "UpdRelaTabDate");
}
}
int intDelRecNum = cc_PaperStuBatchQuesRela_TotalDA.Delcc_PaperStuBatchQuesRela_Total(arrIdPaperStuBatchQuesRelaTotalLst);
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
public static int Delcc_PaperStuBatchQuesRela_TotalsByCond(string strWhereCond)
{
try
{
if (clscc_PaperStuBatchQuesRela_TotalBL.relatedActions != null)
{
List<string> arrIdPaperStuBatchQuesRelaTotal = GetPrimaryKeyID_S(strWhereCond);
foreach (var strIdPaperStuBatchQuesRelaTotal in arrIdPaperStuBatchQuesRelaTotal)
{
long lngIdPaperStuBatchQuesRelaTotal = long.Parse(strIdPaperStuBatchQuesRelaTotal);
clscc_PaperStuBatchQuesRela_TotalBL.relatedActions.UpdRelaTabDate(lngIdPaperStuBatchQuesRelaTotal, "UpdRelaTabDate");
}
}
int intRecNum = cc_PaperStuBatchQuesRela_TotalDA.Delcc_PaperStuBatchQuesRela_Total(strWhereCond);
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
/// 这里仅仅是演示函数,使用时请复制到扩展类:[cc_PaperStuBatchQuesRela_Total]中改名为:[DelRecord4MultiTabEx]使用
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DelRecord4MultiTab)
/// </summary>
/// <param name="lngIdPaperStuBatchQuesRelaTotal">表关键字</param>
/// <returns></returns>
public static bool DelRecord4MultiTab(long lngIdPaperStuBatchQuesRelaTotal)
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clscc_PaperStuBatchQuesRela_TotalDA.GetSpecSQLObj();
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
//删除与表:[cc_PaperStuBatchQuesRela_Total]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conStudent.id_College,
//strid_College);
//        clsStudentBL.DelStudentsByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clscc_PaperStuBatchQuesRela_TotalBL.DelRecord(lngIdPaperStuBatchQuesRelaTotal, objConnection, objSqlTransaction);
                objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clscc_PaperStuBatchQuesRela_TotalBL", "DelRecord4MultiTab", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("删除多表记录出错:{0}!keyId = {1}.({2})",
objException.Message,
lngIdPaperStuBatchQuesRelaTotal, clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "objcc_PaperStuBatchQuesRela_TotalENS">源对象</param>
 /// <param name = "objcc_PaperStuBatchQuesRela_TotalENT">目标对象</param>
 public static void CopyTo(clscc_PaperStuBatchQuesRela_TotalEN objcc_PaperStuBatchQuesRela_TotalENS, clscc_PaperStuBatchQuesRela_TotalEN objcc_PaperStuBatchQuesRela_TotalENT)
{
try
{
objcc_PaperStuBatchQuesRela_TotalENT.IdPaperStuBatchQuesRelaTotal = objcc_PaperStuBatchQuesRela_TotalENS.IdPaperStuBatchQuesRelaTotal; //学生试卷完成汇总流水号
objcc_PaperStuBatchQuesRela_TotalENT.IdPaperStuBatch = objcc_PaperStuBatchQuesRela_TotalENS.IdPaperStuBatch; //学生试卷批次流水号
objcc_PaperStuBatchQuesRela_TotalENT.QuesNum = objcc_PaperStuBatchQuesRela_TotalENS.QuesNum; //题目数
objcc_PaperStuBatchQuesRela_TotalENT.QuesNumLook = objcc_PaperStuBatchQuesRela_TotalENS.QuesNumLook; //查看题目数
objcc_PaperStuBatchQuesRela_TotalENT.QuesNumMark = objcc_PaperStuBatchQuesRela_TotalENS.QuesNumMark; //打分题目数
objcc_PaperStuBatchQuesRela_TotalENT.QuesNumNoFinish = objcc_PaperStuBatchQuesRela_TotalENS.QuesNumNoFinish; //未完成题目数
objcc_PaperStuBatchQuesRela_TotalENT.QuesNumOverdue = objcc_PaperStuBatchQuesRela_TotalENS.QuesNumOverdue; //逾期题目数
objcc_PaperStuBatchQuesRela_TotalENT.QuesNumSave = objcc_PaperStuBatchQuesRela_TotalENS.QuesNumSave; //保存题目数
objcc_PaperStuBatchQuesRela_TotalENT.QuesNumSendBack = objcc_PaperStuBatchQuesRela_TotalENS.QuesNumSendBack; //退回题目数
objcc_PaperStuBatchQuesRela_TotalENT.QuesNumSubmit = objcc_PaperStuBatchQuesRela_TotalENS.QuesNumSubmit; //提交题目数
objcc_PaperStuBatchQuesRela_TotalENT.TotalScore = objcc_PaperStuBatchQuesRela_TotalENS.TotalScore; //总得分
objcc_PaperStuBatchQuesRela_TotalENT.TotalScores = objcc_PaperStuBatchQuesRela_TotalENS.TotalScores; //总分值
objcc_PaperStuBatchQuesRela_TotalENT.SchoolYear = objcc_PaperStuBatchQuesRela_TotalENS.SchoolYear; //学年
objcc_PaperStuBatchQuesRela_TotalENT.SchoolTerm = objcc_PaperStuBatchQuesRela_TotalENS.SchoolTerm; //学期
objcc_PaperStuBatchQuesRela_TotalENT.UpdDate = objcc_PaperStuBatchQuesRela_TotalENS.UpdDate; //修改日期
objcc_PaperStuBatchQuesRela_TotalENT.UpdUserId = objcc_PaperStuBatchQuesRela_TotalENS.UpdUserId; //修改用户Id
objcc_PaperStuBatchQuesRela_TotalENT.Memo = objcc_PaperStuBatchQuesRela_TotalENS.Memo; //备注
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
 /// <param name = "objcc_PaperStuBatchQuesRela_TotalEN">源简化对象</param>
 public static void SetUpdFlag(clscc_PaperStuBatchQuesRela_TotalEN objcc_PaperStuBatchQuesRela_TotalEN)
{
try
{
objcc_PaperStuBatchQuesRela_TotalEN.ClearUpdateState();
   string strsfUpdFldSetStr = objcc_PaperStuBatchQuesRela_TotalEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(concc_PaperStuBatchQuesRela_Total.IdPaperStuBatchQuesRelaTotal, new clsStrCompareIgnoreCase())  ==  true)
{
objcc_PaperStuBatchQuesRela_TotalEN.IdPaperStuBatchQuesRelaTotal = objcc_PaperStuBatchQuesRela_TotalEN.IdPaperStuBatchQuesRelaTotal; //学生试卷完成汇总流水号
}
if (arrFldSet.Contains(concc_PaperStuBatchQuesRela_Total.IdPaperStuBatch, new clsStrCompareIgnoreCase())  ==  true)
{
objcc_PaperStuBatchQuesRela_TotalEN.IdPaperStuBatch = objcc_PaperStuBatchQuesRela_TotalEN.IdPaperStuBatch == "[null]" ? null :  objcc_PaperStuBatchQuesRela_TotalEN.IdPaperStuBatch; //学生试卷批次流水号
}
if (arrFldSet.Contains(concc_PaperStuBatchQuesRela_Total.QuesNum, new clsStrCompareIgnoreCase())  ==  true)
{
objcc_PaperStuBatchQuesRela_TotalEN.QuesNum = objcc_PaperStuBatchQuesRela_TotalEN.QuesNum; //题目数
}
if (arrFldSet.Contains(concc_PaperStuBatchQuesRela_Total.QuesNumLook, new clsStrCompareIgnoreCase())  ==  true)
{
objcc_PaperStuBatchQuesRela_TotalEN.QuesNumLook = objcc_PaperStuBatchQuesRela_TotalEN.QuesNumLook; //查看题目数
}
if (arrFldSet.Contains(concc_PaperStuBatchQuesRela_Total.QuesNumMark, new clsStrCompareIgnoreCase())  ==  true)
{
objcc_PaperStuBatchQuesRela_TotalEN.QuesNumMark = objcc_PaperStuBatchQuesRela_TotalEN.QuesNumMark; //打分题目数
}
if (arrFldSet.Contains(concc_PaperStuBatchQuesRela_Total.QuesNumNoFinish, new clsStrCompareIgnoreCase())  ==  true)
{
objcc_PaperStuBatchQuesRela_TotalEN.QuesNumNoFinish = objcc_PaperStuBatchQuesRela_TotalEN.QuesNumNoFinish; //未完成题目数
}
if (arrFldSet.Contains(concc_PaperStuBatchQuesRela_Total.QuesNumOverdue, new clsStrCompareIgnoreCase())  ==  true)
{
objcc_PaperStuBatchQuesRela_TotalEN.QuesNumOverdue = objcc_PaperStuBatchQuesRela_TotalEN.QuesNumOverdue; //逾期题目数
}
if (arrFldSet.Contains(concc_PaperStuBatchQuesRela_Total.QuesNumSave, new clsStrCompareIgnoreCase())  ==  true)
{
objcc_PaperStuBatchQuesRela_TotalEN.QuesNumSave = objcc_PaperStuBatchQuesRela_TotalEN.QuesNumSave; //保存题目数
}
if (arrFldSet.Contains(concc_PaperStuBatchQuesRela_Total.QuesNumSendBack, new clsStrCompareIgnoreCase())  ==  true)
{
objcc_PaperStuBatchQuesRela_TotalEN.QuesNumSendBack = objcc_PaperStuBatchQuesRela_TotalEN.QuesNumSendBack; //退回题目数
}
if (arrFldSet.Contains(concc_PaperStuBatchQuesRela_Total.QuesNumSubmit, new clsStrCompareIgnoreCase())  ==  true)
{
objcc_PaperStuBatchQuesRela_TotalEN.QuesNumSubmit = objcc_PaperStuBatchQuesRela_TotalEN.QuesNumSubmit; //提交题目数
}
if (arrFldSet.Contains(concc_PaperStuBatchQuesRela_Total.TotalScore, new clsStrCompareIgnoreCase())  ==  true)
{
objcc_PaperStuBatchQuesRela_TotalEN.TotalScore = objcc_PaperStuBatchQuesRela_TotalEN.TotalScore; //总得分
}
if (arrFldSet.Contains(concc_PaperStuBatchQuesRela_Total.TotalScores, new clsStrCompareIgnoreCase())  ==  true)
{
objcc_PaperStuBatchQuesRela_TotalEN.TotalScores = objcc_PaperStuBatchQuesRela_TotalEN.TotalScores; //总分值
}
if (arrFldSet.Contains(concc_PaperStuBatchQuesRela_Total.SchoolYear, new clsStrCompareIgnoreCase())  ==  true)
{
objcc_PaperStuBatchQuesRela_TotalEN.SchoolYear = objcc_PaperStuBatchQuesRela_TotalEN.SchoolYear == "[null]" ? null :  objcc_PaperStuBatchQuesRela_TotalEN.SchoolYear; //学年
}
if (arrFldSet.Contains(concc_PaperStuBatchQuesRela_Total.SchoolTerm, new clsStrCompareIgnoreCase())  ==  true)
{
objcc_PaperStuBatchQuesRela_TotalEN.SchoolTerm = objcc_PaperStuBatchQuesRela_TotalEN.SchoolTerm == "[null]" ? null :  objcc_PaperStuBatchQuesRela_TotalEN.SchoolTerm; //学期
}
if (arrFldSet.Contains(concc_PaperStuBatchQuesRela_Total.UpdDate, new clsStrCompareIgnoreCase())  ==  true)
{
objcc_PaperStuBatchQuesRela_TotalEN.UpdDate = objcc_PaperStuBatchQuesRela_TotalEN.UpdDate; //修改日期
}
if (arrFldSet.Contains(concc_PaperStuBatchQuesRela_Total.UpdUserId, new clsStrCompareIgnoreCase())  ==  true)
{
objcc_PaperStuBatchQuesRela_TotalEN.UpdUserId = objcc_PaperStuBatchQuesRela_TotalEN.UpdUserId == "[null]" ? null :  objcc_PaperStuBatchQuesRela_TotalEN.UpdUserId; //修改用户Id
}
if (arrFldSet.Contains(concc_PaperStuBatchQuesRela_Total.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objcc_PaperStuBatchQuesRela_TotalEN.Memo = objcc_PaperStuBatchQuesRela_TotalEN.Memo == "[null]" ? null :  objcc_PaperStuBatchQuesRela_TotalEN.Memo; //备注
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
 /// <param name = "objcc_PaperStuBatchQuesRela_TotalEN">源简化对象</param>
 public static void AccessFldValueNull(clscc_PaperStuBatchQuesRela_TotalEN objcc_PaperStuBatchQuesRela_TotalEN)
{
try
{
if (objcc_PaperStuBatchQuesRela_TotalEN.IdPaperStuBatch == "[null]") objcc_PaperStuBatchQuesRela_TotalEN.IdPaperStuBatch = null; //学生试卷批次流水号
if (objcc_PaperStuBatchQuesRela_TotalEN.SchoolYear == "[null]") objcc_PaperStuBatchQuesRela_TotalEN.SchoolYear = null; //学年
if (objcc_PaperStuBatchQuesRela_TotalEN.SchoolTerm == "[null]") objcc_PaperStuBatchQuesRela_TotalEN.SchoolTerm = null; //学期
if (objcc_PaperStuBatchQuesRela_TotalEN.UpdUserId == "[null]") objcc_PaperStuBatchQuesRela_TotalEN.UpdUserId = null; //修改用户Id
if (objcc_PaperStuBatchQuesRela_TotalEN.Memo == "[null]") objcc_PaperStuBatchQuesRela_TotalEN.Memo = null; //备注
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
public static void CheckPropertyNew(clscc_PaperStuBatchQuesRela_TotalEN objcc_PaperStuBatchQuesRela_TotalEN)
{
 cc_PaperStuBatchQuesRela_TotalDA.CheckPropertyNew(objcc_PaperStuBatchQuesRela_TotalEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(clscc_PaperStuBatchQuesRela_TotalEN objcc_PaperStuBatchQuesRela_TotalEN)
{
 cc_PaperStuBatchQuesRela_TotalDA.CheckProperty4Condition(objcc_PaperStuBatchQuesRela_TotalEN);
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
if (clscc_PaperStuBatchQuesRela_TotalBL.objCommFun4BL == null)
{
strMsg = string.Format("类clscc_PaperStuBatchQuesRela_TotalBL没有刷新缓存机制(clscc_PaperStuBatchQuesRela_TotalBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by IdPaperStuBatchQuesRelaTotal");
//if (arrcc_PaperStuBatchQuesRela_TotalObjLstCache == null)
//{
//arrcc_PaperStuBatchQuesRela_TotalObjLstCache = cc_PaperStuBatchQuesRela_TotalDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "lngIdPaperStuBatchQuesRelaTotal">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clscc_PaperStuBatchQuesRela_TotalEN GetObjByIdPaperStuBatchQuesRelaTotalCache(long lngIdPaperStuBatchQuesRelaTotal)
{
//获取缓存中的对象列表
string strKey = string.Format("{0}", clscc_PaperStuBatchQuesRela_TotalEN._CurrTabName);
List<clscc_PaperStuBatchQuesRela_TotalEN> arrcc_PaperStuBatchQuesRela_TotalObjLstCache = GetObjLstCache();
IEnumerable <clscc_PaperStuBatchQuesRela_TotalEN> arrcc_PaperStuBatchQuesRela_TotalObjLst_Sel =
arrcc_PaperStuBatchQuesRela_TotalObjLstCache
.Where(x=> x.IdPaperStuBatchQuesRelaTotal == lngIdPaperStuBatchQuesRelaTotal 
);
if (arrcc_PaperStuBatchQuesRela_TotalObjLst_Sel.Count() == 0)
{
   clscc_PaperStuBatchQuesRela_TotalEN obj = clscc_PaperStuBatchQuesRela_TotalBL.GetObjByIdPaperStuBatchQuesRelaTotal(lngIdPaperStuBatchQuesRelaTotal);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
 }
return null;
}
return arrcc_PaperStuBatchQuesRela_TotalObjLst_Sel.First();
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clscc_PaperStuBatchQuesRela_TotalEN> GetAllcc_PaperStuBatchQuesRela_TotalObjLstCache()
{
//获取缓存中的对象列表
List<clscc_PaperStuBatchQuesRela_TotalEN> arrcc_PaperStuBatchQuesRela_TotalObjLstCache = GetObjLstCache(); 
return arrcc_PaperStuBatchQuesRela_TotalObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clscc_PaperStuBatchQuesRela_TotalEN> GetObjLstCache()
{
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}", clscc_PaperStuBatchQuesRela_TotalEN._CurrTabName);
List<clscc_PaperStuBatchQuesRela_TotalEN> arrcc_PaperStuBatchQuesRela_TotalObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrcc_PaperStuBatchQuesRela_TotalObjLstCache;
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
string strKey = string.Format("{0}", clscc_PaperStuBatchQuesRela_TotalEN._CurrTabName);
CacheHelper.Remove(strKey);
clscc_PaperStuBatchQuesRela_TotalEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
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
if (clscc_PaperStuBatchQuesRela_TotalEN._RefreshTimeLst.Count == 0) return "";
return clscc_PaperStuBatchQuesRela_TotalEN._RefreshTimeLst[clscc_PaperStuBatchQuesRela_TotalEN._RefreshTimeLst.Count - 1];
}

 /// <summary>
 /// 刷新缓存.把当前表的缓存以及该表相关视图的缓存清空.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ReFreshCache)
 /// </summary>
public static void ReFreshCache()
{
if (clscc_PaperStuBatchQuesRela_TotalBL.objCommFun4BL != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}", clscc_PaperStuBatchQuesRela_TotalEN._CurrTabName);
CacheHelper.Remove(strKey);
clscc_PaperStuBatchQuesRela_TotalEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
clscc_PaperStuBatchQuesRela_TotalBL.objCommFun4BL.ReFreshCache();
}
}


 #endregion 缓存操作


 #region 检查唯一性

 /// <summary>
 /// 获取检查唯一性条件串(Uniqueness)--cc_PaperStuBatchQuesRela_Total(学生试卷完成汇总)
 /// 唯一性条件:Id_PaperStuBatch_SchoolTerm_SchoolYear
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetUniquenessConditionString)
 /// </summary>
 /// <param name = "objcc_PaperStuBatchQuesRela_TotalEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(clscc_PaperStuBatchQuesRela_TotalEN objcc_PaperStuBatchQuesRela_TotalEN)
{
//检测记录是否存在
string strResult = cc_PaperStuBatchQuesRela_TotalDA.GetUniCondStr(objcc_PaperStuBatchQuesRela_TotalEN);
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
public static string Func(string strInFldName, string strOutFldName, long lngIdPaperStuBatchQuesRelaTotal)
{
if (strInFldName != concc_PaperStuBatchQuesRela_Total.IdPaperStuBatchQuesRelaTotal)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (concc_PaperStuBatchQuesRela_Total.AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", concc_PaperStuBatchQuesRela_Total.AttributeName));
throw new Exception(strMsg);
}
var objcc_PaperStuBatchQuesRela_Total = clscc_PaperStuBatchQuesRela_TotalBL.GetObjByIdPaperStuBatchQuesRelaTotalCache(lngIdPaperStuBatchQuesRelaTotal);
if (objcc_PaperStuBatchQuesRela_Total == null) return "";
return objcc_PaperStuBatchQuesRela_Total[strOutFldName].ToString();
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
int intRecCount = clscc_PaperStuBatchQuesRela_TotalDA.GetRecCount(strTabName);
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
int intRecCount = clscc_PaperStuBatchQuesRela_TotalDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clscc_PaperStuBatchQuesRela_TotalDA.GetRecCount();
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
int intRecCount = clscc_PaperStuBatchQuesRela_TotalDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objcc_PaperStuBatchQuesRela_TotalCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clscc_PaperStuBatchQuesRela_TotalEN objcc_PaperStuBatchQuesRela_TotalCond)
{
List<clscc_PaperStuBatchQuesRela_TotalEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clscc_PaperStuBatchQuesRela_TotalEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in concc_PaperStuBatchQuesRela_Total.AttributeName)
{
if (objcc_PaperStuBatchQuesRela_TotalCond.IsUpdated(strFldName) == false) continue;
if (objcc_PaperStuBatchQuesRela_TotalCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objcc_PaperStuBatchQuesRela_TotalCond[strFldName].ToString());
}
else
{
if (objcc_PaperStuBatchQuesRela_TotalCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objcc_PaperStuBatchQuesRela_TotalCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objcc_PaperStuBatchQuesRela_TotalCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objcc_PaperStuBatchQuesRela_TotalCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objcc_PaperStuBatchQuesRela_TotalCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objcc_PaperStuBatchQuesRela_TotalCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objcc_PaperStuBatchQuesRela_TotalCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objcc_PaperStuBatchQuesRela_TotalCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objcc_PaperStuBatchQuesRela_TotalCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objcc_PaperStuBatchQuesRela_TotalCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objcc_PaperStuBatchQuesRela_TotalCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objcc_PaperStuBatchQuesRela_TotalCond[strFldName]));
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
 List<string> arrList = clscc_PaperStuBatchQuesRela_TotalDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = cc_PaperStuBatchQuesRela_TotalDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = cc_PaperStuBatchQuesRela_TotalDA.GetFldValueNoDistinct(strFldName, strWhereCond);
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
int intRecCount = cc_PaperStuBatchQuesRela_TotalDA.SetFldValue(strFldName, strValue, strWhereCond);
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
int intRecCount = clscc_PaperStuBatchQuesRela_TotalDA.SetFldValue(clscc_PaperStuBatchQuesRela_TotalEN._CurrTabName, strFldName, fltValue, strWhereCond);
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
int intRecCount = cc_PaperStuBatchQuesRela_TotalDA.SetFldValue( strFldName, intValue, strWhereCond);
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
int intRecCount = clscc_PaperStuBatchQuesRela_TotalDA.SetFldValue(strTabName, strFldName, strValue, strWhereCond);
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
int intRecCount = clscc_PaperStuBatchQuesRela_TotalDA.SetFldValue(strTabName, strFldName, intValue, strWhereCond);
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
int intRecCount = clscc_PaperStuBatchQuesRela_TotalDA.SetFldValue(strTabName, strFldName, fltValue, strWhereCond);
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
  strCreateTabCode.Append("CREATE table [dbo].[cc_PaperStuBatchQuesRela_Total] "); 
 strCreateTabCode.Append(" ( "); 
 // /**学生试卷完成汇总流水号*/ 
 strCreateTabCode.Append(" IdPaperStuBatchQuesRelaTotal bigint primary key identity, "); 
 // /**学生试卷批次流水号*/ 
 strCreateTabCode.Append(" IdPaperStuBatch char(10) Null, "); 
 // /**题目数*/ 
 strCreateTabCode.Append(" QuesNum int not Null, "); 
 // /**查看题目数*/ 
 strCreateTabCode.Append(" QuesNumLook int Null, "); 
 // /**打分题目数*/ 
 strCreateTabCode.Append(" QuesNumMark int Null, "); 
 // /**未完成题目数*/ 
 strCreateTabCode.Append(" QuesNumNoFinish int Null, "); 
 // /**逾期题目数*/ 
 strCreateTabCode.Append(" QuesNumOverdue int Null, "); 
 // /**保存题目数*/ 
 strCreateTabCode.Append(" QuesNumSave int Null, "); 
 // /**退回题目数*/ 
 strCreateTabCode.Append(" QuesNumSendBack int Null, "); 
 // /**提交题目数*/ 
 strCreateTabCode.Append(" QuesNumSubmit int Null, "); 
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
 /// 学生试卷完成汇总(cc_PaperStuBatchQuesRela_Total)
 /// 数据源类型:表
 /// (AutoGCLib.CommFun4BL4CSharp:GeneCode_This)
 /// </summary>
public class  clsCommFun4BL4cc_PaperStuBatchQuesRela_Total : clsCommFun4BL
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
clscc_PaperStuBatchQuesRela_TotalBL.ReFreshThisCache();
}
}

}