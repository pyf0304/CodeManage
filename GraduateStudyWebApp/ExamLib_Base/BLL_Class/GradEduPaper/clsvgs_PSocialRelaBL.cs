
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvgs_PSocialRelaBL
 表名:vgs_PSocialRela(01120665)
 * 版本:2023.08.23.1(服务器:WIN-SRV103-116)
 日期:2023/08/24 13:06:17
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
public static class  clsvgs_PSocialRelaBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvgs_PSocialRelaEN GetObj(this K_mId_vgs_PSocialRela myKey)
{
clsvgs_PSocialRelaEN objvgs_PSocialRelaEN = clsvgs_PSocialRelaBL.vgs_PSocialRelaDA.GetObjBymId(myKey.Value);
return objvgs_PSocialRelaEN;
}

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvgs_PSocialRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvgs_PSocialRelaEN SetmId(this clsvgs_PSocialRelaEN objvgs_PSocialRelaEN, long lngmId, string strComparisonOp="")
	{
objvgs_PSocialRelaEN.mId = lngmId; //mId
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvgs_PSocialRelaEN.dicFldComparisonOp.ContainsKey(convgs_PSocialRela.mId) == false)
{
objvgs_PSocialRelaEN.dicFldComparisonOp.Add(convgs_PSocialRela.mId, strComparisonOp);
}
else
{
objvgs_PSocialRelaEN.dicFldComparisonOp[convgs_PSocialRela.mId] = strComparisonOp;
}
}
return objvgs_PSocialRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvgs_PSocialRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvgs_PSocialRelaEN SetPaperId(this clsvgs_PSocialRelaEN objvgs_PSocialRelaEN, string strPaperId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strPaperId, convgs_PSocialRela.PaperId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPaperId, 8, convgs_PSocialRela.PaperId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strPaperId, 8, convgs_PSocialRela.PaperId);
}
objvgs_PSocialRelaEN.PaperId = strPaperId; //论文Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvgs_PSocialRelaEN.dicFldComparisonOp.ContainsKey(convgs_PSocialRela.PaperId) == false)
{
objvgs_PSocialRelaEN.dicFldComparisonOp.Add(convgs_PSocialRela.PaperId, strComparisonOp);
}
else
{
objvgs_PSocialRelaEN.dicFldComparisonOp[convgs_PSocialRela.PaperId] = strComparisonOp;
}
}
return objvgs_PSocialRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvgs_PSocialRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvgs_PSocialRelaEN SetPaperTitle(this clsvgs_PSocialRelaEN objvgs_PSocialRelaEN, string strPaperTitle, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPaperTitle, 500, convgs_PSocialRela.PaperTitle);
}
objvgs_PSocialRelaEN.PaperTitle = strPaperTitle; //论文标题
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvgs_PSocialRelaEN.dicFldComparisonOp.ContainsKey(convgs_PSocialRela.PaperTitle) == false)
{
objvgs_PSocialRelaEN.dicFldComparisonOp.Add(convgs_PSocialRela.PaperTitle, strComparisonOp);
}
else
{
objvgs_PSocialRelaEN.dicFldComparisonOp[convgs_PSocialRela.PaperTitle] = strComparisonOp;
}
}
return objvgs_PSocialRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvgs_PSocialRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvgs_PSocialRelaEN SetPaperTypeId(this clsvgs_PSocialRelaEN objvgs_PSocialRelaEN, string strPaperTypeId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPaperTypeId, 2, convgs_PSocialRela.PaperTypeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strPaperTypeId, 2, convgs_PSocialRela.PaperTypeId);
}
objvgs_PSocialRelaEN.PaperTypeId = strPaperTypeId; //论文类型Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvgs_PSocialRelaEN.dicFldComparisonOp.ContainsKey(convgs_PSocialRela.PaperTypeId) == false)
{
objvgs_PSocialRelaEN.dicFldComparisonOp.Add(convgs_PSocialRela.PaperTypeId, strComparisonOp);
}
else
{
objvgs_PSocialRelaEN.dicFldComparisonOp[convgs_PSocialRela.PaperTypeId] = strComparisonOp;
}
}
return objvgs_PSocialRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvgs_PSocialRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvgs_PSocialRelaEN SetSectionId(this clsvgs_PSocialRelaEN objvgs_PSocialRelaEN, string strSectionId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strSectionId, 8, convgs_PSocialRela.SectionId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strSectionId, 8, convgs_PSocialRela.SectionId);
}
objvgs_PSocialRelaEN.SectionId = strSectionId; //节Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvgs_PSocialRelaEN.dicFldComparisonOp.ContainsKey(convgs_PSocialRela.SectionId) == false)
{
objvgs_PSocialRelaEN.dicFldComparisonOp.Add(convgs_PSocialRela.SectionId, strComparisonOp);
}
else
{
objvgs_PSocialRelaEN.dicFldComparisonOp[convgs_PSocialRela.SectionId] = strComparisonOp;
}
}
return objvgs_PSocialRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvgs_PSocialRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvgs_PSocialRelaEN SetSectionName(this clsvgs_PSocialRelaEN objvgs_PSocialRelaEN, string strSectionName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strSectionName, 100, convgs_PSocialRela.SectionName);
}
objvgs_PSocialRelaEN.SectionName = strSectionName; //节名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvgs_PSocialRelaEN.dicFldComparisonOp.ContainsKey(convgs_PSocialRela.SectionName) == false)
{
objvgs_PSocialRelaEN.dicFldComparisonOp.Add(convgs_PSocialRela.SectionName, strComparisonOp);
}
else
{
objvgs_PSocialRelaEN.dicFldComparisonOp[convgs_PSocialRela.SectionName] = strComparisonOp;
}
}
return objvgs_PSocialRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvgs_PSocialRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvgs_PSocialRelaEN SetSocialId(this clsvgs_PSocialRelaEN objvgs_PSocialRelaEN, string strSocialId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strSocialId, convgs_PSocialRela.SocialId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strSocialId, 10, convgs_PSocialRela.SocialId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strSocialId, 10, convgs_PSocialRela.SocialId);
}
objvgs_PSocialRelaEN.SocialId = strSocialId; //社会Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvgs_PSocialRelaEN.dicFldComparisonOp.ContainsKey(convgs_PSocialRela.SocialId) == false)
{
objvgs_PSocialRelaEN.dicFldComparisonOp.Add(convgs_PSocialRela.SocialId, strComparisonOp);
}
else
{
objvgs_PSocialRelaEN.dicFldComparisonOp[convgs_PSocialRela.SocialId] = strComparisonOp;
}
}
return objvgs_PSocialRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvgs_PSocialRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvgs_PSocialRelaEN SetUpdDate(this clsvgs_PSocialRelaEN objvgs_PSocialRelaEN, string strUpdDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdDate, 20, convgs_PSocialRela.UpdDate);
}
objvgs_PSocialRelaEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvgs_PSocialRelaEN.dicFldComparisonOp.ContainsKey(convgs_PSocialRela.UpdDate) == false)
{
objvgs_PSocialRelaEN.dicFldComparisonOp.Add(convgs_PSocialRela.UpdDate, strComparisonOp);
}
else
{
objvgs_PSocialRelaEN.dicFldComparisonOp[convgs_PSocialRela.UpdDate] = strComparisonOp;
}
}
return objvgs_PSocialRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvgs_PSocialRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvgs_PSocialRelaEN SetUpdUser(this clsvgs_PSocialRelaEN objvgs_PSocialRelaEN, string strUpdUser, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdUser, 20, convgs_PSocialRela.UpdUser);
}
objvgs_PSocialRelaEN.UpdUser = strUpdUser; //修改人
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvgs_PSocialRelaEN.dicFldComparisonOp.ContainsKey(convgs_PSocialRela.UpdUser) == false)
{
objvgs_PSocialRelaEN.dicFldComparisonOp.Add(convgs_PSocialRela.UpdUser, strComparisonOp);
}
else
{
objvgs_PSocialRelaEN.dicFldComparisonOp[convgs_PSocialRela.UpdUser] = strComparisonOp;
}
}
return objvgs_PSocialRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvgs_PSocialRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvgs_PSocialRelaEN SetMemo(this clsvgs_PSocialRelaEN objvgs_PSocialRelaEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, convgs_PSocialRela.Memo);
}
objvgs_PSocialRelaEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvgs_PSocialRelaEN.dicFldComparisonOp.ContainsKey(convgs_PSocialRela.Memo) == false)
{
objvgs_PSocialRelaEN.dicFldComparisonOp.Add(convgs_PSocialRela.Memo, strComparisonOp);
}
else
{
objvgs_PSocialRelaEN.dicFldComparisonOp[convgs_PSocialRela.Memo] = strComparisonOp;
}
}
return objvgs_PSocialRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvgs_PSocialRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvgs_PSocialRelaEN SetFullName(this clsvgs_PSocialRelaEN objvgs_PSocialRelaEN, string strFullName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFullName, 50, convgs_PSocialRela.FullName);
}
objvgs_PSocialRelaEN.FullName = strFullName; //姓名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvgs_PSocialRelaEN.dicFldComparisonOp.ContainsKey(convgs_PSocialRela.FullName) == false)
{
objvgs_PSocialRelaEN.dicFldComparisonOp.Add(convgs_PSocialRela.FullName, strComparisonOp);
}
else
{
objvgs_PSocialRelaEN.dicFldComparisonOp[convgs_PSocialRela.FullName] = strComparisonOp;
}
}
return objvgs_PSocialRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvgs_PSocialRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvgs_PSocialRelaEN SetNationality(this clsvgs_PSocialRelaEN objvgs_PSocialRelaEN, string strNationality, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strNationality, 50, convgs_PSocialRela.Nationality);
}
objvgs_PSocialRelaEN.Nationality = strNationality; //国籍
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvgs_PSocialRelaEN.dicFldComparisonOp.ContainsKey(convgs_PSocialRela.Nationality) == false)
{
objvgs_PSocialRelaEN.dicFldComparisonOp.Add(convgs_PSocialRela.Nationality, strComparisonOp);
}
else
{
objvgs_PSocialRelaEN.dicFldComparisonOp[convgs_PSocialRela.Nationality] = strComparisonOp;
}
}
return objvgs_PSocialRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvgs_PSocialRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvgs_PSocialRelaEN SetWorkUnit(this clsvgs_PSocialRelaEN objvgs_PSocialRelaEN, string strWorkUnit, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strWorkUnit, 100, convgs_PSocialRela.WorkUnit);
}
objvgs_PSocialRelaEN.WorkUnit = strWorkUnit; //工作单位
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvgs_PSocialRelaEN.dicFldComparisonOp.ContainsKey(convgs_PSocialRela.WorkUnit) == false)
{
objvgs_PSocialRelaEN.dicFldComparisonOp.Add(convgs_PSocialRela.WorkUnit, strComparisonOp);
}
else
{
objvgs_PSocialRelaEN.dicFldComparisonOp[convgs_PSocialRela.WorkUnit] = strComparisonOp;
}
}
return objvgs_PSocialRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvgs_PSocialRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvgs_PSocialRelaEN SetMajor(this clsvgs_PSocialRelaEN objvgs_PSocialRelaEN, string strMajor, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMajor, 50, convgs_PSocialRela.Major);
}
objvgs_PSocialRelaEN.Major = strMajor; //专业
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvgs_PSocialRelaEN.dicFldComparisonOp.ContainsKey(convgs_PSocialRela.Major) == false)
{
objvgs_PSocialRelaEN.dicFldComparisonOp.Add(convgs_PSocialRela.Major, strComparisonOp);
}
else
{
objvgs_PSocialRelaEN.dicFldComparisonOp[convgs_PSocialRela.Major] = strComparisonOp;
}
}
return objvgs_PSocialRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvgs_PSocialRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvgs_PSocialRelaEN SetAchievement(this clsvgs_PSocialRelaEN objvgs_PSocialRelaEN, string strAchievement, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strAchievement, 5000, convgs_PSocialRela.Achievement);
}
objvgs_PSocialRelaEN.Achievement = strAchievement; //成就
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvgs_PSocialRelaEN.dicFldComparisonOp.ContainsKey(convgs_PSocialRela.Achievement) == false)
{
objvgs_PSocialRelaEN.dicFldComparisonOp.Add(convgs_PSocialRela.Achievement, strComparisonOp);
}
else
{
objvgs_PSocialRelaEN.dicFldComparisonOp[convgs_PSocialRela.Achievement] = strComparisonOp;
}
}
return objvgs_PSocialRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvgs_PSocialRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvgs_PSocialRelaEN SetDetailedDescription(this clsvgs_PSocialRelaEN objvgs_PSocialRelaEN, string strDetailedDescription, string strComparisonOp="")
	{
objvgs_PSocialRelaEN.DetailedDescription = strDetailedDescription; //详细说明
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvgs_PSocialRelaEN.dicFldComparisonOp.ContainsKey(convgs_PSocialRela.DetailedDescription) == false)
{
objvgs_PSocialRelaEN.dicFldComparisonOp.Add(convgs_PSocialRela.DetailedDescription, strComparisonOp);
}
else
{
objvgs_PSocialRelaEN.dicFldComparisonOp[convgs_PSocialRela.DetailedDescription] = strComparisonOp;
}
}
return objvgs_PSocialRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvgs_PSocialRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvgs_PSocialRelaEN SetLevelId(this clsvgs_PSocialRelaEN objvgs_PSocialRelaEN, string strLevelId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strLevelId, 2, convgs_PSocialRela.LevelId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strLevelId, 2, convgs_PSocialRela.LevelId);
}
objvgs_PSocialRelaEN.LevelId = strLevelId; //级别Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvgs_PSocialRelaEN.dicFldComparisonOp.ContainsKey(convgs_PSocialRela.LevelId) == false)
{
objvgs_PSocialRelaEN.dicFldComparisonOp.Add(convgs_PSocialRela.LevelId, strComparisonOp);
}
else
{
objvgs_PSocialRelaEN.dicFldComparisonOp[convgs_PSocialRela.LevelId] = strComparisonOp;
}
}
return objvgs_PSocialRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvgs_PSocialRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvgs_PSocialRelaEN SetLevelName(this clsvgs_PSocialRelaEN objvgs_PSocialRelaEN, string strLevelName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strLevelName, 50, convgs_PSocialRela.LevelName);
}
objvgs_PSocialRelaEN.LevelName = strLevelName; //级别名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvgs_PSocialRelaEN.dicFldComparisonOp.ContainsKey(convgs_PSocialRela.LevelName) == false)
{
objvgs_PSocialRelaEN.dicFldComparisonOp.Add(convgs_PSocialRela.LevelName, strComparisonOp);
}
else
{
objvgs_PSocialRelaEN.dicFldComparisonOp[convgs_PSocialRela.LevelName] = strComparisonOp;
}
}
return objvgs_PSocialRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvgs_PSocialRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvgs_PSocialRelaEN SetIsSubmit(this clsvgs_PSocialRelaEN objvgs_PSocialRelaEN, bool bolIsSubmit, string strComparisonOp="")
	{
objvgs_PSocialRelaEN.IsSubmit = bolIsSubmit; //是否提交
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvgs_PSocialRelaEN.dicFldComparisonOp.ContainsKey(convgs_PSocialRela.IsSubmit) == false)
{
objvgs_PSocialRelaEN.dicFldComparisonOp.Add(convgs_PSocialRela.IsSubmit, strComparisonOp);
}
else
{
objvgs_PSocialRelaEN.dicFldComparisonOp[convgs_PSocialRela.IsSubmit] = strComparisonOp;
}
}
return objvgs_PSocialRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvgs_PSocialRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvgs_PSocialRelaEN SetOkCount(this clsvgs_PSocialRelaEN objvgs_PSocialRelaEN, int? intOkCount, string strComparisonOp="")
	{
objvgs_PSocialRelaEN.OkCount = intOkCount; //点赞统计
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvgs_PSocialRelaEN.dicFldComparisonOp.ContainsKey(convgs_PSocialRela.OkCount) == false)
{
objvgs_PSocialRelaEN.dicFldComparisonOp.Add(convgs_PSocialRela.OkCount, strComparisonOp);
}
else
{
objvgs_PSocialRelaEN.dicFldComparisonOp[convgs_PSocialRela.OkCount] = strComparisonOp;
}
}
return objvgs_PSocialRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvgs_PSocialRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvgs_PSocialRelaEN SetCitationCount(this clsvgs_PSocialRelaEN objvgs_PSocialRelaEN, int? intCitationCount, string strComparisonOp="")
	{
objvgs_PSocialRelaEN.CitationCount = intCitationCount; //引用统计
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvgs_PSocialRelaEN.dicFldComparisonOp.ContainsKey(convgs_PSocialRela.CitationCount) == false)
{
objvgs_PSocialRelaEN.dicFldComparisonOp.Add(convgs_PSocialRela.CitationCount, strComparisonOp);
}
else
{
objvgs_PSocialRelaEN.dicFldComparisonOp[convgs_PSocialRela.CitationCount] = strComparisonOp;
}
}
return objvgs_PSocialRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvgs_PSocialRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvgs_PSocialRelaEN SetVersionCount(this clsvgs_PSocialRelaEN objvgs_PSocialRelaEN, int? intVersionCount, string strComparisonOp="")
	{
objvgs_PSocialRelaEN.VersionCount = intVersionCount; //版本统计
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvgs_PSocialRelaEN.dicFldComparisonOp.ContainsKey(convgs_PSocialRela.VersionCount) == false)
{
objvgs_PSocialRelaEN.dicFldComparisonOp.Add(convgs_PSocialRela.VersionCount, strComparisonOp);
}
else
{
objvgs_PSocialRelaEN.dicFldComparisonOp[convgs_PSocialRela.VersionCount] = strComparisonOp;
}
}
return objvgs_PSocialRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvgs_PSocialRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvgs_PSocialRelaEN SetAppraiseCount(this clsvgs_PSocialRelaEN objvgs_PSocialRelaEN, int? intAppraiseCount, string strComparisonOp="")
	{
objvgs_PSocialRelaEN.AppraiseCount = intAppraiseCount; //评论数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvgs_PSocialRelaEN.dicFldComparisonOp.ContainsKey(convgs_PSocialRela.AppraiseCount) == false)
{
objvgs_PSocialRelaEN.dicFldComparisonOp.Add(convgs_PSocialRela.AppraiseCount, strComparisonOp);
}
else
{
objvgs_PSocialRelaEN.dicFldComparisonOp[convgs_PSocialRela.AppraiseCount] = strComparisonOp;
}
}
return objvgs_PSocialRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvgs_PSocialRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvgs_PSocialRelaEN SetScore(this clsvgs_PSocialRelaEN objvgs_PSocialRelaEN, float? fltScore, string strComparisonOp="")
	{
objvgs_PSocialRelaEN.Score = fltScore; //评分
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvgs_PSocialRelaEN.dicFldComparisonOp.ContainsKey(convgs_PSocialRela.Score) == false)
{
objvgs_PSocialRelaEN.dicFldComparisonOp.Add(convgs_PSocialRela.Score, strComparisonOp);
}
else
{
objvgs_PSocialRelaEN.dicFldComparisonOp[convgs_PSocialRela.Score] = strComparisonOp;
}
}
return objvgs_PSocialRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvgs_PSocialRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvgs_PSocialRelaEN SetStuScore(this clsvgs_PSocialRelaEN objvgs_PSocialRelaEN, float? fltStuScore, string strComparisonOp="")
	{
objvgs_PSocialRelaEN.StuScore = fltStuScore; //学生平均分
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvgs_PSocialRelaEN.dicFldComparisonOp.ContainsKey(convgs_PSocialRela.StuScore) == false)
{
objvgs_PSocialRelaEN.dicFldComparisonOp.Add(convgs_PSocialRela.StuScore, strComparisonOp);
}
else
{
objvgs_PSocialRelaEN.dicFldComparisonOp[convgs_PSocialRela.StuScore] = strComparisonOp;
}
}
return objvgs_PSocialRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvgs_PSocialRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvgs_PSocialRelaEN SetTeaScore(this clsvgs_PSocialRelaEN objvgs_PSocialRelaEN, float? fltTeaScore, string strComparisonOp="")
	{
objvgs_PSocialRelaEN.TeaScore = fltTeaScore; //教师评分
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvgs_PSocialRelaEN.dicFldComparisonOp.ContainsKey(convgs_PSocialRela.TeaScore) == false)
{
objvgs_PSocialRelaEN.dicFldComparisonOp.Add(convgs_PSocialRela.TeaScore, strComparisonOp);
}
else
{
objvgs_PSocialRelaEN.dicFldComparisonOp[convgs_PSocialRela.TeaScore] = strComparisonOp;
}
}
return objvgs_PSocialRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvgs_PSocialRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvgs_PSocialRelaEN SetSocialUserId(this clsvgs_PSocialRelaEN objvgs_PSocialRelaEN, string strSocialUserId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strSocialUserId, 20, convgs_PSocialRela.SocialUserId);
}
objvgs_PSocialRelaEN.SocialUserId = strSocialUserId; //SocialUserId
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvgs_PSocialRelaEN.dicFldComparisonOp.ContainsKey(convgs_PSocialRela.SocialUserId) == false)
{
objvgs_PSocialRelaEN.dicFldComparisonOp.Add(convgs_PSocialRela.SocialUserId, strComparisonOp);
}
else
{
objvgs_PSocialRelaEN.dicFldComparisonOp[convgs_PSocialRela.SocialUserId] = strComparisonOp;
}
}
return objvgs_PSocialRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvgs_PSocialRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvgs_PSocialRelaEN SetSocialDate(this clsvgs_PSocialRelaEN objvgs_PSocialRelaEN, string strSocialDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strSocialDate, 20, convgs_PSocialRela.SocialDate);
}
objvgs_PSocialRelaEN.SocialDate = strSocialDate; //SocialDate
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvgs_PSocialRelaEN.dicFldComparisonOp.ContainsKey(convgs_PSocialRela.SocialDate) == false)
{
objvgs_PSocialRelaEN.dicFldComparisonOp.Add(convgs_PSocialRela.SocialDate, strComparisonOp);
}
else
{
objvgs_PSocialRelaEN.dicFldComparisonOp[convgs_PSocialRela.SocialDate] = strComparisonOp;
}
}
return objvgs_PSocialRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvgs_PSocialRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvgs_PSocialRelaEN SetCreateDate(this clsvgs_PSocialRelaEN objvgs_PSocialRelaEN, string strCreateDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCreateDate, 20, convgs_PSocialRela.CreateDate);
}
objvgs_PSocialRelaEN.CreateDate = strCreateDate; //建立日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvgs_PSocialRelaEN.dicFldComparisonOp.ContainsKey(convgs_PSocialRela.CreateDate) == false)
{
objvgs_PSocialRelaEN.dicFldComparisonOp.Add(convgs_PSocialRela.CreateDate, strComparisonOp);
}
else
{
objvgs_PSocialRelaEN.dicFldComparisonOp[convgs_PSocialRela.CreateDate] = strComparisonOp;
}
}
return objvgs_PSocialRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvgs_PSocialRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvgs_PSocialRelaEN SetShareId(this clsvgs_PSocialRelaEN objvgs_PSocialRelaEN, string strShareId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strShareId, 2, convgs_PSocialRela.ShareId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strShareId, 2, convgs_PSocialRela.ShareId);
}
objvgs_PSocialRelaEN.ShareId = strShareId; //分享Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvgs_PSocialRelaEN.dicFldComparisonOp.ContainsKey(convgs_PSocialRela.ShareId) == false)
{
objvgs_PSocialRelaEN.dicFldComparisonOp.Add(convgs_PSocialRela.ShareId, strComparisonOp);
}
else
{
objvgs_PSocialRelaEN.dicFldComparisonOp[convgs_PSocialRela.ShareId] = strComparisonOp;
}
}
return objvgs_PSocialRelaEN;
	}

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CopyObj)
 /// </summary>
 /// <param name = "objvgs_PSocialRelaENS">源对象</param>
 /// <param name = "objvgs_PSocialRelaENT">目标对象</param>
 public static void CopyTo(this clsvgs_PSocialRelaEN objvgs_PSocialRelaENS, clsvgs_PSocialRelaEN objvgs_PSocialRelaENT)
{
try
{
objvgs_PSocialRelaENT.mId = objvgs_PSocialRelaENS.mId; //mId
objvgs_PSocialRelaENT.PaperId = objvgs_PSocialRelaENS.PaperId; //论文Id
objvgs_PSocialRelaENT.PaperTitle = objvgs_PSocialRelaENS.PaperTitle; //论文标题
objvgs_PSocialRelaENT.PaperTypeId = objvgs_PSocialRelaENS.PaperTypeId; //论文类型Id
objvgs_PSocialRelaENT.SectionId = objvgs_PSocialRelaENS.SectionId; //节Id
objvgs_PSocialRelaENT.SectionName = objvgs_PSocialRelaENS.SectionName; //节名
objvgs_PSocialRelaENT.SocialId = objvgs_PSocialRelaENS.SocialId; //社会Id
objvgs_PSocialRelaENT.UpdDate = objvgs_PSocialRelaENS.UpdDate; //修改日期
objvgs_PSocialRelaENT.UpdUser = objvgs_PSocialRelaENS.UpdUser; //修改人
objvgs_PSocialRelaENT.Memo = objvgs_PSocialRelaENS.Memo; //备注
objvgs_PSocialRelaENT.FullName = objvgs_PSocialRelaENS.FullName; //姓名
objvgs_PSocialRelaENT.Nationality = objvgs_PSocialRelaENS.Nationality; //国籍
objvgs_PSocialRelaENT.WorkUnit = objvgs_PSocialRelaENS.WorkUnit; //工作单位
objvgs_PSocialRelaENT.Major = objvgs_PSocialRelaENS.Major; //专业
objvgs_PSocialRelaENT.Achievement = objvgs_PSocialRelaENS.Achievement; //成就
objvgs_PSocialRelaENT.DetailedDescription = objvgs_PSocialRelaENS.DetailedDescription; //详细说明
objvgs_PSocialRelaENT.LevelId = objvgs_PSocialRelaENS.LevelId; //级别Id
objvgs_PSocialRelaENT.LevelName = objvgs_PSocialRelaENS.LevelName; //级别名称
objvgs_PSocialRelaENT.IsSubmit = objvgs_PSocialRelaENS.IsSubmit; //是否提交
objvgs_PSocialRelaENT.OkCount = objvgs_PSocialRelaENS.OkCount; //点赞统计
objvgs_PSocialRelaENT.CitationCount = objvgs_PSocialRelaENS.CitationCount; //引用统计
objvgs_PSocialRelaENT.VersionCount = objvgs_PSocialRelaENS.VersionCount; //版本统计
objvgs_PSocialRelaENT.AppraiseCount = objvgs_PSocialRelaENS.AppraiseCount; //评论数
objvgs_PSocialRelaENT.Score = objvgs_PSocialRelaENS.Score; //评分
objvgs_PSocialRelaENT.StuScore = objvgs_PSocialRelaENS.StuScore; //学生平均分
objvgs_PSocialRelaENT.TeaScore = objvgs_PSocialRelaENS.TeaScore; //教师评分
objvgs_PSocialRelaENT.SocialUserId = objvgs_PSocialRelaENS.SocialUserId; //SocialUserId
objvgs_PSocialRelaENT.SocialDate = objvgs_PSocialRelaENS.SocialDate; //SocialDate
objvgs_PSocialRelaENT.CreateDate = objvgs_PSocialRelaENS.CreateDate; //建立日期
objvgs_PSocialRelaENT.ShareId = objvgs_PSocialRelaENS.ShareId; //分享Id
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
 /// <param name = "objvgs_PSocialRelaENS">源对象</param>
 /// <returns>目标对象=>clsvgs_PSocialRelaEN:objvgs_PSocialRelaENT</returns>
 public static clsvgs_PSocialRelaEN CopyTo(this clsvgs_PSocialRelaEN objvgs_PSocialRelaENS)
{
try
{
 clsvgs_PSocialRelaEN objvgs_PSocialRelaENT = new clsvgs_PSocialRelaEN()
{
mId = objvgs_PSocialRelaENS.mId, //mId
PaperId = objvgs_PSocialRelaENS.PaperId, //论文Id
PaperTitle = objvgs_PSocialRelaENS.PaperTitle, //论文标题
PaperTypeId = objvgs_PSocialRelaENS.PaperTypeId, //论文类型Id
SectionId = objvgs_PSocialRelaENS.SectionId, //节Id
SectionName = objvgs_PSocialRelaENS.SectionName, //节名
SocialId = objvgs_PSocialRelaENS.SocialId, //社会Id
UpdDate = objvgs_PSocialRelaENS.UpdDate, //修改日期
UpdUser = objvgs_PSocialRelaENS.UpdUser, //修改人
Memo = objvgs_PSocialRelaENS.Memo, //备注
FullName = objvgs_PSocialRelaENS.FullName, //姓名
Nationality = objvgs_PSocialRelaENS.Nationality, //国籍
WorkUnit = objvgs_PSocialRelaENS.WorkUnit, //工作单位
Major = objvgs_PSocialRelaENS.Major, //专业
Achievement = objvgs_PSocialRelaENS.Achievement, //成就
DetailedDescription = objvgs_PSocialRelaENS.DetailedDescription, //详细说明
LevelId = objvgs_PSocialRelaENS.LevelId, //级别Id
LevelName = objvgs_PSocialRelaENS.LevelName, //级别名称
IsSubmit = objvgs_PSocialRelaENS.IsSubmit, //是否提交
OkCount = objvgs_PSocialRelaENS.OkCount, //点赞统计
CitationCount = objvgs_PSocialRelaENS.CitationCount, //引用统计
VersionCount = objvgs_PSocialRelaENS.VersionCount, //版本统计
AppraiseCount = objvgs_PSocialRelaENS.AppraiseCount, //评论数
Score = objvgs_PSocialRelaENS.Score, //评分
StuScore = objvgs_PSocialRelaENS.StuScore, //学生平均分
TeaScore = objvgs_PSocialRelaENS.TeaScore, //教师评分
SocialUserId = objvgs_PSocialRelaENS.SocialUserId, //SocialUserId
SocialDate = objvgs_PSocialRelaENS.SocialDate, //SocialDate
CreateDate = objvgs_PSocialRelaENS.CreateDate, //建立日期
ShareId = objvgs_PSocialRelaENS.ShareId, //分享Id
};
 return objvgs_PSocialRelaENT;
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
public static void CheckProperty4Condition(this clsvgs_PSocialRelaEN objvgs_PSocialRelaEN)
{
 clsvgs_PSocialRelaBL.vgs_PSocialRelaDA.CheckProperty4Condition(objvgs_PSocialRelaEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvgs_PSocialRelaEN objvgs_PSocialRelaCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvgs_PSocialRelaCond.IsUpdated(convgs_PSocialRela.mId) == true)
{
string strComparisonOpmId = objvgs_PSocialRelaCond.dicFldComparisonOp[convgs_PSocialRela.mId];
strWhereCond += string.Format(" And {0} {2} {1}", convgs_PSocialRela.mId, objvgs_PSocialRelaCond.mId, strComparisonOpmId);
}
if (objvgs_PSocialRelaCond.IsUpdated(convgs_PSocialRela.PaperId) == true)
{
string strComparisonOpPaperId = objvgs_PSocialRelaCond.dicFldComparisonOp[convgs_PSocialRela.PaperId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convgs_PSocialRela.PaperId, objvgs_PSocialRelaCond.PaperId, strComparisonOpPaperId);
}
if (objvgs_PSocialRelaCond.IsUpdated(convgs_PSocialRela.PaperTitle) == true)
{
string strComparisonOpPaperTitle = objvgs_PSocialRelaCond.dicFldComparisonOp[convgs_PSocialRela.PaperTitle];
strWhereCond += string.Format(" And {0} {2} '{1}'", convgs_PSocialRela.PaperTitle, objvgs_PSocialRelaCond.PaperTitle, strComparisonOpPaperTitle);
}
if (objvgs_PSocialRelaCond.IsUpdated(convgs_PSocialRela.PaperTypeId) == true)
{
string strComparisonOpPaperTypeId = objvgs_PSocialRelaCond.dicFldComparisonOp[convgs_PSocialRela.PaperTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convgs_PSocialRela.PaperTypeId, objvgs_PSocialRelaCond.PaperTypeId, strComparisonOpPaperTypeId);
}
if (objvgs_PSocialRelaCond.IsUpdated(convgs_PSocialRela.SectionId) == true)
{
string strComparisonOpSectionId = objvgs_PSocialRelaCond.dicFldComparisonOp[convgs_PSocialRela.SectionId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convgs_PSocialRela.SectionId, objvgs_PSocialRelaCond.SectionId, strComparisonOpSectionId);
}
if (objvgs_PSocialRelaCond.IsUpdated(convgs_PSocialRela.SectionName) == true)
{
string strComparisonOpSectionName = objvgs_PSocialRelaCond.dicFldComparisonOp[convgs_PSocialRela.SectionName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convgs_PSocialRela.SectionName, objvgs_PSocialRelaCond.SectionName, strComparisonOpSectionName);
}
if (objvgs_PSocialRelaCond.IsUpdated(convgs_PSocialRela.SocialId) == true)
{
string strComparisonOpSocialId = objvgs_PSocialRelaCond.dicFldComparisonOp[convgs_PSocialRela.SocialId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convgs_PSocialRela.SocialId, objvgs_PSocialRelaCond.SocialId, strComparisonOpSocialId);
}
if (objvgs_PSocialRelaCond.IsUpdated(convgs_PSocialRela.UpdDate) == true)
{
string strComparisonOpUpdDate = objvgs_PSocialRelaCond.dicFldComparisonOp[convgs_PSocialRela.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convgs_PSocialRela.UpdDate, objvgs_PSocialRelaCond.UpdDate, strComparisonOpUpdDate);
}
if (objvgs_PSocialRelaCond.IsUpdated(convgs_PSocialRela.UpdUser) == true)
{
string strComparisonOpUpdUser = objvgs_PSocialRelaCond.dicFldComparisonOp[convgs_PSocialRela.UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", convgs_PSocialRela.UpdUser, objvgs_PSocialRelaCond.UpdUser, strComparisonOpUpdUser);
}
if (objvgs_PSocialRelaCond.IsUpdated(convgs_PSocialRela.Memo) == true)
{
string strComparisonOpMemo = objvgs_PSocialRelaCond.dicFldComparisonOp[convgs_PSocialRela.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convgs_PSocialRela.Memo, objvgs_PSocialRelaCond.Memo, strComparisonOpMemo);
}
if (objvgs_PSocialRelaCond.IsUpdated(convgs_PSocialRela.FullName) == true)
{
string strComparisonOpFullName = objvgs_PSocialRelaCond.dicFldComparisonOp[convgs_PSocialRela.FullName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convgs_PSocialRela.FullName, objvgs_PSocialRelaCond.FullName, strComparisonOpFullName);
}
if (objvgs_PSocialRelaCond.IsUpdated(convgs_PSocialRela.Nationality) == true)
{
string strComparisonOpNationality = objvgs_PSocialRelaCond.dicFldComparisonOp[convgs_PSocialRela.Nationality];
strWhereCond += string.Format(" And {0} {2} '{1}'", convgs_PSocialRela.Nationality, objvgs_PSocialRelaCond.Nationality, strComparisonOpNationality);
}
if (objvgs_PSocialRelaCond.IsUpdated(convgs_PSocialRela.WorkUnit) == true)
{
string strComparisonOpWorkUnit = objvgs_PSocialRelaCond.dicFldComparisonOp[convgs_PSocialRela.WorkUnit];
strWhereCond += string.Format(" And {0} {2} '{1}'", convgs_PSocialRela.WorkUnit, objvgs_PSocialRelaCond.WorkUnit, strComparisonOpWorkUnit);
}
if (objvgs_PSocialRelaCond.IsUpdated(convgs_PSocialRela.Major) == true)
{
string strComparisonOpMajor = objvgs_PSocialRelaCond.dicFldComparisonOp[convgs_PSocialRela.Major];
strWhereCond += string.Format(" And {0} {2} '{1}'", convgs_PSocialRela.Major, objvgs_PSocialRelaCond.Major, strComparisonOpMajor);
}
if (objvgs_PSocialRelaCond.IsUpdated(convgs_PSocialRela.Achievement) == true)
{
string strComparisonOpAchievement = objvgs_PSocialRelaCond.dicFldComparisonOp[convgs_PSocialRela.Achievement];
strWhereCond += string.Format(" And {0} {2} '{1}'", convgs_PSocialRela.Achievement, objvgs_PSocialRelaCond.Achievement, strComparisonOpAchievement);
}
//数据类型string(text)在函数:[AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj]中没有处理!
if (objvgs_PSocialRelaCond.IsUpdated(convgs_PSocialRela.LevelId) == true)
{
string strComparisonOpLevelId = objvgs_PSocialRelaCond.dicFldComparisonOp[convgs_PSocialRela.LevelId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convgs_PSocialRela.LevelId, objvgs_PSocialRelaCond.LevelId, strComparisonOpLevelId);
}
if (objvgs_PSocialRelaCond.IsUpdated(convgs_PSocialRela.LevelName) == true)
{
string strComparisonOpLevelName = objvgs_PSocialRelaCond.dicFldComparisonOp[convgs_PSocialRela.LevelName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convgs_PSocialRela.LevelName, objvgs_PSocialRelaCond.LevelName, strComparisonOpLevelName);
}
if (objvgs_PSocialRelaCond.IsUpdated(convgs_PSocialRela.IsSubmit) == true)
{
if (objvgs_PSocialRelaCond.IsSubmit == true)
{
strWhereCond += string.Format(" And {0} = '1'", convgs_PSocialRela.IsSubmit);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convgs_PSocialRela.IsSubmit);
}
}
if (objvgs_PSocialRelaCond.IsUpdated(convgs_PSocialRela.OkCount) == true)
{
string strComparisonOpOkCount = objvgs_PSocialRelaCond.dicFldComparisonOp[convgs_PSocialRela.OkCount];
strWhereCond += string.Format(" And {0} {2} {1}", convgs_PSocialRela.OkCount, objvgs_PSocialRelaCond.OkCount, strComparisonOpOkCount);
}
if (objvgs_PSocialRelaCond.IsUpdated(convgs_PSocialRela.CitationCount) == true)
{
string strComparisonOpCitationCount = objvgs_PSocialRelaCond.dicFldComparisonOp[convgs_PSocialRela.CitationCount];
strWhereCond += string.Format(" And {0} {2} {1}", convgs_PSocialRela.CitationCount, objvgs_PSocialRelaCond.CitationCount, strComparisonOpCitationCount);
}
if (objvgs_PSocialRelaCond.IsUpdated(convgs_PSocialRela.VersionCount) == true)
{
string strComparisonOpVersionCount = objvgs_PSocialRelaCond.dicFldComparisonOp[convgs_PSocialRela.VersionCount];
strWhereCond += string.Format(" And {0} {2} {1}", convgs_PSocialRela.VersionCount, objvgs_PSocialRelaCond.VersionCount, strComparisonOpVersionCount);
}
if (objvgs_PSocialRelaCond.IsUpdated(convgs_PSocialRela.AppraiseCount) == true)
{
string strComparisonOpAppraiseCount = objvgs_PSocialRelaCond.dicFldComparisonOp[convgs_PSocialRela.AppraiseCount];
strWhereCond += string.Format(" And {0} {2} {1}", convgs_PSocialRela.AppraiseCount, objvgs_PSocialRelaCond.AppraiseCount, strComparisonOpAppraiseCount);
}
if (objvgs_PSocialRelaCond.IsUpdated(convgs_PSocialRela.Score) == true)
{
string strComparisonOpScore = objvgs_PSocialRelaCond.dicFldComparisonOp[convgs_PSocialRela.Score];
strWhereCond += string.Format(" And {0} {2} {1}", convgs_PSocialRela.Score, objvgs_PSocialRelaCond.Score, strComparisonOpScore);
}
if (objvgs_PSocialRelaCond.IsUpdated(convgs_PSocialRela.StuScore) == true)
{
string strComparisonOpStuScore = objvgs_PSocialRelaCond.dicFldComparisonOp[convgs_PSocialRela.StuScore];
strWhereCond += string.Format(" And {0} {2} {1}", convgs_PSocialRela.StuScore, objvgs_PSocialRelaCond.StuScore, strComparisonOpStuScore);
}
if (objvgs_PSocialRelaCond.IsUpdated(convgs_PSocialRela.TeaScore) == true)
{
string strComparisonOpTeaScore = objvgs_PSocialRelaCond.dicFldComparisonOp[convgs_PSocialRela.TeaScore];
strWhereCond += string.Format(" And {0} {2} {1}", convgs_PSocialRela.TeaScore, objvgs_PSocialRelaCond.TeaScore, strComparisonOpTeaScore);
}
if (objvgs_PSocialRelaCond.IsUpdated(convgs_PSocialRela.SocialUserId) == true)
{
string strComparisonOpSocialUserId = objvgs_PSocialRelaCond.dicFldComparisonOp[convgs_PSocialRela.SocialUserId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convgs_PSocialRela.SocialUserId, objvgs_PSocialRelaCond.SocialUserId, strComparisonOpSocialUserId);
}
if (objvgs_PSocialRelaCond.IsUpdated(convgs_PSocialRela.SocialDate) == true)
{
string strComparisonOpSocialDate = objvgs_PSocialRelaCond.dicFldComparisonOp[convgs_PSocialRela.SocialDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convgs_PSocialRela.SocialDate, objvgs_PSocialRelaCond.SocialDate, strComparisonOpSocialDate);
}
if (objvgs_PSocialRelaCond.IsUpdated(convgs_PSocialRela.CreateDate) == true)
{
string strComparisonOpCreateDate = objvgs_PSocialRelaCond.dicFldComparisonOp[convgs_PSocialRela.CreateDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convgs_PSocialRela.CreateDate, objvgs_PSocialRelaCond.CreateDate, strComparisonOpCreateDate);
}
if (objvgs_PSocialRelaCond.IsUpdated(convgs_PSocialRela.ShareId) == true)
{
string strComparisonOpShareId = objvgs_PSocialRelaCond.dicFldComparisonOp[convgs_PSocialRela.ShareId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convgs_PSocialRela.ShareId, objvgs_PSocialRelaCond.ShareId, strComparisonOpShareId);
}
 return strWhereCond;
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_vgs_PSocialRela
{
public virtual bool UpdRelaTabDate(long lngmId, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// 论文社会关系视图(vgs_PSocialRela)
 /// 数据源类型:视图
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsvgs_PSocialRelaBL
{
public static RelatedActions_vgs_PSocialRela relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsvgs_PSocialRelaDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsvgs_PSocialRelaDA vgs_PSocialRelaDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsvgs_PSocialRelaDA();
}
return uniqueInstance;
}
}

 /// <summary>
 /// 类的构造函数
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ClassConstructor1)
 /// </summary>
 public clsvgs_PSocialRelaBL()
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
if (string.IsNullOrEmpty(clsvgs_PSocialRelaEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvgs_PSocialRelaEN._ConnectString);
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
public static DataTable GetDataTable_vgs_PSocialRela(string strWhereCond)
{
DataTable objDT;
try
{
objDT = vgs_PSocialRelaDA.GetDataTable_vgs_PSocialRela(strWhereCond);
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
objDT = vgs_PSocialRelaDA.GetDataTable(strWhereCond);
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
objDT = vgs_PSocialRelaDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = vgs_PSocialRelaDA.GetDataTable(strWhereCond, strTabName);
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
objDT = vgs_PSocialRelaDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = vgs_PSocialRelaDA.GetDataTable_Top(objTopPara);
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
objDT = vgs_PSocialRelaDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = vgs_PSocialRelaDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = vgs_PSocialRelaDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
public static List<clsvgs_PSocialRelaEN> GetObjLstByMIdLst(List<long> arrMIdLst)
{
List<clsvgs_PSocialRelaEN> arrObjLst = new List<clsvgs_PSocialRelaEN>(); 
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
	clsvgs_PSocialRelaEN objvgs_PSocialRelaEN = new clsvgs_PSocialRelaEN();
try
{
objvgs_PSocialRelaEN.mId = Int32.Parse(objRow[convgs_PSocialRela.mId].ToString().Trim()); //mId
objvgs_PSocialRelaEN.PaperId = objRow[convgs_PSocialRela.PaperId].ToString().Trim(); //论文Id
objvgs_PSocialRelaEN.PaperTitle = objRow[convgs_PSocialRela.PaperTitle] == DBNull.Value ? null : objRow[convgs_PSocialRela.PaperTitle].ToString().Trim(); //论文标题
objvgs_PSocialRelaEN.PaperTypeId = objRow[convgs_PSocialRela.PaperTypeId] == DBNull.Value ? null : objRow[convgs_PSocialRela.PaperTypeId].ToString().Trim(); //论文类型Id
objvgs_PSocialRelaEN.SectionId = objRow[convgs_PSocialRela.SectionId] == DBNull.Value ? null : objRow[convgs_PSocialRela.SectionId].ToString().Trim(); //节Id
objvgs_PSocialRelaEN.SectionName = objRow[convgs_PSocialRela.SectionName] == DBNull.Value ? null : objRow[convgs_PSocialRela.SectionName].ToString().Trim(); //节名
objvgs_PSocialRelaEN.SocialId = objRow[convgs_PSocialRela.SocialId].ToString().Trim(); //社会Id
objvgs_PSocialRelaEN.UpdDate = objRow[convgs_PSocialRela.UpdDate] == DBNull.Value ? null : objRow[convgs_PSocialRela.UpdDate].ToString().Trim(); //修改日期
objvgs_PSocialRelaEN.UpdUser = objRow[convgs_PSocialRela.UpdUser] == DBNull.Value ? null : objRow[convgs_PSocialRela.UpdUser].ToString().Trim(); //修改人
objvgs_PSocialRelaEN.Memo = objRow[convgs_PSocialRela.Memo] == DBNull.Value ? null : objRow[convgs_PSocialRela.Memo].ToString().Trim(); //备注
objvgs_PSocialRelaEN.FullName = objRow[convgs_PSocialRela.FullName] == DBNull.Value ? null : objRow[convgs_PSocialRela.FullName].ToString().Trim(); //姓名
objvgs_PSocialRelaEN.Nationality = objRow[convgs_PSocialRela.Nationality] == DBNull.Value ? null : objRow[convgs_PSocialRela.Nationality].ToString().Trim(); //国籍
objvgs_PSocialRelaEN.WorkUnit = objRow[convgs_PSocialRela.WorkUnit] == DBNull.Value ? null : objRow[convgs_PSocialRela.WorkUnit].ToString().Trim(); //工作单位
objvgs_PSocialRelaEN.Major = objRow[convgs_PSocialRela.Major] == DBNull.Value ? null : objRow[convgs_PSocialRela.Major].ToString().Trim(); //专业
objvgs_PSocialRelaEN.Achievement = objRow[convgs_PSocialRela.Achievement] == DBNull.Value ? null : objRow[convgs_PSocialRela.Achievement].ToString().Trim(); //成就
objvgs_PSocialRelaEN.DetailedDescription = objRow[convgs_PSocialRela.DetailedDescription] == DBNull.Value ? null : objRow[convgs_PSocialRela.DetailedDescription].ToString().Trim(); //详细说明
objvgs_PSocialRelaEN.LevelId = objRow[convgs_PSocialRela.LevelId] == DBNull.Value ? null : objRow[convgs_PSocialRela.LevelId].ToString().Trim(); //级别Id
objvgs_PSocialRelaEN.LevelName = objRow[convgs_PSocialRela.LevelName] == DBNull.Value ? null : objRow[convgs_PSocialRela.LevelName].ToString().Trim(); //级别名称
objvgs_PSocialRelaEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[convgs_PSocialRela.IsSubmit].ToString().Trim()); //是否提交
objvgs_PSocialRelaEN.OkCount = objRow[convgs_PSocialRela.OkCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convgs_PSocialRela.OkCount].ToString().Trim()); //点赞统计
objvgs_PSocialRelaEN.CitationCount = objRow[convgs_PSocialRela.CitationCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convgs_PSocialRela.CitationCount].ToString().Trim()); //引用统计
objvgs_PSocialRelaEN.VersionCount = objRow[convgs_PSocialRela.VersionCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convgs_PSocialRela.VersionCount].ToString().Trim()); //版本统计
objvgs_PSocialRelaEN.AppraiseCount = objRow[convgs_PSocialRela.AppraiseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convgs_PSocialRela.AppraiseCount].ToString().Trim()); //评论数
objvgs_PSocialRelaEN.Score = objRow[convgs_PSocialRela.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convgs_PSocialRela.Score].ToString().Trim()); //评分
objvgs_PSocialRelaEN.StuScore = objRow[convgs_PSocialRela.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convgs_PSocialRela.StuScore].ToString().Trim()); //学生平均分
objvgs_PSocialRelaEN.TeaScore = objRow[convgs_PSocialRela.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convgs_PSocialRela.TeaScore].ToString().Trim()); //教师评分
objvgs_PSocialRelaEN.SocialUserId = objRow[convgs_PSocialRela.SocialUserId] == DBNull.Value ? null : objRow[convgs_PSocialRela.SocialUserId].ToString().Trim(); //SocialUserId
objvgs_PSocialRelaEN.SocialDate = objRow[convgs_PSocialRela.SocialDate] == DBNull.Value ? null : objRow[convgs_PSocialRela.SocialDate].ToString().Trim(); //SocialDate
objvgs_PSocialRelaEN.CreateDate = objRow[convgs_PSocialRela.CreateDate] == DBNull.Value ? null : objRow[convgs_PSocialRela.CreateDate].ToString().Trim(); //建立日期
objvgs_PSocialRelaEN.ShareId = objRow[convgs_PSocialRela.ShareId] == DBNull.Value ? null : objRow[convgs_PSocialRela.ShareId].ToString().Trim(); //分享Id
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvgs_PSocialRelaEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvgs_PSocialRelaEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrMIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsvgs_PSocialRelaEN> GetObjLstByMIdLstCache(List<long> arrMIdLst)
{
string strKey = string.Format("{0}", clsvgs_PSocialRelaEN._CurrTabName);
List<clsvgs_PSocialRelaEN> arrvgs_PSocialRelaObjLstCache = GetObjLstCache();
IEnumerable <clsvgs_PSocialRelaEN> arrvgs_PSocialRelaObjLst_Sel =
arrvgs_PSocialRelaObjLstCache
.Where(x => arrMIdLst.Contains(x.mId));
return arrvgs_PSocialRelaObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvgs_PSocialRelaEN> GetObjLst(string strWhereCond)
{
List<clsvgs_PSocialRelaEN> arrObjLst = new List<clsvgs_PSocialRelaEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvgs_PSocialRelaEN objvgs_PSocialRelaEN = new clsvgs_PSocialRelaEN();
try
{
objvgs_PSocialRelaEN.mId = Int32.Parse(objRow[convgs_PSocialRela.mId].ToString().Trim()); //mId
objvgs_PSocialRelaEN.PaperId = objRow[convgs_PSocialRela.PaperId].ToString().Trim(); //论文Id
objvgs_PSocialRelaEN.PaperTitle = objRow[convgs_PSocialRela.PaperTitle] == DBNull.Value ? null : objRow[convgs_PSocialRela.PaperTitle].ToString().Trim(); //论文标题
objvgs_PSocialRelaEN.PaperTypeId = objRow[convgs_PSocialRela.PaperTypeId] == DBNull.Value ? null : objRow[convgs_PSocialRela.PaperTypeId].ToString().Trim(); //论文类型Id
objvgs_PSocialRelaEN.SectionId = objRow[convgs_PSocialRela.SectionId] == DBNull.Value ? null : objRow[convgs_PSocialRela.SectionId].ToString().Trim(); //节Id
objvgs_PSocialRelaEN.SectionName = objRow[convgs_PSocialRela.SectionName] == DBNull.Value ? null : objRow[convgs_PSocialRela.SectionName].ToString().Trim(); //节名
objvgs_PSocialRelaEN.SocialId = objRow[convgs_PSocialRela.SocialId].ToString().Trim(); //社会Id
objvgs_PSocialRelaEN.UpdDate = objRow[convgs_PSocialRela.UpdDate] == DBNull.Value ? null : objRow[convgs_PSocialRela.UpdDate].ToString().Trim(); //修改日期
objvgs_PSocialRelaEN.UpdUser = objRow[convgs_PSocialRela.UpdUser] == DBNull.Value ? null : objRow[convgs_PSocialRela.UpdUser].ToString().Trim(); //修改人
objvgs_PSocialRelaEN.Memo = objRow[convgs_PSocialRela.Memo] == DBNull.Value ? null : objRow[convgs_PSocialRela.Memo].ToString().Trim(); //备注
objvgs_PSocialRelaEN.FullName = objRow[convgs_PSocialRela.FullName] == DBNull.Value ? null : objRow[convgs_PSocialRela.FullName].ToString().Trim(); //姓名
objvgs_PSocialRelaEN.Nationality = objRow[convgs_PSocialRela.Nationality] == DBNull.Value ? null : objRow[convgs_PSocialRela.Nationality].ToString().Trim(); //国籍
objvgs_PSocialRelaEN.WorkUnit = objRow[convgs_PSocialRela.WorkUnit] == DBNull.Value ? null : objRow[convgs_PSocialRela.WorkUnit].ToString().Trim(); //工作单位
objvgs_PSocialRelaEN.Major = objRow[convgs_PSocialRela.Major] == DBNull.Value ? null : objRow[convgs_PSocialRela.Major].ToString().Trim(); //专业
objvgs_PSocialRelaEN.Achievement = objRow[convgs_PSocialRela.Achievement] == DBNull.Value ? null : objRow[convgs_PSocialRela.Achievement].ToString().Trim(); //成就
objvgs_PSocialRelaEN.DetailedDescription = objRow[convgs_PSocialRela.DetailedDescription] == DBNull.Value ? null : objRow[convgs_PSocialRela.DetailedDescription].ToString().Trim(); //详细说明
objvgs_PSocialRelaEN.LevelId = objRow[convgs_PSocialRela.LevelId] == DBNull.Value ? null : objRow[convgs_PSocialRela.LevelId].ToString().Trim(); //级别Id
objvgs_PSocialRelaEN.LevelName = objRow[convgs_PSocialRela.LevelName] == DBNull.Value ? null : objRow[convgs_PSocialRela.LevelName].ToString().Trim(); //级别名称
objvgs_PSocialRelaEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[convgs_PSocialRela.IsSubmit].ToString().Trim()); //是否提交
objvgs_PSocialRelaEN.OkCount = objRow[convgs_PSocialRela.OkCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convgs_PSocialRela.OkCount].ToString().Trim()); //点赞统计
objvgs_PSocialRelaEN.CitationCount = objRow[convgs_PSocialRela.CitationCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convgs_PSocialRela.CitationCount].ToString().Trim()); //引用统计
objvgs_PSocialRelaEN.VersionCount = objRow[convgs_PSocialRela.VersionCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convgs_PSocialRela.VersionCount].ToString().Trim()); //版本统计
objvgs_PSocialRelaEN.AppraiseCount = objRow[convgs_PSocialRela.AppraiseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convgs_PSocialRela.AppraiseCount].ToString().Trim()); //评论数
objvgs_PSocialRelaEN.Score = objRow[convgs_PSocialRela.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convgs_PSocialRela.Score].ToString().Trim()); //评分
objvgs_PSocialRelaEN.StuScore = objRow[convgs_PSocialRela.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convgs_PSocialRela.StuScore].ToString().Trim()); //学生平均分
objvgs_PSocialRelaEN.TeaScore = objRow[convgs_PSocialRela.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convgs_PSocialRela.TeaScore].ToString().Trim()); //教师评分
objvgs_PSocialRelaEN.SocialUserId = objRow[convgs_PSocialRela.SocialUserId] == DBNull.Value ? null : objRow[convgs_PSocialRela.SocialUserId].ToString().Trim(); //SocialUserId
objvgs_PSocialRelaEN.SocialDate = objRow[convgs_PSocialRela.SocialDate] == DBNull.Value ? null : objRow[convgs_PSocialRela.SocialDate].ToString().Trim(); //SocialDate
objvgs_PSocialRelaEN.CreateDate = objRow[convgs_PSocialRela.CreateDate] == DBNull.Value ? null : objRow[convgs_PSocialRela.CreateDate].ToString().Trim(); //建立日期
objvgs_PSocialRelaEN.ShareId = objRow[convgs_PSocialRela.ShareId] == DBNull.Value ? null : objRow[convgs_PSocialRela.ShareId].ToString().Trim(); //分享Id
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvgs_PSocialRelaEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvgs_PSocialRelaEN);
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
public static List<clsvgs_PSocialRelaEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsvgs_PSocialRelaEN> arrObjLst = new List<clsvgs_PSocialRelaEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvgs_PSocialRelaEN objvgs_PSocialRelaEN = new clsvgs_PSocialRelaEN();
try
{
objvgs_PSocialRelaEN.mId = Int32.Parse(objRow[convgs_PSocialRela.mId].ToString().Trim()); //mId
objvgs_PSocialRelaEN.PaperId = objRow[convgs_PSocialRela.PaperId].ToString().Trim(); //论文Id
objvgs_PSocialRelaEN.PaperTitle = objRow[convgs_PSocialRela.PaperTitle] == DBNull.Value ? null : objRow[convgs_PSocialRela.PaperTitle].ToString().Trim(); //论文标题
objvgs_PSocialRelaEN.PaperTypeId = objRow[convgs_PSocialRela.PaperTypeId] == DBNull.Value ? null : objRow[convgs_PSocialRela.PaperTypeId].ToString().Trim(); //论文类型Id
objvgs_PSocialRelaEN.SectionId = objRow[convgs_PSocialRela.SectionId] == DBNull.Value ? null : objRow[convgs_PSocialRela.SectionId].ToString().Trim(); //节Id
objvgs_PSocialRelaEN.SectionName = objRow[convgs_PSocialRela.SectionName] == DBNull.Value ? null : objRow[convgs_PSocialRela.SectionName].ToString().Trim(); //节名
objvgs_PSocialRelaEN.SocialId = objRow[convgs_PSocialRela.SocialId].ToString().Trim(); //社会Id
objvgs_PSocialRelaEN.UpdDate = objRow[convgs_PSocialRela.UpdDate] == DBNull.Value ? null : objRow[convgs_PSocialRela.UpdDate].ToString().Trim(); //修改日期
objvgs_PSocialRelaEN.UpdUser = objRow[convgs_PSocialRela.UpdUser] == DBNull.Value ? null : objRow[convgs_PSocialRela.UpdUser].ToString().Trim(); //修改人
objvgs_PSocialRelaEN.Memo = objRow[convgs_PSocialRela.Memo] == DBNull.Value ? null : objRow[convgs_PSocialRela.Memo].ToString().Trim(); //备注
objvgs_PSocialRelaEN.FullName = objRow[convgs_PSocialRela.FullName] == DBNull.Value ? null : objRow[convgs_PSocialRela.FullName].ToString().Trim(); //姓名
objvgs_PSocialRelaEN.Nationality = objRow[convgs_PSocialRela.Nationality] == DBNull.Value ? null : objRow[convgs_PSocialRela.Nationality].ToString().Trim(); //国籍
objvgs_PSocialRelaEN.WorkUnit = objRow[convgs_PSocialRela.WorkUnit] == DBNull.Value ? null : objRow[convgs_PSocialRela.WorkUnit].ToString().Trim(); //工作单位
objvgs_PSocialRelaEN.Major = objRow[convgs_PSocialRela.Major] == DBNull.Value ? null : objRow[convgs_PSocialRela.Major].ToString().Trim(); //专业
objvgs_PSocialRelaEN.Achievement = objRow[convgs_PSocialRela.Achievement] == DBNull.Value ? null : objRow[convgs_PSocialRela.Achievement].ToString().Trim(); //成就
objvgs_PSocialRelaEN.DetailedDescription = objRow[convgs_PSocialRela.DetailedDescription] == DBNull.Value ? null : objRow[convgs_PSocialRela.DetailedDescription].ToString().Trim(); //详细说明
objvgs_PSocialRelaEN.LevelId = objRow[convgs_PSocialRela.LevelId] == DBNull.Value ? null : objRow[convgs_PSocialRela.LevelId].ToString().Trim(); //级别Id
objvgs_PSocialRelaEN.LevelName = objRow[convgs_PSocialRela.LevelName] == DBNull.Value ? null : objRow[convgs_PSocialRela.LevelName].ToString().Trim(); //级别名称
objvgs_PSocialRelaEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[convgs_PSocialRela.IsSubmit].ToString().Trim()); //是否提交
objvgs_PSocialRelaEN.OkCount = objRow[convgs_PSocialRela.OkCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convgs_PSocialRela.OkCount].ToString().Trim()); //点赞统计
objvgs_PSocialRelaEN.CitationCount = objRow[convgs_PSocialRela.CitationCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convgs_PSocialRela.CitationCount].ToString().Trim()); //引用统计
objvgs_PSocialRelaEN.VersionCount = objRow[convgs_PSocialRela.VersionCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convgs_PSocialRela.VersionCount].ToString().Trim()); //版本统计
objvgs_PSocialRelaEN.AppraiseCount = objRow[convgs_PSocialRela.AppraiseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convgs_PSocialRela.AppraiseCount].ToString().Trim()); //评论数
objvgs_PSocialRelaEN.Score = objRow[convgs_PSocialRela.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convgs_PSocialRela.Score].ToString().Trim()); //评分
objvgs_PSocialRelaEN.StuScore = objRow[convgs_PSocialRela.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convgs_PSocialRela.StuScore].ToString().Trim()); //学生平均分
objvgs_PSocialRelaEN.TeaScore = objRow[convgs_PSocialRela.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convgs_PSocialRela.TeaScore].ToString().Trim()); //教师评分
objvgs_PSocialRelaEN.SocialUserId = objRow[convgs_PSocialRela.SocialUserId] == DBNull.Value ? null : objRow[convgs_PSocialRela.SocialUserId].ToString().Trim(); //SocialUserId
objvgs_PSocialRelaEN.SocialDate = objRow[convgs_PSocialRela.SocialDate] == DBNull.Value ? null : objRow[convgs_PSocialRela.SocialDate].ToString().Trim(); //SocialDate
objvgs_PSocialRelaEN.CreateDate = objRow[convgs_PSocialRela.CreateDate] == DBNull.Value ? null : objRow[convgs_PSocialRela.CreateDate].ToString().Trim(); //建立日期
objvgs_PSocialRelaEN.ShareId = objRow[convgs_PSocialRela.ShareId] == DBNull.Value ? null : objRow[convgs_PSocialRela.ShareId].ToString().Trim(); //分享Id
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvgs_PSocialRelaEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvgs_PSocialRelaEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objvgs_PSocialRelaCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsvgs_PSocialRelaEN> GetSubObjLstCache(clsvgs_PSocialRelaEN objvgs_PSocialRelaCond)
{
List<clsvgs_PSocialRelaEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsvgs_PSocialRelaEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convgs_PSocialRela.AttributeName)
{
if (objvgs_PSocialRelaCond.IsUpdated(strFldName) == false) continue;
if (objvgs_PSocialRelaCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvgs_PSocialRelaCond[strFldName].ToString());
}
else
{
if (objvgs_PSocialRelaCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvgs_PSocialRelaCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvgs_PSocialRelaCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvgs_PSocialRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvgs_PSocialRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvgs_PSocialRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvgs_PSocialRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvgs_PSocialRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvgs_PSocialRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvgs_PSocialRelaCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvgs_PSocialRelaCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvgs_PSocialRelaCond[strFldName]));
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
public static List<clsvgs_PSocialRelaEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsvgs_PSocialRelaEN> arrObjLst = new List<clsvgs_PSocialRelaEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvgs_PSocialRelaEN objvgs_PSocialRelaEN = new clsvgs_PSocialRelaEN();
try
{
objvgs_PSocialRelaEN.mId = Int32.Parse(objRow[convgs_PSocialRela.mId].ToString().Trim()); //mId
objvgs_PSocialRelaEN.PaperId = objRow[convgs_PSocialRela.PaperId].ToString().Trim(); //论文Id
objvgs_PSocialRelaEN.PaperTitle = objRow[convgs_PSocialRela.PaperTitle] == DBNull.Value ? null : objRow[convgs_PSocialRela.PaperTitle].ToString().Trim(); //论文标题
objvgs_PSocialRelaEN.PaperTypeId = objRow[convgs_PSocialRela.PaperTypeId] == DBNull.Value ? null : objRow[convgs_PSocialRela.PaperTypeId].ToString().Trim(); //论文类型Id
objvgs_PSocialRelaEN.SectionId = objRow[convgs_PSocialRela.SectionId] == DBNull.Value ? null : objRow[convgs_PSocialRela.SectionId].ToString().Trim(); //节Id
objvgs_PSocialRelaEN.SectionName = objRow[convgs_PSocialRela.SectionName] == DBNull.Value ? null : objRow[convgs_PSocialRela.SectionName].ToString().Trim(); //节名
objvgs_PSocialRelaEN.SocialId = objRow[convgs_PSocialRela.SocialId].ToString().Trim(); //社会Id
objvgs_PSocialRelaEN.UpdDate = objRow[convgs_PSocialRela.UpdDate] == DBNull.Value ? null : objRow[convgs_PSocialRela.UpdDate].ToString().Trim(); //修改日期
objvgs_PSocialRelaEN.UpdUser = objRow[convgs_PSocialRela.UpdUser] == DBNull.Value ? null : objRow[convgs_PSocialRela.UpdUser].ToString().Trim(); //修改人
objvgs_PSocialRelaEN.Memo = objRow[convgs_PSocialRela.Memo] == DBNull.Value ? null : objRow[convgs_PSocialRela.Memo].ToString().Trim(); //备注
objvgs_PSocialRelaEN.FullName = objRow[convgs_PSocialRela.FullName] == DBNull.Value ? null : objRow[convgs_PSocialRela.FullName].ToString().Trim(); //姓名
objvgs_PSocialRelaEN.Nationality = objRow[convgs_PSocialRela.Nationality] == DBNull.Value ? null : objRow[convgs_PSocialRela.Nationality].ToString().Trim(); //国籍
objvgs_PSocialRelaEN.WorkUnit = objRow[convgs_PSocialRela.WorkUnit] == DBNull.Value ? null : objRow[convgs_PSocialRela.WorkUnit].ToString().Trim(); //工作单位
objvgs_PSocialRelaEN.Major = objRow[convgs_PSocialRela.Major] == DBNull.Value ? null : objRow[convgs_PSocialRela.Major].ToString().Trim(); //专业
objvgs_PSocialRelaEN.Achievement = objRow[convgs_PSocialRela.Achievement] == DBNull.Value ? null : objRow[convgs_PSocialRela.Achievement].ToString().Trim(); //成就
objvgs_PSocialRelaEN.DetailedDescription = objRow[convgs_PSocialRela.DetailedDescription] == DBNull.Value ? null : objRow[convgs_PSocialRela.DetailedDescription].ToString().Trim(); //详细说明
objvgs_PSocialRelaEN.LevelId = objRow[convgs_PSocialRela.LevelId] == DBNull.Value ? null : objRow[convgs_PSocialRela.LevelId].ToString().Trim(); //级别Id
objvgs_PSocialRelaEN.LevelName = objRow[convgs_PSocialRela.LevelName] == DBNull.Value ? null : objRow[convgs_PSocialRela.LevelName].ToString().Trim(); //级别名称
objvgs_PSocialRelaEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[convgs_PSocialRela.IsSubmit].ToString().Trim()); //是否提交
objvgs_PSocialRelaEN.OkCount = objRow[convgs_PSocialRela.OkCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convgs_PSocialRela.OkCount].ToString().Trim()); //点赞统计
objvgs_PSocialRelaEN.CitationCount = objRow[convgs_PSocialRela.CitationCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convgs_PSocialRela.CitationCount].ToString().Trim()); //引用统计
objvgs_PSocialRelaEN.VersionCount = objRow[convgs_PSocialRela.VersionCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convgs_PSocialRela.VersionCount].ToString().Trim()); //版本统计
objvgs_PSocialRelaEN.AppraiseCount = objRow[convgs_PSocialRela.AppraiseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convgs_PSocialRela.AppraiseCount].ToString().Trim()); //评论数
objvgs_PSocialRelaEN.Score = objRow[convgs_PSocialRela.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convgs_PSocialRela.Score].ToString().Trim()); //评分
objvgs_PSocialRelaEN.StuScore = objRow[convgs_PSocialRela.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convgs_PSocialRela.StuScore].ToString().Trim()); //学生平均分
objvgs_PSocialRelaEN.TeaScore = objRow[convgs_PSocialRela.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convgs_PSocialRela.TeaScore].ToString().Trim()); //教师评分
objvgs_PSocialRelaEN.SocialUserId = objRow[convgs_PSocialRela.SocialUserId] == DBNull.Value ? null : objRow[convgs_PSocialRela.SocialUserId].ToString().Trim(); //SocialUserId
objvgs_PSocialRelaEN.SocialDate = objRow[convgs_PSocialRela.SocialDate] == DBNull.Value ? null : objRow[convgs_PSocialRela.SocialDate].ToString().Trim(); //SocialDate
objvgs_PSocialRelaEN.CreateDate = objRow[convgs_PSocialRela.CreateDate] == DBNull.Value ? null : objRow[convgs_PSocialRela.CreateDate].ToString().Trim(); //建立日期
objvgs_PSocialRelaEN.ShareId = objRow[convgs_PSocialRela.ShareId] == DBNull.Value ? null : objRow[convgs_PSocialRela.ShareId].ToString().Trim(); //分享Id
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvgs_PSocialRelaEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvgs_PSocialRelaEN);
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
public static List<clsvgs_PSocialRelaEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsvgs_PSocialRelaEN> arrObjLst = new List<clsvgs_PSocialRelaEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvgs_PSocialRelaEN objvgs_PSocialRelaEN = new clsvgs_PSocialRelaEN();
try
{
objvgs_PSocialRelaEN.mId = Int32.Parse(objRow[convgs_PSocialRela.mId].ToString().Trim()); //mId
objvgs_PSocialRelaEN.PaperId = objRow[convgs_PSocialRela.PaperId].ToString().Trim(); //论文Id
objvgs_PSocialRelaEN.PaperTitle = objRow[convgs_PSocialRela.PaperTitle] == DBNull.Value ? null : objRow[convgs_PSocialRela.PaperTitle].ToString().Trim(); //论文标题
objvgs_PSocialRelaEN.PaperTypeId = objRow[convgs_PSocialRela.PaperTypeId] == DBNull.Value ? null : objRow[convgs_PSocialRela.PaperTypeId].ToString().Trim(); //论文类型Id
objvgs_PSocialRelaEN.SectionId = objRow[convgs_PSocialRela.SectionId] == DBNull.Value ? null : objRow[convgs_PSocialRela.SectionId].ToString().Trim(); //节Id
objvgs_PSocialRelaEN.SectionName = objRow[convgs_PSocialRela.SectionName] == DBNull.Value ? null : objRow[convgs_PSocialRela.SectionName].ToString().Trim(); //节名
objvgs_PSocialRelaEN.SocialId = objRow[convgs_PSocialRela.SocialId].ToString().Trim(); //社会Id
objvgs_PSocialRelaEN.UpdDate = objRow[convgs_PSocialRela.UpdDate] == DBNull.Value ? null : objRow[convgs_PSocialRela.UpdDate].ToString().Trim(); //修改日期
objvgs_PSocialRelaEN.UpdUser = objRow[convgs_PSocialRela.UpdUser] == DBNull.Value ? null : objRow[convgs_PSocialRela.UpdUser].ToString().Trim(); //修改人
objvgs_PSocialRelaEN.Memo = objRow[convgs_PSocialRela.Memo] == DBNull.Value ? null : objRow[convgs_PSocialRela.Memo].ToString().Trim(); //备注
objvgs_PSocialRelaEN.FullName = objRow[convgs_PSocialRela.FullName] == DBNull.Value ? null : objRow[convgs_PSocialRela.FullName].ToString().Trim(); //姓名
objvgs_PSocialRelaEN.Nationality = objRow[convgs_PSocialRela.Nationality] == DBNull.Value ? null : objRow[convgs_PSocialRela.Nationality].ToString().Trim(); //国籍
objvgs_PSocialRelaEN.WorkUnit = objRow[convgs_PSocialRela.WorkUnit] == DBNull.Value ? null : objRow[convgs_PSocialRela.WorkUnit].ToString().Trim(); //工作单位
objvgs_PSocialRelaEN.Major = objRow[convgs_PSocialRela.Major] == DBNull.Value ? null : objRow[convgs_PSocialRela.Major].ToString().Trim(); //专业
objvgs_PSocialRelaEN.Achievement = objRow[convgs_PSocialRela.Achievement] == DBNull.Value ? null : objRow[convgs_PSocialRela.Achievement].ToString().Trim(); //成就
objvgs_PSocialRelaEN.DetailedDescription = objRow[convgs_PSocialRela.DetailedDescription] == DBNull.Value ? null : objRow[convgs_PSocialRela.DetailedDescription].ToString().Trim(); //详细说明
objvgs_PSocialRelaEN.LevelId = objRow[convgs_PSocialRela.LevelId] == DBNull.Value ? null : objRow[convgs_PSocialRela.LevelId].ToString().Trim(); //级别Id
objvgs_PSocialRelaEN.LevelName = objRow[convgs_PSocialRela.LevelName] == DBNull.Value ? null : objRow[convgs_PSocialRela.LevelName].ToString().Trim(); //级别名称
objvgs_PSocialRelaEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[convgs_PSocialRela.IsSubmit].ToString().Trim()); //是否提交
objvgs_PSocialRelaEN.OkCount = objRow[convgs_PSocialRela.OkCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convgs_PSocialRela.OkCount].ToString().Trim()); //点赞统计
objvgs_PSocialRelaEN.CitationCount = objRow[convgs_PSocialRela.CitationCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convgs_PSocialRela.CitationCount].ToString().Trim()); //引用统计
objvgs_PSocialRelaEN.VersionCount = objRow[convgs_PSocialRela.VersionCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convgs_PSocialRela.VersionCount].ToString().Trim()); //版本统计
objvgs_PSocialRelaEN.AppraiseCount = objRow[convgs_PSocialRela.AppraiseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convgs_PSocialRela.AppraiseCount].ToString().Trim()); //评论数
objvgs_PSocialRelaEN.Score = objRow[convgs_PSocialRela.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convgs_PSocialRela.Score].ToString().Trim()); //评分
objvgs_PSocialRelaEN.StuScore = objRow[convgs_PSocialRela.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convgs_PSocialRela.StuScore].ToString().Trim()); //学生平均分
objvgs_PSocialRelaEN.TeaScore = objRow[convgs_PSocialRela.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convgs_PSocialRela.TeaScore].ToString().Trim()); //教师评分
objvgs_PSocialRelaEN.SocialUserId = objRow[convgs_PSocialRela.SocialUserId] == DBNull.Value ? null : objRow[convgs_PSocialRela.SocialUserId].ToString().Trim(); //SocialUserId
objvgs_PSocialRelaEN.SocialDate = objRow[convgs_PSocialRela.SocialDate] == DBNull.Value ? null : objRow[convgs_PSocialRela.SocialDate].ToString().Trim(); //SocialDate
objvgs_PSocialRelaEN.CreateDate = objRow[convgs_PSocialRela.CreateDate] == DBNull.Value ? null : objRow[convgs_PSocialRela.CreateDate].ToString().Trim(); //建立日期
objvgs_PSocialRelaEN.ShareId = objRow[convgs_PSocialRela.ShareId] == DBNull.Value ? null : objRow[convgs_PSocialRela.ShareId].ToString().Trim(); //分享Id
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvgs_PSocialRelaEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvgs_PSocialRelaEN);
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
List<clsvgs_PSocialRelaEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsvgs_PSocialRelaEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsvgs_PSocialRelaEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsvgs_PSocialRelaEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsvgs_PSocialRelaEN> arrObjLst = new List<clsvgs_PSocialRelaEN>(); 
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
	clsvgs_PSocialRelaEN objvgs_PSocialRelaEN = new clsvgs_PSocialRelaEN();
try
{
objvgs_PSocialRelaEN.mId = Int32.Parse(objRow[convgs_PSocialRela.mId].ToString().Trim()); //mId
objvgs_PSocialRelaEN.PaperId = objRow[convgs_PSocialRela.PaperId].ToString().Trim(); //论文Id
objvgs_PSocialRelaEN.PaperTitle = objRow[convgs_PSocialRela.PaperTitle] == DBNull.Value ? null : objRow[convgs_PSocialRela.PaperTitle].ToString().Trim(); //论文标题
objvgs_PSocialRelaEN.PaperTypeId = objRow[convgs_PSocialRela.PaperTypeId] == DBNull.Value ? null : objRow[convgs_PSocialRela.PaperTypeId].ToString().Trim(); //论文类型Id
objvgs_PSocialRelaEN.SectionId = objRow[convgs_PSocialRela.SectionId] == DBNull.Value ? null : objRow[convgs_PSocialRela.SectionId].ToString().Trim(); //节Id
objvgs_PSocialRelaEN.SectionName = objRow[convgs_PSocialRela.SectionName] == DBNull.Value ? null : objRow[convgs_PSocialRela.SectionName].ToString().Trim(); //节名
objvgs_PSocialRelaEN.SocialId = objRow[convgs_PSocialRela.SocialId].ToString().Trim(); //社会Id
objvgs_PSocialRelaEN.UpdDate = objRow[convgs_PSocialRela.UpdDate] == DBNull.Value ? null : objRow[convgs_PSocialRela.UpdDate].ToString().Trim(); //修改日期
objvgs_PSocialRelaEN.UpdUser = objRow[convgs_PSocialRela.UpdUser] == DBNull.Value ? null : objRow[convgs_PSocialRela.UpdUser].ToString().Trim(); //修改人
objvgs_PSocialRelaEN.Memo = objRow[convgs_PSocialRela.Memo] == DBNull.Value ? null : objRow[convgs_PSocialRela.Memo].ToString().Trim(); //备注
objvgs_PSocialRelaEN.FullName = objRow[convgs_PSocialRela.FullName] == DBNull.Value ? null : objRow[convgs_PSocialRela.FullName].ToString().Trim(); //姓名
objvgs_PSocialRelaEN.Nationality = objRow[convgs_PSocialRela.Nationality] == DBNull.Value ? null : objRow[convgs_PSocialRela.Nationality].ToString().Trim(); //国籍
objvgs_PSocialRelaEN.WorkUnit = objRow[convgs_PSocialRela.WorkUnit] == DBNull.Value ? null : objRow[convgs_PSocialRela.WorkUnit].ToString().Trim(); //工作单位
objvgs_PSocialRelaEN.Major = objRow[convgs_PSocialRela.Major] == DBNull.Value ? null : objRow[convgs_PSocialRela.Major].ToString().Trim(); //专业
objvgs_PSocialRelaEN.Achievement = objRow[convgs_PSocialRela.Achievement] == DBNull.Value ? null : objRow[convgs_PSocialRela.Achievement].ToString().Trim(); //成就
objvgs_PSocialRelaEN.DetailedDescription = objRow[convgs_PSocialRela.DetailedDescription] == DBNull.Value ? null : objRow[convgs_PSocialRela.DetailedDescription].ToString().Trim(); //详细说明
objvgs_PSocialRelaEN.LevelId = objRow[convgs_PSocialRela.LevelId] == DBNull.Value ? null : objRow[convgs_PSocialRela.LevelId].ToString().Trim(); //级别Id
objvgs_PSocialRelaEN.LevelName = objRow[convgs_PSocialRela.LevelName] == DBNull.Value ? null : objRow[convgs_PSocialRela.LevelName].ToString().Trim(); //级别名称
objvgs_PSocialRelaEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[convgs_PSocialRela.IsSubmit].ToString().Trim()); //是否提交
objvgs_PSocialRelaEN.OkCount = objRow[convgs_PSocialRela.OkCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convgs_PSocialRela.OkCount].ToString().Trim()); //点赞统计
objvgs_PSocialRelaEN.CitationCount = objRow[convgs_PSocialRela.CitationCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convgs_PSocialRela.CitationCount].ToString().Trim()); //引用统计
objvgs_PSocialRelaEN.VersionCount = objRow[convgs_PSocialRela.VersionCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convgs_PSocialRela.VersionCount].ToString().Trim()); //版本统计
objvgs_PSocialRelaEN.AppraiseCount = objRow[convgs_PSocialRela.AppraiseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convgs_PSocialRela.AppraiseCount].ToString().Trim()); //评论数
objvgs_PSocialRelaEN.Score = objRow[convgs_PSocialRela.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convgs_PSocialRela.Score].ToString().Trim()); //评分
objvgs_PSocialRelaEN.StuScore = objRow[convgs_PSocialRela.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convgs_PSocialRela.StuScore].ToString().Trim()); //学生平均分
objvgs_PSocialRelaEN.TeaScore = objRow[convgs_PSocialRela.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convgs_PSocialRela.TeaScore].ToString().Trim()); //教师评分
objvgs_PSocialRelaEN.SocialUserId = objRow[convgs_PSocialRela.SocialUserId] == DBNull.Value ? null : objRow[convgs_PSocialRela.SocialUserId].ToString().Trim(); //SocialUserId
objvgs_PSocialRelaEN.SocialDate = objRow[convgs_PSocialRela.SocialDate] == DBNull.Value ? null : objRow[convgs_PSocialRela.SocialDate].ToString().Trim(); //SocialDate
objvgs_PSocialRelaEN.CreateDate = objRow[convgs_PSocialRela.CreateDate] == DBNull.Value ? null : objRow[convgs_PSocialRela.CreateDate].ToString().Trim(); //建立日期
objvgs_PSocialRelaEN.ShareId = objRow[convgs_PSocialRela.ShareId] == DBNull.Value ? null : objRow[convgs_PSocialRela.ShareId].ToString().Trim(); //分享Id
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvgs_PSocialRelaEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvgs_PSocialRelaEN);
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
public static List<clsvgs_PSocialRelaEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsvgs_PSocialRelaEN> arrObjLst = new List<clsvgs_PSocialRelaEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvgs_PSocialRelaEN objvgs_PSocialRelaEN = new clsvgs_PSocialRelaEN();
try
{
objvgs_PSocialRelaEN.mId = Int32.Parse(objRow[convgs_PSocialRela.mId].ToString().Trim()); //mId
objvgs_PSocialRelaEN.PaperId = objRow[convgs_PSocialRela.PaperId].ToString().Trim(); //论文Id
objvgs_PSocialRelaEN.PaperTitle = objRow[convgs_PSocialRela.PaperTitle] == DBNull.Value ? null : objRow[convgs_PSocialRela.PaperTitle].ToString().Trim(); //论文标题
objvgs_PSocialRelaEN.PaperTypeId = objRow[convgs_PSocialRela.PaperTypeId] == DBNull.Value ? null : objRow[convgs_PSocialRela.PaperTypeId].ToString().Trim(); //论文类型Id
objvgs_PSocialRelaEN.SectionId = objRow[convgs_PSocialRela.SectionId] == DBNull.Value ? null : objRow[convgs_PSocialRela.SectionId].ToString().Trim(); //节Id
objvgs_PSocialRelaEN.SectionName = objRow[convgs_PSocialRela.SectionName] == DBNull.Value ? null : objRow[convgs_PSocialRela.SectionName].ToString().Trim(); //节名
objvgs_PSocialRelaEN.SocialId = objRow[convgs_PSocialRela.SocialId].ToString().Trim(); //社会Id
objvgs_PSocialRelaEN.UpdDate = objRow[convgs_PSocialRela.UpdDate] == DBNull.Value ? null : objRow[convgs_PSocialRela.UpdDate].ToString().Trim(); //修改日期
objvgs_PSocialRelaEN.UpdUser = objRow[convgs_PSocialRela.UpdUser] == DBNull.Value ? null : objRow[convgs_PSocialRela.UpdUser].ToString().Trim(); //修改人
objvgs_PSocialRelaEN.Memo = objRow[convgs_PSocialRela.Memo] == DBNull.Value ? null : objRow[convgs_PSocialRela.Memo].ToString().Trim(); //备注
objvgs_PSocialRelaEN.FullName = objRow[convgs_PSocialRela.FullName] == DBNull.Value ? null : objRow[convgs_PSocialRela.FullName].ToString().Trim(); //姓名
objvgs_PSocialRelaEN.Nationality = objRow[convgs_PSocialRela.Nationality] == DBNull.Value ? null : objRow[convgs_PSocialRela.Nationality].ToString().Trim(); //国籍
objvgs_PSocialRelaEN.WorkUnit = objRow[convgs_PSocialRela.WorkUnit] == DBNull.Value ? null : objRow[convgs_PSocialRela.WorkUnit].ToString().Trim(); //工作单位
objvgs_PSocialRelaEN.Major = objRow[convgs_PSocialRela.Major] == DBNull.Value ? null : objRow[convgs_PSocialRela.Major].ToString().Trim(); //专业
objvgs_PSocialRelaEN.Achievement = objRow[convgs_PSocialRela.Achievement] == DBNull.Value ? null : objRow[convgs_PSocialRela.Achievement].ToString().Trim(); //成就
objvgs_PSocialRelaEN.DetailedDescription = objRow[convgs_PSocialRela.DetailedDescription] == DBNull.Value ? null : objRow[convgs_PSocialRela.DetailedDescription].ToString().Trim(); //详细说明
objvgs_PSocialRelaEN.LevelId = objRow[convgs_PSocialRela.LevelId] == DBNull.Value ? null : objRow[convgs_PSocialRela.LevelId].ToString().Trim(); //级别Id
objvgs_PSocialRelaEN.LevelName = objRow[convgs_PSocialRela.LevelName] == DBNull.Value ? null : objRow[convgs_PSocialRela.LevelName].ToString().Trim(); //级别名称
objvgs_PSocialRelaEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[convgs_PSocialRela.IsSubmit].ToString().Trim()); //是否提交
objvgs_PSocialRelaEN.OkCount = objRow[convgs_PSocialRela.OkCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convgs_PSocialRela.OkCount].ToString().Trim()); //点赞统计
objvgs_PSocialRelaEN.CitationCount = objRow[convgs_PSocialRela.CitationCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convgs_PSocialRela.CitationCount].ToString().Trim()); //引用统计
objvgs_PSocialRelaEN.VersionCount = objRow[convgs_PSocialRela.VersionCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convgs_PSocialRela.VersionCount].ToString().Trim()); //版本统计
objvgs_PSocialRelaEN.AppraiseCount = objRow[convgs_PSocialRela.AppraiseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convgs_PSocialRela.AppraiseCount].ToString().Trim()); //评论数
objvgs_PSocialRelaEN.Score = objRow[convgs_PSocialRela.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convgs_PSocialRela.Score].ToString().Trim()); //评分
objvgs_PSocialRelaEN.StuScore = objRow[convgs_PSocialRela.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convgs_PSocialRela.StuScore].ToString().Trim()); //学生平均分
objvgs_PSocialRelaEN.TeaScore = objRow[convgs_PSocialRela.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convgs_PSocialRela.TeaScore].ToString().Trim()); //教师评分
objvgs_PSocialRelaEN.SocialUserId = objRow[convgs_PSocialRela.SocialUserId] == DBNull.Value ? null : objRow[convgs_PSocialRela.SocialUserId].ToString().Trim(); //SocialUserId
objvgs_PSocialRelaEN.SocialDate = objRow[convgs_PSocialRela.SocialDate] == DBNull.Value ? null : objRow[convgs_PSocialRela.SocialDate].ToString().Trim(); //SocialDate
objvgs_PSocialRelaEN.CreateDate = objRow[convgs_PSocialRela.CreateDate] == DBNull.Value ? null : objRow[convgs_PSocialRela.CreateDate].ToString().Trim(); //建立日期
objvgs_PSocialRelaEN.ShareId = objRow[convgs_PSocialRela.ShareId] == DBNull.Value ? null : objRow[convgs_PSocialRela.ShareId].ToString().Trim(); //分享Id
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvgs_PSocialRelaEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvgs_PSocialRelaEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsvgs_PSocialRelaEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsvgs_PSocialRelaEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsvgs_PSocialRelaEN> arrObjLst = new List<clsvgs_PSocialRelaEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvgs_PSocialRelaEN objvgs_PSocialRelaEN = new clsvgs_PSocialRelaEN();
try
{
objvgs_PSocialRelaEN.mId = Int32.Parse(objRow[convgs_PSocialRela.mId].ToString().Trim()); //mId
objvgs_PSocialRelaEN.PaperId = objRow[convgs_PSocialRela.PaperId].ToString().Trim(); //论文Id
objvgs_PSocialRelaEN.PaperTitle = objRow[convgs_PSocialRela.PaperTitle] == DBNull.Value ? null : objRow[convgs_PSocialRela.PaperTitle].ToString().Trim(); //论文标题
objvgs_PSocialRelaEN.PaperTypeId = objRow[convgs_PSocialRela.PaperTypeId] == DBNull.Value ? null : objRow[convgs_PSocialRela.PaperTypeId].ToString().Trim(); //论文类型Id
objvgs_PSocialRelaEN.SectionId = objRow[convgs_PSocialRela.SectionId] == DBNull.Value ? null : objRow[convgs_PSocialRela.SectionId].ToString().Trim(); //节Id
objvgs_PSocialRelaEN.SectionName = objRow[convgs_PSocialRela.SectionName] == DBNull.Value ? null : objRow[convgs_PSocialRela.SectionName].ToString().Trim(); //节名
objvgs_PSocialRelaEN.SocialId = objRow[convgs_PSocialRela.SocialId].ToString().Trim(); //社会Id
objvgs_PSocialRelaEN.UpdDate = objRow[convgs_PSocialRela.UpdDate] == DBNull.Value ? null : objRow[convgs_PSocialRela.UpdDate].ToString().Trim(); //修改日期
objvgs_PSocialRelaEN.UpdUser = objRow[convgs_PSocialRela.UpdUser] == DBNull.Value ? null : objRow[convgs_PSocialRela.UpdUser].ToString().Trim(); //修改人
objvgs_PSocialRelaEN.Memo = objRow[convgs_PSocialRela.Memo] == DBNull.Value ? null : objRow[convgs_PSocialRela.Memo].ToString().Trim(); //备注
objvgs_PSocialRelaEN.FullName = objRow[convgs_PSocialRela.FullName] == DBNull.Value ? null : objRow[convgs_PSocialRela.FullName].ToString().Trim(); //姓名
objvgs_PSocialRelaEN.Nationality = objRow[convgs_PSocialRela.Nationality] == DBNull.Value ? null : objRow[convgs_PSocialRela.Nationality].ToString().Trim(); //国籍
objvgs_PSocialRelaEN.WorkUnit = objRow[convgs_PSocialRela.WorkUnit] == DBNull.Value ? null : objRow[convgs_PSocialRela.WorkUnit].ToString().Trim(); //工作单位
objvgs_PSocialRelaEN.Major = objRow[convgs_PSocialRela.Major] == DBNull.Value ? null : objRow[convgs_PSocialRela.Major].ToString().Trim(); //专业
objvgs_PSocialRelaEN.Achievement = objRow[convgs_PSocialRela.Achievement] == DBNull.Value ? null : objRow[convgs_PSocialRela.Achievement].ToString().Trim(); //成就
objvgs_PSocialRelaEN.DetailedDescription = objRow[convgs_PSocialRela.DetailedDescription] == DBNull.Value ? null : objRow[convgs_PSocialRela.DetailedDescription].ToString().Trim(); //详细说明
objvgs_PSocialRelaEN.LevelId = objRow[convgs_PSocialRela.LevelId] == DBNull.Value ? null : objRow[convgs_PSocialRela.LevelId].ToString().Trim(); //级别Id
objvgs_PSocialRelaEN.LevelName = objRow[convgs_PSocialRela.LevelName] == DBNull.Value ? null : objRow[convgs_PSocialRela.LevelName].ToString().Trim(); //级别名称
objvgs_PSocialRelaEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[convgs_PSocialRela.IsSubmit].ToString().Trim()); //是否提交
objvgs_PSocialRelaEN.OkCount = objRow[convgs_PSocialRela.OkCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convgs_PSocialRela.OkCount].ToString().Trim()); //点赞统计
objvgs_PSocialRelaEN.CitationCount = objRow[convgs_PSocialRela.CitationCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convgs_PSocialRela.CitationCount].ToString().Trim()); //引用统计
objvgs_PSocialRelaEN.VersionCount = objRow[convgs_PSocialRela.VersionCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convgs_PSocialRela.VersionCount].ToString().Trim()); //版本统计
objvgs_PSocialRelaEN.AppraiseCount = objRow[convgs_PSocialRela.AppraiseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convgs_PSocialRela.AppraiseCount].ToString().Trim()); //评论数
objvgs_PSocialRelaEN.Score = objRow[convgs_PSocialRela.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convgs_PSocialRela.Score].ToString().Trim()); //评分
objvgs_PSocialRelaEN.StuScore = objRow[convgs_PSocialRela.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convgs_PSocialRela.StuScore].ToString().Trim()); //学生平均分
objvgs_PSocialRelaEN.TeaScore = objRow[convgs_PSocialRela.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convgs_PSocialRela.TeaScore].ToString().Trim()); //教师评分
objvgs_PSocialRelaEN.SocialUserId = objRow[convgs_PSocialRela.SocialUserId] == DBNull.Value ? null : objRow[convgs_PSocialRela.SocialUserId].ToString().Trim(); //SocialUserId
objvgs_PSocialRelaEN.SocialDate = objRow[convgs_PSocialRela.SocialDate] == DBNull.Value ? null : objRow[convgs_PSocialRela.SocialDate].ToString().Trim(); //SocialDate
objvgs_PSocialRelaEN.CreateDate = objRow[convgs_PSocialRela.CreateDate] == DBNull.Value ? null : objRow[convgs_PSocialRela.CreateDate].ToString().Trim(); //建立日期
objvgs_PSocialRelaEN.ShareId = objRow[convgs_PSocialRela.ShareId] == DBNull.Value ? null : objRow[convgs_PSocialRela.ShareId].ToString().Trim(); //分享Id
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvgs_PSocialRelaEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvgs_PSocialRelaEN);
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
public static List<clsvgs_PSocialRelaEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsvgs_PSocialRelaEN> arrObjLst = new List<clsvgs_PSocialRelaEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvgs_PSocialRelaEN objvgs_PSocialRelaEN = new clsvgs_PSocialRelaEN();
try
{
objvgs_PSocialRelaEN.mId = Int32.Parse(objRow[convgs_PSocialRela.mId].ToString().Trim()); //mId
objvgs_PSocialRelaEN.PaperId = objRow[convgs_PSocialRela.PaperId].ToString().Trim(); //论文Id
objvgs_PSocialRelaEN.PaperTitle = objRow[convgs_PSocialRela.PaperTitle] == DBNull.Value ? null : objRow[convgs_PSocialRela.PaperTitle].ToString().Trim(); //论文标题
objvgs_PSocialRelaEN.PaperTypeId = objRow[convgs_PSocialRela.PaperTypeId] == DBNull.Value ? null : objRow[convgs_PSocialRela.PaperTypeId].ToString().Trim(); //论文类型Id
objvgs_PSocialRelaEN.SectionId = objRow[convgs_PSocialRela.SectionId] == DBNull.Value ? null : objRow[convgs_PSocialRela.SectionId].ToString().Trim(); //节Id
objvgs_PSocialRelaEN.SectionName = objRow[convgs_PSocialRela.SectionName] == DBNull.Value ? null : objRow[convgs_PSocialRela.SectionName].ToString().Trim(); //节名
objvgs_PSocialRelaEN.SocialId = objRow[convgs_PSocialRela.SocialId].ToString().Trim(); //社会Id
objvgs_PSocialRelaEN.UpdDate = objRow[convgs_PSocialRela.UpdDate] == DBNull.Value ? null : objRow[convgs_PSocialRela.UpdDate].ToString().Trim(); //修改日期
objvgs_PSocialRelaEN.UpdUser = objRow[convgs_PSocialRela.UpdUser] == DBNull.Value ? null : objRow[convgs_PSocialRela.UpdUser].ToString().Trim(); //修改人
objvgs_PSocialRelaEN.Memo = objRow[convgs_PSocialRela.Memo] == DBNull.Value ? null : objRow[convgs_PSocialRela.Memo].ToString().Trim(); //备注
objvgs_PSocialRelaEN.FullName = objRow[convgs_PSocialRela.FullName] == DBNull.Value ? null : objRow[convgs_PSocialRela.FullName].ToString().Trim(); //姓名
objvgs_PSocialRelaEN.Nationality = objRow[convgs_PSocialRela.Nationality] == DBNull.Value ? null : objRow[convgs_PSocialRela.Nationality].ToString().Trim(); //国籍
objvgs_PSocialRelaEN.WorkUnit = objRow[convgs_PSocialRela.WorkUnit] == DBNull.Value ? null : objRow[convgs_PSocialRela.WorkUnit].ToString().Trim(); //工作单位
objvgs_PSocialRelaEN.Major = objRow[convgs_PSocialRela.Major] == DBNull.Value ? null : objRow[convgs_PSocialRela.Major].ToString().Trim(); //专业
objvgs_PSocialRelaEN.Achievement = objRow[convgs_PSocialRela.Achievement] == DBNull.Value ? null : objRow[convgs_PSocialRela.Achievement].ToString().Trim(); //成就
objvgs_PSocialRelaEN.DetailedDescription = objRow[convgs_PSocialRela.DetailedDescription] == DBNull.Value ? null : objRow[convgs_PSocialRela.DetailedDescription].ToString().Trim(); //详细说明
objvgs_PSocialRelaEN.LevelId = objRow[convgs_PSocialRela.LevelId] == DBNull.Value ? null : objRow[convgs_PSocialRela.LevelId].ToString().Trim(); //级别Id
objvgs_PSocialRelaEN.LevelName = objRow[convgs_PSocialRela.LevelName] == DBNull.Value ? null : objRow[convgs_PSocialRela.LevelName].ToString().Trim(); //级别名称
objvgs_PSocialRelaEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[convgs_PSocialRela.IsSubmit].ToString().Trim()); //是否提交
objvgs_PSocialRelaEN.OkCount = objRow[convgs_PSocialRela.OkCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convgs_PSocialRela.OkCount].ToString().Trim()); //点赞统计
objvgs_PSocialRelaEN.CitationCount = objRow[convgs_PSocialRela.CitationCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convgs_PSocialRela.CitationCount].ToString().Trim()); //引用统计
objvgs_PSocialRelaEN.VersionCount = objRow[convgs_PSocialRela.VersionCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convgs_PSocialRela.VersionCount].ToString().Trim()); //版本统计
objvgs_PSocialRelaEN.AppraiseCount = objRow[convgs_PSocialRela.AppraiseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convgs_PSocialRela.AppraiseCount].ToString().Trim()); //评论数
objvgs_PSocialRelaEN.Score = objRow[convgs_PSocialRela.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convgs_PSocialRela.Score].ToString().Trim()); //评分
objvgs_PSocialRelaEN.StuScore = objRow[convgs_PSocialRela.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convgs_PSocialRela.StuScore].ToString().Trim()); //学生平均分
objvgs_PSocialRelaEN.TeaScore = objRow[convgs_PSocialRela.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convgs_PSocialRela.TeaScore].ToString().Trim()); //教师评分
objvgs_PSocialRelaEN.SocialUserId = objRow[convgs_PSocialRela.SocialUserId] == DBNull.Value ? null : objRow[convgs_PSocialRela.SocialUserId].ToString().Trim(); //SocialUserId
objvgs_PSocialRelaEN.SocialDate = objRow[convgs_PSocialRela.SocialDate] == DBNull.Value ? null : objRow[convgs_PSocialRela.SocialDate].ToString().Trim(); //SocialDate
objvgs_PSocialRelaEN.CreateDate = objRow[convgs_PSocialRela.CreateDate] == DBNull.Value ? null : objRow[convgs_PSocialRela.CreateDate].ToString().Trim(); //建立日期
objvgs_PSocialRelaEN.ShareId = objRow[convgs_PSocialRela.ShareId] == DBNull.Value ? null : objRow[convgs_PSocialRela.ShareId].ToString().Trim(); //分享Id
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvgs_PSocialRelaEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvgs_PSocialRelaEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsvgs_PSocialRelaEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsvgs_PSocialRelaEN> arrObjLst = new List<clsvgs_PSocialRelaEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvgs_PSocialRelaEN objvgs_PSocialRelaEN = new clsvgs_PSocialRelaEN();
try
{
objvgs_PSocialRelaEN.mId = Int32.Parse(objRow[convgs_PSocialRela.mId].ToString().Trim()); //mId
objvgs_PSocialRelaEN.PaperId = objRow[convgs_PSocialRela.PaperId].ToString().Trim(); //论文Id
objvgs_PSocialRelaEN.PaperTitle = objRow[convgs_PSocialRela.PaperTitle] == DBNull.Value ? null : objRow[convgs_PSocialRela.PaperTitle].ToString().Trim(); //论文标题
objvgs_PSocialRelaEN.PaperTypeId = objRow[convgs_PSocialRela.PaperTypeId] == DBNull.Value ? null : objRow[convgs_PSocialRela.PaperTypeId].ToString().Trim(); //论文类型Id
objvgs_PSocialRelaEN.SectionId = objRow[convgs_PSocialRela.SectionId] == DBNull.Value ? null : objRow[convgs_PSocialRela.SectionId].ToString().Trim(); //节Id
objvgs_PSocialRelaEN.SectionName = objRow[convgs_PSocialRela.SectionName] == DBNull.Value ? null : objRow[convgs_PSocialRela.SectionName].ToString().Trim(); //节名
objvgs_PSocialRelaEN.SocialId = objRow[convgs_PSocialRela.SocialId].ToString().Trim(); //社会Id
objvgs_PSocialRelaEN.UpdDate = objRow[convgs_PSocialRela.UpdDate] == DBNull.Value ? null : objRow[convgs_PSocialRela.UpdDate].ToString().Trim(); //修改日期
objvgs_PSocialRelaEN.UpdUser = objRow[convgs_PSocialRela.UpdUser] == DBNull.Value ? null : objRow[convgs_PSocialRela.UpdUser].ToString().Trim(); //修改人
objvgs_PSocialRelaEN.Memo = objRow[convgs_PSocialRela.Memo] == DBNull.Value ? null : objRow[convgs_PSocialRela.Memo].ToString().Trim(); //备注
objvgs_PSocialRelaEN.FullName = objRow[convgs_PSocialRela.FullName] == DBNull.Value ? null : objRow[convgs_PSocialRela.FullName].ToString().Trim(); //姓名
objvgs_PSocialRelaEN.Nationality = objRow[convgs_PSocialRela.Nationality] == DBNull.Value ? null : objRow[convgs_PSocialRela.Nationality].ToString().Trim(); //国籍
objvgs_PSocialRelaEN.WorkUnit = objRow[convgs_PSocialRela.WorkUnit] == DBNull.Value ? null : objRow[convgs_PSocialRela.WorkUnit].ToString().Trim(); //工作单位
objvgs_PSocialRelaEN.Major = objRow[convgs_PSocialRela.Major] == DBNull.Value ? null : objRow[convgs_PSocialRela.Major].ToString().Trim(); //专业
objvgs_PSocialRelaEN.Achievement = objRow[convgs_PSocialRela.Achievement] == DBNull.Value ? null : objRow[convgs_PSocialRela.Achievement].ToString().Trim(); //成就
objvgs_PSocialRelaEN.DetailedDescription = objRow[convgs_PSocialRela.DetailedDescription] == DBNull.Value ? null : objRow[convgs_PSocialRela.DetailedDescription].ToString().Trim(); //详细说明
objvgs_PSocialRelaEN.LevelId = objRow[convgs_PSocialRela.LevelId] == DBNull.Value ? null : objRow[convgs_PSocialRela.LevelId].ToString().Trim(); //级别Id
objvgs_PSocialRelaEN.LevelName = objRow[convgs_PSocialRela.LevelName] == DBNull.Value ? null : objRow[convgs_PSocialRela.LevelName].ToString().Trim(); //级别名称
objvgs_PSocialRelaEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[convgs_PSocialRela.IsSubmit].ToString().Trim()); //是否提交
objvgs_PSocialRelaEN.OkCount = objRow[convgs_PSocialRela.OkCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convgs_PSocialRela.OkCount].ToString().Trim()); //点赞统计
objvgs_PSocialRelaEN.CitationCount = objRow[convgs_PSocialRela.CitationCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convgs_PSocialRela.CitationCount].ToString().Trim()); //引用统计
objvgs_PSocialRelaEN.VersionCount = objRow[convgs_PSocialRela.VersionCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convgs_PSocialRela.VersionCount].ToString().Trim()); //版本统计
objvgs_PSocialRelaEN.AppraiseCount = objRow[convgs_PSocialRela.AppraiseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convgs_PSocialRela.AppraiseCount].ToString().Trim()); //评论数
objvgs_PSocialRelaEN.Score = objRow[convgs_PSocialRela.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convgs_PSocialRela.Score].ToString().Trim()); //评分
objvgs_PSocialRelaEN.StuScore = objRow[convgs_PSocialRela.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convgs_PSocialRela.StuScore].ToString().Trim()); //学生平均分
objvgs_PSocialRelaEN.TeaScore = objRow[convgs_PSocialRela.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convgs_PSocialRela.TeaScore].ToString().Trim()); //教师评分
objvgs_PSocialRelaEN.SocialUserId = objRow[convgs_PSocialRela.SocialUserId] == DBNull.Value ? null : objRow[convgs_PSocialRela.SocialUserId].ToString().Trim(); //SocialUserId
objvgs_PSocialRelaEN.SocialDate = objRow[convgs_PSocialRela.SocialDate] == DBNull.Value ? null : objRow[convgs_PSocialRela.SocialDate].ToString().Trim(); //SocialDate
objvgs_PSocialRelaEN.CreateDate = objRow[convgs_PSocialRela.CreateDate] == DBNull.Value ? null : objRow[convgs_PSocialRela.CreateDate].ToString().Trim(); //建立日期
objvgs_PSocialRelaEN.ShareId = objRow[convgs_PSocialRela.ShareId] == DBNull.Value ? null : objRow[convgs_PSocialRela.ShareId].ToString().Trim(); //分享Id
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvgs_PSocialRelaEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvgs_PSocialRelaEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objvgs_PSocialRelaEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool Getvgs_PSocialRela(ref clsvgs_PSocialRelaEN objvgs_PSocialRelaEN)
{
bool bolResult = vgs_PSocialRelaDA.Getvgs_PSocialRela(ref objvgs_PSocialRelaEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvgs_PSocialRelaEN GetObjBymId(long lngmId)
{
clsvgs_PSocialRelaEN objvgs_PSocialRelaEN = vgs_PSocialRelaDA.GetObjBymId(lngmId);
return objvgs_PSocialRelaEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsvgs_PSocialRelaEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsvgs_PSocialRelaEN objvgs_PSocialRelaEN = vgs_PSocialRelaDA.GetFirstObj(strWhereCond);
 return objvgs_PSocialRelaEN;
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
public static clsvgs_PSocialRelaEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsvgs_PSocialRelaEN objvgs_PSocialRelaEN = vgs_PSocialRelaDA.GetObjByDataRow(objRow);
 return objvgs_PSocialRelaEN;
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
public static clsvgs_PSocialRelaEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsvgs_PSocialRelaEN objvgs_PSocialRelaEN = vgs_PSocialRelaDA.GetObjByDataRow(objRow);
 return objvgs_PSocialRelaEN;
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
 /// <param name = "lstvgs_PSocialRelaObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvgs_PSocialRelaEN GetObjBymIdFromList(long lngmId, List<clsvgs_PSocialRelaEN> lstvgs_PSocialRelaObjLst)
{
foreach (clsvgs_PSocialRelaEN objvgs_PSocialRelaEN in lstvgs_PSocialRelaObjLst)
{
if (objvgs_PSocialRelaEN.mId == lngmId)
{
return objvgs_PSocialRelaEN;
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
 lngmId = new clsvgs_PSocialRelaDA().GetFirstID(strWhereCond);
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
 arrList = vgs_PSocialRelaDA.GetID(strWhereCond);
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
bool bolIsExist = vgs_PSocialRelaDA.IsExistCondRec(strWhereCond);
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
bool bolIsExist = vgs_PSocialRelaDA.IsExist(lngmId);
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
 bolIsExist = clsvgs_PSocialRelaDA.IsExistTable();
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
 bolIsExist = vgs_PSocialRelaDA.IsExistTable(strTabName);
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
 /// <param name = "objvgs_PSocialRelaENS">源对象</param>
 /// <param name = "objvgs_PSocialRelaENT">目标对象</param>
 public static void CopyTo(clsvgs_PSocialRelaEN objvgs_PSocialRelaENS, clsvgs_PSocialRelaEN objvgs_PSocialRelaENT)
{
try
{
objvgs_PSocialRelaENT.mId = objvgs_PSocialRelaENS.mId; //mId
objvgs_PSocialRelaENT.PaperId = objvgs_PSocialRelaENS.PaperId; //论文Id
objvgs_PSocialRelaENT.PaperTitle = objvgs_PSocialRelaENS.PaperTitle; //论文标题
objvgs_PSocialRelaENT.PaperTypeId = objvgs_PSocialRelaENS.PaperTypeId; //论文类型Id
objvgs_PSocialRelaENT.SectionId = objvgs_PSocialRelaENS.SectionId; //节Id
objvgs_PSocialRelaENT.SectionName = objvgs_PSocialRelaENS.SectionName; //节名
objvgs_PSocialRelaENT.SocialId = objvgs_PSocialRelaENS.SocialId; //社会Id
objvgs_PSocialRelaENT.UpdDate = objvgs_PSocialRelaENS.UpdDate; //修改日期
objvgs_PSocialRelaENT.UpdUser = objvgs_PSocialRelaENS.UpdUser; //修改人
objvgs_PSocialRelaENT.Memo = objvgs_PSocialRelaENS.Memo; //备注
objvgs_PSocialRelaENT.FullName = objvgs_PSocialRelaENS.FullName; //姓名
objvgs_PSocialRelaENT.Nationality = objvgs_PSocialRelaENS.Nationality; //国籍
objvgs_PSocialRelaENT.WorkUnit = objvgs_PSocialRelaENS.WorkUnit; //工作单位
objvgs_PSocialRelaENT.Major = objvgs_PSocialRelaENS.Major; //专业
objvgs_PSocialRelaENT.Achievement = objvgs_PSocialRelaENS.Achievement; //成就
objvgs_PSocialRelaENT.DetailedDescription = objvgs_PSocialRelaENS.DetailedDescription; //详细说明
objvgs_PSocialRelaENT.LevelId = objvgs_PSocialRelaENS.LevelId; //级别Id
objvgs_PSocialRelaENT.LevelName = objvgs_PSocialRelaENS.LevelName; //级别名称
objvgs_PSocialRelaENT.IsSubmit = objvgs_PSocialRelaENS.IsSubmit; //是否提交
objvgs_PSocialRelaENT.OkCount = objvgs_PSocialRelaENS.OkCount; //点赞统计
objvgs_PSocialRelaENT.CitationCount = objvgs_PSocialRelaENS.CitationCount; //引用统计
objvgs_PSocialRelaENT.VersionCount = objvgs_PSocialRelaENS.VersionCount; //版本统计
objvgs_PSocialRelaENT.AppraiseCount = objvgs_PSocialRelaENS.AppraiseCount; //评论数
objvgs_PSocialRelaENT.Score = objvgs_PSocialRelaENS.Score; //评分
objvgs_PSocialRelaENT.StuScore = objvgs_PSocialRelaENS.StuScore; //学生平均分
objvgs_PSocialRelaENT.TeaScore = objvgs_PSocialRelaENS.TeaScore; //教师评分
objvgs_PSocialRelaENT.SocialUserId = objvgs_PSocialRelaENS.SocialUserId; //SocialUserId
objvgs_PSocialRelaENT.SocialDate = objvgs_PSocialRelaENS.SocialDate; //SocialDate
objvgs_PSocialRelaENT.CreateDate = objvgs_PSocialRelaENS.CreateDate; //建立日期
objvgs_PSocialRelaENT.ShareId = objvgs_PSocialRelaENS.ShareId; //分享Id
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
 /// <param name = "objvgs_PSocialRelaEN">源简化对象</param>
 public static void SetUpdFlag(clsvgs_PSocialRelaEN objvgs_PSocialRelaEN)
{
try
{
objvgs_PSocialRelaEN.ClearUpdateState();
   string strsfUpdFldSetStr = objvgs_PSocialRelaEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(convgs_PSocialRela.mId, new clsStrCompareIgnoreCase())  ==  true)
{
objvgs_PSocialRelaEN.mId = objvgs_PSocialRelaEN.mId; //mId
}
if (arrFldSet.Contains(convgs_PSocialRela.PaperId, new clsStrCompareIgnoreCase())  ==  true)
{
objvgs_PSocialRelaEN.PaperId = objvgs_PSocialRelaEN.PaperId; //论文Id
}
if (arrFldSet.Contains(convgs_PSocialRela.PaperTitle, new clsStrCompareIgnoreCase())  ==  true)
{
objvgs_PSocialRelaEN.PaperTitle = objvgs_PSocialRelaEN.PaperTitle == "[null]" ? null :  objvgs_PSocialRelaEN.PaperTitle; //论文标题
}
if (arrFldSet.Contains(convgs_PSocialRela.PaperTypeId, new clsStrCompareIgnoreCase())  ==  true)
{
objvgs_PSocialRelaEN.PaperTypeId = objvgs_PSocialRelaEN.PaperTypeId == "[null]" ? null :  objvgs_PSocialRelaEN.PaperTypeId; //论文类型Id
}
if (arrFldSet.Contains(convgs_PSocialRela.SectionId, new clsStrCompareIgnoreCase())  ==  true)
{
objvgs_PSocialRelaEN.SectionId = objvgs_PSocialRelaEN.SectionId == "[null]" ? null :  objvgs_PSocialRelaEN.SectionId; //节Id
}
if (arrFldSet.Contains(convgs_PSocialRela.SectionName, new clsStrCompareIgnoreCase())  ==  true)
{
objvgs_PSocialRelaEN.SectionName = objvgs_PSocialRelaEN.SectionName == "[null]" ? null :  objvgs_PSocialRelaEN.SectionName; //节名
}
if (arrFldSet.Contains(convgs_PSocialRela.SocialId, new clsStrCompareIgnoreCase())  ==  true)
{
objvgs_PSocialRelaEN.SocialId = objvgs_PSocialRelaEN.SocialId; //社会Id
}
if (arrFldSet.Contains(convgs_PSocialRela.UpdDate, new clsStrCompareIgnoreCase())  ==  true)
{
objvgs_PSocialRelaEN.UpdDate = objvgs_PSocialRelaEN.UpdDate == "[null]" ? null :  objvgs_PSocialRelaEN.UpdDate; //修改日期
}
if (arrFldSet.Contains(convgs_PSocialRela.UpdUser, new clsStrCompareIgnoreCase())  ==  true)
{
objvgs_PSocialRelaEN.UpdUser = objvgs_PSocialRelaEN.UpdUser == "[null]" ? null :  objvgs_PSocialRelaEN.UpdUser; //修改人
}
if (arrFldSet.Contains(convgs_PSocialRela.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objvgs_PSocialRelaEN.Memo = objvgs_PSocialRelaEN.Memo == "[null]" ? null :  objvgs_PSocialRelaEN.Memo; //备注
}
if (arrFldSet.Contains(convgs_PSocialRela.FullName, new clsStrCompareIgnoreCase())  ==  true)
{
objvgs_PSocialRelaEN.FullName = objvgs_PSocialRelaEN.FullName == "[null]" ? null :  objvgs_PSocialRelaEN.FullName; //姓名
}
if (arrFldSet.Contains(convgs_PSocialRela.Nationality, new clsStrCompareIgnoreCase())  ==  true)
{
objvgs_PSocialRelaEN.Nationality = objvgs_PSocialRelaEN.Nationality == "[null]" ? null :  objvgs_PSocialRelaEN.Nationality; //国籍
}
if (arrFldSet.Contains(convgs_PSocialRela.WorkUnit, new clsStrCompareIgnoreCase())  ==  true)
{
objvgs_PSocialRelaEN.WorkUnit = objvgs_PSocialRelaEN.WorkUnit == "[null]" ? null :  objvgs_PSocialRelaEN.WorkUnit; //工作单位
}
if (arrFldSet.Contains(convgs_PSocialRela.Major, new clsStrCompareIgnoreCase())  ==  true)
{
objvgs_PSocialRelaEN.Major = objvgs_PSocialRelaEN.Major == "[null]" ? null :  objvgs_PSocialRelaEN.Major; //专业
}
if (arrFldSet.Contains(convgs_PSocialRela.Achievement, new clsStrCompareIgnoreCase())  ==  true)
{
objvgs_PSocialRelaEN.Achievement = objvgs_PSocialRelaEN.Achievement == "[null]" ? null :  objvgs_PSocialRelaEN.Achievement; //成就
}
if (arrFldSet.Contains(convgs_PSocialRela.DetailedDescription, new clsStrCompareIgnoreCase())  ==  true)
{
objvgs_PSocialRelaEN.DetailedDescription = objvgs_PSocialRelaEN.DetailedDescription == "[null]" ? null :  objvgs_PSocialRelaEN.DetailedDescription; //详细说明
}
if (arrFldSet.Contains(convgs_PSocialRela.LevelId, new clsStrCompareIgnoreCase())  ==  true)
{
objvgs_PSocialRelaEN.LevelId = objvgs_PSocialRelaEN.LevelId == "[null]" ? null :  objvgs_PSocialRelaEN.LevelId; //级别Id
}
if (arrFldSet.Contains(convgs_PSocialRela.LevelName, new clsStrCompareIgnoreCase())  ==  true)
{
objvgs_PSocialRelaEN.LevelName = objvgs_PSocialRelaEN.LevelName == "[null]" ? null :  objvgs_PSocialRelaEN.LevelName; //级别名称
}
if (arrFldSet.Contains(convgs_PSocialRela.IsSubmit, new clsStrCompareIgnoreCase())  ==  true)
{
objvgs_PSocialRelaEN.IsSubmit = objvgs_PSocialRelaEN.IsSubmit; //是否提交
}
if (arrFldSet.Contains(convgs_PSocialRela.OkCount, new clsStrCompareIgnoreCase())  ==  true)
{
objvgs_PSocialRelaEN.OkCount = objvgs_PSocialRelaEN.OkCount; //点赞统计
}
if (arrFldSet.Contains(convgs_PSocialRela.CitationCount, new clsStrCompareIgnoreCase())  ==  true)
{
objvgs_PSocialRelaEN.CitationCount = objvgs_PSocialRelaEN.CitationCount; //引用统计
}
if (arrFldSet.Contains(convgs_PSocialRela.VersionCount, new clsStrCompareIgnoreCase())  ==  true)
{
objvgs_PSocialRelaEN.VersionCount = objvgs_PSocialRelaEN.VersionCount; //版本统计
}
if (arrFldSet.Contains(convgs_PSocialRela.AppraiseCount, new clsStrCompareIgnoreCase())  ==  true)
{
objvgs_PSocialRelaEN.AppraiseCount = objvgs_PSocialRelaEN.AppraiseCount; //评论数
}
if (arrFldSet.Contains(convgs_PSocialRela.Score, new clsStrCompareIgnoreCase())  ==  true)
{
objvgs_PSocialRelaEN.Score = objvgs_PSocialRelaEN.Score; //评分
}
if (arrFldSet.Contains(convgs_PSocialRela.StuScore, new clsStrCompareIgnoreCase())  ==  true)
{
objvgs_PSocialRelaEN.StuScore = objvgs_PSocialRelaEN.StuScore; //学生平均分
}
if (arrFldSet.Contains(convgs_PSocialRela.TeaScore, new clsStrCompareIgnoreCase())  ==  true)
{
objvgs_PSocialRelaEN.TeaScore = objvgs_PSocialRelaEN.TeaScore; //教师评分
}
if (arrFldSet.Contains(convgs_PSocialRela.SocialUserId, new clsStrCompareIgnoreCase())  ==  true)
{
objvgs_PSocialRelaEN.SocialUserId = objvgs_PSocialRelaEN.SocialUserId == "[null]" ? null :  objvgs_PSocialRelaEN.SocialUserId; //SocialUserId
}
if (arrFldSet.Contains(convgs_PSocialRela.SocialDate, new clsStrCompareIgnoreCase())  ==  true)
{
objvgs_PSocialRelaEN.SocialDate = objvgs_PSocialRelaEN.SocialDate == "[null]" ? null :  objvgs_PSocialRelaEN.SocialDate; //SocialDate
}
if (arrFldSet.Contains(convgs_PSocialRela.CreateDate, new clsStrCompareIgnoreCase())  ==  true)
{
objvgs_PSocialRelaEN.CreateDate = objvgs_PSocialRelaEN.CreateDate == "[null]" ? null :  objvgs_PSocialRelaEN.CreateDate; //建立日期
}
if (arrFldSet.Contains(convgs_PSocialRela.ShareId, new clsStrCompareIgnoreCase())  ==  true)
{
objvgs_PSocialRelaEN.ShareId = objvgs_PSocialRelaEN.ShareId == "[null]" ? null :  objvgs_PSocialRelaEN.ShareId; //分享Id
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
 /// <param name = "objvgs_PSocialRelaEN">源简化对象</param>
 public static void AccessFldValueNull(clsvgs_PSocialRelaEN objvgs_PSocialRelaEN)
{
try
{
if (objvgs_PSocialRelaEN.PaperTitle == "[null]") objvgs_PSocialRelaEN.PaperTitle = null; //论文标题
if (objvgs_PSocialRelaEN.PaperTypeId == "[null]") objvgs_PSocialRelaEN.PaperTypeId = null; //论文类型Id
if (objvgs_PSocialRelaEN.SectionId == "[null]") objvgs_PSocialRelaEN.SectionId = null; //节Id
if (objvgs_PSocialRelaEN.SectionName == "[null]") objvgs_PSocialRelaEN.SectionName = null; //节名
if (objvgs_PSocialRelaEN.UpdDate == "[null]") objvgs_PSocialRelaEN.UpdDate = null; //修改日期
if (objvgs_PSocialRelaEN.UpdUser == "[null]") objvgs_PSocialRelaEN.UpdUser = null; //修改人
if (objvgs_PSocialRelaEN.Memo == "[null]") objvgs_PSocialRelaEN.Memo = null; //备注
if (objvgs_PSocialRelaEN.FullName == "[null]") objvgs_PSocialRelaEN.FullName = null; //姓名
if (objvgs_PSocialRelaEN.Nationality == "[null]") objvgs_PSocialRelaEN.Nationality = null; //国籍
if (objvgs_PSocialRelaEN.WorkUnit == "[null]") objvgs_PSocialRelaEN.WorkUnit = null; //工作单位
if (objvgs_PSocialRelaEN.Major == "[null]") objvgs_PSocialRelaEN.Major = null; //专业
if (objvgs_PSocialRelaEN.Achievement == "[null]") objvgs_PSocialRelaEN.Achievement = null; //成就
if (objvgs_PSocialRelaEN.DetailedDescription == "[null]") objvgs_PSocialRelaEN.DetailedDescription = null; //详细说明
if (objvgs_PSocialRelaEN.LevelId == "[null]") objvgs_PSocialRelaEN.LevelId = null; //级别Id
if (objvgs_PSocialRelaEN.LevelName == "[null]") objvgs_PSocialRelaEN.LevelName = null; //级别名称
if (objvgs_PSocialRelaEN.SocialUserId == "[null]") objvgs_PSocialRelaEN.SocialUserId = null; //SocialUserId
if (objvgs_PSocialRelaEN.SocialDate == "[null]") objvgs_PSocialRelaEN.SocialDate = null; //SocialDate
if (objvgs_PSocialRelaEN.CreateDate == "[null]") objvgs_PSocialRelaEN.CreateDate = null; //建立日期
if (objvgs_PSocialRelaEN.ShareId == "[null]") objvgs_PSocialRelaEN.ShareId = null; //分享Id
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
public static void CheckProperty4Condition(clsvgs_PSocialRelaEN objvgs_PSocialRelaEN)
{
 vgs_PSocialRelaDA.CheckProperty4Condition(objvgs_PSocialRelaEN);
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
string strCondition = string.Format("1 =1 Order By {0}", convgs_PSocialRela.mId); 
List<clsvgs_PSocialRelaEN> arrObjLst = clsvgs_PSocialRelaBL.GetObjLst(strCondition);
//初始化一个对象列表
//插入第0项。在第0项中插入“请选择...”,为了方便用户,与WEB方式类似。
clsvgs_PSocialRelaEN objvgs_PSocialRelaEN = new clsvgs_PSocialRelaEN()
{
mId = 0,
LevelId = "选[论文社会关系视图]..."
};
arrObjLst.Insert(0, objvgs_PSocialRelaEN);
//设置下拉框的数据源、以及设置值项、显示项
objComboBox.ValueMember = convgs_PSocialRela.mId;
objComboBox.DisplayMember = convgs_PSocialRela.LevelId;
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
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[论文社会关系视图]...","0");
string strCondition = string.Format("1 =1 Order By {0}", convgs_PSocialRela.mId); 
IEnumerable<clsvgs_PSocialRelaEN> arrObjLst = clsvgs_PSocialRelaBL.GetObjLst(strCondition);
objDDL.DataValueField = convgs_PSocialRela.mId;
objDDL.DataTextField = convgs_PSocialRela.LevelId;
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
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[论文社会关系视图]...","0");
List<clsvgs_PSocialRelaEN> arrvgs_PSocialRelaObjLst = GetAllvgs_PSocialRelaObjLstCache(); 
objDDL.DataValueField = convgs_PSocialRela.mId;
objDDL.DataTextField = convgs_PSocialRela.LevelId;
objDDL.DataSource = arrvgs_PSocialRelaObjLst;
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
if (clsgs_PSocialRelaBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsgs_PSocialRelaBL没有刷新缓存机制(clsgs_PSocialRelaBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsSysSocialRelationsBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsSysSocialRelationsBL没有刷新缓存机制(clsSysSocialRelationsBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsSysSecurityLevelBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsSysSecurityLevelBL没有刷新缓存机制(clsSysSecurityLevelBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by mId");
//if (arrvgs_PSocialRelaObjLstCache == null)
//{
//arrvgs_PSocialRelaObjLstCache = vgs_PSocialRelaDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "lngmId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvgs_PSocialRelaEN GetObjBymIdCache(long lngmId)
{
//获取缓存中的对象列表
string strKey = string.Format("{0}", clsvgs_PSocialRelaEN._CurrTabName);
List<clsvgs_PSocialRelaEN> arrvgs_PSocialRelaObjLstCache = GetObjLstCache();
IEnumerable <clsvgs_PSocialRelaEN> arrvgs_PSocialRelaObjLst_Sel =
arrvgs_PSocialRelaObjLstCache
.Where(x=> x.mId == lngmId 
);
if (arrvgs_PSocialRelaObjLst_Sel.Count() == 0)
{
   clsvgs_PSocialRelaEN obj = clsvgs_PSocialRelaBL.GetObjBymId(lngmId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
 }
return null;
}
return arrvgs_PSocialRelaObjLst_Sel.First();
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
clsvgs_PSocialRelaEN objvgs_PSocialRela = GetObjBymIdCache(lngmId);
if (objvgs_PSocialRela == null) return "";
return objvgs_PSocialRela.LevelId;
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
clsvgs_PSocialRelaEN objvgs_PSocialRela = GetObjBymIdCache(lngmId);
if (objvgs_PSocialRela == null) return "";
return objvgs_PSocialRela.LevelId;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvgs_PSocialRelaEN> GetAllvgs_PSocialRelaObjLstCache()
{
//获取缓存中的对象列表
List<clsvgs_PSocialRelaEN> arrvgs_PSocialRelaObjLstCache = GetObjLstCache(); 
return arrvgs_PSocialRelaObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvgs_PSocialRelaEN> GetObjLstCache()
{
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}", clsvgs_PSocialRelaEN._CurrTabName);
List<clsvgs_PSocialRelaEN> arrvgs_PSocialRelaObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrvgs_PSocialRelaObjLstCache;
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
string strKey = string.Format("{0}", clsvgs_PSocialRelaEN._CurrTabName);
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
if (strInFldName != convgs_PSocialRela.mId)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (convgs_PSocialRela.AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", convgs_PSocialRela.AttributeName));
throw new Exception(strMsg);
}
var objvgs_PSocialRela = clsvgs_PSocialRelaBL.GetObjBymIdCache(lngmId);
if (objvgs_PSocialRela == null) return "";
return objvgs_PSocialRela[strOutFldName].ToString();
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
int intRecCount = clsvgs_PSocialRelaDA.GetRecCount(strTabName);
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
int intRecCount = clsvgs_PSocialRelaDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsvgs_PSocialRelaDA.GetRecCount();
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
int intRecCount = clsvgs_PSocialRelaDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objvgs_PSocialRelaCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsvgs_PSocialRelaEN objvgs_PSocialRelaCond)
{
List<clsvgs_PSocialRelaEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsvgs_PSocialRelaEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convgs_PSocialRela.AttributeName)
{
if (objvgs_PSocialRelaCond.IsUpdated(strFldName) == false) continue;
if (objvgs_PSocialRelaCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvgs_PSocialRelaCond[strFldName].ToString());
}
else
{
if (objvgs_PSocialRelaCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvgs_PSocialRelaCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvgs_PSocialRelaCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvgs_PSocialRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvgs_PSocialRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvgs_PSocialRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvgs_PSocialRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvgs_PSocialRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvgs_PSocialRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvgs_PSocialRelaCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvgs_PSocialRelaCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvgs_PSocialRelaCond[strFldName]));
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
 List<string> arrList = clsvgs_PSocialRelaDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = vgs_PSocialRelaDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = vgs_PSocialRelaDA.GetFldValueNoDistinct(strFldName, strWhereCond);
return arrList;
}



 #endregion 表操作常用函数
}
}