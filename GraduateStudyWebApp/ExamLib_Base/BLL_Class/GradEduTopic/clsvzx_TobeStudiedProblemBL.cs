
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvzx_TobeStudiedProblemBL
 表名:vzx_TobeStudiedProblem(01120840)
 * 版本:2023.08.23.1(服务器:WIN-SRV103-116)
 日期:2023/08/24 12:14:23
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
public static class  clsvzx_TobeStudiedProblemBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "strProblemId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvzx_TobeStudiedProblemEN GetObj(this K_ProblemId_vzx_TobeStudiedProblem myKey)
{
clsvzx_TobeStudiedProblemEN objvzx_TobeStudiedProblemEN = clsvzx_TobeStudiedProblemBL.vzx_TobeStudiedProblemDA.GetObjByProblemId(myKey.Value);
return objvzx_TobeStudiedProblemEN;
}

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_TobeStudiedProblemEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_TobeStudiedProblemEN SetGroupTextId(this clsvzx_TobeStudiedProblemEN objvzx_TobeStudiedProblemEN, string strGroupTextId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strGroupTextId, 8, convzx_TobeStudiedProblem.GroupTextId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strGroupTextId, 8, convzx_TobeStudiedProblem.GroupTextId);
}
objvzx_TobeStudiedProblemEN.GroupTextId = strGroupTextId; //小组Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_TobeStudiedProblemEN.dicFldComparisonOp.ContainsKey(convzx_TobeStudiedProblem.GroupTextId) == false)
{
objvzx_TobeStudiedProblemEN.dicFldComparisonOp.Add(convzx_TobeStudiedProblem.GroupTextId, strComparisonOp);
}
else
{
objvzx_TobeStudiedProblemEN.dicFldComparisonOp[convzx_TobeStudiedProblem.GroupTextId] = strComparisonOp;
}
}
return objvzx_TobeStudiedProblemEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_TobeStudiedProblemEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_TobeStudiedProblemEN SetGroupTextName(this clsvzx_TobeStudiedProblemEN objvzx_TobeStudiedProblemEN, string strGroupTextName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strGroupTextName, 2000, convzx_TobeStudiedProblem.GroupTextName);
}
objvzx_TobeStudiedProblemEN.GroupTextName = strGroupTextName; //小组名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_TobeStudiedProblemEN.dicFldComparisonOp.ContainsKey(convzx_TobeStudiedProblem.GroupTextName) == false)
{
objvzx_TobeStudiedProblemEN.dicFldComparisonOp.Add(convzx_TobeStudiedProblem.GroupTextName, strComparisonOp);
}
else
{
objvzx_TobeStudiedProblemEN.dicFldComparisonOp[convzx_TobeStudiedProblem.GroupTextName] = strComparisonOp;
}
}
return objvzx_TobeStudiedProblemEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_TobeStudiedProblemEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_TobeStudiedProblemEN SetIdCurrEduCls(this clsvzx_TobeStudiedProblemEN objvzx_TobeStudiedProblemEN, string strIdCurrEduCls, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdCurrEduCls, 8, convzx_TobeStudiedProblem.IdCurrEduCls);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdCurrEduCls, 8, convzx_TobeStudiedProblem.IdCurrEduCls);
}
objvzx_TobeStudiedProblemEN.IdCurrEduCls = strIdCurrEduCls; //教学班流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_TobeStudiedProblemEN.dicFldComparisonOp.ContainsKey(convzx_TobeStudiedProblem.IdCurrEduCls) == false)
{
objvzx_TobeStudiedProblemEN.dicFldComparisonOp.Add(convzx_TobeStudiedProblem.IdCurrEduCls, strComparisonOp);
}
else
{
objvzx_TobeStudiedProblemEN.dicFldComparisonOp[convzx_TobeStudiedProblem.IdCurrEduCls] = strComparisonOp;
}
}
return objvzx_TobeStudiedProblemEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_TobeStudiedProblemEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_TobeStudiedProblemEN SetzxShareId(this clsvzx_TobeStudiedProblemEN objvzx_TobeStudiedProblemEN, string strzxShareId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strzxShareId, 2, convzx_TobeStudiedProblem.zxShareId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strzxShareId, 2, convzx_TobeStudiedProblem.zxShareId);
}
objvzx_TobeStudiedProblemEN.zxShareId = strzxShareId; //分享Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_TobeStudiedProblemEN.dicFldComparisonOp.ContainsKey(convzx_TobeStudiedProblem.zxShareId) == false)
{
objvzx_TobeStudiedProblemEN.dicFldComparisonOp.Add(convzx_TobeStudiedProblem.zxShareId, strComparisonOp);
}
else
{
objvzx_TobeStudiedProblemEN.dicFldComparisonOp[convzx_TobeStudiedProblem.zxShareId] = strComparisonOp;
}
}
return objvzx_TobeStudiedProblemEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_TobeStudiedProblemEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_TobeStudiedProblemEN SetMemo(this clsvzx_TobeStudiedProblemEN objvzx_TobeStudiedProblemEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, convzx_TobeStudiedProblem.Memo);
}
objvzx_TobeStudiedProblemEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_TobeStudiedProblemEN.dicFldComparisonOp.ContainsKey(convzx_TobeStudiedProblem.Memo) == false)
{
objvzx_TobeStudiedProblemEN.dicFldComparisonOp.Add(convzx_TobeStudiedProblem.Memo, strComparisonOp);
}
else
{
objvzx_TobeStudiedProblemEN.dicFldComparisonOp[convzx_TobeStudiedProblem.Memo] = strComparisonOp;
}
}
return objvzx_TobeStudiedProblemEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_TobeStudiedProblemEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_TobeStudiedProblemEN SetParticipant(this clsvzx_TobeStudiedProblemEN objvzx_TobeStudiedProblemEN, string strParticipant, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strParticipant, 500, convzx_TobeStudiedProblem.Participant);
}
objvzx_TobeStudiedProblemEN.Participant = strParticipant; //参与者
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_TobeStudiedProblemEN.dicFldComparisonOp.ContainsKey(convzx_TobeStudiedProblem.Participant) == false)
{
objvzx_TobeStudiedProblemEN.dicFldComparisonOp.Add(convzx_TobeStudiedProblem.Participant, strComparisonOp);
}
else
{
objvzx_TobeStudiedProblemEN.dicFldComparisonOp[convzx_TobeStudiedProblem.Participant] = strComparisonOp;
}
}
return objvzx_TobeStudiedProblemEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_TobeStudiedProblemEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_TobeStudiedProblemEN SetVersionCount(this clsvzx_TobeStudiedProblemEN objvzx_TobeStudiedProblemEN, int? intVersionCount, string strComparisonOp="")
	{
objvzx_TobeStudiedProblemEN.VersionCount = intVersionCount; //版本统计
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_TobeStudiedProblemEN.dicFldComparisonOp.ContainsKey(convzx_TobeStudiedProblem.VersionCount) == false)
{
objvzx_TobeStudiedProblemEN.dicFldComparisonOp.Add(convzx_TobeStudiedProblem.VersionCount, strComparisonOp);
}
else
{
objvzx_TobeStudiedProblemEN.dicFldComparisonOp[convzx_TobeStudiedProblem.VersionCount] = strComparisonOp;
}
}
return objvzx_TobeStudiedProblemEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_TobeStudiedProblemEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_TobeStudiedProblemEN SetIsSubmit(this clsvzx_TobeStudiedProblemEN objvzx_TobeStudiedProblemEN, bool bolIsSubmit, string strComparisonOp="")
	{
objvzx_TobeStudiedProblemEN.IsSubmit = bolIsSubmit; //是否提交
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_TobeStudiedProblemEN.dicFldComparisonOp.ContainsKey(convzx_TobeStudiedProblem.IsSubmit) == false)
{
objvzx_TobeStudiedProblemEN.dicFldComparisonOp.Add(convzx_TobeStudiedProblem.IsSubmit, strComparisonOp);
}
else
{
objvzx_TobeStudiedProblemEN.dicFldComparisonOp[convzx_TobeStudiedProblem.IsSubmit] = strComparisonOp;
}
}
return objvzx_TobeStudiedProblemEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_TobeStudiedProblemEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_TobeStudiedProblemEN SetProblemId(this clsvzx_TobeStudiedProblemEN objvzx_TobeStudiedProblemEN, string strProblemId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strProblemId, 10, convzx_TobeStudiedProblem.ProblemId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strProblemId, 10, convzx_TobeStudiedProblem.ProblemId);
}
objvzx_TobeStudiedProblemEN.ProblemId = strProblemId; //问题Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_TobeStudiedProblemEN.dicFldComparisonOp.ContainsKey(convzx_TobeStudiedProblem.ProblemId) == false)
{
objvzx_TobeStudiedProblemEN.dicFldComparisonOp.Add(convzx_TobeStudiedProblem.ProblemId, strComparisonOp);
}
else
{
objvzx_TobeStudiedProblemEN.dicFldComparisonOp[convzx_TobeStudiedProblem.ProblemId] = strComparisonOp;
}
}
return objvzx_TobeStudiedProblemEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_TobeStudiedProblemEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_TobeStudiedProblemEN SetProblemTitle(this clsvzx_TobeStudiedProblemEN objvzx_TobeStudiedProblemEN, string strProblemTitle, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strProblemTitle, 1000, convzx_TobeStudiedProblem.ProblemTitle);
}
objvzx_TobeStudiedProblemEN.ProblemTitle = strProblemTitle; //问题标题
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_TobeStudiedProblemEN.dicFldComparisonOp.ContainsKey(convzx_TobeStudiedProblem.ProblemTitle) == false)
{
objvzx_TobeStudiedProblemEN.dicFldComparisonOp.Add(convzx_TobeStudiedProblem.ProblemTitle, strComparisonOp);
}
else
{
objvzx_TobeStudiedProblemEN.dicFldComparisonOp[convzx_TobeStudiedProblem.ProblemTitle] = strComparisonOp;
}
}
return objvzx_TobeStudiedProblemEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_TobeStudiedProblemEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_TobeStudiedProblemEN SetProblemContent(this clsvzx_TobeStudiedProblemEN objvzx_TobeStudiedProblemEN, string strProblemContent, string strComparisonOp="")
	{
objvzx_TobeStudiedProblemEN.ProblemContent = strProblemContent; //问题内容
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_TobeStudiedProblemEN.dicFldComparisonOp.ContainsKey(convzx_TobeStudiedProblem.ProblemContent) == false)
{
objvzx_TobeStudiedProblemEN.dicFldComparisonOp.Add(convzx_TobeStudiedProblem.ProblemContent, strComparisonOp);
}
else
{
objvzx_TobeStudiedProblemEN.dicFldComparisonOp[convzx_TobeStudiedProblem.ProblemContent] = strComparisonOp;
}
}
return objvzx_TobeStudiedProblemEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_TobeStudiedProblemEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_TobeStudiedProblemEN SetProblemDate(this clsvzx_TobeStudiedProblemEN objvzx_TobeStudiedProblemEN, string strProblemDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strProblemDate, 20, convzx_TobeStudiedProblem.ProblemDate);
}
objvzx_TobeStudiedProblemEN.ProblemDate = strProblemDate; //问题日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_TobeStudiedProblemEN.dicFldComparisonOp.ContainsKey(convzx_TobeStudiedProblem.ProblemDate) == false)
{
objvzx_TobeStudiedProblemEN.dicFldComparisonOp.Add(convzx_TobeStudiedProblem.ProblemDate, strComparisonOp);
}
else
{
objvzx_TobeStudiedProblemEN.dicFldComparisonOp[convzx_TobeStudiedProblem.ProblemDate] = strComparisonOp;
}
}
return objvzx_TobeStudiedProblemEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_TobeStudiedProblemEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_TobeStudiedProblemEN SetUpdDate(this clsvzx_TobeStudiedProblemEN objvzx_TobeStudiedProblemEN, string strUpdDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdDate, 20, convzx_TobeStudiedProblem.UpdDate);
}
objvzx_TobeStudiedProblemEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_TobeStudiedProblemEN.dicFldComparisonOp.ContainsKey(convzx_TobeStudiedProblem.UpdDate) == false)
{
objvzx_TobeStudiedProblemEN.dicFldComparisonOp.Add(convzx_TobeStudiedProblem.UpdDate, strComparisonOp);
}
else
{
objvzx_TobeStudiedProblemEN.dicFldComparisonOp[convzx_TobeStudiedProblem.UpdDate] = strComparisonOp;
}
}
return objvzx_TobeStudiedProblemEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_TobeStudiedProblemEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_TobeStudiedProblemEN SetUpdUser(this clsvzx_TobeStudiedProblemEN objvzx_TobeStudiedProblemEN, string strUpdUser, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdUser, 20, convzx_TobeStudiedProblem.UpdUser);
}
objvzx_TobeStudiedProblemEN.UpdUser = strUpdUser; //修改人
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_TobeStudiedProblemEN.dicFldComparisonOp.ContainsKey(convzx_TobeStudiedProblem.UpdUser) == false)
{
objvzx_TobeStudiedProblemEN.dicFldComparisonOp.Add(convzx_TobeStudiedProblem.UpdUser, strComparisonOp);
}
else
{
objvzx_TobeStudiedProblemEN.dicFldComparisonOp[convzx_TobeStudiedProblem.UpdUser] = strComparisonOp;
}
}
return objvzx_TobeStudiedProblemEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_TobeStudiedProblemEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_TobeStudiedProblemEN SetYear(this clsvzx_TobeStudiedProblemEN objvzx_TobeStudiedProblemEN, string strYear, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strYear, 4, convzx_TobeStudiedProblem.Year);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strYear, 4, convzx_TobeStudiedProblem.Year);
}
objvzx_TobeStudiedProblemEN.Year = strYear; //年
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_TobeStudiedProblemEN.dicFldComparisonOp.ContainsKey(convzx_TobeStudiedProblem.Year) == false)
{
objvzx_TobeStudiedProblemEN.dicFldComparisonOp.Add(convzx_TobeStudiedProblem.Year, strComparisonOp);
}
else
{
objvzx_TobeStudiedProblemEN.dicFldComparisonOp[convzx_TobeStudiedProblem.Year] = strComparisonOp;
}
}
return objvzx_TobeStudiedProblemEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvzx_TobeStudiedProblemEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvzx_TobeStudiedProblemEN SetMonth(this clsvzx_TobeStudiedProblemEN objvzx_TobeStudiedProblemEN, string strMonth, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMonth, 2, convzx_TobeStudiedProblem.Month);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strMonth, 2, convzx_TobeStudiedProblem.Month);
}
objvzx_TobeStudiedProblemEN.Month = strMonth; //月
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvzx_TobeStudiedProblemEN.dicFldComparisonOp.ContainsKey(convzx_TobeStudiedProblem.Month) == false)
{
objvzx_TobeStudiedProblemEN.dicFldComparisonOp.Add(convzx_TobeStudiedProblem.Month, strComparisonOp);
}
else
{
objvzx_TobeStudiedProblemEN.dicFldComparisonOp[convzx_TobeStudiedProblem.Month] = strComparisonOp;
}
}
return objvzx_TobeStudiedProblemEN;
	}

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CopyObj)
 /// </summary>
 /// <param name = "objvzx_TobeStudiedProblemENS">源对象</param>
 /// <param name = "objvzx_TobeStudiedProblemENT">目标对象</param>
 public static void CopyTo(this clsvzx_TobeStudiedProblemEN objvzx_TobeStudiedProblemENS, clsvzx_TobeStudiedProblemEN objvzx_TobeStudiedProblemENT)
{
try
{
objvzx_TobeStudiedProblemENT.GroupTextId = objvzx_TobeStudiedProblemENS.GroupTextId; //小组Id
objvzx_TobeStudiedProblemENT.GroupTextName = objvzx_TobeStudiedProblemENS.GroupTextName; //小组名称
objvzx_TobeStudiedProblemENT.IdCurrEduCls = objvzx_TobeStudiedProblemENS.IdCurrEduCls; //教学班流水号
objvzx_TobeStudiedProblemENT.zxShareId = objvzx_TobeStudiedProblemENS.zxShareId; //分享Id
objvzx_TobeStudiedProblemENT.Memo = objvzx_TobeStudiedProblemENS.Memo; //备注
objvzx_TobeStudiedProblemENT.Participant = objvzx_TobeStudiedProblemENS.Participant; //参与者
objvzx_TobeStudiedProblemENT.VersionCount = objvzx_TobeStudiedProblemENS.VersionCount; //版本统计
objvzx_TobeStudiedProblemENT.IsSubmit = objvzx_TobeStudiedProblemENS.IsSubmit; //是否提交
objvzx_TobeStudiedProblemENT.ProblemId = objvzx_TobeStudiedProblemENS.ProblemId; //问题Id
objvzx_TobeStudiedProblemENT.ProblemTitle = objvzx_TobeStudiedProblemENS.ProblemTitle; //问题标题
objvzx_TobeStudiedProblemENT.ProblemContent = objvzx_TobeStudiedProblemENS.ProblemContent; //问题内容
objvzx_TobeStudiedProblemENT.ProblemDate = objvzx_TobeStudiedProblemENS.ProblemDate; //问题日期
objvzx_TobeStudiedProblemENT.UpdDate = objvzx_TobeStudiedProblemENS.UpdDate; //修改日期
objvzx_TobeStudiedProblemENT.UpdUser = objvzx_TobeStudiedProblemENS.UpdUser; //修改人
objvzx_TobeStudiedProblemENT.Year = objvzx_TobeStudiedProblemENS.Year; //年
objvzx_TobeStudiedProblemENT.Month = objvzx_TobeStudiedProblemENS.Month; //月
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
 /// <param name = "objvzx_TobeStudiedProblemENS">源对象</param>
 /// <returns>目标对象=>clsvzx_TobeStudiedProblemEN:objvzx_TobeStudiedProblemENT</returns>
 public static clsvzx_TobeStudiedProblemEN CopyTo(this clsvzx_TobeStudiedProblemEN objvzx_TobeStudiedProblemENS)
{
try
{
 clsvzx_TobeStudiedProblemEN objvzx_TobeStudiedProblemENT = new clsvzx_TobeStudiedProblemEN()
{
GroupTextId = objvzx_TobeStudiedProblemENS.GroupTextId, //小组Id
GroupTextName = objvzx_TobeStudiedProblemENS.GroupTextName, //小组名称
IdCurrEduCls = objvzx_TobeStudiedProblemENS.IdCurrEduCls, //教学班流水号
zxShareId = objvzx_TobeStudiedProblemENS.zxShareId, //分享Id
Memo = objvzx_TobeStudiedProblemENS.Memo, //备注
Participant = objvzx_TobeStudiedProblemENS.Participant, //参与者
VersionCount = objvzx_TobeStudiedProblemENS.VersionCount, //版本统计
IsSubmit = objvzx_TobeStudiedProblemENS.IsSubmit, //是否提交
ProblemId = objvzx_TobeStudiedProblemENS.ProblemId, //问题Id
ProblemTitle = objvzx_TobeStudiedProblemENS.ProblemTitle, //问题标题
ProblemContent = objvzx_TobeStudiedProblemENS.ProblemContent, //问题内容
ProblemDate = objvzx_TobeStudiedProblemENS.ProblemDate, //问题日期
UpdDate = objvzx_TobeStudiedProblemENS.UpdDate, //修改日期
UpdUser = objvzx_TobeStudiedProblemENS.UpdUser, //修改人
Year = objvzx_TobeStudiedProblemENS.Year, //年
Month = objvzx_TobeStudiedProblemENS.Month, //月
};
 return objvzx_TobeStudiedProblemENT;
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
public static void CheckProperty4Condition(this clsvzx_TobeStudiedProblemEN objvzx_TobeStudiedProblemEN)
{
 clsvzx_TobeStudiedProblemBL.vzx_TobeStudiedProblemDA.CheckProperty4Condition(objvzx_TobeStudiedProblemEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvzx_TobeStudiedProblemEN objvzx_TobeStudiedProblemCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvzx_TobeStudiedProblemCond.IsUpdated(convzx_TobeStudiedProblem.GroupTextId) == true)
{
string strComparisonOpGroupTextId = objvzx_TobeStudiedProblemCond.dicFldComparisonOp[convzx_TobeStudiedProblem.GroupTextId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convzx_TobeStudiedProblem.GroupTextId, objvzx_TobeStudiedProblemCond.GroupTextId, strComparisonOpGroupTextId);
}
if (objvzx_TobeStudiedProblemCond.IsUpdated(convzx_TobeStudiedProblem.GroupTextName) == true)
{
string strComparisonOpGroupTextName = objvzx_TobeStudiedProblemCond.dicFldComparisonOp[convzx_TobeStudiedProblem.GroupTextName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convzx_TobeStudiedProblem.GroupTextName, objvzx_TobeStudiedProblemCond.GroupTextName, strComparisonOpGroupTextName);
}
if (objvzx_TobeStudiedProblemCond.IsUpdated(convzx_TobeStudiedProblem.IdCurrEduCls) == true)
{
string strComparisonOpIdCurrEduCls = objvzx_TobeStudiedProblemCond.dicFldComparisonOp[convzx_TobeStudiedProblem.IdCurrEduCls];
strWhereCond += string.Format(" And {0} {2} '{1}'", convzx_TobeStudiedProblem.IdCurrEduCls, objvzx_TobeStudiedProblemCond.IdCurrEduCls, strComparisonOpIdCurrEduCls);
}
if (objvzx_TobeStudiedProblemCond.IsUpdated(convzx_TobeStudiedProblem.zxShareId) == true)
{
string strComparisonOpzxShareId = objvzx_TobeStudiedProblemCond.dicFldComparisonOp[convzx_TobeStudiedProblem.zxShareId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convzx_TobeStudiedProblem.zxShareId, objvzx_TobeStudiedProblemCond.zxShareId, strComparisonOpzxShareId);
}
if (objvzx_TobeStudiedProblemCond.IsUpdated(convzx_TobeStudiedProblem.Memo) == true)
{
string strComparisonOpMemo = objvzx_TobeStudiedProblemCond.dicFldComparisonOp[convzx_TobeStudiedProblem.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convzx_TobeStudiedProblem.Memo, objvzx_TobeStudiedProblemCond.Memo, strComparisonOpMemo);
}
if (objvzx_TobeStudiedProblemCond.IsUpdated(convzx_TobeStudiedProblem.Participant) == true)
{
string strComparisonOpParticipant = objvzx_TobeStudiedProblemCond.dicFldComparisonOp[convzx_TobeStudiedProblem.Participant];
strWhereCond += string.Format(" And {0} {2} '{1}'", convzx_TobeStudiedProblem.Participant, objvzx_TobeStudiedProblemCond.Participant, strComparisonOpParticipant);
}
if (objvzx_TobeStudiedProblemCond.IsUpdated(convzx_TobeStudiedProblem.VersionCount) == true)
{
string strComparisonOpVersionCount = objvzx_TobeStudiedProblemCond.dicFldComparisonOp[convzx_TobeStudiedProblem.VersionCount];
strWhereCond += string.Format(" And {0} {2} {1}", convzx_TobeStudiedProblem.VersionCount, objvzx_TobeStudiedProblemCond.VersionCount, strComparisonOpVersionCount);
}
if (objvzx_TobeStudiedProblemCond.IsUpdated(convzx_TobeStudiedProblem.IsSubmit) == true)
{
if (objvzx_TobeStudiedProblemCond.IsSubmit == true)
{
strWhereCond += string.Format(" And {0} = '1'", convzx_TobeStudiedProblem.IsSubmit);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convzx_TobeStudiedProblem.IsSubmit);
}
}
if (objvzx_TobeStudiedProblemCond.IsUpdated(convzx_TobeStudiedProblem.ProblemId) == true)
{
string strComparisonOpProblemId = objvzx_TobeStudiedProblemCond.dicFldComparisonOp[convzx_TobeStudiedProblem.ProblemId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convzx_TobeStudiedProblem.ProblemId, objvzx_TobeStudiedProblemCond.ProblemId, strComparisonOpProblemId);
}
if (objvzx_TobeStudiedProblemCond.IsUpdated(convzx_TobeStudiedProblem.ProblemTitle) == true)
{
string strComparisonOpProblemTitle = objvzx_TobeStudiedProblemCond.dicFldComparisonOp[convzx_TobeStudiedProblem.ProblemTitle];
strWhereCond += string.Format(" And {0} {2} '{1}'", convzx_TobeStudiedProblem.ProblemTitle, objvzx_TobeStudiedProblemCond.ProblemTitle, strComparisonOpProblemTitle);
}
//数据类型string(text)在函数:[AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj]中没有处理!
if (objvzx_TobeStudiedProblemCond.IsUpdated(convzx_TobeStudiedProblem.ProblemDate) == true)
{
string strComparisonOpProblemDate = objvzx_TobeStudiedProblemCond.dicFldComparisonOp[convzx_TobeStudiedProblem.ProblemDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convzx_TobeStudiedProblem.ProblemDate, objvzx_TobeStudiedProblemCond.ProblemDate, strComparisonOpProblemDate);
}
if (objvzx_TobeStudiedProblemCond.IsUpdated(convzx_TobeStudiedProblem.UpdDate) == true)
{
string strComparisonOpUpdDate = objvzx_TobeStudiedProblemCond.dicFldComparisonOp[convzx_TobeStudiedProblem.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convzx_TobeStudiedProblem.UpdDate, objvzx_TobeStudiedProblemCond.UpdDate, strComparisonOpUpdDate);
}
if (objvzx_TobeStudiedProblemCond.IsUpdated(convzx_TobeStudiedProblem.UpdUser) == true)
{
string strComparisonOpUpdUser = objvzx_TobeStudiedProblemCond.dicFldComparisonOp[convzx_TobeStudiedProblem.UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", convzx_TobeStudiedProblem.UpdUser, objvzx_TobeStudiedProblemCond.UpdUser, strComparisonOpUpdUser);
}
if (objvzx_TobeStudiedProblemCond.IsUpdated(convzx_TobeStudiedProblem.Year) == true)
{
string strComparisonOpYear = objvzx_TobeStudiedProblemCond.dicFldComparisonOp[convzx_TobeStudiedProblem.Year];
strWhereCond += string.Format(" And {0} {2} '{1}'", convzx_TobeStudiedProblem.Year, objvzx_TobeStudiedProblemCond.Year, strComparisonOpYear);
}
if (objvzx_TobeStudiedProblemCond.IsUpdated(convzx_TobeStudiedProblem.Month) == true)
{
string strComparisonOpMonth = objvzx_TobeStudiedProblemCond.dicFldComparisonOp[convzx_TobeStudiedProblem.Month];
strWhereCond += string.Format(" And {0} {2} '{1}'", convzx_TobeStudiedProblem.Month, objvzx_TobeStudiedProblemCond.Month, strComparisonOpMonth);
}
 return strWhereCond;
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_vzx_TobeStudiedProblem
{
public virtual bool UpdRelaTabDate(string strProblemId, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// vzx_TobeStudiedProblem(vzx_TobeStudiedProblem)
 /// 数据源类型:视图
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsvzx_TobeStudiedProblemBL
{
public static RelatedActions_vzx_TobeStudiedProblem relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsvzx_TobeStudiedProblemDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsvzx_TobeStudiedProblemDA vzx_TobeStudiedProblemDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsvzx_TobeStudiedProblemDA();
}
return uniqueInstance;
}
}

 /// <summary>
 /// 类的构造函数
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ClassConstructor1)
 /// </summary>
 public clsvzx_TobeStudiedProblemBL()
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
if (string.IsNullOrEmpty(clsvzx_TobeStudiedProblemEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvzx_TobeStudiedProblemEN._ConnectString);
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
public static DataTable GetDataTable_vzx_TobeStudiedProblem(string strWhereCond)
{
DataTable objDT;
try
{
objDT = vzx_TobeStudiedProblemDA.GetDataTable_vzx_TobeStudiedProblem(strWhereCond);
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
objDT = vzx_TobeStudiedProblemDA.GetDataTable(strWhereCond);
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
objDT = vzx_TobeStudiedProblemDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = vzx_TobeStudiedProblemDA.GetDataTable(strWhereCond, strTabName);
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
objDT = vzx_TobeStudiedProblemDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = vzx_TobeStudiedProblemDA.GetDataTable_Top(objTopPara);
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
objDT = vzx_TobeStudiedProblemDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = vzx_TobeStudiedProblemDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = vzx_TobeStudiedProblemDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
public static List<clsvzx_TobeStudiedProblemEN> GetObjLstByProblemIdLst(List<string> arrProblemIdLst)
{
List<clsvzx_TobeStudiedProblemEN> arrObjLst = new List<clsvzx_TobeStudiedProblemEN>(); 
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
	clsvzx_TobeStudiedProblemEN objvzx_TobeStudiedProblemEN = new clsvzx_TobeStudiedProblemEN();
try
{
objvzx_TobeStudiedProblemEN.GroupTextId = objRow[convzx_TobeStudiedProblem.GroupTextId] == DBNull.Value ? null : objRow[convzx_TobeStudiedProblem.GroupTextId].ToString().Trim(); //小组Id
objvzx_TobeStudiedProblemEN.GroupTextName = objRow[convzx_TobeStudiedProblem.GroupTextName] == DBNull.Value ? null : objRow[convzx_TobeStudiedProblem.GroupTextName].ToString().Trim(); //小组名称
objvzx_TobeStudiedProblemEN.IdCurrEduCls = objRow[convzx_TobeStudiedProblem.IdCurrEduCls] == DBNull.Value ? null : objRow[convzx_TobeStudiedProblem.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvzx_TobeStudiedProblemEN.zxShareId = objRow[convzx_TobeStudiedProblem.zxShareId] == DBNull.Value ? null : objRow[convzx_TobeStudiedProblem.zxShareId].ToString().Trim(); //分享Id
objvzx_TobeStudiedProblemEN.Memo = objRow[convzx_TobeStudiedProblem.Memo] == DBNull.Value ? null : objRow[convzx_TobeStudiedProblem.Memo].ToString().Trim(); //备注
objvzx_TobeStudiedProblemEN.Participant = objRow[convzx_TobeStudiedProblem.Participant] == DBNull.Value ? null : objRow[convzx_TobeStudiedProblem.Participant].ToString().Trim(); //参与者
objvzx_TobeStudiedProblemEN.VersionCount = objRow[convzx_TobeStudiedProblem.VersionCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_TobeStudiedProblem.VersionCount].ToString().Trim()); //版本统计
objvzx_TobeStudiedProblemEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[convzx_TobeStudiedProblem.IsSubmit].ToString().Trim()); //是否提交
objvzx_TobeStudiedProblemEN.ProblemId = objRow[convzx_TobeStudiedProblem.ProblemId].ToString().Trim(); //问题Id
objvzx_TobeStudiedProblemEN.ProblemTitle = objRow[convzx_TobeStudiedProblem.ProblemTitle] == DBNull.Value ? null : objRow[convzx_TobeStudiedProblem.ProblemTitle].ToString().Trim(); //问题标题
objvzx_TobeStudiedProblemEN.ProblemContent = objRow[convzx_TobeStudiedProblem.ProblemContent] == DBNull.Value ? null : objRow[convzx_TobeStudiedProblem.ProblemContent].ToString().Trim(); //问题内容
objvzx_TobeStudiedProblemEN.ProblemDate = objRow[convzx_TobeStudiedProblem.ProblemDate] == DBNull.Value ? null : objRow[convzx_TobeStudiedProblem.ProblemDate].ToString().Trim(); //问题日期
objvzx_TobeStudiedProblemEN.UpdDate = objRow[convzx_TobeStudiedProblem.UpdDate] == DBNull.Value ? null : objRow[convzx_TobeStudiedProblem.UpdDate].ToString().Trim(); //修改日期
objvzx_TobeStudiedProblemEN.UpdUser = objRow[convzx_TobeStudiedProblem.UpdUser] == DBNull.Value ? null : objRow[convzx_TobeStudiedProblem.UpdUser].ToString().Trim(); //修改人
objvzx_TobeStudiedProblemEN.Year = objRow[convzx_TobeStudiedProblem.Year] == DBNull.Value ? null : objRow[convzx_TobeStudiedProblem.Year].ToString().Trim(); //年
objvzx_TobeStudiedProblemEN.Month = objRow[convzx_TobeStudiedProblem.Month] == DBNull.Value ? null : objRow[convzx_TobeStudiedProblem.Month].ToString().Trim(); //月
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvzx_TobeStudiedProblemEN.ProblemId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvzx_TobeStudiedProblemEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrProblemIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsvzx_TobeStudiedProblemEN> GetObjLstByProblemIdLstCache(List<string> arrProblemIdLst)
{
string strKey = string.Format("{0}", clsvzx_TobeStudiedProblemEN._CurrTabName);
List<clsvzx_TobeStudiedProblemEN> arrvzx_TobeStudiedProblemObjLstCache = GetObjLstCache();
IEnumerable <clsvzx_TobeStudiedProblemEN> arrvzx_TobeStudiedProblemObjLst_Sel =
arrvzx_TobeStudiedProblemObjLstCache
.Where(x => arrProblemIdLst.Contains(x.ProblemId));
return arrvzx_TobeStudiedProblemObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvzx_TobeStudiedProblemEN> GetObjLst(string strWhereCond)
{
List<clsvzx_TobeStudiedProblemEN> arrObjLst = new List<clsvzx_TobeStudiedProblemEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvzx_TobeStudiedProblemEN objvzx_TobeStudiedProblemEN = new clsvzx_TobeStudiedProblemEN();
try
{
objvzx_TobeStudiedProblemEN.GroupTextId = objRow[convzx_TobeStudiedProblem.GroupTextId] == DBNull.Value ? null : objRow[convzx_TobeStudiedProblem.GroupTextId].ToString().Trim(); //小组Id
objvzx_TobeStudiedProblemEN.GroupTextName = objRow[convzx_TobeStudiedProblem.GroupTextName] == DBNull.Value ? null : objRow[convzx_TobeStudiedProblem.GroupTextName].ToString().Trim(); //小组名称
objvzx_TobeStudiedProblemEN.IdCurrEduCls = objRow[convzx_TobeStudiedProblem.IdCurrEduCls] == DBNull.Value ? null : objRow[convzx_TobeStudiedProblem.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvzx_TobeStudiedProblemEN.zxShareId = objRow[convzx_TobeStudiedProblem.zxShareId] == DBNull.Value ? null : objRow[convzx_TobeStudiedProblem.zxShareId].ToString().Trim(); //分享Id
objvzx_TobeStudiedProblemEN.Memo = objRow[convzx_TobeStudiedProblem.Memo] == DBNull.Value ? null : objRow[convzx_TobeStudiedProblem.Memo].ToString().Trim(); //备注
objvzx_TobeStudiedProblemEN.Participant = objRow[convzx_TobeStudiedProblem.Participant] == DBNull.Value ? null : objRow[convzx_TobeStudiedProblem.Participant].ToString().Trim(); //参与者
objvzx_TobeStudiedProblemEN.VersionCount = objRow[convzx_TobeStudiedProblem.VersionCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_TobeStudiedProblem.VersionCount].ToString().Trim()); //版本统计
objvzx_TobeStudiedProblemEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[convzx_TobeStudiedProblem.IsSubmit].ToString().Trim()); //是否提交
objvzx_TobeStudiedProblemEN.ProblemId = objRow[convzx_TobeStudiedProblem.ProblemId].ToString().Trim(); //问题Id
objvzx_TobeStudiedProblemEN.ProblemTitle = objRow[convzx_TobeStudiedProblem.ProblemTitle] == DBNull.Value ? null : objRow[convzx_TobeStudiedProblem.ProblemTitle].ToString().Trim(); //问题标题
objvzx_TobeStudiedProblemEN.ProblemContent = objRow[convzx_TobeStudiedProblem.ProblemContent] == DBNull.Value ? null : objRow[convzx_TobeStudiedProblem.ProblemContent].ToString().Trim(); //问题内容
objvzx_TobeStudiedProblemEN.ProblemDate = objRow[convzx_TobeStudiedProblem.ProblemDate] == DBNull.Value ? null : objRow[convzx_TobeStudiedProblem.ProblemDate].ToString().Trim(); //问题日期
objvzx_TobeStudiedProblemEN.UpdDate = objRow[convzx_TobeStudiedProblem.UpdDate] == DBNull.Value ? null : objRow[convzx_TobeStudiedProblem.UpdDate].ToString().Trim(); //修改日期
objvzx_TobeStudiedProblemEN.UpdUser = objRow[convzx_TobeStudiedProblem.UpdUser] == DBNull.Value ? null : objRow[convzx_TobeStudiedProblem.UpdUser].ToString().Trim(); //修改人
objvzx_TobeStudiedProblemEN.Year = objRow[convzx_TobeStudiedProblem.Year] == DBNull.Value ? null : objRow[convzx_TobeStudiedProblem.Year].ToString().Trim(); //年
objvzx_TobeStudiedProblemEN.Month = objRow[convzx_TobeStudiedProblem.Month] == DBNull.Value ? null : objRow[convzx_TobeStudiedProblem.Month].ToString().Trim(); //月
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvzx_TobeStudiedProblemEN.ProblemId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvzx_TobeStudiedProblemEN);
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
public static List<clsvzx_TobeStudiedProblemEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsvzx_TobeStudiedProblemEN> arrObjLst = new List<clsvzx_TobeStudiedProblemEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvzx_TobeStudiedProblemEN objvzx_TobeStudiedProblemEN = new clsvzx_TobeStudiedProblemEN();
try
{
objvzx_TobeStudiedProblemEN.GroupTextId = objRow[convzx_TobeStudiedProblem.GroupTextId] == DBNull.Value ? null : objRow[convzx_TobeStudiedProblem.GroupTextId].ToString().Trim(); //小组Id
objvzx_TobeStudiedProblemEN.GroupTextName = objRow[convzx_TobeStudiedProblem.GroupTextName] == DBNull.Value ? null : objRow[convzx_TobeStudiedProblem.GroupTextName].ToString().Trim(); //小组名称
objvzx_TobeStudiedProblemEN.IdCurrEduCls = objRow[convzx_TobeStudiedProblem.IdCurrEduCls] == DBNull.Value ? null : objRow[convzx_TobeStudiedProblem.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvzx_TobeStudiedProblemEN.zxShareId = objRow[convzx_TobeStudiedProblem.zxShareId] == DBNull.Value ? null : objRow[convzx_TobeStudiedProblem.zxShareId].ToString().Trim(); //分享Id
objvzx_TobeStudiedProblemEN.Memo = objRow[convzx_TobeStudiedProblem.Memo] == DBNull.Value ? null : objRow[convzx_TobeStudiedProblem.Memo].ToString().Trim(); //备注
objvzx_TobeStudiedProblemEN.Participant = objRow[convzx_TobeStudiedProblem.Participant] == DBNull.Value ? null : objRow[convzx_TobeStudiedProblem.Participant].ToString().Trim(); //参与者
objvzx_TobeStudiedProblemEN.VersionCount = objRow[convzx_TobeStudiedProblem.VersionCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_TobeStudiedProblem.VersionCount].ToString().Trim()); //版本统计
objvzx_TobeStudiedProblemEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[convzx_TobeStudiedProblem.IsSubmit].ToString().Trim()); //是否提交
objvzx_TobeStudiedProblemEN.ProblemId = objRow[convzx_TobeStudiedProblem.ProblemId].ToString().Trim(); //问题Id
objvzx_TobeStudiedProblemEN.ProblemTitle = objRow[convzx_TobeStudiedProblem.ProblemTitle] == DBNull.Value ? null : objRow[convzx_TobeStudiedProblem.ProblemTitle].ToString().Trim(); //问题标题
objvzx_TobeStudiedProblemEN.ProblemContent = objRow[convzx_TobeStudiedProblem.ProblemContent] == DBNull.Value ? null : objRow[convzx_TobeStudiedProblem.ProblemContent].ToString().Trim(); //问题内容
objvzx_TobeStudiedProblemEN.ProblemDate = objRow[convzx_TobeStudiedProblem.ProblemDate] == DBNull.Value ? null : objRow[convzx_TobeStudiedProblem.ProblemDate].ToString().Trim(); //问题日期
objvzx_TobeStudiedProblemEN.UpdDate = objRow[convzx_TobeStudiedProblem.UpdDate] == DBNull.Value ? null : objRow[convzx_TobeStudiedProblem.UpdDate].ToString().Trim(); //修改日期
objvzx_TobeStudiedProblemEN.UpdUser = objRow[convzx_TobeStudiedProblem.UpdUser] == DBNull.Value ? null : objRow[convzx_TobeStudiedProblem.UpdUser].ToString().Trim(); //修改人
objvzx_TobeStudiedProblemEN.Year = objRow[convzx_TobeStudiedProblem.Year] == DBNull.Value ? null : objRow[convzx_TobeStudiedProblem.Year].ToString().Trim(); //年
objvzx_TobeStudiedProblemEN.Month = objRow[convzx_TobeStudiedProblem.Month] == DBNull.Value ? null : objRow[convzx_TobeStudiedProblem.Month].ToString().Trim(); //月
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvzx_TobeStudiedProblemEN.ProblemId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvzx_TobeStudiedProblemEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objvzx_TobeStudiedProblemCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsvzx_TobeStudiedProblemEN> GetSubObjLstCache(clsvzx_TobeStudiedProblemEN objvzx_TobeStudiedProblemCond)
{
List<clsvzx_TobeStudiedProblemEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsvzx_TobeStudiedProblemEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convzx_TobeStudiedProblem.AttributeName)
{
if (objvzx_TobeStudiedProblemCond.IsUpdated(strFldName) == false) continue;
if (objvzx_TobeStudiedProblemCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvzx_TobeStudiedProblemCond[strFldName].ToString());
}
else
{
if (objvzx_TobeStudiedProblemCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvzx_TobeStudiedProblemCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvzx_TobeStudiedProblemCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvzx_TobeStudiedProblemCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvzx_TobeStudiedProblemCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvzx_TobeStudiedProblemCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvzx_TobeStudiedProblemCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvzx_TobeStudiedProblemCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvzx_TobeStudiedProblemCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvzx_TobeStudiedProblemCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvzx_TobeStudiedProblemCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvzx_TobeStudiedProblemCond[strFldName]));
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
public static List<clsvzx_TobeStudiedProblemEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsvzx_TobeStudiedProblemEN> arrObjLst = new List<clsvzx_TobeStudiedProblemEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvzx_TobeStudiedProblemEN objvzx_TobeStudiedProblemEN = new clsvzx_TobeStudiedProblemEN();
try
{
objvzx_TobeStudiedProblemEN.GroupTextId = objRow[convzx_TobeStudiedProblem.GroupTextId] == DBNull.Value ? null : objRow[convzx_TobeStudiedProblem.GroupTextId].ToString().Trim(); //小组Id
objvzx_TobeStudiedProblemEN.GroupTextName = objRow[convzx_TobeStudiedProblem.GroupTextName] == DBNull.Value ? null : objRow[convzx_TobeStudiedProblem.GroupTextName].ToString().Trim(); //小组名称
objvzx_TobeStudiedProblemEN.IdCurrEduCls = objRow[convzx_TobeStudiedProblem.IdCurrEduCls] == DBNull.Value ? null : objRow[convzx_TobeStudiedProblem.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvzx_TobeStudiedProblemEN.zxShareId = objRow[convzx_TobeStudiedProblem.zxShareId] == DBNull.Value ? null : objRow[convzx_TobeStudiedProblem.zxShareId].ToString().Trim(); //分享Id
objvzx_TobeStudiedProblemEN.Memo = objRow[convzx_TobeStudiedProblem.Memo] == DBNull.Value ? null : objRow[convzx_TobeStudiedProblem.Memo].ToString().Trim(); //备注
objvzx_TobeStudiedProblemEN.Participant = objRow[convzx_TobeStudiedProblem.Participant] == DBNull.Value ? null : objRow[convzx_TobeStudiedProblem.Participant].ToString().Trim(); //参与者
objvzx_TobeStudiedProblemEN.VersionCount = objRow[convzx_TobeStudiedProblem.VersionCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_TobeStudiedProblem.VersionCount].ToString().Trim()); //版本统计
objvzx_TobeStudiedProblemEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[convzx_TobeStudiedProblem.IsSubmit].ToString().Trim()); //是否提交
objvzx_TobeStudiedProblemEN.ProblemId = objRow[convzx_TobeStudiedProblem.ProblemId].ToString().Trim(); //问题Id
objvzx_TobeStudiedProblemEN.ProblemTitle = objRow[convzx_TobeStudiedProblem.ProblemTitle] == DBNull.Value ? null : objRow[convzx_TobeStudiedProblem.ProblemTitle].ToString().Trim(); //问题标题
objvzx_TobeStudiedProblemEN.ProblemContent = objRow[convzx_TobeStudiedProblem.ProblemContent] == DBNull.Value ? null : objRow[convzx_TobeStudiedProblem.ProblemContent].ToString().Trim(); //问题内容
objvzx_TobeStudiedProblemEN.ProblemDate = objRow[convzx_TobeStudiedProblem.ProblemDate] == DBNull.Value ? null : objRow[convzx_TobeStudiedProblem.ProblemDate].ToString().Trim(); //问题日期
objvzx_TobeStudiedProblemEN.UpdDate = objRow[convzx_TobeStudiedProblem.UpdDate] == DBNull.Value ? null : objRow[convzx_TobeStudiedProblem.UpdDate].ToString().Trim(); //修改日期
objvzx_TobeStudiedProblemEN.UpdUser = objRow[convzx_TobeStudiedProblem.UpdUser] == DBNull.Value ? null : objRow[convzx_TobeStudiedProblem.UpdUser].ToString().Trim(); //修改人
objvzx_TobeStudiedProblemEN.Year = objRow[convzx_TobeStudiedProblem.Year] == DBNull.Value ? null : objRow[convzx_TobeStudiedProblem.Year].ToString().Trim(); //年
objvzx_TobeStudiedProblemEN.Month = objRow[convzx_TobeStudiedProblem.Month] == DBNull.Value ? null : objRow[convzx_TobeStudiedProblem.Month].ToString().Trim(); //月
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvzx_TobeStudiedProblemEN.ProblemId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvzx_TobeStudiedProblemEN);
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
public static List<clsvzx_TobeStudiedProblemEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsvzx_TobeStudiedProblemEN> arrObjLst = new List<clsvzx_TobeStudiedProblemEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvzx_TobeStudiedProblemEN objvzx_TobeStudiedProblemEN = new clsvzx_TobeStudiedProblemEN();
try
{
objvzx_TobeStudiedProblemEN.GroupTextId = objRow[convzx_TobeStudiedProblem.GroupTextId] == DBNull.Value ? null : objRow[convzx_TobeStudiedProblem.GroupTextId].ToString().Trim(); //小组Id
objvzx_TobeStudiedProblemEN.GroupTextName = objRow[convzx_TobeStudiedProblem.GroupTextName] == DBNull.Value ? null : objRow[convzx_TobeStudiedProblem.GroupTextName].ToString().Trim(); //小组名称
objvzx_TobeStudiedProblemEN.IdCurrEduCls = objRow[convzx_TobeStudiedProblem.IdCurrEduCls] == DBNull.Value ? null : objRow[convzx_TobeStudiedProblem.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvzx_TobeStudiedProblemEN.zxShareId = objRow[convzx_TobeStudiedProblem.zxShareId] == DBNull.Value ? null : objRow[convzx_TobeStudiedProblem.zxShareId].ToString().Trim(); //分享Id
objvzx_TobeStudiedProblemEN.Memo = objRow[convzx_TobeStudiedProblem.Memo] == DBNull.Value ? null : objRow[convzx_TobeStudiedProblem.Memo].ToString().Trim(); //备注
objvzx_TobeStudiedProblemEN.Participant = objRow[convzx_TobeStudiedProblem.Participant] == DBNull.Value ? null : objRow[convzx_TobeStudiedProblem.Participant].ToString().Trim(); //参与者
objvzx_TobeStudiedProblemEN.VersionCount = objRow[convzx_TobeStudiedProblem.VersionCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_TobeStudiedProblem.VersionCount].ToString().Trim()); //版本统计
objvzx_TobeStudiedProblemEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[convzx_TobeStudiedProblem.IsSubmit].ToString().Trim()); //是否提交
objvzx_TobeStudiedProblemEN.ProblemId = objRow[convzx_TobeStudiedProblem.ProblemId].ToString().Trim(); //问题Id
objvzx_TobeStudiedProblemEN.ProblemTitle = objRow[convzx_TobeStudiedProblem.ProblemTitle] == DBNull.Value ? null : objRow[convzx_TobeStudiedProblem.ProblemTitle].ToString().Trim(); //问题标题
objvzx_TobeStudiedProblemEN.ProblemContent = objRow[convzx_TobeStudiedProblem.ProblemContent] == DBNull.Value ? null : objRow[convzx_TobeStudiedProblem.ProblemContent].ToString().Trim(); //问题内容
objvzx_TobeStudiedProblemEN.ProblemDate = objRow[convzx_TobeStudiedProblem.ProblemDate] == DBNull.Value ? null : objRow[convzx_TobeStudiedProblem.ProblemDate].ToString().Trim(); //问题日期
objvzx_TobeStudiedProblemEN.UpdDate = objRow[convzx_TobeStudiedProblem.UpdDate] == DBNull.Value ? null : objRow[convzx_TobeStudiedProblem.UpdDate].ToString().Trim(); //修改日期
objvzx_TobeStudiedProblemEN.UpdUser = objRow[convzx_TobeStudiedProblem.UpdUser] == DBNull.Value ? null : objRow[convzx_TobeStudiedProblem.UpdUser].ToString().Trim(); //修改人
objvzx_TobeStudiedProblemEN.Year = objRow[convzx_TobeStudiedProblem.Year] == DBNull.Value ? null : objRow[convzx_TobeStudiedProblem.Year].ToString().Trim(); //年
objvzx_TobeStudiedProblemEN.Month = objRow[convzx_TobeStudiedProblem.Month] == DBNull.Value ? null : objRow[convzx_TobeStudiedProblem.Month].ToString().Trim(); //月
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvzx_TobeStudiedProblemEN.ProblemId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvzx_TobeStudiedProblemEN);
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
List<clsvzx_TobeStudiedProblemEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsvzx_TobeStudiedProblemEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsvzx_TobeStudiedProblemEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsvzx_TobeStudiedProblemEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsvzx_TobeStudiedProblemEN> arrObjLst = new List<clsvzx_TobeStudiedProblemEN>(); 
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
	clsvzx_TobeStudiedProblemEN objvzx_TobeStudiedProblemEN = new clsvzx_TobeStudiedProblemEN();
try
{
objvzx_TobeStudiedProblemEN.GroupTextId = objRow[convzx_TobeStudiedProblem.GroupTextId] == DBNull.Value ? null : objRow[convzx_TobeStudiedProblem.GroupTextId].ToString().Trim(); //小组Id
objvzx_TobeStudiedProblemEN.GroupTextName = objRow[convzx_TobeStudiedProblem.GroupTextName] == DBNull.Value ? null : objRow[convzx_TobeStudiedProblem.GroupTextName].ToString().Trim(); //小组名称
objvzx_TobeStudiedProblemEN.IdCurrEduCls = objRow[convzx_TobeStudiedProblem.IdCurrEduCls] == DBNull.Value ? null : objRow[convzx_TobeStudiedProblem.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvzx_TobeStudiedProblemEN.zxShareId = objRow[convzx_TobeStudiedProblem.zxShareId] == DBNull.Value ? null : objRow[convzx_TobeStudiedProblem.zxShareId].ToString().Trim(); //分享Id
objvzx_TobeStudiedProblemEN.Memo = objRow[convzx_TobeStudiedProblem.Memo] == DBNull.Value ? null : objRow[convzx_TobeStudiedProblem.Memo].ToString().Trim(); //备注
objvzx_TobeStudiedProblemEN.Participant = objRow[convzx_TobeStudiedProblem.Participant] == DBNull.Value ? null : objRow[convzx_TobeStudiedProblem.Participant].ToString().Trim(); //参与者
objvzx_TobeStudiedProblemEN.VersionCount = objRow[convzx_TobeStudiedProblem.VersionCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_TobeStudiedProblem.VersionCount].ToString().Trim()); //版本统计
objvzx_TobeStudiedProblemEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[convzx_TobeStudiedProblem.IsSubmit].ToString().Trim()); //是否提交
objvzx_TobeStudiedProblemEN.ProblemId = objRow[convzx_TobeStudiedProblem.ProblemId].ToString().Trim(); //问题Id
objvzx_TobeStudiedProblemEN.ProblemTitle = objRow[convzx_TobeStudiedProblem.ProblemTitle] == DBNull.Value ? null : objRow[convzx_TobeStudiedProblem.ProblemTitle].ToString().Trim(); //问题标题
objvzx_TobeStudiedProblemEN.ProblemContent = objRow[convzx_TobeStudiedProblem.ProblemContent] == DBNull.Value ? null : objRow[convzx_TobeStudiedProblem.ProblemContent].ToString().Trim(); //问题内容
objvzx_TobeStudiedProblemEN.ProblemDate = objRow[convzx_TobeStudiedProblem.ProblemDate] == DBNull.Value ? null : objRow[convzx_TobeStudiedProblem.ProblemDate].ToString().Trim(); //问题日期
objvzx_TobeStudiedProblemEN.UpdDate = objRow[convzx_TobeStudiedProblem.UpdDate] == DBNull.Value ? null : objRow[convzx_TobeStudiedProblem.UpdDate].ToString().Trim(); //修改日期
objvzx_TobeStudiedProblemEN.UpdUser = objRow[convzx_TobeStudiedProblem.UpdUser] == DBNull.Value ? null : objRow[convzx_TobeStudiedProblem.UpdUser].ToString().Trim(); //修改人
objvzx_TobeStudiedProblemEN.Year = objRow[convzx_TobeStudiedProblem.Year] == DBNull.Value ? null : objRow[convzx_TobeStudiedProblem.Year].ToString().Trim(); //年
objvzx_TobeStudiedProblemEN.Month = objRow[convzx_TobeStudiedProblem.Month] == DBNull.Value ? null : objRow[convzx_TobeStudiedProblem.Month].ToString().Trim(); //月
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvzx_TobeStudiedProblemEN.ProblemId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvzx_TobeStudiedProblemEN);
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
public static List<clsvzx_TobeStudiedProblemEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsvzx_TobeStudiedProblemEN> arrObjLst = new List<clsvzx_TobeStudiedProblemEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvzx_TobeStudiedProblemEN objvzx_TobeStudiedProblemEN = new clsvzx_TobeStudiedProblemEN();
try
{
objvzx_TobeStudiedProblemEN.GroupTextId = objRow[convzx_TobeStudiedProblem.GroupTextId] == DBNull.Value ? null : objRow[convzx_TobeStudiedProblem.GroupTextId].ToString().Trim(); //小组Id
objvzx_TobeStudiedProblemEN.GroupTextName = objRow[convzx_TobeStudiedProblem.GroupTextName] == DBNull.Value ? null : objRow[convzx_TobeStudiedProblem.GroupTextName].ToString().Trim(); //小组名称
objvzx_TobeStudiedProblemEN.IdCurrEduCls = objRow[convzx_TobeStudiedProblem.IdCurrEduCls] == DBNull.Value ? null : objRow[convzx_TobeStudiedProblem.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvzx_TobeStudiedProblemEN.zxShareId = objRow[convzx_TobeStudiedProblem.zxShareId] == DBNull.Value ? null : objRow[convzx_TobeStudiedProblem.zxShareId].ToString().Trim(); //分享Id
objvzx_TobeStudiedProblemEN.Memo = objRow[convzx_TobeStudiedProblem.Memo] == DBNull.Value ? null : objRow[convzx_TobeStudiedProblem.Memo].ToString().Trim(); //备注
objvzx_TobeStudiedProblemEN.Participant = objRow[convzx_TobeStudiedProblem.Participant] == DBNull.Value ? null : objRow[convzx_TobeStudiedProblem.Participant].ToString().Trim(); //参与者
objvzx_TobeStudiedProblemEN.VersionCount = objRow[convzx_TobeStudiedProblem.VersionCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_TobeStudiedProblem.VersionCount].ToString().Trim()); //版本统计
objvzx_TobeStudiedProblemEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[convzx_TobeStudiedProblem.IsSubmit].ToString().Trim()); //是否提交
objvzx_TobeStudiedProblemEN.ProblemId = objRow[convzx_TobeStudiedProblem.ProblemId].ToString().Trim(); //问题Id
objvzx_TobeStudiedProblemEN.ProblemTitle = objRow[convzx_TobeStudiedProblem.ProblemTitle] == DBNull.Value ? null : objRow[convzx_TobeStudiedProblem.ProblemTitle].ToString().Trim(); //问题标题
objvzx_TobeStudiedProblemEN.ProblemContent = objRow[convzx_TobeStudiedProblem.ProblemContent] == DBNull.Value ? null : objRow[convzx_TobeStudiedProblem.ProblemContent].ToString().Trim(); //问题内容
objvzx_TobeStudiedProblemEN.ProblemDate = objRow[convzx_TobeStudiedProblem.ProblemDate] == DBNull.Value ? null : objRow[convzx_TobeStudiedProblem.ProblemDate].ToString().Trim(); //问题日期
objvzx_TobeStudiedProblemEN.UpdDate = objRow[convzx_TobeStudiedProblem.UpdDate] == DBNull.Value ? null : objRow[convzx_TobeStudiedProblem.UpdDate].ToString().Trim(); //修改日期
objvzx_TobeStudiedProblemEN.UpdUser = objRow[convzx_TobeStudiedProblem.UpdUser] == DBNull.Value ? null : objRow[convzx_TobeStudiedProblem.UpdUser].ToString().Trim(); //修改人
objvzx_TobeStudiedProblemEN.Year = objRow[convzx_TobeStudiedProblem.Year] == DBNull.Value ? null : objRow[convzx_TobeStudiedProblem.Year].ToString().Trim(); //年
objvzx_TobeStudiedProblemEN.Month = objRow[convzx_TobeStudiedProblem.Month] == DBNull.Value ? null : objRow[convzx_TobeStudiedProblem.Month].ToString().Trim(); //月
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvzx_TobeStudiedProblemEN.ProblemId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvzx_TobeStudiedProblemEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsvzx_TobeStudiedProblemEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsvzx_TobeStudiedProblemEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsvzx_TobeStudiedProblemEN> arrObjLst = new List<clsvzx_TobeStudiedProblemEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvzx_TobeStudiedProblemEN objvzx_TobeStudiedProblemEN = new clsvzx_TobeStudiedProblemEN();
try
{
objvzx_TobeStudiedProblemEN.GroupTextId = objRow[convzx_TobeStudiedProblem.GroupTextId] == DBNull.Value ? null : objRow[convzx_TobeStudiedProblem.GroupTextId].ToString().Trim(); //小组Id
objvzx_TobeStudiedProblemEN.GroupTextName = objRow[convzx_TobeStudiedProblem.GroupTextName] == DBNull.Value ? null : objRow[convzx_TobeStudiedProblem.GroupTextName].ToString().Trim(); //小组名称
objvzx_TobeStudiedProblemEN.IdCurrEduCls = objRow[convzx_TobeStudiedProblem.IdCurrEduCls] == DBNull.Value ? null : objRow[convzx_TobeStudiedProblem.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvzx_TobeStudiedProblemEN.zxShareId = objRow[convzx_TobeStudiedProblem.zxShareId] == DBNull.Value ? null : objRow[convzx_TobeStudiedProblem.zxShareId].ToString().Trim(); //分享Id
objvzx_TobeStudiedProblemEN.Memo = objRow[convzx_TobeStudiedProblem.Memo] == DBNull.Value ? null : objRow[convzx_TobeStudiedProblem.Memo].ToString().Trim(); //备注
objvzx_TobeStudiedProblemEN.Participant = objRow[convzx_TobeStudiedProblem.Participant] == DBNull.Value ? null : objRow[convzx_TobeStudiedProblem.Participant].ToString().Trim(); //参与者
objvzx_TobeStudiedProblemEN.VersionCount = objRow[convzx_TobeStudiedProblem.VersionCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_TobeStudiedProblem.VersionCount].ToString().Trim()); //版本统计
objvzx_TobeStudiedProblemEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[convzx_TobeStudiedProblem.IsSubmit].ToString().Trim()); //是否提交
objvzx_TobeStudiedProblemEN.ProblemId = objRow[convzx_TobeStudiedProblem.ProblemId].ToString().Trim(); //问题Id
objvzx_TobeStudiedProblemEN.ProblemTitle = objRow[convzx_TobeStudiedProblem.ProblemTitle] == DBNull.Value ? null : objRow[convzx_TobeStudiedProblem.ProblemTitle].ToString().Trim(); //问题标题
objvzx_TobeStudiedProblemEN.ProblemContent = objRow[convzx_TobeStudiedProblem.ProblemContent] == DBNull.Value ? null : objRow[convzx_TobeStudiedProblem.ProblemContent].ToString().Trim(); //问题内容
objvzx_TobeStudiedProblemEN.ProblemDate = objRow[convzx_TobeStudiedProblem.ProblemDate] == DBNull.Value ? null : objRow[convzx_TobeStudiedProblem.ProblemDate].ToString().Trim(); //问题日期
objvzx_TobeStudiedProblemEN.UpdDate = objRow[convzx_TobeStudiedProblem.UpdDate] == DBNull.Value ? null : objRow[convzx_TobeStudiedProblem.UpdDate].ToString().Trim(); //修改日期
objvzx_TobeStudiedProblemEN.UpdUser = objRow[convzx_TobeStudiedProblem.UpdUser] == DBNull.Value ? null : objRow[convzx_TobeStudiedProblem.UpdUser].ToString().Trim(); //修改人
objvzx_TobeStudiedProblemEN.Year = objRow[convzx_TobeStudiedProblem.Year] == DBNull.Value ? null : objRow[convzx_TobeStudiedProblem.Year].ToString().Trim(); //年
objvzx_TobeStudiedProblemEN.Month = objRow[convzx_TobeStudiedProblem.Month] == DBNull.Value ? null : objRow[convzx_TobeStudiedProblem.Month].ToString().Trim(); //月
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvzx_TobeStudiedProblemEN.ProblemId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvzx_TobeStudiedProblemEN);
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
public static List<clsvzx_TobeStudiedProblemEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsvzx_TobeStudiedProblemEN> arrObjLst = new List<clsvzx_TobeStudiedProblemEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvzx_TobeStudiedProblemEN objvzx_TobeStudiedProblemEN = new clsvzx_TobeStudiedProblemEN();
try
{
objvzx_TobeStudiedProblemEN.GroupTextId = objRow[convzx_TobeStudiedProblem.GroupTextId] == DBNull.Value ? null : objRow[convzx_TobeStudiedProblem.GroupTextId].ToString().Trim(); //小组Id
objvzx_TobeStudiedProblemEN.GroupTextName = objRow[convzx_TobeStudiedProblem.GroupTextName] == DBNull.Value ? null : objRow[convzx_TobeStudiedProblem.GroupTextName].ToString().Trim(); //小组名称
objvzx_TobeStudiedProblemEN.IdCurrEduCls = objRow[convzx_TobeStudiedProblem.IdCurrEduCls] == DBNull.Value ? null : objRow[convzx_TobeStudiedProblem.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvzx_TobeStudiedProblemEN.zxShareId = objRow[convzx_TobeStudiedProblem.zxShareId] == DBNull.Value ? null : objRow[convzx_TobeStudiedProblem.zxShareId].ToString().Trim(); //分享Id
objvzx_TobeStudiedProblemEN.Memo = objRow[convzx_TobeStudiedProblem.Memo] == DBNull.Value ? null : objRow[convzx_TobeStudiedProblem.Memo].ToString().Trim(); //备注
objvzx_TobeStudiedProblemEN.Participant = objRow[convzx_TobeStudiedProblem.Participant] == DBNull.Value ? null : objRow[convzx_TobeStudiedProblem.Participant].ToString().Trim(); //参与者
objvzx_TobeStudiedProblemEN.VersionCount = objRow[convzx_TobeStudiedProblem.VersionCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_TobeStudiedProblem.VersionCount].ToString().Trim()); //版本统计
objvzx_TobeStudiedProblemEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[convzx_TobeStudiedProblem.IsSubmit].ToString().Trim()); //是否提交
objvzx_TobeStudiedProblemEN.ProblemId = objRow[convzx_TobeStudiedProblem.ProblemId].ToString().Trim(); //问题Id
objvzx_TobeStudiedProblemEN.ProblemTitle = objRow[convzx_TobeStudiedProblem.ProblemTitle] == DBNull.Value ? null : objRow[convzx_TobeStudiedProblem.ProblemTitle].ToString().Trim(); //问题标题
objvzx_TobeStudiedProblemEN.ProblemContent = objRow[convzx_TobeStudiedProblem.ProblemContent] == DBNull.Value ? null : objRow[convzx_TobeStudiedProblem.ProblemContent].ToString().Trim(); //问题内容
objvzx_TobeStudiedProblemEN.ProblemDate = objRow[convzx_TobeStudiedProblem.ProblemDate] == DBNull.Value ? null : objRow[convzx_TobeStudiedProblem.ProblemDate].ToString().Trim(); //问题日期
objvzx_TobeStudiedProblemEN.UpdDate = objRow[convzx_TobeStudiedProblem.UpdDate] == DBNull.Value ? null : objRow[convzx_TobeStudiedProblem.UpdDate].ToString().Trim(); //修改日期
objvzx_TobeStudiedProblemEN.UpdUser = objRow[convzx_TobeStudiedProblem.UpdUser] == DBNull.Value ? null : objRow[convzx_TobeStudiedProblem.UpdUser].ToString().Trim(); //修改人
objvzx_TobeStudiedProblemEN.Year = objRow[convzx_TobeStudiedProblem.Year] == DBNull.Value ? null : objRow[convzx_TobeStudiedProblem.Year].ToString().Trim(); //年
objvzx_TobeStudiedProblemEN.Month = objRow[convzx_TobeStudiedProblem.Month] == DBNull.Value ? null : objRow[convzx_TobeStudiedProblem.Month].ToString().Trim(); //月
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvzx_TobeStudiedProblemEN.ProblemId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvzx_TobeStudiedProblemEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsvzx_TobeStudiedProblemEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsvzx_TobeStudiedProblemEN> arrObjLst = new List<clsvzx_TobeStudiedProblemEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvzx_TobeStudiedProblemEN objvzx_TobeStudiedProblemEN = new clsvzx_TobeStudiedProblemEN();
try
{
objvzx_TobeStudiedProblemEN.GroupTextId = objRow[convzx_TobeStudiedProblem.GroupTextId] == DBNull.Value ? null : objRow[convzx_TobeStudiedProblem.GroupTextId].ToString().Trim(); //小组Id
objvzx_TobeStudiedProblemEN.GroupTextName = objRow[convzx_TobeStudiedProblem.GroupTextName] == DBNull.Value ? null : objRow[convzx_TobeStudiedProblem.GroupTextName].ToString().Trim(); //小组名称
objvzx_TobeStudiedProblemEN.IdCurrEduCls = objRow[convzx_TobeStudiedProblem.IdCurrEduCls] == DBNull.Value ? null : objRow[convzx_TobeStudiedProblem.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvzx_TobeStudiedProblemEN.zxShareId = objRow[convzx_TobeStudiedProblem.zxShareId] == DBNull.Value ? null : objRow[convzx_TobeStudiedProblem.zxShareId].ToString().Trim(); //分享Id
objvzx_TobeStudiedProblemEN.Memo = objRow[convzx_TobeStudiedProblem.Memo] == DBNull.Value ? null : objRow[convzx_TobeStudiedProblem.Memo].ToString().Trim(); //备注
objvzx_TobeStudiedProblemEN.Participant = objRow[convzx_TobeStudiedProblem.Participant] == DBNull.Value ? null : objRow[convzx_TobeStudiedProblem.Participant].ToString().Trim(); //参与者
objvzx_TobeStudiedProblemEN.VersionCount = objRow[convzx_TobeStudiedProblem.VersionCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_TobeStudiedProblem.VersionCount].ToString().Trim()); //版本统计
objvzx_TobeStudiedProblemEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[convzx_TobeStudiedProblem.IsSubmit].ToString().Trim()); //是否提交
objvzx_TobeStudiedProblemEN.ProblemId = objRow[convzx_TobeStudiedProblem.ProblemId].ToString().Trim(); //问题Id
objvzx_TobeStudiedProblemEN.ProblemTitle = objRow[convzx_TobeStudiedProblem.ProblemTitle] == DBNull.Value ? null : objRow[convzx_TobeStudiedProblem.ProblemTitle].ToString().Trim(); //问题标题
objvzx_TobeStudiedProblemEN.ProblemContent = objRow[convzx_TobeStudiedProblem.ProblemContent] == DBNull.Value ? null : objRow[convzx_TobeStudiedProblem.ProblemContent].ToString().Trim(); //问题内容
objvzx_TobeStudiedProblemEN.ProblemDate = objRow[convzx_TobeStudiedProblem.ProblemDate] == DBNull.Value ? null : objRow[convzx_TobeStudiedProblem.ProblemDate].ToString().Trim(); //问题日期
objvzx_TobeStudiedProblemEN.UpdDate = objRow[convzx_TobeStudiedProblem.UpdDate] == DBNull.Value ? null : objRow[convzx_TobeStudiedProblem.UpdDate].ToString().Trim(); //修改日期
objvzx_TobeStudiedProblemEN.UpdUser = objRow[convzx_TobeStudiedProblem.UpdUser] == DBNull.Value ? null : objRow[convzx_TobeStudiedProblem.UpdUser].ToString().Trim(); //修改人
objvzx_TobeStudiedProblemEN.Year = objRow[convzx_TobeStudiedProblem.Year] == DBNull.Value ? null : objRow[convzx_TobeStudiedProblem.Year].ToString().Trim(); //年
objvzx_TobeStudiedProblemEN.Month = objRow[convzx_TobeStudiedProblem.Month] == DBNull.Value ? null : objRow[convzx_TobeStudiedProblem.Month].ToString().Trim(); //月
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvzx_TobeStudiedProblemEN.ProblemId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvzx_TobeStudiedProblemEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objvzx_TobeStudiedProblemEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool Getvzx_TobeStudiedProblem(ref clsvzx_TobeStudiedProblemEN objvzx_TobeStudiedProblemEN)
{
bool bolResult = vzx_TobeStudiedProblemDA.Getvzx_TobeStudiedProblem(ref objvzx_TobeStudiedProblemEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "strProblemId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvzx_TobeStudiedProblemEN GetObjByProblemId(string strProblemId)
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
clsvzx_TobeStudiedProblemEN objvzx_TobeStudiedProblemEN = vzx_TobeStudiedProblemDA.GetObjByProblemId(strProblemId);
return objvzx_TobeStudiedProblemEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsvzx_TobeStudiedProblemEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsvzx_TobeStudiedProblemEN objvzx_TobeStudiedProblemEN = vzx_TobeStudiedProblemDA.GetFirstObj(strWhereCond);
 return objvzx_TobeStudiedProblemEN;
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
public static clsvzx_TobeStudiedProblemEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsvzx_TobeStudiedProblemEN objvzx_TobeStudiedProblemEN = vzx_TobeStudiedProblemDA.GetObjByDataRow(objRow);
 return objvzx_TobeStudiedProblemEN;
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
public static clsvzx_TobeStudiedProblemEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsvzx_TobeStudiedProblemEN objvzx_TobeStudiedProblemEN = vzx_TobeStudiedProblemDA.GetObjByDataRow(objRow);
 return objvzx_TobeStudiedProblemEN;
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
 /// <param name = "lstvzx_TobeStudiedProblemObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvzx_TobeStudiedProblemEN GetObjByProblemIdFromList(string strProblemId, List<clsvzx_TobeStudiedProblemEN> lstvzx_TobeStudiedProblemObjLst)
{
foreach (clsvzx_TobeStudiedProblemEN objvzx_TobeStudiedProblemEN in lstvzx_TobeStudiedProblemObjLst)
{
if (objvzx_TobeStudiedProblemEN.ProblemId == strProblemId)
{
return objvzx_TobeStudiedProblemEN;
}
}
return null;
}


 #endregion 获取一个实体对象


 #region 获取一个关键字值

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
 strProblemId = new clsvzx_TobeStudiedProblemDA().GetFirstID(strWhereCond);
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
 arrList = vzx_TobeStudiedProblemDA.GetID(strWhereCond);
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
bool bolIsExist = vzx_TobeStudiedProblemDA.IsExistCondRec(strWhereCond);
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
bool bolIsExist = vzx_TobeStudiedProblemDA.IsExist(strProblemId);
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
 bolIsExist = clsvzx_TobeStudiedProblemDA.IsExistTable();
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
 bolIsExist = vzx_TobeStudiedProblemDA.IsExistTable(strTabName);
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
 /// <param name = "objvzx_TobeStudiedProblemENS">源对象</param>
 /// <param name = "objvzx_TobeStudiedProblemENT">目标对象</param>
 public static void CopyTo(clsvzx_TobeStudiedProblemEN objvzx_TobeStudiedProblemENS, clsvzx_TobeStudiedProblemEN objvzx_TobeStudiedProblemENT)
{
try
{
objvzx_TobeStudiedProblemENT.GroupTextId = objvzx_TobeStudiedProblemENS.GroupTextId; //小组Id
objvzx_TobeStudiedProblemENT.GroupTextName = objvzx_TobeStudiedProblemENS.GroupTextName; //小组名称
objvzx_TobeStudiedProblemENT.IdCurrEduCls = objvzx_TobeStudiedProblemENS.IdCurrEduCls; //教学班流水号
objvzx_TobeStudiedProblemENT.zxShareId = objvzx_TobeStudiedProblemENS.zxShareId; //分享Id
objvzx_TobeStudiedProblemENT.Memo = objvzx_TobeStudiedProblemENS.Memo; //备注
objvzx_TobeStudiedProblemENT.Participant = objvzx_TobeStudiedProblemENS.Participant; //参与者
objvzx_TobeStudiedProblemENT.VersionCount = objvzx_TobeStudiedProblemENS.VersionCount; //版本统计
objvzx_TobeStudiedProblemENT.IsSubmit = objvzx_TobeStudiedProblemENS.IsSubmit; //是否提交
objvzx_TobeStudiedProblemENT.ProblemId = objvzx_TobeStudiedProblemENS.ProblemId; //问题Id
objvzx_TobeStudiedProblemENT.ProblemTitle = objvzx_TobeStudiedProblemENS.ProblemTitle; //问题标题
objvzx_TobeStudiedProblemENT.ProblemContent = objvzx_TobeStudiedProblemENS.ProblemContent; //问题内容
objvzx_TobeStudiedProblemENT.ProblemDate = objvzx_TobeStudiedProblemENS.ProblemDate; //问题日期
objvzx_TobeStudiedProblemENT.UpdDate = objvzx_TobeStudiedProblemENS.UpdDate; //修改日期
objvzx_TobeStudiedProblemENT.UpdUser = objvzx_TobeStudiedProblemENS.UpdUser; //修改人
objvzx_TobeStudiedProblemENT.Year = objvzx_TobeStudiedProblemENS.Year; //年
objvzx_TobeStudiedProblemENT.Month = objvzx_TobeStudiedProblemENS.Month; //月
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
 /// <param name = "objvzx_TobeStudiedProblemEN">源简化对象</param>
 public static void SetUpdFlag(clsvzx_TobeStudiedProblemEN objvzx_TobeStudiedProblemEN)
{
try
{
objvzx_TobeStudiedProblemEN.ClearUpdateState();
   string strsfUpdFldSetStr = objvzx_TobeStudiedProblemEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(convzx_TobeStudiedProblem.GroupTextId, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_TobeStudiedProblemEN.GroupTextId = objvzx_TobeStudiedProblemEN.GroupTextId == "[null]" ? null :  objvzx_TobeStudiedProblemEN.GroupTextId; //小组Id
}
if (arrFldSet.Contains(convzx_TobeStudiedProblem.GroupTextName, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_TobeStudiedProblemEN.GroupTextName = objvzx_TobeStudiedProblemEN.GroupTextName == "[null]" ? null :  objvzx_TobeStudiedProblemEN.GroupTextName; //小组名称
}
if (arrFldSet.Contains(convzx_TobeStudiedProblem.IdCurrEduCls, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_TobeStudiedProblemEN.IdCurrEduCls = objvzx_TobeStudiedProblemEN.IdCurrEduCls == "[null]" ? null :  objvzx_TobeStudiedProblemEN.IdCurrEduCls; //教学班流水号
}
if (arrFldSet.Contains(convzx_TobeStudiedProblem.zxShareId, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_TobeStudiedProblemEN.zxShareId = objvzx_TobeStudiedProblemEN.zxShareId == "[null]" ? null :  objvzx_TobeStudiedProblemEN.zxShareId; //分享Id
}
if (arrFldSet.Contains(convzx_TobeStudiedProblem.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_TobeStudiedProblemEN.Memo = objvzx_TobeStudiedProblemEN.Memo == "[null]" ? null :  objvzx_TobeStudiedProblemEN.Memo; //备注
}
if (arrFldSet.Contains(convzx_TobeStudiedProblem.Participant, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_TobeStudiedProblemEN.Participant = objvzx_TobeStudiedProblemEN.Participant == "[null]" ? null :  objvzx_TobeStudiedProblemEN.Participant; //参与者
}
if (arrFldSet.Contains(convzx_TobeStudiedProblem.VersionCount, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_TobeStudiedProblemEN.VersionCount = objvzx_TobeStudiedProblemEN.VersionCount; //版本统计
}
if (arrFldSet.Contains(convzx_TobeStudiedProblem.IsSubmit, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_TobeStudiedProblemEN.IsSubmit = objvzx_TobeStudiedProblemEN.IsSubmit; //是否提交
}
if (arrFldSet.Contains(convzx_TobeStudiedProblem.ProblemId, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_TobeStudiedProblemEN.ProblemId = objvzx_TobeStudiedProblemEN.ProblemId; //问题Id
}
if (arrFldSet.Contains(convzx_TobeStudiedProblem.ProblemTitle, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_TobeStudiedProblemEN.ProblemTitle = objvzx_TobeStudiedProblemEN.ProblemTitle == "[null]" ? null :  objvzx_TobeStudiedProblemEN.ProblemTitle; //问题标题
}
if (arrFldSet.Contains(convzx_TobeStudiedProblem.ProblemContent, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_TobeStudiedProblemEN.ProblemContent = objvzx_TobeStudiedProblemEN.ProblemContent == "[null]" ? null :  objvzx_TobeStudiedProblemEN.ProblemContent; //问题内容
}
if (arrFldSet.Contains(convzx_TobeStudiedProblem.ProblemDate, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_TobeStudiedProblemEN.ProblemDate = objvzx_TobeStudiedProblemEN.ProblemDate == "[null]" ? null :  objvzx_TobeStudiedProblemEN.ProblemDate; //问题日期
}
if (arrFldSet.Contains(convzx_TobeStudiedProblem.UpdDate, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_TobeStudiedProblemEN.UpdDate = objvzx_TobeStudiedProblemEN.UpdDate == "[null]" ? null :  objvzx_TobeStudiedProblemEN.UpdDate; //修改日期
}
if (arrFldSet.Contains(convzx_TobeStudiedProblem.UpdUser, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_TobeStudiedProblemEN.UpdUser = objvzx_TobeStudiedProblemEN.UpdUser == "[null]" ? null :  objvzx_TobeStudiedProblemEN.UpdUser; //修改人
}
if (arrFldSet.Contains(convzx_TobeStudiedProblem.Year, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_TobeStudiedProblemEN.Year = objvzx_TobeStudiedProblemEN.Year == "[null]" ? null :  objvzx_TobeStudiedProblemEN.Year; //年
}
if (arrFldSet.Contains(convzx_TobeStudiedProblem.Month, new clsStrCompareIgnoreCase())  ==  true)
{
objvzx_TobeStudiedProblemEN.Month = objvzx_TobeStudiedProblemEN.Month == "[null]" ? null :  objvzx_TobeStudiedProblemEN.Month; //月
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
 /// <param name = "objvzx_TobeStudiedProblemEN">源简化对象</param>
 public static void AccessFldValueNull(clsvzx_TobeStudiedProblemEN objvzx_TobeStudiedProblemEN)
{
try
{
if (objvzx_TobeStudiedProblemEN.GroupTextId == "[null]") objvzx_TobeStudiedProblemEN.GroupTextId = null; //小组Id
if (objvzx_TobeStudiedProblemEN.GroupTextName == "[null]") objvzx_TobeStudiedProblemEN.GroupTextName = null; //小组名称
if (objvzx_TobeStudiedProblemEN.IdCurrEduCls == "[null]") objvzx_TobeStudiedProblemEN.IdCurrEduCls = null; //教学班流水号
if (objvzx_TobeStudiedProblemEN.zxShareId == "[null]") objvzx_TobeStudiedProblemEN.zxShareId = null; //分享Id
if (objvzx_TobeStudiedProblemEN.Memo == "[null]") objvzx_TobeStudiedProblemEN.Memo = null; //备注
if (objvzx_TobeStudiedProblemEN.Participant == "[null]") objvzx_TobeStudiedProblemEN.Participant = null; //参与者
if (objvzx_TobeStudiedProblemEN.ProblemTitle == "[null]") objvzx_TobeStudiedProblemEN.ProblemTitle = null; //问题标题
if (objvzx_TobeStudiedProblemEN.ProblemContent == "[null]") objvzx_TobeStudiedProblemEN.ProblemContent = null; //问题内容
if (objvzx_TobeStudiedProblemEN.ProblemDate == "[null]") objvzx_TobeStudiedProblemEN.ProblemDate = null; //问题日期
if (objvzx_TobeStudiedProblemEN.UpdDate == "[null]") objvzx_TobeStudiedProblemEN.UpdDate = null; //修改日期
if (objvzx_TobeStudiedProblemEN.UpdUser == "[null]") objvzx_TobeStudiedProblemEN.UpdUser = null; //修改人
if (objvzx_TobeStudiedProblemEN.Year == "[null]") objvzx_TobeStudiedProblemEN.Year = null; //年
if (objvzx_TobeStudiedProblemEN.Month == "[null]") objvzx_TobeStudiedProblemEN.Month = null; //月
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
public static void CheckProperty4Condition(clsvzx_TobeStudiedProblemEN objvzx_TobeStudiedProblemEN)
{
 vzx_TobeStudiedProblemDA.CheckProperty4Condition(objvzx_TobeStudiedProblemEN);
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
if (clszx_GroupTextBL.objCommFun4BL == null)
{
strMsg = string.Format("类clszx_GroupTextBL没有刷新缓存机制(clszx_GroupTextBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clszx_TobeStudiedProblemBL.objCommFun4BL == null)
{
strMsg = string.Format("类clszx_TobeStudiedProblemBL没有刷新缓存机制(clszx_TobeStudiedProblemBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by ProblemId");
//if (arrvzx_TobeStudiedProblemObjLstCache == null)
//{
//arrvzx_TobeStudiedProblemObjLstCache = vzx_TobeStudiedProblemDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "strProblemId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvzx_TobeStudiedProblemEN GetObjByProblemIdCache(string strProblemId)
{
//获取缓存中的对象列表
string strKey = string.Format("{0}", clsvzx_TobeStudiedProblemEN._CurrTabName);
List<clsvzx_TobeStudiedProblemEN> arrvzx_TobeStudiedProblemObjLstCache = GetObjLstCache();
IEnumerable <clsvzx_TobeStudiedProblemEN> arrvzx_TobeStudiedProblemObjLst_Sel =
arrvzx_TobeStudiedProblemObjLstCache
.Where(x=> x.ProblemId == strProblemId 
);
if (arrvzx_TobeStudiedProblemObjLst_Sel.Count() == 0)
{
   clsvzx_TobeStudiedProblemEN obj = clsvzx_TobeStudiedProblemBL.GetObjByProblemId(strProblemId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
 }
return null;
}
return arrvzx_TobeStudiedProblemObjLst_Sel.First();
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvzx_TobeStudiedProblemEN> GetAllvzx_TobeStudiedProblemObjLstCache()
{
//获取缓存中的对象列表
List<clsvzx_TobeStudiedProblemEN> arrvzx_TobeStudiedProblemObjLstCache = GetObjLstCache(); 
return arrvzx_TobeStudiedProblemObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvzx_TobeStudiedProblemEN> GetObjLstCache()
{
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}", clsvzx_TobeStudiedProblemEN._CurrTabName);
List<clsvzx_TobeStudiedProblemEN> arrvzx_TobeStudiedProblemObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrvzx_TobeStudiedProblemObjLstCache;
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
string strKey = string.Format("{0}", clsvzx_TobeStudiedProblemEN._CurrTabName);
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
if (strInFldName != convzx_TobeStudiedProblem.ProblemId)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (convzx_TobeStudiedProblem.AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", convzx_TobeStudiedProblem.AttributeName));
throw new Exception(strMsg);
}
var objvzx_TobeStudiedProblem = clsvzx_TobeStudiedProblemBL.GetObjByProblemIdCache(strProblemId);
if (objvzx_TobeStudiedProblem == null) return "";
return objvzx_TobeStudiedProblem[strOutFldName].ToString();
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
int intRecCount = clsvzx_TobeStudiedProblemDA.GetRecCount(strTabName);
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
int intRecCount = clsvzx_TobeStudiedProblemDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsvzx_TobeStudiedProblemDA.GetRecCount();
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
int intRecCount = clsvzx_TobeStudiedProblemDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objvzx_TobeStudiedProblemCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsvzx_TobeStudiedProblemEN objvzx_TobeStudiedProblemCond)
{
List<clsvzx_TobeStudiedProblemEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsvzx_TobeStudiedProblemEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convzx_TobeStudiedProblem.AttributeName)
{
if (objvzx_TobeStudiedProblemCond.IsUpdated(strFldName) == false) continue;
if (objvzx_TobeStudiedProblemCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvzx_TobeStudiedProblemCond[strFldName].ToString());
}
else
{
if (objvzx_TobeStudiedProblemCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvzx_TobeStudiedProblemCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvzx_TobeStudiedProblemCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvzx_TobeStudiedProblemCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvzx_TobeStudiedProblemCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvzx_TobeStudiedProblemCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvzx_TobeStudiedProblemCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvzx_TobeStudiedProblemCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvzx_TobeStudiedProblemCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvzx_TobeStudiedProblemCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvzx_TobeStudiedProblemCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvzx_TobeStudiedProblemCond[strFldName]));
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
 List<string> arrList = clsvzx_TobeStudiedProblemDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = vzx_TobeStudiedProblemDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = vzx_TobeStudiedProblemDA.GetFldValueNoDistinct(strFldName, strWhereCond);
return arrList;
}



 #endregion 表操作常用函数
}
}