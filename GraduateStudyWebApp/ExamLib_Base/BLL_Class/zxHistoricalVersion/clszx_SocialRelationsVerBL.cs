
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clszx_SocialRelationsVerBL
 表名:zx_SocialRelationsVer(01120739)
 * 版本:2023.11.15.1(服务器:WIN-SRV103-116)
 日期:2023/11/15 23:08:07
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:研究生学习游戏化后台(变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:中学历史版本(zxHistoricalVersion)
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
public static class  clszx_SocialRelationsVerBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "lngSocialVId">表关键字</param>
 /// <returns>表对象</returns>
public static clszx_SocialRelationsVerEN GetObj(this K_SocialVId_zx_SocialRelationsVer myKey)
{
clszx_SocialRelationsVerEN objzx_SocialRelationsVerEN = clszx_SocialRelationsVerBL.zx_SocialRelationsVerDA.GetObjBySocialVId(myKey.Value);
return objzx_SocialRelationsVerEN;
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_AddNewRecord)
 /// </summary>
 /// <param name = "objzx_SocialRelationsVerEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clszx_SocialRelationsVerEN objzx_SocialRelationsVerEN)
{
if (CheckUniqueness(objzx_SocialRelationsVerEN) == false)
{
var strMsg = string.Format("记录已经存在!社会Id = [{0}],小组Id = [{1}]的数据已经存在!(in clszx_SocialRelationsVerBL.AddNewRecord)", objzx_SocialRelationsVerEN.zxSocialId,objzx_SocialRelationsVerEN.GroupTextId);
throw new Exception(strMsg);
}
try
{
bool bolResult = clszx_SocialRelationsVerBL.zx_SocialRelationsVerDA.AddNewRecordBySQL2(objzx_SocialRelationsVerEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clszx_SocialRelationsVerBL.ReFreshCache();

if (clszx_SocialRelationsVerBL.relatedActions != null)
{
clszx_SocialRelationsVerBL.relatedActions.UpdRelaTabDate(objzx_SocialRelationsVerEN.SocialVId, "SetUpdDate");
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
public static bool AddRecordEx(this clszx_SocialRelationsVerEN objzx_SocialRelationsVerEN)
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
objzx_SocialRelationsVerEN.CheckPropertyNew();
 ///5.2、检查唯一性
if (objzx_SocialRelationsVerEN.CheckUniqueness() == false)
{
strMsg = string.Format("(社会Id(zxSocialId)=[{0}],小组Id(GroupTextId)=[{1}])已经存在,不能重复!", objzx_SocialRelationsVerEN.zxSocialId, objzx_SocialRelationsVerEN.GroupTextId);
throw new Exception(strMsg);
}
//6、把数据实体层的数据存贮到数据库中
objzx_SocialRelationsVerEN.AddNewRecord();
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
 /// <param name = "objzx_SocialRelationsVerEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordWithReturnKey(this clszx_SocialRelationsVerEN objzx_SocialRelationsVerEN)
{
if (CheckUniqueness(objzx_SocialRelationsVerEN) == false)
{
var strMsg = string.Format("记录已经存在!社会Id = [{0}],小组Id = [{1}]的数据已经存在!(in clszx_SocialRelationsVerBL.AddNewRecordWithReturnKey)", objzx_SocialRelationsVerEN.zxSocialId,objzx_SocialRelationsVerEN.GroupTextId);
throw new Exception(strMsg);
}
try
{
string strKey = clszx_SocialRelationsVerBL.zx_SocialRelationsVerDA.AddNewRecordBySQL2WithReturnKey(objzx_SocialRelationsVerEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clszx_SocialRelationsVerBL.ReFreshCache();

if (clszx_SocialRelationsVerBL.relatedActions != null)
{
clszx_SocialRelationsVerBL.relatedActions.UpdRelaTabDate(objzx_SocialRelationsVerEN.SocialVId, "SetUpdDate");
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
 /// <param name = "objzx_SocialRelationsVerEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clszx_SocialRelationsVerEN SetSocialVId(this clszx_SocialRelationsVerEN objzx_SocialRelationsVerEN, long lngSocialVId, string strComparisonOp="")
	{
objzx_SocialRelationsVerEN.SocialVId = lngSocialVId; //SocialVId
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objzx_SocialRelationsVerEN.dicFldComparisonOp.ContainsKey(conzx_SocialRelationsVer.SocialVId) == false)
{
objzx_SocialRelationsVerEN.dicFldComparisonOp.Add(conzx_SocialRelationsVer.SocialVId, strComparisonOp);
}
else
{
objzx_SocialRelationsVerEN.dicFldComparisonOp[conzx_SocialRelationsVer.SocialVId] = strComparisonOp;
}
}
return objzx_SocialRelationsVerEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objzx_SocialRelationsVerEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clszx_SocialRelationsVerEN SetzxSocialId(this clszx_SocialRelationsVerEN objzx_SocialRelationsVerEN, string strzxSocialId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strzxSocialId, conzx_SocialRelationsVer.zxSocialId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strzxSocialId, 10, conzx_SocialRelationsVer.zxSocialId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strzxSocialId, 10, conzx_SocialRelationsVer.zxSocialId);
}
objzx_SocialRelationsVerEN.zxSocialId = strzxSocialId; //社会Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objzx_SocialRelationsVerEN.dicFldComparisonOp.ContainsKey(conzx_SocialRelationsVer.zxSocialId) == false)
{
objzx_SocialRelationsVerEN.dicFldComparisonOp.Add(conzx_SocialRelationsVer.zxSocialId, strComparisonOp);
}
else
{
objzx_SocialRelationsVerEN.dicFldComparisonOp[conzx_SocialRelationsVer.zxSocialId] = strComparisonOp;
}
}
return objzx_SocialRelationsVerEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objzx_SocialRelationsVerEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clszx_SocialRelationsVerEN SetFullName(this clszx_SocialRelationsVerEN objzx_SocialRelationsVerEN, string strFullName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFullName, 50, conzx_SocialRelationsVer.FullName);
}
objzx_SocialRelationsVerEN.FullName = strFullName; //姓名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objzx_SocialRelationsVerEN.dicFldComparisonOp.ContainsKey(conzx_SocialRelationsVer.FullName) == false)
{
objzx_SocialRelationsVerEN.dicFldComparisonOp.Add(conzx_SocialRelationsVer.FullName, strComparisonOp);
}
else
{
objzx_SocialRelationsVerEN.dicFldComparisonOp[conzx_SocialRelationsVer.FullName] = strComparisonOp;
}
}
return objzx_SocialRelationsVerEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objzx_SocialRelationsVerEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clszx_SocialRelationsVerEN SetNationality(this clszx_SocialRelationsVerEN objzx_SocialRelationsVerEN, string strNationality, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strNationality, 50, conzx_SocialRelationsVer.Nationality);
}
objzx_SocialRelationsVerEN.Nationality = strNationality; //国籍
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objzx_SocialRelationsVerEN.dicFldComparisonOp.ContainsKey(conzx_SocialRelationsVer.Nationality) == false)
{
objzx_SocialRelationsVerEN.dicFldComparisonOp.Add(conzx_SocialRelationsVer.Nationality, strComparisonOp);
}
else
{
objzx_SocialRelationsVerEN.dicFldComparisonOp[conzx_SocialRelationsVer.Nationality] = strComparisonOp;
}
}
return objzx_SocialRelationsVerEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objzx_SocialRelationsVerEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clszx_SocialRelationsVerEN SetWorkUnit(this clszx_SocialRelationsVerEN objzx_SocialRelationsVerEN, string strWorkUnit, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strWorkUnit, 100, conzx_SocialRelationsVer.WorkUnit);
}
objzx_SocialRelationsVerEN.WorkUnit = strWorkUnit; //工作单位
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objzx_SocialRelationsVerEN.dicFldComparisonOp.ContainsKey(conzx_SocialRelationsVer.WorkUnit) == false)
{
objzx_SocialRelationsVerEN.dicFldComparisonOp.Add(conzx_SocialRelationsVer.WorkUnit, strComparisonOp);
}
else
{
objzx_SocialRelationsVerEN.dicFldComparisonOp[conzx_SocialRelationsVer.WorkUnit] = strComparisonOp;
}
}
return objzx_SocialRelationsVerEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objzx_SocialRelationsVerEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clszx_SocialRelationsVerEN SetMajor(this clszx_SocialRelationsVerEN objzx_SocialRelationsVerEN, string strMajor, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMajor, 50, conzx_SocialRelationsVer.Major);
}
objzx_SocialRelationsVerEN.Major = strMajor; //专业
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objzx_SocialRelationsVerEN.dicFldComparisonOp.ContainsKey(conzx_SocialRelationsVer.Major) == false)
{
objzx_SocialRelationsVerEN.dicFldComparisonOp.Add(conzx_SocialRelationsVer.Major, strComparisonOp);
}
else
{
objzx_SocialRelationsVerEN.dicFldComparisonOp[conzx_SocialRelationsVer.Major] = strComparisonOp;
}
}
return objzx_SocialRelationsVerEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objzx_SocialRelationsVerEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clszx_SocialRelationsVerEN SetAchievement(this clszx_SocialRelationsVerEN objzx_SocialRelationsVerEN, string strAchievement, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strAchievement, 5000, conzx_SocialRelationsVer.Achievement);
}
objzx_SocialRelationsVerEN.Achievement = strAchievement; //成就
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objzx_SocialRelationsVerEN.dicFldComparisonOp.ContainsKey(conzx_SocialRelationsVer.Achievement) == false)
{
objzx_SocialRelationsVerEN.dicFldComparisonOp.Add(conzx_SocialRelationsVer.Achievement, strComparisonOp);
}
else
{
objzx_SocialRelationsVerEN.dicFldComparisonOp[conzx_SocialRelationsVer.Achievement] = strComparisonOp;
}
}
return objzx_SocialRelationsVerEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objzx_SocialRelationsVerEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clszx_SocialRelationsVerEN SetDetailedDescription(this clszx_SocialRelationsVerEN objzx_SocialRelationsVerEN, string strDetailedDescription, string strComparisonOp="")
	{
objzx_SocialRelationsVerEN.DetailedDescription = strDetailedDescription; //详细说明
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objzx_SocialRelationsVerEN.dicFldComparisonOp.ContainsKey(conzx_SocialRelationsVer.DetailedDescription) == false)
{
objzx_SocialRelationsVerEN.dicFldComparisonOp.Add(conzx_SocialRelationsVer.DetailedDescription, strComparisonOp);
}
else
{
objzx_SocialRelationsVerEN.dicFldComparisonOp[conzx_SocialRelationsVer.DetailedDescription] = strComparisonOp;
}
}
return objzx_SocialRelationsVerEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objzx_SocialRelationsVerEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clszx_SocialRelationsVerEN SetzxLevelId(this clszx_SocialRelationsVerEN objzx_SocialRelationsVerEN, string strzxLevelId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strzxLevelId, 2, conzx_SocialRelationsVer.zxLevelId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strzxLevelId, 2, conzx_SocialRelationsVer.zxLevelId);
}
objzx_SocialRelationsVerEN.zxLevelId = strzxLevelId; //级别Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objzx_SocialRelationsVerEN.dicFldComparisonOp.ContainsKey(conzx_SocialRelationsVer.zxLevelId) == false)
{
objzx_SocialRelationsVerEN.dicFldComparisonOp.Add(conzx_SocialRelationsVer.zxLevelId, strComparisonOp);
}
else
{
objzx_SocialRelationsVerEN.dicFldComparisonOp[conzx_SocialRelationsVer.zxLevelId] = strComparisonOp;
}
}
return objzx_SocialRelationsVerEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objzx_SocialRelationsVerEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clszx_SocialRelationsVerEN SetUpdUser(this clszx_SocialRelationsVerEN objzx_SocialRelationsVerEN, string strUpdUser, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdUser, 20, conzx_SocialRelationsVer.UpdUser);
}
objzx_SocialRelationsVerEN.UpdUser = strUpdUser; //修改人
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objzx_SocialRelationsVerEN.dicFldComparisonOp.ContainsKey(conzx_SocialRelationsVer.UpdUser) == false)
{
objzx_SocialRelationsVerEN.dicFldComparisonOp.Add(conzx_SocialRelationsVer.UpdUser, strComparisonOp);
}
else
{
objzx_SocialRelationsVerEN.dicFldComparisonOp[conzx_SocialRelationsVer.UpdUser] = strComparisonOp;
}
}
return objzx_SocialRelationsVerEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objzx_SocialRelationsVerEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clszx_SocialRelationsVerEN SetCreateDate(this clszx_SocialRelationsVerEN objzx_SocialRelationsVerEN, string strCreateDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCreateDate, 20, conzx_SocialRelationsVer.CreateDate);
}
objzx_SocialRelationsVerEN.CreateDate = strCreateDate; //建立日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objzx_SocialRelationsVerEN.dicFldComparisonOp.ContainsKey(conzx_SocialRelationsVer.CreateDate) == false)
{
objzx_SocialRelationsVerEN.dicFldComparisonOp.Add(conzx_SocialRelationsVer.CreateDate, strComparisonOp);
}
else
{
objzx_SocialRelationsVerEN.dicFldComparisonOp[conzx_SocialRelationsVer.CreateDate] = strComparisonOp;
}
}
return objzx_SocialRelationsVerEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objzx_SocialRelationsVerEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clszx_SocialRelationsVerEN SetUpdDate(this clszx_SocialRelationsVerEN objzx_SocialRelationsVerEN, string strUpdDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdDate, 20, conzx_SocialRelationsVer.UpdDate);
}
objzx_SocialRelationsVerEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objzx_SocialRelationsVerEN.dicFldComparisonOp.ContainsKey(conzx_SocialRelationsVer.UpdDate) == false)
{
objzx_SocialRelationsVerEN.dicFldComparisonOp.Add(conzx_SocialRelationsVer.UpdDate, strComparisonOp);
}
else
{
objzx_SocialRelationsVerEN.dicFldComparisonOp[conzx_SocialRelationsVer.UpdDate] = strComparisonOp;
}
}
return objzx_SocialRelationsVerEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objzx_SocialRelationsVerEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clszx_SocialRelationsVerEN SetIsSubmit(this clszx_SocialRelationsVerEN objzx_SocialRelationsVerEN, bool bolIsSubmit, string strComparisonOp="")
	{
objzx_SocialRelationsVerEN.IsSubmit = bolIsSubmit; //是否提交
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objzx_SocialRelationsVerEN.dicFldComparisonOp.ContainsKey(conzx_SocialRelationsVer.IsSubmit) == false)
{
objzx_SocialRelationsVerEN.dicFldComparisonOp.Add(conzx_SocialRelationsVer.IsSubmit, strComparisonOp);
}
else
{
objzx_SocialRelationsVerEN.dicFldComparisonOp[conzx_SocialRelationsVer.IsSubmit] = strComparisonOp;
}
}
return objzx_SocialRelationsVerEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objzx_SocialRelationsVerEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clszx_SocialRelationsVerEN SetVoteCount(this clszx_SocialRelationsVerEN objzx_SocialRelationsVerEN, int? intVoteCount, string strComparisonOp="")
	{
objzx_SocialRelationsVerEN.VoteCount = intVoteCount; //点赞计数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objzx_SocialRelationsVerEN.dicFldComparisonOp.ContainsKey(conzx_SocialRelationsVer.VoteCount) == false)
{
objzx_SocialRelationsVerEN.dicFldComparisonOp.Add(conzx_SocialRelationsVer.VoteCount, strComparisonOp);
}
else
{
objzx_SocialRelationsVerEN.dicFldComparisonOp[conzx_SocialRelationsVer.VoteCount] = strComparisonOp;
}
}
return objzx_SocialRelationsVerEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objzx_SocialRelationsVerEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clszx_SocialRelationsVerEN SetCitationCount(this clszx_SocialRelationsVerEN objzx_SocialRelationsVerEN, int? intCitationCount, string strComparisonOp="")
	{
objzx_SocialRelationsVerEN.CitationCount = intCitationCount; //引用统计
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objzx_SocialRelationsVerEN.dicFldComparisonOp.ContainsKey(conzx_SocialRelationsVer.CitationCount) == false)
{
objzx_SocialRelationsVerEN.dicFldComparisonOp.Add(conzx_SocialRelationsVer.CitationCount, strComparisonOp);
}
else
{
objzx_SocialRelationsVerEN.dicFldComparisonOp[conzx_SocialRelationsVer.CitationCount] = strComparisonOp;
}
}
return objzx_SocialRelationsVerEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objzx_SocialRelationsVerEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clszx_SocialRelationsVerEN SetVersionCount(this clszx_SocialRelationsVerEN objzx_SocialRelationsVerEN, int? intVersionCount, string strComparisonOp="")
	{
objzx_SocialRelationsVerEN.VersionCount = intVersionCount; //版本统计
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objzx_SocialRelationsVerEN.dicFldComparisonOp.ContainsKey(conzx_SocialRelationsVer.VersionCount) == false)
{
objzx_SocialRelationsVerEN.dicFldComparisonOp.Add(conzx_SocialRelationsVer.VersionCount, strComparisonOp);
}
else
{
objzx_SocialRelationsVerEN.dicFldComparisonOp[conzx_SocialRelationsVer.VersionCount] = strComparisonOp;
}
}
return objzx_SocialRelationsVerEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objzx_SocialRelationsVerEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clszx_SocialRelationsVerEN SetIdCurrEduCls(this clszx_SocialRelationsVerEN objzx_SocialRelationsVerEN, string strIdCurrEduCls, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdCurrEduCls, 8, conzx_SocialRelationsVer.IdCurrEduCls);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdCurrEduCls, 8, conzx_SocialRelationsVer.IdCurrEduCls);
}
objzx_SocialRelationsVerEN.IdCurrEduCls = strIdCurrEduCls; //教学班流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objzx_SocialRelationsVerEN.dicFldComparisonOp.ContainsKey(conzx_SocialRelationsVer.IdCurrEduCls) == false)
{
objzx_SocialRelationsVerEN.dicFldComparisonOp.Add(conzx_SocialRelationsVer.IdCurrEduCls, strComparisonOp);
}
else
{
objzx_SocialRelationsVerEN.dicFldComparisonOp[conzx_SocialRelationsVer.IdCurrEduCls] = strComparisonOp;
}
}
return objzx_SocialRelationsVerEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objzx_SocialRelationsVerEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clszx_SocialRelationsVerEN SetAppraiseCount(this clszx_SocialRelationsVerEN objzx_SocialRelationsVerEN, int? intAppraiseCount, string strComparisonOp="")
	{
objzx_SocialRelationsVerEN.AppraiseCount = intAppraiseCount; //评论数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objzx_SocialRelationsVerEN.dicFldComparisonOp.ContainsKey(conzx_SocialRelationsVer.AppraiseCount) == false)
{
objzx_SocialRelationsVerEN.dicFldComparisonOp.Add(conzx_SocialRelationsVer.AppraiseCount, strComparisonOp);
}
else
{
objzx_SocialRelationsVerEN.dicFldComparisonOp[conzx_SocialRelationsVer.AppraiseCount] = strComparisonOp;
}
}
return objzx_SocialRelationsVerEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objzx_SocialRelationsVerEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clszx_SocialRelationsVerEN SetScore(this clszx_SocialRelationsVerEN objzx_SocialRelationsVerEN, float? fltScore, string strComparisonOp="")
	{
objzx_SocialRelationsVerEN.Score = fltScore; //评分
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objzx_SocialRelationsVerEN.dicFldComparisonOp.ContainsKey(conzx_SocialRelationsVer.Score) == false)
{
objzx_SocialRelationsVerEN.dicFldComparisonOp.Add(conzx_SocialRelationsVer.Score, strComparisonOp);
}
else
{
objzx_SocialRelationsVerEN.dicFldComparisonOp[conzx_SocialRelationsVer.Score] = strComparisonOp;
}
}
return objzx_SocialRelationsVerEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objzx_SocialRelationsVerEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clszx_SocialRelationsVerEN SetStuScore(this clszx_SocialRelationsVerEN objzx_SocialRelationsVerEN, float? fltStuScore, string strComparisonOp="")
	{
objzx_SocialRelationsVerEN.StuScore = fltStuScore; //学生平均分
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objzx_SocialRelationsVerEN.dicFldComparisonOp.ContainsKey(conzx_SocialRelationsVer.StuScore) == false)
{
objzx_SocialRelationsVerEN.dicFldComparisonOp.Add(conzx_SocialRelationsVer.StuScore, strComparisonOp);
}
else
{
objzx_SocialRelationsVerEN.dicFldComparisonOp[conzx_SocialRelationsVer.StuScore] = strComparisonOp;
}
}
return objzx_SocialRelationsVerEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objzx_SocialRelationsVerEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clszx_SocialRelationsVerEN SetTeaScore(this clszx_SocialRelationsVerEN objzx_SocialRelationsVerEN, float? fltTeaScore, string strComparisonOp="")
	{
objzx_SocialRelationsVerEN.TeaScore = fltTeaScore; //教师评分
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objzx_SocialRelationsVerEN.dicFldComparisonOp.ContainsKey(conzx_SocialRelationsVer.TeaScore) == false)
{
objzx_SocialRelationsVerEN.dicFldComparisonOp.Add(conzx_SocialRelationsVer.TeaScore, strComparisonOp);
}
else
{
objzx_SocialRelationsVerEN.dicFldComparisonOp[conzx_SocialRelationsVer.TeaScore] = strComparisonOp;
}
}
return objzx_SocialRelationsVerEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objzx_SocialRelationsVerEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clszx_SocialRelationsVerEN SetTextId(this clszx_SocialRelationsVerEN objzx_SocialRelationsVerEN, string strTextId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTextId, 8, conzx_SocialRelationsVer.TextId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strTextId, 8, conzx_SocialRelationsVer.TextId);
}
objzx_SocialRelationsVerEN.TextId = strTextId; //课件Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objzx_SocialRelationsVerEN.dicFldComparisonOp.ContainsKey(conzx_SocialRelationsVer.TextId) == false)
{
objzx_SocialRelationsVerEN.dicFldComparisonOp.Add(conzx_SocialRelationsVer.TextId, strComparisonOp);
}
else
{
objzx_SocialRelationsVerEN.dicFldComparisonOp[conzx_SocialRelationsVer.TextId] = strComparisonOp;
}
}
return objzx_SocialRelationsVerEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objzx_SocialRelationsVerEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clszx_SocialRelationsVerEN SetzxShareId(this clszx_SocialRelationsVerEN objzx_SocialRelationsVerEN, string strzxShareId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strzxShareId, 2, conzx_SocialRelationsVer.zxShareId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strzxShareId, 2, conzx_SocialRelationsVer.zxShareId);
}
objzx_SocialRelationsVerEN.zxShareId = strzxShareId; //分享Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objzx_SocialRelationsVerEN.dicFldComparisonOp.ContainsKey(conzx_SocialRelationsVer.zxShareId) == false)
{
objzx_SocialRelationsVerEN.dicFldComparisonOp.Add(conzx_SocialRelationsVer.zxShareId, strComparisonOp);
}
else
{
objzx_SocialRelationsVerEN.dicFldComparisonOp[conzx_SocialRelationsVer.zxShareId] = strComparisonOp;
}
}
return objzx_SocialRelationsVerEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objzx_SocialRelationsVerEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clszx_SocialRelationsVerEN SetPdfContent(this clszx_SocialRelationsVerEN objzx_SocialRelationsVerEN, string strPdfContent, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPdfContent, 2000, conzx_SocialRelationsVer.PdfContent);
}
objzx_SocialRelationsVerEN.PdfContent = strPdfContent; //Pdf内容
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objzx_SocialRelationsVerEN.dicFldComparisonOp.ContainsKey(conzx_SocialRelationsVer.PdfContent) == false)
{
objzx_SocialRelationsVerEN.dicFldComparisonOp.Add(conzx_SocialRelationsVer.PdfContent, strComparisonOp);
}
else
{
objzx_SocialRelationsVerEN.dicFldComparisonOp[conzx_SocialRelationsVer.PdfContent] = strComparisonOp;
}
}
return objzx_SocialRelationsVerEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objzx_SocialRelationsVerEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clszx_SocialRelationsVerEN SetPdfPageNum(this clszx_SocialRelationsVerEN objzx_SocialRelationsVerEN, int? intPdfPageNum, string strComparisonOp="")
	{
objzx_SocialRelationsVerEN.PdfPageNum = intPdfPageNum; //Pdf页码
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objzx_SocialRelationsVerEN.dicFldComparisonOp.ContainsKey(conzx_SocialRelationsVer.PdfPageNum) == false)
{
objzx_SocialRelationsVerEN.dicFldComparisonOp.Add(conzx_SocialRelationsVer.PdfPageNum, strComparisonOp);
}
else
{
objzx_SocialRelationsVerEN.dicFldComparisonOp[conzx_SocialRelationsVer.PdfPageNum] = strComparisonOp;
}
}
return objzx_SocialRelationsVerEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objzx_SocialRelationsVerEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clszx_SocialRelationsVerEN SetMemo(this clszx_SocialRelationsVerEN objzx_SocialRelationsVerEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, conzx_SocialRelationsVer.Memo);
}
objzx_SocialRelationsVerEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objzx_SocialRelationsVerEN.dicFldComparisonOp.ContainsKey(conzx_SocialRelationsVer.Memo) == false)
{
objzx_SocialRelationsVerEN.dicFldComparisonOp.Add(conzx_SocialRelationsVer.Memo, strComparisonOp);
}
else
{
objzx_SocialRelationsVerEN.dicFldComparisonOp[conzx_SocialRelationsVer.Memo] = strComparisonOp;
}
}
return objzx_SocialRelationsVerEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objzx_SocialRelationsVerEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clszx_SocialRelationsVerEN SetPdfDivLet(this clszx_SocialRelationsVerEN objzx_SocialRelationsVerEN, string strPdfDivLet, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPdfDivLet, 50, conzx_SocialRelationsVer.PdfDivLet);
}
objzx_SocialRelationsVerEN.PdfDivLet = strPdfDivLet; //PdfDivLet
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objzx_SocialRelationsVerEN.dicFldComparisonOp.ContainsKey(conzx_SocialRelationsVer.PdfDivLet) == false)
{
objzx_SocialRelationsVerEN.dicFldComparisonOp.Add(conzx_SocialRelationsVer.PdfDivLet, strComparisonOp);
}
else
{
objzx_SocialRelationsVerEN.dicFldComparisonOp[conzx_SocialRelationsVer.PdfDivLet] = strComparisonOp;
}
}
return objzx_SocialRelationsVerEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objzx_SocialRelationsVerEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clszx_SocialRelationsVerEN SetPdfDivTop(this clszx_SocialRelationsVerEN objzx_SocialRelationsVerEN, string strPdfDivTop, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPdfDivTop, 50, conzx_SocialRelationsVer.PdfDivTop);
}
objzx_SocialRelationsVerEN.PdfDivTop = strPdfDivTop; //PdfDivTop
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objzx_SocialRelationsVerEN.dicFldComparisonOp.ContainsKey(conzx_SocialRelationsVer.PdfDivTop) == false)
{
objzx_SocialRelationsVerEN.dicFldComparisonOp.Add(conzx_SocialRelationsVer.PdfDivTop, strComparisonOp);
}
else
{
objzx_SocialRelationsVerEN.dicFldComparisonOp[conzx_SocialRelationsVer.PdfDivTop] = strComparisonOp;
}
}
return objzx_SocialRelationsVerEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objzx_SocialRelationsVerEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clszx_SocialRelationsVerEN SetPdfPageNumIn(this clszx_SocialRelationsVerEN objzx_SocialRelationsVerEN, string strPdfPageNumIn, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPdfPageNumIn, 50, conzx_SocialRelationsVer.PdfPageNumIn);
}
objzx_SocialRelationsVerEN.PdfPageNumIn = strPdfPageNumIn; //PdfPageNumIn
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objzx_SocialRelationsVerEN.dicFldComparisonOp.ContainsKey(conzx_SocialRelationsVer.PdfPageNumIn) == false)
{
objzx_SocialRelationsVerEN.dicFldComparisonOp.Add(conzx_SocialRelationsVer.PdfPageNumIn, strComparisonOp);
}
else
{
objzx_SocialRelationsVerEN.dicFldComparisonOp[conzx_SocialRelationsVer.PdfPageNumIn] = strComparisonOp;
}
}
return objzx_SocialRelationsVerEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objzx_SocialRelationsVerEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clszx_SocialRelationsVerEN SetPdfPageTop(this clszx_SocialRelationsVerEN objzx_SocialRelationsVerEN, int? intPdfPageTop, string strComparisonOp="")
	{
objzx_SocialRelationsVerEN.PdfPageTop = intPdfPageTop; //pdf页面顶部位置
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objzx_SocialRelationsVerEN.dicFldComparisonOp.ContainsKey(conzx_SocialRelationsVer.PdfPageTop) == false)
{
objzx_SocialRelationsVerEN.dicFldComparisonOp.Add(conzx_SocialRelationsVer.PdfPageTop, strComparisonOp);
}
else
{
objzx_SocialRelationsVerEN.dicFldComparisonOp[conzx_SocialRelationsVer.PdfPageTop] = strComparisonOp;
}
}
return objzx_SocialRelationsVerEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objzx_SocialRelationsVerEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clszx_SocialRelationsVerEN SetPdfZoom(this clszx_SocialRelationsVerEN objzx_SocialRelationsVerEN, string strPdfZoom, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPdfZoom, 50, conzx_SocialRelationsVer.PdfZoom);
}
objzx_SocialRelationsVerEN.PdfZoom = strPdfZoom; //PdfZoom
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objzx_SocialRelationsVerEN.dicFldComparisonOp.ContainsKey(conzx_SocialRelationsVer.PdfZoom) == false)
{
objzx_SocialRelationsVerEN.dicFldComparisonOp.Add(conzx_SocialRelationsVer.PdfZoom, strComparisonOp);
}
else
{
objzx_SocialRelationsVerEN.dicFldComparisonOp[conzx_SocialRelationsVer.PdfZoom] = strComparisonOp;
}
}
return objzx_SocialRelationsVerEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objzx_SocialRelationsVerEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clszx_SocialRelationsVerEN SetGroupTextId(this clszx_SocialRelationsVerEN objzx_SocialRelationsVerEN, string strGroupTextId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strGroupTextId, 8, conzx_SocialRelationsVer.GroupTextId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strGroupTextId, 8, conzx_SocialRelationsVer.GroupTextId);
}
objzx_SocialRelationsVerEN.GroupTextId = strGroupTextId; //小组Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objzx_SocialRelationsVerEN.dicFldComparisonOp.ContainsKey(conzx_SocialRelationsVer.GroupTextId) == false)
{
objzx_SocialRelationsVerEN.dicFldComparisonOp.Add(conzx_SocialRelationsVer.GroupTextId, strComparisonOp);
}
else
{
objzx_SocialRelationsVerEN.dicFldComparisonOp[conzx_SocialRelationsVer.GroupTextId] = strComparisonOp;
}
}
return objzx_SocialRelationsVerEN;
	}

 /// <summary>
 /// 修改记录存盘到数据表中
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_UpdateRecordEx)
 /// </summary>
 /// <param name = "objzx_SocialRelationsVerEN">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool UpdateRecordEx(this clszx_SocialRelationsVerEN objzx_SocialRelationsVerEN)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
try
{
//1、检查传进去的对象属性是否合法
objzx_SocialRelationsVerEN.CheckPropertyNew();
clszx_SocialRelationsVerEN objzx_SocialRelationsVerCond = new clszx_SocialRelationsVerEN();
string strCondition = objzx_SocialRelationsVerCond
.SetSocialVId(objzx_SocialRelationsVerEN.SocialVId, "<>")
.SetzxSocialId(objzx_SocialRelationsVerEN.zxSocialId, "=")
.SetGroupTextId(objzx_SocialRelationsVerEN.GroupTextId, "=")
.GetCombineCondition();
objzx_SocialRelationsVerEN._IsCheckProperty = true;
bool bolIsExist = clszx_SocialRelationsVerBL.IsExistRecord(strCondition);
if (bolIsExist)
{
strMsg = "(zxSocialId_GroupTextId)不能重复!";
throw new Exception(strMsg);
}
//4、把数据实体层的数据存贮到数据库中
objzx_SocialRelationsVerEN.Update();
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
 /// <param name = "objzx_SocialRelationsVer">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool EditRecordEx(this clszx_SocialRelationsVerEN objzx_SocialRelationsVer)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
clszx_SocialRelationsVerEN objzx_SocialRelationsVerCond = new clszx_SocialRelationsVerEN();
string strCondition = objzx_SocialRelationsVerCond
.SetzxSocialId(objzx_SocialRelationsVer.zxSocialId, "=")
.SetGroupTextId(objzx_SocialRelationsVer.GroupTextId, "=")
.GetCombineCondition();
objzx_SocialRelationsVer._IsCheckProperty = true;
bool bolIsExist = clszx_SocialRelationsVerBL.IsExistRecord(strCondition);
if (bolIsExist)
{
objzx_SocialRelationsVer.SocialVId = clszx_SocialRelationsVerBL.GetFirstID_S(strCondition);
objzx_SocialRelationsVer.UpdateWithCondition(strCondition);
}
else
{
objzx_SocialRelationsVer.AddNewRecord();
}
return true; 
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_Update)
 /// </summary>
 /// <param name = "objzx_SocialRelationsVerEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clszx_SocialRelationsVerEN objzx_SocialRelationsVerEN)
{
 if (objzx_SocialRelationsVerEN.SocialVId == 0)
 {
string strMsg = string.Format("(errid:Busi000095)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clszx_SocialRelationsVerBL.zx_SocialRelationsVerDA.UpdateBySql2(objzx_SocialRelationsVerEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clszx_SocialRelationsVerBL.ReFreshCache();

if (clszx_SocialRelationsVerBL.relatedActions != null)
{
clszx_SocialRelationsVerBL.relatedActions.UpdRelaTabDate(objzx_SocialRelationsVerEN.SocialVId, "SetUpdDate");
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
 /// <param name = "objzx_SocialRelationsVerEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clszx_SocialRelationsVerEN objzx_SocialRelationsVerEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (objzx_SocialRelationsVerEN.SocialVId == 0)
 {
string strMsg = string.Format("(errid:Busi000087)修改记录时关键字不能为空!(带事务处理)(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clszx_SocialRelationsVerBL.zx_SocialRelationsVerDA.UpdateBySql2(objzx_SocialRelationsVerEN, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clszx_SocialRelationsVerBL.ReFreshCache();

if (clszx_SocialRelationsVerBL.relatedActions != null)
{
clszx_SocialRelationsVerBL.relatedActions.UpdRelaTabDate(objzx_SocialRelationsVerEN.SocialVId, "SetUpdDate");
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
 /// <param name = "objzx_SocialRelationsVerEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clszx_SocialRelationsVerEN objzx_SocialRelationsVerEN, string strWhereCond)
{
try
{
bool bolResult = clszx_SocialRelationsVerBL.zx_SocialRelationsVerDA.UpdateBySqlWithCondition(objzx_SocialRelationsVerEN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clszx_SocialRelationsVerBL.ReFreshCache();

if (clszx_SocialRelationsVerBL.relatedActions != null)
{
clszx_SocialRelationsVerBL.relatedActions.UpdRelaTabDate(objzx_SocialRelationsVerEN.SocialVId, "SetUpdDate");
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
 /// <param name = "objzx_SocialRelationsVerEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clszx_SocialRelationsVerEN objzx_SocialRelationsVerEN, string strWhereCond, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
bool bolResult = clszx_SocialRelationsVerBL.zx_SocialRelationsVerDA.UpdateBySqlWithConditionTransaction(objzx_SocialRelationsVerEN, strWhereCond, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clszx_SocialRelationsVerBL.ReFreshCache();

if (clszx_SocialRelationsVerBL.relatedActions != null)
{
clszx_SocialRelationsVerBL.relatedActions.UpdRelaTabDate(objzx_SocialRelationsVerEN.SocialVId, "SetUpdDate");
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
public static int Delete(this clszx_SocialRelationsVerEN objzx_SocialRelationsVerEN)
{
try
{
int intRecNum = clszx_SocialRelationsVerBL.zx_SocialRelationsVerDA.DelRecord(objzx_SocialRelationsVerEN.SocialVId);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clszx_SocialRelationsVerBL.ReFreshCache();

if (clszx_SocialRelationsVerBL.relatedActions != null)
{
clszx_SocialRelationsVerBL.relatedActions.UpdRelaTabDate(objzx_SocialRelationsVerEN.SocialVId, "SetUpdDate");
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
 /// <param name = "objzx_SocialRelationsVerENS">源对象</param>
 /// <param name = "objzx_SocialRelationsVerENT">目标对象</param>
 public static void CopyTo(this clszx_SocialRelationsVerEN objzx_SocialRelationsVerENS, clszx_SocialRelationsVerEN objzx_SocialRelationsVerENT)
{
try
{
objzx_SocialRelationsVerENT.SocialVId = objzx_SocialRelationsVerENS.SocialVId; //SocialVId
objzx_SocialRelationsVerENT.zxSocialId = objzx_SocialRelationsVerENS.zxSocialId; //社会Id
objzx_SocialRelationsVerENT.FullName = objzx_SocialRelationsVerENS.FullName; //姓名
objzx_SocialRelationsVerENT.Nationality = objzx_SocialRelationsVerENS.Nationality; //国籍
objzx_SocialRelationsVerENT.WorkUnit = objzx_SocialRelationsVerENS.WorkUnit; //工作单位
objzx_SocialRelationsVerENT.Major = objzx_SocialRelationsVerENS.Major; //专业
objzx_SocialRelationsVerENT.Achievement = objzx_SocialRelationsVerENS.Achievement; //成就
objzx_SocialRelationsVerENT.DetailedDescription = objzx_SocialRelationsVerENS.DetailedDescription; //详细说明
objzx_SocialRelationsVerENT.zxLevelId = objzx_SocialRelationsVerENS.zxLevelId; //级别Id
objzx_SocialRelationsVerENT.UpdUser = objzx_SocialRelationsVerENS.UpdUser; //修改人
objzx_SocialRelationsVerENT.CreateDate = objzx_SocialRelationsVerENS.CreateDate; //建立日期
objzx_SocialRelationsVerENT.UpdDate = objzx_SocialRelationsVerENS.UpdDate; //修改日期
objzx_SocialRelationsVerENT.IsSubmit = objzx_SocialRelationsVerENS.IsSubmit; //是否提交
objzx_SocialRelationsVerENT.VoteCount = objzx_SocialRelationsVerENS.VoteCount; //点赞计数
objzx_SocialRelationsVerENT.CitationCount = objzx_SocialRelationsVerENS.CitationCount; //引用统计
objzx_SocialRelationsVerENT.VersionCount = objzx_SocialRelationsVerENS.VersionCount; //版本统计
objzx_SocialRelationsVerENT.IdCurrEduCls = objzx_SocialRelationsVerENS.IdCurrEduCls; //教学班流水号
objzx_SocialRelationsVerENT.AppraiseCount = objzx_SocialRelationsVerENS.AppraiseCount; //评论数
objzx_SocialRelationsVerENT.Score = objzx_SocialRelationsVerENS.Score; //评分
objzx_SocialRelationsVerENT.StuScore = objzx_SocialRelationsVerENS.StuScore; //学生平均分
objzx_SocialRelationsVerENT.TeaScore = objzx_SocialRelationsVerENS.TeaScore; //教师评分
objzx_SocialRelationsVerENT.TextId = objzx_SocialRelationsVerENS.TextId; //课件Id
objzx_SocialRelationsVerENT.zxShareId = objzx_SocialRelationsVerENS.zxShareId; //分享Id
objzx_SocialRelationsVerENT.PdfContent = objzx_SocialRelationsVerENS.PdfContent; //Pdf内容
objzx_SocialRelationsVerENT.PdfPageNum = objzx_SocialRelationsVerENS.PdfPageNum; //Pdf页码
objzx_SocialRelationsVerENT.Memo = objzx_SocialRelationsVerENS.Memo; //备注
objzx_SocialRelationsVerENT.PdfDivLet = objzx_SocialRelationsVerENS.PdfDivLet; //PdfDivLet
objzx_SocialRelationsVerENT.PdfDivTop = objzx_SocialRelationsVerENS.PdfDivTop; //PdfDivTop
objzx_SocialRelationsVerENT.PdfPageNumIn = objzx_SocialRelationsVerENS.PdfPageNumIn; //PdfPageNumIn
objzx_SocialRelationsVerENT.PdfPageTop = objzx_SocialRelationsVerENS.PdfPageTop; //pdf页面顶部位置
objzx_SocialRelationsVerENT.PdfZoom = objzx_SocialRelationsVerENS.PdfZoom; //PdfZoom
objzx_SocialRelationsVerENT.GroupTextId = objzx_SocialRelationsVerENS.GroupTextId; //小组Id
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
 /// <param name = "objzx_SocialRelationsVerENS">源对象</param>
 /// <returns>目标对象=>clszx_SocialRelationsVerEN:objzx_SocialRelationsVerENT</returns>
 public static clszx_SocialRelationsVerEN CopyTo(this clszx_SocialRelationsVerEN objzx_SocialRelationsVerENS)
{
try
{
 clszx_SocialRelationsVerEN objzx_SocialRelationsVerENT = new clszx_SocialRelationsVerEN()
{
SocialVId = objzx_SocialRelationsVerENS.SocialVId, //SocialVId
zxSocialId = objzx_SocialRelationsVerENS.zxSocialId, //社会Id
FullName = objzx_SocialRelationsVerENS.FullName, //姓名
Nationality = objzx_SocialRelationsVerENS.Nationality, //国籍
WorkUnit = objzx_SocialRelationsVerENS.WorkUnit, //工作单位
Major = objzx_SocialRelationsVerENS.Major, //专业
Achievement = objzx_SocialRelationsVerENS.Achievement, //成就
DetailedDescription = objzx_SocialRelationsVerENS.DetailedDescription, //详细说明
zxLevelId = objzx_SocialRelationsVerENS.zxLevelId, //级别Id
UpdUser = objzx_SocialRelationsVerENS.UpdUser, //修改人
CreateDate = objzx_SocialRelationsVerENS.CreateDate, //建立日期
UpdDate = objzx_SocialRelationsVerENS.UpdDate, //修改日期
IsSubmit = objzx_SocialRelationsVerENS.IsSubmit, //是否提交
VoteCount = objzx_SocialRelationsVerENS.VoteCount, //点赞计数
CitationCount = objzx_SocialRelationsVerENS.CitationCount, //引用统计
VersionCount = objzx_SocialRelationsVerENS.VersionCount, //版本统计
IdCurrEduCls = objzx_SocialRelationsVerENS.IdCurrEduCls, //教学班流水号
AppraiseCount = objzx_SocialRelationsVerENS.AppraiseCount, //评论数
Score = objzx_SocialRelationsVerENS.Score, //评分
StuScore = objzx_SocialRelationsVerENS.StuScore, //学生平均分
TeaScore = objzx_SocialRelationsVerENS.TeaScore, //教师评分
TextId = objzx_SocialRelationsVerENS.TextId, //课件Id
zxShareId = objzx_SocialRelationsVerENS.zxShareId, //分享Id
PdfContent = objzx_SocialRelationsVerENS.PdfContent, //Pdf内容
PdfPageNum = objzx_SocialRelationsVerENS.PdfPageNum, //Pdf页码
Memo = objzx_SocialRelationsVerENS.Memo, //备注
PdfDivLet = objzx_SocialRelationsVerENS.PdfDivLet, //PdfDivLet
PdfDivTop = objzx_SocialRelationsVerENS.PdfDivTop, //PdfDivTop
PdfPageNumIn = objzx_SocialRelationsVerENS.PdfPageNumIn, //PdfPageNumIn
PdfPageTop = objzx_SocialRelationsVerENS.PdfPageTop, //pdf页面顶部位置
PdfZoom = objzx_SocialRelationsVerENS.PdfZoom, //PdfZoom
GroupTextId = objzx_SocialRelationsVerENS.GroupTextId, //小组Id
};
 return objzx_SocialRelationsVerENT;
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
public static void CheckPropertyNew(this clszx_SocialRelationsVerEN objzx_SocialRelationsVerEN)
{
 clszx_SocialRelationsVerBL.zx_SocialRelationsVerDA.CheckPropertyNew(objzx_SocialRelationsVerEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(this clszx_SocialRelationsVerEN objzx_SocialRelationsVerEN)
{
 clszx_SocialRelationsVerBL.zx_SocialRelationsVerDA.CheckProperty4Condition(objzx_SocialRelationsVerEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clszx_SocialRelationsVerEN objzx_SocialRelationsVerCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objzx_SocialRelationsVerCond.IsUpdated(conzx_SocialRelationsVer.SocialVId) == true)
{
string strComparisonOpSocialVId = objzx_SocialRelationsVerCond.dicFldComparisonOp[conzx_SocialRelationsVer.SocialVId];
strWhereCond += string.Format(" And {0} {2} {1}", conzx_SocialRelationsVer.SocialVId, objzx_SocialRelationsVerCond.SocialVId, strComparisonOpSocialVId);
}
if (objzx_SocialRelationsVerCond.IsUpdated(conzx_SocialRelationsVer.zxSocialId) == true)
{
string strComparisonOpzxSocialId = objzx_SocialRelationsVerCond.dicFldComparisonOp[conzx_SocialRelationsVer.zxSocialId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conzx_SocialRelationsVer.zxSocialId, objzx_SocialRelationsVerCond.zxSocialId, strComparisonOpzxSocialId);
}
if (objzx_SocialRelationsVerCond.IsUpdated(conzx_SocialRelationsVer.FullName) == true)
{
string strComparisonOpFullName = objzx_SocialRelationsVerCond.dicFldComparisonOp[conzx_SocialRelationsVer.FullName];
strWhereCond += string.Format(" And {0} {2} '{1}'", conzx_SocialRelationsVer.FullName, objzx_SocialRelationsVerCond.FullName, strComparisonOpFullName);
}
if (objzx_SocialRelationsVerCond.IsUpdated(conzx_SocialRelationsVer.Nationality) == true)
{
string strComparisonOpNationality = objzx_SocialRelationsVerCond.dicFldComparisonOp[conzx_SocialRelationsVer.Nationality];
strWhereCond += string.Format(" And {0} {2} '{1}'", conzx_SocialRelationsVer.Nationality, objzx_SocialRelationsVerCond.Nationality, strComparisonOpNationality);
}
if (objzx_SocialRelationsVerCond.IsUpdated(conzx_SocialRelationsVer.WorkUnit) == true)
{
string strComparisonOpWorkUnit = objzx_SocialRelationsVerCond.dicFldComparisonOp[conzx_SocialRelationsVer.WorkUnit];
strWhereCond += string.Format(" And {0} {2} '{1}'", conzx_SocialRelationsVer.WorkUnit, objzx_SocialRelationsVerCond.WorkUnit, strComparisonOpWorkUnit);
}
if (objzx_SocialRelationsVerCond.IsUpdated(conzx_SocialRelationsVer.Major) == true)
{
string strComparisonOpMajor = objzx_SocialRelationsVerCond.dicFldComparisonOp[conzx_SocialRelationsVer.Major];
strWhereCond += string.Format(" And {0} {2} '{1}'", conzx_SocialRelationsVer.Major, objzx_SocialRelationsVerCond.Major, strComparisonOpMajor);
}
if (objzx_SocialRelationsVerCond.IsUpdated(conzx_SocialRelationsVer.Achievement) == true)
{
string strComparisonOpAchievement = objzx_SocialRelationsVerCond.dicFldComparisonOp[conzx_SocialRelationsVer.Achievement];
strWhereCond += string.Format(" And {0} {2} '{1}'", conzx_SocialRelationsVer.Achievement, objzx_SocialRelationsVerCond.Achievement, strComparisonOpAchievement);
}
//数据类型string(text)在函数:[AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj]中没有处理!
if (objzx_SocialRelationsVerCond.IsUpdated(conzx_SocialRelationsVer.zxLevelId) == true)
{
string strComparisonOpzxLevelId = objzx_SocialRelationsVerCond.dicFldComparisonOp[conzx_SocialRelationsVer.zxLevelId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conzx_SocialRelationsVer.zxLevelId, objzx_SocialRelationsVerCond.zxLevelId, strComparisonOpzxLevelId);
}
if (objzx_SocialRelationsVerCond.IsUpdated(conzx_SocialRelationsVer.UpdUser) == true)
{
string strComparisonOpUpdUser = objzx_SocialRelationsVerCond.dicFldComparisonOp[conzx_SocialRelationsVer.UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", conzx_SocialRelationsVer.UpdUser, objzx_SocialRelationsVerCond.UpdUser, strComparisonOpUpdUser);
}
if (objzx_SocialRelationsVerCond.IsUpdated(conzx_SocialRelationsVer.CreateDate) == true)
{
string strComparisonOpCreateDate = objzx_SocialRelationsVerCond.dicFldComparisonOp[conzx_SocialRelationsVer.CreateDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conzx_SocialRelationsVer.CreateDate, objzx_SocialRelationsVerCond.CreateDate, strComparisonOpCreateDate);
}
if (objzx_SocialRelationsVerCond.IsUpdated(conzx_SocialRelationsVer.UpdDate) == true)
{
string strComparisonOpUpdDate = objzx_SocialRelationsVerCond.dicFldComparisonOp[conzx_SocialRelationsVer.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conzx_SocialRelationsVer.UpdDate, objzx_SocialRelationsVerCond.UpdDate, strComparisonOpUpdDate);
}
if (objzx_SocialRelationsVerCond.IsUpdated(conzx_SocialRelationsVer.IsSubmit) == true)
{
if (objzx_SocialRelationsVerCond.IsSubmit == true)
{
strWhereCond += string.Format(" And {0} = '1'", conzx_SocialRelationsVer.IsSubmit);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conzx_SocialRelationsVer.IsSubmit);
}
}
if (objzx_SocialRelationsVerCond.IsUpdated(conzx_SocialRelationsVer.VoteCount) == true)
{
string strComparisonOpVoteCount = objzx_SocialRelationsVerCond.dicFldComparisonOp[conzx_SocialRelationsVer.VoteCount];
strWhereCond += string.Format(" And {0} {2} {1}", conzx_SocialRelationsVer.VoteCount, objzx_SocialRelationsVerCond.VoteCount, strComparisonOpVoteCount);
}
if (objzx_SocialRelationsVerCond.IsUpdated(conzx_SocialRelationsVer.CitationCount) == true)
{
string strComparisonOpCitationCount = objzx_SocialRelationsVerCond.dicFldComparisonOp[conzx_SocialRelationsVer.CitationCount];
strWhereCond += string.Format(" And {0} {2} {1}", conzx_SocialRelationsVer.CitationCount, objzx_SocialRelationsVerCond.CitationCount, strComparisonOpCitationCount);
}
if (objzx_SocialRelationsVerCond.IsUpdated(conzx_SocialRelationsVer.VersionCount) == true)
{
string strComparisonOpVersionCount = objzx_SocialRelationsVerCond.dicFldComparisonOp[conzx_SocialRelationsVer.VersionCount];
strWhereCond += string.Format(" And {0} {2} {1}", conzx_SocialRelationsVer.VersionCount, objzx_SocialRelationsVerCond.VersionCount, strComparisonOpVersionCount);
}
if (objzx_SocialRelationsVerCond.IsUpdated(conzx_SocialRelationsVer.IdCurrEduCls) == true)
{
string strComparisonOpIdCurrEduCls = objzx_SocialRelationsVerCond.dicFldComparisonOp[conzx_SocialRelationsVer.IdCurrEduCls];
strWhereCond += string.Format(" And {0} {2} '{1}'", conzx_SocialRelationsVer.IdCurrEduCls, objzx_SocialRelationsVerCond.IdCurrEduCls, strComparisonOpIdCurrEduCls);
}
if (objzx_SocialRelationsVerCond.IsUpdated(conzx_SocialRelationsVer.AppraiseCount) == true)
{
string strComparisonOpAppraiseCount = objzx_SocialRelationsVerCond.dicFldComparisonOp[conzx_SocialRelationsVer.AppraiseCount];
strWhereCond += string.Format(" And {0} {2} {1}", conzx_SocialRelationsVer.AppraiseCount, objzx_SocialRelationsVerCond.AppraiseCount, strComparisonOpAppraiseCount);
}
if (objzx_SocialRelationsVerCond.IsUpdated(conzx_SocialRelationsVer.Score) == true)
{
string strComparisonOpScore = objzx_SocialRelationsVerCond.dicFldComparisonOp[conzx_SocialRelationsVer.Score];
strWhereCond += string.Format(" And {0} {2} {1}", conzx_SocialRelationsVer.Score, objzx_SocialRelationsVerCond.Score, strComparisonOpScore);
}
if (objzx_SocialRelationsVerCond.IsUpdated(conzx_SocialRelationsVer.StuScore) == true)
{
string strComparisonOpStuScore = objzx_SocialRelationsVerCond.dicFldComparisonOp[conzx_SocialRelationsVer.StuScore];
strWhereCond += string.Format(" And {0} {2} {1}", conzx_SocialRelationsVer.StuScore, objzx_SocialRelationsVerCond.StuScore, strComparisonOpStuScore);
}
if (objzx_SocialRelationsVerCond.IsUpdated(conzx_SocialRelationsVer.TeaScore) == true)
{
string strComparisonOpTeaScore = objzx_SocialRelationsVerCond.dicFldComparisonOp[conzx_SocialRelationsVer.TeaScore];
strWhereCond += string.Format(" And {0} {2} {1}", conzx_SocialRelationsVer.TeaScore, objzx_SocialRelationsVerCond.TeaScore, strComparisonOpTeaScore);
}
if (objzx_SocialRelationsVerCond.IsUpdated(conzx_SocialRelationsVer.TextId) == true)
{
string strComparisonOpTextId = objzx_SocialRelationsVerCond.dicFldComparisonOp[conzx_SocialRelationsVer.TextId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conzx_SocialRelationsVer.TextId, objzx_SocialRelationsVerCond.TextId, strComparisonOpTextId);
}
if (objzx_SocialRelationsVerCond.IsUpdated(conzx_SocialRelationsVer.zxShareId) == true)
{
string strComparisonOpzxShareId = objzx_SocialRelationsVerCond.dicFldComparisonOp[conzx_SocialRelationsVer.zxShareId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conzx_SocialRelationsVer.zxShareId, objzx_SocialRelationsVerCond.zxShareId, strComparisonOpzxShareId);
}
if (objzx_SocialRelationsVerCond.IsUpdated(conzx_SocialRelationsVer.PdfContent) == true)
{
string strComparisonOpPdfContent = objzx_SocialRelationsVerCond.dicFldComparisonOp[conzx_SocialRelationsVer.PdfContent];
strWhereCond += string.Format(" And {0} {2} '{1}'", conzx_SocialRelationsVer.PdfContent, objzx_SocialRelationsVerCond.PdfContent, strComparisonOpPdfContent);
}
if (objzx_SocialRelationsVerCond.IsUpdated(conzx_SocialRelationsVer.PdfPageNum) == true)
{
string strComparisonOpPdfPageNum = objzx_SocialRelationsVerCond.dicFldComparisonOp[conzx_SocialRelationsVer.PdfPageNum];
strWhereCond += string.Format(" And {0} {2} {1}", conzx_SocialRelationsVer.PdfPageNum, objzx_SocialRelationsVerCond.PdfPageNum, strComparisonOpPdfPageNum);
}
if (objzx_SocialRelationsVerCond.IsUpdated(conzx_SocialRelationsVer.Memo) == true)
{
string strComparisonOpMemo = objzx_SocialRelationsVerCond.dicFldComparisonOp[conzx_SocialRelationsVer.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", conzx_SocialRelationsVer.Memo, objzx_SocialRelationsVerCond.Memo, strComparisonOpMemo);
}
if (objzx_SocialRelationsVerCond.IsUpdated(conzx_SocialRelationsVer.PdfDivLet) == true)
{
string strComparisonOpPdfDivLet = objzx_SocialRelationsVerCond.dicFldComparisonOp[conzx_SocialRelationsVer.PdfDivLet];
strWhereCond += string.Format(" And {0} {2} '{1}'", conzx_SocialRelationsVer.PdfDivLet, objzx_SocialRelationsVerCond.PdfDivLet, strComparisonOpPdfDivLet);
}
if (objzx_SocialRelationsVerCond.IsUpdated(conzx_SocialRelationsVer.PdfDivTop) == true)
{
string strComparisonOpPdfDivTop = objzx_SocialRelationsVerCond.dicFldComparisonOp[conzx_SocialRelationsVer.PdfDivTop];
strWhereCond += string.Format(" And {0} {2} '{1}'", conzx_SocialRelationsVer.PdfDivTop, objzx_SocialRelationsVerCond.PdfDivTop, strComparisonOpPdfDivTop);
}
if (objzx_SocialRelationsVerCond.IsUpdated(conzx_SocialRelationsVer.PdfPageNumIn) == true)
{
string strComparisonOpPdfPageNumIn = objzx_SocialRelationsVerCond.dicFldComparisonOp[conzx_SocialRelationsVer.PdfPageNumIn];
strWhereCond += string.Format(" And {0} {2} '{1}'", conzx_SocialRelationsVer.PdfPageNumIn, objzx_SocialRelationsVerCond.PdfPageNumIn, strComparisonOpPdfPageNumIn);
}
if (objzx_SocialRelationsVerCond.IsUpdated(conzx_SocialRelationsVer.PdfPageTop) == true)
{
string strComparisonOpPdfPageTop = objzx_SocialRelationsVerCond.dicFldComparisonOp[conzx_SocialRelationsVer.PdfPageTop];
strWhereCond += string.Format(" And {0} {2} {1}", conzx_SocialRelationsVer.PdfPageTop, objzx_SocialRelationsVerCond.PdfPageTop, strComparisonOpPdfPageTop);
}
if (objzx_SocialRelationsVerCond.IsUpdated(conzx_SocialRelationsVer.PdfZoom) == true)
{
string strComparisonOpPdfZoom = objzx_SocialRelationsVerCond.dicFldComparisonOp[conzx_SocialRelationsVer.PdfZoom];
strWhereCond += string.Format(" And {0} {2} '{1}'", conzx_SocialRelationsVer.PdfZoom, objzx_SocialRelationsVerCond.PdfZoom, strComparisonOpPdfZoom);
}
if (objzx_SocialRelationsVerCond.IsUpdated(conzx_SocialRelationsVer.GroupTextId) == true)
{
string strComparisonOpGroupTextId = objzx_SocialRelationsVerCond.dicFldComparisonOp[conzx_SocialRelationsVer.GroupTextId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conzx_SocialRelationsVer.GroupTextId, objzx_SocialRelationsVerCond.GroupTextId, strComparisonOpGroupTextId);
}
 return strWhereCond;
}

 /// <summary>
 /// 检查唯一性(Uniqueness)--zx_SocialRelationsVer(社会关系版本), 如果不唯一,即存在相同的记录,就返回False
 /// 唯一性条件:zxSocialId_GroupTextId
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckConstraint)
 /// </summary>
 /// <param name = "objzx_SocialRelationsVerEN">要求唯一的对象</param>
 /// <returns></returns>
public static bool CheckUniqueness(this clszx_SocialRelationsVerEN objzx_SocialRelationsVerEN)
{
//检测记录是否存在
bool bolIsUniqueness;
StringBuilder sbCondition = new StringBuilder();
if (objzx_SocialRelationsVerEN == null) return true;
if (objzx_SocialRelationsVerEN.SocialVId == 0)
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and zxSocialId = '{0}'", objzx_SocialRelationsVerEN.zxSocialId);
 if (objzx_SocialRelationsVerEN.GroupTextId == null)
{
 sbCondition.AppendFormat(" and GroupTextId is null", objzx_SocialRelationsVerEN.GroupTextId);
}
else
{
 sbCondition.AppendFormat(" and GroupTextId = '{0}'", objzx_SocialRelationsVerEN.GroupTextId);
}
if (clszx_SocialRelationsVerBL.IsExistRecord(sbCondition.ToString())  ==  true)
{
 bolIsUniqueness = false;
}
else
{
 bolIsUniqueness = true;
}
}
 else {
sbCondition.AppendFormat("SocialVId !=  {0}", objzx_SocialRelationsVerEN.SocialVId);
 sbCondition.AppendFormat(" and zxSocialId = '{0}'", objzx_SocialRelationsVerEN.zxSocialId);
 sbCondition.AppendFormat(" and GroupTextId = '{0}'", objzx_SocialRelationsVerEN.GroupTextId);
if (clszx_SocialRelationsVerBL.IsExistRecord(sbCondition.ToString())  ==  true)
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
 /// 获取唯一性条件串--zx_SocialRelationsVer(社会关系版本), 即由对象中唯一性条件字段关键字与值组成的条件串
 /// 唯一性条件:zxSocialId_GroupTextId
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetConditionString4Constraint)
 /// </summary>
 /// <param name = "objzx_SocialRelationsVerEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(this clszx_SocialRelationsVerEN objzx_SocialRelationsVerEN)
{
//检测记录是否存在
StringBuilder sbCondition = new StringBuilder();
if (objzx_SocialRelationsVerEN == null) return "";
if (objzx_SocialRelationsVerEN.SocialVId == 0)
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and zxSocialId = '{0}'", objzx_SocialRelationsVerEN.zxSocialId);
 if (objzx_SocialRelationsVerEN.GroupTextId == null)
{
 sbCondition.AppendFormat(" and GroupTextId is null", objzx_SocialRelationsVerEN.GroupTextId);
}
else
{
 sbCondition.AppendFormat(" and GroupTextId = '{0}'", objzx_SocialRelationsVerEN.GroupTextId);
}
return sbCondition.ToString();
}
 else {
sbCondition.AppendFormat("SocialVId !=  {0}", objzx_SocialRelationsVerEN.SocialVId);
 sbCondition.AppendFormat(" and zxSocialId = '{0}'", objzx_SocialRelationsVerEN.zxSocialId);
 sbCondition.AppendFormat(" and GroupTextId = '{0}'", objzx_SocialRelationsVerEN.GroupTextId);
 return sbCondition.ToString();
}
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_zx_SocialRelationsVer
{
public virtual bool UpdRelaTabDate(long lngSocialVId, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// 社会关系版本(zx_SocialRelationsVer)
 /// 数据源类型:表
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clszx_SocialRelationsVerBL
{
public static RelatedActions_zx_SocialRelationsVer relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clszx_SocialRelationsVerDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clszx_SocialRelationsVerDA zx_SocialRelationsVerDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clszx_SocialRelationsVerDA();
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
 public clszx_SocialRelationsVerBL()
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
if (string.IsNullOrEmpty(clszx_SocialRelationsVerEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clszx_SocialRelationsVerEN._ConnectString);
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
public static DataTable GetDataTable_zx_SocialRelationsVer(string strWhereCond)
{
DataTable objDT;
try
{
objDT = zx_SocialRelationsVerDA.GetDataTable_zx_SocialRelationsVer(strWhereCond);
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
objDT = zx_SocialRelationsVerDA.GetDataTable(strWhereCond);
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
objDT = zx_SocialRelationsVerDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = zx_SocialRelationsVerDA.GetDataTable(strWhereCond, strTabName);
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
objDT = zx_SocialRelationsVerDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = zx_SocialRelationsVerDA.GetDataTable_Top(objTopPara);
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
objDT = zx_SocialRelationsVerDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = zx_SocialRelationsVerDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = zx_SocialRelationsVerDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
public static List<clszx_SocialRelationsVerEN> GetObjLstBySocialVIdLst(List<long> arrSocialVIdLst)
{
List<clszx_SocialRelationsVerEN> arrObjLst = new List<clszx_SocialRelationsVerEN>(); 
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
	clszx_SocialRelationsVerEN objzx_SocialRelationsVerEN = new clszx_SocialRelationsVerEN();
try
{
objzx_SocialRelationsVerEN.SocialVId = Int32.Parse(objRow[conzx_SocialRelationsVer.SocialVId].ToString().Trim()); //SocialVId
objzx_SocialRelationsVerEN.zxSocialId = objRow[conzx_SocialRelationsVer.zxSocialId].ToString().Trim(); //社会Id
objzx_SocialRelationsVerEN.FullName = objRow[conzx_SocialRelationsVer.FullName] == DBNull.Value ? null : objRow[conzx_SocialRelationsVer.FullName].ToString().Trim(); //姓名
objzx_SocialRelationsVerEN.Nationality = objRow[conzx_SocialRelationsVer.Nationality] == DBNull.Value ? null : objRow[conzx_SocialRelationsVer.Nationality].ToString().Trim(); //国籍
objzx_SocialRelationsVerEN.WorkUnit = objRow[conzx_SocialRelationsVer.WorkUnit] == DBNull.Value ? null : objRow[conzx_SocialRelationsVer.WorkUnit].ToString().Trim(); //工作单位
objzx_SocialRelationsVerEN.Major = objRow[conzx_SocialRelationsVer.Major] == DBNull.Value ? null : objRow[conzx_SocialRelationsVer.Major].ToString().Trim(); //专业
objzx_SocialRelationsVerEN.Achievement = objRow[conzx_SocialRelationsVer.Achievement] == DBNull.Value ? null : objRow[conzx_SocialRelationsVer.Achievement].ToString().Trim(); //成就
objzx_SocialRelationsVerEN.DetailedDescription = objRow[conzx_SocialRelationsVer.DetailedDescription] == DBNull.Value ? null : objRow[conzx_SocialRelationsVer.DetailedDescription].ToString().Trim(); //详细说明
objzx_SocialRelationsVerEN.zxLevelId = objRow[conzx_SocialRelationsVer.zxLevelId] == DBNull.Value ? null : objRow[conzx_SocialRelationsVer.zxLevelId].ToString().Trim(); //级别Id
objzx_SocialRelationsVerEN.UpdUser = objRow[conzx_SocialRelationsVer.UpdUser] == DBNull.Value ? null : objRow[conzx_SocialRelationsVer.UpdUser].ToString().Trim(); //修改人
objzx_SocialRelationsVerEN.CreateDate = objRow[conzx_SocialRelationsVer.CreateDate] == DBNull.Value ? null : objRow[conzx_SocialRelationsVer.CreateDate].ToString().Trim(); //建立日期
objzx_SocialRelationsVerEN.UpdDate = objRow[conzx_SocialRelationsVer.UpdDate] == DBNull.Value ? null : objRow[conzx_SocialRelationsVer.UpdDate].ToString().Trim(); //修改日期
objzx_SocialRelationsVerEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[conzx_SocialRelationsVer.IsSubmit].ToString().Trim()); //是否提交
objzx_SocialRelationsVerEN.VoteCount = objRow[conzx_SocialRelationsVer.VoteCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_SocialRelationsVer.VoteCount].ToString().Trim()); //点赞计数
objzx_SocialRelationsVerEN.CitationCount = objRow[conzx_SocialRelationsVer.CitationCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_SocialRelationsVer.CitationCount].ToString().Trim()); //引用统计
objzx_SocialRelationsVerEN.VersionCount = objRow[conzx_SocialRelationsVer.VersionCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_SocialRelationsVer.VersionCount].ToString().Trim()); //版本统计
objzx_SocialRelationsVerEN.IdCurrEduCls = objRow[conzx_SocialRelationsVer.IdCurrEduCls] == DBNull.Value ? null : objRow[conzx_SocialRelationsVer.IdCurrEduCls].ToString().Trim(); //教学班流水号
objzx_SocialRelationsVerEN.AppraiseCount = objRow[conzx_SocialRelationsVer.AppraiseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_SocialRelationsVer.AppraiseCount].ToString().Trim()); //评论数
objzx_SocialRelationsVerEN.Score = objRow[conzx_SocialRelationsVer.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conzx_SocialRelationsVer.Score].ToString().Trim()); //评分
objzx_SocialRelationsVerEN.StuScore = objRow[conzx_SocialRelationsVer.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conzx_SocialRelationsVer.StuScore].ToString().Trim()); //学生平均分
objzx_SocialRelationsVerEN.TeaScore = objRow[conzx_SocialRelationsVer.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conzx_SocialRelationsVer.TeaScore].ToString().Trim()); //教师评分
objzx_SocialRelationsVerEN.TextId = objRow[conzx_SocialRelationsVer.TextId] == DBNull.Value ? null : objRow[conzx_SocialRelationsVer.TextId].ToString().Trim(); //课件Id
objzx_SocialRelationsVerEN.zxShareId = objRow[conzx_SocialRelationsVer.zxShareId] == DBNull.Value ? null : objRow[conzx_SocialRelationsVer.zxShareId].ToString().Trim(); //分享Id
objzx_SocialRelationsVerEN.PdfContent = objRow[conzx_SocialRelationsVer.PdfContent] == DBNull.Value ? null : objRow[conzx_SocialRelationsVer.PdfContent].ToString().Trim(); //Pdf内容
objzx_SocialRelationsVerEN.PdfPageNum = objRow[conzx_SocialRelationsVer.PdfPageNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_SocialRelationsVer.PdfPageNum].ToString().Trim()); //Pdf页码
objzx_SocialRelationsVerEN.Memo = objRow[conzx_SocialRelationsVer.Memo] == DBNull.Value ? null : objRow[conzx_SocialRelationsVer.Memo].ToString().Trim(); //备注
objzx_SocialRelationsVerEN.PdfDivLet = objRow[conzx_SocialRelationsVer.PdfDivLet] == DBNull.Value ? null : objRow[conzx_SocialRelationsVer.PdfDivLet].ToString().Trim(); //PdfDivLet
objzx_SocialRelationsVerEN.PdfDivTop = objRow[conzx_SocialRelationsVer.PdfDivTop] == DBNull.Value ? null : objRow[conzx_SocialRelationsVer.PdfDivTop].ToString().Trim(); //PdfDivTop
objzx_SocialRelationsVerEN.PdfPageNumIn = objRow[conzx_SocialRelationsVer.PdfPageNumIn] == DBNull.Value ? null : objRow[conzx_SocialRelationsVer.PdfPageNumIn].ToString().Trim(); //PdfPageNumIn
objzx_SocialRelationsVerEN.PdfPageTop = objRow[conzx_SocialRelationsVer.PdfPageTop] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_SocialRelationsVer.PdfPageTop].ToString().Trim()); //pdf页面顶部位置
objzx_SocialRelationsVerEN.PdfZoom = objRow[conzx_SocialRelationsVer.PdfZoom] == DBNull.Value ? null : objRow[conzx_SocialRelationsVer.PdfZoom].ToString().Trim(); //PdfZoom
objzx_SocialRelationsVerEN.GroupTextId = objRow[conzx_SocialRelationsVer.GroupTextId] == DBNull.Value ? null : objRow[conzx_SocialRelationsVer.GroupTextId].ToString().Trim(); //小组Id
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objzx_SocialRelationsVerEN.SocialVId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objzx_SocialRelationsVerEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrSocialVIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clszx_SocialRelationsVerEN> GetObjLstBySocialVIdLstCache(List<long> arrSocialVIdLst)
{
string strKey = string.Format("{0}", clszx_SocialRelationsVerEN._CurrTabName);
List<clszx_SocialRelationsVerEN> arrzx_SocialRelationsVerObjLstCache = GetObjLstCache();
IEnumerable <clszx_SocialRelationsVerEN> arrzx_SocialRelationsVerObjLst_Sel =
arrzx_SocialRelationsVerObjLstCache
.Where(x => arrSocialVIdLst.Contains(x.SocialVId));
return arrzx_SocialRelationsVerObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clszx_SocialRelationsVerEN> GetObjLst(string strWhereCond)
{
List<clszx_SocialRelationsVerEN> arrObjLst = new List<clszx_SocialRelationsVerEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clszx_SocialRelationsVerEN objzx_SocialRelationsVerEN = new clszx_SocialRelationsVerEN();
try
{
objzx_SocialRelationsVerEN.SocialVId = Int32.Parse(objRow[conzx_SocialRelationsVer.SocialVId].ToString().Trim()); //SocialVId
objzx_SocialRelationsVerEN.zxSocialId = objRow[conzx_SocialRelationsVer.zxSocialId].ToString().Trim(); //社会Id
objzx_SocialRelationsVerEN.FullName = objRow[conzx_SocialRelationsVer.FullName] == DBNull.Value ? null : objRow[conzx_SocialRelationsVer.FullName].ToString().Trim(); //姓名
objzx_SocialRelationsVerEN.Nationality = objRow[conzx_SocialRelationsVer.Nationality] == DBNull.Value ? null : objRow[conzx_SocialRelationsVer.Nationality].ToString().Trim(); //国籍
objzx_SocialRelationsVerEN.WorkUnit = objRow[conzx_SocialRelationsVer.WorkUnit] == DBNull.Value ? null : objRow[conzx_SocialRelationsVer.WorkUnit].ToString().Trim(); //工作单位
objzx_SocialRelationsVerEN.Major = objRow[conzx_SocialRelationsVer.Major] == DBNull.Value ? null : objRow[conzx_SocialRelationsVer.Major].ToString().Trim(); //专业
objzx_SocialRelationsVerEN.Achievement = objRow[conzx_SocialRelationsVer.Achievement] == DBNull.Value ? null : objRow[conzx_SocialRelationsVer.Achievement].ToString().Trim(); //成就
objzx_SocialRelationsVerEN.DetailedDescription = objRow[conzx_SocialRelationsVer.DetailedDescription] == DBNull.Value ? null : objRow[conzx_SocialRelationsVer.DetailedDescription].ToString().Trim(); //详细说明
objzx_SocialRelationsVerEN.zxLevelId = objRow[conzx_SocialRelationsVer.zxLevelId] == DBNull.Value ? null : objRow[conzx_SocialRelationsVer.zxLevelId].ToString().Trim(); //级别Id
objzx_SocialRelationsVerEN.UpdUser = objRow[conzx_SocialRelationsVer.UpdUser] == DBNull.Value ? null : objRow[conzx_SocialRelationsVer.UpdUser].ToString().Trim(); //修改人
objzx_SocialRelationsVerEN.CreateDate = objRow[conzx_SocialRelationsVer.CreateDate] == DBNull.Value ? null : objRow[conzx_SocialRelationsVer.CreateDate].ToString().Trim(); //建立日期
objzx_SocialRelationsVerEN.UpdDate = objRow[conzx_SocialRelationsVer.UpdDate] == DBNull.Value ? null : objRow[conzx_SocialRelationsVer.UpdDate].ToString().Trim(); //修改日期
objzx_SocialRelationsVerEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[conzx_SocialRelationsVer.IsSubmit].ToString().Trim()); //是否提交
objzx_SocialRelationsVerEN.VoteCount = objRow[conzx_SocialRelationsVer.VoteCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_SocialRelationsVer.VoteCount].ToString().Trim()); //点赞计数
objzx_SocialRelationsVerEN.CitationCount = objRow[conzx_SocialRelationsVer.CitationCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_SocialRelationsVer.CitationCount].ToString().Trim()); //引用统计
objzx_SocialRelationsVerEN.VersionCount = objRow[conzx_SocialRelationsVer.VersionCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_SocialRelationsVer.VersionCount].ToString().Trim()); //版本统计
objzx_SocialRelationsVerEN.IdCurrEduCls = objRow[conzx_SocialRelationsVer.IdCurrEduCls] == DBNull.Value ? null : objRow[conzx_SocialRelationsVer.IdCurrEduCls].ToString().Trim(); //教学班流水号
objzx_SocialRelationsVerEN.AppraiseCount = objRow[conzx_SocialRelationsVer.AppraiseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_SocialRelationsVer.AppraiseCount].ToString().Trim()); //评论数
objzx_SocialRelationsVerEN.Score = objRow[conzx_SocialRelationsVer.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conzx_SocialRelationsVer.Score].ToString().Trim()); //评分
objzx_SocialRelationsVerEN.StuScore = objRow[conzx_SocialRelationsVer.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conzx_SocialRelationsVer.StuScore].ToString().Trim()); //学生平均分
objzx_SocialRelationsVerEN.TeaScore = objRow[conzx_SocialRelationsVer.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conzx_SocialRelationsVer.TeaScore].ToString().Trim()); //教师评分
objzx_SocialRelationsVerEN.TextId = objRow[conzx_SocialRelationsVer.TextId] == DBNull.Value ? null : objRow[conzx_SocialRelationsVer.TextId].ToString().Trim(); //课件Id
objzx_SocialRelationsVerEN.zxShareId = objRow[conzx_SocialRelationsVer.zxShareId] == DBNull.Value ? null : objRow[conzx_SocialRelationsVer.zxShareId].ToString().Trim(); //分享Id
objzx_SocialRelationsVerEN.PdfContent = objRow[conzx_SocialRelationsVer.PdfContent] == DBNull.Value ? null : objRow[conzx_SocialRelationsVer.PdfContent].ToString().Trim(); //Pdf内容
objzx_SocialRelationsVerEN.PdfPageNum = objRow[conzx_SocialRelationsVer.PdfPageNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_SocialRelationsVer.PdfPageNum].ToString().Trim()); //Pdf页码
objzx_SocialRelationsVerEN.Memo = objRow[conzx_SocialRelationsVer.Memo] == DBNull.Value ? null : objRow[conzx_SocialRelationsVer.Memo].ToString().Trim(); //备注
objzx_SocialRelationsVerEN.PdfDivLet = objRow[conzx_SocialRelationsVer.PdfDivLet] == DBNull.Value ? null : objRow[conzx_SocialRelationsVer.PdfDivLet].ToString().Trim(); //PdfDivLet
objzx_SocialRelationsVerEN.PdfDivTop = objRow[conzx_SocialRelationsVer.PdfDivTop] == DBNull.Value ? null : objRow[conzx_SocialRelationsVer.PdfDivTop].ToString().Trim(); //PdfDivTop
objzx_SocialRelationsVerEN.PdfPageNumIn = objRow[conzx_SocialRelationsVer.PdfPageNumIn] == DBNull.Value ? null : objRow[conzx_SocialRelationsVer.PdfPageNumIn].ToString().Trim(); //PdfPageNumIn
objzx_SocialRelationsVerEN.PdfPageTop = objRow[conzx_SocialRelationsVer.PdfPageTop] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_SocialRelationsVer.PdfPageTop].ToString().Trim()); //pdf页面顶部位置
objzx_SocialRelationsVerEN.PdfZoom = objRow[conzx_SocialRelationsVer.PdfZoom] == DBNull.Value ? null : objRow[conzx_SocialRelationsVer.PdfZoom].ToString().Trim(); //PdfZoom
objzx_SocialRelationsVerEN.GroupTextId = objRow[conzx_SocialRelationsVer.GroupTextId] == DBNull.Value ? null : objRow[conzx_SocialRelationsVer.GroupTextId].ToString().Trim(); //小组Id
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objzx_SocialRelationsVerEN.SocialVId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objzx_SocialRelationsVerEN);
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
public static List<clszx_SocialRelationsVerEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clszx_SocialRelationsVerEN> arrObjLst = new List<clszx_SocialRelationsVerEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clszx_SocialRelationsVerEN objzx_SocialRelationsVerEN = new clszx_SocialRelationsVerEN();
try
{
objzx_SocialRelationsVerEN.SocialVId = Int32.Parse(objRow[conzx_SocialRelationsVer.SocialVId].ToString().Trim()); //SocialVId
objzx_SocialRelationsVerEN.zxSocialId = objRow[conzx_SocialRelationsVer.zxSocialId].ToString().Trim(); //社会Id
objzx_SocialRelationsVerEN.FullName = objRow[conzx_SocialRelationsVer.FullName] == DBNull.Value ? null : objRow[conzx_SocialRelationsVer.FullName].ToString().Trim(); //姓名
objzx_SocialRelationsVerEN.Nationality = objRow[conzx_SocialRelationsVer.Nationality] == DBNull.Value ? null : objRow[conzx_SocialRelationsVer.Nationality].ToString().Trim(); //国籍
objzx_SocialRelationsVerEN.WorkUnit = objRow[conzx_SocialRelationsVer.WorkUnit] == DBNull.Value ? null : objRow[conzx_SocialRelationsVer.WorkUnit].ToString().Trim(); //工作单位
objzx_SocialRelationsVerEN.Major = objRow[conzx_SocialRelationsVer.Major] == DBNull.Value ? null : objRow[conzx_SocialRelationsVer.Major].ToString().Trim(); //专业
objzx_SocialRelationsVerEN.Achievement = objRow[conzx_SocialRelationsVer.Achievement] == DBNull.Value ? null : objRow[conzx_SocialRelationsVer.Achievement].ToString().Trim(); //成就
objzx_SocialRelationsVerEN.DetailedDescription = objRow[conzx_SocialRelationsVer.DetailedDescription] == DBNull.Value ? null : objRow[conzx_SocialRelationsVer.DetailedDescription].ToString().Trim(); //详细说明
objzx_SocialRelationsVerEN.zxLevelId = objRow[conzx_SocialRelationsVer.zxLevelId] == DBNull.Value ? null : objRow[conzx_SocialRelationsVer.zxLevelId].ToString().Trim(); //级别Id
objzx_SocialRelationsVerEN.UpdUser = objRow[conzx_SocialRelationsVer.UpdUser] == DBNull.Value ? null : objRow[conzx_SocialRelationsVer.UpdUser].ToString().Trim(); //修改人
objzx_SocialRelationsVerEN.CreateDate = objRow[conzx_SocialRelationsVer.CreateDate] == DBNull.Value ? null : objRow[conzx_SocialRelationsVer.CreateDate].ToString().Trim(); //建立日期
objzx_SocialRelationsVerEN.UpdDate = objRow[conzx_SocialRelationsVer.UpdDate] == DBNull.Value ? null : objRow[conzx_SocialRelationsVer.UpdDate].ToString().Trim(); //修改日期
objzx_SocialRelationsVerEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[conzx_SocialRelationsVer.IsSubmit].ToString().Trim()); //是否提交
objzx_SocialRelationsVerEN.VoteCount = objRow[conzx_SocialRelationsVer.VoteCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_SocialRelationsVer.VoteCount].ToString().Trim()); //点赞计数
objzx_SocialRelationsVerEN.CitationCount = objRow[conzx_SocialRelationsVer.CitationCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_SocialRelationsVer.CitationCount].ToString().Trim()); //引用统计
objzx_SocialRelationsVerEN.VersionCount = objRow[conzx_SocialRelationsVer.VersionCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_SocialRelationsVer.VersionCount].ToString().Trim()); //版本统计
objzx_SocialRelationsVerEN.IdCurrEduCls = objRow[conzx_SocialRelationsVer.IdCurrEduCls] == DBNull.Value ? null : objRow[conzx_SocialRelationsVer.IdCurrEduCls].ToString().Trim(); //教学班流水号
objzx_SocialRelationsVerEN.AppraiseCount = objRow[conzx_SocialRelationsVer.AppraiseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_SocialRelationsVer.AppraiseCount].ToString().Trim()); //评论数
objzx_SocialRelationsVerEN.Score = objRow[conzx_SocialRelationsVer.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conzx_SocialRelationsVer.Score].ToString().Trim()); //评分
objzx_SocialRelationsVerEN.StuScore = objRow[conzx_SocialRelationsVer.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conzx_SocialRelationsVer.StuScore].ToString().Trim()); //学生平均分
objzx_SocialRelationsVerEN.TeaScore = objRow[conzx_SocialRelationsVer.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conzx_SocialRelationsVer.TeaScore].ToString().Trim()); //教师评分
objzx_SocialRelationsVerEN.TextId = objRow[conzx_SocialRelationsVer.TextId] == DBNull.Value ? null : objRow[conzx_SocialRelationsVer.TextId].ToString().Trim(); //课件Id
objzx_SocialRelationsVerEN.zxShareId = objRow[conzx_SocialRelationsVer.zxShareId] == DBNull.Value ? null : objRow[conzx_SocialRelationsVer.zxShareId].ToString().Trim(); //分享Id
objzx_SocialRelationsVerEN.PdfContent = objRow[conzx_SocialRelationsVer.PdfContent] == DBNull.Value ? null : objRow[conzx_SocialRelationsVer.PdfContent].ToString().Trim(); //Pdf内容
objzx_SocialRelationsVerEN.PdfPageNum = objRow[conzx_SocialRelationsVer.PdfPageNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_SocialRelationsVer.PdfPageNum].ToString().Trim()); //Pdf页码
objzx_SocialRelationsVerEN.Memo = objRow[conzx_SocialRelationsVer.Memo] == DBNull.Value ? null : objRow[conzx_SocialRelationsVer.Memo].ToString().Trim(); //备注
objzx_SocialRelationsVerEN.PdfDivLet = objRow[conzx_SocialRelationsVer.PdfDivLet] == DBNull.Value ? null : objRow[conzx_SocialRelationsVer.PdfDivLet].ToString().Trim(); //PdfDivLet
objzx_SocialRelationsVerEN.PdfDivTop = objRow[conzx_SocialRelationsVer.PdfDivTop] == DBNull.Value ? null : objRow[conzx_SocialRelationsVer.PdfDivTop].ToString().Trim(); //PdfDivTop
objzx_SocialRelationsVerEN.PdfPageNumIn = objRow[conzx_SocialRelationsVer.PdfPageNumIn] == DBNull.Value ? null : objRow[conzx_SocialRelationsVer.PdfPageNumIn].ToString().Trim(); //PdfPageNumIn
objzx_SocialRelationsVerEN.PdfPageTop = objRow[conzx_SocialRelationsVer.PdfPageTop] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_SocialRelationsVer.PdfPageTop].ToString().Trim()); //pdf页面顶部位置
objzx_SocialRelationsVerEN.PdfZoom = objRow[conzx_SocialRelationsVer.PdfZoom] == DBNull.Value ? null : objRow[conzx_SocialRelationsVer.PdfZoom].ToString().Trim(); //PdfZoom
objzx_SocialRelationsVerEN.GroupTextId = objRow[conzx_SocialRelationsVer.GroupTextId] == DBNull.Value ? null : objRow[conzx_SocialRelationsVer.GroupTextId].ToString().Trim(); //小组Id
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objzx_SocialRelationsVerEN.SocialVId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objzx_SocialRelationsVerEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objzx_SocialRelationsVerCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clszx_SocialRelationsVerEN> GetSubObjLstCache(clszx_SocialRelationsVerEN objzx_SocialRelationsVerCond)
{
List<clszx_SocialRelationsVerEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clszx_SocialRelationsVerEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conzx_SocialRelationsVer.AttributeName)
{
if (objzx_SocialRelationsVerCond.IsUpdated(strFldName) == false) continue;
if (objzx_SocialRelationsVerCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objzx_SocialRelationsVerCond[strFldName].ToString());
}
else
{
if (objzx_SocialRelationsVerCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objzx_SocialRelationsVerCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objzx_SocialRelationsVerCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objzx_SocialRelationsVerCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objzx_SocialRelationsVerCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objzx_SocialRelationsVerCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objzx_SocialRelationsVerCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objzx_SocialRelationsVerCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objzx_SocialRelationsVerCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objzx_SocialRelationsVerCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objzx_SocialRelationsVerCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objzx_SocialRelationsVerCond[strFldName]));
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
public static List<clszx_SocialRelationsVerEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clszx_SocialRelationsVerEN> arrObjLst = new List<clszx_SocialRelationsVerEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clszx_SocialRelationsVerEN objzx_SocialRelationsVerEN = new clszx_SocialRelationsVerEN();
try
{
objzx_SocialRelationsVerEN.SocialVId = Int32.Parse(objRow[conzx_SocialRelationsVer.SocialVId].ToString().Trim()); //SocialVId
objzx_SocialRelationsVerEN.zxSocialId = objRow[conzx_SocialRelationsVer.zxSocialId].ToString().Trim(); //社会Id
objzx_SocialRelationsVerEN.FullName = objRow[conzx_SocialRelationsVer.FullName] == DBNull.Value ? null : objRow[conzx_SocialRelationsVer.FullName].ToString().Trim(); //姓名
objzx_SocialRelationsVerEN.Nationality = objRow[conzx_SocialRelationsVer.Nationality] == DBNull.Value ? null : objRow[conzx_SocialRelationsVer.Nationality].ToString().Trim(); //国籍
objzx_SocialRelationsVerEN.WorkUnit = objRow[conzx_SocialRelationsVer.WorkUnit] == DBNull.Value ? null : objRow[conzx_SocialRelationsVer.WorkUnit].ToString().Trim(); //工作单位
objzx_SocialRelationsVerEN.Major = objRow[conzx_SocialRelationsVer.Major] == DBNull.Value ? null : objRow[conzx_SocialRelationsVer.Major].ToString().Trim(); //专业
objzx_SocialRelationsVerEN.Achievement = objRow[conzx_SocialRelationsVer.Achievement] == DBNull.Value ? null : objRow[conzx_SocialRelationsVer.Achievement].ToString().Trim(); //成就
objzx_SocialRelationsVerEN.DetailedDescription = objRow[conzx_SocialRelationsVer.DetailedDescription] == DBNull.Value ? null : objRow[conzx_SocialRelationsVer.DetailedDescription].ToString().Trim(); //详细说明
objzx_SocialRelationsVerEN.zxLevelId = objRow[conzx_SocialRelationsVer.zxLevelId] == DBNull.Value ? null : objRow[conzx_SocialRelationsVer.zxLevelId].ToString().Trim(); //级别Id
objzx_SocialRelationsVerEN.UpdUser = objRow[conzx_SocialRelationsVer.UpdUser] == DBNull.Value ? null : objRow[conzx_SocialRelationsVer.UpdUser].ToString().Trim(); //修改人
objzx_SocialRelationsVerEN.CreateDate = objRow[conzx_SocialRelationsVer.CreateDate] == DBNull.Value ? null : objRow[conzx_SocialRelationsVer.CreateDate].ToString().Trim(); //建立日期
objzx_SocialRelationsVerEN.UpdDate = objRow[conzx_SocialRelationsVer.UpdDate] == DBNull.Value ? null : objRow[conzx_SocialRelationsVer.UpdDate].ToString().Trim(); //修改日期
objzx_SocialRelationsVerEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[conzx_SocialRelationsVer.IsSubmit].ToString().Trim()); //是否提交
objzx_SocialRelationsVerEN.VoteCount = objRow[conzx_SocialRelationsVer.VoteCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_SocialRelationsVer.VoteCount].ToString().Trim()); //点赞计数
objzx_SocialRelationsVerEN.CitationCount = objRow[conzx_SocialRelationsVer.CitationCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_SocialRelationsVer.CitationCount].ToString().Trim()); //引用统计
objzx_SocialRelationsVerEN.VersionCount = objRow[conzx_SocialRelationsVer.VersionCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_SocialRelationsVer.VersionCount].ToString().Trim()); //版本统计
objzx_SocialRelationsVerEN.IdCurrEduCls = objRow[conzx_SocialRelationsVer.IdCurrEduCls] == DBNull.Value ? null : objRow[conzx_SocialRelationsVer.IdCurrEduCls].ToString().Trim(); //教学班流水号
objzx_SocialRelationsVerEN.AppraiseCount = objRow[conzx_SocialRelationsVer.AppraiseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_SocialRelationsVer.AppraiseCount].ToString().Trim()); //评论数
objzx_SocialRelationsVerEN.Score = objRow[conzx_SocialRelationsVer.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conzx_SocialRelationsVer.Score].ToString().Trim()); //评分
objzx_SocialRelationsVerEN.StuScore = objRow[conzx_SocialRelationsVer.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conzx_SocialRelationsVer.StuScore].ToString().Trim()); //学生平均分
objzx_SocialRelationsVerEN.TeaScore = objRow[conzx_SocialRelationsVer.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conzx_SocialRelationsVer.TeaScore].ToString().Trim()); //教师评分
objzx_SocialRelationsVerEN.TextId = objRow[conzx_SocialRelationsVer.TextId] == DBNull.Value ? null : objRow[conzx_SocialRelationsVer.TextId].ToString().Trim(); //课件Id
objzx_SocialRelationsVerEN.zxShareId = objRow[conzx_SocialRelationsVer.zxShareId] == DBNull.Value ? null : objRow[conzx_SocialRelationsVer.zxShareId].ToString().Trim(); //分享Id
objzx_SocialRelationsVerEN.PdfContent = objRow[conzx_SocialRelationsVer.PdfContent] == DBNull.Value ? null : objRow[conzx_SocialRelationsVer.PdfContent].ToString().Trim(); //Pdf内容
objzx_SocialRelationsVerEN.PdfPageNum = objRow[conzx_SocialRelationsVer.PdfPageNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_SocialRelationsVer.PdfPageNum].ToString().Trim()); //Pdf页码
objzx_SocialRelationsVerEN.Memo = objRow[conzx_SocialRelationsVer.Memo] == DBNull.Value ? null : objRow[conzx_SocialRelationsVer.Memo].ToString().Trim(); //备注
objzx_SocialRelationsVerEN.PdfDivLet = objRow[conzx_SocialRelationsVer.PdfDivLet] == DBNull.Value ? null : objRow[conzx_SocialRelationsVer.PdfDivLet].ToString().Trim(); //PdfDivLet
objzx_SocialRelationsVerEN.PdfDivTop = objRow[conzx_SocialRelationsVer.PdfDivTop] == DBNull.Value ? null : objRow[conzx_SocialRelationsVer.PdfDivTop].ToString().Trim(); //PdfDivTop
objzx_SocialRelationsVerEN.PdfPageNumIn = objRow[conzx_SocialRelationsVer.PdfPageNumIn] == DBNull.Value ? null : objRow[conzx_SocialRelationsVer.PdfPageNumIn].ToString().Trim(); //PdfPageNumIn
objzx_SocialRelationsVerEN.PdfPageTop = objRow[conzx_SocialRelationsVer.PdfPageTop] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_SocialRelationsVer.PdfPageTop].ToString().Trim()); //pdf页面顶部位置
objzx_SocialRelationsVerEN.PdfZoom = objRow[conzx_SocialRelationsVer.PdfZoom] == DBNull.Value ? null : objRow[conzx_SocialRelationsVer.PdfZoom].ToString().Trim(); //PdfZoom
objzx_SocialRelationsVerEN.GroupTextId = objRow[conzx_SocialRelationsVer.GroupTextId] == DBNull.Value ? null : objRow[conzx_SocialRelationsVer.GroupTextId].ToString().Trim(); //小组Id
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objzx_SocialRelationsVerEN.SocialVId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objzx_SocialRelationsVerEN);
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
public static List<clszx_SocialRelationsVerEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clszx_SocialRelationsVerEN> arrObjLst = new List<clszx_SocialRelationsVerEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clszx_SocialRelationsVerEN objzx_SocialRelationsVerEN = new clszx_SocialRelationsVerEN();
try
{
objzx_SocialRelationsVerEN.SocialVId = Int32.Parse(objRow[conzx_SocialRelationsVer.SocialVId].ToString().Trim()); //SocialVId
objzx_SocialRelationsVerEN.zxSocialId = objRow[conzx_SocialRelationsVer.zxSocialId].ToString().Trim(); //社会Id
objzx_SocialRelationsVerEN.FullName = objRow[conzx_SocialRelationsVer.FullName] == DBNull.Value ? null : objRow[conzx_SocialRelationsVer.FullName].ToString().Trim(); //姓名
objzx_SocialRelationsVerEN.Nationality = objRow[conzx_SocialRelationsVer.Nationality] == DBNull.Value ? null : objRow[conzx_SocialRelationsVer.Nationality].ToString().Trim(); //国籍
objzx_SocialRelationsVerEN.WorkUnit = objRow[conzx_SocialRelationsVer.WorkUnit] == DBNull.Value ? null : objRow[conzx_SocialRelationsVer.WorkUnit].ToString().Trim(); //工作单位
objzx_SocialRelationsVerEN.Major = objRow[conzx_SocialRelationsVer.Major] == DBNull.Value ? null : objRow[conzx_SocialRelationsVer.Major].ToString().Trim(); //专业
objzx_SocialRelationsVerEN.Achievement = objRow[conzx_SocialRelationsVer.Achievement] == DBNull.Value ? null : objRow[conzx_SocialRelationsVer.Achievement].ToString().Trim(); //成就
objzx_SocialRelationsVerEN.DetailedDescription = objRow[conzx_SocialRelationsVer.DetailedDescription] == DBNull.Value ? null : objRow[conzx_SocialRelationsVer.DetailedDescription].ToString().Trim(); //详细说明
objzx_SocialRelationsVerEN.zxLevelId = objRow[conzx_SocialRelationsVer.zxLevelId] == DBNull.Value ? null : objRow[conzx_SocialRelationsVer.zxLevelId].ToString().Trim(); //级别Id
objzx_SocialRelationsVerEN.UpdUser = objRow[conzx_SocialRelationsVer.UpdUser] == DBNull.Value ? null : objRow[conzx_SocialRelationsVer.UpdUser].ToString().Trim(); //修改人
objzx_SocialRelationsVerEN.CreateDate = objRow[conzx_SocialRelationsVer.CreateDate] == DBNull.Value ? null : objRow[conzx_SocialRelationsVer.CreateDate].ToString().Trim(); //建立日期
objzx_SocialRelationsVerEN.UpdDate = objRow[conzx_SocialRelationsVer.UpdDate] == DBNull.Value ? null : objRow[conzx_SocialRelationsVer.UpdDate].ToString().Trim(); //修改日期
objzx_SocialRelationsVerEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[conzx_SocialRelationsVer.IsSubmit].ToString().Trim()); //是否提交
objzx_SocialRelationsVerEN.VoteCount = objRow[conzx_SocialRelationsVer.VoteCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_SocialRelationsVer.VoteCount].ToString().Trim()); //点赞计数
objzx_SocialRelationsVerEN.CitationCount = objRow[conzx_SocialRelationsVer.CitationCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_SocialRelationsVer.CitationCount].ToString().Trim()); //引用统计
objzx_SocialRelationsVerEN.VersionCount = objRow[conzx_SocialRelationsVer.VersionCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_SocialRelationsVer.VersionCount].ToString().Trim()); //版本统计
objzx_SocialRelationsVerEN.IdCurrEduCls = objRow[conzx_SocialRelationsVer.IdCurrEduCls] == DBNull.Value ? null : objRow[conzx_SocialRelationsVer.IdCurrEduCls].ToString().Trim(); //教学班流水号
objzx_SocialRelationsVerEN.AppraiseCount = objRow[conzx_SocialRelationsVer.AppraiseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_SocialRelationsVer.AppraiseCount].ToString().Trim()); //评论数
objzx_SocialRelationsVerEN.Score = objRow[conzx_SocialRelationsVer.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conzx_SocialRelationsVer.Score].ToString().Trim()); //评分
objzx_SocialRelationsVerEN.StuScore = objRow[conzx_SocialRelationsVer.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conzx_SocialRelationsVer.StuScore].ToString().Trim()); //学生平均分
objzx_SocialRelationsVerEN.TeaScore = objRow[conzx_SocialRelationsVer.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conzx_SocialRelationsVer.TeaScore].ToString().Trim()); //教师评分
objzx_SocialRelationsVerEN.TextId = objRow[conzx_SocialRelationsVer.TextId] == DBNull.Value ? null : objRow[conzx_SocialRelationsVer.TextId].ToString().Trim(); //课件Id
objzx_SocialRelationsVerEN.zxShareId = objRow[conzx_SocialRelationsVer.zxShareId] == DBNull.Value ? null : objRow[conzx_SocialRelationsVer.zxShareId].ToString().Trim(); //分享Id
objzx_SocialRelationsVerEN.PdfContent = objRow[conzx_SocialRelationsVer.PdfContent] == DBNull.Value ? null : objRow[conzx_SocialRelationsVer.PdfContent].ToString().Trim(); //Pdf内容
objzx_SocialRelationsVerEN.PdfPageNum = objRow[conzx_SocialRelationsVer.PdfPageNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_SocialRelationsVer.PdfPageNum].ToString().Trim()); //Pdf页码
objzx_SocialRelationsVerEN.Memo = objRow[conzx_SocialRelationsVer.Memo] == DBNull.Value ? null : objRow[conzx_SocialRelationsVer.Memo].ToString().Trim(); //备注
objzx_SocialRelationsVerEN.PdfDivLet = objRow[conzx_SocialRelationsVer.PdfDivLet] == DBNull.Value ? null : objRow[conzx_SocialRelationsVer.PdfDivLet].ToString().Trim(); //PdfDivLet
objzx_SocialRelationsVerEN.PdfDivTop = objRow[conzx_SocialRelationsVer.PdfDivTop] == DBNull.Value ? null : objRow[conzx_SocialRelationsVer.PdfDivTop].ToString().Trim(); //PdfDivTop
objzx_SocialRelationsVerEN.PdfPageNumIn = objRow[conzx_SocialRelationsVer.PdfPageNumIn] == DBNull.Value ? null : objRow[conzx_SocialRelationsVer.PdfPageNumIn].ToString().Trim(); //PdfPageNumIn
objzx_SocialRelationsVerEN.PdfPageTop = objRow[conzx_SocialRelationsVer.PdfPageTop] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_SocialRelationsVer.PdfPageTop].ToString().Trim()); //pdf页面顶部位置
objzx_SocialRelationsVerEN.PdfZoom = objRow[conzx_SocialRelationsVer.PdfZoom] == DBNull.Value ? null : objRow[conzx_SocialRelationsVer.PdfZoom].ToString().Trim(); //PdfZoom
objzx_SocialRelationsVerEN.GroupTextId = objRow[conzx_SocialRelationsVer.GroupTextId] == DBNull.Value ? null : objRow[conzx_SocialRelationsVer.GroupTextId].ToString().Trim(); //小组Id
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objzx_SocialRelationsVerEN.SocialVId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objzx_SocialRelationsVerEN);
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
List<clszx_SocialRelationsVerEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clszx_SocialRelationsVerEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clszx_SocialRelationsVerEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clszx_SocialRelationsVerEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clszx_SocialRelationsVerEN> arrObjLst = new List<clszx_SocialRelationsVerEN>(); 
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
	clszx_SocialRelationsVerEN objzx_SocialRelationsVerEN = new clszx_SocialRelationsVerEN();
try
{
objzx_SocialRelationsVerEN.SocialVId = Int32.Parse(objRow[conzx_SocialRelationsVer.SocialVId].ToString().Trim()); //SocialVId
objzx_SocialRelationsVerEN.zxSocialId = objRow[conzx_SocialRelationsVer.zxSocialId].ToString().Trim(); //社会Id
objzx_SocialRelationsVerEN.FullName = objRow[conzx_SocialRelationsVer.FullName] == DBNull.Value ? null : objRow[conzx_SocialRelationsVer.FullName].ToString().Trim(); //姓名
objzx_SocialRelationsVerEN.Nationality = objRow[conzx_SocialRelationsVer.Nationality] == DBNull.Value ? null : objRow[conzx_SocialRelationsVer.Nationality].ToString().Trim(); //国籍
objzx_SocialRelationsVerEN.WorkUnit = objRow[conzx_SocialRelationsVer.WorkUnit] == DBNull.Value ? null : objRow[conzx_SocialRelationsVer.WorkUnit].ToString().Trim(); //工作单位
objzx_SocialRelationsVerEN.Major = objRow[conzx_SocialRelationsVer.Major] == DBNull.Value ? null : objRow[conzx_SocialRelationsVer.Major].ToString().Trim(); //专业
objzx_SocialRelationsVerEN.Achievement = objRow[conzx_SocialRelationsVer.Achievement] == DBNull.Value ? null : objRow[conzx_SocialRelationsVer.Achievement].ToString().Trim(); //成就
objzx_SocialRelationsVerEN.DetailedDescription = objRow[conzx_SocialRelationsVer.DetailedDescription] == DBNull.Value ? null : objRow[conzx_SocialRelationsVer.DetailedDescription].ToString().Trim(); //详细说明
objzx_SocialRelationsVerEN.zxLevelId = objRow[conzx_SocialRelationsVer.zxLevelId] == DBNull.Value ? null : objRow[conzx_SocialRelationsVer.zxLevelId].ToString().Trim(); //级别Id
objzx_SocialRelationsVerEN.UpdUser = objRow[conzx_SocialRelationsVer.UpdUser] == DBNull.Value ? null : objRow[conzx_SocialRelationsVer.UpdUser].ToString().Trim(); //修改人
objzx_SocialRelationsVerEN.CreateDate = objRow[conzx_SocialRelationsVer.CreateDate] == DBNull.Value ? null : objRow[conzx_SocialRelationsVer.CreateDate].ToString().Trim(); //建立日期
objzx_SocialRelationsVerEN.UpdDate = objRow[conzx_SocialRelationsVer.UpdDate] == DBNull.Value ? null : objRow[conzx_SocialRelationsVer.UpdDate].ToString().Trim(); //修改日期
objzx_SocialRelationsVerEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[conzx_SocialRelationsVer.IsSubmit].ToString().Trim()); //是否提交
objzx_SocialRelationsVerEN.VoteCount = objRow[conzx_SocialRelationsVer.VoteCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_SocialRelationsVer.VoteCount].ToString().Trim()); //点赞计数
objzx_SocialRelationsVerEN.CitationCount = objRow[conzx_SocialRelationsVer.CitationCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_SocialRelationsVer.CitationCount].ToString().Trim()); //引用统计
objzx_SocialRelationsVerEN.VersionCount = objRow[conzx_SocialRelationsVer.VersionCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_SocialRelationsVer.VersionCount].ToString().Trim()); //版本统计
objzx_SocialRelationsVerEN.IdCurrEduCls = objRow[conzx_SocialRelationsVer.IdCurrEduCls] == DBNull.Value ? null : objRow[conzx_SocialRelationsVer.IdCurrEduCls].ToString().Trim(); //教学班流水号
objzx_SocialRelationsVerEN.AppraiseCount = objRow[conzx_SocialRelationsVer.AppraiseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_SocialRelationsVer.AppraiseCount].ToString().Trim()); //评论数
objzx_SocialRelationsVerEN.Score = objRow[conzx_SocialRelationsVer.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conzx_SocialRelationsVer.Score].ToString().Trim()); //评分
objzx_SocialRelationsVerEN.StuScore = objRow[conzx_SocialRelationsVer.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conzx_SocialRelationsVer.StuScore].ToString().Trim()); //学生平均分
objzx_SocialRelationsVerEN.TeaScore = objRow[conzx_SocialRelationsVer.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conzx_SocialRelationsVer.TeaScore].ToString().Trim()); //教师评分
objzx_SocialRelationsVerEN.TextId = objRow[conzx_SocialRelationsVer.TextId] == DBNull.Value ? null : objRow[conzx_SocialRelationsVer.TextId].ToString().Trim(); //课件Id
objzx_SocialRelationsVerEN.zxShareId = objRow[conzx_SocialRelationsVer.zxShareId] == DBNull.Value ? null : objRow[conzx_SocialRelationsVer.zxShareId].ToString().Trim(); //分享Id
objzx_SocialRelationsVerEN.PdfContent = objRow[conzx_SocialRelationsVer.PdfContent] == DBNull.Value ? null : objRow[conzx_SocialRelationsVer.PdfContent].ToString().Trim(); //Pdf内容
objzx_SocialRelationsVerEN.PdfPageNum = objRow[conzx_SocialRelationsVer.PdfPageNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_SocialRelationsVer.PdfPageNum].ToString().Trim()); //Pdf页码
objzx_SocialRelationsVerEN.Memo = objRow[conzx_SocialRelationsVer.Memo] == DBNull.Value ? null : objRow[conzx_SocialRelationsVer.Memo].ToString().Trim(); //备注
objzx_SocialRelationsVerEN.PdfDivLet = objRow[conzx_SocialRelationsVer.PdfDivLet] == DBNull.Value ? null : objRow[conzx_SocialRelationsVer.PdfDivLet].ToString().Trim(); //PdfDivLet
objzx_SocialRelationsVerEN.PdfDivTop = objRow[conzx_SocialRelationsVer.PdfDivTop] == DBNull.Value ? null : objRow[conzx_SocialRelationsVer.PdfDivTop].ToString().Trim(); //PdfDivTop
objzx_SocialRelationsVerEN.PdfPageNumIn = objRow[conzx_SocialRelationsVer.PdfPageNumIn] == DBNull.Value ? null : objRow[conzx_SocialRelationsVer.PdfPageNumIn].ToString().Trim(); //PdfPageNumIn
objzx_SocialRelationsVerEN.PdfPageTop = objRow[conzx_SocialRelationsVer.PdfPageTop] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_SocialRelationsVer.PdfPageTop].ToString().Trim()); //pdf页面顶部位置
objzx_SocialRelationsVerEN.PdfZoom = objRow[conzx_SocialRelationsVer.PdfZoom] == DBNull.Value ? null : objRow[conzx_SocialRelationsVer.PdfZoom].ToString().Trim(); //PdfZoom
objzx_SocialRelationsVerEN.GroupTextId = objRow[conzx_SocialRelationsVer.GroupTextId] == DBNull.Value ? null : objRow[conzx_SocialRelationsVer.GroupTextId].ToString().Trim(); //小组Id
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objzx_SocialRelationsVerEN.SocialVId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objzx_SocialRelationsVerEN);
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
public static List<clszx_SocialRelationsVerEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clszx_SocialRelationsVerEN> arrObjLst = new List<clszx_SocialRelationsVerEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clszx_SocialRelationsVerEN objzx_SocialRelationsVerEN = new clszx_SocialRelationsVerEN();
try
{
objzx_SocialRelationsVerEN.SocialVId = Int32.Parse(objRow[conzx_SocialRelationsVer.SocialVId].ToString().Trim()); //SocialVId
objzx_SocialRelationsVerEN.zxSocialId = objRow[conzx_SocialRelationsVer.zxSocialId].ToString().Trim(); //社会Id
objzx_SocialRelationsVerEN.FullName = objRow[conzx_SocialRelationsVer.FullName] == DBNull.Value ? null : objRow[conzx_SocialRelationsVer.FullName].ToString().Trim(); //姓名
objzx_SocialRelationsVerEN.Nationality = objRow[conzx_SocialRelationsVer.Nationality] == DBNull.Value ? null : objRow[conzx_SocialRelationsVer.Nationality].ToString().Trim(); //国籍
objzx_SocialRelationsVerEN.WorkUnit = objRow[conzx_SocialRelationsVer.WorkUnit] == DBNull.Value ? null : objRow[conzx_SocialRelationsVer.WorkUnit].ToString().Trim(); //工作单位
objzx_SocialRelationsVerEN.Major = objRow[conzx_SocialRelationsVer.Major] == DBNull.Value ? null : objRow[conzx_SocialRelationsVer.Major].ToString().Trim(); //专业
objzx_SocialRelationsVerEN.Achievement = objRow[conzx_SocialRelationsVer.Achievement] == DBNull.Value ? null : objRow[conzx_SocialRelationsVer.Achievement].ToString().Trim(); //成就
objzx_SocialRelationsVerEN.DetailedDescription = objRow[conzx_SocialRelationsVer.DetailedDescription] == DBNull.Value ? null : objRow[conzx_SocialRelationsVer.DetailedDescription].ToString().Trim(); //详细说明
objzx_SocialRelationsVerEN.zxLevelId = objRow[conzx_SocialRelationsVer.zxLevelId] == DBNull.Value ? null : objRow[conzx_SocialRelationsVer.zxLevelId].ToString().Trim(); //级别Id
objzx_SocialRelationsVerEN.UpdUser = objRow[conzx_SocialRelationsVer.UpdUser] == DBNull.Value ? null : objRow[conzx_SocialRelationsVer.UpdUser].ToString().Trim(); //修改人
objzx_SocialRelationsVerEN.CreateDate = objRow[conzx_SocialRelationsVer.CreateDate] == DBNull.Value ? null : objRow[conzx_SocialRelationsVer.CreateDate].ToString().Trim(); //建立日期
objzx_SocialRelationsVerEN.UpdDate = objRow[conzx_SocialRelationsVer.UpdDate] == DBNull.Value ? null : objRow[conzx_SocialRelationsVer.UpdDate].ToString().Trim(); //修改日期
objzx_SocialRelationsVerEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[conzx_SocialRelationsVer.IsSubmit].ToString().Trim()); //是否提交
objzx_SocialRelationsVerEN.VoteCount = objRow[conzx_SocialRelationsVer.VoteCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_SocialRelationsVer.VoteCount].ToString().Trim()); //点赞计数
objzx_SocialRelationsVerEN.CitationCount = objRow[conzx_SocialRelationsVer.CitationCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_SocialRelationsVer.CitationCount].ToString().Trim()); //引用统计
objzx_SocialRelationsVerEN.VersionCount = objRow[conzx_SocialRelationsVer.VersionCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_SocialRelationsVer.VersionCount].ToString().Trim()); //版本统计
objzx_SocialRelationsVerEN.IdCurrEduCls = objRow[conzx_SocialRelationsVer.IdCurrEduCls] == DBNull.Value ? null : objRow[conzx_SocialRelationsVer.IdCurrEduCls].ToString().Trim(); //教学班流水号
objzx_SocialRelationsVerEN.AppraiseCount = objRow[conzx_SocialRelationsVer.AppraiseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_SocialRelationsVer.AppraiseCount].ToString().Trim()); //评论数
objzx_SocialRelationsVerEN.Score = objRow[conzx_SocialRelationsVer.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conzx_SocialRelationsVer.Score].ToString().Trim()); //评分
objzx_SocialRelationsVerEN.StuScore = objRow[conzx_SocialRelationsVer.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conzx_SocialRelationsVer.StuScore].ToString().Trim()); //学生平均分
objzx_SocialRelationsVerEN.TeaScore = objRow[conzx_SocialRelationsVer.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conzx_SocialRelationsVer.TeaScore].ToString().Trim()); //教师评分
objzx_SocialRelationsVerEN.TextId = objRow[conzx_SocialRelationsVer.TextId] == DBNull.Value ? null : objRow[conzx_SocialRelationsVer.TextId].ToString().Trim(); //课件Id
objzx_SocialRelationsVerEN.zxShareId = objRow[conzx_SocialRelationsVer.zxShareId] == DBNull.Value ? null : objRow[conzx_SocialRelationsVer.zxShareId].ToString().Trim(); //分享Id
objzx_SocialRelationsVerEN.PdfContent = objRow[conzx_SocialRelationsVer.PdfContent] == DBNull.Value ? null : objRow[conzx_SocialRelationsVer.PdfContent].ToString().Trim(); //Pdf内容
objzx_SocialRelationsVerEN.PdfPageNum = objRow[conzx_SocialRelationsVer.PdfPageNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_SocialRelationsVer.PdfPageNum].ToString().Trim()); //Pdf页码
objzx_SocialRelationsVerEN.Memo = objRow[conzx_SocialRelationsVer.Memo] == DBNull.Value ? null : objRow[conzx_SocialRelationsVer.Memo].ToString().Trim(); //备注
objzx_SocialRelationsVerEN.PdfDivLet = objRow[conzx_SocialRelationsVer.PdfDivLet] == DBNull.Value ? null : objRow[conzx_SocialRelationsVer.PdfDivLet].ToString().Trim(); //PdfDivLet
objzx_SocialRelationsVerEN.PdfDivTop = objRow[conzx_SocialRelationsVer.PdfDivTop] == DBNull.Value ? null : objRow[conzx_SocialRelationsVer.PdfDivTop].ToString().Trim(); //PdfDivTop
objzx_SocialRelationsVerEN.PdfPageNumIn = objRow[conzx_SocialRelationsVer.PdfPageNumIn] == DBNull.Value ? null : objRow[conzx_SocialRelationsVer.PdfPageNumIn].ToString().Trim(); //PdfPageNumIn
objzx_SocialRelationsVerEN.PdfPageTop = objRow[conzx_SocialRelationsVer.PdfPageTop] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_SocialRelationsVer.PdfPageTop].ToString().Trim()); //pdf页面顶部位置
objzx_SocialRelationsVerEN.PdfZoom = objRow[conzx_SocialRelationsVer.PdfZoom] == DBNull.Value ? null : objRow[conzx_SocialRelationsVer.PdfZoom].ToString().Trim(); //PdfZoom
objzx_SocialRelationsVerEN.GroupTextId = objRow[conzx_SocialRelationsVer.GroupTextId] == DBNull.Value ? null : objRow[conzx_SocialRelationsVer.GroupTextId].ToString().Trim(); //小组Id
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objzx_SocialRelationsVerEN.SocialVId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objzx_SocialRelationsVerEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clszx_SocialRelationsVerEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clszx_SocialRelationsVerEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clszx_SocialRelationsVerEN> arrObjLst = new List<clszx_SocialRelationsVerEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clszx_SocialRelationsVerEN objzx_SocialRelationsVerEN = new clszx_SocialRelationsVerEN();
try
{
objzx_SocialRelationsVerEN.SocialVId = Int32.Parse(objRow[conzx_SocialRelationsVer.SocialVId].ToString().Trim()); //SocialVId
objzx_SocialRelationsVerEN.zxSocialId = objRow[conzx_SocialRelationsVer.zxSocialId].ToString().Trim(); //社会Id
objzx_SocialRelationsVerEN.FullName = objRow[conzx_SocialRelationsVer.FullName] == DBNull.Value ? null : objRow[conzx_SocialRelationsVer.FullName].ToString().Trim(); //姓名
objzx_SocialRelationsVerEN.Nationality = objRow[conzx_SocialRelationsVer.Nationality] == DBNull.Value ? null : objRow[conzx_SocialRelationsVer.Nationality].ToString().Trim(); //国籍
objzx_SocialRelationsVerEN.WorkUnit = objRow[conzx_SocialRelationsVer.WorkUnit] == DBNull.Value ? null : objRow[conzx_SocialRelationsVer.WorkUnit].ToString().Trim(); //工作单位
objzx_SocialRelationsVerEN.Major = objRow[conzx_SocialRelationsVer.Major] == DBNull.Value ? null : objRow[conzx_SocialRelationsVer.Major].ToString().Trim(); //专业
objzx_SocialRelationsVerEN.Achievement = objRow[conzx_SocialRelationsVer.Achievement] == DBNull.Value ? null : objRow[conzx_SocialRelationsVer.Achievement].ToString().Trim(); //成就
objzx_SocialRelationsVerEN.DetailedDescription = objRow[conzx_SocialRelationsVer.DetailedDescription] == DBNull.Value ? null : objRow[conzx_SocialRelationsVer.DetailedDescription].ToString().Trim(); //详细说明
objzx_SocialRelationsVerEN.zxLevelId = objRow[conzx_SocialRelationsVer.zxLevelId] == DBNull.Value ? null : objRow[conzx_SocialRelationsVer.zxLevelId].ToString().Trim(); //级别Id
objzx_SocialRelationsVerEN.UpdUser = objRow[conzx_SocialRelationsVer.UpdUser] == DBNull.Value ? null : objRow[conzx_SocialRelationsVer.UpdUser].ToString().Trim(); //修改人
objzx_SocialRelationsVerEN.CreateDate = objRow[conzx_SocialRelationsVer.CreateDate] == DBNull.Value ? null : objRow[conzx_SocialRelationsVer.CreateDate].ToString().Trim(); //建立日期
objzx_SocialRelationsVerEN.UpdDate = objRow[conzx_SocialRelationsVer.UpdDate] == DBNull.Value ? null : objRow[conzx_SocialRelationsVer.UpdDate].ToString().Trim(); //修改日期
objzx_SocialRelationsVerEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[conzx_SocialRelationsVer.IsSubmit].ToString().Trim()); //是否提交
objzx_SocialRelationsVerEN.VoteCount = objRow[conzx_SocialRelationsVer.VoteCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_SocialRelationsVer.VoteCount].ToString().Trim()); //点赞计数
objzx_SocialRelationsVerEN.CitationCount = objRow[conzx_SocialRelationsVer.CitationCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_SocialRelationsVer.CitationCount].ToString().Trim()); //引用统计
objzx_SocialRelationsVerEN.VersionCount = objRow[conzx_SocialRelationsVer.VersionCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_SocialRelationsVer.VersionCount].ToString().Trim()); //版本统计
objzx_SocialRelationsVerEN.IdCurrEduCls = objRow[conzx_SocialRelationsVer.IdCurrEduCls] == DBNull.Value ? null : objRow[conzx_SocialRelationsVer.IdCurrEduCls].ToString().Trim(); //教学班流水号
objzx_SocialRelationsVerEN.AppraiseCount = objRow[conzx_SocialRelationsVer.AppraiseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_SocialRelationsVer.AppraiseCount].ToString().Trim()); //评论数
objzx_SocialRelationsVerEN.Score = objRow[conzx_SocialRelationsVer.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conzx_SocialRelationsVer.Score].ToString().Trim()); //评分
objzx_SocialRelationsVerEN.StuScore = objRow[conzx_SocialRelationsVer.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conzx_SocialRelationsVer.StuScore].ToString().Trim()); //学生平均分
objzx_SocialRelationsVerEN.TeaScore = objRow[conzx_SocialRelationsVer.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conzx_SocialRelationsVer.TeaScore].ToString().Trim()); //教师评分
objzx_SocialRelationsVerEN.TextId = objRow[conzx_SocialRelationsVer.TextId] == DBNull.Value ? null : objRow[conzx_SocialRelationsVer.TextId].ToString().Trim(); //课件Id
objzx_SocialRelationsVerEN.zxShareId = objRow[conzx_SocialRelationsVer.zxShareId] == DBNull.Value ? null : objRow[conzx_SocialRelationsVer.zxShareId].ToString().Trim(); //分享Id
objzx_SocialRelationsVerEN.PdfContent = objRow[conzx_SocialRelationsVer.PdfContent] == DBNull.Value ? null : objRow[conzx_SocialRelationsVer.PdfContent].ToString().Trim(); //Pdf内容
objzx_SocialRelationsVerEN.PdfPageNum = objRow[conzx_SocialRelationsVer.PdfPageNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_SocialRelationsVer.PdfPageNum].ToString().Trim()); //Pdf页码
objzx_SocialRelationsVerEN.Memo = objRow[conzx_SocialRelationsVer.Memo] == DBNull.Value ? null : objRow[conzx_SocialRelationsVer.Memo].ToString().Trim(); //备注
objzx_SocialRelationsVerEN.PdfDivLet = objRow[conzx_SocialRelationsVer.PdfDivLet] == DBNull.Value ? null : objRow[conzx_SocialRelationsVer.PdfDivLet].ToString().Trim(); //PdfDivLet
objzx_SocialRelationsVerEN.PdfDivTop = objRow[conzx_SocialRelationsVer.PdfDivTop] == DBNull.Value ? null : objRow[conzx_SocialRelationsVer.PdfDivTop].ToString().Trim(); //PdfDivTop
objzx_SocialRelationsVerEN.PdfPageNumIn = objRow[conzx_SocialRelationsVer.PdfPageNumIn] == DBNull.Value ? null : objRow[conzx_SocialRelationsVer.PdfPageNumIn].ToString().Trim(); //PdfPageNumIn
objzx_SocialRelationsVerEN.PdfPageTop = objRow[conzx_SocialRelationsVer.PdfPageTop] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_SocialRelationsVer.PdfPageTop].ToString().Trim()); //pdf页面顶部位置
objzx_SocialRelationsVerEN.PdfZoom = objRow[conzx_SocialRelationsVer.PdfZoom] == DBNull.Value ? null : objRow[conzx_SocialRelationsVer.PdfZoom].ToString().Trim(); //PdfZoom
objzx_SocialRelationsVerEN.GroupTextId = objRow[conzx_SocialRelationsVer.GroupTextId] == DBNull.Value ? null : objRow[conzx_SocialRelationsVer.GroupTextId].ToString().Trim(); //小组Id
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objzx_SocialRelationsVerEN.SocialVId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objzx_SocialRelationsVerEN);
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
public static List<clszx_SocialRelationsVerEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clszx_SocialRelationsVerEN> arrObjLst = new List<clszx_SocialRelationsVerEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clszx_SocialRelationsVerEN objzx_SocialRelationsVerEN = new clszx_SocialRelationsVerEN();
try
{
objzx_SocialRelationsVerEN.SocialVId = Int32.Parse(objRow[conzx_SocialRelationsVer.SocialVId].ToString().Trim()); //SocialVId
objzx_SocialRelationsVerEN.zxSocialId = objRow[conzx_SocialRelationsVer.zxSocialId].ToString().Trim(); //社会Id
objzx_SocialRelationsVerEN.FullName = objRow[conzx_SocialRelationsVer.FullName] == DBNull.Value ? null : objRow[conzx_SocialRelationsVer.FullName].ToString().Trim(); //姓名
objzx_SocialRelationsVerEN.Nationality = objRow[conzx_SocialRelationsVer.Nationality] == DBNull.Value ? null : objRow[conzx_SocialRelationsVer.Nationality].ToString().Trim(); //国籍
objzx_SocialRelationsVerEN.WorkUnit = objRow[conzx_SocialRelationsVer.WorkUnit] == DBNull.Value ? null : objRow[conzx_SocialRelationsVer.WorkUnit].ToString().Trim(); //工作单位
objzx_SocialRelationsVerEN.Major = objRow[conzx_SocialRelationsVer.Major] == DBNull.Value ? null : objRow[conzx_SocialRelationsVer.Major].ToString().Trim(); //专业
objzx_SocialRelationsVerEN.Achievement = objRow[conzx_SocialRelationsVer.Achievement] == DBNull.Value ? null : objRow[conzx_SocialRelationsVer.Achievement].ToString().Trim(); //成就
objzx_SocialRelationsVerEN.DetailedDescription = objRow[conzx_SocialRelationsVer.DetailedDescription] == DBNull.Value ? null : objRow[conzx_SocialRelationsVer.DetailedDescription].ToString().Trim(); //详细说明
objzx_SocialRelationsVerEN.zxLevelId = objRow[conzx_SocialRelationsVer.zxLevelId] == DBNull.Value ? null : objRow[conzx_SocialRelationsVer.zxLevelId].ToString().Trim(); //级别Id
objzx_SocialRelationsVerEN.UpdUser = objRow[conzx_SocialRelationsVer.UpdUser] == DBNull.Value ? null : objRow[conzx_SocialRelationsVer.UpdUser].ToString().Trim(); //修改人
objzx_SocialRelationsVerEN.CreateDate = objRow[conzx_SocialRelationsVer.CreateDate] == DBNull.Value ? null : objRow[conzx_SocialRelationsVer.CreateDate].ToString().Trim(); //建立日期
objzx_SocialRelationsVerEN.UpdDate = objRow[conzx_SocialRelationsVer.UpdDate] == DBNull.Value ? null : objRow[conzx_SocialRelationsVer.UpdDate].ToString().Trim(); //修改日期
objzx_SocialRelationsVerEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[conzx_SocialRelationsVer.IsSubmit].ToString().Trim()); //是否提交
objzx_SocialRelationsVerEN.VoteCount = objRow[conzx_SocialRelationsVer.VoteCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_SocialRelationsVer.VoteCount].ToString().Trim()); //点赞计数
objzx_SocialRelationsVerEN.CitationCount = objRow[conzx_SocialRelationsVer.CitationCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_SocialRelationsVer.CitationCount].ToString().Trim()); //引用统计
objzx_SocialRelationsVerEN.VersionCount = objRow[conzx_SocialRelationsVer.VersionCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_SocialRelationsVer.VersionCount].ToString().Trim()); //版本统计
objzx_SocialRelationsVerEN.IdCurrEduCls = objRow[conzx_SocialRelationsVer.IdCurrEduCls] == DBNull.Value ? null : objRow[conzx_SocialRelationsVer.IdCurrEduCls].ToString().Trim(); //教学班流水号
objzx_SocialRelationsVerEN.AppraiseCount = objRow[conzx_SocialRelationsVer.AppraiseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_SocialRelationsVer.AppraiseCount].ToString().Trim()); //评论数
objzx_SocialRelationsVerEN.Score = objRow[conzx_SocialRelationsVer.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conzx_SocialRelationsVer.Score].ToString().Trim()); //评分
objzx_SocialRelationsVerEN.StuScore = objRow[conzx_SocialRelationsVer.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conzx_SocialRelationsVer.StuScore].ToString().Trim()); //学生平均分
objzx_SocialRelationsVerEN.TeaScore = objRow[conzx_SocialRelationsVer.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conzx_SocialRelationsVer.TeaScore].ToString().Trim()); //教师评分
objzx_SocialRelationsVerEN.TextId = objRow[conzx_SocialRelationsVer.TextId] == DBNull.Value ? null : objRow[conzx_SocialRelationsVer.TextId].ToString().Trim(); //课件Id
objzx_SocialRelationsVerEN.zxShareId = objRow[conzx_SocialRelationsVer.zxShareId] == DBNull.Value ? null : objRow[conzx_SocialRelationsVer.zxShareId].ToString().Trim(); //分享Id
objzx_SocialRelationsVerEN.PdfContent = objRow[conzx_SocialRelationsVer.PdfContent] == DBNull.Value ? null : objRow[conzx_SocialRelationsVer.PdfContent].ToString().Trim(); //Pdf内容
objzx_SocialRelationsVerEN.PdfPageNum = objRow[conzx_SocialRelationsVer.PdfPageNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_SocialRelationsVer.PdfPageNum].ToString().Trim()); //Pdf页码
objzx_SocialRelationsVerEN.Memo = objRow[conzx_SocialRelationsVer.Memo] == DBNull.Value ? null : objRow[conzx_SocialRelationsVer.Memo].ToString().Trim(); //备注
objzx_SocialRelationsVerEN.PdfDivLet = objRow[conzx_SocialRelationsVer.PdfDivLet] == DBNull.Value ? null : objRow[conzx_SocialRelationsVer.PdfDivLet].ToString().Trim(); //PdfDivLet
objzx_SocialRelationsVerEN.PdfDivTop = objRow[conzx_SocialRelationsVer.PdfDivTop] == DBNull.Value ? null : objRow[conzx_SocialRelationsVer.PdfDivTop].ToString().Trim(); //PdfDivTop
objzx_SocialRelationsVerEN.PdfPageNumIn = objRow[conzx_SocialRelationsVer.PdfPageNumIn] == DBNull.Value ? null : objRow[conzx_SocialRelationsVer.PdfPageNumIn].ToString().Trim(); //PdfPageNumIn
objzx_SocialRelationsVerEN.PdfPageTop = objRow[conzx_SocialRelationsVer.PdfPageTop] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_SocialRelationsVer.PdfPageTop].ToString().Trim()); //pdf页面顶部位置
objzx_SocialRelationsVerEN.PdfZoom = objRow[conzx_SocialRelationsVer.PdfZoom] == DBNull.Value ? null : objRow[conzx_SocialRelationsVer.PdfZoom].ToString().Trim(); //PdfZoom
objzx_SocialRelationsVerEN.GroupTextId = objRow[conzx_SocialRelationsVer.GroupTextId] == DBNull.Value ? null : objRow[conzx_SocialRelationsVer.GroupTextId].ToString().Trim(); //小组Id
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objzx_SocialRelationsVerEN.SocialVId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objzx_SocialRelationsVerEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clszx_SocialRelationsVerEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clszx_SocialRelationsVerEN> arrObjLst = new List<clszx_SocialRelationsVerEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clszx_SocialRelationsVerEN objzx_SocialRelationsVerEN = new clszx_SocialRelationsVerEN();
try
{
objzx_SocialRelationsVerEN.SocialVId = Int32.Parse(objRow[conzx_SocialRelationsVer.SocialVId].ToString().Trim()); //SocialVId
objzx_SocialRelationsVerEN.zxSocialId = objRow[conzx_SocialRelationsVer.zxSocialId].ToString().Trim(); //社会Id
objzx_SocialRelationsVerEN.FullName = objRow[conzx_SocialRelationsVer.FullName] == DBNull.Value ? null : objRow[conzx_SocialRelationsVer.FullName].ToString().Trim(); //姓名
objzx_SocialRelationsVerEN.Nationality = objRow[conzx_SocialRelationsVer.Nationality] == DBNull.Value ? null : objRow[conzx_SocialRelationsVer.Nationality].ToString().Trim(); //国籍
objzx_SocialRelationsVerEN.WorkUnit = objRow[conzx_SocialRelationsVer.WorkUnit] == DBNull.Value ? null : objRow[conzx_SocialRelationsVer.WorkUnit].ToString().Trim(); //工作单位
objzx_SocialRelationsVerEN.Major = objRow[conzx_SocialRelationsVer.Major] == DBNull.Value ? null : objRow[conzx_SocialRelationsVer.Major].ToString().Trim(); //专业
objzx_SocialRelationsVerEN.Achievement = objRow[conzx_SocialRelationsVer.Achievement] == DBNull.Value ? null : objRow[conzx_SocialRelationsVer.Achievement].ToString().Trim(); //成就
objzx_SocialRelationsVerEN.DetailedDescription = objRow[conzx_SocialRelationsVer.DetailedDescription] == DBNull.Value ? null : objRow[conzx_SocialRelationsVer.DetailedDescription].ToString().Trim(); //详细说明
objzx_SocialRelationsVerEN.zxLevelId = objRow[conzx_SocialRelationsVer.zxLevelId] == DBNull.Value ? null : objRow[conzx_SocialRelationsVer.zxLevelId].ToString().Trim(); //级别Id
objzx_SocialRelationsVerEN.UpdUser = objRow[conzx_SocialRelationsVer.UpdUser] == DBNull.Value ? null : objRow[conzx_SocialRelationsVer.UpdUser].ToString().Trim(); //修改人
objzx_SocialRelationsVerEN.CreateDate = objRow[conzx_SocialRelationsVer.CreateDate] == DBNull.Value ? null : objRow[conzx_SocialRelationsVer.CreateDate].ToString().Trim(); //建立日期
objzx_SocialRelationsVerEN.UpdDate = objRow[conzx_SocialRelationsVer.UpdDate] == DBNull.Value ? null : objRow[conzx_SocialRelationsVer.UpdDate].ToString().Trim(); //修改日期
objzx_SocialRelationsVerEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[conzx_SocialRelationsVer.IsSubmit].ToString().Trim()); //是否提交
objzx_SocialRelationsVerEN.VoteCount = objRow[conzx_SocialRelationsVer.VoteCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_SocialRelationsVer.VoteCount].ToString().Trim()); //点赞计数
objzx_SocialRelationsVerEN.CitationCount = objRow[conzx_SocialRelationsVer.CitationCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_SocialRelationsVer.CitationCount].ToString().Trim()); //引用统计
objzx_SocialRelationsVerEN.VersionCount = objRow[conzx_SocialRelationsVer.VersionCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_SocialRelationsVer.VersionCount].ToString().Trim()); //版本统计
objzx_SocialRelationsVerEN.IdCurrEduCls = objRow[conzx_SocialRelationsVer.IdCurrEduCls] == DBNull.Value ? null : objRow[conzx_SocialRelationsVer.IdCurrEduCls].ToString().Trim(); //教学班流水号
objzx_SocialRelationsVerEN.AppraiseCount = objRow[conzx_SocialRelationsVer.AppraiseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_SocialRelationsVer.AppraiseCount].ToString().Trim()); //评论数
objzx_SocialRelationsVerEN.Score = objRow[conzx_SocialRelationsVer.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conzx_SocialRelationsVer.Score].ToString().Trim()); //评分
objzx_SocialRelationsVerEN.StuScore = objRow[conzx_SocialRelationsVer.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conzx_SocialRelationsVer.StuScore].ToString().Trim()); //学生平均分
objzx_SocialRelationsVerEN.TeaScore = objRow[conzx_SocialRelationsVer.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conzx_SocialRelationsVer.TeaScore].ToString().Trim()); //教师评分
objzx_SocialRelationsVerEN.TextId = objRow[conzx_SocialRelationsVer.TextId] == DBNull.Value ? null : objRow[conzx_SocialRelationsVer.TextId].ToString().Trim(); //课件Id
objzx_SocialRelationsVerEN.zxShareId = objRow[conzx_SocialRelationsVer.zxShareId] == DBNull.Value ? null : objRow[conzx_SocialRelationsVer.zxShareId].ToString().Trim(); //分享Id
objzx_SocialRelationsVerEN.PdfContent = objRow[conzx_SocialRelationsVer.PdfContent] == DBNull.Value ? null : objRow[conzx_SocialRelationsVer.PdfContent].ToString().Trim(); //Pdf内容
objzx_SocialRelationsVerEN.PdfPageNum = objRow[conzx_SocialRelationsVer.PdfPageNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_SocialRelationsVer.PdfPageNum].ToString().Trim()); //Pdf页码
objzx_SocialRelationsVerEN.Memo = objRow[conzx_SocialRelationsVer.Memo] == DBNull.Value ? null : objRow[conzx_SocialRelationsVer.Memo].ToString().Trim(); //备注
objzx_SocialRelationsVerEN.PdfDivLet = objRow[conzx_SocialRelationsVer.PdfDivLet] == DBNull.Value ? null : objRow[conzx_SocialRelationsVer.PdfDivLet].ToString().Trim(); //PdfDivLet
objzx_SocialRelationsVerEN.PdfDivTop = objRow[conzx_SocialRelationsVer.PdfDivTop] == DBNull.Value ? null : objRow[conzx_SocialRelationsVer.PdfDivTop].ToString().Trim(); //PdfDivTop
objzx_SocialRelationsVerEN.PdfPageNumIn = objRow[conzx_SocialRelationsVer.PdfPageNumIn] == DBNull.Value ? null : objRow[conzx_SocialRelationsVer.PdfPageNumIn].ToString().Trim(); //PdfPageNumIn
objzx_SocialRelationsVerEN.PdfPageTop = objRow[conzx_SocialRelationsVer.PdfPageTop] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_SocialRelationsVer.PdfPageTop].ToString().Trim()); //pdf页面顶部位置
objzx_SocialRelationsVerEN.PdfZoom = objRow[conzx_SocialRelationsVer.PdfZoom] == DBNull.Value ? null : objRow[conzx_SocialRelationsVer.PdfZoom].ToString().Trim(); //PdfZoom
objzx_SocialRelationsVerEN.GroupTextId = objRow[conzx_SocialRelationsVer.GroupTextId] == DBNull.Value ? null : objRow[conzx_SocialRelationsVer.GroupTextId].ToString().Trim(); //小组Id
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objzx_SocialRelationsVerEN.SocialVId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objzx_SocialRelationsVerEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objzx_SocialRelationsVerEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool Getzx_SocialRelationsVer(ref clszx_SocialRelationsVerEN objzx_SocialRelationsVerEN)
{
bool bolResult = zx_SocialRelationsVerDA.Getzx_SocialRelationsVer(ref objzx_SocialRelationsVerEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "lngSocialVId">表关键字</param>
 /// <returns>表对象</returns>
public static clszx_SocialRelationsVerEN GetObjBySocialVId(long lngSocialVId)
{
clszx_SocialRelationsVerEN objzx_SocialRelationsVerEN = zx_SocialRelationsVerDA.GetObjBySocialVId(lngSocialVId);
return objzx_SocialRelationsVerEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clszx_SocialRelationsVerEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clszx_SocialRelationsVerEN objzx_SocialRelationsVerEN = zx_SocialRelationsVerDA.GetFirstObj(strWhereCond);
 return objzx_SocialRelationsVerEN;
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
public static clszx_SocialRelationsVerEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clszx_SocialRelationsVerEN objzx_SocialRelationsVerEN = zx_SocialRelationsVerDA.GetObjByDataRow(objRow);
 return objzx_SocialRelationsVerEN;
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
public static clszx_SocialRelationsVerEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clszx_SocialRelationsVerEN objzx_SocialRelationsVerEN = zx_SocialRelationsVerDA.GetObjByDataRow(objRow);
 return objzx_SocialRelationsVerEN;
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
 /// <param name = "lstzx_SocialRelationsVerObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clszx_SocialRelationsVerEN GetObjBySocialVIdFromList(long lngSocialVId, List<clszx_SocialRelationsVerEN> lstzx_SocialRelationsVerObjLst)
{
foreach (clszx_SocialRelationsVerEN objzx_SocialRelationsVerEN in lstzx_SocialRelationsVerObjLst)
{
if (objzx_SocialRelationsVerEN.SocialVId == lngSocialVId)
{
return objzx_SocialRelationsVerEN;
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
 lngSocialVId = new clszx_SocialRelationsVerDA().GetFirstID(strWhereCond);
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
 arrList = zx_SocialRelationsVerDA.GetID(strWhereCond);
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
bool bolIsExist = zx_SocialRelationsVerDA.IsExistCondRec(strWhereCond);
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
bool bolIsExist = zx_SocialRelationsVerDA.IsExist(lngSocialVId);
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
 bolIsExist = clszx_SocialRelationsVerDA.IsExistTable();
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
 bolIsExist = zx_SocialRelationsVerDA.IsExistTable(strTabName);
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
 /// <param name = "objzx_SocialRelationsVerEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecordBySql2(clszx_SocialRelationsVerEN objzx_SocialRelationsVerEN)
{
if (objzx_SocialRelationsVerEN.CheckUniqueness() == false)
{
var strMsg = string.Format("记录已经存在!社会Id = [{0}],小组Id = [{1}]的数据已经存在!(in clszx_SocialRelationsVerBL.AddNewRecordBySql2)", objzx_SocialRelationsVerEN.zxSocialId,objzx_SocialRelationsVerEN.GroupTextId);
throw new Exception(strMsg);
}
try
{
bool bolResult = zx_SocialRelationsVerDA.AddNewRecordBySQL2(objzx_SocialRelationsVerEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clszx_SocialRelationsVerBL.ReFreshCache();

if (clszx_SocialRelationsVerBL.relatedActions != null)
{
clszx_SocialRelationsVerBL.relatedActions.UpdRelaTabDate(objzx_SocialRelationsVerEN.SocialVId, "SetUpdDate");
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
 /// <param name = "objzx_SocialRelationsVerEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordBySql2WithReturnKey(clszx_SocialRelationsVerEN objzx_SocialRelationsVerEN)
{
if (objzx_SocialRelationsVerEN.CheckUniqueness() == false)
{
var strMsg = string.Format("记录已经存在!社会Id = [{0}],小组Id = [{1}]的数据已经存在!(in clszx_SocialRelationsVerBL.AddNewRecordBySql2WithReturnKey)", objzx_SocialRelationsVerEN.zxSocialId,objzx_SocialRelationsVerEN.GroupTextId);
throw new Exception(strMsg);
}
try
{
string strKey = zx_SocialRelationsVerDA.AddNewRecordBySQL2WithReturnKey(objzx_SocialRelationsVerEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clszx_SocialRelationsVerBL.ReFreshCache();

if (clszx_SocialRelationsVerBL.relatedActions != null)
{
clszx_SocialRelationsVerBL.relatedActions.UpdRelaTabDate(objzx_SocialRelationsVerEN.SocialVId, "SetUpdDate");
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
 /// <param name = "objzx_SocialRelationsVerEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(clszx_SocialRelationsVerEN objzx_SocialRelationsVerEN)
{
try
{
bool bolResult = zx_SocialRelationsVerDA.Update(objzx_SocialRelationsVerEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clszx_SocialRelationsVerBL.ReFreshCache();

if (clszx_SocialRelationsVerBL.relatedActions != null)
{
clszx_SocialRelationsVerBL.relatedActions.UpdRelaTabDate(objzx_SocialRelationsVerEN.SocialVId, "SetUpdDate");
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
 /// <param name = "objzx_SocialRelationsVerEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateBySql2(clszx_SocialRelationsVerEN objzx_SocialRelationsVerEN)
{
 if (objzx_SocialRelationsVerEN.SocialVId == 0)
 {
var strMsg = string.Format("(errid:Busi000065)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = zx_SocialRelationsVerDA.UpdateBySql2(objzx_SocialRelationsVerEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clszx_SocialRelationsVerBL.ReFreshCache();

if (clszx_SocialRelationsVerBL.relatedActions != null)
{
clszx_SocialRelationsVerBL.relatedActions.UpdRelaTabDate(objzx_SocialRelationsVerEN.SocialVId, "SetUpdDate");
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
 clszx_SocialRelationsVerEN objzx_SocialRelationsVerEN = clszx_SocialRelationsVerBL.GetObjBySocialVId(lngSocialVId);

if (clszx_SocialRelationsVerBL.relatedActions != null)
{
clszx_SocialRelationsVerBL.relatedActions.UpdRelaTabDate(objzx_SocialRelationsVerEN.SocialVId, "SetUpdDate");
}
if (objzx_SocialRelationsVerEN != null)
{
int intRecNum = zx_SocialRelationsVerDA.DelRecord(lngSocialVId);
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
objSQL = clszx_SocialRelationsVerDA.GetSpecSQLObj();
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
//删除与表:[zx_SocialRelationsVer]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conzx_SocialRelationsVer.SocialVId,
//lngSocialVId);
//        clszx_SocialRelationsVerBL.Delzx_SocialRelationsVersByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clszx_SocialRelationsVerBL.DelRecord(lngSocialVId, objConnection, objSqlTransaction);
objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clszx_SocialRelationsVerBLEx", "DelRecordEx", objException.Message, clsSysParaEN.strUserId);
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
if (clszx_SocialRelationsVerBL.relatedActions != null)
{
clszx_SocialRelationsVerBL.relatedActions.UpdRelaTabDate(lngSocialVId, "UpdRelaTabDate");
}
bool bolResult = zx_SocialRelationsVerDA.DelRecord(lngSocialVId,objSqlConnection,objSqlTransaction);
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
public static int Delzx_SocialRelationsVers(List<string> arrSocialVIdLst)
{
if (arrSocialVIdLst.Count == 0) return 0;
try
{
if (clszx_SocialRelationsVerBL.relatedActions != null)
{
foreach (var strSocialVId in arrSocialVIdLst)
{
long lngSocialVId = long.Parse(strSocialVId);
clszx_SocialRelationsVerBL.relatedActions.UpdRelaTabDate(lngSocialVId, "UpdRelaTabDate");
}
}
int intDelRecNum = zx_SocialRelationsVerDA.Delzx_SocialRelationsVer(arrSocialVIdLst);
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
public static int Delzx_SocialRelationsVersByCond(string strWhereCond)
{
try
{
if (clszx_SocialRelationsVerBL.relatedActions != null)
{
List<string> arrSocialVId = GetPrimaryKeyID_S(strWhereCond);
foreach (var strSocialVId in arrSocialVId)
{
long lngSocialVId = long.Parse(strSocialVId);
clszx_SocialRelationsVerBL.relatedActions.UpdRelaTabDate(lngSocialVId, "UpdRelaTabDate");
}
}
int intRecNum = zx_SocialRelationsVerDA.Delzx_SocialRelationsVer(strWhereCond);
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
/// 这里仅仅是演示函数,使用时请复制到扩展类:[zx_SocialRelationsVer]中改名为:[DelRecord4MultiTabEx]使用
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DelRecord4MultiTab)
/// </summary>
/// <param name="lngSocialVId">表关键字</param>
/// <returns></returns>
public static bool DelRecord4MultiTab(long lngSocialVId)
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clszx_SocialRelationsVerDA.GetSpecSQLObj();
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
//删除与表:[zx_SocialRelationsVer]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conStudent.id_College,
//strid_College);
//        clsStudentBL.DelStudentsByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clszx_SocialRelationsVerBL.DelRecord(lngSocialVId, objConnection, objSqlTransaction);
                objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clszx_SocialRelationsVerBL", "DelRecord4MultiTab", objException.Message, clsSysParaEN.strUserId);
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
 /// <param name = "objzx_SocialRelationsVerENS">源对象</param>
 /// <param name = "objzx_SocialRelationsVerENT">目标对象</param>
 public static void CopyTo(clszx_SocialRelationsVerEN objzx_SocialRelationsVerENS, clszx_SocialRelationsVerEN objzx_SocialRelationsVerENT)
{
try
{
objzx_SocialRelationsVerENT.SocialVId = objzx_SocialRelationsVerENS.SocialVId; //SocialVId
objzx_SocialRelationsVerENT.zxSocialId = objzx_SocialRelationsVerENS.zxSocialId; //社会Id
objzx_SocialRelationsVerENT.FullName = objzx_SocialRelationsVerENS.FullName; //姓名
objzx_SocialRelationsVerENT.Nationality = objzx_SocialRelationsVerENS.Nationality; //国籍
objzx_SocialRelationsVerENT.WorkUnit = objzx_SocialRelationsVerENS.WorkUnit; //工作单位
objzx_SocialRelationsVerENT.Major = objzx_SocialRelationsVerENS.Major; //专业
objzx_SocialRelationsVerENT.Achievement = objzx_SocialRelationsVerENS.Achievement; //成就
objzx_SocialRelationsVerENT.DetailedDescription = objzx_SocialRelationsVerENS.DetailedDescription; //详细说明
objzx_SocialRelationsVerENT.zxLevelId = objzx_SocialRelationsVerENS.zxLevelId; //级别Id
objzx_SocialRelationsVerENT.UpdUser = objzx_SocialRelationsVerENS.UpdUser; //修改人
objzx_SocialRelationsVerENT.CreateDate = objzx_SocialRelationsVerENS.CreateDate; //建立日期
objzx_SocialRelationsVerENT.UpdDate = objzx_SocialRelationsVerENS.UpdDate; //修改日期
objzx_SocialRelationsVerENT.IsSubmit = objzx_SocialRelationsVerENS.IsSubmit; //是否提交
objzx_SocialRelationsVerENT.VoteCount = objzx_SocialRelationsVerENS.VoteCount; //点赞计数
objzx_SocialRelationsVerENT.CitationCount = objzx_SocialRelationsVerENS.CitationCount; //引用统计
objzx_SocialRelationsVerENT.VersionCount = objzx_SocialRelationsVerENS.VersionCount; //版本统计
objzx_SocialRelationsVerENT.IdCurrEduCls = objzx_SocialRelationsVerENS.IdCurrEduCls; //教学班流水号
objzx_SocialRelationsVerENT.AppraiseCount = objzx_SocialRelationsVerENS.AppraiseCount; //评论数
objzx_SocialRelationsVerENT.Score = objzx_SocialRelationsVerENS.Score; //评分
objzx_SocialRelationsVerENT.StuScore = objzx_SocialRelationsVerENS.StuScore; //学生平均分
objzx_SocialRelationsVerENT.TeaScore = objzx_SocialRelationsVerENS.TeaScore; //教师评分
objzx_SocialRelationsVerENT.TextId = objzx_SocialRelationsVerENS.TextId; //课件Id
objzx_SocialRelationsVerENT.zxShareId = objzx_SocialRelationsVerENS.zxShareId; //分享Id
objzx_SocialRelationsVerENT.PdfContent = objzx_SocialRelationsVerENS.PdfContent; //Pdf内容
objzx_SocialRelationsVerENT.PdfPageNum = objzx_SocialRelationsVerENS.PdfPageNum; //Pdf页码
objzx_SocialRelationsVerENT.Memo = objzx_SocialRelationsVerENS.Memo; //备注
objzx_SocialRelationsVerENT.PdfDivLet = objzx_SocialRelationsVerENS.PdfDivLet; //PdfDivLet
objzx_SocialRelationsVerENT.PdfDivTop = objzx_SocialRelationsVerENS.PdfDivTop; //PdfDivTop
objzx_SocialRelationsVerENT.PdfPageNumIn = objzx_SocialRelationsVerENS.PdfPageNumIn; //PdfPageNumIn
objzx_SocialRelationsVerENT.PdfPageTop = objzx_SocialRelationsVerENS.PdfPageTop; //pdf页面顶部位置
objzx_SocialRelationsVerENT.PdfZoom = objzx_SocialRelationsVerENS.PdfZoom; //PdfZoom
objzx_SocialRelationsVerENT.GroupTextId = objzx_SocialRelationsVerENS.GroupTextId; //小组Id
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
 /// <param name = "objzx_SocialRelationsVerEN">源简化对象</param>
 public static void SetUpdFlag(clszx_SocialRelationsVerEN objzx_SocialRelationsVerEN)
{
try
{
objzx_SocialRelationsVerEN.ClearUpdateState();
   string strsfUpdFldSetStr = objzx_SocialRelationsVerEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(conzx_SocialRelationsVer.SocialVId, new clsStrCompareIgnoreCase())  ==  true)
{
objzx_SocialRelationsVerEN.SocialVId = objzx_SocialRelationsVerEN.SocialVId; //SocialVId
}
if (arrFldSet.Contains(conzx_SocialRelationsVer.zxSocialId, new clsStrCompareIgnoreCase())  ==  true)
{
objzx_SocialRelationsVerEN.zxSocialId = objzx_SocialRelationsVerEN.zxSocialId; //社会Id
}
if (arrFldSet.Contains(conzx_SocialRelationsVer.FullName, new clsStrCompareIgnoreCase())  ==  true)
{
objzx_SocialRelationsVerEN.FullName = objzx_SocialRelationsVerEN.FullName == "[null]" ? null :  objzx_SocialRelationsVerEN.FullName; //姓名
}
if (arrFldSet.Contains(conzx_SocialRelationsVer.Nationality, new clsStrCompareIgnoreCase())  ==  true)
{
objzx_SocialRelationsVerEN.Nationality = objzx_SocialRelationsVerEN.Nationality == "[null]" ? null :  objzx_SocialRelationsVerEN.Nationality; //国籍
}
if (arrFldSet.Contains(conzx_SocialRelationsVer.WorkUnit, new clsStrCompareIgnoreCase())  ==  true)
{
objzx_SocialRelationsVerEN.WorkUnit = objzx_SocialRelationsVerEN.WorkUnit == "[null]" ? null :  objzx_SocialRelationsVerEN.WorkUnit; //工作单位
}
if (arrFldSet.Contains(conzx_SocialRelationsVer.Major, new clsStrCompareIgnoreCase())  ==  true)
{
objzx_SocialRelationsVerEN.Major = objzx_SocialRelationsVerEN.Major == "[null]" ? null :  objzx_SocialRelationsVerEN.Major; //专业
}
if (arrFldSet.Contains(conzx_SocialRelationsVer.Achievement, new clsStrCompareIgnoreCase())  ==  true)
{
objzx_SocialRelationsVerEN.Achievement = objzx_SocialRelationsVerEN.Achievement == "[null]" ? null :  objzx_SocialRelationsVerEN.Achievement; //成就
}
if (arrFldSet.Contains(conzx_SocialRelationsVer.DetailedDescription, new clsStrCompareIgnoreCase())  ==  true)
{
objzx_SocialRelationsVerEN.DetailedDescription = objzx_SocialRelationsVerEN.DetailedDescription == "[null]" ? null :  objzx_SocialRelationsVerEN.DetailedDescription; //详细说明
}
if (arrFldSet.Contains(conzx_SocialRelationsVer.zxLevelId, new clsStrCompareIgnoreCase())  ==  true)
{
objzx_SocialRelationsVerEN.zxLevelId = objzx_SocialRelationsVerEN.zxLevelId == "[null]" ? null :  objzx_SocialRelationsVerEN.zxLevelId; //级别Id
}
if (arrFldSet.Contains(conzx_SocialRelationsVer.UpdUser, new clsStrCompareIgnoreCase())  ==  true)
{
objzx_SocialRelationsVerEN.UpdUser = objzx_SocialRelationsVerEN.UpdUser == "[null]" ? null :  objzx_SocialRelationsVerEN.UpdUser; //修改人
}
if (arrFldSet.Contains(conzx_SocialRelationsVer.CreateDate, new clsStrCompareIgnoreCase())  ==  true)
{
objzx_SocialRelationsVerEN.CreateDate = objzx_SocialRelationsVerEN.CreateDate == "[null]" ? null :  objzx_SocialRelationsVerEN.CreateDate; //建立日期
}
if (arrFldSet.Contains(conzx_SocialRelationsVer.UpdDate, new clsStrCompareIgnoreCase())  ==  true)
{
objzx_SocialRelationsVerEN.UpdDate = objzx_SocialRelationsVerEN.UpdDate == "[null]" ? null :  objzx_SocialRelationsVerEN.UpdDate; //修改日期
}
if (arrFldSet.Contains(conzx_SocialRelationsVer.IsSubmit, new clsStrCompareIgnoreCase())  ==  true)
{
objzx_SocialRelationsVerEN.IsSubmit = objzx_SocialRelationsVerEN.IsSubmit; //是否提交
}
if (arrFldSet.Contains(conzx_SocialRelationsVer.VoteCount, new clsStrCompareIgnoreCase())  ==  true)
{
objzx_SocialRelationsVerEN.VoteCount = objzx_SocialRelationsVerEN.VoteCount; //点赞计数
}
if (arrFldSet.Contains(conzx_SocialRelationsVer.CitationCount, new clsStrCompareIgnoreCase())  ==  true)
{
objzx_SocialRelationsVerEN.CitationCount = objzx_SocialRelationsVerEN.CitationCount; //引用统计
}
if (arrFldSet.Contains(conzx_SocialRelationsVer.VersionCount, new clsStrCompareIgnoreCase())  ==  true)
{
objzx_SocialRelationsVerEN.VersionCount = objzx_SocialRelationsVerEN.VersionCount; //版本统计
}
if (arrFldSet.Contains(conzx_SocialRelationsVer.IdCurrEduCls, new clsStrCompareIgnoreCase())  ==  true)
{
objzx_SocialRelationsVerEN.IdCurrEduCls = objzx_SocialRelationsVerEN.IdCurrEduCls == "[null]" ? null :  objzx_SocialRelationsVerEN.IdCurrEduCls; //教学班流水号
}
if (arrFldSet.Contains(conzx_SocialRelationsVer.AppraiseCount, new clsStrCompareIgnoreCase())  ==  true)
{
objzx_SocialRelationsVerEN.AppraiseCount = objzx_SocialRelationsVerEN.AppraiseCount; //评论数
}
if (arrFldSet.Contains(conzx_SocialRelationsVer.Score, new clsStrCompareIgnoreCase())  ==  true)
{
objzx_SocialRelationsVerEN.Score = objzx_SocialRelationsVerEN.Score; //评分
}
if (arrFldSet.Contains(conzx_SocialRelationsVer.StuScore, new clsStrCompareIgnoreCase())  ==  true)
{
objzx_SocialRelationsVerEN.StuScore = objzx_SocialRelationsVerEN.StuScore; //学生平均分
}
if (arrFldSet.Contains(conzx_SocialRelationsVer.TeaScore, new clsStrCompareIgnoreCase())  ==  true)
{
objzx_SocialRelationsVerEN.TeaScore = objzx_SocialRelationsVerEN.TeaScore; //教师评分
}
if (arrFldSet.Contains(conzx_SocialRelationsVer.TextId, new clsStrCompareIgnoreCase())  ==  true)
{
objzx_SocialRelationsVerEN.TextId = objzx_SocialRelationsVerEN.TextId == "[null]" ? null :  objzx_SocialRelationsVerEN.TextId; //课件Id
}
if (arrFldSet.Contains(conzx_SocialRelationsVer.zxShareId, new clsStrCompareIgnoreCase())  ==  true)
{
objzx_SocialRelationsVerEN.zxShareId = objzx_SocialRelationsVerEN.zxShareId == "[null]" ? null :  objzx_SocialRelationsVerEN.zxShareId; //分享Id
}
if (arrFldSet.Contains(conzx_SocialRelationsVer.PdfContent, new clsStrCompareIgnoreCase())  ==  true)
{
objzx_SocialRelationsVerEN.PdfContent = objzx_SocialRelationsVerEN.PdfContent == "[null]" ? null :  objzx_SocialRelationsVerEN.PdfContent; //Pdf内容
}
if (arrFldSet.Contains(conzx_SocialRelationsVer.PdfPageNum, new clsStrCompareIgnoreCase())  ==  true)
{
objzx_SocialRelationsVerEN.PdfPageNum = objzx_SocialRelationsVerEN.PdfPageNum; //Pdf页码
}
if (arrFldSet.Contains(conzx_SocialRelationsVer.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objzx_SocialRelationsVerEN.Memo = objzx_SocialRelationsVerEN.Memo == "[null]" ? null :  objzx_SocialRelationsVerEN.Memo; //备注
}
if (arrFldSet.Contains(conzx_SocialRelationsVer.PdfDivLet, new clsStrCompareIgnoreCase())  ==  true)
{
objzx_SocialRelationsVerEN.PdfDivLet = objzx_SocialRelationsVerEN.PdfDivLet == "[null]" ? null :  objzx_SocialRelationsVerEN.PdfDivLet; //PdfDivLet
}
if (arrFldSet.Contains(conzx_SocialRelationsVer.PdfDivTop, new clsStrCompareIgnoreCase())  ==  true)
{
objzx_SocialRelationsVerEN.PdfDivTop = objzx_SocialRelationsVerEN.PdfDivTop == "[null]" ? null :  objzx_SocialRelationsVerEN.PdfDivTop; //PdfDivTop
}
if (arrFldSet.Contains(conzx_SocialRelationsVer.PdfPageNumIn, new clsStrCompareIgnoreCase())  ==  true)
{
objzx_SocialRelationsVerEN.PdfPageNumIn = objzx_SocialRelationsVerEN.PdfPageNumIn == "[null]" ? null :  objzx_SocialRelationsVerEN.PdfPageNumIn; //PdfPageNumIn
}
if (arrFldSet.Contains(conzx_SocialRelationsVer.PdfPageTop, new clsStrCompareIgnoreCase())  ==  true)
{
objzx_SocialRelationsVerEN.PdfPageTop = objzx_SocialRelationsVerEN.PdfPageTop; //pdf页面顶部位置
}
if (arrFldSet.Contains(conzx_SocialRelationsVer.PdfZoom, new clsStrCompareIgnoreCase())  ==  true)
{
objzx_SocialRelationsVerEN.PdfZoom = objzx_SocialRelationsVerEN.PdfZoom == "[null]" ? null :  objzx_SocialRelationsVerEN.PdfZoom; //PdfZoom
}
if (arrFldSet.Contains(conzx_SocialRelationsVer.GroupTextId, new clsStrCompareIgnoreCase())  ==  true)
{
objzx_SocialRelationsVerEN.GroupTextId = objzx_SocialRelationsVerEN.GroupTextId == "[null]" ? null :  objzx_SocialRelationsVerEN.GroupTextId; //小组Id
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
 /// <param name = "objzx_SocialRelationsVerEN">源简化对象</param>
 public static void AccessFldValueNull(clszx_SocialRelationsVerEN objzx_SocialRelationsVerEN)
{
try
{
if (objzx_SocialRelationsVerEN.FullName == "[null]") objzx_SocialRelationsVerEN.FullName = null; //姓名
if (objzx_SocialRelationsVerEN.Nationality == "[null]") objzx_SocialRelationsVerEN.Nationality = null; //国籍
if (objzx_SocialRelationsVerEN.WorkUnit == "[null]") objzx_SocialRelationsVerEN.WorkUnit = null; //工作单位
if (objzx_SocialRelationsVerEN.Major == "[null]") objzx_SocialRelationsVerEN.Major = null; //专业
if (objzx_SocialRelationsVerEN.Achievement == "[null]") objzx_SocialRelationsVerEN.Achievement = null; //成就
if (objzx_SocialRelationsVerEN.DetailedDescription == "[null]") objzx_SocialRelationsVerEN.DetailedDescription = null; //详细说明
if (objzx_SocialRelationsVerEN.zxLevelId == "[null]") objzx_SocialRelationsVerEN.zxLevelId = null; //级别Id
if (objzx_SocialRelationsVerEN.UpdUser == "[null]") objzx_SocialRelationsVerEN.UpdUser = null; //修改人
if (objzx_SocialRelationsVerEN.CreateDate == "[null]") objzx_SocialRelationsVerEN.CreateDate = null; //建立日期
if (objzx_SocialRelationsVerEN.UpdDate == "[null]") objzx_SocialRelationsVerEN.UpdDate = null; //修改日期
if (objzx_SocialRelationsVerEN.IdCurrEduCls == "[null]") objzx_SocialRelationsVerEN.IdCurrEduCls = null; //教学班流水号
if (objzx_SocialRelationsVerEN.TextId == "[null]") objzx_SocialRelationsVerEN.TextId = null; //课件Id
if (objzx_SocialRelationsVerEN.zxShareId == "[null]") objzx_SocialRelationsVerEN.zxShareId = null; //分享Id
if (objzx_SocialRelationsVerEN.PdfContent == "[null]") objzx_SocialRelationsVerEN.PdfContent = null; //Pdf内容
if (objzx_SocialRelationsVerEN.Memo == "[null]") objzx_SocialRelationsVerEN.Memo = null; //备注
if (objzx_SocialRelationsVerEN.PdfDivLet == "[null]") objzx_SocialRelationsVerEN.PdfDivLet = null; //PdfDivLet
if (objzx_SocialRelationsVerEN.PdfDivTop == "[null]") objzx_SocialRelationsVerEN.PdfDivTop = null; //PdfDivTop
if (objzx_SocialRelationsVerEN.PdfPageNumIn == "[null]") objzx_SocialRelationsVerEN.PdfPageNumIn = null; //PdfPageNumIn
if (objzx_SocialRelationsVerEN.PdfZoom == "[null]") objzx_SocialRelationsVerEN.PdfZoom = null; //PdfZoom
if (objzx_SocialRelationsVerEN.GroupTextId == "[null]") objzx_SocialRelationsVerEN.GroupTextId = null; //小组Id
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
public static void CheckPropertyNew(clszx_SocialRelationsVerEN objzx_SocialRelationsVerEN)
{
 zx_SocialRelationsVerDA.CheckPropertyNew(objzx_SocialRelationsVerEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(clszx_SocialRelationsVerEN objzx_SocialRelationsVerEN)
{
 zx_SocialRelationsVerDA.CheckProperty4Condition(objzx_SocialRelationsVerEN);
 }


 #endregion 检查对象属性


 #region 绑定下拉框

 /// <summary>
 /// 绑定基于Win的下拉框
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_TabFeature_ComboBoxBindFunction)
 /// </summary>
 /// <param name = "objComboBox">需要绑定当前表的下拉框</param>

public static void BindCbo_SocialVId(System.Windows.Forms.ComboBox objComboBox )
{
//为数据源为表的下拉框设置内容
string strCondition = string.Format("1 =1 Order By {0}", conzx_SocialRelationsVer.SocialVId); 
List<clszx_SocialRelationsVerEN> arrObjLst = clszx_SocialRelationsVerBL.GetObjLst(strCondition);
//初始化一个对象列表
//插入第0项。在第0项中插入“请选择...”,为了方便用户,与WEB方式类似。
clszx_SocialRelationsVerEN objzx_SocialRelationsVerEN = new clszx_SocialRelationsVerEN()
{
SocialVId = 0,
zxLevelId = "选[社会关系版本]..."
};
arrObjLst.Insert(0, objzx_SocialRelationsVerEN);
//设置下拉框的数据源、以及设置值项、显示项
objComboBox.ValueMember = conzx_SocialRelationsVer.SocialVId;
objComboBox.DisplayMember = conzx_SocialRelationsVer.zxLevelId;
objComboBox.DataSource = arrObjLst;
objComboBox.SelectedIndex = 0;
}

 /// <summary>
 /// 绑定基于Web的下拉框
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_TabFeature_DdlBindFunction)
 /// </summary>
 /// <param name = "objDDL">需要绑定当前表的下拉框</param>

public static void BindDdl_SocialVId(System.Web.UI.WebControls.DropDownList objDDL )
{
//为数据源于表的下拉框设置内容
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[社会关系版本]...","0");
string strCondition = string.Format("1 =1 Order By {0}", conzx_SocialRelationsVer.SocialVId); 
IEnumerable<clszx_SocialRelationsVerEN> arrObjLst = clszx_SocialRelationsVerBL.GetObjLst(strCondition);
objDDL.DataValueField = conzx_SocialRelationsVer.SocialVId;
objDDL.DataTextField = conzx_SocialRelationsVer.zxLevelId;
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
public static void BindDdl_SocialVIdCache(System.Web.UI.WebControls.DropDownList objDDL)
{
//为数据源于表的下拉框设置内容
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[社会关系版本]...","0");
List<clszx_SocialRelationsVerEN> arrzx_SocialRelationsVerObjLst = GetAllzx_SocialRelationsVerObjLstCache(); 
objDDL.DataValueField = conzx_SocialRelationsVer.SocialVId;
objDDL.DataTextField = conzx_SocialRelationsVer.zxLevelId;
objDDL.DataSource = arrzx_SocialRelationsVerObjLst;
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
if (clszx_SocialRelationsVerBL.objCommFun4BL == null)
{
strMsg = string.Format("类clszx_SocialRelationsVerBL没有刷新缓存机制(clszx_SocialRelationsVerBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by SocialVId");
//if (arrzx_SocialRelationsVerObjLstCache == null)
//{
//arrzx_SocialRelationsVerObjLstCache = zx_SocialRelationsVerDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "lngSocialVId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clszx_SocialRelationsVerEN GetObjBySocialVIdCache(long lngSocialVId)
{
//获取缓存中的对象列表
string strKey = string.Format("{0}", clszx_SocialRelationsVerEN._CurrTabName);
List<clszx_SocialRelationsVerEN> arrzx_SocialRelationsVerObjLstCache = GetObjLstCache();
IEnumerable <clszx_SocialRelationsVerEN> arrzx_SocialRelationsVerObjLst_Sel =
arrzx_SocialRelationsVerObjLstCache
.Where(x=> x.SocialVId == lngSocialVId 
);
if (arrzx_SocialRelationsVerObjLst_Sel.Count() == 0)
{
   clszx_SocialRelationsVerEN obj = clszx_SocialRelationsVerBL.GetObjBySocialVId(lngSocialVId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
 }
return null;
}
return arrzx_SocialRelationsVerObjLst_Sel.First();
}

 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecNameByKeyCache)
 /// </summary>
 /// <param name = "lngSocialVId">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetzxLevelIdBySocialVIdCache(long lngSocialVId)
{
//获取缓存中的对象列表
clszx_SocialRelationsVerEN objzx_SocialRelationsVer = GetObjBySocialVIdCache(lngSocialVId);
if (objzx_SocialRelationsVer == null) return "";
return objzx_SocialRelationsVer.zxLevelId;
}
 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecNameByKeyCache)
 /// </summary>
 /// <param name = "lngSocialVId">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetNameBySocialVIdCache(long lngSocialVId)
{
//获取缓存中的对象列表
clszx_SocialRelationsVerEN objzx_SocialRelationsVer = GetObjBySocialVIdCache(lngSocialVId);
if (objzx_SocialRelationsVer == null) return "";
return objzx_SocialRelationsVer.zxLevelId;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clszx_SocialRelationsVerEN> GetAllzx_SocialRelationsVerObjLstCache()
{
//获取缓存中的对象列表
List<clszx_SocialRelationsVerEN> arrzx_SocialRelationsVerObjLstCache = GetObjLstCache(); 
return arrzx_SocialRelationsVerObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clszx_SocialRelationsVerEN> GetObjLstCache()
{
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}", clszx_SocialRelationsVerEN._CurrTabName);
List<clszx_SocialRelationsVerEN> arrzx_SocialRelationsVerObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrzx_SocialRelationsVerObjLstCache;
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
string strKey = string.Format("{0}", clszx_SocialRelationsVerEN._CurrTabName);
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
 /// 刷新缓存.把当前表的缓存以及该表相关视图的缓存清空.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ReFreshCache)
 /// </summary>
public static void ReFreshCache()
{
if (clszx_SocialRelationsVerBL.objCommFun4BL != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}", clszx_SocialRelationsVerEN._CurrTabName);
CacheHelper.Remove(strKey);
clszx_SocialRelationsVerBL.objCommFun4BL.ReFreshCache();
}
}


 #endregion 缓存操作


 #region 检查唯一性

 /// <summary>
 /// 获取检查唯一性条件串(Uniqueness)--zx_SocialRelationsVer(社会关系版本)
 /// 唯一性条件:zxSocialId_GroupTextId
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetUniquenessConditionString)
 /// </summary>
 /// <param name = "objzx_SocialRelationsVerEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(clszx_SocialRelationsVerEN objzx_SocialRelationsVerEN)
{
//检测记录是否存在
string strResult = zx_SocialRelationsVerDA.GetUniCondStr(objzx_SocialRelationsVerEN);
return strResult;
}


 #endregion 检查唯一性

 /// <summary>
 /// 映射函数。根据表映射把输入字段值,映射成输出字段值
 /// 作者:pyf
 /// 日期:2023-11-15
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_func)
 /// </summary>
 /// <param name = "strInFldName">输入字段名</param>
 /// <param name = "strOutFldName">输出字段名</param>
 /// <param name = "strInValue">输入字段值</param>
 /// <returns>返回一个输出字段值</returns>
public static string Func(string strInFldName, string strOutFldName, long lngSocialVId)
{
if (strInFldName != conzx_SocialRelationsVer.SocialVId)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (conzx_SocialRelationsVer.AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", conzx_SocialRelationsVer.AttributeName));
throw new Exception(strMsg);
}
var objzx_SocialRelationsVer = clszx_SocialRelationsVerBL.GetObjBySocialVIdCache(lngSocialVId);
if (objzx_SocialRelationsVer == null) return "";
return objzx_SocialRelationsVer[strOutFldName].ToString();
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
int intRecCount = clszx_SocialRelationsVerDA.GetRecCount(strTabName);
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
int intRecCount = clszx_SocialRelationsVerDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clszx_SocialRelationsVerDA.GetRecCount();
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
int intRecCount = clszx_SocialRelationsVerDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objzx_SocialRelationsVerCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clszx_SocialRelationsVerEN objzx_SocialRelationsVerCond)
{
List<clszx_SocialRelationsVerEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clszx_SocialRelationsVerEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conzx_SocialRelationsVer.AttributeName)
{
if (objzx_SocialRelationsVerCond.IsUpdated(strFldName) == false) continue;
if (objzx_SocialRelationsVerCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objzx_SocialRelationsVerCond[strFldName].ToString());
}
else
{
if (objzx_SocialRelationsVerCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objzx_SocialRelationsVerCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objzx_SocialRelationsVerCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objzx_SocialRelationsVerCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objzx_SocialRelationsVerCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objzx_SocialRelationsVerCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objzx_SocialRelationsVerCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objzx_SocialRelationsVerCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objzx_SocialRelationsVerCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objzx_SocialRelationsVerCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objzx_SocialRelationsVerCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objzx_SocialRelationsVerCond[strFldName]));
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
 List<string> arrList = clszx_SocialRelationsVerDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = zx_SocialRelationsVerDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = zx_SocialRelationsVerDA.GetFldValueNoDistinct(strFldName, strWhereCond);
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
int intRecCount = zx_SocialRelationsVerDA.SetFldValue(strFldName, strValue, strWhereCond);
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
int intRecCount = clszx_SocialRelationsVerDA.SetFldValue(clszx_SocialRelationsVerEN._CurrTabName, strFldName, fltValue, strWhereCond);
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
int intRecCount = zx_SocialRelationsVerDA.SetFldValue( strFldName, intValue, strWhereCond);
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
int intRecCount = clszx_SocialRelationsVerDA.SetFldValue(strTabName, strFldName, strValue, strWhereCond);
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
int intRecCount = clszx_SocialRelationsVerDA.SetFldValue(strTabName, strFldName, intValue, strWhereCond);
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
int intRecCount = clszx_SocialRelationsVerDA.SetFldValue(strTabName, strFldName, fltValue, strWhereCond);
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
  strCreateTabCode.Append("CREATE table [dbo].[zx_SocialRelationsVer] "); 
 strCreateTabCode.Append(" ( "); 
 // /**SocialVId*/ 
 strCreateTabCode.Append(" SocialVId bigint primary key identity, "); 
 // /**社会Id*/ 
 strCreateTabCode.Append(" zxSocialId char(10) not Null, "); 
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
 strCreateTabCode.Append(" DetailedDescription text Null, "); 
 // /**级别Id*/ 
 strCreateTabCode.Append(" zxLevelId char(2) Null, "); 
 // /**修改人*/ 
 strCreateTabCode.Append(" UpdUser varchar(20) Null, "); 
 // /**建立日期*/ 
 strCreateTabCode.Append(" CreateDate varchar(20) Null, "); 
 // /**修改日期*/ 
 strCreateTabCode.Append(" UpdDate varchar(20) Null, "); 
 // /**是否提交*/ 
 strCreateTabCode.Append(" IsSubmit bit Null, "); 
 // /**点赞计数*/ 
 strCreateTabCode.Append(" VoteCount int Null, "); 
 // /**引用统计*/ 
 strCreateTabCode.Append(" CitationCount int Null, "); 
 // /**版本统计*/ 
 strCreateTabCode.Append(" VersionCount int Null, "); 
 // /**教学班流水号*/ 
 strCreateTabCode.Append(" IdCurrEduCls char(8) Null, "); 
 // /**评论数*/ 
 strCreateTabCode.Append(" AppraiseCount int Null, "); 
 // /**评分*/ 
 strCreateTabCode.Append(" Score float Null, "); 
 // /**学生平均分*/ 
 strCreateTabCode.Append(" StuScore float Null, "); 
 // /**教师评分*/ 
 strCreateTabCode.Append(" TeaScore float Null, "); 
 // /**课件Id*/ 
 strCreateTabCode.Append(" TextId char(8) Null, "); 
 // /**分享Id*/ 
 strCreateTabCode.Append(" zxShareId char(2) Null, "); 
 // /**Pdf内容*/ 
 strCreateTabCode.Append(" PdfContent varchar(2000) Null, "); 
 // /**Pdf页码*/ 
 strCreateTabCode.Append(" PdfPageNum int Null, "); 
 // /**备注*/ 
 strCreateTabCode.Append(" Memo varchar(1000) Null, "); 
 // /**PdfDivLet*/ 
 strCreateTabCode.Append(" PdfDivLet varchar(50) Null, "); 
 // /**PdfDivTop*/ 
 strCreateTabCode.Append(" PdfDivTop varchar(50) Null, "); 
 // /**PdfPageNumIn*/ 
 strCreateTabCode.Append(" PdfPageNumIn varchar(50) Null, "); 
 // /**pdf页面顶部位置*/ 
 strCreateTabCode.Append(" PdfPageTop int Null, "); 
 // /**PdfZoom*/ 
 strCreateTabCode.Append(" PdfZoom varchar(50) Null, "); 
 // /**小组Id*/ 
 strCreateTabCode.Append(" GroupTextId char(8) Null ");
 strCreateTabCode.Append(") "); 
  strCreateTabCode.Append("ON [PRIMARY] ");
  return strCreateTabCode.ToString();
}



 #endregion 表操作
}
 /// <summary>
 /// 社会关系版本(zx_SocialRelationsVer)
 /// 数据源类型:表
 /// (AutoGCLib.CommFun4BL4CSharp:GeneCode_This)
 /// </summary>
public class  clsCommFun4BL4zx_SocialRelationsVer : clsCommFun4BL
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
clszx_SocialRelationsVerBL.ReFreshThisCache();
}
}

}