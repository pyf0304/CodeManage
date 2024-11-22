
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsQuestionTypeWApi
 表名:QuestionType(01120008)
 生成代码版本:2021.09.20.1
 生成日期:2021/09/21 02:47:47
 生成者:pyf
 生成服务器IP:103.116.76.183
 工程名称:问卷调查
 工程ID:0112
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:系统参数
 模块英文名:SysPara
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
public static class clsQuestionTypeWApi_Static
{

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQuestionTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsQuestionTypeEN SetQuestionTypeId(this clsQuestionTypeEN objQuestionTypeEN, string strQuestionTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strQuestionTypeId, 2, conQuestionType.QuestionTypeId);
clsCheckSql.CheckFieldForeignKey(strQuestionTypeId, 2, conQuestionType.QuestionTypeId);
objQuestionTypeEN.QuestionTypeId = strQuestionTypeId; //题目类型Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQuestionTypeEN.dicFldComparisonOp.ContainsKey(conQuestionType.QuestionTypeId) == false)
{
objQuestionTypeEN.dicFldComparisonOp.Add(conQuestionType.QuestionTypeId, strComparisonOp);
}
else
{
objQuestionTypeEN.dicFldComparisonOp[conQuestionType.QuestionTypeId] = strComparisonOp;
}
}
return objQuestionTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQuestionTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsQuestionTypeEN SetQuestionTypeName(this clsQuestionTypeEN objQuestionTypeEN, string strQuestionTypeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strQuestionTypeName, conQuestionType.QuestionTypeName);
clsCheckSql.CheckFieldLen(strQuestionTypeName, 20, conQuestionType.QuestionTypeName);
objQuestionTypeEN.QuestionTypeName = strQuestionTypeName; //题目类型名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQuestionTypeEN.dicFldComparisonOp.ContainsKey(conQuestionType.QuestionTypeName) == false)
{
objQuestionTypeEN.dicFldComparisonOp.Add(conQuestionType.QuestionTypeName, strComparisonOp);
}
else
{
objQuestionTypeEN.dicFldComparisonOp[conQuestionType.QuestionTypeName] = strComparisonOp;
}
}
return objQuestionTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQuestionTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsQuestionTypeEN SetQuestionTypeENName(this clsQuestionTypeEN objQuestionTypeEN, string strQuestionTypeENName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strQuestionTypeENName, 50, conQuestionType.QuestionTypeENName);
objQuestionTypeEN.QuestionTypeENName = strQuestionTypeENName; //题目类型英文名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQuestionTypeEN.dicFldComparisonOp.ContainsKey(conQuestionType.QuestionTypeENName) == false)
{
objQuestionTypeEN.dicFldComparisonOp.Add(conQuestionType.QuestionTypeENName, strComparisonOp);
}
else
{
objQuestionTypeEN.dicFldComparisonOp[conQuestionType.QuestionTypeENName] = strComparisonOp;
}
}
return objQuestionTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQuestionTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsQuestionTypeEN SetDefaAnswerModeId(this clsQuestionTypeEN objQuestionTypeEN, string strDefaAnswerModeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strDefaAnswerModeId, 4, conQuestionType.DefaAnswerModeId);
clsCheckSql.CheckFieldForeignKey(strDefaAnswerModeId, 4, conQuestionType.DefaAnswerModeId);
objQuestionTypeEN.DefaAnswerModeId = strDefaAnswerModeId; //默认答案模式Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQuestionTypeEN.dicFldComparisonOp.ContainsKey(conQuestionType.DefaAnswerModeId) == false)
{
objQuestionTypeEN.dicFldComparisonOp.Add(conQuestionType.DefaAnswerModeId, strComparisonOp);
}
else
{
objQuestionTypeEN.dicFldComparisonOp[conQuestionType.DefaAnswerModeId] = strComparisonOp;
}
}
return objQuestionTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQuestionTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsQuestionTypeEN SetDefaAnswerTypeId(this clsQuestionTypeEN objQuestionTypeEN, string strDefaAnswerTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strDefaAnswerTypeId, 2, conQuestionType.DefaAnswerTypeId);
clsCheckSql.CheckFieldForeignKey(strDefaAnswerTypeId, 2, conQuestionType.DefaAnswerTypeId);
objQuestionTypeEN.DefaAnswerTypeId = strDefaAnswerTypeId; //默认答案类型Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQuestionTypeEN.dicFldComparisonOp.ContainsKey(conQuestionType.DefaAnswerTypeId) == false)
{
objQuestionTypeEN.dicFldComparisonOp.Add(conQuestionType.DefaAnswerTypeId, strComparisonOp);
}
else
{
objQuestionTypeEN.dicFldComparisonOp[conQuestionType.DefaAnswerTypeId] = strComparisonOp;
}
}
return objQuestionTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQuestionTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsQuestionTypeEN SetOrderNum(this clsQuestionTypeEN objQuestionTypeEN, int intOrderNum, string strComparisonOp="")
	{
objQuestionTypeEN.OrderNum = intOrderNum; //序号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQuestionTypeEN.dicFldComparisonOp.ContainsKey(conQuestionType.OrderNum) == false)
{
objQuestionTypeEN.dicFldComparisonOp.Add(conQuestionType.OrderNum, strComparisonOp);
}
else
{
objQuestionTypeEN.dicFldComparisonOp[conQuestionType.OrderNum] = strComparisonOp;
}
}
return objQuestionTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQuestionTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsQuestionTypeEN SetIsUse(this clsQuestionTypeEN objQuestionTypeEN, bool bolIsUse, string strComparisonOp="")
	{
objQuestionTypeEN.IsUse = bolIsUse; //是否使用
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQuestionTypeEN.dicFldComparisonOp.ContainsKey(conQuestionType.IsUse) == false)
{
objQuestionTypeEN.dicFldComparisonOp.Add(conQuestionType.IsUse, strComparisonOp);
}
else
{
objQuestionTypeEN.dicFldComparisonOp[conQuestionType.IsUse] = strComparisonOp;
}
}
return objQuestionTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQuestionTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsQuestionTypeEN SetUpdDate(this clsQuestionTypeEN objQuestionTypeEN, string strUpdDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strUpdDate, conQuestionType.UpdDate);
clsCheckSql.CheckFieldLen(strUpdDate, 20, conQuestionType.UpdDate);
objQuestionTypeEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQuestionTypeEN.dicFldComparisonOp.ContainsKey(conQuestionType.UpdDate) == false)
{
objQuestionTypeEN.dicFldComparisonOp.Add(conQuestionType.UpdDate, strComparisonOp);
}
else
{
objQuestionTypeEN.dicFldComparisonOp[conQuestionType.UpdDate] = strComparisonOp;
}
}
return objQuestionTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQuestionTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsQuestionTypeEN SetUpdUser(this clsQuestionTypeEN objQuestionTypeEN, string strUpdUser, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strUpdUser, conQuestionType.UpdUser);
clsCheckSql.CheckFieldLen(strUpdUser, 20, conQuestionType.UpdUser);
objQuestionTypeEN.UpdUser = strUpdUser; //修改人
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQuestionTypeEN.dicFldComparisonOp.ContainsKey(conQuestionType.UpdUser) == false)
{
objQuestionTypeEN.dicFldComparisonOp.Add(conQuestionType.UpdUser, strComparisonOp);
}
else
{
objQuestionTypeEN.dicFldComparisonOp[conQuestionType.UpdUser] = strComparisonOp;
}
}
return objQuestionTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQuestionTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsQuestionTypeEN SetMemo(this clsQuestionTypeEN objQuestionTypeEN, string strMemo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMemo, 1000, conQuestionType.Memo);
objQuestionTypeEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQuestionTypeEN.dicFldComparisonOp.ContainsKey(conQuestionType.Memo) == false)
{
objQuestionTypeEN.dicFldComparisonOp.Add(conQuestionType.Memo, strComparisonOp);
}
else
{
objQuestionTypeEN.dicFldComparisonOp[conQuestionType.Memo] = strComparisonOp;
}
}
return objQuestionTypeEN;
	}

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsQuestionTypeEN objQuestionType_Cond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objQuestionType_Cond.IsUpdated(conQuestionType.QuestionTypeId) == true)
{
string strComparisonOp_QuestionTypeId = objQuestionType_Cond.dicFldComparisonOp[conQuestionType.QuestionTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conQuestionType.QuestionTypeId, objQuestionType_Cond.QuestionTypeId, strComparisonOp_QuestionTypeId);
}
if (objQuestionType_Cond.IsUpdated(conQuestionType.QuestionTypeName) == true)
{
string strComparisonOp_QuestionTypeName = objQuestionType_Cond.dicFldComparisonOp[conQuestionType.QuestionTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", conQuestionType.QuestionTypeName, objQuestionType_Cond.QuestionTypeName, strComparisonOp_QuestionTypeName);
}
if (objQuestionType_Cond.IsUpdated(conQuestionType.QuestionTypeENName) == true)
{
string strComparisonOp_QuestionTypeENName = objQuestionType_Cond.dicFldComparisonOp[conQuestionType.QuestionTypeENName];
strWhereCond += string.Format(" And {0} {2} '{1}'", conQuestionType.QuestionTypeENName, objQuestionType_Cond.QuestionTypeENName, strComparisonOp_QuestionTypeENName);
}
if (objQuestionType_Cond.IsUpdated(conQuestionType.DefaAnswerModeId) == true)
{
string strComparisonOp_DefaAnswerModeId = objQuestionType_Cond.dicFldComparisonOp[conQuestionType.DefaAnswerModeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conQuestionType.DefaAnswerModeId, objQuestionType_Cond.DefaAnswerModeId, strComparisonOp_DefaAnswerModeId);
}
if (objQuestionType_Cond.IsUpdated(conQuestionType.DefaAnswerTypeId) == true)
{
string strComparisonOp_DefaAnswerTypeId = objQuestionType_Cond.dicFldComparisonOp[conQuestionType.DefaAnswerTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conQuestionType.DefaAnswerTypeId, objQuestionType_Cond.DefaAnswerTypeId, strComparisonOp_DefaAnswerTypeId);
}
if (objQuestionType_Cond.IsUpdated(conQuestionType.OrderNum) == true)
{
string strComparisonOp_OrderNum = objQuestionType_Cond.dicFldComparisonOp[conQuestionType.OrderNum];
strWhereCond += string.Format(" And {0} {2} {1}", conQuestionType.OrderNum, objQuestionType_Cond.OrderNum, strComparisonOp_OrderNum);
}
if (objQuestionType_Cond.IsUpdated(conQuestionType.IsUse) == true)
{
if (objQuestionType_Cond.IsUse == true)
{
strWhereCond += string.Format(" And {0} = '1'", conQuestionType.IsUse);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conQuestionType.IsUse);
}
}
if (objQuestionType_Cond.IsUpdated(conQuestionType.UpdDate) == true)
{
string strComparisonOp_UpdDate = objQuestionType_Cond.dicFldComparisonOp[conQuestionType.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conQuestionType.UpdDate, objQuestionType_Cond.UpdDate, strComparisonOp_UpdDate);
}
if (objQuestionType_Cond.IsUpdated(conQuestionType.UpdUser) == true)
{
string strComparisonOp_UpdUser = objQuestionType_Cond.dicFldComparisonOp[conQuestionType.UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", conQuestionType.UpdUser, objQuestionType_Cond.UpdUser, strComparisonOp_UpdUser);
}
if (objQuestionType_Cond.IsUpdated(conQuestionType.Memo) == true)
{
string strComparisonOp_Memo = objQuestionType_Cond.dicFldComparisonOp[conQuestionType.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", conQuestionType.Memo, objQuestionType_Cond.Memo, strComparisonOp_Memo);
}
 return strWhereCond;
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_Update)
 /// </summary>
 /// <param name = "objQuestionTypeEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsQuestionTypeEN objQuestionTypeEN)
{
 if (string.IsNullOrEmpty(objQuestionTypeEN.QuestionTypeId) == true)
 {
string strMsg = string.Format("(errid:Watl000003)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
objQuestionTypeEN.sf_UpdFldSetStr = objQuestionTypeEN.getsf_UpdFldSetStr();
clsQuestionTypeWApi.CheckPropertyNew(objQuestionTypeEN); 
bool bolResult = clsQuestionTypeWApi.UpdateRecord(objQuestionTypeEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsQuestionTypeWApi.ReFreshCache();
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
 /// <param name = "objQuestionTypeEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clsQuestionTypeEN objQuestionTypeEN)
{
 if (string.IsNullOrEmpty(objQuestionTypeEN.QuestionTypeId) == true)
 {
string strMsg = string.Format("添加记录时，关键字不能为空!(from {0})\r\n", 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
 if (clsQuestionTypeWApi.IsExist(objQuestionTypeEN.QuestionTypeId) == true)
 {
string strMsg = string.Format("添加记录时，关键字:[{0}]已经存在!(from {1})\r\n", objQuestionTypeEN.QuestionTypeId, 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
try
{
clsQuestionTypeWApi.CheckPropertyNew(objQuestionTypeEN); 
bool bolResult = clsQuestionTypeWApi.AddNewRecord(objQuestionTypeEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsQuestionTypeWApi.ReFreshCache();
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
 /// <param name = "objQuestionTypeEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static string AddNewRecordWithMaxId(this clsQuestionTypeEN objQuestionTypeEN)
{
try
{
clsQuestionTypeWApi.CheckPropertyNew(objQuestionTypeEN); 
string strQuestionTypeId = clsQuestionTypeWApi.AddNewRecordWithMaxId(objQuestionTypeEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsQuestionTypeWApi.ReFreshCache();
return strQuestionTypeId;
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
 /// <param name = "objQuestionTypeEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsQuestionTypeEN objQuestionTypeEN, string strWhereCond)
{
try
{
clsQuestionTypeWApi.CheckPropertyNew(objQuestionTypeEN); 
bool bolResult = clsQuestionTypeWApi.UpdateWithCondition(objQuestionTypeEN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsQuestionTypeWApi.ReFreshCache();
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
 /// 根据表内容设置enum列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GeneEnumConstList)
 /// </summary>
public class enumQuestionTypeWA
{
 /// <summary>
 /// 填空题
 /// </summary>
public const string FillInBlank_01 = "01";
 /// <summary>
 /// 单选题
 /// </summary>
public const string SingleTopic_02 = "02";
 /// <summary>
 /// 多选题
 /// </summary>
public const string MultipleChoice_03 = "03";
 /// <summary>
 /// 开放题
 /// </summary>
public const string OpenQuestion_04 = "04";
 /// <summary>
 /// 解答题
 /// </summary>
public const string AnswerQuestions_05 = "05";
 /// <summary>
 /// 标题
 /// </summary>
public const string Title_06 = "06";
 /// <summary>
 /// 说明性内容
 /// </summary>
public const string ExplanatoryContent_07 = "07";
 /// <summary>
 /// 单选题(下拉框)
 /// </summary>
public const string SingleTopic_DropDownBox_08 = "08";
 /// <summary>
 /// 操作题
 /// </summary>
public const string OperationQuestions_09 = "09";
 /// <summary>
 /// 简答题
 /// </summary>
public const string ShortAnswer_10 = "10";
 /// <summary>
 /// 判断题
 /// </summary>
public const string TrueorFalse_11 = "11";
 /// <summary>
 /// 案例分析题
 /// </summary>
public const string CaseAnysisMultiChoice_12 = "12";
 /// <summary>
 /// 录音分析题
 /// </summary>
public const string RecorderAndAnysis_13 = "13";
 /// <summary>
 /// 知识结构图
 /// </summary>
public const string KnowledgeStructureDiagram_14 = "14";
 /// <summary>
 /// 知识逻辑关系图
 /// </summary>
public const string KnowledgeLogicDiagram_15 = "15";
 /// <summary>
 /// 连连看多选题
 /// </summary>
public const string LianliankanMultipleChoiceQuestions_17 = "17";
 /// <summary>
 /// 概念题
 /// </summary>
public const string ConceptQuestion_18 = "18";
}
 /// <summary>
 /// 题目类型(QuestionType)
 /// (AutoGCLib.WA_Access4CSharp:GeneCode)
 /// </summary>
public class clsQuestionTypeWApi
{
private static readonly string mstrApiControllerName = "QuestionTypeApi";

 /// <summary>
/// 专门在逻辑层用于处理缓存等公共函数的对象
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_DefineObjCommFun4BL)
/// </summary>
public static clsCommFun4BL objCommFun4BL = null;

 public clsQuestionTypeWApi()
 {
 }

 /// <summary>
 /// 绑定基于Web的下拉框
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_DdlBindFunction)
 /// </summary>
 /// <param name="objDDL">需要绑定当前表的下拉框</param>
public static void BindDdl_QuestionTypeId(System.Web.UI.WebControls.DropDownList objDDL)
{
//为数据源于表的下拉框设置内容
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[题目类型]...","0");
List<clsQuestionTypeEN> arrObjLst = GetObjLst("1=1");
objDDL.DataValueField="QuestionTypeId";
objDDL.DataTextField="QuestionTypeName";
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
public static void BindCbo_QuestionTypeId(System.Windows.Forms.ComboBox objComboBox )
{
//为数据源为表的下拉框设置内容
string strCondition = string.Format("1 =1 Order By {0}", conQuestionType.QuestionTypeId); 
List<clsQuestionTypeEN> arrObjLst = clsQuestionTypeWApi.GetObjLst(strCondition);
//初始化一个对象列表
//插入第0项。在第0项中插入“请选择...”,为了方便用户,与WEB方式类似。
clsQuestionTypeEN objQuestionTypeEN = new clsQuestionTypeEN()
{
QuestionTypeId = "0",
QuestionTypeName = "选[题目类型]..."
};
arrObjLst.Insert(0, objQuestionTypeEN);
//设置下拉框的数据源、以及设置值项、显示项
objComboBox.ValueMember = conQuestionType.QuestionTypeId;
objComboBox.DisplayMember = conQuestionType.QuestionTypeName;
objComboBox.DataSource = arrObjLst;
objComboBox.SelectedIndex = 0;
}

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_CheckPropertyNew)
 /// </summary>
public static void CheckPropertyNew(clsQuestionTypeEN objQuestionTypeEN)
{
if (!Object.Equals(null, objQuestionTypeEN.QuestionTypeId) && GetStrLen(objQuestionTypeEN.QuestionTypeId) > 2)
{
 throw new Exception("字段[题目类型Id]的长度不能超过2!");
}
if (!Object.Equals(null, objQuestionTypeEN.QuestionTypeName) && GetStrLen(objQuestionTypeEN.QuestionTypeName) > 20)
{
 throw new Exception("字段[题目类型名]的长度不能超过20!");
}
if (!Object.Equals(null, objQuestionTypeEN.QuestionTypeENName) && GetStrLen(objQuestionTypeEN.QuestionTypeENName) > 50)
{
 throw new Exception("字段[题目类型英文名]的长度不能超过50!");
}
if (!Object.Equals(null, objQuestionTypeEN.DefaAnswerModeId) && GetStrLen(objQuestionTypeEN.DefaAnswerModeId) > 4)
{
 throw new Exception("字段[默认答案模式Id]的长度不能超过4!");
}
if (!Object.Equals(null, objQuestionTypeEN.DefaAnswerTypeId) && GetStrLen(objQuestionTypeEN.DefaAnswerTypeId) > 2)
{
 throw new Exception("字段[默认答案类型Id]的长度不能超过2!");
}
if (!Object.Equals(null, objQuestionTypeEN.UpdDate) && GetStrLen(objQuestionTypeEN.UpdDate) > 20)
{
 throw new Exception("字段[修改日期]的长度不能超过20!");
}
if (!Object.Equals(null, objQuestionTypeEN.UpdUser) && GetStrLen(objQuestionTypeEN.UpdUser) > 20)
{
 throw new Exception("字段[修改人]的长度不能超过20!");
}
if (!Object.Equals(null, objQuestionTypeEN.Memo) && GetStrLen(objQuestionTypeEN.Memo) > 1000)
{
 throw new Exception("字段[备注]的长度不能超过1000!");
}
 objQuestionTypeEN._IsCheckProperty = true;
 }

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyId)
 /// </summary>
 /// <param name = "strQuestionTypeId">表关键字</param>
 /// <returns>表对象</returns>
public static clsQuestionTypeEN GetObjByQuestionTypeId(string strQuestionTypeId)
{
string strAction = "GetObjByQuestionTypeId";
string strErrMsg = string.Empty;
string strResult = "";
clsQuestionTypeEN objQuestionTypeEN = null;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["QuestionTypeId"] = strQuestionTypeId
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
objQuestionTypeEN = JsonConvert.DeserializeObject<clsQuestionTypeEN>((string)jobjReturn["ReturnObj"]);
return objQuestionTypeEN;
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
 /// <param name = "strQuestionTypeId">表关键字</param>
 /// <returns>表对象</returns>
public static clsQuestionTypeEN GetObjByQuestionTypeId_WA_Cache(string strQuestionTypeId)
{
string strAction = "GetObjByQuestionTypeId_Cache";
string strErrMsg = string.Empty;
string strResult = "";
clsQuestionTypeEN objQuestionTypeEN = null;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["QuestionTypeId"] = strQuestionTypeId
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
objQuestionTypeEN = JsonConvert.DeserializeObject<clsQuestionTypeEN>((string)jobjReturn["ReturnObj"]);
return objQuestionTypeEN;
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
public static clsQuestionTypeEN GetFirstObj(string strWhereCond)
{
string strAction = "GetFirstObj";
string strErrMsg = string.Empty;
string strResult = "";
clsQuestionTypeEN objQuestionTypeEN = null;
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
objQuestionTypeEN = JsonConvert.DeserializeObject<clsQuestionTypeEN>((string)jobjReturn["ReturnObj"]);
return objQuestionTypeEN;
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
 /// <param name = "strQuestionTypeId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsQuestionTypeEN GetObjByQuestionTypeId_Cache(string strQuestionTypeId)
{
if (string.IsNullOrEmpty(strQuestionTypeId) == true) return null;
//初始化列表缓存
string strKey = string.Format("{0}", clsQuestionTypeEN._CurrTabName_S);
List<clsQuestionTypeEN> arrQuestionTypeObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsQuestionTypeEN> arrQuestionTypeObjLst_Sel =
from objQuestionTypeEN in arrQuestionTypeObjLst_Cache
where objQuestionTypeEN.QuestionTypeId == strQuestionTypeId
select objQuestionTypeEN;
if (arrQuestionTypeObjLst_Sel.Count() == 0)
{
   clsQuestionTypeEN obj = clsQuestionTypeWApi.GetObjByQuestionTypeId(strQuestionTypeId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
     return obj;
 }
return null;
}
return arrQuestionTypeObjLst_Sel.First();
}

 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetRecNameByKey_Cache)
 /// </summary>
 /// <param name = "strQuestionTypeId">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetQuestionTypeNameByQuestionTypeId_Cache(string strQuestionTypeId)
{
if (string.IsNullOrEmpty(strQuestionTypeId) == true) return "";
//初始化列表缓存
string strKey = string.Format("{0}", clsQuestionTypeEN._CurrTabName_S);
List<clsQuestionTypeEN> arrQuestionTypeObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsQuestionTypeEN> arrQuestionTypeObjLst_Sel1 =
from objQuestionTypeEN in arrQuestionTypeObjLst_Cache
where objQuestionTypeEN.QuestionTypeId == strQuestionTypeId
select objQuestionTypeEN;
List <clsQuestionTypeEN> arrQuestionTypeObjLst_Sel = new List<clsQuestionTypeEN>();
foreach (clsQuestionTypeEN obj in arrQuestionTypeObjLst_Sel1)
{
arrQuestionTypeObjLst_Sel.Add(obj);
}
if (arrQuestionTypeObjLst_Sel.Count > 0)
{
return arrQuestionTypeObjLst_Sel[0].QuestionTypeName;
}
string strErrMsgForGetObjById = string.Format("在QuestionType对象缓存列表中,找不到记录[QuestionTypeId = {0}](函数:{1})", strQuestionTypeId, clsStackTrace.GetCurrFunction());
clsLog.LogErrorS2("clsQuestionTypeBL", clsStackTrace.GetCurrClassFunction(), strErrMsgForGetObjById, "", "");
throw new Exception(strErrMsgForGetObjById);
}
 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetRecNameByKey_Cache)
 /// </summary>
 /// <param name = "strQuestionTypeId">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetNameByQuestionTypeId_Cache(string strQuestionTypeId)
{
if (string.IsNullOrEmpty(strQuestionTypeId) == true) return "";
//初始化列表缓存
string strKey = string.Format("{0}", clsQuestionTypeEN._CurrTabName_S);
List<clsQuestionTypeEN> arrQuestionTypeObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsQuestionTypeEN> arrQuestionTypeObjLst_Sel1 =
from objQuestionTypeEN in arrQuestionTypeObjLst_Cache
where objQuestionTypeEN.QuestionTypeId == strQuestionTypeId
select objQuestionTypeEN;
List <clsQuestionTypeEN> arrQuestionTypeObjLst_Sel = new List<clsQuestionTypeEN>();
foreach (clsQuestionTypeEN obj in arrQuestionTypeObjLst_Sel1)
{
arrQuestionTypeObjLst_Sel.Add(obj);
}
if (arrQuestionTypeObjLst_Sel.Count > 0)
{
return arrQuestionTypeObjLst_Sel[0].QuestionTypeName;
}
string strErrMsgForGetObjById = string.Format("在QuestionType对象缓存列表中,找不到记录的相关名称[QuestionTypeId = {0}](函数:{1})", strQuestionTypeId, clsStackTrace.GetCurrFunction());
clsLog.LogErrorS2("clsQuestionTypeBL", clsStackTrace.GetCurrClassFunction(), strErrMsgForGetObjById, "", "");
throw new Exception(strErrMsgForGetObjById);
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsQuestionTypeEN> GetObjLst(string strWhereCond)
{
 List<clsQuestionTypeEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsQuestionTypeEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsQuestionTypeEN> GetObjLstByQuestionTypeIdLst(List<string> arrQuestionTypeId)
{
 List<clsQuestionTypeEN> arrObjLst = null; 
string strAction = "GetObjLstByQuestionTypeIdLst";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrQuestionTypeId);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
arrObjLst = JsonConvert.DeserializeObject<List<clsQuestionTypeEN>>((string)jobjReturn["ReturnObjLst"]);
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
 /// <param name = "strQuestionTypeId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static IEnumerable<clsQuestionTypeEN> GetObjLstByQuestionTypeIdLst_Cache(List<string> arrQuestionTypeId)
{
//初始化列表缓存
string strKey = string.Format("{0}", clsQuestionTypeEN._CurrTabName_S);
List<clsQuestionTypeEN> arrQuestionTypeObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsQuestionTypeEN> arrQuestionTypeObjLst_Sel =
from objQuestionTypeEN in arrQuestionTypeObjLst_Cache
where arrQuestionTypeId.Contains(objQuestionTypeEN.QuestionTypeId)
select objQuestionTypeEN;
return arrQuestionTypeObjLst_Sel;
}

 /// <summary>
 /// 根据关键字列表获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstByKeyLst_WA_Cache)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsQuestionTypeEN> GetObjLstByQuestionTypeIdLst_WA_Cache(List<string> arrQuestionTypeId)
{
 List<clsQuestionTypeEN> arrObjLst = null; 
string strAction = "GetObjLstByQuestionTypeIdLst_Cache";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
};
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrQuestionTypeId);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
arrObjLst = JsonConvert.DeserializeObject<List<clsQuestionTypeEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsQuestionTypeEN> GetTopObjLst(stuTopPara objTopPara)
{
 List<clsQuestionTypeEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsQuestionTypeEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsQuestionTypeEN> GetObjLstByRange(stuRangePara objRangePara)
{
 List<clsQuestionTypeEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsQuestionTypeEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsQuestionTypeEN> GetObjLstByPager(stuPagerPara objPagerPara)
{
 List<clsQuestionTypeEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsQuestionTypeEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsQuestionTypeEN> GetObjLstByPager_Cache(stuPagerPara objPagerPara)
{
 List<clsQuestionTypeEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsQuestionTypeEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static int DelRecord(string strQuestionTypeId)
{
string strAction = "DelRecord";
string strErrMsg = string.Empty;
string strResult = "";
try
{
 clsQuestionTypeEN objQuestionTypeEN = clsQuestionTypeWApi.GetObjByQuestionTypeId(strQuestionTypeId);
if (clsPubFun4WApi.Delete(mstrApiControllerName, strAction, strQuestionTypeId.ToString(), out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
clsQuestionTypeWApi.ReFreshCache();
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
public static int DelQuestionTypes(List<string> arrQuestionTypeId)
{
string strAction = "DelQuestionTypes";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrQuestionTypeId);
if (clsPubFun4WApi.Deletes(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
clsQuestionTypeWApi.ReFreshCache();
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
public static int DelQuestionTypesByCond(string strWhereCond)
{
string strAction = "DelQuestionTypesByCond";
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
public static bool AddNewRecord(clsQuestionTypeEN objQuestionTypeEN)
{
string strAction = "AddNewRecord";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsQuestionTypeEN>(objQuestionTypeEN);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJson, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsQuestionTypeWApi.ReFreshCache();
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
public static string AddNewRecordWithMaxId(clsQuestionTypeEN objQuestionTypeEN)
{
string strAction = "AddNewRecordWithMaxId";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsQuestionTypeEN>(objQuestionTypeEN);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJson, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsQuestionTypeWApi.ReFreshCache();
var strQuestionTypeId = (string)jobjReturn["ReturnStr"];
return strQuestionTypeId;
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
public static bool UpdateRecord(clsQuestionTypeEN objQuestionTypeEN)
{
if (string.IsNullOrEmpty(objQuestionTypeEN.sf_UpdFldSetStr) == true)
{
string strMsg = string.Format("修改时，修改标志串为空，请联系管理员.对象关键字:{0}.(from {1}).",
objQuestionTypeEN.QuestionTypeId, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
string strAction = "UpdateRecord";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsQuestionTypeEN>(objQuestionTypeEN);
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
 /// <param name = "objQuestionTypeEN">需要修改的对象</param>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的关键字值</returns>
public static bool UpdateWithCondition(clsQuestionTypeEN objQuestionTypeEN, string strWhereCond)
{
if (string.IsNullOrEmpty(objQuestionTypeEN.sf_UpdFldSetStr) == true)
{
string strMsg = string.Format("修改时，修改标志串为空，请联系管理员.对象关键字:{0}.(from {1}).",
objQuestionTypeEN.QuestionTypeId, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (string.IsNullOrEmpty(strWhereCond) == true)
{
string strMsg = string.Format("按条件修改时，条件串为空，请联系管理员.对象关键字:{0}.(from {1}).",
objQuestionTypeEN.QuestionTypeId, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
string strAction = "UpdateWithCondition";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsQuestionTypeEN>(objQuestionTypeEN);
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
public static bool IsExist(string strQuestionTypeId)
{
//检测记录是否存在
string strAction = "IsExist";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["QuestionTypeId"] = strQuestionTypeId
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
 /// <param name = "objQuestionTypeENS">源对象</param>
 /// <param name = "objQuestionTypeENT">目标对象</param>
 public static void CopyTo(clsQuestionTypeEN objQuestionTypeENS, clsQuestionTypeEN objQuestionTypeENT)
{
try
{
objQuestionTypeENT.QuestionTypeId = objQuestionTypeENS.QuestionTypeId; //题目类型Id
objQuestionTypeENT.QuestionTypeName = objQuestionTypeENS.QuestionTypeName; //题目类型名
objQuestionTypeENT.QuestionTypeENName = objQuestionTypeENS.QuestionTypeENName; //题目类型英文名
objQuestionTypeENT.DefaAnswerModeId = objQuestionTypeENS.DefaAnswerModeId; //默认答案模式Id
objQuestionTypeENT.DefaAnswerTypeId = objQuestionTypeENS.DefaAnswerTypeId; //默认答案类型Id
objQuestionTypeENT.OrderNum = objQuestionTypeENS.OrderNum; //序号
objQuestionTypeENT.IsUse = objQuestionTypeENS.IsUse; //是否使用
objQuestionTypeENT.UpdDate = objQuestionTypeENS.UpdDate; //修改日期
objQuestionTypeENT.UpdUser = objQuestionTypeENS.UpdUser; //修改人
objQuestionTypeENT.Memo = objQuestionTypeENS.Memo; //备注
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
public static DataTable ToDataTable(List<clsQuestionTypeEN> arrObj)
{
DataTable dataTable = new DataTable(); //实例化
DataTable result;
if (arrObj.Count == 0) return null;
if (clsQuestionTypeEN.AttributeName.Length == 0)
{
result = dataTable;
return result;
}
Type type = typeof(clsQuestionTypeEN);
PropertyInfo[] arrPropertyInfo = type.GetProperties();
try
{
//Columns
foreach (string strAttrName in clsQuestionTypeEN.AttributeName)
{
PropertyInfo proprety_Curr = arrPropertyInfo.Where(x => x.Name == strAttrName).First();
dataTable.Columns.Add(strAttrName, proprety_Curr.PropertyType);
}
foreach (clsQuestionTypeEN objInFor in arrObj)
{
//Rows
DataRow dataRow = dataTable.NewRow();
foreach (string strAttrName in clsQuestionTypeEN.AttributeName)
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
if (clsQuestionTypeWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsQuestionTypeWApi没有刷新缓存机制(clsQuestionTypeWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by QuestionTypeId");
//if (arrQuestionTypeObjLst_Cache == null)
//{
//arrQuestionTypeObjLst_Cache = await clsQuestionTypeWApi.GetObjLst(strWhereCond);
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
string strKey = string.Format("{0}", clsQuestionTypeEN._CurrTabName_S);
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
if (clsQuestionTypeWApi.objCommFun4BL != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}", clsQuestionTypeEN._CurrTabName_S);
CacheHelper.Remove(strKey);
clsQuestionTypeWApi.objCommFun4BL.ReFreshCache();
}
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst_Cache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsQuestionTypeEN> GetObjLst_Cache()
{
//初始化列表缓存
InitListCache(); 
string strKey = string.Format("{0}", clsQuestionTypeEN._CurrTabName_S);
List<clsQuestionTypeEN> arrQuestionTypeObjLst_Cache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrQuestionTypeObjLst_Cache;
}

 /// <summary>
 /// 根据对象列表获取DataTable
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetDataTableByObjLst)
 /// </summary>
 /// <param name = "arrObjLst">给定的对象列表</param>
 /// <returns>返回DataTable</returns>
public static DataTable GetDataTableByObjLst(List<clsQuestionTypeEN> arrObjLst)
{
DataTable objDT = new DataTable();
objDT.Columns.Add(conQuestionType.QuestionTypeId, Type.GetType("System.String"));
objDT.Columns.Add(conQuestionType.QuestionTypeName, Type.GetType("System.String"));
objDT.Columns.Add(conQuestionType.QuestionTypeENName, Type.GetType("System.String"));
objDT.Columns.Add(conQuestionType.DefaAnswerModeId, Type.GetType("System.String"));
objDT.Columns.Add(conQuestionType.DefaAnswerTypeId, Type.GetType("System.String"));
objDT.Columns.Add(conQuestionType.OrderNum, Type.GetType("System.Int32"));
objDT.Columns.Add(conQuestionType.IsUse, Type.GetType("System.Boolean"));
objDT.Columns.Add(conQuestionType.UpdDate, Type.GetType("System.String"));
objDT.Columns.Add(conQuestionType.UpdUser, Type.GetType("System.String"));
objDT.Columns.Add(conQuestionType.Memo, Type.GetType("System.String"));
foreach (clsQuestionTypeEN objInFor in arrObjLst)
{
DataRow objDR = objDT.NewRow();
objDR[conQuestionType.QuestionTypeId] = objInFor[conQuestionType.QuestionTypeId];
objDR[conQuestionType.QuestionTypeName] = objInFor[conQuestionType.QuestionTypeName];
objDR[conQuestionType.QuestionTypeENName] = objInFor[conQuestionType.QuestionTypeENName];
objDR[conQuestionType.DefaAnswerModeId] = objInFor[conQuestionType.DefaAnswerModeId];
objDR[conQuestionType.DefaAnswerTypeId] = objInFor[conQuestionType.DefaAnswerTypeId];
objDR[conQuestionType.OrderNum] = objInFor[conQuestionType.OrderNum];
objDR[conQuestionType.IsUse] = objInFor[conQuestionType.IsUse];
objDR[conQuestionType.UpdDate] = objInFor[conQuestionType.UpdDate];
objDR[conQuestionType.UpdUser] = objInFor[conQuestionType.UpdUser];
objDR[conQuestionType.Memo] = objInFor[conQuestionType.Memo];
objDT.Rows.Add(objDR);
}
return objDT;
}
}
 /// <summary>
 /// 题目类型(QuestionType)
 /// 数据源类型:SQL表
 /// (AutoGCLib.CommFun4WA4CSharp:GeneCode_This)
 /// </summary>
public class clsCommFun4WA4QuestionType : clsCommFun4BL
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
clsQuestionTypeWApi.ReFreshThisCache();
clsvQuestionTypeWApi.ReFreshThisCache();
}
}

}