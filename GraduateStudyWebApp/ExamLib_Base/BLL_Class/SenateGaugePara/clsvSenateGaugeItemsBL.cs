
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvSenateGaugeItemsBL
 表名:vSenateGaugeItems(01120477)
 * 版本:2023.08.23.1(服务器:WIN-SRV103-116)
 日期:2023/08/24 14:49:27
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:公共后台所有表(变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:评价相关参数(SenateGaugePara)
 框架-层名:业务逻辑层(CS)(BusinessLogic)
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
public static class  clsvSenateGaugeItemsBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "strIdSenateGaugeItem">表关键字</param>
 /// <returns>表对象</returns>
public static clsvSenateGaugeItemsEN GetObj(this K_IdSenateGaugeItem_vSenateGaugeItems myKey)
{
clsvSenateGaugeItemsEN objvSenateGaugeItemsEN = clsvSenateGaugeItemsBL.vSenateGaugeItemsDA.GetObjByIdSenateGaugeItem(myKey.Value);
return objvSenateGaugeItemsEN;
}

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSenateGaugeItemsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvSenateGaugeItemsEN SetIdSenateGaugeItem(this clsvSenateGaugeItemsEN objvSenateGaugeItemsEN, string strIdSenateGaugeItem, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdSenateGaugeItem, 4, convSenateGaugeItems.IdSenateGaugeItem);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdSenateGaugeItem, 4, convSenateGaugeItems.IdSenateGaugeItem);
}
objvSenateGaugeItemsEN.IdSenateGaugeItem = strIdSenateGaugeItem; //量表指标流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvSenateGaugeItemsEN.dicFldComparisonOp.ContainsKey(convSenateGaugeItems.IdSenateGaugeItem) == false)
{
objvSenateGaugeItemsEN.dicFldComparisonOp.Add(convSenateGaugeItems.IdSenateGaugeItem, strComparisonOp);
}
else
{
objvSenateGaugeItemsEN.dicFldComparisonOp[convSenateGaugeItems.IdSenateGaugeItem] = strComparisonOp;
}
}
return objvSenateGaugeItemsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSenateGaugeItemsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvSenateGaugeItemsEN SetsenateGaugeItemID(this clsvSenateGaugeItemsEN objvSenateGaugeItemsEN, string strsenateGaugeItemID, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strsenateGaugeItemID, 4, convSenateGaugeItems.senateGaugeItemID);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strsenateGaugeItemID, 4, convSenateGaugeItems.senateGaugeItemID);
}
objvSenateGaugeItemsEN.senateGaugeItemID = strsenateGaugeItemID; //量表指标ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvSenateGaugeItemsEN.dicFldComparisonOp.ContainsKey(convSenateGaugeItems.senateGaugeItemID) == false)
{
objvSenateGaugeItemsEN.dicFldComparisonOp.Add(convSenateGaugeItems.senateGaugeItemID, strComparisonOp);
}
else
{
objvSenateGaugeItemsEN.dicFldComparisonOp[convSenateGaugeItems.senateGaugeItemID] = strComparisonOp;
}
}
return objvSenateGaugeItemsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSenateGaugeItemsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvSenateGaugeItemsEN SetsenateGaugeItemName(this clsvSenateGaugeItemsEN objvSenateGaugeItemsEN, string strsenateGaugeItemName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strsenateGaugeItemName, 200, convSenateGaugeItems.senateGaugeItemName);
}
objvSenateGaugeItemsEN.senateGaugeItemName = strsenateGaugeItemName; //量表指标名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvSenateGaugeItemsEN.dicFldComparisonOp.ContainsKey(convSenateGaugeItems.senateGaugeItemName) == false)
{
objvSenateGaugeItemsEN.dicFldComparisonOp.Add(convSenateGaugeItems.senateGaugeItemName, strComparisonOp);
}
else
{
objvSenateGaugeItemsEN.dicFldComparisonOp[convSenateGaugeItems.senateGaugeItemName] = strComparisonOp;
}
}
return objvSenateGaugeItemsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSenateGaugeItemsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvSenateGaugeItemsEN SetIdSenateGaugeVersion(this clsvSenateGaugeItemsEN objvSenateGaugeItemsEN, string strIdSenateGaugeVersion, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strIdSenateGaugeVersion, convSenateGaugeItems.IdSenateGaugeVersion);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdSenateGaugeVersion, 4, convSenateGaugeItems.IdSenateGaugeVersion);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdSenateGaugeVersion, 4, convSenateGaugeItems.IdSenateGaugeVersion);
}
objvSenateGaugeItemsEN.IdSenateGaugeVersion = strIdSenateGaugeVersion; //评价量表版本流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvSenateGaugeItemsEN.dicFldComparisonOp.ContainsKey(convSenateGaugeItems.IdSenateGaugeVersion) == false)
{
objvSenateGaugeItemsEN.dicFldComparisonOp.Add(convSenateGaugeItems.IdSenateGaugeVersion, strComparisonOp);
}
else
{
objvSenateGaugeItemsEN.dicFldComparisonOp[convSenateGaugeItems.IdSenateGaugeVersion] = strComparisonOp;
}
}
return objvSenateGaugeItemsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSenateGaugeItemsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvSenateGaugeItemsEN SetsenateGaugeVersionName(this clsvSenateGaugeItemsEN objvSenateGaugeItemsEN, string strsenateGaugeVersionName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strsenateGaugeVersionName, 200, convSenateGaugeItems.senateGaugeVersionName);
}
objvSenateGaugeItemsEN.senateGaugeVersionName = strsenateGaugeVersionName; //评价量表版本名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvSenateGaugeItemsEN.dicFldComparisonOp.ContainsKey(convSenateGaugeItems.senateGaugeVersionName) == false)
{
objvSenateGaugeItemsEN.dicFldComparisonOp.Add(convSenateGaugeItems.senateGaugeVersionName, strComparisonOp);
}
else
{
objvSenateGaugeItemsEN.dicFldComparisonOp[convSenateGaugeItems.senateGaugeVersionName] = strComparisonOp;
}
}
return objvSenateGaugeItemsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSenateGaugeItemsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvSenateGaugeItemsEN SetsenateGaugeItemDesc(this clsvSenateGaugeItemsEN objvSenateGaugeItemsEN, string strsenateGaugeItemDesc, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strsenateGaugeItemDesc, 2000, convSenateGaugeItems.senateGaugeItemDesc);
}
objvSenateGaugeItemsEN.senateGaugeItemDesc = strsenateGaugeItemDesc; //量表指标说明
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvSenateGaugeItemsEN.dicFldComparisonOp.ContainsKey(convSenateGaugeItems.senateGaugeItemDesc) == false)
{
objvSenateGaugeItemsEN.dicFldComparisonOp.Add(convSenateGaugeItems.senateGaugeItemDesc, strComparisonOp);
}
else
{
objvSenateGaugeItemsEN.dicFldComparisonOp[convSenateGaugeItems.senateGaugeItemDesc] = strComparisonOp;
}
}
return objvSenateGaugeItemsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSenateGaugeItemsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvSenateGaugeItemsEN SetsenateGaugeItemWeight(this clsvSenateGaugeItemsEN objvSenateGaugeItemsEN, float? fltsenateGaugeItemWeight, string strComparisonOp="")
	{
objvSenateGaugeItemsEN.senateGaugeItemWeight = fltsenateGaugeItemWeight; //量表指标权重
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvSenateGaugeItemsEN.dicFldComparisonOp.ContainsKey(convSenateGaugeItems.senateGaugeItemWeight) == false)
{
objvSenateGaugeItemsEN.dicFldComparisonOp.Add(convSenateGaugeItems.senateGaugeItemWeight, strComparisonOp);
}
else
{
objvSenateGaugeItemsEN.dicFldComparisonOp[convSenateGaugeItems.senateGaugeItemWeight] = strComparisonOp;
}
}
return objvSenateGaugeItemsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSenateGaugeItemsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvSenateGaugeItemsEN SetAnswerModeId(this clsvSenateGaugeItemsEN objvSenateGaugeItemsEN, string strAnswerModeId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strAnswerModeId, 4, convSenateGaugeItems.AnswerModeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strAnswerModeId, 4, convSenateGaugeItems.AnswerModeId);
}
objvSenateGaugeItemsEN.AnswerModeId = strAnswerModeId; //答案模式Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvSenateGaugeItemsEN.dicFldComparisonOp.ContainsKey(convSenateGaugeItems.AnswerModeId) == false)
{
objvSenateGaugeItemsEN.dicFldComparisonOp.Add(convSenateGaugeItems.AnswerModeId, strComparisonOp);
}
else
{
objvSenateGaugeItemsEN.dicFldComparisonOp[convSenateGaugeItems.AnswerModeId] = strComparisonOp;
}
}
return objvSenateGaugeItemsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSenateGaugeItemsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvSenateGaugeItemsEN SetAnswerTypeId(this clsvSenateGaugeItemsEN objvSenateGaugeItemsEN, string strAnswerTypeId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strAnswerTypeId, 2, convSenateGaugeItems.AnswerTypeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strAnswerTypeId, 2, convSenateGaugeItems.AnswerTypeId);
}
objvSenateGaugeItemsEN.AnswerTypeId = strAnswerTypeId; //答案类型ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvSenateGaugeItemsEN.dicFldComparisonOp.ContainsKey(convSenateGaugeItems.AnswerTypeId) == false)
{
objvSenateGaugeItemsEN.dicFldComparisonOp.Add(convSenateGaugeItems.AnswerTypeId, strComparisonOp);
}
else
{
objvSenateGaugeItemsEN.dicFldComparisonOp[convSenateGaugeItems.AnswerTypeId] = strComparisonOp;
}
}
return objvSenateGaugeItemsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSenateGaugeItemsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvSenateGaugeItemsEN SetGridTitle(this clsvSenateGaugeItemsEN objvSenateGaugeItemsEN, string strGridTitle, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strGridTitle, 30, convSenateGaugeItems.GridTitle);
}
objvSenateGaugeItemsEN.GridTitle = strGridTitle; //表格标题
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvSenateGaugeItemsEN.dicFldComparisonOp.ContainsKey(convSenateGaugeItems.GridTitle) == false)
{
objvSenateGaugeItemsEN.dicFldComparisonOp.Add(convSenateGaugeItems.GridTitle, strComparisonOp);
}
else
{
objvSenateGaugeItemsEN.dicFldComparisonOp[convSenateGaugeItems.GridTitle] = strComparisonOp;
}
}
return objvSenateGaugeItemsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSenateGaugeItemsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvSenateGaugeItemsEN SetQuestionIndex(this clsvSenateGaugeItemsEN objvSenateGaugeItemsEN, int? intQuestionIndex, string strComparisonOp="")
	{
objvSenateGaugeItemsEN.QuestionIndex = intQuestionIndex; //题目序号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvSenateGaugeItemsEN.dicFldComparisonOp.ContainsKey(convSenateGaugeItems.QuestionIndex) == false)
{
objvSenateGaugeItemsEN.dicFldComparisonOp.Add(convSenateGaugeItems.QuestionIndex, strComparisonOp);
}
else
{
objvSenateGaugeItemsEN.dicFldComparisonOp[convSenateGaugeItems.QuestionIndex] = strComparisonOp;
}
}
return objvSenateGaugeItemsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSenateGaugeItemsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvSenateGaugeItemsEN SetsenateGaugeVersionID(this clsvSenateGaugeItemsEN objvSenateGaugeItemsEN, string strsenateGaugeVersionID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strsenateGaugeVersionID, convSenateGaugeItems.senateGaugeVersionID);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strsenateGaugeVersionID, 4, convSenateGaugeItems.senateGaugeVersionID);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strsenateGaugeVersionID, 4, convSenateGaugeItems.senateGaugeVersionID);
}
objvSenateGaugeItemsEN.senateGaugeVersionID = strsenateGaugeVersionID; //评价量表版本ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvSenateGaugeItemsEN.dicFldComparisonOp.ContainsKey(convSenateGaugeItems.senateGaugeVersionID) == false)
{
objvSenateGaugeItemsEN.dicFldComparisonOp.Add(convSenateGaugeItems.senateGaugeVersionID, strComparisonOp);
}
else
{
objvSenateGaugeItemsEN.dicFldComparisonOp[convSenateGaugeItems.senateGaugeVersionID] = strComparisonOp;
}
}
return objvSenateGaugeItemsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSenateGaugeItemsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvSenateGaugeItemsEN SetQuestionNo(this clsvSenateGaugeItemsEN objvSenateGaugeItemsEN, string strQuestionNo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strQuestionNo, 10, convSenateGaugeItems.QuestionNo);
}
objvSenateGaugeItemsEN.QuestionNo = strQuestionNo; //题目编号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvSenateGaugeItemsEN.dicFldComparisonOp.ContainsKey(convSenateGaugeItems.QuestionNo) == false)
{
objvSenateGaugeItemsEN.dicFldComparisonOp.Add(convSenateGaugeItems.QuestionNo, strComparisonOp);
}
else
{
objvSenateGaugeItemsEN.dicFldComparisonOp[convSenateGaugeItems.QuestionNo] = strComparisonOp;
}
}
return objvSenateGaugeItemsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSenateGaugeItemsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvSenateGaugeItemsEN SetQuestionTypeId(this clsvSenateGaugeItemsEN objvSenateGaugeItemsEN, string strQuestionTypeId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strQuestionTypeId, 2, convSenateGaugeItems.QuestionTypeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strQuestionTypeId, 2, convSenateGaugeItems.QuestionTypeId);
}
objvSenateGaugeItemsEN.QuestionTypeId = strQuestionTypeId; //题目类型Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvSenateGaugeItemsEN.dicFldComparisonOp.ContainsKey(convSenateGaugeItems.QuestionTypeId) == false)
{
objvSenateGaugeItemsEN.dicFldComparisonOp.Add(convSenateGaugeItems.QuestionTypeId, strComparisonOp);
}
else
{
objvSenateGaugeItemsEN.dicFldComparisonOp[convSenateGaugeItems.QuestionTypeId] = strComparisonOp;
}
}
return objvSenateGaugeItemsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSenateGaugeItemsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvSenateGaugeItemsEN SetsenateGaugeVersionTtlScore(this clsvSenateGaugeItemsEN objvSenateGaugeItemsEN, float fltsenateGaugeVersionTtlScore, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(fltsenateGaugeVersionTtlScore, convSenateGaugeItems.senateGaugeVersionTtlScore);
objvSenateGaugeItemsEN.senateGaugeVersionTtlScore = fltsenateGaugeVersionTtlScore; //评价量表版本总分
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvSenateGaugeItemsEN.dicFldComparisonOp.ContainsKey(convSenateGaugeItems.senateGaugeVersionTtlScore) == false)
{
objvSenateGaugeItemsEN.dicFldComparisonOp.Add(convSenateGaugeItems.senateGaugeVersionTtlScore, strComparisonOp);
}
else
{
objvSenateGaugeItemsEN.dicFldComparisonOp[convSenateGaugeItems.senateGaugeVersionTtlScore] = strComparisonOp;
}
}
return objvSenateGaugeItemsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSenateGaugeItemsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvSenateGaugeItemsEN SetAnswerTypeName(this clsvSenateGaugeItemsEN objvSenateGaugeItemsEN, string strAnswerTypeName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strAnswerTypeName, 50, convSenateGaugeItems.AnswerTypeName);
}
objvSenateGaugeItemsEN.AnswerTypeName = strAnswerTypeName; //答案类型名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvSenateGaugeItemsEN.dicFldComparisonOp.ContainsKey(convSenateGaugeItems.AnswerTypeName) == false)
{
objvSenateGaugeItemsEN.dicFldComparisonOp.Add(convSenateGaugeItems.AnswerTypeName, strComparisonOp);
}
else
{
objvSenateGaugeItemsEN.dicFldComparisonOp[convSenateGaugeItems.AnswerTypeName] = strComparisonOp;
}
}
return objvSenateGaugeItemsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSenateGaugeItemsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvSenateGaugeItemsEN SetAnswerModeName(this clsvSenateGaugeItemsEN objvSenateGaugeItemsEN, string strAnswerModeName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strAnswerModeName, 30, convSenateGaugeItems.AnswerModeName);
}
objvSenateGaugeItemsEN.AnswerModeName = strAnswerModeName; //答案模式名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvSenateGaugeItemsEN.dicFldComparisonOp.ContainsKey(convSenateGaugeItems.AnswerModeName) == false)
{
objvSenateGaugeItemsEN.dicFldComparisonOp.Add(convSenateGaugeItems.AnswerModeName, strComparisonOp);
}
else
{
objvSenateGaugeItemsEN.dicFldComparisonOp[convSenateGaugeItems.AnswerModeName] = strComparisonOp;
}
}
return objvSenateGaugeItemsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSenateGaugeItemsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvSenateGaugeItemsEN SetsenateGaugeItemMemo(this clsvSenateGaugeItemsEN objvSenateGaugeItemsEN, string strsenateGaugeItemMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strsenateGaugeItemMemo, 1000, convSenateGaugeItems.senateGaugeItemMemo);
}
objvSenateGaugeItemsEN.senateGaugeItemMemo = strsenateGaugeItemMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvSenateGaugeItemsEN.dicFldComparisonOp.ContainsKey(convSenateGaugeItems.senateGaugeItemMemo) == false)
{
objvSenateGaugeItemsEN.dicFldComparisonOp.Add(convSenateGaugeItems.senateGaugeItemMemo, strComparisonOp);
}
else
{
objvSenateGaugeItemsEN.dicFldComparisonOp[convSenateGaugeItems.senateGaugeItemMemo] = strComparisonOp;
}
}
return objvSenateGaugeItemsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSenateGaugeItemsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvSenateGaugeItemsEN SetQuestionTypeName(this clsvSenateGaugeItemsEN objvSenateGaugeItemsEN, string strQuestionTypeName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strQuestionTypeName, 20, convSenateGaugeItems.QuestionTypeName);
}
objvSenateGaugeItemsEN.QuestionTypeName = strQuestionTypeName; //题目类型名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvSenateGaugeItemsEN.dicFldComparisonOp.ContainsKey(convSenateGaugeItems.QuestionTypeName) == false)
{
objvSenateGaugeItemsEN.dicFldComparisonOp.Add(convSenateGaugeItems.QuestionTypeName, strComparisonOp);
}
else
{
objvSenateGaugeItemsEN.dicFldComparisonOp[convSenateGaugeItems.QuestionTypeName] = strComparisonOp;
}
}
return objvSenateGaugeItemsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSenateGaugeItemsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvSenateGaugeItemsEN SetAnswerNum(this clsvSenateGaugeItemsEN objvSenateGaugeItemsEN, int? intAnswerNum, string strComparisonOp="")
	{
objvSenateGaugeItemsEN.AnswerNum = intAnswerNum; //答案数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvSenateGaugeItemsEN.dicFldComparisonOp.ContainsKey(convSenateGaugeItems.AnswerNum) == false)
{
objvSenateGaugeItemsEN.dicFldComparisonOp.Add(convSenateGaugeItems.AnswerNum, strComparisonOp);
}
else
{
objvSenateGaugeItemsEN.dicFldComparisonOp[convSenateGaugeItems.AnswerNum] = strComparisonOp;
}
}
return objvSenateGaugeItemsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSenateGaugeItemsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvSenateGaugeItemsEN SetVersionNo(this clsvSenateGaugeItemsEN objvSenateGaugeItemsEN, int? intVersionNo, string strComparisonOp="")
	{
objvSenateGaugeItemsEN.VersionNo = intVersionNo; //版本号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvSenateGaugeItemsEN.dicFldComparisonOp.ContainsKey(convSenateGaugeItems.VersionNo) == false)
{
objvSenateGaugeItemsEN.dicFldComparisonOp.Add(convSenateGaugeItems.VersionNo, strComparisonOp);
}
else
{
objvSenateGaugeItemsEN.dicFldComparisonOp[convSenateGaugeItems.VersionNo] = strComparisonOp;
}
}
return objvSenateGaugeItemsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSenateGaugeItemsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvSenateGaugeItemsEN SetIsUse(this clsvSenateGaugeItemsEN objvSenateGaugeItemsEN, bool bolIsUse, string strComparisonOp="")
	{
objvSenateGaugeItemsEN.IsUse = bolIsUse; //是否使用
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvSenateGaugeItemsEN.dicFldComparisonOp.ContainsKey(convSenateGaugeItems.IsUse) == false)
{
objvSenateGaugeItemsEN.dicFldComparisonOp.Add(convSenateGaugeItems.IsUse, strComparisonOp);
}
else
{
objvSenateGaugeItemsEN.dicFldComparisonOp[convSenateGaugeItems.IsUse] = strComparisonOp;
}
}
return objvSenateGaugeItemsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSenateGaugeItemsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvSenateGaugeItemsEN SetsenateGaugeVersionMemo(this clsvSenateGaugeItemsEN objvSenateGaugeItemsEN, string strsenateGaugeVersionMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strsenateGaugeVersionMemo, 1000, convSenateGaugeItems.senateGaugeVersionMemo);
}
objvSenateGaugeItemsEN.senateGaugeVersionMemo = strsenateGaugeVersionMemo; //评价量表版本说明
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvSenateGaugeItemsEN.dicFldComparisonOp.ContainsKey(convSenateGaugeItems.senateGaugeVersionMemo) == false)
{
objvSenateGaugeItemsEN.dicFldComparisonOp.Add(convSenateGaugeItems.senateGaugeVersionMemo, strComparisonOp);
}
else
{
objvSenateGaugeItemsEN.dicFldComparisonOp[convSenateGaugeItems.senateGaugeVersionMemo] = strComparisonOp;
}
}
return objvSenateGaugeItemsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSenateGaugeItemsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvSenateGaugeItemsEN SetsenateGaugeItemNameWithOrder(this clsvSenateGaugeItemsEN objvSenateGaugeItemsEN, string strsenateGaugeItemNameWithOrder, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strsenateGaugeItemNameWithOrder, 204, convSenateGaugeItems.senateGaugeItemNameWithOrder);
}
objvSenateGaugeItemsEN.senateGaugeItemNameWithOrder = strsenateGaugeItemNameWithOrder; //量表指标名称WithOrder
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvSenateGaugeItemsEN.dicFldComparisonOp.ContainsKey(convSenateGaugeItems.senateGaugeItemNameWithOrder) == false)
{
objvSenateGaugeItemsEN.dicFldComparisonOp.Add(convSenateGaugeItems.senateGaugeItemNameWithOrder, strComparisonOp);
}
else
{
objvSenateGaugeItemsEN.dicFldComparisonOp[convSenateGaugeItems.senateGaugeItemNameWithOrder] = strComparisonOp;
}
}
return objvSenateGaugeItemsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSenateGaugeItemsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvSenateGaugeItemsEN SetUpdDate(this clsvSenateGaugeItemsEN objvSenateGaugeItemsEN, string strUpdDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdDate, 20, convSenateGaugeItems.UpdDate);
}
objvSenateGaugeItemsEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvSenateGaugeItemsEN.dicFldComparisonOp.ContainsKey(convSenateGaugeItems.UpdDate) == false)
{
objvSenateGaugeItemsEN.dicFldComparisonOp.Add(convSenateGaugeItems.UpdDate, strComparisonOp);
}
else
{
objvSenateGaugeItemsEN.dicFldComparisonOp[convSenateGaugeItems.UpdDate] = strComparisonOp;
}
}
return objvSenateGaugeItemsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSenateGaugeItemsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvSenateGaugeItemsEN SetUpdUserId(this clsvSenateGaugeItemsEN objvSenateGaugeItemsEN, string strUpdUserId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdUserId, 20, convSenateGaugeItems.UpdUserId);
}
objvSenateGaugeItemsEN.UpdUserId = strUpdUserId; //修改用户Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvSenateGaugeItemsEN.dicFldComparisonOp.ContainsKey(convSenateGaugeItems.UpdUserId) == false)
{
objvSenateGaugeItemsEN.dicFldComparisonOp.Add(convSenateGaugeItems.UpdUserId, strComparisonOp);
}
else
{
objvSenateGaugeItemsEN.dicFldComparisonOp[convSenateGaugeItems.UpdUserId] = strComparisonOp;
}
}
return objvSenateGaugeItemsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSenateGaugeItemsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvSenateGaugeItemsEN SetIsHaveAdditionalMemo(this clsvSenateGaugeItemsEN objvSenateGaugeItemsEN, bool bolIsHaveAdditionalMemo, string strComparisonOp="")
	{
objvSenateGaugeItemsEN.IsHaveAdditionalMemo = bolIsHaveAdditionalMemo; //是否有附加说明
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvSenateGaugeItemsEN.dicFldComparisonOp.ContainsKey(convSenateGaugeItems.IsHaveAdditionalMemo) == false)
{
objvSenateGaugeItemsEN.dicFldComparisonOp.Add(convSenateGaugeItems.IsHaveAdditionalMemo, strComparisonOp);
}
else
{
objvSenateGaugeItemsEN.dicFldComparisonOp[convSenateGaugeItems.IsHaveAdditionalMemo] = strComparisonOp;
}
}
return objvSenateGaugeItemsEN;
	}

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CopyObj)
 /// </summary>
 /// <param name = "objvSenateGaugeItemsENS">源对象</param>
 /// <param name = "objvSenateGaugeItemsENT">目标对象</param>
 public static void CopyTo(this clsvSenateGaugeItemsEN objvSenateGaugeItemsENS, clsvSenateGaugeItemsEN objvSenateGaugeItemsENT)
{
try
{
objvSenateGaugeItemsENT.IdSenateGaugeItem = objvSenateGaugeItemsENS.IdSenateGaugeItem; //量表指标流水号
objvSenateGaugeItemsENT.senateGaugeItemID = objvSenateGaugeItemsENS.senateGaugeItemID; //量表指标ID
objvSenateGaugeItemsENT.senateGaugeItemName = objvSenateGaugeItemsENS.senateGaugeItemName; //量表指标名称
objvSenateGaugeItemsENT.IdSenateGaugeVersion = objvSenateGaugeItemsENS.IdSenateGaugeVersion; //评价量表版本流水号
objvSenateGaugeItemsENT.senateGaugeVersionName = objvSenateGaugeItemsENS.senateGaugeVersionName; //评价量表版本名称
objvSenateGaugeItemsENT.senateGaugeItemDesc = objvSenateGaugeItemsENS.senateGaugeItemDesc; //量表指标说明
objvSenateGaugeItemsENT.senateGaugeItemWeight = objvSenateGaugeItemsENS.senateGaugeItemWeight; //量表指标权重
objvSenateGaugeItemsENT.AnswerModeId = objvSenateGaugeItemsENS.AnswerModeId; //答案模式Id
objvSenateGaugeItemsENT.AnswerTypeId = objvSenateGaugeItemsENS.AnswerTypeId; //答案类型ID
objvSenateGaugeItemsENT.GridTitle = objvSenateGaugeItemsENS.GridTitle; //表格标题
objvSenateGaugeItemsENT.QuestionIndex = objvSenateGaugeItemsENS.QuestionIndex; //题目序号
objvSenateGaugeItemsENT.senateGaugeVersionID = objvSenateGaugeItemsENS.senateGaugeVersionID; //评价量表版本ID
objvSenateGaugeItemsENT.QuestionNo = objvSenateGaugeItemsENS.QuestionNo; //题目编号
objvSenateGaugeItemsENT.QuestionTypeId = objvSenateGaugeItemsENS.QuestionTypeId; //题目类型Id
objvSenateGaugeItemsENT.senateGaugeVersionTtlScore = objvSenateGaugeItemsENS.senateGaugeVersionTtlScore; //评价量表版本总分
objvSenateGaugeItemsENT.AnswerTypeName = objvSenateGaugeItemsENS.AnswerTypeName; //答案类型名
objvSenateGaugeItemsENT.AnswerModeName = objvSenateGaugeItemsENS.AnswerModeName; //答案模式名称
objvSenateGaugeItemsENT.senateGaugeItemMemo = objvSenateGaugeItemsENS.senateGaugeItemMemo; //备注
objvSenateGaugeItemsENT.QuestionTypeName = objvSenateGaugeItemsENS.QuestionTypeName; //题目类型名
objvSenateGaugeItemsENT.AnswerNum = objvSenateGaugeItemsENS.AnswerNum; //答案数
objvSenateGaugeItemsENT.VersionNo = objvSenateGaugeItemsENS.VersionNo; //版本号
objvSenateGaugeItemsENT.IsUse = objvSenateGaugeItemsENS.IsUse; //是否使用
objvSenateGaugeItemsENT.senateGaugeVersionMemo = objvSenateGaugeItemsENS.senateGaugeVersionMemo; //评价量表版本说明
objvSenateGaugeItemsENT.senateGaugeItemNameWithOrder = objvSenateGaugeItemsENS.senateGaugeItemNameWithOrder; //量表指标名称WithOrder
objvSenateGaugeItemsENT.UpdDate = objvSenateGaugeItemsENS.UpdDate; //修改日期
objvSenateGaugeItemsENT.UpdUserId = objvSenateGaugeItemsENS.UpdUserId; //修改用户Id
objvSenateGaugeItemsENT.IsHaveAdditionalMemo = objvSenateGaugeItemsENS.IsHaveAdditionalMemo; //是否有附加说明
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
 /// <param name = "objvSenateGaugeItemsENS">源对象</param>
 /// <returns>目标对象=>clsvSenateGaugeItemsEN:objvSenateGaugeItemsENT</returns>
 public static clsvSenateGaugeItemsEN CopyTo(this clsvSenateGaugeItemsEN objvSenateGaugeItemsENS)
{
try
{
 clsvSenateGaugeItemsEN objvSenateGaugeItemsENT = new clsvSenateGaugeItemsEN()
{
IdSenateGaugeItem = objvSenateGaugeItemsENS.IdSenateGaugeItem, //量表指标流水号
senateGaugeItemID = objvSenateGaugeItemsENS.senateGaugeItemID, //量表指标ID
senateGaugeItemName = objvSenateGaugeItemsENS.senateGaugeItemName, //量表指标名称
IdSenateGaugeVersion = objvSenateGaugeItemsENS.IdSenateGaugeVersion, //评价量表版本流水号
senateGaugeVersionName = objvSenateGaugeItemsENS.senateGaugeVersionName, //评价量表版本名称
senateGaugeItemDesc = objvSenateGaugeItemsENS.senateGaugeItemDesc, //量表指标说明
senateGaugeItemWeight = objvSenateGaugeItemsENS.senateGaugeItemWeight, //量表指标权重
AnswerModeId = objvSenateGaugeItemsENS.AnswerModeId, //答案模式Id
AnswerTypeId = objvSenateGaugeItemsENS.AnswerTypeId, //答案类型ID
GridTitle = objvSenateGaugeItemsENS.GridTitle, //表格标题
QuestionIndex = objvSenateGaugeItemsENS.QuestionIndex, //题目序号
senateGaugeVersionID = objvSenateGaugeItemsENS.senateGaugeVersionID, //评价量表版本ID
QuestionNo = objvSenateGaugeItemsENS.QuestionNo, //题目编号
QuestionTypeId = objvSenateGaugeItemsENS.QuestionTypeId, //题目类型Id
senateGaugeVersionTtlScore = objvSenateGaugeItemsENS.senateGaugeVersionTtlScore, //评价量表版本总分
AnswerTypeName = objvSenateGaugeItemsENS.AnswerTypeName, //答案类型名
AnswerModeName = objvSenateGaugeItemsENS.AnswerModeName, //答案模式名称
senateGaugeItemMemo = objvSenateGaugeItemsENS.senateGaugeItemMemo, //备注
QuestionTypeName = objvSenateGaugeItemsENS.QuestionTypeName, //题目类型名
AnswerNum = objvSenateGaugeItemsENS.AnswerNum, //答案数
VersionNo = objvSenateGaugeItemsENS.VersionNo, //版本号
IsUse = objvSenateGaugeItemsENS.IsUse, //是否使用
senateGaugeVersionMemo = objvSenateGaugeItemsENS.senateGaugeVersionMemo, //评价量表版本说明
senateGaugeItemNameWithOrder = objvSenateGaugeItemsENS.senateGaugeItemNameWithOrder, //量表指标名称WithOrder
UpdDate = objvSenateGaugeItemsENS.UpdDate, //修改日期
UpdUserId = objvSenateGaugeItemsENS.UpdUserId, //修改用户Id
IsHaveAdditionalMemo = objvSenateGaugeItemsENS.IsHaveAdditionalMemo, //是否有附加说明
};
 return objvSenateGaugeItemsENT;
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
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(this clsvSenateGaugeItemsEN objvSenateGaugeItemsEN)
{
 clsvSenateGaugeItemsBL.vSenateGaugeItemsDA.CheckProperty4Condition(objvSenateGaugeItemsEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvSenateGaugeItemsEN objvSenateGaugeItemsCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvSenateGaugeItemsCond.IsUpdated(convSenateGaugeItems.IdSenateGaugeItem) == true)
{
string strComparisonOpIdSenateGaugeItem = objvSenateGaugeItemsCond.dicFldComparisonOp[convSenateGaugeItems.IdSenateGaugeItem];
strWhereCond += string.Format(" And {0} {2} '{1}'", convSenateGaugeItems.IdSenateGaugeItem, objvSenateGaugeItemsCond.IdSenateGaugeItem, strComparisonOpIdSenateGaugeItem);
}
if (objvSenateGaugeItemsCond.IsUpdated(convSenateGaugeItems.senateGaugeItemID) == true)
{
string strComparisonOpsenateGaugeItemID = objvSenateGaugeItemsCond.dicFldComparisonOp[convSenateGaugeItems.senateGaugeItemID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convSenateGaugeItems.senateGaugeItemID, objvSenateGaugeItemsCond.senateGaugeItemID, strComparisonOpsenateGaugeItemID);
}
if (objvSenateGaugeItemsCond.IsUpdated(convSenateGaugeItems.senateGaugeItemName) == true)
{
string strComparisonOpsenateGaugeItemName = objvSenateGaugeItemsCond.dicFldComparisonOp[convSenateGaugeItems.senateGaugeItemName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convSenateGaugeItems.senateGaugeItemName, objvSenateGaugeItemsCond.senateGaugeItemName, strComparisonOpsenateGaugeItemName);
}
if (objvSenateGaugeItemsCond.IsUpdated(convSenateGaugeItems.IdSenateGaugeVersion) == true)
{
string strComparisonOpIdSenateGaugeVersion = objvSenateGaugeItemsCond.dicFldComparisonOp[convSenateGaugeItems.IdSenateGaugeVersion];
strWhereCond += string.Format(" And {0} {2} '{1}'", convSenateGaugeItems.IdSenateGaugeVersion, objvSenateGaugeItemsCond.IdSenateGaugeVersion, strComparisonOpIdSenateGaugeVersion);
}
if (objvSenateGaugeItemsCond.IsUpdated(convSenateGaugeItems.senateGaugeVersionName) == true)
{
string strComparisonOpsenateGaugeVersionName = objvSenateGaugeItemsCond.dicFldComparisonOp[convSenateGaugeItems.senateGaugeVersionName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convSenateGaugeItems.senateGaugeVersionName, objvSenateGaugeItemsCond.senateGaugeVersionName, strComparisonOpsenateGaugeVersionName);
}
if (objvSenateGaugeItemsCond.IsUpdated(convSenateGaugeItems.senateGaugeItemDesc) == true)
{
string strComparisonOpsenateGaugeItemDesc = objvSenateGaugeItemsCond.dicFldComparisonOp[convSenateGaugeItems.senateGaugeItemDesc];
strWhereCond += string.Format(" And {0} {2} '{1}'", convSenateGaugeItems.senateGaugeItemDesc, objvSenateGaugeItemsCond.senateGaugeItemDesc, strComparisonOpsenateGaugeItemDesc);
}
if (objvSenateGaugeItemsCond.IsUpdated(convSenateGaugeItems.senateGaugeItemWeight) == true)
{
string strComparisonOpsenateGaugeItemWeight = objvSenateGaugeItemsCond.dicFldComparisonOp[convSenateGaugeItems.senateGaugeItemWeight];
strWhereCond += string.Format(" And {0} {2} {1}", convSenateGaugeItems.senateGaugeItemWeight, objvSenateGaugeItemsCond.senateGaugeItemWeight, strComparisonOpsenateGaugeItemWeight);
}
if (objvSenateGaugeItemsCond.IsUpdated(convSenateGaugeItems.AnswerModeId) == true)
{
string strComparisonOpAnswerModeId = objvSenateGaugeItemsCond.dicFldComparisonOp[convSenateGaugeItems.AnswerModeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convSenateGaugeItems.AnswerModeId, objvSenateGaugeItemsCond.AnswerModeId, strComparisonOpAnswerModeId);
}
if (objvSenateGaugeItemsCond.IsUpdated(convSenateGaugeItems.AnswerTypeId) == true)
{
string strComparisonOpAnswerTypeId = objvSenateGaugeItemsCond.dicFldComparisonOp[convSenateGaugeItems.AnswerTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convSenateGaugeItems.AnswerTypeId, objvSenateGaugeItemsCond.AnswerTypeId, strComparisonOpAnswerTypeId);
}
if (objvSenateGaugeItemsCond.IsUpdated(convSenateGaugeItems.GridTitle) == true)
{
string strComparisonOpGridTitle = objvSenateGaugeItemsCond.dicFldComparisonOp[convSenateGaugeItems.GridTitle];
strWhereCond += string.Format(" And {0} {2} '{1}'", convSenateGaugeItems.GridTitle, objvSenateGaugeItemsCond.GridTitle, strComparisonOpGridTitle);
}
if (objvSenateGaugeItemsCond.IsUpdated(convSenateGaugeItems.QuestionIndex) == true)
{
string strComparisonOpQuestionIndex = objvSenateGaugeItemsCond.dicFldComparisonOp[convSenateGaugeItems.QuestionIndex];
strWhereCond += string.Format(" And {0} {2} {1}", convSenateGaugeItems.QuestionIndex, objvSenateGaugeItemsCond.QuestionIndex, strComparisonOpQuestionIndex);
}
if (objvSenateGaugeItemsCond.IsUpdated(convSenateGaugeItems.senateGaugeVersionID) == true)
{
string strComparisonOpsenateGaugeVersionID = objvSenateGaugeItemsCond.dicFldComparisonOp[convSenateGaugeItems.senateGaugeVersionID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convSenateGaugeItems.senateGaugeVersionID, objvSenateGaugeItemsCond.senateGaugeVersionID, strComparisonOpsenateGaugeVersionID);
}
if (objvSenateGaugeItemsCond.IsUpdated(convSenateGaugeItems.QuestionNo) == true)
{
string strComparisonOpQuestionNo = objvSenateGaugeItemsCond.dicFldComparisonOp[convSenateGaugeItems.QuestionNo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convSenateGaugeItems.QuestionNo, objvSenateGaugeItemsCond.QuestionNo, strComparisonOpQuestionNo);
}
if (objvSenateGaugeItemsCond.IsUpdated(convSenateGaugeItems.QuestionTypeId) == true)
{
string strComparisonOpQuestionTypeId = objvSenateGaugeItemsCond.dicFldComparisonOp[convSenateGaugeItems.QuestionTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convSenateGaugeItems.QuestionTypeId, objvSenateGaugeItemsCond.QuestionTypeId, strComparisonOpQuestionTypeId);
}
if (objvSenateGaugeItemsCond.IsUpdated(convSenateGaugeItems.senateGaugeVersionTtlScore) == true)
{
string strComparisonOpsenateGaugeVersionTtlScore = objvSenateGaugeItemsCond.dicFldComparisonOp[convSenateGaugeItems.senateGaugeVersionTtlScore];
strWhereCond += string.Format(" And {0} {2} {1}", convSenateGaugeItems.senateGaugeVersionTtlScore, objvSenateGaugeItemsCond.senateGaugeVersionTtlScore, strComparisonOpsenateGaugeVersionTtlScore);
}
if (objvSenateGaugeItemsCond.IsUpdated(convSenateGaugeItems.AnswerTypeName) == true)
{
string strComparisonOpAnswerTypeName = objvSenateGaugeItemsCond.dicFldComparisonOp[convSenateGaugeItems.AnswerTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convSenateGaugeItems.AnswerTypeName, objvSenateGaugeItemsCond.AnswerTypeName, strComparisonOpAnswerTypeName);
}
if (objvSenateGaugeItemsCond.IsUpdated(convSenateGaugeItems.AnswerModeName) == true)
{
string strComparisonOpAnswerModeName = objvSenateGaugeItemsCond.dicFldComparisonOp[convSenateGaugeItems.AnswerModeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convSenateGaugeItems.AnswerModeName, objvSenateGaugeItemsCond.AnswerModeName, strComparisonOpAnswerModeName);
}
if (objvSenateGaugeItemsCond.IsUpdated(convSenateGaugeItems.senateGaugeItemMemo) == true)
{
string strComparisonOpsenateGaugeItemMemo = objvSenateGaugeItemsCond.dicFldComparisonOp[convSenateGaugeItems.senateGaugeItemMemo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convSenateGaugeItems.senateGaugeItemMemo, objvSenateGaugeItemsCond.senateGaugeItemMemo, strComparisonOpsenateGaugeItemMemo);
}
if (objvSenateGaugeItemsCond.IsUpdated(convSenateGaugeItems.QuestionTypeName) == true)
{
string strComparisonOpQuestionTypeName = objvSenateGaugeItemsCond.dicFldComparisonOp[convSenateGaugeItems.QuestionTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convSenateGaugeItems.QuestionTypeName, objvSenateGaugeItemsCond.QuestionTypeName, strComparisonOpQuestionTypeName);
}
if (objvSenateGaugeItemsCond.IsUpdated(convSenateGaugeItems.AnswerNum) == true)
{
string strComparisonOpAnswerNum = objvSenateGaugeItemsCond.dicFldComparisonOp[convSenateGaugeItems.AnswerNum];
strWhereCond += string.Format(" And {0} {2} {1}", convSenateGaugeItems.AnswerNum, objvSenateGaugeItemsCond.AnswerNum, strComparisonOpAnswerNum);
}
if (objvSenateGaugeItemsCond.IsUpdated(convSenateGaugeItems.VersionNo) == true)
{
string strComparisonOpVersionNo = objvSenateGaugeItemsCond.dicFldComparisonOp[convSenateGaugeItems.VersionNo];
strWhereCond += string.Format(" And {0} {2} {1}", convSenateGaugeItems.VersionNo, objvSenateGaugeItemsCond.VersionNo, strComparisonOpVersionNo);
}
if (objvSenateGaugeItemsCond.IsUpdated(convSenateGaugeItems.IsUse) == true)
{
if (objvSenateGaugeItemsCond.IsUse == true)
{
strWhereCond += string.Format(" And {0} = '1'", convSenateGaugeItems.IsUse);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convSenateGaugeItems.IsUse);
}
}
if (objvSenateGaugeItemsCond.IsUpdated(convSenateGaugeItems.senateGaugeVersionMemo) == true)
{
string strComparisonOpsenateGaugeVersionMemo = objvSenateGaugeItemsCond.dicFldComparisonOp[convSenateGaugeItems.senateGaugeVersionMemo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convSenateGaugeItems.senateGaugeVersionMemo, objvSenateGaugeItemsCond.senateGaugeVersionMemo, strComparisonOpsenateGaugeVersionMemo);
}
if (objvSenateGaugeItemsCond.IsUpdated(convSenateGaugeItems.senateGaugeItemNameWithOrder) == true)
{
string strComparisonOpsenateGaugeItemNameWithOrder = objvSenateGaugeItemsCond.dicFldComparisonOp[convSenateGaugeItems.senateGaugeItemNameWithOrder];
strWhereCond += string.Format(" And {0} {2} '{1}'", convSenateGaugeItems.senateGaugeItemNameWithOrder, objvSenateGaugeItemsCond.senateGaugeItemNameWithOrder, strComparisonOpsenateGaugeItemNameWithOrder);
}
if (objvSenateGaugeItemsCond.IsUpdated(convSenateGaugeItems.UpdDate) == true)
{
string strComparisonOpUpdDate = objvSenateGaugeItemsCond.dicFldComparisonOp[convSenateGaugeItems.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convSenateGaugeItems.UpdDate, objvSenateGaugeItemsCond.UpdDate, strComparisonOpUpdDate);
}
if (objvSenateGaugeItemsCond.IsUpdated(convSenateGaugeItems.UpdUserId) == true)
{
string strComparisonOpUpdUserId = objvSenateGaugeItemsCond.dicFldComparisonOp[convSenateGaugeItems.UpdUserId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convSenateGaugeItems.UpdUserId, objvSenateGaugeItemsCond.UpdUserId, strComparisonOpUpdUserId);
}
if (objvSenateGaugeItemsCond.IsUpdated(convSenateGaugeItems.IsHaveAdditionalMemo) == true)
{
if (objvSenateGaugeItemsCond.IsHaveAdditionalMemo == true)
{
strWhereCond += string.Format(" And {0} = '1'", convSenateGaugeItems.IsHaveAdditionalMemo);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convSenateGaugeItems.IsHaveAdditionalMemo);
}
}
 return strWhereCond;
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_vSenateGaugeItems
{
public virtual bool UpdRelaTabDate(string strIdSenateGaugeItem, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// v量表指标(vSenateGaugeItems)
 /// 数据源类型:视图
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsvSenateGaugeItemsBL
{
public static RelatedActions_vSenateGaugeItems relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsvSenateGaugeItemsDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsvSenateGaugeItemsDA vSenateGaugeItemsDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsvSenateGaugeItemsDA();
}
return uniqueInstance;
}
}

 /// <summary>
 /// 类的构造函数
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ClassConstructor1)
 /// </summary>
 public clsvSenateGaugeItemsBL()
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
if (string.IsNullOrEmpty(clsvSenateGaugeItemsEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvSenateGaugeItemsEN._ConnectString);
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
public static DataTable GetDataTable_vSenateGaugeItems(string strWhereCond)
{
DataTable objDT;
try
{
objDT = vSenateGaugeItemsDA.GetDataTable_vSenateGaugeItems(strWhereCond);
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
objDT = vSenateGaugeItemsDA.GetDataTable(strWhereCond);
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
objDT = vSenateGaugeItemsDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = vSenateGaugeItemsDA.GetDataTable(strWhereCond, strTabName);
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
objDT = vSenateGaugeItemsDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = vSenateGaugeItemsDA.GetDataTable_Top(objTopPara);
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
objDT = vSenateGaugeItemsDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = vSenateGaugeItemsDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = vSenateGaugeItemsDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
 /// <param name = "arrIdSenateGaugeItemLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static List<clsvSenateGaugeItemsEN> GetObjLstByIdSenateGaugeItemLst(List<string> arrIdSenateGaugeItemLst)
{
List<clsvSenateGaugeItemsEN> arrObjLst = new List<clsvSenateGaugeItemsEN>(); 
System.Data.DataTable objDT; 
 string strSqlConditionStr = clsArray.GetSqlInStrByArray(arrIdSenateGaugeItemLst, true);
 string strWhereCond = string.Format("IdSenateGaugeItem in ({0})", strSqlConditionStr);
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvSenateGaugeItemsEN objvSenateGaugeItemsEN = new clsvSenateGaugeItemsEN();
try
{
objvSenateGaugeItemsEN.IdSenateGaugeItem = objRow[convSenateGaugeItems.IdSenateGaugeItem].ToString().Trim(); //量表指标流水号
objvSenateGaugeItemsEN.senateGaugeItemID = objRow[convSenateGaugeItems.senateGaugeItemID] == DBNull.Value ? null : objRow[convSenateGaugeItems.senateGaugeItemID].ToString().Trim(); //量表指标ID
objvSenateGaugeItemsEN.senateGaugeItemName = objRow[convSenateGaugeItems.senateGaugeItemName] == DBNull.Value ? null : objRow[convSenateGaugeItems.senateGaugeItemName].ToString().Trim(); //量表指标名称
objvSenateGaugeItemsEN.IdSenateGaugeVersion = objRow[convSenateGaugeItems.IdSenateGaugeVersion].ToString().Trim(); //评价量表版本流水号
objvSenateGaugeItemsEN.senateGaugeVersionName = objRow[convSenateGaugeItems.senateGaugeVersionName] == DBNull.Value ? null : objRow[convSenateGaugeItems.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称
objvSenateGaugeItemsEN.senateGaugeItemDesc = objRow[convSenateGaugeItems.senateGaugeItemDesc] == DBNull.Value ? null : objRow[convSenateGaugeItems.senateGaugeItemDesc].ToString().Trim(); //量表指标说明
objvSenateGaugeItemsEN.senateGaugeItemWeight = objRow[convSenateGaugeItems.senateGaugeItemWeight] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convSenateGaugeItems.senateGaugeItemWeight].ToString().Trim()); //量表指标权重
objvSenateGaugeItemsEN.AnswerModeId = objRow[convSenateGaugeItems.AnswerModeId] == DBNull.Value ? null : objRow[convSenateGaugeItems.AnswerModeId].ToString().Trim(); //答案模式Id
objvSenateGaugeItemsEN.AnswerTypeId = objRow[convSenateGaugeItems.AnswerTypeId] == DBNull.Value ? null : objRow[convSenateGaugeItems.AnswerTypeId].ToString().Trim(); //答案类型ID
objvSenateGaugeItemsEN.GridTitle = objRow[convSenateGaugeItems.GridTitle] == DBNull.Value ? null : objRow[convSenateGaugeItems.GridTitle].ToString().Trim(); //表格标题
objvSenateGaugeItemsEN.QuestionIndex = objRow[convSenateGaugeItems.QuestionIndex] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convSenateGaugeItems.QuestionIndex].ToString().Trim()); //题目序号
objvSenateGaugeItemsEN.senateGaugeVersionID = objRow[convSenateGaugeItems.senateGaugeVersionID].ToString().Trim(); //评价量表版本ID
objvSenateGaugeItemsEN.QuestionNo = objRow[convSenateGaugeItems.QuestionNo] == DBNull.Value ? null : objRow[convSenateGaugeItems.QuestionNo].ToString().Trim(); //题目编号
objvSenateGaugeItemsEN.QuestionTypeId = objRow[convSenateGaugeItems.QuestionTypeId] == DBNull.Value ? null : objRow[convSenateGaugeItems.QuestionTypeId].ToString().Trim(); //题目类型Id
objvSenateGaugeItemsEN.senateGaugeVersionTtlScore = Single.Parse(objRow[convSenateGaugeItems.senateGaugeVersionTtlScore].ToString().Trim()); //评价量表版本总分
objvSenateGaugeItemsEN.AnswerTypeName = objRow[convSenateGaugeItems.AnswerTypeName] == DBNull.Value ? null : objRow[convSenateGaugeItems.AnswerTypeName].ToString().Trim(); //答案类型名
objvSenateGaugeItemsEN.AnswerModeName = objRow[convSenateGaugeItems.AnswerModeName] == DBNull.Value ? null : objRow[convSenateGaugeItems.AnswerModeName].ToString().Trim(); //答案模式名称
objvSenateGaugeItemsEN.senateGaugeItemMemo = objRow[convSenateGaugeItems.senateGaugeItemMemo] == DBNull.Value ? null : objRow[convSenateGaugeItems.senateGaugeItemMemo].ToString().Trim(); //备注
objvSenateGaugeItemsEN.QuestionTypeName = objRow[convSenateGaugeItems.QuestionTypeName] == DBNull.Value ? null : objRow[convSenateGaugeItems.QuestionTypeName].ToString().Trim(); //题目类型名
objvSenateGaugeItemsEN.AnswerNum = objRow[convSenateGaugeItems.AnswerNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convSenateGaugeItems.AnswerNum].ToString().Trim()); //答案数
objvSenateGaugeItemsEN.VersionNo = objRow[convSenateGaugeItems.VersionNo] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convSenateGaugeItems.VersionNo].ToString().Trim()); //版本号
objvSenateGaugeItemsEN.IsUse = clsEntityBase2.TransNullToBool_S(objRow[convSenateGaugeItems.IsUse].ToString().Trim()); //是否使用
objvSenateGaugeItemsEN.senateGaugeVersionMemo = objRow[convSenateGaugeItems.senateGaugeVersionMemo] == DBNull.Value ? null : objRow[convSenateGaugeItems.senateGaugeVersionMemo].ToString().Trim(); //评价量表版本说明
objvSenateGaugeItemsEN.senateGaugeItemNameWithOrder = objRow[convSenateGaugeItems.senateGaugeItemNameWithOrder] == DBNull.Value ? null : objRow[convSenateGaugeItems.senateGaugeItemNameWithOrder].ToString().Trim(); //量表指标名称WithOrder
objvSenateGaugeItemsEN.UpdDate = objRow[convSenateGaugeItems.UpdDate] == DBNull.Value ? null : objRow[convSenateGaugeItems.UpdDate].ToString().Trim(); //修改日期
objvSenateGaugeItemsEN.UpdUserId = objRow[convSenateGaugeItems.UpdUserId] == DBNull.Value ? null : objRow[convSenateGaugeItems.UpdUserId].ToString().Trim(); //修改用户Id
objvSenateGaugeItemsEN.IsHaveAdditionalMemo = clsEntityBase2.TransNullToBool_S(objRow[convSenateGaugeItems.IsHaveAdditionalMemo].ToString().Trim()); //是否有附加说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvSenateGaugeItemsEN.IdSenateGaugeItem, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvSenateGaugeItemsEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrIdSenateGaugeItemLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsvSenateGaugeItemsEN> GetObjLstByIdSenateGaugeItemLstCache(List<string> arrIdSenateGaugeItemLst)
{
string strKey = string.Format("{0}", clsvSenateGaugeItemsEN._CurrTabName);
List<clsvSenateGaugeItemsEN> arrvSenateGaugeItemsObjLstCache = GetObjLstCache();
IEnumerable <clsvSenateGaugeItemsEN> arrvSenateGaugeItemsObjLst_Sel =
arrvSenateGaugeItemsObjLstCache
.Where(x => arrIdSenateGaugeItemLst.Contains(x.IdSenateGaugeItem));
return arrvSenateGaugeItemsObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvSenateGaugeItemsEN> GetObjLst(string strWhereCond)
{
List<clsvSenateGaugeItemsEN> arrObjLst = new List<clsvSenateGaugeItemsEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvSenateGaugeItemsEN objvSenateGaugeItemsEN = new clsvSenateGaugeItemsEN();
try
{
objvSenateGaugeItemsEN.IdSenateGaugeItem = objRow[convSenateGaugeItems.IdSenateGaugeItem].ToString().Trim(); //量表指标流水号
objvSenateGaugeItemsEN.senateGaugeItemID = objRow[convSenateGaugeItems.senateGaugeItemID] == DBNull.Value ? null : objRow[convSenateGaugeItems.senateGaugeItemID].ToString().Trim(); //量表指标ID
objvSenateGaugeItemsEN.senateGaugeItemName = objRow[convSenateGaugeItems.senateGaugeItemName] == DBNull.Value ? null : objRow[convSenateGaugeItems.senateGaugeItemName].ToString().Trim(); //量表指标名称
objvSenateGaugeItemsEN.IdSenateGaugeVersion = objRow[convSenateGaugeItems.IdSenateGaugeVersion].ToString().Trim(); //评价量表版本流水号
objvSenateGaugeItemsEN.senateGaugeVersionName = objRow[convSenateGaugeItems.senateGaugeVersionName] == DBNull.Value ? null : objRow[convSenateGaugeItems.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称
objvSenateGaugeItemsEN.senateGaugeItemDesc = objRow[convSenateGaugeItems.senateGaugeItemDesc] == DBNull.Value ? null : objRow[convSenateGaugeItems.senateGaugeItemDesc].ToString().Trim(); //量表指标说明
objvSenateGaugeItemsEN.senateGaugeItemWeight = objRow[convSenateGaugeItems.senateGaugeItemWeight] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convSenateGaugeItems.senateGaugeItemWeight].ToString().Trim()); //量表指标权重
objvSenateGaugeItemsEN.AnswerModeId = objRow[convSenateGaugeItems.AnswerModeId] == DBNull.Value ? null : objRow[convSenateGaugeItems.AnswerModeId].ToString().Trim(); //答案模式Id
objvSenateGaugeItemsEN.AnswerTypeId = objRow[convSenateGaugeItems.AnswerTypeId] == DBNull.Value ? null : objRow[convSenateGaugeItems.AnswerTypeId].ToString().Trim(); //答案类型ID
objvSenateGaugeItemsEN.GridTitle = objRow[convSenateGaugeItems.GridTitle] == DBNull.Value ? null : objRow[convSenateGaugeItems.GridTitle].ToString().Trim(); //表格标题
objvSenateGaugeItemsEN.QuestionIndex = objRow[convSenateGaugeItems.QuestionIndex] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convSenateGaugeItems.QuestionIndex].ToString().Trim()); //题目序号
objvSenateGaugeItemsEN.senateGaugeVersionID = objRow[convSenateGaugeItems.senateGaugeVersionID].ToString().Trim(); //评价量表版本ID
objvSenateGaugeItemsEN.QuestionNo = objRow[convSenateGaugeItems.QuestionNo] == DBNull.Value ? null : objRow[convSenateGaugeItems.QuestionNo].ToString().Trim(); //题目编号
objvSenateGaugeItemsEN.QuestionTypeId = objRow[convSenateGaugeItems.QuestionTypeId] == DBNull.Value ? null : objRow[convSenateGaugeItems.QuestionTypeId].ToString().Trim(); //题目类型Id
objvSenateGaugeItemsEN.senateGaugeVersionTtlScore = Single.Parse(objRow[convSenateGaugeItems.senateGaugeVersionTtlScore].ToString().Trim()); //评价量表版本总分
objvSenateGaugeItemsEN.AnswerTypeName = objRow[convSenateGaugeItems.AnswerTypeName] == DBNull.Value ? null : objRow[convSenateGaugeItems.AnswerTypeName].ToString().Trim(); //答案类型名
objvSenateGaugeItemsEN.AnswerModeName = objRow[convSenateGaugeItems.AnswerModeName] == DBNull.Value ? null : objRow[convSenateGaugeItems.AnswerModeName].ToString().Trim(); //答案模式名称
objvSenateGaugeItemsEN.senateGaugeItemMemo = objRow[convSenateGaugeItems.senateGaugeItemMemo] == DBNull.Value ? null : objRow[convSenateGaugeItems.senateGaugeItemMemo].ToString().Trim(); //备注
objvSenateGaugeItemsEN.QuestionTypeName = objRow[convSenateGaugeItems.QuestionTypeName] == DBNull.Value ? null : objRow[convSenateGaugeItems.QuestionTypeName].ToString().Trim(); //题目类型名
objvSenateGaugeItemsEN.AnswerNum = objRow[convSenateGaugeItems.AnswerNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convSenateGaugeItems.AnswerNum].ToString().Trim()); //答案数
objvSenateGaugeItemsEN.VersionNo = objRow[convSenateGaugeItems.VersionNo] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convSenateGaugeItems.VersionNo].ToString().Trim()); //版本号
objvSenateGaugeItemsEN.IsUse = clsEntityBase2.TransNullToBool_S(objRow[convSenateGaugeItems.IsUse].ToString().Trim()); //是否使用
objvSenateGaugeItemsEN.senateGaugeVersionMemo = objRow[convSenateGaugeItems.senateGaugeVersionMemo] == DBNull.Value ? null : objRow[convSenateGaugeItems.senateGaugeVersionMemo].ToString().Trim(); //评价量表版本说明
objvSenateGaugeItemsEN.senateGaugeItemNameWithOrder = objRow[convSenateGaugeItems.senateGaugeItemNameWithOrder] == DBNull.Value ? null : objRow[convSenateGaugeItems.senateGaugeItemNameWithOrder].ToString().Trim(); //量表指标名称WithOrder
objvSenateGaugeItemsEN.UpdDate = objRow[convSenateGaugeItems.UpdDate] == DBNull.Value ? null : objRow[convSenateGaugeItems.UpdDate].ToString().Trim(); //修改日期
objvSenateGaugeItemsEN.UpdUserId = objRow[convSenateGaugeItems.UpdUserId] == DBNull.Value ? null : objRow[convSenateGaugeItems.UpdUserId].ToString().Trim(); //修改用户Id
objvSenateGaugeItemsEN.IsHaveAdditionalMemo = clsEntityBase2.TransNullToBool_S(objRow[convSenateGaugeItems.IsHaveAdditionalMemo].ToString().Trim()); //是否有附加说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvSenateGaugeItemsEN.IdSenateGaugeItem, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvSenateGaugeItemsEN);
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
public static List<clsvSenateGaugeItemsEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsvSenateGaugeItemsEN> arrObjLst = new List<clsvSenateGaugeItemsEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvSenateGaugeItemsEN objvSenateGaugeItemsEN = new clsvSenateGaugeItemsEN();
try
{
objvSenateGaugeItemsEN.IdSenateGaugeItem = objRow[convSenateGaugeItems.IdSenateGaugeItem].ToString().Trim(); //量表指标流水号
objvSenateGaugeItemsEN.senateGaugeItemID = objRow[convSenateGaugeItems.senateGaugeItemID] == DBNull.Value ? null : objRow[convSenateGaugeItems.senateGaugeItemID].ToString().Trim(); //量表指标ID
objvSenateGaugeItemsEN.senateGaugeItemName = objRow[convSenateGaugeItems.senateGaugeItemName] == DBNull.Value ? null : objRow[convSenateGaugeItems.senateGaugeItemName].ToString().Trim(); //量表指标名称
objvSenateGaugeItemsEN.IdSenateGaugeVersion = objRow[convSenateGaugeItems.IdSenateGaugeVersion].ToString().Trim(); //评价量表版本流水号
objvSenateGaugeItemsEN.senateGaugeVersionName = objRow[convSenateGaugeItems.senateGaugeVersionName] == DBNull.Value ? null : objRow[convSenateGaugeItems.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称
objvSenateGaugeItemsEN.senateGaugeItemDesc = objRow[convSenateGaugeItems.senateGaugeItemDesc] == DBNull.Value ? null : objRow[convSenateGaugeItems.senateGaugeItemDesc].ToString().Trim(); //量表指标说明
objvSenateGaugeItemsEN.senateGaugeItemWeight = objRow[convSenateGaugeItems.senateGaugeItemWeight] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convSenateGaugeItems.senateGaugeItemWeight].ToString().Trim()); //量表指标权重
objvSenateGaugeItemsEN.AnswerModeId = objRow[convSenateGaugeItems.AnswerModeId] == DBNull.Value ? null : objRow[convSenateGaugeItems.AnswerModeId].ToString().Trim(); //答案模式Id
objvSenateGaugeItemsEN.AnswerTypeId = objRow[convSenateGaugeItems.AnswerTypeId] == DBNull.Value ? null : objRow[convSenateGaugeItems.AnswerTypeId].ToString().Trim(); //答案类型ID
objvSenateGaugeItemsEN.GridTitle = objRow[convSenateGaugeItems.GridTitle] == DBNull.Value ? null : objRow[convSenateGaugeItems.GridTitle].ToString().Trim(); //表格标题
objvSenateGaugeItemsEN.QuestionIndex = objRow[convSenateGaugeItems.QuestionIndex] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convSenateGaugeItems.QuestionIndex].ToString().Trim()); //题目序号
objvSenateGaugeItemsEN.senateGaugeVersionID = objRow[convSenateGaugeItems.senateGaugeVersionID].ToString().Trim(); //评价量表版本ID
objvSenateGaugeItemsEN.QuestionNo = objRow[convSenateGaugeItems.QuestionNo] == DBNull.Value ? null : objRow[convSenateGaugeItems.QuestionNo].ToString().Trim(); //题目编号
objvSenateGaugeItemsEN.QuestionTypeId = objRow[convSenateGaugeItems.QuestionTypeId] == DBNull.Value ? null : objRow[convSenateGaugeItems.QuestionTypeId].ToString().Trim(); //题目类型Id
objvSenateGaugeItemsEN.senateGaugeVersionTtlScore = Single.Parse(objRow[convSenateGaugeItems.senateGaugeVersionTtlScore].ToString().Trim()); //评价量表版本总分
objvSenateGaugeItemsEN.AnswerTypeName = objRow[convSenateGaugeItems.AnswerTypeName] == DBNull.Value ? null : objRow[convSenateGaugeItems.AnswerTypeName].ToString().Trim(); //答案类型名
objvSenateGaugeItemsEN.AnswerModeName = objRow[convSenateGaugeItems.AnswerModeName] == DBNull.Value ? null : objRow[convSenateGaugeItems.AnswerModeName].ToString().Trim(); //答案模式名称
objvSenateGaugeItemsEN.senateGaugeItemMemo = objRow[convSenateGaugeItems.senateGaugeItemMemo] == DBNull.Value ? null : objRow[convSenateGaugeItems.senateGaugeItemMemo].ToString().Trim(); //备注
objvSenateGaugeItemsEN.QuestionTypeName = objRow[convSenateGaugeItems.QuestionTypeName] == DBNull.Value ? null : objRow[convSenateGaugeItems.QuestionTypeName].ToString().Trim(); //题目类型名
objvSenateGaugeItemsEN.AnswerNum = objRow[convSenateGaugeItems.AnswerNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convSenateGaugeItems.AnswerNum].ToString().Trim()); //答案数
objvSenateGaugeItemsEN.VersionNo = objRow[convSenateGaugeItems.VersionNo] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convSenateGaugeItems.VersionNo].ToString().Trim()); //版本号
objvSenateGaugeItemsEN.IsUse = clsEntityBase2.TransNullToBool_S(objRow[convSenateGaugeItems.IsUse].ToString().Trim()); //是否使用
objvSenateGaugeItemsEN.senateGaugeVersionMemo = objRow[convSenateGaugeItems.senateGaugeVersionMemo] == DBNull.Value ? null : objRow[convSenateGaugeItems.senateGaugeVersionMemo].ToString().Trim(); //评价量表版本说明
objvSenateGaugeItemsEN.senateGaugeItemNameWithOrder = objRow[convSenateGaugeItems.senateGaugeItemNameWithOrder] == DBNull.Value ? null : objRow[convSenateGaugeItems.senateGaugeItemNameWithOrder].ToString().Trim(); //量表指标名称WithOrder
objvSenateGaugeItemsEN.UpdDate = objRow[convSenateGaugeItems.UpdDate] == DBNull.Value ? null : objRow[convSenateGaugeItems.UpdDate].ToString().Trim(); //修改日期
objvSenateGaugeItemsEN.UpdUserId = objRow[convSenateGaugeItems.UpdUserId] == DBNull.Value ? null : objRow[convSenateGaugeItems.UpdUserId].ToString().Trim(); //修改用户Id
objvSenateGaugeItemsEN.IsHaveAdditionalMemo = clsEntityBase2.TransNullToBool_S(objRow[convSenateGaugeItems.IsHaveAdditionalMemo].ToString().Trim()); //是否有附加说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvSenateGaugeItemsEN.IdSenateGaugeItem, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvSenateGaugeItemsEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objvSenateGaugeItemsCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsvSenateGaugeItemsEN> GetSubObjLstCache(clsvSenateGaugeItemsEN objvSenateGaugeItemsCond)
{
List<clsvSenateGaugeItemsEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsvSenateGaugeItemsEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convSenateGaugeItems.AttributeName)
{
if (objvSenateGaugeItemsCond.IsUpdated(strFldName) == false) continue;
if (objvSenateGaugeItemsCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvSenateGaugeItemsCond[strFldName].ToString());
}
else
{
if (objvSenateGaugeItemsCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvSenateGaugeItemsCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvSenateGaugeItemsCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvSenateGaugeItemsCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvSenateGaugeItemsCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvSenateGaugeItemsCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvSenateGaugeItemsCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvSenateGaugeItemsCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvSenateGaugeItemsCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvSenateGaugeItemsCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvSenateGaugeItemsCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvSenateGaugeItemsCond[strFldName]));
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
public static List<clsvSenateGaugeItemsEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsvSenateGaugeItemsEN> arrObjLst = new List<clsvSenateGaugeItemsEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvSenateGaugeItemsEN objvSenateGaugeItemsEN = new clsvSenateGaugeItemsEN();
try
{
objvSenateGaugeItemsEN.IdSenateGaugeItem = objRow[convSenateGaugeItems.IdSenateGaugeItem].ToString().Trim(); //量表指标流水号
objvSenateGaugeItemsEN.senateGaugeItemID = objRow[convSenateGaugeItems.senateGaugeItemID] == DBNull.Value ? null : objRow[convSenateGaugeItems.senateGaugeItemID].ToString().Trim(); //量表指标ID
objvSenateGaugeItemsEN.senateGaugeItemName = objRow[convSenateGaugeItems.senateGaugeItemName] == DBNull.Value ? null : objRow[convSenateGaugeItems.senateGaugeItemName].ToString().Trim(); //量表指标名称
objvSenateGaugeItemsEN.IdSenateGaugeVersion = objRow[convSenateGaugeItems.IdSenateGaugeVersion].ToString().Trim(); //评价量表版本流水号
objvSenateGaugeItemsEN.senateGaugeVersionName = objRow[convSenateGaugeItems.senateGaugeVersionName] == DBNull.Value ? null : objRow[convSenateGaugeItems.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称
objvSenateGaugeItemsEN.senateGaugeItemDesc = objRow[convSenateGaugeItems.senateGaugeItemDesc] == DBNull.Value ? null : objRow[convSenateGaugeItems.senateGaugeItemDesc].ToString().Trim(); //量表指标说明
objvSenateGaugeItemsEN.senateGaugeItemWeight = objRow[convSenateGaugeItems.senateGaugeItemWeight] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convSenateGaugeItems.senateGaugeItemWeight].ToString().Trim()); //量表指标权重
objvSenateGaugeItemsEN.AnswerModeId = objRow[convSenateGaugeItems.AnswerModeId] == DBNull.Value ? null : objRow[convSenateGaugeItems.AnswerModeId].ToString().Trim(); //答案模式Id
objvSenateGaugeItemsEN.AnswerTypeId = objRow[convSenateGaugeItems.AnswerTypeId] == DBNull.Value ? null : objRow[convSenateGaugeItems.AnswerTypeId].ToString().Trim(); //答案类型ID
objvSenateGaugeItemsEN.GridTitle = objRow[convSenateGaugeItems.GridTitle] == DBNull.Value ? null : objRow[convSenateGaugeItems.GridTitle].ToString().Trim(); //表格标题
objvSenateGaugeItemsEN.QuestionIndex = objRow[convSenateGaugeItems.QuestionIndex] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convSenateGaugeItems.QuestionIndex].ToString().Trim()); //题目序号
objvSenateGaugeItemsEN.senateGaugeVersionID = objRow[convSenateGaugeItems.senateGaugeVersionID].ToString().Trim(); //评价量表版本ID
objvSenateGaugeItemsEN.QuestionNo = objRow[convSenateGaugeItems.QuestionNo] == DBNull.Value ? null : objRow[convSenateGaugeItems.QuestionNo].ToString().Trim(); //题目编号
objvSenateGaugeItemsEN.QuestionTypeId = objRow[convSenateGaugeItems.QuestionTypeId] == DBNull.Value ? null : objRow[convSenateGaugeItems.QuestionTypeId].ToString().Trim(); //题目类型Id
objvSenateGaugeItemsEN.senateGaugeVersionTtlScore = Single.Parse(objRow[convSenateGaugeItems.senateGaugeVersionTtlScore].ToString().Trim()); //评价量表版本总分
objvSenateGaugeItemsEN.AnswerTypeName = objRow[convSenateGaugeItems.AnswerTypeName] == DBNull.Value ? null : objRow[convSenateGaugeItems.AnswerTypeName].ToString().Trim(); //答案类型名
objvSenateGaugeItemsEN.AnswerModeName = objRow[convSenateGaugeItems.AnswerModeName] == DBNull.Value ? null : objRow[convSenateGaugeItems.AnswerModeName].ToString().Trim(); //答案模式名称
objvSenateGaugeItemsEN.senateGaugeItemMemo = objRow[convSenateGaugeItems.senateGaugeItemMemo] == DBNull.Value ? null : objRow[convSenateGaugeItems.senateGaugeItemMemo].ToString().Trim(); //备注
objvSenateGaugeItemsEN.QuestionTypeName = objRow[convSenateGaugeItems.QuestionTypeName] == DBNull.Value ? null : objRow[convSenateGaugeItems.QuestionTypeName].ToString().Trim(); //题目类型名
objvSenateGaugeItemsEN.AnswerNum = objRow[convSenateGaugeItems.AnswerNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convSenateGaugeItems.AnswerNum].ToString().Trim()); //答案数
objvSenateGaugeItemsEN.VersionNo = objRow[convSenateGaugeItems.VersionNo] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convSenateGaugeItems.VersionNo].ToString().Trim()); //版本号
objvSenateGaugeItemsEN.IsUse = clsEntityBase2.TransNullToBool_S(objRow[convSenateGaugeItems.IsUse].ToString().Trim()); //是否使用
objvSenateGaugeItemsEN.senateGaugeVersionMemo = objRow[convSenateGaugeItems.senateGaugeVersionMemo] == DBNull.Value ? null : objRow[convSenateGaugeItems.senateGaugeVersionMemo].ToString().Trim(); //评价量表版本说明
objvSenateGaugeItemsEN.senateGaugeItemNameWithOrder = objRow[convSenateGaugeItems.senateGaugeItemNameWithOrder] == DBNull.Value ? null : objRow[convSenateGaugeItems.senateGaugeItemNameWithOrder].ToString().Trim(); //量表指标名称WithOrder
objvSenateGaugeItemsEN.UpdDate = objRow[convSenateGaugeItems.UpdDate] == DBNull.Value ? null : objRow[convSenateGaugeItems.UpdDate].ToString().Trim(); //修改日期
objvSenateGaugeItemsEN.UpdUserId = objRow[convSenateGaugeItems.UpdUserId] == DBNull.Value ? null : objRow[convSenateGaugeItems.UpdUserId].ToString().Trim(); //修改用户Id
objvSenateGaugeItemsEN.IsHaveAdditionalMemo = clsEntityBase2.TransNullToBool_S(objRow[convSenateGaugeItems.IsHaveAdditionalMemo].ToString().Trim()); //是否有附加说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvSenateGaugeItemsEN.IdSenateGaugeItem, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvSenateGaugeItemsEN);
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
public static List<clsvSenateGaugeItemsEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsvSenateGaugeItemsEN> arrObjLst = new List<clsvSenateGaugeItemsEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvSenateGaugeItemsEN objvSenateGaugeItemsEN = new clsvSenateGaugeItemsEN();
try
{
objvSenateGaugeItemsEN.IdSenateGaugeItem = objRow[convSenateGaugeItems.IdSenateGaugeItem].ToString().Trim(); //量表指标流水号
objvSenateGaugeItemsEN.senateGaugeItemID = objRow[convSenateGaugeItems.senateGaugeItemID] == DBNull.Value ? null : objRow[convSenateGaugeItems.senateGaugeItemID].ToString().Trim(); //量表指标ID
objvSenateGaugeItemsEN.senateGaugeItemName = objRow[convSenateGaugeItems.senateGaugeItemName] == DBNull.Value ? null : objRow[convSenateGaugeItems.senateGaugeItemName].ToString().Trim(); //量表指标名称
objvSenateGaugeItemsEN.IdSenateGaugeVersion = objRow[convSenateGaugeItems.IdSenateGaugeVersion].ToString().Trim(); //评价量表版本流水号
objvSenateGaugeItemsEN.senateGaugeVersionName = objRow[convSenateGaugeItems.senateGaugeVersionName] == DBNull.Value ? null : objRow[convSenateGaugeItems.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称
objvSenateGaugeItemsEN.senateGaugeItemDesc = objRow[convSenateGaugeItems.senateGaugeItemDesc] == DBNull.Value ? null : objRow[convSenateGaugeItems.senateGaugeItemDesc].ToString().Trim(); //量表指标说明
objvSenateGaugeItemsEN.senateGaugeItemWeight = objRow[convSenateGaugeItems.senateGaugeItemWeight] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convSenateGaugeItems.senateGaugeItemWeight].ToString().Trim()); //量表指标权重
objvSenateGaugeItemsEN.AnswerModeId = objRow[convSenateGaugeItems.AnswerModeId] == DBNull.Value ? null : objRow[convSenateGaugeItems.AnswerModeId].ToString().Trim(); //答案模式Id
objvSenateGaugeItemsEN.AnswerTypeId = objRow[convSenateGaugeItems.AnswerTypeId] == DBNull.Value ? null : objRow[convSenateGaugeItems.AnswerTypeId].ToString().Trim(); //答案类型ID
objvSenateGaugeItemsEN.GridTitle = objRow[convSenateGaugeItems.GridTitle] == DBNull.Value ? null : objRow[convSenateGaugeItems.GridTitle].ToString().Trim(); //表格标题
objvSenateGaugeItemsEN.QuestionIndex = objRow[convSenateGaugeItems.QuestionIndex] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convSenateGaugeItems.QuestionIndex].ToString().Trim()); //题目序号
objvSenateGaugeItemsEN.senateGaugeVersionID = objRow[convSenateGaugeItems.senateGaugeVersionID].ToString().Trim(); //评价量表版本ID
objvSenateGaugeItemsEN.QuestionNo = objRow[convSenateGaugeItems.QuestionNo] == DBNull.Value ? null : objRow[convSenateGaugeItems.QuestionNo].ToString().Trim(); //题目编号
objvSenateGaugeItemsEN.QuestionTypeId = objRow[convSenateGaugeItems.QuestionTypeId] == DBNull.Value ? null : objRow[convSenateGaugeItems.QuestionTypeId].ToString().Trim(); //题目类型Id
objvSenateGaugeItemsEN.senateGaugeVersionTtlScore = Single.Parse(objRow[convSenateGaugeItems.senateGaugeVersionTtlScore].ToString().Trim()); //评价量表版本总分
objvSenateGaugeItemsEN.AnswerTypeName = objRow[convSenateGaugeItems.AnswerTypeName] == DBNull.Value ? null : objRow[convSenateGaugeItems.AnswerTypeName].ToString().Trim(); //答案类型名
objvSenateGaugeItemsEN.AnswerModeName = objRow[convSenateGaugeItems.AnswerModeName] == DBNull.Value ? null : objRow[convSenateGaugeItems.AnswerModeName].ToString().Trim(); //答案模式名称
objvSenateGaugeItemsEN.senateGaugeItemMemo = objRow[convSenateGaugeItems.senateGaugeItemMemo] == DBNull.Value ? null : objRow[convSenateGaugeItems.senateGaugeItemMemo].ToString().Trim(); //备注
objvSenateGaugeItemsEN.QuestionTypeName = objRow[convSenateGaugeItems.QuestionTypeName] == DBNull.Value ? null : objRow[convSenateGaugeItems.QuestionTypeName].ToString().Trim(); //题目类型名
objvSenateGaugeItemsEN.AnswerNum = objRow[convSenateGaugeItems.AnswerNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convSenateGaugeItems.AnswerNum].ToString().Trim()); //答案数
objvSenateGaugeItemsEN.VersionNo = objRow[convSenateGaugeItems.VersionNo] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convSenateGaugeItems.VersionNo].ToString().Trim()); //版本号
objvSenateGaugeItemsEN.IsUse = clsEntityBase2.TransNullToBool_S(objRow[convSenateGaugeItems.IsUse].ToString().Trim()); //是否使用
objvSenateGaugeItemsEN.senateGaugeVersionMemo = objRow[convSenateGaugeItems.senateGaugeVersionMemo] == DBNull.Value ? null : objRow[convSenateGaugeItems.senateGaugeVersionMemo].ToString().Trim(); //评价量表版本说明
objvSenateGaugeItemsEN.senateGaugeItemNameWithOrder = objRow[convSenateGaugeItems.senateGaugeItemNameWithOrder] == DBNull.Value ? null : objRow[convSenateGaugeItems.senateGaugeItemNameWithOrder].ToString().Trim(); //量表指标名称WithOrder
objvSenateGaugeItemsEN.UpdDate = objRow[convSenateGaugeItems.UpdDate] == DBNull.Value ? null : objRow[convSenateGaugeItems.UpdDate].ToString().Trim(); //修改日期
objvSenateGaugeItemsEN.UpdUserId = objRow[convSenateGaugeItems.UpdUserId] == DBNull.Value ? null : objRow[convSenateGaugeItems.UpdUserId].ToString().Trim(); //修改用户Id
objvSenateGaugeItemsEN.IsHaveAdditionalMemo = clsEntityBase2.TransNullToBool_S(objRow[convSenateGaugeItems.IsHaveAdditionalMemo].ToString().Trim()); //是否有附加说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvSenateGaugeItemsEN.IdSenateGaugeItem, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvSenateGaugeItemsEN);
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
List<clsvSenateGaugeItemsEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsvSenateGaugeItemsEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsvSenateGaugeItemsEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsvSenateGaugeItemsEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsvSenateGaugeItemsEN> arrObjLst = new List<clsvSenateGaugeItemsEN>(); 
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
	clsvSenateGaugeItemsEN objvSenateGaugeItemsEN = new clsvSenateGaugeItemsEN();
try
{
objvSenateGaugeItemsEN.IdSenateGaugeItem = objRow[convSenateGaugeItems.IdSenateGaugeItem].ToString().Trim(); //量表指标流水号
objvSenateGaugeItemsEN.senateGaugeItemID = objRow[convSenateGaugeItems.senateGaugeItemID] == DBNull.Value ? null : objRow[convSenateGaugeItems.senateGaugeItemID].ToString().Trim(); //量表指标ID
objvSenateGaugeItemsEN.senateGaugeItemName = objRow[convSenateGaugeItems.senateGaugeItemName] == DBNull.Value ? null : objRow[convSenateGaugeItems.senateGaugeItemName].ToString().Trim(); //量表指标名称
objvSenateGaugeItemsEN.IdSenateGaugeVersion = objRow[convSenateGaugeItems.IdSenateGaugeVersion].ToString().Trim(); //评价量表版本流水号
objvSenateGaugeItemsEN.senateGaugeVersionName = objRow[convSenateGaugeItems.senateGaugeVersionName] == DBNull.Value ? null : objRow[convSenateGaugeItems.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称
objvSenateGaugeItemsEN.senateGaugeItemDesc = objRow[convSenateGaugeItems.senateGaugeItemDesc] == DBNull.Value ? null : objRow[convSenateGaugeItems.senateGaugeItemDesc].ToString().Trim(); //量表指标说明
objvSenateGaugeItemsEN.senateGaugeItemWeight = objRow[convSenateGaugeItems.senateGaugeItemWeight] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convSenateGaugeItems.senateGaugeItemWeight].ToString().Trim()); //量表指标权重
objvSenateGaugeItemsEN.AnswerModeId = objRow[convSenateGaugeItems.AnswerModeId] == DBNull.Value ? null : objRow[convSenateGaugeItems.AnswerModeId].ToString().Trim(); //答案模式Id
objvSenateGaugeItemsEN.AnswerTypeId = objRow[convSenateGaugeItems.AnswerTypeId] == DBNull.Value ? null : objRow[convSenateGaugeItems.AnswerTypeId].ToString().Trim(); //答案类型ID
objvSenateGaugeItemsEN.GridTitle = objRow[convSenateGaugeItems.GridTitle] == DBNull.Value ? null : objRow[convSenateGaugeItems.GridTitle].ToString().Trim(); //表格标题
objvSenateGaugeItemsEN.QuestionIndex = objRow[convSenateGaugeItems.QuestionIndex] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convSenateGaugeItems.QuestionIndex].ToString().Trim()); //题目序号
objvSenateGaugeItemsEN.senateGaugeVersionID = objRow[convSenateGaugeItems.senateGaugeVersionID].ToString().Trim(); //评价量表版本ID
objvSenateGaugeItemsEN.QuestionNo = objRow[convSenateGaugeItems.QuestionNo] == DBNull.Value ? null : objRow[convSenateGaugeItems.QuestionNo].ToString().Trim(); //题目编号
objvSenateGaugeItemsEN.QuestionTypeId = objRow[convSenateGaugeItems.QuestionTypeId] == DBNull.Value ? null : objRow[convSenateGaugeItems.QuestionTypeId].ToString().Trim(); //题目类型Id
objvSenateGaugeItemsEN.senateGaugeVersionTtlScore = Single.Parse(objRow[convSenateGaugeItems.senateGaugeVersionTtlScore].ToString().Trim()); //评价量表版本总分
objvSenateGaugeItemsEN.AnswerTypeName = objRow[convSenateGaugeItems.AnswerTypeName] == DBNull.Value ? null : objRow[convSenateGaugeItems.AnswerTypeName].ToString().Trim(); //答案类型名
objvSenateGaugeItemsEN.AnswerModeName = objRow[convSenateGaugeItems.AnswerModeName] == DBNull.Value ? null : objRow[convSenateGaugeItems.AnswerModeName].ToString().Trim(); //答案模式名称
objvSenateGaugeItemsEN.senateGaugeItemMemo = objRow[convSenateGaugeItems.senateGaugeItemMemo] == DBNull.Value ? null : objRow[convSenateGaugeItems.senateGaugeItemMemo].ToString().Trim(); //备注
objvSenateGaugeItemsEN.QuestionTypeName = objRow[convSenateGaugeItems.QuestionTypeName] == DBNull.Value ? null : objRow[convSenateGaugeItems.QuestionTypeName].ToString().Trim(); //题目类型名
objvSenateGaugeItemsEN.AnswerNum = objRow[convSenateGaugeItems.AnswerNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convSenateGaugeItems.AnswerNum].ToString().Trim()); //答案数
objvSenateGaugeItemsEN.VersionNo = objRow[convSenateGaugeItems.VersionNo] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convSenateGaugeItems.VersionNo].ToString().Trim()); //版本号
objvSenateGaugeItemsEN.IsUse = clsEntityBase2.TransNullToBool_S(objRow[convSenateGaugeItems.IsUse].ToString().Trim()); //是否使用
objvSenateGaugeItemsEN.senateGaugeVersionMemo = objRow[convSenateGaugeItems.senateGaugeVersionMemo] == DBNull.Value ? null : objRow[convSenateGaugeItems.senateGaugeVersionMemo].ToString().Trim(); //评价量表版本说明
objvSenateGaugeItemsEN.senateGaugeItemNameWithOrder = objRow[convSenateGaugeItems.senateGaugeItemNameWithOrder] == DBNull.Value ? null : objRow[convSenateGaugeItems.senateGaugeItemNameWithOrder].ToString().Trim(); //量表指标名称WithOrder
objvSenateGaugeItemsEN.UpdDate = objRow[convSenateGaugeItems.UpdDate] == DBNull.Value ? null : objRow[convSenateGaugeItems.UpdDate].ToString().Trim(); //修改日期
objvSenateGaugeItemsEN.UpdUserId = objRow[convSenateGaugeItems.UpdUserId] == DBNull.Value ? null : objRow[convSenateGaugeItems.UpdUserId].ToString().Trim(); //修改用户Id
objvSenateGaugeItemsEN.IsHaveAdditionalMemo = clsEntityBase2.TransNullToBool_S(objRow[convSenateGaugeItems.IsHaveAdditionalMemo].ToString().Trim()); //是否有附加说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvSenateGaugeItemsEN.IdSenateGaugeItem, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvSenateGaugeItemsEN);
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
public static List<clsvSenateGaugeItemsEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsvSenateGaugeItemsEN> arrObjLst = new List<clsvSenateGaugeItemsEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvSenateGaugeItemsEN objvSenateGaugeItemsEN = new clsvSenateGaugeItemsEN();
try
{
objvSenateGaugeItemsEN.IdSenateGaugeItem = objRow[convSenateGaugeItems.IdSenateGaugeItem].ToString().Trim(); //量表指标流水号
objvSenateGaugeItemsEN.senateGaugeItemID = objRow[convSenateGaugeItems.senateGaugeItemID] == DBNull.Value ? null : objRow[convSenateGaugeItems.senateGaugeItemID].ToString().Trim(); //量表指标ID
objvSenateGaugeItemsEN.senateGaugeItemName = objRow[convSenateGaugeItems.senateGaugeItemName] == DBNull.Value ? null : objRow[convSenateGaugeItems.senateGaugeItemName].ToString().Trim(); //量表指标名称
objvSenateGaugeItemsEN.IdSenateGaugeVersion = objRow[convSenateGaugeItems.IdSenateGaugeVersion].ToString().Trim(); //评价量表版本流水号
objvSenateGaugeItemsEN.senateGaugeVersionName = objRow[convSenateGaugeItems.senateGaugeVersionName] == DBNull.Value ? null : objRow[convSenateGaugeItems.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称
objvSenateGaugeItemsEN.senateGaugeItemDesc = objRow[convSenateGaugeItems.senateGaugeItemDesc] == DBNull.Value ? null : objRow[convSenateGaugeItems.senateGaugeItemDesc].ToString().Trim(); //量表指标说明
objvSenateGaugeItemsEN.senateGaugeItemWeight = objRow[convSenateGaugeItems.senateGaugeItemWeight] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convSenateGaugeItems.senateGaugeItemWeight].ToString().Trim()); //量表指标权重
objvSenateGaugeItemsEN.AnswerModeId = objRow[convSenateGaugeItems.AnswerModeId] == DBNull.Value ? null : objRow[convSenateGaugeItems.AnswerModeId].ToString().Trim(); //答案模式Id
objvSenateGaugeItemsEN.AnswerTypeId = objRow[convSenateGaugeItems.AnswerTypeId] == DBNull.Value ? null : objRow[convSenateGaugeItems.AnswerTypeId].ToString().Trim(); //答案类型ID
objvSenateGaugeItemsEN.GridTitle = objRow[convSenateGaugeItems.GridTitle] == DBNull.Value ? null : objRow[convSenateGaugeItems.GridTitle].ToString().Trim(); //表格标题
objvSenateGaugeItemsEN.QuestionIndex = objRow[convSenateGaugeItems.QuestionIndex] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convSenateGaugeItems.QuestionIndex].ToString().Trim()); //题目序号
objvSenateGaugeItemsEN.senateGaugeVersionID = objRow[convSenateGaugeItems.senateGaugeVersionID].ToString().Trim(); //评价量表版本ID
objvSenateGaugeItemsEN.QuestionNo = objRow[convSenateGaugeItems.QuestionNo] == DBNull.Value ? null : objRow[convSenateGaugeItems.QuestionNo].ToString().Trim(); //题目编号
objvSenateGaugeItemsEN.QuestionTypeId = objRow[convSenateGaugeItems.QuestionTypeId] == DBNull.Value ? null : objRow[convSenateGaugeItems.QuestionTypeId].ToString().Trim(); //题目类型Id
objvSenateGaugeItemsEN.senateGaugeVersionTtlScore = Single.Parse(objRow[convSenateGaugeItems.senateGaugeVersionTtlScore].ToString().Trim()); //评价量表版本总分
objvSenateGaugeItemsEN.AnswerTypeName = objRow[convSenateGaugeItems.AnswerTypeName] == DBNull.Value ? null : objRow[convSenateGaugeItems.AnswerTypeName].ToString().Trim(); //答案类型名
objvSenateGaugeItemsEN.AnswerModeName = objRow[convSenateGaugeItems.AnswerModeName] == DBNull.Value ? null : objRow[convSenateGaugeItems.AnswerModeName].ToString().Trim(); //答案模式名称
objvSenateGaugeItemsEN.senateGaugeItemMemo = objRow[convSenateGaugeItems.senateGaugeItemMemo] == DBNull.Value ? null : objRow[convSenateGaugeItems.senateGaugeItemMemo].ToString().Trim(); //备注
objvSenateGaugeItemsEN.QuestionTypeName = objRow[convSenateGaugeItems.QuestionTypeName] == DBNull.Value ? null : objRow[convSenateGaugeItems.QuestionTypeName].ToString().Trim(); //题目类型名
objvSenateGaugeItemsEN.AnswerNum = objRow[convSenateGaugeItems.AnswerNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convSenateGaugeItems.AnswerNum].ToString().Trim()); //答案数
objvSenateGaugeItemsEN.VersionNo = objRow[convSenateGaugeItems.VersionNo] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convSenateGaugeItems.VersionNo].ToString().Trim()); //版本号
objvSenateGaugeItemsEN.IsUse = clsEntityBase2.TransNullToBool_S(objRow[convSenateGaugeItems.IsUse].ToString().Trim()); //是否使用
objvSenateGaugeItemsEN.senateGaugeVersionMemo = objRow[convSenateGaugeItems.senateGaugeVersionMemo] == DBNull.Value ? null : objRow[convSenateGaugeItems.senateGaugeVersionMemo].ToString().Trim(); //评价量表版本说明
objvSenateGaugeItemsEN.senateGaugeItemNameWithOrder = objRow[convSenateGaugeItems.senateGaugeItemNameWithOrder] == DBNull.Value ? null : objRow[convSenateGaugeItems.senateGaugeItemNameWithOrder].ToString().Trim(); //量表指标名称WithOrder
objvSenateGaugeItemsEN.UpdDate = objRow[convSenateGaugeItems.UpdDate] == DBNull.Value ? null : objRow[convSenateGaugeItems.UpdDate].ToString().Trim(); //修改日期
objvSenateGaugeItemsEN.UpdUserId = objRow[convSenateGaugeItems.UpdUserId] == DBNull.Value ? null : objRow[convSenateGaugeItems.UpdUserId].ToString().Trim(); //修改用户Id
objvSenateGaugeItemsEN.IsHaveAdditionalMemo = clsEntityBase2.TransNullToBool_S(objRow[convSenateGaugeItems.IsHaveAdditionalMemo].ToString().Trim()); //是否有附加说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvSenateGaugeItemsEN.IdSenateGaugeItem, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvSenateGaugeItemsEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsvSenateGaugeItemsEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsvSenateGaugeItemsEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsvSenateGaugeItemsEN> arrObjLst = new List<clsvSenateGaugeItemsEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvSenateGaugeItemsEN objvSenateGaugeItemsEN = new clsvSenateGaugeItemsEN();
try
{
objvSenateGaugeItemsEN.IdSenateGaugeItem = objRow[convSenateGaugeItems.IdSenateGaugeItem].ToString().Trim(); //量表指标流水号
objvSenateGaugeItemsEN.senateGaugeItemID = objRow[convSenateGaugeItems.senateGaugeItemID] == DBNull.Value ? null : objRow[convSenateGaugeItems.senateGaugeItemID].ToString().Trim(); //量表指标ID
objvSenateGaugeItemsEN.senateGaugeItemName = objRow[convSenateGaugeItems.senateGaugeItemName] == DBNull.Value ? null : objRow[convSenateGaugeItems.senateGaugeItemName].ToString().Trim(); //量表指标名称
objvSenateGaugeItemsEN.IdSenateGaugeVersion = objRow[convSenateGaugeItems.IdSenateGaugeVersion].ToString().Trim(); //评价量表版本流水号
objvSenateGaugeItemsEN.senateGaugeVersionName = objRow[convSenateGaugeItems.senateGaugeVersionName] == DBNull.Value ? null : objRow[convSenateGaugeItems.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称
objvSenateGaugeItemsEN.senateGaugeItemDesc = objRow[convSenateGaugeItems.senateGaugeItemDesc] == DBNull.Value ? null : objRow[convSenateGaugeItems.senateGaugeItemDesc].ToString().Trim(); //量表指标说明
objvSenateGaugeItemsEN.senateGaugeItemWeight = objRow[convSenateGaugeItems.senateGaugeItemWeight] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convSenateGaugeItems.senateGaugeItemWeight].ToString().Trim()); //量表指标权重
objvSenateGaugeItemsEN.AnswerModeId = objRow[convSenateGaugeItems.AnswerModeId] == DBNull.Value ? null : objRow[convSenateGaugeItems.AnswerModeId].ToString().Trim(); //答案模式Id
objvSenateGaugeItemsEN.AnswerTypeId = objRow[convSenateGaugeItems.AnswerTypeId] == DBNull.Value ? null : objRow[convSenateGaugeItems.AnswerTypeId].ToString().Trim(); //答案类型ID
objvSenateGaugeItemsEN.GridTitle = objRow[convSenateGaugeItems.GridTitle] == DBNull.Value ? null : objRow[convSenateGaugeItems.GridTitle].ToString().Trim(); //表格标题
objvSenateGaugeItemsEN.QuestionIndex = objRow[convSenateGaugeItems.QuestionIndex] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convSenateGaugeItems.QuestionIndex].ToString().Trim()); //题目序号
objvSenateGaugeItemsEN.senateGaugeVersionID = objRow[convSenateGaugeItems.senateGaugeVersionID].ToString().Trim(); //评价量表版本ID
objvSenateGaugeItemsEN.QuestionNo = objRow[convSenateGaugeItems.QuestionNo] == DBNull.Value ? null : objRow[convSenateGaugeItems.QuestionNo].ToString().Trim(); //题目编号
objvSenateGaugeItemsEN.QuestionTypeId = objRow[convSenateGaugeItems.QuestionTypeId] == DBNull.Value ? null : objRow[convSenateGaugeItems.QuestionTypeId].ToString().Trim(); //题目类型Id
objvSenateGaugeItemsEN.senateGaugeVersionTtlScore = Single.Parse(objRow[convSenateGaugeItems.senateGaugeVersionTtlScore].ToString().Trim()); //评价量表版本总分
objvSenateGaugeItemsEN.AnswerTypeName = objRow[convSenateGaugeItems.AnswerTypeName] == DBNull.Value ? null : objRow[convSenateGaugeItems.AnswerTypeName].ToString().Trim(); //答案类型名
objvSenateGaugeItemsEN.AnswerModeName = objRow[convSenateGaugeItems.AnswerModeName] == DBNull.Value ? null : objRow[convSenateGaugeItems.AnswerModeName].ToString().Trim(); //答案模式名称
objvSenateGaugeItemsEN.senateGaugeItemMemo = objRow[convSenateGaugeItems.senateGaugeItemMemo] == DBNull.Value ? null : objRow[convSenateGaugeItems.senateGaugeItemMemo].ToString().Trim(); //备注
objvSenateGaugeItemsEN.QuestionTypeName = objRow[convSenateGaugeItems.QuestionTypeName] == DBNull.Value ? null : objRow[convSenateGaugeItems.QuestionTypeName].ToString().Trim(); //题目类型名
objvSenateGaugeItemsEN.AnswerNum = objRow[convSenateGaugeItems.AnswerNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convSenateGaugeItems.AnswerNum].ToString().Trim()); //答案数
objvSenateGaugeItemsEN.VersionNo = objRow[convSenateGaugeItems.VersionNo] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convSenateGaugeItems.VersionNo].ToString().Trim()); //版本号
objvSenateGaugeItemsEN.IsUse = clsEntityBase2.TransNullToBool_S(objRow[convSenateGaugeItems.IsUse].ToString().Trim()); //是否使用
objvSenateGaugeItemsEN.senateGaugeVersionMemo = objRow[convSenateGaugeItems.senateGaugeVersionMemo] == DBNull.Value ? null : objRow[convSenateGaugeItems.senateGaugeVersionMemo].ToString().Trim(); //评价量表版本说明
objvSenateGaugeItemsEN.senateGaugeItemNameWithOrder = objRow[convSenateGaugeItems.senateGaugeItemNameWithOrder] == DBNull.Value ? null : objRow[convSenateGaugeItems.senateGaugeItemNameWithOrder].ToString().Trim(); //量表指标名称WithOrder
objvSenateGaugeItemsEN.UpdDate = objRow[convSenateGaugeItems.UpdDate] == DBNull.Value ? null : objRow[convSenateGaugeItems.UpdDate].ToString().Trim(); //修改日期
objvSenateGaugeItemsEN.UpdUserId = objRow[convSenateGaugeItems.UpdUserId] == DBNull.Value ? null : objRow[convSenateGaugeItems.UpdUserId].ToString().Trim(); //修改用户Id
objvSenateGaugeItemsEN.IsHaveAdditionalMemo = clsEntityBase2.TransNullToBool_S(objRow[convSenateGaugeItems.IsHaveAdditionalMemo].ToString().Trim()); //是否有附加说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvSenateGaugeItemsEN.IdSenateGaugeItem, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvSenateGaugeItemsEN);
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
public static List<clsvSenateGaugeItemsEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsvSenateGaugeItemsEN> arrObjLst = new List<clsvSenateGaugeItemsEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvSenateGaugeItemsEN objvSenateGaugeItemsEN = new clsvSenateGaugeItemsEN();
try
{
objvSenateGaugeItemsEN.IdSenateGaugeItem = objRow[convSenateGaugeItems.IdSenateGaugeItem].ToString().Trim(); //量表指标流水号
objvSenateGaugeItemsEN.senateGaugeItemID = objRow[convSenateGaugeItems.senateGaugeItemID] == DBNull.Value ? null : objRow[convSenateGaugeItems.senateGaugeItemID].ToString().Trim(); //量表指标ID
objvSenateGaugeItemsEN.senateGaugeItemName = objRow[convSenateGaugeItems.senateGaugeItemName] == DBNull.Value ? null : objRow[convSenateGaugeItems.senateGaugeItemName].ToString().Trim(); //量表指标名称
objvSenateGaugeItemsEN.IdSenateGaugeVersion = objRow[convSenateGaugeItems.IdSenateGaugeVersion].ToString().Trim(); //评价量表版本流水号
objvSenateGaugeItemsEN.senateGaugeVersionName = objRow[convSenateGaugeItems.senateGaugeVersionName] == DBNull.Value ? null : objRow[convSenateGaugeItems.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称
objvSenateGaugeItemsEN.senateGaugeItemDesc = objRow[convSenateGaugeItems.senateGaugeItemDesc] == DBNull.Value ? null : objRow[convSenateGaugeItems.senateGaugeItemDesc].ToString().Trim(); //量表指标说明
objvSenateGaugeItemsEN.senateGaugeItemWeight = objRow[convSenateGaugeItems.senateGaugeItemWeight] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convSenateGaugeItems.senateGaugeItemWeight].ToString().Trim()); //量表指标权重
objvSenateGaugeItemsEN.AnswerModeId = objRow[convSenateGaugeItems.AnswerModeId] == DBNull.Value ? null : objRow[convSenateGaugeItems.AnswerModeId].ToString().Trim(); //答案模式Id
objvSenateGaugeItemsEN.AnswerTypeId = objRow[convSenateGaugeItems.AnswerTypeId] == DBNull.Value ? null : objRow[convSenateGaugeItems.AnswerTypeId].ToString().Trim(); //答案类型ID
objvSenateGaugeItemsEN.GridTitle = objRow[convSenateGaugeItems.GridTitle] == DBNull.Value ? null : objRow[convSenateGaugeItems.GridTitle].ToString().Trim(); //表格标题
objvSenateGaugeItemsEN.QuestionIndex = objRow[convSenateGaugeItems.QuestionIndex] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convSenateGaugeItems.QuestionIndex].ToString().Trim()); //题目序号
objvSenateGaugeItemsEN.senateGaugeVersionID = objRow[convSenateGaugeItems.senateGaugeVersionID].ToString().Trim(); //评价量表版本ID
objvSenateGaugeItemsEN.QuestionNo = objRow[convSenateGaugeItems.QuestionNo] == DBNull.Value ? null : objRow[convSenateGaugeItems.QuestionNo].ToString().Trim(); //题目编号
objvSenateGaugeItemsEN.QuestionTypeId = objRow[convSenateGaugeItems.QuestionTypeId] == DBNull.Value ? null : objRow[convSenateGaugeItems.QuestionTypeId].ToString().Trim(); //题目类型Id
objvSenateGaugeItemsEN.senateGaugeVersionTtlScore = Single.Parse(objRow[convSenateGaugeItems.senateGaugeVersionTtlScore].ToString().Trim()); //评价量表版本总分
objvSenateGaugeItemsEN.AnswerTypeName = objRow[convSenateGaugeItems.AnswerTypeName] == DBNull.Value ? null : objRow[convSenateGaugeItems.AnswerTypeName].ToString().Trim(); //答案类型名
objvSenateGaugeItemsEN.AnswerModeName = objRow[convSenateGaugeItems.AnswerModeName] == DBNull.Value ? null : objRow[convSenateGaugeItems.AnswerModeName].ToString().Trim(); //答案模式名称
objvSenateGaugeItemsEN.senateGaugeItemMemo = objRow[convSenateGaugeItems.senateGaugeItemMemo] == DBNull.Value ? null : objRow[convSenateGaugeItems.senateGaugeItemMemo].ToString().Trim(); //备注
objvSenateGaugeItemsEN.QuestionTypeName = objRow[convSenateGaugeItems.QuestionTypeName] == DBNull.Value ? null : objRow[convSenateGaugeItems.QuestionTypeName].ToString().Trim(); //题目类型名
objvSenateGaugeItemsEN.AnswerNum = objRow[convSenateGaugeItems.AnswerNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convSenateGaugeItems.AnswerNum].ToString().Trim()); //答案数
objvSenateGaugeItemsEN.VersionNo = objRow[convSenateGaugeItems.VersionNo] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convSenateGaugeItems.VersionNo].ToString().Trim()); //版本号
objvSenateGaugeItemsEN.IsUse = clsEntityBase2.TransNullToBool_S(objRow[convSenateGaugeItems.IsUse].ToString().Trim()); //是否使用
objvSenateGaugeItemsEN.senateGaugeVersionMemo = objRow[convSenateGaugeItems.senateGaugeVersionMemo] == DBNull.Value ? null : objRow[convSenateGaugeItems.senateGaugeVersionMemo].ToString().Trim(); //评价量表版本说明
objvSenateGaugeItemsEN.senateGaugeItemNameWithOrder = objRow[convSenateGaugeItems.senateGaugeItemNameWithOrder] == DBNull.Value ? null : objRow[convSenateGaugeItems.senateGaugeItemNameWithOrder].ToString().Trim(); //量表指标名称WithOrder
objvSenateGaugeItemsEN.UpdDate = objRow[convSenateGaugeItems.UpdDate] == DBNull.Value ? null : objRow[convSenateGaugeItems.UpdDate].ToString().Trim(); //修改日期
objvSenateGaugeItemsEN.UpdUserId = objRow[convSenateGaugeItems.UpdUserId] == DBNull.Value ? null : objRow[convSenateGaugeItems.UpdUserId].ToString().Trim(); //修改用户Id
objvSenateGaugeItemsEN.IsHaveAdditionalMemo = clsEntityBase2.TransNullToBool_S(objRow[convSenateGaugeItems.IsHaveAdditionalMemo].ToString().Trim()); //是否有附加说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvSenateGaugeItemsEN.IdSenateGaugeItem, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvSenateGaugeItemsEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsvSenateGaugeItemsEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsvSenateGaugeItemsEN> arrObjLst = new List<clsvSenateGaugeItemsEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvSenateGaugeItemsEN objvSenateGaugeItemsEN = new clsvSenateGaugeItemsEN();
try
{
objvSenateGaugeItemsEN.IdSenateGaugeItem = objRow[convSenateGaugeItems.IdSenateGaugeItem].ToString().Trim(); //量表指标流水号
objvSenateGaugeItemsEN.senateGaugeItemID = objRow[convSenateGaugeItems.senateGaugeItemID] == DBNull.Value ? null : objRow[convSenateGaugeItems.senateGaugeItemID].ToString().Trim(); //量表指标ID
objvSenateGaugeItemsEN.senateGaugeItemName = objRow[convSenateGaugeItems.senateGaugeItemName] == DBNull.Value ? null : objRow[convSenateGaugeItems.senateGaugeItemName].ToString().Trim(); //量表指标名称
objvSenateGaugeItemsEN.IdSenateGaugeVersion = objRow[convSenateGaugeItems.IdSenateGaugeVersion].ToString().Trim(); //评价量表版本流水号
objvSenateGaugeItemsEN.senateGaugeVersionName = objRow[convSenateGaugeItems.senateGaugeVersionName] == DBNull.Value ? null : objRow[convSenateGaugeItems.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称
objvSenateGaugeItemsEN.senateGaugeItemDesc = objRow[convSenateGaugeItems.senateGaugeItemDesc] == DBNull.Value ? null : objRow[convSenateGaugeItems.senateGaugeItemDesc].ToString().Trim(); //量表指标说明
objvSenateGaugeItemsEN.senateGaugeItemWeight = objRow[convSenateGaugeItems.senateGaugeItemWeight] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convSenateGaugeItems.senateGaugeItemWeight].ToString().Trim()); //量表指标权重
objvSenateGaugeItemsEN.AnswerModeId = objRow[convSenateGaugeItems.AnswerModeId] == DBNull.Value ? null : objRow[convSenateGaugeItems.AnswerModeId].ToString().Trim(); //答案模式Id
objvSenateGaugeItemsEN.AnswerTypeId = objRow[convSenateGaugeItems.AnswerTypeId] == DBNull.Value ? null : objRow[convSenateGaugeItems.AnswerTypeId].ToString().Trim(); //答案类型ID
objvSenateGaugeItemsEN.GridTitle = objRow[convSenateGaugeItems.GridTitle] == DBNull.Value ? null : objRow[convSenateGaugeItems.GridTitle].ToString().Trim(); //表格标题
objvSenateGaugeItemsEN.QuestionIndex = objRow[convSenateGaugeItems.QuestionIndex] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convSenateGaugeItems.QuestionIndex].ToString().Trim()); //题目序号
objvSenateGaugeItemsEN.senateGaugeVersionID = objRow[convSenateGaugeItems.senateGaugeVersionID].ToString().Trim(); //评价量表版本ID
objvSenateGaugeItemsEN.QuestionNo = objRow[convSenateGaugeItems.QuestionNo] == DBNull.Value ? null : objRow[convSenateGaugeItems.QuestionNo].ToString().Trim(); //题目编号
objvSenateGaugeItemsEN.QuestionTypeId = objRow[convSenateGaugeItems.QuestionTypeId] == DBNull.Value ? null : objRow[convSenateGaugeItems.QuestionTypeId].ToString().Trim(); //题目类型Id
objvSenateGaugeItemsEN.senateGaugeVersionTtlScore = Single.Parse(objRow[convSenateGaugeItems.senateGaugeVersionTtlScore].ToString().Trim()); //评价量表版本总分
objvSenateGaugeItemsEN.AnswerTypeName = objRow[convSenateGaugeItems.AnswerTypeName] == DBNull.Value ? null : objRow[convSenateGaugeItems.AnswerTypeName].ToString().Trim(); //答案类型名
objvSenateGaugeItemsEN.AnswerModeName = objRow[convSenateGaugeItems.AnswerModeName] == DBNull.Value ? null : objRow[convSenateGaugeItems.AnswerModeName].ToString().Trim(); //答案模式名称
objvSenateGaugeItemsEN.senateGaugeItemMemo = objRow[convSenateGaugeItems.senateGaugeItemMemo] == DBNull.Value ? null : objRow[convSenateGaugeItems.senateGaugeItemMemo].ToString().Trim(); //备注
objvSenateGaugeItemsEN.QuestionTypeName = objRow[convSenateGaugeItems.QuestionTypeName] == DBNull.Value ? null : objRow[convSenateGaugeItems.QuestionTypeName].ToString().Trim(); //题目类型名
objvSenateGaugeItemsEN.AnswerNum = objRow[convSenateGaugeItems.AnswerNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convSenateGaugeItems.AnswerNum].ToString().Trim()); //答案数
objvSenateGaugeItemsEN.VersionNo = objRow[convSenateGaugeItems.VersionNo] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convSenateGaugeItems.VersionNo].ToString().Trim()); //版本号
objvSenateGaugeItemsEN.IsUse = clsEntityBase2.TransNullToBool_S(objRow[convSenateGaugeItems.IsUse].ToString().Trim()); //是否使用
objvSenateGaugeItemsEN.senateGaugeVersionMemo = objRow[convSenateGaugeItems.senateGaugeVersionMemo] == DBNull.Value ? null : objRow[convSenateGaugeItems.senateGaugeVersionMemo].ToString().Trim(); //评价量表版本说明
objvSenateGaugeItemsEN.senateGaugeItemNameWithOrder = objRow[convSenateGaugeItems.senateGaugeItemNameWithOrder] == DBNull.Value ? null : objRow[convSenateGaugeItems.senateGaugeItemNameWithOrder].ToString().Trim(); //量表指标名称WithOrder
objvSenateGaugeItemsEN.UpdDate = objRow[convSenateGaugeItems.UpdDate] == DBNull.Value ? null : objRow[convSenateGaugeItems.UpdDate].ToString().Trim(); //修改日期
objvSenateGaugeItemsEN.UpdUserId = objRow[convSenateGaugeItems.UpdUserId] == DBNull.Value ? null : objRow[convSenateGaugeItems.UpdUserId].ToString().Trim(); //修改用户Id
objvSenateGaugeItemsEN.IsHaveAdditionalMemo = clsEntityBase2.TransNullToBool_S(objRow[convSenateGaugeItems.IsHaveAdditionalMemo].ToString().Trim()); //是否有附加说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvSenateGaugeItemsEN.IdSenateGaugeItem, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvSenateGaugeItemsEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objvSenateGaugeItemsEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetvSenateGaugeItems(ref clsvSenateGaugeItemsEN objvSenateGaugeItemsEN)
{
bool bolResult = vSenateGaugeItemsDA.GetvSenateGaugeItems(ref objvSenateGaugeItemsEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "strIdSenateGaugeItem">表关键字</param>
 /// <returns>表对象</returns>
public static clsvSenateGaugeItemsEN GetObjByIdSenateGaugeItem(string strIdSenateGaugeItem)
{
if (strIdSenateGaugeItem.IndexOf(' ') >=0)
{
var strMsg = string.Format("(errid:Busi000079)在表中,关键字[strIdSenateGaugeItem]中不能有空格!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
if (string.IsNullOrEmpty(strIdSenateGaugeItem) == true)
{
var strMsg = string.Format("(errid:Busi000020)在表中,关键字[strIdSenateGaugeItem]不能为空!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
clsvSenateGaugeItemsEN objvSenateGaugeItemsEN = vSenateGaugeItemsDA.GetObjByIdSenateGaugeItem(strIdSenateGaugeItem);
return objvSenateGaugeItemsEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsvSenateGaugeItemsEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsvSenateGaugeItemsEN objvSenateGaugeItemsEN = vSenateGaugeItemsDA.GetFirstObj(strWhereCond);
 return objvSenateGaugeItemsEN;
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
public static clsvSenateGaugeItemsEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsvSenateGaugeItemsEN objvSenateGaugeItemsEN = vSenateGaugeItemsDA.GetObjByDataRow(objRow);
 return objvSenateGaugeItemsEN;
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
public static clsvSenateGaugeItemsEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsvSenateGaugeItemsEN objvSenateGaugeItemsEN = vSenateGaugeItemsDA.GetObjByDataRow(objRow);
 return objvSenateGaugeItemsEN;
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
 /// <param name = "strIdSenateGaugeItem">所给的关键字</param>
 /// <param name = "lstvSenateGaugeItemsObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvSenateGaugeItemsEN GetObjByIdSenateGaugeItemFromList(string strIdSenateGaugeItem, List<clsvSenateGaugeItemsEN> lstvSenateGaugeItemsObjLst)
{
foreach (clsvSenateGaugeItemsEN objvSenateGaugeItemsEN in lstvSenateGaugeItemsObjLst)
{
if (objvSenateGaugeItemsEN.IdSenateGaugeItem == strIdSenateGaugeItem)
{
return objvSenateGaugeItemsEN;
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
public static string GetFirstID_S(string strWhereCond) 
{
 string strIdSenateGaugeItem;
 try
 {
 strIdSenateGaugeItem = new clsvSenateGaugeItemsDA().GetFirstID(strWhereCond);
 return strIdSenateGaugeItem;
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
 arrList = vSenateGaugeItemsDA.GetID(strWhereCond);
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
bool bolIsExist = vSenateGaugeItemsDA.IsExistCondRec(strWhereCond);
return bolIsExist;
}

 /// <summary>
 /// 判断当前表中是否存在给定关键字值的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExist)
 /// </summary>
 /// <param name = "strIdSenateGaugeItem">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public static bool IsExist(string strIdSenateGaugeItem)
{
if (string.IsNullOrEmpty(strIdSenateGaugeItem) == true)
{
var strMsg = string.Format("(errid:Busi000027)在表中,关键字[strIdSenateGaugeItem]不能为空!!(from {0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
//检测记录是否存在
bool bolIsExist = vSenateGaugeItemsDA.IsExist(strIdSenateGaugeItem);
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
 bolIsExist = clsvSenateGaugeItemsDA.IsExistTable();
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
 bolIsExist = vSenateGaugeItemsDA.IsExistTable(strTabName);
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


 #region 克隆复制对象

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_CopyObj_S)
 /// </summary>
 /// <param name = "objvSenateGaugeItemsENS">源对象</param>
 /// <param name = "objvSenateGaugeItemsENT">目标对象</param>
 public static void CopyTo(clsvSenateGaugeItemsEN objvSenateGaugeItemsENS, clsvSenateGaugeItemsEN objvSenateGaugeItemsENT)
{
try
{
objvSenateGaugeItemsENT.IdSenateGaugeItem = objvSenateGaugeItemsENS.IdSenateGaugeItem; //量表指标流水号
objvSenateGaugeItemsENT.senateGaugeItemID = objvSenateGaugeItemsENS.senateGaugeItemID; //量表指标ID
objvSenateGaugeItemsENT.senateGaugeItemName = objvSenateGaugeItemsENS.senateGaugeItemName; //量表指标名称
objvSenateGaugeItemsENT.IdSenateGaugeVersion = objvSenateGaugeItemsENS.IdSenateGaugeVersion; //评价量表版本流水号
objvSenateGaugeItemsENT.senateGaugeVersionName = objvSenateGaugeItemsENS.senateGaugeVersionName; //评价量表版本名称
objvSenateGaugeItemsENT.senateGaugeItemDesc = objvSenateGaugeItemsENS.senateGaugeItemDesc; //量表指标说明
objvSenateGaugeItemsENT.senateGaugeItemWeight = objvSenateGaugeItemsENS.senateGaugeItemWeight; //量表指标权重
objvSenateGaugeItemsENT.AnswerModeId = objvSenateGaugeItemsENS.AnswerModeId; //答案模式Id
objvSenateGaugeItemsENT.AnswerTypeId = objvSenateGaugeItemsENS.AnswerTypeId; //答案类型ID
objvSenateGaugeItemsENT.GridTitle = objvSenateGaugeItemsENS.GridTitle; //表格标题
objvSenateGaugeItemsENT.QuestionIndex = objvSenateGaugeItemsENS.QuestionIndex; //题目序号
objvSenateGaugeItemsENT.senateGaugeVersionID = objvSenateGaugeItemsENS.senateGaugeVersionID; //评价量表版本ID
objvSenateGaugeItemsENT.QuestionNo = objvSenateGaugeItemsENS.QuestionNo; //题目编号
objvSenateGaugeItemsENT.QuestionTypeId = objvSenateGaugeItemsENS.QuestionTypeId; //题目类型Id
objvSenateGaugeItemsENT.senateGaugeVersionTtlScore = objvSenateGaugeItemsENS.senateGaugeVersionTtlScore; //评价量表版本总分
objvSenateGaugeItemsENT.AnswerTypeName = objvSenateGaugeItemsENS.AnswerTypeName; //答案类型名
objvSenateGaugeItemsENT.AnswerModeName = objvSenateGaugeItemsENS.AnswerModeName; //答案模式名称
objvSenateGaugeItemsENT.senateGaugeItemMemo = objvSenateGaugeItemsENS.senateGaugeItemMemo; //备注
objvSenateGaugeItemsENT.QuestionTypeName = objvSenateGaugeItemsENS.QuestionTypeName; //题目类型名
objvSenateGaugeItemsENT.AnswerNum = objvSenateGaugeItemsENS.AnswerNum; //答案数
objvSenateGaugeItemsENT.VersionNo = objvSenateGaugeItemsENS.VersionNo; //版本号
objvSenateGaugeItemsENT.IsUse = objvSenateGaugeItemsENS.IsUse; //是否使用
objvSenateGaugeItemsENT.senateGaugeVersionMemo = objvSenateGaugeItemsENS.senateGaugeVersionMemo; //评价量表版本说明
objvSenateGaugeItemsENT.senateGaugeItemNameWithOrder = objvSenateGaugeItemsENS.senateGaugeItemNameWithOrder; //量表指标名称WithOrder
objvSenateGaugeItemsENT.UpdDate = objvSenateGaugeItemsENS.UpdDate; //修改日期
objvSenateGaugeItemsENT.UpdUserId = objvSenateGaugeItemsENS.UpdUserId; //修改用户Id
objvSenateGaugeItemsENT.IsHaveAdditionalMemo = objvSenateGaugeItemsENS.IsHaveAdditionalMemo; //是否有附加说明
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
 /// <param name = "objvSenateGaugeItemsEN">源简化对象</param>
 public static void SetUpdFlag(clsvSenateGaugeItemsEN objvSenateGaugeItemsEN)
{
try
{
objvSenateGaugeItemsEN.ClearUpdateState();
   string strsfUpdFldSetStr = objvSenateGaugeItemsEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(convSenateGaugeItems.IdSenateGaugeItem, new clsStrCompareIgnoreCase())  ==  true)
{
objvSenateGaugeItemsEN.IdSenateGaugeItem = objvSenateGaugeItemsEN.IdSenateGaugeItem; //量表指标流水号
}
if (arrFldSet.Contains(convSenateGaugeItems.senateGaugeItemID, new clsStrCompareIgnoreCase())  ==  true)
{
objvSenateGaugeItemsEN.senateGaugeItemID = objvSenateGaugeItemsEN.senateGaugeItemID == "[null]" ? null :  objvSenateGaugeItemsEN.senateGaugeItemID; //量表指标ID
}
if (arrFldSet.Contains(convSenateGaugeItems.senateGaugeItemName, new clsStrCompareIgnoreCase())  ==  true)
{
objvSenateGaugeItemsEN.senateGaugeItemName = objvSenateGaugeItemsEN.senateGaugeItemName == "[null]" ? null :  objvSenateGaugeItemsEN.senateGaugeItemName; //量表指标名称
}
if (arrFldSet.Contains(convSenateGaugeItems.IdSenateGaugeVersion, new clsStrCompareIgnoreCase())  ==  true)
{
objvSenateGaugeItemsEN.IdSenateGaugeVersion = objvSenateGaugeItemsEN.IdSenateGaugeVersion; //评价量表版本流水号
}
if (arrFldSet.Contains(convSenateGaugeItems.senateGaugeVersionName, new clsStrCompareIgnoreCase())  ==  true)
{
objvSenateGaugeItemsEN.senateGaugeVersionName = objvSenateGaugeItemsEN.senateGaugeVersionName == "[null]" ? null :  objvSenateGaugeItemsEN.senateGaugeVersionName; //评价量表版本名称
}
if (arrFldSet.Contains(convSenateGaugeItems.senateGaugeItemDesc, new clsStrCompareIgnoreCase())  ==  true)
{
objvSenateGaugeItemsEN.senateGaugeItemDesc = objvSenateGaugeItemsEN.senateGaugeItemDesc == "[null]" ? null :  objvSenateGaugeItemsEN.senateGaugeItemDesc; //量表指标说明
}
if (arrFldSet.Contains(convSenateGaugeItems.senateGaugeItemWeight, new clsStrCompareIgnoreCase())  ==  true)
{
objvSenateGaugeItemsEN.senateGaugeItemWeight = objvSenateGaugeItemsEN.senateGaugeItemWeight; //量表指标权重
}
if (arrFldSet.Contains(convSenateGaugeItems.AnswerModeId, new clsStrCompareIgnoreCase())  ==  true)
{
objvSenateGaugeItemsEN.AnswerModeId = objvSenateGaugeItemsEN.AnswerModeId == "[null]" ? null :  objvSenateGaugeItemsEN.AnswerModeId; //答案模式Id
}
if (arrFldSet.Contains(convSenateGaugeItems.AnswerTypeId, new clsStrCompareIgnoreCase())  ==  true)
{
objvSenateGaugeItemsEN.AnswerTypeId = objvSenateGaugeItemsEN.AnswerTypeId == "[null]" ? null :  objvSenateGaugeItemsEN.AnswerTypeId; //答案类型ID
}
if (arrFldSet.Contains(convSenateGaugeItems.GridTitle, new clsStrCompareIgnoreCase())  ==  true)
{
objvSenateGaugeItemsEN.GridTitle = objvSenateGaugeItemsEN.GridTitle == "[null]" ? null :  objvSenateGaugeItemsEN.GridTitle; //表格标题
}
if (arrFldSet.Contains(convSenateGaugeItems.QuestionIndex, new clsStrCompareIgnoreCase())  ==  true)
{
objvSenateGaugeItemsEN.QuestionIndex = objvSenateGaugeItemsEN.QuestionIndex; //题目序号
}
if (arrFldSet.Contains(convSenateGaugeItems.senateGaugeVersionID, new clsStrCompareIgnoreCase())  ==  true)
{
objvSenateGaugeItemsEN.senateGaugeVersionID = objvSenateGaugeItemsEN.senateGaugeVersionID; //评价量表版本ID
}
if (arrFldSet.Contains(convSenateGaugeItems.QuestionNo, new clsStrCompareIgnoreCase())  ==  true)
{
objvSenateGaugeItemsEN.QuestionNo = objvSenateGaugeItemsEN.QuestionNo == "[null]" ? null :  objvSenateGaugeItemsEN.QuestionNo; //题目编号
}
if (arrFldSet.Contains(convSenateGaugeItems.QuestionTypeId, new clsStrCompareIgnoreCase())  ==  true)
{
objvSenateGaugeItemsEN.QuestionTypeId = objvSenateGaugeItemsEN.QuestionTypeId == "[null]" ? null :  objvSenateGaugeItemsEN.QuestionTypeId; //题目类型Id
}
if (arrFldSet.Contains(convSenateGaugeItems.senateGaugeVersionTtlScore, new clsStrCompareIgnoreCase())  ==  true)
{
objvSenateGaugeItemsEN.senateGaugeVersionTtlScore = objvSenateGaugeItemsEN.senateGaugeVersionTtlScore; //评价量表版本总分
}
if (arrFldSet.Contains(convSenateGaugeItems.AnswerTypeName, new clsStrCompareIgnoreCase())  ==  true)
{
objvSenateGaugeItemsEN.AnswerTypeName = objvSenateGaugeItemsEN.AnswerTypeName == "[null]" ? null :  objvSenateGaugeItemsEN.AnswerTypeName; //答案类型名
}
if (arrFldSet.Contains(convSenateGaugeItems.AnswerModeName, new clsStrCompareIgnoreCase())  ==  true)
{
objvSenateGaugeItemsEN.AnswerModeName = objvSenateGaugeItemsEN.AnswerModeName == "[null]" ? null :  objvSenateGaugeItemsEN.AnswerModeName; //答案模式名称
}
if (arrFldSet.Contains(convSenateGaugeItems.senateGaugeItemMemo, new clsStrCompareIgnoreCase())  ==  true)
{
objvSenateGaugeItemsEN.senateGaugeItemMemo = objvSenateGaugeItemsEN.senateGaugeItemMemo == "[null]" ? null :  objvSenateGaugeItemsEN.senateGaugeItemMemo; //备注
}
if (arrFldSet.Contains(convSenateGaugeItems.QuestionTypeName, new clsStrCompareIgnoreCase())  ==  true)
{
objvSenateGaugeItemsEN.QuestionTypeName = objvSenateGaugeItemsEN.QuestionTypeName == "[null]" ? null :  objvSenateGaugeItemsEN.QuestionTypeName; //题目类型名
}
if (arrFldSet.Contains(convSenateGaugeItems.AnswerNum, new clsStrCompareIgnoreCase())  ==  true)
{
objvSenateGaugeItemsEN.AnswerNum = objvSenateGaugeItemsEN.AnswerNum; //答案数
}
if (arrFldSet.Contains(convSenateGaugeItems.VersionNo, new clsStrCompareIgnoreCase())  ==  true)
{
objvSenateGaugeItemsEN.VersionNo = objvSenateGaugeItemsEN.VersionNo; //版本号
}
if (arrFldSet.Contains(convSenateGaugeItems.IsUse, new clsStrCompareIgnoreCase())  ==  true)
{
objvSenateGaugeItemsEN.IsUse = objvSenateGaugeItemsEN.IsUse; //是否使用
}
if (arrFldSet.Contains(convSenateGaugeItems.senateGaugeVersionMemo, new clsStrCompareIgnoreCase())  ==  true)
{
objvSenateGaugeItemsEN.senateGaugeVersionMemo = objvSenateGaugeItemsEN.senateGaugeVersionMemo == "[null]" ? null :  objvSenateGaugeItemsEN.senateGaugeVersionMemo; //评价量表版本说明
}
if (arrFldSet.Contains(convSenateGaugeItems.senateGaugeItemNameWithOrder, new clsStrCompareIgnoreCase())  ==  true)
{
objvSenateGaugeItemsEN.senateGaugeItemNameWithOrder = objvSenateGaugeItemsEN.senateGaugeItemNameWithOrder == "[null]" ? null :  objvSenateGaugeItemsEN.senateGaugeItemNameWithOrder; //量表指标名称WithOrder
}
if (arrFldSet.Contains(convSenateGaugeItems.UpdDate, new clsStrCompareIgnoreCase())  ==  true)
{
objvSenateGaugeItemsEN.UpdDate = objvSenateGaugeItemsEN.UpdDate == "[null]" ? null :  objvSenateGaugeItemsEN.UpdDate; //修改日期
}
if (arrFldSet.Contains(convSenateGaugeItems.UpdUserId, new clsStrCompareIgnoreCase())  ==  true)
{
objvSenateGaugeItemsEN.UpdUserId = objvSenateGaugeItemsEN.UpdUserId == "[null]" ? null :  objvSenateGaugeItemsEN.UpdUserId; //修改用户Id
}
if (arrFldSet.Contains(convSenateGaugeItems.IsHaveAdditionalMemo, new clsStrCompareIgnoreCase())  ==  true)
{
objvSenateGaugeItemsEN.IsHaveAdditionalMemo = objvSenateGaugeItemsEN.IsHaveAdditionalMemo; //是否有附加说明
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
 /// <param name = "objvSenateGaugeItemsEN">源简化对象</param>
 public static void AccessFldValueNull(clsvSenateGaugeItemsEN objvSenateGaugeItemsEN)
{
try
{
if (objvSenateGaugeItemsEN.senateGaugeItemID == "[null]") objvSenateGaugeItemsEN.senateGaugeItemID = null; //量表指标ID
if (objvSenateGaugeItemsEN.senateGaugeItemName == "[null]") objvSenateGaugeItemsEN.senateGaugeItemName = null; //量表指标名称
if (objvSenateGaugeItemsEN.senateGaugeVersionName == "[null]") objvSenateGaugeItemsEN.senateGaugeVersionName = null; //评价量表版本名称
if (objvSenateGaugeItemsEN.senateGaugeItemDesc == "[null]") objvSenateGaugeItemsEN.senateGaugeItemDesc = null; //量表指标说明
if (objvSenateGaugeItemsEN.AnswerModeId == "[null]") objvSenateGaugeItemsEN.AnswerModeId = null; //答案模式Id
if (objvSenateGaugeItemsEN.AnswerTypeId == "[null]") objvSenateGaugeItemsEN.AnswerTypeId = null; //答案类型ID
if (objvSenateGaugeItemsEN.GridTitle == "[null]") objvSenateGaugeItemsEN.GridTitle = null; //表格标题
if (objvSenateGaugeItemsEN.QuestionNo == "[null]") objvSenateGaugeItemsEN.QuestionNo = null; //题目编号
if (objvSenateGaugeItemsEN.QuestionTypeId == "[null]") objvSenateGaugeItemsEN.QuestionTypeId = null; //题目类型Id
if (objvSenateGaugeItemsEN.AnswerTypeName == "[null]") objvSenateGaugeItemsEN.AnswerTypeName = null; //答案类型名
if (objvSenateGaugeItemsEN.AnswerModeName == "[null]") objvSenateGaugeItemsEN.AnswerModeName = null; //答案模式名称
if (objvSenateGaugeItemsEN.senateGaugeItemMemo == "[null]") objvSenateGaugeItemsEN.senateGaugeItemMemo = null; //备注
if (objvSenateGaugeItemsEN.QuestionTypeName == "[null]") objvSenateGaugeItemsEN.QuestionTypeName = null; //题目类型名
if (objvSenateGaugeItemsEN.senateGaugeVersionMemo == "[null]") objvSenateGaugeItemsEN.senateGaugeVersionMemo = null; //评价量表版本说明
if (objvSenateGaugeItemsEN.senateGaugeItemNameWithOrder == "[null]") objvSenateGaugeItemsEN.senateGaugeItemNameWithOrder = null; //量表指标名称WithOrder
if (objvSenateGaugeItemsEN.UpdDate == "[null]") objvSenateGaugeItemsEN.UpdDate = null; //修改日期
if (objvSenateGaugeItemsEN.UpdUserId == "[null]") objvSenateGaugeItemsEN.UpdUserId = null; //修改用户Id
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
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(clsvSenateGaugeItemsEN objvSenateGaugeItemsEN)
{
 vSenateGaugeItemsDA.CheckProperty4Condition(objvSenateGaugeItemsEN);
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
if (clsAnswerModeBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsAnswerModeBL没有刷新缓存机制(clsAnswerModeBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsAnswerTypeBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsAnswerTypeBL没有刷新缓存机制(clsAnswerTypeBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsQuestionTypeBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsQuestionTypeBL没有刷新缓存机制(clsQuestionTypeBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsSenateGaugeVersionBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsSenateGaugeVersionBL没有刷新缓存机制(clsSenateGaugeVersionBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsSenateGaugeItemsBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsSenateGaugeItemsBL没有刷新缓存机制(clsSenateGaugeItemsBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by IdSenateGaugeItem");
//if (arrvSenateGaugeItemsObjLstCache == null)
//{
//arrvSenateGaugeItemsObjLstCache = vSenateGaugeItemsDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "strIdSenateGaugeItem">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvSenateGaugeItemsEN GetObjByIdSenateGaugeItemCache(string strIdSenateGaugeItem)
{
//获取缓存中的对象列表
string strKey = string.Format("{0}", clsvSenateGaugeItemsEN._CurrTabName);
List<clsvSenateGaugeItemsEN> arrvSenateGaugeItemsObjLstCache = GetObjLstCache();
IEnumerable <clsvSenateGaugeItemsEN> arrvSenateGaugeItemsObjLst_Sel =
arrvSenateGaugeItemsObjLstCache
.Where(x=> x.IdSenateGaugeItem == strIdSenateGaugeItem 
);
if (arrvSenateGaugeItemsObjLst_Sel.Count() == 0)
{
   clsvSenateGaugeItemsEN obj = clsvSenateGaugeItemsBL.GetObjByIdSenateGaugeItem(strIdSenateGaugeItem);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
 }
return null;
}
return arrvSenateGaugeItemsObjLst_Sel.First();
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvSenateGaugeItemsEN> GetAllvSenateGaugeItemsObjLstCache()
{
//获取缓存中的对象列表
List<clsvSenateGaugeItemsEN> arrvSenateGaugeItemsObjLstCache = GetObjLstCache(); 
return arrvSenateGaugeItemsObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvSenateGaugeItemsEN> GetObjLstCache()
{
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}", clsvSenateGaugeItemsEN._CurrTabName);
List<clsvSenateGaugeItemsEN> arrvSenateGaugeItemsObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrvSenateGaugeItemsObjLstCache;
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
string strKey = string.Format("{0}", clsvSenateGaugeItemsEN._CurrTabName);
CacheHelper.Remove(strKey);
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


 #endregion 缓存操作


 #region 检查唯一性


 #endregion 检查唯一性

 /// <summary>
 /// 映射函数。根据表映射把输入字段值,映射成输出字段值
 /// 作者:pyf
 /// 日期:2023-08-24
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_func)
 /// </summary>
 /// <param name = "strInFldName">输入字段名</param>
 /// <param name = "strOutFldName">输出字段名</param>
 /// <param name = "strInValue">输入字段值</param>
 /// <returns>返回一个输出字段值</returns>
public static string Func(string strInFldName, string strOutFldName, string strIdSenateGaugeItem)
{
if (strInFldName != convSenateGaugeItems.IdSenateGaugeItem)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (convSenateGaugeItems.AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", convSenateGaugeItems.AttributeName));
throw new Exception(strMsg);
}
var objvSenateGaugeItems = clsvSenateGaugeItemsBL.GetObjByIdSenateGaugeItemCache(strIdSenateGaugeItem);
if (objvSenateGaugeItems == null) return "";
return objvSenateGaugeItems[strOutFldName].ToString();
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
int intRecCount = clsvSenateGaugeItemsDA.GetRecCount(strTabName);
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
int intRecCount = clsvSenateGaugeItemsDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsvSenateGaugeItemsDA.GetRecCount();
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
int intRecCount = clsvSenateGaugeItemsDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objvSenateGaugeItemsCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsvSenateGaugeItemsEN objvSenateGaugeItemsCond)
{
List<clsvSenateGaugeItemsEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsvSenateGaugeItemsEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convSenateGaugeItems.AttributeName)
{
if (objvSenateGaugeItemsCond.IsUpdated(strFldName) == false) continue;
if (objvSenateGaugeItemsCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvSenateGaugeItemsCond[strFldName].ToString());
}
else
{
if (objvSenateGaugeItemsCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvSenateGaugeItemsCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvSenateGaugeItemsCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvSenateGaugeItemsCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvSenateGaugeItemsCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvSenateGaugeItemsCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvSenateGaugeItemsCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvSenateGaugeItemsCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvSenateGaugeItemsCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvSenateGaugeItemsCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvSenateGaugeItemsCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvSenateGaugeItemsCond[strFldName]));
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
 List<string> arrList = clsvSenateGaugeItemsDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = vSenateGaugeItemsDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = vSenateGaugeItemsDA.GetFldValueNoDistinct(strFldName, strWhereCond);
return arrList;
}



 #endregion 表操作常用函数
}
}