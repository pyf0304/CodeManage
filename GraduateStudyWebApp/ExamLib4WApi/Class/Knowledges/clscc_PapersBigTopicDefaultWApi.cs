
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clscc_PapersBigTopicDefaultWApi
 表名:cc_PapersBigTopicDefault(01120088)
 生成代码版本:2021.09.20.1
 生成日期:2021/09/21 02:48:47
 生成者:pyf
 生成服务器IP:103.116.76.183
 工程名称:问卷调查
 工程ID:0112
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:知识点相关
 模块英文名:Knowledges
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
public static class clscc_PapersBigTopicDefaultWApi_Static
{

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_PapersBigTopicDefaultEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clscc_PapersBigTopicDefaultEN SetPapersBigTopicDefaultId(this clscc_PapersBigTopicDefaultEN objcc_PapersBigTopicDefaultEN, string strPapersBigTopicDefaultId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strPapersBigTopicDefaultId, 8, concc_PapersBigTopicDefault.PapersBigTopicDefaultId);
clsCheckSql.CheckFieldForeignKey(strPapersBigTopicDefaultId, 8, concc_PapersBigTopicDefault.PapersBigTopicDefaultId);
objcc_PapersBigTopicDefaultEN.PapersBigTopicDefaultId = strPapersBigTopicDefaultId; //PapersBigTopicDefaultId
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_PapersBigTopicDefaultEN.dicFldComparisonOp.ContainsKey(concc_PapersBigTopicDefault.PapersBigTopicDefaultId) == false)
{
objcc_PapersBigTopicDefaultEN.dicFldComparisonOp.Add(concc_PapersBigTopicDefault.PapersBigTopicDefaultId, strComparisonOp);
}
else
{
objcc_PapersBigTopicDefaultEN.dicFldComparisonOp[concc_PapersBigTopicDefault.PapersBigTopicDefaultId] = strComparisonOp;
}
}
return objcc_PapersBigTopicDefaultEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_PapersBigTopicDefaultEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clscc_PapersBigTopicDefaultEN SetQuestionTypeId(this clscc_PapersBigTopicDefaultEN objcc_PapersBigTopicDefaultEN, string strQuestionTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strQuestionTypeId, concc_PapersBigTopicDefault.QuestionTypeId);
clsCheckSql.CheckFieldLen(strQuestionTypeId, 2, concc_PapersBigTopicDefault.QuestionTypeId);
clsCheckSql.CheckFieldForeignKey(strQuestionTypeId, 2, concc_PapersBigTopicDefault.QuestionTypeId);
objcc_PapersBigTopicDefaultEN.QuestionTypeId = strQuestionTypeId; //题目类型Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_PapersBigTopicDefaultEN.dicFldComparisonOp.ContainsKey(concc_PapersBigTopicDefault.QuestionTypeId) == false)
{
objcc_PapersBigTopicDefaultEN.dicFldComparisonOp.Add(concc_PapersBigTopicDefault.QuestionTypeId, strComparisonOp);
}
else
{
objcc_PapersBigTopicDefaultEN.dicFldComparisonOp[concc_PapersBigTopicDefault.QuestionTypeId] = strComparisonOp;
}
}
return objcc_PapersBigTopicDefaultEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_PapersBigTopicDefaultEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clscc_PapersBigTopicDefaultEN SetPapersBigTopicName(this clscc_PapersBigTopicDefaultEN objcc_PapersBigTopicDefaultEN, string strPapersBigTopicName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strPapersBigTopicName, concc_PapersBigTopicDefault.PapersBigTopicName);
clsCheckSql.CheckFieldLen(strPapersBigTopicName, 50, concc_PapersBigTopicDefault.PapersBigTopicName);
objcc_PapersBigTopicDefaultEN.PapersBigTopicName = strPapersBigTopicName; //试卷大题目名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_PapersBigTopicDefaultEN.dicFldComparisonOp.ContainsKey(concc_PapersBigTopicDefault.PapersBigTopicName) == false)
{
objcc_PapersBigTopicDefaultEN.dicFldComparisonOp.Add(concc_PapersBigTopicDefault.PapersBigTopicName, strComparisonOp);
}
else
{
objcc_PapersBigTopicDefaultEN.dicFldComparisonOp[concc_PapersBigTopicDefault.PapersBigTopicName] = strComparisonOp;
}
}
return objcc_PapersBigTopicDefaultEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_PapersBigTopicDefaultEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clscc_PapersBigTopicDefaultEN SetTopicDescription(this clscc_PapersBigTopicDefaultEN objcc_PapersBigTopicDefaultEN, string strTopicDescription, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strTopicDescription, 100, concc_PapersBigTopicDefault.TopicDescription);
objcc_PapersBigTopicDefaultEN.TopicDescription = strTopicDescription; //标题描述
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_PapersBigTopicDefaultEN.dicFldComparisonOp.ContainsKey(concc_PapersBigTopicDefault.TopicDescription) == false)
{
objcc_PapersBigTopicDefaultEN.dicFldComparisonOp.Add(concc_PapersBigTopicDefault.TopicDescription, strComparisonOp);
}
else
{
objcc_PapersBigTopicDefaultEN.dicFldComparisonOp[concc_PapersBigTopicDefault.TopicDescription] = strComparisonOp;
}
}
return objcc_PapersBigTopicDefaultEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_PapersBigTopicDefaultEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clscc_PapersBigTopicDefaultEN SetTopicScores(this clscc_PapersBigTopicDefaultEN objcc_PapersBigTopicDefaultEN, int intTopicScores, string strComparisonOp="")
	{
objcc_PapersBigTopicDefaultEN.TopicScores = intTopicScores; //大题得分
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_PapersBigTopicDefaultEN.dicFldComparisonOp.ContainsKey(concc_PapersBigTopicDefault.TopicScores) == false)
{
objcc_PapersBigTopicDefaultEN.dicFldComparisonOp.Add(concc_PapersBigTopicDefault.TopicScores, strComparisonOp);
}
else
{
objcc_PapersBigTopicDefaultEN.dicFldComparisonOp[concc_PapersBigTopicDefault.TopicScores] = strComparisonOp;
}
}
return objcc_PapersBigTopicDefaultEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_PapersBigTopicDefaultEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clscc_PapersBigTopicDefaultEN SetUpdDate(this clscc_PapersBigTopicDefaultEN objcc_PapersBigTopicDefaultEN, string strUpdDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdDate, 20, concc_PapersBigTopicDefault.UpdDate);
objcc_PapersBigTopicDefaultEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_PapersBigTopicDefaultEN.dicFldComparisonOp.ContainsKey(concc_PapersBigTopicDefault.UpdDate) == false)
{
objcc_PapersBigTopicDefaultEN.dicFldComparisonOp.Add(concc_PapersBigTopicDefault.UpdDate, strComparisonOp);
}
else
{
objcc_PapersBigTopicDefaultEN.dicFldComparisonOp[concc_PapersBigTopicDefault.UpdDate] = strComparisonOp;
}
}
return objcc_PapersBigTopicDefaultEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_PapersBigTopicDefaultEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clscc_PapersBigTopicDefaultEN SetUpdUser(this clscc_PapersBigTopicDefaultEN objcc_PapersBigTopicDefaultEN, string strUpdUser, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdUser, 20, concc_PapersBigTopicDefault.UpdUser);
objcc_PapersBigTopicDefaultEN.UpdUser = strUpdUser; //修改人
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_PapersBigTopicDefaultEN.dicFldComparisonOp.ContainsKey(concc_PapersBigTopicDefault.UpdUser) == false)
{
objcc_PapersBigTopicDefaultEN.dicFldComparisonOp.Add(concc_PapersBigTopicDefault.UpdUser, strComparisonOp);
}
else
{
objcc_PapersBigTopicDefaultEN.dicFldComparisonOp[concc_PapersBigTopicDefault.UpdUser] = strComparisonOp;
}
}
return objcc_PapersBigTopicDefaultEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_PapersBigTopicDefaultEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clscc_PapersBigTopicDefaultEN SetMemo(this clscc_PapersBigTopicDefaultEN objcc_PapersBigTopicDefaultEN, string strMemo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMemo, 1000, concc_PapersBigTopicDefault.Memo);
objcc_PapersBigTopicDefaultEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_PapersBigTopicDefaultEN.dicFldComparisonOp.ContainsKey(concc_PapersBigTopicDefault.Memo) == false)
{
objcc_PapersBigTopicDefaultEN.dicFldComparisonOp.Add(concc_PapersBigTopicDefault.Memo, strComparisonOp);
}
else
{
objcc_PapersBigTopicDefaultEN.dicFldComparisonOp[concc_PapersBigTopicDefault.Memo] = strComparisonOp;
}
}
return objcc_PapersBigTopicDefaultEN;
	}

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clscc_PapersBigTopicDefaultEN objcc_PapersBigTopicDefault_Cond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objcc_PapersBigTopicDefault_Cond.IsUpdated(concc_PapersBigTopicDefault.PapersBigTopicDefaultId) == true)
{
string strComparisonOp_PapersBigTopicDefaultId = objcc_PapersBigTopicDefault_Cond.dicFldComparisonOp[concc_PapersBigTopicDefault.PapersBigTopicDefaultId];
strWhereCond += string.Format(" And {0} {2} '{1}'", concc_PapersBigTopicDefault.PapersBigTopicDefaultId, objcc_PapersBigTopicDefault_Cond.PapersBigTopicDefaultId, strComparisonOp_PapersBigTopicDefaultId);
}
if (objcc_PapersBigTopicDefault_Cond.IsUpdated(concc_PapersBigTopicDefault.QuestionTypeId) == true)
{
string strComparisonOp_QuestionTypeId = objcc_PapersBigTopicDefault_Cond.dicFldComparisonOp[concc_PapersBigTopicDefault.QuestionTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", concc_PapersBigTopicDefault.QuestionTypeId, objcc_PapersBigTopicDefault_Cond.QuestionTypeId, strComparisonOp_QuestionTypeId);
}
if (objcc_PapersBigTopicDefault_Cond.IsUpdated(concc_PapersBigTopicDefault.PapersBigTopicName) == true)
{
string strComparisonOp_PapersBigTopicName = objcc_PapersBigTopicDefault_Cond.dicFldComparisonOp[concc_PapersBigTopicDefault.PapersBigTopicName];
strWhereCond += string.Format(" And {0} {2} '{1}'", concc_PapersBigTopicDefault.PapersBigTopicName, objcc_PapersBigTopicDefault_Cond.PapersBigTopicName, strComparisonOp_PapersBigTopicName);
}
if (objcc_PapersBigTopicDefault_Cond.IsUpdated(concc_PapersBigTopicDefault.TopicDescription) == true)
{
string strComparisonOp_TopicDescription = objcc_PapersBigTopicDefault_Cond.dicFldComparisonOp[concc_PapersBigTopicDefault.TopicDescription];
strWhereCond += string.Format(" And {0} {2} '{1}'", concc_PapersBigTopicDefault.TopicDescription, objcc_PapersBigTopicDefault_Cond.TopicDescription, strComparisonOp_TopicDescription);
}
if (objcc_PapersBigTopicDefault_Cond.IsUpdated(concc_PapersBigTopicDefault.TopicScores) == true)
{
string strComparisonOp_TopicScores = objcc_PapersBigTopicDefault_Cond.dicFldComparisonOp[concc_PapersBigTopicDefault.TopicScores];
strWhereCond += string.Format(" And {0} {2} {1}", concc_PapersBigTopicDefault.TopicScores, objcc_PapersBigTopicDefault_Cond.TopicScores, strComparisonOp_TopicScores);
}
if (objcc_PapersBigTopicDefault_Cond.IsUpdated(concc_PapersBigTopicDefault.UpdDate) == true)
{
string strComparisonOp_UpdDate = objcc_PapersBigTopicDefault_Cond.dicFldComparisonOp[concc_PapersBigTopicDefault.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", concc_PapersBigTopicDefault.UpdDate, objcc_PapersBigTopicDefault_Cond.UpdDate, strComparisonOp_UpdDate);
}
if (objcc_PapersBigTopicDefault_Cond.IsUpdated(concc_PapersBigTopicDefault.UpdUser) == true)
{
string strComparisonOp_UpdUser = objcc_PapersBigTopicDefault_Cond.dicFldComparisonOp[concc_PapersBigTopicDefault.UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", concc_PapersBigTopicDefault.UpdUser, objcc_PapersBigTopicDefault_Cond.UpdUser, strComparisonOp_UpdUser);
}
if (objcc_PapersBigTopicDefault_Cond.IsUpdated(concc_PapersBigTopicDefault.Memo) == true)
{
string strComparisonOp_Memo = objcc_PapersBigTopicDefault_Cond.dicFldComparisonOp[concc_PapersBigTopicDefault.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", concc_PapersBigTopicDefault.Memo, objcc_PapersBigTopicDefault_Cond.Memo, strComparisonOp_Memo);
}
 return strWhereCond;
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_Update)
 /// </summary>
 /// <param name = "objcc_PapersBigTopicDefaultEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clscc_PapersBigTopicDefaultEN objcc_PapersBigTopicDefaultEN)
{
 if (string.IsNullOrEmpty(objcc_PapersBigTopicDefaultEN.PapersBigTopicDefaultId) == true)
 {
string strMsg = string.Format("(errid:Watl000003)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
objcc_PapersBigTopicDefaultEN.sf_UpdFldSetStr = objcc_PapersBigTopicDefaultEN.getsf_UpdFldSetStr();
clscc_PapersBigTopicDefaultWApi.CheckPropertyNew(objcc_PapersBigTopicDefaultEN); 
bool bolResult = clscc_PapersBigTopicDefaultWApi.UpdateRecord(objcc_PapersBigTopicDefaultEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clscc_PapersBigTopicDefaultWApi.ReFreshCache();
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
 /// <param name = "objcc_PapersBigTopicDefaultEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clscc_PapersBigTopicDefaultEN objcc_PapersBigTopicDefaultEN)
{
 if (string.IsNullOrEmpty(objcc_PapersBigTopicDefaultEN.PapersBigTopicDefaultId) == true)
 {
string strMsg = string.Format("添加记录时，关键字不能为空!(from {0})\r\n", 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
 if (clscc_PapersBigTopicDefaultWApi.IsExist(objcc_PapersBigTopicDefaultEN.PapersBigTopicDefaultId) == true)
 {
string strMsg = string.Format("添加记录时，关键字:[{0}]已经存在!(from {1})\r\n", objcc_PapersBigTopicDefaultEN.PapersBigTopicDefaultId, 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
try
{
clscc_PapersBigTopicDefaultWApi.CheckPropertyNew(objcc_PapersBigTopicDefaultEN); 
bool bolResult = clscc_PapersBigTopicDefaultWApi.AddNewRecord(objcc_PapersBigTopicDefaultEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clscc_PapersBigTopicDefaultWApi.ReFreshCache();
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
 /// <param name = "objcc_PapersBigTopicDefaultEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static string AddNewRecordWithMaxId(this clscc_PapersBigTopicDefaultEN objcc_PapersBigTopicDefaultEN)
{
try
{
clscc_PapersBigTopicDefaultWApi.CheckPropertyNew(objcc_PapersBigTopicDefaultEN); 
string strPapersBigTopicDefaultId = clscc_PapersBigTopicDefaultWApi.AddNewRecordWithMaxId(objcc_PapersBigTopicDefaultEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clscc_PapersBigTopicDefaultWApi.ReFreshCache();
return strPapersBigTopicDefaultId;
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
 /// <param name = "objcc_PapersBigTopicDefaultEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clscc_PapersBigTopicDefaultEN objcc_PapersBigTopicDefaultEN, string strWhereCond)
{
try
{
clscc_PapersBigTopicDefaultWApi.CheckPropertyNew(objcc_PapersBigTopicDefaultEN); 
bool bolResult = clscc_PapersBigTopicDefaultWApi.UpdateWithCondition(objcc_PapersBigTopicDefaultEN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clscc_PapersBigTopicDefaultWApi.ReFreshCache();
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
 /// 试卷大题目默认(cc_PapersBigTopicDefault)
 /// (AutoGCLib.WA_Access4CSharp:GeneCode)
 /// </summary>
public class clscc_PapersBigTopicDefaultWApi
{
private static readonly string mstrApiControllerName = "cc_PapersBigTopicDefaultApi";

 /// <summary>
/// 专门在逻辑层用于处理缓存等公共函数的对象
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_DefineObjCommFun4BL)
/// </summary>
public static clsCommFun4BL objCommFun4BL = null;

 public clscc_PapersBigTopicDefaultWApi()
 {
 }

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_CheckPropertyNew)
 /// </summary>
public static void CheckPropertyNew(clscc_PapersBigTopicDefaultEN objcc_PapersBigTopicDefaultEN)
{
if (!Object.Equals(null, objcc_PapersBigTopicDefaultEN.PapersBigTopicDefaultId) && GetStrLen(objcc_PapersBigTopicDefaultEN.PapersBigTopicDefaultId) > 8)
{
 throw new Exception("字段[PapersBigTopicDefaultId]的长度不能超过8!");
}
if (!Object.Equals(null, objcc_PapersBigTopicDefaultEN.QuestionTypeId) && GetStrLen(objcc_PapersBigTopicDefaultEN.QuestionTypeId) > 2)
{
 throw new Exception("字段[题目类型Id]的长度不能超过2!");
}
if (!Object.Equals(null, objcc_PapersBigTopicDefaultEN.PapersBigTopicName) && GetStrLen(objcc_PapersBigTopicDefaultEN.PapersBigTopicName) > 50)
{
 throw new Exception("字段[试卷大题目名称]的长度不能超过50!");
}
if (!Object.Equals(null, objcc_PapersBigTopicDefaultEN.TopicDescription) && GetStrLen(objcc_PapersBigTopicDefaultEN.TopicDescription) > 100)
{
 throw new Exception("字段[标题描述]的长度不能超过100!");
}
if (!Object.Equals(null, objcc_PapersBigTopicDefaultEN.UpdDate) && GetStrLen(objcc_PapersBigTopicDefaultEN.UpdDate) > 20)
{
 throw new Exception("字段[修改日期]的长度不能超过20!");
}
if (!Object.Equals(null, objcc_PapersBigTopicDefaultEN.UpdUser) && GetStrLen(objcc_PapersBigTopicDefaultEN.UpdUser) > 20)
{
 throw new Exception("字段[修改人]的长度不能超过20!");
}
if (!Object.Equals(null, objcc_PapersBigTopicDefaultEN.Memo) && GetStrLen(objcc_PapersBigTopicDefaultEN.Memo) > 1000)
{
 throw new Exception("字段[备注]的长度不能超过1000!");
}
 objcc_PapersBigTopicDefaultEN._IsCheckProperty = true;
 }

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyId)
 /// </summary>
 /// <param name = "strPapersBigTopicDefaultId">表关键字</param>
 /// <returns>表对象</returns>
public static clscc_PapersBigTopicDefaultEN GetObjByPapersBigTopicDefaultId(string strPapersBigTopicDefaultId)
{
string strAction = "GetObjByPapersBigTopicDefaultId";
string strErrMsg = string.Empty;
string strResult = "";
clscc_PapersBigTopicDefaultEN objcc_PapersBigTopicDefaultEN = null;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["PapersBigTopicDefaultId"] = strPapersBigTopicDefaultId
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
objcc_PapersBigTopicDefaultEN = JsonConvert.DeserializeObject<clscc_PapersBigTopicDefaultEN>((string)jobjReturn["ReturnObj"]);
return objcc_PapersBigTopicDefaultEN;
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
 /// <param name = "strPapersBigTopicDefaultId">表关键字</param>
 /// <returns>表对象</returns>
public static clscc_PapersBigTopicDefaultEN GetObjByPapersBigTopicDefaultId_WA_Cache(string strPapersBigTopicDefaultId)
{
string strAction = "GetObjByPapersBigTopicDefaultId_Cache";
string strErrMsg = string.Empty;
string strResult = "";
clscc_PapersBigTopicDefaultEN objcc_PapersBigTopicDefaultEN = null;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["PapersBigTopicDefaultId"] = strPapersBigTopicDefaultId
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
objcc_PapersBigTopicDefaultEN = JsonConvert.DeserializeObject<clscc_PapersBigTopicDefaultEN>((string)jobjReturn["ReturnObj"]);
return objcc_PapersBigTopicDefaultEN;
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
public static clscc_PapersBigTopicDefaultEN GetFirstObj(string strWhereCond)
{
string strAction = "GetFirstObj";
string strErrMsg = string.Empty;
string strResult = "";
clscc_PapersBigTopicDefaultEN objcc_PapersBigTopicDefaultEN = null;
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
objcc_PapersBigTopicDefaultEN = JsonConvert.DeserializeObject<clscc_PapersBigTopicDefaultEN>((string)jobjReturn["ReturnObj"]);
return objcc_PapersBigTopicDefaultEN;
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
 /// <param name = "strPapersBigTopicDefaultId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clscc_PapersBigTopicDefaultEN GetObjByPapersBigTopicDefaultId_Cache(string strPapersBigTopicDefaultId)
{
if (string.IsNullOrEmpty(strPapersBigTopicDefaultId) == true) return null;
//初始化列表缓存
string strKey = string.Format("{0}", clscc_PapersBigTopicDefaultEN._CurrTabName_S);
List<clscc_PapersBigTopicDefaultEN> arrcc_PapersBigTopicDefaultObjLst_Cache = GetObjLst_Cache();
IEnumerable <clscc_PapersBigTopicDefaultEN> arrcc_PapersBigTopicDefaultObjLst_Sel =
from objcc_PapersBigTopicDefaultEN in arrcc_PapersBigTopicDefaultObjLst_Cache
where objcc_PapersBigTopicDefaultEN.PapersBigTopicDefaultId == strPapersBigTopicDefaultId
select objcc_PapersBigTopicDefaultEN;
if (arrcc_PapersBigTopicDefaultObjLst_Sel.Count() == 0)
{
   clscc_PapersBigTopicDefaultEN obj = clscc_PapersBigTopicDefaultWApi.GetObjByPapersBigTopicDefaultId(strPapersBigTopicDefaultId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
     return obj;
 }
return null;
}
return arrcc_PapersBigTopicDefaultObjLst_Sel.First();
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clscc_PapersBigTopicDefaultEN> GetObjLst(string strWhereCond)
{
 List<clscc_PapersBigTopicDefaultEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clscc_PapersBigTopicDefaultEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clscc_PapersBigTopicDefaultEN> GetObjLstByPapersBigTopicDefaultIdLst(List<string> arrPapersBigTopicDefaultId)
{
 List<clscc_PapersBigTopicDefaultEN> arrObjLst = null; 
string strAction = "GetObjLstByPapersBigTopicDefaultIdLst";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrPapersBigTopicDefaultId);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
arrObjLst = JsonConvert.DeserializeObject<List<clscc_PapersBigTopicDefaultEN>>((string)jobjReturn["ReturnObjLst"]);
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
 /// <param name = "strPapersBigTopicDefaultId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static IEnumerable<clscc_PapersBigTopicDefaultEN> GetObjLstByPapersBigTopicDefaultIdLst_Cache(List<string> arrPapersBigTopicDefaultId)
{
//初始化列表缓存
string strKey = string.Format("{0}", clscc_PapersBigTopicDefaultEN._CurrTabName_S);
List<clscc_PapersBigTopicDefaultEN> arrcc_PapersBigTopicDefaultObjLst_Cache = GetObjLst_Cache();
IEnumerable <clscc_PapersBigTopicDefaultEN> arrcc_PapersBigTopicDefaultObjLst_Sel =
from objcc_PapersBigTopicDefaultEN in arrcc_PapersBigTopicDefaultObjLst_Cache
where arrPapersBigTopicDefaultId.Contains(objcc_PapersBigTopicDefaultEN.PapersBigTopicDefaultId)
select objcc_PapersBigTopicDefaultEN;
return arrcc_PapersBigTopicDefaultObjLst_Sel;
}

 /// <summary>
 /// 根据关键字列表获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstByKeyLst_WA_Cache)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clscc_PapersBigTopicDefaultEN> GetObjLstByPapersBigTopicDefaultIdLst_WA_Cache(List<string> arrPapersBigTopicDefaultId)
{
 List<clscc_PapersBigTopicDefaultEN> arrObjLst = null; 
string strAction = "GetObjLstByPapersBigTopicDefaultIdLst_Cache";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
};
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrPapersBigTopicDefaultId);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
arrObjLst = JsonConvert.DeserializeObject<List<clscc_PapersBigTopicDefaultEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clscc_PapersBigTopicDefaultEN> GetTopObjLst(stuTopPara objTopPara)
{
 List<clscc_PapersBigTopicDefaultEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clscc_PapersBigTopicDefaultEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clscc_PapersBigTopicDefaultEN> GetObjLstByRange(stuRangePara objRangePara)
{
 List<clscc_PapersBigTopicDefaultEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clscc_PapersBigTopicDefaultEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clscc_PapersBigTopicDefaultEN> GetObjLstByPager(stuPagerPara objPagerPara)
{
 List<clscc_PapersBigTopicDefaultEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clscc_PapersBigTopicDefaultEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clscc_PapersBigTopicDefaultEN> GetObjLstByPager_Cache(stuPagerPara objPagerPara)
{
 List<clscc_PapersBigTopicDefaultEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clscc_PapersBigTopicDefaultEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static int DelRecord(string strPapersBigTopicDefaultId)
{
string strAction = "DelRecord";
string strErrMsg = string.Empty;
string strResult = "";
try
{
 clscc_PapersBigTopicDefaultEN objcc_PapersBigTopicDefaultEN = clscc_PapersBigTopicDefaultWApi.GetObjByPapersBigTopicDefaultId(strPapersBigTopicDefaultId);
if (clsPubFun4WApi.Delete(mstrApiControllerName, strAction, strPapersBigTopicDefaultId.ToString(), out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
clscc_PapersBigTopicDefaultWApi.ReFreshCache();
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
public static int Delcc_PapersBigTopicDefaults(List<string> arrPapersBigTopicDefaultId)
{
string strAction = "Delcc_PapersBigTopicDefaults";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrPapersBigTopicDefaultId);
if (clsPubFun4WApi.Deletes(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
clscc_PapersBigTopicDefaultWApi.ReFreshCache();
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
public static int Delcc_PapersBigTopicDefaultsByCond(string strWhereCond)
{
string strAction = "Delcc_PapersBigTopicDefaultsByCond";
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
public static bool AddNewRecord(clscc_PapersBigTopicDefaultEN objcc_PapersBigTopicDefaultEN)
{
string strAction = "AddNewRecord";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clscc_PapersBigTopicDefaultEN>(objcc_PapersBigTopicDefaultEN);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJson, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clscc_PapersBigTopicDefaultWApi.ReFreshCache();
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
public static string AddNewRecordWithMaxId(clscc_PapersBigTopicDefaultEN objcc_PapersBigTopicDefaultEN)
{
string strAction = "AddNewRecordWithMaxId";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clscc_PapersBigTopicDefaultEN>(objcc_PapersBigTopicDefaultEN);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJson, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clscc_PapersBigTopicDefaultWApi.ReFreshCache();
var strPapersBigTopicDefaultId = (string)jobjReturn["ReturnStr"];
return strPapersBigTopicDefaultId;
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
public static bool UpdateRecord(clscc_PapersBigTopicDefaultEN objcc_PapersBigTopicDefaultEN)
{
if (string.IsNullOrEmpty(objcc_PapersBigTopicDefaultEN.sf_UpdFldSetStr) == true)
{
string strMsg = string.Format("修改时，修改标志串为空，请联系管理员.对象关键字:{0}.(from {1}).",
objcc_PapersBigTopicDefaultEN.PapersBigTopicDefaultId, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
string strAction = "UpdateRecord";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clscc_PapersBigTopicDefaultEN>(objcc_PapersBigTopicDefaultEN);
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
 /// <param name = "objcc_PapersBigTopicDefaultEN">需要修改的对象</param>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的关键字值</returns>
public static bool UpdateWithCondition(clscc_PapersBigTopicDefaultEN objcc_PapersBigTopicDefaultEN, string strWhereCond)
{
if (string.IsNullOrEmpty(objcc_PapersBigTopicDefaultEN.sf_UpdFldSetStr) == true)
{
string strMsg = string.Format("修改时，修改标志串为空，请联系管理员.对象关键字:{0}.(from {1}).",
objcc_PapersBigTopicDefaultEN.PapersBigTopicDefaultId, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (string.IsNullOrEmpty(strWhereCond) == true)
{
string strMsg = string.Format("按条件修改时，条件串为空，请联系管理员.对象关键字:{0}.(from {1}).",
objcc_PapersBigTopicDefaultEN.PapersBigTopicDefaultId, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
string strAction = "UpdateWithCondition";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clscc_PapersBigTopicDefaultEN>(objcc_PapersBigTopicDefaultEN);
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
public static bool IsExist(string strPapersBigTopicDefaultId)
{
//检测记录是否存在
string strAction = "IsExist";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["PapersBigTopicDefaultId"] = strPapersBigTopicDefaultId
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
 /// <param name = "objcc_PapersBigTopicDefaultENS">源对象</param>
 /// <param name = "objcc_PapersBigTopicDefaultENT">目标对象</param>
 public static void CopyTo(clscc_PapersBigTopicDefaultEN objcc_PapersBigTopicDefaultENS, clscc_PapersBigTopicDefaultEN objcc_PapersBigTopicDefaultENT)
{
try
{
objcc_PapersBigTopicDefaultENT.PapersBigTopicDefaultId = objcc_PapersBigTopicDefaultENS.PapersBigTopicDefaultId; //PapersBigTopicDefaultId
objcc_PapersBigTopicDefaultENT.QuestionTypeId = objcc_PapersBigTopicDefaultENS.QuestionTypeId; //题目类型Id
objcc_PapersBigTopicDefaultENT.PapersBigTopicName = objcc_PapersBigTopicDefaultENS.PapersBigTopicName; //试卷大题目名称
objcc_PapersBigTopicDefaultENT.TopicDescription = objcc_PapersBigTopicDefaultENS.TopicDescription; //标题描述
objcc_PapersBigTopicDefaultENT.TopicScores = objcc_PapersBigTopicDefaultENS.TopicScores; //大题得分
objcc_PapersBigTopicDefaultENT.UpdDate = objcc_PapersBigTopicDefaultENS.UpdDate; //修改日期
objcc_PapersBigTopicDefaultENT.UpdUser = objcc_PapersBigTopicDefaultENS.UpdUser; //修改人
objcc_PapersBigTopicDefaultENT.Memo = objcc_PapersBigTopicDefaultENS.Memo; //备注
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
public static DataTable ToDataTable(List<clscc_PapersBigTopicDefaultEN> arrObj)
{
DataTable dataTable = new DataTable(); //实例化
DataTable result;
if (arrObj.Count == 0) return null;
if (clscc_PapersBigTopicDefaultEN.AttributeName.Length == 0)
{
result = dataTable;
return result;
}
Type type = typeof(clscc_PapersBigTopicDefaultEN);
PropertyInfo[] arrPropertyInfo = type.GetProperties();
try
{
//Columns
foreach (string strAttrName in clscc_PapersBigTopicDefaultEN.AttributeName)
{
PropertyInfo proprety_Curr = arrPropertyInfo.Where(x => x.Name == strAttrName).First();
dataTable.Columns.Add(strAttrName, proprety_Curr.PropertyType);
}
foreach (clscc_PapersBigTopicDefaultEN objInFor in arrObj)
{
//Rows
DataRow dataRow = dataTable.NewRow();
foreach (string strAttrName in clscc_PapersBigTopicDefaultEN.AttributeName)
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
if (clscc_PapersBigTopicDefaultWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clscc_PapersBigTopicDefaultWApi没有刷新缓存机制(clscc_PapersBigTopicDefaultWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by PapersBigTopicDefaultId");
//if (arrcc_PapersBigTopicDefaultObjLst_Cache == null)
//{
//arrcc_PapersBigTopicDefaultObjLst_Cache = await clscc_PapersBigTopicDefaultWApi.GetObjLst(strWhereCond);
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
string strKey = string.Format("{0}", clscc_PapersBigTopicDefaultEN._CurrTabName_S);
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
if (clscc_PapersBigTopicDefaultWApi.objCommFun4BL != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}", clscc_PapersBigTopicDefaultEN._CurrTabName_S);
CacheHelper.Remove(strKey);
clscc_PapersBigTopicDefaultWApi.objCommFun4BL.ReFreshCache();
}
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst_Cache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clscc_PapersBigTopicDefaultEN> GetObjLst_Cache()
{
//初始化列表缓存
InitListCache(); 
string strKey = string.Format("{0}", clscc_PapersBigTopicDefaultEN._CurrTabName_S);
List<clscc_PapersBigTopicDefaultEN> arrcc_PapersBigTopicDefaultObjLst_Cache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrcc_PapersBigTopicDefaultObjLst_Cache;
}

 /// <summary>
 /// 根据对象列表获取DataTable
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetDataTableByObjLst)
 /// </summary>
 /// <param name = "arrObjLst">给定的对象列表</param>
 /// <returns>返回DataTable</returns>
public static DataTable GetDataTableByObjLst(List<clscc_PapersBigTopicDefaultEN> arrObjLst)
{
DataTable objDT = new DataTable();
objDT.Columns.Add(concc_PapersBigTopicDefault.PapersBigTopicDefaultId, Type.GetType("System.String"));
objDT.Columns.Add(concc_PapersBigTopicDefault.QuestionTypeId, Type.GetType("System.String"));
objDT.Columns.Add(concc_PapersBigTopicDefault.PapersBigTopicName, Type.GetType("System.String"));
objDT.Columns.Add(concc_PapersBigTopicDefault.TopicDescription, Type.GetType("System.String"));
objDT.Columns.Add(concc_PapersBigTopicDefault.TopicScores, Type.GetType("System.Int32"));
objDT.Columns.Add(concc_PapersBigTopicDefault.UpdDate, Type.GetType("System.String"));
objDT.Columns.Add(concc_PapersBigTopicDefault.UpdUser, Type.GetType("System.String"));
objDT.Columns.Add(concc_PapersBigTopicDefault.Memo, Type.GetType("System.String"));
foreach (clscc_PapersBigTopicDefaultEN objInFor in arrObjLst)
{
DataRow objDR = objDT.NewRow();
objDR[concc_PapersBigTopicDefault.PapersBigTopicDefaultId] = objInFor[concc_PapersBigTopicDefault.PapersBigTopicDefaultId];
objDR[concc_PapersBigTopicDefault.QuestionTypeId] = objInFor[concc_PapersBigTopicDefault.QuestionTypeId];
objDR[concc_PapersBigTopicDefault.PapersBigTopicName] = objInFor[concc_PapersBigTopicDefault.PapersBigTopicName];
objDR[concc_PapersBigTopicDefault.TopicDescription] = objInFor[concc_PapersBigTopicDefault.TopicDescription];
objDR[concc_PapersBigTopicDefault.TopicScores] = objInFor[concc_PapersBigTopicDefault.TopicScores];
objDR[concc_PapersBigTopicDefault.UpdDate] = objInFor[concc_PapersBigTopicDefault.UpdDate];
objDR[concc_PapersBigTopicDefault.UpdUser] = objInFor[concc_PapersBigTopicDefault.UpdUser];
objDR[concc_PapersBigTopicDefault.Memo] = objInFor[concc_PapersBigTopicDefault.Memo];
objDT.Rows.Add(objDR);
}
return objDT;
}
}
 /// <summary>
 /// 试卷大题目默认(cc_PapersBigTopicDefault)
 /// 数据源类型:SQL表
 /// (AutoGCLib.CommFun4WA4CSharp:GeneCode_This)
 /// </summary>
public class clsCommFun4WA4cc_PapersBigTopicDefault : clsCommFun4BL
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
clscc_PapersBigTopicDefaultWApi.ReFreshThisCache();
clsvcc_PapersBigTopicDefaultWApi.ReFreshThisCache();
}
}

}