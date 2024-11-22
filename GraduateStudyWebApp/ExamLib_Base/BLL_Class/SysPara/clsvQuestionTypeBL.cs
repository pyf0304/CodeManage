
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvQuestionTypeBL
 表名:vQuestionType(01120114)
 * 版本:2023.08.23.1(服务器:WIN-SRV103-116)
 日期:2023/08/24 13:07:48
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:公共后台所有表(变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:系统参数(SysPara)
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
public static class  clsvQuestionTypeBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "strQuestionTypeId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvQuestionTypeEN GetObj(this K_QuestionTypeId_vQuestionType myKey)
{
clsvQuestionTypeEN objvQuestionTypeEN = clsvQuestionTypeBL.vQuestionTypeDA.GetObjByQuestionTypeId(myKey.Value);
return objvQuestionTypeEN;
}

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQuestionTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQuestionTypeEN SetQuestionTypeId(this clsvQuestionTypeEN objvQuestionTypeEN, string strQuestionTypeId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strQuestionTypeId, 2, convQuestionType.QuestionTypeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strQuestionTypeId, 2, convQuestionType.QuestionTypeId);
}
objvQuestionTypeEN.QuestionTypeId = strQuestionTypeId; //题目类型Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQuestionTypeEN.dicFldComparisonOp.ContainsKey(convQuestionType.QuestionTypeId) == false)
{
objvQuestionTypeEN.dicFldComparisonOp.Add(convQuestionType.QuestionTypeId, strComparisonOp);
}
else
{
objvQuestionTypeEN.dicFldComparisonOp[convQuestionType.QuestionTypeId] = strComparisonOp;
}
}
return objvQuestionTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQuestionTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQuestionTypeEN SetQuestionTypeName(this clsvQuestionTypeEN objvQuestionTypeEN, string strQuestionTypeName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strQuestionTypeName, 20, convQuestionType.QuestionTypeName);
}
objvQuestionTypeEN.QuestionTypeName = strQuestionTypeName; //题目类型名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQuestionTypeEN.dicFldComparisonOp.ContainsKey(convQuestionType.QuestionTypeName) == false)
{
objvQuestionTypeEN.dicFldComparisonOp.Add(convQuestionType.QuestionTypeName, strComparisonOp);
}
else
{
objvQuestionTypeEN.dicFldComparisonOp[convQuestionType.QuestionTypeName] = strComparisonOp;
}
}
return objvQuestionTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQuestionTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQuestionTypeEN SetDefaAnswerModeId(this clsvQuestionTypeEN objvQuestionTypeEN, string strDefaAnswerModeId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strDefaAnswerModeId, 4, convQuestionType.DefaAnswerModeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strDefaAnswerModeId, 4, convQuestionType.DefaAnswerModeId);
}
objvQuestionTypeEN.DefaAnswerModeId = strDefaAnswerModeId; //默认答案模式Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQuestionTypeEN.dicFldComparisonOp.ContainsKey(convQuestionType.DefaAnswerModeId) == false)
{
objvQuestionTypeEN.dicFldComparisonOp.Add(convQuestionType.DefaAnswerModeId, strComparisonOp);
}
else
{
objvQuestionTypeEN.dicFldComparisonOp[convQuestionType.DefaAnswerModeId] = strComparisonOp;
}
}
return objvQuestionTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQuestionTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQuestionTypeEN SetAnswerModeName(this clsvQuestionTypeEN objvQuestionTypeEN, string strAnswerModeName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strAnswerModeName, 30, convQuestionType.AnswerModeName);
}
objvQuestionTypeEN.AnswerModeName = strAnswerModeName; //答案模式名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQuestionTypeEN.dicFldComparisonOp.ContainsKey(convQuestionType.AnswerModeName) == false)
{
objvQuestionTypeEN.dicFldComparisonOp.Add(convQuestionType.AnswerModeName, strComparisonOp);
}
else
{
objvQuestionTypeEN.dicFldComparisonOp[convQuestionType.AnswerModeName] = strComparisonOp;
}
}
return objvQuestionTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQuestionTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQuestionTypeEN SetDefaAnswerTypeId(this clsvQuestionTypeEN objvQuestionTypeEN, string strDefaAnswerTypeId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strDefaAnswerTypeId, 2, convQuestionType.DefaAnswerTypeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strDefaAnswerTypeId, 2, convQuestionType.DefaAnswerTypeId);
}
objvQuestionTypeEN.DefaAnswerTypeId = strDefaAnswerTypeId; //默认答案类型Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQuestionTypeEN.dicFldComparisonOp.ContainsKey(convQuestionType.DefaAnswerTypeId) == false)
{
objvQuestionTypeEN.dicFldComparisonOp.Add(convQuestionType.DefaAnswerTypeId, strComparisonOp);
}
else
{
objvQuestionTypeEN.dicFldComparisonOp[convQuestionType.DefaAnswerTypeId] = strComparisonOp;
}
}
return objvQuestionTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQuestionTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQuestionTypeEN SetAnswerTypeName(this clsvQuestionTypeEN objvQuestionTypeEN, string strAnswerTypeName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strAnswerTypeName, 50, convQuestionType.AnswerTypeName);
}
objvQuestionTypeEN.AnswerTypeName = strAnswerTypeName; //答案类型名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQuestionTypeEN.dicFldComparisonOp.ContainsKey(convQuestionType.AnswerTypeName) == false)
{
objvQuestionTypeEN.dicFldComparisonOp.Add(convQuestionType.AnswerTypeName, strComparisonOp);
}
else
{
objvQuestionTypeEN.dicFldComparisonOp[convQuestionType.AnswerTypeName] = strComparisonOp;
}
}
return objvQuestionTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQuestionTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQuestionTypeEN SetOrderNum(this clsvQuestionTypeEN objvQuestionTypeEN, int? intOrderNum, string strComparisonOp="")
	{
objvQuestionTypeEN.OrderNum = intOrderNum; //序号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQuestionTypeEN.dicFldComparisonOp.ContainsKey(convQuestionType.OrderNum) == false)
{
objvQuestionTypeEN.dicFldComparisonOp.Add(convQuestionType.OrderNum, strComparisonOp);
}
else
{
objvQuestionTypeEN.dicFldComparisonOp[convQuestionType.OrderNum] = strComparisonOp;
}
}
return objvQuestionTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQuestionTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQuestionTypeEN SetIsUse(this clsvQuestionTypeEN objvQuestionTypeEN, bool bolIsUse, string strComparisonOp="")
	{
objvQuestionTypeEN.IsUse = bolIsUse; //是否使用
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQuestionTypeEN.dicFldComparisonOp.ContainsKey(convQuestionType.IsUse) == false)
{
objvQuestionTypeEN.dicFldComparisonOp.Add(convQuestionType.IsUse, strComparisonOp);
}
else
{
objvQuestionTypeEN.dicFldComparisonOp[convQuestionType.IsUse] = strComparisonOp;
}
}
return objvQuestionTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQuestionTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQuestionTypeEN SetUpdDate(this clsvQuestionTypeEN objvQuestionTypeEN, string strUpdDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strUpdDate, convQuestionType.UpdDate);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdDate, 20, convQuestionType.UpdDate);
}
objvQuestionTypeEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQuestionTypeEN.dicFldComparisonOp.ContainsKey(convQuestionType.UpdDate) == false)
{
objvQuestionTypeEN.dicFldComparisonOp.Add(convQuestionType.UpdDate, strComparisonOp);
}
else
{
objvQuestionTypeEN.dicFldComparisonOp[convQuestionType.UpdDate] = strComparisonOp;
}
}
return objvQuestionTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQuestionTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQuestionTypeEN SetUpdUser(this clsvQuestionTypeEN objvQuestionTypeEN, string strUpdUser, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strUpdUser, convQuestionType.UpdUser);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdUser, 20, convQuestionType.UpdUser);
}
objvQuestionTypeEN.UpdUser = strUpdUser; //修改人
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQuestionTypeEN.dicFldComparisonOp.ContainsKey(convQuestionType.UpdUser) == false)
{
objvQuestionTypeEN.dicFldComparisonOp.Add(convQuestionType.UpdUser, strComparisonOp);
}
else
{
objvQuestionTypeEN.dicFldComparisonOp[convQuestionType.UpdUser] = strComparisonOp;
}
}
return objvQuestionTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQuestionTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQuestionTypeEN SetMemo(this clsvQuestionTypeEN objvQuestionTypeEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, convQuestionType.Memo);
}
objvQuestionTypeEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQuestionTypeEN.dicFldComparisonOp.ContainsKey(convQuestionType.Memo) == false)
{
objvQuestionTypeEN.dicFldComparisonOp.Add(convQuestionType.Memo, strComparisonOp);
}
else
{
objvQuestionTypeEN.dicFldComparisonOp[convQuestionType.Memo] = strComparisonOp;
}
}
return objvQuestionTypeEN;
	}

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CopyObj)
 /// </summary>
 /// <param name = "objvQuestionTypeENS">源对象</param>
 /// <param name = "objvQuestionTypeENT">目标对象</param>
 public static void CopyTo(this clsvQuestionTypeEN objvQuestionTypeENS, clsvQuestionTypeEN objvQuestionTypeENT)
{
try
{
objvQuestionTypeENT.QuestionTypeId = objvQuestionTypeENS.QuestionTypeId; //题目类型Id
objvQuestionTypeENT.QuestionTypeName = objvQuestionTypeENS.QuestionTypeName; //题目类型名
objvQuestionTypeENT.DefaAnswerModeId = objvQuestionTypeENS.DefaAnswerModeId; //默认答案模式Id
objvQuestionTypeENT.AnswerModeName = objvQuestionTypeENS.AnswerModeName; //答案模式名称
objvQuestionTypeENT.DefaAnswerTypeId = objvQuestionTypeENS.DefaAnswerTypeId; //默认答案类型Id
objvQuestionTypeENT.AnswerTypeName = objvQuestionTypeENS.AnswerTypeName; //答案类型名
objvQuestionTypeENT.OrderNum = objvQuestionTypeENS.OrderNum; //序号
objvQuestionTypeENT.IsUse = objvQuestionTypeENS.IsUse; //是否使用
objvQuestionTypeENT.UpdDate = objvQuestionTypeENS.UpdDate; //修改日期
objvQuestionTypeENT.UpdUser = objvQuestionTypeENS.UpdUser; //修改人
objvQuestionTypeENT.Memo = objvQuestionTypeENS.Memo; //备注
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
 /// <param name = "objvQuestionTypeENS">源对象</param>
 /// <returns>目标对象=>clsvQuestionTypeEN:objvQuestionTypeENT</returns>
 public static clsvQuestionTypeEN CopyTo(this clsvQuestionTypeEN objvQuestionTypeENS)
{
try
{
 clsvQuestionTypeEN objvQuestionTypeENT = new clsvQuestionTypeEN()
{
QuestionTypeId = objvQuestionTypeENS.QuestionTypeId, //题目类型Id
QuestionTypeName = objvQuestionTypeENS.QuestionTypeName, //题目类型名
DefaAnswerModeId = objvQuestionTypeENS.DefaAnswerModeId, //默认答案模式Id
AnswerModeName = objvQuestionTypeENS.AnswerModeName, //答案模式名称
DefaAnswerTypeId = objvQuestionTypeENS.DefaAnswerTypeId, //默认答案类型Id
AnswerTypeName = objvQuestionTypeENS.AnswerTypeName, //答案类型名
OrderNum = objvQuestionTypeENS.OrderNum, //序号
IsUse = objvQuestionTypeENS.IsUse, //是否使用
UpdDate = objvQuestionTypeENS.UpdDate, //修改日期
UpdUser = objvQuestionTypeENS.UpdUser, //修改人
Memo = objvQuestionTypeENS.Memo, //备注
};
 return objvQuestionTypeENT;
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
public static void CheckProperty4Condition(this clsvQuestionTypeEN objvQuestionTypeEN)
{
 clsvQuestionTypeBL.vQuestionTypeDA.CheckProperty4Condition(objvQuestionTypeEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvQuestionTypeEN objvQuestionTypeCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvQuestionTypeCond.IsUpdated(convQuestionType.QuestionTypeId) == true)
{
string strComparisonOpQuestionTypeId = objvQuestionTypeCond.dicFldComparisonOp[convQuestionType.QuestionTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQuestionType.QuestionTypeId, objvQuestionTypeCond.QuestionTypeId, strComparisonOpQuestionTypeId);
}
if (objvQuestionTypeCond.IsUpdated(convQuestionType.QuestionTypeName) == true)
{
string strComparisonOpQuestionTypeName = objvQuestionTypeCond.dicFldComparisonOp[convQuestionType.QuestionTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQuestionType.QuestionTypeName, objvQuestionTypeCond.QuestionTypeName, strComparisonOpQuestionTypeName);
}
if (objvQuestionTypeCond.IsUpdated(convQuestionType.DefaAnswerModeId) == true)
{
string strComparisonOpDefaAnswerModeId = objvQuestionTypeCond.dicFldComparisonOp[convQuestionType.DefaAnswerModeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQuestionType.DefaAnswerModeId, objvQuestionTypeCond.DefaAnswerModeId, strComparisonOpDefaAnswerModeId);
}
if (objvQuestionTypeCond.IsUpdated(convQuestionType.AnswerModeName) == true)
{
string strComparisonOpAnswerModeName = objvQuestionTypeCond.dicFldComparisonOp[convQuestionType.AnswerModeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQuestionType.AnswerModeName, objvQuestionTypeCond.AnswerModeName, strComparisonOpAnswerModeName);
}
if (objvQuestionTypeCond.IsUpdated(convQuestionType.DefaAnswerTypeId) == true)
{
string strComparisonOpDefaAnswerTypeId = objvQuestionTypeCond.dicFldComparisonOp[convQuestionType.DefaAnswerTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQuestionType.DefaAnswerTypeId, objvQuestionTypeCond.DefaAnswerTypeId, strComparisonOpDefaAnswerTypeId);
}
if (objvQuestionTypeCond.IsUpdated(convQuestionType.AnswerTypeName) == true)
{
string strComparisonOpAnswerTypeName = objvQuestionTypeCond.dicFldComparisonOp[convQuestionType.AnswerTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQuestionType.AnswerTypeName, objvQuestionTypeCond.AnswerTypeName, strComparisonOpAnswerTypeName);
}
if (objvQuestionTypeCond.IsUpdated(convQuestionType.OrderNum) == true)
{
string strComparisonOpOrderNum = objvQuestionTypeCond.dicFldComparisonOp[convQuestionType.OrderNum];
strWhereCond += string.Format(" And {0} {2} {1}", convQuestionType.OrderNum, objvQuestionTypeCond.OrderNum, strComparisonOpOrderNum);
}
if (objvQuestionTypeCond.IsUpdated(convQuestionType.IsUse) == true)
{
if (objvQuestionTypeCond.IsUse == true)
{
strWhereCond += string.Format(" And {0} = '1'", convQuestionType.IsUse);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convQuestionType.IsUse);
}
}
if (objvQuestionTypeCond.IsUpdated(convQuestionType.UpdDate) == true)
{
string strComparisonOpUpdDate = objvQuestionTypeCond.dicFldComparisonOp[convQuestionType.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQuestionType.UpdDate, objvQuestionTypeCond.UpdDate, strComparisonOpUpdDate);
}
if (objvQuestionTypeCond.IsUpdated(convQuestionType.UpdUser) == true)
{
string strComparisonOpUpdUser = objvQuestionTypeCond.dicFldComparisonOp[convQuestionType.UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQuestionType.UpdUser, objvQuestionTypeCond.UpdUser, strComparisonOpUpdUser);
}
if (objvQuestionTypeCond.IsUpdated(convQuestionType.Memo) == true)
{
string strComparisonOpMemo = objvQuestionTypeCond.dicFldComparisonOp[convQuestionType.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQuestionType.Memo, objvQuestionTypeCond.Memo, strComparisonOpMemo);
}
 return strWhereCond;
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_vQuestionType
{
public virtual bool UpdRelaTabDate(string strQuestionTypeId, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// v题目类型(vQuestionType)
 /// 数据源类型:视图
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsvQuestionTypeBL
{
public static RelatedActions_vQuestionType relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsvQuestionTypeDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsvQuestionTypeDA vQuestionTypeDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsvQuestionTypeDA();
}
return uniqueInstance;
}
}

 /// <summary>
 /// 类的构造函数
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ClassConstructor1)
 /// </summary>
 public clsvQuestionTypeBL()
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
if (string.IsNullOrEmpty(clsvQuestionTypeEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvQuestionTypeEN._ConnectString);
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
public static DataTable GetDataTable_vQuestionType(string strWhereCond)
{
DataTable objDT;
try
{
objDT = vQuestionTypeDA.GetDataTable_vQuestionType(strWhereCond);
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
objDT = vQuestionTypeDA.GetDataTable(strWhereCond);
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
objDT = vQuestionTypeDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = vQuestionTypeDA.GetDataTable(strWhereCond, strTabName);
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
objDT = vQuestionTypeDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = vQuestionTypeDA.GetDataTable_Top(objTopPara);
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
objDT = vQuestionTypeDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = vQuestionTypeDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = vQuestionTypeDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
 /// <param name = "arrQuestionTypeIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static List<clsvQuestionTypeEN> GetObjLstByQuestionTypeIdLst(List<string> arrQuestionTypeIdLst)
{
List<clsvQuestionTypeEN> arrObjLst = new List<clsvQuestionTypeEN>(); 
System.Data.DataTable objDT; 
 string strSqlConditionStr = clsArray.GetSqlInStrByArray(arrQuestionTypeIdLst, true);
 string strWhereCond = string.Format("QuestionTypeId in ({0})", strSqlConditionStr);
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvQuestionTypeEN objvQuestionTypeEN = new clsvQuestionTypeEN();
try
{
objvQuestionTypeEN.QuestionTypeId = objRow[convQuestionType.QuestionTypeId].ToString().Trim(); //题目类型Id
objvQuestionTypeEN.QuestionTypeName = objRow[convQuestionType.QuestionTypeName] == DBNull.Value ? null : objRow[convQuestionType.QuestionTypeName].ToString().Trim(); //题目类型名
objvQuestionTypeEN.DefaAnswerModeId = objRow[convQuestionType.DefaAnswerModeId] == DBNull.Value ? null : objRow[convQuestionType.DefaAnswerModeId].ToString().Trim(); //默认答案模式Id
objvQuestionTypeEN.AnswerModeName = objRow[convQuestionType.AnswerModeName] == DBNull.Value ? null : objRow[convQuestionType.AnswerModeName].ToString().Trim(); //答案模式名称
objvQuestionTypeEN.DefaAnswerTypeId = objRow[convQuestionType.DefaAnswerTypeId] == DBNull.Value ? null : objRow[convQuestionType.DefaAnswerTypeId].ToString().Trim(); //默认答案类型Id
objvQuestionTypeEN.AnswerTypeName = objRow[convQuestionType.AnswerTypeName] == DBNull.Value ? null : objRow[convQuestionType.AnswerTypeName].ToString().Trim(); //答案类型名
objvQuestionTypeEN.OrderNum = objRow[convQuestionType.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convQuestionType.OrderNum].ToString().Trim()); //序号
objvQuestionTypeEN.IsUse = clsEntityBase2.TransNullToBool_S(objRow[convQuestionType.IsUse].ToString().Trim()); //是否使用
objvQuestionTypeEN.UpdDate = objRow[convQuestionType.UpdDate].ToString().Trim(); //修改日期
objvQuestionTypeEN.UpdUser = objRow[convQuestionType.UpdUser].ToString().Trim(); //修改人
objvQuestionTypeEN.Memo = objRow[convQuestionType.Memo] == DBNull.Value ? null : objRow[convQuestionType.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvQuestionTypeEN.QuestionTypeId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvQuestionTypeEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrQuestionTypeIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsvQuestionTypeEN> GetObjLstByQuestionTypeIdLstCache(List<string> arrQuestionTypeIdLst)
{
string strKey = string.Format("{0}", clsvQuestionTypeEN._CurrTabName);
List<clsvQuestionTypeEN> arrvQuestionTypeObjLstCache = GetObjLstCache();
IEnumerable <clsvQuestionTypeEN> arrvQuestionTypeObjLst_Sel =
arrvQuestionTypeObjLstCache
.Where(x => arrQuestionTypeIdLst.Contains(x.QuestionTypeId));
return arrvQuestionTypeObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvQuestionTypeEN> GetObjLst(string strWhereCond)
{
List<clsvQuestionTypeEN> arrObjLst = new List<clsvQuestionTypeEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvQuestionTypeEN objvQuestionTypeEN = new clsvQuestionTypeEN();
try
{
objvQuestionTypeEN.QuestionTypeId = objRow[convQuestionType.QuestionTypeId].ToString().Trim(); //题目类型Id
objvQuestionTypeEN.QuestionTypeName = objRow[convQuestionType.QuestionTypeName] == DBNull.Value ? null : objRow[convQuestionType.QuestionTypeName].ToString().Trim(); //题目类型名
objvQuestionTypeEN.DefaAnswerModeId = objRow[convQuestionType.DefaAnswerModeId] == DBNull.Value ? null : objRow[convQuestionType.DefaAnswerModeId].ToString().Trim(); //默认答案模式Id
objvQuestionTypeEN.AnswerModeName = objRow[convQuestionType.AnswerModeName] == DBNull.Value ? null : objRow[convQuestionType.AnswerModeName].ToString().Trim(); //答案模式名称
objvQuestionTypeEN.DefaAnswerTypeId = objRow[convQuestionType.DefaAnswerTypeId] == DBNull.Value ? null : objRow[convQuestionType.DefaAnswerTypeId].ToString().Trim(); //默认答案类型Id
objvQuestionTypeEN.AnswerTypeName = objRow[convQuestionType.AnswerTypeName] == DBNull.Value ? null : objRow[convQuestionType.AnswerTypeName].ToString().Trim(); //答案类型名
objvQuestionTypeEN.OrderNum = objRow[convQuestionType.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convQuestionType.OrderNum].ToString().Trim()); //序号
objvQuestionTypeEN.IsUse = clsEntityBase2.TransNullToBool_S(objRow[convQuestionType.IsUse].ToString().Trim()); //是否使用
objvQuestionTypeEN.UpdDate = objRow[convQuestionType.UpdDate].ToString().Trim(); //修改日期
objvQuestionTypeEN.UpdUser = objRow[convQuestionType.UpdUser].ToString().Trim(); //修改人
objvQuestionTypeEN.Memo = objRow[convQuestionType.Memo] == DBNull.Value ? null : objRow[convQuestionType.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvQuestionTypeEN.QuestionTypeId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvQuestionTypeEN);
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
public static List<clsvQuestionTypeEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsvQuestionTypeEN> arrObjLst = new List<clsvQuestionTypeEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvQuestionTypeEN objvQuestionTypeEN = new clsvQuestionTypeEN();
try
{
objvQuestionTypeEN.QuestionTypeId = objRow[convQuestionType.QuestionTypeId].ToString().Trim(); //题目类型Id
objvQuestionTypeEN.QuestionTypeName = objRow[convQuestionType.QuestionTypeName] == DBNull.Value ? null : objRow[convQuestionType.QuestionTypeName].ToString().Trim(); //题目类型名
objvQuestionTypeEN.DefaAnswerModeId = objRow[convQuestionType.DefaAnswerModeId] == DBNull.Value ? null : objRow[convQuestionType.DefaAnswerModeId].ToString().Trim(); //默认答案模式Id
objvQuestionTypeEN.AnswerModeName = objRow[convQuestionType.AnswerModeName] == DBNull.Value ? null : objRow[convQuestionType.AnswerModeName].ToString().Trim(); //答案模式名称
objvQuestionTypeEN.DefaAnswerTypeId = objRow[convQuestionType.DefaAnswerTypeId] == DBNull.Value ? null : objRow[convQuestionType.DefaAnswerTypeId].ToString().Trim(); //默认答案类型Id
objvQuestionTypeEN.AnswerTypeName = objRow[convQuestionType.AnswerTypeName] == DBNull.Value ? null : objRow[convQuestionType.AnswerTypeName].ToString().Trim(); //答案类型名
objvQuestionTypeEN.OrderNum = objRow[convQuestionType.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convQuestionType.OrderNum].ToString().Trim()); //序号
objvQuestionTypeEN.IsUse = clsEntityBase2.TransNullToBool_S(objRow[convQuestionType.IsUse].ToString().Trim()); //是否使用
objvQuestionTypeEN.UpdDate = objRow[convQuestionType.UpdDate].ToString().Trim(); //修改日期
objvQuestionTypeEN.UpdUser = objRow[convQuestionType.UpdUser].ToString().Trim(); //修改人
objvQuestionTypeEN.Memo = objRow[convQuestionType.Memo] == DBNull.Value ? null : objRow[convQuestionType.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvQuestionTypeEN.QuestionTypeId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvQuestionTypeEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objvQuestionTypeCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsvQuestionTypeEN> GetSubObjLstCache(clsvQuestionTypeEN objvQuestionTypeCond)
{
List<clsvQuestionTypeEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsvQuestionTypeEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convQuestionType.AttributeName)
{
if (objvQuestionTypeCond.IsUpdated(strFldName) == false) continue;
if (objvQuestionTypeCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvQuestionTypeCond[strFldName].ToString());
}
else
{
if (objvQuestionTypeCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvQuestionTypeCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvQuestionTypeCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvQuestionTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvQuestionTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvQuestionTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvQuestionTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvQuestionTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvQuestionTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvQuestionTypeCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvQuestionTypeCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvQuestionTypeCond[strFldName]));
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
public static List<clsvQuestionTypeEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsvQuestionTypeEN> arrObjLst = new List<clsvQuestionTypeEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvQuestionTypeEN objvQuestionTypeEN = new clsvQuestionTypeEN();
try
{
objvQuestionTypeEN.QuestionTypeId = objRow[convQuestionType.QuestionTypeId].ToString().Trim(); //题目类型Id
objvQuestionTypeEN.QuestionTypeName = objRow[convQuestionType.QuestionTypeName] == DBNull.Value ? null : objRow[convQuestionType.QuestionTypeName].ToString().Trim(); //题目类型名
objvQuestionTypeEN.DefaAnswerModeId = objRow[convQuestionType.DefaAnswerModeId] == DBNull.Value ? null : objRow[convQuestionType.DefaAnswerModeId].ToString().Trim(); //默认答案模式Id
objvQuestionTypeEN.AnswerModeName = objRow[convQuestionType.AnswerModeName] == DBNull.Value ? null : objRow[convQuestionType.AnswerModeName].ToString().Trim(); //答案模式名称
objvQuestionTypeEN.DefaAnswerTypeId = objRow[convQuestionType.DefaAnswerTypeId] == DBNull.Value ? null : objRow[convQuestionType.DefaAnswerTypeId].ToString().Trim(); //默认答案类型Id
objvQuestionTypeEN.AnswerTypeName = objRow[convQuestionType.AnswerTypeName] == DBNull.Value ? null : objRow[convQuestionType.AnswerTypeName].ToString().Trim(); //答案类型名
objvQuestionTypeEN.OrderNum = objRow[convQuestionType.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convQuestionType.OrderNum].ToString().Trim()); //序号
objvQuestionTypeEN.IsUse = clsEntityBase2.TransNullToBool_S(objRow[convQuestionType.IsUse].ToString().Trim()); //是否使用
objvQuestionTypeEN.UpdDate = objRow[convQuestionType.UpdDate].ToString().Trim(); //修改日期
objvQuestionTypeEN.UpdUser = objRow[convQuestionType.UpdUser].ToString().Trim(); //修改人
objvQuestionTypeEN.Memo = objRow[convQuestionType.Memo] == DBNull.Value ? null : objRow[convQuestionType.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvQuestionTypeEN.QuestionTypeId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvQuestionTypeEN);
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
public static List<clsvQuestionTypeEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsvQuestionTypeEN> arrObjLst = new List<clsvQuestionTypeEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvQuestionTypeEN objvQuestionTypeEN = new clsvQuestionTypeEN();
try
{
objvQuestionTypeEN.QuestionTypeId = objRow[convQuestionType.QuestionTypeId].ToString().Trim(); //题目类型Id
objvQuestionTypeEN.QuestionTypeName = objRow[convQuestionType.QuestionTypeName] == DBNull.Value ? null : objRow[convQuestionType.QuestionTypeName].ToString().Trim(); //题目类型名
objvQuestionTypeEN.DefaAnswerModeId = objRow[convQuestionType.DefaAnswerModeId] == DBNull.Value ? null : objRow[convQuestionType.DefaAnswerModeId].ToString().Trim(); //默认答案模式Id
objvQuestionTypeEN.AnswerModeName = objRow[convQuestionType.AnswerModeName] == DBNull.Value ? null : objRow[convQuestionType.AnswerModeName].ToString().Trim(); //答案模式名称
objvQuestionTypeEN.DefaAnswerTypeId = objRow[convQuestionType.DefaAnswerTypeId] == DBNull.Value ? null : objRow[convQuestionType.DefaAnswerTypeId].ToString().Trim(); //默认答案类型Id
objvQuestionTypeEN.AnswerTypeName = objRow[convQuestionType.AnswerTypeName] == DBNull.Value ? null : objRow[convQuestionType.AnswerTypeName].ToString().Trim(); //答案类型名
objvQuestionTypeEN.OrderNum = objRow[convQuestionType.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convQuestionType.OrderNum].ToString().Trim()); //序号
objvQuestionTypeEN.IsUse = clsEntityBase2.TransNullToBool_S(objRow[convQuestionType.IsUse].ToString().Trim()); //是否使用
objvQuestionTypeEN.UpdDate = objRow[convQuestionType.UpdDate].ToString().Trim(); //修改日期
objvQuestionTypeEN.UpdUser = objRow[convQuestionType.UpdUser].ToString().Trim(); //修改人
objvQuestionTypeEN.Memo = objRow[convQuestionType.Memo] == DBNull.Value ? null : objRow[convQuestionType.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvQuestionTypeEN.QuestionTypeId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvQuestionTypeEN);
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
List<clsvQuestionTypeEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsvQuestionTypeEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsvQuestionTypeEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsvQuestionTypeEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsvQuestionTypeEN> arrObjLst = new List<clsvQuestionTypeEN>(); 
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
	clsvQuestionTypeEN objvQuestionTypeEN = new clsvQuestionTypeEN();
try
{
objvQuestionTypeEN.QuestionTypeId = objRow[convQuestionType.QuestionTypeId].ToString().Trim(); //题目类型Id
objvQuestionTypeEN.QuestionTypeName = objRow[convQuestionType.QuestionTypeName] == DBNull.Value ? null : objRow[convQuestionType.QuestionTypeName].ToString().Trim(); //题目类型名
objvQuestionTypeEN.DefaAnswerModeId = objRow[convQuestionType.DefaAnswerModeId] == DBNull.Value ? null : objRow[convQuestionType.DefaAnswerModeId].ToString().Trim(); //默认答案模式Id
objvQuestionTypeEN.AnswerModeName = objRow[convQuestionType.AnswerModeName] == DBNull.Value ? null : objRow[convQuestionType.AnswerModeName].ToString().Trim(); //答案模式名称
objvQuestionTypeEN.DefaAnswerTypeId = objRow[convQuestionType.DefaAnswerTypeId] == DBNull.Value ? null : objRow[convQuestionType.DefaAnswerTypeId].ToString().Trim(); //默认答案类型Id
objvQuestionTypeEN.AnswerTypeName = objRow[convQuestionType.AnswerTypeName] == DBNull.Value ? null : objRow[convQuestionType.AnswerTypeName].ToString().Trim(); //答案类型名
objvQuestionTypeEN.OrderNum = objRow[convQuestionType.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convQuestionType.OrderNum].ToString().Trim()); //序号
objvQuestionTypeEN.IsUse = clsEntityBase2.TransNullToBool_S(objRow[convQuestionType.IsUse].ToString().Trim()); //是否使用
objvQuestionTypeEN.UpdDate = objRow[convQuestionType.UpdDate].ToString().Trim(); //修改日期
objvQuestionTypeEN.UpdUser = objRow[convQuestionType.UpdUser].ToString().Trim(); //修改人
objvQuestionTypeEN.Memo = objRow[convQuestionType.Memo] == DBNull.Value ? null : objRow[convQuestionType.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvQuestionTypeEN.QuestionTypeId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvQuestionTypeEN);
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
public static List<clsvQuestionTypeEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsvQuestionTypeEN> arrObjLst = new List<clsvQuestionTypeEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvQuestionTypeEN objvQuestionTypeEN = new clsvQuestionTypeEN();
try
{
objvQuestionTypeEN.QuestionTypeId = objRow[convQuestionType.QuestionTypeId].ToString().Trim(); //题目类型Id
objvQuestionTypeEN.QuestionTypeName = objRow[convQuestionType.QuestionTypeName] == DBNull.Value ? null : objRow[convQuestionType.QuestionTypeName].ToString().Trim(); //题目类型名
objvQuestionTypeEN.DefaAnswerModeId = objRow[convQuestionType.DefaAnswerModeId] == DBNull.Value ? null : objRow[convQuestionType.DefaAnswerModeId].ToString().Trim(); //默认答案模式Id
objvQuestionTypeEN.AnswerModeName = objRow[convQuestionType.AnswerModeName] == DBNull.Value ? null : objRow[convQuestionType.AnswerModeName].ToString().Trim(); //答案模式名称
objvQuestionTypeEN.DefaAnswerTypeId = objRow[convQuestionType.DefaAnswerTypeId] == DBNull.Value ? null : objRow[convQuestionType.DefaAnswerTypeId].ToString().Trim(); //默认答案类型Id
objvQuestionTypeEN.AnswerTypeName = objRow[convQuestionType.AnswerTypeName] == DBNull.Value ? null : objRow[convQuestionType.AnswerTypeName].ToString().Trim(); //答案类型名
objvQuestionTypeEN.OrderNum = objRow[convQuestionType.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convQuestionType.OrderNum].ToString().Trim()); //序号
objvQuestionTypeEN.IsUse = clsEntityBase2.TransNullToBool_S(objRow[convQuestionType.IsUse].ToString().Trim()); //是否使用
objvQuestionTypeEN.UpdDate = objRow[convQuestionType.UpdDate].ToString().Trim(); //修改日期
objvQuestionTypeEN.UpdUser = objRow[convQuestionType.UpdUser].ToString().Trim(); //修改人
objvQuestionTypeEN.Memo = objRow[convQuestionType.Memo] == DBNull.Value ? null : objRow[convQuestionType.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvQuestionTypeEN.QuestionTypeId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvQuestionTypeEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsvQuestionTypeEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsvQuestionTypeEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsvQuestionTypeEN> arrObjLst = new List<clsvQuestionTypeEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvQuestionTypeEN objvQuestionTypeEN = new clsvQuestionTypeEN();
try
{
objvQuestionTypeEN.QuestionTypeId = objRow[convQuestionType.QuestionTypeId].ToString().Trim(); //题目类型Id
objvQuestionTypeEN.QuestionTypeName = objRow[convQuestionType.QuestionTypeName] == DBNull.Value ? null : objRow[convQuestionType.QuestionTypeName].ToString().Trim(); //题目类型名
objvQuestionTypeEN.DefaAnswerModeId = objRow[convQuestionType.DefaAnswerModeId] == DBNull.Value ? null : objRow[convQuestionType.DefaAnswerModeId].ToString().Trim(); //默认答案模式Id
objvQuestionTypeEN.AnswerModeName = objRow[convQuestionType.AnswerModeName] == DBNull.Value ? null : objRow[convQuestionType.AnswerModeName].ToString().Trim(); //答案模式名称
objvQuestionTypeEN.DefaAnswerTypeId = objRow[convQuestionType.DefaAnswerTypeId] == DBNull.Value ? null : objRow[convQuestionType.DefaAnswerTypeId].ToString().Trim(); //默认答案类型Id
objvQuestionTypeEN.AnswerTypeName = objRow[convQuestionType.AnswerTypeName] == DBNull.Value ? null : objRow[convQuestionType.AnswerTypeName].ToString().Trim(); //答案类型名
objvQuestionTypeEN.OrderNum = objRow[convQuestionType.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convQuestionType.OrderNum].ToString().Trim()); //序号
objvQuestionTypeEN.IsUse = clsEntityBase2.TransNullToBool_S(objRow[convQuestionType.IsUse].ToString().Trim()); //是否使用
objvQuestionTypeEN.UpdDate = objRow[convQuestionType.UpdDate].ToString().Trim(); //修改日期
objvQuestionTypeEN.UpdUser = objRow[convQuestionType.UpdUser].ToString().Trim(); //修改人
objvQuestionTypeEN.Memo = objRow[convQuestionType.Memo] == DBNull.Value ? null : objRow[convQuestionType.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvQuestionTypeEN.QuestionTypeId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvQuestionTypeEN);
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
public static List<clsvQuestionTypeEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsvQuestionTypeEN> arrObjLst = new List<clsvQuestionTypeEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvQuestionTypeEN objvQuestionTypeEN = new clsvQuestionTypeEN();
try
{
objvQuestionTypeEN.QuestionTypeId = objRow[convQuestionType.QuestionTypeId].ToString().Trim(); //题目类型Id
objvQuestionTypeEN.QuestionTypeName = objRow[convQuestionType.QuestionTypeName] == DBNull.Value ? null : objRow[convQuestionType.QuestionTypeName].ToString().Trim(); //题目类型名
objvQuestionTypeEN.DefaAnswerModeId = objRow[convQuestionType.DefaAnswerModeId] == DBNull.Value ? null : objRow[convQuestionType.DefaAnswerModeId].ToString().Trim(); //默认答案模式Id
objvQuestionTypeEN.AnswerModeName = objRow[convQuestionType.AnswerModeName] == DBNull.Value ? null : objRow[convQuestionType.AnswerModeName].ToString().Trim(); //答案模式名称
objvQuestionTypeEN.DefaAnswerTypeId = objRow[convQuestionType.DefaAnswerTypeId] == DBNull.Value ? null : objRow[convQuestionType.DefaAnswerTypeId].ToString().Trim(); //默认答案类型Id
objvQuestionTypeEN.AnswerTypeName = objRow[convQuestionType.AnswerTypeName] == DBNull.Value ? null : objRow[convQuestionType.AnswerTypeName].ToString().Trim(); //答案类型名
objvQuestionTypeEN.OrderNum = objRow[convQuestionType.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convQuestionType.OrderNum].ToString().Trim()); //序号
objvQuestionTypeEN.IsUse = clsEntityBase2.TransNullToBool_S(objRow[convQuestionType.IsUse].ToString().Trim()); //是否使用
objvQuestionTypeEN.UpdDate = objRow[convQuestionType.UpdDate].ToString().Trim(); //修改日期
objvQuestionTypeEN.UpdUser = objRow[convQuestionType.UpdUser].ToString().Trim(); //修改人
objvQuestionTypeEN.Memo = objRow[convQuestionType.Memo] == DBNull.Value ? null : objRow[convQuestionType.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvQuestionTypeEN.QuestionTypeId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvQuestionTypeEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsvQuestionTypeEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsvQuestionTypeEN> arrObjLst = new List<clsvQuestionTypeEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvQuestionTypeEN objvQuestionTypeEN = new clsvQuestionTypeEN();
try
{
objvQuestionTypeEN.QuestionTypeId = objRow[convQuestionType.QuestionTypeId].ToString().Trim(); //题目类型Id
objvQuestionTypeEN.QuestionTypeName = objRow[convQuestionType.QuestionTypeName] == DBNull.Value ? null : objRow[convQuestionType.QuestionTypeName].ToString().Trim(); //题目类型名
objvQuestionTypeEN.DefaAnswerModeId = objRow[convQuestionType.DefaAnswerModeId] == DBNull.Value ? null : objRow[convQuestionType.DefaAnswerModeId].ToString().Trim(); //默认答案模式Id
objvQuestionTypeEN.AnswerModeName = objRow[convQuestionType.AnswerModeName] == DBNull.Value ? null : objRow[convQuestionType.AnswerModeName].ToString().Trim(); //答案模式名称
objvQuestionTypeEN.DefaAnswerTypeId = objRow[convQuestionType.DefaAnswerTypeId] == DBNull.Value ? null : objRow[convQuestionType.DefaAnswerTypeId].ToString().Trim(); //默认答案类型Id
objvQuestionTypeEN.AnswerTypeName = objRow[convQuestionType.AnswerTypeName] == DBNull.Value ? null : objRow[convQuestionType.AnswerTypeName].ToString().Trim(); //答案类型名
objvQuestionTypeEN.OrderNum = objRow[convQuestionType.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convQuestionType.OrderNum].ToString().Trim()); //序号
objvQuestionTypeEN.IsUse = clsEntityBase2.TransNullToBool_S(objRow[convQuestionType.IsUse].ToString().Trim()); //是否使用
objvQuestionTypeEN.UpdDate = objRow[convQuestionType.UpdDate].ToString().Trim(); //修改日期
objvQuestionTypeEN.UpdUser = objRow[convQuestionType.UpdUser].ToString().Trim(); //修改人
objvQuestionTypeEN.Memo = objRow[convQuestionType.Memo] == DBNull.Value ? null : objRow[convQuestionType.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvQuestionTypeEN.QuestionTypeId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvQuestionTypeEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objvQuestionTypeEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetvQuestionType(ref clsvQuestionTypeEN objvQuestionTypeEN)
{
bool bolResult = vQuestionTypeDA.GetvQuestionType(ref objvQuestionTypeEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "strQuestionTypeId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvQuestionTypeEN GetObjByQuestionTypeId(string strQuestionTypeId)
{
if (strQuestionTypeId.IndexOf(' ') >=0)
{
var strMsg = string.Format("(errid:Busi000079)在表中,关键字[strQuestionTypeId]中不能有空格!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
if (string.IsNullOrEmpty(strQuestionTypeId) == true)
{
var strMsg = string.Format("(errid:Busi000020)在表中,关键字[strQuestionTypeId]不能为空!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
clsvQuestionTypeEN objvQuestionTypeEN = vQuestionTypeDA.GetObjByQuestionTypeId(strQuestionTypeId);
return objvQuestionTypeEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsvQuestionTypeEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsvQuestionTypeEN objvQuestionTypeEN = vQuestionTypeDA.GetFirstObj(strWhereCond);
 return objvQuestionTypeEN;
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
public static clsvQuestionTypeEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsvQuestionTypeEN objvQuestionTypeEN = vQuestionTypeDA.GetObjByDataRow(objRow);
 return objvQuestionTypeEN;
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
public static clsvQuestionTypeEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsvQuestionTypeEN objvQuestionTypeEN = vQuestionTypeDA.GetObjByDataRow(objRow);
 return objvQuestionTypeEN;
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
 /// <param name = "strQuestionTypeId">所给的关键字</param>
 /// <param name = "lstvQuestionTypeObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvQuestionTypeEN GetObjByQuestionTypeIdFromList(string strQuestionTypeId, List<clsvQuestionTypeEN> lstvQuestionTypeObjLst)
{
foreach (clsvQuestionTypeEN objvQuestionTypeEN in lstvQuestionTypeObjLst)
{
if (objvQuestionTypeEN.QuestionTypeId == strQuestionTypeId)
{
return objvQuestionTypeEN;
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
 string strMaxQuestionTypeId;
 try
 {
 strMaxQuestionTypeId = clsvQuestionTypeDA.GetMaxStrId();
 return strMaxQuestionTypeId;
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
 string strQuestionTypeId;
 try
 {
 strQuestionTypeId = new clsvQuestionTypeDA().GetFirstID(strWhereCond);
 return strQuestionTypeId;
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
 arrList = vQuestionTypeDA.GetID(strWhereCond);
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
bool bolIsExist = vQuestionTypeDA.IsExistCondRec(strWhereCond);
return bolIsExist;
}

 /// <summary>
 /// 判断当前表中是否存在给定关键字值的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExist)
 /// </summary>
 /// <param name = "strQuestionTypeId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public static bool IsExist(string strQuestionTypeId)
{
if (string.IsNullOrEmpty(strQuestionTypeId) == true)
{
var strMsg = string.Format("(errid:Busi000027)在表中,关键字[strQuestionTypeId]不能为空!!(from {0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
//检测记录是否存在
bool bolIsExist = vQuestionTypeDA.IsExist(strQuestionTypeId);
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
 bolIsExist = clsvQuestionTypeDA.IsExistTable();
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
 bolIsExist = vQuestionTypeDA.IsExistTable(strTabName);
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
 /// <param name = "objvQuestionTypeENS">源对象</param>
 /// <param name = "objvQuestionTypeENT">目标对象</param>
 public static void CopyTo(clsvQuestionTypeEN objvQuestionTypeENS, clsvQuestionTypeEN objvQuestionTypeENT)
{
try
{
objvQuestionTypeENT.QuestionTypeId = objvQuestionTypeENS.QuestionTypeId; //题目类型Id
objvQuestionTypeENT.QuestionTypeName = objvQuestionTypeENS.QuestionTypeName; //题目类型名
objvQuestionTypeENT.DefaAnswerModeId = objvQuestionTypeENS.DefaAnswerModeId; //默认答案模式Id
objvQuestionTypeENT.AnswerModeName = objvQuestionTypeENS.AnswerModeName; //答案模式名称
objvQuestionTypeENT.DefaAnswerTypeId = objvQuestionTypeENS.DefaAnswerTypeId; //默认答案类型Id
objvQuestionTypeENT.AnswerTypeName = objvQuestionTypeENS.AnswerTypeName; //答案类型名
objvQuestionTypeENT.OrderNum = objvQuestionTypeENS.OrderNum; //序号
objvQuestionTypeENT.IsUse = objvQuestionTypeENS.IsUse; //是否使用
objvQuestionTypeENT.UpdDate = objvQuestionTypeENS.UpdDate; //修改日期
objvQuestionTypeENT.UpdUser = objvQuestionTypeENS.UpdUser; //修改人
objvQuestionTypeENT.Memo = objvQuestionTypeENS.Memo; //备注
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
 /// <param name = "objvQuestionTypeEN">源简化对象</param>
 public static void SetUpdFlag(clsvQuestionTypeEN objvQuestionTypeEN)
{
try
{
objvQuestionTypeEN.ClearUpdateState();
   string strsfUpdFldSetStr = objvQuestionTypeEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(convQuestionType.QuestionTypeId, new clsStrCompareIgnoreCase())  ==  true)
{
objvQuestionTypeEN.QuestionTypeId = objvQuestionTypeEN.QuestionTypeId; //题目类型Id
}
if (arrFldSet.Contains(convQuestionType.QuestionTypeName, new clsStrCompareIgnoreCase())  ==  true)
{
objvQuestionTypeEN.QuestionTypeName = objvQuestionTypeEN.QuestionTypeName == "[null]" ? null :  objvQuestionTypeEN.QuestionTypeName; //题目类型名
}
if (arrFldSet.Contains(convQuestionType.DefaAnswerModeId, new clsStrCompareIgnoreCase())  ==  true)
{
objvQuestionTypeEN.DefaAnswerModeId = objvQuestionTypeEN.DefaAnswerModeId == "[null]" ? null :  objvQuestionTypeEN.DefaAnswerModeId; //默认答案模式Id
}
if (arrFldSet.Contains(convQuestionType.AnswerModeName, new clsStrCompareIgnoreCase())  ==  true)
{
objvQuestionTypeEN.AnswerModeName = objvQuestionTypeEN.AnswerModeName == "[null]" ? null :  objvQuestionTypeEN.AnswerModeName; //答案模式名称
}
if (arrFldSet.Contains(convQuestionType.DefaAnswerTypeId, new clsStrCompareIgnoreCase())  ==  true)
{
objvQuestionTypeEN.DefaAnswerTypeId = objvQuestionTypeEN.DefaAnswerTypeId == "[null]" ? null :  objvQuestionTypeEN.DefaAnswerTypeId; //默认答案类型Id
}
if (arrFldSet.Contains(convQuestionType.AnswerTypeName, new clsStrCompareIgnoreCase())  ==  true)
{
objvQuestionTypeEN.AnswerTypeName = objvQuestionTypeEN.AnswerTypeName == "[null]" ? null :  objvQuestionTypeEN.AnswerTypeName; //答案类型名
}
if (arrFldSet.Contains(convQuestionType.OrderNum, new clsStrCompareIgnoreCase())  ==  true)
{
objvQuestionTypeEN.OrderNum = objvQuestionTypeEN.OrderNum; //序号
}
if (arrFldSet.Contains(convQuestionType.IsUse, new clsStrCompareIgnoreCase())  ==  true)
{
objvQuestionTypeEN.IsUse = objvQuestionTypeEN.IsUse; //是否使用
}
if (arrFldSet.Contains(convQuestionType.UpdDate, new clsStrCompareIgnoreCase())  ==  true)
{
objvQuestionTypeEN.UpdDate = objvQuestionTypeEN.UpdDate; //修改日期
}
if (arrFldSet.Contains(convQuestionType.UpdUser, new clsStrCompareIgnoreCase())  ==  true)
{
objvQuestionTypeEN.UpdUser = objvQuestionTypeEN.UpdUser; //修改人
}
if (arrFldSet.Contains(convQuestionType.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objvQuestionTypeEN.Memo = objvQuestionTypeEN.Memo == "[null]" ? null :  objvQuestionTypeEN.Memo; //备注
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
 /// <param name = "objvQuestionTypeEN">源简化对象</param>
 public static void AccessFldValueNull(clsvQuestionTypeEN objvQuestionTypeEN)
{
try
{
if (objvQuestionTypeEN.QuestionTypeName == "[null]") objvQuestionTypeEN.QuestionTypeName = null; //题目类型名
if (objvQuestionTypeEN.DefaAnswerModeId == "[null]") objvQuestionTypeEN.DefaAnswerModeId = null; //默认答案模式Id
if (objvQuestionTypeEN.AnswerModeName == "[null]") objvQuestionTypeEN.AnswerModeName = null; //答案模式名称
if (objvQuestionTypeEN.DefaAnswerTypeId == "[null]") objvQuestionTypeEN.DefaAnswerTypeId = null; //默认答案类型Id
if (objvQuestionTypeEN.AnswerTypeName == "[null]") objvQuestionTypeEN.AnswerTypeName = null; //答案类型名
if (objvQuestionTypeEN.Memo == "[null]") objvQuestionTypeEN.Memo = null; //备注
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
public static void CheckProperty4Condition(clsvQuestionTypeEN objvQuestionTypeEN)
{
 vQuestionTypeDA.CheckProperty4Condition(objvQuestionTypeEN);
 }


 #endregion 检查对象属性


 #region 绑定下拉框

 /// <summary>
 /// 绑定基于Win的下拉框
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_TabFeature_ComboBoxBindFunction)
 /// </summary>
 /// <param name = "objComboBox">需要绑定当前表的下拉框</param>

public static void BindCbo_QuestionTypeId(System.Windows.Forms.ComboBox objComboBox )
{
//为数据源为表的下拉框设置内容
string strCondition = string.Format("1 =1 Order By {0}", convQuestionType.QuestionTypeId); 
List<clsvQuestionTypeEN> arrObjLst = clsvQuestionTypeBL.GetObjLst(strCondition);
//初始化一个对象列表
//插入第0项。在第0项中插入“请选择...”,为了方便用户,与WEB方式类似。
clsvQuestionTypeEN objvQuestionTypeEN = new clsvQuestionTypeEN()
{
QuestionTypeId = "0",
QuestionTypeName = "选[v题目类型]..."
};
arrObjLst.Insert(0, objvQuestionTypeEN);
//设置下拉框的数据源、以及设置值项、显示项
objComboBox.ValueMember = convQuestionType.QuestionTypeId;
objComboBox.DisplayMember = convQuestionType.QuestionTypeName;
objComboBox.DataSource = arrObjLst;
objComboBox.SelectedIndex = 0;
}

 /// <summary>
 /// 绑定基于Web的下拉框
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_TabFeature_DdlBindFunction)
 /// </summary>
 /// <param name = "objDDL">需要绑定当前表的下拉框</param>

public static void BindDdl_QuestionTypeId(System.Web.UI.WebControls.DropDownList objDDL )
{
//为数据源于表的下拉框设置内容
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[v题目类型]...","0");
string strCondition = string.Format("1 =1 Order By {0}", convQuestionType.QuestionTypeId); 
IEnumerable<clsvQuestionTypeEN> arrObjLst = clsvQuestionTypeBL.GetObjLst(strCondition);
objDDL.DataValueField = convQuestionType.QuestionTypeId;
objDDL.DataTextField = convQuestionType.QuestionTypeName;
objDDL.DataSource = arrObjLst;
objDDL.DataBind();
objDDL.Items.Insert(0, li);
objDDL.SelectedIndex = 0;
}

 /// <summary>
 /// 绑定基于Web的下拉框-使用Cache
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DdlBindFunctionCache)
 /// </summary>
 /// <param name = "objDDL">需要绑定当前表的下拉框</param>
public static void BindDdl_QuestionTypeIdCache(System.Web.UI.WebControls.DropDownList objDDL)
{
//为数据源于表的下拉框设置内容
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[v题目类型]...","0");
List<clsvQuestionTypeEN> arrvQuestionTypeObjLst = GetAllvQuestionTypeObjLstCache(); 
objDDL.DataValueField = convQuestionType.QuestionTypeId;
objDDL.DataTextField = convQuestionType.QuestionTypeName;
objDDL.DataSource = arrvQuestionTypeObjLst;
objDDL.DataBind();
objDDL.Items.Insert(0, li);
objDDL.SelectedIndex = 0;
}


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
if (clsAnswerModeBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsAnswerModeBL没有刷新缓存机制(clsAnswerModeBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsAnswerTypeBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsAnswerTypeBL没有刷新缓存机制(clsAnswerTypeBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsQuestionTypeBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsQuestionTypeBL没有刷新缓存机制(clsQuestionTypeBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by QuestionTypeId");
//if (arrvQuestionTypeObjLstCache == null)
//{
//arrvQuestionTypeObjLstCache = vQuestionTypeDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "strQuestionTypeId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvQuestionTypeEN GetObjByQuestionTypeIdCache(string strQuestionTypeId)
{
//获取缓存中的对象列表
string strKey = string.Format("{0}", clsvQuestionTypeEN._CurrTabName);
List<clsvQuestionTypeEN> arrvQuestionTypeObjLstCache = GetObjLstCache();
IEnumerable <clsvQuestionTypeEN> arrvQuestionTypeObjLst_Sel =
arrvQuestionTypeObjLstCache
.Where(x=> x.QuestionTypeId == strQuestionTypeId 
);
if (arrvQuestionTypeObjLst_Sel.Count() == 0)
{
   clsvQuestionTypeEN obj = clsvQuestionTypeBL.GetObjByQuestionTypeId(strQuestionTypeId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
 }
return null;
}
return arrvQuestionTypeObjLst_Sel.First();
}

 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecNameByKeyCache)
 /// </summary>
 /// <param name = "strQuestionTypeId">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetQuestionTypeNameByQuestionTypeIdCache(string strQuestionTypeId)
{
if (string.IsNullOrEmpty(strQuestionTypeId) == true) return "";
//获取缓存中的对象列表
clsvQuestionTypeEN objvQuestionType = GetObjByQuestionTypeIdCache(strQuestionTypeId);
if (objvQuestionType == null) return "";
return objvQuestionType.QuestionTypeName;
}
 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecNameByKeyCache)
 /// </summary>
 /// <param name = "strQuestionTypeId">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetNameByQuestionTypeIdCache(string strQuestionTypeId)
{
if (string.IsNullOrEmpty(strQuestionTypeId) == true) return "";
//获取缓存中的对象列表
clsvQuestionTypeEN objvQuestionType = GetObjByQuestionTypeIdCache(strQuestionTypeId);
if (objvQuestionType == null) return "";
return objvQuestionType.QuestionTypeName;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvQuestionTypeEN> GetAllvQuestionTypeObjLstCache()
{
//获取缓存中的对象列表
List<clsvQuestionTypeEN> arrvQuestionTypeObjLstCache = GetObjLstCache(); 
return arrvQuestionTypeObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvQuestionTypeEN> GetObjLstCache()
{
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}", clsvQuestionTypeEN._CurrTabName);
List<clsvQuestionTypeEN> arrvQuestionTypeObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrvQuestionTypeObjLstCache;
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
string strKey = string.Format("{0}", clsvQuestionTypeEN._CurrTabName);
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
public static string Func(string strInFldName, string strOutFldName, string strQuestionTypeId)
{
if (strInFldName != convQuestionType.QuestionTypeId)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (convQuestionType.AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", convQuestionType.AttributeName));
throw new Exception(strMsg);
}
var objvQuestionType = clsvQuestionTypeBL.GetObjByQuestionTypeIdCache(strQuestionTypeId);
if (objvQuestionType == null) return "";
return objvQuestionType[strOutFldName].ToString();
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
int intRecCount = clsvQuestionTypeDA.GetRecCount(strTabName);
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
int intRecCount = clsvQuestionTypeDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsvQuestionTypeDA.GetRecCount();
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
int intRecCount = clsvQuestionTypeDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objvQuestionTypeCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsvQuestionTypeEN objvQuestionTypeCond)
{
List<clsvQuestionTypeEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsvQuestionTypeEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convQuestionType.AttributeName)
{
if (objvQuestionTypeCond.IsUpdated(strFldName) == false) continue;
if (objvQuestionTypeCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvQuestionTypeCond[strFldName].ToString());
}
else
{
if (objvQuestionTypeCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvQuestionTypeCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvQuestionTypeCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvQuestionTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvQuestionTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvQuestionTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvQuestionTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvQuestionTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvQuestionTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvQuestionTypeCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvQuestionTypeCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvQuestionTypeCond[strFldName]));
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
 List<string> arrList = clsvQuestionTypeDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = vQuestionTypeDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = vQuestionTypeDA.GetFldValueNoDistinct(strFldName, strWhereCond);
return arrList;
}



 #endregion 表操作常用函数
}
}