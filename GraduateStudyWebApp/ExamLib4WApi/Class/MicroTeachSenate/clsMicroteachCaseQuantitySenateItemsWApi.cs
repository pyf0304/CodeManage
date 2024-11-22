
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsMicroteachCaseQuantitySenateItemsWApi
 表名:MicroteachCaseQuantitySenateItems(01120492)
 生成代码版本:2021.09.20.1
 生成日期:2021/09/21 02:39:16
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
public static class clsMicroteachCaseQuantitySenateItemsWApi_Static
{

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objMicroteachCaseQuantitySenateItemsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsMicroteachCaseQuantitySenateItemsEN Setid_microteachCaseQuantitySenateItem(this clsMicroteachCaseQuantitySenateItemsEN objMicroteachCaseQuantitySenateItemsEN, long lngid_microteachCaseQuantitySenateItem, string strComparisonOp="")
	{
objMicroteachCaseQuantitySenateItemsEN.id_microteachCaseQuantitySenateItem = lngid_microteachCaseQuantitySenateItem; //微格量化评价指标流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objMicroteachCaseQuantitySenateItemsEN.dicFldComparisonOp.ContainsKey(conMicroteachCaseQuantitySenateItems.id_microteachCaseQuantitySenateItem) == false)
{
objMicroteachCaseQuantitySenateItemsEN.dicFldComparisonOp.Add(conMicroteachCaseQuantitySenateItems.id_microteachCaseQuantitySenateItem, strComparisonOp);
}
else
{
objMicroteachCaseQuantitySenateItemsEN.dicFldComparisonOp[conMicroteachCaseQuantitySenateItems.id_microteachCaseQuantitySenateItem] = strComparisonOp;
}
}
return objMicroteachCaseQuantitySenateItemsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objMicroteachCaseQuantitySenateItemsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsMicroteachCaseQuantitySenateItemsEN Setid_microteachCaseQuantitySenate(this clsMicroteachCaseQuantitySenateItemsEN objMicroteachCaseQuantitySenateItemsEN, long lngid_microteachCaseQuantitySenate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(lngid_microteachCaseQuantitySenate, conMicroteachCaseQuantitySenateItems.id_microteachCaseQuantitySenate);
objMicroteachCaseQuantitySenateItemsEN.id_microteachCaseQuantitySenate = lngid_microteachCaseQuantitySenate; //微格量化评价流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objMicroteachCaseQuantitySenateItemsEN.dicFldComparisonOp.ContainsKey(conMicroteachCaseQuantitySenateItems.id_microteachCaseQuantitySenate) == false)
{
objMicroteachCaseQuantitySenateItemsEN.dicFldComparisonOp.Add(conMicroteachCaseQuantitySenateItems.id_microteachCaseQuantitySenate, strComparisonOp);
}
else
{
objMicroteachCaseQuantitySenateItemsEN.dicFldComparisonOp[conMicroteachCaseQuantitySenateItems.id_microteachCaseQuantitySenate] = strComparisonOp;
}
}
return objMicroteachCaseQuantitySenateItemsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objMicroteachCaseQuantitySenateItemsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsMicroteachCaseQuantitySenateItemsEN SetSenateScore(this clsMicroteachCaseQuantitySenateItemsEN objMicroteachCaseQuantitySenateItemsEN, float fltSenateScore, string strComparisonOp="")
	{
objMicroteachCaseQuantitySenateItemsEN.SenateScore = fltSenateScore; //指标得分
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objMicroteachCaseQuantitySenateItemsEN.dicFldComparisonOp.ContainsKey(conMicroteachCaseQuantitySenateItems.SenateScore) == false)
{
objMicroteachCaseQuantitySenateItemsEN.dicFldComparisonOp.Add(conMicroteachCaseQuantitySenateItems.SenateScore, strComparisonOp);
}
else
{
objMicroteachCaseQuantitySenateItemsEN.dicFldComparisonOp[conMicroteachCaseQuantitySenateItems.SenateScore] = strComparisonOp;
}
}
return objMicroteachCaseQuantitySenateItemsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objMicroteachCaseQuantitySenateItemsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsMicroteachCaseQuantitySenateItemsEN Setid_SenateGaugeItem(this clsMicroteachCaseQuantitySenateItemsEN objMicroteachCaseQuantitySenateItemsEN, string strid_SenateGaugeItem, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_SenateGaugeItem, 4, conMicroteachCaseQuantitySenateItems.id_SenateGaugeItem);
clsCheckSql.CheckFieldForeignKey(strid_SenateGaugeItem, 4, conMicroteachCaseQuantitySenateItems.id_SenateGaugeItem);
objMicroteachCaseQuantitySenateItemsEN.id_SenateGaugeItem = strid_SenateGaugeItem; //量表指标流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objMicroteachCaseQuantitySenateItemsEN.dicFldComparisonOp.ContainsKey(conMicroteachCaseQuantitySenateItems.id_SenateGaugeItem) == false)
{
objMicroteachCaseQuantitySenateItemsEN.dicFldComparisonOp.Add(conMicroteachCaseQuantitySenateItems.id_SenateGaugeItem, strComparisonOp);
}
else
{
objMicroteachCaseQuantitySenateItemsEN.dicFldComparisonOp[conMicroteachCaseQuantitySenateItems.id_SenateGaugeItem] = strComparisonOp;
}
}
return objMicroteachCaseQuantitySenateItemsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objMicroteachCaseQuantitySenateItemsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsMicroteachCaseQuantitySenateItemsEN Setid_SenateGaugeSubItem(this clsMicroteachCaseQuantitySenateItemsEN objMicroteachCaseQuantitySenateItemsEN, string strid_SenateGaugeSubItem, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_SenateGaugeSubItem, 4, conMicroteachCaseQuantitySenateItems.id_SenateGaugeSubItem);
clsCheckSql.CheckFieldForeignKey(strid_SenateGaugeSubItem, 4, conMicroteachCaseQuantitySenateItems.id_SenateGaugeSubItem);
objMicroteachCaseQuantitySenateItemsEN.id_SenateGaugeSubItem = strid_SenateGaugeSubItem; //量表指标子项流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objMicroteachCaseQuantitySenateItemsEN.dicFldComparisonOp.ContainsKey(conMicroteachCaseQuantitySenateItems.id_SenateGaugeSubItem) == false)
{
objMicroteachCaseQuantitySenateItemsEN.dicFldComparisonOp.Add(conMicroteachCaseQuantitySenateItems.id_SenateGaugeSubItem, strComparisonOp);
}
else
{
objMicroteachCaseQuantitySenateItemsEN.dicFldComparisonOp[conMicroteachCaseQuantitySenateItems.id_SenateGaugeSubItem] = strComparisonOp;
}
}
return objMicroteachCaseQuantitySenateItemsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objMicroteachCaseQuantitySenateItemsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsMicroteachCaseQuantitySenateItemsEN SetIsAccess(this clsMicroteachCaseQuantitySenateItemsEN objMicroteachCaseQuantitySenateItemsEN, bool bolIsAccess, string strComparisonOp="")
	{
objMicroteachCaseQuantitySenateItemsEN.IsAccess = bolIsAccess; //IsAccess
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objMicroteachCaseQuantitySenateItemsEN.dicFldComparisonOp.ContainsKey(conMicroteachCaseQuantitySenateItems.IsAccess) == false)
{
objMicroteachCaseQuantitySenateItemsEN.dicFldComparisonOp.Add(conMicroteachCaseQuantitySenateItems.IsAccess, strComparisonOp);
}
else
{
objMicroteachCaseQuantitySenateItemsEN.dicFldComparisonOp[conMicroteachCaseQuantitySenateItems.IsAccess] = strComparisonOp;
}
}
return objMicroteachCaseQuantitySenateItemsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objMicroteachCaseQuantitySenateItemsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsMicroteachCaseQuantitySenateItemsEN SetIsAccessC(this clsMicroteachCaseQuantitySenateItemsEN objMicroteachCaseQuantitySenateItemsEN, bool bolIsAccessC, string strComparisonOp="")
	{
objMicroteachCaseQuantitySenateItemsEN.IsAccessC = bolIsAccessC; //IsAccessC
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objMicroteachCaseQuantitySenateItemsEN.dicFldComparisonOp.ContainsKey(conMicroteachCaseQuantitySenateItems.IsAccessC) == false)
{
objMicroteachCaseQuantitySenateItemsEN.dicFldComparisonOp.Add(conMicroteachCaseQuantitySenateItems.IsAccessC, strComparisonOp);
}
else
{
objMicroteachCaseQuantitySenateItemsEN.dicFldComparisonOp[conMicroteachCaseQuantitySenateItems.IsAccessC] = strComparisonOp;
}
}
return objMicroteachCaseQuantitySenateItemsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objMicroteachCaseQuantitySenateItemsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsMicroteachCaseQuantitySenateItemsEN SetUpdDate(this clsMicroteachCaseQuantitySenateItemsEN objMicroteachCaseQuantitySenateItemsEN, string strUpdDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdDate, 20, conMicroteachCaseQuantitySenateItems.UpdDate);
objMicroteachCaseQuantitySenateItemsEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objMicroteachCaseQuantitySenateItemsEN.dicFldComparisonOp.ContainsKey(conMicroteachCaseQuantitySenateItems.UpdDate) == false)
{
objMicroteachCaseQuantitySenateItemsEN.dicFldComparisonOp.Add(conMicroteachCaseQuantitySenateItems.UpdDate, strComparisonOp);
}
else
{
objMicroteachCaseQuantitySenateItemsEN.dicFldComparisonOp[conMicroteachCaseQuantitySenateItems.UpdDate] = strComparisonOp;
}
}
return objMicroteachCaseQuantitySenateItemsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objMicroteachCaseQuantitySenateItemsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsMicroteachCaseQuantitySenateItemsEN SetUpdUser(this clsMicroteachCaseQuantitySenateItemsEN objMicroteachCaseQuantitySenateItemsEN, string strUpdUser, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdUser, 20, conMicroteachCaseQuantitySenateItems.UpdUser);
objMicroteachCaseQuantitySenateItemsEN.UpdUser = strUpdUser; //修改人
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objMicroteachCaseQuantitySenateItemsEN.dicFldComparisonOp.ContainsKey(conMicroteachCaseQuantitySenateItems.UpdUser) == false)
{
objMicroteachCaseQuantitySenateItemsEN.dicFldComparisonOp.Add(conMicroteachCaseQuantitySenateItems.UpdUser, strComparisonOp);
}
else
{
objMicroteachCaseQuantitySenateItemsEN.dicFldComparisonOp[conMicroteachCaseQuantitySenateItems.UpdUser] = strComparisonOp;
}
}
return objMicroteachCaseQuantitySenateItemsEN;
	}

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsMicroteachCaseQuantitySenateItemsEN objMicroteachCaseQuantitySenateItems_Cond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objMicroteachCaseQuantitySenateItems_Cond.IsUpdated(conMicroteachCaseQuantitySenateItems.id_microteachCaseQuantitySenateItem) == true)
{
string strComparisonOp_id_microteachCaseQuantitySenateItem = objMicroteachCaseQuantitySenateItems_Cond.dicFldComparisonOp[conMicroteachCaseQuantitySenateItems.id_microteachCaseQuantitySenateItem];
strWhereCond += string.Format(" And {0} {2} {1}", conMicroteachCaseQuantitySenateItems.id_microteachCaseQuantitySenateItem, objMicroteachCaseQuantitySenateItems_Cond.id_microteachCaseQuantitySenateItem, strComparisonOp_id_microteachCaseQuantitySenateItem);
}
if (objMicroteachCaseQuantitySenateItems_Cond.IsUpdated(conMicroteachCaseQuantitySenateItems.id_microteachCaseQuantitySenate) == true)
{
string strComparisonOp_id_microteachCaseQuantitySenate = objMicroteachCaseQuantitySenateItems_Cond.dicFldComparisonOp[conMicroteachCaseQuantitySenateItems.id_microteachCaseQuantitySenate];
strWhereCond += string.Format(" And {0} {2} {1}", conMicroteachCaseQuantitySenateItems.id_microteachCaseQuantitySenate, objMicroteachCaseQuantitySenateItems_Cond.id_microteachCaseQuantitySenate, strComparisonOp_id_microteachCaseQuantitySenate);
}
if (objMicroteachCaseQuantitySenateItems_Cond.IsUpdated(conMicroteachCaseQuantitySenateItems.SenateScore) == true)
{
string strComparisonOp_SenateScore = objMicroteachCaseQuantitySenateItems_Cond.dicFldComparisonOp[conMicroteachCaseQuantitySenateItems.SenateScore];
strWhereCond += string.Format(" And {0} {2} {1}", conMicroteachCaseQuantitySenateItems.SenateScore, objMicroteachCaseQuantitySenateItems_Cond.SenateScore, strComparisonOp_SenateScore);
}
if (objMicroteachCaseQuantitySenateItems_Cond.IsUpdated(conMicroteachCaseQuantitySenateItems.id_SenateGaugeItem) == true)
{
string strComparisonOp_id_SenateGaugeItem = objMicroteachCaseQuantitySenateItems_Cond.dicFldComparisonOp[conMicroteachCaseQuantitySenateItems.id_SenateGaugeItem];
strWhereCond += string.Format(" And {0} {2} '{1}'", conMicroteachCaseQuantitySenateItems.id_SenateGaugeItem, objMicroteachCaseQuantitySenateItems_Cond.id_SenateGaugeItem, strComparisonOp_id_SenateGaugeItem);
}
if (objMicroteachCaseQuantitySenateItems_Cond.IsUpdated(conMicroteachCaseQuantitySenateItems.id_SenateGaugeSubItem) == true)
{
string strComparisonOp_id_SenateGaugeSubItem = objMicroteachCaseQuantitySenateItems_Cond.dicFldComparisonOp[conMicroteachCaseQuantitySenateItems.id_SenateGaugeSubItem];
strWhereCond += string.Format(" And {0} {2} '{1}'", conMicroteachCaseQuantitySenateItems.id_SenateGaugeSubItem, objMicroteachCaseQuantitySenateItems_Cond.id_SenateGaugeSubItem, strComparisonOp_id_SenateGaugeSubItem);
}
if (objMicroteachCaseQuantitySenateItems_Cond.IsUpdated(conMicroteachCaseQuantitySenateItems.IsAccess) == true)
{
if (objMicroteachCaseQuantitySenateItems_Cond.IsAccess == true)
{
strWhereCond += string.Format(" And {0} = '1'", conMicroteachCaseQuantitySenateItems.IsAccess);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conMicroteachCaseQuantitySenateItems.IsAccess);
}
}
if (objMicroteachCaseQuantitySenateItems_Cond.IsUpdated(conMicroteachCaseQuantitySenateItems.IsAccessC) == true)
{
if (objMicroteachCaseQuantitySenateItems_Cond.IsAccessC == true)
{
strWhereCond += string.Format(" And {0} = '1'", conMicroteachCaseQuantitySenateItems.IsAccessC);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conMicroteachCaseQuantitySenateItems.IsAccessC);
}
}
if (objMicroteachCaseQuantitySenateItems_Cond.IsUpdated(conMicroteachCaseQuantitySenateItems.UpdDate) == true)
{
string strComparisonOp_UpdDate = objMicroteachCaseQuantitySenateItems_Cond.dicFldComparisonOp[conMicroteachCaseQuantitySenateItems.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conMicroteachCaseQuantitySenateItems.UpdDate, objMicroteachCaseQuantitySenateItems_Cond.UpdDate, strComparisonOp_UpdDate);
}
if (objMicroteachCaseQuantitySenateItems_Cond.IsUpdated(conMicroteachCaseQuantitySenateItems.UpdUser) == true)
{
string strComparisonOp_UpdUser = objMicroteachCaseQuantitySenateItems_Cond.dicFldComparisonOp[conMicroteachCaseQuantitySenateItems.UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", conMicroteachCaseQuantitySenateItems.UpdUser, objMicroteachCaseQuantitySenateItems_Cond.UpdUser, strComparisonOp_UpdUser);
}
 return strWhereCond;
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_Update)
 /// </summary>
 /// <param name = "objMicroteachCaseQuantitySenateItemsEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsMicroteachCaseQuantitySenateItemsEN objMicroteachCaseQuantitySenateItemsEN)
{
 if (objMicroteachCaseQuantitySenateItemsEN.id_microteachCaseQuantitySenateItem == 0)
 {
string strMsg = string.Format("(errid:Watl000003)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
objMicroteachCaseQuantitySenateItemsEN.sf_UpdFldSetStr = objMicroteachCaseQuantitySenateItemsEN.getsf_UpdFldSetStr();
clsMicroteachCaseQuantitySenateItemsWApi.CheckPropertyNew(objMicroteachCaseQuantitySenateItemsEN); 
bool bolResult = clsMicroteachCaseQuantitySenateItemsWApi.UpdateRecord(objMicroteachCaseQuantitySenateItemsEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsMicroteachCaseQuantitySenateItemsWApi.ReFreshCache();
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
 /// 检查唯一性(Uniqueness)--MicroteachCaseQuantitySenateItems(微格量化评价详细指标), 如果不唯一,即存在相同的记录,就返回False
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_GetConditionString4Constraint)
 /// </summary>
 /// <param name = "objMicroteachCaseQuantitySenateItemsEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniConditionStr_id_microteachCaseQuantitySenate_id_SenateGaugeItem(this clsMicroteachCaseQuantitySenateItemsEN objMicroteachCaseQuantitySenateItemsEN)
{
//检测记录是否存在
StringBuilder sbCondition = new StringBuilder();
if (objMicroteachCaseQuantitySenateItemsEN == null) return "";
if (objMicroteachCaseQuantitySenateItemsEN.id_microteachCaseQuantitySenateItem == 0)
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and id_microteachCaseQuantitySenate = '{0}'", objMicroteachCaseQuantitySenateItemsEN.id_microteachCaseQuantitySenate);
 sbCondition.AppendFormat(" and id_SenateGaugeItem = '{0}'", objMicroteachCaseQuantitySenateItemsEN.id_SenateGaugeItem);
return sbCondition.ToString();
}
 else {
sbCondition.AppendFormat("id_microteachCaseQuantitySenateItem !=  {0}", objMicroteachCaseQuantitySenateItemsEN.id_microteachCaseQuantitySenateItem);
 sbCondition.AppendFormat(" and id_microteachCaseQuantitySenate = '{0}'", objMicroteachCaseQuantitySenateItemsEN.id_microteachCaseQuantitySenate);
 sbCondition.AppendFormat(" and id_SenateGaugeItem = '{0}'", objMicroteachCaseQuantitySenateItemsEN.id_SenateGaugeItem);
 return sbCondition.ToString();
}
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_AddNewRecord)
 /// </summary>
 /// <param name = "objMicroteachCaseQuantitySenateItemsEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clsMicroteachCaseQuantitySenateItemsEN objMicroteachCaseQuantitySenateItemsEN)
{
try
{
clsMicroteachCaseQuantitySenateItemsWApi.CheckPropertyNew(objMicroteachCaseQuantitySenateItemsEN); 
bool bolResult = clsMicroteachCaseQuantitySenateItemsWApi.AddNewRecord(objMicroteachCaseQuantitySenateItemsEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsMicroteachCaseQuantitySenateItemsWApi.ReFreshCache();
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
 /// /// 功能:通过SQL命令来修改记录,该方式是非优化方式,根据条件修改记录
 /// /// 缺点:1、不能处理字段中的单撇问题；2、不能处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_UpdateWithCondition)
 /// </summary>
 /// <param name = "objMicroteachCaseQuantitySenateItemsEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsMicroteachCaseQuantitySenateItemsEN objMicroteachCaseQuantitySenateItemsEN, string strWhereCond)
{
try
{
clsMicroteachCaseQuantitySenateItemsWApi.CheckPropertyNew(objMicroteachCaseQuantitySenateItemsEN); 
bool bolResult = clsMicroteachCaseQuantitySenateItemsWApi.UpdateWithCondition(objMicroteachCaseQuantitySenateItemsEN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsMicroteachCaseQuantitySenateItemsWApi.ReFreshCache();
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
 /// 微格量化评价详细指标(MicroteachCaseQuantitySenateItems)
 /// (AutoGCLib.WA_Access4CSharp:GeneCode)
 /// </summary>
public class clsMicroteachCaseQuantitySenateItemsWApi
{
private static readonly string mstrApiControllerName = "MicroteachCaseQuantitySenateItemsApi";

 /// <summary>
/// 专门在逻辑层用于处理缓存等公共函数的对象
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_DefineObjCommFun4BL)
/// </summary>
public static clsCommFun4BL objCommFun4BL = null;

 public clsMicroteachCaseQuantitySenateItemsWApi()
 {
 }

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_CheckPropertyNew)
 /// </summary>
public static void CheckPropertyNew(clsMicroteachCaseQuantitySenateItemsEN objMicroteachCaseQuantitySenateItemsEN)
{
if (!Object.Equals(null, objMicroteachCaseQuantitySenateItemsEN.id_SenateGaugeItem) && GetStrLen(objMicroteachCaseQuantitySenateItemsEN.id_SenateGaugeItem) > 4)
{
 throw new Exception("字段[量表指标流水号]的长度不能超过4!");
}
if (!Object.Equals(null, objMicroteachCaseQuantitySenateItemsEN.id_SenateGaugeSubItem) && GetStrLen(objMicroteachCaseQuantitySenateItemsEN.id_SenateGaugeSubItem) > 4)
{
 throw new Exception("字段[量表指标子项流水号]的长度不能超过4!");
}
if (!Object.Equals(null, objMicroteachCaseQuantitySenateItemsEN.UpdDate) && GetStrLen(objMicroteachCaseQuantitySenateItemsEN.UpdDate) > 20)
{
 throw new Exception("字段[修改日期]的长度不能超过20!");
}
if (!Object.Equals(null, objMicroteachCaseQuantitySenateItemsEN.UpdUser) && GetStrLen(objMicroteachCaseQuantitySenateItemsEN.UpdUser) > 20)
{
 throw new Exception("字段[修改人]的长度不能超过20!");
}
 objMicroteachCaseQuantitySenateItemsEN._IsCheckProperty = true;
 }

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyId)
 /// </summary>
 /// <param name = "lngid_microteachCaseQuantitySenateItem">表关键字</param>
 /// <returns>表对象</returns>
public static clsMicroteachCaseQuantitySenateItemsEN GetObjByid_microteachCaseQuantitySenateItem(long lngid_microteachCaseQuantitySenateItem)
{
string strAction = "GetObjByid_microteachCaseQuantitySenateItem";
string strErrMsg = string.Empty;
string strResult = "";
clsMicroteachCaseQuantitySenateItemsEN objMicroteachCaseQuantitySenateItemsEN = null;
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
objMicroteachCaseQuantitySenateItemsEN = JsonConvert.DeserializeObject<clsMicroteachCaseQuantitySenateItemsEN>((string)jobjReturn["ReturnObj"]);
return objMicroteachCaseQuantitySenateItemsEN;
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
public static clsMicroteachCaseQuantitySenateItemsEN GetObjByid_microteachCaseQuantitySenateItem_WA_Cache(long lngid_microteachCaseQuantitySenateItem)
{
string strAction = "GetObjByid_microteachCaseQuantitySenateItem_Cache";
string strErrMsg = string.Empty;
string strResult = "";
clsMicroteachCaseQuantitySenateItemsEN objMicroteachCaseQuantitySenateItemsEN = null;
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
objMicroteachCaseQuantitySenateItemsEN = JsonConvert.DeserializeObject<clsMicroteachCaseQuantitySenateItemsEN>((string)jobjReturn["ReturnObj"]);
return objMicroteachCaseQuantitySenateItemsEN;
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
public static clsMicroteachCaseQuantitySenateItemsEN GetFirstObj(string strWhereCond)
{
string strAction = "GetFirstObj";
string strErrMsg = string.Empty;
string strResult = "";
clsMicroteachCaseQuantitySenateItemsEN objMicroteachCaseQuantitySenateItemsEN = null;
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
objMicroteachCaseQuantitySenateItemsEN = JsonConvert.DeserializeObject<clsMicroteachCaseQuantitySenateItemsEN>((string)jobjReturn["ReturnObj"]);
return objMicroteachCaseQuantitySenateItemsEN;
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
public static clsMicroteachCaseQuantitySenateItemsEN GetObjByid_microteachCaseQuantitySenateItem_Cache(long lngid_microteachCaseQuantitySenateItem)
{
//初始化列表缓存
string strKey = string.Format("{0}", clsMicroteachCaseQuantitySenateItemsEN._CurrTabName_S);
List<clsMicroteachCaseQuantitySenateItemsEN> arrMicroteachCaseQuantitySenateItemsObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsMicroteachCaseQuantitySenateItemsEN> arrMicroteachCaseQuantitySenateItemsObjLst_Sel =
from objMicroteachCaseQuantitySenateItemsEN in arrMicroteachCaseQuantitySenateItemsObjLst_Cache
where objMicroteachCaseQuantitySenateItemsEN.id_microteachCaseQuantitySenateItem == lngid_microteachCaseQuantitySenateItem
select objMicroteachCaseQuantitySenateItemsEN;
if (arrMicroteachCaseQuantitySenateItemsObjLst_Sel.Count() == 0)
{
   clsMicroteachCaseQuantitySenateItemsEN obj = clsMicroteachCaseQuantitySenateItemsWApi.GetObjByid_microteachCaseQuantitySenateItem(lngid_microteachCaseQuantitySenateItem);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
     return obj;
 }
return null;
}
return arrMicroteachCaseQuantitySenateItemsObjLst_Sel.First();
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsMicroteachCaseQuantitySenateItemsEN> GetObjLst(string strWhereCond)
{
 List<clsMicroteachCaseQuantitySenateItemsEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsMicroteachCaseQuantitySenateItemsEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsMicroteachCaseQuantitySenateItemsEN> GetObjLstById_microteachCaseQuantitySenateItemLst(List<long> arrId_microteachCaseQuantitySenateItem)
{
 List<clsMicroteachCaseQuantitySenateItemsEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsMicroteachCaseQuantitySenateItemsEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static IEnumerable<clsMicroteachCaseQuantitySenateItemsEN> GetObjLstById_microteachCaseQuantitySenateItemLst_Cache(List<long> arrId_microteachCaseQuantitySenateItem)
{
//初始化列表缓存
string strKey = string.Format("{0}", clsMicroteachCaseQuantitySenateItemsEN._CurrTabName_S);
List<clsMicroteachCaseQuantitySenateItemsEN> arrMicroteachCaseQuantitySenateItemsObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsMicroteachCaseQuantitySenateItemsEN> arrMicroteachCaseQuantitySenateItemsObjLst_Sel =
from objMicroteachCaseQuantitySenateItemsEN in arrMicroteachCaseQuantitySenateItemsObjLst_Cache
where arrId_microteachCaseQuantitySenateItem.Contains(objMicroteachCaseQuantitySenateItemsEN.id_microteachCaseQuantitySenateItem)
select objMicroteachCaseQuantitySenateItemsEN;
return arrMicroteachCaseQuantitySenateItemsObjLst_Sel;
}

 /// <summary>
 /// 根据关键字列表获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstByKeyLst_WA_Cache)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsMicroteachCaseQuantitySenateItemsEN> GetObjLstById_microteachCaseQuantitySenateItemLst_WA_Cache(List<long> arrId_microteachCaseQuantitySenateItem)
{
 List<clsMicroteachCaseQuantitySenateItemsEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsMicroteachCaseQuantitySenateItemsEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsMicroteachCaseQuantitySenateItemsEN> GetTopObjLst(stuTopPara objTopPara)
{
 List<clsMicroteachCaseQuantitySenateItemsEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsMicroteachCaseQuantitySenateItemsEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsMicroteachCaseQuantitySenateItemsEN> GetObjLstByRange(stuRangePara objRangePara)
{
 List<clsMicroteachCaseQuantitySenateItemsEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsMicroteachCaseQuantitySenateItemsEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsMicroteachCaseQuantitySenateItemsEN> GetObjLstByPager(stuPagerPara objPagerPara)
{
 List<clsMicroteachCaseQuantitySenateItemsEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsMicroteachCaseQuantitySenateItemsEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsMicroteachCaseQuantitySenateItemsEN> GetObjLstByPager_Cache(stuPagerPara objPagerPara)
{
 List<clsMicroteachCaseQuantitySenateItemsEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsMicroteachCaseQuantitySenateItemsEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static int DelRecord(long lngid_microteachCaseQuantitySenateItem)
{
string strAction = "DelRecord";
string strErrMsg = string.Empty;
string strResult = "";
try
{
 clsMicroteachCaseQuantitySenateItemsEN objMicroteachCaseQuantitySenateItemsEN = clsMicroteachCaseQuantitySenateItemsWApi.GetObjByid_microteachCaseQuantitySenateItem(lngid_microteachCaseQuantitySenateItem);
if (clsPubFun4WApi.Delete(mstrApiControllerName, strAction, lngid_microteachCaseQuantitySenateItem.ToString(), out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
clsMicroteachCaseQuantitySenateItemsWApi.ReFreshCache();
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
public static int DelMicroteachCaseQuantitySenateItemss(List<string> arrid_microteachCaseQuantitySenateItem)
{
string strAction = "DelMicroteachCaseQuantitySenateItemss";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrid_microteachCaseQuantitySenateItem);
if (clsPubFun4WApi.Deletes(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
clsMicroteachCaseQuantitySenateItemsWApi.ReFreshCache();
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
public static int DelMicroteachCaseQuantitySenateItemssByCond(string strWhereCond)
{
string strAction = "DelMicroteachCaseQuantitySenateItemssByCond";
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
public static bool AddNewRecord(clsMicroteachCaseQuantitySenateItemsEN objMicroteachCaseQuantitySenateItemsEN)
{
string strAction = "AddNewRecord";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsMicroteachCaseQuantitySenateItemsEN>(objMicroteachCaseQuantitySenateItemsEN);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJson, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsMicroteachCaseQuantitySenateItemsWApi.ReFreshCache();
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
 /// 把表对象添加到数据库中,并且返回该记录的关键字(针对Identity关键字)
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_AddNewRecordWithReturnKey)
 /// </summary>
 /// <param name = "objMicroteachCaseQuantitySenateItemsEN">需要添加的表对象</param>
 /// <returns>返回新添加记录的关键字</returns>
public static string AddNewRecordWithReturnKey(clsMicroteachCaseQuantitySenateItemsEN objMicroteachCaseQuantitySenateItemsEN)
{
string strAction = "AddNewRecord";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsMicroteachCaseQuantitySenateItemsEN>(objMicroteachCaseQuantitySenateItemsEN);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJson, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsMicroteachCaseQuantitySenateItemsWApi.ReFreshCache();
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
 /// 修改记录
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_UpdateRecord)
 /// </summary>
 /// <returns>是否成功?</returns>
public static bool UpdateRecord(clsMicroteachCaseQuantitySenateItemsEN objMicroteachCaseQuantitySenateItemsEN)
{
if (string.IsNullOrEmpty(objMicroteachCaseQuantitySenateItemsEN.sf_UpdFldSetStr) == true)
{
string strMsg = string.Format("修改时，修改标志串为空，请联系管理员.对象关键字:{0}.(from {1}).",
objMicroteachCaseQuantitySenateItemsEN.id_microteachCaseQuantitySenateItem, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
string strAction = "UpdateRecord";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsMicroteachCaseQuantitySenateItemsEN>(objMicroteachCaseQuantitySenateItemsEN);
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
 /// <param name = "objMicroteachCaseQuantitySenateItemsEN">需要修改的对象</param>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的关键字值</returns>
public static bool UpdateWithCondition(clsMicroteachCaseQuantitySenateItemsEN objMicroteachCaseQuantitySenateItemsEN, string strWhereCond)
{
if (string.IsNullOrEmpty(objMicroteachCaseQuantitySenateItemsEN.sf_UpdFldSetStr) == true)
{
string strMsg = string.Format("修改时，修改标志串为空，请联系管理员.对象关键字:{0}.(from {1}).",
objMicroteachCaseQuantitySenateItemsEN.id_microteachCaseQuantitySenateItem, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (string.IsNullOrEmpty(strWhereCond) == true)
{
string strMsg = string.Format("按条件修改时，条件串为空，请联系管理员.对象关键字:{0}.(from {1}).",
objMicroteachCaseQuantitySenateItemsEN.id_microteachCaseQuantitySenateItem, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
string strAction = "UpdateWithCondition";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsMicroteachCaseQuantitySenateItemsEN>(objMicroteachCaseQuantitySenateItemsEN);
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
 /// <param name = "objMicroteachCaseQuantitySenateItemsENS">源对象</param>
 /// <param name = "objMicroteachCaseQuantitySenateItemsENT">目标对象</param>
 public static void CopyTo(clsMicroteachCaseQuantitySenateItemsEN objMicroteachCaseQuantitySenateItemsENS, clsMicroteachCaseQuantitySenateItemsEN objMicroteachCaseQuantitySenateItemsENT)
{
try
{
objMicroteachCaseQuantitySenateItemsENT.id_microteachCaseQuantitySenateItem = objMicroteachCaseQuantitySenateItemsENS.id_microteachCaseQuantitySenateItem; //微格量化评价指标流水号
objMicroteachCaseQuantitySenateItemsENT.id_microteachCaseQuantitySenate = objMicroteachCaseQuantitySenateItemsENS.id_microteachCaseQuantitySenate; //微格量化评价流水号
objMicroteachCaseQuantitySenateItemsENT.SenateScore = objMicroteachCaseQuantitySenateItemsENS.SenateScore; //指标得分
objMicroteachCaseQuantitySenateItemsENT.id_SenateGaugeItem = objMicroteachCaseQuantitySenateItemsENS.id_SenateGaugeItem; //量表指标流水号
objMicroteachCaseQuantitySenateItemsENT.id_SenateGaugeSubItem = objMicroteachCaseQuantitySenateItemsENS.id_SenateGaugeSubItem; //量表指标子项流水号
objMicroteachCaseQuantitySenateItemsENT.IsAccess = objMicroteachCaseQuantitySenateItemsENS.IsAccess; //IsAccess
objMicroteachCaseQuantitySenateItemsENT.IsAccessC = objMicroteachCaseQuantitySenateItemsENS.IsAccessC; //IsAccessC
objMicroteachCaseQuantitySenateItemsENT.UpdDate = objMicroteachCaseQuantitySenateItemsENS.UpdDate; //修改日期
objMicroteachCaseQuantitySenateItemsENT.UpdUser = objMicroteachCaseQuantitySenateItemsENS.UpdUser; //修改人
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
public static DataTable ToDataTable(List<clsMicroteachCaseQuantitySenateItemsEN> arrObj)
{
DataTable dataTable = new DataTable(); //实例化
DataTable result;
if (arrObj.Count == 0) return null;
if (clsMicroteachCaseQuantitySenateItemsEN.AttributeName.Length == 0)
{
result = dataTable;
return result;
}
Type type = typeof(clsMicroteachCaseQuantitySenateItemsEN);
PropertyInfo[] arrPropertyInfo = type.GetProperties();
try
{
//Columns
foreach (string strAttrName in clsMicroteachCaseQuantitySenateItemsEN.AttributeName)
{
PropertyInfo proprety_Curr = arrPropertyInfo.Where(x => x.Name == strAttrName).First();
dataTable.Columns.Add(strAttrName, proprety_Curr.PropertyType);
}
foreach (clsMicroteachCaseQuantitySenateItemsEN objInFor in arrObj)
{
//Rows
DataRow dataRow = dataTable.NewRow();
foreach (string strAttrName in clsMicroteachCaseQuantitySenateItemsEN.AttributeName)
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
if (clsMicroteachCaseQuantitySenateItemsWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsMicroteachCaseQuantitySenateItemsWApi没有刷新缓存机制(clsMicroteachCaseQuantitySenateItemsWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by id_microteachCaseQuantitySenateItem");
//if (arrMicroteachCaseQuantitySenateItemsObjLst_Cache == null)
//{
//arrMicroteachCaseQuantitySenateItemsObjLst_Cache = await clsMicroteachCaseQuantitySenateItemsWApi.GetObjLst(strWhereCond);
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
string strKey = string.Format("{0}", clsMicroteachCaseQuantitySenateItemsEN._CurrTabName_S);
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
if (clsMicroteachCaseQuantitySenateItemsWApi.objCommFun4BL != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}", clsMicroteachCaseQuantitySenateItemsEN._CurrTabName_S);
CacheHelper.Remove(strKey);
clsMicroteachCaseQuantitySenateItemsWApi.objCommFun4BL.ReFreshCache();
}
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst_Cache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsMicroteachCaseQuantitySenateItemsEN> GetObjLst_Cache()
{
//初始化列表缓存
InitListCache(); 
string strKey = string.Format("{0}", clsMicroteachCaseQuantitySenateItemsEN._CurrTabName_S);
List<clsMicroteachCaseQuantitySenateItemsEN> arrMicroteachCaseQuantitySenateItemsObjLst_Cache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrMicroteachCaseQuantitySenateItemsObjLst_Cache;
}

 /// <summary>
 /// 根据对象列表获取DataTable
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetDataTableByObjLst)
 /// </summary>
 /// <param name = "arrObjLst">给定的对象列表</param>
 /// <returns>返回DataTable</returns>
public static DataTable GetDataTableByObjLst(List<clsMicroteachCaseQuantitySenateItemsEN> arrObjLst)
{
DataTable objDT = new DataTable();
objDT.Columns.Add(conMicroteachCaseQuantitySenateItems.id_microteachCaseQuantitySenateItem, Type.GetType("System.Int64"));
objDT.Columns.Add(conMicroteachCaseQuantitySenateItems.id_microteachCaseQuantitySenate, Type.GetType("System.Int64"));
objDT.Columns.Add(conMicroteachCaseQuantitySenateItems.SenateScore, Type.GetType("System.Single"));
objDT.Columns.Add(conMicroteachCaseQuantitySenateItems.id_SenateGaugeItem, Type.GetType("System.String"));
objDT.Columns.Add(conMicroteachCaseQuantitySenateItems.id_SenateGaugeSubItem, Type.GetType("System.String"));
objDT.Columns.Add(conMicroteachCaseQuantitySenateItems.IsAccess, Type.GetType("System.Boolean"));
objDT.Columns.Add(conMicroteachCaseQuantitySenateItems.IsAccessC, Type.GetType("System.Boolean"));
objDT.Columns.Add(conMicroteachCaseQuantitySenateItems.UpdDate, Type.GetType("System.String"));
objDT.Columns.Add(conMicroteachCaseQuantitySenateItems.UpdUser, Type.GetType("System.String"));
foreach (clsMicroteachCaseQuantitySenateItemsEN objInFor in arrObjLst)
{
DataRow objDR = objDT.NewRow();
objDR[conMicroteachCaseQuantitySenateItems.id_microteachCaseQuantitySenateItem] = objInFor[conMicroteachCaseQuantitySenateItems.id_microteachCaseQuantitySenateItem];
objDR[conMicroteachCaseQuantitySenateItems.id_microteachCaseQuantitySenate] = objInFor[conMicroteachCaseQuantitySenateItems.id_microteachCaseQuantitySenate];
objDR[conMicroteachCaseQuantitySenateItems.SenateScore] = objInFor[conMicroteachCaseQuantitySenateItems.SenateScore];
objDR[conMicroteachCaseQuantitySenateItems.id_SenateGaugeItem] = objInFor[conMicroteachCaseQuantitySenateItems.id_SenateGaugeItem];
objDR[conMicroteachCaseQuantitySenateItems.id_SenateGaugeSubItem] = objInFor[conMicroteachCaseQuantitySenateItems.id_SenateGaugeSubItem];
objDR[conMicroteachCaseQuantitySenateItems.IsAccess] = objInFor[conMicroteachCaseQuantitySenateItems.IsAccess];
objDR[conMicroteachCaseQuantitySenateItems.IsAccessC] = objInFor[conMicroteachCaseQuantitySenateItems.IsAccessC];
objDR[conMicroteachCaseQuantitySenateItems.UpdDate] = objInFor[conMicroteachCaseQuantitySenateItems.UpdDate];
objDR[conMicroteachCaseQuantitySenateItems.UpdUser] = objInFor[conMicroteachCaseQuantitySenateItems.UpdUser];
objDT.Rows.Add(objDR);
}
return objDT;
}
}
 /// <summary>
 /// 微格量化评价详细指标(MicroteachCaseQuantitySenateItems)
 /// 数据源类型:SQL表
 /// (AutoGCLib.CommFun4WA4CSharp:GeneCode_This)
 /// </summary>
public class clsCommFun4WA4MicroteachCaseQuantitySenateItems : clsCommFun4BL
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
clsMicroteachCaseQuantitySenateItemsWApi.ReFreshThisCache();
}
}

}