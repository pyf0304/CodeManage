
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvResearchTopicBL
 表名:vResearchTopic(01120612)
 * 版本:2023.08.23.1(服务器:WIN-SRV103-116)
 日期:2023/08/24 13:02:28
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
public static class  clsvResearchTopicBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "strTopicId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvResearchTopicEN GetObj(this K_TopicId_vResearchTopic myKey)
{
clsvResearchTopicEN objvResearchTopicEN = clsvResearchTopicBL.vResearchTopicDA.GetObjByTopicId(myKey.Value);
return objvResearchTopicEN;
}

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvResearchTopicEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvResearchTopicEN SetTopicId(this clsvResearchTopicEN objvResearchTopicEN, string strTopicId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTopicId, 8, convResearchTopic.TopicId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strTopicId, 8, convResearchTopic.TopicId);
}
objvResearchTopicEN.TopicId = strTopicId; //主题Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvResearchTopicEN.dicFldComparisonOp.ContainsKey(convResearchTopic.TopicId) == false)
{
objvResearchTopicEN.dicFldComparisonOp.Add(convResearchTopic.TopicId, strComparisonOp);
}
else
{
objvResearchTopicEN.dicFldComparisonOp[convResearchTopic.TopicId] = strComparisonOp;
}
}
return objvResearchTopicEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvResearchTopicEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvResearchTopicEN SetTopicName(this clsvResearchTopicEN objvResearchTopicEN, string strTopicName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTopicName, 200, convResearchTopic.TopicName);
}
objvResearchTopicEN.TopicName = strTopicName; //栏目主题
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvResearchTopicEN.dicFldComparisonOp.ContainsKey(convResearchTopic.TopicName) == false)
{
objvResearchTopicEN.dicFldComparisonOp.Add(convResearchTopic.TopicName, strComparisonOp);
}
else
{
objvResearchTopicEN.dicFldComparisonOp[convResearchTopic.TopicName] = strComparisonOp;
}
}
return objvResearchTopicEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvResearchTopicEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvResearchTopicEN SetTopicContent(this clsvResearchTopicEN objvResearchTopicEN, string strTopicContent, string strComparisonOp="")
	{
objvResearchTopicEN.TopicContent = strTopicContent; //主题内容
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvResearchTopicEN.dicFldComparisonOp.ContainsKey(convResearchTopic.TopicContent) == false)
{
objvResearchTopicEN.dicFldComparisonOp.Add(convResearchTopic.TopicContent, strComparisonOp);
}
else
{
objvResearchTopicEN.dicFldComparisonOp[convResearchTopic.TopicContent] = strComparisonOp;
}
}
return objvResearchTopicEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvResearchTopicEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvResearchTopicEN SetTopicProposePeople(this clsvResearchTopicEN objvResearchTopicEN, string strTopicProposePeople, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTopicProposePeople, 50, convResearchTopic.TopicProposePeople);
}
objvResearchTopicEN.TopicProposePeople = strTopicProposePeople; //主题提出人
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvResearchTopicEN.dicFldComparisonOp.ContainsKey(convResearchTopic.TopicProposePeople) == false)
{
objvResearchTopicEN.dicFldComparisonOp.Add(convResearchTopic.TopicProposePeople, strComparisonOp);
}
else
{
objvResearchTopicEN.dicFldComparisonOp[convResearchTopic.TopicProposePeople] = strComparisonOp;
}
}
return objvResearchTopicEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvResearchTopicEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvResearchTopicEN SetOrderNum(this clsvResearchTopicEN objvResearchTopicEN, int? intOrderNum, string strComparisonOp="")
	{
objvResearchTopicEN.OrderNum = intOrderNum; //序号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvResearchTopicEN.dicFldComparisonOp.ContainsKey(convResearchTopic.OrderNum) == false)
{
objvResearchTopicEN.dicFldComparisonOp.Add(convResearchTopic.OrderNum, strComparisonOp);
}
else
{
objvResearchTopicEN.dicFldComparisonOp[convResearchTopic.OrderNum] = strComparisonOp;
}
}
return objvResearchTopicEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvResearchTopicEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvResearchTopicEN SetUpdDate(this clsvResearchTopicEN objvResearchTopicEN, string strUpdDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdDate, 20, convResearchTopic.UpdDate);
}
objvResearchTopicEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvResearchTopicEN.dicFldComparisonOp.ContainsKey(convResearchTopic.UpdDate) == false)
{
objvResearchTopicEN.dicFldComparisonOp.Add(convResearchTopic.UpdDate, strComparisonOp);
}
else
{
objvResearchTopicEN.dicFldComparisonOp[convResearchTopic.UpdDate] = strComparisonOp;
}
}
return objvResearchTopicEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvResearchTopicEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvResearchTopicEN SetUpdUser(this clsvResearchTopicEN objvResearchTopicEN, string strUpdUser, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdUser, 20, convResearchTopic.UpdUser);
}
objvResearchTopicEN.UpdUser = strUpdUser; //修改人
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvResearchTopicEN.dicFldComparisonOp.ContainsKey(convResearchTopic.UpdUser) == false)
{
objvResearchTopicEN.dicFldComparisonOp.Add(convResearchTopic.UpdUser, strComparisonOp);
}
else
{
objvResearchTopicEN.dicFldComparisonOp[convResearchTopic.UpdUser] = strComparisonOp;
}
}
return objvResearchTopicEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvResearchTopicEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvResearchTopicEN SetMemo(this clsvResearchTopicEN objvResearchTopicEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, convResearchTopic.Memo);
}
objvResearchTopicEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvResearchTopicEN.dicFldComparisonOp.ContainsKey(convResearchTopic.Memo) == false)
{
objvResearchTopicEN.dicFldComparisonOp.Add(convResearchTopic.Memo, strComparisonOp);
}
else
{
objvResearchTopicEN.dicFldComparisonOp[convResearchTopic.Memo] = strComparisonOp;
}
}
return objvResearchTopicEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvResearchTopicEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvResearchTopicEN SetIsSubmit(this clsvResearchTopicEN objvResearchTopicEN, bool bolIsSubmit, string strComparisonOp="")
	{
objvResearchTopicEN.IsSubmit = bolIsSubmit; //是否提交
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvResearchTopicEN.dicFldComparisonOp.ContainsKey(convResearchTopic.IsSubmit) == false)
{
objvResearchTopicEN.dicFldComparisonOp.Add(convResearchTopic.IsSubmit, strComparisonOp);
}
else
{
objvResearchTopicEN.dicFldComparisonOp[convResearchTopic.IsSubmit] = strComparisonOp;
}
}
return objvResearchTopicEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvResearchTopicEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvResearchTopicEN SetUserName(this clsvResearchTopicEN objvResearchTopicEN, string strUserName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUserName, 30, convResearchTopic.UserName);
}
objvResearchTopicEN.UserName = strUserName; //用户名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvResearchTopicEN.dicFldComparisonOp.ContainsKey(convResearchTopic.UserName) == false)
{
objvResearchTopicEN.dicFldComparisonOp.Add(convResearchTopic.UserName, strComparisonOp);
}
else
{
objvResearchTopicEN.dicFldComparisonOp[convResearchTopic.UserName] = strComparisonOp;
}
}
return objvResearchTopicEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvResearchTopicEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvResearchTopicEN SetIdCurrEduCls(this clsvResearchTopicEN objvResearchTopicEN, string strIdCurrEduCls, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdCurrEduCls, 8, convResearchTopic.IdCurrEduCls);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdCurrEduCls, 8, convResearchTopic.IdCurrEduCls);
}
objvResearchTopicEN.IdCurrEduCls = strIdCurrEduCls; //教学班流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvResearchTopicEN.dicFldComparisonOp.ContainsKey(convResearchTopic.IdCurrEduCls) == false)
{
objvResearchTopicEN.dicFldComparisonOp.Add(convResearchTopic.IdCurrEduCls, strComparisonOp);
}
else
{
objvResearchTopicEN.dicFldComparisonOp[convResearchTopic.IdCurrEduCls] = strComparisonOp;
}
}
return objvResearchTopicEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvResearchTopicEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvResearchTopicEN SetShareId(this clsvResearchTopicEN objvResearchTopicEN, string strShareId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strShareId, convResearchTopic.ShareId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strShareId, 2, convResearchTopic.ShareId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strShareId, 2, convResearchTopic.ShareId);
}
objvResearchTopicEN.ShareId = strShareId; //分享Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvResearchTopicEN.dicFldComparisonOp.ContainsKey(convResearchTopic.ShareId) == false)
{
objvResearchTopicEN.dicFldComparisonOp.Add(convResearchTopic.ShareId, strComparisonOp);
}
else
{
objvResearchTopicEN.dicFldComparisonOp[convResearchTopic.ShareId] = strComparisonOp;
}
}
return objvResearchTopicEN;
	}

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CopyObj)
 /// </summary>
 /// <param name = "objvResearchTopicENS">源对象</param>
 /// <param name = "objvResearchTopicENT">目标对象</param>
 public static void CopyTo(this clsvResearchTopicEN objvResearchTopicENS, clsvResearchTopicEN objvResearchTopicENT)
{
try
{
objvResearchTopicENT.TopicId = objvResearchTopicENS.TopicId; //主题Id
objvResearchTopicENT.TopicName = objvResearchTopicENS.TopicName; //栏目主题
objvResearchTopicENT.TopicContent = objvResearchTopicENS.TopicContent; //主题内容
objvResearchTopicENT.TopicProposePeople = objvResearchTopicENS.TopicProposePeople; //主题提出人
objvResearchTopicENT.OrderNum = objvResearchTopicENS.OrderNum; //序号
objvResearchTopicENT.UpdDate = objvResearchTopicENS.UpdDate; //修改日期
objvResearchTopicENT.UpdUser = objvResearchTopicENS.UpdUser; //修改人
objvResearchTopicENT.Memo = objvResearchTopicENS.Memo; //备注
objvResearchTopicENT.IsSubmit = objvResearchTopicENS.IsSubmit; //是否提交
objvResearchTopicENT.UserName = objvResearchTopicENS.UserName; //用户名
objvResearchTopicENT.IdCurrEduCls = objvResearchTopicENS.IdCurrEduCls; //教学班流水号
objvResearchTopicENT.ShareId = objvResearchTopicENS.ShareId; //分享Id
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
 /// <param name = "objvResearchTopicENS">源对象</param>
 /// <returns>目标对象=>clsvResearchTopicEN:objvResearchTopicENT</returns>
 public static clsvResearchTopicEN CopyTo(this clsvResearchTopicEN objvResearchTopicENS)
{
try
{
 clsvResearchTopicEN objvResearchTopicENT = new clsvResearchTopicEN()
{
TopicId = objvResearchTopicENS.TopicId, //主题Id
TopicName = objvResearchTopicENS.TopicName, //栏目主题
TopicContent = objvResearchTopicENS.TopicContent, //主题内容
TopicProposePeople = objvResearchTopicENS.TopicProposePeople, //主题提出人
OrderNum = objvResearchTopicENS.OrderNum, //序号
UpdDate = objvResearchTopicENS.UpdDate, //修改日期
UpdUser = objvResearchTopicENS.UpdUser, //修改人
Memo = objvResearchTopicENS.Memo, //备注
IsSubmit = objvResearchTopicENS.IsSubmit, //是否提交
UserName = objvResearchTopicENS.UserName, //用户名
IdCurrEduCls = objvResearchTopicENS.IdCurrEduCls, //教学班流水号
ShareId = objvResearchTopicENS.ShareId, //分享Id
};
 return objvResearchTopicENT;
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
public static void CheckProperty4Condition(this clsvResearchTopicEN objvResearchTopicEN)
{
 clsvResearchTopicBL.vResearchTopicDA.CheckProperty4Condition(objvResearchTopicEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvResearchTopicEN objvResearchTopicCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvResearchTopicCond.IsUpdated(convResearchTopic.TopicId) == true)
{
string strComparisonOpTopicId = objvResearchTopicCond.dicFldComparisonOp[convResearchTopic.TopicId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convResearchTopic.TopicId, objvResearchTopicCond.TopicId, strComparisonOpTopicId);
}
if (objvResearchTopicCond.IsUpdated(convResearchTopic.TopicName) == true)
{
string strComparisonOpTopicName = objvResearchTopicCond.dicFldComparisonOp[convResearchTopic.TopicName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convResearchTopic.TopicName, objvResearchTopicCond.TopicName, strComparisonOpTopicName);
}
//数据类型string(text)在函数:[AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj]中没有处理!
if (objvResearchTopicCond.IsUpdated(convResearchTopic.TopicProposePeople) == true)
{
string strComparisonOpTopicProposePeople = objvResearchTopicCond.dicFldComparisonOp[convResearchTopic.TopicProposePeople];
strWhereCond += string.Format(" And {0} {2} '{1}'", convResearchTopic.TopicProposePeople, objvResearchTopicCond.TopicProposePeople, strComparisonOpTopicProposePeople);
}
if (objvResearchTopicCond.IsUpdated(convResearchTopic.OrderNum) == true)
{
string strComparisonOpOrderNum = objvResearchTopicCond.dicFldComparisonOp[convResearchTopic.OrderNum];
strWhereCond += string.Format(" And {0} {2} {1}", convResearchTopic.OrderNum, objvResearchTopicCond.OrderNum, strComparisonOpOrderNum);
}
if (objvResearchTopicCond.IsUpdated(convResearchTopic.UpdDate) == true)
{
string strComparisonOpUpdDate = objvResearchTopicCond.dicFldComparisonOp[convResearchTopic.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convResearchTopic.UpdDate, objvResearchTopicCond.UpdDate, strComparisonOpUpdDate);
}
if (objvResearchTopicCond.IsUpdated(convResearchTopic.UpdUser) == true)
{
string strComparisonOpUpdUser = objvResearchTopicCond.dicFldComparisonOp[convResearchTopic.UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", convResearchTopic.UpdUser, objvResearchTopicCond.UpdUser, strComparisonOpUpdUser);
}
if (objvResearchTopicCond.IsUpdated(convResearchTopic.Memo) == true)
{
string strComparisonOpMemo = objvResearchTopicCond.dicFldComparisonOp[convResearchTopic.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convResearchTopic.Memo, objvResearchTopicCond.Memo, strComparisonOpMemo);
}
if (objvResearchTopicCond.IsUpdated(convResearchTopic.IsSubmit) == true)
{
if (objvResearchTopicCond.IsSubmit == true)
{
strWhereCond += string.Format(" And {0} = '1'", convResearchTopic.IsSubmit);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convResearchTopic.IsSubmit);
}
}
if (objvResearchTopicCond.IsUpdated(convResearchTopic.UserName) == true)
{
string strComparisonOpUserName = objvResearchTopicCond.dicFldComparisonOp[convResearchTopic.UserName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convResearchTopic.UserName, objvResearchTopicCond.UserName, strComparisonOpUserName);
}
if (objvResearchTopicCond.IsUpdated(convResearchTopic.IdCurrEduCls) == true)
{
string strComparisonOpIdCurrEduCls = objvResearchTopicCond.dicFldComparisonOp[convResearchTopic.IdCurrEduCls];
strWhereCond += string.Format(" And {0} {2} '{1}'", convResearchTopic.IdCurrEduCls, objvResearchTopicCond.IdCurrEduCls, strComparisonOpIdCurrEduCls);
}
if (objvResearchTopicCond.IsUpdated(convResearchTopic.ShareId) == true)
{
string strComparisonOpShareId = objvResearchTopicCond.dicFldComparisonOp[convResearchTopic.ShareId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convResearchTopic.ShareId, objvResearchTopicCond.ShareId, strComparisonOpShareId);
}
 return strWhereCond;
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_vResearchTopic
{
public virtual bool UpdRelaTabDate(string strTopicId, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// 研究主题视图(vResearchTopic)
 /// 数据源类型:视图
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsvResearchTopicBL
{
public static RelatedActions_vResearchTopic relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsvResearchTopicDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsvResearchTopicDA vResearchTopicDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsvResearchTopicDA();
}
return uniqueInstance;
}
}

 /// <summary>
 /// 类的构造函数
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ClassConstructor1)
 /// </summary>
 public clsvResearchTopicBL()
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
if (string.IsNullOrEmpty(clsvResearchTopicEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvResearchTopicEN._ConnectString);
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
public static DataTable GetDataTable_vResearchTopic(string strWhereCond)
{
DataTable objDT;
try
{
objDT = vResearchTopicDA.GetDataTable_vResearchTopic(strWhereCond);
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
objDT = vResearchTopicDA.GetDataTable(strWhereCond);
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
objDT = vResearchTopicDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = vResearchTopicDA.GetDataTable(strWhereCond, strTabName);
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
objDT = vResearchTopicDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = vResearchTopicDA.GetDataTable_Top(objTopPara);
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
objDT = vResearchTopicDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = vResearchTopicDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = vResearchTopicDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
 /// <param name = "arrTopicIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static List<clsvResearchTopicEN> GetObjLstByTopicIdLst(List<string> arrTopicIdLst)
{
List<clsvResearchTopicEN> arrObjLst = new List<clsvResearchTopicEN>(); 
System.Data.DataTable objDT; 
 string strSqlConditionStr = clsArray.GetSqlInStrByArray(arrTopicIdLst, true);
 string strWhereCond = string.Format("TopicId in ({0})", strSqlConditionStr);
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvResearchTopicEN objvResearchTopicEN = new clsvResearchTopicEN();
try
{
objvResearchTopicEN.TopicId = objRow[convResearchTopic.TopicId].ToString().Trim(); //主题Id
objvResearchTopicEN.TopicName = objRow[convResearchTopic.TopicName] == DBNull.Value ? null : objRow[convResearchTopic.TopicName].ToString().Trim(); //栏目主题
objvResearchTopicEN.TopicContent = objRow[convResearchTopic.TopicContent] == DBNull.Value ? null : objRow[convResearchTopic.TopicContent].ToString().Trim(); //主题内容
objvResearchTopicEN.TopicProposePeople = objRow[convResearchTopic.TopicProposePeople] == DBNull.Value ? null : objRow[convResearchTopic.TopicProposePeople].ToString().Trim(); //主题提出人
objvResearchTopicEN.OrderNum = objRow[convResearchTopic.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convResearchTopic.OrderNum].ToString().Trim()); //序号
objvResearchTopicEN.UpdDate = objRow[convResearchTopic.UpdDate] == DBNull.Value ? null : objRow[convResearchTopic.UpdDate].ToString().Trim(); //修改日期
objvResearchTopicEN.UpdUser = objRow[convResearchTopic.UpdUser] == DBNull.Value ? null : objRow[convResearchTopic.UpdUser].ToString().Trim(); //修改人
objvResearchTopicEN.Memo = objRow[convResearchTopic.Memo] == DBNull.Value ? null : objRow[convResearchTopic.Memo].ToString().Trim(); //备注
objvResearchTopicEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[convResearchTopic.IsSubmit].ToString().Trim()); //是否提交
objvResearchTopicEN.UserName = objRow[convResearchTopic.UserName] == DBNull.Value ? null : objRow[convResearchTopic.UserName].ToString().Trim(); //用户名
objvResearchTopicEN.IdCurrEduCls = objRow[convResearchTopic.IdCurrEduCls] == DBNull.Value ? null : objRow[convResearchTopic.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvResearchTopicEN.ShareId = objRow[convResearchTopic.ShareId].ToString().Trim(); //分享Id
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvResearchTopicEN.TopicId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvResearchTopicEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrTopicIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsvResearchTopicEN> GetObjLstByTopicIdLstCache(List<string> arrTopicIdLst, string strIdCurrEduCls)
{
string strKey = string.Format("{0}_{1}", clsvResearchTopicEN._CurrTabName, strIdCurrEduCls);
List<clsvResearchTopicEN> arrvResearchTopicObjLstCache = GetObjLstCache(strIdCurrEduCls);
IEnumerable <clsvResearchTopicEN> arrvResearchTopicObjLst_Sel =
arrvResearchTopicObjLstCache
.Where(x => arrTopicIdLst.Contains(x.TopicId));
return arrvResearchTopicObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvResearchTopicEN> GetObjLst(string strWhereCond)
{
List<clsvResearchTopicEN> arrObjLst = new List<clsvResearchTopicEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvResearchTopicEN objvResearchTopicEN = new clsvResearchTopicEN();
try
{
objvResearchTopicEN.TopicId = objRow[convResearchTopic.TopicId].ToString().Trim(); //主题Id
objvResearchTopicEN.TopicName = objRow[convResearchTopic.TopicName] == DBNull.Value ? null : objRow[convResearchTopic.TopicName].ToString().Trim(); //栏目主题
objvResearchTopicEN.TopicContent = objRow[convResearchTopic.TopicContent] == DBNull.Value ? null : objRow[convResearchTopic.TopicContent].ToString().Trim(); //主题内容
objvResearchTopicEN.TopicProposePeople = objRow[convResearchTopic.TopicProposePeople] == DBNull.Value ? null : objRow[convResearchTopic.TopicProposePeople].ToString().Trim(); //主题提出人
objvResearchTopicEN.OrderNum = objRow[convResearchTopic.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convResearchTopic.OrderNum].ToString().Trim()); //序号
objvResearchTopicEN.UpdDate = objRow[convResearchTopic.UpdDate] == DBNull.Value ? null : objRow[convResearchTopic.UpdDate].ToString().Trim(); //修改日期
objvResearchTopicEN.UpdUser = objRow[convResearchTopic.UpdUser] == DBNull.Value ? null : objRow[convResearchTopic.UpdUser].ToString().Trim(); //修改人
objvResearchTopicEN.Memo = objRow[convResearchTopic.Memo] == DBNull.Value ? null : objRow[convResearchTopic.Memo].ToString().Trim(); //备注
objvResearchTopicEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[convResearchTopic.IsSubmit].ToString().Trim()); //是否提交
objvResearchTopicEN.UserName = objRow[convResearchTopic.UserName] == DBNull.Value ? null : objRow[convResearchTopic.UserName].ToString().Trim(); //用户名
objvResearchTopicEN.IdCurrEduCls = objRow[convResearchTopic.IdCurrEduCls] == DBNull.Value ? null : objRow[convResearchTopic.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvResearchTopicEN.ShareId = objRow[convResearchTopic.ShareId].ToString().Trim(); //分享Id
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvResearchTopicEN.TopicId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvResearchTopicEN);
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
public static List<clsvResearchTopicEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsvResearchTopicEN> arrObjLst = new List<clsvResearchTopicEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvResearchTopicEN objvResearchTopicEN = new clsvResearchTopicEN();
try
{
objvResearchTopicEN.TopicId = objRow[convResearchTopic.TopicId].ToString().Trim(); //主题Id
objvResearchTopicEN.TopicName = objRow[convResearchTopic.TopicName] == DBNull.Value ? null : objRow[convResearchTopic.TopicName].ToString().Trim(); //栏目主题
objvResearchTopicEN.TopicContent = objRow[convResearchTopic.TopicContent] == DBNull.Value ? null : objRow[convResearchTopic.TopicContent].ToString().Trim(); //主题内容
objvResearchTopicEN.TopicProposePeople = objRow[convResearchTopic.TopicProposePeople] == DBNull.Value ? null : objRow[convResearchTopic.TopicProposePeople].ToString().Trim(); //主题提出人
objvResearchTopicEN.OrderNum = objRow[convResearchTopic.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convResearchTopic.OrderNum].ToString().Trim()); //序号
objvResearchTopicEN.UpdDate = objRow[convResearchTopic.UpdDate] == DBNull.Value ? null : objRow[convResearchTopic.UpdDate].ToString().Trim(); //修改日期
objvResearchTopicEN.UpdUser = objRow[convResearchTopic.UpdUser] == DBNull.Value ? null : objRow[convResearchTopic.UpdUser].ToString().Trim(); //修改人
objvResearchTopicEN.Memo = objRow[convResearchTopic.Memo] == DBNull.Value ? null : objRow[convResearchTopic.Memo].ToString().Trim(); //备注
objvResearchTopicEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[convResearchTopic.IsSubmit].ToString().Trim()); //是否提交
objvResearchTopicEN.UserName = objRow[convResearchTopic.UserName] == DBNull.Value ? null : objRow[convResearchTopic.UserName].ToString().Trim(); //用户名
objvResearchTopicEN.IdCurrEduCls = objRow[convResearchTopic.IdCurrEduCls] == DBNull.Value ? null : objRow[convResearchTopic.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvResearchTopicEN.ShareId = objRow[convResearchTopic.ShareId].ToString().Trim(); //分享Id
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvResearchTopicEN.TopicId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvResearchTopicEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objvResearchTopicCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsvResearchTopicEN> GetSubObjLstCache(clsvResearchTopicEN objvResearchTopicCond)
{
 string strIdCurrEduCls = objvResearchTopicCond.IdCurrEduCls;
 if (string.IsNullOrEmpty(strIdCurrEduCls) == true)
{
string strMsg = string.Format("(errid:Busi000172)在表中,缓存分类字段值不能为空!(clsvResearchTopicBL:GetSubObjLstCache)");
throw new Exception(strMsg);
}
List<clsvResearchTopicEN> arrObjLstCache = GetObjLstCache(strIdCurrEduCls);
IEnumerable <clsvResearchTopicEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convResearchTopic.AttributeName)
{
if (objvResearchTopicCond.IsUpdated(strFldName) == false) continue;
if (objvResearchTopicCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvResearchTopicCond[strFldName].ToString());
}
else
{
if (objvResearchTopicCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvResearchTopicCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvResearchTopicCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvResearchTopicCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvResearchTopicCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvResearchTopicCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvResearchTopicCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvResearchTopicCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvResearchTopicCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvResearchTopicCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvResearchTopicCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvResearchTopicCond[strFldName]));
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
public static List<clsvResearchTopicEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsvResearchTopicEN> arrObjLst = new List<clsvResearchTopicEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvResearchTopicEN objvResearchTopicEN = new clsvResearchTopicEN();
try
{
objvResearchTopicEN.TopicId = objRow[convResearchTopic.TopicId].ToString().Trim(); //主题Id
objvResearchTopicEN.TopicName = objRow[convResearchTopic.TopicName] == DBNull.Value ? null : objRow[convResearchTopic.TopicName].ToString().Trim(); //栏目主题
objvResearchTopicEN.TopicContent = objRow[convResearchTopic.TopicContent] == DBNull.Value ? null : objRow[convResearchTopic.TopicContent].ToString().Trim(); //主题内容
objvResearchTopicEN.TopicProposePeople = objRow[convResearchTopic.TopicProposePeople] == DBNull.Value ? null : objRow[convResearchTopic.TopicProposePeople].ToString().Trim(); //主题提出人
objvResearchTopicEN.OrderNum = objRow[convResearchTopic.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convResearchTopic.OrderNum].ToString().Trim()); //序号
objvResearchTopicEN.UpdDate = objRow[convResearchTopic.UpdDate] == DBNull.Value ? null : objRow[convResearchTopic.UpdDate].ToString().Trim(); //修改日期
objvResearchTopicEN.UpdUser = objRow[convResearchTopic.UpdUser] == DBNull.Value ? null : objRow[convResearchTopic.UpdUser].ToString().Trim(); //修改人
objvResearchTopicEN.Memo = objRow[convResearchTopic.Memo] == DBNull.Value ? null : objRow[convResearchTopic.Memo].ToString().Trim(); //备注
objvResearchTopicEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[convResearchTopic.IsSubmit].ToString().Trim()); //是否提交
objvResearchTopicEN.UserName = objRow[convResearchTopic.UserName] == DBNull.Value ? null : objRow[convResearchTopic.UserName].ToString().Trim(); //用户名
objvResearchTopicEN.IdCurrEduCls = objRow[convResearchTopic.IdCurrEduCls] == DBNull.Value ? null : objRow[convResearchTopic.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvResearchTopicEN.ShareId = objRow[convResearchTopic.ShareId].ToString().Trim(); //分享Id
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvResearchTopicEN.TopicId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvResearchTopicEN);
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
public static List<clsvResearchTopicEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsvResearchTopicEN> arrObjLst = new List<clsvResearchTopicEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvResearchTopicEN objvResearchTopicEN = new clsvResearchTopicEN();
try
{
objvResearchTopicEN.TopicId = objRow[convResearchTopic.TopicId].ToString().Trim(); //主题Id
objvResearchTopicEN.TopicName = objRow[convResearchTopic.TopicName] == DBNull.Value ? null : objRow[convResearchTopic.TopicName].ToString().Trim(); //栏目主题
objvResearchTopicEN.TopicContent = objRow[convResearchTopic.TopicContent] == DBNull.Value ? null : objRow[convResearchTopic.TopicContent].ToString().Trim(); //主题内容
objvResearchTopicEN.TopicProposePeople = objRow[convResearchTopic.TopicProposePeople] == DBNull.Value ? null : objRow[convResearchTopic.TopicProposePeople].ToString().Trim(); //主题提出人
objvResearchTopicEN.OrderNum = objRow[convResearchTopic.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convResearchTopic.OrderNum].ToString().Trim()); //序号
objvResearchTopicEN.UpdDate = objRow[convResearchTopic.UpdDate] == DBNull.Value ? null : objRow[convResearchTopic.UpdDate].ToString().Trim(); //修改日期
objvResearchTopicEN.UpdUser = objRow[convResearchTopic.UpdUser] == DBNull.Value ? null : objRow[convResearchTopic.UpdUser].ToString().Trim(); //修改人
objvResearchTopicEN.Memo = objRow[convResearchTopic.Memo] == DBNull.Value ? null : objRow[convResearchTopic.Memo].ToString().Trim(); //备注
objvResearchTopicEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[convResearchTopic.IsSubmit].ToString().Trim()); //是否提交
objvResearchTopicEN.UserName = objRow[convResearchTopic.UserName] == DBNull.Value ? null : objRow[convResearchTopic.UserName].ToString().Trim(); //用户名
objvResearchTopicEN.IdCurrEduCls = objRow[convResearchTopic.IdCurrEduCls] == DBNull.Value ? null : objRow[convResearchTopic.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvResearchTopicEN.ShareId = objRow[convResearchTopic.ShareId].ToString().Trim(); //分享Id
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvResearchTopicEN.TopicId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvResearchTopicEN);
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
List<clsvResearchTopicEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsvResearchTopicEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsvResearchTopicEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsvResearchTopicEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsvResearchTopicEN> arrObjLst = new List<clsvResearchTopicEN>(); 
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
	clsvResearchTopicEN objvResearchTopicEN = new clsvResearchTopicEN();
try
{
objvResearchTopicEN.TopicId = objRow[convResearchTopic.TopicId].ToString().Trim(); //主题Id
objvResearchTopicEN.TopicName = objRow[convResearchTopic.TopicName] == DBNull.Value ? null : objRow[convResearchTopic.TopicName].ToString().Trim(); //栏目主题
objvResearchTopicEN.TopicContent = objRow[convResearchTopic.TopicContent] == DBNull.Value ? null : objRow[convResearchTopic.TopicContent].ToString().Trim(); //主题内容
objvResearchTopicEN.TopicProposePeople = objRow[convResearchTopic.TopicProposePeople] == DBNull.Value ? null : objRow[convResearchTopic.TopicProposePeople].ToString().Trim(); //主题提出人
objvResearchTopicEN.OrderNum = objRow[convResearchTopic.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convResearchTopic.OrderNum].ToString().Trim()); //序号
objvResearchTopicEN.UpdDate = objRow[convResearchTopic.UpdDate] == DBNull.Value ? null : objRow[convResearchTopic.UpdDate].ToString().Trim(); //修改日期
objvResearchTopicEN.UpdUser = objRow[convResearchTopic.UpdUser] == DBNull.Value ? null : objRow[convResearchTopic.UpdUser].ToString().Trim(); //修改人
objvResearchTopicEN.Memo = objRow[convResearchTopic.Memo] == DBNull.Value ? null : objRow[convResearchTopic.Memo].ToString().Trim(); //备注
objvResearchTopicEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[convResearchTopic.IsSubmit].ToString().Trim()); //是否提交
objvResearchTopicEN.UserName = objRow[convResearchTopic.UserName] == DBNull.Value ? null : objRow[convResearchTopic.UserName].ToString().Trim(); //用户名
objvResearchTopicEN.IdCurrEduCls = objRow[convResearchTopic.IdCurrEduCls] == DBNull.Value ? null : objRow[convResearchTopic.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvResearchTopicEN.ShareId = objRow[convResearchTopic.ShareId].ToString().Trim(); //分享Id
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvResearchTopicEN.TopicId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvResearchTopicEN);
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
public static List<clsvResearchTopicEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsvResearchTopicEN> arrObjLst = new List<clsvResearchTopicEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvResearchTopicEN objvResearchTopicEN = new clsvResearchTopicEN();
try
{
objvResearchTopicEN.TopicId = objRow[convResearchTopic.TopicId].ToString().Trim(); //主题Id
objvResearchTopicEN.TopicName = objRow[convResearchTopic.TopicName] == DBNull.Value ? null : objRow[convResearchTopic.TopicName].ToString().Trim(); //栏目主题
objvResearchTopicEN.TopicContent = objRow[convResearchTopic.TopicContent] == DBNull.Value ? null : objRow[convResearchTopic.TopicContent].ToString().Trim(); //主题内容
objvResearchTopicEN.TopicProposePeople = objRow[convResearchTopic.TopicProposePeople] == DBNull.Value ? null : objRow[convResearchTopic.TopicProposePeople].ToString().Trim(); //主题提出人
objvResearchTopicEN.OrderNum = objRow[convResearchTopic.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convResearchTopic.OrderNum].ToString().Trim()); //序号
objvResearchTopicEN.UpdDate = objRow[convResearchTopic.UpdDate] == DBNull.Value ? null : objRow[convResearchTopic.UpdDate].ToString().Trim(); //修改日期
objvResearchTopicEN.UpdUser = objRow[convResearchTopic.UpdUser] == DBNull.Value ? null : objRow[convResearchTopic.UpdUser].ToString().Trim(); //修改人
objvResearchTopicEN.Memo = objRow[convResearchTopic.Memo] == DBNull.Value ? null : objRow[convResearchTopic.Memo].ToString().Trim(); //备注
objvResearchTopicEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[convResearchTopic.IsSubmit].ToString().Trim()); //是否提交
objvResearchTopicEN.UserName = objRow[convResearchTopic.UserName] == DBNull.Value ? null : objRow[convResearchTopic.UserName].ToString().Trim(); //用户名
objvResearchTopicEN.IdCurrEduCls = objRow[convResearchTopic.IdCurrEduCls] == DBNull.Value ? null : objRow[convResearchTopic.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvResearchTopicEN.ShareId = objRow[convResearchTopic.ShareId].ToString().Trim(); //分享Id
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvResearchTopicEN.TopicId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvResearchTopicEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsvResearchTopicEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsvResearchTopicEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsvResearchTopicEN> arrObjLst = new List<clsvResearchTopicEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvResearchTopicEN objvResearchTopicEN = new clsvResearchTopicEN();
try
{
objvResearchTopicEN.TopicId = objRow[convResearchTopic.TopicId].ToString().Trim(); //主题Id
objvResearchTopicEN.TopicName = objRow[convResearchTopic.TopicName] == DBNull.Value ? null : objRow[convResearchTopic.TopicName].ToString().Trim(); //栏目主题
objvResearchTopicEN.TopicContent = objRow[convResearchTopic.TopicContent] == DBNull.Value ? null : objRow[convResearchTopic.TopicContent].ToString().Trim(); //主题内容
objvResearchTopicEN.TopicProposePeople = objRow[convResearchTopic.TopicProposePeople] == DBNull.Value ? null : objRow[convResearchTopic.TopicProposePeople].ToString().Trim(); //主题提出人
objvResearchTopicEN.OrderNum = objRow[convResearchTopic.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convResearchTopic.OrderNum].ToString().Trim()); //序号
objvResearchTopicEN.UpdDate = objRow[convResearchTopic.UpdDate] == DBNull.Value ? null : objRow[convResearchTopic.UpdDate].ToString().Trim(); //修改日期
objvResearchTopicEN.UpdUser = objRow[convResearchTopic.UpdUser] == DBNull.Value ? null : objRow[convResearchTopic.UpdUser].ToString().Trim(); //修改人
objvResearchTopicEN.Memo = objRow[convResearchTopic.Memo] == DBNull.Value ? null : objRow[convResearchTopic.Memo].ToString().Trim(); //备注
objvResearchTopicEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[convResearchTopic.IsSubmit].ToString().Trim()); //是否提交
objvResearchTopicEN.UserName = objRow[convResearchTopic.UserName] == DBNull.Value ? null : objRow[convResearchTopic.UserName].ToString().Trim(); //用户名
objvResearchTopicEN.IdCurrEduCls = objRow[convResearchTopic.IdCurrEduCls] == DBNull.Value ? null : objRow[convResearchTopic.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvResearchTopicEN.ShareId = objRow[convResearchTopic.ShareId].ToString().Trim(); //分享Id
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvResearchTopicEN.TopicId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvResearchTopicEN);
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
public static List<clsvResearchTopicEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsvResearchTopicEN> arrObjLst = new List<clsvResearchTopicEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvResearchTopicEN objvResearchTopicEN = new clsvResearchTopicEN();
try
{
objvResearchTopicEN.TopicId = objRow[convResearchTopic.TopicId].ToString().Trim(); //主题Id
objvResearchTopicEN.TopicName = objRow[convResearchTopic.TopicName] == DBNull.Value ? null : objRow[convResearchTopic.TopicName].ToString().Trim(); //栏目主题
objvResearchTopicEN.TopicContent = objRow[convResearchTopic.TopicContent] == DBNull.Value ? null : objRow[convResearchTopic.TopicContent].ToString().Trim(); //主题内容
objvResearchTopicEN.TopicProposePeople = objRow[convResearchTopic.TopicProposePeople] == DBNull.Value ? null : objRow[convResearchTopic.TopicProposePeople].ToString().Trim(); //主题提出人
objvResearchTopicEN.OrderNum = objRow[convResearchTopic.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convResearchTopic.OrderNum].ToString().Trim()); //序号
objvResearchTopicEN.UpdDate = objRow[convResearchTopic.UpdDate] == DBNull.Value ? null : objRow[convResearchTopic.UpdDate].ToString().Trim(); //修改日期
objvResearchTopicEN.UpdUser = objRow[convResearchTopic.UpdUser] == DBNull.Value ? null : objRow[convResearchTopic.UpdUser].ToString().Trim(); //修改人
objvResearchTopicEN.Memo = objRow[convResearchTopic.Memo] == DBNull.Value ? null : objRow[convResearchTopic.Memo].ToString().Trim(); //备注
objvResearchTopicEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[convResearchTopic.IsSubmit].ToString().Trim()); //是否提交
objvResearchTopicEN.UserName = objRow[convResearchTopic.UserName] == DBNull.Value ? null : objRow[convResearchTopic.UserName].ToString().Trim(); //用户名
objvResearchTopicEN.IdCurrEduCls = objRow[convResearchTopic.IdCurrEduCls] == DBNull.Value ? null : objRow[convResearchTopic.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvResearchTopicEN.ShareId = objRow[convResearchTopic.ShareId].ToString().Trim(); //分享Id
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvResearchTopicEN.TopicId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvResearchTopicEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsvResearchTopicEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsvResearchTopicEN> arrObjLst = new List<clsvResearchTopicEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvResearchTopicEN objvResearchTopicEN = new clsvResearchTopicEN();
try
{
objvResearchTopicEN.TopicId = objRow[convResearchTopic.TopicId].ToString().Trim(); //主题Id
objvResearchTopicEN.TopicName = objRow[convResearchTopic.TopicName] == DBNull.Value ? null : objRow[convResearchTopic.TopicName].ToString().Trim(); //栏目主题
objvResearchTopicEN.TopicContent = objRow[convResearchTopic.TopicContent] == DBNull.Value ? null : objRow[convResearchTopic.TopicContent].ToString().Trim(); //主题内容
objvResearchTopicEN.TopicProposePeople = objRow[convResearchTopic.TopicProposePeople] == DBNull.Value ? null : objRow[convResearchTopic.TopicProposePeople].ToString().Trim(); //主题提出人
objvResearchTopicEN.OrderNum = objRow[convResearchTopic.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convResearchTopic.OrderNum].ToString().Trim()); //序号
objvResearchTopicEN.UpdDate = objRow[convResearchTopic.UpdDate] == DBNull.Value ? null : objRow[convResearchTopic.UpdDate].ToString().Trim(); //修改日期
objvResearchTopicEN.UpdUser = objRow[convResearchTopic.UpdUser] == DBNull.Value ? null : objRow[convResearchTopic.UpdUser].ToString().Trim(); //修改人
objvResearchTopicEN.Memo = objRow[convResearchTopic.Memo] == DBNull.Value ? null : objRow[convResearchTopic.Memo].ToString().Trim(); //备注
objvResearchTopicEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[convResearchTopic.IsSubmit].ToString().Trim()); //是否提交
objvResearchTopicEN.UserName = objRow[convResearchTopic.UserName] == DBNull.Value ? null : objRow[convResearchTopic.UserName].ToString().Trim(); //用户名
objvResearchTopicEN.IdCurrEduCls = objRow[convResearchTopic.IdCurrEduCls] == DBNull.Value ? null : objRow[convResearchTopic.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvResearchTopicEN.ShareId = objRow[convResearchTopic.ShareId].ToString().Trim(); //分享Id
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvResearchTopicEN.TopicId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvResearchTopicEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objvResearchTopicEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetvResearchTopic(ref clsvResearchTopicEN objvResearchTopicEN)
{
bool bolResult = vResearchTopicDA.GetvResearchTopic(ref objvResearchTopicEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "strTopicId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvResearchTopicEN GetObjByTopicId(string strTopicId)
{
if (strTopicId.IndexOf(' ') >=0)
{
var strMsg = string.Format("(errid:Busi000079)在表中,关键字[strTopicId]中不能有空格!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
if (string.IsNullOrEmpty(strTopicId) == true)
{
var strMsg = string.Format("(errid:Busi000020)在表中,关键字[strTopicId]不能为空!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
clsvResearchTopicEN objvResearchTopicEN = vResearchTopicDA.GetObjByTopicId(strTopicId);
return objvResearchTopicEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsvResearchTopicEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsvResearchTopicEN objvResearchTopicEN = vResearchTopicDA.GetFirstObj(strWhereCond);
 return objvResearchTopicEN;
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
public static clsvResearchTopicEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsvResearchTopicEN objvResearchTopicEN = vResearchTopicDA.GetObjByDataRow(objRow);
 return objvResearchTopicEN;
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
public static clsvResearchTopicEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsvResearchTopicEN objvResearchTopicEN = vResearchTopicDA.GetObjByDataRow(objRow);
 return objvResearchTopicEN;
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
 /// <param name = "strTopicId">所给的关键字</param>
 /// <param name = "lstvResearchTopicObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvResearchTopicEN GetObjByTopicIdFromList(string strTopicId, List<clsvResearchTopicEN> lstvResearchTopicObjLst)
{
foreach (clsvResearchTopicEN objvResearchTopicEN in lstvResearchTopicObjLst)
{
if (objvResearchTopicEN.TopicId == strTopicId)
{
return objvResearchTopicEN;
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
 string strTopicId;
 try
 {
 strTopicId = new clsvResearchTopicDA().GetFirstID(strWhereCond);
 return strTopicId;
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
 arrList = vResearchTopicDA.GetID(strWhereCond);
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
bool bolIsExist = vResearchTopicDA.IsExistCondRec(strWhereCond);
return bolIsExist;
}

 /// <summary>
 /// 判断当前表中是否存在给定关键字值的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExist)
 /// </summary>
 /// <param name = "strTopicId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public static bool IsExist(string strTopicId)
{
if (string.IsNullOrEmpty(strTopicId) == true)
{
var strMsg = string.Format("(errid:Busi000027)在表中,关键字[strTopicId]不能为空!!(from {0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
//检测记录是否存在
bool bolIsExist = vResearchTopicDA.IsExist(strTopicId);
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
 bolIsExist = clsvResearchTopicDA.IsExistTable();
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
 bolIsExist = vResearchTopicDA.IsExistTable(strTabName);
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
 /// <param name = "objvResearchTopicENS">源对象</param>
 /// <param name = "objvResearchTopicENT">目标对象</param>
 public static void CopyTo(clsvResearchTopicEN objvResearchTopicENS, clsvResearchTopicEN objvResearchTopicENT)
{
try
{
objvResearchTopicENT.TopicId = objvResearchTopicENS.TopicId; //主题Id
objvResearchTopicENT.TopicName = objvResearchTopicENS.TopicName; //栏目主题
objvResearchTopicENT.TopicContent = objvResearchTopicENS.TopicContent; //主题内容
objvResearchTopicENT.TopicProposePeople = objvResearchTopicENS.TopicProposePeople; //主题提出人
objvResearchTopicENT.OrderNum = objvResearchTopicENS.OrderNum; //序号
objvResearchTopicENT.UpdDate = objvResearchTopicENS.UpdDate; //修改日期
objvResearchTopicENT.UpdUser = objvResearchTopicENS.UpdUser; //修改人
objvResearchTopicENT.Memo = objvResearchTopicENS.Memo; //备注
objvResearchTopicENT.IsSubmit = objvResearchTopicENS.IsSubmit; //是否提交
objvResearchTopicENT.UserName = objvResearchTopicENS.UserName; //用户名
objvResearchTopicENT.IdCurrEduCls = objvResearchTopicENS.IdCurrEduCls; //教学班流水号
objvResearchTopicENT.ShareId = objvResearchTopicENS.ShareId; //分享Id
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
 /// <param name = "objvResearchTopicEN">源简化对象</param>
 public static void SetUpdFlag(clsvResearchTopicEN objvResearchTopicEN)
{
try
{
objvResearchTopicEN.ClearUpdateState();
   string strsfUpdFldSetStr = objvResearchTopicEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(convResearchTopic.TopicId, new clsStrCompareIgnoreCase())  ==  true)
{
objvResearchTopicEN.TopicId = objvResearchTopicEN.TopicId; //主题Id
}
if (arrFldSet.Contains(convResearchTopic.TopicName, new clsStrCompareIgnoreCase())  ==  true)
{
objvResearchTopicEN.TopicName = objvResearchTopicEN.TopicName == "[null]" ? null :  objvResearchTopicEN.TopicName; //栏目主题
}
if (arrFldSet.Contains(convResearchTopic.TopicContent, new clsStrCompareIgnoreCase())  ==  true)
{
objvResearchTopicEN.TopicContent = objvResearchTopicEN.TopicContent == "[null]" ? null :  objvResearchTopicEN.TopicContent; //主题内容
}
if (arrFldSet.Contains(convResearchTopic.TopicProposePeople, new clsStrCompareIgnoreCase())  ==  true)
{
objvResearchTopicEN.TopicProposePeople = objvResearchTopicEN.TopicProposePeople == "[null]" ? null :  objvResearchTopicEN.TopicProposePeople; //主题提出人
}
if (arrFldSet.Contains(convResearchTopic.OrderNum, new clsStrCompareIgnoreCase())  ==  true)
{
objvResearchTopicEN.OrderNum = objvResearchTopicEN.OrderNum; //序号
}
if (arrFldSet.Contains(convResearchTopic.UpdDate, new clsStrCompareIgnoreCase())  ==  true)
{
objvResearchTopicEN.UpdDate = objvResearchTopicEN.UpdDate == "[null]" ? null :  objvResearchTopicEN.UpdDate; //修改日期
}
if (arrFldSet.Contains(convResearchTopic.UpdUser, new clsStrCompareIgnoreCase())  ==  true)
{
objvResearchTopicEN.UpdUser = objvResearchTopicEN.UpdUser == "[null]" ? null :  objvResearchTopicEN.UpdUser; //修改人
}
if (arrFldSet.Contains(convResearchTopic.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objvResearchTopicEN.Memo = objvResearchTopicEN.Memo == "[null]" ? null :  objvResearchTopicEN.Memo; //备注
}
if (arrFldSet.Contains(convResearchTopic.IsSubmit, new clsStrCompareIgnoreCase())  ==  true)
{
objvResearchTopicEN.IsSubmit = objvResearchTopicEN.IsSubmit; //是否提交
}
if (arrFldSet.Contains(convResearchTopic.UserName, new clsStrCompareIgnoreCase())  ==  true)
{
objvResearchTopicEN.UserName = objvResearchTopicEN.UserName == "[null]" ? null :  objvResearchTopicEN.UserName; //用户名
}
if (arrFldSet.Contains(convResearchTopic.IdCurrEduCls, new clsStrCompareIgnoreCase())  ==  true)
{
objvResearchTopicEN.IdCurrEduCls = objvResearchTopicEN.IdCurrEduCls == "[null]" ? null :  objvResearchTopicEN.IdCurrEduCls; //教学班流水号
}
if (arrFldSet.Contains(convResearchTopic.ShareId, new clsStrCompareIgnoreCase())  ==  true)
{
objvResearchTopicEN.ShareId = objvResearchTopicEN.ShareId; //分享Id
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
 /// <param name = "objvResearchTopicEN">源简化对象</param>
 public static void AccessFldValueNull(clsvResearchTopicEN objvResearchTopicEN)
{
try
{
if (objvResearchTopicEN.TopicName == "[null]") objvResearchTopicEN.TopicName = null; //栏目主题
if (objvResearchTopicEN.TopicContent == "[null]") objvResearchTopicEN.TopicContent = null; //主题内容
if (objvResearchTopicEN.TopicProposePeople == "[null]") objvResearchTopicEN.TopicProposePeople = null; //主题提出人
if (objvResearchTopicEN.UpdDate == "[null]") objvResearchTopicEN.UpdDate = null; //修改日期
if (objvResearchTopicEN.UpdUser == "[null]") objvResearchTopicEN.UpdUser = null; //修改人
if (objvResearchTopicEN.Memo == "[null]") objvResearchTopicEN.Memo = null; //备注
if (objvResearchTopicEN.UserName == "[null]") objvResearchTopicEN.UserName = null; //用户名
if (objvResearchTopicEN.IdCurrEduCls == "[null]") objvResearchTopicEN.IdCurrEduCls = null; //教学班流水号
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
public static void CheckProperty4Condition(clsvResearchTopicEN objvResearchTopicEN)
{
 vResearchTopicDA.CheckProperty4Condition(objvResearchTopicEN);
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
if (clsUsersBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsUsersBL没有刷新缓存机制(clsUsersBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsResearchTopicBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsResearchTopicBL没有刷新缓存机制(clsResearchTopicBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by TopicId");
//if (arrvResearchTopicObjLstCache == null)
//{
//arrvResearchTopicObjLstCache = vResearchTopicDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "strTopicId">所给的关键字</param>
 /// <param name = "strIdCurrEduCls">缓存的分类字段</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvResearchTopicEN GetObjByTopicIdCache(string strTopicId, string strIdCurrEduCls)
{

if (string.IsNullOrEmpty(strIdCurrEduCls) == true)
{
  var strMsg = string.Format("参数:[strIdCurrEduCls]不能为空!(In {0})", clsStackTrace.GetCurrClassFunction());
clsSysParaEN.objLog.WriteDebugLog(strMsg);
 throw new Exception (strMsg);
}
if (strIdCurrEduCls.Length != 8)
{
var strMsg = string.Format("缓存分类变量:[strIdCurrEduCls]的长度:[{0}]不正确!(In {1})", strIdCurrEduCls.Length, clsStackTrace.GetCurrClassFunction());
clsSysParaEN.objLog.WriteDebugLog(strMsg);
 throw new Exception (strMsg);
}
//获取缓存中的对象列表
string strKey = string.Format("{0}_{1}", clsvResearchTopicEN._CurrTabName, strIdCurrEduCls);
List<clsvResearchTopicEN> arrvResearchTopicObjLstCache = GetObjLstCache(strIdCurrEduCls);
IEnumerable <clsvResearchTopicEN> arrvResearchTopicObjLst_Sel =
arrvResearchTopicObjLstCache
.Where(x=> x.TopicId == strTopicId 
);
if (arrvResearchTopicObjLst_Sel.Count() == 0)
{
   clsvResearchTopicEN obj = clsvResearchTopicBL.GetObjByTopicId(strTopicId);
   if (obj != null)
 {
if (obj.IdCurrEduCls == strIdCurrEduCls)
{
CacheHelper.Remove(strKey);
     return obj;
}
else
{
string strMsg = string.Format("错误: 关键字:{0}不属于分类:{1},请检查!(In {2})", strTopicId, strIdCurrEduCls, clsStackTrace.GetCurrClassFunction());
clsSysParaEN.objLog.WriteDebugLog(strMsg);
throw new Exception(strMsg);
}
 }
return null;
}
return arrvResearchTopicObjLst_Sel.First();
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvResearchTopicEN> GetAllvResearchTopicObjLstCache(string strIdCurrEduCls)
{
//获取缓存中的对象列表
List<clsvResearchTopicEN> arrvResearchTopicObjLstCache = GetObjLstCache(strIdCurrEduCls); 
return arrvResearchTopicObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvResearchTopicEN> GetObjLstCache(string strIdCurrEduCls)
{

if (string.IsNullOrEmpty(strIdCurrEduCls) == true)
{
  var strMsg = string.Format("参数:[strIdCurrEduCls]不能为空!(In {0})", clsStackTrace.GetCurrClassFunction());
clsSysParaEN.objLog.WriteDebugLog(strMsg);
 throw new Exception (strMsg);
}
if (strIdCurrEduCls.Length != 8)
{
var strMsg = string.Format("缓存分类变量:[strIdCurrEduCls]的长度:[{0}]不正确!(In {1})", strIdCurrEduCls.Length, clsStackTrace.GetCurrClassFunction());
clsSysParaEN.objLog.WriteDebugLog(strMsg);
 throw new Exception (strMsg);
}
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}_{1}", clsvResearchTopicEN._CurrTabName, strIdCurrEduCls);
string strCondition = string.Format("IdCurrEduCls='{0}'", strIdCurrEduCls);
List<clsvResearchTopicEN> arrvResearchTopicObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst(strCondition); });
return arrvResearchTopicObjLstCache;
}

 /// <summary>
 /// 刷新本类中的缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ReFreshThisCache)
 /// </summary>
public static void ReFreshThisCache(string strIdCurrEduCls = "")
{
string strMsg;
if (clsSysParaEN.spSetRefreshCacheOn == true)
{
string strKey = string.Format("{0}_{1}", clsvResearchTopicEN._CurrTabName, strIdCurrEduCls);
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
 /// <param name = "strIdCurrEduCls">缓存的分类字段</param>
 /// <returns>返回一个输出字段值</returns>
public static string Func(string strInFldName, string strOutFldName, string strTopicId, string strIdCurrEduCls)
{
if (strInFldName != convResearchTopic.TopicId)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (convResearchTopic.AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", convResearchTopic.AttributeName));
throw new Exception(strMsg);
}
var objvResearchTopic = clsvResearchTopicBL.GetObjByTopicIdCache(strTopicId, strIdCurrEduCls);
if (objvResearchTopic == null) return "";
return objvResearchTopic[strOutFldName].ToString();
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
int intRecCount = clsvResearchTopicDA.GetRecCount(strTabName);
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
int intRecCount = clsvResearchTopicDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsvResearchTopicDA.GetRecCount();
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
int intRecCount = clsvResearchTopicDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objvResearchTopicCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsvResearchTopicEN objvResearchTopicCond)
{
 string strIdCurrEduCls = objvResearchTopicCond.IdCurrEduCls;
 if (string.IsNullOrEmpty(strIdCurrEduCls) == true)
{
string strMsg = string.Format("(errid:Busi000174)在表中,缓存分类字段值不能为空!(clsvResearchTopicBL:GetRecCountByCondCache)");
throw new Exception(strMsg);
}
List<clsvResearchTopicEN> arrObjLstCache = GetObjLstCache(strIdCurrEduCls);
IEnumerable <clsvResearchTopicEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convResearchTopic.AttributeName)
{
if (objvResearchTopicCond.IsUpdated(strFldName) == false) continue;
if (objvResearchTopicCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvResearchTopicCond[strFldName].ToString());
}
else
{
if (objvResearchTopicCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvResearchTopicCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvResearchTopicCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvResearchTopicCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvResearchTopicCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvResearchTopicCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvResearchTopicCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvResearchTopicCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvResearchTopicCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvResearchTopicCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvResearchTopicCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvResearchTopicCond[strFldName]));
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
 List<string> arrList = clsvResearchTopicDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = vResearchTopicDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = vResearchTopicDA.GetFldValueNoDistinct(strFldName, strWhereCond);
return arrList;
}



 #endregion 表操作常用函数
}
}