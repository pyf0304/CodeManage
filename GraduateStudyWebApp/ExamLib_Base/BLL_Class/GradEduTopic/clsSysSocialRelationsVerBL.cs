
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsSysSocialRelationsVerBL
 表名:SysSocialRelationsVer(01120645)
 * 版本:2024.11.13.1(服务器:WIN-SRV103-116)
 日期:2024/11/13 06:09:08
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:研究生学习游戏化后台(000055, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:研培主题(GradEduTopic)
 框架-层名:业务逻辑层(CS)(BusinessLogic,0003)
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
public static class  clsSysSocialRelationsVerBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "lngSocialVId">表关键字</param>
 /// <returns>表对象</returns>
public static clsSysSocialRelationsVerEN GetObj(this K_SocialVId_SysSocialRelationsVer myKey)
{
clsSysSocialRelationsVerEN objSysSocialRelationsVerEN = clsSysSocialRelationsVerBL.SysSocialRelationsVerDA.GetObjBySocialVId(myKey.Value);
return objSysSocialRelationsVerEN;
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_AddNewRecord)
 /// </summary>
 /// <param name = "objSysSocialRelationsVerEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clsSysSocialRelationsVerEN objSysSocialRelationsVerEN, bool bolIsNeedCheckUniqueness = true)
{
if (bolIsNeedCheckUniqueness == true && CheckUniqueness(objSysSocialRelationsVerEN) == false)
{
var strMsg = string.Format("记录已经存在!社会Id = [{0}]的数据已经存在!(in clsSysSocialRelationsVerBL.AddNewRecord)", objSysSocialRelationsVerEN.SocialId);
throw new Exception(strMsg);
}
try
{
bool bolResult = clsSysSocialRelationsVerBL.SysSocialRelationsVerDA.AddNewRecordBySQL2(objSysSocialRelationsVerEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsSysSocialRelationsVerBL.ReFreshCache();

if (clsSysSocialRelationsVerBL.relatedActions != null)
{
clsSysSocialRelationsVerBL.relatedActions.UpdRelaTabDate(objSysSocialRelationsVerEN.SocialVId, "SetUpdDate");
}
return bolResult;
}
catch (Exception objException)
{
string strMsg = string.Format("(errid:Busi000082)添加记录出错, {1}.(from {0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
}
}

 /// <summary>
 /// 插入记录存盘到数据表中
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_AddRecordEx)
 /// </summary>
 /// <returns>插入记录是否成功？</returns>
public static bool AddRecordEx(this clsSysSocialRelationsVerEN objSysSocialRelationsVerEN, bool bolIsNeedCheckUniqueness = true)
{
//操作步骤:
//1、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在
//2、检查唯一性
//3、检查传进去的对象属性是否合法
//4、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
//1、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在
try
{
 //2、检查传进去的对象属性是否合法
objSysSocialRelationsVerEN.CheckPropertyNew();
 ///5.2、检查唯一性
if (bolIsNeedCheckUniqueness == true && objSysSocialRelationsVerEN.CheckUniqueness() == false)
{
strMsg = string.Format("(社会Id(SocialId)=[{0}])已经存在,不能重复!", objSysSocialRelationsVerEN.SocialId);
throw new Exception(strMsg);
}
//6、把数据实体层的数据存贮到数据库中
objSysSocialRelationsVerEN.AddNewRecord();
}
catch(Exception objException)
{
strMsg = "(errid:Busi000152)添加记录不成功!" + objException.Message;
throw new Exception(strMsg);
}
return true;
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_AddNewRecordWithReturnKey)
 /// </summary>
 /// <param name = "objSysSocialRelationsVerEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordWithReturnKey(this clsSysSocialRelationsVerEN objSysSocialRelationsVerEN, bool bolIsNeedCheckUniqueness = true)
{
if (bolIsNeedCheckUniqueness == true && CheckUniqueness(objSysSocialRelationsVerEN) == false)
{
var strMsg = string.Format("记录已经存在!社会Id = [{0}]的数据已经存在!(in clsSysSocialRelationsVerBL.AddNewRecordWithReturnKey)", objSysSocialRelationsVerEN.SocialId);
throw new Exception(strMsg);
}
try
{
string strKey = clsSysSocialRelationsVerBL.SysSocialRelationsVerDA.AddNewRecordBySQL2WithReturnKey(objSysSocialRelationsVerEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsSysSocialRelationsVerBL.ReFreshCache();

if (clsSysSocialRelationsVerBL.relatedActions != null)
{
clsSysSocialRelationsVerBL.relatedActions.UpdRelaTabDate(objSysSocialRelationsVerEN.SocialVId, "SetUpdDate");
}
return strKey;
}
catch (Exception objException)
{
string strMsg = string.Format("(errid:Busi000091)带返回值的添加记录出错, {1}.(from {0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
}
}

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objSysSocialRelationsVerEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsSysSocialRelationsVerEN SetSocialVId(this clsSysSocialRelationsVerEN objSysSocialRelationsVerEN, long lngSocialVId, string strComparisonOp="")
	{
objSysSocialRelationsVerEN.SocialVId = lngSocialVId; //SocialVId
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objSysSocialRelationsVerEN.dicFldComparisonOp.ContainsKey(conSysSocialRelationsVer.SocialVId) == false)
{
objSysSocialRelationsVerEN.dicFldComparisonOp.Add(conSysSocialRelationsVer.SocialVId, strComparisonOp);
}
else
{
objSysSocialRelationsVerEN.dicFldComparisonOp[conSysSocialRelationsVer.SocialVId] = strComparisonOp;
}
}
return objSysSocialRelationsVerEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objSysSocialRelationsVerEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsSysSocialRelationsVerEN SetSocialId(this clsSysSocialRelationsVerEN objSysSocialRelationsVerEN, string strSocialId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strSocialId, conSysSocialRelationsVer.SocialId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strSocialId, 10, conSysSocialRelationsVer.SocialId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strSocialId, 10, conSysSocialRelationsVer.SocialId);
}
objSysSocialRelationsVerEN.SocialId = strSocialId; //社会Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objSysSocialRelationsVerEN.dicFldComparisonOp.ContainsKey(conSysSocialRelationsVer.SocialId) == false)
{
objSysSocialRelationsVerEN.dicFldComparisonOp.Add(conSysSocialRelationsVer.SocialId, strComparisonOp);
}
else
{
objSysSocialRelationsVerEN.dicFldComparisonOp[conSysSocialRelationsVer.SocialId] = strComparisonOp;
}
}
return objSysSocialRelationsVerEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objSysSocialRelationsVerEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsSysSocialRelationsVerEN SetFullName(this clsSysSocialRelationsVerEN objSysSocialRelationsVerEN, string strFullName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFullName, 50, conSysSocialRelationsVer.FullName);
}
objSysSocialRelationsVerEN.FullName = strFullName; //姓名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objSysSocialRelationsVerEN.dicFldComparisonOp.ContainsKey(conSysSocialRelationsVer.FullName) == false)
{
objSysSocialRelationsVerEN.dicFldComparisonOp.Add(conSysSocialRelationsVer.FullName, strComparisonOp);
}
else
{
objSysSocialRelationsVerEN.dicFldComparisonOp[conSysSocialRelationsVer.FullName] = strComparisonOp;
}
}
return objSysSocialRelationsVerEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objSysSocialRelationsVerEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsSysSocialRelationsVerEN SetNationality(this clsSysSocialRelationsVerEN objSysSocialRelationsVerEN, string strNationality, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strNationality, 50, conSysSocialRelationsVer.Nationality);
}
objSysSocialRelationsVerEN.Nationality = strNationality; //国籍
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objSysSocialRelationsVerEN.dicFldComparisonOp.ContainsKey(conSysSocialRelationsVer.Nationality) == false)
{
objSysSocialRelationsVerEN.dicFldComparisonOp.Add(conSysSocialRelationsVer.Nationality, strComparisonOp);
}
else
{
objSysSocialRelationsVerEN.dicFldComparisonOp[conSysSocialRelationsVer.Nationality] = strComparisonOp;
}
}
return objSysSocialRelationsVerEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objSysSocialRelationsVerEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsSysSocialRelationsVerEN SetWorkUnit(this clsSysSocialRelationsVerEN objSysSocialRelationsVerEN, string strWorkUnit, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strWorkUnit, 100, conSysSocialRelationsVer.WorkUnit);
}
objSysSocialRelationsVerEN.WorkUnit = strWorkUnit; //工作单位
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objSysSocialRelationsVerEN.dicFldComparisonOp.ContainsKey(conSysSocialRelationsVer.WorkUnit) == false)
{
objSysSocialRelationsVerEN.dicFldComparisonOp.Add(conSysSocialRelationsVer.WorkUnit, strComparisonOp);
}
else
{
objSysSocialRelationsVerEN.dicFldComparisonOp[conSysSocialRelationsVer.WorkUnit] = strComparisonOp;
}
}
return objSysSocialRelationsVerEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objSysSocialRelationsVerEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsSysSocialRelationsVerEN SetMajor(this clsSysSocialRelationsVerEN objSysSocialRelationsVerEN, string strMajor, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMajor, 50, conSysSocialRelationsVer.Major);
}
objSysSocialRelationsVerEN.Major = strMajor; //专业
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objSysSocialRelationsVerEN.dicFldComparisonOp.ContainsKey(conSysSocialRelationsVer.Major) == false)
{
objSysSocialRelationsVerEN.dicFldComparisonOp.Add(conSysSocialRelationsVer.Major, strComparisonOp);
}
else
{
objSysSocialRelationsVerEN.dicFldComparisonOp[conSysSocialRelationsVer.Major] = strComparisonOp;
}
}
return objSysSocialRelationsVerEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objSysSocialRelationsVerEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsSysSocialRelationsVerEN SetAchievement(this clsSysSocialRelationsVerEN objSysSocialRelationsVerEN, string strAchievement, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strAchievement, 5000, conSysSocialRelationsVer.Achievement);
}
objSysSocialRelationsVerEN.Achievement = strAchievement; //成就
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objSysSocialRelationsVerEN.dicFldComparisonOp.ContainsKey(conSysSocialRelationsVer.Achievement) == false)
{
objSysSocialRelationsVerEN.dicFldComparisonOp.Add(conSysSocialRelationsVer.Achievement, strComparisonOp);
}
else
{
objSysSocialRelationsVerEN.dicFldComparisonOp[conSysSocialRelationsVer.Achievement] = strComparisonOp;
}
}
return objSysSocialRelationsVerEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objSysSocialRelationsVerEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsSysSocialRelationsVerEN SetDetailedDescription(this clsSysSocialRelationsVerEN objSysSocialRelationsVerEN, string strDetailedDescription, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strDetailedDescription, 5000, conSysSocialRelationsVer.DetailedDescription);
}
objSysSocialRelationsVerEN.DetailedDescription = strDetailedDescription; //详细说明
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objSysSocialRelationsVerEN.dicFldComparisonOp.ContainsKey(conSysSocialRelationsVer.DetailedDescription) == false)
{
objSysSocialRelationsVerEN.dicFldComparisonOp.Add(conSysSocialRelationsVer.DetailedDescription, strComparisonOp);
}
else
{
objSysSocialRelationsVerEN.dicFldComparisonOp[conSysSocialRelationsVer.DetailedDescription] = strComparisonOp;
}
}
return objSysSocialRelationsVerEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objSysSocialRelationsVerEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsSysSocialRelationsVerEN SetLevelId(this clsSysSocialRelationsVerEN objSysSocialRelationsVerEN, string strLevelId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strLevelId, 2, conSysSocialRelationsVer.LevelId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strLevelId, 2, conSysSocialRelationsVer.LevelId);
}
objSysSocialRelationsVerEN.LevelId = strLevelId; //级别Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objSysSocialRelationsVerEN.dicFldComparisonOp.ContainsKey(conSysSocialRelationsVer.LevelId) == false)
{
objSysSocialRelationsVerEN.dicFldComparisonOp.Add(conSysSocialRelationsVer.LevelId, strComparisonOp);
}
else
{
objSysSocialRelationsVerEN.dicFldComparisonOp[conSysSocialRelationsVer.LevelId] = strComparisonOp;
}
}
return objSysSocialRelationsVerEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objSysSocialRelationsVerEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsSysSocialRelationsVerEN SetUpdUser(this clsSysSocialRelationsVerEN objSysSocialRelationsVerEN, string strUpdUser, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdUser, 20, conSysSocialRelationsVer.UpdUser);
}
objSysSocialRelationsVerEN.UpdUser = strUpdUser; //修改人
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objSysSocialRelationsVerEN.dicFldComparisonOp.ContainsKey(conSysSocialRelationsVer.UpdUser) == false)
{
objSysSocialRelationsVerEN.dicFldComparisonOp.Add(conSysSocialRelationsVer.UpdUser, strComparisonOp);
}
else
{
objSysSocialRelationsVerEN.dicFldComparisonOp[conSysSocialRelationsVer.UpdUser] = strComparisonOp;
}
}
return objSysSocialRelationsVerEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objSysSocialRelationsVerEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsSysSocialRelationsVerEN SetUpdDate(this clsSysSocialRelationsVerEN objSysSocialRelationsVerEN, string strUpdDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdDate, 20, conSysSocialRelationsVer.UpdDate);
}
objSysSocialRelationsVerEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objSysSocialRelationsVerEN.dicFldComparisonOp.ContainsKey(conSysSocialRelationsVer.UpdDate) == false)
{
objSysSocialRelationsVerEN.dicFldComparisonOp.Add(conSysSocialRelationsVer.UpdDate, strComparisonOp);
}
else
{
objSysSocialRelationsVerEN.dicFldComparisonOp[conSysSocialRelationsVer.UpdDate] = strComparisonOp;
}
}
return objSysSocialRelationsVerEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objSysSocialRelationsVerEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsSysSocialRelationsVerEN SetIdCurrEduCls(this clsSysSocialRelationsVerEN objSysSocialRelationsVerEN, string strIdCurrEduCls, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdCurrEduCls, 8, conSysSocialRelationsVer.IdCurrEduCls);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdCurrEduCls, 8, conSysSocialRelationsVer.IdCurrEduCls);
}
objSysSocialRelationsVerEN.IdCurrEduCls = strIdCurrEduCls; //教学班流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objSysSocialRelationsVerEN.dicFldComparisonOp.ContainsKey(conSysSocialRelationsVer.IdCurrEduCls) == false)
{
objSysSocialRelationsVerEN.dicFldComparisonOp.Add(conSysSocialRelationsVer.IdCurrEduCls, strComparisonOp);
}
else
{
objSysSocialRelationsVerEN.dicFldComparisonOp[conSysSocialRelationsVer.IdCurrEduCls] = strComparisonOp;
}
}
return objSysSocialRelationsVerEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objSysSocialRelationsVerEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsSysSocialRelationsVerEN SetMemo(this clsSysSocialRelationsVerEN objSysSocialRelationsVerEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, conSysSocialRelationsVer.Memo);
}
objSysSocialRelationsVerEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objSysSocialRelationsVerEN.dicFldComparisonOp.ContainsKey(conSysSocialRelationsVer.Memo) == false)
{
objSysSocialRelationsVerEN.dicFldComparisonOp.Add(conSysSocialRelationsVer.Memo, strComparisonOp);
}
else
{
objSysSocialRelationsVerEN.dicFldComparisonOp[conSysSocialRelationsVer.Memo] = strComparisonOp;
}
}
return objSysSocialRelationsVerEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objSysSocialRelationsVerEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsSysSocialRelationsVerEN SetCitationId(this clsSysSocialRelationsVerEN objSysSocialRelationsVerEN, string strCitationId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCitationId, 8, conSysSocialRelationsVer.CitationId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strCitationId, 8, conSysSocialRelationsVer.CitationId);
}
objSysSocialRelationsVerEN.CitationId = strCitationId; //引用Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objSysSocialRelationsVerEN.dicFldComparisonOp.ContainsKey(conSysSocialRelationsVer.CitationId) == false)
{
objSysSocialRelationsVerEN.dicFldComparisonOp.Add(conSysSocialRelationsVer.CitationId, strComparisonOp);
}
else
{
objSysSocialRelationsVerEN.dicFldComparisonOp[conSysSocialRelationsVer.CitationId] = strComparisonOp;
}
}
return objSysSocialRelationsVerEN;
	}

 /// <summary>
 /// 修改记录存盘到数据表中
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_UpdateRecordEx)
 /// </summary>
 /// <param name = "objSysSocialRelationsVerEN">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool UpdateRecordEx(this clsSysSocialRelationsVerEN objSysSocialRelationsVerEN)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
try
{
//1、检查传进去的对象属性是否合法
objSysSocialRelationsVerEN.CheckPropertyNew();
clsSysSocialRelationsVerEN objSysSocialRelationsVerCond = new clsSysSocialRelationsVerEN();
string strCondition = objSysSocialRelationsVerCond
.SetSocialVId(objSysSocialRelationsVerEN.SocialVId, "<>")
.SetSocialId(objSysSocialRelationsVerEN.SocialId, "=")
.GetCombineCondition();
objSysSocialRelationsVerEN._IsCheckProperty = true;
bool bolIsExist = clsSysSocialRelationsVerBL.IsExistRecord(strCondition);
if (bolIsExist)
{
strMsg = "(SocialId)不能重复!";
throw new Exception(strMsg);
}
//4、把数据实体层的数据存贮到数据库中
objSysSocialRelationsVerEN.Update();
}
catch(Exception objException)
{
strMsg = "修改记录不成功!" + objException.Message;
throw new Exception(strMsg);
}
return true; 
}

 /// <summary>
 /// 编辑记录存盘到数据表中。如果存在相关记录就修改,不存在就添加
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_EditRecordEx)
 /// </summary>
 /// <param name = "objSysSocialRelationsVer">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool EditRecordEx(this clsSysSocialRelationsVerEN objSysSocialRelationsVer)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
clsSysSocialRelationsVerEN objSysSocialRelationsVerCond = new clsSysSocialRelationsVerEN();
string strCondition = objSysSocialRelationsVerCond
.SetSocialId(objSysSocialRelationsVer.SocialId, "=")
.GetCombineCondition();
objSysSocialRelationsVer._IsCheckProperty = true;
bool bolIsExist = clsSysSocialRelationsVerBL.IsExistRecord(strCondition);
if (bolIsExist)
{
objSysSocialRelationsVer.SocialVId = clsSysSocialRelationsVerBL.GetFirstID_S(strCondition);
objSysSocialRelationsVer.UpdateWithCondition(strCondition);
}
else
{
objSysSocialRelationsVer.AddNewRecord();
}
return true; 
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_Update)
 /// </summary>
 /// <param name = "objSysSocialRelationsVerEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsSysSocialRelationsVerEN objSysSocialRelationsVerEN)
{
 if (objSysSocialRelationsVerEN.SocialVId == 0)
 {
string strMsg = string.Format("(errid:Busi000095)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsSysSocialRelationsVerBL.SysSocialRelationsVerDA.UpdateBySql2(objSysSocialRelationsVerEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsSysSocialRelationsVerBL.ReFreshCache();

if (clsSysSocialRelationsVerBL.relatedActions != null)
{
clsSysSocialRelationsVerBL.relatedActions.UpdRelaTabDate(objSysSocialRelationsVerEN.SocialVId, "SetUpdDate");
}
return bolResult;
}
catch (Exception objException)
{
string strMsg = string.Format("(errid:Busi000083)修改记录出错,{1}!(from {0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
}
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式.(带事务处理)
 /// /// 优点:1、能够处理字段中的单撇问题；
 /// /// 2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库;
 /// /// 3、支持事务处理.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_UpdateWithTransaction)
 /// </summary>
 /// <param name = "objSysSocialRelationsVerEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsSysSocialRelationsVerEN objSysSocialRelationsVerEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (objSysSocialRelationsVerEN.SocialVId == 0)
 {
string strMsg = string.Format("(errid:Busi000087)修改记录时关键字不能为空!(带事务处理)(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsSysSocialRelationsVerBL.SysSocialRelationsVerDA.UpdateBySql2(objSysSocialRelationsVerEN, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsSysSocialRelationsVerBL.ReFreshCache();

if (clsSysSocialRelationsVerBL.relatedActions != null)
{
clsSysSocialRelationsVerBL.relatedActions.UpdRelaTabDate(objSysSocialRelationsVerEN.SocialVId, "SetUpdDate");
}
return bolResult;
}
catch (Exception objException)
{
string strMsg = string.Format("(errid:Busi000088)修改记录出错,{1}.(带事务处理)(from {0})\r\n",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
}
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是非优化方式,根据条件修改记录
 /// /// 缺点:1、不能处理字段中的单撇问题；2、不能处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_UpdateWithCondition)
 /// </summary>
 /// <param name = "objSysSocialRelationsVerEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsSysSocialRelationsVerEN objSysSocialRelationsVerEN, string strWhereCond)
{
try
{
bool bolResult = clsSysSocialRelationsVerBL.SysSocialRelationsVerDA.UpdateBySqlWithCondition(objSysSocialRelationsVerEN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsSysSocialRelationsVerBL.ReFreshCache();

if (clsSysSocialRelationsVerBL.relatedActions != null)
{
clsSysSocialRelationsVerBL.relatedActions.UpdRelaTabDate(objSysSocialRelationsVerEN.SocialVId, "SetUpdDate");
}
return bolResult;
}
catch (Exception objException)
{
string strMsg = string.Format("(errid:Busi000089)根据条件修改记录出错, {1}.(from {0})\r\n",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
}
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是非优化方式,根据条件修改记录.(带事务处理)
 /// /// 缺点:1、不能处理字段中的单撇问题；2、不能处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_UpdateWithConditionTransaction)
 /// </summary>
 /// <param name = "objSysSocialRelationsVerEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsSysSocialRelationsVerEN objSysSocialRelationsVerEN, string strWhereCond, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
bool bolResult = clsSysSocialRelationsVerBL.SysSocialRelationsVerDA.UpdateBySqlWithConditionTransaction(objSysSocialRelationsVerEN, strWhereCond, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsSysSocialRelationsVerBL.ReFreshCache();

if (clsSysSocialRelationsVerBL.relatedActions != null)
{
clsSysSocialRelationsVerBL.relatedActions.UpdRelaTabDate(objSysSocialRelationsVerEN.SocialVId, "SetUpdDate");
}
return bolResult;
}
catch (Exception objException)
{
string strMsg = string.Format("(errid:Busi000090)根据条件修改记录出错!(带事务处理),{1}.(from {0})\r\n",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
}
}

 /// <summary>
 /// 功能:删除关键字所指定的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_Delete)
 /// </summary>
 /// <param name = "lngSocialVId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int Delete(this clsSysSocialRelationsVerEN objSysSocialRelationsVerEN)
{
try
{
int intRecNum = clsSysSocialRelationsVerBL.SysSocialRelationsVerDA.DelRecord(objSysSocialRelationsVerEN.SocialVId);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsSysSocialRelationsVerBL.ReFreshCache();

if (clsSysSocialRelationsVerBL.relatedActions != null)
{
clsSysSocialRelationsVerBL.relatedActions.UpdRelaTabDate(objSysSocialRelationsVerEN.SocialVId, "SetUpdDate");
}
return intRecNum;
}
catch (Exception objException)
{
string strMsg = string.Format("(errid:Busi000084)根据关键字删除记录出错,{1}.({0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
}
}

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CopyObj)
 /// </summary>
 /// <param name = "objSysSocialRelationsVerENS">源对象</param>
 /// <param name = "objSysSocialRelationsVerENT">目标对象</param>
 public static void CopyTo(this clsSysSocialRelationsVerEN objSysSocialRelationsVerENS, clsSysSocialRelationsVerEN objSysSocialRelationsVerENT)
{
try
{
objSysSocialRelationsVerENT.SocialVId = objSysSocialRelationsVerENS.SocialVId; //SocialVId
objSysSocialRelationsVerENT.SocialId = objSysSocialRelationsVerENS.SocialId; //社会Id
objSysSocialRelationsVerENT.FullName = objSysSocialRelationsVerENS.FullName; //姓名
objSysSocialRelationsVerENT.Nationality = objSysSocialRelationsVerENS.Nationality; //国籍
objSysSocialRelationsVerENT.WorkUnit = objSysSocialRelationsVerENS.WorkUnit; //工作单位
objSysSocialRelationsVerENT.Major = objSysSocialRelationsVerENS.Major; //专业
objSysSocialRelationsVerENT.Achievement = objSysSocialRelationsVerENS.Achievement; //成就
objSysSocialRelationsVerENT.DetailedDescription = objSysSocialRelationsVerENS.DetailedDescription; //详细说明
objSysSocialRelationsVerENT.LevelId = objSysSocialRelationsVerENS.LevelId; //级别Id
objSysSocialRelationsVerENT.UpdUser = objSysSocialRelationsVerENS.UpdUser; //修改人
objSysSocialRelationsVerENT.UpdDate = objSysSocialRelationsVerENS.UpdDate; //修改日期
objSysSocialRelationsVerENT.IdCurrEduCls = objSysSocialRelationsVerENS.IdCurrEduCls; //教学班流水号
objSysSocialRelationsVerENT.Memo = objSysSocialRelationsVerENS.Memo; //备注
objSysSocialRelationsVerENT.CitationId = objSysSocialRelationsVerENS.CitationId; //引用Id
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
 /// <param name = "objSysSocialRelationsVerENS">源对象</param>
 /// <returns>目标对象=>clsSysSocialRelationsVerEN:objSysSocialRelationsVerENT</returns>
 public static clsSysSocialRelationsVerEN CopyTo(this clsSysSocialRelationsVerEN objSysSocialRelationsVerENS)
{
try
{
 clsSysSocialRelationsVerEN objSysSocialRelationsVerENT = new clsSysSocialRelationsVerEN()
{
SocialVId = objSysSocialRelationsVerENS.SocialVId, //SocialVId
SocialId = objSysSocialRelationsVerENS.SocialId, //社会Id
FullName = objSysSocialRelationsVerENS.FullName, //姓名
Nationality = objSysSocialRelationsVerENS.Nationality, //国籍
WorkUnit = objSysSocialRelationsVerENS.WorkUnit, //工作单位
Major = objSysSocialRelationsVerENS.Major, //专业
Achievement = objSysSocialRelationsVerENS.Achievement, //成就
DetailedDescription = objSysSocialRelationsVerENS.DetailedDescription, //详细说明
LevelId = objSysSocialRelationsVerENS.LevelId, //级别Id
UpdUser = objSysSocialRelationsVerENS.UpdUser, //修改人
UpdDate = objSysSocialRelationsVerENS.UpdDate, //修改日期
IdCurrEduCls = objSysSocialRelationsVerENS.IdCurrEduCls, //教学班流水号
Memo = objSysSocialRelationsVerENS.Memo, //备注
CitationId = objSysSocialRelationsVerENS.CitationId, //引用Id
};
 return objSysSocialRelationsVerENT;
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
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckPropertyNew)
 /// </summary>
public static void CheckPropertyNew(this clsSysSocialRelationsVerEN objSysSocialRelationsVerEN)
{
 clsSysSocialRelationsVerBL.SysSocialRelationsVerDA.CheckPropertyNew(objSysSocialRelationsVerEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(this clsSysSocialRelationsVerEN objSysSocialRelationsVerEN)
{
 clsSysSocialRelationsVerBL.SysSocialRelationsVerDA.CheckProperty4Condition(objSysSocialRelationsVerEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsSysSocialRelationsVerEN objSysSocialRelationsVerCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objSysSocialRelationsVerCond.IsUpdated(conSysSocialRelationsVer.SocialVId) == true)
{
string strComparisonOpSocialVId = objSysSocialRelationsVerCond.dicFldComparisonOp[conSysSocialRelationsVer.SocialVId];
strWhereCond += string.Format(" And {0} {2} {1}", conSysSocialRelationsVer.SocialVId, objSysSocialRelationsVerCond.SocialVId, strComparisonOpSocialVId);
}
if (objSysSocialRelationsVerCond.IsUpdated(conSysSocialRelationsVer.SocialId) == true)
{
string strComparisonOpSocialId = objSysSocialRelationsVerCond.dicFldComparisonOp[conSysSocialRelationsVer.SocialId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conSysSocialRelationsVer.SocialId, objSysSocialRelationsVerCond.SocialId, strComparisonOpSocialId);
}
if (objSysSocialRelationsVerCond.IsUpdated(conSysSocialRelationsVer.FullName) == true)
{
string strComparisonOpFullName = objSysSocialRelationsVerCond.dicFldComparisonOp[conSysSocialRelationsVer.FullName];
strWhereCond += string.Format(" And {0} {2} '{1}'", conSysSocialRelationsVer.FullName, objSysSocialRelationsVerCond.FullName, strComparisonOpFullName);
}
if (objSysSocialRelationsVerCond.IsUpdated(conSysSocialRelationsVer.Nationality) == true)
{
string strComparisonOpNationality = objSysSocialRelationsVerCond.dicFldComparisonOp[conSysSocialRelationsVer.Nationality];
strWhereCond += string.Format(" And {0} {2} '{1}'", conSysSocialRelationsVer.Nationality, objSysSocialRelationsVerCond.Nationality, strComparisonOpNationality);
}
if (objSysSocialRelationsVerCond.IsUpdated(conSysSocialRelationsVer.WorkUnit) == true)
{
string strComparisonOpWorkUnit = objSysSocialRelationsVerCond.dicFldComparisonOp[conSysSocialRelationsVer.WorkUnit];
strWhereCond += string.Format(" And {0} {2} '{1}'", conSysSocialRelationsVer.WorkUnit, objSysSocialRelationsVerCond.WorkUnit, strComparisonOpWorkUnit);
}
if (objSysSocialRelationsVerCond.IsUpdated(conSysSocialRelationsVer.Major) == true)
{
string strComparisonOpMajor = objSysSocialRelationsVerCond.dicFldComparisonOp[conSysSocialRelationsVer.Major];
strWhereCond += string.Format(" And {0} {2} '{1}'", conSysSocialRelationsVer.Major, objSysSocialRelationsVerCond.Major, strComparisonOpMajor);
}
if (objSysSocialRelationsVerCond.IsUpdated(conSysSocialRelationsVer.Achievement) == true)
{
string strComparisonOpAchievement = objSysSocialRelationsVerCond.dicFldComparisonOp[conSysSocialRelationsVer.Achievement];
strWhereCond += string.Format(" And {0} {2} '{1}'", conSysSocialRelationsVer.Achievement, objSysSocialRelationsVerCond.Achievement, strComparisonOpAchievement);
}
if (objSysSocialRelationsVerCond.IsUpdated(conSysSocialRelationsVer.DetailedDescription) == true)
{
string strComparisonOpDetailedDescription = objSysSocialRelationsVerCond.dicFldComparisonOp[conSysSocialRelationsVer.DetailedDescription];
strWhereCond += string.Format(" And {0} {2} '{1}'", conSysSocialRelationsVer.DetailedDescription, objSysSocialRelationsVerCond.DetailedDescription, strComparisonOpDetailedDescription);
}
if (objSysSocialRelationsVerCond.IsUpdated(conSysSocialRelationsVer.LevelId) == true)
{
string strComparisonOpLevelId = objSysSocialRelationsVerCond.dicFldComparisonOp[conSysSocialRelationsVer.LevelId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conSysSocialRelationsVer.LevelId, objSysSocialRelationsVerCond.LevelId, strComparisonOpLevelId);
}
if (objSysSocialRelationsVerCond.IsUpdated(conSysSocialRelationsVer.UpdUser) == true)
{
string strComparisonOpUpdUser = objSysSocialRelationsVerCond.dicFldComparisonOp[conSysSocialRelationsVer.UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", conSysSocialRelationsVer.UpdUser, objSysSocialRelationsVerCond.UpdUser, strComparisonOpUpdUser);
}
if (objSysSocialRelationsVerCond.IsUpdated(conSysSocialRelationsVer.UpdDate) == true)
{
string strComparisonOpUpdDate = objSysSocialRelationsVerCond.dicFldComparisonOp[conSysSocialRelationsVer.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conSysSocialRelationsVer.UpdDate, objSysSocialRelationsVerCond.UpdDate, strComparisonOpUpdDate);
}
if (objSysSocialRelationsVerCond.IsUpdated(conSysSocialRelationsVer.IdCurrEduCls) == true)
{
string strComparisonOpIdCurrEduCls = objSysSocialRelationsVerCond.dicFldComparisonOp[conSysSocialRelationsVer.IdCurrEduCls];
strWhereCond += string.Format(" And {0} {2} '{1}'", conSysSocialRelationsVer.IdCurrEduCls, objSysSocialRelationsVerCond.IdCurrEduCls, strComparisonOpIdCurrEduCls);
}
if (objSysSocialRelationsVerCond.IsUpdated(conSysSocialRelationsVer.Memo) == true)
{
string strComparisonOpMemo = objSysSocialRelationsVerCond.dicFldComparisonOp[conSysSocialRelationsVer.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", conSysSocialRelationsVer.Memo, objSysSocialRelationsVerCond.Memo, strComparisonOpMemo);
}
if (objSysSocialRelationsVerCond.IsUpdated(conSysSocialRelationsVer.CitationId) == true)
{
string strComparisonOpCitationId = objSysSocialRelationsVerCond.dicFldComparisonOp[conSysSocialRelationsVer.CitationId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conSysSocialRelationsVer.CitationId, objSysSocialRelationsVerCond.CitationId, strComparisonOpCitationId);
}
 return strWhereCond;
}

 /// <summary>
 /// 检查唯一性(Uniqueness)--SysSocialRelationsVer(社会关系版本表), 如果不唯一,即存在相同的记录,就返回False
 /// 唯一性条件:SocialId
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckConstraint)
 /// </summary>
 /// <param name = "objSysSocialRelationsVerEN">要求唯一的对象</param>
 /// <returns></returns>
public static bool CheckUniqueness(this clsSysSocialRelationsVerEN objSysSocialRelationsVerEN)
{
//检测记录是否存在
bool bolIsUniqueness;
StringBuilder sbCondition = new StringBuilder();
if (objSysSocialRelationsVerEN == null) return true;
if (objSysSocialRelationsVerEN.SocialVId == 0)
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and SocialId = '{0}'", objSysSocialRelationsVerEN.SocialId);
if (clsSysSocialRelationsVerBL.IsExistRecord(sbCondition.ToString())  ==  true)
{
 bolIsUniqueness = false;
}
else
{
 bolIsUniqueness = true;
}
}
 else {
sbCondition.AppendFormat("SocialVId !=  {0}", objSysSocialRelationsVerEN.SocialVId);
 sbCondition.AppendFormat(" and SocialId = '{0}'", objSysSocialRelationsVerEN.SocialId);
if (clsSysSocialRelationsVerBL.IsExistRecord(sbCondition.ToString())  ==  true)
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
 /// 获取唯一性条件串--SysSocialRelationsVer(社会关系版本表), 即由对象中唯一性条件字段关键字与值组成的条件串
 /// 唯一性条件:SocialId
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetConditionString4Constraint)
 /// </summary>
 /// <param name = "objSysSocialRelationsVerEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(this clsSysSocialRelationsVerEN objSysSocialRelationsVerEN)
{
//检测记录是否存在
StringBuilder sbCondition = new StringBuilder();
if (objSysSocialRelationsVerEN == null) return "";
if (objSysSocialRelationsVerEN.SocialVId == 0)
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and SocialId = '{0}'", objSysSocialRelationsVerEN.SocialId);
return sbCondition.ToString();
}
 else {
sbCondition.AppendFormat("SocialVId !=  {0}", objSysSocialRelationsVerEN.SocialVId);
 sbCondition.AppendFormat(" and SocialId = '{0}'", objSysSocialRelationsVerEN.SocialId);
 return sbCondition.ToString();
}
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_SysSocialRelationsVer
{
public virtual bool UpdRelaTabDate(long lngSocialVId, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// 社会关系版本表(SysSocialRelationsVer)
 /// 数据源类型:表
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsSysSocialRelationsVerBL
{
public static RelatedActions_SysSocialRelationsVer relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsSysSocialRelationsVerDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsSysSocialRelationsVerDA SysSocialRelationsVerDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsSysSocialRelationsVerDA();
}
return uniqueInstance;
}
}

 /// <summary>
/// 专门在逻辑层用于处理缓存等公共函数的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineObjCommFun4BL)
/// </summary>
public static clsCommFun4BL objCommFun4BL = null;

 /// <summary>
 /// 类的构造函数
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ClassConstructor1)
 /// </summary>
 public clsSysSocialRelationsVerBL()
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
if (string.IsNullOrEmpty(clsSysSocialRelationsVerEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsSysSocialRelationsVerEN._ConnectString);
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
public static DataTable GetDataTable_SysSocialRelationsVer(string strWhereCond)
{
DataTable objDT;
try
{
objDT = SysSocialRelationsVerDA.GetDataTable_SysSocialRelationsVer(strWhereCond);
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
objDT = SysSocialRelationsVerDA.GetDataTable(strWhereCond);
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
objDT = SysSocialRelationsVerDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = SysSocialRelationsVerDA.GetDataTable(strWhereCond, strTabName);
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
objDT = SysSocialRelationsVerDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = SysSocialRelationsVerDA.GetDataTable_Top(objTopPara);
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
objDT = SysSocialRelationsVerDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = SysSocialRelationsVerDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = SysSocialRelationsVerDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
 /// <param name = "arrSocialVIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static List<clsSysSocialRelationsVerEN> GetObjLstBySocialVIdLst(List<long> arrSocialVIdLst)
{
List<clsSysSocialRelationsVerEN> arrObjLst = new List<clsSysSocialRelationsVerEN>(); 
System.Data.DataTable objDT; 
 string strSqlConditionStr = clsArray.GetSqlInStrByArray(arrSocialVIdLst);
 string strWhereCond = string.Format("SocialVId in ({0})", strSqlConditionStr);
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsSysSocialRelationsVerEN objSysSocialRelationsVerEN = new clsSysSocialRelationsVerEN();
try
{
objSysSocialRelationsVerEN.SocialVId = Int32.Parse(objRow[conSysSocialRelationsVer.SocialVId].ToString().Trim()); //SocialVId
objSysSocialRelationsVerEN.SocialId = objRow[conSysSocialRelationsVer.SocialId].ToString().Trim(); //社会Id
objSysSocialRelationsVerEN.FullName = objRow[conSysSocialRelationsVer.FullName] == DBNull.Value ? null : objRow[conSysSocialRelationsVer.FullName].ToString().Trim(); //姓名
objSysSocialRelationsVerEN.Nationality = objRow[conSysSocialRelationsVer.Nationality] == DBNull.Value ? null : objRow[conSysSocialRelationsVer.Nationality].ToString().Trim(); //国籍
objSysSocialRelationsVerEN.WorkUnit = objRow[conSysSocialRelationsVer.WorkUnit] == DBNull.Value ? null : objRow[conSysSocialRelationsVer.WorkUnit].ToString().Trim(); //工作单位
objSysSocialRelationsVerEN.Major = objRow[conSysSocialRelationsVer.Major] == DBNull.Value ? null : objRow[conSysSocialRelationsVer.Major].ToString().Trim(); //专业
objSysSocialRelationsVerEN.Achievement = objRow[conSysSocialRelationsVer.Achievement] == DBNull.Value ? null : objRow[conSysSocialRelationsVer.Achievement].ToString().Trim(); //成就
objSysSocialRelationsVerEN.DetailedDescription = objRow[conSysSocialRelationsVer.DetailedDescription] == DBNull.Value ? null : objRow[conSysSocialRelationsVer.DetailedDescription].ToString().Trim(); //详细说明
objSysSocialRelationsVerEN.LevelId = objRow[conSysSocialRelationsVer.LevelId] == DBNull.Value ? null : objRow[conSysSocialRelationsVer.LevelId].ToString().Trim(); //级别Id
objSysSocialRelationsVerEN.UpdUser = objRow[conSysSocialRelationsVer.UpdUser] == DBNull.Value ? null : objRow[conSysSocialRelationsVer.UpdUser].ToString().Trim(); //修改人
objSysSocialRelationsVerEN.UpdDate = objRow[conSysSocialRelationsVer.UpdDate] == DBNull.Value ? null : objRow[conSysSocialRelationsVer.UpdDate].ToString().Trim(); //修改日期
objSysSocialRelationsVerEN.IdCurrEduCls = objRow[conSysSocialRelationsVer.IdCurrEduCls] == DBNull.Value ? null : objRow[conSysSocialRelationsVer.IdCurrEduCls].ToString().Trim(); //教学班流水号
objSysSocialRelationsVerEN.Memo = objRow[conSysSocialRelationsVer.Memo] == DBNull.Value ? null : objRow[conSysSocialRelationsVer.Memo].ToString().Trim(); //备注
objSysSocialRelationsVerEN.CitationId = objRow[conSysSocialRelationsVer.CitationId] == DBNull.Value ? null : objRow[conSysSocialRelationsVer.CitationId].ToString().Trim(); //引用Id
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objSysSocialRelationsVerEN.SocialVId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objSysSocialRelationsVerEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrSocialVIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsSysSocialRelationsVerEN> GetObjLstBySocialVIdLstCache(List<long> arrSocialVIdLst)
{
string strKey = string.Format("{0}", clsSysSocialRelationsVerEN._CurrTabName);
List<clsSysSocialRelationsVerEN> arrSysSocialRelationsVerObjLstCache = GetObjLstCache();
IEnumerable <clsSysSocialRelationsVerEN> arrSysSocialRelationsVerObjLst_Sel =
arrSysSocialRelationsVerObjLstCache
.Where(x => arrSocialVIdLst.Contains(x.SocialVId));
return arrSysSocialRelationsVerObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsSysSocialRelationsVerEN> GetObjLst(string strWhereCond)
{
List<clsSysSocialRelationsVerEN> arrObjLst = new List<clsSysSocialRelationsVerEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsSysSocialRelationsVerEN objSysSocialRelationsVerEN = new clsSysSocialRelationsVerEN();
try
{
objSysSocialRelationsVerEN.SocialVId = Int32.Parse(objRow[conSysSocialRelationsVer.SocialVId].ToString().Trim()); //SocialVId
objSysSocialRelationsVerEN.SocialId = objRow[conSysSocialRelationsVer.SocialId].ToString().Trim(); //社会Id
objSysSocialRelationsVerEN.FullName = objRow[conSysSocialRelationsVer.FullName] == DBNull.Value ? null : objRow[conSysSocialRelationsVer.FullName].ToString().Trim(); //姓名
objSysSocialRelationsVerEN.Nationality = objRow[conSysSocialRelationsVer.Nationality] == DBNull.Value ? null : objRow[conSysSocialRelationsVer.Nationality].ToString().Trim(); //国籍
objSysSocialRelationsVerEN.WorkUnit = objRow[conSysSocialRelationsVer.WorkUnit] == DBNull.Value ? null : objRow[conSysSocialRelationsVer.WorkUnit].ToString().Trim(); //工作单位
objSysSocialRelationsVerEN.Major = objRow[conSysSocialRelationsVer.Major] == DBNull.Value ? null : objRow[conSysSocialRelationsVer.Major].ToString().Trim(); //专业
objSysSocialRelationsVerEN.Achievement = objRow[conSysSocialRelationsVer.Achievement] == DBNull.Value ? null : objRow[conSysSocialRelationsVer.Achievement].ToString().Trim(); //成就
objSysSocialRelationsVerEN.DetailedDescription = objRow[conSysSocialRelationsVer.DetailedDescription] == DBNull.Value ? null : objRow[conSysSocialRelationsVer.DetailedDescription].ToString().Trim(); //详细说明
objSysSocialRelationsVerEN.LevelId = objRow[conSysSocialRelationsVer.LevelId] == DBNull.Value ? null : objRow[conSysSocialRelationsVer.LevelId].ToString().Trim(); //级别Id
objSysSocialRelationsVerEN.UpdUser = objRow[conSysSocialRelationsVer.UpdUser] == DBNull.Value ? null : objRow[conSysSocialRelationsVer.UpdUser].ToString().Trim(); //修改人
objSysSocialRelationsVerEN.UpdDate = objRow[conSysSocialRelationsVer.UpdDate] == DBNull.Value ? null : objRow[conSysSocialRelationsVer.UpdDate].ToString().Trim(); //修改日期
objSysSocialRelationsVerEN.IdCurrEduCls = objRow[conSysSocialRelationsVer.IdCurrEduCls] == DBNull.Value ? null : objRow[conSysSocialRelationsVer.IdCurrEduCls].ToString().Trim(); //教学班流水号
objSysSocialRelationsVerEN.Memo = objRow[conSysSocialRelationsVer.Memo] == DBNull.Value ? null : objRow[conSysSocialRelationsVer.Memo].ToString().Trim(); //备注
objSysSocialRelationsVerEN.CitationId = objRow[conSysSocialRelationsVer.CitationId] == DBNull.Value ? null : objRow[conSysSocialRelationsVer.CitationId].ToString().Trim(); //引用Id
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objSysSocialRelationsVerEN.SocialVId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objSysSocialRelationsVerEN);
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
public static List<clsSysSocialRelationsVerEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsSysSocialRelationsVerEN> arrObjLst = new List<clsSysSocialRelationsVerEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsSysSocialRelationsVerEN objSysSocialRelationsVerEN = new clsSysSocialRelationsVerEN();
try
{
objSysSocialRelationsVerEN.SocialVId = Int32.Parse(objRow[conSysSocialRelationsVer.SocialVId].ToString().Trim()); //SocialVId
objSysSocialRelationsVerEN.SocialId = objRow[conSysSocialRelationsVer.SocialId].ToString().Trim(); //社会Id
objSysSocialRelationsVerEN.FullName = objRow[conSysSocialRelationsVer.FullName] == DBNull.Value ? null : objRow[conSysSocialRelationsVer.FullName].ToString().Trim(); //姓名
objSysSocialRelationsVerEN.Nationality = objRow[conSysSocialRelationsVer.Nationality] == DBNull.Value ? null : objRow[conSysSocialRelationsVer.Nationality].ToString().Trim(); //国籍
objSysSocialRelationsVerEN.WorkUnit = objRow[conSysSocialRelationsVer.WorkUnit] == DBNull.Value ? null : objRow[conSysSocialRelationsVer.WorkUnit].ToString().Trim(); //工作单位
objSysSocialRelationsVerEN.Major = objRow[conSysSocialRelationsVer.Major] == DBNull.Value ? null : objRow[conSysSocialRelationsVer.Major].ToString().Trim(); //专业
objSysSocialRelationsVerEN.Achievement = objRow[conSysSocialRelationsVer.Achievement] == DBNull.Value ? null : objRow[conSysSocialRelationsVer.Achievement].ToString().Trim(); //成就
objSysSocialRelationsVerEN.DetailedDescription = objRow[conSysSocialRelationsVer.DetailedDescription] == DBNull.Value ? null : objRow[conSysSocialRelationsVer.DetailedDescription].ToString().Trim(); //详细说明
objSysSocialRelationsVerEN.LevelId = objRow[conSysSocialRelationsVer.LevelId] == DBNull.Value ? null : objRow[conSysSocialRelationsVer.LevelId].ToString().Trim(); //级别Id
objSysSocialRelationsVerEN.UpdUser = objRow[conSysSocialRelationsVer.UpdUser] == DBNull.Value ? null : objRow[conSysSocialRelationsVer.UpdUser].ToString().Trim(); //修改人
objSysSocialRelationsVerEN.UpdDate = objRow[conSysSocialRelationsVer.UpdDate] == DBNull.Value ? null : objRow[conSysSocialRelationsVer.UpdDate].ToString().Trim(); //修改日期
objSysSocialRelationsVerEN.IdCurrEduCls = objRow[conSysSocialRelationsVer.IdCurrEduCls] == DBNull.Value ? null : objRow[conSysSocialRelationsVer.IdCurrEduCls].ToString().Trim(); //教学班流水号
objSysSocialRelationsVerEN.Memo = objRow[conSysSocialRelationsVer.Memo] == DBNull.Value ? null : objRow[conSysSocialRelationsVer.Memo].ToString().Trim(); //备注
objSysSocialRelationsVerEN.CitationId = objRow[conSysSocialRelationsVer.CitationId] == DBNull.Value ? null : objRow[conSysSocialRelationsVer.CitationId].ToString().Trim(); //引用Id
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objSysSocialRelationsVerEN.SocialVId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objSysSocialRelationsVerEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objSysSocialRelationsVerCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsSysSocialRelationsVerEN> GetSubObjLstCache(clsSysSocialRelationsVerEN objSysSocialRelationsVerCond)
{
List<clsSysSocialRelationsVerEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsSysSocialRelationsVerEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conSysSocialRelationsVer.AttributeName)
{
if (objSysSocialRelationsVerCond.IsUpdated(strFldName) == false) continue;
if (objSysSocialRelationsVerCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objSysSocialRelationsVerCond[strFldName].ToString());
}
else
{
if (objSysSocialRelationsVerCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objSysSocialRelationsVerCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objSysSocialRelationsVerCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objSysSocialRelationsVerCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objSysSocialRelationsVerCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objSysSocialRelationsVerCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objSysSocialRelationsVerCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objSysSocialRelationsVerCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objSysSocialRelationsVerCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objSysSocialRelationsVerCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objSysSocialRelationsVerCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objSysSocialRelationsVerCond[strFldName]));
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
public static List<clsSysSocialRelationsVerEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsSysSocialRelationsVerEN> arrObjLst = new List<clsSysSocialRelationsVerEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsSysSocialRelationsVerEN objSysSocialRelationsVerEN = new clsSysSocialRelationsVerEN();
try
{
objSysSocialRelationsVerEN.SocialVId = Int32.Parse(objRow[conSysSocialRelationsVer.SocialVId].ToString().Trim()); //SocialVId
objSysSocialRelationsVerEN.SocialId = objRow[conSysSocialRelationsVer.SocialId].ToString().Trim(); //社会Id
objSysSocialRelationsVerEN.FullName = objRow[conSysSocialRelationsVer.FullName] == DBNull.Value ? null : objRow[conSysSocialRelationsVer.FullName].ToString().Trim(); //姓名
objSysSocialRelationsVerEN.Nationality = objRow[conSysSocialRelationsVer.Nationality] == DBNull.Value ? null : objRow[conSysSocialRelationsVer.Nationality].ToString().Trim(); //国籍
objSysSocialRelationsVerEN.WorkUnit = objRow[conSysSocialRelationsVer.WorkUnit] == DBNull.Value ? null : objRow[conSysSocialRelationsVer.WorkUnit].ToString().Trim(); //工作单位
objSysSocialRelationsVerEN.Major = objRow[conSysSocialRelationsVer.Major] == DBNull.Value ? null : objRow[conSysSocialRelationsVer.Major].ToString().Trim(); //专业
objSysSocialRelationsVerEN.Achievement = objRow[conSysSocialRelationsVer.Achievement] == DBNull.Value ? null : objRow[conSysSocialRelationsVer.Achievement].ToString().Trim(); //成就
objSysSocialRelationsVerEN.DetailedDescription = objRow[conSysSocialRelationsVer.DetailedDescription] == DBNull.Value ? null : objRow[conSysSocialRelationsVer.DetailedDescription].ToString().Trim(); //详细说明
objSysSocialRelationsVerEN.LevelId = objRow[conSysSocialRelationsVer.LevelId] == DBNull.Value ? null : objRow[conSysSocialRelationsVer.LevelId].ToString().Trim(); //级别Id
objSysSocialRelationsVerEN.UpdUser = objRow[conSysSocialRelationsVer.UpdUser] == DBNull.Value ? null : objRow[conSysSocialRelationsVer.UpdUser].ToString().Trim(); //修改人
objSysSocialRelationsVerEN.UpdDate = objRow[conSysSocialRelationsVer.UpdDate] == DBNull.Value ? null : objRow[conSysSocialRelationsVer.UpdDate].ToString().Trim(); //修改日期
objSysSocialRelationsVerEN.IdCurrEduCls = objRow[conSysSocialRelationsVer.IdCurrEduCls] == DBNull.Value ? null : objRow[conSysSocialRelationsVer.IdCurrEduCls].ToString().Trim(); //教学班流水号
objSysSocialRelationsVerEN.Memo = objRow[conSysSocialRelationsVer.Memo] == DBNull.Value ? null : objRow[conSysSocialRelationsVer.Memo].ToString().Trim(); //备注
objSysSocialRelationsVerEN.CitationId = objRow[conSysSocialRelationsVer.CitationId] == DBNull.Value ? null : objRow[conSysSocialRelationsVer.CitationId].ToString().Trim(); //引用Id
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objSysSocialRelationsVerEN.SocialVId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objSysSocialRelationsVerEN);
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
public static List<clsSysSocialRelationsVerEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsSysSocialRelationsVerEN> arrObjLst = new List<clsSysSocialRelationsVerEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsSysSocialRelationsVerEN objSysSocialRelationsVerEN = new clsSysSocialRelationsVerEN();
try
{
objSysSocialRelationsVerEN.SocialVId = Int32.Parse(objRow[conSysSocialRelationsVer.SocialVId].ToString().Trim()); //SocialVId
objSysSocialRelationsVerEN.SocialId = objRow[conSysSocialRelationsVer.SocialId].ToString().Trim(); //社会Id
objSysSocialRelationsVerEN.FullName = objRow[conSysSocialRelationsVer.FullName] == DBNull.Value ? null : objRow[conSysSocialRelationsVer.FullName].ToString().Trim(); //姓名
objSysSocialRelationsVerEN.Nationality = objRow[conSysSocialRelationsVer.Nationality] == DBNull.Value ? null : objRow[conSysSocialRelationsVer.Nationality].ToString().Trim(); //国籍
objSysSocialRelationsVerEN.WorkUnit = objRow[conSysSocialRelationsVer.WorkUnit] == DBNull.Value ? null : objRow[conSysSocialRelationsVer.WorkUnit].ToString().Trim(); //工作单位
objSysSocialRelationsVerEN.Major = objRow[conSysSocialRelationsVer.Major] == DBNull.Value ? null : objRow[conSysSocialRelationsVer.Major].ToString().Trim(); //专业
objSysSocialRelationsVerEN.Achievement = objRow[conSysSocialRelationsVer.Achievement] == DBNull.Value ? null : objRow[conSysSocialRelationsVer.Achievement].ToString().Trim(); //成就
objSysSocialRelationsVerEN.DetailedDescription = objRow[conSysSocialRelationsVer.DetailedDescription] == DBNull.Value ? null : objRow[conSysSocialRelationsVer.DetailedDescription].ToString().Trim(); //详细说明
objSysSocialRelationsVerEN.LevelId = objRow[conSysSocialRelationsVer.LevelId] == DBNull.Value ? null : objRow[conSysSocialRelationsVer.LevelId].ToString().Trim(); //级别Id
objSysSocialRelationsVerEN.UpdUser = objRow[conSysSocialRelationsVer.UpdUser] == DBNull.Value ? null : objRow[conSysSocialRelationsVer.UpdUser].ToString().Trim(); //修改人
objSysSocialRelationsVerEN.UpdDate = objRow[conSysSocialRelationsVer.UpdDate] == DBNull.Value ? null : objRow[conSysSocialRelationsVer.UpdDate].ToString().Trim(); //修改日期
objSysSocialRelationsVerEN.IdCurrEduCls = objRow[conSysSocialRelationsVer.IdCurrEduCls] == DBNull.Value ? null : objRow[conSysSocialRelationsVer.IdCurrEduCls].ToString().Trim(); //教学班流水号
objSysSocialRelationsVerEN.Memo = objRow[conSysSocialRelationsVer.Memo] == DBNull.Value ? null : objRow[conSysSocialRelationsVer.Memo].ToString().Trim(); //备注
objSysSocialRelationsVerEN.CitationId = objRow[conSysSocialRelationsVer.CitationId] == DBNull.Value ? null : objRow[conSysSocialRelationsVer.CitationId].ToString().Trim(); //引用Id
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objSysSocialRelationsVerEN.SocialVId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objSysSocialRelationsVerEN);
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
List<clsSysSocialRelationsVerEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsSysSocialRelationsVerEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsSysSocialRelationsVerEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsSysSocialRelationsVerEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsSysSocialRelationsVerEN> arrObjLst = new List<clsSysSocialRelationsVerEN>(); 
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
	clsSysSocialRelationsVerEN objSysSocialRelationsVerEN = new clsSysSocialRelationsVerEN();
try
{
objSysSocialRelationsVerEN.SocialVId = Int32.Parse(objRow[conSysSocialRelationsVer.SocialVId].ToString().Trim()); //SocialVId
objSysSocialRelationsVerEN.SocialId = objRow[conSysSocialRelationsVer.SocialId].ToString().Trim(); //社会Id
objSysSocialRelationsVerEN.FullName = objRow[conSysSocialRelationsVer.FullName] == DBNull.Value ? null : objRow[conSysSocialRelationsVer.FullName].ToString().Trim(); //姓名
objSysSocialRelationsVerEN.Nationality = objRow[conSysSocialRelationsVer.Nationality] == DBNull.Value ? null : objRow[conSysSocialRelationsVer.Nationality].ToString().Trim(); //国籍
objSysSocialRelationsVerEN.WorkUnit = objRow[conSysSocialRelationsVer.WorkUnit] == DBNull.Value ? null : objRow[conSysSocialRelationsVer.WorkUnit].ToString().Trim(); //工作单位
objSysSocialRelationsVerEN.Major = objRow[conSysSocialRelationsVer.Major] == DBNull.Value ? null : objRow[conSysSocialRelationsVer.Major].ToString().Trim(); //专业
objSysSocialRelationsVerEN.Achievement = objRow[conSysSocialRelationsVer.Achievement] == DBNull.Value ? null : objRow[conSysSocialRelationsVer.Achievement].ToString().Trim(); //成就
objSysSocialRelationsVerEN.DetailedDescription = objRow[conSysSocialRelationsVer.DetailedDescription] == DBNull.Value ? null : objRow[conSysSocialRelationsVer.DetailedDescription].ToString().Trim(); //详细说明
objSysSocialRelationsVerEN.LevelId = objRow[conSysSocialRelationsVer.LevelId] == DBNull.Value ? null : objRow[conSysSocialRelationsVer.LevelId].ToString().Trim(); //级别Id
objSysSocialRelationsVerEN.UpdUser = objRow[conSysSocialRelationsVer.UpdUser] == DBNull.Value ? null : objRow[conSysSocialRelationsVer.UpdUser].ToString().Trim(); //修改人
objSysSocialRelationsVerEN.UpdDate = objRow[conSysSocialRelationsVer.UpdDate] == DBNull.Value ? null : objRow[conSysSocialRelationsVer.UpdDate].ToString().Trim(); //修改日期
objSysSocialRelationsVerEN.IdCurrEduCls = objRow[conSysSocialRelationsVer.IdCurrEduCls] == DBNull.Value ? null : objRow[conSysSocialRelationsVer.IdCurrEduCls].ToString().Trim(); //教学班流水号
objSysSocialRelationsVerEN.Memo = objRow[conSysSocialRelationsVer.Memo] == DBNull.Value ? null : objRow[conSysSocialRelationsVer.Memo].ToString().Trim(); //备注
objSysSocialRelationsVerEN.CitationId = objRow[conSysSocialRelationsVer.CitationId] == DBNull.Value ? null : objRow[conSysSocialRelationsVer.CitationId].ToString().Trim(); //引用Id
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objSysSocialRelationsVerEN.SocialVId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objSysSocialRelationsVerEN);
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
public static List<clsSysSocialRelationsVerEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsSysSocialRelationsVerEN> arrObjLst = new List<clsSysSocialRelationsVerEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsSysSocialRelationsVerEN objSysSocialRelationsVerEN = new clsSysSocialRelationsVerEN();
try
{
objSysSocialRelationsVerEN.SocialVId = Int32.Parse(objRow[conSysSocialRelationsVer.SocialVId].ToString().Trim()); //SocialVId
objSysSocialRelationsVerEN.SocialId = objRow[conSysSocialRelationsVer.SocialId].ToString().Trim(); //社会Id
objSysSocialRelationsVerEN.FullName = objRow[conSysSocialRelationsVer.FullName] == DBNull.Value ? null : objRow[conSysSocialRelationsVer.FullName].ToString().Trim(); //姓名
objSysSocialRelationsVerEN.Nationality = objRow[conSysSocialRelationsVer.Nationality] == DBNull.Value ? null : objRow[conSysSocialRelationsVer.Nationality].ToString().Trim(); //国籍
objSysSocialRelationsVerEN.WorkUnit = objRow[conSysSocialRelationsVer.WorkUnit] == DBNull.Value ? null : objRow[conSysSocialRelationsVer.WorkUnit].ToString().Trim(); //工作单位
objSysSocialRelationsVerEN.Major = objRow[conSysSocialRelationsVer.Major] == DBNull.Value ? null : objRow[conSysSocialRelationsVer.Major].ToString().Trim(); //专业
objSysSocialRelationsVerEN.Achievement = objRow[conSysSocialRelationsVer.Achievement] == DBNull.Value ? null : objRow[conSysSocialRelationsVer.Achievement].ToString().Trim(); //成就
objSysSocialRelationsVerEN.DetailedDescription = objRow[conSysSocialRelationsVer.DetailedDescription] == DBNull.Value ? null : objRow[conSysSocialRelationsVer.DetailedDescription].ToString().Trim(); //详细说明
objSysSocialRelationsVerEN.LevelId = objRow[conSysSocialRelationsVer.LevelId] == DBNull.Value ? null : objRow[conSysSocialRelationsVer.LevelId].ToString().Trim(); //级别Id
objSysSocialRelationsVerEN.UpdUser = objRow[conSysSocialRelationsVer.UpdUser] == DBNull.Value ? null : objRow[conSysSocialRelationsVer.UpdUser].ToString().Trim(); //修改人
objSysSocialRelationsVerEN.UpdDate = objRow[conSysSocialRelationsVer.UpdDate] == DBNull.Value ? null : objRow[conSysSocialRelationsVer.UpdDate].ToString().Trim(); //修改日期
objSysSocialRelationsVerEN.IdCurrEduCls = objRow[conSysSocialRelationsVer.IdCurrEduCls] == DBNull.Value ? null : objRow[conSysSocialRelationsVer.IdCurrEduCls].ToString().Trim(); //教学班流水号
objSysSocialRelationsVerEN.Memo = objRow[conSysSocialRelationsVer.Memo] == DBNull.Value ? null : objRow[conSysSocialRelationsVer.Memo].ToString().Trim(); //备注
objSysSocialRelationsVerEN.CitationId = objRow[conSysSocialRelationsVer.CitationId] == DBNull.Value ? null : objRow[conSysSocialRelationsVer.CitationId].ToString().Trim(); //引用Id
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objSysSocialRelationsVerEN.SocialVId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objSysSocialRelationsVerEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsSysSocialRelationsVerEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsSysSocialRelationsVerEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsSysSocialRelationsVerEN> arrObjLst = new List<clsSysSocialRelationsVerEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsSysSocialRelationsVerEN objSysSocialRelationsVerEN = new clsSysSocialRelationsVerEN();
try
{
objSysSocialRelationsVerEN.SocialVId = Int32.Parse(objRow[conSysSocialRelationsVer.SocialVId].ToString().Trim()); //SocialVId
objSysSocialRelationsVerEN.SocialId = objRow[conSysSocialRelationsVer.SocialId].ToString().Trim(); //社会Id
objSysSocialRelationsVerEN.FullName = objRow[conSysSocialRelationsVer.FullName] == DBNull.Value ? null : objRow[conSysSocialRelationsVer.FullName].ToString().Trim(); //姓名
objSysSocialRelationsVerEN.Nationality = objRow[conSysSocialRelationsVer.Nationality] == DBNull.Value ? null : objRow[conSysSocialRelationsVer.Nationality].ToString().Trim(); //国籍
objSysSocialRelationsVerEN.WorkUnit = objRow[conSysSocialRelationsVer.WorkUnit] == DBNull.Value ? null : objRow[conSysSocialRelationsVer.WorkUnit].ToString().Trim(); //工作单位
objSysSocialRelationsVerEN.Major = objRow[conSysSocialRelationsVer.Major] == DBNull.Value ? null : objRow[conSysSocialRelationsVer.Major].ToString().Trim(); //专业
objSysSocialRelationsVerEN.Achievement = objRow[conSysSocialRelationsVer.Achievement] == DBNull.Value ? null : objRow[conSysSocialRelationsVer.Achievement].ToString().Trim(); //成就
objSysSocialRelationsVerEN.DetailedDescription = objRow[conSysSocialRelationsVer.DetailedDescription] == DBNull.Value ? null : objRow[conSysSocialRelationsVer.DetailedDescription].ToString().Trim(); //详细说明
objSysSocialRelationsVerEN.LevelId = objRow[conSysSocialRelationsVer.LevelId] == DBNull.Value ? null : objRow[conSysSocialRelationsVer.LevelId].ToString().Trim(); //级别Id
objSysSocialRelationsVerEN.UpdUser = objRow[conSysSocialRelationsVer.UpdUser] == DBNull.Value ? null : objRow[conSysSocialRelationsVer.UpdUser].ToString().Trim(); //修改人
objSysSocialRelationsVerEN.UpdDate = objRow[conSysSocialRelationsVer.UpdDate] == DBNull.Value ? null : objRow[conSysSocialRelationsVer.UpdDate].ToString().Trim(); //修改日期
objSysSocialRelationsVerEN.IdCurrEduCls = objRow[conSysSocialRelationsVer.IdCurrEduCls] == DBNull.Value ? null : objRow[conSysSocialRelationsVer.IdCurrEduCls].ToString().Trim(); //教学班流水号
objSysSocialRelationsVerEN.Memo = objRow[conSysSocialRelationsVer.Memo] == DBNull.Value ? null : objRow[conSysSocialRelationsVer.Memo].ToString().Trim(); //备注
objSysSocialRelationsVerEN.CitationId = objRow[conSysSocialRelationsVer.CitationId] == DBNull.Value ? null : objRow[conSysSocialRelationsVer.CitationId].ToString().Trim(); //引用Id
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objSysSocialRelationsVerEN.SocialVId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objSysSocialRelationsVerEN);
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
public static List<clsSysSocialRelationsVerEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsSysSocialRelationsVerEN> arrObjLst = new List<clsSysSocialRelationsVerEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsSysSocialRelationsVerEN objSysSocialRelationsVerEN = new clsSysSocialRelationsVerEN();
try
{
objSysSocialRelationsVerEN.SocialVId = Int32.Parse(objRow[conSysSocialRelationsVer.SocialVId].ToString().Trim()); //SocialVId
objSysSocialRelationsVerEN.SocialId = objRow[conSysSocialRelationsVer.SocialId].ToString().Trim(); //社会Id
objSysSocialRelationsVerEN.FullName = objRow[conSysSocialRelationsVer.FullName] == DBNull.Value ? null : objRow[conSysSocialRelationsVer.FullName].ToString().Trim(); //姓名
objSysSocialRelationsVerEN.Nationality = objRow[conSysSocialRelationsVer.Nationality] == DBNull.Value ? null : objRow[conSysSocialRelationsVer.Nationality].ToString().Trim(); //国籍
objSysSocialRelationsVerEN.WorkUnit = objRow[conSysSocialRelationsVer.WorkUnit] == DBNull.Value ? null : objRow[conSysSocialRelationsVer.WorkUnit].ToString().Trim(); //工作单位
objSysSocialRelationsVerEN.Major = objRow[conSysSocialRelationsVer.Major] == DBNull.Value ? null : objRow[conSysSocialRelationsVer.Major].ToString().Trim(); //专业
objSysSocialRelationsVerEN.Achievement = objRow[conSysSocialRelationsVer.Achievement] == DBNull.Value ? null : objRow[conSysSocialRelationsVer.Achievement].ToString().Trim(); //成就
objSysSocialRelationsVerEN.DetailedDescription = objRow[conSysSocialRelationsVer.DetailedDescription] == DBNull.Value ? null : objRow[conSysSocialRelationsVer.DetailedDescription].ToString().Trim(); //详细说明
objSysSocialRelationsVerEN.LevelId = objRow[conSysSocialRelationsVer.LevelId] == DBNull.Value ? null : objRow[conSysSocialRelationsVer.LevelId].ToString().Trim(); //级别Id
objSysSocialRelationsVerEN.UpdUser = objRow[conSysSocialRelationsVer.UpdUser] == DBNull.Value ? null : objRow[conSysSocialRelationsVer.UpdUser].ToString().Trim(); //修改人
objSysSocialRelationsVerEN.UpdDate = objRow[conSysSocialRelationsVer.UpdDate] == DBNull.Value ? null : objRow[conSysSocialRelationsVer.UpdDate].ToString().Trim(); //修改日期
objSysSocialRelationsVerEN.IdCurrEduCls = objRow[conSysSocialRelationsVer.IdCurrEduCls] == DBNull.Value ? null : objRow[conSysSocialRelationsVer.IdCurrEduCls].ToString().Trim(); //教学班流水号
objSysSocialRelationsVerEN.Memo = objRow[conSysSocialRelationsVer.Memo] == DBNull.Value ? null : objRow[conSysSocialRelationsVer.Memo].ToString().Trim(); //备注
objSysSocialRelationsVerEN.CitationId = objRow[conSysSocialRelationsVer.CitationId] == DBNull.Value ? null : objRow[conSysSocialRelationsVer.CitationId].ToString().Trim(); //引用Id
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objSysSocialRelationsVerEN.SocialVId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objSysSocialRelationsVerEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsSysSocialRelationsVerEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsSysSocialRelationsVerEN> arrObjLst = new List<clsSysSocialRelationsVerEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsSysSocialRelationsVerEN objSysSocialRelationsVerEN = new clsSysSocialRelationsVerEN();
try
{
objSysSocialRelationsVerEN.SocialVId = Int32.Parse(objRow[conSysSocialRelationsVer.SocialVId].ToString().Trim()); //SocialVId
objSysSocialRelationsVerEN.SocialId = objRow[conSysSocialRelationsVer.SocialId].ToString().Trim(); //社会Id
objSysSocialRelationsVerEN.FullName = objRow[conSysSocialRelationsVer.FullName] == DBNull.Value ? null : objRow[conSysSocialRelationsVer.FullName].ToString().Trim(); //姓名
objSysSocialRelationsVerEN.Nationality = objRow[conSysSocialRelationsVer.Nationality] == DBNull.Value ? null : objRow[conSysSocialRelationsVer.Nationality].ToString().Trim(); //国籍
objSysSocialRelationsVerEN.WorkUnit = objRow[conSysSocialRelationsVer.WorkUnit] == DBNull.Value ? null : objRow[conSysSocialRelationsVer.WorkUnit].ToString().Trim(); //工作单位
objSysSocialRelationsVerEN.Major = objRow[conSysSocialRelationsVer.Major] == DBNull.Value ? null : objRow[conSysSocialRelationsVer.Major].ToString().Trim(); //专业
objSysSocialRelationsVerEN.Achievement = objRow[conSysSocialRelationsVer.Achievement] == DBNull.Value ? null : objRow[conSysSocialRelationsVer.Achievement].ToString().Trim(); //成就
objSysSocialRelationsVerEN.DetailedDescription = objRow[conSysSocialRelationsVer.DetailedDescription] == DBNull.Value ? null : objRow[conSysSocialRelationsVer.DetailedDescription].ToString().Trim(); //详细说明
objSysSocialRelationsVerEN.LevelId = objRow[conSysSocialRelationsVer.LevelId] == DBNull.Value ? null : objRow[conSysSocialRelationsVer.LevelId].ToString().Trim(); //级别Id
objSysSocialRelationsVerEN.UpdUser = objRow[conSysSocialRelationsVer.UpdUser] == DBNull.Value ? null : objRow[conSysSocialRelationsVer.UpdUser].ToString().Trim(); //修改人
objSysSocialRelationsVerEN.UpdDate = objRow[conSysSocialRelationsVer.UpdDate] == DBNull.Value ? null : objRow[conSysSocialRelationsVer.UpdDate].ToString().Trim(); //修改日期
objSysSocialRelationsVerEN.IdCurrEduCls = objRow[conSysSocialRelationsVer.IdCurrEduCls] == DBNull.Value ? null : objRow[conSysSocialRelationsVer.IdCurrEduCls].ToString().Trim(); //教学班流水号
objSysSocialRelationsVerEN.Memo = objRow[conSysSocialRelationsVer.Memo] == DBNull.Value ? null : objRow[conSysSocialRelationsVer.Memo].ToString().Trim(); //备注
objSysSocialRelationsVerEN.CitationId = objRow[conSysSocialRelationsVer.CitationId] == DBNull.Value ? null : objRow[conSysSocialRelationsVer.CitationId].ToString().Trim(); //引用Id
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objSysSocialRelationsVerEN.SocialVId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objSysSocialRelationsVerEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objSysSocialRelationsVerEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetSysSocialRelationsVer(ref clsSysSocialRelationsVerEN objSysSocialRelationsVerEN)
{
bool bolResult = SysSocialRelationsVerDA.GetSysSocialRelationsVer(ref objSysSocialRelationsVerEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "lngSocialVId">表关键字</param>
 /// <returns>表对象</returns>
public static clsSysSocialRelationsVerEN GetObjBySocialVId(long lngSocialVId)
{
clsSysSocialRelationsVerEN objSysSocialRelationsVerEN = SysSocialRelationsVerDA.GetObjBySocialVId(lngSocialVId);
return objSysSocialRelationsVerEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsSysSocialRelationsVerEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsSysSocialRelationsVerEN objSysSocialRelationsVerEN = SysSocialRelationsVerDA.GetFirstObj(strWhereCond);
 return objSysSocialRelationsVerEN;
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
public static clsSysSocialRelationsVerEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsSysSocialRelationsVerEN objSysSocialRelationsVerEN = SysSocialRelationsVerDA.GetObjByDataRow(objRow);
 return objSysSocialRelationsVerEN;
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
public static clsSysSocialRelationsVerEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsSysSocialRelationsVerEN objSysSocialRelationsVerEN = SysSocialRelationsVerDA.GetObjByDataRow(objRow);
 return objSysSocialRelationsVerEN;
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
 /// <param name = "lngSocialVId">所给的关键字</param>
 /// <param name = "lstSysSocialRelationsVerObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsSysSocialRelationsVerEN GetObjBySocialVIdFromList(long lngSocialVId, List<clsSysSocialRelationsVerEN> lstSysSocialRelationsVerObjLst)
{
foreach (clsSysSocialRelationsVerEN objSysSocialRelationsVerEN in lstSysSocialRelationsVerObjLst)
{
if (objSysSocialRelationsVerEN.SocialVId == lngSocialVId)
{
return objSysSocialRelationsVerEN;
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
 long lngSocialVId;
 try
 {
 lngSocialVId = new clsSysSocialRelationsVerDA().GetFirstID(strWhereCond);
 return lngSocialVId;
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
 arrList = SysSocialRelationsVerDA.GetID(strWhereCond);
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
bool bolIsExist = SysSocialRelationsVerDA.IsExistCondRec(strWhereCond);
return bolIsExist;
}

 /// <summary>
 /// 判断当前表中是否存在给定关键字值的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExist)
 /// </summary>
 /// <param name = "lngSocialVId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public static bool IsExist(long lngSocialVId)
{
//检测记录是否存在
bool bolIsExist = SysSocialRelationsVerDA.IsExist(lngSocialVId);
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
 bolIsExist = clsSysSocialRelationsVerDA.IsExistTable();
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
 bolIsExist = SysSocialRelationsVerDA.IsExistTable(strTabName);
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


 #region 添加记录

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_AddNewRecordBySql2)
 /// </summary>
 /// <param name = "objSysSocialRelationsVerEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecordBySql2(clsSysSocialRelationsVerEN objSysSocialRelationsVerEN, bool bolIsNeedCheckUniqueness=true)
{
if (bolIsNeedCheckUniqueness == true && objSysSocialRelationsVerEN.CheckUniqueness() == false)
{
var strMsg = string.Format("记录已经存在!社会Id = [{0}]的数据已经存在!(in clsSysSocialRelationsVerBL.AddNewRecordBySql2)", objSysSocialRelationsVerEN.SocialId);
throw new Exception(strMsg);
}
try
{
bool bolResult = SysSocialRelationsVerDA.AddNewRecordBySQL2(objSysSocialRelationsVerEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsSysSocialRelationsVerBL.ReFreshCache();

if (clsSysSocialRelationsVerBL.relatedActions != null)
{
clsSysSocialRelationsVerBL.relatedActions.UpdRelaTabDate(objSysSocialRelationsVerEN.SocialVId, "SetUpdDate");
}
return bolResult;
}
catch (Exception objException)
{
var strMsg = string.Format("(errid:Busi000030)添加记录出错, {1}.(from {0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
}
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_AddNewRecordBySql2WithReturnKey)
 /// </summary>
 /// <param name = "objSysSocialRelationsVerEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordBySql2WithReturnKey(clsSysSocialRelationsVerEN objSysSocialRelationsVerEN, bool bolIsNeedCheckUniqueness=true)
{
if (bolIsNeedCheckUniqueness == true && objSysSocialRelationsVerEN.CheckUniqueness() == false)
{
var strMsg = string.Format("记录已经存在!社会Id = [{0}]的数据已经存在!(in clsSysSocialRelationsVerBL.AddNewRecordBySql2WithReturnKey)", objSysSocialRelationsVerEN.SocialId);
throw new Exception(strMsg);
}
try
{
string strKey = SysSocialRelationsVerDA.AddNewRecordBySQL2WithReturnKey(objSysSocialRelationsVerEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsSysSocialRelationsVerBL.ReFreshCache();

if (clsSysSocialRelationsVerBL.relatedActions != null)
{
clsSysSocialRelationsVerBL.relatedActions.UpdRelaTabDate(objSysSocialRelationsVerEN.SocialVId, "SetUpdDate");
}
return strKey;
}
catch (Exception objException)
{
var strMsg = string.Format("(errid:Busi000049)带返回值的添加记录出错, {1}.(from {0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
}
}


 #endregion 添加记录


 #region 修改记录

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Update)
 /// </summary>
 /// <param name = "objSysSocialRelationsVerEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(clsSysSocialRelationsVerEN objSysSocialRelationsVerEN)
{
try
{
bool bolResult = SysSocialRelationsVerDA.Update(objSysSocialRelationsVerEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsSysSocialRelationsVerBL.ReFreshCache();

if (clsSysSocialRelationsVerBL.relatedActions != null)
{
clsSysSocialRelationsVerBL.relatedActions.UpdRelaTabDate(objSysSocialRelationsVerEN.SocialVId, "SetUpdDate");
}
return bolResult;
}
catch (Exception objException)
{
var strMsg = string.Format("(errid:Busi000033)修改记录出错, {1}.(from {0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
}
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_UpdateBySql2)
 /// </summary>
 /// <param name = "objSysSocialRelationsVerEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateBySql2(clsSysSocialRelationsVerEN objSysSocialRelationsVerEN)
{
 if (objSysSocialRelationsVerEN.SocialVId == 0)
 {
var strMsg = string.Format("(errid:Busi000065)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = SysSocialRelationsVerDA.UpdateBySql2(objSysSocialRelationsVerEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsSysSocialRelationsVerBL.ReFreshCache();

if (clsSysSocialRelationsVerBL.relatedActions != null)
{
clsSysSocialRelationsVerBL.relatedActions.UpdRelaTabDate(objSysSocialRelationsVerEN.SocialVId, "SetUpdDate");
}
return bolResult;
}
catch (Exception objException)
{
var strMsg = string.Format("(errid:Busi000034)修改记录出错,{1}!(from {0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
}
}


 #endregion 修改记录


 #region 删除记录

 /// <summary>
 /// 功能:删除关键字所指定的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DelRecord)
 /// </summary>
 /// <param name = "lngSocialVId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int DelRecord(long lngSocialVId)
{
try
{
 clsSysSocialRelationsVerEN objSysSocialRelationsVerEN = clsSysSocialRelationsVerBL.GetObjBySocialVId(lngSocialVId);

if (clsSysSocialRelationsVerBL.relatedActions != null)
{
clsSysSocialRelationsVerBL.relatedActions.UpdRelaTabDate(objSysSocialRelationsVerEN.SocialVId, "SetUpdDate");
}
if (objSysSocialRelationsVerEN != null)
{
int intRecNum = SysSocialRelationsVerDA.DelRecord(lngSocialVId);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
ReFreshCache();
return intRecNum;
}
            else
{
return 0;
}
}
catch (Exception objException)
{
var strMsg = string.Format("(errid:Busi000039)根据关键字删除记录出错,{1}.({0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
}
}

 /// <summary>
/// 扩展删除记录,即同时删除多个表的记录,需要基于原子性的事务处理
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DelRecordEx)
/// </summary>
/// <param name="lngSocialVId">表关键字</param>
/// <returns></returns>
public static bool DelRecordEx(long lngSocialVId )
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsSysSocialRelationsVerDA.GetSpecSQLObj();
//删除TeacherInfo本表中与当前对象有关的记录
SqlConnection objConnection = null;
SqlTransaction objSqlTransaction = null;
  try
{
//获取连接对象
objConnection = objSQL.getConnectObj(objSQL.ConnectionString);
//获取该连接对象中的事务
objSqlTransaction = objConnection.BeginTransaction();
//
//删除与表:[SysSocialRelationsVer]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conSysSocialRelationsVer.SocialVId,
//lngSocialVId);
//        clsSysSocialRelationsVerBL.DelSysSocialRelationsVersByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsSysSocialRelationsVerBL.DelRecord(lngSocialVId, objConnection, objSqlTransaction);
objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsSysSocialRelationsVerBLEx", "DelRecordEx", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("扩展删除记录出错:{0}!keyId = {1}.({2})",
objException.Message,
lngSocialVId, clsStackTrace.GetCurrClassFunction());
clsSysParaEN.objErrorLog.WriteDebugLog(strMsg);
if (objSqlTransaction != null)
{
objSqlTransaction.Rollback();
}
throw new Exception(strMsg);
        }
finally
{
objConnection.Close();
}
}

 /// <summary>
 /// 功能:删除关键字所指的记录,使用事务
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DelRecordWithTransaction_S)
 /// </summary>
 /// <param name = "lngSocialVId">给定的关键字值</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回删除是否成功?</returns>
public static bool DelRecord(long lngSocialVId, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
if (clsSysSocialRelationsVerBL.relatedActions != null)
{
clsSysSocialRelationsVerBL.relatedActions.UpdRelaTabDate(lngSocialVId, "UpdRelaTabDate");
}
bool bolResult = SysSocialRelationsVerDA.DelRecord(lngSocialVId,objSqlConnection,objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
ReFreshCache();
return bolResult;
}
catch (Exception objException)
{
var strMsg = string.Format("(errid:Busi000040)根据关键字删除记录出错!(使用事务),{1}.({0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
}
}

 /// <summary>
 /// 功能:同时删除多条记录,删除给定关键字列表的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DelMultiRecord)
 /// </summary>
 /// <param name = "arrSocialVIdLst">给定的关键字值列表</param>
 /// <returns>返回删除的记录数</returns>
public static int DelSysSocialRelationsVers(List<string> arrSocialVIdLst)
{
if (arrSocialVIdLst.Count == 0) return 0;
try
{
if (clsSysSocialRelationsVerBL.relatedActions != null)
{
foreach (var strSocialVId in arrSocialVIdLst)
{
long lngSocialVId = long.Parse(strSocialVId);
clsSysSocialRelationsVerBL.relatedActions.UpdRelaTabDate(lngSocialVId, "UpdRelaTabDate");
}
}
int intDelRecNum = SysSocialRelationsVerDA.DelSysSocialRelationsVer(arrSocialVIdLst);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
ReFreshCache();
return intDelRecNum;
}
catch (Exception objException)
{
var strMsg = string.Format("(errid:Busi000042)删除多关键字记录出错,{1}.({0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
}
}

 /// <summary>
 /// 功能:删除满足条件的多条记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DelMultiRecordByCond)
 /// </summary>
 /// <param name = "strWhereCond">需要删除的记录条件</param>
 /// <returns>返回删除的记录数。</returns>
public static int DelSysSocialRelationsVersByCond(string strWhereCond)
{
try
{
if (clsSysSocialRelationsVerBL.relatedActions != null)
{
List<string> arrSocialVId = GetPrimaryKeyID_S(strWhereCond);
foreach (var strSocialVId in arrSocialVId)
{
long lngSocialVId = long.Parse(strSocialVId);
clsSysSocialRelationsVerBL.relatedActions.UpdRelaTabDate(lngSocialVId, "UpdRelaTabDate");
}
}
int intRecNum = SysSocialRelationsVerDA.DelSysSocialRelationsVer(strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
ReFreshCache();
return intRecNum;
}
catch (Exception objException)
{
var strMsg = string.Format("(errid:Busi000043)删除带条件表记录出错!(strWhereCond = {1}),{2}.({0})",
clsStackTrace.GetCurrClassFunction(),
strWhereCond,
objException.Message); 
throw new Exception(strMsg); 
}
}

 /// <summary>
/// 扩展删除记录,即同时删除多个表的记录,需要基于原子性的事务处理
/// 这里仅仅是演示函数,使用时请复制到扩展类:[SysSocialRelationsVer]中改名为:[DelRecord4MultiTabEx]使用
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DelRecord4MultiTab)
/// </summary>
/// <param name="lngSocialVId">表关键字</param>
/// <returns></returns>
public static bool DelRecord4MultiTab(long lngSocialVId)
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsSysSocialRelationsVerDA.GetSpecSQLObj();
//删除TeacherInfo本表中与当前对象有关的记录
SqlConnection objConnection = null;
SqlTransaction objSqlTransaction = null;
  try
{
//获取连接对象
objConnection = objSQL.getConnectObj(objSQL.ConnectionString);
//获取该连接对象中的事务
objSqlTransaction = objConnection.BeginTransaction();
//
//删除与表:[SysSocialRelationsVer]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conStudent.id_College,
//strid_College);
//        clsStudentBL.DelStudentsByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsSysSocialRelationsVerBL.DelRecord(lngSocialVId, objConnection, objSqlTransaction);
                objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsSysSocialRelationsVerBL", "DelRecord4MultiTab", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("删除多表记录出错:{0}!keyId = {1}.({2})",
objException.Message,
lngSocialVId, clsStackTrace.GetCurrClassFunction());
clsSysParaEN.objErrorLog.WriteDebugLog(strMsg);
if (objSqlTransaction != null)
{
objSqlTransaction.Rollback();
}
throw new Exception(strMsg);
        }
finally
{
objConnection.Close();
}
}


 #endregion 删除记录


 #region 克隆复制对象

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_CopyObj_S)
 /// </summary>
 /// <param name = "objSysSocialRelationsVerENS">源对象</param>
 /// <param name = "objSysSocialRelationsVerENT">目标对象</param>
 public static void CopyTo(clsSysSocialRelationsVerEN objSysSocialRelationsVerENS, clsSysSocialRelationsVerEN objSysSocialRelationsVerENT)
{
try
{
objSysSocialRelationsVerENT.SocialVId = objSysSocialRelationsVerENS.SocialVId; //SocialVId
objSysSocialRelationsVerENT.SocialId = objSysSocialRelationsVerENS.SocialId; //社会Id
objSysSocialRelationsVerENT.FullName = objSysSocialRelationsVerENS.FullName; //姓名
objSysSocialRelationsVerENT.Nationality = objSysSocialRelationsVerENS.Nationality; //国籍
objSysSocialRelationsVerENT.WorkUnit = objSysSocialRelationsVerENS.WorkUnit; //工作单位
objSysSocialRelationsVerENT.Major = objSysSocialRelationsVerENS.Major; //专业
objSysSocialRelationsVerENT.Achievement = objSysSocialRelationsVerENS.Achievement; //成就
objSysSocialRelationsVerENT.DetailedDescription = objSysSocialRelationsVerENS.DetailedDescription; //详细说明
objSysSocialRelationsVerENT.LevelId = objSysSocialRelationsVerENS.LevelId; //级别Id
objSysSocialRelationsVerENT.UpdUser = objSysSocialRelationsVerENS.UpdUser; //修改人
objSysSocialRelationsVerENT.UpdDate = objSysSocialRelationsVerENS.UpdDate; //修改日期
objSysSocialRelationsVerENT.IdCurrEduCls = objSysSocialRelationsVerENS.IdCurrEduCls; //教学班流水号
objSysSocialRelationsVerENT.Memo = objSysSocialRelationsVerENS.Memo; //备注
objSysSocialRelationsVerENT.CitationId = objSysSocialRelationsVerENS.CitationId; //引用Id
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
 /// <param name = "objSysSocialRelationsVerEN">源简化对象</param>
 public static void SetUpdFlag(clsSysSocialRelationsVerEN objSysSocialRelationsVerEN)
{
try
{
objSysSocialRelationsVerEN.ClearUpdateState();
   string strsfUpdFldSetStr = objSysSocialRelationsVerEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(conSysSocialRelationsVer.SocialVId, new clsStrCompareIgnoreCase())  ==  true)
{
objSysSocialRelationsVerEN.SocialVId = objSysSocialRelationsVerEN.SocialVId; //SocialVId
}
if (arrFldSet.Contains(conSysSocialRelationsVer.SocialId, new clsStrCompareIgnoreCase())  ==  true)
{
objSysSocialRelationsVerEN.SocialId = objSysSocialRelationsVerEN.SocialId; //社会Id
}
if (arrFldSet.Contains(conSysSocialRelationsVer.FullName, new clsStrCompareIgnoreCase())  ==  true)
{
objSysSocialRelationsVerEN.FullName = objSysSocialRelationsVerEN.FullName == "[null]" ? null :  objSysSocialRelationsVerEN.FullName; //姓名
}
if (arrFldSet.Contains(conSysSocialRelationsVer.Nationality, new clsStrCompareIgnoreCase())  ==  true)
{
objSysSocialRelationsVerEN.Nationality = objSysSocialRelationsVerEN.Nationality == "[null]" ? null :  objSysSocialRelationsVerEN.Nationality; //国籍
}
if (arrFldSet.Contains(conSysSocialRelationsVer.WorkUnit, new clsStrCompareIgnoreCase())  ==  true)
{
objSysSocialRelationsVerEN.WorkUnit = objSysSocialRelationsVerEN.WorkUnit == "[null]" ? null :  objSysSocialRelationsVerEN.WorkUnit; //工作单位
}
if (arrFldSet.Contains(conSysSocialRelationsVer.Major, new clsStrCompareIgnoreCase())  ==  true)
{
objSysSocialRelationsVerEN.Major = objSysSocialRelationsVerEN.Major == "[null]" ? null :  objSysSocialRelationsVerEN.Major; //专业
}
if (arrFldSet.Contains(conSysSocialRelationsVer.Achievement, new clsStrCompareIgnoreCase())  ==  true)
{
objSysSocialRelationsVerEN.Achievement = objSysSocialRelationsVerEN.Achievement == "[null]" ? null :  objSysSocialRelationsVerEN.Achievement; //成就
}
if (arrFldSet.Contains(conSysSocialRelationsVer.DetailedDescription, new clsStrCompareIgnoreCase())  ==  true)
{
objSysSocialRelationsVerEN.DetailedDescription = objSysSocialRelationsVerEN.DetailedDescription == "[null]" ? null :  objSysSocialRelationsVerEN.DetailedDescription; //详细说明
}
if (arrFldSet.Contains(conSysSocialRelationsVer.LevelId, new clsStrCompareIgnoreCase())  ==  true)
{
objSysSocialRelationsVerEN.LevelId = objSysSocialRelationsVerEN.LevelId == "[null]" ? null :  objSysSocialRelationsVerEN.LevelId; //级别Id
}
if (arrFldSet.Contains(conSysSocialRelationsVer.UpdUser, new clsStrCompareIgnoreCase())  ==  true)
{
objSysSocialRelationsVerEN.UpdUser = objSysSocialRelationsVerEN.UpdUser == "[null]" ? null :  objSysSocialRelationsVerEN.UpdUser; //修改人
}
if (arrFldSet.Contains(conSysSocialRelationsVer.UpdDate, new clsStrCompareIgnoreCase())  ==  true)
{
objSysSocialRelationsVerEN.UpdDate = objSysSocialRelationsVerEN.UpdDate == "[null]" ? null :  objSysSocialRelationsVerEN.UpdDate; //修改日期
}
if (arrFldSet.Contains(conSysSocialRelationsVer.IdCurrEduCls, new clsStrCompareIgnoreCase())  ==  true)
{
objSysSocialRelationsVerEN.IdCurrEduCls = objSysSocialRelationsVerEN.IdCurrEduCls == "[null]" ? null :  objSysSocialRelationsVerEN.IdCurrEduCls; //教学班流水号
}
if (arrFldSet.Contains(conSysSocialRelationsVer.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objSysSocialRelationsVerEN.Memo = objSysSocialRelationsVerEN.Memo == "[null]" ? null :  objSysSocialRelationsVerEN.Memo; //备注
}
if (arrFldSet.Contains(conSysSocialRelationsVer.CitationId, new clsStrCompareIgnoreCase())  ==  true)
{
objSysSocialRelationsVerEN.CitationId = objSysSocialRelationsVerEN.CitationId == "[null]" ? null :  objSysSocialRelationsVerEN.CitationId; //引用Id
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
 /// <param name = "objSysSocialRelationsVerEN">源简化对象</param>
 public static void AccessFldValueNull(clsSysSocialRelationsVerEN objSysSocialRelationsVerEN)
{
try
{
if (objSysSocialRelationsVerEN.FullName == "[null]") objSysSocialRelationsVerEN.FullName = null; //姓名
if (objSysSocialRelationsVerEN.Nationality == "[null]") objSysSocialRelationsVerEN.Nationality = null; //国籍
if (objSysSocialRelationsVerEN.WorkUnit == "[null]") objSysSocialRelationsVerEN.WorkUnit = null; //工作单位
if (objSysSocialRelationsVerEN.Major == "[null]") objSysSocialRelationsVerEN.Major = null; //专业
if (objSysSocialRelationsVerEN.Achievement == "[null]") objSysSocialRelationsVerEN.Achievement = null; //成就
if (objSysSocialRelationsVerEN.DetailedDescription == "[null]") objSysSocialRelationsVerEN.DetailedDescription = null; //详细说明
if (objSysSocialRelationsVerEN.LevelId == "[null]") objSysSocialRelationsVerEN.LevelId = null; //级别Id
if (objSysSocialRelationsVerEN.UpdUser == "[null]") objSysSocialRelationsVerEN.UpdUser = null; //修改人
if (objSysSocialRelationsVerEN.UpdDate == "[null]") objSysSocialRelationsVerEN.UpdDate = null; //修改日期
if (objSysSocialRelationsVerEN.IdCurrEduCls == "[null]") objSysSocialRelationsVerEN.IdCurrEduCls = null; //教学班流水号
if (objSysSocialRelationsVerEN.Memo == "[null]") objSysSocialRelationsVerEN.Memo = null; //备注
if (objSysSocialRelationsVerEN.CitationId == "[null]") objSysSocialRelationsVerEN.CitationId = null; //引用Id
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
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_CheckPropertyNew)
 /// </summary>
public static void CheckPropertyNew(clsSysSocialRelationsVerEN objSysSocialRelationsVerEN)
{
 SysSocialRelationsVerDA.CheckPropertyNew(objSysSocialRelationsVerEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(clsSysSocialRelationsVerEN objSysSocialRelationsVerEN)
{
 SysSocialRelationsVerDA.CheckProperty4Condition(objSysSocialRelationsVerEN);
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
if (clsSysSocialRelationsVerBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsSysSocialRelationsVerBL没有刷新缓存机制(clsSysSocialRelationsVerBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by SocialVId");
//if (arrSysSocialRelationsVerObjLstCache == null)
//{
//arrSysSocialRelationsVerObjLstCache = SysSocialRelationsVerDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "lngSocialVId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsSysSocialRelationsVerEN GetObjBySocialVIdCache(long lngSocialVId)
{
//获取缓存中的对象列表
string strKey = string.Format("{0}", clsSysSocialRelationsVerEN._CurrTabName);
List<clsSysSocialRelationsVerEN> arrSysSocialRelationsVerObjLstCache = GetObjLstCache();
IEnumerable <clsSysSocialRelationsVerEN> arrSysSocialRelationsVerObjLst_Sel =
arrSysSocialRelationsVerObjLstCache
.Where(x=> x.SocialVId == lngSocialVId 
);
if (arrSysSocialRelationsVerObjLst_Sel.Count() == 0)
{
   clsSysSocialRelationsVerEN obj = clsSysSocialRelationsVerBL.GetObjBySocialVId(lngSocialVId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
 }
return null;
}
return arrSysSocialRelationsVerObjLst_Sel.First();
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsSysSocialRelationsVerEN> GetAllSysSocialRelationsVerObjLstCache()
{
//获取缓存中的对象列表
List<clsSysSocialRelationsVerEN> arrSysSocialRelationsVerObjLstCache = GetObjLstCache(); 
return arrSysSocialRelationsVerObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsSysSocialRelationsVerEN> GetObjLstCache()
{
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}", clsSysSocialRelationsVerEN._CurrTabName);
List<clsSysSocialRelationsVerEN> arrSysSocialRelationsVerObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrSysSocialRelationsVerObjLstCache;
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
string strKey = string.Format("{0}", clsSysSocialRelationsVerEN._CurrTabName);
CacheHelper.Remove(strKey);
clsSysSocialRelationsVerEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
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
/// 获取最新的缓存刷新时间
/// </summary>
/// <returns>最新的缓存刷新时间，字符串型</returns>
public static string GetLastRefreshTime()
{
if (clsSysSocialRelationsVerEN._RefreshTimeLst.Count == 0) return "";
return clsSysSocialRelationsVerEN._RefreshTimeLst[clsSysSocialRelationsVerEN._RefreshTimeLst.Count - 1];
}

 /// <summary>
 /// 刷新缓存.把当前表的缓存以及该表相关视图的缓存清空.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ReFreshCache)
 /// </summary>
public static void ReFreshCache()
{
if (clsSysSocialRelationsVerBL.objCommFun4BL != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}", clsSysSocialRelationsVerEN._CurrTabName);
CacheHelper.Remove(strKey);
clsSysSocialRelationsVerEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
clsSysSocialRelationsVerBL.objCommFun4BL.ReFreshCache();
}
}


 #endregion 缓存操作


 #region 检查唯一性

 /// <summary>
 /// 获取检查唯一性条件串(Uniqueness)--SysSocialRelationsVer(社会关系版本表)
 /// 唯一性条件:SocialId
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetUniquenessConditionString)
 /// </summary>
 /// <param name = "objSysSocialRelationsVerEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(clsSysSocialRelationsVerEN objSysSocialRelationsVerEN)
{
//检测记录是否存在
string strResult = SysSocialRelationsVerDA.GetUniCondStr(objSysSocialRelationsVerEN);
return strResult;
}


 #endregion 检查唯一性

 /// <summary>
 /// 映射函数。根据表映射把输入字段值,映射成输出字段值
 /// 作者:pyf
 /// 日期:2024-11-13
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_func)
 /// </summary>
 /// <param name = "strInFldName">输入字段名</param>
 /// <param name = "strOutFldName">输出字段名</param>
 /// <param name = "strInValue">输入字段值</param>
 /// <returns>返回一个输出字段值</returns>
public static string Func(string strInFldName, string strOutFldName, long lngSocialVId)
{
if (strInFldName != conSysSocialRelationsVer.SocialVId)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (conSysSocialRelationsVer.AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", conSysSocialRelationsVer.AttributeName));
throw new Exception(strMsg);
}
var objSysSocialRelationsVer = clsSysSocialRelationsVerBL.GetObjBySocialVIdCache(lngSocialVId);
if (objSysSocialRelationsVer == null) return "";
return objSysSocialRelationsVer[strOutFldName].ToString();
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
int intRecCount = clsSysSocialRelationsVerDA.GetRecCount(strTabName);
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
int intRecCount = clsSysSocialRelationsVerDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsSysSocialRelationsVerDA.GetRecCount();
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
int intRecCount = clsSysSocialRelationsVerDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objSysSocialRelationsVerCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsSysSocialRelationsVerEN objSysSocialRelationsVerCond)
{
List<clsSysSocialRelationsVerEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsSysSocialRelationsVerEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conSysSocialRelationsVer.AttributeName)
{
if (objSysSocialRelationsVerCond.IsUpdated(strFldName) == false) continue;
if (objSysSocialRelationsVerCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objSysSocialRelationsVerCond[strFldName].ToString());
}
else
{
if (objSysSocialRelationsVerCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objSysSocialRelationsVerCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objSysSocialRelationsVerCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objSysSocialRelationsVerCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objSysSocialRelationsVerCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objSysSocialRelationsVerCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objSysSocialRelationsVerCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objSysSocialRelationsVerCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objSysSocialRelationsVerCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objSysSocialRelationsVerCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objSysSocialRelationsVerCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objSysSocialRelationsVerCond[strFldName]));
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
 List<string> arrList = clsSysSocialRelationsVerDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = SysSocialRelationsVerDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = SysSocialRelationsVerDA.GetFldValueNoDistinct(strFldName, strWhereCond);
return arrList;
}



 /// <summary>
 /// 功能:设置当前表中的符合条件的某字段的值
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_funSetFldValue4String)
 /// </summary>
 /// <param name = "strFldName">字段名</param>
 /// <param name = "strValue">值</param>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>影响的记录数</returns>
public int SetFldValue(string strFldName, string strValue, string strWhereCond) 
{
int intRecCount = SysSocialRelationsVerDA.SetFldValue(strFldName, strValue, strWhereCond);
//ReFreshCache();
return intRecCount;
}


 /// <summary>
 /// 功能:设置当前表中的符合条件的某字段的值
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_funSetFldValue4Float)
 /// </summary>
 /// <param name = "strFldName">字段名</param>
 /// <param name = "fltValue">值</param>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>影响的记录数</returns>
public int SetFldValue(string strFldName, float fltValue, string strWhereCond) 
{
int intRecCount = clsSysSocialRelationsVerDA.SetFldValue(clsSysSocialRelationsVerEN._CurrTabName, strFldName, fltValue, strWhereCond);
//ReFreshCache();
return intRecCount;
}

 /// <summary>
 /// 功能:设置当前表中的符合条件的某字段的值
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_funSetFldValue4Int)
 /// </summary>
 /// <param name = "strFldName">字段名</param>
 /// <param name = "intValue">值</param>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>影响的记录数</returns>
public int SetFldValue(string strFldName, int intValue, string strWhereCond) 
{
int intRecCount = SysSocialRelationsVerDA.SetFldValue( strFldName, intValue, strWhereCond);
//ReFreshCache();
return intRecCount;
}

 /// <summary>
 /// 功能:设置给定表中的符合条件的某字段的值
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_funSetFldValue4String_S)
 /// </summary>
 /// <param name = "strTabName">表名</param>
 /// <param name = "strFldName">字段名</param>
 /// <param name = "strValue">值</param>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>影响的记录数</returns>
public static int SetFldValue(string strTabName, string strFldName, string strValue, string strWhereCond) 
{
int intRecCount = clsSysSocialRelationsVerDA.SetFldValue(strTabName, strFldName, strValue, strWhereCond);
//ReFreshCache();
return intRecCount;
}

 /// <summary>
 /// 功能:设置给定表中的符合条件的某字段的值
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_funSetFldValue4Int_S)
 /// </summary>
 /// <param name = "strTabName">表名</param>
 /// <param name = "strFldName">字段名</param>
 /// <param name = "strValue">值</param>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>影响的记录数</returns>
public static int SetFldValue(string strTabName, string strFldName, int intValue, string strWhereCond) 
{
int intRecCount = clsSysSocialRelationsVerDA.SetFldValue(strTabName, strFldName, intValue, strWhereCond);
//ReFreshCache();
return intRecCount;
}

 /// <summary>
 /// 功能:设置给定表中的符合条件的某字段的值
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_funSetFldValue4Float_S)
 /// </summary>
 /// <param name = "strTabName">表名</param>
 /// <param name = "strFldName">字段名</param>
 /// <param name = "strValue">值</param>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>影响的记录数</returns>
public static int SetFldValue(string strTabName, string strFldName, float fltValue, string strWhereCond) 
{
int intRecCount = clsSysSocialRelationsVerDA.SetFldValue(strTabName, strFldName, fltValue, strWhereCond);
//ReFreshCache();
return intRecCount;
}



 #endregion 表操作常用函数


 #region 表操作

 /// <summary>
 /// 功能:获取建立表的代码
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GenSQLCode4CreateTab)
 /// </summary>
 /// <returns>建立表的代码</returns>
public static string GetCode4CreateTable() 
{
 StringBuilder strCreateTabCode = new StringBuilder();
  strCreateTabCode.Append("CREATE table [dbo].[SysSocialRelationsVer] "); 
 strCreateTabCode.Append(" ( "); 
 // /**SocialVId*/ 
 strCreateTabCode.Append(" SocialVId bigint primary key identity, "); 
 // /**社会Id*/ 
 strCreateTabCode.Append(" SocialId char(10) not Null, "); 
 // /**姓名*/ 
 strCreateTabCode.Append(" FullName varchar(50) Null, "); 
 // /**国籍*/ 
 strCreateTabCode.Append(" Nationality varchar(50) Null, "); 
 // /**工作单位*/ 
 strCreateTabCode.Append(" WorkUnit varchar(100) Null, "); 
 // /**专业*/ 
 strCreateTabCode.Append(" Major varchar(50) Null, "); 
 // /**成就*/ 
 strCreateTabCode.Append(" Achievement varchar(5000) Null, "); 
 // /**详细说明*/ 
 strCreateTabCode.Append(" DetailedDescription varchar(5000) Null, "); 
 // /**级别Id*/ 
 strCreateTabCode.Append(" LevelId char(2) Null, "); 
 // /**修改人*/ 
 strCreateTabCode.Append(" UpdUser varchar(20) Null, "); 
 // /**修改日期*/ 
 strCreateTabCode.Append(" UpdDate varchar(20) Null, "); 
 // /**教学班流水号*/ 
 strCreateTabCode.Append(" IdCurrEduCls char(8) Null, "); 
 // /**备注*/ 
 strCreateTabCode.Append(" Memo varchar(1000) Null, "); 
 // /**引用Id*/ 
 strCreateTabCode.Append(" CitationId char(8) Null ");
 strCreateTabCode.Append(") "); 
  strCreateTabCode.Append("ON [PRIMARY] ");
  return strCreateTabCode.ToString();
}



 #endregion 表操作
}
 /// <summary>
 /// 社会关系版本表(SysSocialRelationsVer)
 /// 数据源类型:表
 /// (AutoGCLib.CommFun4BL4CSharp:GeneCode_This)
 /// </summary>
public class  clsCommFun4BL4SysSocialRelationsVer : clsCommFun4BL
{

 /// <summary>
 /// 刷新缓存.把当前表的缓存以及该表相关视图的缓存清空.
 /// (AutoGCLib.CommFun4BL4CSharp:Gen_4CFBL_ReFreshCache)
 /// </summary>
public override void ReFreshCache()
{
string strMsg;
if (clsSysParaEN.spSetRefreshCacheOn == false)
{
strMsg = string.Format("刷新缓存已经关闭。(clsSysParaEN.spSetRefreshCacheOn == false)({2}->{1}->{0})",
clsStackTrace.GetCurrClassFunction(),
clsStackTrace.GetCurrClassFunctionByLevel(2),
clsStackTrace.GetCurrClassFunctionByLevel(3));
clsSysParaEN.objLog.WriteDebugLog(strMsg);
return;
}
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsSysSocialRelationsVerBL.ReFreshThisCache();
}
}

}