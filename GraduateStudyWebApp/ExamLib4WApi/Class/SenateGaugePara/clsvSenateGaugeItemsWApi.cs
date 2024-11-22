
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvSenateGaugeItemsWApi
 表名:vSenateGaugeItems(01120477)
 生成代码版本:2021.09.20.1
 生成日期:2021/09/21 02:48:14
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
public static class clsvSenateGaugeItemsWApi_Static
{

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSenateGaugeItemsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvSenateGaugeItemsEN Setid_SenateGaugeItem(this clsvSenateGaugeItemsEN objvSenateGaugeItemsEN, string strid_SenateGaugeItem, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_SenateGaugeItem, 4, convSenateGaugeItems.id_SenateGaugeItem);
clsCheckSql.CheckFieldForeignKey(strid_SenateGaugeItem, 4, convSenateGaugeItems.id_SenateGaugeItem);
objvSenateGaugeItemsEN.id_SenateGaugeItem = strid_SenateGaugeItem; //量表指标流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvSenateGaugeItemsEN.dicFldComparisonOp.ContainsKey(convSenateGaugeItems.id_SenateGaugeItem) == false)
{
objvSenateGaugeItemsEN.dicFldComparisonOp.Add(convSenateGaugeItems.id_SenateGaugeItem, strComparisonOp);
}
else
{
objvSenateGaugeItemsEN.dicFldComparisonOp[convSenateGaugeItems.id_SenateGaugeItem] = strComparisonOp;
}
}
return objvSenateGaugeItemsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSenateGaugeItemsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvSenateGaugeItemsEN SetsenateGaugeItemID(this clsvSenateGaugeItemsEN objvSenateGaugeItemsEN, string strsenateGaugeItemID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strsenateGaugeItemID, 4, convSenateGaugeItems.senateGaugeItemID);
clsCheckSql.CheckFieldForeignKey(strsenateGaugeItemID, 4, convSenateGaugeItems.senateGaugeItemID);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSenateGaugeItemsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvSenateGaugeItemsEN SetsenateGaugeItemName(this clsvSenateGaugeItemsEN objvSenateGaugeItemsEN, string strsenateGaugeItemName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strsenateGaugeItemName, 200, convSenateGaugeItems.senateGaugeItemName);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSenateGaugeItemsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvSenateGaugeItemsEN Setid_SenateGaugeVersion(this clsvSenateGaugeItemsEN objvSenateGaugeItemsEN, string strid_SenateGaugeVersion, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strid_SenateGaugeVersion, convSenateGaugeItems.id_SenateGaugeVersion);
clsCheckSql.CheckFieldLen(strid_SenateGaugeVersion, 4, convSenateGaugeItems.id_SenateGaugeVersion);
clsCheckSql.CheckFieldForeignKey(strid_SenateGaugeVersion, 4, convSenateGaugeItems.id_SenateGaugeVersion);
objvSenateGaugeItemsEN.id_SenateGaugeVersion = strid_SenateGaugeVersion; //评价量表版本流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvSenateGaugeItemsEN.dicFldComparisonOp.ContainsKey(convSenateGaugeItems.id_SenateGaugeVersion) == false)
{
objvSenateGaugeItemsEN.dicFldComparisonOp.Add(convSenateGaugeItems.id_SenateGaugeVersion, strComparisonOp);
}
else
{
objvSenateGaugeItemsEN.dicFldComparisonOp[convSenateGaugeItems.id_SenateGaugeVersion] = strComparisonOp;
}
}
return objvSenateGaugeItemsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSenateGaugeItemsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvSenateGaugeItemsEN SetsenateGaugeVersionName(this clsvSenateGaugeItemsEN objvSenateGaugeItemsEN, string strsenateGaugeVersionName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strsenateGaugeVersionName, 200, convSenateGaugeItems.senateGaugeVersionName);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSenateGaugeItemsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvSenateGaugeItemsEN SetsenateGaugeItemDesc(this clsvSenateGaugeItemsEN objvSenateGaugeItemsEN, string strsenateGaugeItemDesc, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strsenateGaugeItemDesc, 2000, convSenateGaugeItems.senateGaugeItemDesc);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSenateGaugeItemsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvSenateGaugeItemsEN SetsenateGaugeItemWeight(this clsvSenateGaugeItemsEN objvSenateGaugeItemsEN, float fltsenateGaugeItemWeight, string strComparisonOp="")
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSenateGaugeItemsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvSenateGaugeItemsEN SetAnswerModeId(this clsvSenateGaugeItemsEN objvSenateGaugeItemsEN, string strAnswerModeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strAnswerModeId, 4, convSenateGaugeItems.AnswerModeId);
clsCheckSql.CheckFieldForeignKey(strAnswerModeId, 4, convSenateGaugeItems.AnswerModeId);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSenateGaugeItemsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvSenateGaugeItemsEN SetAnswerTypeId(this clsvSenateGaugeItemsEN objvSenateGaugeItemsEN, string strAnswerTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strAnswerTypeId, 2, convSenateGaugeItems.AnswerTypeId);
clsCheckSql.CheckFieldForeignKey(strAnswerTypeId, 2, convSenateGaugeItems.AnswerTypeId);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSenateGaugeItemsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvSenateGaugeItemsEN SetGridTitle(this clsvSenateGaugeItemsEN objvSenateGaugeItemsEN, string strGridTitle, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strGridTitle, 30, convSenateGaugeItems.GridTitle);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSenateGaugeItemsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvSenateGaugeItemsEN SetQuestionIndex(this clsvSenateGaugeItemsEN objvSenateGaugeItemsEN, int intQuestionIndex, string strComparisonOp="")
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSenateGaugeItemsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvSenateGaugeItemsEN SetsenateGaugeVersionID(this clsvSenateGaugeItemsEN objvSenateGaugeItemsEN, string strsenateGaugeVersionID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strsenateGaugeVersionID, convSenateGaugeItems.senateGaugeVersionID);
clsCheckSql.CheckFieldLen(strsenateGaugeVersionID, 4, convSenateGaugeItems.senateGaugeVersionID);
clsCheckSql.CheckFieldForeignKey(strsenateGaugeVersionID, 4, convSenateGaugeItems.senateGaugeVersionID);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSenateGaugeItemsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvSenateGaugeItemsEN SetQuestionNo(this clsvSenateGaugeItemsEN objvSenateGaugeItemsEN, string strQuestionNo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strQuestionNo, 10, convSenateGaugeItems.QuestionNo);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSenateGaugeItemsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvSenateGaugeItemsEN SetQuestionTypeId(this clsvSenateGaugeItemsEN objvSenateGaugeItemsEN, string strQuestionTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strQuestionTypeId, 2, convSenateGaugeItems.QuestionTypeId);
clsCheckSql.CheckFieldForeignKey(strQuestionTypeId, 2, convSenateGaugeItems.QuestionTypeId);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSenateGaugeItemsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSenateGaugeItemsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvSenateGaugeItemsEN SetAnswerTypeName(this clsvSenateGaugeItemsEN objvSenateGaugeItemsEN, string strAnswerTypeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strAnswerTypeName, 50, convSenateGaugeItems.AnswerTypeName);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSenateGaugeItemsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvSenateGaugeItemsEN SetAnswerModeName(this clsvSenateGaugeItemsEN objvSenateGaugeItemsEN, string strAnswerModeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strAnswerModeName, 30, convSenateGaugeItems.AnswerModeName);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSenateGaugeItemsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvSenateGaugeItemsEN SetsenateGaugeItemMemo(this clsvSenateGaugeItemsEN objvSenateGaugeItemsEN, string strsenateGaugeItemMemo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strsenateGaugeItemMemo, 1000, convSenateGaugeItems.senateGaugeItemMemo);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSenateGaugeItemsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvSenateGaugeItemsEN SetQuestionTypeName(this clsvSenateGaugeItemsEN objvSenateGaugeItemsEN, string strQuestionTypeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strQuestionTypeName, 20, convSenateGaugeItems.QuestionTypeName);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSenateGaugeItemsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvSenateGaugeItemsEN SetAnswerNum(this clsvSenateGaugeItemsEN objvSenateGaugeItemsEN, int intAnswerNum, string strComparisonOp="")
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSenateGaugeItemsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvSenateGaugeItemsEN SetVersionNo(this clsvSenateGaugeItemsEN objvSenateGaugeItemsEN, int intVersionNo, string strComparisonOp="")
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSenateGaugeItemsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSenateGaugeItemsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvSenateGaugeItemsEN SetsenateGaugeVersionMemo(this clsvSenateGaugeItemsEN objvSenateGaugeItemsEN, string strsenateGaugeVersionMemo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strsenateGaugeVersionMemo, 1000, convSenateGaugeItems.senateGaugeVersionMemo);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSenateGaugeItemsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvSenateGaugeItemsEN SetsenateGaugeItemNameWithOrder(this clsvSenateGaugeItemsEN objvSenateGaugeItemsEN, string strsenateGaugeItemNameWithOrder, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strsenateGaugeItemNameWithOrder, 204, convSenateGaugeItems.senateGaugeItemNameWithOrder);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSenateGaugeItemsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvSenateGaugeItemsEN SetUpdDate(this clsvSenateGaugeItemsEN objvSenateGaugeItemsEN, string strUpdDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdDate, 20, convSenateGaugeItems.UpdDate);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSenateGaugeItemsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvSenateGaugeItemsEN SetUpdUserId(this clsvSenateGaugeItemsEN objvSenateGaugeItemsEN, string strUpdUserId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdUserId, 20, convSenateGaugeItems.UpdUserId);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvSenateGaugeItemsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
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
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvSenateGaugeItemsEN objvSenateGaugeItems_Cond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvSenateGaugeItems_Cond.IsUpdated(convSenateGaugeItems.id_SenateGaugeItem) == true)
{
string strComparisonOp_id_SenateGaugeItem = objvSenateGaugeItems_Cond.dicFldComparisonOp[convSenateGaugeItems.id_SenateGaugeItem];
strWhereCond += string.Format(" And {0} {2} '{1}'", convSenateGaugeItems.id_SenateGaugeItem, objvSenateGaugeItems_Cond.id_SenateGaugeItem, strComparisonOp_id_SenateGaugeItem);
}
if (objvSenateGaugeItems_Cond.IsUpdated(convSenateGaugeItems.senateGaugeItemID) == true)
{
string strComparisonOp_senateGaugeItemID = objvSenateGaugeItems_Cond.dicFldComparisonOp[convSenateGaugeItems.senateGaugeItemID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convSenateGaugeItems.senateGaugeItemID, objvSenateGaugeItems_Cond.senateGaugeItemID, strComparisonOp_senateGaugeItemID);
}
if (objvSenateGaugeItems_Cond.IsUpdated(convSenateGaugeItems.senateGaugeItemName) == true)
{
string strComparisonOp_senateGaugeItemName = objvSenateGaugeItems_Cond.dicFldComparisonOp[convSenateGaugeItems.senateGaugeItemName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convSenateGaugeItems.senateGaugeItemName, objvSenateGaugeItems_Cond.senateGaugeItemName, strComparisonOp_senateGaugeItemName);
}
if (objvSenateGaugeItems_Cond.IsUpdated(convSenateGaugeItems.id_SenateGaugeVersion) == true)
{
string strComparisonOp_id_SenateGaugeVersion = objvSenateGaugeItems_Cond.dicFldComparisonOp[convSenateGaugeItems.id_SenateGaugeVersion];
strWhereCond += string.Format(" And {0} {2} '{1}'", convSenateGaugeItems.id_SenateGaugeVersion, objvSenateGaugeItems_Cond.id_SenateGaugeVersion, strComparisonOp_id_SenateGaugeVersion);
}
if (objvSenateGaugeItems_Cond.IsUpdated(convSenateGaugeItems.senateGaugeVersionName) == true)
{
string strComparisonOp_senateGaugeVersionName = objvSenateGaugeItems_Cond.dicFldComparisonOp[convSenateGaugeItems.senateGaugeVersionName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convSenateGaugeItems.senateGaugeVersionName, objvSenateGaugeItems_Cond.senateGaugeVersionName, strComparisonOp_senateGaugeVersionName);
}
if (objvSenateGaugeItems_Cond.IsUpdated(convSenateGaugeItems.senateGaugeItemDesc) == true)
{
string strComparisonOp_senateGaugeItemDesc = objvSenateGaugeItems_Cond.dicFldComparisonOp[convSenateGaugeItems.senateGaugeItemDesc];
strWhereCond += string.Format(" And {0} {2} '{1}'", convSenateGaugeItems.senateGaugeItemDesc, objvSenateGaugeItems_Cond.senateGaugeItemDesc, strComparisonOp_senateGaugeItemDesc);
}
if (objvSenateGaugeItems_Cond.IsUpdated(convSenateGaugeItems.senateGaugeItemWeight) == true)
{
string strComparisonOp_senateGaugeItemWeight = objvSenateGaugeItems_Cond.dicFldComparisonOp[convSenateGaugeItems.senateGaugeItemWeight];
strWhereCond += string.Format(" And {0} {2} {1}", convSenateGaugeItems.senateGaugeItemWeight, objvSenateGaugeItems_Cond.senateGaugeItemWeight, strComparisonOp_senateGaugeItemWeight);
}
if (objvSenateGaugeItems_Cond.IsUpdated(convSenateGaugeItems.AnswerModeId) == true)
{
string strComparisonOp_AnswerModeId = objvSenateGaugeItems_Cond.dicFldComparisonOp[convSenateGaugeItems.AnswerModeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convSenateGaugeItems.AnswerModeId, objvSenateGaugeItems_Cond.AnswerModeId, strComparisonOp_AnswerModeId);
}
if (objvSenateGaugeItems_Cond.IsUpdated(convSenateGaugeItems.AnswerTypeId) == true)
{
string strComparisonOp_AnswerTypeId = objvSenateGaugeItems_Cond.dicFldComparisonOp[convSenateGaugeItems.AnswerTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convSenateGaugeItems.AnswerTypeId, objvSenateGaugeItems_Cond.AnswerTypeId, strComparisonOp_AnswerTypeId);
}
if (objvSenateGaugeItems_Cond.IsUpdated(convSenateGaugeItems.GridTitle) == true)
{
string strComparisonOp_GridTitle = objvSenateGaugeItems_Cond.dicFldComparisonOp[convSenateGaugeItems.GridTitle];
strWhereCond += string.Format(" And {0} {2} '{1}'", convSenateGaugeItems.GridTitle, objvSenateGaugeItems_Cond.GridTitle, strComparisonOp_GridTitle);
}
if (objvSenateGaugeItems_Cond.IsUpdated(convSenateGaugeItems.QuestionIndex) == true)
{
string strComparisonOp_QuestionIndex = objvSenateGaugeItems_Cond.dicFldComparisonOp[convSenateGaugeItems.QuestionIndex];
strWhereCond += string.Format(" And {0} {2} {1}", convSenateGaugeItems.QuestionIndex, objvSenateGaugeItems_Cond.QuestionIndex, strComparisonOp_QuestionIndex);
}
if (objvSenateGaugeItems_Cond.IsUpdated(convSenateGaugeItems.senateGaugeVersionID) == true)
{
string strComparisonOp_senateGaugeVersionID = objvSenateGaugeItems_Cond.dicFldComparisonOp[convSenateGaugeItems.senateGaugeVersionID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convSenateGaugeItems.senateGaugeVersionID, objvSenateGaugeItems_Cond.senateGaugeVersionID, strComparisonOp_senateGaugeVersionID);
}
if (objvSenateGaugeItems_Cond.IsUpdated(convSenateGaugeItems.QuestionNo) == true)
{
string strComparisonOp_QuestionNo = objvSenateGaugeItems_Cond.dicFldComparisonOp[convSenateGaugeItems.QuestionNo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convSenateGaugeItems.QuestionNo, objvSenateGaugeItems_Cond.QuestionNo, strComparisonOp_QuestionNo);
}
if (objvSenateGaugeItems_Cond.IsUpdated(convSenateGaugeItems.QuestionTypeId) == true)
{
string strComparisonOp_QuestionTypeId = objvSenateGaugeItems_Cond.dicFldComparisonOp[convSenateGaugeItems.QuestionTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convSenateGaugeItems.QuestionTypeId, objvSenateGaugeItems_Cond.QuestionTypeId, strComparisonOp_QuestionTypeId);
}
if (objvSenateGaugeItems_Cond.IsUpdated(convSenateGaugeItems.senateGaugeVersionTtlScore) == true)
{
string strComparisonOp_senateGaugeVersionTtlScore = objvSenateGaugeItems_Cond.dicFldComparisonOp[convSenateGaugeItems.senateGaugeVersionTtlScore];
strWhereCond += string.Format(" And {0} {2} {1}", convSenateGaugeItems.senateGaugeVersionTtlScore, objvSenateGaugeItems_Cond.senateGaugeVersionTtlScore, strComparisonOp_senateGaugeVersionTtlScore);
}
if (objvSenateGaugeItems_Cond.IsUpdated(convSenateGaugeItems.AnswerTypeName) == true)
{
string strComparisonOp_AnswerTypeName = objvSenateGaugeItems_Cond.dicFldComparisonOp[convSenateGaugeItems.AnswerTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convSenateGaugeItems.AnswerTypeName, objvSenateGaugeItems_Cond.AnswerTypeName, strComparisonOp_AnswerTypeName);
}
if (objvSenateGaugeItems_Cond.IsUpdated(convSenateGaugeItems.AnswerModeName) == true)
{
string strComparisonOp_AnswerModeName = objvSenateGaugeItems_Cond.dicFldComparisonOp[convSenateGaugeItems.AnswerModeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convSenateGaugeItems.AnswerModeName, objvSenateGaugeItems_Cond.AnswerModeName, strComparisonOp_AnswerModeName);
}
if (objvSenateGaugeItems_Cond.IsUpdated(convSenateGaugeItems.senateGaugeItemMemo) == true)
{
string strComparisonOp_senateGaugeItemMemo = objvSenateGaugeItems_Cond.dicFldComparisonOp[convSenateGaugeItems.senateGaugeItemMemo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convSenateGaugeItems.senateGaugeItemMemo, objvSenateGaugeItems_Cond.senateGaugeItemMemo, strComparisonOp_senateGaugeItemMemo);
}
if (objvSenateGaugeItems_Cond.IsUpdated(convSenateGaugeItems.QuestionTypeName) == true)
{
string strComparisonOp_QuestionTypeName = objvSenateGaugeItems_Cond.dicFldComparisonOp[convSenateGaugeItems.QuestionTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convSenateGaugeItems.QuestionTypeName, objvSenateGaugeItems_Cond.QuestionTypeName, strComparisonOp_QuestionTypeName);
}
if (objvSenateGaugeItems_Cond.IsUpdated(convSenateGaugeItems.AnswerNum) == true)
{
string strComparisonOp_AnswerNum = objvSenateGaugeItems_Cond.dicFldComparisonOp[convSenateGaugeItems.AnswerNum];
strWhereCond += string.Format(" And {0} {2} {1}", convSenateGaugeItems.AnswerNum, objvSenateGaugeItems_Cond.AnswerNum, strComparisonOp_AnswerNum);
}
if (objvSenateGaugeItems_Cond.IsUpdated(convSenateGaugeItems.VersionNo) == true)
{
string strComparisonOp_VersionNo = objvSenateGaugeItems_Cond.dicFldComparisonOp[convSenateGaugeItems.VersionNo];
strWhereCond += string.Format(" And {0} {2} {1}", convSenateGaugeItems.VersionNo, objvSenateGaugeItems_Cond.VersionNo, strComparisonOp_VersionNo);
}
if (objvSenateGaugeItems_Cond.IsUpdated(convSenateGaugeItems.IsUse) == true)
{
if (objvSenateGaugeItems_Cond.IsUse == true)
{
strWhereCond += string.Format(" And {0} = '1'", convSenateGaugeItems.IsUse);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convSenateGaugeItems.IsUse);
}
}
if (objvSenateGaugeItems_Cond.IsUpdated(convSenateGaugeItems.senateGaugeVersionMemo) == true)
{
string strComparisonOp_senateGaugeVersionMemo = objvSenateGaugeItems_Cond.dicFldComparisonOp[convSenateGaugeItems.senateGaugeVersionMemo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convSenateGaugeItems.senateGaugeVersionMemo, objvSenateGaugeItems_Cond.senateGaugeVersionMemo, strComparisonOp_senateGaugeVersionMemo);
}
if (objvSenateGaugeItems_Cond.IsUpdated(convSenateGaugeItems.senateGaugeItemNameWithOrder) == true)
{
string strComparisonOp_senateGaugeItemNameWithOrder = objvSenateGaugeItems_Cond.dicFldComparisonOp[convSenateGaugeItems.senateGaugeItemNameWithOrder];
strWhereCond += string.Format(" And {0} {2} '{1}'", convSenateGaugeItems.senateGaugeItemNameWithOrder, objvSenateGaugeItems_Cond.senateGaugeItemNameWithOrder, strComparisonOp_senateGaugeItemNameWithOrder);
}
if (objvSenateGaugeItems_Cond.IsUpdated(convSenateGaugeItems.UpdDate) == true)
{
string strComparisonOp_UpdDate = objvSenateGaugeItems_Cond.dicFldComparisonOp[convSenateGaugeItems.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convSenateGaugeItems.UpdDate, objvSenateGaugeItems_Cond.UpdDate, strComparisonOp_UpdDate);
}
if (objvSenateGaugeItems_Cond.IsUpdated(convSenateGaugeItems.UpdUserId) == true)
{
string strComparisonOp_UpdUserId = objvSenateGaugeItems_Cond.dicFldComparisonOp[convSenateGaugeItems.UpdUserId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convSenateGaugeItems.UpdUserId, objvSenateGaugeItems_Cond.UpdUserId, strComparisonOp_UpdUserId);
}
if (objvSenateGaugeItems_Cond.IsUpdated(convSenateGaugeItems.IsHaveAdditionalMemo) == true)
{
if (objvSenateGaugeItems_Cond.IsHaveAdditionalMemo == true)
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
 /// v量表指标(vSenateGaugeItems)
 /// (AutoGCLib.WA_Access4CSharp:GeneCode)
 /// </summary>
public class clsvSenateGaugeItemsWApi
{
private static readonly string mstrApiControllerName = "vSenateGaugeItemsApi";

 public clsvSenateGaugeItemsWApi()
 {
 }

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyId)
 /// </summary>
 /// <param name = "strid_SenateGaugeItem">表关键字</param>
 /// <returns>表对象</returns>
public static clsvSenateGaugeItemsEN GetObjByid_SenateGaugeItem(string strid_SenateGaugeItem)
{
string strAction = "GetObjByid_SenateGaugeItem";
string strErrMsg = string.Empty;
string strResult = "";
clsvSenateGaugeItemsEN objvSenateGaugeItemsEN = null;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["id_SenateGaugeItem"] = strid_SenateGaugeItem
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
objvSenateGaugeItemsEN = JsonConvert.DeserializeObject<clsvSenateGaugeItemsEN>((string)jobjReturn["ReturnObj"]);
return objvSenateGaugeItemsEN;
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
 /// <param name = "strid_SenateGaugeItem">表关键字</param>
 /// <returns>表对象</returns>
public static clsvSenateGaugeItemsEN GetObjByid_SenateGaugeItem_WA_Cache(string strid_SenateGaugeItem)
{
string strAction = "GetObjByid_SenateGaugeItem_Cache";
string strErrMsg = string.Empty;
string strResult = "";
clsvSenateGaugeItemsEN objvSenateGaugeItemsEN = null;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["id_SenateGaugeItem"] = strid_SenateGaugeItem
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
objvSenateGaugeItemsEN = JsonConvert.DeserializeObject<clsvSenateGaugeItemsEN>((string)jobjReturn["ReturnObj"]);
return objvSenateGaugeItemsEN;
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
public static clsvSenateGaugeItemsEN GetFirstObj(string strWhereCond)
{
string strAction = "GetFirstObj";
string strErrMsg = string.Empty;
string strResult = "";
clsvSenateGaugeItemsEN objvSenateGaugeItemsEN = null;
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
objvSenateGaugeItemsEN = JsonConvert.DeserializeObject<clsvSenateGaugeItemsEN>((string)jobjReturn["ReturnObj"]);
return objvSenateGaugeItemsEN;
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
 /// <param name = "strid_SenateGaugeItem">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvSenateGaugeItemsEN GetObjByid_SenateGaugeItem_Cache(string strid_SenateGaugeItem)
{
if (string.IsNullOrEmpty(strid_SenateGaugeItem) == true) return null;
//初始化列表缓存
string strKey = string.Format("{0}", clsvSenateGaugeItemsEN._CurrTabName_S);
List<clsvSenateGaugeItemsEN> arrvSenateGaugeItemsObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsvSenateGaugeItemsEN> arrvSenateGaugeItemsObjLst_Sel =
from objvSenateGaugeItemsEN in arrvSenateGaugeItemsObjLst_Cache
where objvSenateGaugeItemsEN.id_SenateGaugeItem == strid_SenateGaugeItem
select objvSenateGaugeItemsEN;
if (arrvSenateGaugeItemsObjLst_Sel.Count() == 0)
{
   clsvSenateGaugeItemsEN obj = clsvSenateGaugeItemsWApi.GetObjByid_SenateGaugeItem(strid_SenateGaugeItem);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
     return obj;
 }
return null;
}
return arrvSenateGaugeItemsObjLst_Sel.First();
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvSenateGaugeItemsEN> GetObjLst(string strWhereCond)
{
 List<clsvSenateGaugeItemsEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvSenateGaugeItemsEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvSenateGaugeItemsEN> GetObjLstById_SenateGaugeItemLst(List<string> arrId_SenateGaugeItem)
{
 List<clsvSenateGaugeItemsEN> arrObjLst = null; 
string strAction = "GetObjLstById_SenateGaugeItemLst";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrId_SenateGaugeItem);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
arrObjLst = JsonConvert.DeserializeObject<List<clsvSenateGaugeItemsEN>>((string)jobjReturn["ReturnObjLst"]);
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
 /// <param name = "strid_SenateGaugeItem">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static IEnumerable<clsvSenateGaugeItemsEN> GetObjLstById_SenateGaugeItemLst_Cache(List<string> arrId_SenateGaugeItem)
{
//初始化列表缓存
string strKey = string.Format("{0}", clsvSenateGaugeItemsEN._CurrTabName_S);
List<clsvSenateGaugeItemsEN> arrvSenateGaugeItemsObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsvSenateGaugeItemsEN> arrvSenateGaugeItemsObjLst_Sel =
from objvSenateGaugeItemsEN in arrvSenateGaugeItemsObjLst_Cache
where arrId_SenateGaugeItem.Contains(objvSenateGaugeItemsEN.id_SenateGaugeItem)
select objvSenateGaugeItemsEN;
return arrvSenateGaugeItemsObjLst_Sel;
}

 /// <summary>
 /// 根据关键字列表获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstByKeyLst_WA_Cache)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvSenateGaugeItemsEN> GetObjLstById_SenateGaugeItemLst_WA_Cache(List<string> arrId_SenateGaugeItem)
{
 List<clsvSenateGaugeItemsEN> arrObjLst = null; 
string strAction = "GetObjLstById_SenateGaugeItemLst_Cache";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
};
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrId_SenateGaugeItem);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
arrObjLst = JsonConvert.DeserializeObject<List<clsvSenateGaugeItemsEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvSenateGaugeItemsEN> GetTopObjLst(stuTopPara objTopPara)
{
 List<clsvSenateGaugeItemsEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvSenateGaugeItemsEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvSenateGaugeItemsEN> GetObjLstByRange(stuRangePara objRangePara)
{
 List<clsvSenateGaugeItemsEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvSenateGaugeItemsEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvSenateGaugeItemsEN> GetObjLstByPager(stuPagerPara objPagerPara)
{
 List<clsvSenateGaugeItemsEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvSenateGaugeItemsEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvSenateGaugeItemsEN> GetObjLstByPager_Cache(stuPagerPara objPagerPara)
{
 List<clsvSenateGaugeItemsEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvSenateGaugeItemsEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static bool IsExist(string strid_SenateGaugeItem)
{
//检测记录是否存在
string strAction = "IsExist";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["id_SenateGaugeItem"] = strid_SenateGaugeItem
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
 /// <param name = "objvSenateGaugeItemsENS">源对象</param>
 /// <param name = "objvSenateGaugeItemsENT">目标对象</param>
 public static void CopyTo(clsvSenateGaugeItemsEN objvSenateGaugeItemsENS, clsvSenateGaugeItemsEN objvSenateGaugeItemsENT)
{
try
{
objvSenateGaugeItemsENT.id_SenateGaugeItem = objvSenateGaugeItemsENS.id_SenateGaugeItem; //量表指标流水号
objvSenateGaugeItemsENT.senateGaugeItemID = objvSenateGaugeItemsENS.senateGaugeItemID; //量表指标ID
objvSenateGaugeItemsENT.senateGaugeItemName = objvSenateGaugeItemsENS.senateGaugeItemName; //量表指标名称
objvSenateGaugeItemsENT.id_SenateGaugeVersion = objvSenateGaugeItemsENS.id_SenateGaugeVersion; //评价量表版本流水号
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
public static DataTable ToDataTable(List<clsvSenateGaugeItemsEN> arrObj)
{
DataTable dataTable = new DataTable(); //实例化
DataTable result;
if (arrObj.Count == 0) return null;
if (clsvSenateGaugeItemsEN.AttributeName.Length == 0)
{
result = dataTable;
return result;
}
Type type = typeof(clsvSenateGaugeItemsEN);
PropertyInfo[] arrPropertyInfo = type.GetProperties();
try
{
//Columns
foreach (string strAttrName in clsvSenateGaugeItemsEN.AttributeName)
{
PropertyInfo proprety_Curr = arrPropertyInfo.Where(x => x.Name == strAttrName).First();
dataTable.Columns.Add(strAttrName, proprety_Curr.PropertyType);
}
foreach (clsvSenateGaugeItemsEN objInFor in arrObj)
{
//Rows
DataRow dataRow = dataTable.NewRow();
foreach (string strAttrName in clsvSenateGaugeItemsEN.AttributeName)
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
//string strWhereCond = string.Format("1 = 1 order by id_SenateGaugeItem");
//if (arrvSenateGaugeItemsObjLst_Cache == null)
//{
//arrvSenateGaugeItemsObjLst_Cache = await clsvSenateGaugeItemsWApi.GetObjLst(strWhereCond);
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
string strKey = string.Format("{0}", clsvSenateGaugeItemsEN._CurrTabName_S);
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
public static List<clsvSenateGaugeItemsEN> GetObjLst_Cache()
{
//初始化列表缓存
InitListCache(); 
string strKey = string.Format("{0}", clsvSenateGaugeItemsEN._CurrTabName_S);
List<clsvSenateGaugeItemsEN> arrvSenateGaugeItemsObjLst_Cache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrvSenateGaugeItemsObjLst_Cache;
}

 /// <summary>
 /// 根据对象列表获取DataTable
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetDataTableByObjLst)
 /// </summary>
 /// <param name = "arrObjLst">给定的对象列表</param>
 /// <returns>返回DataTable</returns>
public static DataTable GetDataTableByObjLst(List<clsvSenateGaugeItemsEN> arrObjLst)
{
DataTable objDT = new DataTable();
objDT.Columns.Add(convSenateGaugeItems.id_SenateGaugeItem, Type.GetType("System.String"));
objDT.Columns.Add(convSenateGaugeItems.senateGaugeItemID, Type.GetType("System.String"));
objDT.Columns.Add(convSenateGaugeItems.senateGaugeItemName, Type.GetType("System.String"));
objDT.Columns.Add(convSenateGaugeItems.id_SenateGaugeVersion, Type.GetType("System.String"));
objDT.Columns.Add(convSenateGaugeItems.senateGaugeVersionName, Type.GetType("System.String"));
objDT.Columns.Add(convSenateGaugeItems.senateGaugeItemDesc, Type.GetType("System.String"));
objDT.Columns.Add(convSenateGaugeItems.senateGaugeItemWeight, Type.GetType("System.Single"));
objDT.Columns.Add(convSenateGaugeItems.AnswerModeId, Type.GetType("System.String"));
objDT.Columns.Add(convSenateGaugeItems.AnswerTypeId, Type.GetType("System.String"));
objDT.Columns.Add(convSenateGaugeItems.GridTitle, Type.GetType("System.String"));
objDT.Columns.Add(convSenateGaugeItems.QuestionIndex, Type.GetType("System.Int32"));
objDT.Columns.Add(convSenateGaugeItems.senateGaugeVersionID, Type.GetType("System.String"));
objDT.Columns.Add(convSenateGaugeItems.QuestionNo, Type.GetType("System.String"));
objDT.Columns.Add(convSenateGaugeItems.QuestionTypeId, Type.GetType("System.String"));
objDT.Columns.Add(convSenateGaugeItems.senateGaugeVersionTtlScore, Type.GetType("System.Single"));
objDT.Columns.Add(convSenateGaugeItems.AnswerTypeName, Type.GetType("System.String"));
objDT.Columns.Add(convSenateGaugeItems.AnswerModeName, Type.GetType("System.String"));
objDT.Columns.Add(convSenateGaugeItems.senateGaugeItemMemo, Type.GetType("System.String"));
objDT.Columns.Add(convSenateGaugeItems.QuestionTypeName, Type.GetType("System.String"));
objDT.Columns.Add(convSenateGaugeItems.AnswerNum, Type.GetType("System.Int32"));
objDT.Columns.Add(convSenateGaugeItems.VersionNo, Type.GetType("System.Int32"));
objDT.Columns.Add(convSenateGaugeItems.IsUse, Type.GetType("System.Boolean"));
objDT.Columns.Add(convSenateGaugeItems.senateGaugeVersionMemo, Type.GetType("System.String"));
objDT.Columns.Add(convSenateGaugeItems.senateGaugeItemNameWithOrder, Type.GetType("System.String"));
objDT.Columns.Add(convSenateGaugeItems.UpdDate, Type.GetType("System.String"));
objDT.Columns.Add(convSenateGaugeItems.UpdUserId, Type.GetType("System.String"));
objDT.Columns.Add(convSenateGaugeItems.IsHaveAdditionalMemo, Type.GetType("System.Boolean"));
foreach (clsvSenateGaugeItemsEN objInFor in arrObjLst)
{
DataRow objDR = objDT.NewRow();
objDR[convSenateGaugeItems.id_SenateGaugeItem] = objInFor[convSenateGaugeItems.id_SenateGaugeItem];
objDR[convSenateGaugeItems.senateGaugeItemID] = objInFor[convSenateGaugeItems.senateGaugeItemID];
objDR[convSenateGaugeItems.senateGaugeItemName] = objInFor[convSenateGaugeItems.senateGaugeItemName];
objDR[convSenateGaugeItems.id_SenateGaugeVersion] = objInFor[convSenateGaugeItems.id_SenateGaugeVersion];
objDR[convSenateGaugeItems.senateGaugeVersionName] = objInFor[convSenateGaugeItems.senateGaugeVersionName];
objDR[convSenateGaugeItems.senateGaugeItemDesc] = objInFor[convSenateGaugeItems.senateGaugeItemDesc];
objDR[convSenateGaugeItems.senateGaugeItemWeight] = objInFor[convSenateGaugeItems.senateGaugeItemWeight];
objDR[convSenateGaugeItems.AnswerModeId] = objInFor[convSenateGaugeItems.AnswerModeId];
objDR[convSenateGaugeItems.AnswerTypeId] = objInFor[convSenateGaugeItems.AnswerTypeId];
objDR[convSenateGaugeItems.GridTitle] = objInFor[convSenateGaugeItems.GridTitle];
objDR[convSenateGaugeItems.QuestionIndex] = objInFor[convSenateGaugeItems.QuestionIndex];
objDR[convSenateGaugeItems.senateGaugeVersionID] = objInFor[convSenateGaugeItems.senateGaugeVersionID];
objDR[convSenateGaugeItems.QuestionNo] = objInFor[convSenateGaugeItems.QuestionNo];
objDR[convSenateGaugeItems.QuestionTypeId] = objInFor[convSenateGaugeItems.QuestionTypeId];
objDR[convSenateGaugeItems.senateGaugeVersionTtlScore] = objInFor[convSenateGaugeItems.senateGaugeVersionTtlScore];
objDR[convSenateGaugeItems.AnswerTypeName] = objInFor[convSenateGaugeItems.AnswerTypeName];
objDR[convSenateGaugeItems.AnswerModeName] = objInFor[convSenateGaugeItems.AnswerModeName];
objDR[convSenateGaugeItems.senateGaugeItemMemo] = objInFor[convSenateGaugeItems.senateGaugeItemMemo];
objDR[convSenateGaugeItems.QuestionTypeName] = objInFor[convSenateGaugeItems.QuestionTypeName];
objDR[convSenateGaugeItems.AnswerNum] = objInFor[convSenateGaugeItems.AnswerNum];
objDR[convSenateGaugeItems.VersionNo] = objInFor[convSenateGaugeItems.VersionNo];
objDR[convSenateGaugeItems.IsUse] = objInFor[convSenateGaugeItems.IsUse];
objDR[convSenateGaugeItems.senateGaugeVersionMemo] = objInFor[convSenateGaugeItems.senateGaugeVersionMemo];
objDR[convSenateGaugeItems.senateGaugeItemNameWithOrder] = objInFor[convSenateGaugeItems.senateGaugeItemNameWithOrder];
objDR[convSenateGaugeItems.UpdDate] = objInFor[convSenateGaugeItems.UpdDate];
objDR[convSenateGaugeItems.UpdUserId] = objInFor[convSenateGaugeItems.UpdUserId];
objDR[convSenateGaugeItems.IsHaveAdditionalMemo] = objInFor[convSenateGaugeItems.IsHaveAdditionalMemo];
objDT.Rows.Add(objDR);
}
return objDT;
}
}
}