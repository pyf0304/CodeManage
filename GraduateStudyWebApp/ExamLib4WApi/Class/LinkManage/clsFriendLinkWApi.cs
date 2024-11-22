
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsFriendLinkWApi
 表名:FriendLink(01120439)
 生成代码版本:2021.09.20.1
 生成日期:2021/09/21 02:50:36
 生成者:pyf
 生成服务器IP:103.116.76.183
 工程名称:问卷调查
 工程ID:0112
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:链接管理
 模块英文名:LinkManage
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
public static class clsFriendLinkWApi_Static
{

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objFriendLinkEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsFriendLinkEN SetFriendLinkId(this clsFriendLinkEN objFriendLinkEN, long lngFriendLinkId, string strComparisonOp="")
	{
objFriendLinkEN.FriendLinkId = lngFriendLinkId; //友情链接Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objFriendLinkEN.dicFldComparisonOp.ContainsKey(conFriendLink.FriendLinkId) == false)
{
objFriendLinkEN.dicFldComparisonOp.Add(conFriendLink.FriendLinkId, strComparisonOp);
}
else
{
objFriendLinkEN.dicFldComparisonOp[conFriendLink.FriendLinkId] = strComparisonOp;
}
}
return objFriendLinkEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objFriendLinkEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsFriendLinkEN SetLinkCategoriesId(this clsFriendLinkEN objFriendLinkEN, string strLinkCategoriesId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strLinkCategoriesId, 2, conFriendLink.LinkCategoriesId);
clsCheckSql.CheckFieldForeignKey(strLinkCategoriesId, 2, conFriendLink.LinkCategoriesId);
objFriendLinkEN.LinkCategoriesId = strLinkCategoriesId; //链接分类Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objFriendLinkEN.dicFldComparisonOp.ContainsKey(conFriendLink.LinkCategoriesId) == false)
{
objFriendLinkEN.dicFldComparisonOp.Add(conFriendLink.LinkCategoriesId, strComparisonOp);
}
else
{
objFriendLinkEN.dicFldComparisonOp[conFriendLink.LinkCategoriesId] = strComparisonOp;
}
}
return objFriendLinkEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objFriendLinkEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsFriendLinkEN SetFriendLinkName(this clsFriendLinkEN objFriendLinkEN, string strFriendLinkName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strFriendLinkName, conFriendLink.FriendLinkName);
clsCheckSql.CheckFieldLen(strFriendLinkName, 100, conFriendLink.FriendLinkName);
objFriendLinkEN.FriendLinkName = strFriendLinkName; //友情链接名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objFriendLinkEN.dicFldComparisonOp.ContainsKey(conFriendLink.FriendLinkName) == false)
{
objFriendLinkEN.dicFldComparisonOp.Add(conFriendLink.FriendLinkName, strComparisonOp);
}
else
{
objFriendLinkEN.dicFldComparisonOp[conFriendLink.FriendLinkName] = strComparisonOp;
}
}
return objFriendLinkEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objFriendLinkEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsFriendLinkEN SetFriendLinkUrl(this clsFriendLinkEN objFriendLinkEN, string strFriendLinkUrl, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFriendLinkUrl, 500, conFriendLink.FriendLinkUrl);
objFriendLinkEN.FriendLinkUrl = strFriendLinkUrl; //友情链接地址
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objFriendLinkEN.dicFldComparisonOp.ContainsKey(conFriendLink.FriendLinkUrl) == false)
{
objFriendLinkEN.dicFldComparisonOp.Add(conFriendLink.FriendLinkUrl, strComparisonOp);
}
else
{
objFriendLinkEN.dicFldComparisonOp[conFriendLink.FriendLinkUrl] = strComparisonOp;
}
}
return objFriendLinkEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objFriendLinkEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsFriendLinkEN SetIsMark(this clsFriendLinkEN objFriendLinkEN, bool bolIsMark, string strComparisonOp="")
	{
objFriendLinkEN.IsMark = bolIsMark; //是否启用
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objFriendLinkEN.dicFldComparisonOp.ContainsKey(conFriendLink.IsMark) == false)
{
objFriendLinkEN.dicFldComparisonOp.Add(conFriendLink.IsMark, strComparisonOp);
}
else
{
objFriendLinkEN.dicFldComparisonOp[conFriendLink.IsMark] = strComparisonOp;
}
}
return objFriendLinkEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objFriendLinkEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsFriendLinkEN SetImageUrl(this clsFriendLinkEN objFriendLinkEN, string strImageUrl, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strImageUrl, 50, conFriendLink.ImageUrl);
objFriendLinkEN.ImageUrl = strImageUrl; //ImageUrl
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objFriendLinkEN.dicFldComparisonOp.ContainsKey(conFriendLink.ImageUrl) == false)
{
objFriendLinkEN.dicFldComparisonOp.Add(conFriendLink.ImageUrl, strComparisonOp);
}
else
{
objFriendLinkEN.dicFldComparisonOp[conFriendLink.ImageUrl] = strComparisonOp;
}
}
return objFriendLinkEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objFriendLinkEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsFriendLinkEN SetLinkTypeId(this clsFriendLinkEN objFriendLinkEN, string strLinkTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strLinkTypeId, 4, conFriendLink.LinkTypeId);
clsCheckSql.CheckFieldForeignKey(strLinkTypeId, 4, conFriendLink.LinkTypeId);
objFriendLinkEN.LinkTypeId = strLinkTypeId; //LinkTypeId
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objFriendLinkEN.dicFldComparisonOp.ContainsKey(conFriendLink.LinkTypeId) == false)
{
objFriendLinkEN.dicFldComparisonOp.Add(conFriendLink.LinkTypeId, strComparisonOp);
}
else
{
objFriendLinkEN.dicFldComparisonOp[conFriendLink.LinkTypeId] = strComparisonOp;
}
}
return objFriendLinkEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objFriendLinkEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsFriendLinkEN Setid_XzMajor(this clsFriendLinkEN objFriendLinkEN, string strid_XzMajor, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_XzMajor, 8, conFriendLink.id_XzMajor);
clsCheckSql.CheckFieldForeignKey(strid_XzMajor, 8, conFriendLink.id_XzMajor);
objFriendLinkEN.id_XzMajor = strid_XzMajor; //专业流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objFriendLinkEN.dicFldComparisonOp.ContainsKey(conFriendLink.id_XzMajor) == false)
{
objFriendLinkEN.dicFldComparisonOp.Add(conFriendLink.id_XzMajor, strComparisonOp);
}
else
{
objFriendLinkEN.dicFldComparisonOp[conFriendLink.id_XzMajor] = strComparisonOp;
}
}
return objFriendLinkEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objFriendLinkEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsFriendLinkEN SetUpdDate(this clsFriendLinkEN objFriendLinkEN, string strUpdDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdDate, 20, conFriendLink.UpdDate);
objFriendLinkEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objFriendLinkEN.dicFldComparisonOp.ContainsKey(conFriendLink.UpdDate) == false)
{
objFriendLinkEN.dicFldComparisonOp.Add(conFriendLink.UpdDate, strComparisonOp);
}
else
{
objFriendLinkEN.dicFldComparisonOp[conFriendLink.UpdDate] = strComparisonOp;
}
}
return objFriendLinkEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objFriendLinkEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsFriendLinkEN SetUpdUserId(this clsFriendLinkEN objFriendLinkEN, string strUpdUserId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdUserId, 20, conFriendLink.UpdUserId);
objFriendLinkEN.UpdUserId = strUpdUserId; //修改用户Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objFriendLinkEN.dicFldComparisonOp.ContainsKey(conFriendLink.UpdUserId) == false)
{
objFriendLinkEN.dicFldComparisonOp.Add(conFriendLink.UpdUserId, strComparisonOp);
}
else
{
objFriendLinkEN.dicFldComparisonOp[conFriendLink.UpdUserId] = strComparisonOp;
}
}
return objFriendLinkEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objFriendLinkEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsFriendLinkEN SetMemo(this clsFriendLinkEN objFriendLinkEN, string strMemo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMemo, 1000, conFriendLink.Memo);
objFriendLinkEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objFriendLinkEN.dicFldComparisonOp.ContainsKey(conFriendLink.Memo) == false)
{
objFriendLinkEN.dicFldComparisonOp.Add(conFriendLink.Memo, strComparisonOp);
}
else
{
objFriendLinkEN.dicFldComparisonOp[conFriendLink.Memo] = strComparisonOp;
}
}
return objFriendLinkEN;
	}

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsFriendLinkEN objFriendLink_Cond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objFriendLink_Cond.IsUpdated(conFriendLink.FriendLinkId) == true)
{
string strComparisonOp_FriendLinkId = objFriendLink_Cond.dicFldComparisonOp[conFriendLink.FriendLinkId];
strWhereCond += string.Format(" And {0} {2} {1}", conFriendLink.FriendLinkId, objFriendLink_Cond.FriendLinkId, strComparisonOp_FriendLinkId);
}
if (objFriendLink_Cond.IsUpdated(conFriendLink.LinkCategoriesId) == true)
{
string strComparisonOp_LinkCategoriesId = objFriendLink_Cond.dicFldComparisonOp[conFriendLink.LinkCategoriesId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conFriendLink.LinkCategoriesId, objFriendLink_Cond.LinkCategoriesId, strComparisonOp_LinkCategoriesId);
}
if (objFriendLink_Cond.IsUpdated(conFriendLink.FriendLinkName) == true)
{
string strComparisonOp_FriendLinkName = objFriendLink_Cond.dicFldComparisonOp[conFriendLink.FriendLinkName];
strWhereCond += string.Format(" And {0} {2} '{1}'", conFriendLink.FriendLinkName, objFriendLink_Cond.FriendLinkName, strComparisonOp_FriendLinkName);
}
if (objFriendLink_Cond.IsUpdated(conFriendLink.FriendLinkUrl) == true)
{
string strComparisonOp_FriendLinkUrl = objFriendLink_Cond.dicFldComparisonOp[conFriendLink.FriendLinkUrl];
strWhereCond += string.Format(" And {0} {2} '{1}'", conFriendLink.FriendLinkUrl, objFriendLink_Cond.FriendLinkUrl, strComparisonOp_FriendLinkUrl);
}
if (objFriendLink_Cond.IsUpdated(conFriendLink.IsMark) == true)
{
if (objFriendLink_Cond.IsMark == true)
{
strWhereCond += string.Format(" And {0} = '1'", conFriendLink.IsMark);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conFriendLink.IsMark);
}
}
if (objFriendLink_Cond.IsUpdated(conFriendLink.ImageUrl) == true)
{
string strComparisonOp_ImageUrl = objFriendLink_Cond.dicFldComparisonOp[conFriendLink.ImageUrl];
strWhereCond += string.Format(" And {0} {2} '{1}'", conFriendLink.ImageUrl, objFriendLink_Cond.ImageUrl, strComparisonOp_ImageUrl);
}
if (objFriendLink_Cond.IsUpdated(conFriendLink.LinkTypeId) == true)
{
string strComparisonOp_LinkTypeId = objFriendLink_Cond.dicFldComparisonOp[conFriendLink.LinkTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conFriendLink.LinkTypeId, objFriendLink_Cond.LinkTypeId, strComparisonOp_LinkTypeId);
}
if (objFriendLink_Cond.IsUpdated(conFriendLink.id_XzMajor) == true)
{
string strComparisonOp_id_XzMajor = objFriendLink_Cond.dicFldComparisonOp[conFriendLink.id_XzMajor];
strWhereCond += string.Format(" And {0} {2} '{1}'", conFriendLink.id_XzMajor, objFriendLink_Cond.id_XzMajor, strComparisonOp_id_XzMajor);
}
if (objFriendLink_Cond.IsUpdated(conFriendLink.UpdDate) == true)
{
string strComparisonOp_UpdDate = objFriendLink_Cond.dicFldComparisonOp[conFriendLink.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conFriendLink.UpdDate, objFriendLink_Cond.UpdDate, strComparisonOp_UpdDate);
}
if (objFriendLink_Cond.IsUpdated(conFriendLink.UpdUserId) == true)
{
string strComparisonOp_UpdUserId = objFriendLink_Cond.dicFldComparisonOp[conFriendLink.UpdUserId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conFriendLink.UpdUserId, objFriendLink_Cond.UpdUserId, strComparisonOp_UpdUserId);
}
if (objFriendLink_Cond.IsUpdated(conFriendLink.Memo) == true)
{
string strComparisonOp_Memo = objFriendLink_Cond.dicFldComparisonOp[conFriendLink.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", conFriendLink.Memo, objFriendLink_Cond.Memo, strComparisonOp_Memo);
}
 return strWhereCond;
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_Update)
 /// </summary>
 /// <param name = "objFriendLinkEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsFriendLinkEN objFriendLinkEN)
{
 if (objFriendLinkEN.FriendLinkId == 0)
 {
string strMsg = string.Format("(errid:Watl000003)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
objFriendLinkEN.sf_UpdFldSetStr = objFriendLinkEN.getsf_UpdFldSetStr();
clsFriendLinkWApi.CheckPropertyNew(objFriendLinkEN); 
bool bolResult = clsFriendLinkWApi.UpdateRecord(objFriendLinkEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsFriendLinkWApi.ReFreshCache();
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
 /// 检查唯一性(Uniqueness)--FriendLink(友情链接), 如果不唯一,即存在相同的记录,就返回False
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_GetConditionString4Constraint)
 /// </summary>
 /// <param name = "objFriendLinkEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniConditionStr_FriendLinkName_LinkCategoriesId(this clsFriendLinkEN objFriendLinkEN)
{
//检测记录是否存在
StringBuilder sbCondition = new StringBuilder();
if (objFriendLinkEN == null) return "";
if (objFriendLinkEN.FriendLinkId == 0)
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and FriendLinkName = '{0}'", objFriendLinkEN.FriendLinkName);
 sbCondition.AppendFormat(" and LinkCategoriesId = '{0}'", objFriendLinkEN.LinkCategoriesId);
return sbCondition.ToString();
}
 else {
sbCondition.AppendFormat("FriendLinkId !=  {0}", objFriendLinkEN.FriendLinkId);
 sbCondition.AppendFormat(" and FriendLinkName = '{0}'", objFriendLinkEN.FriendLinkName);
 sbCondition.AppendFormat(" and LinkCategoriesId = '{0}'", objFriendLinkEN.LinkCategoriesId);
 return sbCondition.ToString();
}
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_AddNewRecord)
 /// </summary>
 /// <param name = "objFriendLinkEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clsFriendLinkEN objFriendLinkEN)
{
try
{
clsFriendLinkWApi.CheckPropertyNew(objFriendLinkEN); 
bool bolResult = clsFriendLinkWApi.AddNewRecord(objFriendLinkEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsFriendLinkWApi.ReFreshCache();
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
 /// <param name = "objFriendLinkEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsFriendLinkEN objFriendLinkEN, string strWhereCond)
{
try
{
clsFriendLinkWApi.CheckPropertyNew(objFriendLinkEN); 
bool bolResult = clsFriendLinkWApi.UpdateWithCondition(objFriendLinkEN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsFriendLinkWApi.ReFreshCache();
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
 /// 友情链接(FriendLink)
 /// (AutoGCLib.WA_Access4CSharp:GeneCode)
 /// </summary>
public class clsFriendLinkWApi
{
private static readonly string mstrApiControllerName = "FriendLinkApi";

 /// <summary>
/// 专门在逻辑层用于处理缓存等公共函数的对象
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_DefineObjCommFun4BL)
/// </summary>
public static clsCommFun4BL objCommFun4BL = null;

 public clsFriendLinkWApi()
 {
 }

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_CheckPropertyNew)
 /// </summary>
public static void CheckPropertyNew(clsFriendLinkEN objFriendLinkEN)
{
if (!Object.Equals(null, objFriendLinkEN.LinkCategoriesId) && GetStrLen(objFriendLinkEN.LinkCategoriesId) > 2)
{
 throw new Exception("字段[链接分类Id]的长度不能超过2!");
}
if (!Object.Equals(null, objFriendLinkEN.FriendLinkName) && GetStrLen(objFriendLinkEN.FriendLinkName) > 100)
{
 throw new Exception("字段[友情链接名]的长度不能超过100!");
}
if (!Object.Equals(null, objFriendLinkEN.FriendLinkUrl) && GetStrLen(objFriendLinkEN.FriendLinkUrl) > 500)
{
 throw new Exception("字段[友情链接地址]的长度不能超过500!");
}
if (!Object.Equals(null, objFriendLinkEN.ImageUrl) && GetStrLen(objFriendLinkEN.ImageUrl) > 50)
{
 throw new Exception("字段[ImageUrl]的长度不能超过50!");
}
if (!Object.Equals(null, objFriendLinkEN.LinkTypeId) && GetStrLen(objFriendLinkEN.LinkTypeId) > 4)
{
 throw new Exception("字段[LinkTypeId]的长度不能超过4!");
}
if (!Object.Equals(null, objFriendLinkEN.id_XzMajor) && GetStrLen(objFriendLinkEN.id_XzMajor) > 8)
{
 throw new Exception("字段[专业流水号]的长度不能超过8!");
}
if (!Object.Equals(null, objFriendLinkEN.UpdDate) && GetStrLen(objFriendLinkEN.UpdDate) > 20)
{
 throw new Exception("字段[修改日期]的长度不能超过20!");
}
if (!Object.Equals(null, objFriendLinkEN.UpdUserId) && GetStrLen(objFriendLinkEN.UpdUserId) > 20)
{
 throw new Exception("字段[修改用户Id]的长度不能超过20!");
}
if (!Object.Equals(null, objFriendLinkEN.Memo) && GetStrLen(objFriendLinkEN.Memo) > 1000)
{
 throw new Exception("字段[备注]的长度不能超过1000!");
}
 objFriendLinkEN._IsCheckProperty = true;
 }

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyId)
 /// </summary>
 /// <param name = "lngFriendLinkId">表关键字</param>
 /// <returns>表对象</returns>
public static clsFriendLinkEN GetObjByFriendLinkId(long lngFriendLinkId)
{
string strAction = "GetObjByFriendLinkId";
string strErrMsg = string.Empty;
string strResult = "";
clsFriendLinkEN objFriendLinkEN = null;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["FriendLinkId"] = lngFriendLinkId.ToString()
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
objFriendLinkEN = JsonConvert.DeserializeObject<clsFriendLinkEN>((string)jobjReturn["ReturnObj"]);
return objFriendLinkEN;
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
 /// <param name = "lngFriendLinkId">表关键字</param>
 /// <returns>表对象</returns>
public static clsFriendLinkEN GetObjByFriendLinkId_WA_Cache(long lngFriendLinkId)
{
string strAction = "GetObjByFriendLinkId_Cache";
string strErrMsg = string.Empty;
string strResult = "";
clsFriendLinkEN objFriendLinkEN = null;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["FriendLinkId"] = lngFriendLinkId.ToString()
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
objFriendLinkEN = JsonConvert.DeserializeObject<clsFriendLinkEN>((string)jobjReturn["ReturnObj"]);
return objFriendLinkEN;
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
public static clsFriendLinkEN GetFirstObj(string strWhereCond)
{
string strAction = "GetFirstObj";
string strErrMsg = string.Empty;
string strResult = "";
clsFriendLinkEN objFriendLinkEN = null;
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
objFriendLinkEN = JsonConvert.DeserializeObject<clsFriendLinkEN>((string)jobjReturn["ReturnObj"]);
return objFriendLinkEN;
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
 /// <param name = "lngFriendLinkId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsFriendLinkEN GetObjByFriendLinkId_Cache(long lngFriendLinkId)
{
//初始化列表缓存
string strKey = string.Format("{0}", clsFriendLinkEN._CurrTabName_S);
List<clsFriendLinkEN> arrFriendLinkObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsFriendLinkEN> arrFriendLinkObjLst_Sel =
from objFriendLinkEN in arrFriendLinkObjLst_Cache
where objFriendLinkEN.FriendLinkId == lngFriendLinkId
select objFriendLinkEN;
if (arrFriendLinkObjLst_Sel.Count() == 0)
{
   clsFriendLinkEN obj = clsFriendLinkWApi.GetObjByFriendLinkId(lngFriendLinkId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
     return obj;
 }
return null;
}
return arrFriendLinkObjLst_Sel.First();
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsFriendLinkEN> GetObjLst(string strWhereCond)
{
 List<clsFriendLinkEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsFriendLinkEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsFriendLinkEN> GetObjLstByFriendLinkIdLst(List<long> arrFriendLinkId)
{
 List<clsFriendLinkEN> arrObjLst = null; 
string strAction = "GetObjLstByFriendLinkIdLst";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrFriendLinkId);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
arrObjLst = JsonConvert.DeserializeObject<List<clsFriendLinkEN>>((string)jobjReturn["ReturnObjLst"]);
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
 /// <param name = "lngFriendLinkId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static IEnumerable<clsFriendLinkEN> GetObjLstByFriendLinkIdLst_Cache(List<long> arrFriendLinkId)
{
//初始化列表缓存
string strKey = string.Format("{0}", clsFriendLinkEN._CurrTabName_S);
List<clsFriendLinkEN> arrFriendLinkObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsFriendLinkEN> arrFriendLinkObjLst_Sel =
from objFriendLinkEN in arrFriendLinkObjLst_Cache
where arrFriendLinkId.Contains(objFriendLinkEN.FriendLinkId)
select objFriendLinkEN;
return arrFriendLinkObjLst_Sel;
}

 /// <summary>
 /// 根据关键字列表获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstByKeyLst_WA_Cache)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsFriendLinkEN> GetObjLstByFriendLinkIdLst_WA_Cache(List<long> arrFriendLinkId)
{
 List<clsFriendLinkEN> arrObjLst = null; 
string strAction = "GetObjLstByFriendLinkIdLst_Cache";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
};
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrFriendLinkId);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
arrObjLst = JsonConvert.DeserializeObject<List<clsFriendLinkEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsFriendLinkEN> GetTopObjLst(stuTopPara objTopPara)
{
 List<clsFriendLinkEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsFriendLinkEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsFriendLinkEN> GetObjLstByRange(stuRangePara objRangePara)
{
 List<clsFriendLinkEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsFriendLinkEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsFriendLinkEN> GetObjLstByPager(stuPagerPara objPagerPara)
{
 List<clsFriendLinkEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsFriendLinkEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsFriendLinkEN> GetObjLstByPager_Cache(stuPagerPara objPagerPara)
{
 List<clsFriendLinkEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsFriendLinkEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static int DelRecord(long lngFriendLinkId)
{
string strAction = "DelRecord";
string strErrMsg = string.Empty;
string strResult = "";
try
{
 clsFriendLinkEN objFriendLinkEN = clsFriendLinkWApi.GetObjByFriendLinkId(lngFriendLinkId);
if (clsPubFun4WApi.Delete(mstrApiControllerName, strAction, lngFriendLinkId.ToString(), out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
clsFriendLinkWApi.ReFreshCache();
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
public static int DelFriendLinks(List<string> arrFriendLinkId)
{
string strAction = "DelFriendLinks";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrFriendLinkId);
if (clsPubFun4WApi.Deletes(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
clsFriendLinkWApi.ReFreshCache();
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
public static int DelFriendLinksByCond(string strWhereCond)
{
string strAction = "DelFriendLinksByCond";
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
public static bool AddNewRecord(clsFriendLinkEN objFriendLinkEN)
{
string strAction = "AddNewRecord";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsFriendLinkEN>(objFriendLinkEN);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJson, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsFriendLinkWApi.ReFreshCache();
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
 /// <param name = "objFriendLinkEN">需要添加的表对象</param>
 /// <returns>返回新添加记录的关键字</returns>
public static string AddNewRecordWithReturnKey(clsFriendLinkEN objFriendLinkEN)
{
string strAction = "AddNewRecord";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsFriendLinkEN>(objFriendLinkEN);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJson, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsFriendLinkWApi.ReFreshCache();
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
public static bool UpdateRecord(clsFriendLinkEN objFriendLinkEN)
{
if (string.IsNullOrEmpty(objFriendLinkEN.sf_UpdFldSetStr) == true)
{
string strMsg = string.Format("修改时，修改标志串为空，请联系管理员.对象关键字:{0}.(from {1}).",
objFriendLinkEN.FriendLinkId, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
string strAction = "UpdateRecord";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsFriendLinkEN>(objFriendLinkEN);
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
 /// <param name = "objFriendLinkEN">需要修改的对象</param>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的关键字值</returns>
public static bool UpdateWithCondition(clsFriendLinkEN objFriendLinkEN, string strWhereCond)
{
if (string.IsNullOrEmpty(objFriendLinkEN.sf_UpdFldSetStr) == true)
{
string strMsg = string.Format("修改时，修改标志串为空，请联系管理员.对象关键字:{0}.(from {1}).",
objFriendLinkEN.FriendLinkId, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (string.IsNullOrEmpty(strWhereCond) == true)
{
string strMsg = string.Format("按条件修改时，条件串为空，请联系管理员.对象关键字:{0}.(from {1}).",
objFriendLinkEN.FriendLinkId, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
string strAction = "UpdateWithCondition";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsFriendLinkEN>(objFriendLinkEN);
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
public static bool IsExist(long lngFriendLinkId)
{
//检测记录是否存在
string strAction = "IsExist";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["FriendLinkId"] = lngFriendLinkId.ToString()
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
 /// <param name = "objFriendLinkENS">源对象</param>
 /// <param name = "objFriendLinkENT">目标对象</param>
 public static void CopyTo(clsFriendLinkEN objFriendLinkENS, clsFriendLinkEN objFriendLinkENT)
{
try
{
objFriendLinkENT.FriendLinkId = objFriendLinkENS.FriendLinkId; //友情链接Id
objFriendLinkENT.LinkCategoriesId = objFriendLinkENS.LinkCategoriesId; //链接分类Id
objFriendLinkENT.FriendLinkName = objFriendLinkENS.FriendLinkName; //友情链接名
objFriendLinkENT.FriendLinkUrl = objFriendLinkENS.FriendLinkUrl; //友情链接地址
objFriendLinkENT.IsMark = objFriendLinkENS.IsMark; //是否启用
objFriendLinkENT.ImageUrl = objFriendLinkENS.ImageUrl; //ImageUrl
objFriendLinkENT.LinkTypeId = objFriendLinkENS.LinkTypeId; //LinkTypeId
objFriendLinkENT.id_XzMajor = objFriendLinkENS.id_XzMajor; //专业流水号
objFriendLinkENT.UpdDate = objFriendLinkENS.UpdDate; //修改日期
objFriendLinkENT.UpdUserId = objFriendLinkENS.UpdUserId; //修改用户Id
objFriendLinkENT.Memo = objFriendLinkENS.Memo; //备注
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
public static DataTable ToDataTable(List<clsFriendLinkEN> arrObj)
{
DataTable dataTable = new DataTable(); //实例化
DataTable result;
if (arrObj.Count == 0) return null;
if (clsFriendLinkEN.AttributeName.Length == 0)
{
result = dataTable;
return result;
}
Type type = typeof(clsFriendLinkEN);
PropertyInfo[] arrPropertyInfo = type.GetProperties();
try
{
//Columns
foreach (string strAttrName in clsFriendLinkEN.AttributeName)
{
PropertyInfo proprety_Curr = arrPropertyInfo.Where(x => x.Name == strAttrName).First();
dataTable.Columns.Add(strAttrName, proprety_Curr.PropertyType);
}
foreach (clsFriendLinkEN objInFor in arrObj)
{
//Rows
DataRow dataRow = dataTable.NewRow();
foreach (string strAttrName in clsFriendLinkEN.AttributeName)
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
if (clsFriendLinkWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsFriendLinkWApi没有刷新缓存机制(clsFriendLinkWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by FriendLinkId");
//if (arrFriendLinkObjLst_Cache == null)
//{
//arrFriendLinkObjLst_Cache = await clsFriendLinkWApi.GetObjLst(strWhereCond);
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
string strKey = string.Format("{0}", clsFriendLinkEN._CurrTabName_S);
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
if (clsFriendLinkWApi.objCommFun4BL != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}", clsFriendLinkEN._CurrTabName_S);
CacheHelper.Remove(strKey);
clsFriendLinkWApi.objCommFun4BL.ReFreshCache();
}
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst_Cache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsFriendLinkEN> GetObjLst_Cache()
{
//初始化列表缓存
InitListCache(); 
string strKey = string.Format("{0}", clsFriendLinkEN._CurrTabName_S);
List<clsFriendLinkEN> arrFriendLinkObjLst_Cache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrFriendLinkObjLst_Cache;
}

 /// <summary>
 /// 根据对象列表获取DataTable
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetDataTableByObjLst)
 /// </summary>
 /// <param name = "arrObjLst">给定的对象列表</param>
 /// <returns>返回DataTable</returns>
public static DataTable GetDataTableByObjLst(List<clsFriendLinkEN> arrObjLst)
{
DataTable objDT = new DataTable();
objDT.Columns.Add(conFriendLink.FriendLinkId, Type.GetType("System.Int64"));
objDT.Columns.Add(conFriendLink.LinkCategoriesId, Type.GetType("System.String"));
objDT.Columns.Add(conFriendLink.FriendLinkName, Type.GetType("System.String"));
objDT.Columns.Add(conFriendLink.FriendLinkUrl, Type.GetType("System.String"));
objDT.Columns.Add(conFriendLink.IsMark, Type.GetType("System.Boolean"));
objDT.Columns.Add(conFriendLink.ImageUrl, Type.GetType("System.String"));
objDT.Columns.Add(conFriendLink.LinkTypeId, Type.GetType("System.String"));
objDT.Columns.Add(conFriendLink.id_XzMajor, Type.GetType("System.String"));
objDT.Columns.Add(conFriendLink.UpdDate, Type.GetType("System.String"));
objDT.Columns.Add(conFriendLink.UpdUserId, Type.GetType("System.String"));
objDT.Columns.Add(conFriendLink.Memo, Type.GetType("System.String"));
foreach (clsFriendLinkEN objInFor in arrObjLst)
{
DataRow objDR = objDT.NewRow();
objDR[conFriendLink.FriendLinkId] = objInFor[conFriendLink.FriendLinkId];
objDR[conFriendLink.LinkCategoriesId] = objInFor[conFriendLink.LinkCategoriesId];
objDR[conFriendLink.FriendLinkName] = objInFor[conFriendLink.FriendLinkName];
objDR[conFriendLink.FriendLinkUrl] = objInFor[conFriendLink.FriendLinkUrl];
objDR[conFriendLink.IsMark] = objInFor[conFriendLink.IsMark];
objDR[conFriendLink.ImageUrl] = objInFor[conFriendLink.ImageUrl];
objDR[conFriendLink.LinkTypeId] = objInFor[conFriendLink.LinkTypeId];
objDR[conFriendLink.id_XzMajor] = objInFor[conFriendLink.id_XzMajor];
objDR[conFriendLink.UpdDate] = objInFor[conFriendLink.UpdDate];
objDR[conFriendLink.UpdUserId] = objInFor[conFriendLink.UpdUserId];
objDR[conFriendLink.Memo] = objInFor[conFriendLink.Memo];
objDT.Rows.Add(objDR);
}
return objDT;
}
}
 /// <summary>
 /// 友情链接(FriendLink)
 /// 数据源类型:SQL表
 /// (AutoGCLib.CommFun4WA4CSharp:GeneCode_This)
 /// </summary>
public class clsCommFun4WA4FriendLink : clsCommFun4BL
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
clsFriendLinkWApi.ReFreshThisCache();
}
}

}