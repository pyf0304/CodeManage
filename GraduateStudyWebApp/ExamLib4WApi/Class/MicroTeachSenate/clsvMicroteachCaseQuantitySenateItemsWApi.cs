
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvMicroteachCaseQuantitySenateItemsWApi
 表名:vMicroteachCaseQuantitySenateItems(01120493)
 生成代码版本:2021.09.20.1
 生成日期:2021/09/21 02:48:23
 生成者:pyf
 生成服务器IP:103.116.76.183
 工程名称:问卷调查
 工程ID:0112
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:微格教学评议
 模块英文名:MicroTeachSenate
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
public static class clsvMicroteachCaseQuantitySenateItemsWApi_Static
{

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCaseQuantitySenateItemsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroteachCaseQuantitySenateItemsEN Setid_microteachCaseQuantitySenateItem(this clsvMicroteachCaseQuantitySenateItemsEN objvMicroteachCaseQuantitySenateItemsEN, long lngid_microteachCaseQuantitySenateItem, string strComparisonOp="")
	{
objvMicroteachCaseQuantitySenateItemsEN.id_microteachCaseQuantitySenateItem = lngid_microteachCaseQuantitySenateItem; //微格量化评价指标流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCaseQuantitySenateItemsEN.dicFldComparisonOp.ContainsKey(convMicroteachCaseQuantitySenateItems.id_microteachCaseQuantitySenateItem) == false)
{
objvMicroteachCaseQuantitySenateItemsEN.dicFldComparisonOp.Add(convMicroteachCaseQuantitySenateItems.id_microteachCaseQuantitySenateItem, strComparisonOp);
}
else
{
objvMicroteachCaseQuantitySenateItemsEN.dicFldComparisonOp[convMicroteachCaseQuantitySenateItems.id_microteachCaseQuantitySenateItem] = strComparisonOp;
}
}
return objvMicroteachCaseQuantitySenateItemsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCaseQuantitySenateItemsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroteachCaseQuantitySenateItemsEN Setid_microteachCaseQuantitySenate(this clsvMicroteachCaseQuantitySenateItemsEN objvMicroteachCaseQuantitySenateItemsEN, long lngid_microteachCaseQuantitySenate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(lngid_microteachCaseQuantitySenate, convMicroteachCaseQuantitySenateItems.id_microteachCaseQuantitySenate);
objvMicroteachCaseQuantitySenateItemsEN.id_microteachCaseQuantitySenate = lngid_microteachCaseQuantitySenate; //微格量化评价流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCaseQuantitySenateItemsEN.dicFldComparisonOp.ContainsKey(convMicroteachCaseQuantitySenateItems.id_microteachCaseQuantitySenate) == false)
{
objvMicroteachCaseQuantitySenateItemsEN.dicFldComparisonOp.Add(convMicroteachCaseQuantitySenateItems.id_microteachCaseQuantitySenate, strComparisonOp);
}
else
{
objvMicroteachCaseQuantitySenateItemsEN.dicFldComparisonOp[convMicroteachCaseQuantitySenateItems.id_microteachCaseQuantitySenate] = strComparisonOp;
}
}
return objvMicroteachCaseQuantitySenateItemsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCaseQuantitySenateItemsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroteachCaseQuantitySenateItemsEN Setid_MicroteachCase(this clsvMicroteachCaseQuantitySenateItemsEN objvMicroteachCaseQuantitySenateItemsEN, string strid_MicroteachCase, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strid_MicroteachCase, convMicroteachCaseQuantitySenateItems.id_MicroteachCase);
clsCheckSql.CheckFieldLen(strid_MicroteachCase, 8, convMicroteachCaseQuantitySenateItems.id_MicroteachCase);
clsCheckSql.CheckFieldForeignKey(strid_MicroteachCase, 8, convMicroteachCaseQuantitySenateItems.id_MicroteachCase);
objvMicroteachCaseQuantitySenateItemsEN.id_MicroteachCase = strid_MicroteachCase; //微格教学案例流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCaseQuantitySenateItemsEN.dicFldComparisonOp.ContainsKey(convMicroteachCaseQuantitySenateItems.id_MicroteachCase) == false)
{
objvMicroteachCaseQuantitySenateItemsEN.dicFldComparisonOp.Add(convMicroteachCaseQuantitySenateItems.id_MicroteachCase, strComparisonOp);
}
else
{
objvMicroteachCaseQuantitySenateItemsEN.dicFldComparisonOp[convMicroteachCaseQuantitySenateItems.id_MicroteachCase] = strComparisonOp;
}
}
return objvMicroteachCaseQuantitySenateItemsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCaseQuantitySenateItemsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroteachCaseQuantitySenateItemsEN SetMicroteachCaseID(this clsvMicroteachCaseQuantitySenateItemsEN objvMicroteachCaseQuantitySenateItemsEN, string strMicroteachCaseID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMicroteachCaseID, 8, convMicroteachCaseQuantitySenateItems.MicroteachCaseID);
clsCheckSql.CheckFieldForeignKey(strMicroteachCaseID, 8, convMicroteachCaseQuantitySenateItems.MicroteachCaseID);
objvMicroteachCaseQuantitySenateItemsEN.MicroteachCaseID = strMicroteachCaseID; //微格教学案例ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCaseQuantitySenateItemsEN.dicFldComparisonOp.ContainsKey(convMicroteachCaseQuantitySenateItems.MicroteachCaseID) == false)
{
objvMicroteachCaseQuantitySenateItemsEN.dicFldComparisonOp.Add(convMicroteachCaseQuantitySenateItems.MicroteachCaseID, strComparisonOp);
}
else
{
objvMicroteachCaseQuantitySenateItemsEN.dicFldComparisonOp[convMicroteachCaseQuantitySenateItems.MicroteachCaseID] = strComparisonOp;
}
}
return objvMicroteachCaseQuantitySenateItemsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCaseQuantitySenateItemsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroteachCaseQuantitySenateItemsEN SetMicroteachCaseName(this clsvMicroteachCaseQuantitySenateItemsEN objvMicroteachCaseQuantitySenateItemsEN, string strMicroteachCaseName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMicroteachCaseName, 100, convMicroteachCaseQuantitySenateItems.MicroteachCaseName);
objvMicroteachCaseQuantitySenateItemsEN.MicroteachCaseName = strMicroteachCaseName; //微格教学案例名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCaseQuantitySenateItemsEN.dicFldComparisonOp.ContainsKey(convMicroteachCaseQuantitySenateItems.MicroteachCaseName) == false)
{
objvMicroteachCaseQuantitySenateItemsEN.dicFldComparisonOp.Add(convMicroteachCaseQuantitySenateItems.MicroteachCaseName, strComparisonOp);
}
else
{
objvMicroteachCaseQuantitySenateItemsEN.dicFldComparisonOp[convMicroteachCaseQuantitySenateItems.MicroteachCaseName] = strComparisonOp;
}
}
return objvMicroteachCaseQuantitySenateItemsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCaseQuantitySenateItemsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroteachCaseQuantitySenateItemsEN Setid_SenateGaugeItem(this clsvMicroteachCaseQuantitySenateItemsEN objvMicroteachCaseQuantitySenateItemsEN, string strid_SenateGaugeItem, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strid_SenateGaugeItem, convMicroteachCaseQuantitySenateItems.id_SenateGaugeItem);
clsCheckSql.CheckFieldLen(strid_SenateGaugeItem, 4, convMicroteachCaseQuantitySenateItems.id_SenateGaugeItem);
clsCheckSql.CheckFieldForeignKey(strid_SenateGaugeItem, 4, convMicroteachCaseQuantitySenateItems.id_SenateGaugeItem);
objvMicroteachCaseQuantitySenateItemsEN.id_SenateGaugeItem = strid_SenateGaugeItem; //量表指标流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCaseQuantitySenateItemsEN.dicFldComparisonOp.ContainsKey(convMicroteachCaseQuantitySenateItems.id_SenateGaugeItem) == false)
{
objvMicroteachCaseQuantitySenateItemsEN.dicFldComparisonOp.Add(convMicroteachCaseQuantitySenateItems.id_SenateGaugeItem, strComparisonOp);
}
else
{
objvMicroteachCaseQuantitySenateItemsEN.dicFldComparisonOp[convMicroteachCaseQuantitySenateItems.id_SenateGaugeItem] = strComparisonOp;
}
}
return objvMicroteachCaseQuantitySenateItemsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCaseQuantitySenateItemsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroteachCaseQuantitySenateItemsEN SetsenateGaugeItemID(this clsvMicroteachCaseQuantitySenateItemsEN objvMicroteachCaseQuantitySenateItemsEN, string strsenateGaugeItemID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strsenateGaugeItemID, 4, convMicroteachCaseQuantitySenateItems.senateGaugeItemID);
clsCheckSql.CheckFieldForeignKey(strsenateGaugeItemID, 4, convMicroteachCaseQuantitySenateItems.senateGaugeItemID);
objvMicroteachCaseQuantitySenateItemsEN.senateGaugeItemID = strsenateGaugeItemID; //量表指标ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCaseQuantitySenateItemsEN.dicFldComparisonOp.ContainsKey(convMicroteachCaseQuantitySenateItems.senateGaugeItemID) == false)
{
objvMicroteachCaseQuantitySenateItemsEN.dicFldComparisonOp.Add(convMicroteachCaseQuantitySenateItems.senateGaugeItemID, strComparisonOp);
}
else
{
objvMicroteachCaseQuantitySenateItemsEN.dicFldComparisonOp[convMicroteachCaseQuantitySenateItems.senateGaugeItemID] = strComparisonOp;
}
}
return objvMicroteachCaseQuantitySenateItemsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCaseQuantitySenateItemsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroteachCaseQuantitySenateItemsEN SetsenateGaugeItemName(this clsvMicroteachCaseQuantitySenateItemsEN objvMicroteachCaseQuantitySenateItemsEN, string strsenateGaugeItemName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strsenateGaugeItemName, 200, convMicroteachCaseQuantitySenateItems.senateGaugeItemName);
objvMicroteachCaseQuantitySenateItemsEN.senateGaugeItemName = strsenateGaugeItemName; //量表指标名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCaseQuantitySenateItemsEN.dicFldComparisonOp.ContainsKey(convMicroteachCaseQuantitySenateItems.senateGaugeItemName) == false)
{
objvMicroteachCaseQuantitySenateItemsEN.dicFldComparisonOp.Add(convMicroteachCaseQuantitySenateItems.senateGaugeItemName, strComparisonOp);
}
else
{
objvMicroteachCaseQuantitySenateItemsEN.dicFldComparisonOp[convMicroteachCaseQuantitySenateItems.senateGaugeItemName] = strComparisonOp;
}
}
return objvMicroteachCaseQuantitySenateItemsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCaseQuantitySenateItemsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroteachCaseQuantitySenateItemsEN SetsenateGaugeItemNameWithOrder(this clsvMicroteachCaseQuantitySenateItemsEN objvMicroteachCaseQuantitySenateItemsEN, string strsenateGaugeItemNameWithOrder, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strsenateGaugeItemNameWithOrder, 204, convMicroteachCaseQuantitySenateItems.senateGaugeItemNameWithOrder);
objvMicroteachCaseQuantitySenateItemsEN.senateGaugeItemNameWithOrder = strsenateGaugeItemNameWithOrder; //量表指标名称WithOrder
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCaseQuantitySenateItemsEN.dicFldComparisonOp.ContainsKey(convMicroteachCaseQuantitySenateItems.senateGaugeItemNameWithOrder) == false)
{
objvMicroteachCaseQuantitySenateItemsEN.dicFldComparisonOp.Add(convMicroteachCaseQuantitySenateItems.senateGaugeItemNameWithOrder, strComparisonOp);
}
else
{
objvMicroteachCaseQuantitySenateItemsEN.dicFldComparisonOp[convMicroteachCaseQuantitySenateItems.senateGaugeItemNameWithOrder] = strComparisonOp;
}
}
return objvMicroteachCaseQuantitySenateItemsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCaseQuantitySenateItemsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroteachCaseQuantitySenateItemsEN SetsenateGaugeItemDesc(this clsvMicroteachCaseQuantitySenateItemsEN objvMicroteachCaseQuantitySenateItemsEN, string strsenateGaugeItemDesc, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strsenateGaugeItemDesc, 2000, convMicroteachCaseQuantitySenateItems.senateGaugeItemDesc);
objvMicroteachCaseQuantitySenateItemsEN.senateGaugeItemDesc = strsenateGaugeItemDesc; //量表指标说明
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCaseQuantitySenateItemsEN.dicFldComparisonOp.ContainsKey(convMicroteachCaseQuantitySenateItems.senateGaugeItemDesc) == false)
{
objvMicroteachCaseQuantitySenateItemsEN.dicFldComparisonOp.Add(convMicroteachCaseQuantitySenateItems.senateGaugeItemDesc, strComparisonOp);
}
else
{
objvMicroteachCaseQuantitySenateItemsEN.dicFldComparisonOp[convMicroteachCaseQuantitySenateItems.senateGaugeItemDesc] = strComparisonOp;
}
}
return objvMicroteachCaseQuantitySenateItemsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCaseQuantitySenateItemsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroteachCaseQuantitySenateItemsEN SetsenateGaugeItemMemo(this clsvMicroteachCaseQuantitySenateItemsEN objvMicroteachCaseQuantitySenateItemsEN, string strsenateGaugeItemMemo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strsenateGaugeItemMemo, 1000, convMicroteachCaseQuantitySenateItems.senateGaugeItemMemo);
objvMicroteachCaseQuantitySenateItemsEN.senateGaugeItemMemo = strsenateGaugeItemMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCaseQuantitySenateItemsEN.dicFldComparisonOp.ContainsKey(convMicroteachCaseQuantitySenateItems.senateGaugeItemMemo) == false)
{
objvMicroteachCaseQuantitySenateItemsEN.dicFldComparisonOp.Add(convMicroteachCaseQuantitySenateItems.senateGaugeItemMemo, strComparisonOp);
}
else
{
objvMicroteachCaseQuantitySenateItemsEN.dicFldComparisonOp[convMicroteachCaseQuantitySenateItems.senateGaugeItemMemo] = strComparisonOp;
}
}
return objvMicroteachCaseQuantitySenateItemsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCaseQuantitySenateItemsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroteachCaseQuantitySenateItemsEN SetsenateGaugeItemWeight(this clsvMicroteachCaseQuantitySenateItemsEN objvMicroteachCaseQuantitySenateItemsEN, float fltsenateGaugeItemWeight, string strComparisonOp="")
	{
objvMicroteachCaseQuantitySenateItemsEN.senateGaugeItemWeight = fltsenateGaugeItemWeight; //量表指标权重
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCaseQuantitySenateItemsEN.dicFldComparisonOp.ContainsKey(convMicroteachCaseQuantitySenateItems.senateGaugeItemWeight) == false)
{
objvMicroteachCaseQuantitySenateItemsEN.dicFldComparisonOp.Add(convMicroteachCaseQuantitySenateItems.senateGaugeItemWeight, strComparisonOp);
}
else
{
objvMicroteachCaseQuantitySenateItemsEN.dicFldComparisonOp[convMicroteachCaseQuantitySenateItems.senateGaugeItemWeight] = strComparisonOp;
}
}
return objvMicroteachCaseQuantitySenateItemsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCaseQuantitySenateItemsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroteachCaseQuantitySenateItemsEN SetSenateScore(this clsvMicroteachCaseQuantitySenateItemsEN objvMicroteachCaseQuantitySenateItemsEN, float fltSenateScore, string strComparisonOp="")
	{
objvMicroteachCaseQuantitySenateItemsEN.SenateScore = fltSenateScore; //指标得分
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCaseQuantitySenateItemsEN.dicFldComparisonOp.ContainsKey(convMicroteachCaseQuantitySenateItems.SenateScore) == false)
{
objvMicroteachCaseQuantitySenateItemsEN.dicFldComparisonOp.Add(convMicroteachCaseQuantitySenateItems.SenateScore, strComparisonOp);
}
else
{
objvMicroteachCaseQuantitySenateItemsEN.dicFldComparisonOp[convMicroteachCaseQuantitySenateItems.SenateScore] = strComparisonOp;
}
}
return objvMicroteachCaseQuantitySenateItemsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCaseQuantitySenateItemsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroteachCaseQuantitySenateItemsEN Setid_SenateGaugeSubItem(this clsvMicroteachCaseQuantitySenateItemsEN objvMicroteachCaseQuantitySenateItemsEN, string strid_SenateGaugeSubItem, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_SenateGaugeSubItem, 4, convMicroteachCaseQuantitySenateItems.id_SenateGaugeSubItem);
clsCheckSql.CheckFieldForeignKey(strid_SenateGaugeSubItem, 4, convMicroteachCaseQuantitySenateItems.id_SenateGaugeSubItem);
objvMicroteachCaseQuantitySenateItemsEN.id_SenateGaugeSubItem = strid_SenateGaugeSubItem; //量表指标子项流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCaseQuantitySenateItemsEN.dicFldComparisonOp.ContainsKey(convMicroteachCaseQuantitySenateItems.id_SenateGaugeSubItem) == false)
{
objvMicroteachCaseQuantitySenateItemsEN.dicFldComparisonOp.Add(convMicroteachCaseQuantitySenateItems.id_SenateGaugeSubItem, strComparisonOp);
}
else
{
objvMicroteachCaseQuantitySenateItemsEN.dicFldComparisonOp[convMicroteachCaseQuantitySenateItems.id_SenateGaugeSubItem] = strComparisonOp;
}
}
return objvMicroteachCaseQuantitySenateItemsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCaseQuantitySenateItemsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroteachCaseQuantitySenateItemsEN SetsenateGaugeSubItemID(this clsvMicroteachCaseQuantitySenateItemsEN objvMicroteachCaseQuantitySenateItemsEN, string strsenateGaugeSubItemID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strsenateGaugeSubItemID, 4, convMicroteachCaseQuantitySenateItems.senateGaugeSubItemID);
clsCheckSql.CheckFieldForeignKey(strsenateGaugeSubItemID, 4, convMicroteachCaseQuantitySenateItems.senateGaugeSubItemID);
objvMicroteachCaseQuantitySenateItemsEN.senateGaugeSubItemID = strsenateGaugeSubItemID; //量表指标子项ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCaseQuantitySenateItemsEN.dicFldComparisonOp.ContainsKey(convMicroteachCaseQuantitySenateItems.senateGaugeSubItemID) == false)
{
objvMicroteachCaseQuantitySenateItemsEN.dicFldComparisonOp.Add(convMicroteachCaseQuantitySenateItems.senateGaugeSubItemID, strComparisonOp);
}
else
{
objvMicroteachCaseQuantitySenateItemsEN.dicFldComparisonOp[convMicroteachCaseQuantitySenateItems.senateGaugeSubItemID] = strComparisonOp;
}
}
return objvMicroteachCaseQuantitySenateItemsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCaseQuantitySenateItemsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroteachCaseQuantitySenateItemsEN SetsenateGaugeSubItemName(this clsvMicroteachCaseQuantitySenateItemsEN objvMicroteachCaseQuantitySenateItemsEN, string strsenateGaugeSubItemName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strsenateGaugeSubItemName, 200, convMicroteachCaseQuantitySenateItems.senateGaugeSubItemName);
objvMicroteachCaseQuantitySenateItemsEN.senateGaugeSubItemName = strsenateGaugeSubItemName; //量表指标子项名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCaseQuantitySenateItemsEN.dicFldComparisonOp.ContainsKey(convMicroteachCaseQuantitySenateItems.senateGaugeSubItemName) == false)
{
objvMicroteachCaseQuantitySenateItemsEN.dicFldComparisonOp.Add(convMicroteachCaseQuantitySenateItems.senateGaugeSubItemName, strComparisonOp);
}
else
{
objvMicroteachCaseQuantitySenateItemsEN.dicFldComparisonOp[convMicroteachCaseQuantitySenateItems.senateGaugeSubItemName] = strComparisonOp;
}
}
return objvMicroteachCaseQuantitySenateItemsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCaseQuantitySenateItemsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroteachCaseQuantitySenateItemsEN SetsenateGaugeSubItemDesc(this clsvMicroteachCaseQuantitySenateItemsEN objvMicroteachCaseQuantitySenateItemsEN, string strsenateGaugeSubItemDesc, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strsenateGaugeSubItemDesc, 2000, convMicroteachCaseQuantitySenateItems.senateGaugeSubItemDesc);
objvMicroteachCaseQuantitySenateItemsEN.senateGaugeSubItemDesc = strsenateGaugeSubItemDesc; //量表指标子项说明
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCaseQuantitySenateItemsEN.dicFldComparisonOp.ContainsKey(convMicroteachCaseQuantitySenateItems.senateGaugeSubItemDesc) == false)
{
objvMicroteachCaseQuantitySenateItemsEN.dicFldComparisonOp.Add(convMicroteachCaseQuantitySenateItems.senateGaugeSubItemDesc, strComparisonOp);
}
else
{
objvMicroteachCaseQuantitySenateItemsEN.dicFldComparisonOp[convMicroteachCaseQuantitySenateItems.senateGaugeSubItemDesc] = strComparisonOp;
}
}
return objvMicroteachCaseQuantitySenateItemsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCaseQuantitySenateItemsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroteachCaseQuantitySenateItemsEN SetsenateGaugeSubItemMemo(this clsvMicroteachCaseQuantitySenateItemsEN objvMicroteachCaseQuantitySenateItemsEN, string strsenateGaugeSubItemMemo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strsenateGaugeSubItemMemo, 1000, convMicroteachCaseQuantitySenateItems.senateGaugeSubItemMemo);
objvMicroteachCaseQuantitySenateItemsEN.senateGaugeSubItemMemo = strsenateGaugeSubItemMemo; //量表指标子项备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCaseQuantitySenateItemsEN.dicFldComparisonOp.ContainsKey(convMicroteachCaseQuantitySenateItems.senateGaugeSubItemMemo) == false)
{
objvMicroteachCaseQuantitySenateItemsEN.dicFldComparisonOp.Add(convMicroteachCaseQuantitySenateItems.senateGaugeSubItemMemo, strComparisonOp);
}
else
{
objvMicroteachCaseQuantitySenateItemsEN.dicFldComparisonOp[convMicroteachCaseQuantitySenateItems.senateGaugeSubItemMemo] = strComparisonOp;
}
}
return objvMicroteachCaseQuantitySenateItemsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCaseQuantitySenateItemsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroteachCaseQuantitySenateItemsEN SetsenateGaugeSubItemScore(this clsvMicroteachCaseQuantitySenateItemsEN objvMicroteachCaseQuantitySenateItemsEN, float fltsenateGaugeSubItemScore, string strComparisonOp="")
	{
objvMicroteachCaseQuantitySenateItemsEN.senateGaugeSubItemScore = fltsenateGaugeSubItemScore; //量表指标子项分数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCaseQuantitySenateItemsEN.dicFldComparisonOp.ContainsKey(convMicroteachCaseQuantitySenateItems.senateGaugeSubItemScore) == false)
{
objvMicroteachCaseQuantitySenateItemsEN.dicFldComparisonOp.Add(convMicroteachCaseQuantitySenateItems.senateGaugeSubItemScore, strComparisonOp);
}
else
{
objvMicroteachCaseQuantitySenateItemsEN.dicFldComparisonOp[convMicroteachCaseQuantitySenateItems.senateGaugeSubItemScore] = strComparisonOp;
}
}
return objvMicroteachCaseQuantitySenateItemsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCaseQuantitySenateItemsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroteachCaseQuantitySenateItemsEN SetUserId(this clsvMicroteachCaseQuantitySenateItemsEN objvMicroteachCaseQuantitySenateItemsEN, string strUserId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUserId, 20, convMicroteachCaseQuantitySenateItems.UserId);
objvMicroteachCaseQuantitySenateItemsEN.UserId = strUserId; //用户ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCaseQuantitySenateItemsEN.dicFldComparisonOp.ContainsKey(convMicroteachCaseQuantitySenateItems.UserId) == false)
{
objvMicroteachCaseQuantitySenateItemsEN.dicFldComparisonOp.Add(convMicroteachCaseQuantitySenateItems.UserId, strComparisonOp);
}
else
{
objvMicroteachCaseQuantitySenateItemsEN.dicFldComparisonOp[convMicroteachCaseQuantitySenateItems.UserId] = strComparisonOp;
}
}
return objvMicroteachCaseQuantitySenateItemsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCaseQuantitySenateItemsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroteachCaseQuantitySenateItemsEN SetUserName(this clsvMicroteachCaseQuantitySenateItemsEN objvMicroteachCaseQuantitySenateItemsEN, string strUserName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUserName, 50, convMicroteachCaseQuantitySenateItems.UserName);
objvMicroteachCaseQuantitySenateItemsEN.UserName = strUserName; //用户名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCaseQuantitySenateItemsEN.dicFldComparisonOp.ContainsKey(convMicroteachCaseQuantitySenateItems.UserName) == false)
{
objvMicroteachCaseQuantitySenateItemsEN.dicFldComparisonOp.Add(convMicroteachCaseQuantitySenateItems.UserName, strComparisonOp);
}
else
{
objvMicroteachCaseQuantitySenateItemsEN.dicFldComparisonOp[convMicroteachCaseQuantitySenateItems.UserName] = strComparisonOp;
}
}
return objvMicroteachCaseQuantitySenateItemsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCaseQuantitySenateItemsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroteachCaseQuantitySenateItemsEN SetCollegeID(this clsvMicroteachCaseQuantitySenateItemsEN objvMicroteachCaseQuantitySenateItemsEN, string strCollegeID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCollegeID, 4, convMicroteachCaseQuantitySenateItems.CollegeID);
objvMicroteachCaseQuantitySenateItemsEN.CollegeID = strCollegeID; //学院ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCaseQuantitySenateItemsEN.dicFldComparisonOp.ContainsKey(convMicroteachCaseQuantitySenateItems.CollegeID) == false)
{
objvMicroteachCaseQuantitySenateItemsEN.dicFldComparisonOp.Add(convMicroteachCaseQuantitySenateItems.CollegeID, strComparisonOp);
}
else
{
objvMicroteachCaseQuantitySenateItemsEN.dicFldComparisonOp[convMicroteachCaseQuantitySenateItems.CollegeID] = strComparisonOp;
}
}
return objvMicroteachCaseQuantitySenateItemsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCaseQuantitySenateItemsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroteachCaseQuantitySenateItemsEN SetCollegeName(this clsvMicroteachCaseQuantitySenateItemsEN objvMicroteachCaseQuantitySenateItemsEN, string strCollegeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCollegeName, 100, convMicroteachCaseQuantitySenateItems.CollegeName);
objvMicroteachCaseQuantitySenateItemsEN.CollegeName = strCollegeName; //学院名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCaseQuantitySenateItemsEN.dicFldComparisonOp.ContainsKey(convMicroteachCaseQuantitySenateItems.CollegeName) == false)
{
objvMicroteachCaseQuantitySenateItemsEN.dicFldComparisonOp.Add(convMicroteachCaseQuantitySenateItems.CollegeName, strComparisonOp);
}
else
{
objvMicroteachCaseQuantitySenateItemsEN.dicFldComparisonOp[convMicroteachCaseQuantitySenateItems.CollegeName] = strComparisonOp;
}
}
return objvMicroteachCaseQuantitySenateItemsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCaseQuantitySenateItemsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroteachCaseQuantitySenateItemsEN SetSenateTheme(this clsvMicroteachCaseQuantitySenateItemsEN objvMicroteachCaseQuantitySenateItemsEN, string strSenateTheme, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strSenateTheme, 200, convMicroteachCaseQuantitySenateItems.SenateTheme);
objvMicroteachCaseQuantitySenateItemsEN.SenateTheme = strSenateTheme; //量化评价主题
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCaseQuantitySenateItemsEN.dicFldComparisonOp.ContainsKey(convMicroteachCaseQuantitySenateItems.SenateTheme) == false)
{
objvMicroteachCaseQuantitySenateItemsEN.dicFldComparisonOp.Add(convMicroteachCaseQuantitySenateItems.SenateTheme, strComparisonOp);
}
else
{
objvMicroteachCaseQuantitySenateItemsEN.dicFldComparisonOp[convMicroteachCaseQuantitySenateItems.SenateTheme] = strComparisonOp;
}
}
return objvMicroteachCaseQuantitySenateItemsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCaseQuantitySenateItemsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroteachCaseQuantitySenateItemsEN SetSenateContent(this clsvMicroteachCaseQuantitySenateItemsEN objvMicroteachCaseQuantitySenateItemsEN, string strSenateContent, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strSenateContent, 2000, convMicroteachCaseQuantitySenateItems.SenateContent);
objvMicroteachCaseQuantitySenateItemsEN.SenateContent = strSenateContent; //评价内容
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCaseQuantitySenateItemsEN.dicFldComparisonOp.ContainsKey(convMicroteachCaseQuantitySenateItems.SenateContent) == false)
{
objvMicroteachCaseQuantitySenateItemsEN.dicFldComparisonOp.Add(convMicroteachCaseQuantitySenateItems.SenateContent, strComparisonOp);
}
else
{
objvMicroteachCaseQuantitySenateItemsEN.dicFldComparisonOp[convMicroteachCaseQuantitySenateItems.SenateContent] = strComparisonOp;
}
}
return objvMicroteachCaseQuantitySenateItemsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCaseQuantitySenateItemsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroteachCaseQuantitySenateItemsEN SetSenateDate(this clsvMicroteachCaseQuantitySenateItemsEN objvMicroteachCaseQuantitySenateItemsEN, string strSenateDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strSenateDate, 8, convMicroteachCaseQuantitySenateItems.SenateDate);
clsCheckSql.CheckFieldForeignKey(strSenateDate, 8, convMicroteachCaseQuantitySenateItems.SenateDate);
objvMicroteachCaseQuantitySenateItemsEN.SenateDate = strSenateDate; //评价日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCaseQuantitySenateItemsEN.dicFldComparisonOp.ContainsKey(convMicroteachCaseQuantitySenateItems.SenateDate) == false)
{
objvMicroteachCaseQuantitySenateItemsEN.dicFldComparisonOp.Add(convMicroteachCaseQuantitySenateItems.SenateDate, strComparisonOp);
}
else
{
objvMicroteachCaseQuantitySenateItemsEN.dicFldComparisonOp[convMicroteachCaseQuantitySenateItems.SenateDate] = strComparisonOp;
}
}
return objvMicroteachCaseQuantitySenateItemsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCaseQuantitySenateItemsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroteachCaseQuantitySenateItemsEN SetSenateTime(this clsvMicroteachCaseQuantitySenateItemsEN objvMicroteachCaseQuantitySenateItemsEN, string strSenateTime, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strSenateTime, 6, convMicroteachCaseQuantitySenateItems.SenateTime);
clsCheckSql.CheckFieldForeignKey(strSenateTime, 6, convMicroteachCaseQuantitySenateItems.SenateTime);
objvMicroteachCaseQuantitySenateItemsEN.SenateTime = strSenateTime; //评价时间
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCaseQuantitySenateItemsEN.dicFldComparisonOp.ContainsKey(convMicroteachCaseQuantitySenateItems.SenateTime) == false)
{
objvMicroteachCaseQuantitySenateItemsEN.dicFldComparisonOp.Add(convMicroteachCaseQuantitySenateItems.SenateTime, strComparisonOp);
}
else
{
objvMicroteachCaseQuantitySenateItemsEN.dicFldComparisonOp[convMicroteachCaseQuantitySenateItems.SenateTime] = strComparisonOp;
}
}
return objvMicroteachCaseQuantitySenateItemsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCaseQuantitySenateItemsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroteachCaseQuantitySenateItemsEN SetSenateTotalScore(this clsvMicroteachCaseQuantitySenateItemsEN objvMicroteachCaseQuantitySenateItemsEN, float fltSenateTotalScore, string strComparisonOp="")
	{
objvMicroteachCaseQuantitySenateItemsEN.SenateTotalScore = fltSenateTotalScore; //评价分数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCaseQuantitySenateItemsEN.dicFldComparisonOp.ContainsKey(convMicroteachCaseQuantitySenateItems.SenateTotalScore) == false)
{
objvMicroteachCaseQuantitySenateItemsEN.dicFldComparisonOp.Add(convMicroteachCaseQuantitySenateItems.SenateTotalScore, strComparisonOp);
}
else
{
objvMicroteachCaseQuantitySenateItemsEN.dicFldComparisonOp[convMicroteachCaseQuantitySenateItems.SenateTotalScore] = strComparisonOp;
}
}
return objvMicroteachCaseQuantitySenateItemsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCaseQuantitySenateItemsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroteachCaseQuantitySenateItemsEN SetAnswerModeId(this clsvMicroteachCaseQuantitySenateItemsEN objvMicroteachCaseQuantitySenateItemsEN, string strAnswerModeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strAnswerModeId, 4, convMicroteachCaseQuantitySenateItems.AnswerModeId);
clsCheckSql.CheckFieldForeignKey(strAnswerModeId, 4, convMicroteachCaseQuantitySenateItems.AnswerModeId);
objvMicroteachCaseQuantitySenateItemsEN.AnswerModeId = strAnswerModeId; //答案模式Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCaseQuantitySenateItemsEN.dicFldComparisonOp.ContainsKey(convMicroteachCaseQuantitySenateItems.AnswerModeId) == false)
{
objvMicroteachCaseQuantitySenateItemsEN.dicFldComparisonOp.Add(convMicroteachCaseQuantitySenateItems.AnswerModeId, strComparisonOp);
}
else
{
objvMicroteachCaseQuantitySenateItemsEN.dicFldComparisonOp[convMicroteachCaseQuantitySenateItems.AnswerModeId] = strComparisonOp;
}
}
return objvMicroteachCaseQuantitySenateItemsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCaseQuantitySenateItemsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroteachCaseQuantitySenateItemsEN SetAnswerTypeId(this clsvMicroteachCaseQuantitySenateItemsEN objvMicroteachCaseQuantitySenateItemsEN, string strAnswerTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strAnswerTypeId, 2, convMicroteachCaseQuantitySenateItems.AnswerTypeId);
clsCheckSql.CheckFieldForeignKey(strAnswerTypeId, 2, convMicroteachCaseQuantitySenateItems.AnswerTypeId);
objvMicroteachCaseQuantitySenateItemsEN.AnswerTypeId = strAnswerTypeId; //答案类型ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCaseQuantitySenateItemsEN.dicFldComparisonOp.ContainsKey(convMicroteachCaseQuantitySenateItems.AnswerTypeId) == false)
{
objvMicroteachCaseQuantitySenateItemsEN.dicFldComparisonOp.Add(convMicroteachCaseQuantitySenateItems.AnswerTypeId, strComparisonOp);
}
else
{
objvMicroteachCaseQuantitySenateItemsEN.dicFldComparisonOp[convMicroteachCaseQuantitySenateItems.AnswerTypeId] = strComparisonOp;
}
}
return objvMicroteachCaseQuantitySenateItemsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCaseQuantitySenateItemsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroteachCaseQuantitySenateItemsEN SetGridTitle(this clsvMicroteachCaseQuantitySenateItemsEN objvMicroteachCaseQuantitySenateItemsEN, string strGridTitle, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strGridTitle, 30, convMicroteachCaseQuantitySenateItems.GridTitle);
objvMicroteachCaseQuantitySenateItemsEN.GridTitle = strGridTitle; //表格标题
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCaseQuantitySenateItemsEN.dicFldComparisonOp.ContainsKey(convMicroteachCaseQuantitySenateItems.GridTitle) == false)
{
objvMicroteachCaseQuantitySenateItemsEN.dicFldComparisonOp.Add(convMicroteachCaseQuantitySenateItems.GridTitle, strComparisonOp);
}
else
{
objvMicroteachCaseQuantitySenateItemsEN.dicFldComparisonOp[convMicroteachCaseQuantitySenateItems.GridTitle] = strComparisonOp;
}
}
return objvMicroteachCaseQuantitySenateItemsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCaseQuantitySenateItemsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroteachCaseQuantitySenateItemsEN SetQuestionIndex(this clsvMicroteachCaseQuantitySenateItemsEN objvMicroteachCaseQuantitySenateItemsEN, int intQuestionIndex, string strComparisonOp="")
	{
objvMicroteachCaseQuantitySenateItemsEN.QuestionIndex = intQuestionIndex; //题目序号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCaseQuantitySenateItemsEN.dicFldComparisonOp.ContainsKey(convMicroteachCaseQuantitySenateItems.QuestionIndex) == false)
{
objvMicroteachCaseQuantitySenateItemsEN.dicFldComparisonOp.Add(convMicroteachCaseQuantitySenateItems.QuestionIndex, strComparisonOp);
}
else
{
objvMicroteachCaseQuantitySenateItemsEN.dicFldComparisonOp[convMicroteachCaseQuantitySenateItems.QuestionIndex] = strComparisonOp;
}
}
return objvMicroteachCaseQuantitySenateItemsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCaseQuantitySenateItemsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroteachCaseQuantitySenateItemsEN SetQuestionNo(this clsvMicroteachCaseQuantitySenateItemsEN objvMicroteachCaseQuantitySenateItemsEN, string strQuestionNo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strQuestionNo, 10, convMicroteachCaseQuantitySenateItems.QuestionNo);
objvMicroteachCaseQuantitySenateItemsEN.QuestionNo = strQuestionNo; //题目编号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCaseQuantitySenateItemsEN.dicFldComparisonOp.ContainsKey(convMicroteachCaseQuantitySenateItems.QuestionNo) == false)
{
objvMicroteachCaseQuantitySenateItemsEN.dicFldComparisonOp.Add(convMicroteachCaseQuantitySenateItems.QuestionNo, strComparisonOp);
}
else
{
objvMicroteachCaseQuantitySenateItemsEN.dicFldComparisonOp[convMicroteachCaseQuantitySenateItems.QuestionNo] = strComparisonOp;
}
}
return objvMicroteachCaseQuantitySenateItemsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCaseQuantitySenateItemsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroteachCaseQuantitySenateItemsEN SetQuestionTypeId(this clsvMicroteachCaseQuantitySenateItemsEN objvMicroteachCaseQuantitySenateItemsEN, string strQuestionTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strQuestionTypeId, 2, convMicroteachCaseQuantitySenateItems.QuestionTypeId);
clsCheckSql.CheckFieldForeignKey(strQuestionTypeId, 2, convMicroteachCaseQuantitySenateItems.QuestionTypeId);
objvMicroteachCaseQuantitySenateItemsEN.QuestionTypeId = strQuestionTypeId; //题目类型Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCaseQuantitySenateItemsEN.dicFldComparisonOp.ContainsKey(convMicroteachCaseQuantitySenateItems.QuestionTypeId) == false)
{
objvMicroteachCaseQuantitySenateItemsEN.dicFldComparisonOp.Add(convMicroteachCaseQuantitySenateItems.QuestionTypeId, strComparisonOp);
}
else
{
objvMicroteachCaseQuantitySenateItemsEN.dicFldComparisonOp[convMicroteachCaseQuantitySenateItems.QuestionTypeId] = strComparisonOp;
}
}
return objvMicroteachCaseQuantitySenateItemsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCaseQuantitySenateItemsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroteachCaseQuantitySenateItemsEN SetAnswerModeName(this clsvMicroteachCaseQuantitySenateItemsEN objvMicroteachCaseQuantitySenateItemsEN, string strAnswerModeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strAnswerModeName, 30, convMicroteachCaseQuantitySenateItems.AnswerModeName);
objvMicroteachCaseQuantitySenateItemsEN.AnswerModeName = strAnswerModeName; //答案模式名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCaseQuantitySenateItemsEN.dicFldComparisonOp.ContainsKey(convMicroteachCaseQuantitySenateItems.AnswerModeName) == false)
{
objvMicroteachCaseQuantitySenateItemsEN.dicFldComparisonOp.Add(convMicroteachCaseQuantitySenateItems.AnswerModeName, strComparisonOp);
}
else
{
objvMicroteachCaseQuantitySenateItemsEN.dicFldComparisonOp[convMicroteachCaseQuantitySenateItems.AnswerModeName] = strComparisonOp;
}
}
return objvMicroteachCaseQuantitySenateItemsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCaseQuantitySenateItemsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroteachCaseQuantitySenateItemsEN SetAnswerNum(this clsvMicroteachCaseQuantitySenateItemsEN objvMicroteachCaseQuantitySenateItemsEN, int intAnswerNum, string strComparisonOp="")
	{
objvMicroteachCaseQuantitySenateItemsEN.AnswerNum = intAnswerNum; //答案数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCaseQuantitySenateItemsEN.dicFldComparisonOp.ContainsKey(convMicroteachCaseQuantitySenateItems.AnswerNum) == false)
{
objvMicroteachCaseQuantitySenateItemsEN.dicFldComparisonOp.Add(convMicroteachCaseQuantitySenateItems.AnswerNum, strComparisonOp);
}
else
{
objvMicroteachCaseQuantitySenateItemsEN.dicFldComparisonOp[convMicroteachCaseQuantitySenateItems.AnswerNum] = strComparisonOp;
}
}
return objvMicroteachCaseQuantitySenateItemsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCaseQuantitySenateItemsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroteachCaseQuantitySenateItemsEN SetAnswerTypeName(this clsvMicroteachCaseQuantitySenateItemsEN objvMicroteachCaseQuantitySenateItemsEN, string strAnswerTypeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strAnswerTypeName, 50, convMicroteachCaseQuantitySenateItems.AnswerTypeName);
objvMicroteachCaseQuantitySenateItemsEN.AnswerTypeName = strAnswerTypeName; //答案类型名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCaseQuantitySenateItemsEN.dicFldComparisonOp.ContainsKey(convMicroteachCaseQuantitySenateItems.AnswerTypeName) == false)
{
objvMicroteachCaseQuantitySenateItemsEN.dicFldComparisonOp.Add(convMicroteachCaseQuantitySenateItems.AnswerTypeName, strComparisonOp);
}
else
{
objvMicroteachCaseQuantitySenateItemsEN.dicFldComparisonOp[convMicroteachCaseQuantitySenateItems.AnswerTypeName] = strComparisonOp;
}
}
return objvMicroteachCaseQuantitySenateItemsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCaseQuantitySenateItemsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroteachCaseQuantitySenateItemsEN SetQuestionTypeName(this clsvMicroteachCaseQuantitySenateItemsEN objvMicroteachCaseQuantitySenateItemsEN, string strQuestionTypeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strQuestionTypeName, 20, convMicroteachCaseQuantitySenateItems.QuestionTypeName);
objvMicroteachCaseQuantitySenateItemsEN.QuestionTypeName = strQuestionTypeName; //题目类型名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCaseQuantitySenateItemsEN.dicFldComparisonOp.ContainsKey(convMicroteachCaseQuantitySenateItems.QuestionTypeName) == false)
{
objvMicroteachCaseQuantitySenateItemsEN.dicFldComparisonOp.Add(convMicroteachCaseQuantitySenateItems.QuestionTypeName, strComparisonOp);
}
else
{
objvMicroteachCaseQuantitySenateItemsEN.dicFldComparisonOp[convMicroteachCaseQuantitySenateItems.QuestionTypeName] = strComparisonOp;
}
}
return objvMicroteachCaseQuantitySenateItemsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCaseQuantitySenateItemsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroteachCaseQuantitySenateItemsEN SetsenateGaugeVersionID(this clsvMicroteachCaseQuantitySenateItemsEN objvMicroteachCaseQuantitySenateItemsEN, string strsenateGaugeVersionID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strsenateGaugeVersionID, 4, convMicroteachCaseQuantitySenateItems.senateGaugeVersionID);
clsCheckSql.CheckFieldForeignKey(strsenateGaugeVersionID, 4, convMicroteachCaseQuantitySenateItems.senateGaugeVersionID);
objvMicroteachCaseQuantitySenateItemsEN.senateGaugeVersionID = strsenateGaugeVersionID; //评价量表版本ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCaseQuantitySenateItemsEN.dicFldComparisonOp.ContainsKey(convMicroteachCaseQuantitySenateItems.senateGaugeVersionID) == false)
{
objvMicroteachCaseQuantitySenateItemsEN.dicFldComparisonOp.Add(convMicroteachCaseQuantitySenateItems.senateGaugeVersionID, strComparisonOp);
}
else
{
objvMicroteachCaseQuantitySenateItemsEN.dicFldComparisonOp[convMicroteachCaseQuantitySenateItems.senateGaugeVersionID] = strComparisonOp;
}
}
return objvMicroteachCaseQuantitySenateItemsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCaseQuantitySenateItemsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroteachCaseQuantitySenateItemsEN SetsenateGaugeVersionName(this clsvMicroteachCaseQuantitySenateItemsEN objvMicroteachCaseQuantitySenateItemsEN, string strsenateGaugeVersionName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strsenateGaugeVersionName, 200, convMicroteachCaseQuantitySenateItems.senateGaugeVersionName);
objvMicroteachCaseQuantitySenateItemsEN.senateGaugeVersionName = strsenateGaugeVersionName; //评价量表版本名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCaseQuantitySenateItemsEN.dicFldComparisonOp.ContainsKey(convMicroteachCaseQuantitySenateItems.senateGaugeVersionName) == false)
{
objvMicroteachCaseQuantitySenateItemsEN.dicFldComparisonOp.Add(convMicroteachCaseQuantitySenateItems.senateGaugeVersionName, strComparisonOp);
}
else
{
objvMicroteachCaseQuantitySenateItemsEN.dicFldComparisonOp[convMicroteachCaseQuantitySenateItems.senateGaugeVersionName] = strComparisonOp;
}
}
return objvMicroteachCaseQuantitySenateItemsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCaseQuantitySenateItemsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroteachCaseQuantitySenateItemsEN SetsenateGaugeVersionTtlScore(this clsvMicroteachCaseQuantitySenateItemsEN objvMicroteachCaseQuantitySenateItemsEN, float fltsenateGaugeVersionTtlScore, string strComparisonOp="")
	{
objvMicroteachCaseQuantitySenateItemsEN.senateGaugeVersionTtlScore = fltsenateGaugeVersionTtlScore; //评价量表版本总分
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCaseQuantitySenateItemsEN.dicFldComparisonOp.ContainsKey(convMicroteachCaseQuantitySenateItems.senateGaugeVersionTtlScore) == false)
{
objvMicroteachCaseQuantitySenateItemsEN.dicFldComparisonOp.Add(convMicroteachCaseQuantitySenateItems.senateGaugeVersionTtlScore, strComparisonOp);
}
else
{
objvMicroteachCaseQuantitySenateItemsEN.dicFldComparisonOp[convMicroteachCaseQuantitySenateItems.senateGaugeVersionTtlScore] = strComparisonOp;
}
}
return objvMicroteachCaseQuantitySenateItemsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCaseQuantitySenateItemsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroteachCaseQuantitySenateItemsEN Setid_SenateGaugeVersion(this clsvMicroteachCaseQuantitySenateItemsEN objvMicroteachCaseQuantitySenateItemsEN, string strid_SenateGaugeVersion, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strid_SenateGaugeVersion, convMicroteachCaseQuantitySenateItems.id_SenateGaugeVersion);
clsCheckSql.CheckFieldLen(strid_SenateGaugeVersion, 4, convMicroteachCaseQuantitySenateItems.id_SenateGaugeVersion);
clsCheckSql.CheckFieldForeignKey(strid_SenateGaugeVersion, 4, convMicroteachCaseQuantitySenateItems.id_SenateGaugeVersion);
objvMicroteachCaseQuantitySenateItemsEN.id_SenateGaugeVersion = strid_SenateGaugeVersion; //评价量表版本流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCaseQuantitySenateItemsEN.dicFldComparisonOp.ContainsKey(convMicroteachCaseQuantitySenateItems.id_SenateGaugeVersion) == false)
{
objvMicroteachCaseQuantitySenateItemsEN.dicFldComparisonOp.Add(convMicroteachCaseQuantitySenateItems.id_SenateGaugeVersion, strComparisonOp);
}
else
{
objvMicroteachCaseQuantitySenateItemsEN.dicFldComparisonOp[convMicroteachCaseQuantitySenateItems.id_SenateGaugeVersion] = strComparisonOp;
}
}
return objvMicroteachCaseQuantitySenateItemsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCaseQuantitySenateItemsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroteachCaseQuantitySenateItemsEN SetAnswerIndex(this clsvMicroteachCaseQuantitySenateItemsEN objvMicroteachCaseQuantitySenateItemsEN, int intAnswerIndex, string strComparisonOp="")
	{
objvMicroteachCaseQuantitySenateItemsEN.AnswerIndex = intAnswerIndex; //问答序号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCaseQuantitySenateItemsEN.dicFldComparisonOp.ContainsKey(convMicroteachCaseQuantitySenateItems.AnswerIndex) == false)
{
objvMicroteachCaseQuantitySenateItemsEN.dicFldComparisonOp.Add(convMicroteachCaseQuantitySenateItems.AnswerIndex, strComparisonOp);
}
else
{
objvMicroteachCaseQuantitySenateItemsEN.dicFldComparisonOp[convMicroteachCaseQuantitySenateItems.AnswerIndex] = strComparisonOp;
}
}
return objvMicroteachCaseQuantitySenateItemsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCaseQuantitySenateItemsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroteachCaseQuantitySenateItemsEN SetAnswerTitle(this clsvMicroteachCaseQuantitySenateItemsEN objvMicroteachCaseQuantitySenateItemsEN, string strAnswerTitle, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strAnswerTitle, 20, convMicroteachCaseQuantitySenateItems.AnswerTitle);
objvMicroteachCaseQuantitySenateItemsEN.AnswerTitle = strAnswerTitle; //答案标题
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCaseQuantitySenateItemsEN.dicFldComparisonOp.ContainsKey(convMicroteachCaseQuantitySenateItems.AnswerTitle) == false)
{
objvMicroteachCaseQuantitySenateItemsEN.dicFldComparisonOp.Add(convMicroteachCaseQuantitySenateItems.AnswerTitle, strComparisonOp);
}
else
{
objvMicroteachCaseQuantitySenateItemsEN.dicFldComparisonOp[convMicroteachCaseQuantitySenateItems.AnswerTitle] = strComparisonOp;
}
}
return objvMicroteachCaseQuantitySenateItemsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCaseQuantitySenateItemsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroteachCaseQuantitySenateItemsEN SetOwnerId(this clsvMicroteachCaseQuantitySenateItemsEN objvMicroteachCaseQuantitySenateItemsEN, string strOwnerId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strOwnerId, 20, convMicroteachCaseQuantitySenateItems.OwnerId);
objvMicroteachCaseQuantitySenateItemsEN.OwnerId = strOwnerId; //拥有者Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCaseQuantitySenateItemsEN.dicFldComparisonOp.ContainsKey(convMicroteachCaseQuantitySenateItems.OwnerId) == false)
{
objvMicroteachCaseQuantitySenateItemsEN.dicFldComparisonOp.Add(convMicroteachCaseQuantitySenateItems.OwnerId, strComparisonOp);
}
else
{
objvMicroteachCaseQuantitySenateItemsEN.dicFldComparisonOp[convMicroteachCaseQuantitySenateItems.OwnerId] = strComparisonOp;
}
}
return objvMicroteachCaseQuantitySenateItemsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCaseQuantitySenateItemsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroteachCaseQuantitySenateItemsEN SetOwnerName(this clsvMicroteachCaseQuantitySenateItemsEN objvMicroteachCaseQuantitySenateItemsEN, string strOwnerName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strOwnerName, 30, convMicroteachCaseQuantitySenateItems.OwnerName);
objvMicroteachCaseQuantitySenateItemsEN.OwnerName = strOwnerName; //拥有者姓名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCaseQuantitySenateItemsEN.dicFldComparisonOp.ContainsKey(convMicroteachCaseQuantitySenateItems.OwnerName) == false)
{
objvMicroteachCaseQuantitySenateItemsEN.dicFldComparisonOp.Add(convMicroteachCaseQuantitySenateItems.OwnerName, strComparisonOp);
}
else
{
objvMicroteachCaseQuantitySenateItemsEN.dicFldComparisonOp[convMicroteachCaseQuantitySenateItems.OwnerName] = strComparisonOp;
}
}
return objvMicroteachCaseQuantitySenateItemsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCaseQuantitySenateItemsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroteachCaseQuantitySenateItemsEN SetOwnerNameWithId(this clsvMicroteachCaseQuantitySenateItemsEN objvMicroteachCaseQuantitySenateItemsEN, string strOwnerNameWithId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strOwnerNameWithId, 51, convMicroteachCaseQuantitySenateItems.OwnerNameWithId);
objvMicroteachCaseQuantitySenateItemsEN.OwnerNameWithId = strOwnerNameWithId; //拥有者名称附Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCaseQuantitySenateItemsEN.dicFldComparisonOp.ContainsKey(convMicroteachCaseQuantitySenateItems.OwnerNameWithId) == false)
{
objvMicroteachCaseQuantitySenateItemsEN.dicFldComparisonOp.Add(convMicroteachCaseQuantitySenateItems.OwnerNameWithId, strComparisonOp);
}
else
{
objvMicroteachCaseQuantitySenateItemsEN.dicFldComparisonOp[convMicroteachCaseQuantitySenateItems.OwnerNameWithId] = strComparisonOp;
}
}
return objvMicroteachCaseQuantitySenateItemsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCaseQuantitySenateItemsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroteachCaseQuantitySenateItemsEN SetSenateIp(this clsvMicroteachCaseQuantitySenateItemsEN objvMicroteachCaseQuantitySenateItemsEN, string strSenateIp, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strSenateIp, 50, convMicroteachCaseQuantitySenateItems.SenateIp);
objvMicroteachCaseQuantitySenateItemsEN.SenateIp = strSenateIp; //评议Ip
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCaseQuantitySenateItemsEN.dicFldComparisonOp.ContainsKey(convMicroteachCaseQuantitySenateItems.SenateIp) == false)
{
objvMicroteachCaseQuantitySenateItemsEN.dicFldComparisonOp.Add(convMicroteachCaseQuantitySenateItems.SenateIp, strComparisonOp);
}
else
{
objvMicroteachCaseQuantitySenateItemsEN.dicFldComparisonOp[convMicroteachCaseQuantitySenateItems.SenateIp] = strComparisonOp;
}
}
return objvMicroteachCaseQuantitySenateItemsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCaseQuantitySenateItemsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroteachCaseQuantitySenateItemsEN SetUserNameWithUserId(this clsvMicroteachCaseQuantitySenateItemsEN objvMicroteachCaseQuantitySenateItemsEN, string strUserNameWithUserId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUserNameWithUserId, 51, convMicroteachCaseQuantitySenateItems.UserNameWithUserId);
objvMicroteachCaseQuantitySenateItemsEN.UserNameWithUserId = strUserNameWithUserId; //UserNameWithUserId
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCaseQuantitySenateItemsEN.dicFldComparisonOp.ContainsKey(convMicroteachCaseQuantitySenateItems.UserNameWithUserId) == false)
{
objvMicroteachCaseQuantitySenateItemsEN.dicFldComparisonOp.Add(convMicroteachCaseQuantitySenateItems.UserNameWithUserId, strComparisonOp);
}
else
{
objvMicroteachCaseQuantitySenateItemsEN.dicFldComparisonOp[convMicroteachCaseQuantitySenateItems.UserNameWithUserId] = strComparisonOp;
}
}
return objvMicroteachCaseQuantitySenateItemsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCaseQuantitySenateItemsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroteachCaseQuantitySenateItemsEN SetUserTypeId(this clsvMicroteachCaseQuantitySenateItemsEN objvMicroteachCaseQuantitySenateItemsEN, string strUserTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUserTypeId, 2, convMicroteachCaseQuantitySenateItems.UserTypeId);
clsCheckSql.CheckFieldForeignKey(strUserTypeId, 2, convMicroteachCaseQuantitySenateItems.UserTypeId);
objvMicroteachCaseQuantitySenateItemsEN.UserTypeId = strUserTypeId; //用户类型Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCaseQuantitySenateItemsEN.dicFldComparisonOp.ContainsKey(convMicroteachCaseQuantitySenateItems.UserTypeId) == false)
{
objvMicroteachCaseQuantitySenateItemsEN.dicFldComparisonOp.Add(convMicroteachCaseQuantitySenateItems.UserTypeId, strComparisonOp);
}
else
{
objvMicroteachCaseQuantitySenateItemsEN.dicFldComparisonOp[convMicroteachCaseQuantitySenateItems.UserTypeId] = strComparisonOp;
}
}
return objvMicroteachCaseQuantitySenateItemsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCaseQuantitySenateItemsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroteachCaseQuantitySenateItemsEN SetIsAccess(this clsvMicroteachCaseQuantitySenateItemsEN objvMicroteachCaseQuantitySenateItemsEN, bool bolIsAccess, string strComparisonOp="")
	{
objvMicroteachCaseQuantitySenateItemsEN.IsAccess = bolIsAccess; //IsAccess
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCaseQuantitySenateItemsEN.dicFldComparisonOp.ContainsKey(convMicroteachCaseQuantitySenateItems.IsAccess) == false)
{
objvMicroteachCaseQuantitySenateItemsEN.dicFldComparisonOp.Add(convMicroteachCaseQuantitySenateItems.IsAccess, strComparisonOp);
}
else
{
objvMicroteachCaseQuantitySenateItemsEN.dicFldComparisonOp[convMicroteachCaseQuantitySenateItems.IsAccess] = strComparisonOp;
}
}
return objvMicroteachCaseQuantitySenateItemsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCaseQuantitySenateItemsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroteachCaseQuantitySenateItemsEN SetIsAccessC(this clsvMicroteachCaseQuantitySenateItemsEN objvMicroteachCaseQuantitySenateItemsEN, bool bolIsAccessC, string strComparisonOp="")
	{
objvMicroteachCaseQuantitySenateItemsEN.IsAccessC = bolIsAccessC; //IsAccessC
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCaseQuantitySenateItemsEN.dicFldComparisonOp.ContainsKey(convMicroteachCaseQuantitySenateItems.IsAccessC) == false)
{
objvMicroteachCaseQuantitySenateItemsEN.dicFldComparisonOp.Add(convMicroteachCaseQuantitySenateItems.IsAccessC, strComparisonOp);
}
else
{
objvMicroteachCaseQuantitySenateItemsEN.dicFldComparisonOp[convMicroteachCaseQuantitySenateItems.IsAccessC] = strComparisonOp;
}
}
return objvMicroteachCaseQuantitySenateItemsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCaseQuantitySenateItemsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroteachCaseQuantitySenateItemsEN SetUpdDate(this clsvMicroteachCaseQuantitySenateItemsEN objvMicroteachCaseQuantitySenateItemsEN, string strUpdDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdDate, 20, convMicroteachCaseQuantitySenateItems.UpdDate);
objvMicroteachCaseQuantitySenateItemsEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCaseQuantitySenateItemsEN.dicFldComparisonOp.ContainsKey(convMicroteachCaseQuantitySenateItems.UpdDate) == false)
{
objvMicroteachCaseQuantitySenateItemsEN.dicFldComparisonOp.Add(convMicroteachCaseQuantitySenateItems.UpdDate, strComparisonOp);
}
else
{
objvMicroteachCaseQuantitySenateItemsEN.dicFldComparisonOp[convMicroteachCaseQuantitySenateItems.UpdDate] = strComparisonOp;
}
}
return objvMicroteachCaseQuantitySenateItemsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCaseQuantitySenateItemsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroteachCaseQuantitySenateItemsEN SetUpdUser(this clsvMicroteachCaseQuantitySenateItemsEN objvMicroteachCaseQuantitySenateItemsEN, string strUpdUser, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdUser, 20, convMicroteachCaseQuantitySenateItems.UpdUser);
objvMicroteachCaseQuantitySenateItemsEN.UpdUser = strUpdUser; //修改人
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCaseQuantitySenateItemsEN.dicFldComparisonOp.ContainsKey(convMicroteachCaseQuantitySenateItems.UpdUser) == false)
{
objvMicroteachCaseQuantitySenateItemsEN.dicFldComparisonOp.Add(convMicroteachCaseQuantitySenateItems.UpdUser, strComparisonOp);
}
else
{
objvMicroteachCaseQuantitySenateItemsEN.dicFldComparisonOp[convMicroteachCaseQuantitySenateItems.UpdUser] = strComparisonOp;
}
}
return objvMicroteachCaseQuantitySenateItemsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCaseQuantitySenateItemsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroteachCaseQuantitySenateItemsEN Setid_AppraiseType(this clsvMicroteachCaseQuantitySenateItemsEN objvMicroteachCaseQuantitySenateItemsEN, string strid_AppraiseType, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_AppraiseType, 4, convMicroteachCaseQuantitySenateItems.id_AppraiseType);
clsCheckSql.CheckFieldForeignKey(strid_AppraiseType, 4, convMicroteachCaseQuantitySenateItems.id_AppraiseType);
objvMicroteachCaseQuantitySenateItemsEN.id_AppraiseType = strid_AppraiseType; //评议类型流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCaseQuantitySenateItemsEN.dicFldComparisonOp.ContainsKey(convMicroteachCaseQuantitySenateItems.id_AppraiseType) == false)
{
objvMicroteachCaseQuantitySenateItemsEN.dicFldComparisonOp.Add(convMicroteachCaseQuantitySenateItems.id_AppraiseType, strComparisonOp);
}
else
{
objvMicroteachCaseQuantitySenateItemsEN.dicFldComparisonOp[convMicroteachCaseQuantitySenateItems.id_AppraiseType] = strComparisonOp;
}
}
return objvMicroteachCaseQuantitySenateItemsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCaseQuantitySenateItemsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroteachCaseQuantitySenateItemsEN SetAppraiseTypeName(this clsvMicroteachCaseQuantitySenateItemsEN objvMicroteachCaseQuantitySenateItemsEN, string strAppraiseTypeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strAppraiseTypeName, 50, convMicroteachCaseQuantitySenateItems.AppraiseTypeName);
objvMicroteachCaseQuantitySenateItemsEN.AppraiseTypeName = strAppraiseTypeName; //评议类型名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCaseQuantitySenateItemsEN.dicFldComparisonOp.ContainsKey(convMicroteachCaseQuantitySenateItems.AppraiseTypeName) == false)
{
objvMicroteachCaseQuantitySenateItemsEN.dicFldComparisonOp.Add(convMicroteachCaseQuantitySenateItems.AppraiseTypeName, strComparisonOp);
}
else
{
objvMicroteachCaseQuantitySenateItemsEN.dicFldComparisonOp[convMicroteachCaseQuantitySenateItems.AppraiseTypeName] = strComparisonOp;
}
}
return objvMicroteachCaseQuantitySenateItemsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCaseQuantitySenateItemsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroteachCaseQuantitySenateItemsEN SetFuncModuleId(this clsvMicroteachCaseQuantitySenateItemsEN objvMicroteachCaseQuantitySenateItemsEN, string strFuncModuleId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFuncModuleId, 4, convMicroteachCaseQuantitySenateItems.FuncModuleId);
clsCheckSql.CheckFieldForeignKey(strFuncModuleId, 4, convMicroteachCaseQuantitySenateItems.FuncModuleId);
objvMicroteachCaseQuantitySenateItemsEN.FuncModuleId = strFuncModuleId; //功能模块Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCaseQuantitySenateItemsEN.dicFldComparisonOp.ContainsKey(convMicroteachCaseQuantitySenateItems.FuncModuleId) == false)
{
objvMicroteachCaseQuantitySenateItemsEN.dicFldComparisonOp.Add(convMicroteachCaseQuantitySenateItems.FuncModuleId, strComparisonOp);
}
else
{
objvMicroteachCaseQuantitySenateItemsEN.dicFldComparisonOp[convMicroteachCaseQuantitySenateItems.FuncModuleId] = strComparisonOp;
}
}
return objvMicroteachCaseQuantitySenateItemsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCaseQuantitySenateItemsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroteachCaseQuantitySenateItemsEN SetUserKindId(this clsvMicroteachCaseQuantitySenateItemsEN objvMicroteachCaseQuantitySenateItemsEN, string strUserKindId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUserKindId, 2, convMicroteachCaseQuantitySenateItems.UserKindId);
clsCheckSql.CheckFieldForeignKey(strUserKindId, 2, convMicroteachCaseQuantitySenateItems.UserKindId);
objvMicroteachCaseQuantitySenateItemsEN.UserKindId = strUserKindId; //用户类别Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCaseQuantitySenateItemsEN.dicFldComparisonOp.ContainsKey(convMicroteachCaseQuantitySenateItems.UserKindId) == false)
{
objvMicroteachCaseQuantitySenateItemsEN.dicFldComparisonOp.Add(convMicroteachCaseQuantitySenateItems.UserKindId, strComparisonOp);
}
else
{
objvMicroteachCaseQuantitySenateItemsEN.dicFldComparisonOp[convMicroteachCaseQuantitySenateItems.UserKindId] = strComparisonOp;
}
}
return objvMicroteachCaseQuantitySenateItemsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCaseQuantitySenateItemsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroteachCaseQuantitySenateItemsEN SetUserKindName(this clsvMicroteachCaseQuantitySenateItemsEN objvMicroteachCaseQuantitySenateItemsEN, string strUserKindName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUserKindName, 30, convMicroteachCaseQuantitySenateItems.UserKindName);
objvMicroteachCaseQuantitySenateItemsEN.UserKindName = strUserKindName; //用户类别名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCaseQuantitySenateItemsEN.dicFldComparisonOp.ContainsKey(convMicroteachCaseQuantitySenateItems.UserKindName) == false)
{
objvMicroteachCaseQuantitySenateItemsEN.dicFldComparisonOp.Add(convMicroteachCaseQuantitySenateItems.UserKindName, strComparisonOp);
}
else
{
objvMicroteachCaseQuantitySenateItemsEN.dicFldComparisonOp[convMicroteachCaseQuantitySenateItems.UserKindName] = strComparisonOp;
}
}
return objvMicroteachCaseQuantitySenateItemsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCaseQuantitySenateItemsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroteachCaseQuantitySenateItemsEN SetUserTypeName(this clsvMicroteachCaseQuantitySenateItemsEN objvMicroteachCaseQuantitySenateItemsEN, string strUserTypeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUserTypeName, 20, convMicroteachCaseQuantitySenateItems.UserTypeName);
objvMicroteachCaseQuantitySenateItemsEN.UserTypeName = strUserTypeName; //用户类型名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCaseQuantitySenateItemsEN.dicFldComparisonOp.ContainsKey(convMicroteachCaseQuantitySenateItems.UserTypeName) == false)
{
objvMicroteachCaseQuantitySenateItemsEN.dicFldComparisonOp.Add(convMicroteachCaseQuantitySenateItems.UserTypeName, strComparisonOp);
}
else
{
objvMicroteachCaseQuantitySenateItemsEN.dicFldComparisonOp[convMicroteachCaseQuantitySenateItems.UserTypeName] = strComparisonOp;
}
}
return objvMicroteachCaseQuantitySenateItemsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCaseQuantitySenateItemsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroteachCaseQuantitySenateItemsEN SetFuncModuleName(this clsvMicroteachCaseQuantitySenateItemsEN objvMicroteachCaseQuantitySenateItemsEN, string strFuncModuleName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFuncModuleName, 30, convMicroteachCaseQuantitySenateItems.FuncModuleName);
objvMicroteachCaseQuantitySenateItemsEN.FuncModuleName = strFuncModuleName; //功能模块名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCaseQuantitySenateItemsEN.dicFldComparisonOp.ContainsKey(convMicroteachCaseQuantitySenateItems.FuncModuleName) == false)
{
objvMicroteachCaseQuantitySenateItemsEN.dicFldComparisonOp.Add(convMicroteachCaseQuantitySenateItems.FuncModuleName, strComparisonOp);
}
else
{
objvMicroteachCaseQuantitySenateItemsEN.dicFldComparisonOp[convMicroteachCaseQuantitySenateItems.FuncModuleName] = strComparisonOp;
}
}
return objvMicroteachCaseQuantitySenateItemsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCaseQuantitySenateItemsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroteachCaseQuantitySenateItemsEN Setid_XzCollege(this clsvMicroteachCaseQuantitySenateItemsEN objvMicroteachCaseQuantitySenateItemsEN, string strid_XzCollege, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_XzCollege, 4, convMicroteachCaseQuantitySenateItems.id_XzCollege);
clsCheckSql.CheckFieldForeignKey(strid_XzCollege, 4, convMicroteachCaseQuantitySenateItems.id_XzCollege);
objvMicroteachCaseQuantitySenateItemsEN.id_XzCollege = strid_XzCollege; //学院流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCaseQuantitySenateItemsEN.dicFldComparisonOp.ContainsKey(convMicroteachCaseQuantitySenateItems.id_XzCollege) == false)
{
objvMicroteachCaseQuantitySenateItemsEN.dicFldComparisonOp.Add(convMicroteachCaseQuantitySenateItems.id_XzCollege, strComparisonOp);
}
else
{
objvMicroteachCaseQuantitySenateItemsEN.dicFldComparisonOp[convMicroteachCaseQuantitySenateItems.id_XzCollege] = strComparisonOp;
}
}
return objvMicroteachCaseQuantitySenateItemsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCaseQuantitySenateItemsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMicroteachCaseQuantitySenateItemsEN SetCollegeNameA(this clsvMicroteachCaseQuantitySenateItemsEN objvMicroteachCaseQuantitySenateItemsEN, string strCollegeNameA, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCollegeNameA, 12, convMicroteachCaseQuantitySenateItems.CollegeNameA);
objvMicroteachCaseQuantitySenateItemsEN.CollegeNameA = strCollegeNameA; //学院名称简写
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCaseQuantitySenateItemsEN.dicFldComparisonOp.ContainsKey(convMicroteachCaseQuantitySenateItems.CollegeNameA) == false)
{
objvMicroteachCaseQuantitySenateItemsEN.dicFldComparisonOp.Add(convMicroteachCaseQuantitySenateItems.CollegeNameA, strComparisonOp);
}
else
{
objvMicroteachCaseQuantitySenateItemsEN.dicFldComparisonOp[convMicroteachCaseQuantitySenateItems.CollegeNameA] = strComparisonOp;
}
}
return objvMicroteachCaseQuantitySenateItemsEN;
	}

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvMicroteachCaseQuantitySenateItemsEN objvMicroteachCaseQuantitySenateItems_Cond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvMicroteachCaseQuantitySenateItems_Cond.IsUpdated(convMicroteachCaseQuantitySenateItems.id_microteachCaseQuantitySenateItem) == true)
{
string strComparisonOp_id_microteachCaseQuantitySenateItem = objvMicroteachCaseQuantitySenateItems_Cond.dicFldComparisonOp[convMicroteachCaseQuantitySenateItems.id_microteachCaseQuantitySenateItem];
strWhereCond += string.Format(" And {0} {2} {1}", convMicroteachCaseQuantitySenateItems.id_microteachCaseQuantitySenateItem, objvMicroteachCaseQuantitySenateItems_Cond.id_microteachCaseQuantitySenateItem, strComparisonOp_id_microteachCaseQuantitySenateItem);
}
if (objvMicroteachCaseQuantitySenateItems_Cond.IsUpdated(convMicroteachCaseQuantitySenateItems.id_microteachCaseQuantitySenate) == true)
{
string strComparisonOp_id_microteachCaseQuantitySenate = objvMicroteachCaseQuantitySenateItems_Cond.dicFldComparisonOp[convMicroteachCaseQuantitySenateItems.id_microteachCaseQuantitySenate];
strWhereCond += string.Format(" And {0} {2} {1}", convMicroteachCaseQuantitySenateItems.id_microteachCaseQuantitySenate, objvMicroteachCaseQuantitySenateItems_Cond.id_microteachCaseQuantitySenate, strComparisonOp_id_microteachCaseQuantitySenate);
}
if (objvMicroteachCaseQuantitySenateItems_Cond.IsUpdated(convMicroteachCaseQuantitySenateItems.id_MicroteachCase) == true)
{
string strComparisonOp_id_MicroteachCase = objvMicroteachCaseQuantitySenateItems_Cond.dicFldComparisonOp[convMicroteachCaseQuantitySenateItems.id_MicroteachCase];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCaseQuantitySenateItems.id_MicroteachCase, objvMicroteachCaseQuantitySenateItems_Cond.id_MicroteachCase, strComparisonOp_id_MicroteachCase);
}
if (objvMicroteachCaseQuantitySenateItems_Cond.IsUpdated(convMicroteachCaseQuantitySenateItems.MicroteachCaseID) == true)
{
string strComparisonOp_MicroteachCaseID = objvMicroteachCaseQuantitySenateItems_Cond.dicFldComparisonOp[convMicroteachCaseQuantitySenateItems.MicroteachCaseID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCaseQuantitySenateItems.MicroteachCaseID, objvMicroteachCaseQuantitySenateItems_Cond.MicroteachCaseID, strComparisonOp_MicroteachCaseID);
}
if (objvMicroteachCaseQuantitySenateItems_Cond.IsUpdated(convMicroteachCaseQuantitySenateItems.MicroteachCaseName) == true)
{
string strComparisonOp_MicroteachCaseName = objvMicroteachCaseQuantitySenateItems_Cond.dicFldComparisonOp[convMicroteachCaseQuantitySenateItems.MicroteachCaseName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCaseQuantitySenateItems.MicroteachCaseName, objvMicroteachCaseQuantitySenateItems_Cond.MicroteachCaseName, strComparisonOp_MicroteachCaseName);
}
if (objvMicroteachCaseQuantitySenateItems_Cond.IsUpdated(convMicroteachCaseQuantitySenateItems.id_SenateGaugeItem) == true)
{
string strComparisonOp_id_SenateGaugeItem = objvMicroteachCaseQuantitySenateItems_Cond.dicFldComparisonOp[convMicroteachCaseQuantitySenateItems.id_SenateGaugeItem];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCaseQuantitySenateItems.id_SenateGaugeItem, objvMicroteachCaseQuantitySenateItems_Cond.id_SenateGaugeItem, strComparisonOp_id_SenateGaugeItem);
}
if (objvMicroteachCaseQuantitySenateItems_Cond.IsUpdated(convMicroteachCaseQuantitySenateItems.senateGaugeItemID) == true)
{
string strComparisonOp_senateGaugeItemID = objvMicroteachCaseQuantitySenateItems_Cond.dicFldComparisonOp[convMicroteachCaseQuantitySenateItems.senateGaugeItemID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCaseQuantitySenateItems.senateGaugeItemID, objvMicroteachCaseQuantitySenateItems_Cond.senateGaugeItemID, strComparisonOp_senateGaugeItemID);
}
if (objvMicroteachCaseQuantitySenateItems_Cond.IsUpdated(convMicroteachCaseQuantitySenateItems.senateGaugeItemName) == true)
{
string strComparisonOp_senateGaugeItemName = objvMicroteachCaseQuantitySenateItems_Cond.dicFldComparisonOp[convMicroteachCaseQuantitySenateItems.senateGaugeItemName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCaseQuantitySenateItems.senateGaugeItemName, objvMicroteachCaseQuantitySenateItems_Cond.senateGaugeItemName, strComparisonOp_senateGaugeItemName);
}
if (objvMicroteachCaseQuantitySenateItems_Cond.IsUpdated(convMicroteachCaseQuantitySenateItems.senateGaugeItemNameWithOrder) == true)
{
string strComparisonOp_senateGaugeItemNameWithOrder = objvMicroteachCaseQuantitySenateItems_Cond.dicFldComparisonOp[convMicroteachCaseQuantitySenateItems.senateGaugeItemNameWithOrder];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCaseQuantitySenateItems.senateGaugeItemNameWithOrder, objvMicroteachCaseQuantitySenateItems_Cond.senateGaugeItemNameWithOrder, strComparisonOp_senateGaugeItemNameWithOrder);
}
if (objvMicroteachCaseQuantitySenateItems_Cond.IsUpdated(convMicroteachCaseQuantitySenateItems.senateGaugeItemDesc) == true)
{
string strComparisonOp_senateGaugeItemDesc = objvMicroteachCaseQuantitySenateItems_Cond.dicFldComparisonOp[convMicroteachCaseQuantitySenateItems.senateGaugeItemDesc];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCaseQuantitySenateItems.senateGaugeItemDesc, objvMicroteachCaseQuantitySenateItems_Cond.senateGaugeItemDesc, strComparisonOp_senateGaugeItemDesc);
}
if (objvMicroteachCaseQuantitySenateItems_Cond.IsUpdated(convMicroteachCaseQuantitySenateItems.senateGaugeItemMemo) == true)
{
string strComparisonOp_senateGaugeItemMemo = objvMicroteachCaseQuantitySenateItems_Cond.dicFldComparisonOp[convMicroteachCaseQuantitySenateItems.senateGaugeItemMemo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCaseQuantitySenateItems.senateGaugeItemMemo, objvMicroteachCaseQuantitySenateItems_Cond.senateGaugeItemMemo, strComparisonOp_senateGaugeItemMemo);
}
if (objvMicroteachCaseQuantitySenateItems_Cond.IsUpdated(convMicroteachCaseQuantitySenateItems.senateGaugeItemWeight) == true)
{
string strComparisonOp_senateGaugeItemWeight = objvMicroteachCaseQuantitySenateItems_Cond.dicFldComparisonOp[convMicroteachCaseQuantitySenateItems.senateGaugeItemWeight];
strWhereCond += string.Format(" And {0} {2} {1}", convMicroteachCaseQuantitySenateItems.senateGaugeItemWeight, objvMicroteachCaseQuantitySenateItems_Cond.senateGaugeItemWeight, strComparisonOp_senateGaugeItemWeight);
}
if (objvMicroteachCaseQuantitySenateItems_Cond.IsUpdated(convMicroteachCaseQuantitySenateItems.SenateScore) == true)
{
string strComparisonOp_SenateScore = objvMicroteachCaseQuantitySenateItems_Cond.dicFldComparisonOp[convMicroteachCaseQuantitySenateItems.SenateScore];
strWhereCond += string.Format(" And {0} {2} {1}", convMicroteachCaseQuantitySenateItems.SenateScore, objvMicroteachCaseQuantitySenateItems_Cond.SenateScore, strComparisonOp_SenateScore);
}
if (objvMicroteachCaseQuantitySenateItems_Cond.IsUpdated(convMicroteachCaseQuantitySenateItems.id_SenateGaugeSubItem) == true)
{
string strComparisonOp_id_SenateGaugeSubItem = objvMicroteachCaseQuantitySenateItems_Cond.dicFldComparisonOp[convMicroteachCaseQuantitySenateItems.id_SenateGaugeSubItem];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCaseQuantitySenateItems.id_SenateGaugeSubItem, objvMicroteachCaseQuantitySenateItems_Cond.id_SenateGaugeSubItem, strComparisonOp_id_SenateGaugeSubItem);
}
if (objvMicroteachCaseQuantitySenateItems_Cond.IsUpdated(convMicroteachCaseQuantitySenateItems.senateGaugeSubItemID) == true)
{
string strComparisonOp_senateGaugeSubItemID = objvMicroteachCaseQuantitySenateItems_Cond.dicFldComparisonOp[convMicroteachCaseQuantitySenateItems.senateGaugeSubItemID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCaseQuantitySenateItems.senateGaugeSubItemID, objvMicroteachCaseQuantitySenateItems_Cond.senateGaugeSubItemID, strComparisonOp_senateGaugeSubItemID);
}
if (objvMicroteachCaseQuantitySenateItems_Cond.IsUpdated(convMicroteachCaseQuantitySenateItems.senateGaugeSubItemName) == true)
{
string strComparisonOp_senateGaugeSubItemName = objvMicroteachCaseQuantitySenateItems_Cond.dicFldComparisonOp[convMicroteachCaseQuantitySenateItems.senateGaugeSubItemName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCaseQuantitySenateItems.senateGaugeSubItemName, objvMicroteachCaseQuantitySenateItems_Cond.senateGaugeSubItemName, strComparisonOp_senateGaugeSubItemName);
}
if (objvMicroteachCaseQuantitySenateItems_Cond.IsUpdated(convMicroteachCaseQuantitySenateItems.senateGaugeSubItemDesc) == true)
{
string strComparisonOp_senateGaugeSubItemDesc = objvMicroteachCaseQuantitySenateItems_Cond.dicFldComparisonOp[convMicroteachCaseQuantitySenateItems.senateGaugeSubItemDesc];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCaseQuantitySenateItems.senateGaugeSubItemDesc, objvMicroteachCaseQuantitySenateItems_Cond.senateGaugeSubItemDesc, strComparisonOp_senateGaugeSubItemDesc);
}
if (objvMicroteachCaseQuantitySenateItems_Cond.IsUpdated(convMicroteachCaseQuantitySenateItems.senateGaugeSubItemMemo) == true)
{
string strComparisonOp_senateGaugeSubItemMemo = objvMicroteachCaseQuantitySenateItems_Cond.dicFldComparisonOp[convMicroteachCaseQuantitySenateItems.senateGaugeSubItemMemo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCaseQuantitySenateItems.senateGaugeSubItemMemo, objvMicroteachCaseQuantitySenateItems_Cond.senateGaugeSubItemMemo, strComparisonOp_senateGaugeSubItemMemo);
}
if (objvMicroteachCaseQuantitySenateItems_Cond.IsUpdated(convMicroteachCaseQuantitySenateItems.senateGaugeSubItemScore) == true)
{
string strComparisonOp_senateGaugeSubItemScore = objvMicroteachCaseQuantitySenateItems_Cond.dicFldComparisonOp[convMicroteachCaseQuantitySenateItems.senateGaugeSubItemScore];
strWhereCond += string.Format(" And {0} {2} {1}", convMicroteachCaseQuantitySenateItems.senateGaugeSubItemScore, objvMicroteachCaseQuantitySenateItems_Cond.senateGaugeSubItemScore, strComparisonOp_senateGaugeSubItemScore);
}
if (objvMicroteachCaseQuantitySenateItems_Cond.IsUpdated(convMicroteachCaseQuantitySenateItems.UserId) == true)
{
string strComparisonOp_UserId = objvMicroteachCaseQuantitySenateItems_Cond.dicFldComparisonOp[convMicroteachCaseQuantitySenateItems.UserId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCaseQuantitySenateItems.UserId, objvMicroteachCaseQuantitySenateItems_Cond.UserId, strComparisonOp_UserId);
}
if (objvMicroteachCaseQuantitySenateItems_Cond.IsUpdated(convMicroteachCaseQuantitySenateItems.UserName) == true)
{
string strComparisonOp_UserName = objvMicroteachCaseQuantitySenateItems_Cond.dicFldComparisonOp[convMicroteachCaseQuantitySenateItems.UserName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCaseQuantitySenateItems.UserName, objvMicroteachCaseQuantitySenateItems_Cond.UserName, strComparisonOp_UserName);
}
if (objvMicroteachCaseQuantitySenateItems_Cond.IsUpdated(convMicroteachCaseQuantitySenateItems.CollegeID) == true)
{
string strComparisonOp_CollegeID = objvMicroteachCaseQuantitySenateItems_Cond.dicFldComparisonOp[convMicroteachCaseQuantitySenateItems.CollegeID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCaseQuantitySenateItems.CollegeID, objvMicroteachCaseQuantitySenateItems_Cond.CollegeID, strComparisonOp_CollegeID);
}
if (objvMicroteachCaseQuantitySenateItems_Cond.IsUpdated(convMicroteachCaseQuantitySenateItems.CollegeName) == true)
{
string strComparisonOp_CollegeName = objvMicroteachCaseQuantitySenateItems_Cond.dicFldComparisonOp[convMicroteachCaseQuantitySenateItems.CollegeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCaseQuantitySenateItems.CollegeName, objvMicroteachCaseQuantitySenateItems_Cond.CollegeName, strComparisonOp_CollegeName);
}
if (objvMicroteachCaseQuantitySenateItems_Cond.IsUpdated(convMicroteachCaseQuantitySenateItems.SenateTheme) == true)
{
string strComparisonOp_SenateTheme = objvMicroteachCaseQuantitySenateItems_Cond.dicFldComparisonOp[convMicroteachCaseQuantitySenateItems.SenateTheme];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCaseQuantitySenateItems.SenateTheme, objvMicroteachCaseQuantitySenateItems_Cond.SenateTheme, strComparisonOp_SenateTheme);
}
if (objvMicroteachCaseQuantitySenateItems_Cond.IsUpdated(convMicroteachCaseQuantitySenateItems.SenateContent) == true)
{
string strComparisonOp_SenateContent = objvMicroteachCaseQuantitySenateItems_Cond.dicFldComparisonOp[convMicroteachCaseQuantitySenateItems.SenateContent];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCaseQuantitySenateItems.SenateContent, objvMicroteachCaseQuantitySenateItems_Cond.SenateContent, strComparisonOp_SenateContent);
}
if (objvMicroteachCaseQuantitySenateItems_Cond.IsUpdated(convMicroteachCaseQuantitySenateItems.SenateDate) == true)
{
string strComparisonOp_SenateDate = objvMicroteachCaseQuantitySenateItems_Cond.dicFldComparisonOp[convMicroteachCaseQuantitySenateItems.SenateDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCaseQuantitySenateItems.SenateDate, objvMicroteachCaseQuantitySenateItems_Cond.SenateDate, strComparisonOp_SenateDate);
}
if (objvMicroteachCaseQuantitySenateItems_Cond.IsUpdated(convMicroteachCaseQuantitySenateItems.SenateTime) == true)
{
string strComparisonOp_SenateTime = objvMicroteachCaseQuantitySenateItems_Cond.dicFldComparisonOp[convMicroteachCaseQuantitySenateItems.SenateTime];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCaseQuantitySenateItems.SenateTime, objvMicroteachCaseQuantitySenateItems_Cond.SenateTime, strComparisonOp_SenateTime);
}
if (objvMicroteachCaseQuantitySenateItems_Cond.IsUpdated(convMicroteachCaseQuantitySenateItems.SenateTotalScore) == true)
{
string strComparisonOp_SenateTotalScore = objvMicroteachCaseQuantitySenateItems_Cond.dicFldComparisonOp[convMicroteachCaseQuantitySenateItems.SenateTotalScore];
strWhereCond += string.Format(" And {0} {2} {1}", convMicroteachCaseQuantitySenateItems.SenateTotalScore, objvMicroteachCaseQuantitySenateItems_Cond.SenateTotalScore, strComparisonOp_SenateTotalScore);
}
if (objvMicroteachCaseQuantitySenateItems_Cond.IsUpdated(convMicroteachCaseQuantitySenateItems.AnswerModeId) == true)
{
string strComparisonOp_AnswerModeId = objvMicroteachCaseQuantitySenateItems_Cond.dicFldComparisonOp[convMicroteachCaseQuantitySenateItems.AnswerModeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCaseQuantitySenateItems.AnswerModeId, objvMicroteachCaseQuantitySenateItems_Cond.AnswerModeId, strComparisonOp_AnswerModeId);
}
if (objvMicroteachCaseQuantitySenateItems_Cond.IsUpdated(convMicroteachCaseQuantitySenateItems.AnswerTypeId) == true)
{
string strComparisonOp_AnswerTypeId = objvMicroteachCaseQuantitySenateItems_Cond.dicFldComparisonOp[convMicroteachCaseQuantitySenateItems.AnswerTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCaseQuantitySenateItems.AnswerTypeId, objvMicroteachCaseQuantitySenateItems_Cond.AnswerTypeId, strComparisonOp_AnswerTypeId);
}
if (objvMicroteachCaseQuantitySenateItems_Cond.IsUpdated(convMicroteachCaseQuantitySenateItems.GridTitle) == true)
{
string strComparisonOp_GridTitle = objvMicroteachCaseQuantitySenateItems_Cond.dicFldComparisonOp[convMicroteachCaseQuantitySenateItems.GridTitle];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCaseQuantitySenateItems.GridTitle, objvMicroteachCaseQuantitySenateItems_Cond.GridTitle, strComparisonOp_GridTitle);
}
if (objvMicroteachCaseQuantitySenateItems_Cond.IsUpdated(convMicroteachCaseQuantitySenateItems.QuestionIndex) == true)
{
string strComparisonOp_QuestionIndex = objvMicroteachCaseQuantitySenateItems_Cond.dicFldComparisonOp[convMicroteachCaseQuantitySenateItems.QuestionIndex];
strWhereCond += string.Format(" And {0} {2} {1}", convMicroteachCaseQuantitySenateItems.QuestionIndex, objvMicroteachCaseQuantitySenateItems_Cond.QuestionIndex, strComparisonOp_QuestionIndex);
}
if (objvMicroteachCaseQuantitySenateItems_Cond.IsUpdated(convMicroteachCaseQuantitySenateItems.QuestionNo) == true)
{
string strComparisonOp_QuestionNo = objvMicroteachCaseQuantitySenateItems_Cond.dicFldComparisonOp[convMicroteachCaseQuantitySenateItems.QuestionNo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCaseQuantitySenateItems.QuestionNo, objvMicroteachCaseQuantitySenateItems_Cond.QuestionNo, strComparisonOp_QuestionNo);
}
if (objvMicroteachCaseQuantitySenateItems_Cond.IsUpdated(convMicroteachCaseQuantitySenateItems.QuestionTypeId) == true)
{
string strComparisonOp_QuestionTypeId = objvMicroteachCaseQuantitySenateItems_Cond.dicFldComparisonOp[convMicroteachCaseQuantitySenateItems.QuestionTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCaseQuantitySenateItems.QuestionTypeId, objvMicroteachCaseQuantitySenateItems_Cond.QuestionTypeId, strComparisonOp_QuestionTypeId);
}
if (objvMicroteachCaseQuantitySenateItems_Cond.IsUpdated(convMicroteachCaseQuantitySenateItems.AnswerModeName) == true)
{
string strComparisonOp_AnswerModeName = objvMicroteachCaseQuantitySenateItems_Cond.dicFldComparisonOp[convMicroteachCaseQuantitySenateItems.AnswerModeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCaseQuantitySenateItems.AnswerModeName, objvMicroteachCaseQuantitySenateItems_Cond.AnswerModeName, strComparisonOp_AnswerModeName);
}
if (objvMicroteachCaseQuantitySenateItems_Cond.IsUpdated(convMicroteachCaseQuantitySenateItems.AnswerNum) == true)
{
string strComparisonOp_AnswerNum = objvMicroteachCaseQuantitySenateItems_Cond.dicFldComparisonOp[convMicroteachCaseQuantitySenateItems.AnswerNum];
strWhereCond += string.Format(" And {0} {2} {1}", convMicroteachCaseQuantitySenateItems.AnswerNum, objvMicroteachCaseQuantitySenateItems_Cond.AnswerNum, strComparisonOp_AnswerNum);
}
if (objvMicroteachCaseQuantitySenateItems_Cond.IsUpdated(convMicroteachCaseQuantitySenateItems.AnswerTypeName) == true)
{
string strComparisonOp_AnswerTypeName = objvMicroteachCaseQuantitySenateItems_Cond.dicFldComparisonOp[convMicroteachCaseQuantitySenateItems.AnswerTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCaseQuantitySenateItems.AnswerTypeName, objvMicroteachCaseQuantitySenateItems_Cond.AnswerTypeName, strComparisonOp_AnswerTypeName);
}
if (objvMicroteachCaseQuantitySenateItems_Cond.IsUpdated(convMicroteachCaseQuantitySenateItems.QuestionTypeName) == true)
{
string strComparisonOp_QuestionTypeName = objvMicroteachCaseQuantitySenateItems_Cond.dicFldComparisonOp[convMicroteachCaseQuantitySenateItems.QuestionTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCaseQuantitySenateItems.QuestionTypeName, objvMicroteachCaseQuantitySenateItems_Cond.QuestionTypeName, strComparisonOp_QuestionTypeName);
}
if (objvMicroteachCaseQuantitySenateItems_Cond.IsUpdated(convMicroteachCaseQuantitySenateItems.senateGaugeVersionID) == true)
{
string strComparisonOp_senateGaugeVersionID = objvMicroteachCaseQuantitySenateItems_Cond.dicFldComparisonOp[convMicroteachCaseQuantitySenateItems.senateGaugeVersionID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCaseQuantitySenateItems.senateGaugeVersionID, objvMicroteachCaseQuantitySenateItems_Cond.senateGaugeVersionID, strComparisonOp_senateGaugeVersionID);
}
if (objvMicroteachCaseQuantitySenateItems_Cond.IsUpdated(convMicroteachCaseQuantitySenateItems.senateGaugeVersionName) == true)
{
string strComparisonOp_senateGaugeVersionName = objvMicroteachCaseQuantitySenateItems_Cond.dicFldComparisonOp[convMicroteachCaseQuantitySenateItems.senateGaugeVersionName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCaseQuantitySenateItems.senateGaugeVersionName, objvMicroteachCaseQuantitySenateItems_Cond.senateGaugeVersionName, strComparisonOp_senateGaugeVersionName);
}
if (objvMicroteachCaseQuantitySenateItems_Cond.IsUpdated(convMicroteachCaseQuantitySenateItems.senateGaugeVersionTtlScore) == true)
{
string strComparisonOp_senateGaugeVersionTtlScore = objvMicroteachCaseQuantitySenateItems_Cond.dicFldComparisonOp[convMicroteachCaseQuantitySenateItems.senateGaugeVersionTtlScore];
strWhereCond += string.Format(" And {0} {2} {1}", convMicroteachCaseQuantitySenateItems.senateGaugeVersionTtlScore, objvMicroteachCaseQuantitySenateItems_Cond.senateGaugeVersionTtlScore, strComparisonOp_senateGaugeVersionTtlScore);
}
if (objvMicroteachCaseQuantitySenateItems_Cond.IsUpdated(convMicroteachCaseQuantitySenateItems.id_SenateGaugeVersion) == true)
{
string strComparisonOp_id_SenateGaugeVersion = objvMicroteachCaseQuantitySenateItems_Cond.dicFldComparisonOp[convMicroteachCaseQuantitySenateItems.id_SenateGaugeVersion];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCaseQuantitySenateItems.id_SenateGaugeVersion, objvMicroteachCaseQuantitySenateItems_Cond.id_SenateGaugeVersion, strComparisonOp_id_SenateGaugeVersion);
}
if (objvMicroteachCaseQuantitySenateItems_Cond.IsUpdated(convMicroteachCaseQuantitySenateItems.AnswerIndex) == true)
{
string strComparisonOp_AnswerIndex = objvMicroteachCaseQuantitySenateItems_Cond.dicFldComparisonOp[convMicroteachCaseQuantitySenateItems.AnswerIndex];
strWhereCond += string.Format(" And {0} {2} {1}", convMicroteachCaseQuantitySenateItems.AnswerIndex, objvMicroteachCaseQuantitySenateItems_Cond.AnswerIndex, strComparisonOp_AnswerIndex);
}
if (objvMicroteachCaseQuantitySenateItems_Cond.IsUpdated(convMicroteachCaseQuantitySenateItems.AnswerTitle) == true)
{
string strComparisonOp_AnswerTitle = objvMicroteachCaseQuantitySenateItems_Cond.dicFldComparisonOp[convMicroteachCaseQuantitySenateItems.AnswerTitle];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCaseQuantitySenateItems.AnswerTitle, objvMicroteachCaseQuantitySenateItems_Cond.AnswerTitle, strComparisonOp_AnswerTitle);
}
if (objvMicroteachCaseQuantitySenateItems_Cond.IsUpdated(convMicroteachCaseQuantitySenateItems.OwnerId) == true)
{
string strComparisonOp_OwnerId = objvMicroteachCaseQuantitySenateItems_Cond.dicFldComparisonOp[convMicroteachCaseQuantitySenateItems.OwnerId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCaseQuantitySenateItems.OwnerId, objvMicroteachCaseQuantitySenateItems_Cond.OwnerId, strComparisonOp_OwnerId);
}
if (objvMicroteachCaseQuantitySenateItems_Cond.IsUpdated(convMicroteachCaseQuantitySenateItems.OwnerName) == true)
{
string strComparisonOp_OwnerName = objvMicroteachCaseQuantitySenateItems_Cond.dicFldComparisonOp[convMicroteachCaseQuantitySenateItems.OwnerName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCaseQuantitySenateItems.OwnerName, objvMicroteachCaseQuantitySenateItems_Cond.OwnerName, strComparisonOp_OwnerName);
}
if (objvMicroteachCaseQuantitySenateItems_Cond.IsUpdated(convMicroteachCaseQuantitySenateItems.OwnerNameWithId) == true)
{
string strComparisonOp_OwnerNameWithId = objvMicroteachCaseQuantitySenateItems_Cond.dicFldComparisonOp[convMicroteachCaseQuantitySenateItems.OwnerNameWithId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCaseQuantitySenateItems.OwnerNameWithId, objvMicroteachCaseQuantitySenateItems_Cond.OwnerNameWithId, strComparisonOp_OwnerNameWithId);
}
if (objvMicroteachCaseQuantitySenateItems_Cond.IsUpdated(convMicroteachCaseQuantitySenateItems.SenateIp) == true)
{
string strComparisonOp_SenateIp = objvMicroteachCaseQuantitySenateItems_Cond.dicFldComparisonOp[convMicroteachCaseQuantitySenateItems.SenateIp];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCaseQuantitySenateItems.SenateIp, objvMicroteachCaseQuantitySenateItems_Cond.SenateIp, strComparisonOp_SenateIp);
}
if (objvMicroteachCaseQuantitySenateItems_Cond.IsUpdated(convMicroteachCaseQuantitySenateItems.UserNameWithUserId) == true)
{
string strComparisonOp_UserNameWithUserId = objvMicroteachCaseQuantitySenateItems_Cond.dicFldComparisonOp[convMicroteachCaseQuantitySenateItems.UserNameWithUserId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCaseQuantitySenateItems.UserNameWithUserId, objvMicroteachCaseQuantitySenateItems_Cond.UserNameWithUserId, strComparisonOp_UserNameWithUserId);
}
if (objvMicroteachCaseQuantitySenateItems_Cond.IsUpdated(convMicroteachCaseQuantitySenateItems.UserTypeId) == true)
{
string strComparisonOp_UserTypeId = objvMicroteachCaseQuantitySenateItems_Cond.dicFldComparisonOp[convMicroteachCaseQuantitySenateItems.UserTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCaseQuantitySenateItems.UserTypeId, objvMicroteachCaseQuantitySenateItems_Cond.UserTypeId, strComparisonOp_UserTypeId);
}
if (objvMicroteachCaseQuantitySenateItems_Cond.IsUpdated(convMicroteachCaseQuantitySenateItems.IsAccess) == true)
{
if (objvMicroteachCaseQuantitySenateItems_Cond.IsAccess == true)
{
strWhereCond += string.Format(" And {0} = '1'", convMicroteachCaseQuantitySenateItems.IsAccess);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convMicroteachCaseQuantitySenateItems.IsAccess);
}
}
if (objvMicroteachCaseQuantitySenateItems_Cond.IsUpdated(convMicroteachCaseQuantitySenateItems.IsAccessC) == true)
{
if (objvMicroteachCaseQuantitySenateItems_Cond.IsAccessC == true)
{
strWhereCond += string.Format(" And {0} = '1'", convMicroteachCaseQuantitySenateItems.IsAccessC);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convMicroteachCaseQuantitySenateItems.IsAccessC);
}
}
if (objvMicroteachCaseQuantitySenateItems_Cond.IsUpdated(convMicroteachCaseQuantitySenateItems.UpdDate) == true)
{
string strComparisonOp_UpdDate = objvMicroteachCaseQuantitySenateItems_Cond.dicFldComparisonOp[convMicroteachCaseQuantitySenateItems.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCaseQuantitySenateItems.UpdDate, objvMicroteachCaseQuantitySenateItems_Cond.UpdDate, strComparisonOp_UpdDate);
}
if (objvMicroteachCaseQuantitySenateItems_Cond.IsUpdated(convMicroteachCaseQuantitySenateItems.UpdUser) == true)
{
string strComparisonOp_UpdUser = objvMicroteachCaseQuantitySenateItems_Cond.dicFldComparisonOp[convMicroteachCaseQuantitySenateItems.UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCaseQuantitySenateItems.UpdUser, objvMicroteachCaseQuantitySenateItems_Cond.UpdUser, strComparisonOp_UpdUser);
}
if (objvMicroteachCaseQuantitySenateItems_Cond.IsUpdated(convMicroteachCaseQuantitySenateItems.id_AppraiseType) == true)
{
string strComparisonOp_id_AppraiseType = objvMicroteachCaseQuantitySenateItems_Cond.dicFldComparisonOp[convMicroteachCaseQuantitySenateItems.id_AppraiseType];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCaseQuantitySenateItems.id_AppraiseType, objvMicroteachCaseQuantitySenateItems_Cond.id_AppraiseType, strComparisonOp_id_AppraiseType);
}
if (objvMicroteachCaseQuantitySenateItems_Cond.IsUpdated(convMicroteachCaseQuantitySenateItems.AppraiseTypeName) == true)
{
string strComparisonOp_AppraiseTypeName = objvMicroteachCaseQuantitySenateItems_Cond.dicFldComparisonOp[convMicroteachCaseQuantitySenateItems.AppraiseTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCaseQuantitySenateItems.AppraiseTypeName, objvMicroteachCaseQuantitySenateItems_Cond.AppraiseTypeName, strComparisonOp_AppraiseTypeName);
}
if (objvMicroteachCaseQuantitySenateItems_Cond.IsUpdated(convMicroteachCaseQuantitySenateItems.FuncModuleId) == true)
{
string strComparisonOp_FuncModuleId = objvMicroteachCaseQuantitySenateItems_Cond.dicFldComparisonOp[convMicroteachCaseQuantitySenateItems.FuncModuleId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCaseQuantitySenateItems.FuncModuleId, objvMicroteachCaseQuantitySenateItems_Cond.FuncModuleId, strComparisonOp_FuncModuleId);
}
if (objvMicroteachCaseQuantitySenateItems_Cond.IsUpdated(convMicroteachCaseQuantitySenateItems.UserKindId) == true)
{
string strComparisonOp_UserKindId = objvMicroteachCaseQuantitySenateItems_Cond.dicFldComparisonOp[convMicroteachCaseQuantitySenateItems.UserKindId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCaseQuantitySenateItems.UserKindId, objvMicroteachCaseQuantitySenateItems_Cond.UserKindId, strComparisonOp_UserKindId);
}
if (objvMicroteachCaseQuantitySenateItems_Cond.IsUpdated(convMicroteachCaseQuantitySenateItems.UserKindName) == true)
{
string strComparisonOp_UserKindName = objvMicroteachCaseQuantitySenateItems_Cond.dicFldComparisonOp[convMicroteachCaseQuantitySenateItems.UserKindName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCaseQuantitySenateItems.UserKindName, objvMicroteachCaseQuantitySenateItems_Cond.UserKindName, strComparisonOp_UserKindName);
}
if (objvMicroteachCaseQuantitySenateItems_Cond.IsUpdated(convMicroteachCaseQuantitySenateItems.UserTypeName) == true)
{
string strComparisonOp_UserTypeName = objvMicroteachCaseQuantitySenateItems_Cond.dicFldComparisonOp[convMicroteachCaseQuantitySenateItems.UserTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCaseQuantitySenateItems.UserTypeName, objvMicroteachCaseQuantitySenateItems_Cond.UserTypeName, strComparisonOp_UserTypeName);
}
if (objvMicroteachCaseQuantitySenateItems_Cond.IsUpdated(convMicroteachCaseQuantitySenateItems.FuncModuleName) == true)
{
string strComparisonOp_FuncModuleName = objvMicroteachCaseQuantitySenateItems_Cond.dicFldComparisonOp[convMicroteachCaseQuantitySenateItems.FuncModuleName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCaseQuantitySenateItems.FuncModuleName, objvMicroteachCaseQuantitySenateItems_Cond.FuncModuleName, strComparisonOp_FuncModuleName);
}
if (objvMicroteachCaseQuantitySenateItems_Cond.IsUpdated(convMicroteachCaseQuantitySenateItems.id_XzCollege) == true)
{
string strComparisonOp_id_XzCollege = objvMicroteachCaseQuantitySenateItems_Cond.dicFldComparisonOp[convMicroteachCaseQuantitySenateItems.id_XzCollege];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCaseQuantitySenateItems.id_XzCollege, objvMicroteachCaseQuantitySenateItems_Cond.id_XzCollege, strComparisonOp_id_XzCollege);
}
if (objvMicroteachCaseQuantitySenateItems_Cond.IsUpdated(convMicroteachCaseQuantitySenateItems.CollegeNameA) == true)
{
string strComparisonOp_CollegeNameA = objvMicroteachCaseQuantitySenateItems_Cond.dicFldComparisonOp[convMicroteachCaseQuantitySenateItems.CollegeNameA];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCaseQuantitySenateItems.CollegeNameA, objvMicroteachCaseQuantitySenateItems_Cond.CollegeNameA, strComparisonOp_CollegeNameA);
}
 return strWhereCond;
}
}
 /// <summary>
 /// 微格量化评价详细(vMicroteachCaseQuantitySenateItems)
 /// (AutoGCLib.WA_Access4CSharp:GeneCode)
 /// </summary>
public class clsvMicroteachCaseQuantitySenateItemsWApi
{
private static readonly string mstrApiControllerName = "vMicroteachCaseQuantitySenateItemsApi";

 public clsvMicroteachCaseQuantitySenateItemsWApi()
 {
 }

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyId)
 /// </summary>
 /// <param name = "lngid_microteachCaseQuantitySenateItem">表关键字</param>
 /// <returns>表对象</returns>
public static clsvMicroteachCaseQuantitySenateItemsEN GetObjByid_microteachCaseQuantitySenateItem(long lngid_microteachCaseQuantitySenateItem)
{
string strAction = "GetObjByid_microteachCaseQuantitySenateItem";
string strErrMsg = string.Empty;
string strResult = "";
clsvMicroteachCaseQuantitySenateItemsEN objvMicroteachCaseQuantitySenateItemsEN = null;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["id_microteachCaseQuantitySenateItem"] = lngid_microteachCaseQuantitySenateItem.ToString()
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
objvMicroteachCaseQuantitySenateItemsEN = JsonConvert.DeserializeObject<clsvMicroteachCaseQuantitySenateItemsEN>((string)jobjReturn["ReturnObj"]);
return objvMicroteachCaseQuantitySenateItemsEN;
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
 /// <param name = "lngid_microteachCaseQuantitySenateItem">表关键字</param>
 /// <returns>表对象</returns>
public static clsvMicroteachCaseQuantitySenateItemsEN GetObjByid_microteachCaseQuantitySenateItem_WA_Cache(long lngid_microteachCaseQuantitySenateItem)
{
string strAction = "GetObjByid_microteachCaseQuantitySenateItem_Cache";
string strErrMsg = string.Empty;
string strResult = "";
clsvMicroteachCaseQuantitySenateItemsEN objvMicroteachCaseQuantitySenateItemsEN = null;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["id_microteachCaseQuantitySenateItem"] = lngid_microteachCaseQuantitySenateItem.ToString()
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
objvMicroteachCaseQuantitySenateItemsEN = JsonConvert.DeserializeObject<clsvMicroteachCaseQuantitySenateItemsEN>((string)jobjReturn["ReturnObj"]);
return objvMicroteachCaseQuantitySenateItemsEN;
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
public static long GetFirstID(string strWhereCond)
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
return long.Parse(strReturnStr);
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
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetFirstObj)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的关键字值</returns>
public static clsvMicroteachCaseQuantitySenateItemsEN GetFirstObj(string strWhereCond)
{
string strAction = "GetFirstObj";
string strErrMsg = string.Empty;
string strResult = "";
clsvMicroteachCaseQuantitySenateItemsEN objvMicroteachCaseQuantitySenateItemsEN = null;
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
objvMicroteachCaseQuantitySenateItemsEN = JsonConvert.DeserializeObject<clsvMicroteachCaseQuantitySenateItemsEN>((string)jobjReturn["ReturnObj"]);
return objvMicroteachCaseQuantitySenateItemsEN;
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
 /// <param name = "lngid_microteachCaseQuantitySenateItem">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvMicroteachCaseQuantitySenateItemsEN GetObjByid_microteachCaseQuantitySenateItem_Cache(long lngid_microteachCaseQuantitySenateItem)
{
//初始化列表缓存
string strKey = string.Format("{0}", clsvMicroteachCaseQuantitySenateItemsEN._CurrTabName_S);
List<clsvMicroteachCaseQuantitySenateItemsEN> arrvMicroteachCaseQuantitySenateItemsObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsvMicroteachCaseQuantitySenateItemsEN> arrvMicroteachCaseQuantitySenateItemsObjLst_Sel =
from objvMicroteachCaseQuantitySenateItemsEN in arrvMicroteachCaseQuantitySenateItemsObjLst_Cache
where objvMicroteachCaseQuantitySenateItemsEN.id_microteachCaseQuantitySenateItem == lngid_microteachCaseQuantitySenateItem
select objvMicroteachCaseQuantitySenateItemsEN;
if (arrvMicroteachCaseQuantitySenateItemsObjLst_Sel.Count() == 0)
{
   clsvMicroteachCaseQuantitySenateItemsEN obj = clsvMicroteachCaseQuantitySenateItemsWApi.GetObjByid_microteachCaseQuantitySenateItem(lngid_microteachCaseQuantitySenateItem);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
     return obj;
 }
return null;
}
return arrvMicroteachCaseQuantitySenateItemsObjLst_Sel.First();
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvMicroteachCaseQuantitySenateItemsEN> GetObjLst(string strWhereCond)
{
 List<clsvMicroteachCaseQuantitySenateItemsEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvMicroteachCaseQuantitySenateItemsEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvMicroteachCaseQuantitySenateItemsEN> GetObjLstById_microteachCaseQuantitySenateItemLst(List<long> arrId_microteachCaseQuantitySenateItem)
{
 List<clsvMicroteachCaseQuantitySenateItemsEN> arrObjLst = null; 
string strAction = "GetObjLstById_microteachCaseQuantitySenateItemLst";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrId_microteachCaseQuantitySenateItem);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
arrObjLst = JsonConvert.DeserializeObject<List<clsvMicroteachCaseQuantitySenateItemsEN>>((string)jobjReturn["ReturnObjLst"]);
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
 /// <param name = "lngid_microteachCaseQuantitySenateItem">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static IEnumerable<clsvMicroteachCaseQuantitySenateItemsEN> GetObjLstById_microteachCaseQuantitySenateItemLst_Cache(List<long> arrId_microteachCaseQuantitySenateItem)
{
//初始化列表缓存
string strKey = string.Format("{0}", clsvMicroteachCaseQuantitySenateItemsEN._CurrTabName_S);
List<clsvMicroteachCaseQuantitySenateItemsEN> arrvMicroteachCaseQuantitySenateItemsObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsvMicroteachCaseQuantitySenateItemsEN> arrvMicroteachCaseQuantitySenateItemsObjLst_Sel =
from objvMicroteachCaseQuantitySenateItemsEN in arrvMicroteachCaseQuantitySenateItemsObjLst_Cache
where arrId_microteachCaseQuantitySenateItem.Contains(objvMicroteachCaseQuantitySenateItemsEN.id_microteachCaseQuantitySenateItem)
select objvMicroteachCaseQuantitySenateItemsEN;
return arrvMicroteachCaseQuantitySenateItemsObjLst_Sel;
}

 /// <summary>
 /// 根据关键字列表获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstByKeyLst_WA_Cache)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvMicroteachCaseQuantitySenateItemsEN> GetObjLstById_microteachCaseQuantitySenateItemLst_WA_Cache(List<long> arrId_microteachCaseQuantitySenateItem)
{
 List<clsvMicroteachCaseQuantitySenateItemsEN> arrObjLst = null; 
string strAction = "GetObjLstById_microteachCaseQuantitySenateItemLst_Cache";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
};
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrId_microteachCaseQuantitySenateItem);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
arrObjLst = JsonConvert.DeserializeObject<List<clsvMicroteachCaseQuantitySenateItemsEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvMicroteachCaseQuantitySenateItemsEN> GetTopObjLst(stuTopPara objTopPara)
{
 List<clsvMicroteachCaseQuantitySenateItemsEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvMicroteachCaseQuantitySenateItemsEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvMicroteachCaseQuantitySenateItemsEN> GetObjLstByRange(stuRangePara objRangePara)
{
 List<clsvMicroteachCaseQuantitySenateItemsEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvMicroteachCaseQuantitySenateItemsEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvMicroteachCaseQuantitySenateItemsEN> GetObjLstByPager(stuPagerPara objPagerPara)
{
 List<clsvMicroteachCaseQuantitySenateItemsEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvMicroteachCaseQuantitySenateItemsEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvMicroteachCaseQuantitySenateItemsEN> GetObjLstByPager_Cache(stuPagerPara objPagerPara)
{
 List<clsvMicroteachCaseQuantitySenateItemsEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvMicroteachCaseQuantitySenateItemsEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static bool IsExist(long lngid_microteachCaseQuantitySenateItem)
{
//检测记录是否存在
string strAction = "IsExist";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["id_microteachCaseQuantitySenateItem"] = lngid_microteachCaseQuantitySenateItem.ToString()
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
 /// <param name = "objvMicroteachCaseQuantitySenateItemsENS">源对象</param>
 /// <param name = "objvMicroteachCaseQuantitySenateItemsENT">目标对象</param>
 public static void CopyTo(clsvMicroteachCaseQuantitySenateItemsEN objvMicroteachCaseQuantitySenateItemsENS, clsvMicroteachCaseQuantitySenateItemsEN objvMicroteachCaseQuantitySenateItemsENT)
{
try
{
objvMicroteachCaseQuantitySenateItemsENT.id_microteachCaseQuantitySenateItem = objvMicroteachCaseQuantitySenateItemsENS.id_microteachCaseQuantitySenateItem; //微格量化评价指标流水号
objvMicroteachCaseQuantitySenateItemsENT.id_microteachCaseQuantitySenate = objvMicroteachCaseQuantitySenateItemsENS.id_microteachCaseQuantitySenate; //微格量化评价流水号
objvMicroteachCaseQuantitySenateItemsENT.id_MicroteachCase = objvMicroteachCaseQuantitySenateItemsENS.id_MicroteachCase; //微格教学案例流水号
objvMicroteachCaseQuantitySenateItemsENT.MicroteachCaseID = objvMicroteachCaseQuantitySenateItemsENS.MicroteachCaseID; //微格教学案例ID
objvMicroteachCaseQuantitySenateItemsENT.MicroteachCaseName = objvMicroteachCaseQuantitySenateItemsENS.MicroteachCaseName; //微格教学案例名称
objvMicroteachCaseQuantitySenateItemsENT.id_SenateGaugeItem = objvMicroteachCaseQuantitySenateItemsENS.id_SenateGaugeItem; //量表指标流水号
objvMicroteachCaseQuantitySenateItemsENT.senateGaugeItemID = objvMicroteachCaseQuantitySenateItemsENS.senateGaugeItemID; //量表指标ID
objvMicroteachCaseQuantitySenateItemsENT.senateGaugeItemName = objvMicroteachCaseQuantitySenateItemsENS.senateGaugeItemName; //量表指标名称
objvMicroteachCaseQuantitySenateItemsENT.senateGaugeItemNameWithOrder = objvMicroteachCaseQuantitySenateItemsENS.senateGaugeItemNameWithOrder; //量表指标名称WithOrder
objvMicroteachCaseQuantitySenateItemsENT.senateGaugeItemDesc = objvMicroteachCaseQuantitySenateItemsENS.senateGaugeItemDesc; //量表指标说明
objvMicroteachCaseQuantitySenateItemsENT.senateGaugeItemMemo = objvMicroteachCaseQuantitySenateItemsENS.senateGaugeItemMemo; //备注
objvMicroteachCaseQuantitySenateItemsENT.senateGaugeItemWeight = objvMicroteachCaseQuantitySenateItemsENS.senateGaugeItemWeight; //量表指标权重
objvMicroteachCaseQuantitySenateItemsENT.SenateScore = objvMicroteachCaseQuantitySenateItemsENS.SenateScore; //指标得分
objvMicroteachCaseQuantitySenateItemsENT.id_SenateGaugeSubItem = objvMicroteachCaseQuantitySenateItemsENS.id_SenateGaugeSubItem; //量表指标子项流水号
objvMicroteachCaseQuantitySenateItemsENT.senateGaugeSubItemID = objvMicroteachCaseQuantitySenateItemsENS.senateGaugeSubItemID; //量表指标子项ID
objvMicroteachCaseQuantitySenateItemsENT.senateGaugeSubItemName = objvMicroteachCaseQuantitySenateItemsENS.senateGaugeSubItemName; //量表指标子项名称
objvMicroteachCaseQuantitySenateItemsENT.senateGaugeSubItemDesc = objvMicroteachCaseQuantitySenateItemsENS.senateGaugeSubItemDesc; //量表指标子项说明
objvMicroteachCaseQuantitySenateItemsENT.senateGaugeSubItemMemo = objvMicroteachCaseQuantitySenateItemsENS.senateGaugeSubItemMemo; //量表指标子项备注
objvMicroteachCaseQuantitySenateItemsENT.senateGaugeSubItemScore = objvMicroteachCaseQuantitySenateItemsENS.senateGaugeSubItemScore; //量表指标子项分数
objvMicroteachCaseQuantitySenateItemsENT.UserId = objvMicroteachCaseQuantitySenateItemsENS.UserId; //用户ID
objvMicroteachCaseQuantitySenateItemsENT.UserName = objvMicroteachCaseQuantitySenateItemsENS.UserName; //用户名
objvMicroteachCaseQuantitySenateItemsENT.CollegeID = objvMicroteachCaseQuantitySenateItemsENS.CollegeID; //学院ID
objvMicroteachCaseQuantitySenateItemsENT.CollegeName = objvMicroteachCaseQuantitySenateItemsENS.CollegeName; //学院名称
objvMicroteachCaseQuantitySenateItemsENT.SenateTheme = objvMicroteachCaseQuantitySenateItemsENS.SenateTheme; //量化评价主题
objvMicroteachCaseQuantitySenateItemsENT.SenateContent = objvMicroteachCaseQuantitySenateItemsENS.SenateContent; //评价内容
objvMicroteachCaseQuantitySenateItemsENT.SenateDate = objvMicroteachCaseQuantitySenateItemsENS.SenateDate; //评价日期
objvMicroteachCaseQuantitySenateItemsENT.SenateTime = objvMicroteachCaseQuantitySenateItemsENS.SenateTime; //评价时间
objvMicroteachCaseQuantitySenateItemsENT.SenateTotalScore = objvMicroteachCaseQuantitySenateItemsENS.SenateTotalScore; //评价分数
objvMicroteachCaseQuantitySenateItemsENT.AnswerModeId = objvMicroteachCaseQuantitySenateItemsENS.AnswerModeId; //答案模式Id
objvMicroteachCaseQuantitySenateItemsENT.AnswerTypeId = objvMicroteachCaseQuantitySenateItemsENS.AnswerTypeId; //答案类型ID
objvMicroteachCaseQuantitySenateItemsENT.GridTitle = objvMicroteachCaseQuantitySenateItemsENS.GridTitle; //表格标题
objvMicroteachCaseQuantitySenateItemsENT.QuestionIndex = objvMicroteachCaseQuantitySenateItemsENS.QuestionIndex; //题目序号
objvMicroteachCaseQuantitySenateItemsENT.QuestionNo = objvMicroteachCaseQuantitySenateItemsENS.QuestionNo; //题目编号
objvMicroteachCaseQuantitySenateItemsENT.QuestionTypeId = objvMicroteachCaseQuantitySenateItemsENS.QuestionTypeId; //题目类型Id
objvMicroteachCaseQuantitySenateItemsENT.AnswerModeName = objvMicroteachCaseQuantitySenateItemsENS.AnswerModeName; //答案模式名称
objvMicroteachCaseQuantitySenateItemsENT.AnswerNum = objvMicroteachCaseQuantitySenateItemsENS.AnswerNum; //答案数
objvMicroteachCaseQuantitySenateItemsENT.AnswerTypeName = objvMicroteachCaseQuantitySenateItemsENS.AnswerTypeName; //答案类型名
objvMicroteachCaseQuantitySenateItemsENT.QuestionTypeName = objvMicroteachCaseQuantitySenateItemsENS.QuestionTypeName; //题目类型名
objvMicroteachCaseQuantitySenateItemsENT.senateGaugeVersionID = objvMicroteachCaseQuantitySenateItemsENS.senateGaugeVersionID; //评价量表版本ID
objvMicroteachCaseQuantitySenateItemsENT.senateGaugeVersionName = objvMicroteachCaseQuantitySenateItemsENS.senateGaugeVersionName; //评价量表版本名称
objvMicroteachCaseQuantitySenateItemsENT.senateGaugeVersionTtlScore = objvMicroteachCaseQuantitySenateItemsENS.senateGaugeVersionTtlScore; //评价量表版本总分
objvMicroteachCaseQuantitySenateItemsENT.id_SenateGaugeVersion = objvMicroteachCaseQuantitySenateItemsENS.id_SenateGaugeVersion; //评价量表版本流水号
objvMicroteachCaseQuantitySenateItemsENT.AnswerIndex = objvMicroteachCaseQuantitySenateItemsENS.AnswerIndex; //问答序号
objvMicroteachCaseQuantitySenateItemsENT.AnswerTitle = objvMicroteachCaseQuantitySenateItemsENS.AnswerTitle; //答案标题
objvMicroteachCaseQuantitySenateItemsENT.OwnerId = objvMicroteachCaseQuantitySenateItemsENS.OwnerId; //拥有者Id
objvMicroteachCaseQuantitySenateItemsENT.OwnerName = objvMicroteachCaseQuantitySenateItemsENS.OwnerName; //拥有者姓名
objvMicroteachCaseQuantitySenateItemsENT.OwnerNameWithId = objvMicroteachCaseQuantitySenateItemsENS.OwnerNameWithId; //拥有者名称附Id
objvMicroteachCaseQuantitySenateItemsENT.SenateIp = objvMicroteachCaseQuantitySenateItemsENS.SenateIp; //评议Ip
objvMicroteachCaseQuantitySenateItemsENT.UserNameWithUserId = objvMicroteachCaseQuantitySenateItemsENS.UserNameWithUserId; //UserNameWithUserId
objvMicroteachCaseQuantitySenateItemsENT.UserTypeId = objvMicroteachCaseQuantitySenateItemsENS.UserTypeId; //用户类型Id
objvMicroteachCaseQuantitySenateItemsENT.IsAccess = objvMicroteachCaseQuantitySenateItemsENS.IsAccess; //IsAccess
objvMicroteachCaseQuantitySenateItemsENT.IsAccessC = objvMicroteachCaseQuantitySenateItemsENS.IsAccessC; //IsAccessC
objvMicroteachCaseQuantitySenateItemsENT.UpdDate = objvMicroteachCaseQuantitySenateItemsENS.UpdDate; //修改日期
objvMicroteachCaseQuantitySenateItemsENT.UpdUser = objvMicroteachCaseQuantitySenateItemsENS.UpdUser; //修改人
objvMicroteachCaseQuantitySenateItemsENT.id_AppraiseType = objvMicroteachCaseQuantitySenateItemsENS.id_AppraiseType; //评议类型流水号
objvMicroteachCaseQuantitySenateItemsENT.AppraiseTypeName = objvMicroteachCaseQuantitySenateItemsENS.AppraiseTypeName; //评议类型名称
objvMicroteachCaseQuantitySenateItemsENT.FuncModuleId = objvMicroteachCaseQuantitySenateItemsENS.FuncModuleId; //功能模块Id
objvMicroteachCaseQuantitySenateItemsENT.UserKindId = objvMicroteachCaseQuantitySenateItemsENS.UserKindId; //用户类别Id
objvMicroteachCaseQuantitySenateItemsENT.UserKindName = objvMicroteachCaseQuantitySenateItemsENS.UserKindName; //用户类别名
objvMicroteachCaseQuantitySenateItemsENT.UserTypeName = objvMicroteachCaseQuantitySenateItemsENS.UserTypeName; //用户类型名称
objvMicroteachCaseQuantitySenateItemsENT.FuncModuleName = objvMicroteachCaseQuantitySenateItemsENS.FuncModuleName; //功能模块名称
objvMicroteachCaseQuantitySenateItemsENT.id_XzCollege = objvMicroteachCaseQuantitySenateItemsENS.id_XzCollege; //学院流水号
objvMicroteachCaseQuantitySenateItemsENT.CollegeNameA = objvMicroteachCaseQuantitySenateItemsENS.CollegeNameA; //学院名称简写
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
public static DataTable ToDataTable(List<clsvMicroteachCaseQuantitySenateItemsEN> arrObj)
{
DataTable dataTable = new DataTable(); //实例化
DataTable result;
if (arrObj.Count == 0) return null;
if (clsvMicroteachCaseQuantitySenateItemsEN.AttributeName.Length == 0)
{
result = dataTable;
return result;
}
Type type = typeof(clsvMicroteachCaseQuantitySenateItemsEN);
PropertyInfo[] arrPropertyInfo = type.GetProperties();
try
{
//Columns
foreach (string strAttrName in clsvMicroteachCaseQuantitySenateItemsEN.AttributeName)
{
PropertyInfo proprety_Curr = arrPropertyInfo.Where(x => x.Name == strAttrName).First();
dataTable.Columns.Add(strAttrName, proprety_Curr.PropertyType);
}
foreach (clsvMicroteachCaseQuantitySenateItemsEN objInFor in arrObj)
{
//Rows
DataRow dataRow = dataTable.NewRow();
foreach (string strAttrName in clsvMicroteachCaseQuantitySenateItemsEN.AttributeName)
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
if (clsMicroteachCaseQuantitySenateItemsWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsMicroteachCaseQuantitySenateItemsWApi没有刷新缓存机制(clsMicroteachCaseQuantitySenateItemsWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsTeacherInfoWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsTeacherInfoWApi没有刷新缓存机制(clsTeacherInfoWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsFuncModuleWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsFuncModuleWApi没有刷新缓存机制(clsFuncModuleWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsSenateGaugeVersionWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsSenateGaugeVersionWApi没有刷新缓存机制(clsSenateGaugeVersionWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsAppraiseTypeWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsAppraiseTypeWApi没有刷新缓存机制(clsAppraiseTypeWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsMicroteachCaseQuantitySenateWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsMicroteachCaseQuantitySenateWApi没有刷新缓存机制(clsMicroteachCaseQuantitySenateWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
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
if (clsSenateGaugeItemsWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsSenateGaugeItemsWApi没有刷新缓存机制(clsSenateGaugeItemsWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsUsersWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsUsersWApi没有刷新缓存机制(clsUsersWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsUserStateWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsUserStateWApi没有刷新缓存机制(clsUserStateWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsXzClgWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsXzClgWApi没有刷新缓存机制(clsXzClgWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsXzMajorWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsXzMajorWApi没有刷新缓存机制(clsXzMajorWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsXzGradeBaseWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsXzGradeBaseWApi没有刷新缓存机制(clsXzGradeBaseWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsUserIdentityWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsUserIdentityWApi没有刷新缓存机制(clsUserIdentityWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsStudyLevelWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsStudyLevelWApi没有刷新缓存机制(clsStudyLevelWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsRecommendedDegreeWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsRecommendedDegreeWApi没有刷新缓存机制(clsRecommendedDegreeWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsCaseLevelWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsCaseLevelWApi没有刷新缓存机制(clsCaseLevelWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsUserTypeWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsUserTypeWApi没有刷新缓存机制(clsUserTypeWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsDisciplineWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsDisciplineWApi没有刷新缓存机制(clsDisciplineWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsMicroteachCaseWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsMicroteachCaseWApi没有刷新缓存机制(clsMicroteachCaseWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsMicroteachCaseTypeWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsMicroteachCaseTypeWApi没有刷新缓存机制(clsMicroteachCaseTypeWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsUserKindWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsUserKindWApi没有刷新缓存机制(clsUserKindWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsSkillTypeWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsSkillTypeWApi没有刷新缓存机制(clsSkillTypeWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsTeachSkillWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsTeachSkillWApi没有刷新缓存机制(clsTeachSkillWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by id_microteachCaseQuantitySenateItem");
//if (arrvMicroteachCaseQuantitySenateItemsObjLst_Cache == null)
//{
//arrvMicroteachCaseQuantitySenateItemsObjLst_Cache = await clsvMicroteachCaseQuantitySenateItemsWApi.GetObjLst(strWhereCond);
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
string strKey = string.Format("{0}", clsvMicroteachCaseQuantitySenateItemsEN._CurrTabName_S);
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
public static List<clsvMicroteachCaseQuantitySenateItemsEN> GetObjLst_Cache()
{
//初始化列表缓存
InitListCache(); 
string strKey = string.Format("{0}", clsvMicroteachCaseQuantitySenateItemsEN._CurrTabName_S);
List<clsvMicroteachCaseQuantitySenateItemsEN> arrvMicroteachCaseQuantitySenateItemsObjLst_Cache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrvMicroteachCaseQuantitySenateItemsObjLst_Cache;
}

 /// <summary>
 /// 根据对象列表获取DataTable
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetDataTableByObjLst)
 /// </summary>
 /// <param name = "arrObjLst">给定的对象列表</param>
 /// <returns>返回DataTable</returns>
public static DataTable GetDataTableByObjLst(List<clsvMicroteachCaseQuantitySenateItemsEN> arrObjLst)
{
DataTable objDT = new DataTable();
objDT.Columns.Add(convMicroteachCaseQuantitySenateItems.id_microteachCaseQuantitySenateItem, Type.GetType("System.Int64"));
objDT.Columns.Add(convMicroteachCaseQuantitySenateItems.id_microteachCaseQuantitySenate, Type.GetType("System.Int64"));
objDT.Columns.Add(convMicroteachCaseQuantitySenateItems.id_MicroteachCase, Type.GetType("System.String"));
objDT.Columns.Add(convMicroteachCaseQuantitySenateItems.MicroteachCaseID, Type.GetType("System.String"));
objDT.Columns.Add(convMicroteachCaseQuantitySenateItems.MicroteachCaseName, Type.GetType("System.String"));
objDT.Columns.Add(convMicroteachCaseQuantitySenateItems.id_SenateGaugeItem, Type.GetType("System.String"));
objDT.Columns.Add(convMicroteachCaseQuantitySenateItems.senateGaugeItemID, Type.GetType("System.String"));
objDT.Columns.Add(convMicroteachCaseQuantitySenateItems.senateGaugeItemName, Type.GetType("System.String"));
objDT.Columns.Add(convMicroteachCaseQuantitySenateItems.senateGaugeItemNameWithOrder, Type.GetType("System.String"));
objDT.Columns.Add(convMicroteachCaseQuantitySenateItems.senateGaugeItemDesc, Type.GetType("System.String"));
objDT.Columns.Add(convMicroteachCaseQuantitySenateItems.senateGaugeItemMemo, Type.GetType("System.String"));
objDT.Columns.Add(convMicroteachCaseQuantitySenateItems.senateGaugeItemWeight, Type.GetType("System.Single"));
objDT.Columns.Add(convMicroteachCaseQuantitySenateItems.SenateScore, Type.GetType("System.Single"));
objDT.Columns.Add(convMicroteachCaseQuantitySenateItems.id_SenateGaugeSubItem, Type.GetType("System.String"));
objDT.Columns.Add(convMicroteachCaseQuantitySenateItems.senateGaugeSubItemID, Type.GetType("System.String"));
objDT.Columns.Add(convMicroteachCaseQuantitySenateItems.senateGaugeSubItemName, Type.GetType("System.String"));
objDT.Columns.Add(convMicroteachCaseQuantitySenateItems.senateGaugeSubItemDesc, Type.GetType("System.String"));
objDT.Columns.Add(convMicroteachCaseQuantitySenateItems.senateGaugeSubItemMemo, Type.GetType("System.String"));
objDT.Columns.Add(convMicroteachCaseQuantitySenateItems.senateGaugeSubItemScore, Type.GetType("System.Single"));
objDT.Columns.Add(convMicroteachCaseQuantitySenateItems.UserId, Type.GetType("System.String"));
objDT.Columns.Add(convMicroteachCaseQuantitySenateItems.UserName, Type.GetType("System.String"));
objDT.Columns.Add(convMicroteachCaseQuantitySenateItems.CollegeID, Type.GetType("System.String"));
objDT.Columns.Add(convMicroteachCaseQuantitySenateItems.CollegeName, Type.GetType("System.String"));
objDT.Columns.Add(convMicroteachCaseQuantitySenateItems.SenateTheme, Type.GetType("System.String"));
objDT.Columns.Add(convMicroteachCaseQuantitySenateItems.SenateContent, Type.GetType("System.String"));
objDT.Columns.Add(convMicroteachCaseQuantitySenateItems.SenateDate, Type.GetType("System.String"));
objDT.Columns.Add(convMicroteachCaseQuantitySenateItems.SenateTime, Type.GetType("System.String"));
objDT.Columns.Add(convMicroteachCaseQuantitySenateItems.SenateTotalScore, Type.GetType("System.Single"));
objDT.Columns.Add(convMicroteachCaseQuantitySenateItems.AnswerModeId, Type.GetType("System.String"));
objDT.Columns.Add(convMicroteachCaseQuantitySenateItems.AnswerTypeId, Type.GetType("System.String"));
objDT.Columns.Add(convMicroteachCaseQuantitySenateItems.GridTitle, Type.GetType("System.String"));
objDT.Columns.Add(convMicroteachCaseQuantitySenateItems.QuestionIndex, Type.GetType("System.Int32"));
objDT.Columns.Add(convMicroteachCaseQuantitySenateItems.QuestionNo, Type.GetType("System.String"));
objDT.Columns.Add(convMicroteachCaseQuantitySenateItems.QuestionTypeId, Type.GetType("System.String"));
objDT.Columns.Add(convMicroteachCaseQuantitySenateItems.AnswerModeName, Type.GetType("System.String"));
objDT.Columns.Add(convMicroteachCaseQuantitySenateItems.AnswerNum, Type.GetType("System.Int32"));
objDT.Columns.Add(convMicroteachCaseQuantitySenateItems.AnswerTypeName, Type.GetType("System.String"));
objDT.Columns.Add(convMicroteachCaseQuantitySenateItems.QuestionTypeName, Type.GetType("System.String"));
objDT.Columns.Add(convMicroteachCaseQuantitySenateItems.senateGaugeVersionID, Type.GetType("System.String"));
objDT.Columns.Add(convMicroteachCaseQuantitySenateItems.senateGaugeVersionName, Type.GetType("System.String"));
objDT.Columns.Add(convMicroteachCaseQuantitySenateItems.senateGaugeVersionTtlScore, Type.GetType("System.Single"));
objDT.Columns.Add(convMicroteachCaseQuantitySenateItems.id_SenateGaugeVersion, Type.GetType("System.String"));
objDT.Columns.Add(convMicroteachCaseQuantitySenateItems.AnswerIndex, Type.GetType("System.Int32"));
objDT.Columns.Add(convMicroteachCaseQuantitySenateItems.AnswerTitle, Type.GetType("System.String"));
objDT.Columns.Add(convMicroteachCaseQuantitySenateItems.OwnerId, Type.GetType("System.String"));
objDT.Columns.Add(convMicroteachCaseQuantitySenateItems.OwnerName, Type.GetType("System.String"));
objDT.Columns.Add(convMicroteachCaseQuantitySenateItems.OwnerNameWithId, Type.GetType("System.String"));
objDT.Columns.Add(convMicroteachCaseQuantitySenateItems.SenateIp, Type.GetType("System.String"));
objDT.Columns.Add(convMicroteachCaseQuantitySenateItems.UserNameWithUserId, Type.GetType("System.String"));
objDT.Columns.Add(convMicroteachCaseQuantitySenateItems.UserTypeId, Type.GetType("System.String"));
objDT.Columns.Add(convMicroteachCaseQuantitySenateItems.IsAccess, Type.GetType("System.Boolean"));
objDT.Columns.Add(convMicroteachCaseQuantitySenateItems.IsAccessC, Type.GetType("System.Boolean"));
objDT.Columns.Add(convMicroteachCaseQuantitySenateItems.UpdDate, Type.GetType("System.String"));
objDT.Columns.Add(convMicroteachCaseQuantitySenateItems.UpdUser, Type.GetType("System.String"));
objDT.Columns.Add(convMicroteachCaseQuantitySenateItems.id_AppraiseType, Type.GetType("System.String"));
objDT.Columns.Add(convMicroteachCaseQuantitySenateItems.AppraiseTypeName, Type.GetType("System.String"));
objDT.Columns.Add(convMicroteachCaseQuantitySenateItems.FuncModuleId, Type.GetType("System.String"));
objDT.Columns.Add(convMicroteachCaseQuantitySenateItems.UserKindId, Type.GetType("System.String"));
objDT.Columns.Add(convMicroteachCaseQuantitySenateItems.UserKindName, Type.GetType("System.String"));
objDT.Columns.Add(convMicroteachCaseQuantitySenateItems.UserTypeName, Type.GetType("System.String"));
objDT.Columns.Add(convMicroteachCaseQuantitySenateItems.FuncModuleName, Type.GetType("System.String"));
objDT.Columns.Add(convMicroteachCaseQuantitySenateItems.id_XzCollege, Type.GetType("System.String"));
objDT.Columns.Add(convMicroteachCaseQuantitySenateItems.CollegeNameA, Type.GetType("System.String"));
foreach (clsvMicroteachCaseQuantitySenateItemsEN objInFor in arrObjLst)
{
DataRow objDR = objDT.NewRow();
objDR[convMicroteachCaseQuantitySenateItems.id_microteachCaseQuantitySenateItem] = objInFor[convMicroteachCaseQuantitySenateItems.id_microteachCaseQuantitySenateItem];
objDR[convMicroteachCaseQuantitySenateItems.id_microteachCaseQuantitySenate] = objInFor[convMicroteachCaseQuantitySenateItems.id_microteachCaseQuantitySenate];
objDR[convMicroteachCaseQuantitySenateItems.id_MicroteachCase] = objInFor[convMicroteachCaseQuantitySenateItems.id_MicroteachCase];
objDR[convMicroteachCaseQuantitySenateItems.MicroteachCaseID] = objInFor[convMicroteachCaseQuantitySenateItems.MicroteachCaseID];
objDR[convMicroteachCaseQuantitySenateItems.MicroteachCaseName] = objInFor[convMicroteachCaseQuantitySenateItems.MicroteachCaseName];
objDR[convMicroteachCaseQuantitySenateItems.id_SenateGaugeItem] = objInFor[convMicroteachCaseQuantitySenateItems.id_SenateGaugeItem];
objDR[convMicroteachCaseQuantitySenateItems.senateGaugeItemID] = objInFor[convMicroteachCaseQuantitySenateItems.senateGaugeItemID];
objDR[convMicroteachCaseQuantitySenateItems.senateGaugeItemName] = objInFor[convMicroteachCaseQuantitySenateItems.senateGaugeItemName];
objDR[convMicroteachCaseQuantitySenateItems.senateGaugeItemNameWithOrder] = objInFor[convMicroteachCaseQuantitySenateItems.senateGaugeItemNameWithOrder];
objDR[convMicroteachCaseQuantitySenateItems.senateGaugeItemDesc] = objInFor[convMicroteachCaseQuantitySenateItems.senateGaugeItemDesc];
objDR[convMicroteachCaseQuantitySenateItems.senateGaugeItemMemo] = objInFor[convMicroteachCaseQuantitySenateItems.senateGaugeItemMemo];
objDR[convMicroteachCaseQuantitySenateItems.senateGaugeItemWeight] = objInFor[convMicroteachCaseQuantitySenateItems.senateGaugeItemWeight];
objDR[convMicroteachCaseQuantitySenateItems.SenateScore] = objInFor[convMicroteachCaseQuantitySenateItems.SenateScore];
objDR[convMicroteachCaseQuantitySenateItems.id_SenateGaugeSubItem] = objInFor[convMicroteachCaseQuantitySenateItems.id_SenateGaugeSubItem];
objDR[convMicroteachCaseQuantitySenateItems.senateGaugeSubItemID] = objInFor[convMicroteachCaseQuantitySenateItems.senateGaugeSubItemID];
objDR[convMicroteachCaseQuantitySenateItems.senateGaugeSubItemName] = objInFor[convMicroteachCaseQuantitySenateItems.senateGaugeSubItemName];
objDR[convMicroteachCaseQuantitySenateItems.senateGaugeSubItemDesc] = objInFor[convMicroteachCaseQuantitySenateItems.senateGaugeSubItemDesc];
objDR[convMicroteachCaseQuantitySenateItems.senateGaugeSubItemMemo] = objInFor[convMicroteachCaseQuantitySenateItems.senateGaugeSubItemMemo];
objDR[convMicroteachCaseQuantitySenateItems.senateGaugeSubItemScore] = objInFor[convMicroteachCaseQuantitySenateItems.senateGaugeSubItemScore];
objDR[convMicroteachCaseQuantitySenateItems.UserId] = objInFor[convMicroteachCaseQuantitySenateItems.UserId];
objDR[convMicroteachCaseQuantitySenateItems.UserName] = objInFor[convMicroteachCaseQuantitySenateItems.UserName];
objDR[convMicroteachCaseQuantitySenateItems.CollegeID] = objInFor[convMicroteachCaseQuantitySenateItems.CollegeID];
objDR[convMicroteachCaseQuantitySenateItems.CollegeName] = objInFor[convMicroteachCaseQuantitySenateItems.CollegeName];
objDR[convMicroteachCaseQuantitySenateItems.SenateTheme] = objInFor[convMicroteachCaseQuantitySenateItems.SenateTheme];
objDR[convMicroteachCaseQuantitySenateItems.SenateContent] = objInFor[convMicroteachCaseQuantitySenateItems.SenateContent];
objDR[convMicroteachCaseQuantitySenateItems.SenateDate] = objInFor[convMicroteachCaseQuantitySenateItems.SenateDate];
objDR[convMicroteachCaseQuantitySenateItems.SenateTime] = objInFor[convMicroteachCaseQuantitySenateItems.SenateTime];
objDR[convMicroteachCaseQuantitySenateItems.SenateTotalScore] = objInFor[convMicroteachCaseQuantitySenateItems.SenateTotalScore];
objDR[convMicroteachCaseQuantitySenateItems.AnswerModeId] = objInFor[convMicroteachCaseQuantitySenateItems.AnswerModeId];
objDR[convMicroteachCaseQuantitySenateItems.AnswerTypeId] = objInFor[convMicroteachCaseQuantitySenateItems.AnswerTypeId];
objDR[convMicroteachCaseQuantitySenateItems.GridTitle] = objInFor[convMicroteachCaseQuantitySenateItems.GridTitle];
objDR[convMicroteachCaseQuantitySenateItems.QuestionIndex] = objInFor[convMicroteachCaseQuantitySenateItems.QuestionIndex];
objDR[convMicroteachCaseQuantitySenateItems.QuestionNo] = objInFor[convMicroteachCaseQuantitySenateItems.QuestionNo];
objDR[convMicroteachCaseQuantitySenateItems.QuestionTypeId] = objInFor[convMicroteachCaseQuantitySenateItems.QuestionTypeId];
objDR[convMicroteachCaseQuantitySenateItems.AnswerModeName] = objInFor[convMicroteachCaseQuantitySenateItems.AnswerModeName];
objDR[convMicroteachCaseQuantitySenateItems.AnswerNum] = objInFor[convMicroteachCaseQuantitySenateItems.AnswerNum];
objDR[convMicroteachCaseQuantitySenateItems.AnswerTypeName] = objInFor[convMicroteachCaseQuantitySenateItems.AnswerTypeName];
objDR[convMicroteachCaseQuantitySenateItems.QuestionTypeName] = objInFor[convMicroteachCaseQuantitySenateItems.QuestionTypeName];
objDR[convMicroteachCaseQuantitySenateItems.senateGaugeVersionID] = objInFor[convMicroteachCaseQuantitySenateItems.senateGaugeVersionID];
objDR[convMicroteachCaseQuantitySenateItems.senateGaugeVersionName] = objInFor[convMicroteachCaseQuantitySenateItems.senateGaugeVersionName];
objDR[convMicroteachCaseQuantitySenateItems.senateGaugeVersionTtlScore] = objInFor[convMicroteachCaseQuantitySenateItems.senateGaugeVersionTtlScore];
objDR[convMicroteachCaseQuantitySenateItems.id_SenateGaugeVersion] = objInFor[convMicroteachCaseQuantitySenateItems.id_SenateGaugeVersion];
objDR[convMicroteachCaseQuantitySenateItems.AnswerIndex] = objInFor[convMicroteachCaseQuantitySenateItems.AnswerIndex];
objDR[convMicroteachCaseQuantitySenateItems.AnswerTitle] = objInFor[convMicroteachCaseQuantitySenateItems.AnswerTitle];
objDR[convMicroteachCaseQuantitySenateItems.OwnerId] = objInFor[convMicroteachCaseQuantitySenateItems.OwnerId];
objDR[convMicroteachCaseQuantitySenateItems.OwnerName] = objInFor[convMicroteachCaseQuantitySenateItems.OwnerName];
objDR[convMicroteachCaseQuantitySenateItems.OwnerNameWithId] = objInFor[convMicroteachCaseQuantitySenateItems.OwnerNameWithId];
objDR[convMicroteachCaseQuantitySenateItems.SenateIp] = objInFor[convMicroteachCaseQuantitySenateItems.SenateIp];
objDR[convMicroteachCaseQuantitySenateItems.UserNameWithUserId] = objInFor[convMicroteachCaseQuantitySenateItems.UserNameWithUserId];
objDR[convMicroteachCaseQuantitySenateItems.UserTypeId] = objInFor[convMicroteachCaseQuantitySenateItems.UserTypeId];
objDR[convMicroteachCaseQuantitySenateItems.IsAccess] = objInFor[convMicroteachCaseQuantitySenateItems.IsAccess];
objDR[convMicroteachCaseQuantitySenateItems.IsAccessC] = objInFor[convMicroteachCaseQuantitySenateItems.IsAccessC];
objDR[convMicroteachCaseQuantitySenateItems.UpdDate] = objInFor[convMicroteachCaseQuantitySenateItems.UpdDate];
objDR[convMicroteachCaseQuantitySenateItems.UpdUser] = objInFor[convMicroteachCaseQuantitySenateItems.UpdUser];
objDR[convMicroteachCaseQuantitySenateItems.id_AppraiseType] = objInFor[convMicroteachCaseQuantitySenateItems.id_AppraiseType];
objDR[convMicroteachCaseQuantitySenateItems.AppraiseTypeName] = objInFor[convMicroteachCaseQuantitySenateItems.AppraiseTypeName];
objDR[convMicroteachCaseQuantitySenateItems.FuncModuleId] = objInFor[convMicroteachCaseQuantitySenateItems.FuncModuleId];
objDR[convMicroteachCaseQuantitySenateItems.UserKindId] = objInFor[convMicroteachCaseQuantitySenateItems.UserKindId];
objDR[convMicroteachCaseQuantitySenateItems.UserKindName] = objInFor[convMicroteachCaseQuantitySenateItems.UserKindName];
objDR[convMicroteachCaseQuantitySenateItems.UserTypeName] = objInFor[convMicroteachCaseQuantitySenateItems.UserTypeName];
objDR[convMicroteachCaseQuantitySenateItems.FuncModuleName] = objInFor[convMicroteachCaseQuantitySenateItems.FuncModuleName];
objDR[convMicroteachCaseQuantitySenateItems.id_XzCollege] = objInFor[convMicroteachCaseQuantitySenateItems.id_XzCollege];
objDR[convMicroteachCaseQuantitySenateItems.CollegeNameA] = objInFor[convMicroteachCaseQuantitySenateItems.CollegeNameA];
objDT.Rows.Add(objDR);
}
return objDT;
}
}
}