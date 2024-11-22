
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsqa_PaperWApi
 表名:qa_Paper(01120643)
 生成代码版本:2021.09.20.1
 生成日期:2021/09/21 02:47:50
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
public static class clsqa_PaperWApi_Static
{

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objqa_PaperEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsqa_PaperEN Setqa_PaperId(this clsqa_PaperEN objqa_PaperEN, string strqa_PaperId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strqa_PaperId, 8, conqa_Paper.qa_PaperId);
clsCheckSql.CheckFieldForeignKey(strqa_PaperId, 8, conqa_Paper.qa_PaperId);
objqa_PaperEN.qa_PaperId = strqa_PaperId; //论文答疑Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objqa_PaperEN.dicFldComparisonOp.ContainsKey(conqa_Paper.qa_PaperId) == false)
{
objqa_PaperEN.dicFldComparisonOp.Add(conqa_Paper.qa_PaperId, strComparisonOp);
}
else
{
objqa_PaperEN.dicFldComparisonOp[conqa_Paper.qa_PaperId] = strComparisonOp;
}
}
return objqa_PaperEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objqa_PaperEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsqa_PaperEN SetPaperId(this clsqa_PaperEN objqa_PaperEN, string strPaperId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strPaperId, 8, conqa_Paper.PaperId);
clsCheckSql.CheckFieldForeignKey(strPaperId, 8, conqa_Paper.PaperId);
objqa_PaperEN.PaperId = strPaperId; //论文Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objqa_PaperEN.dicFldComparisonOp.ContainsKey(conqa_Paper.PaperId) == false)
{
objqa_PaperEN.dicFldComparisonOp.Add(conqa_Paper.PaperId, strComparisonOp);
}
else
{
objqa_PaperEN.dicFldComparisonOp[conqa_Paper.PaperId] = strComparisonOp;
}
}
return objqa_PaperEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objqa_PaperEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsqa_PaperEN SetQuestionsCount(this clsqa_PaperEN objqa_PaperEN, int intQuestionsCount, string strComparisonOp="")
	{
objqa_PaperEN.QuestionsCount = intQuestionsCount; //提问计数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objqa_PaperEN.dicFldComparisonOp.ContainsKey(conqa_Paper.QuestionsCount) == false)
{
objqa_PaperEN.dicFldComparisonOp.Add(conqa_Paper.QuestionsCount, strComparisonOp);
}
else
{
objqa_PaperEN.dicFldComparisonOp[conqa_Paper.QuestionsCount] = strComparisonOp;
}
}
return objqa_PaperEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objqa_PaperEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsqa_PaperEN SetIsDelete(this clsqa_PaperEN objqa_PaperEN, bool bolIsDelete, string strComparisonOp="")
	{
objqa_PaperEN.IsDelete = bolIsDelete; //是否删除
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objqa_PaperEN.dicFldComparisonOp.ContainsKey(conqa_Paper.IsDelete) == false)
{
objqa_PaperEN.dicFldComparisonOp.Add(conqa_Paper.IsDelete, strComparisonOp);
}
else
{
objqa_PaperEN.dicFldComparisonOp[conqa_Paper.IsDelete] = strComparisonOp;
}
}
return objqa_PaperEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objqa_PaperEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsqa_PaperEN SetIsPublic(this clsqa_PaperEN objqa_PaperEN, bool bolIsPublic, string strComparisonOp="")
	{
objqa_PaperEN.IsPublic = bolIsPublic; //是否公开
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objqa_PaperEN.dicFldComparisonOp.ContainsKey(conqa_Paper.IsPublic) == false)
{
objqa_PaperEN.dicFldComparisonOp.Add(conqa_Paper.IsPublic, strComparisonOp);
}
else
{
objqa_PaperEN.dicFldComparisonOp[conqa_Paper.IsPublic] = strComparisonOp;
}
}
return objqa_PaperEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objqa_PaperEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsqa_PaperEN SetIsSubmit(this clsqa_PaperEN objqa_PaperEN, bool bolIsSubmit, string strComparisonOp="")
	{
objqa_PaperEN.IsSubmit = bolIsSubmit; //是否提交
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objqa_PaperEN.dicFldComparisonOp.ContainsKey(conqa_Paper.IsSubmit) == false)
{
objqa_PaperEN.dicFldComparisonOp.Add(conqa_Paper.IsSubmit, strComparisonOp);
}
else
{
objqa_PaperEN.dicFldComparisonOp[conqa_Paper.IsSubmit] = strComparisonOp;
}
}
return objqa_PaperEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objqa_PaperEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsqa_PaperEN SetUpdUser(this clsqa_PaperEN objqa_PaperEN, string strUpdUser, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdUser, 20, conqa_Paper.UpdUser);
objqa_PaperEN.UpdUser = strUpdUser; //修改人
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objqa_PaperEN.dicFldComparisonOp.ContainsKey(conqa_Paper.UpdUser) == false)
{
objqa_PaperEN.dicFldComparisonOp.Add(conqa_Paper.UpdUser, strComparisonOp);
}
else
{
objqa_PaperEN.dicFldComparisonOp[conqa_Paper.UpdUser] = strComparisonOp;
}
}
return objqa_PaperEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objqa_PaperEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsqa_PaperEN SetUpdDate(this clsqa_PaperEN objqa_PaperEN, string strUpdDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdDate, 20, conqa_Paper.UpdDate);
objqa_PaperEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objqa_PaperEN.dicFldComparisonOp.ContainsKey(conqa_Paper.UpdDate) == false)
{
objqa_PaperEN.dicFldComparisonOp.Add(conqa_Paper.UpdDate, strComparisonOp);
}
else
{
objqa_PaperEN.dicFldComparisonOp[conqa_Paper.UpdDate] = strComparisonOp;
}
}
return objqa_PaperEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objqa_PaperEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsqa_PaperEN SetMemo(this clsqa_PaperEN objqa_PaperEN, string strMemo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMemo, 1000, conqa_Paper.Memo);
objqa_PaperEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objqa_PaperEN.dicFldComparisonOp.ContainsKey(conqa_Paper.Memo) == false)
{
objqa_PaperEN.dicFldComparisonOp.Add(conqa_Paper.Memo, strComparisonOp);
}
else
{
objqa_PaperEN.dicFldComparisonOp[conqa_Paper.Memo] = strComparisonOp;
}
}
return objqa_PaperEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objqa_PaperEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsqa_PaperEN Setid_CurrEduCls(this clsqa_PaperEN objqa_PaperEN, string strid_CurrEduCls, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_CurrEduCls, 8, conqa_Paper.id_CurrEduCls);
clsCheckSql.CheckFieldForeignKey(strid_CurrEduCls, 8, conqa_Paper.id_CurrEduCls);
objqa_PaperEN.id_CurrEduCls = strid_CurrEduCls; //当前教学班流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objqa_PaperEN.dicFldComparisonOp.ContainsKey(conqa_Paper.id_CurrEduCls) == false)
{
objqa_PaperEN.dicFldComparisonOp.Add(conqa_Paper.id_CurrEduCls, strComparisonOp);
}
else
{
objqa_PaperEN.dicFldComparisonOp[conqa_Paper.id_CurrEduCls] = strComparisonOp;
}
}
return objqa_PaperEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objqa_PaperEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsqa_PaperEN SetAnswerCount(this clsqa_PaperEN objqa_PaperEN, int intAnswerCount, string strComparisonOp="")
	{
objqa_PaperEN.AnswerCount = intAnswerCount; //回答计数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objqa_PaperEN.dicFldComparisonOp.ContainsKey(conqa_Paper.AnswerCount) == false)
{
objqa_PaperEN.dicFldComparisonOp.Add(conqa_Paper.AnswerCount, strComparisonOp);
}
else
{
objqa_PaperEN.dicFldComparisonOp[conqa_Paper.AnswerCount] = strComparisonOp;
}
}
return objqa_PaperEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objqa_PaperEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsqa_PaperEN SetShareId(this clsqa_PaperEN objqa_PaperEN, string strShareId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strShareId, 2, conqa_Paper.ShareId);
clsCheckSql.CheckFieldForeignKey(strShareId, 2, conqa_Paper.ShareId);
objqa_PaperEN.ShareId = strShareId; //分享Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objqa_PaperEN.dicFldComparisonOp.ContainsKey(conqa_Paper.ShareId) == false)
{
objqa_PaperEN.dicFldComparisonOp.Add(conqa_Paper.ShareId, strComparisonOp);
}
else
{
objqa_PaperEN.dicFldComparisonOp[conqa_Paper.ShareId] = strComparisonOp;
}
}
return objqa_PaperEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objqa_PaperEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsqa_PaperEN SetTagsCount(this clsqa_PaperEN objqa_PaperEN, int intTagsCount, string strComparisonOp="")
	{
objqa_PaperEN.TagsCount = intTagsCount; //论文标注数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objqa_PaperEN.dicFldComparisonOp.ContainsKey(conqa_Paper.TagsCount) == false)
{
objqa_PaperEN.dicFldComparisonOp.Add(conqa_Paper.TagsCount, strComparisonOp);
}
else
{
objqa_PaperEN.dicFldComparisonOp[conqa_Paper.TagsCount] = strComparisonOp;
}
}
return objqa_PaperEN;
	}

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsqa_PaperEN objqa_Paper_Cond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objqa_Paper_Cond.IsUpdated(conqa_Paper.qa_PaperId) == true)
{
string strComparisonOp_qa_PaperId = objqa_Paper_Cond.dicFldComparisonOp[conqa_Paper.qa_PaperId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conqa_Paper.qa_PaperId, objqa_Paper_Cond.qa_PaperId, strComparisonOp_qa_PaperId);
}
if (objqa_Paper_Cond.IsUpdated(conqa_Paper.PaperId) == true)
{
string strComparisonOp_PaperId = objqa_Paper_Cond.dicFldComparisonOp[conqa_Paper.PaperId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conqa_Paper.PaperId, objqa_Paper_Cond.PaperId, strComparisonOp_PaperId);
}
if (objqa_Paper_Cond.IsUpdated(conqa_Paper.QuestionsCount) == true)
{
string strComparisonOp_QuestionsCount = objqa_Paper_Cond.dicFldComparisonOp[conqa_Paper.QuestionsCount];
strWhereCond += string.Format(" And {0} {2} {1}", conqa_Paper.QuestionsCount, objqa_Paper_Cond.QuestionsCount, strComparisonOp_QuestionsCount);
}
if (objqa_Paper_Cond.IsUpdated(conqa_Paper.IsDelete) == true)
{
if (objqa_Paper_Cond.IsDelete == true)
{
strWhereCond += string.Format(" And {0} = '1'", conqa_Paper.IsDelete);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conqa_Paper.IsDelete);
}
}
if (objqa_Paper_Cond.IsUpdated(conqa_Paper.IsPublic) == true)
{
if (objqa_Paper_Cond.IsPublic == true)
{
strWhereCond += string.Format(" And {0} = '1'", conqa_Paper.IsPublic);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conqa_Paper.IsPublic);
}
}
if (objqa_Paper_Cond.IsUpdated(conqa_Paper.IsSubmit) == true)
{
if (objqa_Paper_Cond.IsSubmit == true)
{
strWhereCond += string.Format(" And {0} = '1'", conqa_Paper.IsSubmit);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conqa_Paper.IsSubmit);
}
}
if (objqa_Paper_Cond.IsUpdated(conqa_Paper.UpdUser) == true)
{
string strComparisonOp_UpdUser = objqa_Paper_Cond.dicFldComparisonOp[conqa_Paper.UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", conqa_Paper.UpdUser, objqa_Paper_Cond.UpdUser, strComparisonOp_UpdUser);
}
if (objqa_Paper_Cond.IsUpdated(conqa_Paper.UpdDate) == true)
{
string strComparisonOp_UpdDate = objqa_Paper_Cond.dicFldComparisonOp[conqa_Paper.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conqa_Paper.UpdDate, objqa_Paper_Cond.UpdDate, strComparisonOp_UpdDate);
}
if (objqa_Paper_Cond.IsUpdated(conqa_Paper.Memo) == true)
{
string strComparisonOp_Memo = objqa_Paper_Cond.dicFldComparisonOp[conqa_Paper.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", conqa_Paper.Memo, objqa_Paper_Cond.Memo, strComparisonOp_Memo);
}
if (objqa_Paper_Cond.IsUpdated(conqa_Paper.id_CurrEduCls) == true)
{
string strComparisonOp_id_CurrEduCls = objqa_Paper_Cond.dicFldComparisonOp[conqa_Paper.id_CurrEduCls];
strWhereCond += string.Format(" And {0} {2} '{1}'", conqa_Paper.id_CurrEduCls, objqa_Paper_Cond.id_CurrEduCls, strComparisonOp_id_CurrEduCls);
}
if (objqa_Paper_Cond.IsUpdated(conqa_Paper.AnswerCount) == true)
{
string strComparisonOp_AnswerCount = objqa_Paper_Cond.dicFldComparisonOp[conqa_Paper.AnswerCount];
strWhereCond += string.Format(" And {0} {2} {1}", conqa_Paper.AnswerCount, objqa_Paper_Cond.AnswerCount, strComparisonOp_AnswerCount);
}
if (objqa_Paper_Cond.IsUpdated(conqa_Paper.ShareId) == true)
{
string strComparisonOp_ShareId = objqa_Paper_Cond.dicFldComparisonOp[conqa_Paper.ShareId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conqa_Paper.ShareId, objqa_Paper_Cond.ShareId, strComparisonOp_ShareId);
}
if (objqa_Paper_Cond.IsUpdated(conqa_Paper.TagsCount) == true)
{
string strComparisonOp_TagsCount = objqa_Paper_Cond.dicFldComparisonOp[conqa_Paper.TagsCount];
strWhereCond += string.Format(" And {0} {2} {1}", conqa_Paper.TagsCount, objqa_Paper_Cond.TagsCount, strComparisonOp_TagsCount);
}
 return strWhereCond;
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_Update)
 /// </summary>
 /// <param name = "objqa_PaperEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsqa_PaperEN objqa_PaperEN)
{
 if (string.IsNullOrEmpty(objqa_PaperEN.qa_PaperId) == true)
 {
string strMsg = string.Format("(errid:Watl000003)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
objqa_PaperEN.sf_UpdFldSetStr = objqa_PaperEN.getsf_UpdFldSetStr();
clsqa_PaperWApi.CheckPropertyNew(objqa_PaperEN); 
bool bolResult = clsqa_PaperWApi.UpdateRecord(objqa_PaperEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsqa_PaperWApi.ReFreshCache(objqa_PaperEN.id_CurrEduCls);
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
 /// 检查唯一性(Uniqueness)--qa_Paper(论文答疑表), 如果不唯一,即存在相同的记录,就返回False
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_GetConditionString4Constraint)
 /// </summary>
 /// <param name = "objqa_PaperEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniConditionStr_qa_PaperId(this clsqa_PaperEN objqa_PaperEN)
{
//检测记录是否存在
StringBuilder sbCondition = new StringBuilder();
if (objqa_PaperEN == null) return "";
if (objqa_PaperEN.qa_PaperId == null || objqa_PaperEN.qa_PaperId == "")
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and qa_PaperId = '{0}'", objqa_PaperEN.qa_PaperId);
return sbCondition.ToString();
}
 else {
sbCondition.AppendFormat("qa_PaperId !=  '{0}'", objqa_PaperEN.qa_PaperId);
 sbCondition.AppendFormat(" and qa_PaperId = '{0}'", objqa_PaperEN.qa_PaperId);
 return sbCondition.ToString();
}
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_AddNewRecord)
 /// </summary>
 /// <param name = "objqa_PaperEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clsqa_PaperEN objqa_PaperEN)
{
try
{
 if (string.IsNullOrEmpty(objqa_PaperEN.qa_PaperId) == true || clsqa_PaperWApi.IsExist(objqa_PaperEN.qa_PaperId) == true)
 {
     objqa_PaperEN.qa_PaperId = clsqa_PaperWApi.GetMaxStrId();
 }
clsqa_PaperWApi.CheckPropertyNew(objqa_PaperEN); 
bool bolResult = clsqa_PaperWApi.AddNewRecord(objqa_PaperEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsqa_PaperWApi.ReFreshCache(objqa_PaperEN.id_CurrEduCls);
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
 /// <param name = "objqa_PaperEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static string AddNewRecordWithMaxId(this clsqa_PaperEN objqa_PaperEN)
{
try
{
clsqa_PaperWApi.CheckPropertyNew(objqa_PaperEN); 
string strqa_PaperId = clsqa_PaperWApi.AddNewRecordWithMaxId(objqa_PaperEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsqa_PaperWApi.ReFreshCache(objqa_PaperEN.id_CurrEduCls);
return strqa_PaperId;
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
 /// <param name = "objqa_PaperEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsqa_PaperEN objqa_PaperEN, string strWhereCond)
{
try
{
clsqa_PaperWApi.CheckPropertyNew(objqa_PaperEN); 
bool bolResult = clsqa_PaperWApi.UpdateWithCondition(objqa_PaperEN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsqa_PaperWApi.ReFreshCache(objqa_PaperEN.id_CurrEduCls);
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
 /// 论文答疑表(qa_Paper)
 /// (AutoGCLib.WA_Access4CSharp:GeneCode)
 /// </summary>
public class clsqa_PaperWApi
{
private static readonly string mstrApiControllerName = "qa_PaperApi";

 /// <summary>
/// 专门在逻辑层用于处理缓存等公共函数的对象
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_DefineObjCommFun4BL)
/// </summary>
public static clsCommFun4BLV2 objCommFun4BL = null;

 public clsqa_PaperWApi()
 {
 }

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_CheckPropertyNew)
 /// </summary>
public static void CheckPropertyNew(clsqa_PaperEN objqa_PaperEN)
{
if (!Object.Equals(null, objqa_PaperEN.qa_PaperId) && GetStrLen(objqa_PaperEN.qa_PaperId) > 8)
{
 throw new Exception("字段[论文答疑Id]的长度不能超过8!");
}
if (!Object.Equals(null, objqa_PaperEN.PaperId) && GetStrLen(objqa_PaperEN.PaperId) > 8)
{
 throw new Exception("字段[论文Id]的长度不能超过8!");
}
if (!Object.Equals(null, objqa_PaperEN.UpdUser) && GetStrLen(objqa_PaperEN.UpdUser) > 20)
{
 throw new Exception("字段[修改人]的长度不能超过20!");
}
if (!Object.Equals(null, objqa_PaperEN.UpdDate) && GetStrLen(objqa_PaperEN.UpdDate) > 20)
{
 throw new Exception("字段[修改日期]的长度不能超过20!");
}
if (!Object.Equals(null, objqa_PaperEN.Memo) && GetStrLen(objqa_PaperEN.Memo) > 1000)
{
 throw new Exception("字段[备注]的长度不能超过1000!");
}
if (!Object.Equals(null, objqa_PaperEN.id_CurrEduCls) && GetStrLen(objqa_PaperEN.id_CurrEduCls) > 8)
{
 throw new Exception("字段[当前教学班流水号]的长度不能超过8!");
}
if (!Object.Equals(null, objqa_PaperEN.ShareId) && GetStrLen(objqa_PaperEN.ShareId) > 2)
{
 throw new Exception("字段[分享Id]的长度不能超过2!");
}
 objqa_PaperEN._IsCheckProperty = true;
 }

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyId)
 /// </summary>
 /// <param name = "strqa_PaperId">表关键字</param>
 /// <returns>表对象</returns>
public static clsqa_PaperEN GetObjByqa_PaperId(string strqa_PaperId)
{
string strAction = "GetObjByqa_PaperId";
string strErrMsg = string.Empty;
string strResult = "";
clsqa_PaperEN objqa_PaperEN = null;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["qa_PaperId"] = strqa_PaperId
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
objqa_PaperEN = JsonConvert.DeserializeObject<clsqa_PaperEN>((string)jobjReturn["ReturnObj"]);
return objqa_PaperEN;
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
 /// <param name = "strqa_PaperId">表关键字</param>
 /// <returns>表对象</returns>
public static clsqa_PaperEN GetObjByqa_PaperId_WA_Cache(string strqa_PaperId, string strid_CurrEduCls)
{
string strAction = "GetObjByqa_PaperId_Cache";
string strErrMsg = string.Empty;
string strResult = "";
clsqa_PaperEN objqa_PaperEN = null;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["qa_PaperId"] = strqa_PaperId,
["id_CurrEduCls"] = strid_CurrEduCls
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
objqa_PaperEN = JsonConvert.DeserializeObject<clsqa_PaperEN>((string)jobjReturn["ReturnObj"]);
return objqa_PaperEN;
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
public static clsqa_PaperEN GetFirstObj(string strWhereCond)
{
string strAction = "GetFirstObj";
string strErrMsg = string.Empty;
string strResult = "";
clsqa_PaperEN objqa_PaperEN = null;
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
objqa_PaperEN = JsonConvert.DeserializeObject<clsqa_PaperEN>((string)jobjReturn["ReturnObj"]);
return objqa_PaperEN;
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
 /// <param name = "strqa_PaperId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsqa_PaperEN GetObjByqa_PaperId_Cache(string strqa_PaperId, string strid_CurrEduCls)
{
if (string.IsNullOrEmpty(strqa_PaperId) == true) return null;
//初始化列表缓存
string strKey = string.Format("{0}_{1}", clsqa_PaperEN._CurrTabName_S, strid_CurrEduCls);
List<clsqa_PaperEN> arrqa_PaperObjLst_Cache = GetObjLst_Cache(strid_CurrEduCls);
IEnumerable <clsqa_PaperEN> arrqa_PaperObjLst_Sel =
from objqa_PaperEN in arrqa_PaperObjLst_Cache
where objqa_PaperEN.qa_PaperId == strqa_PaperId
select objqa_PaperEN;
if (arrqa_PaperObjLst_Sel.Count() == 0)
{
   clsqa_PaperEN obj = clsqa_PaperWApi.GetObjByqa_PaperId(strqa_PaperId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
     return obj;
 }
return null;
}
return arrqa_PaperObjLst_Sel.First();
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsqa_PaperEN> GetObjLst(string strWhereCond)
{
 List<clsqa_PaperEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsqa_PaperEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsqa_PaperEN> GetObjLstByQa_PaperIdLst(List<string> arrQa_PaperId)
{
 List<clsqa_PaperEN> arrObjLst = null; 
string strAction = "GetObjLstByQa_PaperIdLst";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrQa_PaperId);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
arrObjLst = JsonConvert.DeserializeObject<List<clsqa_PaperEN>>((string)jobjReturn["ReturnObjLst"]);
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
 /// <param name = "strqa_PaperId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static IEnumerable<clsqa_PaperEN> GetObjLstByQa_PaperIdLst_Cache(List<string> arrQa_PaperId, string strid_CurrEduCls)
{
//初始化列表缓存
string strKey = string.Format("{0}_{1}", clsqa_PaperEN._CurrTabName_S, strid_CurrEduCls);
List<clsqa_PaperEN> arrqa_PaperObjLst_Cache = GetObjLst_Cache(strid_CurrEduCls);
IEnumerable <clsqa_PaperEN> arrqa_PaperObjLst_Sel =
from objqa_PaperEN in arrqa_PaperObjLst_Cache
where arrQa_PaperId.Contains(objqa_PaperEN.qa_PaperId)
select objqa_PaperEN;
return arrqa_PaperObjLst_Sel;
}

 /// <summary>
 /// 根据关键字列表获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstByKeyLst_WA_Cache)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsqa_PaperEN> GetObjLstByQa_PaperIdLst_WA_Cache(List<string> arrQa_PaperId, string strid_CurrEduCls)
{
 List<clsqa_PaperEN> arrObjLst = null; 
string strAction = "GetObjLstByQa_PaperIdLst_Cache";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["id_CurrEduCls"] = strid_CurrEduCls
};
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrQa_PaperId);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
arrObjLst = JsonConvert.DeserializeObject<List<clsqa_PaperEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsqa_PaperEN> GetTopObjLst(stuTopPara objTopPara)
{
 List<clsqa_PaperEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsqa_PaperEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsqa_PaperEN> GetObjLstByRange(stuRangePara objRangePara)
{
 List<clsqa_PaperEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsqa_PaperEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsqa_PaperEN> GetObjLstByPager(stuPagerPara objPagerPara)
{
 List<clsqa_PaperEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsqa_PaperEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsqa_PaperEN> GetObjLstByPager_Cache(stuPagerPara objPagerPara)
{
 List<clsqa_PaperEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsqa_PaperEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static int DelRecord(string strqa_PaperId)
{
string strAction = "DelRecord";
string strErrMsg = string.Empty;
string strResult = "";
try
{
 clsqa_PaperEN objqa_PaperEN = clsqa_PaperWApi.GetObjByqa_PaperId(strqa_PaperId);
if (clsPubFun4WApi.Delete(mstrApiControllerName, strAction, strqa_PaperId.ToString(), out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
clsqa_PaperWApi.ReFreshCache(objqa_PaperEN.id_CurrEduCls);
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
public static int Delqa_Papers(List<string> arrqa_PaperId)
{
string strAction = "Delqa_Papers";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrqa_PaperId);
if (clsPubFun4WApi.Deletes(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
 clsqa_PaperEN objqa_PaperEN = clsqa_PaperWApi.GetObjByqa_PaperId(arrqa_PaperId[0]);
clsqa_PaperWApi.ReFreshCache(objqa_PaperEN.id_CurrEduCls);
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
public static int Delqa_PapersByCond(string strWhereCond)
{
string strAction = "Delqa_PapersByCond";
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
public static bool AddNewRecord(clsqa_PaperEN objqa_PaperEN)
{
string strAction = "AddNewRecord";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsqa_PaperEN>(objqa_PaperEN);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJson, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsqa_PaperWApi.ReFreshCache(objqa_PaperEN.id_CurrEduCls);
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
public static string AddNewRecordWithMaxId(clsqa_PaperEN objqa_PaperEN)
{
string strAction = "AddNewRecordWithMaxId";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsqa_PaperEN>(objqa_PaperEN);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJson, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsqa_PaperWApi.ReFreshCache(objqa_PaperEN.id_CurrEduCls);
var strqa_PaperId = (string)jobjReturn["ReturnStr"];
return strqa_PaperId;
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
public static bool UpdateRecord(clsqa_PaperEN objqa_PaperEN)
{
if (string.IsNullOrEmpty(objqa_PaperEN.sf_UpdFldSetStr) == true)
{
string strMsg = string.Format("修改时，修改标志串为空，请联系管理员.对象关键字:{0}.(from {1}).",
objqa_PaperEN.qa_PaperId, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
string strAction = "UpdateRecord";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsqa_PaperEN>(objqa_PaperEN);
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
 /// <param name = "objqa_PaperEN">需要修改的对象</param>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的关键字值</returns>
public static bool UpdateWithCondition(clsqa_PaperEN objqa_PaperEN, string strWhereCond)
{
if (string.IsNullOrEmpty(objqa_PaperEN.sf_UpdFldSetStr) == true)
{
string strMsg = string.Format("修改时，修改标志串为空，请联系管理员.对象关键字:{0}.(from {1}).",
objqa_PaperEN.qa_PaperId, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (string.IsNullOrEmpty(strWhereCond) == true)
{
string strMsg = string.Format("按条件修改时，条件串为空，请联系管理员.对象关键字:{0}.(from {1}).",
objqa_PaperEN.qa_PaperId, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
string strAction = "UpdateWithCondition";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsqa_PaperEN>(objqa_PaperEN);
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
public static bool IsExist(string strqa_PaperId)
{
//检测记录是否存在
string strAction = "IsExist";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["qa_PaperId"] = strqa_PaperId
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
 /// <param name = "objqa_PaperENS">源对象</param>
 /// <param name = "objqa_PaperENT">目标对象</param>
 public static void CopyTo(clsqa_PaperEN objqa_PaperENS, clsqa_PaperEN objqa_PaperENT)
{
try
{
objqa_PaperENT.qa_PaperId = objqa_PaperENS.qa_PaperId; //论文答疑Id
objqa_PaperENT.PaperId = objqa_PaperENS.PaperId; //论文Id
objqa_PaperENT.QuestionsCount = objqa_PaperENS.QuestionsCount; //提问计数
objqa_PaperENT.IsDelete = objqa_PaperENS.IsDelete; //是否删除
objqa_PaperENT.IsPublic = objqa_PaperENS.IsPublic; //是否公开
objqa_PaperENT.IsSubmit = objqa_PaperENS.IsSubmit; //是否提交
objqa_PaperENT.UpdUser = objqa_PaperENS.UpdUser; //修改人
objqa_PaperENT.UpdDate = objqa_PaperENS.UpdDate; //修改日期
objqa_PaperENT.Memo = objqa_PaperENS.Memo; //备注
objqa_PaperENT.id_CurrEduCls = objqa_PaperENS.id_CurrEduCls; //当前教学班流水号
objqa_PaperENT.AnswerCount = objqa_PaperENS.AnswerCount; //回答计数
objqa_PaperENT.ShareId = objqa_PaperENS.ShareId; //分享Id
objqa_PaperENT.TagsCount = objqa_PaperENS.TagsCount; //论文标注数
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
public static DataTable ToDataTable(List<clsqa_PaperEN> arrObj)
{
DataTable dataTable = new DataTable(); //实例化
DataTable result;
if (arrObj.Count == 0) return null;
if (clsqa_PaperEN.AttributeName.Length == 0)
{
result = dataTable;
return result;
}
Type type = typeof(clsqa_PaperEN);
PropertyInfo[] arrPropertyInfo = type.GetProperties();
try
{
//Columns
foreach (string strAttrName in clsqa_PaperEN.AttributeName)
{
PropertyInfo proprety_Curr = arrPropertyInfo.Where(x => x.Name == strAttrName).First();
dataTable.Columns.Add(strAttrName, proprety_Curr.PropertyType);
}
foreach (clsqa_PaperEN objInFor in arrObj)
{
//Rows
DataRow dataRow = dataTable.NewRow();
foreach (string strAttrName in clsqa_PaperEN.AttributeName)
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
if (clsqa_PaperWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsqa_PaperWApi没有刷新缓存机制(clsqa_PaperWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by qa_PaperId");
//if (arrqa_PaperObjLst_Cache == null)
//{
//arrqa_PaperObjLst_Cache = await clsqa_PaperWApi.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 刷新本类中的缓存.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_ReFreshThisCache)
 /// </summary>
public static void ReFreshThisCache(string strid_CurrEduCls = "")
{
string strMsg = "";
if (clsSysParaEN.spSetRefreshCacheOn == true)
{
string strKey = string.Format("{0}_{1}", clsqa_PaperEN._CurrTabName_S, strid_CurrEduCls);
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
public static void ReFreshCache(string strid_CurrEduCls)
{
  if (clsSysParaEN.spIsUseQueue4Task == true)
{
if (clsSysParaEN.arrFunctionLst4Queue == null)
{
clsSysParaEN.arrFunctionLst4Queue = new Queue<object>();
}
}
if (clsqa_PaperWApi.objCommFun4BL != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}_{1}", clsqa_PaperEN._CurrTabName_S, strid_CurrEduCls);
CacheHelper.Remove(strKey);
clsqa_PaperWApi.objCommFun4BL.ReFreshCache(strid_CurrEduCls);
}
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst_Cache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsqa_PaperEN> GetObjLst_Cache(string strid_CurrEduCls)
{
//初始化列表缓存
InitListCache(); 
string strKey = string.Format("{0}_{1}", clsqa_PaperEN._CurrTabName_S, strid_CurrEduCls);
List<clsqa_PaperEN> arrqa_PaperObjLst_Cache = CacheHelper.GetCache(strKey, () => { return GetObjLst(string.Format("id_CurrEduCls='{0}'", strid_CurrEduCls)); });
return arrqa_PaperObjLst_Cache;
}

 /// <summary>
 /// 根据对象列表获取DataTable
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetDataTableByObjLst)
 /// </summary>
 /// <param name = "arrObjLst">给定的对象列表</param>
 /// <returns>返回DataTable</returns>
public static DataTable GetDataTableByObjLst(List<clsqa_PaperEN> arrObjLst)
{
DataTable objDT = new DataTable();
objDT.Columns.Add(conqa_Paper.qa_PaperId, Type.GetType("System.String"));
objDT.Columns.Add(conqa_Paper.PaperId, Type.GetType("System.String"));
objDT.Columns.Add(conqa_Paper.QuestionsCount, Type.GetType("System.Int32"));
objDT.Columns.Add(conqa_Paper.IsDelete, Type.GetType("System.Boolean"));
objDT.Columns.Add(conqa_Paper.IsPublic, Type.GetType("System.Boolean"));
objDT.Columns.Add(conqa_Paper.IsSubmit, Type.GetType("System.Boolean"));
objDT.Columns.Add(conqa_Paper.UpdUser, Type.GetType("System.String"));
objDT.Columns.Add(conqa_Paper.UpdDate, Type.GetType("System.String"));
objDT.Columns.Add(conqa_Paper.Memo, Type.GetType("System.String"));
objDT.Columns.Add(conqa_Paper.id_CurrEduCls, Type.GetType("System.String"));
objDT.Columns.Add(conqa_Paper.AnswerCount, Type.GetType("System.Int32"));
objDT.Columns.Add(conqa_Paper.ShareId, Type.GetType("System.String"));
objDT.Columns.Add(conqa_Paper.TagsCount, Type.GetType("System.Int32"));
foreach (clsqa_PaperEN objInFor in arrObjLst)
{
DataRow objDR = objDT.NewRow();
objDR[conqa_Paper.qa_PaperId] = objInFor[conqa_Paper.qa_PaperId];
objDR[conqa_Paper.PaperId] = objInFor[conqa_Paper.PaperId];
objDR[conqa_Paper.QuestionsCount] = objInFor[conqa_Paper.QuestionsCount];
objDR[conqa_Paper.IsDelete] = objInFor[conqa_Paper.IsDelete];
objDR[conqa_Paper.IsPublic] = objInFor[conqa_Paper.IsPublic];
objDR[conqa_Paper.IsSubmit] = objInFor[conqa_Paper.IsSubmit];
objDR[conqa_Paper.UpdUser] = objInFor[conqa_Paper.UpdUser];
objDR[conqa_Paper.UpdDate] = objInFor[conqa_Paper.UpdDate];
objDR[conqa_Paper.Memo] = objInFor[conqa_Paper.Memo];
objDR[conqa_Paper.id_CurrEduCls] = objInFor[conqa_Paper.id_CurrEduCls];
objDR[conqa_Paper.AnswerCount] = objInFor[conqa_Paper.AnswerCount];
objDR[conqa_Paper.ShareId] = objInFor[conqa_Paper.ShareId];
objDR[conqa_Paper.TagsCount] = objInFor[conqa_Paper.TagsCount];
objDT.Rows.Add(objDR);
}
return objDT;
}
}
 /// <summary>
 /// 论文答疑表(qa_Paper)
 /// 数据源类型:SQL表
 /// (AutoGCLib.CommFun4WA4CSharp:GeneCode_This)
 /// </summary>
public class clsCommFun4WA4qa_Paper : clsCommFun4BLV2
{

 /// <summary>
 /// 刷新缓存.把当前表的缓存以及该表相关视图的缓存清空.
 /// (AutoGCLib.CommFun4WA4CSharp:Gen_4CFWA_ReFreshCache)
 /// </summary>
public override void ReFreshCache(string strid_CurrEduCls)
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
clsqa_PaperWApi.ReFreshThisCache(strid_CurrEduCls);
clsvqa_PaperWApi.ReFreshThisCache(strid_CurrEduCls);
}
}

}