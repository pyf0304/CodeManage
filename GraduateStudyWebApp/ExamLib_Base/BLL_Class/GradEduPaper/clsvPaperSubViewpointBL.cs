
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvPaperSubViewpointBL
 表名:vPaperSubViewpoint(01120551)
 * 版本:2024.02.19.1(服务器:WIN-SRV103-116)
 日期:2024/02/27 16:21:45
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:研究生学习游戏化后台(变量首字母不限定)-WebApi函数集
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
public static class  clsvPaperSubViewpointBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "lngSubViewpointId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvPaperSubViewpointEN GetObj(this K_SubViewpointId_vPaperSubViewpoint myKey)
{
clsvPaperSubViewpointEN objvPaperSubViewpointEN = clsvPaperSubViewpointBL.vPaperSubViewpointDA.GetObjBySubViewpointId(myKey.Value);
return objvPaperSubViewpointEN;
}

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPaperSubViewpointEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPaperSubViewpointEN SetSubViewpointId(this clsvPaperSubViewpointEN objvPaperSubViewpointEN, long lngSubViewpointId, string strComparisonOp="")
	{
objvPaperSubViewpointEN.SubViewpointId = lngSubViewpointId; //子观点Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPaperSubViewpointEN.dicFldComparisonOp.ContainsKey(convPaperSubViewpoint.SubViewpointId) == false)
{
objvPaperSubViewpointEN.dicFldComparisonOp.Add(convPaperSubViewpoint.SubViewpointId, strComparisonOp);
}
else
{
objvPaperSubViewpointEN.dicFldComparisonOp[convPaperSubViewpoint.SubViewpointId] = strComparisonOp;
}
}
return objvPaperSubViewpointEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPaperSubViewpointEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPaperSubViewpointEN SetSubViewpointContent(this clsvPaperSubViewpointEN objvPaperSubViewpointEN, string strSubViewpointContent, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strSubViewpointContent, 500, convPaperSubViewpoint.SubViewpointContent);
}
objvPaperSubViewpointEN.SubViewpointContent = strSubViewpointContent; //详情内容
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPaperSubViewpointEN.dicFldComparisonOp.ContainsKey(convPaperSubViewpoint.SubViewpointContent) == false)
{
objvPaperSubViewpointEN.dicFldComparisonOp.Add(convPaperSubViewpoint.SubViewpointContent, strComparisonOp);
}
else
{
objvPaperSubViewpointEN.dicFldComparisonOp[convPaperSubViewpoint.SubViewpointContent] = strComparisonOp;
}
}
return objvPaperSubViewpointEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPaperSubViewpointEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPaperSubViewpointEN SetPaperRWId(this clsvPaperSubViewpointEN objvPaperSubViewpointEN, string strPaperRWId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPaperRWId, 8, convPaperSubViewpoint.PaperRWId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strPaperRWId, 8, convPaperSubViewpoint.PaperRWId);
}
objvPaperSubViewpointEN.PaperRWId = strPaperRWId; //课文阅读
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPaperSubViewpointEN.dicFldComparisonOp.ContainsKey(convPaperSubViewpoint.PaperRWId) == false)
{
objvPaperSubViewpointEN.dicFldComparisonOp.Add(convPaperSubViewpoint.PaperRWId, strComparisonOp);
}
else
{
objvPaperSubViewpointEN.dicFldComparisonOp[convPaperSubViewpoint.PaperRWId] = strComparisonOp;
}
}
return objvPaperSubViewpointEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPaperSubViewpointEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPaperSubViewpointEN SetPaperId(this clsvPaperSubViewpointEN objvPaperSubViewpointEN, string strPaperId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPaperId, 8, convPaperSubViewpoint.PaperId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strPaperId, 8, convPaperSubViewpoint.PaperId);
}
objvPaperSubViewpointEN.PaperId = strPaperId; //论文Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPaperSubViewpointEN.dicFldComparisonOp.ContainsKey(convPaperSubViewpoint.PaperId) == false)
{
objvPaperSubViewpointEN.dicFldComparisonOp.Add(convPaperSubViewpoint.PaperId, strComparisonOp);
}
else
{
objvPaperSubViewpointEN.dicFldComparisonOp[convPaperSubViewpoint.PaperId] = strComparisonOp;
}
}
return objvPaperSubViewpointEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPaperSubViewpointEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPaperSubViewpointEN SetPaperTitle(this clsvPaperSubViewpointEN objvPaperSubViewpointEN, string strPaperTitle, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPaperTitle, 500, convPaperSubViewpoint.PaperTitle);
}
objvPaperSubViewpointEN.PaperTitle = strPaperTitle; //论文标题
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPaperSubViewpointEN.dicFldComparisonOp.ContainsKey(convPaperSubViewpoint.PaperTitle) == false)
{
objvPaperSubViewpointEN.dicFldComparisonOp.Add(convPaperSubViewpoint.PaperTitle, strComparisonOp);
}
else
{
objvPaperSubViewpointEN.dicFldComparisonOp[convPaperSubViewpoint.PaperTitle] = strComparisonOp;
}
}
return objvPaperSubViewpointEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPaperSubViewpointEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPaperSubViewpointEN SetIsSubmit(this clsvPaperSubViewpointEN objvPaperSubViewpointEN, bool bolIsSubmit, string strComparisonOp="")
	{
objvPaperSubViewpointEN.IsSubmit = bolIsSubmit; //是否提交
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPaperSubViewpointEN.dicFldComparisonOp.ContainsKey(convPaperSubViewpoint.IsSubmit) == false)
{
objvPaperSubViewpointEN.dicFldComparisonOp.Add(convPaperSubViewpoint.IsSubmit, strComparisonOp);
}
else
{
objvPaperSubViewpointEN.dicFldComparisonOp[convPaperSubViewpoint.IsSubmit] = strComparisonOp;
}
}
return objvPaperSubViewpointEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPaperSubViewpointEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPaperSubViewpointEN SetIdCurrEduCls(this clsvPaperSubViewpointEN objvPaperSubViewpointEN, string strIdCurrEduCls, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strIdCurrEduCls, convPaperSubViewpoint.IdCurrEduCls);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdCurrEduCls, 8, convPaperSubViewpoint.IdCurrEduCls);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdCurrEduCls, 8, convPaperSubViewpoint.IdCurrEduCls);
}
objvPaperSubViewpointEN.IdCurrEduCls = strIdCurrEduCls; //教学班流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPaperSubViewpointEN.dicFldComparisonOp.ContainsKey(convPaperSubViewpoint.IdCurrEduCls) == false)
{
objvPaperSubViewpointEN.dicFldComparisonOp.Add(convPaperSubViewpoint.IdCurrEduCls, strComparisonOp);
}
else
{
objvPaperSubViewpointEN.dicFldComparisonOp[convPaperSubViewpoint.IdCurrEduCls] = strComparisonOp;
}
}
return objvPaperSubViewpointEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPaperSubViewpointEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPaperSubViewpointEN SetUserId(this clsvPaperSubViewpointEN objvPaperSubViewpointEN, string strUserId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strUserId, convPaperSubViewpoint.UserId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUserId, 18, convPaperSubViewpoint.UserId);
}
objvPaperSubViewpointEN.UserId = strUserId; //用户ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPaperSubViewpointEN.dicFldComparisonOp.ContainsKey(convPaperSubViewpoint.UserId) == false)
{
objvPaperSubViewpointEN.dicFldComparisonOp.Add(convPaperSubViewpoint.UserId, strComparisonOp);
}
else
{
objvPaperSubViewpointEN.dicFldComparisonOp[convPaperSubViewpoint.UserId] = strComparisonOp;
}
}
return objvPaperSubViewpointEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPaperSubViewpointEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPaperSubViewpointEN SetSectionId(this clsvPaperSubViewpointEN objvPaperSubViewpointEN, string strSectionId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strSectionId, 8, convPaperSubViewpoint.SectionId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strSectionId, 8, convPaperSubViewpoint.SectionId);
}
objvPaperSubViewpointEN.SectionId = strSectionId; //节Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPaperSubViewpointEN.dicFldComparisonOp.ContainsKey(convPaperSubViewpoint.SectionId) == false)
{
objvPaperSubViewpointEN.dicFldComparisonOp.Add(convPaperSubViewpoint.SectionId, strComparisonOp);
}
else
{
objvPaperSubViewpointEN.dicFldComparisonOp[convPaperSubViewpoint.SectionId] = strComparisonOp;
}
}
return objvPaperSubViewpointEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPaperSubViewpointEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPaperSubViewpointEN SetSectionName(this clsvPaperSubViewpointEN objvPaperSubViewpointEN, string strSectionName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strSectionName, 100, convPaperSubViewpoint.SectionName);
}
objvPaperSubViewpointEN.SectionName = strSectionName; //节名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPaperSubViewpointEN.dicFldComparisonOp.ContainsKey(convPaperSubViewpoint.SectionName) == false)
{
objvPaperSubViewpointEN.dicFldComparisonOp.Add(convPaperSubViewpoint.SectionName, strComparisonOp);
}
else
{
objvPaperSubViewpointEN.dicFldComparisonOp[convPaperSubViewpoint.SectionName] = strComparisonOp;
}
}
return objvPaperSubViewpointEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPaperSubViewpointEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPaperSubViewpointEN SetSubViewpointTypeId(this clsvPaperSubViewpointEN objvPaperSubViewpointEN, string strSubViewpointTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strSubViewpointTypeId, convPaperSubViewpoint.SubViewpointTypeId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strSubViewpointTypeId, 8, convPaperSubViewpoint.SubViewpointTypeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strSubViewpointTypeId, 8, convPaperSubViewpoint.SubViewpointTypeId);
}
objvPaperSubViewpointEN.SubViewpointTypeId = strSubViewpointTypeId; //类型Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPaperSubViewpointEN.dicFldComparisonOp.ContainsKey(convPaperSubViewpoint.SubViewpointTypeId) == false)
{
objvPaperSubViewpointEN.dicFldComparisonOp.Add(convPaperSubViewpoint.SubViewpointTypeId, strComparisonOp);
}
else
{
objvPaperSubViewpointEN.dicFldComparisonOp[convPaperSubViewpoint.SubViewpointTypeId] = strComparisonOp;
}
}
return objvPaperSubViewpointEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPaperSubViewpointEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPaperSubViewpointEN SetSubViewpointTypeName(this clsvPaperSubViewpointEN objvPaperSubViewpointEN, string strSubViewpointTypeName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strSubViewpointTypeName, 50, convPaperSubViewpoint.SubViewpointTypeName);
}
objvPaperSubViewpointEN.SubViewpointTypeName = strSubViewpointTypeName; //类型名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPaperSubViewpointEN.dicFldComparisonOp.ContainsKey(convPaperSubViewpoint.SubViewpointTypeName) == false)
{
objvPaperSubViewpointEN.dicFldComparisonOp.Add(convPaperSubViewpoint.SubViewpointTypeName, strComparisonOp);
}
else
{
objvPaperSubViewpointEN.dicFldComparisonOp[convPaperSubViewpoint.SubViewpointTypeName] = strComparisonOp;
}
}
return objvPaperSubViewpointEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPaperSubViewpointEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPaperSubViewpointEN SetDefaTitle(this clsvPaperSubViewpointEN objvPaperSubViewpointEN, string strDefaTitle, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strDefaTitle, 20, convPaperSubViewpoint.DefaTitle);
}
objvPaperSubViewpointEN.DefaTitle = strDefaTitle; //默认标题
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPaperSubViewpointEN.dicFldComparisonOp.ContainsKey(convPaperSubViewpoint.DefaTitle) == false)
{
objvPaperSubViewpointEN.dicFldComparisonOp.Add(convPaperSubViewpoint.DefaTitle, strComparisonOp);
}
else
{
objvPaperSubViewpointEN.dicFldComparisonOp[convPaperSubViewpoint.DefaTitle] = strComparisonOp;
}
}
return objvPaperSubViewpointEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPaperSubViewpointEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPaperSubViewpointEN SetgsKnowledgeTypeId(this clsvPaperSubViewpointEN objvPaperSubViewpointEN, string strgsKnowledgeTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strgsKnowledgeTypeId, convPaperSubViewpoint.gsKnowledgeTypeId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strgsKnowledgeTypeId, 2, convPaperSubViewpoint.gsKnowledgeTypeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strgsKnowledgeTypeId, 2, convPaperSubViewpoint.gsKnowledgeTypeId);
}
objvPaperSubViewpointEN.gsKnowledgeTypeId = strgsKnowledgeTypeId; //知识类型Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPaperSubViewpointEN.dicFldComparisonOp.ContainsKey(convPaperSubViewpoint.gsKnowledgeTypeId) == false)
{
objvPaperSubViewpointEN.dicFldComparisonOp.Add(convPaperSubViewpoint.gsKnowledgeTypeId, strComparisonOp);
}
else
{
objvPaperSubViewpointEN.dicFldComparisonOp[convPaperSubViewpoint.gsKnowledgeTypeId] = strComparisonOp;
}
}
return objvPaperSubViewpointEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPaperSubViewpointEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPaperSubViewpointEN SetRWTitle(this clsvPaperSubViewpointEN objvPaperSubViewpointEN, string strRWTitle, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strRWTitle, 50, convPaperSubViewpoint.RWTitle);
}
objvPaperSubViewpointEN.RWTitle = strRWTitle; //读写标题
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPaperSubViewpointEN.dicFldComparisonOp.ContainsKey(convPaperSubViewpoint.RWTitle) == false)
{
objvPaperSubViewpointEN.dicFldComparisonOp.Add(convPaperSubViewpoint.RWTitle, strComparisonOp);
}
else
{
objvPaperSubViewpointEN.dicFldComparisonOp[convPaperSubViewpoint.RWTitle] = strComparisonOp;
}
}
return objvPaperSubViewpointEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPaperSubViewpointEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPaperSubViewpointEN SetExplainTypeId(this clsvPaperSubViewpointEN objvPaperSubViewpointEN, string strExplainTypeId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strExplainTypeId, 2, convPaperSubViewpoint.ExplainTypeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strExplainTypeId, 2, convPaperSubViewpoint.ExplainTypeId);
}
objvPaperSubViewpointEN.ExplainTypeId = strExplainTypeId; //说明类型Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPaperSubViewpointEN.dicFldComparisonOp.ContainsKey(convPaperSubViewpoint.ExplainTypeId) == false)
{
objvPaperSubViewpointEN.dicFldComparisonOp.Add(convPaperSubViewpoint.ExplainTypeId, strComparisonOp);
}
else
{
objvPaperSubViewpointEN.dicFldComparisonOp[convPaperSubViewpoint.ExplainTypeId] = strComparisonOp;
}
}
return objvPaperSubViewpointEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPaperSubViewpointEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPaperSubViewpointEN SetExplainTypeName(this clsvPaperSubViewpointEN objvPaperSubViewpointEN, string strExplainTypeName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strExplainTypeName, 50, convPaperSubViewpoint.ExplainTypeName);
}
objvPaperSubViewpointEN.ExplainTypeName = strExplainTypeName; //说明类型名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPaperSubViewpointEN.dicFldComparisonOp.ContainsKey(convPaperSubViewpoint.ExplainTypeName) == false)
{
objvPaperSubViewpointEN.dicFldComparisonOp.Add(convPaperSubViewpoint.ExplainTypeName, strComparisonOp);
}
else
{
objvPaperSubViewpointEN.dicFldComparisonOp[convPaperSubViewpoint.ExplainTypeName] = strComparisonOp;
}
}
return objvPaperSubViewpointEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPaperSubViewpointEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPaperSubViewpointEN SetExplainContent(this clsvPaperSubViewpointEN objvPaperSubViewpointEN, string strExplainContent, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strExplainContent, 5000, convPaperSubViewpoint.ExplainContent);
}
objvPaperSubViewpointEN.ExplainContent = strExplainContent; //说明内容
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPaperSubViewpointEN.dicFldComparisonOp.ContainsKey(convPaperSubViewpoint.ExplainContent) == false)
{
objvPaperSubViewpointEN.dicFldComparisonOp.Add(convPaperSubViewpoint.ExplainContent, strComparisonOp);
}
else
{
objvPaperSubViewpointEN.dicFldComparisonOp[convPaperSubViewpoint.ExplainContent] = strComparisonOp;
}
}
return objvPaperSubViewpointEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPaperSubViewpointEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPaperSubViewpointEN SetIsPublic(this clsvPaperSubViewpointEN objvPaperSubViewpointEN, bool bolIsPublic, string strComparisonOp="")
	{
objvPaperSubViewpointEN.IsPublic = bolIsPublic; //是否公开
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPaperSubViewpointEN.dicFldComparisonOp.ContainsKey(convPaperSubViewpoint.IsPublic) == false)
{
objvPaperSubViewpointEN.dicFldComparisonOp.Add(convPaperSubViewpoint.IsPublic, strComparisonOp);
}
else
{
objvPaperSubViewpointEN.dicFldComparisonOp[convPaperSubViewpoint.IsPublic] = strComparisonOp;
}
}
return objvPaperSubViewpointEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPaperSubViewpointEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPaperSubViewpointEN SetLiteratureSourcesId(this clsvPaperSubViewpointEN objvPaperSubViewpointEN, string strLiteratureSourcesId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strLiteratureSourcesId, 8, convPaperSubViewpoint.LiteratureSourcesId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strLiteratureSourcesId, 8, convPaperSubViewpoint.LiteratureSourcesId);
}
objvPaperSubViewpointEN.LiteratureSourcesId = strLiteratureSourcesId; //文献来源
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPaperSubViewpointEN.dicFldComparisonOp.ContainsKey(convPaperSubViewpoint.LiteratureSourcesId) == false)
{
objvPaperSubViewpointEN.dicFldComparisonOp.Add(convPaperSubViewpoint.LiteratureSourcesId, strComparisonOp);
}
else
{
objvPaperSubViewpointEN.dicFldComparisonOp[convPaperSubViewpoint.LiteratureSourcesId] = strComparisonOp;
}
}
return objvPaperSubViewpointEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPaperSubViewpointEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPaperSubViewpointEN SetOperationTypeId(this clsvPaperSubViewpointEN objvPaperSubViewpointEN, string strOperationTypeId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strOperationTypeId, 4, convPaperSubViewpoint.OperationTypeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strOperationTypeId, 4, convPaperSubViewpoint.OperationTypeId);
}
objvPaperSubViewpointEN.OperationTypeId = strOperationTypeId; //操作类型ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPaperSubViewpointEN.dicFldComparisonOp.ContainsKey(convPaperSubViewpoint.OperationTypeId) == false)
{
objvPaperSubViewpointEN.dicFldComparisonOp.Add(convPaperSubViewpoint.OperationTypeId, strComparisonOp);
}
else
{
objvPaperSubViewpointEN.dicFldComparisonOp[convPaperSubViewpoint.OperationTypeId] = strComparisonOp;
}
}
return objvPaperSubViewpointEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPaperSubViewpointEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPaperSubViewpointEN SetLevelId(this clsvPaperSubViewpointEN objvPaperSubViewpointEN, string strLevelId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strLevelId, 2, convPaperSubViewpoint.LevelId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strLevelId, 2, convPaperSubViewpoint.LevelId);
}
objvPaperSubViewpointEN.LevelId = strLevelId; //级别Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPaperSubViewpointEN.dicFldComparisonOp.ContainsKey(convPaperSubViewpoint.LevelId) == false)
{
objvPaperSubViewpointEN.dicFldComparisonOp.Add(convPaperSubViewpoint.LevelId, strComparisonOp);
}
else
{
objvPaperSubViewpointEN.dicFldComparisonOp[convPaperSubViewpoint.LevelId] = strComparisonOp;
}
}
return objvPaperSubViewpointEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPaperSubViewpointEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPaperSubViewpointEN SetConclusion(this clsvPaperSubViewpointEN objvPaperSubViewpointEN, string strConclusion, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strConclusion, 5000, convPaperSubViewpoint.Conclusion);
}
objvPaperSubViewpointEN.Conclusion = strConclusion; //结论
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPaperSubViewpointEN.dicFldComparisonOp.ContainsKey(convPaperSubViewpoint.Conclusion) == false)
{
objvPaperSubViewpointEN.dicFldComparisonOp.Add(convPaperSubViewpoint.Conclusion, strComparisonOp);
}
else
{
objvPaperSubViewpointEN.dicFldComparisonOp[convPaperSubViewpoint.Conclusion] = strComparisonOp;
}
}
return objvPaperSubViewpointEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPaperSubViewpointEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPaperSubViewpointEN SetNationality(this clsvPaperSubViewpointEN objvPaperSubViewpointEN, string strNationality, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strNationality, 50, convPaperSubViewpoint.Nationality);
}
objvPaperSubViewpointEN.Nationality = strNationality; //国籍
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPaperSubViewpointEN.dicFldComparisonOp.ContainsKey(convPaperSubViewpoint.Nationality) == false)
{
objvPaperSubViewpointEN.dicFldComparisonOp.Add(convPaperSubViewpoint.Nationality, strComparisonOp);
}
else
{
objvPaperSubViewpointEN.dicFldComparisonOp[convPaperSubViewpoint.Nationality] = strComparisonOp;
}
}
return objvPaperSubViewpointEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPaperSubViewpointEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPaperSubViewpointEN SetAchievement(this clsvPaperSubViewpointEN objvPaperSubViewpointEN, string strAchievement, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strAchievement, 5000, convPaperSubViewpoint.Achievement);
}
objvPaperSubViewpointEN.Achievement = strAchievement; //成就
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPaperSubViewpointEN.dicFldComparisonOp.ContainsKey(convPaperSubViewpoint.Achievement) == false)
{
objvPaperSubViewpointEN.dicFldComparisonOp.Add(convPaperSubViewpoint.Achievement, strComparisonOp);
}
else
{
objvPaperSubViewpointEN.dicFldComparisonOp[convPaperSubViewpoint.Achievement] = strComparisonOp;
}
}
return objvPaperSubViewpointEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPaperSubViewpointEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPaperSubViewpointEN SetMajor(this clsvPaperSubViewpointEN objvPaperSubViewpointEN, string strMajor, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMajor, 50, convPaperSubViewpoint.Major);
}
objvPaperSubViewpointEN.Major = strMajor; //专业
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPaperSubViewpointEN.dicFldComparisonOp.ContainsKey(convPaperSubViewpoint.Major) == false)
{
objvPaperSubViewpointEN.dicFldComparisonOp.Add(convPaperSubViewpoint.Major, strComparisonOp);
}
else
{
objvPaperSubViewpointEN.dicFldComparisonOp[convPaperSubViewpoint.Major] = strComparisonOp;
}
}
return objvPaperSubViewpointEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPaperSubViewpointEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPaperSubViewpointEN SetWorkUnit(this clsvPaperSubViewpointEN objvPaperSubViewpointEN, string strWorkUnit, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strWorkUnit, 100, convPaperSubViewpoint.WorkUnit);
}
objvPaperSubViewpointEN.WorkUnit = strWorkUnit; //工作单位
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPaperSubViewpointEN.dicFldComparisonOp.ContainsKey(convPaperSubViewpoint.WorkUnit) == false)
{
objvPaperSubViewpointEN.dicFldComparisonOp.Add(convPaperSubViewpoint.WorkUnit, strComparisonOp);
}
else
{
objvPaperSubViewpointEN.dicFldComparisonOp[convPaperSubViewpoint.WorkUnit] = strComparisonOp;
}
}
return objvPaperSubViewpointEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPaperSubViewpointEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPaperSubViewpointEN SetPageNumber(this clsvPaperSubViewpointEN objvPaperSubViewpointEN, int? intPageNumber, string strComparisonOp="")
	{
objvPaperSubViewpointEN.PageNumber = intPageNumber; //页码
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPaperSubViewpointEN.dicFldComparisonOp.ContainsKey(convPaperSubViewpoint.PageNumber) == false)
{
objvPaperSubViewpointEN.dicFldComparisonOp.Add(convPaperSubViewpoint.PageNumber, strComparisonOp);
}
else
{
objvPaperSubViewpointEN.dicFldComparisonOp[convPaperSubViewpoint.PageNumber] = strComparisonOp;
}
}
return objvPaperSubViewpointEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPaperSubViewpointEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPaperSubViewpointEN SetOrderNum(this clsvPaperSubViewpointEN objvPaperSubViewpointEN, int? intOrderNum, string strComparisonOp="")
	{
objvPaperSubViewpointEN.OrderNum = intOrderNum; //序号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPaperSubViewpointEN.dicFldComparisonOp.ContainsKey(convPaperSubViewpoint.OrderNum) == false)
{
objvPaperSubViewpointEN.dicFldComparisonOp.Add(convPaperSubViewpoint.OrderNum, strComparisonOp);
}
else
{
objvPaperSubViewpointEN.dicFldComparisonOp[convPaperSubViewpoint.OrderNum] = strComparisonOp;
}
}
return objvPaperSubViewpointEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPaperSubViewpointEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPaperSubViewpointEN SetPdfContent(this clsvPaperSubViewpointEN objvPaperSubViewpointEN, string strPdfContent, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPdfContent, 2000, convPaperSubViewpoint.PdfContent);
}
objvPaperSubViewpointEN.PdfContent = strPdfContent; //Pdf内容
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPaperSubViewpointEN.dicFldComparisonOp.ContainsKey(convPaperSubViewpoint.PdfContent) == false)
{
objvPaperSubViewpointEN.dicFldComparisonOp.Add(convPaperSubViewpoint.PdfContent, strComparisonOp);
}
else
{
objvPaperSubViewpointEN.dicFldComparisonOp[convPaperSubViewpoint.PdfContent] = strComparisonOp;
}
}
return objvPaperSubViewpointEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPaperSubViewpointEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPaperSubViewpointEN SetselectSpanRange(this clsvPaperSubViewpointEN objvPaperSubViewpointEN, string strselectSpanRange, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strselectSpanRange, 50, convPaperSubViewpoint.selectSpanRange);
}
objvPaperSubViewpointEN.selectSpanRange = strselectSpanRange; //选择Span范围
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPaperSubViewpointEN.dicFldComparisonOp.ContainsKey(convPaperSubViewpoint.selectSpanRange) == false)
{
objvPaperSubViewpointEN.dicFldComparisonOp.Add(convPaperSubViewpoint.selectSpanRange, strComparisonOp);
}
else
{
objvPaperSubViewpointEN.dicFldComparisonOp[convPaperSubViewpoint.selectSpanRange] = strComparisonOp;
}
}
return objvPaperSubViewpointEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPaperSubViewpointEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPaperSubViewpointEN SetPaperLineNum(this clsvPaperSubViewpointEN objvPaperSubViewpointEN, int? intPaperLineNum, string strComparisonOp="")
	{
objvPaperSubViewpointEN.PaperLineNum = intPaperLineNum; //论文行号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPaperSubViewpointEN.dicFldComparisonOp.ContainsKey(convPaperSubViewpoint.PaperLineNum) == false)
{
objvPaperSubViewpointEN.dicFldComparisonOp.Add(convPaperSubViewpoint.PaperLineNum, strComparisonOp);
}
else
{
objvPaperSubViewpointEN.dicFldComparisonOp[convPaperSubViewpoint.PaperLineNum] = strComparisonOp;
}
}
return objvPaperSubViewpointEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPaperSubViewpointEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPaperSubViewpointEN SetPaperPageNum(this clsvPaperSubViewpointEN objvPaperSubViewpointEN, int? intPaperPageNum, string strComparisonOp="")
	{
objvPaperSubViewpointEN.PaperPageNum = intPaperPageNum; //论文页码
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPaperSubViewpointEN.dicFldComparisonOp.ContainsKey(convPaperSubViewpoint.PaperPageNum) == false)
{
objvPaperSubViewpointEN.dicFldComparisonOp.Add(convPaperSubViewpoint.PaperPageNum, strComparisonOp);
}
else
{
objvPaperSubViewpointEN.dicFldComparisonOp[convPaperSubViewpoint.PaperPageNum] = strComparisonOp;
}
}
return objvPaperSubViewpointEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPaperSubViewpointEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPaperSubViewpointEN SetAppraiseCount(this clsvPaperSubViewpointEN objvPaperSubViewpointEN, int? intAppraiseCount, string strComparisonOp="")
	{
objvPaperSubViewpointEN.AppraiseCount = intAppraiseCount; //评论数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPaperSubViewpointEN.dicFldComparisonOp.ContainsKey(convPaperSubViewpoint.AppraiseCount) == false)
{
objvPaperSubViewpointEN.dicFldComparisonOp.Add(convPaperSubViewpoint.AppraiseCount, strComparisonOp);
}
else
{
objvPaperSubViewpointEN.dicFldComparisonOp[convPaperSubViewpoint.AppraiseCount] = strComparisonOp;
}
}
return objvPaperSubViewpointEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPaperSubViewpointEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPaperSubViewpointEN SetOkCount(this clsvPaperSubViewpointEN objvPaperSubViewpointEN, int? intOkCount, string strComparisonOp="")
	{
objvPaperSubViewpointEN.OkCount = intOkCount; //点赞统计
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPaperSubViewpointEN.dicFldComparisonOp.ContainsKey(convPaperSubViewpoint.OkCount) == false)
{
objvPaperSubViewpointEN.dicFldComparisonOp.Add(convPaperSubViewpoint.OkCount, strComparisonOp);
}
else
{
objvPaperSubViewpointEN.dicFldComparisonOp[convPaperSubViewpoint.OkCount] = strComparisonOp;
}
}
return objvPaperSubViewpointEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPaperSubViewpointEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPaperSubViewpointEN SetScore(this clsvPaperSubViewpointEN objvPaperSubViewpointEN, float? fltScore, string strComparisonOp="")
	{
objvPaperSubViewpointEN.Score = fltScore; //评分
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPaperSubViewpointEN.dicFldComparisonOp.ContainsKey(convPaperSubViewpoint.Score) == false)
{
objvPaperSubViewpointEN.dicFldComparisonOp.Add(convPaperSubViewpoint.Score, strComparisonOp);
}
else
{
objvPaperSubViewpointEN.dicFldComparisonOp[convPaperSubViewpoint.Score] = strComparisonOp;
}
}
return objvPaperSubViewpointEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPaperSubViewpointEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPaperSubViewpointEN SetStuScore(this clsvPaperSubViewpointEN objvPaperSubViewpointEN, float? fltStuScore, string strComparisonOp="")
	{
objvPaperSubViewpointEN.StuScore = fltStuScore; //学生平均分
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPaperSubViewpointEN.dicFldComparisonOp.ContainsKey(convPaperSubViewpoint.StuScore) == false)
{
objvPaperSubViewpointEN.dicFldComparisonOp.Add(convPaperSubViewpoint.StuScore, strComparisonOp);
}
else
{
objvPaperSubViewpointEN.dicFldComparisonOp[convPaperSubViewpoint.StuScore] = strComparisonOp;
}
}
return objvPaperSubViewpointEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPaperSubViewpointEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPaperSubViewpointEN SetTeaScore(this clsvPaperSubViewpointEN objvPaperSubViewpointEN, float? fltTeaScore, string strComparisonOp="")
	{
objvPaperSubViewpointEN.TeaScore = fltTeaScore; //教师评分
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPaperSubViewpointEN.dicFldComparisonOp.ContainsKey(convPaperSubViewpoint.TeaScore) == false)
{
objvPaperSubViewpointEN.dicFldComparisonOp.Add(convPaperSubViewpoint.TeaScore, strComparisonOp);
}
else
{
objvPaperSubViewpointEN.dicFldComparisonOp[convPaperSubViewpoint.TeaScore] = strComparisonOp;
}
}
return objvPaperSubViewpointEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPaperSubViewpointEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPaperSubViewpointEN SetCreateDate(this clsvPaperSubViewpointEN objvPaperSubViewpointEN, string strCreateDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCreateDate, 20, convPaperSubViewpoint.CreateDate);
}
objvPaperSubViewpointEN.CreateDate = strCreateDate; //建立日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPaperSubViewpointEN.dicFldComparisonOp.ContainsKey(convPaperSubViewpoint.CreateDate) == false)
{
objvPaperSubViewpointEN.dicFldComparisonOp.Add(convPaperSubViewpoint.CreateDate, strComparisonOp);
}
else
{
objvPaperSubViewpointEN.dicFldComparisonOp[convPaperSubViewpoint.CreateDate] = strComparisonOp;
}
}
return objvPaperSubViewpointEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPaperSubViewpointEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPaperSubViewpointEN SetShareId(this clsvPaperSubViewpointEN objvPaperSubViewpointEN, string strShareId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strShareId, convPaperSubViewpoint.ShareId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strShareId, 2, convPaperSubViewpoint.ShareId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strShareId, 2, convPaperSubViewpoint.ShareId);
}
objvPaperSubViewpointEN.ShareId = strShareId; //分享Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPaperSubViewpointEN.dicFldComparisonOp.ContainsKey(convPaperSubViewpoint.ShareId) == false)
{
objvPaperSubViewpointEN.dicFldComparisonOp.Add(convPaperSubViewpoint.ShareId, strComparisonOp);
}
else
{
objvPaperSubViewpointEN.dicFldComparisonOp[convPaperSubViewpoint.ShareId] = strComparisonOp;
}
}
return objvPaperSubViewpointEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPaperSubViewpointEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPaperSubViewpointEN SetAttitudesId(this clsvPaperSubViewpointEN objvPaperSubViewpointEN, string strAttitudesId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strAttitudesId, convPaperSubViewpoint.AttitudesId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strAttitudesId, 2, convPaperSubViewpoint.AttitudesId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strAttitudesId, 2, convPaperSubViewpoint.AttitudesId);
}
objvPaperSubViewpointEN.AttitudesId = strAttitudesId; //态度Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPaperSubViewpointEN.dicFldComparisonOp.ContainsKey(convPaperSubViewpoint.AttitudesId) == false)
{
objvPaperSubViewpointEN.dicFldComparisonOp.Add(convPaperSubViewpoint.AttitudesId, strComparisonOp);
}
else
{
objvPaperSubViewpointEN.dicFldComparisonOp[convPaperSubViewpoint.AttitudesId] = strComparisonOp;
}
}
return objvPaperSubViewpointEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPaperSubViewpointEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPaperSubViewpointEN SetAttitudesName(this clsvPaperSubViewpointEN objvPaperSubViewpointEN, string strAttitudesName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strAttitudesName, 200, convPaperSubViewpoint.AttitudesName);
}
objvPaperSubViewpointEN.AttitudesName = strAttitudesName; //名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPaperSubViewpointEN.dicFldComparisonOp.ContainsKey(convPaperSubViewpoint.AttitudesName) == false)
{
objvPaperSubViewpointEN.dicFldComparisonOp.Add(convPaperSubViewpoint.AttitudesName, strComparisonOp);
}
else
{
objvPaperSubViewpointEN.dicFldComparisonOp[convPaperSubViewpoint.AttitudesName] = strComparisonOp;
}
}
return objvPaperSubViewpointEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPaperSubViewpointEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPaperSubViewpointEN SetUpdDate(this clsvPaperSubViewpointEN objvPaperSubViewpointEN, string strUpdDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdDate, 20, convPaperSubViewpoint.UpdDate);
}
objvPaperSubViewpointEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPaperSubViewpointEN.dicFldComparisonOp.ContainsKey(convPaperSubViewpoint.UpdDate) == false)
{
objvPaperSubViewpointEN.dicFldComparisonOp.Add(convPaperSubViewpoint.UpdDate, strComparisonOp);
}
else
{
objvPaperSubViewpointEN.dicFldComparisonOp[convPaperSubViewpoint.UpdDate] = strComparisonOp;
}
}
return objvPaperSubViewpointEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPaperSubViewpointEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPaperSubViewpointEN SetUpdUser(this clsvPaperSubViewpointEN objvPaperSubViewpointEN, string strUpdUser, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdUser, 20, convPaperSubViewpoint.UpdUser);
}
objvPaperSubViewpointEN.UpdUser = strUpdUser; //修改人
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPaperSubViewpointEN.dicFldComparisonOp.ContainsKey(convPaperSubViewpoint.UpdUser) == false)
{
objvPaperSubViewpointEN.dicFldComparisonOp.Add(convPaperSubViewpoint.UpdUser, strComparisonOp);
}
else
{
objvPaperSubViewpointEN.dicFldComparisonOp[convPaperSubViewpoint.UpdUser] = strComparisonOp;
}
}
return objvPaperSubViewpointEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPaperSubViewpointEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPaperSubViewpointEN SetMemo(this clsvPaperSubViewpointEN objvPaperSubViewpointEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, convPaperSubViewpoint.Memo);
}
objvPaperSubViewpointEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPaperSubViewpointEN.dicFldComparisonOp.ContainsKey(convPaperSubViewpoint.Memo) == false)
{
objvPaperSubViewpointEN.dicFldComparisonOp.Add(convPaperSubViewpoint.Memo, strComparisonOp);
}
else
{
objvPaperSubViewpointEN.dicFldComparisonOp[convPaperSubViewpoint.Memo] = strComparisonOp;
}
}
return objvPaperSubViewpointEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPaperSubViewpointEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPaperSubViewpointEN SetSectionOrderNum(this clsvPaperSubViewpointEN objvPaperSubViewpointEN, int? intSectionOrderNum, string strComparisonOp="")
	{
objvPaperSubViewpointEN.SectionOrderNum = intSectionOrderNum; //SectionOrderNum
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPaperSubViewpointEN.dicFldComparisonOp.ContainsKey(convPaperSubViewpoint.SectionOrderNum) == false)
{
objvPaperSubViewpointEN.dicFldComparisonOp.Add(convPaperSubViewpoint.SectionOrderNum, strComparisonOp);
}
else
{
objvPaperSubViewpointEN.dicFldComparisonOp[convPaperSubViewpoint.SectionOrderNum] = strComparisonOp;
}
}
return objvPaperSubViewpointEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPaperSubViewpointEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPaperSubViewpointEN SetSubViewpointTypeOrderNum(this clsvPaperSubViewpointEN objvPaperSubViewpointEN, int? intSubViewpointTypeOrderNum, string strComparisonOp="")
	{
objvPaperSubViewpointEN.SubViewpointTypeOrderNum = intSubViewpointTypeOrderNum; //子观点类型序号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPaperSubViewpointEN.dicFldComparisonOp.ContainsKey(convPaperSubViewpoint.SubViewpointTypeOrderNum) == false)
{
objvPaperSubViewpointEN.dicFldComparisonOp.Add(convPaperSubViewpoint.SubViewpointTypeOrderNum, strComparisonOp);
}
else
{
objvPaperSubViewpointEN.dicFldComparisonOp[convPaperSubViewpoint.SubViewpointTypeOrderNum] = strComparisonOp;
}
}
return objvPaperSubViewpointEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPaperSubViewpointEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPaperSubViewpointEN SetCitationCount(this clsvPaperSubViewpointEN objvPaperSubViewpointEN, int? intCitationCount, string strComparisonOp="")
	{
objvPaperSubViewpointEN.CitationCount = intCitationCount; //引用统计
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPaperSubViewpointEN.dicFldComparisonOp.ContainsKey(convPaperSubViewpoint.CitationCount) == false)
{
objvPaperSubViewpointEN.dicFldComparisonOp.Add(convPaperSubViewpoint.CitationCount, strComparisonOp);
}
else
{
objvPaperSubViewpointEN.dicFldComparisonOp[convPaperSubViewpoint.CitationCount] = strComparisonOp;
}
}
return objvPaperSubViewpointEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPaperSubViewpointEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPaperSubViewpointEN SetVersionCount(this clsvPaperSubViewpointEN objvPaperSubViewpointEN, int? intVersionCount, string strComparisonOp="")
	{
objvPaperSubViewpointEN.VersionCount = intVersionCount; //版本统计
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPaperSubViewpointEN.dicFldComparisonOp.ContainsKey(convPaperSubViewpoint.VersionCount) == false)
{
objvPaperSubViewpointEN.dicFldComparisonOp.Add(convPaperSubViewpoint.VersionCount, strComparisonOp);
}
else
{
objvPaperSubViewpointEN.dicFldComparisonOp[convPaperSubViewpoint.VersionCount] = strComparisonOp;
}
}
return objvPaperSubViewpointEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPaperSubViewpointEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPaperSubViewpointEN SetIsRecommend(this clsvPaperSubViewpointEN objvPaperSubViewpointEN, bool bolIsRecommend, string strComparisonOp="")
	{
objvPaperSubViewpointEN.IsRecommend = bolIsRecommend; //是否推荐
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPaperSubViewpointEN.dicFldComparisonOp.ContainsKey(convPaperSubViewpoint.IsRecommend) == false)
{
objvPaperSubViewpointEN.dicFldComparisonOp.Add(convPaperSubViewpoint.IsRecommend, strComparisonOp);
}
else
{
objvPaperSubViewpointEN.dicFldComparisonOp[convPaperSubViewpoint.IsRecommend] = strComparisonOp;
}
}
return objvPaperSubViewpointEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPaperSubViewpointEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPaperSubViewpointEN SetgsKnowledgeTypeName(this clsvPaperSubViewpointEN objvPaperSubViewpointEN, string strgsKnowledgeTypeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strgsKnowledgeTypeName, convPaperSubViewpoint.gsKnowledgeTypeName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strgsKnowledgeTypeName, 50, convPaperSubViewpoint.gsKnowledgeTypeName);
}
objvPaperSubViewpointEN.gsKnowledgeTypeName = strgsKnowledgeTypeName; //知识类型名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPaperSubViewpointEN.dicFldComparisonOp.ContainsKey(convPaperSubViewpoint.gsKnowledgeTypeName) == false)
{
objvPaperSubViewpointEN.dicFldComparisonOp.Add(convPaperSubViewpoint.gsKnowledgeTypeName, strComparisonOp);
}
else
{
objvPaperSubViewpointEN.dicFldComparisonOp[convPaperSubViewpoint.gsKnowledgeTypeName] = strComparisonOp;
}
}
return objvPaperSubViewpointEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPaperSubViewpointEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPaperSubViewpointEN SetLevelName(this clsvPaperSubViewpointEN objvPaperSubViewpointEN, string strLevelName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strLevelName, 50, convPaperSubViewpoint.LevelName);
}
objvPaperSubViewpointEN.LevelName = strLevelName; //级别名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPaperSubViewpointEN.dicFldComparisonOp.ContainsKey(convPaperSubViewpoint.LevelName) == false)
{
objvPaperSubViewpointEN.dicFldComparisonOp.Add(convPaperSubViewpoint.LevelName, strComparisonOp);
}
else
{
objvPaperSubViewpointEN.dicFldComparisonOp[convPaperSubViewpoint.LevelName] = strComparisonOp;
}
}
return objvPaperSubViewpointEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPaperSubViewpointEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPaperSubViewpointEN SetOperationTypeName(this clsvPaperSubViewpointEN objvPaperSubViewpointEN, string strOperationTypeName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strOperationTypeName, 50, convPaperSubViewpoint.OperationTypeName);
}
objvPaperSubViewpointEN.OperationTypeName = strOperationTypeName; //操作类型名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPaperSubViewpointEN.dicFldComparisonOp.ContainsKey(convPaperSubViewpoint.OperationTypeName) == false)
{
objvPaperSubViewpointEN.dicFldComparisonOp.Add(convPaperSubViewpoint.OperationTypeName, strComparisonOp);
}
else
{
objvPaperSubViewpointEN.dicFldComparisonOp[convPaperSubViewpoint.OperationTypeName] = strComparisonOp;
}
}
return objvPaperSubViewpointEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPaperSubViewpointEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPaperSubViewpointEN SetCourseId(this clsvPaperSubViewpointEN objvPaperSubViewpointEN, string strCourseId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCourseId, 8, convPaperSubViewpoint.CourseId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strCourseId, 8, convPaperSubViewpoint.CourseId);
}
objvPaperSubViewpointEN.CourseId = strCourseId; //课程Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPaperSubViewpointEN.dicFldComparisonOp.ContainsKey(convPaperSubViewpoint.CourseId) == false)
{
objvPaperSubViewpointEN.dicFldComparisonOp.Add(convPaperSubViewpoint.CourseId, strComparisonOp);
}
else
{
objvPaperSubViewpointEN.dicFldComparisonOp[convPaperSubViewpoint.CourseId] = strComparisonOp;
}
}
return objvPaperSubViewpointEN;
	}

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CopyObj)
 /// </summary>
 /// <param name = "objvPaperSubViewpointENS">源对象</param>
 /// <param name = "objvPaperSubViewpointENT">目标对象</param>
 public static void CopyTo(this clsvPaperSubViewpointEN objvPaperSubViewpointENS, clsvPaperSubViewpointEN objvPaperSubViewpointENT)
{
try
{
objvPaperSubViewpointENT.SubViewpointId = objvPaperSubViewpointENS.SubViewpointId; //子观点Id
objvPaperSubViewpointENT.SubViewpointContent = objvPaperSubViewpointENS.SubViewpointContent; //详情内容
objvPaperSubViewpointENT.PaperRWId = objvPaperSubViewpointENS.PaperRWId; //课文阅读
objvPaperSubViewpointENT.PaperId = objvPaperSubViewpointENS.PaperId; //论文Id
objvPaperSubViewpointENT.PaperTitle = objvPaperSubViewpointENS.PaperTitle; //论文标题
objvPaperSubViewpointENT.IsSubmit = objvPaperSubViewpointENS.IsSubmit; //是否提交
objvPaperSubViewpointENT.IdCurrEduCls = objvPaperSubViewpointENS.IdCurrEduCls; //教学班流水号
objvPaperSubViewpointENT.UserId = objvPaperSubViewpointENS.UserId; //用户ID
objvPaperSubViewpointENT.SectionId = objvPaperSubViewpointENS.SectionId; //节Id
objvPaperSubViewpointENT.SectionName = objvPaperSubViewpointENS.SectionName; //节名
objvPaperSubViewpointENT.SubViewpointTypeId = objvPaperSubViewpointENS.SubViewpointTypeId; //类型Id
objvPaperSubViewpointENT.SubViewpointTypeName = objvPaperSubViewpointENS.SubViewpointTypeName; //类型名称
objvPaperSubViewpointENT.DefaTitle = objvPaperSubViewpointENS.DefaTitle; //默认标题
objvPaperSubViewpointENT.gsKnowledgeTypeId = objvPaperSubViewpointENS.gsKnowledgeTypeId; //知识类型Id
objvPaperSubViewpointENT.RWTitle = objvPaperSubViewpointENS.RWTitle; //读写标题
objvPaperSubViewpointENT.ExplainTypeId = objvPaperSubViewpointENS.ExplainTypeId; //说明类型Id
objvPaperSubViewpointENT.ExplainTypeName = objvPaperSubViewpointENS.ExplainTypeName; //说明类型名
objvPaperSubViewpointENT.ExplainContent = objvPaperSubViewpointENS.ExplainContent; //说明内容
objvPaperSubViewpointENT.IsPublic = objvPaperSubViewpointENS.IsPublic; //是否公开
objvPaperSubViewpointENT.LiteratureSourcesId = objvPaperSubViewpointENS.LiteratureSourcesId; //文献来源
objvPaperSubViewpointENT.OperationTypeId = objvPaperSubViewpointENS.OperationTypeId; //操作类型ID
objvPaperSubViewpointENT.LevelId = objvPaperSubViewpointENS.LevelId; //级别Id
objvPaperSubViewpointENT.Conclusion = objvPaperSubViewpointENS.Conclusion; //结论
objvPaperSubViewpointENT.Nationality = objvPaperSubViewpointENS.Nationality; //国籍
objvPaperSubViewpointENT.Achievement = objvPaperSubViewpointENS.Achievement; //成就
objvPaperSubViewpointENT.Major = objvPaperSubViewpointENS.Major; //专业
objvPaperSubViewpointENT.WorkUnit = objvPaperSubViewpointENS.WorkUnit; //工作单位
objvPaperSubViewpointENT.PageNumber = objvPaperSubViewpointENS.PageNumber; //页码
objvPaperSubViewpointENT.OrderNum = objvPaperSubViewpointENS.OrderNum; //序号
objvPaperSubViewpointENT.PdfContent = objvPaperSubViewpointENS.PdfContent; //Pdf内容
objvPaperSubViewpointENT.selectSpanRange = objvPaperSubViewpointENS.selectSpanRange; //选择Span范围
objvPaperSubViewpointENT.PaperLineNum = objvPaperSubViewpointENS.PaperLineNum; //论文行号
objvPaperSubViewpointENT.PaperPageNum = objvPaperSubViewpointENS.PaperPageNum; //论文页码
objvPaperSubViewpointENT.AppraiseCount = objvPaperSubViewpointENS.AppraiseCount; //评论数
objvPaperSubViewpointENT.OkCount = objvPaperSubViewpointENS.OkCount; //点赞统计
objvPaperSubViewpointENT.Score = objvPaperSubViewpointENS.Score; //评分
objvPaperSubViewpointENT.StuScore = objvPaperSubViewpointENS.StuScore; //学生平均分
objvPaperSubViewpointENT.TeaScore = objvPaperSubViewpointENS.TeaScore; //教师评分
objvPaperSubViewpointENT.CreateDate = objvPaperSubViewpointENS.CreateDate; //建立日期
objvPaperSubViewpointENT.ShareId = objvPaperSubViewpointENS.ShareId; //分享Id
objvPaperSubViewpointENT.AttitudesId = objvPaperSubViewpointENS.AttitudesId; //态度Id
objvPaperSubViewpointENT.AttitudesName = objvPaperSubViewpointENS.AttitudesName; //名称
objvPaperSubViewpointENT.UpdDate = objvPaperSubViewpointENS.UpdDate; //修改日期
objvPaperSubViewpointENT.UpdUser = objvPaperSubViewpointENS.UpdUser; //修改人
objvPaperSubViewpointENT.Memo = objvPaperSubViewpointENS.Memo; //备注
objvPaperSubViewpointENT.SectionOrderNum = objvPaperSubViewpointENS.SectionOrderNum; //SectionOrderNum
objvPaperSubViewpointENT.SubViewpointTypeOrderNum = objvPaperSubViewpointENS.SubViewpointTypeOrderNum; //子观点类型序号
objvPaperSubViewpointENT.CitationCount = objvPaperSubViewpointENS.CitationCount; //引用统计
objvPaperSubViewpointENT.VersionCount = objvPaperSubViewpointENS.VersionCount; //版本统计
objvPaperSubViewpointENT.IsRecommend = objvPaperSubViewpointENS.IsRecommend; //是否推荐
objvPaperSubViewpointENT.gsKnowledgeTypeName = objvPaperSubViewpointENS.gsKnowledgeTypeName; //知识类型名
objvPaperSubViewpointENT.LevelName = objvPaperSubViewpointENS.LevelName; //级别名称
objvPaperSubViewpointENT.OperationTypeName = objvPaperSubViewpointENS.OperationTypeName; //操作类型名
objvPaperSubViewpointENT.CourseId = objvPaperSubViewpointENS.CourseId; //课程Id
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
 /// <param name = "objvPaperSubViewpointENS">源对象</param>
 /// <returns>目标对象=>clsvPaperSubViewpointEN:objvPaperSubViewpointENT</returns>
 public static clsvPaperSubViewpointEN CopyTo(this clsvPaperSubViewpointEN objvPaperSubViewpointENS)
{
try
{
 clsvPaperSubViewpointEN objvPaperSubViewpointENT = new clsvPaperSubViewpointEN()
{
SubViewpointId = objvPaperSubViewpointENS.SubViewpointId, //子观点Id
SubViewpointContent = objvPaperSubViewpointENS.SubViewpointContent, //详情内容
PaperRWId = objvPaperSubViewpointENS.PaperRWId, //课文阅读
PaperId = objvPaperSubViewpointENS.PaperId, //论文Id
PaperTitle = objvPaperSubViewpointENS.PaperTitle, //论文标题
IsSubmit = objvPaperSubViewpointENS.IsSubmit, //是否提交
IdCurrEduCls = objvPaperSubViewpointENS.IdCurrEduCls, //教学班流水号
UserId = objvPaperSubViewpointENS.UserId, //用户ID
SectionId = objvPaperSubViewpointENS.SectionId, //节Id
SectionName = objvPaperSubViewpointENS.SectionName, //节名
SubViewpointTypeId = objvPaperSubViewpointENS.SubViewpointTypeId, //类型Id
SubViewpointTypeName = objvPaperSubViewpointENS.SubViewpointTypeName, //类型名称
DefaTitle = objvPaperSubViewpointENS.DefaTitle, //默认标题
gsKnowledgeTypeId = objvPaperSubViewpointENS.gsKnowledgeTypeId, //知识类型Id
RWTitle = objvPaperSubViewpointENS.RWTitle, //读写标题
ExplainTypeId = objvPaperSubViewpointENS.ExplainTypeId, //说明类型Id
ExplainTypeName = objvPaperSubViewpointENS.ExplainTypeName, //说明类型名
ExplainContent = objvPaperSubViewpointENS.ExplainContent, //说明内容
IsPublic = objvPaperSubViewpointENS.IsPublic, //是否公开
LiteratureSourcesId = objvPaperSubViewpointENS.LiteratureSourcesId, //文献来源
OperationTypeId = objvPaperSubViewpointENS.OperationTypeId, //操作类型ID
LevelId = objvPaperSubViewpointENS.LevelId, //级别Id
Conclusion = objvPaperSubViewpointENS.Conclusion, //结论
Nationality = objvPaperSubViewpointENS.Nationality, //国籍
Achievement = objvPaperSubViewpointENS.Achievement, //成就
Major = objvPaperSubViewpointENS.Major, //专业
WorkUnit = objvPaperSubViewpointENS.WorkUnit, //工作单位
PageNumber = objvPaperSubViewpointENS.PageNumber, //页码
OrderNum = objvPaperSubViewpointENS.OrderNum, //序号
PdfContent = objvPaperSubViewpointENS.PdfContent, //Pdf内容
selectSpanRange = objvPaperSubViewpointENS.selectSpanRange, //选择Span范围
PaperLineNum = objvPaperSubViewpointENS.PaperLineNum, //论文行号
PaperPageNum = objvPaperSubViewpointENS.PaperPageNum, //论文页码
AppraiseCount = objvPaperSubViewpointENS.AppraiseCount, //评论数
OkCount = objvPaperSubViewpointENS.OkCount, //点赞统计
Score = objvPaperSubViewpointENS.Score, //评分
StuScore = objvPaperSubViewpointENS.StuScore, //学生平均分
TeaScore = objvPaperSubViewpointENS.TeaScore, //教师评分
CreateDate = objvPaperSubViewpointENS.CreateDate, //建立日期
ShareId = objvPaperSubViewpointENS.ShareId, //分享Id
AttitudesId = objvPaperSubViewpointENS.AttitudesId, //态度Id
AttitudesName = objvPaperSubViewpointENS.AttitudesName, //名称
UpdDate = objvPaperSubViewpointENS.UpdDate, //修改日期
UpdUser = objvPaperSubViewpointENS.UpdUser, //修改人
Memo = objvPaperSubViewpointENS.Memo, //备注
SectionOrderNum = objvPaperSubViewpointENS.SectionOrderNum, //SectionOrderNum
SubViewpointTypeOrderNum = objvPaperSubViewpointENS.SubViewpointTypeOrderNum, //子观点类型序号
CitationCount = objvPaperSubViewpointENS.CitationCount, //引用统计
VersionCount = objvPaperSubViewpointENS.VersionCount, //版本统计
IsRecommend = objvPaperSubViewpointENS.IsRecommend, //是否推荐
gsKnowledgeTypeName = objvPaperSubViewpointENS.gsKnowledgeTypeName, //知识类型名
LevelName = objvPaperSubViewpointENS.LevelName, //级别名称
OperationTypeName = objvPaperSubViewpointENS.OperationTypeName, //操作类型名
CourseId = objvPaperSubViewpointENS.CourseId, //课程Id
};
 return objvPaperSubViewpointENT;
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
public static void CheckProperty4Condition(this clsvPaperSubViewpointEN objvPaperSubViewpointEN)
{
 clsvPaperSubViewpointBL.vPaperSubViewpointDA.CheckProperty4Condition(objvPaperSubViewpointEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvPaperSubViewpointEN objvPaperSubViewpointCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvPaperSubViewpointCond.IsUpdated(convPaperSubViewpoint.SubViewpointId) == true)
{
string strComparisonOpSubViewpointId = objvPaperSubViewpointCond.dicFldComparisonOp[convPaperSubViewpoint.SubViewpointId];
strWhereCond += string.Format(" And {0} {2} {1}", convPaperSubViewpoint.SubViewpointId, objvPaperSubViewpointCond.SubViewpointId, strComparisonOpSubViewpointId);
}
if (objvPaperSubViewpointCond.IsUpdated(convPaperSubViewpoint.SubViewpointContent) == true)
{
string strComparisonOpSubViewpointContent = objvPaperSubViewpointCond.dicFldComparisonOp[convPaperSubViewpoint.SubViewpointContent];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPaperSubViewpoint.SubViewpointContent, objvPaperSubViewpointCond.SubViewpointContent, strComparisonOpSubViewpointContent);
}
if (objvPaperSubViewpointCond.IsUpdated(convPaperSubViewpoint.PaperRWId) == true)
{
string strComparisonOpPaperRWId = objvPaperSubViewpointCond.dicFldComparisonOp[convPaperSubViewpoint.PaperRWId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPaperSubViewpoint.PaperRWId, objvPaperSubViewpointCond.PaperRWId, strComparisonOpPaperRWId);
}
if (objvPaperSubViewpointCond.IsUpdated(convPaperSubViewpoint.PaperId) == true)
{
string strComparisonOpPaperId = objvPaperSubViewpointCond.dicFldComparisonOp[convPaperSubViewpoint.PaperId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPaperSubViewpoint.PaperId, objvPaperSubViewpointCond.PaperId, strComparisonOpPaperId);
}
if (objvPaperSubViewpointCond.IsUpdated(convPaperSubViewpoint.PaperTitle) == true)
{
string strComparisonOpPaperTitle = objvPaperSubViewpointCond.dicFldComparisonOp[convPaperSubViewpoint.PaperTitle];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPaperSubViewpoint.PaperTitle, objvPaperSubViewpointCond.PaperTitle, strComparisonOpPaperTitle);
}
if (objvPaperSubViewpointCond.IsUpdated(convPaperSubViewpoint.IsSubmit) == true)
{
if (objvPaperSubViewpointCond.IsSubmit == true)
{
strWhereCond += string.Format(" And {0} = '1'", convPaperSubViewpoint.IsSubmit);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convPaperSubViewpoint.IsSubmit);
}
}
if (objvPaperSubViewpointCond.IsUpdated(convPaperSubViewpoint.IdCurrEduCls) == true)
{
string strComparisonOpIdCurrEduCls = objvPaperSubViewpointCond.dicFldComparisonOp[convPaperSubViewpoint.IdCurrEduCls];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPaperSubViewpoint.IdCurrEduCls, objvPaperSubViewpointCond.IdCurrEduCls, strComparisonOpIdCurrEduCls);
}
if (objvPaperSubViewpointCond.IsUpdated(convPaperSubViewpoint.UserId) == true)
{
string strComparisonOpUserId = objvPaperSubViewpointCond.dicFldComparisonOp[convPaperSubViewpoint.UserId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPaperSubViewpoint.UserId, objvPaperSubViewpointCond.UserId, strComparisonOpUserId);
}
if (objvPaperSubViewpointCond.IsUpdated(convPaperSubViewpoint.SectionId) == true)
{
string strComparisonOpSectionId = objvPaperSubViewpointCond.dicFldComparisonOp[convPaperSubViewpoint.SectionId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPaperSubViewpoint.SectionId, objvPaperSubViewpointCond.SectionId, strComparisonOpSectionId);
}
if (objvPaperSubViewpointCond.IsUpdated(convPaperSubViewpoint.SectionName) == true)
{
string strComparisonOpSectionName = objvPaperSubViewpointCond.dicFldComparisonOp[convPaperSubViewpoint.SectionName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPaperSubViewpoint.SectionName, objvPaperSubViewpointCond.SectionName, strComparisonOpSectionName);
}
if (objvPaperSubViewpointCond.IsUpdated(convPaperSubViewpoint.SubViewpointTypeId) == true)
{
string strComparisonOpSubViewpointTypeId = objvPaperSubViewpointCond.dicFldComparisonOp[convPaperSubViewpoint.SubViewpointTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPaperSubViewpoint.SubViewpointTypeId, objvPaperSubViewpointCond.SubViewpointTypeId, strComparisonOpSubViewpointTypeId);
}
if (objvPaperSubViewpointCond.IsUpdated(convPaperSubViewpoint.SubViewpointTypeName) == true)
{
string strComparisonOpSubViewpointTypeName = objvPaperSubViewpointCond.dicFldComparisonOp[convPaperSubViewpoint.SubViewpointTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPaperSubViewpoint.SubViewpointTypeName, objvPaperSubViewpointCond.SubViewpointTypeName, strComparisonOpSubViewpointTypeName);
}
if (objvPaperSubViewpointCond.IsUpdated(convPaperSubViewpoint.DefaTitle) == true)
{
string strComparisonOpDefaTitle = objvPaperSubViewpointCond.dicFldComparisonOp[convPaperSubViewpoint.DefaTitle];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPaperSubViewpoint.DefaTitle, objvPaperSubViewpointCond.DefaTitle, strComparisonOpDefaTitle);
}
if (objvPaperSubViewpointCond.IsUpdated(convPaperSubViewpoint.gsKnowledgeTypeId) == true)
{
string strComparisonOpgsKnowledgeTypeId = objvPaperSubViewpointCond.dicFldComparisonOp[convPaperSubViewpoint.gsKnowledgeTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPaperSubViewpoint.gsKnowledgeTypeId, objvPaperSubViewpointCond.gsKnowledgeTypeId, strComparisonOpgsKnowledgeTypeId);
}
if (objvPaperSubViewpointCond.IsUpdated(convPaperSubViewpoint.RWTitle) == true)
{
string strComparisonOpRWTitle = objvPaperSubViewpointCond.dicFldComparisonOp[convPaperSubViewpoint.RWTitle];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPaperSubViewpoint.RWTitle, objvPaperSubViewpointCond.RWTitle, strComparisonOpRWTitle);
}
if (objvPaperSubViewpointCond.IsUpdated(convPaperSubViewpoint.ExplainTypeId) == true)
{
string strComparisonOpExplainTypeId = objvPaperSubViewpointCond.dicFldComparisonOp[convPaperSubViewpoint.ExplainTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPaperSubViewpoint.ExplainTypeId, objvPaperSubViewpointCond.ExplainTypeId, strComparisonOpExplainTypeId);
}
if (objvPaperSubViewpointCond.IsUpdated(convPaperSubViewpoint.ExplainTypeName) == true)
{
string strComparisonOpExplainTypeName = objvPaperSubViewpointCond.dicFldComparisonOp[convPaperSubViewpoint.ExplainTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPaperSubViewpoint.ExplainTypeName, objvPaperSubViewpointCond.ExplainTypeName, strComparisonOpExplainTypeName);
}
if (objvPaperSubViewpointCond.IsUpdated(convPaperSubViewpoint.ExplainContent) == true)
{
string strComparisonOpExplainContent = objvPaperSubViewpointCond.dicFldComparisonOp[convPaperSubViewpoint.ExplainContent];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPaperSubViewpoint.ExplainContent, objvPaperSubViewpointCond.ExplainContent, strComparisonOpExplainContent);
}
if (objvPaperSubViewpointCond.IsUpdated(convPaperSubViewpoint.IsPublic) == true)
{
if (objvPaperSubViewpointCond.IsPublic == true)
{
strWhereCond += string.Format(" And {0} = '1'", convPaperSubViewpoint.IsPublic);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convPaperSubViewpoint.IsPublic);
}
}
if (objvPaperSubViewpointCond.IsUpdated(convPaperSubViewpoint.LiteratureSourcesId) == true)
{
string strComparisonOpLiteratureSourcesId = objvPaperSubViewpointCond.dicFldComparisonOp[convPaperSubViewpoint.LiteratureSourcesId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPaperSubViewpoint.LiteratureSourcesId, objvPaperSubViewpointCond.LiteratureSourcesId, strComparisonOpLiteratureSourcesId);
}
if (objvPaperSubViewpointCond.IsUpdated(convPaperSubViewpoint.OperationTypeId) == true)
{
string strComparisonOpOperationTypeId = objvPaperSubViewpointCond.dicFldComparisonOp[convPaperSubViewpoint.OperationTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPaperSubViewpoint.OperationTypeId, objvPaperSubViewpointCond.OperationTypeId, strComparisonOpOperationTypeId);
}
if (objvPaperSubViewpointCond.IsUpdated(convPaperSubViewpoint.LevelId) == true)
{
string strComparisonOpLevelId = objvPaperSubViewpointCond.dicFldComparisonOp[convPaperSubViewpoint.LevelId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPaperSubViewpoint.LevelId, objvPaperSubViewpointCond.LevelId, strComparisonOpLevelId);
}
if (objvPaperSubViewpointCond.IsUpdated(convPaperSubViewpoint.Conclusion) == true)
{
string strComparisonOpConclusion = objvPaperSubViewpointCond.dicFldComparisonOp[convPaperSubViewpoint.Conclusion];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPaperSubViewpoint.Conclusion, objvPaperSubViewpointCond.Conclusion, strComparisonOpConclusion);
}
if (objvPaperSubViewpointCond.IsUpdated(convPaperSubViewpoint.Nationality) == true)
{
string strComparisonOpNationality = objvPaperSubViewpointCond.dicFldComparisonOp[convPaperSubViewpoint.Nationality];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPaperSubViewpoint.Nationality, objvPaperSubViewpointCond.Nationality, strComparisonOpNationality);
}
if (objvPaperSubViewpointCond.IsUpdated(convPaperSubViewpoint.Achievement) == true)
{
string strComparisonOpAchievement = objvPaperSubViewpointCond.dicFldComparisonOp[convPaperSubViewpoint.Achievement];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPaperSubViewpoint.Achievement, objvPaperSubViewpointCond.Achievement, strComparisonOpAchievement);
}
if (objvPaperSubViewpointCond.IsUpdated(convPaperSubViewpoint.Major) == true)
{
string strComparisonOpMajor = objvPaperSubViewpointCond.dicFldComparisonOp[convPaperSubViewpoint.Major];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPaperSubViewpoint.Major, objvPaperSubViewpointCond.Major, strComparisonOpMajor);
}
if (objvPaperSubViewpointCond.IsUpdated(convPaperSubViewpoint.WorkUnit) == true)
{
string strComparisonOpWorkUnit = objvPaperSubViewpointCond.dicFldComparisonOp[convPaperSubViewpoint.WorkUnit];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPaperSubViewpoint.WorkUnit, objvPaperSubViewpointCond.WorkUnit, strComparisonOpWorkUnit);
}
if (objvPaperSubViewpointCond.IsUpdated(convPaperSubViewpoint.PageNumber) == true)
{
string strComparisonOpPageNumber = objvPaperSubViewpointCond.dicFldComparisonOp[convPaperSubViewpoint.PageNumber];
strWhereCond += string.Format(" And {0} {2} {1}", convPaperSubViewpoint.PageNumber, objvPaperSubViewpointCond.PageNumber, strComparisonOpPageNumber);
}
if (objvPaperSubViewpointCond.IsUpdated(convPaperSubViewpoint.OrderNum) == true)
{
string strComparisonOpOrderNum = objvPaperSubViewpointCond.dicFldComparisonOp[convPaperSubViewpoint.OrderNum];
strWhereCond += string.Format(" And {0} {2} {1}", convPaperSubViewpoint.OrderNum, objvPaperSubViewpointCond.OrderNum, strComparisonOpOrderNum);
}
if (objvPaperSubViewpointCond.IsUpdated(convPaperSubViewpoint.PdfContent) == true)
{
string strComparisonOpPdfContent = objvPaperSubViewpointCond.dicFldComparisonOp[convPaperSubViewpoint.PdfContent];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPaperSubViewpoint.PdfContent, objvPaperSubViewpointCond.PdfContent, strComparisonOpPdfContent);
}
if (objvPaperSubViewpointCond.IsUpdated(convPaperSubViewpoint.selectSpanRange) == true)
{
string strComparisonOpselectSpanRange = objvPaperSubViewpointCond.dicFldComparisonOp[convPaperSubViewpoint.selectSpanRange];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPaperSubViewpoint.selectSpanRange, objvPaperSubViewpointCond.selectSpanRange, strComparisonOpselectSpanRange);
}
if (objvPaperSubViewpointCond.IsUpdated(convPaperSubViewpoint.PaperLineNum) == true)
{
string strComparisonOpPaperLineNum = objvPaperSubViewpointCond.dicFldComparisonOp[convPaperSubViewpoint.PaperLineNum];
strWhereCond += string.Format(" And {0} {2} {1}", convPaperSubViewpoint.PaperLineNum, objvPaperSubViewpointCond.PaperLineNum, strComparisonOpPaperLineNum);
}
if (objvPaperSubViewpointCond.IsUpdated(convPaperSubViewpoint.PaperPageNum) == true)
{
string strComparisonOpPaperPageNum = objvPaperSubViewpointCond.dicFldComparisonOp[convPaperSubViewpoint.PaperPageNum];
strWhereCond += string.Format(" And {0} {2} {1}", convPaperSubViewpoint.PaperPageNum, objvPaperSubViewpointCond.PaperPageNum, strComparisonOpPaperPageNum);
}
if (objvPaperSubViewpointCond.IsUpdated(convPaperSubViewpoint.AppraiseCount) == true)
{
string strComparisonOpAppraiseCount = objvPaperSubViewpointCond.dicFldComparisonOp[convPaperSubViewpoint.AppraiseCount];
strWhereCond += string.Format(" And {0} {2} {1}", convPaperSubViewpoint.AppraiseCount, objvPaperSubViewpointCond.AppraiseCount, strComparisonOpAppraiseCount);
}
if (objvPaperSubViewpointCond.IsUpdated(convPaperSubViewpoint.OkCount) == true)
{
string strComparisonOpOkCount = objvPaperSubViewpointCond.dicFldComparisonOp[convPaperSubViewpoint.OkCount];
strWhereCond += string.Format(" And {0} {2} {1}", convPaperSubViewpoint.OkCount, objvPaperSubViewpointCond.OkCount, strComparisonOpOkCount);
}
if (objvPaperSubViewpointCond.IsUpdated(convPaperSubViewpoint.Score) == true)
{
string strComparisonOpScore = objvPaperSubViewpointCond.dicFldComparisonOp[convPaperSubViewpoint.Score];
strWhereCond += string.Format(" And {0} {2} {1}", convPaperSubViewpoint.Score, objvPaperSubViewpointCond.Score, strComparisonOpScore);
}
if (objvPaperSubViewpointCond.IsUpdated(convPaperSubViewpoint.StuScore) == true)
{
string strComparisonOpStuScore = objvPaperSubViewpointCond.dicFldComparisonOp[convPaperSubViewpoint.StuScore];
strWhereCond += string.Format(" And {0} {2} {1}", convPaperSubViewpoint.StuScore, objvPaperSubViewpointCond.StuScore, strComparisonOpStuScore);
}
if (objvPaperSubViewpointCond.IsUpdated(convPaperSubViewpoint.TeaScore) == true)
{
string strComparisonOpTeaScore = objvPaperSubViewpointCond.dicFldComparisonOp[convPaperSubViewpoint.TeaScore];
strWhereCond += string.Format(" And {0} {2} {1}", convPaperSubViewpoint.TeaScore, objvPaperSubViewpointCond.TeaScore, strComparisonOpTeaScore);
}
if (objvPaperSubViewpointCond.IsUpdated(convPaperSubViewpoint.CreateDate) == true)
{
string strComparisonOpCreateDate = objvPaperSubViewpointCond.dicFldComparisonOp[convPaperSubViewpoint.CreateDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPaperSubViewpoint.CreateDate, objvPaperSubViewpointCond.CreateDate, strComparisonOpCreateDate);
}
if (objvPaperSubViewpointCond.IsUpdated(convPaperSubViewpoint.ShareId) == true)
{
string strComparisonOpShareId = objvPaperSubViewpointCond.dicFldComparisonOp[convPaperSubViewpoint.ShareId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPaperSubViewpoint.ShareId, objvPaperSubViewpointCond.ShareId, strComparisonOpShareId);
}
if (objvPaperSubViewpointCond.IsUpdated(convPaperSubViewpoint.AttitudesId) == true)
{
string strComparisonOpAttitudesId = objvPaperSubViewpointCond.dicFldComparisonOp[convPaperSubViewpoint.AttitudesId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPaperSubViewpoint.AttitudesId, objvPaperSubViewpointCond.AttitudesId, strComparisonOpAttitudesId);
}
if (objvPaperSubViewpointCond.IsUpdated(convPaperSubViewpoint.AttitudesName) == true)
{
string strComparisonOpAttitudesName = objvPaperSubViewpointCond.dicFldComparisonOp[convPaperSubViewpoint.AttitudesName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPaperSubViewpoint.AttitudesName, objvPaperSubViewpointCond.AttitudesName, strComparisonOpAttitudesName);
}
if (objvPaperSubViewpointCond.IsUpdated(convPaperSubViewpoint.UpdDate) == true)
{
string strComparisonOpUpdDate = objvPaperSubViewpointCond.dicFldComparisonOp[convPaperSubViewpoint.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPaperSubViewpoint.UpdDate, objvPaperSubViewpointCond.UpdDate, strComparisonOpUpdDate);
}
if (objvPaperSubViewpointCond.IsUpdated(convPaperSubViewpoint.UpdUser) == true)
{
string strComparisonOpUpdUser = objvPaperSubViewpointCond.dicFldComparisonOp[convPaperSubViewpoint.UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPaperSubViewpoint.UpdUser, objvPaperSubViewpointCond.UpdUser, strComparisonOpUpdUser);
}
if (objvPaperSubViewpointCond.IsUpdated(convPaperSubViewpoint.Memo) == true)
{
string strComparisonOpMemo = objvPaperSubViewpointCond.dicFldComparisonOp[convPaperSubViewpoint.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPaperSubViewpoint.Memo, objvPaperSubViewpointCond.Memo, strComparisonOpMemo);
}
if (objvPaperSubViewpointCond.IsUpdated(convPaperSubViewpoint.SectionOrderNum) == true)
{
string strComparisonOpSectionOrderNum = objvPaperSubViewpointCond.dicFldComparisonOp[convPaperSubViewpoint.SectionOrderNum];
strWhereCond += string.Format(" And {0} {2} {1}", convPaperSubViewpoint.SectionOrderNum, objvPaperSubViewpointCond.SectionOrderNum, strComparisonOpSectionOrderNum);
}
if (objvPaperSubViewpointCond.IsUpdated(convPaperSubViewpoint.SubViewpointTypeOrderNum) == true)
{
string strComparisonOpSubViewpointTypeOrderNum = objvPaperSubViewpointCond.dicFldComparisonOp[convPaperSubViewpoint.SubViewpointTypeOrderNum];
strWhereCond += string.Format(" And {0} {2} {1}", convPaperSubViewpoint.SubViewpointTypeOrderNum, objvPaperSubViewpointCond.SubViewpointTypeOrderNum, strComparisonOpSubViewpointTypeOrderNum);
}
if (objvPaperSubViewpointCond.IsUpdated(convPaperSubViewpoint.CitationCount) == true)
{
string strComparisonOpCitationCount = objvPaperSubViewpointCond.dicFldComparisonOp[convPaperSubViewpoint.CitationCount];
strWhereCond += string.Format(" And {0} {2} {1}", convPaperSubViewpoint.CitationCount, objvPaperSubViewpointCond.CitationCount, strComparisonOpCitationCount);
}
if (objvPaperSubViewpointCond.IsUpdated(convPaperSubViewpoint.VersionCount) == true)
{
string strComparisonOpVersionCount = objvPaperSubViewpointCond.dicFldComparisonOp[convPaperSubViewpoint.VersionCount];
strWhereCond += string.Format(" And {0} {2} {1}", convPaperSubViewpoint.VersionCount, objvPaperSubViewpointCond.VersionCount, strComparisonOpVersionCount);
}
if (objvPaperSubViewpointCond.IsUpdated(convPaperSubViewpoint.IsRecommend) == true)
{
if (objvPaperSubViewpointCond.IsRecommend == true)
{
strWhereCond += string.Format(" And {0} = '1'", convPaperSubViewpoint.IsRecommend);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convPaperSubViewpoint.IsRecommend);
}
}
if (objvPaperSubViewpointCond.IsUpdated(convPaperSubViewpoint.gsKnowledgeTypeName) == true)
{
string strComparisonOpgsKnowledgeTypeName = objvPaperSubViewpointCond.dicFldComparisonOp[convPaperSubViewpoint.gsKnowledgeTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPaperSubViewpoint.gsKnowledgeTypeName, objvPaperSubViewpointCond.gsKnowledgeTypeName, strComparisonOpgsKnowledgeTypeName);
}
if (objvPaperSubViewpointCond.IsUpdated(convPaperSubViewpoint.LevelName) == true)
{
string strComparisonOpLevelName = objvPaperSubViewpointCond.dicFldComparisonOp[convPaperSubViewpoint.LevelName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPaperSubViewpoint.LevelName, objvPaperSubViewpointCond.LevelName, strComparisonOpLevelName);
}
if (objvPaperSubViewpointCond.IsUpdated(convPaperSubViewpoint.OperationTypeName) == true)
{
string strComparisonOpOperationTypeName = objvPaperSubViewpointCond.dicFldComparisonOp[convPaperSubViewpoint.OperationTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPaperSubViewpoint.OperationTypeName, objvPaperSubViewpointCond.OperationTypeName, strComparisonOpOperationTypeName);
}
if (objvPaperSubViewpointCond.IsUpdated(convPaperSubViewpoint.CourseId) == true)
{
string strComparisonOpCourseId = objvPaperSubViewpointCond.dicFldComparisonOp[convPaperSubViewpoint.CourseId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPaperSubViewpoint.CourseId, objvPaperSubViewpointCond.CourseId, strComparisonOpCourseId);
}
 return strWhereCond;
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_vPaperSubViewpoint
{
public virtual bool UpdRelaTabDate(long lngSubViewpointId, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// v子观点表(vPaperSubViewpoint)
 /// 数据源类型:视图
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsvPaperSubViewpointBL
{
public static RelatedActions_vPaperSubViewpoint relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsvPaperSubViewpointDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsvPaperSubViewpointDA vPaperSubViewpointDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsvPaperSubViewpointDA();
}
return uniqueInstance;
}
}

 /// <summary>
 /// 类的构造函数
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ClassConstructor1)
 /// </summary>
 public clsvPaperSubViewpointBL()
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
if (string.IsNullOrEmpty(clsvPaperSubViewpointEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvPaperSubViewpointEN._ConnectString);
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
public static DataTable GetDataTable_vPaperSubViewpoint(string strWhereCond)
{
DataTable objDT;
try
{
objDT = vPaperSubViewpointDA.GetDataTable_vPaperSubViewpoint(strWhereCond);
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
objDT = vPaperSubViewpointDA.GetDataTable(strWhereCond);
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
objDT = vPaperSubViewpointDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = vPaperSubViewpointDA.GetDataTable(strWhereCond, strTabName);
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
objDT = vPaperSubViewpointDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = vPaperSubViewpointDA.GetDataTable_Top(objTopPara);
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
objDT = vPaperSubViewpointDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = vPaperSubViewpointDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = vPaperSubViewpointDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
 /// <param name = "arrSubViewpointIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static List<clsvPaperSubViewpointEN> GetObjLstBySubViewpointIdLst(List<long> arrSubViewpointIdLst)
{
List<clsvPaperSubViewpointEN> arrObjLst = new List<clsvPaperSubViewpointEN>(); 
System.Data.DataTable objDT; 
 string strSqlConditionStr = clsArray.GetSqlInStrByArray(arrSubViewpointIdLst);
 string strWhereCond = string.Format("SubViewpointId in ({0})", strSqlConditionStr);
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvPaperSubViewpointEN objvPaperSubViewpointEN = new clsvPaperSubViewpointEN();
try
{
objvPaperSubViewpointEN.SubViewpointId = Int32.Parse(objRow[convPaperSubViewpoint.SubViewpointId].ToString().Trim()); //子观点Id
objvPaperSubViewpointEN.SubViewpointContent = objRow[convPaperSubViewpoint.SubViewpointContent] == DBNull.Value ? null : objRow[convPaperSubViewpoint.SubViewpointContent].ToString().Trim(); //详情内容
objvPaperSubViewpointEN.PaperRWId = objRow[convPaperSubViewpoint.PaperRWId] == DBNull.Value ? null : objRow[convPaperSubViewpoint.PaperRWId].ToString().Trim(); //课文阅读
objvPaperSubViewpointEN.PaperId = objRow[convPaperSubViewpoint.PaperId] == DBNull.Value ? null : objRow[convPaperSubViewpoint.PaperId].ToString().Trim(); //论文Id
objvPaperSubViewpointEN.PaperTitle = objRow[convPaperSubViewpoint.PaperTitle] == DBNull.Value ? null : objRow[convPaperSubViewpoint.PaperTitle].ToString().Trim(); //论文标题
objvPaperSubViewpointEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[convPaperSubViewpoint.IsSubmit].ToString().Trim()); //是否提交
objvPaperSubViewpointEN.IdCurrEduCls = objRow[convPaperSubViewpoint.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvPaperSubViewpointEN.UserId = objRow[convPaperSubViewpoint.UserId].ToString().Trim(); //用户ID
objvPaperSubViewpointEN.SectionId = objRow[convPaperSubViewpoint.SectionId] == DBNull.Value ? null : objRow[convPaperSubViewpoint.SectionId].ToString().Trim(); //节Id
objvPaperSubViewpointEN.SectionName = objRow[convPaperSubViewpoint.SectionName] == DBNull.Value ? null : objRow[convPaperSubViewpoint.SectionName].ToString().Trim(); //节名
objvPaperSubViewpointEN.SubViewpointTypeId = objRow[convPaperSubViewpoint.SubViewpointTypeId].ToString().Trim(); //类型Id
objvPaperSubViewpointEN.SubViewpointTypeName = objRow[convPaperSubViewpoint.SubViewpointTypeName] == DBNull.Value ? null : objRow[convPaperSubViewpoint.SubViewpointTypeName].ToString().Trim(); //类型名称
objvPaperSubViewpointEN.DefaTitle = objRow[convPaperSubViewpoint.DefaTitle] == DBNull.Value ? null : objRow[convPaperSubViewpoint.DefaTitle].ToString().Trim(); //默认标题
objvPaperSubViewpointEN.gsKnowledgeTypeId = objRow[convPaperSubViewpoint.gsKnowledgeTypeId].ToString().Trim(); //知识类型Id
objvPaperSubViewpointEN.RWTitle = objRow[convPaperSubViewpoint.RWTitle] == DBNull.Value ? null : objRow[convPaperSubViewpoint.RWTitle].ToString().Trim(); //读写标题
objvPaperSubViewpointEN.ExplainTypeId = objRow[convPaperSubViewpoint.ExplainTypeId] == DBNull.Value ? null : objRow[convPaperSubViewpoint.ExplainTypeId].ToString().Trim(); //说明类型Id
objvPaperSubViewpointEN.ExplainTypeName = objRow[convPaperSubViewpoint.ExplainTypeName] == DBNull.Value ? null : objRow[convPaperSubViewpoint.ExplainTypeName].ToString().Trim(); //说明类型名
objvPaperSubViewpointEN.ExplainContent = objRow[convPaperSubViewpoint.ExplainContent] == DBNull.Value ? null : objRow[convPaperSubViewpoint.ExplainContent].ToString().Trim(); //说明内容
objvPaperSubViewpointEN.IsPublic = clsEntityBase2.TransNullToBool_S(objRow[convPaperSubViewpoint.IsPublic].ToString().Trim()); //是否公开
objvPaperSubViewpointEN.LiteratureSourcesId = objRow[convPaperSubViewpoint.LiteratureSourcesId] == DBNull.Value ? null : objRow[convPaperSubViewpoint.LiteratureSourcesId].ToString().Trim(); //文献来源
objvPaperSubViewpointEN.OperationTypeId = objRow[convPaperSubViewpoint.OperationTypeId] == DBNull.Value ? null : objRow[convPaperSubViewpoint.OperationTypeId].ToString().Trim(); //操作类型ID
objvPaperSubViewpointEN.LevelId = objRow[convPaperSubViewpoint.LevelId] == DBNull.Value ? null : objRow[convPaperSubViewpoint.LevelId].ToString().Trim(); //级别Id
objvPaperSubViewpointEN.Conclusion = objRow[convPaperSubViewpoint.Conclusion] == DBNull.Value ? null : objRow[convPaperSubViewpoint.Conclusion].ToString().Trim(); //结论
objvPaperSubViewpointEN.Nationality = objRow[convPaperSubViewpoint.Nationality] == DBNull.Value ? null : objRow[convPaperSubViewpoint.Nationality].ToString().Trim(); //国籍
objvPaperSubViewpointEN.Achievement = objRow[convPaperSubViewpoint.Achievement] == DBNull.Value ? null : objRow[convPaperSubViewpoint.Achievement].ToString().Trim(); //成就
objvPaperSubViewpointEN.Major = objRow[convPaperSubViewpoint.Major] == DBNull.Value ? null : objRow[convPaperSubViewpoint.Major].ToString().Trim(); //专业
objvPaperSubViewpointEN.WorkUnit = objRow[convPaperSubViewpoint.WorkUnit] == DBNull.Value ? null : objRow[convPaperSubViewpoint.WorkUnit].ToString().Trim(); //工作单位
objvPaperSubViewpointEN.PageNumber = objRow[convPaperSubViewpoint.PageNumber] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPaperSubViewpoint.PageNumber].ToString().Trim()); //页码
objvPaperSubViewpointEN.OrderNum = objRow[convPaperSubViewpoint.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPaperSubViewpoint.OrderNum].ToString().Trim()); //序号
objvPaperSubViewpointEN.PdfContent = objRow[convPaperSubViewpoint.PdfContent] == DBNull.Value ? null : objRow[convPaperSubViewpoint.PdfContent].ToString().Trim(); //Pdf内容
objvPaperSubViewpointEN.selectSpanRange = objRow[convPaperSubViewpoint.selectSpanRange] == DBNull.Value ? null : objRow[convPaperSubViewpoint.selectSpanRange].ToString().Trim(); //选择Span范围
objvPaperSubViewpointEN.PaperLineNum = objRow[convPaperSubViewpoint.PaperLineNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPaperSubViewpoint.PaperLineNum].ToString().Trim()); //论文行号
objvPaperSubViewpointEN.PaperPageNum = objRow[convPaperSubViewpoint.PaperPageNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPaperSubViewpoint.PaperPageNum].ToString().Trim()); //论文页码
objvPaperSubViewpointEN.AppraiseCount = objRow[convPaperSubViewpoint.AppraiseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPaperSubViewpoint.AppraiseCount].ToString().Trim()); //评论数
objvPaperSubViewpointEN.OkCount = objRow[convPaperSubViewpoint.OkCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPaperSubViewpoint.OkCount].ToString().Trim()); //点赞统计
objvPaperSubViewpointEN.Score = objRow[convPaperSubViewpoint.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convPaperSubViewpoint.Score].ToString().Trim()); //评分
objvPaperSubViewpointEN.StuScore = objRow[convPaperSubViewpoint.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convPaperSubViewpoint.StuScore].ToString().Trim()); //学生平均分
objvPaperSubViewpointEN.TeaScore = objRow[convPaperSubViewpoint.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convPaperSubViewpoint.TeaScore].ToString().Trim()); //教师评分
objvPaperSubViewpointEN.CreateDate = objRow[convPaperSubViewpoint.CreateDate] == DBNull.Value ? null : objRow[convPaperSubViewpoint.CreateDate].ToString().Trim(); //建立日期
objvPaperSubViewpointEN.ShareId = objRow[convPaperSubViewpoint.ShareId].ToString().Trim(); //分享Id
objvPaperSubViewpointEN.AttitudesId = objRow[convPaperSubViewpoint.AttitudesId].ToString().Trim(); //态度Id
objvPaperSubViewpointEN.AttitudesName = objRow[convPaperSubViewpoint.AttitudesName] == DBNull.Value ? null : objRow[convPaperSubViewpoint.AttitudesName].ToString().Trim(); //名称
objvPaperSubViewpointEN.UpdDate = objRow[convPaperSubViewpoint.UpdDate] == DBNull.Value ? null : objRow[convPaperSubViewpoint.UpdDate].ToString().Trim(); //修改日期
objvPaperSubViewpointEN.UpdUser = objRow[convPaperSubViewpoint.UpdUser] == DBNull.Value ? null : objRow[convPaperSubViewpoint.UpdUser].ToString().Trim(); //修改人
objvPaperSubViewpointEN.Memo = objRow[convPaperSubViewpoint.Memo] == DBNull.Value ? null : objRow[convPaperSubViewpoint.Memo].ToString().Trim(); //备注
objvPaperSubViewpointEN.SectionOrderNum = objRow[convPaperSubViewpoint.SectionOrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPaperSubViewpoint.SectionOrderNum].ToString().Trim()); //SectionOrderNum
objvPaperSubViewpointEN.SubViewpointTypeOrderNum = objRow[convPaperSubViewpoint.SubViewpointTypeOrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPaperSubViewpoint.SubViewpointTypeOrderNum].ToString().Trim()); //子观点类型序号
objvPaperSubViewpointEN.CitationCount = objRow[convPaperSubViewpoint.CitationCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPaperSubViewpoint.CitationCount].ToString().Trim()); //引用统计
objvPaperSubViewpointEN.VersionCount = objRow[convPaperSubViewpoint.VersionCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPaperSubViewpoint.VersionCount].ToString().Trim()); //版本统计
objvPaperSubViewpointEN.IsRecommend = clsEntityBase2.TransNullToBool_S(objRow[convPaperSubViewpoint.IsRecommend].ToString().Trim()); //是否推荐
objvPaperSubViewpointEN.gsKnowledgeTypeName = objRow[convPaperSubViewpoint.gsKnowledgeTypeName].ToString().Trim(); //知识类型名
objvPaperSubViewpointEN.LevelName = objRow[convPaperSubViewpoint.LevelName] == DBNull.Value ? null : objRow[convPaperSubViewpoint.LevelName].ToString().Trim(); //级别名称
objvPaperSubViewpointEN.OperationTypeName = objRow[convPaperSubViewpoint.OperationTypeName] == DBNull.Value ? null : objRow[convPaperSubViewpoint.OperationTypeName].ToString().Trim(); //操作类型名
objvPaperSubViewpointEN.CourseId = objRow[convPaperSubViewpoint.CourseId] == DBNull.Value ? null : objRow[convPaperSubViewpoint.CourseId].ToString().Trim(); //课程Id
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvPaperSubViewpointEN.SubViewpointId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvPaperSubViewpointEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrSubViewpointIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsvPaperSubViewpointEN> GetObjLstBySubViewpointIdLstCache(List<long> arrSubViewpointIdLst, string strIdCurrEduCls)
{
string strKey = string.Format("{0}_{1}", clsvPaperSubViewpointEN._CurrTabName, strIdCurrEduCls);
List<clsvPaperSubViewpointEN> arrvPaperSubViewpointObjLstCache = GetObjLstCache(strIdCurrEduCls);
IEnumerable <clsvPaperSubViewpointEN> arrvPaperSubViewpointObjLst_Sel =
arrvPaperSubViewpointObjLstCache
.Where(x => arrSubViewpointIdLst.Contains(x.SubViewpointId));
return arrvPaperSubViewpointObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvPaperSubViewpointEN> GetObjLst(string strWhereCond)
{
List<clsvPaperSubViewpointEN> arrObjLst = new List<clsvPaperSubViewpointEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvPaperSubViewpointEN objvPaperSubViewpointEN = new clsvPaperSubViewpointEN();
try
{
objvPaperSubViewpointEN.SubViewpointId = Int32.Parse(objRow[convPaperSubViewpoint.SubViewpointId].ToString().Trim()); //子观点Id
objvPaperSubViewpointEN.SubViewpointContent = objRow[convPaperSubViewpoint.SubViewpointContent] == DBNull.Value ? null : objRow[convPaperSubViewpoint.SubViewpointContent].ToString().Trim(); //详情内容
objvPaperSubViewpointEN.PaperRWId = objRow[convPaperSubViewpoint.PaperRWId] == DBNull.Value ? null : objRow[convPaperSubViewpoint.PaperRWId].ToString().Trim(); //课文阅读
objvPaperSubViewpointEN.PaperId = objRow[convPaperSubViewpoint.PaperId] == DBNull.Value ? null : objRow[convPaperSubViewpoint.PaperId].ToString().Trim(); //论文Id
objvPaperSubViewpointEN.PaperTitle = objRow[convPaperSubViewpoint.PaperTitle] == DBNull.Value ? null : objRow[convPaperSubViewpoint.PaperTitle].ToString().Trim(); //论文标题
objvPaperSubViewpointEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[convPaperSubViewpoint.IsSubmit].ToString().Trim()); //是否提交
objvPaperSubViewpointEN.IdCurrEduCls = objRow[convPaperSubViewpoint.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvPaperSubViewpointEN.UserId = objRow[convPaperSubViewpoint.UserId].ToString().Trim(); //用户ID
objvPaperSubViewpointEN.SectionId = objRow[convPaperSubViewpoint.SectionId] == DBNull.Value ? null : objRow[convPaperSubViewpoint.SectionId].ToString().Trim(); //节Id
objvPaperSubViewpointEN.SectionName = objRow[convPaperSubViewpoint.SectionName] == DBNull.Value ? null : objRow[convPaperSubViewpoint.SectionName].ToString().Trim(); //节名
objvPaperSubViewpointEN.SubViewpointTypeId = objRow[convPaperSubViewpoint.SubViewpointTypeId].ToString().Trim(); //类型Id
objvPaperSubViewpointEN.SubViewpointTypeName = objRow[convPaperSubViewpoint.SubViewpointTypeName] == DBNull.Value ? null : objRow[convPaperSubViewpoint.SubViewpointTypeName].ToString().Trim(); //类型名称
objvPaperSubViewpointEN.DefaTitle = objRow[convPaperSubViewpoint.DefaTitle] == DBNull.Value ? null : objRow[convPaperSubViewpoint.DefaTitle].ToString().Trim(); //默认标题
objvPaperSubViewpointEN.gsKnowledgeTypeId = objRow[convPaperSubViewpoint.gsKnowledgeTypeId].ToString().Trim(); //知识类型Id
objvPaperSubViewpointEN.RWTitle = objRow[convPaperSubViewpoint.RWTitle] == DBNull.Value ? null : objRow[convPaperSubViewpoint.RWTitle].ToString().Trim(); //读写标题
objvPaperSubViewpointEN.ExplainTypeId = objRow[convPaperSubViewpoint.ExplainTypeId] == DBNull.Value ? null : objRow[convPaperSubViewpoint.ExplainTypeId].ToString().Trim(); //说明类型Id
objvPaperSubViewpointEN.ExplainTypeName = objRow[convPaperSubViewpoint.ExplainTypeName] == DBNull.Value ? null : objRow[convPaperSubViewpoint.ExplainTypeName].ToString().Trim(); //说明类型名
objvPaperSubViewpointEN.ExplainContent = objRow[convPaperSubViewpoint.ExplainContent] == DBNull.Value ? null : objRow[convPaperSubViewpoint.ExplainContent].ToString().Trim(); //说明内容
objvPaperSubViewpointEN.IsPublic = clsEntityBase2.TransNullToBool_S(objRow[convPaperSubViewpoint.IsPublic].ToString().Trim()); //是否公开
objvPaperSubViewpointEN.LiteratureSourcesId = objRow[convPaperSubViewpoint.LiteratureSourcesId] == DBNull.Value ? null : objRow[convPaperSubViewpoint.LiteratureSourcesId].ToString().Trim(); //文献来源
objvPaperSubViewpointEN.OperationTypeId = objRow[convPaperSubViewpoint.OperationTypeId] == DBNull.Value ? null : objRow[convPaperSubViewpoint.OperationTypeId].ToString().Trim(); //操作类型ID
objvPaperSubViewpointEN.LevelId = objRow[convPaperSubViewpoint.LevelId] == DBNull.Value ? null : objRow[convPaperSubViewpoint.LevelId].ToString().Trim(); //级别Id
objvPaperSubViewpointEN.Conclusion = objRow[convPaperSubViewpoint.Conclusion] == DBNull.Value ? null : objRow[convPaperSubViewpoint.Conclusion].ToString().Trim(); //结论
objvPaperSubViewpointEN.Nationality = objRow[convPaperSubViewpoint.Nationality] == DBNull.Value ? null : objRow[convPaperSubViewpoint.Nationality].ToString().Trim(); //国籍
objvPaperSubViewpointEN.Achievement = objRow[convPaperSubViewpoint.Achievement] == DBNull.Value ? null : objRow[convPaperSubViewpoint.Achievement].ToString().Trim(); //成就
objvPaperSubViewpointEN.Major = objRow[convPaperSubViewpoint.Major] == DBNull.Value ? null : objRow[convPaperSubViewpoint.Major].ToString().Trim(); //专业
objvPaperSubViewpointEN.WorkUnit = objRow[convPaperSubViewpoint.WorkUnit] == DBNull.Value ? null : objRow[convPaperSubViewpoint.WorkUnit].ToString().Trim(); //工作单位
objvPaperSubViewpointEN.PageNumber = objRow[convPaperSubViewpoint.PageNumber] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPaperSubViewpoint.PageNumber].ToString().Trim()); //页码
objvPaperSubViewpointEN.OrderNum = objRow[convPaperSubViewpoint.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPaperSubViewpoint.OrderNum].ToString().Trim()); //序号
objvPaperSubViewpointEN.PdfContent = objRow[convPaperSubViewpoint.PdfContent] == DBNull.Value ? null : objRow[convPaperSubViewpoint.PdfContent].ToString().Trim(); //Pdf内容
objvPaperSubViewpointEN.selectSpanRange = objRow[convPaperSubViewpoint.selectSpanRange] == DBNull.Value ? null : objRow[convPaperSubViewpoint.selectSpanRange].ToString().Trim(); //选择Span范围
objvPaperSubViewpointEN.PaperLineNum = objRow[convPaperSubViewpoint.PaperLineNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPaperSubViewpoint.PaperLineNum].ToString().Trim()); //论文行号
objvPaperSubViewpointEN.PaperPageNum = objRow[convPaperSubViewpoint.PaperPageNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPaperSubViewpoint.PaperPageNum].ToString().Trim()); //论文页码
objvPaperSubViewpointEN.AppraiseCount = objRow[convPaperSubViewpoint.AppraiseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPaperSubViewpoint.AppraiseCount].ToString().Trim()); //评论数
objvPaperSubViewpointEN.OkCount = objRow[convPaperSubViewpoint.OkCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPaperSubViewpoint.OkCount].ToString().Trim()); //点赞统计
objvPaperSubViewpointEN.Score = objRow[convPaperSubViewpoint.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convPaperSubViewpoint.Score].ToString().Trim()); //评分
objvPaperSubViewpointEN.StuScore = objRow[convPaperSubViewpoint.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convPaperSubViewpoint.StuScore].ToString().Trim()); //学生平均分
objvPaperSubViewpointEN.TeaScore = objRow[convPaperSubViewpoint.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convPaperSubViewpoint.TeaScore].ToString().Trim()); //教师评分
objvPaperSubViewpointEN.CreateDate = objRow[convPaperSubViewpoint.CreateDate] == DBNull.Value ? null : objRow[convPaperSubViewpoint.CreateDate].ToString().Trim(); //建立日期
objvPaperSubViewpointEN.ShareId = objRow[convPaperSubViewpoint.ShareId].ToString().Trim(); //分享Id
objvPaperSubViewpointEN.AttitudesId = objRow[convPaperSubViewpoint.AttitudesId].ToString().Trim(); //态度Id
objvPaperSubViewpointEN.AttitudesName = objRow[convPaperSubViewpoint.AttitudesName] == DBNull.Value ? null : objRow[convPaperSubViewpoint.AttitudesName].ToString().Trim(); //名称
objvPaperSubViewpointEN.UpdDate = objRow[convPaperSubViewpoint.UpdDate] == DBNull.Value ? null : objRow[convPaperSubViewpoint.UpdDate].ToString().Trim(); //修改日期
objvPaperSubViewpointEN.UpdUser = objRow[convPaperSubViewpoint.UpdUser] == DBNull.Value ? null : objRow[convPaperSubViewpoint.UpdUser].ToString().Trim(); //修改人
objvPaperSubViewpointEN.Memo = objRow[convPaperSubViewpoint.Memo] == DBNull.Value ? null : objRow[convPaperSubViewpoint.Memo].ToString().Trim(); //备注
objvPaperSubViewpointEN.SectionOrderNum = objRow[convPaperSubViewpoint.SectionOrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPaperSubViewpoint.SectionOrderNum].ToString().Trim()); //SectionOrderNum
objvPaperSubViewpointEN.SubViewpointTypeOrderNum = objRow[convPaperSubViewpoint.SubViewpointTypeOrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPaperSubViewpoint.SubViewpointTypeOrderNum].ToString().Trim()); //子观点类型序号
objvPaperSubViewpointEN.CitationCount = objRow[convPaperSubViewpoint.CitationCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPaperSubViewpoint.CitationCount].ToString().Trim()); //引用统计
objvPaperSubViewpointEN.VersionCount = objRow[convPaperSubViewpoint.VersionCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPaperSubViewpoint.VersionCount].ToString().Trim()); //版本统计
objvPaperSubViewpointEN.IsRecommend = clsEntityBase2.TransNullToBool_S(objRow[convPaperSubViewpoint.IsRecommend].ToString().Trim()); //是否推荐
objvPaperSubViewpointEN.gsKnowledgeTypeName = objRow[convPaperSubViewpoint.gsKnowledgeTypeName].ToString().Trim(); //知识类型名
objvPaperSubViewpointEN.LevelName = objRow[convPaperSubViewpoint.LevelName] == DBNull.Value ? null : objRow[convPaperSubViewpoint.LevelName].ToString().Trim(); //级别名称
objvPaperSubViewpointEN.OperationTypeName = objRow[convPaperSubViewpoint.OperationTypeName] == DBNull.Value ? null : objRow[convPaperSubViewpoint.OperationTypeName].ToString().Trim(); //操作类型名
objvPaperSubViewpointEN.CourseId = objRow[convPaperSubViewpoint.CourseId] == DBNull.Value ? null : objRow[convPaperSubViewpoint.CourseId].ToString().Trim(); //课程Id
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvPaperSubViewpointEN.SubViewpointId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvPaperSubViewpointEN);
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
public static List<clsvPaperSubViewpointEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsvPaperSubViewpointEN> arrObjLst = new List<clsvPaperSubViewpointEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvPaperSubViewpointEN objvPaperSubViewpointEN = new clsvPaperSubViewpointEN();
try
{
objvPaperSubViewpointEN.SubViewpointId = Int32.Parse(objRow[convPaperSubViewpoint.SubViewpointId].ToString().Trim()); //子观点Id
objvPaperSubViewpointEN.SubViewpointContent = objRow[convPaperSubViewpoint.SubViewpointContent] == DBNull.Value ? null : objRow[convPaperSubViewpoint.SubViewpointContent].ToString().Trim(); //详情内容
objvPaperSubViewpointEN.PaperRWId = objRow[convPaperSubViewpoint.PaperRWId] == DBNull.Value ? null : objRow[convPaperSubViewpoint.PaperRWId].ToString().Trim(); //课文阅读
objvPaperSubViewpointEN.PaperId = objRow[convPaperSubViewpoint.PaperId] == DBNull.Value ? null : objRow[convPaperSubViewpoint.PaperId].ToString().Trim(); //论文Id
objvPaperSubViewpointEN.PaperTitle = objRow[convPaperSubViewpoint.PaperTitle] == DBNull.Value ? null : objRow[convPaperSubViewpoint.PaperTitle].ToString().Trim(); //论文标题
objvPaperSubViewpointEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[convPaperSubViewpoint.IsSubmit].ToString().Trim()); //是否提交
objvPaperSubViewpointEN.IdCurrEduCls = objRow[convPaperSubViewpoint.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvPaperSubViewpointEN.UserId = objRow[convPaperSubViewpoint.UserId].ToString().Trim(); //用户ID
objvPaperSubViewpointEN.SectionId = objRow[convPaperSubViewpoint.SectionId] == DBNull.Value ? null : objRow[convPaperSubViewpoint.SectionId].ToString().Trim(); //节Id
objvPaperSubViewpointEN.SectionName = objRow[convPaperSubViewpoint.SectionName] == DBNull.Value ? null : objRow[convPaperSubViewpoint.SectionName].ToString().Trim(); //节名
objvPaperSubViewpointEN.SubViewpointTypeId = objRow[convPaperSubViewpoint.SubViewpointTypeId].ToString().Trim(); //类型Id
objvPaperSubViewpointEN.SubViewpointTypeName = objRow[convPaperSubViewpoint.SubViewpointTypeName] == DBNull.Value ? null : objRow[convPaperSubViewpoint.SubViewpointTypeName].ToString().Trim(); //类型名称
objvPaperSubViewpointEN.DefaTitle = objRow[convPaperSubViewpoint.DefaTitle] == DBNull.Value ? null : objRow[convPaperSubViewpoint.DefaTitle].ToString().Trim(); //默认标题
objvPaperSubViewpointEN.gsKnowledgeTypeId = objRow[convPaperSubViewpoint.gsKnowledgeTypeId].ToString().Trim(); //知识类型Id
objvPaperSubViewpointEN.RWTitle = objRow[convPaperSubViewpoint.RWTitle] == DBNull.Value ? null : objRow[convPaperSubViewpoint.RWTitle].ToString().Trim(); //读写标题
objvPaperSubViewpointEN.ExplainTypeId = objRow[convPaperSubViewpoint.ExplainTypeId] == DBNull.Value ? null : objRow[convPaperSubViewpoint.ExplainTypeId].ToString().Trim(); //说明类型Id
objvPaperSubViewpointEN.ExplainTypeName = objRow[convPaperSubViewpoint.ExplainTypeName] == DBNull.Value ? null : objRow[convPaperSubViewpoint.ExplainTypeName].ToString().Trim(); //说明类型名
objvPaperSubViewpointEN.ExplainContent = objRow[convPaperSubViewpoint.ExplainContent] == DBNull.Value ? null : objRow[convPaperSubViewpoint.ExplainContent].ToString().Trim(); //说明内容
objvPaperSubViewpointEN.IsPublic = clsEntityBase2.TransNullToBool_S(objRow[convPaperSubViewpoint.IsPublic].ToString().Trim()); //是否公开
objvPaperSubViewpointEN.LiteratureSourcesId = objRow[convPaperSubViewpoint.LiteratureSourcesId] == DBNull.Value ? null : objRow[convPaperSubViewpoint.LiteratureSourcesId].ToString().Trim(); //文献来源
objvPaperSubViewpointEN.OperationTypeId = objRow[convPaperSubViewpoint.OperationTypeId] == DBNull.Value ? null : objRow[convPaperSubViewpoint.OperationTypeId].ToString().Trim(); //操作类型ID
objvPaperSubViewpointEN.LevelId = objRow[convPaperSubViewpoint.LevelId] == DBNull.Value ? null : objRow[convPaperSubViewpoint.LevelId].ToString().Trim(); //级别Id
objvPaperSubViewpointEN.Conclusion = objRow[convPaperSubViewpoint.Conclusion] == DBNull.Value ? null : objRow[convPaperSubViewpoint.Conclusion].ToString().Trim(); //结论
objvPaperSubViewpointEN.Nationality = objRow[convPaperSubViewpoint.Nationality] == DBNull.Value ? null : objRow[convPaperSubViewpoint.Nationality].ToString().Trim(); //国籍
objvPaperSubViewpointEN.Achievement = objRow[convPaperSubViewpoint.Achievement] == DBNull.Value ? null : objRow[convPaperSubViewpoint.Achievement].ToString().Trim(); //成就
objvPaperSubViewpointEN.Major = objRow[convPaperSubViewpoint.Major] == DBNull.Value ? null : objRow[convPaperSubViewpoint.Major].ToString().Trim(); //专业
objvPaperSubViewpointEN.WorkUnit = objRow[convPaperSubViewpoint.WorkUnit] == DBNull.Value ? null : objRow[convPaperSubViewpoint.WorkUnit].ToString().Trim(); //工作单位
objvPaperSubViewpointEN.PageNumber = objRow[convPaperSubViewpoint.PageNumber] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPaperSubViewpoint.PageNumber].ToString().Trim()); //页码
objvPaperSubViewpointEN.OrderNum = objRow[convPaperSubViewpoint.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPaperSubViewpoint.OrderNum].ToString().Trim()); //序号
objvPaperSubViewpointEN.PdfContent = objRow[convPaperSubViewpoint.PdfContent] == DBNull.Value ? null : objRow[convPaperSubViewpoint.PdfContent].ToString().Trim(); //Pdf内容
objvPaperSubViewpointEN.selectSpanRange = objRow[convPaperSubViewpoint.selectSpanRange] == DBNull.Value ? null : objRow[convPaperSubViewpoint.selectSpanRange].ToString().Trim(); //选择Span范围
objvPaperSubViewpointEN.PaperLineNum = objRow[convPaperSubViewpoint.PaperLineNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPaperSubViewpoint.PaperLineNum].ToString().Trim()); //论文行号
objvPaperSubViewpointEN.PaperPageNum = objRow[convPaperSubViewpoint.PaperPageNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPaperSubViewpoint.PaperPageNum].ToString().Trim()); //论文页码
objvPaperSubViewpointEN.AppraiseCount = objRow[convPaperSubViewpoint.AppraiseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPaperSubViewpoint.AppraiseCount].ToString().Trim()); //评论数
objvPaperSubViewpointEN.OkCount = objRow[convPaperSubViewpoint.OkCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPaperSubViewpoint.OkCount].ToString().Trim()); //点赞统计
objvPaperSubViewpointEN.Score = objRow[convPaperSubViewpoint.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convPaperSubViewpoint.Score].ToString().Trim()); //评分
objvPaperSubViewpointEN.StuScore = objRow[convPaperSubViewpoint.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convPaperSubViewpoint.StuScore].ToString().Trim()); //学生平均分
objvPaperSubViewpointEN.TeaScore = objRow[convPaperSubViewpoint.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convPaperSubViewpoint.TeaScore].ToString().Trim()); //教师评分
objvPaperSubViewpointEN.CreateDate = objRow[convPaperSubViewpoint.CreateDate] == DBNull.Value ? null : objRow[convPaperSubViewpoint.CreateDate].ToString().Trim(); //建立日期
objvPaperSubViewpointEN.ShareId = objRow[convPaperSubViewpoint.ShareId].ToString().Trim(); //分享Id
objvPaperSubViewpointEN.AttitudesId = objRow[convPaperSubViewpoint.AttitudesId].ToString().Trim(); //态度Id
objvPaperSubViewpointEN.AttitudesName = objRow[convPaperSubViewpoint.AttitudesName] == DBNull.Value ? null : objRow[convPaperSubViewpoint.AttitudesName].ToString().Trim(); //名称
objvPaperSubViewpointEN.UpdDate = objRow[convPaperSubViewpoint.UpdDate] == DBNull.Value ? null : objRow[convPaperSubViewpoint.UpdDate].ToString().Trim(); //修改日期
objvPaperSubViewpointEN.UpdUser = objRow[convPaperSubViewpoint.UpdUser] == DBNull.Value ? null : objRow[convPaperSubViewpoint.UpdUser].ToString().Trim(); //修改人
objvPaperSubViewpointEN.Memo = objRow[convPaperSubViewpoint.Memo] == DBNull.Value ? null : objRow[convPaperSubViewpoint.Memo].ToString().Trim(); //备注
objvPaperSubViewpointEN.SectionOrderNum = objRow[convPaperSubViewpoint.SectionOrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPaperSubViewpoint.SectionOrderNum].ToString().Trim()); //SectionOrderNum
objvPaperSubViewpointEN.SubViewpointTypeOrderNum = objRow[convPaperSubViewpoint.SubViewpointTypeOrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPaperSubViewpoint.SubViewpointTypeOrderNum].ToString().Trim()); //子观点类型序号
objvPaperSubViewpointEN.CitationCount = objRow[convPaperSubViewpoint.CitationCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPaperSubViewpoint.CitationCount].ToString().Trim()); //引用统计
objvPaperSubViewpointEN.VersionCount = objRow[convPaperSubViewpoint.VersionCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPaperSubViewpoint.VersionCount].ToString().Trim()); //版本统计
objvPaperSubViewpointEN.IsRecommend = clsEntityBase2.TransNullToBool_S(objRow[convPaperSubViewpoint.IsRecommend].ToString().Trim()); //是否推荐
objvPaperSubViewpointEN.gsKnowledgeTypeName = objRow[convPaperSubViewpoint.gsKnowledgeTypeName].ToString().Trim(); //知识类型名
objvPaperSubViewpointEN.LevelName = objRow[convPaperSubViewpoint.LevelName] == DBNull.Value ? null : objRow[convPaperSubViewpoint.LevelName].ToString().Trim(); //级别名称
objvPaperSubViewpointEN.OperationTypeName = objRow[convPaperSubViewpoint.OperationTypeName] == DBNull.Value ? null : objRow[convPaperSubViewpoint.OperationTypeName].ToString().Trim(); //操作类型名
objvPaperSubViewpointEN.CourseId = objRow[convPaperSubViewpoint.CourseId] == DBNull.Value ? null : objRow[convPaperSubViewpoint.CourseId].ToString().Trim(); //课程Id
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvPaperSubViewpointEN.SubViewpointId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvPaperSubViewpointEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objvPaperSubViewpointCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsvPaperSubViewpointEN> GetSubObjLstCache(clsvPaperSubViewpointEN objvPaperSubViewpointCond)
{
 string strIdCurrEduCls = objvPaperSubViewpointCond.IdCurrEduCls;
 if (string.IsNullOrEmpty(strIdCurrEduCls) == true)
{
string strMsg = string.Format("(errid:Busi000172)在表中,缓存分类字段值不能为空!(clsvPaperSubViewpointBL:GetSubObjLstCache)");
throw new Exception(strMsg);
}
List<clsvPaperSubViewpointEN> arrObjLstCache = GetObjLstCache(strIdCurrEduCls);
IEnumerable <clsvPaperSubViewpointEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convPaperSubViewpoint.AttributeName)
{
if (objvPaperSubViewpointCond.IsUpdated(strFldName) == false) continue;
if (objvPaperSubViewpointCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvPaperSubViewpointCond[strFldName].ToString());
}
else
{
if (objvPaperSubViewpointCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvPaperSubViewpointCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvPaperSubViewpointCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvPaperSubViewpointCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvPaperSubViewpointCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvPaperSubViewpointCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvPaperSubViewpointCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvPaperSubViewpointCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvPaperSubViewpointCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvPaperSubViewpointCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvPaperSubViewpointCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvPaperSubViewpointCond[strFldName]));
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
public static List<clsvPaperSubViewpointEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsvPaperSubViewpointEN> arrObjLst = new List<clsvPaperSubViewpointEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvPaperSubViewpointEN objvPaperSubViewpointEN = new clsvPaperSubViewpointEN();
try
{
objvPaperSubViewpointEN.SubViewpointId = Int32.Parse(objRow[convPaperSubViewpoint.SubViewpointId].ToString().Trim()); //子观点Id
objvPaperSubViewpointEN.SubViewpointContent = objRow[convPaperSubViewpoint.SubViewpointContent] == DBNull.Value ? null : objRow[convPaperSubViewpoint.SubViewpointContent].ToString().Trim(); //详情内容
objvPaperSubViewpointEN.PaperRWId = objRow[convPaperSubViewpoint.PaperRWId] == DBNull.Value ? null : objRow[convPaperSubViewpoint.PaperRWId].ToString().Trim(); //课文阅读
objvPaperSubViewpointEN.PaperId = objRow[convPaperSubViewpoint.PaperId] == DBNull.Value ? null : objRow[convPaperSubViewpoint.PaperId].ToString().Trim(); //论文Id
objvPaperSubViewpointEN.PaperTitle = objRow[convPaperSubViewpoint.PaperTitle] == DBNull.Value ? null : objRow[convPaperSubViewpoint.PaperTitle].ToString().Trim(); //论文标题
objvPaperSubViewpointEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[convPaperSubViewpoint.IsSubmit].ToString().Trim()); //是否提交
objvPaperSubViewpointEN.IdCurrEduCls = objRow[convPaperSubViewpoint.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvPaperSubViewpointEN.UserId = objRow[convPaperSubViewpoint.UserId].ToString().Trim(); //用户ID
objvPaperSubViewpointEN.SectionId = objRow[convPaperSubViewpoint.SectionId] == DBNull.Value ? null : objRow[convPaperSubViewpoint.SectionId].ToString().Trim(); //节Id
objvPaperSubViewpointEN.SectionName = objRow[convPaperSubViewpoint.SectionName] == DBNull.Value ? null : objRow[convPaperSubViewpoint.SectionName].ToString().Trim(); //节名
objvPaperSubViewpointEN.SubViewpointTypeId = objRow[convPaperSubViewpoint.SubViewpointTypeId].ToString().Trim(); //类型Id
objvPaperSubViewpointEN.SubViewpointTypeName = objRow[convPaperSubViewpoint.SubViewpointTypeName] == DBNull.Value ? null : objRow[convPaperSubViewpoint.SubViewpointTypeName].ToString().Trim(); //类型名称
objvPaperSubViewpointEN.DefaTitle = objRow[convPaperSubViewpoint.DefaTitle] == DBNull.Value ? null : objRow[convPaperSubViewpoint.DefaTitle].ToString().Trim(); //默认标题
objvPaperSubViewpointEN.gsKnowledgeTypeId = objRow[convPaperSubViewpoint.gsKnowledgeTypeId].ToString().Trim(); //知识类型Id
objvPaperSubViewpointEN.RWTitle = objRow[convPaperSubViewpoint.RWTitle] == DBNull.Value ? null : objRow[convPaperSubViewpoint.RWTitle].ToString().Trim(); //读写标题
objvPaperSubViewpointEN.ExplainTypeId = objRow[convPaperSubViewpoint.ExplainTypeId] == DBNull.Value ? null : objRow[convPaperSubViewpoint.ExplainTypeId].ToString().Trim(); //说明类型Id
objvPaperSubViewpointEN.ExplainTypeName = objRow[convPaperSubViewpoint.ExplainTypeName] == DBNull.Value ? null : objRow[convPaperSubViewpoint.ExplainTypeName].ToString().Trim(); //说明类型名
objvPaperSubViewpointEN.ExplainContent = objRow[convPaperSubViewpoint.ExplainContent] == DBNull.Value ? null : objRow[convPaperSubViewpoint.ExplainContent].ToString().Trim(); //说明内容
objvPaperSubViewpointEN.IsPublic = clsEntityBase2.TransNullToBool_S(objRow[convPaperSubViewpoint.IsPublic].ToString().Trim()); //是否公开
objvPaperSubViewpointEN.LiteratureSourcesId = objRow[convPaperSubViewpoint.LiteratureSourcesId] == DBNull.Value ? null : objRow[convPaperSubViewpoint.LiteratureSourcesId].ToString().Trim(); //文献来源
objvPaperSubViewpointEN.OperationTypeId = objRow[convPaperSubViewpoint.OperationTypeId] == DBNull.Value ? null : objRow[convPaperSubViewpoint.OperationTypeId].ToString().Trim(); //操作类型ID
objvPaperSubViewpointEN.LevelId = objRow[convPaperSubViewpoint.LevelId] == DBNull.Value ? null : objRow[convPaperSubViewpoint.LevelId].ToString().Trim(); //级别Id
objvPaperSubViewpointEN.Conclusion = objRow[convPaperSubViewpoint.Conclusion] == DBNull.Value ? null : objRow[convPaperSubViewpoint.Conclusion].ToString().Trim(); //结论
objvPaperSubViewpointEN.Nationality = objRow[convPaperSubViewpoint.Nationality] == DBNull.Value ? null : objRow[convPaperSubViewpoint.Nationality].ToString().Trim(); //国籍
objvPaperSubViewpointEN.Achievement = objRow[convPaperSubViewpoint.Achievement] == DBNull.Value ? null : objRow[convPaperSubViewpoint.Achievement].ToString().Trim(); //成就
objvPaperSubViewpointEN.Major = objRow[convPaperSubViewpoint.Major] == DBNull.Value ? null : objRow[convPaperSubViewpoint.Major].ToString().Trim(); //专业
objvPaperSubViewpointEN.WorkUnit = objRow[convPaperSubViewpoint.WorkUnit] == DBNull.Value ? null : objRow[convPaperSubViewpoint.WorkUnit].ToString().Trim(); //工作单位
objvPaperSubViewpointEN.PageNumber = objRow[convPaperSubViewpoint.PageNumber] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPaperSubViewpoint.PageNumber].ToString().Trim()); //页码
objvPaperSubViewpointEN.OrderNum = objRow[convPaperSubViewpoint.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPaperSubViewpoint.OrderNum].ToString().Trim()); //序号
objvPaperSubViewpointEN.PdfContent = objRow[convPaperSubViewpoint.PdfContent] == DBNull.Value ? null : objRow[convPaperSubViewpoint.PdfContent].ToString().Trim(); //Pdf内容
objvPaperSubViewpointEN.selectSpanRange = objRow[convPaperSubViewpoint.selectSpanRange] == DBNull.Value ? null : objRow[convPaperSubViewpoint.selectSpanRange].ToString().Trim(); //选择Span范围
objvPaperSubViewpointEN.PaperLineNum = objRow[convPaperSubViewpoint.PaperLineNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPaperSubViewpoint.PaperLineNum].ToString().Trim()); //论文行号
objvPaperSubViewpointEN.PaperPageNum = objRow[convPaperSubViewpoint.PaperPageNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPaperSubViewpoint.PaperPageNum].ToString().Trim()); //论文页码
objvPaperSubViewpointEN.AppraiseCount = objRow[convPaperSubViewpoint.AppraiseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPaperSubViewpoint.AppraiseCount].ToString().Trim()); //评论数
objvPaperSubViewpointEN.OkCount = objRow[convPaperSubViewpoint.OkCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPaperSubViewpoint.OkCount].ToString().Trim()); //点赞统计
objvPaperSubViewpointEN.Score = objRow[convPaperSubViewpoint.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convPaperSubViewpoint.Score].ToString().Trim()); //评分
objvPaperSubViewpointEN.StuScore = objRow[convPaperSubViewpoint.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convPaperSubViewpoint.StuScore].ToString().Trim()); //学生平均分
objvPaperSubViewpointEN.TeaScore = objRow[convPaperSubViewpoint.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convPaperSubViewpoint.TeaScore].ToString().Trim()); //教师评分
objvPaperSubViewpointEN.CreateDate = objRow[convPaperSubViewpoint.CreateDate] == DBNull.Value ? null : objRow[convPaperSubViewpoint.CreateDate].ToString().Trim(); //建立日期
objvPaperSubViewpointEN.ShareId = objRow[convPaperSubViewpoint.ShareId].ToString().Trim(); //分享Id
objvPaperSubViewpointEN.AttitudesId = objRow[convPaperSubViewpoint.AttitudesId].ToString().Trim(); //态度Id
objvPaperSubViewpointEN.AttitudesName = objRow[convPaperSubViewpoint.AttitudesName] == DBNull.Value ? null : objRow[convPaperSubViewpoint.AttitudesName].ToString().Trim(); //名称
objvPaperSubViewpointEN.UpdDate = objRow[convPaperSubViewpoint.UpdDate] == DBNull.Value ? null : objRow[convPaperSubViewpoint.UpdDate].ToString().Trim(); //修改日期
objvPaperSubViewpointEN.UpdUser = objRow[convPaperSubViewpoint.UpdUser] == DBNull.Value ? null : objRow[convPaperSubViewpoint.UpdUser].ToString().Trim(); //修改人
objvPaperSubViewpointEN.Memo = objRow[convPaperSubViewpoint.Memo] == DBNull.Value ? null : objRow[convPaperSubViewpoint.Memo].ToString().Trim(); //备注
objvPaperSubViewpointEN.SectionOrderNum = objRow[convPaperSubViewpoint.SectionOrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPaperSubViewpoint.SectionOrderNum].ToString().Trim()); //SectionOrderNum
objvPaperSubViewpointEN.SubViewpointTypeOrderNum = objRow[convPaperSubViewpoint.SubViewpointTypeOrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPaperSubViewpoint.SubViewpointTypeOrderNum].ToString().Trim()); //子观点类型序号
objvPaperSubViewpointEN.CitationCount = objRow[convPaperSubViewpoint.CitationCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPaperSubViewpoint.CitationCount].ToString().Trim()); //引用统计
objvPaperSubViewpointEN.VersionCount = objRow[convPaperSubViewpoint.VersionCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPaperSubViewpoint.VersionCount].ToString().Trim()); //版本统计
objvPaperSubViewpointEN.IsRecommend = clsEntityBase2.TransNullToBool_S(objRow[convPaperSubViewpoint.IsRecommend].ToString().Trim()); //是否推荐
objvPaperSubViewpointEN.gsKnowledgeTypeName = objRow[convPaperSubViewpoint.gsKnowledgeTypeName].ToString().Trim(); //知识类型名
objvPaperSubViewpointEN.LevelName = objRow[convPaperSubViewpoint.LevelName] == DBNull.Value ? null : objRow[convPaperSubViewpoint.LevelName].ToString().Trim(); //级别名称
objvPaperSubViewpointEN.OperationTypeName = objRow[convPaperSubViewpoint.OperationTypeName] == DBNull.Value ? null : objRow[convPaperSubViewpoint.OperationTypeName].ToString().Trim(); //操作类型名
objvPaperSubViewpointEN.CourseId = objRow[convPaperSubViewpoint.CourseId] == DBNull.Value ? null : objRow[convPaperSubViewpoint.CourseId].ToString().Trim(); //课程Id
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvPaperSubViewpointEN.SubViewpointId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvPaperSubViewpointEN);
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
public static List<clsvPaperSubViewpointEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsvPaperSubViewpointEN> arrObjLst = new List<clsvPaperSubViewpointEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvPaperSubViewpointEN objvPaperSubViewpointEN = new clsvPaperSubViewpointEN();
try
{
objvPaperSubViewpointEN.SubViewpointId = Int32.Parse(objRow[convPaperSubViewpoint.SubViewpointId].ToString().Trim()); //子观点Id
objvPaperSubViewpointEN.SubViewpointContent = objRow[convPaperSubViewpoint.SubViewpointContent] == DBNull.Value ? null : objRow[convPaperSubViewpoint.SubViewpointContent].ToString().Trim(); //详情内容
objvPaperSubViewpointEN.PaperRWId = objRow[convPaperSubViewpoint.PaperRWId] == DBNull.Value ? null : objRow[convPaperSubViewpoint.PaperRWId].ToString().Trim(); //课文阅读
objvPaperSubViewpointEN.PaperId = objRow[convPaperSubViewpoint.PaperId] == DBNull.Value ? null : objRow[convPaperSubViewpoint.PaperId].ToString().Trim(); //论文Id
objvPaperSubViewpointEN.PaperTitle = objRow[convPaperSubViewpoint.PaperTitle] == DBNull.Value ? null : objRow[convPaperSubViewpoint.PaperTitle].ToString().Trim(); //论文标题
objvPaperSubViewpointEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[convPaperSubViewpoint.IsSubmit].ToString().Trim()); //是否提交
objvPaperSubViewpointEN.IdCurrEduCls = objRow[convPaperSubViewpoint.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvPaperSubViewpointEN.UserId = objRow[convPaperSubViewpoint.UserId].ToString().Trim(); //用户ID
objvPaperSubViewpointEN.SectionId = objRow[convPaperSubViewpoint.SectionId] == DBNull.Value ? null : objRow[convPaperSubViewpoint.SectionId].ToString().Trim(); //节Id
objvPaperSubViewpointEN.SectionName = objRow[convPaperSubViewpoint.SectionName] == DBNull.Value ? null : objRow[convPaperSubViewpoint.SectionName].ToString().Trim(); //节名
objvPaperSubViewpointEN.SubViewpointTypeId = objRow[convPaperSubViewpoint.SubViewpointTypeId].ToString().Trim(); //类型Id
objvPaperSubViewpointEN.SubViewpointTypeName = objRow[convPaperSubViewpoint.SubViewpointTypeName] == DBNull.Value ? null : objRow[convPaperSubViewpoint.SubViewpointTypeName].ToString().Trim(); //类型名称
objvPaperSubViewpointEN.DefaTitle = objRow[convPaperSubViewpoint.DefaTitle] == DBNull.Value ? null : objRow[convPaperSubViewpoint.DefaTitle].ToString().Trim(); //默认标题
objvPaperSubViewpointEN.gsKnowledgeTypeId = objRow[convPaperSubViewpoint.gsKnowledgeTypeId].ToString().Trim(); //知识类型Id
objvPaperSubViewpointEN.RWTitle = objRow[convPaperSubViewpoint.RWTitle] == DBNull.Value ? null : objRow[convPaperSubViewpoint.RWTitle].ToString().Trim(); //读写标题
objvPaperSubViewpointEN.ExplainTypeId = objRow[convPaperSubViewpoint.ExplainTypeId] == DBNull.Value ? null : objRow[convPaperSubViewpoint.ExplainTypeId].ToString().Trim(); //说明类型Id
objvPaperSubViewpointEN.ExplainTypeName = objRow[convPaperSubViewpoint.ExplainTypeName] == DBNull.Value ? null : objRow[convPaperSubViewpoint.ExplainTypeName].ToString().Trim(); //说明类型名
objvPaperSubViewpointEN.ExplainContent = objRow[convPaperSubViewpoint.ExplainContent] == DBNull.Value ? null : objRow[convPaperSubViewpoint.ExplainContent].ToString().Trim(); //说明内容
objvPaperSubViewpointEN.IsPublic = clsEntityBase2.TransNullToBool_S(objRow[convPaperSubViewpoint.IsPublic].ToString().Trim()); //是否公开
objvPaperSubViewpointEN.LiteratureSourcesId = objRow[convPaperSubViewpoint.LiteratureSourcesId] == DBNull.Value ? null : objRow[convPaperSubViewpoint.LiteratureSourcesId].ToString().Trim(); //文献来源
objvPaperSubViewpointEN.OperationTypeId = objRow[convPaperSubViewpoint.OperationTypeId] == DBNull.Value ? null : objRow[convPaperSubViewpoint.OperationTypeId].ToString().Trim(); //操作类型ID
objvPaperSubViewpointEN.LevelId = objRow[convPaperSubViewpoint.LevelId] == DBNull.Value ? null : objRow[convPaperSubViewpoint.LevelId].ToString().Trim(); //级别Id
objvPaperSubViewpointEN.Conclusion = objRow[convPaperSubViewpoint.Conclusion] == DBNull.Value ? null : objRow[convPaperSubViewpoint.Conclusion].ToString().Trim(); //结论
objvPaperSubViewpointEN.Nationality = objRow[convPaperSubViewpoint.Nationality] == DBNull.Value ? null : objRow[convPaperSubViewpoint.Nationality].ToString().Trim(); //国籍
objvPaperSubViewpointEN.Achievement = objRow[convPaperSubViewpoint.Achievement] == DBNull.Value ? null : objRow[convPaperSubViewpoint.Achievement].ToString().Trim(); //成就
objvPaperSubViewpointEN.Major = objRow[convPaperSubViewpoint.Major] == DBNull.Value ? null : objRow[convPaperSubViewpoint.Major].ToString().Trim(); //专业
objvPaperSubViewpointEN.WorkUnit = objRow[convPaperSubViewpoint.WorkUnit] == DBNull.Value ? null : objRow[convPaperSubViewpoint.WorkUnit].ToString().Trim(); //工作单位
objvPaperSubViewpointEN.PageNumber = objRow[convPaperSubViewpoint.PageNumber] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPaperSubViewpoint.PageNumber].ToString().Trim()); //页码
objvPaperSubViewpointEN.OrderNum = objRow[convPaperSubViewpoint.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPaperSubViewpoint.OrderNum].ToString().Trim()); //序号
objvPaperSubViewpointEN.PdfContent = objRow[convPaperSubViewpoint.PdfContent] == DBNull.Value ? null : objRow[convPaperSubViewpoint.PdfContent].ToString().Trim(); //Pdf内容
objvPaperSubViewpointEN.selectSpanRange = objRow[convPaperSubViewpoint.selectSpanRange] == DBNull.Value ? null : objRow[convPaperSubViewpoint.selectSpanRange].ToString().Trim(); //选择Span范围
objvPaperSubViewpointEN.PaperLineNum = objRow[convPaperSubViewpoint.PaperLineNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPaperSubViewpoint.PaperLineNum].ToString().Trim()); //论文行号
objvPaperSubViewpointEN.PaperPageNum = objRow[convPaperSubViewpoint.PaperPageNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPaperSubViewpoint.PaperPageNum].ToString().Trim()); //论文页码
objvPaperSubViewpointEN.AppraiseCount = objRow[convPaperSubViewpoint.AppraiseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPaperSubViewpoint.AppraiseCount].ToString().Trim()); //评论数
objvPaperSubViewpointEN.OkCount = objRow[convPaperSubViewpoint.OkCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPaperSubViewpoint.OkCount].ToString().Trim()); //点赞统计
objvPaperSubViewpointEN.Score = objRow[convPaperSubViewpoint.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convPaperSubViewpoint.Score].ToString().Trim()); //评分
objvPaperSubViewpointEN.StuScore = objRow[convPaperSubViewpoint.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convPaperSubViewpoint.StuScore].ToString().Trim()); //学生平均分
objvPaperSubViewpointEN.TeaScore = objRow[convPaperSubViewpoint.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convPaperSubViewpoint.TeaScore].ToString().Trim()); //教师评分
objvPaperSubViewpointEN.CreateDate = objRow[convPaperSubViewpoint.CreateDate] == DBNull.Value ? null : objRow[convPaperSubViewpoint.CreateDate].ToString().Trim(); //建立日期
objvPaperSubViewpointEN.ShareId = objRow[convPaperSubViewpoint.ShareId].ToString().Trim(); //分享Id
objvPaperSubViewpointEN.AttitudesId = objRow[convPaperSubViewpoint.AttitudesId].ToString().Trim(); //态度Id
objvPaperSubViewpointEN.AttitudesName = objRow[convPaperSubViewpoint.AttitudesName] == DBNull.Value ? null : objRow[convPaperSubViewpoint.AttitudesName].ToString().Trim(); //名称
objvPaperSubViewpointEN.UpdDate = objRow[convPaperSubViewpoint.UpdDate] == DBNull.Value ? null : objRow[convPaperSubViewpoint.UpdDate].ToString().Trim(); //修改日期
objvPaperSubViewpointEN.UpdUser = objRow[convPaperSubViewpoint.UpdUser] == DBNull.Value ? null : objRow[convPaperSubViewpoint.UpdUser].ToString().Trim(); //修改人
objvPaperSubViewpointEN.Memo = objRow[convPaperSubViewpoint.Memo] == DBNull.Value ? null : objRow[convPaperSubViewpoint.Memo].ToString().Trim(); //备注
objvPaperSubViewpointEN.SectionOrderNum = objRow[convPaperSubViewpoint.SectionOrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPaperSubViewpoint.SectionOrderNum].ToString().Trim()); //SectionOrderNum
objvPaperSubViewpointEN.SubViewpointTypeOrderNum = objRow[convPaperSubViewpoint.SubViewpointTypeOrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPaperSubViewpoint.SubViewpointTypeOrderNum].ToString().Trim()); //子观点类型序号
objvPaperSubViewpointEN.CitationCount = objRow[convPaperSubViewpoint.CitationCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPaperSubViewpoint.CitationCount].ToString().Trim()); //引用统计
objvPaperSubViewpointEN.VersionCount = objRow[convPaperSubViewpoint.VersionCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPaperSubViewpoint.VersionCount].ToString().Trim()); //版本统计
objvPaperSubViewpointEN.IsRecommend = clsEntityBase2.TransNullToBool_S(objRow[convPaperSubViewpoint.IsRecommend].ToString().Trim()); //是否推荐
objvPaperSubViewpointEN.gsKnowledgeTypeName = objRow[convPaperSubViewpoint.gsKnowledgeTypeName].ToString().Trim(); //知识类型名
objvPaperSubViewpointEN.LevelName = objRow[convPaperSubViewpoint.LevelName] == DBNull.Value ? null : objRow[convPaperSubViewpoint.LevelName].ToString().Trim(); //级别名称
objvPaperSubViewpointEN.OperationTypeName = objRow[convPaperSubViewpoint.OperationTypeName] == DBNull.Value ? null : objRow[convPaperSubViewpoint.OperationTypeName].ToString().Trim(); //操作类型名
objvPaperSubViewpointEN.CourseId = objRow[convPaperSubViewpoint.CourseId] == DBNull.Value ? null : objRow[convPaperSubViewpoint.CourseId].ToString().Trim(); //课程Id
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvPaperSubViewpointEN.SubViewpointId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvPaperSubViewpointEN);
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
List<clsvPaperSubViewpointEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsvPaperSubViewpointEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsvPaperSubViewpointEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsvPaperSubViewpointEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsvPaperSubViewpointEN> arrObjLst = new List<clsvPaperSubViewpointEN>(); 
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
	clsvPaperSubViewpointEN objvPaperSubViewpointEN = new clsvPaperSubViewpointEN();
try
{
objvPaperSubViewpointEN.SubViewpointId = Int32.Parse(objRow[convPaperSubViewpoint.SubViewpointId].ToString().Trim()); //子观点Id
objvPaperSubViewpointEN.SubViewpointContent = objRow[convPaperSubViewpoint.SubViewpointContent] == DBNull.Value ? null : objRow[convPaperSubViewpoint.SubViewpointContent].ToString().Trim(); //详情内容
objvPaperSubViewpointEN.PaperRWId = objRow[convPaperSubViewpoint.PaperRWId] == DBNull.Value ? null : objRow[convPaperSubViewpoint.PaperRWId].ToString().Trim(); //课文阅读
objvPaperSubViewpointEN.PaperId = objRow[convPaperSubViewpoint.PaperId] == DBNull.Value ? null : objRow[convPaperSubViewpoint.PaperId].ToString().Trim(); //论文Id
objvPaperSubViewpointEN.PaperTitle = objRow[convPaperSubViewpoint.PaperTitle] == DBNull.Value ? null : objRow[convPaperSubViewpoint.PaperTitle].ToString().Trim(); //论文标题
objvPaperSubViewpointEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[convPaperSubViewpoint.IsSubmit].ToString().Trim()); //是否提交
objvPaperSubViewpointEN.IdCurrEduCls = objRow[convPaperSubViewpoint.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvPaperSubViewpointEN.UserId = objRow[convPaperSubViewpoint.UserId].ToString().Trim(); //用户ID
objvPaperSubViewpointEN.SectionId = objRow[convPaperSubViewpoint.SectionId] == DBNull.Value ? null : objRow[convPaperSubViewpoint.SectionId].ToString().Trim(); //节Id
objvPaperSubViewpointEN.SectionName = objRow[convPaperSubViewpoint.SectionName] == DBNull.Value ? null : objRow[convPaperSubViewpoint.SectionName].ToString().Trim(); //节名
objvPaperSubViewpointEN.SubViewpointTypeId = objRow[convPaperSubViewpoint.SubViewpointTypeId].ToString().Trim(); //类型Id
objvPaperSubViewpointEN.SubViewpointTypeName = objRow[convPaperSubViewpoint.SubViewpointTypeName] == DBNull.Value ? null : objRow[convPaperSubViewpoint.SubViewpointTypeName].ToString().Trim(); //类型名称
objvPaperSubViewpointEN.DefaTitle = objRow[convPaperSubViewpoint.DefaTitle] == DBNull.Value ? null : objRow[convPaperSubViewpoint.DefaTitle].ToString().Trim(); //默认标题
objvPaperSubViewpointEN.gsKnowledgeTypeId = objRow[convPaperSubViewpoint.gsKnowledgeTypeId].ToString().Trim(); //知识类型Id
objvPaperSubViewpointEN.RWTitle = objRow[convPaperSubViewpoint.RWTitle] == DBNull.Value ? null : objRow[convPaperSubViewpoint.RWTitle].ToString().Trim(); //读写标题
objvPaperSubViewpointEN.ExplainTypeId = objRow[convPaperSubViewpoint.ExplainTypeId] == DBNull.Value ? null : objRow[convPaperSubViewpoint.ExplainTypeId].ToString().Trim(); //说明类型Id
objvPaperSubViewpointEN.ExplainTypeName = objRow[convPaperSubViewpoint.ExplainTypeName] == DBNull.Value ? null : objRow[convPaperSubViewpoint.ExplainTypeName].ToString().Trim(); //说明类型名
objvPaperSubViewpointEN.ExplainContent = objRow[convPaperSubViewpoint.ExplainContent] == DBNull.Value ? null : objRow[convPaperSubViewpoint.ExplainContent].ToString().Trim(); //说明内容
objvPaperSubViewpointEN.IsPublic = clsEntityBase2.TransNullToBool_S(objRow[convPaperSubViewpoint.IsPublic].ToString().Trim()); //是否公开
objvPaperSubViewpointEN.LiteratureSourcesId = objRow[convPaperSubViewpoint.LiteratureSourcesId] == DBNull.Value ? null : objRow[convPaperSubViewpoint.LiteratureSourcesId].ToString().Trim(); //文献来源
objvPaperSubViewpointEN.OperationTypeId = objRow[convPaperSubViewpoint.OperationTypeId] == DBNull.Value ? null : objRow[convPaperSubViewpoint.OperationTypeId].ToString().Trim(); //操作类型ID
objvPaperSubViewpointEN.LevelId = objRow[convPaperSubViewpoint.LevelId] == DBNull.Value ? null : objRow[convPaperSubViewpoint.LevelId].ToString().Trim(); //级别Id
objvPaperSubViewpointEN.Conclusion = objRow[convPaperSubViewpoint.Conclusion] == DBNull.Value ? null : objRow[convPaperSubViewpoint.Conclusion].ToString().Trim(); //结论
objvPaperSubViewpointEN.Nationality = objRow[convPaperSubViewpoint.Nationality] == DBNull.Value ? null : objRow[convPaperSubViewpoint.Nationality].ToString().Trim(); //国籍
objvPaperSubViewpointEN.Achievement = objRow[convPaperSubViewpoint.Achievement] == DBNull.Value ? null : objRow[convPaperSubViewpoint.Achievement].ToString().Trim(); //成就
objvPaperSubViewpointEN.Major = objRow[convPaperSubViewpoint.Major] == DBNull.Value ? null : objRow[convPaperSubViewpoint.Major].ToString().Trim(); //专业
objvPaperSubViewpointEN.WorkUnit = objRow[convPaperSubViewpoint.WorkUnit] == DBNull.Value ? null : objRow[convPaperSubViewpoint.WorkUnit].ToString().Trim(); //工作单位
objvPaperSubViewpointEN.PageNumber = objRow[convPaperSubViewpoint.PageNumber] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPaperSubViewpoint.PageNumber].ToString().Trim()); //页码
objvPaperSubViewpointEN.OrderNum = objRow[convPaperSubViewpoint.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPaperSubViewpoint.OrderNum].ToString().Trim()); //序号
objvPaperSubViewpointEN.PdfContent = objRow[convPaperSubViewpoint.PdfContent] == DBNull.Value ? null : objRow[convPaperSubViewpoint.PdfContent].ToString().Trim(); //Pdf内容
objvPaperSubViewpointEN.selectSpanRange = objRow[convPaperSubViewpoint.selectSpanRange] == DBNull.Value ? null : objRow[convPaperSubViewpoint.selectSpanRange].ToString().Trim(); //选择Span范围
objvPaperSubViewpointEN.PaperLineNum = objRow[convPaperSubViewpoint.PaperLineNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPaperSubViewpoint.PaperLineNum].ToString().Trim()); //论文行号
objvPaperSubViewpointEN.PaperPageNum = objRow[convPaperSubViewpoint.PaperPageNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPaperSubViewpoint.PaperPageNum].ToString().Trim()); //论文页码
objvPaperSubViewpointEN.AppraiseCount = objRow[convPaperSubViewpoint.AppraiseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPaperSubViewpoint.AppraiseCount].ToString().Trim()); //评论数
objvPaperSubViewpointEN.OkCount = objRow[convPaperSubViewpoint.OkCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPaperSubViewpoint.OkCount].ToString().Trim()); //点赞统计
objvPaperSubViewpointEN.Score = objRow[convPaperSubViewpoint.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convPaperSubViewpoint.Score].ToString().Trim()); //评分
objvPaperSubViewpointEN.StuScore = objRow[convPaperSubViewpoint.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convPaperSubViewpoint.StuScore].ToString().Trim()); //学生平均分
objvPaperSubViewpointEN.TeaScore = objRow[convPaperSubViewpoint.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convPaperSubViewpoint.TeaScore].ToString().Trim()); //教师评分
objvPaperSubViewpointEN.CreateDate = objRow[convPaperSubViewpoint.CreateDate] == DBNull.Value ? null : objRow[convPaperSubViewpoint.CreateDate].ToString().Trim(); //建立日期
objvPaperSubViewpointEN.ShareId = objRow[convPaperSubViewpoint.ShareId].ToString().Trim(); //分享Id
objvPaperSubViewpointEN.AttitudesId = objRow[convPaperSubViewpoint.AttitudesId].ToString().Trim(); //态度Id
objvPaperSubViewpointEN.AttitudesName = objRow[convPaperSubViewpoint.AttitudesName] == DBNull.Value ? null : objRow[convPaperSubViewpoint.AttitudesName].ToString().Trim(); //名称
objvPaperSubViewpointEN.UpdDate = objRow[convPaperSubViewpoint.UpdDate] == DBNull.Value ? null : objRow[convPaperSubViewpoint.UpdDate].ToString().Trim(); //修改日期
objvPaperSubViewpointEN.UpdUser = objRow[convPaperSubViewpoint.UpdUser] == DBNull.Value ? null : objRow[convPaperSubViewpoint.UpdUser].ToString().Trim(); //修改人
objvPaperSubViewpointEN.Memo = objRow[convPaperSubViewpoint.Memo] == DBNull.Value ? null : objRow[convPaperSubViewpoint.Memo].ToString().Trim(); //备注
objvPaperSubViewpointEN.SectionOrderNum = objRow[convPaperSubViewpoint.SectionOrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPaperSubViewpoint.SectionOrderNum].ToString().Trim()); //SectionOrderNum
objvPaperSubViewpointEN.SubViewpointTypeOrderNum = objRow[convPaperSubViewpoint.SubViewpointTypeOrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPaperSubViewpoint.SubViewpointTypeOrderNum].ToString().Trim()); //子观点类型序号
objvPaperSubViewpointEN.CitationCount = objRow[convPaperSubViewpoint.CitationCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPaperSubViewpoint.CitationCount].ToString().Trim()); //引用统计
objvPaperSubViewpointEN.VersionCount = objRow[convPaperSubViewpoint.VersionCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPaperSubViewpoint.VersionCount].ToString().Trim()); //版本统计
objvPaperSubViewpointEN.IsRecommend = clsEntityBase2.TransNullToBool_S(objRow[convPaperSubViewpoint.IsRecommend].ToString().Trim()); //是否推荐
objvPaperSubViewpointEN.gsKnowledgeTypeName = objRow[convPaperSubViewpoint.gsKnowledgeTypeName].ToString().Trim(); //知识类型名
objvPaperSubViewpointEN.LevelName = objRow[convPaperSubViewpoint.LevelName] == DBNull.Value ? null : objRow[convPaperSubViewpoint.LevelName].ToString().Trim(); //级别名称
objvPaperSubViewpointEN.OperationTypeName = objRow[convPaperSubViewpoint.OperationTypeName] == DBNull.Value ? null : objRow[convPaperSubViewpoint.OperationTypeName].ToString().Trim(); //操作类型名
objvPaperSubViewpointEN.CourseId = objRow[convPaperSubViewpoint.CourseId] == DBNull.Value ? null : objRow[convPaperSubViewpoint.CourseId].ToString().Trim(); //课程Id
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvPaperSubViewpointEN.SubViewpointId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvPaperSubViewpointEN);
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
public static List<clsvPaperSubViewpointEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsvPaperSubViewpointEN> arrObjLst = new List<clsvPaperSubViewpointEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvPaperSubViewpointEN objvPaperSubViewpointEN = new clsvPaperSubViewpointEN();
try
{
objvPaperSubViewpointEN.SubViewpointId = Int32.Parse(objRow[convPaperSubViewpoint.SubViewpointId].ToString().Trim()); //子观点Id
objvPaperSubViewpointEN.SubViewpointContent = objRow[convPaperSubViewpoint.SubViewpointContent] == DBNull.Value ? null : objRow[convPaperSubViewpoint.SubViewpointContent].ToString().Trim(); //详情内容
objvPaperSubViewpointEN.PaperRWId = objRow[convPaperSubViewpoint.PaperRWId] == DBNull.Value ? null : objRow[convPaperSubViewpoint.PaperRWId].ToString().Trim(); //课文阅读
objvPaperSubViewpointEN.PaperId = objRow[convPaperSubViewpoint.PaperId] == DBNull.Value ? null : objRow[convPaperSubViewpoint.PaperId].ToString().Trim(); //论文Id
objvPaperSubViewpointEN.PaperTitle = objRow[convPaperSubViewpoint.PaperTitle] == DBNull.Value ? null : objRow[convPaperSubViewpoint.PaperTitle].ToString().Trim(); //论文标题
objvPaperSubViewpointEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[convPaperSubViewpoint.IsSubmit].ToString().Trim()); //是否提交
objvPaperSubViewpointEN.IdCurrEduCls = objRow[convPaperSubViewpoint.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvPaperSubViewpointEN.UserId = objRow[convPaperSubViewpoint.UserId].ToString().Trim(); //用户ID
objvPaperSubViewpointEN.SectionId = objRow[convPaperSubViewpoint.SectionId] == DBNull.Value ? null : objRow[convPaperSubViewpoint.SectionId].ToString().Trim(); //节Id
objvPaperSubViewpointEN.SectionName = objRow[convPaperSubViewpoint.SectionName] == DBNull.Value ? null : objRow[convPaperSubViewpoint.SectionName].ToString().Trim(); //节名
objvPaperSubViewpointEN.SubViewpointTypeId = objRow[convPaperSubViewpoint.SubViewpointTypeId].ToString().Trim(); //类型Id
objvPaperSubViewpointEN.SubViewpointTypeName = objRow[convPaperSubViewpoint.SubViewpointTypeName] == DBNull.Value ? null : objRow[convPaperSubViewpoint.SubViewpointTypeName].ToString().Trim(); //类型名称
objvPaperSubViewpointEN.DefaTitle = objRow[convPaperSubViewpoint.DefaTitle] == DBNull.Value ? null : objRow[convPaperSubViewpoint.DefaTitle].ToString().Trim(); //默认标题
objvPaperSubViewpointEN.gsKnowledgeTypeId = objRow[convPaperSubViewpoint.gsKnowledgeTypeId].ToString().Trim(); //知识类型Id
objvPaperSubViewpointEN.RWTitle = objRow[convPaperSubViewpoint.RWTitle] == DBNull.Value ? null : objRow[convPaperSubViewpoint.RWTitle].ToString().Trim(); //读写标题
objvPaperSubViewpointEN.ExplainTypeId = objRow[convPaperSubViewpoint.ExplainTypeId] == DBNull.Value ? null : objRow[convPaperSubViewpoint.ExplainTypeId].ToString().Trim(); //说明类型Id
objvPaperSubViewpointEN.ExplainTypeName = objRow[convPaperSubViewpoint.ExplainTypeName] == DBNull.Value ? null : objRow[convPaperSubViewpoint.ExplainTypeName].ToString().Trim(); //说明类型名
objvPaperSubViewpointEN.ExplainContent = objRow[convPaperSubViewpoint.ExplainContent] == DBNull.Value ? null : objRow[convPaperSubViewpoint.ExplainContent].ToString().Trim(); //说明内容
objvPaperSubViewpointEN.IsPublic = clsEntityBase2.TransNullToBool_S(objRow[convPaperSubViewpoint.IsPublic].ToString().Trim()); //是否公开
objvPaperSubViewpointEN.LiteratureSourcesId = objRow[convPaperSubViewpoint.LiteratureSourcesId] == DBNull.Value ? null : objRow[convPaperSubViewpoint.LiteratureSourcesId].ToString().Trim(); //文献来源
objvPaperSubViewpointEN.OperationTypeId = objRow[convPaperSubViewpoint.OperationTypeId] == DBNull.Value ? null : objRow[convPaperSubViewpoint.OperationTypeId].ToString().Trim(); //操作类型ID
objvPaperSubViewpointEN.LevelId = objRow[convPaperSubViewpoint.LevelId] == DBNull.Value ? null : objRow[convPaperSubViewpoint.LevelId].ToString().Trim(); //级别Id
objvPaperSubViewpointEN.Conclusion = objRow[convPaperSubViewpoint.Conclusion] == DBNull.Value ? null : objRow[convPaperSubViewpoint.Conclusion].ToString().Trim(); //结论
objvPaperSubViewpointEN.Nationality = objRow[convPaperSubViewpoint.Nationality] == DBNull.Value ? null : objRow[convPaperSubViewpoint.Nationality].ToString().Trim(); //国籍
objvPaperSubViewpointEN.Achievement = objRow[convPaperSubViewpoint.Achievement] == DBNull.Value ? null : objRow[convPaperSubViewpoint.Achievement].ToString().Trim(); //成就
objvPaperSubViewpointEN.Major = objRow[convPaperSubViewpoint.Major] == DBNull.Value ? null : objRow[convPaperSubViewpoint.Major].ToString().Trim(); //专业
objvPaperSubViewpointEN.WorkUnit = objRow[convPaperSubViewpoint.WorkUnit] == DBNull.Value ? null : objRow[convPaperSubViewpoint.WorkUnit].ToString().Trim(); //工作单位
objvPaperSubViewpointEN.PageNumber = objRow[convPaperSubViewpoint.PageNumber] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPaperSubViewpoint.PageNumber].ToString().Trim()); //页码
objvPaperSubViewpointEN.OrderNum = objRow[convPaperSubViewpoint.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPaperSubViewpoint.OrderNum].ToString().Trim()); //序号
objvPaperSubViewpointEN.PdfContent = objRow[convPaperSubViewpoint.PdfContent] == DBNull.Value ? null : objRow[convPaperSubViewpoint.PdfContent].ToString().Trim(); //Pdf内容
objvPaperSubViewpointEN.selectSpanRange = objRow[convPaperSubViewpoint.selectSpanRange] == DBNull.Value ? null : objRow[convPaperSubViewpoint.selectSpanRange].ToString().Trim(); //选择Span范围
objvPaperSubViewpointEN.PaperLineNum = objRow[convPaperSubViewpoint.PaperLineNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPaperSubViewpoint.PaperLineNum].ToString().Trim()); //论文行号
objvPaperSubViewpointEN.PaperPageNum = objRow[convPaperSubViewpoint.PaperPageNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPaperSubViewpoint.PaperPageNum].ToString().Trim()); //论文页码
objvPaperSubViewpointEN.AppraiseCount = objRow[convPaperSubViewpoint.AppraiseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPaperSubViewpoint.AppraiseCount].ToString().Trim()); //评论数
objvPaperSubViewpointEN.OkCount = objRow[convPaperSubViewpoint.OkCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPaperSubViewpoint.OkCount].ToString().Trim()); //点赞统计
objvPaperSubViewpointEN.Score = objRow[convPaperSubViewpoint.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convPaperSubViewpoint.Score].ToString().Trim()); //评分
objvPaperSubViewpointEN.StuScore = objRow[convPaperSubViewpoint.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convPaperSubViewpoint.StuScore].ToString().Trim()); //学生平均分
objvPaperSubViewpointEN.TeaScore = objRow[convPaperSubViewpoint.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convPaperSubViewpoint.TeaScore].ToString().Trim()); //教师评分
objvPaperSubViewpointEN.CreateDate = objRow[convPaperSubViewpoint.CreateDate] == DBNull.Value ? null : objRow[convPaperSubViewpoint.CreateDate].ToString().Trim(); //建立日期
objvPaperSubViewpointEN.ShareId = objRow[convPaperSubViewpoint.ShareId].ToString().Trim(); //分享Id
objvPaperSubViewpointEN.AttitudesId = objRow[convPaperSubViewpoint.AttitudesId].ToString().Trim(); //态度Id
objvPaperSubViewpointEN.AttitudesName = objRow[convPaperSubViewpoint.AttitudesName] == DBNull.Value ? null : objRow[convPaperSubViewpoint.AttitudesName].ToString().Trim(); //名称
objvPaperSubViewpointEN.UpdDate = objRow[convPaperSubViewpoint.UpdDate] == DBNull.Value ? null : objRow[convPaperSubViewpoint.UpdDate].ToString().Trim(); //修改日期
objvPaperSubViewpointEN.UpdUser = objRow[convPaperSubViewpoint.UpdUser] == DBNull.Value ? null : objRow[convPaperSubViewpoint.UpdUser].ToString().Trim(); //修改人
objvPaperSubViewpointEN.Memo = objRow[convPaperSubViewpoint.Memo] == DBNull.Value ? null : objRow[convPaperSubViewpoint.Memo].ToString().Trim(); //备注
objvPaperSubViewpointEN.SectionOrderNum = objRow[convPaperSubViewpoint.SectionOrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPaperSubViewpoint.SectionOrderNum].ToString().Trim()); //SectionOrderNum
objvPaperSubViewpointEN.SubViewpointTypeOrderNum = objRow[convPaperSubViewpoint.SubViewpointTypeOrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPaperSubViewpoint.SubViewpointTypeOrderNum].ToString().Trim()); //子观点类型序号
objvPaperSubViewpointEN.CitationCount = objRow[convPaperSubViewpoint.CitationCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPaperSubViewpoint.CitationCount].ToString().Trim()); //引用统计
objvPaperSubViewpointEN.VersionCount = objRow[convPaperSubViewpoint.VersionCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPaperSubViewpoint.VersionCount].ToString().Trim()); //版本统计
objvPaperSubViewpointEN.IsRecommend = clsEntityBase2.TransNullToBool_S(objRow[convPaperSubViewpoint.IsRecommend].ToString().Trim()); //是否推荐
objvPaperSubViewpointEN.gsKnowledgeTypeName = objRow[convPaperSubViewpoint.gsKnowledgeTypeName].ToString().Trim(); //知识类型名
objvPaperSubViewpointEN.LevelName = objRow[convPaperSubViewpoint.LevelName] == DBNull.Value ? null : objRow[convPaperSubViewpoint.LevelName].ToString().Trim(); //级别名称
objvPaperSubViewpointEN.OperationTypeName = objRow[convPaperSubViewpoint.OperationTypeName] == DBNull.Value ? null : objRow[convPaperSubViewpoint.OperationTypeName].ToString().Trim(); //操作类型名
objvPaperSubViewpointEN.CourseId = objRow[convPaperSubViewpoint.CourseId] == DBNull.Value ? null : objRow[convPaperSubViewpoint.CourseId].ToString().Trim(); //课程Id
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvPaperSubViewpointEN.SubViewpointId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvPaperSubViewpointEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsvPaperSubViewpointEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsvPaperSubViewpointEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsvPaperSubViewpointEN> arrObjLst = new List<clsvPaperSubViewpointEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvPaperSubViewpointEN objvPaperSubViewpointEN = new clsvPaperSubViewpointEN();
try
{
objvPaperSubViewpointEN.SubViewpointId = Int32.Parse(objRow[convPaperSubViewpoint.SubViewpointId].ToString().Trim()); //子观点Id
objvPaperSubViewpointEN.SubViewpointContent = objRow[convPaperSubViewpoint.SubViewpointContent] == DBNull.Value ? null : objRow[convPaperSubViewpoint.SubViewpointContent].ToString().Trim(); //详情内容
objvPaperSubViewpointEN.PaperRWId = objRow[convPaperSubViewpoint.PaperRWId] == DBNull.Value ? null : objRow[convPaperSubViewpoint.PaperRWId].ToString().Trim(); //课文阅读
objvPaperSubViewpointEN.PaperId = objRow[convPaperSubViewpoint.PaperId] == DBNull.Value ? null : objRow[convPaperSubViewpoint.PaperId].ToString().Trim(); //论文Id
objvPaperSubViewpointEN.PaperTitle = objRow[convPaperSubViewpoint.PaperTitle] == DBNull.Value ? null : objRow[convPaperSubViewpoint.PaperTitle].ToString().Trim(); //论文标题
objvPaperSubViewpointEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[convPaperSubViewpoint.IsSubmit].ToString().Trim()); //是否提交
objvPaperSubViewpointEN.IdCurrEduCls = objRow[convPaperSubViewpoint.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvPaperSubViewpointEN.UserId = objRow[convPaperSubViewpoint.UserId].ToString().Trim(); //用户ID
objvPaperSubViewpointEN.SectionId = objRow[convPaperSubViewpoint.SectionId] == DBNull.Value ? null : objRow[convPaperSubViewpoint.SectionId].ToString().Trim(); //节Id
objvPaperSubViewpointEN.SectionName = objRow[convPaperSubViewpoint.SectionName] == DBNull.Value ? null : objRow[convPaperSubViewpoint.SectionName].ToString().Trim(); //节名
objvPaperSubViewpointEN.SubViewpointTypeId = objRow[convPaperSubViewpoint.SubViewpointTypeId].ToString().Trim(); //类型Id
objvPaperSubViewpointEN.SubViewpointTypeName = objRow[convPaperSubViewpoint.SubViewpointTypeName] == DBNull.Value ? null : objRow[convPaperSubViewpoint.SubViewpointTypeName].ToString().Trim(); //类型名称
objvPaperSubViewpointEN.DefaTitle = objRow[convPaperSubViewpoint.DefaTitle] == DBNull.Value ? null : objRow[convPaperSubViewpoint.DefaTitle].ToString().Trim(); //默认标题
objvPaperSubViewpointEN.gsKnowledgeTypeId = objRow[convPaperSubViewpoint.gsKnowledgeTypeId].ToString().Trim(); //知识类型Id
objvPaperSubViewpointEN.RWTitle = objRow[convPaperSubViewpoint.RWTitle] == DBNull.Value ? null : objRow[convPaperSubViewpoint.RWTitle].ToString().Trim(); //读写标题
objvPaperSubViewpointEN.ExplainTypeId = objRow[convPaperSubViewpoint.ExplainTypeId] == DBNull.Value ? null : objRow[convPaperSubViewpoint.ExplainTypeId].ToString().Trim(); //说明类型Id
objvPaperSubViewpointEN.ExplainTypeName = objRow[convPaperSubViewpoint.ExplainTypeName] == DBNull.Value ? null : objRow[convPaperSubViewpoint.ExplainTypeName].ToString().Trim(); //说明类型名
objvPaperSubViewpointEN.ExplainContent = objRow[convPaperSubViewpoint.ExplainContent] == DBNull.Value ? null : objRow[convPaperSubViewpoint.ExplainContent].ToString().Trim(); //说明内容
objvPaperSubViewpointEN.IsPublic = clsEntityBase2.TransNullToBool_S(objRow[convPaperSubViewpoint.IsPublic].ToString().Trim()); //是否公开
objvPaperSubViewpointEN.LiteratureSourcesId = objRow[convPaperSubViewpoint.LiteratureSourcesId] == DBNull.Value ? null : objRow[convPaperSubViewpoint.LiteratureSourcesId].ToString().Trim(); //文献来源
objvPaperSubViewpointEN.OperationTypeId = objRow[convPaperSubViewpoint.OperationTypeId] == DBNull.Value ? null : objRow[convPaperSubViewpoint.OperationTypeId].ToString().Trim(); //操作类型ID
objvPaperSubViewpointEN.LevelId = objRow[convPaperSubViewpoint.LevelId] == DBNull.Value ? null : objRow[convPaperSubViewpoint.LevelId].ToString().Trim(); //级别Id
objvPaperSubViewpointEN.Conclusion = objRow[convPaperSubViewpoint.Conclusion] == DBNull.Value ? null : objRow[convPaperSubViewpoint.Conclusion].ToString().Trim(); //结论
objvPaperSubViewpointEN.Nationality = objRow[convPaperSubViewpoint.Nationality] == DBNull.Value ? null : objRow[convPaperSubViewpoint.Nationality].ToString().Trim(); //国籍
objvPaperSubViewpointEN.Achievement = objRow[convPaperSubViewpoint.Achievement] == DBNull.Value ? null : objRow[convPaperSubViewpoint.Achievement].ToString().Trim(); //成就
objvPaperSubViewpointEN.Major = objRow[convPaperSubViewpoint.Major] == DBNull.Value ? null : objRow[convPaperSubViewpoint.Major].ToString().Trim(); //专业
objvPaperSubViewpointEN.WorkUnit = objRow[convPaperSubViewpoint.WorkUnit] == DBNull.Value ? null : objRow[convPaperSubViewpoint.WorkUnit].ToString().Trim(); //工作单位
objvPaperSubViewpointEN.PageNumber = objRow[convPaperSubViewpoint.PageNumber] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPaperSubViewpoint.PageNumber].ToString().Trim()); //页码
objvPaperSubViewpointEN.OrderNum = objRow[convPaperSubViewpoint.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPaperSubViewpoint.OrderNum].ToString().Trim()); //序号
objvPaperSubViewpointEN.PdfContent = objRow[convPaperSubViewpoint.PdfContent] == DBNull.Value ? null : objRow[convPaperSubViewpoint.PdfContent].ToString().Trim(); //Pdf内容
objvPaperSubViewpointEN.selectSpanRange = objRow[convPaperSubViewpoint.selectSpanRange] == DBNull.Value ? null : objRow[convPaperSubViewpoint.selectSpanRange].ToString().Trim(); //选择Span范围
objvPaperSubViewpointEN.PaperLineNum = objRow[convPaperSubViewpoint.PaperLineNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPaperSubViewpoint.PaperLineNum].ToString().Trim()); //论文行号
objvPaperSubViewpointEN.PaperPageNum = objRow[convPaperSubViewpoint.PaperPageNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPaperSubViewpoint.PaperPageNum].ToString().Trim()); //论文页码
objvPaperSubViewpointEN.AppraiseCount = objRow[convPaperSubViewpoint.AppraiseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPaperSubViewpoint.AppraiseCount].ToString().Trim()); //评论数
objvPaperSubViewpointEN.OkCount = objRow[convPaperSubViewpoint.OkCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPaperSubViewpoint.OkCount].ToString().Trim()); //点赞统计
objvPaperSubViewpointEN.Score = objRow[convPaperSubViewpoint.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convPaperSubViewpoint.Score].ToString().Trim()); //评分
objvPaperSubViewpointEN.StuScore = objRow[convPaperSubViewpoint.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convPaperSubViewpoint.StuScore].ToString().Trim()); //学生平均分
objvPaperSubViewpointEN.TeaScore = objRow[convPaperSubViewpoint.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convPaperSubViewpoint.TeaScore].ToString().Trim()); //教师评分
objvPaperSubViewpointEN.CreateDate = objRow[convPaperSubViewpoint.CreateDate] == DBNull.Value ? null : objRow[convPaperSubViewpoint.CreateDate].ToString().Trim(); //建立日期
objvPaperSubViewpointEN.ShareId = objRow[convPaperSubViewpoint.ShareId].ToString().Trim(); //分享Id
objvPaperSubViewpointEN.AttitudesId = objRow[convPaperSubViewpoint.AttitudesId].ToString().Trim(); //态度Id
objvPaperSubViewpointEN.AttitudesName = objRow[convPaperSubViewpoint.AttitudesName] == DBNull.Value ? null : objRow[convPaperSubViewpoint.AttitudesName].ToString().Trim(); //名称
objvPaperSubViewpointEN.UpdDate = objRow[convPaperSubViewpoint.UpdDate] == DBNull.Value ? null : objRow[convPaperSubViewpoint.UpdDate].ToString().Trim(); //修改日期
objvPaperSubViewpointEN.UpdUser = objRow[convPaperSubViewpoint.UpdUser] == DBNull.Value ? null : objRow[convPaperSubViewpoint.UpdUser].ToString().Trim(); //修改人
objvPaperSubViewpointEN.Memo = objRow[convPaperSubViewpoint.Memo] == DBNull.Value ? null : objRow[convPaperSubViewpoint.Memo].ToString().Trim(); //备注
objvPaperSubViewpointEN.SectionOrderNum = objRow[convPaperSubViewpoint.SectionOrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPaperSubViewpoint.SectionOrderNum].ToString().Trim()); //SectionOrderNum
objvPaperSubViewpointEN.SubViewpointTypeOrderNum = objRow[convPaperSubViewpoint.SubViewpointTypeOrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPaperSubViewpoint.SubViewpointTypeOrderNum].ToString().Trim()); //子观点类型序号
objvPaperSubViewpointEN.CitationCount = objRow[convPaperSubViewpoint.CitationCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPaperSubViewpoint.CitationCount].ToString().Trim()); //引用统计
objvPaperSubViewpointEN.VersionCount = objRow[convPaperSubViewpoint.VersionCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPaperSubViewpoint.VersionCount].ToString().Trim()); //版本统计
objvPaperSubViewpointEN.IsRecommend = clsEntityBase2.TransNullToBool_S(objRow[convPaperSubViewpoint.IsRecommend].ToString().Trim()); //是否推荐
objvPaperSubViewpointEN.gsKnowledgeTypeName = objRow[convPaperSubViewpoint.gsKnowledgeTypeName].ToString().Trim(); //知识类型名
objvPaperSubViewpointEN.LevelName = objRow[convPaperSubViewpoint.LevelName] == DBNull.Value ? null : objRow[convPaperSubViewpoint.LevelName].ToString().Trim(); //级别名称
objvPaperSubViewpointEN.OperationTypeName = objRow[convPaperSubViewpoint.OperationTypeName] == DBNull.Value ? null : objRow[convPaperSubViewpoint.OperationTypeName].ToString().Trim(); //操作类型名
objvPaperSubViewpointEN.CourseId = objRow[convPaperSubViewpoint.CourseId] == DBNull.Value ? null : objRow[convPaperSubViewpoint.CourseId].ToString().Trim(); //课程Id
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvPaperSubViewpointEN.SubViewpointId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvPaperSubViewpointEN);
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
public static List<clsvPaperSubViewpointEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsvPaperSubViewpointEN> arrObjLst = new List<clsvPaperSubViewpointEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvPaperSubViewpointEN objvPaperSubViewpointEN = new clsvPaperSubViewpointEN();
try
{
objvPaperSubViewpointEN.SubViewpointId = Int32.Parse(objRow[convPaperSubViewpoint.SubViewpointId].ToString().Trim()); //子观点Id
objvPaperSubViewpointEN.SubViewpointContent = objRow[convPaperSubViewpoint.SubViewpointContent] == DBNull.Value ? null : objRow[convPaperSubViewpoint.SubViewpointContent].ToString().Trim(); //详情内容
objvPaperSubViewpointEN.PaperRWId = objRow[convPaperSubViewpoint.PaperRWId] == DBNull.Value ? null : objRow[convPaperSubViewpoint.PaperRWId].ToString().Trim(); //课文阅读
objvPaperSubViewpointEN.PaperId = objRow[convPaperSubViewpoint.PaperId] == DBNull.Value ? null : objRow[convPaperSubViewpoint.PaperId].ToString().Trim(); //论文Id
objvPaperSubViewpointEN.PaperTitle = objRow[convPaperSubViewpoint.PaperTitle] == DBNull.Value ? null : objRow[convPaperSubViewpoint.PaperTitle].ToString().Trim(); //论文标题
objvPaperSubViewpointEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[convPaperSubViewpoint.IsSubmit].ToString().Trim()); //是否提交
objvPaperSubViewpointEN.IdCurrEduCls = objRow[convPaperSubViewpoint.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvPaperSubViewpointEN.UserId = objRow[convPaperSubViewpoint.UserId].ToString().Trim(); //用户ID
objvPaperSubViewpointEN.SectionId = objRow[convPaperSubViewpoint.SectionId] == DBNull.Value ? null : objRow[convPaperSubViewpoint.SectionId].ToString().Trim(); //节Id
objvPaperSubViewpointEN.SectionName = objRow[convPaperSubViewpoint.SectionName] == DBNull.Value ? null : objRow[convPaperSubViewpoint.SectionName].ToString().Trim(); //节名
objvPaperSubViewpointEN.SubViewpointTypeId = objRow[convPaperSubViewpoint.SubViewpointTypeId].ToString().Trim(); //类型Id
objvPaperSubViewpointEN.SubViewpointTypeName = objRow[convPaperSubViewpoint.SubViewpointTypeName] == DBNull.Value ? null : objRow[convPaperSubViewpoint.SubViewpointTypeName].ToString().Trim(); //类型名称
objvPaperSubViewpointEN.DefaTitle = objRow[convPaperSubViewpoint.DefaTitle] == DBNull.Value ? null : objRow[convPaperSubViewpoint.DefaTitle].ToString().Trim(); //默认标题
objvPaperSubViewpointEN.gsKnowledgeTypeId = objRow[convPaperSubViewpoint.gsKnowledgeTypeId].ToString().Trim(); //知识类型Id
objvPaperSubViewpointEN.RWTitle = objRow[convPaperSubViewpoint.RWTitle] == DBNull.Value ? null : objRow[convPaperSubViewpoint.RWTitle].ToString().Trim(); //读写标题
objvPaperSubViewpointEN.ExplainTypeId = objRow[convPaperSubViewpoint.ExplainTypeId] == DBNull.Value ? null : objRow[convPaperSubViewpoint.ExplainTypeId].ToString().Trim(); //说明类型Id
objvPaperSubViewpointEN.ExplainTypeName = objRow[convPaperSubViewpoint.ExplainTypeName] == DBNull.Value ? null : objRow[convPaperSubViewpoint.ExplainTypeName].ToString().Trim(); //说明类型名
objvPaperSubViewpointEN.ExplainContent = objRow[convPaperSubViewpoint.ExplainContent] == DBNull.Value ? null : objRow[convPaperSubViewpoint.ExplainContent].ToString().Trim(); //说明内容
objvPaperSubViewpointEN.IsPublic = clsEntityBase2.TransNullToBool_S(objRow[convPaperSubViewpoint.IsPublic].ToString().Trim()); //是否公开
objvPaperSubViewpointEN.LiteratureSourcesId = objRow[convPaperSubViewpoint.LiteratureSourcesId] == DBNull.Value ? null : objRow[convPaperSubViewpoint.LiteratureSourcesId].ToString().Trim(); //文献来源
objvPaperSubViewpointEN.OperationTypeId = objRow[convPaperSubViewpoint.OperationTypeId] == DBNull.Value ? null : objRow[convPaperSubViewpoint.OperationTypeId].ToString().Trim(); //操作类型ID
objvPaperSubViewpointEN.LevelId = objRow[convPaperSubViewpoint.LevelId] == DBNull.Value ? null : objRow[convPaperSubViewpoint.LevelId].ToString().Trim(); //级别Id
objvPaperSubViewpointEN.Conclusion = objRow[convPaperSubViewpoint.Conclusion] == DBNull.Value ? null : objRow[convPaperSubViewpoint.Conclusion].ToString().Trim(); //结论
objvPaperSubViewpointEN.Nationality = objRow[convPaperSubViewpoint.Nationality] == DBNull.Value ? null : objRow[convPaperSubViewpoint.Nationality].ToString().Trim(); //国籍
objvPaperSubViewpointEN.Achievement = objRow[convPaperSubViewpoint.Achievement] == DBNull.Value ? null : objRow[convPaperSubViewpoint.Achievement].ToString().Trim(); //成就
objvPaperSubViewpointEN.Major = objRow[convPaperSubViewpoint.Major] == DBNull.Value ? null : objRow[convPaperSubViewpoint.Major].ToString().Trim(); //专业
objvPaperSubViewpointEN.WorkUnit = objRow[convPaperSubViewpoint.WorkUnit] == DBNull.Value ? null : objRow[convPaperSubViewpoint.WorkUnit].ToString().Trim(); //工作单位
objvPaperSubViewpointEN.PageNumber = objRow[convPaperSubViewpoint.PageNumber] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPaperSubViewpoint.PageNumber].ToString().Trim()); //页码
objvPaperSubViewpointEN.OrderNum = objRow[convPaperSubViewpoint.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPaperSubViewpoint.OrderNum].ToString().Trim()); //序号
objvPaperSubViewpointEN.PdfContent = objRow[convPaperSubViewpoint.PdfContent] == DBNull.Value ? null : objRow[convPaperSubViewpoint.PdfContent].ToString().Trim(); //Pdf内容
objvPaperSubViewpointEN.selectSpanRange = objRow[convPaperSubViewpoint.selectSpanRange] == DBNull.Value ? null : objRow[convPaperSubViewpoint.selectSpanRange].ToString().Trim(); //选择Span范围
objvPaperSubViewpointEN.PaperLineNum = objRow[convPaperSubViewpoint.PaperLineNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPaperSubViewpoint.PaperLineNum].ToString().Trim()); //论文行号
objvPaperSubViewpointEN.PaperPageNum = objRow[convPaperSubViewpoint.PaperPageNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPaperSubViewpoint.PaperPageNum].ToString().Trim()); //论文页码
objvPaperSubViewpointEN.AppraiseCount = objRow[convPaperSubViewpoint.AppraiseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPaperSubViewpoint.AppraiseCount].ToString().Trim()); //评论数
objvPaperSubViewpointEN.OkCount = objRow[convPaperSubViewpoint.OkCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPaperSubViewpoint.OkCount].ToString().Trim()); //点赞统计
objvPaperSubViewpointEN.Score = objRow[convPaperSubViewpoint.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convPaperSubViewpoint.Score].ToString().Trim()); //评分
objvPaperSubViewpointEN.StuScore = objRow[convPaperSubViewpoint.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convPaperSubViewpoint.StuScore].ToString().Trim()); //学生平均分
objvPaperSubViewpointEN.TeaScore = objRow[convPaperSubViewpoint.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convPaperSubViewpoint.TeaScore].ToString().Trim()); //教师评分
objvPaperSubViewpointEN.CreateDate = objRow[convPaperSubViewpoint.CreateDate] == DBNull.Value ? null : objRow[convPaperSubViewpoint.CreateDate].ToString().Trim(); //建立日期
objvPaperSubViewpointEN.ShareId = objRow[convPaperSubViewpoint.ShareId].ToString().Trim(); //分享Id
objvPaperSubViewpointEN.AttitudesId = objRow[convPaperSubViewpoint.AttitudesId].ToString().Trim(); //态度Id
objvPaperSubViewpointEN.AttitudesName = objRow[convPaperSubViewpoint.AttitudesName] == DBNull.Value ? null : objRow[convPaperSubViewpoint.AttitudesName].ToString().Trim(); //名称
objvPaperSubViewpointEN.UpdDate = objRow[convPaperSubViewpoint.UpdDate] == DBNull.Value ? null : objRow[convPaperSubViewpoint.UpdDate].ToString().Trim(); //修改日期
objvPaperSubViewpointEN.UpdUser = objRow[convPaperSubViewpoint.UpdUser] == DBNull.Value ? null : objRow[convPaperSubViewpoint.UpdUser].ToString().Trim(); //修改人
objvPaperSubViewpointEN.Memo = objRow[convPaperSubViewpoint.Memo] == DBNull.Value ? null : objRow[convPaperSubViewpoint.Memo].ToString().Trim(); //备注
objvPaperSubViewpointEN.SectionOrderNum = objRow[convPaperSubViewpoint.SectionOrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPaperSubViewpoint.SectionOrderNum].ToString().Trim()); //SectionOrderNum
objvPaperSubViewpointEN.SubViewpointTypeOrderNum = objRow[convPaperSubViewpoint.SubViewpointTypeOrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPaperSubViewpoint.SubViewpointTypeOrderNum].ToString().Trim()); //子观点类型序号
objvPaperSubViewpointEN.CitationCount = objRow[convPaperSubViewpoint.CitationCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPaperSubViewpoint.CitationCount].ToString().Trim()); //引用统计
objvPaperSubViewpointEN.VersionCount = objRow[convPaperSubViewpoint.VersionCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPaperSubViewpoint.VersionCount].ToString().Trim()); //版本统计
objvPaperSubViewpointEN.IsRecommend = clsEntityBase2.TransNullToBool_S(objRow[convPaperSubViewpoint.IsRecommend].ToString().Trim()); //是否推荐
objvPaperSubViewpointEN.gsKnowledgeTypeName = objRow[convPaperSubViewpoint.gsKnowledgeTypeName].ToString().Trim(); //知识类型名
objvPaperSubViewpointEN.LevelName = objRow[convPaperSubViewpoint.LevelName] == DBNull.Value ? null : objRow[convPaperSubViewpoint.LevelName].ToString().Trim(); //级别名称
objvPaperSubViewpointEN.OperationTypeName = objRow[convPaperSubViewpoint.OperationTypeName] == DBNull.Value ? null : objRow[convPaperSubViewpoint.OperationTypeName].ToString().Trim(); //操作类型名
objvPaperSubViewpointEN.CourseId = objRow[convPaperSubViewpoint.CourseId] == DBNull.Value ? null : objRow[convPaperSubViewpoint.CourseId].ToString().Trim(); //课程Id
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvPaperSubViewpointEN.SubViewpointId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvPaperSubViewpointEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsvPaperSubViewpointEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsvPaperSubViewpointEN> arrObjLst = new List<clsvPaperSubViewpointEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvPaperSubViewpointEN objvPaperSubViewpointEN = new clsvPaperSubViewpointEN();
try
{
objvPaperSubViewpointEN.SubViewpointId = Int32.Parse(objRow[convPaperSubViewpoint.SubViewpointId].ToString().Trim()); //子观点Id
objvPaperSubViewpointEN.SubViewpointContent = objRow[convPaperSubViewpoint.SubViewpointContent] == DBNull.Value ? null : objRow[convPaperSubViewpoint.SubViewpointContent].ToString().Trim(); //详情内容
objvPaperSubViewpointEN.PaperRWId = objRow[convPaperSubViewpoint.PaperRWId] == DBNull.Value ? null : objRow[convPaperSubViewpoint.PaperRWId].ToString().Trim(); //课文阅读
objvPaperSubViewpointEN.PaperId = objRow[convPaperSubViewpoint.PaperId] == DBNull.Value ? null : objRow[convPaperSubViewpoint.PaperId].ToString().Trim(); //论文Id
objvPaperSubViewpointEN.PaperTitle = objRow[convPaperSubViewpoint.PaperTitle] == DBNull.Value ? null : objRow[convPaperSubViewpoint.PaperTitle].ToString().Trim(); //论文标题
objvPaperSubViewpointEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[convPaperSubViewpoint.IsSubmit].ToString().Trim()); //是否提交
objvPaperSubViewpointEN.IdCurrEduCls = objRow[convPaperSubViewpoint.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvPaperSubViewpointEN.UserId = objRow[convPaperSubViewpoint.UserId].ToString().Trim(); //用户ID
objvPaperSubViewpointEN.SectionId = objRow[convPaperSubViewpoint.SectionId] == DBNull.Value ? null : objRow[convPaperSubViewpoint.SectionId].ToString().Trim(); //节Id
objvPaperSubViewpointEN.SectionName = objRow[convPaperSubViewpoint.SectionName] == DBNull.Value ? null : objRow[convPaperSubViewpoint.SectionName].ToString().Trim(); //节名
objvPaperSubViewpointEN.SubViewpointTypeId = objRow[convPaperSubViewpoint.SubViewpointTypeId].ToString().Trim(); //类型Id
objvPaperSubViewpointEN.SubViewpointTypeName = objRow[convPaperSubViewpoint.SubViewpointTypeName] == DBNull.Value ? null : objRow[convPaperSubViewpoint.SubViewpointTypeName].ToString().Trim(); //类型名称
objvPaperSubViewpointEN.DefaTitle = objRow[convPaperSubViewpoint.DefaTitle] == DBNull.Value ? null : objRow[convPaperSubViewpoint.DefaTitle].ToString().Trim(); //默认标题
objvPaperSubViewpointEN.gsKnowledgeTypeId = objRow[convPaperSubViewpoint.gsKnowledgeTypeId].ToString().Trim(); //知识类型Id
objvPaperSubViewpointEN.RWTitle = objRow[convPaperSubViewpoint.RWTitle] == DBNull.Value ? null : objRow[convPaperSubViewpoint.RWTitle].ToString().Trim(); //读写标题
objvPaperSubViewpointEN.ExplainTypeId = objRow[convPaperSubViewpoint.ExplainTypeId] == DBNull.Value ? null : objRow[convPaperSubViewpoint.ExplainTypeId].ToString().Trim(); //说明类型Id
objvPaperSubViewpointEN.ExplainTypeName = objRow[convPaperSubViewpoint.ExplainTypeName] == DBNull.Value ? null : objRow[convPaperSubViewpoint.ExplainTypeName].ToString().Trim(); //说明类型名
objvPaperSubViewpointEN.ExplainContent = objRow[convPaperSubViewpoint.ExplainContent] == DBNull.Value ? null : objRow[convPaperSubViewpoint.ExplainContent].ToString().Trim(); //说明内容
objvPaperSubViewpointEN.IsPublic = clsEntityBase2.TransNullToBool_S(objRow[convPaperSubViewpoint.IsPublic].ToString().Trim()); //是否公开
objvPaperSubViewpointEN.LiteratureSourcesId = objRow[convPaperSubViewpoint.LiteratureSourcesId] == DBNull.Value ? null : objRow[convPaperSubViewpoint.LiteratureSourcesId].ToString().Trim(); //文献来源
objvPaperSubViewpointEN.OperationTypeId = objRow[convPaperSubViewpoint.OperationTypeId] == DBNull.Value ? null : objRow[convPaperSubViewpoint.OperationTypeId].ToString().Trim(); //操作类型ID
objvPaperSubViewpointEN.LevelId = objRow[convPaperSubViewpoint.LevelId] == DBNull.Value ? null : objRow[convPaperSubViewpoint.LevelId].ToString().Trim(); //级别Id
objvPaperSubViewpointEN.Conclusion = objRow[convPaperSubViewpoint.Conclusion] == DBNull.Value ? null : objRow[convPaperSubViewpoint.Conclusion].ToString().Trim(); //结论
objvPaperSubViewpointEN.Nationality = objRow[convPaperSubViewpoint.Nationality] == DBNull.Value ? null : objRow[convPaperSubViewpoint.Nationality].ToString().Trim(); //国籍
objvPaperSubViewpointEN.Achievement = objRow[convPaperSubViewpoint.Achievement] == DBNull.Value ? null : objRow[convPaperSubViewpoint.Achievement].ToString().Trim(); //成就
objvPaperSubViewpointEN.Major = objRow[convPaperSubViewpoint.Major] == DBNull.Value ? null : objRow[convPaperSubViewpoint.Major].ToString().Trim(); //专业
objvPaperSubViewpointEN.WorkUnit = objRow[convPaperSubViewpoint.WorkUnit] == DBNull.Value ? null : objRow[convPaperSubViewpoint.WorkUnit].ToString().Trim(); //工作单位
objvPaperSubViewpointEN.PageNumber = objRow[convPaperSubViewpoint.PageNumber] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPaperSubViewpoint.PageNumber].ToString().Trim()); //页码
objvPaperSubViewpointEN.OrderNum = objRow[convPaperSubViewpoint.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPaperSubViewpoint.OrderNum].ToString().Trim()); //序号
objvPaperSubViewpointEN.PdfContent = objRow[convPaperSubViewpoint.PdfContent] == DBNull.Value ? null : objRow[convPaperSubViewpoint.PdfContent].ToString().Trim(); //Pdf内容
objvPaperSubViewpointEN.selectSpanRange = objRow[convPaperSubViewpoint.selectSpanRange] == DBNull.Value ? null : objRow[convPaperSubViewpoint.selectSpanRange].ToString().Trim(); //选择Span范围
objvPaperSubViewpointEN.PaperLineNum = objRow[convPaperSubViewpoint.PaperLineNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPaperSubViewpoint.PaperLineNum].ToString().Trim()); //论文行号
objvPaperSubViewpointEN.PaperPageNum = objRow[convPaperSubViewpoint.PaperPageNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPaperSubViewpoint.PaperPageNum].ToString().Trim()); //论文页码
objvPaperSubViewpointEN.AppraiseCount = objRow[convPaperSubViewpoint.AppraiseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPaperSubViewpoint.AppraiseCount].ToString().Trim()); //评论数
objvPaperSubViewpointEN.OkCount = objRow[convPaperSubViewpoint.OkCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPaperSubViewpoint.OkCount].ToString().Trim()); //点赞统计
objvPaperSubViewpointEN.Score = objRow[convPaperSubViewpoint.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convPaperSubViewpoint.Score].ToString().Trim()); //评分
objvPaperSubViewpointEN.StuScore = objRow[convPaperSubViewpoint.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convPaperSubViewpoint.StuScore].ToString().Trim()); //学生平均分
objvPaperSubViewpointEN.TeaScore = objRow[convPaperSubViewpoint.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convPaperSubViewpoint.TeaScore].ToString().Trim()); //教师评分
objvPaperSubViewpointEN.CreateDate = objRow[convPaperSubViewpoint.CreateDate] == DBNull.Value ? null : objRow[convPaperSubViewpoint.CreateDate].ToString().Trim(); //建立日期
objvPaperSubViewpointEN.ShareId = objRow[convPaperSubViewpoint.ShareId].ToString().Trim(); //分享Id
objvPaperSubViewpointEN.AttitudesId = objRow[convPaperSubViewpoint.AttitudesId].ToString().Trim(); //态度Id
objvPaperSubViewpointEN.AttitudesName = objRow[convPaperSubViewpoint.AttitudesName] == DBNull.Value ? null : objRow[convPaperSubViewpoint.AttitudesName].ToString().Trim(); //名称
objvPaperSubViewpointEN.UpdDate = objRow[convPaperSubViewpoint.UpdDate] == DBNull.Value ? null : objRow[convPaperSubViewpoint.UpdDate].ToString().Trim(); //修改日期
objvPaperSubViewpointEN.UpdUser = objRow[convPaperSubViewpoint.UpdUser] == DBNull.Value ? null : objRow[convPaperSubViewpoint.UpdUser].ToString().Trim(); //修改人
objvPaperSubViewpointEN.Memo = objRow[convPaperSubViewpoint.Memo] == DBNull.Value ? null : objRow[convPaperSubViewpoint.Memo].ToString().Trim(); //备注
objvPaperSubViewpointEN.SectionOrderNum = objRow[convPaperSubViewpoint.SectionOrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPaperSubViewpoint.SectionOrderNum].ToString().Trim()); //SectionOrderNum
objvPaperSubViewpointEN.SubViewpointTypeOrderNum = objRow[convPaperSubViewpoint.SubViewpointTypeOrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPaperSubViewpoint.SubViewpointTypeOrderNum].ToString().Trim()); //子观点类型序号
objvPaperSubViewpointEN.CitationCount = objRow[convPaperSubViewpoint.CitationCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPaperSubViewpoint.CitationCount].ToString().Trim()); //引用统计
objvPaperSubViewpointEN.VersionCount = objRow[convPaperSubViewpoint.VersionCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPaperSubViewpoint.VersionCount].ToString().Trim()); //版本统计
objvPaperSubViewpointEN.IsRecommend = clsEntityBase2.TransNullToBool_S(objRow[convPaperSubViewpoint.IsRecommend].ToString().Trim()); //是否推荐
objvPaperSubViewpointEN.gsKnowledgeTypeName = objRow[convPaperSubViewpoint.gsKnowledgeTypeName].ToString().Trim(); //知识类型名
objvPaperSubViewpointEN.LevelName = objRow[convPaperSubViewpoint.LevelName] == DBNull.Value ? null : objRow[convPaperSubViewpoint.LevelName].ToString().Trim(); //级别名称
objvPaperSubViewpointEN.OperationTypeName = objRow[convPaperSubViewpoint.OperationTypeName] == DBNull.Value ? null : objRow[convPaperSubViewpoint.OperationTypeName].ToString().Trim(); //操作类型名
objvPaperSubViewpointEN.CourseId = objRow[convPaperSubViewpoint.CourseId] == DBNull.Value ? null : objRow[convPaperSubViewpoint.CourseId].ToString().Trim(); //课程Id
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvPaperSubViewpointEN.SubViewpointId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvPaperSubViewpointEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objvPaperSubViewpointEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetvPaperSubViewpoint(ref clsvPaperSubViewpointEN objvPaperSubViewpointEN)
{
bool bolResult = vPaperSubViewpointDA.GetvPaperSubViewpoint(ref objvPaperSubViewpointEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "lngSubViewpointId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvPaperSubViewpointEN GetObjBySubViewpointId(long lngSubViewpointId)
{
clsvPaperSubViewpointEN objvPaperSubViewpointEN = vPaperSubViewpointDA.GetObjBySubViewpointId(lngSubViewpointId);
return objvPaperSubViewpointEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsvPaperSubViewpointEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsvPaperSubViewpointEN objvPaperSubViewpointEN = vPaperSubViewpointDA.GetFirstObj(strWhereCond);
 return objvPaperSubViewpointEN;
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
public static clsvPaperSubViewpointEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsvPaperSubViewpointEN objvPaperSubViewpointEN = vPaperSubViewpointDA.GetObjByDataRow(objRow);
 return objvPaperSubViewpointEN;
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
public static clsvPaperSubViewpointEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsvPaperSubViewpointEN objvPaperSubViewpointEN = vPaperSubViewpointDA.GetObjByDataRow(objRow);
 return objvPaperSubViewpointEN;
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
 /// <param name = "lngSubViewpointId">所给的关键字</param>
 /// <param name = "lstvPaperSubViewpointObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvPaperSubViewpointEN GetObjBySubViewpointIdFromList(long lngSubViewpointId, List<clsvPaperSubViewpointEN> lstvPaperSubViewpointObjLst)
{
foreach (clsvPaperSubViewpointEN objvPaperSubViewpointEN in lstvPaperSubViewpointObjLst)
{
if (objvPaperSubViewpointEN.SubViewpointId == lngSubViewpointId)
{
return objvPaperSubViewpointEN;
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
 string strMaxSubViewpointId;
 try
 {
 strMaxSubViewpointId = clsvPaperSubViewpointDA.GetMaxStrId();
 return strMaxSubViewpointId;
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
public static long GetFirstID_S(string strWhereCond) 
{
 long lngSubViewpointId;
 try
 {
 lngSubViewpointId = new clsvPaperSubViewpointDA().GetFirstID(strWhereCond);
 return lngSubViewpointId;
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
 arrList = vPaperSubViewpointDA.GetID(strWhereCond);
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
bool bolIsExist = vPaperSubViewpointDA.IsExistCondRec(strWhereCond);
return bolIsExist;
}

 /// <summary>
 /// 判断当前表中是否存在给定关键字值的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExist)
 /// </summary>
 /// <param name = "lngSubViewpointId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public static bool IsExist(long lngSubViewpointId)
{
//检测记录是否存在
bool bolIsExist = vPaperSubViewpointDA.IsExist(lngSubViewpointId);
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
 bolIsExist = clsvPaperSubViewpointDA.IsExistTable();
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
 bolIsExist = vPaperSubViewpointDA.IsExistTable(strTabName);
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
 /// <param name = "objvPaperSubViewpointENS">源对象</param>
 /// <param name = "objvPaperSubViewpointENT">目标对象</param>
 public static void CopyTo(clsvPaperSubViewpointEN objvPaperSubViewpointENS, clsvPaperSubViewpointEN objvPaperSubViewpointENT)
{
try
{
objvPaperSubViewpointENT.SubViewpointId = objvPaperSubViewpointENS.SubViewpointId; //子观点Id
objvPaperSubViewpointENT.SubViewpointContent = objvPaperSubViewpointENS.SubViewpointContent; //详情内容
objvPaperSubViewpointENT.PaperRWId = objvPaperSubViewpointENS.PaperRWId; //课文阅读
objvPaperSubViewpointENT.PaperId = objvPaperSubViewpointENS.PaperId; //论文Id
objvPaperSubViewpointENT.PaperTitle = objvPaperSubViewpointENS.PaperTitle; //论文标题
objvPaperSubViewpointENT.IsSubmit = objvPaperSubViewpointENS.IsSubmit; //是否提交
objvPaperSubViewpointENT.IdCurrEduCls = objvPaperSubViewpointENS.IdCurrEduCls; //教学班流水号
objvPaperSubViewpointENT.UserId = objvPaperSubViewpointENS.UserId; //用户ID
objvPaperSubViewpointENT.SectionId = objvPaperSubViewpointENS.SectionId; //节Id
objvPaperSubViewpointENT.SectionName = objvPaperSubViewpointENS.SectionName; //节名
objvPaperSubViewpointENT.SubViewpointTypeId = objvPaperSubViewpointENS.SubViewpointTypeId; //类型Id
objvPaperSubViewpointENT.SubViewpointTypeName = objvPaperSubViewpointENS.SubViewpointTypeName; //类型名称
objvPaperSubViewpointENT.DefaTitle = objvPaperSubViewpointENS.DefaTitle; //默认标题
objvPaperSubViewpointENT.gsKnowledgeTypeId = objvPaperSubViewpointENS.gsKnowledgeTypeId; //知识类型Id
objvPaperSubViewpointENT.RWTitle = objvPaperSubViewpointENS.RWTitle; //读写标题
objvPaperSubViewpointENT.ExplainTypeId = objvPaperSubViewpointENS.ExplainTypeId; //说明类型Id
objvPaperSubViewpointENT.ExplainTypeName = objvPaperSubViewpointENS.ExplainTypeName; //说明类型名
objvPaperSubViewpointENT.ExplainContent = objvPaperSubViewpointENS.ExplainContent; //说明内容
objvPaperSubViewpointENT.IsPublic = objvPaperSubViewpointENS.IsPublic; //是否公开
objvPaperSubViewpointENT.LiteratureSourcesId = objvPaperSubViewpointENS.LiteratureSourcesId; //文献来源
objvPaperSubViewpointENT.OperationTypeId = objvPaperSubViewpointENS.OperationTypeId; //操作类型ID
objvPaperSubViewpointENT.LevelId = objvPaperSubViewpointENS.LevelId; //级别Id
objvPaperSubViewpointENT.Conclusion = objvPaperSubViewpointENS.Conclusion; //结论
objvPaperSubViewpointENT.Nationality = objvPaperSubViewpointENS.Nationality; //国籍
objvPaperSubViewpointENT.Achievement = objvPaperSubViewpointENS.Achievement; //成就
objvPaperSubViewpointENT.Major = objvPaperSubViewpointENS.Major; //专业
objvPaperSubViewpointENT.WorkUnit = objvPaperSubViewpointENS.WorkUnit; //工作单位
objvPaperSubViewpointENT.PageNumber = objvPaperSubViewpointENS.PageNumber; //页码
objvPaperSubViewpointENT.OrderNum = objvPaperSubViewpointENS.OrderNum; //序号
objvPaperSubViewpointENT.PdfContent = objvPaperSubViewpointENS.PdfContent; //Pdf内容
objvPaperSubViewpointENT.selectSpanRange = objvPaperSubViewpointENS.selectSpanRange; //选择Span范围
objvPaperSubViewpointENT.PaperLineNum = objvPaperSubViewpointENS.PaperLineNum; //论文行号
objvPaperSubViewpointENT.PaperPageNum = objvPaperSubViewpointENS.PaperPageNum; //论文页码
objvPaperSubViewpointENT.AppraiseCount = objvPaperSubViewpointENS.AppraiseCount; //评论数
objvPaperSubViewpointENT.OkCount = objvPaperSubViewpointENS.OkCount; //点赞统计
objvPaperSubViewpointENT.Score = objvPaperSubViewpointENS.Score; //评分
objvPaperSubViewpointENT.StuScore = objvPaperSubViewpointENS.StuScore; //学生平均分
objvPaperSubViewpointENT.TeaScore = objvPaperSubViewpointENS.TeaScore; //教师评分
objvPaperSubViewpointENT.CreateDate = objvPaperSubViewpointENS.CreateDate; //建立日期
objvPaperSubViewpointENT.ShareId = objvPaperSubViewpointENS.ShareId; //分享Id
objvPaperSubViewpointENT.AttitudesId = objvPaperSubViewpointENS.AttitudesId; //态度Id
objvPaperSubViewpointENT.AttitudesName = objvPaperSubViewpointENS.AttitudesName; //名称
objvPaperSubViewpointENT.UpdDate = objvPaperSubViewpointENS.UpdDate; //修改日期
objvPaperSubViewpointENT.UpdUser = objvPaperSubViewpointENS.UpdUser; //修改人
objvPaperSubViewpointENT.Memo = objvPaperSubViewpointENS.Memo; //备注
objvPaperSubViewpointENT.SectionOrderNum = objvPaperSubViewpointENS.SectionOrderNum; //SectionOrderNum
objvPaperSubViewpointENT.SubViewpointTypeOrderNum = objvPaperSubViewpointENS.SubViewpointTypeOrderNum; //子观点类型序号
objvPaperSubViewpointENT.CitationCount = objvPaperSubViewpointENS.CitationCount; //引用统计
objvPaperSubViewpointENT.VersionCount = objvPaperSubViewpointENS.VersionCount; //版本统计
objvPaperSubViewpointENT.IsRecommend = objvPaperSubViewpointENS.IsRecommend; //是否推荐
objvPaperSubViewpointENT.gsKnowledgeTypeName = objvPaperSubViewpointENS.gsKnowledgeTypeName; //知识类型名
objvPaperSubViewpointENT.LevelName = objvPaperSubViewpointENS.LevelName; //级别名称
objvPaperSubViewpointENT.OperationTypeName = objvPaperSubViewpointENS.OperationTypeName; //操作类型名
objvPaperSubViewpointENT.CourseId = objvPaperSubViewpointENS.CourseId; //课程Id
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
 /// <param name = "objvPaperSubViewpointEN">源简化对象</param>
 public static void SetUpdFlag(clsvPaperSubViewpointEN objvPaperSubViewpointEN)
{
try
{
objvPaperSubViewpointEN.ClearUpdateState();
   string strsfUpdFldSetStr = objvPaperSubViewpointEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(convPaperSubViewpoint.SubViewpointId, new clsStrCompareIgnoreCase())  ==  true)
{
objvPaperSubViewpointEN.SubViewpointId = objvPaperSubViewpointEN.SubViewpointId; //子观点Id
}
if (arrFldSet.Contains(convPaperSubViewpoint.SubViewpointContent, new clsStrCompareIgnoreCase())  ==  true)
{
objvPaperSubViewpointEN.SubViewpointContent = objvPaperSubViewpointEN.SubViewpointContent == "[null]" ? null :  objvPaperSubViewpointEN.SubViewpointContent; //详情内容
}
if (arrFldSet.Contains(convPaperSubViewpoint.PaperRWId, new clsStrCompareIgnoreCase())  ==  true)
{
objvPaperSubViewpointEN.PaperRWId = objvPaperSubViewpointEN.PaperRWId == "[null]" ? null :  objvPaperSubViewpointEN.PaperRWId; //课文阅读
}
if (arrFldSet.Contains(convPaperSubViewpoint.PaperId, new clsStrCompareIgnoreCase())  ==  true)
{
objvPaperSubViewpointEN.PaperId = objvPaperSubViewpointEN.PaperId == "[null]" ? null :  objvPaperSubViewpointEN.PaperId; //论文Id
}
if (arrFldSet.Contains(convPaperSubViewpoint.PaperTitle, new clsStrCompareIgnoreCase())  ==  true)
{
objvPaperSubViewpointEN.PaperTitle = objvPaperSubViewpointEN.PaperTitle == "[null]" ? null :  objvPaperSubViewpointEN.PaperTitle; //论文标题
}
if (arrFldSet.Contains(convPaperSubViewpoint.IsSubmit, new clsStrCompareIgnoreCase())  ==  true)
{
objvPaperSubViewpointEN.IsSubmit = objvPaperSubViewpointEN.IsSubmit; //是否提交
}
if (arrFldSet.Contains(convPaperSubViewpoint.IdCurrEduCls, new clsStrCompareIgnoreCase())  ==  true)
{
objvPaperSubViewpointEN.IdCurrEduCls = objvPaperSubViewpointEN.IdCurrEduCls; //教学班流水号
}
if (arrFldSet.Contains(convPaperSubViewpoint.UserId, new clsStrCompareIgnoreCase())  ==  true)
{
objvPaperSubViewpointEN.UserId = objvPaperSubViewpointEN.UserId; //用户ID
}
if (arrFldSet.Contains(convPaperSubViewpoint.SectionId, new clsStrCompareIgnoreCase())  ==  true)
{
objvPaperSubViewpointEN.SectionId = objvPaperSubViewpointEN.SectionId == "[null]" ? null :  objvPaperSubViewpointEN.SectionId; //节Id
}
if (arrFldSet.Contains(convPaperSubViewpoint.SectionName, new clsStrCompareIgnoreCase())  ==  true)
{
objvPaperSubViewpointEN.SectionName = objvPaperSubViewpointEN.SectionName == "[null]" ? null :  objvPaperSubViewpointEN.SectionName; //节名
}
if (arrFldSet.Contains(convPaperSubViewpoint.SubViewpointTypeId, new clsStrCompareIgnoreCase())  ==  true)
{
objvPaperSubViewpointEN.SubViewpointTypeId = objvPaperSubViewpointEN.SubViewpointTypeId; //类型Id
}
if (arrFldSet.Contains(convPaperSubViewpoint.SubViewpointTypeName, new clsStrCompareIgnoreCase())  ==  true)
{
objvPaperSubViewpointEN.SubViewpointTypeName = objvPaperSubViewpointEN.SubViewpointTypeName == "[null]" ? null :  objvPaperSubViewpointEN.SubViewpointTypeName; //类型名称
}
if (arrFldSet.Contains(convPaperSubViewpoint.DefaTitle, new clsStrCompareIgnoreCase())  ==  true)
{
objvPaperSubViewpointEN.DefaTitle = objvPaperSubViewpointEN.DefaTitle == "[null]" ? null :  objvPaperSubViewpointEN.DefaTitle; //默认标题
}
if (arrFldSet.Contains(convPaperSubViewpoint.gsKnowledgeTypeId, new clsStrCompareIgnoreCase())  ==  true)
{
objvPaperSubViewpointEN.gsKnowledgeTypeId = objvPaperSubViewpointEN.gsKnowledgeTypeId; //知识类型Id
}
if (arrFldSet.Contains(convPaperSubViewpoint.RWTitle, new clsStrCompareIgnoreCase())  ==  true)
{
objvPaperSubViewpointEN.RWTitle = objvPaperSubViewpointEN.RWTitle == "[null]" ? null :  objvPaperSubViewpointEN.RWTitle; //读写标题
}
if (arrFldSet.Contains(convPaperSubViewpoint.ExplainTypeId, new clsStrCompareIgnoreCase())  ==  true)
{
objvPaperSubViewpointEN.ExplainTypeId = objvPaperSubViewpointEN.ExplainTypeId == "[null]" ? null :  objvPaperSubViewpointEN.ExplainTypeId; //说明类型Id
}
if (arrFldSet.Contains(convPaperSubViewpoint.ExplainTypeName, new clsStrCompareIgnoreCase())  ==  true)
{
objvPaperSubViewpointEN.ExplainTypeName = objvPaperSubViewpointEN.ExplainTypeName == "[null]" ? null :  objvPaperSubViewpointEN.ExplainTypeName; //说明类型名
}
if (arrFldSet.Contains(convPaperSubViewpoint.ExplainContent, new clsStrCompareIgnoreCase())  ==  true)
{
objvPaperSubViewpointEN.ExplainContent = objvPaperSubViewpointEN.ExplainContent == "[null]" ? null :  objvPaperSubViewpointEN.ExplainContent; //说明内容
}
if (arrFldSet.Contains(convPaperSubViewpoint.IsPublic, new clsStrCompareIgnoreCase())  ==  true)
{
objvPaperSubViewpointEN.IsPublic = objvPaperSubViewpointEN.IsPublic; //是否公开
}
if (arrFldSet.Contains(convPaperSubViewpoint.LiteratureSourcesId, new clsStrCompareIgnoreCase())  ==  true)
{
objvPaperSubViewpointEN.LiteratureSourcesId = objvPaperSubViewpointEN.LiteratureSourcesId == "[null]" ? null :  objvPaperSubViewpointEN.LiteratureSourcesId; //文献来源
}
if (arrFldSet.Contains(convPaperSubViewpoint.OperationTypeId, new clsStrCompareIgnoreCase())  ==  true)
{
objvPaperSubViewpointEN.OperationTypeId = objvPaperSubViewpointEN.OperationTypeId == "[null]" ? null :  objvPaperSubViewpointEN.OperationTypeId; //操作类型ID
}
if (arrFldSet.Contains(convPaperSubViewpoint.LevelId, new clsStrCompareIgnoreCase())  ==  true)
{
objvPaperSubViewpointEN.LevelId = objvPaperSubViewpointEN.LevelId == "[null]" ? null :  objvPaperSubViewpointEN.LevelId; //级别Id
}
if (arrFldSet.Contains(convPaperSubViewpoint.Conclusion, new clsStrCompareIgnoreCase())  ==  true)
{
objvPaperSubViewpointEN.Conclusion = objvPaperSubViewpointEN.Conclusion == "[null]" ? null :  objvPaperSubViewpointEN.Conclusion; //结论
}
if (arrFldSet.Contains(convPaperSubViewpoint.Nationality, new clsStrCompareIgnoreCase())  ==  true)
{
objvPaperSubViewpointEN.Nationality = objvPaperSubViewpointEN.Nationality == "[null]" ? null :  objvPaperSubViewpointEN.Nationality; //国籍
}
if (arrFldSet.Contains(convPaperSubViewpoint.Achievement, new clsStrCompareIgnoreCase())  ==  true)
{
objvPaperSubViewpointEN.Achievement = objvPaperSubViewpointEN.Achievement == "[null]" ? null :  objvPaperSubViewpointEN.Achievement; //成就
}
if (arrFldSet.Contains(convPaperSubViewpoint.Major, new clsStrCompareIgnoreCase())  ==  true)
{
objvPaperSubViewpointEN.Major = objvPaperSubViewpointEN.Major == "[null]" ? null :  objvPaperSubViewpointEN.Major; //专业
}
if (arrFldSet.Contains(convPaperSubViewpoint.WorkUnit, new clsStrCompareIgnoreCase())  ==  true)
{
objvPaperSubViewpointEN.WorkUnit = objvPaperSubViewpointEN.WorkUnit == "[null]" ? null :  objvPaperSubViewpointEN.WorkUnit; //工作单位
}
if (arrFldSet.Contains(convPaperSubViewpoint.PageNumber, new clsStrCompareIgnoreCase())  ==  true)
{
objvPaperSubViewpointEN.PageNumber = objvPaperSubViewpointEN.PageNumber; //页码
}
if (arrFldSet.Contains(convPaperSubViewpoint.OrderNum, new clsStrCompareIgnoreCase())  ==  true)
{
objvPaperSubViewpointEN.OrderNum = objvPaperSubViewpointEN.OrderNum; //序号
}
if (arrFldSet.Contains(convPaperSubViewpoint.PdfContent, new clsStrCompareIgnoreCase())  ==  true)
{
objvPaperSubViewpointEN.PdfContent = objvPaperSubViewpointEN.PdfContent == "[null]" ? null :  objvPaperSubViewpointEN.PdfContent; //Pdf内容
}
if (arrFldSet.Contains(convPaperSubViewpoint.selectSpanRange, new clsStrCompareIgnoreCase())  ==  true)
{
objvPaperSubViewpointEN.selectSpanRange = objvPaperSubViewpointEN.selectSpanRange == "[null]" ? null :  objvPaperSubViewpointEN.selectSpanRange; //选择Span范围
}
if (arrFldSet.Contains(convPaperSubViewpoint.PaperLineNum, new clsStrCompareIgnoreCase())  ==  true)
{
objvPaperSubViewpointEN.PaperLineNum = objvPaperSubViewpointEN.PaperLineNum; //论文行号
}
if (arrFldSet.Contains(convPaperSubViewpoint.PaperPageNum, new clsStrCompareIgnoreCase())  ==  true)
{
objvPaperSubViewpointEN.PaperPageNum = objvPaperSubViewpointEN.PaperPageNum; //论文页码
}
if (arrFldSet.Contains(convPaperSubViewpoint.AppraiseCount, new clsStrCompareIgnoreCase())  ==  true)
{
objvPaperSubViewpointEN.AppraiseCount = objvPaperSubViewpointEN.AppraiseCount; //评论数
}
if (arrFldSet.Contains(convPaperSubViewpoint.OkCount, new clsStrCompareIgnoreCase())  ==  true)
{
objvPaperSubViewpointEN.OkCount = objvPaperSubViewpointEN.OkCount; //点赞统计
}
if (arrFldSet.Contains(convPaperSubViewpoint.Score, new clsStrCompareIgnoreCase())  ==  true)
{
objvPaperSubViewpointEN.Score = objvPaperSubViewpointEN.Score; //评分
}
if (arrFldSet.Contains(convPaperSubViewpoint.StuScore, new clsStrCompareIgnoreCase())  ==  true)
{
objvPaperSubViewpointEN.StuScore = objvPaperSubViewpointEN.StuScore; //学生平均分
}
if (arrFldSet.Contains(convPaperSubViewpoint.TeaScore, new clsStrCompareIgnoreCase())  ==  true)
{
objvPaperSubViewpointEN.TeaScore = objvPaperSubViewpointEN.TeaScore; //教师评分
}
if (arrFldSet.Contains(convPaperSubViewpoint.CreateDate, new clsStrCompareIgnoreCase())  ==  true)
{
objvPaperSubViewpointEN.CreateDate = objvPaperSubViewpointEN.CreateDate == "[null]" ? null :  objvPaperSubViewpointEN.CreateDate; //建立日期
}
if (arrFldSet.Contains(convPaperSubViewpoint.ShareId, new clsStrCompareIgnoreCase())  ==  true)
{
objvPaperSubViewpointEN.ShareId = objvPaperSubViewpointEN.ShareId; //分享Id
}
if (arrFldSet.Contains(convPaperSubViewpoint.AttitudesId, new clsStrCompareIgnoreCase())  ==  true)
{
objvPaperSubViewpointEN.AttitudesId = objvPaperSubViewpointEN.AttitudesId; //态度Id
}
if (arrFldSet.Contains(convPaperSubViewpoint.AttitudesName, new clsStrCompareIgnoreCase())  ==  true)
{
objvPaperSubViewpointEN.AttitudesName = objvPaperSubViewpointEN.AttitudesName == "[null]" ? null :  objvPaperSubViewpointEN.AttitudesName; //名称
}
if (arrFldSet.Contains(convPaperSubViewpoint.UpdDate, new clsStrCompareIgnoreCase())  ==  true)
{
objvPaperSubViewpointEN.UpdDate = objvPaperSubViewpointEN.UpdDate == "[null]" ? null :  objvPaperSubViewpointEN.UpdDate; //修改日期
}
if (arrFldSet.Contains(convPaperSubViewpoint.UpdUser, new clsStrCompareIgnoreCase())  ==  true)
{
objvPaperSubViewpointEN.UpdUser = objvPaperSubViewpointEN.UpdUser == "[null]" ? null :  objvPaperSubViewpointEN.UpdUser; //修改人
}
if (arrFldSet.Contains(convPaperSubViewpoint.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objvPaperSubViewpointEN.Memo = objvPaperSubViewpointEN.Memo == "[null]" ? null :  objvPaperSubViewpointEN.Memo; //备注
}
if (arrFldSet.Contains(convPaperSubViewpoint.SectionOrderNum, new clsStrCompareIgnoreCase())  ==  true)
{
objvPaperSubViewpointEN.SectionOrderNum = objvPaperSubViewpointEN.SectionOrderNum; //SectionOrderNum
}
if (arrFldSet.Contains(convPaperSubViewpoint.SubViewpointTypeOrderNum, new clsStrCompareIgnoreCase())  ==  true)
{
objvPaperSubViewpointEN.SubViewpointTypeOrderNum = objvPaperSubViewpointEN.SubViewpointTypeOrderNum; //子观点类型序号
}
if (arrFldSet.Contains(convPaperSubViewpoint.CitationCount, new clsStrCompareIgnoreCase())  ==  true)
{
objvPaperSubViewpointEN.CitationCount = objvPaperSubViewpointEN.CitationCount; //引用统计
}
if (arrFldSet.Contains(convPaperSubViewpoint.VersionCount, new clsStrCompareIgnoreCase())  ==  true)
{
objvPaperSubViewpointEN.VersionCount = objvPaperSubViewpointEN.VersionCount; //版本统计
}
if (arrFldSet.Contains(convPaperSubViewpoint.IsRecommend, new clsStrCompareIgnoreCase())  ==  true)
{
objvPaperSubViewpointEN.IsRecommend = objvPaperSubViewpointEN.IsRecommend; //是否推荐
}
if (arrFldSet.Contains(convPaperSubViewpoint.gsKnowledgeTypeName, new clsStrCompareIgnoreCase())  ==  true)
{
objvPaperSubViewpointEN.gsKnowledgeTypeName = objvPaperSubViewpointEN.gsKnowledgeTypeName; //知识类型名
}
if (arrFldSet.Contains(convPaperSubViewpoint.LevelName, new clsStrCompareIgnoreCase())  ==  true)
{
objvPaperSubViewpointEN.LevelName = objvPaperSubViewpointEN.LevelName == "[null]" ? null :  objvPaperSubViewpointEN.LevelName; //级别名称
}
if (arrFldSet.Contains(convPaperSubViewpoint.OperationTypeName, new clsStrCompareIgnoreCase())  ==  true)
{
objvPaperSubViewpointEN.OperationTypeName = objvPaperSubViewpointEN.OperationTypeName == "[null]" ? null :  objvPaperSubViewpointEN.OperationTypeName; //操作类型名
}
if (arrFldSet.Contains(convPaperSubViewpoint.CourseId, new clsStrCompareIgnoreCase())  ==  true)
{
objvPaperSubViewpointEN.CourseId = objvPaperSubViewpointEN.CourseId == "[null]" ? null :  objvPaperSubViewpointEN.CourseId; //课程Id
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
 /// <param name = "objvPaperSubViewpointEN">源简化对象</param>
 public static void AccessFldValueNull(clsvPaperSubViewpointEN objvPaperSubViewpointEN)
{
try
{
if (objvPaperSubViewpointEN.SubViewpointContent == "[null]") objvPaperSubViewpointEN.SubViewpointContent = null; //详情内容
if (objvPaperSubViewpointEN.PaperRWId == "[null]") objvPaperSubViewpointEN.PaperRWId = null; //课文阅读
if (objvPaperSubViewpointEN.PaperId == "[null]") objvPaperSubViewpointEN.PaperId = null; //论文Id
if (objvPaperSubViewpointEN.PaperTitle == "[null]") objvPaperSubViewpointEN.PaperTitle = null; //论文标题
if (objvPaperSubViewpointEN.SectionId == "[null]") objvPaperSubViewpointEN.SectionId = null; //节Id
if (objvPaperSubViewpointEN.SectionName == "[null]") objvPaperSubViewpointEN.SectionName = null; //节名
if (objvPaperSubViewpointEN.SubViewpointTypeName == "[null]") objvPaperSubViewpointEN.SubViewpointTypeName = null; //类型名称
if (objvPaperSubViewpointEN.DefaTitle == "[null]") objvPaperSubViewpointEN.DefaTitle = null; //默认标题
if (objvPaperSubViewpointEN.RWTitle == "[null]") objvPaperSubViewpointEN.RWTitle = null; //读写标题
if (objvPaperSubViewpointEN.ExplainTypeId == "[null]") objvPaperSubViewpointEN.ExplainTypeId = null; //说明类型Id
if (objvPaperSubViewpointEN.ExplainTypeName == "[null]") objvPaperSubViewpointEN.ExplainTypeName = null; //说明类型名
if (objvPaperSubViewpointEN.ExplainContent == "[null]") objvPaperSubViewpointEN.ExplainContent = null; //说明内容
if (objvPaperSubViewpointEN.LiteratureSourcesId == "[null]") objvPaperSubViewpointEN.LiteratureSourcesId = null; //文献来源
if (objvPaperSubViewpointEN.OperationTypeId == "[null]") objvPaperSubViewpointEN.OperationTypeId = null; //操作类型ID
if (objvPaperSubViewpointEN.LevelId == "[null]") objvPaperSubViewpointEN.LevelId = null; //级别Id
if (objvPaperSubViewpointEN.Conclusion == "[null]") objvPaperSubViewpointEN.Conclusion = null; //结论
if (objvPaperSubViewpointEN.Nationality == "[null]") objvPaperSubViewpointEN.Nationality = null; //国籍
if (objvPaperSubViewpointEN.Achievement == "[null]") objvPaperSubViewpointEN.Achievement = null; //成就
if (objvPaperSubViewpointEN.Major == "[null]") objvPaperSubViewpointEN.Major = null; //专业
if (objvPaperSubViewpointEN.WorkUnit == "[null]") objvPaperSubViewpointEN.WorkUnit = null; //工作单位
if (objvPaperSubViewpointEN.PdfContent == "[null]") objvPaperSubViewpointEN.PdfContent = null; //Pdf内容
if (objvPaperSubViewpointEN.selectSpanRange == "[null]") objvPaperSubViewpointEN.selectSpanRange = null; //选择Span范围
if (objvPaperSubViewpointEN.CreateDate == "[null]") objvPaperSubViewpointEN.CreateDate = null; //建立日期
if (objvPaperSubViewpointEN.AttitudesName == "[null]") objvPaperSubViewpointEN.AttitudesName = null; //名称
if (objvPaperSubViewpointEN.UpdDate == "[null]") objvPaperSubViewpointEN.UpdDate = null; //修改日期
if (objvPaperSubViewpointEN.UpdUser == "[null]") objvPaperSubViewpointEN.UpdUser = null; //修改人
if (objvPaperSubViewpointEN.Memo == "[null]") objvPaperSubViewpointEN.Memo = null; //备注
if (objvPaperSubViewpointEN.LevelName == "[null]") objvPaperSubViewpointEN.LevelName = null; //级别名称
if (objvPaperSubViewpointEN.OperationTypeName == "[null]") objvPaperSubViewpointEN.OperationTypeName = null; //操作类型名
if (objvPaperSubViewpointEN.CourseId == "[null]") objvPaperSubViewpointEN.CourseId = null; //课程Id
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
public static void CheckProperty4Condition(clsvPaperSubViewpointEN objvPaperSubViewpointEN)
{
 vPaperSubViewpointDA.CheckProperty4Condition(objvPaperSubViewpointEN);
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
if (clsSubViewpointTypeBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsSubViewpointTypeBL没有刷新缓存机制(clsSubViewpointTypeBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsPaperSubViewpointBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsPaperSubViewpointBL没有刷新缓存机制(clsPaperSubViewpointBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsPaperBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsPaperBL没有刷新缓存机制(clsPaperBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsExplainTypeBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsExplainTypeBL没有刷新缓存机制(clsExplainTypeBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsSectionBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsSectionBL没有刷新缓存机制(clsSectionBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsgs_PaperSubViewsAttitudesBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsgs_PaperSubViewsAttitudesBL没有刷新缓存机制(clsgs_PaperSubViewsAttitudesBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by SubViewpointId");
//if (arrvPaperSubViewpointObjLstCache == null)
//{
//arrvPaperSubViewpointObjLstCache = vPaperSubViewpointDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "lngSubViewpointId">所给的关键字</param>
 /// <param name = "strIdCurrEduCls">缓存的分类字段</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvPaperSubViewpointEN GetObjBySubViewpointIdCache(long lngSubViewpointId, string strIdCurrEduCls)
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
string strKey = string.Format("{0}_{1}", clsvPaperSubViewpointEN._CurrTabName, strIdCurrEduCls);
List<clsvPaperSubViewpointEN> arrvPaperSubViewpointObjLstCache = GetObjLstCache(strIdCurrEduCls);
IEnumerable <clsvPaperSubViewpointEN> arrvPaperSubViewpointObjLst_Sel =
arrvPaperSubViewpointObjLstCache
.Where(x=> x.SubViewpointId == lngSubViewpointId 
);
if (arrvPaperSubViewpointObjLst_Sel.Count() == 0)
{
   clsvPaperSubViewpointEN obj = clsvPaperSubViewpointBL.GetObjBySubViewpointId(lngSubViewpointId);
   if (obj != null)
 {
if (obj.IdCurrEduCls == strIdCurrEduCls)
{
CacheHelper.Remove(strKey);
     return obj;
}
else
{
string strMsg = string.Format("错误: 关键字:{0}不属于分类:{1},请检查!(In {2})", lngSubViewpointId, strIdCurrEduCls, clsStackTrace.GetCurrClassFunction());
clsSysParaEN.objLog.WriteDebugLog(strMsg);
throw new Exception(strMsg);
}
 }
return null;
}
return arrvPaperSubViewpointObjLst_Sel.First();
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvPaperSubViewpointEN> GetAllvPaperSubViewpointObjLstCache(string strIdCurrEduCls)
{
//获取缓存中的对象列表
List<clsvPaperSubViewpointEN> arrvPaperSubViewpointObjLstCache = GetObjLstCache(strIdCurrEduCls); 
return arrvPaperSubViewpointObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvPaperSubViewpointEN> GetObjLstCache(string strIdCurrEduCls)
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
string strKey = string.Format("{0}_{1}", clsvPaperSubViewpointEN._CurrTabName, strIdCurrEduCls);
string strCondition = string.Format("IdCurrEduCls='{0}'", strIdCurrEduCls);
List<clsvPaperSubViewpointEN> arrvPaperSubViewpointObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst(strCondition); });
return arrvPaperSubViewpointObjLstCache;
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
string strKey = string.Format("{0}_{1}", clsvPaperSubViewpointEN._CurrTabName, strIdCurrEduCls);
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
 /// 日期:2024-02-27
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_func)
 /// </summary>
 /// <param name = "strInFldName">输入字段名</param>
 /// <param name = "strOutFldName">输出字段名</param>
 /// <param name = "strInValue">输入字段值</param>
 /// <param name = "strIdCurrEduCls">缓存的分类字段</param>
 /// <returns>返回一个输出字段值</returns>
public static string Func(string strInFldName, string strOutFldName, long lngSubViewpointId, string strIdCurrEduCls)
{
if (strInFldName != convPaperSubViewpoint.SubViewpointId)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (convPaperSubViewpoint.AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", convPaperSubViewpoint.AttributeName));
throw new Exception(strMsg);
}
var objvPaperSubViewpoint = clsvPaperSubViewpointBL.GetObjBySubViewpointIdCache(lngSubViewpointId, strIdCurrEduCls);
if (objvPaperSubViewpoint == null) return "";
return objvPaperSubViewpoint[strOutFldName].ToString();
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
int intRecCount = clsvPaperSubViewpointDA.GetRecCount(strTabName);
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
int intRecCount = clsvPaperSubViewpointDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsvPaperSubViewpointDA.GetRecCount();
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
int intRecCount = clsvPaperSubViewpointDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objvPaperSubViewpointCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsvPaperSubViewpointEN objvPaperSubViewpointCond)
{
 string strIdCurrEduCls = objvPaperSubViewpointCond.IdCurrEduCls;
 if (string.IsNullOrEmpty(strIdCurrEduCls) == true)
{
string strMsg = string.Format("(errid:Busi000174)在表中,缓存分类字段值不能为空!(clsvPaperSubViewpointBL:GetRecCountByCondCache)");
throw new Exception(strMsg);
}
List<clsvPaperSubViewpointEN> arrObjLstCache = GetObjLstCache(strIdCurrEduCls);
IEnumerable <clsvPaperSubViewpointEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convPaperSubViewpoint.AttributeName)
{
if (objvPaperSubViewpointCond.IsUpdated(strFldName) == false) continue;
if (objvPaperSubViewpointCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvPaperSubViewpointCond[strFldName].ToString());
}
else
{
if (objvPaperSubViewpointCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvPaperSubViewpointCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvPaperSubViewpointCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvPaperSubViewpointCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvPaperSubViewpointCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvPaperSubViewpointCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvPaperSubViewpointCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvPaperSubViewpointCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvPaperSubViewpointCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvPaperSubViewpointCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvPaperSubViewpointCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvPaperSubViewpointCond[strFldName]));
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
 List<string> arrList = clsvPaperSubViewpointDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = vPaperSubViewpointDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = vPaperSubViewpointDA.GetFldValueNoDistinct(strFldName, strWhereCond);
return arrList;
}



 #endregion 表操作常用函数
}
}