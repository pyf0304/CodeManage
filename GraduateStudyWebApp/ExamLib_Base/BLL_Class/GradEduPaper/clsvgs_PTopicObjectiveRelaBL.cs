
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvgs_PTopicObjectiveRelaBL
 表名:vgs_PTopicObjectiveRela(01120667)
 * 版本:2023.08.23.1(服务器:WIN-SRV103-116)
 日期:2023/08/24 12:59:21
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:公共后台所有表(变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:研培论文(GradEduPaper)
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
public static class  clsvgs_PTopicObjectiveRelaBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvgs_PTopicObjectiveRelaEN GetObj(this K_mId_vgs_PTopicObjectiveRela myKey)
{
clsvgs_PTopicObjectiveRelaEN objvgs_PTopicObjectiveRelaEN = clsvgs_PTopicObjectiveRelaBL.vgs_PTopicObjectiveRelaDA.GetObjBymId(myKey.Value);
return objvgs_PTopicObjectiveRelaEN;
}

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvgs_PTopicObjectiveRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvgs_PTopicObjectiveRelaEN SetmId(this clsvgs_PTopicObjectiveRelaEN objvgs_PTopicObjectiveRelaEN, long lngmId, string strComparisonOp="")
	{
objvgs_PTopicObjectiveRelaEN.mId = lngmId; //mId
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvgs_PTopicObjectiveRelaEN.dicFldComparisonOp.ContainsKey(convgs_PTopicObjectiveRela.mId) == false)
{
objvgs_PTopicObjectiveRelaEN.dicFldComparisonOp.Add(convgs_PTopicObjectiveRela.mId, strComparisonOp);
}
else
{
objvgs_PTopicObjectiveRelaEN.dicFldComparisonOp[convgs_PTopicObjectiveRela.mId] = strComparisonOp;
}
}
return objvgs_PTopicObjectiveRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvgs_PTopicObjectiveRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvgs_PTopicObjectiveRelaEN SetPaperId(this clsvgs_PTopicObjectiveRelaEN objvgs_PTopicObjectiveRelaEN, string strPaperId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strPaperId, convgs_PTopicObjectiveRela.PaperId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPaperId, 8, convgs_PTopicObjectiveRela.PaperId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strPaperId, 8, convgs_PTopicObjectiveRela.PaperId);
}
objvgs_PTopicObjectiveRelaEN.PaperId = strPaperId; //论文Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvgs_PTopicObjectiveRelaEN.dicFldComparisonOp.ContainsKey(convgs_PTopicObjectiveRela.PaperId) == false)
{
objvgs_PTopicObjectiveRelaEN.dicFldComparisonOp.Add(convgs_PTopicObjectiveRela.PaperId, strComparisonOp);
}
else
{
objvgs_PTopicObjectiveRelaEN.dicFldComparisonOp[convgs_PTopicObjectiveRela.PaperId] = strComparisonOp;
}
}
return objvgs_PTopicObjectiveRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvgs_PTopicObjectiveRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvgs_PTopicObjectiveRelaEN SetPaperTitle(this clsvgs_PTopicObjectiveRelaEN objvgs_PTopicObjectiveRelaEN, string strPaperTitle, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPaperTitle, 500, convgs_PTopicObjectiveRela.PaperTitle);
}
objvgs_PTopicObjectiveRelaEN.PaperTitle = strPaperTitle; //论文标题
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvgs_PTopicObjectiveRelaEN.dicFldComparisonOp.ContainsKey(convgs_PTopicObjectiveRela.PaperTitle) == false)
{
objvgs_PTopicObjectiveRelaEN.dicFldComparisonOp.Add(convgs_PTopicObjectiveRela.PaperTitle, strComparisonOp);
}
else
{
objvgs_PTopicObjectiveRelaEN.dicFldComparisonOp[convgs_PTopicObjectiveRela.PaperTitle] = strComparisonOp;
}
}
return objvgs_PTopicObjectiveRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvgs_PTopicObjectiveRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvgs_PTopicObjectiveRelaEN SetPaperTypeId(this clsvgs_PTopicObjectiveRelaEN objvgs_PTopicObjectiveRelaEN, string strPaperTypeId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPaperTypeId, 2, convgs_PTopicObjectiveRela.PaperTypeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strPaperTypeId, 2, convgs_PTopicObjectiveRela.PaperTypeId);
}
objvgs_PTopicObjectiveRelaEN.PaperTypeId = strPaperTypeId; //论文类型Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvgs_PTopicObjectiveRelaEN.dicFldComparisonOp.ContainsKey(convgs_PTopicObjectiveRela.PaperTypeId) == false)
{
objvgs_PTopicObjectiveRelaEN.dicFldComparisonOp.Add(convgs_PTopicObjectiveRela.PaperTypeId, strComparisonOp);
}
else
{
objvgs_PTopicObjectiveRelaEN.dicFldComparisonOp[convgs_PTopicObjectiveRela.PaperTypeId] = strComparisonOp;
}
}
return objvgs_PTopicObjectiveRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvgs_PTopicObjectiveRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvgs_PTopicObjectiveRelaEN SetSectionId(this clsvgs_PTopicObjectiveRelaEN objvgs_PTopicObjectiveRelaEN, string strSectionId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strSectionId, 8, convgs_PTopicObjectiveRela.SectionId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strSectionId, 8, convgs_PTopicObjectiveRela.SectionId);
}
objvgs_PTopicObjectiveRelaEN.SectionId = strSectionId; //节Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvgs_PTopicObjectiveRelaEN.dicFldComparisonOp.ContainsKey(convgs_PTopicObjectiveRela.SectionId) == false)
{
objvgs_PTopicObjectiveRelaEN.dicFldComparisonOp.Add(convgs_PTopicObjectiveRela.SectionId, strComparisonOp);
}
else
{
objvgs_PTopicObjectiveRelaEN.dicFldComparisonOp[convgs_PTopicObjectiveRela.SectionId] = strComparisonOp;
}
}
return objvgs_PTopicObjectiveRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvgs_PTopicObjectiveRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvgs_PTopicObjectiveRelaEN SetSectionName(this clsvgs_PTopicObjectiveRelaEN objvgs_PTopicObjectiveRelaEN, string strSectionName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strSectionName, 100, convgs_PTopicObjectiveRela.SectionName);
}
objvgs_PTopicObjectiveRelaEN.SectionName = strSectionName; //节名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvgs_PTopicObjectiveRelaEN.dicFldComparisonOp.ContainsKey(convgs_PTopicObjectiveRela.SectionName) == false)
{
objvgs_PTopicObjectiveRelaEN.dicFldComparisonOp.Add(convgs_PTopicObjectiveRela.SectionName, strComparisonOp);
}
else
{
objvgs_PTopicObjectiveRelaEN.dicFldComparisonOp[convgs_PTopicObjectiveRela.SectionName] = strComparisonOp;
}
}
return objvgs_PTopicObjectiveRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvgs_PTopicObjectiveRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvgs_PTopicObjectiveRelaEN SetTopicObjectiveId(this clsvgs_PTopicObjectiveRelaEN objvgs_PTopicObjectiveRelaEN, string strTopicObjectiveId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strTopicObjectiveId, convgs_PTopicObjectiveRela.TopicObjectiveId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTopicObjectiveId, 8, convgs_PTopicObjectiveRela.TopicObjectiveId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strTopicObjectiveId, 8, convgs_PTopicObjectiveRela.TopicObjectiveId);
}
objvgs_PTopicObjectiveRelaEN.TopicObjectiveId = strTopicObjectiveId; //客观Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvgs_PTopicObjectiveRelaEN.dicFldComparisonOp.ContainsKey(convgs_PTopicObjectiveRela.TopicObjectiveId) == false)
{
objvgs_PTopicObjectiveRelaEN.dicFldComparisonOp.Add(convgs_PTopicObjectiveRela.TopicObjectiveId, strComparisonOp);
}
else
{
objvgs_PTopicObjectiveRelaEN.dicFldComparisonOp[convgs_PTopicObjectiveRela.TopicObjectiveId] = strComparisonOp;
}
}
return objvgs_PTopicObjectiveRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvgs_PTopicObjectiveRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvgs_PTopicObjectiveRelaEN SetObjectiveName(this clsvgs_PTopicObjectiveRelaEN objvgs_PTopicObjectiveRelaEN, string strObjectiveName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strObjectiveName, 500, convgs_PTopicObjectiveRela.ObjectiveName);
}
objvgs_PTopicObjectiveRelaEN.ObjectiveName = strObjectiveName; //客观名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvgs_PTopicObjectiveRelaEN.dicFldComparisonOp.ContainsKey(convgs_PTopicObjectiveRela.ObjectiveName) == false)
{
objvgs_PTopicObjectiveRelaEN.dicFldComparisonOp.Add(convgs_PTopicObjectiveRela.ObjectiveName, strComparisonOp);
}
else
{
objvgs_PTopicObjectiveRelaEN.dicFldComparisonOp[convgs_PTopicObjectiveRela.ObjectiveName] = strComparisonOp;
}
}
return objvgs_PTopicObjectiveRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvgs_PTopicObjectiveRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvgs_PTopicObjectiveRelaEN SetObjectiveContent(this clsvgs_PTopicObjectiveRelaEN objvgs_PTopicObjectiveRelaEN, string strObjectiveContent, string strComparisonOp="")
	{
objvgs_PTopicObjectiveRelaEN.ObjectiveContent = strObjectiveContent; //客观内容
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvgs_PTopicObjectiveRelaEN.dicFldComparisonOp.ContainsKey(convgs_PTopicObjectiveRela.ObjectiveContent) == false)
{
objvgs_PTopicObjectiveRelaEN.dicFldComparisonOp.Add(convgs_PTopicObjectiveRela.ObjectiveContent, strComparisonOp);
}
else
{
objvgs_PTopicObjectiveRelaEN.dicFldComparisonOp[convgs_PTopicObjectiveRela.ObjectiveContent] = strComparisonOp;
}
}
return objvgs_PTopicObjectiveRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvgs_PTopicObjectiveRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvgs_PTopicObjectiveRelaEN SetObjectiveType(this clsvgs_PTopicObjectiveRelaEN objvgs_PTopicObjectiveRelaEN, string strObjectiveType, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strObjectiveType, 2, convgs_PTopicObjectiveRela.ObjectiveType);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strObjectiveType, 2, convgs_PTopicObjectiveRela.ObjectiveType);
}
objvgs_PTopicObjectiveRelaEN.ObjectiveType = strObjectiveType; //客观类型
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvgs_PTopicObjectiveRelaEN.dicFldComparisonOp.ContainsKey(convgs_PTopicObjectiveRela.ObjectiveType) == false)
{
objvgs_PTopicObjectiveRelaEN.dicFldComparisonOp.Add(convgs_PTopicObjectiveRela.ObjectiveType, strComparisonOp);
}
else
{
objvgs_PTopicObjectiveRelaEN.dicFldComparisonOp[convgs_PTopicObjectiveRela.ObjectiveType] = strComparisonOp;
}
}
return objvgs_PTopicObjectiveRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvgs_PTopicObjectiveRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvgs_PTopicObjectiveRelaEN SetIsSubmit(this clsvgs_PTopicObjectiveRelaEN objvgs_PTopicObjectiveRelaEN, bool bolIsSubmit, string strComparisonOp="")
	{
objvgs_PTopicObjectiveRelaEN.IsSubmit = bolIsSubmit; //是否提交
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvgs_PTopicObjectiveRelaEN.dicFldComparisonOp.ContainsKey(convgs_PTopicObjectiveRela.IsSubmit) == false)
{
objvgs_PTopicObjectiveRelaEN.dicFldComparisonOp.Add(convgs_PTopicObjectiveRela.IsSubmit, strComparisonOp);
}
else
{
objvgs_PTopicObjectiveRelaEN.dicFldComparisonOp[convgs_PTopicObjectiveRela.IsSubmit] = strComparisonOp;
}
}
return objvgs_PTopicObjectiveRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvgs_PTopicObjectiveRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvgs_PTopicObjectiveRelaEN SetObjectiveTypeName(this clsvgs_PTopicObjectiveRelaEN objvgs_PTopicObjectiveRelaEN, string strObjectiveTypeName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strObjectiveTypeName, 8, convgs_PTopicObjectiveRela.ObjectiveTypeName);
}
objvgs_PTopicObjectiveRelaEN.ObjectiveTypeName = strObjectiveTypeName; //ObjectiveTypeName
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvgs_PTopicObjectiveRelaEN.dicFldComparisonOp.ContainsKey(convgs_PTopicObjectiveRela.ObjectiveTypeName) == false)
{
objvgs_PTopicObjectiveRelaEN.dicFldComparisonOp.Add(convgs_PTopicObjectiveRela.ObjectiveTypeName, strComparisonOp);
}
else
{
objvgs_PTopicObjectiveRelaEN.dicFldComparisonOp[convgs_PTopicObjectiveRela.ObjectiveTypeName] = strComparisonOp;
}
}
return objvgs_PTopicObjectiveRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvgs_PTopicObjectiveRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvgs_PTopicObjectiveRelaEN SetTeaScore(this clsvgs_PTopicObjectiveRelaEN objvgs_PTopicObjectiveRelaEN, float? fltTeaScore, string strComparisonOp="")
	{
objvgs_PTopicObjectiveRelaEN.TeaScore = fltTeaScore; //教师评分
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvgs_PTopicObjectiveRelaEN.dicFldComparisonOp.ContainsKey(convgs_PTopicObjectiveRela.TeaScore) == false)
{
objvgs_PTopicObjectiveRelaEN.dicFldComparisonOp.Add(convgs_PTopicObjectiveRela.TeaScore, strComparisonOp);
}
else
{
objvgs_PTopicObjectiveRelaEN.dicFldComparisonOp[convgs_PTopicObjectiveRela.TeaScore] = strComparisonOp;
}
}
return objvgs_PTopicObjectiveRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvgs_PTopicObjectiveRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvgs_PTopicObjectiveRelaEN SetStuScore(this clsvgs_PTopicObjectiveRelaEN objvgs_PTopicObjectiveRelaEN, float? fltStuScore, string strComparisonOp="")
	{
objvgs_PTopicObjectiveRelaEN.StuScore = fltStuScore; //学生平均分
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvgs_PTopicObjectiveRelaEN.dicFldComparisonOp.ContainsKey(convgs_PTopicObjectiveRela.StuScore) == false)
{
objvgs_PTopicObjectiveRelaEN.dicFldComparisonOp.Add(convgs_PTopicObjectiveRela.StuScore, strComparisonOp);
}
else
{
objvgs_PTopicObjectiveRelaEN.dicFldComparisonOp[convgs_PTopicObjectiveRela.StuScore] = strComparisonOp;
}
}
return objvgs_PTopicObjectiveRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvgs_PTopicObjectiveRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvgs_PTopicObjectiveRelaEN SetScore(this clsvgs_PTopicObjectiveRelaEN objvgs_PTopicObjectiveRelaEN, float? fltScore, string strComparisonOp="")
	{
objvgs_PTopicObjectiveRelaEN.Score = fltScore; //评分
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvgs_PTopicObjectiveRelaEN.dicFldComparisonOp.ContainsKey(convgs_PTopicObjectiveRela.Score) == false)
{
objvgs_PTopicObjectiveRelaEN.dicFldComparisonOp.Add(convgs_PTopicObjectiveRela.Score, strComparisonOp);
}
else
{
objvgs_PTopicObjectiveRelaEN.dicFldComparisonOp[convgs_PTopicObjectiveRela.Score] = strComparisonOp;
}
}
return objvgs_PTopicObjectiveRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvgs_PTopicObjectiveRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvgs_PTopicObjectiveRelaEN SetAppraiseCount(this clsvgs_PTopicObjectiveRelaEN objvgs_PTopicObjectiveRelaEN, int? intAppraiseCount, string strComparisonOp="")
	{
objvgs_PTopicObjectiveRelaEN.AppraiseCount = intAppraiseCount; //评论数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvgs_PTopicObjectiveRelaEN.dicFldComparisonOp.ContainsKey(convgs_PTopicObjectiveRela.AppraiseCount) == false)
{
objvgs_PTopicObjectiveRelaEN.dicFldComparisonOp.Add(convgs_PTopicObjectiveRela.AppraiseCount, strComparisonOp);
}
else
{
objvgs_PTopicObjectiveRelaEN.dicFldComparisonOp[convgs_PTopicObjectiveRela.AppraiseCount] = strComparisonOp;
}
}
return objvgs_PTopicObjectiveRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvgs_PTopicObjectiveRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvgs_PTopicObjectiveRelaEN SetOkCount(this clsvgs_PTopicObjectiveRelaEN objvgs_PTopicObjectiveRelaEN, int? intOkCount, string strComparisonOp="")
	{
objvgs_PTopicObjectiveRelaEN.OkCount = intOkCount; //点赞统计
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvgs_PTopicObjectiveRelaEN.dicFldComparisonOp.ContainsKey(convgs_PTopicObjectiveRela.OkCount) == false)
{
objvgs_PTopicObjectiveRelaEN.dicFldComparisonOp.Add(convgs_PTopicObjectiveRela.OkCount, strComparisonOp);
}
else
{
objvgs_PTopicObjectiveRelaEN.dicFldComparisonOp[convgs_PTopicObjectiveRela.OkCount] = strComparisonOp;
}
}
return objvgs_PTopicObjectiveRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvgs_PTopicObjectiveRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvgs_PTopicObjectiveRelaEN SetVersionCount(this clsvgs_PTopicObjectiveRelaEN objvgs_PTopicObjectiveRelaEN, int? intVersionCount, string strComparisonOp="")
	{
objvgs_PTopicObjectiveRelaEN.VersionCount = intVersionCount; //版本统计
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvgs_PTopicObjectiveRelaEN.dicFldComparisonOp.ContainsKey(convgs_PTopicObjectiveRela.VersionCount) == false)
{
objvgs_PTopicObjectiveRelaEN.dicFldComparisonOp.Add(convgs_PTopicObjectiveRela.VersionCount, strComparisonOp);
}
else
{
objvgs_PTopicObjectiveRelaEN.dicFldComparisonOp[convgs_PTopicObjectiveRela.VersionCount] = strComparisonOp;
}
}
return objvgs_PTopicObjectiveRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvgs_PTopicObjectiveRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvgs_PTopicObjectiveRelaEN SetCitationCount(this clsvgs_PTopicObjectiveRelaEN objvgs_PTopicObjectiveRelaEN, int? intCitationCount, string strComparisonOp="")
	{
objvgs_PTopicObjectiveRelaEN.CitationCount = intCitationCount; //引用统计
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvgs_PTopicObjectiveRelaEN.dicFldComparisonOp.ContainsKey(convgs_PTopicObjectiveRela.CitationCount) == false)
{
objvgs_PTopicObjectiveRelaEN.dicFldComparisonOp.Add(convgs_PTopicObjectiveRela.CitationCount, strComparisonOp);
}
else
{
objvgs_PTopicObjectiveRelaEN.dicFldComparisonOp[convgs_PTopicObjectiveRela.CitationCount] = strComparisonOp;
}
}
return objvgs_PTopicObjectiveRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvgs_PTopicObjectiveRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvgs_PTopicObjectiveRelaEN SetUpdDate(this clsvgs_PTopicObjectiveRelaEN objvgs_PTopicObjectiveRelaEN, string strUpdDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdDate, 20, convgs_PTopicObjectiveRela.UpdDate);
}
objvgs_PTopicObjectiveRelaEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvgs_PTopicObjectiveRelaEN.dicFldComparisonOp.ContainsKey(convgs_PTopicObjectiveRela.UpdDate) == false)
{
objvgs_PTopicObjectiveRelaEN.dicFldComparisonOp.Add(convgs_PTopicObjectiveRela.UpdDate, strComparisonOp);
}
else
{
objvgs_PTopicObjectiveRelaEN.dicFldComparisonOp[convgs_PTopicObjectiveRela.UpdDate] = strComparisonOp;
}
}
return objvgs_PTopicObjectiveRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvgs_PTopicObjectiveRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvgs_PTopicObjectiveRelaEN SetUpdUser(this clsvgs_PTopicObjectiveRelaEN objvgs_PTopicObjectiveRelaEN, string strUpdUser, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdUser, 20, convgs_PTopicObjectiveRela.UpdUser);
}
objvgs_PTopicObjectiveRelaEN.UpdUser = strUpdUser; //修改人
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvgs_PTopicObjectiveRelaEN.dicFldComparisonOp.ContainsKey(convgs_PTopicObjectiveRela.UpdUser) == false)
{
objvgs_PTopicObjectiveRelaEN.dicFldComparisonOp.Add(convgs_PTopicObjectiveRela.UpdUser, strComparisonOp);
}
else
{
objvgs_PTopicObjectiveRelaEN.dicFldComparisonOp[convgs_PTopicObjectiveRela.UpdUser] = strComparisonOp;
}
}
return objvgs_PTopicObjectiveRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvgs_PTopicObjectiveRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvgs_PTopicObjectiveRelaEN SetMemo(this clsvgs_PTopicObjectiveRelaEN objvgs_PTopicObjectiveRelaEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, convgs_PTopicObjectiveRela.Memo);
}
objvgs_PTopicObjectiveRelaEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvgs_PTopicObjectiveRelaEN.dicFldComparisonOp.ContainsKey(convgs_PTopicObjectiveRela.Memo) == false)
{
objvgs_PTopicObjectiveRelaEN.dicFldComparisonOp.Add(convgs_PTopicObjectiveRela.Memo, strComparisonOp);
}
else
{
objvgs_PTopicObjectiveRelaEN.dicFldComparisonOp[convgs_PTopicObjectiveRela.Memo] = strComparisonOp;
}
}
return objvgs_PTopicObjectiveRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvgs_PTopicObjectiveRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvgs_PTopicObjectiveRelaEN SetObjUserId(this clsvgs_PTopicObjectiveRelaEN objvgs_PTopicObjectiveRelaEN, string strObjUserId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strObjUserId, 50, convgs_PTopicObjectiveRela.ObjUserId);
}
objvgs_PTopicObjectiveRelaEN.ObjUserId = strObjUserId; //ObjUserId
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvgs_PTopicObjectiveRelaEN.dicFldComparisonOp.ContainsKey(convgs_PTopicObjectiveRela.ObjUserId) == false)
{
objvgs_PTopicObjectiveRelaEN.dicFldComparisonOp.Add(convgs_PTopicObjectiveRela.ObjUserId, strComparisonOp);
}
else
{
objvgs_PTopicObjectiveRelaEN.dicFldComparisonOp[convgs_PTopicObjectiveRela.ObjUserId] = strComparisonOp;
}
}
return objvgs_PTopicObjectiveRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvgs_PTopicObjectiveRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvgs_PTopicObjectiveRelaEN SetObjDate(this clsvgs_PTopicObjectiveRelaEN objvgs_PTopicObjectiveRelaEN, string strObjDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strObjDate, 20, convgs_PTopicObjectiveRela.ObjDate);
}
objvgs_PTopicObjectiveRelaEN.ObjDate = strObjDate; //ObjDate
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvgs_PTopicObjectiveRelaEN.dicFldComparisonOp.ContainsKey(convgs_PTopicObjectiveRela.ObjDate) == false)
{
objvgs_PTopicObjectiveRelaEN.dicFldComparisonOp.Add(convgs_PTopicObjectiveRela.ObjDate, strComparisonOp);
}
else
{
objvgs_PTopicObjectiveRelaEN.dicFldComparisonOp[convgs_PTopicObjectiveRela.ObjDate] = strComparisonOp;
}
}
return objvgs_PTopicObjectiveRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvgs_PTopicObjectiveRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvgs_PTopicObjectiveRelaEN SetConclusion(this clsvgs_PTopicObjectiveRelaEN objvgs_PTopicObjectiveRelaEN, string strConclusion, string strComparisonOp="")
	{
objvgs_PTopicObjectiveRelaEN.Conclusion = strConclusion; //结论
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvgs_PTopicObjectiveRelaEN.dicFldComparisonOp.ContainsKey(convgs_PTopicObjectiveRela.Conclusion) == false)
{
objvgs_PTopicObjectiveRelaEN.dicFldComparisonOp.Add(convgs_PTopicObjectiveRela.Conclusion, strComparisonOp);
}
else
{
objvgs_PTopicObjectiveRelaEN.dicFldComparisonOp[convgs_PTopicObjectiveRela.Conclusion] = strComparisonOp;
}
}
return objvgs_PTopicObjectiveRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvgs_PTopicObjectiveRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvgs_PTopicObjectiveRelaEN SetCreateDate(this clsvgs_PTopicObjectiveRelaEN objvgs_PTopicObjectiveRelaEN, string strCreateDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCreateDate, 20, convgs_PTopicObjectiveRela.CreateDate);
}
objvgs_PTopicObjectiveRelaEN.CreateDate = strCreateDate; //建立日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvgs_PTopicObjectiveRelaEN.dicFldComparisonOp.ContainsKey(convgs_PTopicObjectiveRela.CreateDate) == false)
{
objvgs_PTopicObjectiveRelaEN.dicFldComparisonOp.Add(convgs_PTopicObjectiveRela.CreateDate, strComparisonOp);
}
else
{
objvgs_PTopicObjectiveRelaEN.dicFldComparisonOp[convgs_PTopicObjectiveRela.CreateDate] = strComparisonOp;
}
}
return objvgs_PTopicObjectiveRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvgs_PTopicObjectiveRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvgs_PTopicObjectiveRelaEN SetShareId(this clsvgs_PTopicObjectiveRelaEN objvgs_PTopicObjectiveRelaEN, string strShareId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strShareId, 2, convgs_PTopicObjectiveRela.ShareId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strShareId, 2, convgs_PTopicObjectiveRela.ShareId);
}
objvgs_PTopicObjectiveRelaEN.ShareId = strShareId; //分享Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvgs_PTopicObjectiveRelaEN.dicFldComparisonOp.ContainsKey(convgs_PTopicObjectiveRela.ShareId) == false)
{
objvgs_PTopicObjectiveRelaEN.dicFldComparisonOp.Add(convgs_PTopicObjectiveRela.ShareId, strComparisonOp);
}
else
{
objvgs_PTopicObjectiveRelaEN.dicFldComparisonOp[convgs_PTopicObjectiveRela.ShareId] = strComparisonOp;
}
}
return objvgs_PTopicObjectiveRelaEN;
	}

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CopyObj)
 /// </summary>
 /// <param name = "objvgs_PTopicObjectiveRelaENS">源对象</param>
 /// <param name = "objvgs_PTopicObjectiveRelaENT">目标对象</param>
 public static void CopyTo(this clsvgs_PTopicObjectiveRelaEN objvgs_PTopicObjectiveRelaENS, clsvgs_PTopicObjectiveRelaEN objvgs_PTopicObjectiveRelaENT)
{
try
{
objvgs_PTopicObjectiveRelaENT.mId = objvgs_PTopicObjectiveRelaENS.mId; //mId
objvgs_PTopicObjectiveRelaENT.PaperId = objvgs_PTopicObjectiveRelaENS.PaperId; //论文Id
objvgs_PTopicObjectiveRelaENT.PaperTitle = objvgs_PTopicObjectiveRelaENS.PaperTitle; //论文标题
objvgs_PTopicObjectiveRelaENT.PaperTypeId = objvgs_PTopicObjectiveRelaENS.PaperTypeId; //论文类型Id
objvgs_PTopicObjectiveRelaENT.SectionId = objvgs_PTopicObjectiveRelaENS.SectionId; //节Id
objvgs_PTopicObjectiveRelaENT.SectionName = objvgs_PTopicObjectiveRelaENS.SectionName; //节名
objvgs_PTopicObjectiveRelaENT.TopicObjectiveId = objvgs_PTopicObjectiveRelaENS.TopicObjectiveId; //客观Id
objvgs_PTopicObjectiveRelaENT.ObjectiveName = objvgs_PTopicObjectiveRelaENS.ObjectiveName; //客观名称
objvgs_PTopicObjectiveRelaENT.ObjectiveContent = objvgs_PTopicObjectiveRelaENS.ObjectiveContent; //客观内容
objvgs_PTopicObjectiveRelaENT.ObjectiveType = objvgs_PTopicObjectiveRelaENS.ObjectiveType; //客观类型
objvgs_PTopicObjectiveRelaENT.IsSubmit = objvgs_PTopicObjectiveRelaENS.IsSubmit; //是否提交
objvgs_PTopicObjectiveRelaENT.ObjectiveTypeName = objvgs_PTopicObjectiveRelaENS.ObjectiveTypeName; //ObjectiveTypeName
objvgs_PTopicObjectiveRelaENT.TeaScore = objvgs_PTopicObjectiveRelaENS.TeaScore; //教师评分
objvgs_PTopicObjectiveRelaENT.StuScore = objvgs_PTopicObjectiveRelaENS.StuScore; //学生平均分
objvgs_PTopicObjectiveRelaENT.Score = objvgs_PTopicObjectiveRelaENS.Score; //评分
objvgs_PTopicObjectiveRelaENT.AppraiseCount = objvgs_PTopicObjectiveRelaENS.AppraiseCount; //评论数
objvgs_PTopicObjectiveRelaENT.OkCount = objvgs_PTopicObjectiveRelaENS.OkCount; //点赞统计
objvgs_PTopicObjectiveRelaENT.VersionCount = objvgs_PTopicObjectiveRelaENS.VersionCount; //版本统计
objvgs_PTopicObjectiveRelaENT.CitationCount = objvgs_PTopicObjectiveRelaENS.CitationCount; //引用统计
objvgs_PTopicObjectiveRelaENT.UpdDate = objvgs_PTopicObjectiveRelaENS.UpdDate; //修改日期
objvgs_PTopicObjectiveRelaENT.UpdUser = objvgs_PTopicObjectiveRelaENS.UpdUser; //修改人
objvgs_PTopicObjectiveRelaENT.Memo = objvgs_PTopicObjectiveRelaENS.Memo; //备注
objvgs_PTopicObjectiveRelaENT.ObjUserId = objvgs_PTopicObjectiveRelaENS.ObjUserId; //ObjUserId
objvgs_PTopicObjectiveRelaENT.ObjDate = objvgs_PTopicObjectiveRelaENS.ObjDate; //ObjDate
objvgs_PTopicObjectiveRelaENT.Conclusion = objvgs_PTopicObjectiveRelaENS.Conclusion; //结论
objvgs_PTopicObjectiveRelaENT.CreateDate = objvgs_PTopicObjectiveRelaENS.CreateDate; //建立日期
objvgs_PTopicObjectiveRelaENT.ShareId = objvgs_PTopicObjectiveRelaENS.ShareId; //分享Id
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
 /// <param name = "objvgs_PTopicObjectiveRelaENS">源对象</param>
 /// <returns>目标对象=>clsvgs_PTopicObjectiveRelaEN:objvgs_PTopicObjectiveRelaENT</returns>
 public static clsvgs_PTopicObjectiveRelaEN CopyTo(this clsvgs_PTopicObjectiveRelaEN objvgs_PTopicObjectiveRelaENS)
{
try
{
 clsvgs_PTopicObjectiveRelaEN objvgs_PTopicObjectiveRelaENT = new clsvgs_PTopicObjectiveRelaEN()
{
mId = objvgs_PTopicObjectiveRelaENS.mId, //mId
PaperId = objvgs_PTopicObjectiveRelaENS.PaperId, //论文Id
PaperTitle = objvgs_PTopicObjectiveRelaENS.PaperTitle, //论文标题
PaperTypeId = objvgs_PTopicObjectiveRelaENS.PaperTypeId, //论文类型Id
SectionId = objvgs_PTopicObjectiveRelaENS.SectionId, //节Id
SectionName = objvgs_PTopicObjectiveRelaENS.SectionName, //节名
TopicObjectiveId = objvgs_PTopicObjectiveRelaENS.TopicObjectiveId, //客观Id
ObjectiveName = objvgs_PTopicObjectiveRelaENS.ObjectiveName, //客观名称
ObjectiveContent = objvgs_PTopicObjectiveRelaENS.ObjectiveContent, //客观内容
ObjectiveType = objvgs_PTopicObjectiveRelaENS.ObjectiveType, //客观类型
IsSubmit = objvgs_PTopicObjectiveRelaENS.IsSubmit, //是否提交
ObjectiveTypeName = objvgs_PTopicObjectiveRelaENS.ObjectiveTypeName, //ObjectiveTypeName
TeaScore = objvgs_PTopicObjectiveRelaENS.TeaScore, //教师评分
StuScore = objvgs_PTopicObjectiveRelaENS.StuScore, //学生平均分
Score = objvgs_PTopicObjectiveRelaENS.Score, //评分
AppraiseCount = objvgs_PTopicObjectiveRelaENS.AppraiseCount, //评论数
OkCount = objvgs_PTopicObjectiveRelaENS.OkCount, //点赞统计
VersionCount = objvgs_PTopicObjectiveRelaENS.VersionCount, //版本统计
CitationCount = objvgs_PTopicObjectiveRelaENS.CitationCount, //引用统计
UpdDate = objvgs_PTopicObjectiveRelaENS.UpdDate, //修改日期
UpdUser = objvgs_PTopicObjectiveRelaENS.UpdUser, //修改人
Memo = objvgs_PTopicObjectiveRelaENS.Memo, //备注
ObjUserId = objvgs_PTopicObjectiveRelaENS.ObjUserId, //ObjUserId
ObjDate = objvgs_PTopicObjectiveRelaENS.ObjDate, //ObjDate
Conclusion = objvgs_PTopicObjectiveRelaENS.Conclusion, //结论
CreateDate = objvgs_PTopicObjectiveRelaENS.CreateDate, //建立日期
ShareId = objvgs_PTopicObjectiveRelaENS.ShareId, //分享Id
};
 return objvgs_PTopicObjectiveRelaENT;
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
public static void CheckProperty4Condition(this clsvgs_PTopicObjectiveRelaEN objvgs_PTopicObjectiveRelaEN)
{
 clsvgs_PTopicObjectiveRelaBL.vgs_PTopicObjectiveRelaDA.CheckProperty4Condition(objvgs_PTopicObjectiveRelaEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvgs_PTopicObjectiveRelaEN objvgs_PTopicObjectiveRelaCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvgs_PTopicObjectiveRelaCond.IsUpdated(convgs_PTopicObjectiveRela.mId) == true)
{
string strComparisonOpmId = objvgs_PTopicObjectiveRelaCond.dicFldComparisonOp[convgs_PTopicObjectiveRela.mId];
strWhereCond += string.Format(" And {0} {2} {1}", convgs_PTopicObjectiveRela.mId, objvgs_PTopicObjectiveRelaCond.mId, strComparisonOpmId);
}
if (objvgs_PTopicObjectiveRelaCond.IsUpdated(convgs_PTopicObjectiveRela.PaperId) == true)
{
string strComparisonOpPaperId = objvgs_PTopicObjectiveRelaCond.dicFldComparisonOp[convgs_PTopicObjectiveRela.PaperId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convgs_PTopicObjectiveRela.PaperId, objvgs_PTopicObjectiveRelaCond.PaperId, strComparisonOpPaperId);
}
if (objvgs_PTopicObjectiveRelaCond.IsUpdated(convgs_PTopicObjectiveRela.PaperTitle) == true)
{
string strComparisonOpPaperTitle = objvgs_PTopicObjectiveRelaCond.dicFldComparisonOp[convgs_PTopicObjectiveRela.PaperTitle];
strWhereCond += string.Format(" And {0} {2} '{1}'", convgs_PTopicObjectiveRela.PaperTitle, objvgs_PTopicObjectiveRelaCond.PaperTitle, strComparisonOpPaperTitle);
}
if (objvgs_PTopicObjectiveRelaCond.IsUpdated(convgs_PTopicObjectiveRela.PaperTypeId) == true)
{
string strComparisonOpPaperTypeId = objvgs_PTopicObjectiveRelaCond.dicFldComparisonOp[convgs_PTopicObjectiveRela.PaperTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convgs_PTopicObjectiveRela.PaperTypeId, objvgs_PTopicObjectiveRelaCond.PaperTypeId, strComparisonOpPaperTypeId);
}
if (objvgs_PTopicObjectiveRelaCond.IsUpdated(convgs_PTopicObjectiveRela.SectionId) == true)
{
string strComparisonOpSectionId = objvgs_PTopicObjectiveRelaCond.dicFldComparisonOp[convgs_PTopicObjectiveRela.SectionId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convgs_PTopicObjectiveRela.SectionId, objvgs_PTopicObjectiveRelaCond.SectionId, strComparisonOpSectionId);
}
if (objvgs_PTopicObjectiveRelaCond.IsUpdated(convgs_PTopicObjectiveRela.SectionName) == true)
{
string strComparisonOpSectionName = objvgs_PTopicObjectiveRelaCond.dicFldComparisonOp[convgs_PTopicObjectiveRela.SectionName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convgs_PTopicObjectiveRela.SectionName, objvgs_PTopicObjectiveRelaCond.SectionName, strComparisonOpSectionName);
}
if (objvgs_PTopicObjectiveRelaCond.IsUpdated(convgs_PTopicObjectiveRela.TopicObjectiveId) == true)
{
string strComparisonOpTopicObjectiveId = objvgs_PTopicObjectiveRelaCond.dicFldComparisonOp[convgs_PTopicObjectiveRela.TopicObjectiveId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convgs_PTopicObjectiveRela.TopicObjectiveId, objvgs_PTopicObjectiveRelaCond.TopicObjectiveId, strComparisonOpTopicObjectiveId);
}
if (objvgs_PTopicObjectiveRelaCond.IsUpdated(convgs_PTopicObjectiveRela.ObjectiveName) == true)
{
string strComparisonOpObjectiveName = objvgs_PTopicObjectiveRelaCond.dicFldComparisonOp[convgs_PTopicObjectiveRela.ObjectiveName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convgs_PTopicObjectiveRela.ObjectiveName, objvgs_PTopicObjectiveRelaCond.ObjectiveName, strComparisonOpObjectiveName);
}
//数据类型string(text)在函数:[AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj]中没有处理!
if (objvgs_PTopicObjectiveRelaCond.IsUpdated(convgs_PTopicObjectiveRela.ObjectiveType) == true)
{
string strComparisonOpObjectiveType = objvgs_PTopicObjectiveRelaCond.dicFldComparisonOp[convgs_PTopicObjectiveRela.ObjectiveType];
strWhereCond += string.Format(" And {0} {2} '{1}'", convgs_PTopicObjectiveRela.ObjectiveType, objvgs_PTopicObjectiveRelaCond.ObjectiveType, strComparisonOpObjectiveType);
}
if (objvgs_PTopicObjectiveRelaCond.IsUpdated(convgs_PTopicObjectiveRela.IsSubmit) == true)
{
if (objvgs_PTopicObjectiveRelaCond.IsSubmit == true)
{
strWhereCond += string.Format(" And {0} = '1'", convgs_PTopicObjectiveRela.IsSubmit);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convgs_PTopicObjectiveRela.IsSubmit);
}
}
if (objvgs_PTopicObjectiveRelaCond.IsUpdated(convgs_PTopicObjectiveRela.ObjectiveTypeName) == true)
{
string strComparisonOpObjectiveTypeName = objvgs_PTopicObjectiveRelaCond.dicFldComparisonOp[convgs_PTopicObjectiveRela.ObjectiveTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convgs_PTopicObjectiveRela.ObjectiveTypeName, objvgs_PTopicObjectiveRelaCond.ObjectiveTypeName, strComparisonOpObjectiveTypeName);
}
if (objvgs_PTopicObjectiveRelaCond.IsUpdated(convgs_PTopicObjectiveRela.TeaScore) == true)
{
string strComparisonOpTeaScore = objvgs_PTopicObjectiveRelaCond.dicFldComparisonOp[convgs_PTopicObjectiveRela.TeaScore];
strWhereCond += string.Format(" And {0} {2} {1}", convgs_PTopicObjectiveRela.TeaScore, objvgs_PTopicObjectiveRelaCond.TeaScore, strComparisonOpTeaScore);
}
if (objvgs_PTopicObjectiveRelaCond.IsUpdated(convgs_PTopicObjectiveRela.StuScore) == true)
{
string strComparisonOpStuScore = objvgs_PTopicObjectiveRelaCond.dicFldComparisonOp[convgs_PTopicObjectiveRela.StuScore];
strWhereCond += string.Format(" And {0} {2} {1}", convgs_PTopicObjectiveRela.StuScore, objvgs_PTopicObjectiveRelaCond.StuScore, strComparisonOpStuScore);
}
if (objvgs_PTopicObjectiveRelaCond.IsUpdated(convgs_PTopicObjectiveRela.Score) == true)
{
string strComparisonOpScore = objvgs_PTopicObjectiveRelaCond.dicFldComparisonOp[convgs_PTopicObjectiveRela.Score];
strWhereCond += string.Format(" And {0} {2} {1}", convgs_PTopicObjectiveRela.Score, objvgs_PTopicObjectiveRelaCond.Score, strComparisonOpScore);
}
if (objvgs_PTopicObjectiveRelaCond.IsUpdated(convgs_PTopicObjectiveRela.AppraiseCount) == true)
{
string strComparisonOpAppraiseCount = objvgs_PTopicObjectiveRelaCond.dicFldComparisonOp[convgs_PTopicObjectiveRela.AppraiseCount];
strWhereCond += string.Format(" And {0} {2} {1}", convgs_PTopicObjectiveRela.AppraiseCount, objvgs_PTopicObjectiveRelaCond.AppraiseCount, strComparisonOpAppraiseCount);
}
if (objvgs_PTopicObjectiveRelaCond.IsUpdated(convgs_PTopicObjectiveRela.OkCount) == true)
{
string strComparisonOpOkCount = objvgs_PTopicObjectiveRelaCond.dicFldComparisonOp[convgs_PTopicObjectiveRela.OkCount];
strWhereCond += string.Format(" And {0} {2} {1}", convgs_PTopicObjectiveRela.OkCount, objvgs_PTopicObjectiveRelaCond.OkCount, strComparisonOpOkCount);
}
if (objvgs_PTopicObjectiveRelaCond.IsUpdated(convgs_PTopicObjectiveRela.VersionCount) == true)
{
string strComparisonOpVersionCount = objvgs_PTopicObjectiveRelaCond.dicFldComparisonOp[convgs_PTopicObjectiveRela.VersionCount];
strWhereCond += string.Format(" And {0} {2} {1}", convgs_PTopicObjectiveRela.VersionCount, objvgs_PTopicObjectiveRelaCond.VersionCount, strComparisonOpVersionCount);
}
if (objvgs_PTopicObjectiveRelaCond.IsUpdated(convgs_PTopicObjectiveRela.CitationCount) == true)
{
string strComparisonOpCitationCount = objvgs_PTopicObjectiveRelaCond.dicFldComparisonOp[convgs_PTopicObjectiveRela.CitationCount];
strWhereCond += string.Format(" And {0} {2} {1}", convgs_PTopicObjectiveRela.CitationCount, objvgs_PTopicObjectiveRelaCond.CitationCount, strComparisonOpCitationCount);
}
if (objvgs_PTopicObjectiveRelaCond.IsUpdated(convgs_PTopicObjectiveRela.UpdDate) == true)
{
string strComparisonOpUpdDate = objvgs_PTopicObjectiveRelaCond.dicFldComparisonOp[convgs_PTopicObjectiveRela.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convgs_PTopicObjectiveRela.UpdDate, objvgs_PTopicObjectiveRelaCond.UpdDate, strComparisonOpUpdDate);
}
if (objvgs_PTopicObjectiveRelaCond.IsUpdated(convgs_PTopicObjectiveRela.UpdUser) == true)
{
string strComparisonOpUpdUser = objvgs_PTopicObjectiveRelaCond.dicFldComparisonOp[convgs_PTopicObjectiveRela.UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", convgs_PTopicObjectiveRela.UpdUser, objvgs_PTopicObjectiveRelaCond.UpdUser, strComparisonOpUpdUser);
}
if (objvgs_PTopicObjectiveRelaCond.IsUpdated(convgs_PTopicObjectiveRela.Memo) == true)
{
string strComparisonOpMemo = objvgs_PTopicObjectiveRelaCond.dicFldComparisonOp[convgs_PTopicObjectiveRela.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convgs_PTopicObjectiveRela.Memo, objvgs_PTopicObjectiveRelaCond.Memo, strComparisonOpMemo);
}
if (objvgs_PTopicObjectiveRelaCond.IsUpdated(convgs_PTopicObjectiveRela.ObjUserId) == true)
{
string strComparisonOpObjUserId = objvgs_PTopicObjectiveRelaCond.dicFldComparisonOp[convgs_PTopicObjectiveRela.ObjUserId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convgs_PTopicObjectiveRela.ObjUserId, objvgs_PTopicObjectiveRelaCond.ObjUserId, strComparisonOpObjUserId);
}
if (objvgs_PTopicObjectiveRelaCond.IsUpdated(convgs_PTopicObjectiveRela.ObjDate) == true)
{
string strComparisonOpObjDate = objvgs_PTopicObjectiveRelaCond.dicFldComparisonOp[convgs_PTopicObjectiveRela.ObjDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convgs_PTopicObjectiveRela.ObjDate, objvgs_PTopicObjectiveRelaCond.ObjDate, strComparisonOpObjDate);
}
//数据类型string(text)在函数:[AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj]中没有处理!
if (objvgs_PTopicObjectiveRelaCond.IsUpdated(convgs_PTopicObjectiveRela.CreateDate) == true)
{
string strComparisonOpCreateDate = objvgs_PTopicObjectiveRelaCond.dicFldComparisonOp[convgs_PTopicObjectiveRela.CreateDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convgs_PTopicObjectiveRela.CreateDate, objvgs_PTopicObjectiveRelaCond.CreateDate, strComparisonOpCreateDate);
}
if (objvgs_PTopicObjectiveRelaCond.IsUpdated(convgs_PTopicObjectiveRela.ShareId) == true)
{
string strComparisonOpShareId = objvgs_PTopicObjectiveRelaCond.dicFldComparisonOp[convgs_PTopicObjectiveRela.ShareId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convgs_PTopicObjectiveRela.ShareId, objvgs_PTopicObjectiveRelaCond.ShareId, strComparisonOpShareId);
}
 return strWhereCond;
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_vgs_PTopicObjectiveRela
{
public virtual bool UpdRelaTabDate(long lngmId, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// 论文客观关系视图(vgs_PTopicObjectiveRela)
 /// 数据源类型:视图
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsvgs_PTopicObjectiveRelaBL
{
public static RelatedActions_vgs_PTopicObjectiveRela relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsvgs_PTopicObjectiveRelaDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsvgs_PTopicObjectiveRelaDA vgs_PTopicObjectiveRelaDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsvgs_PTopicObjectiveRelaDA();
}
return uniqueInstance;
}
}

 /// <summary>
 /// 类的构造函数
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ClassConstructor1)
 /// </summary>
 public clsvgs_PTopicObjectiveRelaBL()
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
if (string.IsNullOrEmpty(clsvgs_PTopicObjectiveRelaEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvgs_PTopicObjectiveRelaEN._ConnectString);
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
public static DataTable GetDataTable_vgs_PTopicObjectiveRela(string strWhereCond)
{
DataTable objDT;
try
{
objDT = vgs_PTopicObjectiveRelaDA.GetDataTable_vgs_PTopicObjectiveRela(strWhereCond);
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
objDT = vgs_PTopicObjectiveRelaDA.GetDataTable(strWhereCond);
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
objDT = vgs_PTopicObjectiveRelaDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = vgs_PTopicObjectiveRelaDA.GetDataTable(strWhereCond, strTabName);
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
objDT = vgs_PTopicObjectiveRelaDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = vgs_PTopicObjectiveRelaDA.GetDataTable_Top(objTopPara);
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
objDT = vgs_PTopicObjectiveRelaDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = vgs_PTopicObjectiveRelaDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = vgs_PTopicObjectiveRelaDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
public static List<clsvgs_PTopicObjectiveRelaEN> GetObjLstByMIdLst(List<long> arrMIdLst)
{
List<clsvgs_PTopicObjectiveRelaEN> arrObjLst = new List<clsvgs_PTopicObjectiveRelaEN>(); 
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
	clsvgs_PTopicObjectiveRelaEN objvgs_PTopicObjectiveRelaEN = new clsvgs_PTopicObjectiveRelaEN();
try
{
objvgs_PTopicObjectiveRelaEN.mId = Int32.Parse(objRow[convgs_PTopicObjectiveRela.mId].ToString().Trim()); //mId
objvgs_PTopicObjectiveRelaEN.PaperId = objRow[convgs_PTopicObjectiveRela.PaperId].ToString().Trim(); //论文Id
objvgs_PTopicObjectiveRelaEN.PaperTitle = objRow[convgs_PTopicObjectiveRela.PaperTitle] == DBNull.Value ? null : objRow[convgs_PTopicObjectiveRela.PaperTitle].ToString().Trim(); //论文标题
objvgs_PTopicObjectiveRelaEN.PaperTypeId = objRow[convgs_PTopicObjectiveRela.PaperTypeId] == DBNull.Value ? null : objRow[convgs_PTopicObjectiveRela.PaperTypeId].ToString().Trim(); //论文类型Id
objvgs_PTopicObjectiveRelaEN.SectionId = objRow[convgs_PTopicObjectiveRela.SectionId] == DBNull.Value ? null : objRow[convgs_PTopicObjectiveRela.SectionId].ToString().Trim(); //节Id
objvgs_PTopicObjectiveRelaEN.SectionName = objRow[convgs_PTopicObjectiveRela.SectionName] == DBNull.Value ? null : objRow[convgs_PTopicObjectiveRela.SectionName].ToString().Trim(); //节名
objvgs_PTopicObjectiveRelaEN.TopicObjectiveId = objRow[convgs_PTopicObjectiveRela.TopicObjectiveId].ToString().Trim(); //客观Id
objvgs_PTopicObjectiveRelaEN.ObjectiveName = objRow[convgs_PTopicObjectiveRela.ObjectiveName] == DBNull.Value ? null : objRow[convgs_PTopicObjectiveRela.ObjectiveName].ToString().Trim(); //客观名称
objvgs_PTopicObjectiveRelaEN.ObjectiveContent = objRow[convgs_PTopicObjectiveRela.ObjectiveContent] == DBNull.Value ? null : objRow[convgs_PTopicObjectiveRela.ObjectiveContent].ToString().Trim(); //客观内容
objvgs_PTopicObjectiveRelaEN.ObjectiveType = objRow[convgs_PTopicObjectiveRela.ObjectiveType] == DBNull.Value ? null : objRow[convgs_PTopicObjectiveRela.ObjectiveType].ToString().Trim(); //客观类型
objvgs_PTopicObjectiveRelaEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[convgs_PTopicObjectiveRela.IsSubmit].ToString().Trim()); //是否提交
objvgs_PTopicObjectiveRelaEN.ObjectiveTypeName = objRow[convgs_PTopicObjectiveRela.ObjectiveTypeName] == DBNull.Value ? null : objRow[convgs_PTopicObjectiveRela.ObjectiveTypeName].ToString().Trim(); //ObjectiveTypeName
objvgs_PTopicObjectiveRelaEN.TeaScore = objRow[convgs_PTopicObjectiveRela.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convgs_PTopicObjectiveRela.TeaScore].ToString().Trim()); //教师评分
objvgs_PTopicObjectiveRelaEN.StuScore = objRow[convgs_PTopicObjectiveRela.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convgs_PTopicObjectiveRela.StuScore].ToString().Trim()); //学生平均分
objvgs_PTopicObjectiveRelaEN.Score = objRow[convgs_PTopicObjectiveRela.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convgs_PTopicObjectiveRela.Score].ToString().Trim()); //评分
objvgs_PTopicObjectiveRelaEN.AppraiseCount = objRow[convgs_PTopicObjectiveRela.AppraiseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convgs_PTopicObjectiveRela.AppraiseCount].ToString().Trim()); //评论数
objvgs_PTopicObjectiveRelaEN.OkCount = objRow[convgs_PTopicObjectiveRela.OkCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convgs_PTopicObjectiveRela.OkCount].ToString().Trim()); //点赞统计
objvgs_PTopicObjectiveRelaEN.VersionCount = objRow[convgs_PTopicObjectiveRela.VersionCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convgs_PTopicObjectiveRela.VersionCount].ToString().Trim()); //版本统计
objvgs_PTopicObjectiveRelaEN.CitationCount = objRow[convgs_PTopicObjectiveRela.CitationCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convgs_PTopicObjectiveRela.CitationCount].ToString().Trim()); //引用统计
objvgs_PTopicObjectiveRelaEN.UpdDate = objRow[convgs_PTopicObjectiveRela.UpdDate] == DBNull.Value ? null : objRow[convgs_PTopicObjectiveRela.UpdDate].ToString().Trim(); //修改日期
objvgs_PTopicObjectiveRelaEN.UpdUser = objRow[convgs_PTopicObjectiveRela.UpdUser] == DBNull.Value ? null : objRow[convgs_PTopicObjectiveRela.UpdUser].ToString().Trim(); //修改人
objvgs_PTopicObjectiveRelaEN.Memo = objRow[convgs_PTopicObjectiveRela.Memo] == DBNull.Value ? null : objRow[convgs_PTopicObjectiveRela.Memo].ToString().Trim(); //备注
objvgs_PTopicObjectiveRelaEN.ObjUserId = objRow[convgs_PTopicObjectiveRela.ObjUserId] == DBNull.Value ? null : objRow[convgs_PTopicObjectiveRela.ObjUserId].ToString().Trim(); //ObjUserId
objvgs_PTopicObjectiveRelaEN.ObjDate = objRow[convgs_PTopicObjectiveRela.ObjDate] == DBNull.Value ? null : objRow[convgs_PTopicObjectiveRela.ObjDate].ToString().Trim(); //ObjDate
objvgs_PTopicObjectiveRelaEN.Conclusion = objRow[convgs_PTopicObjectiveRela.Conclusion] == DBNull.Value ? null : objRow[convgs_PTopicObjectiveRela.Conclusion].ToString().Trim(); //结论
objvgs_PTopicObjectiveRelaEN.CreateDate = objRow[convgs_PTopicObjectiveRela.CreateDate] == DBNull.Value ? null : objRow[convgs_PTopicObjectiveRela.CreateDate].ToString().Trim(); //建立日期
objvgs_PTopicObjectiveRelaEN.ShareId = objRow[convgs_PTopicObjectiveRela.ShareId] == DBNull.Value ? null : objRow[convgs_PTopicObjectiveRela.ShareId].ToString().Trim(); //分享Id
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvgs_PTopicObjectiveRelaEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvgs_PTopicObjectiveRelaEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrMIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsvgs_PTopicObjectiveRelaEN> GetObjLstByMIdLstCache(List<long> arrMIdLst)
{
string strKey = string.Format("{0}", clsvgs_PTopicObjectiveRelaEN._CurrTabName);
List<clsvgs_PTopicObjectiveRelaEN> arrvgs_PTopicObjectiveRelaObjLstCache = GetObjLstCache();
IEnumerable <clsvgs_PTopicObjectiveRelaEN> arrvgs_PTopicObjectiveRelaObjLst_Sel =
arrvgs_PTopicObjectiveRelaObjLstCache
.Where(x => arrMIdLst.Contains(x.mId));
return arrvgs_PTopicObjectiveRelaObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvgs_PTopicObjectiveRelaEN> GetObjLst(string strWhereCond)
{
List<clsvgs_PTopicObjectiveRelaEN> arrObjLst = new List<clsvgs_PTopicObjectiveRelaEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvgs_PTopicObjectiveRelaEN objvgs_PTopicObjectiveRelaEN = new clsvgs_PTopicObjectiveRelaEN();
try
{
objvgs_PTopicObjectiveRelaEN.mId = Int32.Parse(objRow[convgs_PTopicObjectiveRela.mId].ToString().Trim()); //mId
objvgs_PTopicObjectiveRelaEN.PaperId = objRow[convgs_PTopicObjectiveRela.PaperId].ToString().Trim(); //论文Id
objvgs_PTopicObjectiveRelaEN.PaperTitle = objRow[convgs_PTopicObjectiveRela.PaperTitle] == DBNull.Value ? null : objRow[convgs_PTopicObjectiveRela.PaperTitle].ToString().Trim(); //论文标题
objvgs_PTopicObjectiveRelaEN.PaperTypeId = objRow[convgs_PTopicObjectiveRela.PaperTypeId] == DBNull.Value ? null : objRow[convgs_PTopicObjectiveRela.PaperTypeId].ToString().Trim(); //论文类型Id
objvgs_PTopicObjectiveRelaEN.SectionId = objRow[convgs_PTopicObjectiveRela.SectionId] == DBNull.Value ? null : objRow[convgs_PTopicObjectiveRela.SectionId].ToString().Trim(); //节Id
objvgs_PTopicObjectiveRelaEN.SectionName = objRow[convgs_PTopicObjectiveRela.SectionName] == DBNull.Value ? null : objRow[convgs_PTopicObjectiveRela.SectionName].ToString().Trim(); //节名
objvgs_PTopicObjectiveRelaEN.TopicObjectiveId = objRow[convgs_PTopicObjectiveRela.TopicObjectiveId].ToString().Trim(); //客观Id
objvgs_PTopicObjectiveRelaEN.ObjectiveName = objRow[convgs_PTopicObjectiveRela.ObjectiveName] == DBNull.Value ? null : objRow[convgs_PTopicObjectiveRela.ObjectiveName].ToString().Trim(); //客观名称
objvgs_PTopicObjectiveRelaEN.ObjectiveContent = objRow[convgs_PTopicObjectiveRela.ObjectiveContent] == DBNull.Value ? null : objRow[convgs_PTopicObjectiveRela.ObjectiveContent].ToString().Trim(); //客观内容
objvgs_PTopicObjectiveRelaEN.ObjectiveType = objRow[convgs_PTopicObjectiveRela.ObjectiveType] == DBNull.Value ? null : objRow[convgs_PTopicObjectiveRela.ObjectiveType].ToString().Trim(); //客观类型
objvgs_PTopicObjectiveRelaEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[convgs_PTopicObjectiveRela.IsSubmit].ToString().Trim()); //是否提交
objvgs_PTopicObjectiveRelaEN.ObjectiveTypeName = objRow[convgs_PTopicObjectiveRela.ObjectiveTypeName] == DBNull.Value ? null : objRow[convgs_PTopicObjectiveRela.ObjectiveTypeName].ToString().Trim(); //ObjectiveTypeName
objvgs_PTopicObjectiveRelaEN.TeaScore = objRow[convgs_PTopicObjectiveRela.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convgs_PTopicObjectiveRela.TeaScore].ToString().Trim()); //教师评分
objvgs_PTopicObjectiveRelaEN.StuScore = objRow[convgs_PTopicObjectiveRela.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convgs_PTopicObjectiveRela.StuScore].ToString().Trim()); //学生平均分
objvgs_PTopicObjectiveRelaEN.Score = objRow[convgs_PTopicObjectiveRela.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convgs_PTopicObjectiveRela.Score].ToString().Trim()); //评分
objvgs_PTopicObjectiveRelaEN.AppraiseCount = objRow[convgs_PTopicObjectiveRela.AppraiseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convgs_PTopicObjectiveRela.AppraiseCount].ToString().Trim()); //评论数
objvgs_PTopicObjectiveRelaEN.OkCount = objRow[convgs_PTopicObjectiveRela.OkCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convgs_PTopicObjectiveRela.OkCount].ToString().Trim()); //点赞统计
objvgs_PTopicObjectiveRelaEN.VersionCount = objRow[convgs_PTopicObjectiveRela.VersionCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convgs_PTopicObjectiveRela.VersionCount].ToString().Trim()); //版本统计
objvgs_PTopicObjectiveRelaEN.CitationCount = objRow[convgs_PTopicObjectiveRela.CitationCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convgs_PTopicObjectiveRela.CitationCount].ToString().Trim()); //引用统计
objvgs_PTopicObjectiveRelaEN.UpdDate = objRow[convgs_PTopicObjectiveRela.UpdDate] == DBNull.Value ? null : objRow[convgs_PTopicObjectiveRela.UpdDate].ToString().Trim(); //修改日期
objvgs_PTopicObjectiveRelaEN.UpdUser = objRow[convgs_PTopicObjectiveRela.UpdUser] == DBNull.Value ? null : objRow[convgs_PTopicObjectiveRela.UpdUser].ToString().Trim(); //修改人
objvgs_PTopicObjectiveRelaEN.Memo = objRow[convgs_PTopicObjectiveRela.Memo] == DBNull.Value ? null : objRow[convgs_PTopicObjectiveRela.Memo].ToString().Trim(); //备注
objvgs_PTopicObjectiveRelaEN.ObjUserId = objRow[convgs_PTopicObjectiveRela.ObjUserId] == DBNull.Value ? null : objRow[convgs_PTopicObjectiveRela.ObjUserId].ToString().Trim(); //ObjUserId
objvgs_PTopicObjectiveRelaEN.ObjDate = objRow[convgs_PTopicObjectiveRela.ObjDate] == DBNull.Value ? null : objRow[convgs_PTopicObjectiveRela.ObjDate].ToString().Trim(); //ObjDate
objvgs_PTopicObjectiveRelaEN.Conclusion = objRow[convgs_PTopicObjectiveRela.Conclusion] == DBNull.Value ? null : objRow[convgs_PTopicObjectiveRela.Conclusion].ToString().Trim(); //结论
objvgs_PTopicObjectiveRelaEN.CreateDate = objRow[convgs_PTopicObjectiveRela.CreateDate] == DBNull.Value ? null : objRow[convgs_PTopicObjectiveRela.CreateDate].ToString().Trim(); //建立日期
objvgs_PTopicObjectiveRelaEN.ShareId = objRow[convgs_PTopicObjectiveRela.ShareId] == DBNull.Value ? null : objRow[convgs_PTopicObjectiveRela.ShareId].ToString().Trim(); //分享Id
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvgs_PTopicObjectiveRelaEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvgs_PTopicObjectiveRelaEN);
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
public static List<clsvgs_PTopicObjectiveRelaEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsvgs_PTopicObjectiveRelaEN> arrObjLst = new List<clsvgs_PTopicObjectiveRelaEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvgs_PTopicObjectiveRelaEN objvgs_PTopicObjectiveRelaEN = new clsvgs_PTopicObjectiveRelaEN();
try
{
objvgs_PTopicObjectiveRelaEN.mId = Int32.Parse(objRow[convgs_PTopicObjectiveRela.mId].ToString().Trim()); //mId
objvgs_PTopicObjectiveRelaEN.PaperId = objRow[convgs_PTopicObjectiveRela.PaperId].ToString().Trim(); //论文Id
objvgs_PTopicObjectiveRelaEN.PaperTitle = objRow[convgs_PTopicObjectiveRela.PaperTitle] == DBNull.Value ? null : objRow[convgs_PTopicObjectiveRela.PaperTitle].ToString().Trim(); //论文标题
objvgs_PTopicObjectiveRelaEN.PaperTypeId = objRow[convgs_PTopicObjectiveRela.PaperTypeId] == DBNull.Value ? null : objRow[convgs_PTopicObjectiveRela.PaperTypeId].ToString().Trim(); //论文类型Id
objvgs_PTopicObjectiveRelaEN.SectionId = objRow[convgs_PTopicObjectiveRela.SectionId] == DBNull.Value ? null : objRow[convgs_PTopicObjectiveRela.SectionId].ToString().Trim(); //节Id
objvgs_PTopicObjectiveRelaEN.SectionName = objRow[convgs_PTopicObjectiveRela.SectionName] == DBNull.Value ? null : objRow[convgs_PTopicObjectiveRela.SectionName].ToString().Trim(); //节名
objvgs_PTopicObjectiveRelaEN.TopicObjectiveId = objRow[convgs_PTopicObjectiveRela.TopicObjectiveId].ToString().Trim(); //客观Id
objvgs_PTopicObjectiveRelaEN.ObjectiveName = objRow[convgs_PTopicObjectiveRela.ObjectiveName] == DBNull.Value ? null : objRow[convgs_PTopicObjectiveRela.ObjectiveName].ToString().Trim(); //客观名称
objvgs_PTopicObjectiveRelaEN.ObjectiveContent = objRow[convgs_PTopicObjectiveRela.ObjectiveContent] == DBNull.Value ? null : objRow[convgs_PTopicObjectiveRela.ObjectiveContent].ToString().Trim(); //客观内容
objvgs_PTopicObjectiveRelaEN.ObjectiveType = objRow[convgs_PTopicObjectiveRela.ObjectiveType] == DBNull.Value ? null : objRow[convgs_PTopicObjectiveRela.ObjectiveType].ToString().Trim(); //客观类型
objvgs_PTopicObjectiveRelaEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[convgs_PTopicObjectiveRela.IsSubmit].ToString().Trim()); //是否提交
objvgs_PTopicObjectiveRelaEN.ObjectiveTypeName = objRow[convgs_PTopicObjectiveRela.ObjectiveTypeName] == DBNull.Value ? null : objRow[convgs_PTopicObjectiveRela.ObjectiveTypeName].ToString().Trim(); //ObjectiveTypeName
objvgs_PTopicObjectiveRelaEN.TeaScore = objRow[convgs_PTopicObjectiveRela.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convgs_PTopicObjectiveRela.TeaScore].ToString().Trim()); //教师评分
objvgs_PTopicObjectiveRelaEN.StuScore = objRow[convgs_PTopicObjectiveRela.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convgs_PTopicObjectiveRela.StuScore].ToString().Trim()); //学生平均分
objvgs_PTopicObjectiveRelaEN.Score = objRow[convgs_PTopicObjectiveRela.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convgs_PTopicObjectiveRela.Score].ToString().Trim()); //评分
objvgs_PTopicObjectiveRelaEN.AppraiseCount = objRow[convgs_PTopicObjectiveRela.AppraiseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convgs_PTopicObjectiveRela.AppraiseCount].ToString().Trim()); //评论数
objvgs_PTopicObjectiveRelaEN.OkCount = objRow[convgs_PTopicObjectiveRela.OkCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convgs_PTopicObjectiveRela.OkCount].ToString().Trim()); //点赞统计
objvgs_PTopicObjectiveRelaEN.VersionCount = objRow[convgs_PTopicObjectiveRela.VersionCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convgs_PTopicObjectiveRela.VersionCount].ToString().Trim()); //版本统计
objvgs_PTopicObjectiveRelaEN.CitationCount = objRow[convgs_PTopicObjectiveRela.CitationCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convgs_PTopicObjectiveRela.CitationCount].ToString().Trim()); //引用统计
objvgs_PTopicObjectiveRelaEN.UpdDate = objRow[convgs_PTopicObjectiveRela.UpdDate] == DBNull.Value ? null : objRow[convgs_PTopicObjectiveRela.UpdDate].ToString().Trim(); //修改日期
objvgs_PTopicObjectiveRelaEN.UpdUser = objRow[convgs_PTopicObjectiveRela.UpdUser] == DBNull.Value ? null : objRow[convgs_PTopicObjectiveRela.UpdUser].ToString().Trim(); //修改人
objvgs_PTopicObjectiveRelaEN.Memo = objRow[convgs_PTopicObjectiveRela.Memo] == DBNull.Value ? null : objRow[convgs_PTopicObjectiveRela.Memo].ToString().Trim(); //备注
objvgs_PTopicObjectiveRelaEN.ObjUserId = objRow[convgs_PTopicObjectiveRela.ObjUserId] == DBNull.Value ? null : objRow[convgs_PTopicObjectiveRela.ObjUserId].ToString().Trim(); //ObjUserId
objvgs_PTopicObjectiveRelaEN.ObjDate = objRow[convgs_PTopicObjectiveRela.ObjDate] == DBNull.Value ? null : objRow[convgs_PTopicObjectiveRela.ObjDate].ToString().Trim(); //ObjDate
objvgs_PTopicObjectiveRelaEN.Conclusion = objRow[convgs_PTopicObjectiveRela.Conclusion] == DBNull.Value ? null : objRow[convgs_PTopicObjectiveRela.Conclusion].ToString().Trim(); //结论
objvgs_PTopicObjectiveRelaEN.CreateDate = objRow[convgs_PTopicObjectiveRela.CreateDate] == DBNull.Value ? null : objRow[convgs_PTopicObjectiveRela.CreateDate].ToString().Trim(); //建立日期
objvgs_PTopicObjectiveRelaEN.ShareId = objRow[convgs_PTopicObjectiveRela.ShareId] == DBNull.Value ? null : objRow[convgs_PTopicObjectiveRela.ShareId].ToString().Trim(); //分享Id
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvgs_PTopicObjectiveRelaEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvgs_PTopicObjectiveRelaEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objvgs_PTopicObjectiveRelaCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsvgs_PTopicObjectiveRelaEN> GetSubObjLstCache(clsvgs_PTopicObjectiveRelaEN objvgs_PTopicObjectiveRelaCond)
{
List<clsvgs_PTopicObjectiveRelaEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsvgs_PTopicObjectiveRelaEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convgs_PTopicObjectiveRela.AttributeName)
{
if (objvgs_PTopicObjectiveRelaCond.IsUpdated(strFldName) == false) continue;
if (objvgs_PTopicObjectiveRelaCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvgs_PTopicObjectiveRelaCond[strFldName].ToString());
}
else
{
if (objvgs_PTopicObjectiveRelaCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvgs_PTopicObjectiveRelaCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvgs_PTopicObjectiveRelaCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvgs_PTopicObjectiveRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvgs_PTopicObjectiveRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvgs_PTopicObjectiveRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvgs_PTopicObjectiveRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvgs_PTopicObjectiveRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvgs_PTopicObjectiveRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvgs_PTopicObjectiveRelaCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvgs_PTopicObjectiveRelaCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvgs_PTopicObjectiveRelaCond[strFldName]));
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
public static List<clsvgs_PTopicObjectiveRelaEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsvgs_PTopicObjectiveRelaEN> arrObjLst = new List<clsvgs_PTopicObjectiveRelaEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvgs_PTopicObjectiveRelaEN objvgs_PTopicObjectiveRelaEN = new clsvgs_PTopicObjectiveRelaEN();
try
{
objvgs_PTopicObjectiveRelaEN.mId = Int32.Parse(objRow[convgs_PTopicObjectiveRela.mId].ToString().Trim()); //mId
objvgs_PTopicObjectiveRelaEN.PaperId = objRow[convgs_PTopicObjectiveRela.PaperId].ToString().Trim(); //论文Id
objvgs_PTopicObjectiveRelaEN.PaperTitle = objRow[convgs_PTopicObjectiveRela.PaperTitle] == DBNull.Value ? null : objRow[convgs_PTopicObjectiveRela.PaperTitle].ToString().Trim(); //论文标题
objvgs_PTopicObjectiveRelaEN.PaperTypeId = objRow[convgs_PTopicObjectiveRela.PaperTypeId] == DBNull.Value ? null : objRow[convgs_PTopicObjectiveRela.PaperTypeId].ToString().Trim(); //论文类型Id
objvgs_PTopicObjectiveRelaEN.SectionId = objRow[convgs_PTopicObjectiveRela.SectionId] == DBNull.Value ? null : objRow[convgs_PTopicObjectiveRela.SectionId].ToString().Trim(); //节Id
objvgs_PTopicObjectiveRelaEN.SectionName = objRow[convgs_PTopicObjectiveRela.SectionName] == DBNull.Value ? null : objRow[convgs_PTopicObjectiveRela.SectionName].ToString().Trim(); //节名
objvgs_PTopicObjectiveRelaEN.TopicObjectiveId = objRow[convgs_PTopicObjectiveRela.TopicObjectiveId].ToString().Trim(); //客观Id
objvgs_PTopicObjectiveRelaEN.ObjectiveName = objRow[convgs_PTopicObjectiveRela.ObjectiveName] == DBNull.Value ? null : objRow[convgs_PTopicObjectiveRela.ObjectiveName].ToString().Trim(); //客观名称
objvgs_PTopicObjectiveRelaEN.ObjectiveContent = objRow[convgs_PTopicObjectiveRela.ObjectiveContent] == DBNull.Value ? null : objRow[convgs_PTopicObjectiveRela.ObjectiveContent].ToString().Trim(); //客观内容
objvgs_PTopicObjectiveRelaEN.ObjectiveType = objRow[convgs_PTopicObjectiveRela.ObjectiveType] == DBNull.Value ? null : objRow[convgs_PTopicObjectiveRela.ObjectiveType].ToString().Trim(); //客观类型
objvgs_PTopicObjectiveRelaEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[convgs_PTopicObjectiveRela.IsSubmit].ToString().Trim()); //是否提交
objvgs_PTopicObjectiveRelaEN.ObjectiveTypeName = objRow[convgs_PTopicObjectiveRela.ObjectiveTypeName] == DBNull.Value ? null : objRow[convgs_PTopicObjectiveRela.ObjectiveTypeName].ToString().Trim(); //ObjectiveTypeName
objvgs_PTopicObjectiveRelaEN.TeaScore = objRow[convgs_PTopicObjectiveRela.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convgs_PTopicObjectiveRela.TeaScore].ToString().Trim()); //教师评分
objvgs_PTopicObjectiveRelaEN.StuScore = objRow[convgs_PTopicObjectiveRela.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convgs_PTopicObjectiveRela.StuScore].ToString().Trim()); //学生平均分
objvgs_PTopicObjectiveRelaEN.Score = objRow[convgs_PTopicObjectiveRela.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convgs_PTopicObjectiveRela.Score].ToString().Trim()); //评分
objvgs_PTopicObjectiveRelaEN.AppraiseCount = objRow[convgs_PTopicObjectiveRela.AppraiseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convgs_PTopicObjectiveRela.AppraiseCount].ToString().Trim()); //评论数
objvgs_PTopicObjectiveRelaEN.OkCount = objRow[convgs_PTopicObjectiveRela.OkCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convgs_PTopicObjectiveRela.OkCount].ToString().Trim()); //点赞统计
objvgs_PTopicObjectiveRelaEN.VersionCount = objRow[convgs_PTopicObjectiveRela.VersionCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convgs_PTopicObjectiveRela.VersionCount].ToString().Trim()); //版本统计
objvgs_PTopicObjectiveRelaEN.CitationCount = objRow[convgs_PTopicObjectiveRela.CitationCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convgs_PTopicObjectiveRela.CitationCount].ToString().Trim()); //引用统计
objvgs_PTopicObjectiveRelaEN.UpdDate = objRow[convgs_PTopicObjectiveRela.UpdDate] == DBNull.Value ? null : objRow[convgs_PTopicObjectiveRela.UpdDate].ToString().Trim(); //修改日期
objvgs_PTopicObjectiveRelaEN.UpdUser = objRow[convgs_PTopicObjectiveRela.UpdUser] == DBNull.Value ? null : objRow[convgs_PTopicObjectiveRela.UpdUser].ToString().Trim(); //修改人
objvgs_PTopicObjectiveRelaEN.Memo = objRow[convgs_PTopicObjectiveRela.Memo] == DBNull.Value ? null : objRow[convgs_PTopicObjectiveRela.Memo].ToString().Trim(); //备注
objvgs_PTopicObjectiveRelaEN.ObjUserId = objRow[convgs_PTopicObjectiveRela.ObjUserId] == DBNull.Value ? null : objRow[convgs_PTopicObjectiveRela.ObjUserId].ToString().Trim(); //ObjUserId
objvgs_PTopicObjectiveRelaEN.ObjDate = objRow[convgs_PTopicObjectiveRela.ObjDate] == DBNull.Value ? null : objRow[convgs_PTopicObjectiveRela.ObjDate].ToString().Trim(); //ObjDate
objvgs_PTopicObjectiveRelaEN.Conclusion = objRow[convgs_PTopicObjectiveRela.Conclusion] == DBNull.Value ? null : objRow[convgs_PTopicObjectiveRela.Conclusion].ToString().Trim(); //结论
objvgs_PTopicObjectiveRelaEN.CreateDate = objRow[convgs_PTopicObjectiveRela.CreateDate] == DBNull.Value ? null : objRow[convgs_PTopicObjectiveRela.CreateDate].ToString().Trim(); //建立日期
objvgs_PTopicObjectiveRelaEN.ShareId = objRow[convgs_PTopicObjectiveRela.ShareId] == DBNull.Value ? null : objRow[convgs_PTopicObjectiveRela.ShareId].ToString().Trim(); //分享Id
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvgs_PTopicObjectiveRelaEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvgs_PTopicObjectiveRelaEN);
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
public static List<clsvgs_PTopicObjectiveRelaEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsvgs_PTopicObjectiveRelaEN> arrObjLst = new List<clsvgs_PTopicObjectiveRelaEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvgs_PTopicObjectiveRelaEN objvgs_PTopicObjectiveRelaEN = new clsvgs_PTopicObjectiveRelaEN();
try
{
objvgs_PTopicObjectiveRelaEN.mId = Int32.Parse(objRow[convgs_PTopicObjectiveRela.mId].ToString().Trim()); //mId
objvgs_PTopicObjectiveRelaEN.PaperId = objRow[convgs_PTopicObjectiveRela.PaperId].ToString().Trim(); //论文Id
objvgs_PTopicObjectiveRelaEN.PaperTitle = objRow[convgs_PTopicObjectiveRela.PaperTitle] == DBNull.Value ? null : objRow[convgs_PTopicObjectiveRela.PaperTitle].ToString().Trim(); //论文标题
objvgs_PTopicObjectiveRelaEN.PaperTypeId = objRow[convgs_PTopicObjectiveRela.PaperTypeId] == DBNull.Value ? null : objRow[convgs_PTopicObjectiveRela.PaperTypeId].ToString().Trim(); //论文类型Id
objvgs_PTopicObjectiveRelaEN.SectionId = objRow[convgs_PTopicObjectiveRela.SectionId] == DBNull.Value ? null : objRow[convgs_PTopicObjectiveRela.SectionId].ToString().Trim(); //节Id
objvgs_PTopicObjectiveRelaEN.SectionName = objRow[convgs_PTopicObjectiveRela.SectionName] == DBNull.Value ? null : objRow[convgs_PTopicObjectiveRela.SectionName].ToString().Trim(); //节名
objvgs_PTopicObjectiveRelaEN.TopicObjectiveId = objRow[convgs_PTopicObjectiveRela.TopicObjectiveId].ToString().Trim(); //客观Id
objvgs_PTopicObjectiveRelaEN.ObjectiveName = objRow[convgs_PTopicObjectiveRela.ObjectiveName] == DBNull.Value ? null : objRow[convgs_PTopicObjectiveRela.ObjectiveName].ToString().Trim(); //客观名称
objvgs_PTopicObjectiveRelaEN.ObjectiveContent = objRow[convgs_PTopicObjectiveRela.ObjectiveContent] == DBNull.Value ? null : objRow[convgs_PTopicObjectiveRela.ObjectiveContent].ToString().Trim(); //客观内容
objvgs_PTopicObjectiveRelaEN.ObjectiveType = objRow[convgs_PTopicObjectiveRela.ObjectiveType] == DBNull.Value ? null : objRow[convgs_PTopicObjectiveRela.ObjectiveType].ToString().Trim(); //客观类型
objvgs_PTopicObjectiveRelaEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[convgs_PTopicObjectiveRela.IsSubmit].ToString().Trim()); //是否提交
objvgs_PTopicObjectiveRelaEN.ObjectiveTypeName = objRow[convgs_PTopicObjectiveRela.ObjectiveTypeName] == DBNull.Value ? null : objRow[convgs_PTopicObjectiveRela.ObjectiveTypeName].ToString().Trim(); //ObjectiveTypeName
objvgs_PTopicObjectiveRelaEN.TeaScore = objRow[convgs_PTopicObjectiveRela.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convgs_PTopicObjectiveRela.TeaScore].ToString().Trim()); //教师评分
objvgs_PTopicObjectiveRelaEN.StuScore = objRow[convgs_PTopicObjectiveRela.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convgs_PTopicObjectiveRela.StuScore].ToString().Trim()); //学生平均分
objvgs_PTopicObjectiveRelaEN.Score = objRow[convgs_PTopicObjectiveRela.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convgs_PTopicObjectiveRela.Score].ToString().Trim()); //评分
objvgs_PTopicObjectiveRelaEN.AppraiseCount = objRow[convgs_PTopicObjectiveRela.AppraiseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convgs_PTopicObjectiveRela.AppraiseCount].ToString().Trim()); //评论数
objvgs_PTopicObjectiveRelaEN.OkCount = objRow[convgs_PTopicObjectiveRela.OkCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convgs_PTopicObjectiveRela.OkCount].ToString().Trim()); //点赞统计
objvgs_PTopicObjectiveRelaEN.VersionCount = objRow[convgs_PTopicObjectiveRela.VersionCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convgs_PTopicObjectiveRela.VersionCount].ToString().Trim()); //版本统计
objvgs_PTopicObjectiveRelaEN.CitationCount = objRow[convgs_PTopicObjectiveRela.CitationCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convgs_PTopicObjectiveRela.CitationCount].ToString().Trim()); //引用统计
objvgs_PTopicObjectiveRelaEN.UpdDate = objRow[convgs_PTopicObjectiveRela.UpdDate] == DBNull.Value ? null : objRow[convgs_PTopicObjectiveRela.UpdDate].ToString().Trim(); //修改日期
objvgs_PTopicObjectiveRelaEN.UpdUser = objRow[convgs_PTopicObjectiveRela.UpdUser] == DBNull.Value ? null : objRow[convgs_PTopicObjectiveRela.UpdUser].ToString().Trim(); //修改人
objvgs_PTopicObjectiveRelaEN.Memo = objRow[convgs_PTopicObjectiveRela.Memo] == DBNull.Value ? null : objRow[convgs_PTopicObjectiveRela.Memo].ToString().Trim(); //备注
objvgs_PTopicObjectiveRelaEN.ObjUserId = objRow[convgs_PTopicObjectiveRela.ObjUserId] == DBNull.Value ? null : objRow[convgs_PTopicObjectiveRela.ObjUserId].ToString().Trim(); //ObjUserId
objvgs_PTopicObjectiveRelaEN.ObjDate = objRow[convgs_PTopicObjectiveRela.ObjDate] == DBNull.Value ? null : objRow[convgs_PTopicObjectiveRela.ObjDate].ToString().Trim(); //ObjDate
objvgs_PTopicObjectiveRelaEN.Conclusion = objRow[convgs_PTopicObjectiveRela.Conclusion] == DBNull.Value ? null : objRow[convgs_PTopicObjectiveRela.Conclusion].ToString().Trim(); //结论
objvgs_PTopicObjectiveRelaEN.CreateDate = objRow[convgs_PTopicObjectiveRela.CreateDate] == DBNull.Value ? null : objRow[convgs_PTopicObjectiveRela.CreateDate].ToString().Trim(); //建立日期
objvgs_PTopicObjectiveRelaEN.ShareId = objRow[convgs_PTopicObjectiveRela.ShareId] == DBNull.Value ? null : objRow[convgs_PTopicObjectiveRela.ShareId].ToString().Trim(); //分享Id
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvgs_PTopicObjectiveRelaEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvgs_PTopicObjectiveRelaEN);
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
List<clsvgs_PTopicObjectiveRelaEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsvgs_PTopicObjectiveRelaEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsvgs_PTopicObjectiveRelaEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsvgs_PTopicObjectiveRelaEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsvgs_PTopicObjectiveRelaEN> arrObjLst = new List<clsvgs_PTopicObjectiveRelaEN>(); 
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
	clsvgs_PTopicObjectiveRelaEN objvgs_PTopicObjectiveRelaEN = new clsvgs_PTopicObjectiveRelaEN();
try
{
objvgs_PTopicObjectiveRelaEN.mId = Int32.Parse(objRow[convgs_PTopicObjectiveRela.mId].ToString().Trim()); //mId
objvgs_PTopicObjectiveRelaEN.PaperId = objRow[convgs_PTopicObjectiveRela.PaperId].ToString().Trim(); //论文Id
objvgs_PTopicObjectiveRelaEN.PaperTitle = objRow[convgs_PTopicObjectiveRela.PaperTitle] == DBNull.Value ? null : objRow[convgs_PTopicObjectiveRela.PaperTitle].ToString().Trim(); //论文标题
objvgs_PTopicObjectiveRelaEN.PaperTypeId = objRow[convgs_PTopicObjectiveRela.PaperTypeId] == DBNull.Value ? null : objRow[convgs_PTopicObjectiveRela.PaperTypeId].ToString().Trim(); //论文类型Id
objvgs_PTopicObjectiveRelaEN.SectionId = objRow[convgs_PTopicObjectiveRela.SectionId] == DBNull.Value ? null : objRow[convgs_PTopicObjectiveRela.SectionId].ToString().Trim(); //节Id
objvgs_PTopicObjectiveRelaEN.SectionName = objRow[convgs_PTopicObjectiveRela.SectionName] == DBNull.Value ? null : objRow[convgs_PTopicObjectiveRela.SectionName].ToString().Trim(); //节名
objvgs_PTopicObjectiveRelaEN.TopicObjectiveId = objRow[convgs_PTopicObjectiveRela.TopicObjectiveId].ToString().Trim(); //客观Id
objvgs_PTopicObjectiveRelaEN.ObjectiveName = objRow[convgs_PTopicObjectiveRela.ObjectiveName] == DBNull.Value ? null : objRow[convgs_PTopicObjectiveRela.ObjectiveName].ToString().Trim(); //客观名称
objvgs_PTopicObjectiveRelaEN.ObjectiveContent = objRow[convgs_PTopicObjectiveRela.ObjectiveContent] == DBNull.Value ? null : objRow[convgs_PTopicObjectiveRela.ObjectiveContent].ToString().Trim(); //客观内容
objvgs_PTopicObjectiveRelaEN.ObjectiveType = objRow[convgs_PTopicObjectiveRela.ObjectiveType] == DBNull.Value ? null : objRow[convgs_PTopicObjectiveRela.ObjectiveType].ToString().Trim(); //客观类型
objvgs_PTopicObjectiveRelaEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[convgs_PTopicObjectiveRela.IsSubmit].ToString().Trim()); //是否提交
objvgs_PTopicObjectiveRelaEN.ObjectiveTypeName = objRow[convgs_PTopicObjectiveRela.ObjectiveTypeName] == DBNull.Value ? null : objRow[convgs_PTopicObjectiveRela.ObjectiveTypeName].ToString().Trim(); //ObjectiveTypeName
objvgs_PTopicObjectiveRelaEN.TeaScore = objRow[convgs_PTopicObjectiveRela.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convgs_PTopicObjectiveRela.TeaScore].ToString().Trim()); //教师评分
objvgs_PTopicObjectiveRelaEN.StuScore = objRow[convgs_PTopicObjectiveRela.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convgs_PTopicObjectiveRela.StuScore].ToString().Trim()); //学生平均分
objvgs_PTopicObjectiveRelaEN.Score = objRow[convgs_PTopicObjectiveRela.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convgs_PTopicObjectiveRela.Score].ToString().Trim()); //评分
objvgs_PTopicObjectiveRelaEN.AppraiseCount = objRow[convgs_PTopicObjectiveRela.AppraiseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convgs_PTopicObjectiveRela.AppraiseCount].ToString().Trim()); //评论数
objvgs_PTopicObjectiveRelaEN.OkCount = objRow[convgs_PTopicObjectiveRela.OkCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convgs_PTopicObjectiveRela.OkCount].ToString().Trim()); //点赞统计
objvgs_PTopicObjectiveRelaEN.VersionCount = objRow[convgs_PTopicObjectiveRela.VersionCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convgs_PTopicObjectiveRela.VersionCount].ToString().Trim()); //版本统计
objvgs_PTopicObjectiveRelaEN.CitationCount = objRow[convgs_PTopicObjectiveRela.CitationCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convgs_PTopicObjectiveRela.CitationCount].ToString().Trim()); //引用统计
objvgs_PTopicObjectiveRelaEN.UpdDate = objRow[convgs_PTopicObjectiveRela.UpdDate] == DBNull.Value ? null : objRow[convgs_PTopicObjectiveRela.UpdDate].ToString().Trim(); //修改日期
objvgs_PTopicObjectiveRelaEN.UpdUser = objRow[convgs_PTopicObjectiveRela.UpdUser] == DBNull.Value ? null : objRow[convgs_PTopicObjectiveRela.UpdUser].ToString().Trim(); //修改人
objvgs_PTopicObjectiveRelaEN.Memo = objRow[convgs_PTopicObjectiveRela.Memo] == DBNull.Value ? null : objRow[convgs_PTopicObjectiveRela.Memo].ToString().Trim(); //备注
objvgs_PTopicObjectiveRelaEN.ObjUserId = objRow[convgs_PTopicObjectiveRela.ObjUserId] == DBNull.Value ? null : objRow[convgs_PTopicObjectiveRela.ObjUserId].ToString().Trim(); //ObjUserId
objvgs_PTopicObjectiveRelaEN.ObjDate = objRow[convgs_PTopicObjectiveRela.ObjDate] == DBNull.Value ? null : objRow[convgs_PTopicObjectiveRela.ObjDate].ToString().Trim(); //ObjDate
objvgs_PTopicObjectiveRelaEN.Conclusion = objRow[convgs_PTopicObjectiveRela.Conclusion] == DBNull.Value ? null : objRow[convgs_PTopicObjectiveRela.Conclusion].ToString().Trim(); //结论
objvgs_PTopicObjectiveRelaEN.CreateDate = objRow[convgs_PTopicObjectiveRela.CreateDate] == DBNull.Value ? null : objRow[convgs_PTopicObjectiveRela.CreateDate].ToString().Trim(); //建立日期
objvgs_PTopicObjectiveRelaEN.ShareId = objRow[convgs_PTopicObjectiveRela.ShareId] == DBNull.Value ? null : objRow[convgs_PTopicObjectiveRela.ShareId].ToString().Trim(); //分享Id
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvgs_PTopicObjectiveRelaEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvgs_PTopicObjectiveRelaEN);
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
public static List<clsvgs_PTopicObjectiveRelaEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsvgs_PTopicObjectiveRelaEN> arrObjLst = new List<clsvgs_PTopicObjectiveRelaEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvgs_PTopicObjectiveRelaEN objvgs_PTopicObjectiveRelaEN = new clsvgs_PTopicObjectiveRelaEN();
try
{
objvgs_PTopicObjectiveRelaEN.mId = Int32.Parse(objRow[convgs_PTopicObjectiveRela.mId].ToString().Trim()); //mId
objvgs_PTopicObjectiveRelaEN.PaperId = objRow[convgs_PTopicObjectiveRela.PaperId].ToString().Trim(); //论文Id
objvgs_PTopicObjectiveRelaEN.PaperTitle = objRow[convgs_PTopicObjectiveRela.PaperTitle] == DBNull.Value ? null : objRow[convgs_PTopicObjectiveRela.PaperTitle].ToString().Trim(); //论文标题
objvgs_PTopicObjectiveRelaEN.PaperTypeId = objRow[convgs_PTopicObjectiveRela.PaperTypeId] == DBNull.Value ? null : objRow[convgs_PTopicObjectiveRela.PaperTypeId].ToString().Trim(); //论文类型Id
objvgs_PTopicObjectiveRelaEN.SectionId = objRow[convgs_PTopicObjectiveRela.SectionId] == DBNull.Value ? null : objRow[convgs_PTopicObjectiveRela.SectionId].ToString().Trim(); //节Id
objvgs_PTopicObjectiveRelaEN.SectionName = objRow[convgs_PTopicObjectiveRela.SectionName] == DBNull.Value ? null : objRow[convgs_PTopicObjectiveRela.SectionName].ToString().Trim(); //节名
objvgs_PTopicObjectiveRelaEN.TopicObjectiveId = objRow[convgs_PTopicObjectiveRela.TopicObjectiveId].ToString().Trim(); //客观Id
objvgs_PTopicObjectiveRelaEN.ObjectiveName = objRow[convgs_PTopicObjectiveRela.ObjectiveName] == DBNull.Value ? null : objRow[convgs_PTopicObjectiveRela.ObjectiveName].ToString().Trim(); //客观名称
objvgs_PTopicObjectiveRelaEN.ObjectiveContent = objRow[convgs_PTopicObjectiveRela.ObjectiveContent] == DBNull.Value ? null : objRow[convgs_PTopicObjectiveRela.ObjectiveContent].ToString().Trim(); //客观内容
objvgs_PTopicObjectiveRelaEN.ObjectiveType = objRow[convgs_PTopicObjectiveRela.ObjectiveType] == DBNull.Value ? null : objRow[convgs_PTopicObjectiveRela.ObjectiveType].ToString().Trim(); //客观类型
objvgs_PTopicObjectiveRelaEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[convgs_PTopicObjectiveRela.IsSubmit].ToString().Trim()); //是否提交
objvgs_PTopicObjectiveRelaEN.ObjectiveTypeName = objRow[convgs_PTopicObjectiveRela.ObjectiveTypeName] == DBNull.Value ? null : objRow[convgs_PTopicObjectiveRela.ObjectiveTypeName].ToString().Trim(); //ObjectiveTypeName
objvgs_PTopicObjectiveRelaEN.TeaScore = objRow[convgs_PTopicObjectiveRela.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convgs_PTopicObjectiveRela.TeaScore].ToString().Trim()); //教师评分
objvgs_PTopicObjectiveRelaEN.StuScore = objRow[convgs_PTopicObjectiveRela.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convgs_PTopicObjectiveRela.StuScore].ToString().Trim()); //学生平均分
objvgs_PTopicObjectiveRelaEN.Score = objRow[convgs_PTopicObjectiveRela.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convgs_PTopicObjectiveRela.Score].ToString().Trim()); //评分
objvgs_PTopicObjectiveRelaEN.AppraiseCount = objRow[convgs_PTopicObjectiveRela.AppraiseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convgs_PTopicObjectiveRela.AppraiseCount].ToString().Trim()); //评论数
objvgs_PTopicObjectiveRelaEN.OkCount = objRow[convgs_PTopicObjectiveRela.OkCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convgs_PTopicObjectiveRela.OkCount].ToString().Trim()); //点赞统计
objvgs_PTopicObjectiveRelaEN.VersionCount = objRow[convgs_PTopicObjectiveRela.VersionCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convgs_PTopicObjectiveRela.VersionCount].ToString().Trim()); //版本统计
objvgs_PTopicObjectiveRelaEN.CitationCount = objRow[convgs_PTopicObjectiveRela.CitationCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convgs_PTopicObjectiveRela.CitationCount].ToString().Trim()); //引用统计
objvgs_PTopicObjectiveRelaEN.UpdDate = objRow[convgs_PTopicObjectiveRela.UpdDate] == DBNull.Value ? null : objRow[convgs_PTopicObjectiveRela.UpdDate].ToString().Trim(); //修改日期
objvgs_PTopicObjectiveRelaEN.UpdUser = objRow[convgs_PTopicObjectiveRela.UpdUser] == DBNull.Value ? null : objRow[convgs_PTopicObjectiveRela.UpdUser].ToString().Trim(); //修改人
objvgs_PTopicObjectiveRelaEN.Memo = objRow[convgs_PTopicObjectiveRela.Memo] == DBNull.Value ? null : objRow[convgs_PTopicObjectiveRela.Memo].ToString().Trim(); //备注
objvgs_PTopicObjectiveRelaEN.ObjUserId = objRow[convgs_PTopicObjectiveRela.ObjUserId] == DBNull.Value ? null : objRow[convgs_PTopicObjectiveRela.ObjUserId].ToString().Trim(); //ObjUserId
objvgs_PTopicObjectiveRelaEN.ObjDate = objRow[convgs_PTopicObjectiveRela.ObjDate] == DBNull.Value ? null : objRow[convgs_PTopicObjectiveRela.ObjDate].ToString().Trim(); //ObjDate
objvgs_PTopicObjectiveRelaEN.Conclusion = objRow[convgs_PTopicObjectiveRela.Conclusion] == DBNull.Value ? null : objRow[convgs_PTopicObjectiveRela.Conclusion].ToString().Trim(); //结论
objvgs_PTopicObjectiveRelaEN.CreateDate = objRow[convgs_PTopicObjectiveRela.CreateDate] == DBNull.Value ? null : objRow[convgs_PTopicObjectiveRela.CreateDate].ToString().Trim(); //建立日期
objvgs_PTopicObjectiveRelaEN.ShareId = objRow[convgs_PTopicObjectiveRela.ShareId] == DBNull.Value ? null : objRow[convgs_PTopicObjectiveRela.ShareId].ToString().Trim(); //分享Id
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvgs_PTopicObjectiveRelaEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvgs_PTopicObjectiveRelaEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsvgs_PTopicObjectiveRelaEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsvgs_PTopicObjectiveRelaEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsvgs_PTopicObjectiveRelaEN> arrObjLst = new List<clsvgs_PTopicObjectiveRelaEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvgs_PTopicObjectiveRelaEN objvgs_PTopicObjectiveRelaEN = new clsvgs_PTopicObjectiveRelaEN();
try
{
objvgs_PTopicObjectiveRelaEN.mId = Int32.Parse(objRow[convgs_PTopicObjectiveRela.mId].ToString().Trim()); //mId
objvgs_PTopicObjectiveRelaEN.PaperId = objRow[convgs_PTopicObjectiveRela.PaperId].ToString().Trim(); //论文Id
objvgs_PTopicObjectiveRelaEN.PaperTitle = objRow[convgs_PTopicObjectiveRela.PaperTitle] == DBNull.Value ? null : objRow[convgs_PTopicObjectiveRela.PaperTitle].ToString().Trim(); //论文标题
objvgs_PTopicObjectiveRelaEN.PaperTypeId = objRow[convgs_PTopicObjectiveRela.PaperTypeId] == DBNull.Value ? null : objRow[convgs_PTopicObjectiveRela.PaperTypeId].ToString().Trim(); //论文类型Id
objvgs_PTopicObjectiveRelaEN.SectionId = objRow[convgs_PTopicObjectiveRela.SectionId] == DBNull.Value ? null : objRow[convgs_PTopicObjectiveRela.SectionId].ToString().Trim(); //节Id
objvgs_PTopicObjectiveRelaEN.SectionName = objRow[convgs_PTopicObjectiveRela.SectionName] == DBNull.Value ? null : objRow[convgs_PTopicObjectiveRela.SectionName].ToString().Trim(); //节名
objvgs_PTopicObjectiveRelaEN.TopicObjectiveId = objRow[convgs_PTopicObjectiveRela.TopicObjectiveId].ToString().Trim(); //客观Id
objvgs_PTopicObjectiveRelaEN.ObjectiveName = objRow[convgs_PTopicObjectiveRela.ObjectiveName] == DBNull.Value ? null : objRow[convgs_PTopicObjectiveRela.ObjectiveName].ToString().Trim(); //客观名称
objvgs_PTopicObjectiveRelaEN.ObjectiveContent = objRow[convgs_PTopicObjectiveRela.ObjectiveContent] == DBNull.Value ? null : objRow[convgs_PTopicObjectiveRela.ObjectiveContent].ToString().Trim(); //客观内容
objvgs_PTopicObjectiveRelaEN.ObjectiveType = objRow[convgs_PTopicObjectiveRela.ObjectiveType] == DBNull.Value ? null : objRow[convgs_PTopicObjectiveRela.ObjectiveType].ToString().Trim(); //客观类型
objvgs_PTopicObjectiveRelaEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[convgs_PTopicObjectiveRela.IsSubmit].ToString().Trim()); //是否提交
objvgs_PTopicObjectiveRelaEN.ObjectiveTypeName = objRow[convgs_PTopicObjectiveRela.ObjectiveTypeName] == DBNull.Value ? null : objRow[convgs_PTopicObjectiveRela.ObjectiveTypeName].ToString().Trim(); //ObjectiveTypeName
objvgs_PTopicObjectiveRelaEN.TeaScore = objRow[convgs_PTopicObjectiveRela.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convgs_PTopicObjectiveRela.TeaScore].ToString().Trim()); //教师评分
objvgs_PTopicObjectiveRelaEN.StuScore = objRow[convgs_PTopicObjectiveRela.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convgs_PTopicObjectiveRela.StuScore].ToString().Trim()); //学生平均分
objvgs_PTopicObjectiveRelaEN.Score = objRow[convgs_PTopicObjectiveRela.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convgs_PTopicObjectiveRela.Score].ToString().Trim()); //评分
objvgs_PTopicObjectiveRelaEN.AppraiseCount = objRow[convgs_PTopicObjectiveRela.AppraiseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convgs_PTopicObjectiveRela.AppraiseCount].ToString().Trim()); //评论数
objvgs_PTopicObjectiveRelaEN.OkCount = objRow[convgs_PTopicObjectiveRela.OkCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convgs_PTopicObjectiveRela.OkCount].ToString().Trim()); //点赞统计
objvgs_PTopicObjectiveRelaEN.VersionCount = objRow[convgs_PTopicObjectiveRela.VersionCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convgs_PTopicObjectiveRela.VersionCount].ToString().Trim()); //版本统计
objvgs_PTopicObjectiveRelaEN.CitationCount = objRow[convgs_PTopicObjectiveRela.CitationCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convgs_PTopicObjectiveRela.CitationCount].ToString().Trim()); //引用统计
objvgs_PTopicObjectiveRelaEN.UpdDate = objRow[convgs_PTopicObjectiveRela.UpdDate] == DBNull.Value ? null : objRow[convgs_PTopicObjectiveRela.UpdDate].ToString().Trim(); //修改日期
objvgs_PTopicObjectiveRelaEN.UpdUser = objRow[convgs_PTopicObjectiveRela.UpdUser] == DBNull.Value ? null : objRow[convgs_PTopicObjectiveRela.UpdUser].ToString().Trim(); //修改人
objvgs_PTopicObjectiveRelaEN.Memo = objRow[convgs_PTopicObjectiveRela.Memo] == DBNull.Value ? null : objRow[convgs_PTopicObjectiveRela.Memo].ToString().Trim(); //备注
objvgs_PTopicObjectiveRelaEN.ObjUserId = objRow[convgs_PTopicObjectiveRela.ObjUserId] == DBNull.Value ? null : objRow[convgs_PTopicObjectiveRela.ObjUserId].ToString().Trim(); //ObjUserId
objvgs_PTopicObjectiveRelaEN.ObjDate = objRow[convgs_PTopicObjectiveRela.ObjDate] == DBNull.Value ? null : objRow[convgs_PTopicObjectiveRela.ObjDate].ToString().Trim(); //ObjDate
objvgs_PTopicObjectiveRelaEN.Conclusion = objRow[convgs_PTopicObjectiveRela.Conclusion] == DBNull.Value ? null : objRow[convgs_PTopicObjectiveRela.Conclusion].ToString().Trim(); //结论
objvgs_PTopicObjectiveRelaEN.CreateDate = objRow[convgs_PTopicObjectiveRela.CreateDate] == DBNull.Value ? null : objRow[convgs_PTopicObjectiveRela.CreateDate].ToString().Trim(); //建立日期
objvgs_PTopicObjectiveRelaEN.ShareId = objRow[convgs_PTopicObjectiveRela.ShareId] == DBNull.Value ? null : objRow[convgs_PTopicObjectiveRela.ShareId].ToString().Trim(); //分享Id
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvgs_PTopicObjectiveRelaEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvgs_PTopicObjectiveRelaEN);
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
public static List<clsvgs_PTopicObjectiveRelaEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsvgs_PTopicObjectiveRelaEN> arrObjLst = new List<clsvgs_PTopicObjectiveRelaEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvgs_PTopicObjectiveRelaEN objvgs_PTopicObjectiveRelaEN = new clsvgs_PTopicObjectiveRelaEN();
try
{
objvgs_PTopicObjectiveRelaEN.mId = Int32.Parse(objRow[convgs_PTopicObjectiveRela.mId].ToString().Trim()); //mId
objvgs_PTopicObjectiveRelaEN.PaperId = objRow[convgs_PTopicObjectiveRela.PaperId].ToString().Trim(); //论文Id
objvgs_PTopicObjectiveRelaEN.PaperTitle = objRow[convgs_PTopicObjectiveRela.PaperTitle] == DBNull.Value ? null : objRow[convgs_PTopicObjectiveRela.PaperTitle].ToString().Trim(); //论文标题
objvgs_PTopicObjectiveRelaEN.PaperTypeId = objRow[convgs_PTopicObjectiveRela.PaperTypeId] == DBNull.Value ? null : objRow[convgs_PTopicObjectiveRela.PaperTypeId].ToString().Trim(); //论文类型Id
objvgs_PTopicObjectiveRelaEN.SectionId = objRow[convgs_PTopicObjectiveRela.SectionId] == DBNull.Value ? null : objRow[convgs_PTopicObjectiveRela.SectionId].ToString().Trim(); //节Id
objvgs_PTopicObjectiveRelaEN.SectionName = objRow[convgs_PTopicObjectiveRela.SectionName] == DBNull.Value ? null : objRow[convgs_PTopicObjectiveRela.SectionName].ToString().Trim(); //节名
objvgs_PTopicObjectiveRelaEN.TopicObjectiveId = objRow[convgs_PTopicObjectiveRela.TopicObjectiveId].ToString().Trim(); //客观Id
objvgs_PTopicObjectiveRelaEN.ObjectiveName = objRow[convgs_PTopicObjectiveRela.ObjectiveName] == DBNull.Value ? null : objRow[convgs_PTopicObjectiveRela.ObjectiveName].ToString().Trim(); //客观名称
objvgs_PTopicObjectiveRelaEN.ObjectiveContent = objRow[convgs_PTopicObjectiveRela.ObjectiveContent] == DBNull.Value ? null : objRow[convgs_PTopicObjectiveRela.ObjectiveContent].ToString().Trim(); //客观内容
objvgs_PTopicObjectiveRelaEN.ObjectiveType = objRow[convgs_PTopicObjectiveRela.ObjectiveType] == DBNull.Value ? null : objRow[convgs_PTopicObjectiveRela.ObjectiveType].ToString().Trim(); //客观类型
objvgs_PTopicObjectiveRelaEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[convgs_PTopicObjectiveRela.IsSubmit].ToString().Trim()); //是否提交
objvgs_PTopicObjectiveRelaEN.ObjectiveTypeName = objRow[convgs_PTopicObjectiveRela.ObjectiveTypeName] == DBNull.Value ? null : objRow[convgs_PTopicObjectiveRela.ObjectiveTypeName].ToString().Trim(); //ObjectiveTypeName
objvgs_PTopicObjectiveRelaEN.TeaScore = objRow[convgs_PTopicObjectiveRela.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convgs_PTopicObjectiveRela.TeaScore].ToString().Trim()); //教师评分
objvgs_PTopicObjectiveRelaEN.StuScore = objRow[convgs_PTopicObjectiveRela.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convgs_PTopicObjectiveRela.StuScore].ToString().Trim()); //学生平均分
objvgs_PTopicObjectiveRelaEN.Score = objRow[convgs_PTopicObjectiveRela.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convgs_PTopicObjectiveRela.Score].ToString().Trim()); //评分
objvgs_PTopicObjectiveRelaEN.AppraiseCount = objRow[convgs_PTopicObjectiveRela.AppraiseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convgs_PTopicObjectiveRela.AppraiseCount].ToString().Trim()); //评论数
objvgs_PTopicObjectiveRelaEN.OkCount = objRow[convgs_PTopicObjectiveRela.OkCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convgs_PTopicObjectiveRela.OkCount].ToString().Trim()); //点赞统计
objvgs_PTopicObjectiveRelaEN.VersionCount = objRow[convgs_PTopicObjectiveRela.VersionCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convgs_PTopicObjectiveRela.VersionCount].ToString().Trim()); //版本统计
objvgs_PTopicObjectiveRelaEN.CitationCount = objRow[convgs_PTopicObjectiveRela.CitationCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convgs_PTopicObjectiveRela.CitationCount].ToString().Trim()); //引用统计
objvgs_PTopicObjectiveRelaEN.UpdDate = objRow[convgs_PTopicObjectiveRela.UpdDate] == DBNull.Value ? null : objRow[convgs_PTopicObjectiveRela.UpdDate].ToString().Trim(); //修改日期
objvgs_PTopicObjectiveRelaEN.UpdUser = objRow[convgs_PTopicObjectiveRela.UpdUser] == DBNull.Value ? null : objRow[convgs_PTopicObjectiveRela.UpdUser].ToString().Trim(); //修改人
objvgs_PTopicObjectiveRelaEN.Memo = objRow[convgs_PTopicObjectiveRela.Memo] == DBNull.Value ? null : objRow[convgs_PTopicObjectiveRela.Memo].ToString().Trim(); //备注
objvgs_PTopicObjectiveRelaEN.ObjUserId = objRow[convgs_PTopicObjectiveRela.ObjUserId] == DBNull.Value ? null : objRow[convgs_PTopicObjectiveRela.ObjUserId].ToString().Trim(); //ObjUserId
objvgs_PTopicObjectiveRelaEN.ObjDate = objRow[convgs_PTopicObjectiveRela.ObjDate] == DBNull.Value ? null : objRow[convgs_PTopicObjectiveRela.ObjDate].ToString().Trim(); //ObjDate
objvgs_PTopicObjectiveRelaEN.Conclusion = objRow[convgs_PTopicObjectiveRela.Conclusion] == DBNull.Value ? null : objRow[convgs_PTopicObjectiveRela.Conclusion].ToString().Trim(); //结论
objvgs_PTopicObjectiveRelaEN.CreateDate = objRow[convgs_PTopicObjectiveRela.CreateDate] == DBNull.Value ? null : objRow[convgs_PTopicObjectiveRela.CreateDate].ToString().Trim(); //建立日期
objvgs_PTopicObjectiveRelaEN.ShareId = objRow[convgs_PTopicObjectiveRela.ShareId] == DBNull.Value ? null : objRow[convgs_PTopicObjectiveRela.ShareId].ToString().Trim(); //分享Id
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvgs_PTopicObjectiveRelaEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvgs_PTopicObjectiveRelaEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsvgs_PTopicObjectiveRelaEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsvgs_PTopicObjectiveRelaEN> arrObjLst = new List<clsvgs_PTopicObjectiveRelaEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvgs_PTopicObjectiveRelaEN objvgs_PTopicObjectiveRelaEN = new clsvgs_PTopicObjectiveRelaEN();
try
{
objvgs_PTopicObjectiveRelaEN.mId = Int32.Parse(objRow[convgs_PTopicObjectiveRela.mId].ToString().Trim()); //mId
objvgs_PTopicObjectiveRelaEN.PaperId = objRow[convgs_PTopicObjectiveRela.PaperId].ToString().Trim(); //论文Id
objvgs_PTopicObjectiveRelaEN.PaperTitle = objRow[convgs_PTopicObjectiveRela.PaperTitle] == DBNull.Value ? null : objRow[convgs_PTopicObjectiveRela.PaperTitle].ToString().Trim(); //论文标题
objvgs_PTopicObjectiveRelaEN.PaperTypeId = objRow[convgs_PTopicObjectiveRela.PaperTypeId] == DBNull.Value ? null : objRow[convgs_PTopicObjectiveRela.PaperTypeId].ToString().Trim(); //论文类型Id
objvgs_PTopicObjectiveRelaEN.SectionId = objRow[convgs_PTopicObjectiveRela.SectionId] == DBNull.Value ? null : objRow[convgs_PTopicObjectiveRela.SectionId].ToString().Trim(); //节Id
objvgs_PTopicObjectiveRelaEN.SectionName = objRow[convgs_PTopicObjectiveRela.SectionName] == DBNull.Value ? null : objRow[convgs_PTopicObjectiveRela.SectionName].ToString().Trim(); //节名
objvgs_PTopicObjectiveRelaEN.TopicObjectiveId = objRow[convgs_PTopicObjectiveRela.TopicObjectiveId].ToString().Trim(); //客观Id
objvgs_PTopicObjectiveRelaEN.ObjectiveName = objRow[convgs_PTopicObjectiveRela.ObjectiveName] == DBNull.Value ? null : objRow[convgs_PTopicObjectiveRela.ObjectiveName].ToString().Trim(); //客观名称
objvgs_PTopicObjectiveRelaEN.ObjectiveContent = objRow[convgs_PTopicObjectiveRela.ObjectiveContent] == DBNull.Value ? null : objRow[convgs_PTopicObjectiveRela.ObjectiveContent].ToString().Trim(); //客观内容
objvgs_PTopicObjectiveRelaEN.ObjectiveType = objRow[convgs_PTopicObjectiveRela.ObjectiveType] == DBNull.Value ? null : objRow[convgs_PTopicObjectiveRela.ObjectiveType].ToString().Trim(); //客观类型
objvgs_PTopicObjectiveRelaEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[convgs_PTopicObjectiveRela.IsSubmit].ToString().Trim()); //是否提交
objvgs_PTopicObjectiveRelaEN.ObjectiveTypeName = objRow[convgs_PTopicObjectiveRela.ObjectiveTypeName] == DBNull.Value ? null : objRow[convgs_PTopicObjectiveRela.ObjectiveTypeName].ToString().Trim(); //ObjectiveTypeName
objvgs_PTopicObjectiveRelaEN.TeaScore = objRow[convgs_PTopicObjectiveRela.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convgs_PTopicObjectiveRela.TeaScore].ToString().Trim()); //教师评分
objvgs_PTopicObjectiveRelaEN.StuScore = objRow[convgs_PTopicObjectiveRela.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convgs_PTopicObjectiveRela.StuScore].ToString().Trim()); //学生平均分
objvgs_PTopicObjectiveRelaEN.Score = objRow[convgs_PTopicObjectiveRela.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convgs_PTopicObjectiveRela.Score].ToString().Trim()); //评分
objvgs_PTopicObjectiveRelaEN.AppraiseCount = objRow[convgs_PTopicObjectiveRela.AppraiseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convgs_PTopicObjectiveRela.AppraiseCount].ToString().Trim()); //评论数
objvgs_PTopicObjectiveRelaEN.OkCount = objRow[convgs_PTopicObjectiveRela.OkCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convgs_PTopicObjectiveRela.OkCount].ToString().Trim()); //点赞统计
objvgs_PTopicObjectiveRelaEN.VersionCount = objRow[convgs_PTopicObjectiveRela.VersionCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convgs_PTopicObjectiveRela.VersionCount].ToString().Trim()); //版本统计
objvgs_PTopicObjectiveRelaEN.CitationCount = objRow[convgs_PTopicObjectiveRela.CitationCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convgs_PTopicObjectiveRela.CitationCount].ToString().Trim()); //引用统计
objvgs_PTopicObjectiveRelaEN.UpdDate = objRow[convgs_PTopicObjectiveRela.UpdDate] == DBNull.Value ? null : objRow[convgs_PTopicObjectiveRela.UpdDate].ToString().Trim(); //修改日期
objvgs_PTopicObjectiveRelaEN.UpdUser = objRow[convgs_PTopicObjectiveRela.UpdUser] == DBNull.Value ? null : objRow[convgs_PTopicObjectiveRela.UpdUser].ToString().Trim(); //修改人
objvgs_PTopicObjectiveRelaEN.Memo = objRow[convgs_PTopicObjectiveRela.Memo] == DBNull.Value ? null : objRow[convgs_PTopicObjectiveRela.Memo].ToString().Trim(); //备注
objvgs_PTopicObjectiveRelaEN.ObjUserId = objRow[convgs_PTopicObjectiveRela.ObjUserId] == DBNull.Value ? null : objRow[convgs_PTopicObjectiveRela.ObjUserId].ToString().Trim(); //ObjUserId
objvgs_PTopicObjectiveRelaEN.ObjDate = objRow[convgs_PTopicObjectiveRela.ObjDate] == DBNull.Value ? null : objRow[convgs_PTopicObjectiveRela.ObjDate].ToString().Trim(); //ObjDate
objvgs_PTopicObjectiveRelaEN.Conclusion = objRow[convgs_PTopicObjectiveRela.Conclusion] == DBNull.Value ? null : objRow[convgs_PTopicObjectiveRela.Conclusion].ToString().Trim(); //结论
objvgs_PTopicObjectiveRelaEN.CreateDate = objRow[convgs_PTopicObjectiveRela.CreateDate] == DBNull.Value ? null : objRow[convgs_PTopicObjectiveRela.CreateDate].ToString().Trim(); //建立日期
objvgs_PTopicObjectiveRelaEN.ShareId = objRow[convgs_PTopicObjectiveRela.ShareId] == DBNull.Value ? null : objRow[convgs_PTopicObjectiveRela.ShareId].ToString().Trim(); //分享Id
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvgs_PTopicObjectiveRelaEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvgs_PTopicObjectiveRelaEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objvgs_PTopicObjectiveRelaEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool Getvgs_PTopicObjectiveRela(ref clsvgs_PTopicObjectiveRelaEN objvgs_PTopicObjectiveRelaEN)
{
bool bolResult = vgs_PTopicObjectiveRelaDA.Getvgs_PTopicObjectiveRela(ref objvgs_PTopicObjectiveRelaEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvgs_PTopicObjectiveRelaEN GetObjBymId(long lngmId)
{
clsvgs_PTopicObjectiveRelaEN objvgs_PTopicObjectiveRelaEN = vgs_PTopicObjectiveRelaDA.GetObjBymId(lngmId);
return objvgs_PTopicObjectiveRelaEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsvgs_PTopicObjectiveRelaEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsvgs_PTopicObjectiveRelaEN objvgs_PTopicObjectiveRelaEN = vgs_PTopicObjectiveRelaDA.GetFirstObj(strWhereCond);
 return objvgs_PTopicObjectiveRelaEN;
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
public static clsvgs_PTopicObjectiveRelaEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsvgs_PTopicObjectiveRelaEN objvgs_PTopicObjectiveRelaEN = vgs_PTopicObjectiveRelaDA.GetObjByDataRow(objRow);
 return objvgs_PTopicObjectiveRelaEN;
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
public static clsvgs_PTopicObjectiveRelaEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsvgs_PTopicObjectiveRelaEN objvgs_PTopicObjectiveRelaEN = vgs_PTopicObjectiveRelaDA.GetObjByDataRow(objRow);
 return objvgs_PTopicObjectiveRelaEN;
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
 /// <param name = "lstvgs_PTopicObjectiveRelaObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvgs_PTopicObjectiveRelaEN GetObjBymIdFromList(long lngmId, List<clsvgs_PTopicObjectiveRelaEN> lstvgs_PTopicObjectiveRelaObjLst)
{
foreach (clsvgs_PTopicObjectiveRelaEN objvgs_PTopicObjectiveRelaEN in lstvgs_PTopicObjectiveRelaObjLst)
{
if (objvgs_PTopicObjectiveRelaEN.mId == lngmId)
{
return objvgs_PTopicObjectiveRelaEN;
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
 lngmId = new clsvgs_PTopicObjectiveRelaDA().GetFirstID(strWhereCond);
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
 arrList = vgs_PTopicObjectiveRelaDA.GetID(strWhereCond);
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
bool bolIsExist = vgs_PTopicObjectiveRelaDA.IsExistCondRec(strWhereCond);
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
bool bolIsExist = vgs_PTopicObjectiveRelaDA.IsExist(lngmId);
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
 bolIsExist = clsvgs_PTopicObjectiveRelaDA.IsExistTable();
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
 bolIsExist = vgs_PTopicObjectiveRelaDA.IsExistTable(strTabName);
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
 /// <param name = "objvgs_PTopicObjectiveRelaENS">源对象</param>
 /// <param name = "objvgs_PTopicObjectiveRelaENT">目标对象</param>
 public static void CopyTo(clsvgs_PTopicObjectiveRelaEN objvgs_PTopicObjectiveRelaENS, clsvgs_PTopicObjectiveRelaEN objvgs_PTopicObjectiveRelaENT)
{
try
{
objvgs_PTopicObjectiveRelaENT.mId = objvgs_PTopicObjectiveRelaENS.mId; //mId
objvgs_PTopicObjectiveRelaENT.PaperId = objvgs_PTopicObjectiveRelaENS.PaperId; //论文Id
objvgs_PTopicObjectiveRelaENT.PaperTitle = objvgs_PTopicObjectiveRelaENS.PaperTitle; //论文标题
objvgs_PTopicObjectiveRelaENT.PaperTypeId = objvgs_PTopicObjectiveRelaENS.PaperTypeId; //论文类型Id
objvgs_PTopicObjectiveRelaENT.SectionId = objvgs_PTopicObjectiveRelaENS.SectionId; //节Id
objvgs_PTopicObjectiveRelaENT.SectionName = objvgs_PTopicObjectiveRelaENS.SectionName; //节名
objvgs_PTopicObjectiveRelaENT.TopicObjectiveId = objvgs_PTopicObjectiveRelaENS.TopicObjectiveId; //客观Id
objvgs_PTopicObjectiveRelaENT.ObjectiveName = objvgs_PTopicObjectiveRelaENS.ObjectiveName; //客观名称
objvgs_PTopicObjectiveRelaENT.ObjectiveContent = objvgs_PTopicObjectiveRelaENS.ObjectiveContent; //客观内容
objvgs_PTopicObjectiveRelaENT.ObjectiveType = objvgs_PTopicObjectiveRelaENS.ObjectiveType; //客观类型
objvgs_PTopicObjectiveRelaENT.IsSubmit = objvgs_PTopicObjectiveRelaENS.IsSubmit; //是否提交
objvgs_PTopicObjectiveRelaENT.ObjectiveTypeName = objvgs_PTopicObjectiveRelaENS.ObjectiveTypeName; //ObjectiveTypeName
objvgs_PTopicObjectiveRelaENT.TeaScore = objvgs_PTopicObjectiveRelaENS.TeaScore; //教师评分
objvgs_PTopicObjectiveRelaENT.StuScore = objvgs_PTopicObjectiveRelaENS.StuScore; //学生平均分
objvgs_PTopicObjectiveRelaENT.Score = objvgs_PTopicObjectiveRelaENS.Score; //评分
objvgs_PTopicObjectiveRelaENT.AppraiseCount = objvgs_PTopicObjectiveRelaENS.AppraiseCount; //评论数
objvgs_PTopicObjectiveRelaENT.OkCount = objvgs_PTopicObjectiveRelaENS.OkCount; //点赞统计
objvgs_PTopicObjectiveRelaENT.VersionCount = objvgs_PTopicObjectiveRelaENS.VersionCount; //版本统计
objvgs_PTopicObjectiveRelaENT.CitationCount = objvgs_PTopicObjectiveRelaENS.CitationCount; //引用统计
objvgs_PTopicObjectiveRelaENT.UpdDate = objvgs_PTopicObjectiveRelaENS.UpdDate; //修改日期
objvgs_PTopicObjectiveRelaENT.UpdUser = objvgs_PTopicObjectiveRelaENS.UpdUser; //修改人
objvgs_PTopicObjectiveRelaENT.Memo = objvgs_PTopicObjectiveRelaENS.Memo; //备注
objvgs_PTopicObjectiveRelaENT.ObjUserId = objvgs_PTopicObjectiveRelaENS.ObjUserId; //ObjUserId
objvgs_PTopicObjectiveRelaENT.ObjDate = objvgs_PTopicObjectiveRelaENS.ObjDate; //ObjDate
objvgs_PTopicObjectiveRelaENT.Conclusion = objvgs_PTopicObjectiveRelaENS.Conclusion; //结论
objvgs_PTopicObjectiveRelaENT.CreateDate = objvgs_PTopicObjectiveRelaENS.CreateDate; //建立日期
objvgs_PTopicObjectiveRelaENT.ShareId = objvgs_PTopicObjectiveRelaENS.ShareId; //分享Id
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
 /// <param name = "objvgs_PTopicObjectiveRelaEN">源简化对象</param>
 public static void SetUpdFlag(clsvgs_PTopicObjectiveRelaEN objvgs_PTopicObjectiveRelaEN)
{
try
{
objvgs_PTopicObjectiveRelaEN.ClearUpdateState();
   string strsfUpdFldSetStr = objvgs_PTopicObjectiveRelaEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(convgs_PTopicObjectiveRela.mId, new clsStrCompareIgnoreCase())  ==  true)
{
objvgs_PTopicObjectiveRelaEN.mId = objvgs_PTopicObjectiveRelaEN.mId; //mId
}
if (arrFldSet.Contains(convgs_PTopicObjectiveRela.PaperId, new clsStrCompareIgnoreCase())  ==  true)
{
objvgs_PTopicObjectiveRelaEN.PaperId = objvgs_PTopicObjectiveRelaEN.PaperId; //论文Id
}
if (arrFldSet.Contains(convgs_PTopicObjectiveRela.PaperTitle, new clsStrCompareIgnoreCase())  ==  true)
{
objvgs_PTopicObjectiveRelaEN.PaperTitle = objvgs_PTopicObjectiveRelaEN.PaperTitle == "[null]" ? null :  objvgs_PTopicObjectiveRelaEN.PaperTitle; //论文标题
}
if (arrFldSet.Contains(convgs_PTopicObjectiveRela.PaperTypeId, new clsStrCompareIgnoreCase())  ==  true)
{
objvgs_PTopicObjectiveRelaEN.PaperTypeId = objvgs_PTopicObjectiveRelaEN.PaperTypeId == "[null]" ? null :  objvgs_PTopicObjectiveRelaEN.PaperTypeId; //论文类型Id
}
if (arrFldSet.Contains(convgs_PTopicObjectiveRela.SectionId, new clsStrCompareIgnoreCase())  ==  true)
{
objvgs_PTopicObjectiveRelaEN.SectionId = objvgs_PTopicObjectiveRelaEN.SectionId == "[null]" ? null :  objvgs_PTopicObjectiveRelaEN.SectionId; //节Id
}
if (arrFldSet.Contains(convgs_PTopicObjectiveRela.SectionName, new clsStrCompareIgnoreCase())  ==  true)
{
objvgs_PTopicObjectiveRelaEN.SectionName = objvgs_PTopicObjectiveRelaEN.SectionName == "[null]" ? null :  objvgs_PTopicObjectiveRelaEN.SectionName; //节名
}
if (arrFldSet.Contains(convgs_PTopicObjectiveRela.TopicObjectiveId, new clsStrCompareIgnoreCase())  ==  true)
{
objvgs_PTopicObjectiveRelaEN.TopicObjectiveId = objvgs_PTopicObjectiveRelaEN.TopicObjectiveId; //客观Id
}
if (arrFldSet.Contains(convgs_PTopicObjectiveRela.ObjectiveName, new clsStrCompareIgnoreCase())  ==  true)
{
objvgs_PTopicObjectiveRelaEN.ObjectiveName = objvgs_PTopicObjectiveRelaEN.ObjectiveName == "[null]" ? null :  objvgs_PTopicObjectiveRelaEN.ObjectiveName; //客观名称
}
if (arrFldSet.Contains(convgs_PTopicObjectiveRela.ObjectiveContent, new clsStrCompareIgnoreCase())  ==  true)
{
objvgs_PTopicObjectiveRelaEN.ObjectiveContent = objvgs_PTopicObjectiveRelaEN.ObjectiveContent == "[null]" ? null :  objvgs_PTopicObjectiveRelaEN.ObjectiveContent; //客观内容
}
if (arrFldSet.Contains(convgs_PTopicObjectiveRela.ObjectiveType, new clsStrCompareIgnoreCase())  ==  true)
{
objvgs_PTopicObjectiveRelaEN.ObjectiveType = objvgs_PTopicObjectiveRelaEN.ObjectiveType == "[null]" ? null :  objvgs_PTopicObjectiveRelaEN.ObjectiveType; //客观类型
}
if (arrFldSet.Contains(convgs_PTopicObjectiveRela.IsSubmit, new clsStrCompareIgnoreCase())  ==  true)
{
objvgs_PTopicObjectiveRelaEN.IsSubmit = objvgs_PTopicObjectiveRelaEN.IsSubmit; //是否提交
}
if (arrFldSet.Contains(convgs_PTopicObjectiveRela.ObjectiveTypeName, new clsStrCompareIgnoreCase())  ==  true)
{
objvgs_PTopicObjectiveRelaEN.ObjectiveTypeName = objvgs_PTopicObjectiveRelaEN.ObjectiveTypeName == "[null]" ? null :  objvgs_PTopicObjectiveRelaEN.ObjectiveTypeName; //ObjectiveTypeName
}
if (arrFldSet.Contains(convgs_PTopicObjectiveRela.TeaScore, new clsStrCompareIgnoreCase())  ==  true)
{
objvgs_PTopicObjectiveRelaEN.TeaScore = objvgs_PTopicObjectiveRelaEN.TeaScore; //教师评分
}
if (arrFldSet.Contains(convgs_PTopicObjectiveRela.StuScore, new clsStrCompareIgnoreCase())  ==  true)
{
objvgs_PTopicObjectiveRelaEN.StuScore = objvgs_PTopicObjectiveRelaEN.StuScore; //学生平均分
}
if (arrFldSet.Contains(convgs_PTopicObjectiveRela.Score, new clsStrCompareIgnoreCase())  ==  true)
{
objvgs_PTopicObjectiveRelaEN.Score = objvgs_PTopicObjectiveRelaEN.Score; //评分
}
if (arrFldSet.Contains(convgs_PTopicObjectiveRela.AppraiseCount, new clsStrCompareIgnoreCase())  ==  true)
{
objvgs_PTopicObjectiveRelaEN.AppraiseCount = objvgs_PTopicObjectiveRelaEN.AppraiseCount; //评论数
}
if (arrFldSet.Contains(convgs_PTopicObjectiveRela.OkCount, new clsStrCompareIgnoreCase())  ==  true)
{
objvgs_PTopicObjectiveRelaEN.OkCount = objvgs_PTopicObjectiveRelaEN.OkCount; //点赞统计
}
if (arrFldSet.Contains(convgs_PTopicObjectiveRela.VersionCount, new clsStrCompareIgnoreCase())  ==  true)
{
objvgs_PTopicObjectiveRelaEN.VersionCount = objvgs_PTopicObjectiveRelaEN.VersionCount; //版本统计
}
if (arrFldSet.Contains(convgs_PTopicObjectiveRela.CitationCount, new clsStrCompareIgnoreCase())  ==  true)
{
objvgs_PTopicObjectiveRelaEN.CitationCount = objvgs_PTopicObjectiveRelaEN.CitationCount; //引用统计
}
if (arrFldSet.Contains(convgs_PTopicObjectiveRela.UpdDate, new clsStrCompareIgnoreCase())  ==  true)
{
objvgs_PTopicObjectiveRelaEN.UpdDate = objvgs_PTopicObjectiveRelaEN.UpdDate == "[null]" ? null :  objvgs_PTopicObjectiveRelaEN.UpdDate; //修改日期
}
if (arrFldSet.Contains(convgs_PTopicObjectiveRela.UpdUser, new clsStrCompareIgnoreCase())  ==  true)
{
objvgs_PTopicObjectiveRelaEN.UpdUser = objvgs_PTopicObjectiveRelaEN.UpdUser == "[null]" ? null :  objvgs_PTopicObjectiveRelaEN.UpdUser; //修改人
}
if (arrFldSet.Contains(convgs_PTopicObjectiveRela.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objvgs_PTopicObjectiveRelaEN.Memo = objvgs_PTopicObjectiveRelaEN.Memo == "[null]" ? null :  objvgs_PTopicObjectiveRelaEN.Memo; //备注
}
if (arrFldSet.Contains(convgs_PTopicObjectiveRela.ObjUserId, new clsStrCompareIgnoreCase())  ==  true)
{
objvgs_PTopicObjectiveRelaEN.ObjUserId = objvgs_PTopicObjectiveRelaEN.ObjUserId == "[null]" ? null :  objvgs_PTopicObjectiveRelaEN.ObjUserId; //ObjUserId
}
if (arrFldSet.Contains(convgs_PTopicObjectiveRela.ObjDate, new clsStrCompareIgnoreCase())  ==  true)
{
objvgs_PTopicObjectiveRelaEN.ObjDate = objvgs_PTopicObjectiveRelaEN.ObjDate == "[null]" ? null :  objvgs_PTopicObjectiveRelaEN.ObjDate; //ObjDate
}
if (arrFldSet.Contains(convgs_PTopicObjectiveRela.Conclusion, new clsStrCompareIgnoreCase())  ==  true)
{
objvgs_PTopicObjectiveRelaEN.Conclusion = objvgs_PTopicObjectiveRelaEN.Conclusion == "[null]" ? null :  objvgs_PTopicObjectiveRelaEN.Conclusion; //结论
}
if (arrFldSet.Contains(convgs_PTopicObjectiveRela.CreateDate, new clsStrCompareIgnoreCase())  ==  true)
{
objvgs_PTopicObjectiveRelaEN.CreateDate = objvgs_PTopicObjectiveRelaEN.CreateDate == "[null]" ? null :  objvgs_PTopicObjectiveRelaEN.CreateDate; //建立日期
}
if (arrFldSet.Contains(convgs_PTopicObjectiveRela.ShareId, new clsStrCompareIgnoreCase())  ==  true)
{
objvgs_PTopicObjectiveRelaEN.ShareId = objvgs_PTopicObjectiveRelaEN.ShareId == "[null]" ? null :  objvgs_PTopicObjectiveRelaEN.ShareId; //分享Id
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
 /// <param name = "objvgs_PTopicObjectiveRelaEN">源简化对象</param>
 public static void AccessFldValueNull(clsvgs_PTopicObjectiveRelaEN objvgs_PTopicObjectiveRelaEN)
{
try
{
if (objvgs_PTopicObjectiveRelaEN.PaperTitle == "[null]") objvgs_PTopicObjectiveRelaEN.PaperTitle = null; //论文标题
if (objvgs_PTopicObjectiveRelaEN.PaperTypeId == "[null]") objvgs_PTopicObjectiveRelaEN.PaperTypeId = null; //论文类型Id
if (objvgs_PTopicObjectiveRelaEN.SectionId == "[null]") objvgs_PTopicObjectiveRelaEN.SectionId = null; //节Id
if (objvgs_PTopicObjectiveRelaEN.SectionName == "[null]") objvgs_PTopicObjectiveRelaEN.SectionName = null; //节名
if (objvgs_PTopicObjectiveRelaEN.ObjectiveName == "[null]") objvgs_PTopicObjectiveRelaEN.ObjectiveName = null; //客观名称
if (objvgs_PTopicObjectiveRelaEN.ObjectiveContent == "[null]") objvgs_PTopicObjectiveRelaEN.ObjectiveContent = null; //客观内容
if (objvgs_PTopicObjectiveRelaEN.ObjectiveType == "[null]") objvgs_PTopicObjectiveRelaEN.ObjectiveType = null; //客观类型
if (objvgs_PTopicObjectiveRelaEN.ObjectiveTypeName == "[null]") objvgs_PTopicObjectiveRelaEN.ObjectiveTypeName = null; //ObjectiveTypeName
if (objvgs_PTopicObjectiveRelaEN.UpdDate == "[null]") objvgs_PTopicObjectiveRelaEN.UpdDate = null; //修改日期
if (objvgs_PTopicObjectiveRelaEN.UpdUser == "[null]") objvgs_PTopicObjectiveRelaEN.UpdUser = null; //修改人
if (objvgs_PTopicObjectiveRelaEN.Memo == "[null]") objvgs_PTopicObjectiveRelaEN.Memo = null; //备注
if (objvgs_PTopicObjectiveRelaEN.ObjUserId == "[null]") objvgs_PTopicObjectiveRelaEN.ObjUserId = null; //ObjUserId
if (objvgs_PTopicObjectiveRelaEN.ObjDate == "[null]") objvgs_PTopicObjectiveRelaEN.ObjDate = null; //ObjDate
if (objvgs_PTopicObjectiveRelaEN.Conclusion == "[null]") objvgs_PTopicObjectiveRelaEN.Conclusion = null; //结论
if (objvgs_PTopicObjectiveRelaEN.CreateDate == "[null]") objvgs_PTopicObjectiveRelaEN.CreateDate = null; //建立日期
if (objvgs_PTopicObjectiveRelaEN.ShareId == "[null]") objvgs_PTopicObjectiveRelaEN.ShareId = null; //分享Id
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
public static void CheckProperty4Condition(clsvgs_PTopicObjectiveRelaEN objvgs_PTopicObjectiveRelaEN)
{
 vgs_PTopicObjectiveRelaDA.CheckProperty4Condition(objvgs_PTopicObjectiveRelaEN);
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
if (clsPaperBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsPaperBL没有刷新缓存机制(clsPaperBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsSectionBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsSectionBL没有刷新缓存机制(clsSectionBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsgs_PTopicObjectiveRelaBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsgs_PTopicObjectiveRelaBL没有刷新缓存机制(clsgs_PTopicObjectiveRelaBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsTopicObjectiveBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsTopicObjectiveBL没有刷新缓存机制(clsTopicObjectiveBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by mId");
//if (arrvgs_PTopicObjectiveRelaObjLstCache == null)
//{
//arrvgs_PTopicObjectiveRelaObjLstCache = vgs_PTopicObjectiveRelaDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "lngmId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvgs_PTopicObjectiveRelaEN GetObjBymIdCache(long lngmId)
{
//获取缓存中的对象列表
string strKey = string.Format("{0}", clsvgs_PTopicObjectiveRelaEN._CurrTabName);
List<clsvgs_PTopicObjectiveRelaEN> arrvgs_PTopicObjectiveRelaObjLstCache = GetObjLstCache();
IEnumerable <clsvgs_PTopicObjectiveRelaEN> arrvgs_PTopicObjectiveRelaObjLst_Sel =
arrvgs_PTopicObjectiveRelaObjLstCache
.Where(x=> x.mId == lngmId 
);
if (arrvgs_PTopicObjectiveRelaObjLst_Sel.Count() == 0)
{
   clsvgs_PTopicObjectiveRelaEN obj = clsvgs_PTopicObjectiveRelaBL.GetObjBymId(lngmId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
 }
return null;
}
return arrvgs_PTopicObjectiveRelaObjLst_Sel.First();
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvgs_PTopicObjectiveRelaEN> GetAllvgs_PTopicObjectiveRelaObjLstCache()
{
//获取缓存中的对象列表
List<clsvgs_PTopicObjectiveRelaEN> arrvgs_PTopicObjectiveRelaObjLstCache = GetObjLstCache(); 
return arrvgs_PTopicObjectiveRelaObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvgs_PTopicObjectiveRelaEN> GetObjLstCache()
{
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}", clsvgs_PTopicObjectiveRelaEN._CurrTabName);
List<clsvgs_PTopicObjectiveRelaEN> arrvgs_PTopicObjectiveRelaObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrvgs_PTopicObjectiveRelaObjLstCache;
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
string strKey = string.Format("{0}", clsvgs_PTopicObjectiveRelaEN._CurrTabName);
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
public static string Func(string strInFldName, string strOutFldName, long lngmId)
{
if (strInFldName != convgs_PTopicObjectiveRela.mId)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (convgs_PTopicObjectiveRela.AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", convgs_PTopicObjectiveRela.AttributeName));
throw new Exception(strMsg);
}
var objvgs_PTopicObjectiveRela = clsvgs_PTopicObjectiveRelaBL.GetObjBymIdCache(lngmId);
if (objvgs_PTopicObjectiveRela == null) return "";
return objvgs_PTopicObjectiveRela[strOutFldName].ToString();
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
int intRecCount = clsvgs_PTopicObjectiveRelaDA.GetRecCount(strTabName);
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
int intRecCount = clsvgs_PTopicObjectiveRelaDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsvgs_PTopicObjectiveRelaDA.GetRecCount();
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
int intRecCount = clsvgs_PTopicObjectiveRelaDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objvgs_PTopicObjectiveRelaCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsvgs_PTopicObjectiveRelaEN objvgs_PTopicObjectiveRelaCond)
{
List<clsvgs_PTopicObjectiveRelaEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsvgs_PTopicObjectiveRelaEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convgs_PTopicObjectiveRela.AttributeName)
{
if (objvgs_PTopicObjectiveRelaCond.IsUpdated(strFldName) == false) continue;
if (objvgs_PTopicObjectiveRelaCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvgs_PTopicObjectiveRelaCond[strFldName].ToString());
}
else
{
if (objvgs_PTopicObjectiveRelaCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvgs_PTopicObjectiveRelaCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvgs_PTopicObjectiveRelaCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvgs_PTopicObjectiveRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvgs_PTopicObjectiveRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvgs_PTopicObjectiveRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvgs_PTopicObjectiveRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvgs_PTopicObjectiveRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvgs_PTopicObjectiveRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvgs_PTopicObjectiveRelaCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvgs_PTopicObjectiveRelaCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvgs_PTopicObjectiveRelaCond[strFldName]));
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
 List<string> arrList = clsvgs_PTopicObjectiveRelaDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = vgs_PTopicObjectiveRelaDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = vgs_PTopicObjectiveRelaDA.GetFldValueNoDistinct(strFldName, strWhereCond);
return arrList;
}



 #endregion 表操作常用函数
}
}