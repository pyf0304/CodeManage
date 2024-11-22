
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvPaperSubViewpointAppraiseWApi
 表名:vPaperSubViewpointAppraise(01120562)
 生成代码版本:2021.09.20.1
 生成日期:2021/09/21 02:45:35
 生成者:pyf
 生成服务器IP:103.116.76.183
 工程名称:问卷调查
 工程ID:0112
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:其他
 模块英文名:Other
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
public static class clsvPaperSubViewpointAppraiseWApi_Static
{

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPaperSubViewpointAppraiseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvPaperSubViewpointAppraiseEN SetPaperSubViewpointAppraiseId(this clsvPaperSubViewpointAppraiseEN objvPaperSubViewpointAppraiseEN, long lngPaperSubViewpointAppraiseId, string strComparisonOp="")
	{
objvPaperSubViewpointAppraiseEN.PaperSubViewpointAppraiseId = lngPaperSubViewpointAppraiseId; //PaperSubViewpointAppraiseId
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPaperSubViewpointAppraiseEN.dicFldComparisonOp.ContainsKey(convPaperSubViewpointAppraise.PaperSubViewpointAppraiseId) == false)
{
objvPaperSubViewpointAppraiseEN.dicFldComparisonOp.Add(convPaperSubViewpointAppraise.PaperSubViewpointAppraiseId, strComparisonOp);
}
else
{
objvPaperSubViewpointAppraiseEN.dicFldComparisonOp[convPaperSubViewpointAppraise.PaperSubViewpointAppraiseId] = strComparisonOp;
}
}
return objvPaperSubViewpointAppraiseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPaperSubViewpointAppraiseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvPaperSubViewpointAppraiseEN SetAppraiseScore(this clsvPaperSubViewpointAppraiseEN objvPaperSubViewpointAppraiseEN, float fltAppraiseScore, string strComparisonOp="")
	{
objvPaperSubViewpointAppraiseEN.AppraiseScore = fltAppraiseScore; //打分
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPaperSubViewpointAppraiseEN.dicFldComparisonOp.ContainsKey(convPaperSubViewpointAppraise.AppraiseScore) == false)
{
objvPaperSubViewpointAppraiseEN.dicFldComparisonOp.Add(convPaperSubViewpointAppraise.AppraiseScore, strComparisonOp);
}
else
{
objvPaperSubViewpointAppraiseEN.dicFldComparisonOp[convPaperSubViewpointAppraise.AppraiseScore] = strComparisonOp;
}
}
return objvPaperSubViewpointAppraiseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPaperSubViewpointAppraiseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvPaperSubViewpointAppraiseEN SetAppraiseContent(this clsvPaperSubViewpointAppraiseEN objvPaperSubViewpointAppraiseEN, string strAppraiseContent, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strAppraiseContent, 2000, convPaperSubViewpointAppraise.AppraiseContent);
objvPaperSubViewpointAppraiseEN.AppraiseContent = strAppraiseContent; //评议内容
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPaperSubViewpointAppraiseEN.dicFldComparisonOp.ContainsKey(convPaperSubViewpointAppraise.AppraiseContent) == false)
{
objvPaperSubViewpointAppraiseEN.dicFldComparisonOp.Add(convPaperSubViewpointAppraise.AppraiseContent, strComparisonOp);
}
else
{
objvPaperSubViewpointAppraiseEN.dicFldComparisonOp[convPaperSubViewpointAppraise.AppraiseContent] = strComparisonOp;
}
}
return objvPaperSubViewpointAppraiseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPaperSubViewpointAppraiseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvPaperSubViewpointAppraiseEN SetUpdDate(this clsvPaperSubViewpointAppraiseEN objvPaperSubViewpointAppraiseEN, string strUpdDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdDate, 20, convPaperSubViewpointAppraise.UpdDate);
objvPaperSubViewpointAppraiseEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPaperSubViewpointAppraiseEN.dicFldComparisonOp.ContainsKey(convPaperSubViewpointAppraise.UpdDate) == false)
{
objvPaperSubViewpointAppraiseEN.dicFldComparisonOp.Add(convPaperSubViewpointAppraise.UpdDate, strComparisonOp);
}
else
{
objvPaperSubViewpointAppraiseEN.dicFldComparisonOp[convPaperSubViewpointAppraise.UpdDate] = strComparisonOp;
}
}
return objvPaperSubViewpointAppraiseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPaperSubViewpointAppraiseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvPaperSubViewpointAppraiseEN SetMeno(this clsvPaperSubViewpointAppraiseEN objvPaperSubViewpointAppraiseEN, string strMeno, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMeno, 2000, convPaperSubViewpointAppraise.Meno);
objvPaperSubViewpointAppraiseEN.Meno = strMeno; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPaperSubViewpointAppraiseEN.dicFldComparisonOp.ContainsKey(convPaperSubViewpointAppraise.Meno) == false)
{
objvPaperSubViewpointAppraiseEN.dicFldComparisonOp.Add(convPaperSubViewpointAppraise.Meno, strComparisonOp);
}
else
{
objvPaperSubViewpointAppraiseEN.dicFldComparisonOp[convPaperSubViewpointAppraise.Meno] = strComparisonOp;
}
}
return objvPaperSubViewpointAppraiseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPaperSubViewpointAppraiseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvPaperSubViewpointAppraiseEN SetRWTitle(this clsvPaperSubViewpointAppraiseEN objvPaperSubViewpointAppraiseEN, string strRWTitle, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strRWTitle, 50, convPaperSubViewpointAppraise.RWTitle);
objvPaperSubViewpointAppraiseEN.RWTitle = strRWTitle; //读写标题
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPaperSubViewpointAppraiseEN.dicFldComparisonOp.ContainsKey(convPaperSubViewpointAppraise.RWTitle) == false)
{
objvPaperSubViewpointAppraiseEN.dicFldComparisonOp.Add(convPaperSubViewpointAppraise.RWTitle, strComparisonOp);
}
else
{
objvPaperSubViewpointAppraiseEN.dicFldComparisonOp[convPaperSubViewpointAppraise.RWTitle] = strComparisonOp;
}
}
return objvPaperSubViewpointAppraiseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPaperSubViewpointAppraiseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvPaperSubViewpointAppraiseEN SetSubViewpointContent(this clsvPaperSubViewpointAppraiseEN objvPaperSubViewpointAppraiseEN, string strSubViewpointContent, string strComparisonOp="")
	{
objvPaperSubViewpointAppraiseEN.SubViewpointContent = strSubViewpointContent; //详情内容
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPaperSubViewpointAppraiseEN.dicFldComparisonOp.ContainsKey(convPaperSubViewpointAppraise.SubViewpointContent) == false)
{
objvPaperSubViewpointAppraiseEN.dicFldComparisonOp.Add(convPaperSubViewpointAppraise.SubViewpointContent, strComparisonOp);
}
else
{
objvPaperSubViewpointAppraiseEN.dicFldComparisonOp[convPaperSubViewpointAppraise.SubViewpointContent] = strComparisonOp;
}
}
return objvPaperSubViewpointAppraiseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPaperSubViewpointAppraiseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvPaperSubViewpointAppraiseEN SetExplainContent(this clsvPaperSubViewpointAppraiseEN objvPaperSubViewpointAppraiseEN, string strExplainContent, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strExplainContent, 5000, convPaperSubViewpointAppraise.ExplainContent);
objvPaperSubViewpointAppraiseEN.ExplainContent = strExplainContent; //说明内容
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPaperSubViewpointAppraiseEN.dicFldComparisonOp.ContainsKey(convPaperSubViewpointAppraise.ExplainContent) == false)
{
objvPaperSubViewpointAppraiseEN.dicFldComparisonOp.Add(convPaperSubViewpointAppraise.ExplainContent, strComparisonOp);
}
else
{
objvPaperSubViewpointAppraiseEN.dicFldComparisonOp[convPaperSubViewpointAppraise.ExplainContent] = strComparisonOp;
}
}
return objvPaperSubViewpointAppraiseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPaperSubViewpointAppraiseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvPaperSubViewpointAppraiseEN SetPaperRWId(this clsvPaperSubViewpointAppraiseEN objvPaperSubViewpointAppraiseEN, string strPaperRWId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strPaperRWId, 8, convPaperSubViewpointAppraise.PaperRWId);
clsCheckSql.CheckFieldForeignKey(strPaperRWId, 8, convPaperSubViewpointAppraise.PaperRWId);
objvPaperSubViewpointAppraiseEN.PaperRWId = strPaperRWId; //课文阅读
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPaperSubViewpointAppraiseEN.dicFldComparisonOp.ContainsKey(convPaperSubViewpointAppraise.PaperRWId) == false)
{
objvPaperSubViewpointAppraiseEN.dicFldComparisonOp.Add(convPaperSubViewpointAppraise.PaperRWId, strComparisonOp);
}
else
{
objvPaperSubViewpointAppraiseEN.dicFldComparisonOp[convPaperSubViewpointAppraise.PaperRWId] = strComparisonOp;
}
}
return objvPaperSubViewpointAppraiseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPaperSubViewpointAppraiseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvPaperSubViewpointAppraiseEN SetSubViewpointId(this clsvPaperSubViewpointAppraiseEN objvPaperSubViewpointAppraiseEN, long lngSubViewpointId, string strComparisonOp="")
	{
objvPaperSubViewpointAppraiseEN.SubViewpointId = lngSubViewpointId; //子观点Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPaperSubViewpointAppraiseEN.dicFldComparisonOp.ContainsKey(convPaperSubViewpointAppraise.SubViewpointId) == false)
{
objvPaperSubViewpointAppraiseEN.dicFldComparisonOp.Add(convPaperSubViewpointAppraise.SubViewpointId, strComparisonOp);
}
else
{
objvPaperSubViewpointAppraiseEN.dicFldComparisonOp[convPaperSubViewpointAppraise.SubViewpointId] = strComparisonOp;
}
}
return objvPaperSubViewpointAppraiseEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPaperSubViewpointAppraiseEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvPaperSubViewpointAppraiseEN SetUpdUser(this clsvPaperSubViewpointAppraiseEN objvPaperSubViewpointAppraiseEN, string strUpdUser, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdUser, 20, convPaperSubViewpointAppraise.UpdUser);
objvPaperSubViewpointAppraiseEN.UpdUser = strUpdUser; //修改人
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPaperSubViewpointAppraiseEN.dicFldComparisonOp.ContainsKey(convPaperSubViewpointAppraise.UpdUser) == false)
{
objvPaperSubViewpointAppraiseEN.dicFldComparisonOp.Add(convPaperSubViewpointAppraise.UpdUser, strComparisonOp);
}
else
{
objvPaperSubViewpointAppraiseEN.dicFldComparisonOp[convPaperSubViewpointAppraise.UpdUser] = strComparisonOp;
}
}
return objvPaperSubViewpointAppraiseEN;
	}

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvPaperSubViewpointAppraiseEN objvPaperSubViewpointAppraise_Cond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvPaperSubViewpointAppraise_Cond.IsUpdated(convPaperSubViewpointAppraise.PaperSubViewpointAppraiseId) == true)
{
string strComparisonOp_PaperSubViewpointAppraiseId = objvPaperSubViewpointAppraise_Cond.dicFldComparisonOp[convPaperSubViewpointAppraise.PaperSubViewpointAppraiseId];
strWhereCond += string.Format(" And {0} {2} {1}", convPaperSubViewpointAppraise.PaperSubViewpointAppraiseId, objvPaperSubViewpointAppraise_Cond.PaperSubViewpointAppraiseId, strComparisonOp_PaperSubViewpointAppraiseId);
}
if (objvPaperSubViewpointAppraise_Cond.IsUpdated(convPaperSubViewpointAppraise.AppraiseScore) == true)
{
string strComparisonOp_AppraiseScore = objvPaperSubViewpointAppraise_Cond.dicFldComparisonOp[convPaperSubViewpointAppraise.AppraiseScore];
strWhereCond += string.Format(" And {0} {2} {1}", convPaperSubViewpointAppraise.AppraiseScore, objvPaperSubViewpointAppraise_Cond.AppraiseScore, strComparisonOp_AppraiseScore);
}
if (objvPaperSubViewpointAppraise_Cond.IsUpdated(convPaperSubViewpointAppraise.AppraiseContent) == true)
{
string strComparisonOp_AppraiseContent = objvPaperSubViewpointAppraise_Cond.dicFldComparisonOp[convPaperSubViewpointAppraise.AppraiseContent];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPaperSubViewpointAppraise.AppraiseContent, objvPaperSubViewpointAppraise_Cond.AppraiseContent, strComparisonOp_AppraiseContent);
}
if (objvPaperSubViewpointAppraise_Cond.IsUpdated(convPaperSubViewpointAppraise.UpdDate) == true)
{
string strComparisonOp_UpdDate = objvPaperSubViewpointAppraise_Cond.dicFldComparisonOp[convPaperSubViewpointAppraise.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPaperSubViewpointAppraise.UpdDate, objvPaperSubViewpointAppraise_Cond.UpdDate, strComparisonOp_UpdDate);
}
if (objvPaperSubViewpointAppraise_Cond.IsUpdated(convPaperSubViewpointAppraise.Meno) == true)
{
string strComparisonOp_Meno = objvPaperSubViewpointAppraise_Cond.dicFldComparisonOp[convPaperSubViewpointAppraise.Meno];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPaperSubViewpointAppraise.Meno, objvPaperSubViewpointAppraise_Cond.Meno, strComparisonOp_Meno);
}
if (objvPaperSubViewpointAppraise_Cond.IsUpdated(convPaperSubViewpointAppraise.RWTitle) == true)
{
string strComparisonOp_RWTitle = objvPaperSubViewpointAppraise_Cond.dicFldComparisonOp[convPaperSubViewpointAppraise.RWTitle];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPaperSubViewpointAppraise.RWTitle, objvPaperSubViewpointAppraise_Cond.RWTitle, strComparisonOp_RWTitle);
}
//数据类型string(text)在函数:[AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj]中没有处理！
if (objvPaperSubViewpointAppraise_Cond.IsUpdated(convPaperSubViewpointAppraise.ExplainContent) == true)
{
string strComparisonOp_ExplainContent = objvPaperSubViewpointAppraise_Cond.dicFldComparisonOp[convPaperSubViewpointAppraise.ExplainContent];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPaperSubViewpointAppraise.ExplainContent, objvPaperSubViewpointAppraise_Cond.ExplainContent, strComparisonOp_ExplainContent);
}
if (objvPaperSubViewpointAppraise_Cond.IsUpdated(convPaperSubViewpointAppraise.PaperRWId) == true)
{
string strComparisonOp_PaperRWId = objvPaperSubViewpointAppraise_Cond.dicFldComparisonOp[convPaperSubViewpointAppraise.PaperRWId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPaperSubViewpointAppraise.PaperRWId, objvPaperSubViewpointAppraise_Cond.PaperRWId, strComparisonOp_PaperRWId);
}
if (objvPaperSubViewpointAppraise_Cond.IsUpdated(convPaperSubViewpointAppraise.SubViewpointId) == true)
{
string strComparisonOp_SubViewpointId = objvPaperSubViewpointAppraise_Cond.dicFldComparisonOp[convPaperSubViewpointAppraise.SubViewpointId];
strWhereCond += string.Format(" And {0} {2} {1}", convPaperSubViewpointAppraise.SubViewpointId, objvPaperSubViewpointAppraise_Cond.SubViewpointId, strComparisonOp_SubViewpointId);
}
if (objvPaperSubViewpointAppraise_Cond.IsUpdated(convPaperSubViewpointAppraise.UpdUser) == true)
{
string strComparisonOp_UpdUser = objvPaperSubViewpointAppraise_Cond.dicFldComparisonOp[convPaperSubViewpointAppraise.UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPaperSubViewpointAppraise.UpdUser, objvPaperSubViewpointAppraise_Cond.UpdUser, strComparisonOp_UpdUser);
}
 return strWhereCond;
}
}
 /// <summary>
 /// v子观点评论表(vPaperSubViewpointAppraise)
 /// (AutoGCLib.WA_Access4CSharp:GeneCode)
 /// </summary>
public class clsvPaperSubViewpointAppraiseWApi
{
private static readonly string mstrApiControllerName = "vPaperSubViewpointAppraiseApi";

 public clsvPaperSubViewpointAppraiseWApi()
 {
 }

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyId)
 /// </summary>
 /// <param name = "lngPaperSubViewpointAppraiseId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvPaperSubViewpointAppraiseEN GetObjByPaperSubViewpointAppraiseId(long lngPaperSubViewpointAppraiseId)
{
string strAction = "GetObjByPaperSubViewpointAppraiseId";
string strErrMsg = string.Empty;
string strResult = "";
clsvPaperSubViewpointAppraiseEN objvPaperSubViewpointAppraiseEN = null;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["PaperSubViewpointAppraiseId"] = lngPaperSubViewpointAppraiseId.ToString()
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
objvPaperSubViewpointAppraiseEN = JsonConvert.DeserializeObject<clsvPaperSubViewpointAppraiseEN>((string)jobjReturn["ReturnObj"]);
return objvPaperSubViewpointAppraiseEN;
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
 /// <param name = "lngPaperSubViewpointAppraiseId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvPaperSubViewpointAppraiseEN GetObjByPaperSubViewpointAppraiseId_WA_Cache(long lngPaperSubViewpointAppraiseId)
{
string strAction = "GetObjByPaperSubViewpointAppraiseId_Cache";
string strErrMsg = string.Empty;
string strResult = "";
clsvPaperSubViewpointAppraiseEN objvPaperSubViewpointAppraiseEN = null;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["PaperSubViewpointAppraiseId"] = lngPaperSubViewpointAppraiseId.ToString()
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
objvPaperSubViewpointAppraiseEN = JsonConvert.DeserializeObject<clsvPaperSubViewpointAppraiseEN>((string)jobjReturn["ReturnObj"]);
return objvPaperSubViewpointAppraiseEN;
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
public static clsvPaperSubViewpointAppraiseEN GetFirstObj(string strWhereCond)
{
string strAction = "GetFirstObj";
string strErrMsg = string.Empty;
string strResult = "";
clsvPaperSubViewpointAppraiseEN objvPaperSubViewpointAppraiseEN = null;
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
objvPaperSubViewpointAppraiseEN = JsonConvert.DeserializeObject<clsvPaperSubViewpointAppraiseEN>((string)jobjReturn["ReturnObj"]);
return objvPaperSubViewpointAppraiseEN;
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
 /// <param name = "lngPaperSubViewpointAppraiseId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvPaperSubViewpointAppraiseEN GetObjByPaperSubViewpointAppraiseId_Cache(long lngPaperSubViewpointAppraiseId)
{
//初始化列表缓存
string strKey = string.Format("{0}", clsvPaperSubViewpointAppraiseEN._CurrTabName_S);
List<clsvPaperSubViewpointAppraiseEN> arrvPaperSubViewpointAppraiseObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsvPaperSubViewpointAppraiseEN> arrvPaperSubViewpointAppraiseObjLst_Sel =
from objvPaperSubViewpointAppraiseEN in arrvPaperSubViewpointAppraiseObjLst_Cache
where objvPaperSubViewpointAppraiseEN.PaperSubViewpointAppraiseId == lngPaperSubViewpointAppraiseId
select objvPaperSubViewpointAppraiseEN;
if (arrvPaperSubViewpointAppraiseObjLst_Sel.Count() == 0)
{
   clsvPaperSubViewpointAppraiseEN obj = clsvPaperSubViewpointAppraiseWApi.GetObjByPaperSubViewpointAppraiseId(lngPaperSubViewpointAppraiseId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
     return obj;
 }
return null;
}
return arrvPaperSubViewpointAppraiseObjLst_Sel.First();
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvPaperSubViewpointAppraiseEN> GetObjLst(string strWhereCond)
{
 List<clsvPaperSubViewpointAppraiseEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvPaperSubViewpointAppraiseEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvPaperSubViewpointAppraiseEN> GetObjLstByPaperSubViewpointAppraiseIdLst(List<long> arrPaperSubViewpointAppraiseId)
{
 List<clsvPaperSubViewpointAppraiseEN> arrObjLst = null; 
string strAction = "GetObjLstByPaperSubViewpointAppraiseIdLst";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrPaperSubViewpointAppraiseId);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
arrObjLst = JsonConvert.DeserializeObject<List<clsvPaperSubViewpointAppraiseEN>>((string)jobjReturn["ReturnObjLst"]);
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
 /// <param name = "lngPaperSubViewpointAppraiseId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static IEnumerable<clsvPaperSubViewpointAppraiseEN> GetObjLstByPaperSubViewpointAppraiseIdLst_Cache(List<long> arrPaperSubViewpointAppraiseId)
{
//初始化列表缓存
string strKey = string.Format("{0}", clsvPaperSubViewpointAppraiseEN._CurrTabName_S);
List<clsvPaperSubViewpointAppraiseEN> arrvPaperSubViewpointAppraiseObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsvPaperSubViewpointAppraiseEN> arrvPaperSubViewpointAppraiseObjLst_Sel =
from objvPaperSubViewpointAppraiseEN in arrvPaperSubViewpointAppraiseObjLst_Cache
where arrPaperSubViewpointAppraiseId.Contains(objvPaperSubViewpointAppraiseEN.PaperSubViewpointAppraiseId)
select objvPaperSubViewpointAppraiseEN;
return arrvPaperSubViewpointAppraiseObjLst_Sel;
}

 /// <summary>
 /// 根据关键字列表获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstByKeyLst_WA_Cache)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvPaperSubViewpointAppraiseEN> GetObjLstByPaperSubViewpointAppraiseIdLst_WA_Cache(List<long> arrPaperSubViewpointAppraiseId)
{
 List<clsvPaperSubViewpointAppraiseEN> arrObjLst = null; 
string strAction = "GetObjLstByPaperSubViewpointAppraiseIdLst_Cache";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
};
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrPaperSubViewpointAppraiseId);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
arrObjLst = JsonConvert.DeserializeObject<List<clsvPaperSubViewpointAppraiseEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvPaperSubViewpointAppraiseEN> GetTopObjLst(stuTopPara objTopPara)
{
 List<clsvPaperSubViewpointAppraiseEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvPaperSubViewpointAppraiseEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvPaperSubViewpointAppraiseEN> GetObjLstByRange(stuRangePara objRangePara)
{
 List<clsvPaperSubViewpointAppraiseEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvPaperSubViewpointAppraiseEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvPaperSubViewpointAppraiseEN> GetObjLstByPager(stuPagerPara objPagerPara)
{
 List<clsvPaperSubViewpointAppraiseEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvPaperSubViewpointAppraiseEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvPaperSubViewpointAppraiseEN> GetObjLstByPager_Cache(stuPagerPara objPagerPara)
{
 List<clsvPaperSubViewpointAppraiseEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvPaperSubViewpointAppraiseEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static bool IsExist(long lngPaperSubViewpointAppraiseId)
{
//检测记录是否存在
string strAction = "IsExist";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["PaperSubViewpointAppraiseId"] = lngPaperSubViewpointAppraiseId.ToString()
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
 /// <param name = "objvPaperSubViewpointAppraiseENS">源对象</param>
 /// <param name = "objvPaperSubViewpointAppraiseENT">目标对象</param>
 public static void CopyTo(clsvPaperSubViewpointAppraiseEN objvPaperSubViewpointAppraiseENS, clsvPaperSubViewpointAppraiseEN objvPaperSubViewpointAppraiseENT)
{
try
{
objvPaperSubViewpointAppraiseENT.PaperSubViewpointAppraiseId = objvPaperSubViewpointAppraiseENS.PaperSubViewpointAppraiseId; //PaperSubViewpointAppraiseId
objvPaperSubViewpointAppraiseENT.AppraiseScore = objvPaperSubViewpointAppraiseENS.AppraiseScore; //打分
objvPaperSubViewpointAppraiseENT.AppraiseContent = objvPaperSubViewpointAppraiseENS.AppraiseContent; //评议内容
objvPaperSubViewpointAppraiseENT.UpdDate = objvPaperSubViewpointAppraiseENS.UpdDate; //修改日期
objvPaperSubViewpointAppraiseENT.Meno = objvPaperSubViewpointAppraiseENS.Meno; //备注
objvPaperSubViewpointAppraiseENT.RWTitle = objvPaperSubViewpointAppraiseENS.RWTitle; //读写标题
objvPaperSubViewpointAppraiseENT.SubViewpointContent = objvPaperSubViewpointAppraiseENS.SubViewpointContent; //详情内容
objvPaperSubViewpointAppraiseENT.ExplainContent = objvPaperSubViewpointAppraiseENS.ExplainContent; //说明内容
objvPaperSubViewpointAppraiseENT.PaperRWId = objvPaperSubViewpointAppraiseENS.PaperRWId; //课文阅读
objvPaperSubViewpointAppraiseENT.SubViewpointId = objvPaperSubViewpointAppraiseENS.SubViewpointId; //子观点Id
objvPaperSubViewpointAppraiseENT.UpdUser = objvPaperSubViewpointAppraiseENS.UpdUser; //修改人
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
public static DataTable ToDataTable(List<clsvPaperSubViewpointAppraiseEN> arrObj)
{
DataTable dataTable = new DataTable(); //实例化
DataTable result;
if (arrObj.Count == 0) return null;
if (clsvPaperSubViewpointAppraiseEN.AttributeName.Length == 0)
{
result = dataTable;
return result;
}
Type type = typeof(clsvPaperSubViewpointAppraiseEN);
PropertyInfo[] arrPropertyInfo = type.GetProperties();
try
{
//Columns
foreach (string strAttrName in clsvPaperSubViewpointAppraiseEN.AttributeName)
{
PropertyInfo proprety_Curr = arrPropertyInfo.Where(x => x.Name == strAttrName).First();
dataTable.Columns.Add(strAttrName, proprety_Curr.PropertyType);
}
foreach (clsvPaperSubViewpointAppraiseEN objInFor in arrObj)
{
//Rows
DataRow dataRow = dataTable.NewRow();
foreach (string strAttrName in clsvPaperSubViewpointAppraiseEN.AttributeName)
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
if (clsPaperSubViewpointWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsPaperSubViewpointWApi没有刷新缓存机制(clsPaperSubViewpointWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsPaperSubViewpointAppraiseWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsPaperSubViewpointAppraiseWApi没有刷新缓存机制(clsPaperSubViewpointAppraiseWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by PaperSubViewpointAppraiseId");
//if (arrvPaperSubViewpointAppraiseObjLst_Cache == null)
//{
//arrvPaperSubViewpointAppraiseObjLst_Cache = await clsvPaperSubViewpointAppraiseWApi.GetObjLst(strWhereCond);
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
string strKey = string.Format("{0}", clsvPaperSubViewpointAppraiseEN._CurrTabName_S);
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
public static List<clsvPaperSubViewpointAppraiseEN> GetObjLst_Cache()
{
//初始化列表缓存
InitListCache(); 
string strKey = string.Format("{0}", clsvPaperSubViewpointAppraiseEN._CurrTabName_S);
List<clsvPaperSubViewpointAppraiseEN> arrvPaperSubViewpointAppraiseObjLst_Cache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrvPaperSubViewpointAppraiseObjLst_Cache;
}

 /// <summary>
 /// 根据对象列表获取DataTable
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetDataTableByObjLst)
 /// </summary>
 /// <param name = "arrObjLst">给定的对象列表</param>
 /// <returns>返回DataTable</returns>
public static DataTable GetDataTableByObjLst(List<clsvPaperSubViewpointAppraiseEN> arrObjLst)
{
DataTable objDT = new DataTable();
objDT.Columns.Add(convPaperSubViewpointAppraise.PaperSubViewpointAppraiseId, Type.GetType("System.Int64"));
objDT.Columns.Add(convPaperSubViewpointAppraise.AppraiseScore, Type.GetType("System.Single"));
objDT.Columns.Add(convPaperSubViewpointAppraise.AppraiseContent, Type.GetType("System.String"));
objDT.Columns.Add(convPaperSubViewpointAppraise.UpdDate, Type.GetType("System.String"));
objDT.Columns.Add(convPaperSubViewpointAppraise.Meno, Type.GetType("System.String"));
objDT.Columns.Add(convPaperSubViewpointAppraise.RWTitle, Type.GetType("System.String"));
objDT.Columns.Add(convPaperSubViewpointAppraise.SubViewpointContent, Type.GetType("System.String"));
objDT.Columns.Add(convPaperSubViewpointAppraise.ExplainContent, Type.GetType("System.String"));
objDT.Columns.Add(convPaperSubViewpointAppraise.PaperRWId, Type.GetType("System.String"));
objDT.Columns.Add(convPaperSubViewpointAppraise.SubViewpointId, Type.GetType("System.Int64"));
objDT.Columns.Add(convPaperSubViewpointAppraise.UpdUser, Type.GetType("System.String"));
foreach (clsvPaperSubViewpointAppraiseEN objInFor in arrObjLst)
{
DataRow objDR = objDT.NewRow();
objDR[convPaperSubViewpointAppraise.PaperSubViewpointAppraiseId] = objInFor[convPaperSubViewpointAppraise.PaperSubViewpointAppraiseId];
objDR[convPaperSubViewpointAppraise.AppraiseScore] = objInFor[convPaperSubViewpointAppraise.AppraiseScore];
objDR[convPaperSubViewpointAppraise.AppraiseContent] = objInFor[convPaperSubViewpointAppraise.AppraiseContent];
objDR[convPaperSubViewpointAppraise.UpdDate] = objInFor[convPaperSubViewpointAppraise.UpdDate];
objDR[convPaperSubViewpointAppraise.Meno] = objInFor[convPaperSubViewpointAppraise.Meno];
objDR[convPaperSubViewpointAppraise.RWTitle] = objInFor[convPaperSubViewpointAppraise.RWTitle];
objDR[convPaperSubViewpointAppraise.SubViewpointContent] = objInFor[convPaperSubViewpointAppraise.SubViewpointContent];
objDR[convPaperSubViewpointAppraise.ExplainContent] = objInFor[convPaperSubViewpointAppraise.ExplainContent];
objDR[convPaperSubViewpointAppraise.PaperRWId] = objInFor[convPaperSubViewpointAppraise.PaperRWId];
objDR[convPaperSubViewpointAppraise.SubViewpointId] = objInFor[convPaperSubViewpointAppraise.SubViewpointId];
objDR[convPaperSubViewpointAppraise.UpdUser] = objInFor[convPaperSubViewpointAppraise.UpdUser];
objDT.Rows.Add(objDR);
}
return objDT;
}
}
}