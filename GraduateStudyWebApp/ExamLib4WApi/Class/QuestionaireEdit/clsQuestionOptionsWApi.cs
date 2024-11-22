
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsQuestionOptionsWApi
 表名:QuestionOptions(01120188)
 生成代码版本:2021.09.20.1
 生成日期:2021/09/21 02:38:00
 生成者:pyf
 生成服务器IP:103.116.76.183
 工程名称:问卷调查
 工程ID:0112
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:问卷维护
 模块英文名:QuestionaireEdit
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
public static class clsQuestionOptionsWApi_Static
{

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQuestionOptionsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsQuestionOptionsEN SetQuestionOptionId(this clsQuestionOptionsEN objQuestionOptionsEN, string strQuestionOptionId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strQuestionOptionId, 8, conQuestionOptions.QuestionOptionId);
clsCheckSql.CheckFieldForeignKey(strQuestionOptionId, 8, conQuestionOptions.QuestionOptionId);
objQuestionOptionsEN.QuestionOptionId = strQuestionOptionId; //题目选项Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQuestionOptionsEN.dicFldComparisonOp.ContainsKey(conQuestionOptions.QuestionOptionId) == false)
{
objQuestionOptionsEN.dicFldComparisonOp.Add(conQuestionOptions.QuestionOptionId, strComparisonOp);
}
else
{
objQuestionOptionsEN.dicFldComparisonOp[conQuestionOptions.QuestionOptionId] = strComparisonOp;
}
}
return objQuestionOptionsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQuestionOptionsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsQuestionOptionsEN SetOptionName(this clsQuestionOptionsEN objQuestionOptionsEN, string strOptionName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strOptionName, 4000, conQuestionOptions.OptionName);
objQuestionOptionsEN.OptionName = strOptionName; //选项名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQuestionOptionsEN.dicFldComparisonOp.ContainsKey(conQuestionOptions.OptionName) == false)
{
objQuestionOptionsEN.dicFldComparisonOp.Add(conQuestionOptions.OptionName, strComparisonOp);
}
else
{
objQuestionOptionsEN.dicFldComparisonOp[conQuestionOptions.OptionName] = strComparisonOp;
}
}
return objQuestionOptionsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQuestionOptionsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsQuestionOptionsEN SetQuestionID(this clsQuestionOptionsEN objQuestionOptionsEN, string strQuestionID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strQuestionID, conQuestionOptions.QuestionID);
clsCheckSql.CheckFieldLen(strQuestionID, 8, conQuestionOptions.QuestionID);
clsCheckSql.CheckFieldForeignKey(strQuestionID, 8, conQuestionOptions.QuestionID);
objQuestionOptionsEN.QuestionID = strQuestionID; //题目ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQuestionOptionsEN.dicFldComparisonOp.ContainsKey(conQuestionOptions.QuestionID) == false)
{
objQuestionOptionsEN.dicFldComparisonOp.Add(conQuestionOptions.QuestionID, strComparisonOp);
}
else
{
objQuestionOptionsEN.dicFldComparisonOp[conQuestionOptions.QuestionID] = strComparisonOp;
}
}
return objQuestionOptionsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQuestionOptionsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsQuestionOptionsEN SetOptionIndex(this clsQuestionOptionsEN objQuestionOptionsEN, int intOptionIndex, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(intOptionIndex, conQuestionOptions.OptionIndex);
objQuestionOptionsEN.OptionIndex = intOptionIndex; //选项序号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQuestionOptionsEN.dicFldComparisonOp.ContainsKey(conQuestionOptions.OptionIndex) == false)
{
objQuestionOptionsEN.dicFldComparisonOp.Add(conQuestionOptions.OptionIndex, strComparisonOp);
}
else
{
objQuestionOptionsEN.dicFldComparisonOp[conQuestionOptions.OptionIndex] = strComparisonOp;
}
}
return objQuestionOptionsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQuestionOptionsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsQuestionOptionsEN SetOptionTitle(this clsQuestionOptionsEN objQuestionOptionsEN, string strOptionTitle, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strOptionTitle, 20, conQuestionOptions.OptionTitle);
objQuestionOptionsEN.OptionTitle = strOptionTitle; //选项标题
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQuestionOptionsEN.dicFldComparisonOp.ContainsKey(conQuestionOptions.OptionTitle) == false)
{
objQuestionOptionsEN.dicFldComparisonOp.Add(conQuestionOptions.OptionTitle, strComparisonOp);
}
else
{
objQuestionOptionsEN.dicFldComparisonOp[conQuestionOptions.OptionTitle] = strComparisonOp;
}
}
return objQuestionOptionsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQuestionOptionsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsQuestionOptionsEN SetOptionContent(this clsQuestionOptionsEN objQuestionOptionsEN, string strOptionContent, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strOptionContent, 4000, conQuestionOptions.OptionContent);
objQuestionOptionsEN.OptionContent = strOptionContent; //选项内容
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQuestionOptionsEN.dicFldComparisonOp.ContainsKey(conQuestionOptions.OptionContent) == false)
{
objQuestionOptionsEN.dicFldComparisonOp.Add(conQuestionOptions.OptionContent, strComparisonOp);
}
else
{
objQuestionOptionsEN.dicFldComparisonOp[conQuestionOptions.OptionContent] = strComparisonOp;
}
}
return objQuestionOptionsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQuestionOptionsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsQuestionOptionsEN SetIsCorrect(this clsQuestionOptionsEN objQuestionOptionsEN, bool bolIsCorrect, string strComparisonOp="")
	{
objQuestionOptionsEN.IsCorrect = bolIsCorrect; //是否正确
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQuestionOptionsEN.dicFldComparisonOp.ContainsKey(conQuestionOptions.IsCorrect) == false)
{
objQuestionOptionsEN.dicFldComparisonOp.Add(conQuestionOptions.IsCorrect, strComparisonOp);
}
else
{
objQuestionOptionsEN.dicFldComparisonOp[conQuestionOptions.IsCorrect] = strComparisonOp;
}
}
return objQuestionOptionsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQuestionOptionsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsQuestionOptionsEN SetScore(this clsQuestionOptionsEN objQuestionOptionsEN, double dblScore, string strComparisonOp="")
	{
objQuestionOptionsEN.Score = dblScore; //得分
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQuestionOptionsEN.dicFldComparisonOp.ContainsKey(conQuestionOptions.Score) == false)
{
objQuestionOptionsEN.dicFldComparisonOp.Add(conQuestionOptions.Score, strComparisonOp);
}
else
{
objQuestionOptionsEN.dicFldComparisonOp[conQuestionOptions.Score] = strComparisonOp;
}
}
return objQuestionOptionsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQuestionOptionsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsQuestionOptionsEN SetIsShow(this clsQuestionOptionsEN objQuestionOptionsEN, bool bolIsShow, string strComparisonOp="")
	{
objQuestionOptionsEN.IsShow = bolIsShow; //是否启用
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQuestionOptionsEN.dicFldComparisonOp.ContainsKey(conQuestionOptions.IsShow) == false)
{
objQuestionOptionsEN.dicFldComparisonOp.Add(conQuestionOptions.IsShow, strComparisonOp);
}
else
{
objQuestionOptionsEN.dicFldComparisonOp[conQuestionOptions.IsShow] = strComparisonOp;
}
}
return objQuestionOptionsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQuestionOptionsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsQuestionOptionsEN SetCourseId(this clsQuestionOptionsEN objQuestionOptionsEN, string strCourseId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strCourseId, conQuestionOptions.CourseId);
clsCheckSql.CheckFieldLen(strCourseId, 8, conQuestionOptions.CourseId);
clsCheckSql.CheckFieldForeignKey(strCourseId, 8, conQuestionOptions.CourseId);
objQuestionOptionsEN.CourseId = strCourseId; //课程Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQuestionOptionsEN.dicFldComparisonOp.ContainsKey(conQuestionOptions.CourseId) == false)
{
objQuestionOptionsEN.dicFldComparisonOp.Add(conQuestionOptions.CourseId, strComparisonOp);
}
else
{
objQuestionOptionsEN.dicFldComparisonOp[conQuestionOptions.CourseId] = strComparisonOp;
}
}
return objQuestionOptionsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQuestionOptionsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsQuestionOptionsEN SetUpdDate(this clsQuestionOptionsEN objQuestionOptionsEN, string strUpdDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strUpdDate, conQuestionOptions.UpdDate);
clsCheckSql.CheckFieldLen(strUpdDate, 20, conQuestionOptions.UpdDate);
objQuestionOptionsEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQuestionOptionsEN.dicFldComparisonOp.ContainsKey(conQuestionOptions.UpdDate) == false)
{
objQuestionOptionsEN.dicFldComparisonOp.Add(conQuestionOptions.UpdDate, strComparisonOp);
}
else
{
objQuestionOptionsEN.dicFldComparisonOp[conQuestionOptions.UpdDate] = strComparisonOp;
}
}
return objQuestionOptionsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQuestionOptionsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsQuestionOptionsEN SetUpdUser(this clsQuestionOptionsEN objQuestionOptionsEN, string strUpdUser, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strUpdUser, conQuestionOptions.UpdUser);
clsCheckSql.CheckFieldLen(strUpdUser, 20, conQuestionOptions.UpdUser);
objQuestionOptionsEN.UpdUser = strUpdUser; //修改人
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQuestionOptionsEN.dicFldComparisonOp.ContainsKey(conQuestionOptions.UpdUser) == false)
{
objQuestionOptionsEN.dicFldComparisonOp.Add(conQuestionOptions.UpdUser, strComparisonOp);
}
else
{
objQuestionOptionsEN.dicFldComparisonOp[conQuestionOptions.UpdUser] = strComparisonOp;
}
}
return objQuestionOptionsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQuestionOptionsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsQuestionOptionsEN SetMemo(this clsQuestionOptionsEN objQuestionOptionsEN, string strMemo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMemo, 1000, conQuestionOptions.Memo);
objQuestionOptionsEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQuestionOptionsEN.dicFldComparisonOp.ContainsKey(conQuestionOptions.Memo) == false)
{
objQuestionOptionsEN.dicFldComparisonOp.Add(conQuestionOptions.Memo, strComparisonOp);
}
else
{
objQuestionOptionsEN.dicFldComparisonOp[conQuestionOptions.Memo] = strComparisonOp;
}
}
return objQuestionOptionsEN;
	}

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsQuestionOptionsEN objQuestionOptions_Cond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objQuestionOptions_Cond.IsUpdated(conQuestionOptions.QuestionOptionId) == true)
{
string strComparisonOp_QuestionOptionId = objQuestionOptions_Cond.dicFldComparisonOp[conQuestionOptions.QuestionOptionId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conQuestionOptions.QuestionOptionId, objQuestionOptions_Cond.QuestionOptionId, strComparisonOp_QuestionOptionId);
}
if (objQuestionOptions_Cond.IsUpdated(conQuestionOptions.OptionName) == true)
{
string strComparisonOp_OptionName = objQuestionOptions_Cond.dicFldComparisonOp[conQuestionOptions.OptionName];
strWhereCond += string.Format(" And {0} {2} '{1}'", conQuestionOptions.OptionName, objQuestionOptions_Cond.OptionName, strComparisonOp_OptionName);
}
if (objQuestionOptions_Cond.IsUpdated(conQuestionOptions.QuestionID) == true)
{
string strComparisonOp_QuestionID = objQuestionOptions_Cond.dicFldComparisonOp[conQuestionOptions.QuestionID];
strWhereCond += string.Format(" And {0} {2} '{1}'", conQuestionOptions.QuestionID, objQuestionOptions_Cond.QuestionID, strComparisonOp_QuestionID);
}
if (objQuestionOptions_Cond.IsUpdated(conQuestionOptions.OptionIndex) == true)
{
string strComparisonOp_OptionIndex = objQuestionOptions_Cond.dicFldComparisonOp[conQuestionOptions.OptionIndex];
strWhereCond += string.Format(" And {0} {2} {1}", conQuestionOptions.OptionIndex, objQuestionOptions_Cond.OptionIndex, strComparisonOp_OptionIndex);
}
if (objQuestionOptions_Cond.IsUpdated(conQuestionOptions.OptionTitle) == true)
{
string strComparisonOp_OptionTitle = objQuestionOptions_Cond.dicFldComparisonOp[conQuestionOptions.OptionTitle];
strWhereCond += string.Format(" And {0} {2} '{1}'", conQuestionOptions.OptionTitle, objQuestionOptions_Cond.OptionTitle, strComparisonOp_OptionTitle);
}
if (objQuestionOptions_Cond.IsUpdated(conQuestionOptions.OptionContent) == true)
{
string strComparisonOp_OptionContent = objQuestionOptions_Cond.dicFldComparisonOp[conQuestionOptions.OptionContent];
strWhereCond += string.Format(" And {0} {2} '{1}'", conQuestionOptions.OptionContent, objQuestionOptions_Cond.OptionContent, strComparisonOp_OptionContent);
}
if (objQuestionOptions_Cond.IsUpdated(conQuestionOptions.IsCorrect) == true)
{
if (objQuestionOptions_Cond.IsCorrect == true)
{
strWhereCond += string.Format(" And {0} = '1'", conQuestionOptions.IsCorrect);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conQuestionOptions.IsCorrect);
}
}
if (objQuestionOptions_Cond.IsUpdated(conQuestionOptions.Score) == true)
{
string strComparisonOp_Score = objQuestionOptions_Cond.dicFldComparisonOp[conQuestionOptions.Score];
strWhereCond += string.Format(" And {0} {2} {1}", conQuestionOptions.Score, objQuestionOptions_Cond.Score, strComparisonOp_Score);
}
if (objQuestionOptions_Cond.IsUpdated(conQuestionOptions.IsShow) == true)
{
if (objQuestionOptions_Cond.IsShow == true)
{
strWhereCond += string.Format(" And {0} = '1'", conQuestionOptions.IsShow);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conQuestionOptions.IsShow);
}
}
if (objQuestionOptions_Cond.IsUpdated(conQuestionOptions.CourseId) == true)
{
string strComparisonOp_CourseId = objQuestionOptions_Cond.dicFldComparisonOp[conQuestionOptions.CourseId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conQuestionOptions.CourseId, objQuestionOptions_Cond.CourseId, strComparisonOp_CourseId);
}
if (objQuestionOptions_Cond.IsUpdated(conQuestionOptions.UpdDate) == true)
{
string strComparisonOp_UpdDate = objQuestionOptions_Cond.dicFldComparisonOp[conQuestionOptions.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conQuestionOptions.UpdDate, objQuestionOptions_Cond.UpdDate, strComparisonOp_UpdDate);
}
if (objQuestionOptions_Cond.IsUpdated(conQuestionOptions.UpdUser) == true)
{
string strComparisonOp_UpdUser = objQuestionOptions_Cond.dicFldComparisonOp[conQuestionOptions.UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", conQuestionOptions.UpdUser, objQuestionOptions_Cond.UpdUser, strComparisonOp_UpdUser);
}
if (objQuestionOptions_Cond.IsUpdated(conQuestionOptions.Memo) == true)
{
string strComparisonOp_Memo = objQuestionOptions_Cond.dicFldComparisonOp[conQuestionOptions.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", conQuestionOptions.Memo, objQuestionOptions_Cond.Memo, strComparisonOp_Memo);
}
 return strWhereCond;
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_Update)
 /// </summary>
 /// <param name = "objQuestionOptionsEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsQuestionOptionsEN objQuestionOptionsEN)
{
 if (string.IsNullOrEmpty(objQuestionOptionsEN.QuestionOptionId) == true)
 {
string strMsg = string.Format("(errid:Watl000003)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
objQuestionOptionsEN.sf_UpdFldSetStr = objQuestionOptionsEN.getsf_UpdFldSetStr();
clsQuestionOptionsWApi.CheckPropertyNew(objQuestionOptionsEN); 
bool bolResult = clsQuestionOptionsWApi.UpdateRecord(objQuestionOptionsEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsQuestionOptionsWApi.ReFreshCache(objQuestionOptionsEN.CourseId);
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
 /// 检查唯一性(Uniqueness)--QuestionOptions(题目选项), 如果不唯一,即存在相同的记录,就返回False
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_GetConditionString4Constraint)
 /// </summary>
 /// <param name = "objQuestionOptionsEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniConditionStr_QuestionOptionId(this clsQuestionOptionsEN objQuestionOptionsEN)
{
//检测记录是否存在
StringBuilder sbCondition = new StringBuilder();
if (objQuestionOptionsEN == null) return "";
if (objQuestionOptionsEN.QuestionOptionId == null || objQuestionOptionsEN.QuestionOptionId == "")
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and QuestionOptionId = '{0}'", objQuestionOptionsEN.QuestionOptionId);
return sbCondition.ToString();
}
 else {
sbCondition.AppendFormat("QuestionOptionId !=  '{0}'", objQuestionOptionsEN.QuestionOptionId);
 sbCondition.AppendFormat(" and QuestionOptionId = '{0}'", objQuestionOptionsEN.QuestionOptionId);
 return sbCondition.ToString();
}
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_AddNewRecord)
 /// </summary>
 /// <param name = "objQuestionOptionsEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clsQuestionOptionsEN objQuestionOptionsEN)
{
try
{
 if (string.IsNullOrEmpty(objQuestionOptionsEN.QuestionOptionId) == true || clsQuestionOptionsWApi.IsExist(objQuestionOptionsEN.QuestionOptionId) == true)
 {
     objQuestionOptionsEN.QuestionOptionId = clsQuestionOptionsWApi.GetMaxStrId();
 }
clsQuestionOptionsWApi.CheckPropertyNew(objQuestionOptionsEN); 
bool bolResult = clsQuestionOptionsWApi.AddNewRecord(objQuestionOptionsEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsQuestionOptionsWApi.ReFreshCache(objQuestionOptionsEN.CourseId);
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
 /// <param name = "objQuestionOptionsEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static string AddNewRecordWithMaxId(this clsQuestionOptionsEN objQuestionOptionsEN)
{
try
{
clsQuestionOptionsWApi.CheckPropertyNew(objQuestionOptionsEN); 
string strQuestionOptionId = clsQuestionOptionsWApi.AddNewRecordWithMaxId(objQuestionOptionsEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsQuestionOptionsWApi.ReFreshCache(objQuestionOptionsEN.CourseId);
return strQuestionOptionId;
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
 /// <param name = "objQuestionOptionsEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsQuestionOptionsEN objQuestionOptionsEN, string strWhereCond)
{
try
{
clsQuestionOptionsWApi.CheckPropertyNew(objQuestionOptionsEN); 
bool bolResult = clsQuestionOptionsWApi.UpdateWithCondition(objQuestionOptionsEN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsQuestionOptionsWApi.ReFreshCache(objQuestionOptionsEN.CourseId);
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
 /// 题目选项(QuestionOptions)
 /// (AutoGCLib.WA_Access4CSharp:GeneCode)
 /// </summary>
public class clsQuestionOptionsWApi
{
private static readonly string mstrApiControllerName = "QuestionOptionsApi";

 /// <summary>
/// 专门在逻辑层用于处理缓存等公共函数的对象
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_DefineObjCommFun4BL)
/// </summary>
public static clsCommFun4BLV2 objCommFun4BL = null;

 public clsQuestionOptionsWApi()
 {
 }

 /// <summary>
 /// 绑定基于Web的下拉框
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_DdlBindFunction)
 /// </summary>
 /// <param name="objDDL">需要绑定当前表的下拉框</param>
public static void BindDdl_QuestionOptionId(System.Web.UI.WebControls.DropDownList objDDL)
{
//为数据源于表的下拉框设置内容
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[题目选项]...","0");
List<clsQuestionOptionsEN> arrObjLst = GetObjLst("1=1");
objDDL.DataValueField="QuestionOptionId";
objDDL.DataTextField="OptionName";
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
public static void BindCbo_QuestionOptionId(System.Windows.Forms.ComboBox objComboBox )
{
//为数据源为表的下拉框设置内容
string strCondition = string.Format("1 =1 Order By {0}", conQuestionOptions.QuestionOptionId); 
List<clsQuestionOptionsEN> arrObjLst = clsQuestionOptionsWApi.GetObjLst(strCondition);
//初始化一个对象列表
//插入第0项。在第0项中插入“请选择...”,为了方便用户,与WEB方式类似。
clsQuestionOptionsEN objQuestionOptionsEN = new clsQuestionOptionsEN()
{
QuestionOptionId = "0",
OptionName = "选[题目选项]..."
};
arrObjLst.Insert(0, objQuestionOptionsEN);
//设置下拉框的数据源、以及设置值项、显示项
objComboBox.ValueMember = conQuestionOptions.QuestionOptionId;
objComboBox.DisplayMember = conQuestionOptions.OptionName;
objComboBox.DataSource = arrObjLst;
objComboBox.SelectedIndex = 0;
}

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_CheckPropertyNew)
 /// </summary>
public static void CheckPropertyNew(clsQuestionOptionsEN objQuestionOptionsEN)
{
if (!Object.Equals(null, objQuestionOptionsEN.QuestionOptionId) && GetStrLen(objQuestionOptionsEN.QuestionOptionId) > 8)
{
 throw new Exception("字段[题目选项Id]的长度不能超过8!");
}
if (!Object.Equals(null, objQuestionOptionsEN.OptionName) && GetStrLen(objQuestionOptionsEN.OptionName) > 4000)
{
 throw new Exception("字段[选项名称]的长度不能超过4000!");
}
if (!Object.Equals(null, objQuestionOptionsEN.QuestionID) && GetStrLen(objQuestionOptionsEN.QuestionID) > 8)
{
 throw new Exception("字段[题目ID]的长度不能超过8!");
}
if (!Object.Equals(null, objQuestionOptionsEN.OptionTitle) && GetStrLen(objQuestionOptionsEN.OptionTitle) > 20)
{
 throw new Exception("字段[选项标题]的长度不能超过20!");
}
if (!Object.Equals(null, objQuestionOptionsEN.OptionContent) && GetStrLen(objQuestionOptionsEN.OptionContent) > 4000)
{
 throw new Exception("字段[选项内容]的长度不能超过4000!");
}
if (!Object.Equals(null, objQuestionOptionsEN.CourseId) && GetStrLen(objQuestionOptionsEN.CourseId) > 8)
{
 throw new Exception("字段[课程Id]的长度不能超过8!");
}
if (!Object.Equals(null, objQuestionOptionsEN.UpdDate) && GetStrLen(objQuestionOptionsEN.UpdDate) > 20)
{
 throw new Exception("字段[修改日期]的长度不能超过20!");
}
if (!Object.Equals(null, objQuestionOptionsEN.UpdUser) && GetStrLen(objQuestionOptionsEN.UpdUser) > 20)
{
 throw new Exception("字段[修改人]的长度不能超过20!");
}
if (!Object.Equals(null, objQuestionOptionsEN.Memo) && GetStrLen(objQuestionOptionsEN.Memo) > 1000)
{
 throw new Exception("字段[备注]的长度不能超过1000!");
}
 objQuestionOptionsEN._IsCheckProperty = true;
 }

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyId)
 /// </summary>
 /// <param name = "strQuestionOptionId">表关键字</param>
 /// <returns>表对象</returns>
public static clsQuestionOptionsEN GetObjByQuestionOptionId(string strQuestionOptionId)
{
string strAction = "GetObjByQuestionOptionId";
string strErrMsg = string.Empty;
string strResult = "";
clsQuestionOptionsEN objQuestionOptionsEN = null;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["QuestionOptionId"] = strQuestionOptionId
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
objQuestionOptionsEN = JsonConvert.DeserializeObject<clsQuestionOptionsEN>((string)jobjReturn["ReturnObj"]);
return objQuestionOptionsEN;
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
 /// <param name = "strQuestionOptionId">表关键字</param>
 /// <returns>表对象</returns>
public static clsQuestionOptionsEN GetObjByQuestionOptionId_WA_Cache(string strQuestionOptionId, string strCourseId)
{
string strAction = "GetObjByQuestionOptionId_Cache";
string strErrMsg = string.Empty;
string strResult = "";
clsQuestionOptionsEN objQuestionOptionsEN = null;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["QuestionOptionId"] = strQuestionOptionId,
["CourseId"] = strCourseId
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
objQuestionOptionsEN = JsonConvert.DeserializeObject<clsQuestionOptionsEN>((string)jobjReturn["ReturnObj"]);
return objQuestionOptionsEN;
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
public static clsQuestionOptionsEN GetFirstObj(string strWhereCond)
{
string strAction = "GetFirstObj";
string strErrMsg = string.Empty;
string strResult = "";
clsQuestionOptionsEN objQuestionOptionsEN = null;
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
objQuestionOptionsEN = JsonConvert.DeserializeObject<clsQuestionOptionsEN>((string)jobjReturn["ReturnObj"]);
return objQuestionOptionsEN;
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
 /// <param name = "strQuestionOptionId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsQuestionOptionsEN GetObjByQuestionOptionId_Cache(string strQuestionOptionId, string strCourseId)
{
if (string.IsNullOrEmpty(strQuestionOptionId) == true) return null;
//初始化列表缓存
string strKey = string.Format("{0}_{1}", clsQuestionOptionsEN._CurrTabName_S, strCourseId);
List<clsQuestionOptionsEN> arrQuestionOptionsObjLst_Cache = GetObjLst_Cache(strCourseId);
IEnumerable <clsQuestionOptionsEN> arrQuestionOptionsObjLst_Sel =
from objQuestionOptionsEN in arrQuestionOptionsObjLst_Cache
where objQuestionOptionsEN.QuestionOptionId == strQuestionOptionId
select objQuestionOptionsEN;
if (arrQuestionOptionsObjLst_Sel.Count() == 0)
{
   clsQuestionOptionsEN obj = clsQuestionOptionsWApi.GetObjByQuestionOptionId(strQuestionOptionId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
     return obj;
 }
return null;
}
return arrQuestionOptionsObjLst_Sel.First();
}

 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetRecNameByKey_Cache)
 /// </summary>
 /// <param name = "strQuestionOptionId">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetOptionNameByQuestionOptionId_Cache(string strQuestionOptionId, string strCourseId)
{
if (string.IsNullOrEmpty(strQuestionOptionId) == true) return "";
//初始化列表缓存
string strKey = string.Format("{0}_{1}", clsQuestionOptionsEN._CurrTabName_S, strCourseId);
List<clsQuestionOptionsEN> arrQuestionOptionsObjLst_Cache = GetObjLst_Cache(strCourseId);
IEnumerable <clsQuestionOptionsEN> arrQuestionOptionsObjLst_Sel1 =
from objQuestionOptionsEN in arrQuestionOptionsObjLst_Cache
where objQuestionOptionsEN.QuestionOptionId == strQuestionOptionId
select objQuestionOptionsEN;
List <clsQuestionOptionsEN> arrQuestionOptionsObjLst_Sel = new List<clsQuestionOptionsEN>();
foreach (clsQuestionOptionsEN obj in arrQuestionOptionsObjLst_Sel1)
{
arrQuestionOptionsObjLst_Sel.Add(obj);
}
if (arrQuestionOptionsObjLst_Sel.Count > 0)
{
return arrQuestionOptionsObjLst_Sel[0].OptionName;
}
string strErrMsgForGetObjById = string.Format("在QuestionOptions对象缓存列表中,找不到记录[QuestionOptionId = {0}](函数:{1})", strQuestionOptionId, clsStackTrace.GetCurrFunction());
clsLog.LogErrorS2("clsQuestionOptionsBL", clsStackTrace.GetCurrClassFunction(), strErrMsgForGetObjById, "", "");
throw new Exception(strErrMsgForGetObjById);
}
 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetRecNameByKey_Cache)
 /// </summary>
 /// <param name = "strQuestionOptionId">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetNameByQuestionOptionId_Cache(string strQuestionOptionId, string strCourseId)
{
if (string.IsNullOrEmpty(strQuestionOptionId) == true) return "";
//初始化列表缓存
string strKey = string.Format("{0}_{1}", clsQuestionOptionsEN._CurrTabName_S, strCourseId);
List<clsQuestionOptionsEN> arrQuestionOptionsObjLst_Cache = GetObjLst_Cache(strCourseId);
IEnumerable <clsQuestionOptionsEN> arrQuestionOptionsObjLst_Sel1 =
from objQuestionOptionsEN in arrQuestionOptionsObjLst_Cache
where objQuestionOptionsEN.QuestionOptionId == strQuestionOptionId
select objQuestionOptionsEN;
List <clsQuestionOptionsEN> arrQuestionOptionsObjLst_Sel = new List<clsQuestionOptionsEN>();
foreach (clsQuestionOptionsEN obj in arrQuestionOptionsObjLst_Sel1)
{
arrQuestionOptionsObjLst_Sel.Add(obj);
}
if (arrQuestionOptionsObjLst_Sel.Count > 0)
{
return arrQuestionOptionsObjLst_Sel[0].OptionName;
}
string strErrMsgForGetObjById = string.Format("在QuestionOptions对象缓存列表中,找不到记录的相关名称[QuestionOptionId = {0}](函数:{1})", strQuestionOptionId, clsStackTrace.GetCurrFunction());
clsLog.LogErrorS2("clsQuestionOptionsBL", clsStackTrace.GetCurrClassFunction(), strErrMsgForGetObjById, "", "");
throw new Exception(strErrMsgForGetObjById);
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsQuestionOptionsEN> GetObjLst(string strWhereCond)
{
 List<clsQuestionOptionsEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsQuestionOptionsEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsQuestionOptionsEN> GetObjLstByQuestionOptionIdLst(List<string> arrQuestionOptionId)
{
 List<clsQuestionOptionsEN> arrObjLst = null; 
string strAction = "GetObjLstByQuestionOptionIdLst";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrQuestionOptionId);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
arrObjLst = JsonConvert.DeserializeObject<List<clsQuestionOptionsEN>>((string)jobjReturn["ReturnObjLst"]);
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
 /// <param name = "strQuestionOptionId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static IEnumerable<clsQuestionOptionsEN> GetObjLstByQuestionOptionIdLst_Cache(List<string> arrQuestionOptionId, string strCourseId)
{
//初始化列表缓存
string strKey = string.Format("{0}_{1}", clsQuestionOptionsEN._CurrTabName_S, strCourseId);
List<clsQuestionOptionsEN> arrQuestionOptionsObjLst_Cache = GetObjLst_Cache(strCourseId);
IEnumerable <clsQuestionOptionsEN> arrQuestionOptionsObjLst_Sel =
from objQuestionOptionsEN in arrQuestionOptionsObjLst_Cache
where arrQuestionOptionId.Contains(objQuestionOptionsEN.QuestionOptionId)
select objQuestionOptionsEN;
return arrQuestionOptionsObjLst_Sel;
}

 /// <summary>
 /// 根据关键字列表获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstByKeyLst_WA_Cache)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsQuestionOptionsEN> GetObjLstByQuestionOptionIdLst_WA_Cache(List<string> arrQuestionOptionId, string strCourseId)
{
 List<clsQuestionOptionsEN> arrObjLst = null; 
string strAction = "GetObjLstByQuestionOptionIdLst_Cache";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["CourseId"] = strCourseId
};
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrQuestionOptionId);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
arrObjLst = JsonConvert.DeserializeObject<List<clsQuestionOptionsEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsQuestionOptionsEN> GetTopObjLst(stuTopPara objTopPara)
{
 List<clsQuestionOptionsEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsQuestionOptionsEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsQuestionOptionsEN> GetObjLstByRange(stuRangePara objRangePara)
{
 List<clsQuestionOptionsEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsQuestionOptionsEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsQuestionOptionsEN> GetObjLstByPager(stuPagerPara objPagerPara)
{
 List<clsQuestionOptionsEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsQuestionOptionsEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsQuestionOptionsEN> GetObjLstByPager_Cache(stuPagerPara objPagerPara)
{
 List<clsQuestionOptionsEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsQuestionOptionsEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static int DelRecord(string strQuestionOptionId)
{
string strAction = "DelRecord";
string strErrMsg = string.Empty;
string strResult = "";
try
{
 clsQuestionOptionsEN objQuestionOptionsEN = clsQuestionOptionsWApi.GetObjByQuestionOptionId(strQuestionOptionId);
if (clsPubFun4WApi.Delete(mstrApiControllerName, strAction, strQuestionOptionId.ToString(), out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
clsQuestionOptionsWApi.ReFreshCache(objQuestionOptionsEN.CourseId);
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
public static int DelQuestionOptionss(List<string> arrQuestionOptionId)
{
string strAction = "DelQuestionOptionss";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrQuestionOptionId);
if (clsPubFun4WApi.Deletes(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
 clsQuestionOptionsEN objQuestionOptionsEN = clsQuestionOptionsWApi.GetObjByQuestionOptionId(arrQuestionOptionId[0]);
clsQuestionOptionsWApi.ReFreshCache(objQuestionOptionsEN.CourseId);
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
public static int DelQuestionOptionssByCond(string strWhereCond)
{
string strAction = "DelQuestionOptionssByCond";
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
public static bool AddNewRecord(clsQuestionOptionsEN objQuestionOptionsEN)
{
string strAction = "AddNewRecord";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsQuestionOptionsEN>(objQuestionOptionsEN);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJson, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsQuestionOptionsWApi.ReFreshCache(objQuestionOptionsEN.CourseId);
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
public static string AddNewRecordWithMaxId(clsQuestionOptionsEN objQuestionOptionsEN)
{
string strAction = "AddNewRecordWithMaxId";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsQuestionOptionsEN>(objQuestionOptionsEN);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJson, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsQuestionOptionsWApi.ReFreshCache(objQuestionOptionsEN.CourseId);
var strQuestionOptionId = (string)jobjReturn["ReturnStr"];
return strQuestionOptionId;
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
public static bool UpdateRecord(clsQuestionOptionsEN objQuestionOptionsEN)
{
if (string.IsNullOrEmpty(objQuestionOptionsEN.sf_UpdFldSetStr) == true)
{
string strMsg = string.Format("修改时，修改标志串为空，请联系管理员.对象关键字:{0}.(from {1}).",
objQuestionOptionsEN.QuestionOptionId, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
string strAction = "UpdateRecord";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsQuestionOptionsEN>(objQuestionOptionsEN);
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
 /// <param name = "objQuestionOptionsEN">需要修改的对象</param>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的关键字值</returns>
public static bool UpdateWithCondition(clsQuestionOptionsEN objQuestionOptionsEN, string strWhereCond)
{
if (string.IsNullOrEmpty(objQuestionOptionsEN.sf_UpdFldSetStr) == true)
{
string strMsg = string.Format("修改时，修改标志串为空，请联系管理员.对象关键字:{0}.(from {1}).",
objQuestionOptionsEN.QuestionOptionId, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (string.IsNullOrEmpty(strWhereCond) == true)
{
string strMsg = string.Format("按条件修改时，条件串为空，请联系管理员.对象关键字:{0}.(from {1}).",
objQuestionOptionsEN.QuestionOptionId, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
string strAction = "UpdateWithCondition";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsQuestionOptionsEN>(objQuestionOptionsEN);
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
public static bool IsExist(string strQuestionOptionId)
{
//检测记录是否存在
string strAction = "IsExist";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["QuestionOptionId"] = strQuestionOptionId
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
 /// <param name = "objQuestionOptionsENS">源对象</param>
 /// <param name = "objQuestionOptionsENT">目标对象</param>
 public static void CopyTo(clsQuestionOptionsEN objQuestionOptionsENS, clsQuestionOptionsEN objQuestionOptionsENT)
{
try
{
objQuestionOptionsENT.QuestionOptionId = objQuestionOptionsENS.QuestionOptionId; //题目选项Id
objQuestionOptionsENT.OptionName = objQuestionOptionsENS.OptionName; //选项名称
objQuestionOptionsENT.QuestionID = objQuestionOptionsENS.QuestionID; //题目ID
objQuestionOptionsENT.OptionIndex = objQuestionOptionsENS.OptionIndex; //选项序号
objQuestionOptionsENT.OptionTitle = objQuestionOptionsENS.OptionTitle; //选项标题
objQuestionOptionsENT.OptionContent = objQuestionOptionsENS.OptionContent; //选项内容
objQuestionOptionsENT.IsCorrect = objQuestionOptionsENS.IsCorrect; //是否正确
objQuestionOptionsENT.Score = objQuestionOptionsENS.Score; //得分
objQuestionOptionsENT.IsShow = objQuestionOptionsENS.IsShow; //是否启用
objQuestionOptionsENT.CourseId = objQuestionOptionsENS.CourseId; //课程Id
objQuestionOptionsENT.UpdDate = objQuestionOptionsENS.UpdDate; //修改日期
objQuestionOptionsENT.UpdUser = objQuestionOptionsENS.UpdUser; //修改人
objQuestionOptionsENT.Memo = objQuestionOptionsENS.Memo; //备注
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
public static DataTable ToDataTable(List<clsQuestionOptionsEN> arrObj)
{
DataTable dataTable = new DataTable(); //实例化
DataTable result;
if (arrObj.Count == 0) return null;
if (clsQuestionOptionsEN.AttributeName.Length == 0)
{
result = dataTable;
return result;
}
Type type = typeof(clsQuestionOptionsEN);
PropertyInfo[] arrPropertyInfo = type.GetProperties();
try
{
//Columns
foreach (string strAttrName in clsQuestionOptionsEN.AttributeName)
{
PropertyInfo proprety_Curr = arrPropertyInfo.Where(x => x.Name == strAttrName).First();
dataTable.Columns.Add(strAttrName, proprety_Curr.PropertyType);
}
foreach (clsQuestionOptionsEN objInFor in arrObj)
{
//Rows
DataRow dataRow = dataTable.NewRow();
foreach (string strAttrName in clsQuestionOptionsEN.AttributeName)
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
if (clsQuestionOptionsWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsQuestionOptionsWApi没有刷新缓存机制(clsQuestionOptionsWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by QuestionOptionId");
//if (arrQuestionOptionsObjLst_Cache == null)
//{
//arrQuestionOptionsObjLst_Cache = await clsQuestionOptionsWApi.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 刷新本类中的缓存.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_ReFreshThisCache)
 /// </summary>
public static void ReFreshThisCache(string strCourseId = "")
{
string strMsg = "";
if (clsSysParaEN.spSetRefreshCacheOn == true)
{
string strKey = string.Format("{0}_{1}", clsQuestionOptionsEN._CurrTabName_S, strCourseId);
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
public static void ReFreshCache(string strCourseId)
{
  if (clsSysParaEN.spIsUseQueue4Task == true)
{
if (clsSysParaEN.arrFunctionLst4Queue == null)
{
clsSysParaEN.arrFunctionLst4Queue = new Queue<object>();
}
}
if (clsQuestionOptionsWApi.objCommFun4BL != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}_{1}", clsQuestionOptionsEN._CurrTabName_S, strCourseId);
CacheHelper.Remove(strKey);
clsQuestionOptionsWApi.objCommFun4BL.ReFreshCache(strCourseId);
}
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst_Cache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsQuestionOptionsEN> GetObjLst_Cache(string strCourseId)
{
//初始化列表缓存
InitListCache(); 
string strKey = string.Format("{0}_{1}", clsQuestionOptionsEN._CurrTabName_S, strCourseId);
List<clsQuestionOptionsEN> arrQuestionOptionsObjLst_Cache = CacheHelper.GetCache(strKey, () => { return GetObjLst(string.Format("CourseId='{0}'", strCourseId)); });
return arrQuestionOptionsObjLst_Cache;
}

 /// <summary>
 /// 根据对象列表获取DataTable
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetDataTableByObjLst)
 /// </summary>
 /// <param name = "arrObjLst">给定的对象列表</param>
 /// <returns>返回DataTable</returns>
public static DataTable GetDataTableByObjLst(List<clsQuestionOptionsEN> arrObjLst)
{
DataTable objDT = new DataTable();
objDT.Columns.Add(conQuestionOptions.QuestionOptionId, Type.GetType("System.String"));
objDT.Columns.Add(conQuestionOptions.OptionName, Type.GetType("System.String"));
objDT.Columns.Add(conQuestionOptions.QuestionID, Type.GetType("System.String"));
objDT.Columns.Add(conQuestionOptions.OptionIndex, Type.GetType("System.Int32"));
objDT.Columns.Add(conQuestionOptions.OptionTitle, Type.GetType("System.String"));
objDT.Columns.Add(conQuestionOptions.OptionContent, Type.GetType("System.String"));
objDT.Columns.Add(conQuestionOptions.IsCorrect, Type.GetType("System.Boolean"));
objDT.Columns.Add(conQuestionOptions.Score, Type.GetType("System.Decimal"));
objDT.Columns.Add(conQuestionOptions.IsShow, Type.GetType("System.Boolean"));
objDT.Columns.Add(conQuestionOptions.CourseId, Type.GetType("System.String"));
objDT.Columns.Add(conQuestionOptions.UpdDate, Type.GetType("System.String"));
objDT.Columns.Add(conQuestionOptions.UpdUser, Type.GetType("System.String"));
objDT.Columns.Add(conQuestionOptions.Memo, Type.GetType("System.String"));
foreach (clsQuestionOptionsEN objInFor in arrObjLst)
{
DataRow objDR = objDT.NewRow();
objDR[conQuestionOptions.QuestionOptionId] = objInFor[conQuestionOptions.QuestionOptionId];
objDR[conQuestionOptions.OptionName] = objInFor[conQuestionOptions.OptionName];
objDR[conQuestionOptions.QuestionID] = objInFor[conQuestionOptions.QuestionID];
objDR[conQuestionOptions.OptionIndex] = objInFor[conQuestionOptions.OptionIndex];
objDR[conQuestionOptions.OptionTitle] = objInFor[conQuestionOptions.OptionTitle];
objDR[conQuestionOptions.OptionContent] = objInFor[conQuestionOptions.OptionContent];
objDR[conQuestionOptions.IsCorrect] = objInFor[conQuestionOptions.IsCorrect];
objDR[conQuestionOptions.Score] = objInFor[conQuestionOptions.Score];
objDR[conQuestionOptions.IsShow] = objInFor[conQuestionOptions.IsShow];
objDR[conQuestionOptions.CourseId] = objInFor[conQuestionOptions.CourseId];
objDR[conQuestionOptions.UpdDate] = objInFor[conQuestionOptions.UpdDate];
objDR[conQuestionOptions.UpdUser] = objInFor[conQuestionOptions.UpdUser];
objDR[conQuestionOptions.Memo] = objInFor[conQuestionOptions.Memo];
objDT.Rows.Add(objDR);
}
return objDT;
}
}
 /// <summary>
 /// 题目选项(QuestionOptions)
 /// 数据源类型:SQL表
 /// (AutoGCLib.CommFun4WA4CSharp:GeneCode_This)
 /// </summary>
public class clsCommFun4WA4QuestionOptions : clsCommFun4BLV2
{

 /// <summary>
 /// 刷新缓存.把当前表的缓存以及该表相关视图的缓存清空.
 /// (AutoGCLib.CommFun4WA4CSharp:Gen_4CFWA_ReFreshCache)
 /// </summary>
public override void ReFreshCache(string strCourseId)
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
clsQuestionOptionsWApi.ReFreshThisCache(strCourseId);
clsvQuestionOptionsWApi.ReFreshThisCache(strCourseId);
}
}

}