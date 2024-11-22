
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvgs_PViewpointRelaBL
 表名:vgs_PViewpointRela(01120669)
 * 版本:2023.08.23.1(服务器:WIN-SRV103-116)
 日期:2023/08/24 12:59:24
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
public static class  clsvgs_PViewpointRelaBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvgs_PViewpointRelaEN GetObj(this K_mId_vgs_PViewpointRela myKey)
{
clsvgs_PViewpointRelaEN objvgs_PViewpointRelaEN = clsvgs_PViewpointRelaBL.vgs_PViewpointRelaDA.GetObjBymId(myKey.Value);
return objvgs_PViewpointRelaEN;
}

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvgs_PViewpointRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvgs_PViewpointRelaEN SetmId(this clsvgs_PViewpointRelaEN objvgs_PViewpointRelaEN, long lngmId, string strComparisonOp="")
	{
objvgs_PViewpointRelaEN.mId = lngmId; //mId
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvgs_PViewpointRelaEN.dicFldComparisonOp.ContainsKey(convgs_PViewpointRela.mId) == false)
{
objvgs_PViewpointRelaEN.dicFldComparisonOp.Add(convgs_PViewpointRela.mId, strComparisonOp);
}
else
{
objvgs_PViewpointRelaEN.dicFldComparisonOp[convgs_PViewpointRela.mId] = strComparisonOp;
}
}
return objvgs_PViewpointRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvgs_PViewpointRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvgs_PViewpointRelaEN SetPaperId(this clsvgs_PViewpointRelaEN objvgs_PViewpointRelaEN, string strPaperId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strPaperId, convgs_PViewpointRela.PaperId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPaperId, 8, convgs_PViewpointRela.PaperId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strPaperId, 8, convgs_PViewpointRela.PaperId);
}
objvgs_PViewpointRelaEN.PaperId = strPaperId; //论文Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvgs_PViewpointRelaEN.dicFldComparisonOp.ContainsKey(convgs_PViewpointRela.PaperId) == false)
{
objvgs_PViewpointRelaEN.dicFldComparisonOp.Add(convgs_PViewpointRela.PaperId, strComparisonOp);
}
else
{
objvgs_PViewpointRelaEN.dicFldComparisonOp[convgs_PViewpointRela.PaperId] = strComparisonOp;
}
}
return objvgs_PViewpointRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvgs_PViewpointRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvgs_PViewpointRelaEN SetPaperTitle(this clsvgs_PViewpointRelaEN objvgs_PViewpointRelaEN, string strPaperTitle, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPaperTitle, 500, convgs_PViewpointRela.PaperTitle);
}
objvgs_PViewpointRelaEN.PaperTitle = strPaperTitle; //论文标题
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvgs_PViewpointRelaEN.dicFldComparisonOp.ContainsKey(convgs_PViewpointRela.PaperTitle) == false)
{
objvgs_PViewpointRelaEN.dicFldComparisonOp.Add(convgs_PViewpointRela.PaperTitle, strComparisonOp);
}
else
{
objvgs_PViewpointRelaEN.dicFldComparisonOp[convgs_PViewpointRela.PaperTitle] = strComparisonOp;
}
}
return objvgs_PViewpointRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvgs_PViewpointRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvgs_PViewpointRelaEN SetPaperTypeId(this clsvgs_PViewpointRelaEN objvgs_PViewpointRelaEN, string strPaperTypeId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPaperTypeId, 2, convgs_PViewpointRela.PaperTypeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strPaperTypeId, 2, convgs_PViewpointRela.PaperTypeId);
}
objvgs_PViewpointRelaEN.PaperTypeId = strPaperTypeId; //论文类型Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvgs_PViewpointRelaEN.dicFldComparisonOp.ContainsKey(convgs_PViewpointRela.PaperTypeId) == false)
{
objvgs_PViewpointRelaEN.dicFldComparisonOp.Add(convgs_PViewpointRela.PaperTypeId, strComparisonOp);
}
else
{
objvgs_PViewpointRelaEN.dicFldComparisonOp[convgs_PViewpointRela.PaperTypeId] = strComparisonOp;
}
}
return objvgs_PViewpointRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvgs_PViewpointRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvgs_PViewpointRelaEN SetSectionId(this clsvgs_PViewpointRelaEN objvgs_PViewpointRelaEN, string strSectionId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strSectionId, 8, convgs_PViewpointRela.SectionId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strSectionId, 8, convgs_PViewpointRela.SectionId);
}
objvgs_PViewpointRelaEN.SectionId = strSectionId; //节Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvgs_PViewpointRelaEN.dicFldComparisonOp.ContainsKey(convgs_PViewpointRela.SectionId) == false)
{
objvgs_PViewpointRelaEN.dicFldComparisonOp.Add(convgs_PViewpointRela.SectionId, strComparisonOp);
}
else
{
objvgs_PViewpointRelaEN.dicFldComparisonOp[convgs_PViewpointRela.SectionId] = strComparisonOp;
}
}
return objvgs_PViewpointRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvgs_PViewpointRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvgs_PViewpointRelaEN SetSectionName(this clsvgs_PViewpointRelaEN objvgs_PViewpointRelaEN, string strSectionName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strSectionName, 100, convgs_PViewpointRela.SectionName);
}
objvgs_PViewpointRelaEN.SectionName = strSectionName; //节名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvgs_PViewpointRelaEN.dicFldComparisonOp.ContainsKey(convgs_PViewpointRela.SectionName) == false)
{
objvgs_PViewpointRelaEN.dicFldComparisonOp.Add(convgs_PViewpointRela.SectionName, strComparisonOp);
}
else
{
objvgs_PViewpointRelaEN.dicFldComparisonOp[convgs_PViewpointRela.SectionName] = strComparisonOp;
}
}
return objvgs_PViewpointRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvgs_PViewpointRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvgs_PViewpointRelaEN SetViewpointId(this clsvgs_PViewpointRelaEN objvgs_PViewpointRelaEN, string strViewpointId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strViewpointId, convgs_PViewpointRela.ViewpointId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strViewpointId, 8, convgs_PViewpointRela.ViewpointId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strViewpointId, 8, convgs_PViewpointRela.ViewpointId);
}
objvgs_PViewpointRelaEN.ViewpointId = strViewpointId; //观点Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvgs_PViewpointRelaEN.dicFldComparisonOp.ContainsKey(convgs_PViewpointRela.ViewpointId) == false)
{
objvgs_PViewpointRelaEN.dicFldComparisonOp.Add(convgs_PViewpointRela.ViewpointId, strComparisonOp);
}
else
{
objvgs_PViewpointRelaEN.dicFldComparisonOp[convgs_PViewpointRela.ViewpointId] = strComparisonOp;
}
}
return objvgs_PViewpointRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvgs_PViewpointRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvgs_PViewpointRelaEN SetViewpointName(this clsvgs_PViewpointRelaEN objvgs_PViewpointRelaEN, string strViewpointName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strViewpointName, 500, convgs_PViewpointRela.ViewpointName);
}
objvgs_PViewpointRelaEN.ViewpointName = strViewpointName; //观点名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvgs_PViewpointRelaEN.dicFldComparisonOp.ContainsKey(convgs_PViewpointRela.ViewpointName) == false)
{
objvgs_PViewpointRelaEN.dicFldComparisonOp.Add(convgs_PViewpointRela.ViewpointName, strComparisonOp);
}
else
{
objvgs_PViewpointRelaEN.dicFldComparisonOp[convgs_PViewpointRela.ViewpointName] = strComparisonOp;
}
}
return objvgs_PViewpointRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvgs_PViewpointRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvgs_PViewpointRelaEN SetViewpointContent(this clsvgs_PViewpointRelaEN objvgs_PViewpointRelaEN, string strViewpointContent, string strComparisonOp="")
	{
objvgs_PViewpointRelaEN.ViewpointContent = strViewpointContent; //观点内容
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvgs_PViewpointRelaEN.dicFldComparisonOp.ContainsKey(convgs_PViewpointRela.ViewpointContent) == false)
{
objvgs_PViewpointRelaEN.dicFldComparisonOp.Add(convgs_PViewpointRela.ViewpointContent, strComparisonOp);
}
else
{
objvgs_PViewpointRelaEN.dicFldComparisonOp[convgs_PViewpointRela.ViewpointContent] = strComparisonOp;
}
}
return objvgs_PViewpointRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvgs_PViewpointRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvgs_PViewpointRelaEN SetViewpointTypeId(this clsvgs_PViewpointRelaEN objvgs_PViewpointRelaEN, string strViewpointTypeId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strViewpointTypeId, 4, convgs_PViewpointRela.ViewpointTypeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strViewpointTypeId, 4, convgs_PViewpointRela.ViewpointTypeId);
}
objvgs_PViewpointRelaEN.ViewpointTypeId = strViewpointTypeId; //观点类型Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvgs_PViewpointRelaEN.dicFldComparisonOp.ContainsKey(convgs_PViewpointRela.ViewpointTypeId) == false)
{
objvgs_PViewpointRelaEN.dicFldComparisonOp.Add(convgs_PViewpointRela.ViewpointTypeId, strComparisonOp);
}
else
{
objvgs_PViewpointRelaEN.dicFldComparisonOp[convgs_PViewpointRela.ViewpointTypeId] = strComparisonOp;
}
}
return objvgs_PViewpointRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvgs_PViewpointRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvgs_PViewpointRelaEN SetViewpointTypeName(this clsvgs_PViewpointRelaEN objvgs_PViewpointRelaEN, string strViewpointTypeName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strViewpointTypeName, 50, convgs_PViewpointRela.ViewpointTypeName);
}
objvgs_PViewpointRelaEN.ViewpointTypeName = strViewpointTypeName; //观点类型名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvgs_PViewpointRelaEN.dicFldComparisonOp.ContainsKey(convgs_PViewpointRela.ViewpointTypeName) == false)
{
objvgs_PViewpointRelaEN.dicFldComparisonOp.Add(convgs_PViewpointRela.ViewpointTypeName, strComparisonOp);
}
else
{
objvgs_PViewpointRelaEN.dicFldComparisonOp[convgs_PViewpointRela.ViewpointTypeName] = strComparisonOp;
}
}
return objvgs_PViewpointRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvgs_PViewpointRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvgs_PViewpointRelaEN SetReason(this clsvgs_PViewpointRelaEN objvgs_PViewpointRelaEN, string strReason, string strComparisonOp="")
	{
objvgs_PViewpointRelaEN.Reason = strReason; //理由
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvgs_PViewpointRelaEN.dicFldComparisonOp.ContainsKey(convgs_PViewpointRela.Reason) == false)
{
objvgs_PViewpointRelaEN.dicFldComparisonOp.Add(convgs_PViewpointRela.Reason, strComparisonOp);
}
else
{
objvgs_PViewpointRelaEN.dicFldComparisonOp[convgs_PViewpointRela.Reason] = strComparisonOp;
}
}
return objvgs_PViewpointRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvgs_PViewpointRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvgs_PViewpointRelaEN SetVPProposePeople(this clsvgs_PViewpointRelaEN objvgs_PViewpointRelaEN, string strVPProposePeople, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strVPProposePeople, 50, convgs_PViewpointRela.VPProposePeople);
}
objvgs_PViewpointRelaEN.VPProposePeople = strVPProposePeople; //观点提出人
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvgs_PViewpointRelaEN.dicFldComparisonOp.ContainsKey(convgs_PViewpointRela.VPProposePeople) == false)
{
objvgs_PViewpointRelaEN.dicFldComparisonOp.Add(convgs_PViewpointRela.VPProposePeople, strComparisonOp);
}
else
{
objvgs_PViewpointRelaEN.dicFldComparisonOp[convgs_PViewpointRela.VPProposePeople] = strComparisonOp;
}
}
return objvgs_PViewpointRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvgs_PViewpointRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvgs_PViewpointRelaEN SetIsSubmit(this clsvgs_PViewpointRelaEN objvgs_PViewpointRelaEN, bool bolIsSubmit, string strComparisonOp="")
	{
objvgs_PViewpointRelaEN.IsSubmit = bolIsSubmit; //是否提交
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvgs_PViewpointRelaEN.dicFldComparisonOp.ContainsKey(convgs_PViewpointRela.IsSubmit) == false)
{
objvgs_PViewpointRelaEN.dicFldComparisonOp.Add(convgs_PViewpointRela.IsSubmit, strComparisonOp);
}
else
{
objvgs_PViewpointRelaEN.dicFldComparisonOp[convgs_PViewpointRela.IsSubmit] = strComparisonOp;
}
}
return objvgs_PViewpointRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvgs_PViewpointRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvgs_PViewpointRelaEN SetUserTypeId(this clsvgs_PViewpointRelaEN objvgs_PViewpointRelaEN, string strUserTypeId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUserTypeId, 2, convgs_PViewpointRela.UserTypeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strUserTypeId, 2, convgs_PViewpointRela.UserTypeId);
}
objvgs_PViewpointRelaEN.UserTypeId = strUserTypeId; //用户类型Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvgs_PViewpointRelaEN.dicFldComparisonOp.ContainsKey(convgs_PViewpointRela.UserTypeId) == false)
{
objvgs_PViewpointRelaEN.dicFldComparisonOp.Add(convgs_PViewpointRela.UserTypeId, strComparisonOp);
}
else
{
objvgs_PViewpointRelaEN.dicFldComparisonOp[convgs_PViewpointRela.UserTypeId] = strComparisonOp;
}
}
return objvgs_PViewpointRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvgs_PViewpointRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvgs_PViewpointRelaEN SetUserTypeName(this clsvgs_PViewpointRelaEN objvgs_PViewpointRelaEN, string strUserTypeName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUserTypeName, 20, convgs_PViewpointRela.UserTypeName);
}
objvgs_PViewpointRelaEN.UserTypeName = strUserTypeName; //用户类型名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvgs_PViewpointRelaEN.dicFldComparisonOp.ContainsKey(convgs_PViewpointRela.UserTypeName) == false)
{
objvgs_PViewpointRelaEN.dicFldComparisonOp.Add(convgs_PViewpointRela.UserTypeName, strComparisonOp);
}
else
{
objvgs_PViewpointRelaEN.dicFldComparisonOp[convgs_PViewpointRela.UserTypeName] = strComparisonOp;
}
}
return objvgs_PViewpointRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvgs_PViewpointRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvgs_PViewpointRelaEN SetAppraiseCount(this clsvgs_PViewpointRelaEN objvgs_PViewpointRelaEN, int? intAppraiseCount, string strComparisonOp="")
	{
objvgs_PViewpointRelaEN.AppraiseCount = intAppraiseCount; //评论数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvgs_PViewpointRelaEN.dicFldComparisonOp.ContainsKey(convgs_PViewpointRela.AppraiseCount) == false)
{
objvgs_PViewpointRelaEN.dicFldComparisonOp.Add(convgs_PViewpointRela.AppraiseCount, strComparisonOp);
}
else
{
objvgs_PViewpointRelaEN.dicFldComparisonOp[convgs_PViewpointRela.AppraiseCount] = strComparisonOp;
}
}
return objvgs_PViewpointRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvgs_PViewpointRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvgs_PViewpointRelaEN SetScore(this clsvgs_PViewpointRelaEN objvgs_PViewpointRelaEN, float? fltScore, string strComparisonOp="")
	{
objvgs_PViewpointRelaEN.Score = fltScore; //评分
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvgs_PViewpointRelaEN.dicFldComparisonOp.ContainsKey(convgs_PViewpointRela.Score) == false)
{
objvgs_PViewpointRelaEN.dicFldComparisonOp.Add(convgs_PViewpointRela.Score, strComparisonOp);
}
else
{
objvgs_PViewpointRelaEN.dicFldComparisonOp[convgs_PViewpointRela.Score] = strComparisonOp;
}
}
return objvgs_PViewpointRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvgs_PViewpointRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvgs_PViewpointRelaEN SetStuScore(this clsvgs_PViewpointRelaEN objvgs_PViewpointRelaEN, float? fltStuScore, string strComparisonOp="")
	{
objvgs_PViewpointRelaEN.StuScore = fltStuScore; //学生平均分
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvgs_PViewpointRelaEN.dicFldComparisonOp.ContainsKey(convgs_PViewpointRela.StuScore) == false)
{
objvgs_PViewpointRelaEN.dicFldComparisonOp.Add(convgs_PViewpointRela.StuScore, strComparisonOp);
}
else
{
objvgs_PViewpointRelaEN.dicFldComparisonOp[convgs_PViewpointRela.StuScore] = strComparisonOp;
}
}
return objvgs_PViewpointRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvgs_PViewpointRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvgs_PViewpointRelaEN SetTeaScore(this clsvgs_PViewpointRelaEN objvgs_PViewpointRelaEN, float? fltTeaScore, string strComparisonOp="")
	{
objvgs_PViewpointRelaEN.TeaScore = fltTeaScore; //教师评分
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvgs_PViewpointRelaEN.dicFldComparisonOp.ContainsKey(convgs_PViewpointRela.TeaScore) == false)
{
objvgs_PViewpointRelaEN.dicFldComparisonOp.Add(convgs_PViewpointRela.TeaScore, strComparisonOp);
}
else
{
objvgs_PViewpointRelaEN.dicFldComparisonOp[convgs_PViewpointRela.TeaScore] = strComparisonOp;
}
}
return objvgs_PViewpointRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvgs_PViewpointRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvgs_PViewpointRelaEN SetOkCount(this clsvgs_PViewpointRelaEN objvgs_PViewpointRelaEN, int? intOkCount, string strComparisonOp="")
	{
objvgs_PViewpointRelaEN.OkCount = intOkCount; //点赞统计
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvgs_PViewpointRelaEN.dicFldComparisonOp.ContainsKey(convgs_PViewpointRela.OkCount) == false)
{
objvgs_PViewpointRelaEN.dicFldComparisonOp.Add(convgs_PViewpointRela.OkCount, strComparisonOp);
}
else
{
objvgs_PViewpointRelaEN.dicFldComparisonOp[convgs_PViewpointRela.OkCount] = strComparisonOp;
}
}
return objvgs_PViewpointRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvgs_PViewpointRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvgs_PViewpointRelaEN SetCitationCount(this clsvgs_PViewpointRelaEN objvgs_PViewpointRelaEN, int? intCitationCount, string strComparisonOp="")
	{
objvgs_PViewpointRelaEN.CitationCount = intCitationCount; //引用统计
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvgs_PViewpointRelaEN.dicFldComparisonOp.ContainsKey(convgs_PViewpointRela.CitationCount) == false)
{
objvgs_PViewpointRelaEN.dicFldComparisonOp.Add(convgs_PViewpointRela.CitationCount, strComparisonOp);
}
else
{
objvgs_PViewpointRelaEN.dicFldComparisonOp[convgs_PViewpointRela.CitationCount] = strComparisonOp;
}
}
return objvgs_PViewpointRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvgs_PViewpointRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvgs_PViewpointRelaEN SetVersionCount(this clsvgs_PViewpointRelaEN objvgs_PViewpointRelaEN, int? intVersionCount, string strComparisonOp="")
	{
objvgs_PViewpointRelaEN.VersionCount = intVersionCount; //版本统计
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvgs_PViewpointRelaEN.dicFldComparisonOp.ContainsKey(convgs_PViewpointRela.VersionCount) == false)
{
objvgs_PViewpointRelaEN.dicFldComparisonOp.Add(convgs_PViewpointRela.VersionCount, strComparisonOp);
}
else
{
objvgs_PViewpointRelaEN.dicFldComparisonOp[convgs_PViewpointRela.VersionCount] = strComparisonOp;
}
}
return objvgs_PViewpointRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvgs_PViewpointRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvgs_PViewpointRelaEN SetProposePeople(this clsvgs_PViewpointRelaEN objvgs_PViewpointRelaEN, string strProposePeople, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strProposePeople, 50, convgs_PViewpointRela.ProposePeople);
}
objvgs_PViewpointRelaEN.ProposePeople = strProposePeople; //提出人
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvgs_PViewpointRelaEN.dicFldComparisonOp.ContainsKey(convgs_PViewpointRela.ProposePeople) == false)
{
objvgs_PViewpointRelaEN.dicFldComparisonOp.Add(convgs_PViewpointRela.ProposePeople, strComparisonOp);
}
else
{
objvgs_PViewpointRelaEN.dicFldComparisonOp[convgs_PViewpointRela.ProposePeople] = strComparisonOp;
}
}
return objvgs_PViewpointRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvgs_PViewpointRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvgs_PViewpointRelaEN SetUpdDate(this clsvgs_PViewpointRelaEN objvgs_PViewpointRelaEN, string strUpdDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdDate, 20, convgs_PViewpointRela.UpdDate);
}
objvgs_PViewpointRelaEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvgs_PViewpointRelaEN.dicFldComparisonOp.ContainsKey(convgs_PViewpointRela.UpdDate) == false)
{
objvgs_PViewpointRelaEN.dicFldComparisonOp.Add(convgs_PViewpointRela.UpdDate, strComparisonOp);
}
else
{
objvgs_PViewpointRelaEN.dicFldComparisonOp[convgs_PViewpointRela.UpdDate] = strComparisonOp;
}
}
return objvgs_PViewpointRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvgs_PViewpointRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvgs_PViewpointRelaEN SetUpdUser(this clsvgs_PViewpointRelaEN objvgs_PViewpointRelaEN, string strUpdUser, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdUser, 20, convgs_PViewpointRela.UpdUser);
}
objvgs_PViewpointRelaEN.UpdUser = strUpdUser; //修改人
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvgs_PViewpointRelaEN.dicFldComparisonOp.ContainsKey(convgs_PViewpointRela.UpdUser) == false)
{
objvgs_PViewpointRelaEN.dicFldComparisonOp.Add(convgs_PViewpointRela.UpdUser, strComparisonOp);
}
else
{
objvgs_PViewpointRelaEN.dicFldComparisonOp[convgs_PViewpointRela.UpdUser] = strComparisonOp;
}
}
return objvgs_PViewpointRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvgs_PViewpointRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvgs_PViewpointRelaEN SetMemo(this clsvgs_PViewpointRelaEN objvgs_PViewpointRelaEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, convgs_PViewpointRela.Memo);
}
objvgs_PViewpointRelaEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvgs_PViewpointRelaEN.dicFldComparisonOp.ContainsKey(convgs_PViewpointRela.Memo) == false)
{
objvgs_PViewpointRelaEN.dicFldComparisonOp.Add(convgs_PViewpointRela.Memo, strComparisonOp);
}
else
{
objvgs_PViewpointRelaEN.dicFldComparisonOp[convgs_PViewpointRela.Memo] = strComparisonOp;
}
}
return objvgs_PViewpointRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvgs_PViewpointRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvgs_PViewpointRelaEN SetViewsDate(this clsvgs_PViewpointRelaEN objvgs_PViewpointRelaEN, string strViewsDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strViewsDate, 20, convgs_PViewpointRela.ViewsDate);
}
objvgs_PViewpointRelaEN.ViewsDate = strViewsDate; //ViewsDate
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvgs_PViewpointRelaEN.dicFldComparisonOp.ContainsKey(convgs_PViewpointRela.ViewsDate) == false)
{
objvgs_PViewpointRelaEN.dicFldComparisonOp.Add(convgs_PViewpointRela.ViewsDate, strComparisonOp);
}
else
{
objvgs_PViewpointRelaEN.dicFldComparisonOp[convgs_PViewpointRela.ViewsDate] = strComparisonOp;
}
}
return objvgs_PViewpointRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvgs_PViewpointRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvgs_PViewpointRelaEN SetViewsUserId(this clsvgs_PViewpointRelaEN objvgs_PViewpointRelaEN, string strViewsUserId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strViewsUserId, 20, convgs_PViewpointRela.ViewsUserId);
}
objvgs_PViewpointRelaEN.ViewsUserId = strViewsUserId; //ViewsUserId
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvgs_PViewpointRelaEN.dicFldComparisonOp.ContainsKey(convgs_PViewpointRela.ViewsUserId) == false)
{
objvgs_PViewpointRelaEN.dicFldComparisonOp.Add(convgs_PViewpointRela.ViewsUserId, strComparisonOp);
}
else
{
objvgs_PViewpointRelaEN.dicFldComparisonOp[convgs_PViewpointRela.ViewsUserId] = strComparisonOp;
}
}
return objvgs_PViewpointRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvgs_PViewpointRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvgs_PViewpointRelaEN SetCreateDate(this clsvgs_PViewpointRelaEN objvgs_PViewpointRelaEN, string strCreateDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCreateDate, 20, convgs_PViewpointRela.CreateDate);
}
objvgs_PViewpointRelaEN.CreateDate = strCreateDate; //建立日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvgs_PViewpointRelaEN.dicFldComparisonOp.ContainsKey(convgs_PViewpointRela.CreateDate) == false)
{
objvgs_PViewpointRelaEN.dicFldComparisonOp.Add(convgs_PViewpointRela.CreateDate, strComparisonOp);
}
else
{
objvgs_PViewpointRelaEN.dicFldComparisonOp[convgs_PViewpointRela.CreateDate] = strComparisonOp;
}
}
return objvgs_PViewpointRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvgs_PViewpointRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvgs_PViewpointRelaEN SetShareId(this clsvgs_PViewpointRelaEN objvgs_PViewpointRelaEN, string strShareId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strShareId, 2, convgs_PViewpointRela.ShareId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strShareId, 2, convgs_PViewpointRela.ShareId);
}
objvgs_PViewpointRelaEN.ShareId = strShareId; //分享Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvgs_PViewpointRelaEN.dicFldComparisonOp.ContainsKey(convgs_PViewpointRela.ShareId) == false)
{
objvgs_PViewpointRelaEN.dicFldComparisonOp.Add(convgs_PViewpointRela.ShareId, strComparisonOp);
}
else
{
objvgs_PViewpointRelaEN.dicFldComparisonOp[convgs_PViewpointRela.ShareId] = strComparisonOp;
}
}
return objvgs_PViewpointRelaEN;
	}

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CopyObj)
 /// </summary>
 /// <param name = "objvgs_PViewpointRelaENS">源对象</param>
 /// <param name = "objvgs_PViewpointRelaENT">目标对象</param>
 public static void CopyTo(this clsvgs_PViewpointRelaEN objvgs_PViewpointRelaENS, clsvgs_PViewpointRelaEN objvgs_PViewpointRelaENT)
{
try
{
objvgs_PViewpointRelaENT.mId = objvgs_PViewpointRelaENS.mId; //mId
objvgs_PViewpointRelaENT.PaperId = objvgs_PViewpointRelaENS.PaperId; //论文Id
objvgs_PViewpointRelaENT.PaperTitle = objvgs_PViewpointRelaENS.PaperTitle; //论文标题
objvgs_PViewpointRelaENT.PaperTypeId = objvgs_PViewpointRelaENS.PaperTypeId; //论文类型Id
objvgs_PViewpointRelaENT.SectionId = objvgs_PViewpointRelaENS.SectionId; //节Id
objvgs_PViewpointRelaENT.SectionName = objvgs_PViewpointRelaENS.SectionName; //节名
objvgs_PViewpointRelaENT.ViewpointId = objvgs_PViewpointRelaENS.ViewpointId; //观点Id
objvgs_PViewpointRelaENT.ViewpointName = objvgs_PViewpointRelaENS.ViewpointName; //观点名称
objvgs_PViewpointRelaENT.ViewpointContent = objvgs_PViewpointRelaENS.ViewpointContent; //观点内容
objvgs_PViewpointRelaENT.ViewpointTypeId = objvgs_PViewpointRelaENS.ViewpointTypeId; //观点类型Id
objvgs_PViewpointRelaENT.ViewpointTypeName = objvgs_PViewpointRelaENS.ViewpointTypeName; //观点类型名
objvgs_PViewpointRelaENT.Reason = objvgs_PViewpointRelaENS.Reason; //理由
objvgs_PViewpointRelaENT.VPProposePeople = objvgs_PViewpointRelaENS.VPProposePeople; //观点提出人
objvgs_PViewpointRelaENT.IsSubmit = objvgs_PViewpointRelaENS.IsSubmit; //是否提交
objvgs_PViewpointRelaENT.UserTypeId = objvgs_PViewpointRelaENS.UserTypeId; //用户类型Id
objvgs_PViewpointRelaENT.UserTypeName = objvgs_PViewpointRelaENS.UserTypeName; //用户类型名称
objvgs_PViewpointRelaENT.AppraiseCount = objvgs_PViewpointRelaENS.AppraiseCount; //评论数
objvgs_PViewpointRelaENT.Score = objvgs_PViewpointRelaENS.Score; //评分
objvgs_PViewpointRelaENT.StuScore = objvgs_PViewpointRelaENS.StuScore; //学生平均分
objvgs_PViewpointRelaENT.TeaScore = objvgs_PViewpointRelaENS.TeaScore; //教师评分
objvgs_PViewpointRelaENT.OkCount = objvgs_PViewpointRelaENS.OkCount; //点赞统计
objvgs_PViewpointRelaENT.CitationCount = objvgs_PViewpointRelaENS.CitationCount; //引用统计
objvgs_PViewpointRelaENT.VersionCount = objvgs_PViewpointRelaENS.VersionCount; //版本统计
objvgs_PViewpointRelaENT.ProposePeople = objvgs_PViewpointRelaENS.ProposePeople; //提出人
objvgs_PViewpointRelaENT.UpdDate = objvgs_PViewpointRelaENS.UpdDate; //修改日期
objvgs_PViewpointRelaENT.UpdUser = objvgs_PViewpointRelaENS.UpdUser; //修改人
objvgs_PViewpointRelaENT.Memo = objvgs_PViewpointRelaENS.Memo; //备注
objvgs_PViewpointRelaENT.ViewsDate = objvgs_PViewpointRelaENS.ViewsDate; //ViewsDate
objvgs_PViewpointRelaENT.ViewsUserId = objvgs_PViewpointRelaENS.ViewsUserId; //ViewsUserId
objvgs_PViewpointRelaENT.CreateDate = objvgs_PViewpointRelaENS.CreateDate; //建立日期
objvgs_PViewpointRelaENT.ShareId = objvgs_PViewpointRelaENS.ShareId; //分享Id
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
 /// <param name = "objvgs_PViewpointRelaENS">源对象</param>
 /// <returns>目标对象=>clsvgs_PViewpointRelaEN:objvgs_PViewpointRelaENT</returns>
 public static clsvgs_PViewpointRelaEN CopyTo(this clsvgs_PViewpointRelaEN objvgs_PViewpointRelaENS)
{
try
{
 clsvgs_PViewpointRelaEN objvgs_PViewpointRelaENT = new clsvgs_PViewpointRelaEN()
{
mId = objvgs_PViewpointRelaENS.mId, //mId
PaperId = objvgs_PViewpointRelaENS.PaperId, //论文Id
PaperTitle = objvgs_PViewpointRelaENS.PaperTitle, //论文标题
PaperTypeId = objvgs_PViewpointRelaENS.PaperTypeId, //论文类型Id
SectionId = objvgs_PViewpointRelaENS.SectionId, //节Id
SectionName = objvgs_PViewpointRelaENS.SectionName, //节名
ViewpointId = objvgs_PViewpointRelaENS.ViewpointId, //观点Id
ViewpointName = objvgs_PViewpointRelaENS.ViewpointName, //观点名称
ViewpointContent = objvgs_PViewpointRelaENS.ViewpointContent, //观点内容
ViewpointTypeId = objvgs_PViewpointRelaENS.ViewpointTypeId, //观点类型Id
ViewpointTypeName = objvgs_PViewpointRelaENS.ViewpointTypeName, //观点类型名
Reason = objvgs_PViewpointRelaENS.Reason, //理由
VPProposePeople = objvgs_PViewpointRelaENS.VPProposePeople, //观点提出人
IsSubmit = objvgs_PViewpointRelaENS.IsSubmit, //是否提交
UserTypeId = objvgs_PViewpointRelaENS.UserTypeId, //用户类型Id
UserTypeName = objvgs_PViewpointRelaENS.UserTypeName, //用户类型名称
AppraiseCount = objvgs_PViewpointRelaENS.AppraiseCount, //评论数
Score = objvgs_PViewpointRelaENS.Score, //评分
StuScore = objvgs_PViewpointRelaENS.StuScore, //学生平均分
TeaScore = objvgs_PViewpointRelaENS.TeaScore, //教师评分
OkCount = objvgs_PViewpointRelaENS.OkCount, //点赞统计
CitationCount = objvgs_PViewpointRelaENS.CitationCount, //引用统计
VersionCount = objvgs_PViewpointRelaENS.VersionCount, //版本统计
ProposePeople = objvgs_PViewpointRelaENS.ProposePeople, //提出人
UpdDate = objvgs_PViewpointRelaENS.UpdDate, //修改日期
UpdUser = objvgs_PViewpointRelaENS.UpdUser, //修改人
Memo = objvgs_PViewpointRelaENS.Memo, //备注
ViewsDate = objvgs_PViewpointRelaENS.ViewsDate, //ViewsDate
ViewsUserId = objvgs_PViewpointRelaENS.ViewsUserId, //ViewsUserId
CreateDate = objvgs_PViewpointRelaENS.CreateDate, //建立日期
ShareId = objvgs_PViewpointRelaENS.ShareId, //分享Id
};
 return objvgs_PViewpointRelaENT;
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
public static void CheckProperty4Condition(this clsvgs_PViewpointRelaEN objvgs_PViewpointRelaEN)
{
 clsvgs_PViewpointRelaBL.vgs_PViewpointRelaDA.CheckProperty4Condition(objvgs_PViewpointRelaEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvgs_PViewpointRelaEN objvgs_PViewpointRelaCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvgs_PViewpointRelaCond.IsUpdated(convgs_PViewpointRela.mId) == true)
{
string strComparisonOpmId = objvgs_PViewpointRelaCond.dicFldComparisonOp[convgs_PViewpointRela.mId];
strWhereCond += string.Format(" And {0} {2} {1}", convgs_PViewpointRela.mId, objvgs_PViewpointRelaCond.mId, strComparisonOpmId);
}
if (objvgs_PViewpointRelaCond.IsUpdated(convgs_PViewpointRela.PaperId) == true)
{
string strComparisonOpPaperId = objvgs_PViewpointRelaCond.dicFldComparisonOp[convgs_PViewpointRela.PaperId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convgs_PViewpointRela.PaperId, objvgs_PViewpointRelaCond.PaperId, strComparisonOpPaperId);
}
if (objvgs_PViewpointRelaCond.IsUpdated(convgs_PViewpointRela.PaperTitle) == true)
{
string strComparisonOpPaperTitle = objvgs_PViewpointRelaCond.dicFldComparisonOp[convgs_PViewpointRela.PaperTitle];
strWhereCond += string.Format(" And {0} {2} '{1}'", convgs_PViewpointRela.PaperTitle, objvgs_PViewpointRelaCond.PaperTitle, strComparisonOpPaperTitle);
}
if (objvgs_PViewpointRelaCond.IsUpdated(convgs_PViewpointRela.PaperTypeId) == true)
{
string strComparisonOpPaperTypeId = objvgs_PViewpointRelaCond.dicFldComparisonOp[convgs_PViewpointRela.PaperTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convgs_PViewpointRela.PaperTypeId, objvgs_PViewpointRelaCond.PaperTypeId, strComparisonOpPaperTypeId);
}
if (objvgs_PViewpointRelaCond.IsUpdated(convgs_PViewpointRela.SectionId) == true)
{
string strComparisonOpSectionId = objvgs_PViewpointRelaCond.dicFldComparisonOp[convgs_PViewpointRela.SectionId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convgs_PViewpointRela.SectionId, objvgs_PViewpointRelaCond.SectionId, strComparisonOpSectionId);
}
if (objvgs_PViewpointRelaCond.IsUpdated(convgs_PViewpointRela.SectionName) == true)
{
string strComparisonOpSectionName = objvgs_PViewpointRelaCond.dicFldComparisonOp[convgs_PViewpointRela.SectionName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convgs_PViewpointRela.SectionName, objvgs_PViewpointRelaCond.SectionName, strComparisonOpSectionName);
}
if (objvgs_PViewpointRelaCond.IsUpdated(convgs_PViewpointRela.ViewpointId) == true)
{
string strComparisonOpViewpointId = objvgs_PViewpointRelaCond.dicFldComparisonOp[convgs_PViewpointRela.ViewpointId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convgs_PViewpointRela.ViewpointId, objvgs_PViewpointRelaCond.ViewpointId, strComparisonOpViewpointId);
}
if (objvgs_PViewpointRelaCond.IsUpdated(convgs_PViewpointRela.ViewpointName) == true)
{
string strComparisonOpViewpointName = objvgs_PViewpointRelaCond.dicFldComparisonOp[convgs_PViewpointRela.ViewpointName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convgs_PViewpointRela.ViewpointName, objvgs_PViewpointRelaCond.ViewpointName, strComparisonOpViewpointName);
}
//数据类型string(text)在函数:[AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj]中没有处理!
if (objvgs_PViewpointRelaCond.IsUpdated(convgs_PViewpointRela.ViewpointTypeId) == true)
{
string strComparisonOpViewpointTypeId = objvgs_PViewpointRelaCond.dicFldComparisonOp[convgs_PViewpointRela.ViewpointTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convgs_PViewpointRela.ViewpointTypeId, objvgs_PViewpointRelaCond.ViewpointTypeId, strComparisonOpViewpointTypeId);
}
if (objvgs_PViewpointRelaCond.IsUpdated(convgs_PViewpointRela.ViewpointTypeName) == true)
{
string strComparisonOpViewpointTypeName = objvgs_PViewpointRelaCond.dicFldComparisonOp[convgs_PViewpointRela.ViewpointTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convgs_PViewpointRela.ViewpointTypeName, objvgs_PViewpointRelaCond.ViewpointTypeName, strComparisonOpViewpointTypeName);
}
//数据类型string(text)在函数:[AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj]中没有处理!
if (objvgs_PViewpointRelaCond.IsUpdated(convgs_PViewpointRela.VPProposePeople) == true)
{
string strComparisonOpVPProposePeople = objvgs_PViewpointRelaCond.dicFldComparisonOp[convgs_PViewpointRela.VPProposePeople];
strWhereCond += string.Format(" And {0} {2} '{1}'", convgs_PViewpointRela.VPProposePeople, objvgs_PViewpointRelaCond.VPProposePeople, strComparisonOpVPProposePeople);
}
if (objvgs_PViewpointRelaCond.IsUpdated(convgs_PViewpointRela.IsSubmit) == true)
{
if (objvgs_PViewpointRelaCond.IsSubmit == true)
{
strWhereCond += string.Format(" And {0} = '1'", convgs_PViewpointRela.IsSubmit);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convgs_PViewpointRela.IsSubmit);
}
}
if (objvgs_PViewpointRelaCond.IsUpdated(convgs_PViewpointRela.UserTypeId) == true)
{
string strComparisonOpUserTypeId = objvgs_PViewpointRelaCond.dicFldComparisonOp[convgs_PViewpointRela.UserTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convgs_PViewpointRela.UserTypeId, objvgs_PViewpointRelaCond.UserTypeId, strComparisonOpUserTypeId);
}
if (objvgs_PViewpointRelaCond.IsUpdated(convgs_PViewpointRela.UserTypeName) == true)
{
string strComparisonOpUserTypeName = objvgs_PViewpointRelaCond.dicFldComparisonOp[convgs_PViewpointRela.UserTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convgs_PViewpointRela.UserTypeName, objvgs_PViewpointRelaCond.UserTypeName, strComparisonOpUserTypeName);
}
if (objvgs_PViewpointRelaCond.IsUpdated(convgs_PViewpointRela.AppraiseCount) == true)
{
string strComparisonOpAppraiseCount = objvgs_PViewpointRelaCond.dicFldComparisonOp[convgs_PViewpointRela.AppraiseCount];
strWhereCond += string.Format(" And {0} {2} {1}", convgs_PViewpointRela.AppraiseCount, objvgs_PViewpointRelaCond.AppraiseCount, strComparisonOpAppraiseCount);
}
if (objvgs_PViewpointRelaCond.IsUpdated(convgs_PViewpointRela.Score) == true)
{
string strComparisonOpScore = objvgs_PViewpointRelaCond.dicFldComparisonOp[convgs_PViewpointRela.Score];
strWhereCond += string.Format(" And {0} {2} {1}", convgs_PViewpointRela.Score, objvgs_PViewpointRelaCond.Score, strComparisonOpScore);
}
if (objvgs_PViewpointRelaCond.IsUpdated(convgs_PViewpointRela.StuScore) == true)
{
string strComparisonOpStuScore = objvgs_PViewpointRelaCond.dicFldComparisonOp[convgs_PViewpointRela.StuScore];
strWhereCond += string.Format(" And {0} {2} {1}", convgs_PViewpointRela.StuScore, objvgs_PViewpointRelaCond.StuScore, strComparisonOpStuScore);
}
if (objvgs_PViewpointRelaCond.IsUpdated(convgs_PViewpointRela.TeaScore) == true)
{
string strComparisonOpTeaScore = objvgs_PViewpointRelaCond.dicFldComparisonOp[convgs_PViewpointRela.TeaScore];
strWhereCond += string.Format(" And {0} {2} {1}", convgs_PViewpointRela.TeaScore, objvgs_PViewpointRelaCond.TeaScore, strComparisonOpTeaScore);
}
if (objvgs_PViewpointRelaCond.IsUpdated(convgs_PViewpointRela.OkCount) == true)
{
string strComparisonOpOkCount = objvgs_PViewpointRelaCond.dicFldComparisonOp[convgs_PViewpointRela.OkCount];
strWhereCond += string.Format(" And {0} {2} {1}", convgs_PViewpointRela.OkCount, objvgs_PViewpointRelaCond.OkCount, strComparisonOpOkCount);
}
if (objvgs_PViewpointRelaCond.IsUpdated(convgs_PViewpointRela.CitationCount) == true)
{
string strComparisonOpCitationCount = objvgs_PViewpointRelaCond.dicFldComparisonOp[convgs_PViewpointRela.CitationCount];
strWhereCond += string.Format(" And {0} {2} {1}", convgs_PViewpointRela.CitationCount, objvgs_PViewpointRelaCond.CitationCount, strComparisonOpCitationCount);
}
if (objvgs_PViewpointRelaCond.IsUpdated(convgs_PViewpointRela.VersionCount) == true)
{
string strComparisonOpVersionCount = objvgs_PViewpointRelaCond.dicFldComparisonOp[convgs_PViewpointRela.VersionCount];
strWhereCond += string.Format(" And {0} {2} {1}", convgs_PViewpointRela.VersionCount, objvgs_PViewpointRelaCond.VersionCount, strComparisonOpVersionCount);
}
if (objvgs_PViewpointRelaCond.IsUpdated(convgs_PViewpointRela.ProposePeople) == true)
{
string strComparisonOpProposePeople = objvgs_PViewpointRelaCond.dicFldComparisonOp[convgs_PViewpointRela.ProposePeople];
strWhereCond += string.Format(" And {0} {2} '{1}'", convgs_PViewpointRela.ProposePeople, objvgs_PViewpointRelaCond.ProposePeople, strComparisonOpProposePeople);
}
if (objvgs_PViewpointRelaCond.IsUpdated(convgs_PViewpointRela.UpdDate) == true)
{
string strComparisonOpUpdDate = objvgs_PViewpointRelaCond.dicFldComparisonOp[convgs_PViewpointRela.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convgs_PViewpointRela.UpdDate, objvgs_PViewpointRelaCond.UpdDate, strComparisonOpUpdDate);
}
if (objvgs_PViewpointRelaCond.IsUpdated(convgs_PViewpointRela.UpdUser) == true)
{
string strComparisonOpUpdUser = objvgs_PViewpointRelaCond.dicFldComparisonOp[convgs_PViewpointRela.UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", convgs_PViewpointRela.UpdUser, objvgs_PViewpointRelaCond.UpdUser, strComparisonOpUpdUser);
}
if (objvgs_PViewpointRelaCond.IsUpdated(convgs_PViewpointRela.Memo) == true)
{
string strComparisonOpMemo = objvgs_PViewpointRelaCond.dicFldComparisonOp[convgs_PViewpointRela.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convgs_PViewpointRela.Memo, objvgs_PViewpointRelaCond.Memo, strComparisonOpMemo);
}
if (objvgs_PViewpointRelaCond.IsUpdated(convgs_PViewpointRela.ViewsDate) == true)
{
string strComparisonOpViewsDate = objvgs_PViewpointRelaCond.dicFldComparisonOp[convgs_PViewpointRela.ViewsDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convgs_PViewpointRela.ViewsDate, objvgs_PViewpointRelaCond.ViewsDate, strComparisonOpViewsDate);
}
if (objvgs_PViewpointRelaCond.IsUpdated(convgs_PViewpointRela.ViewsUserId) == true)
{
string strComparisonOpViewsUserId = objvgs_PViewpointRelaCond.dicFldComparisonOp[convgs_PViewpointRela.ViewsUserId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convgs_PViewpointRela.ViewsUserId, objvgs_PViewpointRelaCond.ViewsUserId, strComparisonOpViewsUserId);
}
if (objvgs_PViewpointRelaCond.IsUpdated(convgs_PViewpointRela.CreateDate) == true)
{
string strComparisonOpCreateDate = objvgs_PViewpointRelaCond.dicFldComparisonOp[convgs_PViewpointRela.CreateDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convgs_PViewpointRela.CreateDate, objvgs_PViewpointRelaCond.CreateDate, strComparisonOpCreateDate);
}
if (objvgs_PViewpointRelaCond.IsUpdated(convgs_PViewpointRela.ShareId) == true)
{
string strComparisonOpShareId = objvgs_PViewpointRelaCond.dicFldComparisonOp[convgs_PViewpointRela.ShareId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convgs_PViewpointRela.ShareId, objvgs_PViewpointRelaCond.ShareId, strComparisonOpShareId);
}
 return strWhereCond;
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_vgs_PViewpointRela
{
public virtual bool UpdRelaTabDate(long lngmId, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// 论文观点关系视图(vgs_PViewpointRela)
 /// 数据源类型:视图
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsvgs_PViewpointRelaBL
{
public static RelatedActions_vgs_PViewpointRela relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsvgs_PViewpointRelaDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsvgs_PViewpointRelaDA vgs_PViewpointRelaDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsvgs_PViewpointRelaDA();
}
return uniqueInstance;
}
}

 /// <summary>
 /// 类的构造函数
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ClassConstructor1)
 /// </summary>
 public clsvgs_PViewpointRelaBL()
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
if (string.IsNullOrEmpty(clsvgs_PViewpointRelaEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvgs_PViewpointRelaEN._ConnectString);
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
public static DataTable GetDataTable_vgs_PViewpointRela(string strWhereCond)
{
DataTable objDT;
try
{
objDT = vgs_PViewpointRelaDA.GetDataTable_vgs_PViewpointRela(strWhereCond);
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
objDT = vgs_PViewpointRelaDA.GetDataTable(strWhereCond);
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
objDT = vgs_PViewpointRelaDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = vgs_PViewpointRelaDA.GetDataTable(strWhereCond, strTabName);
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
objDT = vgs_PViewpointRelaDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = vgs_PViewpointRelaDA.GetDataTable_Top(objTopPara);
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
objDT = vgs_PViewpointRelaDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = vgs_PViewpointRelaDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = vgs_PViewpointRelaDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
public static List<clsvgs_PViewpointRelaEN> GetObjLstByMIdLst(List<long> arrMIdLst)
{
List<clsvgs_PViewpointRelaEN> arrObjLst = new List<clsvgs_PViewpointRelaEN>(); 
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
	clsvgs_PViewpointRelaEN objvgs_PViewpointRelaEN = new clsvgs_PViewpointRelaEN();
try
{
objvgs_PViewpointRelaEN.mId = Int32.Parse(objRow[convgs_PViewpointRela.mId].ToString().Trim()); //mId
objvgs_PViewpointRelaEN.PaperId = objRow[convgs_PViewpointRela.PaperId].ToString().Trim(); //论文Id
objvgs_PViewpointRelaEN.PaperTitle = objRow[convgs_PViewpointRela.PaperTitle] == DBNull.Value ? null : objRow[convgs_PViewpointRela.PaperTitle].ToString().Trim(); //论文标题
objvgs_PViewpointRelaEN.PaperTypeId = objRow[convgs_PViewpointRela.PaperTypeId] == DBNull.Value ? null : objRow[convgs_PViewpointRela.PaperTypeId].ToString().Trim(); //论文类型Id
objvgs_PViewpointRelaEN.SectionId = objRow[convgs_PViewpointRela.SectionId] == DBNull.Value ? null : objRow[convgs_PViewpointRela.SectionId].ToString().Trim(); //节Id
objvgs_PViewpointRelaEN.SectionName = objRow[convgs_PViewpointRela.SectionName] == DBNull.Value ? null : objRow[convgs_PViewpointRela.SectionName].ToString().Trim(); //节名
objvgs_PViewpointRelaEN.ViewpointId = objRow[convgs_PViewpointRela.ViewpointId].ToString().Trim(); //观点Id
objvgs_PViewpointRelaEN.ViewpointName = objRow[convgs_PViewpointRela.ViewpointName] == DBNull.Value ? null : objRow[convgs_PViewpointRela.ViewpointName].ToString().Trim(); //观点名称
objvgs_PViewpointRelaEN.ViewpointContent = objRow[convgs_PViewpointRela.ViewpointContent] == DBNull.Value ? null : objRow[convgs_PViewpointRela.ViewpointContent].ToString().Trim(); //观点内容
objvgs_PViewpointRelaEN.ViewpointTypeId = objRow[convgs_PViewpointRela.ViewpointTypeId] == DBNull.Value ? null : objRow[convgs_PViewpointRela.ViewpointTypeId].ToString().Trim(); //观点类型Id
objvgs_PViewpointRelaEN.ViewpointTypeName = objRow[convgs_PViewpointRela.ViewpointTypeName] == DBNull.Value ? null : objRow[convgs_PViewpointRela.ViewpointTypeName].ToString().Trim(); //观点类型名
objvgs_PViewpointRelaEN.Reason = objRow[convgs_PViewpointRela.Reason] == DBNull.Value ? null : objRow[convgs_PViewpointRela.Reason].ToString().Trim(); //理由
objvgs_PViewpointRelaEN.VPProposePeople = objRow[convgs_PViewpointRela.VPProposePeople] == DBNull.Value ? null : objRow[convgs_PViewpointRela.VPProposePeople].ToString().Trim(); //观点提出人
objvgs_PViewpointRelaEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[convgs_PViewpointRela.IsSubmit].ToString().Trim()); //是否提交
objvgs_PViewpointRelaEN.UserTypeId = objRow[convgs_PViewpointRela.UserTypeId] == DBNull.Value ? null : objRow[convgs_PViewpointRela.UserTypeId].ToString().Trim(); //用户类型Id
objvgs_PViewpointRelaEN.UserTypeName = objRow[convgs_PViewpointRela.UserTypeName] == DBNull.Value ? null : objRow[convgs_PViewpointRela.UserTypeName].ToString().Trim(); //用户类型名称
objvgs_PViewpointRelaEN.AppraiseCount = objRow[convgs_PViewpointRela.AppraiseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convgs_PViewpointRela.AppraiseCount].ToString().Trim()); //评论数
objvgs_PViewpointRelaEN.Score = objRow[convgs_PViewpointRela.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convgs_PViewpointRela.Score].ToString().Trim()); //评分
objvgs_PViewpointRelaEN.StuScore = objRow[convgs_PViewpointRela.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convgs_PViewpointRela.StuScore].ToString().Trim()); //学生平均分
objvgs_PViewpointRelaEN.TeaScore = objRow[convgs_PViewpointRela.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convgs_PViewpointRela.TeaScore].ToString().Trim()); //教师评分
objvgs_PViewpointRelaEN.OkCount = objRow[convgs_PViewpointRela.OkCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convgs_PViewpointRela.OkCount].ToString().Trim()); //点赞统计
objvgs_PViewpointRelaEN.CitationCount = objRow[convgs_PViewpointRela.CitationCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convgs_PViewpointRela.CitationCount].ToString().Trim()); //引用统计
objvgs_PViewpointRelaEN.VersionCount = objRow[convgs_PViewpointRela.VersionCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convgs_PViewpointRela.VersionCount].ToString().Trim()); //版本统计
objvgs_PViewpointRelaEN.ProposePeople = objRow[convgs_PViewpointRela.ProposePeople] == DBNull.Value ? null : objRow[convgs_PViewpointRela.ProposePeople].ToString().Trim(); //提出人
objvgs_PViewpointRelaEN.UpdDate = objRow[convgs_PViewpointRela.UpdDate] == DBNull.Value ? null : objRow[convgs_PViewpointRela.UpdDate].ToString().Trim(); //修改日期
objvgs_PViewpointRelaEN.UpdUser = objRow[convgs_PViewpointRela.UpdUser] == DBNull.Value ? null : objRow[convgs_PViewpointRela.UpdUser].ToString().Trim(); //修改人
objvgs_PViewpointRelaEN.Memo = objRow[convgs_PViewpointRela.Memo] == DBNull.Value ? null : objRow[convgs_PViewpointRela.Memo].ToString().Trim(); //备注
objvgs_PViewpointRelaEN.ViewsDate = objRow[convgs_PViewpointRela.ViewsDate] == DBNull.Value ? null : objRow[convgs_PViewpointRela.ViewsDate].ToString().Trim(); //ViewsDate
objvgs_PViewpointRelaEN.ViewsUserId = objRow[convgs_PViewpointRela.ViewsUserId] == DBNull.Value ? null : objRow[convgs_PViewpointRela.ViewsUserId].ToString().Trim(); //ViewsUserId
objvgs_PViewpointRelaEN.CreateDate = objRow[convgs_PViewpointRela.CreateDate] == DBNull.Value ? null : objRow[convgs_PViewpointRela.CreateDate].ToString().Trim(); //建立日期
objvgs_PViewpointRelaEN.ShareId = objRow[convgs_PViewpointRela.ShareId] == DBNull.Value ? null : objRow[convgs_PViewpointRela.ShareId].ToString().Trim(); //分享Id
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvgs_PViewpointRelaEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvgs_PViewpointRelaEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrMIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsvgs_PViewpointRelaEN> GetObjLstByMIdLstCache(List<long> arrMIdLst)
{
string strKey = string.Format("{0}", clsvgs_PViewpointRelaEN._CurrTabName);
List<clsvgs_PViewpointRelaEN> arrvgs_PViewpointRelaObjLstCache = GetObjLstCache();
IEnumerable <clsvgs_PViewpointRelaEN> arrvgs_PViewpointRelaObjLst_Sel =
arrvgs_PViewpointRelaObjLstCache
.Where(x => arrMIdLst.Contains(x.mId));
return arrvgs_PViewpointRelaObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvgs_PViewpointRelaEN> GetObjLst(string strWhereCond)
{
List<clsvgs_PViewpointRelaEN> arrObjLst = new List<clsvgs_PViewpointRelaEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvgs_PViewpointRelaEN objvgs_PViewpointRelaEN = new clsvgs_PViewpointRelaEN();
try
{
objvgs_PViewpointRelaEN.mId = Int32.Parse(objRow[convgs_PViewpointRela.mId].ToString().Trim()); //mId
objvgs_PViewpointRelaEN.PaperId = objRow[convgs_PViewpointRela.PaperId].ToString().Trim(); //论文Id
objvgs_PViewpointRelaEN.PaperTitle = objRow[convgs_PViewpointRela.PaperTitle] == DBNull.Value ? null : objRow[convgs_PViewpointRela.PaperTitle].ToString().Trim(); //论文标题
objvgs_PViewpointRelaEN.PaperTypeId = objRow[convgs_PViewpointRela.PaperTypeId] == DBNull.Value ? null : objRow[convgs_PViewpointRela.PaperTypeId].ToString().Trim(); //论文类型Id
objvgs_PViewpointRelaEN.SectionId = objRow[convgs_PViewpointRela.SectionId] == DBNull.Value ? null : objRow[convgs_PViewpointRela.SectionId].ToString().Trim(); //节Id
objvgs_PViewpointRelaEN.SectionName = objRow[convgs_PViewpointRela.SectionName] == DBNull.Value ? null : objRow[convgs_PViewpointRela.SectionName].ToString().Trim(); //节名
objvgs_PViewpointRelaEN.ViewpointId = objRow[convgs_PViewpointRela.ViewpointId].ToString().Trim(); //观点Id
objvgs_PViewpointRelaEN.ViewpointName = objRow[convgs_PViewpointRela.ViewpointName] == DBNull.Value ? null : objRow[convgs_PViewpointRela.ViewpointName].ToString().Trim(); //观点名称
objvgs_PViewpointRelaEN.ViewpointContent = objRow[convgs_PViewpointRela.ViewpointContent] == DBNull.Value ? null : objRow[convgs_PViewpointRela.ViewpointContent].ToString().Trim(); //观点内容
objvgs_PViewpointRelaEN.ViewpointTypeId = objRow[convgs_PViewpointRela.ViewpointTypeId] == DBNull.Value ? null : objRow[convgs_PViewpointRela.ViewpointTypeId].ToString().Trim(); //观点类型Id
objvgs_PViewpointRelaEN.ViewpointTypeName = objRow[convgs_PViewpointRela.ViewpointTypeName] == DBNull.Value ? null : objRow[convgs_PViewpointRela.ViewpointTypeName].ToString().Trim(); //观点类型名
objvgs_PViewpointRelaEN.Reason = objRow[convgs_PViewpointRela.Reason] == DBNull.Value ? null : objRow[convgs_PViewpointRela.Reason].ToString().Trim(); //理由
objvgs_PViewpointRelaEN.VPProposePeople = objRow[convgs_PViewpointRela.VPProposePeople] == DBNull.Value ? null : objRow[convgs_PViewpointRela.VPProposePeople].ToString().Trim(); //观点提出人
objvgs_PViewpointRelaEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[convgs_PViewpointRela.IsSubmit].ToString().Trim()); //是否提交
objvgs_PViewpointRelaEN.UserTypeId = objRow[convgs_PViewpointRela.UserTypeId] == DBNull.Value ? null : objRow[convgs_PViewpointRela.UserTypeId].ToString().Trim(); //用户类型Id
objvgs_PViewpointRelaEN.UserTypeName = objRow[convgs_PViewpointRela.UserTypeName] == DBNull.Value ? null : objRow[convgs_PViewpointRela.UserTypeName].ToString().Trim(); //用户类型名称
objvgs_PViewpointRelaEN.AppraiseCount = objRow[convgs_PViewpointRela.AppraiseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convgs_PViewpointRela.AppraiseCount].ToString().Trim()); //评论数
objvgs_PViewpointRelaEN.Score = objRow[convgs_PViewpointRela.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convgs_PViewpointRela.Score].ToString().Trim()); //评分
objvgs_PViewpointRelaEN.StuScore = objRow[convgs_PViewpointRela.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convgs_PViewpointRela.StuScore].ToString().Trim()); //学生平均分
objvgs_PViewpointRelaEN.TeaScore = objRow[convgs_PViewpointRela.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convgs_PViewpointRela.TeaScore].ToString().Trim()); //教师评分
objvgs_PViewpointRelaEN.OkCount = objRow[convgs_PViewpointRela.OkCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convgs_PViewpointRela.OkCount].ToString().Trim()); //点赞统计
objvgs_PViewpointRelaEN.CitationCount = objRow[convgs_PViewpointRela.CitationCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convgs_PViewpointRela.CitationCount].ToString().Trim()); //引用统计
objvgs_PViewpointRelaEN.VersionCount = objRow[convgs_PViewpointRela.VersionCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convgs_PViewpointRela.VersionCount].ToString().Trim()); //版本统计
objvgs_PViewpointRelaEN.ProposePeople = objRow[convgs_PViewpointRela.ProposePeople] == DBNull.Value ? null : objRow[convgs_PViewpointRela.ProposePeople].ToString().Trim(); //提出人
objvgs_PViewpointRelaEN.UpdDate = objRow[convgs_PViewpointRela.UpdDate] == DBNull.Value ? null : objRow[convgs_PViewpointRela.UpdDate].ToString().Trim(); //修改日期
objvgs_PViewpointRelaEN.UpdUser = objRow[convgs_PViewpointRela.UpdUser] == DBNull.Value ? null : objRow[convgs_PViewpointRela.UpdUser].ToString().Trim(); //修改人
objvgs_PViewpointRelaEN.Memo = objRow[convgs_PViewpointRela.Memo] == DBNull.Value ? null : objRow[convgs_PViewpointRela.Memo].ToString().Trim(); //备注
objvgs_PViewpointRelaEN.ViewsDate = objRow[convgs_PViewpointRela.ViewsDate] == DBNull.Value ? null : objRow[convgs_PViewpointRela.ViewsDate].ToString().Trim(); //ViewsDate
objvgs_PViewpointRelaEN.ViewsUserId = objRow[convgs_PViewpointRela.ViewsUserId] == DBNull.Value ? null : objRow[convgs_PViewpointRela.ViewsUserId].ToString().Trim(); //ViewsUserId
objvgs_PViewpointRelaEN.CreateDate = objRow[convgs_PViewpointRela.CreateDate] == DBNull.Value ? null : objRow[convgs_PViewpointRela.CreateDate].ToString().Trim(); //建立日期
objvgs_PViewpointRelaEN.ShareId = objRow[convgs_PViewpointRela.ShareId] == DBNull.Value ? null : objRow[convgs_PViewpointRela.ShareId].ToString().Trim(); //分享Id
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvgs_PViewpointRelaEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvgs_PViewpointRelaEN);
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
public static List<clsvgs_PViewpointRelaEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsvgs_PViewpointRelaEN> arrObjLst = new List<clsvgs_PViewpointRelaEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvgs_PViewpointRelaEN objvgs_PViewpointRelaEN = new clsvgs_PViewpointRelaEN();
try
{
objvgs_PViewpointRelaEN.mId = Int32.Parse(objRow[convgs_PViewpointRela.mId].ToString().Trim()); //mId
objvgs_PViewpointRelaEN.PaperId = objRow[convgs_PViewpointRela.PaperId].ToString().Trim(); //论文Id
objvgs_PViewpointRelaEN.PaperTitle = objRow[convgs_PViewpointRela.PaperTitle] == DBNull.Value ? null : objRow[convgs_PViewpointRela.PaperTitle].ToString().Trim(); //论文标题
objvgs_PViewpointRelaEN.PaperTypeId = objRow[convgs_PViewpointRela.PaperTypeId] == DBNull.Value ? null : objRow[convgs_PViewpointRela.PaperTypeId].ToString().Trim(); //论文类型Id
objvgs_PViewpointRelaEN.SectionId = objRow[convgs_PViewpointRela.SectionId] == DBNull.Value ? null : objRow[convgs_PViewpointRela.SectionId].ToString().Trim(); //节Id
objvgs_PViewpointRelaEN.SectionName = objRow[convgs_PViewpointRela.SectionName] == DBNull.Value ? null : objRow[convgs_PViewpointRela.SectionName].ToString().Trim(); //节名
objvgs_PViewpointRelaEN.ViewpointId = objRow[convgs_PViewpointRela.ViewpointId].ToString().Trim(); //观点Id
objvgs_PViewpointRelaEN.ViewpointName = objRow[convgs_PViewpointRela.ViewpointName] == DBNull.Value ? null : objRow[convgs_PViewpointRela.ViewpointName].ToString().Trim(); //观点名称
objvgs_PViewpointRelaEN.ViewpointContent = objRow[convgs_PViewpointRela.ViewpointContent] == DBNull.Value ? null : objRow[convgs_PViewpointRela.ViewpointContent].ToString().Trim(); //观点内容
objvgs_PViewpointRelaEN.ViewpointTypeId = objRow[convgs_PViewpointRela.ViewpointTypeId] == DBNull.Value ? null : objRow[convgs_PViewpointRela.ViewpointTypeId].ToString().Trim(); //观点类型Id
objvgs_PViewpointRelaEN.ViewpointTypeName = objRow[convgs_PViewpointRela.ViewpointTypeName] == DBNull.Value ? null : objRow[convgs_PViewpointRela.ViewpointTypeName].ToString().Trim(); //观点类型名
objvgs_PViewpointRelaEN.Reason = objRow[convgs_PViewpointRela.Reason] == DBNull.Value ? null : objRow[convgs_PViewpointRela.Reason].ToString().Trim(); //理由
objvgs_PViewpointRelaEN.VPProposePeople = objRow[convgs_PViewpointRela.VPProposePeople] == DBNull.Value ? null : objRow[convgs_PViewpointRela.VPProposePeople].ToString().Trim(); //观点提出人
objvgs_PViewpointRelaEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[convgs_PViewpointRela.IsSubmit].ToString().Trim()); //是否提交
objvgs_PViewpointRelaEN.UserTypeId = objRow[convgs_PViewpointRela.UserTypeId] == DBNull.Value ? null : objRow[convgs_PViewpointRela.UserTypeId].ToString().Trim(); //用户类型Id
objvgs_PViewpointRelaEN.UserTypeName = objRow[convgs_PViewpointRela.UserTypeName] == DBNull.Value ? null : objRow[convgs_PViewpointRela.UserTypeName].ToString().Trim(); //用户类型名称
objvgs_PViewpointRelaEN.AppraiseCount = objRow[convgs_PViewpointRela.AppraiseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convgs_PViewpointRela.AppraiseCount].ToString().Trim()); //评论数
objvgs_PViewpointRelaEN.Score = objRow[convgs_PViewpointRela.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convgs_PViewpointRela.Score].ToString().Trim()); //评分
objvgs_PViewpointRelaEN.StuScore = objRow[convgs_PViewpointRela.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convgs_PViewpointRela.StuScore].ToString().Trim()); //学生平均分
objvgs_PViewpointRelaEN.TeaScore = objRow[convgs_PViewpointRela.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convgs_PViewpointRela.TeaScore].ToString().Trim()); //教师评分
objvgs_PViewpointRelaEN.OkCount = objRow[convgs_PViewpointRela.OkCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convgs_PViewpointRela.OkCount].ToString().Trim()); //点赞统计
objvgs_PViewpointRelaEN.CitationCount = objRow[convgs_PViewpointRela.CitationCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convgs_PViewpointRela.CitationCount].ToString().Trim()); //引用统计
objvgs_PViewpointRelaEN.VersionCount = objRow[convgs_PViewpointRela.VersionCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convgs_PViewpointRela.VersionCount].ToString().Trim()); //版本统计
objvgs_PViewpointRelaEN.ProposePeople = objRow[convgs_PViewpointRela.ProposePeople] == DBNull.Value ? null : objRow[convgs_PViewpointRela.ProposePeople].ToString().Trim(); //提出人
objvgs_PViewpointRelaEN.UpdDate = objRow[convgs_PViewpointRela.UpdDate] == DBNull.Value ? null : objRow[convgs_PViewpointRela.UpdDate].ToString().Trim(); //修改日期
objvgs_PViewpointRelaEN.UpdUser = objRow[convgs_PViewpointRela.UpdUser] == DBNull.Value ? null : objRow[convgs_PViewpointRela.UpdUser].ToString().Trim(); //修改人
objvgs_PViewpointRelaEN.Memo = objRow[convgs_PViewpointRela.Memo] == DBNull.Value ? null : objRow[convgs_PViewpointRela.Memo].ToString().Trim(); //备注
objvgs_PViewpointRelaEN.ViewsDate = objRow[convgs_PViewpointRela.ViewsDate] == DBNull.Value ? null : objRow[convgs_PViewpointRela.ViewsDate].ToString().Trim(); //ViewsDate
objvgs_PViewpointRelaEN.ViewsUserId = objRow[convgs_PViewpointRela.ViewsUserId] == DBNull.Value ? null : objRow[convgs_PViewpointRela.ViewsUserId].ToString().Trim(); //ViewsUserId
objvgs_PViewpointRelaEN.CreateDate = objRow[convgs_PViewpointRela.CreateDate] == DBNull.Value ? null : objRow[convgs_PViewpointRela.CreateDate].ToString().Trim(); //建立日期
objvgs_PViewpointRelaEN.ShareId = objRow[convgs_PViewpointRela.ShareId] == DBNull.Value ? null : objRow[convgs_PViewpointRela.ShareId].ToString().Trim(); //分享Id
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvgs_PViewpointRelaEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvgs_PViewpointRelaEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objvgs_PViewpointRelaCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsvgs_PViewpointRelaEN> GetSubObjLstCache(clsvgs_PViewpointRelaEN objvgs_PViewpointRelaCond)
{
List<clsvgs_PViewpointRelaEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsvgs_PViewpointRelaEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convgs_PViewpointRela.AttributeName)
{
if (objvgs_PViewpointRelaCond.IsUpdated(strFldName) == false) continue;
if (objvgs_PViewpointRelaCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvgs_PViewpointRelaCond[strFldName].ToString());
}
else
{
if (objvgs_PViewpointRelaCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvgs_PViewpointRelaCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvgs_PViewpointRelaCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvgs_PViewpointRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvgs_PViewpointRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvgs_PViewpointRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvgs_PViewpointRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvgs_PViewpointRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvgs_PViewpointRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvgs_PViewpointRelaCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvgs_PViewpointRelaCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvgs_PViewpointRelaCond[strFldName]));
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
public static List<clsvgs_PViewpointRelaEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsvgs_PViewpointRelaEN> arrObjLst = new List<clsvgs_PViewpointRelaEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvgs_PViewpointRelaEN objvgs_PViewpointRelaEN = new clsvgs_PViewpointRelaEN();
try
{
objvgs_PViewpointRelaEN.mId = Int32.Parse(objRow[convgs_PViewpointRela.mId].ToString().Trim()); //mId
objvgs_PViewpointRelaEN.PaperId = objRow[convgs_PViewpointRela.PaperId].ToString().Trim(); //论文Id
objvgs_PViewpointRelaEN.PaperTitle = objRow[convgs_PViewpointRela.PaperTitle] == DBNull.Value ? null : objRow[convgs_PViewpointRela.PaperTitle].ToString().Trim(); //论文标题
objvgs_PViewpointRelaEN.PaperTypeId = objRow[convgs_PViewpointRela.PaperTypeId] == DBNull.Value ? null : objRow[convgs_PViewpointRela.PaperTypeId].ToString().Trim(); //论文类型Id
objvgs_PViewpointRelaEN.SectionId = objRow[convgs_PViewpointRela.SectionId] == DBNull.Value ? null : objRow[convgs_PViewpointRela.SectionId].ToString().Trim(); //节Id
objvgs_PViewpointRelaEN.SectionName = objRow[convgs_PViewpointRela.SectionName] == DBNull.Value ? null : objRow[convgs_PViewpointRela.SectionName].ToString().Trim(); //节名
objvgs_PViewpointRelaEN.ViewpointId = objRow[convgs_PViewpointRela.ViewpointId].ToString().Trim(); //观点Id
objvgs_PViewpointRelaEN.ViewpointName = objRow[convgs_PViewpointRela.ViewpointName] == DBNull.Value ? null : objRow[convgs_PViewpointRela.ViewpointName].ToString().Trim(); //观点名称
objvgs_PViewpointRelaEN.ViewpointContent = objRow[convgs_PViewpointRela.ViewpointContent] == DBNull.Value ? null : objRow[convgs_PViewpointRela.ViewpointContent].ToString().Trim(); //观点内容
objvgs_PViewpointRelaEN.ViewpointTypeId = objRow[convgs_PViewpointRela.ViewpointTypeId] == DBNull.Value ? null : objRow[convgs_PViewpointRela.ViewpointTypeId].ToString().Trim(); //观点类型Id
objvgs_PViewpointRelaEN.ViewpointTypeName = objRow[convgs_PViewpointRela.ViewpointTypeName] == DBNull.Value ? null : objRow[convgs_PViewpointRela.ViewpointTypeName].ToString().Trim(); //观点类型名
objvgs_PViewpointRelaEN.Reason = objRow[convgs_PViewpointRela.Reason] == DBNull.Value ? null : objRow[convgs_PViewpointRela.Reason].ToString().Trim(); //理由
objvgs_PViewpointRelaEN.VPProposePeople = objRow[convgs_PViewpointRela.VPProposePeople] == DBNull.Value ? null : objRow[convgs_PViewpointRela.VPProposePeople].ToString().Trim(); //观点提出人
objvgs_PViewpointRelaEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[convgs_PViewpointRela.IsSubmit].ToString().Trim()); //是否提交
objvgs_PViewpointRelaEN.UserTypeId = objRow[convgs_PViewpointRela.UserTypeId] == DBNull.Value ? null : objRow[convgs_PViewpointRela.UserTypeId].ToString().Trim(); //用户类型Id
objvgs_PViewpointRelaEN.UserTypeName = objRow[convgs_PViewpointRela.UserTypeName] == DBNull.Value ? null : objRow[convgs_PViewpointRela.UserTypeName].ToString().Trim(); //用户类型名称
objvgs_PViewpointRelaEN.AppraiseCount = objRow[convgs_PViewpointRela.AppraiseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convgs_PViewpointRela.AppraiseCount].ToString().Trim()); //评论数
objvgs_PViewpointRelaEN.Score = objRow[convgs_PViewpointRela.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convgs_PViewpointRela.Score].ToString().Trim()); //评分
objvgs_PViewpointRelaEN.StuScore = objRow[convgs_PViewpointRela.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convgs_PViewpointRela.StuScore].ToString().Trim()); //学生平均分
objvgs_PViewpointRelaEN.TeaScore = objRow[convgs_PViewpointRela.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convgs_PViewpointRela.TeaScore].ToString().Trim()); //教师评分
objvgs_PViewpointRelaEN.OkCount = objRow[convgs_PViewpointRela.OkCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convgs_PViewpointRela.OkCount].ToString().Trim()); //点赞统计
objvgs_PViewpointRelaEN.CitationCount = objRow[convgs_PViewpointRela.CitationCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convgs_PViewpointRela.CitationCount].ToString().Trim()); //引用统计
objvgs_PViewpointRelaEN.VersionCount = objRow[convgs_PViewpointRela.VersionCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convgs_PViewpointRela.VersionCount].ToString().Trim()); //版本统计
objvgs_PViewpointRelaEN.ProposePeople = objRow[convgs_PViewpointRela.ProposePeople] == DBNull.Value ? null : objRow[convgs_PViewpointRela.ProposePeople].ToString().Trim(); //提出人
objvgs_PViewpointRelaEN.UpdDate = objRow[convgs_PViewpointRela.UpdDate] == DBNull.Value ? null : objRow[convgs_PViewpointRela.UpdDate].ToString().Trim(); //修改日期
objvgs_PViewpointRelaEN.UpdUser = objRow[convgs_PViewpointRela.UpdUser] == DBNull.Value ? null : objRow[convgs_PViewpointRela.UpdUser].ToString().Trim(); //修改人
objvgs_PViewpointRelaEN.Memo = objRow[convgs_PViewpointRela.Memo] == DBNull.Value ? null : objRow[convgs_PViewpointRela.Memo].ToString().Trim(); //备注
objvgs_PViewpointRelaEN.ViewsDate = objRow[convgs_PViewpointRela.ViewsDate] == DBNull.Value ? null : objRow[convgs_PViewpointRela.ViewsDate].ToString().Trim(); //ViewsDate
objvgs_PViewpointRelaEN.ViewsUserId = objRow[convgs_PViewpointRela.ViewsUserId] == DBNull.Value ? null : objRow[convgs_PViewpointRela.ViewsUserId].ToString().Trim(); //ViewsUserId
objvgs_PViewpointRelaEN.CreateDate = objRow[convgs_PViewpointRela.CreateDate] == DBNull.Value ? null : objRow[convgs_PViewpointRela.CreateDate].ToString().Trim(); //建立日期
objvgs_PViewpointRelaEN.ShareId = objRow[convgs_PViewpointRela.ShareId] == DBNull.Value ? null : objRow[convgs_PViewpointRela.ShareId].ToString().Trim(); //分享Id
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvgs_PViewpointRelaEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvgs_PViewpointRelaEN);
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
public static List<clsvgs_PViewpointRelaEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsvgs_PViewpointRelaEN> arrObjLst = new List<clsvgs_PViewpointRelaEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvgs_PViewpointRelaEN objvgs_PViewpointRelaEN = new clsvgs_PViewpointRelaEN();
try
{
objvgs_PViewpointRelaEN.mId = Int32.Parse(objRow[convgs_PViewpointRela.mId].ToString().Trim()); //mId
objvgs_PViewpointRelaEN.PaperId = objRow[convgs_PViewpointRela.PaperId].ToString().Trim(); //论文Id
objvgs_PViewpointRelaEN.PaperTitle = objRow[convgs_PViewpointRela.PaperTitle] == DBNull.Value ? null : objRow[convgs_PViewpointRela.PaperTitle].ToString().Trim(); //论文标题
objvgs_PViewpointRelaEN.PaperTypeId = objRow[convgs_PViewpointRela.PaperTypeId] == DBNull.Value ? null : objRow[convgs_PViewpointRela.PaperTypeId].ToString().Trim(); //论文类型Id
objvgs_PViewpointRelaEN.SectionId = objRow[convgs_PViewpointRela.SectionId] == DBNull.Value ? null : objRow[convgs_PViewpointRela.SectionId].ToString().Trim(); //节Id
objvgs_PViewpointRelaEN.SectionName = objRow[convgs_PViewpointRela.SectionName] == DBNull.Value ? null : objRow[convgs_PViewpointRela.SectionName].ToString().Trim(); //节名
objvgs_PViewpointRelaEN.ViewpointId = objRow[convgs_PViewpointRela.ViewpointId].ToString().Trim(); //观点Id
objvgs_PViewpointRelaEN.ViewpointName = objRow[convgs_PViewpointRela.ViewpointName] == DBNull.Value ? null : objRow[convgs_PViewpointRela.ViewpointName].ToString().Trim(); //观点名称
objvgs_PViewpointRelaEN.ViewpointContent = objRow[convgs_PViewpointRela.ViewpointContent] == DBNull.Value ? null : objRow[convgs_PViewpointRela.ViewpointContent].ToString().Trim(); //观点内容
objvgs_PViewpointRelaEN.ViewpointTypeId = objRow[convgs_PViewpointRela.ViewpointTypeId] == DBNull.Value ? null : objRow[convgs_PViewpointRela.ViewpointTypeId].ToString().Trim(); //观点类型Id
objvgs_PViewpointRelaEN.ViewpointTypeName = objRow[convgs_PViewpointRela.ViewpointTypeName] == DBNull.Value ? null : objRow[convgs_PViewpointRela.ViewpointTypeName].ToString().Trim(); //观点类型名
objvgs_PViewpointRelaEN.Reason = objRow[convgs_PViewpointRela.Reason] == DBNull.Value ? null : objRow[convgs_PViewpointRela.Reason].ToString().Trim(); //理由
objvgs_PViewpointRelaEN.VPProposePeople = objRow[convgs_PViewpointRela.VPProposePeople] == DBNull.Value ? null : objRow[convgs_PViewpointRela.VPProposePeople].ToString().Trim(); //观点提出人
objvgs_PViewpointRelaEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[convgs_PViewpointRela.IsSubmit].ToString().Trim()); //是否提交
objvgs_PViewpointRelaEN.UserTypeId = objRow[convgs_PViewpointRela.UserTypeId] == DBNull.Value ? null : objRow[convgs_PViewpointRela.UserTypeId].ToString().Trim(); //用户类型Id
objvgs_PViewpointRelaEN.UserTypeName = objRow[convgs_PViewpointRela.UserTypeName] == DBNull.Value ? null : objRow[convgs_PViewpointRela.UserTypeName].ToString().Trim(); //用户类型名称
objvgs_PViewpointRelaEN.AppraiseCount = objRow[convgs_PViewpointRela.AppraiseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convgs_PViewpointRela.AppraiseCount].ToString().Trim()); //评论数
objvgs_PViewpointRelaEN.Score = objRow[convgs_PViewpointRela.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convgs_PViewpointRela.Score].ToString().Trim()); //评分
objvgs_PViewpointRelaEN.StuScore = objRow[convgs_PViewpointRela.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convgs_PViewpointRela.StuScore].ToString().Trim()); //学生平均分
objvgs_PViewpointRelaEN.TeaScore = objRow[convgs_PViewpointRela.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convgs_PViewpointRela.TeaScore].ToString().Trim()); //教师评分
objvgs_PViewpointRelaEN.OkCount = objRow[convgs_PViewpointRela.OkCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convgs_PViewpointRela.OkCount].ToString().Trim()); //点赞统计
objvgs_PViewpointRelaEN.CitationCount = objRow[convgs_PViewpointRela.CitationCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convgs_PViewpointRela.CitationCount].ToString().Trim()); //引用统计
objvgs_PViewpointRelaEN.VersionCount = objRow[convgs_PViewpointRela.VersionCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convgs_PViewpointRela.VersionCount].ToString().Trim()); //版本统计
objvgs_PViewpointRelaEN.ProposePeople = objRow[convgs_PViewpointRela.ProposePeople] == DBNull.Value ? null : objRow[convgs_PViewpointRela.ProposePeople].ToString().Trim(); //提出人
objvgs_PViewpointRelaEN.UpdDate = objRow[convgs_PViewpointRela.UpdDate] == DBNull.Value ? null : objRow[convgs_PViewpointRela.UpdDate].ToString().Trim(); //修改日期
objvgs_PViewpointRelaEN.UpdUser = objRow[convgs_PViewpointRela.UpdUser] == DBNull.Value ? null : objRow[convgs_PViewpointRela.UpdUser].ToString().Trim(); //修改人
objvgs_PViewpointRelaEN.Memo = objRow[convgs_PViewpointRela.Memo] == DBNull.Value ? null : objRow[convgs_PViewpointRela.Memo].ToString().Trim(); //备注
objvgs_PViewpointRelaEN.ViewsDate = objRow[convgs_PViewpointRela.ViewsDate] == DBNull.Value ? null : objRow[convgs_PViewpointRela.ViewsDate].ToString().Trim(); //ViewsDate
objvgs_PViewpointRelaEN.ViewsUserId = objRow[convgs_PViewpointRela.ViewsUserId] == DBNull.Value ? null : objRow[convgs_PViewpointRela.ViewsUserId].ToString().Trim(); //ViewsUserId
objvgs_PViewpointRelaEN.CreateDate = objRow[convgs_PViewpointRela.CreateDate] == DBNull.Value ? null : objRow[convgs_PViewpointRela.CreateDate].ToString().Trim(); //建立日期
objvgs_PViewpointRelaEN.ShareId = objRow[convgs_PViewpointRela.ShareId] == DBNull.Value ? null : objRow[convgs_PViewpointRela.ShareId].ToString().Trim(); //分享Id
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvgs_PViewpointRelaEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvgs_PViewpointRelaEN);
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
List<clsvgs_PViewpointRelaEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsvgs_PViewpointRelaEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsvgs_PViewpointRelaEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsvgs_PViewpointRelaEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsvgs_PViewpointRelaEN> arrObjLst = new List<clsvgs_PViewpointRelaEN>(); 
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
	clsvgs_PViewpointRelaEN objvgs_PViewpointRelaEN = new clsvgs_PViewpointRelaEN();
try
{
objvgs_PViewpointRelaEN.mId = Int32.Parse(objRow[convgs_PViewpointRela.mId].ToString().Trim()); //mId
objvgs_PViewpointRelaEN.PaperId = objRow[convgs_PViewpointRela.PaperId].ToString().Trim(); //论文Id
objvgs_PViewpointRelaEN.PaperTitle = objRow[convgs_PViewpointRela.PaperTitle] == DBNull.Value ? null : objRow[convgs_PViewpointRela.PaperTitle].ToString().Trim(); //论文标题
objvgs_PViewpointRelaEN.PaperTypeId = objRow[convgs_PViewpointRela.PaperTypeId] == DBNull.Value ? null : objRow[convgs_PViewpointRela.PaperTypeId].ToString().Trim(); //论文类型Id
objvgs_PViewpointRelaEN.SectionId = objRow[convgs_PViewpointRela.SectionId] == DBNull.Value ? null : objRow[convgs_PViewpointRela.SectionId].ToString().Trim(); //节Id
objvgs_PViewpointRelaEN.SectionName = objRow[convgs_PViewpointRela.SectionName] == DBNull.Value ? null : objRow[convgs_PViewpointRela.SectionName].ToString().Trim(); //节名
objvgs_PViewpointRelaEN.ViewpointId = objRow[convgs_PViewpointRela.ViewpointId].ToString().Trim(); //观点Id
objvgs_PViewpointRelaEN.ViewpointName = objRow[convgs_PViewpointRela.ViewpointName] == DBNull.Value ? null : objRow[convgs_PViewpointRela.ViewpointName].ToString().Trim(); //观点名称
objvgs_PViewpointRelaEN.ViewpointContent = objRow[convgs_PViewpointRela.ViewpointContent] == DBNull.Value ? null : objRow[convgs_PViewpointRela.ViewpointContent].ToString().Trim(); //观点内容
objvgs_PViewpointRelaEN.ViewpointTypeId = objRow[convgs_PViewpointRela.ViewpointTypeId] == DBNull.Value ? null : objRow[convgs_PViewpointRela.ViewpointTypeId].ToString().Trim(); //观点类型Id
objvgs_PViewpointRelaEN.ViewpointTypeName = objRow[convgs_PViewpointRela.ViewpointTypeName] == DBNull.Value ? null : objRow[convgs_PViewpointRela.ViewpointTypeName].ToString().Trim(); //观点类型名
objvgs_PViewpointRelaEN.Reason = objRow[convgs_PViewpointRela.Reason] == DBNull.Value ? null : objRow[convgs_PViewpointRela.Reason].ToString().Trim(); //理由
objvgs_PViewpointRelaEN.VPProposePeople = objRow[convgs_PViewpointRela.VPProposePeople] == DBNull.Value ? null : objRow[convgs_PViewpointRela.VPProposePeople].ToString().Trim(); //观点提出人
objvgs_PViewpointRelaEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[convgs_PViewpointRela.IsSubmit].ToString().Trim()); //是否提交
objvgs_PViewpointRelaEN.UserTypeId = objRow[convgs_PViewpointRela.UserTypeId] == DBNull.Value ? null : objRow[convgs_PViewpointRela.UserTypeId].ToString().Trim(); //用户类型Id
objvgs_PViewpointRelaEN.UserTypeName = objRow[convgs_PViewpointRela.UserTypeName] == DBNull.Value ? null : objRow[convgs_PViewpointRela.UserTypeName].ToString().Trim(); //用户类型名称
objvgs_PViewpointRelaEN.AppraiseCount = objRow[convgs_PViewpointRela.AppraiseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convgs_PViewpointRela.AppraiseCount].ToString().Trim()); //评论数
objvgs_PViewpointRelaEN.Score = objRow[convgs_PViewpointRela.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convgs_PViewpointRela.Score].ToString().Trim()); //评分
objvgs_PViewpointRelaEN.StuScore = objRow[convgs_PViewpointRela.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convgs_PViewpointRela.StuScore].ToString().Trim()); //学生平均分
objvgs_PViewpointRelaEN.TeaScore = objRow[convgs_PViewpointRela.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convgs_PViewpointRela.TeaScore].ToString().Trim()); //教师评分
objvgs_PViewpointRelaEN.OkCount = objRow[convgs_PViewpointRela.OkCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convgs_PViewpointRela.OkCount].ToString().Trim()); //点赞统计
objvgs_PViewpointRelaEN.CitationCount = objRow[convgs_PViewpointRela.CitationCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convgs_PViewpointRela.CitationCount].ToString().Trim()); //引用统计
objvgs_PViewpointRelaEN.VersionCount = objRow[convgs_PViewpointRela.VersionCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convgs_PViewpointRela.VersionCount].ToString().Trim()); //版本统计
objvgs_PViewpointRelaEN.ProposePeople = objRow[convgs_PViewpointRela.ProposePeople] == DBNull.Value ? null : objRow[convgs_PViewpointRela.ProposePeople].ToString().Trim(); //提出人
objvgs_PViewpointRelaEN.UpdDate = objRow[convgs_PViewpointRela.UpdDate] == DBNull.Value ? null : objRow[convgs_PViewpointRela.UpdDate].ToString().Trim(); //修改日期
objvgs_PViewpointRelaEN.UpdUser = objRow[convgs_PViewpointRela.UpdUser] == DBNull.Value ? null : objRow[convgs_PViewpointRela.UpdUser].ToString().Trim(); //修改人
objvgs_PViewpointRelaEN.Memo = objRow[convgs_PViewpointRela.Memo] == DBNull.Value ? null : objRow[convgs_PViewpointRela.Memo].ToString().Trim(); //备注
objvgs_PViewpointRelaEN.ViewsDate = objRow[convgs_PViewpointRela.ViewsDate] == DBNull.Value ? null : objRow[convgs_PViewpointRela.ViewsDate].ToString().Trim(); //ViewsDate
objvgs_PViewpointRelaEN.ViewsUserId = objRow[convgs_PViewpointRela.ViewsUserId] == DBNull.Value ? null : objRow[convgs_PViewpointRela.ViewsUserId].ToString().Trim(); //ViewsUserId
objvgs_PViewpointRelaEN.CreateDate = objRow[convgs_PViewpointRela.CreateDate] == DBNull.Value ? null : objRow[convgs_PViewpointRela.CreateDate].ToString().Trim(); //建立日期
objvgs_PViewpointRelaEN.ShareId = objRow[convgs_PViewpointRela.ShareId] == DBNull.Value ? null : objRow[convgs_PViewpointRela.ShareId].ToString().Trim(); //分享Id
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvgs_PViewpointRelaEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvgs_PViewpointRelaEN);
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
public static List<clsvgs_PViewpointRelaEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsvgs_PViewpointRelaEN> arrObjLst = new List<clsvgs_PViewpointRelaEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvgs_PViewpointRelaEN objvgs_PViewpointRelaEN = new clsvgs_PViewpointRelaEN();
try
{
objvgs_PViewpointRelaEN.mId = Int32.Parse(objRow[convgs_PViewpointRela.mId].ToString().Trim()); //mId
objvgs_PViewpointRelaEN.PaperId = objRow[convgs_PViewpointRela.PaperId].ToString().Trim(); //论文Id
objvgs_PViewpointRelaEN.PaperTitle = objRow[convgs_PViewpointRela.PaperTitle] == DBNull.Value ? null : objRow[convgs_PViewpointRela.PaperTitle].ToString().Trim(); //论文标题
objvgs_PViewpointRelaEN.PaperTypeId = objRow[convgs_PViewpointRela.PaperTypeId] == DBNull.Value ? null : objRow[convgs_PViewpointRela.PaperTypeId].ToString().Trim(); //论文类型Id
objvgs_PViewpointRelaEN.SectionId = objRow[convgs_PViewpointRela.SectionId] == DBNull.Value ? null : objRow[convgs_PViewpointRela.SectionId].ToString().Trim(); //节Id
objvgs_PViewpointRelaEN.SectionName = objRow[convgs_PViewpointRela.SectionName] == DBNull.Value ? null : objRow[convgs_PViewpointRela.SectionName].ToString().Trim(); //节名
objvgs_PViewpointRelaEN.ViewpointId = objRow[convgs_PViewpointRela.ViewpointId].ToString().Trim(); //观点Id
objvgs_PViewpointRelaEN.ViewpointName = objRow[convgs_PViewpointRela.ViewpointName] == DBNull.Value ? null : objRow[convgs_PViewpointRela.ViewpointName].ToString().Trim(); //观点名称
objvgs_PViewpointRelaEN.ViewpointContent = objRow[convgs_PViewpointRela.ViewpointContent] == DBNull.Value ? null : objRow[convgs_PViewpointRela.ViewpointContent].ToString().Trim(); //观点内容
objvgs_PViewpointRelaEN.ViewpointTypeId = objRow[convgs_PViewpointRela.ViewpointTypeId] == DBNull.Value ? null : objRow[convgs_PViewpointRela.ViewpointTypeId].ToString().Trim(); //观点类型Id
objvgs_PViewpointRelaEN.ViewpointTypeName = objRow[convgs_PViewpointRela.ViewpointTypeName] == DBNull.Value ? null : objRow[convgs_PViewpointRela.ViewpointTypeName].ToString().Trim(); //观点类型名
objvgs_PViewpointRelaEN.Reason = objRow[convgs_PViewpointRela.Reason] == DBNull.Value ? null : objRow[convgs_PViewpointRela.Reason].ToString().Trim(); //理由
objvgs_PViewpointRelaEN.VPProposePeople = objRow[convgs_PViewpointRela.VPProposePeople] == DBNull.Value ? null : objRow[convgs_PViewpointRela.VPProposePeople].ToString().Trim(); //观点提出人
objvgs_PViewpointRelaEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[convgs_PViewpointRela.IsSubmit].ToString().Trim()); //是否提交
objvgs_PViewpointRelaEN.UserTypeId = objRow[convgs_PViewpointRela.UserTypeId] == DBNull.Value ? null : objRow[convgs_PViewpointRela.UserTypeId].ToString().Trim(); //用户类型Id
objvgs_PViewpointRelaEN.UserTypeName = objRow[convgs_PViewpointRela.UserTypeName] == DBNull.Value ? null : objRow[convgs_PViewpointRela.UserTypeName].ToString().Trim(); //用户类型名称
objvgs_PViewpointRelaEN.AppraiseCount = objRow[convgs_PViewpointRela.AppraiseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convgs_PViewpointRela.AppraiseCount].ToString().Trim()); //评论数
objvgs_PViewpointRelaEN.Score = objRow[convgs_PViewpointRela.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convgs_PViewpointRela.Score].ToString().Trim()); //评分
objvgs_PViewpointRelaEN.StuScore = objRow[convgs_PViewpointRela.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convgs_PViewpointRela.StuScore].ToString().Trim()); //学生平均分
objvgs_PViewpointRelaEN.TeaScore = objRow[convgs_PViewpointRela.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convgs_PViewpointRela.TeaScore].ToString().Trim()); //教师评分
objvgs_PViewpointRelaEN.OkCount = objRow[convgs_PViewpointRela.OkCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convgs_PViewpointRela.OkCount].ToString().Trim()); //点赞统计
objvgs_PViewpointRelaEN.CitationCount = objRow[convgs_PViewpointRela.CitationCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convgs_PViewpointRela.CitationCount].ToString().Trim()); //引用统计
objvgs_PViewpointRelaEN.VersionCount = objRow[convgs_PViewpointRela.VersionCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convgs_PViewpointRela.VersionCount].ToString().Trim()); //版本统计
objvgs_PViewpointRelaEN.ProposePeople = objRow[convgs_PViewpointRela.ProposePeople] == DBNull.Value ? null : objRow[convgs_PViewpointRela.ProposePeople].ToString().Trim(); //提出人
objvgs_PViewpointRelaEN.UpdDate = objRow[convgs_PViewpointRela.UpdDate] == DBNull.Value ? null : objRow[convgs_PViewpointRela.UpdDate].ToString().Trim(); //修改日期
objvgs_PViewpointRelaEN.UpdUser = objRow[convgs_PViewpointRela.UpdUser] == DBNull.Value ? null : objRow[convgs_PViewpointRela.UpdUser].ToString().Trim(); //修改人
objvgs_PViewpointRelaEN.Memo = objRow[convgs_PViewpointRela.Memo] == DBNull.Value ? null : objRow[convgs_PViewpointRela.Memo].ToString().Trim(); //备注
objvgs_PViewpointRelaEN.ViewsDate = objRow[convgs_PViewpointRela.ViewsDate] == DBNull.Value ? null : objRow[convgs_PViewpointRela.ViewsDate].ToString().Trim(); //ViewsDate
objvgs_PViewpointRelaEN.ViewsUserId = objRow[convgs_PViewpointRela.ViewsUserId] == DBNull.Value ? null : objRow[convgs_PViewpointRela.ViewsUserId].ToString().Trim(); //ViewsUserId
objvgs_PViewpointRelaEN.CreateDate = objRow[convgs_PViewpointRela.CreateDate] == DBNull.Value ? null : objRow[convgs_PViewpointRela.CreateDate].ToString().Trim(); //建立日期
objvgs_PViewpointRelaEN.ShareId = objRow[convgs_PViewpointRela.ShareId] == DBNull.Value ? null : objRow[convgs_PViewpointRela.ShareId].ToString().Trim(); //分享Id
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvgs_PViewpointRelaEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvgs_PViewpointRelaEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsvgs_PViewpointRelaEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsvgs_PViewpointRelaEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsvgs_PViewpointRelaEN> arrObjLst = new List<clsvgs_PViewpointRelaEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvgs_PViewpointRelaEN objvgs_PViewpointRelaEN = new clsvgs_PViewpointRelaEN();
try
{
objvgs_PViewpointRelaEN.mId = Int32.Parse(objRow[convgs_PViewpointRela.mId].ToString().Trim()); //mId
objvgs_PViewpointRelaEN.PaperId = objRow[convgs_PViewpointRela.PaperId].ToString().Trim(); //论文Id
objvgs_PViewpointRelaEN.PaperTitle = objRow[convgs_PViewpointRela.PaperTitle] == DBNull.Value ? null : objRow[convgs_PViewpointRela.PaperTitle].ToString().Trim(); //论文标题
objvgs_PViewpointRelaEN.PaperTypeId = objRow[convgs_PViewpointRela.PaperTypeId] == DBNull.Value ? null : objRow[convgs_PViewpointRela.PaperTypeId].ToString().Trim(); //论文类型Id
objvgs_PViewpointRelaEN.SectionId = objRow[convgs_PViewpointRela.SectionId] == DBNull.Value ? null : objRow[convgs_PViewpointRela.SectionId].ToString().Trim(); //节Id
objvgs_PViewpointRelaEN.SectionName = objRow[convgs_PViewpointRela.SectionName] == DBNull.Value ? null : objRow[convgs_PViewpointRela.SectionName].ToString().Trim(); //节名
objvgs_PViewpointRelaEN.ViewpointId = objRow[convgs_PViewpointRela.ViewpointId].ToString().Trim(); //观点Id
objvgs_PViewpointRelaEN.ViewpointName = objRow[convgs_PViewpointRela.ViewpointName] == DBNull.Value ? null : objRow[convgs_PViewpointRela.ViewpointName].ToString().Trim(); //观点名称
objvgs_PViewpointRelaEN.ViewpointContent = objRow[convgs_PViewpointRela.ViewpointContent] == DBNull.Value ? null : objRow[convgs_PViewpointRela.ViewpointContent].ToString().Trim(); //观点内容
objvgs_PViewpointRelaEN.ViewpointTypeId = objRow[convgs_PViewpointRela.ViewpointTypeId] == DBNull.Value ? null : objRow[convgs_PViewpointRela.ViewpointTypeId].ToString().Trim(); //观点类型Id
objvgs_PViewpointRelaEN.ViewpointTypeName = objRow[convgs_PViewpointRela.ViewpointTypeName] == DBNull.Value ? null : objRow[convgs_PViewpointRela.ViewpointTypeName].ToString().Trim(); //观点类型名
objvgs_PViewpointRelaEN.Reason = objRow[convgs_PViewpointRela.Reason] == DBNull.Value ? null : objRow[convgs_PViewpointRela.Reason].ToString().Trim(); //理由
objvgs_PViewpointRelaEN.VPProposePeople = objRow[convgs_PViewpointRela.VPProposePeople] == DBNull.Value ? null : objRow[convgs_PViewpointRela.VPProposePeople].ToString().Trim(); //观点提出人
objvgs_PViewpointRelaEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[convgs_PViewpointRela.IsSubmit].ToString().Trim()); //是否提交
objvgs_PViewpointRelaEN.UserTypeId = objRow[convgs_PViewpointRela.UserTypeId] == DBNull.Value ? null : objRow[convgs_PViewpointRela.UserTypeId].ToString().Trim(); //用户类型Id
objvgs_PViewpointRelaEN.UserTypeName = objRow[convgs_PViewpointRela.UserTypeName] == DBNull.Value ? null : objRow[convgs_PViewpointRela.UserTypeName].ToString().Trim(); //用户类型名称
objvgs_PViewpointRelaEN.AppraiseCount = objRow[convgs_PViewpointRela.AppraiseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convgs_PViewpointRela.AppraiseCount].ToString().Trim()); //评论数
objvgs_PViewpointRelaEN.Score = objRow[convgs_PViewpointRela.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convgs_PViewpointRela.Score].ToString().Trim()); //评分
objvgs_PViewpointRelaEN.StuScore = objRow[convgs_PViewpointRela.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convgs_PViewpointRela.StuScore].ToString().Trim()); //学生平均分
objvgs_PViewpointRelaEN.TeaScore = objRow[convgs_PViewpointRela.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convgs_PViewpointRela.TeaScore].ToString().Trim()); //教师评分
objvgs_PViewpointRelaEN.OkCount = objRow[convgs_PViewpointRela.OkCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convgs_PViewpointRela.OkCount].ToString().Trim()); //点赞统计
objvgs_PViewpointRelaEN.CitationCount = objRow[convgs_PViewpointRela.CitationCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convgs_PViewpointRela.CitationCount].ToString().Trim()); //引用统计
objvgs_PViewpointRelaEN.VersionCount = objRow[convgs_PViewpointRela.VersionCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convgs_PViewpointRela.VersionCount].ToString().Trim()); //版本统计
objvgs_PViewpointRelaEN.ProposePeople = objRow[convgs_PViewpointRela.ProposePeople] == DBNull.Value ? null : objRow[convgs_PViewpointRela.ProposePeople].ToString().Trim(); //提出人
objvgs_PViewpointRelaEN.UpdDate = objRow[convgs_PViewpointRela.UpdDate] == DBNull.Value ? null : objRow[convgs_PViewpointRela.UpdDate].ToString().Trim(); //修改日期
objvgs_PViewpointRelaEN.UpdUser = objRow[convgs_PViewpointRela.UpdUser] == DBNull.Value ? null : objRow[convgs_PViewpointRela.UpdUser].ToString().Trim(); //修改人
objvgs_PViewpointRelaEN.Memo = objRow[convgs_PViewpointRela.Memo] == DBNull.Value ? null : objRow[convgs_PViewpointRela.Memo].ToString().Trim(); //备注
objvgs_PViewpointRelaEN.ViewsDate = objRow[convgs_PViewpointRela.ViewsDate] == DBNull.Value ? null : objRow[convgs_PViewpointRela.ViewsDate].ToString().Trim(); //ViewsDate
objvgs_PViewpointRelaEN.ViewsUserId = objRow[convgs_PViewpointRela.ViewsUserId] == DBNull.Value ? null : objRow[convgs_PViewpointRela.ViewsUserId].ToString().Trim(); //ViewsUserId
objvgs_PViewpointRelaEN.CreateDate = objRow[convgs_PViewpointRela.CreateDate] == DBNull.Value ? null : objRow[convgs_PViewpointRela.CreateDate].ToString().Trim(); //建立日期
objvgs_PViewpointRelaEN.ShareId = objRow[convgs_PViewpointRela.ShareId] == DBNull.Value ? null : objRow[convgs_PViewpointRela.ShareId].ToString().Trim(); //分享Id
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvgs_PViewpointRelaEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvgs_PViewpointRelaEN);
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
public static List<clsvgs_PViewpointRelaEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsvgs_PViewpointRelaEN> arrObjLst = new List<clsvgs_PViewpointRelaEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvgs_PViewpointRelaEN objvgs_PViewpointRelaEN = new clsvgs_PViewpointRelaEN();
try
{
objvgs_PViewpointRelaEN.mId = Int32.Parse(objRow[convgs_PViewpointRela.mId].ToString().Trim()); //mId
objvgs_PViewpointRelaEN.PaperId = objRow[convgs_PViewpointRela.PaperId].ToString().Trim(); //论文Id
objvgs_PViewpointRelaEN.PaperTitle = objRow[convgs_PViewpointRela.PaperTitle] == DBNull.Value ? null : objRow[convgs_PViewpointRela.PaperTitle].ToString().Trim(); //论文标题
objvgs_PViewpointRelaEN.PaperTypeId = objRow[convgs_PViewpointRela.PaperTypeId] == DBNull.Value ? null : objRow[convgs_PViewpointRela.PaperTypeId].ToString().Trim(); //论文类型Id
objvgs_PViewpointRelaEN.SectionId = objRow[convgs_PViewpointRela.SectionId] == DBNull.Value ? null : objRow[convgs_PViewpointRela.SectionId].ToString().Trim(); //节Id
objvgs_PViewpointRelaEN.SectionName = objRow[convgs_PViewpointRela.SectionName] == DBNull.Value ? null : objRow[convgs_PViewpointRela.SectionName].ToString().Trim(); //节名
objvgs_PViewpointRelaEN.ViewpointId = objRow[convgs_PViewpointRela.ViewpointId].ToString().Trim(); //观点Id
objvgs_PViewpointRelaEN.ViewpointName = objRow[convgs_PViewpointRela.ViewpointName] == DBNull.Value ? null : objRow[convgs_PViewpointRela.ViewpointName].ToString().Trim(); //观点名称
objvgs_PViewpointRelaEN.ViewpointContent = objRow[convgs_PViewpointRela.ViewpointContent] == DBNull.Value ? null : objRow[convgs_PViewpointRela.ViewpointContent].ToString().Trim(); //观点内容
objvgs_PViewpointRelaEN.ViewpointTypeId = objRow[convgs_PViewpointRela.ViewpointTypeId] == DBNull.Value ? null : objRow[convgs_PViewpointRela.ViewpointTypeId].ToString().Trim(); //观点类型Id
objvgs_PViewpointRelaEN.ViewpointTypeName = objRow[convgs_PViewpointRela.ViewpointTypeName] == DBNull.Value ? null : objRow[convgs_PViewpointRela.ViewpointTypeName].ToString().Trim(); //观点类型名
objvgs_PViewpointRelaEN.Reason = objRow[convgs_PViewpointRela.Reason] == DBNull.Value ? null : objRow[convgs_PViewpointRela.Reason].ToString().Trim(); //理由
objvgs_PViewpointRelaEN.VPProposePeople = objRow[convgs_PViewpointRela.VPProposePeople] == DBNull.Value ? null : objRow[convgs_PViewpointRela.VPProposePeople].ToString().Trim(); //观点提出人
objvgs_PViewpointRelaEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[convgs_PViewpointRela.IsSubmit].ToString().Trim()); //是否提交
objvgs_PViewpointRelaEN.UserTypeId = objRow[convgs_PViewpointRela.UserTypeId] == DBNull.Value ? null : objRow[convgs_PViewpointRela.UserTypeId].ToString().Trim(); //用户类型Id
objvgs_PViewpointRelaEN.UserTypeName = objRow[convgs_PViewpointRela.UserTypeName] == DBNull.Value ? null : objRow[convgs_PViewpointRela.UserTypeName].ToString().Trim(); //用户类型名称
objvgs_PViewpointRelaEN.AppraiseCount = objRow[convgs_PViewpointRela.AppraiseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convgs_PViewpointRela.AppraiseCount].ToString().Trim()); //评论数
objvgs_PViewpointRelaEN.Score = objRow[convgs_PViewpointRela.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convgs_PViewpointRela.Score].ToString().Trim()); //评分
objvgs_PViewpointRelaEN.StuScore = objRow[convgs_PViewpointRela.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convgs_PViewpointRela.StuScore].ToString().Trim()); //学生平均分
objvgs_PViewpointRelaEN.TeaScore = objRow[convgs_PViewpointRela.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convgs_PViewpointRela.TeaScore].ToString().Trim()); //教师评分
objvgs_PViewpointRelaEN.OkCount = objRow[convgs_PViewpointRela.OkCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convgs_PViewpointRela.OkCount].ToString().Trim()); //点赞统计
objvgs_PViewpointRelaEN.CitationCount = objRow[convgs_PViewpointRela.CitationCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convgs_PViewpointRela.CitationCount].ToString().Trim()); //引用统计
objvgs_PViewpointRelaEN.VersionCount = objRow[convgs_PViewpointRela.VersionCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convgs_PViewpointRela.VersionCount].ToString().Trim()); //版本统计
objvgs_PViewpointRelaEN.ProposePeople = objRow[convgs_PViewpointRela.ProposePeople] == DBNull.Value ? null : objRow[convgs_PViewpointRela.ProposePeople].ToString().Trim(); //提出人
objvgs_PViewpointRelaEN.UpdDate = objRow[convgs_PViewpointRela.UpdDate] == DBNull.Value ? null : objRow[convgs_PViewpointRela.UpdDate].ToString().Trim(); //修改日期
objvgs_PViewpointRelaEN.UpdUser = objRow[convgs_PViewpointRela.UpdUser] == DBNull.Value ? null : objRow[convgs_PViewpointRela.UpdUser].ToString().Trim(); //修改人
objvgs_PViewpointRelaEN.Memo = objRow[convgs_PViewpointRela.Memo] == DBNull.Value ? null : objRow[convgs_PViewpointRela.Memo].ToString().Trim(); //备注
objvgs_PViewpointRelaEN.ViewsDate = objRow[convgs_PViewpointRela.ViewsDate] == DBNull.Value ? null : objRow[convgs_PViewpointRela.ViewsDate].ToString().Trim(); //ViewsDate
objvgs_PViewpointRelaEN.ViewsUserId = objRow[convgs_PViewpointRela.ViewsUserId] == DBNull.Value ? null : objRow[convgs_PViewpointRela.ViewsUserId].ToString().Trim(); //ViewsUserId
objvgs_PViewpointRelaEN.CreateDate = objRow[convgs_PViewpointRela.CreateDate] == DBNull.Value ? null : objRow[convgs_PViewpointRela.CreateDate].ToString().Trim(); //建立日期
objvgs_PViewpointRelaEN.ShareId = objRow[convgs_PViewpointRela.ShareId] == DBNull.Value ? null : objRow[convgs_PViewpointRela.ShareId].ToString().Trim(); //分享Id
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvgs_PViewpointRelaEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvgs_PViewpointRelaEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsvgs_PViewpointRelaEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsvgs_PViewpointRelaEN> arrObjLst = new List<clsvgs_PViewpointRelaEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvgs_PViewpointRelaEN objvgs_PViewpointRelaEN = new clsvgs_PViewpointRelaEN();
try
{
objvgs_PViewpointRelaEN.mId = Int32.Parse(objRow[convgs_PViewpointRela.mId].ToString().Trim()); //mId
objvgs_PViewpointRelaEN.PaperId = objRow[convgs_PViewpointRela.PaperId].ToString().Trim(); //论文Id
objvgs_PViewpointRelaEN.PaperTitle = objRow[convgs_PViewpointRela.PaperTitle] == DBNull.Value ? null : objRow[convgs_PViewpointRela.PaperTitle].ToString().Trim(); //论文标题
objvgs_PViewpointRelaEN.PaperTypeId = objRow[convgs_PViewpointRela.PaperTypeId] == DBNull.Value ? null : objRow[convgs_PViewpointRela.PaperTypeId].ToString().Trim(); //论文类型Id
objvgs_PViewpointRelaEN.SectionId = objRow[convgs_PViewpointRela.SectionId] == DBNull.Value ? null : objRow[convgs_PViewpointRela.SectionId].ToString().Trim(); //节Id
objvgs_PViewpointRelaEN.SectionName = objRow[convgs_PViewpointRela.SectionName] == DBNull.Value ? null : objRow[convgs_PViewpointRela.SectionName].ToString().Trim(); //节名
objvgs_PViewpointRelaEN.ViewpointId = objRow[convgs_PViewpointRela.ViewpointId].ToString().Trim(); //观点Id
objvgs_PViewpointRelaEN.ViewpointName = objRow[convgs_PViewpointRela.ViewpointName] == DBNull.Value ? null : objRow[convgs_PViewpointRela.ViewpointName].ToString().Trim(); //观点名称
objvgs_PViewpointRelaEN.ViewpointContent = objRow[convgs_PViewpointRela.ViewpointContent] == DBNull.Value ? null : objRow[convgs_PViewpointRela.ViewpointContent].ToString().Trim(); //观点内容
objvgs_PViewpointRelaEN.ViewpointTypeId = objRow[convgs_PViewpointRela.ViewpointTypeId] == DBNull.Value ? null : objRow[convgs_PViewpointRela.ViewpointTypeId].ToString().Trim(); //观点类型Id
objvgs_PViewpointRelaEN.ViewpointTypeName = objRow[convgs_PViewpointRela.ViewpointTypeName] == DBNull.Value ? null : objRow[convgs_PViewpointRela.ViewpointTypeName].ToString().Trim(); //观点类型名
objvgs_PViewpointRelaEN.Reason = objRow[convgs_PViewpointRela.Reason] == DBNull.Value ? null : objRow[convgs_PViewpointRela.Reason].ToString().Trim(); //理由
objvgs_PViewpointRelaEN.VPProposePeople = objRow[convgs_PViewpointRela.VPProposePeople] == DBNull.Value ? null : objRow[convgs_PViewpointRela.VPProposePeople].ToString().Trim(); //观点提出人
objvgs_PViewpointRelaEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[convgs_PViewpointRela.IsSubmit].ToString().Trim()); //是否提交
objvgs_PViewpointRelaEN.UserTypeId = objRow[convgs_PViewpointRela.UserTypeId] == DBNull.Value ? null : objRow[convgs_PViewpointRela.UserTypeId].ToString().Trim(); //用户类型Id
objvgs_PViewpointRelaEN.UserTypeName = objRow[convgs_PViewpointRela.UserTypeName] == DBNull.Value ? null : objRow[convgs_PViewpointRela.UserTypeName].ToString().Trim(); //用户类型名称
objvgs_PViewpointRelaEN.AppraiseCount = objRow[convgs_PViewpointRela.AppraiseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convgs_PViewpointRela.AppraiseCount].ToString().Trim()); //评论数
objvgs_PViewpointRelaEN.Score = objRow[convgs_PViewpointRela.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convgs_PViewpointRela.Score].ToString().Trim()); //评分
objvgs_PViewpointRelaEN.StuScore = objRow[convgs_PViewpointRela.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convgs_PViewpointRela.StuScore].ToString().Trim()); //学生平均分
objvgs_PViewpointRelaEN.TeaScore = objRow[convgs_PViewpointRela.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convgs_PViewpointRela.TeaScore].ToString().Trim()); //教师评分
objvgs_PViewpointRelaEN.OkCount = objRow[convgs_PViewpointRela.OkCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convgs_PViewpointRela.OkCount].ToString().Trim()); //点赞统计
objvgs_PViewpointRelaEN.CitationCount = objRow[convgs_PViewpointRela.CitationCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convgs_PViewpointRela.CitationCount].ToString().Trim()); //引用统计
objvgs_PViewpointRelaEN.VersionCount = objRow[convgs_PViewpointRela.VersionCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convgs_PViewpointRela.VersionCount].ToString().Trim()); //版本统计
objvgs_PViewpointRelaEN.ProposePeople = objRow[convgs_PViewpointRela.ProposePeople] == DBNull.Value ? null : objRow[convgs_PViewpointRela.ProposePeople].ToString().Trim(); //提出人
objvgs_PViewpointRelaEN.UpdDate = objRow[convgs_PViewpointRela.UpdDate] == DBNull.Value ? null : objRow[convgs_PViewpointRela.UpdDate].ToString().Trim(); //修改日期
objvgs_PViewpointRelaEN.UpdUser = objRow[convgs_PViewpointRela.UpdUser] == DBNull.Value ? null : objRow[convgs_PViewpointRela.UpdUser].ToString().Trim(); //修改人
objvgs_PViewpointRelaEN.Memo = objRow[convgs_PViewpointRela.Memo] == DBNull.Value ? null : objRow[convgs_PViewpointRela.Memo].ToString().Trim(); //备注
objvgs_PViewpointRelaEN.ViewsDate = objRow[convgs_PViewpointRela.ViewsDate] == DBNull.Value ? null : objRow[convgs_PViewpointRela.ViewsDate].ToString().Trim(); //ViewsDate
objvgs_PViewpointRelaEN.ViewsUserId = objRow[convgs_PViewpointRela.ViewsUserId] == DBNull.Value ? null : objRow[convgs_PViewpointRela.ViewsUserId].ToString().Trim(); //ViewsUserId
objvgs_PViewpointRelaEN.CreateDate = objRow[convgs_PViewpointRela.CreateDate] == DBNull.Value ? null : objRow[convgs_PViewpointRela.CreateDate].ToString().Trim(); //建立日期
objvgs_PViewpointRelaEN.ShareId = objRow[convgs_PViewpointRela.ShareId] == DBNull.Value ? null : objRow[convgs_PViewpointRela.ShareId].ToString().Trim(); //分享Id
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvgs_PViewpointRelaEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvgs_PViewpointRelaEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objvgs_PViewpointRelaEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool Getvgs_PViewpointRela(ref clsvgs_PViewpointRelaEN objvgs_PViewpointRelaEN)
{
bool bolResult = vgs_PViewpointRelaDA.Getvgs_PViewpointRela(ref objvgs_PViewpointRelaEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvgs_PViewpointRelaEN GetObjBymId(long lngmId)
{
clsvgs_PViewpointRelaEN objvgs_PViewpointRelaEN = vgs_PViewpointRelaDA.GetObjBymId(lngmId);
return objvgs_PViewpointRelaEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsvgs_PViewpointRelaEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsvgs_PViewpointRelaEN objvgs_PViewpointRelaEN = vgs_PViewpointRelaDA.GetFirstObj(strWhereCond);
 return objvgs_PViewpointRelaEN;
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
public static clsvgs_PViewpointRelaEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsvgs_PViewpointRelaEN objvgs_PViewpointRelaEN = vgs_PViewpointRelaDA.GetObjByDataRow(objRow);
 return objvgs_PViewpointRelaEN;
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
public static clsvgs_PViewpointRelaEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsvgs_PViewpointRelaEN objvgs_PViewpointRelaEN = vgs_PViewpointRelaDA.GetObjByDataRow(objRow);
 return objvgs_PViewpointRelaEN;
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
 /// <param name = "lstvgs_PViewpointRelaObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvgs_PViewpointRelaEN GetObjBymIdFromList(long lngmId, List<clsvgs_PViewpointRelaEN> lstvgs_PViewpointRelaObjLst)
{
foreach (clsvgs_PViewpointRelaEN objvgs_PViewpointRelaEN in lstvgs_PViewpointRelaObjLst)
{
if (objvgs_PViewpointRelaEN.mId == lngmId)
{
return objvgs_PViewpointRelaEN;
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
 lngmId = new clsvgs_PViewpointRelaDA().GetFirstID(strWhereCond);
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
 arrList = vgs_PViewpointRelaDA.GetID(strWhereCond);
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
bool bolIsExist = vgs_PViewpointRelaDA.IsExistCondRec(strWhereCond);
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
bool bolIsExist = vgs_PViewpointRelaDA.IsExist(lngmId);
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
 bolIsExist = clsvgs_PViewpointRelaDA.IsExistTable();
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
 bolIsExist = vgs_PViewpointRelaDA.IsExistTable(strTabName);
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
 /// <param name = "objvgs_PViewpointRelaENS">源对象</param>
 /// <param name = "objvgs_PViewpointRelaENT">目标对象</param>
 public static void CopyTo(clsvgs_PViewpointRelaEN objvgs_PViewpointRelaENS, clsvgs_PViewpointRelaEN objvgs_PViewpointRelaENT)
{
try
{
objvgs_PViewpointRelaENT.mId = objvgs_PViewpointRelaENS.mId; //mId
objvgs_PViewpointRelaENT.PaperId = objvgs_PViewpointRelaENS.PaperId; //论文Id
objvgs_PViewpointRelaENT.PaperTitle = objvgs_PViewpointRelaENS.PaperTitle; //论文标题
objvgs_PViewpointRelaENT.PaperTypeId = objvgs_PViewpointRelaENS.PaperTypeId; //论文类型Id
objvgs_PViewpointRelaENT.SectionId = objvgs_PViewpointRelaENS.SectionId; //节Id
objvgs_PViewpointRelaENT.SectionName = objvgs_PViewpointRelaENS.SectionName; //节名
objvgs_PViewpointRelaENT.ViewpointId = objvgs_PViewpointRelaENS.ViewpointId; //观点Id
objvgs_PViewpointRelaENT.ViewpointName = objvgs_PViewpointRelaENS.ViewpointName; //观点名称
objvgs_PViewpointRelaENT.ViewpointContent = objvgs_PViewpointRelaENS.ViewpointContent; //观点内容
objvgs_PViewpointRelaENT.ViewpointTypeId = objvgs_PViewpointRelaENS.ViewpointTypeId; //观点类型Id
objvgs_PViewpointRelaENT.ViewpointTypeName = objvgs_PViewpointRelaENS.ViewpointTypeName; //观点类型名
objvgs_PViewpointRelaENT.Reason = objvgs_PViewpointRelaENS.Reason; //理由
objvgs_PViewpointRelaENT.VPProposePeople = objvgs_PViewpointRelaENS.VPProposePeople; //观点提出人
objvgs_PViewpointRelaENT.IsSubmit = objvgs_PViewpointRelaENS.IsSubmit; //是否提交
objvgs_PViewpointRelaENT.UserTypeId = objvgs_PViewpointRelaENS.UserTypeId; //用户类型Id
objvgs_PViewpointRelaENT.UserTypeName = objvgs_PViewpointRelaENS.UserTypeName; //用户类型名称
objvgs_PViewpointRelaENT.AppraiseCount = objvgs_PViewpointRelaENS.AppraiseCount; //评论数
objvgs_PViewpointRelaENT.Score = objvgs_PViewpointRelaENS.Score; //评分
objvgs_PViewpointRelaENT.StuScore = objvgs_PViewpointRelaENS.StuScore; //学生平均分
objvgs_PViewpointRelaENT.TeaScore = objvgs_PViewpointRelaENS.TeaScore; //教师评分
objvgs_PViewpointRelaENT.OkCount = objvgs_PViewpointRelaENS.OkCount; //点赞统计
objvgs_PViewpointRelaENT.CitationCount = objvgs_PViewpointRelaENS.CitationCount; //引用统计
objvgs_PViewpointRelaENT.VersionCount = objvgs_PViewpointRelaENS.VersionCount; //版本统计
objvgs_PViewpointRelaENT.ProposePeople = objvgs_PViewpointRelaENS.ProposePeople; //提出人
objvgs_PViewpointRelaENT.UpdDate = objvgs_PViewpointRelaENS.UpdDate; //修改日期
objvgs_PViewpointRelaENT.UpdUser = objvgs_PViewpointRelaENS.UpdUser; //修改人
objvgs_PViewpointRelaENT.Memo = objvgs_PViewpointRelaENS.Memo; //备注
objvgs_PViewpointRelaENT.ViewsDate = objvgs_PViewpointRelaENS.ViewsDate; //ViewsDate
objvgs_PViewpointRelaENT.ViewsUserId = objvgs_PViewpointRelaENS.ViewsUserId; //ViewsUserId
objvgs_PViewpointRelaENT.CreateDate = objvgs_PViewpointRelaENS.CreateDate; //建立日期
objvgs_PViewpointRelaENT.ShareId = objvgs_PViewpointRelaENS.ShareId; //分享Id
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
 /// <param name = "objvgs_PViewpointRelaEN">源简化对象</param>
 public static void SetUpdFlag(clsvgs_PViewpointRelaEN objvgs_PViewpointRelaEN)
{
try
{
objvgs_PViewpointRelaEN.ClearUpdateState();
   string strsfUpdFldSetStr = objvgs_PViewpointRelaEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(convgs_PViewpointRela.mId, new clsStrCompareIgnoreCase())  ==  true)
{
objvgs_PViewpointRelaEN.mId = objvgs_PViewpointRelaEN.mId; //mId
}
if (arrFldSet.Contains(convgs_PViewpointRela.PaperId, new clsStrCompareIgnoreCase())  ==  true)
{
objvgs_PViewpointRelaEN.PaperId = objvgs_PViewpointRelaEN.PaperId; //论文Id
}
if (arrFldSet.Contains(convgs_PViewpointRela.PaperTitle, new clsStrCompareIgnoreCase())  ==  true)
{
objvgs_PViewpointRelaEN.PaperTitle = objvgs_PViewpointRelaEN.PaperTitle == "[null]" ? null :  objvgs_PViewpointRelaEN.PaperTitle; //论文标题
}
if (arrFldSet.Contains(convgs_PViewpointRela.PaperTypeId, new clsStrCompareIgnoreCase())  ==  true)
{
objvgs_PViewpointRelaEN.PaperTypeId = objvgs_PViewpointRelaEN.PaperTypeId == "[null]" ? null :  objvgs_PViewpointRelaEN.PaperTypeId; //论文类型Id
}
if (arrFldSet.Contains(convgs_PViewpointRela.SectionId, new clsStrCompareIgnoreCase())  ==  true)
{
objvgs_PViewpointRelaEN.SectionId = objvgs_PViewpointRelaEN.SectionId == "[null]" ? null :  objvgs_PViewpointRelaEN.SectionId; //节Id
}
if (arrFldSet.Contains(convgs_PViewpointRela.SectionName, new clsStrCompareIgnoreCase())  ==  true)
{
objvgs_PViewpointRelaEN.SectionName = objvgs_PViewpointRelaEN.SectionName == "[null]" ? null :  objvgs_PViewpointRelaEN.SectionName; //节名
}
if (arrFldSet.Contains(convgs_PViewpointRela.ViewpointId, new clsStrCompareIgnoreCase())  ==  true)
{
objvgs_PViewpointRelaEN.ViewpointId = objvgs_PViewpointRelaEN.ViewpointId; //观点Id
}
if (arrFldSet.Contains(convgs_PViewpointRela.ViewpointName, new clsStrCompareIgnoreCase())  ==  true)
{
objvgs_PViewpointRelaEN.ViewpointName = objvgs_PViewpointRelaEN.ViewpointName == "[null]" ? null :  objvgs_PViewpointRelaEN.ViewpointName; //观点名称
}
if (arrFldSet.Contains(convgs_PViewpointRela.ViewpointContent, new clsStrCompareIgnoreCase())  ==  true)
{
objvgs_PViewpointRelaEN.ViewpointContent = objvgs_PViewpointRelaEN.ViewpointContent == "[null]" ? null :  objvgs_PViewpointRelaEN.ViewpointContent; //观点内容
}
if (arrFldSet.Contains(convgs_PViewpointRela.ViewpointTypeId, new clsStrCompareIgnoreCase())  ==  true)
{
objvgs_PViewpointRelaEN.ViewpointTypeId = objvgs_PViewpointRelaEN.ViewpointTypeId == "[null]" ? null :  objvgs_PViewpointRelaEN.ViewpointTypeId; //观点类型Id
}
if (arrFldSet.Contains(convgs_PViewpointRela.ViewpointTypeName, new clsStrCompareIgnoreCase())  ==  true)
{
objvgs_PViewpointRelaEN.ViewpointTypeName = objvgs_PViewpointRelaEN.ViewpointTypeName == "[null]" ? null :  objvgs_PViewpointRelaEN.ViewpointTypeName; //观点类型名
}
if (arrFldSet.Contains(convgs_PViewpointRela.Reason, new clsStrCompareIgnoreCase())  ==  true)
{
objvgs_PViewpointRelaEN.Reason = objvgs_PViewpointRelaEN.Reason == "[null]" ? null :  objvgs_PViewpointRelaEN.Reason; //理由
}
if (arrFldSet.Contains(convgs_PViewpointRela.VPProposePeople, new clsStrCompareIgnoreCase())  ==  true)
{
objvgs_PViewpointRelaEN.VPProposePeople = objvgs_PViewpointRelaEN.VPProposePeople == "[null]" ? null :  objvgs_PViewpointRelaEN.VPProposePeople; //观点提出人
}
if (arrFldSet.Contains(convgs_PViewpointRela.IsSubmit, new clsStrCompareIgnoreCase())  ==  true)
{
objvgs_PViewpointRelaEN.IsSubmit = objvgs_PViewpointRelaEN.IsSubmit; //是否提交
}
if (arrFldSet.Contains(convgs_PViewpointRela.UserTypeId, new clsStrCompareIgnoreCase())  ==  true)
{
objvgs_PViewpointRelaEN.UserTypeId = objvgs_PViewpointRelaEN.UserTypeId == "[null]" ? null :  objvgs_PViewpointRelaEN.UserTypeId; //用户类型Id
}
if (arrFldSet.Contains(convgs_PViewpointRela.UserTypeName, new clsStrCompareIgnoreCase())  ==  true)
{
objvgs_PViewpointRelaEN.UserTypeName = objvgs_PViewpointRelaEN.UserTypeName == "[null]" ? null :  objvgs_PViewpointRelaEN.UserTypeName; //用户类型名称
}
if (arrFldSet.Contains(convgs_PViewpointRela.AppraiseCount, new clsStrCompareIgnoreCase())  ==  true)
{
objvgs_PViewpointRelaEN.AppraiseCount = objvgs_PViewpointRelaEN.AppraiseCount; //评论数
}
if (arrFldSet.Contains(convgs_PViewpointRela.Score, new clsStrCompareIgnoreCase())  ==  true)
{
objvgs_PViewpointRelaEN.Score = objvgs_PViewpointRelaEN.Score; //评分
}
if (arrFldSet.Contains(convgs_PViewpointRela.StuScore, new clsStrCompareIgnoreCase())  ==  true)
{
objvgs_PViewpointRelaEN.StuScore = objvgs_PViewpointRelaEN.StuScore; //学生平均分
}
if (arrFldSet.Contains(convgs_PViewpointRela.TeaScore, new clsStrCompareIgnoreCase())  ==  true)
{
objvgs_PViewpointRelaEN.TeaScore = objvgs_PViewpointRelaEN.TeaScore; //教师评分
}
if (arrFldSet.Contains(convgs_PViewpointRela.OkCount, new clsStrCompareIgnoreCase())  ==  true)
{
objvgs_PViewpointRelaEN.OkCount = objvgs_PViewpointRelaEN.OkCount; //点赞统计
}
if (arrFldSet.Contains(convgs_PViewpointRela.CitationCount, new clsStrCompareIgnoreCase())  ==  true)
{
objvgs_PViewpointRelaEN.CitationCount = objvgs_PViewpointRelaEN.CitationCount; //引用统计
}
if (arrFldSet.Contains(convgs_PViewpointRela.VersionCount, new clsStrCompareIgnoreCase())  ==  true)
{
objvgs_PViewpointRelaEN.VersionCount = objvgs_PViewpointRelaEN.VersionCount; //版本统计
}
if (arrFldSet.Contains(convgs_PViewpointRela.ProposePeople, new clsStrCompareIgnoreCase())  ==  true)
{
objvgs_PViewpointRelaEN.ProposePeople = objvgs_PViewpointRelaEN.ProposePeople == "[null]" ? null :  objvgs_PViewpointRelaEN.ProposePeople; //提出人
}
if (arrFldSet.Contains(convgs_PViewpointRela.UpdDate, new clsStrCompareIgnoreCase())  ==  true)
{
objvgs_PViewpointRelaEN.UpdDate = objvgs_PViewpointRelaEN.UpdDate == "[null]" ? null :  objvgs_PViewpointRelaEN.UpdDate; //修改日期
}
if (arrFldSet.Contains(convgs_PViewpointRela.UpdUser, new clsStrCompareIgnoreCase())  ==  true)
{
objvgs_PViewpointRelaEN.UpdUser = objvgs_PViewpointRelaEN.UpdUser == "[null]" ? null :  objvgs_PViewpointRelaEN.UpdUser; //修改人
}
if (arrFldSet.Contains(convgs_PViewpointRela.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objvgs_PViewpointRelaEN.Memo = objvgs_PViewpointRelaEN.Memo == "[null]" ? null :  objvgs_PViewpointRelaEN.Memo; //备注
}
if (arrFldSet.Contains(convgs_PViewpointRela.ViewsDate, new clsStrCompareIgnoreCase())  ==  true)
{
objvgs_PViewpointRelaEN.ViewsDate = objvgs_PViewpointRelaEN.ViewsDate == "[null]" ? null :  objvgs_PViewpointRelaEN.ViewsDate; //ViewsDate
}
if (arrFldSet.Contains(convgs_PViewpointRela.ViewsUserId, new clsStrCompareIgnoreCase())  ==  true)
{
objvgs_PViewpointRelaEN.ViewsUserId = objvgs_PViewpointRelaEN.ViewsUserId == "[null]" ? null :  objvgs_PViewpointRelaEN.ViewsUserId; //ViewsUserId
}
if (arrFldSet.Contains(convgs_PViewpointRela.CreateDate, new clsStrCompareIgnoreCase())  ==  true)
{
objvgs_PViewpointRelaEN.CreateDate = objvgs_PViewpointRelaEN.CreateDate == "[null]" ? null :  objvgs_PViewpointRelaEN.CreateDate; //建立日期
}
if (arrFldSet.Contains(convgs_PViewpointRela.ShareId, new clsStrCompareIgnoreCase())  ==  true)
{
objvgs_PViewpointRelaEN.ShareId = objvgs_PViewpointRelaEN.ShareId == "[null]" ? null :  objvgs_PViewpointRelaEN.ShareId; //分享Id
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
 /// <param name = "objvgs_PViewpointRelaEN">源简化对象</param>
 public static void AccessFldValueNull(clsvgs_PViewpointRelaEN objvgs_PViewpointRelaEN)
{
try
{
if (objvgs_PViewpointRelaEN.PaperTitle == "[null]") objvgs_PViewpointRelaEN.PaperTitle = null; //论文标题
if (objvgs_PViewpointRelaEN.PaperTypeId == "[null]") objvgs_PViewpointRelaEN.PaperTypeId = null; //论文类型Id
if (objvgs_PViewpointRelaEN.SectionId == "[null]") objvgs_PViewpointRelaEN.SectionId = null; //节Id
if (objvgs_PViewpointRelaEN.SectionName == "[null]") objvgs_PViewpointRelaEN.SectionName = null; //节名
if (objvgs_PViewpointRelaEN.ViewpointName == "[null]") objvgs_PViewpointRelaEN.ViewpointName = null; //观点名称
if (objvgs_PViewpointRelaEN.ViewpointContent == "[null]") objvgs_PViewpointRelaEN.ViewpointContent = null; //观点内容
if (objvgs_PViewpointRelaEN.ViewpointTypeId == "[null]") objvgs_PViewpointRelaEN.ViewpointTypeId = null; //观点类型Id
if (objvgs_PViewpointRelaEN.ViewpointTypeName == "[null]") objvgs_PViewpointRelaEN.ViewpointTypeName = null; //观点类型名
if (objvgs_PViewpointRelaEN.Reason == "[null]") objvgs_PViewpointRelaEN.Reason = null; //理由
if (objvgs_PViewpointRelaEN.VPProposePeople == "[null]") objvgs_PViewpointRelaEN.VPProposePeople = null; //观点提出人
if (objvgs_PViewpointRelaEN.UserTypeId == "[null]") objvgs_PViewpointRelaEN.UserTypeId = null; //用户类型Id
if (objvgs_PViewpointRelaEN.UserTypeName == "[null]") objvgs_PViewpointRelaEN.UserTypeName = null; //用户类型名称
if (objvgs_PViewpointRelaEN.ProposePeople == "[null]") objvgs_PViewpointRelaEN.ProposePeople = null; //提出人
if (objvgs_PViewpointRelaEN.UpdDate == "[null]") objvgs_PViewpointRelaEN.UpdDate = null; //修改日期
if (objvgs_PViewpointRelaEN.UpdUser == "[null]") objvgs_PViewpointRelaEN.UpdUser = null; //修改人
if (objvgs_PViewpointRelaEN.Memo == "[null]") objvgs_PViewpointRelaEN.Memo = null; //备注
if (objvgs_PViewpointRelaEN.ViewsDate == "[null]") objvgs_PViewpointRelaEN.ViewsDate = null; //ViewsDate
if (objvgs_PViewpointRelaEN.ViewsUserId == "[null]") objvgs_PViewpointRelaEN.ViewsUserId = null; //ViewsUserId
if (objvgs_PViewpointRelaEN.CreateDate == "[null]") objvgs_PViewpointRelaEN.CreateDate = null; //建立日期
if (objvgs_PViewpointRelaEN.ShareId == "[null]") objvgs_PViewpointRelaEN.ShareId = null; //分享Id
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
public static void CheckProperty4Condition(clsvgs_PViewpointRelaEN objvgs_PViewpointRelaEN)
{
 vgs_PViewpointRelaDA.CheckProperty4Condition(objvgs_PViewpointRelaEN);
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
if (clsgs_PViewpointRelaBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsgs_PViewpointRelaBL没有刷新缓存机制(clsgs_PViewpointRelaBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsViewpointBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsViewpointBL没有刷新缓存机制(clsViewpointBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsViewpointTypeBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsViewpointTypeBL没有刷新缓存机制(clsViewpointTypeBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by mId");
//if (arrvgs_PViewpointRelaObjLstCache == null)
//{
//arrvgs_PViewpointRelaObjLstCache = vgs_PViewpointRelaDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "lngmId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvgs_PViewpointRelaEN GetObjBymIdCache(long lngmId)
{
//获取缓存中的对象列表
string strKey = string.Format("{0}", clsvgs_PViewpointRelaEN._CurrTabName);
List<clsvgs_PViewpointRelaEN> arrvgs_PViewpointRelaObjLstCache = GetObjLstCache();
IEnumerable <clsvgs_PViewpointRelaEN> arrvgs_PViewpointRelaObjLst_Sel =
arrvgs_PViewpointRelaObjLstCache
.Where(x=> x.mId == lngmId 
);
if (arrvgs_PViewpointRelaObjLst_Sel.Count() == 0)
{
   clsvgs_PViewpointRelaEN obj = clsvgs_PViewpointRelaBL.GetObjBymId(lngmId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
 }
return null;
}
return arrvgs_PViewpointRelaObjLst_Sel.First();
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvgs_PViewpointRelaEN> GetAllvgs_PViewpointRelaObjLstCache()
{
//获取缓存中的对象列表
List<clsvgs_PViewpointRelaEN> arrvgs_PViewpointRelaObjLstCache = GetObjLstCache(); 
return arrvgs_PViewpointRelaObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvgs_PViewpointRelaEN> GetObjLstCache()
{
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}", clsvgs_PViewpointRelaEN._CurrTabName);
List<clsvgs_PViewpointRelaEN> arrvgs_PViewpointRelaObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrvgs_PViewpointRelaObjLstCache;
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
string strKey = string.Format("{0}", clsvgs_PViewpointRelaEN._CurrTabName);
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
if (strInFldName != convgs_PViewpointRela.mId)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (convgs_PViewpointRela.AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", convgs_PViewpointRela.AttributeName));
throw new Exception(strMsg);
}
var objvgs_PViewpointRela = clsvgs_PViewpointRelaBL.GetObjBymIdCache(lngmId);
if (objvgs_PViewpointRela == null) return "";
return objvgs_PViewpointRela[strOutFldName].ToString();
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
int intRecCount = clsvgs_PViewpointRelaDA.GetRecCount(strTabName);
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
int intRecCount = clsvgs_PViewpointRelaDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsvgs_PViewpointRelaDA.GetRecCount();
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
int intRecCount = clsvgs_PViewpointRelaDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objvgs_PViewpointRelaCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsvgs_PViewpointRelaEN objvgs_PViewpointRelaCond)
{
List<clsvgs_PViewpointRelaEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsvgs_PViewpointRelaEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convgs_PViewpointRela.AttributeName)
{
if (objvgs_PViewpointRelaCond.IsUpdated(strFldName) == false) continue;
if (objvgs_PViewpointRelaCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvgs_PViewpointRelaCond[strFldName].ToString());
}
else
{
if (objvgs_PViewpointRelaCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvgs_PViewpointRelaCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvgs_PViewpointRelaCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvgs_PViewpointRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvgs_PViewpointRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvgs_PViewpointRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvgs_PViewpointRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvgs_PViewpointRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvgs_PViewpointRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvgs_PViewpointRelaCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvgs_PViewpointRelaCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvgs_PViewpointRelaCond[strFldName]));
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
 List<string> arrList = clsvgs_PViewpointRelaDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = vgs_PViewpointRelaDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = vgs_PViewpointRelaDA.GetFldValueNoDistinct(strFldName, strWhereCond);
return arrList;
}



 #endregion 表操作常用函数
}
}