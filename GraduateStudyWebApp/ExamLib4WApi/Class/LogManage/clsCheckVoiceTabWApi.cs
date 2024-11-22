
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsCheckVoiceTabWApi
 表名:CheckVoiceTab(01120352)
 生成代码版本:2021.09.20.1
 生成日期:2021/09/21 02:41:56
 生成者:pyf
 生成服务器IP:103.116.76.183
 工程名称:问卷调查
 工程ID:0112
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:日志管理
 模块英文名:LogManage
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
public static class clsCheckVoiceTabWApi_Static
{

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCheckVoiceTabEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsCheckVoiceTabEN SetmId(this clsCheckVoiceTabEN objCheckVoiceTabEN, long lngmId, string strComparisonOp="")
	{
objCheckVoiceTabEN.mId = lngmId; //mId
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCheckVoiceTabEN.dicFldComparisonOp.ContainsKey(conCheckVoiceTab.mId) == false)
{
objCheckVoiceTabEN.dicFldComparisonOp.Add(conCheckVoiceTab.mId, strComparisonOp);
}
else
{
objCheckVoiceTabEN.dicFldComparisonOp[conCheckVoiceTab.mId] = strComparisonOp;
}
}
return objCheckVoiceTabEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCheckVoiceTabEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsCheckVoiceTabEN SetUserId(this clsCheckVoiceTabEN objCheckVoiceTabEN, string strUserId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strUserId, conCheckVoiceTab.UserId);
clsCheckSql.CheckFieldLen(strUserId, 20, conCheckVoiceTab.UserId);
objCheckVoiceTabEN.UserId = strUserId; //用户ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCheckVoiceTabEN.dicFldComparisonOp.ContainsKey(conCheckVoiceTab.UserId) == false)
{
objCheckVoiceTabEN.dicFldComparisonOp.Add(conCheckVoiceTab.UserId, strComparisonOp);
}
else
{
objCheckVoiceTabEN.dicFldComparisonOp[conCheckVoiceTab.UserId] = strComparisonOp;
}
}
return objCheckVoiceTabEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCheckVoiceTabEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsCheckVoiceTabEN SetQuestionID(this clsCheckVoiceTabEN objCheckVoiceTabEN, string strQuestionID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strQuestionID, 8, conCheckVoiceTab.QuestionID);
clsCheckSql.CheckFieldForeignKey(strQuestionID, 8, conCheckVoiceTab.QuestionID);
objCheckVoiceTabEN.QuestionID = strQuestionID; //题目ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCheckVoiceTabEN.dicFldComparisonOp.ContainsKey(conCheckVoiceTab.QuestionID) == false)
{
objCheckVoiceTabEN.dicFldComparisonOp.Add(conCheckVoiceTab.QuestionID, strComparisonOp);
}
else
{
objCheckVoiceTabEN.dicFldComparisonOp[conCheckVoiceTab.QuestionID] = strComparisonOp;
}
}
return objCheckVoiceTabEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCheckVoiceTabEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsCheckVoiceTabEN SetYinBiaoId(this clsCheckVoiceTabEN objCheckVoiceTabEN, int intYinBiaoId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(intYinBiaoId, conCheckVoiceTab.YinBiaoId);
objCheckVoiceTabEN.YinBiaoId = intYinBiaoId; //音标Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCheckVoiceTabEN.dicFldComparisonOp.ContainsKey(conCheckVoiceTab.YinBiaoId) == false)
{
objCheckVoiceTabEN.dicFldComparisonOp.Add(conCheckVoiceTab.YinBiaoId, strComparisonOp);
}
else
{
objCheckVoiceTabEN.dicFldComparisonOp[conCheckVoiceTab.YinBiaoId] = strComparisonOp;
}
}
return objCheckVoiceTabEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCheckVoiceTabEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsCheckVoiceTabEN SetYinBiao(this clsCheckVoiceTabEN objCheckVoiceTabEN, string strYinBiao, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strYinBiao, 50, conCheckVoiceTab.YinBiao);
objCheckVoiceTabEN.YinBiao = strYinBiao; //音标
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCheckVoiceTabEN.dicFldComparisonOp.ContainsKey(conCheckVoiceTab.YinBiao) == false)
{
objCheckVoiceTabEN.dicFldComparisonOp.Add(conCheckVoiceTab.YinBiao, strComparisonOp);
}
else
{
objCheckVoiceTabEN.dicFldComparisonOp[conCheckVoiceTab.YinBiao] = strComparisonOp;
}
}
return objCheckVoiceTabEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCheckVoiceTabEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsCheckVoiceTabEN SetFileName(this clsCheckVoiceTabEN objCheckVoiceTabEN, string strFileName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strFileName, conCheckVoiceTab.FileName);
clsCheckSql.CheckFieldLen(strFileName, 500, conCheckVoiceTab.FileName);
objCheckVoiceTabEN.FileName = strFileName; //文件名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCheckVoiceTabEN.dicFldComparisonOp.ContainsKey(conCheckVoiceTab.FileName) == false)
{
objCheckVoiceTabEN.dicFldComparisonOp.Add(conCheckVoiceTab.FileName, strComparisonOp);
}
else
{
objCheckVoiceTabEN.dicFldComparisonOp[conCheckVoiceTab.FileName] = strComparisonOp;
}
}
return objCheckVoiceTabEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCheckVoiceTabEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsCheckVoiceTabEN SetCheckResult(this clsCheckVoiceTabEN objCheckVoiceTabEN, string strCheckResult, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCheckResult, 1000, conCheckVoiceTab.CheckResult);
objCheckVoiceTabEN.CheckResult = strCheckResult; //检查结果
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCheckVoiceTabEN.dicFldComparisonOp.ContainsKey(conCheckVoiceTab.CheckResult) == false)
{
objCheckVoiceTabEN.dicFldComparisonOp.Add(conCheckVoiceTab.CheckResult, strComparisonOp);
}
else
{
objCheckVoiceTabEN.dicFldComparisonOp[conCheckVoiceTab.CheckResult] = strComparisonOp;
}
}
return objCheckVoiceTabEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCheckVoiceTabEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsCheckVoiceTabEN SetIsChecked(this clsCheckVoiceTabEN objCheckVoiceTabEN, bool bolIsChecked, string strComparisonOp="")
	{
objCheckVoiceTabEN.IsChecked = bolIsChecked; //是否检查
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCheckVoiceTabEN.dicFldComparisonOp.ContainsKey(conCheckVoiceTab.IsChecked) == false)
{
objCheckVoiceTabEN.dicFldComparisonOp.Add(conCheckVoiceTab.IsChecked, strComparisonOp);
}
else
{
objCheckVoiceTabEN.dicFldComparisonOp[conCheckVoiceTab.IsChecked] = strComparisonOp;
}
}
return objCheckVoiceTabEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCheckVoiceTabEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsCheckVoiceTabEN SetIsRight(this clsCheckVoiceTabEN objCheckVoiceTabEN, bool bolIsRight, string strComparisonOp="")
	{
objCheckVoiceTabEN.IsRight = bolIsRight; //是否正确
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCheckVoiceTabEN.dicFldComparisonOp.ContainsKey(conCheckVoiceTab.IsRight) == false)
{
objCheckVoiceTabEN.dicFldComparisonOp.Add(conCheckVoiceTab.IsRight, strComparisonOp);
}
else
{
objCheckVoiceTabEN.dicFldComparisonOp[conCheckVoiceTab.IsRight] = strComparisonOp;
}
}
return objCheckVoiceTabEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCheckVoiceTabEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsCheckVoiceTabEN SetUpdUser(this clsCheckVoiceTabEN objCheckVoiceTabEN, string strUpdUser, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strUpdUser, conCheckVoiceTab.UpdUser);
clsCheckSql.CheckFieldLen(strUpdUser, 20, conCheckVoiceTab.UpdUser);
objCheckVoiceTabEN.UpdUser = strUpdUser; //修改人
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCheckVoiceTabEN.dicFldComparisonOp.ContainsKey(conCheckVoiceTab.UpdUser) == false)
{
objCheckVoiceTabEN.dicFldComparisonOp.Add(conCheckVoiceTab.UpdUser, strComparisonOp);
}
else
{
objCheckVoiceTabEN.dicFldComparisonOp[conCheckVoiceTab.UpdUser] = strComparisonOp;
}
}
return objCheckVoiceTabEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCheckVoiceTabEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsCheckVoiceTabEN SetUpdDate(this clsCheckVoiceTabEN objCheckVoiceTabEN, string strUpdDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strUpdDate, conCheckVoiceTab.UpdDate);
clsCheckSql.CheckFieldLen(strUpdDate, 20, conCheckVoiceTab.UpdDate);
objCheckVoiceTabEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCheckVoiceTabEN.dicFldComparisonOp.ContainsKey(conCheckVoiceTab.UpdDate) == false)
{
objCheckVoiceTabEN.dicFldComparisonOp.Add(conCheckVoiceTab.UpdDate, strComparisonOp);
}
else
{
objCheckVoiceTabEN.dicFldComparisonOp[conCheckVoiceTab.UpdDate] = strComparisonOp;
}
}
return objCheckVoiceTabEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCheckVoiceTabEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsCheckVoiceTabEN SetMemo(this clsCheckVoiceTabEN objCheckVoiceTabEN, string strMemo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMemo, 1000, conCheckVoiceTab.Memo);
objCheckVoiceTabEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCheckVoiceTabEN.dicFldComparisonOp.ContainsKey(conCheckVoiceTab.Memo) == false)
{
objCheckVoiceTabEN.dicFldComparisonOp.Add(conCheckVoiceTab.Memo, strComparisonOp);
}
else
{
objCheckVoiceTabEN.dicFldComparisonOp[conCheckVoiceTab.Memo] = strComparisonOp;
}
}
return objCheckVoiceTabEN;
	}

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsCheckVoiceTabEN objCheckVoiceTab_Cond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objCheckVoiceTab_Cond.IsUpdated(conCheckVoiceTab.mId) == true)
{
string strComparisonOp_mId = objCheckVoiceTab_Cond.dicFldComparisonOp[conCheckVoiceTab.mId];
strWhereCond += string.Format(" And {0} {2} {1}", conCheckVoiceTab.mId, objCheckVoiceTab_Cond.mId, strComparisonOp_mId);
}
if (objCheckVoiceTab_Cond.IsUpdated(conCheckVoiceTab.UserId) == true)
{
string strComparisonOp_UserId = objCheckVoiceTab_Cond.dicFldComparisonOp[conCheckVoiceTab.UserId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCheckVoiceTab.UserId, objCheckVoiceTab_Cond.UserId, strComparisonOp_UserId);
}
if (objCheckVoiceTab_Cond.IsUpdated(conCheckVoiceTab.QuestionID) == true)
{
string strComparisonOp_QuestionID = objCheckVoiceTab_Cond.dicFldComparisonOp[conCheckVoiceTab.QuestionID];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCheckVoiceTab.QuestionID, objCheckVoiceTab_Cond.QuestionID, strComparisonOp_QuestionID);
}
if (objCheckVoiceTab_Cond.IsUpdated(conCheckVoiceTab.YinBiaoId) == true)
{
string strComparisonOp_YinBiaoId = objCheckVoiceTab_Cond.dicFldComparisonOp[conCheckVoiceTab.YinBiaoId];
strWhereCond += string.Format(" And {0} {2} {1}", conCheckVoiceTab.YinBiaoId, objCheckVoiceTab_Cond.YinBiaoId, strComparisonOp_YinBiaoId);
}
if (objCheckVoiceTab_Cond.IsUpdated(conCheckVoiceTab.YinBiao) == true)
{
string strComparisonOp_YinBiao = objCheckVoiceTab_Cond.dicFldComparisonOp[conCheckVoiceTab.YinBiao];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCheckVoiceTab.YinBiao, objCheckVoiceTab_Cond.YinBiao, strComparisonOp_YinBiao);
}
if (objCheckVoiceTab_Cond.IsUpdated(conCheckVoiceTab.FileName) == true)
{
string strComparisonOp_FileName = objCheckVoiceTab_Cond.dicFldComparisonOp[conCheckVoiceTab.FileName];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCheckVoiceTab.FileName, objCheckVoiceTab_Cond.FileName, strComparisonOp_FileName);
}
if (objCheckVoiceTab_Cond.IsUpdated(conCheckVoiceTab.CheckResult) == true)
{
string strComparisonOp_CheckResult = objCheckVoiceTab_Cond.dicFldComparisonOp[conCheckVoiceTab.CheckResult];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCheckVoiceTab.CheckResult, objCheckVoiceTab_Cond.CheckResult, strComparisonOp_CheckResult);
}
if (objCheckVoiceTab_Cond.IsUpdated(conCheckVoiceTab.IsChecked) == true)
{
if (objCheckVoiceTab_Cond.IsChecked == true)
{
strWhereCond += string.Format(" And {0} = '1'", conCheckVoiceTab.IsChecked);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conCheckVoiceTab.IsChecked);
}
}
if (objCheckVoiceTab_Cond.IsUpdated(conCheckVoiceTab.IsRight) == true)
{
if (objCheckVoiceTab_Cond.IsRight == true)
{
strWhereCond += string.Format(" And {0} = '1'", conCheckVoiceTab.IsRight);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conCheckVoiceTab.IsRight);
}
}
if (objCheckVoiceTab_Cond.IsUpdated(conCheckVoiceTab.UpdUser) == true)
{
string strComparisonOp_UpdUser = objCheckVoiceTab_Cond.dicFldComparisonOp[conCheckVoiceTab.UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCheckVoiceTab.UpdUser, objCheckVoiceTab_Cond.UpdUser, strComparisonOp_UpdUser);
}
if (objCheckVoiceTab_Cond.IsUpdated(conCheckVoiceTab.UpdDate) == true)
{
string strComparisonOp_UpdDate = objCheckVoiceTab_Cond.dicFldComparisonOp[conCheckVoiceTab.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCheckVoiceTab.UpdDate, objCheckVoiceTab_Cond.UpdDate, strComparisonOp_UpdDate);
}
if (objCheckVoiceTab_Cond.IsUpdated(conCheckVoiceTab.Memo) == true)
{
string strComparisonOp_Memo = objCheckVoiceTab_Cond.dicFldComparisonOp[conCheckVoiceTab.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCheckVoiceTab.Memo, objCheckVoiceTab_Cond.Memo, strComparisonOp_Memo);
}
 return strWhereCond;
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_Update)
 /// </summary>
 /// <param name = "objCheckVoiceTabEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsCheckVoiceTabEN objCheckVoiceTabEN)
{
 if (objCheckVoiceTabEN.mId == 0)
 {
string strMsg = string.Format("(errid:Watl000003)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
objCheckVoiceTabEN.sf_UpdFldSetStr = objCheckVoiceTabEN.getsf_UpdFldSetStr();
clsCheckVoiceTabWApi.CheckPropertyNew(objCheckVoiceTabEN); 
bool bolResult = clsCheckVoiceTabWApi.UpdateRecord(objCheckVoiceTabEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsCheckVoiceTabWApi.ReFreshCache();
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
 /// 检查唯一性(Uniqueness)--CheckVoiceTab(检查语音), 如果不唯一,即存在相同的记录,就返回False
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_GetConditionString4Constraint)
 /// </summary>
 /// <param name = "objCheckVoiceTabEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniConditionStr_UserId_QuestionID(this clsCheckVoiceTabEN objCheckVoiceTabEN)
{
//检测记录是否存在
StringBuilder sbCondition = new StringBuilder();
if (objCheckVoiceTabEN == null) return "";
if (objCheckVoiceTabEN.mId == 0)
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and UserId = '{0}'", objCheckVoiceTabEN.UserId);
 sbCondition.AppendFormat(" and QuestionID = '{0}'", objCheckVoiceTabEN.QuestionID);
return sbCondition.ToString();
}
 else {
sbCondition.AppendFormat("mId !=  {0}", objCheckVoiceTabEN.mId);
 sbCondition.AppendFormat(" and UserId = '{0}'", objCheckVoiceTabEN.UserId);
 sbCondition.AppendFormat(" and QuestionID = '{0}'", objCheckVoiceTabEN.QuestionID);
 return sbCondition.ToString();
}
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_AddNewRecord)
 /// </summary>
 /// <param name = "objCheckVoiceTabEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clsCheckVoiceTabEN objCheckVoiceTabEN)
{
try
{
clsCheckVoiceTabWApi.CheckPropertyNew(objCheckVoiceTabEN); 
bool bolResult = clsCheckVoiceTabWApi.AddNewRecord(objCheckVoiceTabEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsCheckVoiceTabWApi.ReFreshCache();
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
 /// <param name = "objCheckVoiceTabEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsCheckVoiceTabEN objCheckVoiceTabEN, string strWhereCond)
{
try
{
clsCheckVoiceTabWApi.CheckPropertyNew(objCheckVoiceTabEN); 
bool bolResult = clsCheckVoiceTabWApi.UpdateWithCondition(objCheckVoiceTabEN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsCheckVoiceTabWApi.ReFreshCache();
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
 /// 检查语音(CheckVoiceTab)
 /// (AutoGCLib.WA_Access4CSharp:GeneCode)
 /// </summary>
public class clsCheckVoiceTabWApi
{
private static readonly string mstrApiControllerName = "CheckVoiceTabApi";

 /// <summary>
/// 专门在逻辑层用于处理缓存等公共函数的对象
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_DefineObjCommFun4BL)
/// </summary>
public static clsCommFun4BL objCommFun4BL = null;

 public clsCheckVoiceTabWApi()
 {
 }

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_CheckPropertyNew)
 /// </summary>
public static void CheckPropertyNew(clsCheckVoiceTabEN objCheckVoiceTabEN)
{
if (!Object.Equals(null, objCheckVoiceTabEN.UserId) && GetStrLen(objCheckVoiceTabEN.UserId) > 20)
{
 throw new Exception("字段[用户ID]的长度不能超过20!");
}
if (!Object.Equals(null, objCheckVoiceTabEN.QuestionID) && GetStrLen(objCheckVoiceTabEN.QuestionID) > 8)
{
 throw new Exception("字段[题目ID]的长度不能超过8!");
}
if (!Object.Equals(null, objCheckVoiceTabEN.YinBiao) && GetStrLen(objCheckVoiceTabEN.YinBiao) > 50)
{
 throw new Exception("字段[音标]的长度不能超过50!");
}
if (!Object.Equals(null, objCheckVoiceTabEN.FileName) && GetStrLen(objCheckVoiceTabEN.FileName) > 500)
{
 throw new Exception("字段[文件名称]的长度不能超过500!");
}
if (!Object.Equals(null, objCheckVoiceTabEN.CheckResult) && GetStrLen(objCheckVoiceTabEN.CheckResult) > 1000)
{
 throw new Exception("字段[检查结果]的长度不能超过1000!");
}
if (!Object.Equals(null, objCheckVoiceTabEN.UpdUser) && GetStrLen(objCheckVoiceTabEN.UpdUser) > 20)
{
 throw new Exception("字段[修改人]的长度不能超过20!");
}
if (!Object.Equals(null, objCheckVoiceTabEN.UpdDate) && GetStrLen(objCheckVoiceTabEN.UpdDate) > 20)
{
 throw new Exception("字段[修改日期]的长度不能超过20!");
}
if (!Object.Equals(null, objCheckVoiceTabEN.Memo) && GetStrLen(objCheckVoiceTabEN.Memo) > 1000)
{
 throw new Exception("字段[备注]的长度不能超过1000!");
}
 objCheckVoiceTabEN._IsCheckProperty = true;
 }

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyId)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public static clsCheckVoiceTabEN GetObjBymId(long lngmId)
{
string strAction = "GetObjBymId";
string strErrMsg = string.Empty;
string strResult = "";
clsCheckVoiceTabEN objCheckVoiceTabEN = null;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["mId"] = lngmId.ToString()
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
objCheckVoiceTabEN = JsonConvert.DeserializeObject<clsCheckVoiceTabEN>((string)jobjReturn["ReturnObj"]);
return objCheckVoiceTabEN;
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
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public static clsCheckVoiceTabEN GetObjBymId_WA_Cache(long lngmId)
{
string strAction = "GetObjBymId_Cache";
string strErrMsg = string.Empty;
string strResult = "";
clsCheckVoiceTabEN objCheckVoiceTabEN = null;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["mId"] = lngmId.ToString()
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
objCheckVoiceTabEN = JsonConvert.DeserializeObject<clsCheckVoiceTabEN>((string)jobjReturn["ReturnObj"]);
return objCheckVoiceTabEN;
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
public static clsCheckVoiceTabEN GetFirstObj(string strWhereCond)
{
string strAction = "GetFirstObj";
string strErrMsg = string.Empty;
string strResult = "";
clsCheckVoiceTabEN objCheckVoiceTabEN = null;
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
objCheckVoiceTabEN = JsonConvert.DeserializeObject<clsCheckVoiceTabEN>((string)jobjReturn["ReturnObj"]);
return objCheckVoiceTabEN;
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
 /// <param name = "lngmId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsCheckVoiceTabEN GetObjBymId_Cache(long lngmId)
{
//初始化列表缓存
string strKey = string.Format("{0}", clsCheckVoiceTabEN._CurrTabName_S);
List<clsCheckVoiceTabEN> arrCheckVoiceTabObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsCheckVoiceTabEN> arrCheckVoiceTabObjLst_Sel =
from objCheckVoiceTabEN in arrCheckVoiceTabObjLst_Cache
where objCheckVoiceTabEN.mId == lngmId
select objCheckVoiceTabEN;
if (arrCheckVoiceTabObjLst_Sel.Count() == 0)
{
   clsCheckVoiceTabEN obj = clsCheckVoiceTabWApi.GetObjBymId(lngmId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
     return obj;
 }
return null;
}
return arrCheckVoiceTabObjLst_Sel.First();
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsCheckVoiceTabEN> GetObjLst(string strWhereCond)
{
 List<clsCheckVoiceTabEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsCheckVoiceTabEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsCheckVoiceTabEN> GetObjLstByMIdLst(List<long> arrMId)
{
 List<clsCheckVoiceTabEN> arrObjLst = null; 
string strAction = "GetObjLstByMIdLst";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrMId);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
arrObjLst = JsonConvert.DeserializeObject<List<clsCheckVoiceTabEN>>((string)jobjReturn["ReturnObjLst"]);
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
 /// <param name = "lngmId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static IEnumerable<clsCheckVoiceTabEN> GetObjLstByMIdLst_Cache(List<long> arrMId)
{
//初始化列表缓存
string strKey = string.Format("{0}", clsCheckVoiceTabEN._CurrTabName_S);
List<clsCheckVoiceTabEN> arrCheckVoiceTabObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsCheckVoiceTabEN> arrCheckVoiceTabObjLst_Sel =
from objCheckVoiceTabEN in arrCheckVoiceTabObjLst_Cache
where arrMId.Contains(objCheckVoiceTabEN.mId)
select objCheckVoiceTabEN;
return arrCheckVoiceTabObjLst_Sel;
}

 /// <summary>
 /// 根据关键字列表获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstByKeyLst_WA_Cache)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsCheckVoiceTabEN> GetObjLstByMIdLst_WA_Cache(List<long> arrMId)
{
 List<clsCheckVoiceTabEN> arrObjLst = null; 
string strAction = "GetObjLstByMIdLst_Cache";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
};
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrMId);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
arrObjLst = JsonConvert.DeserializeObject<List<clsCheckVoiceTabEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsCheckVoiceTabEN> GetTopObjLst(stuTopPara objTopPara)
{
 List<clsCheckVoiceTabEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsCheckVoiceTabEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsCheckVoiceTabEN> GetObjLstByRange(stuRangePara objRangePara)
{
 List<clsCheckVoiceTabEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsCheckVoiceTabEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsCheckVoiceTabEN> GetObjLstByPager(stuPagerPara objPagerPara)
{
 List<clsCheckVoiceTabEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsCheckVoiceTabEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsCheckVoiceTabEN> GetObjLstByPager_Cache(stuPagerPara objPagerPara)
{
 List<clsCheckVoiceTabEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsCheckVoiceTabEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static int DelRecord(long lngmId)
{
string strAction = "DelRecord";
string strErrMsg = string.Empty;
string strResult = "";
try
{
 clsCheckVoiceTabEN objCheckVoiceTabEN = clsCheckVoiceTabWApi.GetObjBymId(lngmId);
if (clsPubFun4WApi.Delete(mstrApiControllerName, strAction, lngmId.ToString(), out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
clsCheckVoiceTabWApi.ReFreshCache();
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
public static int DelCheckVoiceTabs(List<string> arrmId)
{
string strAction = "DelCheckVoiceTabs";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrmId);
if (clsPubFun4WApi.Deletes(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
clsCheckVoiceTabWApi.ReFreshCache();
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
public static int DelCheckVoiceTabsByCond(string strWhereCond)
{
string strAction = "DelCheckVoiceTabsByCond";
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
public static bool AddNewRecord(clsCheckVoiceTabEN objCheckVoiceTabEN)
{
string strAction = "AddNewRecord";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsCheckVoiceTabEN>(objCheckVoiceTabEN);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJson, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsCheckVoiceTabWApi.ReFreshCache();
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
 /// <param name = "objCheckVoiceTabEN">需要添加的表对象</param>
 /// <returns>返回新添加记录的关键字</returns>
public static string AddNewRecordWithReturnKey(clsCheckVoiceTabEN objCheckVoiceTabEN)
{
string strAction = "AddNewRecord";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsCheckVoiceTabEN>(objCheckVoiceTabEN);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJson, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsCheckVoiceTabWApi.ReFreshCache();
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
public static bool UpdateRecord(clsCheckVoiceTabEN objCheckVoiceTabEN)
{
if (string.IsNullOrEmpty(objCheckVoiceTabEN.sf_UpdFldSetStr) == true)
{
string strMsg = string.Format("修改时，修改标志串为空，请联系管理员.对象关键字:{0}.(from {1}).",
objCheckVoiceTabEN.mId, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
string strAction = "UpdateRecord";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsCheckVoiceTabEN>(objCheckVoiceTabEN);
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
 /// <param name = "objCheckVoiceTabEN">需要修改的对象</param>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的关键字值</returns>
public static bool UpdateWithCondition(clsCheckVoiceTabEN objCheckVoiceTabEN, string strWhereCond)
{
if (string.IsNullOrEmpty(objCheckVoiceTabEN.sf_UpdFldSetStr) == true)
{
string strMsg = string.Format("修改时，修改标志串为空，请联系管理员.对象关键字:{0}.(from {1}).",
objCheckVoiceTabEN.mId, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (string.IsNullOrEmpty(strWhereCond) == true)
{
string strMsg = string.Format("按条件修改时，条件串为空，请联系管理员.对象关键字:{0}.(from {1}).",
objCheckVoiceTabEN.mId, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
string strAction = "UpdateWithCondition";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsCheckVoiceTabEN>(objCheckVoiceTabEN);
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
public static bool IsExist(long lngmId)
{
//检测记录是否存在
string strAction = "IsExist";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["mId"] = lngmId.ToString()
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
 /// <param name = "objCheckVoiceTabENS">源对象</param>
 /// <param name = "objCheckVoiceTabENT">目标对象</param>
 public static void CopyTo(clsCheckVoiceTabEN objCheckVoiceTabENS, clsCheckVoiceTabEN objCheckVoiceTabENT)
{
try
{
objCheckVoiceTabENT.mId = objCheckVoiceTabENS.mId; //mId
objCheckVoiceTabENT.UserId = objCheckVoiceTabENS.UserId; //用户ID
objCheckVoiceTabENT.QuestionID = objCheckVoiceTabENS.QuestionID; //题目ID
objCheckVoiceTabENT.YinBiaoId = objCheckVoiceTabENS.YinBiaoId; //音标Id
objCheckVoiceTabENT.YinBiao = objCheckVoiceTabENS.YinBiao; //音标
objCheckVoiceTabENT.FileName = objCheckVoiceTabENS.FileName; //文件名称
objCheckVoiceTabENT.CheckResult = objCheckVoiceTabENS.CheckResult; //检查结果
objCheckVoiceTabENT.IsChecked = objCheckVoiceTabENS.IsChecked; //是否检查
objCheckVoiceTabENT.IsRight = objCheckVoiceTabENS.IsRight; //是否正确
objCheckVoiceTabENT.UpdUser = objCheckVoiceTabENS.UpdUser; //修改人
objCheckVoiceTabENT.UpdDate = objCheckVoiceTabENS.UpdDate; //修改日期
objCheckVoiceTabENT.Memo = objCheckVoiceTabENS.Memo; //备注
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
public static DataTable ToDataTable(List<clsCheckVoiceTabEN> arrObj)
{
DataTable dataTable = new DataTable(); //实例化
DataTable result;
if (arrObj.Count == 0) return null;
if (clsCheckVoiceTabEN.AttributeName.Length == 0)
{
result = dataTable;
return result;
}
Type type = typeof(clsCheckVoiceTabEN);
PropertyInfo[] arrPropertyInfo = type.GetProperties();
try
{
//Columns
foreach (string strAttrName in clsCheckVoiceTabEN.AttributeName)
{
PropertyInfo proprety_Curr = arrPropertyInfo.Where(x => x.Name == strAttrName).First();
dataTable.Columns.Add(strAttrName, proprety_Curr.PropertyType);
}
foreach (clsCheckVoiceTabEN objInFor in arrObj)
{
//Rows
DataRow dataRow = dataTable.NewRow();
foreach (string strAttrName in clsCheckVoiceTabEN.AttributeName)
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
if (clsCheckVoiceTabWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsCheckVoiceTabWApi没有刷新缓存机制(clsCheckVoiceTabWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by mId");
//if (arrCheckVoiceTabObjLst_Cache == null)
//{
//arrCheckVoiceTabObjLst_Cache = await clsCheckVoiceTabWApi.GetObjLst(strWhereCond);
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
string strKey = string.Format("{0}", clsCheckVoiceTabEN._CurrTabName_S);
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
if (clsCheckVoiceTabWApi.objCommFun4BL != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}", clsCheckVoiceTabEN._CurrTabName_S);
CacheHelper.Remove(strKey);
clsCheckVoiceTabWApi.objCommFun4BL.ReFreshCache();
}
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst_Cache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsCheckVoiceTabEN> GetObjLst_Cache()
{
//初始化列表缓存
InitListCache(); 
string strKey = string.Format("{0}", clsCheckVoiceTabEN._CurrTabName_S);
List<clsCheckVoiceTabEN> arrCheckVoiceTabObjLst_Cache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrCheckVoiceTabObjLst_Cache;
}

 /// <summary>
 /// 根据对象列表获取DataTable
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetDataTableByObjLst)
 /// </summary>
 /// <param name = "arrObjLst">给定的对象列表</param>
 /// <returns>返回DataTable</returns>
public static DataTable GetDataTableByObjLst(List<clsCheckVoiceTabEN> arrObjLst)
{
DataTable objDT = new DataTable();
objDT.Columns.Add(conCheckVoiceTab.mId, Type.GetType("System.Int64"));
objDT.Columns.Add(conCheckVoiceTab.UserId, Type.GetType("System.String"));
objDT.Columns.Add(conCheckVoiceTab.QuestionID, Type.GetType("System.String"));
objDT.Columns.Add(conCheckVoiceTab.YinBiaoId, Type.GetType("System.Int32"));
objDT.Columns.Add(conCheckVoiceTab.YinBiao, Type.GetType("System.String"));
objDT.Columns.Add(conCheckVoiceTab.FileName, Type.GetType("System.String"));
objDT.Columns.Add(conCheckVoiceTab.CheckResult, Type.GetType("System.String"));
objDT.Columns.Add(conCheckVoiceTab.IsChecked, Type.GetType("System.Boolean"));
objDT.Columns.Add(conCheckVoiceTab.IsRight, Type.GetType("System.Boolean"));
objDT.Columns.Add(conCheckVoiceTab.UpdUser, Type.GetType("System.String"));
objDT.Columns.Add(conCheckVoiceTab.UpdDate, Type.GetType("System.String"));
objDT.Columns.Add(conCheckVoiceTab.Memo, Type.GetType("System.String"));
foreach (clsCheckVoiceTabEN objInFor in arrObjLst)
{
DataRow objDR = objDT.NewRow();
objDR[conCheckVoiceTab.mId] = objInFor[conCheckVoiceTab.mId];
objDR[conCheckVoiceTab.UserId] = objInFor[conCheckVoiceTab.UserId];
objDR[conCheckVoiceTab.QuestionID] = objInFor[conCheckVoiceTab.QuestionID];
objDR[conCheckVoiceTab.YinBiaoId] = objInFor[conCheckVoiceTab.YinBiaoId];
objDR[conCheckVoiceTab.YinBiao] = objInFor[conCheckVoiceTab.YinBiao];
objDR[conCheckVoiceTab.FileName] = objInFor[conCheckVoiceTab.FileName];
objDR[conCheckVoiceTab.CheckResult] = objInFor[conCheckVoiceTab.CheckResult];
objDR[conCheckVoiceTab.IsChecked] = objInFor[conCheckVoiceTab.IsChecked];
objDR[conCheckVoiceTab.IsRight] = objInFor[conCheckVoiceTab.IsRight];
objDR[conCheckVoiceTab.UpdUser] = objInFor[conCheckVoiceTab.UpdUser];
objDR[conCheckVoiceTab.UpdDate] = objInFor[conCheckVoiceTab.UpdDate];
objDR[conCheckVoiceTab.Memo] = objInFor[conCheckVoiceTab.Memo];
objDT.Rows.Add(objDR);
}
return objDT;
}
}
 /// <summary>
 /// 检查语音(CheckVoiceTab)
 /// 数据源类型:SQL表
 /// (AutoGCLib.CommFun4WA4CSharp:GeneCode_This)
 /// </summary>
public class clsCommFun4WA4CheckVoiceTab : clsCommFun4BL
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
clsCheckVoiceTabWApi.ReFreshThisCache();
clsvCheckVoiceTabWApi.ReFreshThisCache();
}
}

}