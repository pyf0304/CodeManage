
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvSenateGaugeSubItemsBL
 表名:vSenateGaugeSubItems(01120479)
 * 版本:2023.08.23.1(服务器:WIN-SRV103-116)
 日期:2023/08/24 14:49:30
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
public static class  clsvSenateGaugeSubItemsBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "strIdSenateGaugeSubItem">表关键字</param>
 /// <returns>表对象</returns>
public static clsvSenateGaugeSubItemsEN GetObj(this K_IdSenateGaugeSubItem_vSenateGaugeSubItems myKey)
{
clsvSenateGaugeSubItemsEN objvSenateGaugeSubItemsEN = clsvSenateGaugeSubItemsBL.vSenateGaugeSubItemsDA.GetObjByIdSenateGaugeSubItem(myKey.Value);
return objvSenateGaugeSubItemsEN;
}

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSenateGaugeSubItemsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvSenateGaugeSubItemsEN SetIdSenateGaugeSubItem(this clsvSenateGaugeSubItemsEN objvSenateGaugeSubItemsEN, string strIdSenateGaugeSubItem, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdSenateGaugeSubItem, 4, convSenateGaugeSubItems.IdSenateGaugeSubItem);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdSenateGaugeSubItem, 4, convSenateGaugeSubItems.IdSenateGaugeSubItem);
}
objvSenateGaugeSubItemsEN.IdSenateGaugeSubItem = strIdSenateGaugeSubItem; //量表指标子项流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvSenateGaugeSubItemsEN.dicFldComparisonOp.ContainsKey(convSenateGaugeSubItems.IdSenateGaugeSubItem) == false)
{
objvSenateGaugeSubItemsEN.dicFldComparisonOp.Add(convSenateGaugeSubItems.IdSenateGaugeSubItem, strComparisonOp);
}
else
{
objvSenateGaugeSubItemsEN.dicFldComparisonOp[convSenateGaugeSubItems.IdSenateGaugeSubItem] = strComparisonOp;
}
}
return objvSenateGaugeSubItemsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSenateGaugeSubItemsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvSenateGaugeSubItemsEN SetsenateGaugeSubItemID(this clsvSenateGaugeSubItemsEN objvSenateGaugeSubItemsEN, string strsenateGaugeSubItemID, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strsenateGaugeSubItemID, 4, convSenateGaugeSubItems.senateGaugeSubItemID);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strsenateGaugeSubItemID, 4, convSenateGaugeSubItems.senateGaugeSubItemID);
}
objvSenateGaugeSubItemsEN.senateGaugeSubItemID = strsenateGaugeSubItemID; //量表指标子项ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvSenateGaugeSubItemsEN.dicFldComparisonOp.ContainsKey(convSenateGaugeSubItems.senateGaugeSubItemID) == false)
{
objvSenateGaugeSubItemsEN.dicFldComparisonOp.Add(convSenateGaugeSubItems.senateGaugeSubItemID, strComparisonOp);
}
else
{
objvSenateGaugeSubItemsEN.dicFldComparisonOp[convSenateGaugeSubItems.senateGaugeSubItemID] = strComparisonOp;
}
}
return objvSenateGaugeSubItemsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSenateGaugeSubItemsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvSenateGaugeSubItemsEN SetsenateGaugeSubItemName(this clsvSenateGaugeSubItemsEN objvSenateGaugeSubItemsEN, string strsenateGaugeSubItemName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strsenateGaugeSubItemName, 200, convSenateGaugeSubItems.senateGaugeSubItemName);
}
objvSenateGaugeSubItemsEN.senateGaugeSubItemName = strsenateGaugeSubItemName; //量表指标子项名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvSenateGaugeSubItemsEN.dicFldComparisonOp.ContainsKey(convSenateGaugeSubItems.senateGaugeSubItemName) == false)
{
objvSenateGaugeSubItemsEN.dicFldComparisonOp.Add(convSenateGaugeSubItems.senateGaugeSubItemName, strComparisonOp);
}
else
{
objvSenateGaugeSubItemsEN.dicFldComparisonOp[convSenateGaugeSubItems.senateGaugeSubItemName] = strComparisonOp;
}
}
return objvSenateGaugeSubItemsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSenateGaugeSubItemsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvSenateGaugeSubItemsEN SetIdSenateGaugeItem(this clsvSenateGaugeSubItemsEN objvSenateGaugeSubItemsEN, string strIdSenateGaugeItem, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strIdSenateGaugeItem, convSenateGaugeSubItems.IdSenateGaugeItem);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdSenateGaugeItem, 4, convSenateGaugeSubItems.IdSenateGaugeItem);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdSenateGaugeItem, 4, convSenateGaugeSubItems.IdSenateGaugeItem);
}
objvSenateGaugeSubItemsEN.IdSenateGaugeItem = strIdSenateGaugeItem; //量表指标流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvSenateGaugeSubItemsEN.dicFldComparisonOp.ContainsKey(convSenateGaugeSubItems.IdSenateGaugeItem) == false)
{
objvSenateGaugeSubItemsEN.dicFldComparisonOp.Add(convSenateGaugeSubItems.IdSenateGaugeItem, strComparisonOp);
}
else
{
objvSenateGaugeSubItemsEN.dicFldComparisonOp[convSenateGaugeSubItems.IdSenateGaugeItem] = strComparisonOp;
}
}
return objvSenateGaugeSubItemsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSenateGaugeSubItemsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvSenateGaugeSubItemsEN SetsenateGaugeItemName(this clsvSenateGaugeSubItemsEN objvSenateGaugeSubItemsEN, string strsenateGaugeItemName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strsenateGaugeItemName, 200, convSenateGaugeSubItems.senateGaugeItemName);
}
objvSenateGaugeSubItemsEN.senateGaugeItemName = strsenateGaugeItemName; //量表指标名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvSenateGaugeSubItemsEN.dicFldComparisonOp.ContainsKey(convSenateGaugeSubItems.senateGaugeItemName) == false)
{
objvSenateGaugeSubItemsEN.dicFldComparisonOp.Add(convSenateGaugeSubItems.senateGaugeItemName, strComparisonOp);
}
else
{
objvSenateGaugeSubItemsEN.dicFldComparisonOp[convSenateGaugeSubItems.senateGaugeItemName] = strComparisonOp;
}
}
return objvSenateGaugeSubItemsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSenateGaugeSubItemsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvSenateGaugeSubItemsEN SetsenateGaugeVersionName(this clsvSenateGaugeSubItemsEN objvSenateGaugeSubItemsEN, string strsenateGaugeVersionName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strsenateGaugeVersionName, 200, convSenateGaugeSubItems.senateGaugeVersionName);
}
objvSenateGaugeSubItemsEN.senateGaugeVersionName = strsenateGaugeVersionName; //评价量表版本名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvSenateGaugeSubItemsEN.dicFldComparisonOp.ContainsKey(convSenateGaugeSubItems.senateGaugeVersionName) == false)
{
objvSenateGaugeSubItemsEN.dicFldComparisonOp.Add(convSenateGaugeSubItems.senateGaugeVersionName, strComparisonOp);
}
else
{
objvSenateGaugeSubItemsEN.dicFldComparisonOp[convSenateGaugeSubItems.senateGaugeVersionName] = strComparisonOp;
}
}
return objvSenateGaugeSubItemsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSenateGaugeSubItemsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvSenateGaugeSubItemsEN SetsenateGaugeSubItemScore(this clsvSenateGaugeSubItemsEN objvSenateGaugeSubItemsEN, float? fltsenateGaugeSubItemScore, string strComparisonOp="")
	{
objvSenateGaugeSubItemsEN.senateGaugeSubItemScore = fltsenateGaugeSubItemScore; //量表指标子项分数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvSenateGaugeSubItemsEN.dicFldComparisonOp.ContainsKey(convSenateGaugeSubItems.senateGaugeSubItemScore) == false)
{
objvSenateGaugeSubItemsEN.dicFldComparisonOp.Add(convSenateGaugeSubItems.senateGaugeSubItemScore, strComparisonOp);
}
else
{
objvSenateGaugeSubItemsEN.dicFldComparisonOp[convSenateGaugeSubItems.senateGaugeSubItemScore] = strComparisonOp;
}
}
return objvSenateGaugeSubItemsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSenateGaugeSubItemsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvSenateGaugeSubItemsEN SetIdSenateGaugeVersion(this clsvSenateGaugeSubItemsEN objvSenateGaugeSubItemsEN, string strIdSenateGaugeVersion, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strIdSenateGaugeVersion, convSenateGaugeSubItems.IdSenateGaugeVersion);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdSenateGaugeVersion, 4, convSenateGaugeSubItems.IdSenateGaugeVersion);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdSenateGaugeVersion, 4, convSenateGaugeSubItems.IdSenateGaugeVersion);
}
objvSenateGaugeSubItemsEN.IdSenateGaugeVersion = strIdSenateGaugeVersion; //评价量表版本流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvSenateGaugeSubItemsEN.dicFldComparisonOp.ContainsKey(convSenateGaugeSubItems.IdSenateGaugeVersion) == false)
{
objvSenateGaugeSubItemsEN.dicFldComparisonOp.Add(convSenateGaugeSubItems.IdSenateGaugeVersion, strComparisonOp);
}
else
{
objvSenateGaugeSubItemsEN.dicFldComparisonOp[convSenateGaugeSubItems.IdSenateGaugeVersion] = strComparisonOp;
}
}
return objvSenateGaugeSubItemsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSenateGaugeSubItemsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvSenateGaugeSubItemsEN SetsenateGaugeItemID(this clsvSenateGaugeSubItemsEN objvSenateGaugeSubItemsEN, string strsenateGaugeItemID, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strsenateGaugeItemID, 4, convSenateGaugeSubItems.senateGaugeItemID);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strsenateGaugeItemID, 4, convSenateGaugeSubItems.senateGaugeItemID);
}
objvSenateGaugeSubItemsEN.senateGaugeItemID = strsenateGaugeItemID; //量表指标ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvSenateGaugeSubItemsEN.dicFldComparisonOp.ContainsKey(convSenateGaugeSubItems.senateGaugeItemID) == false)
{
objvSenateGaugeSubItemsEN.dicFldComparisonOp.Add(convSenateGaugeSubItems.senateGaugeItemID, strComparisonOp);
}
else
{
objvSenateGaugeSubItemsEN.dicFldComparisonOp[convSenateGaugeSubItems.senateGaugeItemID] = strComparisonOp;
}
}
return objvSenateGaugeSubItemsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSenateGaugeSubItemsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvSenateGaugeSubItemsEN SetsenateGaugeSubItemDesc(this clsvSenateGaugeSubItemsEN objvSenateGaugeSubItemsEN, string strsenateGaugeSubItemDesc, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strsenateGaugeSubItemDesc, 2000, convSenateGaugeSubItems.senateGaugeSubItemDesc);
}
objvSenateGaugeSubItemsEN.senateGaugeSubItemDesc = strsenateGaugeSubItemDesc; //量表指标子项说明
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvSenateGaugeSubItemsEN.dicFldComparisonOp.ContainsKey(convSenateGaugeSubItems.senateGaugeSubItemDesc) == false)
{
objvSenateGaugeSubItemsEN.dicFldComparisonOp.Add(convSenateGaugeSubItems.senateGaugeSubItemDesc, strComparisonOp);
}
else
{
objvSenateGaugeSubItemsEN.dicFldComparisonOp[convSenateGaugeSubItems.senateGaugeSubItemDesc] = strComparisonOp;
}
}
return objvSenateGaugeSubItemsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSenateGaugeSubItemsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvSenateGaugeSubItemsEN SetAnswerTitle(this clsvSenateGaugeSubItemsEN objvSenateGaugeSubItemsEN, string strAnswerTitle, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strAnswerTitle, 20, convSenateGaugeSubItems.AnswerTitle);
}
objvSenateGaugeSubItemsEN.AnswerTitle = strAnswerTitle; //答案标题
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvSenateGaugeSubItemsEN.dicFldComparisonOp.ContainsKey(convSenateGaugeSubItems.AnswerTitle) == false)
{
objvSenateGaugeSubItemsEN.dicFldComparisonOp.Add(convSenateGaugeSubItems.AnswerTitle, strComparisonOp);
}
else
{
objvSenateGaugeSubItemsEN.dicFldComparisonOp[convSenateGaugeSubItems.AnswerTitle] = strComparisonOp;
}
}
return objvSenateGaugeSubItemsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSenateGaugeSubItemsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvSenateGaugeSubItemsEN SetAnswerIndex(this clsvSenateGaugeSubItemsEN objvSenateGaugeSubItemsEN, int? intAnswerIndex, string strComparisonOp="")
	{
objvSenateGaugeSubItemsEN.AnswerIndex = intAnswerIndex; //问答序号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvSenateGaugeSubItemsEN.dicFldComparisonOp.ContainsKey(convSenateGaugeSubItems.AnswerIndex) == false)
{
objvSenateGaugeSubItemsEN.dicFldComparisonOp.Add(convSenateGaugeSubItems.AnswerIndex, strComparisonOp);
}
else
{
objvSenateGaugeSubItemsEN.dicFldComparisonOp[convSenateGaugeSubItems.AnswerIndex] = strComparisonOp;
}
}
return objvSenateGaugeSubItemsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSenateGaugeSubItemsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvSenateGaugeSubItemsEN SetsenateGaugeItemDesc(this clsvSenateGaugeSubItemsEN objvSenateGaugeSubItemsEN, string strsenateGaugeItemDesc, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strsenateGaugeItemDesc, 2000, convSenateGaugeSubItems.senateGaugeItemDesc);
}
objvSenateGaugeSubItemsEN.senateGaugeItemDesc = strsenateGaugeItemDesc; //量表指标说明
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvSenateGaugeSubItemsEN.dicFldComparisonOp.ContainsKey(convSenateGaugeSubItems.senateGaugeItemDesc) == false)
{
objvSenateGaugeSubItemsEN.dicFldComparisonOp.Add(convSenateGaugeSubItems.senateGaugeItemDesc, strComparisonOp);
}
else
{
objvSenateGaugeSubItemsEN.dicFldComparisonOp[convSenateGaugeSubItems.senateGaugeItemDesc] = strComparisonOp;
}
}
return objvSenateGaugeSubItemsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSenateGaugeSubItemsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvSenateGaugeSubItemsEN SetsenateGaugeItemWeight(this clsvSenateGaugeSubItemsEN objvSenateGaugeSubItemsEN, float? fltsenateGaugeItemWeight, string strComparisonOp="")
	{
objvSenateGaugeSubItemsEN.senateGaugeItemWeight = fltsenateGaugeItemWeight; //量表指标权重
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvSenateGaugeSubItemsEN.dicFldComparisonOp.ContainsKey(convSenateGaugeSubItems.senateGaugeItemWeight) == false)
{
objvSenateGaugeSubItemsEN.dicFldComparisonOp.Add(convSenateGaugeSubItems.senateGaugeItemWeight, strComparisonOp);
}
else
{
objvSenateGaugeSubItemsEN.dicFldComparisonOp[convSenateGaugeSubItems.senateGaugeItemWeight] = strComparisonOp;
}
}
return objvSenateGaugeSubItemsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSenateGaugeSubItemsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvSenateGaugeSubItemsEN SetsenateGaugeSubItemMemo(this clsvSenateGaugeSubItemsEN objvSenateGaugeSubItemsEN, string strsenateGaugeSubItemMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strsenateGaugeSubItemMemo, 1000, convSenateGaugeSubItems.senateGaugeSubItemMemo);
}
objvSenateGaugeSubItemsEN.senateGaugeSubItemMemo = strsenateGaugeSubItemMemo; //量表指标子项备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvSenateGaugeSubItemsEN.dicFldComparisonOp.ContainsKey(convSenateGaugeSubItems.senateGaugeSubItemMemo) == false)
{
objvSenateGaugeSubItemsEN.dicFldComparisonOp.Add(convSenateGaugeSubItems.senateGaugeSubItemMemo, strComparisonOp);
}
else
{
objvSenateGaugeSubItemsEN.dicFldComparisonOp[convSenateGaugeSubItems.senateGaugeSubItemMemo] = strComparisonOp;
}
}
return objvSenateGaugeSubItemsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSenateGaugeSubItemsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvSenateGaugeSubItemsEN SetsenateGaugeItemMemo(this clsvSenateGaugeSubItemsEN objvSenateGaugeSubItemsEN, string strsenateGaugeItemMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strsenateGaugeItemMemo, 1000, convSenateGaugeSubItems.senateGaugeItemMemo);
}
objvSenateGaugeSubItemsEN.senateGaugeItemMemo = strsenateGaugeItemMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvSenateGaugeSubItemsEN.dicFldComparisonOp.ContainsKey(convSenateGaugeSubItems.senateGaugeItemMemo) == false)
{
objvSenateGaugeSubItemsEN.dicFldComparisonOp.Add(convSenateGaugeSubItems.senateGaugeItemMemo, strComparisonOp);
}
else
{
objvSenateGaugeSubItemsEN.dicFldComparisonOp[convSenateGaugeSubItems.senateGaugeItemMemo] = strComparisonOp;
}
}
return objvSenateGaugeSubItemsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSenateGaugeSubItemsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvSenateGaugeSubItemsEN SetsenateGaugeVersionID(this clsvSenateGaugeSubItemsEN objvSenateGaugeSubItemsEN, string strsenateGaugeVersionID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strsenateGaugeVersionID, convSenateGaugeSubItems.senateGaugeVersionID);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strsenateGaugeVersionID, 4, convSenateGaugeSubItems.senateGaugeVersionID);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strsenateGaugeVersionID, 4, convSenateGaugeSubItems.senateGaugeVersionID);
}
objvSenateGaugeSubItemsEN.senateGaugeVersionID = strsenateGaugeVersionID; //评价量表版本ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvSenateGaugeSubItemsEN.dicFldComparisonOp.ContainsKey(convSenateGaugeSubItems.senateGaugeVersionID) == false)
{
objvSenateGaugeSubItemsEN.dicFldComparisonOp.Add(convSenateGaugeSubItems.senateGaugeVersionID, strComparisonOp);
}
else
{
objvSenateGaugeSubItemsEN.dicFldComparisonOp[convSenateGaugeSubItems.senateGaugeVersionID] = strComparisonOp;
}
}
return objvSenateGaugeSubItemsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSenateGaugeSubItemsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvSenateGaugeSubItemsEN SetsenateGaugeVersionTtlScore(this clsvSenateGaugeSubItemsEN objvSenateGaugeSubItemsEN, float fltsenateGaugeVersionTtlScore, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(fltsenateGaugeVersionTtlScore, convSenateGaugeSubItems.senateGaugeVersionTtlScore);
objvSenateGaugeSubItemsEN.senateGaugeVersionTtlScore = fltsenateGaugeVersionTtlScore; //评价量表版本总分
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvSenateGaugeSubItemsEN.dicFldComparisonOp.ContainsKey(convSenateGaugeSubItems.senateGaugeVersionTtlScore) == false)
{
objvSenateGaugeSubItemsEN.dicFldComparisonOp.Add(convSenateGaugeSubItems.senateGaugeVersionTtlScore, strComparisonOp);
}
else
{
objvSenateGaugeSubItemsEN.dicFldComparisonOp[convSenateGaugeSubItems.senateGaugeVersionTtlScore] = strComparisonOp;
}
}
return objvSenateGaugeSubItemsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSenateGaugeSubItemsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvSenateGaugeSubItemsEN SetsenateGaugeSubItemAll(this clsvSenateGaugeSubItemsEN objvSenateGaugeSubItemsEN, string strsenateGaugeSubItemAll, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strsenateGaugeSubItemAll, 230, convSenateGaugeSubItems.senateGaugeSubItemAll);
}
objvSenateGaugeSubItemsEN.senateGaugeSubItemAll = strsenateGaugeSubItemAll; //子项等地分数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvSenateGaugeSubItemsEN.dicFldComparisonOp.ContainsKey(convSenateGaugeSubItems.senateGaugeSubItemAll) == false)
{
objvSenateGaugeSubItemsEN.dicFldComparisonOp.Add(convSenateGaugeSubItems.senateGaugeSubItemAll, strComparisonOp);
}
else
{
objvSenateGaugeSubItemsEN.dicFldComparisonOp[convSenateGaugeSubItems.senateGaugeSubItemAll] = strComparisonOp;
}
}
return objvSenateGaugeSubItemsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSenateGaugeSubItemsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvSenateGaugeSubItemsEN SetsenateGaugeSubItemAll2(this clsvSenateGaugeSubItemsEN objvSenateGaugeSubItemsEN, string strsenateGaugeSubItemAll2, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strsenateGaugeSubItemAll2, 2235, convSenateGaugeSubItems.senateGaugeSubItemAll2);
}
objvSenateGaugeSubItemsEN.senateGaugeSubItemAll2 = strsenateGaugeSubItemAll2; //senateGaugeSubItemAll2
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvSenateGaugeSubItemsEN.dicFldComparisonOp.ContainsKey(convSenateGaugeSubItems.senateGaugeSubItemAll2) == false)
{
objvSenateGaugeSubItemsEN.dicFldComparisonOp.Add(convSenateGaugeSubItems.senateGaugeSubItemAll2, strComparisonOp);
}
else
{
objvSenateGaugeSubItemsEN.dicFldComparisonOp[convSenateGaugeSubItems.senateGaugeSubItemAll2] = strComparisonOp;
}
}
return objvSenateGaugeSubItemsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSenateGaugeSubItemsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvSenateGaugeSubItemsEN SetVersionNo(this clsvSenateGaugeSubItemsEN objvSenateGaugeSubItemsEN, int? intVersionNo, string strComparisonOp="")
	{
objvSenateGaugeSubItemsEN.VersionNo = intVersionNo; //版本号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvSenateGaugeSubItemsEN.dicFldComparisonOp.ContainsKey(convSenateGaugeSubItems.VersionNo) == false)
{
objvSenateGaugeSubItemsEN.dicFldComparisonOp.Add(convSenateGaugeSubItems.VersionNo, strComparisonOp);
}
else
{
objvSenateGaugeSubItemsEN.dicFldComparisonOp[convSenateGaugeSubItems.VersionNo] = strComparisonOp;
}
}
return objvSenateGaugeSubItemsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSenateGaugeSubItemsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvSenateGaugeSubItemsEN SetIsUse(this clsvSenateGaugeSubItemsEN objvSenateGaugeSubItemsEN, bool bolIsUse, string strComparisonOp="")
	{
objvSenateGaugeSubItemsEN.IsUse = bolIsUse; //是否使用
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvSenateGaugeSubItemsEN.dicFldComparisonOp.ContainsKey(convSenateGaugeSubItems.IsUse) == false)
{
objvSenateGaugeSubItemsEN.dicFldComparisonOp.Add(convSenateGaugeSubItems.IsUse, strComparisonOp);
}
else
{
objvSenateGaugeSubItemsEN.dicFldComparisonOp[convSenateGaugeSubItems.IsUse] = strComparisonOp;
}
}
return objvSenateGaugeSubItemsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSenateGaugeSubItemsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvSenateGaugeSubItemsEN SetUpdDate(this clsvSenateGaugeSubItemsEN objvSenateGaugeSubItemsEN, string strUpdDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdDate, 20, convSenateGaugeSubItems.UpdDate);
}
objvSenateGaugeSubItemsEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvSenateGaugeSubItemsEN.dicFldComparisonOp.ContainsKey(convSenateGaugeSubItems.UpdDate) == false)
{
objvSenateGaugeSubItemsEN.dicFldComparisonOp.Add(convSenateGaugeSubItems.UpdDate, strComparisonOp);
}
else
{
objvSenateGaugeSubItemsEN.dicFldComparisonOp[convSenateGaugeSubItems.UpdDate] = strComparisonOp;
}
}
return objvSenateGaugeSubItemsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSenateGaugeSubItemsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvSenateGaugeSubItemsEN SetUpdUserId(this clsvSenateGaugeSubItemsEN objvSenateGaugeSubItemsEN, string strUpdUserId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdUserId, 20, convSenateGaugeSubItems.UpdUserId);
}
objvSenateGaugeSubItemsEN.UpdUserId = strUpdUserId; //修改用户Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvSenateGaugeSubItemsEN.dicFldComparisonOp.ContainsKey(convSenateGaugeSubItems.UpdUserId) == false)
{
objvSenateGaugeSubItemsEN.dicFldComparisonOp.Add(convSenateGaugeSubItems.UpdUserId, strComparisonOp);
}
else
{
objvSenateGaugeSubItemsEN.dicFldComparisonOp[convSenateGaugeSubItems.UpdUserId] = strComparisonOp;
}
}
return objvSenateGaugeSubItemsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSenateGaugeSubItemsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvSenateGaugeSubItemsEN SetAnswerModeId(this clsvSenateGaugeSubItemsEN objvSenateGaugeSubItemsEN, string strAnswerModeId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strAnswerModeId, 4, convSenateGaugeSubItems.AnswerModeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strAnswerModeId, 4, convSenateGaugeSubItems.AnswerModeId);
}
objvSenateGaugeSubItemsEN.AnswerModeId = strAnswerModeId; //答案模式Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvSenateGaugeSubItemsEN.dicFldComparisonOp.ContainsKey(convSenateGaugeSubItems.AnswerModeId) == false)
{
objvSenateGaugeSubItemsEN.dicFldComparisonOp.Add(convSenateGaugeSubItems.AnswerModeId, strComparisonOp);
}
else
{
objvSenateGaugeSubItemsEN.dicFldComparisonOp[convSenateGaugeSubItems.AnswerModeId] = strComparisonOp;
}
}
return objvSenateGaugeSubItemsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSenateGaugeSubItemsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvSenateGaugeSubItemsEN SetAnswerModeName(this clsvSenateGaugeSubItemsEN objvSenateGaugeSubItemsEN, string strAnswerModeName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strAnswerModeName, 30, convSenateGaugeSubItems.AnswerModeName);
}
objvSenateGaugeSubItemsEN.AnswerModeName = strAnswerModeName; //答案模式名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvSenateGaugeSubItemsEN.dicFldComparisonOp.ContainsKey(convSenateGaugeSubItems.AnswerModeName) == false)
{
objvSenateGaugeSubItemsEN.dicFldComparisonOp.Add(convSenateGaugeSubItems.AnswerModeName, strComparisonOp);
}
else
{
objvSenateGaugeSubItemsEN.dicFldComparisonOp[convSenateGaugeSubItems.AnswerModeName] = strComparisonOp;
}
}
return objvSenateGaugeSubItemsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSenateGaugeSubItemsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvSenateGaugeSubItemsEN SetAnswerNum(this clsvSenateGaugeSubItemsEN objvSenateGaugeSubItemsEN, int? intAnswerNum, string strComparisonOp="")
	{
objvSenateGaugeSubItemsEN.AnswerNum = intAnswerNum; //答案数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvSenateGaugeSubItemsEN.dicFldComparisonOp.ContainsKey(convSenateGaugeSubItems.AnswerNum) == false)
{
objvSenateGaugeSubItemsEN.dicFldComparisonOp.Add(convSenateGaugeSubItems.AnswerNum, strComparisonOp);
}
else
{
objvSenateGaugeSubItemsEN.dicFldComparisonOp[convSenateGaugeSubItems.AnswerNum] = strComparisonOp;
}
}
return objvSenateGaugeSubItemsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSenateGaugeSubItemsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvSenateGaugeSubItemsEN SetAnswerTypeId(this clsvSenateGaugeSubItemsEN objvSenateGaugeSubItemsEN, string strAnswerTypeId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strAnswerTypeId, 2, convSenateGaugeSubItems.AnswerTypeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strAnswerTypeId, 2, convSenateGaugeSubItems.AnswerTypeId);
}
objvSenateGaugeSubItemsEN.AnswerTypeId = strAnswerTypeId; //答案类型ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvSenateGaugeSubItemsEN.dicFldComparisonOp.ContainsKey(convSenateGaugeSubItems.AnswerTypeId) == false)
{
objvSenateGaugeSubItemsEN.dicFldComparisonOp.Add(convSenateGaugeSubItems.AnswerTypeId, strComparisonOp);
}
else
{
objvSenateGaugeSubItemsEN.dicFldComparisonOp[convSenateGaugeSubItems.AnswerTypeId] = strComparisonOp;
}
}
return objvSenateGaugeSubItemsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSenateGaugeSubItemsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvSenateGaugeSubItemsEN SetAnswerTypeName(this clsvSenateGaugeSubItemsEN objvSenateGaugeSubItemsEN, string strAnswerTypeName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strAnswerTypeName, 50, convSenateGaugeSubItems.AnswerTypeName);
}
objvSenateGaugeSubItemsEN.AnswerTypeName = strAnswerTypeName; //答案类型名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvSenateGaugeSubItemsEN.dicFldComparisonOp.ContainsKey(convSenateGaugeSubItems.AnswerTypeName) == false)
{
objvSenateGaugeSubItemsEN.dicFldComparisonOp.Add(convSenateGaugeSubItems.AnswerTypeName, strComparisonOp);
}
else
{
objvSenateGaugeSubItemsEN.dicFldComparisonOp[convSenateGaugeSubItems.AnswerTypeName] = strComparisonOp;
}
}
return objvSenateGaugeSubItemsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSenateGaugeSubItemsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvSenateGaugeSubItemsEN SetGridTitle(this clsvSenateGaugeSubItemsEN objvSenateGaugeSubItemsEN, string strGridTitle, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strGridTitle, 30, convSenateGaugeSubItems.GridTitle);
}
objvSenateGaugeSubItemsEN.GridTitle = strGridTitle; //表格标题
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvSenateGaugeSubItemsEN.dicFldComparisonOp.ContainsKey(convSenateGaugeSubItems.GridTitle) == false)
{
objvSenateGaugeSubItemsEN.dicFldComparisonOp.Add(convSenateGaugeSubItems.GridTitle, strComparisonOp);
}
else
{
objvSenateGaugeSubItemsEN.dicFldComparisonOp[convSenateGaugeSubItems.GridTitle] = strComparisonOp;
}
}
return objvSenateGaugeSubItemsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSenateGaugeSubItemsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvSenateGaugeSubItemsEN SetIsHaveAdditionalMemo(this clsvSenateGaugeSubItemsEN objvSenateGaugeSubItemsEN, bool bolIsHaveAdditionalMemo, string strComparisonOp="")
	{
objvSenateGaugeSubItemsEN.IsHaveAdditionalMemo = bolIsHaveAdditionalMemo; //是否有附加说明
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvSenateGaugeSubItemsEN.dicFldComparisonOp.ContainsKey(convSenateGaugeSubItems.IsHaveAdditionalMemo) == false)
{
objvSenateGaugeSubItemsEN.dicFldComparisonOp.Add(convSenateGaugeSubItems.IsHaveAdditionalMemo, strComparisonOp);
}
else
{
objvSenateGaugeSubItemsEN.dicFldComparisonOp[convSenateGaugeSubItems.IsHaveAdditionalMemo] = strComparisonOp;
}
}
return objvSenateGaugeSubItemsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSenateGaugeSubItemsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvSenateGaugeSubItemsEN SetQuestionIndex(this clsvSenateGaugeSubItemsEN objvSenateGaugeSubItemsEN, int? intQuestionIndex, string strComparisonOp="")
	{
objvSenateGaugeSubItemsEN.QuestionIndex = intQuestionIndex; //题目序号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvSenateGaugeSubItemsEN.dicFldComparisonOp.ContainsKey(convSenateGaugeSubItems.QuestionIndex) == false)
{
objvSenateGaugeSubItemsEN.dicFldComparisonOp.Add(convSenateGaugeSubItems.QuestionIndex, strComparisonOp);
}
else
{
objvSenateGaugeSubItemsEN.dicFldComparisonOp[convSenateGaugeSubItems.QuestionIndex] = strComparisonOp;
}
}
return objvSenateGaugeSubItemsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSenateGaugeSubItemsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvSenateGaugeSubItemsEN SetQuestionNo(this clsvSenateGaugeSubItemsEN objvSenateGaugeSubItemsEN, string strQuestionNo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strQuestionNo, 10, convSenateGaugeSubItems.QuestionNo);
}
objvSenateGaugeSubItemsEN.QuestionNo = strQuestionNo; //题目编号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvSenateGaugeSubItemsEN.dicFldComparisonOp.ContainsKey(convSenateGaugeSubItems.QuestionNo) == false)
{
objvSenateGaugeSubItemsEN.dicFldComparisonOp.Add(convSenateGaugeSubItems.QuestionNo, strComparisonOp);
}
else
{
objvSenateGaugeSubItemsEN.dicFldComparisonOp[convSenateGaugeSubItems.QuestionNo] = strComparisonOp;
}
}
return objvSenateGaugeSubItemsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSenateGaugeSubItemsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvSenateGaugeSubItemsEN SetQuestionTypeId(this clsvSenateGaugeSubItemsEN objvSenateGaugeSubItemsEN, string strQuestionTypeId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strQuestionTypeId, 2, convSenateGaugeSubItems.QuestionTypeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strQuestionTypeId, 2, convSenateGaugeSubItems.QuestionTypeId);
}
objvSenateGaugeSubItemsEN.QuestionTypeId = strQuestionTypeId; //题目类型Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvSenateGaugeSubItemsEN.dicFldComparisonOp.ContainsKey(convSenateGaugeSubItems.QuestionTypeId) == false)
{
objvSenateGaugeSubItemsEN.dicFldComparisonOp.Add(convSenateGaugeSubItems.QuestionTypeId, strComparisonOp);
}
else
{
objvSenateGaugeSubItemsEN.dicFldComparisonOp[convSenateGaugeSubItems.QuestionTypeId] = strComparisonOp;
}
}
return objvSenateGaugeSubItemsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSenateGaugeSubItemsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvSenateGaugeSubItemsEN SetQuestionTypeName(this clsvSenateGaugeSubItemsEN objvSenateGaugeSubItemsEN, string strQuestionTypeName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strQuestionTypeName, 20, convSenateGaugeSubItems.QuestionTypeName);
}
objvSenateGaugeSubItemsEN.QuestionTypeName = strQuestionTypeName; //题目类型名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvSenateGaugeSubItemsEN.dicFldComparisonOp.ContainsKey(convSenateGaugeSubItems.QuestionTypeName) == false)
{
objvSenateGaugeSubItemsEN.dicFldComparisonOp.Add(convSenateGaugeSubItems.QuestionTypeName, strComparisonOp);
}
else
{
objvSenateGaugeSubItemsEN.dicFldComparisonOp[convSenateGaugeSubItems.QuestionTypeName] = strComparisonOp;
}
}
return objvSenateGaugeSubItemsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSenateGaugeSubItemsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvSenateGaugeSubItemsEN SetsenateGaugeItemNameWithOrder(this clsvSenateGaugeSubItemsEN objvSenateGaugeSubItemsEN, string strsenateGaugeItemNameWithOrder, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strsenateGaugeItemNameWithOrder, 204, convSenateGaugeSubItems.senateGaugeItemNameWithOrder);
}
objvSenateGaugeSubItemsEN.senateGaugeItemNameWithOrder = strsenateGaugeItemNameWithOrder; //量表指标名称WithOrder
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvSenateGaugeSubItemsEN.dicFldComparisonOp.ContainsKey(convSenateGaugeSubItems.senateGaugeItemNameWithOrder) == false)
{
objvSenateGaugeSubItemsEN.dicFldComparisonOp.Add(convSenateGaugeSubItems.senateGaugeItemNameWithOrder, strComparisonOp);
}
else
{
objvSenateGaugeSubItemsEN.dicFldComparisonOp[convSenateGaugeSubItems.senateGaugeItemNameWithOrder] = strComparisonOp;
}
}
return objvSenateGaugeSubItemsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSenateGaugeSubItemsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvSenateGaugeSubItemsEN SetsenateGaugeVersionMemo(this clsvSenateGaugeSubItemsEN objvSenateGaugeSubItemsEN, string strsenateGaugeVersionMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strsenateGaugeVersionMemo, 1000, convSenateGaugeSubItems.senateGaugeVersionMemo);
}
objvSenateGaugeSubItemsEN.senateGaugeVersionMemo = strsenateGaugeVersionMemo; //评价量表版本说明
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvSenateGaugeSubItemsEN.dicFldComparisonOp.ContainsKey(convSenateGaugeSubItems.senateGaugeVersionMemo) == false)
{
objvSenateGaugeSubItemsEN.dicFldComparisonOp.Add(convSenateGaugeSubItems.senateGaugeVersionMemo, strComparisonOp);
}
else
{
objvSenateGaugeSubItemsEN.dicFldComparisonOp[convSenateGaugeSubItems.senateGaugeVersionMemo] = strComparisonOp;
}
}
return objvSenateGaugeSubItemsEN;
	}

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CopyObj)
 /// </summary>
 /// <param name = "objvSenateGaugeSubItemsENS">源对象</param>
 /// <param name = "objvSenateGaugeSubItemsENT">目标对象</param>
 public static void CopyTo(this clsvSenateGaugeSubItemsEN objvSenateGaugeSubItemsENS, clsvSenateGaugeSubItemsEN objvSenateGaugeSubItemsENT)
{
try
{
objvSenateGaugeSubItemsENT.IdSenateGaugeSubItem = objvSenateGaugeSubItemsENS.IdSenateGaugeSubItem; //量表指标子项流水号
objvSenateGaugeSubItemsENT.senateGaugeSubItemID = objvSenateGaugeSubItemsENS.senateGaugeSubItemID; //量表指标子项ID
objvSenateGaugeSubItemsENT.senateGaugeSubItemName = objvSenateGaugeSubItemsENS.senateGaugeSubItemName; //量表指标子项名称
objvSenateGaugeSubItemsENT.IdSenateGaugeItem = objvSenateGaugeSubItemsENS.IdSenateGaugeItem; //量表指标流水号
objvSenateGaugeSubItemsENT.senateGaugeItemName = objvSenateGaugeSubItemsENS.senateGaugeItemName; //量表指标名称
objvSenateGaugeSubItemsENT.senateGaugeVersionName = objvSenateGaugeSubItemsENS.senateGaugeVersionName; //评价量表版本名称
objvSenateGaugeSubItemsENT.senateGaugeSubItemScore = objvSenateGaugeSubItemsENS.senateGaugeSubItemScore; //量表指标子项分数
objvSenateGaugeSubItemsENT.IdSenateGaugeVersion = objvSenateGaugeSubItemsENS.IdSenateGaugeVersion; //评价量表版本流水号
objvSenateGaugeSubItemsENT.senateGaugeItemID = objvSenateGaugeSubItemsENS.senateGaugeItemID; //量表指标ID
objvSenateGaugeSubItemsENT.senateGaugeSubItemDesc = objvSenateGaugeSubItemsENS.senateGaugeSubItemDesc; //量表指标子项说明
objvSenateGaugeSubItemsENT.AnswerTitle = objvSenateGaugeSubItemsENS.AnswerTitle; //答案标题
objvSenateGaugeSubItemsENT.AnswerIndex = objvSenateGaugeSubItemsENS.AnswerIndex; //问答序号
objvSenateGaugeSubItemsENT.senateGaugeItemDesc = objvSenateGaugeSubItemsENS.senateGaugeItemDesc; //量表指标说明
objvSenateGaugeSubItemsENT.senateGaugeItemWeight = objvSenateGaugeSubItemsENS.senateGaugeItemWeight; //量表指标权重
objvSenateGaugeSubItemsENT.senateGaugeSubItemMemo = objvSenateGaugeSubItemsENS.senateGaugeSubItemMemo; //量表指标子项备注
objvSenateGaugeSubItemsENT.senateGaugeItemMemo = objvSenateGaugeSubItemsENS.senateGaugeItemMemo; //备注
objvSenateGaugeSubItemsENT.senateGaugeVersionID = objvSenateGaugeSubItemsENS.senateGaugeVersionID; //评价量表版本ID
objvSenateGaugeSubItemsENT.senateGaugeVersionTtlScore = objvSenateGaugeSubItemsENS.senateGaugeVersionTtlScore; //评价量表版本总分
objvSenateGaugeSubItemsENT.senateGaugeSubItemAll = objvSenateGaugeSubItemsENS.senateGaugeSubItemAll; //子项等地分数
objvSenateGaugeSubItemsENT.senateGaugeSubItemAll2 = objvSenateGaugeSubItemsENS.senateGaugeSubItemAll2; //senateGaugeSubItemAll2
objvSenateGaugeSubItemsENT.VersionNo = objvSenateGaugeSubItemsENS.VersionNo; //版本号
objvSenateGaugeSubItemsENT.IsUse = objvSenateGaugeSubItemsENS.IsUse; //是否使用
objvSenateGaugeSubItemsENT.UpdDate = objvSenateGaugeSubItemsENS.UpdDate; //修改日期
objvSenateGaugeSubItemsENT.UpdUserId = objvSenateGaugeSubItemsENS.UpdUserId; //修改用户Id
objvSenateGaugeSubItemsENT.AnswerModeId = objvSenateGaugeSubItemsENS.AnswerModeId; //答案模式Id
objvSenateGaugeSubItemsENT.AnswerModeName = objvSenateGaugeSubItemsENS.AnswerModeName; //答案模式名称
objvSenateGaugeSubItemsENT.AnswerNum = objvSenateGaugeSubItemsENS.AnswerNum; //答案数
objvSenateGaugeSubItemsENT.AnswerTypeId = objvSenateGaugeSubItemsENS.AnswerTypeId; //答案类型ID
objvSenateGaugeSubItemsENT.AnswerTypeName = objvSenateGaugeSubItemsENS.AnswerTypeName; //答案类型名
objvSenateGaugeSubItemsENT.GridTitle = objvSenateGaugeSubItemsENS.GridTitle; //表格标题
objvSenateGaugeSubItemsENT.IsHaveAdditionalMemo = objvSenateGaugeSubItemsENS.IsHaveAdditionalMemo; //是否有附加说明
objvSenateGaugeSubItemsENT.QuestionIndex = objvSenateGaugeSubItemsENS.QuestionIndex; //题目序号
objvSenateGaugeSubItemsENT.QuestionNo = objvSenateGaugeSubItemsENS.QuestionNo; //题目编号
objvSenateGaugeSubItemsENT.QuestionTypeId = objvSenateGaugeSubItemsENS.QuestionTypeId; //题目类型Id
objvSenateGaugeSubItemsENT.QuestionTypeName = objvSenateGaugeSubItemsENS.QuestionTypeName; //题目类型名
objvSenateGaugeSubItemsENT.senateGaugeItemNameWithOrder = objvSenateGaugeSubItemsENS.senateGaugeItemNameWithOrder; //量表指标名称WithOrder
objvSenateGaugeSubItemsENT.senateGaugeVersionMemo = objvSenateGaugeSubItemsENS.senateGaugeVersionMemo; //评价量表版本说明
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
 /// <param name = "objvSenateGaugeSubItemsENS">源对象</param>
 /// <returns>目标对象=>clsvSenateGaugeSubItemsEN:objvSenateGaugeSubItemsENT</returns>
 public static clsvSenateGaugeSubItemsEN CopyTo(this clsvSenateGaugeSubItemsEN objvSenateGaugeSubItemsENS)
{
try
{
 clsvSenateGaugeSubItemsEN objvSenateGaugeSubItemsENT = new clsvSenateGaugeSubItemsEN()
{
IdSenateGaugeSubItem = objvSenateGaugeSubItemsENS.IdSenateGaugeSubItem, //量表指标子项流水号
senateGaugeSubItemID = objvSenateGaugeSubItemsENS.senateGaugeSubItemID, //量表指标子项ID
senateGaugeSubItemName = objvSenateGaugeSubItemsENS.senateGaugeSubItemName, //量表指标子项名称
IdSenateGaugeItem = objvSenateGaugeSubItemsENS.IdSenateGaugeItem, //量表指标流水号
senateGaugeItemName = objvSenateGaugeSubItemsENS.senateGaugeItemName, //量表指标名称
senateGaugeVersionName = objvSenateGaugeSubItemsENS.senateGaugeVersionName, //评价量表版本名称
senateGaugeSubItemScore = objvSenateGaugeSubItemsENS.senateGaugeSubItemScore, //量表指标子项分数
IdSenateGaugeVersion = objvSenateGaugeSubItemsENS.IdSenateGaugeVersion, //评价量表版本流水号
senateGaugeItemID = objvSenateGaugeSubItemsENS.senateGaugeItemID, //量表指标ID
senateGaugeSubItemDesc = objvSenateGaugeSubItemsENS.senateGaugeSubItemDesc, //量表指标子项说明
AnswerTitle = objvSenateGaugeSubItemsENS.AnswerTitle, //答案标题
AnswerIndex = objvSenateGaugeSubItemsENS.AnswerIndex, //问答序号
senateGaugeItemDesc = objvSenateGaugeSubItemsENS.senateGaugeItemDesc, //量表指标说明
senateGaugeItemWeight = objvSenateGaugeSubItemsENS.senateGaugeItemWeight, //量表指标权重
senateGaugeSubItemMemo = objvSenateGaugeSubItemsENS.senateGaugeSubItemMemo, //量表指标子项备注
senateGaugeItemMemo = objvSenateGaugeSubItemsENS.senateGaugeItemMemo, //备注
senateGaugeVersionID = objvSenateGaugeSubItemsENS.senateGaugeVersionID, //评价量表版本ID
senateGaugeVersionTtlScore = objvSenateGaugeSubItemsENS.senateGaugeVersionTtlScore, //评价量表版本总分
senateGaugeSubItemAll = objvSenateGaugeSubItemsENS.senateGaugeSubItemAll, //子项等地分数
senateGaugeSubItemAll2 = objvSenateGaugeSubItemsENS.senateGaugeSubItemAll2, //senateGaugeSubItemAll2
VersionNo = objvSenateGaugeSubItemsENS.VersionNo, //版本号
IsUse = objvSenateGaugeSubItemsENS.IsUse, //是否使用
UpdDate = objvSenateGaugeSubItemsENS.UpdDate, //修改日期
UpdUserId = objvSenateGaugeSubItemsENS.UpdUserId, //修改用户Id
AnswerModeId = objvSenateGaugeSubItemsENS.AnswerModeId, //答案模式Id
AnswerModeName = objvSenateGaugeSubItemsENS.AnswerModeName, //答案模式名称
AnswerNum = objvSenateGaugeSubItemsENS.AnswerNum, //答案数
AnswerTypeId = objvSenateGaugeSubItemsENS.AnswerTypeId, //答案类型ID
AnswerTypeName = objvSenateGaugeSubItemsENS.AnswerTypeName, //答案类型名
GridTitle = objvSenateGaugeSubItemsENS.GridTitle, //表格标题
IsHaveAdditionalMemo = objvSenateGaugeSubItemsENS.IsHaveAdditionalMemo, //是否有附加说明
QuestionIndex = objvSenateGaugeSubItemsENS.QuestionIndex, //题目序号
QuestionNo = objvSenateGaugeSubItemsENS.QuestionNo, //题目编号
QuestionTypeId = objvSenateGaugeSubItemsENS.QuestionTypeId, //题目类型Id
QuestionTypeName = objvSenateGaugeSubItemsENS.QuestionTypeName, //题目类型名
senateGaugeItemNameWithOrder = objvSenateGaugeSubItemsENS.senateGaugeItemNameWithOrder, //量表指标名称WithOrder
senateGaugeVersionMemo = objvSenateGaugeSubItemsENS.senateGaugeVersionMemo, //评价量表版本说明
};
 return objvSenateGaugeSubItemsENT;
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
public static void CheckProperty4Condition(this clsvSenateGaugeSubItemsEN objvSenateGaugeSubItemsEN)
{
 clsvSenateGaugeSubItemsBL.vSenateGaugeSubItemsDA.CheckProperty4Condition(objvSenateGaugeSubItemsEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvSenateGaugeSubItemsEN objvSenateGaugeSubItemsCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvSenateGaugeSubItemsCond.IsUpdated(convSenateGaugeSubItems.IdSenateGaugeSubItem) == true)
{
string strComparisonOpIdSenateGaugeSubItem = objvSenateGaugeSubItemsCond.dicFldComparisonOp[convSenateGaugeSubItems.IdSenateGaugeSubItem];
strWhereCond += string.Format(" And {0} {2} '{1}'", convSenateGaugeSubItems.IdSenateGaugeSubItem, objvSenateGaugeSubItemsCond.IdSenateGaugeSubItem, strComparisonOpIdSenateGaugeSubItem);
}
if (objvSenateGaugeSubItemsCond.IsUpdated(convSenateGaugeSubItems.senateGaugeSubItemID) == true)
{
string strComparisonOpsenateGaugeSubItemID = objvSenateGaugeSubItemsCond.dicFldComparisonOp[convSenateGaugeSubItems.senateGaugeSubItemID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convSenateGaugeSubItems.senateGaugeSubItemID, objvSenateGaugeSubItemsCond.senateGaugeSubItemID, strComparisonOpsenateGaugeSubItemID);
}
if (objvSenateGaugeSubItemsCond.IsUpdated(convSenateGaugeSubItems.senateGaugeSubItemName) == true)
{
string strComparisonOpsenateGaugeSubItemName = objvSenateGaugeSubItemsCond.dicFldComparisonOp[convSenateGaugeSubItems.senateGaugeSubItemName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convSenateGaugeSubItems.senateGaugeSubItemName, objvSenateGaugeSubItemsCond.senateGaugeSubItemName, strComparisonOpsenateGaugeSubItemName);
}
if (objvSenateGaugeSubItemsCond.IsUpdated(convSenateGaugeSubItems.IdSenateGaugeItem) == true)
{
string strComparisonOpIdSenateGaugeItem = objvSenateGaugeSubItemsCond.dicFldComparisonOp[convSenateGaugeSubItems.IdSenateGaugeItem];
strWhereCond += string.Format(" And {0} {2} '{1}'", convSenateGaugeSubItems.IdSenateGaugeItem, objvSenateGaugeSubItemsCond.IdSenateGaugeItem, strComparisonOpIdSenateGaugeItem);
}
if (objvSenateGaugeSubItemsCond.IsUpdated(convSenateGaugeSubItems.senateGaugeItemName) == true)
{
string strComparisonOpsenateGaugeItemName = objvSenateGaugeSubItemsCond.dicFldComparisonOp[convSenateGaugeSubItems.senateGaugeItemName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convSenateGaugeSubItems.senateGaugeItemName, objvSenateGaugeSubItemsCond.senateGaugeItemName, strComparisonOpsenateGaugeItemName);
}
if (objvSenateGaugeSubItemsCond.IsUpdated(convSenateGaugeSubItems.senateGaugeVersionName) == true)
{
string strComparisonOpsenateGaugeVersionName = objvSenateGaugeSubItemsCond.dicFldComparisonOp[convSenateGaugeSubItems.senateGaugeVersionName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convSenateGaugeSubItems.senateGaugeVersionName, objvSenateGaugeSubItemsCond.senateGaugeVersionName, strComparisonOpsenateGaugeVersionName);
}
if (objvSenateGaugeSubItemsCond.IsUpdated(convSenateGaugeSubItems.senateGaugeSubItemScore) == true)
{
string strComparisonOpsenateGaugeSubItemScore = objvSenateGaugeSubItemsCond.dicFldComparisonOp[convSenateGaugeSubItems.senateGaugeSubItemScore];
strWhereCond += string.Format(" And {0} {2} {1}", convSenateGaugeSubItems.senateGaugeSubItemScore, objvSenateGaugeSubItemsCond.senateGaugeSubItemScore, strComparisonOpsenateGaugeSubItemScore);
}
if (objvSenateGaugeSubItemsCond.IsUpdated(convSenateGaugeSubItems.IdSenateGaugeVersion) == true)
{
string strComparisonOpIdSenateGaugeVersion = objvSenateGaugeSubItemsCond.dicFldComparisonOp[convSenateGaugeSubItems.IdSenateGaugeVersion];
strWhereCond += string.Format(" And {0} {2} '{1}'", convSenateGaugeSubItems.IdSenateGaugeVersion, objvSenateGaugeSubItemsCond.IdSenateGaugeVersion, strComparisonOpIdSenateGaugeVersion);
}
if (objvSenateGaugeSubItemsCond.IsUpdated(convSenateGaugeSubItems.senateGaugeItemID) == true)
{
string strComparisonOpsenateGaugeItemID = objvSenateGaugeSubItemsCond.dicFldComparisonOp[convSenateGaugeSubItems.senateGaugeItemID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convSenateGaugeSubItems.senateGaugeItemID, objvSenateGaugeSubItemsCond.senateGaugeItemID, strComparisonOpsenateGaugeItemID);
}
if (objvSenateGaugeSubItemsCond.IsUpdated(convSenateGaugeSubItems.senateGaugeSubItemDesc) == true)
{
string strComparisonOpsenateGaugeSubItemDesc = objvSenateGaugeSubItemsCond.dicFldComparisonOp[convSenateGaugeSubItems.senateGaugeSubItemDesc];
strWhereCond += string.Format(" And {0} {2} '{1}'", convSenateGaugeSubItems.senateGaugeSubItemDesc, objvSenateGaugeSubItemsCond.senateGaugeSubItemDesc, strComparisonOpsenateGaugeSubItemDesc);
}
if (objvSenateGaugeSubItemsCond.IsUpdated(convSenateGaugeSubItems.AnswerTitle) == true)
{
string strComparisonOpAnswerTitle = objvSenateGaugeSubItemsCond.dicFldComparisonOp[convSenateGaugeSubItems.AnswerTitle];
strWhereCond += string.Format(" And {0} {2} '{1}'", convSenateGaugeSubItems.AnswerTitle, objvSenateGaugeSubItemsCond.AnswerTitle, strComparisonOpAnswerTitle);
}
if (objvSenateGaugeSubItemsCond.IsUpdated(convSenateGaugeSubItems.AnswerIndex) == true)
{
string strComparisonOpAnswerIndex = objvSenateGaugeSubItemsCond.dicFldComparisonOp[convSenateGaugeSubItems.AnswerIndex];
strWhereCond += string.Format(" And {0} {2} {1}", convSenateGaugeSubItems.AnswerIndex, objvSenateGaugeSubItemsCond.AnswerIndex, strComparisonOpAnswerIndex);
}
if (objvSenateGaugeSubItemsCond.IsUpdated(convSenateGaugeSubItems.senateGaugeItemDesc) == true)
{
string strComparisonOpsenateGaugeItemDesc = objvSenateGaugeSubItemsCond.dicFldComparisonOp[convSenateGaugeSubItems.senateGaugeItemDesc];
strWhereCond += string.Format(" And {0} {2} '{1}'", convSenateGaugeSubItems.senateGaugeItemDesc, objvSenateGaugeSubItemsCond.senateGaugeItemDesc, strComparisonOpsenateGaugeItemDesc);
}
if (objvSenateGaugeSubItemsCond.IsUpdated(convSenateGaugeSubItems.senateGaugeItemWeight) == true)
{
string strComparisonOpsenateGaugeItemWeight = objvSenateGaugeSubItemsCond.dicFldComparisonOp[convSenateGaugeSubItems.senateGaugeItemWeight];
strWhereCond += string.Format(" And {0} {2} {1}", convSenateGaugeSubItems.senateGaugeItemWeight, objvSenateGaugeSubItemsCond.senateGaugeItemWeight, strComparisonOpsenateGaugeItemWeight);
}
if (objvSenateGaugeSubItemsCond.IsUpdated(convSenateGaugeSubItems.senateGaugeSubItemMemo) == true)
{
string strComparisonOpsenateGaugeSubItemMemo = objvSenateGaugeSubItemsCond.dicFldComparisonOp[convSenateGaugeSubItems.senateGaugeSubItemMemo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convSenateGaugeSubItems.senateGaugeSubItemMemo, objvSenateGaugeSubItemsCond.senateGaugeSubItemMemo, strComparisonOpsenateGaugeSubItemMemo);
}
if (objvSenateGaugeSubItemsCond.IsUpdated(convSenateGaugeSubItems.senateGaugeItemMemo) == true)
{
string strComparisonOpsenateGaugeItemMemo = objvSenateGaugeSubItemsCond.dicFldComparisonOp[convSenateGaugeSubItems.senateGaugeItemMemo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convSenateGaugeSubItems.senateGaugeItemMemo, objvSenateGaugeSubItemsCond.senateGaugeItemMemo, strComparisonOpsenateGaugeItemMemo);
}
if (objvSenateGaugeSubItemsCond.IsUpdated(convSenateGaugeSubItems.senateGaugeVersionID) == true)
{
string strComparisonOpsenateGaugeVersionID = objvSenateGaugeSubItemsCond.dicFldComparisonOp[convSenateGaugeSubItems.senateGaugeVersionID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convSenateGaugeSubItems.senateGaugeVersionID, objvSenateGaugeSubItemsCond.senateGaugeVersionID, strComparisonOpsenateGaugeVersionID);
}
if (objvSenateGaugeSubItemsCond.IsUpdated(convSenateGaugeSubItems.senateGaugeVersionTtlScore) == true)
{
string strComparisonOpsenateGaugeVersionTtlScore = objvSenateGaugeSubItemsCond.dicFldComparisonOp[convSenateGaugeSubItems.senateGaugeVersionTtlScore];
strWhereCond += string.Format(" And {0} {2} {1}", convSenateGaugeSubItems.senateGaugeVersionTtlScore, objvSenateGaugeSubItemsCond.senateGaugeVersionTtlScore, strComparisonOpsenateGaugeVersionTtlScore);
}
if (objvSenateGaugeSubItemsCond.IsUpdated(convSenateGaugeSubItems.senateGaugeSubItemAll) == true)
{
string strComparisonOpsenateGaugeSubItemAll = objvSenateGaugeSubItemsCond.dicFldComparisonOp[convSenateGaugeSubItems.senateGaugeSubItemAll];
strWhereCond += string.Format(" And {0} {2} '{1}'", convSenateGaugeSubItems.senateGaugeSubItemAll, objvSenateGaugeSubItemsCond.senateGaugeSubItemAll, strComparisonOpsenateGaugeSubItemAll);
}
if (objvSenateGaugeSubItemsCond.IsUpdated(convSenateGaugeSubItems.senateGaugeSubItemAll2) == true)
{
string strComparisonOpsenateGaugeSubItemAll2 = objvSenateGaugeSubItemsCond.dicFldComparisonOp[convSenateGaugeSubItems.senateGaugeSubItemAll2];
strWhereCond += string.Format(" And {0} {2} '{1}'", convSenateGaugeSubItems.senateGaugeSubItemAll2, objvSenateGaugeSubItemsCond.senateGaugeSubItemAll2, strComparisonOpsenateGaugeSubItemAll2);
}
if (objvSenateGaugeSubItemsCond.IsUpdated(convSenateGaugeSubItems.VersionNo) == true)
{
string strComparisonOpVersionNo = objvSenateGaugeSubItemsCond.dicFldComparisonOp[convSenateGaugeSubItems.VersionNo];
strWhereCond += string.Format(" And {0} {2} {1}", convSenateGaugeSubItems.VersionNo, objvSenateGaugeSubItemsCond.VersionNo, strComparisonOpVersionNo);
}
if (objvSenateGaugeSubItemsCond.IsUpdated(convSenateGaugeSubItems.IsUse) == true)
{
if (objvSenateGaugeSubItemsCond.IsUse == true)
{
strWhereCond += string.Format(" And {0} = '1'", convSenateGaugeSubItems.IsUse);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convSenateGaugeSubItems.IsUse);
}
}
if (objvSenateGaugeSubItemsCond.IsUpdated(convSenateGaugeSubItems.UpdDate) == true)
{
string strComparisonOpUpdDate = objvSenateGaugeSubItemsCond.dicFldComparisonOp[convSenateGaugeSubItems.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convSenateGaugeSubItems.UpdDate, objvSenateGaugeSubItemsCond.UpdDate, strComparisonOpUpdDate);
}
if (objvSenateGaugeSubItemsCond.IsUpdated(convSenateGaugeSubItems.UpdUserId) == true)
{
string strComparisonOpUpdUserId = objvSenateGaugeSubItemsCond.dicFldComparisonOp[convSenateGaugeSubItems.UpdUserId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convSenateGaugeSubItems.UpdUserId, objvSenateGaugeSubItemsCond.UpdUserId, strComparisonOpUpdUserId);
}
if (objvSenateGaugeSubItemsCond.IsUpdated(convSenateGaugeSubItems.AnswerModeId) == true)
{
string strComparisonOpAnswerModeId = objvSenateGaugeSubItemsCond.dicFldComparisonOp[convSenateGaugeSubItems.AnswerModeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convSenateGaugeSubItems.AnswerModeId, objvSenateGaugeSubItemsCond.AnswerModeId, strComparisonOpAnswerModeId);
}
if (objvSenateGaugeSubItemsCond.IsUpdated(convSenateGaugeSubItems.AnswerModeName) == true)
{
string strComparisonOpAnswerModeName = objvSenateGaugeSubItemsCond.dicFldComparisonOp[convSenateGaugeSubItems.AnswerModeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convSenateGaugeSubItems.AnswerModeName, objvSenateGaugeSubItemsCond.AnswerModeName, strComparisonOpAnswerModeName);
}
if (objvSenateGaugeSubItemsCond.IsUpdated(convSenateGaugeSubItems.AnswerNum) == true)
{
string strComparisonOpAnswerNum = objvSenateGaugeSubItemsCond.dicFldComparisonOp[convSenateGaugeSubItems.AnswerNum];
strWhereCond += string.Format(" And {0} {2} {1}", convSenateGaugeSubItems.AnswerNum, objvSenateGaugeSubItemsCond.AnswerNum, strComparisonOpAnswerNum);
}
if (objvSenateGaugeSubItemsCond.IsUpdated(convSenateGaugeSubItems.AnswerTypeId) == true)
{
string strComparisonOpAnswerTypeId = objvSenateGaugeSubItemsCond.dicFldComparisonOp[convSenateGaugeSubItems.AnswerTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convSenateGaugeSubItems.AnswerTypeId, objvSenateGaugeSubItemsCond.AnswerTypeId, strComparisonOpAnswerTypeId);
}
if (objvSenateGaugeSubItemsCond.IsUpdated(convSenateGaugeSubItems.AnswerTypeName) == true)
{
string strComparisonOpAnswerTypeName = objvSenateGaugeSubItemsCond.dicFldComparisonOp[convSenateGaugeSubItems.AnswerTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convSenateGaugeSubItems.AnswerTypeName, objvSenateGaugeSubItemsCond.AnswerTypeName, strComparisonOpAnswerTypeName);
}
if (objvSenateGaugeSubItemsCond.IsUpdated(convSenateGaugeSubItems.GridTitle) == true)
{
string strComparisonOpGridTitle = objvSenateGaugeSubItemsCond.dicFldComparisonOp[convSenateGaugeSubItems.GridTitle];
strWhereCond += string.Format(" And {0} {2} '{1}'", convSenateGaugeSubItems.GridTitle, objvSenateGaugeSubItemsCond.GridTitle, strComparisonOpGridTitle);
}
if (objvSenateGaugeSubItemsCond.IsUpdated(convSenateGaugeSubItems.IsHaveAdditionalMemo) == true)
{
if (objvSenateGaugeSubItemsCond.IsHaveAdditionalMemo == true)
{
strWhereCond += string.Format(" And {0} = '1'", convSenateGaugeSubItems.IsHaveAdditionalMemo);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convSenateGaugeSubItems.IsHaveAdditionalMemo);
}
}
if (objvSenateGaugeSubItemsCond.IsUpdated(convSenateGaugeSubItems.QuestionIndex) == true)
{
string strComparisonOpQuestionIndex = objvSenateGaugeSubItemsCond.dicFldComparisonOp[convSenateGaugeSubItems.QuestionIndex];
strWhereCond += string.Format(" And {0} {2} {1}", convSenateGaugeSubItems.QuestionIndex, objvSenateGaugeSubItemsCond.QuestionIndex, strComparisonOpQuestionIndex);
}
if (objvSenateGaugeSubItemsCond.IsUpdated(convSenateGaugeSubItems.QuestionNo) == true)
{
string strComparisonOpQuestionNo = objvSenateGaugeSubItemsCond.dicFldComparisonOp[convSenateGaugeSubItems.QuestionNo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convSenateGaugeSubItems.QuestionNo, objvSenateGaugeSubItemsCond.QuestionNo, strComparisonOpQuestionNo);
}
if (objvSenateGaugeSubItemsCond.IsUpdated(convSenateGaugeSubItems.QuestionTypeId) == true)
{
string strComparisonOpQuestionTypeId = objvSenateGaugeSubItemsCond.dicFldComparisonOp[convSenateGaugeSubItems.QuestionTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convSenateGaugeSubItems.QuestionTypeId, objvSenateGaugeSubItemsCond.QuestionTypeId, strComparisonOpQuestionTypeId);
}
if (objvSenateGaugeSubItemsCond.IsUpdated(convSenateGaugeSubItems.QuestionTypeName) == true)
{
string strComparisonOpQuestionTypeName = objvSenateGaugeSubItemsCond.dicFldComparisonOp[convSenateGaugeSubItems.QuestionTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convSenateGaugeSubItems.QuestionTypeName, objvSenateGaugeSubItemsCond.QuestionTypeName, strComparisonOpQuestionTypeName);
}
if (objvSenateGaugeSubItemsCond.IsUpdated(convSenateGaugeSubItems.senateGaugeItemNameWithOrder) == true)
{
string strComparisonOpsenateGaugeItemNameWithOrder = objvSenateGaugeSubItemsCond.dicFldComparisonOp[convSenateGaugeSubItems.senateGaugeItemNameWithOrder];
strWhereCond += string.Format(" And {0} {2} '{1}'", convSenateGaugeSubItems.senateGaugeItemNameWithOrder, objvSenateGaugeSubItemsCond.senateGaugeItemNameWithOrder, strComparisonOpsenateGaugeItemNameWithOrder);
}
if (objvSenateGaugeSubItemsCond.IsUpdated(convSenateGaugeSubItems.senateGaugeVersionMemo) == true)
{
string strComparisonOpsenateGaugeVersionMemo = objvSenateGaugeSubItemsCond.dicFldComparisonOp[convSenateGaugeSubItems.senateGaugeVersionMemo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convSenateGaugeSubItems.senateGaugeVersionMemo, objvSenateGaugeSubItemsCond.senateGaugeVersionMemo, strComparisonOpsenateGaugeVersionMemo);
}
 return strWhereCond;
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_vSenateGaugeSubItems
{
public virtual bool UpdRelaTabDate(string strIdSenateGaugeSubItem, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// v量表指标子项(vSenateGaugeSubItems)
 /// 数据源类型:视图
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsvSenateGaugeSubItemsBL
{
public static RelatedActions_vSenateGaugeSubItems relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsvSenateGaugeSubItemsDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsvSenateGaugeSubItemsDA vSenateGaugeSubItemsDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsvSenateGaugeSubItemsDA();
}
return uniqueInstance;
}
}

 /// <summary>
 /// 类的构造函数
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ClassConstructor1)
 /// </summary>
 public clsvSenateGaugeSubItemsBL()
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
if (string.IsNullOrEmpty(clsvSenateGaugeSubItemsEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvSenateGaugeSubItemsEN._ConnectString);
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
public static DataTable GetDataTable_vSenateGaugeSubItems(string strWhereCond)
{
DataTable objDT;
try
{
objDT = vSenateGaugeSubItemsDA.GetDataTable_vSenateGaugeSubItems(strWhereCond);
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
objDT = vSenateGaugeSubItemsDA.GetDataTable(strWhereCond);
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
objDT = vSenateGaugeSubItemsDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = vSenateGaugeSubItemsDA.GetDataTable(strWhereCond, strTabName);
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
objDT = vSenateGaugeSubItemsDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = vSenateGaugeSubItemsDA.GetDataTable_Top(objTopPara);
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
objDT = vSenateGaugeSubItemsDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = vSenateGaugeSubItemsDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = vSenateGaugeSubItemsDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
 /// <param name = "arrIdSenateGaugeSubItemLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static List<clsvSenateGaugeSubItemsEN> GetObjLstByIdSenateGaugeSubItemLst(List<string> arrIdSenateGaugeSubItemLst)
{
List<clsvSenateGaugeSubItemsEN> arrObjLst = new List<clsvSenateGaugeSubItemsEN>(); 
System.Data.DataTable objDT; 
 string strSqlConditionStr = clsArray.GetSqlInStrByArray(arrIdSenateGaugeSubItemLst, true);
 string strWhereCond = string.Format("IdSenateGaugeSubItem in ({0})", strSqlConditionStr);
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvSenateGaugeSubItemsEN objvSenateGaugeSubItemsEN = new clsvSenateGaugeSubItemsEN();
try
{
objvSenateGaugeSubItemsEN.IdSenateGaugeSubItem = objRow[convSenateGaugeSubItems.IdSenateGaugeSubItem].ToString().Trim(); //量表指标子项流水号
objvSenateGaugeSubItemsEN.senateGaugeSubItemID = objRow[convSenateGaugeSubItems.senateGaugeSubItemID] == DBNull.Value ? null : objRow[convSenateGaugeSubItems.senateGaugeSubItemID].ToString().Trim(); //量表指标子项ID
objvSenateGaugeSubItemsEN.senateGaugeSubItemName = objRow[convSenateGaugeSubItems.senateGaugeSubItemName] == DBNull.Value ? null : objRow[convSenateGaugeSubItems.senateGaugeSubItemName].ToString().Trim(); //量表指标子项名称
objvSenateGaugeSubItemsEN.IdSenateGaugeItem = objRow[convSenateGaugeSubItems.IdSenateGaugeItem].ToString().Trim(); //量表指标流水号
objvSenateGaugeSubItemsEN.senateGaugeItemName = objRow[convSenateGaugeSubItems.senateGaugeItemName] == DBNull.Value ? null : objRow[convSenateGaugeSubItems.senateGaugeItemName].ToString().Trim(); //量表指标名称
objvSenateGaugeSubItemsEN.senateGaugeVersionName = objRow[convSenateGaugeSubItems.senateGaugeVersionName] == DBNull.Value ? null : objRow[convSenateGaugeSubItems.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称
objvSenateGaugeSubItemsEN.senateGaugeSubItemScore = objRow[convSenateGaugeSubItems.senateGaugeSubItemScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convSenateGaugeSubItems.senateGaugeSubItemScore].ToString().Trim()); //量表指标子项分数
objvSenateGaugeSubItemsEN.IdSenateGaugeVersion = objRow[convSenateGaugeSubItems.IdSenateGaugeVersion].ToString().Trim(); //评价量表版本流水号
objvSenateGaugeSubItemsEN.senateGaugeItemID = objRow[convSenateGaugeSubItems.senateGaugeItemID] == DBNull.Value ? null : objRow[convSenateGaugeSubItems.senateGaugeItemID].ToString().Trim(); //量表指标ID
objvSenateGaugeSubItemsEN.senateGaugeSubItemDesc = objRow[convSenateGaugeSubItems.senateGaugeSubItemDesc] == DBNull.Value ? null : objRow[convSenateGaugeSubItems.senateGaugeSubItemDesc].ToString().Trim(); //量表指标子项说明
objvSenateGaugeSubItemsEN.AnswerTitle = objRow[convSenateGaugeSubItems.AnswerTitle] == DBNull.Value ? null : objRow[convSenateGaugeSubItems.AnswerTitle].ToString().Trim(); //答案标题
objvSenateGaugeSubItemsEN.AnswerIndex = objRow[convSenateGaugeSubItems.AnswerIndex] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convSenateGaugeSubItems.AnswerIndex].ToString().Trim()); //问答序号
objvSenateGaugeSubItemsEN.senateGaugeItemDesc = objRow[convSenateGaugeSubItems.senateGaugeItemDesc] == DBNull.Value ? null : objRow[convSenateGaugeSubItems.senateGaugeItemDesc].ToString().Trim(); //量表指标说明
objvSenateGaugeSubItemsEN.senateGaugeItemWeight = objRow[convSenateGaugeSubItems.senateGaugeItemWeight] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convSenateGaugeSubItems.senateGaugeItemWeight].ToString().Trim()); //量表指标权重
objvSenateGaugeSubItemsEN.senateGaugeSubItemMemo = objRow[convSenateGaugeSubItems.senateGaugeSubItemMemo] == DBNull.Value ? null : objRow[convSenateGaugeSubItems.senateGaugeSubItemMemo].ToString().Trim(); //量表指标子项备注
objvSenateGaugeSubItemsEN.senateGaugeItemMemo = objRow[convSenateGaugeSubItems.senateGaugeItemMemo] == DBNull.Value ? null : objRow[convSenateGaugeSubItems.senateGaugeItemMemo].ToString().Trim(); //备注
objvSenateGaugeSubItemsEN.senateGaugeVersionID = objRow[convSenateGaugeSubItems.senateGaugeVersionID].ToString().Trim(); //评价量表版本ID
objvSenateGaugeSubItemsEN.senateGaugeVersionTtlScore = Single.Parse(objRow[convSenateGaugeSubItems.senateGaugeVersionTtlScore].ToString().Trim()); //评价量表版本总分
objvSenateGaugeSubItemsEN.senateGaugeSubItemAll = objRow[convSenateGaugeSubItems.senateGaugeSubItemAll] == DBNull.Value ? null : objRow[convSenateGaugeSubItems.senateGaugeSubItemAll].ToString().Trim(); //子项等地分数
objvSenateGaugeSubItemsEN.senateGaugeSubItemAll2 = objRow[convSenateGaugeSubItems.senateGaugeSubItemAll2] == DBNull.Value ? null : objRow[convSenateGaugeSubItems.senateGaugeSubItemAll2].ToString().Trim(); //senateGaugeSubItemAll2
objvSenateGaugeSubItemsEN.VersionNo = objRow[convSenateGaugeSubItems.VersionNo] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convSenateGaugeSubItems.VersionNo].ToString().Trim()); //版本号
objvSenateGaugeSubItemsEN.IsUse = clsEntityBase2.TransNullToBool_S(objRow[convSenateGaugeSubItems.IsUse].ToString().Trim()); //是否使用
objvSenateGaugeSubItemsEN.UpdDate = objRow[convSenateGaugeSubItems.UpdDate] == DBNull.Value ? null : objRow[convSenateGaugeSubItems.UpdDate].ToString().Trim(); //修改日期
objvSenateGaugeSubItemsEN.UpdUserId = objRow[convSenateGaugeSubItems.UpdUserId] == DBNull.Value ? null : objRow[convSenateGaugeSubItems.UpdUserId].ToString().Trim(); //修改用户Id
objvSenateGaugeSubItemsEN.AnswerModeId = objRow[convSenateGaugeSubItems.AnswerModeId] == DBNull.Value ? null : objRow[convSenateGaugeSubItems.AnswerModeId].ToString().Trim(); //答案模式Id
objvSenateGaugeSubItemsEN.AnswerModeName = objRow[convSenateGaugeSubItems.AnswerModeName] == DBNull.Value ? null : objRow[convSenateGaugeSubItems.AnswerModeName].ToString().Trim(); //答案模式名称
objvSenateGaugeSubItemsEN.AnswerNum = objRow[convSenateGaugeSubItems.AnswerNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convSenateGaugeSubItems.AnswerNum].ToString().Trim()); //答案数
objvSenateGaugeSubItemsEN.AnswerTypeId = objRow[convSenateGaugeSubItems.AnswerTypeId] == DBNull.Value ? null : objRow[convSenateGaugeSubItems.AnswerTypeId].ToString().Trim(); //答案类型ID
objvSenateGaugeSubItemsEN.AnswerTypeName = objRow[convSenateGaugeSubItems.AnswerTypeName] == DBNull.Value ? null : objRow[convSenateGaugeSubItems.AnswerTypeName].ToString().Trim(); //答案类型名
objvSenateGaugeSubItemsEN.GridTitle = objRow[convSenateGaugeSubItems.GridTitle] == DBNull.Value ? null : objRow[convSenateGaugeSubItems.GridTitle].ToString().Trim(); //表格标题
objvSenateGaugeSubItemsEN.IsHaveAdditionalMemo = clsEntityBase2.TransNullToBool_S(objRow[convSenateGaugeSubItems.IsHaveAdditionalMemo].ToString().Trim()); //是否有附加说明
objvSenateGaugeSubItemsEN.QuestionIndex = objRow[convSenateGaugeSubItems.QuestionIndex] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convSenateGaugeSubItems.QuestionIndex].ToString().Trim()); //题目序号
objvSenateGaugeSubItemsEN.QuestionNo = objRow[convSenateGaugeSubItems.QuestionNo] == DBNull.Value ? null : objRow[convSenateGaugeSubItems.QuestionNo].ToString().Trim(); //题目编号
objvSenateGaugeSubItemsEN.QuestionTypeId = objRow[convSenateGaugeSubItems.QuestionTypeId] == DBNull.Value ? null : objRow[convSenateGaugeSubItems.QuestionTypeId].ToString().Trim(); //题目类型Id
objvSenateGaugeSubItemsEN.QuestionTypeName = objRow[convSenateGaugeSubItems.QuestionTypeName] == DBNull.Value ? null : objRow[convSenateGaugeSubItems.QuestionTypeName].ToString().Trim(); //题目类型名
objvSenateGaugeSubItemsEN.senateGaugeItemNameWithOrder = objRow[convSenateGaugeSubItems.senateGaugeItemNameWithOrder] == DBNull.Value ? null : objRow[convSenateGaugeSubItems.senateGaugeItemNameWithOrder].ToString().Trim(); //量表指标名称WithOrder
objvSenateGaugeSubItemsEN.senateGaugeVersionMemo = objRow[convSenateGaugeSubItems.senateGaugeVersionMemo] == DBNull.Value ? null : objRow[convSenateGaugeSubItems.senateGaugeVersionMemo].ToString().Trim(); //评价量表版本说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvSenateGaugeSubItemsEN.IdSenateGaugeSubItem, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvSenateGaugeSubItemsEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrIdSenateGaugeSubItemLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsvSenateGaugeSubItemsEN> GetObjLstByIdSenateGaugeSubItemLstCache(List<string> arrIdSenateGaugeSubItemLst)
{
string strKey = string.Format("{0}", clsvSenateGaugeSubItemsEN._CurrTabName);
List<clsvSenateGaugeSubItemsEN> arrvSenateGaugeSubItemsObjLstCache = GetObjLstCache();
IEnumerable <clsvSenateGaugeSubItemsEN> arrvSenateGaugeSubItemsObjLst_Sel =
arrvSenateGaugeSubItemsObjLstCache
.Where(x => arrIdSenateGaugeSubItemLst.Contains(x.IdSenateGaugeSubItem));
return arrvSenateGaugeSubItemsObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvSenateGaugeSubItemsEN> GetObjLst(string strWhereCond)
{
List<clsvSenateGaugeSubItemsEN> arrObjLst = new List<clsvSenateGaugeSubItemsEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvSenateGaugeSubItemsEN objvSenateGaugeSubItemsEN = new clsvSenateGaugeSubItemsEN();
try
{
objvSenateGaugeSubItemsEN.IdSenateGaugeSubItem = objRow[convSenateGaugeSubItems.IdSenateGaugeSubItem].ToString().Trim(); //量表指标子项流水号
objvSenateGaugeSubItemsEN.senateGaugeSubItemID = objRow[convSenateGaugeSubItems.senateGaugeSubItemID] == DBNull.Value ? null : objRow[convSenateGaugeSubItems.senateGaugeSubItemID].ToString().Trim(); //量表指标子项ID
objvSenateGaugeSubItemsEN.senateGaugeSubItemName = objRow[convSenateGaugeSubItems.senateGaugeSubItemName] == DBNull.Value ? null : objRow[convSenateGaugeSubItems.senateGaugeSubItemName].ToString().Trim(); //量表指标子项名称
objvSenateGaugeSubItemsEN.IdSenateGaugeItem = objRow[convSenateGaugeSubItems.IdSenateGaugeItem].ToString().Trim(); //量表指标流水号
objvSenateGaugeSubItemsEN.senateGaugeItemName = objRow[convSenateGaugeSubItems.senateGaugeItemName] == DBNull.Value ? null : objRow[convSenateGaugeSubItems.senateGaugeItemName].ToString().Trim(); //量表指标名称
objvSenateGaugeSubItemsEN.senateGaugeVersionName = objRow[convSenateGaugeSubItems.senateGaugeVersionName] == DBNull.Value ? null : objRow[convSenateGaugeSubItems.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称
objvSenateGaugeSubItemsEN.senateGaugeSubItemScore = objRow[convSenateGaugeSubItems.senateGaugeSubItemScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convSenateGaugeSubItems.senateGaugeSubItemScore].ToString().Trim()); //量表指标子项分数
objvSenateGaugeSubItemsEN.IdSenateGaugeVersion = objRow[convSenateGaugeSubItems.IdSenateGaugeVersion].ToString().Trim(); //评价量表版本流水号
objvSenateGaugeSubItemsEN.senateGaugeItemID = objRow[convSenateGaugeSubItems.senateGaugeItemID] == DBNull.Value ? null : objRow[convSenateGaugeSubItems.senateGaugeItemID].ToString().Trim(); //量表指标ID
objvSenateGaugeSubItemsEN.senateGaugeSubItemDesc = objRow[convSenateGaugeSubItems.senateGaugeSubItemDesc] == DBNull.Value ? null : objRow[convSenateGaugeSubItems.senateGaugeSubItemDesc].ToString().Trim(); //量表指标子项说明
objvSenateGaugeSubItemsEN.AnswerTitle = objRow[convSenateGaugeSubItems.AnswerTitle] == DBNull.Value ? null : objRow[convSenateGaugeSubItems.AnswerTitle].ToString().Trim(); //答案标题
objvSenateGaugeSubItemsEN.AnswerIndex = objRow[convSenateGaugeSubItems.AnswerIndex] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convSenateGaugeSubItems.AnswerIndex].ToString().Trim()); //问答序号
objvSenateGaugeSubItemsEN.senateGaugeItemDesc = objRow[convSenateGaugeSubItems.senateGaugeItemDesc] == DBNull.Value ? null : objRow[convSenateGaugeSubItems.senateGaugeItemDesc].ToString().Trim(); //量表指标说明
objvSenateGaugeSubItemsEN.senateGaugeItemWeight = objRow[convSenateGaugeSubItems.senateGaugeItemWeight] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convSenateGaugeSubItems.senateGaugeItemWeight].ToString().Trim()); //量表指标权重
objvSenateGaugeSubItemsEN.senateGaugeSubItemMemo = objRow[convSenateGaugeSubItems.senateGaugeSubItemMemo] == DBNull.Value ? null : objRow[convSenateGaugeSubItems.senateGaugeSubItemMemo].ToString().Trim(); //量表指标子项备注
objvSenateGaugeSubItemsEN.senateGaugeItemMemo = objRow[convSenateGaugeSubItems.senateGaugeItemMemo] == DBNull.Value ? null : objRow[convSenateGaugeSubItems.senateGaugeItemMemo].ToString().Trim(); //备注
objvSenateGaugeSubItemsEN.senateGaugeVersionID = objRow[convSenateGaugeSubItems.senateGaugeVersionID].ToString().Trim(); //评价量表版本ID
objvSenateGaugeSubItemsEN.senateGaugeVersionTtlScore = Single.Parse(objRow[convSenateGaugeSubItems.senateGaugeVersionTtlScore].ToString().Trim()); //评价量表版本总分
objvSenateGaugeSubItemsEN.senateGaugeSubItemAll = objRow[convSenateGaugeSubItems.senateGaugeSubItemAll] == DBNull.Value ? null : objRow[convSenateGaugeSubItems.senateGaugeSubItemAll].ToString().Trim(); //子项等地分数
objvSenateGaugeSubItemsEN.senateGaugeSubItemAll2 = objRow[convSenateGaugeSubItems.senateGaugeSubItemAll2] == DBNull.Value ? null : objRow[convSenateGaugeSubItems.senateGaugeSubItemAll2].ToString().Trim(); //senateGaugeSubItemAll2
objvSenateGaugeSubItemsEN.VersionNo = objRow[convSenateGaugeSubItems.VersionNo] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convSenateGaugeSubItems.VersionNo].ToString().Trim()); //版本号
objvSenateGaugeSubItemsEN.IsUse = clsEntityBase2.TransNullToBool_S(objRow[convSenateGaugeSubItems.IsUse].ToString().Trim()); //是否使用
objvSenateGaugeSubItemsEN.UpdDate = objRow[convSenateGaugeSubItems.UpdDate] == DBNull.Value ? null : objRow[convSenateGaugeSubItems.UpdDate].ToString().Trim(); //修改日期
objvSenateGaugeSubItemsEN.UpdUserId = objRow[convSenateGaugeSubItems.UpdUserId] == DBNull.Value ? null : objRow[convSenateGaugeSubItems.UpdUserId].ToString().Trim(); //修改用户Id
objvSenateGaugeSubItemsEN.AnswerModeId = objRow[convSenateGaugeSubItems.AnswerModeId] == DBNull.Value ? null : objRow[convSenateGaugeSubItems.AnswerModeId].ToString().Trim(); //答案模式Id
objvSenateGaugeSubItemsEN.AnswerModeName = objRow[convSenateGaugeSubItems.AnswerModeName] == DBNull.Value ? null : objRow[convSenateGaugeSubItems.AnswerModeName].ToString().Trim(); //答案模式名称
objvSenateGaugeSubItemsEN.AnswerNum = objRow[convSenateGaugeSubItems.AnswerNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convSenateGaugeSubItems.AnswerNum].ToString().Trim()); //答案数
objvSenateGaugeSubItemsEN.AnswerTypeId = objRow[convSenateGaugeSubItems.AnswerTypeId] == DBNull.Value ? null : objRow[convSenateGaugeSubItems.AnswerTypeId].ToString().Trim(); //答案类型ID
objvSenateGaugeSubItemsEN.AnswerTypeName = objRow[convSenateGaugeSubItems.AnswerTypeName] == DBNull.Value ? null : objRow[convSenateGaugeSubItems.AnswerTypeName].ToString().Trim(); //答案类型名
objvSenateGaugeSubItemsEN.GridTitle = objRow[convSenateGaugeSubItems.GridTitle] == DBNull.Value ? null : objRow[convSenateGaugeSubItems.GridTitle].ToString().Trim(); //表格标题
objvSenateGaugeSubItemsEN.IsHaveAdditionalMemo = clsEntityBase2.TransNullToBool_S(objRow[convSenateGaugeSubItems.IsHaveAdditionalMemo].ToString().Trim()); //是否有附加说明
objvSenateGaugeSubItemsEN.QuestionIndex = objRow[convSenateGaugeSubItems.QuestionIndex] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convSenateGaugeSubItems.QuestionIndex].ToString().Trim()); //题目序号
objvSenateGaugeSubItemsEN.QuestionNo = objRow[convSenateGaugeSubItems.QuestionNo] == DBNull.Value ? null : objRow[convSenateGaugeSubItems.QuestionNo].ToString().Trim(); //题目编号
objvSenateGaugeSubItemsEN.QuestionTypeId = objRow[convSenateGaugeSubItems.QuestionTypeId] == DBNull.Value ? null : objRow[convSenateGaugeSubItems.QuestionTypeId].ToString().Trim(); //题目类型Id
objvSenateGaugeSubItemsEN.QuestionTypeName = objRow[convSenateGaugeSubItems.QuestionTypeName] == DBNull.Value ? null : objRow[convSenateGaugeSubItems.QuestionTypeName].ToString().Trim(); //题目类型名
objvSenateGaugeSubItemsEN.senateGaugeItemNameWithOrder = objRow[convSenateGaugeSubItems.senateGaugeItemNameWithOrder] == DBNull.Value ? null : objRow[convSenateGaugeSubItems.senateGaugeItemNameWithOrder].ToString().Trim(); //量表指标名称WithOrder
objvSenateGaugeSubItemsEN.senateGaugeVersionMemo = objRow[convSenateGaugeSubItems.senateGaugeVersionMemo] == DBNull.Value ? null : objRow[convSenateGaugeSubItems.senateGaugeVersionMemo].ToString().Trim(); //评价量表版本说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvSenateGaugeSubItemsEN.IdSenateGaugeSubItem, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvSenateGaugeSubItemsEN);
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
public static List<clsvSenateGaugeSubItemsEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsvSenateGaugeSubItemsEN> arrObjLst = new List<clsvSenateGaugeSubItemsEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvSenateGaugeSubItemsEN objvSenateGaugeSubItemsEN = new clsvSenateGaugeSubItemsEN();
try
{
objvSenateGaugeSubItemsEN.IdSenateGaugeSubItem = objRow[convSenateGaugeSubItems.IdSenateGaugeSubItem].ToString().Trim(); //量表指标子项流水号
objvSenateGaugeSubItemsEN.senateGaugeSubItemID = objRow[convSenateGaugeSubItems.senateGaugeSubItemID] == DBNull.Value ? null : objRow[convSenateGaugeSubItems.senateGaugeSubItemID].ToString().Trim(); //量表指标子项ID
objvSenateGaugeSubItemsEN.senateGaugeSubItemName = objRow[convSenateGaugeSubItems.senateGaugeSubItemName] == DBNull.Value ? null : objRow[convSenateGaugeSubItems.senateGaugeSubItemName].ToString().Trim(); //量表指标子项名称
objvSenateGaugeSubItemsEN.IdSenateGaugeItem = objRow[convSenateGaugeSubItems.IdSenateGaugeItem].ToString().Trim(); //量表指标流水号
objvSenateGaugeSubItemsEN.senateGaugeItemName = objRow[convSenateGaugeSubItems.senateGaugeItemName] == DBNull.Value ? null : objRow[convSenateGaugeSubItems.senateGaugeItemName].ToString().Trim(); //量表指标名称
objvSenateGaugeSubItemsEN.senateGaugeVersionName = objRow[convSenateGaugeSubItems.senateGaugeVersionName] == DBNull.Value ? null : objRow[convSenateGaugeSubItems.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称
objvSenateGaugeSubItemsEN.senateGaugeSubItemScore = objRow[convSenateGaugeSubItems.senateGaugeSubItemScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convSenateGaugeSubItems.senateGaugeSubItemScore].ToString().Trim()); //量表指标子项分数
objvSenateGaugeSubItemsEN.IdSenateGaugeVersion = objRow[convSenateGaugeSubItems.IdSenateGaugeVersion].ToString().Trim(); //评价量表版本流水号
objvSenateGaugeSubItemsEN.senateGaugeItemID = objRow[convSenateGaugeSubItems.senateGaugeItemID] == DBNull.Value ? null : objRow[convSenateGaugeSubItems.senateGaugeItemID].ToString().Trim(); //量表指标ID
objvSenateGaugeSubItemsEN.senateGaugeSubItemDesc = objRow[convSenateGaugeSubItems.senateGaugeSubItemDesc] == DBNull.Value ? null : objRow[convSenateGaugeSubItems.senateGaugeSubItemDesc].ToString().Trim(); //量表指标子项说明
objvSenateGaugeSubItemsEN.AnswerTitle = objRow[convSenateGaugeSubItems.AnswerTitle] == DBNull.Value ? null : objRow[convSenateGaugeSubItems.AnswerTitle].ToString().Trim(); //答案标题
objvSenateGaugeSubItemsEN.AnswerIndex = objRow[convSenateGaugeSubItems.AnswerIndex] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convSenateGaugeSubItems.AnswerIndex].ToString().Trim()); //问答序号
objvSenateGaugeSubItemsEN.senateGaugeItemDesc = objRow[convSenateGaugeSubItems.senateGaugeItemDesc] == DBNull.Value ? null : objRow[convSenateGaugeSubItems.senateGaugeItemDesc].ToString().Trim(); //量表指标说明
objvSenateGaugeSubItemsEN.senateGaugeItemWeight = objRow[convSenateGaugeSubItems.senateGaugeItemWeight] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convSenateGaugeSubItems.senateGaugeItemWeight].ToString().Trim()); //量表指标权重
objvSenateGaugeSubItemsEN.senateGaugeSubItemMemo = objRow[convSenateGaugeSubItems.senateGaugeSubItemMemo] == DBNull.Value ? null : objRow[convSenateGaugeSubItems.senateGaugeSubItemMemo].ToString().Trim(); //量表指标子项备注
objvSenateGaugeSubItemsEN.senateGaugeItemMemo = objRow[convSenateGaugeSubItems.senateGaugeItemMemo] == DBNull.Value ? null : objRow[convSenateGaugeSubItems.senateGaugeItemMemo].ToString().Trim(); //备注
objvSenateGaugeSubItemsEN.senateGaugeVersionID = objRow[convSenateGaugeSubItems.senateGaugeVersionID].ToString().Trim(); //评价量表版本ID
objvSenateGaugeSubItemsEN.senateGaugeVersionTtlScore = Single.Parse(objRow[convSenateGaugeSubItems.senateGaugeVersionTtlScore].ToString().Trim()); //评价量表版本总分
objvSenateGaugeSubItemsEN.senateGaugeSubItemAll = objRow[convSenateGaugeSubItems.senateGaugeSubItemAll] == DBNull.Value ? null : objRow[convSenateGaugeSubItems.senateGaugeSubItemAll].ToString().Trim(); //子项等地分数
objvSenateGaugeSubItemsEN.senateGaugeSubItemAll2 = objRow[convSenateGaugeSubItems.senateGaugeSubItemAll2] == DBNull.Value ? null : objRow[convSenateGaugeSubItems.senateGaugeSubItemAll2].ToString().Trim(); //senateGaugeSubItemAll2
objvSenateGaugeSubItemsEN.VersionNo = objRow[convSenateGaugeSubItems.VersionNo] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convSenateGaugeSubItems.VersionNo].ToString().Trim()); //版本号
objvSenateGaugeSubItemsEN.IsUse = clsEntityBase2.TransNullToBool_S(objRow[convSenateGaugeSubItems.IsUse].ToString().Trim()); //是否使用
objvSenateGaugeSubItemsEN.UpdDate = objRow[convSenateGaugeSubItems.UpdDate] == DBNull.Value ? null : objRow[convSenateGaugeSubItems.UpdDate].ToString().Trim(); //修改日期
objvSenateGaugeSubItemsEN.UpdUserId = objRow[convSenateGaugeSubItems.UpdUserId] == DBNull.Value ? null : objRow[convSenateGaugeSubItems.UpdUserId].ToString().Trim(); //修改用户Id
objvSenateGaugeSubItemsEN.AnswerModeId = objRow[convSenateGaugeSubItems.AnswerModeId] == DBNull.Value ? null : objRow[convSenateGaugeSubItems.AnswerModeId].ToString().Trim(); //答案模式Id
objvSenateGaugeSubItemsEN.AnswerModeName = objRow[convSenateGaugeSubItems.AnswerModeName] == DBNull.Value ? null : objRow[convSenateGaugeSubItems.AnswerModeName].ToString().Trim(); //答案模式名称
objvSenateGaugeSubItemsEN.AnswerNum = objRow[convSenateGaugeSubItems.AnswerNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convSenateGaugeSubItems.AnswerNum].ToString().Trim()); //答案数
objvSenateGaugeSubItemsEN.AnswerTypeId = objRow[convSenateGaugeSubItems.AnswerTypeId] == DBNull.Value ? null : objRow[convSenateGaugeSubItems.AnswerTypeId].ToString().Trim(); //答案类型ID
objvSenateGaugeSubItemsEN.AnswerTypeName = objRow[convSenateGaugeSubItems.AnswerTypeName] == DBNull.Value ? null : objRow[convSenateGaugeSubItems.AnswerTypeName].ToString().Trim(); //答案类型名
objvSenateGaugeSubItemsEN.GridTitle = objRow[convSenateGaugeSubItems.GridTitle] == DBNull.Value ? null : objRow[convSenateGaugeSubItems.GridTitle].ToString().Trim(); //表格标题
objvSenateGaugeSubItemsEN.IsHaveAdditionalMemo = clsEntityBase2.TransNullToBool_S(objRow[convSenateGaugeSubItems.IsHaveAdditionalMemo].ToString().Trim()); //是否有附加说明
objvSenateGaugeSubItemsEN.QuestionIndex = objRow[convSenateGaugeSubItems.QuestionIndex] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convSenateGaugeSubItems.QuestionIndex].ToString().Trim()); //题目序号
objvSenateGaugeSubItemsEN.QuestionNo = objRow[convSenateGaugeSubItems.QuestionNo] == DBNull.Value ? null : objRow[convSenateGaugeSubItems.QuestionNo].ToString().Trim(); //题目编号
objvSenateGaugeSubItemsEN.QuestionTypeId = objRow[convSenateGaugeSubItems.QuestionTypeId] == DBNull.Value ? null : objRow[convSenateGaugeSubItems.QuestionTypeId].ToString().Trim(); //题目类型Id
objvSenateGaugeSubItemsEN.QuestionTypeName = objRow[convSenateGaugeSubItems.QuestionTypeName] == DBNull.Value ? null : objRow[convSenateGaugeSubItems.QuestionTypeName].ToString().Trim(); //题目类型名
objvSenateGaugeSubItemsEN.senateGaugeItemNameWithOrder = objRow[convSenateGaugeSubItems.senateGaugeItemNameWithOrder] == DBNull.Value ? null : objRow[convSenateGaugeSubItems.senateGaugeItemNameWithOrder].ToString().Trim(); //量表指标名称WithOrder
objvSenateGaugeSubItemsEN.senateGaugeVersionMemo = objRow[convSenateGaugeSubItems.senateGaugeVersionMemo] == DBNull.Value ? null : objRow[convSenateGaugeSubItems.senateGaugeVersionMemo].ToString().Trim(); //评价量表版本说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvSenateGaugeSubItemsEN.IdSenateGaugeSubItem, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvSenateGaugeSubItemsEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objvSenateGaugeSubItemsCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsvSenateGaugeSubItemsEN> GetSubObjLstCache(clsvSenateGaugeSubItemsEN objvSenateGaugeSubItemsCond)
{
List<clsvSenateGaugeSubItemsEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsvSenateGaugeSubItemsEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convSenateGaugeSubItems.AttributeName)
{
if (objvSenateGaugeSubItemsCond.IsUpdated(strFldName) == false) continue;
if (objvSenateGaugeSubItemsCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvSenateGaugeSubItemsCond[strFldName].ToString());
}
else
{
if (objvSenateGaugeSubItemsCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvSenateGaugeSubItemsCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvSenateGaugeSubItemsCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvSenateGaugeSubItemsCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvSenateGaugeSubItemsCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvSenateGaugeSubItemsCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvSenateGaugeSubItemsCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvSenateGaugeSubItemsCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvSenateGaugeSubItemsCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvSenateGaugeSubItemsCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvSenateGaugeSubItemsCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvSenateGaugeSubItemsCond[strFldName]));
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
public static List<clsvSenateGaugeSubItemsEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsvSenateGaugeSubItemsEN> arrObjLst = new List<clsvSenateGaugeSubItemsEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvSenateGaugeSubItemsEN objvSenateGaugeSubItemsEN = new clsvSenateGaugeSubItemsEN();
try
{
objvSenateGaugeSubItemsEN.IdSenateGaugeSubItem = objRow[convSenateGaugeSubItems.IdSenateGaugeSubItem].ToString().Trim(); //量表指标子项流水号
objvSenateGaugeSubItemsEN.senateGaugeSubItemID = objRow[convSenateGaugeSubItems.senateGaugeSubItemID] == DBNull.Value ? null : objRow[convSenateGaugeSubItems.senateGaugeSubItemID].ToString().Trim(); //量表指标子项ID
objvSenateGaugeSubItemsEN.senateGaugeSubItemName = objRow[convSenateGaugeSubItems.senateGaugeSubItemName] == DBNull.Value ? null : objRow[convSenateGaugeSubItems.senateGaugeSubItemName].ToString().Trim(); //量表指标子项名称
objvSenateGaugeSubItemsEN.IdSenateGaugeItem = objRow[convSenateGaugeSubItems.IdSenateGaugeItem].ToString().Trim(); //量表指标流水号
objvSenateGaugeSubItemsEN.senateGaugeItemName = objRow[convSenateGaugeSubItems.senateGaugeItemName] == DBNull.Value ? null : objRow[convSenateGaugeSubItems.senateGaugeItemName].ToString().Trim(); //量表指标名称
objvSenateGaugeSubItemsEN.senateGaugeVersionName = objRow[convSenateGaugeSubItems.senateGaugeVersionName] == DBNull.Value ? null : objRow[convSenateGaugeSubItems.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称
objvSenateGaugeSubItemsEN.senateGaugeSubItemScore = objRow[convSenateGaugeSubItems.senateGaugeSubItemScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convSenateGaugeSubItems.senateGaugeSubItemScore].ToString().Trim()); //量表指标子项分数
objvSenateGaugeSubItemsEN.IdSenateGaugeVersion = objRow[convSenateGaugeSubItems.IdSenateGaugeVersion].ToString().Trim(); //评价量表版本流水号
objvSenateGaugeSubItemsEN.senateGaugeItemID = objRow[convSenateGaugeSubItems.senateGaugeItemID] == DBNull.Value ? null : objRow[convSenateGaugeSubItems.senateGaugeItemID].ToString().Trim(); //量表指标ID
objvSenateGaugeSubItemsEN.senateGaugeSubItemDesc = objRow[convSenateGaugeSubItems.senateGaugeSubItemDesc] == DBNull.Value ? null : objRow[convSenateGaugeSubItems.senateGaugeSubItemDesc].ToString().Trim(); //量表指标子项说明
objvSenateGaugeSubItemsEN.AnswerTitle = objRow[convSenateGaugeSubItems.AnswerTitle] == DBNull.Value ? null : objRow[convSenateGaugeSubItems.AnswerTitle].ToString().Trim(); //答案标题
objvSenateGaugeSubItemsEN.AnswerIndex = objRow[convSenateGaugeSubItems.AnswerIndex] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convSenateGaugeSubItems.AnswerIndex].ToString().Trim()); //问答序号
objvSenateGaugeSubItemsEN.senateGaugeItemDesc = objRow[convSenateGaugeSubItems.senateGaugeItemDesc] == DBNull.Value ? null : objRow[convSenateGaugeSubItems.senateGaugeItemDesc].ToString().Trim(); //量表指标说明
objvSenateGaugeSubItemsEN.senateGaugeItemWeight = objRow[convSenateGaugeSubItems.senateGaugeItemWeight] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convSenateGaugeSubItems.senateGaugeItemWeight].ToString().Trim()); //量表指标权重
objvSenateGaugeSubItemsEN.senateGaugeSubItemMemo = objRow[convSenateGaugeSubItems.senateGaugeSubItemMemo] == DBNull.Value ? null : objRow[convSenateGaugeSubItems.senateGaugeSubItemMemo].ToString().Trim(); //量表指标子项备注
objvSenateGaugeSubItemsEN.senateGaugeItemMemo = objRow[convSenateGaugeSubItems.senateGaugeItemMemo] == DBNull.Value ? null : objRow[convSenateGaugeSubItems.senateGaugeItemMemo].ToString().Trim(); //备注
objvSenateGaugeSubItemsEN.senateGaugeVersionID = objRow[convSenateGaugeSubItems.senateGaugeVersionID].ToString().Trim(); //评价量表版本ID
objvSenateGaugeSubItemsEN.senateGaugeVersionTtlScore = Single.Parse(objRow[convSenateGaugeSubItems.senateGaugeVersionTtlScore].ToString().Trim()); //评价量表版本总分
objvSenateGaugeSubItemsEN.senateGaugeSubItemAll = objRow[convSenateGaugeSubItems.senateGaugeSubItemAll] == DBNull.Value ? null : objRow[convSenateGaugeSubItems.senateGaugeSubItemAll].ToString().Trim(); //子项等地分数
objvSenateGaugeSubItemsEN.senateGaugeSubItemAll2 = objRow[convSenateGaugeSubItems.senateGaugeSubItemAll2] == DBNull.Value ? null : objRow[convSenateGaugeSubItems.senateGaugeSubItemAll2].ToString().Trim(); //senateGaugeSubItemAll2
objvSenateGaugeSubItemsEN.VersionNo = objRow[convSenateGaugeSubItems.VersionNo] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convSenateGaugeSubItems.VersionNo].ToString().Trim()); //版本号
objvSenateGaugeSubItemsEN.IsUse = clsEntityBase2.TransNullToBool_S(objRow[convSenateGaugeSubItems.IsUse].ToString().Trim()); //是否使用
objvSenateGaugeSubItemsEN.UpdDate = objRow[convSenateGaugeSubItems.UpdDate] == DBNull.Value ? null : objRow[convSenateGaugeSubItems.UpdDate].ToString().Trim(); //修改日期
objvSenateGaugeSubItemsEN.UpdUserId = objRow[convSenateGaugeSubItems.UpdUserId] == DBNull.Value ? null : objRow[convSenateGaugeSubItems.UpdUserId].ToString().Trim(); //修改用户Id
objvSenateGaugeSubItemsEN.AnswerModeId = objRow[convSenateGaugeSubItems.AnswerModeId] == DBNull.Value ? null : objRow[convSenateGaugeSubItems.AnswerModeId].ToString().Trim(); //答案模式Id
objvSenateGaugeSubItemsEN.AnswerModeName = objRow[convSenateGaugeSubItems.AnswerModeName] == DBNull.Value ? null : objRow[convSenateGaugeSubItems.AnswerModeName].ToString().Trim(); //答案模式名称
objvSenateGaugeSubItemsEN.AnswerNum = objRow[convSenateGaugeSubItems.AnswerNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convSenateGaugeSubItems.AnswerNum].ToString().Trim()); //答案数
objvSenateGaugeSubItemsEN.AnswerTypeId = objRow[convSenateGaugeSubItems.AnswerTypeId] == DBNull.Value ? null : objRow[convSenateGaugeSubItems.AnswerTypeId].ToString().Trim(); //答案类型ID
objvSenateGaugeSubItemsEN.AnswerTypeName = objRow[convSenateGaugeSubItems.AnswerTypeName] == DBNull.Value ? null : objRow[convSenateGaugeSubItems.AnswerTypeName].ToString().Trim(); //答案类型名
objvSenateGaugeSubItemsEN.GridTitle = objRow[convSenateGaugeSubItems.GridTitle] == DBNull.Value ? null : objRow[convSenateGaugeSubItems.GridTitle].ToString().Trim(); //表格标题
objvSenateGaugeSubItemsEN.IsHaveAdditionalMemo = clsEntityBase2.TransNullToBool_S(objRow[convSenateGaugeSubItems.IsHaveAdditionalMemo].ToString().Trim()); //是否有附加说明
objvSenateGaugeSubItemsEN.QuestionIndex = objRow[convSenateGaugeSubItems.QuestionIndex] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convSenateGaugeSubItems.QuestionIndex].ToString().Trim()); //题目序号
objvSenateGaugeSubItemsEN.QuestionNo = objRow[convSenateGaugeSubItems.QuestionNo] == DBNull.Value ? null : objRow[convSenateGaugeSubItems.QuestionNo].ToString().Trim(); //题目编号
objvSenateGaugeSubItemsEN.QuestionTypeId = objRow[convSenateGaugeSubItems.QuestionTypeId] == DBNull.Value ? null : objRow[convSenateGaugeSubItems.QuestionTypeId].ToString().Trim(); //题目类型Id
objvSenateGaugeSubItemsEN.QuestionTypeName = objRow[convSenateGaugeSubItems.QuestionTypeName] == DBNull.Value ? null : objRow[convSenateGaugeSubItems.QuestionTypeName].ToString().Trim(); //题目类型名
objvSenateGaugeSubItemsEN.senateGaugeItemNameWithOrder = objRow[convSenateGaugeSubItems.senateGaugeItemNameWithOrder] == DBNull.Value ? null : objRow[convSenateGaugeSubItems.senateGaugeItemNameWithOrder].ToString().Trim(); //量表指标名称WithOrder
objvSenateGaugeSubItemsEN.senateGaugeVersionMemo = objRow[convSenateGaugeSubItems.senateGaugeVersionMemo] == DBNull.Value ? null : objRow[convSenateGaugeSubItems.senateGaugeVersionMemo].ToString().Trim(); //评价量表版本说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvSenateGaugeSubItemsEN.IdSenateGaugeSubItem, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvSenateGaugeSubItemsEN);
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
public static List<clsvSenateGaugeSubItemsEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsvSenateGaugeSubItemsEN> arrObjLst = new List<clsvSenateGaugeSubItemsEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvSenateGaugeSubItemsEN objvSenateGaugeSubItemsEN = new clsvSenateGaugeSubItemsEN();
try
{
objvSenateGaugeSubItemsEN.IdSenateGaugeSubItem = objRow[convSenateGaugeSubItems.IdSenateGaugeSubItem].ToString().Trim(); //量表指标子项流水号
objvSenateGaugeSubItemsEN.senateGaugeSubItemID = objRow[convSenateGaugeSubItems.senateGaugeSubItemID] == DBNull.Value ? null : objRow[convSenateGaugeSubItems.senateGaugeSubItemID].ToString().Trim(); //量表指标子项ID
objvSenateGaugeSubItemsEN.senateGaugeSubItemName = objRow[convSenateGaugeSubItems.senateGaugeSubItemName] == DBNull.Value ? null : objRow[convSenateGaugeSubItems.senateGaugeSubItemName].ToString().Trim(); //量表指标子项名称
objvSenateGaugeSubItemsEN.IdSenateGaugeItem = objRow[convSenateGaugeSubItems.IdSenateGaugeItem].ToString().Trim(); //量表指标流水号
objvSenateGaugeSubItemsEN.senateGaugeItemName = objRow[convSenateGaugeSubItems.senateGaugeItemName] == DBNull.Value ? null : objRow[convSenateGaugeSubItems.senateGaugeItemName].ToString().Trim(); //量表指标名称
objvSenateGaugeSubItemsEN.senateGaugeVersionName = objRow[convSenateGaugeSubItems.senateGaugeVersionName] == DBNull.Value ? null : objRow[convSenateGaugeSubItems.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称
objvSenateGaugeSubItemsEN.senateGaugeSubItemScore = objRow[convSenateGaugeSubItems.senateGaugeSubItemScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convSenateGaugeSubItems.senateGaugeSubItemScore].ToString().Trim()); //量表指标子项分数
objvSenateGaugeSubItemsEN.IdSenateGaugeVersion = objRow[convSenateGaugeSubItems.IdSenateGaugeVersion].ToString().Trim(); //评价量表版本流水号
objvSenateGaugeSubItemsEN.senateGaugeItemID = objRow[convSenateGaugeSubItems.senateGaugeItemID] == DBNull.Value ? null : objRow[convSenateGaugeSubItems.senateGaugeItemID].ToString().Trim(); //量表指标ID
objvSenateGaugeSubItemsEN.senateGaugeSubItemDesc = objRow[convSenateGaugeSubItems.senateGaugeSubItemDesc] == DBNull.Value ? null : objRow[convSenateGaugeSubItems.senateGaugeSubItemDesc].ToString().Trim(); //量表指标子项说明
objvSenateGaugeSubItemsEN.AnswerTitle = objRow[convSenateGaugeSubItems.AnswerTitle] == DBNull.Value ? null : objRow[convSenateGaugeSubItems.AnswerTitle].ToString().Trim(); //答案标题
objvSenateGaugeSubItemsEN.AnswerIndex = objRow[convSenateGaugeSubItems.AnswerIndex] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convSenateGaugeSubItems.AnswerIndex].ToString().Trim()); //问答序号
objvSenateGaugeSubItemsEN.senateGaugeItemDesc = objRow[convSenateGaugeSubItems.senateGaugeItemDesc] == DBNull.Value ? null : objRow[convSenateGaugeSubItems.senateGaugeItemDesc].ToString().Trim(); //量表指标说明
objvSenateGaugeSubItemsEN.senateGaugeItemWeight = objRow[convSenateGaugeSubItems.senateGaugeItemWeight] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convSenateGaugeSubItems.senateGaugeItemWeight].ToString().Trim()); //量表指标权重
objvSenateGaugeSubItemsEN.senateGaugeSubItemMemo = objRow[convSenateGaugeSubItems.senateGaugeSubItemMemo] == DBNull.Value ? null : objRow[convSenateGaugeSubItems.senateGaugeSubItemMemo].ToString().Trim(); //量表指标子项备注
objvSenateGaugeSubItemsEN.senateGaugeItemMemo = objRow[convSenateGaugeSubItems.senateGaugeItemMemo] == DBNull.Value ? null : objRow[convSenateGaugeSubItems.senateGaugeItemMemo].ToString().Trim(); //备注
objvSenateGaugeSubItemsEN.senateGaugeVersionID = objRow[convSenateGaugeSubItems.senateGaugeVersionID].ToString().Trim(); //评价量表版本ID
objvSenateGaugeSubItemsEN.senateGaugeVersionTtlScore = Single.Parse(objRow[convSenateGaugeSubItems.senateGaugeVersionTtlScore].ToString().Trim()); //评价量表版本总分
objvSenateGaugeSubItemsEN.senateGaugeSubItemAll = objRow[convSenateGaugeSubItems.senateGaugeSubItemAll] == DBNull.Value ? null : objRow[convSenateGaugeSubItems.senateGaugeSubItemAll].ToString().Trim(); //子项等地分数
objvSenateGaugeSubItemsEN.senateGaugeSubItemAll2 = objRow[convSenateGaugeSubItems.senateGaugeSubItemAll2] == DBNull.Value ? null : objRow[convSenateGaugeSubItems.senateGaugeSubItemAll2].ToString().Trim(); //senateGaugeSubItemAll2
objvSenateGaugeSubItemsEN.VersionNo = objRow[convSenateGaugeSubItems.VersionNo] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convSenateGaugeSubItems.VersionNo].ToString().Trim()); //版本号
objvSenateGaugeSubItemsEN.IsUse = clsEntityBase2.TransNullToBool_S(objRow[convSenateGaugeSubItems.IsUse].ToString().Trim()); //是否使用
objvSenateGaugeSubItemsEN.UpdDate = objRow[convSenateGaugeSubItems.UpdDate] == DBNull.Value ? null : objRow[convSenateGaugeSubItems.UpdDate].ToString().Trim(); //修改日期
objvSenateGaugeSubItemsEN.UpdUserId = objRow[convSenateGaugeSubItems.UpdUserId] == DBNull.Value ? null : objRow[convSenateGaugeSubItems.UpdUserId].ToString().Trim(); //修改用户Id
objvSenateGaugeSubItemsEN.AnswerModeId = objRow[convSenateGaugeSubItems.AnswerModeId] == DBNull.Value ? null : objRow[convSenateGaugeSubItems.AnswerModeId].ToString().Trim(); //答案模式Id
objvSenateGaugeSubItemsEN.AnswerModeName = objRow[convSenateGaugeSubItems.AnswerModeName] == DBNull.Value ? null : objRow[convSenateGaugeSubItems.AnswerModeName].ToString().Trim(); //答案模式名称
objvSenateGaugeSubItemsEN.AnswerNum = objRow[convSenateGaugeSubItems.AnswerNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convSenateGaugeSubItems.AnswerNum].ToString().Trim()); //答案数
objvSenateGaugeSubItemsEN.AnswerTypeId = objRow[convSenateGaugeSubItems.AnswerTypeId] == DBNull.Value ? null : objRow[convSenateGaugeSubItems.AnswerTypeId].ToString().Trim(); //答案类型ID
objvSenateGaugeSubItemsEN.AnswerTypeName = objRow[convSenateGaugeSubItems.AnswerTypeName] == DBNull.Value ? null : objRow[convSenateGaugeSubItems.AnswerTypeName].ToString().Trim(); //答案类型名
objvSenateGaugeSubItemsEN.GridTitle = objRow[convSenateGaugeSubItems.GridTitle] == DBNull.Value ? null : objRow[convSenateGaugeSubItems.GridTitle].ToString().Trim(); //表格标题
objvSenateGaugeSubItemsEN.IsHaveAdditionalMemo = clsEntityBase2.TransNullToBool_S(objRow[convSenateGaugeSubItems.IsHaveAdditionalMemo].ToString().Trim()); //是否有附加说明
objvSenateGaugeSubItemsEN.QuestionIndex = objRow[convSenateGaugeSubItems.QuestionIndex] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convSenateGaugeSubItems.QuestionIndex].ToString().Trim()); //题目序号
objvSenateGaugeSubItemsEN.QuestionNo = objRow[convSenateGaugeSubItems.QuestionNo] == DBNull.Value ? null : objRow[convSenateGaugeSubItems.QuestionNo].ToString().Trim(); //题目编号
objvSenateGaugeSubItemsEN.QuestionTypeId = objRow[convSenateGaugeSubItems.QuestionTypeId] == DBNull.Value ? null : objRow[convSenateGaugeSubItems.QuestionTypeId].ToString().Trim(); //题目类型Id
objvSenateGaugeSubItemsEN.QuestionTypeName = objRow[convSenateGaugeSubItems.QuestionTypeName] == DBNull.Value ? null : objRow[convSenateGaugeSubItems.QuestionTypeName].ToString().Trim(); //题目类型名
objvSenateGaugeSubItemsEN.senateGaugeItemNameWithOrder = objRow[convSenateGaugeSubItems.senateGaugeItemNameWithOrder] == DBNull.Value ? null : objRow[convSenateGaugeSubItems.senateGaugeItemNameWithOrder].ToString().Trim(); //量表指标名称WithOrder
objvSenateGaugeSubItemsEN.senateGaugeVersionMemo = objRow[convSenateGaugeSubItems.senateGaugeVersionMemo] == DBNull.Value ? null : objRow[convSenateGaugeSubItems.senateGaugeVersionMemo].ToString().Trim(); //评价量表版本说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvSenateGaugeSubItemsEN.IdSenateGaugeSubItem, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvSenateGaugeSubItemsEN);
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
List<clsvSenateGaugeSubItemsEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsvSenateGaugeSubItemsEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsvSenateGaugeSubItemsEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsvSenateGaugeSubItemsEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsvSenateGaugeSubItemsEN> arrObjLst = new List<clsvSenateGaugeSubItemsEN>(); 
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
	clsvSenateGaugeSubItemsEN objvSenateGaugeSubItemsEN = new clsvSenateGaugeSubItemsEN();
try
{
objvSenateGaugeSubItemsEN.IdSenateGaugeSubItem = objRow[convSenateGaugeSubItems.IdSenateGaugeSubItem].ToString().Trim(); //量表指标子项流水号
objvSenateGaugeSubItemsEN.senateGaugeSubItemID = objRow[convSenateGaugeSubItems.senateGaugeSubItemID] == DBNull.Value ? null : objRow[convSenateGaugeSubItems.senateGaugeSubItemID].ToString().Trim(); //量表指标子项ID
objvSenateGaugeSubItemsEN.senateGaugeSubItemName = objRow[convSenateGaugeSubItems.senateGaugeSubItemName] == DBNull.Value ? null : objRow[convSenateGaugeSubItems.senateGaugeSubItemName].ToString().Trim(); //量表指标子项名称
objvSenateGaugeSubItemsEN.IdSenateGaugeItem = objRow[convSenateGaugeSubItems.IdSenateGaugeItem].ToString().Trim(); //量表指标流水号
objvSenateGaugeSubItemsEN.senateGaugeItemName = objRow[convSenateGaugeSubItems.senateGaugeItemName] == DBNull.Value ? null : objRow[convSenateGaugeSubItems.senateGaugeItemName].ToString().Trim(); //量表指标名称
objvSenateGaugeSubItemsEN.senateGaugeVersionName = objRow[convSenateGaugeSubItems.senateGaugeVersionName] == DBNull.Value ? null : objRow[convSenateGaugeSubItems.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称
objvSenateGaugeSubItemsEN.senateGaugeSubItemScore = objRow[convSenateGaugeSubItems.senateGaugeSubItemScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convSenateGaugeSubItems.senateGaugeSubItemScore].ToString().Trim()); //量表指标子项分数
objvSenateGaugeSubItemsEN.IdSenateGaugeVersion = objRow[convSenateGaugeSubItems.IdSenateGaugeVersion].ToString().Trim(); //评价量表版本流水号
objvSenateGaugeSubItemsEN.senateGaugeItemID = objRow[convSenateGaugeSubItems.senateGaugeItemID] == DBNull.Value ? null : objRow[convSenateGaugeSubItems.senateGaugeItemID].ToString().Trim(); //量表指标ID
objvSenateGaugeSubItemsEN.senateGaugeSubItemDesc = objRow[convSenateGaugeSubItems.senateGaugeSubItemDesc] == DBNull.Value ? null : objRow[convSenateGaugeSubItems.senateGaugeSubItemDesc].ToString().Trim(); //量表指标子项说明
objvSenateGaugeSubItemsEN.AnswerTitle = objRow[convSenateGaugeSubItems.AnswerTitle] == DBNull.Value ? null : objRow[convSenateGaugeSubItems.AnswerTitle].ToString().Trim(); //答案标题
objvSenateGaugeSubItemsEN.AnswerIndex = objRow[convSenateGaugeSubItems.AnswerIndex] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convSenateGaugeSubItems.AnswerIndex].ToString().Trim()); //问答序号
objvSenateGaugeSubItemsEN.senateGaugeItemDesc = objRow[convSenateGaugeSubItems.senateGaugeItemDesc] == DBNull.Value ? null : objRow[convSenateGaugeSubItems.senateGaugeItemDesc].ToString().Trim(); //量表指标说明
objvSenateGaugeSubItemsEN.senateGaugeItemWeight = objRow[convSenateGaugeSubItems.senateGaugeItemWeight] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convSenateGaugeSubItems.senateGaugeItemWeight].ToString().Trim()); //量表指标权重
objvSenateGaugeSubItemsEN.senateGaugeSubItemMemo = objRow[convSenateGaugeSubItems.senateGaugeSubItemMemo] == DBNull.Value ? null : objRow[convSenateGaugeSubItems.senateGaugeSubItemMemo].ToString().Trim(); //量表指标子项备注
objvSenateGaugeSubItemsEN.senateGaugeItemMemo = objRow[convSenateGaugeSubItems.senateGaugeItemMemo] == DBNull.Value ? null : objRow[convSenateGaugeSubItems.senateGaugeItemMemo].ToString().Trim(); //备注
objvSenateGaugeSubItemsEN.senateGaugeVersionID = objRow[convSenateGaugeSubItems.senateGaugeVersionID].ToString().Trim(); //评价量表版本ID
objvSenateGaugeSubItemsEN.senateGaugeVersionTtlScore = Single.Parse(objRow[convSenateGaugeSubItems.senateGaugeVersionTtlScore].ToString().Trim()); //评价量表版本总分
objvSenateGaugeSubItemsEN.senateGaugeSubItemAll = objRow[convSenateGaugeSubItems.senateGaugeSubItemAll] == DBNull.Value ? null : objRow[convSenateGaugeSubItems.senateGaugeSubItemAll].ToString().Trim(); //子项等地分数
objvSenateGaugeSubItemsEN.senateGaugeSubItemAll2 = objRow[convSenateGaugeSubItems.senateGaugeSubItemAll2] == DBNull.Value ? null : objRow[convSenateGaugeSubItems.senateGaugeSubItemAll2].ToString().Trim(); //senateGaugeSubItemAll2
objvSenateGaugeSubItemsEN.VersionNo = objRow[convSenateGaugeSubItems.VersionNo] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convSenateGaugeSubItems.VersionNo].ToString().Trim()); //版本号
objvSenateGaugeSubItemsEN.IsUse = clsEntityBase2.TransNullToBool_S(objRow[convSenateGaugeSubItems.IsUse].ToString().Trim()); //是否使用
objvSenateGaugeSubItemsEN.UpdDate = objRow[convSenateGaugeSubItems.UpdDate] == DBNull.Value ? null : objRow[convSenateGaugeSubItems.UpdDate].ToString().Trim(); //修改日期
objvSenateGaugeSubItemsEN.UpdUserId = objRow[convSenateGaugeSubItems.UpdUserId] == DBNull.Value ? null : objRow[convSenateGaugeSubItems.UpdUserId].ToString().Trim(); //修改用户Id
objvSenateGaugeSubItemsEN.AnswerModeId = objRow[convSenateGaugeSubItems.AnswerModeId] == DBNull.Value ? null : objRow[convSenateGaugeSubItems.AnswerModeId].ToString().Trim(); //答案模式Id
objvSenateGaugeSubItemsEN.AnswerModeName = objRow[convSenateGaugeSubItems.AnswerModeName] == DBNull.Value ? null : objRow[convSenateGaugeSubItems.AnswerModeName].ToString().Trim(); //答案模式名称
objvSenateGaugeSubItemsEN.AnswerNum = objRow[convSenateGaugeSubItems.AnswerNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convSenateGaugeSubItems.AnswerNum].ToString().Trim()); //答案数
objvSenateGaugeSubItemsEN.AnswerTypeId = objRow[convSenateGaugeSubItems.AnswerTypeId] == DBNull.Value ? null : objRow[convSenateGaugeSubItems.AnswerTypeId].ToString().Trim(); //答案类型ID
objvSenateGaugeSubItemsEN.AnswerTypeName = objRow[convSenateGaugeSubItems.AnswerTypeName] == DBNull.Value ? null : objRow[convSenateGaugeSubItems.AnswerTypeName].ToString().Trim(); //答案类型名
objvSenateGaugeSubItemsEN.GridTitle = objRow[convSenateGaugeSubItems.GridTitle] == DBNull.Value ? null : objRow[convSenateGaugeSubItems.GridTitle].ToString().Trim(); //表格标题
objvSenateGaugeSubItemsEN.IsHaveAdditionalMemo = clsEntityBase2.TransNullToBool_S(objRow[convSenateGaugeSubItems.IsHaveAdditionalMemo].ToString().Trim()); //是否有附加说明
objvSenateGaugeSubItemsEN.QuestionIndex = objRow[convSenateGaugeSubItems.QuestionIndex] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convSenateGaugeSubItems.QuestionIndex].ToString().Trim()); //题目序号
objvSenateGaugeSubItemsEN.QuestionNo = objRow[convSenateGaugeSubItems.QuestionNo] == DBNull.Value ? null : objRow[convSenateGaugeSubItems.QuestionNo].ToString().Trim(); //题目编号
objvSenateGaugeSubItemsEN.QuestionTypeId = objRow[convSenateGaugeSubItems.QuestionTypeId] == DBNull.Value ? null : objRow[convSenateGaugeSubItems.QuestionTypeId].ToString().Trim(); //题目类型Id
objvSenateGaugeSubItemsEN.QuestionTypeName = objRow[convSenateGaugeSubItems.QuestionTypeName] == DBNull.Value ? null : objRow[convSenateGaugeSubItems.QuestionTypeName].ToString().Trim(); //题目类型名
objvSenateGaugeSubItemsEN.senateGaugeItemNameWithOrder = objRow[convSenateGaugeSubItems.senateGaugeItemNameWithOrder] == DBNull.Value ? null : objRow[convSenateGaugeSubItems.senateGaugeItemNameWithOrder].ToString().Trim(); //量表指标名称WithOrder
objvSenateGaugeSubItemsEN.senateGaugeVersionMemo = objRow[convSenateGaugeSubItems.senateGaugeVersionMemo] == DBNull.Value ? null : objRow[convSenateGaugeSubItems.senateGaugeVersionMemo].ToString().Trim(); //评价量表版本说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvSenateGaugeSubItemsEN.IdSenateGaugeSubItem, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvSenateGaugeSubItemsEN);
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
public static List<clsvSenateGaugeSubItemsEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsvSenateGaugeSubItemsEN> arrObjLst = new List<clsvSenateGaugeSubItemsEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvSenateGaugeSubItemsEN objvSenateGaugeSubItemsEN = new clsvSenateGaugeSubItemsEN();
try
{
objvSenateGaugeSubItemsEN.IdSenateGaugeSubItem = objRow[convSenateGaugeSubItems.IdSenateGaugeSubItem].ToString().Trim(); //量表指标子项流水号
objvSenateGaugeSubItemsEN.senateGaugeSubItemID = objRow[convSenateGaugeSubItems.senateGaugeSubItemID] == DBNull.Value ? null : objRow[convSenateGaugeSubItems.senateGaugeSubItemID].ToString().Trim(); //量表指标子项ID
objvSenateGaugeSubItemsEN.senateGaugeSubItemName = objRow[convSenateGaugeSubItems.senateGaugeSubItemName] == DBNull.Value ? null : objRow[convSenateGaugeSubItems.senateGaugeSubItemName].ToString().Trim(); //量表指标子项名称
objvSenateGaugeSubItemsEN.IdSenateGaugeItem = objRow[convSenateGaugeSubItems.IdSenateGaugeItem].ToString().Trim(); //量表指标流水号
objvSenateGaugeSubItemsEN.senateGaugeItemName = objRow[convSenateGaugeSubItems.senateGaugeItemName] == DBNull.Value ? null : objRow[convSenateGaugeSubItems.senateGaugeItemName].ToString().Trim(); //量表指标名称
objvSenateGaugeSubItemsEN.senateGaugeVersionName = objRow[convSenateGaugeSubItems.senateGaugeVersionName] == DBNull.Value ? null : objRow[convSenateGaugeSubItems.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称
objvSenateGaugeSubItemsEN.senateGaugeSubItemScore = objRow[convSenateGaugeSubItems.senateGaugeSubItemScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convSenateGaugeSubItems.senateGaugeSubItemScore].ToString().Trim()); //量表指标子项分数
objvSenateGaugeSubItemsEN.IdSenateGaugeVersion = objRow[convSenateGaugeSubItems.IdSenateGaugeVersion].ToString().Trim(); //评价量表版本流水号
objvSenateGaugeSubItemsEN.senateGaugeItemID = objRow[convSenateGaugeSubItems.senateGaugeItemID] == DBNull.Value ? null : objRow[convSenateGaugeSubItems.senateGaugeItemID].ToString().Trim(); //量表指标ID
objvSenateGaugeSubItemsEN.senateGaugeSubItemDesc = objRow[convSenateGaugeSubItems.senateGaugeSubItemDesc] == DBNull.Value ? null : objRow[convSenateGaugeSubItems.senateGaugeSubItemDesc].ToString().Trim(); //量表指标子项说明
objvSenateGaugeSubItemsEN.AnswerTitle = objRow[convSenateGaugeSubItems.AnswerTitle] == DBNull.Value ? null : objRow[convSenateGaugeSubItems.AnswerTitle].ToString().Trim(); //答案标题
objvSenateGaugeSubItemsEN.AnswerIndex = objRow[convSenateGaugeSubItems.AnswerIndex] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convSenateGaugeSubItems.AnswerIndex].ToString().Trim()); //问答序号
objvSenateGaugeSubItemsEN.senateGaugeItemDesc = objRow[convSenateGaugeSubItems.senateGaugeItemDesc] == DBNull.Value ? null : objRow[convSenateGaugeSubItems.senateGaugeItemDesc].ToString().Trim(); //量表指标说明
objvSenateGaugeSubItemsEN.senateGaugeItemWeight = objRow[convSenateGaugeSubItems.senateGaugeItemWeight] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convSenateGaugeSubItems.senateGaugeItemWeight].ToString().Trim()); //量表指标权重
objvSenateGaugeSubItemsEN.senateGaugeSubItemMemo = objRow[convSenateGaugeSubItems.senateGaugeSubItemMemo] == DBNull.Value ? null : objRow[convSenateGaugeSubItems.senateGaugeSubItemMemo].ToString().Trim(); //量表指标子项备注
objvSenateGaugeSubItemsEN.senateGaugeItemMemo = objRow[convSenateGaugeSubItems.senateGaugeItemMemo] == DBNull.Value ? null : objRow[convSenateGaugeSubItems.senateGaugeItemMemo].ToString().Trim(); //备注
objvSenateGaugeSubItemsEN.senateGaugeVersionID = objRow[convSenateGaugeSubItems.senateGaugeVersionID].ToString().Trim(); //评价量表版本ID
objvSenateGaugeSubItemsEN.senateGaugeVersionTtlScore = Single.Parse(objRow[convSenateGaugeSubItems.senateGaugeVersionTtlScore].ToString().Trim()); //评价量表版本总分
objvSenateGaugeSubItemsEN.senateGaugeSubItemAll = objRow[convSenateGaugeSubItems.senateGaugeSubItemAll] == DBNull.Value ? null : objRow[convSenateGaugeSubItems.senateGaugeSubItemAll].ToString().Trim(); //子项等地分数
objvSenateGaugeSubItemsEN.senateGaugeSubItemAll2 = objRow[convSenateGaugeSubItems.senateGaugeSubItemAll2] == DBNull.Value ? null : objRow[convSenateGaugeSubItems.senateGaugeSubItemAll2].ToString().Trim(); //senateGaugeSubItemAll2
objvSenateGaugeSubItemsEN.VersionNo = objRow[convSenateGaugeSubItems.VersionNo] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convSenateGaugeSubItems.VersionNo].ToString().Trim()); //版本号
objvSenateGaugeSubItemsEN.IsUse = clsEntityBase2.TransNullToBool_S(objRow[convSenateGaugeSubItems.IsUse].ToString().Trim()); //是否使用
objvSenateGaugeSubItemsEN.UpdDate = objRow[convSenateGaugeSubItems.UpdDate] == DBNull.Value ? null : objRow[convSenateGaugeSubItems.UpdDate].ToString().Trim(); //修改日期
objvSenateGaugeSubItemsEN.UpdUserId = objRow[convSenateGaugeSubItems.UpdUserId] == DBNull.Value ? null : objRow[convSenateGaugeSubItems.UpdUserId].ToString().Trim(); //修改用户Id
objvSenateGaugeSubItemsEN.AnswerModeId = objRow[convSenateGaugeSubItems.AnswerModeId] == DBNull.Value ? null : objRow[convSenateGaugeSubItems.AnswerModeId].ToString().Trim(); //答案模式Id
objvSenateGaugeSubItemsEN.AnswerModeName = objRow[convSenateGaugeSubItems.AnswerModeName] == DBNull.Value ? null : objRow[convSenateGaugeSubItems.AnswerModeName].ToString().Trim(); //答案模式名称
objvSenateGaugeSubItemsEN.AnswerNum = objRow[convSenateGaugeSubItems.AnswerNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convSenateGaugeSubItems.AnswerNum].ToString().Trim()); //答案数
objvSenateGaugeSubItemsEN.AnswerTypeId = objRow[convSenateGaugeSubItems.AnswerTypeId] == DBNull.Value ? null : objRow[convSenateGaugeSubItems.AnswerTypeId].ToString().Trim(); //答案类型ID
objvSenateGaugeSubItemsEN.AnswerTypeName = objRow[convSenateGaugeSubItems.AnswerTypeName] == DBNull.Value ? null : objRow[convSenateGaugeSubItems.AnswerTypeName].ToString().Trim(); //答案类型名
objvSenateGaugeSubItemsEN.GridTitle = objRow[convSenateGaugeSubItems.GridTitle] == DBNull.Value ? null : objRow[convSenateGaugeSubItems.GridTitle].ToString().Trim(); //表格标题
objvSenateGaugeSubItemsEN.IsHaveAdditionalMemo = clsEntityBase2.TransNullToBool_S(objRow[convSenateGaugeSubItems.IsHaveAdditionalMemo].ToString().Trim()); //是否有附加说明
objvSenateGaugeSubItemsEN.QuestionIndex = objRow[convSenateGaugeSubItems.QuestionIndex] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convSenateGaugeSubItems.QuestionIndex].ToString().Trim()); //题目序号
objvSenateGaugeSubItemsEN.QuestionNo = objRow[convSenateGaugeSubItems.QuestionNo] == DBNull.Value ? null : objRow[convSenateGaugeSubItems.QuestionNo].ToString().Trim(); //题目编号
objvSenateGaugeSubItemsEN.QuestionTypeId = objRow[convSenateGaugeSubItems.QuestionTypeId] == DBNull.Value ? null : objRow[convSenateGaugeSubItems.QuestionTypeId].ToString().Trim(); //题目类型Id
objvSenateGaugeSubItemsEN.QuestionTypeName = objRow[convSenateGaugeSubItems.QuestionTypeName] == DBNull.Value ? null : objRow[convSenateGaugeSubItems.QuestionTypeName].ToString().Trim(); //题目类型名
objvSenateGaugeSubItemsEN.senateGaugeItemNameWithOrder = objRow[convSenateGaugeSubItems.senateGaugeItemNameWithOrder] == DBNull.Value ? null : objRow[convSenateGaugeSubItems.senateGaugeItemNameWithOrder].ToString().Trim(); //量表指标名称WithOrder
objvSenateGaugeSubItemsEN.senateGaugeVersionMemo = objRow[convSenateGaugeSubItems.senateGaugeVersionMemo] == DBNull.Value ? null : objRow[convSenateGaugeSubItems.senateGaugeVersionMemo].ToString().Trim(); //评价量表版本说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvSenateGaugeSubItemsEN.IdSenateGaugeSubItem, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvSenateGaugeSubItemsEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsvSenateGaugeSubItemsEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsvSenateGaugeSubItemsEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsvSenateGaugeSubItemsEN> arrObjLst = new List<clsvSenateGaugeSubItemsEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvSenateGaugeSubItemsEN objvSenateGaugeSubItemsEN = new clsvSenateGaugeSubItemsEN();
try
{
objvSenateGaugeSubItemsEN.IdSenateGaugeSubItem = objRow[convSenateGaugeSubItems.IdSenateGaugeSubItem].ToString().Trim(); //量表指标子项流水号
objvSenateGaugeSubItemsEN.senateGaugeSubItemID = objRow[convSenateGaugeSubItems.senateGaugeSubItemID] == DBNull.Value ? null : objRow[convSenateGaugeSubItems.senateGaugeSubItemID].ToString().Trim(); //量表指标子项ID
objvSenateGaugeSubItemsEN.senateGaugeSubItemName = objRow[convSenateGaugeSubItems.senateGaugeSubItemName] == DBNull.Value ? null : objRow[convSenateGaugeSubItems.senateGaugeSubItemName].ToString().Trim(); //量表指标子项名称
objvSenateGaugeSubItemsEN.IdSenateGaugeItem = objRow[convSenateGaugeSubItems.IdSenateGaugeItem].ToString().Trim(); //量表指标流水号
objvSenateGaugeSubItemsEN.senateGaugeItemName = objRow[convSenateGaugeSubItems.senateGaugeItemName] == DBNull.Value ? null : objRow[convSenateGaugeSubItems.senateGaugeItemName].ToString().Trim(); //量表指标名称
objvSenateGaugeSubItemsEN.senateGaugeVersionName = objRow[convSenateGaugeSubItems.senateGaugeVersionName] == DBNull.Value ? null : objRow[convSenateGaugeSubItems.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称
objvSenateGaugeSubItemsEN.senateGaugeSubItemScore = objRow[convSenateGaugeSubItems.senateGaugeSubItemScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convSenateGaugeSubItems.senateGaugeSubItemScore].ToString().Trim()); //量表指标子项分数
objvSenateGaugeSubItemsEN.IdSenateGaugeVersion = objRow[convSenateGaugeSubItems.IdSenateGaugeVersion].ToString().Trim(); //评价量表版本流水号
objvSenateGaugeSubItemsEN.senateGaugeItemID = objRow[convSenateGaugeSubItems.senateGaugeItemID] == DBNull.Value ? null : objRow[convSenateGaugeSubItems.senateGaugeItemID].ToString().Trim(); //量表指标ID
objvSenateGaugeSubItemsEN.senateGaugeSubItemDesc = objRow[convSenateGaugeSubItems.senateGaugeSubItemDesc] == DBNull.Value ? null : objRow[convSenateGaugeSubItems.senateGaugeSubItemDesc].ToString().Trim(); //量表指标子项说明
objvSenateGaugeSubItemsEN.AnswerTitle = objRow[convSenateGaugeSubItems.AnswerTitle] == DBNull.Value ? null : objRow[convSenateGaugeSubItems.AnswerTitle].ToString().Trim(); //答案标题
objvSenateGaugeSubItemsEN.AnswerIndex = objRow[convSenateGaugeSubItems.AnswerIndex] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convSenateGaugeSubItems.AnswerIndex].ToString().Trim()); //问答序号
objvSenateGaugeSubItemsEN.senateGaugeItemDesc = objRow[convSenateGaugeSubItems.senateGaugeItemDesc] == DBNull.Value ? null : objRow[convSenateGaugeSubItems.senateGaugeItemDesc].ToString().Trim(); //量表指标说明
objvSenateGaugeSubItemsEN.senateGaugeItemWeight = objRow[convSenateGaugeSubItems.senateGaugeItemWeight] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convSenateGaugeSubItems.senateGaugeItemWeight].ToString().Trim()); //量表指标权重
objvSenateGaugeSubItemsEN.senateGaugeSubItemMemo = objRow[convSenateGaugeSubItems.senateGaugeSubItemMemo] == DBNull.Value ? null : objRow[convSenateGaugeSubItems.senateGaugeSubItemMemo].ToString().Trim(); //量表指标子项备注
objvSenateGaugeSubItemsEN.senateGaugeItemMemo = objRow[convSenateGaugeSubItems.senateGaugeItemMemo] == DBNull.Value ? null : objRow[convSenateGaugeSubItems.senateGaugeItemMemo].ToString().Trim(); //备注
objvSenateGaugeSubItemsEN.senateGaugeVersionID = objRow[convSenateGaugeSubItems.senateGaugeVersionID].ToString().Trim(); //评价量表版本ID
objvSenateGaugeSubItemsEN.senateGaugeVersionTtlScore = Single.Parse(objRow[convSenateGaugeSubItems.senateGaugeVersionTtlScore].ToString().Trim()); //评价量表版本总分
objvSenateGaugeSubItemsEN.senateGaugeSubItemAll = objRow[convSenateGaugeSubItems.senateGaugeSubItemAll] == DBNull.Value ? null : objRow[convSenateGaugeSubItems.senateGaugeSubItemAll].ToString().Trim(); //子项等地分数
objvSenateGaugeSubItemsEN.senateGaugeSubItemAll2 = objRow[convSenateGaugeSubItems.senateGaugeSubItemAll2] == DBNull.Value ? null : objRow[convSenateGaugeSubItems.senateGaugeSubItemAll2].ToString().Trim(); //senateGaugeSubItemAll2
objvSenateGaugeSubItemsEN.VersionNo = objRow[convSenateGaugeSubItems.VersionNo] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convSenateGaugeSubItems.VersionNo].ToString().Trim()); //版本号
objvSenateGaugeSubItemsEN.IsUse = clsEntityBase2.TransNullToBool_S(objRow[convSenateGaugeSubItems.IsUse].ToString().Trim()); //是否使用
objvSenateGaugeSubItemsEN.UpdDate = objRow[convSenateGaugeSubItems.UpdDate] == DBNull.Value ? null : objRow[convSenateGaugeSubItems.UpdDate].ToString().Trim(); //修改日期
objvSenateGaugeSubItemsEN.UpdUserId = objRow[convSenateGaugeSubItems.UpdUserId] == DBNull.Value ? null : objRow[convSenateGaugeSubItems.UpdUserId].ToString().Trim(); //修改用户Id
objvSenateGaugeSubItemsEN.AnswerModeId = objRow[convSenateGaugeSubItems.AnswerModeId] == DBNull.Value ? null : objRow[convSenateGaugeSubItems.AnswerModeId].ToString().Trim(); //答案模式Id
objvSenateGaugeSubItemsEN.AnswerModeName = objRow[convSenateGaugeSubItems.AnswerModeName] == DBNull.Value ? null : objRow[convSenateGaugeSubItems.AnswerModeName].ToString().Trim(); //答案模式名称
objvSenateGaugeSubItemsEN.AnswerNum = objRow[convSenateGaugeSubItems.AnswerNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convSenateGaugeSubItems.AnswerNum].ToString().Trim()); //答案数
objvSenateGaugeSubItemsEN.AnswerTypeId = objRow[convSenateGaugeSubItems.AnswerTypeId] == DBNull.Value ? null : objRow[convSenateGaugeSubItems.AnswerTypeId].ToString().Trim(); //答案类型ID
objvSenateGaugeSubItemsEN.AnswerTypeName = objRow[convSenateGaugeSubItems.AnswerTypeName] == DBNull.Value ? null : objRow[convSenateGaugeSubItems.AnswerTypeName].ToString().Trim(); //答案类型名
objvSenateGaugeSubItemsEN.GridTitle = objRow[convSenateGaugeSubItems.GridTitle] == DBNull.Value ? null : objRow[convSenateGaugeSubItems.GridTitle].ToString().Trim(); //表格标题
objvSenateGaugeSubItemsEN.IsHaveAdditionalMemo = clsEntityBase2.TransNullToBool_S(objRow[convSenateGaugeSubItems.IsHaveAdditionalMemo].ToString().Trim()); //是否有附加说明
objvSenateGaugeSubItemsEN.QuestionIndex = objRow[convSenateGaugeSubItems.QuestionIndex] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convSenateGaugeSubItems.QuestionIndex].ToString().Trim()); //题目序号
objvSenateGaugeSubItemsEN.QuestionNo = objRow[convSenateGaugeSubItems.QuestionNo] == DBNull.Value ? null : objRow[convSenateGaugeSubItems.QuestionNo].ToString().Trim(); //题目编号
objvSenateGaugeSubItemsEN.QuestionTypeId = objRow[convSenateGaugeSubItems.QuestionTypeId] == DBNull.Value ? null : objRow[convSenateGaugeSubItems.QuestionTypeId].ToString().Trim(); //题目类型Id
objvSenateGaugeSubItemsEN.QuestionTypeName = objRow[convSenateGaugeSubItems.QuestionTypeName] == DBNull.Value ? null : objRow[convSenateGaugeSubItems.QuestionTypeName].ToString().Trim(); //题目类型名
objvSenateGaugeSubItemsEN.senateGaugeItemNameWithOrder = objRow[convSenateGaugeSubItems.senateGaugeItemNameWithOrder] == DBNull.Value ? null : objRow[convSenateGaugeSubItems.senateGaugeItemNameWithOrder].ToString().Trim(); //量表指标名称WithOrder
objvSenateGaugeSubItemsEN.senateGaugeVersionMemo = objRow[convSenateGaugeSubItems.senateGaugeVersionMemo] == DBNull.Value ? null : objRow[convSenateGaugeSubItems.senateGaugeVersionMemo].ToString().Trim(); //评价量表版本说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvSenateGaugeSubItemsEN.IdSenateGaugeSubItem, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvSenateGaugeSubItemsEN);
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
public static List<clsvSenateGaugeSubItemsEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsvSenateGaugeSubItemsEN> arrObjLst = new List<clsvSenateGaugeSubItemsEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvSenateGaugeSubItemsEN objvSenateGaugeSubItemsEN = new clsvSenateGaugeSubItemsEN();
try
{
objvSenateGaugeSubItemsEN.IdSenateGaugeSubItem = objRow[convSenateGaugeSubItems.IdSenateGaugeSubItem].ToString().Trim(); //量表指标子项流水号
objvSenateGaugeSubItemsEN.senateGaugeSubItemID = objRow[convSenateGaugeSubItems.senateGaugeSubItemID] == DBNull.Value ? null : objRow[convSenateGaugeSubItems.senateGaugeSubItemID].ToString().Trim(); //量表指标子项ID
objvSenateGaugeSubItemsEN.senateGaugeSubItemName = objRow[convSenateGaugeSubItems.senateGaugeSubItemName] == DBNull.Value ? null : objRow[convSenateGaugeSubItems.senateGaugeSubItemName].ToString().Trim(); //量表指标子项名称
objvSenateGaugeSubItemsEN.IdSenateGaugeItem = objRow[convSenateGaugeSubItems.IdSenateGaugeItem].ToString().Trim(); //量表指标流水号
objvSenateGaugeSubItemsEN.senateGaugeItemName = objRow[convSenateGaugeSubItems.senateGaugeItemName] == DBNull.Value ? null : objRow[convSenateGaugeSubItems.senateGaugeItemName].ToString().Trim(); //量表指标名称
objvSenateGaugeSubItemsEN.senateGaugeVersionName = objRow[convSenateGaugeSubItems.senateGaugeVersionName] == DBNull.Value ? null : objRow[convSenateGaugeSubItems.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称
objvSenateGaugeSubItemsEN.senateGaugeSubItemScore = objRow[convSenateGaugeSubItems.senateGaugeSubItemScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convSenateGaugeSubItems.senateGaugeSubItemScore].ToString().Trim()); //量表指标子项分数
objvSenateGaugeSubItemsEN.IdSenateGaugeVersion = objRow[convSenateGaugeSubItems.IdSenateGaugeVersion].ToString().Trim(); //评价量表版本流水号
objvSenateGaugeSubItemsEN.senateGaugeItemID = objRow[convSenateGaugeSubItems.senateGaugeItemID] == DBNull.Value ? null : objRow[convSenateGaugeSubItems.senateGaugeItemID].ToString().Trim(); //量表指标ID
objvSenateGaugeSubItemsEN.senateGaugeSubItemDesc = objRow[convSenateGaugeSubItems.senateGaugeSubItemDesc] == DBNull.Value ? null : objRow[convSenateGaugeSubItems.senateGaugeSubItemDesc].ToString().Trim(); //量表指标子项说明
objvSenateGaugeSubItemsEN.AnswerTitle = objRow[convSenateGaugeSubItems.AnswerTitle] == DBNull.Value ? null : objRow[convSenateGaugeSubItems.AnswerTitle].ToString().Trim(); //答案标题
objvSenateGaugeSubItemsEN.AnswerIndex = objRow[convSenateGaugeSubItems.AnswerIndex] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convSenateGaugeSubItems.AnswerIndex].ToString().Trim()); //问答序号
objvSenateGaugeSubItemsEN.senateGaugeItemDesc = objRow[convSenateGaugeSubItems.senateGaugeItemDesc] == DBNull.Value ? null : objRow[convSenateGaugeSubItems.senateGaugeItemDesc].ToString().Trim(); //量表指标说明
objvSenateGaugeSubItemsEN.senateGaugeItemWeight = objRow[convSenateGaugeSubItems.senateGaugeItemWeight] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convSenateGaugeSubItems.senateGaugeItemWeight].ToString().Trim()); //量表指标权重
objvSenateGaugeSubItemsEN.senateGaugeSubItemMemo = objRow[convSenateGaugeSubItems.senateGaugeSubItemMemo] == DBNull.Value ? null : objRow[convSenateGaugeSubItems.senateGaugeSubItemMemo].ToString().Trim(); //量表指标子项备注
objvSenateGaugeSubItemsEN.senateGaugeItemMemo = objRow[convSenateGaugeSubItems.senateGaugeItemMemo] == DBNull.Value ? null : objRow[convSenateGaugeSubItems.senateGaugeItemMemo].ToString().Trim(); //备注
objvSenateGaugeSubItemsEN.senateGaugeVersionID = objRow[convSenateGaugeSubItems.senateGaugeVersionID].ToString().Trim(); //评价量表版本ID
objvSenateGaugeSubItemsEN.senateGaugeVersionTtlScore = Single.Parse(objRow[convSenateGaugeSubItems.senateGaugeVersionTtlScore].ToString().Trim()); //评价量表版本总分
objvSenateGaugeSubItemsEN.senateGaugeSubItemAll = objRow[convSenateGaugeSubItems.senateGaugeSubItemAll] == DBNull.Value ? null : objRow[convSenateGaugeSubItems.senateGaugeSubItemAll].ToString().Trim(); //子项等地分数
objvSenateGaugeSubItemsEN.senateGaugeSubItemAll2 = objRow[convSenateGaugeSubItems.senateGaugeSubItemAll2] == DBNull.Value ? null : objRow[convSenateGaugeSubItems.senateGaugeSubItemAll2].ToString().Trim(); //senateGaugeSubItemAll2
objvSenateGaugeSubItemsEN.VersionNo = objRow[convSenateGaugeSubItems.VersionNo] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convSenateGaugeSubItems.VersionNo].ToString().Trim()); //版本号
objvSenateGaugeSubItemsEN.IsUse = clsEntityBase2.TransNullToBool_S(objRow[convSenateGaugeSubItems.IsUse].ToString().Trim()); //是否使用
objvSenateGaugeSubItemsEN.UpdDate = objRow[convSenateGaugeSubItems.UpdDate] == DBNull.Value ? null : objRow[convSenateGaugeSubItems.UpdDate].ToString().Trim(); //修改日期
objvSenateGaugeSubItemsEN.UpdUserId = objRow[convSenateGaugeSubItems.UpdUserId] == DBNull.Value ? null : objRow[convSenateGaugeSubItems.UpdUserId].ToString().Trim(); //修改用户Id
objvSenateGaugeSubItemsEN.AnswerModeId = objRow[convSenateGaugeSubItems.AnswerModeId] == DBNull.Value ? null : objRow[convSenateGaugeSubItems.AnswerModeId].ToString().Trim(); //答案模式Id
objvSenateGaugeSubItemsEN.AnswerModeName = objRow[convSenateGaugeSubItems.AnswerModeName] == DBNull.Value ? null : objRow[convSenateGaugeSubItems.AnswerModeName].ToString().Trim(); //答案模式名称
objvSenateGaugeSubItemsEN.AnswerNum = objRow[convSenateGaugeSubItems.AnswerNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convSenateGaugeSubItems.AnswerNum].ToString().Trim()); //答案数
objvSenateGaugeSubItemsEN.AnswerTypeId = objRow[convSenateGaugeSubItems.AnswerTypeId] == DBNull.Value ? null : objRow[convSenateGaugeSubItems.AnswerTypeId].ToString().Trim(); //答案类型ID
objvSenateGaugeSubItemsEN.AnswerTypeName = objRow[convSenateGaugeSubItems.AnswerTypeName] == DBNull.Value ? null : objRow[convSenateGaugeSubItems.AnswerTypeName].ToString().Trim(); //答案类型名
objvSenateGaugeSubItemsEN.GridTitle = objRow[convSenateGaugeSubItems.GridTitle] == DBNull.Value ? null : objRow[convSenateGaugeSubItems.GridTitle].ToString().Trim(); //表格标题
objvSenateGaugeSubItemsEN.IsHaveAdditionalMemo = clsEntityBase2.TransNullToBool_S(objRow[convSenateGaugeSubItems.IsHaveAdditionalMemo].ToString().Trim()); //是否有附加说明
objvSenateGaugeSubItemsEN.QuestionIndex = objRow[convSenateGaugeSubItems.QuestionIndex] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convSenateGaugeSubItems.QuestionIndex].ToString().Trim()); //题目序号
objvSenateGaugeSubItemsEN.QuestionNo = objRow[convSenateGaugeSubItems.QuestionNo] == DBNull.Value ? null : objRow[convSenateGaugeSubItems.QuestionNo].ToString().Trim(); //题目编号
objvSenateGaugeSubItemsEN.QuestionTypeId = objRow[convSenateGaugeSubItems.QuestionTypeId] == DBNull.Value ? null : objRow[convSenateGaugeSubItems.QuestionTypeId].ToString().Trim(); //题目类型Id
objvSenateGaugeSubItemsEN.QuestionTypeName = objRow[convSenateGaugeSubItems.QuestionTypeName] == DBNull.Value ? null : objRow[convSenateGaugeSubItems.QuestionTypeName].ToString().Trim(); //题目类型名
objvSenateGaugeSubItemsEN.senateGaugeItemNameWithOrder = objRow[convSenateGaugeSubItems.senateGaugeItemNameWithOrder] == DBNull.Value ? null : objRow[convSenateGaugeSubItems.senateGaugeItemNameWithOrder].ToString().Trim(); //量表指标名称WithOrder
objvSenateGaugeSubItemsEN.senateGaugeVersionMemo = objRow[convSenateGaugeSubItems.senateGaugeVersionMemo] == DBNull.Value ? null : objRow[convSenateGaugeSubItems.senateGaugeVersionMemo].ToString().Trim(); //评价量表版本说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvSenateGaugeSubItemsEN.IdSenateGaugeSubItem, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvSenateGaugeSubItemsEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsvSenateGaugeSubItemsEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsvSenateGaugeSubItemsEN> arrObjLst = new List<clsvSenateGaugeSubItemsEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvSenateGaugeSubItemsEN objvSenateGaugeSubItemsEN = new clsvSenateGaugeSubItemsEN();
try
{
objvSenateGaugeSubItemsEN.IdSenateGaugeSubItem = objRow[convSenateGaugeSubItems.IdSenateGaugeSubItem].ToString().Trim(); //量表指标子项流水号
objvSenateGaugeSubItemsEN.senateGaugeSubItemID = objRow[convSenateGaugeSubItems.senateGaugeSubItemID] == DBNull.Value ? null : objRow[convSenateGaugeSubItems.senateGaugeSubItemID].ToString().Trim(); //量表指标子项ID
objvSenateGaugeSubItemsEN.senateGaugeSubItemName = objRow[convSenateGaugeSubItems.senateGaugeSubItemName] == DBNull.Value ? null : objRow[convSenateGaugeSubItems.senateGaugeSubItemName].ToString().Trim(); //量表指标子项名称
objvSenateGaugeSubItemsEN.IdSenateGaugeItem = objRow[convSenateGaugeSubItems.IdSenateGaugeItem].ToString().Trim(); //量表指标流水号
objvSenateGaugeSubItemsEN.senateGaugeItemName = objRow[convSenateGaugeSubItems.senateGaugeItemName] == DBNull.Value ? null : objRow[convSenateGaugeSubItems.senateGaugeItemName].ToString().Trim(); //量表指标名称
objvSenateGaugeSubItemsEN.senateGaugeVersionName = objRow[convSenateGaugeSubItems.senateGaugeVersionName] == DBNull.Value ? null : objRow[convSenateGaugeSubItems.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称
objvSenateGaugeSubItemsEN.senateGaugeSubItemScore = objRow[convSenateGaugeSubItems.senateGaugeSubItemScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convSenateGaugeSubItems.senateGaugeSubItemScore].ToString().Trim()); //量表指标子项分数
objvSenateGaugeSubItemsEN.IdSenateGaugeVersion = objRow[convSenateGaugeSubItems.IdSenateGaugeVersion].ToString().Trim(); //评价量表版本流水号
objvSenateGaugeSubItemsEN.senateGaugeItemID = objRow[convSenateGaugeSubItems.senateGaugeItemID] == DBNull.Value ? null : objRow[convSenateGaugeSubItems.senateGaugeItemID].ToString().Trim(); //量表指标ID
objvSenateGaugeSubItemsEN.senateGaugeSubItemDesc = objRow[convSenateGaugeSubItems.senateGaugeSubItemDesc] == DBNull.Value ? null : objRow[convSenateGaugeSubItems.senateGaugeSubItemDesc].ToString().Trim(); //量表指标子项说明
objvSenateGaugeSubItemsEN.AnswerTitle = objRow[convSenateGaugeSubItems.AnswerTitle] == DBNull.Value ? null : objRow[convSenateGaugeSubItems.AnswerTitle].ToString().Trim(); //答案标题
objvSenateGaugeSubItemsEN.AnswerIndex = objRow[convSenateGaugeSubItems.AnswerIndex] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convSenateGaugeSubItems.AnswerIndex].ToString().Trim()); //问答序号
objvSenateGaugeSubItemsEN.senateGaugeItemDesc = objRow[convSenateGaugeSubItems.senateGaugeItemDesc] == DBNull.Value ? null : objRow[convSenateGaugeSubItems.senateGaugeItemDesc].ToString().Trim(); //量表指标说明
objvSenateGaugeSubItemsEN.senateGaugeItemWeight = objRow[convSenateGaugeSubItems.senateGaugeItemWeight] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convSenateGaugeSubItems.senateGaugeItemWeight].ToString().Trim()); //量表指标权重
objvSenateGaugeSubItemsEN.senateGaugeSubItemMemo = objRow[convSenateGaugeSubItems.senateGaugeSubItemMemo] == DBNull.Value ? null : objRow[convSenateGaugeSubItems.senateGaugeSubItemMemo].ToString().Trim(); //量表指标子项备注
objvSenateGaugeSubItemsEN.senateGaugeItemMemo = objRow[convSenateGaugeSubItems.senateGaugeItemMemo] == DBNull.Value ? null : objRow[convSenateGaugeSubItems.senateGaugeItemMemo].ToString().Trim(); //备注
objvSenateGaugeSubItemsEN.senateGaugeVersionID = objRow[convSenateGaugeSubItems.senateGaugeVersionID].ToString().Trim(); //评价量表版本ID
objvSenateGaugeSubItemsEN.senateGaugeVersionTtlScore = Single.Parse(objRow[convSenateGaugeSubItems.senateGaugeVersionTtlScore].ToString().Trim()); //评价量表版本总分
objvSenateGaugeSubItemsEN.senateGaugeSubItemAll = objRow[convSenateGaugeSubItems.senateGaugeSubItemAll] == DBNull.Value ? null : objRow[convSenateGaugeSubItems.senateGaugeSubItemAll].ToString().Trim(); //子项等地分数
objvSenateGaugeSubItemsEN.senateGaugeSubItemAll2 = objRow[convSenateGaugeSubItems.senateGaugeSubItemAll2] == DBNull.Value ? null : objRow[convSenateGaugeSubItems.senateGaugeSubItemAll2].ToString().Trim(); //senateGaugeSubItemAll2
objvSenateGaugeSubItemsEN.VersionNo = objRow[convSenateGaugeSubItems.VersionNo] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convSenateGaugeSubItems.VersionNo].ToString().Trim()); //版本号
objvSenateGaugeSubItemsEN.IsUse = clsEntityBase2.TransNullToBool_S(objRow[convSenateGaugeSubItems.IsUse].ToString().Trim()); //是否使用
objvSenateGaugeSubItemsEN.UpdDate = objRow[convSenateGaugeSubItems.UpdDate] == DBNull.Value ? null : objRow[convSenateGaugeSubItems.UpdDate].ToString().Trim(); //修改日期
objvSenateGaugeSubItemsEN.UpdUserId = objRow[convSenateGaugeSubItems.UpdUserId] == DBNull.Value ? null : objRow[convSenateGaugeSubItems.UpdUserId].ToString().Trim(); //修改用户Id
objvSenateGaugeSubItemsEN.AnswerModeId = objRow[convSenateGaugeSubItems.AnswerModeId] == DBNull.Value ? null : objRow[convSenateGaugeSubItems.AnswerModeId].ToString().Trim(); //答案模式Id
objvSenateGaugeSubItemsEN.AnswerModeName = objRow[convSenateGaugeSubItems.AnswerModeName] == DBNull.Value ? null : objRow[convSenateGaugeSubItems.AnswerModeName].ToString().Trim(); //答案模式名称
objvSenateGaugeSubItemsEN.AnswerNum = objRow[convSenateGaugeSubItems.AnswerNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convSenateGaugeSubItems.AnswerNum].ToString().Trim()); //答案数
objvSenateGaugeSubItemsEN.AnswerTypeId = objRow[convSenateGaugeSubItems.AnswerTypeId] == DBNull.Value ? null : objRow[convSenateGaugeSubItems.AnswerTypeId].ToString().Trim(); //答案类型ID
objvSenateGaugeSubItemsEN.AnswerTypeName = objRow[convSenateGaugeSubItems.AnswerTypeName] == DBNull.Value ? null : objRow[convSenateGaugeSubItems.AnswerTypeName].ToString().Trim(); //答案类型名
objvSenateGaugeSubItemsEN.GridTitle = objRow[convSenateGaugeSubItems.GridTitle] == DBNull.Value ? null : objRow[convSenateGaugeSubItems.GridTitle].ToString().Trim(); //表格标题
objvSenateGaugeSubItemsEN.IsHaveAdditionalMemo = clsEntityBase2.TransNullToBool_S(objRow[convSenateGaugeSubItems.IsHaveAdditionalMemo].ToString().Trim()); //是否有附加说明
objvSenateGaugeSubItemsEN.QuestionIndex = objRow[convSenateGaugeSubItems.QuestionIndex] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convSenateGaugeSubItems.QuestionIndex].ToString().Trim()); //题目序号
objvSenateGaugeSubItemsEN.QuestionNo = objRow[convSenateGaugeSubItems.QuestionNo] == DBNull.Value ? null : objRow[convSenateGaugeSubItems.QuestionNo].ToString().Trim(); //题目编号
objvSenateGaugeSubItemsEN.QuestionTypeId = objRow[convSenateGaugeSubItems.QuestionTypeId] == DBNull.Value ? null : objRow[convSenateGaugeSubItems.QuestionTypeId].ToString().Trim(); //题目类型Id
objvSenateGaugeSubItemsEN.QuestionTypeName = objRow[convSenateGaugeSubItems.QuestionTypeName] == DBNull.Value ? null : objRow[convSenateGaugeSubItems.QuestionTypeName].ToString().Trim(); //题目类型名
objvSenateGaugeSubItemsEN.senateGaugeItemNameWithOrder = objRow[convSenateGaugeSubItems.senateGaugeItemNameWithOrder] == DBNull.Value ? null : objRow[convSenateGaugeSubItems.senateGaugeItemNameWithOrder].ToString().Trim(); //量表指标名称WithOrder
objvSenateGaugeSubItemsEN.senateGaugeVersionMemo = objRow[convSenateGaugeSubItems.senateGaugeVersionMemo] == DBNull.Value ? null : objRow[convSenateGaugeSubItems.senateGaugeVersionMemo].ToString().Trim(); //评价量表版本说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvSenateGaugeSubItemsEN.IdSenateGaugeSubItem, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvSenateGaugeSubItemsEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objvSenateGaugeSubItemsEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetvSenateGaugeSubItems(ref clsvSenateGaugeSubItemsEN objvSenateGaugeSubItemsEN)
{
bool bolResult = vSenateGaugeSubItemsDA.GetvSenateGaugeSubItems(ref objvSenateGaugeSubItemsEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "strIdSenateGaugeSubItem">表关键字</param>
 /// <returns>表对象</returns>
public static clsvSenateGaugeSubItemsEN GetObjByIdSenateGaugeSubItem(string strIdSenateGaugeSubItem)
{
if (strIdSenateGaugeSubItem.IndexOf(' ') >=0)
{
var strMsg = string.Format("(errid:Busi000079)在表中,关键字[strIdSenateGaugeSubItem]中不能有空格!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
if (string.IsNullOrEmpty(strIdSenateGaugeSubItem) == true)
{
var strMsg = string.Format("(errid:Busi000020)在表中,关键字[strIdSenateGaugeSubItem]不能为空!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
clsvSenateGaugeSubItemsEN objvSenateGaugeSubItemsEN = vSenateGaugeSubItemsDA.GetObjByIdSenateGaugeSubItem(strIdSenateGaugeSubItem);
return objvSenateGaugeSubItemsEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsvSenateGaugeSubItemsEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsvSenateGaugeSubItemsEN objvSenateGaugeSubItemsEN = vSenateGaugeSubItemsDA.GetFirstObj(strWhereCond);
 return objvSenateGaugeSubItemsEN;
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
public static clsvSenateGaugeSubItemsEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsvSenateGaugeSubItemsEN objvSenateGaugeSubItemsEN = vSenateGaugeSubItemsDA.GetObjByDataRow(objRow);
 return objvSenateGaugeSubItemsEN;
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
public static clsvSenateGaugeSubItemsEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsvSenateGaugeSubItemsEN objvSenateGaugeSubItemsEN = vSenateGaugeSubItemsDA.GetObjByDataRow(objRow);
 return objvSenateGaugeSubItemsEN;
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
 /// <param name = "strIdSenateGaugeSubItem">所给的关键字</param>
 /// <param name = "lstvSenateGaugeSubItemsObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvSenateGaugeSubItemsEN GetObjByIdSenateGaugeSubItemFromList(string strIdSenateGaugeSubItem, List<clsvSenateGaugeSubItemsEN> lstvSenateGaugeSubItemsObjLst)
{
foreach (clsvSenateGaugeSubItemsEN objvSenateGaugeSubItemsEN in lstvSenateGaugeSubItemsObjLst)
{
if (objvSenateGaugeSubItemsEN.IdSenateGaugeSubItem == strIdSenateGaugeSubItem)
{
return objvSenateGaugeSubItemsEN;
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
 string strIdSenateGaugeSubItem;
 try
 {
 strIdSenateGaugeSubItem = new clsvSenateGaugeSubItemsDA().GetFirstID(strWhereCond);
 return strIdSenateGaugeSubItem;
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
 arrList = vSenateGaugeSubItemsDA.GetID(strWhereCond);
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
bool bolIsExist = vSenateGaugeSubItemsDA.IsExistCondRec(strWhereCond);
return bolIsExist;
}

 /// <summary>
 /// 判断当前表中是否存在给定关键字值的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExist)
 /// </summary>
 /// <param name = "strIdSenateGaugeSubItem">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public static bool IsExist(string strIdSenateGaugeSubItem)
{
if (string.IsNullOrEmpty(strIdSenateGaugeSubItem) == true)
{
var strMsg = string.Format("(errid:Busi000027)在表中,关键字[strIdSenateGaugeSubItem]不能为空!!(from {0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
//检测记录是否存在
bool bolIsExist = vSenateGaugeSubItemsDA.IsExist(strIdSenateGaugeSubItem);
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
 bolIsExist = clsvSenateGaugeSubItemsDA.IsExistTable();
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
 bolIsExist = vSenateGaugeSubItemsDA.IsExistTable(strTabName);
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
 /// <param name = "objvSenateGaugeSubItemsENS">源对象</param>
 /// <param name = "objvSenateGaugeSubItemsENT">目标对象</param>
 public static void CopyTo(clsvSenateGaugeSubItemsEN objvSenateGaugeSubItemsENS, clsvSenateGaugeSubItemsEN objvSenateGaugeSubItemsENT)
{
try
{
objvSenateGaugeSubItemsENT.IdSenateGaugeSubItem = objvSenateGaugeSubItemsENS.IdSenateGaugeSubItem; //量表指标子项流水号
objvSenateGaugeSubItemsENT.senateGaugeSubItemID = objvSenateGaugeSubItemsENS.senateGaugeSubItemID; //量表指标子项ID
objvSenateGaugeSubItemsENT.senateGaugeSubItemName = objvSenateGaugeSubItemsENS.senateGaugeSubItemName; //量表指标子项名称
objvSenateGaugeSubItemsENT.IdSenateGaugeItem = objvSenateGaugeSubItemsENS.IdSenateGaugeItem; //量表指标流水号
objvSenateGaugeSubItemsENT.senateGaugeItemName = objvSenateGaugeSubItemsENS.senateGaugeItemName; //量表指标名称
objvSenateGaugeSubItemsENT.senateGaugeVersionName = objvSenateGaugeSubItemsENS.senateGaugeVersionName; //评价量表版本名称
objvSenateGaugeSubItemsENT.senateGaugeSubItemScore = objvSenateGaugeSubItemsENS.senateGaugeSubItemScore; //量表指标子项分数
objvSenateGaugeSubItemsENT.IdSenateGaugeVersion = objvSenateGaugeSubItemsENS.IdSenateGaugeVersion; //评价量表版本流水号
objvSenateGaugeSubItemsENT.senateGaugeItemID = objvSenateGaugeSubItemsENS.senateGaugeItemID; //量表指标ID
objvSenateGaugeSubItemsENT.senateGaugeSubItemDesc = objvSenateGaugeSubItemsENS.senateGaugeSubItemDesc; //量表指标子项说明
objvSenateGaugeSubItemsENT.AnswerTitle = objvSenateGaugeSubItemsENS.AnswerTitle; //答案标题
objvSenateGaugeSubItemsENT.AnswerIndex = objvSenateGaugeSubItemsENS.AnswerIndex; //问答序号
objvSenateGaugeSubItemsENT.senateGaugeItemDesc = objvSenateGaugeSubItemsENS.senateGaugeItemDesc; //量表指标说明
objvSenateGaugeSubItemsENT.senateGaugeItemWeight = objvSenateGaugeSubItemsENS.senateGaugeItemWeight; //量表指标权重
objvSenateGaugeSubItemsENT.senateGaugeSubItemMemo = objvSenateGaugeSubItemsENS.senateGaugeSubItemMemo; //量表指标子项备注
objvSenateGaugeSubItemsENT.senateGaugeItemMemo = objvSenateGaugeSubItemsENS.senateGaugeItemMemo; //备注
objvSenateGaugeSubItemsENT.senateGaugeVersionID = objvSenateGaugeSubItemsENS.senateGaugeVersionID; //评价量表版本ID
objvSenateGaugeSubItemsENT.senateGaugeVersionTtlScore = objvSenateGaugeSubItemsENS.senateGaugeVersionTtlScore; //评价量表版本总分
objvSenateGaugeSubItemsENT.senateGaugeSubItemAll = objvSenateGaugeSubItemsENS.senateGaugeSubItemAll; //子项等地分数
objvSenateGaugeSubItemsENT.senateGaugeSubItemAll2 = objvSenateGaugeSubItemsENS.senateGaugeSubItemAll2; //senateGaugeSubItemAll2
objvSenateGaugeSubItemsENT.VersionNo = objvSenateGaugeSubItemsENS.VersionNo; //版本号
objvSenateGaugeSubItemsENT.IsUse = objvSenateGaugeSubItemsENS.IsUse; //是否使用
objvSenateGaugeSubItemsENT.UpdDate = objvSenateGaugeSubItemsENS.UpdDate; //修改日期
objvSenateGaugeSubItemsENT.UpdUserId = objvSenateGaugeSubItemsENS.UpdUserId; //修改用户Id
objvSenateGaugeSubItemsENT.AnswerModeId = objvSenateGaugeSubItemsENS.AnswerModeId; //答案模式Id
objvSenateGaugeSubItemsENT.AnswerModeName = objvSenateGaugeSubItemsENS.AnswerModeName; //答案模式名称
objvSenateGaugeSubItemsENT.AnswerNum = objvSenateGaugeSubItemsENS.AnswerNum; //答案数
objvSenateGaugeSubItemsENT.AnswerTypeId = objvSenateGaugeSubItemsENS.AnswerTypeId; //答案类型ID
objvSenateGaugeSubItemsENT.AnswerTypeName = objvSenateGaugeSubItemsENS.AnswerTypeName; //答案类型名
objvSenateGaugeSubItemsENT.GridTitle = objvSenateGaugeSubItemsENS.GridTitle; //表格标题
objvSenateGaugeSubItemsENT.IsHaveAdditionalMemo = objvSenateGaugeSubItemsENS.IsHaveAdditionalMemo; //是否有附加说明
objvSenateGaugeSubItemsENT.QuestionIndex = objvSenateGaugeSubItemsENS.QuestionIndex; //题目序号
objvSenateGaugeSubItemsENT.QuestionNo = objvSenateGaugeSubItemsENS.QuestionNo; //题目编号
objvSenateGaugeSubItemsENT.QuestionTypeId = objvSenateGaugeSubItemsENS.QuestionTypeId; //题目类型Id
objvSenateGaugeSubItemsENT.QuestionTypeName = objvSenateGaugeSubItemsENS.QuestionTypeName; //题目类型名
objvSenateGaugeSubItemsENT.senateGaugeItemNameWithOrder = objvSenateGaugeSubItemsENS.senateGaugeItemNameWithOrder; //量表指标名称WithOrder
objvSenateGaugeSubItemsENT.senateGaugeVersionMemo = objvSenateGaugeSubItemsENS.senateGaugeVersionMemo; //评价量表版本说明
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
 /// <param name = "objvSenateGaugeSubItemsEN">源简化对象</param>
 public static void SetUpdFlag(clsvSenateGaugeSubItemsEN objvSenateGaugeSubItemsEN)
{
try
{
objvSenateGaugeSubItemsEN.ClearUpdateState();
   string strsfUpdFldSetStr = objvSenateGaugeSubItemsEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(convSenateGaugeSubItems.IdSenateGaugeSubItem, new clsStrCompareIgnoreCase())  ==  true)
{
objvSenateGaugeSubItemsEN.IdSenateGaugeSubItem = objvSenateGaugeSubItemsEN.IdSenateGaugeSubItem; //量表指标子项流水号
}
if (arrFldSet.Contains(convSenateGaugeSubItems.senateGaugeSubItemID, new clsStrCompareIgnoreCase())  ==  true)
{
objvSenateGaugeSubItemsEN.senateGaugeSubItemID = objvSenateGaugeSubItemsEN.senateGaugeSubItemID == "[null]" ? null :  objvSenateGaugeSubItemsEN.senateGaugeSubItemID; //量表指标子项ID
}
if (arrFldSet.Contains(convSenateGaugeSubItems.senateGaugeSubItemName, new clsStrCompareIgnoreCase())  ==  true)
{
objvSenateGaugeSubItemsEN.senateGaugeSubItemName = objvSenateGaugeSubItemsEN.senateGaugeSubItemName == "[null]" ? null :  objvSenateGaugeSubItemsEN.senateGaugeSubItemName; //量表指标子项名称
}
if (arrFldSet.Contains(convSenateGaugeSubItems.IdSenateGaugeItem, new clsStrCompareIgnoreCase())  ==  true)
{
objvSenateGaugeSubItemsEN.IdSenateGaugeItem = objvSenateGaugeSubItemsEN.IdSenateGaugeItem; //量表指标流水号
}
if (arrFldSet.Contains(convSenateGaugeSubItems.senateGaugeItemName, new clsStrCompareIgnoreCase())  ==  true)
{
objvSenateGaugeSubItemsEN.senateGaugeItemName = objvSenateGaugeSubItemsEN.senateGaugeItemName == "[null]" ? null :  objvSenateGaugeSubItemsEN.senateGaugeItemName; //量表指标名称
}
if (arrFldSet.Contains(convSenateGaugeSubItems.senateGaugeVersionName, new clsStrCompareIgnoreCase())  ==  true)
{
objvSenateGaugeSubItemsEN.senateGaugeVersionName = objvSenateGaugeSubItemsEN.senateGaugeVersionName == "[null]" ? null :  objvSenateGaugeSubItemsEN.senateGaugeVersionName; //评价量表版本名称
}
if (arrFldSet.Contains(convSenateGaugeSubItems.senateGaugeSubItemScore, new clsStrCompareIgnoreCase())  ==  true)
{
objvSenateGaugeSubItemsEN.senateGaugeSubItemScore = objvSenateGaugeSubItemsEN.senateGaugeSubItemScore; //量表指标子项分数
}
if (arrFldSet.Contains(convSenateGaugeSubItems.IdSenateGaugeVersion, new clsStrCompareIgnoreCase())  ==  true)
{
objvSenateGaugeSubItemsEN.IdSenateGaugeVersion = objvSenateGaugeSubItemsEN.IdSenateGaugeVersion; //评价量表版本流水号
}
if (arrFldSet.Contains(convSenateGaugeSubItems.senateGaugeItemID, new clsStrCompareIgnoreCase())  ==  true)
{
objvSenateGaugeSubItemsEN.senateGaugeItemID = objvSenateGaugeSubItemsEN.senateGaugeItemID == "[null]" ? null :  objvSenateGaugeSubItemsEN.senateGaugeItemID; //量表指标ID
}
if (arrFldSet.Contains(convSenateGaugeSubItems.senateGaugeSubItemDesc, new clsStrCompareIgnoreCase())  ==  true)
{
objvSenateGaugeSubItemsEN.senateGaugeSubItemDesc = objvSenateGaugeSubItemsEN.senateGaugeSubItemDesc == "[null]" ? null :  objvSenateGaugeSubItemsEN.senateGaugeSubItemDesc; //量表指标子项说明
}
if (arrFldSet.Contains(convSenateGaugeSubItems.AnswerTitle, new clsStrCompareIgnoreCase())  ==  true)
{
objvSenateGaugeSubItemsEN.AnswerTitle = objvSenateGaugeSubItemsEN.AnswerTitle == "[null]" ? null :  objvSenateGaugeSubItemsEN.AnswerTitle; //答案标题
}
if (arrFldSet.Contains(convSenateGaugeSubItems.AnswerIndex, new clsStrCompareIgnoreCase())  ==  true)
{
objvSenateGaugeSubItemsEN.AnswerIndex = objvSenateGaugeSubItemsEN.AnswerIndex; //问答序号
}
if (arrFldSet.Contains(convSenateGaugeSubItems.senateGaugeItemDesc, new clsStrCompareIgnoreCase())  ==  true)
{
objvSenateGaugeSubItemsEN.senateGaugeItemDesc = objvSenateGaugeSubItemsEN.senateGaugeItemDesc == "[null]" ? null :  objvSenateGaugeSubItemsEN.senateGaugeItemDesc; //量表指标说明
}
if (arrFldSet.Contains(convSenateGaugeSubItems.senateGaugeItemWeight, new clsStrCompareIgnoreCase())  ==  true)
{
objvSenateGaugeSubItemsEN.senateGaugeItemWeight = objvSenateGaugeSubItemsEN.senateGaugeItemWeight; //量表指标权重
}
if (arrFldSet.Contains(convSenateGaugeSubItems.senateGaugeSubItemMemo, new clsStrCompareIgnoreCase())  ==  true)
{
objvSenateGaugeSubItemsEN.senateGaugeSubItemMemo = objvSenateGaugeSubItemsEN.senateGaugeSubItemMemo == "[null]" ? null :  objvSenateGaugeSubItemsEN.senateGaugeSubItemMemo; //量表指标子项备注
}
if (arrFldSet.Contains(convSenateGaugeSubItems.senateGaugeItemMemo, new clsStrCompareIgnoreCase())  ==  true)
{
objvSenateGaugeSubItemsEN.senateGaugeItemMemo = objvSenateGaugeSubItemsEN.senateGaugeItemMemo == "[null]" ? null :  objvSenateGaugeSubItemsEN.senateGaugeItemMemo; //备注
}
if (arrFldSet.Contains(convSenateGaugeSubItems.senateGaugeVersionID, new clsStrCompareIgnoreCase())  ==  true)
{
objvSenateGaugeSubItemsEN.senateGaugeVersionID = objvSenateGaugeSubItemsEN.senateGaugeVersionID; //评价量表版本ID
}
if (arrFldSet.Contains(convSenateGaugeSubItems.senateGaugeVersionTtlScore, new clsStrCompareIgnoreCase())  ==  true)
{
objvSenateGaugeSubItemsEN.senateGaugeVersionTtlScore = objvSenateGaugeSubItemsEN.senateGaugeVersionTtlScore; //评价量表版本总分
}
if (arrFldSet.Contains(convSenateGaugeSubItems.senateGaugeSubItemAll, new clsStrCompareIgnoreCase())  ==  true)
{
objvSenateGaugeSubItemsEN.senateGaugeSubItemAll = objvSenateGaugeSubItemsEN.senateGaugeSubItemAll == "[null]" ? null :  objvSenateGaugeSubItemsEN.senateGaugeSubItemAll; //子项等地分数
}
if (arrFldSet.Contains(convSenateGaugeSubItems.senateGaugeSubItemAll2, new clsStrCompareIgnoreCase())  ==  true)
{
objvSenateGaugeSubItemsEN.senateGaugeSubItemAll2 = objvSenateGaugeSubItemsEN.senateGaugeSubItemAll2 == "[null]" ? null :  objvSenateGaugeSubItemsEN.senateGaugeSubItemAll2; //senateGaugeSubItemAll2
}
if (arrFldSet.Contains(convSenateGaugeSubItems.VersionNo, new clsStrCompareIgnoreCase())  ==  true)
{
objvSenateGaugeSubItemsEN.VersionNo = objvSenateGaugeSubItemsEN.VersionNo; //版本号
}
if (arrFldSet.Contains(convSenateGaugeSubItems.IsUse, new clsStrCompareIgnoreCase())  ==  true)
{
objvSenateGaugeSubItemsEN.IsUse = objvSenateGaugeSubItemsEN.IsUse; //是否使用
}
if (arrFldSet.Contains(convSenateGaugeSubItems.UpdDate, new clsStrCompareIgnoreCase())  ==  true)
{
objvSenateGaugeSubItemsEN.UpdDate = objvSenateGaugeSubItemsEN.UpdDate == "[null]" ? null :  objvSenateGaugeSubItemsEN.UpdDate; //修改日期
}
if (arrFldSet.Contains(convSenateGaugeSubItems.UpdUserId, new clsStrCompareIgnoreCase())  ==  true)
{
objvSenateGaugeSubItemsEN.UpdUserId = objvSenateGaugeSubItemsEN.UpdUserId == "[null]" ? null :  objvSenateGaugeSubItemsEN.UpdUserId; //修改用户Id
}
if (arrFldSet.Contains(convSenateGaugeSubItems.AnswerModeId, new clsStrCompareIgnoreCase())  ==  true)
{
objvSenateGaugeSubItemsEN.AnswerModeId = objvSenateGaugeSubItemsEN.AnswerModeId == "[null]" ? null :  objvSenateGaugeSubItemsEN.AnswerModeId; //答案模式Id
}
if (arrFldSet.Contains(convSenateGaugeSubItems.AnswerModeName, new clsStrCompareIgnoreCase())  ==  true)
{
objvSenateGaugeSubItemsEN.AnswerModeName = objvSenateGaugeSubItemsEN.AnswerModeName == "[null]" ? null :  objvSenateGaugeSubItemsEN.AnswerModeName; //答案模式名称
}
if (arrFldSet.Contains(convSenateGaugeSubItems.AnswerNum, new clsStrCompareIgnoreCase())  ==  true)
{
objvSenateGaugeSubItemsEN.AnswerNum = objvSenateGaugeSubItemsEN.AnswerNum; //答案数
}
if (arrFldSet.Contains(convSenateGaugeSubItems.AnswerTypeId, new clsStrCompareIgnoreCase())  ==  true)
{
objvSenateGaugeSubItemsEN.AnswerTypeId = objvSenateGaugeSubItemsEN.AnswerTypeId == "[null]" ? null :  objvSenateGaugeSubItemsEN.AnswerTypeId; //答案类型ID
}
if (arrFldSet.Contains(convSenateGaugeSubItems.AnswerTypeName, new clsStrCompareIgnoreCase())  ==  true)
{
objvSenateGaugeSubItemsEN.AnswerTypeName = objvSenateGaugeSubItemsEN.AnswerTypeName == "[null]" ? null :  objvSenateGaugeSubItemsEN.AnswerTypeName; //答案类型名
}
if (arrFldSet.Contains(convSenateGaugeSubItems.GridTitle, new clsStrCompareIgnoreCase())  ==  true)
{
objvSenateGaugeSubItemsEN.GridTitle = objvSenateGaugeSubItemsEN.GridTitle == "[null]" ? null :  objvSenateGaugeSubItemsEN.GridTitle; //表格标题
}
if (arrFldSet.Contains(convSenateGaugeSubItems.IsHaveAdditionalMemo, new clsStrCompareIgnoreCase())  ==  true)
{
objvSenateGaugeSubItemsEN.IsHaveAdditionalMemo = objvSenateGaugeSubItemsEN.IsHaveAdditionalMemo; //是否有附加说明
}
if (arrFldSet.Contains(convSenateGaugeSubItems.QuestionIndex, new clsStrCompareIgnoreCase())  ==  true)
{
objvSenateGaugeSubItemsEN.QuestionIndex = objvSenateGaugeSubItemsEN.QuestionIndex; //题目序号
}
if (arrFldSet.Contains(convSenateGaugeSubItems.QuestionNo, new clsStrCompareIgnoreCase())  ==  true)
{
objvSenateGaugeSubItemsEN.QuestionNo = objvSenateGaugeSubItemsEN.QuestionNo == "[null]" ? null :  objvSenateGaugeSubItemsEN.QuestionNo; //题目编号
}
if (arrFldSet.Contains(convSenateGaugeSubItems.QuestionTypeId, new clsStrCompareIgnoreCase())  ==  true)
{
objvSenateGaugeSubItemsEN.QuestionTypeId = objvSenateGaugeSubItemsEN.QuestionTypeId == "[null]" ? null :  objvSenateGaugeSubItemsEN.QuestionTypeId; //题目类型Id
}
if (arrFldSet.Contains(convSenateGaugeSubItems.QuestionTypeName, new clsStrCompareIgnoreCase())  ==  true)
{
objvSenateGaugeSubItemsEN.QuestionTypeName = objvSenateGaugeSubItemsEN.QuestionTypeName == "[null]" ? null :  objvSenateGaugeSubItemsEN.QuestionTypeName; //题目类型名
}
if (arrFldSet.Contains(convSenateGaugeSubItems.senateGaugeItemNameWithOrder, new clsStrCompareIgnoreCase())  ==  true)
{
objvSenateGaugeSubItemsEN.senateGaugeItemNameWithOrder = objvSenateGaugeSubItemsEN.senateGaugeItemNameWithOrder == "[null]" ? null :  objvSenateGaugeSubItemsEN.senateGaugeItemNameWithOrder; //量表指标名称WithOrder
}
if (arrFldSet.Contains(convSenateGaugeSubItems.senateGaugeVersionMemo, new clsStrCompareIgnoreCase())  ==  true)
{
objvSenateGaugeSubItemsEN.senateGaugeVersionMemo = objvSenateGaugeSubItemsEN.senateGaugeVersionMemo == "[null]" ? null :  objvSenateGaugeSubItemsEN.senateGaugeVersionMemo; //评价量表版本说明
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
 /// <param name = "objvSenateGaugeSubItemsEN">源简化对象</param>
 public static void AccessFldValueNull(clsvSenateGaugeSubItemsEN objvSenateGaugeSubItemsEN)
{
try
{
if (objvSenateGaugeSubItemsEN.senateGaugeSubItemID == "[null]") objvSenateGaugeSubItemsEN.senateGaugeSubItemID = null; //量表指标子项ID
if (objvSenateGaugeSubItemsEN.senateGaugeSubItemName == "[null]") objvSenateGaugeSubItemsEN.senateGaugeSubItemName = null; //量表指标子项名称
if (objvSenateGaugeSubItemsEN.senateGaugeItemName == "[null]") objvSenateGaugeSubItemsEN.senateGaugeItemName = null; //量表指标名称
if (objvSenateGaugeSubItemsEN.senateGaugeVersionName == "[null]") objvSenateGaugeSubItemsEN.senateGaugeVersionName = null; //评价量表版本名称
if (objvSenateGaugeSubItemsEN.senateGaugeItemID == "[null]") objvSenateGaugeSubItemsEN.senateGaugeItemID = null; //量表指标ID
if (objvSenateGaugeSubItemsEN.senateGaugeSubItemDesc == "[null]") objvSenateGaugeSubItemsEN.senateGaugeSubItemDesc = null; //量表指标子项说明
if (objvSenateGaugeSubItemsEN.AnswerTitle == "[null]") objvSenateGaugeSubItemsEN.AnswerTitle = null; //答案标题
if (objvSenateGaugeSubItemsEN.senateGaugeItemDesc == "[null]") objvSenateGaugeSubItemsEN.senateGaugeItemDesc = null; //量表指标说明
if (objvSenateGaugeSubItemsEN.senateGaugeSubItemMemo == "[null]") objvSenateGaugeSubItemsEN.senateGaugeSubItemMemo = null; //量表指标子项备注
if (objvSenateGaugeSubItemsEN.senateGaugeItemMemo == "[null]") objvSenateGaugeSubItemsEN.senateGaugeItemMemo = null; //备注
if (objvSenateGaugeSubItemsEN.senateGaugeSubItemAll == "[null]") objvSenateGaugeSubItemsEN.senateGaugeSubItemAll = null; //子项等地分数
if (objvSenateGaugeSubItemsEN.senateGaugeSubItemAll2 == "[null]") objvSenateGaugeSubItemsEN.senateGaugeSubItemAll2 = null; //senateGaugeSubItemAll2
if (objvSenateGaugeSubItemsEN.UpdDate == "[null]") objvSenateGaugeSubItemsEN.UpdDate = null; //修改日期
if (objvSenateGaugeSubItemsEN.UpdUserId == "[null]") objvSenateGaugeSubItemsEN.UpdUserId = null; //修改用户Id
if (objvSenateGaugeSubItemsEN.AnswerModeId == "[null]") objvSenateGaugeSubItemsEN.AnswerModeId = null; //答案模式Id
if (objvSenateGaugeSubItemsEN.AnswerModeName == "[null]") objvSenateGaugeSubItemsEN.AnswerModeName = null; //答案模式名称
if (objvSenateGaugeSubItemsEN.AnswerTypeId == "[null]") objvSenateGaugeSubItemsEN.AnswerTypeId = null; //答案类型ID
if (objvSenateGaugeSubItemsEN.AnswerTypeName == "[null]") objvSenateGaugeSubItemsEN.AnswerTypeName = null; //答案类型名
if (objvSenateGaugeSubItemsEN.GridTitle == "[null]") objvSenateGaugeSubItemsEN.GridTitle = null; //表格标题
if (objvSenateGaugeSubItemsEN.QuestionNo == "[null]") objvSenateGaugeSubItemsEN.QuestionNo = null; //题目编号
if (objvSenateGaugeSubItemsEN.QuestionTypeId == "[null]") objvSenateGaugeSubItemsEN.QuestionTypeId = null; //题目类型Id
if (objvSenateGaugeSubItemsEN.QuestionTypeName == "[null]") objvSenateGaugeSubItemsEN.QuestionTypeName = null; //题目类型名
if (objvSenateGaugeSubItemsEN.senateGaugeItemNameWithOrder == "[null]") objvSenateGaugeSubItemsEN.senateGaugeItemNameWithOrder = null; //量表指标名称WithOrder
if (objvSenateGaugeSubItemsEN.senateGaugeVersionMemo == "[null]") objvSenateGaugeSubItemsEN.senateGaugeVersionMemo = null; //评价量表版本说明
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
public static void CheckProperty4Condition(clsvSenateGaugeSubItemsEN objvSenateGaugeSubItemsEN)
{
 vSenateGaugeSubItemsDA.CheckProperty4Condition(objvSenateGaugeSubItemsEN);
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
if (clsSenateGaugeSubItemsBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsSenateGaugeSubItemsBL没有刷新缓存机制(clsSenateGaugeSubItemsBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
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
//string strWhereCond = string.Format("1 = 1 order by IdSenateGaugeSubItem");
//if (arrvSenateGaugeSubItemsObjLstCache == null)
//{
//arrvSenateGaugeSubItemsObjLstCache = vSenateGaugeSubItemsDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "strIdSenateGaugeSubItem">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvSenateGaugeSubItemsEN GetObjByIdSenateGaugeSubItemCache(string strIdSenateGaugeSubItem)
{
//获取缓存中的对象列表
string strKey = string.Format("{0}", clsvSenateGaugeSubItemsEN._CurrTabName);
List<clsvSenateGaugeSubItemsEN> arrvSenateGaugeSubItemsObjLstCache = GetObjLstCache();
IEnumerable <clsvSenateGaugeSubItemsEN> arrvSenateGaugeSubItemsObjLst_Sel =
arrvSenateGaugeSubItemsObjLstCache
.Where(x=> x.IdSenateGaugeSubItem == strIdSenateGaugeSubItem 
);
if (arrvSenateGaugeSubItemsObjLst_Sel.Count() == 0)
{
   clsvSenateGaugeSubItemsEN obj = clsvSenateGaugeSubItemsBL.GetObjByIdSenateGaugeSubItem(strIdSenateGaugeSubItem);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
 }
return null;
}
return arrvSenateGaugeSubItemsObjLst_Sel.First();
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvSenateGaugeSubItemsEN> GetAllvSenateGaugeSubItemsObjLstCache()
{
//获取缓存中的对象列表
List<clsvSenateGaugeSubItemsEN> arrvSenateGaugeSubItemsObjLstCache = GetObjLstCache(); 
return arrvSenateGaugeSubItemsObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvSenateGaugeSubItemsEN> GetObjLstCache()
{
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}", clsvSenateGaugeSubItemsEN._CurrTabName);
List<clsvSenateGaugeSubItemsEN> arrvSenateGaugeSubItemsObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrvSenateGaugeSubItemsObjLstCache;
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
string strKey = string.Format("{0}", clsvSenateGaugeSubItemsEN._CurrTabName);
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
public static string Func(string strInFldName, string strOutFldName, string strIdSenateGaugeSubItem)
{
if (strInFldName != convSenateGaugeSubItems.IdSenateGaugeSubItem)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (convSenateGaugeSubItems.AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", convSenateGaugeSubItems.AttributeName));
throw new Exception(strMsg);
}
var objvSenateGaugeSubItems = clsvSenateGaugeSubItemsBL.GetObjByIdSenateGaugeSubItemCache(strIdSenateGaugeSubItem);
if (objvSenateGaugeSubItems == null) return "";
return objvSenateGaugeSubItems[strOutFldName].ToString();
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
int intRecCount = clsvSenateGaugeSubItemsDA.GetRecCount(strTabName);
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
int intRecCount = clsvSenateGaugeSubItemsDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsvSenateGaugeSubItemsDA.GetRecCount();
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
int intRecCount = clsvSenateGaugeSubItemsDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objvSenateGaugeSubItemsCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsvSenateGaugeSubItemsEN objvSenateGaugeSubItemsCond)
{
List<clsvSenateGaugeSubItemsEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsvSenateGaugeSubItemsEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convSenateGaugeSubItems.AttributeName)
{
if (objvSenateGaugeSubItemsCond.IsUpdated(strFldName) == false) continue;
if (objvSenateGaugeSubItemsCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvSenateGaugeSubItemsCond[strFldName].ToString());
}
else
{
if (objvSenateGaugeSubItemsCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvSenateGaugeSubItemsCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvSenateGaugeSubItemsCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvSenateGaugeSubItemsCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvSenateGaugeSubItemsCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvSenateGaugeSubItemsCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvSenateGaugeSubItemsCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvSenateGaugeSubItemsCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvSenateGaugeSubItemsCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvSenateGaugeSubItemsCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvSenateGaugeSubItemsCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvSenateGaugeSubItemsCond[strFldName]));
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
 List<string> arrList = clsvSenateGaugeSubItemsDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = vSenateGaugeSubItemsDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = vSenateGaugeSubItemsDA.GetFldValueNoDistinct(strFldName, strWhereCond);
return arrList;
}



 #endregion 表操作常用函数
}
}