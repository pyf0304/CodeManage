
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvCheckVoiceTabWApi
 表名:vCheckVoiceTab(01120353)
 生成代码版本:2021.09.20.1
 生成日期:2021/09/21 02:47:10
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
public static class clsvCheckVoiceTabWApi_Static
{

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCheckVoiceTabEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCheckVoiceTabEN SetmId(this clsvCheckVoiceTabEN objvCheckVoiceTabEN, long lngmId, string strComparisonOp="")
	{
objvCheckVoiceTabEN.mId = lngmId; //mId
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCheckVoiceTabEN.dicFldComparisonOp.ContainsKey(convCheckVoiceTab.mId) == false)
{
objvCheckVoiceTabEN.dicFldComparisonOp.Add(convCheckVoiceTab.mId, strComparisonOp);
}
else
{
objvCheckVoiceTabEN.dicFldComparisonOp[convCheckVoiceTab.mId] = strComparisonOp;
}
}
return objvCheckVoiceTabEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCheckVoiceTabEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCheckVoiceTabEN SetUserId(this clsvCheckVoiceTabEN objvCheckVoiceTabEN, string strUserId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUserId, 20, convCheckVoiceTab.UserId);
objvCheckVoiceTabEN.UserId = strUserId; //用户ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCheckVoiceTabEN.dicFldComparisonOp.ContainsKey(convCheckVoiceTab.UserId) == false)
{
objvCheckVoiceTabEN.dicFldComparisonOp.Add(convCheckVoiceTab.UserId, strComparisonOp);
}
else
{
objvCheckVoiceTabEN.dicFldComparisonOp[convCheckVoiceTab.UserId] = strComparisonOp;
}
}
return objvCheckVoiceTabEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCheckVoiceTabEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCheckVoiceTabEN SetQuestionID(this clsvCheckVoiceTabEN objvCheckVoiceTabEN, string strQuestionID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strQuestionID, 8, convCheckVoiceTab.QuestionID);
clsCheckSql.CheckFieldForeignKey(strQuestionID, 8, convCheckVoiceTab.QuestionID);
objvCheckVoiceTabEN.QuestionID = strQuestionID; //题目ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCheckVoiceTabEN.dicFldComparisonOp.ContainsKey(convCheckVoiceTab.QuestionID) == false)
{
objvCheckVoiceTabEN.dicFldComparisonOp.Add(convCheckVoiceTab.QuestionID, strComparisonOp);
}
else
{
objvCheckVoiceTabEN.dicFldComparisonOp[convCheckVoiceTab.QuestionID] = strComparisonOp;
}
}
return objvCheckVoiceTabEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCheckVoiceTabEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCheckVoiceTabEN SetQuestionName(this clsvCheckVoiceTabEN objvCheckVoiceTabEN, string strQuestionName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strQuestionName, 1000, convCheckVoiceTab.QuestionName);
objvCheckVoiceTabEN.QuestionName = strQuestionName; //题目名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCheckVoiceTabEN.dicFldComparisonOp.ContainsKey(convCheckVoiceTab.QuestionName) == false)
{
objvCheckVoiceTabEN.dicFldComparisonOp.Add(convCheckVoiceTab.QuestionName, strComparisonOp);
}
else
{
objvCheckVoiceTabEN.dicFldComparisonOp[convCheckVoiceTab.QuestionName] = strComparisonOp;
}
}
return objvCheckVoiceTabEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCheckVoiceTabEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCheckVoiceTabEN SetYinBiaoId(this clsvCheckVoiceTabEN objvCheckVoiceTabEN, int intYinBiaoId, string strComparisonOp="")
	{
objvCheckVoiceTabEN.YinBiaoId = intYinBiaoId; //音标Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCheckVoiceTabEN.dicFldComparisonOp.ContainsKey(convCheckVoiceTab.YinBiaoId) == false)
{
objvCheckVoiceTabEN.dicFldComparisonOp.Add(convCheckVoiceTab.YinBiaoId, strComparisonOp);
}
else
{
objvCheckVoiceTabEN.dicFldComparisonOp[convCheckVoiceTab.YinBiaoId] = strComparisonOp;
}
}
return objvCheckVoiceTabEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCheckVoiceTabEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCheckVoiceTabEN SetYinBiao(this clsvCheckVoiceTabEN objvCheckVoiceTabEN, string strYinBiao, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strYinBiao, 50, convCheckVoiceTab.YinBiao);
objvCheckVoiceTabEN.YinBiao = strYinBiao; //音标
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCheckVoiceTabEN.dicFldComparisonOp.ContainsKey(convCheckVoiceTab.YinBiao) == false)
{
objvCheckVoiceTabEN.dicFldComparisonOp.Add(convCheckVoiceTab.YinBiao, strComparisonOp);
}
else
{
objvCheckVoiceTabEN.dicFldComparisonOp[convCheckVoiceTab.YinBiao] = strComparisonOp;
}
}
return objvCheckVoiceTabEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCheckVoiceTabEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCheckVoiceTabEN SetFileName(this clsvCheckVoiceTabEN objvCheckVoiceTabEN, string strFileName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFileName, 500, convCheckVoiceTab.FileName);
objvCheckVoiceTabEN.FileName = strFileName; //文件名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCheckVoiceTabEN.dicFldComparisonOp.ContainsKey(convCheckVoiceTab.FileName) == false)
{
objvCheckVoiceTabEN.dicFldComparisonOp.Add(convCheckVoiceTab.FileName, strComparisonOp);
}
else
{
objvCheckVoiceTabEN.dicFldComparisonOp[convCheckVoiceTab.FileName] = strComparisonOp;
}
}
return objvCheckVoiceTabEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCheckVoiceTabEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCheckVoiceTabEN SetCheckResult(this clsvCheckVoiceTabEN objvCheckVoiceTabEN, string strCheckResult, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCheckResult, 1000, convCheckVoiceTab.CheckResult);
objvCheckVoiceTabEN.CheckResult = strCheckResult; //检查结果
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCheckVoiceTabEN.dicFldComparisonOp.ContainsKey(convCheckVoiceTab.CheckResult) == false)
{
objvCheckVoiceTabEN.dicFldComparisonOp.Add(convCheckVoiceTab.CheckResult, strComparisonOp);
}
else
{
objvCheckVoiceTabEN.dicFldComparisonOp[convCheckVoiceTab.CheckResult] = strComparisonOp;
}
}
return objvCheckVoiceTabEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCheckVoiceTabEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCheckVoiceTabEN SetIsChecked(this clsvCheckVoiceTabEN objvCheckVoiceTabEN, bool bolIsChecked, string strComparisonOp="")
	{
objvCheckVoiceTabEN.IsChecked = bolIsChecked; //是否检查
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCheckVoiceTabEN.dicFldComparisonOp.ContainsKey(convCheckVoiceTab.IsChecked) == false)
{
objvCheckVoiceTabEN.dicFldComparisonOp.Add(convCheckVoiceTab.IsChecked, strComparisonOp);
}
else
{
objvCheckVoiceTabEN.dicFldComparisonOp[convCheckVoiceTab.IsChecked] = strComparisonOp;
}
}
return objvCheckVoiceTabEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCheckVoiceTabEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCheckVoiceTabEN SetIsRight(this clsvCheckVoiceTabEN objvCheckVoiceTabEN, bool bolIsRight, string strComparisonOp="")
	{
objvCheckVoiceTabEN.IsRight = bolIsRight; //是否正确
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCheckVoiceTabEN.dicFldComparisonOp.ContainsKey(convCheckVoiceTab.IsRight) == false)
{
objvCheckVoiceTabEN.dicFldComparisonOp.Add(convCheckVoiceTab.IsRight, strComparisonOp);
}
else
{
objvCheckVoiceTabEN.dicFldComparisonOp[convCheckVoiceTab.IsRight] = strComparisonOp;
}
}
return objvCheckVoiceTabEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCheckVoiceTabEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCheckVoiceTabEN SetUpdUser(this clsvCheckVoiceTabEN objvCheckVoiceTabEN, string strUpdUser, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strUpdUser, convCheckVoiceTab.UpdUser);
clsCheckSql.CheckFieldLen(strUpdUser, 20, convCheckVoiceTab.UpdUser);
objvCheckVoiceTabEN.UpdUser = strUpdUser; //修改人
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCheckVoiceTabEN.dicFldComparisonOp.ContainsKey(convCheckVoiceTab.UpdUser) == false)
{
objvCheckVoiceTabEN.dicFldComparisonOp.Add(convCheckVoiceTab.UpdUser, strComparisonOp);
}
else
{
objvCheckVoiceTabEN.dicFldComparisonOp[convCheckVoiceTab.UpdUser] = strComparisonOp;
}
}
return objvCheckVoiceTabEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCheckVoiceTabEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCheckVoiceTabEN SetUpdDate(this clsvCheckVoiceTabEN objvCheckVoiceTabEN, string strUpdDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strUpdDate, convCheckVoiceTab.UpdDate);
clsCheckSql.CheckFieldLen(strUpdDate, 20, convCheckVoiceTab.UpdDate);
objvCheckVoiceTabEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCheckVoiceTabEN.dicFldComparisonOp.ContainsKey(convCheckVoiceTab.UpdDate) == false)
{
objvCheckVoiceTabEN.dicFldComparisonOp.Add(convCheckVoiceTab.UpdDate, strComparisonOp);
}
else
{
objvCheckVoiceTabEN.dicFldComparisonOp[convCheckVoiceTab.UpdDate] = strComparisonOp;
}
}
return objvCheckVoiceTabEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCheckVoiceTabEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCheckVoiceTabEN SetMemo(this clsvCheckVoiceTabEN objvCheckVoiceTabEN, string strMemo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMemo, 1000, convCheckVoiceTab.Memo);
objvCheckVoiceTabEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCheckVoiceTabEN.dicFldComparisonOp.ContainsKey(convCheckVoiceTab.Memo) == false)
{
objvCheckVoiceTabEN.dicFldComparisonOp.Add(convCheckVoiceTab.Memo, strComparisonOp);
}
else
{
objvCheckVoiceTabEN.dicFldComparisonOp[convCheckVoiceTab.Memo] = strComparisonOp;
}
}
return objvCheckVoiceTabEN;
	}

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvCheckVoiceTabEN objvCheckVoiceTab_Cond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvCheckVoiceTab_Cond.IsUpdated(convCheckVoiceTab.mId) == true)
{
string strComparisonOp_mId = objvCheckVoiceTab_Cond.dicFldComparisonOp[convCheckVoiceTab.mId];
strWhereCond += string.Format(" And {0} {2} {1}", convCheckVoiceTab.mId, objvCheckVoiceTab_Cond.mId, strComparisonOp_mId);
}
if (objvCheckVoiceTab_Cond.IsUpdated(convCheckVoiceTab.UserId) == true)
{
string strComparisonOp_UserId = objvCheckVoiceTab_Cond.dicFldComparisonOp[convCheckVoiceTab.UserId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCheckVoiceTab.UserId, objvCheckVoiceTab_Cond.UserId, strComparisonOp_UserId);
}
if (objvCheckVoiceTab_Cond.IsUpdated(convCheckVoiceTab.QuestionID) == true)
{
string strComparisonOp_QuestionID = objvCheckVoiceTab_Cond.dicFldComparisonOp[convCheckVoiceTab.QuestionID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCheckVoiceTab.QuestionID, objvCheckVoiceTab_Cond.QuestionID, strComparisonOp_QuestionID);
}
if (objvCheckVoiceTab_Cond.IsUpdated(convCheckVoiceTab.QuestionName) == true)
{
string strComparisonOp_QuestionName = objvCheckVoiceTab_Cond.dicFldComparisonOp[convCheckVoiceTab.QuestionName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCheckVoiceTab.QuestionName, objvCheckVoiceTab_Cond.QuestionName, strComparisonOp_QuestionName);
}
if (objvCheckVoiceTab_Cond.IsUpdated(convCheckVoiceTab.YinBiaoId) == true)
{
string strComparisonOp_YinBiaoId = objvCheckVoiceTab_Cond.dicFldComparisonOp[convCheckVoiceTab.YinBiaoId];
strWhereCond += string.Format(" And {0} {2} {1}", convCheckVoiceTab.YinBiaoId, objvCheckVoiceTab_Cond.YinBiaoId, strComparisonOp_YinBiaoId);
}
if (objvCheckVoiceTab_Cond.IsUpdated(convCheckVoiceTab.YinBiao) == true)
{
string strComparisonOp_YinBiao = objvCheckVoiceTab_Cond.dicFldComparisonOp[convCheckVoiceTab.YinBiao];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCheckVoiceTab.YinBiao, objvCheckVoiceTab_Cond.YinBiao, strComparisonOp_YinBiao);
}
if (objvCheckVoiceTab_Cond.IsUpdated(convCheckVoiceTab.FileName) == true)
{
string strComparisonOp_FileName = objvCheckVoiceTab_Cond.dicFldComparisonOp[convCheckVoiceTab.FileName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCheckVoiceTab.FileName, objvCheckVoiceTab_Cond.FileName, strComparisonOp_FileName);
}
if (objvCheckVoiceTab_Cond.IsUpdated(convCheckVoiceTab.CheckResult) == true)
{
string strComparisonOp_CheckResult = objvCheckVoiceTab_Cond.dicFldComparisonOp[convCheckVoiceTab.CheckResult];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCheckVoiceTab.CheckResult, objvCheckVoiceTab_Cond.CheckResult, strComparisonOp_CheckResult);
}
if (objvCheckVoiceTab_Cond.IsUpdated(convCheckVoiceTab.IsChecked) == true)
{
if (objvCheckVoiceTab_Cond.IsChecked == true)
{
strWhereCond += string.Format(" And {0} = '1'", convCheckVoiceTab.IsChecked);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convCheckVoiceTab.IsChecked);
}
}
if (objvCheckVoiceTab_Cond.IsUpdated(convCheckVoiceTab.IsRight) == true)
{
if (objvCheckVoiceTab_Cond.IsRight == true)
{
strWhereCond += string.Format(" And {0} = '1'", convCheckVoiceTab.IsRight);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convCheckVoiceTab.IsRight);
}
}
if (objvCheckVoiceTab_Cond.IsUpdated(convCheckVoiceTab.UpdUser) == true)
{
string strComparisonOp_UpdUser = objvCheckVoiceTab_Cond.dicFldComparisonOp[convCheckVoiceTab.UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCheckVoiceTab.UpdUser, objvCheckVoiceTab_Cond.UpdUser, strComparisonOp_UpdUser);
}
if (objvCheckVoiceTab_Cond.IsUpdated(convCheckVoiceTab.UpdDate) == true)
{
string strComparisonOp_UpdDate = objvCheckVoiceTab_Cond.dicFldComparisonOp[convCheckVoiceTab.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCheckVoiceTab.UpdDate, objvCheckVoiceTab_Cond.UpdDate, strComparisonOp_UpdDate);
}
if (objvCheckVoiceTab_Cond.IsUpdated(convCheckVoiceTab.Memo) == true)
{
string strComparisonOp_Memo = objvCheckVoiceTab_Cond.dicFldComparisonOp[convCheckVoiceTab.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCheckVoiceTab.Memo, objvCheckVoiceTab_Cond.Memo, strComparisonOp_Memo);
}
 return strWhereCond;
}
}
 /// <summary>
 /// v检查语音(vCheckVoiceTab)
 /// (AutoGCLib.WA_Access4CSharp:GeneCode)
 /// </summary>
public class clsvCheckVoiceTabWApi
{
private static readonly string mstrApiControllerName = "vCheckVoiceTabApi";

 public clsvCheckVoiceTabWApi()
 {
 }

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyId)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvCheckVoiceTabEN GetObjBymId(long lngmId)
{
string strAction = "GetObjBymId";
string strErrMsg = string.Empty;
string strResult = "";
clsvCheckVoiceTabEN objvCheckVoiceTabEN = null;
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
objvCheckVoiceTabEN = JsonConvert.DeserializeObject<clsvCheckVoiceTabEN>((string)jobjReturn["ReturnObj"]);
return objvCheckVoiceTabEN;
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
public static clsvCheckVoiceTabEN GetObjBymId_WA_Cache(long lngmId)
{
string strAction = "GetObjBymId_Cache";
string strErrMsg = string.Empty;
string strResult = "";
clsvCheckVoiceTabEN objvCheckVoiceTabEN = null;
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
objvCheckVoiceTabEN = JsonConvert.DeserializeObject<clsvCheckVoiceTabEN>((string)jobjReturn["ReturnObj"]);
return objvCheckVoiceTabEN;
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
public static clsvCheckVoiceTabEN GetFirstObj(string strWhereCond)
{
string strAction = "GetFirstObj";
string strErrMsg = string.Empty;
string strResult = "";
clsvCheckVoiceTabEN objvCheckVoiceTabEN = null;
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
objvCheckVoiceTabEN = JsonConvert.DeserializeObject<clsvCheckVoiceTabEN>((string)jobjReturn["ReturnObj"]);
return objvCheckVoiceTabEN;
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
public static clsvCheckVoiceTabEN GetObjBymId_Cache(long lngmId)
{
//初始化列表缓存
string strKey = string.Format("{0}", clsvCheckVoiceTabEN._CurrTabName_S);
List<clsvCheckVoiceTabEN> arrvCheckVoiceTabObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsvCheckVoiceTabEN> arrvCheckVoiceTabObjLst_Sel =
from objvCheckVoiceTabEN in arrvCheckVoiceTabObjLst_Cache
where objvCheckVoiceTabEN.mId == lngmId
select objvCheckVoiceTabEN;
if (arrvCheckVoiceTabObjLst_Sel.Count() == 0)
{
   clsvCheckVoiceTabEN obj = clsvCheckVoiceTabWApi.GetObjBymId(lngmId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
     return obj;
 }
return null;
}
return arrvCheckVoiceTabObjLst_Sel.First();
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvCheckVoiceTabEN> GetObjLst(string strWhereCond)
{
 List<clsvCheckVoiceTabEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvCheckVoiceTabEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvCheckVoiceTabEN> GetObjLstByMIdLst(List<long> arrMId)
{
 List<clsvCheckVoiceTabEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvCheckVoiceTabEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static IEnumerable<clsvCheckVoiceTabEN> GetObjLstByMIdLst_Cache(List<long> arrMId)
{
//初始化列表缓存
string strKey = string.Format("{0}", clsvCheckVoiceTabEN._CurrTabName_S);
List<clsvCheckVoiceTabEN> arrvCheckVoiceTabObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsvCheckVoiceTabEN> arrvCheckVoiceTabObjLst_Sel =
from objvCheckVoiceTabEN in arrvCheckVoiceTabObjLst_Cache
where arrMId.Contains(objvCheckVoiceTabEN.mId)
select objvCheckVoiceTabEN;
return arrvCheckVoiceTabObjLst_Sel;
}

 /// <summary>
 /// 根据关键字列表获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstByKeyLst_WA_Cache)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvCheckVoiceTabEN> GetObjLstByMIdLst_WA_Cache(List<long> arrMId)
{
 List<clsvCheckVoiceTabEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvCheckVoiceTabEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvCheckVoiceTabEN> GetTopObjLst(stuTopPara objTopPara)
{
 List<clsvCheckVoiceTabEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvCheckVoiceTabEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvCheckVoiceTabEN> GetObjLstByRange(stuRangePara objRangePara)
{
 List<clsvCheckVoiceTabEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvCheckVoiceTabEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvCheckVoiceTabEN> GetObjLstByPager(stuPagerPara objPagerPara)
{
 List<clsvCheckVoiceTabEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvCheckVoiceTabEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvCheckVoiceTabEN> GetObjLstByPager_Cache(stuPagerPara objPagerPara)
{
 List<clsvCheckVoiceTabEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvCheckVoiceTabEN>>((string)jobjReturn["ReturnObjLst"]);
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
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_CopyObj_S)
 /// </summary>
 /// <param name = "objvCheckVoiceTabENS">源对象</param>
 /// <param name = "objvCheckVoiceTabENT">目标对象</param>
 public static void CopyTo(clsvCheckVoiceTabEN objvCheckVoiceTabENS, clsvCheckVoiceTabEN objvCheckVoiceTabENT)
{
try
{
objvCheckVoiceTabENT.mId = objvCheckVoiceTabENS.mId; //mId
objvCheckVoiceTabENT.UserId = objvCheckVoiceTabENS.UserId; //用户ID
objvCheckVoiceTabENT.QuestionID = objvCheckVoiceTabENS.QuestionID; //题目ID
objvCheckVoiceTabENT.QuestionName = objvCheckVoiceTabENS.QuestionName; //题目名称
objvCheckVoiceTabENT.YinBiaoId = objvCheckVoiceTabENS.YinBiaoId; //音标Id
objvCheckVoiceTabENT.YinBiao = objvCheckVoiceTabENS.YinBiao; //音标
objvCheckVoiceTabENT.FileName = objvCheckVoiceTabENS.FileName; //文件名称
objvCheckVoiceTabENT.CheckResult = objvCheckVoiceTabENS.CheckResult; //检查结果
objvCheckVoiceTabENT.IsChecked = objvCheckVoiceTabENS.IsChecked; //是否检查
objvCheckVoiceTabENT.IsRight = objvCheckVoiceTabENS.IsRight; //是否正确
objvCheckVoiceTabENT.UpdUser = objvCheckVoiceTabENS.UpdUser; //修改人
objvCheckVoiceTabENT.UpdDate = objvCheckVoiceTabENS.UpdDate; //修改日期
objvCheckVoiceTabENT.Memo = objvCheckVoiceTabENS.Memo; //备注
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
public static DataTable ToDataTable(List<clsvCheckVoiceTabEN> arrObj)
{
DataTable dataTable = new DataTable(); //实例化
DataTable result;
if (arrObj.Count == 0) return null;
if (clsvCheckVoiceTabEN.AttributeName.Length == 0)
{
result = dataTable;
return result;
}
Type type = typeof(clsvCheckVoiceTabEN);
PropertyInfo[] arrPropertyInfo = type.GetProperties();
try
{
//Columns
foreach (string strAttrName in clsvCheckVoiceTabEN.AttributeName)
{
PropertyInfo proprety_Curr = arrPropertyInfo.Where(x => x.Name == strAttrName).First();
dataTable.Columns.Add(strAttrName, proprety_Curr.PropertyType);
}
foreach (clsvCheckVoiceTabEN objInFor in arrObj)
{
//Rows
DataRow dataRow = dataTable.NewRow();
foreach (string strAttrName in clsvCheckVoiceTabEN.AttributeName)
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
if (clsQuestionnaireWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsQuestionnaireWApi没有刷新缓存机制(clsQuestionnaireWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsCheckVoiceTabWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsCheckVoiceTabWApi没有刷新缓存机制(clsCheckVoiceTabWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by mId");
//if (arrvCheckVoiceTabObjLst_Cache == null)
//{
//arrvCheckVoiceTabObjLst_Cache = await clsvCheckVoiceTabWApi.GetObjLst(strWhereCond);
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
string strKey = string.Format("{0}", clsvCheckVoiceTabEN._CurrTabName_S);
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
public static List<clsvCheckVoiceTabEN> GetObjLst_Cache()
{
//初始化列表缓存
InitListCache(); 
string strKey = string.Format("{0}", clsvCheckVoiceTabEN._CurrTabName_S);
List<clsvCheckVoiceTabEN> arrvCheckVoiceTabObjLst_Cache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrvCheckVoiceTabObjLst_Cache;
}

 /// <summary>
 /// 根据对象列表获取DataTable
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetDataTableByObjLst)
 /// </summary>
 /// <param name = "arrObjLst">给定的对象列表</param>
 /// <returns>返回DataTable</returns>
public static DataTable GetDataTableByObjLst(List<clsvCheckVoiceTabEN> arrObjLst)
{
DataTable objDT = new DataTable();
objDT.Columns.Add(convCheckVoiceTab.mId, Type.GetType("System.Int64"));
objDT.Columns.Add(convCheckVoiceTab.UserId, Type.GetType("System.String"));
objDT.Columns.Add(convCheckVoiceTab.QuestionID, Type.GetType("System.String"));
objDT.Columns.Add(convCheckVoiceTab.QuestionName, Type.GetType("System.String"));
objDT.Columns.Add(convCheckVoiceTab.YinBiaoId, Type.GetType("System.Int32"));
objDT.Columns.Add(convCheckVoiceTab.YinBiao, Type.GetType("System.String"));
objDT.Columns.Add(convCheckVoiceTab.FileName, Type.GetType("System.String"));
objDT.Columns.Add(convCheckVoiceTab.CheckResult, Type.GetType("System.String"));
objDT.Columns.Add(convCheckVoiceTab.IsChecked, Type.GetType("System.Boolean"));
objDT.Columns.Add(convCheckVoiceTab.IsRight, Type.GetType("System.Boolean"));
objDT.Columns.Add(convCheckVoiceTab.UpdUser, Type.GetType("System.String"));
objDT.Columns.Add(convCheckVoiceTab.UpdDate, Type.GetType("System.String"));
objDT.Columns.Add(convCheckVoiceTab.Memo, Type.GetType("System.String"));
foreach (clsvCheckVoiceTabEN objInFor in arrObjLst)
{
DataRow objDR = objDT.NewRow();
objDR[convCheckVoiceTab.mId] = objInFor[convCheckVoiceTab.mId];
objDR[convCheckVoiceTab.UserId] = objInFor[convCheckVoiceTab.UserId];
objDR[convCheckVoiceTab.QuestionID] = objInFor[convCheckVoiceTab.QuestionID];
objDR[convCheckVoiceTab.QuestionName] = objInFor[convCheckVoiceTab.QuestionName];
objDR[convCheckVoiceTab.YinBiaoId] = objInFor[convCheckVoiceTab.YinBiaoId];
objDR[convCheckVoiceTab.YinBiao] = objInFor[convCheckVoiceTab.YinBiao];
objDR[convCheckVoiceTab.FileName] = objInFor[convCheckVoiceTab.FileName];
objDR[convCheckVoiceTab.CheckResult] = objInFor[convCheckVoiceTab.CheckResult];
objDR[convCheckVoiceTab.IsChecked] = objInFor[convCheckVoiceTab.IsChecked];
objDR[convCheckVoiceTab.IsRight] = objInFor[convCheckVoiceTab.IsRight];
objDR[convCheckVoiceTab.UpdUser] = objInFor[convCheckVoiceTab.UpdUser];
objDR[convCheckVoiceTab.UpdDate] = objInFor[convCheckVoiceTab.UpdDate];
objDR[convCheckVoiceTab.Memo] = objInFor[convCheckVoiceTab.Memo];
objDT.Rows.Add(objDR);
}
return objDT;
}
}
}