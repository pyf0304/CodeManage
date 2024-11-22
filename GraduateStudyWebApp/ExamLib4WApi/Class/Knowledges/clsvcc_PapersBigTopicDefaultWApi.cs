
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvcc_PapersBigTopicDefaultWApi
 表名:vcc_PapersBigTopicDefault(01120161)
 生成代码版本:2021.09.20.1
 生成日期:2021/09/21 02:45:12
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
public static class clsvcc_PapersBigTopicDefaultWApi_Static
{

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_PapersBigTopicDefaultEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_PapersBigTopicDefaultEN SetPapersBigTopicDefaultId(this clsvcc_PapersBigTopicDefaultEN objvcc_PapersBigTopicDefaultEN, string strPapersBigTopicDefaultId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strPapersBigTopicDefaultId, 8, convcc_PapersBigTopicDefault.PapersBigTopicDefaultId);
clsCheckSql.CheckFieldForeignKey(strPapersBigTopicDefaultId, 8, convcc_PapersBigTopicDefault.PapersBigTopicDefaultId);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_PapersBigTopicDefaultEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_PapersBigTopicDefaultEN SetQuestionTypeId(this clsvcc_PapersBigTopicDefaultEN objvcc_PapersBigTopicDefaultEN, string strQuestionTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strQuestionTypeId, 2, convcc_PapersBigTopicDefault.QuestionTypeId);
clsCheckSql.CheckFieldForeignKey(strQuestionTypeId, 2, convcc_PapersBigTopicDefault.QuestionTypeId);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_PapersBigTopicDefaultEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_PapersBigTopicDefaultEN SetQuestionTypeName(this clsvcc_PapersBigTopicDefaultEN objvcc_PapersBigTopicDefaultEN, string strQuestionTypeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strQuestionTypeName, 20, convcc_PapersBigTopicDefault.QuestionTypeName);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_PapersBigTopicDefaultEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_PapersBigTopicDefaultEN SetPapersBigTopicName(this clsvcc_PapersBigTopicDefaultEN objvcc_PapersBigTopicDefaultEN, string strPapersBigTopicName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strPapersBigTopicName, 50, convcc_PapersBigTopicDefault.PapersBigTopicName);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_PapersBigTopicDefaultEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_PapersBigTopicDefaultEN SetTopicDescription(this clsvcc_PapersBigTopicDefaultEN objvcc_PapersBigTopicDefaultEN, string strTopicDescription, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strTopicDescription, 100, convcc_PapersBigTopicDefault.TopicDescription);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_PapersBigTopicDefaultEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_PapersBigTopicDefaultEN SetTopicScores(this clsvcc_PapersBigTopicDefaultEN objvcc_PapersBigTopicDefaultEN, int intTopicScores, string strComparisonOp="")
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_PapersBigTopicDefaultEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_PapersBigTopicDefaultEN SetUpdDate(this clsvcc_PapersBigTopicDefaultEN objvcc_PapersBigTopicDefaultEN, string strUpdDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strUpdDate, convcc_PapersBigTopicDefault.UpdDate);
clsCheckSql.CheckFieldLen(strUpdDate, 20, convcc_PapersBigTopicDefault.UpdDate);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_PapersBigTopicDefaultEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_PapersBigTopicDefaultEN SetUpdUser(this clsvcc_PapersBigTopicDefaultEN objvcc_PapersBigTopicDefaultEN, string strUpdUser, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strUpdUser, convcc_PapersBigTopicDefault.UpdUser);
clsCheckSql.CheckFieldLen(strUpdUser, 20, convcc_PapersBigTopicDefault.UpdUser);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvcc_PapersBigTopicDefaultEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvcc_PapersBigTopicDefaultEN SetMemo(this clsvcc_PapersBigTopicDefaultEN objvcc_PapersBigTopicDefaultEN, string strMemo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMemo, 1000, convcc_PapersBigTopicDefault.Memo);
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
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvcc_PapersBigTopicDefaultEN objvcc_PapersBigTopicDefault_Cond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvcc_PapersBigTopicDefault_Cond.IsUpdated(convcc_PapersBigTopicDefault.PapersBigTopicDefaultId) == true)
{
string strComparisonOp_PapersBigTopicDefaultId = objvcc_PapersBigTopicDefault_Cond.dicFldComparisonOp[convcc_PapersBigTopicDefault.PapersBigTopicDefaultId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_PapersBigTopicDefault.PapersBigTopicDefaultId, objvcc_PapersBigTopicDefault_Cond.PapersBigTopicDefaultId, strComparisonOp_PapersBigTopicDefaultId);
}
if (objvcc_PapersBigTopicDefault_Cond.IsUpdated(convcc_PapersBigTopicDefault.QuestionTypeId) == true)
{
string strComparisonOp_QuestionTypeId = objvcc_PapersBigTopicDefault_Cond.dicFldComparisonOp[convcc_PapersBigTopicDefault.QuestionTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_PapersBigTopicDefault.QuestionTypeId, objvcc_PapersBigTopicDefault_Cond.QuestionTypeId, strComparisonOp_QuestionTypeId);
}
if (objvcc_PapersBigTopicDefault_Cond.IsUpdated(convcc_PapersBigTopicDefault.QuestionTypeName) == true)
{
string strComparisonOp_QuestionTypeName = objvcc_PapersBigTopicDefault_Cond.dicFldComparisonOp[convcc_PapersBigTopicDefault.QuestionTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_PapersBigTopicDefault.QuestionTypeName, objvcc_PapersBigTopicDefault_Cond.QuestionTypeName, strComparisonOp_QuestionTypeName);
}
if (objvcc_PapersBigTopicDefault_Cond.IsUpdated(convcc_PapersBigTopicDefault.PapersBigTopicName) == true)
{
string strComparisonOp_PapersBigTopicName = objvcc_PapersBigTopicDefault_Cond.dicFldComparisonOp[convcc_PapersBigTopicDefault.PapersBigTopicName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_PapersBigTopicDefault.PapersBigTopicName, objvcc_PapersBigTopicDefault_Cond.PapersBigTopicName, strComparisonOp_PapersBigTopicName);
}
if (objvcc_PapersBigTopicDefault_Cond.IsUpdated(convcc_PapersBigTopicDefault.TopicDescription) == true)
{
string strComparisonOp_TopicDescription = objvcc_PapersBigTopicDefault_Cond.dicFldComparisonOp[convcc_PapersBigTopicDefault.TopicDescription];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_PapersBigTopicDefault.TopicDescription, objvcc_PapersBigTopicDefault_Cond.TopicDescription, strComparisonOp_TopicDescription);
}
if (objvcc_PapersBigTopicDefault_Cond.IsUpdated(convcc_PapersBigTopicDefault.TopicScores) == true)
{
string strComparisonOp_TopicScores = objvcc_PapersBigTopicDefault_Cond.dicFldComparisonOp[convcc_PapersBigTopicDefault.TopicScores];
strWhereCond += string.Format(" And {0} {2} {1}", convcc_PapersBigTopicDefault.TopicScores, objvcc_PapersBigTopicDefault_Cond.TopicScores, strComparisonOp_TopicScores);
}
if (objvcc_PapersBigTopicDefault_Cond.IsUpdated(convcc_PapersBigTopicDefault.UpdDate) == true)
{
string strComparisonOp_UpdDate = objvcc_PapersBigTopicDefault_Cond.dicFldComparisonOp[convcc_PapersBigTopicDefault.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_PapersBigTopicDefault.UpdDate, objvcc_PapersBigTopicDefault_Cond.UpdDate, strComparisonOp_UpdDate);
}
if (objvcc_PapersBigTopicDefault_Cond.IsUpdated(convcc_PapersBigTopicDefault.UpdUser) == true)
{
string strComparisonOp_UpdUser = objvcc_PapersBigTopicDefault_Cond.dicFldComparisonOp[convcc_PapersBigTopicDefault.UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_PapersBigTopicDefault.UpdUser, objvcc_PapersBigTopicDefault_Cond.UpdUser, strComparisonOp_UpdUser);
}
if (objvcc_PapersBigTopicDefault_Cond.IsUpdated(convcc_PapersBigTopicDefault.Memo) == true)
{
string strComparisonOp_Memo = objvcc_PapersBigTopicDefault_Cond.dicFldComparisonOp[convcc_PapersBigTopicDefault.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convcc_PapersBigTopicDefault.Memo, objvcc_PapersBigTopicDefault_Cond.Memo, strComparisonOp_Memo);
}
 return strWhereCond;
}
}
 /// <summary>
 /// v试卷大题目默认(vcc_PapersBigTopicDefault)
 /// (AutoGCLib.WA_Access4CSharp:GeneCode)
 /// </summary>
public class clsvcc_PapersBigTopicDefaultWApi
{
private static readonly string mstrApiControllerName = "vcc_PapersBigTopicDefaultApi";

 public clsvcc_PapersBigTopicDefaultWApi()
 {
 }

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyId)
 /// </summary>
 /// <param name = "strPapersBigTopicDefaultId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvcc_PapersBigTopicDefaultEN GetObjByPapersBigTopicDefaultId(string strPapersBigTopicDefaultId)
{
string strAction = "GetObjByPapersBigTopicDefaultId";
string strErrMsg = string.Empty;
string strResult = "";
clsvcc_PapersBigTopicDefaultEN objvcc_PapersBigTopicDefaultEN = null;
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
objvcc_PapersBigTopicDefaultEN = JsonConvert.DeserializeObject<clsvcc_PapersBigTopicDefaultEN>((string)jobjReturn["ReturnObj"]);
return objvcc_PapersBigTopicDefaultEN;
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
public static clsvcc_PapersBigTopicDefaultEN GetObjByPapersBigTopicDefaultId_WA_Cache(string strPapersBigTopicDefaultId)
{
string strAction = "GetObjByPapersBigTopicDefaultId_Cache";
string strErrMsg = string.Empty;
string strResult = "";
clsvcc_PapersBigTopicDefaultEN objvcc_PapersBigTopicDefaultEN = null;
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
objvcc_PapersBigTopicDefaultEN = JsonConvert.DeserializeObject<clsvcc_PapersBigTopicDefaultEN>((string)jobjReturn["ReturnObj"]);
return objvcc_PapersBigTopicDefaultEN;
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
public static clsvcc_PapersBigTopicDefaultEN GetFirstObj(string strWhereCond)
{
string strAction = "GetFirstObj";
string strErrMsg = string.Empty;
string strResult = "";
clsvcc_PapersBigTopicDefaultEN objvcc_PapersBigTopicDefaultEN = null;
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
objvcc_PapersBigTopicDefaultEN = JsonConvert.DeserializeObject<clsvcc_PapersBigTopicDefaultEN>((string)jobjReturn["ReturnObj"]);
return objvcc_PapersBigTopicDefaultEN;
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
public static clsvcc_PapersBigTopicDefaultEN GetObjByPapersBigTopicDefaultId_Cache(string strPapersBigTopicDefaultId)
{
if (string.IsNullOrEmpty(strPapersBigTopicDefaultId) == true) return null;
//初始化列表缓存
string strKey = string.Format("{0}", clsvcc_PapersBigTopicDefaultEN._CurrTabName_S);
List<clsvcc_PapersBigTopicDefaultEN> arrvcc_PapersBigTopicDefaultObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsvcc_PapersBigTopicDefaultEN> arrvcc_PapersBigTopicDefaultObjLst_Sel =
from objvcc_PapersBigTopicDefaultEN in arrvcc_PapersBigTopicDefaultObjLst_Cache
where objvcc_PapersBigTopicDefaultEN.PapersBigTopicDefaultId == strPapersBigTopicDefaultId
select objvcc_PapersBigTopicDefaultEN;
if (arrvcc_PapersBigTopicDefaultObjLst_Sel.Count() == 0)
{
   clsvcc_PapersBigTopicDefaultEN obj = clsvcc_PapersBigTopicDefaultWApi.GetObjByPapersBigTopicDefaultId(strPapersBigTopicDefaultId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
     return obj;
 }
return null;
}
return arrvcc_PapersBigTopicDefaultObjLst_Sel.First();
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvcc_PapersBigTopicDefaultEN> GetObjLst(string strWhereCond)
{
 List<clsvcc_PapersBigTopicDefaultEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvcc_PapersBigTopicDefaultEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvcc_PapersBigTopicDefaultEN> GetObjLstByPapersBigTopicDefaultIdLst(List<string> arrPapersBigTopicDefaultId)
{
 List<clsvcc_PapersBigTopicDefaultEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvcc_PapersBigTopicDefaultEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static IEnumerable<clsvcc_PapersBigTopicDefaultEN> GetObjLstByPapersBigTopicDefaultIdLst_Cache(List<string> arrPapersBigTopicDefaultId)
{
//初始化列表缓存
string strKey = string.Format("{0}", clsvcc_PapersBigTopicDefaultEN._CurrTabName_S);
List<clsvcc_PapersBigTopicDefaultEN> arrvcc_PapersBigTopicDefaultObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsvcc_PapersBigTopicDefaultEN> arrvcc_PapersBigTopicDefaultObjLst_Sel =
from objvcc_PapersBigTopicDefaultEN in arrvcc_PapersBigTopicDefaultObjLst_Cache
where arrPapersBigTopicDefaultId.Contains(objvcc_PapersBigTopicDefaultEN.PapersBigTopicDefaultId)
select objvcc_PapersBigTopicDefaultEN;
return arrvcc_PapersBigTopicDefaultObjLst_Sel;
}

 /// <summary>
 /// 根据关键字列表获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstByKeyLst_WA_Cache)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvcc_PapersBigTopicDefaultEN> GetObjLstByPapersBigTopicDefaultIdLst_WA_Cache(List<string> arrPapersBigTopicDefaultId)
{
 List<clsvcc_PapersBigTopicDefaultEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvcc_PapersBigTopicDefaultEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvcc_PapersBigTopicDefaultEN> GetTopObjLst(stuTopPara objTopPara)
{
 List<clsvcc_PapersBigTopicDefaultEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvcc_PapersBigTopicDefaultEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvcc_PapersBigTopicDefaultEN> GetObjLstByRange(stuRangePara objRangePara)
{
 List<clsvcc_PapersBigTopicDefaultEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvcc_PapersBigTopicDefaultEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvcc_PapersBigTopicDefaultEN> GetObjLstByPager(stuPagerPara objPagerPara)
{
 List<clsvcc_PapersBigTopicDefaultEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvcc_PapersBigTopicDefaultEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvcc_PapersBigTopicDefaultEN> GetObjLstByPager_Cache(stuPagerPara objPagerPara)
{
 List<clsvcc_PapersBigTopicDefaultEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvcc_PapersBigTopicDefaultEN>>((string)jobjReturn["ReturnObjLst"]);
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
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_CopyObj_S)
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
public static DataTable ToDataTable(List<clsvcc_PapersBigTopicDefaultEN> arrObj)
{
DataTable dataTable = new DataTable(); //实例化
DataTable result;
if (arrObj.Count == 0) return null;
if (clsvcc_PapersBigTopicDefaultEN.AttributeName.Length == 0)
{
result = dataTable;
return result;
}
Type type = typeof(clsvcc_PapersBigTopicDefaultEN);
PropertyInfo[] arrPropertyInfo = type.GetProperties();
try
{
//Columns
foreach (string strAttrName in clsvcc_PapersBigTopicDefaultEN.AttributeName)
{
PropertyInfo proprety_Curr = arrPropertyInfo.Where(x => x.Name == strAttrName).First();
dataTable.Columns.Add(strAttrName, proprety_Curr.PropertyType);
}
foreach (clsvcc_PapersBigTopicDefaultEN objInFor in arrObj)
{
//Rows
DataRow dataRow = dataTable.NewRow();
foreach (string strAttrName in clsvcc_PapersBigTopicDefaultEN.AttributeName)
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
if (clsQuestionTypeWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsQuestionTypeWApi没有刷新缓存机制(clsQuestionTypeWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clscc_PapersBigTopicDefaultWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clscc_PapersBigTopicDefaultWApi没有刷新缓存机制(clscc_PapersBigTopicDefaultWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by PapersBigTopicDefaultId");
//if (arrvcc_PapersBigTopicDefaultObjLst_Cache == null)
//{
//arrvcc_PapersBigTopicDefaultObjLst_Cache = await clsvcc_PapersBigTopicDefaultWApi.GetObjLst(strWhereCond);
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
string strKey = string.Format("{0}", clsvcc_PapersBigTopicDefaultEN._CurrTabName_S);
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
public static List<clsvcc_PapersBigTopicDefaultEN> GetObjLst_Cache()
{
//初始化列表缓存
InitListCache(); 
string strKey = string.Format("{0}", clsvcc_PapersBigTopicDefaultEN._CurrTabName_S);
List<clsvcc_PapersBigTopicDefaultEN> arrvcc_PapersBigTopicDefaultObjLst_Cache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrvcc_PapersBigTopicDefaultObjLst_Cache;
}

 /// <summary>
 /// 根据对象列表获取DataTable
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetDataTableByObjLst)
 /// </summary>
 /// <param name = "arrObjLst">给定的对象列表</param>
 /// <returns>返回DataTable</returns>
public static DataTable GetDataTableByObjLst(List<clsvcc_PapersBigTopicDefaultEN> arrObjLst)
{
DataTable objDT = new DataTable();
objDT.Columns.Add(convcc_PapersBigTopicDefault.PapersBigTopicDefaultId, Type.GetType("System.String"));
objDT.Columns.Add(convcc_PapersBigTopicDefault.QuestionTypeId, Type.GetType("System.String"));
objDT.Columns.Add(convcc_PapersBigTopicDefault.QuestionTypeName, Type.GetType("System.String"));
objDT.Columns.Add(convcc_PapersBigTopicDefault.PapersBigTopicName, Type.GetType("System.String"));
objDT.Columns.Add(convcc_PapersBigTopicDefault.TopicDescription, Type.GetType("System.String"));
objDT.Columns.Add(convcc_PapersBigTopicDefault.TopicScores, Type.GetType("System.Int32"));
objDT.Columns.Add(convcc_PapersBigTopicDefault.UpdDate, Type.GetType("System.String"));
objDT.Columns.Add(convcc_PapersBigTopicDefault.UpdUser, Type.GetType("System.String"));
objDT.Columns.Add(convcc_PapersBigTopicDefault.Memo, Type.GetType("System.String"));
foreach (clsvcc_PapersBigTopicDefaultEN objInFor in arrObjLst)
{
DataRow objDR = objDT.NewRow();
objDR[convcc_PapersBigTopicDefault.PapersBigTopicDefaultId] = objInFor[convcc_PapersBigTopicDefault.PapersBigTopicDefaultId];
objDR[convcc_PapersBigTopicDefault.QuestionTypeId] = objInFor[convcc_PapersBigTopicDefault.QuestionTypeId];
objDR[convcc_PapersBigTopicDefault.QuestionTypeName] = objInFor[convcc_PapersBigTopicDefault.QuestionTypeName];
objDR[convcc_PapersBigTopicDefault.PapersBigTopicName] = objInFor[convcc_PapersBigTopicDefault.PapersBigTopicName];
objDR[convcc_PapersBigTopicDefault.TopicDescription] = objInFor[convcc_PapersBigTopicDefault.TopicDescription];
objDR[convcc_PapersBigTopicDefault.TopicScores] = objInFor[convcc_PapersBigTopicDefault.TopicScores];
objDR[convcc_PapersBigTopicDefault.UpdDate] = objInFor[convcc_PapersBigTopicDefault.UpdDate];
objDR[convcc_PapersBigTopicDefault.UpdUser] = objInFor[convcc_PapersBigTopicDefault.UpdUser];
objDR[convcc_PapersBigTopicDefault.Memo] = objInFor[convcc_PapersBigTopicDefault.Memo];
objDT.Rows.Add(objDR);
}
return objDT;
}
}
}