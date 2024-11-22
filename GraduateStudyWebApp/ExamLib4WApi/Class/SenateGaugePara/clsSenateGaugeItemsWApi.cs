
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsSenateGaugeItemsWApi
 表名:SenateGaugeItems(01120476)
 生成代码版本:2021.09.20.1
 生成日期:2021/09/21 02:37:55
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
public static class clsSenateGaugeItemsWApi_Static
{

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objSenateGaugeItemsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsSenateGaugeItemsEN Setid_SenateGaugeItem(this clsSenateGaugeItemsEN objSenateGaugeItemsEN, string strid_SenateGaugeItem, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_SenateGaugeItem, 4, conSenateGaugeItems.id_SenateGaugeItem);
clsCheckSql.CheckFieldForeignKey(strid_SenateGaugeItem, 4, conSenateGaugeItems.id_SenateGaugeItem);
objSenateGaugeItemsEN.id_SenateGaugeItem = strid_SenateGaugeItem; //量表指标流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objSenateGaugeItemsEN.dicFldComparisonOp.ContainsKey(conSenateGaugeItems.id_SenateGaugeItem) == false)
{
objSenateGaugeItemsEN.dicFldComparisonOp.Add(conSenateGaugeItems.id_SenateGaugeItem, strComparisonOp);
}
else
{
objSenateGaugeItemsEN.dicFldComparisonOp[conSenateGaugeItems.id_SenateGaugeItem] = strComparisonOp;
}
}
return objSenateGaugeItemsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objSenateGaugeItemsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsSenateGaugeItemsEN Setid_SenateGaugeVersion(this clsSenateGaugeItemsEN objSenateGaugeItemsEN, string strid_SenateGaugeVersion, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strid_SenateGaugeVersion, conSenateGaugeItems.id_SenateGaugeVersion);
clsCheckSql.CheckFieldLen(strid_SenateGaugeVersion, 4, conSenateGaugeItems.id_SenateGaugeVersion);
clsCheckSql.CheckFieldForeignKey(strid_SenateGaugeVersion, 4, conSenateGaugeItems.id_SenateGaugeVersion);
objSenateGaugeItemsEN.id_SenateGaugeVersion = strid_SenateGaugeVersion; //评价量表版本流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objSenateGaugeItemsEN.dicFldComparisonOp.ContainsKey(conSenateGaugeItems.id_SenateGaugeVersion) == false)
{
objSenateGaugeItemsEN.dicFldComparisonOp.Add(conSenateGaugeItems.id_SenateGaugeVersion, strComparisonOp);
}
else
{
objSenateGaugeItemsEN.dicFldComparisonOp[conSenateGaugeItems.id_SenateGaugeVersion] = strComparisonOp;
}
}
return objSenateGaugeItemsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objSenateGaugeItemsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsSenateGaugeItemsEN SetsenateGaugeItemID(this clsSenateGaugeItemsEN objSenateGaugeItemsEN, string strsenateGaugeItemID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strsenateGaugeItemID, conSenateGaugeItems.senateGaugeItemID);
clsCheckSql.CheckFieldLen(strsenateGaugeItemID, 4, conSenateGaugeItems.senateGaugeItemID);
clsCheckSql.CheckFieldForeignKey(strsenateGaugeItemID, 4, conSenateGaugeItems.senateGaugeItemID);
objSenateGaugeItemsEN.senateGaugeItemID = strsenateGaugeItemID; //量表指标ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objSenateGaugeItemsEN.dicFldComparisonOp.ContainsKey(conSenateGaugeItems.senateGaugeItemID) == false)
{
objSenateGaugeItemsEN.dicFldComparisonOp.Add(conSenateGaugeItems.senateGaugeItemID, strComparisonOp);
}
else
{
objSenateGaugeItemsEN.dicFldComparisonOp[conSenateGaugeItems.senateGaugeItemID] = strComparisonOp;
}
}
return objSenateGaugeItemsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objSenateGaugeItemsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsSenateGaugeItemsEN SetsenateGaugeItemName(this clsSenateGaugeItemsEN objSenateGaugeItemsEN, string strsenateGaugeItemName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strsenateGaugeItemName, conSenateGaugeItems.senateGaugeItemName);
clsCheckSql.CheckFieldLen(strsenateGaugeItemName, 200, conSenateGaugeItems.senateGaugeItemName);
objSenateGaugeItemsEN.senateGaugeItemName = strsenateGaugeItemName; //量表指标名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objSenateGaugeItemsEN.dicFldComparisonOp.ContainsKey(conSenateGaugeItems.senateGaugeItemName) == false)
{
objSenateGaugeItemsEN.dicFldComparisonOp.Add(conSenateGaugeItems.senateGaugeItemName, strComparisonOp);
}
else
{
objSenateGaugeItemsEN.dicFldComparisonOp[conSenateGaugeItems.senateGaugeItemName] = strComparisonOp;
}
}
return objSenateGaugeItemsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objSenateGaugeItemsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsSenateGaugeItemsEN SetsenateGaugeItemDesc(this clsSenateGaugeItemsEN objSenateGaugeItemsEN, string strsenateGaugeItemDesc, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strsenateGaugeItemDesc, 2000, conSenateGaugeItems.senateGaugeItemDesc);
objSenateGaugeItemsEN.senateGaugeItemDesc = strsenateGaugeItemDesc; //量表指标说明
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objSenateGaugeItemsEN.dicFldComparisonOp.ContainsKey(conSenateGaugeItems.senateGaugeItemDesc) == false)
{
objSenateGaugeItemsEN.dicFldComparisonOp.Add(conSenateGaugeItems.senateGaugeItemDesc, strComparisonOp);
}
else
{
objSenateGaugeItemsEN.dicFldComparisonOp[conSenateGaugeItems.senateGaugeItemDesc] = strComparisonOp;
}
}
return objSenateGaugeItemsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objSenateGaugeItemsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsSenateGaugeItemsEN SetsenateGaugeItemWeight(this clsSenateGaugeItemsEN objSenateGaugeItemsEN, float fltsenateGaugeItemWeight, string strComparisonOp="")
	{
objSenateGaugeItemsEN.senateGaugeItemWeight = fltsenateGaugeItemWeight; //量表指标权重
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objSenateGaugeItemsEN.dicFldComparisonOp.ContainsKey(conSenateGaugeItems.senateGaugeItemWeight) == false)
{
objSenateGaugeItemsEN.dicFldComparisonOp.Add(conSenateGaugeItems.senateGaugeItemWeight, strComparisonOp);
}
else
{
objSenateGaugeItemsEN.dicFldComparisonOp[conSenateGaugeItems.senateGaugeItemWeight] = strComparisonOp;
}
}
return objSenateGaugeItemsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objSenateGaugeItemsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsSenateGaugeItemsEN SetAnswerModeId(this clsSenateGaugeItemsEN objSenateGaugeItemsEN, string strAnswerModeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strAnswerModeId, conSenateGaugeItems.AnswerModeId);
clsCheckSql.CheckFieldLen(strAnswerModeId, 4, conSenateGaugeItems.AnswerModeId);
clsCheckSql.CheckFieldForeignKey(strAnswerModeId, 4, conSenateGaugeItems.AnswerModeId);
objSenateGaugeItemsEN.AnswerModeId = strAnswerModeId; //答案模式Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objSenateGaugeItemsEN.dicFldComparisonOp.ContainsKey(conSenateGaugeItems.AnswerModeId) == false)
{
objSenateGaugeItemsEN.dicFldComparisonOp.Add(conSenateGaugeItems.AnswerModeId, strComparisonOp);
}
else
{
objSenateGaugeItemsEN.dicFldComparisonOp[conSenateGaugeItems.AnswerModeId] = strComparisonOp;
}
}
return objSenateGaugeItemsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objSenateGaugeItemsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsSenateGaugeItemsEN SetAnswerTypeId(this clsSenateGaugeItemsEN objSenateGaugeItemsEN, string strAnswerTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strAnswerTypeId, conSenateGaugeItems.AnswerTypeId);
clsCheckSql.CheckFieldLen(strAnswerTypeId, 2, conSenateGaugeItems.AnswerTypeId);
clsCheckSql.CheckFieldForeignKey(strAnswerTypeId, 2, conSenateGaugeItems.AnswerTypeId);
objSenateGaugeItemsEN.AnswerTypeId = strAnswerTypeId; //答案类型ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objSenateGaugeItemsEN.dicFldComparisonOp.ContainsKey(conSenateGaugeItems.AnswerTypeId) == false)
{
objSenateGaugeItemsEN.dicFldComparisonOp.Add(conSenateGaugeItems.AnswerTypeId, strComparisonOp);
}
else
{
objSenateGaugeItemsEN.dicFldComparisonOp[conSenateGaugeItems.AnswerTypeId] = strComparisonOp;
}
}
return objSenateGaugeItemsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objSenateGaugeItemsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsSenateGaugeItemsEN SetGridTitle(this clsSenateGaugeItemsEN objSenateGaugeItemsEN, string strGridTitle, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strGridTitle, conSenateGaugeItems.GridTitle);
clsCheckSql.CheckFieldLen(strGridTitle, 30, conSenateGaugeItems.GridTitle);
objSenateGaugeItemsEN.GridTitle = strGridTitle; //表格标题
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objSenateGaugeItemsEN.dicFldComparisonOp.ContainsKey(conSenateGaugeItems.GridTitle) == false)
{
objSenateGaugeItemsEN.dicFldComparisonOp.Add(conSenateGaugeItems.GridTitle, strComparisonOp);
}
else
{
objSenateGaugeItemsEN.dicFldComparisonOp[conSenateGaugeItems.GridTitle] = strComparisonOp;
}
}
return objSenateGaugeItemsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objSenateGaugeItemsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsSenateGaugeItemsEN SetQuestionIndex(this clsSenateGaugeItemsEN objSenateGaugeItemsEN, int intQuestionIndex, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(intQuestionIndex, conSenateGaugeItems.QuestionIndex);
objSenateGaugeItemsEN.QuestionIndex = intQuestionIndex; //题目序号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objSenateGaugeItemsEN.dicFldComparisonOp.ContainsKey(conSenateGaugeItems.QuestionIndex) == false)
{
objSenateGaugeItemsEN.dicFldComparisonOp.Add(conSenateGaugeItems.QuestionIndex, strComparisonOp);
}
else
{
objSenateGaugeItemsEN.dicFldComparisonOp[conSenateGaugeItems.QuestionIndex] = strComparisonOp;
}
}
return objSenateGaugeItemsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objSenateGaugeItemsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsSenateGaugeItemsEN SetQuestionNo(this clsSenateGaugeItemsEN objSenateGaugeItemsEN, string strQuestionNo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strQuestionNo, conSenateGaugeItems.QuestionNo);
clsCheckSql.CheckFieldLen(strQuestionNo, 10, conSenateGaugeItems.QuestionNo);
objSenateGaugeItemsEN.QuestionNo = strQuestionNo; //题目编号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objSenateGaugeItemsEN.dicFldComparisonOp.ContainsKey(conSenateGaugeItems.QuestionNo) == false)
{
objSenateGaugeItemsEN.dicFldComparisonOp.Add(conSenateGaugeItems.QuestionNo, strComparisonOp);
}
else
{
objSenateGaugeItemsEN.dicFldComparisonOp[conSenateGaugeItems.QuestionNo] = strComparisonOp;
}
}
return objSenateGaugeItemsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objSenateGaugeItemsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsSenateGaugeItemsEN SetQuestionTypeId(this clsSenateGaugeItemsEN objSenateGaugeItemsEN, string strQuestionTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strQuestionTypeId, conSenateGaugeItems.QuestionTypeId);
clsCheckSql.CheckFieldLen(strQuestionTypeId, 2, conSenateGaugeItems.QuestionTypeId);
clsCheckSql.CheckFieldForeignKey(strQuestionTypeId, 2, conSenateGaugeItems.QuestionTypeId);
objSenateGaugeItemsEN.QuestionTypeId = strQuestionTypeId; //题目类型Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objSenateGaugeItemsEN.dicFldComparisonOp.ContainsKey(conSenateGaugeItems.QuestionTypeId) == false)
{
objSenateGaugeItemsEN.dicFldComparisonOp.Add(conSenateGaugeItems.QuestionTypeId, strComparisonOp);
}
else
{
objSenateGaugeItemsEN.dicFldComparisonOp[conSenateGaugeItems.QuestionTypeId] = strComparisonOp;
}
}
return objSenateGaugeItemsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objSenateGaugeItemsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsSenateGaugeItemsEN SetIsHaveAdditionalMemo(this clsSenateGaugeItemsEN objSenateGaugeItemsEN, bool bolIsHaveAdditionalMemo, string strComparisonOp="")
	{
objSenateGaugeItemsEN.IsHaveAdditionalMemo = bolIsHaveAdditionalMemo; //是否有附加说明
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objSenateGaugeItemsEN.dicFldComparisonOp.ContainsKey(conSenateGaugeItems.IsHaveAdditionalMemo) == false)
{
objSenateGaugeItemsEN.dicFldComparisonOp.Add(conSenateGaugeItems.IsHaveAdditionalMemo, strComparisonOp);
}
else
{
objSenateGaugeItemsEN.dicFldComparisonOp[conSenateGaugeItems.IsHaveAdditionalMemo] = strComparisonOp;
}
}
return objSenateGaugeItemsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objSenateGaugeItemsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsSenateGaugeItemsEN SetUpdDate(this clsSenateGaugeItemsEN objSenateGaugeItemsEN, string strUpdDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdDate, 20, conSenateGaugeItems.UpdDate);
objSenateGaugeItemsEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objSenateGaugeItemsEN.dicFldComparisonOp.ContainsKey(conSenateGaugeItems.UpdDate) == false)
{
objSenateGaugeItemsEN.dicFldComparisonOp.Add(conSenateGaugeItems.UpdDate, strComparisonOp);
}
else
{
objSenateGaugeItemsEN.dicFldComparisonOp[conSenateGaugeItems.UpdDate] = strComparisonOp;
}
}
return objSenateGaugeItemsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objSenateGaugeItemsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsSenateGaugeItemsEN SetUpdUserId(this clsSenateGaugeItemsEN objSenateGaugeItemsEN, string strUpdUserId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdUserId, 20, conSenateGaugeItems.UpdUserId);
objSenateGaugeItemsEN.UpdUserId = strUpdUserId; //修改用户Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objSenateGaugeItemsEN.dicFldComparisonOp.ContainsKey(conSenateGaugeItems.UpdUserId) == false)
{
objSenateGaugeItemsEN.dicFldComparisonOp.Add(conSenateGaugeItems.UpdUserId, strComparisonOp);
}
else
{
objSenateGaugeItemsEN.dicFldComparisonOp[conSenateGaugeItems.UpdUserId] = strComparisonOp;
}
}
return objSenateGaugeItemsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objSenateGaugeItemsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsSenateGaugeItemsEN SetsenateGaugeItemMemo(this clsSenateGaugeItemsEN objSenateGaugeItemsEN, string strsenateGaugeItemMemo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strsenateGaugeItemMemo, 1000, conSenateGaugeItems.senateGaugeItemMemo);
objSenateGaugeItemsEN.senateGaugeItemMemo = strsenateGaugeItemMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objSenateGaugeItemsEN.dicFldComparisonOp.ContainsKey(conSenateGaugeItems.senateGaugeItemMemo) == false)
{
objSenateGaugeItemsEN.dicFldComparisonOp.Add(conSenateGaugeItems.senateGaugeItemMemo, strComparisonOp);
}
else
{
objSenateGaugeItemsEN.dicFldComparisonOp[conSenateGaugeItems.senateGaugeItemMemo] = strComparisonOp;
}
}
return objSenateGaugeItemsEN;
	}

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsSenateGaugeItemsEN objSenateGaugeItems_Cond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objSenateGaugeItems_Cond.IsUpdated(conSenateGaugeItems.id_SenateGaugeItem) == true)
{
string strComparisonOp_id_SenateGaugeItem = objSenateGaugeItems_Cond.dicFldComparisonOp[conSenateGaugeItems.id_SenateGaugeItem];
strWhereCond += string.Format(" And {0} {2} '{1}'", conSenateGaugeItems.id_SenateGaugeItem, objSenateGaugeItems_Cond.id_SenateGaugeItem, strComparisonOp_id_SenateGaugeItem);
}
if (objSenateGaugeItems_Cond.IsUpdated(conSenateGaugeItems.id_SenateGaugeVersion) == true)
{
string strComparisonOp_id_SenateGaugeVersion = objSenateGaugeItems_Cond.dicFldComparisonOp[conSenateGaugeItems.id_SenateGaugeVersion];
strWhereCond += string.Format(" And {0} {2} '{1}'", conSenateGaugeItems.id_SenateGaugeVersion, objSenateGaugeItems_Cond.id_SenateGaugeVersion, strComparisonOp_id_SenateGaugeVersion);
}
if (objSenateGaugeItems_Cond.IsUpdated(conSenateGaugeItems.senateGaugeItemID) == true)
{
string strComparisonOp_senateGaugeItemID = objSenateGaugeItems_Cond.dicFldComparisonOp[conSenateGaugeItems.senateGaugeItemID];
strWhereCond += string.Format(" And {0} {2} '{1}'", conSenateGaugeItems.senateGaugeItemID, objSenateGaugeItems_Cond.senateGaugeItemID, strComparisonOp_senateGaugeItemID);
}
if (objSenateGaugeItems_Cond.IsUpdated(conSenateGaugeItems.senateGaugeItemName) == true)
{
string strComparisonOp_senateGaugeItemName = objSenateGaugeItems_Cond.dicFldComparisonOp[conSenateGaugeItems.senateGaugeItemName];
strWhereCond += string.Format(" And {0} {2} '{1}'", conSenateGaugeItems.senateGaugeItemName, objSenateGaugeItems_Cond.senateGaugeItemName, strComparisonOp_senateGaugeItemName);
}
if (objSenateGaugeItems_Cond.IsUpdated(conSenateGaugeItems.senateGaugeItemDesc) == true)
{
string strComparisonOp_senateGaugeItemDesc = objSenateGaugeItems_Cond.dicFldComparisonOp[conSenateGaugeItems.senateGaugeItemDesc];
strWhereCond += string.Format(" And {0} {2} '{1}'", conSenateGaugeItems.senateGaugeItemDesc, objSenateGaugeItems_Cond.senateGaugeItemDesc, strComparisonOp_senateGaugeItemDesc);
}
if (objSenateGaugeItems_Cond.IsUpdated(conSenateGaugeItems.senateGaugeItemWeight) == true)
{
string strComparisonOp_senateGaugeItemWeight = objSenateGaugeItems_Cond.dicFldComparisonOp[conSenateGaugeItems.senateGaugeItemWeight];
strWhereCond += string.Format(" And {0} {2} {1}", conSenateGaugeItems.senateGaugeItemWeight, objSenateGaugeItems_Cond.senateGaugeItemWeight, strComparisonOp_senateGaugeItemWeight);
}
if (objSenateGaugeItems_Cond.IsUpdated(conSenateGaugeItems.AnswerModeId) == true)
{
string strComparisonOp_AnswerModeId = objSenateGaugeItems_Cond.dicFldComparisonOp[conSenateGaugeItems.AnswerModeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conSenateGaugeItems.AnswerModeId, objSenateGaugeItems_Cond.AnswerModeId, strComparisonOp_AnswerModeId);
}
if (objSenateGaugeItems_Cond.IsUpdated(conSenateGaugeItems.AnswerTypeId) == true)
{
string strComparisonOp_AnswerTypeId = objSenateGaugeItems_Cond.dicFldComparisonOp[conSenateGaugeItems.AnswerTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conSenateGaugeItems.AnswerTypeId, objSenateGaugeItems_Cond.AnswerTypeId, strComparisonOp_AnswerTypeId);
}
if (objSenateGaugeItems_Cond.IsUpdated(conSenateGaugeItems.GridTitle) == true)
{
string strComparisonOp_GridTitle = objSenateGaugeItems_Cond.dicFldComparisonOp[conSenateGaugeItems.GridTitle];
strWhereCond += string.Format(" And {0} {2} '{1}'", conSenateGaugeItems.GridTitle, objSenateGaugeItems_Cond.GridTitle, strComparisonOp_GridTitle);
}
if (objSenateGaugeItems_Cond.IsUpdated(conSenateGaugeItems.QuestionIndex) == true)
{
string strComparisonOp_QuestionIndex = objSenateGaugeItems_Cond.dicFldComparisonOp[conSenateGaugeItems.QuestionIndex];
strWhereCond += string.Format(" And {0} {2} {1}", conSenateGaugeItems.QuestionIndex, objSenateGaugeItems_Cond.QuestionIndex, strComparisonOp_QuestionIndex);
}
if (objSenateGaugeItems_Cond.IsUpdated(conSenateGaugeItems.QuestionNo) == true)
{
string strComparisonOp_QuestionNo = objSenateGaugeItems_Cond.dicFldComparisonOp[conSenateGaugeItems.QuestionNo];
strWhereCond += string.Format(" And {0} {2} '{1}'", conSenateGaugeItems.QuestionNo, objSenateGaugeItems_Cond.QuestionNo, strComparisonOp_QuestionNo);
}
if (objSenateGaugeItems_Cond.IsUpdated(conSenateGaugeItems.QuestionTypeId) == true)
{
string strComparisonOp_QuestionTypeId = objSenateGaugeItems_Cond.dicFldComparisonOp[conSenateGaugeItems.QuestionTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conSenateGaugeItems.QuestionTypeId, objSenateGaugeItems_Cond.QuestionTypeId, strComparisonOp_QuestionTypeId);
}
if (objSenateGaugeItems_Cond.IsUpdated(conSenateGaugeItems.IsHaveAdditionalMemo) == true)
{
if (objSenateGaugeItems_Cond.IsHaveAdditionalMemo == true)
{
strWhereCond += string.Format(" And {0} = '1'", conSenateGaugeItems.IsHaveAdditionalMemo);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conSenateGaugeItems.IsHaveAdditionalMemo);
}
}
if (objSenateGaugeItems_Cond.IsUpdated(conSenateGaugeItems.UpdDate) == true)
{
string strComparisonOp_UpdDate = objSenateGaugeItems_Cond.dicFldComparisonOp[conSenateGaugeItems.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conSenateGaugeItems.UpdDate, objSenateGaugeItems_Cond.UpdDate, strComparisonOp_UpdDate);
}
if (objSenateGaugeItems_Cond.IsUpdated(conSenateGaugeItems.UpdUserId) == true)
{
string strComparisonOp_UpdUserId = objSenateGaugeItems_Cond.dicFldComparisonOp[conSenateGaugeItems.UpdUserId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conSenateGaugeItems.UpdUserId, objSenateGaugeItems_Cond.UpdUserId, strComparisonOp_UpdUserId);
}
if (objSenateGaugeItems_Cond.IsUpdated(conSenateGaugeItems.senateGaugeItemMemo) == true)
{
string strComparisonOp_senateGaugeItemMemo = objSenateGaugeItems_Cond.dicFldComparisonOp[conSenateGaugeItems.senateGaugeItemMemo];
strWhereCond += string.Format(" And {0} {2} '{1}'", conSenateGaugeItems.senateGaugeItemMemo, objSenateGaugeItems_Cond.senateGaugeItemMemo, strComparisonOp_senateGaugeItemMemo);
}
 return strWhereCond;
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_Update)
 /// </summary>
 /// <param name = "objSenateGaugeItemsEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsSenateGaugeItemsEN objSenateGaugeItemsEN)
{
 if (string.IsNullOrEmpty(objSenateGaugeItemsEN.id_SenateGaugeItem) == true)
 {
string strMsg = string.Format("(errid:Watl000003)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
objSenateGaugeItemsEN.sf_UpdFldSetStr = objSenateGaugeItemsEN.getsf_UpdFldSetStr();
clsSenateGaugeItemsWApi.CheckPropertyNew(objSenateGaugeItemsEN); 
bool bolResult = clsSenateGaugeItemsWApi.UpdateRecord(objSenateGaugeItemsEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsSenateGaugeItemsWApi.ReFreshCache();
return bolResult;
}
catch (Exception objException)
{
string strMsg = string.Format("(errid:Watl000004)修改记录出错,{1}!(from {0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
}
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_AddNewRecord)
 /// </summary>
 /// <param name = "objSenateGaugeItemsEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clsSenateGaugeItemsEN objSenateGaugeItemsEN)
{
 if (string.IsNullOrEmpty(objSenateGaugeItemsEN.id_SenateGaugeItem) == true)
 {
string strMsg = string.Format("添加记录时，关键字不能为空!(from {0})\r\n", 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
 if (clsSenateGaugeItemsWApi.IsExist(objSenateGaugeItemsEN.id_SenateGaugeItem) == true)
 {
string strMsg = string.Format("添加记录时，关键字:[{0}]已经存在!(from {1})\r\n", objSenateGaugeItemsEN.id_SenateGaugeItem, 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
try
{
clsSenateGaugeItemsWApi.CheckPropertyNew(objSenateGaugeItemsEN); 
bool bolResult = clsSenateGaugeItemsWApi.AddNewRecord(objSenateGaugeItemsEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsSenateGaugeItemsWApi.ReFreshCache();
return bolResult;
}
catch (Exception objException)
{
string strMsg = string.Format("(errid:Watl000008)添加记录出错, {1}.(from {0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
}
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,其中关键字为表中获取的最大值. 该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_AddNewRecordWithMaxId)
 /// </summary>
 /// <param name = "objSenateGaugeItemsEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static string AddNewRecordWithMaxId(this clsSenateGaugeItemsEN objSenateGaugeItemsEN)
{
try
{
clsSenateGaugeItemsWApi.CheckPropertyNew(objSenateGaugeItemsEN); 
string strid_SenateGaugeItem = clsSenateGaugeItemsWApi.AddNewRecordWithMaxId(objSenateGaugeItemsEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsSenateGaugeItemsWApi.ReFreshCache();
return strid_SenateGaugeItem;
}
catch (Exception objException)
{
string strMsg = string.Format("(errid:Watl000009)添加记录出错, {1}.(from {0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
}
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是非优化方式,根据条件修改记录
 /// /// 缺点:1、不能处理字段中的单撇问题；2、不能处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_UpdateWithCondition)
 /// </summary>
 /// <param name = "objSenateGaugeItemsEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsSenateGaugeItemsEN objSenateGaugeItemsEN, string strWhereCond)
{
try
{
clsSenateGaugeItemsWApi.CheckPropertyNew(objSenateGaugeItemsEN); 
bool bolResult = clsSenateGaugeItemsWApi.UpdateWithCondition(objSenateGaugeItemsEN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsSenateGaugeItemsWApi.ReFreshCache();
return bolResult;
}
catch (Exception objException)
{
string strMsg = string.Format("(errid:Watl000007)根据条件修改记录出错, {1}.(from {0})\r\n",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
}
}
}
 /// <summary>
 /// 量表指标(SenateGaugeItems)
 /// (AutoGCLib.WA_Access4CSharp:GeneCode)
 /// </summary>
public class clsSenateGaugeItemsWApi
{
private static readonly string mstrApiControllerName = "SenateGaugeItemsApi";

 /// <summary>
/// 专门在逻辑层用于处理缓存等公共函数的对象
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_DefineObjCommFun4BL)
/// </summary>
public static clsCommFun4BL objCommFun4BL = null;

 public clsSenateGaugeItemsWApi()
 {
 }

 /// <summary>
 /// 绑定基于Web的下拉框
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_DdlBindFunction)
 /// </summary>
 /// <param name="objDDL">需要绑定当前表的下拉框</param>
public static void BindDdl_id_SenateGaugeItem(System.Web.UI.WebControls.DropDownList objDDL)
{
//为数据源于表的下拉框设置内容
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[量表指标]...","0");
List<clsSenateGaugeItemsEN> arrObjLst = GetObjLst("1=1");
objDDL.DataValueField="id_SenateGaugeItem";
objDDL.DataTextField="senateGaugeItemName";
objDDL.DataSource = arrObjLst;
objDDL.DataBind();
objDDL.Items.Insert(0, li);
objDDL.SelectedIndex = 0;
}

 /// <summary>
 /// 绑定基于Win的下拉框
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_TabFeature_ComboBoxBindFunction)
 /// </summary>
 /// <param name = "objComboBox">需要绑定当前表的下拉框</param>
public static void BindCbo_id_SenateGaugeItem(System.Windows.Forms.ComboBox objComboBox )
{
//为数据源为表的下拉框设置内容
string strCondition = string.Format("1 =1 Order By {0}", conSenateGaugeItems.id_SenateGaugeItem); 
List<clsSenateGaugeItemsEN> arrObjLst = clsSenateGaugeItemsWApi.GetObjLst(strCondition);
//初始化一个对象列表
//插入第0项。在第0项中插入“请选择...”,为了方便用户,与WEB方式类似。
clsSenateGaugeItemsEN objSenateGaugeItemsEN = new clsSenateGaugeItemsEN()
{
id_SenateGaugeItem = "0",
senateGaugeItemName = "选[量表指标]..."
};
arrObjLst.Insert(0, objSenateGaugeItemsEN);
//设置下拉框的数据源、以及设置值项、显示项
objComboBox.ValueMember = conSenateGaugeItems.id_SenateGaugeItem;
objComboBox.DisplayMember = conSenateGaugeItems.senateGaugeItemName;
objComboBox.DataSource = arrObjLst;
objComboBox.SelectedIndex = 0;
}

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_CheckPropertyNew)
 /// </summary>
public static void CheckPropertyNew(clsSenateGaugeItemsEN objSenateGaugeItemsEN)
{
if (!Object.Equals(null, objSenateGaugeItemsEN.id_SenateGaugeItem) && GetStrLen(objSenateGaugeItemsEN.id_SenateGaugeItem) > 4)
{
 throw new Exception("字段[量表指标流水号]的长度不能超过4!");
}
if (!Object.Equals(null, objSenateGaugeItemsEN.id_SenateGaugeVersion) && GetStrLen(objSenateGaugeItemsEN.id_SenateGaugeVersion) > 4)
{
 throw new Exception("字段[评价量表版本流水号]的长度不能超过4!");
}
if (!Object.Equals(null, objSenateGaugeItemsEN.senateGaugeItemID) && GetStrLen(objSenateGaugeItemsEN.senateGaugeItemID) > 4)
{
 throw new Exception("字段[量表指标ID]的长度不能超过4!");
}
if (!Object.Equals(null, objSenateGaugeItemsEN.senateGaugeItemName) && GetStrLen(objSenateGaugeItemsEN.senateGaugeItemName) > 200)
{
 throw new Exception("字段[量表指标名称]的长度不能超过200!");
}
if (!Object.Equals(null, objSenateGaugeItemsEN.senateGaugeItemDesc) && GetStrLen(objSenateGaugeItemsEN.senateGaugeItemDesc) > 2000)
{
 throw new Exception("字段[量表指标说明]的长度不能超过2000!");
}
if (!Object.Equals(null, objSenateGaugeItemsEN.AnswerModeId) && GetStrLen(objSenateGaugeItemsEN.AnswerModeId) > 4)
{
 throw new Exception("字段[答案模式Id]的长度不能超过4!");
}
if (!Object.Equals(null, objSenateGaugeItemsEN.AnswerTypeId) && GetStrLen(objSenateGaugeItemsEN.AnswerTypeId) > 2)
{
 throw new Exception("字段[答案类型ID]的长度不能超过2!");
}
if (!Object.Equals(null, objSenateGaugeItemsEN.GridTitle) && GetStrLen(objSenateGaugeItemsEN.GridTitle) > 30)
{
 throw new Exception("字段[表格标题]的长度不能超过30!");
}
if (!Object.Equals(null, objSenateGaugeItemsEN.QuestionNo) && GetStrLen(objSenateGaugeItemsEN.QuestionNo) > 10)
{
 throw new Exception("字段[题目编号]的长度不能超过10!");
}
if (!Object.Equals(null, objSenateGaugeItemsEN.QuestionTypeId) && GetStrLen(objSenateGaugeItemsEN.QuestionTypeId) > 2)
{
 throw new Exception("字段[题目类型Id]的长度不能超过2!");
}
if (!Object.Equals(null, objSenateGaugeItemsEN.UpdDate) && GetStrLen(objSenateGaugeItemsEN.UpdDate) > 20)
{
 throw new Exception("字段[修改日期]的长度不能超过20!");
}
if (!Object.Equals(null, objSenateGaugeItemsEN.UpdUserId) && GetStrLen(objSenateGaugeItemsEN.UpdUserId) > 20)
{
 throw new Exception("字段[修改用户Id]的长度不能超过20!");
}
if (!Object.Equals(null, objSenateGaugeItemsEN.senateGaugeItemMemo) && GetStrLen(objSenateGaugeItemsEN.senateGaugeItemMemo) > 1000)
{
 throw new Exception("字段[备注]的长度不能超过1000!");
}
 objSenateGaugeItemsEN._IsCheckProperty = true;
 }

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyId)
 /// </summary>
 /// <param name = "strid_SenateGaugeItem">表关键字</param>
 /// <returns>表对象</returns>
public static clsSenateGaugeItemsEN GetObjByid_SenateGaugeItem(string strid_SenateGaugeItem)
{
string strAction = "GetObjByid_SenateGaugeItem";
string strErrMsg = string.Empty;
string strResult = "";
clsSenateGaugeItemsEN objSenateGaugeItemsEN = null;
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
objSenateGaugeItemsEN = JsonConvert.DeserializeObject<clsSenateGaugeItemsEN>((string)jobjReturn["ReturnObj"]);
return objSenateGaugeItemsEN;
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
public static clsSenateGaugeItemsEN GetObjByid_SenateGaugeItem_WA_Cache(string strid_SenateGaugeItem)
{
string strAction = "GetObjByid_SenateGaugeItem_Cache";
string strErrMsg = string.Empty;
string strResult = "";
clsSenateGaugeItemsEN objSenateGaugeItemsEN = null;
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
objSenateGaugeItemsEN = JsonConvert.DeserializeObject<clsSenateGaugeItemsEN>((string)jobjReturn["ReturnObj"]);
return objSenateGaugeItemsEN;
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
public static clsSenateGaugeItemsEN GetFirstObj(string strWhereCond)
{
string strAction = "GetFirstObj";
string strErrMsg = string.Empty;
string strResult = "";
clsSenateGaugeItemsEN objSenateGaugeItemsEN = null;
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
objSenateGaugeItemsEN = JsonConvert.DeserializeObject<clsSenateGaugeItemsEN>((string)jobjReturn["ReturnObj"]);
return objSenateGaugeItemsEN;
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
public static clsSenateGaugeItemsEN GetObjByid_SenateGaugeItem_Cache(string strid_SenateGaugeItem)
{
if (string.IsNullOrEmpty(strid_SenateGaugeItem) == true) return null;
//初始化列表缓存
string strKey = string.Format("{0}", clsSenateGaugeItemsEN._CurrTabName_S);
List<clsSenateGaugeItemsEN> arrSenateGaugeItemsObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsSenateGaugeItemsEN> arrSenateGaugeItemsObjLst_Sel =
from objSenateGaugeItemsEN in arrSenateGaugeItemsObjLst_Cache
where objSenateGaugeItemsEN.id_SenateGaugeItem == strid_SenateGaugeItem
select objSenateGaugeItemsEN;
if (arrSenateGaugeItemsObjLst_Sel.Count() == 0)
{
   clsSenateGaugeItemsEN obj = clsSenateGaugeItemsWApi.GetObjByid_SenateGaugeItem(strid_SenateGaugeItem);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
     return obj;
 }
return null;
}
return arrSenateGaugeItemsObjLst_Sel.First();
}

 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetRecNameByKey_Cache)
 /// </summary>
 /// <param name = "strid_SenateGaugeItem">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetsenateGaugeItemNameByid_SenateGaugeItem_Cache(string strid_SenateGaugeItem)
{
if (string.IsNullOrEmpty(strid_SenateGaugeItem) == true) return "";
//初始化列表缓存
string strKey = string.Format("{0}", clsSenateGaugeItemsEN._CurrTabName_S);
List<clsSenateGaugeItemsEN> arrSenateGaugeItemsObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsSenateGaugeItemsEN> arrSenateGaugeItemsObjLst_Sel1 =
from objSenateGaugeItemsEN in arrSenateGaugeItemsObjLst_Cache
where objSenateGaugeItemsEN.id_SenateGaugeItem == strid_SenateGaugeItem
select objSenateGaugeItemsEN;
List <clsSenateGaugeItemsEN> arrSenateGaugeItemsObjLst_Sel = new List<clsSenateGaugeItemsEN>();
foreach (clsSenateGaugeItemsEN obj in arrSenateGaugeItemsObjLst_Sel1)
{
arrSenateGaugeItemsObjLst_Sel.Add(obj);
}
if (arrSenateGaugeItemsObjLst_Sel.Count > 0)
{
return arrSenateGaugeItemsObjLst_Sel[0].senateGaugeItemName;
}
string strErrMsgForGetObjById = string.Format("在SenateGaugeItems对象缓存列表中,找不到记录[id_SenateGaugeItem = {0}](函数:{1})", strid_SenateGaugeItem, clsStackTrace.GetCurrFunction());
clsLog.LogErrorS2("clsSenateGaugeItemsBL", clsStackTrace.GetCurrClassFunction(), strErrMsgForGetObjById, "", "");
throw new Exception(strErrMsgForGetObjById);
}
 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetRecNameByKey_Cache)
 /// </summary>
 /// <param name = "strid_SenateGaugeItem">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetNameByid_SenateGaugeItem_Cache(string strid_SenateGaugeItem)
{
if (string.IsNullOrEmpty(strid_SenateGaugeItem) == true) return "";
//初始化列表缓存
string strKey = string.Format("{0}", clsSenateGaugeItemsEN._CurrTabName_S);
List<clsSenateGaugeItemsEN> arrSenateGaugeItemsObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsSenateGaugeItemsEN> arrSenateGaugeItemsObjLst_Sel1 =
from objSenateGaugeItemsEN in arrSenateGaugeItemsObjLst_Cache
where objSenateGaugeItemsEN.id_SenateGaugeItem == strid_SenateGaugeItem
select objSenateGaugeItemsEN;
List <clsSenateGaugeItemsEN> arrSenateGaugeItemsObjLst_Sel = new List<clsSenateGaugeItemsEN>();
foreach (clsSenateGaugeItemsEN obj in arrSenateGaugeItemsObjLst_Sel1)
{
arrSenateGaugeItemsObjLst_Sel.Add(obj);
}
if (arrSenateGaugeItemsObjLst_Sel.Count > 0)
{
return arrSenateGaugeItemsObjLst_Sel[0].senateGaugeItemName;
}
string strErrMsgForGetObjById = string.Format("在SenateGaugeItems对象缓存列表中,找不到记录的相关名称[id_SenateGaugeItem = {0}](函数:{1})", strid_SenateGaugeItem, clsStackTrace.GetCurrFunction());
clsLog.LogErrorS2("clsSenateGaugeItemsBL", clsStackTrace.GetCurrClassFunction(), strErrMsgForGetObjById, "", "");
throw new Exception(strErrMsgForGetObjById);
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsSenateGaugeItemsEN> GetObjLst(string strWhereCond)
{
 List<clsSenateGaugeItemsEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsSenateGaugeItemsEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsSenateGaugeItemsEN> GetObjLstById_SenateGaugeItemLst(List<string> arrId_SenateGaugeItem)
{
 List<clsSenateGaugeItemsEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsSenateGaugeItemsEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static IEnumerable<clsSenateGaugeItemsEN> GetObjLstById_SenateGaugeItemLst_Cache(List<string> arrId_SenateGaugeItem)
{
//初始化列表缓存
string strKey = string.Format("{0}", clsSenateGaugeItemsEN._CurrTabName_S);
List<clsSenateGaugeItemsEN> arrSenateGaugeItemsObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsSenateGaugeItemsEN> arrSenateGaugeItemsObjLst_Sel =
from objSenateGaugeItemsEN in arrSenateGaugeItemsObjLst_Cache
where arrId_SenateGaugeItem.Contains(objSenateGaugeItemsEN.id_SenateGaugeItem)
select objSenateGaugeItemsEN;
return arrSenateGaugeItemsObjLst_Sel;
}

 /// <summary>
 /// 根据关键字列表获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstByKeyLst_WA_Cache)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsSenateGaugeItemsEN> GetObjLstById_SenateGaugeItemLst_WA_Cache(List<string> arrId_SenateGaugeItem)
{
 List<clsSenateGaugeItemsEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsSenateGaugeItemsEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsSenateGaugeItemsEN> GetTopObjLst(stuTopPara objTopPara)
{
 List<clsSenateGaugeItemsEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsSenateGaugeItemsEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsSenateGaugeItemsEN> GetObjLstByRange(stuRangePara objRangePara)
{
 List<clsSenateGaugeItemsEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsSenateGaugeItemsEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsSenateGaugeItemsEN> GetObjLstByPager(stuPagerPara objPagerPara)
{
 List<clsSenateGaugeItemsEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsSenateGaugeItemsEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsSenateGaugeItemsEN> GetObjLstByPager_Cache(stuPagerPara objPagerPara)
{
 List<clsSenateGaugeItemsEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsSenateGaugeItemsEN>>((string)jobjReturn["ReturnObjLst"]);
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
 /// 根据关键字删除记录
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_DelRecord)
 /// </summary>
 /// <returns>实际删除记录的个数</returns>
public static int DelRecord(string strid_SenateGaugeItem)
{
string strAction = "DelRecord";
string strErrMsg = string.Empty;
string strResult = "";
try
{
 clsSenateGaugeItemsEN objSenateGaugeItemsEN = clsSenateGaugeItemsWApi.GetObjByid_SenateGaugeItem(strid_SenateGaugeItem);
if (clsPubFun4WApi.Delete(mstrApiControllerName, strAction, strid_SenateGaugeItem.ToString(), out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
clsSenateGaugeItemsWApi.ReFreshCache();
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
 string strMsg = string.Format("执行WebApi功能出错, {0}.(from {1}). WebApi地址:{2}).",
      HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction(),
clsPubFun4WApi.GetWebApiUrl(mstrApiControllerName, strAction));
 throw new Exception(strMsg);
}
}

 /// <summary>
 /// 根据关键字列表删除记录
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_DelRecords)
 /// </summary>
 /// <returns>实际删除记录的个数</returns>
public static int DelRecords(string strKeyIdLst)
{
string strAction = "DelRecords";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
if (clsPubFun4WApi.Deletes(mstrApiControllerName, strAction, dictParam, strKeyIdLst, out strResult, out strErrMsg) == true)
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
 string strMsg = string.Format("执行WebApi功能出错, {0}.(from {1}). WebApi地址:{2}).",
      HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction(),
clsPubFun4WApi.GetWebApiUrl(mstrApiControllerName, strAction));
 throw new Exception(strMsg);
}
}

 /// <summary>
 /// 根据关键字列表删除记录
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_DelMultiRecord)
 /// </summary>
 /// <returns>实际删除记录的个数</returns>
public static int DelSenateGaugeItemss(List<string> arrid_SenateGaugeItem)
{
string strAction = "DelSenateGaugeItemss";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrid_SenateGaugeItem);
if (clsPubFun4WApi.Deletes(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
clsSenateGaugeItemsWApi.ReFreshCache();
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
 string strMsg = string.Format("执行WebApi功能出错, {0}.(from {1}). WebApi地址:{2}).",
      HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction(),
clsPubFun4WApi.GetWebApiUrl(mstrApiControllerName, strAction));
 throw new Exception(strMsg);
}
}

 /// <summary>
 /// 根据条件删除记录
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_DelMultiRecordByCond)
 /// </summary>
 /// <returns>实际删除记录的个数</returns>
public static int DelSenateGaugeItemssByCond(string strWhereCond)
{
string strAction = "DelSenateGaugeItemssByCond";
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
 string strMsg = string.Format("执行WebApi功能出错, {0}.(from {1}). WebApi地址:{2}).",
      HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction(),
clsPubFun4WApi.GetWebApiUrl(mstrApiControllerName, strAction));
 throw new Exception(strMsg);
}
}

 /// <summary>
 /// 添加记录
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_AddNewRecord)
 /// </summary>
 /// <returns>是否成功?</returns>
public static bool AddNewRecord(clsSenateGaugeItemsEN objSenateGaugeItemsEN)
{
string strAction = "AddNewRecord";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsSenateGaugeItemsEN>(objSenateGaugeItemsEN);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJson, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsSenateGaugeItemsWApi.ReFreshCache();
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
 string strMsg = string.Format("执行WebApi功能出错, {0}.(from {1}). WebApi地址:{2}).",
      HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction(),
clsPubFun4WApi.GetWebApiUrl(mstrApiControllerName, strAction));
 throw new Exception(strMsg);
}
}

 /// <summary>
 /// 添加记录
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_AddNewRecordWithMaxId)
 /// </summary>
 /// <returns>是否成功?</returns>
public static string AddNewRecordWithMaxId(clsSenateGaugeItemsEN objSenateGaugeItemsEN)
{
string strAction = "AddNewRecordWithMaxId";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsSenateGaugeItemsEN>(objSenateGaugeItemsEN);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJson, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsSenateGaugeItemsWApi.ReFreshCache();
var strid_SenateGaugeItem = (string)jobjReturn["ReturnStr"];
return strid_SenateGaugeItem;
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
 /// 修改记录
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_UpdateRecord)
 /// </summary>
 /// <returns>是否成功?</returns>
public static bool UpdateRecord(clsSenateGaugeItemsEN objSenateGaugeItemsEN)
{
if (string.IsNullOrEmpty(objSenateGaugeItemsEN.sf_UpdFldSetStr) == true)
{
string strMsg = string.Format("修改时，修改标志串为空，请联系管理员.对象关键字:{0}.(from {1}).",
objSenateGaugeItemsEN.id_SenateGaugeItem, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
string strAction = "UpdateRecord";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsSenateGaugeItemsEN>(objSenateGaugeItemsEN);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJson, out strResult, out strErrMsg) == true)
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
 string strMsg = string.Format("执行WebApi功能出错, {0}.(from {1}). WebApi地址:{2}).",
      HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction(),
clsPubFun4WApi.GetWebApiUrl(mstrApiControllerName, strAction));
 throw new Exception(strMsg);
}
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_UpdateWithCondition)
 /// </summary>
 /// <param name = "objSenateGaugeItemsEN">需要修改的对象</param>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的关键字值</returns>
public static bool UpdateWithCondition(clsSenateGaugeItemsEN objSenateGaugeItemsEN, string strWhereCond)
{
if (string.IsNullOrEmpty(objSenateGaugeItemsEN.sf_UpdFldSetStr) == true)
{
string strMsg = string.Format("修改时，修改标志串为空，请联系管理员.对象关键字:{0}.(from {1}).",
objSenateGaugeItemsEN.id_SenateGaugeItem, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (string.IsNullOrEmpty(strWhereCond) == true)
{
string strMsg = string.Format("按条件修改时，条件串为空，请联系管理员.对象关键字:{0}.(from {1}).",
objSenateGaugeItemsEN.id_SenateGaugeItem, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
string strAction = "UpdateWithCondition";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsSenateGaugeItemsEN>(objSenateGaugeItemsEN);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJson, out strResult, out strErrMsg) == true)
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
 /// 根据条件设置字段值
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_funSetFldValue)
 /// </summary>
 /// <param name = "strFldName">字段名</param>
 /// <param name = "strValue">值</param>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>记录数</returns>
public static int SetFldValue(string strFldName, string strValue, string strWhereCond)
{
string strAction = "SetFldValue";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["strFldName"] = strFldName,
["strValue"] = strValue,
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
string strMsg = string.Format("根据条件设置字段值,{0}.(from {1})", HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
}

 /// <summary>
 /// 获取当前表关键字值的最大值,再加1,避免重复
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetMaxStrId)
 /// </summary>
 /// <returns>当前表关键字值的最大值,再加1</returns>
public static string GetMaxStrId()
{
string strAction = "GetMaxStrId";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
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
string strMsg = string.Format("获取最大值出错,{0}.(from {1})", HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
}

 /// <summary>
 /// 根据前缀获取当前表关键字值的最大值,再加1,避免重复
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetMaxStrIdByPrefix)
 /// </summary>
 /// <returns>当前表关键字值的最大值,再加1</returns>
public static string GetMaxStrIdByPrefix(string strPrefix)
{
//检测记录是否存在
string strAction = "GetMaxStrIdByPrefix";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
dictParam.Add("strPrefix", strPrefix);
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
string strMsg = string.Format("根据前缀获取最大值出错,{0}.(from {1})", HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
}

 /// <summary>
 /// 获取字符串长度,其中汉字为2个字节,英文为1个字节
 /// (AutoGCLib.clsGeneCodeBase:GengetStrLen)
 /// </summary>
 /// <param name = "strTemp">给定的原字符串</param>
 /// <returns>返回字符串长度</returns>
public static int GetStrLen(string strTemp)
{
int len ;
byte[] sarr = System.Text.Encoding.Default.GetBytes(strTemp);
len = sarr.Length;//will output as 3+3*2 = 9
return len;
}

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_CopyObj_S)
 /// </summary>
 /// <param name = "objSenateGaugeItemsENS">源对象</param>
 /// <param name = "objSenateGaugeItemsENT">目标对象</param>
 public static void CopyTo(clsSenateGaugeItemsEN objSenateGaugeItemsENS, clsSenateGaugeItemsEN objSenateGaugeItemsENT)
{
try
{
objSenateGaugeItemsENT.id_SenateGaugeItem = objSenateGaugeItemsENS.id_SenateGaugeItem; //量表指标流水号
objSenateGaugeItemsENT.id_SenateGaugeVersion = objSenateGaugeItemsENS.id_SenateGaugeVersion; //评价量表版本流水号
objSenateGaugeItemsENT.senateGaugeItemID = objSenateGaugeItemsENS.senateGaugeItemID; //量表指标ID
objSenateGaugeItemsENT.senateGaugeItemName = objSenateGaugeItemsENS.senateGaugeItemName; //量表指标名称
objSenateGaugeItemsENT.senateGaugeItemDesc = objSenateGaugeItemsENS.senateGaugeItemDesc; //量表指标说明
objSenateGaugeItemsENT.senateGaugeItemWeight = objSenateGaugeItemsENS.senateGaugeItemWeight; //量表指标权重
objSenateGaugeItemsENT.AnswerModeId = objSenateGaugeItemsENS.AnswerModeId; //答案模式Id
objSenateGaugeItemsENT.AnswerTypeId = objSenateGaugeItemsENS.AnswerTypeId; //答案类型ID
objSenateGaugeItemsENT.GridTitle = objSenateGaugeItemsENS.GridTitle; //表格标题
objSenateGaugeItemsENT.QuestionIndex = objSenateGaugeItemsENS.QuestionIndex; //题目序号
objSenateGaugeItemsENT.QuestionNo = objSenateGaugeItemsENS.QuestionNo; //题目编号
objSenateGaugeItemsENT.QuestionTypeId = objSenateGaugeItemsENS.QuestionTypeId; //题目类型Id
objSenateGaugeItemsENT.IsHaveAdditionalMemo = objSenateGaugeItemsENS.IsHaveAdditionalMemo; //是否有附加说明
objSenateGaugeItemsENT.UpdDate = objSenateGaugeItemsENS.UpdDate; //修改日期
objSenateGaugeItemsENT.UpdUserId = objSenateGaugeItemsENS.UpdUserId; //修改用户Id
objSenateGaugeItemsENT.senateGaugeItemMemo = objSenateGaugeItemsENS.senateGaugeItemMemo; //备注
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
public static DataTable ToDataTable(List<clsSenateGaugeItemsEN> arrObj)
{
DataTable dataTable = new DataTable(); //实例化
DataTable result;
if (arrObj.Count == 0) return null;
if (clsSenateGaugeItemsEN.AttributeName.Length == 0)
{
result = dataTable;
return result;
}
Type type = typeof(clsSenateGaugeItemsEN);
PropertyInfo[] arrPropertyInfo = type.GetProperties();
try
{
//Columns
foreach (string strAttrName in clsSenateGaugeItemsEN.AttributeName)
{
PropertyInfo proprety_Curr = arrPropertyInfo.Where(x => x.Name == strAttrName).First();
dataTable.Columns.Add(strAttrName, proprety_Curr.PropertyType);
}
foreach (clsSenateGaugeItemsEN objInFor in arrObj)
{
//Rows
DataRow dataRow = dataTable.NewRow();
foreach (string strAttrName in clsSenateGaugeItemsEN.AttributeName)
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
if (clsSenateGaugeItemsWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsSenateGaugeItemsWApi没有刷新缓存机制(clsSenateGaugeItemsWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by id_SenateGaugeItem");
//if (arrSenateGaugeItemsObjLst_Cache == null)
//{
//arrSenateGaugeItemsObjLst_Cache = await clsSenateGaugeItemsWApi.GetObjLst(strWhereCond);
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
string strKey = string.Format("{0}", clsSenateGaugeItemsEN._CurrTabName_S);
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
 /// 刷新缓存.把当前表的缓存以及该表相关视图的缓存清空.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_ReFreshCache)
 /// </summary>
public static void ReFreshCache()
{
  if (clsSysParaEN.spIsUseQueue4Task == true)
{
if (clsSysParaEN.arrFunctionLst4Queue == null)
{
clsSysParaEN.arrFunctionLst4Queue = new Queue<object>();
}
}
if (clsSenateGaugeItemsWApi.objCommFun4BL != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}", clsSenateGaugeItemsEN._CurrTabName_S);
CacheHelper.Remove(strKey);
clsSenateGaugeItemsWApi.objCommFun4BL.ReFreshCache();
}
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst_Cache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsSenateGaugeItemsEN> GetObjLst_Cache()
{
//初始化列表缓存
InitListCache(); 
string strKey = string.Format("{0}", clsSenateGaugeItemsEN._CurrTabName_S);
List<clsSenateGaugeItemsEN> arrSenateGaugeItemsObjLst_Cache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrSenateGaugeItemsObjLst_Cache;
}

 /// <summary>
 /// 根据对象列表获取DataTable
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetDataTableByObjLst)
 /// </summary>
 /// <param name = "arrObjLst">给定的对象列表</param>
 /// <returns>返回DataTable</returns>
public static DataTable GetDataTableByObjLst(List<clsSenateGaugeItemsEN> arrObjLst)
{
DataTable objDT = new DataTable();
objDT.Columns.Add(conSenateGaugeItems.id_SenateGaugeItem, Type.GetType("System.String"));
objDT.Columns.Add(conSenateGaugeItems.id_SenateGaugeVersion, Type.GetType("System.String"));
objDT.Columns.Add(conSenateGaugeItems.senateGaugeItemID, Type.GetType("System.String"));
objDT.Columns.Add(conSenateGaugeItems.senateGaugeItemName, Type.GetType("System.String"));
objDT.Columns.Add(conSenateGaugeItems.senateGaugeItemDesc, Type.GetType("System.String"));
objDT.Columns.Add(conSenateGaugeItems.senateGaugeItemWeight, Type.GetType("System.Single"));
objDT.Columns.Add(conSenateGaugeItems.AnswerModeId, Type.GetType("System.String"));
objDT.Columns.Add(conSenateGaugeItems.AnswerTypeId, Type.GetType("System.String"));
objDT.Columns.Add(conSenateGaugeItems.GridTitle, Type.GetType("System.String"));
objDT.Columns.Add(conSenateGaugeItems.QuestionIndex, Type.GetType("System.Int32"));
objDT.Columns.Add(conSenateGaugeItems.QuestionNo, Type.GetType("System.String"));
objDT.Columns.Add(conSenateGaugeItems.QuestionTypeId, Type.GetType("System.String"));
objDT.Columns.Add(conSenateGaugeItems.IsHaveAdditionalMemo, Type.GetType("System.Boolean"));
objDT.Columns.Add(conSenateGaugeItems.UpdDate, Type.GetType("System.String"));
objDT.Columns.Add(conSenateGaugeItems.UpdUserId, Type.GetType("System.String"));
objDT.Columns.Add(conSenateGaugeItems.senateGaugeItemMemo, Type.GetType("System.String"));
foreach (clsSenateGaugeItemsEN objInFor in arrObjLst)
{
DataRow objDR = objDT.NewRow();
objDR[conSenateGaugeItems.id_SenateGaugeItem] = objInFor[conSenateGaugeItems.id_SenateGaugeItem];
objDR[conSenateGaugeItems.id_SenateGaugeVersion] = objInFor[conSenateGaugeItems.id_SenateGaugeVersion];
objDR[conSenateGaugeItems.senateGaugeItemID] = objInFor[conSenateGaugeItems.senateGaugeItemID];
objDR[conSenateGaugeItems.senateGaugeItemName] = objInFor[conSenateGaugeItems.senateGaugeItemName];
objDR[conSenateGaugeItems.senateGaugeItemDesc] = objInFor[conSenateGaugeItems.senateGaugeItemDesc];
objDR[conSenateGaugeItems.senateGaugeItemWeight] = objInFor[conSenateGaugeItems.senateGaugeItemWeight];
objDR[conSenateGaugeItems.AnswerModeId] = objInFor[conSenateGaugeItems.AnswerModeId];
objDR[conSenateGaugeItems.AnswerTypeId] = objInFor[conSenateGaugeItems.AnswerTypeId];
objDR[conSenateGaugeItems.GridTitle] = objInFor[conSenateGaugeItems.GridTitle];
objDR[conSenateGaugeItems.QuestionIndex] = objInFor[conSenateGaugeItems.QuestionIndex];
objDR[conSenateGaugeItems.QuestionNo] = objInFor[conSenateGaugeItems.QuestionNo];
objDR[conSenateGaugeItems.QuestionTypeId] = objInFor[conSenateGaugeItems.QuestionTypeId];
objDR[conSenateGaugeItems.IsHaveAdditionalMemo] = objInFor[conSenateGaugeItems.IsHaveAdditionalMemo];
objDR[conSenateGaugeItems.UpdDate] = objInFor[conSenateGaugeItems.UpdDate];
objDR[conSenateGaugeItems.UpdUserId] = objInFor[conSenateGaugeItems.UpdUserId];
objDR[conSenateGaugeItems.senateGaugeItemMemo] = objInFor[conSenateGaugeItems.senateGaugeItemMemo];
objDT.Rows.Add(objDR);
}
return objDT;
}
}
 /// <summary>
 /// 量表指标(SenateGaugeItems)
 /// 数据源类型:SQL表
 /// (AutoGCLib.CommFun4WA4CSharp:GeneCode_This)
 /// </summary>
public class clsCommFun4WA4SenateGaugeItems : clsCommFun4BL
{

 /// <summary>
 /// 刷新缓存.把当前表的缓存以及该表相关视图的缓存清空.
 /// (AutoGCLib.CommFun4WA4CSharp:Gen_4CFWA_ReFreshCache)
 /// </summary>
public override void ReFreshCache()
{
string strMsg = "";
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
clsSenateGaugeItemsWApi.ReFreshThisCache();
}
}

}