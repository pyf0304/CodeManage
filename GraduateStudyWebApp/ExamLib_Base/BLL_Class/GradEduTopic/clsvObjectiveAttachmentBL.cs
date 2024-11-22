
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvObjectiveAttachmentBL
 表名:vObjectiveAttachment(01120618)
 * 版本:2023.08.23.1(服务器:WIN-SRV103-116)
 日期:2023/08/24 13:02:24
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
public static class  clsvObjectiveAttachmentBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "lngObjectiveAttachmentId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvObjectiveAttachmentEN GetObj(this K_ObjectiveAttachmentId_vObjectiveAttachment myKey)
{
clsvObjectiveAttachmentEN objvObjectiveAttachmentEN = clsvObjectiveAttachmentBL.vObjectiveAttachmentDA.GetObjByObjectiveAttachmentId(myKey.Value);
return objvObjectiveAttachmentEN;
}

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvObjectiveAttachmentEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvObjectiveAttachmentEN SetTopicObjectiveId(this clsvObjectiveAttachmentEN objvObjectiveAttachmentEN, string strTopicObjectiveId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strTopicObjectiveId, convObjectiveAttachment.TopicObjectiveId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTopicObjectiveId, 8, convObjectiveAttachment.TopicObjectiveId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strTopicObjectiveId, 8, convObjectiveAttachment.TopicObjectiveId);
}
objvObjectiveAttachmentEN.TopicObjectiveId = strTopicObjectiveId; //客观Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvObjectiveAttachmentEN.dicFldComparisonOp.ContainsKey(convObjectiveAttachment.TopicObjectiveId) == false)
{
objvObjectiveAttachmentEN.dicFldComparisonOp.Add(convObjectiveAttachment.TopicObjectiveId, strComparisonOp);
}
else
{
objvObjectiveAttachmentEN.dicFldComparisonOp[convObjectiveAttachment.TopicObjectiveId] = strComparisonOp;
}
}
return objvObjectiveAttachmentEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvObjectiveAttachmentEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvObjectiveAttachmentEN SetObjectiveAttachmentId(this clsvObjectiveAttachmentEN objvObjectiveAttachmentEN, long lngObjectiveAttachmentId, string strComparisonOp="")
	{
objvObjectiveAttachmentEN.ObjectiveAttachmentId = lngObjectiveAttachmentId; //客观附件Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvObjectiveAttachmentEN.dicFldComparisonOp.ContainsKey(convObjectiveAttachment.ObjectiveAttachmentId) == false)
{
objvObjectiveAttachmentEN.dicFldComparisonOp.Add(convObjectiveAttachment.ObjectiveAttachmentId, strComparisonOp);
}
else
{
objvObjectiveAttachmentEN.dicFldComparisonOp[convObjectiveAttachment.ObjectiveAttachmentId] = strComparisonOp;
}
}
return objvObjectiveAttachmentEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvObjectiveAttachmentEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvObjectiveAttachmentEN SetObjectiveAttachmentName(this clsvObjectiveAttachmentEN objvObjectiveAttachmentEN, string strObjectiveAttachmentName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strObjectiveAttachmentName, 200, convObjectiveAttachment.ObjectiveAttachmentName);
}
objvObjectiveAttachmentEN.ObjectiveAttachmentName = strObjectiveAttachmentName; //附件名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvObjectiveAttachmentEN.dicFldComparisonOp.ContainsKey(convObjectiveAttachment.ObjectiveAttachmentName) == false)
{
objvObjectiveAttachmentEN.dicFldComparisonOp.Add(convObjectiveAttachment.ObjectiveAttachmentName, strComparisonOp);
}
else
{
objvObjectiveAttachmentEN.dicFldComparisonOp[convObjectiveAttachment.ObjectiveAttachmentName] = strComparisonOp;
}
}
return objvObjectiveAttachmentEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvObjectiveAttachmentEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvObjectiveAttachmentEN SetFilePath(this clsvObjectiveAttachmentEN objvObjectiveAttachmentEN, string strFilePath, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strFilePath, convObjectiveAttachment.FilePath);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFilePath, 500, convObjectiveAttachment.FilePath);
}
objvObjectiveAttachmentEN.FilePath = strFilePath; //文件路径
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvObjectiveAttachmentEN.dicFldComparisonOp.ContainsKey(convObjectiveAttachment.FilePath) == false)
{
objvObjectiveAttachmentEN.dicFldComparisonOp.Add(convObjectiveAttachment.FilePath, strComparisonOp);
}
else
{
objvObjectiveAttachmentEN.dicFldComparisonOp[convObjectiveAttachment.FilePath] = strComparisonOp;
}
}
return objvObjectiveAttachmentEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvObjectiveAttachmentEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvObjectiveAttachmentEN SetUpdDate(this clsvObjectiveAttachmentEN objvObjectiveAttachmentEN, string strUpdDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdDate, 20, convObjectiveAttachment.UpdDate);
}
objvObjectiveAttachmentEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvObjectiveAttachmentEN.dicFldComparisonOp.ContainsKey(convObjectiveAttachment.UpdDate) == false)
{
objvObjectiveAttachmentEN.dicFldComparisonOp.Add(convObjectiveAttachment.UpdDate, strComparisonOp);
}
else
{
objvObjectiveAttachmentEN.dicFldComparisonOp[convObjectiveAttachment.UpdDate] = strComparisonOp;
}
}
return objvObjectiveAttachmentEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvObjectiveAttachmentEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvObjectiveAttachmentEN SetUpdUserId(this clsvObjectiveAttachmentEN objvObjectiveAttachmentEN, string strUpdUserId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdUserId, 20, convObjectiveAttachment.UpdUserId);
}
objvObjectiveAttachmentEN.UpdUserId = strUpdUserId; //修改用户Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvObjectiveAttachmentEN.dicFldComparisonOp.ContainsKey(convObjectiveAttachment.UpdUserId) == false)
{
objvObjectiveAttachmentEN.dicFldComparisonOp.Add(convObjectiveAttachment.UpdUserId, strComparisonOp);
}
else
{
objvObjectiveAttachmentEN.dicFldComparisonOp[convObjectiveAttachment.UpdUserId] = strComparisonOp;
}
}
return objvObjectiveAttachmentEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvObjectiveAttachmentEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvObjectiveAttachmentEN SetMemo(this clsvObjectiveAttachmentEN objvObjectiveAttachmentEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, convObjectiveAttachment.Memo);
}
objvObjectiveAttachmentEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvObjectiveAttachmentEN.dicFldComparisonOp.ContainsKey(convObjectiveAttachment.Memo) == false)
{
objvObjectiveAttachmentEN.dicFldComparisonOp.Add(convObjectiveAttachment.Memo, strComparisonOp);
}
else
{
objvObjectiveAttachmentEN.dicFldComparisonOp[convObjectiveAttachment.Memo] = strComparisonOp;
}
}
return objvObjectiveAttachmentEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvObjectiveAttachmentEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvObjectiveAttachmentEN SetObjectiveName(this clsvObjectiveAttachmentEN objvObjectiveAttachmentEN, string strObjectiveName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strObjectiveName, 500, convObjectiveAttachment.ObjectiveName);
}
objvObjectiveAttachmentEN.ObjectiveName = strObjectiveName; //客观名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvObjectiveAttachmentEN.dicFldComparisonOp.ContainsKey(convObjectiveAttachment.ObjectiveName) == false)
{
objvObjectiveAttachmentEN.dicFldComparisonOp.Add(convObjectiveAttachment.ObjectiveName, strComparisonOp);
}
else
{
objvObjectiveAttachmentEN.dicFldComparisonOp[convObjectiveAttachment.ObjectiveName] = strComparisonOp;
}
}
return objvObjectiveAttachmentEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvObjectiveAttachmentEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvObjectiveAttachmentEN SetObjectiveContent(this clsvObjectiveAttachmentEN objvObjectiveAttachmentEN, string strObjectiveContent, string strComparisonOp="")
	{
objvObjectiveAttachmentEN.ObjectiveContent = strObjectiveContent; //客观内容
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvObjectiveAttachmentEN.dicFldComparisonOp.ContainsKey(convObjectiveAttachment.ObjectiveContent) == false)
{
objvObjectiveAttachmentEN.dicFldComparisonOp.Add(convObjectiveAttachment.ObjectiveContent, strComparisonOp);
}
else
{
objvObjectiveAttachmentEN.dicFldComparisonOp[convObjectiveAttachment.ObjectiveContent] = strComparisonOp;
}
}
return objvObjectiveAttachmentEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvObjectiveAttachmentEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvObjectiveAttachmentEN SetObjectiveType(this clsvObjectiveAttachmentEN objvObjectiveAttachmentEN, string strObjectiveType, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strObjectiveType, 2, convObjectiveAttachment.ObjectiveType);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strObjectiveType, 2, convObjectiveAttachment.ObjectiveType);
}
objvObjectiveAttachmentEN.ObjectiveType = strObjectiveType; //客观类型
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvObjectiveAttachmentEN.dicFldComparisonOp.ContainsKey(convObjectiveAttachment.ObjectiveType) == false)
{
objvObjectiveAttachmentEN.dicFldComparisonOp.Add(convObjectiveAttachment.ObjectiveType, strComparisonOp);
}
else
{
objvObjectiveAttachmentEN.dicFldComparisonOp[convObjectiveAttachment.ObjectiveType] = strComparisonOp;
}
}
return objvObjectiveAttachmentEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvObjectiveAttachmentEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvObjectiveAttachmentEN SetObjectiveTypeName(this clsvObjectiveAttachmentEN objvObjectiveAttachmentEN, string strObjectiveTypeName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strObjectiveTypeName, 8, convObjectiveAttachment.ObjectiveTypeName);
}
objvObjectiveAttachmentEN.ObjectiveTypeName = strObjectiveTypeName; //ObjectiveTypeName
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvObjectiveAttachmentEN.dicFldComparisonOp.ContainsKey(convObjectiveAttachment.ObjectiveTypeName) == false)
{
objvObjectiveAttachmentEN.dicFldComparisonOp.Add(convObjectiveAttachment.ObjectiveTypeName, strComparisonOp);
}
else
{
objvObjectiveAttachmentEN.dicFldComparisonOp[convObjectiveAttachment.ObjectiveTypeName] = strComparisonOp;
}
}
return objvObjectiveAttachmentEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvObjectiveAttachmentEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvObjectiveAttachmentEN SetConclusion(this clsvObjectiveAttachmentEN objvObjectiveAttachmentEN, string strConclusion, string strComparisonOp="")
	{
objvObjectiveAttachmentEN.Conclusion = strConclusion; //结论
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvObjectiveAttachmentEN.dicFldComparisonOp.ContainsKey(convObjectiveAttachment.Conclusion) == false)
{
objvObjectiveAttachmentEN.dicFldComparisonOp.Add(convObjectiveAttachment.Conclusion, strComparisonOp);
}
else
{
objvObjectiveAttachmentEN.dicFldComparisonOp[convObjectiveAttachment.Conclusion] = strComparisonOp;
}
}
return objvObjectiveAttachmentEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvObjectiveAttachmentEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvObjectiveAttachmentEN SetIdCurrEduCls(this clsvObjectiveAttachmentEN objvObjectiveAttachmentEN, string strIdCurrEduCls, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdCurrEduCls, 8, convObjectiveAttachment.IdCurrEduCls);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdCurrEduCls, 8, convObjectiveAttachment.IdCurrEduCls);
}
objvObjectiveAttachmentEN.IdCurrEduCls = strIdCurrEduCls; //教学班流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvObjectiveAttachmentEN.dicFldComparisonOp.ContainsKey(convObjectiveAttachment.IdCurrEduCls) == false)
{
objvObjectiveAttachmentEN.dicFldComparisonOp.Add(convObjectiveAttachment.IdCurrEduCls, strComparisonOp);
}
else
{
objvObjectiveAttachmentEN.dicFldComparisonOp[convObjectiveAttachment.IdCurrEduCls] = strComparisonOp;
}
}
return objvObjectiveAttachmentEN;
	}

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CopyObj)
 /// </summary>
 /// <param name = "objvObjectiveAttachmentENS">源对象</param>
 /// <param name = "objvObjectiveAttachmentENT">目标对象</param>
 public static void CopyTo(this clsvObjectiveAttachmentEN objvObjectiveAttachmentENS, clsvObjectiveAttachmentEN objvObjectiveAttachmentENT)
{
try
{
objvObjectiveAttachmentENT.TopicObjectiveId = objvObjectiveAttachmentENS.TopicObjectiveId; //客观Id
objvObjectiveAttachmentENT.ObjectiveAttachmentId = objvObjectiveAttachmentENS.ObjectiveAttachmentId; //客观附件Id
objvObjectiveAttachmentENT.ObjectiveAttachmentName = objvObjectiveAttachmentENS.ObjectiveAttachmentName; //附件名称
objvObjectiveAttachmentENT.FilePath = objvObjectiveAttachmentENS.FilePath; //文件路径
objvObjectiveAttachmentENT.UpdDate = objvObjectiveAttachmentENS.UpdDate; //修改日期
objvObjectiveAttachmentENT.UpdUserId = objvObjectiveAttachmentENS.UpdUserId; //修改用户Id
objvObjectiveAttachmentENT.Memo = objvObjectiveAttachmentENS.Memo; //备注
objvObjectiveAttachmentENT.ObjectiveName = objvObjectiveAttachmentENS.ObjectiveName; //客观名称
objvObjectiveAttachmentENT.ObjectiveContent = objvObjectiveAttachmentENS.ObjectiveContent; //客观内容
objvObjectiveAttachmentENT.ObjectiveType = objvObjectiveAttachmentENS.ObjectiveType; //客观类型
objvObjectiveAttachmentENT.ObjectiveTypeName = objvObjectiveAttachmentENS.ObjectiveTypeName; //ObjectiveTypeName
objvObjectiveAttachmentENT.Conclusion = objvObjectiveAttachmentENS.Conclusion; //结论
objvObjectiveAttachmentENT.IdCurrEduCls = objvObjectiveAttachmentENS.IdCurrEduCls; //教学班流水号
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
 /// <param name = "objvObjectiveAttachmentENS">源对象</param>
 /// <returns>目标对象=>clsvObjectiveAttachmentEN:objvObjectiveAttachmentENT</returns>
 public static clsvObjectiveAttachmentEN CopyTo(this clsvObjectiveAttachmentEN objvObjectiveAttachmentENS)
{
try
{
 clsvObjectiveAttachmentEN objvObjectiveAttachmentENT = new clsvObjectiveAttachmentEN()
{
TopicObjectiveId = objvObjectiveAttachmentENS.TopicObjectiveId, //客观Id
ObjectiveAttachmentId = objvObjectiveAttachmentENS.ObjectiveAttachmentId, //客观附件Id
ObjectiveAttachmentName = objvObjectiveAttachmentENS.ObjectiveAttachmentName, //附件名称
FilePath = objvObjectiveAttachmentENS.FilePath, //文件路径
UpdDate = objvObjectiveAttachmentENS.UpdDate, //修改日期
UpdUserId = objvObjectiveAttachmentENS.UpdUserId, //修改用户Id
Memo = objvObjectiveAttachmentENS.Memo, //备注
ObjectiveName = objvObjectiveAttachmentENS.ObjectiveName, //客观名称
ObjectiveContent = objvObjectiveAttachmentENS.ObjectiveContent, //客观内容
ObjectiveType = objvObjectiveAttachmentENS.ObjectiveType, //客观类型
ObjectiveTypeName = objvObjectiveAttachmentENS.ObjectiveTypeName, //ObjectiveTypeName
Conclusion = objvObjectiveAttachmentENS.Conclusion, //结论
IdCurrEduCls = objvObjectiveAttachmentENS.IdCurrEduCls, //教学班流水号
};
 return objvObjectiveAttachmentENT;
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
public static void CheckProperty4Condition(this clsvObjectiveAttachmentEN objvObjectiveAttachmentEN)
{
 clsvObjectiveAttachmentBL.vObjectiveAttachmentDA.CheckProperty4Condition(objvObjectiveAttachmentEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvObjectiveAttachmentEN objvObjectiveAttachmentCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvObjectiveAttachmentCond.IsUpdated(convObjectiveAttachment.TopicObjectiveId) == true)
{
string strComparisonOpTopicObjectiveId = objvObjectiveAttachmentCond.dicFldComparisonOp[convObjectiveAttachment.TopicObjectiveId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convObjectiveAttachment.TopicObjectiveId, objvObjectiveAttachmentCond.TopicObjectiveId, strComparisonOpTopicObjectiveId);
}
if (objvObjectiveAttachmentCond.IsUpdated(convObjectiveAttachment.ObjectiveAttachmentId) == true)
{
string strComparisonOpObjectiveAttachmentId = objvObjectiveAttachmentCond.dicFldComparisonOp[convObjectiveAttachment.ObjectiveAttachmentId];
strWhereCond += string.Format(" And {0} {2} {1}", convObjectiveAttachment.ObjectiveAttachmentId, objvObjectiveAttachmentCond.ObjectiveAttachmentId, strComparisonOpObjectiveAttachmentId);
}
if (objvObjectiveAttachmentCond.IsUpdated(convObjectiveAttachment.ObjectiveAttachmentName) == true)
{
string strComparisonOpObjectiveAttachmentName = objvObjectiveAttachmentCond.dicFldComparisonOp[convObjectiveAttachment.ObjectiveAttachmentName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convObjectiveAttachment.ObjectiveAttachmentName, objvObjectiveAttachmentCond.ObjectiveAttachmentName, strComparisonOpObjectiveAttachmentName);
}
if (objvObjectiveAttachmentCond.IsUpdated(convObjectiveAttachment.FilePath) == true)
{
string strComparisonOpFilePath = objvObjectiveAttachmentCond.dicFldComparisonOp[convObjectiveAttachment.FilePath];
strWhereCond += string.Format(" And {0} {2} '{1}'", convObjectiveAttachment.FilePath, objvObjectiveAttachmentCond.FilePath, strComparisonOpFilePath);
}
if (objvObjectiveAttachmentCond.IsUpdated(convObjectiveAttachment.UpdDate) == true)
{
string strComparisonOpUpdDate = objvObjectiveAttachmentCond.dicFldComparisonOp[convObjectiveAttachment.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convObjectiveAttachment.UpdDate, objvObjectiveAttachmentCond.UpdDate, strComparisonOpUpdDate);
}
if (objvObjectiveAttachmentCond.IsUpdated(convObjectiveAttachment.UpdUserId) == true)
{
string strComparisonOpUpdUserId = objvObjectiveAttachmentCond.dicFldComparisonOp[convObjectiveAttachment.UpdUserId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convObjectiveAttachment.UpdUserId, objvObjectiveAttachmentCond.UpdUserId, strComparisonOpUpdUserId);
}
if (objvObjectiveAttachmentCond.IsUpdated(convObjectiveAttachment.Memo) == true)
{
string strComparisonOpMemo = objvObjectiveAttachmentCond.dicFldComparisonOp[convObjectiveAttachment.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convObjectiveAttachment.Memo, objvObjectiveAttachmentCond.Memo, strComparisonOpMemo);
}
if (objvObjectiveAttachmentCond.IsUpdated(convObjectiveAttachment.ObjectiveName) == true)
{
string strComparisonOpObjectiveName = objvObjectiveAttachmentCond.dicFldComparisonOp[convObjectiveAttachment.ObjectiveName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convObjectiveAttachment.ObjectiveName, objvObjectiveAttachmentCond.ObjectiveName, strComparisonOpObjectiveName);
}
//数据类型string(text)在函数:[AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj]中没有处理!
if (objvObjectiveAttachmentCond.IsUpdated(convObjectiveAttachment.ObjectiveType) == true)
{
string strComparisonOpObjectiveType = objvObjectiveAttachmentCond.dicFldComparisonOp[convObjectiveAttachment.ObjectiveType];
strWhereCond += string.Format(" And {0} {2} '{1}'", convObjectiveAttachment.ObjectiveType, objvObjectiveAttachmentCond.ObjectiveType, strComparisonOpObjectiveType);
}
if (objvObjectiveAttachmentCond.IsUpdated(convObjectiveAttachment.ObjectiveTypeName) == true)
{
string strComparisonOpObjectiveTypeName = objvObjectiveAttachmentCond.dicFldComparisonOp[convObjectiveAttachment.ObjectiveTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convObjectiveAttachment.ObjectiveTypeName, objvObjectiveAttachmentCond.ObjectiveTypeName, strComparisonOpObjectiveTypeName);
}
//数据类型string(text)在函数:[AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj]中没有处理!
if (objvObjectiveAttachmentCond.IsUpdated(convObjectiveAttachment.IdCurrEduCls) == true)
{
string strComparisonOpIdCurrEduCls = objvObjectiveAttachmentCond.dicFldComparisonOp[convObjectiveAttachment.IdCurrEduCls];
strWhereCond += string.Format(" And {0} {2} '{1}'", convObjectiveAttachment.IdCurrEduCls, objvObjectiveAttachmentCond.IdCurrEduCls, strComparisonOpIdCurrEduCls);
}
 return strWhereCond;
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_vObjectiveAttachment
{
public virtual bool UpdRelaTabDate(long lngObjectiveAttachmentId, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// vObjectiveAttachment(vObjectiveAttachment)
 /// 数据源类型:视图
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsvObjectiveAttachmentBL
{
public static RelatedActions_vObjectiveAttachment relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsvObjectiveAttachmentDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsvObjectiveAttachmentDA vObjectiveAttachmentDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsvObjectiveAttachmentDA();
}
return uniqueInstance;
}
}

 /// <summary>
 /// 类的构造函数
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ClassConstructor1)
 /// </summary>
 public clsvObjectiveAttachmentBL()
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
if (string.IsNullOrEmpty(clsvObjectiveAttachmentEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvObjectiveAttachmentEN._ConnectString);
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
public static DataTable GetDataTable_vObjectiveAttachment(string strWhereCond)
{
DataTable objDT;
try
{
objDT = vObjectiveAttachmentDA.GetDataTable_vObjectiveAttachment(strWhereCond);
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
objDT = vObjectiveAttachmentDA.GetDataTable(strWhereCond);
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
objDT = vObjectiveAttachmentDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = vObjectiveAttachmentDA.GetDataTable(strWhereCond, strTabName);
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
objDT = vObjectiveAttachmentDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = vObjectiveAttachmentDA.GetDataTable_Top(objTopPara);
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
objDT = vObjectiveAttachmentDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = vObjectiveAttachmentDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = vObjectiveAttachmentDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
 /// <param name = "arrObjectiveAttachmentIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static List<clsvObjectiveAttachmentEN> GetObjLstByObjectiveAttachmentIdLst(List<long> arrObjectiveAttachmentIdLst)
{
List<clsvObjectiveAttachmentEN> arrObjLst = new List<clsvObjectiveAttachmentEN>(); 
System.Data.DataTable objDT; 
 string strSqlConditionStr = clsArray.GetSqlInStrByArray(arrObjectiveAttachmentIdLst);
 string strWhereCond = string.Format("ObjectiveAttachmentId in ({0})", strSqlConditionStr);
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvObjectiveAttachmentEN objvObjectiveAttachmentEN = new clsvObjectiveAttachmentEN();
try
{
objvObjectiveAttachmentEN.TopicObjectiveId = objRow[convObjectiveAttachment.TopicObjectiveId].ToString().Trim(); //客观Id
objvObjectiveAttachmentEN.ObjectiveAttachmentId = Int32.Parse(objRow[convObjectiveAttachment.ObjectiveAttachmentId].ToString().Trim()); //客观附件Id
objvObjectiveAttachmentEN.ObjectiveAttachmentName = objRow[convObjectiveAttachment.ObjectiveAttachmentName] == DBNull.Value ? null : objRow[convObjectiveAttachment.ObjectiveAttachmentName].ToString().Trim(); //附件名称
objvObjectiveAttachmentEN.FilePath = objRow[convObjectiveAttachment.FilePath].ToString().Trim(); //文件路径
objvObjectiveAttachmentEN.UpdDate = objRow[convObjectiveAttachment.UpdDate] == DBNull.Value ? null : objRow[convObjectiveAttachment.UpdDate].ToString().Trim(); //修改日期
objvObjectiveAttachmentEN.UpdUserId = objRow[convObjectiveAttachment.UpdUserId] == DBNull.Value ? null : objRow[convObjectiveAttachment.UpdUserId].ToString().Trim(); //修改用户Id
objvObjectiveAttachmentEN.Memo = objRow[convObjectiveAttachment.Memo] == DBNull.Value ? null : objRow[convObjectiveAttachment.Memo].ToString().Trim(); //备注
objvObjectiveAttachmentEN.ObjectiveName = objRow[convObjectiveAttachment.ObjectiveName] == DBNull.Value ? null : objRow[convObjectiveAttachment.ObjectiveName].ToString().Trim(); //客观名称
objvObjectiveAttachmentEN.ObjectiveContent = objRow[convObjectiveAttachment.ObjectiveContent] == DBNull.Value ? null : objRow[convObjectiveAttachment.ObjectiveContent].ToString().Trim(); //客观内容
objvObjectiveAttachmentEN.ObjectiveType = objRow[convObjectiveAttachment.ObjectiveType] == DBNull.Value ? null : objRow[convObjectiveAttachment.ObjectiveType].ToString().Trim(); //客观类型
objvObjectiveAttachmentEN.ObjectiveTypeName = objRow[convObjectiveAttachment.ObjectiveTypeName] == DBNull.Value ? null : objRow[convObjectiveAttachment.ObjectiveTypeName].ToString().Trim(); //ObjectiveTypeName
objvObjectiveAttachmentEN.Conclusion = objRow[convObjectiveAttachment.Conclusion] == DBNull.Value ? null : objRow[convObjectiveAttachment.Conclusion].ToString().Trim(); //结论
objvObjectiveAttachmentEN.IdCurrEduCls = objRow[convObjectiveAttachment.IdCurrEduCls] == DBNull.Value ? null : objRow[convObjectiveAttachment.IdCurrEduCls].ToString().Trim(); //教学班流水号
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvObjectiveAttachmentEN.ObjectiveAttachmentId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvObjectiveAttachmentEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrObjectiveAttachmentIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsvObjectiveAttachmentEN> GetObjLstByObjectiveAttachmentIdLstCache(List<long> arrObjectiveAttachmentIdLst, string strIdCurrEduCls)
{
string strKey = string.Format("{0}_{1}", clsvObjectiveAttachmentEN._CurrTabName, strIdCurrEduCls);
List<clsvObjectiveAttachmentEN> arrvObjectiveAttachmentObjLstCache = GetObjLstCache(strIdCurrEduCls);
IEnumerable <clsvObjectiveAttachmentEN> arrvObjectiveAttachmentObjLst_Sel =
arrvObjectiveAttachmentObjLstCache
.Where(x => arrObjectiveAttachmentIdLst.Contains(x.ObjectiveAttachmentId));
return arrvObjectiveAttachmentObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvObjectiveAttachmentEN> GetObjLst(string strWhereCond)
{
List<clsvObjectiveAttachmentEN> arrObjLst = new List<clsvObjectiveAttachmentEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvObjectiveAttachmentEN objvObjectiveAttachmentEN = new clsvObjectiveAttachmentEN();
try
{
objvObjectiveAttachmentEN.TopicObjectiveId = objRow[convObjectiveAttachment.TopicObjectiveId].ToString().Trim(); //客观Id
objvObjectiveAttachmentEN.ObjectiveAttachmentId = Int32.Parse(objRow[convObjectiveAttachment.ObjectiveAttachmentId].ToString().Trim()); //客观附件Id
objvObjectiveAttachmentEN.ObjectiveAttachmentName = objRow[convObjectiveAttachment.ObjectiveAttachmentName] == DBNull.Value ? null : objRow[convObjectiveAttachment.ObjectiveAttachmentName].ToString().Trim(); //附件名称
objvObjectiveAttachmentEN.FilePath = objRow[convObjectiveAttachment.FilePath].ToString().Trim(); //文件路径
objvObjectiveAttachmentEN.UpdDate = objRow[convObjectiveAttachment.UpdDate] == DBNull.Value ? null : objRow[convObjectiveAttachment.UpdDate].ToString().Trim(); //修改日期
objvObjectiveAttachmentEN.UpdUserId = objRow[convObjectiveAttachment.UpdUserId] == DBNull.Value ? null : objRow[convObjectiveAttachment.UpdUserId].ToString().Trim(); //修改用户Id
objvObjectiveAttachmentEN.Memo = objRow[convObjectiveAttachment.Memo] == DBNull.Value ? null : objRow[convObjectiveAttachment.Memo].ToString().Trim(); //备注
objvObjectiveAttachmentEN.ObjectiveName = objRow[convObjectiveAttachment.ObjectiveName] == DBNull.Value ? null : objRow[convObjectiveAttachment.ObjectiveName].ToString().Trim(); //客观名称
objvObjectiveAttachmentEN.ObjectiveContent = objRow[convObjectiveAttachment.ObjectiveContent] == DBNull.Value ? null : objRow[convObjectiveAttachment.ObjectiveContent].ToString().Trim(); //客观内容
objvObjectiveAttachmentEN.ObjectiveType = objRow[convObjectiveAttachment.ObjectiveType] == DBNull.Value ? null : objRow[convObjectiveAttachment.ObjectiveType].ToString().Trim(); //客观类型
objvObjectiveAttachmentEN.ObjectiveTypeName = objRow[convObjectiveAttachment.ObjectiveTypeName] == DBNull.Value ? null : objRow[convObjectiveAttachment.ObjectiveTypeName].ToString().Trim(); //ObjectiveTypeName
objvObjectiveAttachmentEN.Conclusion = objRow[convObjectiveAttachment.Conclusion] == DBNull.Value ? null : objRow[convObjectiveAttachment.Conclusion].ToString().Trim(); //结论
objvObjectiveAttachmentEN.IdCurrEduCls = objRow[convObjectiveAttachment.IdCurrEduCls] == DBNull.Value ? null : objRow[convObjectiveAttachment.IdCurrEduCls].ToString().Trim(); //教学班流水号
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvObjectiveAttachmentEN.ObjectiveAttachmentId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvObjectiveAttachmentEN);
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
public static List<clsvObjectiveAttachmentEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsvObjectiveAttachmentEN> arrObjLst = new List<clsvObjectiveAttachmentEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvObjectiveAttachmentEN objvObjectiveAttachmentEN = new clsvObjectiveAttachmentEN();
try
{
objvObjectiveAttachmentEN.TopicObjectiveId = objRow[convObjectiveAttachment.TopicObjectiveId].ToString().Trim(); //客观Id
objvObjectiveAttachmentEN.ObjectiveAttachmentId = Int32.Parse(objRow[convObjectiveAttachment.ObjectiveAttachmentId].ToString().Trim()); //客观附件Id
objvObjectiveAttachmentEN.ObjectiveAttachmentName = objRow[convObjectiveAttachment.ObjectiveAttachmentName] == DBNull.Value ? null : objRow[convObjectiveAttachment.ObjectiveAttachmentName].ToString().Trim(); //附件名称
objvObjectiveAttachmentEN.FilePath = objRow[convObjectiveAttachment.FilePath].ToString().Trim(); //文件路径
objvObjectiveAttachmentEN.UpdDate = objRow[convObjectiveAttachment.UpdDate] == DBNull.Value ? null : objRow[convObjectiveAttachment.UpdDate].ToString().Trim(); //修改日期
objvObjectiveAttachmentEN.UpdUserId = objRow[convObjectiveAttachment.UpdUserId] == DBNull.Value ? null : objRow[convObjectiveAttachment.UpdUserId].ToString().Trim(); //修改用户Id
objvObjectiveAttachmentEN.Memo = objRow[convObjectiveAttachment.Memo] == DBNull.Value ? null : objRow[convObjectiveAttachment.Memo].ToString().Trim(); //备注
objvObjectiveAttachmentEN.ObjectiveName = objRow[convObjectiveAttachment.ObjectiveName] == DBNull.Value ? null : objRow[convObjectiveAttachment.ObjectiveName].ToString().Trim(); //客观名称
objvObjectiveAttachmentEN.ObjectiveContent = objRow[convObjectiveAttachment.ObjectiveContent] == DBNull.Value ? null : objRow[convObjectiveAttachment.ObjectiveContent].ToString().Trim(); //客观内容
objvObjectiveAttachmentEN.ObjectiveType = objRow[convObjectiveAttachment.ObjectiveType] == DBNull.Value ? null : objRow[convObjectiveAttachment.ObjectiveType].ToString().Trim(); //客观类型
objvObjectiveAttachmentEN.ObjectiveTypeName = objRow[convObjectiveAttachment.ObjectiveTypeName] == DBNull.Value ? null : objRow[convObjectiveAttachment.ObjectiveTypeName].ToString().Trim(); //ObjectiveTypeName
objvObjectiveAttachmentEN.Conclusion = objRow[convObjectiveAttachment.Conclusion] == DBNull.Value ? null : objRow[convObjectiveAttachment.Conclusion].ToString().Trim(); //结论
objvObjectiveAttachmentEN.IdCurrEduCls = objRow[convObjectiveAttachment.IdCurrEduCls] == DBNull.Value ? null : objRow[convObjectiveAttachment.IdCurrEduCls].ToString().Trim(); //教学班流水号
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvObjectiveAttachmentEN.ObjectiveAttachmentId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvObjectiveAttachmentEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objvObjectiveAttachmentCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsvObjectiveAttachmentEN> GetSubObjLstCache(clsvObjectiveAttachmentEN objvObjectiveAttachmentCond)
{
 string strIdCurrEduCls = objvObjectiveAttachmentCond.IdCurrEduCls;
 if (string.IsNullOrEmpty(strIdCurrEduCls) == true)
{
string strMsg = string.Format("(errid:Busi000172)在表中,缓存分类字段值不能为空!(clsvObjectiveAttachmentBL:GetSubObjLstCache)");
throw new Exception(strMsg);
}
List<clsvObjectiveAttachmentEN> arrObjLstCache = GetObjLstCache(strIdCurrEduCls);
IEnumerable <clsvObjectiveAttachmentEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convObjectiveAttachment.AttributeName)
{
if (objvObjectiveAttachmentCond.IsUpdated(strFldName) == false) continue;
if (objvObjectiveAttachmentCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvObjectiveAttachmentCond[strFldName].ToString());
}
else
{
if (objvObjectiveAttachmentCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvObjectiveAttachmentCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvObjectiveAttachmentCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvObjectiveAttachmentCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvObjectiveAttachmentCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvObjectiveAttachmentCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvObjectiveAttachmentCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvObjectiveAttachmentCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvObjectiveAttachmentCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvObjectiveAttachmentCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvObjectiveAttachmentCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvObjectiveAttachmentCond[strFldName]));
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
public static List<clsvObjectiveAttachmentEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsvObjectiveAttachmentEN> arrObjLst = new List<clsvObjectiveAttachmentEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvObjectiveAttachmentEN objvObjectiveAttachmentEN = new clsvObjectiveAttachmentEN();
try
{
objvObjectiveAttachmentEN.TopicObjectiveId = objRow[convObjectiveAttachment.TopicObjectiveId].ToString().Trim(); //客观Id
objvObjectiveAttachmentEN.ObjectiveAttachmentId = Int32.Parse(objRow[convObjectiveAttachment.ObjectiveAttachmentId].ToString().Trim()); //客观附件Id
objvObjectiveAttachmentEN.ObjectiveAttachmentName = objRow[convObjectiveAttachment.ObjectiveAttachmentName] == DBNull.Value ? null : objRow[convObjectiveAttachment.ObjectiveAttachmentName].ToString().Trim(); //附件名称
objvObjectiveAttachmentEN.FilePath = objRow[convObjectiveAttachment.FilePath].ToString().Trim(); //文件路径
objvObjectiveAttachmentEN.UpdDate = objRow[convObjectiveAttachment.UpdDate] == DBNull.Value ? null : objRow[convObjectiveAttachment.UpdDate].ToString().Trim(); //修改日期
objvObjectiveAttachmentEN.UpdUserId = objRow[convObjectiveAttachment.UpdUserId] == DBNull.Value ? null : objRow[convObjectiveAttachment.UpdUserId].ToString().Trim(); //修改用户Id
objvObjectiveAttachmentEN.Memo = objRow[convObjectiveAttachment.Memo] == DBNull.Value ? null : objRow[convObjectiveAttachment.Memo].ToString().Trim(); //备注
objvObjectiveAttachmentEN.ObjectiveName = objRow[convObjectiveAttachment.ObjectiveName] == DBNull.Value ? null : objRow[convObjectiveAttachment.ObjectiveName].ToString().Trim(); //客观名称
objvObjectiveAttachmentEN.ObjectiveContent = objRow[convObjectiveAttachment.ObjectiveContent] == DBNull.Value ? null : objRow[convObjectiveAttachment.ObjectiveContent].ToString().Trim(); //客观内容
objvObjectiveAttachmentEN.ObjectiveType = objRow[convObjectiveAttachment.ObjectiveType] == DBNull.Value ? null : objRow[convObjectiveAttachment.ObjectiveType].ToString().Trim(); //客观类型
objvObjectiveAttachmentEN.ObjectiveTypeName = objRow[convObjectiveAttachment.ObjectiveTypeName] == DBNull.Value ? null : objRow[convObjectiveAttachment.ObjectiveTypeName].ToString().Trim(); //ObjectiveTypeName
objvObjectiveAttachmentEN.Conclusion = objRow[convObjectiveAttachment.Conclusion] == DBNull.Value ? null : objRow[convObjectiveAttachment.Conclusion].ToString().Trim(); //结论
objvObjectiveAttachmentEN.IdCurrEduCls = objRow[convObjectiveAttachment.IdCurrEduCls] == DBNull.Value ? null : objRow[convObjectiveAttachment.IdCurrEduCls].ToString().Trim(); //教学班流水号
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvObjectiveAttachmentEN.ObjectiveAttachmentId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvObjectiveAttachmentEN);
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
public static List<clsvObjectiveAttachmentEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsvObjectiveAttachmentEN> arrObjLst = new List<clsvObjectiveAttachmentEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvObjectiveAttachmentEN objvObjectiveAttachmentEN = new clsvObjectiveAttachmentEN();
try
{
objvObjectiveAttachmentEN.TopicObjectiveId = objRow[convObjectiveAttachment.TopicObjectiveId].ToString().Trim(); //客观Id
objvObjectiveAttachmentEN.ObjectiveAttachmentId = Int32.Parse(objRow[convObjectiveAttachment.ObjectiveAttachmentId].ToString().Trim()); //客观附件Id
objvObjectiveAttachmentEN.ObjectiveAttachmentName = objRow[convObjectiveAttachment.ObjectiveAttachmentName] == DBNull.Value ? null : objRow[convObjectiveAttachment.ObjectiveAttachmentName].ToString().Trim(); //附件名称
objvObjectiveAttachmentEN.FilePath = objRow[convObjectiveAttachment.FilePath].ToString().Trim(); //文件路径
objvObjectiveAttachmentEN.UpdDate = objRow[convObjectiveAttachment.UpdDate] == DBNull.Value ? null : objRow[convObjectiveAttachment.UpdDate].ToString().Trim(); //修改日期
objvObjectiveAttachmentEN.UpdUserId = objRow[convObjectiveAttachment.UpdUserId] == DBNull.Value ? null : objRow[convObjectiveAttachment.UpdUserId].ToString().Trim(); //修改用户Id
objvObjectiveAttachmentEN.Memo = objRow[convObjectiveAttachment.Memo] == DBNull.Value ? null : objRow[convObjectiveAttachment.Memo].ToString().Trim(); //备注
objvObjectiveAttachmentEN.ObjectiveName = objRow[convObjectiveAttachment.ObjectiveName] == DBNull.Value ? null : objRow[convObjectiveAttachment.ObjectiveName].ToString().Trim(); //客观名称
objvObjectiveAttachmentEN.ObjectiveContent = objRow[convObjectiveAttachment.ObjectiveContent] == DBNull.Value ? null : objRow[convObjectiveAttachment.ObjectiveContent].ToString().Trim(); //客观内容
objvObjectiveAttachmentEN.ObjectiveType = objRow[convObjectiveAttachment.ObjectiveType] == DBNull.Value ? null : objRow[convObjectiveAttachment.ObjectiveType].ToString().Trim(); //客观类型
objvObjectiveAttachmentEN.ObjectiveTypeName = objRow[convObjectiveAttachment.ObjectiveTypeName] == DBNull.Value ? null : objRow[convObjectiveAttachment.ObjectiveTypeName].ToString().Trim(); //ObjectiveTypeName
objvObjectiveAttachmentEN.Conclusion = objRow[convObjectiveAttachment.Conclusion] == DBNull.Value ? null : objRow[convObjectiveAttachment.Conclusion].ToString().Trim(); //结论
objvObjectiveAttachmentEN.IdCurrEduCls = objRow[convObjectiveAttachment.IdCurrEduCls] == DBNull.Value ? null : objRow[convObjectiveAttachment.IdCurrEduCls].ToString().Trim(); //教学班流水号
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvObjectiveAttachmentEN.ObjectiveAttachmentId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvObjectiveAttachmentEN);
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
List<clsvObjectiveAttachmentEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsvObjectiveAttachmentEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsvObjectiveAttachmentEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsvObjectiveAttachmentEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsvObjectiveAttachmentEN> arrObjLst = new List<clsvObjectiveAttachmentEN>(); 
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
	clsvObjectiveAttachmentEN objvObjectiveAttachmentEN = new clsvObjectiveAttachmentEN();
try
{
objvObjectiveAttachmentEN.TopicObjectiveId = objRow[convObjectiveAttachment.TopicObjectiveId].ToString().Trim(); //客观Id
objvObjectiveAttachmentEN.ObjectiveAttachmentId = Int32.Parse(objRow[convObjectiveAttachment.ObjectiveAttachmentId].ToString().Trim()); //客观附件Id
objvObjectiveAttachmentEN.ObjectiveAttachmentName = objRow[convObjectiveAttachment.ObjectiveAttachmentName] == DBNull.Value ? null : objRow[convObjectiveAttachment.ObjectiveAttachmentName].ToString().Trim(); //附件名称
objvObjectiveAttachmentEN.FilePath = objRow[convObjectiveAttachment.FilePath].ToString().Trim(); //文件路径
objvObjectiveAttachmentEN.UpdDate = objRow[convObjectiveAttachment.UpdDate] == DBNull.Value ? null : objRow[convObjectiveAttachment.UpdDate].ToString().Trim(); //修改日期
objvObjectiveAttachmentEN.UpdUserId = objRow[convObjectiveAttachment.UpdUserId] == DBNull.Value ? null : objRow[convObjectiveAttachment.UpdUserId].ToString().Trim(); //修改用户Id
objvObjectiveAttachmentEN.Memo = objRow[convObjectiveAttachment.Memo] == DBNull.Value ? null : objRow[convObjectiveAttachment.Memo].ToString().Trim(); //备注
objvObjectiveAttachmentEN.ObjectiveName = objRow[convObjectiveAttachment.ObjectiveName] == DBNull.Value ? null : objRow[convObjectiveAttachment.ObjectiveName].ToString().Trim(); //客观名称
objvObjectiveAttachmentEN.ObjectiveContent = objRow[convObjectiveAttachment.ObjectiveContent] == DBNull.Value ? null : objRow[convObjectiveAttachment.ObjectiveContent].ToString().Trim(); //客观内容
objvObjectiveAttachmentEN.ObjectiveType = objRow[convObjectiveAttachment.ObjectiveType] == DBNull.Value ? null : objRow[convObjectiveAttachment.ObjectiveType].ToString().Trim(); //客观类型
objvObjectiveAttachmentEN.ObjectiveTypeName = objRow[convObjectiveAttachment.ObjectiveTypeName] == DBNull.Value ? null : objRow[convObjectiveAttachment.ObjectiveTypeName].ToString().Trim(); //ObjectiveTypeName
objvObjectiveAttachmentEN.Conclusion = objRow[convObjectiveAttachment.Conclusion] == DBNull.Value ? null : objRow[convObjectiveAttachment.Conclusion].ToString().Trim(); //结论
objvObjectiveAttachmentEN.IdCurrEduCls = objRow[convObjectiveAttachment.IdCurrEduCls] == DBNull.Value ? null : objRow[convObjectiveAttachment.IdCurrEduCls].ToString().Trim(); //教学班流水号
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvObjectiveAttachmentEN.ObjectiveAttachmentId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvObjectiveAttachmentEN);
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
public static List<clsvObjectiveAttachmentEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsvObjectiveAttachmentEN> arrObjLst = new List<clsvObjectiveAttachmentEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvObjectiveAttachmentEN objvObjectiveAttachmentEN = new clsvObjectiveAttachmentEN();
try
{
objvObjectiveAttachmentEN.TopicObjectiveId = objRow[convObjectiveAttachment.TopicObjectiveId].ToString().Trim(); //客观Id
objvObjectiveAttachmentEN.ObjectiveAttachmentId = Int32.Parse(objRow[convObjectiveAttachment.ObjectiveAttachmentId].ToString().Trim()); //客观附件Id
objvObjectiveAttachmentEN.ObjectiveAttachmentName = objRow[convObjectiveAttachment.ObjectiveAttachmentName] == DBNull.Value ? null : objRow[convObjectiveAttachment.ObjectiveAttachmentName].ToString().Trim(); //附件名称
objvObjectiveAttachmentEN.FilePath = objRow[convObjectiveAttachment.FilePath].ToString().Trim(); //文件路径
objvObjectiveAttachmentEN.UpdDate = objRow[convObjectiveAttachment.UpdDate] == DBNull.Value ? null : objRow[convObjectiveAttachment.UpdDate].ToString().Trim(); //修改日期
objvObjectiveAttachmentEN.UpdUserId = objRow[convObjectiveAttachment.UpdUserId] == DBNull.Value ? null : objRow[convObjectiveAttachment.UpdUserId].ToString().Trim(); //修改用户Id
objvObjectiveAttachmentEN.Memo = objRow[convObjectiveAttachment.Memo] == DBNull.Value ? null : objRow[convObjectiveAttachment.Memo].ToString().Trim(); //备注
objvObjectiveAttachmentEN.ObjectiveName = objRow[convObjectiveAttachment.ObjectiveName] == DBNull.Value ? null : objRow[convObjectiveAttachment.ObjectiveName].ToString().Trim(); //客观名称
objvObjectiveAttachmentEN.ObjectiveContent = objRow[convObjectiveAttachment.ObjectiveContent] == DBNull.Value ? null : objRow[convObjectiveAttachment.ObjectiveContent].ToString().Trim(); //客观内容
objvObjectiveAttachmentEN.ObjectiveType = objRow[convObjectiveAttachment.ObjectiveType] == DBNull.Value ? null : objRow[convObjectiveAttachment.ObjectiveType].ToString().Trim(); //客观类型
objvObjectiveAttachmentEN.ObjectiveTypeName = objRow[convObjectiveAttachment.ObjectiveTypeName] == DBNull.Value ? null : objRow[convObjectiveAttachment.ObjectiveTypeName].ToString().Trim(); //ObjectiveTypeName
objvObjectiveAttachmentEN.Conclusion = objRow[convObjectiveAttachment.Conclusion] == DBNull.Value ? null : objRow[convObjectiveAttachment.Conclusion].ToString().Trim(); //结论
objvObjectiveAttachmentEN.IdCurrEduCls = objRow[convObjectiveAttachment.IdCurrEduCls] == DBNull.Value ? null : objRow[convObjectiveAttachment.IdCurrEduCls].ToString().Trim(); //教学班流水号
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvObjectiveAttachmentEN.ObjectiveAttachmentId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvObjectiveAttachmentEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsvObjectiveAttachmentEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsvObjectiveAttachmentEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsvObjectiveAttachmentEN> arrObjLst = new List<clsvObjectiveAttachmentEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvObjectiveAttachmentEN objvObjectiveAttachmentEN = new clsvObjectiveAttachmentEN();
try
{
objvObjectiveAttachmentEN.TopicObjectiveId = objRow[convObjectiveAttachment.TopicObjectiveId].ToString().Trim(); //客观Id
objvObjectiveAttachmentEN.ObjectiveAttachmentId = Int32.Parse(objRow[convObjectiveAttachment.ObjectiveAttachmentId].ToString().Trim()); //客观附件Id
objvObjectiveAttachmentEN.ObjectiveAttachmentName = objRow[convObjectiveAttachment.ObjectiveAttachmentName] == DBNull.Value ? null : objRow[convObjectiveAttachment.ObjectiveAttachmentName].ToString().Trim(); //附件名称
objvObjectiveAttachmentEN.FilePath = objRow[convObjectiveAttachment.FilePath].ToString().Trim(); //文件路径
objvObjectiveAttachmentEN.UpdDate = objRow[convObjectiveAttachment.UpdDate] == DBNull.Value ? null : objRow[convObjectiveAttachment.UpdDate].ToString().Trim(); //修改日期
objvObjectiveAttachmentEN.UpdUserId = objRow[convObjectiveAttachment.UpdUserId] == DBNull.Value ? null : objRow[convObjectiveAttachment.UpdUserId].ToString().Trim(); //修改用户Id
objvObjectiveAttachmentEN.Memo = objRow[convObjectiveAttachment.Memo] == DBNull.Value ? null : objRow[convObjectiveAttachment.Memo].ToString().Trim(); //备注
objvObjectiveAttachmentEN.ObjectiveName = objRow[convObjectiveAttachment.ObjectiveName] == DBNull.Value ? null : objRow[convObjectiveAttachment.ObjectiveName].ToString().Trim(); //客观名称
objvObjectiveAttachmentEN.ObjectiveContent = objRow[convObjectiveAttachment.ObjectiveContent] == DBNull.Value ? null : objRow[convObjectiveAttachment.ObjectiveContent].ToString().Trim(); //客观内容
objvObjectiveAttachmentEN.ObjectiveType = objRow[convObjectiveAttachment.ObjectiveType] == DBNull.Value ? null : objRow[convObjectiveAttachment.ObjectiveType].ToString().Trim(); //客观类型
objvObjectiveAttachmentEN.ObjectiveTypeName = objRow[convObjectiveAttachment.ObjectiveTypeName] == DBNull.Value ? null : objRow[convObjectiveAttachment.ObjectiveTypeName].ToString().Trim(); //ObjectiveTypeName
objvObjectiveAttachmentEN.Conclusion = objRow[convObjectiveAttachment.Conclusion] == DBNull.Value ? null : objRow[convObjectiveAttachment.Conclusion].ToString().Trim(); //结论
objvObjectiveAttachmentEN.IdCurrEduCls = objRow[convObjectiveAttachment.IdCurrEduCls] == DBNull.Value ? null : objRow[convObjectiveAttachment.IdCurrEduCls].ToString().Trim(); //教学班流水号
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvObjectiveAttachmentEN.ObjectiveAttachmentId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvObjectiveAttachmentEN);
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
public static List<clsvObjectiveAttachmentEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsvObjectiveAttachmentEN> arrObjLst = new List<clsvObjectiveAttachmentEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvObjectiveAttachmentEN objvObjectiveAttachmentEN = new clsvObjectiveAttachmentEN();
try
{
objvObjectiveAttachmentEN.TopicObjectiveId = objRow[convObjectiveAttachment.TopicObjectiveId].ToString().Trim(); //客观Id
objvObjectiveAttachmentEN.ObjectiveAttachmentId = Int32.Parse(objRow[convObjectiveAttachment.ObjectiveAttachmentId].ToString().Trim()); //客观附件Id
objvObjectiveAttachmentEN.ObjectiveAttachmentName = objRow[convObjectiveAttachment.ObjectiveAttachmentName] == DBNull.Value ? null : objRow[convObjectiveAttachment.ObjectiveAttachmentName].ToString().Trim(); //附件名称
objvObjectiveAttachmentEN.FilePath = objRow[convObjectiveAttachment.FilePath].ToString().Trim(); //文件路径
objvObjectiveAttachmentEN.UpdDate = objRow[convObjectiveAttachment.UpdDate] == DBNull.Value ? null : objRow[convObjectiveAttachment.UpdDate].ToString().Trim(); //修改日期
objvObjectiveAttachmentEN.UpdUserId = objRow[convObjectiveAttachment.UpdUserId] == DBNull.Value ? null : objRow[convObjectiveAttachment.UpdUserId].ToString().Trim(); //修改用户Id
objvObjectiveAttachmentEN.Memo = objRow[convObjectiveAttachment.Memo] == DBNull.Value ? null : objRow[convObjectiveAttachment.Memo].ToString().Trim(); //备注
objvObjectiveAttachmentEN.ObjectiveName = objRow[convObjectiveAttachment.ObjectiveName] == DBNull.Value ? null : objRow[convObjectiveAttachment.ObjectiveName].ToString().Trim(); //客观名称
objvObjectiveAttachmentEN.ObjectiveContent = objRow[convObjectiveAttachment.ObjectiveContent] == DBNull.Value ? null : objRow[convObjectiveAttachment.ObjectiveContent].ToString().Trim(); //客观内容
objvObjectiveAttachmentEN.ObjectiveType = objRow[convObjectiveAttachment.ObjectiveType] == DBNull.Value ? null : objRow[convObjectiveAttachment.ObjectiveType].ToString().Trim(); //客观类型
objvObjectiveAttachmentEN.ObjectiveTypeName = objRow[convObjectiveAttachment.ObjectiveTypeName] == DBNull.Value ? null : objRow[convObjectiveAttachment.ObjectiveTypeName].ToString().Trim(); //ObjectiveTypeName
objvObjectiveAttachmentEN.Conclusion = objRow[convObjectiveAttachment.Conclusion] == DBNull.Value ? null : objRow[convObjectiveAttachment.Conclusion].ToString().Trim(); //结论
objvObjectiveAttachmentEN.IdCurrEduCls = objRow[convObjectiveAttachment.IdCurrEduCls] == DBNull.Value ? null : objRow[convObjectiveAttachment.IdCurrEduCls].ToString().Trim(); //教学班流水号
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvObjectiveAttachmentEN.ObjectiveAttachmentId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvObjectiveAttachmentEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsvObjectiveAttachmentEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsvObjectiveAttachmentEN> arrObjLst = new List<clsvObjectiveAttachmentEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvObjectiveAttachmentEN objvObjectiveAttachmentEN = new clsvObjectiveAttachmentEN();
try
{
objvObjectiveAttachmentEN.TopicObjectiveId = objRow[convObjectiveAttachment.TopicObjectiveId].ToString().Trim(); //客观Id
objvObjectiveAttachmentEN.ObjectiveAttachmentId = Int32.Parse(objRow[convObjectiveAttachment.ObjectiveAttachmentId].ToString().Trim()); //客观附件Id
objvObjectiveAttachmentEN.ObjectiveAttachmentName = objRow[convObjectiveAttachment.ObjectiveAttachmentName] == DBNull.Value ? null : objRow[convObjectiveAttachment.ObjectiveAttachmentName].ToString().Trim(); //附件名称
objvObjectiveAttachmentEN.FilePath = objRow[convObjectiveAttachment.FilePath].ToString().Trim(); //文件路径
objvObjectiveAttachmentEN.UpdDate = objRow[convObjectiveAttachment.UpdDate] == DBNull.Value ? null : objRow[convObjectiveAttachment.UpdDate].ToString().Trim(); //修改日期
objvObjectiveAttachmentEN.UpdUserId = objRow[convObjectiveAttachment.UpdUserId] == DBNull.Value ? null : objRow[convObjectiveAttachment.UpdUserId].ToString().Trim(); //修改用户Id
objvObjectiveAttachmentEN.Memo = objRow[convObjectiveAttachment.Memo] == DBNull.Value ? null : objRow[convObjectiveAttachment.Memo].ToString().Trim(); //备注
objvObjectiveAttachmentEN.ObjectiveName = objRow[convObjectiveAttachment.ObjectiveName] == DBNull.Value ? null : objRow[convObjectiveAttachment.ObjectiveName].ToString().Trim(); //客观名称
objvObjectiveAttachmentEN.ObjectiveContent = objRow[convObjectiveAttachment.ObjectiveContent] == DBNull.Value ? null : objRow[convObjectiveAttachment.ObjectiveContent].ToString().Trim(); //客观内容
objvObjectiveAttachmentEN.ObjectiveType = objRow[convObjectiveAttachment.ObjectiveType] == DBNull.Value ? null : objRow[convObjectiveAttachment.ObjectiveType].ToString().Trim(); //客观类型
objvObjectiveAttachmentEN.ObjectiveTypeName = objRow[convObjectiveAttachment.ObjectiveTypeName] == DBNull.Value ? null : objRow[convObjectiveAttachment.ObjectiveTypeName].ToString().Trim(); //ObjectiveTypeName
objvObjectiveAttachmentEN.Conclusion = objRow[convObjectiveAttachment.Conclusion] == DBNull.Value ? null : objRow[convObjectiveAttachment.Conclusion].ToString().Trim(); //结论
objvObjectiveAttachmentEN.IdCurrEduCls = objRow[convObjectiveAttachment.IdCurrEduCls] == DBNull.Value ? null : objRow[convObjectiveAttachment.IdCurrEduCls].ToString().Trim(); //教学班流水号
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvObjectiveAttachmentEN.ObjectiveAttachmentId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvObjectiveAttachmentEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objvObjectiveAttachmentEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetvObjectiveAttachment(ref clsvObjectiveAttachmentEN objvObjectiveAttachmentEN)
{
bool bolResult = vObjectiveAttachmentDA.GetvObjectiveAttachment(ref objvObjectiveAttachmentEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "lngObjectiveAttachmentId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvObjectiveAttachmentEN GetObjByObjectiveAttachmentId(long lngObjectiveAttachmentId)
{
clsvObjectiveAttachmentEN objvObjectiveAttachmentEN = vObjectiveAttachmentDA.GetObjByObjectiveAttachmentId(lngObjectiveAttachmentId);
return objvObjectiveAttachmentEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsvObjectiveAttachmentEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsvObjectiveAttachmentEN objvObjectiveAttachmentEN = vObjectiveAttachmentDA.GetFirstObj(strWhereCond);
 return objvObjectiveAttachmentEN;
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
public static clsvObjectiveAttachmentEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsvObjectiveAttachmentEN objvObjectiveAttachmentEN = vObjectiveAttachmentDA.GetObjByDataRow(objRow);
 return objvObjectiveAttachmentEN;
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
public static clsvObjectiveAttachmentEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsvObjectiveAttachmentEN objvObjectiveAttachmentEN = vObjectiveAttachmentDA.GetObjByDataRow(objRow);
 return objvObjectiveAttachmentEN;
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
 /// <param name = "lngObjectiveAttachmentId">所给的关键字</param>
 /// <param name = "lstvObjectiveAttachmentObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvObjectiveAttachmentEN GetObjByObjectiveAttachmentIdFromList(long lngObjectiveAttachmentId, List<clsvObjectiveAttachmentEN> lstvObjectiveAttachmentObjLst)
{
foreach (clsvObjectiveAttachmentEN objvObjectiveAttachmentEN in lstvObjectiveAttachmentObjLst)
{
if (objvObjectiveAttachmentEN.ObjectiveAttachmentId == lngObjectiveAttachmentId)
{
return objvObjectiveAttachmentEN;
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
 long lngObjectiveAttachmentId;
 try
 {
 lngObjectiveAttachmentId = new clsvObjectiveAttachmentDA().GetFirstID(strWhereCond);
 return lngObjectiveAttachmentId;
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
 arrList = vObjectiveAttachmentDA.GetID(strWhereCond);
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
bool bolIsExist = vObjectiveAttachmentDA.IsExistCondRec(strWhereCond);
return bolIsExist;
}

 /// <summary>
 /// 判断当前表中是否存在给定关键字值的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExist)
 /// </summary>
 /// <param name = "lngObjectiveAttachmentId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public static bool IsExist(long lngObjectiveAttachmentId)
{
//检测记录是否存在
bool bolIsExist = vObjectiveAttachmentDA.IsExist(lngObjectiveAttachmentId);
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
 bolIsExist = clsvObjectiveAttachmentDA.IsExistTable();
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
 bolIsExist = vObjectiveAttachmentDA.IsExistTable(strTabName);
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
 /// <param name = "objvObjectiveAttachmentENS">源对象</param>
 /// <param name = "objvObjectiveAttachmentENT">目标对象</param>
 public static void CopyTo(clsvObjectiveAttachmentEN objvObjectiveAttachmentENS, clsvObjectiveAttachmentEN objvObjectiveAttachmentENT)
{
try
{
objvObjectiveAttachmentENT.TopicObjectiveId = objvObjectiveAttachmentENS.TopicObjectiveId; //客观Id
objvObjectiveAttachmentENT.ObjectiveAttachmentId = objvObjectiveAttachmentENS.ObjectiveAttachmentId; //客观附件Id
objvObjectiveAttachmentENT.ObjectiveAttachmentName = objvObjectiveAttachmentENS.ObjectiveAttachmentName; //附件名称
objvObjectiveAttachmentENT.FilePath = objvObjectiveAttachmentENS.FilePath; //文件路径
objvObjectiveAttachmentENT.UpdDate = objvObjectiveAttachmentENS.UpdDate; //修改日期
objvObjectiveAttachmentENT.UpdUserId = objvObjectiveAttachmentENS.UpdUserId; //修改用户Id
objvObjectiveAttachmentENT.Memo = objvObjectiveAttachmentENS.Memo; //备注
objvObjectiveAttachmentENT.ObjectiveName = objvObjectiveAttachmentENS.ObjectiveName; //客观名称
objvObjectiveAttachmentENT.ObjectiveContent = objvObjectiveAttachmentENS.ObjectiveContent; //客观内容
objvObjectiveAttachmentENT.ObjectiveType = objvObjectiveAttachmentENS.ObjectiveType; //客观类型
objvObjectiveAttachmentENT.ObjectiveTypeName = objvObjectiveAttachmentENS.ObjectiveTypeName; //ObjectiveTypeName
objvObjectiveAttachmentENT.Conclusion = objvObjectiveAttachmentENS.Conclusion; //结论
objvObjectiveAttachmentENT.IdCurrEduCls = objvObjectiveAttachmentENS.IdCurrEduCls; //教学班流水号
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
 /// <param name = "objvObjectiveAttachmentEN">源简化对象</param>
 public static void SetUpdFlag(clsvObjectiveAttachmentEN objvObjectiveAttachmentEN)
{
try
{
objvObjectiveAttachmentEN.ClearUpdateState();
   string strsfUpdFldSetStr = objvObjectiveAttachmentEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(convObjectiveAttachment.TopicObjectiveId, new clsStrCompareIgnoreCase())  ==  true)
{
objvObjectiveAttachmentEN.TopicObjectiveId = objvObjectiveAttachmentEN.TopicObjectiveId; //客观Id
}
if (arrFldSet.Contains(convObjectiveAttachment.ObjectiveAttachmentId, new clsStrCompareIgnoreCase())  ==  true)
{
objvObjectiveAttachmentEN.ObjectiveAttachmentId = objvObjectiveAttachmentEN.ObjectiveAttachmentId; //客观附件Id
}
if (arrFldSet.Contains(convObjectiveAttachment.ObjectiveAttachmentName, new clsStrCompareIgnoreCase())  ==  true)
{
objvObjectiveAttachmentEN.ObjectiveAttachmentName = objvObjectiveAttachmentEN.ObjectiveAttachmentName == "[null]" ? null :  objvObjectiveAttachmentEN.ObjectiveAttachmentName; //附件名称
}
if (arrFldSet.Contains(convObjectiveAttachment.FilePath, new clsStrCompareIgnoreCase())  ==  true)
{
objvObjectiveAttachmentEN.FilePath = objvObjectiveAttachmentEN.FilePath; //文件路径
}
if (arrFldSet.Contains(convObjectiveAttachment.UpdDate, new clsStrCompareIgnoreCase())  ==  true)
{
objvObjectiveAttachmentEN.UpdDate = objvObjectiveAttachmentEN.UpdDate == "[null]" ? null :  objvObjectiveAttachmentEN.UpdDate; //修改日期
}
if (arrFldSet.Contains(convObjectiveAttachment.UpdUserId, new clsStrCompareIgnoreCase())  ==  true)
{
objvObjectiveAttachmentEN.UpdUserId = objvObjectiveAttachmentEN.UpdUserId == "[null]" ? null :  objvObjectiveAttachmentEN.UpdUserId; //修改用户Id
}
if (arrFldSet.Contains(convObjectiveAttachment.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objvObjectiveAttachmentEN.Memo = objvObjectiveAttachmentEN.Memo == "[null]" ? null :  objvObjectiveAttachmentEN.Memo; //备注
}
if (arrFldSet.Contains(convObjectiveAttachment.ObjectiveName, new clsStrCompareIgnoreCase())  ==  true)
{
objvObjectiveAttachmentEN.ObjectiveName = objvObjectiveAttachmentEN.ObjectiveName == "[null]" ? null :  objvObjectiveAttachmentEN.ObjectiveName; //客观名称
}
if (arrFldSet.Contains(convObjectiveAttachment.ObjectiveContent, new clsStrCompareIgnoreCase())  ==  true)
{
objvObjectiveAttachmentEN.ObjectiveContent = objvObjectiveAttachmentEN.ObjectiveContent == "[null]" ? null :  objvObjectiveAttachmentEN.ObjectiveContent; //客观内容
}
if (arrFldSet.Contains(convObjectiveAttachment.ObjectiveType, new clsStrCompareIgnoreCase())  ==  true)
{
objvObjectiveAttachmentEN.ObjectiveType = objvObjectiveAttachmentEN.ObjectiveType == "[null]" ? null :  objvObjectiveAttachmentEN.ObjectiveType; //客观类型
}
if (arrFldSet.Contains(convObjectiveAttachment.ObjectiveTypeName, new clsStrCompareIgnoreCase())  ==  true)
{
objvObjectiveAttachmentEN.ObjectiveTypeName = objvObjectiveAttachmentEN.ObjectiveTypeName == "[null]" ? null :  objvObjectiveAttachmentEN.ObjectiveTypeName; //ObjectiveTypeName
}
if (arrFldSet.Contains(convObjectiveAttachment.Conclusion, new clsStrCompareIgnoreCase())  ==  true)
{
objvObjectiveAttachmentEN.Conclusion = objvObjectiveAttachmentEN.Conclusion == "[null]" ? null :  objvObjectiveAttachmentEN.Conclusion; //结论
}
if (arrFldSet.Contains(convObjectiveAttachment.IdCurrEduCls, new clsStrCompareIgnoreCase())  ==  true)
{
objvObjectiveAttachmentEN.IdCurrEduCls = objvObjectiveAttachmentEN.IdCurrEduCls == "[null]" ? null :  objvObjectiveAttachmentEN.IdCurrEduCls; //教学班流水号
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
 /// <param name = "objvObjectiveAttachmentEN">源简化对象</param>
 public static void AccessFldValueNull(clsvObjectiveAttachmentEN objvObjectiveAttachmentEN)
{
try
{
if (objvObjectiveAttachmentEN.ObjectiveAttachmentName == "[null]") objvObjectiveAttachmentEN.ObjectiveAttachmentName = null; //附件名称
if (objvObjectiveAttachmentEN.UpdDate == "[null]") objvObjectiveAttachmentEN.UpdDate = null; //修改日期
if (objvObjectiveAttachmentEN.UpdUserId == "[null]") objvObjectiveAttachmentEN.UpdUserId = null; //修改用户Id
if (objvObjectiveAttachmentEN.Memo == "[null]") objvObjectiveAttachmentEN.Memo = null; //备注
if (objvObjectiveAttachmentEN.ObjectiveName == "[null]") objvObjectiveAttachmentEN.ObjectiveName = null; //客观名称
if (objvObjectiveAttachmentEN.ObjectiveContent == "[null]") objvObjectiveAttachmentEN.ObjectiveContent = null; //客观内容
if (objvObjectiveAttachmentEN.ObjectiveType == "[null]") objvObjectiveAttachmentEN.ObjectiveType = null; //客观类型
if (objvObjectiveAttachmentEN.ObjectiveTypeName == "[null]") objvObjectiveAttachmentEN.ObjectiveTypeName = null; //ObjectiveTypeName
if (objvObjectiveAttachmentEN.Conclusion == "[null]") objvObjectiveAttachmentEN.Conclusion = null; //结论
if (objvObjectiveAttachmentEN.IdCurrEduCls == "[null]") objvObjectiveAttachmentEN.IdCurrEduCls = null; //教学班流水号
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
public static void CheckProperty4Condition(clsvObjectiveAttachmentEN objvObjectiveAttachmentEN)
{
 vObjectiveAttachmentDA.CheckProperty4Condition(objvObjectiveAttachmentEN);
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
if (clsObjectiveAttachmentBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsObjectiveAttachmentBL没有刷新缓存机制(clsObjectiveAttachmentBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsPaperBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsPaperBL没有刷新缓存机制(clsPaperBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsTopicObjectiveBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsTopicObjectiveBL没有刷新缓存机制(clsTopicObjectiveBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by ObjectiveAttachmentId");
//if (arrvObjectiveAttachmentObjLstCache == null)
//{
//arrvObjectiveAttachmentObjLstCache = vObjectiveAttachmentDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "lngObjectiveAttachmentId">所给的关键字</param>
 /// <param name = "strIdCurrEduCls">缓存的分类字段</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvObjectiveAttachmentEN GetObjByObjectiveAttachmentIdCache(long lngObjectiveAttachmentId, string strIdCurrEduCls)
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
string strKey = string.Format("{0}_{1}", clsvObjectiveAttachmentEN._CurrTabName, strIdCurrEduCls);
List<clsvObjectiveAttachmentEN> arrvObjectiveAttachmentObjLstCache = GetObjLstCache(strIdCurrEduCls);
IEnumerable <clsvObjectiveAttachmentEN> arrvObjectiveAttachmentObjLst_Sel =
arrvObjectiveAttachmentObjLstCache
.Where(x=> x.ObjectiveAttachmentId == lngObjectiveAttachmentId 
);
if (arrvObjectiveAttachmentObjLst_Sel.Count() == 0)
{
   clsvObjectiveAttachmentEN obj = clsvObjectiveAttachmentBL.GetObjByObjectiveAttachmentId(lngObjectiveAttachmentId);
   if (obj != null)
 {
if (obj.IdCurrEduCls == strIdCurrEduCls)
{
CacheHelper.Remove(strKey);
     return obj;
}
else
{
string strMsg = string.Format("错误: 关键字:{0}不属于分类:{1},请检查!(In {2})", lngObjectiveAttachmentId, strIdCurrEduCls, clsStackTrace.GetCurrClassFunction());
clsSysParaEN.objLog.WriteDebugLog(strMsg);
throw new Exception(strMsg);
}
 }
return null;
}
return arrvObjectiveAttachmentObjLst_Sel.First();
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvObjectiveAttachmentEN> GetAllvObjectiveAttachmentObjLstCache(string strIdCurrEduCls)
{
//获取缓存中的对象列表
List<clsvObjectiveAttachmentEN> arrvObjectiveAttachmentObjLstCache = GetObjLstCache(strIdCurrEduCls); 
return arrvObjectiveAttachmentObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvObjectiveAttachmentEN> GetObjLstCache(string strIdCurrEduCls)
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
string strKey = string.Format("{0}_{1}", clsvObjectiveAttachmentEN._CurrTabName, strIdCurrEduCls);
string strCondition = string.Format("IdCurrEduCls='{0}'", strIdCurrEduCls);
List<clsvObjectiveAttachmentEN> arrvObjectiveAttachmentObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst(strCondition); });
return arrvObjectiveAttachmentObjLstCache;
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
string strKey = string.Format("{0}_{1}", clsvObjectiveAttachmentEN._CurrTabName, strIdCurrEduCls);
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
public static string Func(string strInFldName, string strOutFldName, long lngObjectiveAttachmentId, string strIdCurrEduCls)
{
if (strInFldName != convObjectiveAttachment.ObjectiveAttachmentId)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (convObjectiveAttachment.AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", convObjectiveAttachment.AttributeName));
throw new Exception(strMsg);
}
var objvObjectiveAttachment = clsvObjectiveAttachmentBL.GetObjByObjectiveAttachmentIdCache(lngObjectiveAttachmentId, strIdCurrEduCls);
if (objvObjectiveAttachment == null) return "";
return objvObjectiveAttachment[strOutFldName].ToString();
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
int intRecCount = clsvObjectiveAttachmentDA.GetRecCount(strTabName);
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
int intRecCount = clsvObjectiveAttachmentDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsvObjectiveAttachmentDA.GetRecCount();
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
int intRecCount = clsvObjectiveAttachmentDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objvObjectiveAttachmentCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsvObjectiveAttachmentEN objvObjectiveAttachmentCond)
{
 string strIdCurrEduCls = objvObjectiveAttachmentCond.IdCurrEduCls;
 if (string.IsNullOrEmpty(strIdCurrEduCls) == true)
{
string strMsg = string.Format("(errid:Busi000174)在表中,缓存分类字段值不能为空!(clsvObjectiveAttachmentBL:GetRecCountByCondCache)");
throw new Exception(strMsg);
}
List<clsvObjectiveAttachmentEN> arrObjLstCache = GetObjLstCache(strIdCurrEduCls);
IEnumerable <clsvObjectiveAttachmentEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convObjectiveAttachment.AttributeName)
{
if (objvObjectiveAttachmentCond.IsUpdated(strFldName) == false) continue;
if (objvObjectiveAttachmentCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvObjectiveAttachmentCond[strFldName].ToString());
}
else
{
if (objvObjectiveAttachmentCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvObjectiveAttachmentCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvObjectiveAttachmentCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvObjectiveAttachmentCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvObjectiveAttachmentCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvObjectiveAttachmentCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvObjectiveAttachmentCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvObjectiveAttachmentCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvObjectiveAttachmentCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvObjectiveAttachmentCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvObjectiveAttachmentCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvObjectiveAttachmentCond[strFldName]));
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
 List<string> arrList = clsvObjectiveAttachmentDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = vObjectiveAttachmentDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = vObjectiveAttachmentDA.GetFldValueNoDistinct(strFldName, strWhereCond);
return arrList;
}



 #endregion 表操作常用函数
}
}