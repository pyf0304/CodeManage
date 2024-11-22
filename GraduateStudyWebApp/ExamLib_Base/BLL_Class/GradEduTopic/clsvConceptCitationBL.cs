
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvConceptCitationBL
 表名:vConceptCitation(01120611)
 * 版本:2023.08.23.1(服务器:WIN-SRV103-116)
 日期:2023/08/24 13:05:19
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
public static class  clsvConceptCitationBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvConceptCitationEN GetObj(this K_mId_vConceptCitation myKey)
{
clsvConceptCitationEN objvConceptCitationEN = clsvConceptCitationBL.vConceptCitationDA.GetObjBymId(myKey.Value);
return objvConceptCitationEN;
}

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvConceptCitationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvConceptCitationEN SetConceptContent(this clsvConceptCitationEN objvConceptCitationEN, string strConceptContent, string strComparisonOp="")
	{
objvConceptCitationEN.ConceptContent = strConceptContent; //概念内容
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvConceptCitationEN.dicFldComparisonOp.ContainsKey(convConceptCitation.ConceptContent) == false)
{
objvConceptCitationEN.dicFldComparisonOp.Add(convConceptCitation.ConceptContent, strComparisonOp);
}
else
{
objvConceptCitationEN.dicFldComparisonOp[convConceptCitation.ConceptContent] = strComparisonOp;
}
}
return objvConceptCitationEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvConceptCitationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvConceptCitationEN SetConceptId(this clsvConceptCitationEN objvConceptCitationEN, string strConceptId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strConceptId, 8, convConceptCitation.ConceptId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strConceptId, 8, convConceptCitation.ConceptId);
}
objvConceptCitationEN.ConceptId = strConceptId; //概念Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvConceptCitationEN.dicFldComparisonOp.ContainsKey(convConceptCitation.ConceptId) == false)
{
objvConceptCitationEN.dicFldComparisonOp.Add(convConceptCitation.ConceptId, strComparisonOp);
}
else
{
objvConceptCitationEN.dicFldComparisonOp[convConceptCitation.ConceptId] = strComparisonOp;
}
}
return objvConceptCitationEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvConceptCitationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvConceptCitationEN SetConceptName(this clsvConceptCitationEN objvConceptCitationEN, string strConceptName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strConceptName, 500, convConceptCitation.ConceptName);
}
objvConceptCitationEN.ConceptName = strConceptName; //概念名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvConceptCitationEN.dicFldComparisonOp.ContainsKey(convConceptCitation.ConceptName) == false)
{
objvConceptCitationEN.dicFldComparisonOp.Add(convConceptCitation.ConceptName, strComparisonOp);
}
else
{
objvConceptCitationEN.dicFldComparisonOp[convConceptCitation.ConceptName] = strComparisonOp;
}
}
return objvConceptCitationEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvConceptCitationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvConceptCitationEN SetUpdDate(this clsvConceptCitationEN objvConceptCitationEN, string strUpdDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdDate, 20, convConceptCitation.UpdDate);
}
objvConceptCitationEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvConceptCitationEN.dicFldComparisonOp.ContainsKey(convConceptCitation.UpdDate) == false)
{
objvConceptCitationEN.dicFldComparisonOp.Add(convConceptCitation.UpdDate, strComparisonOp);
}
else
{
objvConceptCitationEN.dicFldComparisonOp[convConceptCitation.UpdDate] = strComparisonOp;
}
}
return objvConceptCitationEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvConceptCitationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvConceptCitationEN SetmId(this clsvConceptCitationEN objvConceptCitationEN, long lngmId, string strComparisonOp="")
	{
objvConceptCitationEN.mId = lngmId; //mId
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvConceptCitationEN.dicFldComparisonOp.ContainsKey(convConceptCitation.mId) == false)
{
objvConceptCitationEN.dicFldComparisonOp.Add(convConceptCitation.mId, strComparisonOp);
}
else
{
objvConceptCitationEN.dicFldComparisonOp[convConceptCitation.mId] = strComparisonOp;
}
}
return objvConceptCitationEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvConceptCitationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvConceptCitationEN SetPaperId(this clsvConceptCitationEN objvConceptCitationEN, string strPaperId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPaperId, 8, convConceptCitation.PaperId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strPaperId, 8, convConceptCitation.PaperId);
}
objvConceptCitationEN.PaperId = strPaperId; //论文Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvConceptCitationEN.dicFldComparisonOp.ContainsKey(convConceptCitation.PaperId) == false)
{
objvConceptCitationEN.dicFldComparisonOp.Add(convConceptCitation.PaperId, strComparisonOp);
}
else
{
objvConceptCitationEN.dicFldComparisonOp[convConceptCitation.PaperId] = strComparisonOp;
}
}
return objvConceptCitationEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvConceptCitationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvConceptCitationEN SetPaperTitle(this clsvConceptCitationEN objvConceptCitationEN, string strPaperTitle, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPaperTitle, 500, convConceptCitation.PaperTitle);
}
objvConceptCitationEN.PaperTitle = strPaperTitle; //论文标题
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvConceptCitationEN.dicFldComparisonOp.ContainsKey(convConceptCitation.PaperTitle) == false)
{
objvConceptCitationEN.dicFldComparisonOp.Add(convConceptCitation.PaperTitle, strComparisonOp);
}
else
{
objvConceptCitationEN.dicFldComparisonOp[convConceptCitation.PaperTitle] = strComparisonOp;
}
}
return objvConceptCitationEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvConceptCitationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvConceptCitationEN SetPaperContent(this clsvConceptCitationEN objvConceptCitationEN, string strPaperContent, string strComparisonOp="")
	{
objvConceptCitationEN.PaperContent = strPaperContent; //主题内容
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvConceptCitationEN.dicFldComparisonOp.ContainsKey(convConceptCitation.PaperContent) == false)
{
objvConceptCitationEN.dicFldComparisonOp.Add(convConceptCitation.PaperContent, strComparisonOp);
}
else
{
objvConceptCitationEN.dicFldComparisonOp[convConceptCitation.PaperContent] = strComparisonOp;
}
}
return objvConceptCitationEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvConceptCitationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvConceptCitationEN SetUserName(this clsvConceptCitationEN objvConceptCitationEN, string strUserName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUserName, 30, convConceptCitation.UserName);
}
objvConceptCitationEN.UserName = strUserName; //用户名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvConceptCitationEN.dicFldComparisonOp.ContainsKey(convConceptCitation.UserName) == false)
{
objvConceptCitationEN.dicFldComparisonOp.Add(convConceptCitation.UserName, strComparisonOp);
}
else
{
objvConceptCitationEN.dicFldComparisonOp[convConceptCitation.UserName] = strComparisonOp;
}
}
return objvConceptCitationEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvConceptCitationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvConceptCitationEN SetUpdUserId(this clsvConceptCitationEN objvConceptCitationEN, string strUpdUserId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdUserId, 20, convConceptCitation.UpdUserId);
}
objvConceptCitationEN.UpdUserId = strUpdUserId; //修改用户Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvConceptCitationEN.dicFldComparisonOp.ContainsKey(convConceptCitation.UpdUserId) == false)
{
objvConceptCitationEN.dicFldComparisonOp.Add(convConceptCitation.UpdUserId, strComparisonOp);
}
else
{
objvConceptCitationEN.dicFldComparisonOp[convConceptCitation.UpdUserId] = strComparisonOp;
}
}
return objvConceptCitationEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvConceptCitationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvConceptCitationEN SetTopicId(this clsvConceptCitationEN objvConceptCitationEN, string strTopicId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTopicId, 8, convConceptCitation.TopicId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strTopicId, 8, convConceptCitation.TopicId);
}
objvConceptCitationEN.TopicId = strTopicId; //主题Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvConceptCitationEN.dicFldComparisonOp.ContainsKey(convConceptCitation.TopicId) == false)
{
objvConceptCitationEN.dicFldComparisonOp.Add(convConceptCitation.TopicId, strComparisonOp);
}
else
{
objvConceptCitationEN.dicFldComparisonOp[convConceptCitation.TopicId] = strComparisonOp;
}
}
return objvConceptCitationEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvConceptCitationEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvConceptCitationEN SetTopicName(this clsvConceptCitationEN objvConceptCitationEN, string strTopicName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTopicName, 200, convConceptCitation.TopicName);
}
objvConceptCitationEN.TopicName = strTopicName; //栏目主题
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvConceptCitationEN.dicFldComparisonOp.ContainsKey(convConceptCitation.TopicName) == false)
{
objvConceptCitationEN.dicFldComparisonOp.Add(convConceptCitation.TopicName, strComparisonOp);
}
else
{
objvConceptCitationEN.dicFldComparisonOp[convConceptCitation.TopicName] = strComparisonOp;
}
}
return objvConceptCitationEN;
	}

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CopyObj)
 /// </summary>
 /// <param name = "objvConceptCitationENS">源对象</param>
 /// <param name = "objvConceptCitationENT">目标对象</param>
 public static void CopyTo(this clsvConceptCitationEN objvConceptCitationENS, clsvConceptCitationEN objvConceptCitationENT)
{
try
{
objvConceptCitationENT.ConceptContent = objvConceptCitationENS.ConceptContent; //概念内容
objvConceptCitationENT.ConceptId = objvConceptCitationENS.ConceptId; //概念Id
objvConceptCitationENT.ConceptName = objvConceptCitationENS.ConceptName; //概念名称
objvConceptCitationENT.UpdDate = objvConceptCitationENS.UpdDate; //修改日期
objvConceptCitationENT.mId = objvConceptCitationENS.mId; //mId
objvConceptCitationENT.PaperId = objvConceptCitationENS.PaperId; //论文Id
objvConceptCitationENT.PaperTitle = objvConceptCitationENS.PaperTitle; //论文标题
objvConceptCitationENT.PaperContent = objvConceptCitationENS.PaperContent; //主题内容
objvConceptCitationENT.UserName = objvConceptCitationENS.UserName; //用户名
objvConceptCitationENT.UpdUserId = objvConceptCitationENS.UpdUserId; //修改用户Id
objvConceptCitationENT.TopicId = objvConceptCitationENS.TopicId; //主题Id
objvConceptCitationENT.TopicName = objvConceptCitationENS.TopicName; //栏目主题
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
 /// <param name = "objvConceptCitationENS">源对象</param>
 /// <returns>目标对象=>clsvConceptCitationEN:objvConceptCitationENT</returns>
 public static clsvConceptCitationEN CopyTo(this clsvConceptCitationEN objvConceptCitationENS)
{
try
{
 clsvConceptCitationEN objvConceptCitationENT = new clsvConceptCitationEN()
{
ConceptContent = objvConceptCitationENS.ConceptContent, //概念内容
ConceptId = objvConceptCitationENS.ConceptId, //概念Id
ConceptName = objvConceptCitationENS.ConceptName, //概念名称
UpdDate = objvConceptCitationENS.UpdDate, //修改日期
mId = objvConceptCitationENS.mId, //mId
PaperId = objvConceptCitationENS.PaperId, //论文Id
PaperTitle = objvConceptCitationENS.PaperTitle, //论文标题
PaperContent = objvConceptCitationENS.PaperContent, //主题内容
UserName = objvConceptCitationENS.UserName, //用户名
UpdUserId = objvConceptCitationENS.UpdUserId, //修改用户Id
TopicId = objvConceptCitationENS.TopicId, //主题Id
TopicName = objvConceptCitationENS.TopicName, //栏目主题
};
 return objvConceptCitationENT;
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
public static void CheckProperty4Condition(this clsvConceptCitationEN objvConceptCitationEN)
{
 clsvConceptCitationBL.vConceptCitationDA.CheckProperty4Condition(objvConceptCitationEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvConceptCitationEN objvConceptCitationCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
//数据类型string(text)在函数:[AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj]中没有处理!
if (objvConceptCitationCond.IsUpdated(convConceptCitation.ConceptId) == true)
{
string strComparisonOpConceptId = objvConceptCitationCond.dicFldComparisonOp[convConceptCitation.ConceptId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convConceptCitation.ConceptId, objvConceptCitationCond.ConceptId, strComparisonOpConceptId);
}
if (objvConceptCitationCond.IsUpdated(convConceptCitation.ConceptName) == true)
{
string strComparisonOpConceptName = objvConceptCitationCond.dicFldComparisonOp[convConceptCitation.ConceptName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convConceptCitation.ConceptName, objvConceptCitationCond.ConceptName, strComparisonOpConceptName);
}
if (objvConceptCitationCond.IsUpdated(convConceptCitation.UpdDate) == true)
{
string strComparisonOpUpdDate = objvConceptCitationCond.dicFldComparisonOp[convConceptCitation.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convConceptCitation.UpdDate, objvConceptCitationCond.UpdDate, strComparisonOpUpdDate);
}
if (objvConceptCitationCond.IsUpdated(convConceptCitation.mId) == true)
{
string strComparisonOpmId = objvConceptCitationCond.dicFldComparisonOp[convConceptCitation.mId];
strWhereCond += string.Format(" And {0} {2} {1}", convConceptCitation.mId, objvConceptCitationCond.mId, strComparisonOpmId);
}
if (objvConceptCitationCond.IsUpdated(convConceptCitation.PaperId) == true)
{
string strComparisonOpPaperId = objvConceptCitationCond.dicFldComparisonOp[convConceptCitation.PaperId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convConceptCitation.PaperId, objvConceptCitationCond.PaperId, strComparisonOpPaperId);
}
if (objvConceptCitationCond.IsUpdated(convConceptCitation.PaperTitle) == true)
{
string strComparisonOpPaperTitle = objvConceptCitationCond.dicFldComparisonOp[convConceptCitation.PaperTitle];
strWhereCond += string.Format(" And {0} {2} '{1}'", convConceptCitation.PaperTitle, objvConceptCitationCond.PaperTitle, strComparisonOpPaperTitle);
}
//数据类型string(text)在函数:[AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj]中没有处理!
if (objvConceptCitationCond.IsUpdated(convConceptCitation.UserName) == true)
{
string strComparisonOpUserName = objvConceptCitationCond.dicFldComparisonOp[convConceptCitation.UserName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convConceptCitation.UserName, objvConceptCitationCond.UserName, strComparisonOpUserName);
}
if (objvConceptCitationCond.IsUpdated(convConceptCitation.UpdUserId) == true)
{
string strComparisonOpUpdUserId = objvConceptCitationCond.dicFldComparisonOp[convConceptCitation.UpdUserId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convConceptCitation.UpdUserId, objvConceptCitationCond.UpdUserId, strComparisonOpUpdUserId);
}
if (objvConceptCitationCond.IsUpdated(convConceptCitation.TopicId) == true)
{
string strComparisonOpTopicId = objvConceptCitationCond.dicFldComparisonOp[convConceptCitation.TopicId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convConceptCitation.TopicId, objvConceptCitationCond.TopicId, strComparisonOpTopicId);
}
if (objvConceptCitationCond.IsUpdated(convConceptCitation.TopicName) == true)
{
string strComparisonOpTopicName = objvConceptCitationCond.dicFldComparisonOp[convConceptCitation.TopicName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convConceptCitation.TopicName, objvConceptCitationCond.TopicName, strComparisonOpTopicName);
}
 return strWhereCond;
}

 /// <summary>
 /// 检查唯一性(Uniqueness)--vConceptCitation(vConceptCitation), 如果不唯一,即存在相同的记录,就返回False
 /// 唯一性条件:mId_ConceptId_PaperId
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckConstraint)
 /// </summary>
 /// <param name = "objvConceptCitationEN">要求唯一的对象</param>
 /// <returns></returns>
public static bool CheckUniqueness(this clsvConceptCitationEN objvConceptCitationEN)
{
//检测记录是否存在
bool bolIsUniqueness;
StringBuilder sbCondition = new StringBuilder();
if (objvConceptCitationEN == null) return true;
if (objvConceptCitationEN.mId == 0)
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and mId = '{0}'", objvConceptCitationEN.mId);
 if (objvConceptCitationEN.ConceptId == null)
{
 sbCondition.AppendFormat(" and ConceptId is null", objvConceptCitationEN.ConceptId);
}
else
{
 sbCondition.AppendFormat(" and ConceptId = '{0}'", objvConceptCitationEN.ConceptId);
}
 if (objvConceptCitationEN.PaperId == null)
{
 sbCondition.AppendFormat(" and PaperId is null", objvConceptCitationEN.PaperId);
}
else
{
 sbCondition.AppendFormat(" and PaperId = '{0}'", objvConceptCitationEN.PaperId);
}
if (clsvConceptCitationBL.IsExistRecord(sbCondition.ToString())  ==  true)
{
 bolIsUniqueness = false;
}
else
{
 bolIsUniqueness = true;
}
}
 else {
sbCondition.AppendFormat("mId !=  {0}", objvConceptCitationEN.mId);
 sbCondition.AppendFormat(" and mId = '{0}'", objvConceptCitationEN.mId);
 sbCondition.AppendFormat(" and ConceptId = '{0}'", objvConceptCitationEN.ConceptId);
 sbCondition.AppendFormat(" and PaperId = '{0}'", objvConceptCitationEN.PaperId);
if (clsvConceptCitationBL.IsExistRecord(sbCondition.ToString())  ==  true)
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
 /// 获取唯一性条件串--vConceptCitation(vConceptCitation), 即由对象中唯一性条件字段关键字与值组成的条件串
 /// 唯一性条件:mId_ConceptId_PaperId
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetConditionString4Constraint)
 /// </summary>
 /// <param name = "objvConceptCitationEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(this clsvConceptCitationEN objvConceptCitationEN)
{
//检测记录是否存在
StringBuilder sbCondition = new StringBuilder();
if (objvConceptCitationEN == null) return "";
if (objvConceptCitationEN.mId == 0)
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and mId = '{0}'", objvConceptCitationEN.mId);
 if (objvConceptCitationEN.ConceptId == null)
{
 sbCondition.AppendFormat(" and ConceptId is null", objvConceptCitationEN.ConceptId);
}
else
{
 sbCondition.AppendFormat(" and ConceptId = '{0}'", objvConceptCitationEN.ConceptId);
}
 if (objvConceptCitationEN.PaperId == null)
{
 sbCondition.AppendFormat(" and PaperId is null", objvConceptCitationEN.PaperId);
}
else
{
 sbCondition.AppendFormat(" and PaperId = '{0}'", objvConceptCitationEN.PaperId);
}
return sbCondition.ToString();
}
 else {
sbCondition.AppendFormat("mId !=  {0}", objvConceptCitationEN.mId);
 sbCondition.AppendFormat(" and mId = '{0}'", objvConceptCitationEN.mId);
 sbCondition.AppendFormat(" and ConceptId = '{0}'", objvConceptCitationEN.ConceptId);
 sbCondition.AppendFormat(" and PaperId = '{0}'", objvConceptCitationEN.PaperId);
 return sbCondition.ToString();
}
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_vConceptCitation
{
public virtual bool UpdRelaTabDate(long lngmId, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// vConceptCitation(vConceptCitation)
 /// 数据源类型:视图
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsvConceptCitationBL
{
public static RelatedActions_vConceptCitation relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsvConceptCitationDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsvConceptCitationDA vConceptCitationDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsvConceptCitationDA();
}
return uniqueInstance;
}
}

 /// <summary>
 /// 类的构造函数
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ClassConstructor1)
 /// </summary>
 public clsvConceptCitationBL()
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
if (string.IsNullOrEmpty(clsvConceptCitationEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvConceptCitationEN._ConnectString);
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
public static DataTable GetDataTable_vConceptCitation(string strWhereCond)
{
DataTable objDT;
try
{
objDT = vConceptCitationDA.GetDataTable_vConceptCitation(strWhereCond);
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
objDT = vConceptCitationDA.GetDataTable(strWhereCond);
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
objDT = vConceptCitationDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = vConceptCitationDA.GetDataTable(strWhereCond, strTabName);
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
objDT = vConceptCitationDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = vConceptCitationDA.GetDataTable_Top(objTopPara);
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
objDT = vConceptCitationDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = vConceptCitationDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = vConceptCitationDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
 /// <param name = "arrMIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static List<clsvConceptCitationEN> GetObjLstByMIdLst(List<long> arrMIdLst)
{
List<clsvConceptCitationEN> arrObjLst = new List<clsvConceptCitationEN>(); 
System.Data.DataTable objDT; 
 string strSqlConditionStr = clsArray.GetSqlInStrByArray(arrMIdLst);
 string strWhereCond = string.Format("mId in ({0})", strSqlConditionStr);
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvConceptCitationEN objvConceptCitationEN = new clsvConceptCitationEN();
try
{
objvConceptCitationEN.ConceptContent = objRow[convConceptCitation.ConceptContent] == DBNull.Value ? null : objRow[convConceptCitation.ConceptContent].ToString().Trim(); //概念内容
objvConceptCitationEN.ConceptId = objRow[convConceptCitation.ConceptId] == DBNull.Value ? null : objRow[convConceptCitation.ConceptId].ToString().Trim(); //概念Id
objvConceptCitationEN.ConceptName = objRow[convConceptCitation.ConceptName] == DBNull.Value ? null : objRow[convConceptCitation.ConceptName].ToString().Trim(); //概念名称
objvConceptCitationEN.UpdDate = objRow[convConceptCitation.UpdDate] == DBNull.Value ? null : objRow[convConceptCitation.UpdDate].ToString().Trim(); //修改日期
objvConceptCitationEN.mId = Int32.Parse(objRow[convConceptCitation.mId].ToString().Trim()); //mId
objvConceptCitationEN.PaperId = objRow[convConceptCitation.PaperId] == DBNull.Value ? null : objRow[convConceptCitation.PaperId].ToString().Trim(); //论文Id
objvConceptCitationEN.PaperTitle = objRow[convConceptCitation.PaperTitle] == DBNull.Value ? null : objRow[convConceptCitation.PaperTitle].ToString().Trim(); //论文标题
objvConceptCitationEN.PaperContent = objRow[convConceptCitation.PaperContent] == DBNull.Value ? null : objRow[convConceptCitation.PaperContent].ToString().Trim(); //主题内容
objvConceptCitationEN.UserName = objRow[convConceptCitation.UserName] == DBNull.Value ? null : objRow[convConceptCitation.UserName].ToString().Trim(); //用户名
objvConceptCitationEN.UpdUserId = objRow[convConceptCitation.UpdUserId] == DBNull.Value ? null : objRow[convConceptCitation.UpdUserId].ToString().Trim(); //修改用户Id
objvConceptCitationEN.TopicId = objRow[convConceptCitation.TopicId] == DBNull.Value ? null : objRow[convConceptCitation.TopicId].ToString().Trim(); //主题Id
objvConceptCitationEN.TopicName = objRow[convConceptCitation.TopicName] == DBNull.Value ? null : objRow[convConceptCitation.TopicName].ToString().Trim(); //栏目主题
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvConceptCitationEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvConceptCitationEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrMIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsvConceptCitationEN> GetObjLstByMIdLstCache(List<long> arrMIdLst)
{
string strKey = string.Format("{0}", clsvConceptCitationEN._CurrTabName);
List<clsvConceptCitationEN> arrvConceptCitationObjLstCache = GetObjLstCache();
IEnumerable <clsvConceptCitationEN> arrvConceptCitationObjLst_Sel =
arrvConceptCitationObjLstCache
.Where(x => arrMIdLst.Contains(x.mId));
return arrvConceptCitationObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvConceptCitationEN> GetObjLst(string strWhereCond)
{
List<clsvConceptCitationEN> arrObjLst = new List<clsvConceptCitationEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvConceptCitationEN objvConceptCitationEN = new clsvConceptCitationEN();
try
{
objvConceptCitationEN.ConceptContent = objRow[convConceptCitation.ConceptContent] == DBNull.Value ? null : objRow[convConceptCitation.ConceptContent].ToString().Trim(); //概念内容
objvConceptCitationEN.ConceptId = objRow[convConceptCitation.ConceptId] == DBNull.Value ? null : objRow[convConceptCitation.ConceptId].ToString().Trim(); //概念Id
objvConceptCitationEN.ConceptName = objRow[convConceptCitation.ConceptName] == DBNull.Value ? null : objRow[convConceptCitation.ConceptName].ToString().Trim(); //概念名称
objvConceptCitationEN.UpdDate = objRow[convConceptCitation.UpdDate] == DBNull.Value ? null : objRow[convConceptCitation.UpdDate].ToString().Trim(); //修改日期
objvConceptCitationEN.mId = Int32.Parse(objRow[convConceptCitation.mId].ToString().Trim()); //mId
objvConceptCitationEN.PaperId = objRow[convConceptCitation.PaperId] == DBNull.Value ? null : objRow[convConceptCitation.PaperId].ToString().Trim(); //论文Id
objvConceptCitationEN.PaperTitle = objRow[convConceptCitation.PaperTitle] == DBNull.Value ? null : objRow[convConceptCitation.PaperTitle].ToString().Trim(); //论文标题
objvConceptCitationEN.PaperContent = objRow[convConceptCitation.PaperContent] == DBNull.Value ? null : objRow[convConceptCitation.PaperContent].ToString().Trim(); //主题内容
objvConceptCitationEN.UserName = objRow[convConceptCitation.UserName] == DBNull.Value ? null : objRow[convConceptCitation.UserName].ToString().Trim(); //用户名
objvConceptCitationEN.UpdUserId = objRow[convConceptCitation.UpdUserId] == DBNull.Value ? null : objRow[convConceptCitation.UpdUserId].ToString().Trim(); //修改用户Id
objvConceptCitationEN.TopicId = objRow[convConceptCitation.TopicId] == DBNull.Value ? null : objRow[convConceptCitation.TopicId].ToString().Trim(); //主题Id
objvConceptCitationEN.TopicName = objRow[convConceptCitation.TopicName] == DBNull.Value ? null : objRow[convConceptCitation.TopicName].ToString().Trim(); //栏目主题
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvConceptCitationEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvConceptCitationEN);
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
public static List<clsvConceptCitationEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsvConceptCitationEN> arrObjLst = new List<clsvConceptCitationEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvConceptCitationEN objvConceptCitationEN = new clsvConceptCitationEN();
try
{
objvConceptCitationEN.ConceptContent = objRow[convConceptCitation.ConceptContent] == DBNull.Value ? null : objRow[convConceptCitation.ConceptContent].ToString().Trim(); //概念内容
objvConceptCitationEN.ConceptId = objRow[convConceptCitation.ConceptId] == DBNull.Value ? null : objRow[convConceptCitation.ConceptId].ToString().Trim(); //概念Id
objvConceptCitationEN.ConceptName = objRow[convConceptCitation.ConceptName] == DBNull.Value ? null : objRow[convConceptCitation.ConceptName].ToString().Trim(); //概念名称
objvConceptCitationEN.UpdDate = objRow[convConceptCitation.UpdDate] == DBNull.Value ? null : objRow[convConceptCitation.UpdDate].ToString().Trim(); //修改日期
objvConceptCitationEN.mId = Int32.Parse(objRow[convConceptCitation.mId].ToString().Trim()); //mId
objvConceptCitationEN.PaperId = objRow[convConceptCitation.PaperId] == DBNull.Value ? null : objRow[convConceptCitation.PaperId].ToString().Trim(); //论文Id
objvConceptCitationEN.PaperTitle = objRow[convConceptCitation.PaperTitle] == DBNull.Value ? null : objRow[convConceptCitation.PaperTitle].ToString().Trim(); //论文标题
objvConceptCitationEN.PaperContent = objRow[convConceptCitation.PaperContent] == DBNull.Value ? null : objRow[convConceptCitation.PaperContent].ToString().Trim(); //主题内容
objvConceptCitationEN.UserName = objRow[convConceptCitation.UserName] == DBNull.Value ? null : objRow[convConceptCitation.UserName].ToString().Trim(); //用户名
objvConceptCitationEN.UpdUserId = objRow[convConceptCitation.UpdUserId] == DBNull.Value ? null : objRow[convConceptCitation.UpdUserId].ToString().Trim(); //修改用户Id
objvConceptCitationEN.TopicId = objRow[convConceptCitation.TopicId] == DBNull.Value ? null : objRow[convConceptCitation.TopicId].ToString().Trim(); //主题Id
objvConceptCitationEN.TopicName = objRow[convConceptCitation.TopicName] == DBNull.Value ? null : objRow[convConceptCitation.TopicName].ToString().Trim(); //栏目主题
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvConceptCitationEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvConceptCitationEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objvConceptCitationCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsvConceptCitationEN> GetSubObjLstCache(clsvConceptCitationEN objvConceptCitationCond)
{
List<clsvConceptCitationEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsvConceptCitationEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convConceptCitation.AttributeName)
{
if (objvConceptCitationCond.IsUpdated(strFldName) == false) continue;
if (objvConceptCitationCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvConceptCitationCond[strFldName].ToString());
}
else
{
if (objvConceptCitationCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvConceptCitationCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvConceptCitationCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvConceptCitationCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvConceptCitationCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvConceptCitationCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvConceptCitationCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvConceptCitationCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvConceptCitationCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvConceptCitationCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvConceptCitationCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvConceptCitationCond[strFldName]));
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
public static List<clsvConceptCitationEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsvConceptCitationEN> arrObjLst = new List<clsvConceptCitationEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvConceptCitationEN objvConceptCitationEN = new clsvConceptCitationEN();
try
{
objvConceptCitationEN.ConceptContent = objRow[convConceptCitation.ConceptContent] == DBNull.Value ? null : objRow[convConceptCitation.ConceptContent].ToString().Trim(); //概念内容
objvConceptCitationEN.ConceptId = objRow[convConceptCitation.ConceptId] == DBNull.Value ? null : objRow[convConceptCitation.ConceptId].ToString().Trim(); //概念Id
objvConceptCitationEN.ConceptName = objRow[convConceptCitation.ConceptName] == DBNull.Value ? null : objRow[convConceptCitation.ConceptName].ToString().Trim(); //概念名称
objvConceptCitationEN.UpdDate = objRow[convConceptCitation.UpdDate] == DBNull.Value ? null : objRow[convConceptCitation.UpdDate].ToString().Trim(); //修改日期
objvConceptCitationEN.mId = Int32.Parse(objRow[convConceptCitation.mId].ToString().Trim()); //mId
objvConceptCitationEN.PaperId = objRow[convConceptCitation.PaperId] == DBNull.Value ? null : objRow[convConceptCitation.PaperId].ToString().Trim(); //论文Id
objvConceptCitationEN.PaperTitle = objRow[convConceptCitation.PaperTitle] == DBNull.Value ? null : objRow[convConceptCitation.PaperTitle].ToString().Trim(); //论文标题
objvConceptCitationEN.PaperContent = objRow[convConceptCitation.PaperContent] == DBNull.Value ? null : objRow[convConceptCitation.PaperContent].ToString().Trim(); //主题内容
objvConceptCitationEN.UserName = objRow[convConceptCitation.UserName] == DBNull.Value ? null : objRow[convConceptCitation.UserName].ToString().Trim(); //用户名
objvConceptCitationEN.UpdUserId = objRow[convConceptCitation.UpdUserId] == DBNull.Value ? null : objRow[convConceptCitation.UpdUserId].ToString().Trim(); //修改用户Id
objvConceptCitationEN.TopicId = objRow[convConceptCitation.TopicId] == DBNull.Value ? null : objRow[convConceptCitation.TopicId].ToString().Trim(); //主题Id
objvConceptCitationEN.TopicName = objRow[convConceptCitation.TopicName] == DBNull.Value ? null : objRow[convConceptCitation.TopicName].ToString().Trim(); //栏目主题
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvConceptCitationEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvConceptCitationEN);
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
public static List<clsvConceptCitationEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsvConceptCitationEN> arrObjLst = new List<clsvConceptCitationEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvConceptCitationEN objvConceptCitationEN = new clsvConceptCitationEN();
try
{
objvConceptCitationEN.ConceptContent = objRow[convConceptCitation.ConceptContent] == DBNull.Value ? null : objRow[convConceptCitation.ConceptContent].ToString().Trim(); //概念内容
objvConceptCitationEN.ConceptId = objRow[convConceptCitation.ConceptId] == DBNull.Value ? null : objRow[convConceptCitation.ConceptId].ToString().Trim(); //概念Id
objvConceptCitationEN.ConceptName = objRow[convConceptCitation.ConceptName] == DBNull.Value ? null : objRow[convConceptCitation.ConceptName].ToString().Trim(); //概念名称
objvConceptCitationEN.UpdDate = objRow[convConceptCitation.UpdDate] == DBNull.Value ? null : objRow[convConceptCitation.UpdDate].ToString().Trim(); //修改日期
objvConceptCitationEN.mId = Int32.Parse(objRow[convConceptCitation.mId].ToString().Trim()); //mId
objvConceptCitationEN.PaperId = objRow[convConceptCitation.PaperId] == DBNull.Value ? null : objRow[convConceptCitation.PaperId].ToString().Trim(); //论文Id
objvConceptCitationEN.PaperTitle = objRow[convConceptCitation.PaperTitle] == DBNull.Value ? null : objRow[convConceptCitation.PaperTitle].ToString().Trim(); //论文标题
objvConceptCitationEN.PaperContent = objRow[convConceptCitation.PaperContent] == DBNull.Value ? null : objRow[convConceptCitation.PaperContent].ToString().Trim(); //主题内容
objvConceptCitationEN.UserName = objRow[convConceptCitation.UserName] == DBNull.Value ? null : objRow[convConceptCitation.UserName].ToString().Trim(); //用户名
objvConceptCitationEN.UpdUserId = objRow[convConceptCitation.UpdUserId] == DBNull.Value ? null : objRow[convConceptCitation.UpdUserId].ToString().Trim(); //修改用户Id
objvConceptCitationEN.TopicId = objRow[convConceptCitation.TopicId] == DBNull.Value ? null : objRow[convConceptCitation.TopicId].ToString().Trim(); //主题Id
objvConceptCitationEN.TopicName = objRow[convConceptCitation.TopicName] == DBNull.Value ? null : objRow[convConceptCitation.TopicName].ToString().Trim(); //栏目主题
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvConceptCitationEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvConceptCitationEN);
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
List<clsvConceptCitationEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsvConceptCitationEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsvConceptCitationEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsvConceptCitationEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsvConceptCitationEN> arrObjLst = new List<clsvConceptCitationEN>(); 
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
	clsvConceptCitationEN objvConceptCitationEN = new clsvConceptCitationEN();
try
{
objvConceptCitationEN.ConceptContent = objRow[convConceptCitation.ConceptContent] == DBNull.Value ? null : objRow[convConceptCitation.ConceptContent].ToString().Trim(); //概念内容
objvConceptCitationEN.ConceptId = objRow[convConceptCitation.ConceptId] == DBNull.Value ? null : objRow[convConceptCitation.ConceptId].ToString().Trim(); //概念Id
objvConceptCitationEN.ConceptName = objRow[convConceptCitation.ConceptName] == DBNull.Value ? null : objRow[convConceptCitation.ConceptName].ToString().Trim(); //概念名称
objvConceptCitationEN.UpdDate = objRow[convConceptCitation.UpdDate] == DBNull.Value ? null : objRow[convConceptCitation.UpdDate].ToString().Trim(); //修改日期
objvConceptCitationEN.mId = Int32.Parse(objRow[convConceptCitation.mId].ToString().Trim()); //mId
objvConceptCitationEN.PaperId = objRow[convConceptCitation.PaperId] == DBNull.Value ? null : objRow[convConceptCitation.PaperId].ToString().Trim(); //论文Id
objvConceptCitationEN.PaperTitle = objRow[convConceptCitation.PaperTitle] == DBNull.Value ? null : objRow[convConceptCitation.PaperTitle].ToString().Trim(); //论文标题
objvConceptCitationEN.PaperContent = objRow[convConceptCitation.PaperContent] == DBNull.Value ? null : objRow[convConceptCitation.PaperContent].ToString().Trim(); //主题内容
objvConceptCitationEN.UserName = objRow[convConceptCitation.UserName] == DBNull.Value ? null : objRow[convConceptCitation.UserName].ToString().Trim(); //用户名
objvConceptCitationEN.UpdUserId = objRow[convConceptCitation.UpdUserId] == DBNull.Value ? null : objRow[convConceptCitation.UpdUserId].ToString().Trim(); //修改用户Id
objvConceptCitationEN.TopicId = objRow[convConceptCitation.TopicId] == DBNull.Value ? null : objRow[convConceptCitation.TopicId].ToString().Trim(); //主题Id
objvConceptCitationEN.TopicName = objRow[convConceptCitation.TopicName] == DBNull.Value ? null : objRow[convConceptCitation.TopicName].ToString().Trim(); //栏目主题
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvConceptCitationEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvConceptCitationEN);
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
public static List<clsvConceptCitationEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsvConceptCitationEN> arrObjLst = new List<clsvConceptCitationEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvConceptCitationEN objvConceptCitationEN = new clsvConceptCitationEN();
try
{
objvConceptCitationEN.ConceptContent = objRow[convConceptCitation.ConceptContent] == DBNull.Value ? null : objRow[convConceptCitation.ConceptContent].ToString().Trim(); //概念内容
objvConceptCitationEN.ConceptId = objRow[convConceptCitation.ConceptId] == DBNull.Value ? null : objRow[convConceptCitation.ConceptId].ToString().Trim(); //概念Id
objvConceptCitationEN.ConceptName = objRow[convConceptCitation.ConceptName] == DBNull.Value ? null : objRow[convConceptCitation.ConceptName].ToString().Trim(); //概念名称
objvConceptCitationEN.UpdDate = objRow[convConceptCitation.UpdDate] == DBNull.Value ? null : objRow[convConceptCitation.UpdDate].ToString().Trim(); //修改日期
objvConceptCitationEN.mId = Int32.Parse(objRow[convConceptCitation.mId].ToString().Trim()); //mId
objvConceptCitationEN.PaperId = objRow[convConceptCitation.PaperId] == DBNull.Value ? null : objRow[convConceptCitation.PaperId].ToString().Trim(); //论文Id
objvConceptCitationEN.PaperTitle = objRow[convConceptCitation.PaperTitle] == DBNull.Value ? null : objRow[convConceptCitation.PaperTitle].ToString().Trim(); //论文标题
objvConceptCitationEN.PaperContent = objRow[convConceptCitation.PaperContent] == DBNull.Value ? null : objRow[convConceptCitation.PaperContent].ToString().Trim(); //主题内容
objvConceptCitationEN.UserName = objRow[convConceptCitation.UserName] == DBNull.Value ? null : objRow[convConceptCitation.UserName].ToString().Trim(); //用户名
objvConceptCitationEN.UpdUserId = objRow[convConceptCitation.UpdUserId] == DBNull.Value ? null : objRow[convConceptCitation.UpdUserId].ToString().Trim(); //修改用户Id
objvConceptCitationEN.TopicId = objRow[convConceptCitation.TopicId] == DBNull.Value ? null : objRow[convConceptCitation.TopicId].ToString().Trim(); //主题Id
objvConceptCitationEN.TopicName = objRow[convConceptCitation.TopicName] == DBNull.Value ? null : objRow[convConceptCitation.TopicName].ToString().Trim(); //栏目主题
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvConceptCitationEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvConceptCitationEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsvConceptCitationEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsvConceptCitationEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsvConceptCitationEN> arrObjLst = new List<clsvConceptCitationEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvConceptCitationEN objvConceptCitationEN = new clsvConceptCitationEN();
try
{
objvConceptCitationEN.ConceptContent = objRow[convConceptCitation.ConceptContent] == DBNull.Value ? null : objRow[convConceptCitation.ConceptContent].ToString().Trim(); //概念内容
objvConceptCitationEN.ConceptId = objRow[convConceptCitation.ConceptId] == DBNull.Value ? null : objRow[convConceptCitation.ConceptId].ToString().Trim(); //概念Id
objvConceptCitationEN.ConceptName = objRow[convConceptCitation.ConceptName] == DBNull.Value ? null : objRow[convConceptCitation.ConceptName].ToString().Trim(); //概念名称
objvConceptCitationEN.UpdDate = objRow[convConceptCitation.UpdDate] == DBNull.Value ? null : objRow[convConceptCitation.UpdDate].ToString().Trim(); //修改日期
objvConceptCitationEN.mId = Int32.Parse(objRow[convConceptCitation.mId].ToString().Trim()); //mId
objvConceptCitationEN.PaperId = objRow[convConceptCitation.PaperId] == DBNull.Value ? null : objRow[convConceptCitation.PaperId].ToString().Trim(); //论文Id
objvConceptCitationEN.PaperTitle = objRow[convConceptCitation.PaperTitle] == DBNull.Value ? null : objRow[convConceptCitation.PaperTitle].ToString().Trim(); //论文标题
objvConceptCitationEN.PaperContent = objRow[convConceptCitation.PaperContent] == DBNull.Value ? null : objRow[convConceptCitation.PaperContent].ToString().Trim(); //主题内容
objvConceptCitationEN.UserName = objRow[convConceptCitation.UserName] == DBNull.Value ? null : objRow[convConceptCitation.UserName].ToString().Trim(); //用户名
objvConceptCitationEN.UpdUserId = objRow[convConceptCitation.UpdUserId] == DBNull.Value ? null : objRow[convConceptCitation.UpdUserId].ToString().Trim(); //修改用户Id
objvConceptCitationEN.TopicId = objRow[convConceptCitation.TopicId] == DBNull.Value ? null : objRow[convConceptCitation.TopicId].ToString().Trim(); //主题Id
objvConceptCitationEN.TopicName = objRow[convConceptCitation.TopicName] == DBNull.Value ? null : objRow[convConceptCitation.TopicName].ToString().Trim(); //栏目主题
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvConceptCitationEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvConceptCitationEN);
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
public static List<clsvConceptCitationEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsvConceptCitationEN> arrObjLst = new List<clsvConceptCitationEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvConceptCitationEN objvConceptCitationEN = new clsvConceptCitationEN();
try
{
objvConceptCitationEN.ConceptContent = objRow[convConceptCitation.ConceptContent] == DBNull.Value ? null : objRow[convConceptCitation.ConceptContent].ToString().Trim(); //概念内容
objvConceptCitationEN.ConceptId = objRow[convConceptCitation.ConceptId] == DBNull.Value ? null : objRow[convConceptCitation.ConceptId].ToString().Trim(); //概念Id
objvConceptCitationEN.ConceptName = objRow[convConceptCitation.ConceptName] == DBNull.Value ? null : objRow[convConceptCitation.ConceptName].ToString().Trim(); //概念名称
objvConceptCitationEN.UpdDate = objRow[convConceptCitation.UpdDate] == DBNull.Value ? null : objRow[convConceptCitation.UpdDate].ToString().Trim(); //修改日期
objvConceptCitationEN.mId = Int32.Parse(objRow[convConceptCitation.mId].ToString().Trim()); //mId
objvConceptCitationEN.PaperId = objRow[convConceptCitation.PaperId] == DBNull.Value ? null : objRow[convConceptCitation.PaperId].ToString().Trim(); //论文Id
objvConceptCitationEN.PaperTitle = objRow[convConceptCitation.PaperTitle] == DBNull.Value ? null : objRow[convConceptCitation.PaperTitle].ToString().Trim(); //论文标题
objvConceptCitationEN.PaperContent = objRow[convConceptCitation.PaperContent] == DBNull.Value ? null : objRow[convConceptCitation.PaperContent].ToString().Trim(); //主题内容
objvConceptCitationEN.UserName = objRow[convConceptCitation.UserName] == DBNull.Value ? null : objRow[convConceptCitation.UserName].ToString().Trim(); //用户名
objvConceptCitationEN.UpdUserId = objRow[convConceptCitation.UpdUserId] == DBNull.Value ? null : objRow[convConceptCitation.UpdUserId].ToString().Trim(); //修改用户Id
objvConceptCitationEN.TopicId = objRow[convConceptCitation.TopicId] == DBNull.Value ? null : objRow[convConceptCitation.TopicId].ToString().Trim(); //主题Id
objvConceptCitationEN.TopicName = objRow[convConceptCitation.TopicName] == DBNull.Value ? null : objRow[convConceptCitation.TopicName].ToString().Trim(); //栏目主题
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvConceptCitationEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvConceptCitationEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsvConceptCitationEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsvConceptCitationEN> arrObjLst = new List<clsvConceptCitationEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvConceptCitationEN objvConceptCitationEN = new clsvConceptCitationEN();
try
{
objvConceptCitationEN.ConceptContent = objRow[convConceptCitation.ConceptContent] == DBNull.Value ? null : objRow[convConceptCitation.ConceptContent].ToString().Trim(); //概念内容
objvConceptCitationEN.ConceptId = objRow[convConceptCitation.ConceptId] == DBNull.Value ? null : objRow[convConceptCitation.ConceptId].ToString().Trim(); //概念Id
objvConceptCitationEN.ConceptName = objRow[convConceptCitation.ConceptName] == DBNull.Value ? null : objRow[convConceptCitation.ConceptName].ToString().Trim(); //概念名称
objvConceptCitationEN.UpdDate = objRow[convConceptCitation.UpdDate] == DBNull.Value ? null : objRow[convConceptCitation.UpdDate].ToString().Trim(); //修改日期
objvConceptCitationEN.mId = Int32.Parse(objRow[convConceptCitation.mId].ToString().Trim()); //mId
objvConceptCitationEN.PaperId = objRow[convConceptCitation.PaperId] == DBNull.Value ? null : objRow[convConceptCitation.PaperId].ToString().Trim(); //论文Id
objvConceptCitationEN.PaperTitle = objRow[convConceptCitation.PaperTitle] == DBNull.Value ? null : objRow[convConceptCitation.PaperTitle].ToString().Trim(); //论文标题
objvConceptCitationEN.PaperContent = objRow[convConceptCitation.PaperContent] == DBNull.Value ? null : objRow[convConceptCitation.PaperContent].ToString().Trim(); //主题内容
objvConceptCitationEN.UserName = objRow[convConceptCitation.UserName] == DBNull.Value ? null : objRow[convConceptCitation.UserName].ToString().Trim(); //用户名
objvConceptCitationEN.UpdUserId = objRow[convConceptCitation.UpdUserId] == DBNull.Value ? null : objRow[convConceptCitation.UpdUserId].ToString().Trim(); //修改用户Id
objvConceptCitationEN.TopicId = objRow[convConceptCitation.TopicId] == DBNull.Value ? null : objRow[convConceptCitation.TopicId].ToString().Trim(); //主题Id
objvConceptCitationEN.TopicName = objRow[convConceptCitation.TopicName] == DBNull.Value ? null : objRow[convConceptCitation.TopicName].ToString().Trim(); //栏目主题
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvConceptCitationEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvConceptCitationEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objvConceptCitationEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetvConceptCitation(ref clsvConceptCitationEN objvConceptCitationEN)
{
bool bolResult = vConceptCitationDA.GetvConceptCitation(ref objvConceptCitationEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvConceptCitationEN GetObjBymId(long lngmId)
{
clsvConceptCitationEN objvConceptCitationEN = vConceptCitationDA.GetObjBymId(lngmId);
return objvConceptCitationEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsvConceptCitationEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsvConceptCitationEN objvConceptCitationEN = vConceptCitationDA.GetFirstObj(strWhereCond);
 return objvConceptCitationEN;
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
public static clsvConceptCitationEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsvConceptCitationEN objvConceptCitationEN = vConceptCitationDA.GetObjByDataRow(objRow);
 return objvConceptCitationEN;
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
public static clsvConceptCitationEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsvConceptCitationEN objvConceptCitationEN = vConceptCitationDA.GetObjByDataRow(objRow);
 return objvConceptCitationEN;
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
 /// <param name = "lngmId">所给的关键字</param>
 /// <param name = "lstvConceptCitationObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvConceptCitationEN GetObjBymIdFromList(long lngmId, List<clsvConceptCitationEN> lstvConceptCitationObjLst)
{
foreach (clsvConceptCitationEN objvConceptCitationEN in lstvConceptCitationObjLst)
{
if (objvConceptCitationEN.mId == lngmId)
{
return objvConceptCitationEN;
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
public static long GetFirstID_S(string strWhereCond) 
{
 long lngmId;
 try
 {
 lngmId = new clsvConceptCitationDA().GetFirstID(strWhereCond);
 return lngmId;
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
 arrList = vConceptCitationDA.GetID(strWhereCond);
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
bool bolIsExist = vConceptCitationDA.IsExistCondRec(strWhereCond);
return bolIsExist;
}

 /// <summary>
 /// 判断当前表中是否存在给定关键字值的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExist)
 /// </summary>
 /// <param name = "lngmId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public static bool IsExist(long lngmId)
{
//检测记录是否存在
bool bolIsExist = vConceptCitationDA.IsExist(lngmId);
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
 bolIsExist = clsvConceptCitationDA.IsExistTable();
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
 bolIsExist = vConceptCitationDA.IsExistTable(strTabName);
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
 /// <param name = "objvConceptCitationENS">源对象</param>
 /// <param name = "objvConceptCitationENT">目标对象</param>
 public static void CopyTo(clsvConceptCitationEN objvConceptCitationENS, clsvConceptCitationEN objvConceptCitationENT)
{
try
{
objvConceptCitationENT.ConceptContent = objvConceptCitationENS.ConceptContent; //概念内容
objvConceptCitationENT.ConceptId = objvConceptCitationENS.ConceptId; //概念Id
objvConceptCitationENT.ConceptName = objvConceptCitationENS.ConceptName; //概念名称
objvConceptCitationENT.UpdDate = objvConceptCitationENS.UpdDate; //修改日期
objvConceptCitationENT.mId = objvConceptCitationENS.mId; //mId
objvConceptCitationENT.PaperId = objvConceptCitationENS.PaperId; //论文Id
objvConceptCitationENT.PaperTitle = objvConceptCitationENS.PaperTitle; //论文标题
objvConceptCitationENT.PaperContent = objvConceptCitationENS.PaperContent; //主题内容
objvConceptCitationENT.UserName = objvConceptCitationENS.UserName; //用户名
objvConceptCitationENT.UpdUserId = objvConceptCitationENS.UpdUserId; //修改用户Id
objvConceptCitationENT.TopicId = objvConceptCitationENS.TopicId; //主题Id
objvConceptCitationENT.TopicName = objvConceptCitationENS.TopicName; //栏目主题
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
 /// <param name = "objvConceptCitationEN">源简化对象</param>
 public static void SetUpdFlag(clsvConceptCitationEN objvConceptCitationEN)
{
try
{
objvConceptCitationEN.ClearUpdateState();
   string strsfUpdFldSetStr = objvConceptCitationEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(convConceptCitation.ConceptContent, new clsStrCompareIgnoreCase())  ==  true)
{
objvConceptCitationEN.ConceptContent = objvConceptCitationEN.ConceptContent == "[null]" ? null :  objvConceptCitationEN.ConceptContent; //概念内容
}
if (arrFldSet.Contains(convConceptCitation.ConceptId, new clsStrCompareIgnoreCase())  ==  true)
{
objvConceptCitationEN.ConceptId = objvConceptCitationEN.ConceptId == "[null]" ? null :  objvConceptCitationEN.ConceptId; //概念Id
}
if (arrFldSet.Contains(convConceptCitation.ConceptName, new clsStrCompareIgnoreCase())  ==  true)
{
objvConceptCitationEN.ConceptName = objvConceptCitationEN.ConceptName == "[null]" ? null :  objvConceptCitationEN.ConceptName; //概念名称
}
if (arrFldSet.Contains(convConceptCitation.UpdDate, new clsStrCompareIgnoreCase())  ==  true)
{
objvConceptCitationEN.UpdDate = objvConceptCitationEN.UpdDate == "[null]" ? null :  objvConceptCitationEN.UpdDate; //修改日期
}
if (arrFldSet.Contains(convConceptCitation.mId, new clsStrCompareIgnoreCase())  ==  true)
{
objvConceptCitationEN.mId = objvConceptCitationEN.mId; //mId
}
if (arrFldSet.Contains(convConceptCitation.PaperId, new clsStrCompareIgnoreCase())  ==  true)
{
objvConceptCitationEN.PaperId = objvConceptCitationEN.PaperId == "[null]" ? null :  objvConceptCitationEN.PaperId; //论文Id
}
if (arrFldSet.Contains(convConceptCitation.PaperTitle, new clsStrCompareIgnoreCase())  ==  true)
{
objvConceptCitationEN.PaperTitle = objvConceptCitationEN.PaperTitle == "[null]" ? null :  objvConceptCitationEN.PaperTitle; //论文标题
}
if (arrFldSet.Contains(convConceptCitation.PaperContent, new clsStrCompareIgnoreCase())  ==  true)
{
objvConceptCitationEN.PaperContent = objvConceptCitationEN.PaperContent == "[null]" ? null :  objvConceptCitationEN.PaperContent; //主题内容
}
if (arrFldSet.Contains(convConceptCitation.UserName, new clsStrCompareIgnoreCase())  ==  true)
{
objvConceptCitationEN.UserName = objvConceptCitationEN.UserName == "[null]" ? null :  objvConceptCitationEN.UserName; //用户名
}
if (arrFldSet.Contains(convConceptCitation.UpdUserId, new clsStrCompareIgnoreCase())  ==  true)
{
objvConceptCitationEN.UpdUserId = objvConceptCitationEN.UpdUserId == "[null]" ? null :  objvConceptCitationEN.UpdUserId; //修改用户Id
}
if (arrFldSet.Contains(convConceptCitation.TopicId, new clsStrCompareIgnoreCase())  ==  true)
{
objvConceptCitationEN.TopicId = objvConceptCitationEN.TopicId == "[null]" ? null :  objvConceptCitationEN.TopicId; //主题Id
}
if (arrFldSet.Contains(convConceptCitation.TopicName, new clsStrCompareIgnoreCase())  ==  true)
{
objvConceptCitationEN.TopicName = objvConceptCitationEN.TopicName == "[null]" ? null :  objvConceptCitationEN.TopicName; //栏目主题
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
 /// <param name = "objvConceptCitationEN">源简化对象</param>
 public static void AccessFldValueNull(clsvConceptCitationEN objvConceptCitationEN)
{
try
{
if (objvConceptCitationEN.ConceptContent == "[null]") objvConceptCitationEN.ConceptContent = null; //概念内容
if (objvConceptCitationEN.ConceptId == "[null]") objvConceptCitationEN.ConceptId = null; //概念Id
if (objvConceptCitationEN.ConceptName == "[null]") objvConceptCitationEN.ConceptName = null; //概念名称
if (objvConceptCitationEN.UpdDate == "[null]") objvConceptCitationEN.UpdDate = null; //修改日期
if (objvConceptCitationEN.PaperId == "[null]") objvConceptCitationEN.PaperId = null; //论文Id
if (objvConceptCitationEN.PaperTitle == "[null]") objvConceptCitationEN.PaperTitle = null; //论文标题
if (objvConceptCitationEN.PaperContent == "[null]") objvConceptCitationEN.PaperContent = null; //主题内容
if (objvConceptCitationEN.UserName == "[null]") objvConceptCitationEN.UserName = null; //用户名
if (objvConceptCitationEN.UpdUserId == "[null]") objvConceptCitationEN.UpdUserId = null; //修改用户Id
if (objvConceptCitationEN.TopicId == "[null]") objvConceptCitationEN.TopicId = null; //主题Id
if (objvConceptCitationEN.TopicName == "[null]") objvConceptCitationEN.TopicName = null; //栏目主题
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
public static void CheckProperty4Condition(clsvConceptCitationEN objvConceptCitationEN)
{
 vConceptCitationDA.CheckProperty4Condition(objvConceptCitationEN);
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
if (clsPaperBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsPaperBL没有刷新缓存机制(clsPaperBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsConceptCitationBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsConceptCitationBL没有刷新缓存机制(clsConceptCitationBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsResearchTopicBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsResearchTopicBL没有刷新缓存机制(clsResearchTopicBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsRTConceptRelaBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsRTConceptRelaBL没有刷新缓存机制(clsRTConceptRelaBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsConceptBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsConceptBL没有刷新缓存机制(clsConceptBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by mId");
//if (arrvConceptCitationObjLstCache == null)
//{
//arrvConceptCitationObjLstCache = vConceptCitationDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "lngmId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvConceptCitationEN GetObjBymIdCache(long lngmId)
{
//获取缓存中的对象列表
string strKey = string.Format("{0}", clsvConceptCitationEN._CurrTabName);
List<clsvConceptCitationEN> arrvConceptCitationObjLstCache = GetObjLstCache();
IEnumerable <clsvConceptCitationEN> arrvConceptCitationObjLst_Sel =
arrvConceptCitationObjLstCache
.Where(x=> x.mId == lngmId 
);
if (arrvConceptCitationObjLst_Sel.Count() == 0)
{
   clsvConceptCitationEN obj = clsvConceptCitationBL.GetObjBymId(lngmId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
 }
return null;
}
return arrvConceptCitationObjLst_Sel.First();
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvConceptCitationEN> GetAllvConceptCitationObjLstCache()
{
//获取缓存中的对象列表
List<clsvConceptCitationEN> arrvConceptCitationObjLstCache = GetObjLstCache(); 
return arrvConceptCitationObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvConceptCitationEN> GetObjLstCache()
{
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}", clsvConceptCitationEN._CurrTabName);
List<clsvConceptCitationEN> arrvConceptCitationObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrvConceptCitationObjLstCache;
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
string strKey = string.Format("{0}", clsvConceptCitationEN._CurrTabName);
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
 /// 获取检查唯一性条件串(Uniqueness)--vConceptCitation(vConceptCitation)
 /// 唯一性条件:mId_ConceptId_PaperId
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetUniquenessConditionString)
 /// </summary>
 /// <param name = "objvConceptCitationEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(clsvConceptCitationEN objvConceptCitationEN)
{
//检测记录是否存在
string strResult = vConceptCitationDA.GetUniCondStr(objvConceptCitationEN);
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
public static string Func(string strInFldName, string strOutFldName, long lngmId)
{
if (strInFldName != convConceptCitation.mId)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (convConceptCitation.AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", convConceptCitation.AttributeName));
throw new Exception(strMsg);
}
var objvConceptCitation = clsvConceptCitationBL.GetObjBymIdCache(lngmId);
if (objvConceptCitation == null) return "";
return objvConceptCitation[strOutFldName].ToString();
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
int intRecCount = clsvConceptCitationDA.GetRecCount(strTabName);
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
int intRecCount = clsvConceptCitationDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsvConceptCitationDA.GetRecCount();
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
int intRecCount = clsvConceptCitationDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objvConceptCitationCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsvConceptCitationEN objvConceptCitationCond)
{
List<clsvConceptCitationEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsvConceptCitationEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convConceptCitation.AttributeName)
{
if (objvConceptCitationCond.IsUpdated(strFldName) == false) continue;
if (objvConceptCitationCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvConceptCitationCond[strFldName].ToString());
}
else
{
if (objvConceptCitationCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvConceptCitationCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvConceptCitationCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvConceptCitationCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvConceptCitationCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvConceptCitationCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvConceptCitationCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvConceptCitationCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvConceptCitationCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvConceptCitationCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvConceptCitationCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvConceptCitationCond[strFldName]));
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
 List<string> arrList = clsvConceptCitationDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = vConceptCitationDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = vConceptCitationDA.GetFldValueNoDistinct(strFldName, strWhereCond);
return arrList;
}



 #endregion 表操作常用函数
}
}