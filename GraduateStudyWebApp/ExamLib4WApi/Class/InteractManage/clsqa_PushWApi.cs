
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsqa_PushWApi
 表名:qa_Push(01120640)
 生成代码版本:2021.09.20.1
 生成日期:2021/09/21 02:40:20
 生成者:pyf
 生成服务器IP:103.116.76.183
 工程名称:问卷调查
 工程ID:0112
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:互动管理
 模块英文名:InteractManage
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
public static class clsqa_PushWApi_Static
{

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objqa_PushEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsqa_PushEN SetPushId(this clsqa_PushEN objqa_PushEN, long lngPushId, string strComparisonOp="")
	{
objqa_PushEN.PushId = lngPushId; //推送d
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objqa_PushEN.dicFldComparisonOp.ContainsKey(conqa_Push.PushId) == false)
{
objqa_PushEN.dicFldComparisonOp.Add(conqa_Push.PushId, strComparisonOp);
}
else
{
objqa_PushEN.dicFldComparisonOp[conqa_Push.PushId] = strComparisonOp;
}
}
return objqa_PushEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objqa_PushEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsqa_PushEN SetQuestionsId(this clsqa_PushEN objqa_PushEN, string strQuestionsId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strQuestionsId, conqa_Push.QuestionsId);
clsCheckSql.CheckFieldLen(strQuestionsId, 8, conqa_Push.QuestionsId);
clsCheckSql.CheckFieldForeignKey(strQuestionsId, 8, conqa_Push.QuestionsId);
objqa_PushEN.QuestionsId = strQuestionsId; //提问Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objqa_PushEN.dicFldComparisonOp.ContainsKey(conqa_Push.QuestionsId) == false)
{
objqa_PushEN.dicFldComparisonOp.Add(conqa_Push.QuestionsId, strComparisonOp);
}
else
{
objqa_PushEN.dicFldComparisonOp[conqa_Push.QuestionsId] = strComparisonOp;
}
}
return objqa_PushEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objqa_PushEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsqa_PushEN SetReceiveUser(this clsqa_PushEN objqa_PushEN, string strReceiveUser, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strReceiveUser, 20, conqa_Push.ReceiveUser);
objqa_PushEN.ReceiveUser = strReceiveUser; //接收用户
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objqa_PushEN.dicFldComparisonOp.ContainsKey(conqa_Push.ReceiveUser) == false)
{
objqa_PushEN.dicFldComparisonOp.Add(conqa_Push.ReceiveUser, strComparisonOp);
}
else
{
objqa_PushEN.dicFldComparisonOp[conqa_Push.ReceiveUser] = strComparisonOp;
}
}
return objqa_PushEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objqa_PushEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsqa_PushEN SetReceiveDate(this clsqa_PushEN objqa_PushEN, string strReceiveDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strReceiveDate, 20, conqa_Push.ReceiveDate);
objqa_PushEN.ReceiveDate = strReceiveDate; //接收日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objqa_PushEN.dicFldComparisonOp.ContainsKey(conqa_Push.ReceiveDate) == false)
{
objqa_PushEN.dicFldComparisonOp.Add(conqa_Push.ReceiveDate, strComparisonOp);
}
else
{
objqa_PushEN.dicFldComparisonOp[conqa_Push.ReceiveDate] = strComparisonOp;
}
}
return objqa_PushEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objqa_PushEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsqa_PushEN SetIsReceive(this clsqa_PushEN objqa_PushEN, bool bolIsReceive, string strComparisonOp="")
	{
objqa_PushEN.IsReceive = bolIsReceive; //是否接收
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objqa_PushEN.dicFldComparisonOp.ContainsKey(conqa_Push.IsReceive) == false)
{
objqa_PushEN.dicFldComparisonOp.Add(conqa_Push.IsReceive, strComparisonOp);
}
else
{
objqa_PushEN.dicFldComparisonOp[conqa_Push.IsReceive] = strComparisonOp;
}
}
return objqa_PushEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objqa_PushEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsqa_PushEN SetUpdDate(this clsqa_PushEN objqa_PushEN, string strUpdDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdDate, 20, conqa_Push.UpdDate);
objqa_PushEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objqa_PushEN.dicFldComparisonOp.ContainsKey(conqa_Push.UpdDate) == false)
{
objqa_PushEN.dicFldComparisonOp.Add(conqa_Push.UpdDate, strComparisonOp);
}
else
{
objqa_PushEN.dicFldComparisonOp[conqa_Push.UpdDate] = strComparisonOp;
}
}
return objqa_PushEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objqa_PushEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsqa_PushEN SetMemo(this clsqa_PushEN objqa_PushEN, string strMemo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMemo, 1000, conqa_Push.Memo);
objqa_PushEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objqa_PushEN.dicFldComparisonOp.ContainsKey(conqa_Push.Memo) == false)
{
objqa_PushEN.dicFldComparisonOp.Add(conqa_Push.Memo, strComparisonOp);
}
else
{
objqa_PushEN.dicFldComparisonOp[conqa_Push.Memo] = strComparisonOp;
}
}
return objqa_PushEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objqa_PushEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsqa_PushEN Setid_CurrEduCls(this clsqa_PushEN objqa_PushEN, string strid_CurrEduCls, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_CurrEduCls, 8, conqa_Push.id_CurrEduCls);
clsCheckSql.CheckFieldForeignKey(strid_CurrEduCls, 8, conqa_Push.id_CurrEduCls);
objqa_PushEN.id_CurrEduCls = strid_CurrEduCls; //当前教学班流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objqa_PushEN.dicFldComparisonOp.ContainsKey(conqa_Push.id_CurrEduCls) == false)
{
objqa_PushEN.dicFldComparisonOp.Add(conqa_Push.id_CurrEduCls, strComparisonOp);
}
else
{
objqa_PushEN.dicFldComparisonOp[conqa_Push.id_CurrEduCls] = strComparisonOp;
}
}
return objqa_PushEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objqa_PushEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsqa_PushEN SetIsReply(this clsqa_PushEN objqa_PushEN, bool bolIsReply, string strComparisonOp="")
	{
objqa_PushEN.IsReply = bolIsReply; //是否回复
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objqa_PushEN.dicFldComparisonOp.ContainsKey(conqa_Push.IsReply) == false)
{
objqa_PushEN.dicFldComparisonOp.Add(conqa_Push.IsReply, strComparisonOp);
}
else
{
objqa_PushEN.dicFldComparisonOp[conqa_Push.IsReply] = strComparisonOp;
}
}
return objqa_PushEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objqa_PushEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsqa_PushEN SetIsRequestReply(this clsqa_PushEN objqa_PushEN, bool bolIsRequestReply, string strComparisonOp="")
	{
objqa_PushEN.IsRequestReply = bolIsRequestReply; //是否要求回复
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objqa_PushEN.dicFldComparisonOp.ContainsKey(conqa_Push.IsRequestReply) == false)
{
objqa_PushEN.dicFldComparisonOp.Add(conqa_Push.IsRequestReply, strComparisonOp);
}
else
{
objqa_PushEN.dicFldComparisonOp[conqa_Push.IsRequestReply] = strComparisonOp;
}
}
return objqa_PushEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objqa_PushEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsqa_PushEN SetReplyDate(this clsqa_PushEN objqa_PushEN, string strReplyDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strReplyDate, 20, conqa_Push.ReplyDate);
objqa_PushEN.ReplyDate = strReplyDate; //回复日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objqa_PushEN.dicFldComparisonOp.ContainsKey(conqa_Push.ReplyDate) == false)
{
objqa_PushEN.dicFldComparisonOp.Add(conqa_Push.ReplyDate, strComparisonOp);
}
else
{
objqa_PushEN.dicFldComparisonOp[conqa_Push.ReplyDate] = strComparisonOp;
}
}
return objqa_PushEN;
	}

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsqa_PushEN objqa_Push_Cond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objqa_Push_Cond.IsUpdated(conqa_Push.PushId) == true)
{
string strComparisonOp_PushId = objqa_Push_Cond.dicFldComparisonOp[conqa_Push.PushId];
strWhereCond += string.Format(" And {0} {2} {1}", conqa_Push.PushId, objqa_Push_Cond.PushId, strComparisonOp_PushId);
}
if (objqa_Push_Cond.IsUpdated(conqa_Push.QuestionsId) == true)
{
string strComparisonOp_QuestionsId = objqa_Push_Cond.dicFldComparisonOp[conqa_Push.QuestionsId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conqa_Push.QuestionsId, objqa_Push_Cond.QuestionsId, strComparisonOp_QuestionsId);
}
if (objqa_Push_Cond.IsUpdated(conqa_Push.ReceiveUser) == true)
{
string strComparisonOp_ReceiveUser = objqa_Push_Cond.dicFldComparisonOp[conqa_Push.ReceiveUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", conqa_Push.ReceiveUser, objqa_Push_Cond.ReceiveUser, strComparisonOp_ReceiveUser);
}
if (objqa_Push_Cond.IsUpdated(conqa_Push.ReceiveDate) == true)
{
string strComparisonOp_ReceiveDate = objqa_Push_Cond.dicFldComparisonOp[conqa_Push.ReceiveDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conqa_Push.ReceiveDate, objqa_Push_Cond.ReceiveDate, strComparisonOp_ReceiveDate);
}
if (objqa_Push_Cond.IsUpdated(conqa_Push.IsReceive) == true)
{
if (objqa_Push_Cond.IsReceive == true)
{
strWhereCond += string.Format(" And {0} = '1'", conqa_Push.IsReceive);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conqa_Push.IsReceive);
}
}
if (objqa_Push_Cond.IsUpdated(conqa_Push.UpdDate) == true)
{
string strComparisonOp_UpdDate = objqa_Push_Cond.dicFldComparisonOp[conqa_Push.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conqa_Push.UpdDate, objqa_Push_Cond.UpdDate, strComparisonOp_UpdDate);
}
if (objqa_Push_Cond.IsUpdated(conqa_Push.Memo) == true)
{
string strComparisonOp_Memo = objqa_Push_Cond.dicFldComparisonOp[conqa_Push.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", conqa_Push.Memo, objqa_Push_Cond.Memo, strComparisonOp_Memo);
}
if (objqa_Push_Cond.IsUpdated(conqa_Push.id_CurrEduCls) == true)
{
string strComparisonOp_id_CurrEduCls = objqa_Push_Cond.dicFldComparisonOp[conqa_Push.id_CurrEduCls];
strWhereCond += string.Format(" And {0} {2} '{1}'", conqa_Push.id_CurrEduCls, objqa_Push_Cond.id_CurrEduCls, strComparisonOp_id_CurrEduCls);
}
if (objqa_Push_Cond.IsUpdated(conqa_Push.IsReply) == true)
{
if (objqa_Push_Cond.IsReply == true)
{
strWhereCond += string.Format(" And {0} = '1'", conqa_Push.IsReply);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conqa_Push.IsReply);
}
}
if (objqa_Push_Cond.IsUpdated(conqa_Push.IsRequestReply) == true)
{
if (objqa_Push_Cond.IsRequestReply == true)
{
strWhereCond += string.Format(" And {0} = '1'", conqa_Push.IsRequestReply);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conqa_Push.IsRequestReply);
}
}
if (objqa_Push_Cond.IsUpdated(conqa_Push.ReplyDate) == true)
{
string strComparisonOp_ReplyDate = objqa_Push_Cond.dicFldComparisonOp[conqa_Push.ReplyDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conqa_Push.ReplyDate, objqa_Push_Cond.ReplyDate, strComparisonOp_ReplyDate);
}
 return strWhereCond;
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_Update)
 /// </summary>
 /// <param name = "objqa_PushEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsqa_PushEN objqa_PushEN)
{
 if (objqa_PushEN.PushId == 0)
 {
string strMsg = string.Format("(errid:Watl000003)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
objqa_PushEN.sf_UpdFldSetStr = objqa_PushEN.getsf_UpdFldSetStr();
clsqa_PushWApi.CheckPropertyNew(objqa_PushEN); 
bool bolResult = clsqa_PushWApi.UpdateRecord(objqa_PushEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsqa_PushWApi.ReFreshCache();
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
 /// 检查唯一性(Uniqueness)--qa_Push(答疑推送), 如果不唯一,即存在相同的记录,就返回False
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_GetConditionString4Constraint)
 /// </summary>
 /// <param name = "objqa_PushEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniConditionStr_PushId(this clsqa_PushEN objqa_PushEN)
{
//检测记录是否存在
StringBuilder sbCondition = new StringBuilder();
if (objqa_PushEN == null) return "";
if (objqa_PushEN.PushId == 0)
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and PushId = '{0}'", objqa_PushEN.PushId);
return sbCondition.ToString();
}
 else {
sbCondition.AppendFormat("PushId !=  {0}", objqa_PushEN.PushId);
 sbCondition.AppendFormat(" and PushId = '{0}'", objqa_PushEN.PushId);
 return sbCondition.ToString();
}
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_AddNewRecord)
 /// </summary>
 /// <param name = "objqa_PushEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clsqa_PushEN objqa_PushEN)
{
try
{
clsqa_PushWApi.CheckPropertyNew(objqa_PushEN); 
bool bolResult = clsqa_PushWApi.AddNewRecord(objqa_PushEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsqa_PushWApi.ReFreshCache();
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
 /// <param name = "objqa_PushEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsqa_PushEN objqa_PushEN, string strWhereCond)
{
try
{
clsqa_PushWApi.CheckPropertyNew(objqa_PushEN); 
bool bolResult = clsqa_PushWApi.UpdateWithCondition(objqa_PushEN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsqa_PushWApi.ReFreshCache();
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
 /// 答疑推送(qa_Push)
 /// (AutoGCLib.WA_Access4CSharp:GeneCode)
 /// </summary>
public class clsqa_PushWApi
{
private static readonly string mstrApiControllerName = "qa_PushApi";

 /// <summary>
/// 专门在逻辑层用于处理缓存等公共函数的对象
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_DefineObjCommFun4BL)
/// </summary>
public static clsCommFun4BL objCommFun4BL = null;

 public clsqa_PushWApi()
 {
 }

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_CheckPropertyNew)
 /// </summary>
public static void CheckPropertyNew(clsqa_PushEN objqa_PushEN)
{
if (!Object.Equals(null, objqa_PushEN.QuestionsId) && GetStrLen(objqa_PushEN.QuestionsId) > 8)
{
 throw new Exception("字段[提问Id]的长度不能超过8!");
}
if (!Object.Equals(null, objqa_PushEN.ReceiveUser) && GetStrLen(objqa_PushEN.ReceiveUser) > 20)
{
 throw new Exception("字段[接收用户]的长度不能超过20!");
}
if (!Object.Equals(null, objqa_PushEN.ReceiveDate) && GetStrLen(objqa_PushEN.ReceiveDate) > 20)
{
 throw new Exception("字段[接收日期]的长度不能超过20!");
}
if (!Object.Equals(null, objqa_PushEN.UpdDate) && GetStrLen(objqa_PushEN.UpdDate) > 20)
{
 throw new Exception("字段[修改日期]的长度不能超过20!");
}
if (!Object.Equals(null, objqa_PushEN.Memo) && GetStrLen(objqa_PushEN.Memo) > 1000)
{
 throw new Exception("字段[备注]的长度不能超过1000!");
}
if (!Object.Equals(null, objqa_PushEN.id_CurrEduCls) && GetStrLen(objqa_PushEN.id_CurrEduCls) > 8)
{
 throw new Exception("字段[当前教学班流水号]的长度不能超过8!");
}
if (!Object.Equals(null, objqa_PushEN.ReplyDate) && GetStrLen(objqa_PushEN.ReplyDate) > 20)
{
 throw new Exception("字段[回复日期]的长度不能超过20!");
}
 objqa_PushEN._IsCheckProperty = true;
 }

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyId)
 /// </summary>
 /// <param name = "lngPushId">表关键字</param>
 /// <returns>表对象</returns>
public static clsqa_PushEN GetObjByPushId(long lngPushId)
{
string strAction = "GetObjByPushId";
string strErrMsg = string.Empty;
string strResult = "";
clsqa_PushEN objqa_PushEN = null;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["PushId"] = lngPushId.ToString()
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
objqa_PushEN = JsonConvert.DeserializeObject<clsqa_PushEN>((string)jobjReturn["ReturnObj"]);
return objqa_PushEN;
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
 /// <param name = "lngPushId">表关键字</param>
 /// <returns>表对象</returns>
public static clsqa_PushEN GetObjByPushId_WA_Cache(long lngPushId)
{
string strAction = "GetObjByPushId_Cache";
string strErrMsg = string.Empty;
string strResult = "";
clsqa_PushEN objqa_PushEN = null;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["PushId"] = lngPushId.ToString()
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
objqa_PushEN = JsonConvert.DeserializeObject<clsqa_PushEN>((string)jobjReturn["ReturnObj"]);
return objqa_PushEN;
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
public static clsqa_PushEN GetFirstObj(string strWhereCond)
{
string strAction = "GetFirstObj";
string strErrMsg = string.Empty;
string strResult = "";
clsqa_PushEN objqa_PushEN = null;
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
objqa_PushEN = JsonConvert.DeserializeObject<clsqa_PushEN>((string)jobjReturn["ReturnObj"]);
return objqa_PushEN;
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
 /// <param name = "lngPushId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsqa_PushEN GetObjByPushId_Cache(long lngPushId)
{
//初始化列表缓存
string strKey = string.Format("{0}", clsqa_PushEN._CurrTabName_S);
List<clsqa_PushEN> arrqa_PushObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsqa_PushEN> arrqa_PushObjLst_Sel =
from objqa_PushEN in arrqa_PushObjLst_Cache
where objqa_PushEN.PushId == lngPushId
select objqa_PushEN;
if (arrqa_PushObjLst_Sel.Count() == 0)
{
   clsqa_PushEN obj = clsqa_PushWApi.GetObjByPushId(lngPushId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
     return obj;
 }
return null;
}
return arrqa_PushObjLst_Sel.First();
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsqa_PushEN> GetObjLst(string strWhereCond)
{
 List<clsqa_PushEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsqa_PushEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsqa_PushEN> GetObjLstByPushIdLst(List<long> arrPushId)
{
 List<clsqa_PushEN> arrObjLst = null; 
string strAction = "GetObjLstByPushIdLst";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrPushId);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
arrObjLst = JsonConvert.DeserializeObject<List<clsqa_PushEN>>((string)jobjReturn["ReturnObjLst"]);
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
 /// <param name = "lngPushId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static IEnumerable<clsqa_PushEN> GetObjLstByPushIdLst_Cache(List<long> arrPushId)
{
//初始化列表缓存
string strKey = string.Format("{0}", clsqa_PushEN._CurrTabName_S);
List<clsqa_PushEN> arrqa_PushObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsqa_PushEN> arrqa_PushObjLst_Sel =
from objqa_PushEN in arrqa_PushObjLst_Cache
where arrPushId.Contains(objqa_PushEN.PushId)
select objqa_PushEN;
return arrqa_PushObjLst_Sel;
}

 /// <summary>
 /// 根据关键字列表获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstByKeyLst_WA_Cache)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsqa_PushEN> GetObjLstByPushIdLst_WA_Cache(List<long> arrPushId)
{
 List<clsqa_PushEN> arrObjLst = null; 
string strAction = "GetObjLstByPushIdLst_Cache";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
};
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrPushId);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
arrObjLst = JsonConvert.DeserializeObject<List<clsqa_PushEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsqa_PushEN> GetTopObjLst(stuTopPara objTopPara)
{
 List<clsqa_PushEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsqa_PushEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsqa_PushEN> GetObjLstByRange(stuRangePara objRangePara)
{
 List<clsqa_PushEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsqa_PushEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsqa_PushEN> GetObjLstByPager(stuPagerPara objPagerPara)
{
 List<clsqa_PushEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsqa_PushEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsqa_PushEN> GetObjLstByPager_Cache(stuPagerPara objPagerPara)
{
 List<clsqa_PushEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsqa_PushEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static int DelRecord(long lngPushId)
{
string strAction = "DelRecord";
string strErrMsg = string.Empty;
string strResult = "";
try
{
 clsqa_PushEN objqa_PushEN = clsqa_PushWApi.GetObjByPushId(lngPushId);
if (clsPubFun4WApi.Delete(mstrApiControllerName, strAction, lngPushId.ToString(), out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
clsqa_PushWApi.ReFreshCache();
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
public static int Delqa_Pushs(List<string> arrPushId)
{
string strAction = "Delqa_Pushs";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrPushId);
if (clsPubFun4WApi.Deletes(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
clsqa_PushWApi.ReFreshCache();
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
public static int Delqa_PushsByCond(string strWhereCond)
{
string strAction = "Delqa_PushsByCond";
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
public static bool AddNewRecord(clsqa_PushEN objqa_PushEN)
{
string strAction = "AddNewRecord";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsqa_PushEN>(objqa_PushEN);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJson, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsqa_PushWApi.ReFreshCache();
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
 /// <param name = "objqa_PushEN">需要添加的表对象</param>
 /// <returns>返回新添加记录的关键字</returns>
public static string AddNewRecordWithReturnKey(clsqa_PushEN objqa_PushEN)
{
string strAction = "AddNewRecord";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsqa_PushEN>(objqa_PushEN);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJson, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsqa_PushWApi.ReFreshCache();
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
public static bool UpdateRecord(clsqa_PushEN objqa_PushEN)
{
if (string.IsNullOrEmpty(objqa_PushEN.sf_UpdFldSetStr) == true)
{
string strMsg = string.Format("修改时，修改标志串为空，请联系管理员.对象关键字:{0}.(from {1}).",
objqa_PushEN.PushId, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
string strAction = "UpdateRecord";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsqa_PushEN>(objqa_PushEN);
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
 /// <param name = "objqa_PushEN">需要修改的对象</param>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的关键字值</returns>
public static bool UpdateWithCondition(clsqa_PushEN objqa_PushEN, string strWhereCond)
{
if (string.IsNullOrEmpty(objqa_PushEN.sf_UpdFldSetStr) == true)
{
string strMsg = string.Format("修改时，修改标志串为空，请联系管理员.对象关键字:{0}.(from {1}).",
objqa_PushEN.PushId, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (string.IsNullOrEmpty(strWhereCond) == true)
{
string strMsg = string.Format("按条件修改时，条件串为空，请联系管理员.对象关键字:{0}.(from {1}).",
objqa_PushEN.PushId, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
string strAction = "UpdateWithCondition";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsqa_PushEN>(objqa_PushEN);
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
public static bool IsExist(long lngPushId)
{
//检测记录是否存在
string strAction = "IsExist";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["PushId"] = lngPushId.ToString()
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
 /// <param name = "objqa_PushENS">源对象</param>
 /// <param name = "objqa_PushENT">目标对象</param>
 public static void CopyTo(clsqa_PushEN objqa_PushENS, clsqa_PushEN objqa_PushENT)
{
try
{
objqa_PushENT.PushId = objqa_PushENS.PushId; //推送d
objqa_PushENT.QuestionsId = objqa_PushENS.QuestionsId; //提问Id
objqa_PushENT.ReceiveUser = objqa_PushENS.ReceiveUser; //接收用户
objqa_PushENT.ReceiveDate = objqa_PushENS.ReceiveDate; //接收日期
objqa_PushENT.IsReceive = objqa_PushENS.IsReceive; //是否接收
objqa_PushENT.UpdDate = objqa_PushENS.UpdDate; //修改日期
objqa_PushENT.Memo = objqa_PushENS.Memo; //备注
objqa_PushENT.id_CurrEduCls = objqa_PushENS.id_CurrEduCls; //当前教学班流水号
objqa_PushENT.IsReply = objqa_PushENS.IsReply; //是否回复
objqa_PushENT.IsRequestReply = objqa_PushENS.IsRequestReply; //是否要求回复
objqa_PushENT.ReplyDate = objqa_PushENS.ReplyDate; //回复日期
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
public static DataTable ToDataTable(List<clsqa_PushEN> arrObj)
{
DataTable dataTable = new DataTable(); //实例化
DataTable result;
if (arrObj.Count == 0) return null;
if (clsqa_PushEN.AttributeName.Length == 0)
{
result = dataTable;
return result;
}
Type type = typeof(clsqa_PushEN);
PropertyInfo[] arrPropertyInfo = type.GetProperties();
try
{
//Columns
foreach (string strAttrName in clsqa_PushEN.AttributeName)
{
PropertyInfo proprety_Curr = arrPropertyInfo.Where(x => x.Name == strAttrName).First();
dataTable.Columns.Add(strAttrName, proprety_Curr.PropertyType);
}
foreach (clsqa_PushEN objInFor in arrObj)
{
//Rows
DataRow dataRow = dataTable.NewRow();
foreach (string strAttrName in clsqa_PushEN.AttributeName)
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
if (clsqa_PushWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsqa_PushWApi没有刷新缓存机制(clsqa_PushWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by PushId");
//if (arrqa_PushObjLst_Cache == null)
//{
//arrqa_PushObjLst_Cache = await clsqa_PushWApi.GetObjLst(strWhereCond);
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
string strKey = string.Format("{0}", clsqa_PushEN._CurrTabName_S);
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
if (clsqa_PushWApi.objCommFun4BL != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}", clsqa_PushEN._CurrTabName_S);
CacheHelper.Remove(strKey);
clsqa_PushWApi.objCommFun4BL.ReFreshCache();
}
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst_Cache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsqa_PushEN> GetObjLst_Cache()
{
//初始化列表缓存
InitListCache(); 
string strKey = string.Format("{0}", clsqa_PushEN._CurrTabName_S);
List<clsqa_PushEN> arrqa_PushObjLst_Cache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrqa_PushObjLst_Cache;
}

 /// <summary>
 /// 根据对象列表获取DataTable
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetDataTableByObjLst)
 /// </summary>
 /// <param name = "arrObjLst">给定的对象列表</param>
 /// <returns>返回DataTable</returns>
public static DataTable GetDataTableByObjLst(List<clsqa_PushEN> arrObjLst)
{
DataTable objDT = new DataTable();
objDT.Columns.Add(conqa_Push.PushId, Type.GetType("System.Int64"));
objDT.Columns.Add(conqa_Push.QuestionsId, Type.GetType("System.String"));
objDT.Columns.Add(conqa_Push.ReceiveUser, Type.GetType("System.String"));
objDT.Columns.Add(conqa_Push.ReceiveDate, Type.GetType("System.String"));
objDT.Columns.Add(conqa_Push.IsReceive, Type.GetType("System.Boolean"));
objDT.Columns.Add(conqa_Push.UpdDate, Type.GetType("System.String"));
objDT.Columns.Add(conqa_Push.Memo, Type.GetType("System.String"));
objDT.Columns.Add(conqa_Push.id_CurrEduCls, Type.GetType("System.String"));
objDT.Columns.Add(conqa_Push.IsReply, Type.GetType("System.Boolean"));
objDT.Columns.Add(conqa_Push.IsRequestReply, Type.GetType("System.Boolean"));
objDT.Columns.Add(conqa_Push.ReplyDate, Type.GetType("System.String"));
foreach (clsqa_PushEN objInFor in arrObjLst)
{
DataRow objDR = objDT.NewRow();
objDR[conqa_Push.PushId] = objInFor[conqa_Push.PushId];
objDR[conqa_Push.QuestionsId] = objInFor[conqa_Push.QuestionsId];
objDR[conqa_Push.ReceiveUser] = objInFor[conqa_Push.ReceiveUser];
objDR[conqa_Push.ReceiveDate] = objInFor[conqa_Push.ReceiveDate];
objDR[conqa_Push.IsReceive] = objInFor[conqa_Push.IsReceive];
objDR[conqa_Push.UpdDate] = objInFor[conqa_Push.UpdDate];
objDR[conqa_Push.Memo] = objInFor[conqa_Push.Memo];
objDR[conqa_Push.id_CurrEduCls] = objInFor[conqa_Push.id_CurrEduCls];
objDR[conqa_Push.IsReply] = objInFor[conqa_Push.IsReply];
objDR[conqa_Push.IsRequestReply] = objInFor[conqa_Push.IsRequestReply];
objDR[conqa_Push.ReplyDate] = objInFor[conqa_Push.ReplyDate];
objDT.Rows.Add(objDR);
}
return objDT;
}
}
 /// <summary>
 /// 答疑推送(qa_Push)
 /// 数据源类型:SQL表
 /// (AutoGCLib.CommFun4WA4CSharp:GeneCode_This)
 /// </summary>
public class clsCommFun4WA4qa_Push : clsCommFun4BL
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
clsqa_PushWApi.ReFreshThisCache();
clsvqa_PushWApi.ReFreshThisCache();
}
}

}