
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsSysSocialRelationsBL
 表名:SysSocialRelations(01120644)
 * 版本:2024.11.13.1(服务器:WIN-SRV103-116)
 日期:2024/11/13 06:05:50
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
public static class  clsSysSocialRelationsBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "strSocialId">表关键字</param>
 /// <returns>表对象</returns>
public static clsSysSocialRelationsEN GetObj(this K_SocialId_SysSocialRelations myKey)
{
clsSysSocialRelationsEN objSysSocialRelationsEN = clsSysSocialRelationsBL.SysSocialRelationsDA.GetObjBySocialId(myKey.Value);
return objSysSocialRelationsEN;
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_AddNewRecord)
 /// </summary>
 /// <param name = "objSysSocialRelationsEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clsSysSocialRelationsEN objSysSocialRelationsEN, bool bolIsNeedCheckUniqueness = true)
{
if (bolIsNeedCheckUniqueness == true && CheckUniqueness(objSysSocialRelationsEN) == false)
{
var strMsg = string.Format("记录已经存在!社会Id = [{0}]的数据已经存在!(in clsSysSocialRelationsBL.AddNewRecord)", objSysSocialRelationsEN.SocialId);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objSysSocialRelationsEN.SocialId) == true || clsSysSocialRelationsBL.IsExist(objSysSocialRelationsEN.SocialId) == true)
 {
     objSysSocialRelationsEN.SocialId = clsSysSocialRelationsBL.GetMaxStrId_S();
 }
bool bolResult = clsSysSocialRelationsBL.SysSocialRelationsDA.AddNewRecordBySQL2(objSysSocialRelationsEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsSysSocialRelationsBL.ReFreshCache(objSysSocialRelationsEN.IdCurrEduCls);

if (clsSysSocialRelationsBL.relatedActions != null)
{
clsSysSocialRelationsBL.relatedActions.UpdRelaTabDate(objSysSocialRelationsEN.SocialId, "SetUpdDate");
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
public static bool AddRecordEx(this clsSysSocialRelationsEN objSysSocialRelationsEN, bool bolIsNeedCheckUniqueness = true)
{
//操作步骤:
//1、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在
//2、检查唯一性
//3、检查传进去的对象属性是否合法
//4、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
//1、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在

//因为是字符型自增主键,不需要检查主键是否已经存在,在添加时,再获取 最大值作为主键
//if (clsSysSocialRelationsBL.IsExist(objSysSocialRelationsEN.SocialId))	//判断是否有相同的关键字
//{
//strMsg = "(errid:Busi000151)关键字字段已有相同的值";
//throw new Exception(strMsg);
//}
try
{
 //2、检查传进去的对象属性是否合法
objSysSocialRelationsEN.CheckPropertyNew();
 ///5.2、检查唯一性
if (bolIsNeedCheckUniqueness == true && objSysSocialRelationsEN.CheckUniqueness() == false)
{
strMsg = string.Format("(社会Id(SocialId)=[{0}])已经存在,不能重复!", objSysSocialRelationsEN.SocialId);
throw new Exception(strMsg);
}
//因为是字符型自增主键,所以在添加时,自动获取主键值。
 if (string.IsNullOrEmpty(objSysSocialRelationsEN.SocialId) == true || clsSysSocialRelationsBL.IsExist(objSysSocialRelationsEN.SocialId) == true)
 {
     objSysSocialRelationsEN.SocialId = clsSysSocialRelationsBL.GetMaxStrId_S();
 }
//6、把数据实体层的数据存贮到数据库中
objSysSocialRelationsEN.AddNewRecord();
}
catch(Exception objException)
{
strMsg = "(errid:Busi000152)添加记录不成功!" + objException.Message;
throw new Exception(strMsg);
}
return true;
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,其中关键字为表中获取的最大值。该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_AddNewRecordWithMaxId)
 /// </summary>
 /// <param name = "objSysSocialRelationsEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static string AddNewRecordWithMaxId(this clsSysSocialRelationsEN objSysSocialRelationsEN, bool bolIsNeedCheckUniqueness = true)
{
if (bolIsNeedCheckUniqueness == true && CheckUniqueness(objSysSocialRelationsEN) == false)
{
var strMsg = string.Format("记录已经存在!社会Id = [{0}]的数据已经存在!(in clsSysSocialRelationsBL.AddNewRecordWithMaxId)", objSysSocialRelationsEN.SocialId);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objSysSocialRelationsEN.SocialId) == true || clsSysSocialRelationsBL.IsExist(objSysSocialRelationsEN.SocialId) == true)
 {
     objSysSocialRelationsEN.SocialId = clsSysSocialRelationsBL.GetMaxStrId_S();
 }
string strSocialId = clsSysSocialRelationsBL.SysSocialRelationsDA.AddNewRecordBySQL2WithReturnKey(objSysSocialRelationsEN);
     objSysSocialRelationsEN.SocialId = strSocialId;
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsSysSocialRelationsBL.ReFreshCache(objSysSocialRelationsEN.IdCurrEduCls);

if (clsSysSocialRelationsBL.relatedActions != null)
{
clsSysSocialRelationsBL.relatedActions.UpdRelaTabDate(objSysSocialRelationsEN.SocialId, "SetUpdDate");
}
return strSocialId;
}
catch (Exception objException)
{
string strMsg = string.Format("(errid:Busi000096)添加记录出错, {1}.(from {0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
}
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_AddNewRecordWithReturnKey)
 /// </summary>
 /// <param name = "objSysSocialRelationsEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordWithReturnKey(this clsSysSocialRelationsEN objSysSocialRelationsEN, bool bolIsNeedCheckUniqueness = true)
{
if (bolIsNeedCheckUniqueness == true && CheckUniqueness(objSysSocialRelationsEN) == false)
{
var strMsg = string.Format("记录已经存在!社会Id = [{0}]的数据已经存在!(in clsSysSocialRelationsBL.AddNewRecordWithReturnKey)", objSysSocialRelationsEN.SocialId);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objSysSocialRelationsEN.SocialId) == true || clsSysSocialRelationsBL.IsExist(objSysSocialRelationsEN.SocialId) == true)
 {
     objSysSocialRelationsEN.SocialId = clsSysSocialRelationsBL.GetMaxStrId_S();
 }
string strKey = clsSysSocialRelationsBL.SysSocialRelationsDA.AddNewRecordBySQL2WithReturnKey(objSysSocialRelationsEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsSysSocialRelationsBL.ReFreshCache(objSysSocialRelationsEN.IdCurrEduCls);

if (clsSysSocialRelationsBL.relatedActions != null)
{
clsSysSocialRelationsBL.relatedActions.UpdRelaTabDate(objSysSocialRelationsEN.SocialId, "SetUpdDate");
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
 /// <param name = "objSysSocialRelationsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsSysSocialRelationsEN SetSocialId(this clsSysSocialRelationsEN objSysSocialRelationsEN, string strSocialId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strSocialId, 10, conSysSocialRelations.SocialId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strSocialId, 10, conSysSocialRelations.SocialId);
}
objSysSocialRelationsEN.SocialId = strSocialId; //社会Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objSysSocialRelationsEN.dicFldComparisonOp.ContainsKey(conSysSocialRelations.SocialId) == false)
{
objSysSocialRelationsEN.dicFldComparisonOp.Add(conSysSocialRelations.SocialId, strComparisonOp);
}
else
{
objSysSocialRelationsEN.dicFldComparisonOp[conSysSocialRelations.SocialId] = strComparisonOp;
}
}
return objSysSocialRelationsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objSysSocialRelationsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsSysSocialRelationsEN SetFullName(this clsSysSocialRelationsEN objSysSocialRelationsEN, string strFullName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFullName, 50, conSysSocialRelations.FullName);
}
objSysSocialRelationsEN.FullName = strFullName; //姓名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objSysSocialRelationsEN.dicFldComparisonOp.ContainsKey(conSysSocialRelations.FullName) == false)
{
objSysSocialRelationsEN.dicFldComparisonOp.Add(conSysSocialRelations.FullName, strComparisonOp);
}
else
{
objSysSocialRelationsEN.dicFldComparisonOp[conSysSocialRelations.FullName] = strComparisonOp;
}
}
return objSysSocialRelationsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objSysSocialRelationsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsSysSocialRelationsEN SetNationality(this clsSysSocialRelationsEN objSysSocialRelationsEN, string strNationality, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strNationality, 50, conSysSocialRelations.Nationality);
}
objSysSocialRelationsEN.Nationality = strNationality; //国籍
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objSysSocialRelationsEN.dicFldComparisonOp.ContainsKey(conSysSocialRelations.Nationality) == false)
{
objSysSocialRelationsEN.dicFldComparisonOp.Add(conSysSocialRelations.Nationality, strComparisonOp);
}
else
{
objSysSocialRelationsEN.dicFldComparisonOp[conSysSocialRelations.Nationality] = strComparisonOp;
}
}
return objSysSocialRelationsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objSysSocialRelationsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsSysSocialRelationsEN SetWorkUnit(this clsSysSocialRelationsEN objSysSocialRelationsEN, string strWorkUnit, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strWorkUnit, 100, conSysSocialRelations.WorkUnit);
}
objSysSocialRelationsEN.WorkUnit = strWorkUnit; //工作单位
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objSysSocialRelationsEN.dicFldComparisonOp.ContainsKey(conSysSocialRelations.WorkUnit) == false)
{
objSysSocialRelationsEN.dicFldComparisonOp.Add(conSysSocialRelations.WorkUnit, strComparisonOp);
}
else
{
objSysSocialRelationsEN.dicFldComparisonOp[conSysSocialRelations.WorkUnit] = strComparisonOp;
}
}
return objSysSocialRelationsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objSysSocialRelationsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsSysSocialRelationsEN SetMajor(this clsSysSocialRelationsEN objSysSocialRelationsEN, string strMajor, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMajor, 50, conSysSocialRelations.Major);
}
objSysSocialRelationsEN.Major = strMajor; //专业
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objSysSocialRelationsEN.dicFldComparisonOp.ContainsKey(conSysSocialRelations.Major) == false)
{
objSysSocialRelationsEN.dicFldComparisonOp.Add(conSysSocialRelations.Major, strComparisonOp);
}
else
{
objSysSocialRelationsEN.dicFldComparisonOp[conSysSocialRelations.Major] = strComparisonOp;
}
}
return objSysSocialRelationsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objSysSocialRelationsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsSysSocialRelationsEN SetAchievement(this clsSysSocialRelationsEN objSysSocialRelationsEN, string strAchievement, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strAchievement, 5000, conSysSocialRelations.Achievement);
}
objSysSocialRelationsEN.Achievement = strAchievement; //成就
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objSysSocialRelationsEN.dicFldComparisonOp.ContainsKey(conSysSocialRelations.Achievement) == false)
{
objSysSocialRelationsEN.dicFldComparisonOp.Add(conSysSocialRelations.Achievement, strComparisonOp);
}
else
{
objSysSocialRelationsEN.dicFldComparisonOp[conSysSocialRelations.Achievement] = strComparisonOp;
}
}
return objSysSocialRelationsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objSysSocialRelationsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsSysSocialRelationsEN SetDetailedDescription(this clsSysSocialRelationsEN objSysSocialRelationsEN, string strDetailedDescription, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strDetailedDescription, 5000, conSysSocialRelations.DetailedDescription);
}
objSysSocialRelationsEN.DetailedDescription = strDetailedDescription; //详细说明
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objSysSocialRelationsEN.dicFldComparisonOp.ContainsKey(conSysSocialRelations.DetailedDescription) == false)
{
objSysSocialRelationsEN.dicFldComparisonOp.Add(conSysSocialRelations.DetailedDescription, strComparisonOp);
}
else
{
objSysSocialRelationsEN.dicFldComparisonOp[conSysSocialRelations.DetailedDescription] = strComparisonOp;
}
}
return objSysSocialRelationsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objSysSocialRelationsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsSysSocialRelationsEN SetLevelId(this clsSysSocialRelationsEN objSysSocialRelationsEN, string strLevelId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strLevelId, 2, conSysSocialRelations.LevelId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strLevelId, 2, conSysSocialRelations.LevelId);
}
objSysSocialRelationsEN.LevelId = strLevelId; //级别Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objSysSocialRelationsEN.dicFldComparisonOp.ContainsKey(conSysSocialRelations.LevelId) == false)
{
objSysSocialRelationsEN.dicFldComparisonOp.Add(conSysSocialRelations.LevelId, strComparisonOp);
}
else
{
objSysSocialRelationsEN.dicFldComparisonOp[conSysSocialRelations.LevelId] = strComparisonOp;
}
}
return objSysSocialRelationsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objSysSocialRelationsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsSysSocialRelationsEN SetUpdUser(this clsSysSocialRelationsEN objSysSocialRelationsEN, string strUpdUser, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdUser, 20, conSysSocialRelations.UpdUser);
}
objSysSocialRelationsEN.UpdUser = strUpdUser; //修改人
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objSysSocialRelationsEN.dicFldComparisonOp.ContainsKey(conSysSocialRelations.UpdUser) == false)
{
objSysSocialRelationsEN.dicFldComparisonOp.Add(conSysSocialRelations.UpdUser, strComparisonOp);
}
else
{
objSysSocialRelationsEN.dicFldComparisonOp[conSysSocialRelations.UpdUser] = strComparisonOp;
}
}
return objSysSocialRelationsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objSysSocialRelationsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsSysSocialRelationsEN SetUpdDate(this clsSysSocialRelationsEN objSysSocialRelationsEN, string strUpdDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdDate, 20, conSysSocialRelations.UpdDate);
}
objSysSocialRelationsEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objSysSocialRelationsEN.dicFldComparisonOp.ContainsKey(conSysSocialRelations.UpdDate) == false)
{
objSysSocialRelationsEN.dicFldComparisonOp.Add(conSysSocialRelations.UpdDate, strComparisonOp);
}
else
{
objSysSocialRelationsEN.dicFldComparisonOp[conSysSocialRelations.UpdDate] = strComparisonOp;
}
}
return objSysSocialRelationsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objSysSocialRelationsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsSysSocialRelationsEN SetIsSubmit(this clsSysSocialRelationsEN objSysSocialRelationsEN, bool bolIsSubmit, string strComparisonOp="")
	{
objSysSocialRelationsEN.IsSubmit = bolIsSubmit; //是否提交
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objSysSocialRelationsEN.dicFldComparisonOp.ContainsKey(conSysSocialRelations.IsSubmit) == false)
{
objSysSocialRelationsEN.dicFldComparisonOp.Add(conSysSocialRelations.IsSubmit, strComparisonOp);
}
else
{
objSysSocialRelationsEN.dicFldComparisonOp[conSysSocialRelations.IsSubmit] = strComparisonOp;
}
}
return objSysSocialRelationsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objSysSocialRelationsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsSysSocialRelationsEN SetOkCount(this clsSysSocialRelationsEN objSysSocialRelationsEN, int? intOkCount, string strComparisonOp="")
	{
objSysSocialRelationsEN.OkCount = intOkCount; //点赞统计
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objSysSocialRelationsEN.dicFldComparisonOp.ContainsKey(conSysSocialRelations.OkCount) == false)
{
objSysSocialRelationsEN.dicFldComparisonOp.Add(conSysSocialRelations.OkCount, strComparisonOp);
}
else
{
objSysSocialRelationsEN.dicFldComparisonOp[conSysSocialRelations.OkCount] = strComparisonOp;
}
}
return objSysSocialRelationsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objSysSocialRelationsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsSysSocialRelationsEN SetCitationCount(this clsSysSocialRelationsEN objSysSocialRelationsEN, int? intCitationCount, string strComparisonOp="")
	{
objSysSocialRelationsEN.CitationCount = intCitationCount; //引用统计
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objSysSocialRelationsEN.dicFldComparisonOp.ContainsKey(conSysSocialRelations.CitationCount) == false)
{
objSysSocialRelationsEN.dicFldComparisonOp.Add(conSysSocialRelations.CitationCount, strComparisonOp);
}
else
{
objSysSocialRelationsEN.dicFldComparisonOp[conSysSocialRelations.CitationCount] = strComparisonOp;
}
}
return objSysSocialRelationsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objSysSocialRelationsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsSysSocialRelationsEN SetVersionCount(this clsSysSocialRelationsEN objSysSocialRelationsEN, int? intVersionCount, string strComparisonOp="")
	{
objSysSocialRelationsEN.VersionCount = intVersionCount; //版本统计
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objSysSocialRelationsEN.dicFldComparisonOp.ContainsKey(conSysSocialRelations.VersionCount) == false)
{
objSysSocialRelationsEN.dicFldComparisonOp.Add(conSysSocialRelations.VersionCount, strComparisonOp);
}
else
{
objSysSocialRelationsEN.dicFldComparisonOp[conSysSocialRelations.VersionCount] = strComparisonOp;
}
}
return objSysSocialRelationsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objSysSocialRelationsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsSysSocialRelationsEN SetIdCurrEduCls(this clsSysSocialRelationsEN objSysSocialRelationsEN, string strIdCurrEduCls, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdCurrEduCls, 8, conSysSocialRelations.IdCurrEduCls);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdCurrEduCls, 8, conSysSocialRelations.IdCurrEduCls);
}
objSysSocialRelationsEN.IdCurrEduCls = strIdCurrEduCls; //教学班流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objSysSocialRelationsEN.dicFldComparisonOp.ContainsKey(conSysSocialRelations.IdCurrEduCls) == false)
{
objSysSocialRelationsEN.dicFldComparisonOp.Add(conSysSocialRelations.IdCurrEduCls, strComparisonOp);
}
else
{
objSysSocialRelationsEN.dicFldComparisonOp[conSysSocialRelations.IdCurrEduCls] = strComparisonOp;
}
}
return objSysSocialRelationsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objSysSocialRelationsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsSysSocialRelationsEN SetMemo(this clsSysSocialRelationsEN objSysSocialRelationsEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, conSysSocialRelations.Memo);
}
objSysSocialRelationsEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objSysSocialRelationsEN.dicFldComparisonOp.ContainsKey(conSysSocialRelations.Memo) == false)
{
objSysSocialRelationsEN.dicFldComparisonOp.Add(conSysSocialRelations.Memo, strComparisonOp);
}
else
{
objSysSocialRelationsEN.dicFldComparisonOp[conSysSocialRelations.Memo] = strComparisonOp;
}
}
return objSysSocialRelationsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objSysSocialRelationsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsSysSocialRelationsEN SetAppraiseCount(this clsSysSocialRelationsEN objSysSocialRelationsEN, int? intAppraiseCount, string strComparisonOp="")
	{
objSysSocialRelationsEN.AppraiseCount = intAppraiseCount; //评论数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objSysSocialRelationsEN.dicFldComparisonOp.ContainsKey(conSysSocialRelations.AppraiseCount) == false)
{
objSysSocialRelationsEN.dicFldComparisonOp.Add(conSysSocialRelations.AppraiseCount, strComparisonOp);
}
else
{
objSysSocialRelationsEN.dicFldComparisonOp[conSysSocialRelations.AppraiseCount] = strComparisonOp;
}
}
return objSysSocialRelationsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objSysSocialRelationsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsSysSocialRelationsEN SetScore(this clsSysSocialRelationsEN objSysSocialRelationsEN, float? fltScore, string strComparisonOp="")
	{
objSysSocialRelationsEN.Score = fltScore; //评分
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objSysSocialRelationsEN.dicFldComparisonOp.ContainsKey(conSysSocialRelations.Score) == false)
{
objSysSocialRelationsEN.dicFldComparisonOp.Add(conSysSocialRelations.Score, strComparisonOp);
}
else
{
objSysSocialRelationsEN.dicFldComparisonOp[conSysSocialRelations.Score] = strComparisonOp;
}
}
return objSysSocialRelationsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objSysSocialRelationsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsSysSocialRelationsEN SetStuScore(this clsSysSocialRelationsEN objSysSocialRelationsEN, float? fltStuScore, string strComparisonOp="")
	{
objSysSocialRelationsEN.StuScore = fltStuScore; //学生平均分
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objSysSocialRelationsEN.dicFldComparisonOp.ContainsKey(conSysSocialRelations.StuScore) == false)
{
objSysSocialRelationsEN.dicFldComparisonOp.Add(conSysSocialRelations.StuScore, strComparisonOp);
}
else
{
objSysSocialRelationsEN.dicFldComparisonOp[conSysSocialRelations.StuScore] = strComparisonOp;
}
}
return objSysSocialRelationsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objSysSocialRelationsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsSysSocialRelationsEN SetTeaScore(this clsSysSocialRelationsEN objSysSocialRelationsEN, float? fltTeaScore, string strComparisonOp="")
	{
objSysSocialRelationsEN.TeaScore = fltTeaScore; //教师评分
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objSysSocialRelationsEN.dicFldComparisonOp.ContainsKey(conSysSocialRelations.TeaScore) == false)
{
objSysSocialRelationsEN.dicFldComparisonOp.Add(conSysSocialRelations.TeaScore, strComparisonOp);
}
else
{
objSysSocialRelationsEN.dicFldComparisonOp[conSysSocialRelations.TeaScore] = strComparisonOp;
}
}
return objSysSocialRelationsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objSysSocialRelationsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsSysSocialRelationsEN SetCitationId(this clsSysSocialRelationsEN objSysSocialRelationsEN, string strCitationId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCitationId, 8, conSysSocialRelations.CitationId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strCitationId, 8, conSysSocialRelations.CitationId);
}
objSysSocialRelationsEN.CitationId = strCitationId; //引用Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objSysSocialRelationsEN.dicFldComparisonOp.ContainsKey(conSysSocialRelations.CitationId) == false)
{
objSysSocialRelationsEN.dicFldComparisonOp.Add(conSysSocialRelations.CitationId, strComparisonOp);
}
else
{
objSysSocialRelationsEN.dicFldComparisonOp[conSysSocialRelations.CitationId] = strComparisonOp;
}
}
return objSysSocialRelationsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objSysSocialRelationsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsSysSocialRelationsEN SetCreateDate(this clsSysSocialRelationsEN objSysSocialRelationsEN, string strCreateDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCreateDate, 20, conSysSocialRelations.CreateDate);
}
objSysSocialRelationsEN.CreateDate = strCreateDate; //建立日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objSysSocialRelationsEN.dicFldComparisonOp.ContainsKey(conSysSocialRelations.CreateDate) == false)
{
objSysSocialRelationsEN.dicFldComparisonOp.Add(conSysSocialRelations.CreateDate, strComparisonOp);
}
else
{
objSysSocialRelationsEN.dicFldComparisonOp[conSysSocialRelations.CreateDate] = strComparisonOp;
}
}
return objSysSocialRelationsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objSysSocialRelationsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsSysSocialRelationsEN SetShareId(this clsSysSocialRelationsEN objSysSocialRelationsEN, string strShareId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strShareId, 2, conSysSocialRelations.ShareId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strShareId, 2, conSysSocialRelations.ShareId);
}
objSysSocialRelationsEN.ShareId = strShareId; //分享Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objSysSocialRelationsEN.dicFldComparisonOp.ContainsKey(conSysSocialRelations.ShareId) == false)
{
objSysSocialRelationsEN.dicFldComparisonOp.Add(conSysSocialRelations.ShareId, strComparisonOp);
}
else
{
objSysSocialRelationsEN.dicFldComparisonOp[conSysSocialRelations.ShareId] = strComparisonOp;
}
}
return objSysSocialRelationsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objSysSocialRelationsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsSysSocialRelationsEN SetPdfContent(this clsSysSocialRelationsEN objSysSocialRelationsEN, string strPdfContent, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPdfContent, 2000, conSysSocialRelations.PdfContent);
}
objSysSocialRelationsEN.PdfContent = strPdfContent; //Pdf内容
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objSysSocialRelationsEN.dicFldComparisonOp.ContainsKey(conSysSocialRelations.PdfContent) == false)
{
objSysSocialRelationsEN.dicFldComparisonOp.Add(conSysSocialRelations.PdfContent, strComparisonOp);
}
else
{
objSysSocialRelationsEN.dicFldComparisonOp[conSysSocialRelations.PdfContent] = strComparisonOp;
}
}
return objSysSocialRelationsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objSysSocialRelationsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsSysSocialRelationsEN SetPdfPageNum(this clsSysSocialRelationsEN objSysSocialRelationsEN, int? intPdfPageNum, string strComparisonOp="")
	{
objSysSocialRelationsEN.PdfPageNum = intPdfPageNum; //Pdf页码
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objSysSocialRelationsEN.dicFldComparisonOp.ContainsKey(conSysSocialRelations.PdfPageNum) == false)
{
objSysSocialRelationsEN.dicFldComparisonOp.Add(conSysSocialRelations.PdfPageNum, strComparisonOp);
}
else
{
objSysSocialRelationsEN.dicFldComparisonOp[conSysSocialRelations.PdfPageNum] = strComparisonOp;
}
}
return objSysSocialRelationsEN;
	}

 /// <summary>
 /// 修改记录存盘到数据表中
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_UpdateRecordEx)
 /// </summary>
 /// <param name = "objSysSocialRelationsEN">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool UpdateRecordEx(this clsSysSocialRelationsEN objSysSocialRelationsEN)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
try
{
//1、检查传进去的对象属性是否合法
objSysSocialRelationsEN.CheckPropertyNew();
clsSysSocialRelationsEN objSysSocialRelationsCond = new clsSysSocialRelationsEN();
string strCondition = objSysSocialRelationsCond
.SetSocialId(objSysSocialRelationsEN.SocialId, "<>")
.SetSocialId(objSysSocialRelationsEN.SocialId, "=")
.GetCombineCondition();
objSysSocialRelationsEN._IsCheckProperty = true;
bool bolIsExist = clsSysSocialRelationsBL.IsExistRecord(strCondition);
if (bolIsExist)
{
strMsg = "(SocialId)不能重复!";
throw new Exception(strMsg);
}
//4、把数据实体层的数据存贮到数据库中
objSysSocialRelationsEN.Update();
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
 /// <param name = "objSysSocialRelations">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool EditRecordEx(this clsSysSocialRelationsEN objSysSocialRelations)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
clsSysSocialRelationsEN objSysSocialRelationsCond = new clsSysSocialRelationsEN();
string strCondition = objSysSocialRelationsCond
.SetSocialId(objSysSocialRelations.SocialId, "=")
.GetCombineCondition();
objSysSocialRelations._IsCheckProperty = true;
bool bolIsExist = clsSysSocialRelationsBL.IsExistRecord(strCondition);
if (bolIsExist)
{
objSysSocialRelations.SocialId = clsSysSocialRelationsBL.GetFirstID_S(strCondition);
objSysSocialRelations.UpdateWithCondition(strCondition);
}
else
{
objSysSocialRelations.SocialId = clsSysSocialRelationsBL.GetMaxStrId_S();
objSysSocialRelations.AddNewRecord();
}
return true; 
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_Update)
 /// </summary>
 /// <param name = "objSysSocialRelationsEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsSysSocialRelationsEN objSysSocialRelationsEN)
{
 if (string.IsNullOrEmpty(objSysSocialRelationsEN.SocialId) == true)
 {
string strMsg = string.Format("(errid:Busi000095)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsSysSocialRelationsBL.SysSocialRelationsDA.UpdateBySql2(objSysSocialRelationsEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsSysSocialRelationsBL.ReFreshCache(objSysSocialRelationsEN.IdCurrEduCls);

if (clsSysSocialRelationsBL.relatedActions != null)
{
clsSysSocialRelationsBL.relatedActions.UpdRelaTabDate(objSysSocialRelationsEN.SocialId, "SetUpdDate");
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
 /// <param name = "objSysSocialRelationsEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsSysSocialRelationsEN objSysSocialRelationsEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (string.IsNullOrEmpty(objSysSocialRelationsEN.SocialId) == true)
 {
string strMsg = string.Format("(errid:Busi000087)修改记录时关键字不能为空!(带事务处理)(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsSysSocialRelationsBL.SysSocialRelationsDA.UpdateBySql2(objSysSocialRelationsEN, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsSysSocialRelationsBL.ReFreshCache(objSysSocialRelationsEN.IdCurrEduCls);

if (clsSysSocialRelationsBL.relatedActions != null)
{
clsSysSocialRelationsBL.relatedActions.UpdRelaTabDate(objSysSocialRelationsEN.SocialId, "SetUpdDate");
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
 /// <param name = "objSysSocialRelationsEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsSysSocialRelationsEN objSysSocialRelationsEN, string strWhereCond)
{
try
{
bool bolResult = clsSysSocialRelationsBL.SysSocialRelationsDA.UpdateBySqlWithCondition(objSysSocialRelationsEN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsSysSocialRelationsBL.ReFreshCache(objSysSocialRelationsEN.IdCurrEduCls);

if (clsSysSocialRelationsBL.relatedActions != null)
{
clsSysSocialRelationsBL.relatedActions.UpdRelaTabDate(objSysSocialRelationsEN.SocialId, "SetUpdDate");
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
 /// <param name = "objSysSocialRelationsEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsSysSocialRelationsEN objSysSocialRelationsEN, string strWhereCond, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
bool bolResult = clsSysSocialRelationsBL.SysSocialRelationsDA.UpdateBySqlWithConditionTransaction(objSysSocialRelationsEN, strWhereCond, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsSysSocialRelationsBL.ReFreshCache(objSysSocialRelationsEN.IdCurrEduCls);

if (clsSysSocialRelationsBL.relatedActions != null)
{
clsSysSocialRelationsBL.relatedActions.UpdRelaTabDate(objSysSocialRelationsEN.SocialId, "SetUpdDate");
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
 /// <param name = "strSocialId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int Delete(this clsSysSocialRelationsEN objSysSocialRelationsEN)
{
try
{
int intRecNum = clsSysSocialRelationsBL.SysSocialRelationsDA.DelRecord(objSysSocialRelationsEN.SocialId);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsSysSocialRelationsBL.ReFreshCache(objSysSocialRelationsEN.IdCurrEduCls);

if (clsSysSocialRelationsBL.relatedActions != null)
{
clsSysSocialRelationsBL.relatedActions.UpdRelaTabDate(objSysSocialRelationsEN.SocialId, "SetUpdDate");
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
 /// <param name = "objSysSocialRelationsENS">源对象</param>
 /// <param name = "objSysSocialRelationsENT">目标对象</param>
 public static void CopyTo(this clsSysSocialRelationsEN objSysSocialRelationsENS, clsSysSocialRelationsEN objSysSocialRelationsENT)
{
try
{
objSysSocialRelationsENT.SocialId = objSysSocialRelationsENS.SocialId; //社会Id
objSysSocialRelationsENT.FullName = objSysSocialRelationsENS.FullName; //姓名
objSysSocialRelationsENT.Nationality = objSysSocialRelationsENS.Nationality; //国籍
objSysSocialRelationsENT.WorkUnit = objSysSocialRelationsENS.WorkUnit; //工作单位
objSysSocialRelationsENT.Major = objSysSocialRelationsENS.Major; //专业
objSysSocialRelationsENT.Achievement = objSysSocialRelationsENS.Achievement; //成就
objSysSocialRelationsENT.DetailedDescription = objSysSocialRelationsENS.DetailedDescription; //详细说明
objSysSocialRelationsENT.LevelId = objSysSocialRelationsENS.LevelId; //级别Id
objSysSocialRelationsENT.UpdUser = objSysSocialRelationsENS.UpdUser; //修改人
objSysSocialRelationsENT.UpdDate = objSysSocialRelationsENS.UpdDate; //修改日期
objSysSocialRelationsENT.IsSubmit = objSysSocialRelationsENS.IsSubmit; //是否提交
objSysSocialRelationsENT.OkCount = objSysSocialRelationsENS.OkCount; //点赞统计
objSysSocialRelationsENT.CitationCount = objSysSocialRelationsENS.CitationCount; //引用统计
objSysSocialRelationsENT.VersionCount = objSysSocialRelationsENS.VersionCount; //版本统计
objSysSocialRelationsENT.IdCurrEduCls = objSysSocialRelationsENS.IdCurrEduCls; //教学班流水号
objSysSocialRelationsENT.Memo = objSysSocialRelationsENS.Memo; //备注
objSysSocialRelationsENT.AppraiseCount = objSysSocialRelationsENS.AppraiseCount; //评论数
objSysSocialRelationsENT.Score = objSysSocialRelationsENS.Score; //评分
objSysSocialRelationsENT.StuScore = objSysSocialRelationsENS.StuScore; //学生平均分
objSysSocialRelationsENT.TeaScore = objSysSocialRelationsENS.TeaScore; //教师评分
objSysSocialRelationsENT.CitationId = objSysSocialRelationsENS.CitationId; //引用Id
objSysSocialRelationsENT.CreateDate = objSysSocialRelationsENS.CreateDate; //建立日期
objSysSocialRelationsENT.ShareId = objSysSocialRelationsENS.ShareId; //分享Id
objSysSocialRelationsENT.PdfContent = objSysSocialRelationsENS.PdfContent; //Pdf内容
objSysSocialRelationsENT.PdfPageNum = objSysSocialRelationsENS.PdfPageNum; //Pdf页码
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
 /// <param name = "objSysSocialRelationsENS">源对象</param>
 /// <returns>目标对象=>clsSysSocialRelationsEN:objSysSocialRelationsENT</returns>
 public static clsSysSocialRelationsEN CopyTo(this clsSysSocialRelationsEN objSysSocialRelationsENS)
{
try
{
 clsSysSocialRelationsEN objSysSocialRelationsENT = new clsSysSocialRelationsEN()
{
SocialId = objSysSocialRelationsENS.SocialId, //社会Id
FullName = objSysSocialRelationsENS.FullName, //姓名
Nationality = objSysSocialRelationsENS.Nationality, //国籍
WorkUnit = objSysSocialRelationsENS.WorkUnit, //工作单位
Major = objSysSocialRelationsENS.Major, //专业
Achievement = objSysSocialRelationsENS.Achievement, //成就
DetailedDescription = objSysSocialRelationsENS.DetailedDescription, //详细说明
LevelId = objSysSocialRelationsENS.LevelId, //级别Id
UpdUser = objSysSocialRelationsENS.UpdUser, //修改人
UpdDate = objSysSocialRelationsENS.UpdDate, //修改日期
IsSubmit = objSysSocialRelationsENS.IsSubmit, //是否提交
OkCount = objSysSocialRelationsENS.OkCount, //点赞统计
CitationCount = objSysSocialRelationsENS.CitationCount, //引用统计
VersionCount = objSysSocialRelationsENS.VersionCount, //版本统计
IdCurrEduCls = objSysSocialRelationsENS.IdCurrEduCls, //教学班流水号
Memo = objSysSocialRelationsENS.Memo, //备注
AppraiseCount = objSysSocialRelationsENS.AppraiseCount, //评论数
Score = objSysSocialRelationsENS.Score, //评分
StuScore = objSysSocialRelationsENS.StuScore, //学生平均分
TeaScore = objSysSocialRelationsENS.TeaScore, //教师评分
CitationId = objSysSocialRelationsENS.CitationId, //引用Id
CreateDate = objSysSocialRelationsENS.CreateDate, //建立日期
ShareId = objSysSocialRelationsENS.ShareId, //分享Id
PdfContent = objSysSocialRelationsENS.PdfContent, //Pdf内容
PdfPageNum = objSysSocialRelationsENS.PdfPageNum, //Pdf页码
};
 return objSysSocialRelationsENT;
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
public static void CheckPropertyNew(this clsSysSocialRelationsEN objSysSocialRelationsEN)
{
 clsSysSocialRelationsBL.SysSocialRelationsDA.CheckPropertyNew(objSysSocialRelationsEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(this clsSysSocialRelationsEN objSysSocialRelationsEN)
{
 clsSysSocialRelationsBL.SysSocialRelationsDA.CheckProperty4Condition(objSysSocialRelationsEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsSysSocialRelationsEN objSysSocialRelationsCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objSysSocialRelationsCond.IsUpdated(conSysSocialRelations.SocialId) == true)
{
string strComparisonOpSocialId = objSysSocialRelationsCond.dicFldComparisonOp[conSysSocialRelations.SocialId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conSysSocialRelations.SocialId, objSysSocialRelationsCond.SocialId, strComparisonOpSocialId);
}
if (objSysSocialRelationsCond.IsUpdated(conSysSocialRelations.FullName) == true)
{
string strComparisonOpFullName = objSysSocialRelationsCond.dicFldComparisonOp[conSysSocialRelations.FullName];
strWhereCond += string.Format(" And {0} {2} '{1}'", conSysSocialRelations.FullName, objSysSocialRelationsCond.FullName, strComparisonOpFullName);
}
if (objSysSocialRelationsCond.IsUpdated(conSysSocialRelations.Nationality) == true)
{
string strComparisonOpNationality = objSysSocialRelationsCond.dicFldComparisonOp[conSysSocialRelations.Nationality];
strWhereCond += string.Format(" And {0} {2} '{1}'", conSysSocialRelations.Nationality, objSysSocialRelationsCond.Nationality, strComparisonOpNationality);
}
if (objSysSocialRelationsCond.IsUpdated(conSysSocialRelations.WorkUnit) == true)
{
string strComparisonOpWorkUnit = objSysSocialRelationsCond.dicFldComparisonOp[conSysSocialRelations.WorkUnit];
strWhereCond += string.Format(" And {0} {2} '{1}'", conSysSocialRelations.WorkUnit, objSysSocialRelationsCond.WorkUnit, strComparisonOpWorkUnit);
}
if (objSysSocialRelationsCond.IsUpdated(conSysSocialRelations.Major) == true)
{
string strComparisonOpMajor = objSysSocialRelationsCond.dicFldComparisonOp[conSysSocialRelations.Major];
strWhereCond += string.Format(" And {0} {2} '{1}'", conSysSocialRelations.Major, objSysSocialRelationsCond.Major, strComparisonOpMajor);
}
if (objSysSocialRelationsCond.IsUpdated(conSysSocialRelations.Achievement) == true)
{
string strComparisonOpAchievement = objSysSocialRelationsCond.dicFldComparisonOp[conSysSocialRelations.Achievement];
strWhereCond += string.Format(" And {0} {2} '{1}'", conSysSocialRelations.Achievement, objSysSocialRelationsCond.Achievement, strComparisonOpAchievement);
}
if (objSysSocialRelationsCond.IsUpdated(conSysSocialRelations.DetailedDescription) == true)
{
string strComparisonOpDetailedDescription = objSysSocialRelationsCond.dicFldComparisonOp[conSysSocialRelations.DetailedDescription];
strWhereCond += string.Format(" And {0} {2} '{1}'", conSysSocialRelations.DetailedDescription, objSysSocialRelationsCond.DetailedDescription, strComparisonOpDetailedDescription);
}
if (objSysSocialRelationsCond.IsUpdated(conSysSocialRelations.LevelId) == true)
{
string strComparisonOpLevelId = objSysSocialRelationsCond.dicFldComparisonOp[conSysSocialRelations.LevelId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conSysSocialRelations.LevelId, objSysSocialRelationsCond.LevelId, strComparisonOpLevelId);
}
if (objSysSocialRelationsCond.IsUpdated(conSysSocialRelations.UpdUser) == true)
{
string strComparisonOpUpdUser = objSysSocialRelationsCond.dicFldComparisonOp[conSysSocialRelations.UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", conSysSocialRelations.UpdUser, objSysSocialRelationsCond.UpdUser, strComparisonOpUpdUser);
}
if (objSysSocialRelationsCond.IsUpdated(conSysSocialRelations.UpdDate) == true)
{
string strComparisonOpUpdDate = objSysSocialRelationsCond.dicFldComparisonOp[conSysSocialRelations.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conSysSocialRelations.UpdDate, objSysSocialRelationsCond.UpdDate, strComparisonOpUpdDate);
}
if (objSysSocialRelationsCond.IsUpdated(conSysSocialRelations.IsSubmit) == true)
{
if (objSysSocialRelationsCond.IsSubmit == true)
{
strWhereCond += string.Format(" And {0} = '1'", conSysSocialRelations.IsSubmit);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conSysSocialRelations.IsSubmit);
}
}
if (objSysSocialRelationsCond.IsUpdated(conSysSocialRelations.OkCount) == true)
{
string strComparisonOpOkCount = objSysSocialRelationsCond.dicFldComparisonOp[conSysSocialRelations.OkCount];
strWhereCond += string.Format(" And {0} {2} {1}", conSysSocialRelations.OkCount, objSysSocialRelationsCond.OkCount, strComparisonOpOkCount);
}
if (objSysSocialRelationsCond.IsUpdated(conSysSocialRelations.CitationCount) == true)
{
string strComparisonOpCitationCount = objSysSocialRelationsCond.dicFldComparisonOp[conSysSocialRelations.CitationCount];
strWhereCond += string.Format(" And {0} {2} {1}", conSysSocialRelations.CitationCount, objSysSocialRelationsCond.CitationCount, strComparisonOpCitationCount);
}
if (objSysSocialRelationsCond.IsUpdated(conSysSocialRelations.VersionCount) == true)
{
string strComparisonOpVersionCount = objSysSocialRelationsCond.dicFldComparisonOp[conSysSocialRelations.VersionCount];
strWhereCond += string.Format(" And {0} {2} {1}", conSysSocialRelations.VersionCount, objSysSocialRelationsCond.VersionCount, strComparisonOpVersionCount);
}
if (objSysSocialRelationsCond.IsUpdated(conSysSocialRelations.IdCurrEduCls) == true)
{
string strComparisonOpIdCurrEduCls = objSysSocialRelationsCond.dicFldComparisonOp[conSysSocialRelations.IdCurrEduCls];
strWhereCond += string.Format(" And {0} {2} '{1}'", conSysSocialRelations.IdCurrEduCls, objSysSocialRelationsCond.IdCurrEduCls, strComparisonOpIdCurrEduCls);
}
if (objSysSocialRelationsCond.IsUpdated(conSysSocialRelations.Memo) == true)
{
string strComparisonOpMemo = objSysSocialRelationsCond.dicFldComparisonOp[conSysSocialRelations.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", conSysSocialRelations.Memo, objSysSocialRelationsCond.Memo, strComparisonOpMemo);
}
if (objSysSocialRelationsCond.IsUpdated(conSysSocialRelations.AppraiseCount) == true)
{
string strComparisonOpAppraiseCount = objSysSocialRelationsCond.dicFldComparisonOp[conSysSocialRelations.AppraiseCount];
strWhereCond += string.Format(" And {0} {2} {1}", conSysSocialRelations.AppraiseCount, objSysSocialRelationsCond.AppraiseCount, strComparisonOpAppraiseCount);
}
if (objSysSocialRelationsCond.IsUpdated(conSysSocialRelations.Score) == true)
{
string strComparisonOpScore = objSysSocialRelationsCond.dicFldComparisonOp[conSysSocialRelations.Score];
strWhereCond += string.Format(" And {0} {2} {1}", conSysSocialRelations.Score, objSysSocialRelationsCond.Score, strComparisonOpScore);
}
if (objSysSocialRelationsCond.IsUpdated(conSysSocialRelations.StuScore) == true)
{
string strComparisonOpStuScore = objSysSocialRelationsCond.dicFldComparisonOp[conSysSocialRelations.StuScore];
strWhereCond += string.Format(" And {0} {2} {1}", conSysSocialRelations.StuScore, objSysSocialRelationsCond.StuScore, strComparisonOpStuScore);
}
if (objSysSocialRelationsCond.IsUpdated(conSysSocialRelations.TeaScore) == true)
{
string strComparisonOpTeaScore = objSysSocialRelationsCond.dicFldComparisonOp[conSysSocialRelations.TeaScore];
strWhereCond += string.Format(" And {0} {2} {1}", conSysSocialRelations.TeaScore, objSysSocialRelationsCond.TeaScore, strComparisonOpTeaScore);
}
if (objSysSocialRelationsCond.IsUpdated(conSysSocialRelations.CitationId) == true)
{
string strComparisonOpCitationId = objSysSocialRelationsCond.dicFldComparisonOp[conSysSocialRelations.CitationId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conSysSocialRelations.CitationId, objSysSocialRelationsCond.CitationId, strComparisonOpCitationId);
}
if (objSysSocialRelationsCond.IsUpdated(conSysSocialRelations.CreateDate) == true)
{
string strComparisonOpCreateDate = objSysSocialRelationsCond.dicFldComparisonOp[conSysSocialRelations.CreateDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conSysSocialRelations.CreateDate, objSysSocialRelationsCond.CreateDate, strComparisonOpCreateDate);
}
if (objSysSocialRelationsCond.IsUpdated(conSysSocialRelations.ShareId) == true)
{
string strComparisonOpShareId = objSysSocialRelationsCond.dicFldComparisonOp[conSysSocialRelations.ShareId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conSysSocialRelations.ShareId, objSysSocialRelationsCond.ShareId, strComparisonOpShareId);
}
if (objSysSocialRelationsCond.IsUpdated(conSysSocialRelations.PdfContent) == true)
{
string strComparisonOpPdfContent = objSysSocialRelationsCond.dicFldComparisonOp[conSysSocialRelations.PdfContent];
strWhereCond += string.Format(" And {0} {2} '{1}'", conSysSocialRelations.PdfContent, objSysSocialRelationsCond.PdfContent, strComparisonOpPdfContent);
}
if (objSysSocialRelationsCond.IsUpdated(conSysSocialRelations.PdfPageNum) == true)
{
string strComparisonOpPdfPageNum = objSysSocialRelationsCond.dicFldComparisonOp[conSysSocialRelations.PdfPageNum];
strWhereCond += string.Format(" And {0} {2} {1}", conSysSocialRelations.PdfPageNum, objSysSocialRelationsCond.PdfPageNum, strComparisonOpPdfPageNum);
}
 return strWhereCond;
}

 /// <summary>
 /// 检查唯一性(Uniqueness)--SysSocialRelations(社会关系表), 如果不唯一,即存在相同的记录,就返回False
 /// 唯一性条件:SocialId
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckConstraint)
 /// </summary>
 /// <param name = "objSysSocialRelationsEN">要求唯一的对象</param>
 /// <returns></returns>
public static bool CheckUniqueness(this clsSysSocialRelationsEN objSysSocialRelationsEN)
{
//检测记录是否存在
bool bolIsUniqueness;
StringBuilder sbCondition = new StringBuilder();
if (objSysSocialRelationsEN == null) return true;
if (objSysSocialRelationsEN.SocialId == null || objSysSocialRelationsEN.SocialId == "")
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and SocialId = '{0}'", objSysSocialRelationsEN.SocialId);
if (clsSysSocialRelationsBL.IsExistRecord(sbCondition.ToString())  ==  true)
{
 bolIsUniqueness = false;
}
else
{
 bolIsUniqueness = true;
}
}
 else {
sbCondition.AppendFormat("SocialId !=  '{0}'", objSysSocialRelationsEN.SocialId);
 sbCondition.AppendFormat(" and SocialId = '{0}'", objSysSocialRelationsEN.SocialId);
if (clsSysSocialRelationsBL.IsExistRecord(sbCondition.ToString())  ==  true)
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
 /// 获取唯一性条件串--SysSocialRelations(社会关系表), 即由对象中唯一性条件字段关键字与值组成的条件串
 /// 唯一性条件:SocialId
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetConditionString4Constraint)
 /// </summary>
 /// <param name = "objSysSocialRelationsEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(this clsSysSocialRelationsEN objSysSocialRelationsEN)
{
//检测记录是否存在
StringBuilder sbCondition = new StringBuilder();
if (objSysSocialRelationsEN == null) return "";
if (objSysSocialRelationsEN.SocialId == null || objSysSocialRelationsEN.SocialId == "")
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and SocialId = '{0}'", objSysSocialRelationsEN.SocialId);
return sbCondition.ToString();
}
 else {
sbCondition.AppendFormat("SocialId !=  '{0}'", objSysSocialRelationsEN.SocialId);
 sbCondition.AppendFormat(" and SocialId = '{0}'", objSysSocialRelationsEN.SocialId);
 return sbCondition.ToString();
}
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_SysSocialRelations
{
public virtual bool UpdRelaTabDate(string strSocialId, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// 社会关系表(SysSocialRelations)
 /// 数据源类型:表
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsSysSocialRelationsBL
{
public static RelatedActions_SysSocialRelations relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsSysSocialRelationsDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsSysSocialRelationsDA SysSocialRelationsDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsSysSocialRelationsDA();
}
return uniqueInstance;
}
}

 /// <summary>
/// 专门在逻辑层用于处理缓存等公共函数的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineObjCommFun4BL)
/// </summary>
public static clsCommFun4BLV2 objCommFun4BL = null;

 /// <summary>
 /// 类的构造函数
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ClassConstructor1)
 /// </summary>
 public clsSysSocialRelationsBL()
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
if (string.IsNullOrEmpty(clsSysSocialRelationsEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsSysSocialRelationsEN._ConnectString);
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
public static DataTable GetDataTable_SysSocialRelations(string strWhereCond)
{
DataTable objDT;
try
{
objDT = SysSocialRelationsDA.GetDataTable_SysSocialRelations(strWhereCond);
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
objDT = SysSocialRelationsDA.GetDataTable(strWhereCond);
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
objDT = SysSocialRelationsDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = SysSocialRelationsDA.GetDataTable(strWhereCond, strTabName);
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
objDT = SysSocialRelationsDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = SysSocialRelationsDA.GetDataTable_Top(objTopPara);
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
objDT = SysSocialRelationsDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = SysSocialRelationsDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = SysSocialRelationsDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
 /// <param name = "arrSocialIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static List<clsSysSocialRelationsEN> GetObjLstBySocialIdLst(List<string> arrSocialIdLst)
{
List<clsSysSocialRelationsEN> arrObjLst = new List<clsSysSocialRelationsEN>(); 
System.Data.DataTable objDT; 
 string strSqlConditionStr = clsArray.GetSqlInStrByArray(arrSocialIdLst, true);
 string strWhereCond = string.Format("SocialId in ({0})", strSqlConditionStr);
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsSysSocialRelationsEN objSysSocialRelationsEN = new clsSysSocialRelationsEN();
try
{
objSysSocialRelationsEN.SocialId = objRow[conSysSocialRelations.SocialId].ToString().Trim(); //社会Id
objSysSocialRelationsEN.FullName = objRow[conSysSocialRelations.FullName] == DBNull.Value ? null : objRow[conSysSocialRelations.FullName].ToString().Trim(); //姓名
objSysSocialRelationsEN.Nationality = objRow[conSysSocialRelations.Nationality] == DBNull.Value ? null : objRow[conSysSocialRelations.Nationality].ToString().Trim(); //国籍
objSysSocialRelationsEN.WorkUnit = objRow[conSysSocialRelations.WorkUnit] == DBNull.Value ? null : objRow[conSysSocialRelations.WorkUnit].ToString().Trim(); //工作单位
objSysSocialRelationsEN.Major = objRow[conSysSocialRelations.Major] == DBNull.Value ? null : objRow[conSysSocialRelations.Major].ToString().Trim(); //专业
objSysSocialRelationsEN.Achievement = objRow[conSysSocialRelations.Achievement] == DBNull.Value ? null : objRow[conSysSocialRelations.Achievement].ToString().Trim(); //成就
objSysSocialRelationsEN.DetailedDescription = objRow[conSysSocialRelations.DetailedDescription] == DBNull.Value ? null : objRow[conSysSocialRelations.DetailedDescription].ToString().Trim(); //详细说明
objSysSocialRelationsEN.LevelId = objRow[conSysSocialRelations.LevelId] == DBNull.Value ? null : objRow[conSysSocialRelations.LevelId].ToString().Trim(); //级别Id
objSysSocialRelationsEN.UpdUser = objRow[conSysSocialRelations.UpdUser] == DBNull.Value ? null : objRow[conSysSocialRelations.UpdUser].ToString().Trim(); //修改人
objSysSocialRelationsEN.UpdDate = objRow[conSysSocialRelations.UpdDate] == DBNull.Value ? null : objRow[conSysSocialRelations.UpdDate].ToString().Trim(); //修改日期
objSysSocialRelationsEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[conSysSocialRelations.IsSubmit].ToString().Trim()); //是否提交
objSysSocialRelationsEN.OkCount = objRow[conSysSocialRelations.OkCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conSysSocialRelations.OkCount].ToString().Trim()); //点赞统计
objSysSocialRelationsEN.CitationCount = objRow[conSysSocialRelations.CitationCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conSysSocialRelations.CitationCount].ToString().Trim()); //引用统计
objSysSocialRelationsEN.VersionCount = objRow[conSysSocialRelations.VersionCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conSysSocialRelations.VersionCount].ToString().Trim()); //版本统计
objSysSocialRelationsEN.IdCurrEduCls = objRow[conSysSocialRelations.IdCurrEduCls] == DBNull.Value ? null : objRow[conSysSocialRelations.IdCurrEduCls].ToString().Trim(); //教学班流水号
objSysSocialRelationsEN.Memo = objRow[conSysSocialRelations.Memo] == DBNull.Value ? null : objRow[conSysSocialRelations.Memo].ToString().Trim(); //备注
objSysSocialRelationsEN.AppraiseCount = objRow[conSysSocialRelations.AppraiseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conSysSocialRelations.AppraiseCount].ToString().Trim()); //评论数
objSysSocialRelationsEN.Score = objRow[conSysSocialRelations.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conSysSocialRelations.Score].ToString().Trim()); //评分
objSysSocialRelationsEN.StuScore = objRow[conSysSocialRelations.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conSysSocialRelations.StuScore].ToString().Trim()); //学生平均分
objSysSocialRelationsEN.TeaScore = objRow[conSysSocialRelations.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conSysSocialRelations.TeaScore].ToString().Trim()); //教师评分
objSysSocialRelationsEN.CitationId = objRow[conSysSocialRelations.CitationId] == DBNull.Value ? null : objRow[conSysSocialRelations.CitationId].ToString().Trim(); //引用Id
objSysSocialRelationsEN.CreateDate = objRow[conSysSocialRelations.CreateDate] == DBNull.Value ? null : objRow[conSysSocialRelations.CreateDate].ToString().Trim(); //建立日期
objSysSocialRelationsEN.ShareId = objRow[conSysSocialRelations.ShareId] == DBNull.Value ? null : objRow[conSysSocialRelations.ShareId].ToString().Trim(); //分享Id
objSysSocialRelationsEN.PdfContent = objRow[conSysSocialRelations.PdfContent] == DBNull.Value ? null : objRow[conSysSocialRelations.PdfContent].ToString().Trim(); //Pdf内容
objSysSocialRelationsEN.PdfPageNum = objRow[conSysSocialRelations.PdfPageNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conSysSocialRelations.PdfPageNum].ToString().Trim()); //Pdf页码
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objSysSocialRelationsEN.SocialId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objSysSocialRelationsEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrSocialIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsSysSocialRelationsEN> GetObjLstBySocialIdLstCache(List<string> arrSocialIdLst, string strIdCurrEduCls)
{
string strKey = string.Format("{0}_{1}", clsSysSocialRelationsEN._CurrTabName, strIdCurrEduCls);
List<clsSysSocialRelationsEN> arrSysSocialRelationsObjLstCache = GetObjLstCache(strIdCurrEduCls);
IEnumerable <clsSysSocialRelationsEN> arrSysSocialRelationsObjLst_Sel =
arrSysSocialRelationsObjLstCache
.Where(x => arrSocialIdLst.Contains(x.SocialId));
return arrSysSocialRelationsObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsSysSocialRelationsEN> GetObjLst(string strWhereCond)
{
List<clsSysSocialRelationsEN> arrObjLst = new List<clsSysSocialRelationsEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsSysSocialRelationsEN objSysSocialRelationsEN = new clsSysSocialRelationsEN();
try
{
objSysSocialRelationsEN.SocialId = objRow[conSysSocialRelations.SocialId].ToString().Trim(); //社会Id
objSysSocialRelationsEN.FullName = objRow[conSysSocialRelations.FullName] == DBNull.Value ? null : objRow[conSysSocialRelations.FullName].ToString().Trim(); //姓名
objSysSocialRelationsEN.Nationality = objRow[conSysSocialRelations.Nationality] == DBNull.Value ? null : objRow[conSysSocialRelations.Nationality].ToString().Trim(); //国籍
objSysSocialRelationsEN.WorkUnit = objRow[conSysSocialRelations.WorkUnit] == DBNull.Value ? null : objRow[conSysSocialRelations.WorkUnit].ToString().Trim(); //工作单位
objSysSocialRelationsEN.Major = objRow[conSysSocialRelations.Major] == DBNull.Value ? null : objRow[conSysSocialRelations.Major].ToString().Trim(); //专业
objSysSocialRelationsEN.Achievement = objRow[conSysSocialRelations.Achievement] == DBNull.Value ? null : objRow[conSysSocialRelations.Achievement].ToString().Trim(); //成就
objSysSocialRelationsEN.DetailedDescription = objRow[conSysSocialRelations.DetailedDescription] == DBNull.Value ? null : objRow[conSysSocialRelations.DetailedDescription].ToString().Trim(); //详细说明
objSysSocialRelationsEN.LevelId = objRow[conSysSocialRelations.LevelId] == DBNull.Value ? null : objRow[conSysSocialRelations.LevelId].ToString().Trim(); //级别Id
objSysSocialRelationsEN.UpdUser = objRow[conSysSocialRelations.UpdUser] == DBNull.Value ? null : objRow[conSysSocialRelations.UpdUser].ToString().Trim(); //修改人
objSysSocialRelationsEN.UpdDate = objRow[conSysSocialRelations.UpdDate] == DBNull.Value ? null : objRow[conSysSocialRelations.UpdDate].ToString().Trim(); //修改日期
objSysSocialRelationsEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[conSysSocialRelations.IsSubmit].ToString().Trim()); //是否提交
objSysSocialRelationsEN.OkCount = objRow[conSysSocialRelations.OkCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conSysSocialRelations.OkCount].ToString().Trim()); //点赞统计
objSysSocialRelationsEN.CitationCount = objRow[conSysSocialRelations.CitationCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conSysSocialRelations.CitationCount].ToString().Trim()); //引用统计
objSysSocialRelationsEN.VersionCount = objRow[conSysSocialRelations.VersionCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conSysSocialRelations.VersionCount].ToString().Trim()); //版本统计
objSysSocialRelationsEN.IdCurrEduCls = objRow[conSysSocialRelations.IdCurrEduCls] == DBNull.Value ? null : objRow[conSysSocialRelations.IdCurrEduCls].ToString().Trim(); //教学班流水号
objSysSocialRelationsEN.Memo = objRow[conSysSocialRelations.Memo] == DBNull.Value ? null : objRow[conSysSocialRelations.Memo].ToString().Trim(); //备注
objSysSocialRelationsEN.AppraiseCount = objRow[conSysSocialRelations.AppraiseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conSysSocialRelations.AppraiseCount].ToString().Trim()); //评论数
objSysSocialRelationsEN.Score = objRow[conSysSocialRelations.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conSysSocialRelations.Score].ToString().Trim()); //评分
objSysSocialRelationsEN.StuScore = objRow[conSysSocialRelations.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conSysSocialRelations.StuScore].ToString().Trim()); //学生平均分
objSysSocialRelationsEN.TeaScore = objRow[conSysSocialRelations.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conSysSocialRelations.TeaScore].ToString().Trim()); //教师评分
objSysSocialRelationsEN.CitationId = objRow[conSysSocialRelations.CitationId] == DBNull.Value ? null : objRow[conSysSocialRelations.CitationId].ToString().Trim(); //引用Id
objSysSocialRelationsEN.CreateDate = objRow[conSysSocialRelations.CreateDate] == DBNull.Value ? null : objRow[conSysSocialRelations.CreateDate].ToString().Trim(); //建立日期
objSysSocialRelationsEN.ShareId = objRow[conSysSocialRelations.ShareId] == DBNull.Value ? null : objRow[conSysSocialRelations.ShareId].ToString().Trim(); //分享Id
objSysSocialRelationsEN.PdfContent = objRow[conSysSocialRelations.PdfContent] == DBNull.Value ? null : objRow[conSysSocialRelations.PdfContent].ToString().Trim(); //Pdf内容
objSysSocialRelationsEN.PdfPageNum = objRow[conSysSocialRelations.PdfPageNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conSysSocialRelations.PdfPageNum].ToString().Trim()); //Pdf页码
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objSysSocialRelationsEN.SocialId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objSysSocialRelationsEN);
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
public static List<clsSysSocialRelationsEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsSysSocialRelationsEN> arrObjLst = new List<clsSysSocialRelationsEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsSysSocialRelationsEN objSysSocialRelationsEN = new clsSysSocialRelationsEN();
try
{
objSysSocialRelationsEN.SocialId = objRow[conSysSocialRelations.SocialId].ToString().Trim(); //社会Id
objSysSocialRelationsEN.FullName = objRow[conSysSocialRelations.FullName] == DBNull.Value ? null : objRow[conSysSocialRelations.FullName].ToString().Trim(); //姓名
objSysSocialRelationsEN.Nationality = objRow[conSysSocialRelations.Nationality] == DBNull.Value ? null : objRow[conSysSocialRelations.Nationality].ToString().Trim(); //国籍
objSysSocialRelationsEN.WorkUnit = objRow[conSysSocialRelations.WorkUnit] == DBNull.Value ? null : objRow[conSysSocialRelations.WorkUnit].ToString().Trim(); //工作单位
objSysSocialRelationsEN.Major = objRow[conSysSocialRelations.Major] == DBNull.Value ? null : objRow[conSysSocialRelations.Major].ToString().Trim(); //专业
objSysSocialRelationsEN.Achievement = objRow[conSysSocialRelations.Achievement] == DBNull.Value ? null : objRow[conSysSocialRelations.Achievement].ToString().Trim(); //成就
objSysSocialRelationsEN.DetailedDescription = objRow[conSysSocialRelations.DetailedDescription] == DBNull.Value ? null : objRow[conSysSocialRelations.DetailedDescription].ToString().Trim(); //详细说明
objSysSocialRelationsEN.LevelId = objRow[conSysSocialRelations.LevelId] == DBNull.Value ? null : objRow[conSysSocialRelations.LevelId].ToString().Trim(); //级别Id
objSysSocialRelationsEN.UpdUser = objRow[conSysSocialRelations.UpdUser] == DBNull.Value ? null : objRow[conSysSocialRelations.UpdUser].ToString().Trim(); //修改人
objSysSocialRelationsEN.UpdDate = objRow[conSysSocialRelations.UpdDate] == DBNull.Value ? null : objRow[conSysSocialRelations.UpdDate].ToString().Trim(); //修改日期
objSysSocialRelationsEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[conSysSocialRelations.IsSubmit].ToString().Trim()); //是否提交
objSysSocialRelationsEN.OkCount = objRow[conSysSocialRelations.OkCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conSysSocialRelations.OkCount].ToString().Trim()); //点赞统计
objSysSocialRelationsEN.CitationCount = objRow[conSysSocialRelations.CitationCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conSysSocialRelations.CitationCount].ToString().Trim()); //引用统计
objSysSocialRelationsEN.VersionCount = objRow[conSysSocialRelations.VersionCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conSysSocialRelations.VersionCount].ToString().Trim()); //版本统计
objSysSocialRelationsEN.IdCurrEduCls = objRow[conSysSocialRelations.IdCurrEduCls] == DBNull.Value ? null : objRow[conSysSocialRelations.IdCurrEduCls].ToString().Trim(); //教学班流水号
objSysSocialRelationsEN.Memo = objRow[conSysSocialRelations.Memo] == DBNull.Value ? null : objRow[conSysSocialRelations.Memo].ToString().Trim(); //备注
objSysSocialRelationsEN.AppraiseCount = objRow[conSysSocialRelations.AppraiseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conSysSocialRelations.AppraiseCount].ToString().Trim()); //评论数
objSysSocialRelationsEN.Score = objRow[conSysSocialRelations.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conSysSocialRelations.Score].ToString().Trim()); //评分
objSysSocialRelationsEN.StuScore = objRow[conSysSocialRelations.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conSysSocialRelations.StuScore].ToString().Trim()); //学生平均分
objSysSocialRelationsEN.TeaScore = objRow[conSysSocialRelations.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conSysSocialRelations.TeaScore].ToString().Trim()); //教师评分
objSysSocialRelationsEN.CitationId = objRow[conSysSocialRelations.CitationId] == DBNull.Value ? null : objRow[conSysSocialRelations.CitationId].ToString().Trim(); //引用Id
objSysSocialRelationsEN.CreateDate = objRow[conSysSocialRelations.CreateDate] == DBNull.Value ? null : objRow[conSysSocialRelations.CreateDate].ToString().Trim(); //建立日期
objSysSocialRelationsEN.ShareId = objRow[conSysSocialRelations.ShareId] == DBNull.Value ? null : objRow[conSysSocialRelations.ShareId].ToString().Trim(); //分享Id
objSysSocialRelationsEN.PdfContent = objRow[conSysSocialRelations.PdfContent] == DBNull.Value ? null : objRow[conSysSocialRelations.PdfContent].ToString().Trim(); //Pdf内容
objSysSocialRelationsEN.PdfPageNum = objRow[conSysSocialRelations.PdfPageNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conSysSocialRelations.PdfPageNum].ToString().Trim()); //Pdf页码
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objSysSocialRelationsEN.SocialId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objSysSocialRelationsEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objSysSocialRelationsCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsSysSocialRelationsEN> GetSubObjLstCache(clsSysSocialRelationsEN objSysSocialRelationsCond)
{
 string strIdCurrEduCls = objSysSocialRelationsCond.IdCurrEduCls;
 if (string.IsNullOrEmpty(strIdCurrEduCls) == true)
{
string strMsg = string.Format("(errid:Busi000172)在表中,缓存分类字段值不能为空!(clsSysSocialRelationsBL:GetSubObjLstCache)");
throw new Exception(strMsg);
}
List<clsSysSocialRelationsEN> arrObjLstCache = GetObjLstCache(strIdCurrEduCls);
IEnumerable <clsSysSocialRelationsEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conSysSocialRelations.AttributeName)
{
if (objSysSocialRelationsCond.IsUpdated(strFldName) == false) continue;
if (objSysSocialRelationsCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objSysSocialRelationsCond[strFldName].ToString());
}
else
{
if (objSysSocialRelationsCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objSysSocialRelationsCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objSysSocialRelationsCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objSysSocialRelationsCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objSysSocialRelationsCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objSysSocialRelationsCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objSysSocialRelationsCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objSysSocialRelationsCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objSysSocialRelationsCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objSysSocialRelationsCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objSysSocialRelationsCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objSysSocialRelationsCond[strFldName]));
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
public static List<clsSysSocialRelationsEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsSysSocialRelationsEN> arrObjLst = new List<clsSysSocialRelationsEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsSysSocialRelationsEN objSysSocialRelationsEN = new clsSysSocialRelationsEN();
try
{
objSysSocialRelationsEN.SocialId = objRow[conSysSocialRelations.SocialId].ToString().Trim(); //社会Id
objSysSocialRelationsEN.FullName = objRow[conSysSocialRelations.FullName] == DBNull.Value ? null : objRow[conSysSocialRelations.FullName].ToString().Trim(); //姓名
objSysSocialRelationsEN.Nationality = objRow[conSysSocialRelations.Nationality] == DBNull.Value ? null : objRow[conSysSocialRelations.Nationality].ToString().Trim(); //国籍
objSysSocialRelationsEN.WorkUnit = objRow[conSysSocialRelations.WorkUnit] == DBNull.Value ? null : objRow[conSysSocialRelations.WorkUnit].ToString().Trim(); //工作单位
objSysSocialRelationsEN.Major = objRow[conSysSocialRelations.Major] == DBNull.Value ? null : objRow[conSysSocialRelations.Major].ToString().Trim(); //专业
objSysSocialRelationsEN.Achievement = objRow[conSysSocialRelations.Achievement] == DBNull.Value ? null : objRow[conSysSocialRelations.Achievement].ToString().Trim(); //成就
objSysSocialRelationsEN.DetailedDescription = objRow[conSysSocialRelations.DetailedDescription] == DBNull.Value ? null : objRow[conSysSocialRelations.DetailedDescription].ToString().Trim(); //详细说明
objSysSocialRelationsEN.LevelId = objRow[conSysSocialRelations.LevelId] == DBNull.Value ? null : objRow[conSysSocialRelations.LevelId].ToString().Trim(); //级别Id
objSysSocialRelationsEN.UpdUser = objRow[conSysSocialRelations.UpdUser] == DBNull.Value ? null : objRow[conSysSocialRelations.UpdUser].ToString().Trim(); //修改人
objSysSocialRelationsEN.UpdDate = objRow[conSysSocialRelations.UpdDate] == DBNull.Value ? null : objRow[conSysSocialRelations.UpdDate].ToString().Trim(); //修改日期
objSysSocialRelationsEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[conSysSocialRelations.IsSubmit].ToString().Trim()); //是否提交
objSysSocialRelationsEN.OkCount = objRow[conSysSocialRelations.OkCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conSysSocialRelations.OkCount].ToString().Trim()); //点赞统计
objSysSocialRelationsEN.CitationCount = objRow[conSysSocialRelations.CitationCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conSysSocialRelations.CitationCount].ToString().Trim()); //引用统计
objSysSocialRelationsEN.VersionCount = objRow[conSysSocialRelations.VersionCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conSysSocialRelations.VersionCount].ToString().Trim()); //版本统计
objSysSocialRelationsEN.IdCurrEduCls = objRow[conSysSocialRelations.IdCurrEduCls] == DBNull.Value ? null : objRow[conSysSocialRelations.IdCurrEduCls].ToString().Trim(); //教学班流水号
objSysSocialRelationsEN.Memo = objRow[conSysSocialRelations.Memo] == DBNull.Value ? null : objRow[conSysSocialRelations.Memo].ToString().Trim(); //备注
objSysSocialRelationsEN.AppraiseCount = objRow[conSysSocialRelations.AppraiseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conSysSocialRelations.AppraiseCount].ToString().Trim()); //评论数
objSysSocialRelationsEN.Score = objRow[conSysSocialRelations.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conSysSocialRelations.Score].ToString().Trim()); //评分
objSysSocialRelationsEN.StuScore = objRow[conSysSocialRelations.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conSysSocialRelations.StuScore].ToString().Trim()); //学生平均分
objSysSocialRelationsEN.TeaScore = objRow[conSysSocialRelations.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conSysSocialRelations.TeaScore].ToString().Trim()); //教师评分
objSysSocialRelationsEN.CitationId = objRow[conSysSocialRelations.CitationId] == DBNull.Value ? null : objRow[conSysSocialRelations.CitationId].ToString().Trim(); //引用Id
objSysSocialRelationsEN.CreateDate = objRow[conSysSocialRelations.CreateDate] == DBNull.Value ? null : objRow[conSysSocialRelations.CreateDate].ToString().Trim(); //建立日期
objSysSocialRelationsEN.ShareId = objRow[conSysSocialRelations.ShareId] == DBNull.Value ? null : objRow[conSysSocialRelations.ShareId].ToString().Trim(); //分享Id
objSysSocialRelationsEN.PdfContent = objRow[conSysSocialRelations.PdfContent] == DBNull.Value ? null : objRow[conSysSocialRelations.PdfContent].ToString().Trim(); //Pdf内容
objSysSocialRelationsEN.PdfPageNum = objRow[conSysSocialRelations.PdfPageNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conSysSocialRelations.PdfPageNum].ToString().Trim()); //Pdf页码
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objSysSocialRelationsEN.SocialId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objSysSocialRelationsEN);
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
public static List<clsSysSocialRelationsEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsSysSocialRelationsEN> arrObjLst = new List<clsSysSocialRelationsEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsSysSocialRelationsEN objSysSocialRelationsEN = new clsSysSocialRelationsEN();
try
{
objSysSocialRelationsEN.SocialId = objRow[conSysSocialRelations.SocialId].ToString().Trim(); //社会Id
objSysSocialRelationsEN.FullName = objRow[conSysSocialRelations.FullName] == DBNull.Value ? null : objRow[conSysSocialRelations.FullName].ToString().Trim(); //姓名
objSysSocialRelationsEN.Nationality = objRow[conSysSocialRelations.Nationality] == DBNull.Value ? null : objRow[conSysSocialRelations.Nationality].ToString().Trim(); //国籍
objSysSocialRelationsEN.WorkUnit = objRow[conSysSocialRelations.WorkUnit] == DBNull.Value ? null : objRow[conSysSocialRelations.WorkUnit].ToString().Trim(); //工作单位
objSysSocialRelationsEN.Major = objRow[conSysSocialRelations.Major] == DBNull.Value ? null : objRow[conSysSocialRelations.Major].ToString().Trim(); //专业
objSysSocialRelationsEN.Achievement = objRow[conSysSocialRelations.Achievement] == DBNull.Value ? null : objRow[conSysSocialRelations.Achievement].ToString().Trim(); //成就
objSysSocialRelationsEN.DetailedDescription = objRow[conSysSocialRelations.DetailedDescription] == DBNull.Value ? null : objRow[conSysSocialRelations.DetailedDescription].ToString().Trim(); //详细说明
objSysSocialRelationsEN.LevelId = objRow[conSysSocialRelations.LevelId] == DBNull.Value ? null : objRow[conSysSocialRelations.LevelId].ToString().Trim(); //级别Id
objSysSocialRelationsEN.UpdUser = objRow[conSysSocialRelations.UpdUser] == DBNull.Value ? null : objRow[conSysSocialRelations.UpdUser].ToString().Trim(); //修改人
objSysSocialRelationsEN.UpdDate = objRow[conSysSocialRelations.UpdDate] == DBNull.Value ? null : objRow[conSysSocialRelations.UpdDate].ToString().Trim(); //修改日期
objSysSocialRelationsEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[conSysSocialRelations.IsSubmit].ToString().Trim()); //是否提交
objSysSocialRelationsEN.OkCount = objRow[conSysSocialRelations.OkCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conSysSocialRelations.OkCount].ToString().Trim()); //点赞统计
objSysSocialRelationsEN.CitationCount = objRow[conSysSocialRelations.CitationCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conSysSocialRelations.CitationCount].ToString().Trim()); //引用统计
objSysSocialRelationsEN.VersionCount = objRow[conSysSocialRelations.VersionCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conSysSocialRelations.VersionCount].ToString().Trim()); //版本统计
objSysSocialRelationsEN.IdCurrEduCls = objRow[conSysSocialRelations.IdCurrEduCls] == DBNull.Value ? null : objRow[conSysSocialRelations.IdCurrEduCls].ToString().Trim(); //教学班流水号
objSysSocialRelationsEN.Memo = objRow[conSysSocialRelations.Memo] == DBNull.Value ? null : objRow[conSysSocialRelations.Memo].ToString().Trim(); //备注
objSysSocialRelationsEN.AppraiseCount = objRow[conSysSocialRelations.AppraiseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conSysSocialRelations.AppraiseCount].ToString().Trim()); //评论数
objSysSocialRelationsEN.Score = objRow[conSysSocialRelations.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conSysSocialRelations.Score].ToString().Trim()); //评分
objSysSocialRelationsEN.StuScore = objRow[conSysSocialRelations.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conSysSocialRelations.StuScore].ToString().Trim()); //学生平均分
objSysSocialRelationsEN.TeaScore = objRow[conSysSocialRelations.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conSysSocialRelations.TeaScore].ToString().Trim()); //教师评分
objSysSocialRelationsEN.CitationId = objRow[conSysSocialRelations.CitationId] == DBNull.Value ? null : objRow[conSysSocialRelations.CitationId].ToString().Trim(); //引用Id
objSysSocialRelationsEN.CreateDate = objRow[conSysSocialRelations.CreateDate] == DBNull.Value ? null : objRow[conSysSocialRelations.CreateDate].ToString().Trim(); //建立日期
objSysSocialRelationsEN.ShareId = objRow[conSysSocialRelations.ShareId] == DBNull.Value ? null : objRow[conSysSocialRelations.ShareId].ToString().Trim(); //分享Id
objSysSocialRelationsEN.PdfContent = objRow[conSysSocialRelations.PdfContent] == DBNull.Value ? null : objRow[conSysSocialRelations.PdfContent].ToString().Trim(); //Pdf内容
objSysSocialRelationsEN.PdfPageNum = objRow[conSysSocialRelations.PdfPageNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conSysSocialRelations.PdfPageNum].ToString().Trim()); //Pdf页码
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objSysSocialRelationsEN.SocialId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objSysSocialRelationsEN);
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
List<clsSysSocialRelationsEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsSysSocialRelationsEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsSysSocialRelationsEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsSysSocialRelationsEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsSysSocialRelationsEN> arrObjLst = new List<clsSysSocialRelationsEN>(); 
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
	clsSysSocialRelationsEN objSysSocialRelationsEN = new clsSysSocialRelationsEN();
try
{
objSysSocialRelationsEN.SocialId = objRow[conSysSocialRelations.SocialId].ToString().Trim(); //社会Id
objSysSocialRelationsEN.FullName = objRow[conSysSocialRelations.FullName] == DBNull.Value ? null : objRow[conSysSocialRelations.FullName].ToString().Trim(); //姓名
objSysSocialRelationsEN.Nationality = objRow[conSysSocialRelations.Nationality] == DBNull.Value ? null : objRow[conSysSocialRelations.Nationality].ToString().Trim(); //国籍
objSysSocialRelationsEN.WorkUnit = objRow[conSysSocialRelations.WorkUnit] == DBNull.Value ? null : objRow[conSysSocialRelations.WorkUnit].ToString().Trim(); //工作单位
objSysSocialRelationsEN.Major = objRow[conSysSocialRelations.Major] == DBNull.Value ? null : objRow[conSysSocialRelations.Major].ToString().Trim(); //专业
objSysSocialRelationsEN.Achievement = objRow[conSysSocialRelations.Achievement] == DBNull.Value ? null : objRow[conSysSocialRelations.Achievement].ToString().Trim(); //成就
objSysSocialRelationsEN.DetailedDescription = objRow[conSysSocialRelations.DetailedDescription] == DBNull.Value ? null : objRow[conSysSocialRelations.DetailedDescription].ToString().Trim(); //详细说明
objSysSocialRelationsEN.LevelId = objRow[conSysSocialRelations.LevelId] == DBNull.Value ? null : objRow[conSysSocialRelations.LevelId].ToString().Trim(); //级别Id
objSysSocialRelationsEN.UpdUser = objRow[conSysSocialRelations.UpdUser] == DBNull.Value ? null : objRow[conSysSocialRelations.UpdUser].ToString().Trim(); //修改人
objSysSocialRelationsEN.UpdDate = objRow[conSysSocialRelations.UpdDate] == DBNull.Value ? null : objRow[conSysSocialRelations.UpdDate].ToString().Trim(); //修改日期
objSysSocialRelationsEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[conSysSocialRelations.IsSubmit].ToString().Trim()); //是否提交
objSysSocialRelationsEN.OkCount = objRow[conSysSocialRelations.OkCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conSysSocialRelations.OkCount].ToString().Trim()); //点赞统计
objSysSocialRelationsEN.CitationCount = objRow[conSysSocialRelations.CitationCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conSysSocialRelations.CitationCount].ToString().Trim()); //引用统计
objSysSocialRelationsEN.VersionCount = objRow[conSysSocialRelations.VersionCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conSysSocialRelations.VersionCount].ToString().Trim()); //版本统计
objSysSocialRelationsEN.IdCurrEduCls = objRow[conSysSocialRelations.IdCurrEduCls] == DBNull.Value ? null : objRow[conSysSocialRelations.IdCurrEduCls].ToString().Trim(); //教学班流水号
objSysSocialRelationsEN.Memo = objRow[conSysSocialRelations.Memo] == DBNull.Value ? null : objRow[conSysSocialRelations.Memo].ToString().Trim(); //备注
objSysSocialRelationsEN.AppraiseCount = objRow[conSysSocialRelations.AppraiseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conSysSocialRelations.AppraiseCount].ToString().Trim()); //评论数
objSysSocialRelationsEN.Score = objRow[conSysSocialRelations.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conSysSocialRelations.Score].ToString().Trim()); //评分
objSysSocialRelationsEN.StuScore = objRow[conSysSocialRelations.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conSysSocialRelations.StuScore].ToString().Trim()); //学生平均分
objSysSocialRelationsEN.TeaScore = objRow[conSysSocialRelations.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conSysSocialRelations.TeaScore].ToString().Trim()); //教师评分
objSysSocialRelationsEN.CitationId = objRow[conSysSocialRelations.CitationId] == DBNull.Value ? null : objRow[conSysSocialRelations.CitationId].ToString().Trim(); //引用Id
objSysSocialRelationsEN.CreateDate = objRow[conSysSocialRelations.CreateDate] == DBNull.Value ? null : objRow[conSysSocialRelations.CreateDate].ToString().Trim(); //建立日期
objSysSocialRelationsEN.ShareId = objRow[conSysSocialRelations.ShareId] == DBNull.Value ? null : objRow[conSysSocialRelations.ShareId].ToString().Trim(); //分享Id
objSysSocialRelationsEN.PdfContent = objRow[conSysSocialRelations.PdfContent] == DBNull.Value ? null : objRow[conSysSocialRelations.PdfContent].ToString().Trim(); //Pdf内容
objSysSocialRelationsEN.PdfPageNum = objRow[conSysSocialRelations.PdfPageNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conSysSocialRelations.PdfPageNum].ToString().Trim()); //Pdf页码
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objSysSocialRelationsEN.SocialId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objSysSocialRelationsEN);
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
public static List<clsSysSocialRelationsEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsSysSocialRelationsEN> arrObjLst = new List<clsSysSocialRelationsEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsSysSocialRelationsEN objSysSocialRelationsEN = new clsSysSocialRelationsEN();
try
{
objSysSocialRelationsEN.SocialId = objRow[conSysSocialRelations.SocialId].ToString().Trim(); //社会Id
objSysSocialRelationsEN.FullName = objRow[conSysSocialRelations.FullName] == DBNull.Value ? null : objRow[conSysSocialRelations.FullName].ToString().Trim(); //姓名
objSysSocialRelationsEN.Nationality = objRow[conSysSocialRelations.Nationality] == DBNull.Value ? null : objRow[conSysSocialRelations.Nationality].ToString().Trim(); //国籍
objSysSocialRelationsEN.WorkUnit = objRow[conSysSocialRelations.WorkUnit] == DBNull.Value ? null : objRow[conSysSocialRelations.WorkUnit].ToString().Trim(); //工作单位
objSysSocialRelationsEN.Major = objRow[conSysSocialRelations.Major] == DBNull.Value ? null : objRow[conSysSocialRelations.Major].ToString().Trim(); //专业
objSysSocialRelationsEN.Achievement = objRow[conSysSocialRelations.Achievement] == DBNull.Value ? null : objRow[conSysSocialRelations.Achievement].ToString().Trim(); //成就
objSysSocialRelationsEN.DetailedDescription = objRow[conSysSocialRelations.DetailedDescription] == DBNull.Value ? null : objRow[conSysSocialRelations.DetailedDescription].ToString().Trim(); //详细说明
objSysSocialRelationsEN.LevelId = objRow[conSysSocialRelations.LevelId] == DBNull.Value ? null : objRow[conSysSocialRelations.LevelId].ToString().Trim(); //级别Id
objSysSocialRelationsEN.UpdUser = objRow[conSysSocialRelations.UpdUser] == DBNull.Value ? null : objRow[conSysSocialRelations.UpdUser].ToString().Trim(); //修改人
objSysSocialRelationsEN.UpdDate = objRow[conSysSocialRelations.UpdDate] == DBNull.Value ? null : objRow[conSysSocialRelations.UpdDate].ToString().Trim(); //修改日期
objSysSocialRelationsEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[conSysSocialRelations.IsSubmit].ToString().Trim()); //是否提交
objSysSocialRelationsEN.OkCount = objRow[conSysSocialRelations.OkCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conSysSocialRelations.OkCount].ToString().Trim()); //点赞统计
objSysSocialRelationsEN.CitationCount = objRow[conSysSocialRelations.CitationCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conSysSocialRelations.CitationCount].ToString().Trim()); //引用统计
objSysSocialRelationsEN.VersionCount = objRow[conSysSocialRelations.VersionCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conSysSocialRelations.VersionCount].ToString().Trim()); //版本统计
objSysSocialRelationsEN.IdCurrEduCls = objRow[conSysSocialRelations.IdCurrEduCls] == DBNull.Value ? null : objRow[conSysSocialRelations.IdCurrEduCls].ToString().Trim(); //教学班流水号
objSysSocialRelationsEN.Memo = objRow[conSysSocialRelations.Memo] == DBNull.Value ? null : objRow[conSysSocialRelations.Memo].ToString().Trim(); //备注
objSysSocialRelationsEN.AppraiseCount = objRow[conSysSocialRelations.AppraiseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conSysSocialRelations.AppraiseCount].ToString().Trim()); //评论数
objSysSocialRelationsEN.Score = objRow[conSysSocialRelations.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conSysSocialRelations.Score].ToString().Trim()); //评分
objSysSocialRelationsEN.StuScore = objRow[conSysSocialRelations.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conSysSocialRelations.StuScore].ToString().Trim()); //学生平均分
objSysSocialRelationsEN.TeaScore = objRow[conSysSocialRelations.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conSysSocialRelations.TeaScore].ToString().Trim()); //教师评分
objSysSocialRelationsEN.CitationId = objRow[conSysSocialRelations.CitationId] == DBNull.Value ? null : objRow[conSysSocialRelations.CitationId].ToString().Trim(); //引用Id
objSysSocialRelationsEN.CreateDate = objRow[conSysSocialRelations.CreateDate] == DBNull.Value ? null : objRow[conSysSocialRelations.CreateDate].ToString().Trim(); //建立日期
objSysSocialRelationsEN.ShareId = objRow[conSysSocialRelations.ShareId] == DBNull.Value ? null : objRow[conSysSocialRelations.ShareId].ToString().Trim(); //分享Id
objSysSocialRelationsEN.PdfContent = objRow[conSysSocialRelations.PdfContent] == DBNull.Value ? null : objRow[conSysSocialRelations.PdfContent].ToString().Trim(); //Pdf内容
objSysSocialRelationsEN.PdfPageNum = objRow[conSysSocialRelations.PdfPageNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conSysSocialRelations.PdfPageNum].ToString().Trim()); //Pdf页码
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objSysSocialRelationsEN.SocialId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objSysSocialRelationsEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsSysSocialRelationsEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsSysSocialRelationsEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsSysSocialRelationsEN> arrObjLst = new List<clsSysSocialRelationsEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsSysSocialRelationsEN objSysSocialRelationsEN = new clsSysSocialRelationsEN();
try
{
objSysSocialRelationsEN.SocialId = objRow[conSysSocialRelations.SocialId].ToString().Trim(); //社会Id
objSysSocialRelationsEN.FullName = objRow[conSysSocialRelations.FullName] == DBNull.Value ? null : objRow[conSysSocialRelations.FullName].ToString().Trim(); //姓名
objSysSocialRelationsEN.Nationality = objRow[conSysSocialRelations.Nationality] == DBNull.Value ? null : objRow[conSysSocialRelations.Nationality].ToString().Trim(); //国籍
objSysSocialRelationsEN.WorkUnit = objRow[conSysSocialRelations.WorkUnit] == DBNull.Value ? null : objRow[conSysSocialRelations.WorkUnit].ToString().Trim(); //工作单位
objSysSocialRelationsEN.Major = objRow[conSysSocialRelations.Major] == DBNull.Value ? null : objRow[conSysSocialRelations.Major].ToString().Trim(); //专业
objSysSocialRelationsEN.Achievement = objRow[conSysSocialRelations.Achievement] == DBNull.Value ? null : objRow[conSysSocialRelations.Achievement].ToString().Trim(); //成就
objSysSocialRelationsEN.DetailedDescription = objRow[conSysSocialRelations.DetailedDescription] == DBNull.Value ? null : objRow[conSysSocialRelations.DetailedDescription].ToString().Trim(); //详细说明
objSysSocialRelationsEN.LevelId = objRow[conSysSocialRelations.LevelId] == DBNull.Value ? null : objRow[conSysSocialRelations.LevelId].ToString().Trim(); //级别Id
objSysSocialRelationsEN.UpdUser = objRow[conSysSocialRelations.UpdUser] == DBNull.Value ? null : objRow[conSysSocialRelations.UpdUser].ToString().Trim(); //修改人
objSysSocialRelationsEN.UpdDate = objRow[conSysSocialRelations.UpdDate] == DBNull.Value ? null : objRow[conSysSocialRelations.UpdDate].ToString().Trim(); //修改日期
objSysSocialRelationsEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[conSysSocialRelations.IsSubmit].ToString().Trim()); //是否提交
objSysSocialRelationsEN.OkCount = objRow[conSysSocialRelations.OkCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conSysSocialRelations.OkCount].ToString().Trim()); //点赞统计
objSysSocialRelationsEN.CitationCount = objRow[conSysSocialRelations.CitationCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conSysSocialRelations.CitationCount].ToString().Trim()); //引用统计
objSysSocialRelationsEN.VersionCount = objRow[conSysSocialRelations.VersionCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conSysSocialRelations.VersionCount].ToString().Trim()); //版本统计
objSysSocialRelationsEN.IdCurrEduCls = objRow[conSysSocialRelations.IdCurrEduCls] == DBNull.Value ? null : objRow[conSysSocialRelations.IdCurrEduCls].ToString().Trim(); //教学班流水号
objSysSocialRelationsEN.Memo = objRow[conSysSocialRelations.Memo] == DBNull.Value ? null : objRow[conSysSocialRelations.Memo].ToString().Trim(); //备注
objSysSocialRelationsEN.AppraiseCount = objRow[conSysSocialRelations.AppraiseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conSysSocialRelations.AppraiseCount].ToString().Trim()); //评论数
objSysSocialRelationsEN.Score = objRow[conSysSocialRelations.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conSysSocialRelations.Score].ToString().Trim()); //评分
objSysSocialRelationsEN.StuScore = objRow[conSysSocialRelations.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conSysSocialRelations.StuScore].ToString().Trim()); //学生平均分
objSysSocialRelationsEN.TeaScore = objRow[conSysSocialRelations.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conSysSocialRelations.TeaScore].ToString().Trim()); //教师评分
objSysSocialRelationsEN.CitationId = objRow[conSysSocialRelations.CitationId] == DBNull.Value ? null : objRow[conSysSocialRelations.CitationId].ToString().Trim(); //引用Id
objSysSocialRelationsEN.CreateDate = objRow[conSysSocialRelations.CreateDate] == DBNull.Value ? null : objRow[conSysSocialRelations.CreateDate].ToString().Trim(); //建立日期
objSysSocialRelationsEN.ShareId = objRow[conSysSocialRelations.ShareId] == DBNull.Value ? null : objRow[conSysSocialRelations.ShareId].ToString().Trim(); //分享Id
objSysSocialRelationsEN.PdfContent = objRow[conSysSocialRelations.PdfContent] == DBNull.Value ? null : objRow[conSysSocialRelations.PdfContent].ToString().Trim(); //Pdf内容
objSysSocialRelationsEN.PdfPageNum = objRow[conSysSocialRelations.PdfPageNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conSysSocialRelations.PdfPageNum].ToString().Trim()); //Pdf页码
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objSysSocialRelationsEN.SocialId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objSysSocialRelationsEN);
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
public static List<clsSysSocialRelationsEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsSysSocialRelationsEN> arrObjLst = new List<clsSysSocialRelationsEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsSysSocialRelationsEN objSysSocialRelationsEN = new clsSysSocialRelationsEN();
try
{
objSysSocialRelationsEN.SocialId = objRow[conSysSocialRelations.SocialId].ToString().Trim(); //社会Id
objSysSocialRelationsEN.FullName = objRow[conSysSocialRelations.FullName] == DBNull.Value ? null : objRow[conSysSocialRelations.FullName].ToString().Trim(); //姓名
objSysSocialRelationsEN.Nationality = objRow[conSysSocialRelations.Nationality] == DBNull.Value ? null : objRow[conSysSocialRelations.Nationality].ToString().Trim(); //国籍
objSysSocialRelationsEN.WorkUnit = objRow[conSysSocialRelations.WorkUnit] == DBNull.Value ? null : objRow[conSysSocialRelations.WorkUnit].ToString().Trim(); //工作单位
objSysSocialRelationsEN.Major = objRow[conSysSocialRelations.Major] == DBNull.Value ? null : objRow[conSysSocialRelations.Major].ToString().Trim(); //专业
objSysSocialRelationsEN.Achievement = objRow[conSysSocialRelations.Achievement] == DBNull.Value ? null : objRow[conSysSocialRelations.Achievement].ToString().Trim(); //成就
objSysSocialRelationsEN.DetailedDescription = objRow[conSysSocialRelations.DetailedDescription] == DBNull.Value ? null : objRow[conSysSocialRelations.DetailedDescription].ToString().Trim(); //详细说明
objSysSocialRelationsEN.LevelId = objRow[conSysSocialRelations.LevelId] == DBNull.Value ? null : objRow[conSysSocialRelations.LevelId].ToString().Trim(); //级别Id
objSysSocialRelationsEN.UpdUser = objRow[conSysSocialRelations.UpdUser] == DBNull.Value ? null : objRow[conSysSocialRelations.UpdUser].ToString().Trim(); //修改人
objSysSocialRelationsEN.UpdDate = objRow[conSysSocialRelations.UpdDate] == DBNull.Value ? null : objRow[conSysSocialRelations.UpdDate].ToString().Trim(); //修改日期
objSysSocialRelationsEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[conSysSocialRelations.IsSubmit].ToString().Trim()); //是否提交
objSysSocialRelationsEN.OkCount = objRow[conSysSocialRelations.OkCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conSysSocialRelations.OkCount].ToString().Trim()); //点赞统计
objSysSocialRelationsEN.CitationCount = objRow[conSysSocialRelations.CitationCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conSysSocialRelations.CitationCount].ToString().Trim()); //引用统计
objSysSocialRelationsEN.VersionCount = objRow[conSysSocialRelations.VersionCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conSysSocialRelations.VersionCount].ToString().Trim()); //版本统计
objSysSocialRelationsEN.IdCurrEduCls = objRow[conSysSocialRelations.IdCurrEduCls] == DBNull.Value ? null : objRow[conSysSocialRelations.IdCurrEduCls].ToString().Trim(); //教学班流水号
objSysSocialRelationsEN.Memo = objRow[conSysSocialRelations.Memo] == DBNull.Value ? null : objRow[conSysSocialRelations.Memo].ToString().Trim(); //备注
objSysSocialRelationsEN.AppraiseCount = objRow[conSysSocialRelations.AppraiseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conSysSocialRelations.AppraiseCount].ToString().Trim()); //评论数
objSysSocialRelationsEN.Score = objRow[conSysSocialRelations.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conSysSocialRelations.Score].ToString().Trim()); //评分
objSysSocialRelationsEN.StuScore = objRow[conSysSocialRelations.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conSysSocialRelations.StuScore].ToString().Trim()); //学生平均分
objSysSocialRelationsEN.TeaScore = objRow[conSysSocialRelations.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conSysSocialRelations.TeaScore].ToString().Trim()); //教师评分
objSysSocialRelationsEN.CitationId = objRow[conSysSocialRelations.CitationId] == DBNull.Value ? null : objRow[conSysSocialRelations.CitationId].ToString().Trim(); //引用Id
objSysSocialRelationsEN.CreateDate = objRow[conSysSocialRelations.CreateDate] == DBNull.Value ? null : objRow[conSysSocialRelations.CreateDate].ToString().Trim(); //建立日期
objSysSocialRelationsEN.ShareId = objRow[conSysSocialRelations.ShareId] == DBNull.Value ? null : objRow[conSysSocialRelations.ShareId].ToString().Trim(); //分享Id
objSysSocialRelationsEN.PdfContent = objRow[conSysSocialRelations.PdfContent] == DBNull.Value ? null : objRow[conSysSocialRelations.PdfContent].ToString().Trim(); //Pdf内容
objSysSocialRelationsEN.PdfPageNum = objRow[conSysSocialRelations.PdfPageNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conSysSocialRelations.PdfPageNum].ToString().Trim()); //Pdf页码
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objSysSocialRelationsEN.SocialId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objSysSocialRelationsEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsSysSocialRelationsEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsSysSocialRelationsEN> arrObjLst = new List<clsSysSocialRelationsEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsSysSocialRelationsEN objSysSocialRelationsEN = new clsSysSocialRelationsEN();
try
{
objSysSocialRelationsEN.SocialId = objRow[conSysSocialRelations.SocialId].ToString().Trim(); //社会Id
objSysSocialRelationsEN.FullName = objRow[conSysSocialRelations.FullName] == DBNull.Value ? null : objRow[conSysSocialRelations.FullName].ToString().Trim(); //姓名
objSysSocialRelationsEN.Nationality = objRow[conSysSocialRelations.Nationality] == DBNull.Value ? null : objRow[conSysSocialRelations.Nationality].ToString().Trim(); //国籍
objSysSocialRelationsEN.WorkUnit = objRow[conSysSocialRelations.WorkUnit] == DBNull.Value ? null : objRow[conSysSocialRelations.WorkUnit].ToString().Trim(); //工作单位
objSysSocialRelationsEN.Major = objRow[conSysSocialRelations.Major] == DBNull.Value ? null : objRow[conSysSocialRelations.Major].ToString().Trim(); //专业
objSysSocialRelationsEN.Achievement = objRow[conSysSocialRelations.Achievement] == DBNull.Value ? null : objRow[conSysSocialRelations.Achievement].ToString().Trim(); //成就
objSysSocialRelationsEN.DetailedDescription = objRow[conSysSocialRelations.DetailedDescription] == DBNull.Value ? null : objRow[conSysSocialRelations.DetailedDescription].ToString().Trim(); //详细说明
objSysSocialRelationsEN.LevelId = objRow[conSysSocialRelations.LevelId] == DBNull.Value ? null : objRow[conSysSocialRelations.LevelId].ToString().Trim(); //级别Id
objSysSocialRelationsEN.UpdUser = objRow[conSysSocialRelations.UpdUser] == DBNull.Value ? null : objRow[conSysSocialRelations.UpdUser].ToString().Trim(); //修改人
objSysSocialRelationsEN.UpdDate = objRow[conSysSocialRelations.UpdDate] == DBNull.Value ? null : objRow[conSysSocialRelations.UpdDate].ToString().Trim(); //修改日期
objSysSocialRelationsEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[conSysSocialRelations.IsSubmit].ToString().Trim()); //是否提交
objSysSocialRelationsEN.OkCount = objRow[conSysSocialRelations.OkCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conSysSocialRelations.OkCount].ToString().Trim()); //点赞统计
objSysSocialRelationsEN.CitationCount = objRow[conSysSocialRelations.CitationCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conSysSocialRelations.CitationCount].ToString().Trim()); //引用统计
objSysSocialRelationsEN.VersionCount = objRow[conSysSocialRelations.VersionCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conSysSocialRelations.VersionCount].ToString().Trim()); //版本统计
objSysSocialRelationsEN.IdCurrEduCls = objRow[conSysSocialRelations.IdCurrEduCls] == DBNull.Value ? null : objRow[conSysSocialRelations.IdCurrEduCls].ToString().Trim(); //教学班流水号
objSysSocialRelationsEN.Memo = objRow[conSysSocialRelations.Memo] == DBNull.Value ? null : objRow[conSysSocialRelations.Memo].ToString().Trim(); //备注
objSysSocialRelationsEN.AppraiseCount = objRow[conSysSocialRelations.AppraiseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conSysSocialRelations.AppraiseCount].ToString().Trim()); //评论数
objSysSocialRelationsEN.Score = objRow[conSysSocialRelations.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conSysSocialRelations.Score].ToString().Trim()); //评分
objSysSocialRelationsEN.StuScore = objRow[conSysSocialRelations.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conSysSocialRelations.StuScore].ToString().Trim()); //学生平均分
objSysSocialRelationsEN.TeaScore = objRow[conSysSocialRelations.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conSysSocialRelations.TeaScore].ToString().Trim()); //教师评分
objSysSocialRelationsEN.CitationId = objRow[conSysSocialRelations.CitationId] == DBNull.Value ? null : objRow[conSysSocialRelations.CitationId].ToString().Trim(); //引用Id
objSysSocialRelationsEN.CreateDate = objRow[conSysSocialRelations.CreateDate] == DBNull.Value ? null : objRow[conSysSocialRelations.CreateDate].ToString().Trim(); //建立日期
objSysSocialRelationsEN.ShareId = objRow[conSysSocialRelations.ShareId] == DBNull.Value ? null : objRow[conSysSocialRelations.ShareId].ToString().Trim(); //分享Id
objSysSocialRelationsEN.PdfContent = objRow[conSysSocialRelations.PdfContent] == DBNull.Value ? null : objRow[conSysSocialRelations.PdfContent].ToString().Trim(); //Pdf内容
objSysSocialRelationsEN.PdfPageNum = objRow[conSysSocialRelations.PdfPageNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conSysSocialRelations.PdfPageNum].ToString().Trim()); //Pdf页码
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objSysSocialRelationsEN.SocialId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objSysSocialRelationsEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objSysSocialRelationsEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetSysSocialRelations(ref clsSysSocialRelationsEN objSysSocialRelationsEN)
{
bool bolResult = SysSocialRelationsDA.GetSysSocialRelations(ref objSysSocialRelationsEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "strSocialId">表关键字</param>
 /// <returns>表对象</returns>
public static clsSysSocialRelationsEN GetObjBySocialId(string strSocialId)
{
if (strSocialId.IndexOf(' ') >=0)
{
var strMsg = string.Format("(errid:Busi000079)在表中,关键字[strSocialId]中不能有空格!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
if (string.IsNullOrEmpty(strSocialId) == true)
{
var strMsg = string.Format("(errid:Busi000020)在表中,关键字[strSocialId]不能为空!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
clsSysSocialRelationsEN objSysSocialRelationsEN = SysSocialRelationsDA.GetObjBySocialId(strSocialId);
return objSysSocialRelationsEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsSysSocialRelationsEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsSysSocialRelationsEN objSysSocialRelationsEN = SysSocialRelationsDA.GetFirstObj(strWhereCond);
 return objSysSocialRelationsEN;
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
public static clsSysSocialRelationsEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsSysSocialRelationsEN objSysSocialRelationsEN = SysSocialRelationsDA.GetObjByDataRow(objRow);
 return objSysSocialRelationsEN;
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
public static clsSysSocialRelationsEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsSysSocialRelationsEN objSysSocialRelationsEN = SysSocialRelationsDA.GetObjByDataRow(objRow);
 return objSysSocialRelationsEN;
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
 /// <param name = "strSocialId">所给的关键字</param>
 /// <param name = "lstSysSocialRelationsObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsSysSocialRelationsEN GetObjBySocialIdFromList(string strSocialId, List<clsSysSocialRelationsEN> lstSysSocialRelationsObjLst)
{
foreach (clsSysSocialRelationsEN objSysSocialRelationsEN in lstSysSocialRelationsObjLst)
{
if (objSysSocialRelationsEN.SocialId == strSocialId)
{
return objSysSocialRelationsEN;
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
 string strMaxSocialId;
 try
 {
 strMaxSocialId = clsSysSocialRelationsDA.GetMaxStrId();
 return strMaxSocialId;
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
public static string GetFirstID_S(string strWhereCond) 
{
 string strSocialId;
 try
 {
 strSocialId = new clsSysSocialRelationsDA().GetFirstID(strWhereCond);
 return strSocialId;
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
 arrList = SysSocialRelationsDA.GetID(strWhereCond);
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
bool bolIsExist = SysSocialRelationsDA.IsExistCondRec(strWhereCond);
return bolIsExist;
}

 /// <summary>
 /// 判断当前表中是否存在给定关键字值的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExist)
 /// </summary>
 /// <param name = "strSocialId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public static bool IsExist(string strSocialId)
{
if (string.IsNullOrEmpty(strSocialId) == true)
{
var strMsg = string.Format("(errid:Busi000027)在表中,关键字[strSocialId]不能为空!!(from {0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
//检测记录是否存在
bool bolIsExist = SysSocialRelationsDA.IsExist(strSocialId);
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
 bolIsExist = clsSysSocialRelationsDA.IsExistTable();
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
 bolIsExist = SysSocialRelationsDA.IsExistTable(strTabName);
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
 /// <param name = "objSysSocialRelationsEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecordBySql2(clsSysSocialRelationsEN objSysSocialRelationsEN, bool bolIsNeedCheckUniqueness=true)
{
if (bolIsNeedCheckUniqueness == true && objSysSocialRelationsEN.CheckUniqueness() == false)
{
var strMsg = string.Format("记录已经存在!社会Id = [{0}]的数据已经存在!(in clsSysSocialRelationsBL.AddNewRecordBySql2)", objSysSocialRelationsEN.SocialId);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objSysSocialRelationsEN.SocialId) == true || clsSysSocialRelationsBL.IsExist(objSysSocialRelationsEN.SocialId) == true)
 {
     objSysSocialRelationsEN.SocialId = clsSysSocialRelationsBL.GetMaxStrId_S();
 }
bool bolResult = SysSocialRelationsDA.AddNewRecordBySQL2(objSysSocialRelationsEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsSysSocialRelationsBL.ReFreshCache(objSysSocialRelationsEN.IdCurrEduCls);

if (clsSysSocialRelationsBL.relatedActions != null)
{
clsSysSocialRelationsBL.relatedActions.UpdRelaTabDate(objSysSocialRelationsEN.SocialId, "SetUpdDate");
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
 /// <param name = "objSysSocialRelationsEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordBySql2WithReturnKey(clsSysSocialRelationsEN objSysSocialRelationsEN, bool bolIsNeedCheckUniqueness=true)
{
if (bolIsNeedCheckUniqueness == true && objSysSocialRelationsEN.CheckUniqueness() == false)
{
var strMsg = string.Format("记录已经存在!社会Id = [{0}]的数据已经存在!(in clsSysSocialRelationsBL.AddNewRecordBySql2WithReturnKey)", objSysSocialRelationsEN.SocialId);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objSysSocialRelationsEN.SocialId) == true || clsSysSocialRelationsBL.IsExist(objSysSocialRelationsEN.SocialId) == true)
 {
     objSysSocialRelationsEN.SocialId = clsSysSocialRelationsBL.GetMaxStrId_S();
 }
string strKey = SysSocialRelationsDA.AddNewRecordBySQL2WithReturnKey(objSysSocialRelationsEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsSysSocialRelationsBL.ReFreshCache(objSysSocialRelationsEN.IdCurrEduCls);

if (clsSysSocialRelationsBL.relatedActions != null)
{
clsSysSocialRelationsBL.relatedActions.UpdRelaTabDate(objSysSocialRelationsEN.SocialId, "SetUpdDate");
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
 /// <param name = "objSysSocialRelationsEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(clsSysSocialRelationsEN objSysSocialRelationsEN)
{
try
{
bool bolResult = SysSocialRelationsDA.Update(objSysSocialRelationsEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsSysSocialRelationsBL.ReFreshCache(objSysSocialRelationsEN.IdCurrEduCls);

if (clsSysSocialRelationsBL.relatedActions != null)
{
clsSysSocialRelationsBL.relatedActions.UpdRelaTabDate(objSysSocialRelationsEN.SocialId, "SetUpdDate");
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
 /// <param name = "objSysSocialRelationsEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateBySql2(clsSysSocialRelationsEN objSysSocialRelationsEN)
{
 if (string.IsNullOrEmpty(objSysSocialRelationsEN.SocialId) == true)
 {
var strMsg = string.Format("(errid:Busi000065)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = SysSocialRelationsDA.UpdateBySql2(objSysSocialRelationsEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsSysSocialRelationsBL.ReFreshCache(objSysSocialRelationsEN.IdCurrEduCls);

if (clsSysSocialRelationsBL.relatedActions != null)
{
clsSysSocialRelationsBL.relatedActions.UpdRelaTabDate(objSysSocialRelationsEN.SocialId, "SetUpdDate");
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
 /// <param name = "strSocialId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int DelRecord(string strSocialId)
{
try
{
 clsSysSocialRelationsEN objSysSocialRelationsEN = clsSysSocialRelationsBL.GetObjBySocialId(strSocialId);

if (clsSysSocialRelationsBL.relatedActions != null)
{
clsSysSocialRelationsBL.relatedActions.UpdRelaTabDate(objSysSocialRelationsEN.SocialId, "SetUpdDate");
}
if (objSysSocialRelationsEN != null)
{
int intRecNum = SysSocialRelationsDA.DelRecord(strSocialId);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
ReFreshCache(objSysSocialRelationsEN.IdCurrEduCls);
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
/// <param name="strSocialId">表关键字</param>
 /// <param name = "strIdCurrEduCls">缓存的分类字段</param>
/// <returns></returns>
public static bool DelRecordEx(string strSocialId , string strIdCurrEduCls)
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsSysSocialRelationsDA.GetSpecSQLObj();
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
//删除与表:[SysSocialRelations]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conSysSocialRelations.SocialId,
//strSocialId);
//        clsSysSocialRelationsBL.DelSysSocialRelationssByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsSysSocialRelationsBL.DelRecord(strSocialId, strIdCurrEduCls, objConnection, objSqlTransaction);
objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsSysSocialRelationsBLEx", "DelRecordEx", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("扩展删除记录出错:{0}!keyId = {1}.({2})",
objException.Message,
strSocialId, clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "strSocialId">给定的关键字值</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回删除是否成功?</returns>
public static bool DelRecord(string strSocialId, string strIdCurrEduCls, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
if (clsSysSocialRelationsBL.relatedActions != null)
{
clsSysSocialRelationsBL.relatedActions.UpdRelaTabDate(strSocialId, "UpdRelaTabDate");
}
bool bolResult = SysSocialRelationsDA.DelRecord(strSocialId,objSqlConnection,objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
ReFreshCache(strIdCurrEduCls);
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
 /// <param name = "arrSocialIdLst">给定的关键字值列表</param>
 /// <returns>返回删除的记录数</returns>
public static int DelSysSocialRelationss(List<string> arrSocialIdLst)
{
if (arrSocialIdLst.Count == 0) return 0;
try
{
if (clsSysSocialRelationsBL.relatedActions != null)
{
foreach (var strSocialId in arrSocialIdLst)
{
clsSysSocialRelationsBL.relatedActions.UpdRelaTabDate(strSocialId, "UpdRelaTabDate");
}
}
 clsSysSocialRelationsEN objSysSocialRelationsEN = clsSysSocialRelationsBL.GetObjBySocialId(arrSocialIdLst[0]);
int intDelRecNum = SysSocialRelationsDA.DelSysSocialRelations(arrSocialIdLst);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
ReFreshCache(objSysSocialRelationsEN.IdCurrEduCls);
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
public static int DelSysSocialRelationssByCond(string strWhereCond)
{
try
{
if (clsSysSocialRelationsBL.relatedActions != null)
{
List<string> arrSocialId = GetPrimaryKeyID_S(strWhereCond);
foreach (var strSocialId in arrSocialId)
{
clsSysSocialRelationsBL.relatedActions.UpdRelaTabDate(strSocialId, "UpdRelaTabDate");
}
}
List<string> arrIdCurrEduCls = GetFldValue(conSysSocialRelations.IdCurrEduCls, strWhereCond);
int intRecNum = SysSocialRelationsDA.DelSysSocialRelations(strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
arrIdCurrEduCls.ForEach(x => ReFreshCache(x));
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
/// 这里仅仅是演示函数,使用时请复制到扩展类:[SysSocialRelations]中改名为:[DelRecord4MultiTabEx]使用
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DelRecord4MultiTab)
/// </summary>
/// <param name="strSocialId">表关键字</param>
 /// <param name = "strIdCurrEduCls">缓存的分类字段</param>
/// <returns></returns>
public static bool DelRecord4MultiTab(string strSocialId, string strIdCurrEduCls)
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsSysSocialRelationsDA.GetSpecSQLObj();
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
//删除与表:[SysSocialRelations]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conStudent.id_College,
//strid_College);
//        clsStudentBL.DelStudentsByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsSysSocialRelationsBL.DelRecord(strSocialId, strIdCurrEduCls, objConnection, objSqlTransaction);
                objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsSysSocialRelationsBL", "DelRecord4MultiTab", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("删除多表记录出错:{0}!keyId = {1}.({2})",
objException.Message,
strSocialId, clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "objSysSocialRelationsENS">源对象</param>
 /// <param name = "objSysSocialRelationsENT">目标对象</param>
 public static void CopyTo(clsSysSocialRelationsEN objSysSocialRelationsENS, clsSysSocialRelationsEN objSysSocialRelationsENT)
{
try
{
objSysSocialRelationsENT.SocialId = objSysSocialRelationsENS.SocialId; //社会Id
objSysSocialRelationsENT.FullName = objSysSocialRelationsENS.FullName; //姓名
objSysSocialRelationsENT.Nationality = objSysSocialRelationsENS.Nationality; //国籍
objSysSocialRelationsENT.WorkUnit = objSysSocialRelationsENS.WorkUnit; //工作单位
objSysSocialRelationsENT.Major = objSysSocialRelationsENS.Major; //专业
objSysSocialRelationsENT.Achievement = objSysSocialRelationsENS.Achievement; //成就
objSysSocialRelationsENT.DetailedDescription = objSysSocialRelationsENS.DetailedDescription; //详细说明
objSysSocialRelationsENT.LevelId = objSysSocialRelationsENS.LevelId; //级别Id
objSysSocialRelationsENT.UpdUser = objSysSocialRelationsENS.UpdUser; //修改人
objSysSocialRelationsENT.UpdDate = objSysSocialRelationsENS.UpdDate; //修改日期
objSysSocialRelationsENT.IsSubmit = objSysSocialRelationsENS.IsSubmit; //是否提交
objSysSocialRelationsENT.OkCount = objSysSocialRelationsENS.OkCount; //点赞统计
objSysSocialRelationsENT.CitationCount = objSysSocialRelationsENS.CitationCount; //引用统计
objSysSocialRelationsENT.VersionCount = objSysSocialRelationsENS.VersionCount; //版本统计
objSysSocialRelationsENT.IdCurrEduCls = objSysSocialRelationsENS.IdCurrEduCls; //教学班流水号
objSysSocialRelationsENT.Memo = objSysSocialRelationsENS.Memo; //备注
objSysSocialRelationsENT.AppraiseCount = objSysSocialRelationsENS.AppraiseCount; //评论数
objSysSocialRelationsENT.Score = objSysSocialRelationsENS.Score; //评分
objSysSocialRelationsENT.StuScore = objSysSocialRelationsENS.StuScore; //学生平均分
objSysSocialRelationsENT.TeaScore = objSysSocialRelationsENS.TeaScore; //教师评分
objSysSocialRelationsENT.CitationId = objSysSocialRelationsENS.CitationId; //引用Id
objSysSocialRelationsENT.CreateDate = objSysSocialRelationsENS.CreateDate; //建立日期
objSysSocialRelationsENT.ShareId = objSysSocialRelationsENS.ShareId; //分享Id
objSysSocialRelationsENT.PdfContent = objSysSocialRelationsENS.PdfContent; //Pdf内容
objSysSocialRelationsENT.PdfPageNum = objSysSocialRelationsENS.PdfPageNum; //Pdf页码
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
 /// <param name = "objSysSocialRelationsEN">源简化对象</param>
 public static void SetUpdFlag(clsSysSocialRelationsEN objSysSocialRelationsEN)
{
try
{
objSysSocialRelationsEN.ClearUpdateState();
   string strsfUpdFldSetStr = objSysSocialRelationsEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(conSysSocialRelations.SocialId, new clsStrCompareIgnoreCase())  ==  true)
{
objSysSocialRelationsEN.SocialId = objSysSocialRelationsEN.SocialId; //社会Id
}
if (arrFldSet.Contains(conSysSocialRelations.FullName, new clsStrCompareIgnoreCase())  ==  true)
{
objSysSocialRelationsEN.FullName = objSysSocialRelationsEN.FullName == "[null]" ? null :  objSysSocialRelationsEN.FullName; //姓名
}
if (arrFldSet.Contains(conSysSocialRelations.Nationality, new clsStrCompareIgnoreCase())  ==  true)
{
objSysSocialRelationsEN.Nationality = objSysSocialRelationsEN.Nationality == "[null]" ? null :  objSysSocialRelationsEN.Nationality; //国籍
}
if (arrFldSet.Contains(conSysSocialRelations.WorkUnit, new clsStrCompareIgnoreCase())  ==  true)
{
objSysSocialRelationsEN.WorkUnit = objSysSocialRelationsEN.WorkUnit == "[null]" ? null :  objSysSocialRelationsEN.WorkUnit; //工作单位
}
if (arrFldSet.Contains(conSysSocialRelations.Major, new clsStrCompareIgnoreCase())  ==  true)
{
objSysSocialRelationsEN.Major = objSysSocialRelationsEN.Major == "[null]" ? null :  objSysSocialRelationsEN.Major; //专业
}
if (arrFldSet.Contains(conSysSocialRelations.Achievement, new clsStrCompareIgnoreCase())  ==  true)
{
objSysSocialRelationsEN.Achievement = objSysSocialRelationsEN.Achievement == "[null]" ? null :  objSysSocialRelationsEN.Achievement; //成就
}
if (arrFldSet.Contains(conSysSocialRelations.DetailedDescription, new clsStrCompareIgnoreCase())  ==  true)
{
objSysSocialRelationsEN.DetailedDescription = objSysSocialRelationsEN.DetailedDescription == "[null]" ? null :  objSysSocialRelationsEN.DetailedDescription; //详细说明
}
if (arrFldSet.Contains(conSysSocialRelations.LevelId, new clsStrCompareIgnoreCase())  ==  true)
{
objSysSocialRelationsEN.LevelId = objSysSocialRelationsEN.LevelId == "[null]" ? null :  objSysSocialRelationsEN.LevelId; //级别Id
}
if (arrFldSet.Contains(conSysSocialRelations.UpdUser, new clsStrCompareIgnoreCase())  ==  true)
{
objSysSocialRelationsEN.UpdUser = objSysSocialRelationsEN.UpdUser == "[null]" ? null :  objSysSocialRelationsEN.UpdUser; //修改人
}
if (arrFldSet.Contains(conSysSocialRelations.UpdDate, new clsStrCompareIgnoreCase())  ==  true)
{
objSysSocialRelationsEN.UpdDate = objSysSocialRelationsEN.UpdDate == "[null]" ? null :  objSysSocialRelationsEN.UpdDate; //修改日期
}
if (arrFldSet.Contains(conSysSocialRelations.IsSubmit, new clsStrCompareIgnoreCase())  ==  true)
{
objSysSocialRelationsEN.IsSubmit = objSysSocialRelationsEN.IsSubmit; //是否提交
}
if (arrFldSet.Contains(conSysSocialRelations.OkCount, new clsStrCompareIgnoreCase())  ==  true)
{
objSysSocialRelationsEN.OkCount = objSysSocialRelationsEN.OkCount; //点赞统计
}
if (arrFldSet.Contains(conSysSocialRelations.CitationCount, new clsStrCompareIgnoreCase())  ==  true)
{
objSysSocialRelationsEN.CitationCount = objSysSocialRelationsEN.CitationCount; //引用统计
}
if (arrFldSet.Contains(conSysSocialRelations.VersionCount, new clsStrCompareIgnoreCase())  ==  true)
{
objSysSocialRelationsEN.VersionCount = objSysSocialRelationsEN.VersionCount; //版本统计
}
if (arrFldSet.Contains(conSysSocialRelations.IdCurrEduCls, new clsStrCompareIgnoreCase())  ==  true)
{
objSysSocialRelationsEN.IdCurrEduCls = objSysSocialRelationsEN.IdCurrEduCls == "[null]" ? null :  objSysSocialRelationsEN.IdCurrEduCls; //教学班流水号
}
if (arrFldSet.Contains(conSysSocialRelations.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objSysSocialRelationsEN.Memo = objSysSocialRelationsEN.Memo == "[null]" ? null :  objSysSocialRelationsEN.Memo; //备注
}
if (arrFldSet.Contains(conSysSocialRelations.AppraiseCount, new clsStrCompareIgnoreCase())  ==  true)
{
objSysSocialRelationsEN.AppraiseCount = objSysSocialRelationsEN.AppraiseCount; //评论数
}
if (arrFldSet.Contains(conSysSocialRelations.Score, new clsStrCompareIgnoreCase())  ==  true)
{
objSysSocialRelationsEN.Score = objSysSocialRelationsEN.Score; //评分
}
if (arrFldSet.Contains(conSysSocialRelations.StuScore, new clsStrCompareIgnoreCase())  ==  true)
{
objSysSocialRelationsEN.StuScore = objSysSocialRelationsEN.StuScore; //学生平均分
}
if (arrFldSet.Contains(conSysSocialRelations.TeaScore, new clsStrCompareIgnoreCase())  ==  true)
{
objSysSocialRelationsEN.TeaScore = objSysSocialRelationsEN.TeaScore; //教师评分
}
if (arrFldSet.Contains(conSysSocialRelations.CitationId, new clsStrCompareIgnoreCase())  ==  true)
{
objSysSocialRelationsEN.CitationId = objSysSocialRelationsEN.CitationId == "[null]" ? null :  objSysSocialRelationsEN.CitationId; //引用Id
}
if (arrFldSet.Contains(conSysSocialRelations.CreateDate, new clsStrCompareIgnoreCase())  ==  true)
{
objSysSocialRelationsEN.CreateDate = objSysSocialRelationsEN.CreateDate == "[null]" ? null :  objSysSocialRelationsEN.CreateDate; //建立日期
}
if (arrFldSet.Contains(conSysSocialRelations.ShareId, new clsStrCompareIgnoreCase())  ==  true)
{
objSysSocialRelationsEN.ShareId = objSysSocialRelationsEN.ShareId == "[null]" ? null :  objSysSocialRelationsEN.ShareId; //分享Id
}
if (arrFldSet.Contains(conSysSocialRelations.PdfContent, new clsStrCompareIgnoreCase())  ==  true)
{
objSysSocialRelationsEN.PdfContent = objSysSocialRelationsEN.PdfContent == "[null]" ? null :  objSysSocialRelationsEN.PdfContent; //Pdf内容
}
if (arrFldSet.Contains(conSysSocialRelations.PdfPageNum, new clsStrCompareIgnoreCase())  ==  true)
{
objSysSocialRelationsEN.PdfPageNum = objSysSocialRelationsEN.PdfPageNum; //Pdf页码
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
 /// <param name = "objSysSocialRelationsEN">源简化对象</param>
 public static void AccessFldValueNull(clsSysSocialRelationsEN objSysSocialRelationsEN)
{
try
{
if (objSysSocialRelationsEN.FullName == "[null]") objSysSocialRelationsEN.FullName = null; //姓名
if (objSysSocialRelationsEN.Nationality == "[null]") objSysSocialRelationsEN.Nationality = null; //国籍
if (objSysSocialRelationsEN.WorkUnit == "[null]") objSysSocialRelationsEN.WorkUnit = null; //工作单位
if (objSysSocialRelationsEN.Major == "[null]") objSysSocialRelationsEN.Major = null; //专业
if (objSysSocialRelationsEN.Achievement == "[null]") objSysSocialRelationsEN.Achievement = null; //成就
if (objSysSocialRelationsEN.DetailedDescription == "[null]") objSysSocialRelationsEN.DetailedDescription = null; //详细说明
if (objSysSocialRelationsEN.LevelId == "[null]") objSysSocialRelationsEN.LevelId = null; //级别Id
if (objSysSocialRelationsEN.UpdUser == "[null]") objSysSocialRelationsEN.UpdUser = null; //修改人
if (objSysSocialRelationsEN.UpdDate == "[null]") objSysSocialRelationsEN.UpdDate = null; //修改日期
if (objSysSocialRelationsEN.IdCurrEduCls == "[null]") objSysSocialRelationsEN.IdCurrEduCls = null; //教学班流水号
if (objSysSocialRelationsEN.Memo == "[null]") objSysSocialRelationsEN.Memo = null; //备注
if (objSysSocialRelationsEN.CitationId == "[null]") objSysSocialRelationsEN.CitationId = null; //引用Id
if (objSysSocialRelationsEN.CreateDate == "[null]") objSysSocialRelationsEN.CreateDate = null; //建立日期
if (objSysSocialRelationsEN.ShareId == "[null]") objSysSocialRelationsEN.ShareId = null; //分享Id
if (objSysSocialRelationsEN.PdfContent == "[null]") objSysSocialRelationsEN.PdfContent = null; //Pdf内容
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
public static void CheckPropertyNew(clsSysSocialRelationsEN objSysSocialRelationsEN)
{
 SysSocialRelationsDA.CheckPropertyNew(objSysSocialRelationsEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(clsSysSocialRelationsEN objSysSocialRelationsEN)
{
 SysSocialRelationsDA.CheckProperty4Condition(objSysSocialRelationsEN);
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
if (clsSysSocialRelationsBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsSysSocialRelationsBL没有刷新缓存机制(clsSysSocialRelationsBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by SocialId");
//if (arrSysSocialRelationsObjLstCache == null)
//{
//arrSysSocialRelationsObjLstCache = SysSocialRelationsDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "strSocialId">所给的关键字</param>
 /// <param name = "strIdCurrEduCls">缓存的分类字段</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsSysSocialRelationsEN GetObjBySocialIdCache(string strSocialId, string strIdCurrEduCls)
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
string strKey = string.Format("{0}_{1}", clsSysSocialRelationsEN._CurrTabName, strIdCurrEduCls);
List<clsSysSocialRelationsEN> arrSysSocialRelationsObjLstCache = GetObjLstCache(strIdCurrEduCls);
IEnumerable <clsSysSocialRelationsEN> arrSysSocialRelationsObjLst_Sel =
arrSysSocialRelationsObjLstCache
.Where(x=> x.SocialId == strSocialId 
);
if (arrSysSocialRelationsObjLst_Sel.Count() == 0)
{
   clsSysSocialRelationsEN obj = clsSysSocialRelationsBL.GetObjBySocialId(strSocialId);
   if (obj != null)
 {
if (obj.IdCurrEduCls == strIdCurrEduCls)
{
CacheHelper.Remove(strKey);
     return obj;
}
else
{
string strMsg = string.Format("错误: 关键字:{0}不属于分类:{1},请检查!(In {2})", strSocialId, strIdCurrEduCls, clsStackTrace.GetCurrClassFunction());
clsSysParaEN.objLog.WriteDebugLog(strMsg);
throw new Exception(strMsg);
}
 }
return null;
}
return arrSysSocialRelationsObjLst_Sel.First();
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsSysSocialRelationsEN> GetAllSysSocialRelationsObjLstCache(string strIdCurrEduCls)
{
//获取缓存中的对象列表
List<clsSysSocialRelationsEN> arrSysSocialRelationsObjLstCache = GetObjLstCache(strIdCurrEduCls); 
return arrSysSocialRelationsObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsSysSocialRelationsEN> GetObjLstCache(string strIdCurrEduCls)
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
string strKey = string.Format("{0}_{1}", clsSysSocialRelationsEN._CurrTabName, strIdCurrEduCls);
string strCondition = string.Format("IdCurrEduCls='{0}'", strIdCurrEduCls);
List<clsSysSocialRelationsEN> arrSysSocialRelationsObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst(strCondition); });
return arrSysSocialRelationsObjLstCache;
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
string strKey = string.Format("{0}_{1}", clsSysSocialRelationsEN._CurrTabName, strIdCurrEduCls);
CacheHelper.Remove(strKey);
clsSysSocialRelationsEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
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
if (clsSysSocialRelationsEN._RefreshTimeLst.Count == 0) return "";
return clsSysSocialRelationsEN._RefreshTimeLst[clsSysSocialRelationsEN._RefreshTimeLst.Count - 1];
}

 /// <summary>
 /// 刷新缓存.把当前表的缓存以及该表相关视图的缓存清空.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ReFreshCache)
 /// </summary>
public static void ReFreshCache(string strIdCurrEduCls)
{
if (string.IsNullOrEmpty(strIdCurrEduCls) == true)
{
string strMsg = string.Format("缓存分类字段:[IdCurrEduCls]不能为空!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsSysSocialRelationsBL.objCommFun4BL != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}_{1}", clsSysSocialRelationsEN._CurrTabName, strIdCurrEduCls);
CacheHelper.Remove(strKey);
clsSysSocialRelationsEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
clsSysSocialRelationsBL.objCommFun4BL.ReFreshCache(strIdCurrEduCls);
}
}


 #endregion 缓存操作


 #region 检查唯一性

 /// <summary>
 /// 获取检查唯一性条件串(Uniqueness)--SysSocialRelations(社会关系表)
 /// 唯一性条件:SocialId
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetUniquenessConditionString)
 /// </summary>
 /// <param name = "objSysSocialRelationsEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(clsSysSocialRelationsEN objSysSocialRelationsEN)
{
//检测记录是否存在
string strResult = SysSocialRelationsDA.GetUniCondStr(objSysSocialRelationsEN);
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
 /// <param name = "strIdCurrEduCls">缓存的分类字段</param>
 /// <returns>返回一个输出字段值</returns>
public static string Func(string strInFldName, string strOutFldName, string strSocialId, string strIdCurrEduCls)
{
if (strInFldName != conSysSocialRelations.SocialId)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (conSysSocialRelations.AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", conSysSocialRelations.AttributeName));
throw new Exception(strMsg);
}
var objSysSocialRelations = clsSysSocialRelationsBL.GetObjBySocialIdCache(strSocialId, strIdCurrEduCls);
if (objSysSocialRelations == null) return "";
return objSysSocialRelations[strOutFldName].ToString();
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
int intRecCount = clsSysSocialRelationsDA.GetRecCount(strTabName);
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
int intRecCount = clsSysSocialRelationsDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsSysSocialRelationsDA.GetRecCount();
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
int intRecCount = clsSysSocialRelationsDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objSysSocialRelationsCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsSysSocialRelationsEN objSysSocialRelationsCond)
{
 string strIdCurrEduCls = objSysSocialRelationsCond.IdCurrEduCls;
 if (string.IsNullOrEmpty(strIdCurrEduCls) == true)
{
string strMsg = string.Format("(errid:Busi000174)在表中,缓存分类字段值不能为空!(clsSysSocialRelationsBL:GetRecCountByCondCache)");
throw new Exception(strMsg);
}
List<clsSysSocialRelationsEN> arrObjLstCache = GetObjLstCache(strIdCurrEduCls);
IEnumerable <clsSysSocialRelationsEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conSysSocialRelations.AttributeName)
{
if (objSysSocialRelationsCond.IsUpdated(strFldName) == false) continue;
if (objSysSocialRelationsCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objSysSocialRelationsCond[strFldName].ToString());
}
else
{
if (objSysSocialRelationsCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objSysSocialRelationsCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objSysSocialRelationsCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objSysSocialRelationsCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objSysSocialRelationsCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objSysSocialRelationsCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objSysSocialRelationsCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objSysSocialRelationsCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objSysSocialRelationsCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objSysSocialRelationsCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objSysSocialRelationsCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objSysSocialRelationsCond[strFldName]));
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
 List<string> arrList = clsSysSocialRelationsDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = SysSocialRelationsDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = SysSocialRelationsDA.GetFldValueNoDistinct(strFldName, strWhereCond);
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
int intRecCount = SysSocialRelationsDA.SetFldValue(strFldName, strValue, strWhereCond);
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
int intRecCount = clsSysSocialRelationsDA.SetFldValue(clsSysSocialRelationsEN._CurrTabName, strFldName, fltValue, strWhereCond);
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
int intRecCount = SysSocialRelationsDA.SetFldValue( strFldName, intValue, strWhereCond);
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
int intRecCount = clsSysSocialRelationsDA.SetFldValue(strTabName, strFldName, strValue, strWhereCond);
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
int intRecCount = clsSysSocialRelationsDA.SetFldValue(strTabName, strFldName, intValue, strWhereCond);
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
int intRecCount = clsSysSocialRelationsDA.SetFldValue(strTabName, strFldName, fltValue, strWhereCond);
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
  strCreateTabCode.Append("CREATE table [dbo].[SysSocialRelations] "); 
 strCreateTabCode.Append(" ( "); 
 // /**社会Id*/ 
 strCreateTabCode.Append(" SocialId char(10) primary key, "); 
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
 // /**是否提交*/ 
 strCreateTabCode.Append(" IsSubmit bit Null, "); 
 // /**点赞统计*/ 
 strCreateTabCode.Append(" OkCount int Null, "); 
 // /**引用统计*/ 
 strCreateTabCode.Append(" CitationCount int Null, "); 
 // /**版本统计*/ 
 strCreateTabCode.Append(" VersionCount int Null, "); 
 // /**教学班流水号*/ 
 strCreateTabCode.Append(" IdCurrEduCls char(8) Null, "); 
 // /**备注*/ 
 strCreateTabCode.Append(" Memo varchar(1000) Null, "); 
 // /**评论数*/ 
 strCreateTabCode.Append(" AppraiseCount int Null, "); 
 // /**评分*/ 
 strCreateTabCode.Append(" Score float Null, "); 
 // /**学生平均分*/ 
 strCreateTabCode.Append(" StuScore float Null, "); 
 // /**教师评分*/ 
 strCreateTabCode.Append(" TeaScore float Null, "); 
 // /**引用Id*/ 
 strCreateTabCode.Append(" CitationId char(8) Null, "); 
 // /**建立日期*/ 
 strCreateTabCode.Append(" CreateDate varchar(20) Null, "); 
 // /**分享Id*/ 
 strCreateTabCode.Append(" ShareId char(2) Null, "); 
 // /**Pdf内容*/ 
 strCreateTabCode.Append(" PdfContent varchar(2000) Null, "); 
 // /**Pdf页码*/ 
 strCreateTabCode.Append(" PdfPageNum int Null ");
 strCreateTabCode.Append(") "); 
  strCreateTabCode.Append("ON [PRIMARY] ");
  return strCreateTabCode.ToString();
}



 #endregion 表操作
}
 /// <summary>
 /// 社会关系表(SysSocialRelations)
 /// 数据源类型:表
 /// (AutoGCLib.CommFun4BL4CSharp:GeneCode_This)
 /// </summary>
public class  clsCommFun4BL4SysSocialRelations : clsCommFun4BLV2
{

 /// <summary>
 /// 刷新缓存.把当前表的缓存以及该表相关视图的缓存清空.
 /// (AutoGCLib.CommFun4BL4CSharp:Gen_4CFBL_ReFreshCache)
 /// </summary>
public override void ReFreshCache(string strIdCurrEduCls)
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
clsSysSocialRelationsBL.ReFreshThisCache(strIdCurrEduCls);
}
}

}