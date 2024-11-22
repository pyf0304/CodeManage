
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvMicroteachCaseQuantitySenateItemsBL
 表名:vMicroteachCaseQuantitySenateItems(01120493)
 * 版本:2023.08.23.1(服务器:WIN-SRV103-116)
 日期:2023/08/24 14:47:55
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:公共后台所有表(变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:微格教学评议(MicroTeachSenate)
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
public static class  clsvMicroteachCaseQuantitySenateItemsBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "lngIdmicroteachCaseQuantitySenateItem">表关键字</param>
 /// <returns>表对象</returns>
public static clsvMicroteachCaseQuantitySenateItemsEN GetObj(this K_IdmicroteachCaseQuantitySenateItem_vMicroteachCaseQuantitySenateItems myKey)
{
clsvMicroteachCaseQuantitySenateItemsEN objvMicroteachCaseQuantitySenateItemsEN = clsvMicroteachCaseQuantitySenateItemsBL.vMicroteachCaseQuantitySenateItemsDA.GetObjByIdmicroteachCaseQuantitySenateItem(myKey.Value);
return objvMicroteachCaseQuantitySenateItemsEN;
}

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCaseQuantitySenateItemsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroteachCaseQuantitySenateItemsEN SetIdmicroteachCaseQuantitySenateItem(this clsvMicroteachCaseQuantitySenateItemsEN objvMicroteachCaseQuantitySenateItemsEN, long lngIdmicroteachCaseQuantitySenateItem, string strComparisonOp="")
	{
objvMicroteachCaseQuantitySenateItemsEN.IdmicroteachCaseQuantitySenateItem = lngIdmicroteachCaseQuantitySenateItem; //微格量化评价指标流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCaseQuantitySenateItemsEN.dicFldComparisonOp.ContainsKey(convMicroteachCaseQuantitySenateItems.IdmicroteachCaseQuantitySenateItem) == false)
{
objvMicroteachCaseQuantitySenateItemsEN.dicFldComparisonOp.Add(convMicroteachCaseQuantitySenateItems.IdmicroteachCaseQuantitySenateItem, strComparisonOp);
}
else
{
objvMicroteachCaseQuantitySenateItemsEN.dicFldComparisonOp[convMicroteachCaseQuantitySenateItems.IdmicroteachCaseQuantitySenateItem] = strComparisonOp;
}
}
return objvMicroteachCaseQuantitySenateItemsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCaseQuantitySenateItemsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroteachCaseQuantitySenateItemsEN SetIdmicroteachCaseQuantitySenate(this clsvMicroteachCaseQuantitySenateItemsEN objvMicroteachCaseQuantitySenateItemsEN, long lngIdmicroteachCaseQuantitySenate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(lngIdmicroteachCaseQuantitySenate, convMicroteachCaseQuantitySenateItems.IdmicroteachCaseQuantitySenate);
objvMicroteachCaseQuantitySenateItemsEN.IdmicroteachCaseQuantitySenate = lngIdmicroteachCaseQuantitySenate; //微格量化评价流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCaseQuantitySenateItemsEN.dicFldComparisonOp.ContainsKey(convMicroteachCaseQuantitySenateItems.IdmicroteachCaseQuantitySenate) == false)
{
objvMicroteachCaseQuantitySenateItemsEN.dicFldComparisonOp.Add(convMicroteachCaseQuantitySenateItems.IdmicroteachCaseQuantitySenate, strComparisonOp);
}
else
{
objvMicroteachCaseQuantitySenateItemsEN.dicFldComparisonOp[convMicroteachCaseQuantitySenateItems.IdmicroteachCaseQuantitySenate] = strComparisonOp;
}
}
return objvMicroteachCaseQuantitySenateItemsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCaseQuantitySenateItemsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroteachCaseQuantitySenateItemsEN SetIdMicroteachCase(this clsvMicroteachCaseQuantitySenateItemsEN objvMicroteachCaseQuantitySenateItemsEN, string strIdMicroteachCase, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strIdMicroteachCase, convMicroteachCaseQuantitySenateItems.IdMicroteachCase);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdMicroteachCase, 8, convMicroteachCaseQuantitySenateItems.IdMicroteachCase);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdMicroteachCase, 8, convMicroteachCaseQuantitySenateItems.IdMicroteachCase);
}
objvMicroteachCaseQuantitySenateItemsEN.IdMicroteachCase = strIdMicroteachCase; //微格教学案例流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCaseQuantitySenateItemsEN.dicFldComparisonOp.ContainsKey(convMicroteachCaseQuantitySenateItems.IdMicroteachCase) == false)
{
objvMicroteachCaseQuantitySenateItemsEN.dicFldComparisonOp.Add(convMicroteachCaseQuantitySenateItems.IdMicroteachCase, strComparisonOp);
}
else
{
objvMicroteachCaseQuantitySenateItemsEN.dicFldComparisonOp[convMicroteachCaseQuantitySenateItems.IdMicroteachCase] = strComparisonOp;
}
}
return objvMicroteachCaseQuantitySenateItemsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCaseQuantitySenateItemsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroteachCaseQuantitySenateItemsEN SetMicroteachCaseID(this clsvMicroteachCaseQuantitySenateItemsEN objvMicroteachCaseQuantitySenateItemsEN, string strMicroteachCaseID, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMicroteachCaseID, 8, convMicroteachCaseQuantitySenateItems.MicroteachCaseID);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strMicroteachCaseID, 8, convMicroteachCaseQuantitySenateItems.MicroteachCaseID);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCaseQuantitySenateItemsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroteachCaseQuantitySenateItemsEN SetMicroteachCaseName(this clsvMicroteachCaseQuantitySenateItemsEN objvMicroteachCaseQuantitySenateItemsEN, string strMicroteachCaseName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMicroteachCaseName, 100, convMicroteachCaseQuantitySenateItems.MicroteachCaseName);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCaseQuantitySenateItemsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroteachCaseQuantitySenateItemsEN SetIdSenateGaugeItem(this clsvMicroteachCaseQuantitySenateItemsEN objvMicroteachCaseQuantitySenateItemsEN, string strIdSenateGaugeItem, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strIdSenateGaugeItem, convMicroteachCaseQuantitySenateItems.IdSenateGaugeItem);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdSenateGaugeItem, 4, convMicroteachCaseQuantitySenateItems.IdSenateGaugeItem);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdSenateGaugeItem, 4, convMicroteachCaseQuantitySenateItems.IdSenateGaugeItem);
}
objvMicroteachCaseQuantitySenateItemsEN.IdSenateGaugeItem = strIdSenateGaugeItem; //量表指标流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCaseQuantitySenateItemsEN.dicFldComparisonOp.ContainsKey(convMicroteachCaseQuantitySenateItems.IdSenateGaugeItem) == false)
{
objvMicroteachCaseQuantitySenateItemsEN.dicFldComparisonOp.Add(convMicroteachCaseQuantitySenateItems.IdSenateGaugeItem, strComparisonOp);
}
else
{
objvMicroteachCaseQuantitySenateItemsEN.dicFldComparisonOp[convMicroteachCaseQuantitySenateItems.IdSenateGaugeItem] = strComparisonOp;
}
}
return objvMicroteachCaseQuantitySenateItemsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCaseQuantitySenateItemsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroteachCaseQuantitySenateItemsEN SetsenateGaugeItemID(this clsvMicroteachCaseQuantitySenateItemsEN objvMicroteachCaseQuantitySenateItemsEN, string strsenateGaugeItemID, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strsenateGaugeItemID, 4, convMicroteachCaseQuantitySenateItems.senateGaugeItemID);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strsenateGaugeItemID, 4, convMicroteachCaseQuantitySenateItems.senateGaugeItemID);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCaseQuantitySenateItemsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroteachCaseQuantitySenateItemsEN SetsenateGaugeItemName(this clsvMicroteachCaseQuantitySenateItemsEN objvMicroteachCaseQuantitySenateItemsEN, string strsenateGaugeItemName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strsenateGaugeItemName, 200, convMicroteachCaseQuantitySenateItems.senateGaugeItemName);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCaseQuantitySenateItemsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroteachCaseQuantitySenateItemsEN SetsenateGaugeItemNameWithOrder(this clsvMicroteachCaseQuantitySenateItemsEN objvMicroteachCaseQuantitySenateItemsEN, string strsenateGaugeItemNameWithOrder, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strsenateGaugeItemNameWithOrder, 204, convMicroteachCaseQuantitySenateItems.senateGaugeItemNameWithOrder);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCaseQuantitySenateItemsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroteachCaseQuantitySenateItemsEN SetsenateGaugeItemDesc(this clsvMicroteachCaseQuantitySenateItemsEN objvMicroteachCaseQuantitySenateItemsEN, string strsenateGaugeItemDesc, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strsenateGaugeItemDesc, 2000, convMicroteachCaseQuantitySenateItems.senateGaugeItemDesc);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCaseQuantitySenateItemsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroteachCaseQuantitySenateItemsEN SetsenateGaugeItemMemo(this clsvMicroteachCaseQuantitySenateItemsEN objvMicroteachCaseQuantitySenateItemsEN, string strsenateGaugeItemMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strsenateGaugeItemMemo, 1000, convMicroteachCaseQuantitySenateItems.senateGaugeItemMemo);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCaseQuantitySenateItemsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroteachCaseQuantitySenateItemsEN SetsenateGaugeItemWeight(this clsvMicroteachCaseQuantitySenateItemsEN objvMicroteachCaseQuantitySenateItemsEN, float? fltsenateGaugeItemWeight, string strComparisonOp="")
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCaseQuantitySenateItemsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroteachCaseQuantitySenateItemsEN SetSenateScore(this clsvMicroteachCaseQuantitySenateItemsEN objvMicroteachCaseQuantitySenateItemsEN, float? fltSenateScore, string strComparisonOp="")
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCaseQuantitySenateItemsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroteachCaseQuantitySenateItemsEN SetIdSenateGaugeSubItem(this clsvMicroteachCaseQuantitySenateItemsEN objvMicroteachCaseQuantitySenateItemsEN, string strIdSenateGaugeSubItem, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdSenateGaugeSubItem, 4, convMicroteachCaseQuantitySenateItems.IdSenateGaugeSubItem);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdSenateGaugeSubItem, 4, convMicroteachCaseQuantitySenateItems.IdSenateGaugeSubItem);
}
objvMicroteachCaseQuantitySenateItemsEN.IdSenateGaugeSubItem = strIdSenateGaugeSubItem; //量表指标子项流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCaseQuantitySenateItemsEN.dicFldComparisonOp.ContainsKey(convMicroteachCaseQuantitySenateItems.IdSenateGaugeSubItem) == false)
{
objvMicroteachCaseQuantitySenateItemsEN.dicFldComparisonOp.Add(convMicroteachCaseQuantitySenateItems.IdSenateGaugeSubItem, strComparisonOp);
}
else
{
objvMicroteachCaseQuantitySenateItemsEN.dicFldComparisonOp[convMicroteachCaseQuantitySenateItems.IdSenateGaugeSubItem] = strComparisonOp;
}
}
return objvMicroteachCaseQuantitySenateItemsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCaseQuantitySenateItemsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroteachCaseQuantitySenateItemsEN SetsenateGaugeSubItemID(this clsvMicroteachCaseQuantitySenateItemsEN objvMicroteachCaseQuantitySenateItemsEN, string strsenateGaugeSubItemID, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strsenateGaugeSubItemID, 4, convMicroteachCaseQuantitySenateItems.senateGaugeSubItemID);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strsenateGaugeSubItemID, 4, convMicroteachCaseQuantitySenateItems.senateGaugeSubItemID);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCaseQuantitySenateItemsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroteachCaseQuantitySenateItemsEN SetsenateGaugeSubItemName(this clsvMicroteachCaseQuantitySenateItemsEN objvMicroteachCaseQuantitySenateItemsEN, string strsenateGaugeSubItemName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strsenateGaugeSubItemName, 200, convMicroteachCaseQuantitySenateItems.senateGaugeSubItemName);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCaseQuantitySenateItemsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroteachCaseQuantitySenateItemsEN SetsenateGaugeSubItemDesc(this clsvMicroteachCaseQuantitySenateItemsEN objvMicroteachCaseQuantitySenateItemsEN, string strsenateGaugeSubItemDesc, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strsenateGaugeSubItemDesc, 2000, convMicroteachCaseQuantitySenateItems.senateGaugeSubItemDesc);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCaseQuantitySenateItemsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroteachCaseQuantitySenateItemsEN SetsenateGaugeSubItemMemo(this clsvMicroteachCaseQuantitySenateItemsEN objvMicroteachCaseQuantitySenateItemsEN, string strsenateGaugeSubItemMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strsenateGaugeSubItemMemo, 1000, convMicroteachCaseQuantitySenateItems.senateGaugeSubItemMemo);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCaseQuantitySenateItemsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroteachCaseQuantitySenateItemsEN SetsenateGaugeSubItemScore(this clsvMicroteachCaseQuantitySenateItemsEN objvMicroteachCaseQuantitySenateItemsEN, float? fltsenateGaugeSubItemScore, string strComparisonOp="")
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCaseQuantitySenateItemsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroteachCaseQuantitySenateItemsEN SetUserId(this clsvMicroteachCaseQuantitySenateItemsEN objvMicroteachCaseQuantitySenateItemsEN, string strUserId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUserId, 18, convMicroteachCaseQuantitySenateItems.UserId);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCaseQuantitySenateItemsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroteachCaseQuantitySenateItemsEN SetUserName(this clsvMicroteachCaseQuantitySenateItemsEN objvMicroteachCaseQuantitySenateItemsEN, string strUserName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUserName, 30, convMicroteachCaseQuantitySenateItems.UserName);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCaseQuantitySenateItemsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroteachCaseQuantitySenateItemsEN SetCollegeID(this clsvMicroteachCaseQuantitySenateItemsEN objvMicroteachCaseQuantitySenateItemsEN, string strCollegeID, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCollegeID, 4, convMicroteachCaseQuantitySenateItems.CollegeID);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCaseQuantitySenateItemsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroteachCaseQuantitySenateItemsEN SetCollegeName(this clsvMicroteachCaseQuantitySenateItemsEN objvMicroteachCaseQuantitySenateItemsEN, string strCollegeName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCollegeName, 100, convMicroteachCaseQuantitySenateItems.CollegeName);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCaseQuantitySenateItemsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroteachCaseQuantitySenateItemsEN SetSenateTheme(this clsvMicroteachCaseQuantitySenateItemsEN objvMicroteachCaseQuantitySenateItemsEN, string strSenateTheme, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strSenateTheme, 200, convMicroteachCaseQuantitySenateItems.SenateTheme);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCaseQuantitySenateItemsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroteachCaseQuantitySenateItemsEN SetSenateContent(this clsvMicroteachCaseQuantitySenateItemsEN objvMicroteachCaseQuantitySenateItemsEN, string strSenateContent, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strSenateContent, 2000, convMicroteachCaseQuantitySenateItems.SenateContent);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCaseQuantitySenateItemsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroteachCaseQuantitySenateItemsEN SetSenateDate(this clsvMicroteachCaseQuantitySenateItemsEN objvMicroteachCaseQuantitySenateItemsEN, string strSenateDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strSenateDate, 8, convMicroteachCaseQuantitySenateItems.SenateDate);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strSenateDate, 8, convMicroteachCaseQuantitySenateItems.SenateDate);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCaseQuantitySenateItemsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroteachCaseQuantitySenateItemsEN SetSenateTime(this clsvMicroteachCaseQuantitySenateItemsEN objvMicroteachCaseQuantitySenateItemsEN, string strSenateTime, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strSenateTime, 6, convMicroteachCaseQuantitySenateItems.SenateTime);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strSenateTime, 6, convMicroteachCaseQuantitySenateItems.SenateTime);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCaseQuantitySenateItemsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroteachCaseQuantitySenateItemsEN SetSenateTotalScore(this clsvMicroteachCaseQuantitySenateItemsEN objvMicroteachCaseQuantitySenateItemsEN, float? fltSenateTotalScore, string strComparisonOp="")
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCaseQuantitySenateItemsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroteachCaseQuantitySenateItemsEN SetAnswerModeId(this clsvMicroteachCaseQuantitySenateItemsEN objvMicroteachCaseQuantitySenateItemsEN, string strAnswerModeId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strAnswerModeId, 4, convMicroteachCaseQuantitySenateItems.AnswerModeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strAnswerModeId, 4, convMicroteachCaseQuantitySenateItems.AnswerModeId);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCaseQuantitySenateItemsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroteachCaseQuantitySenateItemsEN SetAnswerTypeId(this clsvMicroteachCaseQuantitySenateItemsEN objvMicroteachCaseQuantitySenateItemsEN, string strAnswerTypeId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strAnswerTypeId, 2, convMicroteachCaseQuantitySenateItems.AnswerTypeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strAnswerTypeId, 2, convMicroteachCaseQuantitySenateItems.AnswerTypeId);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCaseQuantitySenateItemsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroteachCaseQuantitySenateItemsEN SetGridTitle(this clsvMicroteachCaseQuantitySenateItemsEN objvMicroteachCaseQuantitySenateItemsEN, string strGridTitle, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strGridTitle, 30, convMicroteachCaseQuantitySenateItems.GridTitle);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCaseQuantitySenateItemsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroteachCaseQuantitySenateItemsEN SetQuestionIndex(this clsvMicroteachCaseQuantitySenateItemsEN objvMicroteachCaseQuantitySenateItemsEN, int? intQuestionIndex, string strComparisonOp="")
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCaseQuantitySenateItemsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroteachCaseQuantitySenateItemsEN SetQuestionNo(this clsvMicroteachCaseQuantitySenateItemsEN objvMicroteachCaseQuantitySenateItemsEN, string strQuestionNo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strQuestionNo, 10, convMicroteachCaseQuantitySenateItems.QuestionNo);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCaseQuantitySenateItemsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroteachCaseQuantitySenateItemsEN SetQuestionTypeId(this clsvMicroteachCaseQuantitySenateItemsEN objvMicroteachCaseQuantitySenateItemsEN, string strQuestionTypeId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strQuestionTypeId, 2, convMicroteachCaseQuantitySenateItems.QuestionTypeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strQuestionTypeId, 2, convMicroteachCaseQuantitySenateItems.QuestionTypeId);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCaseQuantitySenateItemsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroteachCaseQuantitySenateItemsEN SetAnswerModeName(this clsvMicroteachCaseQuantitySenateItemsEN objvMicroteachCaseQuantitySenateItemsEN, string strAnswerModeName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strAnswerModeName, 30, convMicroteachCaseQuantitySenateItems.AnswerModeName);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCaseQuantitySenateItemsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroteachCaseQuantitySenateItemsEN SetAnswerNum(this clsvMicroteachCaseQuantitySenateItemsEN objvMicroteachCaseQuantitySenateItemsEN, int? intAnswerNum, string strComparisonOp="")
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCaseQuantitySenateItemsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroteachCaseQuantitySenateItemsEN SetAnswerTypeName(this clsvMicroteachCaseQuantitySenateItemsEN objvMicroteachCaseQuantitySenateItemsEN, string strAnswerTypeName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strAnswerTypeName, 50, convMicroteachCaseQuantitySenateItems.AnswerTypeName);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCaseQuantitySenateItemsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroteachCaseQuantitySenateItemsEN SetQuestionTypeName(this clsvMicroteachCaseQuantitySenateItemsEN objvMicroteachCaseQuantitySenateItemsEN, string strQuestionTypeName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strQuestionTypeName, 20, convMicroteachCaseQuantitySenateItems.QuestionTypeName);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCaseQuantitySenateItemsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroteachCaseQuantitySenateItemsEN SetsenateGaugeVersionID(this clsvMicroteachCaseQuantitySenateItemsEN objvMicroteachCaseQuantitySenateItemsEN, string strsenateGaugeVersionID, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strsenateGaugeVersionID, 4, convMicroteachCaseQuantitySenateItems.senateGaugeVersionID);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strsenateGaugeVersionID, 4, convMicroteachCaseQuantitySenateItems.senateGaugeVersionID);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCaseQuantitySenateItemsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroteachCaseQuantitySenateItemsEN SetsenateGaugeVersionName(this clsvMicroteachCaseQuantitySenateItemsEN objvMicroteachCaseQuantitySenateItemsEN, string strsenateGaugeVersionName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strsenateGaugeVersionName, 200, convMicroteachCaseQuantitySenateItems.senateGaugeVersionName);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCaseQuantitySenateItemsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroteachCaseQuantitySenateItemsEN SetsenateGaugeVersionTtlScore(this clsvMicroteachCaseQuantitySenateItemsEN objvMicroteachCaseQuantitySenateItemsEN, float? fltsenateGaugeVersionTtlScore, string strComparisonOp="")
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCaseQuantitySenateItemsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroteachCaseQuantitySenateItemsEN SetIdSenateGaugeVersion(this clsvMicroteachCaseQuantitySenateItemsEN objvMicroteachCaseQuantitySenateItemsEN, string strIdSenateGaugeVersion, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strIdSenateGaugeVersion, convMicroteachCaseQuantitySenateItems.IdSenateGaugeVersion);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdSenateGaugeVersion, 4, convMicroteachCaseQuantitySenateItems.IdSenateGaugeVersion);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdSenateGaugeVersion, 4, convMicroteachCaseQuantitySenateItems.IdSenateGaugeVersion);
}
objvMicroteachCaseQuantitySenateItemsEN.IdSenateGaugeVersion = strIdSenateGaugeVersion; //评价量表版本流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCaseQuantitySenateItemsEN.dicFldComparisonOp.ContainsKey(convMicroteachCaseQuantitySenateItems.IdSenateGaugeVersion) == false)
{
objvMicroteachCaseQuantitySenateItemsEN.dicFldComparisonOp.Add(convMicroteachCaseQuantitySenateItems.IdSenateGaugeVersion, strComparisonOp);
}
else
{
objvMicroteachCaseQuantitySenateItemsEN.dicFldComparisonOp[convMicroteachCaseQuantitySenateItems.IdSenateGaugeVersion] = strComparisonOp;
}
}
return objvMicroteachCaseQuantitySenateItemsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCaseQuantitySenateItemsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroteachCaseQuantitySenateItemsEN SetAnswerIndex(this clsvMicroteachCaseQuantitySenateItemsEN objvMicroteachCaseQuantitySenateItemsEN, int? intAnswerIndex, string strComparisonOp="")
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCaseQuantitySenateItemsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroteachCaseQuantitySenateItemsEN SetAnswerTitle(this clsvMicroteachCaseQuantitySenateItemsEN objvMicroteachCaseQuantitySenateItemsEN, string strAnswerTitle, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strAnswerTitle, 20, convMicroteachCaseQuantitySenateItems.AnswerTitle);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCaseQuantitySenateItemsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroteachCaseQuantitySenateItemsEN SetOwnerId(this clsvMicroteachCaseQuantitySenateItemsEN objvMicroteachCaseQuantitySenateItemsEN, string strOwnerId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strOwnerId, 20, convMicroteachCaseQuantitySenateItems.OwnerId);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCaseQuantitySenateItemsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroteachCaseQuantitySenateItemsEN SetOwnerName(this clsvMicroteachCaseQuantitySenateItemsEN objvMicroteachCaseQuantitySenateItemsEN, string strOwnerName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strOwnerName, 30, convMicroteachCaseQuantitySenateItems.OwnerName);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCaseQuantitySenateItemsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroteachCaseQuantitySenateItemsEN SetOwnerNameWithId(this clsvMicroteachCaseQuantitySenateItemsEN objvMicroteachCaseQuantitySenateItemsEN, string strOwnerNameWithId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strOwnerNameWithId, 51, convMicroteachCaseQuantitySenateItems.OwnerNameWithId);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCaseQuantitySenateItemsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroteachCaseQuantitySenateItemsEN SetSenateIp(this clsvMicroteachCaseQuantitySenateItemsEN objvMicroteachCaseQuantitySenateItemsEN, string strSenateIp, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strSenateIp, 50, convMicroteachCaseQuantitySenateItems.SenateIp);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCaseQuantitySenateItemsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroteachCaseQuantitySenateItemsEN SetUserNameWithUserId(this clsvMicroteachCaseQuantitySenateItemsEN objvMicroteachCaseQuantitySenateItemsEN, string strUserNameWithUserId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUserNameWithUserId, 51, convMicroteachCaseQuantitySenateItems.UserNameWithUserId);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCaseQuantitySenateItemsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroteachCaseQuantitySenateItemsEN SetUserTypeId(this clsvMicroteachCaseQuantitySenateItemsEN objvMicroteachCaseQuantitySenateItemsEN, string strUserTypeId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUserTypeId, 2, convMicroteachCaseQuantitySenateItems.UserTypeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strUserTypeId, 2, convMicroteachCaseQuantitySenateItems.UserTypeId);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCaseQuantitySenateItemsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCaseQuantitySenateItemsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCaseQuantitySenateItemsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroteachCaseQuantitySenateItemsEN SetUpdDate(this clsvMicroteachCaseQuantitySenateItemsEN objvMicroteachCaseQuantitySenateItemsEN, string strUpdDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdDate, 20, convMicroteachCaseQuantitySenateItems.UpdDate);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCaseQuantitySenateItemsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroteachCaseQuantitySenateItemsEN SetUpdUser(this clsvMicroteachCaseQuantitySenateItemsEN objvMicroteachCaseQuantitySenateItemsEN, string strUpdUser, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdUser, 20, convMicroteachCaseQuantitySenateItems.UpdUser);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCaseQuantitySenateItemsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroteachCaseQuantitySenateItemsEN SetIdAppraiseType(this clsvMicroteachCaseQuantitySenateItemsEN objvMicroteachCaseQuantitySenateItemsEN, string strIdAppraiseType, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdAppraiseType, 4, convMicroteachCaseQuantitySenateItems.IdAppraiseType);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdAppraiseType, 4, convMicroteachCaseQuantitySenateItems.IdAppraiseType);
}
objvMicroteachCaseQuantitySenateItemsEN.IdAppraiseType = strIdAppraiseType; //评议类型流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCaseQuantitySenateItemsEN.dicFldComparisonOp.ContainsKey(convMicroteachCaseQuantitySenateItems.IdAppraiseType) == false)
{
objvMicroteachCaseQuantitySenateItemsEN.dicFldComparisonOp.Add(convMicroteachCaseQuantitySenateItems.IdAppraiseType, strComparisonOp);
}
else
{
objvMicroteachCaseQuantitySenateItemsEN.dicFldComparisonOp[convMicroteachCaseQuantitySenateItems.IdAppraiseType] = strComparisonOp;
}
}
return objvMicroteachCaseQuantitySenateItemsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCaseQuantitySenateItemsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroteachCaseQuantitySenateItemsEN SetAppraiseTypeName(this clsvMicroteachCaseQuantitySenateItemsEN objvMicroteachCaseQuantitySenateItemsEN, string strAppraiseTypeName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strAppraiseTypeName, 50, convMicroteachCaseQuantitySenateItems.AppraiseTypeName);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCaseQuantitySenateItemsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroteachCaseQuantitySenateItemsEN SetFuncModuleId(this clsvMicroteachCaseQuantitySenateItemsEN objvMicroteachCaseQuantitySenateItemsEN, string strFuncModuleId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFuncModuleId, 4, convMicroteachCaseQuantitySenateItems.FuncModuleId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strFuncModuleId, 4, convMicroteachCaseQuantitySenateItems.FuncModuleId);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCaseQuantitySenateItemsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroteachCaseQuantitySenateItemsEN SetUserKindId(this clsvMicroteachCaseQuantitySenateItemsEN objvMicroteachCaseQuantitySenateItemsEN, string strUserKindId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUserKindId, 2, convMicroteachCaseQuantitySenateItems.UserKindId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strUserKindId, 2, convMicroteachCaseQuantitySenateItems.UserKindId);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCaseQuantitySenateItemsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroteachCaseQuantitySenateItemsEN SetUserKindName(this clsvMicroteachCaseQuantitySenateItemsEN objvMicroteachCaseQuantitySenateItemsEN, string strUserKindName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUserKindName, 30, convMicroteachCaseQuantitySenateItems.UserKindName);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCaseQuantitySenateItemsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroteachCaseQuantitySenateItemsEN SetUserTypeName(this clsvMicroteachCaseQuantitySenateItemsEN objvMicroteachCaseQuantitySenateItemsEN, string strUserTypeName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUserTypeName, 20, convMicroteachCaseQuantitySenateItems.UserTypeName);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCaseQuantitySenateItemsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroteachCaseQuantitySenateItemsEN SetFuncModuleName(this clsvMicroteachCaseQuantitySenateItemsEN objvMicroteachCaseQuantitySenateItemsEN, string strFuncModuleName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFuncModuleName, 30, convMicroteachCaseQuantitySenateItems.FuncModuleName);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCaseQuantitySenateItemsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroteachCaseQuantitySenateItemsEN SetIdXzCollege(this clsvMicroteachCaseQuantitySenateItemsEN objvMicroteachCaseQuantitySenateItemsEN, string strIdXzCollege, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdXzCollege, 4, convMicroteachCaseQuantitySenateItems.IdXzCollege);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdXzCollege, 4, convMicroteachCaseQuantitySenateItems.IdXzCollege);
}
objvMicroteachCaseQuantitySenateItemsEN.IdXzCollege = strIdXzCollege; //学院流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMicroteachCaseQuantitySenateItemsEN.dicFldComparisonOp.ContainsKey(convMicroteachCaseQuantitySenateItems.IdXzCollege) == false)
{
objvMicroteachCaseQuantitySenateItemsEN.dicFldComparisonOp.Add(convMicroteachCaseQuantitySenateItems.IdXzCollege, strComparisonOp);
}
else
{
objvMicroteachCaseQuantitySenateItemsEN.dicFldComparisonOp[convMicroteachCaseQuantitySenateItems.IdXzCollege] = strComparisonOp;
}
}
return objvMicroteachCaseQuantitySenateItemsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMicroteachCaseQuantitySenateItemsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMicroteachCaseQuantitySenateItemsEN SetCollegeNameA(this clsvMicroteachCaseQuantitySenateItemsEN objvMicroteachCaseQuantitySenateItemsEN, string strCollegeNameA, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCollegeNameA, 12, convMicroteachCaseQuantitySenateItems.CollegeNameA);
}
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
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CopyObj)
 /// </summary>
 /// <param name = "objvMicroteachCaseQuantitySenateItemsENS">源对象</param>
 /// <param name = "objvMicroteachCaseQuantitySenateItemsENT">目标对象</param>
 public static void CopyTo(this clsvMicroteachCaseQuantitySenateItemsEN objvMicroteachCaseQuantitySenateItemsENS, clsvMicroteachCaseQuantitySenateItemsEN objvMicroteachCaseQuantitySenateItemsENT)
{
try
{
objvMicroteachCaseQuantitySenateItemsENT.IdmicroteachCaseQuantitySenateItem = objvMicroteachCaseQuantitySenateItemsENS.IdmicroteachCaseQuantitySenateItem; //微格量化评价指标流水号
objvMicroteachCaseQuantitySenateItemsENT.IdmicroteachCaseQuantitySenate = objvMicroteachCaseQuantitySenateItemsENS.IdmicroteachCaseQuantitySenate; //微格量化评价流水号
objvMicroteachCaseQuantitySenateItemsENT.IdMicroteachCase = objvMicroteachCaseQuantitySenateItemsENS.IdMicroteachCase; //微格教学案例流水号
objvMicroteachCaseQuantitySenateItemsENT.MicroteachCaseID = objvMicroteachCaseQuantitySenateItemsENS.MicroteachCaseID; //微格教学案例ID
objvMicroteachCaseQuantitySenateItemsENT.MicroteachCaseName = objvMicroteachCaseQuantitySenateItemsENS.MicroteachCaseName; //微格教学案例名称
objvMicroteachCaseQuantitySenateItemsENT.IdSenateGaugeItem = objvMicroteachCaseQuantitySenateItemsENS.IdSenateGaugeItem; //量表指标流水号
objvMicroteachCaseQuantitySenateItemsENT.senateGaugeItemID = objvMicroteachCaseQuantitySenateItemsENS.senateGaugeItemID; //量表指标ID
objvMicroteachCaseQuantitySenateItemsENT.senateGaugeItemName = objvMicroteachCaseQuantitySenateItemsENS.senateGaugeItemName; //量表指标名称
objvMicroteachCaseQuantitySenateItemsENT.senateGaugeItemNameWithOrder = objvMicroteachCaseQuantitySenateItemsENS.senateGaugeItemNameWithOrder; //量表指标名称WithOrder
objvMicroteachCaseQuantitySenateItemsENT.senateGaugeItemDesc = objvMicroteachCaseQuantitySenateItemsENS.senateGaugeItemDesc; //量表指标说明
objvMicroteachCaseQuantitySenateItemsENT.senateGaugeItemMemo = objvMicroteachCaseQuantitySenateItemsENS.senateGaugeItemMemo; //备注
objvMicroteachCaseQuantitySenateItemsENT.senateGaugeItemWeight = objvMicroteachCaseQuantitySenateItemsENS.senateGaugeItemWeight; //量表指标权重
objvMicroteachCaseQuantitySenateItemsENT.SenateScore = objvMicroteachCaseQuantitySenateItemsENS.SenateScore; //指标得分
objvMicroteachCaseQuantitySenateItemsENT.IdSenateGaugeSubItem = objvMicroteachCaseQuantitySenateItemsENS.IdSenateGaugeSubItem; //量表指标子项流水号
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
objvMicroteachCaseQuantitySenateItemsENT.IdSenateGaugeVersion = objvMicroteachCaseQuantitySenateItemsENS.IdSenateGaugeVersion; //评价量表版本流水号
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
objvMicroteachCaseQuantitySenateItemsENT.IdAppraiseType = objvMicroteachCaseQuantitySenateItemsENS.IdAppraiseType; //评议类型流水号
objvMicroteachCaseQuantitySenateItemsENT.AppraiseTypeName = objvMicroteachCaseQuantitySenateItemsENS.AppraiseTypeName; //评议类型名称
objvMicroteachCaseQuantitySenateItemsENT.FuncModuleId = objvMicroteachCaseQuantitySenateItemsENS.FuncModuleId; //功能模块Id
objvMicroteachCaseQuantitySenateItemsENT.UserKindId = objvMicroteachCaseQuantitySenateItemsENS.UserKindId; //用户类别Id
objvMicroteachCaseQuantitySenateItemsENT.UserKindName = objvMicroteachCaseQuantitySenateItemsENS.UserKindName; //用户类别名
objvMicroteachCaseQuantitySenateItemsENT.UserTypeName = objvMicroteachCaseQuantitySenateItemsENS.UserTypeName; //用户类型名称
objvMicroteachCaseQuantitySenateItemsENT.FuncModuleName = objvMicroteachCaseQuantitySenateItemsENS.FuncModuleName; //功能模块名称
objvMicroteachCaseQuantitySenateItemsENT.IdXzCollege = objvMicroteachCaseQuantitySenateItemsENS.IdXzCollege; //学院流水号
objvMicroteachCaseQuantitySenateItemsENT.CollegeNameA = objvMicroteachCaseQuantitySenateItemsENS.CollegeNameA; //学院名称简写
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
 /// <param name = "objvMicroteachCaseQuantitySenateItemsENS">源对象</param>
 /// <returns>目标对象=>clsvMicroteachCaseQuantitySenateItemsEN:objvMicroteachCaseQuantitySenateItemsENT</returns>
 public static clsvMicroteachCaseQuantitySenateItemsEN CopyTo(this clsvMicroteachCaseQuantitySenateItemsEN objvMicroteachCaseQuantitySenateItemsENS)
{
try
{
 clsvMicroteachCaseQuantitySenateItemsEN objvMicroteachCaseQuantitySenateItemsENT = new clsvMicroteachCaseQuantitySenateItemsEN()
{
IdmicroteachCaseQuantitySenateItem = objvMicroteachCaseQuantitySenateItemsENS.IdmicroteachCaseQuantitySenateItem, //微格量化评价指标流水号
IdmicroteachCaseQuantitySenate = objvMicroteachCaseQuantitySenateItemsENS.IdmicroteachCaseQuantitySenate, //微格量化评价流水号
IdMicroteachCase = objvMicroteachCaseQuantitySenateItemsENS.IdMicroteachCase, //微格教学案例流水号
MicroteachCaseID = objvMicroteachCaseQuantitySenateItemsENS.MicroteachCaseID, //微格教学案例ID
MicroteachCaseName = objvMicroteachCaseQuantitySenateItemsENS.MicroteachCaseName, //微格教学案例名称
IdSenateGaugeItem = objvMicroteachCaseQuantitySenateItemsENS.IdSenateGaugeItem, //量表指标流水号
senateGaugeItemID = objvMicroteachCaseQuantitySenateItemsENS.senateGaugeItemID, //量表指标ID
senateGaugeItemName = objvMicroteachCaseQuantitySenateItemsENS.senateGaugeItemName, //量表指标名称
senateGaugeItemNameWithOrder = objvMicroteachCaseQuantitySenateItemsENS.senateGaugeItemNameWithOrder, //量表指标名称WithOrder
senateGaugeItemDesc = objvMicroteachCaseQuantitySenateItemsENS.senateGaugeItemDesc, //量表指标说明
senateGaugeItemMemo = objvMicroteachCaseQuantitySenateItemsENS.senateGaugeItemMemo, //备注
senateGaugeItemWeight = objvMicroteachCaseQuantitySenateItemsENS.senateGaugeItemWeight, //量表指标权重
SenateScore = objvMicroteachCaseQuantitySenateItemsENS.SenateScore, //指标得分
IdSenateGaugeSubItem = objvMicroteachCaseQuantitySenateItemsENS.IdSenateGaugeSubItem, //量表指标子项流水号
senateGaugeSubItemID = objvMicroteachCaseQuantitySenateItemsENS.senateGaugeSubItemID, //量表指标子项ID
senateGaugeSubItemName = objvMicroteachCaseQuantitySenateItemsENS.senateGaugeSubItemName, //量表指标子项名称
senateGaugeSubItemDesc = objvMicroteachCaseQuantitySenateItemsENS.senateGaugeSubItemDesc, //量表指标子项说明
senateGaugeSubItemMemo = objvMicroteachCaseQuantitySenateItemsENS.senateGaugeSubItemMemo, //量表指标子项备注
senateGaugeSubItemScore = objvMicroteachCaseQuantitySenateItemsENS.senateGaugeSubItemScore, //量表指标子项分数
UserId = objvMicroteachCaseQuantitySenateItemsENS.UserId, //用户ID
UserName = objvMicroteachCaseQuantitySenateItemsENS.UserName, //用户名
CollegeID = objvMicroteachCaseQuantitySenateItemsENS.CollegeID, //学院ID
CollegeName = objvMicroteachCaseQuantitySenateItemsENS.CollegeName, //学院名称
SenateTheme = objvMicroteachCaseQuantitySenateItemsENS.SenateTheme, //量化评价主题
SenateContent = objvMicroteachCaseQuantitySenateItemsENS.SenateContent, //评价内容
SenateDate = objvMicroteachCaseQuantitySenateItemsENS.SenateDate, //评价日期
SenateTime = objvMicroteachCaseQuantitySenateItemsENS.SenateTime, //评价时间
SenateTotalScore = objvMicroteachCaseQuantitySenateItemsENS.SenateTotalScore, //评价分数
AnswerModeId = objvMicroteachCaseQuantitySenateItemsENS.AnswerModeId, //答案模式Id
AnswerTypeId = objvMicroteachCaseQuantitySenateItemsENS.AnswerTypeId, //答案类型ID
GridTitle = objvMicroteachCaseQuantitySenateItemsENS.GridTitle, //表格标题
QuestionIndex = objvMicroteachCaseQuantitySenateItemsENS.QuestionIndex, //题目序号
QuestionNo = objvMicroteachCaseQuantitySenateItemsENS.QuestionNo, //题目编号
QuestionTypeId = objvMicroteachCaseQuantitySenateItemsENS.QuestionTypeId, //题目类型Id
AnswerModeName = objvMicroteachCaseQuantitySenateItemsENS.AnswerModeName, //答案模式名称
AnswerNum = objvMicroteachCaseQuantitySenateItemsENS.AnswerNum, //答案数
AnswerTypeName = objvMicroteachCaseQuantitySenateItemsENS.AnswerTypeName, //答案类型名
QuestionTypeName = objvMicroteachCaseQuantitySenateItemsENS.QuestionTypeName, //题目类型名
senateGaugeVersionID = objvMicroteachCaseQuantitySenateItemsENS.senateGaugeVersionID, //评价量表版本ID
senateGaugeVersionName = objvMicroteachCaseQuantitySenateItemsENS.senateGaugeVersionName, //评价量表版本名称
senateGaugeVersionTtlScore = objvMicroteachCaseQuantitySenateItemsENS.senateGaugeVersionTtlScore, //评价量表版本总分
IdSenateGaugeVersion = objvMicroteachCaseQuantitySenateItemsENS.IdSenateGaugeVersion, //评价量表版本流水号
AnswerIndex = objvMicroteachCaseQuantitySenateItemsENS.AnswerIndex, //问答序号
AnswerTitle = objvMicroteachCaseQuantitySenateItemsENS.AnswerTitle, //答案标题
OwnerId = objvMicroteachCaseQuantitySenateItemsENS.OwnerId, //拥有者Id
OwnerName = objvMicroteachCaseQuantitySenateItemsENS.OwnerName, //拥有者姓名
OwnerNameWithId = objvMicroteachCaseQuantitySenateItemsENS.OwnerNameWithId, //拥有者名称附Id
SenateIp = objvMicroteachCaseQuantitySenateItemsENS.SenateIp, //评议Ip
UserNameWithUserId = objvMicroteachCaseQuantitySenateItemsENS.UserNameWithUserId, //UserNameWithUserId
UserTypeId = objvMicroteachCaseQuantitySenateItemsENS.UserTypeId, //用户类型Id
IsAccess = objvMicroteachCaseQuantitySenateItemsENS.IsAccess, //IsAccess
IsAccessC = objvMicroteachCaseQuantitySenateItemsENS.IsAccessC, //IsAccessC
UpdDate = objvMicroteachCaseQuantitySenateItemsENS.UpdDate, //修改日期
UpdUser = objvMicroteachCaseQuantitySenateItemsENS.UpdUser, //修改人
IdAppraiseType = objvMicroteachCaseQuantitySenateItemsENS.IdAppraiseType, //评议类型流水号
AppraiseTypeName = objvMicroteachCaseQuantitySenateItemsENS.AppraiseTypeName, //评议类型名称
FuncModuleId = objvMicroteachCaseQuantitySenateItemsENS.FuncModuleId, //功能模块Id
UserKindId = objvMicroteachCaseQuantitySenateItemsENS.UserKindId, //用户类别Id
UserKindName = objvMicroteachCaseQuantitySenateItemsENS.UserKindName, //用户类别名
UserTypeName = objvMicroteachCaseQuantitySenateItemsENS.UserTypeName, //用户类型名称
FuncModuleName = objvMicroteachCaseQuantitySenateItemsENS.FuncModuleName, //功能模块名称
IdXzCollege = objvMicroteachCaseQuantitySenateItemsENS.IdXzCollege, //学院流水号
CollegeNameA = objvMicroteachCaseQuantitySenateItemsENS.CollegeNameA, //学院名称简写
};
 return objvMicroteachCaseQuantitySenateItemsENT;
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
public static void CheckProperty4Condition(this clsvMicroteachCaseQuantitySenateItemsEN objvMicroteachCaseQuantitySenateItemsEN)
{
 clsvMicroteachCaseQuantitySenateItemsBL.vMicroteachCaseQuantitySenateItemsDA.CheckProperty4Condition(objvMicroteachCaseQuantitySenateItemsEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvMicroteachCaseQuantitySenateItemsEN objvMicroteachCaseQuantitySenateItemsCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvMicroteachCaseQuantitySenateItemsCond.IsUpdated(convMicroteachCaseQuantitySenateItems.IdmicroteachCaseQuantitySenateItem) == true)
{
string strComparisonOpIdmicroteachCaseQuantitySenateItem = objvMicroteachCaseQuantitySenateItemsCond.dicFldComparisonOp[convMicroteachCaseQuantitySenateItems.IdmicroteachCaseQuantitySenateItem];
strWhereCond += string.Format(" And {0} {2} {1}", convMicroteachCaseQuantitySenateItems.IdmicroteachCaseQuantitySenateItem, objvMicroteachCaseQuantitySenateItemsCond.IdmicroteachCaseQuantitySenateItem, strComparisonOpIdmicroteachCaseQuantitySenateItem);
}
if (objvMicroteachCaseQuantitySenateItemsCond.IsUpdated(convMicroteachCaseQuantitySenateItems.IdmicroteachCaseQuantitySenate) == true)
{
string strComparisonOpIdmicroteachCaseQuantitySenate = objvMicroteachCaseQuantitySenateItemsCond.dicFldComparisonOp[convMicroteachCaseQuantitySenateItems.IdmicroteachCaseQuantitySenate];
strWhereCond += string.Format(" And {0} {2} {1}", convMicroteachCaseQuantitySenateItems.IdmicroteachCaseQuantitySenate, objvMicroteachCaseQuantitySenateItemsCond.IdmicroteachCaseQuantitySenate, strComparisonOpIdmicroteachCaseQuantitySenate);
}
if (objvMicroteachCaseQuantitySenateItemsCond.IsUpdated(convMicroteachCaseQuantitySenateItems.IdMicroteachCase) == true)
{
string strComparisonOpIdMicroteachCase = objvMicroteachCaseQuantitySenateItemsCond.dicFldComparisonOp[convMicroteachCaseQuantitySenateItems.IdMicroteachCase];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCaseQuantitySenateItems.IdMicroteachCase, objvMicroteachCaseQuantitySenateItemsCond.IdMicroteachCase, strComparisonOpIdMicroteachCase);
}
if (objvMicroteachCaseQuantitySenateItemsCond.IsUpdated(convMicroteachCaseQuantitySenateItems.MicroteachCaseID) == true)
{
string strComparisonOpMicroteachCaseID = objvMicroteachCaseQuantitySenateItemsCond.dicFldComparisonOp[convMicroteachCaseQuantitySenateItems.MicroteachCaseID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCaseQuantitySenateItems.MicroteachCaseID, objvMicroteachCaseQuantitySenateItemsCond.MicroteachCaseID, strComparisonOpMicroteachCaseID);
}
if (objvMicroteachCaseQuantitySenateItemsCond.IsUpdated(convMicroteachCaseQuantitySenateItems.MicroteachCaseName) == true)
{
string strComparisonOpMicroteachCaseName = objvMicroteachCaseQuantitySenateItemsCond.dicFldComparisonOp[convMicroteachCaseQuantitySenateItems.MicroteachCaseName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCaseQuantitySenateItems.MicroteachCaseName, objvMicroteachCaseQuantitySenateItemsCond.MicroteachCaseName, strComparisonOpMicroteachCaseName);
}
if (objvMicroteachCaseQuantitySenateItemsCond.IsUpdated(convMicroteachCaseQuantitySenateItems.IdSenateGaugeItem) == true)
{
string strComparisonOpIdSenateGaugeItem = objvMicroteachCaseQuantitySenateItemsCond.dicFldComparisonOp[convMicroteachCaseQuantitySenateItems.IdSenateGaugeItem];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCaseQuantitySenateItems.IdSenateGaugeItem, objvMicroteachCaseQuantitySenateItemsCond.IdSenateGaugeItem, strComparisonOpIdSenateGaugeItem);
}
if (objvMicroteachCaseQuantitySenateItemsCond.IsUpdated(convMicroteachCaseQuantitySenateItems.senateGaugeItemID) == true)
{
string strComparisonOpsenateGaugeItemID = objvMicroteachCaseQuantitySenateItemsCond.dicFldComparisonOp[convMicroteachCaseQuantitySenateItems.senateGaugeItemID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCaseQuantitySenateItems.senateGaugeItemID, objvMicroteachCaseQuantitySenateItemsCond.senateGaugeItemID, strComparisonOpsenateGaugeItemID);
}
if (objvMicroteachCaseQuantitySenateItemsCond.IsUpdated(convMicroteachCaseQuantitySenateItems.senateGaugeItemName) == true)
{
string strComparisonOpsenateGaugeItemName = objvMicroteachCaseQuantitySenateItemsCond.dicFldComparisonOp[convMicroteachCaseQuantitySenateItems.senateGaugeItemName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCaseQuantitySenateItems.senateGaugeItemName, objvMicroteachCaseQuantitySenateItemsCond.senateGaugeItemName, strComparisonOpsenateGaugeItemName);
}
if (objvMicroteachCaseQuantitySenateItemsCond.IsUpdated(convMicroteachCaseQuantitySenateItems.senateGaugeItemNameWithOrder) == true)
{
string strComparisonOpsenateGaugeItemNameWithOrder = objvMicroteachCaseQuantitySenateItemsCond.dicFldComparisonOp[convMicroteachCaseQuantitySenateItems.senateGaugeItemNameWithOrder];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCaseQuantitySenateItems.senateGaugeItemNameWithOrder, objvMicroteachCaseQuantitySenateItemsCond.senateGaugeItemNameWithOrder, strComparisonOpsenateGaugeItemNameWithOrder);
}
if (objvMicroteachCaseQuantitySenateItemsCond.IsUpdated(convMicroteachCaseQuantitySenateItems.senateGaugeItemDesc) == true)
{
string strComparisonOpsenateGaugeItemDesc = objvMicroteachCaseQuantitySenateItemsCond.dicFldComparisonOp[convMicroteachCaseQuantitySenateItems.senateGaugeItemDesc];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCaseQuantitySenateItems.senateGaugeItemDesc, objvMicroteachCaseQuantitySenateItemsCond.senateGaugeItemDesc, strComparisonOpsenateGaugeItemDesc);
}
if (objvMicroteachCaseQuantitySenateItemsCond.IsUpdated(convMicroteachCaseQuantitySenateItems.senateGaugeItemMemo) == true)
{
string strComparisonOpsenateGaugeItemMemo = objvMicroteachCaseQuantitySenateItemsCond.dicFldComparisonOp[convMicroteachCaseQuantitySenateItems.senateGaugeItemMemo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCaseQuantitySenateItems.senateGaugeItemMemo, objvMicroteachCaseQuantitySenateItemsCond.senateGaugeItemMemo, strComparisonOpsenateGaugeItemMemo);
}
if (objvMicroteachCaseQuantitySenateItemsCond.IsUpdated(convMicroteachCaseQuantitySenateItems.senateGaugeItemWeight) == true)
{
string strComparisonOpsenateGaugeItemWeight = objvMicroteachCaseQuantitySenateItemsCond.dicFldComparisonOp[convMicroteachCaseQuantitySenateItems.senateGaugeItemWeight];
strWhereCond += string.Format(" And {0} {2} {1}", convMicroteachCaseQuantitySenateItems.senateGaugeItemWeight, objvMicroteachCaseQuantitySenateItemsCond.senateGaugeItemWeight, strComparisonOpsenateGaugeItemWeight);
}
if (objvMicroteachCaseQuantitySenateItemsCond.IsUpdated(convMicroteachCaseQuantitySenateItems.SenateScore) == true)
{
string strComparisonOpSenateScore = objvMicroteachCaseQuantitySenateItemsCond.dicFldComparisonOp[convMicroteachCaseQuantitySenateItems.SenateScore];
strWhereCond += string.Format(" And {0} {2} {1}", convMicroteachCaseQuantitySenateItems.SenateScore, objvMicroteachCaseQuantitySenateItemsCond.SenateScore, strComparisonOpSenateScore);
}
if (objvMicroteachCaseQuantitySenateItemsCond.IsUpdated(convMicroteachCaseQuantitySenateItems.IdSenateGaugeSubItem) == true)
{
string strComparisonOpIdSenateGaugeSubItem = objvMicroteachCaseQuantitySenateItemsCond.dicFldComparisonOp[convMicroteachCaseQuantitySenateItems.IdSenateGaugeSubItem];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCaseQuantitySenateItems.IdSenateGaugeSubItem, objvMicroteachCaseQuantitySenateItemsCond.IdSenateGaugeSubItem, strComparisonOpIdSenateGaugeSubItem);
}
if (objvMicroteachCaseQuantitySenateItemsCond.IsUpdated(convMicroteachCaseQuantitySenateItems.senateGaugeSubItemID) == true)
{
string strComparisonOpsenateGaugeSubItemID = objvMicroteachCaseQuantitySenateItemsCond.dicFldComparisonOp[convMicroteachCaseQuantitySenateItems.senateGaugeSubItemID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCaseQuantitySenateItems.senateGaugeSubItemID, objvMicroteachCaseQuantitySenateItemsCond.senateGaugeSubItemID, strComparisonOpsenateGaugeSubItemID);
}
if (objvMicroteachCaseQuantitySenateItemsCond.IsUpdated(convMicroteachCaseQuantitySenateItems.senateGaugeSubItemName) == true)
{
string strComparisonOpsenateGaugeSubItemName = objvMicroteachCaseQuantitySenateItemsCond.dicFldComparisonOp[convMicroteachCaseQuantitySenateItems.senateGaugeSubItemName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCaseQuantitySenateItems.senateGaugeSubItemName, objvMicroteachCaseQuantitySenateItemsCond.senateGaugeSubItemName, strComparisonOpsenateGaugeSubItemName);
}
if (objvMicroteachCaseQuantitySenateItemsCond.IsUpdated(convMicroteachCaseQuantitySenateItems.senateGaugeSubItemDesc) == true)
{
string strComparisonOpsenateGaugeSubItemDesc = objvMicroteachCaseQuantitySenateItemsCond.dicFldComparisonOp[convMicroteachCaseQuantitySenateItems.senateGaugeSubItemDesc];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCaseQuantitySenateItems.senateGaugeSubItemDesc, objvMicroteachCaseQuantitySenateItemsCond.senateGaugeSubItemDesc, strComparisonOpsenateGaugeSubItemDesc);
}
if (objvMicroteachCaseQuantitySenateItemsCond.IsUpdated(convMicroteachCaseQuantitySenateItems.senateGaugeSubItemMemo) == true)
{
string strComparisonOpsenateGaugeSubItemMemo = objvMicroteachCaseQuantitySenateItemsCond.dicFldComparisonOp[convMicroteachCaseQuantitySenateItems.senateGaugeSubItemMemo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCaseQuantitySenateItems.senateGaugeSubItemMemo, objvMicroteachCaseQuantitySenateItemsCond.senateGaugeSubItemMemo, strComparisonOpsenateGaugeSubItemMemo);
}
if (objvMicroteachCaseQuantitySenateItemsCond.IsUpdated(convMicroteachCaseQuantitySenateItems.senateGaugeSubItemScore) == true)
{
string strComparisonOpsenateGaugeSubItemScore = objvMicroteachCaseQuantitySenateItemsCond.dicFldComparisonOp[convMicroteachCaseQuantitySenateItems.senateGaugeSubItemScore];
strWhereCond += string.Format(" And {0} {2} {1}", convMicroteachCaseQuantitySenateItems.senateGaugeSubItemScore, objvMicroteachCaseQuantitySenateItemsCond.senateGaugeSubItemScore, strComparisonOpsenateGaugeSubItemScore);
}
if (objvMicroteachCaseQuantitySenateItemsCond.IsUpdated(convMicroteachCaseQuantitySenateItems.UserId) == true)
{
string strComparisonOpUserId = objvMicroteachCaseQuantitySenateItemsCond.dicFldComparisonOp[convMicroteachCaseQuantitySenateItems.UserId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCaseQuantitySenateItems.UserId, objvMicroteachCaseQuantitySenateItemsCond.UserId, strComparisonOpUserId);
}
if (objvMicroteachCaseQuantitySenateItemsCond.IsUpdated(convMicroteachCaseQuantitySenateItems.UserName) == true)
{
string strComparisonOpUserName = objvMicroteachCaseQuantitySenateItemsCond.dicFldComparisonOp[convMicroteachCaseQuantitySenateItems.UserName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCaseQuantitySenateItems.UserName, objvMicroteachCaseQuantitySenateItemsCond.UserName, strComparisonOpUserName);
}
if (objvMicroteachCaseQuantitySenateItemsCond.IsUpdated(convMicroteachCaseQuantitySenateItems.CollegeID) == true)
{
string strComparisonOpCollegeID = objvMicroteachCaseQuantitySenateItemsCond.dicFldComparisonOp[convMicroteachCaseQuantitySenateItems.CollegeID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCaseQuantitySenateItems.CollegeID, objvMicroteachCaseQuantitySenateItemsCond.CollegeID, strComparisonOpCollegeID);
}
if (objvMicroteachCaseQuantitySenateItemsCond.IsUpdated(convMicroteachCaseQuantitySenateItems.CollegeName) == true)
{
string strComparisonOpCollegeName = objvMicroteachCaseQuantitySenateItemsCond.dicFldComparisonOp[convMicroteachCaseQuantitySenateItems.CollegeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCaseQuantitySenateItems.CollegeName, objvMicroteachCaseQuantitySenateItemsCond.CollegeName, strComparisonOpCollegeName);
}
if (objvMicroteachCaseQuantitySenateItemsCond.IsUpdated(convMicroteachCaseQuantitySenateItems.SenateTheme) == true)
{
string strComparisonOpSenateTheme = objvMicroteachCaseQuantitySenateItemsCond.dicFldComparisonOp[convMicroteachCaseQuantitySenateItems.SenateTheme];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCaseQuantitySenateItems.SenateTheme, objvMicroteachCaseQuantitySenateItemsCond.SenateTheme, strComparisonOpSenateTheme);
}
if (objvMicroteachCaseQuantitySenateItemsCond.IsUpdated(convMicroteachCaseQuantitySenateItems.SenateContent) == true)
{
string strComparisonOpSenateContent = objvMicroteachCaseQuantitySenateItemsCond.dicFldComparisonOp[convMicroteachCaseQuantitySenateItems.SenateContent];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCaseQuantitySenateItems.SenateContent, objvMicroteachCaseQuantitySenateItemsCond.SenateContent, strComparisonOpSenateContent);
}
if (objvMicroteachCaseQuantitySenateItemsCond.IsUpdated(convMicroteachCaseQuantitySenateItems.SenateDate) == true)
{
string strComparisonOpSenateDate = objvMicroteachCaseQuantitySenateItemsCond.dicFldComparisonOp[convMicroteachCaseQuantitySenateItems.SenateDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCaseQuantitySenateItems.SenateDate, objvMicroteachCaseQuantitySenateItemsCond.SenateDate, strComparisonOpSenateDate);
}
if (objvMicroteachCaseQuantitySenateItemsCond.IsUpdated(convMicroteachCaseQuantitySenateItems.SenateTime) == true)
{
string strComparisonOpSenateTime = objvMicroteachCaseQuantitySenateItemsCond.dicFldComparisonOp[convMicroteachCaseQuantitySenateItems.SenateTime];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCaseQuantitySenateItems.SenateTime, objvMicroteachCaseQuantitySenateItemsCond.SenateTime, strComparisonOpSenateTime);
}
if (objvMicroteachCaseQuantitySenateItemsCond.IsUpdated(convMicroteachCaseQuantitySenateItems.SenateTotalScore) == true)
{
string strComparisonOpSenateTotalScore = objvMicroteachCaseQuantitySenateItemsCond.dicFldComparisonOp[convMicroteachCaseQuantitySenateItems.SenateTotalScore];
strWhereCond += string.Format(" And {0} {2} {1}", convMicroteachCaseQuantitySenateItems.SenateTotalScore, objvMicroteachCaseQuantitySenateItemsCond.SenateTotalScore, strComparisonOpSenateTotalScore);
}
if (objvMicroteachCaseQuantitySenateItemsCond.IsUpdated(convMicroteachCaseQuantitySenateItems.AnswerModeId) == true)
{
string strComparisonOpAnswerModeId = objvMicroteachCaseQuantitySenateItemsCond.dicFldComparisonOp[convMicroteachCaseQuantitySenateItems.AnswerModeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCaseQuantitySenateItems.AnswerModeId, objvMicroteachCaseQuantitySenateItemsCond.AnswerModeId, strComparisonOpAnswerModeId);
}
if (objvMicroteachCaseQuantitySenateItemsCond.IsUpdated(convMicroteachCaseQuantitySenateItems.AnswerTypeId) == true)
{
string strComparisonOpAnswerTypeId = objvMicroteachCaseQuantitySenateItemsCond.dicFldComparisonOp[convMicroteachCaseQuantitySenateItems.AnswerTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCaseQuantitySenateItems.AnswerTypeId, objvMicroteachCaseQuantitySenateItemsCond.AnswerTypeId, strComparisonOpAnswerTypeId);
}
if (objvMicroteachCaseQuantitySenateItemsCond.IsUpdated(convMicroteachCaseQuantitySenateItems.GridTitle) == true)
{
string strComparisonOpGridTitle = objvMicroteachCaseQuantitySenateItemsCond.dicFldComparisonOp[convMicroteachCaseQuantitySenateItems.GridTitle];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCaseQuantitySenateItems.GridTitle, objvMicroteachCaseQuantitySenateItemsCond.GridTitle, strComparisonOpGridTitle);
}
if (objvMicroteachCaseQuantitySenateItemsCond.IsUpdated(convMicroteachCaseQuantitySenateItems.QuestionIndex) == true)
{
string strComparisonOpQuestionIndex = objvMicroteachCaseQuantitySenateItemsCond.dicFldComparisonOp[convMicroteachCaseQuantitySenateItems.QuestionIndex];
strWhereCond += string.Format(" And {0} {2} {1}", convMicroteachCaseQuantitySenateItems.QuestionIndex, objvMicroteachCaseQuantitySenateItemsCond.QuestionIndex, strComparisonOpQuestionIndex);
}
if (objvMicroteachCaseQuantitySenateItemsCond.IsUpdated(convMicroteachCaseQuantitySenateItems.QuestionNo) == true)
{
string strComparisonOpQuestionNo = objvMicroteachCaseQuantitySenateItemsCond.dicFldComparisonOp[convMicroteachCaseQuantitySenateItems.QuestionNo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCaseQuantitySenateItems.QuestionNo, objvMicroteachCaseQuantitySenateItemsCond.QuestionNo, strComparisonOpQuestionNo);
}
if (objvMicroteachCaseQuantitySenateItemsCond.IsUpdated(convMicroteachCaseQuantitySenateItems.QuestionTypeId) == true)
{
string strComparisonOpQuestionTypeId = objvMicroteachCaseQuantitySenateItemsCond.dicFldComparisonOp[convMicroteachCaseQuantitySenateItems.QuestionTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCaseQuantitySenateItems.QuestionTypeId, objvMicroteachCaseQuantitySenateItemsCond.QuestionTypeId, strComparisonOpQuestionTypeId);
}
if (objvMicroteachCaseQuantitySenateItemsCond.IsUpdated(convMicroteachCaseQuantitySenateItems.AnswerModeName) == true)
{
string strComparisonOpAnswerModeName = objvMicroteachCaseQuantitySenateItemsCond.dicFldComparisonOp[convMicroteachCaseQuantitySenateItems.AnswerModeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCaseQuantitySenateItems.AnswerModeName, objvMicroteachCaseQuantitySenateItemsCond.AnswerModeName, strComparisonOpAnswerModeName);
}
if (objvMicroteachCaseQuantitySenateItemsCond.IsUpdated(convMicroteachCaseQuantitySenateItems.AnswerNum) == true)
{
string strComparisonOpAnswerNum = objvMicroteachCaseQuantitySenateItemsCond.dicFldComparisonOp[convMicroteachCaseQuantitySenateItems.AnswerNum];
strWhereCond += string.Format(" And {0} {2} {1}", convMicroteachCaseQuantitySenateItems.AnswerNum, objvMicroteachCaseQuantitySenateItemsCond.AnswerNum, strComparisonOpAnswerNum);
}
if (objvMicroteachCaseQuantitySenateItemsCond.IsUpdated(convMicroteachCaseQuantitySenateItems.AnswerTypeName) == true)
{
string strComparisonOpAnswerTypeName = objvMicroteachCaseQuantitySenateItemsCond.dicFldComparisonOp[convMicroteachCaseQuantitySenateItems.AnswerTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCaseQuantitySenateItems.AnswerTypeName, objvMicroteachCaseQuantitySenateItemsCond.AnswerTypeName, strComparisonOpAnswerTypeName);
}
if (objvMicroteachCaseQuantitySenateItemsCond.IsUpdated(convMicroteachCaseQuantitySenateItems.QuestionTypeName) == true)
{
string strComparisonOpQuestionTypeName = objvMicroteachCaseQuantitySenateItemsCond.dicFldComparisonOp[convMicroteachCaseQuantitySenateItems.QuestionTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCaseQuantitySenateItems.QuestionTypeName, objvMicroteachCaseQuantitySenateItemsCond.QuestionTypeName, strComparisonOpQuestionTypeName);
}
if (objvMicroteachCaseQuantitySenateItemsCond.IsUpdated(convMicroteachCaseQuantitySenateItems.senateGaugeVersionID) == true)
{
string strComparisonOpsenateGaugeVersionID = objvMicroteachCaseQuantitySenateItemsCond.dicFldComparisonOp[convMicroteachCaseQuantitySenateItems.senateGaugeVersionID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCaseQuantitySenateItems.senateGaugeVersionID, objvMicroteachCaseQuantitySenateItemsCond.senateGaugeVersionID, strComparisonOpsenateGaugeVersionID);
}
if (objvMicroteachCaseQuantitySenateItemsCond.IsUpdated(convMicroteachCaseQuantitySenateItems.senateGaugeVersionName) == true)
{
string strComparisonOpsenateGaugeVersionName = objvMicroteachCaseQuantitySenateItemsCond.dicFldComparisonOp[convMicroteachCaseQuantitySenateItems.senateGaugeVersionName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCaseQuantitySenateItems.senateGaugeVersionName, objvMicroteachCaseQuantitySenateItemsCond.senateGaugeVersionName, strComparisonOpsenateGaugeVersionName);
}
if (objvMicroteachCaseQuantitySenateItemsCond.IsUpdated(convMicroteachCaseQuantitySenateItems.senateGaugeVersionTtlScore) == true)
{
string strComparisonOpsenateGaugeVersionTtlScore = objvMicroteachCaseQuantitySenateItemsCond.dicFldComparisonOp[convMicroteachCaseQuantitySenateItems.senateGaugeVersionTtlScore];
strWhereCond += string.Format(" And {0} {2} {1}", convMicroteachCaseQuantitySenateItems.senateGaugeVersionTtlScore, objvMicroteachCaseQuantitySenateItemsCond.senateGaugeVersionTtlScore, strComparisonOpsenateGaugeVersionTtlScore);
}
if (objvMicroteachCaseQuantitySenateItemsCond.IsUpdated(convMicroteachCaseQuantitySenateItems.IdSenateGaugeVersion) == true)
{
string strComparisonOpIdSenateGaugeVersion = objvMicroteachCaseQuantitySenateItemsCond.dicFldComparisonOp[convMicroteachCaseQuantitySenateItems.IdSenateGaugeVersion];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCaseQuantitySenateItems.IdSenateGaugeVersion, objvMicroteachCaseQuantitySenateItemsCond.IdSenateGaugeVersion, strComparisonOpIdSenateGaugeVersion);
}
if (objvMicroteachCaseQuantitySenateItemsCond.IsUpdated(convMicroteachCaseQuantitySenateItems.AnswerIndex) == true)
{
string strComparisonOpAnswerIndex = objvMicroteachCaseQuantitySenateItemsCond.dicFldComparisonOp[convMicroteachCaseQuantitySenateItems.AnswerIndex];
strWhereCond += string.Format(" And {0} {2} {1}", convMicroteachCaseQuantitySenateItems.AnswerIndex, objvMicroteachCaseQuantitySenateItemsCond.AnswerIndex, strComparisonOpAnswerIndex);
}
if (objvMicroteachCaseQuantitySenateItemsCond.IsUpdated(convMicroteachCaseQuantitySenateItems.AnswerTitle) == true)
{
string strComparisonOpAnswerTitle = objvMicroteachCaseQuantitySenateItemsCond.dicFldComparisonOp[convMicroteachCaseQuantitySenateItems.AnswerTitle];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCaseQuantitySenateItems.AnswerTitle, objvMicroteachCaseQuantitySenateItemsCond.AnswerTitle, strComparisonOpAnswerTitle);
}
if (objvMicroteachCaseQuantitySenateItemsCond.IsUpdated(convMicroteachCaseQuantitySenateItems.OwnerId) == true)
{
string strComparisonOpOwnerId = objvMicroteachCaseQuantitySenateItemsCond.dicFldComparisonOp[convMicroteachCaseQuantitySenateItems.OwnerId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCaseQuantitySenateItems.OwnerId, objvMicroteachCaseQuantitySenateItemsCond.OwnerId, strComparisonOpOwnerId);
}
if (objvMicroteachCaseQuantitySenateItemsCond.IsUpdated(convMicroteachCaseQuantitySenateItems.OwnerName) == true)
{
string strComparisonOpOwnerName = objvMicroteachCaseQuantitySenateItemsCond.dicFldComparisonOp[convMicroteachCaseQuantitySenateItems.OwnerName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCaseQuantitySenateItems.OwnerName, objvMicroteachCaseQuantitySenateItemsCond.OwnerName, strComparisonOpOwnerName);
}
if (objvMicroteachCaseQuantitySenateItemsCond.IsUpdated(convMicroteachCaseQuantitySenateItems.OwnerNameWithId) == true)
{
string strComparisonOpOwnerNameWithId = objvMicroteachCaseQuantitySenateItemsCond.dicFldComparisonOp[convMicroteachCaseQuantitySenateItems.OwnerNameWithId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCaseQuantitySenateItems.OwnerNameWithId, objvMicroteachCaseQuantitySenateItemsCond.OwnerNameWithId, strComparisonOpOwnerNameWithId);
}
if (objvMicroteachCaseQuantitySenateItemsCond.IsUpdated(convMicroteachCaseQuantitySenateItems.SenateIp) == true)
{
string strComparisonOpSenateIp = objvMicroteachCaseQuantitySenateItemsCond.dicFldComparisonOp[convMicroteachCaseQuantitySenateItems.SenateIp];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCaseQuantitySenateItems.SenateIp, objvMicroteachCaseQuantitySenateItemsCond.SenateIp, strComparisonOpSenateIp);
}
if (objvMicroteachCaseQuantitySenateItemsCond.IsUpdated(convMicroteachCaseQuantitySenateItems.UserNameWithUserId) == true)
{
string strComparisonOpUserNameWithUserId = objvMicroteachCaseQuantitySenateItemsCond.dicFldComparisonOp[convMicroteachCaseQuantitySenateItems.UserNameWithUserId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCaseQuantitySenateItems.UserNameWithUserId, objvMicroteachCaseQuantitySenateItemsCond.UserNameWithUserId, strComparisonOpUserNameWithUserId);
}
if (objvMicroteachCaseQuantitySenateItemsCond.IsUpdated(convMicroteachCaseQuantitySenateItems.UserTypeId) == true)
{
string strComparisonOpUserTypeId = objvMicroteachCaseQuantitySenateItemsCond.dicFldComparisonOp[convMicroteachCaseQuantitySenateItems.UserTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCaseQuantitySenateItems.UserTypeId, objvMicroteachCaseQuantitySenateItemsCond.UserTypeId, strComparisonOpUserTypeId);
}
if (objvMicroteachCaseQuantitySenateItemsCond.IsUpdated(convMicroteachCaseQuantitySenateItems.IsAccess) == true)
{
if (objvMicroteachCaseQuantitySenateItemsCond.IsAccess == true)
{
strWhereCond += string.Format(" And {0} = '1'", convMicroteachCaseQuantitySenateItems.IsAccess);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convMicroteachCaseQuantitySenateItems.IsAccess);
}
}
if (objvMicroteachCaseQuantitySenateItemsCond.IsUpdated(convMicroteachCaseQuantitySenateItems.IsAccessC) == true)
{
if (objvMicroteachCaseQuantitySenateItemsCond.IsAccessC == true)
{
strWhereCond += string.Format(" And {0} = '1'", convMicroteachCaseQuantitySenateItems.IsAccessC);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convMicroteachCaseQuantitySenateItems.IsAccessC);
}
}
if (objvMicroteachCaseQuantitySenateItemsCond.IsUpdated(convMicroteachCaseQuantitySenateItems.UpdDate) == true)
{
string strComparisonOpUpdDate = objvMicroteachCaseQuantitySenateItemsCond.dicFldComparisonOp[convMicroteachCaseQuantitySenateItems.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCaseQuantitySenateItems.UpdDate, objvMicroteachCaseQuantitySenateItemsCond.UpdDate, strComparisonOpUpdDate);
}
if (objvMicroteachCaseQuantitySenateItemsCond.IsUpdated(convMicroteachCaseQuantitySenateItems.UpdUser) == true)
{
string strComparisonOpUpdUser = objvMicroteachCaseQuantitySenateItemsCond.dicFldComparisonOp[convMicroteachCaseQuantitySenateItems.UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCaseQuantitySenateItems.UpdUser, objvMicroteachCaseQuantitySenateItemsCond.UpdUser, strComparisonOpUpdUser);
}
if (objvMicroteachCaseQuantitySenateItemsCond.IsUpdated(convMicroteachCaseQuantitySenateItems.IdAppraiseType) == true)
{
string strComparisonOpIdAppraiseType = objvMicroteachCaseQuantitySenateItemsCond.dicFldComparisonOp[convMicroteachCaseQuantitySenateItems.IdAppraiseType];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCaseQuantitySenateItems.IdAppraiseType, objvMicroteachCaseQuantitySenateItemsCond.IdAppraiseType, strComparisonOpIdAppraiseType);
}
if (objvMicroteachCaseQuantitySenateItemsCond.IsUpdated(convMicroteachCaseQuantitySenateItems.AppraiseTypeName) == true)
{
string strComparisonOpAppraiseTypeName = objvMicroteachCaseQuantitySenateItemsCond.dicFldComparisonOp[convMicroteachCaseQuantitySenateItems.AppraiseTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCaseQuantitySenateItems.AppraiseTypeName, objvMicroteachCaseQuantitySenateItemsCond.AppraiseTypeName, strComparisonOpAppraiseTypeName);
}
if (objvMicroteachCaseQuantitySenateItemsCond.IsUpdated(convMicroteachCaseQuantitySenateItems.FuncModuleId) == true)
{
string strComparisonOpFuncModuleId = objvMicroteachCaseQuantitySenateItemsCond.dicFldComparisonOp[convMicroteachCaseQuantitySenateItems.FuncModuleId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCaseQuantitySenateItems.FuncModuleId, objvMicroteachCaseQuantitySenateItemsCond.FuncModuleId, strComparisonOpFuncModuleId);
}
if (objvMicroteachCaseQuantitySenateItemsCond.IsUpdated(convMicroteachCaseQuantitySenateItems.UserKindId) == true)
{
string strComparisonOpUserKindId = objvMicroteachCaseQuantitySenateItemsCond.dicFldComparisonOp[convMicroteachCaseQuantitySenateItems.UserKindId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCaseQuantitySenateItems.UserKindId, objvMicroteachCaseQuantitySenateItemsCond.UserKindId, strComparisonOpUserKindId);
}
if (objvMicroteachCaseQuantitySenateItemsCond.IsUpdated(convMicroteachCaseQuantitySenateItems.UserKindName) == true)
{
string strComparisonOpUserKindName = objvMicroteachCaseQuantitySenateItemsCond.dicFldComparisonOp[convMicroteachCaseQuantitySenateItems.UserKindName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCaseQuantitySenateItems.UserKindName, objvMicroteachCaseQuantitySenateItemsCond.UserKindName, strComparisonOpUserKindName);
}
if (objvMicroteachCaseQuantitySenateItemsCond.IsUpdated(convMicroteachCaseQuantitySenateItems.UserTypeName) == true)
{
string strComparisonOpUserTypeName = objvMicroteachCaseQuantitySenateItemsCond.dicFldComparisonOp[convMicroteachCaseQuantitySenateItems.UserTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCaseQuantitySenateItems.UserTypeName, objvMicroteachCaseQuantitySenateItemsCond.UserTypeName, strComparisonOpUserTypeName);
}
if (objvMicroteachCaseQuantitySenateItemsCond.IsUpdated(convMicroteachCaseQuantitySenateItems.FuncModuleName) == true)
{
string strComparisonOpFuncModuleName = objvMicroteachCaseQuantitySenateItemsCond.dicFldComparisonOp[convMicroteachCaseQuantitySenateItems.FuncModuleName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCaseQuantitySenateItems.FuncModuleName, objvMicroteachCaseQuantitySenateItemsCond.FuncModuleName, strComparisonOpFuncModuleName);
}
if (objvMicroteachCaseQuantitySenateItemsCond.IsUpdated(convMicroteachCaseQuantitySenateItems.IdXzCollege) == true)
{
string strComparisonOpIdXzCollege = objvMicroteachCaseQuantitySenateItemsCond.dicFldComparisonOp[convMicroteachCaseQuantitySenateItems.IdXzCollege];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCaseQuantitySenateItems.IdXzCollege, objvMicroteachCaseQuantitySenateItemsCond.IdXzCollege, strComparisonOpIdXzCollege);
}
if (objvMicroteachCaseQuantitySenateItemsCond.IsUpdated(convMicroteachCaseQuantitySenateItems.CollegeNameA) == true)
{
string strComparisonOpCollegeNameA = objvMicroteachCaseQuantitySenateItemsCond.dicFldComparisonOp[convMicroteachCaseQuantitySenateItems.CollegeNameA];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMicroteachCaseQuantitySenateItems.CollegeNameA, objvMicroteachCaseQuantitySenateItemsCond.CollegeNameA, strComparisonOpCollegeNameA);
}
 return strWhereCond;
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_vMicroteachCaseQuantitySenateItems
{
public virtual bool UpdRelaTabDate(long lngIdmicroteachCaseQuantitySenateItem, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// 微格量化评价详细(vMicroteachCaseQuantitySenateItems)
 /// 数据源类型:视图
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsvMicroteachCaseQuantitySenateItemsBL
{
public static RelatedActions_vMicroteachCaseQuantitySenateItems relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsvMicroteachCaseQuantitySenateItemsDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsvMicroteachCaseQuantitySenateItemsDA vMicroteachCaseQuantitySenateItemsDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsvMicroteachCaseQuantitySenateItemsDA();
}
return uniqueInstance;
}
}

 /// <summary>
 /// 类的构造函数
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ClassConstructor1)
 /// </summary>
 public clsvMicroteachCaseQuantitySenateItemsBL()
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
if (string.IsNullOrEmpty(clsvMicroteachCaseQuantitySenateItemsEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvMicroteachCaseQuantitySenateItemsEN._ConnectString);
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
public static DataTable GetDataTable_vMicroteachCaseQuantitySenateItems(string strWhereCond)
{
DataTable objDT;
try
{
objDT = vMicroteachCaseQuantitySenateItemsDA.GetDataTable_vMicroteachCaseQuantitySenateItems(strWhereCond);
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
objDT = vMicroteachCaseQuantitySenateItemsDA.GetDataTable(strWhereCond);
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
objDT = vMicroteachCaseQuantitySenateItemsDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = vMicroteachCaseQuantitySenateItemsDA.GetDataTable(strWhereCond, strTabName);
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
objDT = vMicroteachCaseQuantitySenateItemsDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = vMicroteachCaseQuantitySenateItemsDA.GetDataTable_Top(objTopPara);
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
objDT = vMicroteachCaseQuantitySenateItemsDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = vMicroteachCaseQuantitySenateItemsDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = vMicroteachCaseQuantitySenateItemsDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
 /// <param name = "arrIdmicroteachCaseQuantitySenateItemLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static List<clsvMicroteachCaseQuantitySenateItemsEN> GetObjLstByIdmicroteachCaseQuantitySenateItemLst(List<long> arrIdmicroteachCaseQuantitySenateItemLst)
{
List<clsvMicroteachCaseQuantitySenateItemsEN> arrObjLst = new List<clsvMicroteachCaseQuantitySenateItemsEN>(); 
System.Data.DataTable objDT; 
 string strSqlConditionStr = clsArray.GetSqlInStrByArray(arrIdmicroteachCaseQuantitySenateItemLst);
 string strWhereCond = string.Format("IdmicroteachCaseQuantitySenateItem in ({0})", strSqlConditionStr);
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvMicroteachCaseQuantitySenateItemsEN objvMicroteachCaseQuantitySenateItemsEN = new clsvMicroteachCaseQuantitySenateItemsEN();
try
{
objvMicroteachCaseQuantitySenateItemsEN.IdmicroteachCaseQuantitySenateItem = Int32.Parse(objRow[convMicroteachCaseQuantitySenateItems.IdmicroteachCaseQuantitySenateItem].ToString().Trim()); //微格量化评价指标流水号
objvMicroteachCaseQuantitySenateItemsEN.IdmicroteachCaseQuantitySenate = Int32.Parse(objRow[convMicroteachCaseQuantitySenateItems.IdmicroteachCaseQuantitySenate].ToString().Trim()); //微格量化评价流水号
objvMicroteachCaseQuantitySenateItemsEN.IdMicroteachCase = objRow[convMicroteachCaseQuantitySenateItems.IdMicroteachCase].ToString().Trim(); //微格教学案例流水号
objvMicroteachCaseQuantitySenateItemsEN.MicroteachCaseID = objRow[convMicroteachCaseQuantitySenateItems.MicroteachCaseID] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.MicroteachCaseID].ToString().Trim(); //微格教学案例ID
objvMicroteachCaseQuantitySenateItemsEN.MicroteachCaseName = objRow[convMicroteachCaseQuantitySenateItems.MicroteachCaseName] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.MicroteachCaseName].ToString().Trim(); //微格教学案例名称
objvMicroteachCaseQuantitySenateItemsEN.IdSenateGaugeItem = objRow[convMicroteachCaseQuantitySenateItems.IdSenateGaugeItem].ToString().Trim(); //量表指标流水号
objvMicroteachCaseQuantitySenateItemsEN.senateGaugeItemID = objRow[convMicroteachCaseQuantitySenateItems.senateGaugeItemID] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.senateGaugeItemID].ToString().Trim(); //量表指标ID
objvMicroteachCaseQuantitySenateItemsEN.senateGaugeItemName = objRow[convMicroteachCaseQuantitySenateItems.senateGaugeItemName] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.senateGaugeItemName].ToString().Trim(); //量表指标名称
objvMicroteachCaseQuantitySenateItemsEN.senateGaugeItemNameWithOrder = objRow[convMicroteachCaseQuantitySenateItems.senateGaugeItemNameWithOrder] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.senateGaugeItemNameWithOrder].ToString().Trim(); //量表指标名称WithOrder
objvMicroteachCaseQuantitySenateItemsEN.senateGaugeItemDesc = objRow[convMicroteachCaseQuantitySenateItems.senateGaugeItemDesc] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.senateGaugeItemDesc].ToString().Trim(); //量表指标说明
objvMicroteachCaseQuantitySenateItemsEN.senateGaugeItemMemo = objRow[convMicroteachCaseQuantitySenateItems.senateGaugeItemMemo] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.senateGaugeItemMemo].ToString().Trim(); //备注
objvMicroteachCaseQuantitySenateItemsEN.senateGaugeItemWeight = objRow[convMicroteachCaseQuantitySenateItems.senateGaugeItemWeight] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convMicroteachCaseQuantitySenateItems.senateGaugeItemWeight].ToString().Trim()); //量表指标权重
objvMicroteachCaseQuantitySenateItemsEN.SenateScore = objRow[convMicroteachCaseQuantitySenateItems.SenateScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convMicroteachCaseQuantitySenateItems.SenateScore].ToString().Trim()); //指标得分
objvMicroteachCaseQuantitySenateItemsEN.IdSenateGaugeSubItem = objRow[convMicroteachCaseQuantitySenateItems.IdSenateGaugeSubItem] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.IdSenateGaugeSubItem].ToString().Trim(); //量表指标子项流水号
objvMicroteachCaseQuantitySenateItemsEN.senateGaugeSubItemID = objRow[convMicroteachCaseQuantitySenateItems.senateGaugeSubItemID] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.senateGaugeSubItemID].ToString().Trim(); //量表指标子项ID
objvMicroteachCaseQuantitySenateItemsEN.senateGaugeSubItemName = objRow[convMicroteachCaseQuantitySenateItems.senateGaugeSubItemName] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.senateGaugeSubItemName].ToString().Trim(); //量表指标子项名称
objvMicroteachCaseQuantitySenateItemsEN.senateGaugeSubItemDesc = objRow[convMicroteachCaseQuantitySenateItems.senateGaugeSubItemDesc] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.senateGaugeSubItemDesc].ToString().Trim(); //量表指标子项说明
objvMicroteachCaseQuantitySenateItemsEN.senateGaugeSubItemMemo = objRow[convMicroteachCaseQuantitySenateItems.senateGaugeSubItemMemo] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.senateGaugeSubItemMemo].ToString().Trim(); //量表指标子项备注
objvMicroteachCaseQuantitySenateItemsEN.senateGaugeSubItemScore = objRow[convMicroteachCaseQuantitySenateItems.senateGaugeSubItemScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convMicroteachCaseQuantitySenateItems.senateGaugeSubItemScore].ToString().Trim()); //量表指标子项分数
objvMicroteachCaseQuantitySenateItemsEN.UserId = objRow[convMicroteachCaseQuantitySenateItems.UserId] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.UserId].ToString().Trim(); //用户ID
objvMicroteachCaseQuantitySenateItemsEN.UserName = objRow[convMicroteachCaseQuantitySenateItems.UserName] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.UserName].ToString().Trim(); //用户名
objvMicroteachCaseQuantitySenateItemsEN.CollegeID = objRow[convMicroteachCaseQuantitySenateItems.CollegeID] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.CollegeID].ToString().Trim(); //学院ID
objvMicroteachCaseQuantitySenateItemsEN.CollegeName = objRow[convMicroteachCaseQuantitySenateItems.CollegeName] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.CollegeName].ToString().Trim(); //学院名称
objvMicroteachCaseQuantitySenateItemsEN.SenateTheme = objRow[convMicroteachCaseQuantitySenateItems.SenateTheme] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.SenateTheme].ToString().Trim(); //量化评价主题
objvMicroteachCaseQuantitySenateItemsEN.SenateContent = objRow[convMicroteachCaseQuantitySenateItems.SenateContent] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.SenateContent].ToString().Trim(); //评价内容
objvMicroteachCaseQuantitySenateItemsEN.SenateDate = objRow[convMicroteachCaseQuantitySenateItems.SenateDate] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.SenateDate].ToString().Trim(); //评价日期
objvMicroteachCaseQuantitySenateItemsEN.SenateTime = objRow[convMicroteachCaseQuantitySenateItems.SenateTime] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.SenateTime].ToString().Trim(); //评价时间
objvMicroteachCaseQuantitySenateItemsEN.SenateTotalScore = objRow[convMicroteachCaseQuantitySenateItems.SenateTotalScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convMicroteachCaseQuantitySenateItems.SenateTotalScore].ToString().Trim()); //评价分数
objvMicroteachCaseQuantitySenateItemsEN.AnswerModeId = objRow[convMicroteachCaseQuantitySenateItems.AnswerModeId] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.AnswerModeId].ToString().Trim(); //答案模式Id
objvMicroteachCaseQuantitySenateItemsEN.AnswerTypeId = objRow[convMicroteachCaseQuantitySenateItems.AnswerTypeId] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.AnswerTypeId].ToString().Trim(); //答案类型ID
objvMicroteachCaseQuantitySenateItemsEN.GridTitle = objRow[convMicroteachCaseQuantitySenateItems.GridTitle] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.GridTitle].ToString().Trim(); //表格标题
objvMicroteachCaseQuantitySenateItemsEN.QuestionIndex = objRow[convMicroteachCaseQuantitySenateItems.QuestionIndex] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convMicroteachCaseQuantitySenateItems.QuestionIndex].ToString().Trim()); //题目序号
objvMicroteachCaseQuantitySenateItemsEN.QuestionNo = objRow[convMicroteachCaseQuantitySenateItems.QuestionNo] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.QuestionNo].ToString().Trim(); //题目编号
objvMicroteachCaseQuantitySenateItemsEN.QuestionTypeId = objRow[convMicroteachCaseQuantitySenateItems.QuestionTypeId] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.QuestionTypeId].ToString().Trim(); //题目类型Id
objvMicroteachCaseQuantitySenateItemsEN.AnswerModeName = objRow[convMicroteachCaseQuantitySenateItems.AnswerModeName] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.AnswerModeName].ToString().Trim(); //答案模式名称
objvMicroteachCaseQuantitySenateItemsEN.AnswerNum = objRow[convMicroteachCaseQuantitySenateItems.AnswerNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convMicroteachCaseQuantitySenateItems.AnswerNum].ToString().Trim()); //答案数
objvMicroteachCaseQuantitySenateItemsEN.AnswerTypeName = objRow[convMicroteachCaseQuantitySenateItems.AnswerTypeName] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.AnswerTypeName].ToString().Trim(); //答案类型名
objvMicroteachCaseQuantitySenateItemsEN.QuestionTypeName = objRow[convMicroteachCaseQuantitySenateItems.QuestionTypeName] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.QuestionTypeName].ToString().Trim(); //题目类型名
objvMicroteachCaseQuantitySenateItemsEN.senateGaugeVersionID = objRow[convMicroteachCaseQuantitySenateItems.senateGaugeVersionID] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.senateGaugeVersionID].ToString().Trim(); //评价量表版本ID
objvMicroteachCaseQuantitySenateItemsEN.senateGaugeVersionName = objRow[convMicroteachCaseQuantitySenateItems.senateGaugeVersionName] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称
objvMicroteachCaseQuantitySenateItemsEN.senateGaugeVersionTtlScore = objRow[convMicroteachCaseQuantitySenateItems.senateGaugeVersionTtlScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convMicroteachCaseQuantitySenateItems.senateGaugeVersionTtlScore].ToString().Trim()); //评价量表版本总分
objvMicroteachCaseQuantitySenateItemsEN.IdSenateGaugeVersion = objRow[convMicroteachCaseQuantitySenateItems.IdSenateGaugeVersion].ToString().Trim(); //评价量表版本流水号
objvMicroteachCaseQuantitySenateItemsEN.AnswerIndex = objRow[convMicroteachCaseQuantitySenateItems.AnswerIndex] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convMicroteachCaseQuantitySenateItems.AnswerIndex].ToString().Trim()); //问答序号
objvMicroteachCaseQuantitySenateItemsEN.AnswerTitle = objRow[convMicroteachCaseQuantitySenateItems.AnswerTitle] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.AnswerTitle].ToString().Trim(); //答案标题
objvMicroteachCaseQuantitySenateItemsEN.OwnerId = objRow[convMicroteachCaseQuantitySenateItems.OwnerId] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.OwnerId].ToString().Trim(); //拥有者Id
objvMicroteachCaseQuantitySenateItemsEN.OwnerName = objRow[convMicroteachCaseQuantitySenateItems.OwnerName] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.OwnerName].ToString().Trim(); //拥有者姓名
objvMicroteachCaseQuantitySenateItemsEN.OwnerNameWithId = objRow[convMicroteachCaseQuantitySenateItems.OwnerNameWithId] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.OwnerNameWithId].ToString().Trim(); //拥有者名称附Id
objvMicroteachCaseQuantitySenateItemsEN.SenateIp = objRow[convMicroteachCaseQuantitySenateItems.SenateIp] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.SenateIp].ToString().Trim(); //评议Ip
objvMicroteachCaseQuantitySenateItemsEN.UserNameWithUserId = objRow[convMicroteachCaseQuantitySenateItems.UserNameWithUserId] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.UserNameWithUserId].ToString().Trim(); //UserNameWithUserId
objvMicroteachCaseQuantitySenateItemsEN.UserTypeId = objRow[convMicroteachCaseQuantitySenateItems.UserTypeId] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.UserTypeId].ToString().Trim(); //用户类型Id
objvMicroteachCaseQuantitySenateItemsEN.IsAccess = clsEntityBase2.TransNullToBool_S(objRow[convMicroteachCaseQuantitySenateItems.IsAccess].ToString().Trim()); //IsAccess
objvMicroteachCaseQuantitySenateItemsEN.IsAccessC = clsEntityBase2.TransNullToBool_S(objRow[convMicroteachCaseQuantitySenateItems.IsAccessC].ToString().Trim()); //IsAccessC
objvMicroteachCaseQuantitySenateItemsEN.UpdDate = objRow[convMicroteachCaseQuantitySenateItems.UpdDate] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.UpdDate].ToString().Trim(); //修改日期
objvMicroteachCaseQuantitySenateItemsEN.UpdUser = objRow[convMicroteachCaseQuantitySenateItems.UpdUser] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.UpdUser].ToString().Trim(); //修改人
objvMicroteachCaseQuantitySenateItemsEN.IdAppraiseType = objRow[convMicroteachCaseQuantitySenateItems.IdAppraiseType] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.IdAppraiseType].ToString().Trim(); //评议类型流水号
objvMicroteachCaseQuantitySenateItemsEN.AppraiseTypeName = objRow[convMicroteachCaseQuantitySenateItems.AppraiseTypeName] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.AppraiseTypeName].ToString().Trim(); //评议类型名称
objvMicroteachCaseQuantitySenateItemsEN.FuncModuleId = objRow[convMicroteachCaseQuantitySenateItems.FuncModuleId] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.FuncModuleId].ToString().Trim(); //功能模块Id
objvMicroteachCaseQuantitySenateItemsEN.UserKindId = objRow[convMicroteachCaseQuantitySenateItems.UserKindId] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.UserKindId].ToString().Trim(); //用户类别Id
objvMicroteachCaseQuantitySenateItemsEN.UserKindName = objRow[convMicroteachCaseQuantitySenateItems.UserKindName] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.UserKindName].ToString().Trim(); //用户类别名
objvMicroteachCaseQuantitySenateItemsEN.UserTypeName = objRow[convMicroteachCaseQuantitySenateItems.UserTypeName] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.UserTypeName].ToString().Trim(); //用户类型名称
objvMicroteachCaseQuantitySenateItemsEN.FuncModuleName = objRow[convMicroteachCaseQuantitySenateItems.FuncModuleName] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.FuncModuleName].ToString().Trim(); //功能模块名称
objvMicroteachCaseQuantitySenateItemsEN.IdXzCollege = objRow[convMicroteachCaseQuantitySenateItems.IdXzCollege] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.IdXzCollege].ToString().Trim(); //学院流水号
objvMicroteachCaseQuantitySenateItemsEN.CollegeNameA = objRow[convMicroteachCaseQuantitySenateItems.CollegeNameA] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.CollegeNameA].ToString().Trim(); //学院名称简写
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvMicroteachCaseQuantitySenateItemsEN.IdmicroteachCaseQuantitySenateItem, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvMicroteachCaseQuantitySenateItemsEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrIdmicroteachCaseQuantitySenateItemLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsvMicroteachCaseQuantitySenateItemsEN> GetObjLstByIdmicroteachCaseQuantitySenateItemLstCache(List<long> arrIdmicroteachCaseQuantitySenateItemLst)
{
string strKey = string.Format("{0}", clsvMicroteachCaseQuantitySenateItemsEN._CurrTabName);
List<clsvMicroteachCaseQuantitySenateItemsEN> arrvMicroteachCaseQuantitySenateItemsObjLstCache = GetObjLstCache();
IEnumerable <clsvMicroteachCaseQuantitySenateItemsEN> arrvMicroteachCaseQuantitySenateItemsObjLst_Sel =
arrvMicroteachCaseQuantitySenateItemsObjLstCache
.Where(x => arrIdmicroteachCaseQuantitySenateItemLst.Contains(x.IdmicroteachCaseQuantitySenateItem));
return arrvMicroteachCaseQuantitySenateItemsObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvMicroteachCaseQuantitySenateItemsEN> GetObjLst(string strWhereCond)
{
List<clsvMicroteachCaseQuantitySenateItemsEN> arrObjLst = new List<clsvMicroteachCaseQuantitySenateItemsEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvMicroteachCaseQuantitySenateItemsEN objvMicroteachCaseQuantitySenateItemsEN = new clsvMicroteachCaseQuantitySenateItemsEN();
try
{
objvMicroteachCaseQuantitySenateItemsEN.IdmicroteachCaseQuantitySenateItem = Int32.Parse(objRow[convMicroteachCaseQuantitySenateItems.IdmicroteachCaseQuantitySenateItem].ToString().Trim()); //微格量化评价指标流水号
objvMicroteachCaseQuantitySenateItemsEN.IdmicroteachCaseQuantitySenate = Int32.Parse(objRow[convMicroteachCaseQuantitySenateItems.IdmicroteachCaseQuantitySenate].ToString().Trim()); //微格量化评价流水号
objvMicroteachCaseQuantitySenateItemsEN.IdMicroteachCase = objRow[convMicroteachCaseQuantitySenateItems.IdMicroteachCase].ToString().Trim(); //微格教学案例流水号
objvMicroteachCaseQuantitySenateItemsEN.MicroteachCaseID = objRow[convMicroteachCaseQuantitySenateItems.MicroteachCaseID] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.MicroteachCaseID].ToString().Trim(); //微格教学案例ID
objvMicroteachCaseQuantitySenateItemsEN.MicroteachCaseName = objRow[convMicroteachCaseQuantitySenateItems.MicroteachCaseName] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.MicroteachCaseName].ToString().Trim(); //微格教学案例名称
objvMicroteachCaseQuantitySenateItemsEN.IdSenateGaugeItem = objRow[convMicroteachCaseQuantitySenateItems.IdSenateGaugeItem].ToString().Trim(); //量表指标流水号
objvMicroteachCaseQuantitySenateItemsEN.senateGaugeItemID = objRow[convMicroteachCaseQuantitySenateItems.senateGaugeItemID] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.senateGaugeItemID].ToString().Trim(); //量表指标ID
objvMicroteachCaseQuantitySenateItemsEN.senateGaugeItemName = objRow[convMicroteachCaseQuantitySenateItems.senateGaugeItemName] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.senateGaugeItemName].ToString().Trim(); //量表指标名称
objvMicroteachCaseQuantitySenateItemsEN.senateGaugeItemNameWithOrder = objRow[convMicroteachCaseQuantitySenateItems.senateGaugeItemNameWithOrder] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.senateGaugeItemNameWithOrder].ToString().Trim(); //量表指标名称WithOrder
objvMicroteachCaseQuantitySenateItemsEN.senateGaugeItemDesc = objRow[convMicroteachCaseQuantitySenateItems.senateGaugeItemDesc] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.senateGaugeItemDesc].ToString().Trim(); //量表指标说明
objvMicroteachCaseQuantitySenateItemsEN.senateGaugeItemMemo = objRow[convMicroteachCaseQuantitySenateItems.senateGaugeItemMemo] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.senateGaugeItemMemo].ToString().Trim(); //备注
objvMicroteachCaseQuantitySenateItemsEN.senateGaugeItemWeight = objRow[convMicroteachCaseQuantitySenateItems.senateGaugeItemWeight] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convMicroteachCaseQuantitySenateItems.senateGaugeItemWeight].ToString().Trim()); //量表指标权重
objvMicroteachCaseQuantitySenateItemsEN.SenateScore = objRow[convMicroteachCaseQuantitySenateItems.SenateScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convMicroteachCaseQuantitySenateItems.SenateScore].ToString().Trim()); //指标得分
objvMicroteachCaseQuantitySenateItemsEN.IdSenateGaugeSubItem = objRow[convMicroteachCaseQuantitySenateItems.IdSenateGaugeSubItem] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.IdSenateGaugeSubItem].ToString().Trim(); //量表指标子项流水号
objvMicroteachCaseQuantitySenateItemsEN.senateGaugeSubItemID = objRow[convMicroteachCaseQuantitySenateItems.senateGaugeSubItemID] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.senateGaugeSubItemID].ToString().Trim(); //量表指标子项ID
objvMicroteachCaseQuantitySenateItemsEN.senateGaugeSubItemName = objRow[convMicroteachCaseQuantitySenateItems.senateGaugeSubItemName] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.senateGaugeSubItemName].ToString().Trim(); //量表指标子项名称
objvMicroteachCaseQuantitySenateItemsEN.senateGaugeSubItemDesc = objRow[convMicroteachCaseQuantitySenateItems.senateGaugeSubItemDesc] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.senateGaugeSubItemDesc].ToString().Trim(); //量表指标子项说明
objvMicroteachCaseQuantitySenateItemsEN.senateGaugeSubItemMemo = objRow[convMicroteachCaseQuantitySenateItems.senateGaugeSubItemMemo] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.senateGaugeSubItemMemo].ToString().Trim(); //量表指标子项备注
objvMicroteachCaseQuantitySenateItemsEN.senateGaugeSubItemScore = objRow[convMicroteachCaseQuantitySenateItems.senateGaugeSubItemScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convMicroteachCaseQuantitySenateItems.senateGaugeSubItemScore].ToString().Trim()); //量表指标子项分数
objvMicroteachCaseQuantitySenateItemsEN.UserId = objRow[convMicroteachCaseQuantitySenateItems.UserId] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.UserId].ToString().Trim(); //用户ID
objvMicroteachCaseQuantitySenateItemsEN.UserName = objRow[convMicroteachCaseQuantitySenateItems.UserName] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.UserName].ToString().Trim(); //用户名
objvMicroteachCaseQuantitySenateItemsEN.CollegeID = objRow[convMicroteachCaseQuantitySenateItems.CollegeID] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.CollegeID].ToString().Trim(); //学院ID
objvMicroteachCaseQuantitySenateItemsEN.CollegeName = objRow[convMicroteachCaseQuantitySenateItems.CollegeName] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.CollegeName].ToString().Trim(); //学院名称
objvMicroteachCaseQuantitySenateItemsEN.SenateTheme = objRow[convMicroteachCaseQuantitySenateItems.SenateTheme] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.SenateTheme].ToString().Trim(); //量化评价主题
objvMicroteachCaseQuantitySenateItemsEN.SenateContent = objRow[convMicroteachCaseQuantitySenateItems.SenateContent] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.SenateContent].ToString().Trim(); //评价内容
objvMicroteachCaseQuantitySenateItemsEN.SenateDate = objRow[convMicroteachCaseQuantitySenateItems.SenateDate] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.SenateDate].ToString().Trim(); //评价日期
objvMicroteachCaseQuantitySenateItemsEN.SenateTime = objRow[convMicroteachCaseQuantitySenateItems.SenateTime] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.SenateTime].ToString().Trim(); //评价时间
objvMicroteachCaseQuantitySenateItemsEN.SenateTotalScore = objRow[convMicroteachCaseQuantitySenateItems.SenateTotalScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convMicroteachCaseQuantitySenateItems.SenateTotalScore].ToString().Trim()); //评价分数
objvMicroteachCaseQuantitySenateItemsEN.AnswerModeId = objRow[convMicroteachCaseQuantitySenateItems.AnswerModeId] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.AnswerModeId].ToString().Trim(); //答案模式Id
objvMicroteachCaseQuantitySenateItemsEN.AnswerTypeId = objRow[convMicroteachCaseQuantitySenateItems.AnswerTypeId] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.AnswerTypeId].ToString().Trim(); //答案类型ID
objvMicroteachCaseQuantitySenateItemsEN.GridTitle = objRow[convMicroteachCaseQuantitySenateItems.GridTitle] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.GridTitle].ToString().Trim(); //表格标题
objvMicroteachCaseQuantitySenateItemsEN.QuestionIndex = objRow[convMicroteachCaseQuantitySenateItems.QuestionIndex] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convMicroteachCaseQuantitySenateItems.QuestionIndex].ToString().Trim()); //题目序号
objvMicroteachCaseQuantitySenateItemsEN.QuestionNo = objRow[convMicroteachCaseQuantitySenateItems.QuestionNo] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.QuestionNo].ToString().Trim(); //题目编号
objvMicroteachCaseQuantitySenateItemsEN.QuestionTypeId = objRow[convMicroteachCaseQuantitySenateItems.QuestionTypeId] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.QuestionTypeId].ToString().Trim(); //题目类型Id
objvMicroteachCaseQuantitySenateItemsEN.AnswerModeName = objRow[convMicroteachCaseQuantitySenateItems.AnswerModeName] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.AnswerModeName].ToString().Trim(); //答案模式名称
objvMicroteachCaseQuantitySenateItemsEN.AnswerNum = objRow[convMicroteachCaseQuantitySenateItems.AnswerNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convMicroteachCaseQuantitySenateItems.AnswerNum].ToString().Trim()); //答案数
objvMicroteachCaseQuantitySenateItemsEN.AnswerTypeName = objRow[convMicroteachCaseQuantitySenateItems.AnswerTypeName] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.AnswerTypeName].ToString().Trim(); //答案类型名
objvMicroteachCaseQuantitySenateItemsEN.QuestionTypeName = objRow[convMicroteachCaseQuantitySenateItems.QuestionTypeName] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.QuestionTypeName].ToString().Trim(); //题目类型名
objvMicroteachCaseQuantitySenateItemsEN.senateGaugeVersionID = objRow[convMicroteachCaseQuantitySenateItems.senateGaugeVersionID] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.senateGaugeVersionID].ToString().Trim(); //评价量表版本ID
objvMicroteachCaseQuantitySenateItemsEN.senateGaugeVersionName = objRow[convMicroteachCaseQuantitySenateItems.senateGaugeVersionName] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称
objvMicroteachCaseQuantitySenateItemsEN.senateGaugeVersionTtlScore = objRow[convMicroteachCaseQuantitySenateItems.senateGaugeVersionTtlScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convMicroteachCaseQuantitySenateItems.senateGaugeVersionTtlScore].ToString().Trim()); //评价量表版本总分
objvMicroteachCaseQuantitySenateItemsEN.IdSenateGaugeVersion = objRow[convMicroteachCaseQuantitySenateItems.IdSenateGaugeVersion].ToString().Trim(); //评价量表版本流水号
objvMicroteachCaseQuantitySenateItemsEN.AnswerIndex = objRow[convMicroteachCaseQuantitySenateItems.AnswerIndex] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convMicroteachCaseQuantitySenateItems.AnswerIndex].ToString().Trim()); //问答序号
objvMicroteachCaseQuantitySenateItemsEN.AnswerTitle = objRow[convMicroteachCaseQuantitySenateItems.AnswerTitle] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.AnswerTitle].ToString().Trim(); //答案标题
objvMicroteachCaseQuantitySenateItemsEN.OwnerId = objRow[convMicroteachCaseQuantitySenateItems.OwnerId] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.OwnerId].ToString().Trim(); //拥有者Id
objvMicroteachCaseQuantitySenateItemsEN.OwnerName = objRow[convMicroteachCaseQuantitySenateItems.OwnerName] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.OwnerName].ToString().Trim(); //拥有者姓名
objvMicroteachCaseQuantitySenateItemsEN.OwnerNameWithId = objRow[convMicroteachCaseQuantitySenateItems.OwnerNameWithId] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.OwnerNameWithId].ToString().Trim(); //拥有者名称附Id
objvMicroteachCaseQuantitySenateItemsEN.SenateIp = objRow[convMicroteachCaseQuantitySenateItems.SenateIp] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.SenateIp].ToString().Trim(); //评议Ip
objvMicroteachCaseQuantitySenateItemsEN.UserNameWithUserId = objRow[convMicroteachCaseQuantitySenateItems.UserNameWithUserId] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.UserNameWithUserId].ToString().Trim(); //UserNameWithUserId
objvMicroteachCaseQuantitySenateItemsEN.UserTypeId = objRow[convMicroteachCaseQuantitySenateItems.UserTypeId] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.UserTypeId].ToString().Trim(); //用户类型Id
objvMicroteachCaseQuantitySenateItemsEN.IsAccess = clsEntityBase2.TransNullToBool_S(objRow[convMicroteachCaseQuantitySenateItems.IsAccess].ToString().Trim()); //IsAccess
objvMicroteachCaseQuantitySenateItemsEN.IsAccessC = clsEntityBase2.TransNullToBool_S(objRow[convMicroteachCaseQuantitySenateItems.IsAccessC].ToString().Trim()); //IsAccessC
objvMicroteachCaseQuantitySenateItemsEN.UpdDate = objRow[convMicroteachCaseQuantitySenateItems.UpdDate] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.UpdDate].ToString().Trim(); //修改日期
objvMicroteachCaseQuantitySenateItemsEN.UpdUser = objRow[convMicroteachCaseQuantitySenateItems.UpdUser] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.UpdUser].ToString().Trim(); //修改人
objvMicroteachCaseQuantitySenateItemsEN.IdAppraiseType = objRow[convMicroteachCaseQuantitySenateItems.IdAppraiseType] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.IdAppraiseType].ToString().Trim(); //评议类型流水号
objvMicroteachCaseQuantitySenateItemsEN.AppraiseTypeName = objRow[convMicroteachCaseQuantitySenateItems.AppraiseTypeName] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.AppraiseTypeName].ToString().Trim(); //评议类型名称
objvMicroteachCaseQuantitySenateItemsEN.FuncModuleId = objRow[convMicroteachCaseQuantitySenateItems.FuncModuleId] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.FuncModuleId].ToString().Trim(); //功能模块Id
objvMicroteachCaseQuantitySenateItemsEN.UserKindId = objRow[convMicroteachCaseQuantitySenateItems.UserKindId] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.UserKindId].ToString().Trim(); //用户类别Id
objvMicroteachCaseQuantitySenateItemsEN.UserKindName = objRow[convMicroteachCaseQuantitySenateItems.UserKindName] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.UserKindName].ToString().Trim(); //用户类别名
objvMicroteachCaseQuantitySenateItemsEN.UserTypeName = objRow[convMicroteachCaseQuantitySenateItems.UserTypeName] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.UserTypeName].ToString().Trim(); //用户类型名称
objvMicroteachCaseQuantitySenateItemsEN.FuncModuleName = objRow[convMicroteachCaseQuantitySenateItems.FuncModuleName] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.FuncModuleName].ToString().Trim(); //功能模块名称
objvMicroteachCaseQuantitySenateItemsEN.IdXzCollege = objRow[convMicroteachCaseQuantitySenateItems.IdXzCollege] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.IdXzCollege].ToString().Trim(); //学院流水号
objvMicroteachCaseQuantitySenateItemsEN.CollegeNameA = objRow[convMicroteachCaseQuantitySenateItems.CollegeNameA] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.CollegeNameA].ToString().Trim(); //学院名称简写
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvMicroteachCaseQuantitySenateItemsEN.IdmicroteachCaseQuantitySenateItem, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvMicroteachCaseQuantitySenateItemsEN);
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
public static List<clsvMicroteachCaseQuantitySenateItemsEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsvMicroteachCaseQuantitySenateItemsEN> arrObjLst = new List<clsvMicroteachCaseQuantitySenateItemsEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvMicroteachCaseQuantitySenateItemsEN objvMicroteachCaseQuantitySenateItemsEN = new clsvMicroteachCaseQuantitySenateItemsEN();
try
{
objvMicroteachCaseQuantitySenateItemsEN.IdmicroteachCaseQuantitySenateItem = Int32.Parse(objRow[convMicroteachCaseQuantitySenateItems.IdmicroteachCaseQuantitySenateItem].ToString().Trim()); //微格量化评价指标流水号
objvMicroteachCaseQuantitySenateItemsEN.IdmicroteachCaseQuantitySenate = Int32.Parse(objRow[convMicroteachCaseQuantitySenateItems.IdmicroteachCaseQuantitySenate].ToString().Trim()); //微格量化评价流水号
objvMicroteachCaseQuantitySenateItemsEN.IdMicroteachCase = objRow[convMicroteachCaseQuantitySenateItems.IdMicroteachCase].ToString().Trim(); //微格教学案例流水号
objvMicroteachCaseQuantitySenateItemsEN.MicroteachCaseID = objRow[convMicroteachCaseQuantitySenateItems.MicroteachCaseID] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.MicroteachCaseID].ToString().Trim(); //微格教学案例ID
objvMicroteachCaseQuantitySenateItemsEN.MicroteachCaseName = objRow[convMicroteachCaseQuantitySenateItems.MicroteachCaseName] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.MicroteachCaseName].ToString().Trim(); //微格教学案例名称
objvMicroteachCaseQuantitySenateItemsEN.IdSenateGaugeItem = objRow[convMicroteachCaseQuantitySenateItems.IdSenateGaugeItem].ToString().Trim(); //量表指标流水号
objvMicroteachCaseQuantitySenateItemsEN.senateGaugeItemID = objRow[convMicroteachCaseQuantitySenateItems.senateGaugeItemID] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.senateGaugeItemID].ToString().Trim(); //量表指标ID
objvMicroteachCaseQuantitySenateItemsEN.senateGaugeItemName = objRow[convMicroteachCaseQuantitySenateItems.senateGaugeItemName] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.senateGaugeItemName].ToString().Trim(); //量表指标名称
objvMicroteachCaseQuantitySenateItemsEN.senateGaugeItemNameWithOrder = objRow[convMicroteachCaseQuantitySenateItems.senateGaugeItemNameWithOrder] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.senateGaugeItemNameWithOrder].ToString().Trim(); //量表指标名称WithOrder
objvMicroteachCaseQuantitySenateItemsEN.senateGaugeItemDesc = objRow[convMicroteachCaseQuantitySenateItems.senateGaugeItemDesc] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.senateGaugeItemDesc].ToString().Trim(); //量表指标说明
objvMicroteachCaseQuantitySenateItemsEN.senateGaugeItemMemo = objRow[convMicroteachCaseQuantitySenateItems.senateGaugeItemMemo] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.senateGaugeItemMemo].ToString().Trim(); //备注
objvMicroteachCaseQuantitySenateItemsEN.senateGaugeItemWeight = objRow[convMicroteachCaseQuantitySenateItems.senateGaugeItemWeight] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convMicroteachCaseQuantitySenateItems.senateGaugeItemWeight].ToString().Trim()); //量表指标权重
objvMicroteachCaseQuantitySenateItemsEN.SenateScore = objRow[convMicroteachCaseQuantitySenateItems.SenateScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convMicroteachCaseQuantitySenateItems.SenateScore].ToString().Trim()); //指标得分
objvMicroteachCaseQuantitySenateItemsEN.IdSenateGaugeSubItem = objRow[convMicroteachCaseQuantitySenateItems.IdSenateGaugeSubItem] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.IdSenateGaugeSubItem].ToString().Trim(); //量表指标子项流水号
objvMicroteachCaseQuantitySenateItemsEN.senateGaugeSubItemID = objRow[convMicroteachCaseQuantitySenateItems.senateGaugeSubItemID] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.senateGaugeSubItemID].ToString().Trim(); //量表指标子项ID
objvMicroteachCaseQuantitySenateItemsEN.senateGaugeSubItemName = objRow[convMicroteachCaseQuantitySenateItems.senateGaugeSubItemName] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.senateGaugeSubItemName].ToString().Trim(); //量表指标子项名称
objvMicroteachCaseQuantitySenateItemsEN.senateGaugeSubItemDesc = objRow[convMicroteachCaseQuantitySenateItems.senateGaugeSubItemDesc] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.senateGaugeSubItemDesc].ToString().Trim(); //量表指标子项说明
objvMicroteachCaseQuantitySenateItemsEN.senateGaugeSubItemMemo = objRow[convMicroteachCaseQuantitySenateItems.senateGaugeSubItemMemo] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.senateGaugeSubItemMemo].ToString().Trim(); //量表指标子项备注
objvMicroteachCaseQuantitySenateItemsEN.senateGaugeSubItemScore = objRow[convMicroteachCaseQuantitySenateItems.senateGaugeSubItemScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convMicroteachCaseQuantitySenateItems.senateGaugeSubItemScore].ToString().Trim()); //量表指标子项分数
objvMicroteachCaseQuantitySenateItemsEN.UserId = objRow[convMicroteachCaseQuantitySenateItems.UserId] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.UserId].ToString().Trim(); //用户ID
objvMicroteachCaseQuantitySenateItemsEN.UserName = objRow[convMicroteachCaseQuantitySenateItems.UserName] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.UserName].ToString().Trim(); //用户名
objvMicroteachCaseQuantitySenateItemsEN.CollegeID = objRow[convMicroteachCaseQuantitySenateItems.CollegeID] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.CollegeID].ToString().Trim(); //学院ID
objvMicroteachCaseQuantitySenateItemsEN.CollegeName = objRow[convMicroteachCaseQuantitySenateItems.CollegeName] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.CollegeName].ToString().Trim(); //学院名称
objvMicroteachCaseQuantitySenateItemsEN.SenateTheme = objRow[convMicroteachCaseQuantitySenateItems.SenateTheme] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.SenateTheme].ToString().Trim(); //量化评价主题
objvMicroteachCaseQuantitySenateItemsEN.SenateContent = objRow[convMicroteachCaseQuantitySenateItems.SenateContent] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.SenateContent].ToString().Trim(); //评价内容
objvMicroteachCaseQuantitySenateItemsEN.SenateDate = objRow[convMicroteachCaseQuantitySenateItems.SenateDate] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.SenateDate].ToString().Trim(); //评价日期
objvMicroteachCaseQuantitySenateItemsEN.SenateTime = objRow[convMicroteachCaseQuantitySenateItems.SenateTime] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.SenateTime].ToString().Trim(); //评价时间
objvMicroteachCaseQuantitySenateItemsEN.SenateTotalScore = objRow[convMicroteachCaseQuantitySenateItems.SenateTotalScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convMicroteachCaseQuantitySenateItems.SenateTotalScore].ToString().Trim()); //评价分数
objvMicroteachCaseQuantitySenateItemsEN.AnswerModeId = objRow[convMicroteachCaseQuantitySenateItems.AnswerModeId] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.AnswerModeId].ToString().Trim(); //答案模式Id
objvMicroteachCaseQuantitySenateItemsEN.AnswerTypeId = objRow[convMicroteachCaseQuantitySenateItems.AnswerTypeId] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.AnswerTypeId].ToString().Trim(); //答案类型ID
objvMicroteachCaseQuantitySenateItemsEN.GridTitle = objRow[convMicroteachCaseQuantitySenateItems.GridTitle] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.GridTitle].ToString().Trim(); //表格标题
objvMicroteachCaseQuantitySenateItemsEN.QuestionIndex = objRow[convMicroteachCaseQuantitySenateItems.QuestionIndex] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convMicroteachCaseQuantitySenateItems.QuestionIndex].ToString().Trim()); //题目序号
objvMicroteachCaseQuantitySenateItemsEN.QuestionNo = objRow[convMicroteachCaseQuantitySenateItems.QuestionNo] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.QuestionNo].ToString().Trim(); //题目编号
objvMicroteachCaseQuantitySenateItemsEN.QuestionTypeId = objRow[convMicroteachCaseQuantitySenateItems.QuestionTypeId] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.QuestionTypeId].ToString().Trim(); //题目类型Id
objvMicroteachCaseQuantitySenateItemsEN.AnswerModeName = objRow[convMicroteachCaseQuantitySenateItems.AnswerModeName] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.AnswerModeName].ToString().Trim(); //答案模式名称
objvMicroteachCaseQuantitySenateItemsEN.AnswerNum = objRow[convMicroteachCaseQuantitySenateItems.AnswerNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convMicroteachCaseQuantitySenateItems.AnswerNum].ToString().Trim()); //答案数
objvMicroteachCaseQuantitySenateItemsEN.AnswerTypeName = objRow[convMicroteachCaseQuantitySenateItems.AnswerTypeName] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.AnswerTypeName].ToString().Trim(); //答案类型名
objvMicroteachCaseQuantitySenateItemsEN.QuestionTypeName = objRow[convMicroteachCaseQuantitySenateItems.QuestionTypeName] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.QuestionTypeName].ToString().Trim(); //题目类型名
objvMicroteachCaseQuantitySenateItemsEN.senateGaugeVersionID = objRow[convMicroteachCaseQuantitySenateItems.senateGaugeVersionID] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.senateGaugeVersionID].ToString().Trim(); //评价量表版本ID
objvMicroteachCaseQuantitySenateItemsEN.senateGaugeVersionName = objRow[convMicroteachCaseQuantitySenateItems.senateGaugeVersionName] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称
objvMicroteachCaseQuantitySenateItemsEN.senateGaugeVersionTtlScore = objRow[convMicroteachCaseQuantitySenateItems.senateGaugeVersionTtlScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convMicroteachCaseQuantitySenateItems.senateGaugeVersionTtlScore].ToString().Trim()); //评价量表版本总分
objvMicroteachCaseQuantitySenateItemsEN.IdSenateGaugeVersion = objRow[convMicroteachCaseQuantitySenateItems.IdSenateGaugeVersion].ToString().Trim(); //评价量表版本流水号
objvMicroteachCaseQuantitySenateItemsEN.AnswerIndex = objRow[convMicroteachCaseQuantitySenateItems.AnswerIndex] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convMicroteachCaseQuantitySenateItems.AnswerIndex].ToString().Trim()); //问答序号
objvMicroteachCaseQuantitySenateItemsEN.AnswerTitle = objRow[convMicroteachCaseQuantitySenateItems.AnswerTitle] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.AnswerTitle].ToString().Trim(); //答案标题
objvMicroteachCaseQuantitySenateItemsEN.OwnerId = objRow[convMicroteachCaseQuantitySenateItems.OwnerId] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.OwnerId].ToString().Trim(); //拥有者Id
objvMicroteachCaseQuantitySenateItemsEN.OwnerName = objRow[convMicroteachCaseQuantitySenateItems.OwnerName] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.OwnerName].ToString().Trim(); //拥有者姓名
objvMicroteachCaseQuantitySenateItemsEN.OwnerNameWithId = objRow[convMicroteachCaseQuantitySenateItems.OwnerNameWithId] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.OwnerNameWithId].ToString().Trim(); //拥有者名称附Id
objvMicroteachCaseQuantitySenateItemsEN.SenateIp = objRow[convMicroteachCaseQuantitySenateItems.SenateIp] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.SenateIp].ToString().Trim(); //评议Ip
objvMicroteachCaseQuantitySenateItemsEN.UserNameWithUserId = objRow[convMicroteachCaseQuantitySenateItems.UserNameWithUserId] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.UserNameWithUserId].ToString().Trim(); //UserNameWithUserId
objvMicroteachCaseQuantitySenateItemsEN.UserTypeId = objRow[convMicroteachCaseQuantitySenateItems.UserTypeId] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.UserTypeId].ToString().Trim(); //用户类型Id
objvMicroteachCaseQuantitySenateItemsEN.IsAccess = clsEntityBase2.TransNullToBool_S(objRow[convMicroteachCaseQuantitySenateItems.IsAccess].ToString().Trim()); //IsAccess
objvMicroteachCaseQuantitySenateItemsEN.IsAccessC = clsEntityBase2.TransNullToBool_S(objRow[convMicroteachCaseQuantitySenateItems.IsAccessC].ToString().Trim()); //IsAccessC
objvMicroteachCaseQuantitySenateItemsEN.UpdDate = objRow[convMicroteachCaseQuantitySenateItems.UpdDate] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.UpdDate].ToString().Trim(); //修改日期
objvMicroteachCaseQuantitySenateItemsEN.UpdUser = objRow[convMicroteachCaseQuantitySenateItems.UpdUser] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.UpdUser].ToString().Trim(); //修改人
objvMicroteachCaseQuantitySenateItemsEN.IdAppraiseType = objRow[convMicroteachCaseQuantitySenateItems.IdAppraiseType] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.IdAppraiseType].ToString().Trim(); //评议类型流水号
objvMicroteachCaseQuantitySenateItemsEN.AppraiseTypeName = objRow[convMicroteachCaseQuantitySenateItems.AppraiseTypeName] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.AppraiseTypeName].ToString().Trim(); //评议类型名称
objvMicroteachCaseQuantitySenateItemsEN.FuncModuleId = objRow[convMicroteachCaseQuantitySenateItems.FuncModuleId] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.FuncModuleId].ToString().Trim(); //功能模块Id
objvMicroteachCaseQuantitySenateItemsEN.UserKindId = objRow[convMicroteachCaseQuantitySenateItems.UserKindId] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.UserKindId].ToString().Trim(); //用户类别Id
objvMicroteachCaseQuantitySenateItemsEN.UserKindName = objRow[convMicroteachCaseQuantitySenateItems.UserKindName] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.UserKindName].ToString().Trim(); //用户类别名
objvMicroteachCaseQuantitySenateItemsEN.UserTypeName = objRow[convMicroteachCaseQuantitySenateItems.UserTypeName] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.UserTypeName].ToString().Trim(); //用户类型名称
objvMicroteachCaseQuantitySenateItemsEN.FuncModuleName = objRow[convMicroteachCaseQuantitySenateItems.FuncModuleName] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.FuncModuleName].ToString().Trim(); //功能模块名称
objvMicroteachCaseQuantitySenateItemsEN.IdXzCollege = objRow[convMicroteachCaseQuantitySenateItems.IdXzCollege] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.IdXzCollege].ToString().Trim(); //学院流水号
objvMicroteachCaseQuantitySenateItemsEN.CollegeNameA = objRow[convMicroteachCaseQuantitySenateItems.CollegeNameA] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.CollegeNameA].ToString().Trim(); //学院名称简写
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvMicroteachCaseQuantitySenateItemsEN.IdmicroteachCaseQuantitySenateItem, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvMicroteachCaseQuantitySenateItemsEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objvMicroteachCaseQuantitySenateItemsCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsvMicroteachCaseQuantitySenateItemsEN> GetSubObjLstCache(clsvMicroteachCaseQuantitySenateItemsEN objvMicroteachCaseQuantitySenateItemsCond)
{
List<clsvMicroteachCaseQuantitySenateItemsEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsvMicroteachCaseQuantitySenateItemsEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convMicroteachCaseQuantitySenateItems.AttributeName)
{
if (objvMicroteachCaseQuantitySenateItemsCond.IsUpdated(strFldName) == false) continue;
if (objvMicroteachCaseQuantitySenateItemsCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvMicroteachCaseQuantitySenateItemsCond[strFldName].ToString());
}
else
{
if (objvMicroteachCaseQuantitySenateItemsCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvMicroteachCaseQuantitySenateItemsCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvMicroteachCaseQuantitySenateItemsCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvMicroteachCaseQuantitySenateItemsCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvMicroteachCaseQuantitySenateItemsCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvMicroteachCaseQuantitySenateItemsCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvMicroteachCaseQuantitySenateItemsCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvMicroteachCaseQuantitySenateItemsCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvMicroteachCaseQuantitySenateItemsCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvMicroteachCaseQuantitySenateItemsCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvMicroteachCaseQuantitySenateItemsCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvMicroteachCaseQuantitySenateItemsCond[strFldName]));
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
public static List<clsvMicroteachCaseQuantitySenateItemsEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsvMicroteachCaseQuantitySenateItemsEN> arrObjLst = new List<clsvMicroteachCaseQuantitySenateItemsEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvMicroteachCaseQuantitySenateItemsEN objvMicroteachCaseQuantitySenateItemsEN = new clsvMicroteachCaseQuantitySenateItemsEN();
try
{
objvMicroteachCaseQuantitySenateItemsEN.IdmicroteachCaseQuantitySenateItem = Int32.Parse(objRow[convMicroteachCaseQuantitySenateItems.IdmicroteachCaseQuantitySenateItem].ToString().Trim()); //微格量化评价指标流水号
objvMicroteachCaseQuantitySenateItemsEN.IdmicroteachCaseQuantitySenate = Int32.Parse(objRow[convMicroteachCaseQuantitySenateItems.IdmicroteachCaseQuantitySenate].ToString().Trim()); //微格量化评价流水号
objvMicroteachCaseQuantitySenateItemsEN.IdMicroteachCase = objRow[convMicroteachCaseQuantitySenateItems.IdMicroteachCase].ToString().Trim(); //微格教学案例流水号
objvMicroteachCaseQuantitySenateItemsEN.MicroteachCaseID = objRow[convMicroteachCaseQuantitySenateItems.MicroteachCaseID] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.MicroteachCaseID].ToString().Trim(); //微格教学案例ID
objvMicroteachCaseQuantitySenateItemsEN.MicroteachCaseName = objRow[convMicroteachCaseQuantitySenateItems.MicroteachCaseName] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.MicroteachCaseName].ToString().Trim(); //微格教学案例名称
objvMicroteachCaseQuantitySenateItemsEN.IdSenateGaugeItem = objRow[convMicroteachCaseQuantitySenateItems.IdSenateGaugeItem].ToString().Trim(); //量表指标流水号
objvMicroteachCaseQuantitySenateItemsEN.senateGaugeItemID = objRow[convMicroteachCaseQuantitySenateItems.senateGaugeItemID] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.senateGaugeItemID].ToString().Trim(); //量表指标ID
objvMicroteachCaseQuantitySenateItemsEN.senateGaugeItemName = objRow[convMicroteachCaseQuantitySenateItems.senateGaugeItemName] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.senateGaugeItemName].ToString().Trim(); //量表指标名称
objvMicroteachCaseQuantitySenateItemsEN.senateGaugeItemNameWithOrder = objRow[convMicroteachCaseQuantitySenateItems.senateGaugeItemNameWithOrder] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.senateGaugeItemNameWithOrder].ToString().Trim(); //量表指标名称WithOrder
objvMicroteachCaseQuantitySenateItemsEN.senateGaugeItemDesc = objRow[convMicroteachCaseQuantitySenateItems.senateGaugeItemDesc] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.senateGaugeItemDesc].ToString().Trim(); //量表指标说明
objvMicroteachCaseQuantitySenateItemsEN.senateGaugeItemMemo = objRow[convMicroteachCaseQuantitySenateItems.senateGaugeItemMemo] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.senateGaugeItemMemo].ToString().Trim(); //备注
objvMicroteachCaseQuantitySenateItemsEN.senateGaugeItemWeight = objRow[convMicroteachCaseQuantitySenateItems.senateGaugeItemWeight] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convMicroteachCaseQuantitySenateItems.senateGaugeItemWeight].ToString().Trim()); //量表指标权重
objvMicroteachCaseQuantitySenateItemsEN.SenateScore = objRow[convMicroteachCaseQuantitySenateItems.SenateScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convMicroteachCaseQuantitySenateItems.SenateScore].ToString().Trim()); //指标得分
objvMicroteachCaseQuantitySenateItemsEN.IdSenateGaugeSubItem = objRow[convMicroteachCaseQuantitySenateItems.IdSenateGaugeSubItem] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.IdSenateGaugeSubItem].ToString().Trim(); //量表指标子项流水号
objvMicroteachCaseQuantitySenateItemsEN.senateGaugeSubItemID = objRow[convMicroteachCaseQuantitySenateItems.senateGaugeSubItemID] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.senateGaugeSubItemID].ToString().Trim(); //量表指标子项ID
objvMicroteachCaseQuantitySenateItemsEN.senateGaugeSubItemName = objRow[convMicroteachCaseQuantitySenateItems.senateGaugeSubItemName] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.senateGaugeSubItemName].ToString().Trim(); //量表指标子项名称
objvMicroteachCaseQuantitySenateItemsEN.senateGaugeSubItemDesc = objRow[convMicroteachCaseQuantitySenateItems.senateGaugeSubItemDesc] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.senateGaugeSubItemDesc].ToString().Trim(); //量表指标子项说明
objvMicroteachCaseQuantitySenateItemsEN.senateGaugeSubItemMemo = objRow[convMicroteachCaseQuantitySenateItems.senateGaugeSubItemMemo] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.senateGaugeSubItemMemo].ToString().Trim(); //量表指标子项备注
objvMicroteachCaseQuantitySenateItemsEN.senateGaugeSubItemScore = objRow[convMicroteachCaseQuantitySenateItems.senateGaugeSubItemScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convMicroteachCaseQuantitySenateItems.senateGaugeSubItemScore].ToString().Trim()); //量表指标子项分数
objvMicroteachCaseQuantitySenateItemsEN.UserId = objRow[convMicroteachCaseQuantitySenateItems.UserId] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.UserId].ToString().Trim(); //用户ID
objvMicroteachCaseQuantitySenateItemsEN.UserName = objRow[convMicroteachCaseQuantitySenateItems.UserName] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.UserName].ToString().Trim(); //用户名
objvMicroteachCaseQuantitySenateItemsEN.CollegeID = objRow[convMicroteachCaseQuantitySenateItems.CollegeID] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.CollegeID].ToString().Trim(); //学院ID
objvMicroteachCaseQuantitySenateItemsEN.CollegeName = objRow[convMicroteachCaseQuantitySenateItems.CollegeName] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.CollegeName].ToString().Trim(); //学院名称
objvMicroteachCaseQuantitySenateItemsEN.SenateTheme = objRow[convMicroteachCaseQuantitySenateItems.SenateTheme] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.SenateTheme].ToString().Trim(); //量化评价主题
objvMicroteachCaseQuantitySenateItemsEN.SenateContent = objRow[convMicroteachCaseQuantitySenateItems.SenateContent] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.SenateContent].ToString().Trim(); //评价内容
objvMicroteachCaseQuantitySenateItemsEN.SenateDate = objRow[convMicroteachCaseQuantitySenateItems.SenateDate] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.SenateDate].ToString().Trim(); //评价日期
objvMicroteachCaseQuantitySenateItemsEN.SenateTime = objRow[convMicroteachCaseQuantitySenateItems.SenateTime] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.SenateTime].ToString().Trim(); //评价时间
objvMicroteachCaseQuantitySenateItemsEN.SenateTotalScore = objRow[convMicroteachCaseQuantitySenateItems.SenateTotalScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convMicroteachCaseQuantitySenateItems.SenateTotalScore].ToString().Trim()); //评价分数
objvMicroteachCaseQuantitySenateItemsEN.AnswerModeId = objRow[convMicroteachCaseQuantitySenateItems.AnswerModeId] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.AnswerModeId].ToString().Trim(); //答案模式Id
objvMicroteachCaseQuantitySenateItemsEN.AnswerTypeId = objRow[convMicroteachCaseQuantitySenateItems.AnswerTypeId] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.AnswerTypeId].ToString().Trim(); //答案类型ID
objvMicroteachCaseQuantitySenateItemsEN.GridTitle = objRow[convMicroteachCaseQuantitySenateItems.GridTitle] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.GridTitle].ToString().Trim(); //表格标题
objvMicroteachCaseQuantitySenateItemsEN.QuestionIndex = objRow[convMicroteachCaseQuantitySenateItems.QuestionIndex] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convMicroteachCaseQuantitySenateItems.QuestionIndex].ToString().Trim()); //题目序号
objvMicroteachCaseQuantitySenateItemsEN.QuestionNo = objRow[convMicroteachCaseQuantitySenateItems.QuestionNo] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.QuestionNo].ToString().Trim(); //题目编号
objvMicroteachCaseQuantitySenateItemsEN.QuestionTypeId = objRow[convMicroteachCaseQuantitySenateItems.QuestionTypeId] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.QuestionTypeId].ToString().Trim(); //题目类型Id
objvMicroteachCaseQuantitySenateItemsEN.AnswerModeName = objRow[convMicroteachCaseQuantitySenateItems.AnswerModeName] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.AnswerModeName].ToString().Trim(); //答案模式名称
objvMicroteachCaseQuantitySenateItemsEN.AnswerNum = objRow[convMicroteachCaseQuantitySenateItems.AnswerNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convMicroteachCaseQuantitySenateItems.AnswerNum].ToString().Trim()); //答案数
objvMicroteachCaseQuantitySenateItemsEN.AnswerTypeName = objRow[convMicroteachCaseQuantitySenateItems.AnswerTypeName] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.AnswerTypeName].ToString().Trim(); //答案类型名
objvMicroteachCaseQuantitySenateItemsEN.QuestionTypeName = objRow[convMicroteachCaseQuantitySenateItems.QuestionTypeName] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.QuestionTypeName].ToString().Trim(); //题目类型名
objvMicroteachCaseQuantitySenateItemsEN.senateGaugeVersionID = objRow[convMicroteachCaseQuantitySenateItems.senateGaugeVersionID] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.senateGaugeVersionID].ToString().Trim(); //评价量表版本ID
objvMicroteachCaseQuantitySenateItemsEN.senateGaugeVersionName = objRow[convMicroteachCaseQuantitySenateItems.senateGaugeVersionName] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称
objvMicroteachCaseQuantitySenateItemsEN.senateGaugeVersionTtlScore = objRow[convMicroteachCaseQuantitySenateItems.senateGaugeVersionTtlScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convMicroteachCaseQuantitySenateItems.senateGaugeVersionTtlScore].ToString().Trim()); //评价量表版本总分
objvMicroteachCaseQuantitySenateItemsEN.IdSenateGaugeVersion = objRow[convMicroteachCaseQuantitySenateItems.IdSenateGaugeVersion].ToString().Trim(); //评价量表版本流水号
objvMicroteachCaseQuantitySenateItemsEN.AnswerIndex = objRow[convMicroteachCaseQuantitySenateItems.AnswerIndex] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convMicroteachCaseQuantitySenateItems.AnswerIndex].ToString().Trim()); //问答序号
objvMicroteachCaseQuantitySenateItemsEN.AnswerTitle = objRow[convMicroteachCaseQuantitySenateItems.AnswerTitle] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.AnswerTitle].ToString().Trim(); //答案标题
objvMicroteachCaseQuantitySenateItemsEN.OwnerId = objRow[convMicroteachCaseQuantitySenateItems.OwnerId] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.OwnerId].ToString().Trim(); //拥有者Id
objvMicroteachCaseQuantitySenateItemsEN.OwnerName = objRow[convMicroteachCaseQuantitySenateItems.OwnerName] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.OwnerName].ToString().Trim(); //拥有者姓名
objvMicroteachCaseQuantitySenateItemsEN.OwnerNameWithId = objRow[convMicroteachCaseQuantitySenateItems.OwnerNameWithId] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.OwnerNameWithId].ToString().Trim(); //拥有者名称附Id
objvMicroteachCaseQuantitySenateItemsEN.SenateIp = objRow[convMicroteachCaseQuantitySenateItems.SenateIp] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.SenateIp].ToString().Trim(); //评议Ip
objvMicroteachCaseQuantitySenateItemsEN.UserNameWithUserId = objRow[convMicroteachCaseQuantitySenateItems.UserNameWithUserId] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.UserNameWithUserId].ToString().Trim(); //UserNameWithUserId
objvMicroteachCaseQuantitySenateItemsEN.UserTypeId = objRow[convMicroteachCaseQuantitySenateItems.UserTypeId] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.UserTypeId].ToString().Trim(); //用户类型Id
objvMicroteachCaseQuantitySenateItemsEN.IsAccess = clsEntityBase2.TransNullToBool_S(objRow[convMicroteachCaseQuantitySenateItems.IsAccess].ToString().Trim()); //IsAccess
objvMicroteachCaseQuantitySenateItemsEN.IsAccessC = clsEntityBase2.TransNullToBool_S(objRow[convMicroteachCaseQuantitySenateItems.IsAccessC].ToString().Trim()); //IsAccessC
objvMicroteachCaseQuantitySenateItemsEN.UpdDate = objRow[convMicroteachCaseQuantitySenateItems.UpdDate] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.UpdDate].ToString().Trim(); //修改日期
objvMicroteachCaseQuantitySenateItemsEN.UpdUser = objRow[convMicroteachCaseQuantitySenateItems.UpdUser] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.UpdUser].ToString().Trim(); //修改人
objvMicroteachCaseQuantitySenateItemsEN.IdAppraiseType = objRow[convMicroteachCaseQuantitySenateItems.IdAppraiseType] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.IdAppraiseType].ToString().Trim(); //评议类型流水号
objvMicroteachCaseQuantitySenateItemsEN.AppraiseTypeName = objRow[convMicroteachCaseQuantitySenateItems.AppraiseTypeName] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.AppraiseTypeName].ToString().Trim(); //评议类型名称
objvMicroteachCaseQuantitySenateItemsEN.FuncModuleId = objRow[convMicroteachCaseQuantitySenateItems.FuncModuleId] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.FuncModuleId].ToString().Trim(); //功能模块Id
objvMicroteachCaseQuantitySenateItemsEN.UserKindId = objRow[convMicroteachCaseQuantitySenateItems.UserKindId] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.UserKindId].ToString().Trim(); //用户类别Id
objvMicroteachCaseQuantitySenateItemsEN.UserKindName = objRow[convMicroteachCaseQuantitySenateItems.UserKindName] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.UserKindName].ToString().Trim(); //用户类别名
objvMicroteachCaseQuantitySenateItemsEN.UserTypeName = objRow[convMicroteachCaseQuantitySenateItems.UserTypeName] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.UserTypeName].ToString().Trim(); //用户类型名称
objvMicroteachCaseQuantitySenateItemsEN.FuncModuleName = objRow[convMicroteachCaseQuantitySenateItems.FuncModuleName] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.FuncModuleName].ToString().Trim(); //功能模块名称
objvMicroteachCaseQuantitySenateItemsEN.IdXzCollege = objRow[convMicroteachCaseQuantitySenateItems.IdXzCollege] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.IdXzCollege].ToString().Trim(); //学院流水号
objvMicroteachCaseQuantitySenateItemsEN.CollegeNameA = objRow[convMicroteachCaseQuantitySenateItems.CollegeNameA] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.CollegeNameA].ToString().Trim(); //学院名称简写
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvMicroteachCaseQuantitySenateItemsEN.IdmicroteachCaseQuantitySenateItem, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvMicroteachCaseQuantitySenateItemsEN);
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
public static List<clsvMicroteachCaseQuantitySenateItemsEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsvMicroteachCaseQuantitySenateItemsEN> arrObjLst = new List<clsvMicroteachCaseQuantitySenateItemsEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvMicroteachCaseQuantitySenateItemsEN objvMicroteachCaseQuantitySenateItemsEN = new clsvMicroteachCaseQuantitySenateItemsEN();
try
{
objvMicroteachCaseQuantitySenateItemsEN.IdmicroteachCaseQuantitySenateItem = Int32.Parse(objRow[convMicroteachCaseQuantitySenateItems.IdmicroteachCaseQuantitySenateItem].ToString().Trim()); //微格量化评价指标流水号
objvMicroteachCaseQuantitySenateItemsEN.IdmicroteachCaseQuantitySenate = Int32.Parse(objRow[convMicroteachCaseQuantitySenateItems.IdmicroteachCaseQuantitySenate].ToString().Trim()); //微格量化评价流水号
objvMicroteachCaseQuantitySenateItemsEN.IdMicroteachCase = objRow[convMicroteachCaseQuantitySenateItems.IdMicroteachCase].ToString().Trim(); //微格教学案例流水号
objvMicroteachCaseQuantitySenateItemsEN.MicroteachCaseID = objRow[convMicroteachCaseQuantitySenateItems.MicroteachCaseID] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.MicroteachCaseID].ToString().Trim(); //微格教学案例ID
objvMicroteachCaseQuantitySenateItemsEN.MicroteachCaseName = objRow[convMicroteachCaseQuantitySenateItems.MicroteachCaseName] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.MicroteachCaseName].ToString().Trim(); //微格教学案例名称
objvMicroteachCaseQuantitySenateItemsEN.IdSenateGaugeItem = objRow[convMicroteachCaseQuantitySenateItems.IdSenateGaugeItem].ToString().Trim(); //量表指标流水号
objvMicroteachCaseQuantitySenateItemsEN.senateGaugeItemID = objRow[convMicroteachCaseQuantitySenateItems.senateGaugeItemID] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.senateGaugeItemID].ToString().Trim(); //量表指标ID
objvMicroteachCaseQuantitySenateItemsEN.senateGaugeItemName = objRow[convMicroteachCaseQuantitySenateItems.senateGaugeItemName] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.senateGaugeItemName].ToString().Trim(); //量表指标名称
objvMicroteachCaseQuantitySenateItemsEN.senateGaugeItemNameWithOrder = objRow[convMicroteachCaseQuantitySenateItems.senateGaugeItemNameWithOrder] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.senateGaugeItemNameWithOrder].ToString().Trim(); //量表指标名称WithOrder
objvMicroteachCaseQuantitySenateItemsEN.senateGaugeItemDesc = objRow[convMicroteachCaseQuantitySenateItems.senateGaugeItemDesc] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.senateGaugeItemDesc].ToString().Trim(); //量表指标说明
objvMicroteachCaseQuantitySenateItemsEN.senateGaugeItemMemo = objRow[convMicroteachCaseQuantitySenateItems.senateGaugeItemMemo] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.senateGaugeItemMemo].ToString().Trim(); //备注
objvMicroteachCaseQuantitySenateItemsEN.senateGaugeItemWeight = objRow[convMicroteachCaseQuantitySenateItems.senateGaugeItemWeight] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convMicroteachCaseQuantitySenateItems.senateGaugeItemWeight].ToString().Trim()); //量表指标权重
objvMicroteachCaseQuantitySenateItemsEN.SenateScore = objRow[convMicroteachCaseQuantitySenateItems.SenateScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convMicroteachCaseQuantitySenateItems.SenateScore].ToString().Trim()); //指标得分
objvMicroteachCaseQuantitySenateItemsEN.IdSenateGaugeSubItem = objRow[convMicroteachCaseQuantitySenateItems.IdSenateGaugeSubItem] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.IdSenateGaugeSubItem].ToString().Trim(); //量表指标子项流水号
objvMicroteachCaseQuantitySenateItemsEN.senateGaugeSubItemID = objRow[convMicroteachCaseQuantitySenateItems.senateGaugeSubItemID] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.senateGaugeSubItemID].ToString().Trim(); //量表指标子项ID
objvMicroteachCaseQuantitySenateItemsEN.senateGaugeSubItemName = objRow[convMicroteachCaseQuantitySenateItems.senateGaugeSubItemName] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.senateGaugeSubItemName].ToString().Trim(); //量表指标子项名称
objvMicroteachCaseQuantitySenateItemsEN.senateGaugeSubItemDesc = objRow[convMicroteachCaseQuantitySenateItems.senateGaugeSubItemDesc] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.senateGaugeSubItemDesc].ToString().Trim(); //量表指标子项说明
objvMicroteachCaseQuantitySenateItemsEN.senateGaugeSubItemMemo = objRow[convMicroteachCaseQuantitySenateItems.senateGaugeSubItemMemo] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.senateGaugeSubItemMemo].ToString().Trim(); //量表指标子项备注
objvMicroteachCaseQuantitySenateItemsEN.senateGaugeSubItemScore = objRow[convMicroteachCaseQuantitySenateItems.senateGaugeSubItemScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convMicroteachCaseQuantitySenateItems.senateGaugeSubItemScore].ToString().Trim()); //量表指标子项分数
objvMicroteachCaseQuantitySenateItemsEN.UserId = objRow[convMicroteachCaseQuantitySenateItems.UserId] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.UserId].ToString().Trim(); //用户ID
objvMicroteachCaseQuantitySenateItemsEN.UserName = objRow[convMicroteachCaseQuantitySenateItems.UserName] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.UserName].ToString().Trim(); //用户名
objvMicroteachCaseQuantitySenateItemsEN.CollegeID = objRow[convMicroteachCaseQuantitySenateItems.CollegeID] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.CollegeID].ToString().Trim(); //学院ID
objvMicroteachCaseQuantitySenateItemsEN.CollegeName = objRow[convMicroteachCaseQuantitySenateItems.CollegeName] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.CollegeName].ToString().Trim(); //学院名称
objvMicroteachCaseQuantitySenateItemsEN.SenateTheme = objRow[convMicroteachCaseQuantitySenateItems.SenateTheme] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.SenateTheme].ToString().Trim(); //量化评价主题
objvMicroteachCaseQuantitySenateItemsEN.SenateContent = objRow[convMicroteachCaseQuantitySenateItems.SenateContent] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.SenateContent].ToString().Trim(); //评价内容
objvMicroteachCaseQuantitySenateItemsEN.SenateDate = objRow[convMicroteachCaseQuantitySenateItems.SenateDate] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.SenateDate].ToString().Trim(); //评价日期
objvMicroteachCaseQuantitySenateItemsEN.SenateTime = objRow[convMicroteachCaseQuantitySenateItems.SenateTime] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.SenateTime].ToString().Trim(); //评价时间
objvMicroteachCaseQuantitySenateItemsEN.SenateTotalScore = objRow[convMicroteachCaseQuantitySenateItems.SenateTotalScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convMicroteachCaseQuantitySenateItems.SenateTotalScore].ToString().Trim()); //评价分数
objvMicroteachCaseQuantitySenateItemsEN.AnswerModeId = objRow[convMicroteachCaseQuantitySenateItems.AnswerModeId] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.AnswerModeId].ToString().Trim(); //答案模式Id
objvMicroteachCaseQuantitySenateItemsEN.AnswerTypeId = objRow[convMicroteachCaseQuantitySenateItems.AnswerTypeId] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.AnswerTypeId].ToString().Trim(); //答案类型ID
objvMicroteachCaseQuantitySenateItemsEN.GridTitle = objRow[convMicroteachCaseQuantitySenateItems.GridTitle] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.GridTitle].ToString().Trim(); //表格标题
objvMicroteachCaseQuantitySenateItemsEN.QuestionIndex = objRow[convMicroteachCaseQuantitySenateItems.QuestionIndex] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convMicroteachCaseQuantitySenateItems.QuestionIndex].ToString().Trim()); //题目序号
objvMicroteachCaseQuantitySenateItemsEN.QuestionNo = objRow[convMicroteachCaseQuantitySenateItems.QuestionNo] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.QuestionNo].ToString().Trim(); //题目编号
objvMicroteachCaseQuantitySenateItemsEN.QuestionTypeId = objRow[convMicroteachCaseQuantitySenateItems.QuestionTypeId] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.QuestionTypeId].ToString().Trim(); //题目类型Id
objvMicroteachCaseQuantitySenateItemsEN.AnswerModeName = objRow[convMicroteachCaseQuantitySenateItems.AnswerModeName] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.AnswerModeName].ToString().Trim(); //答案模式名称
objvMicroteachCaseQuantitySenateItemsEN.AnswerNum = objRow[convMicroteachCaseQuantitySenateItems.AnswerNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convMicroteachCaseQuantitySenateItems.AnswerNum].ToString().Trim()); //答案数
objvMicroteachCaseQuantitySenateItemsEN.AnswerTypeName = objRow[convMicroteachCaseQuantitySenateItems.AnswerTypeName] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.AnswerTypeName].ToString().Trim(); //答案类型名
objvMicroteachCaseQuantitySenateItemsEN.QuestionTypeName = objRow[convMicroteachCaseQuantitySenateItems.QuestionTypeName] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.QuestionTypeName].ToString().Trim(); //题目类型名
objvMicroteachCaseQuantitySenateItemsEN.senateGaugeVersionID = objRow[convMicroteachCaseQuantitySenateItems.senateGaugeVersionID] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.senateGaugeVersionID].ToString().Trim(); //评价量表版本ID
objvMicroteachCaseQuantitySenateItemsEN.senateGaugeVersionName = objRow[convMicroteachCaseQuantitySenateItems.senateGaugeVersionName] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称
objvMicroteachCaseQuantitySenateItemsEN.senateGaugeVersionTtlScore = objRow[convMicroteachCaseQuantitySenateItems.senateGaugeVersionTtlScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convMicroteachCaseQuantitySenateItems.senateGaugeVersionTtlScore].ToString().Trim()); //评价量表版本总分
objvMicroteachCaseQuantitySenateItemsEN.IdSenateGaugeVersion = objRow[convMicroteachCaseQuantitySenateItems.IdSenateGaugeVersion].ToString().Trim(); //评价量表版本流水号
objvMicroteachCaseQuantitySenateItemsEN.AnswerIndex = objRow[convMicroteachCaseQuantitySenateItems.AnswerIndex] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convMicroteachCaseQuantitySenateItems.AnswerIndex].ToString().Trim()); //问答序号
objvMicroteachCaseQuantitySenateItemsEN.AnswerTitle = objRow[convMicroteachCaseQuantitySenateItems.AnswerTitle] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.AnswerTitle].ToString().Trim(); //答案标题
objvMicroteachCaseQuantitySenateItemsEN.OwnerId = objRow[convMicroteachCaseQuantitySenateItems.OwnerId] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.OwnerId].ToString().Trim(); //拥有者Id
objvMicroteachCaseQuantitySenateItemsEN.OwnerName = objRow[convMicroteachCaseQuantitySenateItems.OwnerName] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.OwnerName].ToString().Trim(); //拥有者姓名
objvMicroteachCaseQuantitySenateItemsEN.OwnerNameWithId = objRow[convMicroteachCaseQuantitySenateItems.OwnerNameWithId] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.OwnerNameWithId].ToString().Trim(); //拥有者名称附Id
objvMicroteachCaseQuantitySenateItemsEN.SenateIp = objRow[convMicroteachCaseQuantitySenateItems.SenateIp] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.SenateIp].ToString().Trim(); //评议Ip
objvMicroteachCaseQuantitySenateItemsEN.UserNameWithUserId = objRow[convMicroteachCaseQuantitySenateItems.UserNameWithUserId] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.UserNameWithUserId].ToString().Trim(); //UserNameWithUserId
objvMicroteachCaseQuantitySenateItemsEN.UserTypeId = objRow[convMicroteachCaseQuantitySenateItems.UserTypeId] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.UserTypeId].ToString().Trim(); //用户类型Id
objvMicroteachCaseQuantitySenateItemsEN.IsAccess = clsEntityBase2.TransNullToBool_S(objRow[convMicroteachCaseQuantitySenateItems.IsAccess].ToString().Trim()); //IsAccess
objvMicroteachCaseQuantitySenateItemsEN.IsAccessC = clsEntityBase2.TransNullToBool_S(objRow[convMicroteachCaseQuantitySenateItems.IsAccessC].ToString().Trim()); //IsAccessC
objvMicroteachCaseQuantitySenateItemsEN.UpdDate = objRow[convMicroteachCaseQuantitySenateItems.UpdDate] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.UpdDate].ToString().Trim(); //修改日期
objvMicroteachCaseQuantitySenateItemsEN.UpdUser = objRow[convMicroteachCaseQuantitySenateItems.UpdUser] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.UpdUser].ToString().Trim(); //修改人
objvMicroteachCaseQuantitySenateItemsEN.IdAppraiseType = objRow[convMicroteachCaseQuantitySenateItems.IdAppraiseType] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.IdAppraiseType].ToString().Trim(); //评议类型流水号
objvMicroteachCaseQuantitySenateItemsEN.AppraiseTypeName = objRow[convMicroteachCaseQuantitySenateItems.AppraiseTypeName] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.AppraiseTypeName].ToString().Trim(); //评议类型名称
objvMicroteachCaseQuantitySenateItemsEN.FuncModuleId = objRow[convMicroteachCaseQuantitySenateItems.FuncModuleId] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.FuncModuleId].ToString().Trim(); //功能模块Id
objvMicroteachCaseQuantitySenateItemsEN.UserKindId = objRow[convMicroteachCaseQuantitySenateItems.UserKindId] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.UserKindId].ToString().Trim(); //用户类别Id
objvMicroteachCaseQuantitySenateItemsEN.UserKindName = objRow[convMicroteachCaseQuantitySenateItems.UserKindName] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.UserKindName].ToString().Trim(); //用户类别名
objvMicroteachCaseQuantitySenateItemsEN.UserTypeName = objRow[convMicroteachCaseQuantitySenateItems.UserTypeName] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.UserTypeName].ToString().Trim(); //用户类型名称
objvMicroteachCaseQuantitySenateItemsEN.FuncModuleName = objRow[convMicroteachCaseQuantitySenateItems.FuncModuleName] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.FuncModuleName].ToString().Trim(); //功能模块名称
objvMicroteachCaseQuantitySenateItemsEN.IdXzCollege = objRow[convMicroteachCaseQuantitySenateItems.IdXzCollege] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.IdXzCollege].ToString().Trim(); //学院流水号
objvMicroteachCaseQuantitySenateItemsEN.CollegeNameA = objRow[convMicroteachCaseQuantitySenateItems.CollegeNameA] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.CollegeNameA].ToString().Trim(); //学院名称简写
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvMicroteachCaseQuantitySenateItemsEN.IdmicroteachCaseQuantitySenateItem, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvMicroteachCaseQuantitySenateItemsEN);
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
List<clsvMicroteachCaseQuantitySenateItemsEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsvMicroteachCaseQuantitySenateItemsEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsvMicroteachCaseQuantitySenateItemsEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsvMicroteachCaseQuantitySenateItemsEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsvMicroteachCaseQuantitySenateItemsEN> arrObjLst = new List<clsvMicroteachCaseQuantitySenateItemsEN>(); 
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
	clsvMicroteachCaseQuantitySenateItemsEN objvMicroteachCaseQuantitySenateItemsEN = new clsvMicroteachCaseQuantitySenateItemsEN();
try
{
objvMicroteachCaseQuantitySenateItemsEN.IdmicroteachCaseQuantitySenateItem = Int32.Parse(objRow[convMicroteachCaseQuantitySenateItems.IdmicroteachCaseQuantitySenateItem].ToString().Trim()); //微格量化评价指标流水号
objvMicroteachCaseQuantitySenateItemsEN.IdmicroteachCaseQuantitySenate = Int32.Parse(objRow[convMicroteachCaseQuantitySenateItems.IdmicroteachCaseQuantitySenate].ToString().Trim()); //微格量化评价流水号
objvMicroteachCaseQuantitySenateItemsEN.IdMicroteachCase = objRow[convMicroteachCaseQuantitySenateItems.IdMicroteachCase].ToString().Trim(); //微格教学案例流水号
objvMicroteachCaseQuantitySenateItemsEN.MicroteachCaseID = objRow[convMicroteachCaseQuantitySenateItems.MicroteachCaseID] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.MicroteachCaseID].ToString().Trim(); //微格教学案例ID
objvMicroteachCaseQuantitySenateItemsEN.MicroteachCaseName = objRow[convMicroteachCaseQuantitySenateItems.MicroteachCaseName] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.MicroteachCaseName].ToString().Trim(); //微格教学案例名称
objvMicroteachCaseQuantitySenateItemsEN.IdSenateGaugeItem = objRow[convMicroteachCaseQuantitySenateItems.IdSenateGaugeItem].ToString().Trim(); //量表指标流水号
objvMicroteachCaseQuantitySenateItemsEN.senateGaugeItemID = objRow[convMicroteachCaseQuantitySenateItems.senateGaugeItemID] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.senateGaugeItemID].ToString().Trim(); //量表指标ID
objvMicroteachCaseQuantitySenateItemsEN.senateGaugeItemName = objRow[convMicroteachCaseQuantitySenateItems.senateGaugeItemName] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.senateGaugeItemName].ToString().Trim(); //量表指标名称
objvMicroteachCaseQuantitySenateItemsEN.senateGaugeItemNameWithOrder = objRow[convMicroteachCaseQuantitySenateItems.senateGaugeItemNameWithOrder] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.senateGaugeItemNameWithOrder].ToString().Trim(); //量表指标名称WithOrder
objvMicroteachCaseQuantitySenateItemsEN.senateGaugeItemDesc = objRow[convMicroteachCaseQuantitySenateItems.senateGaugeItemDesc] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.senateGaugeItemDesc].ToString().Trim(); //量表指标说明
objvMicroteachCaseQuantitySenateItemsEN.senateGaugeItemMemo = objRow[convMicroteachCaseQuantitySenateItems.senateGaugeItemMemo] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.senateGaugeItemMemo].ToString().Trim(); //备注
objvMicroteachCaseQuantitySenateItemsEN.senateGaugeItemWeight = objRow[convMicroteachCaseQuantitySenateItems.senateGaugeItemWeight] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convMicroteachCaseQuantitySenateItems.senateGaugeItemWeight].ToString().Trim()); //量表指标权重
objvMicroteachCaseQuantitySenateItemsEN.SenateScore = objRow[convMicroteachCaseQuantitySenateItems.SenateScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convMicroteachCaseQuantitySenateItems.SenateScore].ToString().Trim()); //指标得分
objvMicroteachCaseQuantitySenateItemsEN.IdSenateGaugeSubItem = objRow[convMicroteachCaseQuantitySenateItems.IdSenateGaugeSubItem] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.IdSenateGaugeSubItem].ToString().Trim(); //量表指标子项流水号
objvMicroteachCaseQuantitySenateItemsEN.senateGaugeSubItemID = objRow[convMicroteachCaseQuantitySenateItems.senateGaugeSubItemID] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.senateGaugeSubItemID].ToString().Trim(); //量表指标子项ID
objvMicroteachCaseQuantitySenateItemsEN.senateGaugeSubItemName = objRow[convMicroteachCaseQuantitySenateItems.senateGaugeSubItemName] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.senateGaugeSubItemName].ToString().Trim(); //量表指标子项名称
objvMicroteachCaseQuantitySenateItemsEN.senateGaugeSubItemDesc = objRow[convMicroteachCaseQuantitySenateItems.senateGaugeSubItemDesc] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.senateGaugeSubItemDesc].ToString().Trim(); //量表指标子项说明
objvMicroteachCaseQuantitySenateItemsEN.senateGaugeSubItemMemo = objRow[convMicroteachCaseQuantitySenateItems.senateGaugeSubItemMemo] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.senateGaugeSubItemMemo].ToString().Trim(); //量表指标子项备注
objvMicroteachCaseQuantitySenateItemsEN.senateGaugeSubItemScore = objRow[convMicroteachCaseQuantitySenateItems.senateGaugeSubItemScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convMicroteachCaseQuantitySenateItems.senateGaugeSubItemScore].ToString().Trim()); //量表指标子项分数
objvMicroteachCaseQuantitySenateItemsEN.UserId = objRow[convMicroteachCaseQuantitySenateItems.UserId] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.UserId].ToString().Trim(); //用户ID
objvMicroteachCaseQuantitySenateItemsEN.UserName = objRow[convMicroteachCaseQuantitySenateItems.UserName] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.UserName].ToString().Trim(); //用户名
objvMicroteachCaseQuantitySenateItemsEN.CollegeID = objRow[convMicroteachCaseQuantitySenateItems.CollegeID] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.CollegeID].ToString().Trim(); //学院ID
objvMicroteachCaseQuantitySenateItemsEN.CollegeName = objRow[convMicroteachCaseQuantitySenateItems.CollegeName] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.CollegeName].ToString().Trim(); //学院名称
objvMicroteachCaseQuantitySenateItemsEN.SenateTheme = objRow[convMicroteachCaseQuantitySenateItems.SenateTheme] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.SenateTheme].ToString().Trim(); //量化评价主题
objvMicroteachCaseQuantitySenateItemsEN.SenateContent = objRow[convMicroteachCaseQuantitySenateItems.SenateContent] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.SenateContent].ToString().Trim(); //评价内容
objvMicroteachCaseQuantitySenateItemsEN.SenateDate = objRow[convMicroteachCaseQuantitySenateItems.SenateDate] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.SenateDate].ToString().Trim(); //评价日期
objvMicroteachCaseQuantitySenateItemsEN.SenateTime = objRow[convMicroteachCaseQuantitySenateItems.SenateTime] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.SenateTime].ToString().Trim(); //评价时间
objvMicroteachCaseQuantitySenateItemsEN.SenateTotalScore = objRow[convMicroteachCaseQuantitySenateItems.SenateTotalScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convMicroteachCaseQuantitySenateItems.SenateTotalScore].ToString().Trim()); //评价分数
objvMicroteachCaseQuantitySenateItemsEN.AnswerModeId = objRow[convMicroteachCaseQuantitySenateItems.AnswerModeId] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.AnswerModeId].ToString().Trim(); //答案模式Id
objvMicroteachCaseQuantitySenateItemsEN.AnswerTypeId = objRow[convMicroteachCaseQuantitySenateItems.AnswerTypeId] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.AnswerTypeId].ToString().Trim(); //答案类型ID
objvMicroteachCaseQuantitySenateItemsEN.GridTitle = objRow[convMicroteachCaseQuantitySenateItems.GridTitle] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.GridTitle].ToString().Trim(); //表格标题
objvMicroteachCaseQuantitySenateItemsEN.QuestionIndex = objRow[convMicroteachCaseQuantitySenateItems.QuestionIndex] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convMicroteachCaseQuantitySenateItems.QuestionIndex].ToString().Trim()); //题目序号
objvMicroteachCaseQuantitySenateItemsEN.QuestionNo = objRow[convMicroteachCaseQuantitySenateItems.QuestionNo] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.QuestionNo].ToString().Trim(); //题目编号
objvMicroteachCaseQuantitySenateItemsEN.QuestionTypeId = objRow[convMicroteachCaseQuantitySenateItems.QuestionTypeId] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.QuestionTypeId].ToString().Trim(); //题目类型Id
objvMicroteachCaseQuantitySenateItemsEN.AnswerModeName = objRow[convMicroteachCaseQuantitySenateItems.AnswerModeName] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.AnswerModeName].ToString().Trim(); //答案模式名称
objvMicroteachCaseQuantitySenateItemsEN.AnswerNum = objRow[convMicroteachCaseQuantitySenateItems.AnswerNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convMicroteachCaseQuantitySenateItems.AnswerNum].ToString().Trim()); //答案数
objvMicroteachCaseQuantitySenateItemsEN.AnswerTypeName = objRow[convMicroteachCaseQuantitySenateItems.AnswerTypeName] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.AnswerTypeName].ToString().Trim(); //答案类型名
objvMicroteachCaseQuantitySenateItemsEN.QuestionTypeName = objRow[convMicroteachCaseQuantitySenateItems.QuestionTypeName] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.QuestionTypeName].ToString().Trim(); //题目类型名
objvMicroteachCaseQuantitySenateItemsEN.senateGaugeVersionID = objRow[convMicroteachCaseQuantitySenateItems.senateGaugeVersionID] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.senateGaugeVersionID].ToString().Trim(); //评价量表版本ID
objvMicroteachCaseQuantitySenateItemsEN.senateGaugeVersionName = objRow[convMicroteachCaseQuantitySenateItems.senateGaugeVersionName] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称
objvMicroteachCaseQuantitySenateItemsEN.senateGaugeVersionTtlScore = objRow[convMicroteachCaseQuantitySenateItems.senateGaugeVersionTtlScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convMicroteachCaseQuantitySenateItems.senateGaugeVersionTtlScore].ToString().Trim()); //评价量表版本总分
objvMicroteachCaseQuantitySenateItemsEN.IdSenateGaugeVersion = objRow[convMicroteachCaseQuantitySenateItems.IdSenateGaugeVersion].ToString().Trim(); //评价量表版本流水号
objvMicroteachCaseQuantitySenateItemsEN.AnswerIndex = objRow[convMicroteachCaseQuantitySenateItems.AnswerIndex] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convMicroteachCaseQuantitySenateItems.AnswerIndex].ToString().Trim()); //问答序号
objvMicroteachCaseQuantitySenateItemsEN.AnswerTitle = objRow[convMicroteachCaseQuantitySenateItems.AnswerTitle] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.AnswerTitle].ToString().Trim(); //答案标题
objvMicroteachCaseQuantitySenateItemsEN.OwnerId = objRow[convMicroteachCaseQuantitySenateItems.OwnerId] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.OwnerId].ToString().Trim(); //拥有者Id
objvMicroteachCaseQuantitySenateItemsEN.OwnerName = objRow[convMicroteachCaseQuantitySenateItems.OwnerName] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.OwnerName].ToString().Trim(); //拥有者姓名
objvMicroteachCaseQuantitySenateItemsEN.OwnerNameWithId = objRow[convMicroteachCaseQuantitySenateItems.OwnerNameWithId] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.OwnerNameWithId].ToString().Trim(); //拥有者名称附Id
objvMicroteachCaseQuantitySenateItemsEN.SenateIp = objRow[convMicroteachCaseQuantitySenateItems.SenateIp] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.SenateIp].ToString().Trim(); //评议Ip
objvMicroteachCaseQuantitySenateItemsEN.UserNameWithUserId = objRow[convMicroteachCaseQuantitySenateItems.UserNameWithUserId] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.UserNameWithUserId].ToString().Trim(); //UserNameWithUserId
objvMicroteachCaseQuantitySenateItemsEN.UserTypeId = objRow[convMicroteachCaseQuantitySenateItems.UserTypeId] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.UserTypeId].ToString().Trim(); //用户类型Id
objvMicroteachCaseQuantitySenateItemsEN.IsAccess = clsEntityBase2.TransNullToBool_S(objRow[convMicroteachCaseQuantitySenateItems.IsAccess].ToString().Trim()); //IsAccess
objvMicroteachCaseQuantitySenateItemsEN.IsAccessC = clsEntityBase2.TransNullToBool_S(objRow[convMicroteachCaseQuantitySenateItems.IsAccessC].ToString().Trim()); //IsAccessC
objvMicroteachCaseQuantitySenateItemsEN.UpdDate = objRow[convMicroteachCaseQuantitySenateItems.UpdDate] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.UpdDate].ToString().Trim(); //修改日期
objvMicroteachCaseQuantitySenateItemsEN.UpdUser = objRow[convMicroteachCaseQuantitySenateItems.UpdUser] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.UpdUser].ToString().Trim(); //修改人
objvMicroteachCaseQuantitySenateItemsEN.IdAppraiseType = objRow[convMicroteachCaseQuantitySenateItems.IdAppraiseType] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.IdAppraiseType].ToString().Trim(); //评议类型流水号
objvMicroteachCaseQuantitySenateItemsEN.AppraiseTypeName = objRow[convMicroteachCaseQuantitySenateItems.AppraiseTypeName] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.AppraiseTypeName].ToString().Trim(); //评议类型名称
objvMicroteachCaseQuantitySenateItemsEN.FuncModuleId = objRow[convMicroteachCaseQuantitySenateItems.FuncModuleId] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.FuncModuleId].ToString().Trim(); //功能模块Id
objvMicroteachCaseQuantitySenateItemsEN.UserKindId = objRow[convMicroteachCaseQuantitySenateItems.UserKindId] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.UserKindId].ToString().Trim(); //用户类别Id
objvMicroteachCaseQuantitySenateItemsEN.UserKindName = objRow[convMicroteachCaseQuantitySenateItems.UserKindName] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.UserKindName].ToString().Trim(); //用户类别名
objvMicroteachCaseQuantitySenateItemsEN.UserTypeName = objRow[convMicroteachCaseQuantitySenateItems.UserTypeName] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.UserTypeName].ToString().Trim(); //用户类型名称
objvMicroteachCaseQuantitySenateItemsEN.FuncModuleName = objRow[convMicroteachCaseQuantitySenateItems.FuncModuleName] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.FuncModuleName].ToString().Trim(); //功能模块名称
objvMicroteachCaseQuantitySenateItemsEN.IdXzCollege = objRow[convMicroteachCaseQuantitySenateItems.IdXzCollege] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.IdXzCollege].ToString().Trim(); //学院流水号
objvMicroteachCaseQuantitySenateItemsEN.CollegeNameA = objRow[convMicroteachCaseQuantitySenateItems.CollegeNameA] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.CollegeNameA].ToString().Trim(); //学院名称简写
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvMicroteachCaseQuantitySenateItemsEN.IdmicroteachCaseQuantitySenateItem, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvMicroteachCaseQuantitySenateItemsEN);
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
public static List<clsvMicroteachCaseQuantitySenateItemsEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsvMicroteachCaseQuantitySenateItemsEN> arrObjLst = new List<clsvMicroteachCaseQuantitySenateItemsEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvMicroteachCaseQuantitySenateItemsEN objvMicroteachCaseQuantitySenateItemsEN = new clsvMicroteachCaseQuantitySenateItemsEN();
try
{
objvMicroteachCaseQuantitySenateItemsEN.IdmicroteachCaseQuantitySenateItem = Int32.Parse(objRow[convMicroteachCaseQuantitySenateItems.IdmicroteachCaseQuantitySenateItem].ToString().Trim()); //微格量化评价指标流水号
objvMicroteachCaseQuantitySenateItemsEN.IdmicroteachCaseQuantitySenate = Int32.Parse(objRow[convMicroteachCaseQuantitySenateItems.IdmicroteachCaseQuantitySenate].ToString().Trim()); //微格量化评价流水号
objvMicroteachCaseQuantitySenateItemsEN.IdMicroteachCase = objRow[convMicroteachCaseQuantitySenateItems.IdMicroteachCase].ToString().Trim(); //微格教学案例流水号
objvMicroteachCaseQuantitySenateItemsEN.MicroteachCaseID = objRow[convMicroteachCaseQuantitySenateItems.MicroteachCaseID] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.MicroteachCaseID].ToString().Trim(); //微格教学案例ID
objvMicroteachCaseQuantitySenateItemsEN.MicroteachCaseName = objRow[convMicroteachCaseQuantitySenateItems.MicroteachCaseName] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.MicroteachCaseName].ToString().Trim(); //微格教学案例名称
objvMicroteachCaseQuantitySenateItemsEN.IdSenateGaugeItem = objRow[convMicroteachCaseQuantitySenateItems.IdSenateGaugeItem].ToString().Trim(); //量表指标流水号
objvMicroteachCaseQuantitySenateItemsEN.senateGaugeItemID = objRow[convMicroteachCaseQuantitySenateItems.senateGaugeItemID] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.senateGaugeItemID].ToString().Trim(); //量表指标ID
objvMicroteachCaseQuantitySenateItemsEN.senateGaugeItemName = objRow[convMicroteachCaseQuantitySenateItems.senateGaugeItemName] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.senateGaugeItemName].ToString().Trim(); //量表指标名称
objvMicroteachCaseQuantitySenateItemsEN.senateGaugeItemNameWithOrder = objRow[convMicroteachCaseQuantitySenateItems.senateGaugeItemNameWithOrder] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.senateGaugeItemNameWithOrder].ToString().Trim(); //量表指标名称WithOrder
objvMicroteachCaseQuantitySenateItemsEN.senateGaugeItemDesc = objRow[convMicroteachCaseQuantitySenateItems.senateGaugeItemDesc] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.senateGaugeItemDesc].ToString().Trim(); //量表指标说明
objvMicroteachCaseQuantitySenateItemsEN.senateGaugeItemMemo = objRow[convMicroteachCaseQuantitySenateItems.senateGaugeItemMemo] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.senateGaugeItemMemo].ToString().Trim(); //备注
objvMicroteachCaseQuantitySenateItemsEN.senateGaugeItemWeight = objRow[convMicroteachCaseQuantitySenateItems.senateGaugeItemWeight] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convMicroteachCaseQuantitySenateItems.senateGaugeItemWeight].ToString().Trim()); //量表指标权重
objvMicroteachCaseQuantitySenateItemsEN.SenateScore = objRow[convMicroteachCaseQuantitySenateItems.SenateScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convMicroteachCaseQuantitySenateItems.SenateScore].ToString().Trim()); //指标得分
objvMicroteachCaseQuantitySenateItemsEN.IdSenateGaugeSubItem = objRow[convMicroteachCaseQuantitySenateItems.IdSenateGaugeSubItem] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.IdSenateGaugeSubItem].ToString().Trim(); //量表指标子项流水号
objvMicroteachCaseQuantitySenateItemsEN.senateGaugeSubItemID = objRow[convMicroteachCaseQuantitySenateItems.senateGaugeSubItemID] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.senateGaugeSubItemID].ToString().Trim(); //量表指标子项ID
objvMicroteachCaseQuantitySenateItemsEN.senateGaugeSubItemName = objRow[convMicroteachCaseQuantitySenateItems.senateGaugeSubItemName] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.senateGaugeSubItemName].ToString().Trim(); //量表指标子项名称
objvMicroteachCaseQuantitySenateItemsEN.senateGaugeSubItemDesc = objRow[convMicroteachCaseQuantitySenateItems.senateGaugeSubItemDesc] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.senateGaugeSubItemDesc].ToString().Trim(); //量表指标子项说明
objvMicroteachCaseQuantitySenateItemsEN.senateGaugeSubItemMemo = objRow[convMicroteachCaseQuantitySenateItems.senateGaugeSubItemMemo] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.senateGaugeSubItemMemo].ToString().Trim(); //量表指标子项备注
objvMicroteachCaseQuantitySenateItemsEN.senateGaugeSubItemScore = objRow[convMicroteachCaseQuantitySenateItems.senateGaugeSubItemScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convMicroteachCaseQuantitySenateItems.senateGaugeSubItemScore].ToString().Trim()); //量表指标子项分数
objvMicroteachCaseQuantitySenateItemsEN.UserId = objRow[convMicroteachCaseQuantitySenateItems.UserId] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.UserId].ToString().Trim(); //用户ID
objvMicroteachCaseQuantitySenateItemsEN.UserName = objRow[convMicroteachCaseQuantitySenateItems.UserName] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.UserName].ToString().Trim(); //用户名
objvMicroteachCaseQuantitySenateItemsEN.CollegeID = objRow[convMicroteachCaseQuantitySenateItems.CollegeID] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.CollegeID].ToString().Trim(); //学院ID
objvMicroteachCaseQuantitySenateItemsEN.CollegeName = objRow[convMicroteachCaseQuantitySenateItems.CollegeName] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.CollegeName].ToString().Trim(); //学院名称
objvMicroteachCaseQuantitySenateItemsEN.SenateTheme = objRow[convMicroteachCaseQuantitySenateItems.SenateTheme] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.SenateTheme].ToString().Trim(); //量化评价主题
objvMicroteachCaseQuantitySenateItemsEN.SenateContent = objRow[convMicroteachCaseQuantitySenateItems.SenateContent] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.SenateContent].ToString().Trim(); //评价内容
objvMicroteachCaseQuantitySenateItemsEN.SenateDate = objRow[convMicroteachCaseQuantitySenateItems.SenateDate] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.SenateDate].ToString().Trim(); //评价日期
objvMicroteachCaseQuantitySenateItemsEN.SenateTime = objRow[convMicroteachCaseQuantitySenateItems.SenateTime] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.SenateTime].ToString().Trim(); //评价时间
objvMicroteachCaseQuantitySenateItemsEN.SenateTotalScore = objRow[convMicroteachCaseQuantitySenateItems.SenateTotalScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convMicroteachCaseQuantitySenateItems.SenateTotalScore].ToString().Trim()); //评价分数
objvMicroteachCaseQuantitySenateItemsEN.AnswerModeId = objRow[convMicroteachCaseQuantitySenateItems.AnswerModeId] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.AnswerModeId].ToString().Trim(); //答案模式Id
objvMicroteachCaseQuantitySenateItemsEN.AnswerTypeId = objRow[convMicroteachCaseQuantitySenateItems.AnswerTypeId] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.AnswerTypeId].ToString().Trim(); //答案类型ID
objvMicroteachCaseQuantitySenateItemsEN.GridTitle = objRow[convMicroteachCaseQuantitySenateItems.GridTitle] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.GridTitle].ToString().Trim(); //表格标题
objvMicroteachCaseQuantitySenateItemsEN.QuestionIndex = objRow[convMicroteachCaseQuantitySenateItems.QuestionIndex] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convMicroteachCaseQuantitySenateItems.QuestionIndex].ToString().Trim()); //题目序号
objvMicroteachCaseQuantitySenateItemsEN.QuestionNo = objRow[convMicroteachCaseQuantitySenateItems.QuestionNo] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.QuestionNo].ToString().Trim(); //题目编号
objvMicroteachCaseQuantitySenateItemsEN.QuestionTypeId = objRow[convMicroteachCaseQuantitySenateItems.QuestionTypeId] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.QuestionTypeId].ToString().Trim(); //题目类型Id
objvMicroteachCaseQuantitySenateItemsEN.AnswerModeName = objRow[convMicroteachCaseQuantitySenateItems.AnswerModeName] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.AnswerModeName].ToString().Trim(); //答案模式名称
objvMicroteachCaseQuantitySenateItemsEN.AnswerNum = objRow[convMicroteachCaseQuantitySenateItems.AnswerNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convMicroteachCaseQuantitySenateItems.AnswerNum].ToString().Trim()); //答案数
objvMicroteachCaseQuantitySenateItemsEN.AnswerTypeName = objRow[convMicroteachCaseQuantitySenateItems.AnswerTypeName] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.AnswerTypeName].ToString().Trim(); //答案类型名
objvMicroteachCaseQuantitySenateItemsEN.QuestionTypeName = objRow[convMicroteachCaseQuantitySenateItems.QuestionTypeName] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.QuestionTypeName].ToString().Trim(); //题目类型名
objvMicroteachCaseQuantitySenateItemsEN.senateGaugeVersionID = objRow[convMicroteachCaseQuantitySenateItems.senateGaugeVersionID] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.senateGaugeVersionID].ToString().Trim(); //评价量表版本ID
objvMicroteachCaseQuantitySenateItemsEN.senateGaugeVersionName = objRow[convMicroteachCaseQuantitySenateItems.senateGaugeVersionName] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称
objvMicroteachCaseQuantitySenateItemsEN.senateGaugeVersionTtlScore = objRow[convMicroteachCaseQuantitySenateItems.senateGaugeVersionTtlScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convMicroteachCaseQuantitySenateItems.senateGaugeVersionTtlScore].ToString().Trim()); //评价量表版本总分
objvMicroteachCaseQuantitySenateItemsEN.IdSenateGaugeVersion = objRow[convMicroteachCaseQuantitySenateItems.IdSenateGaugeVersion].ToString().Trim(); //评价量表版本流水号
objvMicroteachCaseQuantitySenateItemsEN.AnswerIndex = objRow[convMicroteachCaseQuantitySenateItems.AnswerIndex] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convMicroteachCaseQuantitySenateItems.AnswerIndex].ToString().Trim()); //问答序号
objvMicroteachCaseQuantitySenateItemsEN.AnswerTitle = objRow[convMicroteachCaseQuantitySenateItems.AnswerTitle] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.AnswerTitle].ToString().Trim(); //答案标题
objvMicroteachCaseQuantitySenateItemsEN.OwnerId = objRow[convMicroteachCaseQuantitySenateItems.OwnerId] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.OwnerId].ToString().Trim(); //拥有者Id
objvMicroteachCaseQuantitySenateItemsEN.OwnerName = objRow[convMicroteachCaseQuantitySenateItems.OwnerName] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.OwnerName].ToString().Trim(); //拥有者姓名
objvMicroteachCaseQuantitySenateItemsEN.OwnerNameWithId = objRow[convMicroteachCaseQuantitySenateItems.OwnerNameWithId] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.OwnerNameWithId].ToString().Trim(); //拥有者名称附Id
objvMicroteachCaseQuantitySenateItemsEN.SenateIp = objRow[convMicroteachCaseQuantitySenateItems.SenateIp] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.SenateIp].ToString().Trim(); //评议Ip
objvMicroteachCaseQuantitySenateItemsEN.UserNameWithUserId = objRow[convMicroteachCaseQuantitySenateItems.UserNameWithUserId] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.UserNameWithUserId].ToString().Trim(); //UserNameWithUserId
objvMicroteachCaseQuantitySenateItemsEN.UserTypeId = objRow[convMicroteachCaseQuantitySenateItems.UserTypeId] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.UserTypeId].ToString().Trim(); //用户类型Id
objvMicroteachCaseQuantitySenateItemsEN.IsAccess = clsEntityBase2.TransNullToBool_S(objRow[convMicroteachCaseQuantitySenateItems.IsAccess].ToString().Trim()); //IsAccess
objvMicroteachCaseQuantitySenateItemsEN.IsAccessC = clsEntityBase2.TransNullToBool_S(objRow[convMicroteachCaseQuantitySenateItems.IsAccessC].ToString().Trim()); //IsAccessC
objvMicroteachCaseQuantitySenateItemsEN.UpdDate = objRow[convMicroteachCaseQuantitySenateItems.UpdDate] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.UpdDate].ToString().Trim(); //修改日期
objvMicroteachCaseQuantitySenateItemsEN.UpdUser = objRow[convMicroteachCaseQuantitySenateItems.UpdUser] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.UpdUser].ToString().Trim(); //修改人
objvMicroteachCaseQuantitySenateItemsEN.IdAppraiseType = objRow[convMicroteachCaseQuantitySenateItems.IdAppraiseType] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.IdAppraiseType].ToString().Trim(); //评议类型流水号
objvMicroteachCaseQuantitySenateItemsEN.AppraiseTypeName = objRow[convMicroteachCaseQuantitySenateItems.AppraiseTypeName] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.AppraiseTypeName].ToString().Trim(); //评议类型名称
objvMicroteachCaseQuantitySenateItemsEN.FuncModuleId = objRow[convMicroteachCaseQuantitySenateItems.FuncModuleId] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.FuncModuleId].ToString().Trim(); //功能模块Id
objvMicroteachCaseQuantitySenateItemsEN.UserKindId = objRow[convMicroteachCaseQuantitySenateItems.UserKindId] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.UserKindId].ToString().Trim(); //用户类别Id
objvMicroteachCaseQuantitySenateItemsEN.UserKindName = objRow[convMicroteachCaseQuantitySenateItems.UserKindName] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.UserKindName].ToString().Trim(); //用户类别名
objvMicroteachCaseQuantitySenateItemsEN.UserTypeName = objRow[convMicroteachCaseQuantitySenateItems.UserTypeName] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.UserTypeName].ToString().Trim(); //用户类型名称
objvMicroteachCaseQuantitySenateItemsEN.FuncModuleName = objRow[convMicroteachCaseQuantitySenateItems.FuncModuleName] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.FuncModuleName].ToString().Trim(); //功能模块名称
objvMicroteachCaseQuantitySenateItemsEN.IdXzCollege = objRow[convMicroteachCaseQuantitySenateItems.IdXzCollege] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.IdXzCollege].ToString().Trim(); //学院流水号
objvMicroteachCaseQuantitySenateItemsEN.CollegeNameA = objRow[convMicroteachCaseQuantitySenateItems.CollegeNameA] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.CollegeNameA].ToString().Trim(); //学院名称简写
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvMicroteachCaseQuantitySenateItemsEN.IdmicroteachCaseQuantitySenateItem, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvMicroteachCaseQuantitySenateItemsEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsvMicroteachCaseQuantitySenateItemsEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsvMicroteachCaseQuantitySenateItemsEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsvMicroteachCaseQuantitySenateItemsEN> arrObjLst = new List<clsvMicroteachCaseQuantitySenateItemsEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvMicroteachCaseQuantitySenateItemsEN objvMicroteachCaseQuantitySenateItemsEN = new clsvMicroteachCaseQuantitySenateItemsEN();
try
{
objvMicroteachCaseQuantitySenateItemsEN.IdmicroteachCaseQuantitySenateItem = Int32.Parse(objRow[convMicroteachCaseQuantitySenateItems.IdmicroteachCaseQuantitySenateItem].ToString().Trim()); //微格量化评价指标流水号
objvMicroteachCaseQuantitySenateItemsEN.IdmicroteachCaseQuantitySenate = Int32.Parse(objRow[convMicroteachCaseQuantitySenateItems.IdmicroteachCaseQuantitySenate].ToString().Trim()); //微格量化评价流水号
objvMicroteachCaseQuantitySenateItemsEN.IdMicroteachCase = objRow[convMicroteachCaseQuantitySenateItems.IdMicroteachCase].ToString().Trim(); //微格教学案例流水号
objvMicroteachCaseQuantitySenateItemsEN.MicroteachCaseID = objRow[convMicroteachCaseQuantitySenateItems.MicroteachCaseID] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.MicroteachCaseID].ToString().Trim(); //微格教学案例ID
objvMicroteachCaseQuantitySenateItemsEN.MicroteachCaseName = objRow[convMicroteachCaseQuantitySenateItems.MicroteachCaseName] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.MicroteachCaseName].ToString().Trim(); //微格教学案例名称
objvMicroteachCaseQuantitySenateItemsEN.IdSenateGaugeItem = objRow[convMicroteachCaseQuantitySenateItems.IdSenateGaugeItem].ToString().Trim(); //量表指标流水号
objvMicroteachCaseQuantitySenateItemsEN.senateGaugeItemID = objRow[convMicroteachCaseQuantitySenateItems.senateGaugeItemID] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.senateGaugeItemID].ToString().Trim(); //量表指标ID
objvMicroteachCaseQuantitySenateItemsEN.senateGaugeItemName = objRow[convMicroteachCaseQuantitySenateItems.senateGaugeItemName] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.senateGaugeItemName].ToString().Trim(); //量表指标名称
objvMicroteachCaseQuantitySenateItemsEN.senateGaugeItemNameWithOrder = objRow[convMicroteachCaseQuantitySenateItems.senateGaugeItemNameWithOrder] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.senateGaugeItemNameWithOrder].ToString().Trim(); //量表指标名称WithOrder
objvMicroteachCaseQuantitySenateItemsEN.senateGaugeItemDesc = objRow[convMicroteachCaseQuantitySenateItems.senateGaugeItemDesc] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.senateGaugeItemDesc].ToString().Trim(); //量表指标说明
objvMicroteachCaseQuantitySenateItemsEN.senateGaugeItemMemo = objRow[convMicroteachCaseQuantitySenateItems.senateGaugeItemMemo] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.senateGaugeItemMemo].ToString().Trim(); //备注
objvMicroteachCaseQuantitySenateItemsEN.senateGaugeItemWeight = objRow[convMicroteachCaseQuantitySenateItems.senateGaugeItemWeight] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convMicroteachCaseQuantitySenateItems.senateGaugeItemWeight].ToString().Trim()); //量表指标权重
objvMicroteachCaseQuantitySenateItemsEN.SenateScore = objRow[convMicroteachCaseQuantitySenateItems.SenateScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convMicroteachCaseQuantitySenateItems.SenateScore].ToString().Trim()); //指标得分
objvMicroteachCaseQuantitySenateItemsEN.IdSenateGaugeSubItem = objRow[convMicroteachCaseQuantitySenateItems.IdSenateGaugeSubItem] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.IdSenateGaugeSubItem].ToString().Trim(); //量表指标子项流水号
objvMicroteachCaseQuantitySenateItemsEN.senateGaugeSubItemID = objRow[convMicroteachCaseQuantitySenateItems.senateGaugeSubItemID] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.senateGaugeSubItemID].ToString().Trim(); //量表指标子项ID
objvMicroteachCaseQuantitySenateItemsEN.senateGaugeSubItemName = objRow[convMicroteachCaseQuantitySenateItems.senateGaugeSubItemName] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.senateGaugeSubItemName].ToString().Trim(); //量表指标子项名称
objvMicroteachCaseQuantitySenateItemsEN.senateGaugeSubItemDesc = objRow[convMicroteachCaseQuantitySenateItems.senateGaugeSubItemDesc] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.senateGaugeSubItemDesc].ToString().Trim(); //量表指标子项说明
objvMicroteachCaseQuantitySenateItemsEN.senateGaugeSubItemMemo = objRow[convMicroteachCaseQuantitySenateItems.senateGaugeSubItemMemo] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.senateGaugeSubItemMemo].ToString().Trim(); //量表指标子项备注
objvMicroteachCaseQuantitySenateItemsEN.senateGaugeSubItemScore = objRow[convMicroteachCaseQuantitySenateItems.senateGaugeSubItemScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convMicroteachCaseQuantitySenateItems.senateGaugeSubItemScore].ToString().Trim()); //量表指标子项分数
objvMicroteachCaseQuantitySenateItemsEN.UserId = objRow[convMicroteachCaseQuantitySenateItems.UserId] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.UserId].ToString().Trim(); //用户ID
objvMicroteachCaseQuantitySenateItemsEN.UserName = objRow[convMicroteachCaseQuantitySenateItems.UserName] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.UserName].ToString().Trim(); //用户名
objvMicroteachCaseQuantitySenateItemsEN.CollegeID = objRow[convMicroteachCaseQuantitySenateItems.CollegeID] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.CollegeID].ToString().Trim(); //学院ID
objvMicroteachCaseQuantitySenateItemsEN.CollegeName = objRow[convMicroteachCaseQuantitySenateItems.CollegeName] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.CollegeName].ToString().Trim(); //学院名称
objvMicroteachCaseQuantitySenateItemsEN.SenateTheme = objRow[convMicroteachCaseQuantitySenateItems.SenateTheme] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.SenateTheme].ToString().Trim(); //量化评价主题
objvMicroteachCaseQuantitySenateItemsEN.SenateContent = objRow[convMicroteachCaseQuantitySenateItems.SenateContent] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.SenateContent].ToString().Trim(); //评价内容
objvMicroteachCaseQuantitySenateItemsEN.SenateDate = objRow[convMicroteachCaseQuantitySenateItems.SenateDate] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.SenateDate].ToString().Trim(); //评价日期
objvMicroteachCaseQuantitySenateItemsEN.SenateTime = objRow[convMicroteachCaseQuantitySenateItems.SenateTime] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.SenateTime].ToString().Trim(); //评价时间
objvMicroteachCaseQuantitySenateItemsEN.SenateTotalScore = objRow[convMicroteachCaseQuantitySenateItems.SenateTotalScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convMicroteachCaseQuantitySenateItems.SenateTotalScore].ToString().Trim()); //评价分数
objvMicroteachCaseQuantitySenateItemsEN.AnswerModeId = objRow[convMicroteachCaseQuantitySenateItems.AnswerModeId] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.AnswerModeId].ToString().Trim(); //答案模式Id
objvMicroteachCaseQuantitySenateItemsEN.AnswerTypeId = objRow[convMicroteachCaseQuantitySenateItems.AnswerTypeId] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.AnswerTypeId].ToString().Trim(); //答案类型ID
objvMicroteachCaseQuantitySenateItemsEN.GridTitle = objRow[convMicroteachCaseQuantitySenateItems.GridTitle] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.GridTitle].ToString().Trim(); //表格标题
objvMicroteachCaseQuantitySenateItemsEN.QuestionIndex = objRow[convMicroteachCaseQuantitySenateItems.QuestionIndex] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convMicroteachCaseQuantitySenateItems.QuestionIndex].ToString().Trim()); //题目序号
objvMicroteachCaseQuantitySenateItemsEN.QuestionNo = objRow[convMicroteachCaseQuantitySenateItems.QuestionNo] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.QuestionNo].ToString().Trim(); //题目编号
objvMicroteachCaseQuantitySenateItemsEN.QuestionTypeId = objRow[convMicroteachCaseQuantitySenateItems.QuestionTypeId] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.QuestionTypeId].ToString().Trim(); //题目类型Id
objvMicroteachCaseQuantitySenateItemsEN.AnswerModeName = objRow[convMicroteachCaseQuantitySenateItems.AnswerModeName] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.AnswerModeName].ToString().Trim(); //答案模式名称
objvMicroteachCaseQuantitySenateItemsEN.AnswerNum = objRow[convMicroteachCaseQuantitySenateItems.AnswerNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convMicroteachCaseQuantitySenateItems.AnswerNum].ToString().Trim()); //答案数
objvMicroteachCaseQuantitySenateItemsEN.AnswerTypeName = objRow[convMicroteachCaseQuantitySenateItems.AnswerTypeName] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.AnswerTypeName].ToString().Trim(); //答案类型名
objvMicroteachCaseQuantitySenateItemsEN.QuestionTypeName = objRow[convMicroteachCaseQuantitySenateItems.QuestionTypeName] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.QuestionTypeName].ToString().Trim(); //题目类型名
objvMicroteachCaseQuantitySenateItemsEN.senateGaugeVersionID = objRow[convMicroteachCaseQuantitySenateItems.senateGaugeVersionID] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.senateGaugeVersionID].ToString().Trim(); //评价量表版本ID
objvMicroteachCaseQuantitySenateItemsEN.senateGaugeVersionName = objRow[convMicroteachCaseQuantitySenateItems.senateGaugeVersionName] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称
objvMicroteachCaseQuantitySenateItemsEN.senateGaugeVersionTtlScore = objRow[convMicroteachCaseQuantitySenateItems.senateGaugeVersionTtlScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convMicroteachCaseQuantitySenateItems.senateGaugeVersionTtlScore].ToString().Trim()); //评价量表版本总分
objvMicroteachCaseQuantitySenateItemsEN.IdSenateGaugeVersion = objRow[convMicroteachCaseQuantitySenateItems.IdSenateGaugeVersion].ToString().Trim(); //评价量表版本流水号
objvMicroteachCaseQuantitySenateItemsEN.AnswerIndex = objRow[convMicroteachCaseQuantitySenateItems.AnswerIndex] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convMicroteachCaseQuantitySenateItems.AnswerIndex].ToString().Trim()); //问答序号
objvMicroteachCaseQuantitySenateItemsEN.AnswerTitle = objRow[convMicroteachCaseQuantitySenateItems.AnswerTitle] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.AnswerTitle].ToString().Trim(); //答案标题
objvMicroteachCaseQuantitySenateItemsEN.OwnerId = objRow[convMicroteachCaseQuantitySenateItems.OwnerId] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.OwnerId].ToString().Trim(); //拥有者Id
objvMicroteachCaseQuantitySenateItemsEN.OwnerName = objRow[convMicroteachCaseQuantitySenateItems.OwnerName] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.OwnerName].ToString().Trim(); //拥有者姓名
objvMicroteachCaseQuantitySenateItemsEN.OwnerNameWithId = objRow[convMicroteachCaseQuantitySenateItems.OwnerNameWithId] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.OwnerNameWithId].ToString().Trim(); //拥有者名称附Id
objvMicroteachCaseQuantitySenateItemsEN.SenateIp = objRow[convMicroteachCaseQuantitySenateItems.SenateIp] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.SenateIp].ToString().Trim(); //评议Ip
objvMicroteachCaseQuantitySenateItemsEN.UserNameWithUserId = objRow[convMicroteachCaseQuantitySenateItems.UserNameWithUserId] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.UserNameWithUserId].ToString().Trim(); //UserNameWithUserId
objvMicroteachCaseQuantitySenateItemsEN.UserTypeId = objRow[convMicroteachCaseQuantitySenateItems.UserTypeId] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.UserTypeId].ToString().Trim(); //用户类型Id
objvMicroteachCaseQuantitySenateItemsEN.IsAccess = clsEntityBase2.TransNullToBool_S(objRow[convMicroteachCaseQuantitySenateItems.IsAccess].ToString().Trim()); //IsAccess
objvMicroteachCaseQuantitySenateItemsEN.IsAccessC = clsEntityBase2.TransNullToBool_S(objRow[convMicroteachCaseQuantitySenateItems.IsAccessC].ToString().Trim()); //IsAccessC
objvMicroteachCaseQuantitySenateItemsEN.UpdDate = objRow[convMicroteachCaseQuantitySenateItems.UpdDate] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.UpdDate].ToString().Trim(); //修改日期
objvMicroteachCaseQuantitySenateItemsEN.UpdUser = objRow[convMicroteachCaseQuantitySenateItems.UpdUser] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.UpdUser].ToString().Trim(); //修改人
objvMicroteachCaseQuantitySenateItemsEN.IdAppraiseType = objRow[convMicroteachCaseQuantitySenateItems.IdAppraiseType] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.IdAppraiseType].ToString().Trim(); //评议类型流水号
objvMicroteachCaseQuantitySenateItemsEN.AppraiseTypeName = objRow[convMicroteachCaseQuantitySenateItems.AppraiseTypeName] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.AppraiseTypeName].ToString().Trim(); //评议类型名称
objvMicroteachCaseQuantitySenateItemsEN.FuncModuleId = objRow[convMicroteachCaseQuantitySenateItems.FuncModuleId] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.FuncModuleId].ToString().Trim(); //功能模块Id
objvMicroteachCaseQuantitySenateItemsEN.UserKindId = objRow[convMicroteachCaseQuantitySenateItems.UserKindId] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.UserKindId].ToString().Trim(); //用户类别Id
objvMicroteachCaseQuantitySenateItemsEN.UserKindName = objRow[convMicroteachCaseQuantitySenateItems.UserKindName] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.UserKindName].ToString().Trim(); //用户类别名
objvMicroteachCaseQuantitySenateItemsEN.UserTypeName = objRow[convMicroteachCaseQuantitySenateItems.UserTypeName] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.UserTypeName].ToString().Trim(); //用户类型名称
objvMicroteachCaseQuantitySenateItemsEN.FuncModuleName = objRow[convMicroteachCaseQuantitySenateItems.FuncModuleName] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.FuncModuleName].ToString().Trim(); //功能模块名称
objvMicroteachCaseQuantitySenateItemsEN.IdXzCollege = objRow[convMicroteachCaseQuantitySenateItems.IdXzCollege] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.IdXzCollege].ToString().Trim(); //学院流水号
objvMicroteachCaseQuantitySenateItemsEN.CollegeNameA = objRow[convMicroteachCaseQuantitySenateItems.CollegeNameA] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.CollegeNameA].ToString().Trim(); //学院名称简写
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvMicroteachCaseQuantitySenateItemsEN.IdmicroteachCaseQuantitySenateItem, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvMicroteachCaseQuantitySenateItemsEN);
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
public static List<clsvMicroteachCaseQuantitySenateItemsEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsvMicroteachCaseQuantitySenateItemsEN> arrObjLst = new List<clsvMicroteachCaseQuantitySenateItemsEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvMicroteachCaseQuantitySenateItemsEN objvMicroteachCaseQuantitySenateItemsEN = new clsvMicroteachCaseQuantitySenateItemsEN();
try
{
objvMicroteachCaseQuantitySenateItemsEN.IdmicroteachCaseQuantitySenateItem = Int32.Parse(objRow[convMicroteachCaseQuantitySenateItems.IdmicroteachCaseQuantitySenateItem].ToString().Trim()); //微格量化评价指标流水号
objvMicroteachCaseQuantitySenateItemsEN.IdmicroteachCaseQuantitySenate = Int32.Parse(objRow[convMicroteachCaseQuantitySenateItems.IdmicroteachCaseQuantitySenate].ToString().Trim()); //微格量化评价流水号
objvMicroteachCaseQuantitySenateItemsEN.IdMicroteachCase = objRow[convMicroteachCaseQuantitySenateItems.IdMicroteachCase].ToString().Trim(); //微格教学案例流水号
objvMicroteachCaseQuantitySenateItemsEN.MicroteachCaseID = objRow[convMicroteachCaseQuantitySenateItems.MicroteachCaseID] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.MicroteachCaseID].ToString().Trim(); //微格教学案例ID
objvMicroteachCaseQuantitySenateItemsEN.MicroteachCaseName = objRow[convMicroteachCaseQuantitySenateItems.MicroteachCaseName] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.MicroteachCaseName].ToString().Trim(); //微格教学案例名称
objvMicroteachCaseQuantitySenateItemsEN.IdSenateGaugeItem = objRow[convMicroteachCaseQuantitySenateItems.IdSenateGaugeItem].ToString().Trim(); //量表指标流水号
objvMicroteachCaseQuantitySenateItemsEN.senateGaugeItemID = objRow[convMicroteachCaseQuantitySenateItems.senateGaugeItemID] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.senateGaugeItemID].ToString().Trim(); //量表指标ID
objvMicroteachCaseQuantitySenateItemsEN.senateGaugeItemName = objRow[convMicroteachCaseQuantitySenateItems.senateGaugeItemName] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.senateGaugeItemName].ToString().Trim(); //量表指标名称
objvMicroteachCaseQuantitySenateItemsEN.senateGaugeItemNameWithOrder = objRow[convMicroteachCaseQuantitySenateItems.senateGaugeItemNameWithOrder] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.senateGaugeItemNameWithOrder].ToString().Trim(); //量表指标名称WithOrder
objvMicroteachCaseQuantitySenateItemsEN.senateGaugeItemDesc = objRow[convMicroteachCaseQuantitySenateItems.senateGaugeItemDesc] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.senateGaugeItemDesc].ToString().Trim(); //量表指标说明
objvMicroteachCaseQuantitySenateItemsEN.senateGaugeItemMemo = objRow[convMicroteachCaseQuantitySenateItems.senateGaugeItemMemo] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.senateGaugeItemMemo].ToString().Trim(); //备注
objvMicroteachCaseQuantitySenateItemsEN.senateGaugeItemWeight = objRow[convMicroteachCaseQuantitySenateItems.senateGaugeItemWeight] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convMicroteachCaseQuantitySenateItems.senateGaugeItemWeight].ToString().Trim()); //量表指标权重
objvMicroteachCaseQuantitySenateItemsEN.SenateScore = objRow[convMicroteachCaseQuantitySenateItems.SenateScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convMicroteachCaseQuantitySenateItems.SenateScore].ToString().Trim()); //指标得分
objvMicroteachCaseQuantitySenateItemsEN.IdSenateGaugeSubItem = objRow[convMicroteachCaseQuantitySenateItems.IdSenateGaugeSubItem] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.IdSenateGaugeSubItem].ToString().Trim(); //量表指标子项流水号
objvMicroteachCaseQuantitySenateItemsEN.senateGaugeSubItemID = objRow[convMicroteachCaseQuantitySenateItems.senateGaugeSubItemID] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.senateGaugeSubItemID].ToString().Trim(); //量表指标子项ID
objvMicroteachCaseQuantitySenateItemsEN.senateGaugeSubItemName = objRow[convMicroteachCaseQuantitySenateItems.senateGaugeSubItemName] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.senateGaugeSubItemName].ToString().Trim(); //量表指标子项名称
objvMicroteachCaseQuantitySenateItemsEN.senateGaugeSubItemDesc = objRow[convMicroteachCaseQuantitySenateItems.senateGaugeSubItemDesc] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.senateGaugeSubItemDesc].ToString().Trim(); //量表指标子项说明
objvMicroteachCaseQuantitySenateItemsEN.senateGaugeSubItemMemo = objRow[convMicroteachCaseQuantitySenateItems.senateGaugeSubItemMemo] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.senateGaugeSubItemMemo].ToString().Trim(); //量表指标子项备注
objvMicroteachCaseQuantitySenateItemsEN.senateGaugeSubItemScore = objRow[convMicroteachCaseQuantitySenateItems.senateGaugeSubItemScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convMicroteachCaseQuantitySenateItems.senateGaugeSubItemScore].ToString().Trim()); //量表指标子项分数
objvMicroteachCaseQuantitySenateItemsEN.UserId = objRow[convMicroteachCaseQuantitySenateItems.UserId] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.UserId].ToString().Trim(); //用户ID
objvMicroteachCaseQuantitySenateItemsEN.UserName = objRow[convMicroteachCaseQuantitySenateItems.UserName] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.UserName].ToString().Trim(); //用户名
objvMicroteachCaseQuantitySenateItemsEN.CollegeID = objRow[convMicroteachCaseQuantitySenateItems.CollegeID] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.CollegeID].ToString().Trim(); //学院ID
objvMicroteachCaseQuantitySenateItemsEN.CollegeName = objRow[convMicroteachCaseQuantitySenateItems.CollegeName] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.CollegeName].ToString().Trim(); //学院名称
objvMicroteachCaseQuantitySenateItemsEN.SenateTheme = objRow[convMicroteachCaseQuantitySenateItems.SenateTheme] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.SenateTheme].ToString().Trim(); //量化评价主题
objvMicroteachCaseQuantitySenateItemsEN.SenateContent = objRow[convMicroteachCaseQuantitySenateItems.SenateContent] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.SenateContent].ToString().Trim(); //评价内容
objvMicroteachCaseQuantitySenateItemsEN.SenateDate = objRow[convMicroteachCaseQuantitySenateItems.SenateDate] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.SenateDate].ToString().Trim(); //评价日期
objvMicroteachCaseQuantitySenateItemsEN.SenateTime = objRow[convMicroteachCaseQuantitySenateItems.SenateTime] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.SenateTime].ToString().Trim(); //评价时间
objvMicroteachCaseQuantitySenateItemsEN.SenateTotalScore = objRow[convMicroteachCaseQuantitySenateItems.SenateTotalScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convMicroteachCaseQuantitySenateItems.SenateTotalScore].ToString().Trim()); //评价分数
objvMicroteachCaseQuantitySenateItemsEN.AnswerModeId = objRow[convMicroteachCaseQuantitySenateItems.AnswerModeId] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.AnswerModeId].ToString().Trim(); //答案模式Id
objvMicroteachCaseQuantitySenateItemsEN.AnswerTypeId = objRow[convMicroteachCaseQuantitySenateItems.AnswerTypeId] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.AnswerTypeId].ToString().Trim(); //答案类型ID
objvMicroteachCaseQuantitySenateItemsEN.GridTitle = objRow[convMicroteachCaseQuantitySenateItems.GridTitle] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.GridTitle].ToString().Trim(); //表格标题
objvMicroteachCaseQuantitySenateItemsEN.QuestionIndex = objRow[convMicroteachCaseQuantitySenateItems.QuestionIndex] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convMicroteachCaseQuantitySenateItems.QuestionIndex].ToString().Trim()); //题目序号
objvMicroteachCaseQuantitySenateItemsEN.QuestionNo = objRow[convMicroteachCaseQuantitySenateItems.QuestionNo] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.QuestionNo].ToString().Trim(); //题目编号
objvMicroteachCaseQuantitySenateItemsEN.QuestionTypeId = objRow[convMicroteachCaseQuantitySenateItems.QuestionTypeId] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.QuestionTypeId].ToString().Trim(); //题目类型Id
objvMicroteachCaseQuantitySenateItemsEN.AnswerModeName = objRow[convMicroteachCaseQuantitySenateItems.AnswerModeName] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.AnswerModeName].ToString().Trim(); //答案模式名称
objvMicroteachCaseQuantitySenateItemsEN.AnswerNum = objRow[convMicroteachCaseQuantitySenateItems.AnswerNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convMicroteachCaseQuantitySenateItems.AnswerNum].ToString().Trim()); //答案数
objvMicroteachCaseQuantitySenateItemsEN.AnswerTypeName = objRow[convMicroteachCaseQuantitySenateItems.AnswerTypeName] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.AnswerTypeName].ToString().Trim(); //答案类型名
objvMicroteachCaseQuantitySenateItemsEN.QuestionTypeName = objRow[convMicroteachCaseQuantitySenateItems.QuestionTypeName] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.QuestionTypeName].ToString().Trim(); //题目类型名
objvMicroteachCaseQuantitySenateItemsEN.senateGaugeVersionID = objRow[convMicroteachCaseQuantitySenateItems.senateGaugeVersionID] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.senateGaugeVersionID].ToString().Trim(); //评价量表版本ID
objvMicroteachCaseQuantitySenateItemsEN.senateGaugeVersionName = objRow[convMicroteachCaseQuantitySenateItems.senateGaugeVersionName] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称
objvMicroteachCaseQuantitySenateItemsEN.senateGaugeVersionTtlScore = objRow[convMicroteachCaseQuantitySenateItems.senateGaugeVersionTtlScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convMicroteachCaseQuantitySenateItems.senateGaugeVersionTtlScore].ToString().Trim()); //评价量表版本总分
objvMicroteachCaseQuantitySenateItemsEN.IdSenateGaugeVersion = objRow[convMicroteachCaseQuantitySenateItems.IdSenateGaugeVersion].ToString().Trim(); //评价量表版本流水号
objvMicroteachCaseQuantitySenateItemsEN.AnswerIndex = objRow[convMicroteachCaseQuantitySenateItems.AnswerIndex] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convMicroteachCaseQuantitySenateItems.AnswerIndex].ToString().Trim()); //问答序号
objvMicroteachCaseQuantitySenateItemsEN.AnswerTitle = objRow[convMicroteachCaseQuantitySenateItems.AnswerTitle] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.AnswerTitle].ToString().Trim(); //答案标题
objvMicroteachCaseQuantitySenateItemsEN.OwnerId = objRow[convMicroteachCaseQuantitySenateItems.OwnerId] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.OwnerId].ToString().Trim(); //拥有者Id
objvMicroteachCaseQuantitySenateItemsEN.OwnerName = objRow[convMicroteachCaseQuantitySenateItems.OwnerName] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.OwnerName].ToString().Trim(); //拥有者姓名
objvMicroteachCaseQuantitySenateItemsEN.OwnerNameWithId = objRow[convMicroteachCaseQuantitySenateItems.OwnerNameWithId] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.OwnerNameWithId].ToString().Trim(); //拥有者名称附Id
objvMicroteachCaseQuantitySenateItemsEN.SenateIp = objRow[convMicroteachCaseQuantitySenateItems.SenateIp] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.SenateIp].ToString().Trim(); //评议Ip
objvMicroteachCaseQuantitySenateItemsEN.UserNameWithUserId = objRow[convMicroteachCaseQuantitySenateItems.UserNameWithUserId] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.UserNameWithUserId].ToString().Trim(); //UserNameWithUserId
objvMicroteachCaseQuantitySenateItemsEN.UserTypeId = objRow[convMicroteachCaseQuantitySenateItems.UserTypeId] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.UserTypeId].ToString().Trim(); //用户类型Id
objvMicroteachCaseQuantitySenateItemsEN.IsAccess = clsEntityBase2.TransNullToBool_S(objRow[convMicroteachCaseQuantitySenateItems.IsAccess].ToString().Trim()); //IsAccess
objvMicroteachCaseQuantitySenateItemsEN.IsAccessC = clsEntityBase2.TransNullToBool_S(objRow[convMicroteachCaseQuantitySenateItems.IsAccessC].ToString().Trim()); //IsAccessC
objvMicroteachCaseQuantitySenateItemsEN.UpdDate = objRow[convMicroteachCaseQuantitySenateItems.UpdDate] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.UpdDate].ToString().Trim(); //修改日期
objvMicroteachCaseQuantitySenateItemsEN.UpdUser = objRow[convMicroteachCaseQuantitySenateItems.UpdUser] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.UpdUser].ToString().Trim(); //修改人
objvMicroteachCaseQuantitySenateItemsEN.IdAppraiseType = objRow[convMicroteachCaseQuantitySenateItems.IdAppraiseType] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.IdAppraiseType].ToString().Trim(); //评议类型流水号
objvMicroteachCaseQuantitySenateItemsEN.AppraiseTypeName = objRow[convMicroteachCaseQuantitySenateItems.AppraiseTypeName] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.AppraiseTypeName].ToString().Trim(); //评议类型名称
objvMicroteachCaseQuantitySenateItemsEN.FuncModuleId = objRow[convMicroteachCaseQuantitySenateItems.FuncModuleId] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.FuncModuleId].ToString().Trim(); //功能模块Id
objvMicroteachCaseQuantitySenateItemsEN.UserKindId = objRow[convMicroteachCaseQuantitySenateItems.UserKindId] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.UserKindId].ToString().Trim(); //用户类别Id
objvMicroteachCaseQuantitySenateItemsEN.UserKindName = objRow[convMicroteachCaseQuantitySenateItems.UserKindName] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.UserKindName].ToString().Trim(); //用户类别名
objvMicroteachCaseQuantitySenateItemsEN.UserTypeName = objRow[convMicroteachCaseQuantitySenateItems.UserTypeName] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.UserTypeName].ToString().Trim(); //用户类型名称
objvMicroteachCaseQuantitySenateItemsEN.FuncModuleName = objRow[convMicroteachCaseQuantitySenateItems.FuncModuleName] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.FuncModuleName].ToString().Trim(); //功能模块名称
objvMicroteachCaseQuantitySenateItemsEN.IdXzCollege = objRow[convMicroteachCaseQuantitySenateItems.IdXzCollege] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.IdXzCollege].ToString().Trim(); //学院流水号
objvMicroteachCaseQuantitySenateItemsEN.CollegeNameA = objRow[convMicroteachCaseQuantitySenateItems.CollegeNameA] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.CollegeNameA].ToString().Trim(); //学院名称简写
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvMicroteachCaseQuantitySenateItemsEN.IdmicroteachCaseQuantitySenateItem, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvMicroteachCaseQuantitySenateItemsEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsvMicroteachCaseQuantitySenateItemsEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsvMicroteachCaseQuantitySenateItemsEN> arrObjLst = new List<clsvMicroteachCaseQuantitySenateItemsEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvMicroteachCaseQuantitySenateItemsEN objvMicroteachCaseQuantitySenateItemsEN = new clsvMicroteachCaseQuantitySenateItemsEN();
try
{
objvMicroteachCaseQuantitySenateItemsEN.IdmicroteachCaseQuantitySenateItem = Int32.Parse(objRow[convMicroteachCaseQuantitySenateItems.IdmicroteachCaseQuantitySenateItem].ToString().Trim()); //微格量化评价指标流水号
objvMicroteachCaseQuantitySenateItemsEN.IdmicroteachCaseQuantitySenate = Int32.Parse(objRow[convMicroteachCaseQuantitySenateItems.IdmicroteachCaseQuantitySenate].ToString().Trim()); //微格量化评价流水号
objvMicroteachCaseQuantitySenateItemsEN.IdMicroteachCase = objRow[convMicroteachCaseQuantitySenateItems.IdMicroteachCase].ToString().Trim(); //微格教学案例流水号
objvMicroteachCaseQuantitySenateItemsEN.MicroteachCaseID = objRow[convMicroteachCaseQuantitySenateItems.MicroteachCaseID] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.MicroteachCaseID].ToString().Trim(); //微格教学案例ID
objvMicroteachCaseQuantitySenateItemsEN.MicroteachCaseName = objRow[convMicroteachCaseQuantitySenateItems.MicroteachCaseName] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.MicroteachCaseName].ToString().Trim(); //微格教学案例名称
objvMicroteachCaseQuantitySenateItemsEN.IdSenateGaugeItem = objRow[convMicroteachCaseQuantitySenateItems.IdSenateGaugeItem].ToString().Trim(); //量表指标流水号
objvMicroteachCaseQuantitySenateItemsEN.senateGaugeItemID = objRow[convMicroteachCaseQuantitySenateItems.senateGaugeItemID] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.senateGaugeItemID].ToString().Trim(); //量表指标ID
objvMicroteachCaseQuantitySenateItemsEN.senateGaugeItemName = objRow[convMicroteachCaseQuantitySenateItems.senateGaugeItemName] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.senateGaugeItemName].ToString().Trim(); //量表指标名称
objvMicroteachCaseQuantitySenateItemsEN.senateGaugeItemNameWithOrder = objRow[convMicroteachCaseQuantitySenateItems.senateGaugeItemNameWithOrder] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.senateGaugeItemNameWithOrder].ToString().Trim(); //量表指标名称WithOrder
objvMicroteachCaseQuantitySenateItemsEN.senateGaugeItemDesc = objRow[convMicroteachCaseQuantitySenateItems.senateGaugeItemDesc] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.senateGaugeItemDesc].ToString().Trim(); //量表指标说明
objvMicroteachCaseQuantitySenateItemsEN.senateGaugeItemMemo = objRow[convMicroteachCaseQuantitySenateItems.senateGaugeItemMemo] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.senateGaugeItemMemo].ToString().Trim(); //备注
objvMicroteachCaseQuantitySenateItemsEN.senateGaugeItemWeight = objRow[convMicroteachCaseQuantitySenateItems.senateGaugeItemWeight] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convMicroteachCaseQuantitySenateItems.senateGaugeItemWeight].ToString().Trim()); //量表指标权重
objvMicroteachCaseQuantitySenateItemsEN.SenateScore = objRow[convMicroteachCaseQuantitySenateItems.SenateScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convMicroteachCaseQuantitySenateItems.SenateScore].ToString().Trim()); //指标得分
objvMicroteachCaseQuantitySenateItemsEN.IdSenateGaugeSubItem = objRow[convMicroteachCaseQuantitySenateItems.IdSenateGaugeSubItem] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.IdSenateGaugeSubItem].ToString().Trim(); //量表指标子项流水号
objvMicroteachCaseQuantitySenateItemsEN.senateGaugeSubItemID = objRow[convMicroteachCaseQuantitySenateItems.senateGaugeSubItemID] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.senateGaugeSubItemID].ToString().Trim(); //量表指标子项ID
objvMicroteachCaseQuantitySenateItemsEN.senateGaugeSubItemName = objRow[convMicroteachCaseQuantitySenateItems.senateGaugeSubItemName] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.senateGaugeSubItemName].ToString().Trim(); //量表指标子项名称
objvMicroteachCaseQuantitySenateItemsEN.senateGaugeSubItemDesc = objRow[convMicroteachCaseQuantitySenateItems.senateGaugeSubItemDesc] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.senateGaugeSubItemDesc].ToString().Trim(); //量表指标子项说明
objvMicroteachCaseQuantitySenateItemsEN.senateGaugeSubItemMemo = objRow[convMicroteachCaseQuantitySenateItems.senateGaugeSubItemMemo] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.senateGaugeSubItemMemo].ToString().Trim(); //量表指标子项备注
objvMicroteachCaseQuantitySenateItemsEN.senateGaugeSubItemScore = objRow[convMicroteachCaseQuantitySenateItems.senateGaugeSubItemScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convMicroteachCaseQuantitySenateItems.senateGaugeSubItemScore].ToString().Trim()); //量表指标子项分数
objvMicroteachCaseQuantitySenateItemsEN.UserId = objRow[convMicroteachCaseQuantitySenateItems.UserId] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.UserId].ToString().Trim(); //用户ID
objvMicroteachCaseQuantitySenateItemsEN.UserName = objRow[convMicroteachCaseQuantitySenateItems.UserName] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.UserName].ToString().Trim(); //用户名
objvMicroteachCaseQuantitySenateItemsEN.CollegeID = objRow[convMicroteachCaseQuantitySenateItems.CollegeID] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.CollegeID].ToString().Trim(); //学院ID
objvMicroteachCaseQuantitySenateItemsEN.CollegeName = objRow[convMicroteachCaseQuantitySenateItems.CollegeName] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.CollegeName].ToString().Trim(); //学院名称
objvMicroteachCaseQuantitySenateItemsEN.SenateTheme = objRow[convMicroteachCaseQuantitySenateItems.SenateTheme] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.SenateTheme].ToString().Trim(); //量化评价主题
objvMicroteachCaseQuantitySenateItemsEN.SenateContent = objRow[convMicroteachCaseQuantitySenateItems.SenateContent] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.SenateContent].ToString().Trim(); //评价内容
objvMicroteachCaseQuantitySenateItemsEN.SenateDate = objRow[convMicroteachCaseQuantitySenateItems.SenateDate] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.SenateDate].ToString().Trim(); //评价日期
objvMicroteachCaseQuantitySenateItemsEN.SenateTime = objRow[convMicroteachCaseQuantitySenateItems.SenateTime] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.SenateTime].ToString().Trim(); //评价时间
objvMicroteachCaseQuantitySenateItemsEN.SenateTotalScore = objRow[convMicroteachCaseQuantitySenateItems.SenateTotalScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convMicroteachCaseQuantitySenateItems.SenateTotalScore].ToString().Trim()); //评价分数
objvMicroteachCaseQuantitySenateItemsEN.AnswerModeId = objRow[convMicroteachCaseQuantitySenateItems.AnswerModeId] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.AnswerModeId].ToString().Trim(); //答案模式Id
objvMicroteachCaseQuantitySenateItemsEN.AnswerTypeId = objRow[convMicroteachCaseQuantitySenateItems.AnswerTypeId] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.AnswerTypeId].ToString().Trim(); //答案类型ID
objvMicroteachCaseQuantitySenateItemsEN.GridTitle = objRow[convMicroteachCaseQuantitySenateItems.GridTitle] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.GridTitle].ToString().Trim(); //表格标题
objvMicroteachCaseQuantitySenateItemsEN.QuestionIndex = objRow[convMicroteachCaseQuantitySenateItems.QuestionIndex] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convMicroteachCaseQuantitySenateItems.QuestionIndex].ToString().Trim()); //题目序号
objvMicroteachCaseQuantitySenateItemsEN.QuestionNo = objRow[convMicroteachCaseQuantitySenateItems.QuestionNo] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.QuestionNo].ToString().Trim(); //题目编号
objvMicroteachCaseQuantitySenateItemsEN.QuestionTypeId = objRow[convMicroteachCaseQuantitySenateItems.QuestionTypeId] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.QuestionTypeId].ToString().Trim(); //题目类型Id
objvMicroteachCaseQuantitySenateItemsEN.AnswerModeName = objRow[convMicroteachCaseQuantitySenateItems.AnswerModeName] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.AnswerModeName].ToString().Trim(); //答案模式名称
objvMicroteachCaseQuantitySenateItemsEN.AnswerNum = objRow[convMicroteachCaseQuantitySenateItems.AnswerNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convMicroteachCaseQuantitySenateItems.AnswerNum].ToString().Trim()); //答案数
objvMicroteachCaseQuantitySenateItemsEN.AnswerTypeName = objRow[convMicroteachCaseQuantitySenateItems.AnswerTypeName] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.AnswerTypeName].ToString().Trim(); //答案类型名
objvMicroteachCaseQuantitySenateItemsEN.QuestionTypeName = objRow[convMicroteachCaseQuantitySenateItems.QuestionTypeName] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.QuestionTypeName].ToString().Trim(); //题目类型名
objvMicroteachCaseQuantitySenateItemsEN.senateGaugeVersionID = objRow[convMicroteachCaseQuantitySenateItems.senateGaugeVersionID] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.senateGaugeVersionID].ToString().Trim(); //评价量表版本ID
objvMicroteachCaseQuantitySenateItemsEN.senateGaugeVersionName = objRow[convMicroteachCaseQuantitySenateItems.senateGaugeVersionName] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称
objvMicroteachCaseQuantitySenateItemsEN.senateGaugeVersionTtlScore = objRow[convMicroteachCaseQuantitySenateItems.senateGaugeVersionTtlScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convMicroteachCaseQuantitySenateItems.senateGaugeVersionTtlScore].ToString().Trim()); //评价量表版本总分
objvMicroteachCaseQuantitySenateItemsEN.IdSenateGaugeVersion = objRow[convMicroteachCaseQuantitySenateItems.IdSenateGaugeVersion].ToString().Trim(); //评价量表版本流水号
objvMicroteachCaseQuantitySenateItemsEN.AnswerIndex = objRow[convMicroteachCaseQuantitySenateItems.AnswerIndex] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convMicroteachCaseQuantitySenateItems.AnswerIndex].ToString().Trim()); //问答序号
objvMicroteachCaseQuantitySenateItemsEN.AnswerTitle = objRow[convMicroteachCaseQuantitySenateItems.AnswerTitle] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.AnswerTitle].ToString().Trim(); //答案标题
objvMicroteachCaseQuantitySenateItemsEN.OwnerId = objRow[convMicroteachCaseQuantitySenateItems.OwnerId] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.OwnerId].ToString().Trim(); //拥有者Id
objvMicroteachCaseQuantitySenateItemsEN.OwnerName = objRow[convMicroteachCaseQuantitySenateItems.OwnerName] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.OwnerName].ToString().Trim(); //拥有者姓名
objvMicroteachCaseQuantitySenateItemsEN.OwnerNameWithId = objRow[convMicroteachCaseQuantitySenateItems.OwnerNameWithId] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.OwnerNameWithId].ToString().Trim(); //拥有者名称附Id
objvMicroteachCaseQuantitySenateItemsEN.SenateIp = objRow[convMicroteachCaseQuantitySenateItems.SenateIp] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.SenateIp].ToString().Trim(); //评议Ip
objvMicroteachCaseQuantitySenateItemsEN.UserNameWithUserId = objRow[convMicroteachCaseQuantitySenateItems.UserNameWithUserId] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.UserNameWithUserId].ToString().Trim(); //UserNameWithUserId
objvMicroteachCaseQuantitySenateItemsEN.UserTypeId = objRow[convMicroteachCaseQuantitySenateItems.UserTypeId] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.UserTypeId].ToString().Trim(); //用户类型Id
objvMicroteachCaseQuantitySenateItemsEN.IsAccess = clsEntityBase2.TransNullToBool_S(objRow[convMicroteachCaseQuantitySenateItems.IsAccess].ToString().Trim()); //IsAccess
objvMicroteachCaseQuantitySenateItemsEN.IsAccessC = clsEntityBase2.TransNullToBool_S(objRow[convMicroteachCaseQuantitySenateItems.IsAccessC].ToString().Trim()); //IsAccessC
objvMicroteachCaseQuantitySenateItemsEN.UpdDate = objRow[convMicroteachCaseQuantitySenateItems.UpdDate] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.UpdDate].ToString().Trim(); //修改日期
objvMicroteachCaseQuantitySenateItemsEN.UpdUser = objRow[convMicroteachCaseQuantitySenateItems.UpdUser] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.UpdUser].ToString().Trim(); //修改人
objvMicroteachCaseQuantitySenateItemsEN.IdAppraiseType = objRow[convMicroteachCaseQuantitySenateItems.IdAppraiseType] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.IdAppraiseType].ToString().Trim(); //评议类型流水号
objvMicroteachCaseQuantitySenateItemsEN.AppraiseTypeName = objRow[convMicroteachCaseQuantitySenateItems.AppraiseTypeName] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.AppraiseTypeName].ToString().Trim(); //评议类型名称
objvMicroteachCaseQuantitySenateItemsEN.FuncModuleId = objRow[convMicroteachCaseQuantitySenateItems.FuncModuleId] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.FuncModuleId].ToString().Trim(); //功能模块Id
objvMicroteachCaseQuantitySenateItemsEN.UserKindId = objRow[convMicroteachCaseQuantitySenateItems.UserKindId] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.UserKindId].ToString().Trim(); //用户类别Id
objvMicroteachCaseQuantitySenateItemsEN.UserKindName = objRow[convMicroteachCaseQuantitySenateItems.UserKindName] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.UserKindName].ToString().Trim(); //用户类别名
objvMicroteachCaseQuantitySenateItemsEN.UserTypeName = objRow[convMicroteachCaseQuantitySenateItems.UserTypeName] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.UserTypeName].ToString().Trim(); //用户类型名称
objvMicroteachCaseQuantitySenateItemsEN.FuncModuleName = objRow[convMicroteachCaseQuantitySenateItems.FuncModuleName] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.FuncModuleName].ToString().Trim(); //功能模块名称
objvMicroteachCaseQuantitySenateItemsEN.IdXzCollege = objRow[convMicroteachCaseQuantitySenateItems.IdXzCollege] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.IdXzCollege].ToString().Trim(); //学院流水号
objvMicroteachCaseQuantitySenateItemsEN.CollegeNameA = objRow[convMicroteachCaseQuantitySenateItems.CollegeNameA] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenateItems.CollegeNameA].ToString().Trim(); //学院名称简写
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvMicroteachCaseQuantitySenateItemsEN.IdmicroteachCaseQuantitySenateItem, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvMicroteachCaseQuantitySenateItemsEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objvMicroteachCaseQuantitySenateItemsEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetvMicroteachCaseQuantitySenateItems(ref clsvMicroteachCaseQuantitySenateItemsEN objvMicroteachCaseQuantitySenateItemsEN)
{
bool bolResult = vMicroteachCaseQuantitySenateItemsDA.GetvMicroteachCaseQuantitySenateItems(ref objvMicroteachCaseQuantitySenateItemsEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "lngIdmicroteachCaseQuantitySenateItem">表关键字</param>
 /// <returns>表对象</returns>
public static clsvMicroteachCaseQuantitySenateItemsEN GetObjByIdmicroteachCaseQuantitySenateItem(long lngIdmicroteachCaseQuantitySenateItem)
{
clsvMicroteachCaseQuantitySenateItemsEN objvMicroteachCaseQuantitySenateItemsEN = vMicroteachCaseQuantitySenateItemsDA.GetObjByIdmicroteachCaseQuantitySenateItem(lngIdmicroteachCaseQuantitySenateItem);
return objvMicroteachCaseQuantitySenateItemsEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsvMicroteachCaseQuantitySenateItemsEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsvMicroteachCaseQuantitySenateItemsEN objvMicroteachCaseQuantitySenateItemsEN = vMicroteachCaseQuantitySenateItemsDA.GetFirstObj(strWhereCond);
 return objvMicroteachCaseQuantitySenateItemsEN;
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
public static clsvMicroteachCaseQuantitySenateItemsEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsvMicroteachCaseQuantitySenateItemsEN objvMicroteachCaseQuantitySenateItemsEN = vMicroteachCaseQuantitySenateItemsDA.GetObjByDataRow(objRow);
 return objvMicroteachCaseQuantitySenateItemsEN;
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
public static clsvMicroteachCaseQuantitySenateItemsEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsvMicroteachCaseQuantitySenateItemsEN objvMicroteachCaseQuantitySenateItemsEN = vMicroteachCaseQuantitySenateItemsDA.GetObjByDataRow(objRow);
 return objvMicroteachCaseQuantitySenateItemsEN;
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
 /// <param name = "lngIdmicroteachCaseQuantitySenateItem">所给的关键字</param>
 /// <param name = "lstvMicroteachCaseQuantitySenateItemsObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvMicroteachCaseQuantitySenateItemsEN GetObjByIdmicroteachCaseQuantitySenateItemFromList(long lngIdmicroteachCaseQuantitySenateItem, List<clsvMicroteachCaseQuantitySenateItemsEN> lstvMicroteachCaseQuantitySenateItemsObjLst)
{
foreach (clsvMicroteachCaseQuantitySenateItemsEN objvMicroteachCaseQuantitySenateItemsEN in lstvMicroteachCaseQuantitySenateItemsObjLst)
{
if (objvMicroteachCaseQuantitySenateItemsEN.IdmicroteachCaseQuantitySenateItem == lngIdmicroteachCaseQuantitySenateItem)
{
return objvMicroteachCaseQuantitySenateItemsEN;
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
 long lngIdmicroteachCaseQuantitySenateItem;
 try
 {
 lngIdmicroteachCaseQuantitySenateItem = new clsvMicroteachCaseQuantitySenateItemsDA().GetFirstID(strWhereCond);
 return lngIdmicroteachCaseQuantitySenateItem;
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
 arrList = vMicroteachCaseQuantitySenateItemsDA.GetID(strWhereCond);
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
bool bolIsExist = vMicroteachCaseQuantitySenateItemsDA.IsExistCondRec(strWhereCond);
return bolIsExist;
}

 /// <summary>
 /// 判断当前表中是否存在给定关键字值的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExist)
 /// </summary>
 /// <param name = "lngIdmicroteachCaseQuantitySenateItem">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public static bool IsExist(long lngIdmicroteachCaseQuantitySenateItem)
{
//检测记录是否存在
bool bolIsExist = vMicroteachCaseQuantitySenateItemsDA.IsExist(lngIdmicroteachCaseQuantitySenateItem);
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
 bolIsExist = clsvMicroteachCaseQuantitySenateItemsDA.IsExistTable();
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
 bolIsExist = vMicroteachCaseQuantitySenateItemsDA.IsExistTable(strTabName);
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
 /// <param name = "objvMicroteachCaseQuantitySenateItemsENS">源对象</param>
 /// <param name = "objvMicroteachCaseQuantitySenateItemsENT">目标对象</param>
 public static void CopyTo(clsvMicroteachCaseQuantitySenateItemsEN objvMicroteachCaseQuantitySenateItemsENS, clsvMicroteachCaseQuantitySenateItemsEN objvMicroteachCaseQuantitySenateItemsENT)
{
try
{
objvMicroteachCaseQuantitySenateItemsENT.IdmicroteachCaseQuantitySenateItem = objvMicroteachCaseQuantitySenateItemsENS.IdmicroteachCaseQuantitySenateItem; //微格量化评价指标流水号
objvMicroteachCaseQuantitySenateItemsENT.IdmicroteachCaseQuantitySenate = objvMicroteachCaseQuantitySenateItemsENS.IdmicroteachCaseQuantitySenate; //微格量化评价流水号
objvMicroteachCaseQuantitySenateItemsENT.IdMicroteachCase = objvMicroteachCaseQuantitySenateItemsENS.IdMicroteachCase; //微格教学案例流水号
objvMicroteachCaseQuantitySenateItemsENT.MicroteachCaseID = objvMicroteachCaseQuantitySenateItemsENS.MicroteachCaseID; //微格教学案例ID
objvMicroteachCaseQuantitySenateItemsENT.MicroteachCaseName = objvMicroteachCaseQuantitySenateItemsENS.MicroteachCaseName; //微格教学案例名称
objvMicroteachCaseQuantitySenateItemsENT.IdSenateGaugeItem = objvMicroteachCaseQuantitySenateItemsENS.IdSenateGaugeItem; //量表指标流水号
objvMicroteachCaseQuantitySenateItemsENT.senateGaugeItemID = objvMicroteachCaseQuantitySenateItemsENS.senateGaugeItemID; //量表指标ID
objvMicroteachCaseQuantitySenateItemsENT.senateGaugeItemName = objvMicroteachCaseQuantitySenateItemsENS.senateGaugeItemName; //量表指标名称
objvMicroteachCaseQuantitySenateItemsENT.senateGaugeItemNameWithOrder = objvMicroteachCaseQuantitySenateItemsENS.senateGaugeItemNameWithOrder; //量表指标名称WithOrder
objvMicroteachCaseQuantitySenateItemsENT.senateGaugeItemDesc = objvMicroteachCaseQuantitySenateItemsENS.senateGaugeItemDesc; //量表指标说明
objvMicroteachCaseQuantitySenateItemsENT.senateGaugeItemMemo = objvMicroteachCaseQuantitySenateItemsENS.senateGaugeItemMemo; //备注
objvMicroteachCaseQuantitySenateItemsENT.senateGaugeItemWeight = objvMicroteachCaseQuantitySenateItemsENS.senateGaugeItemWeight; //量表指标权重
objvMicroteachCaseQuantitySenateItemsENT.SenateScore = objvMicroteachCaseQuantitySenateItemsENS.SenateScore; //指标得分
objvMicroteachCaseQuantitySenateItemsENT.IdSenateGaugeSubItem = objvMicroteachCaseQuantitySenateItemsENS.IdSenateGaugeSubItem; //量表指标子项流水号
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
objvMicroteachCaseQuantitySenateItemsENT.IdSenateGaugeVersion = objvMicroteachCaseQuantitySenateItemsENS.IdSenateGaugeVersion; //评价量表版本流水号
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
objvMicroteachCaseQuantitySenateItemsENT.IdAppraiseType = objvMicroteachCaseQuantitySenateItemsENS.IdAppraiseType; //评议类型流水号
objvMicroteachCaseQuantitySenateItemsENT.AppraiseTypeName = objvMicroteachCaseQuantitySenateItemsENS.AppraiseTypeName; //评议类型名称
objvMicroteachCaseQuantitySenateItemsENT.FuncModuleId = objvMicroteachCaseQuantitySenateItemsENS.FuncModuleId; //功能模块Id
objvMicroteachCaseQuantitySenateItemsENT.UserKindId = objvMicroteachCaseQuantitySenateItemsENS.UserKindId; //用户类别Id
objvMicroteachCaseQuantitySenateItemsENT.UserKindName = objvMicroteachCaseQuantitySenateItemsENS.UserKindName; //用户类别名
objvMicroteachCaseQuantitySenateItemsENT.UserTypeName = objvMicroteachCaseQuantitySenateItemsENS.UserTypeName; //用户类型名称
objvMicroteachCaseQuantitySenateItemsENT.FuncModuleName = objvMicroteachCaseQuantitySenateItemsENS.FuncModuleName; //功能模块名称
objvMicroteachCaseQuantitySenateItemsENT.IdXzCollege = objvMicroteachCaseQuantitySenateItemsENS.IdXzCollege; //学院流水号
objvMicroteachCaseQuantitySenateItemsENT.CollegeNameA = objvMicroteachCaseQuantitySenateItemsENS.CollegeNameA; //学院名称简写
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
 /// <param name = "objvMicroteachCaseQuantitySenateItemsEN">源简化对象</param>
 public static void SetUpdFlag(clsvMicroteachCaseQuantitySenateItemsEN objvMicroteachCaseQuantitySenateItemsEN)
{
try
{
objvMicroteachCaseQuantitySenateItemsEN.ClearUpdateState();
   string strsfUpdFldSetStr = objvMicroteachCaseQuantitySenateItemsEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(convMicroteachCaseQuantitySenateItems.IdmicroteachCaseQuantitySenateItem, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroteachCaseQuantitySenateItemsEN.IdmicroteachCaseQuantitySenateItem = objvMicroteachCaseQuantitySenateItemsEN.IdmicroteachCaseQuantitySenateItem; //微格量化评价指标流水号
}
if (arrFldSet.Contains(convMicroteachCaseQuantitySenateItems.IdmicroteachCaseQuantitySenate, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroteachCaseQuantitySenateItemsEN.IdmicroteachCaseQuantitySenate = objvMicroteachCaseQuantitySenateItemsEN.IdmicroteachCaseQuantitySenate; //微格量化评价流水号
}
if (arrFldSet.Contains(convMicroteachCaseQuantitySenateItems.IdMicroteachCase, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroteachCaseQuantitySenateItemsEN.IdMicroteachCase = objvMicroteachCaseQuantitySenateItemsEN.IdMicroteachCase; //微格教学案例流水号
}
if (arrFldSet.Contains(convMicroteachCaseQuantitySenateItems.MicroteachCaseID, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroteachCaseQuantitySenateItemsEN.MicroteachCaseID = objvMicroteachCaseQuantitySenateItemsEN.MicroteachCaseID == "[null]" ? null :  objvMicroteachCaseQuantitySenateItemsEN.MicroteachCaseID; //微格教学案例ID
}
if (arrFldSet.Contains(convMicroteachCaseQuantitySenateItems.MicroteachCaseName, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroteachCaseQuantitySenateItemsEN.MicroteachCaseName = objvMicroteachCaseQuantitySenateItemsEN.MicroteachCaseName == "[null]" ? null :  objvMicroteachCaseQuantitySenateItemsEN.MicroteachCaseName; //微格教学案例名称
}
if (arrFldSet.Contains(convMicroteachCaseQuantitySenateItems.IdSenateGaugeItem, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroteachCaseQuantitySenateItemsEN.IdSenateGaugeItem = objvMicroteachCaseQuantitySenateItemsEN.IdSenateGaugeItem; //量表指标流水号
}
if (arrFldSet.Contains(convMicroteachCaseQuantitySenateItems.senateGaugeItemID, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroteachCaseQuantitySenateItemsEN.senateGaugeItemID = objvMicroteachCaseQuantitySenateItemsEN.senateGaugeItemID == "[null]" ? null :  objvMicroteachCaseQuantitySenateItemsEN.senateGaugeItemID; //量表指标ID
}
if (arrFldSet.Contains(convMicroteachCaseQuantitySenateItems.senateGaugeItemName, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroteachCaseQuantitySenateItemsEN.senateGaugeItemName = objvMicroteachCaseQuantitySenateItemsEN.senateGaugeItemName == "[null]" ? null :  objvMicroteachCaseQuantitySenateItemsEN.senateGaugeItemName; //量表指标名称
}
if (arrFldSet.Contains(convMicroteachCaseQuantitySenateItems.senateGaugeItemNameWithOrder, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroteachCaseQuantitySenateItemsEN.senateGaugeItemNameWithOrder = objvMicroteachCaseQuantitySenateItemsEN.senateGaugeItemNameWithOrder == "[null]" ? null :  objvMicroteachCaseQuantitySenateItemsEN.senateGaugeItemNameWithOrder; //量表指标名称WithOrder
}
if (arrFldSet.Contains(convMicroteachCaseQuantitySenateItems.senateGaugeItemDesc, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroteachCaseQuantitySenateItemsEN.senateGaugeItemDesc = objvMicroteachCaseQuantitySenateItemsEN.senateGaugeItemDesc == "[null]" ? null :  objvMicroteachCaseQuantitySenateItemsEN.senateGaugeItemDesc; //量表指标说明
}
if (arrFldSet.Contains(convMicroteachCaseQuantitySenateItems.senateGaugeItemMemo, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroteachCaseQuantitySenateItemsEN.senateGaugeItemMemo = objvMicroteachCaseQuantitySenateItemsEN.senateGaugeItemMemo == "[null]" ? null :  objvMicroteachCaseQuantitySenateItemsEN.senateGaugeItemMemo; //备注
}
if (arrFldSet.Contains(convMicroteachCaseQuantitySenateItems.senateGaugeItemWeight, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroteachCaseQuantitySenateItemsEN.senateGaugeItemWeight = objvMicroteachCaseQuantitySenateItemsEN.senateGaugeItemWeight; //量表指标权重
}
if (arrFldSet.Contains(convMicroteachCaseQuantitySenateItems.SenateScore, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroteachCaseQuantitySenateItemsEN.SenateScore = objvMicroteachCaseQuantitySenateItemsEN.SenateScore; //指标得分
}
if (arrFldSet.Contains(convMicroteachCaseQuantitySenateItems.IdSenateGaugeSubItem, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroteachCaseQuantitySenateItemsEN.IdSenateGaugeSubItem = objvMicroteachCaseQuantitySenateItemsEN.IdSenateGaugeSubItem == "[null]" ? null :  objvMicroteachCaseQuantitySenateItemsEN.IdSenateGaugeSubItem; //量表指标子项流水号
}
if (arrFldSet.Contains(convMicroteachCaseQuantitySenateItems.senateGaugeSubItemID, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroteachCaseQuantitySenateItemsEN.senateGaugeSubItemID = objvMicroteachCaseQuantitySenateItemsEN.senateGaugeSubItemID == "[null]" ? null :  objvMicroteachCaseQuantitySenateItemsEN.senateGaugeSubItemID; //量表指标子项ID
}
if (arrFldSet.Contains(convMicroteachCaseQuantitySenateItems.senateGaugeSubItemName, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroteachCaseQuantitySenateItemsEN.senateGaugeSubItemName = objvMicroteachCaseQuantitySenateItemsEN.senateGaugeSubItemName == "[null]" ? null :  objvMicroteachCaseQuantitySenateItemsEN.senateGaugeSubItemName; //量表指标子项名称
}
if (arrFldSet.Contains(convMicroteachCaseQuantitySenateItems.senateGaugeSubItemDesc, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroteachCaseQuantitySenateItemsEN.senateGaugeSubItemDesc = objvMicroteachCaseQuantitySenateItemsEN.senateGaugeSubItemDesc == "[null]" ? null :  objvMicroteachCaseQuantitySenateItemsEN.senateGaugeSubItemDesc; //量表指标子项说明
}
if (arrFldSet.Contains(convMicroteachCaseQuantitySenateItems.senateGaugeSubItemMemo, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroteachCaseQuantitySenateItemsEN.senateGaugeSubItemMemo = objvMicroteachCaseQuantitySenateItemsEN.senateGaugeSubItemMemo == "[null]" ? null :  objvMicroteachCaseQuantitySenateItemsEN.senateGaugeSubItemMemo; //量表指标子项备注
}
if (arrFldSet.Contains(convMicroteachCaseQuantitySenateItems.senateGaugeSubItemScore, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroteachCaseQuantitySenateItemsEN.senateGaugeSubItemScore = objvMicroteachCaseQuantitySenateItemsEN.senateGaugeSubItemScore; //量表指标子项分数
}
if (arrFldSet.Contains(convMicroteachCaseQuantitySenateItems.UserId, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroteachCaseQuantitySenateItemsEN.UserId = objvMicroteachCaseQuantitySenateItemsEN.UserId == "[null]" ? null :  objvMicroteachCaseQuantitySenateItemsEN.UserId; //用户ID
}
if (arrFldSet.Contains(convMicroteachCaseQuantitySenateItems.UserName, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroteachCaseQuantitySenateItemsEN.UserName = objvMicroteachCaseQuantitySenateItemsEN.UserName == "[null]" ? null :  objvMicroteachCaseQuantitySenateItemsEN.UserName; //用户名
}
if (arrFldSet.Contains(convMicroteachCaseQuantitySenateItems.CollegeID, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroteachCaseQuantitySenateItemsEN.CollegeID = objvMicroteachCaseQuantitySenateItemsEN.CollegeID == "[null]" ? null :  objvMicroteachCaseQuantitySenateItemsEN.CollegeID; //学院ID
}
if (arrFldSet.Contains(convMicroteachCaseQuantitySenateItems.CollegeName, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroteachCaseQuantitySenateItemsEN.CollegeName = objvMicroteachCaseQuantitySenateItemsEN.CollegeName == "[null]" ? null :  objvMicroteachCaseQuantitySenateItemsEN.CollegeName; //学院名称
}
if (arrFldSet.Contains(convMicroteachCaseQuantitySenateItems.SenateTheme, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroteachCaseQuantitySenateItemsEN.SenateTheme = objvMicroteachCaseQuantitySenateItemsEN.SenateTheme == "[null]" ? null :  objvMicroteachCaseQuantitySenateItemsEN.SenateTheme; //量化评价主题
}
if (arrFldSet.Contains(convMicroteachCaseQuantitySenateItems.SenateContent, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroteachCaseQuantitySenateItemsEN.SenateContent = objvMicroteachCaseQuantitySenateItemsEN.SenateContent == "[null]" ? null :  objvMicroteachCaseQuantitySenateItemsEN.SenateContent; //评价内容
}
if (arrFldSet.Contains(convMicroteachCaseQuantitySenateItems.SenateDate, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroteachCaseQuantitySenateItemsEN.SenateDate = objvMicroteachCaseQuantitySenateItemsEN.SenateDate == "[null]" ? null :  objvMicroteachCaseQuantitySenateItemsEN.SenateDate; //评价日期
}
if (arrFldSet.Contains(convMicroteachCaseQuantitySenateItems.SenateTime, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroteachCaseQuantitySenateItemsEN.SenateTime = objvMicroteachCaseQuantitySenateItemsEN.SenateTime == "[null]" ? null :  objvMicroteachCaseQuantitySenateItemsEN.SenateTime; //评价时间
}
if (arrFldSet.Contains(convMicroteachCaseQuantitySenateItems.SenateTotalScore, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroteachCaseQuantitySenateItemsEN.SenateTotalScore = objvMicroteachCaseQuantitySenateItemsEN.SenateTotalScore; //评价分数
}
if (arrFldSet.Contains(convMicroteachCaseQuantitySenateItems.AnswerModeId, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroteachCaseQuantitySenateItemsEN.AnswerModeId = objvMicroteachCaseQuantitySenateItemsEN.AnswerModeId == "[null]" ? null :  objvMicroteachCaseQuantitySenateItemsEN.AnswerModeId; //答案模式Id
}
if (arrFldSet.Contains(convMicroteachCaseQuantitySenateItems.AnswerTypeId, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroteachCaseQuantitySenateItemsEN.AnswerTypeId = objvMicroteachCaseQuantitySenateItemsEN.AnswerTypeId == "[null]" ? null :  objvMicroteachCaseQuantitySenateItemsEN.AnswerTypeId; //答案类型ID
}
if (arrFldSet.Contains(convMicroteachCaseQuantitySenateItems.GridTitle, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroteachCaseQuantitySenateItemsEN.GridTitle = objvMicroteachCaseQuantitySenateItemsEN.GridTitle == "[null]" ? null :  objvMicroteachCaseQuantitySenateItemsEN.GridTitle; //表格标题
}
if (arrFldSet.Contains(convMicroteachCaseQuantitySenateItems.QuestionIndex, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroteachCaseQuantitySenateItemsEN.QuestionIndex = objvMicroteachCaseQuantitySenateItemsEN.QuestionIndex; //题目序号
}
if (arrFldSet.Contains(convMicroteachCaseQuantitySenateItems.QuestionNo, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroteachCaseQuantitySenateItemsEN.QuestionNo = objvMicroteachCaseQuantitySenateItemsEN.QuestionNo == "[null]" ? null :  objvMicroteachCaseQuantitySenateItemsEN.QuestionNo; //题目编号
}
if (arrFldSet.Contains(convMicroteachCaseQuantitySenateItems.QuestionTypeId, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroteachCaseQuantitySenateItemsEN.QuestionTypeId = objvMicroteachCaseQuantitySenateItemsEN.QuestionTypeId == "[null]" ? null :  objvMicroteachCaseQuantitySenateItemsEN.QuestionTypeId; //题目类型Id
}
if (arrFldSet.Contains(convMicroteachCaseQuantitySenateItems.AnswerModeName, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroteachCaseQuantitySenateItemsEN.AnswerModeName = objvMicroteachCaseQuantitySenateItemsEN.AnswerModeName == "[null]" ? null :  objvMicroteachCaseQuantitySenateItemsEN.AnswerModeName; //答案模式名称
}
if (arrFldSet.Contains(convMicroteachCaseQuantitySenateItems.AnswerNum, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroteachCaseQuantitySenateItemsEN.AnswerNum = objvMicroteachCaseQuantitySenateItemsEN.AnswerNum; //答案数
}
if (arrFldSet.Contains(convMicroteachCaseQuantitySenateItems.AnswerTypeName, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroteachCaseQuantitySenateItemsEN.AnswerTypeName = objvMicroteachCaseQuantitySenateItemsEN.AnswerTypeName == "[null]" ? null :  objvMicroteachCaseQuantitySenateItemsEN.AnswerTypeName; //答案类型名
}
if (arrFldSet.Contains(convMicroteachCaseQuantitySenateItems.QuestionTypeName, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroteachCaseQuantitySenateItemsEN.QuestionTypeName = objvMicroteachCaseQuantitySenateItemsEN.QuestionTypeName == "[null]" ? null :  objvMicroteachCaseQuantitySenateItemsEN.QuestionTypeName; //题目类型名
}
if (arrFldSet.Contains(convMicroteachCaseQuantitySenateItems.senateGaugeVersionID, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroteachCaseQuantitySenateItemsEN.senateGaugeVersionID = objvMicroteachCaseQuantitySenateItemsEN.senateGaugeVersionID == "[null]" ? null :  objvMicroteachCaseQuantitySenateItemsEN.senateGaugeVersionID; //评价量表版本ID
}
if (arrFldSet.Contains(convMicroteachCaseQuantitySenateItems.senateGaugeVersionName, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroteachCaseQuantitySenateItemsEN.senateGaugeVersionName = objvMicroteachCaseQuantitySenateItemsEN.senateGaugeVersionName == "[null]" ? null :  objvMicroteachCaseQuantitySenateItemsEN.senateGaugeVersionName; //评价量表版本名称
}
if (arrFldSet.Contains(convMicroteachCaseQuantitySenateItems.senateGaugeVersionTtlScore, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroteachCaseQuantitySenateItemsEN.senateGaugeVersionTtlScore = objvMicroteachCaseQuantitySenateItemsEN.senateGaugeVersionTtlScore; //评价量表版本总分
}
if (arrFldSet.Contains(convMicroteachCaseQuantitySenateItems.IdSenateGaugeVersion, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroteachCaseQuantitySenateItemsEN.IdSenateGaugeVersion = objvMicroteachCaseQuantitySenateItemsEN.IdSenateGaugeVersion; //评价量表版本流水号
}
if (arrFldSet.Contains(convMicroteachCaseQuantitySenateItems.AnswerIndex, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroteachCaseQuantitySenateItemsEN.AnswerIndex = objvMicroteachCaseQuantitySenateItemsEN.AnswerIndex; //问答序号
}
if (arrFldSet.Contains(convMicroteachCaseQuantitySenateItems.AnswerTitle, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroteachCaseQuantitySenateItemsEN.AnswerTitle = objvMicroteachCaseQuantitySenateItemsEN.AnswerTitle == "[null]" ? null :  objvMicroteachCaseQuantitySenateItemsEN.AnswerTitle; //答案标题
}
if (arrFldSet.Contains(convMicroteachCaseQuantitySenateItems.OwnerId, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroteachCaseQuantitySenateItemsEN.OwnerId = objvMicroteachCaseQuantitySenateItemsEN.OwnerId == "[null]" ? null :  objvMicroteachCaseQuantitySenateItemsEN.OwnerId; //拥有者Id
}
if (arrFldSet.Contains(convMicroteachCaseQuantitySenateItems.OwnerName, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroteachCaseQuantitySenateItemsEN.OwnerName = objvMicroteachCaseQuantitySenateItemsEN.OwnerName == "[null]" ? null :  objvMicroteachCaseQuantitySenateItemsEN.OwnerName; //拥有者姓名
}
if (arrFldSet.Contains(convMicroteachCaseQuantitySenateItems.OwnerNameWithId, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroteachCaseQuantitySenateItemsEN.OwnerNameWithId = objvMicroteachCaseQuantitySenateItemsEN.OwnerNameWithId == "[null]" ? null :  objvMicroteachCaseQuantitySenateItemsEN.OwnerNameWithId; //拥有者名称附Id
}
if (arrFldSet.Contains(convMicroteachCaseQuantitySenateItems.SenateIp, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroteachCaseQuantitySenateItemsEN.SenateIp = objvMicroteachCaseQuantitySenateItemsEN.SenateIp == "[null]" ? null :  objvMicroteachCaseQuantitySenateItemsEN.SenateIp; //评议Ip
}
if (arrFldSet.Contains(convMicroteachCaseQuantitySenateItems.UserNameWithUserId, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroteachCaseQuantitySenateItemsEN.UserNameWithUserId = objvMicroteachCaseQuantitySenateItemsEN.UserNameWithUserId == "[null]" ? null :  objvMicroteachCaseQuantitySenateItemsEN.UserNameWithUserId; //UserNameWithUserId
}
if (arrFldSet.Contains(convMicroteachCaseQuantitySenateItems.UserTypeId, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroteachCaseQuantitySenateItemsEN.UserTypeId = objvMicroteachCaseQuantitySenateItemsEN.UserTypeId == "[null]" ? null :  objvMicroteachCaseQuantitySenateItemsEN.UserTypeId; //用户类型Id
}
if (arrFldSet.Contains(convMicroteachCaseQuantitySenateItems.IsAccess, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroteachCaseQuantitySenateItemsEN.IsAccess = objvMicroteachCaseQuantitySenateItemsEN.IsAccess; //IsAccess
}
if (arrFldSet.Contains(convMicroteachCaseQuantitySenateItems.IsAccessC, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroteachCaseQuantitySenateItemsEN.IsAccessC = objvMicroteachCaseQuantitySenateItemsEN.IsAccessC; //IsAccessC
}
if (arrFldSet.Contains(convMicroteachCaseQuantitySenateItems.UpdDate, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroteachCaseQuantitySenateItemsEN.UpdDate = objvMicroteachCaseQuantitySenateItemsEN.UpdDate == "[null]" ? null :  objvMicroteachCaseQuantitySenateItemsEN.UpdDate; //修改日期
}
if (arrFldSet.Contains(convMicroteachCaseQuantitySenateItems.UpdUser, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroteachCaseQuantitySenateItemsEN.UpdUser = objvMicroteachCaseQuantitySenateItemsEN.UpdUser == "[null]" ? null :  objvMicroteachCaseQuantitySenateItemsEN.UpdUser; //修改人
}
if (arrFldSet.Contains(convMicroteachCaseQuantitySenateItems.IdAppraiseType, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroteachCaseQuantitySenateItemsEN.IdAppraiseType = objvMicroteachCaseQuantitySenateItemsEN.IdAppraiseType == "[null]" ? null :  objvMicroteachCaseQuantitySenateItemsEN.IdAppraiseType; //评议类型流水号
}
if (arrFldSet.Contains(convMicroteachCaseQuantitySenateItems.AppraiseTypeName, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroteachCaseQuantitySenateItemsEN.AppraiseTypeName = objvMicroteachCaseQuantitySenateItemsEN.AppraiseTypeName == "[null]" ? null :  objvMicroteachCaseQuantitySenateItemsEN.AppraiseTypeName; //评议类型名称
}
if (arrFldSet.Contains(convMicroteachCaseQuantitySenateItems.FuncModuleId, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroteachCaseQuantitySenateItemsEN.FuncModuleId = objvMicroteachCaseQuantitySenateItemsEN.FuncModuleId == "[null]" ? null :  objvMicroteachCaseQuantitySenateItemsEN.FuncModuleId; //功能模块Id
}
if (arrFldSet.Contains(convMicroteachCaseQuantitySenateItems.UserKindId, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroteachCaseQuantitySenateItemsEN.UserKindId = objvMicroteachCaseQuantitySenateItemsEN.UserKindId == "[null]" ? null :  objvMicroteachCaseQuantitySenateItemsEN.UserKindId; //用户类别Id
}
if (arrFldSet.Contains(convMicroteachCaseQuantitySenateItems.UserKindName, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroteachCaseQuantitySenateItemsEN.UserKindName = objvMicroteachCaseQuantitySenateItemsEN.UserKindName == "[null]" ? null :  objvMicroteachCaseQuantitySenateItemsEN.UserKindName; //用户类别名
}
if (arrFldSet.Contains(convMicroteachCaseQuantitySenateItems.UserTypeName, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroteachCaseQuantitySenateItemsEN.UserTypeName = objvMicroteachCaseQuantitySenateItemsEN.UserTypeName == "[null]" ? null :  objvMicroteachCaseQuantitySenateItemsEN.UserTypeName; //用户类型名称
}
if (arrFldSet.Contains(convMicroteachCaseQuantitySenateItems.FuncModuleName, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroteachCaseQuantitySenateItemsEN.FuncModuleName = objvMicroteachCaseQuantitySenateItemsEN.FuncModuleName == "[null]" ? null :  objvMicroteachCaseQuantitySenateItemsEN.FuncModuleName; //功能模块名称
}
if (arrFldSet.Contains(convMicroteachCaseQuantitySenateItems.IdXzCollege, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroteachCaseQuantitySenateItemsEN.IdXzCollege = objvMicroteachCaseQuantitySenateItemsEN.IdXzCollege == "[null]" ? null :  objvMicroteachCaseQuantitySenateItemsEN.IdXzCollege; //学院流水号
}
if (arrFldSet.Contains(convMicroteachCaseQuantitySenateItems.CollegeNameA, new clsStrCompareIgnoreCase())  ==  true)
{
objvMicroteachCaseQuantitySenateItemsEN.CollegeNameA = objvMicroteachCaseQuantitySenateItemsEN.CollegeNameA == "[null]" ? null :  objvMicroteachCaseQuantitySenateItemsEN.CollegeNameA; //学院名称简写
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
 /// <param name = "objvMicroteachCaseQuantitySenateItemsEN">源简化对象</param>
 public static void AccessFldValueNull(clsvMicroteachCaseQuantitySenateItemsEN objvMicroteachCaseQuantitySenateItemsEN)
{
try
{
if (objvMicroteachCaseQuantitySenateItemsEN.MicroteachCaseID == "[null]") objvMicroteachCaseQuantitySenateItemsEN.MicroteachCaseID = null; //微格教学案例ID
if (objvMicroteachCaseQuantitySenateItemsEN.MicroteachCaseName == "[null]") objvMicroteachCaseQuantitySenateItemsEN.MicroteachCaseName = null; //微格教学案例名称
if (objvMicroteachCaseQuantitySenateItemsEN.senateGaugeItemID == "[null]") objvMicroteachCaseQuantitySenateItemsEN.senateGaugeItemID = null; //量表指标ID
if (objvMicroteachCaseQuantitySenateItemsEN.senateGaugeItemName == "[null]") objvMicroteachCaseQuantitySenateItemsEN.senateGaugeItemName = null; //量表指标名称
if (objvMicroteachCaseQuantitySenateItemsEN.senateGaugeItemNameWithOrder == "[null]") objvMicroteachCaseQuantitySenateItemsEN.senateGaugeItemNameWithOrder = null; //量表指标名称WithOrder
if (objvMicroteachCaseQuantitySenateItemsEN.senateGaugeItemDesc == "[null]") objvMicroteachCaseQuantitySenateItemsEN.senateGaugeItemDesc = null; //量表指标说明
if (objvMicroteachCaseQuantitySenateItemsEN.senateGaugeItemMemo == "[null]") objvMicroteachCaseQuantitySenateItemsEN.senateGaugeItemMemo = null; //备注
if (objvMicroteachCaseQuantitySenateItemsEN.IdSenateGaugeSubItem == "[null]") objvMicroteachCaseQuantitySenateItemsEN.IdSenateGaugeSubItem = null; //量表指标子项流水号
if (objvMicroteachCaseQuantitySenateItemsEN.senateGaugeSubItemID == "[null]") objvMicroteachCaseQuantitySenateItemsEN.senateGaugeSubItemID = null; //量表指标子项ID
if (objvMicroteachCaseQuantitySenateItemsEN.senateGaugeSubItemName == "[null]") objvMicroteachCaseQuantitySenateItemsEN.senateGaugeSubItemName = null; //量表指标子项名称
if (objvMicroteachCaseQuantitySenateItemsEN.senateGaugeSubItemDesc == "[null]") objvMicroteachCaseQuantitySenateItemsEN.senateGaugeSubItemDesc = null; //量表指标子项说明
if (objvMicroteachCaseQuantitySenateItemsEN.senateGaugeSubItemMemo == "[null]") objvMicroteachCaseQuantitySenateItemsEN.senateGaugeSubItemMemo = null; //量表指标子项备注
if (objvMicroteachCaseQuantitySenateItemsEN.UserId == "[null]") objvMicroteachCaseQuantitySenateItemsEN.UserId = null; //用户ID
if (objvMicroteachCaseQuantitySenateItemsEN.UserName == "[null]") objvMicroteachCaseQuantitySenateItemsEN.UserName = null; //用户名
if (objvMicroteachCaseQuantitySenateItemsEN.CollegeID == "[null]") objvMicroteachCaseQuantitySenateItemsEN.CollegeID = null; //学院ID
if (objvMicroteachCaseQuantitySenateItemsEN.CollegeName == "[null]") objvMicroteachCaseQuantitySenateItemsEN.CollegeName = null; //学院名称
if (objvMicroteachCaseQuantitySenateItemsEN.SenateTheme == "[null]") objvMicroteachCaseQuantitySenateItemsEN.SenateTheme = null; //量化评价主题
if (objvMicroteachCaseQuantitySenateItemsEN.SenateContent == "[null]") objvMicroteachCaseQuantitySenateItemsEN.SenateContent = null; //评价内容
if (objvMicroteachCaseQuantitySenateItemsEN.SenateDate == "[null]") objvMicroteachCaseQuantitySenateItemsEN.SenateDate = null; //评价日期
if (objvMicroteachCaseQuantitySenateItemsEN.SenateTime == "[null]") objvMicroteachCaseQuantitySenateItemsEN.SenateTime = null; //评价时间
if (objvMicroteachCaseQuantitySenateItemsEN.AnswerModeId == "[null]") objvMicroteachCaseQuantitySenateItemsEN.AnswerModeId = null; //答案模式Id
if (objvMicroteachCaseQuantitySenateItemsEN.AnswerTypeId == "[null]") objvMicroteachCaseQuantitySenateItemsEN.AnswerTypeId = null; //答案类型ID
if (objvMicroteachCaseQuantitySenateItemsEN.GridTitle == "[null]") objvMicroteachCaseQuantitySenateItemsEN.GridTitle = null; //表格标题
if (objvMicroteachCaseQuantitySenateItemsEN.QuestionNo == "[null]") objvMicroteachCaseQuantitySenateItemsEN.QuestionNo = null; //题目编号
if (objvMicroteachCaseQuantitySenateItemsEN.QuestionTypeId == "[null]") objvMicroteachCaseQuantitySenateItemsEN.QuestionTypeId = null; //题目类型Id
if (objvMicroteachCaseQuantitySenateItemsEN.AnswerModeName == "[null]") objvMicroteachCaseQuantitySenateItemsEN.AnswerModeName = null; //答案模式名称
if (objvMicroteachCaseQuantitySenateItemsEN.AnswerTypeName == "[null]") objvMicroteachCaseQuantitySenateItemsEN.AnswerTypeName = null; //答案类型名
if (objvMicroteachCaseQuantitySenateItemsEN.QuestionTypeName == "[null]") objvMicroteachCaseQuantitySenateItemsEN.QuestionTypeName = null; //题目类型名
if (objvMicroteachCaseQuantitySenateItemsEN.senateGaugeVersionID == "[null]") objvMicroteachCaseQuantitySenateItemsEN.senateGaugeVersionID = null; //评价量表版本ID
if (objvMicroteachCaseQuantitySenateItemsEN.senateGaugeVersionName == "[null]") objvMicroteachCaseQuantitySenateItemsEN.senateGaugeVersionName = null; //评价量表版本名称
if (objvMicroteachCaseQuantitySenateItemsEN.AnswerTitle == "[null]") objvMicroteachCaseQuantitySenateItemsEN.AnswerTitle = null; //答案标题
if (objvMicroteachCaseQuantitySenateItemsEN.OwnerId == "[null]") objvMicroteachCaseQuantitySenateItemsEN.OwnerId = null; //拥有者Id
if (objvMicroteachCaseQuantitySenateItemsEN.OwnerName == "[null]") objvMicroteachCaseQuantitySenateItemsEN.OwnerName = null; //拥有者姓名
if (objvMicroteachCaseQuantitySenateItemsEN.OwnerNameWithId == "[null]") objvMicroteachCaseQuantitySenateItemsEN.OwnerNameWithId = null; //拥有者名称附Id
if (objvMicroteachCaseQuantitySenateItemsEN.SenateIp == "[null]") objvMicroteachCaseQuantitySenateItemsEN.SenateIp = null; //评议Ip
if (objvMicroteachCaseQuantitySenateItemsEN.UserNameWithUserId == "[null]") objvMicroteachCaseQuantitySenateItemsEN.UserNameWithUserId = null; //UserNameWithUserId
if (objvMicroteachCaseQuantitySenateItemsEN.UserTypeId == "[null]") objvMicroteachCaseQuantitySenateItemsEN.UserTypeId = null; //用户类型Id
if (objvMicroteachCaseQuantitySenateItemsEN.UpdDate == "[null]") objvMicroteachCaseQuantitySenateItemsEN.UpdDate = null; //修改日期
if (objvMicroteachCaseQuantitySenateItemsEN.UpdUser == "[null]") objvMicroteachCaseQuantitySenateItemsEN.UpdUser = null; //修改人
if (objvMicroteachCaseQuantitySenateItemsEN.IdAppraiseType == "[null]") objvMicroteachCaseQuantitySenateItemsEN.IdAppraiseType = null; //评议类型流水号
if (objvMicroteachCaseQuantitySenateItemsEN.AppraiseTypeName == "[null]") objvMicroteachCaseQuantitySenateItemsEN.AppraiseTypeName = null; //评议类型名称
if (objvMicroteachCaseQuantitySenateItemsEN.FuncModuleId == "[null]") objvMicroteachCaseQuantitySenateItemsEN.FuncModuleId = null; //功能模块Id
if (objvMicroteachCaseQuantitySenateItemsEN.UserKindId == "[null]") objvMicroteachCaseQuantitySenateItemsEN.UserKindId = null; //用户类别Id
if (objvMicroteachCaseQuantitySenateItemsEN.UserKindName == "[null]") objvMicroteachCaseQuantitySenateItemsEN.UserKindName = null; //用户类别名
if (objvMicroteachCaseQuantitySenateItemsEN.UserTypeName == "[null]") objvMicroteachCaseQuantitySenateItemsEN.UserTypeName = null; //用户类型名称
if (objvMicroteachCaseQuantitySenateItemsEN.FuncModuleName == "[null]") objvMicroteachCaseQuantitySenateItemsEN.FuncModuleName = null; //功能模块名称
if (objvMicroteachCaseQuantitySenateItemsEN.IdXzCollege == "[null]") objvMicroteachCaseQuantitySenateItemsEN.IdXzCollege = null; //学院流水号
if (objvMicroteachCaseQuantitySenateItemsEN.CollegeNameA == "[null]") objvMicroteachCaseQuantitySenateItemsEN.CollegeNameA = null; //学院名称简写
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
public static void CheckProperty4Condition(clsvMicroteachCaseQuantitySenateItemsEN objvMicroteachCaseQuantitySenateItemsEN)
{
 vMicroteachCaseQuantitySenateItemsDA.CheckProperty4Condition(objvMicroteachCaseQuantitySenateItemsEN);
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
if (clsMicroteachCaseQuantitySenateItemsBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsMicroteachCaseQuantitySenateItemsBL没有刷新缓存机制(clsMicroteachCaseQuantitySenateItemsBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsTeacherInfoBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsTeacherInfoBL没有刷新缓存机制(clsTeacherInfoBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsFuncModuleBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsFuncModuleBL没有刷新缓存机制(clsFuncModuleBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsSenateGaugeVersionBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsSenateGaugeVersionBL没有刷新缓存机制(clsSenateGaugeVersionBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsAppraiseTypeBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsAppraiseTypeBL没有刷新缓存机制(clsAppraiseTypeBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsMicroteachCaseQuantitySenateBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsMicroteachCaseQuantitySenateBL没有刷新缓存机制(clsMicroteachCaseQuantitySenateBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
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
if (clsSenateGaugeItemsBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsSenateGaugeItemsBL没有刷新缓存机制(clsSenateGaugeItemsBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsUsersBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsUsersBL没有刷新缓存机制(clsUsersBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsUserStateBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsUserStateBL没有刷新缓存机制(clsUserStateBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsXzClgBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsXzClgBL没有刷新缓存机制(clsXzClgBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsXzMajorBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsXzMajorBL没有刷新缓存机制(clsXzMajorBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsXzGradeBaseBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsXzGradeBaseBL没有刷新缓存机制(clsXzGradeBaseBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsUserIdentityBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsUserIdentityBL没有刷新缓存机制(clsUserIdentityBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsStudyLevelBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsStudyLevelBL没有刷新缓存机制(clsStudyLevelBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsRecommendedDegreeBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsRecommendedDegreeBL没有刷新缓存机制(clsRecommendedDegreeBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsCaseLevelBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsCaseLevelBL没有刷新缓存机制(clsCaseLevelBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsUserTypeBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsUserTypeBL没有刷新缓存机制(clsUserTypeBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsDisciplineBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsDisciplineBL没有刷新缓存机制(clsDisciplineBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsMicroteachCaseBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsMicroteachCaseBL没有刷新缓存机制(clsMicroteachCaseBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsMicroteachCaseTypeBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsMicroteachCaseTypeBL没有刷新缓存机制(clsMicroteachCaseTypeBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsUserKindBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsUserKindBL没有刷新缓存机制(clsUserKindBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsSkillTypeBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsSkillTypeBL没有刷新缓存机制(clsSkillTypeBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsTeachSkillBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsTeachSkillBL没有刷新缓存机制(clsTeachSkillBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by IdmicroteachCaseQuantitySenateItem");
//if (arrvMicroteachCaseQuantitySenateItemsObjLstCache == null)
//{
//arrvMicroteachCaseQuantitySenateItemsObjLstCache = vMicroteachCaseQuantitySenateItemsDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "lngIdmicroteachCaseQuantitySenateItem">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvMicroteachCaseQuantitySenateItemsEN GetObjByIdmicroteachCaseQuantitySenateItemCache(long lngIdmicroteachCaseQuantitySenateItem)
{
//获取缓存中的对象列表
string strKey = string.Format("{0}", clsvMicroteachCaseQuantitySenateItemsEN._CurrTabName);
List<clsvMicroteachCaseQuantitySenateItemsEN> arrvMicroteachCaseQuantitySenateItemsObjLstCache = GetObjLstCache();
IEnumerable <clsvMicroteachCaseQuantitySenateItemsEN> arrvMicroteachCaseQuantitySenateItemsObjLst_Sel =
arrvMicroteachCaseQuantitySenateItemsObjLstCache
.Where(x=> x.IdmicroteachCaseQuantitySenateItem == lngIdmicroteachCaseQuantitySenateItem 
);
if (arrvMicroteachCaseQuantitySenateItemsObjLst_Sel.Count() == 0)
{
   clsvMicroteachCaseQuantitySenateItemsEN obj = clsvMicroteachCaseQuantitySenateItemsBL.GetObjByIdmicroteachCaseQuantitySenateItem(lngIdmicroteachCaseQuantitySenateItem);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
 }
return null;
}
return arrvMicroteachCaseQuantitySenateItemsObjLst_Sel.First();
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvMicroteachCaseQuantitySenateItemsEN> GetAllvMicroteachCaseQuantitySenateItemsObjLstCache()
{
//获取缓存中的对象列表
List<clsvMicroteachCaseQuantitySenateItemsEN> arrvMicroteachCaseQuantitySenateItemsObjLstCache = GetObjLstCache(); 
return arrvMicroteachCaseQuantitySenateItemsObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvMicroteachCaseQuantitySenateItemsEN> GetObjLstCache()
{
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}", clsvMicroteachCaseQuantitySenateItemsEN._CurrTabName);
List<clsvMicroteachCaseQuantitySenateItemsEN> arrvMicroteachCaseQuantitySenateItemsObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrvMicroteachCaseQuantitySenateItemsObjLstCache;
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
string strKey = string.Format("{0}", clsvMicroteachCaseQuantitySenateItemsEN._CurrTabName);
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
public static string Func(string strInFldName, string strOutFldName, long lngIdmicroteachCaseQuantitySenateItem)
{
if (strInFldName != convMicroteachCaseQuantitySenateItems.IdmicroteachCaseQuantitySenateItem)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (convMicroteachCaseQuantitySenateItems.AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", convMicroteachCaseQuantitySenateItems.AttributeName));
throw new Exception(strMsg);
}
var objvMicroteachCaseQuantitySenateItems = clsvMicroteachCaseQuantitySenateItemsBL.GetObjByIdmicroteachCaseQuantitySenateItemCache(lngIdmicroteachCaseQuantitySenateItem);
if (objvMicroteachCaseQuantitySenateItems == null) return "";
return objvMicroteachCaseQuantitySenateItems[strOutFldName].ToString();
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
int intRecCount = clsvMicroteachCaseQuantitySenateItemsDA.GetRecCount(strTabName);
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
int intRecCount = clsvMicroteachCaseQuantitySenateItemsDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsvMicroteachCaseQuantitySenateItemsDA.GetRecCount();
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
int intRecCount = clsvMicroteachCaseQuantitySenateItemsDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objvMicroteachCaseQuantitySenateItemsCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsvMicroteachCaseQuantitySenateItemsEN objvMicroteachCaseQuantitySenateItemsCond)
{
List<clsvMicroteachCaseQuantitySenateItemsEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsvMicroteachCaseQuantitySenateItemsEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convMicroteachCaseQuantitySenateItems.AttributeName)
{
if (objvMicroteachCaseQuantitySenateItemsCond.IsUpdated(strFldName) == false) continue;
if (objvMicroteachCaseQuantitySenateItemsCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvMicroteachCaseQuantitySenateItemsCond[strFldName].ToString());
}
else
{
if (objvMicroteachCaseQuantitySenateItemsCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvMicroteachCaseQuantitySenateItemsCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvMicroteachCaseQuantitySenateItemsCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvMicroteachCaseQuantitySenateItemsCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvMicroteachCaseQuantitySenateItemsCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvMicroteachCaseQuantitySenateItemsCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvMicroteachCaseQuantitySenateItemsCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvMicroteachCaseQuantitySenateItemsCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvMicroteachCaseQuantitySenateItemsCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvMicroteachCaseQuantitySenateItemsCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvMicroteachCaseQuantitySenateItemsCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvMicroteachCaseQuantitySenateItemsCond[strFldName]));
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
 List<string> arrList = clsvMicroteachCaseQuantitySenateItemsDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = vMicroteachCaseQuantitySenateItemsDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = vMicroteachCaseQuantitySenateItemsDA.GetFldValueNoDistinct(strFldName, strWhereCond);
return arrList;
}



 #endregion 表操作常用函数
}
}