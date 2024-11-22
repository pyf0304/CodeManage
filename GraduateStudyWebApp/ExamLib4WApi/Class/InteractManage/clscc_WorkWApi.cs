
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clscc_WorkWApi
 表名:cc_Work(01120144)
 生成代码版本:2021.09.20.1
 生成日期:2021/09/21 02:45:09
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
public static class clscc_WorkWApi_Static
{

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_WorkEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clscc_WorkEN SetId_Work(this clscc_WorkEN objcc_WorkEN, string strId_Work, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strId_Work, 8, concc_Work.Id_Work);
clsCheckSql.CheckFieldForeignKey(strId_Work, 8, concc_Work.Id_Work);
objcc_WorkEN.Id_Work = strId_Work; //作业流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_WorkEN.dicFldComparisonOp.ContainsKey(concc_Work.Id_Work) == false)
{
objcc_WorkEN.dicFldComparisonOp.Add(concc_Work.Id_Work, strComparisonOp);
}
else
{
objcc_WorkEN.dicFldComparisonOp[concc_Work.Id_Work] = strComparisonOp;
}
}
return objcc_WorkEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_WorkEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clscc_WorkEN SetWorkIndex(this clscc_WorkEN objcc_WorkEN, int intWorkIndex, string strComparisonOp="")
	{
objcc_WorkEN.WorkIndex = intWorkIndex; //作业序号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_WorkEN.dicFldComparisonOp.ContainsKey(concc_Work.WorkIndex) == false)
{
objcc_WorkEN.dicFldComparisonOp.Add(concc_Work.WorkIndex, strComparisonOp);
}
else
{
objcc_WorkEN.dicFldComparisonOp[concc_Work.WorkIndex] = strComparisonOp;
}
}
return objcc_WorkEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_WorkEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clscc_WorkEN SetWorkName(this clscc_WorkEN objcc_WorkEN, string strWorkName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strWorkName, concc_Work.WorkName);
clsCheckSql.CheckFieldLen(strWorkName, 5000, concc_Work.WorkName);
objcc_WorkEN.WorkName = strWorkName; //作业名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_WorkEN.dicFldComparisonOp.ContainsKey(concc_Work.WorkName) == false)
{
objcc_WorkEN.dicFldComparisonOp.Add(concc_Work.WorkName, strComparisonOp);
}
else
{
objcc_WorkEN.dicFldComparisonOp[concc_Work.WorkName] = strComparisonOp;
}
}
return objcc_WorkEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_WorkEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clscc_WorkEN SetWorkDesc(this clscc_WorkEN objcc_WorkEN, string strWorkDesc, string strComparisonOp="")
	{
objcc_WorkEN.WorkDesc = strWorkDesc; //作业说明
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_WorkEN.dicFldComparisonOp.ContainsKey(concc_Work.WorkDesc) == false)
{
objcc_WorkEN.dicFldComparisonOp.Add(concc_Work.WorkDesc, strComparisonOp);
}
else
{
objcc_WorkEN.dicFldComparisonOp[concc_Work.WorkDesc] = strComparisonOp;
}
}
return objcc_WorkEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_WorkEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clscc_WorkEN SetCourseId(this clscc_WorkEN objcc_WorkEN, string strCourseId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strCourseId, concc_Work.CourseId);
clsCheckSql.CheckFieldLen(strCourseId, 8, concc_Work.CourseId);
clsCheckSql.CheckFieldForeignKey(strCourseId, 8, concc_Work.CourseId);
objcc_WorkEN.CourseId = strCourseId; //课程Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_WorkEN.dicFldComparisonOp.ContainsKey(concc_Work.CourseId) == false)
{
objcc_WorkEN.dicFldComparisonOp.Add(concc_Work.CourseId, strComparisonOp);
}
else
{
objcc_WorkEN.dicFldComparisonOp[concc_Work.CourseId] = strComparisonOp;
}
}
return objcc_WorkEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_WorkEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clscc_WorkEN SetCourseChapterId(this clscc_WorkEN objcc_WorkEN, string strCourseChapterId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCourseChapterId, 8, concc_Work.CourseChapterId);
clsCheckSql.CheckFieldForeignKey(strCourseChapterId, 8, concc_Work.CourseChapterId);
objcc_WorkEN.CourseChapterId = strCourseChapterId; //课程章节ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_WorkEN.dicFldComparisonOp.ContainsKey(concc_Work.CourseChapterId) == false)
{
objcc_WorkEN.dicFldComparisonOp.Add(concc_Work.CourseChapterId, strComparisonOp);
}
else
{
objcc_WorkEN.dicFldComparisonOp[concc_Work.CourseChapterId] = strComparisonOp;
}
}
return objcc_WorkEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_WorkEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clscc_WorkEN SetCreator(this clscc_WorkEN objcc_WorkEN, string strCreator, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCreator, 18, concc_Work.Creator);
objcc_WorkEN.Creator = strCreator; //创建者
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_WorkEN.dicFldComparisonOp.ContainsKey(concc_Work.Creator) == false)
{
objcc_WorkEN.dicFldComparisonOp.Add(concc_Work.Creator, strComparisonOp);
}
else
{
objcc_WorkEN.dicFldComparisonOp[concc_Work.Creator] = strComparisonOp;
}
}
return objcc_WorkEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_WorkEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clscc_WorkEN SetCreateDate(this clscc_WorkEN objcc_WorkEN, string strCreateDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCreateDate, 20, concc_Work.CreateDate);
objcc_WorkEN.CreateDate = strCreateDate; //建立日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_WorkEN.dicFldComparisonOp.ContainsKey(concc_Work.CreateDate) == false)
{
objcc_WorkEN.dicFldComparisonOp.Add(concc_Work.CreateDate, strComparisonOp);
}
else
{
objcc_WorkEN.dicFldComparisonOp[concc_Work.CreateDate] = strComparisonOp;
}
}
return objcc_WorkEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_WorkEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clscc_WorkEN SetAnswerAttLimitSize(this clscc_WorkEN objcc_WorkEN, long lngAnswerAttLimitSize, string strComparisonOp="")
	{
objcc_WorkEN.AnswerAttLimitSize = lngAnswerAttLimitSize; //回答附件限制大小
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_WorkEN.dicFldComparisonOp.ContainsKey(concc_Work.AnswerAttLimitSize) == false)
{
objcc_WorkEN.dicFldComparisonOp.Add(concc_Work.AnswerAttLimitSize, strComparisonOp);
}
else
{
objcc_WorkEN.dicFldComparisonOp[concc_Work.AnswerAttLimitSize] = strComparisonOp;
}
}
return objcc_WorkEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_WorkEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clscc_WorkEN SetLimitedResourceType(this clscc_WorkEN objcc_WorkEN, string strLimitedResourceType, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strLimitedResourceType, 100, concc_Work.LimitedResourceType);
objcc_WorkEN.LimitedResourceType = strLimitedResourceType; //限制资源类型
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_WorkEN.dicFldComparisonOp.ContainsKey(concc_Work.LimitedResourceType) == false)
{
objcc_WorkEN.dicFldComparisonOp.Add(concc_Work.LimitedResourceType, strComparisonOp);
}
else
{
objcc_WorkEN.dicFldComparisonOp[concc_Work.LimitedResourceType] = strComparisonOp;
}
}
return objcc_WorkEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_WorkEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clscc_WorkEN SetUpdDate(this clscc_WorkEN objcc_WorkEN, string strUpdDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strUpdDate, concc_Work.UpdDate);
clsCheckSql.CheckFieldLen(strUpdDate, 20, concc_Work.UpdDate);
objcc_WorkEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_WorkEN.dicFldComparisonOp.ContainsKey(concc_Work.UpdDate) == false)
{
objcc_WorkEN.dicFldComparisonOp.Add(concc_Work.UpdDate, strComparisonOp);
}
else
{
objcc_WorkEN.dicFldComparisonOp[concc_Work.UpdDate] = strComparisonOp;
}
}
return objcc_WorkEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_WorkEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clscc_WorkEN SetUpdUserId(this clscc_WorkEN objcc_WorkEN, string strUpdUserId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdUserId, 20, concc_Work.UpdUserId);
objcc_WorkEN.UpdUserId = strUpdUserId; //修改用户Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_WorkEN.dicFldComparisonOp.ContainsKey(concc_Work.UpdUserId) == false)
{
objcc_WorkEN.dicFldComparisonOp.Add(concc_Work.UpdUserId, strComparisonOp);
}
else
{
objcc_WorkEN.dicFldComparisonOp[concc_Work.UpdUserId] = strComparisonOp;
}
}
return objcc_WorkEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objcc_WorkEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clscc_WorkEN SetMemo(this clscc_WorkEN objcc_WorkEN, string strMemo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMemo, 1000, concc_Work.Memo);
objcc_WorkEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objcc_WorkEN.dicFldComparisonOp.ContainsKey(concc_Work.Memo) == false)
{
objcc_WorkEN.dicFldComparisonOp.Add(concc_Work.Memo, strComparisonOp);
}
else
{
objcc_WorkEN.dicFldComparisonOp[concc_Work.Memo] = strComparisonOp;
}
}
return objcc_WorkEN;
	}

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clscc_WorkEN objcc_Work_Cond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objcc_Work_Cond.IsUpdated(concc_Work.Id_Work) == true)
{
string strComparisonOp_Id_Work = objcc_Work_Cond.dicFldComparisonOp[concc_Work.Id_Work];
strWhereCond += string.Format(" And {0} {2} '{1}'", concc_Work.Id_Work, objcc_Work_Cond.Id_Work, strComparisonOp_Id_Work);
}
if (objcc_Work_Cond.IsUpdated(concc_Work.WorkIndex) == true)
{
string strComparisonOp_WorkIndex = objcc_Work_Cond.dicFldComparisonOp[concc_Work.WorkIndex];
strWhereCond += string.Format(" And {0} {2} {1}", concc_Work.WorkIndex, objcc_Work_Cond.WorkIndex, strComparisonOp_WorkIndex);
}
if (objcc_Work_Cond.IsUpdated(concc_Work.WorkName) == true)
{
string strComparisonOp_WorkName = objcc_Work_Cond.dicFldComparisonOp[concc_Work.WorkName];
strWhereCond += string.Format(" And {0} {2} '{1}'", concc_Work.WorkName, objcc_Work_Cond.WorkName, strComparisonOp_WorkName);
}
//数据类型string(text)在函数:[AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj]中没有处理！
if (objcc_Work_Cond.IsUpdated(concc_Work.CourseId) == true)
{
string strComparisonOp_CourseId = objcc_Work_Cond.dicFldComparisonOp[concc_Work.CourseId];
strWhereCond += string.Format(" And {0} {2} '{1}'", concc_Work.CourseId, objcc_Work_Cond.CourseId, strComparisonOp_CourseId);
}
if (objcc_Work_Cond.IsUpdated(concc_Work.CourseChapterId) == true)
{
string strComparisonOp_CourseChapterId = objcc_Work_Cond.dicFldComparisonOp[concc_Work.CourseChapterId];
strWhereCond += string.Format(" And {0} {2} '{1}'", concc_Work.CourseChapterId, objcc_Work_Cond.CourseChapterId, strComparisonOp_CourseChapterId);
}
if (objcc_Work_Cond.IsUpdated(concc_Work.Creator) == true)
{
string strComparisonOp_Creator = objcc_Work_Cond.dicFldComparisonOp[concc_Work.Creator];
strWhereCond += string.Format(" And {0} {2} '{1}'", concc_Work.Creator, objcc_Work_Cond.Creator, strComparisonOp_Creator);
}
if (objcc_Work_Cond.IsUpdated(concc_Work.CreateDate) == true)
{
string strComparisonOp_CreateDate = objcc_Work_Cond.dicFldComparisonOp[concc_Work.CreateDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", concc_Work.CreateDate, objcc_Work_Cond.CreateDate, strComparisonOp_CreateDate);
}
if (objcc_Work_Cond.IsUpdated(concc_Work.AnswerAttLimitSize) == true)
{
string strComparisonOp_AnswerAttLimitSize = objcc_Work_Cond.dicFldComparisonOp[concc_Work.AnswerAttLimitSize];
strWhereCond += string.Format(" And {0} {2} {1}", concc_Work.AnswerAttLimitSize, objcc_Work_Cond.AnswerAttLimitSize, strComparisonOp_AnswerAttLimitSize);
}
if (objcc_Work_Cond.IsUpdated(concc_Work.LimitedResourceType) == true)
{
string strComparisonOp_LimitedResourceType = objcc_Work_Cond.dicFldComparisonOp[concc_Work.LimitedResourceType];
strWhereCond += string.Format(" And {0} {2} '{1}'", concc_Work.LimitedResourceType, objcc_Work_Cond.LimitedResourceType, strComparisonOp_LimitedResourceType);
}
if (objcc_Work_Cond.IsUpdated(concc_Work.UpdDate) == true)
{
string strComparisonOp_UpdDate = objcc_Work_Cond.dicFldComparisonOp[concc_Work.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", concc_Work.UpdDate, objcc_Work_Cond.UpdDate, strComparisonOp_UpdDate);
}
if (objcc_Work_Cond.IsUpdated(concc_Work.UpdUserId) == true)
{
string strComparisonOp_UpdUserId = objcc_Work_Cond.dicFldComparisonOp[concc_Work.UpdUserId];
strWhereCond += string.Format(" And {0} {2} '{1}'", concc_Work.UpdUserId, objcc_Work_Cond.UpdUserId, strComparisonOp_UpdUserId);
}
if (objcc_Work_Cond.IsUpdated(concc_Work.Memo) == true)
{
string strComparisonOp_Memo = objcc_Work_Cond.dicFldComparisonOp[concc_Work.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", concc_Work.Memo, objcc_Work_Cond.Memo, strComparisonOp_Memo);
}
 return strWhereCond;
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_Update)
 /// </summary>
 /// <param name = "objcc_WorkEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clscc_WorkEN objcc_WorkEN)
{
 if (string.IsNullOrEmpty(objcc_WorkEN.Id_Work) == true)
 {
string strMsg = string.Format("(errid:Watl000003)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
objcc_WorkEN.sf_UpdFldSetStr = objcc_WorkEN.getsf_UpdFldSetStr();
clscc_WorkWApi.CheckPropertyNew(objcc_WorkEN); 
bool bolResult = clscc_WorkWApi.UpdateRecord(objcc_WorkEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clscc_WorkWApi.ReFreshCache();
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
 /// <param name = "objcc_WorkEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clscc_WorkEN objcc_WorkEN)
{
 if (string.IsNullOrEmpty(objcc_WorkEN.Id_Work) == true)
 {
string strMsg = string.Format("添加记录时，关键字不能为空!(from {0})\r\n", 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
 if (clscc_WorkWApi.IsExist(objcc_WorkEN.Id_Work) == true)
 {
string strMsg = string.Format("添加记录时，关键字:[{0}]已经存在!(from {1})\r\n", objcc_WorkEN.Id_Work, 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
try
{
clscc_WorkWApi.CheckPropertyNew(objcc_WorkEN); 
bool bolResult = clscc_WorkWApi.AddNewRecord(objcc_WorkEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clscc_WorkWApi.ReFreshCache();
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
 /// <param name = "objcc_WorkEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static string AddNewRecordWithMaxId(this clscc_WorkEN objcc_WorkEN)
{
try
{
clscc_WorkWApi.CheckPropertyNew(objcc_WorkEN); 
string strId_Work = clscc_WorkWApi.AddNewRecordWithMaxId(objcc_WorkEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clscc_WorkWApi.ReFreshCache();
return strId_Work;
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
 /// <param name = "objcc_WorkEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clscc_WorkEN objcc_WorkEN, string strWhereCond)
{
try
{
clscc_WorkWApi.CheckPropertyNew(objcc_WorkEN); 
bool bolResult = clscc_WorkWApi.UpdateWithCondition(objcc_WorkEN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clscc_WorkWApi.ReFreshCache();
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
 /// 作业(cc_Work)
 /// (AutoGCLib.WA_Access4CSharp:GeneCode)
 /// </summary>
public class clscc_WorkWApi
{
private static readonly string mstrApiControllerName = "cc_WorkApi";

 /// <summary>
/// 专门在逻辑层用于处理缓存等公共函数的对象
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_DefineObjCommFun4BL)
/// </summary>
public static clsCommFun4BL objCommFun4BL = null;

 public clscc_WorkWApi()
 {
 }

 /// <summary>
 /// 绑定基于Web的下拉框
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_DdlBindFunction)
 /// </summary>
 /// <param name="objDDL">需要绑定当前表的下拉框</param>
public static void BindDdl_Id_Work(System.Web.UI.WebControls.DropDownList objDDL)
{
//为数据源于表的下拉框设置内容
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[作业]...","0");
List<clscc_WorkEN> arrObjLst = GetObjLst("1=1");
objDDL.DataValueField="Id_Work";
objDDL.DataTextField="WorkName";
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
public static void BindCbo_Id_Work(System.Windows.Forms.ComboBox objComboBox )
{
//为数据源为表的下拉框设置内容
string strCondition = string.Format("1 =1 Order By {0}", concc_Work.Id_Work); 
List<clscc_WorkEN> arrObjLst = clscc_WorkWApi.GetObjLst(strCondition);
//初始化一个对象列表
//插入第0项。在第0项中插入“请选择...”,为了方便用户,与WEB方式类似。
clscc_WorkEN objcc_WorkEN = new clscc_WorkEN()
{
Id_Work = "0",
WorkName = "选[作业]..."
};
arrObjLst.Insert(0, objcc_WorkEN);
//设置下拉框的数据源、以及设置值项、显示项
objComboBox.ValueMember = concc_Work.Id_Work;
objComboBox.DisplayMember = concc_Work.WorkName;
objComboBox.DataSource = arrObjLst;
objComboBox.SelectedIndex = 0;
}

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_CheckPropertyNew)
 /// </summary>
public static void CheckPropertyNew(clscc_WorkEN objcc_WorkEN)
{
if (!Object.Equals(null, objcc_WorkEN.Id_Work) && GetStrLen(objcc_WorkEN.Id_Work) > 8)
{
 throw new Exception("字段[作业流水号]的长度不能超过8!");
}
if (!Object.Equals(null, objcc_WorkEN.WorkName) && GetStrLen(objcc_WorkEN.WorkName) > 5000)
{
 throw new Exception("字段[作业名称]的长度不能超过5000!");
}
if (!Object.Equals(null, objcc_WorkEN.CourseId) && GetStrLen(objcc_WorkEN.CourseId) > 8)
{
 throw new Exception("字段[课程Id]的长度不能超过8!");
}
if (!Object.Equals(null, objcc_WorkEN.CourseChapterId) && GetStrLen(objcc_WorkEN.CourseChapterId) > 8)
{
 throw new Exception("字段[课程章节ID]的长度不能超过8!");
}
if (!Object.Equals(null, objcc_WorkEN.Creator) && GetStrLen(objcc_WorkEN.Creator) > 18)
{
 throw new Exception("字段[创建者]的长度不能超过18!");
}
if (!Object.Equals(null, objcc_WorkEN.CreateDate) && GetStrLen(objcc_WorkEN.CreateDate) > 20)
{
 throw new Exception("字段[建立日期]的长度不能超过20!");
}
if (!Object.Equals(null, objcc_WorkEN.LimitedResourceType) && GetStrLen(objcc_WorkEN.LimitedResourceType) > 100)
{
 throw new Exception("字段[限制资源类型]的长度不能超过100!");
}
if (!Object.Equals(null, objcc_WorkEN.UpdDate) && GetStrLen(objcc_WorkEN.UpdDate) > 20)
{
 throw new Exception("字段[修改日期]的长度不能超过20!");
}
if (!Object.Equals(null, objcc_WorkEN.UpdUserId) && GetStrLen(objcc_WorkEN.UpdUserId) > 20)
{
 throw new Exception("字段[修改用户Id]的长度不能超过20!");
}
if (!Object.Equals(null, objcc_WorkEN.Memo) && GetStrLen(objcc_WorkEN.Memo) > 1000)
{
 throw new Exception("字段[备注]的长度不能超过1000!");
}
 objcc_WorkEN._IsCheckProperty = true;
 }

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyId)
 /// </summary>
 /// <param name = "strId_Work">表关键字</param>
 /// <returns>表对象</returns>
public static clscc_WorkEN GetObjById_Work(string strId_Work)
{
string strAction = "GetObjById_Work";
string strErrMsg = string.Empty;
string strResult = "";
clscc_WorkEN objcc_WorkEN = null;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["Id_Work"] = strId_Work
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
objcc_WorkEN = JsonConvert.DeserializeObject<clscc_WorkEN>((string)jobjReturn["ReturnObj"]);
return objcc_WorkEN;
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
 /// <param name = "strId_Work">表关键字</param>
 /// <returns>表对象</returns>
public static clscc_WorkEN GetObjById_Work_WA_Cache(string strId_Work)
{
string strAction = "GetObjById_Work_Cache";
string strErrMsg = string.Empty;
string strResult = "";
clscc_WorkEN objcc_WorkEN = null;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["Id_Work"] = strId_Work
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
objcc_WorkEN = JsonConvert.DeserializeObject<clscc_WorkEN>((string)jobjReturn["ReturnObj"]);
return objcc_WorkEN;
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
public static clscc_WorkEN GetFirstObj(string strWhereCond)
{
string strAction = "GetFirstObj";
string strErrMsg = string.Empty;
string strResult = "";
clscc_WorkEN objcc_WorkEN = null;
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
objcc_WorkEN = JsonConvert.DeserializeObject<clscc_WorkEN>((string)jobjReturn["ReturnObj"]);
return objcc_WorkEN;
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
 /// <param name = "strId_Work">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clscc_WorkEN GetObjById_Work_Cache(string strId_Work)
{
if (string.IsNullOrEmpty(strId_Work) == true) return null;
//初始化列表缓存
string strKey = string.Format("{0}", clscc_WorkEN._CurrTabName_S);
List<clscc_WorkEN> arrcc_WorkObjLst_Cache = GetObjLst_Cache();
IEnumerable <clscc_WorkEN> arrcc_WorkObjLst_Sel =
from objcc_WorkEN in arrcc_WorkObjLst_Cache
where objcc_WorkEN.Id_Work == strId_Work
select objcc_WorkEN;
if (arrcc_WorkObjLst_Sel.Count() == 0)
{
   clscc_WorkEN obj = clscc_WorkWApi.GetObjById_Work(strId_Work);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
     return obj;
 }
return null;
}
return arrcc_WorkObjLst_Sel.First();
}

 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetRecNameByKey_Cache)
 /// </summary>
 /// <param name = "strId_Work">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetWorkNameById_Work_Cache(string strId_Work)
{
if (string.IsNullOrEmpty(strId_Work) == true) return "";
//初始化列表缓存
string strKey = string.Format("{0}", clscc_WorkEN._CurrTabName_S);
List<clscc_WorkEN> arrcc_WorkObjLst_Cache = GetObjLst_Cache();
IEnumerable <clscc_WorkEN> arrcc_WorkObjLst_Sel1 =
from objcc_WorkEN in arrcc_WorkObjLst_Cache
where objcc_WorkEN.Id_Work == strId_Work
select objcc_WorkEN;
List <clscc_WorkEN> arrcc_WorkObjLst_Sel = new List<clscc_WorkEN>();
foreach (clscc_WorkEN obj in arrcc_WorkObjLst_Sel1)
{
arrcc_WorkObjLst_Sel.Add(obj);
}
if (arrcc_WorkObjLst_Sel.Count > 0)
{
return arrcc_WorkObjLst_Sel[0].WorkName;
}
string strErrMsgForGetObjById = string.Format("在cc_Work对象缓存列表中,找不到记录[Id_Work = {0}](函数:{1})", strId_Work, clsStackTrace.GetCurrFunction());
clsLog.LogErrorS2("clscc_WorkBL", clsStackTrace.GetCurrClassFunction(), strErrMsgForGetObjById, "", "");
throw new Exception(strErrMsgForGetObjById);
}
 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetRecNameByKey_Cache)
 /// </summary>
 /// <param name = "strId_Work">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetNameById_Work_Cache(string strId_Work)
{
if (string.IsNullOrEmpty(strId_Work) == true) return "";
//初始化列表缓存
string strKey = string.Format("{0}", clscc_WorkEN._CurrTabName_S);
List<clscc_WorkEN> arrcc_WorkObjLst_Cache = GetObjLst_Cache();
IEnumerable <clscc_WorkEN> arrcc_WorkObjLst_Sel1 =
from objcc_WorkEN in arrcc_WorkObjLst_Cache
where objcc_WorkEN.Id_Work == strId_Work
select objcc_WorkEN;
List <clscc_WorkEN> arrcc_WorkObjLst_Sel = new List<clscc_WorkEN>();
foreach (clscc_WorkEN obj in arrcc_WorkObjLst_Sel1)
{
arrcc_WorkObjLst_Sel.Add(obj);
}
if (arrcc_WorkObjLst_Sel.Count > 0)
{
return arrcc_WorkObjLst_Sel[0].WorkName;
}
string strErrMsgForGetObjById = string.Format("在cc_Work对象缓存列表中,找不到记录的相关名称[Id_Work = {0}](函数:{1})", strId_Work, clsStackTrace.GetCurrFunction());
clsLog.LogErrorS2("clscc_WorkBL", clsStackTrace.GetCurrClassFunction(), strErrMsgForGetObjById, "", "");
throw new Exception(strErrMsgForGetObjById);
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clscc_WorkEN> GetObjLst(string strWhereCond)
{
 List<clscc_WorkEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clscc_WorkEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clscc_WorkEN> GetObjLstById_WorkLst(List<string> arrId_Work)
{
 List<clscc_WorkEN> arrObjLst = null; 
string strAction = "GetObjLstById_WorkLst";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrId_Work);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
arrObjLst = JsonConvert.DeserializeObject<List<clscc_WorkEN>>((string)jobjReturn["ReturnObjLst"]);
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
 /// <param name = "strId_Work">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static IEnumerable<clscc_WorkEN> GetObjLstById_WorkLst_Cache(List<string> arrId_Work)
{
//初始化列表缓存
string strKey = string.Format("{0}", clscc_WorkEN._CurrTabName_S);
List<clscc_WorkEN> arrcc_WorkObjLst_Cache = GetObjLst_Cache();
IEnumerable <clscc_WorkEN> arrcc_WorkObjLst_Sel =
from objcc_WorkEN in arrcc_WorkObjLst_Cache
where arrId_Work.Contains(objcc_WorkEN.Id_Work)
select objcc_WorkEN;
return arrcc_WorkObjLst_Sel;
}

 /// <summary>
 /// 根据关键字列表获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstByKeyLst_WA_Cache)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clscc_WorkEN> GetObjLstById_WorkLst_WA_Cache(List<string> arrId_Work)
{
 List<clscc_WorkEN> arrObjLst = null; 
string strAction = "GetObjLstById_WorkLst_Cache";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
};
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrId_Work);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
arrObjLst = JsonConvert.DeserializeObject<List<clscc_WorkEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clscc_WorkEN> GetTopObjLst(stuTopPara objTopPara)
{
 List<clscc_WorkEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clscc_WorkEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clscc_WorkEN> GetObjLstByRange(stuRangePara objRangePara)
{
 List<clscc_WorkEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clscc_WorkEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clscc_WorkEN> GetObjLstByPager(stuPagerPara objPagerPara)
{
 List<clscc_WorkEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clscc_WorkEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clscc_WorkEN> GetObjLstByPager_Cache(stuPagerPara objPagerPara)
{
 List<clscc_WorkEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clscc_WorkEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static int DelRecord(string strId_Work)
{
string strAction = "DelRecord";
string strErrMsg = string.Empty;
string strResult = "";
try
{
 clscc_WorkEN objcc_WorkEN = clscc_WorkWApi.GetObjById_Work(strId_Work);
if (clsPubFun4WApi.Delete(mstrApiControllerName, strAction, strId_Work.ToString(), out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
clscc_WorkWApi.ReFreshCache();
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
public static int Delcc_Works(List<string> arrId_Work)
{
string strAction = "Delcc_Works";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrId_Work);
if (clsPubFun4WApi.Deletes(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
clscc_WorkWApi.ReFreshCache();
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
public static int Delcc_WorksByCond(string strWhereCond)
{
string strAction = "Delcc_WorksByCond";
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
public static bool AddNewRecord(clscc_WorkEN objcc_WorkEN)
{
string strAction = "AddNewRecord";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clscc_WorkEN>(objcc_WorkEN);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJson, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clscc_WorkWApi.ReFreshCache();
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
public static string AddNewRecordWithMaxId(clscc_WorkEN objcc_WorkEN)
{
string strAction = "AddNewRecordWithMaxId";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clscc_WorkEN>(objcc_WorkEN);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJson, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clscc_WorkWApi.ReFreshCache();
var strId_Work = (string)jobjReturn["ReturnStr"];
return strId_Work;
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
public static bool UpdateRecord(clscc_WorkEN objcc_WorkEN)
{
if (string.IsNullOrEmpty(objcc_WorkEN.sf_UpdFldSetStr) == true)
{
string strMsg = string.Format("修改时，修改标志串为空，请联系管理员.对象关键字:{0}.(from {1}).",
objcc_WorkEN.Id_Work, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
string strAction = "UpdateRecord";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clscc_WorkEN>(objcc_WorkEN);
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
 /// <param name = "objcc_WorkEN">需要修改的对象</param>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的关键字值</returns>
public static bool UpdateWithCondition(clscc_WorkEN objcc_WorkEN, string strWhereCond)
{
if (string.IsNullOrEmpty(objcc_WorkEN.sf_UpdFldSetStr) == true)
{
string strMsg = string.Format("修改时，修改标志串为空，请联系管理员.对象关键字:{0}.(from {1}).",
objcc_WorkEN.Id_Work, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (string.IsNullOrEmpty(strWhereCond) == true)
{
string strMsg = string.Format("按条件修改时，条件串为空，请联系管理员.对象关键字:{0}.(from {1}).",
objcc_WorkEN.Id_Work, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
string strAction = "UpdateWithCondition";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clscc_WorkEN>(objcc_WorkEN);
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
public static bool IsExist(string strId_Work)
{
//检测记录是否存在
string strAction = "IsExist";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["Id_Work"] = strId_Work
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
 /// <param name = "objcc_WorkENS">源对象</param>
 /// <param name = "objcc_WorkENT">目标对象</param>
 public static void CopyTo(clscc_WorkEN objcc_WorkENS, clscc_WorkEN objcc_WorkENT)
{
try
{
objcc_WorkENT.Id_Work = objcc_WorkENS.Id_Work; //作业流水号
objcc_WorkENT.WorkIndex = objcc_WorkENS.WorkIndex; //作业序号
objcc_WorkENT.WorkName = objcc_WorkENS.WorkName; //作业名称
objcc_WorkENT.WorkDesc = objcc_WorkENS.WorkDesc; //作业说明
objcc_WorkENT.CourseId = objcc_WorkENS.CourseId; //课程Id
objcc_WorkENT.CourseChapterId = objcc_WorkENS.CourseChapterId; //课程章节ID
objcc_WorkENT.Creator = objcc_WorkENS.Creator; //创建者
objcc_WorkENT.CreateDate = objcc_WorkENS.CreateDate; //建立日期
objcc_WorkENT.AnswerAttLimitSize = objcc_WorkENS.AnswerAttLimitSize; //回答附件限制大小
objcc_WorkENT.LimitedResourceType = objcc_WorkENS.LimitedResourceType; //限制资源类型
objcc_WorkENT.UpdDate = objcc_WorkENS.UpdDate; //修改日期
objcc_WorkENT.UpdUserId = objcc_WorkENS.UpdUserId; //修改用户Id
objcc_WorkENT.Memo = objcc_WorkENS.Memo; //备注
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
public static DataTable ToDataTable(List<clscc_WorkEN> arrObj)
{
DataTable dataTable = new DataTable(); //实例化
DataTable result;
if (arrObj.Count == 0) return null;
if (clscc_WorkEN.AttributeName.Length == 0)
{
result = dataTable;
return result;
}
Type type = typeof(clscc_WorkEN);
PropertyInfo[] arrPropertyInfo = type.GetProperties();
try
{
//Columns
foreach (string strAttrName in clscc_WorkEN.AttributeName)
{
PropertyInfo proprety_Curr = arrPropertyInfo.Where(x => x.Name == strAttrName).First();
dataTable.Columns.Add(strAttrName, proprety_Curr.PropertyType);
}
foreach (clscc_WorkEN objInFor in arrObj)
{
//Rows
DataRow dataRow = dataTable.NewRow();
foreach (string strAttrName in clscc_WorkEN.AttributeName)
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
if (clscc_WorkWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clscc_WorkWApi没有刷新缓存机制(clscc_WorkWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by Id_Work");
//if (arrcc_WorkObjLst_Cache == null)
//{
//arrcc_WorkObjLst_Cache = await clscc_WorkWApi.GetObjLst(strWhereCond);
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
string strKey = string.Format("{0}", clscc_WorkEN._CurrTabName_S);
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
if (clscc_WorkWApi.objCommFun4BL != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}", clscc_WorkEN._CurrTabName_S);
CacheHelper.Remove(strKey);
clscc_WorkWApi.objCommFun4BL.ReFreshCache();
}
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst_Cache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clscc_WorkEN> GetObjLst_Cache()
{
//初始化列表缓存
InitListCache(); 
string strKey = string.Format("{0}", clscc_WorkEN._CurrTabName_S);
List<clscc_WorkEN> arrcc_WorkObjLst_Cache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrcc_WorkObjLst_Cache;
}

 /// <summary>
 /// 根据对象列表获取DataTable
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetDataTableByObjLst)
 /// </summary>
 /// <param name = "arrObjLst">给定的对象列表</param>
 /// <returns>返回DataTable</returns>
public static DataTable GetDataTableByObjLst(List<clscc_WorkEN> arrObjLst)
{
DataTable objDT = new DataTable();
objDT.Columns.Add(concc_Work.Id_Work, Type.GetType("System.String"));
objDT.Columns.Add(concc_Work.WorkIndex, Type.GetType("System.Int32"));
objDT.Columns.Add(concc_Work.WorkName, Type.GetType("System.String"));
objDT.Columns.Add(concc_Work.WorkDesc, Type.GetType("System.String"));
objDT.Columns.Add(concc_Work.CourseId, Type.GetType("System.String"));
objDT.Columns.Add(concc_Work.CourseChapterId, Type.GetType("System.String"));
objDT.Columns.Add(concc_Work.Creator, Type.GetType("System.String"));
objDT.Columns.Add(concc_Work.CreateDate, Type.GetType("System.String"));
objDT.Columns.Add(concc_Work.AnswerAttLimitSize, Type.GetType("System.Int64"));
objDT.Columns.Add(concc_Work.LimitedResourceType, Type.GetType("System.String"));
objDT.Columns.Add(concc_Work.UpdDate, Type.GetType("System.String"));
objDT.Columns.Add(concc_Work.UpdUserId, Type.GetType("System.String"));
objDT.Columns.Add(concc_Work.Memo, Type.GetType("System.String"));
foreach (clscc_WorkEN objInFor in arrObjLst)
{
DataRow objDR = objDT.NewRow();
objDR[concc_Work.Id_Work] = objInFor[concc_Work.Id_Work];
objDR[concc_Work.WorkIndex] = objInFor[concc_Work.WorkIndex];
objDR[concc_Work.WorkName] = objInFor[concc_Work.WorkName];
objDR[concc_Work.WorkDesc] = objInFor[concc_Work.WorkDesc];
objDR[concc_Work.CourseId] = objInFor[concc_Work.CourseId];
objDR[concc_Work.CourseChapterId] = objInFor[concc_Work.CourseChapterId];
objDR[concc_Work.Creator] = objInFor[concc_Work.Creator];
objDR[concc_Work.CreateDate] = objInFor[concc_Work.CreateDate];
objDR[concc_Work.AnswerAttLimitSize] = objInFor[concc_Work.AnswerAttLimitSize];
objDR[concc_Work.LimitedResourceType] = objInFor[concc_Work.LimitedResourceType];
objDR[concc_Work.UpdDate] = objInFor[concc_Work.UpdDate];
objDR[concc_Work.UpdUserId] = objInFor[concc_Work.UpdUserId];
objDR[concc_Work.Memo] = objInFor[concc_Work.Memo];
objDT.Rows.Add(objDR);
}
return objDT;
}
}
 /// <summary>
 /// 作业(cc_Work)
 /// 数据源类型:SQL表
 /// (AutoGCLib.CommFun4WA4CSharp:GeneCode_This)
 /// </summary>
public class clsCommFun4WA4cc_Work : clsCommFun4BL
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
clscc_WorkWApi.ReFreshThisCache();
clsvcc_WorkWApi.ReFreshThisCache();
}
}

}