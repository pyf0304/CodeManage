
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsSenateGaugeVersionBL
 表名:SenateGaugeVersion(01120297)
 * 版本:2024.11.13.1(服务器:WIN-SRV103-116)
 日期:2024/11/13 06:13:55
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:研究生学习游戏化后台(000055, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:评价相关参数(SenateGaugePara)
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
public static class  clsSenateGaugeVersionBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "strIdSenateGaugeVersion">表关键字</param>
 /// <returns>表对象</returns>
public static clsSenateGaugeVersionEN GetObj(this K_IdSenateGaugeVersion_SenateGaugeVersion myKey)
{
clsSenateGaugeVersionEN objSenateGaugeVersionEN = clsSenateGaugeVersionBL.SenateGaugeVersionDA.GetObjByIdSenateGaugeVersion(myKey.Value);
return objSenateGaugeVersionEN;
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_AddNewRecord)
 /// </summary>
 /// <param name = "objSenateGaugeVersionEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clsSenateGaugeVersionEN objSenateGaugeVersionEN, bool bolIsNeedCheckUniqueness = true)
{
if (bolIsNeedCheckUniqueness == true && CheckUniqueness(objSenateGaugeVersionEN) == false)
{
var strMsg = string.Format("记录已经存在!评价量表版本名称 = [{0}]的数据已经存在!(in clsSenateGaugeVersionBL.AddNewRecord)", objSenateGaugeVersionEN.senateGaugeVersionName);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objSenateGaugeVersionEN.IdSenateGaugeVersion) == true || clsSenateGaugeVersionBL.IsExist(objSenateGaugeVersionEN.IdSenateGaugeVersion) == true)
 {
     objSenateGaugeVersionEN.IdSenateGaugeVersion = clsSenateGaugeVersionBL.GetMaxStrId_S();
 }
bool bolResult = clsSenateGaugeVersionBL.SenateGaugeVersionDA.AddNewRecordBySQL2(objSenateGaugeVersionEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsSenateGaugeVersionBL.ReFreshCache();

if (clsSenateGaugeVersionBL.relatedActions != null)
{
clsSenateGaugeVersionBL.relatedActions.UpdRelaTabDate(objSenateGaugeVersionEN.IdSenateGaugeVersion, objSenateGaugeVersionEN.UpdUserId);
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
public static bool AddRecordEx(this clsSenateGaugeVersionEN objSenateGaugeVersionEN, bool bolIsNeedCheckUniqueness = true)
{
//操作步骤:
//1、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在
//2、检查唯一性
//3、检查传进去的对象属性是否合法
//4、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
//1、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在

//因为是字符型自增主键,不需要检查主键是否已经存在,在添加时,再获取 最大值作为主键
//if (clsSenateGaugeVersionBL.IsExist(objSenateGaugeVersionEN.IdSenateGaugeVersion))	//判断是否有相同的关键字
//{
//strMsg = "(errid:Busi000151)关键字字段已有相同的值";
//throw new Exception(strMsg);
//}
try
{
 //2、检查传进去的对象属性是否合法
objSenateGaugeVersionEN.CheckPropertyNew();
 ///5.2、检查唯一性
if (bolIsNeedCheckUniqueness == true && objSenateGaugeVersionEN.CheckUniqueness() == false)
{
strMsg = string.Format("(评价量表版本名称(senateGaugeVersionName)=[{0}])已经存在,不能重复!", objSenateGaugeVersionEN.senateGaugeVersionName);
throw new Exception(strMsg);
}
//因为是字符型自增主键,所以在添加时,自动获取主键值。
 if (string.IsNullOrEmpty(objSenateGaugeVersionEN.IdSenateGaugeVersion) == true || clsSenateGaugeVersionBL.IsExist(objSenateGaugeVersionEN.IdSenateGaugeVersion) == true)
 {
     objSenateGaugeVersionEN.IdSenateGaugeVersion = clsSenateGaugeVersionBL.GetMaxStrId_S();
 }
//6、把数据实体层的数据存贮到数据库中
objSenateGaugeVersionEN.AddNewRecord();
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
 /// <param name = "objSenateGaugeVersionEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static string AddNewRecordWithMaxId(this clsSenateGaugeVersionEN objSenateGaugeVersionEN, bool bolIsNeedCheckUniqueness = true)
{
if (bolIsNeedCheckUniqueness == true && CheckUniqueness(objSenateGaugeVersionEN) == false)
{
var strMsg = string.Format("记录已经存在!评价量表版本名称 = [{0}]的数据已经存在!(in clsSenateGaugeVersionBL.AddNewRecordWithMaxId)", objSenateGaugeVersionEN.senateGaugeVersionName);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objSenateGaugeVersionEN.IdSenateGaugeVersion) == true || clsSenateGaugeVersionBL.IsExist(objSenateGaugeVersionEN.IdSenateGaugeVersion) == true)
 {
     objSenateGaugeVersionEN.IdSenateGaugeVersion = clsSenateGaugeVersionBL.GetMaxStrId_S();
 }
string strIdSenateGaugeVersion = clsSenateGaugeVersionBL.SenateGaugeVersionDA.AddNewRecordBySQL2WithReturnKey(objSenateGaugeVersionEN);
     objSenateGaugeVersionEN.IdSenateGaugeVersion = strIdSenateGaugeVersion;
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsSenateGaugeVersionBL.ReFreshCache();

if (clsSenateGaugeVersionBL.relatedActions != null)
{
clsSenateGaugeVersionBL.relatedActions.UpdRelaTabDate(objSenateGaugeVersionEN.IdSenateGaugeVersion, objSenateGaugeVersionEN.UpdUserId);
}
return strIdSenateGaugeVersion;
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
 /// <param name = "objSenateGaugeVersionEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordWithReturnKey(this clsSenateGaugeVersionEN objSenateGaugeVersionEN, bool bolIsNeedCheckUniqueness = true)
{
if (bolIsNeedCheckUniqueness == true && CheckUniqueness(objSenateGaugeVersionEN) == false)
{
var strMsg = string.Format("记录已经存在!评价量表版本名称 = [{0}]的数据已经存在!(in clsSenateGaugeVersionBL.AddNewRecordWithReturnKey)", objSenateGaugeVersionEN.senateGaugeVersionName);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objSenateGaugeVersionEN.IdSenateGaugeVersion) == true || clsSenateGaugeVersionBL.IsExist(objSenateGaugeVersionEN.IdSenateGaugeVersion) == true)
 {
     objSenateGaugeVersionEN.IdSenateGaugeVersion = clsSenateGaugeVersionBL.GetMaxStrId_S();
 }
string strKey = clsSenateGaugeVersionBL.SenateGaugeVersionDA.AddNewRecordBySQL2WithReturnKey(objSenateGaugeVersionEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsSenateGaugeVersionBL.ReFreshCache();

if (clsSenateGaugeVersionBL.relatedActions != null)
{
clsSenateGaugeVersionBL.relatedActions.UpdRelaTabDate(objSenateGaugeVersionEN.IdSenateGaugeVersion, objSenateGaugeVersionEN.UpdUserId);
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
 /// <param name = "objSenateGaugeVersionEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsSenateGaugeVersionEN SetIdSenateGaugeVersion(this clsSenateGaugeVersionEN objSenateGaugeVersionEN, string strIdSenateGaugeVersion, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdSenateGaugeVersion, 4, conSenateGaugeVersion.IdSenateGaugeVersion);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdSenateGaugeVersion, 4, conSenateGaugeVersion.IdSenateGaugeVersion);
}
objSenateGaugeVersionEN.IdSenateGaugeVersion = strIdSenateGaugeVersion; //评价量表版本流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objSenateGaugeVersionEN.dicFldComparisonOp.ContainsKey(conSenateGaugeVersion.IdSenateGaugeVersion) == false)
{
objSenateGaugeVersionEN.dicFldComparisonOp.Add(conSenateGaugeVersion.IdSenateGaugeVersion, strComparisonOp);
}
else
{
objSenateGaugeVersionEN.dicFldComparisonOp[conSenateGaugeVersion.IdSenateGaugeVersion] = strComparisonOp;
}
}
return objSenateGaugeVersionEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objSenateGaugeVersionEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsSenateGaugeVersionEN SetsenateGaugeVersionID(this clsSenateGaugeVersionEN objSenateGaugeVersionEN, string strsenateGaugeVersionID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strsenateGaugeVersionID, conSenateGaugeVersion.senateGaugeVersionID);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strsenateGaugeVersionID, 4, conSenateGaugeVersion.senateGaugeVersionID);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strsenateGaugeVersionID, 4, conSenateGaugeVersion.senateGaugeVersionID);
}
objSenateGaugeVersionEN.senateGaugeVersionID = strsenateGaugeVersionID; //评价量表版本ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objSenateGaugeVersionEN.dicFldComparisonOp.ContainsKey(conSenateGaugeVersion.senateGaugeVersionID) == false)
{
objSenateGaugeVersionEN.dicFldComparisonOp.Add(conSenateGaugeVersion.senateGaugeVersionID, strComparisonOp);
}
else
{
objSenateGaugeVersionEN.dicFldComparisonOp[conSenateGaugeVersion.senateGaugeVersionID] = strComparisonOp;
}
}
return objSenateGaugeVersionEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objSenateGaugeVersionEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsSenateGaugeVersionEN SetsenateGaugeVersionName(this clsSenateGaugeVersionEN objSenateGaugeVersionEN, string strsenateGaugeVersionName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strsenateGaugeVersionName, conSenateGaugeVersion.senateGaugeVersionName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strsenateGaugeVersionName, 200, conSenateGaugeVersion.senateGaugeVersionName);
}
objSenateGaugeVersionEN.senateGaugeVersionName = strsenateGaugeVersionName; //评价量表版本名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objSenateGaugeVersionEN.dicFldComparisonOp.ContainsKey(conSenateGaugeVersion.senateGaugeVersionName) == false)
{
objSenateGaugeVersionEN.dicFldComparisonOp.Add(conSenateGaugeVersion.senateGaugeVersionName, strComparisonOp);
}
else
{
objSenateGaugeVersionEN.dicFldComparisonOp[conSenateGaugeVersion.senateGaugeVersionName] = strComparisonOp;
}
}
return objSenateGaugeVersionEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objSenateGaugeVersionEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsSenateGaugeVersionEN SetsenateGaugeVersionTtlScore(this clsSenateGaugeVersionEN objSenateGaugeVersionEN, float fltsenateGaugeVersionTtlScore, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(fltsenateGaugeVersionTtlScore, conSenateGaugeVersion.senateGaugeVersionTtlScore);
objSenateGaugeVersionEN.senateGaugeVersionTtlScore = fltsenateGaugeVersionTtlScore; //评价量表版本总分
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objSenateGaugeVersionEN.dicFldComparisonOp.ContainsKey(conSenateGaugeVersion.senateGaugeVersionTtlScore) == false)
{
objSenateGaugeVersionEN.dicFldComparisonOp.Add(conSenateGaugeVersion.senateGaugeVersionTtlScore, strComparisonOp);
}
else
{
objSenateGaugeVersionEN.dicFldComparisonOp[conSenateGaugeVersion.senateGaugeVersionTtlScore] = strComparisonOp;
}
}
return objSenateGaugeVersionEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objSenateGaugeVersionEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsSenateGaugeVersionEN SetIsUse(this clsSenateGaugeVersionEN objSenateGaugeVersionEN, bool bolIsUse, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(bolIsUse, conSenateGaugeVersion.IsUse);
objSenateGaugeVersionEN.IsUse = bolIsUse; //是否使用
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objSenateGaugeVersionEN.dicFldComparisonOp.ContainsKey(conSenateGaugeVersion.IsUse) == false)
{
objSenateGaugeVersionEN.dicFldComparisonOp.Add(conSenateGaugeVersion.IsUse, strComparisonOp);
}
else
{
objSenateGaugeVersionEN.dicFldComparisonOp[conSenateGaugeVersion.IsUse] = strComparisonOp;
}
}
return objSenateGaugeVersionEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objSenateGaugeVersionEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsSenateGaugeVersionEN SetVersionNo(this clsSenateGaugeVersionEN objSenateGaugeVersionEN, int? intVersionNo, string strComparisonOp="")
	{
objSenateGaugeVersionEN.VersionNo = intVersionNo; //版本号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objSenateGaugeVersionEN.dicFldComparisonOp.ContainsKey(conSenateGaugeVersion.VersionNo) == false)
{
objSenateGaugeVersionEN.dicFldComparisonOp.Add(conSenateGaugeVersion.VersionNo, strComparisonOp);
}
else
{
objSenateGaugeVersionEN.dicFldComparisonOp[conSenateGaugeVersion.VersionNo] = strComparisonOp;
}
}
return objSenateGaugeVersionEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objSenateGaugeVersionEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsSenateGaugeVersionEN SetIdSkillType(this clsSenateGaugeVersionEN objSenateGaugeVersionEN, string strIdSkillType, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strIdSkillType, conSenateGaugeVersion.IdSkillType);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdSkillType, 4, conSenateGaugeVersion.IdSkillType);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdSkillType, 4, conSenateGaugeVersion.IdSkillType);
}
objSenateGaugeVersionEN.IdSkillType = strIdSkillType; //技能类型流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objSenateGaugeVersionEN.dicFldComparisonOp.ContainsKey(conSenateGaugeVersion.IdSkillType) == false)
{
objSenateGaugeVersionEN.dicFldComparisonOp.Add(conSenateGaugeVersion.IdSkillType, strComparisonOp);
}
else
{
objSenateGaugeVersionEN.dicFldComparisonOp[conSenateGaugeVersion.IdSkillType] = strComparisonOp;
}
}
return objSenateGaugeVersionEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objSenateGaugeVersionEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsSenateGaugeVersionEN SetUserTypeId(this clsSenateGaugeVersionEN objSenateGaugeVersionEN, string strUserTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strUserTypeId, conSenateGaugeVersion.UserTypeId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUserTypeId, 2, conSenateGaugeVersion.UserTypeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strUserTypeId, 2, conSenateGaugeVersion.UserTypeId);
}
objSenateGaugeVersionEN.UserTypeId = strUserTypeId; //用户类型Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objSenateGaugeVersionEN.dicFldComparisonOp.ContainsKey(conSenateGaugeVersion.UserTypeId) == false)
{
objSenateGaugeVersionEN.dicFldComparisonOp.Add(conSenateGaugeVersion.UserTypeId, strComparisonOp);
}
else
{
objSenateGaugeVersionEN.dicFldComparisonOp[conSenateGaugeVersion.UserTypeId] = strComparisonOp;
}
}
return objSenateGaugeVersionEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objSenateGaugeVersionEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsSenateGaugeVersionEN SetUpdDate(this clsSenateGaugeVersionEN objSenateGaugeVersionEN, string strUpdDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdDate, 20, conSenateGaugeVersion.UpdDate);
}
objSenateGaugeVersionEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objSenateGaugeVersionEN.dicFldComparisonOp.ContainsKey(conSenateGaugeVersion.UpdDate) == false)
{
objSenateGaugeVersionEN.dicFldComparisonOp.Add(conSenateGaugeVersion.UpdDate, strComparisonOp);
}
else
{
objSenateGaugeVersionEN.dicFldComparisonOp[conSenateGaugeVersion.UpdDate] = strComparisonOp;
}
}
return objSenateGaugeVersionEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objSenateGaugeVersionEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsSenateGaugeVersionEN SetUpdUserId(this clsSenateGaugeVersionEN objSenateGaugeVersionEN, string strUpdUserId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdUserId, 20, conSenateGaugeVersion.UpdUserId);
}
objSenateGaugeVersionEN.UpdUserId = strUpdUserId; //修改用户Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objSenateGaugeVersionEN.dicFldComparisonOp.ContainsKey(conSenateGaugeVersion.UpdUserId) == false)
{
objSenateGaugeVersionEN.dicFldComparisonOp.Add(conSenateGaugeVersion.UpdUserId, strComparisonOp);
}
else
{
objSenateGaugeVersionEN.dicFldComparisonOp[conSenateGaugeVersion.UpdUserId] = strComparisonOp;
}
}
return objSenateGaugeVersionEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objSenateGaugeVersionEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsSenateGaugeVersionEN SetsenateGaugeVersionMemo(this clsSenateGaugeVersionEN objSenateGaugeVersionEN, string strsenateGaugeVersionMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strsenateGaugeVersionMemo, 1000, conSenateGaugeVersion.senateGaugeVersionMemo);
}
objSenateGaugeVersionEN.senateGaugeVersionMemo = strsenateGaugeVersionMemo; //评价量表版本说明
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objSenateGaugeVersionEN.dicFldComparisonOp.ContainsKey(conSenateGaugeVersion.senateGaugeVersionMemo) == false)
{
objSenateGaugeVersionEN.dicFldComparisonOp.Add(conSenateGaugeVersion.senateGaugeVersionMemo, strComparisonOp);
}
else
{
objSenateGaugeVersionEN.dicFldComparisonOp[conSenateGaugeVersion.senateGaugeVersionMemo] = strComparisonOp;
}
}
return objSenateGaugeVersionEN;
	}

 /// <summary>
 /// 修改记录存盘到数据表中
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_UpdateRecordEx)
 /// </summary>
 /// <param name = "objSenateGaugeVersionEN">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool UpdateRecordEx(this clsSenateGaugeVersionEN objSenateGaugeVersionEN)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
try
{
//1、检查传进去的对象属性是否合法
objSenateGaugeVersionEN.CheckPropertyNew();
clsSenateGaugeVersionEN objSenateGaugeVersionCond = new clsSenateGaugeVersionEN();
string strCondition = objSenateGaugeVersionCond
.SetIdSenateGaugeVersion(objSenateGaugeVersionEN.IdSenateGaugeVersion, "<>")
.SetsenateGaugeVersionName(objSenateGaugeVersionEN.senateGaugeVersionName, "=")
.GetCombineCondition();
objSenateGaugeVersionEN._IsCheckProperty = true;
bool bolIsExist = clsSenateGaugeVersionBL.IsExistRecord(strCondition);
if (bolIsExist)
{
strMsg = "(senateGaugeVersionName)不能重复!";
throw new Exception(strMsg);
}
//4、把数据实体层的数据存贮到数据库中
objSenateGaugeVersionEN.Update();
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
 /// <param name = "objSenateGaugeVersion">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool EditRecordEx(this clsSenateGaugeVersionEN objSenateGaugeVersion)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
clsSenateGaugeVersionEN objSenateGaugeVersionCond = new clsSenateGaugeVersionEN();
string strCondition = objSenateGaugeVersionCond
.SetsenateGaugeVersionName(objSenateGaugeVersion.senateGaugeVersionName, "=")
.GetCombineCondition();
objSenateGaugeVersion._IsCheckProperty = true;
bool bolIsExist = clsSenateGaugeVersionBL.IsExistRecord(strCondition);
if (bolIsExist)
{
objSenateGaugeVersion.IdSenateGaugeVersion = clsSenateGaugeVersionBL.GetFirstID_S(strCondition);
objSenateGaugeVersion.UpdateWithCondition(strCondition);
}
else
{
objSenateGaugeVersion.IdSenateGaugeVersion = clsSenateGaugeVersionBL.GetMaxStrId_S();
objSenateGaugeVersion.AddNewRecord();
}
return true; 
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_Update)
 /// </summary>
 /// <param name = "objSenateGaugeVersionEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsSenateGaugeVersionEN objSenateGaugeVersionEN)
{
 if (string.IsNullOrEmpty(objSenateGaugeVersionEN.IdSenateGaugeVersion) == true)
 {
string strMsg = string.Format("(errid:Busi000095)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsSenateGaugeVersionBL.SenateGaugeVersionDA.UpdateBySql2(objSenateGaugeVersionEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsSenateGaugeVersionBL.ReFreshCache();

if (clsSenateGaugeVersionBL.relatedActions != null)
{
clsSenateGaugeVersionBL.relatedActions.UpdRelaTabDate(objSenateGaugeVersionEN.IdSenateGaugeVersion, objSenateGaugeVersionEN.UpdUserId);
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
 /// <param name = "objSenateGaugeVersionEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsSenateGaugeVersionEN objSenateGaugeVersionEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (string.IsNullOrEmpty(objSenateGaugeVersionEN.IdSenateGaugeVersion) == true)
 {
string strMsg = string.Format("(errid:Busi000087)修改记录时关键字不能为空!(带事务处理)(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsSenateGaugeVersionBL.SenateGaugeVersionDA.UpdateBySql2(objSenateGaugeVersionEN, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsSenateGaugeVersionBL.ReFreshCache();

if (clsSenateGaugeVersionBL.relatedActions != null)
{
clsSenateGaugeVersionBL.relatedActions.UpdRelaTabDate(objSenateGaugeVersionEN.IdSenateGaugeVersion, objSenateGaugeVersionEN.UpdUserId);
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
 /// <param name = "objSenateGaugeVersionEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsSenateGaugeVersionEN objSenateGaugeVersionEN, string strWhereCond)
{
try
{
bool bolResult = clsSenateGaugeVersionBL.SenateGaugeVersionDA.UpdateBySqlWithCondition(objSenateGaugeVersionEN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsSenateGaugeVersionBL.ReFreshCache();

if (clsSenateGaugeVersionBL.relatedActions != null)
{
clsSenateGaugeVersionBL.relatedActions.UpdRelaTabDate(objSenateGaugeVersionEN.IdSenateGaugeVersion, objSenateGaugeVersionEN.UpdUserId);
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
 /// <param name = "objSenateGaugeVersionEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsSenateGaugeVersionEN objSenateGaugeVersionEN, string strWhereCond, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
bool bolResult = clsSenateGaugeVersionBL.SenateGaugeVersionDA.UpdateBySqlWithConditionTransaction(objSenateGaugeVersionEN, strWhereCond, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsSenateGaugeVersionBL.ReFreshCache();

if (clsSenateGaugeVersionBL.relatedActions != null)
{
clsSenateGaugeVersionBL.relatedActions.UpdRelaTabDate(objSenateGaugeVersionEN.IdSenateGaugeVersion, objSenateGaugeVersionEN.UpdUserId);
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
 /// <param name = "strIdSenateGaugeVersion">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int Delete(this clsSenateGaugeVersionEN objSenateGaugeVersionEN)
{
try
{
int intRecNum = clsSenateGaugeVersionBL.SenateGaugeVersionDA.DelRecord(objSenateGaugeVersionEN.IdSenateGaugeVersion);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsSenateGaugeVersionBL.ReFreshCache();

if (clsSenateGaugeVersionBL.relatedActions != null)
{
clsSenateGaugeVersionBL.relatedActions.UpdRelaTabDate(objSenateGaugeVersionEN.IdSenateGaugeVersion, objSenateGaugeVersionEN.UpdUserId);
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
 /// <param name = "objSenateGaugeVersionENS">源对象</param>
 /// <param name = "objSenateGaugeVersionENT">目标对象</param>
 public static void CopyTo(this clsSenateGaugeVersionEN objSenateGaugeVersionENS, clsSenateGaugeVersionEN objSenateGaugeVersionENT)
{
try
{
objSenateGaugeVersionENT.IdSenateGaugeVersion = objSenateGaugeVersionENS.IdSenateGaugeVersion; //评价量表版本流水号
objSenateGaugeVersionENT.senateGaugeVersionID = objSenateGaugeVersionENS.senateGaugeVersionID; //评价量表版本ID
objSenateGaugeVersionENT.senateGaugeVersionName = objSenateGaugeVersionENS.senateGaugeVersionName; //评价量表版本名称
objSenateGaugeVersionENT.senateGaugeVersionTtlScore = objSenateGaugeVersionENS.senateGaugeVersionTtlScore; //评价量表版本总分
objSenateGaugeVersionENT.IsUse = objSenateGaugeVersionENS.IsUse; //是否使用
objSenateGaugeVersionENT.VersionNo = objSenateGaugeVersionENS.VersionNo; //版本号
objSenateGaugeVersionENT.IdSkillType = objSenateGaugeVersionENS.IdSkillType; //技能类型流水号
objSenateGaugeVersionENT.UserTypeId = objSenateGaugeVersionENS.UserTypeId; //用户类型Id
objSenateGaugeVersionENT.UpdDate = objSenateGaugeVersionENS.UpdDate; //修改日期
objSenateGaugeVersionENT.UpdUserId = objSenateGaugeVersionENS.UpdUserId; //修改用户Id
objSenateGaugeVersionENT.senateGaugeVersionMemo = objSenateGaugeVersionENS.senateGaugeVersionMemo; //评价量表版本说明
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
 /// <param name = "objSenateGaugeVersionENS">源对象</param>
 /// <returns>目标对象=>clsSenateGaugeVersionEN:objSenateGaugeVersionENT</returns>
 public static clsSenateGaugeVersionEN CopyTo(this clsSenateGaugeVersionEN objSenateGaugeVersionENS)
{
try
{
 clsSenateGaugeVersionEN objSenateGaugeVersionENT = new clsSenateGaugeVersionEN()
{
IdSenateGaugeVersion = objSenateGaugeVersionENS.IdSenateGaugeVersion, //评价量表版本流水号
senateGaugeVersionID = objSenateGaugeVersionENS.senateGaugeVersionID, //评价量表版本ID
senateGaugeVersionName = objSenateGaugeVersionENS.senateGaugeVersionName, //评价量表版本名称
senateGaugeVersionTtlScore = objSenateGaugeVersionENS.senateGaugeVersionTtlScore, //评价量表版本总分
IsUse = objSenateGaugeVersionENS.IsUse, //是否使用
VersionNo = objSenateGaugeVersionENS.VersionNo, //版本号
IdSkillType = objSenateGaugeVersionENS.IdSkillType, //技能类型流水号
UserTypeId = objSenateGaugeVersionENS.UserTypeId, //用户类型Id
UpdDate = objSenateGaugeVersionENS.UpdDate, //修改日期
UpdUserId = objSenateGaugeVersionENS.UpdUserId, //修改用户Id
senateGaugeVersionMemo = objSenateGaugeVersionENS.senateGaugeVersionMemo, //评价量表版本说明
};
 return objSenateGaugeVersionENT;
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
public static void CheckPropertyNew(this clsSenateGaugeVersionEN objSenateGaugeVersionEN)
{
 clsSenateGaugeVersionBL.SenateGaugeVersionDA.CheckPropertyNew(objSenateGaugeVersionEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(this clsSenateGaugeVersionEN objSenateGaugeVersionEN)
{
 clsSenateGaugeVersionBL.SenateGaugeVersionDA.CheckProperty4Condition(objSenateGaugeVersionEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsSenateGaugeVersionEN objSenateGaugeVersionCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objSenateGaugeVersionCond.IsUpdated(conSenateGaugeVersion.IdSenateGaugeVersion) == true)
{
string strComparisonOpIdSenateGaugeVersion = objSenateGaugeVersionCond.dicFldComparisonOp[conSenateGaugeVersion.IdSenateGaugeVersion];
strWhereCond += string.Format(" And {0} {2} '{1}'", conSenateGaugeVersion.IdSenateGaugeVersion, objSenateGaugeVersionCond.IdSenateGaugeVersion, strComparisonOpIdSenateGaugeVersion);
}
if (objSenateGaugeVersionCond.IsUpdated(conSenateGaugeVersion.senateGaugeVersionID) == true)
{
string strComparisonOpsenateGaugeVersionID = objSenateGaugeVersionCond.dicFldComparisonOp[conSenateGaugeVersion.senateGaugeVersionID];
strWhereCond += string.Format(" And {0} {2} '{1}'", conSenateGaugeVersion.senateGaugeVersionID, objSenateGaugeVersionCond.senateGaugeVersionID, strComparisonOpsenateGaugeVersionID);
}
if (objSenateGaugeVersionCond.IsUpdated(conSenateGaugeVersion.senateGaugeVersionName) == true)
{
string strComparisonOpsenateGaugeVersionName = objSenateGaugeVersionCond.dicFldComparisonOp[conSenateGaugeVersion.senateGaugeVersionName];
strWhereCond += string.Format(" And {0} {2} '{1}'", conSenateGaugeVersion.senateGaugeVersionName, objSenateGaugeVersionCond.senateGaugeVersionName, strComparisonOpsenateGaugeVersionName);
}
if (objSenateGaugeVersionCond.IsUpdated(conSenateGaugeVersion.senateGaugeVersionTtlScore) == true)
{
string strComparisonOpsenateGaugeVersionTtlScore = objSenateGaugeVersionCond.dicFldComparisonOp[conSenateGaugeVersion.senateGaugeVersionTtlScore];
strWhereCond += string.Format(" And {0} {2} {1}", conSenateGaugeVersion.senateGaugeVersionTtlScore, objSenateGaugeVersionCond.senateGaugeVersionTtlScore, strComparisonOpsenateGaugeVersionTtlScore);
}
if (objSenateGaugeVersionCond.IsUpdated(conSenateGaugeVersion.IsUse) == true)
{
if (objSenateGaugeVersionCond.IsUse == true)
{
strWhereCond += string.Format(" And {0} = '1'", conSenateGaugeVersion.IsUse);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conSenateGaugeVersion.IsUse);
}
}
if (objSenateGaugeVersionCond.IsUpdated(conSenateGaugeVersion.VersionNo) == true)
{
string strComparisonOpVersionNo = objSenateGaugeVersionCond.dicFldComparisonOp[conSenateGaugeVersion.VersionNo];
strWhereCond += string.Format(" And {0} {2} {1}", conSenateGaugeVersion.VersionNo, objSenateGaugeVersionCond.VersionNo, strComparisonOpVersionNo);
}
if (objSenateGaugeVersionCond.IsUpdated(conSenateGaugeVersion.IdSkillType) == true)
{
string strComparisonOpIdSkillType = objSenateGaugeVersionCond.dicFldComparisonOp[conSenateGaugeVersion.IdSkillType];
strWhereCond += string.Format(" And {0} {2} '{1}'", conSenateGaugeVersion.IdSkillType, objSenateGaugeVersionCond.IdSkillType, strComparisonOpIdSkillType);
}
if (objSenateGaugeVersionCond.IsUpdated(conSenateGaugeVersion.UserTypeId) == true)
{
string strComparisonOpUserTypeId = objSenateGaugeVersionCond.dicFldComparisonOp[conSenateGaugeVersion.UserTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conSenateGaugeVersion.UserTypeId, objSenateGaugeVersionCond.UserTypeId, strComparisonOpUserTypeId);
}
if (objSenateGaugeVersionCond.IsUpdated(conSenateGaugeVersion.UpdDate) == true)
{
string strComparisonOpUpdDate = objSenateGaugeVersionCond.dicFldComparisonOp[conSenateGaugeVersion.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conSenateGaugeVersion.UpdDate, objSenateGaugeVersionCond.UpdDate, strComparisonOpUpdDate);
}
if (objSenateGaugeVersionCond.IsUpdated(conSenateGaugeVersion.UpdUserId) == true)
{
string strComparisonOpUpdUserId = objSenateGaugeVersionCond.dicFldComparisonOp[conSenateGaugeVersion.UpdUserId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conSenateGaugeVersion.UpdUserId, objSenateGaugeVersionCond.UpdUserId, strComparisonOpUpdUserId);
}
if (objSenateGaugeVersionCond.IsUpdated(conSenateGaugeVersion.senateGaugeVersionMemo) == true)
{
string strComparisonOpsenateGaugeVersionMemo = objSenateGaugeVersionCond.dicFldComparisonOp[conSenateGaugeVersion.senateGaugeVersionMemo];
strWhereCond += string.Format(" And {0} {2} '{1}'", conSenateGaugeVersion.senateGaugeVersionMemo, objSenateGaugeVersionCond.senateGaugeVersionMemo, strComparisonOpsenateGaugeVersionMemo);
}
 return strWhereCond;
}

 /// <summary>
 /// 检查唯一性(Uniqueness)--SenateGaugeVersion(评价量规版本), 如果不唯一,即存在相同的记录,就返回False
 /// 唯一性条件:senateGaugeVersionName
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckConstraint)
 /// </summary>
 /// <param name = "objSenateGaugeVersionEN">要求唯一的对象</param>
 /// <returns></returns>
public static bool CheckUniqueness(this clsSenateGaugeVersionEN objSenateGaugeVersionEN)
{
//检测记录是否存在
bool bolIsUniqueness;
StringBuilder sbCondition = new StringBuilder();
if (objSenateGaugeVersionEN == null) return true;
if (objSenateGaugeVersionEN.IdSenateGaugeVersion == null || objSenateGaugeVersionEN.IdSenateGaugeVersion == "")
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and senateGaugeVersionName = '{0}'", objSenateGaugeVersionEN.senateGaugeVersionName);
if (clsSenateGaugeVersionBL.IsExistRecord(sbCondition.ToString())  ==  true)
{
 bolIsUniqueness = false;
}
else
{
 bolIsUniqueness = true;
}
}
 else {
sbCondition.AppendFormat("IdSenateGaugeVersion !=  '{0}'", objSenateGaugeVersionEN.IdSenateGaugeVersion);
 sbCondition.AppendFormat(" and senateGaugeVersionName = '{0}'", objSenateGaugeVersionEN.senateGaugeVersionName);
if (clsSenateGaugeVersionBL.IsExistRecord(sbCondition.ToString())  ==  true)
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
 /// 获取唯一性条件串--SenateGaugeVersion(评价量规版本), 即由对象中唯一性条件字段关键字与值组成的条件串
 /// 唯一性条件:senateGaugeVersionName
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetConditionString4Constraint)
 /// </summary>
 /// <param name = "objSenateGaugeVersionEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(this clsSenateGaugeVersionEN objSenateGaugeVersionEN)
{
//检测记录是否存在
StringBuilder sbCondition = new StringBuilder();
if (objSenateGaugeVersionEN == null) return "";
if (objSenateGaugeVersionEN.IdSenateGaugeVersion == null || objSenateGaugeVersionEN.IdSenateGaugeVersion == "")
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and senateGaugeVersionName = '{0}'", objSenateGaugeVersionEN.senateGaugeVersionName);
return sbCondition.ToString();
}
 else {
sbCondition.AppendFormat("IdSenateGaugeVersion !=  '{0}'", objSenateGaugeVersionEN.IdSenateGaugeVersion);
 sbCondition.AppendFormat(" and senateGaugeVersionName = '{0}'", objSenateGaugeVersionEN.senateGaugeVersionName);
 return sbCondition.ToString();
}
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_SenateGaugeVersion
{
public virtual bool UpdRelaTabDate(string strIdSenateGaugeVersion, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// 评价量规版本(SenateGaugeVersion)
 /// 数据源类型:表
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsSenateGaugeVersionBL
{
public static RelatedActions_SenateGaugeVersion relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsSenateGaugeVersionDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsSenateGaugeVersionDA SenateGaugeVersionDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsSenateGaugeVersionDA();
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
 public clsSenateGaugeVersionBL()
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
if (string.IsNullOrEmpty(clsSenateGaugeVersionEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsSenateGaugeVersionEN._ConnectString);
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
public static DataTable GetDataTable_SenateGaugeVersion(string strWhereCond)
{
DataTable objDT;
try
{
objDT = SenateGaugeVersionDA.GetDataTable_SenateGaugeVersion(strWhereCond);
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
objDT = SenateGaugeVersionDA.GetDataTable(strWhereCond);
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
objDT = SenateGaugeVersionDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = SenateGaugeVersionDA.GetDataTable(strWhereCond, strTabName);
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
objDT = SenateGaugeVersionDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = SenateGaugeVersionDA.GetDataTable_Top(objTopPara);
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
objDT = SenateGaugeVersionDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = SenateGaugeVersionDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = SenateGaugeVersionDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
 /// <param name = "arrIdSenateGaugeVersionLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static List<clsSenateGaugeVersionEN> GetObjLstByIdSenateGaugeVersionLst(List<string> arrIdSenateGaugeVersionLst)
{
List<clsSenateGaugeVersionEN> arrObjLst = new List<clsSenateGaugeVersionEN>(); 
System.Data.DataTable objDT; 
 string strSqlConditionStr = clsArray.GetSqlInStrByArray(arrIdSenateGaugeVersionLst, true);
 string strWhereCond = string.Format("IdSenateGaugeVersion in ({0})", strSqlConditionStr);
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsSenateGaugeVersionEN objSenateGaugeVersionEN = new clsSenateGaugeVersionEN();
try
{
objSenateGaugeVersionEN.IdSenateGaugeVersion = objRow[conSenateGaugeVersion.IdSenateGaugeVersion].ToString().Trim(); //评价量表版本流水号
objSenateGaugeVersionEN.senateGaugeVersionID = objRow[conSenateGaugeVersion.senateGaugeVersionID].ToString().Trim(); //评价量表版本ID
objSenateGaugeVersionEN.senateGaugeVersionName = objRow[conSenateGaugeVersion.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称
objSenateGaugeVersionEN.senateGaugeVersionTtlScore = Single.Parse(objRow[conSenateGaugeVersion.senateGaugeVersionTtlScore].ToString().Trim()); //评价量表版本总分
objSenateGaugeVersionEN.IsUse = clsEntityBase2.TransNullToBool_S(objRow[conSenateGaugeVersion.IsUse].ToString().Trim()); //是否使用
objSenateGaugeVersionEN.VersionNo = objRow[conSenateGaugeVersion.VersionNo] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conSenateGaugeVersion.VersionNo].ToString().Trim()); //版本号
objSenateGaugeVersionEN.IdSkillType = objRow[conSenateGaugeVersion.IdSkillType].ToString().Trim(); //技能类型流水号
objSenateGaugeVersionEN.UserTypeId = objRow[conSenateGaugeVersion.UserTypeId].ToString().Trim(); //用户类型Id
objSenateGaugeVersionEN.UpdDate = objRow[conSenateGaugeVersion.UpdDate] == DBNull.Value ? null : objRow[conSenateGaugeVersion.UpdDate].ToString().Trim(); //修改日期
objSenateGaugeVersionEN.UpdUserId = objRow[conSenateGaugeVersion.UpdUserId] == DBNull.Value ? null : objRow[conSenateGaugeVersion.UpdUserId].ToString().Trim(); //修改用户Id
objSenateGaugeVersionEN.senateGaugeVersionMemo = objRow[conSenateGaugeVersion.senateGaugeVersionMemo] == DBNull.Value ? null : objRow[conSenateGaugeVersion.senateGaugeVersionMemo].ToString().Trim(); //评价量表版本说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objSenateGaugeVersionEN.IdSenateGaugeVersion, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objSenateGaugeVersionEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrIdSenateGaugeVersionLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsSenateGaugeVersionEN> GetObjLstByIdSenateGaugeVersionLstCache(List<string> arrIdSenateGaugeVersionLst)
{
string strKey = string.Format("{0}", clsSenateGaugeVersionEN._CurrTabName);
List<clsSenateGaugeVersionEN> arrSenateGaugeVersionObjLstCache = GetObjLstCache();
IEnumerable <clsSenateGaugeVersionEN> arrSenateGaugeVersionObjLst_Sel =
arrSenateGaugeVersionObjLstCache
.Where(x => arrIdSenateGaugeVersionLst.Contains(x.IdSenateGaugeVersion));
return arrSenateGaugeVersionObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsSenateGaugeVersionEN> GetObjLst(string strWhereCond)
{
List<clsSenateGaugeVersionEN> arrObjLst = new List<clsSenateGaugeVersionEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsSenateGaugeVersionEN objSenateGaugeVersionEN = new clsSenateGaugeVersionEN();
try
{
objSenateGaugeVersionEN.IdSenateGaugeVersion = objRow[conSenateGaugeVersion.IdSenateGaugeVersion].ToString().Trim(); //评价量表版本流水号
objSenateGaugeVersionEN.senateGaugeVersionID = objRow[conSenateGaugeVersion.senateGaugeVersionID].ToString().Trim(); //评价量表版本ID
objSenateGaugeVersionEN.senateGaugeVersionName = objRow[conSenateGaugeVersion.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称
objSenateGaugeVersionEN.senateGaugeVersionTtlScore = Single.Parse(objRow[conSenateGaugeVersion.senateGaugeVersionTtlScore].ToString().Trim()); //评价量表版本总分
objSenateGaugeVersionEN.IsUse = clsEntityBase2.TransNullToBool_S(objRow[conSenateGaugeVersion.IsUse].ToString().Trim()); //是否使用
objSenateGaugeVersionEN.VersionNo = objRow[conSenateGaugeVersion.VersionNo] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conSenateGaugeVersion.VersionNo].ToString().Trim()); //版本号
objSenateGaugeVersionEN.IdSkillType = objRow[conSenateGaugeVersion.IdSkillType].ToString().Trim(); //技能类型流水号
objSenateGaugeVersionEN.UserTypeId = objRow[conSenateGaugeVersion.UserTypeId].ToString().Trim(); //用户类型Id
objSenateGaugeVersionEN.UpdDate = objRow[conSenateGaugeVersion.UpdDate] == DBNull.Value ? null : objRow[conSenateGaugeVersion.UpdDate].ToString().Trim(); //修改日期
objSenateGaugeVersionEN.UpdUserId = objRow[conSenateGaugeVersion.UpdUserId] == DBNull.Value ? null : objRow[conSenateGaugeVersion.UpdUserId].ToString().Trim(); //修改用户Id
objSenateGaugeVersionEN.senateGaugeVersionMemo = objRow[conSenateGaugeVersion.senateGaugeVersionMemo] == DBNull.Value ? null : objRow[conSenateGaugeVersion.senateGaugeVersionMemo].ToString().Trim(); //评价量表版本说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objSenateGaugeVersionEN.IdSenateGaugeVersion, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objSenateGaugeVersionEN);
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
public static List<clsSenateGaugeVersionEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsSenateGaugeVersionEN> arrObjLst = new List<clsSenateGaugeVersionEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsSenateGaugeVersionEN objSenateGaugeVersionEN = new clsSenateGaugeVersionEN();
try
{
objSenateGaugeVersionEN.IdSenateGaugeVersion = objRow[conSenateGaugeVersion.IdSenateGaugeVersion].ToString().Trim(); //评价量表版本流水号
objSenateGaugeVersionEN.senateGaugeVersionID = objRow[conSenateGaugeVersion.senateGaugeVersionID].ToString().Trim(); //评价量表版本ID
objSenateGaugeVersionEN.senateGaugeVersionName = objRow[conSenateGaugeVersion.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称
objSenateGaugeVersionEN.senateGaugeVersionTtlScore = Single.Parse(objRow[conSenateGaugeVersion.senateGaugeVersionTtlScore].ToString().Trim()); //评价量表版本总分
objSenateGaugeVersionEN.IsUse = clsEntityBase2.TransNullToBool_S(objRow[conSenateGaugeVersion.IsUse].ToString().Trim()); //是否使用
objSenateGaugeVersionEN.VersionNo = objRow[conSenateGaugeVersion.VersionNo] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conSenateGaugeVersion.VersionNo].ToString().Trim()); //版本号
objSenateGaugeVersionEN.IdSkillType = objRow[conSenateGaugeVersion.IdSkillType].ToString().Trim(); //技能类型流水号
objSenateGaugeVersionEN.UserTypeId = objRow[conSenateGaugeVersion.UserTypeId].ToString().Trim(); //用户类型Id
objSenateGaugeVersionEN.UpdDate = objRow[conSenateGaugeVersion.UpdDate] == DBNull.Value ? null : objRow[conSenateGaugeVersion.UpdDate].ToString().Trim(); //修改日期
objSenateGaugeVersionEN.UpdUserId = objRow[conSenateGaugeVersion.UpdUserId] == DBNull.Value ? null : objRow[conSenateGaugeVersion.UpdUserId].ToString().Trim(); //修改用户Id
objSenateGaugeVersionEN.senateGaugeVersionMemo = objRow[conSenateGaugeVersion.senateGaugeVersionMemo] == DBNull.Value ? null : objRow[conSenateGaugeVersion.senateGaugeVersionMemo].ToString().Trim(); //评价量表版本说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objSenateGaugeVersionEN.IdSenateGaugeVersion, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objSenateGaugeVersionEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objSenateGaugeVersionCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsSenateGaugeVersionEN> GetSubObjLstCache(clsSenateGaugeVersionEN objSenateGaugeVersionCond)
{
List<clsSenateGaugeVersionEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsSenateGaugeVersionEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conSenateGaugeVersion.AttributeName)
{
if (objSenateGaugeVersionCond.IsUpdated(strFldName) == false) continue;
if (objSenateGaugeVersionCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objSenateGaugeVersionCond[strFldName].ToString());
}
else
{
if (objSenateGaugeVersionCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objSenateGaugeVersionCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objSenateGaugeVersionCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objSenateGaugeVersionCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objSenateGaugeVersionCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objSenateGaugeVersionCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objSenateGaugeVersionCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objSenateGaugeVersionCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objSenateGaugeVersionCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objSenateGaugeVersionCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objSenateGaugeVersionCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objSenateGaugeVersionCond[strFldName]));
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
public static List<clsSenateGaugeVersionEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsSenateGaugeVersionEN> arrObjLst = new List<clsSenateGaugeVersionEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsSenateGaugeVersionEN objSenateGaugeVersionEN = new clsSenateGaugeVersionEN();
try
{
objSenateGaugeVersionEN.IdSenateGaugeVersion = objRow[conSenateGaugeVersion.IdSenateGaugeVersion].ToString().Trim(); //评价量表版本流水号
objSenateGaugeVersionEN.senateGaugeVersionID = objRow[conSenateGaugeVersion.senateGaugeVersionID].ToString().Trim(); //评价量表版本ID
objSenateGaugeVersionEN.senateGaugeVersionName = objRow[conSenateGaugeVersion.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称
objSenateGaugeVersionEN.senateGaugeVersionTtlScore = Single.Parse(objRow[conSenateGaugeVersion.senateGaugeVersionTtlScore].ToString().Trim()); //评价量表版本总分
objSenateGaugeVersionEN.IsUse = clsEntityBase2.TransNullToBool_S(objRow[conSenateGaugeVersion.IsUse].ToString().Trim()); //是否使用
objSenateGaugeVersionEN.VersionNo = objRow[conSenateGaugeVersion.VersionNo] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conSenateGaugeVersion.VersionNo].ToString().Trim()); //版本号
objSenateGaugeVersionEN.IdSkillType = objRow[conSenateGaugeVersion.IdSkillType].ToString().Trim(); //技能类型流水号
objSenateGaugeVersionEN.UserTypeId = objRow[conSenateGaugeVersion.UserTypeId].ToString().Trim(); //用户类型Id
objSenateGaugeVersionEN.UpdDate = objRow[conSenateGaugeVersion.UpdDate] == DBNull.Value ? null : objRow[conSenateGaugeVersion.UpdDate].ToString().Trim(); //修改日期
objSenateGaugeVersionEN.UpdUserId = objRow[conSenateGaugeVersion.UpdUserId] == DBNull.Value ? null : objRow[conSenateGaugeVersion.UpdUserId].ToString().Trim(); //修改用户Id
objSenateGaugeVersionEN.senateGaugeVersionMemo = objRow[conSenateGaugeVersion.senateGaugeVersionMemo] == DBNull.Value ? null : objRow[conSenateGaugeVersion.senateGaugeVersionMemo].ToString().Trim(); //评价量表版本说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objSenateGaugeVersionEN.IdSenateGaugeVersion, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objSenateGaugeVersionEN);
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
public static List<clsSenateGaugeVersionEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsSenateGaugeVersionEN> arrObjLst = new List<clsSenateGaugeVersionEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsSenateGaugeVersionEN objSenateGaugeVersionEN = new clsSenateGaugeVersionEN();
try
{
objSenateGaugeVersionEN.IdSenateGaugeVersion = objRow[conSenateGaugeVersion.IdSenateGaugeVersion].ToString().Trim(); //评价量表版本流水号
objSenateGaugeVersionEN.senateGaugeVersionID = objRow[conSenateGaugeVersion.senateGaugeVersionID].ToString().Trim(); //评价量表版本ID
objSenateGaugeVersionEN.senateGaugeVersionName = objRow[conSenateGaugeVersion.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称
objSenateGaugeVersionEN.senateGaugeVersionTtlScore = Single.Parse(objRow[conSenateGaugeVersion.senateGaugeVersionTtlScore].ToString().Trim()); //评价量表版本总分
objSenateGaugeVersionEN.IsUse = clsEntityBase2.TransNullToBool_S(objRow[conSenateGaugeVersion.IsUse].ToString().Trim()); //是否使用
objSenateGaugeVersionEN.VersionNo = objRow[conSenateGaugeVersion.VersionNo] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conSenateGaugeVersion.VersionNo].ToString().Trim()); //版本号
objSenateGaugeVersionEN.IdSkillType = objRow[conSenateGaugeVersion.IdSkillType].ToString().Trim(); //技能类型流水号
objSenateGaugeVersionEN.UserTypeId = objRow[conSenateGaugeVersion.UserTypeId].ToString().Trim(); //用户类型Id
objSenateGaugeVersionEN.UpdDate = objRow[conSenateGaugeVersion.UpdDate] == DBNull.Value ? null : objRow[conSenateGaugeVersion.UpdDate].ToString().Trim(); //修改日期
objSenateGaugeVersionEN.UpdUserId = objRow[conSenateGaugeVersion.UpdUserId] == DBNull.Value ? null : objRow[conSenateGaugeVersion.UpdUserId].ToString().Trim(); //修改用户Id
objSenateGaugeVersionEN.senateGaugeVersionMemo = objRow[conSenateGaugeVersion.senateGaugeVersionMemo] == DBNull.Value ? null : objRow[conSenateGaugeVersion.senateGaugeVersionMemo].ToString().Trim(); //评价量表版本说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objSenateGaugeVersionEN.IdSenateGaugeVersion, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objSenateGaugeVersionEN);
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
List<clsSenateGaugeVersionEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsSenateGaugeVersionEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsSenateGaugeVersionEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsSenateGaugeVersionEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsSenateGaugeVersionEN> arrObjLst = new List<clsSenateGaugeVersionEN>(); 
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
	clsSenateGaugeVersionEN objSenateGaugeVersionEN = new clsSenateGaugeVersionEN();
try
{
objSenateGaugeVersionEN.IdSenateGaugeVersion = objRow[conSenateGaugeVersion.IdSenateGaugeVersion].ToString().Trim(); //评价量表版本流水号
objSenateGaugeVersionEN.senateGaugeVersionID = objRow[conSenateGaugeVersion.senateGaugeVersionID].ToString().Trim(); //评价量表版本ID
objSenateGaugeVersionEN.senateGaugeVersionName = objRow[conSenateGaugeVersion.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称
objSenateGaugeVersionEN.senateGaugeVersionTtlScore = Single.Parse(objRow[conSenateGaugeVersion.senateGaugeVersionTtlScore].ToString().Trim()); //评价量表版本总分
objSenateGaugeVersionEN.IsUse = clsEntityBase2.TransNullToBool_S(objRow[conSenateGaugeVersion.IsUse].ToString().Trim()); //是否使用
objSenateGaugeVersionEN.VersionNo = objRow[conSenateGaugeVersion.VersionNo] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conSenateGaugeVersion.VersionNo].ToString().Trim()); //版本号
objSenateGaugeVersionEN.IdSkillType = objRow[conSenateGaugeVersion.IdSkillType].ToString().Trim(); //技能类型流水号
objSenateGaugeVersionEN.UserTypeId = objRow[conSenateGaugeVersion.UserTypeId].ToString().Trim(); //用户类型Id
objSenateGaugeVersionEN.UpdDate = objRow[conSenateGaugeVersion.UpdDate] == DBNull.Value ? null : objRow[conSenateGaugeVersion.UpdDate].ToString().Trim(); //修改日期
objSenateGaugeVersionEN.UpdUserId = objRow[conSenateGaugeVersion.UpdUserId] == DBNull.Value ? null : objRow[conSenateGaugeVersion.UpdUserId].ToString().Trim(); //修改用户Id
objSenateGaugeVersionEN.senateGaugeVersionMemo = objRow[conSenateGaugeVersion.senateGaugeVersionMemo] == DBNull.Value ? null : objRow[conSenateGaugeVersion.senateGaugeVersionMemo].ToString().Trim(); //评价量表版本说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objSenateGaugeVersionEN.IdSenateGaugeVersion, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objSenateGaugeVersionEN);
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
public static List<clsSenateGaugeVersionEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsSenateGaugeVersionEN> arrObjLst = new List<clsSenateGaugeVersionEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsSenateGaugeVersionEN objSenateGaugeVersionEN = new clsSenateGaugeVersionEN();
try
{
objSenateGaugeVersionEN.IdSenateGaugeVersion = objRow[conSenateGaugeVersion.IdSenateGaugeVersion].ToString().Trim(); //评价量表版本流水号
objSenateGaugeVersionEN.senateGaugeVersionID = objRow[conSenateGaugeVersion.senateGaugeVersionID].ToString().Trim(); //评价量表版本ID
objSenateGaugeVersionEN.senateGaugeVersionName = objRow[conSenateGaugeVersion.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称
objSenateGaugeVersionEN.senateGaugeVersionTtlScore = Single.Parse(objRow[conSenateGaugeVersion.senateGaugeVersionTtlScore].ToString().Trim()); //评价量表版本总分
objSenateGaugeVersionEN.IsUse = clsEntityBase2.TransNullToBool_S(objRow[conSenateGaugeVersion.IsUse].ToString().Trim()); //是否使用
objSenateGaugeVersionEN.VersionNo = objRow[conSenateGaugeVersion.VersionNo] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conSenateGaugeVersion.VersionNo].ToString().Trim()); //版本号
objSenateGaugeVersionEN.IdSkillType = objRow[conSenateGaugeVersion.IdSkillType].ToString().Trim(); //技能类型流水号
objSenateGaugeVersionEN.UserTypeId = objRow[conSenateGaugeVersion.UserTypeId].ToString().Trim(); //用户类型Id
objSenateGaugeVersionEN.UpdDate = objRow[conSenateGaugeVersion.UpdDate] == DBNull.Value ? null : objRow[conSenateGaugeVersion.UpdDate].ToString().Trim(); //修改日期
objSenateGaugeVersionEN.UpdUserId = objRow[conSenateGaugeVersion.UpdUserId] == DBNull.Value ? null : objRow[conSenateGaugeVersion.UpdUserId].ToString().Trim(); //修改用户Id
objSenateGaugeVersionEN.senateGaugeVersionMemo = objRow[conSenateGaugeVersion.senateGaugeVersionMemo] == DBNull.Value ? null : objRow[conSenateGaugeVersion.senateGaugeVersionMemo].ToString().Trim(); //评价量表版本说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objSenateGaugeVersionEN.IdSenateGaugeVersion, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objSenateGaugeVersionEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsSenateGaugeVersionEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsSenateGaugeVersionEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsSenateGaugeVersionEN> arrObjLst = new List<clsSenateGaugeVersionEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsSenateGaugeVersionEN objSenateGaugeVersionEN = new clsSenateGaugeVersionEN();
try
{
objSenateGaugeVersionEN.IdSenateGaugeVersion = objRow[conSenateGaugeVersion.IdSenateGaugeVersion].ToString().Trim(); //评价量表版本流水号
objSenateGaugeVersionEN.senateGaugeVersionID = objRow[conSenateGaugeVersion.senateGaugeVersionID].ToString().Trim(); //评价量表版本ID
objSenateGaugeVersionEN.senateGaugeVersionName = objRow[conSenateGaugeVersion.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称
objSenateGaugeVersionEN.senateGaugeVersionTtlScore = Single.Parse(objRow[conSenateGaugeVersion.senateGaugeVersionTtlScore].ToString().Trim()); //评价量表版本总分
objSenateGaugeVersionEN.IsUse = clsEntityBase2.TransNullToBool_S(objRow[conSenateGaugeVersion.IsUse].ToString().Trim()); //是否使用
objSenateGaugeVersionEN.VersionNo = objRow[conSenateGaugeVersion.VersionNo] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conSenateGaugeVersion.VersionNo].ToString().Trim()); //版本号
objSenateGaugeVersionEN.IdSkillType = objRow[conSenateGaugeVersion.IdSkillType].ToString().Trim(); //技能类型流水号
objSenateGaugeVersionEN.UserTypeId = objRow[conSenateGaugeVersion.UserTypeId].ToString().Trim(); //用户类型Id
objSenateGaugeVersionEN.UpdDate = objRow[conSenateGaugeVersion.UpdDate] == DBNull.Value ? null : objRow[conSenateGaugeVersion.UpdDate].ToString().Trim(); //修改日期
objSenateGaugeVersionEN.UpdUserId = objRow[conSenateGaugeVersion.UpdUserId] == DBNull.Value ? null : objRow[conSenateGaugeVersion.UpdUserId].ToString().Trim(); //修改用户Id
objSenateGaugeVersionEN.senateGaugeVersionMemo = objRow[conSenateGaugeVersion.senateGaugeVersionMemo] == DBNull.Value ? null : objRow[conSenateGaugeVersion.senateGaugeVersionMemo].ToString().Trim(); //评价量表版本说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objSenateGaugeVersionEN.IdSenateGaugeVersion, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objSenateGaugeVersionEN);
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
public static List<clsSenateGaugeVersionEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsSenateGaugeVersionEN> arrObjLst = new List<clsSenateGaugeVersionEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsSenateGaugeVersionEN objSenateGaugeVersionEN = new clsSenateGaugeVersionEN();
try
{
objSenateGaugeVersionEN.IdSenateGaugeVersion = objRow[conSenateGaugeVersion.IdSenateGaugeVersion].ToString().Trim(); //评价量表版本流水号
objSenateGaugeVersionEN.senateGaugeVersionID = objRow[conSenateGaugeVersion.senateGaugeVersionID].ToString().Trim(); //评价量表版本ID
objSenateGaugeVersionEN.senateGaugeVersionName = objRow[conSenateGaugeVersion.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称
objSenateGaugeVersionEN.senateGaugeVersionTtlScore = Single.Parse(objRow[conSenateGaugeVersion.senateGaugeVersionTtlScore].ToString().Trim()); //评价量表版本总分
objSenateGaugeVersionEN.IsUse = clsEntityBase2.TransNullToBool_S(objRow[conSenateGaugeVersion.IsUse].ToString().Trim()); //是否使用
objSenateGaugeVersionEN.VersionNo = objRow[conSenateGaugeVersion.VersionNo] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conSenateGaugeVersion.VersionNo].ToString().Trim()); //版本号
objSenateGaugeVersionEN.IdSkillType = objRow[conSenateGaugeVersion.IdSkillType].ToString().Trim(); //技能类型流水号
objSenateGaugeVersionEN.UserTypeId = objRow[conSenateGaugeVersion.UserTypeId].ToString().Trim(); //用户类型Id
objSenateGaugeVersionEN.UpdDate = objRow[conSenateGaugeVersion.UpdDate] == DBNull.Value ? null : objRow[conSenateGaugeVersion.UpdDate].ToString().Trim(); //修改日期
objSenateGaugeVersionEN.UpdUserId = objRow[conSenateGaugeVersion.UpdUserId] == DBNull.Value ? null : objRow[conSenateGaugeVersion.UpdUserId].ToString().Trim(); //修改用户Id
objSenateGaugeVersionEN.senateGaugeVersionMemo = objRow[conSenateGaugeVersion.senateGaugeVersionMemo] == DBNull.Value ? null : objRow[conSenateGaugeVersion.senateGaugeVersionMemo].ToString().Trim(); //评价量表版本说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objSenateGaugeVersionEN.IdSenateGaugeVersion, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objSenateGaugeVersionEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsSenateGaugeVersionEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsSenateGaugeVersionEN> arrObjLst = new List<clsSenateGaugeVersionEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsSenateGaugeVersionEN objSenateGaugeVersionEN = new clsSenateGaugeVersionEN();
try
{
objSenateGaugeVersionEN.IdSenateGaugeVersion = objRow[conSenateGaugeVersion.IdSenateGaugeVersion].ToString().Trim(); //评价量表版本流水号
objSenateGaugeVersionEN.senateGaugeVersionID = objRow[conSenateGaugeVersion.senateGaugeVersionID].ToString().Trim(); //评价量表版本ID
objSenateGaugeVersionEN.senateGaugeVersionName = objRow[conSenateGaugeVersion.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称
objSenateGaugeVersionEN.senateGaugeVersionTtlScore = Single.Parse(objRow[conSenateGaugeVersion.senateGaugeVersionTtlScore].ToString().Trim()); //评价量表版本总分
objSenateGaugeVersionEN.IsUse = clsEntityBase2.TransNullToBool_S(objRow[conSenateGaugeVersion.IsUse].ToString().Trim()); //是否使用
objSenateGaugeVersionEN.VersionNo = objRow[conSenateGaugeVersion.VersionNo] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conSenateGaugeVersion.VersionNo].ToString().Trim()); //版本号
objSenateGaugeVersionEN.IdSkillType = objRow[conSenateGaugeVersion.IdSkillType].ToString().Trim(); //技能类型流水号
objSenateGaugeVersionEN.UserTypeId = objRow[conSenateGaugeVersion.UserTypeId].ToString().Trim(); //用户类型Id
objSenateGaugeVersionEN.UpdDate = objRow[conSenateGaugeVersion.UpdDate] == DBNull.Value ? null : objRow[conSenateGaugeVersion.UpdDate].ToString().Trim(); //修改日期
objSenateGaugeVersionEN.UpdUserId = objRow[conSenateGaugeVersion.UpdUserId] == DBNull.Value ? null : objRow[conSenateGaugeVersion.UpdUserId].ToString().Trim(); //修改用户Id
objSenateGaugeVersionEN.senateGaugeVersionMemo = objRow[conSenateGaugeVersion.senateGaugeVersionMemo] == DBNull.Value ? null : objRow[conSenateGaugeVersion.senateGaugeVersionMemo].ToString().Trim(); //评价量表版本说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objSenateGaugeVersionEN.IdSenateGaugeVersion, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objSenateGaugeVersionEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objSenateGaugeVersionEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetSenateGaugeVersion(ref clsSenateGaugeVersionEN objSenateGaugeVersionEN)
{
bool bolResult = SenateGaugeVersionDA.GetSenateGaugeVersion(ref objSenateGaugeVersionEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "strIdSenateGaugeVersion">表关键字</param>
 /// <returns>表对象</returns>
public static clsSenateGaugeVersionEN GetObjByIdSenateGaugeVersion(string strIdSenateGaugeVersion)
{
if (strIdSenateGaugeVersion.IndexOf(' ') >=0)
{
var strMsg = string.Format("(errid:Busi000079)在表中,关键字[strIdSenateGaugeVersion]中不能有空格!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
if (string.IsNullOrEmpty(strIdSenateGaugeVersion) == true)
{
var strMsg = string.Format("(errid:Busi000020)在表中,关键字[strIdSenateGaugeVersion]不能为空!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
clsSenateGaugeVersionEN objSenateGaugeVersionEN = SenateGaugeVersionDA.GetObjByIdSenateGaugeVersion(strIdSenateGaugeVersion);
return objSenateGaugeVersionEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsSenateGaugeVersionEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsSenateGaugeVersionEN objSenateGaugeVersionEN = SenateGaugeVersionDA.GetFirstObj(strWhereCond);
 return objSenateGaugeVersionEN;
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
public static clsSenateGaugeVersionEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsSenateGaugeVersionEN objSenateGaugeVersionEN = SenateGaugeVersionDA.GetObjByDataRow(objRow);
 return objSenateGaugeVersionEN;
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
public static clsSenateGaugeVersionEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsSenateGaugeVersionEN objSenateGaugeVersionEN = SenateGaugeVersionDA.GetObjByDataRow(objRow);
 return objSenateGaugeVersionEN;
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
 /// <param name = "strIdSenateGaugeVersion">所给的关键字</param>
 /// <param name = "lstSenateGaugeVersionObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsSenateGaugeVersionEN GetObjByIdSenateGaugeVersionFromList(string strIdSenateGaugeVersion, List<clsSenateGaugeVersionEN> lstSenateGaugeVersionObjLst)
{
foreach (clsSenateGaugeVersionEN objSenateGaugeVersionEN in lstSenateGaugeVersionObjLst)
{
if (objSenateGaugeVersionEN.IdSenateGaugeVersion == strIdSenateGaugeVersion)
{
return objSenateGaugeVersionEN;
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
 string strMaxIdSenateGaugeVersion;
 try
 {
 strMaxIdSenateGaugeVersion = clsSenateGaugeVersionDA.GetMaxStrId();
 return strMaxIdSenateGaugeVersion;
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
 string strIdSenateGaugeVersion;
 try
 {
 strIdSenateGaugeVersion = new clsSenateGaugeVersionDA().GetFirstID(strWhereCond);
 return strIdSenateGaugeVersion;
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
 arrList = SenateGaugeVersionDA.GetID(strWhereCond);
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
bool bolIsExist = SenateGaugeVersionDA.IsExistCondRec(strWhereCond);
return bolIsExist;
}

 /// <summary>
 /// 判断当前表中是否存在给定关键字值的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExist)
 /// </summary>
 /// <param name = "strIdSenateGaugeVersion">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public static bool IsExist(string strIdSenateGaugeVersion)
{
if (string.IsNullOrEmpty(strIdSenateGaugeVersion) == true)
{
var strMsg = string.Format("(errid:Busi000027)在表中,关键字[strIdSenateGaugeVersion]不能为空!!(from {0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
//检测记录是否存在
bool bolIsExist = SenateGaugeVersionDA.IsExist(strIdSenateGaugeVersion);
return bolIsExist;
}

/// <summary>
/// 设置修改时间
/// </summary>
/// <param name = "strIdSenateGaugeVersion">评价量表版本流水号</param>
/// <param name = "strOpUser">修改用户</param>
/// <returns>是否成功？</returns>
public static bool SetUpdDate(string strIdSenateGaugeVersion, string strOpUser)
{
clsSenateGaugeVersionEN objSenateGaugeVersionEN = clsSenateGaugeVersionBL.GetObjByIdSenateGaugeVersion(strIdSenateGaugeVersion);
objSenateGaugeVersionEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
objSenateGaugeVersionEN.UpdUserId = strOpUser;
return clsSenateGaugeVersionBL.UpdateBySql2(objSenateGaugeVersionEN);
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
 bolIsExist = clsSenateGaugeVersionDA.IsExistTable();
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
 bolIsExist = SenateGaugeVersionDA.IsExistTable(strTabName);
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
 /// <param name = "objSenateGaugeVersionEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecordBySql2(clsSenateGaugeVersionEN objSenateGaugeVersionEN, bool bolIsNeedCheckUniqueness=true)
{
if (bolIsNeedCheckUniqueness == true && objSenateGaugeVersionEN.CheckUniqueness() == false)
{
var strMsg = string.Format("记录已经存在!评价量表版本名称 = [{0}]的数据已经存在!(in clsSenateGaugeVersionBL.AddNewRecordBySql2)", objSenateGaugeVersionEN.senateGaugeVersionName);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objSenateGaugeVersionEN.IdSenateGaugeVersion) == true || clsSenateGaugeVersionBL.IsExist(objSenateGaugeVersionEN.IdSenateGaugeVersion) == true)
 {
     objSenateGaugeVersionEN.IdSenateGaugeVersion = clsSenateGaugeVersionBL.GetMaxStrId_S();
 }
bool bolResult = SenateGaugeVersionDA.AddNewRecordBySQL2(objSenateGaugeVersionEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsSenateGaugeVersionBL.ReFreshCache();

if (clsSenateGaugeVersionBL.relatedActions != null)
{
clsSenateGaugeVersionBL.relatedActions.UpdRelaTabDate(objSenateGaugeVersionEN.IdSenateGaugeVersion, objSenateGaugeVersionEN.UpdUserId);
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
 /// <param name = "objSenateGaugeVersionEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordBySql2WithReturnKey(clsSenateGaugeVersionEN objSenateGaugeVersionEN, bool bolIsNeedCheckUniqueness=true)
{
if (bolIsNeedCheckUniqueness == true && objSenateGaugeVersionEN.CheckUniqueness() == false)
{
var strMsg = string.Format("记录已经存在!评价量表版本名称 = [{0}]的数据已经存在!(in clsSenateGaugeVersionBL.AddNewRecordBySql2WithReturnKey)", objSenateGaugeVersionEN.senateGaugeVersionName);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objSenateGaugeVersionEN.IdSenateGaugeVersion) == true || clsSenateGaugeVersionBL.IsExist(objSenateGaugeVersionEN.IdSenateGaugeVersion) == true)
 {
     objSenateGaugeVersionEN.IdSenateGaugeVersion = clsSenateGaugeVersionBL.GetMaxStrId_S();
 }
string strKey = SenateGaugeVersionDA.AddNewRecordBySQL2WithReturnKey(objSenateGaugeVersionEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsSenateGaugeVersionBL.ReFreshCache();

if (clsSenateGaugeVersionBL.relatedActions != null)
{
clsSenateGaugeVersionBL.relatedActions.UpdRelaTabDate(objSenateGaugeVersionEN.IdSenateGaugeVersion, objSenateGaugeVersionEN.UpdUserId);
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
 /// <param name = "objSenateGaugeVersionEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(clsSenateGaugeVersionEN objSenateGaugeVersionEN)
{
try
{
bool bolResult = SenateGaugeVersionDA.Update(objSenateGaugeVersionEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsSenateGaugeVersionBL.ReFreshCache();

if (clsSenateGaugeVersionBL.relatedActions != null)
{
clsSenateGaugeVersionBL.relatedActions.UpdRelaTabDate(objSenateGaugeVersionEN.IdSenateGaugeVersion, objSenateGaugeVersionEN.UpdUserId);
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
 /// <param name = "objSenateGaugeVersionEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateBySql2(clsSenateGaugeVersionEN objSenateGaugeVersionEN)
{
 if (string.IsNullOrEmpty(objSenateGaugeVersionEN.IdSenateGaugeVersion) == true)
 {
var strMsg = string.Format("(errid:Busi000065)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = SenateGaugeVersionDA.UpdateBySql2(objSenateGaugeVersionEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsSenateGaugeVersionBL.ReFreshCache();

if (clsSenateGaugeVersionBL.relatedActions != null)
{
clsSenateGaugeVersionBL.relatedActions.UpdRelaTabDate(objSenateGaugeVersionEN.IdSenateGaugeVersion, objSenateGaugeVersionEN.UpdUserId);
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
 /// <param name = "strIdSenateGaugeVersion">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int DelRecord(string strIdSenateGaugeVersion)
{
try
{
 clsSenateGaugeVersionEN objSenateGaugeVersionEN = clsSenateGaugeVersionBL.GetObjByIdSenateGaugeVersion(strIdSenateGaugeVersion);

if (clsSenateGaugeVersionBL.relatedActions != null)
{
clsSenateGaugeVersionBL.relatedActions.UpdRelaTabDate(objSenateGaugeVersionEN.IdSenateGaugeVersion, objSenateGaugeVersionEN.UpdUserId);
}
if (objSenateGaugeVersionEN != null)
{
int intRecNum = SenateGaugeVersionDA.DelRecord(strIdSenateGaugeVersion);
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
/// <param name="strIdSenateGaugeVersion">表关键字</param>
/// <returns></returns>
public static bool DelRecordEx(string strIdSenateGaugeVersion )
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsSenateGaugeVersionDA.GetSpecSQLObj();
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
//删除与表:[SenateGaugeVersion]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conSenateGaugeVersion.IdSenateGaugeVersion,
//strIdSenateGaugeVersion);
//        clsSenateGaugeVersionBL.DelSenateGaugeVersionsByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsSenateGaugeVersionBL.DelRecord(strIdSenateGaugeVersion, objConnection, objSqlTransaction);
objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsSenateGaugeVersionBLEx", "DelRecordEx", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("扩展删除记录出错:{0}!keyId = {1}.({2})",
objException.Message,
strIdSenateGaugeVersion, clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "strIdSenateGaugeVersion">给定的关键字值</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回删除是否成功?</returns>
public static bool DelRecord(string strIdSenateGaugeVersion, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
if (clsSenateGaugeVersionBL.relatedActions != null)
{
clsSenateGaugeVersionBL.relatedActions.UpdRelaTabDate(strIdSenateGaugeVersion, "UpdRelaTabDate");
}
bool bolResult = SenateGaugeVersionDA.DelRecord(strIdSenateGaugeVersion,objSqlConnection,objSqlTransaction);
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
 /// <param name = "arrIdSenateGaugeVersionLst">给定的关键字值列表</param>
 /// <returns>返回删除的记录数</returns>
public static int DelSenateGaugeVersions(List<string> arrIdSenateGaugeVersionLst)
{
if (arrIdSenateGaugeVersionLst.Count == 0) return 0;
try
{
if (clsSenateGaugeVersionBL.relatedActions != null)
{
foreach (var strIdSenateGaugeVersion in arrIdSenateGaugeVersionLst)
{
clsSenateGaugeVersionBL.relatedActions.UpdRelaTabDate(strIdSenateGaugeVersion, "UpdRelaTabDate");
}
}
int intDelRecNum = SenateGaugeVersionDA.DelSenateGaugeVersion(arrIdSenateGaugeVersionLst);
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
public static int DelSenateGaugeVersionsByCond(string strWhereCond)
{
try
{
if (clsSenateGaugeVersionBL.relatedActions != null)
{
List<string> arrIdSenateGaugeVersion = GetPrimaryKeyID_S(strWhereCond);
foreach (var strIdSenateGaugeVersion in arrIdSenateGaugeVersion)
{
clsSenateGaugeVersionBL.relatedActions.UpdRelaTabDate(strIdSenateGaugeVersion, "UpdRelaTabDate");
}
}
int intRecNum = SenateGaugeVersionDA.DelSenateGaugeVersion(strWhereCond);
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
/// 这里仅仅是演示函数,使用时请复制到扩展类:[SenateGaugeVersion]中改名为:[DelRecord4MultiTabEx]使用
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DelRecord4MultiTab)
/// </summary>
/// <param name="strIdSenateGaugeVersion">表关键字</param>
/// <returns></returns>
public static bool DelRecord4MultiTab(string strIdSenateGaugeVersion)
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsSenateGaugeVersionDA.GetSpecSQLObj();
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
//删除与表:[SenateGaugeVersion]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conStudent.id_College,
//strid_College);
//        clsStudentBL.DelStudentsByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsSenateGaugeVersionBL.DelRecord(strIdSenateGaugeVersion, objConnection, objSqlTransaction);
                objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsSenateGaugeVersionBL", "DelRecord4MultiTab", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("删除多表记录出错:{0}!keyId = {1}.({2})",
objException.Message,
strIdSenateGaugeVersion, clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "objSenateGaugeVersionENS">源对象</param>
 /// <param name = "objSenateGaugeVersionENT">目标对象</param>
 public static void CopyTo(clsSenateGaugeVersionEN objSenateGaugeVersionENS, clsSenateGaugeVersionEN objSenateGaugeVersionENT)
{
try
{
objSenateGaugeVersionENT.IdSenateGaugeVersion = objSenateGaugeVersionENS.IdSenateGaugeVersion; //评价量表版本流水号
objSenateGaugeVersionENT.senateGaugeVersionID = objSenateGaugeVersionENS.senateGaugeVersionID; //评价量表版本ID
objSenateGaugeVersionENT.senateGaugeVersionName = objSenateGaugeVersionENS.senateGaugeVersionName; //评价量表版本名称
objSenateGaugeVersionENT.senateGaugeVersionTtlScore = objSenateGaugeVersionENS.senateGaugeVersionTtlScore; //评价量表版本总分
objSenateGaugeVersionENT.IsUse = objSenateGaugeVersionENS.IsUse; //是否使用
objSenateGaugeVersionENT.VersionNo = objSenateGaugeVersionENS.VersionNo; //版本号
objSenateGaugeVersionENT.IdSkillType = objSenateGaugeVersionENS.IdSkillType; //技能类型流水号
objSenateGaugeVersionENT.UserTypeId = objSenateGaugeVersionENS.UserTypeId; //用户类型Id
objSenateGaugeVersionENT.UpdDate = objSenateGaugeVersionENS.UpdDate; //修改日期
objSenateGaugeVersionENT.UpdUserId = objSenateGaugeVersionENS.UpdUserId; //修改用户Id
objSenateGaugeVersionENT.senateGaugeVersionMemo = objSenateGaugeVersionENS.senateGaugeVersionMemo; //评价量表版本说明
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
 /// <param name = "objSenateGaugeVersionEN">源简化对象</param>
 public static void SetUpdFlag(clsSenateGaugeVersionEN objSenateGaugeVersionEN)
{
try
{
objSenateGaugeVersionEN.ClearUpdateState();
   string strsfUpdFldSetStr = objSenateGaugeVersionEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(conSenateGaugeVersion.IdSenateGaugeVersion, new clsStrCompareIgnoreCase())  ==  true)
{
objSenateGaugeVersionEN.IdSenateGaugeVersion = objSenateGaugeVersionEN.IdSenateGaugeVersion; //评价量表版本流水号
}
if (arrFldSet.Contains(conSenateGaugeVersion.senateGaugeVersionID, new clsStrCompareIgnoreCase())  ==  true)
{
objSenateGaugeVersionEN.senateGaugeVersionID = objSenateGaugeVersionEN.senateGaugeVersionID; //评价量表版本ID
}
if (arrFldSet.Contains(conSenateGaugeVersion.senateGaugeVersionName, new clsStrCompareIgnoreCase())  ==  true)
{
objSenateGaugeVersionEN.senateGaugeVersionName = objSenateGaugeVersionEN.senateGaugeVersionName; //评价量表版本名称
}
if (arrFldSet.Contains(conSenateGaugeVersion.senateGaugeVersionTtlScore, new clsStrCompareIgnoreCase())  ==  true)
{
objSenateGaugeVersionEN.senateGaugeVersionTtlScore = objSenateGaugeVersionEN.senateGaugeVersionTtlScore; //评价量表版本总分
}
if (arrFldSet.Contains(conSenateGaugeVersion.IsUse, new clsStrCompareIgnoreCase())  ==  true)
{
objSenateGaugeVersionEN.IsUse = objSenateGaugeVersionEN.IsUse; //是否使用
}
if (arrFldSet.Contains(conSenateGaugeVersion.VersionNo, new clsStrCompareIgnoreCase())  ==  true)
{
objSenateGaugeVersionEN.VersionNo = objSenateGaugeVersionEN.VersionNo; //版本号
}
if (arrFldSet.Contains(conSenateGaugeVersion.IdSkillType, new clsStrCompareIgnoreCase())  ==  true)
{
objSenateGaugeVersionEN.IdSkillType = objSenateGaugeVersionEN.IdSkillType; //技能类型流水号
}
if (arrFldSet.Contains(conSenateGaugeVersion.UserTypeId, new clsStrCompareIgnoreCase())  ==  true)
{
objSenateGaugeVersionEN.UserTypeId = objSenateGaugeVersionEN.UserTypeId; //用户类型Id
}
if (arrFldSet.Contains(conSenateGaugeVersion.UpdDate, new clsStrCompareIgnoreCase())  ==  true)
{
objSenateGaugeVersionEN.UpdDate = objSenateGaugeVersionEN.UpdDate == "[null]" ? null :  objSenateGaugeVersionEN.UpdDate; //修改日期
}
if (arrFldSet.Contains(conSenateGaugeVersion.UpdUserId, new clsStrCompareIgnoreCase())  ==  true)
{
objSenateGaugeVersionEN.UpdUserId = objSenateGaugeVersionEN.UpdUserId == "[null]" ? null :  objSenateGaugeVersionEN.UpdUserId; //修改用户Id
}
if (arrFldSet.Contains(conSenateGaugeVersion.senateGaugeVersionMemo, new clsStrCompareIgnoreCase())  ==  true)
{
objSenateGaugeVersionEN.senateGaugeVersionMemo = objSenateGaugeVersionEN.senateGaugeVersionMemo == "[null]" ? null :  objSenateGaugeVersionEN.senateGaugeVersionMemo; //评价量表版本说明
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
 /// <param name = "objSenateGaugeVersionEN">源简化对象</param>
 public static void AccessFldValueNull(clsSenateGaugeVersionEN objSenateGaugeVersionEN)
{
try
{
if (objSenateGaugeVersionEN.UpdDate == "[null]") objSenateGaugeVersionEN.UpdDate = null; //修改日期
if (objSenateGaugeVersionEN.UpdUserId == "[null]") objSenateGaugeVersionEN.UpdUserId = null; //修改用户Id
if (objSenateGaugeVersionEN.senateGaugeVersionMemo == "[null]") objSenateGaugeVersionEN.senateGaugeVersionMemo = null; //评价量表版本说明
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
public static void CheckPropertyNew(clsSenateGaugeVersionEN objSenateGaugeVersionEN)
{
 SenateGaugeVersionDA.CheckPropertyNew(objSenateGaugeVersionEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(clsSenateGaugeVersionEN objSenateGaugeVersionEN)
{
 SenateGaugeVersionDA.CheckProperty4Condition(objSenateGaugeVersionEN);
 }


 #endregion 检查对象属性


 #region 绑定下拉框

 /// <summary>
 /// 绑定基于Web的下拉框-使用Cache
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DdlBindFunctionCache)
 /// </summary>
 /// <param name = "objDDL">需要绑定当前表的下拉框</param>
public static void BindDdl_IdSenateGaugeVersionCache(System.Web.UI.WebControls.DropDownList objDDL)
{
//为数据源于表的下拉框设置内容
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[评价量规版本]...","0");
List<clsSenateGaugeVersionEN> arrSenateGaugeVersionObjLst = GetAllSenateGaugeVersionObjLstCache(); 
objDDL.DataValueField = conSenateGaugeVersion.IdSenateGaugeVersion;
objDDL.DataTextField = conSenateGaugeVersion.senateGaugeVersionName;
objDDL.DataSource = arrSenateGaugeVersionObjLst;
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
if (clsSenateGaugeVersionBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsSenateGaugeVersionBL没有刷新缓存机制(clsSenateGaugeVersionBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by IdSenateGaugeVersion");
//if (arrSenateGaugeVersionObjLstCache == null)
//{
//arrSenateGaugeVersionObjLstCache = SenateGaugeVersionDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "strIdSenateGaugeVersion">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsSenateGaugeVersionEN GetObjByIdSenateGaugeVersionCache(string strIdSenateGaugeVersion)
{
//获取缓存中的对象列表
string strKey = string.Format("{0}", clsSenateGaugeVersionEN._CurrTabName);
List<clsSenateGaugeVersionEN> arrSenateGaugeVersionObjLstCache = GetObjLstCache();
IEnumerable <clsSenateGaugeVersionEN> arrSenateGaugeVersionObjLst_Sel =
arrSenateGaugeVersionObjLstCache
.Where(x=> x.IdSenateGaugeVersion == strIdSenateGaugeVersion 
);
if (arrSenateGaugeVersionObjLst_Sel.Count() == 0)
{
   clsSenateGaugeVersionEN obj = clsSenateGaugeVersionBL.GetObjByIdSenateGaugeVersion(strIdSenateGaugeVersion);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
 }
return null;
}
return arrSenateGaugeVersionObjLst_Sel.First();
}

 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecNameByKeyCache)
 /// </summary>
 /// <param name = "strIdSenateGaugeVersion">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetsenateGaugeVersionNameByIdSenateGaugeVersionCache(string strIdSenateGaugeVersion)
{
if (string.IsNullOrEmpty(strIdSenateGaugeVersion) == true) return "";
//获取缓存中的对象列表
clsSenateGaugeVersionEN objSenateGaugeVersion = GetObjByIdSenateGaugeVersionCache(strIdSenateGaugeVersion);
if (objSenateGaugeVersion == null) return "";
return objSenateGaugeVersion.senateGaugeVersionName;
}
 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecNameByKeyCache)
 /// </summary>
 /// <param name = "strIdSenateGaugeVersion">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetNameByIdSenateGaugeVersionCache(string strIdSenateGaugeVersion)
{
if (string.IsNullOrEmpty(strIdSenateGaugeVersion) == true) return "";
//获取缓存中的对象列表
clsSenateGaugeVersionEN objSenateGaugeVersion = GetObjByIdSenateGaugeVersionCache(strIdSenateGaugeVersion);
if (objSenateGaugeVersion == null) return "";
return objSenateGaugeVersion.senateGaugeVersionName;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsSenateGaugeVersionEN> GetAllSenateGaugeVersionObjLstCache()
{
//获取缓存中的对象列表
List<clsSenateGaugeVersionEN> arrSenateGaugeVersionObjLstCache = GetObjLstCache(); 
return arrSenateGaugeVersionObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsSenateGaugeVersionEN> GetObjLstCache()
{
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}", clsSenateGaugeVersionEN._CurrTabName);
List<clsSenateGaugeVersionEN> arrSenateGaugeVersionObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrSenateGaugeVersionObjLstCache;
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
string strKey = string.Format("{0}", clsSenateGaugeVersionEN._CurrTabName);
CacheHelper.Remove(strKey);
clsSenateGaugeVersionEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
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
if (clsSenateGaugeVersionEN._RefreshTimeLst.Count == 0) return "";
return clsSenateGaugeVersionEN._RefreshTimeLst[clsSenateGaugeVersionEN._RefreshTimeLst.Count - 1];
}

 /// <summary>
 /// 刷新缓存.把当前表的缓存以及该表相关视图的缓存清空.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ReFreshCache)
 /// </summary>
public static void ReFreshCache()
{
if (clsSenateGaugeVersionBL.objCommFun4BL != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}", clsSenateGaugeVersionEN._CurrTabName);
CacheHelper.Remove(strKey);
clsSenateGaugeVersionEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
clsSenateGaugeVersionBL.objCommFun4BL.ReFreshCache();
}
}


 #endregion 缓存操作


 #region 检查唯一性

 /// <summary>
 /// 获取检查唯一性条件串(Uniqueness)--SenateGaugeVersion(评价量规版本)
 /// 唯一性条件:senateGaugeVersionName
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetUniquenessConditionString)
 /// </summary>
 /// <param name = "objSenateGaugeVersionEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(clsSenateGaugeVersionEN objSenateGaugeVersionEN)
{
//检测记录是否存在
string strResult = SenateGaugeVersionDA.GetUniCondStr(objSenateGaugeVersionEN);
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
public static string Func(string strInFldName, string strOutFldName, string strIdSenateGaugeVersion)
{
if (strInFldName != conSenateGaugeVersion.IdSenateGaugeVersion)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (conSenateGaugeVersion.AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", conSenateGaugeVersion.AttributeName));
throw new Exception(strMsg);
}
var objSenateGaugeVersion = clsSenateGaugeVersionBL.GetObjByIdSenateGaugeVersionCache(strIdSenateGaugeVersion);
if (objSenateGaugeVersion == null) return "";
return objSenateGaugeVersion[strOutFldName].ToString();
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
int intRecCount = clsSenateGaugeVersionDA.GetRecCount(strTabName);
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
int intRecCount = clsSenateGaugeVersionDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsSenateGaugeVersionDA.GetRecCount();
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
int intRecCount = clsSenateGaugeVersionDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objSenateGaugeVersionCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsSenateGaugeVersionEN objSenateGaugeVersionCond)
{
List<clsSenateGaugeVersionEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsSenateGaugeVersionEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conSenateGaugeVersion.AttributeName)
{
if (objSenateGaugeVersionCond.IsUpdated(strFldName) == false) continue;
if (objSenateGaugeVersionCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objSenateGaugeVersionCond[strFldName].ToString());
}
else
{
if (objSenateGaugeVersionCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objSenateGaugeVersionCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objSenateGaugeVersionCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objSenateGaugeVersionCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objSenateGaugeVersionCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objSenateGaugeVersionCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objSenateGaugeVersionCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objSenateGaugeVersionCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objSenateGaugeVersionCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objSenateGaugeVersionCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objSenateGaugeVersionCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objSenateGaugeVersionCond[strFldName]));
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
 List<string> arrList = clsSenateGaugeVersionDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = SenateGaugeVersionDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = SenateGaugeVersionDA.GetFldValueNoDistinct(strFldName, strWhereCond);
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
int intRecCount = SenateGaugeVersionDA.SetFldValue(strFldName, strValue, strWhereCond);
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
int intRecCount = clsSenateGaugeVersionDA.SetFldValue(clsSenateGaugeVersionEN._CurrTabName, strFldName, fltValue, strWhereCond);
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
int intRecCount = SenateGaugeVersionDA.SetFldValue( strFldName, intValue, strWhereCond);
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
int intRecCount = clsSenateGaugeVersionDA.SetFldValue(strTabName, strFldName, strValue, strWhereCond);
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
int intRecCount = clsSenateGaugeVersionDA.SetFldValue(strTabName, strFldName, intValue, strWhereCond);
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
int intRecCount = clsSenateGaugeVersionDA.SetFldValue(strTabName, strFldName, fltValue, strWhereCond);
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
  strCreateTabCode.Append("CREATE table [dbo].[SenateGaugeVersion] "); 
 strCreateTabCode.Append(" ( "); 
 // /**评价量表版本流水号*/ 
 strCreateTabCode.Append(" IdSenateGaugeVersion char(4) primary key, "); 
 // /**评价量表版本ID*/ 
 strCreateTabCode.Append(" senateGaugeVersionID char(4) not Null, "); 
 // /**评价量表版本名称*/ 
 strCreateTabCode.Append(" senateGaugeVersionName varchar(200) not Null, "); 
 // /**评价量表版本总分*/ 
 strCreateTabCode.Append(" senateGaugeVersionTtlScore float not Null, "); 
 // /**是否使用*/ 
 strCreateTabCode.Append(" IsUse bit not Null, "); 
 // /**版本号*/ 
 strCreateTabCode.Append(" VersionNo int Null, "); 
 // /**技能类型流水号*/ 
 strCreateTabCode.Append(" IdSkillType char(4) not Null, "); 
 // /**用户类型Id*/ 
 strCreateTabCode.Append(" UserTypeId char(2) not Null, "); 
 // /**修改日期*/ 
 strCreateTabCode.Append(" UpdDate varchar(20) Null, "); 
 // /**修改用户Id*/ 
 strCreateTabCode.Append(" UpdUserId varchar(20) Null, "); 
 // /**评价量表版本说明*/ 
 strCreateTabCode.Append(" senateGaugeVersionMemo varchar(1000) Null ");
 strCreateTabCode.Append(") "); 
  strCreateTabCode.Append("ON [PRIMARY] ");
  return strCreateTabCode.ToString();
}



 #endregion 表操作
}
 /// <summary>
 /// 评价量规版本(SenateGaugeVersion)
 /// 数据源类型:表
 /// (AutoGCLib.CommFun4BL4CSharp:GeneCode_This)
 /// </summary>
public class  clsCommFun4BL4SenateGaugeVersion : clsCommFun4BL
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
clsSenateGaugeVersionBL.ReFreshThisCache();
}
}

}