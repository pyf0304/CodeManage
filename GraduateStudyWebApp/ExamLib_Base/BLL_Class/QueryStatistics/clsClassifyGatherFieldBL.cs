
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsClassifyGatherFieldBL
 表名:ClassifyGatherField(01120012)
 * 版本:2024.11.13.1(服务器:WIN-SRV103-116)
 日期:2024/11/13 06:00:23
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:研究生学习游戏化后台(000055, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:查询统计(QueryStatistics)
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
public static class  clsClassifyGatherFieldBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public static clsClassifyGatherFieldEN GetObj(this K_mId_ClassifyGatherField myKey)
{
clsClassifyGatherFieldEN objClassifyGatherFieldEN = clsClassifyGatherFieldBL.ClassifyGatherFieldDA.GetObjBymId(myKey.Value);
return objClassifyGatherFieldEN;
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_AddNewRecord)
 /// </summary>
 /// <param name = "objClassifyGatherFieldEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clsClassifyGatherFieldEN objClassifyGatherFieldEN, bool bolIsNeedCheckUniqueness = true)
{
if (bolIsNeedCheckUniqueness == true && CheckUniqueness(objClassifyGatherFieldEN) == false)
{
var strMsg = string.Format("记录已经存在!分类统计Id = [{0}],题目Id = [{1}],分类字段类型Id = [{2}]的数据已经存在!(in clsClassifyGatherFieldBL.AddNewRecord)", objClassifyGatherFieldEN.ClassifyGatherId,objClassifyGatherFieldEN.QuestionId,objClassifyGatherFieldEN.ClassifyFieldTypeId);
throw new Exception(strMsg);
}
try
{
bool bolResult = clsClassifyGatherFieldBL.ClassifyGatherFieldDA.AddNewRecordBySQL2(objClassifyGatherFieldEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsClassifyGatherFieldBL.ReFreshCache();

if (clsClassifyGatherFieldBL.relatedActions != null)
{
clsClassifyGatherFieldBL.relatedActions.UpdRelaTabDate(objClassifyGatherFieldEN.mId, objClassifyGatherFieldEN.UpdUser);
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
public static bool AddRecordEx(this clsClassifyGatherFieldEN objClassifyGatherFieldEN, bool bolIsNeedCheckUniqueness = true)
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
objClassifyGatherFieldEN.CheckPropertyNew();
 ///5.2、检查唯一性
if (bolIsNeedCheckUniqueness == true && objClassifyGatherFieldEN.CheckUniqueness() == false)
{
strMsg = string.Format("(分类统计Id(ClassifyGatherId)=[{0}],题目Id(QuestionId)=[{1}],分类字段类型Id(ClassifyFieldTypeId)=[{2}])已经存在,不能重复!", objClassifyGatherFieldEN.ClassifyGatherId, objClassifyGatherFieldEN.QuestionId, objClassifyGatherFieldEN.ClassifyFieldTypeId);
throw new Exception(strMsg);
}
//6、把数据实体层的数据存贮到数据库中
objClassifyGatherFieldEN.AddNewRecord();
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
 /// <param name = "objClassifyGatherFieldEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordWithReturnKey(this clsClassifyGatherFieldEN objClassifyGatherFieldEN, bool bolIsNeedCheckUniqueness = true)
{
if (bolIsNeedCheckUniqueness == true && CheckUniqueness(objClassifyGatherFieldEN) == false)
{
var strMsg = string.Format("记录已经存在!分类统计Id = [{0}],题目Id = [{1}],分类字段类型Id = [{2}]的数据已经存在!(in clsClassifyGatherFieldBL.AddNewRecordWithReturnKey)", objClassifyGatherFieldEN.ClassifyGatherId,objClassifyGatherFieldEN.QuestionId,objClassifyGatherFieldEN.ClassifyFieldTypeId);
throw new Exception(strMsg);
}
try
{
string strKey = clsClassifyGatherFieldBL.ClassifyGatherFieldDA.AddNewRecordBySQL2WithReturnKey(objClassifyGatherFieldEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsClassifyGatherFieldBL.ReFreshCache();

if (clsClassifyGatherFieldBL.relatedActions != null)
{
clsClassifyGatherFieldBL.relatedActions.UpdRelaTabDate(objClassifyGatherFieldEN.mId, objClassifyGatherFieldEN.UpdUser);
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
 /// <param name = "objClassifyGatherFieldEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsClassifyGatherFieldEN SetmId(this clsClassifyGatherFieldEN objClassifyGatherFieldEN, long lngmId, string strComparisonOp="")
	{
objClassifyGatherFieldEN.mId = lngmId; //mId
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objClassifyGatherFieldEN.dicFldComparisonOp.ContainsKey(conClassifyGatherField.mId) == false)
{
objClassifyGatherFieldEN.dicFldComparisonOp.Add(conClassifyGatherField.mId, strComparisonOp);
}
else
{
objClassifyGatherFieldEN.dicFldComparisonOp[conClassifyGatherField.mId] = strComparisonOp;
}
}
return objClassifyGatherFieldEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objClassifyGatherFieldEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsClassifyGatherFieldEN SetClassifyGatherId(this clsClassifyGatherFieldEN objClassifyGatherFieldEN, string strClassifyGatherId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strClassifyGatherId, conClassifyGatherField.ClassifyGatherId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strClassifyGatherId, 4, conClassifyGatherField.ClassifyGatherId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strClassifyGatherId, 4, conClassifyGatherField.ClassifyGatherId);
}
objClassifyGatherFieldEN.ClassifyGatherId = strClassifyGatherId; //分类统计Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objClassifyGatherFieldEN.dicFldComparisonOp.ContainsKey(conClassifyGatherField.ClassifyGatherId) == false)
{
objClassifyGatherFieldEN.dicFldComparisonOp.Add(conClassifyGatherField.ClassifyGatherId, strComparisonOp);
}
else
{
objClassifyGatherFieldEN.dicFldComparisonOp[conClassifyGatherField.ClassifyGatherId] = strComparisonOp;
}
}
return objClassifyGatherFieldEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objClassifyGatherFieldEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsClassifyGatherFieldEN SetQuestionId(this clsClassifyGatherFieldEN objClassifyGatherFieldEN, long? lngQuestionId, string strComparisonOp="")
	{
objClassifyGatherFieldEN.QuestionId = lngQuestionId; //题目Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objClassifyGatherFieldEN.dicFldComparisonOp.ContainsKey(conClassifyGatherField.QuestionId) == false)
{
objClassifyGatherFieldEN.dicFldComparisonOp.Add(conClassifyGatherField.QuestionId, strComparisonOp);
}
else
{
objClassifyGatherFieldEN.dicFldComparisonOp[conClassifyGatherField.QuestionId] = strComparisonOp;
}
}
return objClassifyGatherFieldEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objClassifyGatherFieldEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsClassifyGatherFieldEN SetClassifyFieldTypeId(this clsClassifyGatherFieldEN objClassifyGatherFieldEN, string strClassifyFieldTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strClassifyFieldTypeId, conClassifyGatherField.ClassifyFieldTypeId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strClassifyFieldTypeId, 4, conClassifyGatherField.ClassifyFieldTypeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strClassifyFieldTypeId, 4, conClassifyGatherField.ClassifyFieldTypeId);
}
objClassifyGatherFieldEN.ClassifyFieldTypeId = strClassifyFieldTypeId; //分类字段类型Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objClassifyGatherFieldEN.dicFldComparisonOp.ContainsKey(conClassifyGatherField.ClassifyFieldTypeId) == false)
{
objClassifyGatherFieldEN.dicFldComparisonOp.Add(conClassifyGatherField.ClassifyFieldTypeId, strComparisonOp);
}
else
{
objClassifyGatherFieldEN.dicFldComparisonOp[conClassifyGatherField.ClassifyFieldTypeId] = strComparisonOp;
}
}
return objClassifyGatherFieldEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objClassifyGatherFieldEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsClassifyGatherFieldEN SetGatherModeId(this clsClassifyGatherFieldEN objClassifyGatherFieldEN, string strGatherModeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strGatherModeId, conClassifyGatherField.GatherModeId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strGatherModeId, 4, conClassifyGatherField.GatherModeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strGatherModeId, 4, conClassifyGatherField.GatherModeId);
}
objClassifyGatherFieldEN.GatherModeId = strGatherModeId; //汇总模式Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objClassifyGatherFieldEN.dicFldComparisonOp.ContainsKey(conClassifyGatherField.GatherModeId) == false)
{
objClassifyGatherFieldEN.dicFldComparisonOp.Add(conClassifyGatherField.GatherModeId, strComparisonOp);
}
else
{
objClassifyGatherFieldEN.dicFldComparisonOp[conClassifyGatherField.GatherModeId] = strComparisonOp;
}
}
return objClassifyGatherFieldEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objClassifyGatherFieldEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsClassifyGatherFieldEN SetDetailTitle(this clsClassifyGatherFieldEN objClassifyGatherFieldEN, string strDetailTitle, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strDetailTitle, 30, conClassifyGatherField.DetailTitle);
}
objClassifyGatherFieldEN.DetailTitle = strDetailTitle; //详细列表标题
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objClassifyGatherFieldEN.dicFldComparisonOp.ContainsKey(conClassifyGatherField.DetailTitle) == false)
{
objClassifyGatherFieldEN.dicFldComparisonOp.Add(conClassifyGatherField.DetailTitle, strComparisonOp);
}
else
{
objClassifyGatherFieldEN.dicFldComparisonOp[conClassifyGatherField.DetailTitle] = strComparisonOp;
}
}
return objClassifyGatherFieldEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objClassifyGatherFieldEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsClassifyGatherFieldEN SetIsDetailTitleIndexNo(this clsClassifyGatherFieldEN objClassifyGatherFieldEN, bool bolIsDetailTitleIndexNo, string strComparisonOp="")
	{
objClassifyGatherFieldEN.IsDetailTitleIndexNo = bolIsDetailTitleIndexNo; //标题是否编号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objClassifyGatherFieldEN.dicFldComparisonOp.ContainsKey(conClassifyGatherField.IsDetailTitleIndexNo) == false)
{
objClassifyGatherFieldEN.dicFldComparisonOp.Add(conClassifyGatherField.IsDetailTitleIndexNo, strComparisonOp);
}
else
{
objClassifyGatherFieldEN.dicFldComparisonOp[conClassifyGatherField.IsDetailTitleIndexNo] = strComparisonOp;
}
}
return objClassifyGatherFieldEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objClassifyGatherFieldEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsClassifyGatherFieldEN SetRecNo(this clsClassifyGatherFieldEN objClassifyGatherFieldEN, int intRecNo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(intRecNo, conClassifyGatherField.RecNo);
objClassifyGatherFieldEN.RecNo = intRecNo; //序号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objClassifyGatherFieldEN.dicFldComparisonOp.ContainsKey(conClassifyGatherField.RecNo) == false)
{
objClassifyGatherFieldEN.dicFldComparisonOp.Add(conClassifyGatherField.RecNo, strComparisonOp);
}
else
{
objClassifyGatherFieldEN.dicFldComparisonOp[conClassifyGatherField.RecNo] = strComparisonOp;
}
}
return objClassifyGatherFieldEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objClassifyGatherFieldEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsClassifyGatherFieldEN SetUpdDate(this clsClassifyGatherFieldEN objClassifyGatherFieldEN, string strUpdDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strUpdDate, conClassifyGatherField.UpdDate);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdDate, 20, conClassifyGatherField.UpdDate);
}
objClassifyGatherFieldEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objClassifyGatherFieldEN.dicFldComparisonOp.ContainsKey(conClassifyGatherField.UpdDate) == false)
{
objClassifyGatherFieldEN.dicFldComparisonOp.Add(conClassifyGatherField.UpdDate, strComparisonOp);
}
else
{
objClassifyGatherFieldEN.dicFldComparisonOp[conClassifyGatherField.UpdDate] = strComparisonOp;
}
}
return objClassifyGatherFieldEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objClassifyGatherFieldEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsClassifyGatherFieldEN SetUpdUser(this clsClassifyGatherFieldEN objClassifyGatherFieldEN, string strUpdUser, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strUpdUser, conClassifyGatherField.UpdUser);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdUser, 20, conClassifyGatherField.UpdUser);
}
objClassifyGatherFieldEN.UpdUser = strUpdUser; //修改人
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objClassifyGatherFieldEN.dicFldComparisonOp.ContainsKey(conClassifyGatherField.UpdUser) == false)
{
objClassifyGatherFieldEN.dicFldComparisonOp.Add(conClassifyGatherField.UpdUser, strComparisonOp);
}
else
{
objClassifyGatherFieldEN.dicFldComparisonOp[conClassifyGatherField.UpdUser] = strComparisonOp;
}
}
return objClassifyGatherFieldEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objClassifyGatherFieldEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsClassifyGatherFieldEN SetMemo(this clsClassifyGatherFieldEN objClassifyGatherFieldEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, conClassifyGatherField.Memo);
}
objClassifyGatherFieldEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objClassifyGatherFieldEN.dicFldComparisonOp.ContainsKey(conClassifyGatherField.Memo) == false)
{
objClassifyGatherFieldEN.dicFldComparisonOp.Add(conClassifyGatherField.Memo, strComparisonOp);
}
else
{
objClassifyGatherFieldEN.dicFldComparisonOp[conClassifyGatherField.Memo] = strComparisonOp;
}
}
return objClassifyGatherFieldEN;
	}

 /// <summary>
 /// 修改记录存盘到数据表中
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_UpdateRecordEx)
 /// </summary>
 /// <param name = "objClassifyGatherFieldEN">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool UpdateRecordEx(this clsClassifyGatherFieldEN objClassifyGatherFieldEN)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
try
{
//1、检查传进去的对象属性是否合法
objClassifyGatherFieldEN.CheckPropertyNew();
clsClassifyGatherFieldEN objClassifyGatherFieldCond = new clsClassifyGatherFieldEN();
string strCondition = objClassifyGatherFieldCond
.SetmId(objClassifyGatherFieldEN.mId, "<>")
.SetClassifyGatherId(objClassifyGatherFieldEN.ClassifyGatherId, "=")
.SetQuestionId(objClassifyGatherFieldEN.QuestionId, "=")
.SetClassifyFieldTypeId(objClassifyGatherFieldEN.ClassifyFieldTypeId, "=")
.GetCombineCondition();
objClassifyGatherFieldEN._IsCheckProperty = true;
bool bolIsExist = clsClassifyGatherFieldBL.IsExistRecord(strCondition);
if (bolIsExist)
{
strMsg = "(ClassifyGatherId_QuestionID_ClassifyFieldTypeId)不能重复!";
throw new Exception(strMsg);
}
//4、把数据实体层的数据存贮到数据库中
objClassifyGatherFieldEN.Update();
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
 /// <param name = "objClassifyGatherField">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool EditRecordEx(this clsClassifyGatherFieldEN objClassifyGatherField)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
clsClassifyGatherFieldEN objClassifyGatherFieldCond = new clsClassifyGatherFieldEN();
string strCondition = objClassifyGatherFieldCond
.SetClassifyGatherId(objClassifyGatherField.ClassifyGatherId, "=")
.SetQuestionId(objClassifyGatherField.QuestionId, "=")
.SetClassifyFieldTypeId(objClassifyGatherField.ClassifyFieldTypeId, "=")
.GetCombineCondition();
objClassifyGatherField._IsCheckProperty = true;
bool bolIsExist = clsClassifyGatherFieldBL.IsExistRecord(strCondition);
if (bolIsExist)
{
objClassifyGatherField.mId = clsClassifyGatherFieldBL.GetFirstID_S(strCondition);
objClassifyGatherField.UpdateWithCondition(strCondition);
}
else
{
objClassifyGatherField.AddNewRecord();
}
return true; 
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_Update)
 /// </summary>
 /// <param name = "objClassifyGatherFieldEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsClassifyGatherFieldEN objClassifyGatherFieldEN)
{
 if (objClassifyGatherFieldEN.mId == 0)
 {
string strMsg = string.Format("(errid:Busi000095)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsClassifyGatherFieldBL.ClassifyGatherFieldDA.UpdateBySql2(objClassifyGatherFieldEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsClassifyGatherFieldBL.ReFreshCache();

if (clsClassifyGatherFieldBL.relatedActions != null)
{
clsClassifyGatherFieldBL.relatedActions.UpdRelaTabDate(objClassifyGatherFieldEN.mId, objClassifyGatherFieldEN.UpdUser);
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
 /// <param name = "objClassifyGatherFieldEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsClassifyGatherFieldEN objClassifyGatherFieldEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (objClassifyGatherFieldEN.mId == 0)
 {
string strMsg = string.Format("(errid:Busi000087)修改记录时关键字不能为空!(带事务处理)(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsClassifyGatherFieldBL.ClassifyGatherFieldDA.UpdateBySql2(objClassifyGatherFieldEN, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsClassifyGatherFieldBL.ReFreshCache();

if (clsClassifyGatherFieldBL.relatedActions != null)
{
clsClassifyGatherFieldBL.relatedActions.UpdRelaTabDate(objClassifyGatherFieldEN.mId, objClassifyGatherFieldEN.UpdUser);
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
 /// <param name = "objClassifyGatherFieldEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsClassifyGatherFieldEN objClassifyGatherFieldEN, string strWhereCond)
{
try
{
bool bolResult = clsClassifyGatherFieldBL.ClassifyGatherFieldDA.UpdateBySqlWithCondition(objClassifyGatherFieldEN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsClassifyGatherFieldBL.ReFreshCache();

if (clsClassifyGatherFieldBL.relatedActions != null)
{
clsClassifyGatherFieldBL.relatedActions.UpdRelaTabDate(objClassifyGatherFieldEN.mId, objClassifyGatherFieldEN.UpdUser);
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
 /// <param name = "objClassifyGatherFieldEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsClassifyGatherFieldEN objClassifyGatherFieldEN, string strWhereCond, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
bool bolResult = clsClassifyGatherFieldBL.ClassifyGatherFieldDA.UpdateBySqlWithConditionTransaction(objClassifyGatherFieldEN, strWhereCond, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsClassifyGatherFieldBL.ReFreshCache();

if (clsClassifyGatherFieldBL.relatedActions != null)
{
clsClassifyGatherFieldBL.relatedActions.UpdRelaTabDate(objClassifyGatherFieldEN.mId, objClassifyGatherFieldEN.UpdUser);
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
public static int Delete(this clsClassifyGatherFieldEN objClassifyGatherFieldEN)
{
try
{
int intRecNum = clsClassifyGatherFieldBL.ClassifyGatherFieldDA.DelRecord(objClassifyGatherFieldEN.mId);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsClassifyGatherFieldBL.ReFreshCache();

if (clsClassifyGatherFieldBL.relatedActions != null)
{
clsClassifyGatherFieldBL.relatedActions.UpdRelaTabDate(objClassifyGatherFieldEN.mId, objClassifyGatherFieldEN.UpdUser);
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
 /// <param name = "objClassifyGatherFieldENS">源对象</param>
 /// <param name = "objClassifyGatherFieldENT">目标对象</param>
 public static void CopyTo(this clsClassifyGatherFieldEN objClassifyGatherFieldENS, clsClassifyGatherFieldEN objClassifyGatherFieldENT)
{
try
{
objClassifyGatherFieldENT.mId = objClassifyGatherFieldENS.mId; //mId
objClassifyGatherFieldENT.ClassifyGatherId = objClassifyGatherFieldENS.ClassifyGatherId; //分类统计Id
objClassifyGatherFieldENT.QuestionId = objClassifyGatherFieldENS.QuestionId; //题目Id
objClassifyGatherFieldENT.ClassifyFieldTypeId = objClassifyGatherFieldENS.ClassifyFieldTypeId; //分类字段类型Id
objClassifyGatherFieldENT.GatherModeId = objClassifyGatherFieldENS.GatherModeId; //汇总模式Id
objClassifyGatherFieldENT.DetailTitle = objClassifyGatherFieldENS.DetailTitle; //详细列表标题
objClassifyGatherFieldENT.IsDetailTitleIndexNo = objClassifyGatherFieldENS.IsDetailTitleIndexNo; //标题是否编号
objClassifyGatherFieldENT.RecNo = objClassifyGatherFieldENS.RecNo; //序号
objClassifyGatherFieldENT.UpdDate = objClassifyGatherFieldENS.UpdDate; //修改日期
objClassifyGatherFieldENT.UpdUser = objClassifyGatherFieldENS.UpdUser; //修改人
objClassifyGatherFieldENT.Memo = objClassifyGatherFieldENS.Memo; //备注
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
 /// <param name = "objClassifyGatherFieldENS">源对象</param>
 /// <returns>目标对象=>clsClassifyGatherFieldEN:objClassifyGatherFieldENT</returns>
 public static clsClassifyGatherFieldEN CopyTo(this clsClassifyGatherFieldEN objClassifyGatherFieldENS)
{
try
{
 clsClassifyGatherFieldEN objClassifyGatherFieldENT = new clsClassifyGatherFieldEN()
{
mId = objClassifyGatherFieldENS.mId, //mId
ClassifyGatherId = objClassifyGatherFieldENS.ClassifyGatherId, //分类统计Id
QuestionId = objClassifyGatherFieldENS.QuestionId, //题目Id
ClassifyFieldTypeId = objClassifyGatherFieldENS.ClassifyFieldTypeId, //分类字段类型Id
GatherModeId = objClassifyGatherFieldENS.GatherModeId, //汇总模式Id
DetailTitle = objClassifyGatherFieldENS.DetailTitle, //详细列表标题
IsDetailTitleIndexNo = objClassifyGatherFieldENS.IsDetailTitleIndexNo, //标题是否编号
RecNo = objClassifyGatherFieldENS.RecNo, //序号
UpdDate = objClassifyGatherFieldENS.UpdDate, //修改日期
UpdUser = objClassifyGatherFieldENS.UpdUser, //修改人
Memo = objClassifyGatherFieldENS.Memo, //备注
};
 return objClassifyGatherFieldENT;
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
public static void CheckPropertyNew(this clsClassifyGatherFieldEN objClassifyGatherFieldEN)
{
 clsClassifyGatherFieldBL.ClassifyGatherFieldDA.CheckPropertyNew(objClassifyGatherFieldEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(this clsClassifyGatherFieldEN objClassifyGatherFieldEN)
{
 clsClassifyGatherFieldBL.ClassifyGatherFieldDA.CheckProperty4Condition(objClassifyGatherFieldEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsClassifyGatherFieldEN objClassifyGatherFieldCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objClassifyGatherFieldCond.IsUpdated(conClassifyGatherField.mId) == true)
{
string strComparisonOpmId = objClassifyGatherFieldCond.dicFldComparisonOp[conClassifyGatherField.mId];
strWhereCond += string.Format(" And {0} {2} {1}", conClassifyGatherField.mId, objClassifyGatherFieldCond.mId, strComparisonOpmId);
}
if (objClassifyGatherFieldCond.IsUpdated(conClassifyGatherField.ClassifyGatherId) == true)
{
string strComparisonOpClassifyGatherId = objClassifyGatherFieldCond.dicFldComparisonOp[conClassifyGatherField.ClassifyGatherId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conClassifyGatherField.ClassifyGatherId, objClassifyGatherFieldCond.ClassifyGatherId, strComparisonOpClassifyGatherId);
}
if (objClassifyGatherFieldCond.IsUpdated(conClassifyGatherField.QuestionId) == true)
{
string strComparisonOpQuestionId = objClassifyGatherFieldCond.dicFldComparisonOp[conClassifyGatherField.QuestionId];
strWhereCond += string.Format(" And {0} {2} {1}", conClassifyGatherField.QuestionId, objClassifyGatherFieldCond.QuestionId, strComparisonOpQuestionId);
}
if (objClassifyGatherFieldCond.IsUpdated(conClassifyGatherField.ClassifyFieldTypeId) == true)
{
string strComparisonOpClassifyFieldTypeId = objClassifyGatherFieldCond.dicFldComparisonOp[conClassifyGatherField.ClassifyFieldTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conClassifyGatherField.ClassifyFieldTypeId, objClassifyGatherFieldCond.ClassifyFieldTypeId, strComparisonOpClassifyFieldTypeId);
}
if (objClassifyGatherFieldCond.IsUpdated(conClassifyGatherField.GatherModeId) == true)
{
string strComparisonOpGatherModeId = objClassifyGatherFieldCond.dicFldComparisonOp[conClassifyGatherField.GatherModeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conClassifyGatherField.GatherModeId, objClassifyGatherFieldCond.GatherModeId, strComparisonOpGatherModeId);
}
if (objClassifyGatherFieldCond.IsUpdated(conClassifyGatherField.DetailTitle) == true)
{
string strComparisonOpDetailTitle = objClassifyGatherFieldCond.dicFldComparisonOp[conClassifyGatherField.DetailTitle];
strWhereCond += string.Format(" And {0} {2} '{1}'", conClassifyGatherField.DetailTitle, objClassifyGatherFieldCond.DetailTitle, strComparisonOpDetailTitle);
}
if (objClassifyGatherFieldCond.IsUpdated(conClassifyGatherField.IsDetailTitleIndexNo) == true)
{
if (objClassifyGatherFieldCond.IsDetailTitleIndexNo == true)
{
strWhereCond += string.Format(" And {0} = '1'", conClassifyGatherField.IsDetailTitleIndexNo);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conClassifyGatherField.IsDetailTitleIndexNo);
}
}
if (objClassifyGatherFieldCond.IsUpdated(conClassifyGatherField.RecNo) == true)
{
string strComparisonOpRecNo = objClassifyGatherFieldCond.dicFldComparisonOp[conClassifyGatherField.RecNo];
strWhereCond += string.Format(" And {0} {2} {1}", conClassifyGatherField.RecNo, objClassifyGatherFieldCond.RecNo, strComparisonOpRecNo);
}
if (objClassifyGatherFieldCond.IsUpdated(conClassifyGatherField.UpdDate) == true)
{
string strComparisonOpUpdDate = objClassifyGatherFieldCond.dicFldComparisonOp[conClassifyGatherField.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conClassifyGatherField.UpdDate, objClassifyGatherFieldCond.UpdDate, strComparisonOpUpdDate);
}
if (objClassifyGatherFieldCond.IsUpdated(conClassifyGatherField.UpdUser) == true)
{
string strComparisonOpUpdUser = objClassifyGatherFieldCond.dicFldComparisonOp[conClassifyGatherField.UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", conClassifyGatherField.UpdUser, objClassifyGatherFieldCond.UpdUser, strComparisonOpUpdUser);
}
if (objClassifyGatherFieldCond.IsUpdated(conClassifyGatherField.Memo) == true)
{
string strComparisonOpMemo = objClassifyGatherFieldCond.dicFldComparisonOp[conClassifyGatherField.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", conClassifyGatherField.Memo, objClassifyGatherFieldCond.Memo, strComparisonOpMemo);
}
 return strWhereCond;
}

 /// <summary>
 /// 检查唯一性(Uniqueness)--ClassifyGatherField(分类汇总字段), 如果不唯一,即存在相同的记录,就返回False
 /// 唯一性条件:ClassifyGatherId_QuestionID_ClassifyFieldTypeId
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckConstraint)
 /// </summary>
 /// <param name = "objClassifyGatherFieldEN">要求唯一的对象</param>
 /// <returns></returns>
public static bool CheckUniqueness(this clsClassifyGatherFieldEN objClassifyGatherFieldEN)
{
//检测记录是否存在
bool bolIsUniqueness;
StringBuilder sbCondition = new StringBuilder();
if (objClassifyGatherFieldEN == null) return true;
if (objClassifyGatherFieldEN.mId == 0)
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and ClassifyGatherId = '{0}'", objClassifyGatherFieldEN.ClassifyGatherId);
 if (objClassifyGatherFieldEN.QuestionId == null)
{
 sbCondition.AppendFormat(" and QuestionId is null", objClassifyGatherFieldEN.QuestionId);
}
else
{
 sbCondition.AppendFormat(" and QuestionId = '{0}'", objClassifyGatherFieldEN.QuestionId);
}
 sbCondition.AppendFormat(" and ClassifyFieldTypeId = '{0}'", objClassifyGatherFieldEN.ClassifyFieldTypeId);
if (clsClassifyGatherFieldBL.IsExistRecord(sbCondition.ToString())  ==  true)
{
 bolIsUniqueness = false;
}
else
{
 bolIsUniqueness = true;
}
}
 else {
sbCondition.AppendFormat("mId !=  {0}", objClassifyGatherFieldEN.mId);
 sbCondition.AppendFormat(" and ClassifyGatherId = '{0}'", objClassifyGatherFieldEN.ClassifyGatherId);
 sbCondition.AppendFormat(" and QuestionId = '{0}'", objClassifyGatherFieldEN.QuestionId);
 sbCondition.AppendFormat(" and ClassifyFieldTypeId = '{0}'", objClassifyGatherFieldEN.ClassifyFieldTypeId);
if (clsClassifyGatherFieldBL.IsExistRecord(sbCondition.ToString())  ==  true)
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
 /// 获取唯一性条件串--ClassifyGatherField(分类汇总字段), 即由对象中唯一性条件字段关键字与值组成的条件串
 /// 唯一性条件:ClassifyGatherId_QuestionID_ClassifyFieldTypeId
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetConditionString4Constraint)
 /// </summary>
 /// <param name = "objClassifyGatherFieldEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(this clsClassifyGatherFieldEN objClassifyGatherFieldEN)
{
//检测记录是否存在
StringBuilder sbCondition = new StringBuilder();
if (objClassifyGatherFieldEN == null) return "";
if (objClassifyGatherFieldEN.mId == 0)
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and ClassifyGatherId = '{0}'", objClassifyGatherFieldEN.ClassifyGatherId);
 if (objClassifyGatherFieldEN.QuestionId == null)
{
 sbCondition.AppendFormat(" and QuestionId is null", objClassifyGatherFieldEN.QuestionId);
}
else
{
 sbCondition.AppendFormat(" and QuestionId = '{0}'", objClassifyGatherFieldEN.QuestionId);
}
 sbCondition.AppendFormat(" and ClassifyFieldTypeId = '{0}'", objClassifyGatherFieldEN.ClassifyFieldTypeId);
return sbCondition.ToString();
}
 else {
sbCondition.AppendFormat("mId !=  {0}", objClassifyGatherFieldEN.mId);
 sbCondition.AppendFormat(" and ClassifyGatherId = '{0}'", objClassifyGatherFieldEN.ClassifyGatherId);
 sbCondition.AppendFormat(" and QuestionId = '{0}'", objClassifyGatherFieldEN.QuestionId);
 sbCondition.AppendFormat(" and ClassifyFieldTypeId = '{0}'", objClassifyGatherFieldEN.ClassifyFieldTypeId);
 return sbCondition.ToString();
}
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_ClassifyGatherField
{
public virtual bool UpdRelaTabDate(long lngmId, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// 分类汇总字段(ClassifyGatherField)
 /// 数据源类型:表
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsClassifyGatherFieldBL
{
public static RelatedActions_ClassifyGatherField relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsClassifyGatherFieldDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsClassifyGatherFieldDA ClassifyGatherFieldDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsClassifyGatherFieldDA();
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
 public clsClassifyGatherFieldBL()
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
if (string.IsNullOrEmpty(clsClassifyGatherFieldEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsClassifyGatherFieldEN._ConnectString);
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
public static DataTable GetDataTable_ClassifyGatherField(string strWhereCond)
{
DataTable objDT;
try
{
objDT = ClassifyGatherFieldDA.GetDataTable_ClassifyGatherField(strWhereCond);
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
objDT = ClassifyGatherFieldDA.GetDataTable(strWhereCond);
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
objDT = ClassifyGatherFieldDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = ClassifyGatherFieldDA.GetDataTable(strWhereCond, strTabName);
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
objDT = ClassifyGatherFieldDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = ClassifyGatherFieldDA.GetDataTable_Top(objTopPara);
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
objDT = ClassifyGatherFieldDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = ClassifyGatherFieldDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = ClassifyGatherFieldDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
public static List<clsClassifyGatherFieldEN> GetObjLstByMIdLst(List<long> arrMIdLst)
{
List<clsClassifyGatherFieldEN> arrObjLst = new List<clsClassifyGatherFieldEN>(); 
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
	clsClassifyGatherFieldEN objClassifyGatherFieldEN = new clsClassifyGatherFieldEN();
try
{
objClassifyGatherFieldEN.mId = Int32.Parse(objRow[conClassifyGatherField.mId].ToString().Trim()); //mId
objClassifyGatherFieldEN.ClassifyGatherId = objRow[conClassifyGatherField.ClassifyGatherId].ToString().Trim(); //分类统计Id
objClassifyGatherFieldEN.QuestionId = objRow[conClassifyGatherField.QuestionId] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[conClassifyGatherField.QuestionId].ToString().Trim()); //题目Id
objClassifyGatherFieldEN.ClassifyFieldTypeId = objRow[conClassifyGatherField.ClassifyFieldTypeId].ToString().Trim(); //分类字段类型Id
objClassifyGatherFieldEN.GatherModeId = objRow[conClassifyGatherField.GatherModeId].ToString().Trim(); //汇总模式Id
objClassifyGatherFieldEN.DetailTitle = objRow[conClassifyGatherField.DetailTitle] == DBNull.Value ? null : objRow[conClassifyGatherField.DetailTitle].ToString().Trim(); //详细列表标题
objClassifyGatherFieldEN.IsDetailTitleIndexNo = clsEntityBase2.TransNullToBool_S(objRow[conClassifyGatherField.IsDetailTitleIndexNo].ToString().Trim()); //标题是否编号
objClassifyGatherFieldEN.RecNo = Int32.Parse(objRow[conClassifyGatherField.RecNo].ToString().Trim()); //序号
objClassifyGatherFieldEN.UpdDate = objRow[conClassifyGatherField.UpdDate].ToString().Trim(); //修改日期
objClassifyGatherFieldEN.UpdUser = objRow[conClassifyGatherField.UpdUser].ToString().Trim(); //修改人
objClassifyGatherFieldEN.Memo = objRow[conClassifyGatherField.Memo] == DBNull.Value ? null : objRow[conClassifyGatherField.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objClassifyGatherFieldEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objClassifyGatherFieldEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrMIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsClassifyGatherFieldEN> GetObjLstByMIdLstCache(List<long> arrMIdLst)
{
string strKey = string.Format("{0}", clsClassifyGatherFieldEN._CurrTabName);
List<clsClassifyGatherFieldEN> arrClassifyGatherFieldObjLstCache = GetObjLstCache();
IEnumerable <clsClassifyGatherFieldEN> arrClassifyGatherFieldObjLst_Sel =
arrClassifyGatherFieldObjLstCache
.Where(x => arrMIdLst.Contains(x.mId));
return arrClassifyGatherFieldObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsClassifyGatherFieldEN> GetObjLst(string strWhereCond)
{
List<clsClassifyGatherFieldEN> arrObjLst = new List<clsClassifyGatherFieldEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsClassifyGatherFieldEN objClassifyGatherFieldEN = new clsClassifyGatherFieldEN();
try
{
objClassifyGatherFieldEN.mId = Int32.Parse(objRow[conClassifyGatherField.mId].ToString().Trim()); //mId
objClassifyGatherFieldEN.ClassifyGatherId = objRow[conClassifyGatherField.ClassifyGatherId].ToString().Trim(); //分类统计Id
objClassifyGatherFieldEN.QuestionId = objRow[conClassifyGatherField.QuestionId] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[conClassifyGatherField.QuestionId].ToString().Trim()); //题目Id
objClassifyGatherFieldEN.ClassifyFieldTypeId = objRow[conClassifyGatherField.ClassifyFieldTypeId].ToString().Trim(); //分类字段类型Id
objClassifyGatherFieldEN.GatherModeId = objRow[conClassifyGatherField.GatherModeId].ToString().Trim(); //汇总模式Id
objClassifyGatherFieldEN.DetailTitle = objRow[conClassifyGatherField.DetailTitle] == DBNull.Value ? null : objRow[conClassifyGatherField.DetailTitle].ToString().Trim(); //详细列表标题
objClassifyGatherFieldEN.IsDetailTitleIndexNo = clsEntityBase2.TransNullToBool_S(objRow[conClassifyGatherField.IsDetailTitleIndexNo].ToString().Trim()); //标题是否编号
objClassifyGatherFieldEN.RecNo = Int32.Parse(objRow[conClassifyGatherField.RecNo].ToString().Trim()); //序号
objClassifyGatherFieldEN.UpdDate = objRow[conClassifyGatherField.UpdDate].ToString().Trim(); //修改日期
objClassifyGatherFieldEN.UpdUser = objRow[conClassifyGatherField.UpdUser].ToString().Trim(); //修改人
objClassifyGatherFieldEN.Memo = objRow[conClassifyGatherField.Memo] == DBNull.Value ? null : objRow[conClassifyGatherField.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objClassifyGatherFieldEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objClassifyGatherFieldEN);
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
public static List<clsClassifyGatherFieldEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsClassifyGatherFieldEN> arrObjLst = new List<clsClassifyGatherFieldEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsClassifyGatherFieldEN objClassifyGatherFieldEN = new clsClassifyGatherFieldEN();
try
{
objClassifyGatherFieldEN.mId = Int32.Parse(objRow[conClassifyGatherField.mId].ToString().Trim()); //mId
objClassifyGatherFieldEN.ClassifyGatherId = objRow[conClassifyGatherField.ClassifyGatherId].ToString().Trim(); //分类统计Id
objClassifyGatherFieldEN.QuestionId = objRow[conClassifyGatherField.QuestionId] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[conClassifyGatherField.QuestionId].ToString().Trim()); //题目Id
objClassifyGatherFieldEN.ClassifyFieldTypeId = objRow[conClassifyGatherField.ClassifyFieldTypeId].ToString().Trim(); //分类字段类型Id
objClassifyGatherFieldEN.GatherModeId = objRow[conClassifyGatherField.GatherModeId].ToString().Trim(); //汇总模式Id
objClassifyGatherFieldEN.DetailTitle = objRow[conClassifyGatherField.DetailTitle] == DBNull.Value ? null : objRow[conClassifyGatherField.DetailTitle].ToString().Trim(); //详细列表标题
objClassifyGatherFieldEN.IsDetailTitleIndexNo = clsEntityBase2.TransNullToBool_S(objRow[conClassifyGatherField.IsDetailTitleIndexNo].ToString().Trim()); //标题是否编号
objClassifyGatherFieldEN.RecNo = Int32.Parse(objRow[conClassifyGatherField.RecNo].ToString().Trim()); //序号
objClassifyGatherFieldEN.UpdDate = objRow[conClassifyGatherField.UpdDate].ToString().Trim(); //修改日期
objClassifyGatherFieldEN.UpdUser = objRow[conClassifyGatherField.UpdUser].ToString().Trim(); //修改人
objClassifyGatherFieldEN.Memo = objRow[conClassifyGatherField.Memo] == DBNull.Value ? null : objRow[conClassifyGatherField.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objClassifyGatherFieldEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objClassifyGatherFieldEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objClassifyGatherFieldCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsClassifyGatherFieldEN> GetSubObjLstCache(clsClassifyGatherFieldEN objClassifyGatherFieldCond)
{
List<clsClassifyGatherFieldEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsClassifyGatherFieldEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conClassifyGatherField.AttributeName)
{
if (objClassifyGatherFieldCond.IsUpdated(strFldName) == false) continue;
if (objClassifyGatherFieldCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objClassifyGatherFieldCond[strFldName].ToString());
}
else
{
if (objClassifyGatherFieldCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objClassifyGatherFieldCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objClassifyGatherFieldCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objClassifyGatherFieldCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objClassifyGatherFieldCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objClassifyGatherFieldCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objClassifyGatherFieldCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objClassifyGatherFieldCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objClassifyGatherFieldCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objClassifyGatherFieldCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objClassifyGatherFieldCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objClassifyGatherFieldCond[strFldName]));
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
public static List<clsClassifyGatherFieldEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsClassifyGatherFieldEN> arrObjLst = new List<clsClassifyGatherFieldEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsClassifyGatherFieldEN objClassifyGatherFieldEN = new clsClassifyGatherFieldEN();
try
{
objClassifyGatherFieldEN.mId = Int32.Parse(objRow[conClassifyGatherField.mId].ToString().Trim()); //mId
objClassifyGatherFieldEN.ClassifyGatherId = objRow[conClassifyGatherField.ClassifyGatherId].ToString().Trim(); //分类统计Id
objClassifyGatherFieldEN.QuestionId = objRow[conClassifyGatherField.QuestionId] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[conClassifyGatherField.QuestionId].ToString().Trim()); //题目Id
objClassifyGatherFieldEN.ClassifyFieldTypeId = objRow[conClassifyGatherField.ClassifyFieldTypeId].ToString().Trim(); //分类字段类型Id
objClassifyGatherFieldEN.GatherModeId = objRow[conClassifyGatherField.GatherModeId].ToString().Trim(); //汇总模式Id
objClassifyGatherFieldEN.DetailTitle = objRow[conClassifyGatherField.DetailTitle] == DBNull.Value ? null : objRow[conClassifyGatherField.DetailTitle].ToString().Trim(); //详细列表标题
objClassifyGatherFieldEN.IsDetailTitleIndexNo = clsEntityBase2.TransNullToBool_S(objRow[conClassifyGatherField.IsDetailTitleIndexNo].ToString().Trim()); //标题是否编号
objClassifyGatherFieldEN.RecNo = Int32.Parse(objRow[conClassifyGatherField.RecNo].ToString().Trim()); //序号
objClassifyGatherFieldEN.UpdDate = objRow[conClassifyGatherField.UpdDate].ToString().Trim(); //修改日期
objClassifyGatherFieldEN.UpdUser = objRow[conClassifyGatherField.UpdUser].ToString().Trim(); //修改人
objClassifyGatherFieldEN.Memo = objRow[conClassifyGatherField.Memo] == DBNull.Value ? null : objRow[conClassifyGatherField.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objClassifyGatherFieldEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objClassifyGatherFieldEN);
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
public static List<clsClassifyGatherFieldEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsClassifyGatherFieldEN> arrObjLst = new List<clsClassifyGatherFieldEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsClassifyGatherFieldEN objClassifyGatherFieldEN = new clsClassifyGatherFieldEN();
try
{
objClassifyGatherFieldEN.mId = Int32.Parse(objRow[conClassifyGatherField.mId].ToString().Trim()); //mId
objClassifyGatherFieldEN.ClassifyGatherId = objRow[conClassifyGatherField.ClassifyGatherId].ToString().Trim(); //分类统计Id
objClassifyGatherFieldEN.QuestionId = objRow[conClassifyGatherField.QuestionId] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[conClassifyGatherField.QuestionId].ToString().Trim()); //题目Id
objClassifyGatherFieldEN.ClassifyFieldTypeId = objRow[conClassifyGatherField.ClassifyFieldTypeId].ToString().Trim(); //分类字段类型Id
objClassifyGatherFieldEN.GatherModeId = objRow[conClassifyGatherField.GatherModeId].ToString().Trim(); //汇总模式Id
objClassifyGatherFieldEN.DetailTitle = objRow[conClassifyGatherField.DetailTitle] == DBNull.Value ? null : objRow[conClassifyGatherField.DetailTitle].ToString().Trim(); //详细列表标题
objClassifyGatherFieldEN.IsDetailTitleIndexNo = clsEntityBase2.TransNullToBool_S(objRow[conClassifyGatherField.IsDetailTitleIndexNo].ToString().Trim()); //标题是否编号
objClassifyGatherFieldEN.RecNo = Int32.Parse(objRow[conClassifyGatherField.RecNo].ToString().Trim()); //序号
objClassifyGatherFieldEN.UpdDate = objRow[conClassifyGatherField.UpdDate].ToString().Trim(); //修改日期
objClassifyGatherFieldEN.UpdUser = objRow[conClassifyGatherField.UpdUser].ToString().Trim(); //修改人
objClassifyGatherFieldEN.Memo = objRow[conClassifyGatherField.Memo] == DBNull.Value ? null : objRow[conClassifyGatherField.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objClassifyGatherFieldEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objClassifyGatherFieldEN);
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
List<clsClassifyGatherFieldEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsClassifyGatherFieldEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsClassifyGatherFieldEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsClassifyGatherFieldEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsClassifyGatherFieldEN> arrObjLst = new List<clsClassifyGatherFieldEN>(); 
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
	clsClassifyGatherFieldEN objClassifyGatherFieldEN = new clsClassifyGatherFieldEN();
try
{
objClassifyGatherFieldEN.mId = Int32.Parse(objRow[conClassifyGatherField.mId].ToString().Trim()); //mId
objClassifyGatherFieldEN.ClassifyGatherId = objRow[conClassifyGatherField.ClassifyGatherId].ToString().Trim(); //分类统计Id
objClassifyGatherFieldEN.QuestionId = objRow[conClassifyGatherField.QuestionId] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[conClassifyGatherField.QuestionId].ToString().Trim()); //题目Id
objClassifyGatherFieldEN.ClassifyFieldTypeId = objRow[conClassifyGatherField.ClassifyFieldTypeId].ToString().Trim(); //分类字段类型Id
objClassifyGatherFieldEN.GatherModeId = objRow[conClassifyGatherField.GatherModeId].ToString().Trim(); //汇总模式Id
objClassifyGatherFieldEN.DetailTitle = objRow[conClassifyGatherField.DetailTitle] == DBNull.Value ? null : objRow[conClassifyGatherField.DetailTitle].ToString().Trim(); //详细列表标题
objClassifyGatherFieldEN.IsDetailTitleIndexNo = clsEntityBase2.TransNullToBool_S(objRow[conClassifyGatherField.IsDetailTitleIndexNo].ToString().Trim()); //标题是否编号
objClassifyGatherFieldEN.RecNo = Int32.Parse(objRow[conClassifyGatherField.RecNo].ToString().Trim()); //序号
objClassifyGatherFieldEN.UpdDate = objRow[conClassifyGatherField.UpdDate].ToString().Trim(); //修改日期
objClassifyGatherFieldEN.UpdUser = objRow[conClassifyGatherField.UpdUser].ToString().Trim(); //修改人
objClassifyGatherFieldEN.Memo = objRow[conClassifyGatherField.Memo] == DBNull.Value ? null : objRow[conClassifyGatherField.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objClassifyGatherFieldEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objClassifyGatherFieldEN);
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
public static List<clsClassifyGatherFieldEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsClassifyGatherFieldEN> arrObjLst = new List<clsClassifyGatherFieldEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsClassifyGatherFieldEN objClassifyGatherFieldEN = new clsClassifyGatherFieldEN();
try
{
objClassifyGatherFieldEN.mId = Int32.Parse(objRow[conClassifyGatherField.mId].ToString().Trim()); //mId
objClassifyGatherFieldEN.ClassifyGatherId = objRow[conClassifyGatherField.ClassifyGatherId].ToString().Trim(); //分类统计Id
objClassifyGatherFieldEN.QuestionId = objRow[conClassifyGatherField.QuestionId] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[conClassifyGatherField.QuestionId].ToString().Trim()); //题目Id
objClassifyGatherFieldEN.ClassifyFieldTypeId = objRow[conClassifyGatherField.ClassifyFieldTypeId].ToString().Trim(); //分类字段类型Id
objClassifyGatherFieldEN.GatherModeId = objRow[conClassifyGatherField.GatherModeId].ToString().Trim(); //汇总模式Id
objClassifyGatherFieldEN.DetailTitle = objRow[conClassifyGatherField.DetailTitle] == DBNull.Value ? null : objRow[conClassifyGatherField.DetailTitle].ToString().Trim(); //详细列表标题
objClassifyGatherFieldEN.IsDetailTitleIndexNo = clsEntityBase2.TransNullToBool_S(objRow[conClassifyGatherField.IsDetailTitleIndexNo].ToString().Trim()); //标题是否编号
objClassifyGatherFieldEN.RecNo = Int32.Parse(objRow[conClassifyGatherField.RecNo].ToString().Trim()); //序号
objClassifyGatherFieldEN.UpdDate = objRow[conClassifyGatherField.UpdDate].ToString().Trim(); //修改日期
objClassifyGatherFieldEN.UpdUser = objRow[conClassifyGatherField.UpdUser].ToString().Trim(); //修改人
objClassifyGatherFieldEN.Memo = objRow[conClassifyGatherField.Memo] == DBNull.Value ? null : objRow[conClassifyGatherField.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objClassifyGatherFieldEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objClassifyGatherFieldEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsClassifyGatherFieldEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsClassifyGatherFieldEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsClassifyGatherFieldEN> arrObjLst = new List<clsClassifyGatherFieldEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsClassifyGatherFieldEN objClassifyGatherFieldEN = new clsClassifyGatherFieldEN();
try
{
objClassifyGatherFieldEN.mId = Int32.Parse(objRow[conClassifyGatherField.mId].ToString().Trim()); //mId
objClassifyGatherFieldEN.ClassifyGatherId = objRow[conClassifyGatherField.ClassifyGatherId].ToString().Trim(); //分类统计Id
objClassifyGatherFieldEN.QuestionId = objRow[conClassifyGatherField.QuestionId] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[conClassifyGatherField.QuestionId].ToString().Trim()); //题目Id
objClassifyGatherFieldEN.ClassifyFieldTypeId = objRow[conClassifyGatherField.ClassifyFieldTypeId].ToString().Trim(); //分类字段类型Id
objClassifyGatherFieldEN.GatherModeId = objRow[conClassifyGatherField.GatherModeId].ToString().Trim(); //汇总模式Id
objClassifyGatherFieldEN.DetailTitle = objRow[conClassifyGatherField.DetailTitle] == DBNull.Value ? null : objRow[conClassifyGatherField.DetailTitle].ToString().Trim(); //详细列表标题
objClassifyGatherFieldEN.IsDetailTitleIndexNo = clsEntityBase2.TransNullToBool_S(objRow[conClassifyGatherField.IsDetailTitleIndexNo].ToString().Trim()); //标题是否编号
objClassifyGatherFieldEN.RecNo = Int32.Parse(objRow[conClassifyGatherField.RecNo].ToString().Trim()); //序号
objClassifyGatherFieldEN.UpdDate = objRow[conClassifyGatherField.UpdDate].ToString().Trim(); //修改日期
objClassifyGatherFieldEN.UpdUser = objRow[conClassifyGatherField.UpdUser].ToString().Trim(); //修改人
objClassifyGatherFieldEN.Memo = objRow[conClassifyGatherField.Memo] == DBNull.Value ? null : objRow[conClassifyGatherField.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objClassifyGatherFieldEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objClassifyGatherFieldEN);
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
public static List<clsClassifyGatherFieldEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsClassifyGatherFieldEN> arrObjLst = new List<clsClassifyGatherFieldEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsClassifyGatherFieldEN objClassifyGatherFieldEN = new clsClassifyGatherFieldEN();
try
{
objClassifyGatherFieldEN.mId = Int32.Parse(objRow[conClassifyGatherField.mId].ToString().Trim()); //mId
objClassifyGatherFieldEN.ClassifyGatherId = objRow[conClassifyGatherField.ClassifyGatherId].ToString().Trim(); //分类统计Id
objClassifyGatherFieldEN.QuestionId = objRow[conClassifyGatherField.QuestionId] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[conClassifyGatherField.QuestionId].ToString().Trim()); //题目Id
objClassifyGatherFieldEN.ClassifyFieldTypeId = objRow[conClassifyGatherField.ClassifyFieldTypeId].ToString().Trim(); //分类字段类型Id
objClassifyGatherFieldEN.GatherModeId = objRow[conClassifyGatherField.GatherModeId].ToString().Trim(); //汇总模式Id
objClassifyGatherFieldEN.DetailTitle = objRow[conClassifyGatherField.DetailTitle] == DBNull.Value ? null : objRow[conClassifyGatherField.DetailTitle].ToString().Trim(); //详细列表标题
objClassifyGatherFieldEN.IsDetailTitleIndexNo = clsEntityBase2.TransNullToBool_S(objRow[conClassifyGatherField.IsDetailTitleIndexNo].ToString().Trim()); //标题是否编号
objClassifyGatherFieldEN.RecNo = Int32.Parse(objRow[conClassifyGatherField.RecNo].ToString().Trim()); //序号
objClassifyGatherFieldEN.UpdDate = objRow[conClassifyGatherField.UpdDate].ToString().Trim(); //修改日期
objClassifyGatherFieldEN.UpdUser = objRow[conClassifyGatherField.UpdUser].ToString().Trim(); //修改人
objClassifyGatherFieldEN.Memo = objRow[conClassifyGatherField.Memo] == DBNull.Value ? null : objRow[conClassifyGatherField.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objClassifyGatherFieldEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objClassifyGatherFieldEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsClassifyGatherFieldEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsClassifyGatherFieldEN> arrObjLst = new List<clsClassifyGatherFieldEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsClassifyGatherFieldEN objClassifyGatherFieldEN = new clsClassifyGatherFieldEN();
try
{
objClassifyGatherFieldEN.mId = Int32.Parse(objRow[conClassifyGatherField.mId].ToString().Trim()); //mId
objClassifyGatherFieldEN.ClassifyGatherId = objRow[conClassifyGatherField.ClassifyGatherId].ToString().Trim(); //分类统计Id
objClassifyGatherFieldEN.QuestionId = objRow[conClassifyGatherField.QuestionId] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[conClassifyGatherField.QuestionId].ToString().Trim()); //题目Id
objClassifyGatherFieldEN.ClassifyFieldTypeId = objRow[conClassifyGatherField.ClassifyFieldTypeId].ToString().Trim(); //分类字段类型Id
objClassifyGatherFieldEN.GatherModeId = objRow[conClassifyGatherField.GatherModeId].ToString().Trim(); //汇总模式Id
objClassifyGatherFieldEN.DetailTitle = objRow[conClassifyGatherField.DetailTitle] == DBNull.Value ? null : objRow[conClassifyGatherField.DetailTitle].ToString().Trim(); //详细列表标题
objClassifyGatherFieldEN.IsDetailTitleIndexNo = clsEntityBase2.TransNullToBool_S(objRow[conClassifyGatherField.IsDetailTitleIndexNo].ToString().Trim()); //标题是否编号
objClassifyGatherFieldEN.RecNo = Int32.Parse(objRow[conClassifyGatherField.RecNo].ToString().Trim()); //序号
objClassifyGatherFieldEN.UpdDate = objRow[conClassifyGatherField.UpdDate].ToString().Trim(); //修改日期
objClassifyGatherFieldEN.UpdUser = objRow[conClassifyGatherField.UpdUser].ToString().Trim(); //修改人
objClassifyGatherFieldEN.Memo = objRow[conClassifyGatherField.Memo] == DBNull.Value ? null : objRow[conClassifyGatherField.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objClassifyGatherFieldEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objClassifyGatherFieldEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objClassifyGatherFieldEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetClassifyGatherField(ref clsClassifyGatherFieldEN objClassifyGatherFieldEN)
{
bool bolResult = ClassifyGatherFieldDA.GetClassifyGatherField(ref objClassifyGatherFieldEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public static clsClassifyGatherFieldEN GetObjBymId(long lngmId)
{
clsClassifyGatherFieldEN objClassifyGatherFieldEN = ClassifyGatherFieldDA.GetObjBymId(lngmId);
return objClassifyGatherFieldEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsClassifyGatherFieldEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsClassifyGatherFieldEN objClassifyGatherFieldEN = ClassifyGatherFieldDA.GetFirstObj(strWhereCond);
 return objClassifyGatherFieldEN;
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
public static clsClassifyGatherFieldEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsClassifyGatherFieldEN objClassifyGatherFieldEN = ClassifyGatherFieldDA.GetObjByDataRow(objRow);
 return objClassifyGatherFieldEN;
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
public static clsClassifyGatherFieldEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsClassifyGatherFieldEN objClassifyGatherFieldEN = ClassifyGatherFieldDA.GetObjByDataRow(objRow);
 return objClassifyGatherFieldEN;
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
 /// <param name = "lstClassifyGatherFieldObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsClassifyGatherFieldEN GetObjBymIdFromList(long lngmId, List<clsClassifyGatherFieldEN> lstClassifyGatherFieldObjLst)
{
foreach (clsClassifyGatherFieldEN objClassifyGatherFieldEN in lstClassifyGatherFieldObjLst)
{
if (objClassifyGatherFieldEN.mId == lngmId)
{
return objClassifyGatherFieldEN;
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
 lngmId = new clsClassifyGatherFieldDA().GetFirstID(strWhereCond);
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
 arrList = ClassifyGatherFieldDA.GetID(strWhereCond);
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
bool bolIsExist = ClassifyGatherFieldDA.IsExistCondRec(strWhereCond);
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
bool bolIsExist = ClassifyGatherFieldDA.IsExist(lngmId);
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
clsClassifyGatherFieldEN objClassifyGatherFieldEN = clsClassifyGatherFieldBL.GetObjBymId(lngmId);
objClassifyGatherFieldEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
objClassifyGatherFieldEN.UpdUser = strOpUser;
return clsClassifyGatherFieldBL.UpdateBySql2(objClassifyGatherFieldEN);
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
 bolIsExist = clsClassifyGatherFieldDA.IsExistTable();
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
 bolIsExist = ClassifyGatherFieldDA.IsExistTable(strTabName);
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
 /// <param name = "objClassifyGatherFieldEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecordBySql2(clsClassifyGatherFieldEN objClassifyGatherFieldEN, bool bolIsNeedCheckUniqueness=true)
{
if (bolIsNeedCheckUniqueness == true && objClassifyGatherFieldEN.CheckUniqueness() == false)
{
var strMsg = string.Format("记录已经存在!分类统计Id = [{0}],题目Id = [{1}],分类字段类型Id = [{2}]的数据已经存在!(in clsClassifyGatherFieldBL.AddNewRecordBySql2)", objClassifyGatherFieldEN.ClassifyGatherId,objClassifyGatherFieldEN.QuestionId,objClassifyGatherFieldEN.ClassifyFieldTypeId);
throw new Exception(strMsg);
}
try
{
bool bolResult = ClassifyGatherFieldDA.AddNewRecordBySQL2(objClassifyGatherFieldEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsClassifyGatherFieldBL.ReFreshCache();

if (clsClassifyGatherFieldBL.relatedActions != null)
{
clsClassifyGatherFieldBL.relatedActions.UpdRelaTabDate(objClassifyGatherFieldEN.mId, objClassifyGatherFieldEN.UpdUser);
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
 /// <param name = "objClassifyGatherFieldEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordBySql2WithReturnKey(clsClassifyGatherFieldEN objClassifyGatherFieldEN, bool bolIsNeedCheckUniqueness=true)
{
if (bolIsNeedCheckUniqueness == true && objClassifyGatherFieldEN.CheckUniqueness() == false)
{
var strMsg = string.Format("记录已经存在!分类统计Id = [{0}],题目Id = [{1}],分类字段类型Id = [{2}]的数据已经存在!(in clsClassifyGatherFieldBL.AddNewRecordBySql2WithReturnKey)", objClassifyGatherFieldEN.ClassifyGatherId,objClassifyGatherFieldEN.QuestionId,objClassifyGatherFieldEN.ClassifyFieldTypeId);
throw new Exception(strMsg);
}
try
{
string strKey = ClassifyGatherFieldDA.AddNewRecordBySQL2WithReturnKey(objClassifyGatherFieldEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsClassifyGatherFieldBL.ReFreshCache();

if (clsClassifyGatherFieldBL.relatedActions != null)
{
clsClassifyGatherFieldBL.relatedActions.UpdRelaTabDate(objClassifyGatherFieldEN.mId, objClassifyGatherFieldEN.UpdUser);
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
 /// <param name = "objClassifyGatherFieldEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(clsClassifyGatherFieldEN objClassifyGatherFieldEN)
{
try
{
bool bolResult = ClassifyGatherFieldDA.Update(objClassifyGatherFieldEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsClassifyGatherFieldBL.ReFreshCache();

if (clsClassifyGatherFieldBL.relatedActions != null)
{
clsClassifyGatherFieldBL.relatedActions.UpdRelaTabDate(objClassifyGatherFieldEN.mId, objClassifyGatherFieldEN.UpdUser);
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
 /// <param name = "objClassifyGatherFieldEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateBySql2(clsClassifyGatherFieldEN objClassifyGatherFieldEN)
{
 if (objClassifyGatherFieldEN.mId == 0)
 {
var strMsg = string.Format("(errid:Busi000065)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = ClassifyGatherFieldDA.UpdateBySql2(objClassifyGatherFieldEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsClassifyGatherFieldBL.ReFreshCache();

if (clsClassifyGatherFieldBL.relatedActions != null)
{
clsClassifyGatherFieldBL.relatedActions.UpdRelaTabDate(objClassifyGatherFieldEN.mId, objClassifyGatherFieldEN.UpdUser);
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
 clsClassifyGatherFieldEN objClassifyGatherFieldEN = clsClassifyGatherFieldBL.GetObjBymId(lngmId);

if (clsClassifyGatherFieldBL.relatedActions != null)
{
clsClassifyGatherFieldBL.relatedActions.UpdRelaTabDate(objClassifyGatherFieldEN.mId, objClassifyGatherFieldEN.UpdUser);
}
if (objClassifyGatherFieldEN != null)
{
int intRecNum = ClassifyGatherFieldDA.DelRecord(lngmId);
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
/// <param name="lngmId">表关键字</param>
/// <returns></returns>
public static bool DelRecordEx(long lngmId )
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsClassifyGatherFieldDA.GetSpecSQLObj();
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
//删除与表:[ClassifyGatherField]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conClassifyGatherField.mId,
//lngmId);
//        clsClassifyGatherFieldBL.DelClassifyGatherFieldsByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsClassifyGatherFieldBL.DelRecord(lngmId, objConnection, objSqlTransaction);
objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsClassifyGatherFieldBLEx", "DelRecordEx", objException.Message, clsSysParaEN.strUserId);
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
public static bool DelRecord(long lngmId, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
if (clsClassifyGatherFieldBL.relatedActions != null)
{
clsClassifyGatherFieldBL.relatedActions.UpdRelaTabDate(lngmId, "UpdRelaTabDate");
}
bool bolResult = ClassifyGatherFieldDA.DelRecord(lngmId,objSqlConnection,objSqlTransaction);
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
 /// <param name = "arrmIdLst">给定的关键字值列表</param>
 /// <returns>返回删除的记录数</returns>
public static int DelClassifyGatherFields(List<string> arrmIdLst)
{
if (arrmIdLst.Count == 0) return 0;
try
{
if (clsClassifyGatherFieldBL.relatedActions != null)
{
foreach (var strmId in arrmIdLst)
{
long lngmId = long.Parse(strmId);
clsClassifyGatherFieldBL.relatedActions.UpdRelaTabDate(lngmId, "UpdRelaTabDate");
}
}
int intDelRecNum = ClassifyGatherFieldDA.DelClassifyGatherField(arrmIdLst);
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
public static int DelClassifyGatherFieldsByCond(string strWhereCond)
{
try
{
if (clsClassifyGatherFieldBL.relatedActions != null)
{
List<string> arrmId = GetPrimaryKeyID_S(strWhereCond);
foreach (var strmId in arrmId)
{
long lngmId = long.Parse(strmId);
clsClassifyGatherFieldBL.relatedActions.UpdRelaTabDate(lngmId, "UpdRelaTabDate");
}
}
int intRecNum = ClassifyGatherFieldDA.DelClassifyGatherField(strWhereCond);
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
/// 这里仅仅是演示函数,使用时请复制到扩展类:[ClassifyGatherField]中改名为:[DelRecord4MultiTabEx]使用
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DelRecord4MultiTab)
/// </summary>
/// <param name="lngmId">表关键字</param>
/// <returns></returns>
public static bool DelRecord4MultiTab(long lngmId)
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsClassifyGatherFieldDA.GetSpecSQLObj();
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
//删除与表:[ClassifyGatherField]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conStudent.id_College,
//strid_College);
//        clsStudentBL.DelStudentsByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsClassifyGatherFieldBL.DelRecord(lngmId, objConnection, objSqlTransaction);
                objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsClassifyGatherFieldBL", "DelRecord4MultiTab", objException.Message, clsSysParaEN.strUserId);
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
 /// <param name = "objClassifyGatherFieldENS">源对象</param>
 /// <param name = "objClassifyGatherFieldENT">目标对象</param>
 public static void CopyTo(clsClassifyGatherFieldEN objClassifyGatherFieldENS, clsClassifyGatherFieldEN objClassifyGatherFieldENT)
{
try
{
objClassifyGatherFieldENT.mId = objClassifyGatherFieldENS.mId; //mId
objClassifyGatherFieldENT.ClassifyGatherId = objClassifyGatherFieldENS.ClassifyGatherId; //分类统计Id
objClassifyGatherFieldENT.QuestionId = objClassifyGatherFieldENS.QuestionId; //题目Id
objClassifyGatherFieldENT.ClassifyFieldTypeId = objClassifyGatherFieldENS.ClassifyFieldTypeId; //分类字段类型Id
objClassifyGatherFieldENT.GatherModeId = objClassifyGatherFieldENS.GatherModeId; //汇总模式Id
objClassifyGatherFieldENT.DetailTitle = objClassifyGatherFieldENS.DetailTitle; //详细列表标题
objClassifyGatherFieldENT.IsDetailTitleIndexNo = objClassifyGatherFieldENS.IsDetailTitleIndexNo; //标题是否编号
objClassifyGatherFieldENT.RecNo = objClassifyGatherFieldENS.RecNo; //序号
objClassifyGatherFieldENT.UpdDate = objClassifyGatherFieldENS.UpdDate; //修改日期
objClassifyGatherFieldENT.UpdUser = objClassifyGatherFieldENS.UpdUser; //修改人
objClassifyGatherFieldENT.Memo = objClassifyGatherFieldENS.Memo; //备注
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
 /// <param name = "objClassifyGatherFieldEN">源简化对象</param>
 public static void SetUpdFlag(clsClassifyGatherFieldEN objClassifyGatherFieldEN)
{
try
{
objClassifyGatherFieldEN.ClearUpdateState();
   string strsfUpdFldSetStr = objClassifyGatherFieldEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(conClassifyGatherField.mId, new clsStrCompareIgnoreCase())  ==  true)
{
objClassifyGatherFieldEN.mId = objClassifyGatherFieldEN.mId; //mId
}
if (arrFldSet.Contains(conClassifyGatherField.ClassifyGatherId, new clsStrCompareIgnoreCase())  ==  true)
{
objClassifyGatherFieldEN.ClassifyGatherId = objClassifyGatherFieldEN.ClassifyGatherId; //分类统计Id
}
if (arrFldSet.Contains(conClassifyGatherField.QuestionId, new clsStrCompareIgnoreCase())  ==  true)
{
objClassifyGatherFieldEN.QuestionId = objClassifyGatherFieldEN.QuestionId; //题目Id
}
if (arrFldSet.Contains(conClassifyGatherField.ClassifyFieldTypeId, new clsStrCompareIgnoreCase())  ==  true)
{
objClassifyGatherFieldEN.ClassifyFieldTypeId = objClassifyGatherFieldEN.ClassifyFieldTypeId; //分类字段类型Id
}
if (arrFldSet.Contains(conClassifyGatherField.GatherModeId, new clsStrCompareIgnoreCase())  ==  true)
{
objClassifyGatherFieldEN.GatherModeId = objClassifyGatherFieldEN.GatherModeId; //汇总模式Id
}
if (arrFldSet.Contains(conClassifyGatherField.DetailTitle, new clsStrCompareIgnoreCase())  ==  true)
{
objClassifyGatherFieldEN.DetailTitle = objClassifyGatherFieldEN.DetailTitle == "[null]" ? null :  objClassifyGatherFieldEN.DetailTitle; //详细列表标题
}
if (arrFldSet.Contains(conClassifyGatherField.IsDetailTitleIndexNo, new clsStrCompareIgnoreCase())  ==  true)
{
objClassifyGatherFieldEN.IsDetailTitleIndexNo = objClassifyGatherFieldEN.IsDetailTitleIndexNo; //标题是否编号
}
if (arrFldSet.Contains(conClassifyGatherField.RecNo, new clsStrCompareIgnoreCase())  ==  true)
{
objClassifyGatherFieldEN.RecNo = objClassifyGatherFieldEN.RecNo; //序号
}
if (arrFldSet.Contains(conClassifyGatherField.UpdDate, new clsStrCompareIgnoreCase())  ==  true)
{
objClassifyGatherFieldEN.UpdDate = objClassifyGatherFieldEN.UpdDate; //修改日期
}
if (arrFldSet.Contains(conClassifyGatherField.UpdUser, new clsStrCompareIgnoreCase())  ==  true)
{
objClassifyGatherFieldEN.UpdUser = objClassifyGatherFieldEN.UpdUser; //修改人
}
if (arrFldSet.Contains(conClassifyGatherField.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objClassifyGatherFieldEN.Memo = objClassifyGatherFieldEN.Memo == "[null]" ? null :  objClassifyGatherFieldEN.Memo; //备注
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
 /// <param name = "objClassifyGatherFieldEN">源简化对象</param>
 public static void AccessFldValueNull(clsClassifyGatherFieldEN objClassifyGatherFieldEN)
{
try
{
if (objClassifyGatherFieldEN.DetailTitle == "[null]") objClassifyGatherFieldEN.DetailTitle = null; //详细列表标题
if (objClassifyGatherFieldEN.Memo == "[null]") objClassifyGatherFieldEN.Memo = null; //备注
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
public static void CheckPropertyNew(clsClassifyGatherFieldEN objClassifyGatherFieldEN)
{
 ClassifyGatherFieldDA.CheckPropertyNew(objClassifyGatherFieldEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(clsClassifyGatherFieldEN objClassifyGatherFieldEN)
{
 ClassifyGatherFieldDA.CheckProperty4Condition(objClassifyGatherFieldEN);
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
if (clsClassifyGatherFieldBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsClassifyGatherFieldBL没有刷新缓存机制(clsClassifyGatherFieldBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by mId");
//if (arrClassifyGatherFieldObjLstCache == null)
//{
//arrClassifyGatherFieldObjLstCache = ClassifyGatherFieldDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "lngmId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsClassifyGatherFieldEN GetObjBymIdCache(long lngmId)
{
//获取缓存中的对象列表
string strKey = string.Format("{0}", clsClassifyGatherFieldEN._CurrTabName);
List<clsClassifyGatherFieldEN> arrClassifyGatherFieldObjLstCache = GetObjLstCache();
IEnumerable <clsClassifyGatherFieldEN> arrClassifyGatherFieldObjLst_Sel =
arrClassifyGatherFieldObjLstCache
.Where(x=> x.mId == lngmId 
);
if (arrClassifyGatherFieldObjLst_Sel.Count() == 0)
{
   clsClassifyGatherFieldEN obj = clsClassifyGatherFieldBL.GetObjBymId(lngmId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
 }
return null;
}
return arrClassifyGatherFieldObjLst_Sel.First();
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsClassifyGatherFieldEN> GetAllClassifyGatherFieldObjLstCache()
{
//获取缓存中的对象列表
List<clsClassifyGatherFieldEN> arrClassifyGatherFieldObjLstCache = GetObjLstCache(); 
return arrClassifyGatherFieldObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsClassifyGatherFieldEN> GetObjLstCache()
{
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}", clsClassifyGatherFieldEN._CurrTabName);
List<clsClassifyGatherFieldEN> arrClassifyGatherFieldObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrClassifyGatherFieldObjLstCache;
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
string strKey = string.Format("{0}", clsClassifyGatherFieldEN._CurrTabName);
CacheHelper.Remove(strKey);
clsClassifyGatherFieldEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
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
if (clsClassifyGatherFieldEN._RefreshTimeLst.Count == 0) return "";
return clsClassifyGatherFieldEN._RefreshTimeLst[clsClassifyGatherFieldEN._RefreshTimeLst.Count - 1];
}

 /// <summary>
 /// 刷新缓存.把当前表的缓存以及该表相关视图的缓存清空.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ReFreshCache)
 /// </summary>
public static void ReFreshCache()
{
if (clsClassifyGatherFieldBL.objCommFun4BL != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}", clsClassifyGatherFieldEN._CurrTabName);
CacheHelper.Remove(strKey);
clsClassifyGatherFieldEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
clsClassifyGatherFieldBL.objCommFun4BL.ReFreshCache();
}
}


 #endregion 缓存操作


 #region 检查唯一性

 /// <summary>
 /// 获取检查唯一性条件串(Uniqueness)--ClassifyGatherField(分类汇总字段)
 /// 唯一性条件:ClassifyGatherId_QuestionID_ClassifyFieldTypeId
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetUniquenessConditionString)
 /// </summary>
 /// <param name = "objClassifyGatherFieldEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(clsClassifyGatherFieldEN objClassifyGatherFieldEN)
{
//检测记录是否存在
string strResult = ClassifyGatherFieldDA.GetUniCondStr(objClassifyGatherFieldEN);
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
public static string Func(string strInFldName, string strOutFldName, long lngmId)
{
if (strInFldName != conClassifyGatherField.mId)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (conClassifyGatherField.AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", conClassifyGatherField.AttributeName));
throw new Exception(strMsg);
}
var objClassifyGatherField = clsClassifyGatherFieldBL.GetObjBymIdCache(lngmId);
if (objClassifyGatherField == null) return "";
return objClassifyGatherField[strOutFldName].ToString();
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
int intRecCount = clsClassifyGatherFieldDA.GetRecCount(strTabName);
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
int intRecCount = clsClassifyGatherFieldDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsClassifyGatherFieldDA.GetRecCount();
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
int intRecCount = clsClassifyGatherFieldDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objClassifyGatherFieldCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsClassifyGatherFieldEN objClassifyGatherFieldCond)
{
List<clsClassifyGatherFieldEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsClassifyGatherFieldEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conClassifyGatherField.AttributeName)
{
if (objClassifyGatherFieldCond.IsUpdated(strFldName) == false) continue;
if (objClassifyGatherFieldCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objClassifyGatherFieldCond[strFldName].ToString());
}
else
{
if (objClassifyGatherFieldCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objClassifyGatherFieldCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objClassifyGatherFieldCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objClassifyGatherFieldCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objClassifyGatherFieldCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objClassifyGatherFieldCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objClassifyGatherFieldCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objClassifyGatherFieldCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objClassifyGatherFieldCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objClassifyGatherFieldCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objClassifyGatherFieldCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objClassifyGatherFieldCond[strFldName]));
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
 List<string> arrList = clsClassifyGatherFieldDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = ClassifyGatherFieldDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = ClassifyGatherFieldDA.GetFldValueNoDistinct(strFldName, strWhereCond);
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
int intRecCount = ClassifyGatherFieldDA.SetFldValue(strFldName, strValue, strWhereCond);
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
int intRecCount = clsClassifyGatherFieldDA.SetFldValue(clsClassifyGatherFieldEN._CurrTabName, strFldName, fltValue, strWhereCond);
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
int intRecCount = ClassifyGatherFieldDA.SetFldValue( strFldName, intValue, strWhereCond);
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
int intRecCount = clsClassifyGatherFieldDA.SetFldValue(strTabName, strFldName, strValue, strWhereCond);
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
int intRecCount = clsClassifyGatherFieldDA.SetFldValue(strTabName, strFldName, intValue, strWhereCond);
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
int intRecCount = clsClassifyGatherFieldDA.SetFldValue(strTabName, strFldName, fltValue, strWhereCond);
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
  strCreateTabCode.Append("CREATE table [dbo].[ClassifyGatherField] "); 
 strCreateTabCode.Append(" ( "); 
 // /**mId*/ 
 strCreateTabCode.Append(" mId bigint primary key identity, "); 
 // /**分类统计Id*/ 
 strCreateTabCode.Append(" ClassifyGatherId char(4) not Null, "); 
 // /**题目Id*/ 
 strCreateTabCode.Append(" QuestionId bigint Null, "); 
 // /**分类字段类型Id*/ 
 strCreateTabCode.Append(" ClassifyFieldTypeId char(4) not Null, "); 
 // /**汇总模式Id*/ 
 strCreateTabCode.Append(" GatherModeId char(4) not Null, "); 
 // /**详细列表标题*/ 
 strCreateTabCode.Append(" DetailTitle varchar(30) Null, "); 
 // /**标题是否编号*/ 
 strCreateTabCode.Append(" IsDetailTitleIndexNo bit Null, "); 
 // /**序号*/ 
 strCreateTabCode.Append(" RecNo int not Null, "); 
 // /**修改日期*/ 
 strCreateTabCode.Append(" UpdDate varchar(20) not Null, "); 
 // /**修改人*/ 
 strCreateTabCode.Append(" UpdUser varchar(20) not Null, "); 
 // /**备注*/ 
 strCreateTabCode.Append(" Memo varchar(1000) Null ");
 strCreateTabCode.Append(") "); 
  strCreateTabCode.Append("ON [PRIMARY] ");
  return strCreateTabCode.ToString();
}



 #endregion 表操作
}
 /// <summary>
 /// 分类汇总字段(ClassifyGatherField)
 /// 数据源类型:表
 /// (AutoGCLib.CommFun4BL4CSharp:GeneCode_This)
 /// </summary>
public class  clsCommFun4BL4ClassifyGatherField : clsCommFun4BL
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
clsClassifyGatherFieldBL.ReFreshThisCache();
}
}

}