
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvConceptAttachmentBL
 表名:vConceptAttachment(01120606)
 * 版本:2023.08.23.1(服务器:WIN-SRV103-116)
 日期:2023/08/24 12:59:13
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
public static class  clsvConceptAttachmentBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "lngConceptAttachmentId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvConceptAttachmentEN GetObj(this K_ConceptAttachmentId_vConceptAttachment myKey)
{
clsvConceptAttachmentEN objvConceptAttachmentEN = clsvConceptAttachmentBL.vConceptAttachmentDA.GetObjByConceptAttachmentId(myKey.Value);
return objvConceptAttachmentEN;
}

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvConceptAttachmentEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvConceptAttachmentEN SetConceptName(this clsvConceptAttachmentEN objvConceptAttachmentEN, string strConceptName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strConceptName, 500, convConceptAttachment.ConceptName);
}
objvConceptAttachmentEN.ConceptName = strConceptName; //概念名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvConceptAttachmentEN.dicFldComparisonOp.ContainsKey(convConceptAttachment.ConceptName) == false)
{
objvConceptAttachmentEN.dicFldComparisonOp.Add(convConceptAttachment.ConceptName, strComparisonOp);
}
else
{
objvConceptAttachmentEN.dicFldComparisonOp[convConceptAttachment.ConceptName] = strComparisonOp;
}
}
return objvConceptAttachmentEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvConceptAttachmentEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvConceptAttachmentEN SetConceptAttachmentId(this clsvConceptAttachmentEN objvConceptAttachmentEN, long lngConceptAttachmentId, string strComparisonOp="")
	{
objvConceptAttachmentEN.ConceptAttachmentId = lngConceptAttachmentId; //概念附件Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvConceptAttachmentEN.dicFldComparisonOp.ContainsKey(convConceptAttachment.ConceptAttachmentId) == false)
{
objvConceptAttachmentEN.dicFldComparisonOp.Add(convConceptAttachment.ConceptAttachmentId, strComparisonOp);
}
else
{
objvConceptAttachmentEN.dicFldComparisonOp[convConceptAttachment.ConceptAttachmentId] = strComparisonOp;
}
}
return objvConceptAttachmentEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvConceptAttachmentEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvConceptAttachmentEN SetConceptContent(this clsvConceptAttachmentEN objvConceptAttachmentEN, string strConceptContent, string strComparisonOp="")
	{
objvConceptAttachmentEN.ConceptContent = strConceptContent; //概念内容
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvConceptAttachmentEN.dicFldComparisonOp.ContainsKey(convConceptAttachment.ConceptContent) == false)
{
objvConceptAttachmentEN.dicFldComparisonOp.Add(convConceptAttachment.ConceptContent, strComparisonOp);
}
else
{
objvConceptAttachmentEN.dicFldComparisonOp[convConceptAttachment.ConceptContent] = strComparisonOp;
}
}
return objvConceptAttachmentEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvConceptAttachmentEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvConceptAttachmentEN SetConceptAttachmentName(this clsvConceptAttachmentEN objvConceptAttachmentEN, string strConceptAttachmentName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strConceptAttachmentName, 200, convConceptAttachment.ConceptAttachmentName);
}
objvConceptAttachmentEN.ConceptAttachmentName = strConceptAttachmentName; //附件名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvConceptAttachmentEN.dicFldComparisonOp.ContainsKey(convConceptAttachment.ConceptAttachmentName) == false)
{
objvConceptAttachmentEN.dicFldComparisonOp.Add(convConceptAttachment.ConceptAttachmentName, strComparisonOp);
}
else
{
objvConceptAttachmentEN.dicFldComparisonOp[convConceptAttachment.ConceptAttachmentName] = strComparisonOp;
}
}
return objvConceptAttachmentEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvConceptAttachmentEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvConceptAttachmentEN SetConceptId(this clsvConceptAttachmentEN objvConceptAttachmentEN, string strConceptId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strConceptId, 8, convConceptAttachment.ConceptId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strConceptId, 8, convConceptAttachment.ConceptId);
}
objvConceptAttachmentEN.ConceptId = strConceptId; //概念Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvConceptAttachmentEN.dicFldComparisonOp.ContainsKey(convConceptAttachment.ConceptId) == false)
{
objvConceptAttachmentEN.dicFldComparisonOp.Add(convConceptAttachment.ConceptId, strComparisonOp);
}
else
{
objvConceptAttachmentEN.dicFldComparisonOp[convConceptAttachment.ConceptId] = strComparisonOp;
}
}
return objvConceptAttachmentEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvConceptAttachmentEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvConceptAttachmentEN SetIsSubmit(this clsvConceptAttachmentEN objvConceptAttachmentEN, bool bolIsSubmit, string strComparisonOp="")
	{
objvConceptAttachmentEN.IsSubmit = bolIsSubmit; //是否提交
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvConceptAttachmentEN.dicFldComparisonOp.ContainsKey(convConceptAttachment.IsSubmit) == false)
{
objvConceptAttachmentEN.dicFldComparisonOp.Add(convConceptAttachment.IsSubmit, strComparisonOp);
}
else
{
objvConceptAttachmentEN.dicFldComparisonOp[convConceptAttachment.IsSubmit] = strComparisonOp;
}
}
return objvConceptAttachmentEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvConceptAttachmentEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvConceptAttachmentEN SetFilePath(this clsvConceptAttachmentEN objvConceptAttachmentEN, string strFilePath, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strFilePath, convConceptAttachment.FilePath);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFilePath, 500, convConceptAttachment.FilePath);
}
objvConceptAttachmentEN.FilePath = strFilePath; //文件路径
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvConceptAttachmentEN.dicFldComparisonOp.ContainsKey(convConceptAttachment.FilePath) == false)
{
objvConceptAttachmentEN.dicFldComparisonOp.Add(convConceptAttachment.FilePath, strComparisonOp);
}
else
{
objvConceptAttachmentEN.dicFldComparisonOp[convConceptAttachment.FilePath] = strComparisonOp;
}
}
return objvConceptAttachmentEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvConceptAttachmentEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvConceptAttachmentEN SetUpdDate(this clsvConceptAttachmentEN objvConceptAttachmentEN, string strUpdDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdDate, 20, convConceptAttachment.UpdDate);
}
objvConceptAttachmentEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvConceptAttachmentEN.dicFldComparisonOp.ContainsKey(convConceptAttachment.UpdDate) == false)
{
objvConceptAttachmentEN.dicFldComparisonOp.Add(convConceptAttachment.UpdDate, strComparisonOp);
}
else
{
objvConceptAttachmentEN.dicFldComparisonOp[convConceptAttachment.UpdDate] = strComparisonOp;
}
}
return objvConceptAttachmentEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvConceptAttachmentEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvConceptAttachmentEN SetMemo(this clsvConceptAttachmentEN objvConceptAttachmentEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, convConceptAttachment.Memo);
}
objvConceptAttachmentEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvConceptAttachmentEN.dicFldComparisonOp.ContainsKey(convConceptAttachment.Memo) == false)
{
objvConceptAttachmentEN.dicFldComparisonOp.Add(convConceptAttachment.Memo, strComparisonOp);
}
else
{
objvConceptAttachmentEN.dicFldComparisonOp[convConceptAttachment.Memo] = strComparisonOp;
}
}
return objvConceptAttachmentEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvConceptAttachmentEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvConceptAttachmentEN SetIdCurrEduCls(this clsvConceptAttachmentEN objvConceptAttachmentEN, string strIdCurrEduCls, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdCurrEduCls, 8, convConceptAttachment.IdCurrEduCls);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdCurrEduCls, 8, convConceptAttachment.IdCurrEduCls);
}
objvConceptAttachmentEN.IdCurrEduCls = strIdCurrEduCls; //教学班流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvConceptAttachmentEN.dicFldComparisonOp.ContainsKey(convConceptAttachment.IdCurrEduCls) == false)
{
objvConceptAttachmentEN.dicFldComparisonOp.Add(convConceptAttachment.IdCurrEduCls, strComparisonOp);
}
else
{
objvConceptAttachmentEN.dicFldComparisonOp[convConceptAttachment.IdCurrEduCls] = strComparisonOp;
}
}
return objvConceptAttachmentEN;
	}

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CopyObj)
 /// </summary>
 /// <param name = "objvConceptAttachmentENS">源对象</param>
 /// <param name = "objvConceptAttachmentENT">目标对象</param>
 public static void CopyTo(this clsvConceptAttachmentEN objvConceptAttachmentENS, clsvConceptAttachmentEN objvConceptAttachmentENT)
{
try
{
objvConceptAttachmentENT.ConceptName = objvConceptAttachmentENS.ConceptName; //概念名称
objvConceptAttachmentENT.ConceptAttachmentId = objvConceptAttachmentENS.ConceptAttachmentId; //概念附件Id
objvConceptAttachmentENT.ConceptContent = objvConceptAttachmentENS.ConceptContent; //概念内容
objvConceptAttachmentENT.ConceptAttachmentName = objvConceptAttachmentENS.ConceptAttachmentName; //附件名称
objvConceptAttachmentENT.ConceptId = objvConceptAttachmentENS.ConceptId; //概念Id
objvConceptAttachmentENT.IsSubmit = objvConceptAttachmentENS.IsSubmit; //是否提交
objvConceptAttachmentENT.FilePath = objvConceptAttachmentENS.FilePath; //文件路径
objvConceptAttachmentENT.UpdDate = objvConceptAttachmentENS.UpdDate; //修改日期
objvConceptAttachmentENT.Memo = objvConceptAttachmentENS.Memo; //备注
objvConceptAttachmentENT.IdCurrEduCls = objvConceptAttachmentENS.IdCurrEduCls; //教学班流水号
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
 /// <param name = "objvConceptAttachmentENS">源对象</param>
 /// <returns>目标对象=>clsvConceptAttachmentEN:objvConceptAttachmentENT</returns>
 public static clsvConceptAttachmentEN CopyTo(this clsvConceptAttachmentEN objvConceptAttachmentENS)
{
try
{
 clsvConceptAttachmentEN objvConceptAttachmentENT = new clsvConceptAttachmentEN()
{
ConceptName = objvConceptAttachmentENS.ConceptName, //概念名称
ConceptAttachmentId = objvConceptAttachmentENS.ConceptAttachmentId, //概念附件Id
ConceptContent = objvConceptAttachmentENS.ConceptContent, //概念内容
ConceptAttachmentName = objvConceptAttachmentENS.ConceptAttachmentName, //附件名称
ConceptId = objvConceptAttachmentENS.ConceptId, //概念Id
IsSubmit = objvConceptAttachmentENS.IsSubmit, //是否提交
FilePath = objvConceptAttachmentENS.FilePath, //文件路径
UpdDate = objvConceptAttachmentENS.UpdDate, //修改日期
Memo = objvConceptAttachmentENS.Memo, //备注
IdCurrEduCls = objvConceptAttachmentENS.IdCurrEduCls, //教学班流水号
};
 return objvConceptAttachmentENT;
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
public static void CheckProperty4Condition(this clsvConceptAttachmentEN objvConceptAttachmentEN)
{
 clsvConceptAttachmentBL.vConceptAttachmentDA.CheckProperty4Condition(objvConceptAttachmentEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvConceptAttachmentEN objvConceptAttachmentCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvConceptAttachmentCond.IsUpdated(convConceptAttachment.ConceptName) == true)
{
string strComparisonOpConceptName = objvConceptAttachmentCond.dicFldComparisonOp[convConceptAttachment.ConceptName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convConceptAttachment.ConceptName, objvConceptAttachmentCond.ConceptName, strComparisonOpConceptName);
}
if (objvConceptAttachmentCond.IsUpdated(convConceptAttachment.ConceptAttachmentId) == true)
{
string strComparisonOpConceptAttachmentId = objvConceptAttachmentCond.dicFldComparisonOp[convConceptAttachment.ConceptAttachmentId];
strWhereCond += string.Format(" And {0} {2} {1}", convConceptAttachment.ConceptAttachmentId, objvConceptAttachmentCond.ConceptAttachmentId, strComparisonOpConceptAttachmentId);
}
//数据类型string(text)在函数:[AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj]中没有处理!
if (objvConceptAttachmentCond.IsUpdated(convConceptAttachment.ConceptAttachmentName) == true)
{
string strComparisonOpConceptAttachmentName = objvConceptAttachmentCond.dicFldComparisonOp[convConceptAttachment.ConceptAttachmentName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convConceptAttachment.ConceptAttachmentName, objvConceptAttachmentCond.ConceptAttachmentName, strComparisonOpConceptAttachmentName);
}
if (objvConceptAttachmentCond.IsUpdated(convConceptAttachment.ConceptId) == true)
{
string strComparisonOpConceptId = objvConceptAttachmentCond.dicFldComparisonOp[convConceptAttachment.ConceptId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convConceptAttachment.ConceptId, objvConceptAttachmentCond.ConceptId, strComparisonOpConceptId);
}
if (objvConceptAttachmentCond.IsUpdated(convConceptAttachment.IsSubmit) == true)
{
if (objvConceptAttachmentCond.IsSubmit == true)
{
strWhereCond += string.Format(" And {0} = '1'", convConceptAttachment.IsSubmit);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convConceptAttachment.IsSubmit);
}
}
if (objvConceptAttachmentCond.IsUpdated(convConceptAttachment.FilePath) == true)
{
string strComparisonOpFilePath = objvConceptAttachmentCond.dicFldComparisonOp[convConceptAttachment.FilePath];
strWhereCond += string.Format(" And {0} {2} '{1}'", convConceptAttachment.FilePath, objvConceptAttachmentCond.FilePath, strComparisonOpFilePath);
}
if (objvConceptAttachmentCond.IsUpdated(convConceptAttachment.UpdDate) == true)
{
string strComparisonOpUpdDate = objvConceptAttachmentCond.dicFldComparisonOp[convConceptAttachment.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convConceptAttachment.UpdDate, objvConceptAttachmentCond.UpdDate, strComparisonOpUpdDate);
}
if (objvConceptAttachmentCond.IsUpdated(convConceptAttachment.Memo) == true)
{
string strComparisonOpMemo = objvConceptAttachmentCond.dicFldComparisonOp[convConceptAttachment.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convConceptAttachment.Memo, objvConceptAttachmentCond.Memo, strComparisonOpMemo);
}
if (objvConceptAttachmentCond.IsUpdated(convConceptAttachment.IdCurrEduCls) == true)
{
string strComparisonOpIdCurrEduCls = objvConceptAttachmentCond.dicFldComparisonOp[convConceptAttachment.IdCurrEduCls];
strWhereCond += string.Format(" And {0} {2} '{1}'", convConceptAttachment.IdCurrEduCls, objvConceptAttachmentCond.IdCurrEduCls, strComparisonOpIdCurrEduCls);
}
 return strWhereCond;
}

 /// <summary>
 /// 检查唯一性(Uniqueness)--vConceptAttachment(vConceptAttachment), 如果不唯一,即存在相同的记录,就返回False
 /// 唯一性条件:ConceptAttachmentId_ConceptId
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckConstraint)
 /// </summary>
 /// <param name = "objvConceptAttachmentEN">要求唯一的对象</param>
 /// <returns></returns>
public static bool CheckUniqueness(this clsvConceptAttachmentEN objvConceptAttachmentEN)
{
//检测记录是否存在
bool bolIsUniqueness;
StringBuilder sbCondition = new StringBuilder();
if (objvConceptAttachmentEN == null) return true;
if (objvConceptAttachmentEN.ConceptAttachmentId == 0)
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and ConceptAttachmentId = '{0}'", objvConceptAttachmentEN.ConceptAttachmentId);
 if (objvConceptAttachmentEN.ConceptId == null)
{
 sbCondition.AppendFormat(" and ConceptId is null", objvConceptAttachmentEN.ConceptId);
}
else
{
 sbCondition.AppendFormat(" and ConceptId = '{0}'", objvConceptAttachmentEN.ConceptId);
}
if (clsvConceptAttachmentBL.IsExistRecord(sbCondition.ToString())  ==  true)
{
 bolIsUniqueness = false;
}
else
{
 bolIsUniqueness = true;
}
}
 else {
sbCondition.AppendFormat("ConceptAttachmentId !=  {0}", objvConceptAttachmentEN.ConceptAttachmentId);
 sbCondition.AppendFormat(" and ConceptAttachmentId = '{0}'", objvConceptAttachmentEN.ConceptAttachmentId);
 sbCondition.AppendFormat(" and ConceptId = '{0}'", objvConceptAttachmentEN.ConceptId);
if (clsvConceptAttachmentBL.IsExistRecord(sbCondition.ToString())  ==  true)
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
 /// 获取唯一性条件串--vConceptAttachment(vConceptAttachment), 即由对象中唯一性条件字段关键字与值组成的条件串
 /// 唯一性条件:ConceptAttachmentId_ConceptId
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetConditionString4Constraint)
 /// </summary>
 /// <param name = "objvConceptAttachmentEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(this clsvConceptAttachmentEN objvConceptAttachmentEN)
{
//检测记录是否存在
StringBuilder sbCondition = new StringBuilder();
if (objvConceptAttachmentEN == null) return "";
if (objvConceptAttachmentEN.ConceptAttachmentId == 0)
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and ConceptAttachmentId = '{0}'", objvConceptAttachmentEN.ConceptAttachmentId);
 if (objvConceptAttachmentEN.ConceptId == null)
{
 sbCondition.AppendFormat(" and ConceptId is null", objvConceptAttachmentEN.ConceptId);
}
else
{
 sbCondition.AppendFormat(" and ConceptId = '{0}'", objvConceptAttachmentEN.ConceptId);
}
return sbCondition.ToString();
}
 else {
sbCondition.AppendFormat("ConceptAttachmentId !=  {0}", objvConceptAttachmentEN.ConceptAttachmentId);
 sbCondition.AppendFormat(" and ConceptAttachmentId = '{0}'", objvConceptAttachmentEN.ConceptAttachmentId);
 sbCondition.AppendFormat(" and ConceptId = '{0}'", objvConceptAttachmentEN.ConceptId);
 return sbCondition.ToString();
}
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_vConceptAttachment
{
public virtual bool UpdRelaTabDate(long lngConceptAttachmentId, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// vConceptAttachment(vConceptAttachment)
 /// 数据源类型:视图
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsvConceptAttachmentBL
{
public static RelatedActions_vConceptAttachment relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsvConceptAttachmentDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsvConceptAttachmentDA vConceptAttachmentDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsvConceptAttachmentDA();
}
return uniqueInstance;
}
}

 /// <summary>
 /// 类的构造函数
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ClassConstructor1)
 /// </summary>
 public clsvConceptAttachmentBL()
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
if (string.IsNullOrEmpty(clsvConceptAttachmentEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvConceptAttachmentEN._ConnectString);
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
public static DataTable GetDataTable_vConceptAttachment(string strWhereCond)
{
DataTable objDT;
try
{
objDT = vConceptAttachmentDA.GetDataTable_vConceptAttachment(strWhereCond);
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
objDT = vConceptAttachmentDA.GetDataTable(strWhereCond);
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
objDT = vConceptAttachmentDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = vConceptAttachmentDA.GetDataTable(strWhereCond, strTabName);
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
objDT = vConceptAttachmentDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = vConceptAttachmentDA.GetDataTable_Top(objTopPara);
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
objDT = vConceptAttachmentDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = vConceptAttachmentDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = vConceptAttachmentDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
 /// <param name = "arrConceptAttachmentIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static List<clsvConceptAttachmentEN> GetObjLstByConceptAttachmentIdLst(List<long> arrConceptAttachmentIdLst)
{
List<clsvConceptAttachmentEN> arrObjLst = new List<clsvConceptAttachmentEN>(); 
System.Data.DataTable objDT; 
 string strSqlConditionStr = clsArray.GetSqlInStrByArray(arrConceptAttachmentIdLst);
 string strWhereCond = string.Format("ConceptAttachmentId in ({0})", strSqlConditionStr);
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvConceptAttachmentEN objvConceptAttachmentEN = new clsvConceptAttachmentEN();
try
{
objvConceptAttachmentEN.ConceptName = objRow[convConceptAttachment.ConceptName] == DBNull.Value ? null : objRow[convConceptAttachment.ConceptName].ToString().Trim(); //概念名称
objvConceptAttachmentEN.ConceptAttachmentId = Int32.Parse(objRow[convConceptAttachment.ConceptAttachmentId].ToString().Trim()); //概念附件Id
objvConceptAttachmentEN.ConceptContent = objRow[convConceptAttachment.ConceptContent] == DBNull.Value ? null : objRow[convConceptAttachment.ConceptContent].ToString().Trim(); //概念内容
objvConceptAttachmentEN.ConceptAttachmentName = objRow[convConceptAttachment.ConceptAttachmentName] == DBNull.Value ? null : objRow[convConceptAttachment.ConceptAttachmentName].ToString().Trim(); //附件名称
objvConceptAttachmentEN.ConceptId = objRow[convConceptAttachment.ConceptId] == DBNull.Value ? null : objRow[convConceptAttachment.ConceptId].ToString().Trim(); //概念Id
objvConceptAttachmentEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[convConceptAttachment.IsSubmit].ToString().Trim()); //是否提交
objvConceptAttachmentEN.FilePath = objRow[convConceptAttachment.FilePath].ToString().Trim(); //文件路径
objvConceptAttachmentEN.UpdDate = objRow[convConceptAttachment.UpdDate] == DBNull.Value ? null : objRow[convConceptAttachment.UpdDate].ToString().Trim(); //修改日期
objvConceptAttachmentEN.Memo = objRow[convConceptAttachment.Memo] == DBNull.Value ? null : objRow[convConceptAttachment.Memo].ToString().Trim(); //备注
objvConceptAttachmentEN.IdCurrEduCls = objRow[convConceptAttachment.IdCurrEduCls] == DBNull.Value ? null : objRow[convConceptAttachment.IdCurrEduCls].ToString().Trim(); //教学班流水号
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvConceptAttachmentEN.ConceptAttachmentId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvConceptAttachmentEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrConceptAttachmentIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsvConceptAttachmentEN> GetObjLstByConceptAttachmentIdLstCache(List<long> arrConceptAttachmentIdLst, string strIdCurrEduCls)
{
string strKey = string.Format("{0}_{1}", clsvConceptAttachmentEN._CurrTabName, strIdCurrEduCls);
List<clsvConceptAttachmentEN> arrvConceptAttachmentObjLstCache = GetObjLstCache(strIdCurrEduCls);
IEnumerable <clsvConceptAttachmentEN> arrvConceptAttachmentObjLst_Sel =
arrvConceptAttachmentObjLstCache
.Where(x => arrConceptAttachmentIdLst.Contains(x.ConceptAttachmentId));
return arrvConceptAttachmentObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvConceptAttachmentEN> GetObjLst(string strWhereCond)
{
List<clsvConceptAttachmentEN> arrObjLst = new List<clsvConceptAttachmentEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvConceptAttachmentEN objvConceptAttachmentEN = new clsvConceptAttachmentEN();
try
{
objvConceptAttachmentEN.ConceptName = objRow[convConceptAttachment.ConceptName] == DBNull.Value ? null : objRow[convConceptAttachment.ConceptName].ToString().Trim(); //概念名称
objvConceptAttachmentEN.ConceptAttachmentId = Int32.Parse(objRow[convConceptAttachment.ConceptAttachmentId].ToString().Trim()); //概念附件Id
objvConceptAttachmentEN.ConceptContent = objRow[convConceptAttachment.ConceptContent] == DBNull.Value ? null : objRow[convConceptAttachment.ConceptContent].ToString().Trim(); //概念内容
objvConceptAttachmentEN.ConceptAttachmentName = objRow[convConceptAttachment.ConceptAttachmentName] == DBNull.Value ? null : objRow[convConceptAttachment.ConceptAttachmentName].ToString().Trim(); //附件名称
objvConceptAttachmentEN.ConceptId = objRow[convConceptAttachment.ConceptId] == DBNull.Value ? null : objRow[convConceptAttachment.ConceptId].ToString().Trim(); //概念Id
objvConceptAttachmentEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[convConceptAttachment.IsSubmit].ToString().Trim()); //是否提交
objvConceptAttachmentEN.FilePath = objRow[convConceptAttachment.FilePath].ToString().Trim(); //文件路径
objvConceptAttachmentEN.UpdDate = objRow[convConceptAttachment.UpdDate] == DBNull.Value ? null : objRow[convConceptAttachment.UpdDate].ToString().Trim(); //修改日期
objvConceptAttachmentEN.Memo = objRow[convConceptAttachment.Memo] == DBNull.Value ? null : objRow[convConceptAttachment.Memo].ToString().Trim(); //备注
objvConceptAttachmentEN.IdCurrEduCls = objRow[convConceptAttachment.IdCurrEduCls] == DBNull.Value ? null : objRow[convConceptAttachment.IdCurrEduCls].ToString().Trim(); //教学班流水号
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvConceptAttachmentEN.ConceptAttachmentId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvConceptAttachmentEN);
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
public static List<clsvConceptAttachmentEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsvConceptAttachmentEN> arrObjLst = new List<clsvConceptAttachmentEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvConceptAttachmentEN objvConceptAttachmentEN = new clsvConceptAttachmentEN();
try
{
objvConceptAttachmentEN.ConceptName = objRow[convConceptAttachment.ConceptName] == DBNull.Value ? null : objRow[convConceptAttachment.ConceptName].ToString().Trim(); //概念名称
objvConceptAttachmentEN.ConceptAttachmentId = Int32.Parse(objRow[convConceptAttachment.ConceptAttachmentId].ToString().Trim()); //概念附件Id
objvConceptAttachmentEN.ConceptContent = objRow[convConceptAttachment.ConceptContent] == DBNull.Value ? null : objRow[convConceptAttachment.ConceptContent].ToString().Trim(); //概念内容
objvConceptAttachmentEN.ConceptAttachmentName = objRow[convConceptAttachment.ConceptAttachmentName] == DBNull.Value ? null : objRow[convConceptAttachment.ConceptAttachmentName].ToString().Trim(); //附件名称
objvConceptAttachmentEN.ConceptId = objRow[convConceptAttachment.ConceptId] == DBNull.Value ? null : objRow[convConceptAttachment.ConceptId].ToString().Trim(); //概念Id
objvConceptAttachmentEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[convConceptAttachment.IsSubmit].ToString().Trim()); //是否提交
objvConceptAttachmentEN.FilePath = objRow[convConceptAttachment.FilePath].ToString().Trim(); //文件路径
objvConceptAttachmentEN.UpdDate = objRow[convConceptAttachment.UpdDate] == DBNull.Value ? null : objRow[convConceptAttachment.UpdDate].ToString().Trim(); //修改日期
objvConceptAttachmentEN.Memo = objRow[convConceptAttachment.Memo] == DBNull.Value ? null : objRow[convConceptAttachment.Memo].ToString().Trim(); //备注
objvConceptAttachmentEN.IdCurrEduCls = objRow[convConceptAttachment.IdCurrEduCls] == DBNull.Value ? null : objRow[convConceptAttachment.IdCurrEduCls].ToString().Trim(); //教学班流水号
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvConceptAttachmentEN.ConceptAttachmentId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvConceptAttachmentEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objvConceptAttachmentCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsvConceptAttachmentEN> GetSubObjLstCache(clsvConceptAttachmentEN objvConceptAttachmentCond)
{
 string strIdCurrEduCls = objvConceptAttachmentCond.IdCurrEduCls;
 if (string.IsNullOrEmpty(strIdCurrEduCls) == true)
{
string strMsg = string.Format("(errid:Busi000172)在表中,缓存分类字段值不能为空!(clsvConceptAttachmentBL:GetSubObjLstCache)");
throw new Exception(strMsg);
}
List<clsvConceptAttachmentEN> arrObjLstCache = GetObjLstCache(strIdCurrEduCls);
IEnumerable <clsvConceptAttachmentEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convConceptAttachment.AttributeName)
{
if (objvConceptAttachmentCond.IsUpdated(strFldName) == false) continue;
if (objvConceptAttachmentCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvConceptAttachmentCond[strFldName].ToString());
}
else
{
if (objvConceptAttachmentCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvConceptAttachmentCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvConceptAttachmentCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvConceptAttachmentCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvConceptAttachmentCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvConceptAttachmentCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvConceptAttachmentCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvConceptAttachmentCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvConceptAttachmentCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvConceptAttachmentCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvConceptAttachmentCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvConceptAttachmentCond[strFldName]));
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
public static List<clsvConceptAttachmentEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsvConceptAttachmentEN> arrObjLst = new List<clsvConceptAttachmentEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvConceptAttachmentEN objvConceptAttachmentEN = new clsvConceptAttachmentEN();
try
{
objvConceptAttachmentEN.ConceptName = objRow[convConceptAttachment.ConceptName] == DBNull.Value ? null : objRow[convConceptAttachment.ConceptName].ToString().Trim(); //概念名称
objvConceptAttachmentEN.ConceptAttachmentId = Int32.Parse(objRow[convConceptAttachment.ConceptAttachmentId].ToString().Trim()); //概念附件Id
objvConceptAttachmentEN.ConceptContent = objRow[convConceptAttachment.ConceptContent] == DBNull.Value ? null : objRow[convConceptAttachment.ConceptContent].ToString().Trim(); //概念内容
objvConceptAttachmentEN.ConceptAttachmentName = objRow[convConceptAttachment.ConceptAttachmentName] == DBNull.Value ? null : objRow[convConceptAttachment.ConceptAttachmentName].ToString().Trim(); //附件名称
objvConceptAttachmentEN.ConceptId = objRow[convConceptAttachment.ConceptId] == DBNull.Value ? null : objRow[convConceptAttachment.ConceptId].ToString().Trim(); //概念Id
objvConceptAttachmentEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[convConceptAttachment.IsSubmit].ToString().Trim()); //是否提交
objvConceptAttachmentEN.FilePath = objRow[convConceptAttachment.FilePath].ToString().Trim(); //文件路径
objvConceptAttachmentEN.UpdDate = objRow[convConceptAttachment.UpdDate] == DBNull.Value ? null : objRow[convConceptAttachment.UpdDate].ToString().Trim(); //修改日期
objvConceptAttachmentEN.Memo = objRow[convConceptAttachment.Memo] == DBNull.Value ? null : objRow[convConceptAttachment.Memo].ToString().Trim(); //备注
objvConceptAttachmentEN.IdCurrEduCls = objRow[convConceptAttachment.IdCurrEduCls] == DBNull.Value ? null : objRow[convConceptAttachment.IdCurrEduCls].ToString().Trim(); //教学班流水号
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvConceptAttachmentEN.ConceptAttachmentId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvConceptAttachmentEN);
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
public static List<clsvConceptAttachmentEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsvConceptAttachmentEN> arrObjLst = new List<clsvConceptAttachmentEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvConceptAttachmentEN objvConceptAttachmentEN = new clsvConceptAttachmentEN();
try
{
objvConceptAttachmentEN.ConceptName = objRow[convConceptAttachment.ConceptName] == DBNull.Value ? null : objRow[convConceptAttachment.ConceptName].ToString().Trim(); //概念名称
objvConceptAttachmentEN.ConceptAttachmentId = Int32.Parse(objRow[convConceptAttachment.ConceptAttachmentId].ToString().Trim()); //概念附件Id
objvConceptAttachmentEN.ConceptContent = objRow[convConceptAttachment.ConceptContent] == DBNull.Value ? null : objRow[convConceptAttachment.ConceptContent].ToString().Trim(); //概念内容
objvConceptAttachmentEN.ConceptAttachmentName = objRow[convConceptAttachment.ConceptAttachmentName] == DBNull.Value ? null : objRow[convConceptAttachment.ConceptAttachmentName].ToString().Trim(); //附件名称
objvConceptAttachmentEN.ConceptId = objRow[convConceptAttachment.ConceptId] == DBNull.Value ? null : objRow[convConceptAttachment.ConceptId].ToString().Trim(); //概念Id
objvConceptAttachmentEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[convConceptAttachment.IsSubmit].ToString().Trim()); //是否提交
objvConceptAttachmentEN.FilePath = objRow[convConceptAttachment.FilePath].ToString().Trim(); //文件路径
objvConceptAttachmentEN.UpdDate = objRow[convConceptAttachment.UpdDate] == DBNull.Value ? null : objRow[convConceptAttachment.UpdDate].ToString().Trim(); //修改日期
objvConceptAttachmentEN.Memo = objRow[convConceptAttachment.Memo] == DBNull.Value ? null : objRow[convConceptAttachment.Memo].ToString().Trim(); //备注
objvConceptAttachmentEN.IdCurrEduCls = objRow[convConceptAttachment.IdCurrEduCls] == DBNull.Value ? null : objRow[convConceptAttachment.IdCurrEduCls].ToString().Trim(); //教学班流水号
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvConceptAttachmentEN.ConceptAttachmentId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvConceptAttachmentEN);
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
List<clsvConceptAttachmentEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsvConceptAttachmentEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsvConceptAttachmentEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsvConceptAttachmentEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsvConceptAttachmentEN> arrObjLst = new List<clsvConceptAttachmentEN>(); 
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
	clsvConceptAttachmentEN objvConceptAttachmentEN = new clsvConceptAttachmentEN();
try
{
objvConceptAttachmentEN.ConceptName = objRow[convConceptAttachment.ConceptName] == DBNull.Value ? null : objRow[convConceptAttachment.ConceptName].ToString().Trim(); //概念名称
objvConceptAttachmentEN.ConceptAttachmentId = Int32.Parse(objRow[convConceptAttachment.ConceptAttachmentId].ToString().Trim()); //概念附件Id
objvConceptAttachmentEN.ConceptContent = objRow[convConceptAttachment.ConceptContent] == DBNull.Value ? null : objRow[convConceptAttachment.ConceptContent].ToString().Trim(); //概念内容
objvConceptAttachmentEN.ConceptAttachmentName = objRow[convConceptAttachment.ConceptAttachmentName] == DBNull.Value ? null : objRow[convConceptAttachment.ConceptAttachmentName].ToString().Trim(); //附件名称
objvConceptAttachmentEN.ConceptId = objRow[convConceptAttachment.ConceptId] == DBNull.Value ? null : objRow[convConceptAttachment.ConceptId].ToString().Trim(); //概念Id
objvConceptAttachmentEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[convConceptAttachment.IsSubmit].ToString().Trim()); //是否提交
objvConceptAttachmentEN.FilePath = objRow[convConceptAttachment.FilePath].ToString().Trim(); //文件路径
objvConceptAttachmentEN.UpdDate = objRow[convConceptAttachment.UpdDate] == DBNull.Value ? null : objRow[convConceptAttachment.UpdDate].ToString().Trim(); //修改日期
objvConceptAttachmentEN.Memo = objRow[convConceptAttachment.Memo] == DBNull.Value ? null : objRow[convConceptAttachment.Memo].ToString().Trim(); //备注
objvConceptAttachmentEN.IdCurrEduCls = objRow[convConceptAttachment.IdCurrEduCls] == DBNull.Value ? null : objRow[convConceptAttachment.IdCurrEduCls].ToString().Trim(); //教学班流水号
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvConceptAttachmentEN.ConceptAttachmentId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvConceptAttachmentEN);
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
public static List<clsvConceptAttachmentEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsvConceptAttachmentEN> arrObjLst = new List<clsvConceptAttachmentEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvConceptAttachmentEN objvConceptAttachmentEN = new clsvConceptAttachmentEN();
try
{
objvConceptAttachmentEN.ConceptName = objRow[convConceptAttachment.ConceptName] == DBNull.Value ? null : objRow[convConceptAttachment.ConceptName].ToString().Trim(); //概念名称
objvConceptAttachmentEN.ConceptAttachmentId = Int32.Parse(objRow[convConceptAttachment.ConceptAttachmentId].ToString().Trim()); //概念附件Id
objvConceptAttachmentEN.ConceptContent = objRow[convConceptAttachment.ConceptContent] == DBNull.Value ? null : objRow[convConceptAttachment.ConceptContent].ToString().Trim(); //概念内容
objvConceptAttachmentEN.ConceptAttachmentName = objRow[convConceptAttachment.ConceptAttachmentName] == DBNull.Value ? null : objRow[convConceptAttachment.ConceptAttachmentName].ToString().Trim(); //附件名称
objvConceptAttachmentEN.ConceptId = objRow[convConceptAttachment.ConceptId] == DBNull.Value ? null : objRow[convConceptAttachment.ConceptId].ToString().Trim(); //概念Id
objvConceptAttachmentEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[convConceptAttachment.IsSubmit].ToString().Trim()); //是否提交
objvConceptAttachmentEN.FilePath = objRow[convConceptAttachment.FilePath].ToString().Trim(); //文件路径
objvConceptAttachmentEN.UpdDate = objRow[convConceptAttachment.UpdDate] == DBNull.Value ? null : objRow[convConceptAttachment.UpdDate].ToString().Trim(); //修改日期
objvConceptAttachmentEN.Memo = objRow[convConceptAttachment.Memo] == DBNull.Value ? null : objRow[convConceptAttachment.Memo].ToString().Trim(); //备注
objvConceptAttachmentEN.IdCurrEduCls = objRow[convConceptAttachment.IdCurrEduCls] == DBNull.Value ? null : objRow[convConceptAttachment.IdCurrEduCls].ToString().Trim(); //教学班流水号
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvConceptAttachmentEN.ConceptAttachmentId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvConceptAttachmentEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsvConceptAttachmentEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsvConceptAttachmentEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsvConceptAttachmentEN> arrObjLst = new List<clsvConceptAttachmentEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvConceptAttachmentEN objvConceptAttachmentEN = new clsvConceptAttachmentEN();
try
{
objvConceptAttachmentEN.ConceptName = objRow[convConceptAttachment.ConceptName] == DBNull.Value ? null : objRow[convConceptAttachment.ConceptName].ToString().Trim(); //概念名称
objvConceptAttachmentEN.ConceptAttachmentId = Int32.Parse(objRow[convConceptAttachment.ConceptAttachmentId].ToString().Trim()); //概念附件Id
objvConceptAttachmentEN.ConceptContent = objRow[convConceptAttachment.ConceptContent] == DBNull.Value ? null : objRow[convConceptAttachment.ConceptContent].ToString().Trim(); //概念内容
objvConceptAttachmentEN.ConceptAttachmentName = objRow[convConceptAttachment.ConceptAttachmentName] == DBNull.Value ? null : objRow[convConceptAttachment.ConceptAttachmentName].ToString().Trim(); //附件名称
objvConceptAttachmentEN.ConceptId = objRow[convConceptAttachment.ConceptId] == DBNull.Value ? null : objRow[convConceptAttachment.ConceptId].ToString().Trim(); //概念Id
objvConceptAttachmentEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[convConceptAttachment.IsSubmit].ToString().Trim()); //是否提交
objvConceptAttachmentEN.FilePath = objRow[convConceptAttachment.FilePath].ToString().Trim(); //文件路径
objvConceptAttachmentEN.UpdDate = objRow[convConceptAttachment.UpdDate] == DBNull.Value ? null : objRow[convConceptAttachment.UpdDate].ToString().Trim(); //修改日期
objvConceptAttachmentEN.Memo = objRow[convConceptAttachment.Memo] == DBNull.Value ? null : objRow[convConceptAttachment.Memo].ToString().Trim(); //备注
objvConceptAttachmentEN.IdCurrEduCls = objRow[convConceptAttachment.IdCurrEduCls] == DBNull.Value ? null : objRow[convConceptAttachment.IdCurrEduCls].ToString().Trim(); //教学班流水号
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvConceptAttachmentEN.ConceptAttachmentId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvConceptAttachmentEN);
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
public static List<clsvConceptAttachmentEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsvConceptAttachmentEN> arrObjLst = new List<clsvConceptAttachmentEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvConceptAttachmentEN objvConceptAttachmentEN = new clsvConceptAttachmentEN();
try
{
objvConceptAttachmentEN.ConceptName = objRow[convConceptAttachment.ConceptName] == DBNull.Value ? null : objRow[convConceptAttachment.ConceptName].ToString().Trim(); //概念名称
objvConceptAttachmentEN.ConceptAttachmentId = Int32.Parse(objRow[convConceptAttachment.ConceptAttachmentId].ToString().Trim()); //概念附件Id
objvConceptAttachmentEN.ConceptContent = objRow[convConceptAttachment.ConceptContent] == DBNull.Value ? null : objRow[convConceptAttachment.ConceptContent].ToString().Trim(); //概念内容
objvConceptAttachmentEN.ConceptAttachmentName = objRow[convConceptAttachment.ConceptAttachmentName] == DBNull.Value ? null : objRow[convConceptAttachment.ConceptAttachmentName].ToString().Trim(); //附件名称
objvConceptAttachmentEN.ConceptId = objRow[convConceptAttachment.ConceptId] == DBNull.Value ? null : objRow[convConceptAttachment.ConceptId].ToString().Trim(); //概念Id
objvConceptAttachmentEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[convConceptAttachment.IsSubmit].ToString().Trim()); //是否提交
objvConceptAttachmentEN.FilePath = objRow[convConceptAttachment.FilePath].ToString().Trim(); //文件路径
objvConceptAttachmentEN.UpdDate = objRow[convConceptAttachment.UpdDate] == DBNull.Value ? null : objRow[convConceptAttachment.UpdDate].ToString().Trim(); //修改日期
objvConceptAttachmentEN.Memo = objRow[convConceptAttachment.Memo] == DBNull.Value ? null : objRow[convConceptAttachment.Memo].ToString().Trim(); //备注
objvConceptAttachmentEN.IdCurrEduCls = objRow[convConceptAttachment.IdCurrEduCls] == DBNull.Value ? null : objRow[convConceptAttachment.IdCurrEduCls].ToString().Trim(); //教学班流水号
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvConceptAttachmentEN.ConceptAttachmentId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvConceptAttachmentEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsvConceptAttachmentEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsvConceptAttachmentEN> arrObjLst = new List<clsvConceptAttachmentEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvConceptAttachmentEN objvConceptAttachmentEN = new clsvConceptAttachmentEN();
try
{
objvConceptAttachmentEN.ConceptName = objRow[convConceptAttachment.ConceptName] == DBNull.Value ? null : objRow[convConceptAttachment.ConceptName].ToString().Trim(); //概念名称
objvConceptAttachmentEN.ConceptAttachmentId = Int32.Parse(objRow[convConceptAttachment.ConceptAttachmentId].ToString().Trim()); //概念附件Id
objvConceptAttachmentEN.ConceptContent = objRow[convConceptAttachment.ConceptContent] == DBNull.Value ? null : objRow[convConceptAttachment.ConceptContent].ToString().Trim(); //概念内容
objvConceptAttachmentEN.ConceptAttachmentName = objRow[convConceptAttachment.ConceptAttachmentName] == DBNull.Value ? null : objRow[convConceptAttachment.ConceptAttachmentName].ToString().Trim(); //附件名称
objvConceptAttachmentEN.ConceptId = objRow[convConceptAttachment.ConceptId] == DBNull.Value ? null : objRow[convConceptAttachment.ConceptId].ToString().Trim(); //概念Id
objvConceptAttachmentEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[convConceptAttachment.IsSubmit].ToString().Trim()); //是否提交
objvConceptAttachmentEN.FilePath = objRow[convConceptAttachment.FilePath].ToString().Trim(); //文件路径
objvConceptAttachmentEN.UpdDate = objRow[convConceptAttachment.UpdDate] == DBNull.Value ? null : objRow[convConceptAttachment.UpdDate].ToString().Trim(); //修改日期
objvConceptAttachmentEN.Memo = objRow[convConceptAttachment.Memo] == DBNull.Value ? null : objRow[convConceptAttachment.Memo].ToString().Trim(); //备注
objvConceptAttachmentEN.IdCurrEduCls = objRow[convConceptAttachment.IdCurrEduCls] == DBNull.Value ? null : objRow[convConceptAttachment.IdCurrEduCls].ToString().Trim(); //教学班流水号
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvConceptAttachmentEN.ConceptAttachmentId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvConceptAttachmentEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objvConceptAttachmentEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetvConceptAttachment(ref clsvConceptAttachmentEN objvConceptAttachmentEN)
{
bool bolResult = vConceptAttachmentDA.GetvConceptAttachment(ref objvConceptAttachmentEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "lngConceptAttachmentId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvConceptAttachmentEN GetObjByConceptAttachmentId(long lngConceptAttachmentId)
{
clsvConceptAttachmentEN objvConceptAttachmentEN = vConceptAttachmentDA.GetObjByConceptAttachmentId(lngConceptAttachmentId);
return objvConceptAttachmentEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsvConceptAttachmentEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsvConceptAttachmentEN objvConceptAttachmentEN = vConceptAttachmentDA.GetFirstObj(strWhereCond);
 return objvConceptAttachmentEN;
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
public static clsvConceptAttachmentEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsvConceptAttachmentEN objvConceptAttachmentEN = vConceptAttachmentDA.GetObjByDataRow(objRow);
 return objvConceptAttachmentEN;
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
public static clsvConceptAttachmentEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsvConceptAttachmentEN objvConceptAttachmentEN = vConceptAttachmentDA.GetObjByDataRow(objRow);
 return objvConceptAttachmentEN;
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
 /// <param name = "lngConceptAttachmentId">所给的关键字</param>
 /// <param name = "lstvConceptAttachmentObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvConceptAttachmentEN GetObjByConceptAttachmentIdFromList(long lngConceptAttachmentId, List<clsvConceptAttachmentEN> lstvConceptAttachmentObjLst)
{
foreach (clsvConceptAttachmentEN objvConceptAttachmentEN in lstvConceptAttachmentObjLst)
{
if (objvConceptAttachmentEN.ConceptAttachmentId == lngConceptAttachmentId)
{
return objvConceptAttachmentEN;
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
 long lngConceptAttachmentId;
 try
 {
 lngConceptAttachmentId = new clsvConceptAttachmentDA().GetFirstID(strWhereCond);
 return lngConceptAttachmentId;
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
 arrList = vConceptAttachmentDA.GetID(strWhereCond);
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
bool bolIsExist = vConceptAttachmentDA.IsExistCondRec(strWhereCond);
return bolIsExist;
}

 /// <summary>
 /// 判断当前表中是否存在给定关键字值的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExist)
 /// </summary>
 /// <param name = "lngConceptAttachmentId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public static bool IsExist(long lngConceptAttachmentId)
{
//检测记录是否存在
bool bolIsExist = vConceptAttachmentDA.IsExist(lngConceptAttachmentId);
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
 bolIsExist = clsvConceptAttachmentDA.IsExistTable();
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
 bolIsExist = vConceptAttachmentDA.IsExistTable(strTabName);
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
 /// <param name = "objvConceptAttachmentENS">源对象</param>
 /// <param name = "objvConceptAttachmentENT">目标对象</param>
 public static void CopyTo(clsvConceptAttachmentEN objvConceptAttachmentENS, clsvConceptAttachmentEN objvConceptAttachmentENT)
{
try
{
objvConceptAttachmentENT.ConceptName = objvConceptAttachmentENS.ConceptName; //概念名称
objvConceptAttachmentENT.ConceptAttachmentId = objvConceptAttachmentENS.ConceptAttachmentId; //概念附件Id
objvConceptAttachmentENT.ConceptContent = objvConceptAttachmentENS.ConceptContent; //概念内容
objvConceptAttachmentENT.ConceptAttachmentName = objvConceptAttachmentENS.ConceptAttachmentName; //附件名称
objvConceptAttachmentENT.ConceptId = objvConceptAttachmentENS.ConceptId; //概念Id
objvConceptAttachmentENT.IsSubmit = objvConceptAttachmentENS.IsSubmit; //是否提交
objvConceptAttachmentENT.FilePath = objvConceptAttachmentENS.FilePath; //文件路径
objvConceptAttachmentENT.UpdDate = objvConceptAttachmentENS.UpdDate; //修改日期
objvConceptAttachmentENT.Memo = objvConceptAttachmentENS.Memo; //备注
objvConceptAttachmentENT.IdCurrEduCls = objvConceptAttachmentENS.IdCurrEduCls; //教学班流水号
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
 /// <param name = "objvConceptAttachmentEN">源简化对象</param>
 public static void SetUpdFlag(clsvConceptAttachmentEN objvConceptAttachmentEN)
{
try
{
objvConceptAttachmentEN.ClearUpdateState();
   string strsfUpdFldSetStr = objvConceptAttachmentEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(convConceptAttachment.ConceptName, new clsStrCompareIgnoreCase())  ==  true)
{
objvConceptAttachmentEN.ConceptName = objvConceptAttachmentEN.ConceptName == "[null]" ? null :  objvConceptAttachmentEN.ConceptName; //概念名称
}
if (arrFldSet.Contains(convConceptAttachment.ConceptAttachmentId, new clsStrCompareIgnoreCase())  ==  true)
{
objvConceptAttachmentEN.ConceptAttachmentId = objvConceptAttachmentEN.ConceptAttachmentId; //概念附件Id
}
if (arrFldSet.Contains(convConceptAttachment.ConceptContent, new clsStrCompareIgnoreCase())  ==  true)
{
objvConceptAttachmentEN.ConceptContent = objvConceptAttachmentEN.ConceptContent == "[null]" ? null :  objvConceptAttachmentEN.ConceptContent; //概念内容
}
if (arrFldSet.Contains(convConceptAttachment.ConceptAttachmentName, new clsStrCompareIgnoreCase())  ==  true)
{
objvConceptAttachmentEN.ConceptAttachmentName = objvConceptAttachmentEN.ConceptAttachmentName == "[null]" ? null :  objvConceptAttachmentEN.ConceptAttachmentName; //附件名称
}
if (arrFldSet.Contains(convConceptAttachment.ConceptId, new clsStrCompareIgnoreCase())  ==  true)
{
objvConceptAttachmentEN.ConceptId = objvConceptAttachmentEN.ConceptId == "[null]" ? null :  objvConceptAttachmentEN.ConceptId; //概念Id
}
if (arrFldSet.Contains(convConceptAttachment.IsSubmit, new clsStrCompareIgnoreCase())  ==  true)
{
objvConceptAttachmentEN.IsSubmit = objvConceptAttachmentEN.IsSubmit; //是否提交
}
if (arrFldSet.Contains(convConceptAttachment.FilePath, new clsStrCompareIgnoreCase())  ==  true)
{
objvConceptAttachmentEN.FilePath = objvConceptAttachmentEN.FilePath; //文件路径
}
if (arrFldSet.Contains(convConceptAttachment.UpdDate, new clsStrCompareIgnoreCase())  ==  true)
{
objvConceptAttachmentEN.UpdDate = objvConceptAttachmentEN.UpdDate == "[null]" ? null :  objvConceptAttachmentEN.UpdDate; //修改日期
}
if (arrFldSet.Contains(convConceptAttachment.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objvConceptAttachmentEN.Memo = objvConceptAttachmentEN.Memo == "[null]" ? null :  objvConceptAttachmentEN.Memo; //备注
}
if (arrFldSet.Contains(convConceptAttachment.IdCurrEduCls, new clsStrCompareIgnoreCase())  ==  true)
{
objvConceptAttachmentEN.IdCurrEduCls = objvConceptAttachmentEN.IdCurrEduCls == "[null]" ? null :  objvConceptAttachmentEN.IdCurrEduCls; //教学班流水号
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
 /// <param name = "objvConceptAttachmentEN">源简化对象</param>
 public static void AccessFldValueNull(clsvConceptAttachmentEN objvConceptAttachmentEN)
{
try
{
if (objvConceptAttachmentEN.ConceptName == "[null]") objvConceptAttachmentEN.ConceptName = null; //概念名称
if (objvConceptAttachmentEN.ConceptContent == "[null]") objvConceptAttachmentEN.ConceptContent = null; //概念内容
if (objvConceptAttachmentEN.ConceptAttachmentName == "[null]") objvConceptAttachmentEN.ConceptAttachmentName = null; //附件名称
if (objvConceptAttachmentEN.ConceptId == "[null]") objvConceptAttachmentEN.ConceptId = null; //概念Id
if (objvConceptAttachmentEN.UpdDate == "[null]") objvConceptAttachmentEN.UpdDate = null; //修改日期
if (objvConceptAttachmentEN.Memo == "[null]") objvConceptAttachmentEN.Memo = null; //备注
if (objvConceptAttachmentEN.IdCurrEduCls == "[null]") objvConceptAttachmentEN.IdCurrEduCls = null; //教学班流水号
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
public static void CheckProperty4Condition(clsvConceptAttachmentEN objvConceptAttachmentEN)
{
 vConceptAttachmentDA.CheckProperty4Condition(objvConceptAttachmentEN);
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
if (clsConceptBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsConceptBL没有刷新缓存机制(clsConceptBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsConceptAttachmentBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsConceptAttachmentBL没有刷新缓存机制(clsConceptAttachmentBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by ConceptAttachmentId");
//if (arrvConceptAttachmentObjLstCache == null)
//{
//arrvConceptAttachmentObjLstCache = vConceptAttachmentDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "lngConceptAttachmentId">所给的关键字</param>
 /// <param name = "strIdCurrEduCls">缓存的分类字段</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvConceptAttachmentEN GetObjByConceptAttachmentIdCache(long lngConceptAttachmentId, string strIdCurrEduCls)
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
string strKey = string.Format("{0}_{1}", clsvConceptAttachmentEN._CurrTabName, strIdCurrEduCls);
List<clsvConceptAttachmentEN> arrvConceptAttachmentObjLstCache = GetObjLstCache(strIdCurrEduCls);
IEnumerable <clsvConceptAttachmentEN> arrvConceptAttachmentObjLst_Sel =
arrvConceptAttachmentObjLstCache
.Where(x=> x.ConceptAttachmentId == lngConceptAttachmentId 
);
if (arrvConceptAttachmentObjLst_Sel.Count() == 0)
{
   clsvConceptAttachmentEN obj = clsvConceptAttachmentBL.GetObjByConceptAttachmentId(lngConceptAttachmentId);
   if (obj != null)
 {
if (obj.IdCurrEduCls == strIdCurrEduCls)
{
CacheHelper.Remove(strKey);
     return obj;
}
else
{
string strMsg = string.Format("错误: 关键字:{0}不属于分类:{1},请检查!(In {2})", lngConceptAttachmentId, strIdCurrEduCls, clsStackTrace.GetCurrClassFunction());
clsSysParaEN.objLog.WriteDebugLog(strMsg);
throw new Exception(strMsg);
}
 }
return null;
}
return arrvConceptAttachmentObjLst_Sel.First();
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvConceptAttachmentEN> GetAllvConceptAttachmentObjLstCache(string strIdCurrEduCls)
{
//获取缓存中的对象列表
List<clsvConceptAttachmentEN> arrvConceptAttachmentObjLstCache = GetObjLstCache(strIdCurrEduCls); 
return arrvConceptAttachmentObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvConceptAttachmentEN> GetObjLstCache(string strIdCurrEduCls)
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
string strKey = string.Format("{0}_{1}", clsvConceptAttachmentEN._CurrTabName, strIdCurrEduCls);
string strCondition = string.Format("IdCurrEduCls='{0}'", strIdCurrEduCls);
List<clsvConceptAttachmentEN> arrvConceptAttachmentObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst(strCondition); });
return arrvConceptAttachmentObjLstCache;
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
string strKey = string.Format("{0}_{1}", clsvConceptAttachmentEN._CurrTabName, strIdCurrEduCls);
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
 /// 获取检查唯一性条件串(Uniqueness)--vConceptAttachment(vConceptAttachment)
 /// 唯一性条件:ConceptAttachmentId_ConceptId
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetUniquenessConditionString)
 /// </summary>
 /// <param name = "objvConceptAttachmentEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(clsvConceptAttachmentEN objvConceptAttachmentEN)
{
//检测记录是否存在
string strResult = vConceptAttachmentDA.GetUniCondStr(objvConceptAttachmentEN);
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
 /// <param name = "strIdCurrEduCls">缓存的分类字段</param>
 /// <returns>返回一个输出字段值</returns>
public static string Func(string strInFldName, string strOutFldName, long lngConceptAttachmentId, string strIdCurrEduCls)
{
if (strInFldName != convConceptAttachment.ConceptAttachmentId)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (convConceptAttachment.AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", convConceptAttachment.AttributeName));
throw new Exception(strMsg);
}
var objvConceptAttachment = clsvConceptAttachmentBL.GetObjByConceptAttachmentIdCache(lngConceptAttachmentId, strIdCurrEduCls);
if (objvConceptAttachment == null) return "";
return objvConceptAttachment[strOutFldName].ToString();
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
int intRecCount = clsvConceptAttachmentDA.GetRecCount(strTabName);
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
int intRecCount = clsvConceptAttachmentDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsvConceptAttachmentDA.GetRecCount();
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
int intRecCount = clsvConceptAttachmentDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objvConceptAttachmentCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsvConceptAttachmentEN objvConceptAttachmentCond)
{
 string strIdCurrEduCls = objvConceptAttachmentCond.IdCurrEduCls;
 if (string.IsNullOrEmpty(strIdCurrEduCls) == true)
{
string strMsg = string.Format("(errid:Busi000174)在表中,缓存分类字段值不能为空!(clsvConceptAttachmentBL:GetRecCountByCondCache)");
throw new Exception(strMsg);
}
List<clsvConceptAttachmentEN> arrObjLstCache = GetObjLstCache(strIdCurrEduCls);
IEnumerable <clsvConceptAttachmentEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convConceptAttachment.AttributeName)
{
if (objvConceptAttachmentCond.IsUpdated(strFldName) == false) continue;
if (objvConceptAttachmentCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvConceptAttachmentCond[strFldName].ToString());
}
else
{
if (objvConceptAttachmentCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvConceptAttachmentCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvConceptAttachmentCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvConceptAttachmentCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvConceptAttachmentCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvConceptAttachmentCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvConceptAttachmentCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvConceptAttachmentCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvConceptAttachmentCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvConceptAttachmentCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvConceptAttachmentCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvConceptAttachmentCond[strFldName]));
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
 List<string> arrList = clsvConceptAttachmentDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = vConceptAttachmentDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = vConceptAttachmentDA.GetFldValueNoDistinct(strFldName, strWhereCond);
return arrList;
}



 #endregion 表操作常用函数
}
}