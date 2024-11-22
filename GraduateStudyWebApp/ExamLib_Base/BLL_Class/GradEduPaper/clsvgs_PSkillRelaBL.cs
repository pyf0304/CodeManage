
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvgs_PSkillRelaBL
 表名:vgs_PSkillRela(01120666)
 * 版本:2023.08.23.1(服务器:WIN-SRV103-116)
 日期:2023/08/24 12:59:18
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
public static class  clsvgs_PSkillRelaBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvgs_PSkillRelaEN GetObj(this K_mId_vgs_PSkillRela myKey)
{
clsvgs_PSkillRelaEN objvgs_PSkillRelaEN = clsvgs_PSkillRelaBL.vgs_PSkillRelaDA.GetObjBymId(myKey.Value);
return objvgs_PSkillRelaEN;
}

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvgs_PSkillRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvgs_PSkillRelaEN SetmId(this clsvgs_PSkillRelaEN objvgs_PSkillRelaEN, long lngmId, string strComparisonOp="")
	{
objvgs_PSkillRelaEN.mId = lngmId; //mId
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvgs_PSkillRelaEN.dicFldComparisonOp.ContainsKey(convgs_PSkillRela.mId) == false)
{
objvgs_PSkillRelaEN.dicFldComparisonOp.Add(convgs_PSkillRela.mId, strComparisonOp);
}
else
{
objvgs_PSkillRelaEN.dicFldComparisonOp[convgs_PSkillRela.mId] = strComparisonOp;
}
}
return objvgs_PSkillRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvgs_PSkillRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvgs_PSkillRelaEN SetPaperId(this clsvgs_PSkillRelaEN objvgs_PSkillRelaEN, string strPaperId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strPaperId, convgs_PSkillRela.PaperId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPaperId, 8, convgs_PSkillRela.PaperId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strPaperId, 8, convgs_PSkillRela.PaperId);
}
objvgs_PSkillRelaEN.PaperId = strPaperId; //论文Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvgs_PSkillRelaEN.dicFldComparisonOp.ContainsKey(convgs_PSkillRela.PaperId) == false)
{
objvgs_PSkillRelaEN.dicFldComparisonOp.Add(convgs_PSkillRela.PaperId, strComparisonOp);
}
else
{
objvgs_PSkillRelaEN.dicFldComparisonOp[convgs_PSkillRela.PaperId] = strComparisonOp;
}
}
return objvgs_PSkillRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvgs_PSkillRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvgs_PSkillRelaEN SetPaperTitle(this clsvgs_PSkillRelaEN objvgs_PSkillRelaEN, string strPaperTitle, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPaperTitle, 500, convgs_PSkillRela.PaperTitle);
}
objvgs_PSkillRelaEN.PaperTitle = strPaperTitle; //论文标题
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvgs_PSkillRelaEN.dicFldComparisonOp.ContainsKey(convgs_PSkillRela.PaperTitle) == false)
{
objvgs_PSkillRelaEN.dicFldComparisonOp.Add(convgs_PSkillRela.PaperTitle, strComparisonOp);
}
else
{
objvgs_PSkillRelaEN.dicFldComparisonOp[convgs_PSkillRela.PaperTitle] = strComparisonOp;
}
}
return objvgs_PSkillRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvgs_PSkillRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvgs_PSkillRelaEN SetPaperTypeId(this clsvgs_PSkillRelaEN objvgs_PSkillRelaEN, string strPaperTypeId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPaperTypeId, 2, convgs_PSkillRela.PaperTypeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strPaperTypeId, 2, convgs_PSkillRela.PaperTypeId);
}
objvgs_PSkillRelaEN.PaperTypeId = strPaperTypeId; //论文类型Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvgs_PSkillRelaEN.dicFldComparisonOp.ContainsKey(convgs_PSkillRela.PaperTypeId) == false)
{
objvgs_PSkillRelaEN.dicFldComparisonOp.Add(convgs_PSkillRela.PaperTypeId, strComparisonOp);
}
else
{
objvgs_PSkillRelaEN.dicFldComparisonOp[convgs_PSkillRela.PaperTypeId] = strComparisonOp;
}
}
return objvgs_PSkillRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvgs_PSkillRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvgs_PSkillRelaEN SetSectionId(this clsvgs_PSkillRelaEN objvgs_PSkillRelaEN, string strSectionId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strSectionId, 8, convgs_PSkillRela.SectionId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strSectionId, 8, convgs_PSkillRela.SectionId);
}
objvgs_PSkillRelaEN.SectionId = strSectionId; //节Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvgs_PSkillRelaEN.dicFldComparisonOp.ContainsKey(convgs_PSkillRela.SectionId) == false)
{
objvgs_PSkillRelaEN.dicFldComparisonOp.Add(convgs_PSkillRela.SectionId, strComparisonOp);
}
else
{
objvgs_PSkillRelaEN.dicFldComparisonOp[convgs_PSkillRela.SectionId] = strComparisonOp;
}
}
return objvgs_PSkillRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvgs_PSkillRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvgs_PSkillRelaEN SetSectionName(this clsvgs_PSkillRelaEN objvgs_PSkillRelaEN, string strSectionName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strSectionName, 100, convgs_PSkillRela.SectionName);
}
objvgs_PSkillRelaEN.SectionName = strSectionName; //节名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvgs_PSkillRelaEN.dicFldComparisonOp.ContainsKey(convgs_PSkillRela.SectionName) == false)
{
objvgs_PSkillRelaEN.dicFldComparisonOp.Add(convgs_PSkillRela.SectionName, strComparisonOp);
}
else
{
objvgs_PSkillRelaEN.dicFldComparisonOp[convgs_PSkillRela.SectionName] = strComparisonOp;
}
}
return objvgs_PSkillRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvgs_PSkillRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvgs_PSkillRelaEN SetSkillId(this clsvgs_PSkillRelaEN objvgs_PSkillRelaEN, string strSkillId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strSkillId, convgs_PSkillRela.SkillId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strSkillId, 10, convgs_PSkillRela.SkillId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strSkillId, 10, convgs_PSkillRela.SkillId);
}
objvgs_PSkillRelaEN.SkillId = strSkillId; //技能Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvgs_PSkillRelaEN.dicFldComparisonOp.ContainsKey(convgs_PSkillRela.SkillId) == false)
{
objvgs_PSkillRelaEN.dicFldComparisonOp.Add(convgs_PSkillRela.SkillId, strComparisonOp);
}
else
{
objvgs_PSkillRelaEN.dicFldComparisonOp[convgs_PSkillRela.SkillId] = strComparisonOp;
}
}
return objvgs_PSkillRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvgs_PSkillRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvgs_PSkillRelaEN SetUpdDate(this clsvgs_PSkillRelaEN objvgs_PSkillRelaEN, string strUpdDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdDate, 20, convgs_PSkillRela.UpdDate);
}
objvgs_PSkillRelaEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvgs_PSkillRelaEN.dicFldComparisonOp.ContainsKey(convgs_PSkillRela.UpdDate) == false)
{
objvgs_PSkillRelaEN.dicFldComparisonOp.Add(convgs_PSkillRela.UpdDate, strComparisonOp);
}
else
{
objvgs_PSkillRelaEN.dicFldComparisonOp[convgs_PSkillRela.UpdDate] = strComparisonOp;
}
}
return objvgs_PSkillRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvgs_PSkillRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvgs_PSkillRelaEN SetUpdUser(this clsvgs_PSkillRelaEN objvgs_PSkillRelaEN, string strUpdUser, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdUser, 20, convgs_PSkillRela.UpdUser);
}
objvgs_PSkillRelaEN.UpdUser = strUpdUser; //修改人
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvgs_PSkillRelaEN.dicFldComparisonOp.ContainsKey(convgs_PSkillRela.UpdUser) == false)
{
objvgs_PSkillRelaEN.dicFldComparisonOp.Add(convgs_PSkillRela.UpdUser, strComparisonOp);
}
else
{
objvgs_PSkillRelaEN.dicFldComparisonOp[convgs_PSkillRela.UpdUser] = strComparisonOp;
}
}
return objvgs_PSkillRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvgs_PSkillRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvgs_PSkillRelaEN SetMemo(this clsvgs_PSkillRelaEN objvgs_PSkillRelaEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, convgs_PSkillRela.Memo);
}
objvgs_PSkillRelaEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvgs_PSkillRelaEN.dicFldComparisonOp.ContainsKey(convgs_PSkillRela.Memo) == false)
{
objvgs_PSkillRelaEN.dicFldComparisonOp.Add(convgs_PSkillRela.Memo, strComparisonOp);
}
else
{
objvgs_PSkillRelaEN.dicFldComparisonOp[convgs_PSkillRela.Memo] = strComparisonOp;
}
}
return objvgs_PSkillRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvgs_PSkillRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvgs_PSkillRelaEN SetSkillName(this clsvgs_PSkillRelaEN objvgs_PSkillRelaEN, string strSkillName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strSkillName, 200, convgs_PSkillRela.SkillName);
}
objvgs_PSkillRelaEN.SkillName = strSkillName; //技能名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvgs_PSkillRelaEN.dicFldComparisonOp.ContainsKey(convgs_PSkillRela.SkillName) == false)
{
objvgs_PSkillRelaEN.dicFldComparisonOp.Add(convgs_PSkillRela.SkillName, strComparisonOp);
}
else
{
objvgs_PSkillRelaEN.dicFldComparisonOp[convgs_PSkillRela.SkillName] = strComparisonOp;
}
}
return objvgs_PSkillRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvgs_PSkillRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvgs_PSkillRelaEN SetOperationTypeId(this clsvgs_PSkillRelaEN objvgs_PSkillRelaEN, string strOperationTypeId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strOperationTypeId, 4, convgs_PSkillRela.OperationTypeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strOperationTypeId, 4, convgs_PSkillRela.OperationTypeId);
}
objvgs_PSkillRelaEN.OperationTypeId = strOperationTypeId; //操作类型ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvgs_PSkillRelaEN.dicFldComparisonOp.ContainsKey(convgs_PSkillRela.OperationTypeId) == false)
{
objvgs_PSkillRelaEN.dicFldComparisonOp.Add(convgs_PSkillRela.OperationTypeId, strComparisonOp);
}
else
{
objvgs_PSkillRelaEN.dicFldComparisonOp[convgs_PSkillRela.OperationTypeId] = strComparisonOp;
}
}
return objvgs_PSkillRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvgs_PSkillRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvgs_PSkillRelaEN SetOperationTypeName(this clsvgs_PSkillRelaEN objvgs_PSkillRelaEN, string strOperationTypeName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strOperationTypeName, 50, convgs_PSkillRela.OperationTypeName);
}
objvgs_PSkillRelaEN.OperationTypeName = strOperationTypeName; //操作类型名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvgs_PSkillRelaEN.dicFldComparisonOp.ContainsKey(convgs_PSkillRela.OperationTypeName) == false)
{
objvgs_PSkillRelaEN.dicFldComparisonOp.Add(convgs_PSkillRela.OperationTypeName, strComparisonOp);
}
else
{
objvgs_PSkillRelaEN.dicFldComparisonOp[convgs_PSkillRela.OperationTypeName] = strComparisonOp;
}
}
return objvgs_PSkillRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvgs_PSkillRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvgs_PSkillRelaEN SetLevelName(this clsvgs_PSkillRelaEN objvgs_PSkillRelaEN, string strLevelName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strLevelName, 50, convgs_PSkillRela.LevelName);
}
objvgs_PSkillRelaEN.LevelName = strLevelName; //级别名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvgs_PSkillRelaEN.dicFldComparisonOp.ContainsKey(convgs_PSkillRela.LevelName) == false)
{
objvgs_PSkillRelaEN.dicFldComparisonOp.Add(convgs_PSkillRela.LevelName, strComparisonOp);
}
else
{
objvgs_PSkillRelaEN.dicFldComparisonOp[convgs_PSkillRela.LevelName] = strComparisonOp;
}
}
return objvgs_PSkillRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvgs_PSkillRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvgs_PSkillRelaEN SetLevelId(this clsvgs_PSkillRelaEN objvgs_PSkillRelaEN, string strLevelId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strLevelId, 2, convgs_PSkillRela.LevelId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strLevelId, 2, convgs_PSkillRela.LevelId);
}
objvgs_PSkillRelaEN.LevelId = strLevelId; //级别Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvgs_PSkillRelaEN.dicFldComparisonOp.ContainsKey(convgs_PSkillRela.LevelId) == false)
{
objvgs_PSkillRelaEN.dicFldComparisonOp.Add(convgs_PSkillRela.LevelId, strComparisonOp);
}
else
{
objvgs_PSkillRelaEN.dicFldComparisonOp[convgs_PSkillRela.LevelId] = strComparisonOp;
}
}
return objvgs_PSkillRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvgs_PSkillRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvgs_PSkillRelaEN SetProcess(this clsvgs_PSkillRelaEN objvgs_PSkillRelaEN, string strProcess, string strComparisonOp="")
	{
objvgs_PSkillRelaEN.Process = strProcess; //实施过程
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvgs_PSkillRelaEN.dicFldComparisonOp.ContainsKey(convgs_PSkillRela.Process) == false)
{
objvgs_PSkillRelaEN.dicFldComparisonOp.Add(convgs_PSkillRela.Process, strComparisonOp);
}
else
{
objvgs_PSkillRelaEN.dicFldComparisonOp[convgs_PSkillRela.Process] = strComparisonOp;
}
}
return objvgs_PSkillRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvgs_PSkillRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvgs_PSkillRelaEN SetIsSubmit(this clsvgs_PSkillRelaEN objvgs_PSkillRelaEN, bool bolIsSubmit, string strComparisonOp="")
	{
objvgs_PSkillRelaEN.IsSubmit = bolIsSubmit; //是否提交
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvgs_PSkillRelaEN.dicFldComparisonOp.ContainsKey(convgs_PSkillRela.IsSubmit) == false)
{
objvgs_PSkillRelaEN.dicFldComparisonOp.Add(convgs_PSkillRela.IsSubmit, strComparisonOp);
}
else
{
objvgs_PSkillRelaEN.dicFldComparisonOp[convgs_PSkillRela.IsSubmit] = strComparisonOp;
}
}
return objvgs_PSkillRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvgs_PSkillRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvgs_PSkillRelaEN SetOkCount(this clsvgs_PSkillRelaEN objvgs_PSkillRelaEN, int? intOkCount, string strComparisonOp="")
	{
objvgs_PSkillRelaEN.OkCount = intOkCount; //点赞统计
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvgs_PSkillRelaEN.dicFldComparisonOp.ContainsKey(convgs_PSkillRela.OkCount) == false)
{
objvgs_PSkillRelaEN.dicFldComparisonOp.Add(convgs_PSkillRela.OkCount, strComparisonOp);
}
else
{
objvgs_PSkillRelaEN.dicFldComparisonOp[convgs_PSkillRela.OkCount] = strComparisonOp;
}
}
return objvgs_PSkillRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvgs_PSkillRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvgs_PSkillRelaEN SetScore(this clsvgs_PSkillRelaEN objvgs_PSkillRelaEN, float? fltScore, string strComparisonOp="")
	{
objvgs_PSkillRelaEN.Score = fltScore; //评分
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvgs_PSkillRelaEN.dicFldComparisonOp.ContainsKey(convgs_PSkillRela.Score) == false)
{
objvgs_PSkillRelaEN.dicFldComparisonOp.Add(convgs_PSkillRela.Score, strComparisonOp);
}
else
{
objvgs_PSkillRelaEN.dicFldComparisonOp[convgs_PSkillRela.Score] = strComparisonOp;
}
}
return objvgs_PSkillRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvgs_PSkillRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvgs_PSkillRelaEN SetAppraiseCount(this clsvgs_PSkillRelaEN objvgs_PSkillRelaEN, int? intAppraiseCount, string strComparisonOp="")
	{
objvgs_PSkillRelaEN.AppraiseCount = intAppraiseCount; //评论数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvgs_PSkillRelaEN.dicFldComparisonOp.ContainsKey(convgs_PSkillRela.AppraiseCount) == false)
{
objvgs_PSkillRelaEN.dicFldComparisonOp.Add(convgs_PSkillRela.AppraiseCount, strComparisonOp);
}
else
{
objvgs_PSkillRelaEN.dicFldComparisonOp[convgs_PSkillRela.AppraiseCount] = strComparisonOp;
}
}
return objvgs_PSkillRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvgs_PSkillRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvgs_PSkillRelaEN SetStuScore(this clsvgs_PSkillRelaEN objvgs_PSkillRelaEN, float? fltStuScore, string strComparisonOp="")
	{
objvgs_PSkillRelaEN.StuScore = fltStuScore; //学生平均分
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvgs_PSkillRelaEN.dicFldComparisonOp.ContainsKey(convgs_PSkillRela.StuScore) == false)
{
objvgs_PSkillRelaEN.dicFldComparisonOp.Add(convgs_PSkillRela.StuScore, strComparisonOp);
}
else
{
objvgs_PSkillRelaEN.dicFldComparisonOp[convgs_PSkillRela.StuScore] = strComparisonOp;
}
}
return objvgs_PSkillRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvgs_PSkillRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvgs_PSkillRelaEN SetTeaScore(this clsvgs_PSkillRelaEN objvgs_PSkillRelaEN, float? fltTeaScore, string strComparisonOp="")
	{
objvgs_PSkillRelaEN.TeaScore = fltTeaScore; //教师评分
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvgs_PSkillRelaEN.dicFldComparisonOp.ContainsKey(convgs_PSkillRela.TeaScore) == false)
{
objvgs_PSkillRelaEN.dicFldComparisonOp.Add(convgs_PSkillRela.TeaScore, strComparisonOp);
}
else
{
objvgs_PSkillRelaEN.dicFldComparisonOp[convgs_PSkillRela.TeaScore] = strComparisonOp;
}
}
return objvgs_PSkillRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvgs_PSkillRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvgs_PSkillRelaEN SetCitationCount(this clsvgs_PSkillRelaEN objvgs_PSkillRelaEN, int? intCitationCount, string strComparisonOp="")
	{
objvgs_PSkillRelaEN.CitationCount = intCitationCount; //引用统计
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvgs_PSkillRelaEN.dicFldComparisonOp.ContainsKey(convgs_PSkillRela.CitationCount) == false)
{
objvgs_PSkillRelaEN.dicFldComparisonOp.Add(convgs_PSkillRela.CitationCount, strComparisonOp);
}
else
{
objvgs_PSkillRelaEN.dicFldComparisonOp[convgs_PSkillRela.CitationCount] = strComparisonOp;
}
}
return objvgs_PSkillRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvgs_PSkillRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvgs_PSkillRelaEN SetVersionCount(this clsvgs_PSkillRelaEN objvgs_PSkillRelaEN, int? intVersionCount, string strComparisonOp="")
	{
objvgs_PSkillRelaEN.VersionCount = intVersionCount; //版本统计
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvgs_PSkillRelaEN.dicFldComparisonOp.ContainsKey(convgs_PSkillRela.VersionCount) == false)
{
objvgs_PSkillRelaEN.dicFldComparisonOp.Add(convgs_PSkillRela.VersionCount, strComparisonOp);
}
else
{
objvgs_PSkillRelaEN.dicFldComparisonOp[convgs_PSkillRela.VersionCount] = strComparisonOp;
}
}
return objvgs_PSkillRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvgs_PSkillRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvgs_PSkillRelaEN SetSkillUserId(this clsvgs_PSkillRelaEN objvgs_PSkillRelaEN, string strSkillUserId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strSkillUserId, 20, convgs_PSkillRela.SkillUserId);
}
objvgs_PSkillRelaEN.SkillUserId = strSkillUserId; //SkillUserId
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvgs_PSkillRelaEN.dicFldComparisonOp.ContainsKey(convgs_PSkillRela.SkillUserId) == false)
{
objvgs_PSkillRelaEN.dicFldComparisonOp.Add(convgs_PSkillRela.SkillUserId, strComparisonOp);
}
else
{
objvgs_PSkillRelaEN.dicFldComparisonOp[convgs_PSkillRela.SkillUserId] = strComparisonOp;
}
}
return objvgs_PSkillRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvgs_PSkillRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvgs_PSkillRelaEN SetSkillDate(this clsvgs_PSkillRelaEN objvgs_PSkillRelaEN, string strSkillDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strSkillDate, 20, convgs_PSkillRela.SkillDate);
}
objvgs_PSkillRelaEN.SkillDate = strSkillDate; //SkillDate
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvgs_PSkillRelaEN.dicFldComparisonOp.ContainsKey(convgs_PSkillRela.SkillDate) == false)
{
objvgs_PSkillRelaEN.dicFldComparisonOp.Add(convgs_PSkillRela.SkillDate, strComparisonOp);
}
else
{
objvgs_PSkillRelaEN.dicFldComparisonOp[convgs_PSkillRela.SkillDate] = strComparisonOp;
}
}
return objvgs_PSkillRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvgs_PSkillRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvgs_PSkillRelaEN SetCreateDate(this clsvgs_PSkillRelaEN objvgs_PSkillRelaEN, string strCreateDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCreateDate, 20, convgs_PSkillRela.CreateDate);
}
objvgs_PSkillRelaEN.CreateDate = strCreateDate; //建立日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvgs_PSkillRelaEN.dicFldComparisonOp.ContainsKey(convgs_PSkillRela.CreateDate) == false)
{
objvgs_PSkillRelaEN.dicFldComparisonOp.Add(convgs_PSkillRela.CreateDate, strComparisonOp);
}
else
{
objvgs_PSkillRelaEN.dicFldComparisonOp[convgs_PSkillRela.CreateDate] = strComparisonOp;
}
}
return objvgs_PSkillRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvgs_PSkillRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvgs_PSkillRelaEN SetShareId(this clsvgs_PSkillRelaEN objvgs_PSkillRelaEN, string strShareId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strShareId, 2, convgs_PSkillRela.ShareId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strShareId, 2, convgs_PSkillRela.ShareId);
}
objvgs_PSkillRelaEN.ShareId = strShareId; //分享Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvgs_PSkillRelaEN.dicFldComparisonOp.ContainsKey(convgs_PSkillRela.ShareId) == false)
{
objvgs_PSkillRelaEN.dicFldComparisonOp.Add(convgs_PSkillRela.ShareId, strComparisonOp);
}
else
{
objvgs_PSkillRelaEN.dicFldComparisonOp[convgs_PSkillRela.ShareId] = strComparisonOp;
}
}
return objvgs_PSkillRelaEN;
	}

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CopyObj)
 /// </summary>
 /// <param name = "objvgs_PSkillRelaENS">源对象</param>
 /// <param name = "objvgs_PSkillRelaENT">目标对象</param>
 public static void CopyTo(this clsvgs_PSkillRelaEN objvgs_PSkillRelaENS, clsvgs_PSkillRelaEN objvgs_PSkillRelaENT)
{
try
{
objvgs_PSkillRelaENT.mId = objvgs_PSkillRelaENS.mId; //mId
objvgs_PSkillRelaENT.PaperId = objvgs_PSkillRelaENS.PaperId; //论文Id
objvgs_PSkillRelaENT.PaperTitle = objvgs_PSkillRelaENS.PaperTitle; //论文标题
objvgs_PSkillRelaENT.PaperTypeId = objvgs_PSkillRelaENS.PaperTypeId; //论文类型Id
objvgs_PSkillRelaENT.SectionId = objvgs_PSkillRelaENS.SectionId; //节Id
objvgs_PSkillRelaENT.SectionName = objvgs_PSkillRelaENS.SectionName; //节名
objvgs_PSkillRelaENT.SkillId = objvgs_PSkillRelaENS.SkillId; //技能Id
objvgs_PSkillRelaENT.UpdDate = objvgs_PSkillRelaENS.UpdDate; //修改日期
objvgs_PSkillRelaENT.UpdUser = objvgs_PSkillRelaENS.UpdUser; //修改人
objvgs_PSkillRelaENT.Memo = objvgs_PSkillRelaENS.Memo; //备注
objvgs_PSkillRelaENT.SkillName = objvgs_PSkillRelaENS.SkillName; //技能名称
objvgs_PSkillRelaENT.OperationTypeId = objvgs_PSkillRelaENS.OperationTypeId; //操作类型ID
objvgs_PSkillRelaENT.OperationTypeName = objvgs_PSkillRelaENS.OperationTypeName; //操作类型名
objvgs_PSkillRelaENT.LevelName = objvgs_PSkillRelaENS.LevelName; //级别名称
objvgs_PSkillRelaENT.LevelId = objvgs_PSkillRelaENS.LevelId; //级别Id
objvgs_PSkillRelaENT.Process = objvgs_PSkillRelaENS.Process; //实施过程
objvgs_PSkillRelaENT.IsSubmit = objvgs_PSkillRelaENS.IsSubmit; //是否提交
objvgs_PSkillRelaENT.OkCount = objvgs_PSkillRelaENS.OkCount; //点赞统计
objvgs_PSkillRelaENT.Score = objvgs_PSkillRelaENS.Score; //评分
objvgs_PSkillRelaENT.AppraiseCount = objvgs_PSkillRelaENS.AppraiseCount; //评论数
objvgs_PSkillRelaENT.StuScore = objvgs_PSkillRelaENS.StuScore; //学生平均分
objvgs_PSkillRelaENT.TeaScore = objvgs_PSkillRelaENS.TeaScore; //教师评分
objvgs_PSkillRelaENT.CitationCount = objvgs_PSkillRelaENS.CitationCount; //引用统计
objvgs_PSkillRelaENT.VersionCount = objvgs_PSkillRelaENS.VersionCount; //版本统计
objvgs_PSkillRelaENT.SkillUserId = objvgs_PSkillRelaENS.SkillUserId; //SkillUserId
objvgs_PSkillRelaENT.SkillDate = objvgs_PSkillRelaENS.SkillDate; //SkillDate
objvgs_PSkillRelaENT.CreateDate = objvgs_PSkillRelaENS.CreateDate; //建立日期
objvgs_PSkillRelaENT.ShareId = objvgs_PSkillRelaENS.ShareId; //分享Id
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
 /// <param name = "objvgs_PSkillRelaENS">源对象</param>
 /// <returns>目标对象=>clsvgs_PSkillRelaEN:objvgs_PSkillRelaENT</returns>
 public static clsvgs_PSkillRelaEN CopyTo(this clsvgs_PSkillRelaEN objvgs_PSkillRelaENS)
{
try
{
 clsvgs_PSkillRelaEN objvgs_PSkillRelaENT = new clsvgs_PSkillRelaEN()
{
mId = objvgs_PSkillRelaENS.mId, //mId
PaperId = objvgs_PSkillRelaENS.PaperId, //论文Id
PaperTitle = objvgs_PSkillRelaENS.PaperTitle, //论文标题
PaperTypeId = objvgs_PSkillRelaENS.PaperTypeId, //论文类型Id
SectionId = objvgs_PSkillRelaENS.SectionId, //节Id
SectionName = objvgs_PSkillRelaENS.SectionName, //节名
SkillId = objvgs_PSkillRelaENS.SkillId, //技能Id
UpdDate = objvgs_PSkillRelaENS.UpdDate, //修改日期
UpdUser = objvgs_PSkillRelaENS.UpdUser, //修改人
Memo = objvgs_PSkillRelaENS.Memo, //备注
SkillName = objvgs_PSkillRelaENS.SkillName, //技能名称
OperationTypeId = objvgs_PSkillRelaENS.OperationTypeId, //操作类型ID
OperationTypeName = objvgs_PSkillRelaENS.OperationTypeName, //操作类型名
LevelName = objvgs_PSkillRelaENS.LevelName, //级别名称
LevelId = objvgs_PSkillRelaENS.LevelId, //级别Id
Process = objvgs_PSkillRelaENS.Process, //实施过程
IsSubmit = objvgs_PSkillRelaENS.IsSubmit, //是否提交
OkCount = objvgs_PSkillRelaENS.OkCount, //点赞统计
Score = objvgs_PSkillRelaENS.Score, //评分
AppraiseCount = objvgs_PSkillRelaENS.AppraiseCount, //评论数
StuScore = objvgs_PSkillRelaENS.StuScore, //学生平均分
TeaScore = objvgs_PSkillRelaENS.TeaScore, //教师评分
CitationCount = objvgs_PSkillRelaENS.CitationCount, //引用统计
VersionCount = objvgs_PSkillRelaENS.VersionCount, //版本统计
SkillUserId = objvgs_PSkillRelaENS.SkillUserId, //SkillUserId
SkillDate = objvgs_PSkillRelaENS.SkillDate, //SkillDate
CreateDate = objvgs_PSkillRelaENS.CreateDate, //建立日期
ShareId = objvgs_PSkillRelaENS.ShareId, //分享Id
};
 return objvgs_PSkillRelaENT;
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
public static void CheckProperty4Condition(this clsvgs_PSkillRelaEN objvgs_PSkillRelaEN)
{
 clsvgs_PSkillRelaBL.vgs_PSkillRelaDA.CheckProperty4Condition(objvgs_PSkillRelaEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvgs_PSkillRelaEN objvgs_PSkillRelaCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvgs_PSkillRelaCond.IsUpdated(convgs_PSkillRela.mId) == true)
{
string strComparisonOpmId = objvgs_PSkillRelaCond.dicFldComparisonOp[convgs_PSkillRela.mId];
strWhereCond += string.Format(" And {0} {2} {1}", convgs_PSkillRela.mId, objvgs_PSkillRelaCond.mId, strComparisonOpmId);
}
if (objvgs_PSkillRelaCond.IsUpdated(convgs_PSkillRela.PaperId) == true)
{
string strComparisonOpPaperId = objvgs_PSkillRelaCond.dicFldComparisonOp[convgs_PSkillRela.PaperId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convgs_PSkillRela.PaperId, objvgs_PSkillRelaCond.PaperId, strComparisonOpPaperId);
}
if (objvgs_PSkillRelaCond.IsUpdated(convgs_PSkillRela.PaperTitle) == true)
{
string strComparisonOpPaperTitle = objvgs_PSkillRelaCond.dicFldComparisonOp[convgs_PSkillRela.PaperTitle];
strWhereCond += string.Format(" And {0} {2} '{1}'", convgs_PSkillRela.PaperTitle, objvgs_PSkillRelaCond.PaperTitle, strComparisonOpPaperTitle);
}
if (objvgs_PSkillRelaCond.IsUpdated(convgs_PSkillRela.PaperTypeId) == true)
{
string strComparisonOpPaperTypeId = objvgs_PSkillRelaCond.dicFldComparisonOp[convgs_PSkillRela.PaperTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convgs_PSkillRela.PaperTypeId, objvgs_PSkillRelaCond.PaperTypeId, strComparisonOpPaperTypeId);
}
if (objvgs_PSkillRelaCond.IsUpdated(convgs_PSkillRela.SectionId) == true)
{
string strComparisonOpSectionId = objvgs_PSkillRelaCond.dicFldComparisonOp[convgs_PSkillRela.SectionId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convgs_PSkillRela.SectionId, objvgs_PSkillRelaCond.SectionId, strComparisonOpSectionId);
}
if (objvgs_PSkillRelaCond.IsUpdated(convgs_PSkillRela.SectionName) == true)
{
string strComparisonOpSectionName = objvgs_PSkillRelaCond.dicFldComparisonOp[convgs_PSkillRela.SectionName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convgs_PSkillRela.SectionName, objvgs_PSkillRelaCond.SectionName, strComparisonOpSectionName);
}
if (objvgs_PSkillRelaCond.IsUpdated(convgs_PSkillRela.SkillId) == true)
{
string strComparisonOpSkillId = objvgs_PSkillRelaCond.dicFldComparisonOp[convgs_PSkillRela.SkillId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convgs_PSkillRela.SkillId, objvgs_PSkillRelaCond.SkillId, strComparisonOpSkillId);
}
if (objvgs_PSkillRelaCond.IsUpdated(convgs_PSkillRela.UpdDate) == true)
{
string strComparisonOpUpdDate = objvgs_PSkillRelaCond.dicFldComparisonOp[convgs_PSkillRela.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convgs_PSkillRela.UpdDate, objvgs_PSkillRelaCond.UpdDate, strComparisonOpUpdDate);
}
if (objvgs_PSkillRelaCond.IsUpdated(convgs_PSkillRela.UpdUser) == true)
{
string strComparisonOpUpdUser = objvgs_PSkillRelaCond.dicFldComparisonOp[convgs_PSkillRela.UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", convgs_PSkillRela.UpdUser, objvgs_PSkillRelaCond.UpdUser, strComparisonOpUpdUser);
}
if (objvgs_PSkillRelaCond.IsUpdated(convgs_PSkillRela.Memo) == true)
{
string strComparisonOpMemo = objvgs_PSkillRelaCond.dicFldComparisonOp[convgs_PSkillRela.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convgs_PSkillRela.Memo, objvgs_PSkillRelaCond.Memo, strComparisonOpMemo);
}
if (objvgs_PSkillRelaCond.IsUpdated(convgs_PSkillRela.SkillName) == true)
{
string strComparisonOpSkillName = objvgs_PSkillRelaCond.dicFldComparisonOp[convgs_PSkillRela.SkillName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convgs_PSkillRela.SkillName, objvgs_PSkillRelaCond.SkillName, strComparisonOpSkillName);
}
if (objvgs_PSkillRelaCond.IsUpdated(convgs_PSkillRela.OperationTypeId) == true)
{
string strComparisonOpOperationTypeId = objvgs_PSkillRelaCond.dicFldComparisonOp[convgs_PSkillRela.OperationTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convgs_PSkillRela.OperationTypeId, objvgs_PSkillRelaCond.OperationTypeId, strComparisonOpOperationTypeId);
}
if (objvgs_PSkillRelaCond.IsUpdated(convgs_PSkillRela.OperationTypeName) == true)
{
string strComparisonOpOperationTypeName = objvgs_PSkillRelaCond.dicFldComparisonOp[convgs_PSkillRela.OperationTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convgs_PSkillRela.OperationTypeName, objvgs_PSkillRelaCond.OperationTypeName, strComparisonOpOperationTypeName);
}
if (objvgs_PSkillRelaCond.IsUpdated(convgs_PSkillRela.LevelName) == true)
{
string strComparisonOpLevelName = objvgs_PSkillRelaCond.dicFldComparisonOp[convgs_PSkillRela.LevelName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convgs_PSkillRela.LevelName, objvgs_PSkillRelaCond.LevelName, strComparisonOpLevelName);
}
if (objvgs_PSkillRelaCond.IsUpdated(convgs_PSkillRela.LevelId) == true)
{
string strComparisonOpLevelId = objvgs_PSkillRelaCond.dicFldComparisonOp[convgs_PSkillRela.LevelId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convgs_PSkillRela.LevelId, objvgs_PSkillRelaCond.LevelId, strComparisonOpLevelId);
}
//数据类型string(text)在函数:[AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj]中没有处理!
if (objvgs_PSkillRelaCond.IsUpdated(convgs_PSkillRela.IsSubmit) == true)
{
if (objvgs_PSkillRelaCond.IsSubmit == true)
{
strWhereCond += string.Format(" And {0} = '1'", convgs_PSkillRela.IsSubmit);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convgs_PSkillRela.IsSubmit);
}
}
if (objvgs_PSkillRelaCond.IsUpdated(convgs_PSkillRela.OkCount) == true)
{
string strComparisonOpOkCount = objvgs_PSkillRelaCond.dicFldComparisonOp[convgs_PSkillRela.OkCount];
strWhereCond += string.Format(" And {0} {2} {1}", convgs_PSkillRela.OkCount, objvgs_PSkillRelaCond.OkCount, strComparisonOpOkCount);
}
if (objvgs_PSkillRelaCond.IsUpdated(convgs_PSkillRela.Score) == true)
{
string strComparisonOpScore = objvgs_PSkillRelaCond.dicFldComparisonOp[convgs_PSkillRela.Score];
strWhereCond += string.Format(" And {0} {2} {1}", convgs_PSkillRela.Score, objvgs_PSkillRelaCond.Score, strComparisonOpScore);
}
if (objvgs_PSkillRelaCond.IsUpdated(convgs_PSkillRela.AppraiseCount) == true)
{
string strComparisonOpAppraiseCount = objvgs_PSkillRelaCond.dicFldComparisonOp[convgs_PSkillRela.AppraiseCount];
strWhereCond += string.Format(" And {0} {2} {1}", convgs_PSkillRela.AppraiseCount, objvgs_PSkillRelaCond.AppraiseCount, strComparisonOpAppraiseCount);
}
if (objvgs_PSkillRelaCond.IsUpdated(convgs_PSkillRela.StuScore) == true)
{
string strComparisonOpStuScore = objvgs_PSkillRelaCond.dicFldComparisonOp[convgs_PSkillRela.StuScore];
strWhereCond += string.Format(" And {0} {2} {1}", convgs_PSkillRela.StuScore, objvgs_PSkillRelaCond.StuScore, strComparisonOpStuScore);
}
if (objvgs_PSkillRelaCond.IsUpdated(convgs_PSkillRela.TeaScore) == true)
{
string strComparisonOpTeaScore = objvgs_PSkillRelaCond.dicFldComparisonOp[convgs_PSkillRela.TeaScore];
strWhereCond += string.Format(" And {0} {2} {1}", convgs_PSkillRela.TeaScore, objvgs_PSkillRelaCond.TeaScore, strComparisonOpTeaScore);
}
if (objvgs_PSkillRelaCond.IsUpdated(convgs_PSkillRela.CitationCount) == true)
{
string strComparisonOpCitationCount = objvgs_PSkillRelaCond.dicFldComparisonOp[convgs_PSkillRela.CitationCount];
strWhereCond += string.Format(" And {0} {2} {1}", convgs_PSkillRela.CitationCount, objvgs_PSkillRelaCond.CitationCount, strComparisonOpCitationCount);
}
if (objvgs_PSkillRelaCond.IsUpdated(convgs_PSkillRela.VersionCount) == true)
{
string strComparisonOpVersionCount = objvgs_PSkillRelaCond.dicFldComparisonOp[convgs_PSkillRela.VersionCount];
strWhereCond += string.Format(" And {0} {2} {1}", convgs_PSkillRela.VersionCount, objvgs_PSkillRelaCond.VersionCount, strComparisonOpVersionCount);
}
if (objvgs_PSkillRelaCond.IsUpdated(convgs_PSkillRela.SkillUserId) == true)
{
string strComparisonOpSkillUserId = objvgs_PSkillRelaCond.dicFldComparisonOp[convgs_PSkillRela.SkillUserId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convgs_PSkillRela.SkillUserId, objvgs_PSkillRelaCond.SkillUserId, strComparisonOpSkillUserId);
}
if (objvgs_PSkillRelaCond.IsUpdated(convgs_PSkillRela.SkillDate) == true)
{
string strComparisonOpSkillDate = objvgs_PSkillRelaCond.dicFldComparisonOp[convgs_PSkillRela.SkillDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convgs_PSkillRela.SkillDate, objvgs_PSkillRelaCond.SkillDate, strComparisonOpSkillDate);
}
if (objvgs_PSkillRelaCond.IsUpdated(convgs_PSkillRela.CreateDate) == true)
{
string strComparisonOpCreateDate = objvgs_PSkillRelaCond.dicFldComparisonOp[convgs_PSkillRela.CreateDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convgs_PSkillRela.CreateDate, objvgs_PSkillRelaCond.CreateDate, strComparisonOpCreateDate);
}
if (objvgs_PSkillRelaCond.IsUpdated(convgs_PSkillRela.ShareId) == true)
{
string strComparisonOpShareId = objvgs_PSkillRelaCond.dicFldComparisonOp[convgs_PSkillRela.ShareId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convgs_PSkillRela.ShareId, objvgs_PSkillRelaCond.ShareId, strComparisonOpShareId);
}
 return strWhereCond;
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_vgs_PSkillRela
{
public virtual bool UpdRelaTabDate(long lngmId, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// 论文技能关系视图(vgs_PSkillRela)
 /// 数据源类型:视图
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsvgs_PSkillRelaBL
{
public static RelatedActions_vgs_PSkillRela relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsvgs_PSkillRelaDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsvgs_PSkillRelaDA vgs_PSkillRelaDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsvgs_PSkillRelaDA();
}
return uniqueInstance;
}
}

 /// <summary>
 /// 类的构造函数
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ClassConstructor1)
 /// </summary>
 public clsvgs_PSkillRelaBL()
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
if (string.IsNullOrEmpty(clsvgs_PSkillRelaEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvgs_PSkillRelaEN._ConnectString);
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
public static DataTable GetDataTable_vgs_PSkillRela(string strWhereCond)
{
DataTable objDT;
try
{
objDT = vgs_PSkillRelaDA.GetDataTable_vgs_PSkillRela(strWhereCond);
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
objDT = vgs_PSkillRelaDA.GetDataTable(strWhereCond);
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
objDT = vgs_PSkillRelaDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = vgs_PSkillRelaDA.GetDataTable(strWhereCond, strTabName);
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
objDT = vgs_PSkillRelaDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = vgs_PSkillRelaDA.GetDataTable_Top(objTopPara);
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
objDT = vgs_PSkillRelaDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = vgs_PSkillRelaDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = vgs_PSkillRelaDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
public static List<clsvgs_PSkillRelaEN> GetObjLstByMIdLst(List<long> arrMIdLst)
{
List<clsvgs_PSkillRelaEN> arrObjLst = new List<clsvgs_PSkillRelaEN>(); 
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
	clsvgs_PSkillRelaEN objvgs_PSkillRelaEN = new clsvgs_PSkillRelaEN();
try
{
objvgs_PSkillRelaEN.mId = Int32.Parse(objRow[convgs_PSkillRela.mId].ToString().Trim()); //mId
objvgs_PSkillRelaEN.PaperId = objRow[convgs_PSkillRela.PaperId].ToString().Trim(); //论文Id
objvgs_PSkillRelaEN.PaperTitle = objRow[convgs_PSkillRela.PaperTitle] == DBNull.Value ? null : objRow[convgs_PSkillRela.PaperTitle].ToString().Trim(); //论文标题
objvgs_PSkillRelaEN.PaperTypeId = objRow[convgs_PSkillRela.PaperTypeId] == DBNull.Value ? null : objRow[convgs_PSkillRela.PaperTypeId].ToString().Trim(); //论文类型Id
objvgs_PSkillRelaEN.SectionId = objRow[convgs_PSkillRela.SectionId] == DBNull.Value ? null : objRow[convgs_PSkillRela.SectionId].ToString().Trim(); //节Id
objvgs_PSkillRelaEN.SectionName = objRow[convgs_PSkillRela.SectionName] == DBNull.Value ? null : objRow[convgs_PSkillRela.SectionName].ToString().Trim(); //节名
objvgs_PSkillRelaEN.SkillId = objRow[convgs_PSkillRela.SkillId].ToString().Trim(); //技能Id
objvgs_PSkillRelaEN.UpdDate = objRow[convgs_PSkillRela.UpdDate] == DBNull.Value ? null : objRow[convgs_PSkillRela.UpdDate].ToString().Trim(); //修改日期
objvgs_PSkillRelaEN.UpdUser = objRow[convgs_PSkillRela.UpdUser] == DBNull.Value ? null : objRow[convgs_PSkillRela.UpdUser].ToString().Trim(); //修改人
objvgs_PSkillRelaEN.Memo = objRow[convgs_PSkillRela.Memo] == DBNull.Value ? null : objRow[convgs_PSkillRela.Memo].ToString().Trim(); //备注
objvgs_PSkillRelaEN.SkillName = objRow[convgs_PSkillRela.SkillName] == DBNull.Value ? null : objRow[convgs_PSkillRela.SkillName].ToString().Trim(); //技能名称
objvgs_PSkillRelaEN.OperationTypeId = objRow[convgs_PSkillRela.OperationTypeId] == DBNull.Value ? null : objRow[convgs_PSkillRela.OperationTypeId].ToString().Trim(); //操作类型ID
objvgs_PSkillRelaEN.OperationTypeName = objRow[convgs_PSkillRela.OperationTypeName] == DBNull.Value ? null : objRow[convgs_PSkillRela.OperationTypeName].ToString().Trim(); //操作类型名
objvgs_PSkillRelaEN.LevelName = objRow[convgs_PSkillRela.LevelName] == DBNull.Value ? null : objRow[convgs_PSkillRela.LevelName].ToString().Trim(); //级别名称
objvgs_PSkillRelaEN.LevelId = objRow[convgs_PSkillRela.LevelId] == DBNull.Value ? null : objRow[convgs_PSkillRela.LevelId].ToString().Trim(); //级别Id
objvgs_PSkillRelaEN.Process = objRow[convgs_PSkillRela.Process] == DBNull.Value ? null : objRow[convgs_PSkillRela.Process].ToString().Trim(); //实施过程
objvgs_PSkillRelaEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[convgs_PSkillRela.IsSubmit].ToString().Trim()); //是否提交
objvgs_PSkillRelaEN.OkCount = objRow[convgs_PSkillRela.OkCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convgs_PSkillRela.OkCount].ToString().Trim()); //点赞统计
objvgs_PSkillRelaEN.Score = objRow[convgs_PSkillRela.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convgs_PSkillRela.Score].ToString().Trim()); //评分
objvgs_PSkillRelaEN.AppraiseCount = objRow[convgs_PSkillRela.AppraiseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convgs_PSkillRela.AppraiseCount].ToString().Trim()); //评论数
objvgs_PSkillRelaEN.StuScore = objRow[convgs_PSkillRela.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convgs_PSkillRela.StuScore].ToString().Trim()); //学生平均分
objvgs_PSkillRelaEN.TeaScore = objRow[convgs_PSkillRela.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convgs_PSkillRela.TeaScore].ToString().Trim()); //教师评分
objvgs_PSkillRelaEN.CitationCount = objRow[convgs_PSkillRela.CitationCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convgs_PSkillRela.CitationCount].ToString().Trim()); //引用统计
objvgs_PSkillRelaEN.VersionCount = objRow[convgs_PSkillRela.VersionCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convgs_PSkillRela.VersionCount].ToString().Trim()); //版本统计
objvgs_PSkillRelaEN.SkillUserId = objRow[convgs_PSkillRela.SkillUserId] == DBNull.Value ? null : objRow[convgs_PSkillRela.SkillUserId].ToString().Trim(); //SkillUserId
objvgs_PSkillRelaEN.SkillDate = objRow[convgs_PSkillRela.SkillDate] == DBNull.Value ? null : objRow[convgs_PSkillRela.SkillDate].ToString().Trim(); //SkillDate
objvgs_PSkillRelaEN.CreateDate = objRow[convgs_PSkillRela.CreateDate] == DBNull.Value ? null : objRow[convgs_PSkillRela.CreateDate].ToString().Trim(); //建立日期
objvgs_PSkillRelaEN.ShareId = objRow[convgs_PSkillRela.ShareId] == DBNull.Value ? null : objRow[convgs_PSkillRela.ShareId].ToString().Trim(); //分享Id
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvgs_PSkillRelaEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvgs_PSkillRelaEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrMIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsvgs_PSkillRelaEN> GetObjLstByMIdLstCache(List<long> arrMIdLst)
{
string strKey = string.Format("{0}", clsvgs_PSkillRelaEN._CurrTabName);
List<clsvgs_PSkillRelaEN> arrvgs_PSkillRelaObjLstCache = GetObjLstCache();
IEnumerable <clsvgs_PSkillRelaEN> arrvgs_PSkillRelaObjLst_Sel =
arrvgs_PSkillRelaObjLstCache
.Where(x => arrMIdLst.Contains(x.mId));
return arrvgs_PSkillRelaObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvgs_PSkillRelaEN> GetObjLst(string strWhereCond)
{
List<clsvgs_PSkillRelaEN> arrObjLst = new List<clsvgs_PSkillRelaEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvgs_PSkillRelaEN objvgs_PSkillRelaEN = new clsvgs_PSkillRelaEN();
try
{
objvgs_PSkillRelaEN.mId = Int32.Parse(objRow[convgs_PSkillRela.mId].ToString().Trim()); //mId
objvgs_PSkillRelaEN.PaperId = objRow[convgs_PSkillRela.PaperId].ToString().Trim(); //论文Id
objvgs_PSkillRelaEN.PaperTitle = objRow[convgs_PSkillRela.PaperTitle] == DBNull.Value ? null : objRow[convgs_PSkillRela.PaperTitle].ToString().Trim(); //论文标题
objvgs_PSkillRelaEN.PaperTypeId = objRow[convgs_PSkillRela.PaperTypeId] == DBNull.Value ? null : objRow[convgs_PSkillRela.PaperTypeId].ToString().Trim(); //论文类型Id
objvgs_PSkillRelaEN.SectionId = objRow[convgs_PSkillRela.SectionId] == DBNull.Value ? null : objRow[convgs_PSkillRela.SectionId].ToString().Trim(); //节Id
objvgs_PSkillRelaEN.SectionName = objRow[convgs_PSkillRela.SectionName] == DBNull.Value ? null : objRow[convgs_PSkillRela.SectionName].ToString().Trim(); //节名
objvgs_PSkillRelaEN.SkillId = objRow[convgs_PSkillRela.SkillId].ToString().Trim(); //技能Id
objvgs_PSkillRelaEN.UpdDate = objRow[convgs_PSkillRela.UpdDate] == DBNull.Value ? null : objRow[convgs_PSkillRela.UpdDate].ToString().Trim(); //修改日期
objvgs_PSkillRelaEN.UpdUser = objRow[convgs_PSkillRela.UpdUser] == DBNull.Value ? null : objRow[convgs_PSkillRela.UpdUser].ToString().Trim(); //修改人
objvgs_PSkillRelaEN.Memo = objRow[convgs_PSkillRela.Memo] == DBNull.Value ? null : objRow[convgs_PSkillRela.Memo].ToString().Trim(); //备注
objvgs_PSkillRelaEN.SkillName = objRow[convgs_PSkillRela.SkillName] == DBNull.Value ? null : objRow[convgs_PSkillRela.SkillName].ToString().Trim(); //技能名称
objvgs_PSkillRelaEN.OperationTypeId = objRow[convgs_PSkillRela.OperationTypeId] == DBNull.Value ? null : objRow[convgs_PSkillRela.OperationTypeId].ToString().Trim(); //操作类型ID
objvgs_PSkillRelaEN.OperationTypeName = objRow[convgs_PSkillRela.OperationTypeName] == DBNull.Value ? null : objRow[convgs_PSkillRela.OperationTypeName].ToString().Trim(); //操作类型名
objvgs_PSkillRelaEN.LevelName = objRow[convgs_PSkillRela.LevelName] == DBNull.Value ? null : objRow[convgs_PSkillRela.LevelName].ToString().Trim(); //级别名称
objvgs_PSkillRelaEN.LevelId = objRow[convgs_PSkillRela.LevelId] == DBNull.Value ? null : objRow[convgs_PSkillRela.LevelId].ToString().Trim(); //级别Id
objvgs_PSkillRelaEN.Process = objRow[convgs_PSkillRela.Process] == DBNull.Value ? null : objRow[convgs_PSkillRela.Process].ToString().Trim(); //实施过程
objvgs_PSkillRelaEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[convgs_PSkillRela.IsSubmit].ToString().Trim()); //是否提交
objvgs_PSkillRelaEN.OkCount = objRow[convgs_PSkillRela.OkCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convgs_PSkillRela.OkCount].ToString().Trim()); //点赞统计
objvgs_PSkillRelaEN.Score = objRow[convgs_PSkillRela.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convgs_PSkillRela.Score].ToString().Trim()); //评分
objvgs_PSkillRelaEN.AppraiseCount = objRow[convgs_PSkillRela.AppraiseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convgs_PSkillRela.AppraiseCount].ToString().Trim()); //评论数
objvgs_PSkillRelaEN.StuScore = objRow[convgs_PSkillRela.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convgs_PSkillRela.StuScore].ToString().Trim()); //学生平均分
objvgs_PSkillRelaEN.TeaScore = objRow[convgs_PSkillRela.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convgs_PSkillRela.TeaScore].ToString().Trim()); //教师评分
objvgs_PSkillRelaEN.CitationCount = objRow[convgs_PSkillRela.CitationCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convgs_PSkillRela.CitationCount].ToString().Trim()); //引用统计
objvgs_PSkillRelaEN.VersionCount = objRow[convgs_PSkillRela.VersionCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convgs_PSkillRela.VersionCount].ToString().Trim()); //版本统计
objvgs_PSkillRelaEN.SkillUserId = objRow[convgs_PSkillRela.SkillUserId] == DBNull.Value ? null : objRow[convgs_PSkillRela.SkillUserId].ToString().Trim(); //SkillUserId
objvgs_PSkillRelaEN.SkillDate = objRow[convgs_PSkillRela.SkillDate] == DBNull.Value ? null : objRow[convgs_PSkillRela.SkillDate].ToString().Trim(); //SkillDate
objvgs_PSkillRelaEN.CreateDate = objRow[convgs_PSkillRela.CreateDate] == DBNull.Value ? null : objRow[convgs_PSkillRela.CreateDate].ToString().Trim(); //建立日期
objvgs_PSkillRelaEN.ShareId = objRow[convgs_PSkillRela.ShareId] == DBNull.Value ? null : objRow[convgs_PSkillRela.ShareId].ToString().Trim(); //分享Id
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvgs_PSkillRelaEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvgs_PSkillRelaEN);
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
public static List<clsvgs_PSkillRelaEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsvgs_PSkillRelaEN> arrObjLst = new List<clsvgs_PSkillRelaEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvgs_PSkillRelaEN objvgs_PSkillRelaEN = new clsvgs_PSkillRelaEN();
try
{
objvgs_PSkillRelaEN.mId = Int32.Parse(objRow[convgs_PSkillRela.mId].ToString().Trim()); //mId
objvgs_PSkillRelaEN.PaperId = objRow[convgs_PSkillRela.PaperId].ToString().Trim(); //论文Id
objvgs_PSkillRelaEN.PaperTitle = objRow[convgs_PSkillRela.PaperTitle] == DBNull.Value ? null : objRow[convgs_PSkillRela.PaperTitle].ToString().Trim(); //论文标题
objvgs_PSkillRelaEN.PaperTypeId = objRow[convgs_PSkillRela.PaperTypeId] == DBNull.Value ? null : objRow[convgs_PSkillRela.PaperTypeId].ToString().Trim(); //论文类型Id
objvgs_PSkillRelaEN.SectionId = objRow[convgs_PSkillRela.SectionId] == DBNull.Value ? null : objRow[convgs_PSkillRela.SectionId].ToString().Trim(); //节Id
objvgs_PSkillRelaEN.SectionName = objRow[convgs_PSkillRela.SectionName] == DBNull.Value ? null : objRow[convgs_PSkillRela.SectionName].ToString().Trim(); //节名
objvgs_PSkillRelaEN.SkillId = objRow[convgs_PSkillRela.SkillId].ToString().Trim(); //技能Id
objvgs_PSkillRelaEN.UpdDate = objRow[convgs_PSkillRela.UpdDate] == DBNull.Value ? null : objRow[convgs_PSkillRela.UpdDate].ToString().Trim(); //修改日期
objvgs_PSkillRelaEN.UpdUser = objRow[convgs_PSkillRela.UpdUser] == DBNull.Value ? null : objRow[convgs_PSkillRela.UpdUser].ToString().Trim(); //修改人
objvgs_PSkillRelaEN.Memo = objRow[convgs_PSkillRela.Memo] == DBNull.Value ? null : objRow[convgs_PSkillRela.Memo].ToString().Trim(); //备注
objvgs_PSkillRelaEN.SkillName = objRow[convgs_PSkillRela.SkillName] == DBNull.Value ? null : objRow[convgs_PSkillRela.SkillName].ToString().Trim(); //技能名称
objvgs_PSkillRelaEN.OperationTypeId = objRow[convgs_PSkillRela.OperationTypeId] == DBNull.Value ? null : objRow[convgs_PSkillRela.OperationTypeId].ToString().Trim(); //操作类型ID
objvgs_PSkillRelaEN.OperationTypeName = objRow[convgs_PSkillRela.OperationTypeName] == DBNull.Value ? null : objRow[convgs_PSkillRela.OperationTypeName].ToString().Trim(); //操作类型名
objvgs_PSkillRelaEN.LevelName = objRow[convgs_PSkillRela.LevelName] == DBNull.Value ? null : objRow[convgs_PSkillRela.LevelName].ToString().Trim(); //级别名称
objvgs_PSkillRelaEN.LevelId = objRow[convgs_PSkillRela.LevelId] == DBNull.Value ? null : objRow[convgs_PSkillRela.LevelId].ToString().Trim(); //级别Id
objvgs_PSkillRelaEN.Process = objRow[convgs_PSkillRela.Process] == DBNull.Value ? null : objRow[convgs_PSkillRela.Process].ToString().Trim(); //实施过程
objvgs_PSkillRelaEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[convgs_PSkillRela.IsSubmit].ToString().Trim()); //是否提交
objvgs_PSkillRelaEN.OkCount = objRow[convgs_PSkillRela.OkCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convgs_PSkillRela.OkCount].ToString().Trim()); //点赞统计
objvgs_PSkillRelaEN.Score = objRow[convgs_PSkillRela.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convgs_PSkillRela.Score].ToString().Trim()); //评分
objvgs_PSkillRelaEN.AppraiseCount = objRow[convgs_PSkillRela.AppraiseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convgs_PSkillRela.AppraiseCount].ToString().Trim()); //评论数
objvgs_PSkillRelaEN.StuScore = objRow[convgs_PSkillRela.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convgs_PSkillRela.StuScore].ToString().Trim()); //学生平均分
objvgs_PSkillRelaEN.TeaScore = objRow[convgs_PSkillRela.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convgs_PSkillRela.TeaScore].ToString().Trim()); //教师评分
objvgs_PSkillRelaEN.CitationCount = objRow[convgs_PSkillRela.CitationCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convgs_PSkillRela.CitationCount].ToString().Trim()); //引用统计
objvgs_PSkillRelaEN.VersionCount = objRow[convgs_PSkillRela.VersionCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convgs_PSkillRela.VersionCount].ToString().Trim()); //版本统计
objvgs_PSkillRelaEN.SkillUserId = objRow[convgs_PSkillRela.SkillUserId] == DBNull.Value ? null : objRow[convgs_PSkillRela.SkillUserId].ToString().Trim(); //SkillUserId
objvgs_PSkillRelaEN.SkillDate = objRow[convgs_PSkillRela.SkillDate] == DBNull.Value ? null : objRow[convgs_PSkillRela.SkillDate].ToString().Trim(); //SkillDate
objvgs_PSkillRelaEN.CreateDate = objRow[convgs_PSkillRela.CreateDate] == DBNull.Value ? null : objRow[convgs_PSkillRela.CreateDate].ToString().Trim(); //建立日期
objvgs_PSkillRelaEN.ShareId = objRow[convgs_PSkillRela.ShareId] == DBNull.Value ? null : objRow[convgs_PSkillRela.ShareId].ToString().Trim(); //分享Id
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvgs_PSkillRelaEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvgs_PSkillRelaEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objvgs_PSkillRelaCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsvgs_PSkillRelaEN> GetSubObjLstCache(clsvgs_PSkillRelaEN objvgs_PSkillRelaCond)
{
List<clsvgs_PSkillRelaEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsvgs_PSkillRelaEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convgs_PSkillRela.AttributeName)
{
if (objvgs_PSkillRelaCond.IsUpdated(strFldName) == false) continue;
if (objvgs_PSkillRelaCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvgs_PSkillRelaCond[strFldName].ToString());
}
else
{
if (objvgs_PSkillRelaCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvgs_PSkillRelaCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvgs_PSkillRelaCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvgs_PSkillRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvgs_PSkillRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvgs_PSkillRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvgs_PSkillRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvgs_PSkillRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvgs_PSkillRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvgs_PSkillRelaCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvgs_PSkillRelaCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvgs_PSkillRelaCond[strFldName]));
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
public static List<clsvgs_PSkillRelaEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsvgs_PSkillRelaEN> arrObjLst = new List<clsvgs_PSkillRelaEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvgs_PSkillRelaEN objvgs_PSkillRelaEN = new clsvgs_PSkillRelaEN();
try
{
objvgs_PSkillRelaEN.mId = Int32.Parse(objRow[convgs_PSkillRela.mId].ToString().Trim()); //mId
objvgs_PSkillRelaEN.PaperId = objRow[convgs_PSkillRela.PaperId].ToString().Trim(); //论文Id
objvgs_PSkillRelaEN.PaperTitle = objRow[convgs_PSkillRela.PaperTitle] == DBNull.Value ? null : objRow[convgs_PSkillRela.PaperTitle].ToString().Trim(); //论文标题
objvgs_PSkillRelaEN.PaperTypeId = objRow[convgs_PSkillRela.PaperTypeId] == DBNull.Value ? null : objRow[convgs_PSkillRela.PaperTypeId].ToString().Trim(); //论文类型Id
objvgs_PSkillRelaEN.SectionId = objRow[convgs_PSkillRela.SectionId] == DBNull.Value ? null : objRow[convgs_PSkillRela.SectionId].ToString().Trim(); //节Id
objvgs_PSkillRelaEN.SectionName = objRow[convgs_PSkillRela.SectionName] == DBNull.Value ? null : objRow[convgs_PSkillRela.SectionName].ToString().Trim(); //节名
objvgs_PSkillRelaEN.SkillId = objRow[convgs_PSkillRela.SkillId].ToString().Trim(); //技能Id
objvgs_PSkillRelaEN.UpdDate = objRow[convgs_PSkillRela.UpdDate] == DBNull.Value ? null : objRow[convgs_PSkillRela.UpdDate].ToString().Trim(); //修改日期
objvgs_PSkillRelaEN.UpdUser = objRow[convgs_PSkillRela.UpdUser] == DBNull.Value ? null : objRow[convgs_PSkillRela.UpdUser].ToString().Trim(); //修改人
objvgs_PSkillRelaEN.Memo = objRow[convgs_PSkillRela.Memo] == DBNull.Value ? null : objRow[convgs_PSkillRela.Memo].ToString().Trim(); //备注
objvgs_PSkillRelaEN.SkillName = objRow[convgs_PSkillRela.SkillName] == DBNull.Value ? null : objRow[convgs_PSkillRela.SkillName].ToString().Trim(); //技能名称
objvgs_PSkillRelaEN.OperationTypeId = objRow[convgs_PSkillRela.OperationTypeId] == DBNull.Value ? null : objRow[convgs_PSkillRela.OperationTypeId].ToString().Trim(); //操作类型ID
objvgs_PSkillRelaEN.OperationTypeName = objRow[convgs_PSkillRela.OperationTypeName] == DBNull.Value ? null : objRow[convgs_PSkillRela.OperationTypeName].ToString().Trim(); //操作类型名
objvgs_PSkillRelaEN.LevelName = objRow[convgs_PSkillRela.LevelName] == DBNull.Value ? null : objRow[convgs_PSkillRela.LevelName].ToString().Trim(); //级别名称
objvgs_PSkillRelaEN.LevelId = objRow[convgs_PSkillRela.LevelId] == DBNull.Value ? null : objRow[convgs_PSkillRela.LevelId].ToString().Trim(); //级别Id
objvgs_PSkillRelaEN.Process = objRow[convgs_PSkillRela.Process] == DBNull.Value ? null : objRow[convgs_PSkillRela.Process].ToString().Trim(); //实施过程
objvgs_PSkillRelaEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[convgs_PSkillRela.IsSubmit].ToString().Trim()); //是否提交
objvgs_PSkillRelaEN.OkCount = objRow[convgs_PSkillRela.OkCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convgs_PSkillRela.OkCount].ToString().Trim()); //点赞统计
objvgs_PSkillRelaEN.Score = objRow[convgs_PSkillRela.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convgs_PSkillRela.Score].ToString().Trim()); //评分
objvgs_PSkillRelaEN.AppraiseCount = objRow[convgs_PSkillRela.AppraiseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convgs_PSkillRela.AppraiseCount].ToString().Trim()); //评论数
objvgs_PSkillRelaEN.StuScore = objRow[convgs_PSkillRela.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convgs_PSkillRela.StuScore].ToString().Trim()); //学生平均分
objvgs_PSkillRelaEN.TeaScore = objRow[convgs_PSkillRela.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convgs_PSkillRela.TeaScore].ToString().Trim()); //教师评分
objvgs_PSkillRelaEN.CitationCount = objRow[convgs_PSkillRela.CitationCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convgs_PSkillRela.CitationCount].ToString().Trim()); //引用统计
objvgs_PSkillRelaEN.VersionCount = objRow[convgs_PSkillRela.VersionCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convgs_PSkillRela.VersionCount].ToString().Trim()); //版本统计
objvgs_PSkillRelaEN.SkillUserId = objRow[convgs_PSkillRela.SkillUserId] == DBNull.Value ? null : objRow[convgs_PSkillRela.SkillUserId].ToString().Trim(); //SkillUserId
objvgs_PSkillRelaEN.SkillDate = objRow[convgs_PSkillRela.SkillDate] == DBNull.Value ? null : objRow[convgs_PSkillRela.SkillDate].ToString().Trim(); //SkillDate
objvgs_PSkillRelaEN.CreateDate = objRow[convgs_PSkillRela.CreateDate] == DBNull.Value ? null : objRow[convgs_PSkillRela.CreateDate].ToString().Trim(); //建立日期
objvgs_PSkillRelaEN.ShareId = objRow[convgs_PSkillRela.ShareId] == DBNull.Value ? null : objRow[convgs_PSkillRela.ShareId].ToString().Trim(); //分享Id
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvgs_PSkillRelaEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvgs_PSkillRelaEN);
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
public static List<clsvgs_PSkillRelaEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsvgs_PSkillRelaEN> arrObjLst = new List<clsvgs_PSkillRelaEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvgs_PSkillRelaEN objvgs_PSkillRelaEN = new clsvgs_PSkillRelaEN();
try
{
objvgs_PSkillRelaEN.mId = Int32.Parse(objRow[convgs_PSkillRela.mId].ToString().Trim()); //mId
objvgs_PSkillRelaEN.PaperId = objRow[convgs_PSkillRela.PaperId].ToString().Trim(); //论文Id
objvgs_PSkillRelaEN.PaperTitle = objRow[convgs_PSkillRela.PaperTitle] == DBNull.Value ? null : objRow[convgs_PSkillRela.PaperTitle].ToString().Trim(); //论文标题
objvgs_PSkillRelaEN.PaperTypeId = objRow[convgs_PSkillRela.PaperTypeId] == DBNull.Value ? null : objRow[convgs_PSkillRela.PaperTypeId].ToString().Trim(); //论文类型Id
objvgs_PSkillRelaEN.SectionId = objRow[convgs_PSkillRela.SectionId] == DBNull.Value ? null : objRow[convgs_PSkillRela.SectionId].ToString().Trim(); //节Id
objvgs_PSkillRelaEN.SectionName = objRow[convgs_PSkillRela.SectionName] == DBNull.Value ? null : objRow[convgs_PSkillRela.SectionName].ToString().Trim(); //节名
objvgs_PSkillRelaEN.SkillId = objRow[convgs_PSkillRela.SkillId].ToString().Trim(); //技能Id
objvgs_PSkillRelaEN.UpdDate = objRow[convgs_PSkillRela.UpdDate] == DBNull.Value ? null : objRow[convgs_PSkillRela.UpdDate].ToString().Trim(); //修改日期
objvgs_PSkillRelaEN.UpdUser = objRow[convgs_PSkillRela.UpdUser] == DBNull.Value ? null : objRow[convgs_PSkillRela.UpdUser].ToString().Trim(); //修改人
objvgs_PSkillRelaEN.Memo = objRow[convgs_PSkillRela.Memo] == DBNull.Value ? null : objRow[convgs_PSkillRela.Memo].ToString().Trim(); //备注
objvgs_PSkillRelaEN.SkillName = objRow[convgs_PSkillRela.SkillName] == DBNull.Value ? null : objRow[convgs_PSkillRela.SkillName].ToString().Trim(); //技能名称
objvgs_PSkillRelaEN.OperationTypeId = objRow[convgs_PSkillRela.OperationTypeId] == DBNull.Value ? null : objRow[convgs_PSkillRela.OperationTypeId].ToString().Trim(); //操作类型ID
objvgs_PSkillRelaEN.OperationTypeName = objRow[convgs_PSkillRela.OperationTypeName] == DBNull.Value ? null : objRow[convgs_PSkillRela.OperationTypeName].ToString().Trim(); //操作类型名
objvgs_PSkillRelaEN.LevelName = objRow[convgs_PSkillRela.LevelName] == DBNull.Value ? null : objRow[convgs_PSkillRela.LevelName].ToString().Trim(); //级别名称
objvgs_PSkillRelaEN.LevelId = objRow[convgs_PSkillRela.LevelId] == DBNull.Value ? null : objRow[convgs_PSkillRela.LevelId].ToString().Trim(); //级别Id
objvgs_PSkillRelaEN.Process = objRow[convgs_PSkillRela.Process] == DBNull.Value ? null : objRow[convgs_PSkillRela.Process].ToString().Trim(); //实施过程
objvgs_PSkillRelaEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[convgs_PSkillRela.IsSubmit].ToString().Trim()); //是否提交
objvgs_PSkillRelaEN.OkCount = objRow[convgs_PSkillRela.OkCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convgs_PSkillRela.OkCount].ToString().Trim()); //点赞统计
objvgs_PSkillRelaEN.Score = objRow[convgs_PSkillRela.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convgs_PSkillRela.Score].ToString().Trim()); //评分
objvgs_PSkillRelaEN.AppraiseCount = objRow[convgs_PSkillRela.AppraiseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convgs_PSkillRela.AppraiseCount].ToString().Trim()); //评论数
objvgs_PSkillRelaEN.StuScore = objRow[convgs_PSkillRela.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convgs_PSkillRela.StuScore].ToString().Trim()); //学生平均分
objvgs_PSkillRelaEN.TeaScore = objRow[convgs_PSkillRela.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convgs_PSkillRela.TeaScore].ToString().Trim()); //教师评分
objvgs_PSkillRelaEN.CitationCount = objRow[convgs_PSkillRela.CitationCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convgs_PSkillRela.CitationCount].ToString().Trim()); //引用统计
objvgs_PSkillRelaEN.VersionCount = objRow[convgs_PSkillRela.VersionCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convgs_PSkillRela.VersionCount].ToString().Trim()); //版本统计
objvgs_PSkillRelaEN.SkillUserId = objRow[convgs_PSkillRela.SkillUserId] == DBNull.Value ? null : objRow[convgs_PSkillRela.SkillUserId].ToString().Trim(); //SkillUserId
objvgs_PSkillRelaEN.SkillDate = objRow[convgs_PSkillRela.SkillDate] == DBNull.Value ? null : objRow[convgs_PSkillRela.SkillDate].ToString().Trim(); //SkillDate
objvgs_PSkillRelaEN.CreateDate = objRow[convgs_PSkillRela.CreateDate] == DBNull.Value ? null : objRow[convgs_PSkillRela.CreateDate].ToString().Trim(); //建立日期
objvgs_PSkillRelaEN.ShareId = objRow[convgs_PSkillRela.ShareId] == DBNull.Value ? null : objRow[convgs_PSkillRela.ShareId].ToString().Trim(); //分享Id
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvgs_PSkillRelaEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvgs_PSkillRelaEN);
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
List<clsvgs_PSkillRelaEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsvgs_PSkillRelaEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsvgs_PSkillRelaEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsvgs_PSkillRelaEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsvgs_PSkillRelaEN> arrObjLst = new List<clsvgs_PSkillRelaEN>(); 
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
	clsvgs_PSkillRelaEN objvgs_PSkillRelaEN = new clsvgs_PSkillRelaEN();
try
{
objvgs_PSkillRelaEN.mId = Int32.Parse(objRow[convgs_PSkillRela.mId].ToString().Trim()); //mId
objvgs_PSkillRelaEN.PaperId = objRow[convgs_PSkillRela.PaperId].ToString().Trim(); //论文Id
objvgs_PSkillRelaEN.PaperTitle = objRow[convgs_PSkillRela.PaperTitle] == DBNull.Value ? null : objRow[convgs_PSkillRela.PaperTitle].ToString().Trim(); //论文标题
objvgs_PSkillRelaEN.PaperTypeId = objRow[convgs_PSkillRela.PaperTypeId] == DBNull.Value ? null : objRow[convgs_PSkillRela.PaperTypeId].ToString().Trim(); //论文类型Id
objvgs_PSkillRelaEN.SectionId = objRow[convgs_PSkillRela.SectionId] == DBNull.Value ? null : objRow[convgs_PSkillRela.SectionId].ToString().Trim(); //节Id
objvgs_PSkillRelaEN.SectionName = objRow[convgs_PSkillRela.SectionName] == DBNull.Value ? null : objRow[convgs_PSkillRela.SectionName].ToString().Trim(); //节名
objvgs_PSkillRelaEN.SkillId = objRow[convgs_PSkillRela.SkillId].ToString().Trim(); //技能Id
objvgs_PSkillRelaEN.UpdDate = objRow[convgs_PSkillRela.UpdDate] == DBNull.Value ? null : objRow[convgs_PSkillRela.UpdDate].ToString().Trim(); //修改日期
objvgs_PSkillRelaEN.UpdUser = objRow[convgs_PSkillRela.UpdUser] == DBNull.Value ? null : objRow[convgs_PSkillRela.UpdUser].ToString().Trim(); //修改人
objvgs_PSkillRelaEN.Memo = objRow[convgs_PSkillRela.Memo] == DBNull.Value ? null : objRow[convgs_PSkillRela.Memo].ToString().Trim(); //备注
objvgs_PSkillRelaEN.SkillName = objRow[convgs_PSkillRela.SkillName] == DBNull.Value ? null : objRow[convgs_PSkillRela.SkillName].ToString().Trim(); //技能名称
objvgs_PSkillRelaEN.OperationTypeId = objRow[convgs_PSkillRela.OperationTypeId] == DBNull.Value ? null : objRow[convgs_PSkillRela.OperationTypeId].ToString().Trim(); //操作类型ID
objvgs_PSkillRelaEN.OperationTypeName = objRow[convgs_PSkillRela.OperationTypeName] == DBNull.Value ? null : objRow[convgs_PSkillRela.OperationTypeName].ToString().Trim(); //操作类型名
objvgs_PSkillRelaEN.LevelName = objRow[convgs_PSkillRela.LevelName] == DBNull.Value ? null : objRow[convgs_PSkillRela.LevelName].ToString().Trim(); //级别名称
objvgs_PSkillRelaEN.LevelId = objRow[convgs_PSkillRela.LevelId] == DBNull.Value ? null : objRow[convgs_PSkillRela.LevelId].ToString().Trim(); //级别Id
objvgs_PSkillRelaEN.Process = objRow[convgs_PSkillRela.Process] == DBNull.Value ? null : objRow[convgs_PSkillRela.Process].ToString().Trim(); //实施过程
objvgs_PSkillRelaEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[convgs_PSkillRela.IsSubmit].ToString().Trim()); //是否提交
objvgs_PSkillRelaEN.OkCount = objRow[convgs_PSkillRela.OkCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convgs_PSkillRela.OkCount].ToString().Trim()); //点赞统计
objvgs_PSkillRelaEN.Score = objRow[convgs_PSkillRela.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convgs_PSkillRela.Score].ToString().Trim()); //评分
objvgs_PSkillRelaEN.AppraiseCount = objRow[convgs_PSkillRela.AppraiseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convgs_PSkillRela.AppraiseCount].ToString().Trim()); //评论数
objvgs_PSkillRelaEN.StuScore = objRow[convgs_PSkillRela.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convgs_PSkillRela.StuScore].ToString().Trim()); //学生平均分
objvgs_PSkillRelaEN.TeaScore = objRow[convgs_PSkillRela.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convgs_PSkillRela.TeaScore].ToString().Trim()); //教师评分
objvgs_PSkillRelaEN.CitationCount = objRow[convgs_PSkillRela.CitationCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convgs_PSkillRela.CitationCount].ToString().Trim()); //引用统计
objvgs_PSkillRelaEN.VersionCount = objRow[convgs_PSkillRela.VersionCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convgs_PSkillRela.VersionCount].ToString().Trim()); //版本统计
objvgs_PSkillRelaEN.SkillUserId = objRow[convgs_PSkillRela.SkillUserId] == DBNull.Value ? null : objRow[convgs_PSkillRela.SkillUserId].ToString().Trim(); //SkillUserId
objvgs_PSkillRelaEN.SkillDate = objRow[convgs_PSkillRela.SkillDate] == DBNull.Value ? null : objRow[convgs_PSkillRela.SkillDate].ToString().Trim(); //SkillDate
objvgs_PSkillRelaEN.CreateDate = objRow[convgs_PSkillRela.CreateDate] == DBNull.Value ? null : objRow[convgs_PSkillRela.CreateDate].ToString().Trim(); //建立日期
objvgs_PSkillRelaEN.ShareId = objRow[convgs_PSkillRela.ShareId] == DBNull.Value ? null : objRow[convgs_PSkillRela.ShareId].ToString().Trim(); //分享Id
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvgs_PSkillRelaEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvgs_PSkillRelaEN);
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
public static List<clsvgs_PSkillRelaEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsvgs_PSkillRelaEN> arrObjLst = new List<clsvgs_PSkillRelaEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvgs_PSkillRelaEN objvgs_PSkillRelaEN = new clsvgs_PSkillRelaEN();
try
{
objvgs_PSkillRelaEN.mId = Int32.Parse(objRow[convgs_PSkillRela.mId].ToString().Trim()); //mId
objvgs_PSkillRelaEN.PaperId = objRow[convgs_PSkillRela.PaperId].ToString().Trim(); //论文Id
objvgs_PSkillRelaEN.PaperTitle = objRow[convgs_PSkillRela.PaperTitle] == DBNull.Value ? null : objRow[convgs_PSkillRela.PaperTitle].ToString().Trim(); //论文标题
objvgs_PSkillRelaEN.PaperTypeId = objRow[convgs_PSkillRela.PaperTypeId] == DBNull.Value ? null : objRow[convgs_PSkillRela.PaperTypeId].ToString().Trim(); //论文类型Id
objvgs_PSkillRelaEN.SectionId = objRow[convgs_PSkillRela.SectionId] == DBNull.Value ? null : objRow[convgs_PSkillRela.SectionId].ToString().Trim(); //节Id
objvgs_PSkillRelaEN.SectionName = objRow[convgs_PSkillRela.SectionName] == DBNull.Value ? null : objRow[convgs_PSkillRela.SectionName].ToString().Trim(); //节名
objvgs_PSkillRelaEN.SkillId = objRow[convgs_PSkillRela.SkillId].ToString().Trim(); //技能Id
objvgs_PSkillRelaEN.UpdDate = objRow[convgs_PSkillRela.UpdDate] == DBNull.Value ? null : objRow[convgs_PSkillRela.UpdDate].ToString().Trim(); //修改日期
objvgs_PSkillRelaEN.UpdUser = objRow[convgs_PSkillRela.UpdUser] == DBNull.Value ? null : objRow[convgs_PSkillRela.UpdUser].ToString().Trim(); //修改人
objvgs_PSkillRelaEN.Memo = objRow[convgs_PSkillRela.Memo] == DBNull.Value ? null : objRow[convgs_PSkillRela.Memo].ToString().Trim(); //备注
objvgs_PSkillRelaEN.SkillName = objRow[convgs_PSkillRela.SkillName] == DBNull.Value ? null : objRow[convgs_PSkillRela.SkillName].ToString().Trim(); //技能名称
objvgs_PSkillRelaEN.OperationTypeId = objRow[convgs_PSkillRela.OperationTypeId] == DBNull.Value ? null : objRow[convgs_PSkillRela.OperationTypeId].ToString().Trim(); //操作类型ID
objvgs_PSkillRelaEN.OperationTypeName = objRow[convgs_PSkillRela.OperationTypeName] == DBNull.Value ? null : objRow[convgs_PSkillRela.OperationTypeName].ToString().Trim(); //操作类型名
objvgs_PSkillRelaEN.LevelName = objRow[convgs_PSkillRela.LevelName] == DBNull.Value ? null : objRow[convgs_PSkillRela.LevelName].ToString().Trim(); //级别名称
objvgs_PSkillRelaEN.LevelId = objRow[convgs_PSkillRela.LevelId] == DBNull.Value ? null : objRow[convgs_PSkillRela.LevelId].ToString().Trim(); //级别Id
objvgs_PSkillRelaEN.Process = objRow[convgs_PSkillRela.Process] == DBNull.Value ? null : objRow[convgs_PSkillRela.Process].ToString().Trim(); //实施过程
objvgs_PSkillRelaEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[convgs_PSkillRela.IsSubmit].ToString().Trim()); //是否提交
objvgs_PSkillRelaEN.OkCount = objRow[convgs_PSkillRela.OkCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convgs_PSkillRela.OkCount].ToString().Trim()); //点赞统计
objvgs_PSkillRelaEN.Score = objRow[convgs_PSkillRela.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convgs_PSkillRela.Score].ToString().Trim()); //评分
objvgs_PSkillRelaEN.AppraiseCount = objRow[convgs_PSkillRela.AppraiseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convgs_PSkillRela.AppraiseCount].ToString().Trim()); //评论数
objvgs_PSkillRelaEN.StuScore = objRow[convgs_PSkillRela.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convgs_PSkillRela.StuScore].ToString().Trim()); //学生平均分
objvgs_PSkillRelaEN.TeaScore = objRow[convgs_PSkillRela.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convgs_PSkillRela.TeaScore].ToString().Trim()); //教师评分
objvgs_PSkillRelaEN.CitationCount = objRow[convgs_PSkillRela.CitationCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convgs_PSkillRela.CitationCount].ToString().Trim()); //引用统计
objvgs_PSkillRelaEN.VersionCount = objRow[convgs_PSkillRela.VersionCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convgs_PSkillRela.VersionCount].ToString().Trim()); //版本统计
objvgs_PSkillRelaEN.SkillUserId = objRow[convgs_PSkillRela.SkillUserId] == DBNull.Value ? null : objRow[convgs_PSkillRela.SkillUserId].ToString().Trim(); //SkillUserId
objvgs_PSkillRelaEN.SkillDate = objRow[convgs_PSkillRela.SkillDate] == DBNull.Value ? null : objRow[convgs_PSkillRela.SkillDate].ToString().Trim(); //SkillDate
objvgs_PSkillRelaEN.CreateDate = objRow[convgs_PSkillRela.CreateDate] == DBNull.Value ? null : objRow[convgs_PSkillRela.CreateDate].ToString().Trim(); //建立日期
objvgs_PSkillRelaEN.ShareId = objRow[convgs_PSkillRela.ShareId] == DBNull.Value ? null : objRow[convgs_PSkillRela.ShareId].ToString().Trim(); //分享Id
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvgs_PSkillRelaEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvgs_PSkillRelaEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsvgs_PSkillRelaEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsvgs_PSkillRelaEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsvgs_PSkillRelaEN> arrObjLst = new List<clsvgs_PSkillRelaEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvgs_PSkillRelaEN objvgs_PSkillRelaEN = new clsvgs_PSkillRelaEN();
try
{
objvgs_PSkillRelaEN.mId = Int32.Parse(objRow[convgs_PSkillRela.mId].ToString().Trim()); //mId
objvgs_PSkillRelaEN.PaperId = objRow[convgs_PSkillRela.PaperId].ToString().Trim(); //论文Id
objvgs_PSkillRelaEN.PaperTitle = objRow[convgs_PSkillRela.PaperTitle] == DBNull.Value ? null : objRow[convgs_PSkillRela.PaperTitle].ToString().Trim(); //论文标题
objvgs_PSkillRelaEN.PaperTypeId = objRow[convgs_PSkillRela.PaperTypeId] == DBNull.Value ? null : objRow[convgs_PSkillRela.PaperTypeId].ToString().Trim(); //论文类型Id
objvgs_PSkillRelaEN.SectionId = objRow[convgs_PSkillRela.SectionId] == DBNull.Value ? null : objRow[convgs_PSkillRela.SectionId].ToString().Trim(); //节Id
objvgs_PSkillRelaEN.SectionName = objRow[convgs_PSkillRela.SectionName] == DBNull.Value ? null : objRow[convgs_PSkillRela.SectionName].ToString().Trim(); //节名
objvgs_PSkillRelaEN.SkillId = objRow[convgs_PSkillRela.SkillId].ToString().Trim(); //技能Id
objvgs_PSkillRelaEN.UpdDate = objRow[convgs_PSkillRela.UpdDate] == DBNull.Value ? null : objRow[convgs_PSkillRela.UpdDate].ToString().Trim(); //修改日期
objvgs_PSkillRelaEN.UpdUser = objRow[convgs_PSkillRela.UpdUser] == DBNull.Value ? null : objRow[convgs_PSkillRela.UpdUser].ToString().Trim(); //修改人
objvgs_PSkillRelaEN.Memo = objRow[convgs_PSkillRela.Memo] == DBNull.Value ? null : objRow[convgs_PSkillRela.Memo].ToString().Trim(); //备注
objvgs_PSkillRelaEN.SkillName = objRow[convgs_PSkillRela.SkillName] == DBNull.Value ? null : objRow[convgs_PSkillRela.SkillName].ToString().Trim(); //技能名称
objvgs_PSkillRelaEN.OperationTypeId = objRow[convgs_PSkillRela.OperationTypeId] == DBNull.Value ? null : objRow[convgs_PSkillRela.OperationTypeId].ToString().Trim(); //操作类型ID
objvgs_PSkillRelaEN.OperationTypeName = objRow[convgs_PSkillRela.OperationTypeName] == DBNull.Value ? null : objRow[convgs_PSkillRela.OperationTypeName].ToString().Trim(); //操作类型名
objvgs_PSkillRelaEN.LevelName = objRow[convgs_PSkillRela.LevelName] == DBNull.Value ? null : objRow[convgs_PSkillRela.LevelName].ToString().Trim(); //级别名称
objvgs_PSkillRelaEN.LevelId = objRow[convgs_PSkillRela.LevelId] == DBNull.Value ? null : objRow[convgs_PSkillRela.LevelId].ToString().Trim(); //级别Id
objvgs_PSkillRelaEN.Process = objRow[convgs_PSkillRela.Process] == DBNull.Value ? null : objRow[convgs_PSkillRela.Process].ToString().Trim(); //实施过程
objvgs_PSkillRelaEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[convgs_PSkillRela.IsSubmit].ToString().Trim()); //是否提交
objvgs_PSkillRelaEN.OkCount = objRow[convgs_PSkillRela.OkCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convgs_PSkillRela.OkCount].ToString().Trim()); //点赞统计
objvgs_PSkillRelaEN.Score = objRow[convgs_PSkillRela.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convgs_PSkillRela.Score].ToString().Trim()); //评分
objvgs_PSkillRelaEN.AppraiseCount = objRow[convgs_PSkillRela.AppraiseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convgs_PSkillRela.AppraiseCount].ToString().Trim()); //评论数
objvgs_PSkillRelaEN.StuScore = objRow[convgs_PSkillRela.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convgs_PSkillRela.StuScore].ToString().Trim()); //学生平均分
objvgs_PSkillRelaEN.TeaScore = objRow[convgs_PSkillRela.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convgs_PSkillRela.TeaScore].ToString().Trim()); //教师评分
objvgs_PSkillRelaEN.CitationCount = objRow[convgs_PSkillRela.CitationCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convgs_PSkillRela.CitationCount].ToString().Trim()); //引用统计
objvgs_PSkillRelaEN.VersionCount = objRow[convgs_PSkillRela.VersionCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convgs_PSkillRela.VersionCount].ToString().Trim()); //版本统计
objvgs_PSkillRelaEN.SkillUserId = objRow[convgs_PSkillRela.SkillUserId] == DBNull.Value ? null : objRow[convgs_PSkillRela.SkillUserId].ToString().Trim(); //SkillUserId
objvgs_PSkillRelaEN.SkillDate = objRow[convgs_PSkillRela.SkillDate] == DBNull.Value ? null : objRow[convgs_PSkillRela.SkillDate].ToString().Trim(); //SkillDate
objvgs_PSkillRelaEN.CreateDate = objRow[convgs_PSkillRela.CreateDate] == DBNull.Value ? null : objRow[convgs_PSkillRela.CreateDate].ToString().Trim(); //建立日期
objvgs_PSkillRelaEN.ShareId = objRow[convgs_PSkillRela.ShareId] == DBNull.Value ? null : objRow[convgs_PSkillRela.ShareId].ToString().Trim(); //分享Id
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvgs_PSkillRelaEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvgs_PSkillRelaEN);
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
public static List<clsvgs_PSkillRelaEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsvgs_PSkillRelaEN> arrObjLst = new List<clsvgs_PSkillRelaEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvgs_PSkillRelaEN objvgs_PSkillRelaEN = new clsvgs_PSkillRelaEN();
try
{
objvgs_PSkillRelaEN.mId = Int32.Parse(objRow[convgs_PSkillRela.mId].ToString().Trim()); //mId
objvgs_PSkillRelaEN.PaperId = objRow[convgs_PSkillRela.PaperId].ToString().Trim(); //论文Id
objvgs_PSkillRelaEN.PaperTitle = objRow[convgs_PSkillRela.PaperTitle] == DBNull.Value ? null : objRow[convgs_PSkillRela.PaperTitle].ToString().Trim(); //论文标题
objvgs_PSkillRelaEN.PaperTypeId = objRow[convgs_PSkillRela.PaperTypeId] == DBNull.Value ? null : objRow[convgs_PSkillRela.PaperTypeId].ToString().Trim(); //论文类型Id
objvgs_PSkillRelaEN.SectionId = objRow[convgs_PSkillRela.SectionId] == DBNull.Value ? null : objRow[convgs_PSkillRela.SectionId].ToString().Trim(); //节Id
objvgs_PSkillRelaEN.SectionName = objRow[convgs_PSkillRela.SectionName] == DBNull.Value ? null : objRow[convgs_PSkillRela.SectionName].ToString().Trim(); //节名
objvgs_PSkillRelaEN.SkillId = objRow[convgs_PSkillRela.SkillId].ToString().Trim(); //技能Id
objvgs_PSkillRelaEN.UpdDate = objRow[convgs_PSkillRela.UpdDate] == DBNull.Value ? null : objRow[convgs_PSkillRela.UpdDate].ToString().Trim(); //修改日期
objvgs_PSkillRelaEN.UpdUser = objRow[convgs_PSkillRela.UpdUser] == DBNull.Value ? null : objRow[convgs_PSkillRela.UpdUser].ToString().Trim(); //修改人
objvgs_PSkillRelaEN.Memo = objRow[convgs_PSkillRela.Memo] == DBNull.Value ? null : objRow[convgs_PSkillRela.Memo].ToString().Trim(); //备注
objvgs_PSkillRelaEN.SkillName = objRow[convgs_PSkillRela.SkillName] == DBNull.Value ? null : objRow[convgs_PSkillRela.SkillName].ToString().Trim(); //技能名称
objvgs_PSkillRelaEN.OperationTypeId = objRow[convgs_PSkillRela.OperationTypeId] == DBNull.Value ? null : objRow[convgs_PSkillRela.OperationTypeId].ToString().Trim(); //操作类型ID
objvgs_PSkillRelaEN.OperationTypeName = objRow[convgs_PSkillRela.OperationTypeName] == DBNull.Value ? null : objRow[convgs_PSkillRela.OperationTypeName].ToString().Trim(); //操作类型名
objvgs_PSkillRelaEN.LevelName = objRow[convgs_PSkillRela.LevelName] == DBNull.Value ? null : objRow[convgs_PSkillRela.LevelName].ToString().Trim(); //级别名称
objvgs_PSkillRelaEN.LevelId = objRow[convgs_PSkillRela.LevelId] == DBNull.Value ? null : objRow[convgs_PSkillRela.LevelId].ToString().Trim(); //级别Id
objvgs_PSkillRelaEN.Process = objRow[convgs_PSkillRela.Process] == DBNull.Value ? null : objRow[convgs_PSkillRela.Process].ToString().Trim(); //实施过程
objvgs_PSkillRelaEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[convgs_PSkillRela.IsSubmit].ToString().Trim()); //是否提交
objvgs_PSkillRelaEN.OkCount = objRow[convgs_PSkillRela.OkCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convgs_PSkillRela.OkCount].ToString().Trim()); //点赞统计
objvgs_PSkillRelaEN.Score = objRow[convgs_PSkillRela.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convgs_PSkillRela.Score].ToString().Trim()); //评分
objvgs_PSkillRelaEN.AppraiseCount = objRow[convgs_PSkillRela.AppraiseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convgs_PSkillRela.AppraiseCount].ToString().Trim()); //评论数
objvgs_PSkillRelaEN.StuScore = objRow[convgs_PSkillRela.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convgs_PSkillRela.StuScore].ToString().Trim()); //学生平均分
objvgs_PSkillRelaEN.TeaScore = objRow[convgs_PSkillRela.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convgs_PSkillRela.TeaScore].ToString().Trim()); //教师评分
objvgs_PSkillRelaEN.CitationCount = objRow[convgs_PSkillRela.CitationCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convgs_PSkillRela.CitationCount].ToString().Trim()); //引用统计
objvgs_PSkillRelaEN.VersionCount = objRow[convgs_PSkillRela.VersionCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convgs_PSkillRela.VersionCount].ToString().Trim()); //版本统计
objvgs_PSkillRelaEN.SkillUserId = objRow[convgs_PSkillRela.SkillUserId] == DBNull.Value ? null : objRow[convgs_PSkillRela.SkillUserId].ToString().Trim(); //SkillUserId
objvgs_PSkillRelaEN.SkillDate = objRow[convgs_PSkillRela.SkillDate] == DBNull.Value ? null : objRow[convgs_PSkillRela.SkillDate].ToString().Trim(); //SkillDate
objvgs_PSkillRelaEN.CreateDate = objRow[convgs_PSkillRela.CreateDate] == DBNull.Value ? null : objRow[convgs_PSkillRela.CreateDate].ToString().Trim(); //建立日期
objvgs_PSkillRelaEN.ShareId = objRow[convgs_PSkillRela.ShareId] == DBNull.Value ? null : objRow[convgs_PSkillRela.ShareId].ToString().Trim(); //分享Id
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvgs_PSkillRelaEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvgs_PSkillRelaEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsvgs_PSkillRelaEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsvgs_PSkillRelaEN> arrObjLst = new List<clsvgs_PSkillRelaEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvgs_PSkillRelaEN objvgs_PSkillRelaEN = new clsvgs_PSkillRelaEN();
try
{
objvgs_PSkillRelaEN.mId = Int32.Parse(objRow[convgs_PSkillRela.mId].ToString().Trim()); //mId
objvgs_PSkillRelaEN.PaperId = objRow[convgs_PSkillRela.PaperId].ToString().Trim(); //论文Id
objvgs_PSkillRelaEN.PaperTitle = objRow[convgs_PSkillRela.PaperTitle] == DBNull.Value ? null : objRow[convgs_PSkillRela.PaperTitle].ToString().Trim(); //论文标题
objvgs_PSkillRelaEN.PaperTypeId = objRow[convgs_PSkillRela.PaperTypeId] == DBNull.Value ? null : objRow[convgs_PSkillRela.PaperTypeId].ToString().Trim(); //论文类型Id
objvgs_PSkillRelaEN.SectionId = objRow[convgs_PSkillRela.SectionId] == DBNull.Value ? null : objRow[convgs_PSkillRela.SectionId].ToString().Trim(); //节Id
objvgs_PSkillRelaEN.SectionName = objRow[convgs_PSkillRela.SectionName] == DBNull.Value ? null : objRow[convgs_PSkillRela.SectionName].ToString().Trim(); //节名
objvgs_PSkillRelaEN.SkillId = objRow[convgs_PSkillRela.SkillId].ToString().Trim(); //技能Id
objvgs_PSkillRelaEN.UpdDate = objRow[convgs_PSkillRela.UpdDate] == DBNull.Value ? null : objRow[convgs_PSkillRela.UpdDate].ToString().Trim(); //修改日期
objvgs_PSkillRelaEN.UpdUser = objRow[convgs_PSkillRela.UpdUser] == DBNull.Value ? null : objRow[convgs_PSkillRela.UpdUser].ToString().Trim(); //修改人
objvgs_PSkillRelaEN.Memo = objRow[convgs_PSkillRela.Memo] == DBNull.Value ? null : objRow[convgs_PSkillRela.Memo].ToString().Trim(); //备注
objvgs_PSkillRelaEN.SkillName = objRow[convgs_PSkillRela.SkillName] == DBNull.Value ? null : objRow[convgs_PSkillRela.SkillName].ToString().Trim(); //技能名称
objvgs_PSkillRelaEN.OperationTypeId = objRow[convgs_PSkillRela.OperationTypeId] == DBNull.Value ? null : objRow[convgs_PSkillRela.OperationTypeId].ToString().Trim(); //操作类型ID
objvgs_PSkillRelaEN.OperationTypeName = objRow[convgs_PSkillRela.OperationTypeName] == DBNull.Value ? null : objRow[convgs_PSkillRela.OperationTypeName].ToString().Trim(); //操作类型名
objvgs_PSkillRelaEN.LevelName = objRow[convgs_PSkillRela.LevelName] == DBNull.Value ? null : objRow[convgs_PSkillRela.LevelName].ToString().Trim(); //级别名称
objvgs_PSkillRelaEN.LevelId = objRow[convgs_PSkillRela.LevelId] == DBNull.Value ? null : objRow[convgs_PSkillRela.LevelId].ToString().Trim(); //级别Id
objvgs_PSkillRelaEN.Process = objRow[convgs_PSkillRela.Process] == DBNull.Value ? null : objRow[convgs_PSkillRela.Process].ToString().Trim(); //实施过程
objvgs_PSkillRelaEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[convgs_PSkillRela.IsSubmit].ToString().Trim()); //是否提交
objvgs_PSkillRelaEN.OkCount = objRow[convgs_PSkillRela.OkCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convgs_PSkillRela.OkCount].ToString().Trim()); //点赞统计
objvgs_PSkillRelaEN.Score = objRow[convgs_PSkillRela.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convgs_PSkillRela.Score].ToString().Trim()); //评分
objvgs_PSkillRelaEN.AppraiseCount = objRow[convgs_PSkillRela.AppraiseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convgs_PSkillRela.AppraiseCount].ToString().Trim()); //评论数
objvgs_PSkillRelaEN.StuScore = objRow[convgs_PSkillRela.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convgs_PSkillRela.StuScore].ToString().Trim()); //学生平均分
objvgs_PSkillRelaEN.TeaScore = objRow[convgs_PSkillRela.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convgs_PSkillRela.TeaScore].ToString().Trim()); //教师评分
objvgs_PSkillRelaEN.CitationCount = objRow[convgs_PSkillRela.CitationCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convgs_PSkillRela.CitationCount].ToString().Trim()); //引用统计
objvgs_PSkillRelaEN.VersionCount = objRow[convgs_PSkillRela.VersionCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convgs_PSkillRela.VersionCount].ToString().Trim()); //版本统计
objvgs_PSkillRelaEN.SkillUserId = objRow[convgs_PSkillRela.SkillUserId] == DBNull.Value ? null : objRow[convgs_PSkillRela.SkillUserId].ToString().Trim(); //SkillUserId
objvgs_PSkillRelaEN.SkillDate = objRow[convgs_PSkillRela.SkillDate] == DBNull.Value ? null : objRow[convgs_PSkillRela.SkillDate].ToString().Trim(); //SkillDate
objvgs_PSkillRelaEN.CreateDate = objRow[convgs_PSkillRela.CreateDate] == DBNull.Value ? null : objRow[convgs_PSkillRela.CreateDate].ToString().Trim(); //建立日期
objvgs_PSkillRelaEN.ShareId = objRow[convgs_PSkillRela.ShareId] == DBNull.Value ? null : objRow[convgs_PSkillRela.ShareId].ToString().Trim(); //分享Id
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvgs_PSkillRelaEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvgs_PSkillRelaEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objvgs_PSkillRelaEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool Getvgs_PSkillRela(ref clsvgs_PSkillRelaEN objvgs_PSkillRelaEN)
{
bool bolResult = vgs_PSkillRelaDA.Getvgs_PSkillRela(ref objvgs_PSkillRelaEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvgs_PSkillRelaEN GetObjBymId(long lngmId)
{
clsvgs_PSkillRelaEN objvgs_PSkillRelaEN = vgs_PSkillRelaDA.GetObjBymId(lngmId);
return objvgs_PSkillRelaEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsvgs_PSkillRelaEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsvgs_PSkillRelaEN objvgs_PSkillRelaEN = vgs_PSkillRelaDA.GetFirstObj(strWhereCond);
 return objvgs_PSkillRelaEN;
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
public static clsvgs_PSkillRelaEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsvgs_PSkillRelaEN objvgs_PSkillRelaEN = vgs_PSkillRelaDA.GetObjByDataRow(objRow);
 return objvgs_PSkillRelaEN;
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
public static clsvgs_PSkillRelaEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsvgs_PSkillRelaEN objvgs_PSkillRelaEN = vgs_PSkillRelaDA.GetObjByDataRow(objRow);
 return objvgs_PSkillRelaEN;
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
 /// <param name = "lstvgs_PSkillRelaObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvgs_PSkillRelaEN GetObjBymIdFromList(long lngmId, List<clsvgs_PSkillRelaEN> lstvgs_PSkillRelaObjLst)
{
foreach (clsvgs_PSkillRelaEN objvgs_PSkillRelaEN in lstvgs_PSkillRelaObjLst)
{
if (objvgs_PSkillRelaEN.mId == lngmId)
{
return objvgs_PSkillRelaEN;
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
 lngmId = new clsvgs_PSkillRelaDA().GetFirstID(strWhereCond);
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
 arrList = vgs_PSkillRelaDA.GetID(strWhereCond);
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
bool bolIsExist = vgs_PSkillRelaDA.IsExistCondRec(strWhereCond);
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
bool bolIsExist = vgs_PSkillRelaDA.IsExist(lngmId);
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
 bolIsExist = clsvgs_PSkillRelaDA.IsExistTable();
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
 bolIsExist = vgs_PSkillRelaDA.IsExistTable(strTabName);
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
 /// <param name = "objvgs_PSkillRelaENS">源对象</param>
 /// <param name = "objvgs_PSkillRelaENT">目标对象</param>
 public static void CopyTo(clsvgs_PSkillRelaEN objvgs_PSkillRelaENS, clsvgs_PSkillRelaEN objvgs_PSkillRelaENT)
{
try
{
objvgs_PSkillRelaENT.mId = objvgs_PSkillRelaENS.mId; //mId
objvgs_PSkillRelaENT.PaperId = objvgs_PSkillRelaENS.PaperId; //论文Id
objvgs_PSkillRelaENT.PaperTitle = objvgs_PSkillRelaENS.PaperTitle; //论文标题
objvgs_PSkillRelaENT.PaperTypeId = objvgs_PSkillRelaENS.PaperTypeId; //论文类型Id
objvgs_PSkillRelaENT.SectionId = objvgs_PSkillRelaENS.SectionId; //节Id
objvgs_PSkillRelaENT.SectionName = objvgs_PSkillRelaENS.SectionName; //节名
objvgs_PSkillRelaENT.SkillId = objvgs_PSkillRelaENS.SkillId; //技能Id
objvgs_PSkillRelaENT.UpdDate = objvgs_PSkillRelaENS.UpdDate; //修改日期
objvgs_PSkillRelaENT.UpdUser = objvgs_PSkillRelaENS.UpdUser; //修改人
objvgs_PSkillRelaENT.Memo = objvgs_PSkillRelaENS.Memo; //备注
objvgs_PSkillRelaENT.SkillName = objvgs_PSkillRelaENS.SkillName; //技能名称
objvgs_PSkillRelaENT.OperationTypeId = objvgs_PSkillRelaENS.OperationTypeId; //操作类型ID
objvgs_PSkillRelaENT.OperationTypeName = objvgs_PSkillRelaENS.OperationTypeName; //操作类型名
objvgs_PSkillRelaENT.LevelName = objvgs_PSkillRelaENS.LevelName; //级别名称
objvgs_PSkillRelaENT.LevelId = objvgs_PSkillRelaENS.LevelId; //级别Id
objvgs_PSkillRelaENT.Process = objvgs_PSkillRelaENS.Process; //实施过程
objvgs_PSkillRelaENT.IsSubmit = objvgs_PSkillRelaENS.IsSubmit; //是否提交
objvgs_PSkillRelaENT.OkCount = objvgs_PSkillRelaENS.OkCount; //点赞统计
objvgs_PSkillRelaENT.Score = objvgs_PSkillRelaENS.Score; //评分
objvgs_PSkillRelaENT.AppraiseCount = objvgs_PSkillRelaENS.AppraiseCount; //评论数
objvgs_PSkillRelaENT.StuScore = objvgs_PSkillRelaENS.StuScore; //学生平均分
objvgs_PSkillRelaENT.TeaScore = objvgs_PSkillRelaENS.TeaScore; //教师评分
objvgs_PSkillRelaENT.CitationCount = objvgs_PSkillRelaENS.CitationCount; //引用统计
objvgs_PSkillRelaENT.VersionCount = objvgs_PSkillRelaENS.VersionCount; //版本统计
objvgs_PSkillRelaENT.SkillUserId = objvgs_PSkillRelaENS.SkillUserId; //SkillUserId
objvgs_PSkillRelaENT.SkillDate = objvgs_PSkillRelaENS.SkillDate; //SkillDate
objvgs_PSkillRelaENT.CreateDate = objvgs_PSkillRelaENS.CreateDate; //建立日期
objvgs_PSkillRelaENT.ShareId = objvgs_PSkillRelaENS.ShareId; //分享Id
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
 /// <param name = "objvgs_PSkillRelaEN">源简化对象</param>
 public static void SetUpdFlag(clsvgs_PSkillRelaEN objvgs_PSkillRelaEN)
{
try
{
objvgs_PSkillRelaEN.ClearUpdateState();
   string strsfUpdFldSetStr = objvgs_PSkillRelaEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(convgs_PSkillRela.mId, new clsStrCompareIgnoreCase())  ==  true)
{
objvgs_PSkillRelaEN.mId = objvgs_PSkillRelaEN.mId; //mId
}
if (arrFldSet.Contains(convgs_PSkillRela.PaperId, new clsStrCompareIgnoreCase())  ==  true)
{
objvgs_PSkillRelaEN.PaperId = objvgs_PSkillRelaEN.PaperId; //论文Id
}
if (arrFldSet.Contains(convgs_PSkillRela.PaperTitle, new clsStrCompareIgnoreCase())  ==  true)
{
objvgs_PSkillRelaEN.PaperTitle = objvgs_PSkillRelaEN.PaperTitle == "[null]" ? null :  objvgs_PSkillRelaEN.PaperTitle; //论文标题
}
if (arrFldSet.Contains(convgs_PSkillRela.PaperTypeId, new clsStrCompareIgnoreCase())  ==  true)
{
objvgs_PSkillRelaEN.PaperTypeId = objvgs_PSkillRelaEN.PaperTypeId == "[null]" ? null :  objvgs_PSkillRelaEN.PaperTypeId; //论文类型Id
}
if (arrFldSet.Contains(convgs_PSkillRela.SectionId, new clsStrCompareIgnoreCase())  ==  true)
{
objvgs_PSkillRelaEN.SectionId = objvgs_PSkillRelaEN.SectionId == "[null]" ? null :  objvgs_PSkillRelaEN.SectionId; //节Id
}
if (arrFldSet.Contains(convgs_PSkillRela.SectionName, new clsStrCompareIgnoreCase())  ==  true)
{
objvgs_PSkillRelaEN.SectionName = objvgs_PSkillRelaEN.SectionName == "[null]" ? null :  objvgs_PSkillRelaEN.SectionName; //节名
}
if (arrFldSet.Contains(convgs_PSkillRela.SkillId, new clsStrCompareIgnoreCase())  ==  true)
{
objvgs_PSkillRelaEN.SkillId = objvgs_PSkillRelaEN.SkillId; //技能Id
}
if (arrFldSet.Contains(convgs_PSkillRela.UpdDate, new clsStrCompareIgnoreCase())  ==  true)
{
objvgs_PSkillRelaEN.UpdDate = objvgs_PSkillRelaEN.UpdDate == "[null]" ? null :  objvgs_PSkillRelaEN.UpdDate; //修改日期
}
if (arrFldSet.Contains(convgs_PSkillRela.UpdUser, new clsStrCompareIgnoreCase())  ==  true)
{
objvgs_PSkillRelaEN.UpdUser = objvgs_PSkillRelaEN.UpdUser == "[null]" ? null :  objvgs_PSkillRelaEN.UpdUser; //修改人
}
if (arrFldSet.Contains(convgs_PSkillRela.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objvgs_PSkillRelaEN.Memo = objvgs_PSkillRelaEN.Memo == "[null]" ? null :  objvgs_PSkillRelaEN.Memo; //备注
}
if (arrFldSet.Contains(convgs_PSkillRela.SkillName, new clsStrCompareIgnoreCase())  ==  true)
{
objvgs_PSkillRelaEN.SkillName = objvgs_PSkillRelaEN.SkillName == "[null]" ? null :  objvgs_PSkillRelaEN.SkillName; //技能名称
}
if (arrFldSet.Contains(convgs_PSkillRela.OperationTypeId, new clsStrCompareIgnoreCase())  ==  true)
{
objvgs_PSkillRelaEN.OperationTypeId = objvgs_PSkillRelaEN.OperationTypeId == "[null]" ? null :  objvgs_PSkillRelaEN.OperationTypeId; //操作类型ID
}
if (arrFldSet.Contains(convgs_PSkillRela.OperationTypeName, new clsStrCompareIgnoreCase())  ==  true)
{
objvgs_PSkillRelaEN.OperationTypeName = objvgs_PSkillRelaEN.OperationTypeName == "[null]" ? null :  objvgs_PSkillRelaEN.OperationTypeName; //操作类型名
}
if (arrFldSet.Contains(convgs_PSkillRela.LevelName, new clsStrCompareIgnoreCase())  ==  true)
{
objvgs_PSkillRelaEN.LevelName = objvgs_PSkillRelaEN.LevelName == "[null]" ? null :  objvgs_PSkillRelaEN.LevelName; //级别名称
}
if (arrFldSet.Contains(convgs_PSkillRela.LevelId, new clsStrCompareIgnoreCase())  ==  true)
{
objvgs_PSkillRelaEN.LevelId = objvgs_PSkillRelaEN.LevelId == "[null]" ? null :  objvgs_PSkillRelaEN.LevelId; //级别Id
}
if (arrFldSet.Contains(convgs_PSkillRela.Process, new clsStrCompareIgnoreCase())  ==  true)
{
objvgs_PSkillRelaEN.Process = objvgs_PSkillRelaEN.Process == "[null]" ? null :  objvgs_PSkillRelaEN.Process; //实施过程
}
if (arrFldSet.Contains(convgs_PSkillRela.IsSubmit, new clsStrCompareIgnoreCase())  ==  true)
{
objvgs_PSkillRelaEN.IsSubmit = objvgs_PSkillRelaEN.IsSubmit; //是否提交
}
if (arrFldSet.Contains(convgs_PSkillRela.OkCount, new clsStrCompareIgnoreCase())  ==  true)
{
objvgs_PSkillRelaEN.OkCount = objvgs_PSkillRelaEN.OkCount; //点赞统计
}
if (arrFldSet.Contains(convgs_PSkillRela.Score, new clsStrCompareIgnoreCase())  ==  true)
{
objvgs_PSkillRelaEN.Score = objvgs_PSkillRelaEN.Score; //评分
}
if (arrFldSet.Contains(convgs_PSkillRela.AppraiseCount, new clsStrCompareIgnoreCase())  ==  true)
{
objvgs_PSkillRelaEN.AppraiseCount = objvgs_PSkillRelaEN.AppraiseCount; //评论数
}
if (arrFldSet.Contains(convgs_PSkillRela.StuScore, new clsStrCompareIgnoreCase())  ==  true)
{
objvgs_PSkillRelaEN.StuScore = objvgs_PSkillRelaEN.StuScore; //学生平均分
}
if (arrFldSet.Contains(convgs_PSkillRela.TeaScore, new clsStrCompareIgnoreCase())  ==  true)
{
objvgs_PSkillRelaEN.TeaScore = objvgs_PSkillRelaEN.TeaScore; //教师评分
}
if (arrFldSet.Contains(convgs_PSkillRela.CitationCount, new clsStrCompareIgnoreCase())  ==  true)
{
objvgs_PSkillRelaEN.CitationCount = objvgs_PSkillRelaEN.CitationCount; //引用统计
}
if (arrFldSet.Contains(convgs_PSkillRela.VersionCount, new clsStrCompareIgnoreCase())  ==  true)
{
objvgs_PSkillRelaEN.VersionCount = objvgs_PSkillRelaEN.VersionCount; //版本统计
}
if (arrFldSet.Contains(convgs_PSkillRela.SkillUserId, new clsStrCompareIgnoreCase())  ==  true)
{
objvgs_PSkillRelaEN.SkillUserId = objvgs_PSkillRelaEN.SkillUserId == "[null]" ? null :  objvgs_PSkillRelaEN.SkillUserId; //SkillUserId
}
if (arrFldSet.Contains(convgs_PSkillRela.SkillDate, new clsStrCompareIgnoreCase())  ==  true)
{
objvgs_PSkillRelaEN.SkillDate = objvgs_PSkillRelaEN.SkillDate == "[null]" ? null :  objvgs_PSkillRelaEN.SkillDate; //SkillDate
}
if (arrFldSet.Contains(convgs_PSkillRela.CreateDate, new clsStrCompareIgnoreCase())  ==  true)
{
objvgs_PSkillRelaEN.CreateDate = objvgs_PSkillRelaEN.CreateDate == "[null]" ? null :  objvgs_PSkillRelaEN.CreateDate; //建立日期
}
if (arrFldSet.Contains(convgs_PSkillRela.ShareId, new clsStrCompareIgnoreCase())  ==  true)
{
objvgs_PSkillRelaEN.ShareId = objvgs_PSkillRelaEN.ShareId == "[null]" ? null :  objvgs_PSkillRelaEN.ShareId; //分享Id
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
 /// <param name = "objvgs_PSkillRelaEN">源简化对象</param>
 public static void AccessFldValueNull(clsvgs_PSkillRelaEN objvgs_PSkillRelaEN)
{
try
{
if (objvgs_PSkillRelaEN.PaperTitle == "[null]") objvgs_PSkillRelaEN.PaperTitle = null; //论文标题
if (objvgs_PSkillRelaEN.PaperTypeId == "[null]") objvgs_PSkillRelaEN.PaperTypeId = null; //论文类型Id
if (objvgs_PSkillRelaEN.SectionId == "[null]") objvgs_PSkillRelaEN.SectionId = null; //节Id
if (objvgs_PSkillRelaEN.SectionName == "[null]") objvgs_PSkillRelaEN.SectionName = null; //节名
if (objvgs_PSkillRelaEN.UpdDate == "[null]") objvgs_PSkillRelaEN.UpdDate = null; //修改日期
if (objvgs_PSkillRelaEN.UpdUser == "[null]") objvgs_PSkillRelaEN.UpdUser = null; //修改人
if (objvgs_PSkillRelaEN.Memo == "[null]") objvgs_PSkillRelaEN.Memo = null; //备注
if (objvgs_PSkillRelaEN.SkillName == "[null]") objvgs_PSkillRelaEN.SkillName = null; //技能名称
if (objvgs_PSkillRelaEN.OperationTypeId == "[null]") objvgs_PSkillRelaEN.OperationTypeId = null; //操作类型ID
if (objvgs_PSkillRelaEN.OperationTypeName == "[null]") objvgs_PSkillRelaEN.OperationTypeName = null; //操作类型名
if (objvgs_PSkillRelaEN.LevelName == "[null]") objvgs_PSkillRelaEN.LevelName = null; //级别名称
if (objvgs_PSkillRelaEN.LevelId == "[null]") objvgs_PSkillRelaEN.LevelId = null; //级别Id
if (objvgs_PSkillRelaEN.Process == "[null]") objvgs_PSkillRelaEN.Process = null; //实施过程
if (objvgs_PSkillRelaEN.SkillUserId == "[null]") objvgs_PSkillRelaEN.SkillUserId = null; //SkillUserId
if (objvgs_PSkillRelaEN.SkillDate == "[null]") objvgs_PSkillRelaEN.SkillDate = null; //SkillDate
if (objvgs_PSkillRelaEN.CreateDate == "[null]") objvgs_PSkillRelaEN.CreateDate = null; //建立日期
if (objvgs_PSkillRelaEN.ShareId == "[null]") objvgs_PSkillRelaEN.ShareId = null; //分享Id
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
public static void CheckProperty4Condition(clsvgs_PSkillRelaEN objvgs_PSkillRelaEN)
{
 vgs_PSkillRelaDA.CheckProperty4Condition(objvgs_PSkillRelaEN);
 }


 #endregion 检查对象属性


 #region 绑定下拉框

 /// <summary>
 /// 绑定基于Win的下拉框
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_TabFeature_ComboBoxBindFunction)
 /// </summary>
 /// <param name = "objComboBox">需要绑定当前表的下拉框</param>

public static void BindCbo_mId(System.Windows.Forms.ComboBox objComboBox )
{
//为数据源为表的下拉框设置内容
string strCondition = string.Format("1 =1 Order By {0}", convgs_PSkillRela.mId); 
List<clsvgs_PSkillRelaEN> arrObjLst = clsvgs_PSkillRelaBL.GetObjLst(strCondition);
//初始化一个对象列表
//插入第0项。在第0项中插入“请选择...”,为了方便用户,与WEB方式类似。
clsvgs_PSkillRelaEN objvgs_PSkillRelaEN = new clsvgs_PSkillRelaEN()
{
mId = 0,
OperationTypeId = "选[论文技能关系视图]..."
};
arrObjLst.Insert(0, objvgs_PSkillRelaEN);
//设置下拉框的数据源、以及设置值项、显示项
objComboBox.ValueMember = convgs_PSkillRela.mId;
objComboBox.DisplayMember = convgs_PSkillRela.OperationTypeId;
objComboBox.DataSource = arrObjLst;
objComboBox.SelectedIndex = 0;
}

 /// <summary>
 /// 绑定基于Web的下拉框
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_TabFeature_DdlBindFunction)
 /// </summary>
 /// <param name = "objDDL">需要绑定当前表的下拉框</param>

public static void BindDdl_mId(System.Web.UI.WebControls.DropDownList objDDL )
{
//为数据源于表的下拉框设置内容
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[论文技能关系视图]...","0");
string strCondition = string.Format("1 =1 Order By {0}", convgs_PSkillRela.mId); 
IEnumerable<clsvgs_PSkillRelaEN> arrObjLst = clsvgs_PSkillRelaBL.GetObjLst(strCondition);
objDDL.DataValueField = convgs_PSkillRela.mId;
objDDL.DataTextField = convgs_PSkillRela.OperationTypeId;
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
public static void BindDdl_mIdCache(System.Web.UI.WebControls.DropDownList objDDL)
{
//为数据源于表的下拉框设置内容
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[论文技能关系视图]...","0");
List<clsvgs_PSkillRelaEN> arrvgs_PSkillRelaObjLst = GetAllvgs_PSkillRelaObjLstCache(); 
objDDL.DataValueField = convgs_PSkillRela.mId;
objDDL.DataTextField = convgs_PSkillRela.OperationTypeId;
objDDL.DataSource = arrvgs_PSkillRelaObjLst;
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
if (clsgs_PSkillRelaBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsgs_PSkillRelaBL没有刷新缓存机制(clsgs_PSkillRelaBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsSysSkillBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsSysSkillBL没有刷新缓存机制(clsSysSkillBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsSysSecurityLevelBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsSysSecurityLevelBL没有刷新缓存机制(clsSysSecurityLevelBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsSysOperationTypeBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsSysOperationTypeBL没有刷新缓存机制(clsSysOperationTypeBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by mId");
//if (arrvgs_PSkillRelaObjLstCache == null)
//{
//arrvgs_PSkillRelaObjLstCache = vgs_PSkillRelaDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "lngmId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvgs_PSkillRelaEN GetObjBymIdCache(long lngmId)
{
//获取缓存中的对象列表
string strKey = string.Format("{0}", clsvgs_PSkillRelaEN._CurrTabName);
List<clsvgs_PSkillRelaEN> arrvgs_PSkillRelaObjLstCache = GetObjLstCache();
IEnumerable <clsvgs_PSkillRelaEN> arrvgs_PSkillRelaObjLst_Sel =
arrvgs_PSkillRelaObjLstCache
.Where(x=> x.mId == lngmId 
);
if (arrvgs_PSkillRelaObjLst_Sel.Count() == 0)
{
   clsvgs_PSkillRelaEN obj = clsvgs_PSkillRelaBL.GetObjBymId(lngmId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
 }
return null;
}
return arrvgs_PSkillRelaObjLst_Sel.First();
}

 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecNameByKeyCache)
 /// </summary>
 /// <param name = "lngmId">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetLevelIdBymIdCache(long lngmId)
{
//获取缓存中的对象列表
clsvgs_PSkillRelaEN objvgs_PSkillRela = GetObjBymIdCache(lngmId);
if (objvgs_PSkillRela == null) return "";
return objvgs_PSkillRela.LevelId;
}
 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecNameByKeyCache)
 /// </summary>
 /// <param name = "lngmId">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetNameBymIdCache(long lngmId)
{
//获取缓存中的对象列表
clsvgs_PSkillRelaEN objvgs_PSkillRela = GetObjBymIdCache(lngmId);
if (objvgs_PSkillRela == null) return "";
return objvgs_PSkillRela.LevelId;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvgs_PSkillRelaEN> GetAllvgs_PSkillRelaObjLstCache()
{
//获取缓存中的对象列表
List<clsvgs_PSkillRelaEN> arrvgs_PSkillRelaObjLstCache = GetObjLstCache(); 
return arrvgs_PSkillRelaObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvgs_PSkillRelaEN> GetObjLstCache()
{
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}", clsvgs_PSkillRelaEN._CurrTabName);
List<clsvgs_PSkillRelaEN> arrvgs_PSkillRelaObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrvgs_PSkillRelaObjLstCache;
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
string strKey = string.Format("{0}", clsvgs_PSkillRelaEN._CurrTabName);
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
if (strInFldName != convgs_PSkillRela.mId)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (convgs_PSkillRela.AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", convgs_PSkillRela.AttributeName));
throw new Exception(strMsg);
}
var objvgs_PSkillRela = clsvgs_PSkillRelaBL.GetObjBymIdCache(lngmId);
if (objvgs_PSkillRela == null) return "";
return objvgs_PSkillRela[strOutFldName].ToString();
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
int intRecCount = clsvgs_PSkillRelaDA.GetRecCount(strTabName);
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
int intRecCount = clsvgs_PSkillRelaDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsvgs_PSkillRelaDA.GetRecCount();
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
int intRecCount = clsvgs_PSkillRelaDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objvgs_PSkillRelaCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsvgs_PSkillRelaEN objvgs_PSkillRelaCond)
{
List<clsvgs_PSkillRelaEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsvgs_PSkillRelaEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convgs_PSkillRela.AttributeName)
{
if (objvgs_PSkillRelaCond.IsUpdated(strFldName) == false) continue;
if (objvgs_PSkillRelaCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvgs_PSkillRelaCond[strFldName].ToString());
}
else
{
if (objvgs_PSkillRelaCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvgs_PSkillRelaCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvgs_PSkillRelaCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvgs_PSkillRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvgs_PSkillRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvgs_PSkillRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvgs_PSkillRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvgs_PSkillRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvgs_PSkillRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvgs_PSkillRelaCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvgs_PSkillRelaCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvgs_PSkillRelaCond[strFldName]));
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
 List<string> arrList = clsvgs_PSkillRelaDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = vgs_PSkillRelaDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = vgs_PSkillRelaDA.GetFldValueNoDistinct(strFldName, strWhereCond);
return arrList;
}



 #endregion 表操作常用函数
}
}