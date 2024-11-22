﻿
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsAnswer4WorkWApi
 表名:Answer4Work(01120200)
 生成代码版本:2021.09.20.1
 生成日期:2021/09/21 02:42:22
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
public static class clsAnswer4WorkWApi_Static
{

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objAnswer4WorkEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsAnswer4WorkEN SetId_Answer4Work(this clsAnswer4WorkEN objAnswer4WorkEN, string strId_Answer4Work, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strId_Answer4Work, 8, conAnswer4Work.Id_Answer4Work);
clsCheckSql.CheckFieldForeignKey(strId_Answer4Work, 8, conAnswer4Work.Id_Answer4Work);
objAnswer4WorkEN.Id_Answer4Work = strId_Answer4Work; //作业答案流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objAnswer4WorkEN.dicFldComparisonOp.ContainsKey(conAnswer4Work.Id_Answer4Work) == false)
{
objAnswer4WorkEN.dicFldComparisonOp.Add(conAnswer4Work.Id_Answer4Work, strComparisonOp);
}
else
{
objAnswer4WorkEN.dicFldComparisonOp[conAnswer4Work.Id_Answer4Work] = strComparisonOp;
}
}
return objAnswer4WorkEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objAnswer4WorkEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsAnswer4WorkEN SetAnswerIndex(this clsAnswer4WorkEN objAnswer4WorkEN, int intAnswerIndex, string strComparisonOp="")
	{
objAnswer4WorkEN.AnswerIndex = intAnswerIndex; //问答序号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objAnswer4WorkEN.dicFldComparisonOp.ContainsKey(conAnswer4Work.AnswerIndex) == false)
{
objAnswer4WorkEN.dicFldComparisonOp.Add(conAnswer4Work.AnswerIndex, strComparisonOp);
}
else
{
objAnswer4WorkEN.dicFldComparisonOp[conAnswer4Work.AnswerIndex] = strComparisonOp;
}
}
return objAnswer4WorkEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objAnswer4WorkEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsAnswer4WorkEN SetAnswerName(this clsAnswer4WorkEN objAnswer4WorkEN, string strAnswerName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strAnswerName, 100, conAnswer4Work.AnswerName);
objAnswer4WorkEN.AnswerName = strAnswerName; //问答名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objAnswer4WorkEN.dicFldComparisonOp.ContainsKey(conAnswer4Work.AnswerName) == false)
{
objAnswer4WorkEN.dicFldComparisonOp.Add(conAnswer4Work.AnswerName, strComparisonOp);
}
else
{
objAnswer4WorkEN.dicFldComparisonOp[conAnswer4Work.AnswerName] = strComparisonOp;
}
}
return objAnswer4WorkEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objAnswer4WorkEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsAnswer4WorkEN SetIsShow(this clsAnswer4WorkEN objAnswer4WorkEN, bool bolIsShow, string strComparisonOp="")
	{
objAnswer4WorkEN.IsShow = bolIsShow; //是否启用
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objAnswer4WorkEN.dicFldComparisonOp.ContainsKey(conAnswer4Work.IsShow) == false)
{
objAnswer4WorkEN.dicFldComparisonOp.Add(conAnswer4Work.IsShow, strComparisonOp);
}
else
{
objAnswer4WorkEN.dicFldComparisonOp[conAnswer4Work.IsShow] = strComparisonOp;
}
}
return objAnswer4WorkEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objAnswer4WorkEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsAnswer4WorkEN SetAnswerContent(this clsAnswer4WorkEN objAnswer4WorkEN, string strAnswerContent, string strComparisonOp="")
	{
objAnswer4WorkEN.AnswerContent = strAnswerContent; //答案内容
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objAnswer4WorkEN.dicFldComparisonOp.ContainsKey(conAnswer4Work.AnswerContent) == false)
{
objAnswer4WorkEN.dicFldComparisonOp.Add(conAnswer4Work.AnswerContent, strComparisonOp);
}
else
{
objAnswer4WorkEN.dicFldComparisonOp[conAnswer4Work.AnswerContent] = strComparisonOp;
}
}
return objAnswer4WorkEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objAnswer4WorkEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsAnswer4WorkEN SetIsCorrect(this clsAnswer4WorkEN objAnswer4WorkEN, bool bolIsCorrect, string strComparisonOp="")
	{
objAnswer4WorkEN.IsCorrect = bolIsCorrect; //是否正确
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objAnswer4WorkEN.dicFldComparisonOp.ContainsKey(conAnswer4Work.IsCorrect) == false)
{
objAnswer4WorkEN.dicFldComparisonOp.Add(conAnswer4Work.IsCorrect, strComparisonOp);
}
else
{
objAnswer4WorkEN.dicFldComparisonOp[conAnswer4Work.IsCorrect] = strComparisonOp;
}
}
return objAnswer4WorkEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objAnswer4WorkEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsAnswer4WorkEN SetId_Work(this clsAnswer4WorkEN objAnswer4WorkEN, string strId_Work, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strId_Work, conAnswer4Work.Id_Work);
clsCheckSql.CheckFieldLen(strId_Work, 8, conAnswer4Work.Id_Work);
clsCheckSql.CheckFieldForeignKey(strId_Work, 8, conAnswer4Work.Id_Work);
objAnswer4WorkEN.Id_Work = strId_Work; //作业流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objAnswer4WorkEN.dicFldComparisonOp.ContainsKey(conAnswer4Work.Id_Work) == false)
{
objAnswer4WorkEN.dicFldComparisonOp.Add(conAnswer4Work.Id_Work, strComparisonOp);
}
else
{
objAnswer4WorkEN.dicFldComparisonOp[conAnswer4Work.Id_Work] = strComparisonOp;
}
}
return objAnswer4WorkEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objAnswer4WorkEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsAnswer4WorkEN SetQuestionResolve(this clsAnswer4WorkEN objAnswer4WorkEN, string strQuestionResolve, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strQuestionResolve, 8000, conAnswer4Work.QuestionResolve);
objAnswer4WorkEN.QuestionResolve = strQuestionResolve; //题目解析
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objAnswer4WorkEN.dicFldComparisonOp.ContainsKey(conAnswer4Work.QuestionResolve) == false)
{
objAnswer4WorkEN.dicFldComparisonOp.Add(conAnswer4Work.QuestionResolve, strComparisonOp);
}
else
{
objAnswer4WorkEN.dicFldComparisonOp[conAnswer4Work.QuestionResolve] = strComparisonOp;
}
}
return objAnswer4WorkEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objAnswer4WorkEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsAnswer4WorkEN SetUpdUser(this clsAnswer4WorkEN objAnswer4WorkEN, string strUpdUser, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strUpdUser, conAnswer4Work.UpdUser);
clsCheckSql.CheckFieldLen(strUpdUser, 20, conAnswer4Work.UpdUser);
objAnswer4WorkEN.UpdUser = strUpdUser; //修改人
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objAnswer4WorkEN.dicFldComparisonOp.ContainsKey(conAnswer4Work.UpdUser) == false)
{
objAnswer4WorkEN.dicFldComparisonOp.Add(conAnswer4Work.UpdUser, strComparisonOp);
}
else
{
objAnswer4WorkEN.dicFldComparisonOp[conAnswer4Work.UpdUser] = strComparisonOp;
}
}
return objAnswer4WorkEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objAnswer4WorkEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsAnswer4WorkEN SetUpdDate(this clsAnswer4WorkEN objAnswer4WorkEN, string strUpdDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strUpdDate, conAnswer4Work.UpdDate);
clsCheckSql.CheckFieldLen(strUpdDate, 20, conAnswer4Work.UpdDate);
objAnswer4WorkEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objAnswer4WorkEN.dicFldComparisonOp.ContainsKey(conAnswer4Work.UpdDate) == false)
{
objAnswer4WorkEN.dicFldComparisonOp.Add(conAnswer4Work.UpdDate, strComparisonOp);
}
else
{
objAnswer4WorkEN.dicFldComparisonOp[conAnswer4Work.UpdDate] = strComparisonOp;
}
}
return objAnswer4WorkEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objAnswer4WorkEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsAnswer4WorkEN SetMemo(this clsAnswer4WorkEN objAnswer4WorkEN, string strMemo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMemo, 1000, conAnswer4Work.Memo);
objAnswer4WorkEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objAnswer4WorkEN.dicFldComparisonOp.ContainsKey(conAnswer4Work.Memo) == false)
{
objAnswer4WorkEN.dicFldComparisonOp.Add(conAnswer4Work.Memo, strComparisonOp);
}
else
{
objAnswer4WorkEN.dicFldComparisonOp[conAnswer4Work.Memo] = strComparisonOp;
}
}
return objAnswer4WorkEN;
	}

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsAnswer4WorkEN objAnswer4Work_Cond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objAnswer4Work_Cond.IsUpdated(conAnswer4Work.Id_Answer4Work) == true)
{
string strComparisonOp_Id_Answer4Work = objAnswer4Work_Cond.dicFldComparisonOp[conAnswer4Work.Id_Answer4Work];
strWhereCond += string.Format(" And {0} {2} '{1}'", conAnswer4Work.Id_Answer4Work, objAnswer4Work_Cond.Id_Answer4Work, strComparisonOp_Id_Answer4Work);
}
if (objAnswer4Work_Cond.IsUpdated(conAnswer4Work.AnswerIndex) == true)
{
string strComparisonOp_AnswerIndex = objAnswer4Work_Cond.dicFldComparisonOp[conAnswer4Work.AnswerIndex];
strWhereCond += string.Format(" And {0} {2} {1}", conAnswer4Work.AnswerIndex, objAnswer4Work_Cond.AnswerIndex, strComparisonOp_AnswerIndex);
}
if (objAnswer4Work_Cond.IsUpdated(conAnswer4Work.AnswerName) == true)
{
string strComparisonOp_AnswerName = objAnswer4Work_Cond.dicFldComparisonOp[conAnswer4Work.AnswerName];
strWhereCond += string.Format(" And {0} {2} '{1}'", conAnswer4Work.AnswerName, objAnswer4Work_Cond.AnswerName, strComparisonOp_AnswerName);
}
if (objAnswer4Work_Cond.IsUpdated(conAnswer4Work.IsShow) == true)
{
if (objAnswer4Work_Cond.IsShow == true)
{
strWhereCond += string.Format(" And {0} = '1'", conAnswer4Work.IsShow);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conAnswer4Work.IsShow);
}
}
//数据类型string(text)在函数:[AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj]中没有处理！
if (objAnswer4Work_Cond.IsUpdated(conAnswer4Work.IsCorrect) == true)
{
if (objAnswer4Work_Cond.IsCorrect == true)
{
strWhereCond += string.Format(" And {0} = '1'", conAnswer4Work.IsCorrect);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conAnswer4Work.IsCorrect);
}
}
if (objAnswer4Work_Cond.IsUpdated(conAnswer4Work.Id_Work) == true)
{
string strComparisonOp_Id_Work = objAnswer4Work_Cond.dicFldComparisonOp[conAnswer4Work.Id_Work];
strWhereCond += string.Format(" And {0} {2} '{1}'", conAnswer4Work.Id_Work, objAnswer4Work_Cond.Id_Work, strComparisonOp_Id_Work);
}
if (objAnswer4Work_Cond.IsUpdated(conAnswer4Work.QuestionResolve) == true)
{
string strComparisonOp_QuestionResolve = objAnswer4Work_Cond.dicFldComparisonOp[conAnswer4Work.QuestionResolve];
strWhereCond += string.Format(" And {0} {2} '{1}'", conAnswer4Work.QuestionResolve, objAnswer4Work_Cond.QuestionResolve, strComparisonOp_QuestionResolve);
}
if (objAnswer4Work_Cond.IsUpdated(conAnswer4Work.UpdUser) == true)
{
string strComparisonOp_UpdUser = objAnswer4Work_Cond.dicFldComparisonOp[conAnswer4Work.UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", conAnswer4Work.UpdUser, objAnswer4Work_Cond.UpdUser, strComparisonOp_UpdUser);
}
if (objAnswer4Work_Cond.IsUpdated(conAnswer4Work.UpdDate) == true)
{
string strComparisonOp_UpdDate = objAnswer4Work_Cond.dicFldComparisonOp[conAnswer4Work.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conAnswer4Work.UpdDate, objAnswer4Work_Cond.UpdDate, strComparisonOp_UpdDate);
}
if (objAnswer4Work_Cond.IsUpdated(conAnswer4Work.Memo) == true)
{
string strComparisonOp_Memo = objAnswer4Work_Cond.dicFldComparisonOp[conAnswer4Work.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", conAnswer4Work.Memo, objAnswer4Work_Cond.Memo, strComparisonOp_Memo);
}
 return strWhereCond;
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_Update)
 /// </summary>
 /// <param name = "objAnswer4WorkEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsAnswer4WorkEN objAnswer4WorkEN)
{
 if (string.IsNullOrEmpty(objAnswer4WorkEN.Id_Answer4Work) == true)
 {
string strMsg = string.Format("(errid:Watl000003)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
objAnswer4WorkEN.sf_UpdFldSetStr = objAnswer4WorkEN.getsf_UpdFldSetStr();
clsAnswer4WorkWApi.CheckPropertyNew(objAnswer4WorkEN); 
bool bolResult = clsAnswer4WorkWApi.UpdateRecord(objAnswer4WorkEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsAnswer4WorkWApi.ReFreshCache();
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
 /// <param name = "objAnswer4WorkEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clsAnswer4WorkEN objAnswer4WorkEN)
{
 if (string.IsNullOrEmpty(objAnswer4WorkEN.Id_Answer4Work) == true)
 {
string strMsg = string.Format("添加记录时，关键字不能为空!(from {0})\r\n", 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
 if (clsAnswer4WorkWApi.IsExist(objAnswer4WorkEN.Id_Answer4Work) == true)
 {
string strMsg = string.Format("添加记录时，关键字:[{0}]已经存在!(from {1})\r\n", objAnswer4WorkEN.Id_Answer4Work, 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
try
{
clsAnswer4WorkWApi.CheckPropertyNew(objAnswer4WorkEN); 
bool bolResult = clsAnswer4WorkWApi.AddNewRecord(objAnswer4WorkEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsAnswer4WorkWApi.ReFreshCache();
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
 /// <param name = "objAnswer4WorkEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static string AddNewRecordWithMaxId(this clsAnswer4WorkEN objAnswer4WorkEN)
{
try
{
clsAnswer4WorkWApi.CheckPropertyNew(objAnswer4WorkEN); 
string strId_Answer4Work = clsAnswer4WorkWApi.AddNewRecordWithMaxId(objAnswer4WorkEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsAnswer4WorkWApi.ReFreshCache();
return strId_Answer4Work;
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
 /// <param name = "objAnswer4WorkEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsAnswer4WorkEN objAnswer4WorkEN, string strWhereCond)
{
try
{
clsAnswer4WorkWApi.CheckPropertyNew(objAnswer4WorkEN); 
bool bolResult = clsAnswer4WorkWApi.UpdateWithCondition(objAnswer4WorkEN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsAnswer4WorkWApi.ReFreshCache();
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
 /// 作业答案(Answer4Work)
 /// (AutoGCLib.WA_Access4CSharp:GeneCode)
 /// </summary>
public class clsAnswer4WorkWApi
{
private static readonly string mstrApiControllerName = "Answer4WorkApi";

 /// <summary>
/// 专门在逻辑层用于处理缓存等公共函数的对象
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_DefineObjCommFun4BL)
/// </summary>
public static clsCommFun4BL objCommFun4BL = null;

 public clsAnswer4WorkWApi()
 {
 }

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_CheckPropertyNew)
 /// </summary>
public static void CheckPropertyNew(clsAnswer4WorkEN objAnswer4WorkEN)
{
if (!Object.Equals(null, objAnswer4WorkEN.Id_Answer4Work) && GetStrLen(objAnswer4WorkEN.Id_Answer4Work) > 8)
{
 throw new Exception("字段[作业答案流水号]的长度不能超过8!");
}
if (!Object.Equals(null, objAnswer4WorkEN.AnswerName) && GetStrLen(objAnswer4WorkEN.AnswerName) > 100)
{
 throw new Exception("字段[问答名称]的长度不能超过100!");
}
if (!Object.Equals(null, objAnswer4WorkEN.Id_Work) && GetStrLen(objAnswer4WorkEN.Id_Work) > 8)
{
 throw new Exception("字段[作业流水号]的长度不能超过8!");
}
if (!Object.Equals(null, objAnswer4WorkEN.QuestionResolve) && GetStrLen(objAnswer4WorkEN.QuestionResolve) > 8000)
{
 throw new Exception("字段[题目解析]的长度不能超过8000!");
}
if (!Object.Equals(null, objAnswer4WorkEN.UpdUser) && GetStrLen(objAnswer4WorkEN.UpdUser) > 20)
{
 throw new Exception("字段[修改人]的长度不能超过20!");
}
if (!Object.Equals(null, objAnswer4WorkEN.UpdDate) && GetStrLen(objAnswer4WorkEN.UpdDate) > 20)
{
 throw new Exception("字段[修改日期]的长度不能超过20!");
}
if (!Object.Equals(null, objAnswer4WorkEN.Memo) && GetStrLen(objAnswer4WorkEN.Memo) > 1000)
{
 throw new Exception("字段[备注]的长度不能超过1000!");
}
 objAnswer4WorkEN._IsCheckProperty = true;
 }

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyId)
 /// </summary>
 /// <param name = "strId_Answer4Work">表关键字</param>
 /// <returns>表对象</returns>
public static clsAnswer4WorkEN GetObjById_Answer4Work(string strId_Answer4Work)
{
string strAction = "GetObjById_Answer4Work";
string strErrMsg = string.Empty;
string strResult = "";
clsAnswer4WorkEN objAnswer4WorkEN = null;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["Id_Answer4Work"] = strId_Answer4Work
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
objAnswer4WorkEN = JsonConvert.DeserializeObject<clsAnswer4WorkEN>((string)jobjReturn["ReturnObj"]);
return objAnswer4WorkEN;
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
 /// <param name = "strId_Answer4Work">表关键字</param>
 /// <returns>表对象</returns>
public static clsAnswer4WorkEN GetObjById_Answer4Work_WA_Cache(string strId_Answer4Work)
{
string strAction = "GetObjById_Answer4Work_Cache";
string strErrMsg = string.Empty;
string strResult = "";
clsAnswer4WorkEN objAnswer4WorkEN = null;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["Id_Answer4Work"] = strId_Answer4Work
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
objAnswer4WorkEN = JsonConvert.DeserializeObject<clsAnswer4WorkEN>((string)jobjReturn["ReturnObj"]);
return objAnswer4WorkEN;
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
public static clsAnswer4WorkEN GetFirstObj(string strWhereCond)
{
string strAction = "GetFirstObj";
string strErrMsg = string.Empty;
string strResult = "";
clsAnswer4WorkEN objAnswer4WorkEN = null;
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
objAnswer4WorkEN = JsonConvert.DeserializeObject<clsAnswer4WorkEN>((string)jobjReturn["ReturnObj"]);
return objAnswer4WorkEN;
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
 /// <param name = "strId_Answer4Work">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsAnswer4WorkEN GetObjById_Answer4Work_Cache(string strId_Answer4Work)
{
if (string.IsNullOrEmpty(strId_Answer4Work) == true) return null;
//初始化列表缓存
string strKey = string.Format("{0}", clsAnswer4WorkEN._CurrTabName_S);
List<clsAnswer4WorkEN> arrAnswer4WorkObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsAnswer4WorkEN> arrAnswer4WorkObjLst_Sel =
from objAnswer4WorkEN in arrAnswer4WorkObjLst_Cache
where objAnswer4WorkEN.Id_Answer4Work == strId_Answer4Work
select objAnswer4WorkEN;
if (arrAnswer4WorkObjLst_Sel.Count() == 0)
{
   clsAnswer4WorkEN obj = clsAnswer4WorkWApi.GetObjById_Answer4Work(strId_Answer4Work);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
     return obj;
 }
return null;
}
return arrAnswer4WorkObjLst_Sel.First();
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsAnswer4WorkEN> GetObjLst(string strWhereCond)
{
 List<clsAnswer4WorkEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsAnswer4WorkEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsAnswer4WorkEN> GetObjLstById_Answer4WorkLst(List<string> arrId_Answer4Work)
{
 List<clsAnswer4WorkEN> arrObjLst = null; 
string strAction = "GetObjLstById_Answer4WorkLst";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrId_Answer4Work);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
arrObjLst = JsonConvert.DeserializeObject<List<clsAnswer4WorkEN>>((string)jobjReturn["ReturnObjLst"]);
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
 /// <param name = "strId_Answer4Work">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static IEnumerable<clsAnswer4WorkEN> GetObjLstById_Answer4WorkLst_Cache(List<string> arrId_Answer4Work)
{
//初始化列表缓存
string strKey = string.Format("{0}", clsAnswer4WorkEN._CurrTabName_S);
List<clsAnswer4WorkEN> arrAnswer4WorkObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsAnswer4WorkEN> arrAnswer4WorkObjLst_Sel =
from objAnswer4WorkEN in arrAnswer4WorkObjLst_Cache
where arrId_Answer4Work.Contains(objAnswer4WorkEN.Id_Answer4Work)
select objAnswer4WorkEN;
return arrAnswer4WorkObjLst_Sel;
}

 /// <summary>
 /// 根据关键字列表获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstByKeyLst_WA_Cache)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsAnswer4WorkEN> GetObjLstById_Answer4WorkLst_WA_Cache(List<string> arrId_Answer4Work)
{
 List<clsAnswer4WorkEN> arrObjLst = null; 
string strAction = "GetObjLstById_Answer4WorkLst_Cache";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
};
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrId_Answer4Work);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
arrObjLst = JsonConvert.DeserializeObject<List<clsAnswer4WorkEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsAnswer4WorkEN> GetTopObjLst(stuTopPara objTopPara)
{
 List<clsAnswer4WorkEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsAnswer4WorkEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsAnswer4WorkEN> GetObjLstByRange(stuRangePara objRangePara)
{
 List<clsAnswer4WorkEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsAnswer4WorkEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsAnswer4WorkEN> GetObjLstByPager(stuPagerPara objPagerPara)
{
 List<clsAnswer4WorkEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsAnswer4WorkEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsAnswer4WorkEN> GetObjLstByPager_Cache(stuPagerPara objPagerPara)
{
 List<clsAnswer4WorkEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsAnswer4WorkEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static int DelRecord(string strId_Answer4Work)
{
string strAction = "DelRecord";
string strErrMsg = string.Empty;
string strResult = "";
try
{
 clsAnswer4WorkEN objAnswer4WorkEN = clsAnswer4WorkWApi.GetObjById_Answer4Work(strId_Answer4Work);
if (clsPubFun4WApi.Delete(mstrApiControllerName, strAction, strId_Answer4Work.ToString(), out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
clsAnswer4WorkWApi.ReFreshCache();
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
public static int DelAnswer4Works(List<string> arrId_Answer4Work)
{
string strAction = "DelAnswer4Works";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrId_Answer4Work);
if (clsPubFun4WApi.Deletes(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
clsAnswer4WorkWApi.ReFreshCache();
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
public static int DelAnswer4WorksByCond(string strWhereCond)
{
string strAction = "DelAnswer4WorksByCond";
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
public static bool AddNewRecord(clsAnswer4WorkEN objAnswer4WorkEN)
{
string strAction = "AddNewRecord";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsAnswer4WorkEN>(objAnswer4WorkEN);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJson, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsAnswer4WorkWApi.ReFreshCache();
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
public static string AddNewRecordWithMaxId(clsAnswer4WorkEN objAnswer4WorkEN)
{
string strAction = "AddNewRecordWithMaxId";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsAnswer4WorkEN>(objAnswer4WorkEN);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJson, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsAnswer4WorkWApi.ReFreshCache();
var strId_Answer4Work = (string)jobjReturn["ReturnStr"];
return strId_Answer4Work;
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
public static bool UpdateRecord(clsAnswer4WorkEN objAnswer4WorkEN)
{
if (string.IsNullOrEmpty(objAnswer4WorkEN.sf_UpdFldSetStr) == true)
{
string strMsg = string.Format("修改时，修改标志串为空，请联系管理员.对象关键字:{0}.(from {1}).",
objAnswer4WorkEN.Id_Answer4Work, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
string strAction = "UpdateRecord";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsAnswer4WorkEN>(objAnswer4WorkEN);
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
 /// <param name = "objAnswer4WorkEN">需要修改的对象</param>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的关键字值</returns>
public static bool UpdateWithCondition(clsAnswer4WorkEN objAnswer4WorkEN, string strWhereCond)
{
if (string.IsNullOrEmpty(objAnswer4WorkEN.sf_UpdFldSetStr) == true)
{
string strMsg = string.Format("修改时，修改标志串为空，请联系管理员.对象关键字:{0}.(from {1}).",
objAnswer4WorkEN.Id_Answer4Work, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (string.IsNullOrEmpty(strWhereCond) == true)
{
string strMsg = string.Format("按条件修改时，条件串为空，请联系管理员.对象关键字:{0}.(from {1}).",
objAnswer4WorkEN.Id_Answer4Work, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
string strAction = "UpdateWithCondition";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsAnswer4WorkEN>(objAnswer4WorkEN);
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
public static bool IsExist(string strId_Answer4Work)
{
//检测记录是否存在
string strAction = "IsExist";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["Id_Answer4Work"] = strId_Answer4Work
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
 /// <param name = "objAnswer4WorkENS">源对象</param>
 /// <param name = "objAnswer4WorkENT">目标对象</param>
 public static void CopyTo(clsAnswer4WorkEN objAnswer4WorkENS, clsAnswer4WorkEN objAnswer4WorkENT)
{
try
{
objAnswer4WorkENT.Id_Answer4Work = objAnswer4WorkENS.Id_Answer4Work; //作业答案流水号
objAnswer4WorkENT.AnswerIndex = objAnswer4WorkENS.AnswerIndex; //问答序号
objAnswer4WorkENT.AnswerName = objAnswer4WorkENS.AnswerName; //问答名称
objAnswer4WorkENT.IsShow = objAnswer4WorkENS.IsShow; //是否启用
objAnswer4WorkENT.AnswerContent = objAnswer4WorkENS.AnswerContent; //答案内容
objAnswer4WorkENT.IsCorrect = objAnswer4WorkENS.IsCorrect; //是否正确
objAnswer4WorkENT.Id_Work = objAnswer4WorkENS.Id_Work; //作业流水号
objAnswer4WorkENT.QuestionResolve = objAnswer4WorkENS.QuestionResolve; //题目解析
objAnswer4WorkENT.UpdUser = objAnswer4WorkENS.UpdUser; //修改人
objAnswer4WorkENT.UpdDate = objAnswer4WorkENS.UpdDate; //修改日期
objAnswer4WorkENT.Memo = objAnswer4WorkENS.Memo; //备注
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
public static DataTable ToDataTable(List<clsAnswer4WorkEN> arrObj)
{
DataTable dataTable = new DataTable(); //实例化
DataTable result;
if (arrObj.Count == 0) return null;
if (clsAnswer4WorkEN.AttributeName.Length == 0)
{
result = dataTable;
return result;
}
Type type = typeof(clsAnswer4WorkEN);
PropertyInfo[] arrPropertyInfo = type.GetProperties();
try
{
//Columns
foreach (string strAttrName in clsAnswer4WorkEN.AttributeName)
{
PropertyInfo proprety_Curr = arrPropertyInfo.Where(x => x.Name == strAttrName).First();
dataTable.Columns.Add(strAttrName, proprety_Curr.PropertyType);
}
foreach (clsAnswer4WorkEN objInFor in arrObj)
{
//Rows
DataRow dataRow = dataTable.NewRow();
foreach (string strAttrName in clsAnswer4WorkEN.AttributeName)
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
if (clsAnswer4WorkWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsAnswer4WorkWApi没有刷新缓存机制(clsAnswer4WorkWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by Id_Answer4Work");
//if (arrAnswer4WorkObjLst_Cache == null)
//{
//arrAnswer4WorkObjLst_Cache = await clsAnswer4WorkWApi.GetObjLst(strWhereCond);
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
string strKey = string.Format("{0}", clsAnswer4WorkEN._CurrTabName_S);
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
if (clsAnswer4WorkWApi.objCommFun4BL != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}", clsAnswer4WorkEN._CurrTabName_S);
CacheHelper.Remove(strKey);
clsAnswer4WorkWApi.objCommFun4BL.ReFreshCache();
}
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst_Cache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsAnswer4WorkEN> GetObjLst_Cache()
{
//初始化列表缓存
InitListCache(); 
string strKey = string.Format("{0}", clsAnswer4WorkEN._CurrTabName_S);
List<clsAnswer4WorkEN> arrAnswer4WorkObjLst_Cache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrAnswer4WorkObjLst_Cache;
}

 /// <summary>
 /// 根据对象列表获取DataTable
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetDataTableByObjLst)
 /// </summary>
 /// <param name = "arrObjLst">给定的对象列表</param>
 /// <returns>返回DataTable</returns>
public static DataTable GetDataTableByObjLst(List<clsAnswer4WorkEN> arrObjLst)
{
DataTable objDT = new DataTable();
objDT.Columns.Add(conAnswer4Work.Id_Answer4Work, Type.GetType("System.String"));
objDT.Columns.Add(conAnswer4Work.AnswerIndex, Type.GetType("System.Int32"));
objDT.Columns.Add(conAnswer4Work.AnswerName, Type.GetType("System.String"));
objDT.Columns.Add(conAnswer4Work.IsShow, Type.GetType("System.Boolean"));
objDT.Columns.Add(conAnswer4Work.AnswerContent, Type.GetType("System.String"));
objDT.Columns.Add(conAnswer4Work.IsCorrect, Type.GetType("System.Boolean"));
objDT.Columns.Add(conAnswer4Work.Id_Work, Type.GetType("System.String"));
objDT.Columns.Add(conAnswer4Work.QuestionResolve, Type.GetType("System.String"));
objDT.Columns.Add(conAnswer4Work.UpdUser, Type.GetType("System.String"));
objDT.Columns.Add(conAnswer4Work.UpdDate, Type.GetType("System.String"));
objDT.Columns.Add(conAnswer4Work.Memo, Type.GetType("System.String"));
foreach (clsAnswer4WorkEN objInFor in arrObjLst)
{
DataRow objDR = objDT.NewRow();
objDR[conAnswer4Work.Id_Answer4Work] = objInFor[conAnswer4Work.Id_Answer4Work];
objDR[conAnswer4Work.AnswerIndex] = objInFor[conAnswer4Work.AnswerIndex];
objDR[conAnswer4Work.AnswerName] = objInFor[conAnswer4Work.AnswerName];
objDR[conAnswer4Work.IsShow] = objInFor[conAnswer4Work.IsShow];
objDR[conAnswer4Work.AnswerContent] = objInFor[conAnswer4Work.AnswerContent];
objDR[conAnswer4Work.IsCorrect] = objInFor[conAnswer4Work.IsCorrect];
objDR[conAnswer4Work.Id_Work] = objInFor[conAnswer4Work.Id_Work];
objDR[conAnswer4Work.QuestionResolve] = objInFor[conAnswer4Work.QuestionResolve];
objDR[conAnswer4Work.UpdUser] = objInFor[conAnswer4Work.UpdUser];
objDR[conAnswer4Work.UpdDate] = objInFor[conAnswer4Work.UpdDate];
objDR[conAnswer4Work.Memo] = objInFor[conAnswer4Work.Memo];
objDT.Rows.Add(objDR);
}
return objDT;
}
}
 /// <summary>
 /// 作业答案(Answer4Work)
 /// 数据源类型:SQL表
 /// (AutoGCLib.CommFun4WA4CSharp:GeneCode_This)
 /// </summary>
public class clsCommFun4WA4Answer4Work : clsCommFun4BL
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
clsAnswer4WorkWApi.ReFreshThisCache();
}
}

}