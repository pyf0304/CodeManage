
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsGroupPicRelationWApi
 表名:GroupPicRelation(01120036)
 生成代码版本:2021.09.20.1
 生成日期:2021/09/21 02:47:22
 生成者:pyf
 生成服务器IP:103.116.76.183
 工程名称:问卷调查
 工程ID:0112
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:系统设置
 模块英文名:SystemSet
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
public static class clsGroupPicRelationWApi_Static
{

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objGroupPicRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsGroupPicRelationEN SetRelationshipId(this clsGroupPicRelationEN objGroupPicRelationEN, int intRelationshipId, string strComparisonOp="")
	{
objGroupPicRelationEN.RelationshipId = intRelationshipId; //RelationshipId
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objGroupPicRelationEN.dicFldComparisonOp.ContainsKey(conGroupPicRelation.RelationshipId) == false)
{
objGroupPicRelationEN.dicFldComparisonOp.Add(conGroupPicRelation.RelationshipId, strComparisonOp);
}
else
{
objGroupPicRelationEN.dicFldComparisonOp[conGroupPicRelation.RelationshipId] = strComparisonOp;
}
}
return objGroupPicRelationEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objGroupPicRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsGroupPicRelationEN SetGroupId(this clsGroupPicRelationEN objGroupPicRelationEN, string strGroupId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strGroupId, 8, conGroupPicRelation.GroupId);
clsCheckSql.CheckFieldForeignKey(strGroupId, 8, conGroupPicRelation.GroupId);
objGroupPicRelationEN.GroupId = strGroupId; //组Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objGroupPicRelationEN.dicFldComparisonOp.ContainsKey(conGroupPicRelation.GroupId) == false)
{
objGroupPicRelationEN.dicFldComparisonOp.Add(conGroupPicRelation.GroupId, strComparisonOp);
}
else
{
objGroupPicRelationEN.dicFldComparisonOp[conGroupPicRelation.GroupId] = strComparisonOp;
}
}
return objGroupPicRelationEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objGroupPicRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsGroupPicRelationEN SetPictureId(this clsGroupPicRelationEN objGroupPicRelationEN, int intPictureId, string strComparisonOp="")
	{
objGroupPicRelationEN.PictureId = intPictureId; //PictureId
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objGroupPicRelationEN.dicFldComparisonOp.ContainsKey(conGroupPicRelation.PictureId) == false)
{
objGroupPicRelationEN.dicFldComparisonOp.Add(conGroupPicRelation.PictureId, strComparisonOp);
}
else
{
objGroupPicRelationEN.dicFldComparisonOp[conGroupPicRelation.PictureId] = strComparisonOp;
}
}
return objGroupPicRelationEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objGroupPicRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsGroupPicRelationEN SetCreateTime(this clsGroupPicRelationEN objGroupPicRelationEN, string strCreateTime, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCreateTime, 16, conGroupPicRelation.CreateTime);
objGroupPicRelationEN.CreateTime = strCreateTime; //建立时间
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objGroupPicRelationEN.dicFldComparisonOp.ContainsKey(conGroupPicRelation.CreateTime) == false)
{
objGroupPicRelationEN.dicFldComparisonOp.Add(conGroupPicRelation.CreateTime, strComparisonOp);
}
else
{
objGroupPicRelationEN.dicFldComparisonOp[conGroupPicRelation.CreateTime] = strComparisonOp;
}
}
return objGroupPicRelationEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objGroupPicRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsGroupPicRelationEN SetCreateUserID(this clsGroupPicRelationEN objGroupPicRelationEN, string strCreateUserID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCreateUserID, 20, conGroupPicRelation.CreateUserID);
objGroupPicRelationEN.CreateUserID = strCreateUserID; //建立用户ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objGroupPicRelationEN.dicFldComparisonOp.ContainsKey(conGroupPicRelation.CreateUserID) == false)
{
objGroupPicRelationEN.dicFldComparisonOp.Add(conGroupPicRelation.CreateUserID, strComparisonOp);
}
else
{
objGroupPicRelationEN.dicFldComparisonOp[conGroupPicRelation.CreateUserID] = strComparisonOp;
}
}
return objGroupPicRelationEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objGroupPicRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsGroupPicRelationEN SetLastModifyUserID(this clsGroupPicRelationEN objGroupPicRelationEN, string strLastModifyUserID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strLastModifyUserID, 20, conGroupPicRelation.LastModifyUserID);
objGroupPicRelationEN.LastModifyUserID = strLastModifyUserID; //最后修改用户ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objGroupPicRelationEN.dicFldComparisonOp.ContainsKey(conGroupPicRelation.LastModifyUserID) == false)
{
objGroupPicRelationEN.dicFldComparisonOp.Add(conGroupPicRelation.LastModifyUserID, strComparisonOp);
}
else
{
objGroupPicRelationEN.dicFldComparisonOp[conGroupPicRelation.LastModifyUserID] = strComparisonOp;
}
}
return objGroupPicRelationEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objGroupPicRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsGroupPicRelationEN SetLastModifyTime(this clsGroupPicRelationEN objGroupPicRelationEN, string strLastModifyTime, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strLastModifyTime, 16, conGroupPicRelation.LastModifyTime);
objGroupPicRelationEN.LastModifyTime = strLastModifyTime; //最后修改时间
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objGroupPicRelationEN.dicFldComparisonOp.ContainsKey(conGroupPicRelation.LastModifyTime) == false)
{
objGroupPicRelationEN.dicFldComparisonOp.Add(conGroupPicRelation.LastModifyTime, strComparisonOp);
}
else
{
objGroupPicRelationEN.dicFldComparisonOp[conGroupPicRelation.LastModifyTime] = strComparisonOp;
}
}
return objGroupPicRelationEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objGroupPicRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsGroupPicRelationEN SetPictureConfigerId(this clsGroupPicRelationEN objGroupPicRelationEN, string strPictureConfigerId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strPictureConfigerId, 4, conGroupPicRelation.PictureConfigerId);
clsCheckSql.CheckFieldForeignKey(strPictureConfigerId, 4, conGroupPicRelation.PictureConfigerId);
objGroupPicRelationEN.PictureConfigerId = strPictureConfigerId; //PictureConfigerId
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objGroupPicRelationEN.dicFldComparisonOp.ContainsKey(conGroupPicRelation.PictureConfigerId) == false)
{
objGroupPicRelationEN.dicFldComparisonOp.Add(conGroupPicRelation.PictureConfigerId, strComparisonOp);
}
else
{
objGroupPicRelationEN.dicFldComparisonOp[conGroupPicRelation.PictureConfigerId] = strComparisonOp;
}
}
return objGroupPicRelationEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objGroupPicRelationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsGroupPicRelationEN SetMemo(this clsGroupPicRelationEN objGroupPicRelationEN, string strMemo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMemo, 1000, conGroupPicRelation.Memo);
objGroupPicRelationEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objGroupPicRelationEN.dicFldComparisonOp.ContainsKey(conGroupPicRelation.Memo) == false)
{
objGroupPicRelationEN.dicFldComparisonOp.Add(conGroupPicRelation.Memo, strComparisonOp);
}
else
{
objGroupPicRelationEN.dicFldComparisonOp[conGroupPicRelation.Memo] = strComparisonOp;
}
}
return objGroupPicRelationEN;
	}

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsGroupPicRelationEN objGroupPicRelation_Cond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objGroupPicRelation_Cond.IsUpdated(conGroupPicRelation.RelationshipId) == true)
{
string strComparisonOp_RelationshipId = objGroupPicRelation_Cond.dicFldComparisonOp[conGroupPicRelation.RelationshipId];
strWhereCond += string.Format(" And {0} {2} {1}", conGroupPicRelation.RelationshipId, objGroupPicRelation_Cond.RelationshipId, strComparisonOp_RelationshipId);
}
if (objGroupPicRelation_Cond.IsUpdated(conGroupPicRelation.GroupId) == true)
{
string strComparisonOp_GroupId = objGroupPicRelation_Cond.dicFldComparisonOp[conGroupPicRelation.GroupId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conGroupPicRelation.GroupId, objGroupPicRelation_Cond.GroupId, strComparisonOp_GroupId);
}
if (objGroupPicRelation_Cond.IsUpdated(conGroupPicRelation.PictureId) == true)
{
string strComparisonOp_PictureId = objGroupPicRelation_Cond.dicFldComparisonOp[conGroupPicRelation.PictureId];
strWhereCond += string.Format(" And {0} {2} {1}", conGroupPicRelation.PictureId, objGroupPicRelation_Cond.PictureId, strComparisonOp_PictureId);
}
if (objGroupPicRelation_Cond.IsUpdated(conGroupPicRelation.CreateTime) == true)
{
string strComparisonOp_CreateTime = objGroupPicRelation_Cond.dicFldComparisonOp[conGroupPicRelation.CreateTime];
strWhereCond += string.Format(" And {0} {2} '{1}'", conGroupPicRelation.CreateTime, objGroupPicRelation_Cond.CreateTime, strComparisonOp_CreateTime);
}
if (objGroupPicRelation_Cond.IsUpdated(conGroupPicRelation.CreateUserID) == true)
{
string strComparisonOp_CreateUserID = objGroupPicRelation_Cond.dicFldComparisonOp[conGroupPicRelation.CreateUserID];
strWhereCond += string.Format(" And {0} {2} '{1}'", conGroupPicRelation.CreateUserID, objGroupPicRelation_Cond.CreateUserID, strComparisonOp_CreateUserID);
}
if (objGroupPicRelation_Cond.IsUpdated(conGroupPicRelation.LastModifyUserID) == true)
{
string strComparisonOp_LastModifyUserID = objGroupPicRelation_Cond.dicFldComparisonOp[conGroupPicRelation.LastModifyUserID];
strWhereCond += string.Format(" And {0} {2} '{1}'", conGroupPicRelation.LastModifyUserID, objGroupPicRelation_Cond.LastModifyUserID, strComparisonOp_LastModifyUserID);
}
if (objGroupPicRelation_Cond.IsUpdated(conGroupPicRelation.LastModifyTime) == true)
{
string strComparisonOp_LastModifyTime = objGroupPicRelation_Cond.dicFldComparisonOp[conGroupPicRelation.LastModifyTime];
strWhereCond += string.Format(" And {0} {2} '{1}'", conGroupPicRelation.LastModifyTime, objGroupPicRelation_Cond.LastModifyTime, strComparisonOp_LastModifyTime);
}
if (objGroupPicRelation_Cond.IsUpdated(conGroupPicRelation.PictureConfigerId) == true)
{
string strComparisonOp_PictureConfigerId = objGroupPicRelation_Cond.dicFldComparisonOp[conGroupPicRelation.PictureConfigerId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conGroupPicRelation.PictureConfigerId, objGroupPicRelation_Cond.PictureConfigerId, strComparisonOp_PictureConfigerId);
}
if (objGroupPicRelation_Cond.IsUpdated(conGroupPicRelation.Memo) == true)
{
string strComparisonOp_Memo = objGroupPicRelation_Cond.dicFldComparisonOp[conGroupPicRelation.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", conGroupPicRelation.Memo, objGroupPicRelation_Cond.Memo, strComparisonOp_Memo);
}
 return strWhereCond;
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_Update)
 /// </summary>
 /// <param name = "objGroupPicRelationEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsGroupPicRelationEN objGroupPicRelationEN)
{
 if (objGroupPicRelationEN.RelationshipId == 0)
 {
string strMsg = string.Format("(errid:Watl000003)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
objGroupPicRelationEN.sf_UpdFldSetStr = objGroupPicRelationEN.getsf_UpdFldSetStr();
clsGroupPicRelationWApi.CheckPropertyNew(objGroupPicRelationEN); 
bool bolResult = clsGroupPicRelationWApi.UpdateRecord(objGroupPicRelationEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsGroupPicRelationWApi.ReFreshCache();
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
 /// 检查唯一性(Uniqueness)--GroupPicRelation(用户组图片关系), 如果不唯一,即存在相同的记录,就返回False
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_GetConditionString4Constraint)
 /// </summary>
 /// <param name = "objGroupPicRelationEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniConditionStr_GroupId_PictureId(this clsGroupPicRelationEN objGroupPicRelationEN)
{
//检测记录是否存在
StringBuilder sbCondition = new StringBuilder();
if (objGroupPicRelationEN == null) return "";
if (objGroupPicRelationEN.RelationshipId == 0)
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and GroupId = '{0}'", objGroupPicRelationEN.GroupId);
 sbCondition.AppendFormat(" and PictureId = '{0}'", objGroupPicRelationEN.PictureId);
return sbCondition.ToString();
}
 else {
sbCondition.AppendFormat("RelationshipId !=  {0}", objGroupPicRelationEN.RelationshipId);
 sbCondition.AppendFormat(" and GroupId = '{0}'", objGroupPicRelationEN.GroupId);
 sbCondition.AppendFormat(" and PictureId = '{0}'", objGroupPicRelationEN.PictureId);
 return sbCondition.ToString();
}
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_AddNewRecord)
 /// </summary>
 /// <param name = "objGroupPicRelationEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clsGroupPicRelationEN objGroupPicRelationEN)
{
try
{
clsGroupPicRelationWApi.CheckPropertyNew(objGroupPicRelationEN); 
bool bolResult = clsGroupPicRelationWApi.AddNewRecord(objGroupPicRelationEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsGroupPicRelationWApi.ReFreshCache();
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
 /// <param name = "objGroupPicRelationEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsGroupPicRelationEN objGroupPicRelationEN, string strWhereCond)
{
try
{
clsGroupPicRelationWApi.CheckPropertyNew(objGroupPicRelationEN); 
bool bolResult = clsGroupPicRelationWApi.UpdateWithCondition(objGroupPicRelationEN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsGroupPicRelationWApi.ReFreshCache();
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
 /// 用户组图片关系(GroupPicRelation)
 /// (AutoGCLib.WA_Access4CSharp:GeneCode)
 /// </summary>
public class clsGroupPicRelationWApi
{
private static readonly string mstrApiControllerName = "GroupPicRelationApi";

 /// <summary>
/// 专门在逻辑层用于处理缓存等公共函数的对象
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_DefineObjCommFun4BL)
/// </summary>
public static clsCommFun4BL objCommFun4BL = null;

 public clsGroupPicRelationWApi()
 {
 }

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_CheckPropertyNew)
 /// </summary>
public static void CheckPropertyNew(clsGroupPicRelationEN objGroupPicRelationEN)
{
if (!Object.Equals(null, objGroupPicRelationEN.GroupId) && GetStrLen(objGroupPicRelationEN.GroupId) > 8)
{
 throw new Exception("字段[组Id]的长度不能超过8!");
}
if (!Object.Equals(null, objGroupPicRelationEN.CreateTime) && GetStrLen(objGroupPicRelationEN.CreateTime) > 16)
{
 throw new Exception("字段[建立时间]的长度不能超过16!");
}
if (!Object.Equals(null, objGroupPicRelationEN.CreateUserID) && GetStrLen(objGroupPicRelationEN.CreateUserID) > 20)
{
 throw new Exception("字段[建立用户ID]的长度不能超过20!");
}
if (!Object.Equals(null, objGroupPicRelationEN.LastModifyUserID) && GetStrLen(objGroupPicRelationEN.LastModifyUserID) > 20)
{
 throw new Exception("字段[最后修改用户ID]的长度不能超过20!");
}
if (!Object.Equals(null, objGroupPicRelationEN.LastModifyTime) && GetStrLen(objGroupPicRelationEN.LastModifyTime) > 16)
{
 throw new Exception("字段[最后修改时间]的长度不能超过16!");
}
if (!Object.Equals(null, objGroupPicRelationEN.PictureConfigerId) && GetStrLen(objGroupPicRelationEN.PictureConfigerId) > 4)
{
 throw new Exception("字段[PictureConfigerId]的长度不能超过4!");
}
if (!Object.Equals(null, objGroupPicRelationEN.Memo) && GetStrLen(objGroupPicRelationEN.Memo) > 1000)
{
 throw new Exception("字段[备注]的长度不能超过1000!");
}
 objGroupPicRelationEN._IsCheckProperty = true;
 }

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyId)
 /// </summary>
 /// <param name = "intRelationshipId">表关键字</param>
 /// <returns>表对象</returns>
public static clsGroupPicRelationEN GetObjByRelationshipId(int intRelationshipId)
{
string strAction = "GetObjByRelationshipId";
string strErrMsg = string.Empty;
string strResult = "";
clsGroupPicRelationEN objGroupPicRelationEN = null;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["RelationshipId"] = intRelationshipId.ToString()
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
objGroupPicRelationEN = JsonConvert.DeserializeObject<clsGroupPicRelationEN>((string)jobjReturn["ReturnObj"]);
return objGroupPicRelationEN;
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
 /// <param name = "intRelationshipId">表关键字</param>
 /// <returns>表对象</returns>
public static clsGroupPicRelationEN GetObjByRelationshipId_WA_Cache(int intRelationshipId)
{
string strAction = "GetObjByRelationshipId_Cache";
string strErrMsg = string.Empty;
string strResult = "";
clsGroupPicRelationEN objGroupPicRelationEN = null;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["RelationshipId"] = intRelationshipId.ToString()
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
objGroupPicRelationEN = JsonConvert.DeserializeObject<clsGroupPicRelationEN>((string)jobjReturn["ReturnObj"]);
return objGroupPicRelationEN;
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
public static int GetFirstID(string strWhereCond)
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
return int.Parse(strReturnStr);
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
public static clsGroupPicRelationEN GetFirstObj(string strWhereCond)
{
string strAction = "GetFirstObj";
string strErrMsg = string.Empty;
string strResult = "";
clsGroupPicRelationEN objGroupPicRelationEN = null;
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
objGroupPicRelationEN = JsonConvert.DeserializeObject<clsGroupPicRelationEN>((string)jobjReturn["ReturnObj"]);
return objGroupPicRelationEN;
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
 /// <param name = "intRelationshipId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsGroupPicRelationEN GetObjByRelationshipId_Cache(int intRelationshipId)
{
//初始化列表缓存
string strKey = string.Format("{0}", clsGroupPicRelationEN._CurrTabName_S);
List<clsGroupPicRelationEN> arrGroupPicRelationObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsGroupPicRelationEN> arrGroupPicRelationObjLst_Sel =
from objGroupPicRelationEN in arrGroupPicRelationObjLst_Cache
where objGroupPicRelationEN.RelationshipId == intRelationshipId
select objGroupPicRelationEN;
if (arrGroupPicRelationObjLst_Sel.Count() == 0)
{
   clsGroupPicRelationEN obj = clsGroupPicRelationWApi.GetObjByRelationshipId(intRelationshipId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
     return obj;
 }
return null;
}
return arrGroupPicRelationObjLst_Sel.First();
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsGroupPicRelationEN> GetObjLst(string strWhereCond)
{
 List<clsGroupPicRelationEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsGroupPicRelationEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsGroupPicRelationEN> GetObjLstByRelationshipIdLst(List<int> arrRelationshipId)
{
 List<clsGroupPicRelationEN> arrObjLst = null; 
string strAction = "GetObjLstByRelationshipIdLst";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrRelationshipId);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
arrObjLst = JsonConvert.DeserializeObject<List<clsGroupPicRelationEN>>((string)jobjReturn["ReturnObjLst"]);
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
 /// <param name = "intRelationshipId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static IEnumerable<clsGroupPicRelationEN> GetObjLstByRelationshipIdLst_Cache(List<int> arrRelationshipId)
{
//初始化列表缓存
string strKey = string.Format("{0}", clsGroupPicRelationEN._CurrTabName_S);
List<clsGroupPicRelationEN> arrGroupPicRelationObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsGroupPicRelationEN> arrGroupPicRelationObjLst_Sel =
from objGroupPicRelationEN in arrGroupPicRelationObjLst_Cache
where arrRelationshipId.Contains(objGroupPicRelationEN.RelationshipId)
select objGroupPicRelationEN;
return arrGroupPicRelationObjLst_Sel;
}

 /// <summary>
 /// 根据关键字列表获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstByKeyLst_WA_Cache)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsGroupPicRelationEN> GetObjLstByRelationshipIdLst_WA_Cache(List<int> arrRelationshipId)
{
 List<clsGroupPicRelationEN> arrObjLst = null; 
string strAction = "GetObjLstByRelationshipIdLst_Cache";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
};
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrRelationshipId);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
arrObjLst = JsonConvert.DeserializeObject<List<clsGroupPicRelationEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsGroupPicRelationEN> GetTopObjLst(stuTopPara objTopPara)
{
 List<clsGroupPicRelationEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsGroupPicRelationEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsGroupPicRelationEN> GetObjLstByRange(stuRangePara objRangePara)
{
 List<clsGroupPicRelationEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsGroupPicRelationEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsGroupPicRelationEN> GetObjLstByPager(stuPagerPara objPagerPara)
{
 List<clsGroupPicRelationEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsGroupPicRelationEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsGroupPicRelationEN> GetObjLstByPager_Cache(stuPagerPara objPagerPara)
{
 List<clsGroupPicRelationEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsGroupPicRelationEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static int DelRecord(int intRelationshipId)
{
string strAction = "DelRecord";
string strErrMsg = string.Empty;
string strResult = "";
try
{
 clsGroupPicRelationEN objGroupPicRelationEN = clsGroupPicRelationWApi.GetObjByRelationshipId(intRelationshipId);
if (clsPubFun4WApi.Delete(mstrApiControllerName, strAction, intRelationshipId.ToString(), out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
clsGroupPicRelationWApi.ReFreshCache();
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
public static int DelGroupPicRelations(List<string> arrRelationshipId)
{
string strAction = "DelGroupPicRelations";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrRelationshipId);
if (clsPubFun4WApi.Deletes(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
clsGroupPicRelationWApi.ReFreshCache();
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
public static int DelGroupPicRelationsByCond(string strWhereCond)
{
string strAction = "DelGroupPicRelationsByCond";
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
public static bool AddNewRecord(clsGroupPicRelationEN objGroupPicRelationEN)
{
string strAction = "AddNewRecord";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsGroupPicRelationEN>(objGroupPicRelationEN);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJson, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsGroupPicRelationWApi.ReFreshCache();
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
 /// <param name = "objGroupPicRelationEN">需要添加的表对象</param>
 /// <returns>返回新添加记录的关键字</returns>
public static string AddNewRecordWithReturnKey(clsGroupPicRelationEN objGroupPicRelationEN)
{
string strAction = "AddNewRecord";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsGroupPicRelationEN>(objGroupPicRelationEN);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJson, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsGroupPicRelationWApi.ReFreshCache();
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
public static bool UpdateRecord(clsGroupPicRelationEN objGroupPicRelationEN)
{
if (string.IsNullOrEmpty(objGroupPicRelationEN.sf_UpdFldSetStr) == true)
{
string strMsg = string.Format("修改时，修改标志串为空，请联系管理员.对象关键字:{0}.(from {1}).",
objGroupPicRelationEN.RelationshipId, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
string strAction = "UpdateRecord";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsGroupPicRelationEN>(objGroupPicRelationEN);
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
 /// <param name = "objGroupPicRelationEN">需要修改的对象</param>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的关键字值</returns>
public static bool UpdateWithCondition(clsGroupPicRelationEN objGroupPicRelationEN, string strWhereCond)
{
if (string.IsNullOrEmpty(objGroupPicRelationEN.sf_UpdFldSetStr) == true)
{
string strMsg = string.Format("修改时，修改标志串为空，请联系管理员.对象关键字:{0}.(from {1}).",
objGroupPicRelationEN.RelationshipId, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (string.IsNullOrEmpty(strWhereCond) == true)
{
string strMsg = string.Format("按条件修改时，条件串为空，请联系管理员.对象关键字:{0}.(from {1}).",
objGroupPicRelationEN.RelationshipId, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
string strAction = "UpdateWithCondition";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsGroupPicRelationEN>(objGroupPicRelationEN);
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
public static bool IsExist(int intRelationshipId)
{
//检测记录是否存在
string strAction = "IsExist";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["RelationshipId"] = intRelationshipId.ToString()
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
 /// <param name = "objGroupPicRelationENS">源对象</param>
 /// <param name = "objGroupPicRelationENT">目标对象</param>
 public static void CopyTo(clsGroupPicRelationEN objGroupPicRelationENS, clsGroupPicRelationEN objGroupPicRelationENT)
{
try
{
objGroupPicRelationENT.RelationshipId = objGroupPicRelationENS.RelationshipId; //RelationshipId
objGroupPicRelationENT.GroupId = objGroupPicRelationENS.GroupId; //组Id
objGroupPicRelationENT.PictureId = objGroupPicRelationENS.PictureId; //PictureId
objGroupPicRelationENT.CreateTime = objGroupPicRelationENS.CreateTime; //建立时间
objGroupPicRelationENT.CreateUserID = objGroupPicRelationENS.CreateUserID; //建立用户ID
objGroupPicRelationENT.LastModifyUserID = objGroupPicRelationENS.LastModifyUserID; //最后修改用户ID
objGroupPicRelationENT.LastModifyTime = objGroupPicRelationENS.LastModifyTime; //最后修改时间
objGroupPicRelationENT.PictureConfigerId = objGroupPicRelationENS.PictureConfigerId; //PictureConfigerId
objGroupPicRelationENT.Memo = objGroupPicRelationENS.Memo; //备注
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
public static DataTable ToDataTable(List<clsGroupPicRelationEN> arrObj)
{
DataTable dataTable = new DataTable(); //实例化
DataTable result;
if (arrObj.Count == 0) return null;
if (clsGroupPicRelationEN.AttributeName.Length == 0)
{
result = dataTable;
return result;
}
Type type = typeof(clsGroupPicRelationEN);
PropertyInfo[] arrPropertyInfo = type.GetProperties();
try
{
//Columns
foreach (string strAttrName in clsGroupPicRelationEN.AttributeName)
{
PropertyInfo proprety_Curr = arrPropertyInfo.Where(x => x.Name == strAttrName).First();
dataTable.Columns.Add(strAttrName, proprety_Curr.PropertyType);
}
foreach (clsGroupPicRelationEN objInFor in arrObj)
{
//Rows
DataRow dataRow = dataTable.NewRow();
foreach (string strAttrName in clsGroupPicRelationEN.AttributeName)
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
if (clsGroupPicRelationWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsGroupPicRelationWApi没有刷新缓存机制(clsGroupPicRelationWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by RelationshipId");
//if (arrGroupPicRelationObjLst_Cache == null)
//{
//arrGroupPicRelationObjLst_Cache = await clsGroupPicRelationWApi.GetObjLst(strWhereCond);
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
string strKey = string.Format("{0}", clsGroupPicRelationEN._CurrTabName_S);
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
if (clsGroupPicRelationWApi.objCommFun4BL != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}", clsGroupPicRelationEN._CurrTabName_S);
CacheHelper.Remove(strKey);
clsGroupPicRelationWApi.objCommFun4BL.ReFreshCache();
}
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst_Cache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsGroupPicRelationEN> GetObjLst_Cache()
{
//初始化列表缓存
InitListCache(); 
string strKey = string.Format("{0}", clsGroupPicRelationEN._CurrTabName_S);
List<clsGroupPicRelationEN> arrGroupPicRelationObjLst_Cache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrGroupPicRelationObjLst_Cache;
}

 /// <summary>
 /// 根据对象列表获取DataTable
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetDataTableByObjLst)
 /// </summary>
 /// <param name = "arrObjLst">给定的对象列表</param>
 /// <returns>返回DataTable</returns>
public static DataTable GetDataTableByObjLst(List<clsGroupPicRelationEN> arrObjLst)
{
DataTable objDT = new DataTable();
objDT.Columns.Add(conGroupPicRelation.RelationshipId, Type.GetType("System.Int32"));
objDT.Columns.Add(conGroupPicRelation.GroupId, Type.GetType("System.String"));
objDT.Columns.Add(conGroupPicRelation.PictureId, Type.GetType("System.Int32"));
objDT.Columns.Add(conGroupPicRelation.CreateTime, Type.GetType("System.String"));
objDT.Columns.Add(conGroupPicRelation.CreateUserID, Type.GetType("System.String"));
objDT.Columns.Add(conGroupPicRelation.LastModifyUserID, Type.GetType("System.String"));
objDT.Columns.Add(conGroupPicRelation.LastModifyTime, Type.GetType("System.String"));
objDT.Columns.Add(conGroupPicRelation.PictureConfigerId, Type.GetType("System.String"));
objDT.Columns.Add(conGroupPicRelation.Memo, Type.GetType("System.String"));
foreach (clsGroupPicRelationEN objInFor in arrObjLst)
{
DataRow objDR = objDT.NewRow();
objDR[conGroupPicRelation.RelationshipId] = objInFor[conGroupPicRelation.RelationshipId];
objDR[conGroupPicRelation.GroupId] = objInFor[conGroupPicRelation.GroupId];
objDR[conGroupPicRelation.PictureId] = objInFor[conGroupPicRelation.PictureId];
objDR[conGroupPicRelation.CreateTime] = objInFor[conGroupPicRelation.CreateTime];
objDR[conGroupPicRelation.CreateUserID] = objInFor[conGroupPicRelation.CreateUserID];
objDR[conGroupPicRelation.LastModifyUserID] = objInFor[conGroupPicRelation.LastModifyUserID];
objDR[conGroupPicRelation.LastModifyTime] = objInFor[conGroupPicRelation.LastModifyTime];
objDR[conGroupPicRelation.PictureConfigerId] = objInFor[conGroupPicRelation.PictureConfigerId];
objDR[conGroupPicRelation.Memo] = objInFor[conGroupPicRelation.Memo];
objDT.Rows.Add(objDR);
}
return objDT;
}
}
 /// <summary>
 /// 用户组图片关系(GroupPicRelation)
 /// 数据源类型:SQL表
 /// (AutoGCLib.CommFun4WA4CSharp:GeneCode_This)
 /// </summary>
public class clsCommFun4WA4GroupPicRelation : clsCommFun4BL
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
clsGroupPicRelationWApi.ReFreshThisCache();
clsvGroupPicRelationWApi.ReFreshThisCache();
}
}

}