﻿
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsXzClgBL
 表名:XzClg(01120064)
 * 版本:2024.11.13.1(服务器:WIN-SRV103-116)
 日期:2024/11/13 05:59:20
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:研究生学习游戏化后台(000055, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:用户管理(UserManage)
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
public static class  clsXzClgBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "strIdXzCollege">表关键字</param>
 /// <returns>表对象</returns>
public static clsXzClgEN GetObj(this K_IdXzCollege_XzClg myKey)
{
clsXzClgEN objXzClgEN = clsXzClgBL.XzClgDA.GetObjByIdXzCollege(myKey.Value);
return objXzClgEN;
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_AddNewRecord)
 /// </summary>
 /// <param name = "objXzClgEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clsXzClgEN objXzClgEN, bool bolIsNeedCheckUniqueness = true)
{
 if (string.IsNullOrEmpty(objXzClgEN.IdXzCollege) == true)
 {
string strMsg = string.Format("添加记录时,关键字不能为空!(from {0})\r\n", 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
 if (clsXzClgBL.IsExist(objXzClgEN.IdXzCollege) == true)
 {
string strMsg = string.Format("添加记录时,关键字:[{0}]已经存在!(from {1})\r\n", objXzClgEN.IdXzCollege, 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
try
{
bool bolResult = clsXzClgBL.XzClgDA.AddNewRecordBySQL2(objXzClgEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsXzClgBL.ReFreshCache();

if (clsXzClgBL.relatedActions != null)
{
clsXzClgBL.relatedActions.UpdRelaTabDate(objXzClgEN.IdXzCollege, "SetUpdDate");
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
public static bool AddRecordEx(this clsXzClgEN objXzClgEN, bool bolIsNeedCheckUniqueness = true)
{
//操作步骤:
//1、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在
//2、检查唯一性
//3、检查传进去的对象属性是否合法
//4、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
//1、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在
if (clsXzClgBL.IsExist(objXzClgEN.IdXzCollege))	//判断是否有相同的关键字
{
strMsg = "(errid:Busi000151)关键字字段已有相同的值";
throw new Exception(strMsg);
}
try
{
 //2、检查传进去的对象属性是否合法
objXzClgEN.CheckPropertyNew();
//6、把数据实体层的数据存贮到数据库中
objXzClgEN.AddNewRecord();
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
 /// <param name = "objXzClgEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordWithReturnKey(this clsXzClgEN objXzClgEN, bool bolIsNeedCheckUniqueness = true)
{
 if (string.IsNullOrEmpty(objXzClgEN.IdXzCollege) == true)
 {
string strMsg = string.Format("添加记录时,关键字不能为空!(from {{0}})", 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
 if (clsXzClgBL.IsExist(objXzClgEN.IdXzCollege) == true)
 {
string strMsg = string.Format("添加记录时,关键字:[{0}]已经存在!(from {1})\r\n", objXzClgEN.IdXzCollege, 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
try
{
string strKey = clsXzClgBL.XzClgDA.AddNewRecordBySQL2WithReturnKey(objXzClgEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsXzClgBL.ReFreshCache();

if (clsXzClgBL.relatedActions != null)
{
clsXzClgBL.relatedActions.UpdRelaTabDate(objXzClgEN.IdXzCollege, "SetUpdDate");
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
 /// <param name = "objXzClgEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsXzClgEN SetIdXzCollege(this clsXzClgEN objXzClgEN, string strIdXzCollege, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdXzCollege, 4, conXzClg.IdXzCollege);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdXzCollege, 4, conXzClg.IdXzCollege);
}
objXzClgEN.IdXzCollege = strIdXzCollege; //学院流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objXzClgEN.dicFldComparisonOp.ContainsKey(conXzClg.IdXzCollege) == false)
{
objXzClgEN.dicFldComparisonOp.Add(conXzClg.IdXzCollege, strComparisonOp);
}
else
{
objXzClgEN.dicFldComparisonOp[conXzClg.IdXzCollege] = strComparisonOp;
}
}
return objXzClgEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objXzClgEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsXzClgEN SetCollegeId(this clsXzClgEN objXzClgEN, string strCollegeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strCollegeId, conXzClg.CollegeId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCollegeId, 4, conXzClg.CollegeId);
}
objXzClgEN.CollegeId = strCollegeId; //学院ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objXzClgEN.dicFldComparisonOp.ContainsKey(conXzClg.CollegeId) == false)
{
objXzClgEN.dicFldComparisonOp.Add(conXzClg.CollegeId, strComparisonOp);
}
else
{
objXzClgEN.dicFldComparisonOp[conXzClg.CollegeId] = strComparisonOp;
}
}
return objXzClgEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objXzClgEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsXzClgEN SetCollegeName(this clsXzClgEN objXzClgEN, string strCollegeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strCollegeName, conXzClg.CollegeName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCollegeName, 100, conXzClg.CollegeName);
}
objXzClgEN.CollegeName = strCollegeName; //学院名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objXzClgEN.dicFldComparisonOp.ContainsKey(conXzClg.CollegeName) == false)
{
objXzClgEN.dicFldComparisonOp.Add(conXzClg.CollegeName, strComparisonOp);
}
else
{
objXzClgEN.dicFldComparisonOp[conXzClg.CollegeName] = strComparisonOp;
}
}
return objXzClgEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objXzClgEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsXzClgEN SetCollegeIdInGP(this clsXzClgEN objXzClgEN, string strCollegeIdInGP, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCollegeIdInGP, 6, conXzClg.CollegeIdInGP);
}
objXzClgEN.CollegeIdInGP = strCollegeIdInGP; //CollegeIdInGP
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objXzClgEN.dicFldComparisonOp.ContainsKey(conXzClg.CollegeIdInGP) == false)
{
objXzClgEN.dicFldComparisonOp.Add(conXzClg.CollegeIdInGP, strComparisonOp);
}
else
{
objXzClgEN.dicFldComparisonOp[conXzClg.CollegeIdInGP] = strComparisonOp;
}
}
return objXzClgEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objXzClgEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsXzClgEN SetClgEnglishName(this clsXzClgEN objXzClgEN, string strClgEnglishName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strClgEnglishName, 60, conXzClg.ClgEnglishName);
}
objXzClgEN.ClgEnglishName = strClgEnglishName; //ClgEnglishName
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objXzClgEN.dicFldComparisonOp.ContainsKey(conXzClg.ClgEnglishName) == false)
{
objXzClgEN.dicFldComparisonOp.Add(conXzClg.ClgEnglishName, strComparisonOp);
}
else
{
objXzClgEN.dicFldComparisonOp[conXzClg.ClgEnglishName] = strComparisonOp;
}
}
return objXzClgEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objXzClgEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsXzClgEN SetCollegeNameA(this clsXzClgEN objXzClgEN, string strCollegeNameA, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strCollegeNameA, conXzClg.CollegeNameA);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCollegeNameA, 12, conXzClg.CollegeNameA);
}
objXzClgEN.CollegeNameA = strCollegeNameA; //学院名称简写
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objXzClgEN.dicFldComparisonOp.ContainsKey(conXzClg.CollegeNameA) == false)
{
objXzClgEN.dicFldComparisonOp.Add(conXzClg.CollegeNameA, strComparisonOp);
}
else
{
objXzClgEN.dicFldComparisonOp[conXzClg.CollegeNameA] = strComparisonOp;
}
}
return objXzClgEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objXzClgEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsXzClgEN SetUserType(this clsXzClgEN objXzClgEN, string strUserType, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUserType, 50, conXzClg.UserType);
}
objXzClgEN.UserType = strUserType; //用户类型
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objXzClgEN.dicFldComparisonOp.ContainsKey(conXzClg.UserType) == false)
{
objXzClgEN.dicFldComparisonOp.Add(conXzClg.UserType, strComparisonOp);
}
else
{
objXzClgEN.dicFldComparisonOp[conXzClg.UserType] = strComparisonOp;
}
}
return objXzClgEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objXzClgEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsXzClgEN SetPhoneNumber(this clsXzClgEN objXzClgEN, string strPhoneNumber, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPhoneNumber, 15, conXzClg.PhoneNumber);
}
objXzClgEN.PhoneNumber = strPhoneNumber; //电话
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objXzClgEN.dicFldComparisonOp.ContainsKey(conXzClg.PhoneNumber) == false)
{
objXzClgEN.dicFldComparisonOp.Add(conXzClg.PhoneNumber, strComparisonOp);
}
else
{
objXzClgEN.dicFldComparisonOp[conXzClg.PhoneNumber] = strComparisonOp;
}
}
return objXzClgEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objXzClgEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsXzClgEN SetWebSite(this clsXzClgEN objXzClgEN, string strWebSite, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strWebSite, 60, conXzClg.WebSite);
}
objXzClgEN.WebSite = strWebSite; //个人主页
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objXzClgEN.dicFldComparisonOp.ContainsKey(conXzClg.WebSite) == false)
{
objXzClgEN.dicFldComparisonOp.Add(conXzClg.WebSite, strComparisonOp);
}
else
{
objXzClgEN.dicFldComparisonOp[conXzClg.WebSite] = strComparisonOp;
}
}
return objXzClgEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objXzClgEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsXzClgEN SetIdSchool(this clsXzClgEN objXzClgEN, string strIdSchool, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdSchool, 4, conXzClg.IdSchool);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdSchool, 4, conXzClg.IdSchool);
}
objXzClgEN.IdSchool = strIdSchool; //学校流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objXzClgEN.dicFldComparisonOp.ContainsKey(conXzClg.IdSchool) == false)
{
objXzClgEN.dicFldComparisonOp.Add(conXzClg.IdSchool, strComparisonOp);
}
else
{
objXzClgEN.dicFldComparisonOp[conXzClg.IdSchool] = strComparisonOp;
}
}
return objXzClgEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objXzClgEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsXzClgEN SetIdUni(this clsXzClgEN objXzClgEN, string strIdUni, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdUni, 4, conXzClg.IdUni);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdUni, 4, conXzClg.IdUni);
}
objXzClgEN.IdUni = strIdUni; //id_Uni
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objXzClgEN.dicFldComparisonOp.ContainsKey(conXzClg.IdUni) == false)
{
objXzClgEN.dicFldComparisonOp.Add(conXzClg.IdUni, strComparisonOp);
}
else
{
objXzClgEN.dicFldComparisonOp[conXzClg.IdUni] = strComparisonOp;
}
}
return objXzClgEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objXzClgEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsXzClgEN SetIsVisible4Tea(this clsXzClgEN objXzClgEN, bool bolIsVisible4Tea, string strComparisonOp="")
	{
objXzClgEN.IsVisible4Tea = bolIsVisible4Tea; //IsVisible4Tea
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objXzClgEN.dicFldComparisonOp.ContainsKey(conXzClg.IsVisible4Tea) == false)
{
objXzClgEN.dicFldComparisonOp.Add(conXzClg.IsVisible4Tea, strComparisonOp);
}
else
{
objXzClgEN.dicFldComparisonOp[conXzClg.IsVisible4Tea] = strComparisonOp;
}
}
return objXzClgEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objXzClgEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsXzClgEN SetIsVisible(this clsXzClgEN objXzClgEN, bool bolIsVisible, string strComparisonOp="")
	{
objXzClgEN.IsVisible = bolIsVisible; //是否显示
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objXzClgEN.dicFldComparisonOp.ContainsKey(conXzClg.IsVisible) == false)
{
objXzClgEN.dicFldComparisonOp.Add(conXzClg.IsVisible, strComparisonOp);
}
else
{
objXzClgEN.dicFldComparisonOp[conXzClg.IsVisible] = strComparisonOp;
}
}
return objXzClgEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objXzClgEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsXzClgEN SetOrderNum(this clsXzClgEN objXzClgEN, int? intOrderNum, string strComparisonOp="")
	{
objXzClgEN.OrderNum = intOrderNum; //序号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objXzClgEN.dicFldComparisonOp.ContainsKey(conXzClg.OrderNum) == false)
{
objXzClgEN.dicFldComparisonOp.Add(conXzClg.OrderNum, strComparisonOp);
}
else
{
objXzClgEN.dicFldComparisonOp[conXzClg.OrderNum] = strComparisonOp;
}
}
return objXzClgEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objXzClgEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsXzClgEN SetModifyDate(this clsXzClgEN objXzClgEN, string strModifyDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strModifyDate, 20, conXzClg.ModifyDate);
}
objXzClgEN.ModifyDate = strModifyDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objXzClgEN.dicFldComparisonOp.ContainsKey(conXzClg.ModifyDate) == false)
{
objXzClgEN.dicFldComparisonOp.Add(conXzClg.ModifyDate, strComparisonOp);
}
else
{
objXzClgEN.dicFldComparisonOp[conXzClg.ModifyDate] = strComparisonOp;
}
}
return objXzClgEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objXzClgEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsXzClgEN SetModifyUserId(this clsXzClgEN objXzClgEN, string strModifyUserId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strModifyUserId, 18, conXzClg.ModifyUserId);
}
objXzClgEN.ModifyUserId = strModifyUserId; //修改人
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objXzClgEN.dicFldComparisonOp.ContainsKey(conXzClg.ModifyUserId) == false)
{
objXzClgEN.dicFldComparisonOp.Add(conXzClg.ModifyUserId, strComparisonOp);
}
else
{
objXzClgEN.dicFldComparisonOp[conXzClg.ModifyUserId] = strComparisonOp;
}
}
return objXzClgEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objXzClgEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsXzClgEN SetMemo(this clsXzClgEN objXzClgEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, conXzClg.Memo);
}
objXzClgEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objXzClgEN.dicFldComparisonOp.ContainsKey(conXzClg.Memo) == false)
{
objXzClgEN.dicFldComparisonOp.Add(conXzClg.Memo, strComparisonOp);
}
else
{
objXzClgEN.dicFldComparisonOp[conXzClg.Memo] = strComparisonOp;
}
}
return objXzClgEN;
	}

 /// <summary>
 /// 修改记录存盘到数据表中
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_UpdateRecordEx)
 /// </summary>
 /// <param name = "objXzClgEN">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool UpdateRecordEx(this clsXzClgEN objXzClgEN)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
try
{
//1、检查传进去的对象属性是否合法
objXzClgEN.CheckPropertyNew();
clsXzClgEN objXzClgCond = new clsXzClgEN();
string strCondition = objXzClgCond
.SetIdXzCollege(objXzClgEN.IdXzCollege, "=")
.GetCombineCondition();
objXzClgEN._IsCheckProperty = true;
bool bolIsExist = clsXzClgBL.IsExistRecord(strCondition);
if (bolIsExist)
{
strMsg = "()不能重复!";
throw new Exception(strMsg);
}
//4、把数据实体层的数据存贮到数据库中
objXzClgEN.Update();
}
catch(Exception objException)
{
strMsg = "修改记录不成功!" + objException.Message;
throw new Exception(strMsg);
}
return true; 
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_Update)
 /// </summary>
 /// <param name = "objXzClgEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsXzClgEN objXzClgEN)
{
 if (string.IsNullOrEmpty(objXzClgEN.IdXzCollege) == true)
 {
string strMsg = string.Format("(errid:Busi000095)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsXzClgBL.XzClgDA.UpdateBySql2(objXzClgEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsXzClgBL.ReFreshCache();

if (clsXzClgBL.relatedActions != null)
{
clsXzClgBL.relatedActions.UpdRelaTabDate(objXzClgEN.IdXzCollege, "SetUpdDate");
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
 /// <param name = "objXzClgEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsXzClgEN objXzClgEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (string.IsNullOrEmpty(objXzClgEN.IdXzCollege) == true)
 {
string strMsg = string.Format("(errid:Busi000087)修改记录时关键字不能为空!(带事务处理)(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsXzClgBL.XzClgDA.UpdateBySql2(objXzClgEN, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsXzClgBL.ReFreshCache();

if (clsXzClgBL.relatedActions != null)
{
clsXzClgBL.relatedActions.UpdRelaTabDate(objXzClgEN.IdXzCollege, "SetUpdDate");
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
 /// <param name = "objXzClgEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsXzClgEN objXzClgEN, string strWhereCond)
{
try
{
bool bolResult = clsXzClgBL.XzClgDA.UpdateBySqlWithCondition(objXzClgEN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsXzClgBL.ReFreshCache();

if (clsXzClgBL.relatedActions != null)
{
clsXzClgBL.relatedActions.UpdRelaTabDate(objXzClgEN.IdXzCollege, "SetUpdDate");
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
 /// <param name = "objXzClgEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsXzClgEN objXzClgEN, string strWhereCond, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
bool bolResult = clsXzClgBL.XzClgDA.UpdateBySqlWithConditionTransaction(objXzClgEN, strWhereCond, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsXzClgBL.ReFreshCache();

if (clsXzClgBL.relatedActions != null)
{
clsXzClgBL.relatedActions.UpdRelaTabDate(objXzClgEN.IdXzCollege, "SetUpdDate");
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
 /// <param name = "strIdXzCollege">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int Delete(this clsXzClgEN objXzClgEN)
{
try
{
int intRecNum = clsXzClgBL.XzClgDA.DelRecord(objXzClgEN.IdXzCollege);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsXzClgBL.ReFreshCache();

if (clsXzClgBL.relatedActions != null)
{
clsXzClgBL.relatedActions.UpdRelaTabDate(objXzClgEN.IdXzCollege, "SetUpdDate");
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
 /// <param name = "objXzClgENS">源对象</param>
 /// <param name = "objXzClgENT">目标对象</param>
 public static void CopyTo(this clsXzClgEN objXzClgENS, clsXzClgEN objXzClgENT)
{
try
{
objXzClgENT.IdXzCollege = objXzClgENS.IdXzCollege; //学院流水号
objXzClgENT.CollegeId = objXzClgENS.CollegeId; //学院ID
objXzClgENT.CollegeName = objXzClgENS.CollegeName; //学院名称
objXzClgENT.CollegeIdInGP = objXzClgENS.CollegeIdInGP; //CollegeIdInGP
objXzClgENT.ClgEnglishName = objXzClgENS.ClgEnglishName; //ClgEnglishName
objXzClgENT.CollegeNameA = objXzClgENS.CollegeNameA; //学院名称简写
objXzClgENT.UserType = objXzClgENS.UserType; //用户类型
objXzClgENT.PhoneNumber = objXzClgENS.PhoneNumber; //电话
objXzClgENT.WebSite = objXzClgENS.WebSite; //个人主页
objXzClgENT.IdSchool = objXzClgENS.IdSchool; //学校流水号
objXzClgENT.IdUni = objXzClgENS.IdUni; //id_Uni
objXzClgENT.IsVisible4Tea = objXzClgENS.IsVisible4Tea; //IsVisible4Tea
objXzClgENT.IsVisible = objXzClgENS.IsVisible; //是否显示
objXzClgENT.OrderNum = objXzClgENS.OrderNum; //序号
objXzClgENT.ModifyDate = objXzClgENS.ModifyDate; //修改日期
objXzClgENT.ModifyUserId = objXzClgENS.ModifyUserId; //修改人
objXzClgENT.Memo = objXzClgENS.Memo; //备注
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
 /// <param name = "objXzClgENS">源对象</param>
 /// <returns>目标对象=>clsXzClgEN:objXzClgENT</returns>
 public static clsXzClgEN CopyTo(this clsXzClgEN objXzClgENS)
{
try
{
 clsXzClgEN objXzClgENT = new clsXzClgEN()
{
IdXzCollege = objXzClgENS.IdXzCollege, //学院流水号
CollegeId = objXzClgENS.CollegeId, //学院ID
CollegeName = objXzClgENS.CollegeName, //学院名称
CollegeIdInGP = objXzClgENS.CollegeIdInGP, //CollegeIdInGP
ClgEnglishName = objXzClgENS.ClgEnglishName, //ClgEnglishName
CollegeNameA = objXzClgENS.CollegeNameA, //学院名称简写
UserType = objXzClgENS.UserType, //用户类型
PhoneNumber = objXzClgENS.PhoneNumber, //电话
WebSite = objXzClgENS.WebSite, //个人主页
IdSchool = objXzClgENS.IdSchool, //学校流水号
IdUni = objXzClgENS.IdUni, //id_Uni
IsVisible4Tea = objXzClgENS.IsVisible4Tea, //IsVisible4Tea
IsVisible = objXzClgENS.IsVisible, //是否显示
OrderNum = objXzClgENS.OrderNum, //序号
ModifyDate = objXzClgENS.ModifyDate, //修改日期
ModifyUserId = objXzClgENS.ModifyUserId, //修改人
Memo = objXzClgENS.Memo, //备注
};
 return objXzClgENT;
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
public static void CheckPropertyNew(this clsXzClgEN objXzClgEN)
{
 clsXzClgBL.XzClgDA.CheckPropertyNew(objXzClgEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(this clsXzClgEN objXzClgEN)
{
 clsXzClgBL.XzClgDA.CheckProperty4Condition(objXzClgEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsXzClgEN objXzClgCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objXzClgCond.IsUpdated(conXzClg.IdXzCollege) == true)
{
string strComparisonOpIdXzCollege = objXzClgCond.dicFldComparisonOp[conXzClg.IdXzCollege];
strWhereCond += string.Format(" And {0} {2} '{1}'", conXzClg.IdXzCollege, objXzClgCond.IdXzCollege, strComparisonOpIdXzCollege);
}
if (objXzClgCond.IsUpdated(conXzClg.CollegeId) == true)
{
string strComparisonOpCollegeId = objXzClgCond.dicFldComparisonOp[conXzClg.CollegeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conXzClg.CollegeId, objXzClgCond.CollegeId, strComparisonOpCollegeId);
}
if (objXzClgCond.IsUpdated(conXzClg.CollegeName) == true)
{
string strComparisonOpCollegeName = objXzClgCond.dicFldComparisonOp[conXzClg.CollegeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", conXzClg.CollegeName, objXzClgCond.CollegeName, strComparisonOpCollegeName);
}
if (objXzClgCond.IsUpdated(conXzClg.CollegeIdInGP) == true)
{
string strComparisonOpCollegeIdInGP = objXzClgCond.dicFldComparisonOp[conXzClg.CollegeIdInGP];
strWhereCond += string.Format(" And {0} {2} '{1}'", conXzClg.CollegeIdInGP, objXzClgCond.CollegeIdInGP, strComparisonOpCollegeIdInGP);
}
if (objXzClgCond.IsUpdated(conXzClg.ClgEnglishName) == true)
{
string strComparisonOpClgEnglishName = objXzClgCond.dicFldComparisonOp[conXzClg.ClgEnglishName];
strWhereCond += string.Format(" And {0} {2} '{1}'", conXzClg.ClgEnglishName, objXzClgCond.ClgEnglishName, strComparisonOpClgEnglishName);
}
if (objXzClgCond.IsUpdated(conXzClg.CollegeNameA) == true)
{
string strComparisonOpCollegeNameA = objXzClgCond.dicFldComparisonOp[conXzClg.CollegeNameA];
strWhereCond += string.Format(" And {0} {2} '{1}'", conXzClg.CollegeNameA, objXzClgCond.CollegeNameA, strComparisonOpCollegeNameA);
}
if (objXzClgCond.IsUpdated(conXzClg.UserType) == true)
{
string strComparisonOpUserType = objXzClgCond.dicFldComparisonOp[conXzClg.UserType];
strWhereCond += string.Format(" And {0} {2} '{1}'", conXzClg.UserType, objXzClgCond.UserType, strComparisonOpUserType);
}
if (objXzClgCond.IsUpdated(conXzClg.PhoneNumber) == true)
{
string strComparisonOpPhoneNumber = objXzClgCond.dicFldComparisonOp[conXzClg.PhoneNumber];
strWhereCond += string.Format(" And {0} {2} '{1}'", conXzClg.PhoneNumber, objXzClgCond.PhoneNumber, strComparisonOpPhoneNumber);
}
if (objXzClgCond.IsUpdated(conXzClg.WebSite) == true)
{
string strComparisonOpWebSite = objXzClgCond.dicFldComparisonOp[conXzClg.WebSite];
strWhereCond += string.Format(" And {0} {2} '{1}'", conXzClg.WebSite, objXzClgCond.WebSite, strComparisonOpWebSite);
}
if (objXzClgCond.IsUpdated(conXzClg.IdSchool) == true)
{
string strComparisonOpIdSchool = objXzClgCond.dicFldComparisonOp[conXzClg.IdSchool];
strWhereCond += string.Format(" And {0} {2} '{1}'", conXzClg.IdSchool, objXzClgCond.IdSchool, strComparisonOpIdSchool);
}
if (objXzClgCond.IsUpdated(conXzClg.IdUni) == true)
{
string strComparisonOpIdUni = objXzClgCond.dicFldComparisonOp[conXzClg.IdUni];
strWhereCond += string.Format(" And {0} {2} '{1}'", conXzClg.IdUni, objXzClgCond.IdUni, strComparisonOpIdUni);
}
if (objXzClgCond.IsUpdated(conXzClg.IsVisible4Tea) == true)
{
if (objXzClgCond.IsVisible4Tea == true)
{
strWhereCond += string.Format(" And {0} = '1'", conXzClg.IsVisible4Tea);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conXzClg.IsVisible4Tea);
}
}
if (objXzClgCond.IsUpdated(conXzClg.IsVisible) == true)
{
if (objXzClgCond.IsVisible == true)
{
strWhereCond += string.Format(" And {0} = '1'", conXzClg.IsVisible);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conXzClg.IsVisible);
}
}
if (objXzClgCond.IsUpdated(conXzClg.OrderNum) == true)
{
string strComparisonOpOrderNum = objXzClgCond.dicFldComparisonOp[conXzClg.OrderNum];
strWhereCond += string.Format(" And {0} {2} {1}", conXzClg.OrderNum, objXzClgCond.OrderNum, strComparisonOpOrderNum);
}
if (objXzClgCond.IsUpdated(conXzClg.ModifyDate) == true)
{
string strComparisonOpModifyDate = objXzClgCond.dicFldComparisonOp[conXzClg.ModifyDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conXzClg.ModifyDate, objXzClgCond.ModifyDate, strComparisonOpModifyDate);
}
if (objXzClgCond.IsUpdated(conXzClg.ModifyUserId) == true)
{
string strComparisonOpModifyUserId = objXzClgCond.dicFldComparisonOp[conXzClg.ModifyUserId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conXzClg.ModifyUserId, objXzClgCond.ModifyUserId, strComparisonOpModifyUserId);
}
if (objXzClgCond.IsUpdated(conXzClg.Memo) == true)
{
string strComparisonOpMemo = objXzClgCond.dicFldComparisonOp[conXzClg.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", conXzClg.Memo, objXzClgCond.Memo, strComparisonOpMemo);
}
 return strWhereCond;
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_XzClg
{
public virtual bool UpdRelaTabDate(string strIdXzCollege, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// 学院(XzClg)
 /// 数据源类型:表
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsXzClgBL
{
public static RelatedActions_XzClg relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsXzClgDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsXzClgDA XzClgDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsXzClgDA();
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
 public clsXzClgBL()
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
if (string.IsNullOrEmpty(clsXzClgEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsXzClgEN._ConnectString);
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
public static DataTable GetDataTable_XzClg(string strWhereCond)
{
DataTable objDT;
try
{
objDT = XzClgDA.GetDataTable_XzClg(strWhereCond);
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
objDT = XzClgDA.GetDataTable(strWhereCond);
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
objDT = XzClgDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = XzClgDA.GetDataTable(strWhereCond, strTabName);
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
objDT = XzClgDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = XzClgDA.GetDataTable_Top(objTopPara);
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
objDT = XzClgDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = XzClgDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = XzClgDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
 /// <param name = "arrIdXzCollegeLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static List<clsXzClgEN> GetObjLstByIdXzCollegeLst(List<string> arrIdXzCollegeLst)
{
List<clsXzClgEN> arrObjLst = new List<clsXzClgEN>(); 
System.Data.DataTable objDT; 
 string strSqlConditionStr = clsArray.GetSqlInStrByArray(arrIdXzCollegeLst, true);
 string strWhereCond = string.Format("IdXzCollege in ({0})", strSqlConditionStr);
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsXzClgEN objXzClgEN = new clsXzClgEN();
try
{
objXzClgEN.IdXzCollege = objRow[conXzClg.IdXzCollege].ToString().Trim(); //学院流水号
objXzClgEN.CollegeId = objRow[conXzClg.CollegeId].ToString().Trim(); //学院ID
objXzClgEN.CollegeName = objRow[conXzClg.CollegeName].ToString().Trim(); //学院名称
objXzClgEN.CollegeIdInGP = objRow[conXzClg.CollegeIdInGP] == DBNull.Value ? null : objRow[conXzClg.CollegeIdInGP].ToString().Trim(); //CollegeIdInGP
objXzClgEN.ClgEnglishName = objRow[conXzClg.ClgEnglishName] == DBNull.Value ? null : objRow[conXzClg.ClgEnglishName].ToString().Trim(); //ClgEnglishName
objXzClgEN.CollegeNameA = objRow[conXzClg.CollegeNameA].ToString().Trim(); //学院名称简写
objXzClgEN.UserType = objRow[conXzClg.UserType] == DBNull.Value ? null : objRow[conXzClg.UserType].ToString().Trim(); //用户类型
objXzClgEN.PhoneNumber = objRow[conXzClg.PhoneNumber] == DBNull.Value ? null : objRow[conXzClg.PhoneNumber].ToString().Trim(); //电话
objXzClgEN.WebSite = objRow[conXzClg.WebSite] == DBNull.Value ? null : objRow[conXzClg.WebSite].ToString().Trim(); //个人主页
objXzClgEN.IdSchool = objRow[conXzClg.IdSchool] == DBNull.Value ? null : objRow[conXzClg.IdSchool].ToString().Trim(); //学校流水号
objXzClgEN.IdUni = objRow[conXzClg.IdUni] == DBNull.Value ? null : objRow[conXzClg.IdUni].ToString().Trim(); //id_Uni
objXzClgEN.IsVisible4Tea = clsEntityBase2.TransNullToBool_S(objRow[conXzClg.IsVisible4Tea].ToString().Trim()); //IsVisible4Tea
objXzClgEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[conXzClg.IsVisible].ToString().Trim()); //是否显示
objXzClgEN.OrderNum = objRow[conXzClg.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conXzClg.OrderNum].ToString().Trim()); //序号
objXzClgEN.ModifyDate = objRow[conXzClg.ModifyDate] == DBNull.Value ? null : objRow[conXzClg.ModifyDate].ToString().Trim(); //修改日期
objXzClgEN.ModifyUserId = objRow[conXzClg.ModifyUserId] == DBNull.Value ? null : objRow[conXzClg.ModifyUserId].ToString().Trim(); //修改人
objXzClgEN.Memo = objRow[conXzClg.Memo] == DBNull.Value ? null : objRow[conXzClg.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objXzClgEN.IdXzCollege, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objXzClgEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrIdXzCollegeLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsXzClgEN> GetObjLstByIdXzCollegeLstCache(List<string> arrIdXzCollegeLst)
{
string strKey = string.Format("{0}", clsXzClgEN._CurrTabName);
List<clsXzClgEN> arrXzClgObjLstCache = GetObjLstCache();
IEnumerable <clsXzClgEN> arrXzClgObjLst_Sel =
arrXzClgObjLstCache
.Where(x => arrIdXzCollegeLst.Contains(x.IdXzCollege));
return arrXzClgObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsXzClgEN> GetObjLst(string strWhereCond)
{
List<clsXzClgEN> arrObjLst = new List<clsXzClgEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsXzClgEN objXzClgEN = new clsXzClgEN();
try
{
objXzClgEN.IdXzCollege = objRow[conXzClg.IdXzCollege].ToString().Trim(); //学院流水号
objXzClgEN.CollegeId = objRow[conXzClg.CollegeId].ToString().Trim(); //学院ID
objXzClgEN.CollegeName = objRow[conXzClg.CollegeName].ToString().Trim(); //学院名称
objXzClgEN.CollegeIdInGP = objRow[conXzClg.CollegeIdInGP] == DBNull.Value ? null : objRow[conXzClg.CollegeIdInGP].ToString().Trim(); //CollegeIdInGP
objXzClgEN.ClgEnglishName = objRow[conXzClg.ClgEnglishName] == DBNull.Value ? null : objRow[conXzClg.ClgEnglishName].ToString().Trim(); //ClgEnglishName
objXzClgEN.CollegeNameA = objRow[conXzClg.CollegeNameA].ToString().Trim(); //学院名称简写
objXzClgEN.UserType = objRow[conXzClg.UserType] == DBNull.Value ? null : objRow[conXzClg.UserType].ToString().Trim(); //用户类型
objXzClgEN.PhoneNumber = objRow[conXzClg.PhoneNumber] == DBNull.Value ? null : objRow[conXzClg.PhoneNumber].ToString().Trim(); //电话
objXzClgEN.WebSite = objRow[conXzClg.WebSite] == DBNull.Value ? null : objRow[conXzClg.WebSite].ToString().Trim(); //个人主页
objXzClgEN.IdSchool = objRow[conXzClg.IdSchool] == DBNull.Value ? null : objRow[conXzClg.IdSchool].ToString().Trim(); //学校流水号
objXzClgEN.IdUni = objRow[conXzClg.IdUni] == DBNull.Value ? null : objRow[conXzClg.IdUni].ToString().Trim(); //id_Uni
objXzClgEN.IsVisible4Tea = clsEntityBase2.TransNullToBool_S(objRow[conXzClg.IsVisible4Tea].ToString().Trim()); //IsVisible4Tea
objXzClgEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[conXzClg.IsVisible].ToString().Trim()); //是否显示
objXzClgEN.OrderNum = objRow[conXzClg.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conXzClg.OrderNum].ToString().Trim()); //序号
objXzClgEN.ModifyDate = objRow[conXzClg.ModifyDate] == DBNull.Value ? null : objRow[conXzClg.ModifyDate].ToString().Trim(); //修改日期
objXzClgEN.ModifyUserId = objRow[conXzClg.ModifyUserId] == DBNull.Value ? null : objRow[conXzClg.ModifyUserId].ToString().Trim(); //修改人
objXzClgEN.Memo = objRow[conXzClg.Memo] == DBNull.Value ? null : objRow[conXzClg.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objXzClgEN.IdXzCollege, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objXzClgEN);
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
public static List<clsXzClgEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsXzClgEN> arrObjLst = new List<clsXzClgEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsXzClgEN objXzClgEN = new clsXzClgEN();
try
{
objXzClgEN.IdXzCollege = objRow[conXzClg.IdXzCollege].ToString().Trim(); //学院流水号
objXzClgEN.CollegeId = objRow[conXzClg.CollegeId].ToString().Trim(); //学院ID
objXzClgEN.CollegeName = objRow[conXzClg.CollegeName].ToString().Trim(); //学院名称
objXzClgEN.CollegeIdInGP = objRow[conXzClg.CollegeIdInGP] == DBNull.Value ? null : objRow[conXzClg.CollegeIdInGP].ToString().Trim(); //CollegeIdInGP
objXzClgEN.ClgEnglishName = objRow[conXzClg.ClgEnglishName] == DBNull.Value ? null : objRow[conXzClg.ClgEnglishName].ToString().Trim(); //ClgEnglishName
objXzClgEN.CollegeNameA = objRow[conXzClg.CollegeNameA].ToString().Trim(); //学院名称简写
objXzClgEN.UserType = objRow[conXzClg.UserType] == DBNull.Value ? null : objRow[conXzClg.UserType].ToString().Trim(); //用户类型
objXzClgEN.PhoneNumber = objRow[conXzClg.PhoneNumber] == DBNull.Value ? null : objRow[conXzClg.PhoneNumber].ToString().Trim(); //电话
objXzClgEN.WebSite = objRow[conXzClg.WebSite] == DBNull.Value ? null : objRow[conXzClg.WebSite].ToString().Trim(); //个人主页
objXzClgEN.IdSchool = objRow[conXzClg.IdSchool] == DBNull.Value ? null : objRow[conXzClg.IdSchool].ToString().Trim(); //学校流水号
objXzClgEN.IdUni = objRow[conXzClg.IdUni] == DBNull.Value ? null : objRow[conXzClg.IdUni].ToString().Trim(); //id_Uni
objXzClgEN.IsVisible4Tea = clsEntityBase2.TransNullToBool_S(objRow[conXzClg.IsVisible4Tea].ToString().Trim()); //IsVisible4Tea
objXzClgEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[conXzClg.IsVisible].ToString().Trim()); //是否显示
objXzClgEN.OrderNum = objRow[conXzClg.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conXzClg.OrderNum].ToString().Trim()); //序号
objXzClgEN.ModifyDate = objRow[conXzClg.ModifyDate] == DBNull.Value ? null : objRow[conXzClg.ModifyDate].ToString().Trim(); //修改日期
objXzClgEN.ModifyUserId = objRow[conXzClg.ModifyUserId] == DBNull.Value ? null : objRow[conXzClg.ModifyUserId].ToString().Trim(); //修改人
objXzClgEN.Memo = objRow[conXzClg.Memo] == DBNull.Value ? null : objRow[conXzClg.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objXzClgEN.IdXzCollege, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objXzClgEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objXzClgCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsXzClgEN> GetSubObjLstCache(clsXzClgEN objXzClgCond)
{
List<clsXzClgEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsXzClgEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conXzClg.AttributeName)
{
if (objXzClgCond.IsUpdated(strFldName) == false) continue;
if (objXzClgCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objXzClgCond[strFldName].ToString());
}
else
{
if (objXzClgCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objXzClgCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objXzClgCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objXzClgCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objXzClgCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objXzClgCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objXzClgCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objXzClgCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objXzClgCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objXzClgCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objXzClgCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objXzClgCond[strFldName]));
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
public static List<clsXzClgEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsXzClgEN> arrObjLst = new List<clsXzClgEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsXzClgEN objXzClgEN = new clsXzClgEN();
try
{
objXzClgEN.IdXzCollege = objRow[conXzClg.IdXzCollege].ToString().Trim(); //学院流水号
objXzClgEN.CollegeId = objRow[conXzClg.CollegeId].ToString().Trim(); //学院ID
objXzClgEN.CollegeName = objRow[conXzClg.CollegeName].ToString().Trim(); //学院名称
objXzClgEN.CollegeIdInGP = objRow[conXzClg.CollegeIdInGP] == DBNull.Value ? null : objRow[conXzClg.CollegeIdInGP].ToString().Trim(); //CollegeIdInGP
objXzClgEN.ClgEnglishName = objRow[conXzClg.ClgEnglishName] == DBNull.Value ? null : objRow[conXzClg.ClgEnglishName].ToString().Trim(); //ClgEnglishName
objXzClgEN.CollegeNameA = objRow[conXzClg.CollegeNameA].ToString().Trim(); //学院名称简写
objXzClgEN.UserType = objRow[conXzClg.UserType] == DBNull.Value ? null : objRow[conXzClg.UserType].ToString().Trim(); //用户类型
objXzClgEN.PhoneNumber = objRow[conXzClg.PhoneNumber] == DBNull.Value ? null : objRow[conXzClg.PhoneNumber].ToString().Trim(); //电话
objXzClgEN.WebSite = objRow[conXzClg.WebSite] == DBNull.Value ? null : objRow[conXzClg.WebSite].ToString().Trim(); //个人主页
objXzClgEN.IdSchool = objRow[conXzClg.IdSchool] == DBNull.Value ? null : objRow[conXzClg.IdSchool].ToString().Trim(); //学校流水号
objXzClgEN.IdUni = objRow[conXzClg.IdUni] == DBNull.Value ? null : objRow[conXzClg.IdUni].ToString().Trim(); //id_Uni
objXzClgEN.IsVisible4Tea = clsEntityBase2.TransNullToBool_S(objRow[conXzClg.IsVisible4Tea].ToString().Trim()); //IsVisible4Tea
objXzClgEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[conXzClg.IsVisible].ToString().Trim()); //是否显示
objXzClgEN.OrderNum = objRow[conXzClg.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conXzClg.OrderNum].ToString().Trim()); //序号
objXzClgEN.ModifyDate = objRow[conXzClg.ModifyDate] == DBNull.Value ? null : objRow[conXzClg.ModifyDate].ToString().Trim(); //修改日期
objXzClgEN.ModifyUserId = objRow[conXzClg.ModifyUserId] == DBNull.Value ? null : objRow[conXzClg.ModifyUserId].ToString().Trim(); //修改人
objXzClgEN.Memo = objRow[conXzClg.Memo] == DBNull.Value ? null : objRow[conXzClg.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objXzClgEN.IdXzCollege, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objXzClgEN);
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
public static List<clsXzClgEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsXzClgEN> arrObjLst = new List<clsXzClgEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsXzClgEN objXzClgEN = new clsXzClgEN();
try
{
objXzClgEN.IdXzCollege = objRow[conXzClg.IdXzCollege].ToString().Trim(); //学院流水号
objXzClgEN.CollegeId = objRow[conXzClg.CollegeId].ToString().Trim(); //学院ID
objXzClgEN.CollegeName = objRow[conXzClg.CollegeName].ToString().Trim(); //学院名称
objXzClgEN.CollegeIdInGP = objRow[conXzClg.CollegeIdInGP] == DBNull.Value ? null : objRow[conXzClg.CollegeIdInGP].ToString().Trim(); //CollegeIdInGP
objXzClgEN.ClgEnglishName = objRow[conXzClg.ClgEnglishName] == DBNull.Value ? null : objRow[conXzClg.ClgEnglishName].ToString().Trim(); //ClgEnglishName
objXzClgEN.CollegeNameA = objRow[conXzClg.CollegeNameA].ToString().Trim(); //学院名称简写
objXzClgEN.UserType = objRow[conXzClg.UserType] == DBNull.Value ? null : objRow[conXzClg.UserType].ToString().Trim(); //用户类型
objXzClgEN.PhoneNumber = objRow[conXzClg.PhoneNumber] == DBNull.Value ? null : objRow[conXzClg.PhoneNumber].ToString().Trim(); //电话
objXzClgEN.WebSite = objRow[conXzClg.WebSite] == DBNull.Value ? null : objRow[conXzClg.WebSite].ToString().Trim(); //个人主页
objXzClgEN.IdSchool = objRow[conXzClg.IdSchool] == DBNull.Value ? null : objRow[conXzClg.IdSchool].ToString().Trim(); //学校流水号
objXzClgEN.IdUni = objRow[conXzClg.IdUni] == DBNull.Value ? null : objRow[conXzClg.IdUni].ToString().Trim(); //id_Uni
objXzClgEN.IsVisible4Tea = clsEntityBase2.TransNullToBool_S(objRow[conXzClg.IsVisible4Tea].ToString().Trim()); //IsVisible4Tea
objXzClgEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[conXzClg.IsVisible].ToString().Trim()); //是否显示
objXzClgEN.OrderNum = objRow[conXzClg.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conXzClg.OrderNum].ToString().Trim()); //序号
objXzClgEN.ModifyDate = objRow[conXzClg.ModifyDate] == DBNull.Value ? null : objRow[conXzClg.ModifyDate].ToString().Trim(); //修改日期
objXzClgEN.ModifyUserId = objRow[conXzClg.ModifyUserId] == DBNull.Value ? null : objRow[conXzClg.ModifyUserId].ToString().Trim(); //修改人
objXzClgEN.Memo = objRow[conXzClg.Memo] == DBNull.Value ? null : objRow[conXzClg.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objXzClgEN.IdXzCollege, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objXzClgEN);
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
List<clsXzClgEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsXzClgEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsXzClgEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsXzClgEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsXzClgEN> arrObjLst = new List<clsXzClgEN>(); 
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
	clsXzClgEN objXzClgEN = new clsXzClgEN();
try
{
objXzClgEN.IdXzCollege = objRow[conXzClg.IdXzCollege].ToString().Trim(); //学院流水号
objXzClgEN.CollegeId = objRow[conXzClg.CollegeId].ToString().Trim(); //学院ID
objXzClgEN.CollegeName = objRow[conXzClg.CollegeName].ToString().Trim(); //学院名称
objXzClgEN.CollegeIdInGP = objRow[conXzClg.CollegeIdInGP] == DBNull.Value ? null : objRow[conXzClg.CollegeIdInGP].ToString().Trim(); //CollegeIdInGP
objXzClgEN.ClgEnglishName = objRow[conXzClg.ClgEnglishName] == DBNull.Value ? null : objRow[conXzClg.ClgEnglishName].ToString().Trim(); //ClgEnglishName
objXzClgEN.CollegeNameA = objRow[conXzClg.CollegeNameA].ToString().Trim(); //学院名称简写
objXzClgEN.UserType = objRow[conXzClg.UserType] == DBNull.Value ? null : objRow[conXzClg.UserType].ToString().Trim(); //用户类型
objXzClgEN.PhoneNumber = objRow[conXzClg.PhoneNumber] == DBNull.Value ? null : objRow[conXzClg.PhoneNumber].ToString().Trim(); //电话
objXzClgEN.WebSite = objRow[conXzClg.WebSite] == DBNull.Value ? null : objRow[conXzClg.WebSite].ToString().Trim(); //个人主页
objXzClgEN.IdSchool = objRow[conXzClg.IdSchool] == DBNull.Value ? null : objRow[conXzClg.IdSchool].ToString().Trim(); //学校流水号
objXzClgEN.IdUni = objRow[conXzClg.IdUni] == DBNull.Value ? null : objRow[conXzClg.IdUni].ToString().Trim(); //id_Uni
objXzClgEN.IsVisible4Tea = clsEntityBase2.TransNullToBool_S(objRow[conXzClg.IsVisible4Tea].ToString().Trim()); //IsVisible4Tea
objXzClgEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[conXzClg.IsVisible].ToString().Trim()); //是否显示
objXzClgEN.OrderNum = objRow[conXzClg.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conXzClg.OrderNum].ToString().Trim()); //序号
objXzClgEN.ModifyDate = objRow[conXzClg.ModifyDate] == DBNull.Value ? null : objRow[conXzClg.ModifyDate].ToString().Trim(); //修改日期
objXzClgEN.ModifyUserId = objRow[conXzClg.ModifyUserId] == DBNull.Value ? null : objRow[conXzClg.ModifyUserId].ToString().Trim(); //修改人
objXzClgEN.Memo = objRow[conXzClg.Memo] == DBNull.Value ? null : objRow[conXzClg.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objXzClgEN.IdXzCollege, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objXzClgEN);
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
public static List<clsXzClgEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsXzClgEN> arrObjLst = new List<clsXzClgEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsXzClgEN objXzClgEN = new clsXzClgEN();
try
{
objXzClgEN.IdXzCollege = objRow[conXzClg.IdXzCollege].ToString().Trim(); //学院流水号
objXzClgEN.CollegeId = objRow[conXzClg.CollegeId].ToString().Trim(); //学院ID
objXzClgEN.CollegeName = objRow[conXzClg.CollegeName].ToString().Trim(); //学院名称
objXzClgEN.CollegeIdInGP = objRow[conXzClg.CollegeIdInGP] == DBNull.Value ? null : objRow[conXzClg.CollegeIdInGP].ToString().Trim(); //CollegeIdInGP
objXzClgEN.ClgEnglishName = objRow[conXzClg.ClgEnglishName] == DBNull.Value ? null : objRow[conXzClg.ClgEnglishName].ToString().Trim(); //ClgEnglishName
objXzClgEN.CollegeNameA = objRow[conXzClg.CollegeNameA].ToString().Trim(); //学院名称简写
objXzClgEN.UserType = objRow[conXzClg.UserType] == DBNull.Value ? null : objRow[conXzClg.UserType].ToString().Trim(); //用户类型
objXzClgEN.PhoneNumber = objRow[conXzClg.PhoneNumber] == DBNull.Value ? null : objRow[conXzClg.PhoneNumber].ToString().Trim(); //电话
objXzClgEN.WebSite = objRow[conXzClg.WebSite] == DBNull.Value ? null : objRow[conXzClg.WebSite].ToString().Trim(); //个人主页
objXzClgEN.IdSchool = objRow[conXzClg.IdSchool] == DBNull.Value ? null : objRow[conXzClg.IdSchool].ToString().Trim(); //学校流水号
objXzClgEN.IdUni = objRow[conXzClg.IdUni] == DBNull.Value ? null : objRow[conXzClg.IdUni].ToString().Trim(); //id_Uni
objXzClgEN.IsVisible4Tea = clsEntityBase2.TransNullToBool_S(objRow[conXzClg.IsVisible4Tea].ToString().Trim()); //IsVisible4Tea
objXzClgEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[conXzClg.IsVisible].ToString().Trim()); //是否显示
objXzClgEN.OrderNum = objRow[conXzClg.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conXzClg.OrderNum].ToString().Trim()); //序号
objXzClgEN.ModifyDate = objRow[conXzClg.ModifyDate] == DBNull.Value ? null : objRow[conXzClg.ModifyDate].ToString().Trim(); //修改日期
objXzClgEN.ModifyUserId = objRow[conXzClg.ModifyUserId] == DBNull.Value ? null : objRow[conXzClg.ModifyUserId].ToString().Trim(); //修改人
objXzClgEN.Memo = objRow[conXzClg.Memo] == DBNull.Value ? null : objRow[conXzClg.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objXzClgEN.IdXzCollege, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objXzClgEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsXzClgEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsXzClgEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsXzClgEN> arrObjLst = new List<clsXzClgEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsXzClgEN objXzClgEN = new clsXzClgEN();
try
{
objXzClgEN.IdXzCollege = objRow[conXzClg.IdXzCollege].ToString().Trim(); //学院流水号
objXzClgEN.CollegeId = objRow[conXzClg.CollegeId].ToString().Trim(); //学院ID
objXzClgEN.CollegeName = objRow[conXzClg.CollegeName].ToString().Trim(); //学院名称
objXzClgEN.CollegeIdInGP = objRow[conXzClg.CollegeIdInGP] == DBNull.Value ? null : objRow[conXzClg.CollegeIdInGP].ToString().Trim(); //CollegeIdInGP
objXzClgEN.ClgEnglishName = objRow[conXzClg.ClgEnglishName] == DBNull.Value ? null : objRow[conXzClg.ClgEnglishName].ToString().Trim(); //ClgEnglishName
objXzClgEN.CollegeNameA = objRow[conXzClg.CollegeNameA].ToString().Trim(); //学院名称简写
objXzClgEN.UserType = objRow[conXzClg.UserType] == DBNull.Value ? null : objRow[conXzClg.UserType].ToString().Trim(); //用户类型
objXzClgEN.PhoneNumber = objRow[conXzClg.PhoneNumber] == DBNull.Value ? null : objRow[conXzClg.PhoneNumber].ToString().Trim(); //电话
objXzClgEN.WebSite = objRow[conXzClg.WebSite] == DBNull.Value ? null : objRow[conXzClg.WebSite].ToString().Trim(); //个人主页
objXzClgEN.IdSchool = objRow[conXzClg.IdSchool] == DBNull.Value ? null : objRow[conXzClg.IdSchool].ToString().Trim(); //学校流水号
objXzClgEN.IdUni = objRow[conXzClg.IdUni] == DBNull.Value ? null : objRow[conXzClg.IdUni].ToString().Trim(); //id_Uni
objXzClgEN.IsVisible4Tea = clsEntityBase2.TransNullToBool_S(objRow[conXzClg.IsVisible4Tea].ToString().Trim()); //IsVisible4Tea
objXzClgEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[conXzClg.IsVisible].ToString().Trim()); //是否显示
objXzClgEN.OrderNum = objRow[conXzClg.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conXzClg.OrderNum].ToString().Trim()); //序号
objXzClgEN.ModifyDate = objRow[conXzClg.ModifyDate] == DBNull.Value ? null : objRow[conXzClg.ModifyDate].ToString().Trim(); //修改日期
objXzClgEN.ModifyUserId = objRow[conXzClg.ModifyUserId] == DBNull.Value ? null : objRow[conXzClg.ModifyUserId].ToString().Trim(); //修改人
objXzClgEN.Memo = objRow[conXzClg.Memo] == DBNull.Value ? null : objRow[conXzClg.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objXzClgEN.IdXzCollege, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objXzClgEN);
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
public static List<clsXzClgEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsXzClgEN> arrObjLst = new List<clsXzClgEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsXzClgEN objXzClgEN = new clsXzClgEN();
try
{
objXzClgEN.IdXzCollege = objRow[conXzClg.IdXzCollege].ToString().Trim(); //学院流水号
objXzClgEN.CollegeId = objRow[conXzClg.CollegeId].ToString().Trim(); //学院ID
objXzClgEN.CollegeName = objRow[conXzClg.CollegeName].ToString().Trim(); //学院名称
objXzClgEN.CollegeIdInGP = objRow[conXzClg.CollegeIdInGP] == DBNull.Value ? null : objRow[conXzClg.CollegeIdInGP].ToString().Trim(); //CollegeIdInGP
objXzClgEN.ClgEnglishName = objRow[conXzClg.ClgEnglishName] == DBNull.Value ? null : objRow[conXzClg.ClgEnglishName].ToString().Trim(); //ClgEnglishName
objXzClgEN.CollegeNameA = objRow[conXzClg.CollegeNameA].ToString().Trim(); //学院名称简写
objXzClgEN.UserType = objRow[conXzClg.UserType] == DBNull.Value ? null : objRow[conXzClg.UserType].ToString().Trim(); //用户类型
objXzClgEN.PhoneNumber = objRow[conXzClg.PhoneNumber] == DBNull.Value ? null : objRow[conXzClg.PhoneNumber].ToString().Trim(); //电话
objXzClgEN.WebSite = objRow[conXzClg.WebSite] == DBNull.Value ? null : objRow[conXzClg.WebSite].ToString().Trim(); //个人主页
objXzClgEN.IdSchool = objRow[conXzClg.IdSchool] == DBNull.Value ? null : objRow[conXzClg.IdSchool].ToString().Trim(); //学校流水号
objXzClgEN.IdUni = objRow[conXzClg.IdUni] == DBNull.Value ? null : objRow[conXzClg.IdUni].ToString().Trim(); //id_Uni
objXzClgEN.IsVisible4Tea = clsEntityBase2.TransNullToBool_S(objRow[conXzClg.IsVisible4Tea].ToString().Trim()); //IsVisible4Tea
objXzClgEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[conXzClg.IsVisible].ToString().Trim()); //是否显示
objXzClgEN.OrderNum = objRow[conXzClg.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conXzClg.OrderNum].ToString().Trim()); //序号
objXzClgEN.ModifyDate = objRow[conXzClg.ModifyDate] == DBNull.Value ? null : objRow[conXzClg.ModifyDate].ToString().Trim(); //修改日期
objXzClgEN.ModifyUserId = objRow[conXzClg.ModifyUserId] == DBNull.Value ? null : objRow[conXzClg.ModifyUserId].ToString().Trim(); //修改人
objXzClgEN.Memo = objRow[conXzClg.Memo] == DBNull.Value ? null : objRow[conXzClg.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objXzClgEN.IdXzCollege, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objXzClgEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsXzClgEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsXzClgEN> arrObjLst = new List<clsXzClgEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsXzClgEN objXzClgEN = new clsXzClgEN();
try
{
objXzClgEN.IdXzCollege = objRow[conXzClg.IdXzCollege].ToString().Trim(); //学院流水号
objXzClgEN.CollegeId = objRow[conXzClg.CollegeId].ToString().Trim(); //学院ID
objXzClgEN.CollegeName = objRow[conXzClg.CollegeName].ToString().Trim(); //学院名称
objXzClgEN.CollegeIdInGP = objRow[conXzClg.CollegeIdInGP] == DBNull.Value ? null : objRow[conXzClg.CollegeIdInGP].ToString().Trim(); //CollegeIdInGP
objXzClgEN.ClgEnglishName = objRow[conXzClg.ClgEnglishName] == DBNull.Value ? null : objRow[conXzClg.ClgEnglishName].ToString().Trim(); //ClgEnglishName
objXzClgEN.CollegeNameA = objRow[conXzClg.CollegeNameA].ToString().Trim(); //学院名称简写
objXzClgEN.UserType = objRow[conXzClg.UserType] == DBNull.Value ? null : objRow[conXzClg.UserType].ToString().Trim(); //用户类型
objXzClgEN.PhoneNumber = objRow[conXzClg.PhoneNumber] == DBNull.Value ? null : objRow[conXzClg.PhoneNumber].ToString().Trim(); //电话
objXzClgEN.WebSite = objRow[conXzClg.WebSite] == DBNull.Value ? null : objRow[conXzClg.WebSite].ToString().Trim(); //个人主页
objXzClgEN.IdSchool = objRow[conXzClg.IdSchool] == DBNull.Value ? null : objRow[conXzClg.IdSchool].ToString().Trim(); //学校流水号
objXzClgEN.IdUni = objRow[conXzClg.IdUni] == DBNull.Value ? null : objRow[conXzClg.IdUni].ToString().Trim(); //id_Uni
objXzClgEN.IsVisible4Tea = clsEntityBase2.TransNullToBool_S(objRow[conXzClg.IsVisible4Tea].ToString().Trim()); //IsVisible4Tea
objXzClgEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[conXzClg.IsVisible].ToString().Trim()); //是否显示
objXzClgEN.OrderNum = objRow[conXzClg.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conXzClg.OrderNum].ToString().Trim()); //序号
objXzClgEN.ModifyDate = objRow[conXzClg.ModifyDate] == DBNull.Value ? null : objRow[conXzClg.ModifyDate].ToString().Trim(); //修改日期
objXzClgEN.ModifyUserId = objRow[conXzClg.ModifyUserId] == DBNull.Value ? null : objRow[conXzClg.ModifyUserId].ToString().Trim(); //修改人
objXzClgEN.Memo = objRow[conXzClg.Memo] == DBNull.Value ? null : objRow[conXzClg.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objXzClgEN.IdXzCollege, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objXzClgEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objXzClgEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetXzClg(ref clsXzClgEN objXzClgEN)
{
bool bolResult = XzClgDA.GetXzClg(ref objXzClgEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "strIdXzCollege">表关键字</param>
 /// <returns>表对象</returns>
public static clsXzClgEN GetObjByIdXzCollege(string strIdXzCollege)
{
if (strIdXzCollege.IndexOf(' ') >=0)
{
var strMsg = string.Format("(errid:Busi000079)在表中,关键字[strIdXzCollege]中不能有空格!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
if (string.IsNullOrEmpty(strIdXzCollege) == true)
{
var strMsg = string.Format("(errid:Busi000020)在表中,关键字[strIdXzCollege]不能为空!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
clsXzClgEN objXzClgEN = XzClgDA.GetObjByIdXzCollege(strIdXzCollege);
return objXzClgEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsXzClgEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsXzClgEN objXzClgEN = XzClgDA.GetFirstObj(strWhereCond);
 return objXzClgEN;
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
public static clsXzClgEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsXzClgEN objXzClgEN = XzClgDA.GetObjByDataRow(objRow);
 return objXzClgEN;
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
public static clsXzClgEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsXzClgEN objXzClgEN = XzClgDA.GetObjByDataRow(objRow);
 return objXzClgEN;
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
 /// <param name = "strIdXzCollege">所给的关键字</param>
 /// <param name = "lstXzClgObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsXzClgEN GetObjByIdXzCollegeFromList(string strIdXzCollege, List<clsXzClgEN> lstXzClgObjLst)
{
foreach (clsXzClgEN objXzClgEN in lstXzClgObjLst)
{
if (objXzClgEN.IdXzCollege == strIdXzCollege)
{
return objXzClgEN;
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
public static string GetFirstID_S(string strWhereCond) 
{
 string strIdXzCollege;
 try
 {
 strIdXzCollege = new clsXzClgDA().GetFirstID(strWhereCond);
 return strIdXzCollege;
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
 arrList = XzClgDA.GetID(strWhereCond);
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
bool bolIsExist = XzClgDA.IsExistCondRec(strWhereCond);
return bolIsExist;
}

 /// <summary>
 /// 判断当前表中是否存在给定关键字值的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExist)
 /// </summary>
 /// <param name = "strIdXzCollege">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public static bool IsExist(string strIdXzCollege)
{
if (string.IsNullOrEmpty(strIdXzCollege) == true)
{
var strMsg = string.Format("(errid:Busi000027)在表中,关键字[strIdXzCollege]不能为空!!(from {0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
//检测记录是否存在
bool bolIsExist = XzClgDA.IsExist(strIdXzCollege);
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
 bolIsExist = clsXzClgDA.IsExistTable();
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
 bolIsExist = XzClgDA.IsExistTable(strTabName);
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
 /// <param name = "objXzClgEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecordBySql2(clsXzClgEN objXzClgEN, bool bolIsNeedCheckUniqueness=true)
{
 if (string.IsNullOrEmpty(objXzClgEN.IdXzCollege) == true)
 {
string strMsg = string.Format("添加记录时,关键字不能为空!(from {0})\r\n", 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
 if (clsXzClgBL.IsExist(objXzClgEN.IdXzCollege) == true)
 {
string strMsg = string.Format("添加记录时,关键字:[{0}]已经存在!(from {1})\r\n", objXzClgEN.IdXzCollege, 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
try
{
bool bolResult = XzClgDA.AddNewRecordBySQL2(objXzClgEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsXzClgBL.ReFreshCache();

if (clsXzClgBL.relatedActions != null)
{
clsXzClgBL.relatedActions.UpdRelaTabDate(objXzClgEN.IdXzCollege, "SetUpdDate");
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
 /// <param name = "objXzClgEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordBySql2WithReturnKey(clsXzClgEN objXzClgEN, bool bolIsNeedCheckUniqueness=true)
{
 if (string.IsNullOrEmpty(objXzClgEN.IdXzCollege) == true)
 {
string strMsg = string.Format("添加记录时,关键字不能为空!(from {{0}})", 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
 if (clsXzClgBL.IsExist(objXzClgEN.IdXzCollege) == true)
 {
string strMsg = string.Format("添加记录时,关键字:[{0}]已经存在!(from {1})\r\n", objXzClgEN.IdXzCollege, 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
try
{
string strKey = XzClgDA.AddNewRecordBySQL2WithReturnKey(objXzClgEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsXzClgBL.ReFreshCache();

if (clsXzClgBL.relatedActions != null)
{
clsXzClgBL.relatedActions.UpdRelaTabDate(objXzClgEN.IdXzCollege, "SetUpdDate");
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
 /// <param name = "objXzClgEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(clsXzClgEN objXzClgEN)
{
try
{
bool bolResult = XzClgDA.Update(objXzClgEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsXzClgBL.ReFreshCache();

if (clsXzClgBL.relatedActions != null)
{
clsXzClgBL.relatedActions.UpdRelaTabDate(objXzClgEN.IdXzCollege, "SetUpdDate");
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
 /// <param name = "objXzClgEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateBySql2(clsXzClgEN objXzClgEN)
{
 if (string.IsNullOrEmpty(objXzClgEN.IdXzCollege) == true)
 {
var strMsg = string.Format("(errid:Busi000065)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = XzClgDA.UpdateBySql2(objXzClgEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsXzClgBL.ReFreshCache();

if (clsXzClgBL.relatedActions != null)
{
clsXzClgBL.relatedActions.UpdRelaTabDate(objXzClgEN.IdXzCollege, "SetUpdDate");
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
 /// <param name = "strIdXzCollege">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int DelRecord(string strIdXzCollege)
{
try
{
 clsXzClgEN objXzClgEN = clsXzClgBL.GetObjByIdXzCollege(strIdXzCollege);

if (clsXzClgBL.relatedActions != null)
{
clsXzClgBL.relatedActions.UpdRelaTabDate(objXzClgEN.IdXzCollege, "SetUpdDate");
}
if (objXzClgEN != null)
{
int intRecNum = XzClgDA.DelRecord(strIdXzCollege);
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
/// <param name="strIdXzCollege">表关键字</param>
/// <returns></returns>
public static bool DelRecordEx(string strIdXzCollege )
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsXzClgDA.GetSpecSQLObj();
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
//删除与表:[XzClg]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conXzClg.IdXzCollege,
//strIdXzCollege);
//        clsXzClgBL.DelXzClgsByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsXzClgBL.DelRecord(strIdXzCollege, objConnection, objSqlTransaction);
objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsXzClgBLEx", "DelRecordEx", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("扩展删除记录出错:{0}!keyId = {1}.({2})",
objException.Message,
strIdXzCollege, clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "strIdXzCollege">给定的关键字值</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回删除是否成功?</returns>
public static bool DelRecord(string strIdXzCollege, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
if (clsXzClgBL.relatedActions != null)
{
clsXzClgBL.relatedActions.UpdRelaTabDate(strIdXzCollege, "UpdRelaTabDate");
}
bool bolResult = XzClgDA.DelRecord(strIdXzCollege,objSqlConnection,objSqlTransaction);
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
 /// <param name = "arrIdXzCollegeLst">给定的关键字值列表</param>
 /// <returns>返回删除的记录数</returns>
public static int DelXzClgs(List<string> arrIdXzCollegeLst)
{
if (arrIdXzCollegeLst.Count == 0) return 0;
try
{
if (clsXzClgBL.relatedActions != null)
{
foreach (var strIdXzCollege in arrIdXzCollegeLst)
{
clsXzClgBL.relatedActions.UpdRelaTabDate(strIdXzCollege, "UpdRelaTabDate");
}
}
int intDelRecNum = XzClgDA.DelXzClg(arrIdXzCollegeLst);
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
public static int DelXzClgsByCond(string strWhereCond)
{
try
{
if (clsXzClgBL.relatedActions != null)
{
List<string> arrIdXzCollege = GetPrimaryKeyID_S(strWhereCond);
foreach (var strIdXzCollege in arrIdXzCollege)
{
clsXzClgBL.relatedActions.UpdRelaTabDate(strIdXzCollege, "UpdRelaTabDate");
}
}
int intRecNum = XzClgDA.DelXzClg(strWhereCond);
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
/// 这里仅仅是演示函数,使用时请复制到扩展类:[XzClg]中改名为:[DelRecord4MultiTabEx]使用
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DelRecord4MultiTab)
/// </summary>
/// <param name="strIdXzCollege">表关键字</param>
/// <returns></returns>
public static bool DelRecord4MultiTab(string strIdXzCollege)
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsXzClgDA.GetSpecSQLObj();
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
//删除与表:[XzClg]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conStudent.id_College,
//strid_College);
//        clsStudentBL.DelStudentsByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsXzClgBL.DelRecord(strIdXzCollege, objConnection, objSqlTransaction);
                objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsXzClgBL", "DelRecord4MultiTab", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("删除多表记录出错:{0}!keyId = {1}.({2})",
objException.Message,
strIdXzCollege, clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "objXzClgENS">源对象</param>
 /// <param name = "objXzClgENT">目标对象</param>
 public static void CopyTo(clsXzClgEN objXzClgENS, clsXzClgEN objXzClgENT)
{
try
{
objXzClgENT.IdXzCollege = objXzClgENS.IdXzCollege; //学院流水号
objXzClgENT.CollegeId = objXzClgENS.CollegeId; //学院ID
objXzClgENT.CollegeName = objXzClgENS.CollegeName; //学院名称
objXzClgENT.CollegeIdInGP = objXzClgENS.CollegeIdInGP; //CollegeIdInGP
objXzClgENT.ClgEnglishName = objXzClgENS.ClgEnglishName; //ClgEnglishName
objXzClgENT.CollegeNameA = objXzClgENS.CollegeNameA; //学院名称简写
objXzClgENT.UserType = objXzClgENS.UserType; //用户类型
objXzClgENT.PhoneNumber = objXzClgENS.PhoneNumber; //电话
objXzClgENT.WebSite = objXzClgENS.WebSite; //个人主页
objXzClgENT.IdSchool = objXzClgENS.IdSchool; //学校流水号
objXzClgENT.IdUni = objXzClgENS.IdUni; //id_Uni
objXzClgENT.IsVisible4Tea = objXzClgENS.IsVisible4Tea; //IsVisible4Tea
objXzClgENT.IsVisible = objXzClgENS.IsVisible; //是否显示
objXzClgENT.OrderNum = objXzClgENS.OrderNum; //序号
objXzClgENT.ModifyDate = objXzClgENS.ModifyDate; //修改日期
objXzClgENT.ModifyUserId = objXzClgENS.ModifyUserId; //修改人
objXzClgENT.Memo = objXzClgENS.Memo; //备注
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
 /// <param name = "objXzClgEN">源简化对象</param>
 public static void SetUpdFlag(clsXzClgEN objXzClgEN)
{
try
{
objXzClgEN.ClearUpdateState();
   string strsfUpdFldSetStr = objXzClgEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(conXzClg.IdXzCollege, new clsStrCompareIgnoreCase())  ==  true)
{
objXzClgEN.IdXzCollege = objXzClgEN.IdXzCollege; //学院流水号
}
if (arrFldSet.Contains(conXzClg.CollegeId, new clsStrCompareIgnoreCase())  ==  true)
{
objXzClgEN.CollegeId = objXzClgEN.CollegeId; //学院ID
}
if (arrFldSet.Contains(conXzClg.CollegeName, new clsStrCompareIgnoreCase())  ==  true)
{
objXzClgEN.CollegeName = objXzClgEN.CollegeName; //学院名称
}
if (arrFldSet.Contains(conXzClg.CollegeIdInGP, new clsStrCompareIgnoreCase())  ==  true)
{
objXzClgEN.CollegeIdInGP = objXzClgEN.CollegeIdInGP == "[null]" ? null :  objXzClgEN.CollegeIdInGP; //CollegeIdInGP
}
if (arrFldSet.Contains(conXzClg.ClgEnglishName, new clsStrCompareIgnoreCase())  ==  true)
{
objXzClgEN.ClgEnglishName = objXzClgEN.ClgEnglishName == "[null]" ? null :  objXzClgEN.ClgEnglishName; //ClgEnglishName
}
if (arrFldSet.Contains(conXzClg.CollegeNameA, new clsStrCompareIgnoreCase())  ==  true)
{
objXzClgEN.CollegeNameA = objXzClgEN.CollegeNameA; //学院名称简写
}
if (arrFldSet.Contains(conXzClg.UserType, new clsStrCompareIgnoreCase())  ==  true)
{
objXzClgEN.UserType = objXzClgEN.UserType == "[null]" ? null :  objXzClgEN.UserType; //用户类型
}
if (arrFldSet.Contains(conXzClg.PhoneNumber, new clsStrCompareIgnoreCase())  ==  true)
{
objXzClgEN.PhoneNumber = objXzClgEN.PhoneNumber == "[null]" ? null :  objXzClgEN.PhoneNumber; //电话
}
if (arrFldSet.Contains(conXzClg.WebSite, new clsStrCompareIgnoreCase())  ==  true)
{
objXzClgEN.WebSite = objXzClgEN.WebSite == "[null]" ? null :  objXzClgEN.WebSite; //个人主页
}
if (arrFldSet.Contains(conXzClg.IdSchool, new clsStrCompareIgnoreCase())  ==  true)
{
objXzClgEN.IdSchool = objXzClgEN.IdSchool == "[null]" ? null :  objXzClgEN.IdSchool; //学校流水号
}
if (arrFldSet.Contains(conXzClg.IdUni, new clsStrCompareIgnoreCase())  ==  true)
{
objXzClgEN.IdUni = objXzClgEN.IdUni == "[null]" ? null :  objXzClgEN.IdUni; //id_Uni
}
if (arrFldSet.Contains(conXzClg.IsVisible4Tea, new clsStrCompareIgnoreCase())  ==  true)
{
objXzClgEN.IsVisible4Tea = objXzClgEN.IsVisible4Tea; //IsVisible4Tea
}
if (arrFldSet.Contains(conXzClg.IsVisible, new clsStrCompareIgnoreCase())  ==  true)
{
objXzClgEN.IsVisible = objXzClgEN.IsVisible; //是否显示
}
if (arrFldSet.Contains(conXzClg.OrderNum, new clsStrCompareIgnoreCase())  ==  true)
{
objXzClgEN.OrderNum = objXzClgEN.OrderNum; //序号
}
if (arrFldSet.Contains(conXzClg.ModifyDate, new clsStrCompareIgnoreCase())  ==  true)
{
objXzClgEN.ModifyDate = objXzClgEN.ModifyDate == "[null]" ? null :  objXzClgEN.ModifyDate; //修改日期
}
if (arrFldSet.Contains(conXzClg.ModifyUserId, new clsStrCompareIgnoreCase())  ==  true)
{
objXzClgEN.ModifyUserId = objXzClgEN.ModifyUserId == "[null]" ? null :  objXzClgEN.ModifyUserId; //修改人
}
if (arrFldSet.Contains(conXzClg.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objXzClgEN.Memo = objXzClgEN.Memo == "[null]" ? null :  objXzClgEN.Memo; //备注
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
 /// <param name = "objXzClgEN">源简化对象</param>
 public static void AccessFldValueNull(clsXzClgEN objXzClgEN)
{
try
{
if (objXzClgEN.CollegeIdInGP == "[null]") objXzClgEN.CollegeIdInGP = null; //CollegeIdInGP
if (objXzClgEN.ClgEnglishName == "[null]") objXzClgEN.ClgEnglishName = null; //ClgEnglishName
if (objXzClgEN.UserType == "[null]") objXzClgEN.UserType = null; //用户类型
if (objXzClgEN.PhoneNumber == "[null]") objXzClgEN.PhoneNumber = null; //电话
if (objXzClgEN.WebSite == "[null]") objXzClgEN.WebSite = null; //个人主页
if (objXzClgEN.IdSchool == "[null]") objXzClgEN.IdSchool = null; //学校流水号
if (objXzClgEN.IdUni == "[null]") objXzClgEN.IdUni = null; //id_Uni
if (objXzClgEN.ModifyDate == "[null]") objXzClgEN.ModifyDate = null; //修改日期
if (objXzClgEN.ModifyUserId == "[null]") objXzClgEN.ModifyUserId = null; //修改人
if (objXzClgEN.Memo == "[null]") objXzClgEN.Memo = null; //备注
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
public static void CheckPropertyNew(clsXzClgEN objXzClgEN)
{
 XzClgDA.CheckPropertyNew(objXzClgEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(clsXzClgEN objXzClgEN)
{
 XzClgDA.CheckProperty4Condition(objXzClgEN);
 }


 #endregion 检查对象属性


 #region 绑定下拉框

 /// <summary>
 /// 绑定基于Win的下拉框
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_TabFeature_ComboBoxBindFunction)
 /// </summary>
 /// <param name = "objComboBox">需要绑定当前表的下拉框</param>

 /// <param name = "strIdSchool"></param>
public static void BindCbo_IdXzCollege(System.Windows.Forms.ComboBox objComboBox , string strIdSchool)
{
//为数据源为表的下拉框设置内容
string strCondition = string.Format("1 =1 Order By {0}", conXzClg.IdXzCollege); 
List<clsXzClgEN> arrObjLst = clsXzClgBL.GetObjLst(strCondition);
var arrObjLstSel = arrObjLst.Where(x=>x.IdSchool == strIdSchool).ToList();
//初始化一个对象列表
//插入第0项。在第0项中插入“请选择...”,为了方便用户,与WEB方式类似。
clsXzClgEN objXzClgEN = new clsXzClgEN()
{
IdXzCollege = "0",
CollegeName = "选[学院]..."
};
arrObjLstSel.Insert(0, objXzClgEN);
//设置下拉框的数据源、以及设置值项、显示项
objComboBox.ValueMember = conXzClg.IdXzCollege;
objComboBox.DisplayMember = conXzClg.CollegeName;
objComboBox.DataSource = arrObjLstSel;
objComboBox.SelectedIndex = 0;
}

 /// <summary>
 /// 绑定基于Web的下拉框
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_TabFeature_DdlBindFunction)
 /// </summary>
 /// <param name = "objDDL">需要绑定当前表的下拉框</param>

 /// <param name = "strIdSchool"></param>
public static void BindDdl_IdXzCollege(System.Web.UI.WebControls.DropDownList objDDL , string strIdSchool)
{
//为数据源于表的下拉框设置内容
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[学院]...","0");
string strCondition = string.Format("1 =1 Order By {0}", conXzClg.IdXzCollege); 
IEnumerable<clsXzClgEN> arrObjLst = clsXzClgBL.GetObjLst(strCondition);
var arrObjLstSel = arrObjLst.Where(x=>x.IdSchool == strIdSchool).ToList();
objDDL.DataValueField = conXzClg.IdXzCollege;
objDDL.DataTextField = conXzClg.CollegeName;
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
public static void BindDdl_IdXzCollegeCache(System.Web.UI.WebControls.DropDownList objDDL)
{
//为数据源于表的下拉框设置内容
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[学院]...","0");
List<clsXzClgEN> arrXzClgObjLst = GetAllXzClgObjLstCache(); 
objDDL.DataValueField = conXzClg.IdXzCollege;
objDDL.DataTextField = conXzClg.CollegeName;
objDDL.DataSource = arrXzClgObjLst;
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
if (clsXzClgBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsXzClgBL没有刷新缓存机制(clsXzClgBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by IdXzCollege");
//if (arrXzClgObjLstCache == null)
//{
//arrXzClgObjLstCache = XzClgDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "strIdXzCollege">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsXzClgEN GetObjByIdXzCollegeCache(string strIdXzCollege)
{
//获取缓存中的对象列表
string strKey = string.Format("{0}", clsXzClgEN._CurrTabName);
List<clsXzClgEN> arrXzClgObjLstCache = GetObjLstCache();
IEnumerable <clsXzClgEN> arrXzClgObjLst_Sel =
arrXzClgObjLstCache
.Where(x=> x.IdXzCollege == strIdXzCollege 
);
if (arrXzClgObjLst_Sel.Count() == 0)
{
   clsXzClgEN obj = clsXzClgBL.GetObjByIdXzCollege(strIdXzCollege);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
 }
return null;
}
return arrXzClgObjLst_Sel.First();
}

 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecNameByKeyCache)
 /// </summary>
 /// <param name = "strIdXzCollege">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetCollegeNameByIdXzCollegeCache(string strIdXzCollege)
{
if (string.IsNullOrEmpty(strIdXzCollege) == true) return "";
//获取缓存中的对象列表
clsXzClgEN objXzClg = GetObjByIdXzCollegeCache(strIdXzCollege);
if (objXzClg == null) return "";
return objXzClg.CollegeName;
}
 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecNameByKeyCache)
 /// </summary>
 /// <param name = "strIdXzCollege">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetNameByIdXzCollegeCache(string strIdXzCollege)
{
if (string.IsNullOrEmpty(strIdXzCollege) == true) return "";
//获取缓存中的对象列表
clsXzClgEN objXzClg = GetObjByIdXzCollegeCache(strIdXzCollege);
if (objXzClg == null) return "";
return objXzClg.CollegeName;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsXzClgEN> GetAllXzClgObjLstCache()
{
//获取缓存中的对象列表
List<clsXzClgEN> arrXzClgObjLstCache = GetObjLstCache(); 
return arrXzClgObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsXzClgEN> GetObjLstCache()
{
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}", clsXzClgEN._CurrTabName);
List<clsXzClgEN> arrXzClgObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrXzClgObjLstCache;
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
string strKey = string.Format("{0}", clsXzClgEN._CurrTabName);
CacheHelper.Remove(strKey);
clsXzClgEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
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
if (clsXzClgEN._RefreshTimeLst.Count == 0) return "";
return clsXzClgEN._RefreshTimeLst[clsXzClgEN._RefreshTimeLst.Count - 1];
}

 /// <summary>
 /// 刷新缓存.把当前表的缓存以及该表相关视图的缓存清空.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ReFreshCache)
 /// </summary>
public static void ReFreshCache()
{
if (clsXzClgBL.objCommFun4BL != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}", clsXzClgEN._CurrTabName);
CacheHelper.Remove(strKey);
clsXzClgEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
clsXzClgBL.objCommFun4BL.ReFreshCache();
}
}


 #endregion 缓存操作


 #region 检查唯一性


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
public static string Func(string strInFldName, string strOutFldName, string strIdXzCollege)
{
if (strInFldName != conXzClg.IdXzCollege)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (conXzClg.AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", conXzClg.AttributeName));
throw new Exception(strMsg);
}
var objXzClg = clsXzClgBL.GetObjByIdXzCollegeCache(strIdXzCollege);
if (objXzClg == null) return "";
return objXzClg[strOutFldName].ToString();
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
int intRecCount = clsXzClgDA.GetRecCount(strTabName);
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
int intRecCount = clsXzClgDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsXzClgDA.GetRecCount();
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
int intRecCount = clsXzClgDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objXzClgCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsXzClgEN objXzClgCond)
{
List<clsXzClgEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsXzClgEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conXzClg.AttributeName)
{
if (objXzClgCond.IsUpdated(strFldName) == false) continue;
if (objXzClgCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objXzClgCond[strFldName].ToString());
}
else
{
if (objXzClgCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objXzClgCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objXzClgCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objXzClgCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objXzClgCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objXzClgCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objXzClgCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objXzClgCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objXzClgCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objXzClgCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objXzClgCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objXzClgCond[strFldName]));
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
 List<string> arrList = clsXzClgDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = XzClgDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = XzClgDA.GetFldValueNoDistinct(strFldName, strWhereCond);
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
int intRecCount = XzClgDA.SetFldValue(strFldName, strValue, strWhereCond);
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
int intRecCount = clsXzClgDA.SetFldValue(clsXzClgEN._CurrTabName, strFldName, fltValue, strWhereCond);
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
int intRecCount = XzClgDA.SetFldValue( strFldName, intValue, strWhereCond);
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
int intRecCount = clsXzClgDA.SetFldValue(strTabName, strFldName, strValue, strWhereCond);
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
int intRecCount = clsXzClgDA.SetFldValue(strTabName, strFldName, intValue, strWhereCond);
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
int intRecCount = clsXzClgDA.SetFldValue(strTabName, strFldName, fltValue, strWhereCond);
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
  strCreateTabCode.Append("CREATE table [dbo].[XzClg] "); 
 strCreateTabCode.Append(" ( "); 
 // /**学院流水号*/ 
 strCreateTabCode.Append(" IdXzCollege char(4) primary key, "); 
 // /**学院ID*/ 
 strCreateTabCode.Append(" CollegeId varchar(4) not Null, "); 
 // /**学院名称*/ 
 strCreateTabCode.Append(" CollegeName varchar(100) not Null, "); 
 // /**CollegeIdInGP*/ 
 strCreateTabCode.Append(" CollegeIdInGP varchar(6) Null, "); 
 // /**ClgEnglishName*/ 
 strCreateTabCode.Append(" ClgEnglishName varchar(60) Null, "); 
 // /**学院名称简写*/ 
 strCreateTabCode.Append(" CollegeNameA varchar(12) not Null, "); 
 // /**用户类型*/ 
 strCreateTabCode.Append(" UserType varchar(50) Null, "); 
 // /**电话*/ 
 strCreateTabCode.Append(" PhoneNumber varchar(15) Null, "); 
 // /**个人主页*/ 
 strCreateTabCode.Append(" WebSite varchar(60) Null, "); 
 // /**学校流水号*/ 
 strCreateTabCode.Append(" IdSchool char(4) Null, "); 
 // /**id_Uni*/ 
 strCreateTabCode.Append(" IdUni char(4) Null, "); 
 // /**IsVisible4Tea*/ 
 strCreateTabCode.Append(" IsVisible4Tea bit Null, "); 
 // /**是否显示*/ 
 strCreateTabCode.Append(" IsVisible bit Null, "); 
 // /**序号*/ 
 strCreateTabCode.Append(" OrderNum int Null, "); 
 // /**修改日期*/ 
 strCreateTabCode.Append(" ModifyDate varchar(20) Null, "); 
 // /**修改人*/ 
 strCreateTabCode.Append(" ModifyUserId varchar(18) Null, "); 
 // /**备注*/ 
 strCreateTabCode.Append(" Memo varchar(1000) Null ");
 strCreateTabCode.Append(") "); 
  strCreateTabCode.Append("ON [PRIMARY] ");
  return strCreateTabCode.ToString();
}



 #endregion 表操作
}
 /// <summary>
 /// 学院(XzClg)
 /// 数据源类型:表
 /// (AutoGCLib.CommFun4BL4CSharp:GeneCode_This)
 /// </summary>
public class  clsCommFun4BL4XzClg : clsCommFun4BL
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
clsXzClgBL.ReFreshThisCache();
}
}

}