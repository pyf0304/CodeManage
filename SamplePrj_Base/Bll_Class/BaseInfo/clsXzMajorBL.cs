﻿
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsXzMajorBL
 表名:XzMajor(01160026)
 * 版本:2023.03.10.1(服务器:WIN-SRV103-116)
 日期:2023/03/11 03:04:26
 生成者:pyf
 生成服务器IP:
 工程名称:简单工程样例(0116)
 CM工程:简单样例后端(变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433SimplePrj
 PrjDataBaseId:0111
 模块中文名:基本信息(BaseInfo)
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
using SimplePrj.Entity;
using System.Data; 
using System.Data.SqlClient; 
using SimplePrj.DAL;

namespace SimplePrj.BusinessLogic
{
public static class clsXzMajorBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "strid_Major">表关键字</param>
 /// <returns>表对象</returns>
public static clsXzMajorEN GetObj(this K_id_Major_XzMajor myKey)
{
clsXzMajorEN objXzMajorEN = clsXzMajorBL.XzMajorDA.GetObjByid_Major(myKey.Value);
return objXzMajorEN;
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_AddNewRecord)
 /// </summary>
 /// <param name = "objXzMajorEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clsXzMajorEN objXzMajorEN)
{
if (CheckUniqueness_MajorName_CollegeId(objXzMajorEN) == false)
{
var strMsg = string.Format("记录已经存在!专业名称 = [{0}],学院Id = [{1}],是否在用 = [{2}]的数据已经存在!(in clsXzMajorBL.AddNewRecord)", objXzMajorEN.MajorName,objXzMajorEN.CollegeId,objXzMajorEN.InUse);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objXzMajorEN.id_Major) == true || clsXzMajorBL.IsExist(objXzMajorEN.id_Major) == true)
 {
     objXzMajorEN.id_Major = clsXzMajorBL.GetMaxStrId_S();
 }
bool bolResult = clsXzMajorBL.XzMajorDA.AddNewRecordBySQL2(objXzMajorEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsXzMajorBL.ReFreshCache();

if (clsXzMajorBL.relatedActions != null)
{
clsXzMajorBL.relatedActions.UpdRelaTabDate(objXzMajorEN.id_Major, objXzMajorEN.UpdUser);
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
public static bool AddRecordEx(this clsXzMajorEN objXzMajorEN)
{
//操作步骤:
//1、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在
//2、检查唯一性
//3、检查传进去的对象属性是否合法
//4、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
//1、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在

//因为是字符型自增主键，不需要检查主键是否已经存在，在添加时，再获取 最大值作为主键
//if (clsXzMajorBL.IsExist(objXzMajorEN.id_Major))	//判断是否有相同的关键字
//{
//strMsg = "(errid:Busi000151)关键字字段已有相同的值";
//throw new Exception(strMsg);
//}
try
{
 //2、检查传进去的对象属性是否合法
objXzMajorEN.CheckPropertyNew();
 ///5.2、检查唯一性
if (objXzMajorEN.CheckXzMajorUniqueness() == false)
{
strMsg = string.Format("(专业名称(MajorName)=[{0}],学院Id(CollegeId)=[{1}])已经存在，不能重复!", objXzMajorEN.MajorName, objXzMajorEN.CollegeId);
throw new Exception(strMsg);
}
//因为是字符型自增主键，所以在添加时，自动获取主键值。
 if (string.IsNullOrEmpty(objXzMajorEN.id_Major) == true || clsXzMajorBL.IsExist(objXzMajorEN.id_Major) == true)
 {
     objXzMajorEN.id_Major = clsXzMajorBL.GetMaxStrId_S();
 }
//6、把数据实体层的数据存贮到数据库中
objXzMajorEN.AddNewRecord();
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
 /// <param name = "objXzMajorEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static string AddNewRecordWithMaxId(this clsXzMajorEN objXzMajorEN)
{
if (CheckUniqueness_MajorName_CollegeId(objXzMajorEN) == false)
{
var strMsg = string.Format("记录已经存在!专业名称 = [{0}],学院Id = [{1}],是否在用 = [{2}]的数据已经存在!(in clsXzMajorBL.AddNewRecordWithMaxId)", objXzMajorEN.MajorName,objXzMajorEN.CollegeId,objXzMajorEN.InUse);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objXzMajorEN.id_Major) == true || clsXzMajorBL.IsExist(objXzMajorEN.id_Major) == true)
 {
     objXzMajorEN.id_Major = clsXzMajorBL.GetMaxStrId_S();
 }
string strid_Major = clsXzMajorBL.XzMajorDA.AddNewRecordBySQL2WithReturnKey(objXzMajorEN);
     objXzMajorEN.id_Major = strid_Major;
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsXzMajorBL.ReFreshCache();

if (clsXzMajorBL.relatedActions != null)
{
clsXzMajorBL.relatedActions.UpdRelaTabDate(objXzMajorEN.id_Major, objXzMajorEN.UpdUser);
}
return strid_Major;
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
 /// <param name = "objXzMajorEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordWithReturnKey(this clsXzMajorEN objXzMajorEN)
{
if (CheckUniqueness_MajorName_CollegeId(objXzMajorEN) == false)
{
var strMsg = string.Format("记录已经存在!专业名称 = [{0}],学院Id = [{1}],是否在用 = [{2}]的数据已经存在!(in clsXzMajorBL.AddNewRecordWithReturnKey)", objXzMajorEN.MajorName,objXzMajorEN.CollegeId,objXzMajorEN.InUse);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objXzMajorEN.id_Major) == true || clsXzMajorBL.IsExist(objXzMajorEN.id_Major) == true)
 {
     objXzMajorEN.id_Major = clsXzMajorBL.GetMaxStrId_S();
 }
string strKey = clsXzMajorBL.XzMajorDA.AddNewRecordBySQL2WithReturnKey(objXzMajorEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsXzMajorBL.ReFreshCache();

if (clsXzMajorBL.relatedActions != null)
{
clsXzMajorBL.relatedActions.UpdRelaTabDate(objXzMajorEN.id_Major, objXzMajorEN.UpdUser);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objXzMajorEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsXzMajorEN Setid_Major(this clsXzMajorEN objXzMajorEN, string strid_Major, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strid_Major, 8, conXzMajor.id_Major);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strid_Major, 8, conXzMajor.id_Major);
}
objXzMajorEN.id_Major = strid_Major; //专业流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objXzMajorEN.dicFldComparisonOp.ContainsKey(conXzMajor.id_Major) == false)
{
objXzMajorEN.dicFldComparisonOp.Add(conXzMajor.id_Major, strComparisonOp);
}
else
{
objXzMajorEN.dicFldComparisonOp[conXzMajor.id_Major] = strComparisonOp;
}
}
return objXzMajorEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objXzMajorEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsXzMajorEN SetMajorID(this clsXzMajorEN objXzMajorEN, string strMajorID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strMajorID, conXzMajor.MajorID);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMajorID, 4, conXzMajor.MajorID);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strMajorID, 4, conXzMajor.MajorID);
}
objXzMajorEN.MajorID = strMajorID; //MajorID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objXzMajorEN.dicFldComparisonOp.ContainsKey(conXzMajor.MajorID) == false)
{
objXzMajorEN.dicFldComparisonOp.Add(conXzMajor.MajorID, strComparisonOp);
}
else
{
objXzMajorEN.dicFldComparisonOp[conXzMajor.MajorID] = strComparisonOp;
}
}
return objXzMajorEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objXzMajorEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsXzMajorEN SetMajorName(this clsXzMajorEN objXzMajorEN, string strMajorName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMajorName, 100, conXzMajor.MajorName);
}
objXzMajorEN.MajorName = strMajorName; //专业名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objXzMajorEN.dicFldComparisonOp.ContainsKey(conXzMajor.MajorName) == false)
{
objXzMajorEN.dicFldComparisonOp.Add(conXzMajor.MajorName, strComparisonOp);
}
else
{
objXzMajorEN.dicFldComparisonOp[conXzMajor.MajorName] = strComparisonOp;
}
}
return objXzMajorEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objXzMajorEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsXzMajorEN SetIsMainMajor(this clsXzMajorEN objXzMajorEN, bool bolIsMainMajor, string strComparisonOp="")
	{
objXzMajorEN.IsMainMajor = bolIsMainMajor; //是否重要专业
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objXzMajorEN.dicFldComparisonOp.ContainsKey(conXzMajor.IsMainMajor) == false)
{
objXzMajorEN.dicFldComparisonOp.Add(conXzMajor.IsMainMajor, strComparisonOp);
}
else
{
objXzMajorEN.dicFldComparisonOp[conXzMajor.IsMainMajor] = strComparisonOp;
}
}
return objXzMajorEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objXzMajorEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsXzMajorEN SetCollegeId(this clsXzMajorEN objXzMajorEN, string strCollegeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strCollegeId, conXzMajor.CollegeId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCollegeId, 6, conXzMajor.CollegeId);
}
objXzMajorEN.CollegeId = strCollegeId; //学院Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objXzMajorEN.dicFldComparisonOp.ContainsKey(conXzMajor.CollegeId) == false)
{
objXzMajorEN.dicFldComparisonOp.Add(conXzMajor.CollegeId, strComparisonOp);
}
else
{
objXzMajorEN.dicFldComparisonOp[conXzMajor.CollegeId] = strComparisonOp;
}
}
return objXzMajorEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objXzMajorEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsXzMajorEN SetOrderNum(this clsXzMajorEN objXzMajorEN, int intOrderNum, string strComparisonOp="")
	{
objXzMajorEN.OrderNum = intOrderNum; //排序
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objXzMajorEN.dicFldComparisonOp.ContainsKey(conXzMajor.OrderNum) == false)
{
objXzMajorEN.dicFldComparisonOp.Add(conXzMajor.OrderNum, strComparisonOp);
}
else
{
objXzMajorEN.dicFldComparisonOp[conXzMajor.OrderNum] = strComparisonOp;
}
}
return objXzMajorEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objXzMajorEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsXzMajorEN SetInUse(this clsXzMajorEN objXzMajorEN, bool bolInUse, string strComparisonOp="")
	{
objXzMajorEN.InUse = bolInUse; //是否在用
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objXzMajorEN.dicFldComparisonOp.ContainsKey(conXzMajor.InUse) == false)
{
objXzMajorEN.dicFldComparisonOp.Add(conXzMajor.InUse, strComparisonOp);
}
else
{
objXzMajorEN.dicFldComparisonOp[conXzMajor.InUse] = strComparisonOp;
}
}
return objXzMajorEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objXzMajorEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsXzMajorEN SetUpdDate(this clsXzMajorEN objXzMajorEN, string strUpdDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdDate, 20, conXzMajor.UpdDate);
}
objXzMajorEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objXzMajorEN.dicFldComparisonOp.ContainsKey(conXzMajor.UpdDate) == false)
{
objXzMajorEN.dicFldComparisonOp.Add(conXzMajor.UpdDate, strComparisonOp);
}
else
{
objXzMajorEN.dicFldComparisonOp[conXzMajor.UpdDate] = strComparisonOp;
}
}
return objXzMajorEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objXzMajorEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsXzMajorEN SetUpdUser(this clsXzMajorEN objXzMajorEN, string strUpdUser, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdUser, 20, conXzMajor.UpdUser);
}
objXzMajorEN.UpdUser = strUpdUser; //修改用户
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objXzMajorEN.dicFldComparisonOp.ContainsKey(conXzMajor.UpdUser) == false)
{
objXzMajorEN.dicFldComparisonOp.Add(conXzMajor.UpdUser, strComparisonOp);
}
else
{
objXzMajorEN.dicFldComparisonOp[conXzMajor.UpdUser] = strComparisonOp;
}
}
return objXzMajorEN;
	}

 /// <summary>
 /// 修改记录存盘到数据表中
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_UpdateRecordEx)
 /// </summary>
 /// <param name = "objXzMajorEN">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool UpdateRecordEx(this clsXzMajorEN objXzMajorEN)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
try
{
//1、检查传进去的对象属性是否合法
objXzMajorEN.CheckPropertyNew();
clsXzMajorEN objXzMajor_Cond = new clsXzMajorEN();
string strCondition = objXzMajor_Cond
.Setid_Major(objXzMajorEN.id_Major, "<>")
.SetMajorName(objXzMajorEN.MajorName, "=")
.SetCollegeId(objXzMajorEN.CollegeId, "=")
.SetInUse(objXzMajorEN.InUse, "=")
.GetCombineCondition();
objXzMajorEN._IsCheckProperty = true;
bool bolIsExist = clsXzMajorBL.IsExistRecord(strCondition);
if (bolIsExist)
{
strMsg = "(专业名_学院Id唯一，保证在同一个学院里专业名是唯一的。)不能重复!";
throw new Exception(strMsg);
}
//4、把数据实体层的数据存贮到数据库中
objXzMajorEN.Update();
}
catch(Exception objException)
{
strMsg = "修改记录不成功!" + objException.Message;
throw new Exception(strMsg);
}
return true; 
}

 /// <summary>
 /// 编辑记录存盘到数据表中。如果存在相关记录就修改，不存在就添加
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_EditRecordEx)
 /// </summary>
 /// <param name = "objXzMajor">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool EditRecordEx(this clsXzMajorEN objXzMajor)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
clsXzMajorEN objXzMajor_Cond = new clsXzMajorEN();
string strCondition = objXzMajor_Cond
.SetMajorName(objXzMajor.MajorName, "=")
.SetCollegeId(objXzMajor.CollegeId, "=")
.SetInUse(objXzMajor.InUse, "=")
.GetCombineCondition();
objXzMajor._IsCheckProperty = true;
bool bolIsExist = clsXzMajorBL.IsExistRecord(strCondition);
if (bolIsExist)
{
objXzMajor.id_Major = clsXzMajorBL.GetFirstID_S(strCondition);
objXzMajor.UpdateWithCondition(strCondition);
}
else
{
objXzMajor.id_Major = clsXzMajorBL.GetMaxStrId_S();
objXzMajor.AddNewRecord();
}
return true; 
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_Update)
 /// </summary>
 /// <param name = "objXzMajorEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsXzMajorEN objXzMajorEN)
{
 if (string.IsNullOrEmpty(objXzMajorEN.id_Major) == true)
 {
string strMsg = string.Format("(errid:Busi000095)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsXzMajorBL.XzMajorDA.UpdateBySql2(objXzMajorEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsXzMajorBL.ReFreshCache();

if (clsXzMajorBL.relatedActions != null)
{
clsXzMajorBL.relatedActions.UpdRelaTabDate(objXzMajorEN.id_Major, objXzMajorEN.UpdUser);
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
 /// <param name = "objXzMajorEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsXzMajorEN objXzMajorEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (string.IsNullOrEmpty(objXzMajorEN.id_Major) == true)
 {
string strMsg = string.Format("(errid:Busi000087)修改记录时关键字不能为空!(带事务处理)(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsXzMajorBL.XzMajorDA.UpdateBySql2(objXzMajorEN, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsXzMajorBL.ReFreshCache();

if (clsXzMajorBL.relatedActions != null)
{
clsXzMajorBL.relatedActions.UpdRelaTabDate(objXzMajorEN.id_Major, objXzMajorEN.UpdUser);
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
 /// <param name = "objXzMajorEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsXzMajorEN objXzMajorEN, string strWhereCond)
{
try
{
bool bolResult = clsXzMajorBL.XzMajorDA.UpdateBySqlWithCondition(objXzMajorEN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsXzMajorBL.ReFreshCache();

if (clsXzMajorBL.relatedActions != null)
{
clsXzMajorBL.relatedActions.UpdRelaTabDate(objXzMajorEN.id_Major, objXzMajorEN.UpdUser);
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
 /// <param name = "objXzMajorEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsXzMajorEN objXzMajorEN, string strWhereCond, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
bool bolResult = clsXzMajorBL.XzMajorDA.UpdateBySqlWithConditionTransaction(objXzMajorEN, strWhereCond, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsXzMajorBL.ReFreshCache();

if (clsXzMajorBL.relatedActions != null)
{
clsXzMajorBL.relatedActions.UpdRelaTabDate(objXzMajorEN.id_Major, objXzMajorEN.UpdUser);
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
 /// <param name = "strid_Major">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int Delete(this clsXzMajorEN objXzMajorEN)
{
try
{
int intRecNum = clsXzMajorBL.XzMajorDA.DelRecord(objXzMajorEN.id_Major);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsXzMajorBL.ReFreshCache();

if (clsXzMajorBL.relatedActions != null)
{
clsXzMajorBL.relatedActions.UpdRelaTabDate(objXzMajorEN.id_Major, objXzMajorEN.UpdUser);
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
 /// <param name = "objXzMajorENS">源对象</param>
 /// <param name = "objXzMajorENT">目标对象</param>
 public static void CopyTo(this clsXzMajorEN objXzMajorENS, clsXzMajorEN objXzMajorENT)
{
try
{
objXzMajorENT.id_Major = objXzMajorENS.id_Major; //专业流水号
objXzMajorENT.MajorID = objXzMajorENS.MajorID; //MajorID
objXzMajorENT.MajorName = objXzMajorENS.MajorName; //专业名称
objXzMajorENT.IsMainMajor = objXzMajorENS.IsMainMajor; //是否重要专业
objXzMajorENT.CollegeId = objXzMajorENS.CollegeId; //学院Id
objXzMajorENT.OrderNum = objXzMajorENS.OrderNum; //排序
objXzMajorENT.InUse = objXzMajorENS.InUse; //是否在用
objXzMajorENT.UpdDate = objXzMajorENS.UpdDate; //修改日期
objXzMajorENT.UpdUser = objXzMajorENS.UpdUser; //修改用户
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
 /// <param name = "objXzMajorENS">源对象</param>
 /// <returns>目标对象=>clsXzMajorEN:objXzMajorENT</returns>
 public static clsXzMajorEN CopyTo(this clsXzMajorEN objXzMajorENS)
{
try
{
 clsXzMajorEN objXzMajorENT = new clsXzMajorEN()
{
id_Major = objXzMajorENS.id_Major, //专业流水号
MajorID = objXzMajorENS.MajorID, //MajorID
MajorName = objXzMajorENS.MajorName, //专业名称
IsMainMajor = objXzMajorENS.IsMainMajor, //是否重要专业
CollegeId = objXzMajorENS.CollegeId, //学院Id
OrderNum = objXzMajorENS.OrderNum, //排序
InUse = objXzMajorENS.InUse, //是否在用
UpdDate = objXzMajorENS.UpdDate, //修改日期
UpdUser = objXzMajorENS.UpdUser, //修改用户
};
 return objXzMajorENT;
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
public static void CheckPropertyNew(this clsXzMajorEN objXzMajorEN)
{
 clsXzMajorBL.XzMajorDA.CheckPropertyNew(objXzMajorEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(this clsXzMajorEN objXzMajorEN)
{
 clsXzMajorBL.XzMajorDA.CheckProperty4Condition(objXzMajorEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsXzMajorEN objXzMajor_Cond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objXzMajor_Cond.IsUpdated(conXzMajor.id_Major) == true)
{
string strComparisonOp_id_Major = objXzMajor_Cond.dicFldComparisonOp[conXzMajor.id_Major];
strWhereCond += string.Format(" And {0} {2} '{1}'", conXzMajor.id_Major, objXzMajor_Cond.id_Major, strComparisonOp_id_Major);
}
if (objXzMajor_Cond.IsUpdated(conXzMajor.MajorID) == true)
{
string strComparisonOp_MajorID = objXzMajor_Cond.dicFldComparisonOp[conXzMajor.MajorID];
strWhereCond += string.Format(" And {0} {2} '{1}'", conXzMajor.MajorID, objXzMajor_Cond.MajorID, strComparisonOp_MajorID);
}
if (objXzMajor_Cond.IsUpdated(conXzMajor.MajorName) == true)
{
string strComparisonOp_MajorName = objXzMajor_Cond.dicFldComparisonOp[conXzMajor.MajorName];
strWhereCond += string.Format(" And {0} {2} '{1}'", conXzMajor.MajorName, objXzMajor_Cond.MajorName, strComparisonOp_MajorName);
}
if (objXzMajor_Cond.IsUpdated(conXzMajor.IsMainMajor) == true)
{
if (objXzMajor_Cond.IsMainMajor == true)
{
strWhereCond += string.Format(" And {0} = '1'", conXzMajor.IsMainMajor);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conXzMajor.IsMainMajor);
}
}
if (objXzMajor_Cond.IsUpdated(conXzMajor.CollegeId) == true)
{
string strComparisonOp_CollegeId = objXzMajor_Cond.dicFldComparisonOp[conXzMajor.CollegeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conXzMajor.CollegeId, objXzMajor_Cond.CollegeId, strComparisonOp_CollegeId);
}
if (objXzMajor_Cond.IsUpdated(conXzMajor.OrderNum) == true)
{
string strComparisonOp_OrderNum = objXzMajor_Cond.dicFldComparisonOp[conXzMajor.OrderNum];
strWhereCond += string.Format(" And {0} {2} {1}", conXzMajor.OrderNum, objXzMajor_Cond.OrderNum, strComparisonOp_OrderNum);
}
if (objXzMajor_Cond.IsUpdated(conXzMajor.InUse) == true)
{
if (objXzMajor_Cond.InUse == true)
{
strWhereCond += string.Format(" And {0} = '1'", conXzMajor.InUse);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conXzMajor.InUse);
}
}
if (objXzMajor_Cond.IsUpdated(conXzMajor.UpdDate) == true)
{
string strComparisonOp_UpdDate = objXzMajor_Cond.dicFldComparisonOp[conXzMajor.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conXzMajor.UpdDate, objXzMajor_Cond.UpdDate, strComparisonOp_UpdDate);
}
if (objXzMajor_Cond.IsUpdated(conXzMajor.UpdUser) == true)
{
string strComparisonOp_UpdUser = objXzMajor_Cond.dicFldComparisonOp[conXzMajor.UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", conXzMajor.UpdUser, objXzMajor_Cond.UpdUser, strComparisonOp_UpdUser);
}
 return strWhereCond;
}

 /// <summary>
 /// 检查唯一性(Uniqueness)--专业名称(MajorName), 如果不唯一,即存在相同的记录,就返回False
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckUniqueness)
 /// </summary>
 /// <param name = "strid_Major">专业流水号(主键)</param>
 /// <param name = "strMajorName">专业名称(要求唯一的字段)</param>
 /// <returns></returns>
public static bool CheckMajorNameUniqueness(this string strid_Major, string strMajorName)
{
//检测记录是否存在
bool bolIsUniqueness = clsXzMajorBL.XzMajorDA.CheckMajorNameUniqueness(strid_Major, strMajorName);
return bolIsUniqueness;
}
 /// <summary>
 /// 检查唯一性(Uniqueness)--学院Id(CollegeId), 如果不唯一,即存在相同的记录,就返回False
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckUniqueness)
 /// </summary>
 /// <param name = "strid_Major">专业流水号(主键)</param>
 /// <param name = "strCollegeId">学院Id(要求唯一的字段)</param>
 /// <returns></returns>
public static bool CheckCollegeIdUniqueness(this string strid_Major, string strCollegeId)
{
//检测记录是否存在
bool bolIsUniqueness = clsXzMajorBL.XzMajorDA.CheckCollegeIdUniqueness(strid_Major, strCollegeId);
return bolIsUniqueness;
}

 /// <summary>
 /// 检查唯一性(Uniqueness)--XzMajor(专业), 如果不唯一,即存在相同的记录,就返回False
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckUniquenessV3)
 /// </summary>
 /// <param name = "objXzMajorEN">要求唯一的对象</param>
 /// <returns></returns>
public static bool CheckXzMajorUniqueness(this clsXzMajorEN objXzMajorEN)
{
//检测记录是否存在
bool bolIsUniqueness;
if (objXzMajorEN == null) return true;
if (objXzMajorEN.id_Major == null || objXzMajorEN.id_Major == "")
{
bolIsUniqueness = clsXzMajorBL.XzMajorDA.CheckXzMajorUniqueness(objXzMajorEN.MajorName, objXzMajorEN.CollegeId);
}
else
{
bolIsUniqueness = clsXzMajorBL.XzMajorDA.CheckXzMajorUniqueness(objXzMajorEN.id_Major, objXzMajorEN.MajorName, objXzMajorEN.CollegeId);
}
return bolIsUniqueness;
}

 /// <summary>
 /// 检查唯一性(Uniqueness)--XzMajor(专业), 如果不唯一,即存在相同的记录,就返回False
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckConstraint)
 /// </summary>
 /// <param name = "objXzMajorEN">要求唯一的对象</param>
 /// <returns></returns>
public static bool CheckUniqueness_MajorName_CollegeId(this clsXzMajorEN objXzMajorEN)
{
//检测记录是否存在
bool bolIsUniqueness;
StringBuilder sbCondition = new StringBuilder();
if (objXzMajorEN == null) return true;
if (objXzMajorEN.id_Major == null || objXzMajorEN.id_Major == "")
{
sbCondition.AppendFormat("1 = 1");
 if (objXzMajorEN.MajorName == null)
{
 sbCondition.AppendFormat(" and MajorName is null", objXzMajorEN.MajorName);
}
else
{
 sbCondition.AppendFormat(" and MajorName = '{0}'", objXzMajorEN.MajorName);
}
 sbCondition.AppendFormat(" and CollegeId = '{0}'", objXzMajorEN.CollegeId);
 if (objXzMajorEN.InUse == null)
{
 sbCondition.AppendFormat(" and InUse is null", objXzMajorEN.InUse);
}
else
{
 sbCondition.AppendFormat(" and InUse = '{0}'", objXzMajorEN.InUse);
}
if (clsXzMajorBL.IsExistRecord(sbCondition.ToString())  ==  true)
{
 bolIsUniqueness = false;
}
else
{
 bolIsUniqueness = true;
}
}
 else {
sbCondition.AppendFormat("id_Major !=  '{0}'", objXzMajorEN.id_Major);
 sbCondition.AppendFormat(" and MajorName = '{0}'", objXzMajorEN.MajorName);
 sbCondition.AppendFormat(" and CollegeId = '{0}'", objXzMajorEN.CollegeId);
 sbCondition.AppendFormat(" and InUse = '{0}'", objXzMajorEN.InUse);
if (clsXzMajorBL.IsExistRecord(sbCondition.ToString())  ==  true)
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
 /// 检查唯一性(Uniqueness)--XzMajor(专业), 如果不唯一,即存在相同的记录,就返回False
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetConditionString4Constraint)
 /// </summary>
 /// <param name = "objXzMajorEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr_MajorName_CollegeId(this clsXzMajorEN objXzMajorEN)
{
//检测记录是否存在
StringBuilder sbCondition = new StringBuilder();
if (objXzMajorEN == null) return "";
if (objXzMajorEN.id_Major == null || objXzMajorEN.id_Major == "")
{
sbCondition.AppendFormat("1 = 1");
 if (objXzMajorEN.MajorName == null)
{
 sbCondition.AppendFormat(" and MajorName is null", objXzMajorEN.MajorName);
}
else
{
 sbCondition.AppendFormat(" and MajorName = '{0}'", objXzMajorEN.MajorName);
}
 sbCondition.AppendFormat(" and CollegeId = '{0}'", objXzMajorEN.CollegeId);
 if (objXzMajorEN.InUse == null)
{
 sbCondition.AppendFormat(" and InUse is null", objXzMajorEN.InUse);
}
else
{
 sbCondition.AppendFormat(" and InUse = '{0}'", objXzMajorEN.InUse);
}
return sbCondition.ToString();
}
 else {
sbCondition.AppendFormat("id_Major !=  '{0}'", objXzMajorEN.id_Major);
 sbCondition.AppendFormat(" and MajorName = '{0}'", objXzMajorEN.MajorName);
 sbCondition.AppendFormat(" and CollegeId = '{0}'", objXzMajorEN.CollegeId);
 sbCondition.AppendFormat(" and InUse = '{0}'", objXzMajorEN.InUse);
 return sbCondition.ToString();
}
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时，对相关表执行相应的操作，此处定义一个类，在外面可以扩展该类的相关函数，达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_XzMajor
{
public virtual bool UpdRelaTabDate(string strid_Major, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// 专业(XzMajor)
 /// 数据源类型:表
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsXzMajorBL
{
public static RelatedActions_XzMajor relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsXzMajorDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式，使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsXzMajorDA XzMajorDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsXzMajorDA();
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
 public clsXzMajorBL()
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
throw new Exception("请初始化用于记录日志的clsSysParaEN.objLog对象！");
}
if (clsSysParaEN.objErrorLog == null)
{
throw new Exception("请初始化用于记录错误日志的clsSysParaEN.objErrorLog对象！");
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
if (string.IsNullOrEmpty(clsXzMajorEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsXzMajorEN._ConnectString);
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
public static DataTable GetDataTable_XzMajor(string strWhereCond)
{
DataTable objDT;
try
{
objDT = XzMajorDA.GetDataTable_XzMajor(strWhereCond);
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
objDT = XzMajorDA.GetDataTable(strWhereCond);
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
objDT = XzMajorDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = XzMajorDA.GetDataTable(strWhereCond, strTabName);
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
objDT = XzMajorDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = XzMajorDA.GetDataTable_Top(objTopPara);
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
objDT = XzMajorDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = XzMajorDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = XzMajorDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
 /// <param name = "arrId_MajorLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static List<clsXzMajorEN> GetObjLstById_MajorLst(List<string> arrId_MajorLst)
{
List<clsXzMajorEN> arrObjLst = new List<clsXzMajorEN>(); 
System.Data.DataTable objDT; 
 string strSqlConditionStr = clsArray.GetSqlInStrByArray(arrId_MajorLst, true);
 string strWhereCond = string.Format("id_Major in ({0})", strSqlConditionStr);
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsXzMajorEN objXzMajorEN = new clsXzMajorEN();
try
{
objXzMajorEN.id_Major = objRow[conXzMajor.id_Major].ToString().Trim(); //专业流水号
objXzMajorEN.MajorID = objRow[conXzMajor.MajorID].ToString().Trim(); //MajorID
objXzMajorEN.MajorName = objRow[conXzMajor.MajorName] == DBNull.Value ? null : objRow[conXzMajor.MajorName].ToString().Trim(); //专业名称
objXzMajorEN.IsMainMajor = clsEntityBase2.TransNullToBool_S(objRow[conXzMajor.IsMainMajor] == DBNull.Value ? null : objRow[conXzMajor.IsMainMajor].ToString().Trim()); //是否重要专业
objXzMajorEN.CollegeId = objRow[conXzMajor.CollegeId].ToString().Trim(); //学院Id
objXzMajorEN.OrderNum = clsEntityBase2.TransNullToInt_S(objRow[conXzMajor.OrderNum] == DBNull.Value ? null : objRow[conXzMajor.OrderNum].ToString().Trim()); //排序
objXzMajorEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[conXzMajor.InUse] == DBNull.Value ? null : objRow[conXzMajor.InUse].ToString().Trim()); //是否在用
objXzMajorEN.UpdDate = objRow[conXzMajor.UpdDate] == DBNull.Value ? null : objRow[conXzMajor.UpdDate].ToString().Trim(); //修改日期
objXzMajorEN.UpdUser = objRow[conXzMajor.UpdUser] == DBNull.Value ? null : objRow[conXzMajor.UpdUser].ToString().Trim(); //修改用户
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objXzMajorEN.id_Major, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objXzMajorEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLst_Cache)
 /// </summary>
 /// <param name = "arrId_MajorLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsXzMajorEN> GetObjLstById_MajorLst_Cache(List<string> arrId_MajorLst)
{
string strKey = string.Format("{0}", clsXzMajorEN._CurrTabName_S);
List<clsXzMajorEN> arrXzMajorObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsXzMajorEN> arrXzMajorObjLst_Sel =
arrXzMajorObjLst_Cache
.Where(x => arrId_MajorLst.Contains(x.id_Major));
return arrXzMajorObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsXzMajorEN> GetObjLst(string strWhereCond)
{
List<clsXzMajorEN> arrObjLst = new List<clsXzMajorEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsXzMajorEN objXzMajorEN = new clsXzMajorEN();
try
{
objXzMajorEN.id_Major = objRow[conXzMajor.id_Major].ToString().Trim(); //专业流水号
objXzMajorEN.MajorID = objRow[conXzMajor.MajorID].ToString().Trim(); //MajorID
objXzMajorEN.MajorName = objRow[conXzMajor.MajorName] == DBNull.Value ? null : objRow[conXzMajor.MajorName].ToString().Trim(); //专业名称
objXzMajorEN.IsMainMajor = clsEntityBase2.TransNullToBool_S(objRow[conXzMajor.IsMainMajor] == DBNull.Value ? null : objRow[conXzMajor.IsMainMajor].ToString().Trim()); //是否重要专业
objXzMajorEN.CollegeId = objRow[conXzMajor.CollegeId].ToString().Trim(); //学院Id
objXzMajorEN.OrderNum = clsEntityBase2.TransNullToInt_S(objRow[conXzMajor.OrderNum] == DBNull.Value ? null : objRow[conXzMajor.OrderNum].ToString().Trim()); //排序
objXzMajorEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[conXzMajor.InUse] == DBNull.Value ? null : objRow[conXzMajor.InUse].ToString().Trim()); //是否在用
objXzMajorEN.UpdDate = objRow[conXzMajor.UpdDate] == DBNull.Value ? null : objRow[conXzMajor.UpdDate].ToString().Trim(); //修改日期
objXzMajorEN.UpdUser = objRow[conXzMajor.UpdUser] == DBNull.Value ? null : objRow[conXzMajor.UpdUser].ToString().Trim(); //修改用户
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objXzMajorEN.id_Major, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objXzMajorEN);
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
public static List<clsXzMajorEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsXzMajorEN> arrObjLst = new List<clsXzMajorEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsXzMajorEN objXzMajorEN = new clsXzMajorEN();
try
{
objXzMajorEN.id_Major = objRow[conXzMajor.id_Major].ToString().Trim(); //专业流水号
objXzMajorEN.MajorID = objRow[conXzMajor.MajorID].ToString().Trim(); //MajorID
objXzMajorEN.MajorName = objRow[conXzMajor.MajorName] == DBNull.Value ? null : objRow[conXzMajor.MajorName].ToString().Trim(); //专业名称
objXzMajorEN.IsMainMajor = clsEntityBase2.TransNullToBool_S(objRow[conXzMajor.IsMainMajor] == DBNull.Value ? null : objRow[conXzMajor.IsMainMajor].ToString().Trim()); //是否重要专业
objXzMajorEN.CollegeId = objRow[conXzMajor.CollegeId].ToString().Trim(); //学院Id
objXzMajorEN.OrderNum = clsEntityBase2.TransNullToInt_S(objRow[conXzMajor.OrderNum] == DBNull.Value ? null : objRow[conXzMajor.OrderNum].ToString().Trim()); //排序
objXzMajorEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[conXzMajor.InUse] == DBNull.Value ? null : objRow[conXzMajor.InUse].ToString().Trim()); //是否在用
objXzMajorEN.UpdDate = objRow[conXzMajor.UpdDate] == DBNull.Value ? null : objRow[conXzMajor.UpdDate].ToString().Trim(); //修改日期
objXzMajorEN.UpdUser = objRow[conXzMajor.UpdUser] == DBNull.Value ? null : objRow[conXzMajor.UpdUser].ToString().Trim(); //修改用户
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objXzMajorEN.id_Major, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objXzMajorEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLst_Cache)
 /// </summary>
 /// <param name = "objXzMajor_Cond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsXzMajorEN> GetSubObjLst_Cache(clsXzMajorEN objXzMajor_Cond)
{
List<clsXzMajorEN> arrObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsXzMajorEN> arrObjLst_Sel = arrObjLst_Cache;
foreach (string strFldName in conXzMajor.AttributeName)
{
if (objXzMajor_Cond.IsUpdated(strFldName) == false) continue;
if (objXzMajor_Cond.dicFldComparisonOp == null)
{
arrObjLst_Sel = arrObjLst_Sel.Where(x => x[strFldName].ToString() == objXzMajor_Cond[strFldName].ToString());
}
else
{
if (objXzMajor_Cond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objXzMajor_Cond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLst_Sel = arrObjLst_Sel.Where(x => x[strFldName].ToString() == objXzMajor_Cond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLst_Sel = arrObjLst_Sel.Where(x => x[strFldName].ToString().Contains(objXzMajor_Cond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLst_Sel = arrObjLst_Sel.Where(x => x[strFldName].ToString().Length > int.Parse(objXzMajor_Cond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLst_Sel = arrObjLst_Sel.Where(x => x[strFldName].ToString().Length <= int.Parse(objXzMajor_Cond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLst_Sel = arrObjLst_Sel.Where(x => x[strFldName].ToString().Length >= int.Parse(objXzMajor_Cond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLst_Sel = arrObjLst_Sel.Where(x => x[strFldName].ToString().Length < int.Parse(objXzMajor_Cond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLst_Sel = arrObjLst_Sel.Where(x => x[strFldName].ToString().Length == int.Parse(objXzMajor_Cond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objXzMajor_Cond[strFldName].ToString().Split(",".ToCharArray());
arrObjLst_Sel = arrObjLst_Sel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLst_Sel = arrObjLst_Sel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objXzMajor_Cond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLst_Sel = arrObjLst_Sel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objXzMajor_Cond[strFldName]));
}
}
}
return arrObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByTabName)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsXzMajorEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsXzMajorEN> arrObjLst = new List<clsXzMajorEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsXzMajorEN objXzMajorEN = new clsXzMajorEN();
try
{
objXzMajorEN.id_Major = objRow[conXzMajor.id_Major].ToString().Trim(); //专业流水号
objXzMajorEN.MajorID = objRow[conXzMajor.MajorID].ToString().Trim(); //MajorID
objXzMajorEN.MajorName = objRow[conXzMajor.MajorName] == DBNull.Value ? null : objRow[conXzMajor.MajorName].ToString().Trim(); //专业名称
objXzMajorEN.IsMainMajor = clsEntityBase2.TransNullToBool_S(objRow[conXzMajor.IsMainMajor] == DBNull.Value ? null : objRow[conXzMajor.IsMainMajor].ToString().Trim()); //是否重要专业
objXzMajorEN.CollegeId = objRow[conXzMajor.CollegeId].ToString().Trim(); //学院Id
objXzMajorEN.OrderNum = clsEntityBase2.TransNullToInt_S(objRow[conXzMajor.OrderNum] == DBNull.Value ? null : objRow[conXzMajor.OrderNum].ToString().Trim()); //排序
objXzMajorEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[conXzMajor.InUse] == DBNull.Value ? null : objRow[conXzMajor.InUse].ToString().Trim()); //是否在用
objXzMajorEN.UpdDate = objRow[conXzMajor.UpdDate] == DBNull.Value ? null : objRow[conXzMajor.UpdDate].ToString().Trim(); //修改日期
objXzMajorEN.UpdUser = objRow[conXzMajor.UpdUser] == DBNull.Value ? null : objRow[conXzMajor.UpdUser].ToString().Trim(); //修改用户
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objXzMajorEN.id_Major, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objXzMajorEN);
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
public static List<clsXzMajorEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsXzMajorEN> arrObjLst = new List<clsXzMajorEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsXzMajorEN objXzMajorEN = new clsXzMajorEN();
try
{
objXzMajorEN.id_Major = objRow[conXzMajor.id_Major].ToString().Trim(); //专业流水号
objXzMajorEN.MajorID = objRow[conXzMajor.MajorID].ToString().Trim(); //MajorID
objXzMajorEN.MajorName = objRow[conXzMajor.MajorName] == DBNull.Value ? null : objRow[conXzMajor.MajorName].ToString().Trim(); //专业名称
objXzMajorEN.IsMainMajor = clsEntityBase2.TransNullToBool_S(objRow[conXzMajor.IsMainMajor] == DBNull.Value ? null : objRow[conXzMajor.IsMainMajor].ToString().Trim()); //是否重要专业
objXzMajorEN.CollegeId = objRow[conXzMajor.CollegeId].ToString().Trim(); //学院Id
objXzMajorEN.OrderNum = clsEntityBase2.TransNullToInt_S(objRow[conXzMajor.OrderNum] == DBNull.Value ? null : objRow[conXzMajor.OrderNum].ToString().Trim()); //排序
objXzMajorEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[conXzMajor.InUse] == DBNull.Value ? null : objRow[conXzMajor.InUse].ToString().Trim()); //是否在用
objXzMajorEN.UpdDate = objRow[conXzMajor.UpdDate] == DBNull.Value ? null : objRow[conXzMajor.UpdDate].ToString().Trim(); //修改日期
objXzMajorEN.UpdUser = objRow[conXzMajor.UpdUser] == DBNull.Value ? null : objRow[conXzMajor.UpdUser].ToString().Trim(); //修改用户
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objXzMajorEN.id_Major, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objXzMajorEN);
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
List<clsXzMajorEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsXzMajorEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsXzMajorEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsXzMajorEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsXzMajorEN> arrObjLst = new List<clsXzMajorEN>(); 
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
	clsXzMajorEN objXzMajorEN = new clsXzMajorEN();
try
{
objXzMajorEN.id_Major = objRow[conXzMajor.id_Major].ToString().Trim(); //专业流水号
objXzMajorEN.MajorID = objRow[conXzMajor.MajorID].ToString().Trim(); //MajorID
objXzMajorEN.MajorName = objRow[conXzMajor.MajorName] == DBNull.Value ? null : objRow[conXzMajor.MajorName].ToString().Trim(); //专业名称
objXzMajorEN.IsMainMajor = clsEntityBase2.TransNullToBool_S(objRow[conXzMajor.IsMainMajor] == DBNull.Value ? null : objRow[conXzMajor.IsMainMajor].ToString().Trim()); //是否重要专业
objXzMajorEN.CollegeId = objRow[conXzMajor.CollegeId].ToString().Trim(); //学院Id
objXzMajorEN.OrderNum = clsEntityBase2.TransNullToInt_S(objRow[conXzMajor.OrderNum] == DBNull.Value ? null : objRow[conXzMajor.OrderNum].ToString().Trim()); //排序
objXzMajorEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[conXzMajor.InUse] == DBNull.Value ? null : objRow[conXzMajor.InUse].ToString().Trim()); //是否在用
objXzMajorEN.UpdDate = objRow[conXzMajor.UpdDate] == DBNull.Value ? null : objRow[conXzMajor.UpdDate].ToString().Trim(); //修改日期
objXzMajorEN.UpdUser = objRow[conXzMajor.UpdUser] == DBNull.Value ? null : objRow[conXzMajor.UpdUser].ToString().Trim(); //修改用户
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objXzMajorEN.id_Major, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objXzMajorEN);
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
public static List<clsXzMajorEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsXzMajorEN> arrObjLst = new List<clsXzMajorEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsXzMajorEN objXzMajorEN = new clsXzMajorEN();
try
{
objXzMajorEN.id_Major = objRow[conXzMajor.id_Major].ToString().Trim(); //专业流水号
objXzMajorEN.MajorID = objRow[conXzMajor.MajorID].ToString().Trim(); //MajorID
objXzMajorEN.MajorName = objRow[conXzMajor.MajorName] == DBNull.Value ? null : objRow[conXzMajor.MajorName].ToString().Trim(); //专业名称
objXzMajorEN.IsMainMajor = clsEntityBase2.TransNullToBool_S(objRow[conXzMajor.IsMainMajor] == DBNull.Value ? null : objRow[conXzMajor.IsMainMajor].ToString().Trim()); //是否重要专业
objXzMajorEN.CollegeId = objRow[conXzMajor.CollegeId].ToString().Trim(); //学院Id
objXzMajorEN.OrderNum = clsEntityBase2.TransNullToInt_S(objRow[conXzMajor.OrderNum] == DBNull.Value ? null : objRow[conXzMajor.OrderNum].ToString().Trim()); //排序
objXzMajorEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[conXzMajor.InUse] == DBNull.Value ? null : objRow[conXzMajor.InUse].ToString().Trim()); //是否在用
objXzMajorEN.UpdDate = objRow[conXzMajor.UpdDate] == DBNull.Value ? null : objRow[conXzMajor.UpdDate].ToString().Trim(); //修改日期
objXzMajorEN.UpdUser = objRow[conXzMajor.UpdUser] == DBNull.Value ? null : objRow[conXzMajor.UpdUser].ToString().Trim(); //修改用户
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objXzMajorEN.id_Major, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objXzMajorEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsXzMajorEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsXzMajorEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsXzMajorEN> arrObjLst = new List<clsXzMajorEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsXzMajorEN objXzMajorEN = new clsXzMajorEN();
try
{
objXzMajorEN.id_Major = objRow[conXzMajor.id_Major].ToString().Trim(); //专业流水号
objXzMajorEN.MajorID = objRow[conXzMajor.MajorID].ToString().Trim(); //MajorID
objXzMajorEN.MajorName = objRow[conXzMajor.MajorName] == DBNull.Value ? null : objRow[conXzMajor.MajorName].ToString().Trim(); //专业名称
objXzMajorEN.IsMainMajor = clsEntityBase2.TransNullToBool_S(objRow[conXzMajor.IsMainMajor] == DBNull.Value ? null : objRow[conXzMajor.IsMainMajor].ToString().Trim()); //是否重要专业
objXzMajorEN.CollegeId = objRow[conXzMajor.CollegeId].ToString().Trim(); //学院Id
objXzMajorEN.OrderNum = clsEntityBase2.TransNullToInt_S(objRow[conXzMajor.OrderNum] == DBNull.Value ? null : objRow[conXzMajor.OrderNum].ToString().Trim()); //排序
objXzMajorEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[conXzMajor.InUse] == DBNull.Value ? null : objRow[conXzMajor.InUse].ToString().Trim()); //是否在用
objXzMajorEN.UpdDate = objRow[conXzMajor.UpdDate] == DBNull.Value ? null : objRow[conXzMajor.UpdDate].ToString().Trim(); //修改日期
objXzMajorEN.UpdUser = objRow[conXzMajor.UpdUser] == DBNull.Value ? null : objRow[conXzMajor.UpdUser].ToString().Trim(); //修改用户
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objXzMajorEN.id_Major, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objXzMajorEN);
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
public static List<clsXzMajorEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsXzMajorEN> arrObjLst = new List<clsXzMajorEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsXzMajorEN objXzMajorEN = new clsXzMajorEN();
try
{
objXzMajorEN.id_Major = objRow[conXzMajor.id_Major].ToString().Trim(); //专业流水号
objXzMajorEN.MajorID = objRow[conXzMajor.MajorID].ToString().Trim(); //MajorID
objXzMajorEN.MajorName = objRow[conXzMajor.MajorName] == DBNull.Value ? null : objRow[conXzMajor.MajorName].ToString().Trim(); //专业名称
objXzMajorEN.IsMainMajor = clsEntityBase2.TransNullToBool_S(objRow[conXzMajor.IsMainMajor] == DBNull.Value ? null : objRow[conXzMajor.IsMainMajor].ToString().Trim()); //是否重要专业
objXzMajorEN.CollegeId = objRow[conXzMajor.CollegeId].ToString().Trim(); //学院Id
objXzMajorEN.OrderNum = clsEntityBase2.TransNullToInt_S(objRow[conXzMajor.OrderNum] == DBNull.Value ? null : objRow[conXzMajor.OrderNum].ToString().Trim()); //排序
objXzMajorEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[conXzMajor.InUse] == DBNull.Value ? null : objRow[conXzMajor.InUse].ToString().Trim()); //是否在用
objXzMajorEN.UpdDate = objRow[conXzMajor.UpdDate] == DBNull.Value ? null : objRow[conXzMajor.UpdDate].ToString().Trim(); //修改日期
objXzMajorEN.UpdUser = objRow[conXzMajor.UpdUser] == DBNull.Value ? null : objRow[conXzMajor.UpdUser].ToString().Trim(); //修改用户
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objXzMajorEN.id_Major, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objXzMajorEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsXzMajorEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsXzMajorEN> arrObjLst = new List<clsXzMajorEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsXzMajorEN objXzMajorEN = new clsXzMajorEN();
try
{
objXzMajorEN.id_Major = objRow[conXzMajor.id_Major].ToString().Trim(); //专业流水号
objXzMajorEN.MajorID = objRow[conXzMajor.MajorID].ToString().Trim(); //MajorID
objXzMajorEN.MajorName = objRow[conXzMajor.MajorName] == DBNull.Value ? null : objRow[conXzMajor.MajorName].ToString().Trim(); //专业名称
objXzMajorEN.IsMainMajor = clsEntityBase2.TransNullToBool_S(objRow[conXzMajor.IsMainMajor] == DBNull.Value ? null : objRow[conXzMajor.IsMainMajor].ToString().Trim()); //是否重要专业
objXzMajorEN.CollegeId = objRow[conXzMajor.CollegeId].ToString().Trim(); //学院Id
objXzMajorEN.OrderNum = clsEntityBase2.TransNullToInt_S(objRow[conXzMajor.OrderNum] == DBNull.Value ? null : objRow[conXzMajor.OrderNum].ToString().Trim()); //排序
objXzMajorEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[conXzMajor.InUse] == DBNull.Value ? null : objRow[conXzMajor.InUse].ToString().Trim()); //是否在用
objXzMajorEN.UpdDate = objRow[conXzMajor.UpdDate] == DBNull.Value ? null : objRow[conXzMajor.UpdDate].ToString().Trim(); //修改日期
objXzMajorEN.UpdUser = objRow[conXzMajor.UpdUser] == DBNull.Value ? null : objRow[conXzMajor.UpdUser].ToString().Trim(); //修改用户
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objXzMajorEN.id_Major, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objXzMajorEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objXzMajorEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetXzMajor(ref clsXzMajorEN objXzMajorEN)
{
bool bolResult = XzMajorDA.GetXzMajor(ref objXzMajorEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "strid_Major">表关键字</param>
 /// <returns>表对象</returns>
public static clsXzMajorEN GetObjByid_Major(string strid_Major)
{
if (strid_Major.IndexOf(' ') >=0)
{
var strMsg = string.Format("(errid:Busi000079)在表中,关键字[strid_Major]中不能有空格!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
if (string.IsNullOrEmpty(strid_Major) == true)
{
var strMsg = string.Format("(errid:Busi000020)在表中,关键字[strid_Major]不能为空!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
clsXzMajorEN objXzMajorEN = XzMajorDA.GetObjByid_Major(strid_Major);
return objXzMajorEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsXzMajorEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsXzMajorEN objXzMajorEN = XzMajorDA.GetFirstObj(strWhereCond);
 return objXzMajorEN;
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
public static clsXzMajorEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsXzMajorEN objXzMajorEN = XzMajorDA.GetObjByDataRow(objRow);
 return objXzMajorEN;
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
public static clsXzMajorEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsXzMajorEN objXzMajorEN = XzMajorDA.GetObjByDataRow(objRow);
 return objXzMajorEN;
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
 /// <param name = "strid_Major">所给的关键字</param>
 /// <param name = "lstXzMajorObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsXzMajorEN GetObjByid_MajorFromList(string strid_Major, List<clsXzMajorEN> lstXzMajorObjLst)
{
foreach (clsXzMajorEN objXzMajorEN in lstXzMajorObjLst)
{
if (objXzMajorEN.id_Major == strid_Major)
{
return objXzMajorEN;
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
 string strMaxId_Major;
 try
 {
 strMaxId_Major = clsXzMajorDA.GetMaxStrId();
 return strMaxId_Major;
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
 string strid_Major;
 try
 {
 strid_Major = new clsXzMajorDA().GetFirstID(strWhereCond);
 return strid_Major;
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
 arrList = XzMajorDA.GetID(strWhereCond);
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
bool bolIsExist = XzMajorDA.IsExistCondRec(strWhereCond);
return bolIsExist;
}

 /// <summary>
 /// 判断当前表中是否存在给定关键字值的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExist)
 /// </summary>
 /// <param name = "strid_Major">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public static bool IsExist(string strid_Major)
{
if (string.IsNullOrEmpty(strid_Major) == true)
{
var strMsg = string.Format("(errid:Busi000027)在表中,关键字[strid_Major]不能为空!!(from {0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
//检测记录是否存在
bool bolIsExist = XzMajorDA.IsExist(strid_Major);
return bolIsExist;
}

/// <summary>
/// 设置修改时间
/// </summary>
/// <param name = "strid_Major">专业流水号</param>
/// <param name = "strOpUser">修改用户</param>
/// <returns>是否成功？</returns>
public static bool SetUpdDate(string strid_Major, string strOpUser)
{
clsXzMajorEN objXzMajorEN = clsXzMajorBL.GetObjByid_Major(strid_Major);
objXzMajorEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
objXzMajorEN.UpdUser = strOpUser;
return clsXzMajorBL.UpdateBySql2(objXzMajorEN);
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
 bolIsExist = clsXzMajorDA.IsExistTable();
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
 bolIsExist = XzMajorDA.IsExistTable(strTabName);
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
 /// <param name = "objXzMajorEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecordBySql2(clsXzMajorEN objXzMajorEN)
{
if (objXzMajorEN.CheckUniqueness_MajorName_CollegeId() == false)
{
var strMsg = string.Format("记录已经存在!专业名称 = [{0}],学院Id = [{1}],是否在用 = [{2}]的数据已经存在!(in clsXzMajorBL.AddNewRecordBySql2)", objXzMajorEN.MajorName,objXzMajorEN.CollegeId,objXzMajorEN.InUse);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objXzMajorEN.id_Major) == true || clsXzMajorBL.IsExist(objXzMajorEN.id_Major) == true)
 {
     objXzMajorEN.id_Major = clsXzMajorBL.GetMaxStrId_S();
 }
bool bolResult = XzMajorDA.AddNewRecordBySQL2(objXzMajorEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsXzMajorBL.ReFreshCache();

if (clsXzMajorBL.relatedActions != null)
{
clsXzMajorBL.relatedActions.UpdRelaTabDate(objXzMajorEN.id_Major, objXzMajorEN.UpdUser);
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
 /// <param name = "objXzMajorEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordBySql2WithReturnKey(clsXzMajorEN objXzMajorEN)
{
if (objXzMajorEN.CheckUniqueness_MajorName_CollegeId() == false)
{
var strMsg = string.Format("记录已经存在!专业名称 = [{0}],学院Id = [{1}],是否在用 = [{2}]的数据已经存在!(in clsXzMajorBL.AddNewRecordBySql2WithReturnKey)", objXzMajorEN.MajorName,objXzMajorEN.CollegeId,objXzMajorEN.InUse);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objXzMajorEN.id_Major) == true || clsXzMajorBL.IsExist(objXzMajorEN.id_Major) == true)
 {
     objXzMajorEN.id_Major = clsXzMajorBL.GetMaxStrId_S();
 }
string strKey = XzMajorDA.AddNewRecordBySQL2WithReturnKey(objXzMajorEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsXzMajorBL.ReFreshCache();

if (clsXzMajorBL.relatedActions != null)
{
clsXzMajorBL.relatedActions.UpdRelaTabDate(objXzMajorEN.id_Major, objXzMajorEN.UpdUser);
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
 /// <param name = "objXzMajorEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(clsXzMajorEN objXzMajorEN)
{
try
{
bool bolResult = XzMajorDA.Update(objXzMajorEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsXzMajorBL.ReFreshCache();

if (clsXzMajorBL.relatedActions != null)
{
clsXzMajorBL.relatedActions.UpdRelaTabDate(objXzMajorEN.id_Major, objXzMajorEN.UpdUser);
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
 /// <param name = "objXzMajorEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateBySql2(clsXzMajorEN objXzMajorEN)
{
 if (string.IsNullOrEmpty(objXzMajorEN.id_Major) == true)
 {
var strMsg = string.Format("(errid:Busi000065)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = XzMajorDA.UpdateBySql2(objXzMajorEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsXzMajorBL.ReFreshCache();

if (clsXzMajorBL.relatedActions != null)
{
clsXzMajorBL.relatedActions.UpdRelaTabDate(objXzMajorEN.id_Major, objXzMajorEN.UpdUser);
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
 /// <param name = "strid_Major">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int DelRecord(string strid_Major)
{
try
{
 clsXzMajorEN objXzMajorEN = clsXzMajorBL.GetObjByid_Major(strid_Major);

if (clsXzMajorBL.relatedActions != null)
{
clsXzMajorBL.relatedActions.UpdRelaTabDate(objXzMajorEN.id_Major, objXzMajorEN.UpdUser);
}
if (objXzMajorEN != null)
{
int intRecNum = XzMajorDA.DelRecord(strid_Major);
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
/// 扩展删除记录，即同时删除多个表的记录，需要基于原子性的事务处理
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DelRecordEx)
/// </summary>
/// <param name="strid_Major">表关键字</param>
/// <returns></returns>
public static bool DelRecordEx(string strid_Major )
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsXzMajorDA.GetSpecSQLObj();
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
//删除与表:[XzMajor]相关的表的代码，需要时去除注释，编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conXzMajor.id_Major,
//strid_Major);
//        clsXzMajorBL.DelXzMajorsByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsXzMajorBL.DelRecord(strid_Major, objConnection, objSqlTransaction);
objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsXzMajorBLEx", "DelRecordEx", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("扩展删除记录出错:{0}！keyId = {1}.({2})",
objException.Message,
strid_Major, clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "strid_Major">给定的关键字值</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回删除是否成功?</returns>
public static bool DelRecord(string strid_Major, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
if (clsXzMajorBL.relatedActions != null)
{
clsXzMajorBL.relatedActions.UpdRelaTabDate(strid_Major, "UpdRelaTabDate");
}
bool bolResult = XzMajorDA.DelRecord(strid_Major,objSqlConnection,objSqlTransaction);
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
 /// <param name = "arrid_MajorLst">给定的关键字值列表</param>
 /// <returns>返回删除的记录数</returns>
public static int DelXzMajors(List<string> arrid_MajorLst)
{
if (arrid_MajorLst.Count == 0) return 0;
try
{
if (clsXzMajorBL.relatedActions != null)
{
foreach (var strid_Major in arrid_MajorLst)
{
clsXzMajorBL.relatedActions.UpdRelaTabDate(strid_Major, "UpdRelaTabDate");
}
}
int intDelRecNum = XzMajorDA.DelXzMajor(arrid_MajorLst);
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
public static int DelXzMajorsByCond(string strWhereCond)
{
try
{
if (clsXzMajorBL.relatedActions != null)
{
List<string> arrid_Major = GetPrimaryKeyID_S(strWhereCond);
foreach (var strid_Major in arrid_Major)
{
clsXzMajorBL.relatedActions.UpdRelaTabDate(strid_Major, "UpdRelaTabDate");
}
}
int intRecNum = XzMajorDA.DelXzMajor(strWhereCond);
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
/// 扩展删除记录，即同时删除多个表的记录，需要基于原子性的事务处理
/// 这里仅仅是演示函数，使用时请复制到扩展类:[XzMajor]中改名为:[DelRecord4MultiTabEx]使用
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DelRecord4MultiTab)
/// </summary>
/// <param name="strid_Major">表关键字</param>
/// <returns></returns>
public static bool DelRecord4MultiTab(string strid_Major)
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsXzMajorDA.GetSpecSQLObj();
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
//删除与表:[XzMajor]相关的表的代码，需要时去除注释，编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conStudent.id_College,
//strid_College);
//        clsStudentBL.DelStudentsByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsXzMajorBL.DelRecord(strid_Major, objConnection, objSqlTransaction);
                objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsXzMajorBL", "DelRecord4MultiTab", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("删除多表记录出错:{0}！keyId = {1}.({2})",
objException.Message,
strid_Major, clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "objXzMajorENS">源对象</param>
 /// <param name = "objXzMajorENT">目标对象</param>
 public static void CopyTo(clsXzMajorEN objXzMajorENS, clsXzMajorEN objXzMajorENT)
{
try
{
objXzMajorENT.id_Major = objXzMajorENS.id_Major; //专业流水号
objXzMajorENT.MajorID = objXzMajorENS.MajorID; //MajorID
objXzMajorENT.MajorName = objXzMajorENS.MajorName; //专业名称
objXzMajorENT.IsMainMajor = objXzMajorENS.IsMainMajor; //是否重要专业
objXzMajorENT.CollegeId = objXzMajorENS.CollegeId; //学院Id
objXzMajorENT.OrderNum = objXzMajorENS.OrderNum; //排序
objXzMajorENT.InUse = objXzMajorENS.InUse; //是否在用
objXzMajorENT.UpdDate = objXzMajorENS.UpdDate; //修改日期
objXzMajorENT.UpdUser = objXzMajorENS.UpdUser; //修改用户
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
 /// <param name = "objXzMajorEN">源简化对象</param>
 public static void SetUpdFlag(clsXzMajorEN objXzMajorEN)
{
try
{
objXzMajorEN.ClearUpdateState();
   string strsf_UpdFldSetStr = objXzMajorEN.sf_UpdFldSetStr;
    string[] sstrFldSet = strsf_UpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(conXzMajor.id_Major, new clsStrCompareIgnoreCase())  ==  true)
{
objXzMajorEN.id_Major = objXzMajorEN.id_Major; //专业流水号
}
if (arrFldSet.Contains(conXzMajor.MajorID, new clsStrCompareIgnoreCase())  ==  true)
{
objXzMajorEN.MajorID = objXzMajorEN.MajorID; //MajorID
}
if (arrFldSet.Contains(conXzMajor.MajorName, new clsStrCompareIgnoreCase())  ==  true)
{
objXzMajorEN.MajorName = objXzMajorEN.MajorName == "[null]" ? null :  objXzMajorEN.MajorName; //专业名称
}
if (arrFldSet.Contains(conXzMajor.IsMainMajor, new clsStrCompareIgnoreCase())  ==  true)
{
objXzMajorEN.IsMainMajor = objXzMajorEN.IsMainMajor; //是否重要专业
}
if (arrFldSet.Contains(conXzMajor.CollegeId, new clsStrCompareIgnoreCase())  ==  true)
{
objXzMajorEN.CollegeId = objXzMajorEN.CollegeId; //学院Id
}
if (arrFldSet.Contains(conXzMajor.OrderNum, new clsStrCompareIgnoreCase())  ==  true)
{
objXzMajorEN.OrderNum = objXzMajorEN.OrderNum; //排序
}
if (arrFldSet.Contains(conXzMajor.InUse, new clsStrCompareIgnoreCase())  ==  true)
{
objXzMajorEN.InUse = objXzMajorEN.InUse; //是否在用
}
if (arrFldSet.Contains(conXzMajor.UpdDate, new clsStrCompareIgnoreCase())  ==  true)
{
objXzMajorEN.UpdDate = objXzMajorEN.UpdDate == "[null]" ? null :  objXzMajorEN.UpdDate; //修改日期
}
if (arrFldSet.Contains(conXzMajor.UpdUser, new clsStrCompareIgnoreCase())  ==  true)
{
objXzMajorEN.UpdUser = objXzMajorEN.UpdUser == "[null]" ? null :  objXzMajorEN.UpdUser; //修改用户
}
}
catch (Exception objException)
{
var strMsg = string.Format("(errid:Busi000064)设置表的修改标志出错,{1}.({0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
}
}

 /// <summary>
 /// 处理从Web端传来的[null]的字段值，在WebApi端设置成null
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_AccessFldValueNull)
 /// </summary>
 /// <param name = "objXzMajorEN">源简化对象</param>
 public static void AccessFldValueNull(clsXzMajorEN objXzMajorEN)
{
try
{
if (objXzMajorEN.MajorName == "[null]") objXzMajorEN.MajorName = null; //专业名称
if (objXzMajorEN.UpdDate == "[null]") objXzMajorEN.UpdDate = null; //修改日期
if (objXzMajorEN.UpdUser == "[null]") objXzMajorEN.UpdUser = null; //修改用户
}
catch (Exception objException)
{
var strMsg = string.Format("(errid:Busi000170)处理从Web端传来的[null]的字段值出错,{1}.({0})",
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
public static void CheckPropertyNew(clsXzMajorEN objXzMajorEN)
{
 XzMajorDA.CheckPropertyNew(objXzMajorEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(clsXzMajorEN objXzMajorEN)
{
 XzMajorDA.CheckProperty4Condition(objXzMajorEN);
 }


 #endregion 检查对象属性


 #region 绑定下拉框

 /// <summary>
 /// 绑定基于Win的下拉框
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_TabFeature_ComboBoxBindFunction)
 /// </summary>
 /// <param name = "objComboBox">需要绑定当前表的下拉框</param>
 /// <param name = "strCollegeId">学院Id</param>
public static void BindCbo_id_Major(System.Windows.Forms.ComboBox objComboBox , string strCollegeId)
{
//为数据源为表的下拉框设置内容
string strCondition = string.Format("1 =1 Order By {0}", conXzMajor.id_Major); 
List<clsXzMajorEN> arrObjLst = clsXzMajorBL.GetObjLst(strCondition);
arrObjLst = arrObjLst.Where(x=>x.CollegeId == strCollegeId).ToList();
//初始化一个对象列表
//插入第0项。在第0项中插入“请选择...”,为了方便用户,与WEB方式类似。
clsXzMajorEN objXzMajorEN = new clsXzMajorEN()
{
id_Major = "0",
MajorName = "选[专业]..."
};
arrObjLst.Insert(0, objXzMajorEN);
//设置下拉框的数据源、以及设置值项、显示项
objComboBox.ValueMember = conXzMajor.id_Major;
objComboBox.DisplayMember = conXzMajor.MajorName;
objComboBox.DataSource = arrObjLst;
objComboBox.SelectedIndex = 0;
}

 /// <summary>
 /// 绑定基于Web的下拉框
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_TabFeature_DdlBindFunction)
 /// </summary>
 /// <param name = "objDDL">需要绑定当前表的下拉框</param>
 /// <param name = "strCollegeId">学院Id</param>
public static void BindDdl_id_Major(System.Web.UI.WebControls.DropDownList objDDL , string strCollegeId)
{
//为数据源于表的下拉框设置内容
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[专业]...","0");
string strCondition = string.Format("1 =1 Order By {0}", conXzMajor.id_Major); 
IEnumerable<clsXzMajorEN> arrObjLst = clsXzMajorBL.GetObjLst(strCondition);
arrObjLst = arrObjLst.Where(x=>x.CollegeId == strCollegeId);
objDDL.DataValueField = conXzMajor.id_Major;
objDDL.DataTextField = conXzMajor.MajorName;
objDDL.DataSource = arrObjLst;
objDDL.DataBind();
objDDL.Items.Insert(0, li);
objDDL.SelectedIndex = 0;
}

 /// <summary>
 /// 绑定基于Web的下拉框-使用Cache
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DdlBindFunction_Cache)
 /// </summary>
 /// <param name = "objDDL">需要绑定当前表的下拉框</param>
public static void BindDdl_id_Major_Cache(System.Web.UI.WebControls.DropDownList objDDL)
{
//为数据源于表的下拉框设置内容
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[专业]...","0");
List<clsXzMajorEN> arrXzMajorObjLst = GetAllXzMajorObjLst_Cache(); 
arrXzMajorObjLst = arrXzMajorObjLst.OrderBy(x=>x.OrderNum).ToList(); 
objDDL.DataValueField = conXzMajor.id_Major;
objDDL.DataTextField = conXzMajor.MajorName;
objDDL.DataSource = arrXzMajorObjLst;
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
if (clsXzMajorBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsXzMajorBL没有刷新缓存机制(clsXzMajorBL.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by id_Major");
//if (arrXzMajorObjLst_Cache == null)
//{
//arrXzMajorObjLst_Cache = XzMajorDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey_Cache)
 /// </summary>
 /// <param name = "strid_Major">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsXzMajorEN GetObjByid_Major_Cache(string strid_Major)
{
//获取缓存中的对象列表
string strKey = string.Format("{0}", clsXzMajorEN._CurrTabName_S);
List<clsXzMajorEN> arrXzMajorObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsXzMajorEN> arrXzMajorObjLst_Sel =
arrXzMajorObjLst_Cache
.Where(x=> x.id_Major == strid_Major 
);
if (arrXzMajorObjLst_Sel.Count() == 0)
{
   clsXzMajorEN obj = clsXzMajorBL.GetObjByid_Major(strid_Major);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
 }
return null;
}
return arrXzMajorObjLst_Sel.First();
}

 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecNameByKey_Cache)
 /// </summary>
 /// <param name = "strid_Major">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetMajorNameByid_Major_Cache(string strid_Major)
{
if (string.IsNullOrEmpty(strid_Major) == true) return "";
//获取缓存中的对象列表
clsXzMajorEN objXzMajor = GetObjByid_Major_Cache(strid_Major);
if (objXzMajor == null) return "";
return objXzMajor.MajorName;
}
 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecNameByKey_Cache)
 /// </summary>
 /// <param name = "strid_Major">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetNameByid_Major_Cache(string strid_Major)
{
if (string.IsNullOrEmpty(strid_Major) == true) return "";
//获取缓存中的对象列表
clsXzMajorEN objXzMajor = GetObjByid_Major_Cache(strid_Major);
if (objXzMajor == null) return "";
return objXzMajor.MajorName;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLst_Cache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsXzMajorEN> GetAllXzMajorObjLst_Cache()
{
//获取缓存中的对象列表
List<clsXzMajorEN> arrXzMajorObjLst_Cache = GetObjLst_Cache(); 
return arrXzMajorObjLst_Cache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst_Cache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsXzMajorEN> GetObjLst_Cache()
{
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}", clsXzMajorEN._CurrTabName_S);
List<clsXzMajorEN> arrXzMajorObjLst_Cache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrXzMajorObjLst_Cache;
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
string strKey = string.Format("{0}", clsXzMajorEN._CurrTabName_S);
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
if (clsXzMajorBL.objCommFun4BL != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}", clsXzMajorEN._CurrTabName_S);
CacheHelper.Remove(strKey);
clsXzMajorBL.objCommFun4BL.ReFreshCache();
}
}


 #endregion 缓存操作


 #region 检查唯一性

 /// <summary>
 /// 检查唯一性(Uniqueness)--专业名称(MajorName), 如果不唯一,即存在相同的记录,就返回False
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_CheckUniqueness)
 /// </summary>
 /// <param name = "strid_Major">专业流水号(主键)</param>
 /// <param name = "strMajorName">专业名称(要求唯一的字段)</param>
 /// <returns></returns>
public static bool CheckMajorNameUniqueness(string strid_Major, string strMajorName)
{
//检测记录是否存在
bool bolIsUniqueness = XzMajorDA.CheckMajorNameUniqueness(strid_Major, strMajorName);
return bolIsUniqueness;
}
 /// <summary>
 /// 检查唯一性(Uniqueness)--学院Id(CollegeId), 如果不唯一,即存在相同的记录,就返回False
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_CheckUniqueness)
 /// </summary>
 /// <param name = "strid_Major">专业流水号(主键)</param>
 /// <param name = "strCollegeId">学院Id(要求唯一的字段)</param>
 /// <returns></returns>
public static bool CheckCollegeIdUniqueness(string strid_Major, string strCollegeId)
{
//检测记录是否存在
bool bolIsUniqueness = XzMajorDA.CheckCollegeIdUniqueness(strid_Major, strCollegeId);
return bolIsUniqueness;
}

 /// <summary>
 /// 检查唯一性(Uniqueness)--XzMajor(专业), 如果不唯一,即存在相同的记录,就返回False
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_CheckUniquenessV3)
 /// </summary>
 /// <param name = "objXzMajorEN">要求唯一的对象</param>
 /// <returns></returns>
public static bool CheckXzMajorUniqueness(clsXzMajorEN objXzMajorEN)
{
//检测记录是否存在
bool bolIsUniqueness;
if (objXzMajorEN == null) return true;
if (objXzMajorEN.id_Major == null || objXzMajorEN.id_Major == "")
{
bolIsUniqueness = XzMajorDA.CheckXzMajorUniqueness(objXzMajorEN.MajorName, objXzMajorEN.CollegeId);
}
else
{
bolIsUniqueness = XzMajorDA.CheckXzMajorUniqueness(objXzMajorEN.id_Major, objXzMajorEN.MajorName, objXzMajorEN.CollegeId);
}
return bolIsUniqueness;
}

 /// <summary>
 /// 获取检查唯一性条件串(Uniqueness)--XzMajor(专业)
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetUniquenessConditionString)
 /// </summary>
 /// <param name = "objXzMajorEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr_MajorName_CollegeId(clsXzMajorEN objXzMajorEN)
{
//检测记录是否存在
string strResult = XzMajorDA.GetUniCondStr_MajorName_CollegeId(objXzMajorEN);
return strResult;
}


 #endregion 检查唯一性

 /// <summary>
 /// 映射函数。根据表映射把输入字段值，映射成输出字段值
 /// 作者:pyf
 /// 日期:2023-03-11
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_func)
 /// </summary>
 /// <param name = "strInFldName">输入字段名</param>
 /// <param name = "strOutFldName">输出字段名</param>
 /// <param name = "strInValue">输入字段值</param>
 /// <returns>返回一个输出字段值</returns>
public static string Func(string strInFldName, string strOutFldName, string strid_Major)
{
if (strInFldName != conXzMajor.id_Major)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (conXzMajor.AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确，不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", conXzMajor.AttributeName));
throw new Exception(strMsg);
}
var objXzMajor = clsXzMajorBL.GetObjByid_Major_Cache(strid_Major);
if (objXzMajor == null) return "";
return objXzMajor[strOutFldName].ToString();
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
int intRecCount = clsXzMajorDA.GetRecCount(strTabName);
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
int intRecCount = clsXzMajorDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsXzMajorDA.GetRecCount();
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
int intRecCount = clsXzMajorDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObj_Cache)
 /// </summary>
 /// <param name = "objXzMajor_Cond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCond_Cache(clsXzMajorEN objXzMajor_Cond)
{
List<clsXzMajorEN> arrObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsXzMajorEN> arrObjLst_Sel = arrObjLst_Cache;
foreach (string strFldName in conXzMajor.AttributeName)
{
if (objXzMajor_Cond.IsUpdated(strFldName) == false) continue;
if (objXzMajor_Cond.dicFldComparisonOp == null)
{
arrObjLst_Sel = arrObjLst_Sel.Where(x => x[strFldName].ToString() == objXzMajor_Cond[strFldName].ToString());
}
else
{
if (objXzMajor_Cond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objXzMajor_Cond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLst_Sel = arrObjLst_Sel.Where(x => x[strFldName].ToString() == objXzMajor_Cond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLst_Sel = arrObjLst_Sel.Where(x => x[strFldName].ToString().Contains(objXzMajor_Cond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLst_Sel = arrObjLst_Sel.Where(x => x[strFldName].ToString().Length > int.Parse(objXzMajor_Cond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLst_Sel = arrObjLst_Sel.Where(x => x[strFldName].ToString().Length <= int.Parse(objXzMajor_Cond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLst_Sel = arrObjLst_Sel.Where(x => x[strFldName].ToString().Length >= int.Parse(objXzMajor_Cond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLst_Sel = arrObjLst_Sel.Where(x => x[strFldName].ToString().Length < int.Parse(objXzMajor_Cond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLst_Sel = arrObjLst_Sel.Where(x => x[strFldName].ToString().Length == int.Parse(objXzMajor_Cond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objXzMajor_Cond[strFldName].ToString().Split(",".ToCharArray());
arrObjLst_Sel = arrObjLst_Sel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLst_Sel = arrObjLst_Sel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objXzMajor_Cond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLst_Sel = arrObjLst_Sel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objXzMajor_Cond[strFldName]));
}
}
}
return arrObjLst_Sel.Count();
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
 List<string> arrList = clsXzMajorDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = XzMajorDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = XzMajorDA.GetFldValueNoDistinct(strFldName, strWhereCond);
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
int intRecCount = XzMajorDA.SetFldValue(strFldName, strValue, strWhereCond);
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
int intRecCount = clsXzMajorDA.SetFldValue(clsXzMajorEN._CurrTabName_S, strFldName, fltValue, strWhereCond);
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
int intRecCount = XzMajorDA.SetFldValue( strFldName, intValue, strWhereCond);
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
int intRecCount = clsXzMajorDA.SetFldValue(strTabName, strFldName, strValue, strWhereCond);
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
int intRecCount = clsXzMajorDA.SetFldValue(strTabName, strFldName, intValue, strWhereCond);
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
int intRecCount = clsXzMajorDA.SetFldValue(strTabName, strFldName, fltValue, strWhereCond);
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
  strCreateTabCode.Append("CREATE table [dbo].[XzMajor] "); 
 strCreateTabCode.Append(" ( "); 
 // /**专业流水号*/ 
 strCreateTabCode.Append(" id_Major char(8) primary key, "); 
 // /**MajorID*/ 
 strCreateTabCode.Append(" MajorID char(4) not Null, "); 
 // /**专业名称*/ 
 strCreateTabCode.Append(" MajorName varchar(100) Null, "); 
 // /**是否重要专业*/ 
 strCreateTabCode.Append(" IsMainMajor bit Null, "); 
 // /**学院Id*/ 
 strCreateTabCode.Append(" CollegeId varchar(6) not Null, "); 
 // /**排序*/ 
 strCreateTabCode.Append(" OrderNum int Null, "); 
 // /**是否在用*/ 
 strCreateTabCode.Append(" InUse bit Null, "); 
 // /**修改日期*/ 
 strCreateTabCode.Append(" UpdDate varchar(20) Null, "); 
 // /**修改用户*/ 
 strCreateTabCode.Append(" UpdUser varchar(20) Null ");
 strCreateTabCode.Append(") "); 
  strCreateTabCode.Append("ON [PRIMARY] ");
  return strCreateTabCode.ToString();
}



 #endregion 表操作


 #region 排序相关函数

/// <summary>
/// 重新排序。根据分类字段：CollegeId单独排序
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_TabFeature_ReOrder)
/// </summary>
/// <param name="strCollegeId">分类字段</param>
/// <returns></returns>
public static bool ReOrder(string strCollegeId)
{
try
{
string strCondition = " 1=1 ";
strCondition += string.Format(" And {0} = '{1}' ", conXzMajor.CollegeId, strCollegeId);
 strCondition += string.Format(" order by OrderNum ");
List<clsXzMajorEN> arrXzMajorObjList = new clsXzMajorDA().GetObjLst(strCondition);
    
int intIndex = 1;
foreach (clsXzMajorEN objXzMajor in arrXzMajorObjList)
{
objXzMajor.OrderNum = intIndex;
UpdateBySql2(objXzMajor);
intIndex++;
}
return true; 
}
catch (Exception objException)
{
string strMsg = string.Format("重序出错, {0}. (from {1})", objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
}

/// <summary>
/// 调整所给关键字记录的序号。根据分类字段：CollegeId单独排序
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_TabFeature_AdjustOrderNum)
/// </summary>
/// <param name="strDirect">方向：用"Up","Down"表示</param>
/// <param name="strid_Major">所给的关键字</param>
/// <param name="strCollegeId">分类字段</param>
/// <returns>是否成功?</returns>
public static bool AdjustOrderNum(string strDirect, string strid_Major, string strCollegeId)
{
try
{
//操作步骤：
//1、根据所给定的关键字[id_Major]，获取相应的序号[OrderNum]；
//2、如果当前序号是否是末端序号；
//3、如果是末端序号，就退出；
//   3.1、如果是向下移动，判断当前序号是否“小于”当前表中的字段数，
//	   即不是最后一个记录，就准备把当前字段项的序号加1，而下一字段的序号减1，
//   3.2、如果是向上移动，就判断当前序号是否“大于”1，
//	   即不是第一条记录，就准备把当前字段项的序号减1，而上一字段的序号加1。
//4、获取下(上)一个序号记录的关键字id_Major
//5、把当前关键字id_Major所对应记录的序号加(减)1
//6、把下(上)一个序号关键字id_Major所对应的记录序号减(加)1
string strMsg;
int intOrderNum;    //当前记录的序号
int intPrevOrderNum, intNextOrderNum;   //上下两条记录的序号
string strPrevid_Major = "";    //上一条序号的关键字id_Major
string strNextid_Major = "";    //下一条序号的关键字id_Major
int intTabRecNum;       //当前表中字段的记录数
StringBuilder sbCondition = new StringBuilder();
//1、根据所给定的关键字[id_Major]，获取相应的序号[OrderNum]。

clsXzMajorEN objXzMajor = clsXzMajorBL.GetObjByid_Major(strid_Major);

intOrderNum = objXzMajor.OrderNum;//当前序号
intPrevOrderNum = intOrderNum - 1;//前一条记录的序号
intNextOrderNum = intOrderNum + 1;//后一条记录的序号
//3、如果当前序号是否是末端序号，
//		3.1 如果是末端序号，就退出，

string strCondition = " 1=1 ";
strCondition += string.Format(" And {0} = '{1}' ", conXzMajor.CollegeId, strCollegeId);
intTabRecNum = clsXzMajorBL.GetRecCountByCond(clsXzMajorEN._CurrTabName_S, strCondition);    //获取当前表的记录数
switch (strDirect)
{
case "UP":
case "Up":
case "up":
//3、如果是末端序号，就退出；
//  3.2、如果是向上移动，就判断当前序号是否“大于”1，
//	     即不是第一条记录，就准备把当前字段项的序号减1，而上一字段的序号加1。
if (intOrderNum <= 1)
{
strMsg = string.Format("已经是第一条记录，不能再上移.(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//		3.2 如果不是，即如果是向下移动，就判断当前序号是否“小于”当前表中的字段数，
//		    即不是最后一个记录，就准备把当前字段项的序号加1，而下一字段的序号减1，
//		    如果是向上移动，就判断当前序号是否“大于”1，
//		    即不是最开始一个记录，就准备把当前字段项的序号减1，而上一字段的序号加1。
sbCondition.AppendFormat(" {0} = {1} ", conXzMajor.OrderNum, intOrderNum - 1);
sbCondition.AppendFormat(" And {0} = '{1}' ", conXzMajor.CollegeId, strCollegeId);
//4、获取上一个序号字段的关键字id_Major
strPrevid_Major = clsXzMajorBL.GetFirstID_S(sbCondition.ToString());
if (string.IsNullOrEmpty(strPrevid_Major) == true)
{
strMsg = string.Format("获取上一条记录的关键字出错.(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//5、把当前关键字id_Major所对应记录的序号减1
//6、把下(上)一个序号关键字id_Major所对应的记录序号加1
clsXzMajorBL.SetFldValue(clsXzMajorEN._CurrTabName_S, conXzMajor.OrderNum,
 	 	intOrderNum - 1,
  	 	string.Format("{0} = '{1}'", conXzMajor.id_Major, strid_Major));
clsXzMajorBL.SetFldValue(clsXzMajorEN._CurrTabName_S, conXzMajor.OrderNum,
 	 	intPrevOrderNum + 1,
 	 	string.Format("{0} = '{1}'", conXzMajor.id_Major, strPrevid_Major));
break;
case "DOWN":
case "Down":
case "down":
//3、如果是末端序号，就退出；
//   3.1、如果是向下移动，判断当前序号是否“小于”当前表中的字段数，
//	   即不是最后一个记录，就准备把当前字段项的序号加1，而下一字段的序号减1，
if (intOrderNum >= intTabRecNum)    //如果当前序号大于表记录数
{
strMsg = string.Format("已经是最后一条记录，不能再下移.(from {0})", clsStackTrace.GetCurrClassFunction());
                            throw new Exception(strMsg);
}

//4、获取下一个序号字段的关键字id_Major
sbCondition.AppendFormat(" {0} = {1} ", conXzMajor.OrderNum, intOrderNum + 1);
sbCondition.AppendFormat(" And {0} = '{1}' ", conXzMajor.CollegeId, strCollegeId);

strNextid_Major = clsXzMajorBL.GetFirstID_S(sbCondition.ToString());
if (string.IsNullOrEmpty(strNextid_Major) == true)
{
strMsg = string.Format("获取下一条记录的关键字出错.(from {0})", clsStackTrace.GetCurrClassFunction());

throw new Exception(strMsg);
}
//5、把当前关键字id_Major所对应记录的序号加1
//6、把下(上)一个序号关键字id_Major所对应的记录序号减1
clsXzMajorBL.SetFldValue(clsXzMajorEN._CurrTabName_S, conXzMajor.OrderNum,
 	 	intOrderNum + 1,
 	 	string.Format("{0} = '{1}'", conXzMajor.id_Major, strid_Major));
clsXzMajorBL.SetFldValue(clsXzMajorEN._CurrTabName_S, conXzMajor.OrderNum,
 	 	intNextOrderNum - 1,
 	 	string.Format("{0} = '{1}'", conXzMajor.id_Major, strNextid_Major));
break;
default:
strMsg = string.Format("方向参数出错!strDirect=[{0}]({1})",
 	 	strDirect,
 	 	clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
return true;
}
catch (Exception objException)
{
string strMsg = string.Format("调整记录次序出错！错误:[{0}]({1})",
 	 	objException.Message,
 	 	clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
}

/// <summary>
/// 把所给的关键字列表所对应的对象置顶。根据分类字段：CollegeId单独排序
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_TabFeature_GoBottom)
/// </summary>
/// <param name="arrKeyId">所给的关键字列表</param>
/// <returns></returns>
public static bool GoBottom(List<string> arrKeyId, string strCollegeId)
{
try
{
if (arrKeyId.Count == 0) return true;
string strKeyList = clsArray.GetSqlInStrByArray(arrKeyId, true);
string strCondition = string.Format("{0} in ({1})", conXzMajor.id_Major, strKeyList);
List<clsXzMajorEN> arrXzMajorLst = GetObjLst(strCondition);
foreach (clsXzMajorEN objXzMajor in arrXzMajorLst)
{
objXzMajor.OrderNum = objXzMajor.OrderNum + 10000;
UpdateBySql2(objXzMajor);
}
strCondition = " 1=1 ";
strCondition += string.Format(" And {0} = '{1}' ", conXzMajor.CollegeId, strCollegeId);
 strCondition += string.Format(" order by OrderNum ");
List<clsXzMajorEN> arrXzMajorObjList = new clsXzMajorDA().GetObjLst(strCondition);
    
int intIndex = 1;
foreach (clsXzMajorEN objXzMajor in arrXzMajorObjList)
{
objXzMajor.OrderNum = intIndex;
UpdateBySql2(objXzMajor);
intIndex++;
}
return true; 
}
catch (Exception objException)
{
string strMsg = string.Format("置顶出错, {0}. (from {1})", objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
}

/// <summary>
/// 把所给的关键字列表所对应的对象置顶。根据分类字段：CollegeId单独排序
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_TabFeature_GoTop)
/// </summary>
/// <param name="arrKeyId">所给的关键字列表</param>
/// <param name="strCollegeId">分类字段</param>
/// <returns></returns>
public static bool GoTop(List<string> arrKeyId, string strCollegeId)
{
try
{
if (arrKeyId.Count == 0) return true;
string strKeyList = clsArray.GetSqlInStrByArray(arrKeyId, true);
string strCondition = string.Format("{0} in ({1})", conXzMajor.id_Major, strKeyList);
List<clsXzMajorEN> arrXzMajorLst = GetObjLst(strCondition);
foreach (clsXzMajorEN objXzMajor in arrXzMajorLst)
{
objXzMajor.OrderNum = objXzMajor.OrderNum - 10000;
UpdateBySql2(objXzMajor);
}
strCondition = " 1=1 ";
strCondition += string.Format(" And {0} = '{1}' ", conXzMajor.CollegeId, strCollegeId);
 strCondition += string.Format(" order by OrderNum ");
List<clsXzMajorEN> arrXzMajorObjList = new clsXzMajorDA().GetObjLst(strCondition);
    
int intIndex = 1;
foreach (clsXzMajorEN objXzMajor in arrXzMajorObjList)
{
objXzMajor.OrderNum = intIndex;
UpdateBySql2(objXzMajor);
intIndex++;
}
return true; 
}
catch (Exception objException)
{
string strMsg = string.Format("置顶出错,{0}. (from {1})", objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
}


 #endregion 排序相关函数
}
 /// <summary>
 /// 专业(XzMajor)
 /// 数据源类型:表
 /// (AutoGCLib.CommFun4BL4CSharp:GeneCode_This)
 /// </summary>
public class clsCommFun4BL4XzMajor : clsCommFun4BL
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
clsXzMajorBL.ReFreshThisCache();
}
}

}