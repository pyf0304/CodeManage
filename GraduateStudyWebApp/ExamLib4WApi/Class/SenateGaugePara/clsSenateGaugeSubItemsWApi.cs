
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsSenateGaugeSubItemsWApi
 表名:SenateGaugeSubItems(01120478)
 生成代码版本:2021.09.20.1
 生成日期:2021/09/21 02:41:54
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
public static class clsSenateGaugeSubItemsWApi_Static
{

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objSenateGaugeSubItemsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsSenateGaugeSubItemsEN Setid_SenateGaugeSubItem(this clsSenateGaugeSubItemsEN objSenateGaugeSubItemsEN, string strid_SenateGaugeSubItem, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_SenateGaugeSubItem, 4, conSenateGaugeSubItems.id_SenateGaugeSubItem);
clsCheckSql.CheckFieldForeignKey(strid_SenateGaugeSubItem, 4, conSenateGaugeSubItems.id_SenateGaugeSubItem);
objSenateGaugeSubItemsEN.id_SenateGaugeSubItem = strid_SenateGaugeSubItem; //量表指标子项流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objSenateGaugeSubItemsEN.dicFldComparisonOp.ContainsKey(conSenateGaugeSubItems.id_SenateGaugeSubItem) == false)
{
objSenateGaugeSubItemsEN.dicFldComparisonOp.Add(conSenateGaugeSubItems.id_SenateGaugeSubItem, strComparisonOp);
}
else
{
objSenateGaugeSubItemsEN.dicFldComparisonOp[conSenateGaugeSubItems.id_SenateGaugeSubItem] = strComparisonOp;
}
}
return objSenateGaugeSubItemsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objSenateGaugeSubItemsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsSenateGaugeSubItemsEN Setid_SenateGaugeItem(this clsSenateGaugeSubItemsEN objSenateGaugeSubItemsEN, string strid_SenateGaugeItem, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strid_SenateGaugeItem, conSenateGaugeSubItems.id_SenateGaugeItem);
clsCheckSql.CheckFieldLen(strid_SenateGaugeItem, 4, conSenateGaugeSubItems.id_SenateGaugeItem);
clsCheckSql.CheckFieldForeignKey(strid_SenateGaugeItem, 4, conSenateGaugeSubItems.id_SenateGaugeItem);
objSenateGaugeSubItemsEN.id_SenateGaugeItem = strid_SenateGaugeItem; //量表指标流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objSenateGaugeSubItemsEN.dicFldComparisonOp.ContainsKey(conSenateGaugeSubItems.id_SenateGaugeItem) == false)
{
objSenateGaugeSubItemsEN.dicFldComparisonOp.Add(conSenateGaugeSubItems.id_SenateGaugeItem, strComparisonOp);
}
else
{
objSenateGaugeSubItemsEN.dicFldComparisonOp[conSenateGaugeSubItems.id_SenateGaugeItem] = strComparisonOp;
}
}
return objSenateGaugeSubItemsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objSenateGaugeSubItemsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsSenateGaugeSubItemsEN SetsenateGaugeSubItemID(this clsSenateGaugeSubItemsEN objSenateGaugeSubItemsEN, string strsenateGaugeSubItemID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strsenateGaugeSubItemID, conSenateGaugeSubItems.senateGaugeSubItemID);
clsCheckSql.CheckFieldLen(strsenateGaugeSubItemID, 4, conSenateGaugeSubItems.senateGaugeSubItemID);
clsCheckSql.CheckFieldForeignKey(strsenateGaugeSubItemID, 4, conSenateGaugeSubItems.senateGaugeSubItemID);
objSenateGaugeSubItemsEN.senateGaugeSubItemID = strsenateGaugeSubItemID; //量表指标子项ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objSenateGaugeSubItemsEN.dicFldComparisonOp.ContainsKey(conSenateGaugeSubItems.senateGaugeSubItemID) == false)
{
objSenateGaugeSubItemsEN.dicFldComparisonOp.Add(conSenateGaugeSubItems.senateGaugeSubItemID, strComparisonOp);
}
else
{
objSenateGaugeSubItemsEN.dicFldComparisonOp[conSenateGaugeSubItems.senateGaugeSubItemID] = strComparisonOp;
}
}
return objSenateGaugeSubItemsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objSenateGaugeSubItemsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsSenateGaugeSubItemsEN SetsenateGaugeSubItemName(this clsSenateGaugeSubItemsEN objSenateGaugeSubItemsEN, string strsenateGaugeSubItemName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strsenateGaugeSubItemName, conSenateGaugeSubItems.senateGaugeSubItemName);
clsCheckSql.CheckFieldLen(strsenateGaugeSubItemName, 200, conSenateGaugeSubItems.senateGaugeSubItemName);
objSenateGaugeSubItemsEN.senateGaugeSubItemName = strsenateGaugeSubItemName; //量表指标子项名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objSenateGaugeSubItemsEN.dicFldComparisonOp.ContainsKey(conSenateGaugeSubItems.senateGaugeSubItemName) == false)
{
objSenateGaugeSubItemsEN.dicFldComparisonOp.Add(conSenateGaugeSubItems.senateGaugeSubItemName, strComparisonOp);
}
else
{
objSenateGaugeSubItemsEN.dicFldComparisonOp[conSenateGaugeSubItems.senateGaugeSubItemName] = strComparisonOp;
}
}
return objSenateGaugeSubItemsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objSenateGaugeSubItemsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsSenateGaugeSubItemsEN SetsenateGaugeSubItemScore(this clsSenateGaugeSubItemsEN objSenateGaugeSubItemsEN, float fltsenateGaugeSubItemScore, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(fltsenateGaugeSubItemScore, conSenateGaugeSubItems.senateGaugeSubItemScore);
objSenateGaugeSubItemsEN.senateGaugeSubItemScore = fltsenateGaugeSubItemScore; //量表指标子项分数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objSenateGaugeSubItemsEN.dicFldComparisonOp.ContainsKey(conSenateGaugeSubItems.senateGaugeSubItemScore) == false)
{
objSenateGaugeSubItemsEN.dicFldComparisonOp.Add(conSenateGaugeSubItems.senateGaugeSubItemScore, strComparisonOp);
}
else
{
objSenateGaugeSubItemsEN.dicFldComparisonOp[conSenateGaugeSubItems.senateGaugeSubItemScore] = strComparisonOp;
}
}
return objSenateGaugeSubItemsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objSenateGaugeSubItemsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsSenateGaugeSubItemsEN SetsenateGaugeSubItemDesc(this clsSenateGaugeSubItemsEN objSenateGaugeSubItemsEN, string strsenateGaugeSubItemDesc, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strsenateGaugeSubItemDesc, 2000, conSenateGaugeSubItems.senateGaugeSubItemDesc);
objSenateGaugeSubItemsEN.senateGaugeSubItemDesc = strsenateGaugeSubItemDesc; //量表指标子项说明
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objSenateGaugeSubItemsEN.dicFldComparisonOp.ContainsKey(conSenateGaugeSubItems.senateGaugeSubItemDesc) == false)
{
objSenateGaugeSubItemsEN.dicFldComparisonOp.Add(conSenateGaugeSubItems.senateGaugeSubItemDesc, strComparisonOp);
}
else
{
objSenateGaugeSubItemsEN.dicFldComparisonOp[conSenateGaugeSubItems.senateGaugeSubItemDesc] = strComparisonOp;
}
}
return objSenateGaugeSubItemsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objSenateGaugeSubItemsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsSenateGaugeSubItemsEN SetAnswerTitle(this clsSenateGaugeSubItemsEN objSenateGaugeSubItemsEN, string strAnswerTitle, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strAnswerTitle, 20, conSenateGaugeSubItems.AnswerTitle);
objSenateGaugeSubItemsEN.AnswerTitle = strAnswerTitle; //答案标题
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objSenateGaugeSubItemsEN.dicFldComparisonOp.ContainsKey(conSenateGaugeSubItems.AnswerTitle) == false)
{
objSenateGaugeSubItemsEN.dicFldComparisonOp.Add(conSenateGaugeSubItems.AnswerTitle, strComparisonOp);
}
else
{
objSenateGaugeSubItemsEN.dicFldComparisonOp[conSenateGaugeSubItems.AnswerTitle] = strComparisonOp;
}
}
return objSenateGaugeSubItemsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objSenateGaugeSubItemsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsSenateGaugeSubItemsEN SetAnswerIndex(this clsSenateGaugeSubItemsEN objSenateGaugeSubItemsEN, int intAnswerIndex, string strComparisonOp="")
	{
objSenateGaugeSubItemsEN.AnswerIndex = intAnswerIndex; //问答序号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objSenateGaugeSubItemsEN.dicFldComparisonOp.ContainsKey(conSenateGaugeSubItems.AnswerIndex) == false)
{
objSenateGaugeSubItemsEN.dicFldComparisonOp.Add(conSenateGaugeSubItems.AnswerIndex, strComparisonOp);
}
else
{
objSenateGaugeSubItemsEN.dicFldComparisonOp[conSenateGaugeSubItems.AnswerIndex] = strComparisonOp;
}
}
return objSenateGaugeSubItemsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objSenateGaugeSubItemsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsSenateGaugeSubItemsEN SetUpdDate(this clsSenateGaugeSubItemsEN objSenateGaugeSubItemsEN, string strUpdDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdDate, 20, conSenateGaugeSubItems.UpdDate);
objSenateGaugeSubItemsEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objSenateGaugeSubItemsEN.dicFldComparisonOp.ContainsKey(conSenateGaugeSubItems.UpdDate) == false)
{
objSenateGaugeSubItemsEN.dicFldComparisonOp.Add(conSenateGaugeSubItems.UpdDate, strComparisonOp);
}
else
{
objSenateGaugeSubItemsEN.dicFldComparisonOp[conSenateGaugeSubItems.UpdDate] = strComparisonOp;
}
}
return objSenateGaugeSubItemsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objSenateGaugeSubItemsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsSenateGaugeSubItemsEN SetUpdUserId(this clsSenateGaugeSubItemsEN objSenateGaugeSubItemsEN, string strUpdUserId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdUserId, 20, conSenateGaugeSubItems.UpdUserId);
objSenateGaugeSubItemsEN.UpdUserId = strUpdUserId; //修改用户Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objSenateGaugeSubItemsEN.dicFldComparisonOp.ContainsKey(conSenateGaugeSubItems.UpdUserId) == false)
{
objSenateGaugeSubItemsEN.dicFldComparisonOp.Add(conSenateGaugeSubItems.UpdUserId, strComparisonOp);
}
else
{
objSenateGaugeSubItemsEN.dicFldComparisonOp[conSenateGaugeSubItems.UpdUserId] = strComparisonOp;
}
}
return objSenateGaugeSubItemsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objSenateGaugeSubItemsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsSenateGaugeSubItemsEN SetsenateGaugeSubItemMemo(this clsSenateGaugeSubItemsEN objSenateGaugeSubItemsEN, string strsenateGaugeSubItemMemo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strsenateGaugeSubItemMemo, 1000, conSenateGaugeSubItems.senateGaugeSubItemMemo);
objSenateGaugeSubItemsEN.senateGaugeSubItemMemo = strsenateGaugeSubItemMemo; //量表指标子项备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objSenateGaugeSubItemsEN.dicFldComparisonOp.ContainsKey(conSenateGaugeSubItems.senateGaugeSubItemMemo) == false)
{
objSenateGaugeSubItemsEN.dicFldComparisonOp.Add(conSenateGaugeSubItems.senateGaugeSubItemMemo, strComparisonOp);
}
else
{
objSenateGaugeSubItemsEN.dicFldComparisonOp[conSenateGaugeSubItems.senateGaugeSubItemMemo] = strComparisonOp;
}
}
return objSenateGaugeSubItemsEN;
	}

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsSenateGaugeSubItemsEN objSenateGaugeSubItems_Cond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objSenateGaugeSubItems_Cond.IsUpdated(conSenateGaugeSubItems.id_SenateGaugeSubItem) == true)
{
string strComparisonOp_id_SenateGaugeSubItem = objSenateGaugeSubItems_Cond.dicFldComparisonOp[conSenateGaugeSubItems.id_SenateGaugeSubItem];
strWhereCond += string.Format(" And {0} {2} '{1}'", conSenateGaugeSubItems.id_SenateGaugeSubItem, objSenateGaugeSubItems_Cond.id_SenateGaugeSubItem, strComparisonOp_id_SenateGaugeSubItem);
}
if (objSenateGaugeSubItems_Cond.IsUpdated(conSenateGaugeSubItems.id_SenateGaugeItem) == true)
{
string strComparisonOp_id_SenateGaugeItem = objSenateGaugeSubItems_Cond.dicFldComparisonOp[conSenateGaugeSubItems.id_SenateGaugeItem];
strWhereCond += string.Format(" And {0} {2} '{1}'", conSenateGaugeSubItems.id_SenateGaugeItem, objSenateGaugeSubItems_Cond.id_SenateGaugeItem, strComparisonOp_id_SenateGaugeItem);
}
if (objSenateGaugeSubItems_Cond.IsUpdated(conSenateGaugeSubItems.senateGaugeSubItemID) == true)
{
string strComparisonOp_senateGaugeSubItemID = objSenateGaugeSubItems_Cond.dicFldComparisonOp[conSenateGaugeSubItems.senateGaugeSubItemID];
strWhereCond += string.Format(" And {0} {2} '{1}'", conSenateGaugeSubItems.senateGaugeSubItemID, objSenateGaugeSubItems_Cond.senateGaugeSubItemID, strComparisonOp_senateGaugeSubItemID);
}
if (objSenateGaugeSubItems_Cond.IsUpdated(conSenateGaugeSubItems.senateGaugeSubItemName) == true)
{
string strComparisonOp_senateGaugeSubItemName = objSenateGaugeSubItems_Cond.dicFldComparisonOp[conSenateGaugeSubItems.senateGaugeSubItemName];
strWhereCond += string.Format(" And {0} {2} '{1}'", conSenateGaugeSubItems.senateGaugeSubItemName, objSenateGaugeSubItems_Cond.senateGaugeSubItemName, strComparisonOp_senateGaugeSubItemName);
}
if (objSenateGaugeSubItems_Cond.IsUpdated(conSenateGaugeSubItems.senateGaugeSubItemScore) == true)
{
string strComparisonOp_senateGaugeSubItemScore = objSenateGaugeSubItems_Cond.dicFldComparisonOp[conSenateGaugeSubItems.senateGaugeSubItemScore];
strWhereCond += string.Format(" And {0} {2} {1}", conSenateGaugeSubItems.senateGaugeSubItemScore, objSenateGaugeSubItems_Cond.senateGaugeSubItemScore, strComparisonOp_senateGaugeSubItemScore);
}
if (objSenateGaugeSubItems_Cond.IsUpdated(conSenateGaugeSubItems.senateGaugeSubItemDesc) == true)
{
string strComparisonOp_senateGaugeSubItemDesc = objSenateGaugeSubItems_Cond.dicFldComparisonOp[conSenateGaugeSubItems.senateGaugeSubItemDesc];
strWhereCond += string.Format(" And {0} {2} '{1}'", conSenateGaugeSubItems.senateGaugeSubItemDesc, objSenateGaugeSubItems_Cond.senateGaugeSubItemDesc, strComparisonOp_senateGaugeSubItemDesc);
}
if (objSenateGaugeSubItems_Cond.IsUpdated(conSenateGaugeSubItems.AnswerTitle) == true)
{
string strComparisonOp_AnswerTitle = objSenateGaugeSubItems_Cond.dicFldComparisonOp[conSenateGaugeSubItems.AnswerTitle];
strWhereCond += string.Format(" And {0} {2} '{1}'", conSenateGaugeSubItems.AnswerTitle, objSenateGaugeSubItems_Cond.AnswerTitle, strComparisonOp_AnswerTitle);
}
if (objSenateGaugeSubItems_Cond.IsUpdated(conSenateGaugeSubItems.AnswerIndex) == true)
{
string strComparisonOp_AnswerIndex = objSenateGaugeSubItems_Cond.dicFldComparisonOp[conSenateGaugeSubItems.AnswerIndex];
strWhereCond += string.Format(" And {0} {2} {1}", conSenateGaugeSubItems.AnswerIndex, objSenateGaugeSubItems_Cond.AnswerIndex, strComparisonOp_AnswerIndex);
}
if (objSenateGaugeSubItems_Cond.IsUpdated(conSenateGaugeSubItems.UpdDate) == true)
{
string strComparisonOp_UpdDate = objSenateGaugeSubItems_Cond.dicFldComparisonOp[conSenateGaugeSubItems.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conSenateGaugeSubItems.UpdDate, objSenateGaugeSubItems_Cond.UpdDate, strComparisonOp_UpdDate);
}
if (objSenateGaugeSubItems_Cond.IsUpdated(conSenateGaugeSubItems.UpdUserId) == true)
{
string strComparisonOp_UpdUserId = objSenateGaugeSubItems_Cond.dicFldComparisonOp[conSenateGaugeSubItems.UpdUserId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conSenateGaugeSubItems.UpdUserId, objSenateGaugeSubItems_Cond.UpdUserId, strComparisonOp_UpdUserId);
}
if (objSenateGaugeSubItems_Cond.IsUpdated(conSenateGaugeSubItems.senateGaugeSubItemMemo) == true)
{
string strComparisonOp_senateGaugeSubItemMemo = objSenateGaugeSubItems_Cond.dicFldComparisonOp[conSenateGaugeSubItems.senateGaugeSubItemMemo];
strWhereCond += string.Format(" And {0} {2} '{1}'", conSenateGaugeSubItems.senateGaugeSubItemMemo, objSenateGaugeSubItems_Cond.senateGaugeSubItemMemo, strComparisonOp_senateGaugeSubItemMemo);
}
 return strWhereCond;
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_Update)
 /// </summary>
 /// <param name = "objSenateGaugeSubItemsEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsSenateGaugeSubItemsEN objSenateGaugeSubItemsEN)
{
 if (string.IsNullOrEmpty(objSenateGaugeSubItemsEN.id_SenateGaugeSubItem) == true)
 {
string strMsg = string.Format("(errid:Watl000003)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
objSenateGaugeSubItemsEN.sf_UpdFldSetStr = objSenateGaugeSubItemsEN.getsf_UpdFldSetStr();
clsSenateGaugeSubItemsWApi.CheckPropertyNew(objSenateGaugeSubItemsEN); 
bool bolResult = clsSenateGaugeSubItemsWApi.UpdateRecord(objSenateGaugeSubItemsEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsSenateGaugeSubItemsWApi.ReFreshCache();
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
 /// <param name = "objSenateGaugeSubItemsEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clsSenateGaugeSubItemsEN objSenateGaugeSubItemsEN)
{
 if (string.IsNullOrEmpty(objSenateGaugeSubItemsEN.id_SenateGaugeSubItem) == true)
 {
string strMsg = string.Format("添加记录时，关键字不能为空!(from {0})\r\n", 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
 if (clsSenateGaugeSubItemsWApi.IsExist(objSenateGaugeSubItemsEN.id_SenateGaugeSubItem) == true)
 {
string strMsg = string.Format("添加记录时，关键字:[{0}]已经存在!(from {1})\r\n", objSenateGaugeSubItemsEN.id_SenateGaugeSubItem, 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
try
{
clsSenateGaugeSubItemsWApi.CheckPropertyNew(objSenateGaugeSubItemsEN); 
bool bolResult = clsSenateGaugeSubItemsWApi.AddNewRecord(objSenateGaugeSubItemsEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsSenateGaugeSubItemsWApi.ReFreshCache();
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
 /// <param name = "objSenateGaugeSubItemsEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static string AddNewRecordWithMaxId(this clsSenateGaugeSubItemsEN objSenateGaugeSubItemsEN)
{
try
{
clsSenateGaugeSubItemsWApi.CheckPropertyNew(objSenateGaugeSubItemsEN); 
string strid_SenateGaugeSubItem = clsSenateGaugeSubItemsWApi.AddNewRecordWithMaxId(objSenateGaugeSubItemsEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsSenateGaugeSubItemsWApi.ReFreshCache();
return strid_SenateGaugeSubItem;
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
 /// <param name = "objSenateGaugeSubItemsEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsSenateGaugeSubItemsEN objSenateGaugeSubItemsEN, string strWhereCond)
{
try
{
clsSenateGaugeSubItemsWApi.CheckPropertyNew(objSenateGaugeSubItemsEN); 
bool bolResult = clsSenateGaugeSubItemsWApi.UpdateWithCondition(objSenateGaugeSubItemsEN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsSenateGaugeSubItemsWApi.ReFreshCache();
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
 /// 量表指标子项(SenateGaugeSubItems)
 /// (AutoGCLib.WA_Access4CSharp:GeneCode)
 /// </summary>
public class clsSenateGaugeSubItemsWApi
{
private static readonly string mstrApiControllerName = "SenateGaugeSubItemsApi";

 /// <summary>
/// 专门在逻辑层用于处理缓存等公共函数的对象
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_DefineObjCommFun4BL)
/// </summary>
public static clsCommFun4BL objCommFun4BL = null;

 public clsSenateGaugeSubItemsWApi()
 {
 }

 /// <summary>
 /// 绑定基于Web的下拉框
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_DdlBindFunction)
 /// </summary>
 /// <param name="objDDL">需要绑定当前表的下拉框</param>
public static void BindDdl_id_SenateGaugeSubItem(System.Web.UI.WebControls.DropDownList objDDL)
{
//为数据源于表的下拉框设置内容
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[量表指标子项]...","0");
List<clsSenateGaugeSubItemsEN> arrObjLst = GetObjLst("1=1");
objDDL.DataValueField="id_SenateGaugeSubItem";
objDDL.DataTextField="senateGaugeSubItemName";
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
public static void BindCbo_id_SenateGaugeSubItem(System.Windows.Forms.ComboBox objComboBox )
{
//为数据源为表的下拉框设置内容
string strCondition = string.Format("1 =1 Order By {0}", conSenateGaugeSubItems.id_SenateGaugeSubItem); 
List<clsSenateGaugeSubItemsEN> arrObjLst = clsSenateGaugeSubItemsWApi.GetObjLst(strCondition);
//初始化一个对象列表
//插入第0项。在第0项中插入“请选择...”,为了方便用户,与WEB方式类似。
clsSenateGaugeSubItemsEN objSenateGaugeSubItemsEN = new clsSenateGaugeSubItemsEN()
{
id_SenateGaugeSubItem = "0",
senateGaugeSubItemName = "选[量表指标子项]..."
};
arrObjLst.Insert(0, objSenateGaugeSubItemsEN);
//设置下拉框的数据源、以及设置值项、显示项
objComboBox.ValueMember = conSenateGaugeSubItems.id_SenateGaugeSubItem;
objComboBox.DisplayMember = conSenateGaugeSubItems.senateGaugeSubItemName;
objComboBox.DataSource = arrObjLst;
objComboBox.SelectedIndex = 0;
}

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_CheckPropertyNew)
 /// </summary>
public static void CheckPropertyNew(clsSenateGaugeSubItemsEN objSenateGaugeSubItemsEN)
{
if (!Object.Equals(null, objSenateGaugeSubItemsEN.id_SenateGaugeSubItem) && GetStrLen(objSenateGaugeSubItemsEN.id_SenateGaugeSubItem) > 4)
{
 throw new Exception("字段[量表指标子项流水号]的长度不能超过4!");
}
if (!Object.Equals(null, objSenateGaugeSubItemsEN.id_SenateGaugeItem) && GetStrLen(objSenateGaugeSubItemsEN.id_SenateGaugeItem) > 4)
{
 throw new Exception("字段[量表指标流水号]的长度不能超过4!");
}
if (!Object.Equals(null, objSenateGaugeSubItemsEN.senateGaugeSubItemID) && GetStrLen(objSenateGaugeSubItemsEN.senateGaugeSubItemID) > 4)
{
 throw new Exception("字段[量表指标子项ID]的长度不能超过4!");
}
if (!Object.Equals(null, objSenateGaugeSubItemsEN.senateGaugeSubItemName) && GetStrLen(objSenateGaugeSubItemsEN.senateGaugeSubItemName) > 200)
{
 throw new Exception("字段[量表指标子项名称]的长度不能超过200!");
}
if (!Object.Equals(null, objSenateGaugeSubItemsEN.senateGaugeSubItemDesc) && GetStrLen(objSenateGaugeSubItemsEN.senateGaugeSubItemDesc) > 2000)
{
 throw new Exception("字段[量表指标子项说明]的长度不能超过2000!");
}
if (!Object.Equals(null, objSenateGaugeSubItemsEN.AnswerTitle) && GetStrLen(objSenateGaugeSubItemsEN.AnswerTitle) > 20)
{
 throw new Exception("字段[答案标题]的长度不能超过20!");
}
if (!Object.Equals(null, objSenateGaugeSubItemsEN.UpdDate) && GetStrLen(objSenateGaugeSubItemsEN.UpdDate) > 20)
{
 throw new Exception("字段[修改日期]的长度不能超过20!");
}
if (!Object.Equals(null, objSenateGaugeSubItemsEN.UpdUserId) && GetStrLen(objSenateGaugeSubItemsEN.UpdUserId) > 20)
{
 throw new Exception("字段[修改用户Id]的长度不能超过20!");
}
if (!Object.Equals(null, objSenateGaugeSubItemsEN.senateGaugeSubItemMemo) && GetStrLen(objSenateGaugeSubItemsEN.senateGaugeSubItemMemo) > 1000)
{
 throw new Exception("字段[量表指标子项备注]的长度不能超过1000!");
}
 objSenateGaugeSubItemsEN._IsCheckProperty = true;
 }

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyId)
 /// </summary>
 /// <param name = "strid_SenateGaugeSubItem">表关键字</param>
 /// <returns>表对象</returns>
public static clsSenateGaugeSubItemsEN GetObjByid_SenateGaugeSubItem(string strid_SenateGaugeSubItem)
{
string strAction = "GetObjByid_SenateGaugeSubItem";
string strErrMsg = string.Empty;
string strResult = "";
clsSenateGaugeSubItemsEN objSenateGaugeSubItemsEN = null;
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
objSenateGaugeSubItemsEN = JsonConvert.DeserializeObject<clsSenateGaugeSubItemsEN>((string)jobjReturn["ReturnObj"]);
return objSenateGaugeSubItemsEN;
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
public static clsSenateGaugeSubItemsEN GetObjByid_SenateGaugeSubItem_WA_Cache(string strid_SenateGaugeSubItem)
{
string strAction = "GetObjByid_SenateGaugeSubItem_Cache";
string strErrMsg = string.Empty;
string strResult = "";
clsSenateGaugeSubItemsEN objSenateGaugeSubItemsEN = null;
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
objSenateGaugeSubItemsEN = JsonConvert.DeserializeObject<clsSenateGaugeSubItemsEN>((string)jobjReturn["ReturnObj"]);
return objSenateGaugeSubItemsEN;
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
public static clsSenateGaugeSubItemsEN GetFirstObj(string strWhereCond)
{
string strAction = "GetFirstObj";
string strErrMsg = string.Empty;
string strResult = "";
clsSenateGaugeSubItemsEN objSenateGaugeSubItemsEN = null;
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
objSenateGaugeSubItemsEN = JsonConvert.DeserializeObject<clsSenateGaugeSubItemsEN>((string)jobjReturn["ReturnObj"]);
return objSenateGaugeSubItemsEN;
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
public static clsSenateGaugeSubItemsEN GetObjByid_SenateGaugeSubItem_Cache(string strid_SenateGaugeSubItem)
{
if (string.IsNullOrEmpty(strid_SenateGaugeSubItem) == true) return null;
//初始化列表缓存
string strKey = string.Format("{0}", clsSenateGaugeSubItemsEN._CurrTabName_S);
List<clsSenateGaugeSubItemsEN> arrSenateGaugeSubItemsObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsSenateGaugeSubItemsEN> arrSenateGaugeSubItemsObjLst_Sel =
from objSenateGaugeSubItemsEN in arrSenateGaugeSubItemsObjLst_Cache
where objSenateGaugeSubItemsEN.id_SenateGaugeSubItem == strid_SenateGaugeSubItem
select objSenateGaugeSubItemsEN;
if (arrSenateGaugeSubItemsObjLst_Sel.Count() == 0)
{
   clsSenateGaugeSubItemsEN obj = clsSenateGaugeSubItemsWApi.GetObjByid_SenateGaugeSubItem(strid_SenateGaugeSubItem);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
     return obj;
 }
return null;
}
return arrSenateGaugeSubItemsObjLst_Sel.First();
}

 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetRecNameByKey_Cache)
 /// </summary>
 /// <param name = "strid_SenateGaugeSubItem">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetsenateGaugeSubItemNameByid_SenateGaugeSubItem_Cache(string strid_SenateGaugeSubItem)
{
if (string.IsNullOrEmpty(strid_SenateGaugeSubItem) == true) return "";
//初始化列表缓存
string strKey = string.Format("{0}", clsSenateGaugeSubItemsEN._CurrTabName_S);
List<clsSenateGaugeSubItemsEN> arrSenateGaugeSubItemsObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsSenateGaugeSubItemsEN> arrSenateGaugeSubItemsObjLst_Sel1 =
from objSenateGaugeSubItemsEN in arrSenateGaugeSubItemsObjLst_Cache
where objSenateGaugeSubItemsEN.id_SenateGaugeSubItem == strid_SenateGaugeSubItem
select objSenateGaugeSubItemsEN;
List <clsSenateGaugeSubItemsEN> arrSenateGaugeSubItemsObjLst_Sel = new List<clsSenateGaugeSubItemsEN>();
foreach (clsSenateGaugeSubItemsEN obj in arrSenateGaugeSubItemsObjLst_Sel1)
{
arrSenateGaugeSubItemsObjLst_Sel.Add(obj);
}
if (arrSenateGaugeSubItemsObjLst_Sel.Count > 0)
{
return arrSenateGaugeSubItemsObjLst_Sel[0].senateGaugeSubItemName;
}
string strErrMsgForGetObjById = string.Format("在SenateGaugeSubItems对象缓存列表中,找不到记录[id_SenateGaugeSubItem = {0}](函数:{1})", strid_SenateGaugeSubItem, clsStackTrace.GetCurrFunction());
clsLog.LogErrorS2("clsSenateGaugeSubItemsBL", clsStackTrace.GetCurrClassFunction(), strErrMsgForGetObjById, "", "");
throw new Exception(strErrMsgForGetObjById);
}
 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetRecNameByKey_Cache)
 /// </summary>
 /// <param name = "strid_SenateGaugeSubItem">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetNameByid_SenateGaugeSubItem_Cache(string strid_SenateGaugeSubItem)
{
if (string.IsNullOrEmpty(strid_SenateGaugeSubItem) == true) return "";
//初始化列表缓存
string strKey = string.Format("{0}", clsSenateGaugeSubItemsEN._CurrTabName_S);
List<clsSenateGaugeSubItemsEN> arrSenateGaugeSubItemsObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsSenateGaugeSubItemsEN> arrSenateGaugeSubItemsObjLst_Sel1 =
from objSenateGaugeSubItemsEN in arrSenateGaugeSubItemsObjLst_Cache
where objSenateGaugeSubItemsEN.id_SenateGaugeSubItem == strid_SenateGaugeSubItem
select objSenateGaugeSubItemsEN;
List <clsSenateGaugeSubItemsEN> arrSenateGaugeSubItemsObjLst_Sel = new List<clsSenateGaugeSubItemsEN>();
foreach (clsSenateGaugeSubItemsEN obj in arrSenateGaugeSubItemsObjLst_Sel1)
{
arrSenateGaugeSubItemsObjLst_Sel.Add(obj);
}
if (arrSenateGaugeSubItemsObjLst_Sel.Count > 0)
{
return arrSenateGaugeSubItemsObjLst_Sel[0].senateGaugeSubItemName;
}
string strErrMsgForGetObjById = string.Format("在SenateGaugeSubItems对象缓存列表中,找不到记录的相关名称[id_SenateGaugeSubItem = {0}](函数:{1})", strid_SenateGaugeSubItem, clsStackTrace.GetCurrFunction());
clsLog.LogErrorS2("clsSenateGaugeSubItemsBL", clsStackTrace.GetCurrClassFunction(), strErrMsgForGetObjById, "", "");
throw new Exception(strErrMsgForGetObjById);
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsSenateGaugeSubItemsEN> GetObjLst(string strWhereCond)
{
 List<clsSenateGaugeSubItemsEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsSenateGaugeSubItemsEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsSenateGaugeSubItemsEN> GetObjLstById_SenateGaugeSubItemLst(List<string> arrId_SenateGaugeSubItem)
{
 List<clsSenateGaugeSubItemsEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsSenateGaugeSubItemsEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static IEnumerable<clsSenateGaugeSubItemsEN> GetObjLstById_SenateGaugeSubItemLst_Cache(List<string> arrId_SenateGaugeSubItem)
{
//初始化列表缓存
string strKey = string.Format("{0}", clsSenateGaugeSubItemsEN._CurrTabName_S);
List<clsSenateGaugeSubItemsEN> arrSenateGaugeSubItemsObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsSenateGaugeSubItemsEN> arrSenateGaugeSubItemsObjLst_Sel =
from objSenateGaugeSubItemsEN in arrSenateGaugeSubItemsObjLst_Cache
where arrId_SenateGaugeSubItem.Contains(objSenateGaugeSubItemsEN.id_SenateGaugeSubItem)
select objSenateGaugeSubItemsEN;
return arrSenateGaugeSubItemsObjLst_Sel;
}

 /// <summary>
 /// 根据关键字列表获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstByKeyLst_WA_Cache)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsSenateGaugeSubItemsEN> GetObjLstById_SenateGaugeSubItemLst_WA_Cache(List<string> arrId_SenateGaugeSubItem)
{
 List<clsSenateGaugeSubItemsEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsSenateGaugeSubItemsEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsSenateGaugeSubItemsEN> GetTopObjLst(stuTopPara objTopPara)
{
 List<clsSenateGaugeSubItemsEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsSenateGaugeSubItemsEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsSenateGaugeSubItemsEN> GetObjLstByRange(stuRangePara objRangePara)
{
 List<clsSenateGaugeSubItemsEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsSenateGaugeSubItemsEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsSenateGaugeSubItemsEN> GetObjLstByPager(stuPagerPara objPagerPara)
{
 List<clsSenateGaugeSubItemsEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsSenateGaugeSubItemsEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsSenateGaugeSubItemsEN> GetObjLstByPager_Cache(stuPagerPara objPagerPara)
{
 List<clsSenateGaugeSubItemsEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsSenateGaugeSubItemsEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static int DelRecord(string strid_SenateGaugeSubItem)
{
string strAction = "DelRecord";
string strErrMsg = string.Empty;
string strResult = "";
try
{
 clsSenateGaugeSubItemsEN objSenateGaugeSubItemsEN = clsSenateGaugeSubItemsWApi.GetObjByid_SenateGaugeSubItem(strid_SenateGaugeSubItem);
if (clsPubFun4WApi.Delete(mstrApiControllerName, strAction, strid_SenateGaugeSubItem.ToString(), out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
clsSenateGaugeSubItemsWApi.ReFreshCache();
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
public static int DelSenateGaugeSubItemss(List<string> arrid_SenateGaugeSubItem)
{
string strAction = "DelSenateGaugeSubItemss";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrid_SenateGaugeSubItem);
if (clsPubFun4WApi.Deletes(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
clsSenateGaugeSubItemsWApi.ReFreshCache();
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
public static int DelSenateGaugeSubItemssByCond(string strWhereCond)
{
string strAction = "DelSenateGaugeSubItemssByCond";
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
public static bool AddNewRecord(clsSenateGaugeSubItemsEN objSenateGaugeSubItemsEN)
{
string strAction = "AddNewRecord";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsSenateGaugeSubItemsEN>(objSenateGaugeSubItemsEN);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJson, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsSenateGaugeSubItemsWApi.ReFreshCache();
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
public static string AddNewRecordWithMaxId(clsSenateGaugeSubItemsEN objSenateGaugeSubItemsEN)
{
string strAction = "AddNewRecordWithMaxId";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsSenateGaugeSubItemsEN>(objSenateGaugeSubItemsEN);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJson, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsSenateGaugeSubItemsWApi.ReFreshCache();
var strid_SenateGaugeSubItem = (string)jobjReturn["ReturnStr"];
return strid_SenateGaugeSubItem;
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
public static bool UpdateRecord(clsSenateGaugeSubItemsEN objSenateGaugeSubItemsEN)
{
if (string.IsNullOrEmpty(objSenateGaugeSubItemsEN.sf_UpdFldSetStr) == true)
{
string strMsg = string.Format("修改时，修改标志串为空，请联系管理员.对象关键字:{0}.(from {1}).",
objSenateGaugeSubItemsEN.id_SenateGaugeSubItem, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
string strAction = "UpdateRecord";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsSenateGaugeSubItemsEN>(objSenateGaugeSubItemsEN);
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
 /// <param name = "objSenateGaugeSubItemsEN">需要修改的对象</param>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的关键字值</returns>
public static bool UpdateWithCondition(clsSenateGaugeSubItemsEN objSenateGaugeSubItemsEN, string strWhereCond)
{
if (string.IsNullOrEmpty(objSenateGaugeSubItemsEN.sf_UpdFldSetStr) == true)
{
string strMsg = string.Format("修改时，修改标志串为空，请联系管理员.对象关键字:{0}.(from {1}).",
objSenateGaugeSubItemsEN.id_SenateGaugeSubItem, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (string.IsNullOrEmpty(strWhereCond) == true)
{
string strMsg = string.Format("按条件修改时，条件串为空，请联系管理员.对象关键字:{0}.(from {1}).",
objSenateGaugeSubItemsEN.id_SenateGaugeSubItem, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
string strAction = "UpdateWithCondition";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsSenateGaugeSubItemsEN>(objSenateGaugeSubItemsEN);
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
 /// <param name = "objSenateGaugeSubItemsENS">源对象</param>
 /// <param name = "objSenateGaugeSubItemsENT">目标对象</param>
 public static void CopyTo(clsSenateGaugeSubItemsEN objSenateGaugeSubItemsENS, clsSenateGaugeSubItemsEN objSenateGaugeSubItemsENT)
{
try
{
objSenateGaugeSubItemsENT.id_SenateGaugeSubItem = objSenateGaugeSubItemsENS.id_SenateGaugeSubItem; //量表指标子项流水号
objSenateGaugeSubItemsENT.id_SenateGaugeItem = objSenateGaugeSubItemsENS.id_SenateGaugeItem; //量表指标流水号
objSenateGaugeSubItemsENT.senateGaugeSubItemID = objSenateGaugeSubItemsENS.senateGaugeSubItemID; //量表指标子项ID
objSenateGaugeSubItemsENT.senateGaugeSubItemName = objSenateGaugeSubItemsENS.senateGaugeSubItemName; //量表指标子项名称
objSenateGaugeSubItemsENT.senateGaugeSubItemScore = objSenateGaugeSubItemsENS.senateGaugeSubItemScore; //量表指标子项分数
objSenateGaugeSubItemsENT.senateGaugeSubItemDesc = objSenateGaugeSubItemsENS.senateGaugeSubItemDesc; //量表指标子项说明
objSenateGaugeSubItemsENT.AnswerTitle = objSenateGaugeSubItemsENS.AnswerTitle; //答案标题
objSenateGaugeSubItemsENT.AnswerIndex = objSenateGaugeSubItemsENS.AnswerIndex; //问答序号
objSenateGaugeSubItemsENT.UpdDate = objSenateGaugeSubItemsENS.UpdDate; //修改日期
objSenateGaugeSubItemsENT.UpdUserId = objSenateGaugeSubItemsENS.UpdUserId; //修改用户Id
objSenateGaugeSubItemsENT.senateGaugeSubItemMemo = objSenateGaugeSubItemsENS.senateGaugeSubItemMemo; //量表指标子项备注
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
public static DataTable ToDataTable(List<clsSenateGaugeSubItemsEN> arrObj)
{
DataTable dataTable = new DataTable(); //实例化
DataTable result;
if (arrObj.Count == 0) return null;
if (clsSenateGaugeSubItemsEN.AttributeName.Length == 0)
{
result = dataTable;
return result;
}
Type type = typeof(clsSenateGaugeSubItemsEN);
PropertyInfo[] arrPropertyInfo = type.GetProperties();
try
{
//Columns
foreach (string strAttrName in clsSenateGaugeSubItemsEN.AttributeName)
{
PropertyInfo proprety_Curr = arrPropertyInfo.Where(x => x.Name == strAttrName).First();
dataTable.Columns.Add(strAttrName, proprety_Curr.PropertyType);
}
foreach (clsSenateGaugeSubItemsEN objInFor in arrObj)
{
//Rows
DataRow dataRow = dataTable.NewRow();
foreach (string strAttrName in clsSenateGaugeSubItemsEN.AttributeName)
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
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by id_SenateGaugeSubItem");
//if (arrSenateGaugeSubItemsObjLst_Cache == null)
//{
//arrSenateGaugeSubItemsObjLst_Cache = await clsSenateGaugeSubItemsWApi.GetObjLst(strWhereCond);
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
string strKey = string.Format("{0}", clsSenateGaugeSubItemsEN._CurrTabName_S);
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
if (clsSenateGaugeSubItemsWApi.objCommFun4BL != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}", clsSenateGaugeSubItemsEN._CurrTabName_S);
CacheHelper.Remove(strKey);
clsSenateGaugeSubItemsWApi.objCommFun4BL.ReFreshCache();
}
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst_Cache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsSenateGaugeSubItemsEN> GetObjLst_Cache()
{
//初始化列表缓存
InitListCache(); 
string strKey = string.Format("{0}", clsSenateGaugeSubItemsEN._CurrTabName_S);
List<clsSenateGaugeSubItemsEN> arrSenateGaugeSubItemsObjLst_Cache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrSenateGaugeSubItemsObjLst_Cache;
}

 /// <summary>
 /// 根据对象列表获取DataTable
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetDataTableByObjLst)
 /// </summary>
 /// <param name = "arrObjLst">给定的对象列表</param>
 /// <returns>返回DataTable</returns>
public static DataTable GetDataTableByObjLst(List<clsSenateGaugeSubItemsEN> arrObjLst)
{
DataTable objDT = new DataTable();
objDT.Columns.Add(conSenateGaugeSubItems.id_SenateGaugeSubItem, Type.GetType("System.String"));
objDT.Columns.Add(conSenateGaugeSubItems.id_SenateGaugeItem, Type.GetType("System.String"));
objDT.Columns.Add(conSenateGaugeSubItems.senateGaugeSubItemID, Type.GetType("System.String"));
objDT.Columns.Add(conSenateGaugeSubItems.senateGaugeSubItemName, Type.GetType("System.String"));
objDT.Columns.Add(conSenateGaugeSubItems.senateGaugeSubItemScore, Type.GetType("System.Single"));
objDT.Columns.Add(conSenateGaugeSubItems.senateGaugeSubItemDesc, Type.GetType("System.String"));
objDT.Columns.Add(conSenateGaugeSubItems.AnswerTitle, Type.GetType("System.String"));
objDT.Columns.Add(conSenateGaugeSubItems.AnswerIndex, Type.GetType("System.Int32"));
objDT.Columns.Add(conSenateGaugeSubItems.UpdDate, Type.GetType("System.String"));
objDT.Columns.Add(conSenateGaugeSubItems.UpdUserId, Type.GetType("System.String"));
objDT.Columns.Add(conSenateGaugeSubItems.senateGaugeSubItemMemo, Type.GetType("System.String"));
foreach (clsSenateGaugeSubItemsEN objInFor in arrObjLst)
{
DataRow objDR = objDT.NewRow();
objDR[conSenateGaugeSubItems.id_SenateGaugeSubItem] = objInFor[conSenateGaugeSubItems.id_SenateGaugeSubItem];
objDR[conSenateGaugeSubItems.id_SenateGaugeItem] = objInFor[conSenateGaugeSubItems.id_SenateGaugeItem];
objDR[conSenateGaugeSubItems.senateGaugeSubItemID] = objInFor[conSenateGaugeSubItems.senateGaugeSubItemID];
objDR[conSenateGaugeSubItems.senateGaugeSubItemName] = objInFor[conSenateGaugeSubItems.senateGaugeSubItemName];
objDR[conSenateGaugeSubItems.senateGaugeSubItemScore] = objInFor[conSenateGaugeSubItems.senateGaugeSubItemScore];
objDR[conSenateGaugeSubItems.senateGaugeSubItemDesc] = objInFor[conSenateGaugeSubItems.senateGaugeSubItemDesc];
objDR[conSenateGaugeSubItems.AnswerTitle] = objInFor[conSenateGaugeSubItems.AnswerTitle];
objDR[conSenateGaugeSubItems.AnswerIndex] = objInFor[conSenateGaugeSubItems.AnswerIndex];
objDR[conSenateGaugeSubItems.UpdDate] = objInFor[conSenateGaugeSubItems.UpdDate];
objDR[conSenateGaugeSubItems.UpdUserId] = objInFor[conSenateGaugeSubItems.UpdUserId];
objDR[conSenateGaugeSubItems.senateGaugeSubItemMemo] = objInFor[conSenateGaugeSubItems.senateGaugeSubItemMemo];
objDT.Rows.Add(objDR);
}
return objDT;
}
}
 /// <summary>
 /// 量表指标子项(SenateGaugeSubItems)
 /// 数据源类型:SQL表
 /// (AutoGCLib.CommFun4WA4CSharp:GeneCode_This)
 /// </summary>
public class clsCommFun4WA4SenateGaugeSubItems : clsCommFun4BL
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
clsSenateGaugeSubItemsWApi.ReFreshThisCache();
}
}

}