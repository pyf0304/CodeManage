
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvcc_PapersBigTopicDefaultBL
 表名:vcc_PapersBigTopicDefault(01120161)
 * 版本:2023.08.23.1(服务器:WIN-SRV103-116)
 日期:2023/08/24 14:45:10
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:公共后台所有表(变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:知识点相关(Knowledges)
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
public static class  clsvcc_PapersBigTopicDefaultBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "strPapersBigTopicDefaultId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvcc_PapersBigTopicDefaultEN GetObj(this K_PapersBigTopicDefaultId_vcc_PapersBigTopicDefault myKey)
{
clsvcc_PapersBigTopicDefaultEN objvcc_PapersBigTopicDefaultEN = clsvcc_PapersBigTopicDefaultBL.vcc_PapersBigTopicDefaultDA.GetObjByPapersBigTopicDefaultId(myKey.Value);
return objvcc_PapersBigTopicDefaultEN;
}

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_PapersBigTopicDefaultEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_PapersBigTopicDefaultEN SetPapersBigTopicDefaultId(this clsvcc_PapersBigTopicDefaultEN objvcc_PapersBigTopicDefaultEN, string strPapersBigTopicDefaultId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPapersBigTopicDefaultId, 8, convcc_PapersBigTopicDefault.PapersBigTopicDefaultId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strPapersBigTopicDefaultId, 8, convcc_PapersBigTopicDefault.PapersBigTopicDefaultId);
}
objvcc_PapersBigTopicDefaultEN.PapersBigTopicDefaultId = strPapersBigTopicDefaultId; //PapersBigTopicDefaultId
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_PapersBigTopicDefaultEN.dicFldComparisonOp.ContainsKey(convcc_PapersBigTopicDefault.PapersBigTopicDefaultId) == false)
{
objvcc_PapersBigTopicDefaultEN.dicFldComparisonOp.Add(convcc_PapersBigTopicDefault.PapersBigTopicDefaultId, strComparisonOp);
}
else
{
objvcc_PapersBigTopicDefaultEN.dicFldComparisonOp[convcc_PapersBigTopicDefault.PapersBigTopicDefaultId] = strComparisonOp;
}
}
return objvcc_PapersBigTopicDefaultEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_PapersBigTopicDefaultEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_PapersBigTopicDefaultEN SetQuestionTypeId(this clsvcc_PapersBigTopicDefaultEN objvcc_PapersBigTopicDefaultEN, string strQuestionTypeId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strQuestionTypeId, 2, convcc_PapersBigTopicDefault.QuestionTypeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strQuestionTypeId, 2, convcc_PapersBigTopicDefault.QuestionTypeId);
}
objvcc_PapersBigTopicDefaultEN.QuestionTypeId = strQuestionTypeId; //题目类型Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_PapersBigTopicDefaultEN.dicFldComparisonOp.ContainsKey(convcc_PapersBigTopicDefault.QuestionTypeId) == false)
{
objvcc_PapersBigTopicDefaultEN.dicFldComparisonOp.Add(convcc_PapersBigTopicDefault.QuestionTypeId, strComparisonOp);
}
else
{
objvcc_PapersBigTopicDefaultEN.dicFldComparisonOp[convcc_PapersBigTopicDefault.QuestionTypeId] = strComparisonOp;
}
}
return objvcc_PapersBigTopicDefaultEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_PapersBigTopicDefaultEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_PapersBigTopicDefaultEN SetQuestionTypeName(this clsvcc_PapersBigTopicDefaultEN objvcc_PapersBigTopicDefaultEN, string strQuestionTypeName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strQuestionTypeName, 20, convcc_PapersBigTopicDefault.QuestionTypeName);
}
objvcc_PapersBigTopicDefaultEN.QuestionTypeName = strQuestionTypeName; //题目类型名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_PapersBigTopicDefaultEN.dicFldComparisonOp.ContainsKey(convcc_PapersBigTopicDefault.QuestionTypeName) == false)
{
objvcc_PapersBigTopicDefaultEN.dicFldComparisonOp.Add(convcc_PapersBigTopicDefault.QuestionTypeName, strComparisonOp);
}
else
{
objvcc_PapersBigTopicDefaultEN.dicFldComparisonOp[convcc_PapersBigTopicDefault.QuestionTypeName] = strComparisonOp;
}
}
return objvcc_PapersBigTopicDefaultEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_PapersBigTopicDefaultEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_PapersBigTopicDefaultEN SetPapersBigTopicName(this clsvcc_PapersBigTopicDefaultEN objvcc_PapersBigTopicDefaultEN, string strPapersBigTopicName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPapersBigTopicName, 50, convcc_PapersBigTopicDefault.PapersBigTopicName);
}
objvcc_PapersBigTopicDefaultEN.PapersBigTopicName = strPapersBigTopicName; //试卷大题目名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_PapersBigTopicDefaultEN.dicFldComparisonOp.ContainsKey(convcc_PapersBigTopicDefault.PapersBigTopicName) == false)
{
objvcc_PapersBigTopicDefaultEN.dicFldComparisonOp.Add(convcc_PapersBigTopicDefault.PapersBigTopicName, strComparisonOp);
}
else
{
objvcc_PapersBigTopicDefaultEN.dicFldComparisonOp[convcc_PapersBigTopicDefault.PapersBigTopicName] = strComparisonOp;
}
}
return objvcc_PapersBigTopicDefaultEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_PapersBigTopicDefaultEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_PapersBigTopicDefaultEN SetTopicDescription(this clsvcc_PapersBigTopicDefaultEN objvcc_PapersBigTopicDefaultEN, string strTopicDescription, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTopicDescription, 100, convcc_PapersBigTopicDefault.TopicDescription);
}
objvcc_PapersBigTopicDefaultEN.TopicDescription = strTopicDescription; //标题描述
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_PapersBigTopicDefaultEN.dicFldComparisonOp.ContainsKey(convcc_PapersBigTopicDefault.TopicDescription) == false)
{
objvcc_PapersBigTopicDefaultEN.dicFldComparisonOp.Add(convcc_PapersBigTopicDefault.TopicDescription, strComparisonOp);
}
else
{
objvcc_PapersBigTopicDefaultEN.dicFldComparisonOp[convcc_PapersBigTopicDefault.TopicDescription] = strComparisonOp;
}
}
return objvcc_PapersBigTopicDefaultEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_PapersBigTopicDefaultEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_PapersBigTopicDefaultEN SetTopicScores(this clsvcc_PapersBigTopicDefaultEN objvcc_PapersBigTopicDefaultEN, int? intTopicScores, string strComparisonOp="")
	{
objvcc_PapersBigTopicDefaultEN.TopicScores = intTopicScores; //大题得分
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_PapersBigTopicDefaultEN.dicFldComparisonOp.ContainsKey(convcc_PapersBigTopicDefault.TopicScores) == false)
{
objvcc_PapersBigTopicDefaultEN.dicFldComparisonOp.Add(convcc_PapersBigTopicDefault.TopicScores, strComparisonOp);
}
else
{
objvcc_PapersBigTopicDefaultEN.dicFldComparisonOp[convcc_PapersBigTopicDefault.TopicScores] = strComparisonOp;
}
}
return objvcc_PapersBigTopicDefaultEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_PapersBigTopicDefaultEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_PapersBigTopicDefaultEN SetUpdDate(this clsvcc_PapersBigTopicDefaultEN objvcc_PapersBigTopicDefaultEN, string strUpdDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strUpdDate, convcc_PapersBigTopicDefault.UpdDate);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdDate, 20, convcc_PapersBigTopicDefault.UpdDate);
}
objvcc_PapersBigTopicDefaultEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_PapersBigTopicDefaultEN.dicFldComparisonOp.ContainsKey(convcc_PapersBigTopicDefault.UpdDate) == false)
{
objvcc_PapersBigTopicDefaultEN.dicFldComparisonOp.Add(convcc_PapersBigTopicDefault.UpdDate, strComparisonOp);
}
else
{
objvcc_PapersBigTopicDefaultEN.dicFldComparisonOp[convcc_PapersBigTopicDefault.UpdDate] = strComparisonOp;
}
}
return objvcc_PapersBigTopicDefaultEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_PapersBigTopicDefaultEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_PapersBigTopicDefaultEN SetUpdUser(this clsvcc_PapersBigTopicDefaultEN objvcc_PapersBigTopicDefaultEN, string strUpdUser, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strUpdUser, convcc_PapersBigTopicDefault.UpdUser);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdUser, 20, convcc_PapersBigTopicDefault.UpdUser);
}
objvcc_PapersBigTopicDefaultEN.UpdUser = strUpdUser; //修改人
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_PapersBigTopicDefaultEN.dicFldComparisonOp.ContainsKey(convcc_PapersBigTopicDefault.UpdUser) == false)
{
objvcc_PapersBigTopicDefaultEN.dicFldComparisonOp.Add(convcc_PapersBigTopicDefault.UpdUser, strComparisonOp);
}
else
{
objvcc_PapersBigTopicDefaultEN.dicFldComparisonOp[convcc_PapersBigTopicDefault.UpdUser] = strComparisonOp;
}
}
return objvcc_PapersBigTopicDefaultEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_PapersBigTopicDefaultEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvcc_PapersBigTopicDefaultEN SetMemo(this clsvcc_PapersBigTopicDefaultEN objvcc_PapersBigTopicDefaultEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, convcc_PapersBigTopicDefault.Memo);
}
objvcc_PapersBigTopicDefaultEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvcc_PapersBigTopicDefaultEN.dicFldComparisonOp.ContainsKey(convcc_PapersBigTopicDefault.Memo) == false)
{
objvcc_PapersBigTopicDefaultEN.dicFldComparisonOp.Add(convcc_PapersBigTopicDefault.Memo, strComparisonOp);
}
else
{
objvcc_PapersBigTopicDefaultEN.dicFldComparisonOp[convcc_PapersBigTopicDefault.Memo] = strComparisonOp;
}
}
return objvcc_PapersBigTopicDefaultEN;
	}

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CopyObj)
 /// </summary>
 /// <param name = "objvcc_PapersBigTopicDefaultENS">源对象</param>
 /// <param name = "objvcc_PapersBigTopicDefaultENT">目标对象</param>
 public static void CopyTo(this clsvcc_PapersBigTopicDefaultEN objvcc_PapersBigTopicDefaultENS, clsvcc_PapersBigTopicDefaultEN objvcc_PapersBigTopicDefaultENT)
{
try
{
objvcc_PapersBigTopicDefaultENT.PapersBigTopicDefaultId = objvcc_PapersBigTopicDefaultENS.PapersBigTopicDefaultId; //PapersBigTopicDefaultId
objvcc_PapersBigTopicDefaultENT.QuestionTypeId = objvcc_PapersBigTopicDefaultENS.QuestionTypeId; //题目类型Id
objvcc_PapersBigTopicDefaultENT.QuestionTypeName = objvcc_PapersBigTopicDefaultENS.QuestionTypeName; //题目类型名
objvcc_PapersBigTopicDefaultENT.PapersBigTopicName = objvcc_PapersBigTopicDefaultENS.PapersBigTopicName; //试卷大题目名称
objvcc_PapersBigTopicDefaultENT.TopicDescription = objvcc_PapersBigTopicDefaultENS.TopicDescription; //标题描述
objvcc_PapersBigTopicDefaultENT.TopicScores = objvcc_PapersBigTopicDefaultENS.TopicScores; //大题得分
objvcc_PapersBigTopicDefaultENT.UpdDate = objvcc_PapersBigTopicDefaultENS.UpdDate; //修改日期
objvcc_PapersBigTopicDefaultENT.UpdUser = objvcc_PapersBigTopicDefaultENS.UpdUser; //修改人
objvcc_PapersBigTopicDefaultENT.Memo = objvcc_PapersBigTopicDefaultENS.Memo; //备注
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
 /// <param name = "objvcc_PapersBigTopicDefaultENS">源对象</param>
 /// <returns>目标对象=>clsvcc_PapersBigTopicDefaultEN:objvcc_PapersBigTopicDefaultENT</returns>
 public static clsvcc_PapersBigTopicDefaultEN CopyTo(this clsvcc_PapersBigTopicDefaultEN objvcc_PapersBigTopicDefaultENS)
{
try
{
 clsvcc_PapersBigTopicDefaultEN objvcc_PapersBigTopicDefaultENT = new clsvcc_PapersBigTopicDefaultEN()
{
PapersBigTopicDefaultId = objvcc_PapersBigTopicDefaultENS.PapersBigTopicDefaultId, //PapersBigTopicDefaultId
QuestionTypeId = objvcc_PapersBigTopicDefaultENS.QuestionTypeId, //题目类型Id
QuestionTypeName = objvcc_PapersBigTopicDefaultENS.QuestionTypeName, //题目类型名
PapersBigTopicName = objvcc_PapersBigTopicDefaultENS.PapersBigTopicName, //试卷大题目名称
TopicDescription = objvcc_PapersBigTopicDefaultENS.TopicDescription, //标题描述
TopicScores = objvcc_PapersBigTopicDefaultENS.TopicScores, //大题得分
UpdDate = objvcc_PapersBigTopicDefaultENS.UpdDate, //修改日期
UpdUser = objvcc_PapersBigTopicDefaultENS.UpdUser, //修改人
Memo = objvcc_PapersBigTopicDefaultENS.Memo, //备注
};
 return objvcc_PapersBigTopicDefaultENT;
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
public static void CheckProperty4Condition(this clsvcc_PapersBigTopicDefaultEN objvcc_PapersBigTopicDefaultEN)
{
 clsvcc_PapersBigTopicDefaultBL.vcc_PapersBigTopicDefaultDA.CheckProperty4Condition(objvcc_PapersBigTopicDefaultEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvcc_PapersBigTopicDefaultEN objvcc_PapersBigTopicDefaultCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvcc_PapersBigTopicDefaultCond.IsUpdated(convcc_PapersBigTopicDefault.PapersBigTopicDefaultId) == true)
{
string strComparisonOpPapersBigTopicDefaultId = objvcc_PapersBigTopicDefaultCond.dicFldComparisonOp[convcc_PapersBigTopicDefault.PapersBigTopicDefaultId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_PapersBigTopicDefault.PapersBigTopicDefaultId, objvcc_PapersBigTopicDefaultCond.PapersBigTopicDefaultId, strComparisonOpPapersBigTopicDefaultId);
}
if (objvcc_PapersBigTopicDefaultCond.IsUpdated(convcc_PapersBigTopicDefault.QuestionTypeId) == true)
{
string strComparisonOpQuestionTypeId = objvcc_PapersBigTopicDefaultCond.dicFldComparisonOp[convcc_PapersBigTopicDefault.QuestionTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_PapersBigTopicDefault.QuestionTypeId, objvcc_PapersBigTopicDefaultCond.QuestionTypeId, strComparisonOpQuestionTypeId);
}
if (objvcc_PapersBigTopicDefaultCond.IsUpdated(convcc_PapersBigTopicDefault.QuestionTypeName) == true)
{
string strComparisonOpQuestionTypeName = objvcc_PapersBigTopicDefaultCond.dicFldComparisonOp[convcc_PapersBigTopicDefault.QuestionTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_PapersBigTopicDefault.QuestionTypeName, objvcc_PapersBigTopicDefaultCond.QuestionTypeName, strComparisonOpQuestionTypeName);
}
if (objvcc_PapersBigTopicDefaultCond.IsUpdated(convcc_PapersBigTopicDefault.PapersBigTopicName) == true)
{
string strComparisonOpPapersBigTopicName = objvcc_PapersBigTopicDefaultCond.dicFldComparisonOp[convcc_PapersBigTopicDefault.PapersBigTopicName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_PapersBigTopicDefault.PapersBigTopicName, objvcc_PapersBigTopicDefaultCond.PapersBigTopicName, strComparisonOpPapersBigTopicName);
}
if (objvcc_PapersBigTopicDefaultCond.IsUpdated(convcc_PapersBigTopicDefault.TopicDescription) == true)
{
string strComparisonOpTopicDescription = objvcc_PapersBigTopicDefaultCond.dicFldComparisonOp[convcc_PapersBigTopicDefault.TopicDescription];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_PapersBigTopicDefault.TopicDescription, objvcc_PapersBigTopicDefaultCond.TopicDescription, strComparisonOpTopicDescription);
}
if (objvcc_PapersBigTopicDefaultCond.IsUpdated(convcc_PapersBigTopicDefault.TopicScores) == true)
{
string strComparisonOpTopicScores = objvcc_PapersBigTopicDefaultCond.dicFldComparisonOp[convcc_PapersBigTopicDefault.TopicScores];
strWhereCond += string.Format(" And {0} {2} {1}", convcc_PapersBigTopicDefault.TopicScores, objvcc_PapersBigTopicDefaultCond.TopicScores, strComparisonOpTopicScores);
}
if (objvcc_PapersBigTopicDefaultCond.IsUpdated(convcc_PapersBigTopicDefault.UpdDate) == true)
{
string strComparisonOpUpdDate = objvcc_PapersBigTopicDefaultCond.dicFldComparisonOp[convcc_PapersBigTopicDefault.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_PapersBigTopicDefault.UpdDate, objvcc_PapersBigTopicDefaultCond.UpdDate, strComparisonOpUpdDate);
}
if (objvcc_PapersBigTopicDefaultCond.IsUpdated(convcc_PapersBigTopicDefault.UpdUser) == true)
{
string strComparisonOpUpdUser = objvcc_PapersBigTopicDefaultCond.dicFldComparisonOp[convcc_PapersBigTopicDefault.UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_PapersBigTopicDefault.UpdUser, objvcc_PapersBigTopicDefaultCond.UpdUser, strComparisonOpUpdUser);
}
if (objvcc_PapersBigTopicDefaultCond.IsUpdated(convcc_PapersBigTopicDefault.Memo) == true)
{
string strComparisonOpMemo = objvcc_PapersBigTopicDefaultCond.dicFldComparisonOp[convcc_PapersBigTopicDefault.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_PapersBigTopicDefault.Memo, objvcc_PapersBigTopicDefaultCond.Memo, strComparisonOpMemo);
}
 return strWhereCond;
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_vcc_PapersBigTopicDefault
{
public virtual bool UpdRelaTabDate(string strPapersBigTopicDefaultId, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// v试卷大题目默认(vcc_PapersBigTopicDefault)
 /// 数据源类型:视图
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsvcc_PapersBigTopicDefaultBL
{
public static RelatedActions_vcc_PapersBigTopicDefault relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsvcc_PapersBigTopicDefaultDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsvcc_PapersBigTopicDefaultDA vcc_PapersBigTopicDefaultDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsvcc_PapersBigTopicDefaultDA();
}
return uniqueInstance;
}
}

 /// <summary>
 /// 类的构造函数
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ClassConstructor1)
 /// </summary>
 public clsvcc_PapersBigTopicDefaultBL()
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
if (string.IsNullOrEmpty(clsvcc_PapersBigTopicDefaultEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvcc_PapersBigTopicDefaultEN._ConnectString);
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
public static DataTable GetDataTable_vcc_PapersBigTopicDefault(string strWhereCond)
{
DataTable objDT;
try
{
objDT = vcc_PapersBigTopicDefaultDA.GetDataTable_vcc_PapersBigTopicDefault(strWhereCond);
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
objDT = vcc_PapersBigTopicDefaultDA.GetDataTable(strWhereCond);
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
objDT = vcc_PapersBigTopicDefaultDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = vcc_PapersBigTopicDefaultDA.GetDataTable(strWhereCond, strTabName);
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
objDT = vcc_PapersBigTopicDefaultDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = vcc_PapersBigTopicDefaultDA.GetDataTable_Top(objTopPara);
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
objDT = vcc_PapersBigTopicDefaultDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = vcc_PapersBigTopicDefaultDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = vcc_PapersBigTopicDefaultDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
 /// <param name = "arrPapersBigTopicDefaultIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static List<clsvcc_PapersBigTopicDefaultEN> GetObjLstByPapersBigTopicDefaultIdLst(List<string> arrPapersBigTopicDefaultIdLst)
{
List<clsvcc_PapersBigTopicDefaultEN> arrObjLst = new List<clsvcc_PapersBigTopicDefaultEN>(); 
System.Data.DataTable objDT; 
 string strSqlConditionStr = clsArray.GetSqlInStrByArray(arrPapersBigTopicDefaultIdLst, true);
 string strWhereCond = string.Format("PapersBigTopicDefaultId in ({0})", strSqlConditionStr);
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvcc_PapersBigTopicDefaultEN objvcc_PapersBigTopicDefaultEN = new clsvcc_PapersBigTopicDefaultEN();
try
{
objvcc_PapersBigTopicDefaultEN.PapersBigTopicDefaultId = objRow[convcc_PapersBigTopicDefault.PapersBigTopicDefaultId].ToString().Trim(); //PapersBigTopicDefaultId
objvcc_PapersBigTopicDefaultEN.QuestionTypeId = objRow[convcc_PapersBigTopicDefault.QuestionTypeId] == DBNull.Value ? null : objRow[convcc_PapersBigTopicDefault.QuestionTypeId].ToString().Trim(); //题目类型Id
objvcc_PapersBigTopicDefaultEN.QuestionTypeName = objRow[convcc_PapersBigTopicDefault.QuestionTypeName] == DBNull.Value ? null : objRow[convcc_PapersBigTopicDefault.QuestionTypeName].ToString().Trim(); //题目类型名
objvcc_PapersBigTopicDefaultEN.PapersBigTopicName = objRow[convcc_PapersBigTopicDefault.PapersBigTopicName] == DBNull.Value ? null : objRow[convcc_PapersBigTopicDefault.PapersBigTopicName].ToString().Trim(); //试卷大题目名称
objvcc_PapersBigTopicDefaultEN.TopicDescription = objRow[convcc_PapersBigTopicDefault.TopicDescription] == DBNull.Value ? null : objRow[convcc_PapersBigTopicDefault.TopicDescription].ToString().Trim(); //标题描述
objvcc_PapersBigTopicDefaultEN.TopicScores = objRow[convcc_PapersBigTopicDefault.TopicScores] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_PapersBigTopicDefault.TopicScores].ToString().Trim()); //大题得分
objvcc_PapersBigTopicDefaultEN.UpdDate = objRow[convcc_PapersBigTopicDefault.UpdDate].ToString().Trim(); //修改日期
objvcc_PapersBigTopicDefaultEN.UpdUser = objRow[convcc_PapersBigTopicDefault.UpdUser].ToString().Trim(); //修改人
objvcc_PapersBigTopicDefaultEN.Memo = objRow[convcc_PapersBigTopicDefault.Memo] == DBNull.Value ? null : objRow[convcc_PapersBigTopicDefault.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvcc_PapersBigTopicDefaultEN.PapersBigTopicDefaultId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvcc_PapersBigTopicDefaultEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrPapersBigTopicDefaultIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsvcc_PapersBigTopicDefaultEN> GetObjLstByPapersBigTopicDefaultIdLstCache(List<string> arrPapersBigTopicDefaultIdLst)
{
string strKey = string.Format("{0}", clsvcc_PapersBigTopicDefaultEN._CurrTabName);
List<clsvcc_PapersBigTopicDefaultEN> arrvcc_PapersBigTopicDefaultObjLstCache = GetObjLstCache();
IEnumerable <clsvcc_PapersBigTopicDefaultEN> arrvcc_PapersBigTopicDefaultObjLst_Sel =
arrvcc_PapersBigTopicDefaultObjLstCache
.Where(x => arrPapersBigTopicDefaultIdLst.Contains(x.PapersBigTopicDefaultId));
return arrvcc_PapersBigTopicDefaultObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvcc_PapersBigTopicDefaultEN> GetObjLst(string strWhereCond)
{
List<clsvcc_PapersBigTopicDefaultEN> arrObjLst = new List<clsvcc_PapersBigTopicDefaultEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvcc_PapersBigTopicDefaultEN objvcc_PapersBigTopicDefaultEN = new clsvcc_PapersBigTopicDefaultEN();
try
{
objvcc_PapersBigTopicDefaultEN.PapersBigTopicDefaultId = objRow[convcc_PapersBigTopicDefault.PapersBigTopicDefaultId].ToString().Trim(); //PapersBigTopicDefaultId
objvcc_PapersBigTopicDefaultEN.QuestionTypeId = objRow[convcc_PapersBigTopicDefault.QuestionTypeId] == DBNull.Value ? null : objRow[convcc_PapersBigTopicDefault.QuestionTypeId].ToString().Trim(); //题目类型Id
objvcc_PapersBigTopicDefaultEN.QuestionTypeName = objRow[convcc_PapersBigTopicDefault.QuestionTypeName] == DBNull.Value ? null : objRow[convcc_PapersBigTopicDefault.QuestionTypeName].ToString().Trim(); //题目类型名
objvcc_PapersBigTopicDefaultEN.PapersBigTopicName = objRow[convcc_PapersBigTopicDefault.PapersBigTopicName] == DBNull.Value ? null : objRow[convcc_PapersBigTopicDefault.PapersBigTopicName].ToString().Trim(); //试卷大题目名称
objvcc_PapersBigTopicDefaultEN.TopicDescription = objRow[convcc_PapersBigTopicDefault.TopicDescription] == DBNull.Value ? null : objRow[convcc_PapersBigTopicDefault.TopicDescription].ToString().Trim(); //标题描述
objvcc_PapersBigTopicDefaultEN.TopicScores = objRow[convcc_PapersBigTopicDefault.TopicScores] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_PapersBigTopicDefault.TopicScores].ToString().Trim()); //大题得分
objvcc_PapersBigTopicDefaultEN.UpdDate = objRow[convcc_PapersBigTopicDefault.UpdDate].ToString().Trim(); //修改日期
objvcc_PapersBigTopicDefaultEN.UpdUser = objRow[convcc_PapersBigTopicDefault.UpdUser].ToString().Trim(); //修改人
objvcc_PapersBigTopicDefaultEN.Memo = objRow[convcc_PapersBigTopicDefault.Memo] == DBNull.Value ? null : objRow[convcc_PapersBigTopicDefault.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvcc_PapersBigTopicDefaultEN.PapersBigTopicDefaultId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvcc_PapersBigTopicDefaultEN);
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
public static List<clsvcc_PapersBigTopicDefaultEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsvcc_PapersBigTopicDefaultEN> arrObjLst = new List<clsvcc_PapersBigTopicDefaultEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvcc_PapersBigTopicDefaultEN objvcc_PapersBigTopicDefaultEN = new clsvcc_PapersBigTopicDefaultEN();
try
{
objvcc_PapersBigTopicDefaultEN.PapersBigTopicDefaultId = objRow[convcc_PapersBigTopicDefault.PapersBigTopicDefaultId].ToString().Trim(); //PapersBigTopicDefaultId
objvcc_PapersBigTopicDefaultEN.QuestionTypeId = objRow[convcc_PapersBigTopicDefault.QuestionTypeId] == DBNull.Value ? null : objRow[convcc_PapersBigTopicDefault.QuestionTypeId].ToString().Trim(); //题目类型Id
objvcc_PapersBigTopicDefaultEN.QuestionTypeName = objRow[convcc_PapersBigTopicDefault.QuestionTypeName] == DBNull.Value ? null : objRow[convcc_PapersBigTopicDefault.QuestionTypeName].ToString().Trim(); //题目类型名
objvcc_PapersBigTopicDefaultEN.PapersBigTopicName = objRow[convcc_PapersBigTopicDefault.PapersBigTopicName] == DBNull.Value ? null : objRow[convcc_PapersBigTopicDefault.PapersBigTopicName].ToString().Trim(); //试卷大题目名称
objvcc_PapersBigTopicDefaultEN.TopicDescription = objRow[convcc_PapersBigTopicDefault.TopicDescription] == DBNull.Value ? null : objRow[convcc_PapersBigTopicDefault.TopicDescription].ToString().Trim(); //标题描述
objvcc_PapersBigTopicDefaultEN.TopicScores = objRow[convcc_PapersBigTopicDefault.TopicScores] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_PapersBigTopicDefault.TopicScores].ToString().Trim()); //大题得分
objvcc_PapersBigTopicDefaultEN.UpdDate = objRow[convcc_PapersBigTopicDefault.UpdDate].ToString().Trim(); //修改日期
objvcc_PapersBigTopicDefaultEN.UpdUser = objRow[convcc_PapersBigTopicDefault.UpdUser].ToString().Trim(); //修改人
objvcc_PapersBigTopicDefaultEN.Memo = objRow[convcc_PapersBigTopicDefault.Memo] == DBNull.Value ? null : objRow[convcc_PapersBigTopicDefault.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvcc_PapersBigTopicDefaultEN.PapersBigTopicDefaultId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvcc_PapersBigTopicDefaultEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objvcc_PapersBigTopicDefaultCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsvcc_PapersBigTopicDefaultEN> GetSubObjLstCache(clsvcc_PapersBigTopicDefaultEN objvcc_PapersBigTopicDefaultCond)
{
List<clsvcc_PapersBigTopicDefaultEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsvcc_PapersBigTopicDefaultEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convcc_PapersBigTopicDefault.AttributeName)
{
if (objvcc_PapersBigTopicDefaultCond.IsUpdated(strFldName) == false) continue;
if (objvcc_PapersBigTopicDefaultCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvcc_PapersBigTopicDefaultCond[strFldName].ToString());
}
else
{
if (objvcc_PapersBigTopicDefaultCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvcc_PapersBigTopicDefaultCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvcc_PapersBigTopicDefaultCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvcc_PapersBigTopicDefaultCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvcc_PapersBigTopicDefaultCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvcc_PapersBigTopicDefaultCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvcc_PapersBigTopicDefaultCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvcc_PapersBigTopicDefaultCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvcc_PapersBigTopicDefaultCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvcc_PapersBigTopicDefaultCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvcc_PapersBigTopicDefaultCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvcc_PapersBigTopicDefaultCond[strFldName]));
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
public static List<clsvcc_PapersBigTopicDefaultEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsvcc_PapersBigTopicDefaultEN> arrObjLst = new List<clsvcc_PapersBigTopicDefaultEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvcc_PapersBigTopicDefaultEN objvcc_PapersBigTopicDefaultEN = new clsvcc_PapersBigTopicDefaultEN();
try
{
objvcc_PapersBigTopicDefaultEN.PapersBigTopicDefaultId = objRow[convcc_PapersBigTopicDefault.PapersBigTopicDefaultId].ToString().Trim(); //PapersBigTopicDefaultId
objvcc_PapersBigTopicDefaultEN.QuestionTypeId = objRow[convcc_PapersBigTopicDefault.QuestionTypeId] == DBNull.Value ? null : objRow[convcc_PapersBigTopicDefault.QuestionTypeId].ToString().Trim(); //题目类型Id
objvcc_PapersBigTopicDefaultEN.QuestionTypeName = objRow[convcc_PapersBigTopicDefault.QuestionTypeName] == DBNull.Value ? null : objRow[convcc_PapersBigTopicDefault.QuestionTypeName].ToString().Trim(); //题目类型名
objvcc_PapersBigTopicDefaultEN.PapersBigTopicName = objRow[convcc_PapersBigTopicDefault.PapersBigTopicName] == DBNull.Value ? null : objRow[convcc_PapersBigTopicDefault.PapersBigTopicName].ToString().Trim(); //试卷大题目名称
objvcc_PapersBigTopicDefaultEN.TopicDescription = objRow[convcc_PapersBigTopicDefault.TopicDescription] == DBNull.Value ? null : objRow[convcc_PapersBigTopicDefault.TopicDescription].ToString().Trim(); //标题描述
objvcc_PapersBigTopicDefaultEN.TopicScores = objRow[convcc_PapersBigTopicDefault.TopicScores] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_PapersBigTopicDefault.TopicScores].ToString().Trim()); //大题得分
objvcc_PapersBigTopicDefaultEN.UpdDate = objRow[convcc_PapersBigTopicDefault.UpdDate].ToString().Trim(); //修改日期
objvcc_PapersBigTopicDefaultEN.UpdUser = objRow[convcc_PapersBigTopicDefault.UpdUser].ToString().Trim(); //修改人
objvcc_PapersBigTopicDefaultEN.Memo = objRow[convcc_PapersBigTopicDefault.Memo] == DBNull.Value ? null : objRow[convcc_PapersBigTopicDefault.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvcc_PapersBigTopicDefaultEN.PapersBigTopicDefaultId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvcc_PapersBigTopicDefaultEN);
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
public static List<clsvcc_PapersBigTopicDefaultEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsvcc_PapersBigTopicDefaultEN> arrObjLst = new List<clsvcc_PapersBigTopicDefaultEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvcc_PapersBigTopicDefaultEN objvcc_PapersBigTopicDefaultEN = new clsvcc_PapersBigTopicDefaultEN();
try
{
objvcc_PapersBigTopicDefaultEN.PapersBigTopicDefaultId = objRow[convcc_PapersBigTopicDefault.PapersBigTopicDefaultId].ToString().Trim(); //PapersBigTopicDefaultId
objvcc_PapersBigTopicDefaultEN.QuestionTypeId = objRow[convcc_PapersBigTopicDefault.QuestionTypeId] == DBNull.Value ? null : objRow[convcc_PapersBigTopicDefault.QuestionTypeId].ToString().Trim(); //题目类型Id
objvcc_PapersBigTopicDefaultEN.QuestionTypeName = objRow[convcc_PapersBigTopicDefault.QuestionTypeName] == DBNull.Value ? null : objRow[convcc_PapersBigTopicDefault.QuestionTypeName].ToString().Trim(); //题目类型名
objvcc_PapersBigTopicDefaultEN.PapersBigTopicName = objRow[convcc_PapersBigTopicDefault.PapersBigTopicName] == DBNull.Value ? null : objRow[convcc_PapersBigTopicDefault.PapersBigTopicName].ToString().Trim(); //试卷大题目名称
objvcc_PapersBigTopicDefaultEN.TopicDescription = objRow[convcc_PapersBigTopicDefault.TopicDescription] == DBNull.Value ? null : objRow[convcc_PapersBigTopicDefault.TopicDescription].ToString().Trim(); //标题描述
objvcc_PapersBigTopicDefaultEN.TopicScores = objRow[convcc_PapersBigTopicDefault.TopicScores] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_PapersBigTopicDefault.TopicScores].ToString().Trim()); //大题得分
objvcc_PapersBigTopicDefaultEN.UpdDate = objRow[convcc_PapersBigTopicDefault.UpdDate].ToString().Trim(); //修改日期
objvcc_PapersBigTopicDefaultEN.UpdUser = objRow[convcc_PapersBigTopicDefault.UpdUser].ToString().Trim(); //修改人
objvcc_PapersBigTopicDefaultEN.Memo = objRow[convcc_PapersBigTopicDefault.Memo] == DBNull.Value ? null : objRow[convcc_PapersBigTopicDefault.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvcc_PapersBigTopicDefaultEN.PapersBigTopicDefaultId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvcc_PapersBigTopicDefaultEN);
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
List<clsvcc_PapersBigTopicDefaultEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsvcc_PapersBigTopicDefaultEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsvcc_PapersBigTopicDefaultEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsvcc_PapersBigTopicDefaultEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsvcc_PapersBigTopicDefaultEN> arrObjLst = new List<clsvcc_PapersBigTopicDefaultEN>(); 
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
	clsvcc_PapersBigTopicDefaultEN objvcc_PapersBigTopicDefaultEN = new clsvcc_PapersBigTopicDefaultEN();
try
{
objvcc_PapersBigTopicDefaultEN.PapersBigTopicDefaultId = objRow[convcc_PapersBigTopicDefault.PapersBigTopicDefaultId].ToString().Trim(); //PapersBigTopicDefaultId
objvcc_PapersBigTopicDefaultEN.QuestionTypeId = objRow[convcc_PapersBigTopicDefault.QuestionTypeId] == DBNull.Value ? null : objRow[convcc_PapersBigTopicDefault.QuestionTypeId].ToString().Trim(); //题目类型Id
objvcc_PapersBigTopicDefaultEN.QuestionTypeName = objRow[convcc_PapersBigTopicDefault.QuestionTypeName] == DBNull.Value ? null : objRow[convcc_PapersBigTopicDefault.QuestionTypeName].ToString().Trim(); //题目类型名
objvcc_PapersBigTopicDefaultEN.PapersBigTopicName = objRow[convcc_PapersBigTopicDefault.PapersBigTopicName] == DBNull.Value ? null : objRow[convcc_PapersBigTopicDefault.PapersBigTopicName].ToString().Trim(); //试卷大题目名称
objvcc_PapersBigTopicDefaultEN.TopicDescription = objRow[convcc_PapersBigTopicDefault.TopicDescription] == DBNull.Value ? null : objRow[convcc_PapersBigTopicDefault.TopicDescription].ToString().Trim(); //标题描述
objvcc_PapersBigTopicDefaultEN.TopicScores = objRow[convcc_PapersBigTopicDefault.TopicScores] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_PapersBigTopicDefault.TopicScores].ToString().Trim()); //大题得分
objvcc_PapersBigTopicDefaultEN.UpdDate = objRow[convcc_PapersBigTopicDefault.UpdDate].ToString().Trim(); //修改日期
objvcc_PapersBigTopicDefaultEN.UpdUser = objRow[convcc_PapersBigTopicDefault.UpdUser].ToString().Trim(); //修改人
objvcc_PapersBigTopicDefaultEN.Memo = objRow[convcc_PapersBigTopicDefault.Memo] == DBNull.Value ? null : objRow[convcc_PapersBigTopicDefault.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvcc_PapersBigTopicDefaultEN.PapersBigTopicDefaultId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvcc_PapersBigTopicDefaultEN);
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
public static List<clsvcc_PapersBigTopicDefaultEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsvcc_PapersBigTopicDefaultEN> arrObjLst = new List<clsvcc_PapersBigTopicDefaultEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvcc_PapersBigTopicDefaultEN objvcc_PapersBigTopicDefaultEN = new clsvcc_PapersBigTopicDefaultEN();
try
{
objvcc_PapersBigTopicDefaultEN.PapersBigTopicDefaultId = objRow[convcc_PapersBigTopicDefault.PapersBigTopicDefaultId].ToString().Trim(); //PapersBigTopicDefaultId
objvcc_PapersBigTopicDefaultEN.QuestionTypeId = objRow[convcc_PapersBigTopicDefault.QuestionTypeId] == DBNull.Value ? null : objRow[convcc_PapersBigTopicDefault.QuestionTypeId].ToString().Trim(); //题目类型Id
objvcc_PapersBigTopicDefaultEN.QuestionTypeName = objRow[convcc_PapersBigTopicDefault.QuestionTypeName] == DBNull.Value ? null : objRow[convcc_PapersBigTopicDefault.QuestionTypeName].ToString().Trim(); //题目类型名
objvcc_PapersBigTopicDefaultEN.PapersBigTopicName = objRow[convcc_PapersBigTopicDefault.PapersBigTopicName] == DBNull.Value ? null : objRow[convcc_PapersBigTopicDefault.PapersBigTopicName].ToString().Trim(); //试卷大题目名称
objvcc_PapersBigTopicDefaultEN.TopicDescription = objRow[convcc_PapersBigTopicDefault.TopicDescription] == DBNull.Value ? null : objRow[convcc_PapersBigTopicDefault.TopicDescription].ToString().Trim(); //标题描述
objvcc_PapersBigTopicDefaultEN.TopicScores = objRow[convcc_PapersBigTopicDefault.TopicScores] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_PapersBigTopicDefault.TopicScores].ToString().Trim()); //大题得分
objvcc_PapersBigTopicDefaultEN.UpdDate = objRow[convcc_PapersBigTopicDefault.UpdDate].ToString().Trim(); //修改日期
objvcc_PapersBigTopicDefaultEN.UpdUser = objRow[convcc_PapersBigTopicDefault.UpdUser].ToString().Trim(); //修改人
objvcc_PapersBigTopicDefaultEN.Memo = objRow[convcc_PapersBigTopicDefault.Memo] == DBNull.Value ? null : objRow[convcc_PapersBigTopicDefault.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvcc_PapersBigTopicDefaultEN.PapersBigTopicDefaultId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvcc_PapersBigTopicDefaultEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsvcc_PapersBigTopicDefaultEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsvcc_PapersBigTopicDefaultEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsvcc_PapersBigTopicDefaultEN> arrObjLst = new List<clsvcc_PapersBigTopicDefaultEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvcc_PapersBigTopicDefaultEN objvcc_PapersBigTopicDefaultEN = new clsvcc_PapersBigTopicDefaultEN();
try
{
objvcc_PapersBigTopicDefaultEN.PapersBigTopicDefaultId = objRow[convcc_PapersBigTopicDefault.PapersBigTopicDefaultId].ToString().Trim(); //PapersBigTopicDefaultId
objvcc_PapersBigTopicDefaultEN.QuestionTypeId = objRow[convcc_PapersBigTopicDefault.QuestionTypeId] == DBNull.Value ? null : objRow[convcc_PapersBigTopicDefault.QuestionTypeId].ToString().Trim(); //题目类型Id
objvcc_PapersBigTopicDefaultEN.QuestionTypeName = objRow[convcc_PapersBigTopicDefault.QuestionTypeName] == DBNull.Value ? null : objRow[convcc_PapersBigTopicDefault.QuestionTypeName].ToString().Trim(); //题目类型名
objvcc_PapersBigTopicDefaultEN.PapersBigTopicName = objRow[convcc_PapersBigTopicDefault.PapersBigTopicName] == DBNull.Value ? null : objRow[convcc_PapersBigTopicDefault.PapersBigTopicName].ToString().Trim(); //试卷大题目名称
objvcc_PapersBigTopicDefaultEN.TopicDescription = objRow[convcc_PapersBigTopicDefault.TopicDescription] == DBNull.Value ? null : objRow[convcc_PapersBigTopicDefault.TopicDescription].ToString().Trim(); //标题描述
objvcc_PapersBigTopicDefaultEN.TopicScores = objRow[convcc_PapersBigTopicDefault.TopicScores] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_PapersBigTopicDefault.TopicScores].ToString().Trim()); //大题得分
objvcc_PapersBigTopicDefaultEN.UpdDate = objRow[convcc_PapersBigTopicDefault.UpdDate].ToString().Trim(); //修改日期
objvcc_PapersBigTopicDefaultEN.UpdUser = objRow[convcc_PapersBigTopicDefault.UpdUser].ToString().Trim(); //修改人
objvcc_PapersBigTopicDefaultEN.Memo = objRow[convcc_PapersBigTopicDefault.Memo] == DBNull.Value ? null : objRow[convcc_PapersBigTopicDefault.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvcc_PapersBigTopicDefaultEN.PapersBigTopicDefaultId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvcc_PapersBigTopicDefaultEN);
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
public static List<clsvcc_PapersBigTopicDefaultEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsvcc_PapersBigTopicDefaultEN> arrObjLst = new List<clsvcc_PapersBigTopicDefaultEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvcc_PapersBigTopicDefaultEN objvcc_PapersBigTopicDefaultEN = new clsvcc_PapersBigTopicDefaultEN();
try
{
objvcc_PapersBigTopicDefaultEN.PapersBigTopicDefaultId = objRow[convcc_PapersBigTopicDefault.PapersBigTopicDefaultId].ToString().Trim(); //PapersBigTopicDefaultId
objvcc_PapersBigTopicDefaultEN.QuestionTypeId = objRow[convcc_PapersBigTopicDefault.QuestionTypeId] == DBNull.Value ? null : objRow[convcc_PapersBigTopicDefault.QuestionTypeId].ToString().Trim(); //题目类型Id
objvcc_PapersBigTopicDefaultEN.QuestionTypeName = objRow[convcc_PapersBigTopicDefault.QuestionTypeName] == DBNull.Value ? null : objRow[convcc_PapersBigTopicDefault.QuestionTypeName].ToString().Trim(); //题目类型名
objvcc_PapersBigTopicDefaultEN.PapersBigTopicName = objRow[convcc_PapersBigTopicDefault.PapersBigTopicName] == DBNull.Value ? null : objRow[convcc_PapersBigTopicDefault.PapersBigTopicName].ToString().Trim(); //试卷大题目名称
objvcc_PapersBigTopicDefaultEN.TopicDescription = objRow[convcc_PapersBigTopicDefault.TopicDescription] == DBNull.Value ? null : objRow[convcc_PapersBigTopicDefault.TopicDescription].ToString().Trim(); //标题描述
objvcc_PapersBigTopicDefaultEN.TopicScores = objRow[convcc_PapersBigTopicDefault.TopicScores] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_PapersBigTopicDefault.TopicScores].ToString().Trim()); //大题得分
objvcc_PapersBigTopicDefaultEN.UpdDate = objRow[convcc_PapersBigTopicDefault.UpdDate].ToString().Trim(); //修改日期
objvcc_PapersBigTopicDefaultEN.UpdUser = objRow[convcc_PapersBigTopicDefault.UpdUser].ToString().Trim(); //修改人
objvcc_PapersBigTopicDefaultEN.Memo = objRow[convcc_PapersBigTopicDefault.Memo] == DBNull.Value ? null : objRow[convcc_PapersBigTopicDefault.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvcc_PapersBigTopicDefaultEN.PapersBigTopicDefaultId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvcc_PapersBigTopicDefaultEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsvcc_PapersBigTopicDefaultEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsvcc_PapersBigTopicDefaultEN> arrObjLst = new List<clsvcc_PapersBigTopicDefaultEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvcc_PapersBigTopicDefaultEN objvcc_PapersBigTopicDefaultEN = new clsvcc_PapersBigTopicDefaultEN();
try
{
objvcc_PapersBigTopicDefaultEN.PapersBigTopicDefaultId = objRow[convcc_PapersBigTopicDefault.PapersBigTopicDefaultId].ToString().Trim(); //PapersBigTopicDefaultId
objvcc_PapersBigTopicDefaultEN.QuestionTypeId = objRow[convcc_PapersBigTopicDefault.QuestionTypeId] == DBNull.Value ? null : objRow[convcc_PapersBigTopicDefault.QuestionTypeId].ToString().Trim(); //题目类型Id
objvcc_PapersBigTopicDefaultEN.QuestionTypeName = objRow[convcc_PapersBigTopicDefault.QuestionTypeName] == DBNull.Value ? null : objRow[convcc_PapersBigTopicDefault.QuestionTypeName].ToString().Trim(); //题目类型名
objvcc_PapersBigTopicDefaultEN.PapersBigTopicName = objRow[convcc_PapersBigTopicDefault.PapersBigTopicName] == DBNull.Value ? null : objRow[convcc_PapersBigTopicDefault.PapersBigTopicName].ToString().Trim(); //试卷大题目名称
objvcc_PapersBigTopicDefaultEN.TopicDescription = objRow[convcc_PapersBigTopicDefault.TopicDescription] == DBNull.Value ? null : objRow[convcc_PapersBigTopicDefault.TopicDescription].ToString().Trim(); //标题描述
objvcc_PapersBigTopicDefaultEN.TopicScores = objRow[convcc_PapersBigTopicDefault.TopicScores] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_PapersBigTopicDefault.TopicScores].ToString().Trim()); //大题得分
objvcc_PapersBigTopicDefaultEN.UpdDate = objRow[convcc_PapersBigTopicDefault.UpdDate].ToString().Trim(); //修改日期
objvcc_PapersBigTopicDefaultEN.UpdUser = objRow[convcc_PapersBigTopicDefault.UpdUser].ToString().Trim(); //修改人
objvcc_PapersBigTopicDefaultEN.Memo = objRow[convcc_PapersBigTopicDefault.Memo] == DBNull.Value ? null : objRow[convcc_PapersBigTopicDefault.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvcc_PapersBigTopicDefaultEN.PapersBigTopicDefaultId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvcc_PapersBigTopicDefaultEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objvcc_PapersBigTopicDefaultEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool Getvcc_PapersBigTopicDefault(ref clsvcc_PapersBigTopicDefaultEN objvcc_PapersBigTopicDefaultEN)
{
bool bolResult = vcc_PapersBigTopicDefaultDA.Getvcc_PapersBigTopicDefault(ref objvcc_PapersBigTopicDefaultEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "strPapersBigTopicDefaultId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvcc_PapersBigTopicDefaultEN GetObjByPapersBigTopicDefaultId(string strPapersBigTopicDefaultId)
{
if (strPapersBigTopicDefaultId.IndexOf(' ') >=0)
{
var strMsg = string.Format("(errid:Busi000079)在表中,关键字[strPapersBigTopicDefaultId]中不能有空格!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
if (string.IsNullOrEmpty(strPapersBigTopicDefaultId) == true)
{
var strMsg = string.Format("(errid:Busi000020)在表中,关键字[strPapersBigTopicDefaultId]不能为空!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
clsvcc_PapersBigTopicDefaultEN objvcc_PapersBigTopicDefaultEN = vcc_PapersBigTopicDefaultDA.GetObjByPapersBigTopicDefaultId(strPapersBigTopicDefaultId);
return objvcc_PapersBigTopicDefaultEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsvcc_PapersBigTopicDefaultEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsvcc_PapersBigTopicDefaultEN objvcc_PapersBigTopicDefaultEN = vcc_PapersBigTopicDefaultDA.GetFirstObj(strWhereCond);
 return objvcc_PapersBigTopicDefaultEN;
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
public static clsvcc_PapersBigTopicDefaultEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsvcc_PapersBigTopicDefaultEN objvcc_PapersBigTopicDefaultEN = vcc_PapersBigTopicDefaultDA.GetObjByDataRow(objRow);
 return objvcc_PapersBigTopicDefaultEN;
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
public static clsvcc_PapersBigTopicDefaultEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsvcc_PapersBigTopicDefaultEN objvcc_PapersBigTopicDefaultEN = vcc_PapersBigTopicDefaultDA.GetObjByDataRow(objRow);
 return objvcc_PapersBigTopicDefaultEN;
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
 /// <param name = "strPapersBigTopicDefaultId">所给的关键字</param>
 /// <param name = "lstvcc_PapersBigTopicDefaultObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvcc_PapersBigTopicDefaultEN GetObjByPapersBigTopicDefaultIdFromList(string strPapersBigTopicDefaultId, List<clsvcc_PapersBigTopicDefaultEN> lstvcc_PapersBigTopicDefaultObjLst)
{
foreach (clsvcc_PapersBigTopicDefaultEN objvcc_PapersBigTopicDefaultEN in lstvcc_PapersBigTopicDefaultObjLst)
{
if (objvcc_PapersBigTopicDefaultEN.PapersBigTopicDefaultId == strPapersBigTopicDefaultId)
{
return objvcc_PapersBigTopicDefaultEN;
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
 string strMaxPapersBigTopicDefaultId;
 try
 {
 strMaxPapersBigTopicDefaultId = clsvcc_PapersBigTopicDefaultDA.GetMaxStrId();
 return strMaxPapersBigTopicDefaultId;
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
 string strPapersBigTopicDefaultId;
 try
 {
 strPapersBigTopicDefaultId = new clsvcc_PapersBigTopicDefaultDA().GetFirstID(strWhereCond);
 return strPapersBigTopicDefaultId;
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
 arrList = vcc_PapersBigTopicDefaultDA.GetID(strWhereCond);
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
bool bolIsExist = vcc_PapersBigTopicDefaultDA.IsExistCondRec(strWhereCond);
return bolIsExist;
}

 /// <summary>
 /// 判断当前表中是否存在给定关键字值的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExist)
 /// </summary>
 /// <param name = "strPapersBigTopicDefaultId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public static bool IsExist(string strPapersBigTopicDefaultId)
{
if (string.IsNullOrEmpty(strPapersBigTopicDefaultId) == true)
{
var strMsg = string.Format("(errid:Busi000027)在表中,关键字[strPapersBigTopicDefaultId]不能为空!!(from {0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
//检测记录是否存在
bool bolIsExist = vcc_PapersBigTopicDefaultDA.IsExist(strPapersBigTopicDefaultId);
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
 bolIsExist = clsvcc_PapersBigTopicDefaultDA.IsExistTable();
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
 bolIsExist = vcc_PapersBigTopicDefaultDA.IsExistTable(strTabName);
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
 /// <param name = "objvcc_PapersBigTopicDefaultENS">源对象</param>
 /// <param name = "objvcc_PapersBigTopicDefaultENT">目标对象</param>
 public static void CopyTo(clsvcc_PapersBigTopicDefaultEN objvcc_PapersBigTopicDefaultENS, clsvcc_PapersBigTopicDefaultEN objvcc_PapersBigTopicDefaultENT)
{
try
{
objvcc_PapersBigTopicDefaultENT.PapersBigTopicDefaultId = objvcc_PapersBigTopicDefaultENS.PapersBigTopicDefaultId; //PapersBigTopicDefaultId
objvcc_PapersBigTopicDefaultENT.QuestionTypeId = objvcc_PapersBigTopicDefaultENS.QuestionTypeId; //题目类型Id
objvcc_PapersBigTopicDefaultENT.QuestionTypeName = objvcc_PapersBigTopicDefaultENS.QuestionTypeName; //题目类型名
objvcc_PapersBigTopicDefaultENT.PapersBigTopicName = objvcc_PapersBigTopicDefaultENS.PapersBigTopicName; //试卷大题目名称
objvcc_PapersBigTopicDefaultENT.TopicDescription = objvcc_PapersBigTopicDefaultENS.TopicDescription; //标题描述
objvcc_PapersBigTopicDefaultENT.TopicScores = objvcc_PapersBigTopicDefaultENS.TopicScores; //大题得分
objvcc_PapersBigTopicDefaultENT.UpdDate = objvcc_PapersBigTopicDefaultENS.UpdDate; //修改日期
objvcc_PapersBigTopicDefaultENT.UpdUser = objvcc_PapersBigTopicDefaultENS.UpdUser; //修改人
objvcc_PapersBigTopicDefaultENT.Memo = objvcc_PapersBigTopicDefaultENS.Memo; //备注
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
 /// <param name = "objvcc_PapersBigTopicDefaultEN">源简化对象</param>
 public static void SetUpdFlag(clsvcc_PapersBigTopicDefaultEN objvcc_PapersBigTopicDefaultEN)
{
try
{
objvcc_PapersBigTopicDefaultEN.ClearUpdateState();
   string strsfUpdFldSetStr = objvcc_PapersBigTopicDefaultEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(convcc_PapersBigTopicDefault.PapersBigTopicDefaultId, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_PapersBigTopicDefaultEN.PapersBigTopicDefaultId = objvcc_PapersBigTopicDefaultEN.PapersBigTopicDefaultId; //PapersBigTopicDefaultId
}
if (arrFldSet.Contains(convcc_PapersBigTopicDefault.QuestionTypeId, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_PapersBigTopicDefaultEN.QuestionTypeId = objvcc_PapersBigTopicDefaultEN.QuestionTypeId == "[null]" ? null :  objvcc_PapersBigTopicDefaultEN.QuestionTypeId; //题目类型Id
}
if (arrFldSet.Contains(convcc_PapersBigTopicDefault.QuestionTypeName, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_PapersBigTopicDefaultEN.QuestionTypeName = objvcc_PapersBigTopicDefaultEN.QuestionTypeName == "[null]" ? null :  objvcc_PapersBigTopicDefaultEN.QuestionTypeName; //题目类型名
}
if (arrFldSet.Contains(convcc_PapersBigTopicDefault.PapersBigTopicName, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_PapersBigTopicDefaultEN.PapersBigTopicName = objvcc_PapersBigTopicDefaultEN.PapersBigTopicName == "[null]" ? null :  objvcc_PapersBigTopicDefaultEN.PapersBigTopicName; //试卷大题目名称
}
if (arrFldSet.Contains(convcc_PapersBigTopicDefault.TopicDescription, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_PapersBigTopicDefaultEN.TopicDescription = objvcc_PapersBigTopicDefaultEN.TopicDescription == "[null]" ? null :  objvcc_PapersBigTopicDefaultEN.TopicDescription; //标题描述
}
if (arrFldSet.Contains(convcc_PapersBigTopicDefault.TopicScores, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_PapersBigTopicDefaultEN.TopicScores = objvcc_PapersBigTopicDefaultEN.TopicScores; //大题得分
}
if (arrFldSet.Contains(convcc_PapersBigTopicDefault.UpdDate, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_PapersBigTopicDefaultEN.UpdDate = objvcc_PapersBigTopicDefaultEN.UpdDate; //修改日期
}
if (arrFldSet.Contains(convcc_PapersBigTopicDefault.UpdUser, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_PapersBigTopicDefaultEN.UpdUser = objvcc_PapersBigTopicDefaultEN.UpdUser; //修改人
}
if (arrFldSet.Contains(convcc_PapersBigTopicDefault.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objvcc_PapersBigTopicDefaultEN.Memo = objvcc_PapersBigTopicDefaultEN.Memo == "[null]" ? null :  objvcc_PapersBigTopicDefaultEN.Memo; //备注
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
 /// <param name = "objvcc_PapersBigTopicDefaultEN">源简化对象</param>
 public static void AccessFldValueNull(clsvcc_PapersBigTopicDefaultEN objvcc_PapersBigTopicDefaultEN)
{
try
{
if (objvcc_PapersBigTopicDefaultEN.QuestionTypeId == "[null]") objvcc_PapersBigTopicDefaultEN.QuestionTypeId = null; //题目类型Id
if (objvcc_PapersBigTopicDefaultEN.QuestionTypeName == "[null]") objvcc_PapersBigTopicDefaultEN.QuestionTypeName = null; //题目类型名
if (objvcc_PapersBigTopicDefaultEN.PapersBigTopicName == "[null]") objvcc_PapersBigTopicDefaultEN.PapersBigTopicName = null; //试卷大题目名称
if (objvcc_PapersBigTopicDefaultEN.TopicDescription == "[null]") objvcc_PapersBigTopicDefaultEN.TopicDescription = null; //标题描述
if (objvcc_PapersBigTopicDefaultEN.Memo == "[null]") objvcc_PapersBigTopicDefaultEN.Memo = null; //备注
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
public static void CheckProperty4Condition(clsvcc_PapersBigTopicDefaultEN objvcc_PapersBigTopicDefaultEN)
{
 vcc_PapersBigTopicDefaultDA.CheckProperty4Condition(objvcc_PapersBigTopicDefaultEN);
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
if (clsQuestionTypeBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsQuestionTypeBL没有刷新缓存机制(clsQuestionTypeBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clscc_PapersBigTopicDefaultBL.objCommFun4BL == null)
{
strMsg = string.Format("类clscc_PapersBigTopicDefaultBL没有刷新缓存机制(clscc_PapersBigTopicDefaultBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by PapersBigTopicDefaultId");
//if (arrvcc_PapersBigTopicDefaultObjLstCache == null)
//{
//arrvcc_PapersBigTopicDefaultObjLstCache = vcc_PapersBigTopicDefaultDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "strPapersBigTopicDefaultId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvcc_PapersBigTopicDefaultEN GetObjByPapersBigTopicDefaultIdCache(string strPapersBigTopicDefaultId)
{
//获取缓存中的对象列表
string strKey = string.Format("{0}", clsvcc_PapersBigTopicDefaultEN._CurrTabName);
List<clsvcc_PapersBigTopicDefaultEN> arrvcc_PapersBigTopicDefaultObjLstCache = GetObjLstCache();
IEnumerable <clsvcc_PapersBigTopicDefaultEN> arrvcc_PapersBigTopicDefaultObjLst_Sel =
arrvcc_PapersBigTopicDefaultObjLstCache
.Where(x=> x.PapersBigTopicDefaultId == strPapersBigTopicDefaultId 
);
if (arrvcc_PapersBigTopicDefaultObjLst_Sel.Count() == 0)
{
   clsvcc_PapersBigTopicDefaultEN obj = clsvcc_PapersBigTopicDefaultBL.GetObjByPapersBigTopicDefaultId(strPapersBigTopicDefaultId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
 }
return null;
}
return arrvcc_PapersBigTopicDefaultObjLst_Sel.First();
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvcc_PapersBigTopicDefaultEN> GetAllvcc_PapersBigTopicDefaultObjLstCache()
{
//获取缓存中的对象列表
List<clsvcc_PapersBigTopicDefaultEN> arrvcc_PapersBigTopicDefaultObjLstCache = GetObjLstCache(); 
return arrvcc_PapersBigTopicDefaultObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvcc_PapersBigTopicDefaultEN> GetObjLstCache()
{
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}", clsvcc_PapersBigTopicDefaultEN._CurrTabName);
List<clsvcc_PapersBigTopicDefaultEN> arrvcc_PapersBigTopicDefaultObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrvcc_PapersBigTopicDefaultObjLstCache;
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
string strKey = string.Format("{0}", clsvcc_PapersBigTopicDefaultEN._CurrTabName);
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
public static string Func(string strInFldName, string strOutFldName, string strPapersBigTopicDefaultId)
{
if (strInFldName != convcc_PapersBigTopicDefault.PapersBigTopicDefaultId)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (convcc_PapersBigTopicDefault.AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", convcc_PapersBigTopicDefault.AttributeName));
throw new Exception(strMsg);
}
var objvcc_PapersBigTopicDefault = clsvcc_PapersBigTopicDefaultBL.GetObjByPapersBigTopicDefaultIdCache(strPapersBigTopicDefaultId);
if (objvcc_PapersBigTopicDefault == null) return "";
return objvcc_PapersBigTopicDefault[strOutFldName].ToString();
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
int intRecCount = clsvcc_PapersBigTopicDefaultDA.GetRecCount(strTabName);
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
int intRecCount = clsvcc_PapersBigTopicDefaultDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsvcc_PapersBigTopicDefaultDA.GetRecCount();
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
int intRecCount = clsvcc_PapersBigTopicDefaultDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objvcc_PapersBigTopicDefaultCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsvcc_PapersBigTopicDefaultEN objvcc_PapersBigTopicDefaultCond)
{
List<clsvcc_PapersBigTopicDefaultEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsvcc_PapersBigTopicDefaultEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convcc_PapersBigTopicDefault.AttributeName)
{
if (objvcc_PapersBigTopicDefaultCond.IsUpdated(strFldName) == false) continue;
if (objvcc_PapersBigTopicDefaultCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvcc_PapersBigTopicDefaultCond[strFldName].ToString());
}
else
{
if (objvcc_PapersBigTopicDefaultCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvcc_PapersBigTopicDefaultCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvcc_PapersBigTopicDefaultCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvcc_PapersBigTopicDefaultCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvcc_PapersBigTopicDefaultCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvcc_PapersBigTopicDefaultCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvcc_PapersBigTopicDefaultCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvcc_PapersBigTopicDefaultCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvcc_PapersBigTopicDefaultCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvcc_PapersBigTopicDefaultCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvcc_PapersBigTopicDefaultCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvcc_PapersBigTopicDefaultCond[strFldName]));
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
 List<string> arrList = clsvcc_PapersBigTopicDefaultDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = vcc_PapersBigTopicDefaultDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = vcc_PapersBigTopicDefaultDA.GetFldValueNoDistinct(strFldName, strWhereCond);
return arrList;
}



 #endregion 表操作常用函数
}
}