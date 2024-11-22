
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clszx_SocialRelationsBL
 表名:zx_SocialRelations(01120707)
 * 版本:2023.11.15.1(服务器:WIN-SRV103-116)
 日期:2023/11/15 22:56:17
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:研究生学习游戏化后台(变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:中学生课件管理(ZXCourseware)
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
public static class  clszx_SocialRelationsBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "strzxSocialId">表关键字</param>
 /// <returns>表对象</returns>
public static clszx_SocialRelationsEN GetObj(this K_zxSocialId_zx_SocialRelations myKey)
{
clszx_SocialRelationsEN objzx_SocialRelationsEN = clszx_SocialRelationsBL.zx_SocialRelationsDA.GetObjByzxSocialId(myKey.Value);
return objzx_SocialRelationsEN;
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_AddNewRecord)
 /// </summary>
 /// <param name = "objzx_SocialRelationsEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clszx_SocialRelationsEN objzx_SocialRelationsEN)
{
if (CheckUniqueness(objzx_SocialRelationsEN) == false)
{
var strMsg = string.Format("记录已经存在!课件Id = [{0}]的数据已经存在!(in clszx_SocialRelationsBL.AddNewRecord)", objzx_SocialRelationsEN.TextId);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objzx_SocialRelationsEN.zxSocialId) == true || clszx_SocialRelationsBL.IsExist(objzx_SocialRelationsEN.zxSocialId) == true)
 {
     objzx_SocialRelationsEN.zxSocialId = clszx_SocialRelationsBL.GetMaxStrId_S();
 }
bool bolResult = clszx_SocialRelationsBL.zx_SocialRelationsDA.AddNewRecordBySQL2(objzx_SocialRelationsEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clszx_SocialRelationsBL.ReFreshCache(objzx_SocialRelationsEN.IdCurrEduCls);

if (clszx_SocialRelationsBL.relatedActions != null)
{
clszx_SocialRelationsBL.relatedActions.UpdRelaTabDate(objzx_SocialRelationsEN.zxSocialId, "SetUpdDate");
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
public static bool AddRecordEx(this clszx_SocialRelationsEN objzx_SocialRelationsEN)
{
//操作步骤:
//1、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在
//2、检查唯一性
//3、检查传进去的对象属性是否合法
//4、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
//1、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在

//因为是字符型自增主键,不需要检查主键是否已经存在,在添加时,再获取 最大值作为主键
//if (clszx_SocialRelationsBL.IsExist(objzx_SocialRelationsEN.zxSocialId))	//判断是否有相同的关键字
//{
//strMsg = "(errid:Busi000151)关键字字段已有相同的值";
//throw new Exception(strMsg);
//}
try
{
 //2、检查传进去的对象属性是否合法
objzx_SocialRelationsEN.CheckPropertyNew();
 ///5.2、检查唯一性
if (objzx_SocialRelationsEN.CheckUniqueness() == false)
{
strMsg = string.Format("(课件Id(TextId)=[{0}])已经存在,不能重复!", objzx_SocialRelationsEN.TextId);
throw new Exception(strMsg);
}
//因为是字符型自增主键,所以在添加时,自动获取主键值。
 if (string.IsNullOrEmpty(objzx_SocialRelationsEN.zxSocialId) == true || clszx_SocialRelationsBL.IsExist(objzx_SocialRelationsEN.zxSocialId) == true)
 {
     objzx_SocialRelationsEN.zxSocialId = clszx_SocialRelationsBL.GetMaxStrId_S();
 }
//6、把数据实体层的数据存贮到数据库中
objzx_SocialRelationsEN.AddNewRecord();
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
 /// <param name = "objzx_SocialRelationsEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static string AddNewRecordWithMaxId(this clszx_SocialRelationsEN objzx_SocialRelationsEN)
{
if (CheckUniqueness(objzx_SocialRelationsEN) == false)
{
var strMsg = string.Format("记录已经存在!课件Id = [{0}]的数据已经存在!(in clszx_SocialRelationsBL.AddNewRecordWithMaxId)", objzx_SocialRelationsEN.TextId);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objzx_SocialRelationsEN.zxSocialId) == true || clszx_SocialRelationsBL.IsExist(objzx_SocialRelationsEN.zxSocialId) == true)
 {
     objzx_SocialRelationsEN.zxSocialId = clszx_SocialRelationsBL.GetMaxStrId_S();
 }
string strzxSocialId = clszx_SocialRelationsBL.zx_SocialRelationsDA.AddNewRecordBySQL2WithReturnKey(objzx_SocialRelationsEN);
     objzx_SocialRelationsEN.zxSocialId = strzxSocialId;
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clszx_SocialRelationsBL.ReFreshCache(objzx_SocialRelationsEN.IdCurrEduCls);

if (clszx_SocialRelationsBL.relatedActions != null)
{
clszx_SocialRelationsBL.relatedActions.UpdRelaTabDate(objzx_SocialRelationsEN.zxSocialId, "SetUpdDate");
}
return strzxSocialId;
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
 /// <param name = "objzx_SocialRelationsEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordWithReturnKey(this clszx_SocialRelationsEN objzx_SocialRelationsEN)
{
if (CheckUniqueness(objzx_SocialRelationsEN) == false)
{
var strMsg = string.Format("记录已经存在!课件Id = [{0}]的数据已经存在!(in clszx_SocialRelationsBL.AddNewRecordWithReturnKey)", objzx_SocialRelationsEN.TextId);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objzx_SocialRelationsEN.zxSocialId) == true || clszx_SocialRelationsBL.IsExist(objzx_SocialRelationsEN.zxSocialId) == true)
 {
     objzx_SocialRelationsEN.zxSocialId = clszx_SocialRelationsBL.GetMaxStrId_S();
 }
string strKey = clszx_SocialRelationsBL.zx_SocialRelationsDA.AddNewRecordBySQL2WithReturnKey(objzx_SocialRelationsEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clszx_SocialRelationsBL.ReFreshCache(objzx_SocialRelationsEN.IdCurrEduCls);

if (clszx_SocialRelationsBL.relatedActions != null)
{
clszx_SocialRelationsBL.relatedActions.UpdRelaTabDate(objzx_SocialRelationsEN.zxSocialId, "SetUpdDate");
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
 /// <param name = "objzx_SocialRelationsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clszx_SocialRelationsEN SetzxSocialId(this clszx_SocialRelationsEN objzx_SocialRelationsEN, string strzxSocialId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strzxSocialId, 10, conzx_SocialRelations.zxSocialId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strzxSocialId, 10, conzx_SocialRelations.zxSocialId);
}
objzx_SocialRelationsEN.zxSocialId = strzxSocialId; //社会Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objzx_SocialRelationsEN.dicFldComparisonOp.ContainsKey(conzx_SocialRelations.zxSocialId) == false)
{
objzx_SocialRelationsEN.dicFldComparisonOp.Add(conzx_SocialRelations.zxSocialId, strComparisonOp);
}
else
{
objzx_SocialRelationsEN.dicFldComparisonOp[conzx_SocialRelations.zxSocialId] = strComparisonOp;
}
}
return objzx_SocialRelationsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objzx_SocialRelationsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clszx_SocialRelationsEN SetFullName(this clszx_SocialRelationsEN objzx_SocialRelationsEN, string strFullName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFullName, 50, conzx_SocialRelations.FullName);
}
objzx_SocialRelationsEN.FullName = strFullName; //姓名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objzx_SocialRelationsEN.dicFldComparisonOp.ContainsKey(conzx_SocialRelations.FullName) == false)
{
objzx_SocialRelationsEN.dicFldComparisonOp.Add(conzx_SocialRelations.FullName, strComparisonOp);
}
else
{
objzx_SocialRelationsEN.dicFldComparisonOp[conzx_SocialRelations.FullName] = strComparisonOp;
}
}
return objzx_SocialRelationsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objzx_SocialRelationsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clszx_SocialRelationsEN SetNationality(this clszx_SocialRelationsEN objzx_SocialRelationsEN, string strNationality, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strNationality, 50, conzx_SocialRelations.Nationality);
}
objzx_SocialRelationsEN.Nationality = strNationality; //国籍
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objzx_SocialRelationsEN.dicFldComparisonOp.ContainsKey(conzx_SocialRelations.Nationality) == false)
{
objzx_SocialRelationsEN.dicFldComparisonOp.Add(conzx_SocialRelations.Nationality, strComparisonOp);
}
else
{
objzx_SocialRelationsEN.dicFldComparisonOp[conzx_SocialRelations.Nationality] = strComparisonOp;
}
}
return objzx_SocialRelationsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objzx_SocialRelationsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clszx_SocialRelationsEN SetWorkUnit(this clszx_SocialRelationsEN objzx_SocialRelationsEN, string strWorkUnit, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strWorkUnit, 100, conzx_SocialRelations.WorkUnit);
}
objzx_SocialRelationsEN.WorkUnit = strWorkUnit; //工作单位
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objzx_SocialRelationsEN.dicFldComparisonOp.ContainsKey(conzx_SocialRelations.WorkUnit) == false)
{
objzx_SocialRelationsEN.dicFldComparisonOp.Add(conzx_SocialRelations.WorkUnit, strComparisonOp);
}
else
{
objzx_SocialRelationsEN.dicFldComparisonOp[conzx_SocialRelations.WorkUnit] = strComparisonOp;
}
}
return objzx_SocialRelationsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objzx_SocialRelationsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clszx_SocialRelationsEN SetMajor(this clszx_SocialRelationsEN objzx_SocialRelationsEN, string strMajor, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMajor, 50, conzx_SocialRelations.Major);
}
objzx_SocialRelationsEN.Major = strMajor; //专业
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objzx_SocialRelationsEN.dicFldComparisonOp.ContainsKey(conzx_SocialRelations.Major) == false)
{
objzx_SocialRelationsEN.dicFldComparisonOp.Add(conzx_SocialRelations.Major, strComparisonOp);
}
else
{
objzx_SocialRelationsEN.dicFldComparisonOp[conzx_SocialRelations.Major] = strComparisonOp;
}
}
return objzx_SocialRelationsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objzx_SocialRelationsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clszx_SocialRelationsEN SetAchievement(this clszx_SocialRelationsEN objzx_SocialRelationsEN, string strAchievement, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strAchievement, 5000, conzx_SocialRelations.Achievement);
}
objzx_SocialRelationsEN.Achievement = strAchievement; //成就
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objzx_SocialRelationsEN.dicFldComparisonOp.ContainsKey(conzx_SocialRelations.Achievement) == false)
{
objzx_SocialRelationsEN.dicFldComparisonOp.Add(conzx_SocialRelations.Achievement, strComparisonOp);
}
else
{
objzx_SocialRelationsEN.dicFldComparisonOp[conzx_SocialRelations.Achievement] = strComparisonOp;
}
}
return objzx_SocialRelationsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objzx_SocialRelationsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clszx_SocialRelationsEN SetDetailedDescription(this clszx_SocialRelationsEN objzx_SocialRelationsEN, string strDetailedDescription, string strComparisonOp="")
	{
objzx_SocialRelationsEN.DetailedDescription = strDetailedDescription; //详细说明
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objzx_SocialRelationsEN.dicFldComparisonOp.ContainsKey(conzx_SocialRelations.DetailedDescription) == false)
{
objzx_SocialRelationsEN.dicFldComparisonOp.Add(conzx_SocialRelations.DetailedDescription, strComparisonOp);
}
else
{
objzx_SocialRelationsEN.dicFldComparisonOp[conzx_SocialRelations.DetailedDescription] = strComparisonOp;
}
}
return objzx_SocialRelationsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objzx_SocialRelationsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clszx_SocialRelationsEN SetzxLevelId(this clszx_SocialRelationsEN objzx_SocialRelationsEN, string strzxLevelId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strzxLevelId, 2, conzx_SocialRelations.zxLevelId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strzxLevelId, 2, conzx_SocialRelations.zxLevelId);
}
objzx_SocialRelationsEN.zxLevelId = strzxLevelId; //级别Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objzx_SocialRelationsEN.dicFldComparisonOp.ContainsKey(conzx_SocialRelations.zxLevelId) == false)
{
objzx_SocialRelationsEN.dicFldComparisonOp.Add(conzx_SocialRelations.zxLevelId, strComparisonOp);
}
else
{
objzx_SocialRelationsEN.dicFldComparisonOp[conzx_SocialRelations.zxLevelId] = strComparisonOp;
}
}
return objzx_SocialRelationsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objzx_SocialRelationsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clszx_SocialRelationsEN SetIsSubmit(this clszx_SocialRelationsEN objzx_SocialRelationsEN, bool bolIsSubmit, string strComparisonOp="")
	{
objzx_SocialRelationsEN.IsSubmit = bolIsSubmit; //是否提交
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objzx_SocialRelationsEN.dicFldComparisonOp.ContainsKey(conzx_SocialRelations.IsSubmit) == false)
{
objzx_SocialRelationsEN.dicFldComparisonOp.Add(conzx_SocialRelations.IsSubmit, strComparisonOp);
}
else
{
objzx_SocialRelationsEN.dicFldComparisonOp[conzx_SocialRelations.IsSubmit] = strComparisonOp;
}
}
return objzx_SocialRelationsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objzx_SocialRelationsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clszx_SocialRelationsEN SetVoteCount(this clszx_SocialRelationsEN objzx_SocialRelationsEN, int? intVoteCount, string strComparisonOp="")
	{
objzx_SocialRelationsEN.VoteCount = intVoteCount; //点赞计数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objzx_SocialRelationsEN.dicFldComparisonOp.ContainsKey(conzx_SocialRelations.VoteCount) == false)
{
objzx_SocialRelationsEN.dicFldComparisonOp.Add(conzx_SocialRelations.VoteCount, strComparisonOp);
}
else
{
objzx_SocialRelationsEN.dicFldComparisonOp[conzx_SocialRelations.VoteCount] = strComparisonOp;
}
}
return objzx_SocialRelationsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objzx_SocialRelationsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clszx_SocialRelationsEN SetCitationCount(this clszx_SocialRelationsEN objzx_SocialRelationsEN, int? intCitationCount, string strComparisonOp="")
	{
objzx_SocialRelationsEN.CitationCount = intCitationCount; //引用统计
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objzx_SocialRelationsEN.dicFldComparisonOp.ContainsKey(conzx_SocialRelations.CitationCount) == false)
{
objzx_SocialRelationsEN.dicFldComparisonOp.Add(conzx_SocialRelations.CitationCount, strComparisonOp);
}
else
{
objzx_SocialRelationsEN.dicFldComparisonOp[conzx_SocialRelations.CitationCount] = strComparisonOp;
}
}
return objzx_SocialRelationsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objzx_SocialRelationsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clszx_SocialRelationsEN SetVersionCount(this clszx_SocialRelationsEN objzx_SocialRelationsEN, int? intVersionCount, string strComparisonOp="")
	{
objzx_SocialRelationsEN.VersionCount = intVersionCount; //版本统计
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objzx_SocialRelationsEN.dicFldComparisonOp.ContainsKey(conzx_SocialRelations.VersionCount) == false)
{
objzx_SocialRelationsEN.dicFldComparisonOp.Add(conzx_SocialRelations.VersionCount, strComparisonOp);
}
else
{
objzx_SocialRelationsEN.dicFldComparisonOp[conzx_SocialRelations.VersionCount] = strComparisonOp;
}
}
return objzx_SocialRelationsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objzx_SocialRelationsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clszx_SocialRelationsEN SetIdCurrEduCls(this clszx_SocialRelationsEN objzx_SocialRelationsEN, string strIdCurrEduCls, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdCurrEduCls, 8, conzx_SocialRelations.IdCurrEduCls);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdCurrEduCls, 8, conzx_SocialRelations.IdCurrEduCls);
}
objzx_SocialRelationsEN.IdCurrEduCls = strIdCurrEduCls; //教学班流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objzx_SocialRelationsEN.dicFldComparisonOp.ContainsKey(conzx_SocialRelations.IdCurrEduCls) == false)
{
objzx_SocialRelationsEN.dicFldComparisonOp.Add(conzx_SocialRelations.IdCurrEduCls, strComparisonOp);
}
else
{
objzx_SocialRelationsEN.dicFldComparisonOp[conzx_SocialRelations.IdCurrEduCls] = strComparisonOp;
}
}
return objzx_SocialRelationsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objzx_SocialRelationsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clszx_SocialRelationsEN SetAppraiseCount(this clszx_SocialRelationsEN objzx_SocialRelationsEN, int? intAppraiseCount, string strComparisonOp="")
	{
objzx_SocialRelationsEN.AppraiseCount = intAppraiseCount; //评论数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objzx_SocialRelationsEN.dicFldComparisonOp.ContainsKey(conzx_SocialRelations.AppraiseCount) == false)
{
objzx_SocialRelationsEN.dicFldComparisonOp.Add(conzx_SocialRelations.AppraiseCount, strComparisonOp);
}
else
{
objzx_SocialRelationsEN.dicFldComparisonOp[conzx_SocialRelations.AppraiseCount] = strComparisonOp;
}
}
return objzx_SocialRelationsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objzx_SocialRelationsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clszx_SocialRelationsEN SetScore(this clszx_SocialRelationsEN objzx_SocialRelationsEN, float? fltScore, string strComparisonOp="")
	{
objzx_SocialRelationsEN.Score = fltScore; //评分
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objzx_SocialRelationsEN.dicFldComparisonOp.ContainsKey(conzx_SocialRelations.Score) == false)
{
objzx_SocialRelationsEN.dicFldComparisonOp.Add(conzx_SocialRelations.Score, strComparisonOp);
}
else
{
objzx_SocialRelationsEN.dicFldComparisonOp[conzx_SocialRelations.Score] = strComparisonOp;
}
}
return objzx_SocialRelationsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objzx_SocialRelationsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clszx_SocialRelationsEN SetStuScore(this clszx_SocialRelationsEN objzx_SocialRelationsEN, float? fltStuScore, string strComparisonOp="")
	{
objzx_SocialRelationsEN.StuScore = fltStuScore; //学生平均分
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objzx_SocialRelationsEN.dicFldComparisonOp.ContainsKey(conzx_SocialRelations.StuScore) == false)
{
objzx_SocialRelationsEN.dicFldComparisonOp.Add(conzx_SocialRelations.StuScore, strComparisonOp);
}
else
{
objzx_SocialRelationsEN.dicFldComparisonOp[conzx_SocialRelations.StuScore] = strComparisonOp;
}
}
return objzx_SocialRelationsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objzx_SocialRelationsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clszx_SocialRelationsEN SetTeaScore(this clszx_SocialRelationsEN objzx_SocialRelationsEN, float? fltTeaScore, string strComparisonOp="")
	{
objzx_SocialRelationsEN.TeaScore = fltTeaScore; //教师评分
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objzx_SocialRelationsEN.dicFldComparisonOp.ContainsKey(conzx_SocialRelations.TeaScore) == false)
{
objzx_SocialRelationsEN.dicFldComparisonOp.Add(conzx_SocialRelations.TeaScore, strComparisonOp);
}
else
{
objzx_SocialRelationsEN.dicFldComparisonOp[conzx_SocialRelations.TeaScore] = strComparisonOp;
}
}
return objzx_SocialRelationsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objzx_SocialRelationsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clszx_SocialRelationsEN SetTextId(this clszx_SocialRelationsEN objzx_SocialRelationsEN, string strTextId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTextId, 8, conzx_SocialRelations.TextId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strTextId, 8, conzx_SocialRelations.TextId);
}
objzx_SocialRelationsEN.TextId = strTextId; //课件Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objzx_SocialRelationsEN.dicFldComparisonOp.ContainsKey(conzx_SocialRelations.TextId) == false)
{
objzx_SocialRelationsEN.dicFldComparisonOp.Add(conzx_SocialRelations.TextId, strComparisonOp);
}
else
{
objzx_SocialRelationsEN.dicFldComparisonOp[conzx_SocialRelations.TextId] = strComparisonOp;
}
}
return objzx_SocialRelationsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objzx_SocialRelationsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clszx_SocialRelationsEN SetzxShareId(this clszx_SocialRelationsEN objzx_SocialRelationsEN, string strzxShareId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strzxShareId, 2, conzx_SocialRelations.zxShareId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strzxShareId, 2, conzx_SocialRelations.zxShareId);
}
objzx_SocialRelationsEN.zxShareId = strzxShareId; //分享Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objzx_SocialRelationsEN.dicFldComparisonOp.ContainsKey(conzx_SocialRelations.zxShareId) == false)
{
objzx_SocialRelationsEN.dicFldComparisonOp.Add(conzx_SocialRelations.zxShareId, strComparisonOp);
}
else
{
objzx_SocialRelationsEN.dicFldComparisonOp[conzx_SocialRelations.zxShareId] = strComparisonOp;
}
}
return objzx_SocialRelationsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objzx_SocialRelationsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clszx_SocialRelationsEN SetPdfContent(this clszx_SocialRelationsEN objzx_SocialRelationsEN, string strPdfContent, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPdfContent, 2000, conzx_SocialRelations.PdfContent);
}
objzx_SocialRelationsEN.PdfContent = strPdfContent; //Pdf内容
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objzx_SocialRelationsEN.dicFldComparisonOp.ContainsKey(conzx_SocialRelations.PdfContent) == false)
{
objzx_SocialRelationsEN.dicFldComparisonOp.Add(conzx_SocialRelations.PdfContent, strComparisonOp);
}
else
{
objzx_SocialRelationsEN.dicFldComparisonOp[conzx_SocialRelations.PdfContent] = strComparisonOp;
}
}
return objzx_SocialRelationsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objzx_SocialRelationsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clszx_SocialRelationsEN SetPdfPageNum(this clszx_SocialRelationsEN objzx_SocialRelationsEN, int? intPdfPageNum, string strComparisonOp="")
	{
objzx_SocialRelationsEN.PdfPageNum = intPdfPageNum; //Pdf页码
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objzx_SocialRelationsEN.dicFldComparisonOp.ContainsKey(conzx_SocialRelations.PdfPageNum) == false)
{
objzx_SocialRelationsEN.dicFldComparisonOp.Add(conzx_SocialRelations.PdfPageNum, strComparisonOp);
}
else
{
objzx_SocialRelationsEN.dicFldComparisonOp[conzx_SocialRelations.PdfPageNum] = strComparisonOp;
}
}
return objzx_SocialRelationsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objzx_SocialRelationsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clszx_SocialRelationsEN SetUpdUser(this clszx_SocialRelationsEN objzx_SocialRelationsEN, string strUpdUser, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdUser, 20, conzx_SocialRelations.UpdUser);
}
objzx_SocialRelationsEN.UpdUser = strUpdUser; //修改人
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objzx_SocialRelationsEN.dicFldComparisonOp.ContainsKey(conzx_SocialRelations.UpdUser) == false)
{
objzx_SocialRelationsEN.dicFldComparisonOp.Add(conzx_SocialRelations.UpdUser, strComparisonOp);
}
else
{
objzx_SocialRelationsEN.dicFldComparisonOp[conzx_SocialRelations.UpdUser] = strComparisonOp;
}
}
return objzx_SocialRelationsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objzx_SocialRelationsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clszx_SocialRelationsEN SetCreateDate(this clszx_SocialRelationsEN objzx_SocialRelationsEN, string strCreateDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCreateDate, 20, conzx_SocialRelations.CreateDate);
}
objzx_SocialRelationsEN.CreateDate = strCreateDate; //建立日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objzx_SocialRelationsEN.dicFldComparisonOp.ContainsKey(conzx_SocialRelations.CreateDate) == false)
{
objzx_SocialRelationsEN.dicFldComparisonOp.Add(conzx_SocialRelations.CreateDate, strComparisonOp);
}
else
{
objzx_SocialRelationsEN.dicFldComparisonOp[conzx_SocialRelations.CreateDate] = strComparisonOp;
}
}
return objzx_SocialRelationsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objzx_SocialRelationsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clszx_SocialRelationsEN SetUpdDate(this clszx_SocialRelationsEN objzx_SocialRelationsEN, string strUpdDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdDate, 20, conzx_SocialRelations.UpdDate);
}
objzx_SocialRelationsEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objzx_SocialRelationsEN.dicFldComparisonOp.ContainsKey(conzx_SocialRelations.UpdDate) == false)
{
objzx_SocialRelationsEN.dicFldComparisonOp.Add(conzx_SocialRelations.UpdDate, strComparisonOp);
}
else
{
objzx_SocialRelationsEN.dicFldComparisonOp[conzx_SocialRelations.UpdDate] = strComparisonOp;
}
}
return objzx_SocialRelationsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objzx_SocialRelationsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clszx_SocialRelationsEN SetMemo(this clszx_SocialRelationsEN objzx_SocialRelationsEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, conzx_SocialRelations.Memo);
}
objzx_SocialRelationsEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objzx_SocialRelationsEN.dicFldComparisonOp.ContainsKey(conzx_SocialRelations.Memo) == false)
{
objzx_SocialRelationsEN.dicFldComparisonOp.Add(conzx_SocialRelations.Memo, strComparisonOp);
}
else
{
objzx_SocialRelationsEN.dicFldComparisonOp[conzx_SocialRelations.Memo] = strComparisonOp;
}
}
return objzx_SocialRelationsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objzx_SocialRelationsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clszx_SocialRelationsEN SetPdfDivLet(this clszx_SocialRelationsEN objzx_SocialRelationsEN, string strPdfDivLet, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPdfDivLet, 50, conzx_SocialRelations.PdfDivLet);
}
objzx_SocialRelationsEN.PdfDivLet = strPdfDivLet; //PdfDivLet
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objzx_SocialRelationsEN.dicFldComparisonOp.ContainsKey(conzx_SocialRelations.PdfDivLet) == false)
{
objzx_SocialRelationsEN.dicFldComparisonOp.Add(conzx_SocialRelations.PdfDivLet, strComparisonOp);
}
else
{
objzx_SocialRelationsEN.dicFldComparisonOp[conzx_SocialRelations.PdfDivLet] = strComparisonOp;
}
}
return objzx_SocialRelationsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objzx_SocialRelationsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clszx_SocialRelationsEN SetPdfDivTop(this clszx_SocialRelationsEN objzx_SocialRelationsEN, string strPdfDivTop, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPdfDivTop, 50, conzx_SocialRelations.PdfDivTop);
}
objzx_SocialRelationsEN.PdfDivTop = strPdfDivTop; //PdfDivTop
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objzx_SocialRelationsEN.dicFldComparisonOp.ContainsKey(conzx_SocialRelations.PdfDivTop) == false)
{
objzx_SocialRelationsEN.dicFldComparisonOp.Add(conzx_SocialRelations.PdfDivTop, strComparisonOp);
}
else
{
objzx_SocialRelationsEN.dicFldComparisonOp[conzx_SocialRelations.PdfDivTop] = strComparisonOp;
}
}
return objzx_SocialRelationsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objzx_SocialRelationsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clszx_SocialRelationsEN SetPdfPageNumIn(this clszx_SocialRelationsEN objzx_SocialRelationsEN, string strPdfPageNumIn, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPdfPageNumIn, 50, conzx_SocialRelations.PdfPageNumIn);
}
objzx_SocialRelationsEN.PdfPageNumIn = strPdfPageNumIn; //PdfPageNumIn
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objzx_SocialRelationsEN.dicFldComparisonOp.ContainsKey(conzx_SocialRelations.PdfPageNumIn) == false)
{
objzx_SocialRelationsEN.dicFldComparisonOp.Add(conzx_SocialRelations.PdfPageNumIn, strComparisonOp);
}
else
{
objzx_SocialRelationsEN.dicFldComparisonOp[conzx_SocialRelations.PdfPageNumIn] = strComparisonOp;
}
}
return objzx_SocialRelationsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objzx_SocialRelationsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clszx_SocialRelationsEN SetPdfPageTop(this clszx_SocialRelationsEN objzx_SocialRelationsEN, int? intPdfPageTop, string strComparisonOp="")
	{
objzx_SocialRelationsEN.PdfPageTop = intPdfPageTop; //pdf页面顶部位置
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objzx_SocialRelationsEN.dicFldComparisonOp.ContainsKey(conzx_SocialRelations.PdfPageTop) == false)
{
objzx_SocialRelationsEN.dicFldComparisonOp.Add(conzx_SocialRelations.PdfPageTop, strComparisonOp);
}
else
{
objzx_SocialRelationsEN.dicFldComparisonOp[conzx_SocialRelations.PdfPageTop] = strComparisonOp;
}
}
return objzx_SocialRelationsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objzx_SocialRelationsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clszx_SocialRelationsEN SetPdfZoom(this clszx_SocialRelationsEN objzx_SocialRelationsEN, string strPdfZoom, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPdfZoom, 50, conzx_SocialRelations.PdfZoom);
}
objzx_SocialRelationsEN.PdfZoom = strPdfZoom; //PdfZoom
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objzx_SocialRelationsEN.dicFldComparisonOp.ContainsKey(conzx_SocialRelations.PdfZoom) == false)
{
objzx_SocialRelationsEN.dicFldComparisonOp.Add(conzx_SocialRelations.PdfZoom, strComparisonOp);
}
else
{
objzx_SocialRelationsEN.dicFldComparisonOp[conzx_SocialRelations.PdfZoom] = strComparisonOp;
}
}
return objzx_SocialRelationsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objzx_SocialRelationsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clszx_SocialRelationsEN SetGroupTextId(this clszx_SocialRelationsEN objzx_SocialRelationsEN, string strGroupTextId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strGroupTextId, 8, conzx_SocialRelations.GroupTextId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strGroupTextId, 8, conzx_SocialRelations.GroupTextId);
}
objzx_SocialRelationsEN.GroupTextId = strGroupTextId; //小组Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objzx_SocialRelationsEN.dicFldComparisonOp.ContainsKey(conzx_SocialRelations.GroupTextId) == false)
{
objzx_SocialRelationsEN.dicFldComparisonOp.Add(conzx_SocialRelations.GroupTextId, strComparisonOp);
}
else
{
objzx_SocialRelationsEN.dicFldComparisonOp[conzx_SocialRelations.GroupTextId] = strComparisonOp;
}
}
return objzx_SocialRelationsEN;
	}

 /// <summary>
 /// 修改记录存盘到数据表中
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_UpdateRecordEx)
 /// </summary>
 /// <param name = "objzx_SocialRelationsEN">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool UpdateRecordEx(this clszx_SocialRelationsEN objzx_SocialRelationsEN)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
try
{
//1、检查传进去的对象属性是否合法
objzx_SocialRelationsEN.CheckPropertyNew();
clszx_SocialRelationsEN objzx_SocialRelationsCond = new clszx_SocialRelationsEN();
string strCondition = objzx_SocialRelationsCond
.SetzxSocialId(objzx_SocialRelationsEN.zxSocialId, "<>")
.SetTextId(objzx_SocialRelationsEN.TextId, "=")
.GetCombineCondition();
objzx_SocialRelationsEN._IsCheckProperty = true;
bool bolIsExist = clszx_SocialRelationsBL.IsExistRecord(strCondition);
if (bolIsExist)
{
strMsg = "(TextId)不能重复!";
throw new Exception(strMsg);
}
//4、把数据实体层的数据存贮到数据库中
objzx_SocialRelationsEN.Update();
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
 /// <param name = "objzx_SocialRelations">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool EditRecordEx(this clszx_SocialRelationsEN objzx_SocialRelations)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
clszx_SocialRelationsEN objzx_SocialRelationsCond = new clszx_SocialRelationsEN();
string strCondition = objzx_SocialRelationsCond
.SetTextId(objzx_SocialRelations.TextId, "=")
.GetCombineCondition();
objzx_SocialRelations._IsCheckProperty = true;
bool bolIsExist = clszx_SocialRelationsBL.IsExistRecord(strCondition);
if (bolIsExist)
{
objzx_SocialRelations.zxSocialId = clszx_SocialRelationsBL.GetFirstID_S(strCondition);
objzx_SocialRelations.UpdateWithCondition(strCondition);
}
else
{
objzx_SocialRelations.zxSocialId = clszx_SocialRelationsBL.GetMaxStrId_S();
objzx_SocialRelations.AddNewRecord();
}
return true; 
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_Update)
 /// </summary>
 /// <param name = "objzx_SocialRelationsEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clszx_SocialRelationsEN objzx_SocialRelationsEN)
{
 if (string.IsNullOrEmpty(objzx_SocialRelationsEN.zxSocialId) == true)
 {
string strMsg = string.Format("(errid:Busi000095)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clszx_SocialRelationsBL.zx_SocialRelationsDA.UpdateBySql2(objzx_SocialRelationsEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clszx_SocialRelationsBL.ReFreshCache(objzx_SocialRelationsEN.IdCurrEduCls);

if (clszx_SocialRelationsBL.relatedActions != null)
{
clszx_SocialRelationsBL.relatedActions.UpdRelaTabDate(objzx_SocialRelationsEN.zxSocialId, "SetUpdDate");
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
 /// <param name = "objzx_SocialRelationsEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clszx_SocialRelationsEN objzx_SocialRelationsEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (string.IsNullOrEmpty(objzx_SocialRelationsEN.zxSocialId) == true)
 {
string strMsg = string.Format("(errid:Busi000087)修改记录时关键字不能为空!(带事务处理)(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clszx_SocialRelationsBL.zx_SocialRelationsDA.UpdateBySql2(objzx_SocialRelationsEN, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clszx_SocialRelationsBL.ReFreshCache(objzx_SocialRelationsEN.IdCurrEduCls);

if (clszx_SocialRelationsBL.relatedActions != null)
{
clszx_SocialRelationsBL.relatedActions.UpdRelaTabDate(objzx_SocialRelationsEN.zxSocialId, "SetUpdDate");
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
 /// <param name = "objzx_SocialRelationsEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clszx_SocialRelationsEN objzx_SocialRelationsEN, string strWhereCond)
{
try
{
bool bolResult = clszx_SocialRelationsBL.zx_SocialRelationsDA.UpdateBySqlWithCondition(objzx_SocialRelationsEN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clszx_SocialRelationsBL.ReFreshCache(objzx_SocialRelationsEN.IdCurrEduCls);

if (clszx_SocialRelationsBL.relatedActions != null)
{
clszx_SocialRelationsBL.relatedActions.UpdRelaTabDate(objzx_SocialRelationsEN.zxSocialId, "SetUpdDate");
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
 /// <param name = "objzx_SocialRelationsEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clszx_SocialRelationsEN objzx_SocialRelationsEN, string strWhereCond, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
bool bolResult = clszx_SocialRelationsBL.zx_SocialRelationsDA.UpdateBySqlWithConditionTransaction(objzx_SocialRelationsEN, strWhereCond, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clszx_SocialRelationsBL.ReFreshCache(objzx_SocialRelationsEN.IdCurrEduCls);

if (clszx_SocialRelationsBL.relatedActions != null)
{
clszx_SocialRelationsBL.relatedActions.UpdRelaTabDate(objzx_SocialRelationsEN.zxSocialId, "SetUpdDate");
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
 /// <param name = "strzxSocialId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int Delete(this clszx_SocialRelationsEN objzx_SocialRelationsEN)
{
try
{
int intRecNum = clszx_SocialRelationsBL.zx_SocialRelationsDA.DelRecord(objzx_SocialRelationsEN.zxSocialId);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clszx_SocialRelationsBL.ReFreshCache(objzx_SocialRelationsEN.IdCurrEduCls);

if (clszx_SocialRelationsBL.relatedActions != null)
{
clszx_SocialRelationsBL.relatedActions.UpdRelaTabDate(objzx_SocialRelationsEN.zxSocialId, "SetUpdDate");
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
 /// <param name = "objzx_SocialRelationsENS">源对象</param>
 /// <param name = "objzx_SocialRelationsENT">目标对象</param>
 public static void CopyTo(this clszx_SocialRelationsEN objzx_SocialRelationsENS, clszx_SocialRelationsEN objzx_SocialRelationsENT)
{
try
{
objzx_SocialRelationsENT.zxSocialId = objzx_SocialRelationsENS.zxSocialId; //社会Id
objzx_SocialRelationsENT.FullName = objzx_SocialRelationsENS.FullName; //姓名
objzx_SocialRelationsENT.Nationality = objzx_SocialRelationsENS.Nationality; //国籍
objzx_SocialRelationsENT.WorkUnit = objzx_SocialRelationsENS.WorkUnit; //工作单位
objzx_SocialRelationsENT.Major = objzx_SocialRelationsENS.Major; //专业
objzx_SocialRelationsENT.Achievement = objzx_SocialRelationsENS.Achievement; //成就
objzx_SocialRelationsENT.DetailedDescription = objzx_SocialRelationsENS.DetailedDescription; //详细说明
objzx_SocialRelationsENT.zxLevelId = objzx_SocialRelationsENS.zxLevelId; //级别Id
objzx_SocialRelationsENT.IsSubmit = objzx_SocialRelationsENS.IsSubmit; //是否提交
objzx_SocialRelationsENT.VoteCount = objzx_SocialRelationsENS.VoteCount; //点赞计数
objzx_SocialRelationsENT.CitationCount = objzx_SocialRelationsENS.CitationCount; //引用统计
objzx_SocialRelationsENT.VersionCount = objzx_SocialRelationsENS.VersionCount; //版本统计
objzx_SocialRelationsENT.IdCurrEduCls = objzx_SocialRelationsENS.IdCurrEduCls; //教学班流水号
objzx_SocialRelationsENT.AppraiseCount = objzx_SocialRelationsENS.AppraiseCount; //评论数
objzx_SocialRelationsENT.Score = objzx_SocialRelationsENS.Score; //评分
objzx_SocialRelationsENT.StuScore = objzx_SocialRelationsENS.StuScore; //学生平均分
objzx_SocialRelationsENT.TeaScore = objzx_SocialRelationsENS.TeaScore; //教师评分
objzx_SocialRelationsENT.TextId = objzx_SocialRelationsENS.TextId; //课件Id
objzx_SocialRelationsENT.zxShareId = objzx_SocialRelationsENS.zxShareId; //分享Id
objzx_SocialRelationsENT.PdfContent = objzx_SocialRelationsENS.PdfContent; //Pdf内容
objzx_SocialRelationsENT.PdfPageNum = objzx_SocialRelationsENS.PdfPageNum; //Pdf页码
objzx_SocialRelationsENT.UpdUser = objzx_SocialRelationsENS.UpdUser; //修改人
objzx_SocialRelationsENT.CreateDate = objzx_SocialRelationsENS.CreateDate; //建立日期
objzx_SocialRelationsENT.UpdDate = objzx_SocialRelationsENS.UpdDate; //修改日期
objzx_SocialRelationsENT.Memo = objzx_SocialRelationsENS.Memo; //备注
objzx_SocialRelationsENT.PdfDivLet = objzx_SocialRelationsENS.PdfDivLet; //PdfDivLet
objzx_SocialRelationsENT.PdfDivTop = objzx_SocialRelationsENS.PdfDivTop; //PdfDivTop
objzx_SocialRelationsENT.PdfPageNumIn = objzx_SocialRelationsENS.PdfPageNumIn; //PdfPageNumIn
objzx_SocialRelationsENT.PdfPageTop = objzx_SocialRelationsENS.PdfPageTop; //pdf页面顶部位置
objzx_SocialRelationsENT.PdfZoom = objzx_SocialRelationsENS.PdfZoom; //PdfZoom
objzx_SocialRelationsENT.GroupTextId = objzx_SocialRelationsENS.GroupTextId; //小组Id
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
 /// <param name = "objzx_SocialRelationsENS">源对象</param>
 /// <returns>目标对象=>clszx_SocialRelationsEN:objzx_SocialRelationsENT</returns>
 public static clszx_SocialRelationsEN CopyTo(this clszx_SocialRelationsEN objzx_SocialRelationsENS)
{
try
{
 clszx_SocialRelationsEN objzx_SocialRelationsENT = new clszx_SocialRelationsEN()
{
zxSocialId = objzx_SocialRelationsENS.zxSocialId, //社会Id
FullName = objzx_SocialRelationsENS.FullName, //姓名
Nationality = objzx_SocialRelationsENS.Nationality, //国籍
WorkUnit = objzx_SocialRelationsENS.WorkUnit, //工作单位
Major = objzx_SocialRelationsENS.Major, //专业
Achievement = objzx_SocialRelationsENS.Achievement, //成就
DetailedDescription = objzx_SocialRelationsENS.DetailedDescription, //详细说明
zxLevelId = objzx_SocialRelationsENS.zxLevelId, //级别Id
IsSubmit = objzx_SocialRelationsENS.IsSubmit, //是否提交
VoteCount = objzx_SocialRelationsENS.VoteCount, //点赞计数
CitationCount = objzx_SocialRelationsENS.CitationCount, //引用统计
VersionCount = objzx_SocialRelationsENS.VersionCount, //版本统计
IdCurrEduCls = objzx_SocialRelationsENS.IdCurrEduCls, //教学班流水号
AppraiseCount = objzx_SocialRelationsENS.AppraiseCount, //评论数
Score = objzx_SocialRelationsENS.Score, //评分
StuScore = objzx_SocialRelationsENS.StuScore, //学生平均分
TeaScore = objzx_SocialRelationsENS.TeaScore, //教师评分
TextId = objzx_SocialRelationsENS.TextId, //课件Id
zxShareId = objzx_SocialRelationsENS.zxShareId, //分享Id
PdfContent = objzx_SocialRelationsENS.PdfContent, //Pdf内容
PdfPageNum = objzx_SocialRelationsENS.PdfPageNum, //Pdf页码
UpdUser = objzx_SocialRelationsENS.UpdUser, //修改人
CreateDate = objzx_SocialRelationsENS.CreateDate, //建立日期
UpdDate = objzx_SocialRelationsENS.UpdDate, //修改日期
Memo = objzx_SocialRelationsENS.Memo, //备注
PdfDivLet = objzx_SocialRelationsENS.PdfDivLet, //PdfDivLet
PdfDivTop = objzx_SocialRelationsENS.PdfDivTop, //PdfDivTop
PdfPageNumIn = objzx_SocialRelationsENS.PdfPageNumIn, //PdfPageNumIn
PdfPageTop = objzx_SocialRelationsENS.PdfPageTop, //pdf页面顶部位置
PdfZoom = objzx_SocialRelationsENS.PdfZoom, //PdfZoom
GroupTextId = objzx_SocialRelationsENS.GroupTextId, //小组Id
};
 return objzx_SocialRelationsENT;
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
public static void CheckPropertyNew(this clszx_SocialRelationsEN objzx_SocialRelationsEN)
{
 clszx_SocialRelationsBL.zx_SocialRelationsDA.CheckPropertyNew(objzx_SocialRelationsEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(this clszx_SocialRelationsEN objzx_SocialRelationsEN)
{
 clszx_SocialRelationsBL.zx_SocialRelationsDA.CheckProperty4Condition(objzx_SocialRelationsEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clszx_SocialRelationsEN objzx_SocialRelationsCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objzx_SocialRelationsCond.IsUpdated(conzx_SocialRelations.zxSocialId) == true)
{
string strComparisonOpzxSocialId = objzx_SocialRelationsCond.dicFldComparisonOp[conzx_SocialRelations.zxSocialId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conzx_SocialRelations.zxSocialId, objzx_SocialRelationsCond.zxSocialId, strComparisonOpzxSocialId);
}
if (objzx_SocialRelationsCond.IsUpdated(conzx_SocialRelations.FullName) == true)
{
string strComparisonOpFullName = objzx_SocialRelationsCond.dicFldComparisonOp[conzx_SocialRelations.FullName];
strWhereCond += string.Format(" And {0} {2} '{1}'", conzx_SocialRelations.FullName, objzx_SocialRelationsCond.FullName, strComparisonOpFullName);
}
if (objzx_SocialRelationsCond.IsUpdated(conzx_SocialRelations.Nationality) == true)
{
string strComparisonOpNationality = objzx_SocialRelationsCond.dicFldComparisonOp[conzx_SocialRelations.Nationality];
strWhereCond += string.Format(" And {0} {2} '{1}'", conzx_SocialRelations.Nationality, objzx_SocialRelationsCond.Nationality, strComparisonOpNationality);
}
if (objzx_SocialRelationsCond.IsUpdated(conzx_SocialRelations.WorkUnit) == true)
{
string strComparisonOpWorkUnit = objzx_SocialRelationsCond.dicFldComparisonOp[conzx_SocialRelations.WorkUnit];
strWhereCond += string.Format(" And {0} {2} '{1}'", conzx_SocialRelations.WorkUnit, objzx_SocialRelationsCond.WorkUnit, strComparisonOpWorkUnit);
}
if (objzx_SocialRelationsCond.IsUpdated(conzx_SocialRelations.Major) == true)
{
string strComparisonOpMajor = objzx_SocialRelationsCond.dicFldComparisonOp[conzx_SocialRelations.Major];
strWhereCond += string.Format(" And {0} {2} '{1}'", conzx_SocialRelations.Major, objzx_SocialRelationsCond.Major, strComparisonOpMajor);
}
if (objzx_SocialRelationsCond.IsUpdated(conzx_SocialRelations.Achievement) == true)
{
string strComparisonOpAchievement = objzx_SocialRelationsCond.dicFldComparisonOp[conzx_SocialRelations.Achievement];
strWhereCond += string.Format(" And {0} {2} '{1}'", conzx_SocialRelations.Achievement, objzx_SocialRelationsCond.Achievement, strComparisonOpAchievement);
}
//数据类型string(text)在函数:[AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj]中没有处理!
if (objzx_SocialRelationsCond.IsUpdated(conzx_SocialRelations.zxLevelId) == true)
{
string strComparisonOpzxLevelId = objzx_SocialRelationsCond.dicFldComparisonOp[conzx_SocialRelations.zxLevelId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conzx_SocialRelations.zxLevelId, objzx_SocialRelationsCond.zxLevelId, strComparisonOpzxLevelId);
}
if (objzx_SocialRelationsCond.IsUpdated(conzx_SocialRelations.IsSubmit) == true)
{
if (objzx_SocialRelationsCond.IsSubmit == true)
{
strWhereCond += string.Format(" And {0} = '1'", conzx_SocialRelations.IsSubmit);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conzx_SocialRelations.IsSubmit);
}
}
if (objzx_SocialRelationsCond.IsUpdated(conzx_SocialRelations.VoteCount) == true)
{
string strComparisonOpVoteCount = objzx_SocialRelationsCond.dicFldComparisonOp[conzx_SocialRelations.VoteCount];
strWhereCond += string.Format(" And {0} {2} {1}", conzx_SocialRelations.VoteCount, objzx_SocialRelationsCond.VoteCount, strComparisonOpVoteCount);
}
if (objzx_SocialRelationsCond.IsUpdated(conzx_SocialRelations.CitationCount) == true)
{
string strComparisonOpCitationCount = objzx_SocialRelationsCond.dicFldComparisonOp[conzx_SocialRelations.CitationCount];
strWhereCond += string.Format(" And {0} {2} {1}", conzx_SocialRelations.CitationCount, objzx_SocialRelationsCond.CitationCount, strComparisonOpCitationCount);
}
if (objzx_SocialRelationsCond.IsUpdated(conzx_SocialRelations.VersionCount) == true)
{
string strComparisonOpVersionCount = objzx_SocialRelationsCond.dicFldComparisonOp[conzx_SocialRelations.VersionCount];
strWhereCond += string.Format(" And {0} {2} {1}", conzx_SocialRelations.VersionCount, objzx_SocialRelationsCond.VersionCount, strComparisonOpVersionCount);
}
if (objzx_SocialRelationsCond.IsUpdated(conzx_SocialRelations.IdCurrEduCls) == true)
{
string strComparisonOpIdCurrEduCls = objzx_SocialRelationsCond.dicFldComparisonOp[conzx_SocialRelations.IdCurrEduCls];
strWhereCond += string.Format(" And {0} {2} '{1}'", conzx_SocialRelations.IdCurrEduCls, objzx_SocialRelationsCond.IdCurrEduCls, strComparisonOpIdCurrEduCls);
}
if (objzx_SocialRelationsCond.IsUpdated(conzx_SocialRelations.AppraiseCount) == true)
{
string strComparisonOpAppraiseCount = objzx_SocialRelationsCond.dicFldComparisonOp[conzx_SocialRelations.AppraiseCount];
strWhereCond += string.Format(" And {0} {2} {1}", conzx_SocialRelations.AppraiseCount, objzx_SocialRelationsCond.AppraiseCount, strComparisonOpAppraiseCount);
}
if (objzx_SocialRelationsCond.IsUpdated(conzx_SocialRelations.Score) == true)
{
string strComparisonOpScore = objzx_SocialRelationsCond.dicFldComparisonOp[conzx_SocialRelations.Score];
strWhereCond += string.Format(" And {0} {2} {1}", conzx_SocialRelations.Score, objzx_SocialRelationsCond.Score, strComparisonOpScore);
}
if (objzx_SocialRelationsCond.IsUpdated(conzx_SocialRelations.StuScore) == true)
{
string strComparisonOpStuScore = objzx_SocialRelationsCond.dicFldComparisonOp[conzx_SocialRelations.StuScore];
strWhereCond += string.Format(" And {0} {2} {1}", conzx_SocialRelations.StuScore, objzx_SocialRelationsCond.StuScore, strComparisonOpStuScore);
}
if (objzx_SocialRelationsCond.IsUpdated(conzx_SocialRelations.TeaScore) == true)
{
string strComparisonOpTeaScore = objzx_SocialRelationsCond.dicFldComparisonOp[conzx_SocialRelations.TeaScore];
strWhereCond += string.Format(" And {0} {2} {1}", conzx_SocialRelations.TeaScore, objzx_SocialRelationsCond.TeaScore, strComparisonOpTeaScore);
}
if (objzx_SocialRelationsCond.IsUpdated(conzx_SocialRelations.TextId) == true)
{
string strComparisonOpTextId = objzx_SocialRelationsCond.dicFldComparisonOp[conzx_SocialRelations.TextId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conzx_SocialRelations.TextId, objzx_SocialRelationsCond.TextId, strComparisonOpTextId);
}
if (objzx_SocialRelationsCond.IsUpdated(conzx_SocialRelations.zxShareId) == true)
{
string strComparisonOpzxShareId = objzx_SocialRelationsCond.dicFldComparisonOp[conzx_SocialRelations.zxShareId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conzx_SocialRelations.zxShareId, objzx_SocialRelationsCond.zxShareId, strComparisonOpzxShareId);
}
if (objzx_SocialRelationsCond.IsUpdated(conzx_SocialRelations.PdfContent) == true)
{
string strComparisonOpPdfContent = objzx_SocialRelationsCond.dicFldComparisonOp[conzx_SocialRelations.PdfContent];
strWhereCond += string.Format(" And {0} {2} '{1}'", conzx_SocialRelations.PdfContent, objzx_SocialRelationsCond.PdfContent, strComparisonOpPdfContent);
}
if (objzx_SocialRelationsCond.IsUpdated(conzx_SocialRelations.PdfPageNum) == true)
{
string strComparisonOpPdfPageNum = objzx_SocialRelationsCond.dicFldComparisonOp[conzx_SocialRelations.PdfPageNum];
strWhereCond += string.Format(" And {0} {2} {1}", conzx_SocialRelations.PdfPageNum, objzx_SocialRelationsCond.PdfPageNum, strComparisonOpPdfPageNum);
}
if (objzx_SocialRelationsCond.IsUpdated(conzx_SocialRelations.UpdUser) == true)
{
string strComparisonOpUpdUser = objzx_SocialRelationsCond.dicFldComparisonOp[conzx_SocialRelations.UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", conzx_SocialRelations.UpdUser, objzx_SocialRelationsCond.UpdUser, strComparisonOpUpdUser);
}
if (objzx_SocialRelationsCond.IsUpdated(conzx_SocialRelations.CreateDate) == true)
{
string strComparisonOpCreateDate = objzx_SocialRelationsCond.dicFldComparisonOp[conzx_SocialRelations.CreateDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conzx_SocialRelations.CreateDate, objzx_SocialRelationsCond.CreateDate, strComparisonOpCreateDate);
}
if (objzx_SocialRelationsCond.IsUpdated(conzx_SocialRelations.UpdDate) == true)
{
string strComparisonOpUpdDate = objzx_SocialRelationsCond.dicFldComparisonOp[conzx_SocialRelations.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conzx_SocialRelations.UpdDate, objzx_SocialRelationsCond.UpdDate, strComparisonOpUpdDate);
}
if (objzx_SocialRelationsCond.IsUpdated(conzx_SocialRelations.Memo) == true)
{
string strComparisonOpMemo = objzx_SocialRelationsCond.dicFldComparisonOp[conzx_SocialRelations.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", conzx_SocialRelations.Memo, objzx_SocialRelationsCond.Memo, strComparisonOpMemo);
}
if (objzx_SocialRelationsCond.IsUpdated(conzx_SocialRelations.PdfDivLet) == true)
{
string strComparisonOpPdfDivLet = objzx_SocialRelationsCond.dicFldComparisonOp[conzx_SocialRelations.PdfDivLet];
strWhereCond += string.Format(" And {0} {2} '{1}'", conzx_SocialRelations.PdfDivLet, objzx_SocialRelationsCond.PdfDivLet, strComparisonOpPdfDivLet);
}
if (objzx_SocialRelationsCond.IsUpdated(conzx_SocialRelations.PdfDivTop) == true)
{
string strComparisonOpPdfDivTop = objzx_SocialRelationsCond.dicFldComparisonOp[conzx_SocialRelations.PdfDivTop];
strWhereCond += string.Format(" And {0} {2} '{1}'", conzx_SocialRelations.PdfDivTop, objzx_SocialRelationsCond.PdfDivTop, strComparisonOpPdfDivTop);
}
if (objzx_SocialRelationsCond.IsUpdated(conzx_SocialRelations.PdfPageNumIn) == true)
{
string strComparisonOpPdfPageNumIn = objzx_SocialRelationsCond.dicFldComparisonOp[conzx_SocialRelations.PdfPageNumIn];
strWhereCond += string.Format(" And {0} {2} '{1}'", conzx_SocialRelations.PdfPageNumIn, objzx_SocialRelationsCond.PdfPageNumIn, strComparisonOpPdfPageNumIn);
}
if (objzx_SocialRelationsCond.IsUpdated(conzx_SocialRelations.PdfPageTop) == true)
{
string strComparisonOpPdfPageTop = objzx_SocialRelationsCond.dicFldComparisonOp[conzx_SocialRelations.PdfPageTop];
strWhereCond += string.Format(" And {0} {2} {1}", conzx_SocialRelations.PdfPageTop, objzx_SocialRelationsCond.PdfPageTop, strComparisonOpPdfPageTop);
}
if (objzx_SocialRelationsCond.IsUpdated(conzx_SocialRelations.PdfZoom) == true)
{
string strComparisonOpPdfZoom = objzx_SocialRelationsCond.dicFldComparisonOp[conzx_SocialRelations.PdfZoom];
strWhereCond += string.Format(" And {0} {2} '{1}'", conzx_SocialRelations.PdfZoom, objzx_SocialRelationsCond.PdfZoom, strComparisonOpPdfZoom);
}
if (objzx_SocialRelationsCond.IsUpdated(conzx_SocialRelations.GroupTextId) == true)
{
string strComparisonOpGroupTextId = objzx_SocialRelationsCond.dicFldComparisonOp[conzx_SocialRelations.GroupTextId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conzx_SocialRelations.GroupTextId, objzx_SocialRelationsCond.GroupTextId, strComparisonOpGroupTextId);
}
 return strWhereCond;
}

 /// <summary>
 /// 检查唯一性(Uniqueness)--zx_SocialRelations(中学社会关系), 如果不唯一,即存在相同的记录,就返回False
 /// 唯一性条件:TextId
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckConstraint)
 /// </summary>
 /// <param name = "objzx_SocialRelationsEN">要求唯一的对象</param>
 /// <returns></returns>
public static bool CheckUniqueness(this clszx_SocialRelationsEN objzx_SocialRelationsEN)
{
//检测记录是否存在
bool bolIsUniqueness;
StringBuilder sbCondition = new StringBuilder();
if (objzx_SocialRelationsEN == null) return true;
if (objzx_SocialRelationsEN.zxSocialId == null || objzx_SocialRelationsEN.zxSocialId == "")
{
sbCondition.AppendFormat("1 = 1");
 if (objzx_SocialRelationsEN.TextId == null)
{
 sbCondition.AppendFormat(" and TextId is null", objzx_SocialRelationsEN.TextId);
}
else
{
 sbCondition.AppendFormat(" and TextId = '{0}'", objzx_SocialRelationsEN.TextId);
}
if (clszx_SocialRelationsBL.IsExistRecord(sbCondition.ToString())  ==  true)
{
 bolIsUniqueness = false;
}
else
{
 bolIsUniqueness = true;
}
}
 else {
sbCondition.AppendFormat("zxSocialId !=  '{0}'", objzx_SocialRelationsEN.zxSocialId);
 sbCondition.AppendFormat(" and TextId = '{0}'", objzx_SocialRelationsEN.TextId);
if (clszx_SocialRelationsBL.IsExistRecord(sbCondition.ToString())  ==  true)
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
 /// 获取唯一性条件串--zx_SocialRelations(中学社会关系), 即由对象中唯一性条件字段关键字与值组成的条件串
 /// 唯一性条件:TextId
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetConditionString4Constraint)
 /// </summary>
 /// <param name = "objzx_SocialRelationsEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(this clszx_SocialRelationsEN objzx_SocialRelationsEN)
{
//检测记录是否存在
StringBuilder sbCondition = new StringBuilder();
if (objzx_SocialRelationsEN == null) return "";
if (objzx_SocialRelationsEN.zxSocialId == null || objzx_SocialRelationsEN.zxSocialId == "")
{
sbCondition.AppendFormat("1 = 1");
 if (objzx_SocialRelationsEN.TextId == null)
{
 sbCondition.AppendFormat(" and TextId is null", objzx_SocialRelationsEN.TextId);
}
else
{
 sbCondition.AppendFormat(" and TextId = '{0}'", objzx_SocialRelationsEN.TextId);
}
return sbCondition.ToString();
}
 else {
sbCondition.AppendFormat("zxSocialId !=  '{0}'", objzx_SocialRelationsEN.zxSocialId);
 sbCondition.AppendFormat(" and TextId = '{0}'", objzx_SocialRelationsEN.TextId);
 return sbCondition.ToString();
}
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_zx_SocialRelations
{
public virtual bool UpdRelaTabDate(string strzxSocialId, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// 中学社会关系(zx_SocialRelations)
 /// 数据源类型:表
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clszx_SocialRelationsBL
{
public static RelatedActions_zx_SocialRelations relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clszx_SocialRelationsDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clszx_SocialRelationsDA zx_SocialRelationsDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clszx_SocialRelationsDA();
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
 public clszx_SocialRelationsBL()
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
if (string.IsNullOrEmpty(clszx_SocialRelationsEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clszx_SocialRelationsEN._ConnectString);
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
public static DataTable GetDataTable_zx_SocialRelations(string strWhereCond)
{
DataTable objDT;
try
{
objDT = zx_SocialRelationsDA.GetDataTable_zx_SocialRelations(strWhereCond);
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
objDT = zx_SocialRelationsDA.GetDataTable(strWhereCond);
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
objDT = zx_SocialRelationsDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = zx_SocialRelationsDA.GetDataTable(strWhereCond, strTabName);
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
objDT = zx_SocialRelationsDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = zx_SocialRelationsDA.GetDataTable_Top(objTopPara);
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
objDT = zx_SocialRelationsDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = zx_SocialRelationsDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = zx_SocialRelationsDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
 /// <param name = "arrZxSocialIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static List<clszx_SocialRelationsEN> GetObjLstByZxSocialIdLst(List<string> arrZxSocialIdLst)
{
List<clszx_SocialRelationsEN> arrObjLst = new List<clszx_SocialRelationsEN>(); 
System.Data.DataTable objDT; 
 string strSqlConditionStr = clsArray.GetSqlInStrByArray(arrZxSocialIdLst, true);
 string strWhereCond = string.Format("zxSocialId in ({0})", strSqlConditionStr);
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clszx_SocialRelationsEN objzx_SocialRelationsEN = new clszx_SocialRelationsEN();
try
{
objzx_SocialRelationsEN.zxSocialId = objRow[conzx_SocialRelations.zxSocialId].ToString().Trim(); //社会Id
objzx_SocialRelationsEN.FullName = objRow[conzx_SocialRelations.FullName] == DBNull.Value ? null : objRow[conzx_SocialRelations.FullName].ToString().Trim(); //姓名
objzx_SocialRelationsEN.Nationality = objRow[conzx_SocialRelations.Nationality] == DBNull.Value ? null : objRow[conzx_SocialRelations.Nationality].ToString().Trim(); //国籍
objzx_SocialRelationsEN.WorkUnit = objRow[conzx_SocialRelations.WorkUnit] == DBNull.Value ? null : objRow[conzx_SocialRelations.WorkUnit].ToString().Trim(); //工作单位
objzx_SocialRelationsEN.Major = objRow[conzx_SocialRelations.Major] == DBNull.Value ? null : objRow[conzx_SocialRelations.Major].ToString().Trim(); //专业
objzx_SocialRelationsEN.Achievement = objRow[conzx_SocialRelations.Achievement] == DBNull.Value ? null : objRow[conzx_SocialRelations.Achievement].ToString().Trim(); //成就
objzx_SocialRelationsEN.DetailedDescription = objRow[conzx_SocialRelations.DetailedDescription] == DBNull.Value ? null : objRow[conzx_SocialRelations.DetailedDescription].ToString().Trim(); //详细说明
objzx_SocialRelationsEN.zxLevelId = objRow[conzx_SocialRelations.zxLevelId] == DBNull.Value ? null : objRow[conzx_SocialRelations.zxLevelId].ToString().Trim(); //级别Id
objzx_SocialRelationsEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[conzx_SocialRelations.IsSubmit].ToString().Trim()); //是否提交
objzx_SocialRelationsEN.VoteCount = objRow[conzx_SocialRelations.VoteCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_SocialRelations.VoteCount].ToString().Trim()); //点赞计数
objzx_SocialRelationsEN.CitationCount = objRow[conzx_SocialRelations.CitationCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_SocialRelations.CitationCount].ToString().Trim()); //引用统计
objzx_SocialRelationsEN.VersionCount = objRow[conzx_SocialRelations.VersionCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_SocialRelations.VersionCount].ToString().Trim()); //版本统计
objzx_SocialRelationsEN.IdCurrEduCls = objRow[conzx_SocialRelations.IdCurrEduCls] == DBNull.Value ? null : objRow[conzx_SocialRelations.IdCurrEduCls].ToString().Trim(); //教学班流水号
objzx_SocialRelationsEN.AppraiseCount = objRow[conzx_SocialRelations.AppraiseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_SocialRelations.AppraiseCount].ToString().Trim()); //评论数
objzx_SocialRelationsEN.Score = objRow[conzx_SocialRelations.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conzx_SocialRelations.Score].ToString().Trim()); //评分
objzx_SocialRelationsEN.StuScore = objRow[conzx_SocialRelations.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conzx_SocialRelations.StuScore].ToString().Trim()); //学生平均分
objzx_SocialRelationsEN.TeaScore = objRow[conzx_SocialRelations.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conzx_SocialRelations.TeaScore].ToString().Trim()); //教师评分
objzx_SocialRelationsEN.TextId = objRow[conzx_SocialRelations.TextId] == DBNull.Value ? null : objRow[conzx_SocialRelations.TextId].ToString().Trim(); //课件Id
objzx_SocialRelationsEN.zxShareId = objRow[conzx_SocialRelations.zxShareId] == DBNull.Value ? null : objRow[conzx_SocialRelations.zxShareId].ToString().Trim(); //分享Id
objzx_SocialRelationsEN.PdfContent = objRow[conzx_SocialRelations.PdfContent] == DBNull.Value ? null : objRow[conzx_SocialRelations.PdfContent].ToString().Trim(); //Pdf内容
objzx_SocialRelationsEN.PdfPageNum = objRow[conzx_SocialRelations.PdfPageNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_SocialRelations.PdfPageNum].ToString().Trim()); //Pdf页码
objzx_SocialRelationsEN.UpdUser = objRow[conzx_SocialRelations.UpdUser] == DBNull.Value ? null : objRow[conzx_SocialRelations.UpdUser].ToString().Trim(); //修改人
objzx_SocialRelationsEN.CreateDate = objRow[conzx_SocialRelations.CreateDate] == DBNull.Value ? null : objRow[conzx_SocialRelations.CreateDate].ToString().Trim(); //建立日期
objzx_SocialRelationsEN.UpdDate = objRow[conzx_SocialRelations.UpdDate] == DBNull.Value ? null : objRow[conzx_SocialRelations.UpdDate].ToString().Trim(); //修改日期
objzx_SocialRelationsEN.Memo = objRow[conzx_SocialRelations.Memo] == DBNull.Value ? null : objRow[conzx_SocialRelations.Memo].ToString().Trim(); //备注
objzx_SocialRelationsEN.PdfDivLet = objRow[conzx_SocialRelations.PdfDivLet] == DBNull.Value ? null : objRow[conzx_SocialRelations.PdfDivLet].ToString().Trim(); //PdfDivLet
objzx_SocialRelationsEN.PdfDivTop = objRow[conzx_SocialRelations.PdfDivTop] == DBNull.Value ? null : objRow[conzx_SocialRelations.PdfDivTop].ToString().Trim(); //PdfDivTop
objzx_SocialRelationsEN.PdfPageNumIn = objRow[conzx_SocialRelations.PdfPageNumIn] == DBNull.Value ? null : objRow[conzx_SocialRelations.PdfPageNumIn].ToString().Trim(); //PdfPageNumIn
objzx_SocialRelationsEN.PdfPageTop = objRow[conzx_SocialRelations.PdfPageTop] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_SocialRelations.PdfPageTop].ToString().Trim()); //pdf页面顶部位置
objzx_SocialRelationsEN.PdfZoom = objRow[conzx_SocialRelations.PdfZoom] == DBNull.Value ? null : objRow[conzx_SocialRelations.PdfZoom].ToString().Trim(); //PdfZoom
objzx_SocialRelationsEN.GroupTextId = objRow[conzx_SocialRelations.GroupTextId] == DBNull.Value ? null : objRow[conzx_SocialRelations.GroupTextId].ToString().Trim(); //小组Id
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objzx_SocialRelationsEN.zxSocialId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objzx_SocialRelationsEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrZxSocialIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clszx_SocialRelationsEN> GetObjLstByZxSocialIdLstCache(List<string> arrZxSocialIdLst, string strIdCurrEduCls)
{
string strKey = string.Format("{0}_{1}", clszx_SocialRelationsEN._CurrTabName, strIdCurrEduCls);
List<clszx_SocialRelationsEN> arrzx_SocialRelationsObjLstCache = GetObjLstCache(strIdCurrEduCls);
IEnumerable <clszx_SocialRelationsEN> arrzx_SocialRelationsObjLst_Sel =
arrzx_SocialRelationsObjLstCache
.Where(x => arrZxSocialIdLst.Contains(x.zxSocialId));
return arrzx_SocialRelationsObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clszx_SocialRelationsEN> GetObjLst(string strWhereCond)
{
List<clszx_SocialRelationsEN> arrObjLst = new List<clszx_SocialRelationsEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clszx_SocialRelationsEN objzx_SocialRelationsEN = new clszx_SocialRelationsEN();
try
{
objzx_SocialRelationsEN.zxSocialId = objRow[conzx_SocialRelations.zxSocialId].ToString().Trim(); //社会Id
objzx_SocialRelationsEN.FullName = objRow[conzx_SocialRelations.FullName] == DBNull.Value ? null : objRow[conzx_SocialRelations.FullName].ToString().Trim(); //姓名
objzx_SocialRelationsEN.Nationality = objRow[conzx_SocialRelations.Nationality] == DBNull.Value ? null : objRow[conzx_SocialRelations.Nationality].ToString().Trim(); //国籍
objzx_SocialRelationsEN.WorkUnit = objRow[conzx_SocialRelations.WorkUnit] == DBNull.Value ? null : objRow[conzx_SocialRelations.WorkUnit].ToString().Trim(); //工作单位
objzx_SocialRelationsEN.Major = objRow[conzx_SocialRelations.Major] == DBNull.Value ? null : objRow[conzx_SocialRelations.Major].ToString().Trim(); //专业
objzx_SocialRelationsEN.Achievement = objRow[conzx_SocialRelations.Achievement] == DBNull.Value ? null : objRow[conzx_SocialRelations.Achievement].ToString().Trim(); //成就
objzx_SocialRelationsEN.DetailedDescription = objRow[conzx_SocialRelations.DetailedDescription] == DBNull.Value ? null : objRow[conzx_SocialRelations.DetailedDescription].ToString().Trim(); //详细说明
objzx_SocialRelationsEN.zxLevelId = objRow[conzx_SocialRelations.zxLevelId] == DBNull.Value ? null : objRow[conzx_SocialRelations.zxLevelId].ToString().Trim(); //级别Id
objzx_SocialRelationsEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[conzx_SocialRelations.IsSubmit].ToString().Trim()); //是否提交
objzx_SocialRelationsEN.VoteCount = objRow[conzx_SocialRelations.VoteCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_SocialRelations.VoteCount].ToString().Trim()); //点赞计数
objzx_SocialRelationsEN.CitationCount = objRow[conzx_SocialRelations.CitationCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_SocialRelations.CitationCount].ToString().Trim()); //引用统计
objzx_SocialRelationsEN.VersionCount = objRow[conzx_SocialRelations.VersionCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_SocialRelations.VersionCount].ToString().Trim()); //版本统计
objzx_SocialRelationsEN.IdCurrEduCls = objRow[conzx_SocialRelations.IdCurrEduCls] == DBNull.Value ? null : objRow[conzx_SocialRelations.IdCurrEduCls].ToString().Trim(); //教学班流水号
objzx_SocialRelationsEN.AppraiseCount = objRow[conzx_SocialRelations.AppraiseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_SocialRelations.AppraiseCount].ToString().Trim()); //评论数
objzx_SocialRelationsEN.Score = objRow[conzx_SocialRelations.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conzx_SocialRelations.Score].ToString().Trim()); //评分
objzx_SocialRelationsEN.StuScore = objRow[conzx_SocialRelations.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conzx_SocialRelations.StuScore].ToString().Trim()); //学生平均分
objzx_SocialRelationsEN.TeaScore = objRow[conzx_SocialRelations.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conzx_SocialRelations.TeaScore].ToString().Trim()); //教师评分
objzx_SocialRelationsEN.TextId = objRow[conzx_SocialRelations.TextId] == DBNull.Value ? null : objRow[conzx_SocialRelations.TextId].ToString().Trim(); //课件Id
objzx_SocialRelationsEN.zxShareId = objRow[conzx_SocialRelations.zxShareId] == DBNull.Value ? null : objRow[conzx_SocialRelations.zxShareId].ToString().Trim(); //分享Id
objzx_SocialRelationsEN.PdfContent = objRow[conzx_SocialRelations.PdfContent] == DBNull.Value ? null : objRow[conzx_SocialRelations.PdfContent].ToString().Trim(); //Pdf内容
objzx_SocialRelationsEN.PdfPageNum = objRow[conzx_SocialRelations.PdfPageNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_SocialRelations.PdfPageNum].ToString().Trim()); //Pdf页码
objzx_SocialRelationsEN.UpdUser = objRow[conzx_SocialRelations.UpdUser] == DBNull.Value ? null : objRow[conzx_SocialRelations.UpdUser].ToString().Trim(); //修改人
objzx_SocialRelationsEN.CreateDate = objRow[conzx_SocialRelations.CreateDate] == DBNull.Value ? null : objRow[conzx_SocialRelations.CreateDate].ToString().Trim(); //建立日期
objzx_SocialRelationsEN.UpdDate = objRow[conzx_SocialRelations.UpdDate] == DBNull.Value ? null : objRow[conzx_SocialRelations.UpdDate].ToString().Trim(); //修改日期
objzx_SocialRelationsEN.Memo = objRow[conzx_SocialRelations.Memo] == DBNull.Value ? null : objRow[conzx_SocialRelations.Memo].ToString().Trim(); //备注
objzx_SocialRelationsEN.PdfDivLet = objRow[conzx_SocialRelations.PdfDivLet] == DBNull.Value ? null : objRow[conzx_SocialRelations.PdfDivLet].ToString().Trim(); //PdfDivLet
objzx_SocialRelationsEN.PdfDivTop = objRow[conzx_SocialRelations.PdfDivTop] == DBNull.Value ? null : objRow[conzx_SocialRelations.PdfDivTop].ToString().Trim(); //PdfDivTop
objzx_SocialRelationsEN.PdfPageNumIn = objRow[conzx_SocialRelations.PdfPageNumIn] == DBNull.Value ? null : objRow[conzx_SocialRelations.PdfPageNumIn].ToString().Trim(); //PdfPageNumIn
objzx_SocialRelationsEN.PdfPageTop = objRow[conzx_SocialRelations.PdfPageTop] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_SocialRelations.PdfPageTop].ToString().Trim()); //pdf页面顶部位置
objzx_SocialRelationsEN.PdfZoom = objRow[conzx_SocialRelations.PdfZoom] == DBNull.Value ? null : objRow[conzx_SocialRelations.PdfZoom].ToString().Trim(); //PdfZoom
objzx_SocialRelationsEN.GroupTextId = objRow[conzx_SocialRelations.GroupTextId] == DBNull.Value ? null : objRow[conzx_SocialRelations.GroupTextId].ToString().Trim(); //小组Id
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objzx_SocialRelationsEN.zxSocialId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objzx_SocialRelationsEN);
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
public static List<clszx_SocialRelationsEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clszx_SocialRelationsEN> arrObjLst = new List<clszx_SocialRelationsEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clszx_SocialRelationsEN objzx_SocialRelationsEN = new clszx_SocialRelationsEN();
try
{
objzx_SocialRelationsEN.zxSocialId = objRow[conzx_SocialRelations.zxSocialId].ToString().Trim(); //社会Id
objzx_SocialRelationsEN.FullName = objRow[conzx_SocialRelations.FullName] == DBNull.Value ? null : objRow[conzx_SocialRelations.FullName].ToString().Trim(); //姓名
objzx_SocialRelationsEN.Nationality = objRow[conzx_SocialRelations.Nationality] == DBNull.Value ? null : objRow[conzx_SocialRelations.Nationality].ToString().Trim(); //国籍
objzx_SocialRelationsEN.WorkUnit = objRow[conzx_SocialRelations.WorkUnit] == DBNull.Value ? null : objRow[conzx_SocialRelations.WorkUnit].ToString().Trim(); //工作单位
objzx_SocialRelationsEN.Major = objRow[conzx_SocialRelations.Major] == DBNull.Value ? null : objRow[conzx_SocialRelations.Major].ToString().Trim(); //专业
objzx_SocialRelationsEN.Achievement = objRow[conzx_SocialRelations.Achievement] == DBNull.Value ? null : objRow[conzx_SocialRelations.Achievement].ToString().Trim(); //成就
objzx_SocialRelationsEN.DetailedDescription = objRow[conzx_SocialRelations.DetailedDescription] == DBNull.Value ? null : objRow[conzx_SocialRelations.DetailedDescription].ToString().Trim(); //详细说明
objzx_SocialRelationsEN.zxLevelId = objRow[conzx_SocialRelations.zxLevelId] == DBNull.Value ? null : objRow[conzx_SocialRelations.zxLevelId].ToString().Trim(); //级别Id
objzx_SocialRelationsEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[conzx_SocialRelations.IsSubmit].ToString().Trim()); //是否提交
objzx_SocialRelationsEN.VoteCount = objRow[conzx_SocialRelations.VoteCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_SocialRelations.VoteCount].ToString().Trim()); //点赞计数
objzx_SocialRelationsEN.CitationCount = objRow[conzx_SocialRelations.CitationCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_SocialRelations.CitationCount].ToString().Trim()); //引用统计
objzx_SocialRelationsEN.VersionCount = objRow[conzx_SocialRelations.VersionCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_SocialRelations.VersionCount].ToString().Trim()); //版本统计
objzx_SocialRelationsEN.IdCurrEduCls = objRow[conzx_SocialRelations.IdCurrEduCls] == DBNull.Value ? null : objRow[conzx_SocialRelations.IdCurrEduCls].ToString().Trim(); //教学班流水号
objzx_SocialRelationsEN.AppraiseCount = objRow[conzx_SocialRelations.AppraiseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_SocialRelations.AppraiseCount].ToString().Trim()); //评论数
objzx_SocialRelationsEN.Score = objRow[conzx_SocialRelations.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conzx_SocialRelations.Score].ToString().Trim()); //评分
objzx_SocialRelationsEN.StuScore = objRow[conzx_SocialRelations.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conzx_SocialRelations.StuScore].ToString().Trim()); //学生平均分
objzx_SocialRelationsEN.TeaScore = objRow[conzx_SocialRelations.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conzx_SocialRelations.TeaScore].ToString().Trim()); //教师评分
objzx_SocialRelationsEN.TextId = objRow[conzx_SocialRelations.TextId] == DBNull.Value ? null : objRow[conzx_SocialRelations.TextId].ToString().Trim(); //课件Id
objzx_SocialRelationsEN.zxShareId = objRow[conzx_SocialRelations.zxShareId] == DBNull.Value ? null : objRow[conzx_SocialRelations.zxShareId].ToString().Trim(); //分享Id
objzx_SocialRelationsEN.PdfContent = objRow[conzx_SocialRelations.PdfContent] == DBNull.Value ? null : objRow[conzx_SocialRelations.PdfContent].ToString().Trim(); //Pdf内容
objzx_SocialRelationsEN.PdfPageNum = objRow[conzx_SocialRelations.PdfPageNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_SocialRelations.PdfPageNum].ToString().Trim()); //Pdf页码
objzx_SocialRelationsEN.UpdUser = objRow[conzx_SocialRelations.UpdUser] == DBNull.Value ? null : objRow[conzx_SocialRelations.UpdUser].ToString().Trim(); //修改人
objzx_SocialRelationsEN.CreateDate = objRow[conzx_SocialRelations.CreateDate] == DBNull.Value ? null : objRow[conzx_SocialRelations.CreateDate].ToString().Trim(); //建立日期
objzx_SocialRelationsEN.UpdDate = objRow[conzx_SocialRelations.UpdDate] == DBNull.Value ? null : objRow[conzx_SocialRelations.UpdDate].ToString().Trim(); //修改日期
objzx_SocialRelationsEN.Memo = objRow[conzx_SocialRelations.Memo] == DBNull.Value ? null : objRow[conzx_SocialRelations.Memo].ToString().Trim(); //备注
objzx_SocialRelationsEN.PdfDivLet = objRow[conzx_SocialRelations.PdfDivLet] == DBNull.Value ? null : objRow[conzx_SocialRelations.PdfDivLet].ToString().Trim(); //PdfDivLet
objzx_SocialRelationsEN.PdfDivTop = objRow[conzx_SocialRelations.PdfDivTop] == DBNull.Value ? null : objRow[conzx_SocialRelations.PdfDivTop].ToString().Trim(); //PdfDivTop
objzx_SocialRelationsEN.PdfPageNumIn = objRow[conzx_SocialRelations.PdfPageNumIn] == DBNull.Value ? null : objRow[conzx_SocialRelations.PdfPageNumIn].ToString().Trim(); //PdfPageNumIn
objzx_SocialRelationsEN.PdfPageTop = objRow[conzx_SocialRelations.PdfPageTop] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_SocialRelations.PdfPageTop].ToString().Trim()); //pdf页面顶部位置
objzx_SocialRelationsEN.PdfZoom = objRow[conzx_SocialRelations.PdfZoom] == DBNull.Value ? null : objRow[conzx_SocialRelations.PdfZoom].ToString().Trim(); //PdfZoom
objzx_SocialRelationsEN.GroupTextId = objRow[conzx_SocialRelations.GroupTextId] == DBNull.Value ? null : objRow[conzx_SocialRelations.GroupTextId].ToString().Trim(); //小组Id
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objzx_SocialRelationsEN.zxSocialId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objzx_SocialRelationsEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objzx_SocialRelationsCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clszx_SocialRelationsEN> GetSubObjLstCache(clszx_SocialRelationsEN objzx_SocialRelationsCond)
{
 string strIdCurrEduCls = objzx_SocialRelationsCond.IdCurrEduCls;
 if (string.IsNullOrEmpty(strIdCurrEduCls) == true)
{
string strMsg = string.Format("(errid:Busi000172)在表中,缓存分类字段值不能为空!(clszx_SocialRelationsBL:GetSubObjLstCache)");
throw new Exception(strMsg);
}
List<clszx_SocialRelationsEN> arrObjLstCache = GetObjLstCache(strIdCurrEduCls);
IEnumerable <clszx_SocialRelationsEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conzx_SocialRelations.AttributeName)
{
if (objzx_SocialRelationsCond.IsUpdated(strFldName) == false) continue;
if (objzx_SocialRelationsCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objzx_SocialRelationsCond[strFldName].ToString());
}
else
{
if (objzx_SocialRelationsCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objzx_SocialRelationsCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objzx_SocialRelationsCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objzx_SocialRelationsCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objzx_SocialRelationsCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objzx_SocialRelationsCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objzx_SocialRelationsCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objzx_SocialRelationsCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objzx_SocialRelationsCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objzx_SocialRelationsCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objzx_SocialRelationsCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objzx_SocialRelationsCond[strFldName]));
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
public static List<clszx_SocialRelationsEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clszx_SocialRelationsEN> arrObjLst = new List<clszx_SocialRelationsEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clszx_SocialRelationsEN objzx_SocialRelationsEN = new clszx_SocialRelationsEN();
try
{
objzx_SocialRelationsEN.zxSocialId = objRow[conzx_SocialRelations.zxSocialId].ToString().Trim(); //社会Id
objzx_SocialRelationsEN.FullName = objRow[conzx_SocialRelations.FullName] == DBNull.Value ? null : objRow[conzx_SocialRelations.FullName].ToString().Trim(); //姓名
objzx_SocialRelationsEN.Nationality = objRow[conzx_SocialRelations.Nationality] == DBNull.Value ? null : objRow[conzx_SocialRelations.Nationality].ToString().Trim(); //国籍
objzx_SocialRelationsEN.WorkUnit = objRow[conzx_SocialRelations.WorkUnit] == DBNull.Value ? null : objRow[conzx_SocialRelations.WorkUnit].ToString().Trim(); //工作单位
objzx_SocialRelationsEN.Major = objRow[conzx_SocialRelations.Major] == DBNull.Value ? null : objRow[conzx_SocialRelations.Major].ToString().Trim(); //专业
objzx_SocialRelationsEN.Achievement = objRow[conzx_SocialRelations.Achievement] == DBNull.Value ? null : objRow[conzx_SocialRelations.Achievement].ToString().Trim(); //成就
objzx_SocialRelationsEN.DetailedDescription = objRow[conzx_SocialRelations.DetailedDescription] == DBNull.Value ? null : objRow[conzx_SocialRelations.DetailedDescription].ToString().Trim(); //详细说明
objzx_SocialRelationsEN.zxLevelId = objRow[conzx_SocialRelations.zxLevelId] == DBNull.Value ? null : objRow[conzx_SocialRelations.zxLevelId].ToString().Trim(); //级别Id
objzx_SocialRelationsEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[conzx_SocialRelations.IsSubmit].ToString().Trim()); //是否提交
objzx_SocialRelationsEN.VoteCount = objRow[conzx_SocialRelations.VoteCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_SocialRelations.VoteCount].ToString().Trim()); //点赞计数
objzx_SocialRelationsEN.CitationCount = objRow[conzx_SocialRelations.CitationCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_SocialRelations.CitationCount].ToString().Trim()); //引用统计
objzx_SocialRelationsEN.VersionCount = objRow[conzx_SocialRelations.VersionCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_SocialRelations.VersionCount].ToString().Trim()); //版本统计
objzx_SocialRelationsEN.IdCurrEduCls = objRow[conzx_SocialRelations.IdCurrEduCls] == DBNull.Value ? null : objRow[conzx_SocialRelations.IdCurrEduCls].ToString().Trim(); //教学班流水号
objzx_SocialRelationsEN.AppraiseCount = objRow[conzx_SocialRelations.AppraiseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_SocialRelations.AppraiseCount].ToString().Trim()); //评论数
objzx_SocialRelationsEN.Score = objRow[conzx_SocialRelations.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conzx_SocialRelations.Score].ToString().Trim()); //评分
objzx_SocialRelationsEN.StuScore = objRow[conzx_SocialRelations.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conzx_SocialRelations.StuScore].ToString().Trim()); //学生平均分
objzx_SocialRelationsEN.TeaScore = objRow[conzx_SocialRelations.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conzx_SocialRelations.TeaScore].ToString().Trim()); //教师评分
objzx_SocialRelationsEN.TextId = objRow[conzx_SocialRelations.TextId] == DBNull.Value ? null : objRow[conzx_SocialRelations.TextId].ToString().Trim(); //课件Id
objzx_SocialRelationsEN.zxShareId = objRow[conzx_SocialRelations.zxShareId] == DBNull.Value ? null : objRow[conzx_SocialRelations.zxShareId].ToString().Trim(); //分享Id
objzx_SocialRelationsEN.PdfContent = objRow[conzx_SocialRelations.PdfContent] == DBNull.Value ? null : objRow[conzx_SocialRelations.PdfContent].ToString().Trim(); //Pdf内容
objzx_SocialRelationsEN.PdfPageNum = objRow[conzx_SocialRelations.PdfPageNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_SocialRelations.PdfPageNum].ToString().Trim()); //Pdf页码
objzx_SocialRelationsEN.UpdUser = objRow[conzx_SocialRelations.UpdUser] == DBNull.Value ? null : objRow[conzx_SocialRelations.UpdUser].ToString().Trim(); //修改人
objzx_SocialRelationsEN.CreateDate = objRow[conzx_SocialRelations.CreateDate] == DBNull.Value ? null : objRow[conzx_SocialRelations.CreateDate].ToString().Trim(); //建立日期
objzx_SocialRelationsEN.UpdDate = objRow[conzx_SocialRelations.UpdDate] == DBNull.Value ? null : objRow[conzx_SocialRelations.UpdDate].ToString().Trim(); //修改日期
objzx_SocialRelationsEN.Memo = objRow[conzx_SocialRelations.Memo] == DBNull.Value ? null : objRow[conzx_SocialRelations.Memo].ToString().Trim(); //备注
objzx_SocialRelationsEN.PdfDivLet = objRow[conzx_SocialRelations.PdfDivLet] == DBNull.Value ? null : objRow[conzx_SocialRelations.PdfDivLet].ToString().Trim(); //PdfDivLet
objzx_SocialRelationsEN.PdfDivTop = objRow[conzx_SocialRelations.PdfDivTop] == DBNull.Value ? null : objRow[conzx_SocialRelations.PdfDivTop].ToString().Trim(); //PdfDivTop
objzx_SocialRelationsEN.PdfPageNumIn = objRow[conzx_SocialRelations.PdfPageNumIn] == DBNull.Value ? null : objRow[conzx_SocialRelations.PdfPageNumIn].ToString().Trim(); //PdfPageNumIn
objzx_SocialRelationsEN.PdfPageTop = objRow[conzx_SocialRelations.PdfPageTop] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_SocialRelations.PdfPageTop].ToString().Trim()); //pdf页面顶部位置
objzx_SocialRelationsEN.PdfZoom = objRow[conzx_SocialRelations.PdfZoom] == DBNull.Value ? null : objRow[conzx_SocialRelations.PdfZoom].ToString().Trim(); //PdfZoom
objzx_SocialRelationsEN.GroupTextId = objRow[conzx_SocialRelations.GroupTextId] == DBNull.Value ? null : objRow[conzx_SocialRelations.GroupTextId].ToString().Trim(); //小组Id
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objzx_SocialRelationsEN.zxSocialId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objzx_SocialRelationsEN);
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
public static List<clszx_SocialRelationsEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clszx_SocialRelationsEN> arrObjLst = new List<clszx_SocialRelationsEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clszx_SocialRelationsEN objzx_SocialRelationsEN = new clszx_SocialRelationsEN();
try
{
objzx_SocialRelationsEN.zxSocialId = objRow[conzx_SocialRelations.zxSocialId].ToString().Trim(); //社会Id
objzx_SocialRelationsEN.FullName = objRow[conzx_SocialRelations.FullName] == DBNull.Value ? null : objRow[conzx_SocialRelations.FullName].ToString().Trim(); //姓名
objzx_SocialRelationsEN.Nationality = objRow[conzx_SocialRelations.Nationality] == DBNull.Value ? null : objRow[conzx_SocialRelations.Nationality].ToString().Trim(); //国籍
objzx_SocialRelationsEN.WorkUnit = objRow[conzx_SocialRelations.WorkUnit] == DBNull.Value ? null : objRow[conzx_SocialRelations.WorkUnit].ToString().Trim(); //工作单位
objzx_SocialRelationsEN.Major = objRow[conzx_SocialRelations.Major] == DBNull.Value ? null : objRow[conzx_SocialRelations.Major].ToString().Trim(); //专业
objzx_SocialRelationsEN.Achievement = objRow[conzx_SocialRelations.Achievement] == DBNull.Value ? null : objRow[conzx_SocialRelations.Achievement].ToString().Trim(); //成就
objzx_SocialRelationsEN.DetailedDescription = objRow[conzx_SocialRelations.DetailedDescription] == DBNull.Value ? null : objRow[conzx_SocialRelations.DetailedDescription].ToString().Trim(); //详细说明
objzx_SocialRelationsEN.zxLevelId = objRow[conzx_SocialRelations.zxLevelId] == DBNull.Value ? null : objRow[conzx_SocialRelations.zxLevelId].ToString().Trim(); //级别Id
objzx_SocialRelationsEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[conzx_SocialRelations.IsSubmit].ToString().Trim()); //是否提交
objzx_SocialRelationsEN.VoteCount = objRow[conzx_SocialRelations.VoteCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_SocialRelations.VoteCount].ToString().Trim()); //点赞计数
objzx_SocialRelationsEN.CitationCount = objRow[conzx_SocialRelations.CitationCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_SocialRelations.CitationCount].ToString().Trim()); //引用统计
objzx_SocialRelationsEN.VersionCount = objRow[conzx_SocialRelations.VersionCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_SocialRelations.VersionCount].ToString().Trim()); //版本统计
objzx_SocialRelationsEN.IdCurrEduCls = objRow[conzx_SocialRelations.IdCurrEduCls] == DBNull.Value ? null : objRow[conzx_SocialRelations.IdCurrEduCls].ToString().Trim(); //教学班流水号
objzx_SocialRelationsEN.AppraiseCount = objRow[conzx_SocialRelations.AppraiseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_SocialRelations.AppraiseCount].ToString().Trim()); //评论数
objzx_SocialRelationsEN.Score = objRow[conzx_SocialRelations.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conzx_SocialRelations.Score].ToString().Trim()); //评分
objzx_SocialRelationsEN.StuScore = objRow[conzx_SocialRelations.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conzx_SocialRelations.StuScore].ToString().Trim()); //学生平均分
objzx_SocialRelationsEN.TeaScore = objRow[conzx_SocialRelations.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conzx_SocialRelations.TeaScore].ToString().Trim()); //教师评分
objzx_SocialRelationsEN.TextId = objRow[conzx_SocialRelations.TextId] == DBNull.Value ? null : objRow[conzx_SocialRelations.TextId].ToString().Trim(); //课件Id
objzx_SocialRelationsEN.zxShareId = objRow[conzx_SocialRelations.zxShareId] == DBNull.Value ? null : objRow[conzx_SocialRelations.zxShareId].ToString().Trim(); //分享Id
objzx_SocialRelationsEN.PdfContent = objRow[conzx_SocialRelations.PdfContent] == DBNull.Value ? null : objRow[conzx_SocialRelations.PdfContent].ToString().Trim(); //Pdf内容
objzx_SocialRelationsEN.PdfPageNum = objRow[conzx_SocialRelations.PdfPageNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_SocialRelations.PdfPageNum].ToString().Trim()); //Pdf页码
objzx_SocialRelationsEN.UpdUser = objRow[conzx_SocialRelations.UpdUser] == DBNull.Value ? null : objRow[conzx_SocialRelations.UpdUser].ToString().Trim(); //修改人
objzx_SocialRelationsEN.CreateDate = objRow[conzx_SocialRelations.CreateDate] == DBNull.Value ? null : objRow[conzx_SocialRelations.CreateDate].ToString().Trim(); //建立日期
objzx_SocialRelationsEN.UpdDate = objRow[conzx_SocialRelations.UpdDate] == DBNull.Value ? null : objRow[conzx_SocialRelations.UpdDate].ToString().Trim(); //修改日期
objzx_SocialRelationsEN.Memo = objRow[conzx_SocialRelations.Memo] == DBNull.Value ? null : objRow[conzx_SocialRelations.Memo].ToString().Trim(); //备注
objzx_SocialRelationsEN.PdfDivLet = objRow[conzx_SocialRelations.PdfDivLet] == DBNull.Value ? null : objRow[conzx_SocialRelations.PdfDivLet].ToString().Trim(); //PdfDivLet
objzx_SocialRelationsEN.PdfDivTop = objRow[conzx_SocialRelations.PdfDivTop] == DBNull.Value ? null : objRow[conzx_SocialRelations.PdfDivTop].ToString().Trim(); //PdfDivTop
objzx_SocialRelationsEN.PdfPageNumIn = objRow[conzx_SocialRelations.PdfPageNumIn] == DBNull.Value ? null : objRow[conzx_SocialRelations.PdfPageNumIn].ToString().Trim(); //PdfPageNumIn
objzx_SocialRelationsEN.PdfPageTop = objRow[conzx_SocialRelations.PdfPageTop] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_SocialRelations.PdfPageTop].ToString().Trim()); //pdf页面顶部位置
objzx_SocialRelationsEN.PdfZoom = objRow[conzx_SocialRelations.PdfZoom] == DBNull.Value ? null : objRow[conzx_SocialRelations.PdfZoom].ToString().Trim(); //PdfZoom
objzx_SocialRelationsEN.GroupTextId = objRow[conzx_SocialRelations.GroupTextId] == DBNull.Value ? null : objRow[conzx_SocialRelations.GroupTextId].ToString().Trim(); //小组Id
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objzx_SocialRelationsEN.zxSocialId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objzx_SocialRelationsEN);
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
List<clszx_SocialRelationsEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clszx_SocialRelationsEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clszx_SocialRelationsEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clszx_SocialRelationsEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clszx_SocialRelationsEN> arrObjLst = new List<clszx_SocialRelationsEN>(); 
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
	clszx_SocialRelationsEN objzx_SocialRelationsEN = new clszx_SocialRelationsEN();
try
{
objzx_SocialRelationsEN.zxSocialId = objRow[conzx_SocialRelations.zxSocialId].ToString().Trim(); //社会Id
objzx_SocialRelationsEN.FullName = objRow[conzx_SocialRelations.FullName] == DBNull.Value ? null : objRow[conzx_SocialRelations.FullName].ToString().Trim(); //姓名
objzx_SocialRelationsEN.Nationality = objRow[conzx_SocialRelations.Nationality] == DBNull.Value ? null : objRow[conzx_SocialRelations.Nationality].ToString().Trim(); //国籍
objzx_SocialRelationsEN.WorkUnit = objRow[conzx_SocialRelations.WorkUnit] == DBNull.Value ? null : objRow[conzx_SocialRelations.WorkUnit].ToString().Trim(); //工作单位
objzx_SocialRelationsEN.Major = objRow[conzx_SocialRelations.Major] == DBNull.Value ? null : objRow[conzx_SocialRelations.Major].ToString().Trim(); //专业
objzx_SocialRelationsEN.Achievement = objRow[conzx_SocialRelations.Achievement] == DBNull.Value ? null : objRow[conzx_SocialRelations.Achievement].ToString().Trim(); //成就
objzx_SocialRelationsEN.DetailedDescription = objRow[conzx_SocialRelations.DetailedDescription] == DBNull.Value ? null : objRow[conzx_SocialRelations.DetailedDescription].ToString().Trim(); //详细说明
objzx_SocialRelationsEN.zxLevelId = objRow[conzx_SocialRelations.zxLevelId] == DBNull.Value ? null : objRow[conzx_SocialRelations.zxLevelId].ToString().Trim(); //级别Id
objzx_SocialRelationsEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[conzx_SocialRelations.IsSubmit].ToString().Trim()); //是否提交
objzx_SocialRelationsEN.VoteCount = objRow[conzx_SocialRelations.VoteCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_SocialRelations.VoteCount].ToString().Trim()); //点赞计数
objzx_SocialRelationsEN.CitationCount = objRow[conzx_SocialRelations.CitationCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_SocialRelations.CitationCount].ToString().Trim()); //引用统计
objzx_SocialRelationsEN.VersionCount = objRow[conzx_SocialRelations.VersionCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_SocialRelations.VersionCount].ToString().Trim()); //版本统计
objzx_SocialRelationsEN.IdCurrEduCls = objRow[conzx_SocialRelations.IdCurrEduCls] == DBNull.Value ? null : objRow[conzx_SocialRelations.IdCurrEduCls].ToString().Trim(); //教学班流水号
objzx_SocialRelationsEN.AppraiseCount = objRow[conzx_SocialRelations.AppraiseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_SocialRelations.AppraiseCount].ToString().Trim()); //评论数
objzx_SocialRelationsEN.Score = objRow[conzx_SocialRelations.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conzx_SocialRelations.Score].ToString().Trim()); //评分
objzx_SocialRelationsEN.StuScore = objRow[conzx_SocialRelations.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conzx_SocialRelations.StuScore].ToString().Trim()); //学生平均分
objzx_SocialRelationsEN.TeaScore = objRow[conzx_SocialRelations.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conzx_SocialRelations.TeaScore].ToString().Trim()); //教师评分
objzx_SocialRelationsEN.TextId = objRow[conzx_SocialRelations.TextId] == DBNull.Value ? null : objRow[conzx_SocialRelations.TextId].ToString().Trim(); //课件Id
objzx_SocialRelationsEN.zxShareId = objRow[conzx_SocialRelations.zxShareId] == DBNull.Value ? null : objRow[conzx_SocialRelations.zxShareId].ToString().Trim(); //分享Id
objzx_SocialRelationsEN.PdfContent = objRow[conzx_SocialRelations.PdfContent] == DBNull.Value ? null : objRow[conzx_SocialRelations.PdfContent].ToString().Trim(); //Pdf内容
objzx_SocialRelationsEN.PdfPageNum = objRow[conzx_SocialRelations.PdfPageNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_SocialRelations.PdfPageNum].ToString().Trim()); //Pdf页码
objzx_SocialRelationsEN.UpdUser = objRow[conzx_SocialRelations.UpdUser] == DBNull.Value ? null : objRow[conzx_SocialRelations.UpdUser].ToString().Trim(); //修改人
objzx_SocialRelationsEN.CreateDate = objRow[conzx_SocialRelations.CreateDate] == DBNull.Value ? null : objRow[conzx_SocialRelations.CreateDate].ToString().Trim(); //建立日期
objzx_SocialRelationsEN.UpdDate = objRow[conzx_SocialRelations.UpdDate] == DBNull.Value ? null : objRow[conzx_SocialRelations.UpdDate].ToString().Trim(); //修改日期
objzx_SocialRelationsEN.Memo = objRow[conzx_SocialRelations.Memo] == DBNull.Value ? null : objRow[conzx_SocialRelations.Memo].ToString().Trim(); //备注
objzx_SocialRelationsEN.PdfDivLet = objRow[conzx_SocialRelations.PdfDivLet] == DBNull.Value ? null : objRow[conzx_SocialRelations.PdfDivLet].ToString().Trim(); //PdfDivLet
objzx_SocialRelationsEN.PdfDivTop = objRow[conzx_SocialRelations.PdfDivTop] == DBNull.Value ? null : objRow[conzx_SocialRelations.PdfDivTop].ToString().Trim(); //PdfDivTop
objzx_SocialRelationsEN.PdfPageNumIn = objRow[conzx_SocialRelations.PdfPageNumIn] == DBNull.Value ? null : objRow[conzx_SocialRelations.PdfPageNumIn].ToString().Trim(); //PdfPageNumIn
objzx_SocialRelationsEN.PdfPageTop = objRow[conzx_SocialRelations.PdfPageTop] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_SocialRelations.PdfPageTop].ToString().Trim()); //pdf页面顶部位置
objzx_SocialRelationsEN.PdfZoom = objRow[conzx_SocialRelations.PdfZoom] == DBNull.Value ? null : objRow[conzx_SocialRelations.PdfZoom].ToString().Trim(); //PdfZoom
objzx_SocialRelationsEN.GroupTextId = objRow[conzx_SocialRelations.GroupTextId] == DBNull.Value ? null : objRow[conzx_SocialRelations.GroupTextId].ToString().Trim(); //小组Id
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objzx_SocialRelationsEN.zxSocialId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objzx_SocialRelationsEN);
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
public static List<clszx_SocialRelationsEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clszx_SocialRelationsEN> arrObjLst = new List<clszx_SocialRelationsEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clszx_SocialRelationsEN objzx_SocialRelationsEN = new clszx_SocialRelationsEN();
try
{
objzx_SocialRelationsEN.zxSocialId = objRow[conzx_SocialRelations.zxSocialId].ToString().Trim(); //社会Id
objzx_SocialRelationsEN.FullName = objRow[conzx_SocialRelations.FullName] == DBNull.Value ? null : objRow[conzx_SocialRelations.FullName].ToString().Trim(); //姓名
objzx_SocialRelationsEN.Nationality = objRow[conzx_SocialRelations.Nationality] == DBNull.Value ? null : objRow[conzx_SocialRelations.Nationality].ToString().Trim(); //国籍
objzx_SocialRelationsEN.WorkUnit = objRow[conzx_SocialRelations.WorkUnit] == DBNull.Value ? null : objRow[conzx_SocialRelations.WorkUnit].ToString().Trim(); //工作单位
objzx_SocialRelationsEN.Major = objRow[conzx_SocialRelations.Major] == DBNull.Value ? null : objRow[conzx_SocialRelations.Major].ToString().Trim(); //专业
objzx_SocialRelationsEN.Achievement = objRow[conzx_SocialRelations.Achievement] == DBNull.Value ? null : objRow[conzx_SocialRelations.Achievement].ToString().Trim(); //成就
objzx_SocialRelationsEN.DetailedDescription = objRow[conzx_SocialRelations.DetailedDescription] == DBNull.Value ? null : objRow[conzx_SocialRelations.DetailedDescription].ToString().Trim(); //详细说明
objzx_SocialRelationsEN.zxLevelId = objRow[conzx_SocialRelations.zxLevelId] == DBNull.Value ? null : objRow[conzx_SocialRelations.zxLevelId].ToString().Trim(); //级别Id
objzx_SocialRelationsEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[conzx_SocialRelations.IsSubmit].ToString().Trim()); //是否提交
objzx_SocialRelationsEN.VoteCount = objRow[conzx_SocialRelations.VoteCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_SocialRelations.VoteCount].ToString().Trim()); //点赞计数
objzx_SocialRelationsEN.CitationCount = objRow[conzx_SocialRelations.CitationCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_SocialRelations.CitationCount].ToString().Trim()); //引用统计
objzx_SocialRelationsEN.VersionCount = objRow[conzx_SocialRelations.VersionCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_SocialRelations.VersionCount].ToString().Trim()); //版本统计
objzx_SocialRelationsEN.IdCurrEduCls = objRow[conzx_SocialRelations.IdCurrEduCls] == DBNull.Value ? null : objRow[conzx_SocialRelations.IdCurrEduCls].ToString().Trim(); //教学班流水号
objzx_SocialRelationsEN.AppraiseCount = objRow[conzx_SocialRelations.AppraiseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_SocialRelations.AppraiseCount].ToString().Trim()); //评论数
objzx_SocialRelationsEN.Score = objRow[conzx_SocialRelations.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conzx_SocialRelations.Score].ToString().Trim()); //评分
objzx_SocialRelationsEN.StuScore = objRow[conzx_SocialRelations.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conzx_SocialRelations.StuScore].ToString().Trim()); //学生平均分
objzx_SocialRelationsEN.TeaScore = objRow[conzx_SocialRelations.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conzx_SocialRelations.TeaScore].ToString().Trim()); //教师评分
objzx_SocialRelationsEN.TextId = objRow[conzx_SocialRelations.TextId] == DBNull.Value ? null : objRow[conzx_SocialRelations.TextId].ToString().Trim(); //课件Id
objzx_SocialRelationsEN.zxShareId = objRow[conzx_SocialRelations.zxShareId] == DBNull.Value ? null : objRow[conzx_SocialRelations.zxShareId].ToString().Trim(); //分享Id
objzx_SocialRelationsEN.PdfContent = objRow[conzx_SocialRelations.PdfContent] == DBNull.Value ? null : objRow[conzx_SocialRelations.PdfContent].ToString().Trim(); //Pdf内容
objzx_SocialRelationsEN.PdfPageNum = objRow[conzx_SocialRelations.PdfPageNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_SocialRelations.PdfPageNum].ToString().Trim()); //Pdf页码
objzx_SocialRelationsEN.UpdUser = objRow[conzx_SocialRelations.UpdUser] == DBNull.Value ? null : objRow[conzx_SocialRelations.UpdUser].ToString().Trim(); //修改人
objzx_SocialRelationsEN.CreateDate = objRow[conzx_SocialRelations.CreateDate] == DBNull.Value ? null : objRow[conzx_SocialRelations.CreateDate].ToString().Trim(); //建立日期
objzx_SocialRelationsEN.UpdDate = objRow[conzx_SocialRelations.UpdDate] == DBNull.Value ? null : objRow[conzx_SocialRelations.UpdDate].ToString().Trim(); //修改日期
objzx_SocialRelationsEN.Memo = objRow[conzx_SocialRelations.Memo] == DBNull.Value ? null : objRow[conzx_SocialRelations.Memo].ToString().Trim(); //备注
objzx_SocialRelationsEN.PdfDivLet = objRow[conzx_SocialRelations.PdfDivLet] == DBNull.Value ? null : objRow[conzx_SocialRelations.PdfDivLet].ToString().Trim(); //PdfDivLet
objzx_SocialRelationsEN.PdfDivTop = objRow[conzx_SocialRelations.PdfDivTop] == DBNull.Value ? null : objRow[conzx_SocialRelations.PdfDivTop].ToString().Trim(); //PdfDivTop
objzx_SocialRelationsEN.PdfPageNumIn = objRow[conzx_SocialRelations.PdfPageNumIn] == DBNull.Value ? null : objRow[conzx_SocialRelations.PdfPageNumIn].ToString().Trim(); //PdfPageNumIn
objzx_SocialRelationsEN.PdfPageTop = objRow[conzx_SocialRelations.PdfPageTop] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_SocialRelations.PdfPageTop].ToString().Trim()); //pdf页面顶部位置
objzx_SocialRelationsEN.PdfZoom = objRow[conzx_SocialRelations.PdfZoom] == DBNull.Value ? null : objRow[conzx_SocialRelations.PdfZoom].ToString().Trim(); //PdfZoom
objzx_SocialRelationsEN.GroupTextId = objRow[conzx_SocialRelations.GroupTextId] == DBNull.Value ? null : objRow[conzx_SocialRelations.GroupTextId].ToString().Trim(); //小组Id
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objzx_SocialRelationsEN.zxSocialId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objzx_SocialRelationsEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clszx_SocialRelationsEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clszx_SocialRelationsEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clszx_SocialRelationsEN> arrObjLst = new List<clszx_SocialRelationsEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clszx_SocialRelationsEN objzx_SocialRelationsEN = new clszx_SocialRelationsEN();
try
{
objzx_SocialRelationsEN.zxSocialId = objRow[conzx_SocialRelations.zxSocialId].ToString().Trim(); //社会Id
objzx_SocialRelationsEN.FullName = objRow[conzx_SocialRelations.FullName] == DBNull.Value ? null : objRow[conzx_SocialRelations.FullName].ToString().Trim(); //姓名
objzx_SocialRelationsEN.Nationality = objRow[conzx_SocialRelations.Nationality] == DBNull.Value ? null : objRow[conzx_SocialRelations.Nationality].ToString().Trim(); //国籍
objzx_SocialRelationsEN.WorkUnit = objRow[conzx_SocialRelations.WorkUnit] == DBNull.Value ? null : objRow[conzx_SocialRelations.WorkUnit].ToString().Trim(); //工作单位
objzx_SocialRelationsEN.Major = objRow[conzx_SocialRelations.Major] == DBNull.Value ? null : objRow[conzx_SocialRelations.Major].ToString().Trim(); //专业
objzx_SocialRelationsEN.Achievement = objRow[conzx_SocialRelations.Achievement] == DBNull.Value ? null : objRow[conzx_SocialRelations.Achievement].ToString().Trim(); //成就
objzx_SocialRelationsEN.DetailedDescription = objRow[conzx_SocialRelations.DetailedDescription] == DBNull.Value ? null : objRow[conzx_SocialRelations.DetailedDescription].ToString().Trim(); //详细说明
objzx_SocialRelationsEN.zxLevelId = objRow[conzx_SocialRelations.zxLevelId] == DBNull.Value ? null : objRow[conzx_SocialRelations.zxLevelId].ToString().Trim(); //级别Id
objzx_SocialRelationsEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[conzx_SocialRelations.IsSubmit].ToString().Trim()); //是否提交
objzx_SocialRelationsEN.VoteCount = objRow[conzx_SocialRelations.VoteCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_SocialRelations.VoteCount].ToString().Trim()); //点赞计数
objzx_SocialRelationsEN.CitationCount = objRow[conzx_SocialRelations.CitationCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_SocialRelations.CitationCount].ToString().Trim()); //引用统计
objzx_SocialRelationsEN.VersionCount = objRow[conzx_SocialRelations.VersionCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_SocialRelations.VersionCount].ToString().Trim()); //版本统计
objzx_SocialRelationsEN.IdCurrEduCls = objRow[conzx_SocialRelations.IdCurrEduCls] == DBNull.Value ? null : objRow[conzx_SocialRelations.IdCurrEduCls].ToString().Trim(); //教学班流水号
objzx_SocialRelationsEN.AppraiseCount = objRow[conzx_SocialRelations.AppraiseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_SocialRelations.AppraiseCount].ToString().Trim()); //评论数
objzx_SocialRelationsEN.Score = objRow[conzx_SocialRelations.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conzx_SocialRelations.Score].ToString().Trim()); //评分
objzx_SocialRelationsEN.StuScore = objRow[conzx_SocialRelations.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conzx_SocialRelations.StuScore].ToString().Trim()); //学生平均分
objzx_SocialRelationsEN.TeaScore = objRow[conzx_SocialRelations.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conzx_SocialRelations.TeaScore].ToString().Trim()); //教师评分
objzx_SocialRelationsEN.TextId = objRow[conzx_SocialRelations.TextId] == DBNull.Value ? null : objRow[conzx_SocialRelations.TextId].ToString().Trim(); //课件Id
objzx_SocialRelationsEN.zxShareId = objRow[conzx_SocialRelations.zxShareId] == DBNull.Value ? null : objRow[conzx_SocialRelations.zxShareId].ToString().Trim(); //分享Id
objzx_SocialRelationsEN.PdfContent = objRow[conzx_SocialRelations.PdfContent] == DBNull.Value ? null : objRow[conzx_SocialRelations.PdfContent].ToString().Trim(); //Pdf内容
objzx_SocialRelationsEN.PdfPageNum = objRow[conzx_SocialRelations.PdfPageNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_SocialRelations.PdfPageNum].ToString().Trim()); //Pdf页码
objzx_SocialRelationsEN.UpdUser = objRow[conzx_SocialRelations.UpdUser] == DBNull.Value ? null : objRow[conzx_SocialRelations.UpdUser].ToString().Trim(); //修改人
objzx_SocialRelationsEN.CreateDate = objRow[conzx_SocialRelations.CreateDate] == DBNull.Value ? null : objRow[conzx_SocialRelations.CreateDate].ToString().Trim(); //建立日期
objzx_SocialRelationsEN.UpdDate = objRow[conzx_SocialRelations.UpdDate] == DBNull.Value ? null : objRow[conzx_SocialRelations.UpdDate].ToString().Trim(); //修改日期
objzx_SocialRelationsEN.Memo = objRow[conzx_SocialRelations.Memo] == DBNull.Value ? null : objRow[conzx_SocialRelations.Memo].ToString().Trim(); //备注
objzx_SocialRelationsEN.PdfDivLet = objRow[conzx_SocialRelations.PdfDivLet] == DBNull.Value ? null : objRow[conzx_SocialRelations.PdfDivLet].ToString().Trim(); //PdfDivLet
objzx_SocialRelationsEN.PdfDivTop = objRow[conzx_SocialRelations.PdfDivTop] == DBNull.Value ? null : objRow[conzx_SocialRelations.PdfDivTop].ToString().Trim(); //PdfDivTop
objzx_SocialRelationsEN.PdfPageNumIn = objRow[conzx_SocialRelations.PdfPageNumIn] == DBNull.Value ? null : objRow[conzx_SocialRelations.PdfPageNumIn].ToString().Trim(); //PdfPageNumIn
objzx_SocialRelationsEN.PdfPageTop = objRow[conzx_SocialRelations.PdfPageTop] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_SocialRelations.PdfPageTop].ToString().Trim()); //pdf页面顶部位置
objzx_SocialRelationsEN.PdfZoom = objRow[conzx_SocialRelations.PdfZoom] == DBNull.Value ? null : objRow[conzx_SocialRelations.PdfZoom].ToString().Trim(); //PdfZoom
objzx_SocialRelationsEN.GroupTextId = objRow[conzx_SocialRelations.GroupTextId] == DBNull.Value ? null : objRow[conzx_SocialRelations.GroupTextId].ToString().Trim(); //小组Id
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objzx_SocialRelationsEN.zxSocialId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objzx_SocialRelationsEN);
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
public static List<clszx_SocialRelationsEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clszx_SocialRelationsEN> arrObjLst = new List<clszx_SocialRelationsEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clszx_SocialRelationsEN objzx_SocialRelationsEN = new clszx_SocialRelationsEN();
try
{
objzx_SocialRelationsEN.zxSocialId = objRow[conzx_SocialRelations.zxSocialId].ToString().Trim(); //社会Id
objzx_SocialRelationsEN.FullName = objRow[conzx_SocialRelations.FullName] == DBNull.Value ? null : objRow[conzx_SocialRelations.FullName].ToString().Trim(); //姓名
objzx_SocialRelationsEN.Nationality = objRow[conzx_SocialRelations.Nationality] == DBNull.Value ? null : objRow[conzx_SocialRelations.Nationality].ToString().Trim(); //国籍
objzx_SocialRelationsEN.WorkUnit = objRow[conzx_SocialRelations.WorkUnit] == DBNull.Value ? null : objRow[conzx_SocialRelations.WorkUnit].ToString().Trim(); //工作单位
objzx_SocialRelationsEN.Major = objRow[conzx_SocialRelations.Major] == DBNull.Value ? null : objRow[conzx_SocialRelations.Major].ToString().Trim(); //专业
objzx_SocialRelationsEN.Achievement = objRow[conzx_SocialRelations.Achievement] == DBNull.Value ? null : objRow[conzx_SocialRelations.Achievement].ToString().Trim(); //成就
objzx_SocialRelationsEN.DetailedDescription = objRow[conzx_SocialRelations.DetailedDescription] == DBNull.Value ? null : objRow[conzx_SocialRelations.DetailedDescription].ToString().Trim(); //详细说明
objzx_SocialRelationsEN.zxLevelId = objRow[conzx_SocialRelations.zxLevelId] == DBNull.Value ? null : objRow[conzx_SocialRelations.zxLevelId].ToString().Trim(); //级别Id
objzx_SocialRelationsEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[conzx_SocialRelations.IsSubmit].ToString().Trim()); //是否提交
objzx_SocialRelationsEN.VoteCount = objRow[conzx_SocialRelations.VoteCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_SocialRelations.VoteCount].ToString().Trim()); //点赞计数
objzx_SocialRelationsEN.CitationCount = objRow[conzx_SocialRelations.CitationCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_SocialRelations.CitationCount].ToString().Trim()); //引用统计
objzx_SocialRelationsEN.VersionCount = objRow[conzx_SocialRelations.VersionCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_SocialRelations.VersionCount].ToString().Trim()); //版本统计
objzx_SocialRelationsEN.IdCurrEduCls = objRow[conzx_SocialRelations.IdCurrEduCls] == DBNull.Value ? null : objRow[conzx_SocialRelations.IdCurrEduCls].ToString().Trim(); //教学班流水号
objzx_SocialRelationsEN.AppraiseCount = objRow[conzx_SocialRelations.AppraiseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_SocialRelations.AppraiseCount].ToString().Trim()); //评论数
objzx_SocialRelationsEN.Score = objRow[conzx_SocialRelations.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conzx_SocialRelations.Score].ToString().Trim()); //评分
objzx_SocialRelationsEN.StuScore = objRow[conzx_SocialRelations.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conzx_SocialRelations.StuScore].ToString().Trim()); //学生平均分
objzx_SocialRelationsEN.TeaScore = objRow[conzx_SocialRelations.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conzx_SocialRelations.TeaScore].ToString().Trim()); //教师评分
objzx_SocialRelationsEN.TextId = objRow[conzx_SocialRelations.TextId] == DBNull.Value ? null : objRow[conzx_SocialRelations.TextId].ToString().Trim(); //课件Id
objzx_SocialRelationsEN.zxShareId = objRow[conzx_SocialRelations.zxShareId] == DBNull.Value ? null : objRow[conzx_SocialRelations.zxShareId].ToString().Trim(); //分享Id
objzx_SocialRelationsEN.PdfContent = objRow[conzx_SocialRelations.PdfContent] == DBNull.Value ? null : objRow[conzx_SocialRelations.PdfContent].ToString().Trim(); //Pdf内容
objzx_SocialRelationsEN.PdfPageNum = objRow[conzx_SocialRelations.PdfPageNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_SocialRelations.PdfPageNum].ToString().Trim()); //Pdf页码
objzx_SocialRelationsEN.UpdUser = objRow[conzx_SocialRelations.UpdUser] == DBNull.Value ? null : objRow[conzx_SocialRelations.UpdUser].ToString().Trim(); //修改人
objzx_SocialRelationsEN.CreateDate = objRow[conzx_SocialRelations.CreateDate] == DBNull.Value ? null : objRow[conzx_SocialRelations.CreateDate].ToString().Trim(); //建立日期
objzx_SocialRelationsEN.UpdDate = objRow[conzx_SocialRelations.UpdDate] == DBNull.Value ? null : objRow[conzx_SocialRelations.UpdDate].ToString().Trim(); //修改日期
objzx_SocialRelationsEN.Memo = objRow[conzx_SocialRelations.Memo] == DBNull.Value ? null : objRow[conzx_SocialRelations.Memo].ToString().Trim(); //备注
objzx_SocialRelationsEN.PdfDivLet = objRow[conzx_SocialRelations.PdfDivLet] == DBNull.Value ? null : objRow[conzx_SocialRelations.PdfDivLet].ToString().Trim(); //PdfDivLet
objzx_SocialRelationsEN.PdfDivTop = objRow[conzx_SocialRelations.PdfDivTop] == DBNull.Value ? null : objRow[conzx_SocialRelations.PdfDivTop].ToString().Trim(); //PdfDivTop
objzx_SocialRelationsEN.PdfPageNumIn = objRow[conzx_SocialRelations.PdfPageNumIn] == DBNull.Value ? null : objRow[conzx_SocialRelations.PdfPageNumIn].ToString().Trim(); //PdfPageNumIn
objzx_SocialRelationsEN.PdfPageTop = objRow[conzx_SocialRelations.PdfPageTop] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_SocialRelations.PdfPageTop].ToString().Trim()); //pdf页面顶部位置
objzx_SocialRelationsEN.PdfZoom = objRow[conzx_SocialRelations.PdfZoom] == DBNull.Value ? null : objRow[conzx_SocialRelations.PdfZoom].ToString().Trim(); //PdfZoom
objzx_SocialRelationsEN.GroupTextId = objRow[conzx_SocialRelations.GroupTextId] == DBNull.Value ? null : objRow[conzx_SocialRelations.GroupTextId].ToString().Trim(); //小组Id
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objzx_SocialRelationsEN.zxSocialId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objzx_SocialRelationsEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clszx_SocialRelationsEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clszx_SocialRelationsEN> arrObjLst = new List<clszx_SocialRelationsEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clszx_SocialRelationsEN objzx_SocialRelationsEN = new clszx_SocialRelationsEN();
try
{
objzx_SocialRelationsEN.zxSocialId = objRow[conzx_SocialRelations.zxSocialId].ToString().Trim(); //社会Id
objzx_SocialRelationsEN.FullName = objRow[conzx_SocialRelations.FullName] == DBNull.Value ? null : objRow[conzx_SocialRelations.FullName].ToString().Trim(); //姓名
objzx_SocialRelationsEN.Nationality = objRow[conzx_SocialRelations.Nationality] == DBNull.Value ? null : objRow[conzx_SocialRelations.Nationality].ToString().Trim(); //国籍
objzx_SocialRelationsEN.WorkUnit = objRow[conzx_SocialRelations.WorkUnit] == DBNull.Value ? null : objRow[conzx_SocialRelations.WorkUnit].ToString().Trim(); //工作单位
objzx_SocialRelationsEN.Major = objRow[conzx_SocialRelations.Major] == DBNull.Value ? null : objRow[conzx_SocialRelations.Major].ToString().Trim(); //专业
objzx_SocialRelationsEN.Achievement = objRow[conzx_SocialRelations.Achievement] == DBNull.Value ? null : objRow[conzx_SocialRelations.Achievement].ToString().Trim(); //成就
objzx_SocialRelationsEN.DetailedDescription = objRow[conzx_SocialRelations.DetailedDescription] == DBNull.Value ? null : objRow[conzx_SocialRelations.DetailedDescription].ToString().Trim(); //详细说明
objzx_SocialRelationsEN.zxLevelId = objRow[conzx_SocialRelations.zxLevelId] == DBNull.Value ? null : objRow[conzx_SocialRelations.zxLevelId].ToString().Trim(); //级别Id
objzx_SocialRelationsEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[conzx_SocialRelations.IsSubmit].ToString().Trim()); //是否提交
objzx_SocialRelationsEN.VoteCount = objRow[conzx_SocialRelations.VoteCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_SocialRelations.VoteCount].ToString().Trim()); //点赞计数
objzx_SocialRelationsEN.CitationCount = objRow[conzx_SocialRelations.CitationCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_SocialRelations.CitationCount].ToString().Trim()); //引用统计
objzx_SocialRelationsEN.VersionCount = objRow[conzx_SocialRelations.VersionCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_SocialRelations.VersionCount].ToString().Trim()); //版本统计
objzx_SocialRelationsEN.IdCurrEduCls = objRow[conzx_SocialRelations.IdCurrEduCls] == DBNull.Value ? null : objRow[conzx_SocialRelations.IdCurrEduCls].ToString().Trim(); //教学班流水号
objzx_SocialRelationsEN.AppraiseCount = objRow[conzx_SocialRelations.AppraiseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_SocialRelations.AppraiseCount].ToString().Trim()); //评论数
objzx_SocialRelationsEN.Score = objRow[conzx_SocialRelations.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conzx_SocialRelations.Score].ToString().Trim()); //评分
objzx_SocialRelationsEN.StuScore = objRow[conzx_SocialRelations.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conzx_SocialRelations.StuScore].ToString().Trim()); //学生平均分
objzx_SocialRelationsEN.TeaScore = objRow[conzx_SocialRelations.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conzx_SocialRelations.TeaScore].ToString().Trim()); //教师评分
objzx_SocialRelationsEN.TextId = objRow[conzx_SocialRelations.TextId] == DBNull.Value ? null : objRow[conzx_SocialRelations.TextId].ToString().Trim(); //课件Id
objzx_SocialRelationsEN.zxShareId = objRow[conzx_SocialRelations.zxShareId] == DBNull.Value ? null : objRow[conzx_SocialRelations.zxShareId].ToString().Trim(); //分享Id
objzx_SocialRelationsEN.PdfContent = objRow[conzx_SocialRelations.PdfContent] == DBNull.Value ? null : objRow[conzx_SocialRelations.PdfContent].ToString().Trim(); //Pdf内容
objzx_SocialRelationsEN.PdfPageNum = objRow[conzx_SocialRelations.PdfPageNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_SocialRelations.PdfPageNum].ToString().Trim()); //Pdf页码
objzx_SocialRelationsEN.UpdUser = objRow[conzx_SocialRelations.UpdUser] == DBNull.Value ? null : objRow[conzx_SocialRelations.UpdUser].ToString().Trim(); //修改人
objzx_SocialRelationsEN.CreateDate = objRow[conzx_SocialRelations.CreateDate] == DBNull.Value ? null : objRow[conzx_SocialRelations.CreateDate].ToString().Trim(); //建立日期
objzx_SocialRelationsEN.UpdDate = objRow[conzx_SocialRelations.UpdDate] == DBNull.Value ? null : objRow[conzx_SocialRelations.UpdDate].ToString().Trim(); //修改日期
objzx_SocialRelationsEN.Memo = objRow[conzx_SocialRelations.Memo] == DBNull.Value ? null : objRow[conzx_SocialRelations.Memo].ToString().Trim(); //备注
objzx_SocialRelationsEN.PdfDivLet = objRow[conzx_SocialRelations.PdfDivLet] == DBNull.Value ? null : objRow[conzx_SocialRelations.PdfDivLet].ToString().Trim(); //PdfDivLet
objzx_SocialRelationsEN.PdfDivTop = objRow[conzx_SocialRelations.PdfDivTop] == DBNull.Value ? null : objRow[conzx_SocialRelations.PdfDivTop].ToString().Trim(); //PdfDivTop
objzx_SocialRelationsEN.PdfPageNumIn = objRow[conzx_SocialRelations.PdfPageNumIn] == DBNull.Value ? null : objRow[conzx_SocialRelations.PdfPageNumIn].ToString().Trim(); //PdfPageNumIn
objzx_SocialRelationsEN.PdfPageTop = objRow[conzx_SocialRelations.PdfPageTop] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_SocialRelations.PdfPageTop].ToString().Trim()); //pdf页面顶部位置
objzx_SocialRelationsEN.PdfZoom = objRow[conzx_SocialRelations.PdfZoom] == DBNull.Value ? null : objRow[conzx_SocialRelations.PdfZoom].ToString().Trim(); //PdfZoom
objzx_SocialRelationsEN.GroupTextId = objRow[conzx_SocialRelations.GroupTextId] == DBNull.Value ? null : objRow[conzx_SocialRelations.GroupTextId].ToString().Trim(); //小组Id
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objzx_SocialRelationsEN.zxSocialId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objzx_SocialRelationsEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objzx_SocialRelationsEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool Getzx_SocialRelations(ref clszx_SocialRelationsEN objzx_SocialRelationsEN)
{
bool bolResult = zx_SocialRelationsDA.Getzx_SocialRelations(ref objzx_SocialRelationsEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "strzxSocialId">表关键字</param>
 /// <returns>表对象</returns>
public static clszx_SocialRelationsEN GetObjByzxSocialId(string strzxSocialId)
{
if (strzxSocialId.IndexOf(' ') >=0)
{
var strMsg = string.Format("(errid:Busi000079)在表中,关键字[strzxSocialId]中不能有空格!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
if (string.IsNullOrEmpty(strzxSocialId) == true)
{
var strMsg = string.Format("(errid:Busi000020)在表中,关键字[strzxSocialId]不能为空!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
clszx_SocialRelationsEN objzx_SocialRelationsEN = zx_SocialRelationsDA.GetObjByzxSocialId(strzxSocialId);
return objzx_SocialRelationsEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clszx_SocialRelationsEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clszx_SocialRelationsEN objzx_SocialRelationsEN = zx_SocialRelationsDA.GetFirstObj(strWhereCond);
 return objzx_SocialRelationsEN;
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
public static clszx_SocialRelationsEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clszx_SocialRelationsEN objzx_SocialRelationsEN = zx_SocialRelationsDA.GetObjByDataRow(objRow);
 return objzx_SocialRelationsEN;
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
public static clszx_SocialRelationsEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clszx_SocialRelationsEN objzx_SocialRelationsEN = zx_SocialRelationsDA.GetObjByDataRow(objRow);
 return objzx_SocialRelationsEN;
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
 /// <param name = "strzxSocialId">所给的关键字</param>
 /// <param name = "lstzx_SocialRelationsObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clszx_SocialRelationsEN GetObjByzxSocialIdFromList(string strzxSocialId, List<clszx_SocialRelationsEN> lstzx_SocialRelationsObjLst)
{
foreach (clszx_SocialRelationsEN objzx_SocialRelationsEN in lstzx_SocialRelationsObjLst)
{
if (objzx_SocialRelationsEN.zxSocialId == strzxSocialId)
{
return objzx_SocialRelationsEN;
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
 string strMaxZxSocialId;
 try
 {
 strMaxZxSocialId = clszx_SocialRelationsDA.GetMaxStrId();
 return strMaxZxSocialId;
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
 string strzxSocialId;
 try
 {
 strzxSocialId = new clszx_SocialRelationsDA().GetFirstID(strWhereCond);
 return strzxSocialId;
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
 arrList = zx_SocialRelationsDA.GetID(strWhereCond);
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
bool bolIsExist = zx_SocialRelationsDA.IsExistCondRec(strWhereCond);
return bolIsExist;
}

 /// <summary>
 /// 判断当前表中是否存在给定关键字值的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExist)
 /// </summary>
 /// <param name = "strzxSocialId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public static bool IsExist(string strzxSocialId)
{
if (string.IsNullOrEmpty(strzxSocialId) == true)
{
var strMsg = string.Format("(errid:Busi000027)在表中,关键字[strzxSocialId]不能为空!!(from {0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
//检测记录是否存在
bool bolIsExist = zx_SocialRelationsDA.IsExist(strzxSocialId);
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
 bolIsExist = clszx_SocialRelationsDA.IsExistTable();
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
 bolIsExist = zx_SocialRelationsDA.IsExistTable(strTabName);
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
 /// <param name = "objzx_SocialRelationsEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecordBySql2(clszx_SocialRelationsEN objzx_SocialRelationsEN)
{
if (objzx_SocialRelationsEN.CheckUniqueness() == false)
{
var strMsg = string.Format("记录已经存在!课件Id = [{0}]的数据已经存在!(in clszx_SocialRelationsBL.AddNewRecordBySql2)", objzx_SocialRelationsEN.TextId);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objzx_SocialRelationsEN.zxSocialId) == true || clszx_SocialRelationsBL.IsExist(objzx_SocialRelationsEN.zxSocialId) == true)
 {
     objzx_SocialRelationsEN.zxSocialId = clszx_SocialRelationsBL.GetMaxStrId_S();
 }
bool bolResult = zx_SocialRelationsDA.AddNewRecordBySQL2(objzx_SocialRelationsEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clszx_SocialRelationsBL.ReFreshCache(objzx_SocialRelationsEN.IdCurrEduCls);

if (clszx_SocialRelationsBL.relatedActions != null)
{
clszx_SocialRelationsBL.relatedActions.UpdRelaTabDate(objzx_SocialRelationsEN.zxSocialId, "SetUpdDate");
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
 /// <param name = "objzx_SocialRelationsEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordBySql2WithReturnKey(clszx_SocialRelationsEN objzx_SocialRelationsEN)
{
if (objzx_SocialRelationsEN.CheckUniqueness() == false)
{
var strMsg = string.Format("记录已经存在!课件Id = [{0}]的数据已经存在!(in clszx_SocialRelationsBL.AddNewRecordBySql2WithReturnKey)", objzx_SocialRelationsEN.TextId);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objzx_SocialRelationsEN.zxSocialId) == true || clszx_SocialRelationsBL.IsExist(objzx_SocialRelationsEN.zxSocialId) == true)
 {
     objzx_SocialRelationsEN.zxSocialId = clszx_SocialRelationsBL.GetMaxStrId_S();
 }
string strKey = zx_SocialRelationsDA.AddNewRecordBySQL2WithReturnKey(objzx_SocialRelationsEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clszx_SocialRelationsBL.ReFreshCache(objzx_SocialRelationsEN.IdCurrEduCls);

if (clszx_SocialRelationsBL.relatedActions != null)
{
clszx_SocialRelationsBL.relatedActions.UpdRelaTabDate(objzx_SocialRelationsEN.zxSocialId, "SetUpdDate");
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
 /// <param name = "objzx_SocialRelationsEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(clszx_SocialRelationsEN objzx_SocialRelationsEN)
{
try
{
bool bolResult = zx_SocialRelationsDA.Update(objzx_SocialRelationsEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clszx_SocialRelationsBL.ReFreshCache(objzx_SocialRelationsEN.IdCurrEduCls);

if (clszx_SocialRelationsBL.relatedActions != null)
{
clszx_SocialRelationsBL.relatedActions.UpdRelaTabDate(objzx_SocialRelationsEN.zxSocialId, "SetUpdDate");
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
 /// <param name = "objzx_SocialRelationsEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateBySql2(clszx_SocialRelationsEN objzx_SocialRelationsEN)
{
 if (string.IsNullOrEmpty(objzx_SocialRelationsEN.zxSocialId) == true)
 {
var strMsg = string.Format("(errid:Busi000065)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = zx_SocialRelationsDA.UpdateBySql2(objzx_SocialRelationsEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clszx_SocialRelationsBL.ReFreshCache(objzx_SocialRelationsEN.IdCurrEduCls);

if (clszx_SocialRelationsBL.relatedActions != null)
{
clszx_SocialRelationsBL.relatedActions.UpdRelaTabDate(objzx_SocialRelationsEN.zxSocialId, "SetUpdDate");
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
 /// <param name = "strzxSocialId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int DelRecord(string strzxSocialId)
{
try
{
 clszx_SocialRelationsEN objzx_SocialRelationsEN = clszx_SocialRelationsBL.GetObjByzxSocialId(strzxSocialId);

if (clszx_SocialRelationsBL.relatedActions != null)
{
clszx_SocialRelationsBL.relatedActions.UpdRelaTabDate(objzx_SocialRelationsEN.zxSocialId, "SetUpdDate");
}
if (objzx_SocialRelationsEN != null)
{
int intRecNum = zx_SocialRelationsDA.DelRecord(strzxSocialId);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
ReFreshCache(objzx_SocialRelationsEN.IdCurrEduCls);
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
/// <param name="strzxSocialId">表关键字</param>
 /// <param name = "strIdCurrEduCls">缓存的分类字段</param>
/// <returns></returns>
public static bool DelRecordEx(string strzxSocialId , string strIdCurrEduCls)
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clszx_SocialRelationsDA.GetSpecSQLObj();
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
//删除与表:[zx_SocialRelations]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conzx_SocialRelations.zxSocialId,
//strzxSocialId);
//        clszx_SocialRelationsBL.Delzx_SocialRelationssByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clszx_SocialRelationsBL.DelRecord(strzxSocialId, strIdCurrEduCls, objConnection, objSqlTransaction);
objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clszx_SocialRelationsBLEx", "DelRecordEx", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("扩展删除记录出错:{0}!keyId = {1}.({2})",
objException.Message,
strzxSocialId, clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "strzxSocialId">给定的关键字值</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回删除是否成功?</returns>
public static bool DelRecord(string strzxSocialId, string strIdCurrEduCls, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
if (clszx_SocialRelationsBL.relatedActions != null)
{
clszx_SocialRelationsBL.relatedActions.UpdRelaTabDate(strzxSocialId, "UpdRelaTabDate");
}
bool bolResult = zx_SocialRelationsDA.DelRecord(strzxSocialId,objSqlConnection,objSqlTransaction);
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
 /// <param name = "arrzxSocialIdLst">给定的关键字值列表</param>
 /// <returns>返回删除的记录数</returns>
public static int Delzx_SocialRelationss(List<string> arrzxSocialIdLst)
{
if (arrzxSocialIdLst.Count == 0) return 0;
try
{
if (clszx_SocialRelationsBL.relatedActions != null)
{
foreach (var strzxSocialId in arrzxSocialIdLst)
{
clszx_SocialRelationsBL.relatedActions.UpdRelaTabDate(strzxSocialId, "UpdRelaTabDate");
}
}
 clszx_SocialRelationsEN objzx_SocialRelationsEN = clszx_SocialRelationsBL.GetObjByzxSocialId(arrzxSocialIdLst[0]);
int intDelRecNum = zx_SocialRelationsDA.Delzx_SocialRelations(arrzxSocialIdLst);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
ReFreshCache(objzx_SocialRelationsEN.IdCurrEduCls);
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
public static int Delzx_SocialRelationssByCond(string strWhereCond)
{
try
{
if (clszx_SocialRelationsBL.relatedActions != null)
{
List<string> arrzxSocialId = GetPrimaryKeyID_S(strWhereCond);
foreach (var strzxSocialId in arrzxSocialId)
{
clszx_SocialRelationsBL.relatedActions.UpdRelaTabDate(strzxSocialId, "UpdRelaTabDate");
}
}
List<string> arrIdCurrEduCls = GetFldValue(conzx_SocialRelations.IdCurrEduCls, strWhereCond);
int intRecNum = zx_SocialRelationsDA.Delzx_SocialRelations(strWhereCond);
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
/// 这里仅仅是演示函数,使用时请复制到扩展类:[zx_SocialRelations]中改名为:[DelRecord4MultiTabEx]使用
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DelRecord4MultiTab)
/// </summary>
/// <param name="strzxSocialId">表关键字</param>
 /// <param name = "strIdCurrEduCls">缓存的分类字段</param>
/// <returns></returns>
public static bool DelRecord4MultiTab(string strzxSocialId, string strIdCurrEduCls)
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clszx_SocialRelationsDA.GetSpecSQLObj();
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
//删除与表:[zx_SocialRelations]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conStudent.id_College,
//strid_College);
//        clsStudentBL.DelStudentsByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clszx_SocialRelationsBL.DelRecord(strzxSocialId, strIdCurrEduCls, objConnection, objSqlTransaction);
                objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clszx_SocialRelationsBL", "DelRecord4MultiTab", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("删除多表记录出错:{0}!keyId = {1}.({2})",
objException.Message,
strzxSocialId, clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "objzx_SocialRelationsENS">源对象</param>
 /// <param name = "objzx_SocialRelationsENT">目标对象</param>
 public static void CopyTo(clszx_SocialRelationsEN objzx_SocialRelationsENS, clszx_SocialRelationsEN objzx_SocialRelationsENT)
{
try
{
objzx_SocialRelationsENT.zxSocialId = objzx_SocialRelationsENS.zxSocialId; //社会Id
objzx_SocialRelationsENT.FullName = objzx_SocialRelationsENS.FullName; //姓名
objzx_SocialRelationsENT.Nationality = objzx_SocialRelationsENS.Nationality; //国籍
objzx_SocialRelationsENT.WorkUnit = objzx_SocialRelationsENS.WorkUnit; //工作单位
objzx_SocialRelationsENT.Major = objzx_SocialRelationsENS.Major; //专业
objzx_SocialRelationsENT.Achievement = objzx_SocialRelationsENS.Achievement; //成就
objzx_SocialRelationsENT.DetailedDescription = objzx_SocialRelationsENS.DetailedDescription; //详细说明
objzx_SocialRelationsENT.zxLevelId = objzx_SocialRelationsENS.zxLevelId; //级别Id
objzx_SocialRelationsENT.IsSubmit = objzx_SocialRelationsENS.IsSubmit; //是否提交
objzx_SocialRelationsENT.VoteCount = objzx_SocialRelationsENS.VoteCount; //点赞计数
objzx_SocialRelationsENT.CitationCount = objzx_SocialRelationsENS.CitationCount; //引用统计
objzx_SocialRelationsENT.VersionCount = objzx_SocialRelationsENS.VersionCount; //版本统计
objzx_SocialRelationsENT.IdCurrEduCls = objzx_SocialRelationsENS.IdCurrEduCls; //教学班流水号
objzx_SocialRelationsENT.AppraiseCount = objzx_SocialRelationsENS.AppraiseCount; //评论数
objzx_SocialRelationsENT.Score = objzx_SocialRelationsENS.Score; //评分
objzx_SocialRelationsENT.StuScore = objzx_SocialRelationsENS.StuScore; //学生平均分
objzx_SocialRelationsENT.TeaScore = objzx_SocialRelationsENS.TeaScore; //教师评分
objzx_SocialRelationsENT.TextId = objzx_SocialRelationsENS.TextId; //课件Id
objzx_SocialRelationsENT.zxShareId = objzx_SocialRelationsENS.zxShareId; //分享Id
objzx_SocialRelationsENT.PdfContent = objzx_SocialRelationsENS.PdfContent; //Pdf内容
objzx_SocialRelationsENT.PdfPageNum = objzx_SocialRelationsENS.PdfPageNum; //Pdf页码
objzx_SocialRelationsENT.UpdUser = objzx_SocialRelationsENS.UpdUser; //修改人
objzx_SocialRelationsENT.CreateDate = objzx_SocialRelationsENS.CreateDate; //建立日期
objzx_SocialRelationsENT.UpdDate = objzx_SocialRelationsENS.UpdDate; //修改日期
objzx_SocialRelationsENT.Memo = objzx_SocialRelationsENS.Memo; //备注
objzx_SocialRelationsENT.PdfDivLet = objzx_SocialRelationsENS.PdfDivLet; //PdfDivLet
objzx_SocialRelationsENT.PdfDivTop = objzx_SocialRelationsENS.PdfDivTop; //PdfDivTop
objzx_SocialRelationsENT.PdfPageNumIn = objzx_SocialRelationsENS.PdfPageNumIn; //PdfPageNumIn
objzx_SocialRelationsENT.PdfPageTop = objzx_SocialRelationsENS.PdfPageTop; //pdf页面顶部位置
objzx_SocialRelationsENT.PdfZoom = objzx_SocialRelationsENS.PdfZoom; //PdfZoom
objzx_SocialRelationsENT.GroupTextId = objzx_SocialRelationsENS.GroupTextId; //小组Id
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
 /// <param name = "objzx_SocialRelationsEN">源简化对象</param>
 public static void SetUpdFlag(clszx_SocialRelationsEN objzx_SocialRelationsEN)
{
try
{
objzx_SocialRelationsEN.ClearUpdateState();
   string strsfUpdFldSetStr = objzx_SocialRelationsEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(conzx_SocialRelations.zxSocialId, new clsStrCompareIgnoreCase())  ==  true)
{
objzx_SocialRelationsEN.zxSocialId = objzx_SocialRelationsEN.zxSocialId; //社会Id
}
if (arrFldSet.Contains(conzx_SocialRelations.FullName, new clsStrCompareIgnoreCase())  ==  true)
{
objzx_SocialRelationsEN.FullName = objzx_SocialRelationsEN.FullName == "[null]" ? null :  objzx_SocialRelationsEN.FullName; //姓名
}
if (arrFldSet.Contains(conzx_SocialRelations.Nationality, new clsStrCompareIgnoreCase())  ==  true)
{
objzx_SocialRelationsEN.Nationality = objzx_SocialRelationsEN.Nationality == "[null]" ? null :  objzx_SocialRelationsEN.Nationality; //国籍
}
if (arrFldSet.Contains(conzx_SocialRelations.WorkUnit, new clsStrCompareIgnoreCase())  ==  true)
{
objzx_SocialRelationsEN.WorkUnit = objzx_SocialRelationsEN.WorkUnit == "[null]" ? null :  objzx_SocialRelationsEN.WorkUnit; //工作单位
}
if (arrFldSet.Contains(conzx_SocialRelations.Major, new clsStrCompareIgnoreCase())  ==  true)
{
objzx_SocialRelationsEN.Major = objzx_SocialRelationsEN.Major == "[null]" ? null :  objzx_SocialRelationsEN.Major; //专业
}
if (arrFldSet.Contains(conzx_SocialRelations.Achievement, new clsStrCompareIgnoreCase())  ==  true)
{
objzx_SocialRelationsEN.Achievement = objzx_SocialRelationsEN.Achievement == "[null]" ? null :  objzx_SocialRelationsEN.Achievement; //成就
}
if (arrFldSet.Contains(conzx_SocialRelations.DetailedDescription, new clsStrCompareIgnoreCase())  ==  true)
{
objzx_SocialRelationsEN.DetailedDescription = objzx_SocialRelationsEN.DetailedDescription == "[null]" ? null :  objzx_SocialRelationsEN.DetailedDescription; //详细说明
}
if (arrFldSet.Contains(conzx_SocialRelations.zxLevelId, new clsStrCompareIgnoreCase())  ==  true)
{
objzx_SocialRelationsEN.zxLevelId = objzx_SocialRelationsEN.zxLevelId == "[null]" ? null :  objzx_SocialRelationsEN.zxLevelId; //级别Id
}
if (arrFldSet.Contains(conzx_SocialRelations.IsSubmit, new clsStrCompareIgnoreCase())  ==  true)
{
objzx_SocialRelationsEN.IsSubmit = objzx_SocialRelationsEN.IsSubmit; //是否提交
}
if (arrFldSet.Contains(conzx_SocialRelations.VoteCount, new clsStrCompareIgnoreCase())  ==  true)
{
objzx_SocialRelationsEN.VoteCount = objzx_SocialRelationsEN.VoteCount; //点赞计数
}
if (arrFldSet.Contains(conzx_SocialRelations.CitationCount, new clsStrCompareIgnoreCase())  ==  true)
{
objzx_SocialRelationsEN.CitationCount = objzx_SocialRelationsEN.CitationCount; //引用统计
}
if (arrFldSet.Contains(conzx_SocialRelations.VersionCount, new clsStrCompareIgnoreCase())  ==  true)
{
objzx_SocialRelationsEN.VersionCount = objzx_SocialRelationsEN.VersionCount; //版本统计
}
if (arrFldSet.Contains(conzx_SocialRelations.IdCurrEduCls, new clsStrCompareIgnoreCase())  ==  true)
{
objzx_SocialRelationsEN.IdCurrEduCls = objzx_SocialRelationsEN.IdCurrEduCls == "[null]" ? null :  objzx_SocialRelationsEN.IdCurrEduCls; //教学班流水号
}
if (arrFldSet.Contains(conzx_SocialRelations.AppraiseCount, new clsStrCompareIgnoreCase())  ==  true)
{
objzx_SocialRelationsEN.AppraiseCount = objzx_SocialRelationsEN.AppraiseCount; //评论数
}
if (arrFldSet.Contains(conzx_SocialRelations.Score, new clsStrCompareIgnoreCase())  ==  true)
{
objzx_SocialRelationsEN.Score = objzx_SocialRelationsEN.Score; //评分
}
if (arrFldSet.Contains(conzx_SocialRelations.StuScore, new clsStrCompareIgnoreCase())  ==  true)
{
objzx_SocialRelationsEN.StuScore = objzx_SocialRelationsEN.StuScore; //学生平均分
}
if (arrFldSet.Contains(conzx_SocialRelations.TeaScore, new clsStrCompareIgnoreCase())  ==  true)
{
objzx_SocialRelationsEN.TeaScore = objzx_SocialRelationsEN.TeaScore; //教师评分
}
if (arrFldSet.Contains(conzx_SocialRelations.TextId, new clsStrCompareIgnoreCase())  ==  true)
{
objzx_SocialRelationsEN.TextId = objzx_SocialRelationsEN.TextId == "[null]" ? null :  objzx_SocialRelationsEN.TextId; //课件Id
}
if (arrFldSet.Contains(conzx_SocialRelations.zxShareId, new clsStrCompareIgnoreCase())  ==  true)
{
objzx_SocialRelationsEN.zxShareId = objzx_SocialRelationsEN.zxShareId == "[null]" ? null :  objzx_SocialRelationsEN.zxShareId; //分享Id
}
if (arrFldSet.Contains(conzx_SocialRelations.PdfContent, new clsStrCompareIgnoreCase())  ==  true)
{
objzx_SocialRelationsEN.PdfContent = objzx_SocialRelationsEN.PdfContent == "[null]" ? null :  objzx_SocialRelationsEN.PdfContent; //Pdf内容
}
if (arrFldSet.Contains(conzx_SocialRelations.PdfPageNum, new clsStrCompareIgnoreCase())  ==  true)
{
objzx_SocialRelationsEN.PdfPageNum = objzx_SocialRelationsEN.PdfPageNum; //Pdf页码
}
if (arrFldSet.Contains(conzx_SocialRelations.UpdUser, new clsStrCompareIgnoreCase())  ==  true)
{
objzx_SocialRelationsEN.UpdUser = objzx_SocialRelationsEN.UpdUser == "[null]" ? null :  objzx_SocialRelationsEN.UpdUser; //修改人
}
if (arrFldSet.Contains(conzx_SocialRelations.CreateDate, new clsStrCompareIgnoreCase())  ==  true)
{
objzx_SocialRelationsEN.CreateDate = objzx_SocialRelationsEN.CreateDate == "[null]" ? null :  objzx_SocialRelationsEN.CreateDate; //建立日期
}
if (arrFldSet.Contains(conzx_SocialRelations.UpdDate, new clsStrCompareIgnoreCase())  ==  true)
{
objzx_SocialRelationsEN.UpdDate = objzx_SocialRelationsEN.UpdDate == "[null]" ? null :  objzx_SocialRelationsEN.UpdDate; //修改日期
}
if (arrFldSet.Contains(conzx_SocialRelations.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objzx_SocialRelationsEN.Memo = objzx_SocialRelationsEN.Memo == "[null]" ? null :  objzx_SocialRelationsEN.Memo; //备注
}
if (arrFldSet.Contains(conzx_SocialRelations.PdfDivLet, new clsStrCompareIgnoreCase())  ==  true)
{
objzx_SocialRelationsEN.PdfDivLet = objzx_SocialRelationsEN.PdfDivLet == "[null]" ? null :  objzx_SocialRelationsEN.PdfDivLet; //PdfDivLet
}
if (arrFldSet.Contains(conzx_SocialRelations.PdfDivTop, new clsStrCompareIgnoreCase())  ==  true)
{
objzx_SocialRelationsEN.PdfDivTop = objzx_SocialRelationsEN.PdfDivTop == "[null]" ? null :  objzx_SocialRelationsEN.PdfDivTop; //PdfDivTop
}
if (arrFldSet.Contains(conzx_SocialRelations.PdfPageNumIn, new clsStrCompareIgnoreCase())  ==  true)
{
objzx_SocialRelationsEN.PdfPageNumIn = objzx_SocialRelationsEN.PdfPageNumIn == "[null]" ? null :  objzx_SocialRelationsEN.PdfPageNumIn; //PdfPageNumIn
}
if (arrFldSet.Contains(conzx_SocialRelations.PdfPageTop, new clsStrCompareIgnoreCase())  ==  true)
{
objzx_SocialRelationsEN.PdfPageTop = objzx_SocialRelationsEN.PdfPageTop; //pdf页面顶部位置
}
if (arrFldSet.Contains(conzx_SocialRelations.PdfZoom, new clsStrCompareIgnoreCase())  ==  true)
{
objzx_SocialRelationsEN.PdfZoom = objzx_SocialRelationsEN.PdfZoom == "[null]" ? null :  objzx_SocialRelationsEN.PdfZoom; //PdfZoom
}
if (arrFldSet.Contains(conzx_SocialRelations.GroupTextId, new clsStrCompareIgnoreCase())  ==  true)
{
objzx_SocialRelationsEN.GroupTextId = objzx_SocialRelationsEN.GroupTextId == "[null]" ? null :  objzx_SocialRelationsEN.GroupTextId; //小组Id
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
 /// <param name = "objzx_SocialRelationsEN">源简化对象</param>
 public static void AccessFldValueNull(clszx_SocialRelationsEN objzx_SocialRelationsEN)
{
try
{
if (objzx_SocialRelationsEN.FullName == "[null]") objzx_SocialRelationsEN.FullName = null; //姓名
if (objzx_SocialRelationsEN.Nationality == "[null]") objzx_SocialRelationsEN.Nationality = null; //国籍
if (objzx_SocialRelationsEN.WorkUnit == "[null]") objzx_SocialRelationsEN.WorkUnit = null; //工作单位
if (objzx_SocialRelationsEN.Major == "[null]") objzx_SocialRelationsEN.Major = null; //专业
if (objzx_SocialRelationsEN.Achievement == "[null]") objzx_SocialRelationsEN.Achievement = null; //成就
if (objzx_SocialRelationsEN.DetailedDescription == "[null]") objzx_SocialRelationsEN.DetailedDescription = null; //详细说明
if (objzx_SocialRelationsEN.zxLevelId == "[null]") objzx_SocialRelationsEN.zxLevelId = null; //级别Id
if (objzx_SocialRelationsEN.IdCurrEduCls == "[null]") objzx_SocialRelationsEN.IdCurrEduCls = null; //教学班流水号
if (objzx_SocialRelationsEN.TextId == "[null]") objzx_SocialRelationsEN.TextId = null; //课件Id
if (objzx_SocialRelationsEN.zxShareId == "[null]") objzx_SocialRelationsEN.zxShareId = null; //分享Id
if (objzx_SocialRelationsEN.PdfContent == "[null]") objzx_SocialRelationsEN.PdfContent = null; //Pdf内容
if (objzx_SocialRelationsEN.UpdUser == "[null]") objzx_SocialRelationsEN.UpdUser = null; //修改人
if (objzx_SocialRelationsEN.CreateDate == "[null]") objzx_SocialRelationsEN.CreateDate = null; //建立日期
if (objzx_SocialRelationsEN.UpdDate == "[null]") objzx_SocialRelationsEN.UpdDate = null; //修改日期
if (objzx_SocialRelationsEN.Memo == "[null]") objzx_SocialRelationsEN.Memo = null; //备注
if (objzx_SocialRelationsEN.PdfDivLet == "[null]") objzx_SocialRelationsEN.PdfDivLet = null; //PdfDivLet
if (objzx_SocialRelationsEN.PdfDivTop == "[null]") objzx_SocialRelationsEN.PdfDivTop = null; //PdfDivTop
if (objzx_SocialRelationsEN.PdfPageNumIn == "[null]") objzx_SocialRelationsEN.PdfPageNumIn = null; //PdfPageNumIn
if (objzx_SocialRelationsEN.PdfZoom == "[null]") objzx_SocialRelationsEN.PdfZoom = null; //PdfZoom
if (objzx_SocialRelationsEN.GroupTextId == "[null]") objzx_SocialRelationsEN.GroupTextId = null; //小组Id
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
public static void CheckPropertyNew(clszx_SocialRelationsEN objzx_SocialRelationsEN)
{
 zx_SocialRelationsDA.CheckPropertyNew(objzx_SocialRelationsEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(clszx_SocialRelationsEN objzx_SocialRelationsEN)
{
 zx_SocialRelationsDA.CheckProperty4Condition(objzx_SocialRelationsEN);
 }


 #endregion 检查对象属性


 #region 绑定下拉框

 /// <summary>
 /// 绑定基于Win的下拉框
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_TabFeature_ComboBoxBindFunction)
 /// </summary>
 /// <param name = "objComboBox">需要绑定当前表的下拉框</param>

 /// <param name = "strIdCurrEduCls"></param>
public static void BindCbo_zxSocialId(System.Windows.Forms.ComboBox objComboBox , string strIdCurrEduCls)
{
//为数据源为表的下拉框设置内容
string strCondition = string.Format("1 =1 Order By {0}", conzx_SocialRelations.zxSocialId); 
List<clszx_SocialRelationsEN> arrObjLst = clszx_SocialRelationsBL.GetObjLst(strCondition);
var arrObjLstSel = arrObjLst.Where(x=>x.IdCurrEduCls == strIdCurrEduCls).ToList();
//初始化一个对象列表
//插入第0项。在第0项中插入“请选择...”,为了方便用户,与WEB方式类似。
clszx_SocialRelationsEN objzx_SocialRelationsEN = new clszx_SocialRelationsEN()
{
zxSocialId = "0",
zxLevelId = "选[中学社会关系]..."
};
arrObjLstSel.Insert(0, objzx_SocialRelationsEN);
//设置下拉框的数据源、以及设置值项、显示项
objComboBox.ValueMember = conzx_SocialRelations.zxSocialId;
objComboBox.DisplayMember = conzx_SocialRelations.zxLevelId;
objComboBox.DataSource = arrObjLstSel;
objComboBox.SelectedIndex = 0;
}

 /// <summary>
 /// 绑定基于Web的下拉框
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_TabFeature_DdlBindFunction)
 /// </summary>
 /// <param name = "objDDL">需要绑定当前表的下拉框</param>

 /// <param name = "strIdCurrEduCls"></param>
public static void BindDdl_zxSocialId(System.Web.UI.WebControls.DropDownList objDDL , string strIdCurrEduCls)
{
//为数据源于表的下拉框设置内容
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[中学社会关系]...","0");
string strCondition = string.Format("1 =1 Order By {0}", conzx_SocialRelations.zxSocialId); 
IEnumerable<clszx_SocialRelationsEN> arrObjLst = clszx_SocialRelationsBL.GetObjLst(strCondition);
var arrObjLstSel = arrObjLst.Where(x=>x.IdCurrEduCls == strIdCurrEduCls).ToList();
objDDL.DataValueField = conzx_SocialRelations.zxSocialId;
objDDL.DataTextField = conzx_SocialRelations.zxLevelId;
objDDL.DataSource = arrObjLstSel;
objDDL.DataBind();
objDDL.Items.Insert(0, li);
objDDL.SelectedIndex = 0;
}

 /// <summary>
 /// 绑定基于Web的下拉框-使用Cache
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DdlBindFunctionCache)
 /// </summary>
 /// <param name = "objDDL">需要绑定当前表的下拉框</param>
public static void BindDdl_zxSocialIdCache(System.Web.UI.WebControls.DropDownList objDDL, string strIdCurrEduCls)
{
//为数据源于表的下拉框设置内容
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[中学社会关系]...","0");
List<clszx_SocialRelationsEN> arrzx_SocialRelationsObjLst = GetAllzx_SocialRelationsObjLstCache(strIdCurrEduCls); 
objDDL.DataValueField = conzx_SocialRelations.zxSocialId;
objDDL.DataTextField = conzx_SocialRelations.zxLevelId;
objDDL.DataSource = arrzx_SocialRelationsObjLst;
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
if (clszx_SocialRelationsBL.objCommFun4BL == null)
{
strMsg = string.Format("类clszx_SocialRelationsBL没有刷新缓存机制(clszx_SocialRelationsBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by zxSocialId");
//if (arrzx_SocialRelationsObjLstCache == null)
//{
//arrzx_SocialRelationsObjLstCache = zx_SocialRelationsDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "strzxSocialId">所给的关键字</param>
 /// <param name = "strIdCurrEduCls">缓存的分类字段</param>
 /// <returns>根据关键字获取的对象</returns>
public static clszx_SocialRelationsEN GetObjByzxSocialIdCache(string strzxSocialId, string strIdCurrEduCls)
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
string strKey = string.Format("{0}_{1}", clszx_SocialRelationsEN._CurrTabName, strIdCurrEduCls);
List<clszx_SocialRelationsEN> arrzx_SocialRelationsObjLstCache = GetObjLstCache(strIdCurrEduCls);
IEnumerable <clszx_SocialRelationsEN> arrzx_SocialRelationsObjLst_Sel =
arrzx_SocialRelationsObjLstCache
.Where(x=> x.zxSocialId == strzxSocialId 
);
if (arrzx_SocialRelationsObjLst_Sel.Count() == 0)
{
   clszx_SocialRelationsEN obj = clszx_SocialRelationsBL.GetObjByzxSocialId(strzxSocialId);
   if (obj != null)
 {
if (obj.IdCurrEduCls == strIdCurrEduCls)
{
CacheHelper.Remove(strKey);
     return obj;
}
else
{
string strMsg = string.Format("错误: 关键字:{0}不属于分类:{1},请检查!(In {2})", strzxSocialId, strIdCurrEduCls, clsStackTrace.GetCurrClassFunction());
clsSysParaEN.objLog.WriteDebugLog(strMsg);
throw new Exception(strMsg);
}
 }
return null;
}
return arrzx_SocialRelationsObjLst_Sel.First();
}

 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecNameByKeyCache)
 /// </summary>
 /// <param name = "strzxSocialId">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetzxLevelIdByzxSocialIdCache(string strzxSocialId, string strIdCurrEduCls)
{
if (string.IsNullOrEmpty(strzxSocialId) == true) return "";
//获取缓存中的对象列表
clszx_SocialRelationsEN objzx_SocialRelations = GetObjByzxSocialIdCache(strzxSocialId, strIdCurrEduCls);
if (objzx_SocialRelations == null) return "";
return objzx_SocialRelations.zxLevelId;
}
 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecNameByKeyCache)
 /// </summary>
 /// <param name = "strzxSocialId">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetNameByzxSocialIdCache(string strzxSocialId, string strIdCurrEduCls)
{
if (string.IsNullOrEmpty(strzxSocialId) == true) return "";
//获取缓存中的对象列表
clszx_SocialRelationsEN objzx_SocialRelations = GetObjByzxSocialIdCache(strzxSocialId, strIdCurrEduCls);
if (objzx_SocialRelations == null) return "";
return objzx_SocialRelations.zxLevelId;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clszx_SocialRelationsEN> GetAllzx_SocialRelationsObjLstCache(string strIdCurrEduCls)
{
//获取缓存中的对象列表
List<clszx_SocialRelationsEN> arrzx_SocialRelationsObjLstCache = GetObjLstCache(strIdCurrEduCls); 
return arrzx_SocialRelationsObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clszx_SocialRelationsEN> GetObjLstCache(string strIdCurrEduCls)
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
string strKey = string.Format("{0}_{1}", clszx_SocialRelationsEN._CurrTabName, strIdCurrEduCls);
string strCondition = string.Format("IdCurrEduCls='{0}'", strIdCurrEduCls);
List<clszx_SocialRelationsEN> arrzx_SocialRelationsObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst(strCondition); });
return arrzx_SocialRelationsObjLstCache;
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
string strKey = string.Format("{0}_{1}", clszx_SocialRelationsEN._CurrTabName, strIdCurrEduCls);
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
public static void ReFreshCache(string strIdCurrEduCls)
{
if (string.IsNullOrEmpty(strIdCurrEduCls) == true)
{
string strMsg = string.Format("缓存分类字段:[IdCurrEduCls]不能为空!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clszx_SocialRelationsBL.objCommFun4BL != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}_{1}", clszx_SocialRelationsEN._CurrTabName, strIdCurrEduCls);
CacheHelper.Remove(strKey);
clszx_SocialRelationsBL.objCommFun4BL.ReFreshCache(strIdCurrEduCls);
}
}


 #endregion 缓存操作


 #region 检查唯一性

 /// <summary>
 /// 获取检查唯一性条件串(Uniqueness)--zx_SocialRelations(中学社会关系)
 /// 唯一性条件:TextId
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetUniquenessConditionString)
 /// </summary>
 /// <param name = "objzx_SocialRelationsEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(clszx_SocialRelationsEN objzx_SocialRelationsEN)
{
//检测记录是否存在
string strResult = zx_SocialRelationsDA.GetUniCondStr(objzx_SocialRelationsEN);
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
 /// <param name = "strIdCurrEduCls">缓存的分类字段</param>
 /// <returns>返回一个输出字段值</returns>
public static string Func(string strInFldName, string strOutFldName, string strzxSocialId, string strIdCurrEduCls)
{
if (strInFldName != conzx_SocialRelations.zxSocialId)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (conzx_SocialRelations.AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", conzx_SocialRelations.AttributeName));
throw new Exception(strMsg);
}
var objzx_SocialRelations = clszx_SocialRelationsBL.GetObjByzxSocialIdCache(strzxSocialId, strIdCurrEduCls);
if (objzx_SocialRelations == null) return "";
return objzx_SocialRelations[strOutFldName].ToString();
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
int intRecCount = clszx_SocialRelationsDA.GetRecCount(strTabName);
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
int intRecCount = clszx_SocialRelationsDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clszx_SocialRelationsDA.GetRecCount();
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
int intRecCount = clszx_SocialRelationsDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objzx_SocialRelationsCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clszx_SocialRelationsEN objzx_SocialRelationsCond)
{
 string strIdCurrEduCls = objzx_SocialRelationsCond.IdCurrEduCls;
 if (string.IsNullOrEmpty(strIdCurrEduCls) == true)
{
string strMsg = string.Format("(errid:Busi000174)在表中,缓存分类字段值不能为空!(clszx_SocialRelationsBL:GetRecCountByCondCache)");
throw new Exception(strMsg);
}
List<clszx_SocialRelationsEN> arrObjLstCache = GetObjLstCache(strIdCurrEduCls);
IEnumerable <clszx_SocialRelationsEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conzx_SocialRelations.AttributeName)
{
if (objzx_SocialRelationsCond.IsUpdated(strFldName) == false) continue;
if (objzx_SocialRelationsCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objzx_SocialRelationsCond[strFldName].ToString());
}
else
{
if (objzx_SocialRelationsCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objzx_SocialRelationsCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objzx_SocialRelationsCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objzx_SocialRelationsCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objzx_SocialRelationsCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objzx_SocialRelationsCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objzx_SocialRelationsCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objzx_SocialRelationsCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objzx_SocialRelationsCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objzx_SocialRelationsCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objzx_SocialRelationsCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objzx_SocialRelationsCond[strFldName]));
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
 List<string> arrList = clszx_SocialRelationsDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = zx_SocialRelationsDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = zx_SocialRelationsDA.GetFldValueNoDistinct(strFldName, strWhereCond);
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
int intRecCount = zx_SocialRelationsDA.SetFldValue(strFldName, strValue, strWhereCond);
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
int intRecCount = clszx_SocialRelationsDA.SetFldValue(clszx_SocialRelationsEN._CurrTabName, strFldName, fltValue, strWhereCond);
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
int intRecCount = zx_SocialRelationsDA.SetFldValue( strFldName, intValue, strWhereCond);
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
int intRecCount = clszx_SocialRelationsDA.SetFldValue(strTabName, strFldName, strValue, strWhereCond);
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
int intRecCount = clszx_SocialRelationsDA.SetFldValue(strTabName, strFldName, intValue, strWhereCond);
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
int intRecCount = clszx_SocialRelationsDA.SetFldValue(strTabName, strFldName, fltValue, strWhereCond);
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
  strCreateTabCode.Append("CREATE table [dbo].[zx_SocialRelations] "); 
 strCreateTabCode.Append(" ( "); 
 // /**社会Id*/ 
 strCreateTabCode.Append(" zxSocialId char(10) primary key, "); 
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
 // /**修改人*/ 
 strCreateTabCode.Append(" UpdUser varchar(20) Null, "); 
 // /**建立日期*/ 
 strCreateTabCode.Append(" CreateDate varchar(20) Null, "); 
 // /**修改日期*/ 
 strCreateTabCode.Append(" UpdDate varchar(20) Null, "); 
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
 /// 中学社会关系(zx_SocialRelations)
 /// 数据源类型:表
 /// (AutoGCLib.CommFun4BL4CSharp:GeneCode_This)
 /// </summary>
public class  clsCommFun4BL4zx_SocialRelations : clsCommFun4BLV2
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
clszx_SocialRelationsBL.ReFreshThisCache(strIdCurrEduCls);
}
}

}