
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvSenateGaugeSubItemsWApi
 表名:vSenateGaugeSubItems(01120479)
 生成代码版本:2021.09.20.1
 生成日期:2021/09/21 02:46:21
 生成者:pyf
 生成服务器IP:103.116.76.183
 工程名称:问卷调查
 工程ID:0112
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:评价相关参数
 模块英文名:SenateGaugePara
 框架-层名:WA_访问层_CS(WA_Access)
 编程语言:CSharp
 注意:1、需要数据底层(PubDataBase.dll)的版本:2019.03.07.01
        2、需要公共函数层(TzPubFunction.dll)的版本:2017.12.21.01
 == == == == == == == == == == == == 
 **/
using System;
using System.Data; 
using System.Data.SqlClient;
using System.Text; 
using System.Web;
using System.Collections; 
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using com.taishsoft.common;
using com.taishsoft.comm_db_obj;
using com.taishsoft.dynamiccompiler;
using com.taishsoft.json;
using ExamLib.Entity;

namespace ExamLib4WApi
{
public static class clsvSenateGaugeSubItemsWApi_Static
{

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSenateGaugeSubItemsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvSenateGaugeSubItemsEN Setid_SenateGaugeSubItem(this clsvSenateGaugeSubItemsEN objvSenateGaugeSubItemsEN, string strid_SenateGaugeSubItem, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_SenateGaugeSubItem, 4, convSenateGaugeSubItems.id_SenateGaugeSubItem);
clsCheckSql.CheckFieldForeignKey(strid_SenateGaugeSubItem, 4, convSenateGaugeSubItems.id_SenateGaugeSubItem);
objvSenateGaugeSubItemsEN.id_SenateGaugeSubItem = strid_SenateGaugeSubItem; //量表指标子项流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvSenateGaugeSubItemsEN.dicFldComparisonOp.ContainsKey(convSenateGaugeSubItems.id_SenateGaugeSubItem) == false)
{
objvSenateGaugeSubItemsEN.dicFldComparisonOp.Add(convSenateGaugeSubItems.id_SenateGaugeSubItem, strComparisonOp);
}
else
{
objvSenateGaugeSubItemsEN.dicFldComparisonOp[convSenateGaugeSubItems.id_SenateGaugeSubItem] = strComparisonOp;
}
}
return objvSenateGaugeSubItemsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSenateGaugeSubItemsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvSenateGaugeSubItemsEN SetsenateGaugeSubItemID(this clsvSenateGaugeSubItemsEN objvSenateGaugeSubItemsEN, string strsenateGaugeSubItemID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strsenateGaugeSubItemID, 4, convSenateGaugeSubItems.senateGaugeSubItemID);
clsCheckSql.CheckFieldForeignKey(strsenateGaugeSubItemID, 4, convSenateGaugeSubItems.senateGaugeSubItemID);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSenateGaugeSubItemsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvSenateGaugeSubItemsEN SetsenateGaugeSubItemName(this clsvSenateGaugeSubItemsEN objvSenateGaugeSubItemsEN, string strsenateGaugeSubItemName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strsenateGaugeSubItemName, 200, convSenateGaugeSubItems.senateGaugeSubItemName);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSenateGaugeSubItemsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvSenateGaugeSubItemsEN Setid_SenateGaugeItem(this clsvSenateGaugeSubItemsEN objvSenateGaugeSubItemsEN, string strid_SenateGaugeItem, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strid_SenateGaugeItem, convSenateGaugeSubItems.id_SenateGaugeItem);
clsCheckSql.CheckFieldLen(strid_SenateGaugeItem, 4, convSenateGaugeSubItems.id_SenateGaugeItem);
clsCheckSql.CheckFieldForeignKey(strid_SenateGaugeItem, 4, convSenateGaugeSubItems.id_SenateGaugeItem);
objvSenateGaugeSubItemsEN.id_SenateGaugeItem = strid_SenateGaugeItem; //量表指标流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvSenateGaugeSubItemsEN.dicFldComparisonOp.ContainsKey(convSenateGaugeSubItems.id_SenateGaugeItem) == false)
{
objvSenateGaugeSubItemsEN.dicFldComparisonOp.Add(convSenateGaugeSubItems.id_SenateGaugeItem, strComparisonOp);
}
else
{
objvSenateGaugeSubItemsEN.dicFldComparisonOp[convSenateGaugeSubItems.id_SenateGaugeItem] = strComparisonOp;
}
}
return objvSenateGaugeSubItemsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSenateGaugeSubItemsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvSenateGaugeSubItemsEN SetsenateGaugeItemName(this clsvSenateGaugeSubItemsEN objvSenateGaugeSubItemsEN, string strsenateGaugeItemName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strsenateGaugeItemName, 200, convSenateGaugeSubItems.senateGaugeItemName);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSenateGaugeSubItemsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvSenateGaugeSubItemsEN SetsenateGaugeVersionName(this clsvSenateGaugeSubItemsEN objvSenateGaugeSubItemsEN, string strsenateGaugeVersionName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strsenateGaugeVersionName, 200, convSenateGaugeSubItems.senateGaugeVersionName);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSenateGaugeSubItemsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvSenateGaugeSubItemsEN SetsenateGaugeSubItemScore(this clsvSenateGaugeSubItemsEN objvSenateGaugeSubItemsEN, float fltsenateGaugeSubItemScore, string strComparisonOp="")
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSenateGaugeSubItemsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvSenateGaugeSubItemsEN Setid_SenateGaugeVersion(this clsvSenateGaugeSubItemsEN objvSenateGaugeSubItemsEN, string strid_SenateGaugeVersion, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strid_SenateGaugeVersion, convSenateGaugeSubItems.id_SenateGaugeVersion);
clsCheckSql.CheckFieldLen(strid_SenateGaugeVersion, 4, convSenateGaugeSubItems.id_SenateGaugeVersion);
clsCheckSql.CheckFieldForeignKey(strid_SenateGaugeVersion, 4, convSenateGaugeSubItems.id_SenateGaugeVersion);
objvSenateGaugeSubItemsEN.id_SenateGaugeVersion = strid_SenateGaugeVersion; //评价量表版本流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvSenateGaugeSubItemsEN.dicFldComparisonOp.ContainsKey(convSenateGaugeSubItems.id_SenateGaugeVersion) == false)
{
objvSenateGaugeSubItemsEN.dicFldComparisonOp.Add(convSenateGaugeSubItems.id_SenateGaugeVersion, strComparisonOp);
}
else
{
objvSenateGaugeSubItemsEN.dicFldComparisonOp[convSenateGaugeSubItems.id_SenateGaugeVersion] = strComparisonOp;
}
}
return objvSenateGaugeSubItemsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSenateGaugeSubItemsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvSenateGaugeSubItemsEN SetsenateGaugeItemID(this clsvSenateGaugeSubItemsEN objvSenateGaugeSubItemsEN, string strsenateGaugeItemID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strsenateGaugeItemID, 4, convSenateGaugeSubItems.senateGaugeItemID);
clsCheckSql.CheckFieldForeignKey(strsenateGaugeItemID, 4, convSenateGaugeSubItems.senateGaugeItemID);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSenateGaugeSubItemsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvSenateGaugeSubItemsEN SetsenateGaugeSubItemDesc(this clsvSenateGaugeSubItemsEN objvSenateGaugeSubItemsEN, string strsenateGaugeSubItemDesc, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strsenateGaugeSubItemDesc, 2000, convSenateGaugeSubItems.senateGaugeSubItemDesc);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSenateGaugeSubItemsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvSenateGaugeSubItemsEN SetAnswerTitle(this clsvSenateGaugeSubItemsEN objvSenateGaugeSubItemsEN, string strAnswerTitle, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strAnswerTitle, 20, convSenateGaugeSubItems.AnswerTitle);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSenateGaugeSubItemsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvSenateGaugeSubItemsEN SetAnswerIndex(this clsvSenateGaugeSubItemsEN objvSenateGaugeSubItemsEN, int intAnswerIndex, string strComparisonOp="")
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSenateGaugeSubItemsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvSenateGaugeSubItemsEN SetsenateGaugeItemDesc(this clsvSenateGaugeSubItemsEN objvSenateGaugeSubItemsEN, string strsenateGaugeItemDesc, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strsenateGaugeItemDesc, 2000, convSenateGaugeSubItems.senateGaugeItemDesc);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSenateGaugeSubItemsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvSenateGaugeSubItemsEN SetsenateGaugeItemWeight(this clsvSenateGaugeSubItemsEN objvSenateGaugeSubItemsEN, float fltsenateGaugeItemWeight, string strComparisonOp="")
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSenateGaugeSubItemsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvSenateGaugeSubItemsEN SetsenateGaugeSubItemMemo(this clsvSenateGaugeSubItemsEN objvSenateGaugeSubItemsEN, string strsenateGaugeSubItemMemo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strsenateGaugeSubItemMemo, 1000, convSenateGaugeSubItems.senateGaugeSubItemMemo);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSenateGaugeSubItemsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvSenateGaugeSubItemsEN SetsenateGaugeItemMemo(this clsvSenateGaugeSubItemsEN objvSenateGaugeSubItemsEN, string strsenateGaugeItemMemo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strsenateGaugeItemMemo, 1000, convSenateGaugeSubItems.senateGaugeItemMemo);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSenateGaugeSubItemsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvSenateGaugeSubItemsEN SetsenateGaugeVersionID(this clsvSenateGaugeSubItemsEN objvSenateGaugeSubItemsEN, string strsenateGaugeVersionID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strsenateGaugeVersionID, convSenateGaugeSubItems.senateGaugeVersionID);
clsCheckSql.CheckFieldLen(strsenateGaugeVersionID, 4, convSenateGaugeSubItems.senateGaugeVersionID);
clsCheckSql.CheckFieldForeignKey(strsenateGaugeVersionID, 4, convSenateGaugeSubItems.senateGaugeVersionID);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSenateGaugeSubItemsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSenateGaugeSubItemsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvSenateGaugeSubItemsEN SetsenateGaugeSubItemAll(this clsvSenateGaugeSubItemsEN objvSenateGaugeSubItemsEN, string strsenateGaugeSubItemAll, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strsenateGaugeSubItemAll, 230, convSenateGaugeSubItems.senateGaugeSubItemAll);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSenateGaugeSubItemsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvSenateGaugeSubItemsEN SetsenateGaugeSubItemAll2(this clsvSenateGaugeSubItemsEN objvSenateGaugeSubItemsEN, string strsenateGaugeSubItemAll2, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strsenateGaugeSubItemAll2, 2235, convSenateGaugeSubItems.senateGaugeSubItemAll2);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSenateGaugeSubItemsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvSenateGaugeSubItemsEN SetVersionNo(this clsvSenateGaugeSubItemsEN objvSenateGaugeSubItemsEN, int intVersionNo, string strComparisonOp="")
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSenateGaugeSubItemsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSenateGaugeSubItemsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvSenateGaugeSubItemsEN SetUpdDate(this clsvSenateGaugeSubItemsEN objvSenateGaugeSubItemsEN, string strUpdDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdDate, 20, convSenateGaugeSubItems.UpdDate);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSenateGaugeSubItemsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvSenateGaugeSubItemsEN SetUpdUserId(this clsvSenateGaugeSubItemsEN objvSenateGaugeSubItemsEN, string strUpdUserId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdUserId, 20, convSenateGaugeSubItems.UpdUserId);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSenateGaugeSubItemsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvSenateGaugeSubItemsEN SetAnswerModeId(this clsvSenateGaugeSubItemsEN objvSenateGaugeSubItemsEN, string strAnswerModeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strAnswerModeId, 4, convSenateGaugeSubItems.AnswerModeId);
clsCheckSql.CheckFieldForeignKey(strAnswerModeId, 4, convSenateGaugeSubItems.AnswerModeId);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSenateGaugeSubItemsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvSenateGaugeSubItemsEN SetAnswerModeName(this clsvSenateGaugeSubItemsEN objvSenateGaugeSubItemsEN, string strAnswerModeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strAnswerModeName, 30, convSenateGaugeSubItems.AnswerModeName);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSenateGaugeSubItemsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvSenateGaugeSubItemsEN SetAnswerNum(this clsvSenateGaugeSubItemsEN objvSenateGaugeSubItemsEN, int intAnswerNum, string strComparisonOp="")
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSenateGaugeSubItemsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvSenateGaugeSubItemsEN SetAnswerTypeId(this clsvSenateGaugeSubItemsEN objvSenateGaugeSubItemsEN, string strAnswerTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strAnswerTypeId, 2, convSenateGaugeSubItems.AnswerTypeId);
clsCheckSql.CheckFieldForeignKey(strAnswerTypeId, 2, convSenateGaugeSubItems.AnswerTypeId);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSenateGaugeSubItemsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvSenateGaugeSubItemsEN SetAnswerTypeName(this clsvSenateGaugeSubItemsEN objvSenateGaugeSubItemsEN, string strAnswerTypeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strAnswerTypeName, 50, convSenateGaugeSubItems.AnswerTypeName);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSenateGaugeSubItemsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvSenateGaugeSubItemsEN SetGridTitle(this clsvSenateGaugeSubItemsEN objvSenateGaugeSubItemsEN, string strGridTitle, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strGridTitle, 30, convSenateGaugeSubItems.GridTitle);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSenateGaugeSubItemsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSenateGaugeSubItemsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvSenateGaugeSubItemsEN SetQuestionIndex(this clsvSenateGaugeSubItemsEN objvSenateGaugeSubItemsEN, int intQuestionIndex, string strComparisonOp="")
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSenateGaugeSubItemsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvSenateGaugeSubItemsEN SetQuestionNo(this clsvSenateGaugeSubItemsEN objvSenateGaugeSubItemsEN, string strQuestionNo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strQuestionNo, 10, convSenateGaugeSubItems.QuestionNo);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSenateGaugeSubItemsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvSenateGaugeSubItemsEN SetQuestionTypeId(this clsvSenateGaugeSubItemsEN objvSenateGaugeSubItemsEN, string strQuestionTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strQuestionTypeId, 2, convSenateGaugeSubItems.QuestionTypeId);
clsCheckSql.CheckFieldForeignKey(strQuestionTypeId, 2, convSenateGaugeSubItems.QuestionTypeId);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSenateGaugeSubItemsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvSenateGaugeSubItemsEN SetQuestionTypeName(this clsvSenateGaugeSubItemsEN objvSenateGaugeSubItemsEN, string strQuestionTypeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strQuestionTypeName, 20, convSenateGaugeSubItems.QuestionTypeName);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSenateGaugeSubItemsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvSenateGaugeSubItemsEN SetsenateGaugeItemNameWithOrder(this clsvSenateGaugeSubItemsEN objvSenateGaugeSubItemsEN, string strsenateGaugeItemNameWithOrder, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strsenateGaugeItemNameWithOrder, 204, convSenateGaugeSubItems.senateGaugeItemNameWithOrder);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSenateGaugeSubItemsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvSenateGaugeSubItemsEN SetsenateGaugeVersionMemo(this clsvSenateGaugeSubItemsEN objvSenateGaugeSubItemsEN, string strsenateGaugeVersionMemo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strsenateGaugeVersionMemo, 1000, convSenateGaugeSubItems.senateGaugeVersionMemo);
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
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvSenateGaugeSubItemsEN objvSenateGaugeSubItems_Cond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvSenateGaugeSubItems_Cond.IsUpdated(convSenateGaugeSubItems.id_SenateGaugeSubItem) == true)
{
string strComparisonOp_id_SenateGaugeSubItem = objvSenateGaugeSubItems_Cond.dicFldComparisonOp[convSenateGaugeSubItems.id_SenateGaugeSubItem];
strWhereCond += string.Format(" And {0} {2} '{1}'", convSenateGaugeSubItems.id_SenateGaugeSubItem, objvSenateGaugeSubItems_Cond.id_SenateGaugeSubItem, strComparisonOp_id_SenateGaugeSubItem);
}
if (objvSenateGaugeSubItems_Cond.IsUpdated(convSenateGaugeSubItems.senateGaugeSubItemID) == true)
{
string strComparisonOp_senateGaugeSubItemID = objvSenateGaugeSubItems_Cond.dicFldComparisonOp[convSenateGaugeSubItems.senateGaugeSubItemID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convSenateGaugeSubItems.senateGaugeSubItemID, objvSenateGaugeSubItems_Cond.senateGaugeSubItemID, strComparisonOp_senateGaugeSubItemID);
}
if (objvSenateGaugeSubItems_Cond.IsUpdated(convSenateGaugeSubItems.senateGaugeSubItemName) == true)
{
string strComparisonOp_senateGaugeSubItemName = objvSenateGaugeSubItems_Cond.dicFldComparisonOp[convSenateGaugeSubItems.senateGaugeSubItemName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convSenateGaugeSubItems.senateGaugeSubItemName, objvSenateGaugeSubItems_Cond.senateGaugeSubItemName, strComparisonOp_senateGaugeSubItemName);
}
if (objvSenateGaugeSubItems_Cond.IsUpdated(convSenateGaugeSubItems.id_SenateGaugeItem) == true)
{
string strComparisonOp_id_SenateGaugeItem = objvSenateGaugeSubItems_Cond.dicFldComparisonOp[convSenateGaugeSubItems.id_SenateGaugeItem];
strWhereCond += string.Format(" And {0} {2} '{1}'", convSenateGaugeSubItems.id_SenateGaugeItem, objvSenateGaugeSubItems_Cond.id_SenateGaugeItem, strComparisonOp_id_SenateGaugeItem);
}
if (objvSenateGaugeSubItems_Cond.IsUpdated(convSenateGaugeSubItems.senateGaugeItemName) == true)
{
string strComparisonOp_senateGaugeItemName = objvSenateGaugeSubItems_Cond.dicFldComparisonOp[convSenateGaugeSubItems.senateGaugeItemName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convSenateGaugeSubItems.senateGaugeItemName, objvSenateGaugeSubItems_Cond.senateGaugeItemName, strComparisonOp_senateGaugeItemName);
}
if (objvSenateGaugeSubItems_Cond.IsUpdated(convSenateGaugeSubItems.senateGaugeVersionName) == true)
{
string strComparisonOp_senateGaugeVersionName = objvSenateGaugeSubItems_Cond.dicFldComparisonOp[convSenateGaugeSubItems.senateGaugeVersionName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convSenateGaugeSubItems.senateGaugeVersionName, objvSenateGaugeSubItems_Cond.senateGaugeVersionName, strComparisonOp_senateGaugeVersionName);
}
if (objvSenateGaugeSubItems_Cond.IsUpdated(convSenateGaugeSubItems.senateGaugeSubItemScore) == true)
{
string strComparisonOp_senateGaugeSubItemScore = objvSenateGaugeSubItems_Cond.dicFldComparisonOp[convSenateGaugeSubItems.senateGaugeSubItemScore];
strWhereCond += string.Format(" And {0} {2} {1}", convSenateGaugeSubItems.senateGaugeSubItemScore, objvSenateGaugeSubItems_Cond.senateGaugeSubItemScore, strComparisonOp_senateGaugeSubItemScore);
}
if (objvSenateGaugeSubItems_Cond.IsUpdated(convSenateGaugeSubItems.id_SenateGaugeVersion) == true)
{
string strComparisonOp_id_SenateGaugeVersion = objvSenateGaugeSubItems_Cond.dicFldComparisonOp[convSenateGaugeSubItems.id_SenateGaugeVersion];
strWhereCond += string.Format(" And {0} {2} '{1}'", convSenateGaugeSubItems.id_SenateGaugeVersion, objvSenateGaugeSubItems_Cond.id_SenateGaugeVersion, strComparisonOp_id_SenateGaugeVersion);
}
if (objvSenateGaugeSubItems_Cond.IsUpdated(convSenateGaugeSubItems.senateGaugeItemID) == true)
{
string strComparisonOp_senateGaugeItemID = objvSenateGaugeSubItems_Cond.dicFldComparisonOp[convSenateGaugeSubItems.senateGaugeItemID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convSenateGaugeSubItems.senateGaugeItemID, objvSenateGaugeSubItems_Cond.senateGaugeItemID, strComparisonOp_senateGaugeItemID);
}
if (objvSenateGaugeSubItems_Cond.IsUpdated(convSenateGaugeSubItems.senateGaugeSubItemDesc) == true)
{
string strComparisonOp_senateGaugeSubItemDesc = objvSenateGaugeSubItems_Cond.dicFldComparisonOp[convSenateGaugeSubItems.senateGaugeSubItemDesc];
strWhereCond += string.Format(" And {0} {2} '{1}'", convSenateGaugeSubItems.senateGaugeSubItemDesc, objvSenateGaugeSubItems_Cond.senateGaugeSubItemDesc, strComparisonOp_senateGaugeSubItemDesc);
}
if (objvSenateGaugeSubItems_Cond.IsUpdated(convSenateGaugeSubItems.AnswerTitle) == true)
{
string strComparisonOp_AnswerTitle = objvSenateGaugeSubItems_Cond.dicFldComparisonOp[convSenateGaugeSubItems.AnswerTitle];
strWhereCond += string.Format(" And {0} {2} '{1}'", convSenateGaugeSubItems.AnswerTitle, objvSenateGaugeSubItems_Cond.AnswerTitle, strComparisonOp_AnswerTitle);
}
if (objvSenateGaugeSubItems_Cond.IsUpdated(convSenateGaugeSubItems.AnswerIndex) == true)
{
string strComparisonOp_AnswerIndex = objvSenateGaugeSubItems_Cond.dicFldComparisonOp[convSenateGaugeSubItems.AnswerIndex];
strWhereCond += string.Format(" And {0} {2} {1}", convSenateGaugeSubItems.AnswerIndex, objvSenateGaugeSubItems_Cond.AnswerIndex, strComparisonOp_AnswerIndex);
}
if (objvSenateGaugeSubItems_Cond.IsUpdated(convSenateGaugeSubItems.senateGaugeItemDesc) == true)
{
string strComparisonOp_senateGaugeItemDesc = objvSenateGaugeSubItems_Cond.dicFldComparisonOp[convSenateGaugeSubItems.senateGaugeItemDesc];
strWhereCond += string.Format(" And {0} {2} '{1}'", convSenateGaugeSubItems.senateGaugeItemDesc, objvSenateGaugeSubItems_Cond.senateGaugeItemDesc, strComparisonOp_senateGaugeItemDesc);
}
if (objvSenateGaugeSubItems_Cond.IsUpdated(convSenateGaugeSubItems.senateGaugeItemWeight) == true)
{
string strComparisonOp_senateGaugeItemWeight = objvSenateGaugeSubItems_Cond.dicFldComparisonOp[convSenateGaugeSubItems.senateGaugeItemWeight];
strWhereCond += string.Format(" And {0} {2} {1}", convSenateGaugeSubItems.senateGaugeItemWeight, objvSenateGaugeSubItems_Cond.senateGaugeItemWeight, strComparisonOp_senateGaugeItemWeight);
}
if (objvSenateGaugeSubItems_Cond.IsUpdated(convSenateGaugeSubItems.senateGaugeSubItemMemo) == true)
{
string strComparisonOp_senateGaugeSubItemMemo = objvSenateGaugeSubItems_Cond.dicFldComparisonOp[convSenateGaugeSubItems.senateGaugeSubItemMemo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convSenateGaugeSubItems.senateGaugeSubItemMemo, objvSenateGaugeSubItems_Cond.senateGaugeSubItemMemo, strComparisonOp_senateGaugeSubItemMemo);
}
if (objvSenateGaugeSubItems_Cond.IsUpdated(convSenateGaugeSubItems.senateGaugeItemMemo) == true)
{
string strComparisonOp_senateGaugeItemMemo = objvSenateGaugeSubItems_Cond.dicFldComparisonOp[convSenateGaugeSubItems.senateGaugeItemMemo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convSenateGaugeSubItems.senateGaugeItemMemo, objvSenateGaugeSubItems_Cond.senateGaugeItemMemo, strComparisonOp_senateGaugeItemMemo);
}
if (objvSenateGaugeSubItems_Cond.IsUpdated(convSenateGaugeSubItems.senateGaugeVersionID) == true)
{
string strComparisonOp_senateGaugeVersionID = objvSenateGaugeSubItems_Cond.dicFldComparisonOp[convSenateGaugeSubItems.senateGaugeVersionID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convSenateGaugeSubItems.senateGaugeVersionID, objvSenateGaugeSubItems_Cond.senateGaugeVersionID, strComparisonOp_senateGaugeVersionID);
}
if (objvSenateGaugeSubItems_Cond.IsUpdated(convSenateGaugeSubItems.senateGaugeVersionTtlScore) == true)
{
string strComparisonOp_senateGaugeVersionTtlScore = objvSenateGaugeSubItems_Cond.dicFldComparisonOp[convSenateGaugeSubItems.senateGaugeVersionTtlScore];
strWhereCond += string.Format(" And {0} {2} {1}", convSenateGaugeSubItems.senateGaugeVersionTtlScore, objvSenateGaugeSubItems_Cond.senateGaugeVersionTtlScore, strComparisonOp_senateGaugeVersionTtlScore);
}
if (objvSenateGaugeSubItems_Cond.IsUpdated(convSenateGaugeSubItems.senateGaugeSubItemAll) == true)
{
string strComparisonOp_senateGaugeSubItemAll = objvSenateGaugeSubItems_Cond.dicFldComparisonOp[convSenateGaugeSubItems.senateGaugeSubItemAll];
strWhereCond += string.Format(" And {0} {2} '{1}'", convSenateGaugeSubItems.senateGaugeSubItemAll, objvSenateGaugeSubItems_Cond.senateGaugeSubItemAll, strComparisonOp_senateGaugeSubItemAll);
}
if (objvSenateGaugeSubItems_Cond.IsUpdated(convSenateGaugeSubItems.senateGaugeSubItemAll2) == true)
{
string strComparisonOp_senateGaugeSubItemAll2 = objvSenateGaugeSubItems_Cond.dicFldComparisonOp[convSenateGaugeSubItems.senateGaugeSubItemAll2];
strWhereCond += string.Format(" And {0} {2} '{1}'", convSenateGaugeSubItems.senateGaugeSubItemAll2, objvSenateGaugeSubItems_Cond.senateGaugeSubItemAll2, strComparisonOp_senateGaugeSubItemAll2);
}
if (objvSenateGaugeSubItems_Cond.IsUpdated(convSenateGaugeSubItems.VersionNo) == true)
{
string strComparisonOp_VersionNo = objvSenateGaugeSubItems_Cond.dicFldComparisonOp[convSenateGaugeSubItems.VersionNo];
strWhereCond += string.Format(" And {0} {2} {1}", convSenateGaugeSubItems.VersionNo, objvSenateGaugeSubItems_Cond.VersionNo, strComparisonOp_VersionNo);
}
if (objvSenateGaugeSubItems_Cond.IsUpdated(convSenateGaugeSubItems.IsUse) == true)
{
if (objvSenateGaugeSubItems_Cond.IsUse == true)
{
strWhereCond += string.Format(" And {0} = '1'", convSenateGaugeSubItems.IsUse);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convSenateGaugeSubItems.IsUse);
}
}
if (objvSenateGaugeSubItems_Cond.IsUpdated(convSenateGaugeSubItems.UpdDate) == true)
{
string strComparisonOp_UpdDate = objvSenateGaugeSubItems_Cond.dicFldComparisonOp[convSenateGaugeSubItems.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convSenateGaugeSubItems.UpdDate, objvSenateGaugeSubItems_Cond.UpdDate, strComparisonOp_UpdDate);
}
if (objvSenateGaugeSubItems_Cond.IsUpdated(convSenateGaugeSubItems.UpdUserId) == true)
{
string strComparisonOp_UpdUserId = objvSenateGaugeSubItems_Cond.dicFldComparisonOp[convSenateGaugeSubItems.UpdUserId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convSenateGaugeSubItems.UpdUserId, objvSenateGaugeSubItems_Cond.UpdUserId, strComparisonOp_UpdUserId);
}
if (objvSenateGaugeSubItems_Cond.IsUpdated(convSenateGaugeSubItems.AnswerModeId) == true)
{
string strComparisonOp_AnswerModeId = objvSenateGaugeSubItems_Cond.dicFldComparisonOp[convSenateGaugeSubItems.AnswerModeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convSenateGaugeSubItems.AnswerModeId, objvSenateGaugeSubItems_Cond.AnswerModeId, strComparisonOp_AnswerModeId);
}
if (objvSenateGaugeSubItems_Cond.IsUpdated(convSenateGaugeSubItems.AnswerModeName) == true)
{
string strComparisonOp_AnswerModeName = objvSenateGaugeSubItems_Cond.dicFldComparisonOp[convSenateGaugeSubItems.AnswerModeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convSenateGaugeSubItems.AnswerModeName, objvSenateGaugeSubItems_Cond.AnswerModeName, strComparisonOp_AnswerModeName);
}
if (objvSenateGaugeSubItems_Cond.IsUpdated(convSenateGaugeSubItems.AnswerNum) == true)
{
string strComparisonOp_AnswerNum = objvSenateGaugeSubItems_Cond.dicFldComparisonOp[convSenateGaugeSubItems.AnswerNum];
strWhereCond += string.Format(" And {0} {2} {1}", convSenateGaugeSubItems.AnswerNum, objvSenateGaugeSubItems_Cond.AnswerNum, strComparisonOp_AnswerNum);
}
if (objvSenateGaugeSubItems_Cond.IsUpdated(convSenateGaugeSubItems.AnswerTypeId) == true)
{
string strComparisonOp_AnswerTypeId = objvSenateGaugeSubItems_Cond.dicFldComparisonOp[convSenateGaugeSubItems.AnswerTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convSenateGaugeSubItems.AnswerTypeId, objvSenateGaugeSubItems_Cond.AnswerTypeId, strComparisonOp_AnswerTypeId);
}
if (objvSenateGaugeSubItems_Cond.IsUpdated(convSenateGaugeSubItems.AnswerTypeName) == true)
{
string strComparisonOp_AnswerTypeName = objvSenateGaugeSubItems_Cond.dicFldComparisonOp[convSenateGaugeSubItems.AnswerTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convSenateGaugeSubItems.AnswerTypeName, objvSenateGaugeSubItems_Cond.AnswerTypeName, strComparisonOp_AnswerTypeName);
}
if (objvSenateGaugeSubItems_Cond.IsUpdated(convSenateGaugeSubItems.GridTitle) == true)
{
string strComparisonOp_GridTitle = objvSenateGaugeSubItems_Cond.dicFldComparisonOp[convSenateGaugeSubItems.GridTitle];
strWhereCond += string.Format(" And {0} {2} '{1}'", convSenateGaugeSubItems.GridTitle, objvSenateGaugeSubItems_Cond.GridTitle, strComparisonOp_GridTitle);
}
if (objvSenateGaugeSubItems_Cond.IsUpdated(convSenateGaugeSubItems.IsHaveAdditionalMemo) == true)
{
if (objvSenateGaugeSubItems_Cond.IsHaveAdditionalMemo == true)
{
strWhereCond += string.Format(" And {0} = '1'", convSenateGaugeSubItems.IsHaveAdditionalMemo);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convSenateGaugeSubItems.IsHaveAdditionalMemo);
}
}
if (objvSenateGaugeSubItems_Cond.IsUpdated(convSenateGaugeSubItems.QuestionIndex) == true)
{
string strComparisonOp_QuestionIndex = objvSenateGaugeSubItems_Cond.dicFldComparisonOp[convSenateGaugeSubItems.QuestionIndex];
strWhereCond += string.Format(" And {0} {2} {1}", convSenateGaugeSubItems.QuestionIndex, objvSenateGaugeSubItems_Cond.QuestionIndex, strComparisonOp_QuestionIndex);
}
if (objvSenateGaugeSubItems_Cond.IsUpdated(convSenateGaugeSubItems.QuestionNo) == true)
{
string strComparisonOp_QuestionNo = objvSenateGaugeSubItems_Cond.dicFldComparisonOp[convSenateGaugeSubItems.QuestionNo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convSenateGaugeSubItems.QuestionNo, objvSenateGaugeSubItems_Cond.QuestionNo, strComparisonOp_QuestionNo);
}
if (objvSenateGaugeSubItems_Cond.IsUpdated(convSenateGaugeSubItems.QuestionTypeId) == true)
{
string strComparisonOp_QuestionTypeId = objvSenateGaugeSubItems_Cond.dicFldComparisonOp[convSenateGaugeSubItems.QuestionTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convSenateGaugeSubItems.QuestionTypeId, objvSenateGaugeSubItems_Cond.QuestionTypeId, strComparisonOp_QuestionTypeId);
}
if (objvSenateGaugeSubItems_Cond.IsUpdated(convSenateGaugeSubItems.QuestionTypeName) == true)
{
string strComparisonOp_QuestionTypeName = objvSenateGaugeSubItems_Cond.dicFldComparisonOp[convSenateGaugeSubItems.QuestionTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convSenateGaugeSubItems.QuestionTypeName, objvSenateGaugeSubItems_Cond.QuestionTypeName, strComparisonOp_QuestionTypeName);
}
if (objvSenateGaugeSubItems_Cond.IsUpdated(convSenateGaugeSubItems.senateGaugeItemNameWithOrder) == true)
{
string strComparisonOp_senateGaugeItemNameWithOrder = objvSenateGaugeSubItems_Cond.dicFldComparisonOp[convSenateGaugeSubItems.senateGaugeItemNameWithOrder];
strWhereCond += string.Format(" And {0} {2} '{1}'", convSenateGaugeSubItems.senateGaugeItemNameWithOrder, objvSenateGaugeSubItems_Cond.senateGaugeItemNameWithOrder, strComparisonOp_senateGaugeItemNameWithOrder);
}
if (objvSenateGaugeSubItems_Cond.IsUpdated(convSenateGaugeSubItems.senateGaugeVersionMemo) == true)
{
string strComparisonOp_senateGaugeVersionMemo = objvSenateGaugeSubItems_Cond.dicFldComparisonOp[convSenateGaugeSubItems.senateGaugeVersionMemo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convSenateGaugeSubItems.senateGaugeVersionMemo, objvSenateGaugeSubItems_Cond.senateGaugeVersionMemo, strComparisonOp_senateGaugeVersionMemo);
}
 return strWhereCond;
}
}
 /// <summary>
 /// v量表指标子项(vSenateGaugeSubItems)
 /// (AutoGCLib.WA_Access4CSharp:GeneCode)
 /// </summary>
public class clsvSenateGaugeSubItemsWApi
{
private static readonly string mstrApiControllerName = "vSenateGaugeSubItemsApi";

 public clsvSenateGaugeSubItemsWApi()
 {
 }

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyId)
 /// </summary>
 /// <param name = "strid_SenateGaugeSubItem">表关键字</param>
 /// <returns>表对象</returns>
public static clsvSenateGaugeSubItemsEN GetObjByid_SenateGaugeSubItem(string strid_SenateGaugeSubItem)
{
string strAction = "GetObjByid_SenateGaugeSubItem";
string strErrMsg = string.Empty;
string strResult = "";
clsvSenateGaugeSubItemsEN objvSenateGaugeSubItemsEN = null;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["id_SenateGaugeSubItem"] = strid_SenateGaugeSubItem
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
objvSenateGaugeSubItemsEN = JsonConvert.DeserializeObject<clsvSenateGaugeSubItemsEN>((string)jobjReturn["ReturnObj"]);
return objvSenateGaugeSubItemsEN;
}
else
{
string strMsg = string.Format("{0}", jobjReturn["ErrorMsg"]);
throw new Exception(strMsg);
}
}
else return null;
}
catch (Exception objException)
{
string strMsg = string.Format("获取条件记录出错,{0}.(from {1})", HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyId_WA_Cache)
 /// </summary>
 /// <param name = "strid_SenateGaugeSubItem">表关键字</param>
 /// <returns>表对象</returns>
public static clsvSenateGaugeSubItemsEN GetObjByid_SenateGaugeSubItem_WA_Cache(string strid_SenateGaugeSubItem)
{
string strAction = "GetObjByid_SenateGaugeSubItem_Cache";
string strErrMsg = string.Empty;
string strResult = "";
clsvSenateGaugeSubItemsEN objvSenateGaugeSubItemsEN = null;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["id_SenateGaugeSubItem"] = strid_SenateGaugeSubItem
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
objvSenateGaugeSubItemsEN = JsonConvert.DeserializeObject<clsvSenateGaugeSubItemsEN>((string)jobjReturn["ReturnObj"]);
return objvSenateGaugeSubItemsEN;
}
else
{
string strMsg = string.Format("{0}", jobjReturn["ErrorMsg"]);
throw new Exception(strMsg);
}
}
else return null;
}
catch (Exception objException)
{
string strMsg = string.Format("获取条件记录出错,{0}.(from {1})", HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的关键字值
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetFirstID)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的关键字值</returns>
public static string GetFirstID(string strWhereCond)
{
string strAction = "GetFirstID";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["strWhereCond"] = strWhereCond
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
var strReturnStr = (string)jobjReturn["ReturnStr"];
return strReturnStr;
}
else
{
string strMsg = string.Format("{0}", jobjReturn["ErrorMsg"]);
throw new Exception(strMsg);
}
}
else return "";
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebApi功能出错, {0}.(from {1}). WebApi地址:{2}).",
      HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction(),
clsPubFun4WApi.GetWebApiUrl(mstrApiControllerName, strAction));
 throw new Exception(strMsg);
}
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetFirstObj)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的关键字值</returns>
public static clsvSenateGaugeSubItemsEN GetFirstObj(string strWhereCond)
{
string strAction = "GetFirstObj";
string strErrMsg = string.Empty;
string strResult = "";
clsvSenateGaugeSubItemsEN objvSenateGaugeSubItemsEN = null;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["strWhereCond"] = strWhereCond
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
objvSenateGaugeSubItemsEN = JsonConvert.DeserializeObject<clsvSenateGaugeSubItemsEN>((string)jobjReturn["ReturnObj"]);
return objvSenateGaugeSubItemsEN;
}
else
{
string strMsg = string.Format("{0}", jobjReturn["ErrorMsg"]);
throw new Exception(strMsg);
}
}
else return null;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebApi功能出错, {0}.(from {1}). WebApi地址:{2}).",
      HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction(),
clsPubFun4WApi.GetWebApiUrl(mstrApiControllerName, strAction));
 throw new Exception(strMsg);
}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKey_Cache)
 /// </summary>
 /// <param name = "strid_SenateGaugeSubItem">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvSenateGaugeSubItemsEN GetObjByid_SenateGaugeSubItem_Cache(string strid_SenateGaugeSubItem)
{
if (string.IsNullOrEmpty(strid_SenateGaugeSubItem) == true) return null;
//初始化列表缓存
string strKey = string.Format("{0}", clsvSenateGaugeSubItemsEN._CurrTabName_S);
List<clsvSenateGaugeSubItemsEN> arrvSenateGaugeSubItemsObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsvSenateGaugeSubItemsEN> arrvSenateGaugeSubItemsObjLst_Sel =
from objvSenateGaugeSubItemsEN in arrvSenateGaugeSubItemsObjLst_Cache
where objvSenateGaugeSubItemsEN.id_SenateGaugeSubItem == strid_SenateGaugeSubItem
select objvSenateGaugeSubItemsEN;
if (arrvSenateGaugeSubItemsObjLst_Sel.Count() == 0)
{
   clsvSenateGaugeSubItemsEN obj = clsvSenateGaugeSubItemsWApi.GetObjByid_SenateGaugeSubItem(strid_SenateGaugeSubItem);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
     return obj;
 }
return null;
}
return arrvSenateGaugeSubItemsObjLst_Sel.First();
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvSenateGaugeSubItemsEN> GetObjLst(string strWhereCond)
{
 List<clsvSenateGaugeSubItemsEN> arrObjLst = null; 
string strAction = "GetObjLst";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["strWhereCond"] = strWhereCond
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
arrObjLst = JsonConvert.DeserializeObject<List<clsvSenateGaugeSubItemsEN>>((string)jobjReturn["ReturnObjLst"]);
return arrObjLst;
}
else
{
string strMsg = string.Format("{0}", jobjReturn["ErrorMsg"]);
throw new Exception(strMsg);
}
}
else return null;
}
catch (Exception objException)
{
string strMsg = string.Format("获取条件对象列表出错,{0}.(from {1})", HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
}

 /// <summary>
 /// 根据关键字列表获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstByKeyLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvSenateGaugeSubItemsEN> GetObjLstById_SenateGaugeSubItemLst(List<string> arrId_SenateGaugeSubItem)
{
 List<clsvSenateGaugeSubItemsEN> arrObjLst = null; 
string strAction = "GetObjLstById_SenateGaugeSubItemLst";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrId_SenateGaugeSubItem);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
arrObjLst = JsonConvert.DeserializeObject<List<clsvSenateGaugeSubItemsEN>>((string)jobjReturn["ReturnObjLst"]);
return arrObjLst;
}
else
{
string strMsg = string.Format("{0}", jobjReturn["ErrorMsg"]);
throw new Exception(strMsg);
}
}
else return null;
}
catch (Exception objException)
{
string strMsg = string.Format("根据关键字列表获取对象列表出错,{0}.(from {1})", HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstByKeyLst_Cache)
 /// </summary>
 /// <param name = "strid_SenateGaugeSubItem">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static IEnumerable<clsvSenateGaugeSubItemsEN> GetObjLstById_SenateGaugeSubItemLst_Cache(List<string> arrId_SenateGaugeSubItem)
{
//初始化列表缓存
string strKey = string.Format("{0}", clsvSenateGaugeSubItemsEN._CurrTabName_S);
List<clsvSenateGaugeSubItemsEN> arrvSenateGaugeSubItemsObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsvSenateGaugeSubItemsEN> arrvSenateGaugeSubItemsObjLst_Sel =
from objvSenateGaugeSubItemsEN in arrvSenateGaugeSubItemsObjLst_Cache
where arrId_SenateGaugeSubItem.Contains(objvSenateGaugeSubItemsEN.id_SenateGaugeSubItem)
select objvSenateGaugeSubItemsEN;
return arrvSenateGaugeSubItemsObjLst_Sel;
}

 /// <summary>
 /// 根据关键字列表获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstByKeyLst_WA_Cache)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvSenateGaugeSubItemsEN> GetObjLstById_SenateGaugeSubItemLst_WA_Cache(List<string> arrId_SenateGaugeSubItem)
{
 List<clsvSenateGaugeSubItemsEN> arrObjLst = null; 
string strAction = "GetObjLstById_SenateGaugeSubItemLst_Cache";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
};
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrId_SenateGaugeSubItem);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
arrObjLst = JsonConvert.DeserializeObject<List<clsvSenateGaugeSubItemsEN>>((string)jobjReturn["ReturnObjLst"]);
return arrObjLst;
}
else
{
string strMsg = string.Format("{0}", jobjReturn["ErrorMsg"]);
throw new Exception(strMsg);
}
}
else return null;
}
catch (Exception objException)
{
string strMsg = string.Format("根据关键字列表获取对象列表出错,{0}.(from {1})", HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
}

 /// <summary>
 /// 根据条件获取顶部对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsvSenateGaugeSubItemsEN> GetTopObjLst(stuTopPara objTopPara)
{
 List<clsvSenateGaugeSubItemsEN> arrObjLst = null; 
string strAction = "GetTopObjLst";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = objTopPara.GetDictParam();
try
{
string strJSON = clsJSON.GetJsonFromObj<stuTopPara>(objTopPara);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
arrObjLst = JsonConvert.DeserializeObject<List<clsvSenateGaugeSubItemsEN>>((string)jobjReturn["ReturnObjLst"]);
return arrObjLst;
}
else
{
string strMsg = string.Format("{0}", jobjReturn["ErrorMsg"]);
throw new Exception(strMsg);
}
}
else return null;
}
catch (Exception objException)
{
string strMsg = string.Format("根据条件获取顶部对象列表,{0}.(from {1})", HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
}

 /// <summary>
 /// 根据条件获取范围内的对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstByRange)
 /// </summary>
 /// <param name = "objRangePara">根据范围获取记录的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsvSenateGaugeSubItemsEN> GetObjLstByRange(stuRangePara objRangePara)
{
 List<clsvSenateGaugeSubItemsEN> arrObjLst = null; 
string strAction = "GetObjLstByRange";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam =  objRangePara.GetDictParam();
try
{
string strJSON = clsJSON.GetJsonFromObj<stuRangePara>(objRangePara);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
arrObjLst = JsonConvert.DeserializeObject<List<clsvSenateGaugeSubItemsEN>>((string)jobjReturn["ReturnObjLst"]);
return arrObjLst;
}
else
{
string strMsg = string.Format("{0}", jobjReturn["ErrorMsg"]);
throw new Exception(strMsg);
}
}
else return null;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebApi功能出错, {0}.(from {1}). WebApi地址:{2}).",
      HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction(),
clsPubFun4WApi.GetWebApiUrl(mstrApiControllerName, strAction));
 throw new Exception(strMsg);
}
}

 /// <summary>
 /// 根据条件分页获取JSON对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回JSON对象列表</returns>
public static List<clsvSenateGaugeSubItemsEN> GetObjLstByPager(stuPagerPara objPagerPara)
{
 List<clsvSenateGaugeSubItemsEN> arrObjLst = null; 
string strAction = "GetObjLstByPager";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = objPagerPara.GetDictParam();
try
{
string strJSON = clsJSON.GetJsonFromObj<stuPagerPara>(objPagerPara);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
arrObjLst = JsonConvert.DeserializeObject<List<clsvSenateGaugeSubItemsEN>>((string)jobjReturn["ReturnObjLst"]);
return arrObjLst;
}
else
{
string strMsg = string.Format("{0}", jobjReturn["ErrorMsg"]);
throw new Exception(strMsg);
}
}
else return null;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebApi功能出错, {0}.(from {1}). WebApi地址:{2}).",
      HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction(),
clsPubFun4WApi.GetWebApiUrl(mstrApiControllerName, strAction));
 throw new Exception(strMsg);
}
}

 /// <summary>
 /// 根据条件分页获取JSON对象列表, 使用缓存
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstByPager_Cache)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回JSON对象列表</returns>
public static List<clsvSenateGaugeSubItemsEN> GetObjLstByPager_Cache(stuPagerPara objPagerPara)
{
 List<clsvSenateGaugeSubItemsEN> arrObjLst = null; 
string strAction = "GetObjLstByPager_Cache";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = objPagerPara.GetDictParam();
try
{
string strJSON = clsJSON.GetJsonFromObj<stuPagerPara>(objPagerPara);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
arrObjLst = JsonConvert.DeserializeObject<List<clsvSenateGaugeSubItemsEN>>((string)jobjReturn["ReturnObjLst"]);
return arrObjLst;
}
else
{
string strMsg = string.Format("{0}", jobjReturn["ErrorMsg"]);
throw new Exception(strMsg);
}
}
else return null;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebApi功能出错, {0}.(from {1}). WebApi地址:{2}).",
      HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction(),
clsPubFun4WApi.GetWebApiUrl(mstrApiControllerName, strAction));
 throw new Exception(strMsg);
}
}

 /// <summary>
 /// 根据条件判断是否存在记录
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_IsExistRecord)
 /// </summary>
 /// <returns>是否存在?存在返回True</returns>
public static bool IsExistRecord(string strWhereCond)
{
//检测记录是否存在
string strAction = "IsExistRecord";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["strWhereCond"] = strWhereCond
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
var bolReturnBool = (bool)jobjReturn["ReturnBool"];
return bolReturnBool;
}
else
{
string strMsg = string.Format("{0}", jobjReturn["ErrorMsg"]);
throw new Exception(strMsg);
}
}
else return false;
}
catch (Exception objException)
{
string strMsg = string.Format("获取条件记录出错,{0}.(from {1})", HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
}

 /// <summary>
 /// 根据关键字判断是否存在记录
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_IsExist)
 /// </summary>
 /// <returns>是否存在?存在返回True</returns>
public static bool IsExist(string strid_SenateGaugeSubItem)
{
//检测记录是否存在
string strAction = "IsExist";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["id_SenateGaugeSubItem"] = strid_SenateGaugeSubItem
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
var bolReturnBool = (bool)jobjReturn["ReturnBool"];
return bolReturnBool;
}
else
{
string strMsg = string.Format("{0}", jobjReturn["ErrorMsg"]);
throw new Exception(strMsg);
}
}
else return false;
}
catch (Exception objException)
{
string strMsg = string.Format("获取条件记录出错,{0}.(from {1})", HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
}

 /// <summary>
 /// 根据条件获取相关记录数
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetRecCountByCond)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>记录数</returns>
public static int GetRecCountByCond(string strWhereCond)
{
string strAction = "GetRecCountByCond";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["strWhereCond"] = strWhereCond
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
var intReturnInt = (int)jobjReturn["ReturnInt"];
return intReturnInt;
}
else
{
string strMsg = string.Format("{0}", jobjReturn["ErrorMsg"]);
throw new Exception(strMsg);
}
}
else return 0;
}
catch (Exception objException)
{
string strMsg = string.Format("获取条件记录出错,{0}.(from {1})", HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
}

 /// <summary>
 /// 根据条件获取相关记录数
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetFldValue)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>记录数</returns>
public static List<string> GetFldValue(string strFldName, string strWhereCond)
{
string strAction = "GetFldValue";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["strFldName"] = strFldName,
["strWhereCond"] = strWhereCond
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
string strReturnStrLst = (string)jobjReturn["ReturnStrLst"];
var arrReturnStrLst = strReturnStrLst.Split(",".ToCharArray());
return arrReturnStrLst.Select(x => x).ToList();
}
else
{
string strMsg = string.Format("{0}", jobjReturn["ErrorMsg"]);
throw new Exception(strMsg);
}
}
else return null;
}
catch (Exception objException)
{
string strMsg = string.Format("获取条件记录出错,{0}.(from {1})", HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
}

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_CopyObj_S)
 /// </summary>
 /// <param name = "objvSenateGaugeSubItemsENS">源对象</param>
 /// <param name = "objvSenateGaugeSubItemsENT">目标对象</param>
 public static void CopyTo(clsvSenateGaugeSubItemsEN objvSenateGaugeSubItemsENS, clsvSenateGaugeSubItemsEN objvSenateGaugeSubItemsENT)
{
try
{
objvSenateGaugeSubItemsENT.id_SenateGaugeSubItem = objvSenateGaugeSubItemsENS.id_SenateGaugeSubItem; //量表指标子项流水号
objvSenateGaugeSubItemsENT.senateGaugeSubItemID = objvSenateGaugeSubItemsENS.senateGaugeSubItemID; //量表指标子项ID
objvSenateGaugeSubItemsENT.senateGaugeSubItemName = objvSenateGaugeSubItemsENS.senateGaugeSubItemName; //量表指标子项名称
objvSenateGaugeSubItemsENT.id_SenateGaugeItem = objvSenateGaugeSubItemsENS.id_SenateGaugeItem; //量表指标流水号
objvSenateGaugeSubItemsENT.senateGaugeItemName = objvSenateGaugeSubItemsENS.senateGaugeItemName; //量表指标名称
objvSenateGaugeSubItemsENT.senateGaugeVersionName = objvSenateGaugeSubItemsENS.senateGaugeVersionName; //评价量表版本名称
objvSenateGaugeSubItemsENT.senateGaugeSubItemScore = objvSenateGaugeSubItemsENS.senateGaugeSubItemScore; //量表指标子项分数
objvSenateGaugeSubItemsENT.id_SenateGaugeVersion = objvSenateGaugeSubItemsENS.id_SenateGaugeVersion; //评价量表版本流水号
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
string strMsg = string.Format("(errid:Watl000001)Copy表对象数据出错,{1}.({0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
}
}

/// <summary>
/// 对象列表 转换为 DataTable数据集合
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_ToDataTable)
/// </summary>
/// <param name="arrObj">原对象列表</param>
/// <returns>返回的DataTable</returns>
public static DataTable ToDataTable(List<clsvSenateGaugeSubItemsEN> arrObj)
{
DataTable dataTable = new DataTable(); //实例化
DataTable result;
if (arrObj.Count == 0) return null;
if (clsvSenateGaugeSubItemsEN.AttributeName.Length == 0)
{
result = dataTable;
return result;
}
Type type = typeof(clsvSenateGaugeSubItemsEN);
PropertyInfo[] arrPropertyInfo = type.GetProperties();
try
{
//Columns
foreach (string strAttrName in clsvSenateGaugeSubItemsEN.AttributeName)
{
PropertyInfo proprety_Curr = arrPropertyInfo.Where(x => x.Name == strAttrName).First();
dataTable.Columns.Add(strAttrName, proprety_Curr.PropertyType);
}
foreach (clsvSenateGaugeSubItemsEN objInFor in arrObj)
{
//Rows
DataRow dataRow = dataTable.NewRow();
foreach (string strAttrName in clsvSenateGaugeSubItemsEN.AttributeName)
{
dataRow[strAttrName] = objInFor[strAttrName];
}
dataTable.Rows.Add(dataRow); //循环添加行到DataTable中
}
}
catch (Exception objExceptoin)
{
throw objExceptoin;
}
result = dataTable;
return result;
}

 /// <summary>
 /// 初始化列表缓存.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_InitListCache)
 /// </summary>
public static void InitListCache()
{
//检查缓存刷新机制
string strMsg = "";
if (clsSenateGaugeSubItemsWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsSenateGaugeSubItemsWApi没有刷新缓存机制(clsSenateGaugeSubItemsWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsAnswerModeWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsAnswerModeWApi没有刷新缓存机制(clsAnswerModeWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsAnswerTypeWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsAnswerTypeWApi没有刷新缓存机制(clsAnswerTypeWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsQuestionTypeWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsQuestionTypeWApi没有刷新缓存机制(clsQuestionTypeWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsSenateGaugeVersionWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsSenateGaugeVersionWApi没有刷新缓存机制(clsSenateGaugeVersionWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsSenateGaugeItemsWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsSenateGaugeItemsWApi没有刷新缓存机制(clsSenateGaugeItemsWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by id_SenateGaugeSubItem");
//if (arrvSenateGaugeSubItemsObjLst_Cache == null)
//{
//arrvSenateGaugeSubItemsObjLst_Cache = await clsvSenateGaugeSubItemsWApi.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 刷新本类中的缓存.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_ReFreshThisCache)
 /// </summary>
public static void ReFreshThisCache()
{
string strMsg = "";
if (clsSysParaEN.spSetRefreshCacheOn == true)
{
string strKey = string.Format("{0}", clsvSenateGaugeSubItemsEN._CurrTabName_S);
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

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst_Cache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvSenateGaugeSubItemsEN> GetObjLst_Cache()
{
//初始化列表缓存
InitListCache(); 
string strKey = string.Format("{0}", clsvSenateGaugeSubItemsEN._CurrTabName_S);
List<clsvSenateGaugeSubItemsEN> arrvSenateGaugeSubItemsObjLst_Cache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrvSenateGaugeSubItemsObjLst_Cache;
}

 /// <summary>
 /// 根据对象列表获取DataTable
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetDataTableByObjLst)
 /// </summary>
 /// <param name = "arrObjLst">给定的对象列表</param>
 /// <returns>返回DataTable</returns>
public static DataTable GetDataTableByObjLst(List<clsvSenateGaugeSubItemsEN> arrObjLst)
{
DataTable objDT = new DataTable();
objDT.Columns.Add(convSenateGaugeSubItems.id_SenateGaugeSubItem, Type.GetType("System.String"));
objDT.Columns.Add(convSenateGaugeSubItems.senateGaugeSubItemID, Type.GetType("System.String"));
objDT.Columns.Add(convSenateGaugeSubItems.senateGaugeSubItemName, Type.GetType("System.String"));
objDT.Columns.Add(convSenateGaugeSubItems.id_SenateGaugeItem, Type.GetType("System.String"));
objDT.Columns.Add(convSenateGaugeSubItems.senateGaugeItemName, Type.GetType("System.String"));
objDT.Columns.Add(convSenateGaugeSubItems.senateGaugeVersionName, Type.GetType("System.String"));
objDT.Columns.Add(convSenateGaugeSubItems.senateGaugeSubItemScore, Type.GetType("System.Single"));
objDT.Columns.Add(convSenateGaugeSubItems.id_SenateGaugeVersion, Type.GetType("System.String"));
objDT.Columns.Add(convSenateGaugeSubItems.senateGaugeItemID, Type.GetType("System.String"));
objDT.Columns.Add(convSenateGaugeSubItems.senateGaugeSubItemDesc, Type.GetType("System.String"));
objDT.Columns.Add(convSenateGaugeSubItems.AnswerTitle, Type.GetType("System.String"));
objDT.Columns.Add(convSenateGaugeSubItems.AnswerIndex, Type.GetType("System.Int32"));
objDT.Columns.Add(convSenateGaugeSubItems.senateGaugeItemDesc, Type.GetType("System.String"));
objDT.Columns.Add(convSenateGaugeSubItems.senateGaugeItemWeight, Type.GetType("System.Single"));
objDT.Columns.Add(convSenateGaugeSubItems.senateGaugeSubItemMemo, Type.GetType("System.String"));
objDT.Columns.Add(convSenateGaugeSubItems.senateGaugeItemMemo, Type.GetType("System.String"));
objDT.Columns.Add(convSenateGaugeSubItems.senateGaugeVersionID, Type.GetType("System.String"));
objDT.Columns.Add(convSenateGaugeSubItems.senateGaugeVersionTtlScore, Type.GetType("System.Single"));
objDT.Columns.Add(convSenateGaugeSubItems.senateGaugeSubItemAll, Type.GetType("System.String"));
objDT.Columns.Add(convSenateGaugeSubItems.senateGaugeSubItemAll2, Type.GetType("System.String"));
objDT.Columns.Add(convSenateGaugeSubItems.VersionNo, Type.GetType("System.Int32"));
objDT.Columns.Add(convSenateGaugeSubItems.IsUse, Type.GetType("System.Boolean"));
objDT.Columns.Add(convSenateGaugeSubItems.UpdDate, Type.GetType("System.String"));
objDT.Columns.Add(convSenateGaugeSubItems.UpdUserId, Type.GetType("System.String"));
objDT.Columns.Add(convSenateGaugeSubItems.AnswerModeId, Type.GetType("System.String"));
objDT.Columns.Add(convSenateGaugeSubItems.AnswerModeName, Type.GetType("System.String"));
objDT.Columns.Add(convSenateGaugeSubItems.AnswerNum, Type.GetType("System.Int32"));
objDT.Columns.Add(convSenateGaugeSubItems.AnswerTypeId, Type.GetType("System.String"));
objDT.Columns.Add(convSenateGaugeSubItems.AnswerTypeName, Type.GetType("System.String"));
objDT.Columns.Add(convSenateGaugeSubItems.GridTitle, Type.GetType("System.String"));
objDT.Columns.Add(convSenateGaugeSubItems.IsHaveAdditionalMemo, Type.GetType("System.Boolean"));
objDT.Columns.Add(convSenateGaugeSubItems.QuestionIndex, Type.GetType("System.Int32"));
objDT.Columns.Add(convSenateGaugeSubItems.QuestionNo, Type.GetType("System.String"));
objDT.Columns.Add(convSenateGaugeSubItems.QuestionTypeId, Type.GetType("System.String"));
objDT.Columns.Add(convSenateGaugeSubItems.QuestionTypeName, Type.GetType("System.String"));
objDT.Columns.Add(convSenateGaugeSubItems.senateGaugeItemNameWithOrder, Type.GetType("System.String"));
objDT.Columns.Add(convSenateGaugeSubItems.senateGaugeVersionMemo, Type.GetType("System.String"));
foreach (clsvSenateGaugeSubItemsEN objInFor in arrObjLst)
{
DataRow objDR = objDT.NewRow();
objDR[convSenateGaugeSubItems.id_SenateGaugeSubItem] = objInFor[convSenateGaugeSubItems.id_SenateGaugeSubItem];
objDR[convSenateGaugeSubItems.senateGaugeSubItemID] = objInFor[convSenateGaugeSubItems.senateGaugeSubItemID];
objDR[convSenateGaugeSubItems.senateGaugeSubItemName] = objInFor[convSenateGaugeSubItems.senateGaugeSubItemName];
objDR[convSenateGaugeSubItems.id_SenateGaugeItem] = objInFor[convSenateGaugeSubItems.id_SenateGaugeItem];
objDR[convSenateGaugeSubItems.senateGaugeItemName] = objInFor[convSenateGaugeSubItems.senateGaugeItemName];
objDR[convSenateGaugeSubItems.senateGaugeVersionName] = objInFor[convSenateGaugeSubItems.senateGaugeVersionName];
objDR[convSenateGaugeSubItems.senateGaugeSubItemScore] = objInFor[convSenateGaugeSubItems.senateGaugeSubItemScore];
objDR[convSenateGaugeSubItems.id_SenateGaugeVersion] = objInFor[convSenateGaugeSubItems.id_SenateGaugeVersion];
objDR[convSenateGaugeSubItems.senateGaugeItemID] = objInFor[convSenateGaugeSubItems.senateGaugeItemID];
objDR[convSenateGaugeSubItems.senateGaugeSubItemDesc] = objInFor[convSenateGaugeSubItems.senateGaugeSubItemDesc];
objDR[convSenateGaugeSubItems.AnswerTitle] = objInFor[convSenateGaugeSubItems.AnswerTitle];
objDR[convSenateGaugeSubItems.AnswerIndex] = objInFor[convSenateGaugeSubItems.AnswerIndex];
objDR[convSenateGaugeSubItems.senateGaugeItemDesc] = objInFor[convSenateGaugeSubItems.senateGaugeItemDesc];
objDR[convSenateGaugeSubItems.senateGaugeItemWeight] = objInFor[convSenateGaugeSubItems.senateGaugeItemWeight];
objDR[convSenateGaugeSubItems.senateGaugeSubItemMemo] = objInFor[convSenateGaugeSubItems.senateGaugeSubItemMemo];
objDR[convSenateGaugeSubItems.senateGaugeItemMemo] = objInFor[convSenateGaugeSubItems.senateGaugeItemMemo];
objDR[convSenateGaugeSubItems.senateGaugeVersionID] = objInFor[convSenateGaugeSubItems.senateGaugeVersionID];
objDR[convSenateGaugeSubItems.senateGaugeVersionTtlScore] = objInFor[convSenateGaugeSubItems.senateGaugeVersionTtlScore];
objDR[convSenateGaugeSubItems.senateGaugeSubItemAll] = objInFor[convSenateGaugeSubItems.senateGaugeSubItemAll];
objDR[convSenateGaugeSubItems.senateGaugeSubItemAll2] = objInFor[convSenateGaugeSubItems.senateGaugeSubItemAll2];
objDR[convSenateGaugeSubItems.VersionNo] = objInFor[convSenateGaugeSubItems.VersionNo];
objDR[convSenateGaugeSubItems.IsUse] = objInFor[convSenateGaugeSubItems.IsUse];
objDR[convSenateGaugeSubItems.UpdDate] = objInFor[convSenateGaugeSubItems.UpdDate];
objDR[convSenateGaugeSubItems.UpdUserId] = objInFor[convSenateGaugeSubItems.UpdUserId];
objDR[convSenateGaugeSubItems.AnswerModeId] = objInFor[convSenateGaugeSubItems.AnswerModeId];
objDR[convSenateGaugeSubItems.AnswerModeName] = objInFor[convSenateGaugeSubItems.AnswerModeName];
objDR[convSenateGaugeSubItems.AnswerNum] = objInFor[convSenateGaugeSubItems.AnswerNum];
objDR[convSenateGaugeSubItems.AnswerTypeId] = objInFor[convSenateGaugeSubItems.AnswerTypeId];
objDR[convSenateGaugeSubItems.AnswerTypeName] = objInFor[convSenateGaugeSubItems.AnswerTypeName];
objDR[convSenateGaugeSubItems.GridTitle] = objInFor[convSenateGaugeSubItems.GridTitle];
objDR[convSenateGaugeSubItems.IsHaveAdditionalMemo] = objInFor[convSenateGaugeSubItems.IsHaveAdditionalMemo];
objDR[convSenateGaugeSubItems.QuestionIndex] = objInFor[convSenateGaugeSubItems.QuestionIndex];
objDR[convSenateGaugeSubItems.QuestionNo] = objInFor[convSenateGaugeSubItems.QuestionNo];
objDR[convSenateGaugeSubItems.QuestionTypeId] = objInFor[convSenateGaugeSubItems.QuestionTypeId];
objDR[convSenateGaugeSubItems.QuestionTypeName] = objInFor[convSenateGaugeSubItems.QuestionTypeName];
objDR[convSenateGaugeSubItems.senateGaugeItemNameWithOrder] = objInFor[convSenateGaugeSubItems.senateGaugeItemNameWithOrder];
objDR[convSenateGaugeSubItems.senateGaugeVersionMemo] = objInFor[convSenateGaugeSubItems.senateGaugeVersionMemo];
objDT.Rows.Add(objDR);
}
return objDT;
}
}
}