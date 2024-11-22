
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvgs_TobeStudiedProblemBL
 表名:vgs_TobeStudiedProblem(01120774)
 * 版本:2023.08.23.1(服务器:WIN-SRV103-116)
 日期:2023/08/24 13:05:25
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:公共后台所有表(变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:研培主题(GradEduTopic)
 框架-层名:业务逻辑层(CS)(BusinessLogic)
 编程语言:CSharp
 注意:1、需要数据底层(PubDataBase.dll)的版本:2019.03.07.01
        2、需要公共函数层(TzPubFunction.dll)的版本:2017.12.21.01
 == == == == == == == == == == == == 
 **/
using System;
using System.Text; 
using System.Collections; 
using System.Collections.Generic; 
using System.Globalization;
using System.IO;
using System.Linq;
using System.ComponentModel;
using System.Xml;
using Newtonsoft.Json;
using com.taishsoft.file;
using com.taishsoft.common;
using com.taishsoft.commdb;
using com.taishsoft.comm_db_obj;
using com.taishsoft.json;
using com.taishsoft.dynamiccompiler;
using com.taishsoft.datetime;
using ExamLib.Entity;
using System.Data; 
using System.Data.SqlClient; 
using ExamLib.DAL;

namespace ExamLib.BusinessLogic
{
public static class  clsvgs_TobeStudiedProblemBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "strProblemId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvgs_TobeStudiedProblemEN GetObj(this K_ProblemId_vgs_TobeStudiedProblem myKey)
{
clsvgs_TobeStudiedProblemEN objvgs_TobeStudiedProblemEN = clsvgs_TobeStudiedProblemBL.vgs_TobeStudiedProblemDA.GetObjByProblemId(myKey.Value);
return objvgs_TobeStudiedProblemEN;
}

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvgs_TobeStudiedProblemEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvgs_TobeStudiedProblemEN SetProblemId(this clsvgs_TobeStudiedProblemEN objvgs_TobeStudiedProblemEN, string strProblemId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strProblemId, 10, convgs_TobeStudiedProblem.ProblemId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strProblemId, 10, convgs_TobeStudiedProblem.ProblemId);
}
objvgs_TobeStudiedProblemEN.ProblemId = strProblemId; //问题Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvgs_TobeStudiedProblemEN.dicFldComparisonOp.ContainsKey(convgs_TobeStudiedProblem.ProblemId) == false)
{
objvgs_TobeStudiedProblemEN.dicFldComparisonOp.Add(convgs_TobeStudiedProblem.ProblemId, strComparisonOp);
}
else
{
objvgs_TobeStudiedProblemEN.dicFldComparisonOp[convgs_TobeStudiedProblem.ProblemId] = strComparisonOp;
}
}
return objvgs_TobeStudiedProblemEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvgs_TobeStudiedProblemEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvgs_TobeStudiedProblemEN SetProblemTitle(this clsvgs_TobeStudiedProblemEN objvgs_TobeStudiedProblemEN, string strProblemTitle, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strProblemTitle, 1000, convgs_TobeStudiedProblem.ProblemTitle);
}
objvgs_TobeStudiedProblemEN.ProblemTitle = strProblemTitle; //问题标题
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvgs_TobeStudiedProblemEN.dicFldComparisonOp.ContainsKey(convgs_TobeStudiedProblem.ProblemTitle) == false)
{
objvgs_TobeStudiedProblemEN.dicFldComparisonOp.Add(convgs_TobeStudiedProblem.ProblemTitle, strComparisonOp);
}
else
{
objvgs_TobeStudiedProblemEN.dicFldComparisonOp[convgs_TobeStudiedProblem.ProblemTitle] = strComparisonOp;
}
}
return objvgs_TobeStudiedProblemEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvgs_TobeStudiedProblemEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvgs_TobeStudiedProblemEN SetProblemContent(this clsvgs_TobeStudiedProblemEN objvgs_TobeStudiedProblemEN, string strProblemContent, string strComparisonOp="")
	{
objvgs_TobeStudiedProblemEN.ProblemContent = strProblemContent; //问题内容
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvgs_TobeStudiedProblemEN.dicFldComparisonOp.ContainsKey(convgs_TobeStudiedProblem.ProblemContent) == false)
{
objvgs_TobeStudiedProblemEN.dicFldComparisonOp.Add(convgs_TobeStudiedProblem.ProblemContent, strComparisonOp);
}
else
{
objvgs_TobeStudiedProblemEN.dicFldComparisonOp[convgs_TobeStudiedProblem.ProblemContent] = strComparisonOp;
}
}
return objvgs_TobeStudiedProblemEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvgs_TobeStudiedProblemEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvgs_TobeStudiedProblemEN SetTopicId(this clsvgs_TobeStudiedProblemEN objvgs_TobeStudiedProblemEN, string strTopicId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTopicId, 8, convgs_TobeStudiedProblem.TopicId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strTopicId, 8, convgs_TobeStudiedProblem.TopicId);
}
objvgs_TobeStudiedProblemEN.TopicId = strTopicId; //主题Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvgs_TobeStudiedProblemEN.dicFldComparisonOp.ContainsKey(convgs_TobeStudiedProblem.TopicId) == false)
{
objvgs_TobeStudiedProblemEN.dicFldComparisonOp.Add(convgs_TobeStudiedProblem.TopicId, strComparisonOp);
}
else
{
objvgs_TobeStudiedProblemEN.dicFldComparisonOp[convgs_TobeStudiedProblem.TopicId] = strComparisonOp;
}
}
return objvgs_TobeStudiedProblemEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvgs_TobeStudiedProblemEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvgs_TobeStudiedProblemEN SetTopicName(this clsvgs_TobeStudiedProblemEN objvgs_TobeStudiedProblemEN, string strTopicName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTopicName, 200, convgs_TobeStudiedProblem.TopicName);
}
objvgs_TobeStudiedProblemEN.TopicName = strTopicName; //栏目主题
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvgs_TobeStudiedProblemEN.dicFldComparisonOp.ContainsKey(convgs_TobeStudiedProblem.TopicName) == false)
{
objvgs_TobeStudiedProblemEN.dicFldComparisonOp.Add(convgs_TobeStudiedProblem.TopicName, strComparisonOp);
}
else
{
objvgs_TobeStudiedProblemEN.dicFldComparisonOp[convgs_TobeStudiedProblem.TopicName] = strComparisonOp;
}
}
return objvgs_TobeStudiedProblemEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvgs_TobeStudiedProblemEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvgs_TobeStudiedProblemEN SetIdCurrEduCls(this clsvgs_TobeStudiedProblemEN objvgs_TobeStudiedProblemEN, string strIdCurrEduCls, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdCurrEduCls, 8, convgs_TobeStudiedProblem.IdCurrEduCls);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdCurrEduCls, 8, convgs_TobeStudiedProblem.IdCurrEduCls);
}
objvgs_TobeStudiedProblemEN.IdCurrEduCls = strIdCurrEduCls; //教学班流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvgs_TobeStudiedProblemEN.dicFldComparisonOp.ContainsKey(convgs_TobeStudiedProblem.IdCurrEduCls) == false)
{
objvgs_TobeStudiedProblemEN.dicFldComparisonOp.Add(convgs_TobeStudiedProblem.IdCurrEduCls, strComparisonOp);
}
else
{
objvgs_TobeStudiedProblemEN.dicFldComparisonOp[convgs_TobeStudiedProblem.IdCurrEduCls] = strComparisonOp;
}
}
return objvgs_TobeStudiedProblemEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvgs_TobeStudiedProblemEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvgs_TobeStudiedProblemEN SetIsSubmit(this clsvgs_TobeStudiedProblemEN objvgs_TobeStudiedProblemEN, bool bolIsSubmit, string strComparisonOp="")
	{
objvgs_TobeStudiedProblemEN.IsSubmit = bolIsSubmit; //是否提交
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvgs_TobeStudiedProblemEN.dicFldComparisonOp.ContainsKey(convgs_TobeStudiedProblem.IsSubmit) == false)
{
objvgs_TobeStudiedProblemEN.dicFldComparisonOp.Add(convgs_TobeStudiedProblem.IsSubmit, strComparisonOp);
}
else
{
objvgs_TobeStudiedProblemEN.dicFldComparisonOp[convgs_TobeStudiedProblem.IsSubmit] = strComparisonOp;
}
}
return objvgs_TobeStudiedProblemEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvgs_TobeStudiedProblemEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvgs_TobeStudiedProblemEN SetProblemDate(this clsvgs_TobeStudiedProblemEN objvgs_TobeStudiedProblemEN, string strProblemDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strProblemDate, 20, convgs_TobeStudiedProblem.ProblemDate);
}
objvgs_TobeStudiedProblemEN.ProblemDate = strProblemDate; //问题日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvgs_TobeStudiedProblemEN.dicFldComparisonOp.ContainsKey(convgs_TobeStudiedProblem.ProblemDate) == false)
{
objvgs_TobeStudiedProblemEN.dicFldComparisonOp.Add(convgs_TobeStudiedProblem.ProblemDate, strComparisonOp);
}
else
{
objvgs_TobeStudiedProblemEN.dicFldComparisonOp[convgs_TobeStudiedProblem.ProblemDate] = strComparisonOp;
}
}
return objvgs_TobeStudiedProblemEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvgs_TobeStudiedProblemEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvgs_TobeStudiedProblemEN SetUpdDate(this clsvgs_TobeStudiedProblemEN objvgs_TobeStudiedProblemEN, string strUpdDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdDate, 20, convgs_TobeStudiedProblem.UpdDate);
}
objvgs_TobeStudiedProblemEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvgs_TobeStudiedProblemEN.dicFldComparisonOp.ContainsKey(convgs_TobeStudiedProblem.UpdDate) == false)
{
objvgs_TobeStudiedProblemEN.dicFldComparisonOp.Add(convgs_TobeStudiedProblem.UpdDate, strComparisonOp);
}
else
{
objvgs_TobeStudiedProblemEN.dicFldComparisonOp[convgs_TobeStudiedProblem.UpdDate] = strComparisonOp;
}
}
return objvgs_TobeStudiedProblemEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvgs_TobeStudiedProblemEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvgs_TobeStudiedProblemEN SetUpdUser(this clsvgs_TobeStudiedProblemEN objvgs_TobeStudiedProblemEN, string strUpdUser, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdUser, 20, convgs_TobeStudiedProblem.UpdUser);
}
objvgs_TobeStudiedProblemEN.UpdUser = strUpdUser; //修改人
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvgs_TobeStudiedProblemEN.dicFldComparisonOp.ContainsKey(convgs_TobeStudiedProblem.UpdUser) == false)
{
objvgs_TobeStudiedProblemEN.dicFldComparisonOp.Add(convgs_TobeStudiedProblem.UpdUser, strComparisonOp);
}
else
{
objvgs_TobeStudiedProblemEN.dicFldComparisonOp[convgs_TobeStudiedProblem.UpdUser] = strComparisonOp;
}
}
return objvgs_TobeStudiedProblemEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvgs_TobeStudiedProblemEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvgs_TobeStudiedProblemEN SetYear(this clsvgs_TobeStudiedProblemEN objvgs_TobeStudiedProblemEN, string strYear, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strYear, 4, convgs_TobeStudiedProblem.Year);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strYear, 4, convgs_TobeStudiedProblem.Year);
}
objvgs_TobeStudiedProblemEN.Year = strYear; //年
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvgs_TobeStudiedProblemEN.dicFldComparisonOp.ContainsKey(convgs_TobeStudiedProblem.Year) == false)
{
objvgs_TobeStudiedProblemEN.dicFldComparisonOp.Add(convgs_TobeStudiedProblem.Year, strComparisonOp);
}
else
{
objvgs_TobeStudiedProblemEN.dicFldComparisonOp[convgs_TobeStudiedProblem.Year] = strComparisonOp;
}
}
return objvgs_TobeStudiedProblemEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvgs_TobeStudiedProblemEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvgs_TobeStudiedProblemEN SetMonth(this clsvgs_TobeStudiedProblemEN objvgs_TobeStudiedProblemEN, string strMonth, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMonth, 2, convgs_TobeStudiedProblem.Month);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strMonth, 2, convgs_TobeStudiedProblem.Month);
}
objvgs_TobeStudiedProblemEN.Month = strMonth; //月
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvgs_TobeStudiedProblemEN.dicFldComparisonOp.ContainsKey(convgs_TobeStudiedProblem.Month) == false)
{
objvgs_TobeStudiedProblemEN.dicFldComparisonOp.Add(convgs_TobeStudiedProblem.Month, strComparisonOp);
}
else
{
objvgs_TobeStudiedProblemEN.dicFldComparisonOp[convgs_TobeStudiedProblem.Month] = strComparisonOp;
}
}
return objvgs_TobeStudiedProblemEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvgs_TobeStudiedProblemEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvgs_TobeStudiedProblemEN SetVersionCount(this clsvgs_TobeStudiedProblemEN objvgs_TobeStudiedProblemEN, int? intVersionCount, string strComparisonOp="")
	{
objvgs_TobeStudiedProblemEN.VersionCount = intVersionCount; //版本统计
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvgs_TobeStudiedProblemEN.dicFldComparisonOp.ContainsKey(convgs_TobeStudiedProblem.VersionCount) == false)
{
objvgs_TobeStudiedProblemEN.dicFldComparisonOp.Add(convgs_TobeStudiedProblem.VersionCount, strComparisonOp);
}
else
{
objvgs_TobeStudiedProblemEN.dicFldComparisonOp[convgs_TobeStudiedProblem.VersionCount] = strComparisonOp;
}
}
return objvgs_TobeStudiedProblemEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvgs_TobeStudiedProblemEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvgs_TobeStudiedProblemEN SetParticipant(this clsvgs_TobeStudiedProblemEN objvgs_TobeStudiedProblemEN, string strParticipant, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strParticipant, 500, convgs_TobeStudiedProblem.Participant);
}
objvgs_TobeStudiedProblemEN.Participant = strParticipant; //参与者
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvgs_TobeStudiedProblemEN.dicFldComparisonOp.ContainsKey(convgs_TobeStudiedProblem.Participant) == false)
{
objvgs_TobeStudiedProblemEN.dicFldComparisonOp.Add(convgs_TobeStudiedProblem.Participant, strComparisonOp);
}
else
{
objvgs_TobeStudiedProblemEN.dicFldComparisonOp[convgs_TobeStudiedProblem.Participant] = strComparisonOp;
}
}
return objvgs_TobeStudiedProblemEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvgs_TobeStudiedProblemEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvgs_TobeStudiedProblemEN SetMemo(this clsvgs_TobeStudiedProblemEN objvgs_TobeStudiedProblemEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, convgs_TobeStudiedProblem.Memo);
}
objvgs_TobeStudiedProblemEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvgs_TobeStudiedProblemEN.dicFldComparisonOp.ContainsKey(convgs_TobeStudiedProblem.Memo) == false)
{
objvgs_TobeStudiedProblemEN.dicFldComparisonOp.Add(convgs_TobeStudiedProblem.Memo, strComparisonOp);
}
else
{
objvgs_TobeStudiedProblemEN.dicFldComparisonOp[convgs_TobeStudiedProblem.Memo] = strComparisonOp;
}
}
return objvgs_TobeStudiedProblemEN;
	}

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CopyObj)
 /// </summary>
 /// <param name = "objvgs_TobeStudiedProblemENS">源对象</param>
 /// <param name = "objvgs_TobeStudiedProblemENT">目标对象</param>
 public static void CopyTo(this clsvgs_TobeStudiedProblemEN objvgs_TobeStudiedProblemENS, clsvgs_TobeStudiedProblemEN objvgs_TobeStudiedProblemENT)
{
try
{
objvgs_TobeStudiedProblemENT.ProblemId = objvgs_TobeStudiedProblemENS.ProblemId; //问题Id
objvgs_TobeStudiedProblemENT.ProblemTitle = objvgs_TobeStudiedProblemENS.ProblemTitle; //问题标题
objvgs_TobeStudiedProblemENT.ProblemContent = objvgs_TobeStudiedProblemENS.ProblemContent; //问题内容
objvgs_TobeStudiedProblemENT.TopicId = objvgs_TobeStudiedProblemENS.TopicId; //主题Id
objvgs_TobeStudiedProblemENT.TopicName = objvgs_TobeStudiedProblemENS.TopicName; //栏目主题
objvgs_TobeStudiedProblemENT.IdCurrEduCls = objvgs_TobeStudiedProblemENS.IdCurrEduCls; //教学班流水号
objvgs_TobeStudiedProblemENT.IsSubmit = objvgs_TobeStudiedProblemENS.IsSubmit; //是否提交
objvgs_TobeStudiedProblemENT.ProblemDate = objvgs_TobeStudiedProblemENS.ProblemDate; //问题日期
objvgs_TobeStudiedProblemENT.UpdDate = objvgs_TobeStudiedProblemENS.UpdDate; //修改日期
objvgs_TobeStudiedProblemENT.UpdUser = objvgs_TobeStudiedProblemENS.UpdUser; //修改人
objvgs_TobeStudiedProblemENT.Year = objvgs_TobeStudiedProblemENS.Year; //年
objvgs_TobeStudiedProblemENT.Month = objvgs_TobeStudiedProblemENS.Month; //月
objvgs_TobeStudiedProblemENT.VersionCount = objvgs_TobeStudiedProblemENS.VersionCount; //版本统计
objvgs_TobeStudiedProblemENT.Participant = objvgs_TobeStudiedProblemENS.Participant; //参与者
objvgs_TobeStudiedProblemENT.Memo = objvgs_TobeStudiedProblemENS.Memo; //备注
}
catch (Exception objException)
{
string strMsg = string.Format("(errid:Busi000166)Copy表对象数据出错,{1}.({0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
}
}

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CopyTo)
 /// </summary>
 /// <param name = "objvgs_TobeStudiedProblemENS">源对象</param>
 /// <returns>目标对象=>clsvgs_TobeStudiedProblemEN:objvgs_TobeStudiedProblemENT</returns>
 public static clsvgs_TobeStudiedProblemEN CopyTo(this clsvgs_TobeStudiedProblemEN objvgs_TobeStudiedProblemENS)
{
try
{
 clsvgs_TobeStudiedProblemEN objvgs_TobeStudiedProblemENT = new clsvgs_TobeStudiedProblemEN()
{
ProblemId = objvgs_TobeStudiedProblemENS.ProblemId, //问题Id
ProblemTitle = objvgs_TobeStudiedProblemENS.ProblemTitle, //问题标题
ProblemContent = objvgs_TobeStudiedProblemENS.ProblemContent, //问题内容
TopicId = objvgs_TobeStudiedProblemENS.TopicId, //主题Id
TopicName = objvgs_TobeStudiedProblemENS.TopicName, //栏目主题
IdCurrEduCls = objvgs_TobeStudiedProblemENS.IdCurrEduCls, //教学班流水号
IsSubmit = objvgs_TobeStudiedProblemENS.IsSubmit, //是否提交
ProblemDate = objvgs_TobeStudiedProblemENS.ProblemDate, //问题日期
UpdDate = objvgs_TobeStudiedProblemENS.UpdDate, //修改日期
UpdUser = objvgs_TobeStudiedProblemENS.UpdUser, //修改人
Year = objvgs_TobeStudiedProblemENS.Year, //年
Month = objvgs_TobeStudiedProblemENS.Month, //月
VersionCount = objvgs_TobeStudiedProblemENS.VersionCount, //版本统计
Participant = objvgs_TobeStudiedProblemENS.Participant, //参与者
Memo = objvgs_TobeStudiedProblemENS.Memo, //备注
};
 return objvgs_TobeStudiedProblemENT;
}
catch (Exception objException)
{
string strMsg = string.Format("(errid:Busi000167)Copy表对象数据出错,{1}.({0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
}
}

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(this clsvgs_TobeStudiedProblemEN objvgs_TobeStudiedProblemEN)
{
 clsvgs_TobeStudiedProblemBL.vgs_TobeStudiedProblemDA.CheckProperty4Condition(objvgs_TobeStudiedProblemEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvgs_TobeStudiedProblemEN objvgs_TobeStudiedProblemCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvgs_TobeStudiedProblemCond.IsUpdated(convgs_TobeStudiedProblem.ProblemId) == true)
{
string strComparisonOpProblemId = objvgs_TobeStudiedProblemCond.dicFldComparisonOp[convgs_TobeStudiedProblem.ProblemId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convgs_TobeStudiedProblem.ProblemId, objvgs_TobeStudiedProblemCond.ProblemId, strComparisonOpProblemId);
}
if (objvgs_TobeStudiedProblemCond.IsUpdated(convgs_TobeStudiedProblem.ProblemTitle) == true)
{
string strComparisonOpProblemTitle = objvgs_TobeStudiedProblemCond.dicFldComparisonOp[convgs_TobeStudiedProblem.ProblemTitle];
strWhereCond += string.Format(" And {0} {2} '{1}'", convgs_TobeStudiedProblem.ProblemTitle, objvgs_TobeStudiedProblemCond.ProblemTitle, strComparisonOpProblemTitle);
}
//数据类型string(text)在函数:[AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj]中没有处理!
if (objvgs_TobeStudiedProblemCond.IsUpdated(convgs_TobeStudiedProblem.TopicId) == true)
{
string strComparisonOpTopicId = objvgs_TobeStudiedProblemCond.dicFldComparisonOp[convgs_TobeStudiedProblem.TopicId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convgs_TobeStudiedProblem.TopicId, objvgs_TobeStudiedProblemCond.TopicId, strComparisonOpTopicId);
}
if (objvgs_TobeStudiedProblemCond.IsUpdated(convgs_TobeStudiedProblem.TopicName) == true)
{
string strComparisonOpTopicName = objvgs_TobeStudiedProblemCond.dicFldComparisonOp[convgs_TobeStudiedProblem.TopicName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convgs_TobeStudiedProblem.TopicName, objvgs_TobeStudiedProblemCond.TopicName, strComparisonOpTopicName);
}
if (objvgs_TobeStudiedProblemCond.IsUpdated(convgs_TobeStudiedProblem.IdCurrEduCls) == true)
{
string strComparisonOpIdCurrEduCls = objvgs_TobeStudiedProblemCond.dicFldComparisonOp[convgs_TobeStudiedProblem.IdCurrEduCls];
strWhereCond += string.Format(" And {0} {2} '{1}'", convgs_TobeStudiedProblem.IdCurrEduCls, objvgs_TobeStudiedProblemCond.IdCurrEduCls, strComparisonOpIdCurrEduCls);
}
if (objvgs_TobeStudiedProblemCond.IsUpdated(convgs_TobeStudiedProblem.IsSubmit) == true)
{
if (objvgs_TobeStudiedProblemCond.IsSubmit == true)
{
strWhereCond += string.Format(" And {0} = '1'", convgs_TobeStudiedProblem.IsSubmit);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convgs_TobeStudiedProblem.IsSubmit);
}
}
if (objvgs_TobeStudiedProblemCond.IsUpdated(convgs_TobeStudiedProblem.ProblemDate) == true)
{
string strComparisonOpProblemDate = objvgs_TobeStudiedProblemCond.dicFldComparisonOp[convgs_TobeStudiedProblem.ProblemDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convgs_TobeStudiedProblem.ProblemDate, objvgs_TobeStudiedProblemCond.ProblemDate, strComparisonOpProblemDate);
}
if (objvgs_TobeStudiedProblemCond.IsUpdated(convgs_TobeStudiedProblem.UpdDate) == true)
{
string strComparisonOpUpdDate = objvgs_TobeStudiedProblemCond.dicFldComparisonOp[convgs_TobeStudiedProblem.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convgs_TobeStudiedProblem.UpdDate, objvgs_TobeStudiedProblemCond.UpdDate, strComparisonOpUpdDate);
}
if (objvgs_TobeStudiedProblemCond.IsUpdated(convgs_TobeStudiedProblem.UpdUser) == true)
{
string strComparisonOpUpdUser = objvgs_TobeStudiedProblemCond.dicFldComparisonOp[convgs_TobeStudiedProblem.UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", convgs_TobeStudiedProblem.UpdUser, objvgs_TobeStudiedProblemCond.UpdUser, strComparisonOpUpdUser);
}
if (objvgs_TobeStudiedProblemCond.IsUpdated(convgs_TobeStudiedProblem.Year) == true)
{
string strComparisonOpYear = objvgs_TobeStudiedProblemCond.dicFldComparisonOp[convgs_TobeStudiedProblem.Year];
strWhereCond += string.Format(" And {0} {2} '{1}'", convgs_TobeStudiedProblem.Year, objvgs_TobeStudiedProblemCond.Year, strComparisonOpYear);
}
if (objvgs_TobeStudiedProblemCond.IsUpdated(convgs_TobeStudiedProblem.Month) == true)
{
string strComparisonOpMonth = objvgs_TobeStudiedProblemCond.dicFldComparisonOp[convgs_TobeStudiedProblem.Month];
strWhereCond += string.Format(" And {0} {2} '{1}'", convgs_TobeStudiedProblem.Month, objvgs_TobeStudiedProblemCond.Month, strComparisonOpMonth);
}
if (objvgs_TobeStudiedProblemCond.IsUpdated(convgs_TobeStudiedProblem.VersionCount) == true)
{
string strComparisonOpVersionCount = objvgs_TobeStudiedProblemCond.dicFldComparisonOp[convgs_TobeStudiedProblem.VersionCount];
strWhereCond += string.Format(" And {0} {2} {1}", convgs_TobeStudiedProblem.VersionCount, objvgs_TobeStudiedProblemCond.VersionCount, strComparisonOpVersionCount);
}
if (objvgs_TobeStudiedProblemCond.IsUpdated(convgs_TobeStudiedProblem.Participant) == true)
{
string strComparisonOpParticipant = objvgs_TobeStudiedProblemCond.dicFldComparisonOp[convgs_TobeStudiedProblem.Participant];
strWhereCond += string.Format(" And {0} {2} '{1}'", convgs_TobeStudiedProblem.Participant, objvgs_TobeStudiedProblemCond.Participant, strComparisonOpParticipant);
}
if (objvgs_TobeStudiedProblemCond.IsUpdated(convgs_TobeStudiedProblem.Memo) == true)
{
string strComparisonOpMemo = objvgs_TobeStudiedProblemCond.dicFldComparisonOp[convgs_TobeStudiedProblem.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convgs_TobeStudiedProblem.Memo, objvgs_TobeStudiedProblemCond.Memo, strComparisonOpMemo);
}
 return strWhereCond;
}

 /// <summary>
 /// 检查唯一性(Uniqueness)--vgs_TobeStudiedProblem(待研究问题视图), 如果不唯一,即存在相同的记录,就返回False
 /// 唯一性条件:ProblemId
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckConstraint)
 /// </summary>
 /// <param name = "objvgs_TobeStudiedProblemEN">要求唯一的对象</param>
 /// <returns></returns>
public static bool CheckUniqueness(this clsvgs_TobeStudiedProblemEN objvgs_TobeStudiedProblemEN)
{
//检测记录是否存在
bool bolIsUniqueness;
StringBuilder sbCondition = new StringBuilder();
if (objvgs_TobeStudiedProblemEN == null) return true;
if (objvgs_TobeStudiedProblemEN.ProblemId == null || objvgs_TobeStudiedProblemEN.ProblemId == "")
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and ProblemId = '{0}'", objvgs_TobeStudiedProblemEN.ProblemId);
if (clsvgs_TobeStudiedProblemBL.IsExistRecord(sbCondition.ToString())  ==  true)
{
 bolIsUniqueness = false;
}
else
{
 bolIsUniqueness = true;
}
}
 else {
sbCondition.AppendFormat("ProblemId !=  '{0}'", objvgs_TobeStudiedProblemEN.ProblemId);
 sbCondition.AppendFormat(" and ProblemId = '{0}'", objvgs_TobeStudiedProblemEN.ProblemId);
if (clsvgs_TobeStudiedProblemBL.IsExistRecord(sbCondition.ToString())  ==  true)
{
 bolIsUniqueness = false;
}
else
{
 bolIsUniqueness = true;
}
}
return bolIsUniqueness;
}

 /// <summary>
 /// 获取唯一性条件串--vgs_TobeStudiedProblem(待研究问题视图), 即由对象中唯一性条件字段关键字与值组成的条件串
 /// 唯一性条件:ProblemId
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetConditionString4Constraint)
 /// </summary>
 /// <param name = "objvgs_TobeStudiedProblemEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(this clsvgs_TobeStudiedProblemEN objvgs_TobeStudiedProblemEN)
{
//检测记录是否存在
StringBuilder sbCondition = new StringBuilder();
if (objvgs_TobeStudiedProblemEN == null) return "";
if (objvgs_TobeStudiedProblemEN.ProblemId == null || objvgs_TobeStudiedProblemEN.ProblemId == "")
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and ProblemId = '{0}'", objvgs_TobeStudiedProblemEN.ProblemId);
return sbCondition.ToString();
}
 else {
sbCondition.AppendFormat("ProblemId !=  '{0}'", objvgs_TobeStudiedProblemEN.ProblemId);
 sbCondition.AppendFormat(" and ProblemId = '{0}'", objvgs_TobeStudiedProblemEN.ProblemId);
 return sbCondition.ToString();
}
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_vgs_TobeStudiedProblem
{
public virtual bool UpdRelaTabDate(string strProblemId, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// 待研究问题视图(vgs_TobeStudiedProblem)
 /// 数据源类型:视图
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsvgs_TobeStudiedProblemBL
{
public static RelatedActions_vgs_TobeStudiedProblem relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsvgs_TobeStudiedProblemDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsvgs_TobeStudiedProblemDA vgs_TobeStudiedProblemDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsvgs_TobeStudiedProblemDA();
}
return uniqueInstance;
}
}

 /// <summary>
 /// 类的构造函数
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ClassConstructor1)
 /// </summary>
 public clsvgs_TobeStudiedProblemBL()
 {
 }

 /// <summary>
 /// 获取SQL服务器连接对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSpecSQLObj)
 /// </summary>
 /// <returns>SQL服务器连接对象</returns>
 public static clsSpecSQLforSql GetSpecSQLObj() 
{
if (clsSysParaEN.objLog == null)
{
throw new Exception("请初始化用于记录日志的clsSysParaEN.objLog对象!");
}
if (clsSysParaEN.objErrorLog == null)
{
throw new Exception("请初始化用于记录错误日志的clsSysParaEN.objErrorLog对象!");
}
 clsSpecSQLforSql objSQL;
 //1. 如果系统参数(SysPara)中设置使用连接串名,就用该连接串名所指定的连接串
 if (clsSysParaEN.bolIsUseConnectStrName == true)
 {
 objSQL = new clsSpecSQLforSql(clsSysParaEN.strConnectStrName, true);
 return objSQL;
 }
 //2. 如果类所指定的连接串非空,就用该类所指定的连接串
 //3. 否则就用项目系统配置(web.config or app.config)中所指定的默认连接串
if (string.IsNullOrEmpty(clsvgs_TobeStudiedProblemEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvgs_TobeStudiedProblemEN._ConnectString);
}
return objSQL;
}



 #region 获取数据表的DataTable

 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetDataTable)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回数据表,用DataTable表示</returns>
public static DataTable GetDataTable_vgs_TobeStudiedProblem(string strWhereCond)
{
DataTable objDT;
try
{
objDT = vgs_TobeStudiedProblemDA.GetDataTable_vgs_TobeStudiedProblem(strWhereCond);
return objDT;
}
catch (Exception objException)
{
var strMsg = string.Format("(errid:Busi000005)获取表数据出错!(strWhereCond = {1}),{2}.({0})",
clsStackTrace.GetCurrClassFunction(),
strWhereCond,
objException.Message); 
throw new Exception(strMsg); 
}
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetDataTable)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回数据表,用DataTable表示</returns>
public static DataTable GetDataTable(string strWhereCond)
{
DataTable objDT;
try
{
objDT = vgs_TobeStudiedProblemDA.GetDataTable(strWhereCond);
return objDT;
}
catch (Exception objException)
{
var strMsg = string.Format("(errid:Busi000006)获取表数据出错!(strWhereCond = {1}), {2}.({0})",
clsStackTrace.GetCurrClassFunction(),
strWhereCond,
objException.Message); 
throw new Exception(strMsg); 
}
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时可以排除一些关键字不检查
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetDataTable)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <param name = "lstExclude">排除的检查字符串列表</param>
 /// <returns></returns>
public static DataTable GetDataTable(string strWhereCond, List<string> lstExclude)
{
DataTable objDT;
try
{
objDT = vgs_TobeStudiedProblemDA.GetDataTable(strWhereCond, lstExclude);
return objDT;
}
catch (Exception objException)
{
var strMsg = string.Format("(errid:Busi000007)获取表数据出错!(排除的检查字符串列表)(strWhereCond = {1}), {2}.({0})",
clsStackTrace.GetCurrClassFunction(),
strWhereCond,
objException.Message); 
throw new Exception(strMsg); 
}
}

 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetDataTableByTabName)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回数据表,用DataTable表示</returns>
public static DataTable GetDataTable(string strWhereCond, string strTabName)
{
DataTable objDT;
try
{
objDT = vgs_TobeStudiedProblemDA.GetDataTable(strWhereCond, strTabName);
return objDT;
}
catch (Exception objException)
{
var strMsg = string.Format("(errid:Busi000061)获取表数据出错!(strWhereCond = {1}),{2}.({0})",
clsStackTrace.GetCurrClassFunction(),
strWhereCond,
objException.Message); 
throw new Exception(strMsg); 
}
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时可以排除一些关键字不检查
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetDataTableByTabName)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <param name = "lstExclude">排除的检查字符串列表</param>
 /// <returns></returns>
public static DataTable GetDataTable(string strWhereCond, string strTabName, List<string> lstExclude)
{
DataTable objDT;
try
{
objDT = vgs_TobeStudiedProblemDA.GetDataTable(strWhereCond, strTabName, lstExclude);
return objDT;
}
catch (Exception objException)
{
var strMsg = string.Format("(errid:Busi000062)获取表数据出错!(排除的检查字符串列表)(strWhereCond = {1}),{2}.({0})",
clsStackTrace.GetCurrClassFunction(),
strWhereCond,
objException.Message); 
throw new Exception(strMsg); 
}
}

 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopDataTable)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回数据表,用DataTable表示</returns>
public static DataTable GetDataTable_Top(stuTopPara objTopPara)
{
DataTable objDT;
try
{
objDT = vgs_TobeStudiedProblemDA.GetDataTable_Top(objTopPara);
return objDT;
}
catch (Exception objException)
{
var strMsg = string.Format("(errid:Busi000009)获取表顶数据出错!(strWhereCond = {1}),{2}.({0})",
clsStackTrace.GetCurrClassFunction(),
objTopPara.whereCond,
objException.Message); 
throw new Exception(strMsg); 
}
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时可以排除一些关键字不检查
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopDataTable)
 /// </summary>
 /// <param name = "intTopSize">顶部记录数</param>
 /// <param name = "strWhereCond">条件串</param>
 /// <param name = "lstExclude">排除的检查字符串列表</param>
 /// <returns></returns>
public static DataTable GetDataTable_Top(int intTopSize, string strWhereCond, List<string> lstExclude)
{
DataTable objDT;
try
{
objDT = vgs_TobeStudiedProblemDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
return objDT;
}
catch (Exception objException)
{
var strMsg = string.Format("(errid:Busi000010)获取表顶数据出错!(排除的检查字符串列表)(strWhereCond = {1}),{2}.({0})",
clsStackTrace.GetCurrClassFunction(),
strWhereCond,
objException.Message); 
throw new Exception(strMsg); 
}
}

 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetDataTableByPager)
 /// </summary>
 /// <param name = "intPageIndex">页序号</param>
 /// <param name = "intPageSize">页记录数</param>
 /// <param name = "strWhereCond">条件串</param>
 /// <param name = "strOrderBy">排序方式</param>
 /// <returns>返回数据表,用DataTable表示</returns>
public static DataTable GetDataTableByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
DataTable objDT;
try
{
objDT = vgs_TobeStudiedProblemDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
return objDT;
}
catch (Exception objException)
{
var strMsg = string.Format("(errid:Busi000012)获取分页表顶数据出错!(strWhereCond = {1}),{2}.({0})",
clsStackTrace.GetCurrClassFunction(),
strWhereCond,
objException.Message); 
throw new Exception(strMsg); 
}
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时可以排除一些关键字不检查
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetDataTableByPager)
 /// </summary>
 /// <param name = "intPageIndex">页序号</param>
 /// <param name = "intPageSize">页记录数</param>
 /// <param name = "strWhereCond">条件串</param>
 /// <param name = "strOrderBy">排序方式</param>
 /// <param name = "lstExclude">排除的检查字符串列表</param>
 /// <returns></returns>
public static DataTable GetDataTableByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
DataTable objDT;
try
{
objDT = vgs_TobeStudiedProblemDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
return objDT;
}
catch (Exception objException)
{
var strMsg = string.Format("(errid:Busi000013)获取分页表顶数据出错!(排除的检查字符串列表)(strWhereCond = {1}),{2}.({0})",
clsStackTrace.GetCurrClassFunction(),
strWhereCond,
objException.Message); 
throw new Exception(strMsg); 
}
}


 #endregion 获取数据表的DataTable


 #region 获取数据表的多个对象列表

 /// <summary>
 /// 根据关键字列表获取相关对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLst)
 /// </summary>
 /// <param name = "arrProblemIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static List<clsvgs_TobeStudiedProblemEN> GetObjLstByProblemIdLst(List<string> arrProblemIdLst)
{
List<clsvgs_TobeStudiedProblemEN> arrObjLst = new List<clsvgs_TobeStudiedProblemEN>(); 
System.Data.DataTable objDT; 
 string strSqlConditionStr = clsArray.GetSqlInStrByArray(arrProblemIdLst, true);
 string strWhereCond = string.Format("ProblemId in ({0})", strSqlConditionStr);
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvgs_TobeStudiedProblemEN objvgs_TobeStudiedProblemEN = new clsvgs_TobeStudiedProblemEN();
try
{
objvgs_TobeStudiedProblemEN.ProblemId = objRow[convgs_TobeStudiedProblem.ProblemId].ToString().Trim(); //问题Id
objvgs_TobeStudiedProblemEN.ProblemTitle = objRow[convgs_TobeStudiedProblem.ProblemTitle] == DBNull.Value ? null : objRow[convgs_TobeStudiedProblem.ProblemTitle].ToString().Trim(); //问题标题
objvgs_TobeStudiedProblemEN.ProblemContent = objRow[convgs_TobeStudiedProblem.ProblemContent] == DBNull.Value ? null : objRow[convgs_TobeStudiedProblem.ProblemContent].ToString().Trim(); //问题内容
objvgs_TobeStudiedProblemEN.TopicId = objRow[convgs_TobeStudiedProblem.TopicId] == DBNull.Value ? null : objRow[convgs_TobeStudiedProblem.TopicId].ToString().Trim(); //主题Id
objvgs_TobeStudiedProblemEN.TopicName = objRow[convgs_TobeStudiedProblem.TopicName] == DBNull.Value ? null : objRow[convgs_TobeStudiedProblem.TopicName].ToString().Trim(); //栏目主题
objvgs_TobeStudiedProblemEN.IdCurrEduCls = objRow[convgs_TobeStudiedProblem.IdCurrEduCls] == DBNull.Value ? null : objRow[convgs_TobeStudiedProblem.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvgs_TobeStudiedProblemEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[convgs_TobeStudiedProblem.IsSubmit].ToString().Trim()); //是否提交
objvgs_TobeStudiedProblemEN.ProblemDate = objRow[convgs_TobeStudiedProblem.ProblemDate] == DBNull.Value ? null : objRow[convgs_TobeStudiedProblem.ProblemDate].ToString().Trim(); //问题日期
objvgs_TobeStudiedProblemEN.UpdDate = objRow[convgs_TobeStudiedProblem.UpdDate] == DBNull.Value ? null : objRow[convgs_TobeStudiedProblem.UpdDate].ToString().Trim(); //修改日期
objvgs_TobeStudiedProblemEN.UpdUser = objRow[convgs_TobeStudiedProblem.UpdUser] == DBNull.Value ? null : objRow[convgs_TobeStudiedProblem.UpdUser].ToString().Trim(); //修改人
objvgs_TobeStudiedProblemEN.Year = objRow[convgs_TobeStudiedProblem.Year] == DBNull.Value ? null : objRow[convgs_TobeStudiedProblem.Year].ToString().Trim(); //年
objvgs_TobeStudiedProblemEN.Month = objRow[convgs_TobeStudiedProblem.Month] == DBNull.Value ? null : objRow[convgs_TobeStudiedProblem.Month].ToString().Trim(); //月
objvgs_TobeStudiedProblemEN.VersionCount = objRow[convgs_TobeStudiedProblem.VersionCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convgs_TobeStudiedProblem.VersionCount].ToString().Trim()); //版本统计
objvgs_TobeStudiedProblemEN.Participant = objRow[convgs_TobeStudiedProblem.Participant] == DBNull.Value ? null : objRow[convgs_TobeStudiedProblem.Participant].ToString().Trim(); //参与者
objvgs_TobeStudiedProblemEN.Memo = objRow[convgs_TobeStudiedProblem.Memo] == DBNull.Value ? null : objRow[convgs_TobeStudiedProblem.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvgs_TobeStudiedProblemEN.ProblemId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvgs_TobeStudiedProblemEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrProblemIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsvgs_TobeStudiedProblemEN> GetObjLstByProblemIdLstCache(List<string> arrProblemIdLst)
{
string strKey = string.Format("{0}", clsvgs_TobeStudiedProblemEN._CurrTabName);
List<clsvgs_TobeStudiedProblemEN> arrvgs_TobeStudiedProblemObjLstCache = GetObjLstCache();
IEnumerable <clsvgs_TobeStudiedProblemEN> arrvgs_TobeStudiedProblemObjLst_Sel =
arrvgs_TobeStudiedProblemObjLstCache
.Where(x => arrProblemIdLst.Contains(x.ProblemId));
return arrvgs_TobeStudiedProblemObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvgs_TobeStudiedProblemEN> GetObjLst(string strWhereCond)
{
List<clsvgs_TobeStudiedProblemEN> arrObjLst = new List<clsvgs_TobeStudiedProblemEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvgs_TobeStudiedProblemEN objvgs_TobeStudiedProblemEN = new clsvgs_TobeStudiedProblemEN();
try
{
objvgs_TobeStudiedProblemEN.ProblemId = objRow[convgs_TobeStudiedProblem.ProblemId].ToString().Trim(); //问题Id
objvgs_TobeStudiedProblemEN.ProblemTitle = objRow[convgs_TobeStudiedProblem.ProblemTitle] == DBNull.Value ? null : objRow[convgs_TobeStudiedProblem.ProblemTitle].ToString().Trim(); //问题标题
objvgs_TobeStudiedProblemEN.ProblemContent = objRow[convgs_TobeStudiedProblem.ProblemContent] == DBNull.Value ? null : objRow[convgs_TobeStudiedProblem.ProblemContent].ToString().Trim(); //问题内容
objvgs_TobeStudiedProblemEN.TopicId = objRow[convgs_TobeStudiedProblem.TopicId] == DBNull.Value ? null : objRow[convgs_TobeStudiedProblem.TopicId].ToString().Trim(); //主题Id
objvgs_TobeStudiedProblemEN.TopicName = objRow[convgs_TobeStudiedProblem.TopicName] == DBNull.Value ? null : objRow[convgs_TobeStudiedProblem.TopicName].ToString().Trim(); //栏目主题
objvgs_TobeStudiedProblemEN.IdCurrEduCls = objRow[convgs_TobeStudiedProblem.IdCurrEduCls] == DBNull.Value ? null : objRow[convgs_TobeStudiedProblem.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvgs_TobeStudiedProblemEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[convgs_TobeStudiedProblem.IsSubmit].ToString().Trim()); //是否提交
objvgs_TobeStudiedProblemEN.ProblemDate = objRow[convgs_TobeStudiedProblem.ProblemDate] == DBNull.Value ? null : objRow[convgs_TobeStudiedProblem.ProblemDate].ToString().Trim(); //问题日期
objvgs_TobeStudiedProblemEN.UpdDate = objRow[convgs_TobeStudiedProblem.UpdDate] == DBNull.Value ? null : objRow[convgs_TobeStudiedProblem.UpdDate].ToString().Trim(); //修改日期
objvgs_TobeStudiedProblemEN.UpdUser = objRow[convgs_TobeStudiedProblem.UpdUser] == DBNull.Value ? null : objRow[convgs_TobeStudiedProblem.UpdUser].ToString().Trim(); //修改人
objvgs_TobeStudiedProblemEN.Year = objRow[convgs_TobeStudiedProblem.Year] == DBNull.Value ? null : objRow[convgs_TobeStudiedProblem.Year].ToString().Trim(); //年
objvgs_TobeStudiedProblemEN.Month = objRow[convgs_TobeStudiedProblem.Month] == DBNull.Value ? null : objRow[convgs_TobeStudiedProblem.Month].ToString().Trim(); //月
objvgs_TobeStudiedProblemEN.VersionCount = objRow[convgs_TobeStudiedProblem.VersionCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convgs_TobeStudiedProblem.VersionCount].ToString().Trim()); //版本统计
objvgs_TobeStudiedProblemEN.Participant = objRow[convgs_TobeStudiedProblem.Participant] == DBNull.Value ? null : objRow[convgs_TobeStudiedProblem.Participant].ToString().Trim(); //参与者
objvgs_TobeStudiedProblemEN.Memo = objRow[convgs_TobeStudiedProblem.Memo] == DBNull.Value ? null : objRow[convgs_TobeStudiedProblem.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvgs_TobeStudiedProblemEN.ProblemId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvgs_TobeStudiedProblemEN);
	}
return arrObjLst;
}
 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <param name = "lstExclude">查询条件中排除的标志列表</param>
 /// <returns>返回对象列表</returns>
public static List<clsvgs_TobeStudiedProblemEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsvgs_TobeStudiedProblemEN> arrObjLst = new List<clsvgs_TobeStudiedProblemEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvgs_TobeStudiedProblemEN objvgs_TobeStudiedProblemEN = new clsvgs_TobeStudiedProblemEN();
try
{
objvgs_TobeStudiedProblemEN.ProblemId = objRow[convgs_TobeStudiedProblem.ProblemId].ToString().Trim(); //问题Id
objvgs_TobeStudiedProblemEN.ProblemTitle = objRow[convgs_TobeStudiedProblem.ProblemTitle] == DBNull.Value ? null : objRow[convgs_TobeStudiedProblem.ProblemTitle].ToString().Trim(); //问题标题
objvgs_TobeStudiedProblemEN.ProblemContent = objRow[convgs_TobeStudiedProblem.ProblemContent] == DBNull.Value ? null : objRow[convgs_TobeStudiedProblem.ProblemContent].ToString().Trim(); //问题内容
objvgs_TobeStudiedProblemEN.TopicId = objRow[convgs_TobeStudiedProblem.TopicId] == DBNull.Value ? null : objRow[convgs_TobeStudiedProblem.TopicId].ToString().Trim(); //主题Id
objvgs_TobeStudiedProblemEN.TopicName = objRow[convgs_TobeStudiedProblem.TopicName] == DBNull.Value ? null : objRow[convgs_TobeStudiedProblem.TopicName].ToString().Trim(); //栏目主题
objvgs_TobeStudiedProblemEN.IdCurrEduCls = objRow[convgs_TobeStudiedProblem.IdCurrEduCls] == DBNull.Value ? null : objRow[convgs_TobeStudiedProblem.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvgs_TobeStudiedProblemEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[convgs_TobeStudiedProblem.IsSubmit].ToString().Trim()); //是否提交
objvgs_TobeStudiedProblemEN.ProblemDate = objRow[convgs_TobeStudiedProblem.ProblemDate] == DBNull.Value ? null : objRow[convgs_TobeStudiedProblem.ProblemDate].ToString().Trim(); //问题日期
objvgs_TobeStudiedProblemEN.UpdDate = objRow[convgs_TobeStudiedProblem.UpdDate] == DBNull.Value ? null : objRow[convgs_TobeStudiedProblem.UpdDate].ToString().Trim(); //修改日期
objvgs_TobeStudiedProblemEN.UpdUser = objRow[convgs_TobeStudiedProblem.UpdUser] == DBNull.Value ? null : objRow[convgs_TobeStudiedProblem.UpdUser].ToString().Trim(); //修改人
objvgs_TobeStudiedProblemEN.Year = objRow[convgs_TobeStudiedProblem.Year] == DBNull.Value ? null : objRow[convgs_TobeStudiedProblem.Year].ToString().Trim(); //年
objvgs_TobeStudiedProblemEN.Month = objRow[convgs_TobeStudiedProblem.Month] == DBNull.Value ? null : objRow[convgs_TobeStudiedProblem.Month].ToString().Trim(); //月
objvgs_TobeStudiedProblemEN.VersionCount = objRow[convgs_TobeStudiedProblem.VersionCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convgs_TobeStudiedProblem.VersionCount].ToString().Trim()); //版本统计
objvgs_TobeStudiedProblemEN.Participant = objRow[convgs_TobeStudiedProblem.Participant] == DBNull.Value ? null : objRow[convgs_TobeStudiedProblem.Participant].ToString().Trim(); //参与者
objvgs_TobeStudiedProblemEN.Memo = objRow[convgs_TobeStudiedProblem.Memo] == DBNull.Value ? null : objRow[convgs_TobeStudiedProblem.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvgs_TobeStudiedProblemEN.ProblemId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvgs_TobeStudiedProblemEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objvgs_TobeStudiedProblemCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsvgs_TobeStudiedProblemEN> GetSubObjLstCache(clsvgs_TobeStudiedProblemEN objvgs_TobeStudiedProblemCond)
{
List<clsvgs_TobeStudiedProblemEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsvgs_TobeStudiedProblemEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convgs_TobeStudiedProblem.AttributeName)
{
if (objvgs_TobeStudiedProblemCond.IsUpdated(strFldName) == false) continue;
if (objvgs_TobeStudiedProblemCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvgs_TobeStudiedProblemCond[strFldName].ToString());
}
else
{
if (objvgs_TobeStudiedProblemCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvgs_TobeStudiedProblemCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvgs_TobeStudiedProblemCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvgs_TobeStudiedProblemCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvgs_TobeStudiedProblemCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvgs_TobeStudiedProblemCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvgs_TobeStudiedProblemCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvgs_TobeStudiedProblemCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvgs_TobeStudiedProblemCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvgs_TobeStudiedProblemCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvgs_TobeStudiedProblemCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvgs_TobeStudiedProblemCond[strFldName]));
}
}
}
return arrObjLstSel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByTabName)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvgs_TobeStudiedProblemEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsvgs_TobeStudiedProblemEN> arrObjLst = new List<clsvgs_TobeStudiedProblemEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvgs_TobeStudiedProblemEN objvgs_TobeStudiedProblemEN = new clsvgs_TobeStudiedProblemEN();
try
{
objvgs_TobeStudiedProblemEN.ProblemId = objRow[convgs_TobeStudiedProblem.ProblemId].ToString().Trim(); //问题Id
objvgs_TobeStudiedProblemEN.ProblemTitle = objRow[convgs_TobeStudiedProblem.ProblemTitle] == DBNull.Value ? null : objRow[convgs_TobeStudiedProblem.ProblemTitle].ToString().Trim(); //问题标题
objvgs_TobeStudiedProblemEN.ProblemContent = objRow[convgs_TobeStudiedProblem.ProblemContent] == DBNull.Value ? null : objRow[convgs_TobeStudiedProblem.ProblemContent].ToString().Trim(); //问题内容
objvgs_TobeStudiedProblemEN.TopicId = objRow[convgs_TobeStudiedProblem.TopicId] == DBNull.Value ? null : objRow[convgs_TobeStudiedProblem.TopicId].ToString().Trim(); //主题Id
objvgs_TobeStudiedProblemEN.TopicName = objRow[convgs_TobeStudiedProblem.TopicName] == DBNull.Value ? null : objRow[convgs_TobeStudiedProblem.TopicName].ToString().Trim(); //栏目主题
objvgs_TobeStudiedProblemEN.IdCurrEduCls = objRow[convgs_TobeStudiedProblem.IdCurrEduCls] == DBNull.Value ? null : objRow[convgs_TobeStudiedProblem.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvgs_TobeStudiedProblemEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[convgs_TobeStudiedProblem.IsSubmit].ToString().Trim()); //是否提交
objvgs_TobeStudiedProblemEN.ProblemDate = objRow[convgs_TobeStudiedProblem.ProblemDate] == DBNull.Value ? null : objRow[convgs_TobeStudiedProblem.ProblemDate].ToString().Trim(); //问题日期
objvgs_TobeStudiedProblemEN.UpdDate = objRow[convgs_TobeStudiedProblem.UpdDate] == DBNull.Value ? null : objRow[convgs_TobeStudiedProblem.UpdDate].ToString().Trim(); //修改日期
objvgs_TobeStudiedProblemEN.UpdUser = objRow[convgs_TobeStudiedProblem.UpdUser] == DBNull.Value ? null : objRow[convgs_TobeStudiedProblem.UpdUser].ToString().Trim(); //修改人
objvgs_TobeStudiedProblemEN.Year = objRow[convgs_TobeStudiedProblem.Year] == DBNull.Value ? null : objRow[convgs_TobeStudiedProblem.Year].ToString().Trim(); //年
objvgs_TobeStudiedProblemEN.Month = objRow[convgs_TobeStudiedProblem.Month] == DBNull.Value ? null : objRow[convgs_TobeStudiedProblem.Month].ToString().Trim(); //月
objvgs_TobeStudiedProblemEN.VersionCount = objRow[convgs_TobeStudiedProblem.VersionCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convgs_TobeStudiedProblem.VersionCount].ToString().Trim()); //版本统计
objvgs_TobeStudiedProblemEN.Participant = objRow[convgs_TobeStudiedProblem.Participant] == DBNull.Value ? null : objRow[convgs_TobeStudiedProblem.Participant].ToString().Trim(); //参与者
objvgs_TobeStudiedProblemEN.Memo = objRow[convgs_TobeStudiedProblem.Memo] == DBNull.Value ? null : objRow[convgs_TobeStudiedProblem.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvgs_TobeStudiedProblemEN.ProblemId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvgs_TobeStudiedProblemEN);
	}
return arrObjLst;
}
 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByTabName)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <param name = "lstExclude">查询条件中排除的标志列表</param>
 /// <returns>返回对象列表</returns>
public static List<clsvgs_TobeStudiedProblemEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsvgs_TobeStudiedProblemEN> arrObjLst = new List<clsvgs_TobeStudiedProblemEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvgs_TobeStudiedProblemEN objvgs_TobeStudiedProblemEN = new clsvgs_TobeStudiedProblemEN();
try
{
objvgs_TobeStudiedProblemEN.ProblemId = objRow[convgs_TobeStudiedProblem.ProblemId].ToString().Trim(); //问题Id
objvgs_TobeStudiedProblemEN.ProblemTitle = objRow[convgs_TobeStudiedProblem.ProblemTitle] == DBNull.Value ? null : objRow[convgs_TobeStudiedProblem.ProblemTitle].ToString().Trim(); //问题标题
objvgs_TobeStudiedProblemEN.ProblemContent = objRow[convgs_TobeStudiedProblem.ProblemContent] == DBNull.Value ? null : objRow[convgs_TobeStudiedProblem.ProblemContent].ToString().Trim(); //问题内容
objvgs_TobeStudiedProblemEN.TopicId = objRow[convgs_TobeStudiedProblem.TopicId] == DBNull.Value ? null : objRow[convgs_TobeStudiedProblem.TopicId].ToString().Trim(); //主题Id
objvgs_TobeStudiedProblemEN.TopicName = objRow[convgs_TobeStudiedProblem.TopicName] == DBNull.Value ? null : objRow[convgs_TobeStudiedProblem.TopicName].ToString().Trim(); //栏目主题
objvgs_TobeStudiedProblemEN.IdCurrEduCls = objRow[convgs_TobeStudiedProblem.IdCurrEduCls] == DBNull.Value ? null : objRow[convgs_TobeStudiedProblem.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvgs_TobeStudiedProblemEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[convgs_TobeStudiedProblem.IsSubmit].ToString().Trim()); //是否提交
objvgs_TobeStudiedProblemEN.ProblemDate = objRow[convgs_TobeStudiedProblem.ProblemDate] == DBNull.Value ? null : objRow[convgs_TobeStudiedProblem.ProblemDate].ToString().Trim(); //问题日期
objvgs_TobeStudiedProblemEN.UpdDate = objRow[convgs_TobeStudiedProblem.UpdDate] == DBNull.Value ? null : objRow[convgs_TobeStudiedProblem.UpdDate].ToString().Trim(); //修改日期
objvgs_TobeStudiedProblemEN.UpdUser = objRow[convgs_TobeStudiedProblem.UpdUser] == DBNull.Value ? null : objRow[convgs_TobeStudiedProblem.UpdUser].ToString().Trim(); //修改人
objvgs_TobeStudiedProblemEN.Year = objRow[convgs_TobeStudiedProblem.Year] == DBNull.Value ? null : objRow[convgs_TobeStudiedProblem.Year].ToString().Trim(); //年
objvgs_TobeStudiedProblemEN.Month = objRow[convgs_TobeStudiedProblem.Month] == DBNull.Value ? null : objRow[convgs_TobeStudiedProblem.Month].ToString().Trim(); //月
objvgs_TobeStudiedProblemEN.VersionCount = objRow[convgs_TobeStudiedProblem.VersionCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convgs_TobeStudiedProblem.VersionCount].ToString().Trim()); //版本统计
objvgs_TobeStudiedProblemEN.Participant = objRow[convgs_TobeStudiedProblem.Participant] == DBNull.Value ? null : objRow[convgs_TobeStudiedProblem.Participant].ToString().Trim(); //参与者
objvgs_TobeStudiedProblemEN.Memo = objRow[convgs_TobeStudiedProblem.Memo] == DBNull.Value ? null : objRow[convgs_TobeStudiedProblem.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvgs_TobeStudiedProblemEN.ProblemId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvgs_TobeStudiedProblemEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件获取JSON对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetJSONObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static string GetJSONObjLst(string strWhereCond)
{
List<clsvgs_TobeStudiedProblemEN> arrObjLst = GetObjLst(strWhereCond);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}
 /// <summary>
 /// 根据条件获取JSON对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetJSONObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <param name = "lstExclude">查询条件中排除的标志列表</param>
 /// <returns>返回对象列表</returns>
public static string GetJSONObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsvgs_TobeStudiedProblemEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsvgs_TobeStudiedProblemEN> GetTopObjLst(stuTopPara objTopPara)
{
 return GetTopObjLst( objTopPara.topSize, objTopPara.whereCond, objTopPara.orderBy);
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "intTopSize">顶部记录数</param>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvgs_TobeStudiedProblemEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsvgs_TobeStudiedProblemEN> arrObjLst = new List<clsvgs_TobeStudiedProblemEN>(); 
System.Data.DataTable objDT; 
 stuTopPara objTopPara = new stuTopPara()
 {
 topSize = intTopSize,
 whereCond = strWhereCond,
 orderBy = strOrderBy
 };
 objDT = GetDataTable_Top(objTopPara);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvgs_TobeStudiedProblemEN objvgs_TobeStudiedProblemEN = new clsvgs_TobeStudiedProblemEN();
try
{
objvgs_TobeStudiedProblemEN.ProblemId = objRow[convgs_TobeStudiedProblem.ProblemId].ToString().Trim(); //问题Id
objvgs_TobeStudiedProblemEN.ProblemTitle = objRow[convgs_TobeStudiedProblem.ProblemTitle] == DBNull.Value ? null : objRow[convgs_TobeStudiedProblem.ProblemTitle].ToString().Trim(); //问题标题
objvgs_TobeStudiedProblemEN.ProblemContent = objRow[convgs_TobeStudiedProblem.ProblemContent] == DBNull.Value ? null : objRow[convgs_TobeStudiedProblem.ProblemContent].ToString().Trim(); //问题内容
objvgs_TobeStudiedProblemEN.TopicId = objRow[convgs_TobeStudiedProblem.TopicId] == DBNull.Value ? null : objRow[convgs_TobeStudiedProblem.TopicId].ToString().Trim(); //主题Id
objvgs_TobeStudiedProblemEN.TopicName = objRow[convgs_TobeStudiedProblem.TopicName] == DBNull.Value ? null : objRow[convgs_TobeStudiedProblem.TopicName].ToString().Trim(); //栏目主题
objvgs_TobeStudiedProblemEN.IdCurrEduCls = objRow[convgs_TobeStudiedProblem.IdCurrEduCls] == DBNull.Value ? null : objRow[convgs_TobeStudiedProblem.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvgs_TobeStudiedProblemEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[convgs_TobeStudiedProblem.IsSubmit].ToString().Trim()); //是否提交
objvgs_TobeStudiedProblemEN.ProblemDate = objRow[convgs_TobeStudiedProblem.ProblemDate] == DBNull.Value ? null : objRow[convgs_TobeStudiedProblem.ProblemDate].ToString().Trim(); //问题日期
objvgs_TobeStudiedProblemEN.UpdDate = objRow[convgs_TobeStudiedProblem.UpdDate] == DBNull.Value ? null : objRow[convgs_TobeStudiedProblem.UpdDate].ToString().Trim(); //修改日期
objvgs_TobeStudiedProblemEN.UpdUser = objRow[convgs_TobeStudiedProblem.UpdUser] == DBNull.Value ? null : objRow[convgs_TobeStudiedProblem.UpdUser].ToString().Trim(); //修改人
objvgs_TobeStudiedProblemEN.Year = objRow[convgs_TobeStudiedProblem.Year] == DBNull.Value ? null : objRow[convgs_TobeStudiedProblem.Year].ToString().Trim(); //年
objvgs_TobeStudiedProblemEN.Month = objRow[convgs_TobeStudiedProblem.Month] == DBNull.Value ? null : objRow[convgs_TobeStudiedProblem.Month].ToString().Trim(); //月
objvgs_TobeStudiedProblemEN.VersionCount = objRow[convgs_TobeStudiedProblem.VersionCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convgs_TobeStudiedProblem.VersionCount].ToString().Trim()); //版本统计
objvgs_TobeStudiedProblemEN.Participant = objRow[convgs_TobeStudiedProblem.Participant] == DBNull.Value ? null : objRow[convgs_TobeStudiedProblem.Participant].ToString().Trim(); //参与者
objvgs_TobeStudiedProblemEN.Memo = objRow[convgs_TobeStudiedProblem.Memo] == DBNull.Value ? null : objRow[convgs_TobeStudiedProblem.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvgs_TobeStudiedProblemEN.ProblemId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvgs_TobeStudiedProblemEN);
	}
return arrObjLst;
}
 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <param name = "lstExclude">查询条件中排除的标志列表</param>
 /// <returns>返回对象列表</returns>
public static List<clsvgs_TobeStudiedProblemEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsvgs_TobeStudiedProblemEN> arrObjLst = new List<clsvgs_TobeStudiedProblemEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvgs_TobeStudiedProblemEN objvgs_TobeStudiedProblemEN = new clsvgs_TobeStudiedProblemEN();
try
{
objvgs_TobeStudiedProblemEN.ProblemId = objRow[convgs_TobeStudiedProblem.ProblemId].ToString().Trim(); //问题Id
objvgs_TobeStudiedProblemEN.ProblemTitle = objRow[convgs_TobeStudiedProblem.ProblemTitle] == DBNull.Value ? null : objRow[convgs_TobeStudiedProblem.ProblemTitle].ToString().Trim(); //问题标题
objvgs_TobeStudiedProblemEN.ProblemContent = objRow[convgs_TobeStudiedProblem.ProblemContent] == DBNull.Value ? null : objRow[convgs_TobeStudiedProblem.ProblemContent].ToString().Trim(); //问题内容
objvgs_TobeStudiedProblemEN.TopicId = objRow[convgs_TobeStudiedProblem.TopicId] == DBNull.Value ? null : objRow[convgs_TobeStudiedProblem.TopicId].ToString().Trim(); //主题Id
objvgs_TobeStudiedProblemEN.TopicName = objRow[convgs_TobeStudiedProblem.TopicName] == DBNull.Value ? null : objRow[convgs_TobeStudiedProblem.TopicName].ToString().Trim(); //栏目主题
objvgs_TobeStudiedProblemEN.IdCurrEduCls = objRow[convgs_TobeStudiedProblem.IdCurrEduCls] == DBNull.Value ? null : objRow[convgs_TobeStudiedProblem.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvgs_TobeStudiedProblemEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[convgs_TobeStudiedProblem.IsSubmit].ToString().Trim()); //是否提交
objvgs_TobeStudiedProblemEN.ProblemDate = objRow[convgs_TobeStudiedProblem.ProblemDate] == DBNull.Value ? null : objRow[convgs_TobeStudiedProblem.ProblemDate].ToString().Trim(); //问题日期
objvgs_TobeStudiedProblemEN.UpdDate = objRow[convgs_TobeStudiedProblem.UpdDate] == DBNull.Value ? null : objRow[convgs_TobeStudiedProblem.UpdDate].ToString().Trim(); //修改日期
objvgs_TobeStudiedProblemEN.UpdUser = objRow[convgs_TobeStudiedProblem.UpdUser] == DBNull.Value ? null : objRow[convgs_TobeStudiedProblem.UpdUser].ToString().Trim(); //修改人
objvgs_TobeStudiedProblemEN.Year = objRow[convgs_TobeStudiedProblem.Year] == DBNull.Value ? null : objRow[convgs_TobeStudiedProblem.Year].ToString().Trim(); //年
objvgs_TobeStudiedProblemEN.Month = objRow[convgs_TobeStudiedProblem.Month] == DBNull.Value ? null : objRow[convgs_TobeStudiedProblem.Month].ToString().Trim(); //月
objvgs_TobeStudiedProblemEN.VersionCount = objRow[convgs_TobeStudiedProblem.VersionCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convgs_TobeStudiedProblem.VersionCount].ToString().Trim()); //版本统计
objvgs_TobeStudiedProblemEN.Participant = objRow[convgs_TobeStudiedProblem.Participant] == DBNull.Value ? null : objRow[convgs_TobeStudiedProblem.Participant].ToString().Trim(); //参与者
objvgs_TobeStudiedProblemEN.Memo = objRow[convgs_TobeStudiedProblem.Memo] == DBNull.Value ? null : objRow[convgs_TobeStudiedProblem.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvgs_TobeStudiedProblemEN.ProblemId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvgs_TobeStudiedProblemEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsvgs_TobeStudiedProblemEN> GetObjLstByPager(stuPagerPara objPagerPara)
{
 return GetObjLstByPager(objPagerPara.pageIndex, objPagerPara.pageSize, objPagerPara.whereCond, objPagerPara.orderBy);
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "intPageIndex">页序号</param>
 /// <param name = "intPageSize">页记录数</param>
 /// <param name = "strWhereCond">给定条件</param>
 /// <param name = "strOrderBy">排序方式</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsvgs_TobeStudiedProblemEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsvgs_TobeStudiedProblemEN> arrObjLst = new List<clsvgs_TobeStudiedProblemEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvgs_TobeStudiedProblemEN objvgs_TobeStudiedProblemEN = new clsvgs_TobeStudiedProblemEN();
try
{
objvgs_TobeStudiedProblemEN.ProblemId = objRow[convgs_TobeStudiedProblem.ProblemId].ToString().Trim(); //问题Id
objvgs_TobeStudiedProblemEN.ProblemTitle = objRow[convgs_TobeStudiedProblem.ProblemTitle] == DBNull.Value ? null : objRow[convgs_TobeStudiedProblem.ProblemTitle].ToString().Trim(); //问题标题
objvgs_TobeStudiedProblemEN.ProblemContent = objRow[convgs_TobeStudiedProblem.ProblemContent] == DBNull.Value ? null : objRow[convgs_TobeStudiedProblem.ProblemContent].ToString().Trim(); //问题内容
objvgs_TobeStudiedProblemEN.TopicId = objRow[convgs_TobeStudiedProblem.TopicId] == DBNull.Value ? null : objRow[convgs_TobeStudiedProblem.TopicId].ToString().Trim(); //主题Id
objvgs_TobeStudiedProblemEN.TopicName = objRow[convgs_TobeStudiedProblem.TopicName] == DBNull.Value ? null : objRow[convgs_TobeStudiedProblem.TopicName].ToString().Trim(); //栏目主题
objvgs_TobeStudiedProblemEN.IdCurrEduCls = objRow[convgs_TobeStudiedProblem.IdCurrEduCls] == DBNull.Value ? null : objRow[convgs_TobeStudiedProblem.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvgs_TobeStudiedProblemEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[convgs_TobeStudiedProblem.IsSubmit].ToString().Trim()); //是否提交
objvgs_TobeStudiedProblemEN.ProblemDate = objRow[convgs_TobeStudiedProblem.ProblemDate] == DBNull.Value ? null : objRow[convgs_TobeStudiedProblem.ProblemDate].ToString().Trim(); //问题日期
objvgs_TobeStudiedProblemEN.UpdDate = objRow[convgs_TobeStudiedProblem.UpdDate] == DBNull.Value ? null : objRow[convgs_TobeStudiedProblem.UpdDate].ToString().Trim(); //修改日期
objvgs_TobeStudiedProblemEN.UpdUser = objRow[convgs_TobeStudiedProblem.UpdUser] == DBNull.Value ? null : objRow[convgs_TobeStudiedProblem.UpdUser].ToString().Trim(); //修改人
objvgs_TobeStudiedProblemEN.Year = objRow[convgs_TobeStudiedProblem.Year] == DBNull.Value ? null : objRow[convgs_TobeStudiedProblem.Year].ToString().Trim(); //年
objvgs_TobeStudiedProblemEN.Month = objRow[convgs_TobeStudiedProblem.Month] == DBNull.Value ? null : objRow[convgs_TobeStudiedProblem.Month].ToString().Trim(); //月
objvgs_TobeStudiedProblemEN.VersionCount = objRow[convgs_TobeStudiedProblem.VersionCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convgs_TobeStudiedProblem.VersionCount].ToString().Trim()); //版本统计
objvgs_TobeStudiedProblemEN.Participant = objRow[convgs_TobeStudiedProblem.Participant] == DBNull.Value ? null : objRow[convgs_TobeStudiedProblem.Participant].ToString().Trim(); //参与者
objvgs_TobeStudiedProblemEN.Memo = objRow[convgs_TobeStudiedProblem.Memo] == DBNull.Value ? null : objRow[convgs_TobeStudiedProblem.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvgs_TobeStudiedProblemEN.ProblemId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvgs_TobeStudiedProblemEN);
	}
return arrObjLst;
}
 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "intPageIndex">页序号</param>
 /// <param name = "intPageSize">页记录数</param>
 /// <param name = "strWhereCond">给定条件</param>
 /// <param name = "strOrderBy">排序方式</param>
 /// <param name = "lstExclude">查询条件中排除的标志列表</param>
 /// <returns>返回对象列表</returns>
public static List<clsvgs_TobeStudiedProblemEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsvgs_TobeStudiedProblemEN> arrObjLst = new List<clsvgs_TobeStudiedProblemEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvgs_TobeStudiedProblemEN objvgs_TobeStudiedProblemEN = new clsvgs_TobeStudiedProblemEN();
try
{
objvgs_TobeStudiedProblemEN.ProblemId = objRow[convgs_TobeStudiedProblem.ProblemId].ToString().Trim(); //问题Id
objvgs_TobeStudiedProblemEN.ProblemTitle = objRow[convgs_TobeStudiedProblem.ProblemTitle] == DBNull.Value ? null : objRow[convgs_TobeStudiedProblem.ProblemTitle].ToString().Trim(); //问题标题
objvgs_TobeStudiedProblemEN.ProblemContent = objRow[convgs_TobeStudiedProblem.ProblemContent] == DBNull.Value ? null : objRow[convgs_TobeStudiedProblem.ProblemContent].ToString().Trim(); //问题内容
objvgs_TobeStudiedProblemEN.TopicId = objRow[convgs_TobeStudiedProblem.TopicId] == DBNull.Value ? null : objRow[convgs_TobeStudiedProblem.TopicId].ToString().Trim(); //主题Id
objvgs_TobeStudiedProblemEN.TopicName = objRow[convgs_TobeStudiedProblem.TopicName] == DBNull.Value ? null : objRow[convgs_TobeStudiedProblem.TopicName].ToString().Trim(); //栏目主题
objvgs_TobeStudiedProblemEN.IdCurrEduCls = objRow[convgs_TobeStudiedProblem.IdCurrEduCls] == DBNull.Value ? null : objRow[convgs_TobeStudiedProblem.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvgs_TobeStudiedProblemEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[convgs_TobeStudiedProblem.IsSubmit].ToString().Trim()); //是否提交
objvgs_TobeStudiedProblemEN.ProblemDate = objRow[convgs_TobeStudiedProblem.ProblemDate] == DBNull.Value ? null : objRow[convgs_TobeStudiedProblem.ProblemDate].ToString().Trim(); //问题日期
objvgs_TobeStudiedProblemEN.UpdDate = objRow[convgs_TobeStudiedProblem.UpdDate] == DBNull.Value ? null : objRow[convgs_TobeStudiedProblem.UpdDate].ToString().Trim(); //修改日期
objvgs_TobeStudiedProblemEN.UpdUser = objRow[convgs_TobeStudiedProblem.UpdUser] == DBNull.Value ? null : objRow[convgs_TobeStudiedProblem.UpdUser].ToString().Trim(); //修改人
objvgs_TobeStudiedProblemEN.Year = objRow[convgs_TobeStudiedProblem.Year] == DBNull.Value ? null : objRow[convgs_TobeStudiedProblem.Year].ToString().Trim(); //年
objvgs_TobeStudiedProblemEN.Month = objRow[convgs_TobeStudiedProblem.Month] == DBNull.Value ? null : objRow[convgs_TobeStudiedProblem.Month].ToString().Trim(); //月
objvgs_TobeStudiedProblemEN.VersionCount = objRow[convgs_TobeStudiedProblem.VersionCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convgs_TobeStudiedProblem.VersionCount].ToString().Trim()); //版本统计
objvgs_TobeStudiedProblemEN.Participant = objRow[convgs_TobeStudiedProblem.Participant] == DBNull.Value ? null : objRow[convgs_TobeStudiedProblem.Participant].ToString().Trim(); //参与者
objvgs_TobeStudiedProblemEN.Memo = objRow[convgs_TobeStudiedProblem.Memo] == DBNull.Value ? null : objRow[convgs_TobeStudiedProblem.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvgs_TobeStudiedProblemEN.ProblemId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvgs_TobeStudiedProblemEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsvgs_TobeStudiedProblemEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsvgs_TobeStudiedProblemEN> arrObjLst = new List<clsvgs_TobeStudiedProblemEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvgs_TobeStudiedProblemEN objvgs_TobeStudiedProblemEN = new clsvgs_TobeStudiedProblemEN();
try
{
objvgs_TobeStudiedProblemEN.ProblemId = objRow[convgs_TobeStudiedProblem.ProblemId].ToString().Trim(); //问题Id
objvgs_TobeStudiedProblemEN.ProblemTitle = objRow[convgs_TobeStudiedProblem.ProblemTitle] == DBNull.Value ? null : objRow[convgs_TobeStudiedProblem.ProblemTitle].ToString().Trim(); //问题标题
objvgs_TobeStudiedProblemEN.ProblemContent = objRow[convgs_TobeStudiedProblem.ProblemContent] == DBNull.Value ? null : objRow[convgs_TobeStudiedProblem.ProblemContent].ToString().Trim(); //问题内容
objvgs_TobeStudiedProblemEN.TopicId = objRow[convgs_TobeStudiedProblem.TopicId] == DBNull.Value ? null : objRow[convgs_TobeStudiedProblem.TopicId].ToString().Trim(); //主题Id
objvgs_TobeStudiedProblemEN.TopicName = objRow[convgs_TobeStudiedProblem.TopicName] == DBNull.Value ? null : objRow[convgs_TobeStudiedProblem.TopicName].ToString().Trim(); //栏目主题
objvgs_TobeStudiedProblemEN.IdCurrEduCls = objRow[convgs_TobeStudiedProblem.IdCurrEduCls] == DBNull.Value ? null : objRow[convgs_TobeStudiedProblem.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvgs_TobeStudiedProblemEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[convgs_TobeStudiedProblem.IsSubmit].ToString().Trim()); //是否提交
objvgs_TobeStudiedProblemEN.ProblemDate = objRow[convgs_TobeStudiedProblem.ProblemDate] == DBNull.Value ? null : objRow[convgs_TobeStudiedProblem.ProblemDate].ToString().Trim(); //问题日期
objvgs_TobeStudiedProblemEN.UpdDate = objRow[convgs_TobeStudiedProblem.UpdDate] == DBNull.Value ? null : objRow[convgs_TobeStudiedProblem.UpdDate].ToString().Trim(); //修改日期
objvgs_TobeStudiedProblemEN.UpdUser = objRow[convgs_TobeStudiedProblem.UpdUser] == DBNull.Value ? null : objRow[convgs_TobeStudiedProblem.UpdUser].ToString().Trim(); //修改人
objvgs_TobeStudiedProblemEN.Year = objRow[convgs_TobeStudiedProblem.Year] == DBNull.Value ? null : objRow[convgs_TobeStudiedProblem.Year].ToString().Trim(); //年
objvgs_TobeStudiedProblemEN.Month = objRow[convgs_TobeStudiedProblem.Month] == DBNull.Value ? null : objRow[convgs_TobeStudiedProblem.Month].ToString().Trim(); //月
objvgs_TobeStudiedProblemEN.VersionCount = objRow[convgs_TobeStudiedProblem.VersionCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convgs_TobeStudiedProblem.VersionCount].ToString().Trim()); //版本统计
objvgs_TobeStudiedProblemEN.Participant = objRow[convgs_TobeStudiedProblem.Participant] == DBNull.Value ? null : objRow[convgs_TobeStudiedProblem.Participant].ToString().Trim(); //参与者
objvgs_TobeStudiedProblemEN.Memo = objRow[convgs_TobeStudiedProblem.Memo] == DBNull.Value ? null : objRow[convgs_TobeStudiedProblem.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvgs_TobeStudiedProblemEN.ProblemId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvgs_TobeStudiedProblemEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objvgs_TobeStudiedProblemEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool Getvgs_TobeStudiedProblem(ref clsvgs_TobeStudiedProblemEN objvgs_TobeStudiedProblemEN)
{
bool bolResult = vgs_TobeStudiedProblemDA.Getvgs_TobeStudiedProblem(ref objvgs_TobeStudiedProblemEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "strProblemId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvgs_TobeStudiedProblemEN GetObjByProblemId(string strProblemId)
{
if (strProblemId.IndexOf(' ') >=0)
{
var strMsg = string.Format("(errid:Busi000079)在表中,关键字[strProblemId]中不能有空格!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
if (string.IsNullOrEmpty(strProblemId) == true)
{
var strMsg = string.Format("(errid:Busi000020)在表中,关键字[strProblemId]不能为空!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
clsvgs_TobeStudiedProblemEN objvgs_TobeStudiedProblemEN = vgs_TobeStudiedProblemDA.GetObjByProblemId(strProblemId);
return objvgs_TobeStudiedProblemEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsvgs_TobeStudiedProblemEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsvgs_TobeStudiedProblemEN objvgs_TobeStudiedProblemEN = vgs_TobeStudiedProblemDA.GetFirstObj(strWhereCond);
 return objvgs_TobeStudiedProblemEN;
 }
 catch (Exception objException)
 {
var strMsg = string.Format("(errid:Busi000022)获取当前表满足条件的第一条记录数据出错!(strWhereCond = {1}),{2}.(from {0})",
clsStackTrace.GetCurrClassFunction(),
strWhereCond,
objException.Message); 
throw new Exception(strMsg); 
 }
}

 /// <summary>
 /// 把DataRow转换成相关实体对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecValueObjByDataRow_S)
 /// </summary>
 /// <param name = "objRow">给定的DataRow</param>
 /// <returns>返回相关的实体对象</returns>
public static clsvgs_TobeStudiedProblemEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsvgs_TobeStudiedProblemEN objvgs_TobeStudiedProblemEN = vgs_TobeStudiedProblemDA.GetObjByDataRow(objRow);
 return objvgs_TobeStudiedProblemEN;
 }
 catch (Exception objException)
 {
var strMsg = string.Format("(errid:Busi000051)根据DataRow记录获取对象出错, {1}.(from {0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
 }
}
 /// <summary>
 /// 把DataRowView转换成相关实体对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecValueObjByDataRow_S)
 /// </summary>
 /// <param name = "objRow">给定的DataRowView</param>
 /// <returns>返回相关的实体对象</returns>
public static clsvgs_TobeStudiedProblemEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsvgs_TobeStudiedProblemEN objvgs_TobeStudiedProblemEN = vgs_TobeStudiedProblemDA.GetObjByDataRow(objRow);
 return objvgs_TobeStudiedProblemEN;
 }
 catch (Exception objException)
 {
var strMsg = string.Format("(errid:Busi000052)通过DataRowView记录对象出错, {1}.(from {0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
 }
}

 /// <summary>
 /// 根据关键字获取相关对象, 从给定的对象列表中获取.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyFromList)
 /// </summary>
 /// <param name = "strProblemId">所给的关键字</param>
 /// <param name = "lstvgs_TobeStudiedProblemObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvgs_TobeStudiedProblemEN GetObjByProblemIdFromList(string strProblemId, List<clsvgs_TobeStudiedProblemEN> lstvgs_TobeStudiedProblemObjLst)
{
foreach (clsvgs_TobeStudiedProblemEN objvgs_TobeStudiedProblemEN in lstvgs_TobeStudiedProblemObjLst)
{
if (objvgs_TobeStudiedProblemEN.ProblemId == strProblemId)
{
return objvgs_TobeStudiedProblemEN;
}
}
return null;
}


 #endregion 获取一个实体对象


 #region 获取一个关键字值

 /// <summary>
 /// 获取当前表关键字值的最大值,再加1,避免重复
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetMaxStrId_S)
 /// </summary>
 /// <returns>当前表关键字值的最大值,再加1</returns>
public static string GetMaxStrId_S() 
{
 string strMaxProblemId;
 try
 {
 strMaxProblemId = clsvgs_TobeStudiedProblemDA.GetMaxStrId();
 return strMaxProblemId;
 }
 catch (Exception objException)
 {
var strMsg = string.Format("(errid:Busi000024)获取最大关键字值出错, {1}.(from {0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
 }
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的关键字值
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstID_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的关键字值</returns>
public static string GetFirstID_S(string strWhereCond) 
{
 string strProblemId;
 try
 {
 strProblemId = new clsvgs_TobeStudiedProblemDA().GetFirstID(strWhereCond);
 return strProblemId;
 }
 catch (Exception objException)
 {
var strMsg = string.Format("(errid:Busi000023)获取First关键字出错, {1}.(from {0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
 }
}


 #endregion 获取一个关键字值


 #region 获取多个关键字值列表

 /// <summary>
 /// 获取当前表满足条件的关键字值列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetPrimaryKeyID_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回满足条件的关键字列表值</returns>
public static List<string> GetPrimaryKeyID_S(string strWhereCond) 
{
 List<string> arrList;
 try
 {
 arrList = vgs_TobeStudiedProblemDA.GetID(strWhereCond);
 return arrList;
 }
 catch (Exception objException)
 {
var strMsg = string.Format("(errid:Busi000026)获取关键字列表出错, {1}.(from {0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
 }
}


 #endregion 获取多个关键字值列表


 #region 判断记录是否存在

 /// <summary>
 /// 功能:判断是否存在某一条件的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExistRecord)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>如果存在就返回TRUE,否则返回FALSE</returns>
public static bool IsExistRecord(string strWhereCond)
{
//检测记录是否存在
bool bolIsExist = vgs_TobeStudiedProblemDA.IsExistCondRec(strWhereCond);
return bolIsExist;
}

 /// <summary>
 /// 判断当前表中是否存在给定关键字值的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExist)
 /// </summary>
 /// <param name = "strProblemId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public static bool IsExist(string strProblemId)
{
if (string.IsNullOrEmpty(strProblemId) == true)
{
var strMsg = string.Format("(errid:Busi000027)在表中,关键字[strProblemId]不能为空!!(from {0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
//检测记录是否存在
bool bolIsExist = vgs_TobeStudiedProblemDA.IsExist(strProblemId);
return bolIsExist;
}

 /// <summary>
 /// 检查是否存在当前表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExistTable)
 /// </summary>
 /// <returns>存在就返回True,否则返回False</returns>
public static bool IsExistTable() 
{
 bool bolIsExist;
 try
 {
 bolIsExist = clsvgs_TobeStudiedProblemDA.IsExistTable();
 return bolIsExist;
 }
 catch (Exception objException)
 {
var strMsg = string.Format("(errid:Busi000028)检查是否存在当前表(IsExistTable)出错, {1}.(from {0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
 }
}
 /// <summary>
 /// 检查是否存在当前表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExistTable)
 /// </summary>
 /// <param name = "strTabName">给定表</param>
 /// <returns>存在就返回True,否则返回False</returns>
public static bool IsExistTable(string strTabName) 
{
 bool bolIsExist;
 try
 {
 bolIsExist = vgs_TobeStudiedProblemDA.IsExistTable(strTabName);
 return bolIsExist;
 }
 catch (Exception objException)
 {
var strMsg = string.Format("(errid:Busi000029)检查是否存在指定表(IsExistTable)出错, {1}.(from {0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
 }
}


 #endregion 判断记录是否存在


 #region 克隆复制对象

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_CopyObj_S)
 /// </summary>
 /// <param name = "objvgs_TobeStudiedProblemENS">源对象</param>
 /// <param name = "objvgs_TobeStudiedProblemENT">目标对象</param>
 public static void CopyTo(clsvgs_TobeStudiedProblemEN objvgs_TobeStudiedProblemENS, clsvgs_TobeStudiedProblemEN objvgs_TobeStudiedProblemENT)
{
try
{
objvgs_TobeStudiedProblemENT.ProblemId = objvgs_TobeStudiedProblemENS.ProblemId; //问题Id
objvgs_TobeStudiedProblemENT.ProblemTitle = objvgs_TobeStudiedProblemENS.ProblemTitle; //问题标题
objvgs_TobeStudiedProblemENT.ProblemContent = objvgs_TobeStudiedProblemENS.ProblemContent; //问题内容
objvgs_TobeStudiedProblemENT.TopicId = objvgs_TobeStudiedProblemENS.TopicId; //主题Id
objvgs_TobeStudiedProblemENT.TopicName = objvgs_TobeStudiedProblemENS.TopicName; //栏目主题
objvgs_TobeStudiedProblemENT.IdCurrEduCls = objvgs_TobeStudiedProblemENS.IdCurrEduCls; //教学班流水号
objvgs_TobeStudiedProblemENT.IsSubmit = objvgs_TobeStudiedProblemENS.IsSubmit; //是否提交
objvgs_TobeStudiedProblemENT.ProblemDate = objvgs_TobeStudiedProblemENS.ProblemDate; //问题日期
objvgs_TobeStudiedProblemENT.UpdDate = objvgs_TobeStudiedProblemENS.UpdDate; //修改日期
objvgs_TobeStudiedProblemENT.UpdUser = objvgs_TobeStudiedProblemENS.UpdUser; //修改人
objvgs_TobeStudiedProblemENT.Year = objvgs_TobeStudiedProblemENS.Year; //年
objvgs_TobeStudiedProblemENT.Month = objvgs_TobeStudiedProblemENS.Month; //月
objvgs_TobeStudiedProblemENT.VersionCount = objvgs_TobeStudiedProblemENS.VersionCount; //版本统计
objvgs_TobeStudiedProblemENT.Participant = objvgs_TobeStudiedProblemENS.Participant; //参与者
objvgs_TobeStudiedProblemENT.Memo = objvgs_TobeStudiedProblemENS.Memo; //备注
}
catch (Exception objException)
{
var strMsg = string.Format("(errid:Busi000045)Copy表对象数据出错,{1}.({0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
}
}

 /// <summary>
 /// 设置修改标志,即根据字段修改标志字符串获取哪一个字段已经被修改
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_SetUpdFlag_S)
 /// </summary>
 /// <param name = "objvgs_TobeStudiedProblemEN">源简化对象</param>
 public static void SetUpdFlag(clsvgs_TobeStudiedProblemEN objvgs_TobeStudiedProblemEN)
{
try
{
objvgs_TobeStudiedProblemEN.ClearUpdateState();
   string strsfUpdFldSetStr = objvgs_TobeStudiedProblemEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(convgs_TobeStudiedProblem.ProblemId, new clsStrCompareIgnoreCase())  ==  true)
{
objvgs_TobeStudiedProblemEN.ProblemId = objvgs_TobeStudiedProblemEN.ProblemId; //问题Id
}
if (arrFldSet.Contains(convgs_TobeStudiedProblem.ProblemTitle, new clsStrCompareIgnoreCase())  ==  true)
{
objvgs_TobeStudiedProblemEN.ProblemTitle = objvgs_TobeStudiedProblemEN.ProblemTitle == "[null]" ? null :  objvgs_TobeStudiedProblemEN.ProblemTitle; //问题标题
}
if (arrFldSet.Contains(convgs_TobeStudiedProblem.ProblemContent, new clsStrCompareIgnoreCase())  ==  true)
{
objvgs_TobeStudiedProblemEN.ProblemContent = objvgs_TobeStudiedProblemEN.ProblemContent == "[null]" ? null :  objvgs_TobeStudiedProblemEN.ProblemContent; //问题内容
}
if (arrFldSet.Contains(convgs_TobeStudiedProblem.TopicId, new clsStrCompareIgnoreCase())  ==  true)
{
objvgs_TobeStudiedProblemEN.TopicId = objvgs_TobeStudiedProblemEN.TopicId == "[null]" ? null :  objvgs_TobeStudiedProblemEN.TopicId; //主题Id
}
if (arrFldSet.Contains(convgs_TobeStudiedProblem.TopicName, new clsStrCompareIgnoreCase())  ==  true)
{
objvgs_TobeStudiedProblemEN.TopicName = objvgs_TobeStudiedProblemEN.TopicName == "[null]" ? null :  objvgs_TobeStudiedProblemEN.TopicName; //栏目主题
}
if (arrFldSet.Contains(convgs_TobeStudiedProblem.IdCurrEduCls, new clsStrCompareIgnoreCase())  ==  true)
{
objvgs_TobeStudiedProblemEN.IdCurrEduCls = objvgs_TobeStudiedProblemEN.IdCurrEduCls == "[null]" ? null :  objvgs_TobeStudiedProblemEN.IdCurrEduCls; //教学班流水号
}
if (arrFldSet.Contains(convgs_TobeStudiedProblem.IsSubmit, new clsStrCompareIgnoreCase())  ==  true)
{
objvgs_TobeStudiedProblemEN.IsSubmit = objvgs_TobeStudiedProblemEN.IsSubmit; //是否提交
}
if (arrFldSet.Contains(convgs_TobeStudiedProblem.ProblemDate, new clsStrCompareIgnoreCase())  ==  true)
{
objvgs_TobeStudiedProblemEN.ProblemDate = objvgs_TobeStudiedProblemEN.ProblemDate == "[null]" ? null :  objvgs_TobeStudiedProblemEN.ProblemDate; //问题日期
}
if (arrFldSet.Contains(convgs_TobeStudiedProblem.UpdDate, new clsStrCompareIgnoreCase())  ==  true)
{
objvgs_TobeStudiedProblemEN.UpdDate = objvgs_TobeStudiedProblemEN.UpdDate == "[null]" ? null :  objvgs_TobeStudiedProblemEN.UpdDate; //修改日期
}
if (arrFldSet.Contains(convgs_TobeStudiedProblem.UpdUser, new clsStrCompareIgnoreCase())  ==  true)
{
objvgs_TobeStudiedProblemEN.UpdUser = objvgs_TobeStudiedProblemEN.UpdUser == "[null]" ? null :  objvgs_TobeStudiedProblemEN.UpdUser; //修改人
}
if (arrFldSet.Contains(convgs_TobeStudiedProblem.Year, new clsStrCompareIgnoreCase())  ==  true)
{
objvgs_TobeStudiedProblemEN.Year = objvgs_TobeStudiedProblemEN.Year == "[null]" ? null :  objvgs_TobeStudiedProblemEN.Year; //年
}
if (arrFldSet.Contains(convgs_TobeStudiedProblem.Month, new clsStrCompareIgnoreCase())  ==  true)
{
objvgs_TobeStudiedProblemEN.Month = objvgs_TobeStudiedProblemEN.Month == "[null]" ? null :  objvgs_TobeStudiedProblemEN.Month; //月
}
if (arrFldSet.Contains(convgs_TobeStudiedProblem.VersionCount, new clsStrCompareIgnoreCase())  ==  true)
{
objvgs_TobeStudiedProblemEN.VersionCount = objvgs_TobeStudiedProblemEN.VersionCount; //版本统计
}
if (arrFldSet.Contains(convgs_TobeStudiedProblem.Participant, new clsStrCompareIgnoreCase())  ==  true)
{
objvgs_TobeStudiedProblemEN.Participant = objvgs_TobeStudiedProblemEN.Participant == "[null]" ? null :  objvgs_TobeStudiedProblemEN.Participant; //参与者
}
if (arrFldSet.Contains(convgs_TobeStudiedProblem.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objvgs_TobeStudiedProblemEN.Memo = objvgs_TobeStudiedProblemEN.Memo == "[null]" ? null :  objvgs_TobeStudiedProblemEN.Memo; //备注
}
}
catch (Exception objException)
{
var strMsg = string.Format("(errid:001)设置表的修改标志出错,{1}.({0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
}
}

 /// <summary>
 /// 处理从Web端传来的[null]的字段值,在WebApi端设置成null
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_AccessFldValueNull)
 /// </summary>
 /// <param name = "objvgs_TobeStudiedProblemEN">源简化对象</param>
 public static void AccessFldValueNull(clsvgs_TobeStudiedProblemEN objvgs_TobeStudiedProblemEN)
{
try
{
if (objvgs_TobeStudiedProblemEN.ProblemTitle == "[null]") objvgs_TobeStudiedProblemEN.ProblemTitle = null; //问题标题
if (objvgs_TobeStudiedProblemEN.ProblemContent == "[null]") objvgs_TobeStudiedProblemEN.ProblemContent = null; //问题内容
if (objvgs_TobeStudiedProblemEN.TopicId == "[null]") objvgs_TobeStudiedProblemEN.TopicId = null; //主题Id
if (objvgs_TobeStudiedProblemEN.TopicName == "[null]") objvgs_TobeStudiedProblemEN.TopicName = null; //栏目主题
if (objvgs_TobeStudiedProblemEN.IdCurrEduCls == "[null]") objvgs_TobeStudiedProblemEN.IdCurrEduCls = null; //教学班流水号
if (objvgs_TobeStudiedProblemEN.ProblemDate == "[null]") objvgs_TobeStudiedProblemEN.ProblemDate = null; //问题日期
if (objvgs_TobeStudiedProblemEN.UpdDate == "[null]") objvgs_TobeStudiedProblemEN.UpdDate = null; //修改日期
if (objvgs_TobeStudiedProblemEN.UpdUser == "[null]") objvgs_TobeStudiedProblemEN.UpdUser = null; //修改人
if (objvgs_TobeStudiedProblemEN.Year == "[null]") objvgs_TobeStudiedProblemEN.Year = null; //年
if (objvgs_TobeStudiedProblemEN.Month == "[null]") objvgs_TobeStudiedProblemEN.Month = null; //月
if (objvgs_TobeStudiedProblemEN.Participant == "[null]") objvgs_TobeStudiedProblemEN.Participant = null; //参与者
if (objvgs_TobeStudiedProblemEN.Memo == "[null]") objvgs_TobeStudiedProblemEN.Memo = null; //备注
}
catch (Exception objException)
{
var strMsg = string.Format("(errid:002)处理从Web端传来的[null]的字段值出错,{1}.({0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
}
}


 #endregion 克隆复制对象


 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(clsvgs_TobeStudiedProblemEN objvgs_TobeStudiedProblemEN)
{
 vgs_TobeStudiedProblemDA.CheckProperty4Condition(objvgs_TobeStudiedProblemEN);
 }


 #endregion 检查对象属性


 #region 绑定下拉框


 #endregion 绑定下拉框


 #region 缓存操作

 /// <summary>
 /// 初始化列表缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_InitListCache)
 /// </summary>
public static void InitListCache()
{
//检查缓存刷新机制
string strMsg;
if (clsResearchTopicBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsResearchTopicBL没有刷新缓存机制(clsResearchTopicBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsgs_TobeStudiedProblemBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsgs_TobeStudiedProblemBL没有刷新缓存机制(clsgs_TobeStudiedProblemBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by ProblemId");
//if (arrvgs_TobeStudiedProblemObjLstCache == null)
//{
//arrvgs_TobeStudiedProblemObjLstCache = vgs_TobeStudiedProblemDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "strProblemId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvgs_TobeStudiedProblemEN GetObjByProblemIdCache(string strProblemId)
{
//获取缓存中的对象列表
string strKey = string.Format("{0}", clsvgs_TobeStudiedProblemEN._CurrTabName);
List<clsvgs_TobeStudiedProblemEN> arrvgs_TobeStudiedProblemObjLstCache = GetObjLstCache();
IEnumerable <clsvgs_TobeStudiedProblemEN> arrvgs_TobeStudiedProblemObjLst_Sel =
arrvgs_TobeStudiedProblemObjLstCache
.Where(x=> x.ProblemId == strProblemId 
);
if (arrvgs_TobeStudiedProblemObjLst_Sel.Count() == 0)
{
   clsvgs_TobeStudiedProblemEN obj = clsvgs_TobeStudiedProblemBL.GetObjByProblemId(strProblemId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
 }
return null;
}
return arrvgs_TobeStudiedProblemObjLst_Sel.First();
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvgs_TobeStudiedProblemEN> GetAllvgs_TobeStudiedProblemObjLstCache()
{
//获取缓存中的对象列表
List<clsvgs_TobeStudiedProblemEN> arrvgs_TobeStudiedProblemObjLstCache = GetObjLstCache(); 
return arrvgs_TobeStudiedProblemObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvgs_TobeStudiedProblemEN> GetObjLstCache()
{
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}", clsvgs_TobeStudiedProblemEN._CurrTabName);
List<clsvgs_TobeStudiedProblemEN> arrvgs_TobeStudiedProblemObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrvgs_TobeStudiedProblemObjLstCache;
}

 /// <summary>
 /// 刷新本类中的缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ReFreshThisCache)
 /// </summary>
public static void ReFreshThisCache()
{
string strMsg;
if (clsSysParaEN.spSetRefreshCacheOn == true)
{
string strKey = string.Format("{0}", clsvgs_TobeStudiedProblemEN._CurrTabName);
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


 #endregion 缓存操作


 #region 检查唯一性

 /// <summary>
 /// 获取检查唯一性条件串(Uniqueness)--vgs_TobeStudiedProblem(待研究问题视图)
 /// 唯一性条件:ProblemId
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetUniquenessConditionString)
 /// </summary>
 /// <param name = "objvgs_TobeStudiedProblemEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(clsvgs_TobeStudiedProblemEN objvgs_TobeStudiedProblemEN)
{
//检测记录是否存在
string strResult = vgs_TobeStudiedProblemDA.GetUniCondStr(objvgs_TobeStudiedProblemEN);
return strResult;
}


 #endregion 检查唯一性

 /// <summary>
 /// 映射函数。根据表映射把输入字段值,映射成输出字段值
 /// 作者:pyf
 /// 日期:2023-08-24
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_func)
 /// </summary>
 /// <param name = "strInFldName">输入字段名</param>
 /// <param name = "strOutFldName">输出字段名</param>
 /// <param name = "strInValue">输入字段值</param>
 /// <returns>返回一个输出字段值</returns>
public static string Func(string strInFldName, string strOutFldName, string strProblemId)
{
if (strInFldName != convgs_TobeStudiedProblem.ProblemId)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (convgs_TobeStudiedProblem.AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", convgs_TobeStudiedProblem.AttributeName));
throw new Exception(strMsg);
}
var objvgs_TobeStudiedProblem = clsvgs_TobeStudiedProblemBL.GetObjByProblemIdCache(strProblemId);
if (objvgs_TobeStudiedProblem == null) return "";
return objvgs_TobeStudiedProblem[strOutFldName].ToString();
}


 #region 有关JSON操作


 #endregion 有关JSON操作


 #region 表操作常用函数

 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类不相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount_S)
 /// </summary>
 /// <param name = "strTabName">所给定的表名</param>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount(string strTabName)
{
int intRecCount = clsvgs_TobeStudiedProblemDA.GetRecCount(strTabName);
return intRecCount;
}


 /// <summary>
 /// 功能:获取给定表中满足条件的记录数, 该表与当前类不相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCond_S)
 /// </summary>
 /// <param name = "strTabName">所给定的表名</param>
 /// <param name = "strWhereCond">所给定的记录条件</param>
 /// <returns>记录数,为整型</returns>
public static int GetRecCountByCond(string strTabName, string strWhereCond)
{
int intRecCount = clsvgs_TobeStudiedProblemDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsvgs_TobeStudiedProblemDA.GetRecCount();
return intRecCount;
}


 /// <summary>
 /// 功能:获取给定表中满足条件的记录数, 该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCond)
 /// </summary>
 /// <param name = "strWhereCond">所给定的记录条件</param>
 /// <returns>记录数,为整型</returns>
public static int GetRecCountByCond( string strWhereCond)
{
int intRecCount = clsvgs_TobeStudiedProblemDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objvgs_TobeStudiedProblemCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsvgs_TobeStudiedProblemEN objvgs_TobeStudiedProblemCond)
{
List<clsvgs_TobeStudiedProblemEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsvgs_TobeStudiedProblemEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convgs_TobeStudiedProblem.AttributeName)
{
if (objvgs_TobeStudiedProblemCond.IsUpdated(strFldName) == false) continue;
if (objvgs_TobeStudiedProblemCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvgs_TobeStudiedProblemCond[strFldName].ToString());
}
else
{
if (objvgs_TobeStudiedProblemCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvgs_TobeStudiedProblemCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvgs_TobeStudiedProblemCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvgs_TobeStudiedProblemCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvgs_TobeStudiedProblemCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvgs_TobeStudiedProblemCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvgs_TobeStudiedProblemCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvgs_TobeStudiedProblemCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvgs_TobeStudiedProblemCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvgs_TobeStudiedProblemCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvgs_TobeStudiedProblemCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvgs_TobeStudiedProblemCond[strFldName]));
}
}
}
return arrObjLstSel.Count();
}

 /// <summary>
 /// 功能:获取给定表中满足条件的记录数, 该表与当前类不相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFldValue_S)
 /// </summary>
 /// <param name = "strTabName">所给定的表名</param>
 /// <param name = "strFldName">字段名</param>
 /// <param name = "strWhereCond">所给定的记录条件</param>
 /// <returns>记录数,为整型</returns>
public static List<string> GetFldValue(string strTabName, string strFldName, string strWhereCond)
{
 List<string> arrList = clsvgs_TobeStudiedProblemDA.GetFldValue(strTabName, strFldName, strWhereCond);
return arrList;
}


 /// <summary>
 /// 功能:获取给定表中满足条件的记录数, 该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFldValue)
 /// </summary>
 /// <param name = "strFldName">字段名</param>
 /// <param name = "strWhereCond">所给定的记录条件</param>
 /// <returns>记录数,为整型</returns>
public static List<string> GetFldValue(string strFldName, string strWhereCond)
{
 List<string> arrList = vgs_TobeStudiedProblemDA.GetFldValue(strFldName, strWhereCond);
return arrList;
}


 /// <summary>
 /// 功能:获取给定表中满足条件的记录数, 该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFldValueNoDistinct)
 /// </summary>
 /// <param name = "strFldName">字段名</param>
 /// <param name = "strWhereCond">所给定的记录条件</param>
 /// <returns>记录数,为整型</returns>
public static List<string> GetFldValueNoDistinct(string strFldName, string strWhereCond)
{
 List<string> arrList = vgs_TobeStudiedProblemDA.GetFldValueNoDistinct(strFldName, strWhereCond);
return arrList;
}



 #endregion 表操作常用函数
}
}