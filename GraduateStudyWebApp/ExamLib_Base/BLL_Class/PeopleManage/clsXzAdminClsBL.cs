﻿
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsXzAdminClsBL
 表名:XzAdminCls(01120194)
 * 版本:2024.11.13.1(服务器:WIN-SRV103-116)
 日期:2024/11/13 05:59:11
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:研究生学习游戏化后台(000055, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:人员管理(PeopleManage)
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
public static class  clsXzAdminClsBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "strIdAdminCls">表关键字</param>
 /// <returns>表对象</returns>
public static clsXzAdminClsEN GetObj(this K_IdAdminCls_XzAdminCls myKey)
{
clsXzAdminClsEN objXzAdminClsEN = clsXzAdminClsBL.XzAdminClsDA.GetObjByIdAdminCls(myKey.Value);
return objXzAdminClsEN;
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_AddNewRecord)
 /// </summary>
 /// <param name = "objXzAdminClsEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clsXzAdminClsEN objXzAdminClsEN, bool bolIsNeedCheckUniqueness = true)
{
if (bolIsNeedCheckUniqueness == true && CheckUniqueness(objXzAdminClsEN) == false)
{
var strMsg = string.Format("记录已经存在!行政班名称 = [{0}]的数据已经存在!(in clsXzAdminClsBL.AddNewRecord)", objXzAdminClsEN.AdminClsName);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objXzAdminClsEN.IdAdminCls) == true || clsXzAdminClsBL.IsExist(objXzAdminClsEN.IdAdminCls) == true)
 {
     objXzAdminClsEN.IdAdminCls = clsXzAdminClsBL.GetMaxStrId_S();
 }
bool bolResult = clsXzAdminClsBL.XzAdminClsDA.AddNewRecordBySQL2(objXzAdminClsEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsXzAdminClsBL.ReFreshCache();

if (clsXzAdminClsBL.relatedActions != null)
{
clsXzAdminClsBL.relatedActions.UpdRelaTabDate(objXzAdminClsEN.IdAdminCls, "SetUpdDate");
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
public static bool AddRecordEx(this clsXzAdminClsEN objXzAdminClsEN, bool bolIsNeedCheckUniqueness = true)
{
//操作步骤:
//1、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在
//2、检查唯一性
//3、检查传进去的对象属性是否合法
//4、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
//1、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在

//因为是字符型自增主键,不需要检查主键是否已经存在,在添加时,再获取 最大值作为主键
//if (clsXzAdminClsBL.IsExist(objXzAdminClsEN.IdAdminCls))	//判断是否有相同的关键字
//{
//strMsg = "(errid:Busi000151)关键字字段已有相同的值";
//throw new Exception(strMsg);
//}
try
{
 //2、检查传进去的对象属性是否合法
objXzAdminClsEN.CheckPropertyNew();
 ///5.2、检查唯一性
if (bolIsNeedCheckUniqueness == true && objXzAdminClsEN.CheckUniqueness() == false)
{
strMsg = string.Format("(行政班名称(AdminClsName)=[{0}])已经存在,不能重复!", objXzAdminClsEN.AdminClsName);
throw new Exception(strMsg);
}
//因为是字符型自增主键,所以在添加时,自动获取主键值。
 if (string.IsNullOrEmpty(objXzAdminClsEN.IdAdminCls) == true || clsXzAdminClsBL.IsExist(objXzAdminClsEN.IdAdminCls) == true)
 {
     objXzAdminClsEN.IdAdminCls = clsXzAdminClsBL.GetMaxStrId_S();
 }
//6、把数据实体层的数据存贮到数据库中
objXzAdminClsEN.AddNewRecord();
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
 /// <param name = "objXzAdminClsEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static string AddNewRecordWithMaxId(this clsXzAdminClsEN objXzAdminClsEN, bool bolIsNeedCheckUniqueness = true)
{
if (bolIsNeedCheckUniqueness == true && CheckUniqueness(objXzAdminClsEN) == false)
{
var strMsg = string.Format("记录已经存在!行政班名称 = [{0}]的数据已经存在!(in clsXzAdminClsBL.AddNewRecordWithMaxId)", objXzAdminClsEN.AdminClsName);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objXzAdminClsEN.IdAdminCls) == true || clsXzAdminClsBL.IsExist(objXzAdminClsEN.IdAdminCls) == true)
 {
     objXzAdminClsEN.IdAdminCls = clsXzAdminClsBL.GetMaxStrId_S();
 }
string strIdAdminCls = clsXzAdminClsBL.XzAdminClsDA.AddNewRecordBySQL2WithReturnKey(objXzAdminClsEN);
     objXzAdminClsEN.IdAdminCls = strIdAdminCls;
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsXzAdminClsBL.ReFreshCache();

if (clsXzAdminClsBL.relatedActions != null)
{
clsXzAdminClsBL.relatedActions.UpdRelaTabDate(objXzAdminClsEN.IdAdminCls, "SetUpdDate");
}
return strIdAdminCls;
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
 /// <param name = "objXzAdminClsEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordWithReturnKey(this clsXzAdminClsEN objXzAdminClsEN, bool bolIsNeedCheckUniqueness = true)
{
if (bolIsNeedCheckUniqueness == true && CheckUniqueness(objXzAdminClsEN) == false)
{
var strMsg = string.Format("记录已经存在!行政班名称 = [{0}]的数据已经存在!(in clsXzAdminClsBL.AddNewRecordWithReturnKey)", objXzAdminClsEN.AdminClsName);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objXzAdminClsEN.IdAdminCls) == true || clsXzAdminClsBL.IsExist(objXzAdminClsEN.IdAdminCls) == true)
 {
     objXzAdminClsEN.IdAdminCls = clsXzAdminClsBL.GetMaxStrId_S();
 }
string strKey = clsXzAdminClsBL.XzAdminClsDA.AddNewRecordBySQL2WithReturnKey(objXzAdminClsEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsXzAdminClsBL.ReFreshCache();

if (clsXzAdminClsBL.relatedActions != null)
{
clsXzAdminClsBL.relatedActions.UpdRelaTabDate(objXzAdminClsEN.IdAdminCls, "SetUpdDate");
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
 /// <param name = "objXzAdminClsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsXzAdminClsEN SetIdAdminCls(this clsXzAdminClsEN objXzAdminClsEN, string strIdAdminCls, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdAdminCls, 8, conXzAdminCls.IdAdminCls);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdAdminCls, 8, conXzAdminCls.IdAdminCls);
}
objXzAdminClsEN.IdAdminCls = strIdAdminCls; //行政班流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objXzAdminClsEN.dicFldComparisonOp.ContainsKey(conXzAdminCls.IdAdminCls) == false)
{
objXzAdminClsEN.dicFldComparisonOp.Add(conXzAdminCls.IdAdminCls, strComparisonOp);
}
else
{
objXzAdminClsEN.dicFldComparisonOp[conXzAdminCls.IdAdminCls] = strComparisonOp;
}
}
return objXzAdminClsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objXzAdminClsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsXzAdminClsEN SetAdminClsName(this clsXzAdminClsEN objXzAdminClsEN, string strAdminClsName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strAdminClsName, 100, conXzAdminCls.AdminClsName);
}
objXzAdminClsEN.AdminClsName = strAdminClsName; //行政班名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objXzAdminClsEN.dicFldComparisonOp.ContainsKey(conXzAdminCls.AdminClsName) == false)
{
objXzAdminClsEN.dicFldComparisonOp.Add(conXzAdminCls.AdminClsName, strComparisonOp);
}
else
{
objXzAdminClsEN.dicFldComparisonOp[conXzAdminCls.AdminClsName] = strComparisonOp;
}
}
return objXzAdminClsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objXzAdminClsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsXzAdminClsEN SetIdXzMajor(this clsXzAdminClsEN objXzAdminClsEN, string strIdXzMajor, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strIdXzMajor, conXzAdminCls.IdXzMajor);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdXzMajor, 8, conXzAdminCls.IdXzMajor);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdXzMajor, 8, conXzAdminCls.IdXzMajor);
}
objXzAdminClsEN.IdXzMajor = strIdXzMajor; //专业流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objXzAdminClsEN.dicFldComparisonOp.ContainsKey(conXzAdminCls.IdXzMajor) == false)
{
objXzAdminClsEN.dicFldComparisonOp.Add(conXzAdminCls.IdXzMajor, strComparisonOp);
}
else
{
objXzAdminClsEN.dicFldComparisonOp[conXzAdminCls.IdXzMajor] = strComparisonOp;
}
}
return objXzAdminClsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objXzAdminClsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsXzAdminClsEN SetIdXzCollege(this clsXzAdminClsEN objXzAdminClsEN, string strIdXzCollege, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strIdXzCollege, conXzAdminCls.IdXzCollege);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdXzCollege, 4, conXzAdminCls.IdXzCollege);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdXzCollege, 4, conXzAdminCls.IdXzCollege);
}
objXzAdminClsEN.IdXzCollege = strIdXzCollege; //学院流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objXzAdminClsEN.dicFldComparisonOp.ContainsKey(conXzAdminCls.IdXzCollege) == false)
{
objXzAdminClsEN.dicFldComparisonOp.Add(conXzAdminCls.IdXzCollege, strComparisonOp);
}
else
{
objXzAdminClsEN.dicFldComparisonOp[conXzAdminCls.IdXzCollege] = strComparisonOp;
}
}
return objXzAdminClsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objXzAdminClsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsXzAdminClsEN SetIdUniZone(this clsXzAdminClsEN objXzAdminClsEN, string strIdUniZone, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdUniZone, 4, conXzAdminCls.IdUniZone);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdUniZone, 4, conXzAdminCls.IdUniZone);
}
objXzAdminClsEN.IdUniZone = strIdUniZone; //校区流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objXzAdminClsEN.dicFldComparisonOp.ContainsKey(conXzAdminCls.IdUniZone) == false)
{
objXzAdminClsEN.dicFldComparisonOp.Add(conXzAdminCls.IdUniZone, strComparisonOp);
}
else
{
objXzAdminClsEN.dicFldComparisonOp[conXzAdminCls.IdUniZone] = strComparisonOp;
}
}
return objXzAdminClsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objXzAdminClsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsXzAdminClsEN SetCurrentStuQty(this clsXzAdminClsEN objXzAdminClsEN, int? intCurrentStuQty, string strComparisonOp="")
	{
objXzAdminClsEN.CurrentStuQty = intCurrentStuQty; //当前学生数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objXzAdminClsEN.dicFldComparisonOp.ContainsKey(conXzAdminCls.CurrentStuQty) == false)
{
objXzAdminClsEN.dicFldComparisonOp.Add(conXzAdminCls.CurrentStuQty, strComparisonOp);
}
else
{
objXzAdminClsEN.dicFldComparisonOp[conXzAdminCls.CurrentStuQty] = strComparisonOp;
}
}
return objXzAdminClsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objXzAdminClsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsXzAdminClsEN SetIdGradeBase(this clsXzAdminClsEN objXzAdminClsEN, string strIdGradeBase, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strIdGradeBase, conXzAdminCls.IdGradeBase);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdGradeBase, 4, conXzAdminCls.IdGradeBase);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdGradeBase, 4, conXzAdminCls.IdGradeBase);
}
objXzAdminClsEN.IdGradeBase = strIdGradeBase; //年级流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objXzAdminClsEN.dicFldComparisonOp.ContainsKey(conXzAdminCls.IdGradeBase) == false)
{
objXzAdminClsEN.dicFldComparisonOp.Add(conXzAdminCls.IdGradeBase, strComparisonOp);
}
else
{
objXzAdminClsEN.dicFldComparisonOp[conXzAdminCls.IdGradeBase] = strComparisonOp;
}
}
return objXzAdminClsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objXzAdminClsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsXzAdminClsEN SetAdminClsId(this clsXzAdminClsEN objXzAdminClsEN, string strAdminClsId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strAdminClsId, 8, conXzAdminCls.AdminClsId);
}
objXzAdminClsEN.AdminClsId = strAdminClsId; //行政班代号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objXzAdminClsEN.dicFldComparisonOp.ContainsKey(conXzAdminCls.AdminClsId) == false)
{
objXzAdminClsEN.dicFldComparisonOp.Add(conXzAdminCls.AdminClsId, strComparisonOp);
}
else
{
objXzAdminClsEN.dicFldComparisonOp[conXzAdminCls.AdminClsId] = strComparisonOp;
}
}
return objXzAdminClsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objXzAdminClsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsXzAdminClsEN SetIdAdminClsType(this clsXzAdminClsEN objXzAdminClsEN, string strIdAdminClsType, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdAdminClsType, 4, conXzAdminCls.IdAdminClsType);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdAdminClsType, 4, conXzAdminCls.IdAdminClsType);
}
objXzAdminClsEN.IdAdminClsType = strIdAdminClsType; //行政班级类型流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objXzAdminClsEN.dicFldComparisonOp.ContainsKey(conXzAdminCls.IdAdminClsType) == false)
{
objXzAdminClsEN.dicFldComparisonOp.Add(conXzAdminCls.IdAdminClsType, strComparisonOp);
}
else
{
objXzAdminClsEN.dicFldComparisonOp[conXzAdminCls.IdAdminClsType] = strComparisonOp;
}
}
return objXzAdminClsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objXzAdminClsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsXzAdminClsEN SetAdminClsIndex(this clsXzAdminClsEN objXzAdminClsEN, int? intAdminClsIndex, string strComparisonOp="")
	{
objXzAdminClsEN.AdminClsIndex = intAdminClsIndex; //AdminClsIndex
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objXzAdminClsEN.dicFldComparisonOp.ContainsKey(conXzAdminCls.AdminClsIndex) == false)
{
objXzAdminClsEN.dicFldComparisonOp.Add(conXzAdminCls.AdminClsIndex, strComparisonOp);
}
else
{
objXzAdminClsEN.dicFldComparisonOp[conXzAdminCls.AdminClsIndex] = strComparisonOp;
}
}
return objXzAdminClsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objXzAdminClsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsXzAdminClsEN SetMemo(this clsXzAdminClsEN objXzAdminClsEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, conXzAdminCls.Memo);
}
objXzAdminClsEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objXzAdminClsEN.dicFldComparisonOp.ContainsKey(conXzAdminCls.Memo) == false)
{
objXzAdminClsEN.dicFldComparisonOp.Add(conXzAdminCls.Memo, strComparisonOp);
}
else
{
objXzAdminClsEN.dicFldComparisonOp[conXzAdminCls.Memo] = strComparisonOp;
}
}
return objXzAdminClsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objXzAdminClsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsXzAdminClsEN SetModifyUserId(this clsXzAdminClsEN objXzAdminClsEN, string strModifyUserId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strModifyUserId, 18, conXzAdminCls.ModifyUserId);
}
objXzAdminClsEN.ModifyUserId = strModifyUserId; //修改人
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objXzAdminClsEN.dicFldComparisonOp.ContainsKey(conXzAdminCls.ModifyUserId) == false)
{
objXzAdminClsEN.dicFldComparisonOp.Add(conXzAdminCls.ModifyUserId, strComparisonOp);
}
else
{
objXzAdminClsEN.dicFldComparisonOp[conXzAdminCls.ModifyUserId] = strComparisonOp;
}
}
return objXzAdminClsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objXzAdminClsEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsXzAdminClsEN SetModifyDate(this clsXzAdminClsEN objXzAdminClsEN, string strModifyDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strModifyDate, 20, conXzAdminCls.ModifyDate);
}
objXzAdminClsEN.ModifyDate = strModifyDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objXzAdminClsEN.dicFldComparisonOp.ContainsKey(conXzAdminCls.ModifyDate) == false)
{
objXzAdminClsEN.dicFldComparisonOp.Add(conXzAdminCls.ModifyDate, strComparisonOp);
}
else
{
objXzAdminClsEN.dicFldComparisonOp[conXzAdminCls.ModifyDate] = strComparisonOp;
}
}
return objXzAdminClsEN;
	}

 /// <summary>
 /// 修改记录存盘到数据表中
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_UpdateRecordEx)
 /// </summary>
 /// <param name = "objXzAdminClsEN">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool UpdateRecordEx(this clsXzAdminClsEN objXzAdminClsEN)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
try
{
//1、检查传进去的对象属性是否合法
objXzAdminClsEN.CheckPropertyNew();
clsXzAdminClsEN objXzAdminClsCond = new clsXzAdminClsEN();
string strCondition = objXzAdminClsCond
.SetIdAdminCls(objXzAdminClsEN.IdAdminCls, "<>")
.SetAdminClsName(objXzAdminClsEN.AdminClsName, "=")
.GetCombineCondition();
objXzAdminClsEN._IsCheckProperty = true;
bool bolIsExist = clsXzAdminClsBL.IsExistRecord(strCondition);
if (bolIsExist)
{
strMsg = "(AdminClsName)不能重复!";
throw new Exception(strMsg);
}
//4、把数据实体层的数据存贮到数据库中
objXzAdminClsEN.Update();
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
 /// <param name = "objXzAdminCls">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool EditRecordEx(this clsXzAdminClsEN objXzAdminCls)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
clsXzAdminClsEN objXzAdminClsCond = new clsXzAdminClsEN();
string strCondition = objXzAdminClsCond
.SetAdminClsName(objXzAdminCls.AdminClsName, "=")
.GetCombineCondition();
objXzAdminCls._IsCheckProperty = true;
bool bolIsExist = clsXzAdminClsBL.IsExistRecord(strCondition);
if (bolIsExist)
{
objXzAdminCls.IdAdminCls = clsXzAdminClsBL.GetFirstID_S(strCondition);
objXzAdminCls.UpdateWithCondition(strCondition);
}
else
{
objXzAdminCls.IdAdminCls = clsXzAdminClsBL.GetMaxStrId_S();
objXzAdminCls.AddNewRecord();
}
return true; 
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_Update)
 /// </summary>
 /// <param name = "objXzAdminClsEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsXzAdminClsEN objXzAdminClsEN)
{
 if (string.IsNullOrEmpty(objXzAdminClsEN.IdAdminCls) == true)
 {
string strMsg = string.Format("(errid:Busi000095)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsXzAdminClsBL.XzAdminClsDA.UpdateBySql2(objXzAdminClsEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsXzAdminClsBL.ReFreshCache();

if (clsXzAdminClsBL.relatedActions != null)
{
clsXzAdminClsBL.relatedActions.UpdRelaTabDate(objXzAdminClsEN.IdAdminCls, "SetUpdDate");
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
 /// <param name = "objXzAdminClsEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsXzAdminClsEN objXzAdminClsEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (string.IsNullOrEmpty(objXzAdminClsEN.IdAdminCls) == true)
 {
string strMsg = string.Format("(errid:Busi000087)修改记录时关键字不能为空!(带事务处理)(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsXzAdminClsBL.XzAdminClsDA.UpdateBySql2(objXzAdminClsEN, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsXzAdminClsBL.ReFreshCache();

if (clsXzAdminClsBL.relatedActions != null)
{
clsXzAdminClsBL.relatedActions.UpdRelaTabDate(objXzAdminClsEN.IdAdminCls, "SetUpdDate");
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
 /// <param name = "objXzAdminClsEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsXzAdminClsEN objXzAdminClsEN, string strWhereCond)
{
try
{
bool bolResult = clsXzAdminClsBL.XzAdminClsDA.UpdateBySqlWithCondition(objXzAdminClsEN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsXzAdminClsBL.ReFreshCache();

if (clsXzAdminClsBL.relatedActions != null)
{
clsXzAdminClsBL.relatedActions.UpdRelaTabDate(objXzAdminClsEN.IdAdminCls, "SetUpdDate");
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
 /// <param name = "objXzAdminClsEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsXzAdminClsEN objXzAdminClsEN, string strWhereCond, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
bool bolResult = clsXzAdminClsBL.XzAdminClsDA.UpdateBySqlWithConditionTransaction(objXzAdminClsEN, strWhereCond, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsXzAdminClsBL.ReFreshCache();

if (clsXzAdminClsBL.relatedActions != null)
{
clsXzAdminClsBL.relatedActions.UpdRelaTabDate(objXzAdminClsEN.IdAdminCls, "SetUpdDate");
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
 /// <param name = "strIdAdminCls">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int Delete(this clsXzAdminClsEN objXzAdminClsEN)
{
try
{
int intRecNum = clsXzAdminClsBL.XzAdminClsDA.DelRecord(objXzAdminClsEN.IdAdminCls);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsXzAdminClsBL.ReFreshCache();

if (clsXzAdminClsBL.relatedActions != null)
{
clsXzAdminClsBL.relatedActions.UpdRelaTabDate(objXzAdminClsEN.IdAdminCls, "SetUpdDate");
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
 /// <param name = "objXzAdminClsENS">源对象</param>
 /// <param name = "objXzAdminClsENT">目标对象</param>
 public static void CopyTo(this clsXzAdminClsEN objXzAdminClsENS, clsXzAdminClsEN objXzAdminClsENT)
{
try
{
objXzAdminClsENT.IdAdminCls = objXzAdminClsENS.IdAdminCls; //行政班流水号
objXzAdminClsENT.AdminClsName = objXzAdminClsENS.AdminClsName; //行政班名称
objXzAdminClsENT.IdXzMajor = objXzAdminClsENS.IdXzMajor; //专业流水号
objXzAdminClsENT.IdXzCollege = objXzAdminClsENS.IdXzCollege; //学院流水号
objXzAdminClsENT.IdUniZone = objXzAdminClsENS.IdUniZone; //校区流水号
objXzAdminClsENT.CurrentStuQty = objXzAdminClsENS.CurrentStuQty; //当前学生数
objXzAdminClsENT.IdGradeBase = objXzAdminClsENS.IdGradeBase; //年级流水号
objXzAdminClsENT.AdminClsId = objXzAdminClsENS.AdminClsId; //行政班代号
objXzAdminClsENT.IdAdminClsType = objXzAdminClsENS.IdAdminClsType; //行政班级类型流水号
objXzAdminClsENT.AdminClsIndex = objXzAdminClsENS.AdminClsIndex; //AdminClsIndex
objXzAdminClsENT.Memo = objXzAdminClsENS.Memo; //备注
objXzAdminClsENT.ModifyUserId = objXzAdminClsENS.ModifyUserId; //修改人
objXzAdminClsENT.ModifyDate = objXzAdminClsENS.ModifyDate; //修改日期
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
 /// <param name = "objXzAdminClsENS">源对象</param>
 /// <returns>目标对象=>clsXzAdminClsEN:objXzAdminClsENT</returns>
 public static clsXzAdminClsEN CopyTo(this clsXzAdminClsEN objXzAdminClsENS)
{
try
{
 clsXzAdminClsEN objXzAdminClsENT = new clsXzAdminClsEN()
{
IdAdminCls = objXzAdminClsENS.IdAdminCls, //行政班流水号
AdminClsName = objXzAdminClsENS.AdminClsName, //行政班名称
IdXzMajor = objXzAdminClsENS.IdXzMajor, //专业流水号
IdXzCollege = objXzAdminClsENS.IdXzCollege, //学院流水号
IdUniZone = objXzAdminClsENS.IdUniZone, //校区流水号
CurrentStuQty = objXzAdminClsENS.CurrentStuQty, //当前学生数
IdGradeBase = objXzAdminClsENS.IdGradeBase, //年级流水号
AdminClsId = objXzAdminClsENS.AdminClsId, //行政班代号
IdAdminClsType = objXzAdminClsENS.IdAdminClsType, //行政班级类型流水号
AdminClsIndex = objXzAdminClsENS.AdminClsIndex, //AdminClsIndex
Memo = objXzAdminClsENS.Memo, //备注
ModifyUserId = objXzAdminClsENS.ModifyUserId, //修改人
ModifyDate = objXzAdminClsENS.ModifyDate, //修改日期
};
 return objXzAdminClsENT;
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
public static void CheckPropertyNew(this clsXzAdminClsEN objXzAdminClsEN)
{
 clsXzAdminClsBL.XzAdminClsDA.CheckPropertyNew(objXzAdminClsEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(this clsXzAdminClsEN objXzAdminClsEN)
{
 clsXzAdminClsBL.XzAdminClsDA.CheckProperty4Condition(objXzAdminClsEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsXzAdminClsEN objXzAdminClsCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objXzAdminClsCond.IsUpdated(conXzAdminCls.IdAdminCls) == true)
{
string strComparisonOpIdAdminCls = objXzAdminClsCond.dicFldComparisonOp[conXzAdminCls.IdAdminCls];
strWhereCond += string.Format(" And {0} {2} '{1}'", conXzAdminCls.IdAdminCls, objXzAdminClsCond.IdAdminCls, strComparisonOpIdAdminCls);
}
if (objXzAdminClsCond.IsUpdated(conXzAdminCls.AdminClsName) == true)
{
string strComparisonOpAdminClsName = objXzAdminClsCond.dicFldComparisonOp[conXzAdminCls.AdminClsName];
strWhereCond += string.Format(" And {0} {2} '{1}'", conXzAdminCls.AdminClsName, objXzAdminClsCond.AdminClsName, strComparisonOpAdminClsName);
}
if (objXzAdminClsCond.IsUpdated(conXzAdminCls.IdXzMajor) == true)
{
string strComparisonOpIdXzMajor = objXzAdminClsCond.dicFldComparisonOp[conXzAdminCls.IdXzMajor];
strWhereCond += string.Format(" And {0} {2} '{1}'", conXzAdminCls.IdXzMajor, objXzAdminClsCond.IdXzMajor, strComparisonOpIdXzMajor);
}
if (objXzAdminClsCond.IsUpdated(conXzAdminCls.IdXzCollege) == true)
{
string strComparisonOpIdXzCollege = objXzAdminClsCond.dicFldComparisonOp[conXzAdminCls.IdXzCollege];
strWhereCond += string.Format(" And {0} {2} '{1}'", conXzAdminCls.IdXzCollege, objXzAdminClsCond.IdXzCollege, strComparisonOpIdXzCollege);
}
if (objXzAdminClsCond.IsUpdated(conXzAdminCls.IdUniZone) == true)
{
string strComparisonOpIdUniZone = objXzAdminClsCond.dicFldComparisonOp[conXzAdminCls.IdUniZone];
strWhereCond += string.Format(" And {0} {2} '{1}'", conXzAdminCls.IdUniZone, objXzAdminClsCond.IdUniZone, strComparisonOpIdUniZone);
}
if (objXzAdminClsCond.IsUpdated(conXzAdminCls.CurrentStuQty) == true)
{
string strComparisonOpCurrentStuQty = objXzAdminClsCond.dicFldComparisonOp[conXzAdminCls.CurrentStuQty];
strWhereCond += string.Format(" And {0} {2} {1}", conXzAdminCls.CurrentStuQty, objXzAdminClsCond.CurrentStuQty, strComparisonOpCurrentStuQty);
}
if (objXzAdminClsCond.IsUpdated(conXzAdminCls.IdGradeBase) == true)
{
string strComparisonOpIdGradeBase = objXzAdminClsCond.dicFldComparisonOp[conXzAdminCls.IdGradeBase];
strWhereCond += string.Format(" And {0} {2} '{1}'", conXzAdminCls.IdGradeBase, objXzAdminClsCond.IdGradeBase, strComparisonOpIdGradeBase);
}
if (objXzAdminClsCond.IsUpdated(conXzAdminCls.AdminClsId) == true)
{
string strComparisonOpAdminClsId = objXzAdminClsCond.dicFldComparisonOp[conXzAdminCls.AdminClsId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conXzAdminCls.AdminClsId, objXzAdminClsCond.AdminClsId, strComparisonOpAdminClsId);
}
if (objXzAdminClsCond.IsUpdated(conXzAdminCls.IdAdminClsType) == true)
{
string strComparisonOpIdAdminClsType = objXzAdminClsCond.dicFldComparisonOp[conXzAdminCls.IdAdminClsType];
strWhereCond += string.Format(" And {0} {2} '{1}'", conXzAdminCls.IdAdminClsType, objXzAdminClsCond.IdAdminClsType, strComparisonOpIdAdminClsType);
}
if (objXzAdminClsCond.IsUpdated(conXzAdminCls.AdminClsIndex) == true)
{
string strComparisonOpAdminClsIndex = objXzAdminClsCond.dicFldComparisonOp[conXzAdminCls.AdminClsIndex];
strWhereCond += string.Format(" And {0} {2} {1}", conXzAdminCls.AdminClsIndex, objXzAdminClsCond.AdminClsIndex, strComparisonOpAdminClsIndex);
}
if (objXzAdminClsCond.IsUpdated(conXzAdminCls.Memo) == true)
{
string strComparisonOpMemo = objXzAdminClsCond.dicFldComparisonOp[conXzAdminCls.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", conXzAdminCls.Memo, objXzAdminClsCond.Memo, strComparisonOpMemo);
}
if (objXzAdminClsCond.IsUpdated(conXzAdminCls.ModifyUserId) == true)
{
string strComparisonOpModifyUserId = objXzAdminClsCond.dicFldComparisonOp[conXzAdminCls.ModifyUserId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conXzAdminCls.ModifyUserId, objXzAdminClsCond.ModifyUserId, strComparisonOpModifyUserId);
}
if (objXzAdminClsCond.IsUpdated(conXzAdminCls.ModifyDate) == true)
{
string strComparisonOpModifyDate = objXzAdminClsCond.dicFldComparisonOp[conXzAdminCls.ModifyDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conXzAdminCls.ModifyDate, objXzAdminClsCond.ModifyDate, strComparisonOpModifyDate);
}
 return strWhereCond;
}

 /// <summary>
 /// 检查唯一性(Uniqueness)--XzAdminCls(行政班), 如果不唯一,即存在相同的记录,就返回False
 /// 唯一性条件:AdminClsName
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckConstraint)
 /// </summary>
 /// <param name = "objXzAdminClsEN">要求唯一的对象</param>
 /// <returns></returns>
public static bool CheckUniqueness(this clsXzAdminClsEN objXzAdminClsEN)
{
//检测记录是否存在
bool bolIsUniqueness;
StringBuilder sbCondition = new StringBuilder();
if (objXzAdminClsEN == null) return true;
if (objXzAdminClsEN.IdAdminCls == null || objXzAdminClsEN.IdAdminCls == "")
{
sbCondition.AppendFormat("1 = 1");
 if (objXzAdminClsEN.AdminClsName == null)
{
 sbCondition.AppendFormat(" and AdminClsName is null", objXzAdminClsEN.AdminClsName);
}
else
{
 sbCondition.AppendFormat(" and AdminClsName = '{0}'", objXzAdminClsEN.AdminClsName);
}
if (clsXzAdminClsBL.IsExistRecord(sbCondition.ToString())  ==  true)
{
 bolIsUniqueness = false;
}
else
{
 bolIsUniqueness = true;
}
}
 else {
sbCondition.AppendFormat("IdAdminCls !=  '{0}'", objXzAdminClsEN.IdAdminCls);
 sbCondition.AppendFormat(" and AdminClsName = '{0}'", objXzAdminClsEN.AdminClsName);
if (clsXzAdminClsBL.IsExistRecord(sbCondition.ToString())  ==  true)
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
 /// 获取唯一性条件串--XzAdminCls(行政班), 即由对象中唯一性条件字段关键字与值组成的条件串
 /// 唯一性条件:AdminClsName
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetConditionString4Constraint)
 /// </summary>
 /// <param name = "objXzAdminClsEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(this clsXzAdminClsEN objXzAdminClsEN)
{
//检测记录是否存在
StringBuilder sbCondition = new StringBuilder();
if (objXzAdminClsEN == null) return "";
if (objXzAdminClsEN.IdAdminCls == null || objXzAdminClsEN.IdAdminCls == "")
{
sbCondition.AppendFormat("1 = 1");
 if (objXzAdminClsEN.AdminClsName == null)
{
 sbCondition.AppendFormat(" and AdminClsName is null", objXzAdminClsEN.AdminClsName);
}
else
{
 sbCondition.AppendFormat(" and AdminClsName = '{0}'", objXzAdminClsEN.AdminClsName);
}
return sbCondition.ToString();
}
 else {
sbCondition.AppendFormat("IdAdminCls !=  '{0}'", objXzAdminClsEN.IdAdminCls);
 sbCondition.AppendFormat(" and AdminClsName = '{0}'", objXzAdminClsEN.AdminClsName);
 return sbCondition.ToString();
}
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_XzAdminCls
{
public virtual bool UpdRelaTabDate(string strIdAdminCls, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// 行政班(XzAdminCls)
 /// 数据源类型:表
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsXzAdminClsBL
{
public static RelatedActions_XzAdminCls relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsXzAdminClsDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsXzAdminClsDA XzAdminClsDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsXzAdminClsDA();
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
 public clsXzAdminClsBL()
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
if (string.IsNullOrEmpty(clsXzAdminClsEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsXzAdminClsEN._ConnectString);
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
public static DataTable GetDataTable_XzAdminCls(string strWhereCond)
{
DataTable objDT;
try
{
objDT = XzAdminClsDA.GetDataTable_XzAdminCls(strWhereCond);
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
objDT = XzAdminClsDA.GetDataTable(strWhereCond);
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
objDT = XzAdminClsDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = XzAdminClsDA.GetDataTable(strWhereCond, strTabName);
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
objDT = XzAdminClsDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = XzAdminClsDA.GetDataTable_Top(objTopPara);
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
objDT = XzAdminClsDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = XzAdminClsDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = XzAdminClsDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
 /// <param name = "arrIdAdminClsLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static List<clsXzAdminClsEN> GetObjLstByIdAdminClsLst(List<string> arrIdAdminClsLst)
{
List<clsXzAdminClsEN> arrObjLst = new List<clsXzAdminClsEN>(); 
System.Data.DataTable objDT; 
 string strSqlConditionStr = clsArray.GetSqlInStrByArray(arrIdAdminClsLst, true);
 string strWhereCond = string.Format("IdAdminCls in ({0})", strSqlConditionStr);
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsXzAdminClsEN objXzAdminClsEN = new clsXzAdminClsEN();
try
{
objXzAdminClsEN.IdAdminCls = objRow[conXzAdminCls.IdAdminCls].ToString().Trim(); //行政班流水号
objXzAdminClsEN.AdminClsName = objRow[conXzAdminCls.AdminClsName] == DBNull.Value ? null : objRow[conXzAdminCls.AdminClsName].ToString().Trim(); //行政班名称
objXzAdminClsEN.IdXzMajor = objRow[conXzAdminCls.IdXzMajor].ToString().Trim(); //专业流水号
objXzAdminClsEN.IdXzCollege = objRow[conXzAdminCls.IdXzCollege].ToString().Trim(); //学院流水号
objXzAdminClsEN.IdUniZone = objRow[conXzAdminCls.IdUniZone] == DBNull.Value ? null : objRow[conXzAdminCls.IdUniZone].ToString().Trim(); //校区流水号
objXzAdminClsEN.CurrentStuQty = objRow[conXzAdminCls.CurrentStuQty] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conXzAdminCls.CurrentStuQty].ToString().Trim()); //当前学生数
objXzAdminClsEN.IdGradeBase = objRow[conXzAdminCls.IdGradeBase].ToString().Trim(); //年级流水号
objXzAdminClsEN.AdminClsId = objRow[conXzAdminCls.AdminClsId] == DBNull.Value ? null : objRow[conXzAdminCls.AdminClsId].ToString().Trim(); //行政班代号
objXzAdminClsEN.IdAdminClsType = objRow[conXzAdminCls.IdAdminClsType] == DBNull.Value ? null : objRow[conXzAdminCls.IdAdminClsType].ToString().Trim(); //行政班级类型流水号
objXzAdminClsEN.AdminClsIndex = objRow[conXzAdminCls.AdminClsIndex] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conXzAdminCls.AdminClsIndex].ToString().Trim()); //AdminClsIndex
objXzAdminClsEN.Memo = objRow[conXzAdminCls.Memo] == DBNull.Value ? null : objRow[conXzAdminCls.Memo].ToString().Trim(); //备注
objXzAdminClsEN.ModifyUserId = objRow[conXzAdminCls.ModifyUserId] == DBNull.Value ? null : objRow[conXzAdminCls.ModifyUserId].ToString().Trim(); //修改人
objXzAdminClsEN.ModifyDate = objRow[conXzAdminCls.ModifyDate] == DBNull.Value ? null : objRow[conXzAdminCls.ModifyDate].ToString().Trim(); //修改日期
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objXzAdminClsEN.IdAdminCls, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objXzAdminClsEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrIdAdminClsLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsXzAdminClsEN> GetObjLstByIdAdminClsLstCache(List<string> arrIdAdminClsLst)
{
string strKey = string.Format("{0}", clsXzAdminClsEN._CurrTabName);
List<clsXzAdminClsEN> arrXzAdminClsObjLstCache = GetObjLstCache();
IEnumerable <clsXzAdminClsEN> arrXzAdminClsObjLst_Sel =
arrXzAdminClsObjLstCache
.Where(x => arrIdAdminClsLst.Contains(x.IdAdminCls));
return arrXzAdminClsObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsXzAdminClsEN> GetObjLst(string strWhereCond)
{
List<clsXzAdminClsEN> arrObjLst = new List<clsXzAdminClsEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsXzAdminClsEN objXzAdminClsEN = new clsXzAdminClsEN();
try
{
objXzAdminClsEN.IdAdminCls = objRow[conXzAdminCls.IdAdminCls].ToString().Trim(); //行政班流水号
objXzAdminClsEN.AdminClsName = objRow[conXzAdminCls.AdminClsName] == DBNull.Value ? null : objRow[conXzAdminCls.AdminClsName].ToString().Trim(); //行政班名称
objXzAdminClsEN.IdXzMajor = objRow[conXzAdminCls.IdXzMajor].ToString().Trim(); //专业流水号
objXzAdminClsEN.IdXzCollege = objRow[conXzAdminCls.IdXzCollege].ToString().Trim(); //学院流水号
objXzAdminClsEN.IdUniZone = objRow[conXzAdminCls.IdUniZone] == DBNull.Value ? null : objRow[conXzAdminCls.IdUniZone].ToString().Trim(); //校区流水号
objXzAdminClsEN.CurrentStuQty = objRow[conXzAdminCls.CurrentStuQty] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conXzAdminCls.CurrentStuQty].ToString().Trim()); //当前学生数
objXzAdminClsEN.IdGradeBase = objRow[conXzAdminCls.IdGradeBase].ToString().Trim(); //年级流水号
objXzAdminClsEN.AdminClsId = objRow[conXzAdminCls.AdminClsId] == DBNull.Value ? null : objRow[conXzAdminCls.AdminClsId].ToString().Trim(); //行政班代号
objXzAdminClsEN.IdAdminClsType = objRow[conXzAdminCls.IdAdminClsType] == DBNull.Value ? null : objRow[conXzAdminCls.IdAdminClsType].ToString().Trim(); //行政班级类型流水号
objXzAdminClsEN.AdminClsIndex = objRow[conXzAdminCls.AdminClsIndex] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conXzAdminCls.AdminClsIndex].ToString().Trim()); //AdminClsIndex
objXzAdminClsEN.Memo = objRow[conXzAdminCls.Memo] == DBNull.Value ? null : objRow[conXzAdminCls.Memo].ToString().Trim(); //备注
objXzAdminClsEN.ModifyUserId = objRow[conXzAdminCls.ModifyUserId] == DBNull.Value ? null : objRow[conXzAdminCls.ModifyUserId].ToString().Trim(); //修改人
objXzAdminClsEN.ModifyDate = objRow[conXzAdminCls.ModifyDate] == DBNull.Value ? null : objRow[conXzAdminCls.ModifyDate].ToString().Trim(); //修改日期
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objXzAdminClsEN.IdAdminCls, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objXzAdminClsEN);
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
public static List<clsXzAdminClsEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsXzAdminClsEN> arrObjLst = new List<clsXzAdminClsEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsXzAdminClsEN objXzAdminClsEN = new clsXzAdminClsEN();
try
{
objXzAdminClsEN.IdAdminCls = objRow[conXzAdminCls.IdAdminCls].ToString().Trim(); //行政班流水号
objXzAdminClsEN.AdminClsName = objRow[conXzAdminCls.AdminClsName] == DBNull.Value ? null : objRow[conXzAdminCls.AdminClsName].ToString().Trim(); //行政班名称
objXzAdminClsEN.IdXzMajor = objRow[conXzAdminCls.IdXzMajor].ToString().Trim(); //专业流水号
objXzAdminClsEN.IdXzCollege = objRow[conXzAdminCls.IdXzCollege].ToString().Trim(); //学院流水号
objXzAdminClsEN.IdUniZone = objRow[conXzAdminCls.IdUniZone] == DBNull.Value ? null : objRow[conXzAdminCls.IdUniZone].ToString().Trim(); //校区流水号
objXzAdminClsEN.CurrentStuQty = objRow[conXzAdminCls.CurrentStuQty] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conXzAdminCls.CurrentStuQty].ToString().Trim()); //当前学生数
objXzAdminClsEN.IdGradeBase = objRow[conXzAdminCls.IdGradeBase].ToString().Trim(); //年级流水号
objXzAdminClsEN.AdminClsId = objRow[conXzAdminCls.AdminClsId] == DBNull.Value ? null : objRow[conXzAdminCls.AdminClsId].ToString().Trim(); //行政班代号
objXzAdminClsEN.IdAdminClsType = objRow[conXzAdminCls.IdAdminClsType] == DBNull.Value ? null : objRow[conXzAdminCls.IdAdminClsType].ToString().Trim(); //行政班级类型流水号
objXzAdminClsEN.AdminClsIndex = objRow[conXzAdminCls.AdminClsIndex] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conXzAdminCls.AdminClsIndex].ToString().Trim()); //AdminClsIndex
objXzAdminClsEN.Memo = objRow[conXzAdminCls.Memo] == DBNull.Value ? null : objRow[conXzAdminCls.Memo].ToString().Trim(); //备注
objXzAdminClsEN.ModifyUserId = objRow[conXzAdminCls.ModifyUserId] == DBNull.Value ? null : objRow[conXzAdminCls.ModifyUserId].ToString().Trim(); //修改人
objXzAdminClsEN.ModifyDate = objRow[conXzAdminCls.ModifyDate] == DBNull.Value ? null : objRow[conXzAdminCls.ModifyDate].ToString().Trim(); //修改日期
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objXzAdminClsEN.IdAdminCls, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objXzAdminClsEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objXzAdminClsCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsXzAdminClsEN> GetSubObjLstCache(clsXzAdminClsEN objXzAdminClsCond)
{
List<clsXzAdminClsEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsXzAdminClsEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conXzAdminCls.AttributeName)
{
if (objXzAdminClsCond.IsUpdated(strFldName) == false) continue;
if (objXzAdminClsCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objXzAdminClsCond[strFldName].ToString());
}
else
{
if (objXzAdminClsCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objXzAdminClsCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objXzAdminClsCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objXzAdminClsCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objXzAdminClsCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objXzAdminClsCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objXzAdminClsCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objXzAdminClsCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objXzAdminClsCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objXzAdminClsCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objXzAdminClsCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objXzAdminClsCond[strFldName]));
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
public static List<clsXzAdminClsEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsXzAdminClsEN> arrObjLst = new List<clsXzAdminClsEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsXzAdminClsEN objXzAdminClsEN = new clsXzAdminClsEN();
try
{
objXzAdminClsEN.IdAdminCls = objRow[conXzAdminCls.IdAdminCls].ToString().Trim(); //行政班流水号
objXzAdminClsEN.AdminClsName = objRow[conXzAdminCls.AdminClsName] == DBNull.Value ? null : objRow[conXzAdminCls.AdminClsName].ToString().Trim(); //行政班名称
objXzAdminClsEN.IdXzMajor = objRow[conXzAdminCls.IdXzMajor].ToString().Trim(); //专业流水号
objXzAdminClsEN.IdXzCollege = objRow[conXzAdminCls.IdXzCollege].ToString().Trim(); //学院流水号
objXzAdminClsEN.IdUniZone = objRow[conXzAdminCls.IdUniZone] == DBNull.Value ? null : objRow[conXzAdminCls.IdUniZone].ToString().Trim(); //校区流水号
objXzAdminClsEN.CurrentStuQty = objRow[conXzAdminCls.CurrentStuQty] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conXzAdminCls.CurrentStuQty].ToString().Trim()); //当前学生数
objXzAdminClsEN.IdGradeBase = objRow[conXzAdminCls.IdGradeBase].ToString().Trim(); //年级流水号
objXzAdminClsEN.AdminClsId = objRow[conXzAdminCls.AdminClsId] == DBNull.Value ? null : objRow[conXzAdminCls.AdminClsId].ToString().Trim(); //行政班代号
objXzAdminClsEN.IdAdminClsType = objRow[conXzAdminCls.IdAdminClsType] == DBNull.Value ? null : objRow[conXzAdminCls.IdAdminClsType].ToString().Trim(); //行政班级类型流水号
objXzAdminClsEN.AdminClsIndex = objRow[conXzAdminCls.AdminClsIndex] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conXzAdminCls.AdminClsIndex].ToString().Trim()); //AdminClsIndex
objXzAdminClsEN.Memo = objRow[conXzAdminCls.Memo] == DBNull.Value ? null : objRow[conXzAdminCls.Memo].ToString().Trim(); //备注
objXzAdminClsEN.ModifyUserId = objRow[conXzAdminCls.ModifyUserId] == DBNull.Value ? null : objRow[conXzAdminCls.ModifyUserId].ToString().Trim(); //修改人
objXzAdminClsEN.ModifyDate = objRow[conXzAdminCls.ModifyDate] == DBNull.Value ? null : objRow[conXzAdminCls.ModifyDate].ToString().Trim(); //修改日期
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objXzAdminClsEN.IdAdminCls, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objXzAdminClsEN);
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
public static List<clsXzAdminClsEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsXzAdminClsEN> arrObjLst = new List<clsXzAdminClsEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsXzAdminClsEN objXzAdminClsEN = new clsXzAdminClsEN();
try
{
objXzAdminClsEN.IdAdminCls = objRow[conXzAdminCls.IdAdminCls].ToString().Trim(); //行政班流水号
objXzAdminClsEN.AdminClsName = objRow[conXzAdminCls.AdminClsName] == DBNull.Value ? null : objRow[conXzAdminCls.AdminClsName].ToString().Trim(); //行政班名称
objXzAdminClsEN.IdXzMajor = objRow[conXzAdminCls.IdXzMajor].ToString().Trim(); //专业流水号
objXzAdminClsEN.IdXzCollege = objRow[conXzAdminCls.IdXzCollege].ToString().Trim(); //学院流水号
objXzAdminClsEN.IdUniZone = objRow[conXzAdminCls.IdUniZone] == DBNull.Value ? null : objRow[conXzAdminCls.IdUniZone].ToString().Trim(); //校区流水号
objXzAdminClsEN.CurrentStuQty = objRow[conXzAdminCls.CurrentStuQty] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conXzAdminCls.CurrentStuQty].ToString().Trim()); //当前学生数
objXzAdminClsEN.IdGradeBase = objRow[conXzAdminCls.IdGradeBase].ToString().Trim(); //年级流水号
objXzAdminClsEN.AdminClsId = objRow[conXzAdminCls.AdminClsId] == DBNull.Value ? null : objRow[conXzAdminCls.AdminClsId].ToString().Trim(); //行政班代号
objXzAdminClsEN.IdAdminClsType = objRow[conXzAdminCls.IdAdminClsType] == DBNull.Value ? null : objRow[conXzAdminCls.IdAdminClsType].ToString().Trim(); //行政班级类型流水号
objXzAdminClsEN.AdminClsIndex = objRow[conXzAdminCls.AdminClsIndex] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conXzAdminCls.AdminClsIndex].ToString().Trim()); //AdminClsIndex
objXzAdminClsEN.Memo = objRow[conXzAdminCls.Memo] == DBNull.Value ? null : objRow[conXzAdminCls.Memo].ToString().Trim(); //备注
objXzAdminClsEN.ModifyUserId = objRow[conXzAdminCls.ModifyUserId] == DBNull.Value ? null : objRow[conXzAdminCls.ModifyUserId].ToString().Trim(); //修改人
objXzAdminClsEN.ModifyDate = objRow[conXzAdminCls.ModifyDate] == DBNull.Value ? null : objRow[conXzAdminCls.ModifyDate].ToString().Trim(); //修改日期
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objXzAdminClsEN.IdAdminCls, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objXzAdminClsEN);
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
List<clsXzAdminClsEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsXzAdminClsEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsXzAdminClsEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsXzAdminClsEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsXzAdminClsEN> arrObjLst = new List<clsXzAdminClsEN>(); 
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
	clsXzAdminClsEN objXzAdminClsEN = new clsXzAdminClsEN();
try
{
objXzAdminClsEN.IdAdminCls = objRow[conXzAdminCls.IdAdminCls].ToString().Trim(); //行政班流水号
objXzAdminClsEN.AdminClsName = objRow[conXzAdminCls.AdminClsName] == DBNull.Value ? null : objRow[conXzAdminCls.AdminClsName].ToString().Trim(); //行政班名称
objXzAdminClsEN.IdXzMajor = objRow[conXzAdminCls.IdXzMajor].ToString().Trim(); //专业流水号
objXzAdminClsEN.IdXzCollege = objRow[conXzAdminCls.IdXzCollege].ToString().Trim(); //学院流水号
objXzAdminClsEN.IdUniZone = objRow[conXzAdminCls.IdUniZone] == DBNull.Value ? null : objRow[conXzAdminCls.IdUniZone].ToString().Trim(); //校区流水号
objXzAdminClsEN.CurrentStuQty = objRow[conXzAdminCls.CurrentStuQty] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conXzAdminCls.CurrentStuQty].ToString().Trim()); //当前学生数
objXzAdminClsEN.IdGradeBase = objRow[conXzAdminCls.IdGradeBase].ToString().Trim(); //年级流水号
objXzAdminClsEN.AdminClsId = objRow[conXzAdminCls.AdminClsId] == DBNull.Value ? null : objRow[conXzAdminCls.AdminClsId].ToString().Trim(); //行政班代号
objXzAdminClsEN.IdAdminClsType = objRow[conXzAdminCls.IdAdminClsType] == DBNull.Value ? null : objRow[conXzAdminCls.IdAdminClsType].ToString().Trim(); //行政班级类型流水号
objXzAdminClsEN.AdminClsIndex = objRow[conXzAdminCls.AdminClsIndex] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conXzAdminCls.AdminClsIndex].ToString().Trim()); //AdminClsIndex
objXzAdminClsEN.Memo = objRow[conXzAdminCls.Memo] == DBNull.Value ? null : objRow[conXzAdminCls.Memo].ToString().Trim(); //备注
objXzAdminClsEN.ModifyUserId = objRow[conXzAdminCls.ModifyUserId] == DBNull.Value ? null : objRow[conXzAdminCls.ModifyUserId].ToString().Trim(); //修改人
objXzAdminClsEN.ModifyDate = objRow[conXzAdminCls.ModifyDate] == DBNull.Value ? null : objRow[conXzAdminCls.ModifyDate].ToString().Trim(); //修改日期
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objXzAdminClsEN.IdAdminCls, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objXzAdminClsEN);
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
public static List<clsXzAdminClsEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsXzAdminClsEN> arrObjLst = new List<clsXzAdminClsEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsXzAdminClsEN objXzAdminClsEN = new clsXzAdminClsEN();
try
{
objXzAdminClsEN.IdAdminCls = objRow[conXzAdminCls.IdAdminCls].ToString().Trim(); //行政班流水号
objXzAdminClsEN.AdminClsName = objRow[conXzAdminCls.AdminClsName] == DBNull.Value ? null : objRow[conXzAdminCls.AdminClsName].ToString().Trim(); //行政班名称
objXzAdminClsEN.IdXzMajor = objRow[conXzAdminCls.IdXzMajor].ToString().Trim(); //专业流水号
objXzAdminClsEN.IdXzCollege = objRow[conXzAdminCls.IdXzCollege].ToString().Trim(); //学院流水号
objXzAdminClsEN.IdUniZone = objRow[conXzAdminCls.IdUniZone] == DBNull.Value ? null : objRow[conXzAdminCls.IdUniZone].ToString().Trim(); //校区流水号
objXzAdminClsEN.CurrentStuQty = objRow[conXzAdminCls.CurrentStuQty] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conXzAdminCls.CurrentStuQty].ToString().Trim()); //当前学生数
objXzAdminClsEN.IdGradeBase = objRow[conXzAdminCls.IdGradeBase].ToString().Trim(); //年级流水号
objXzAdminClsEN.AdminClsId = objRow[conXzAdminCls.AdminClsId] == DBNull.Value ? null : objRow[conXzAdminCls.AdminClsId].ToString().Trim(); //行政班代号
objXzAdminClsEN.IdAdminClsType = objRow[conXzAdminCls.IdAdminClsType] == DBNull.Value ? null : objRow[conXzAdminCls.IdAdminClsType].ToString().Trim(); //行政班级类型流水号
objXzAdminClsEN.AdminClsIndex = objRow[conXzAdminCls.AdminClsIndex] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conXzAdminCls.AdminClsIndex].ToString().Trim()); //AdminClsIndex
objXzAdminClsEN.Memo = objRow[conXzAdminCls.Memo] == DBNull.Value ? null : objRow[conXzAdminCls.Memo].ToString().Trim(); //备注
objXzAdminClsEN.ModifyUserId = objRow[conXzAdminCls.ModifyUserId] == DBNull.Value ? null : objRow[conXzAdminCls.ModifyUserId].ToString().Trim(); //修改人
objXzAdminClsEN.ModifyDate = objRow[conXzAdminCls.ModifyDate] == DBNull.Value ? null : objRow[conXzAdminCls.ModifyDate].ToString().Trim(); //修改日期
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objXzAdminClsEN.IdAdminCls, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objXzAdminClsEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsXzAdminClsEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsXzAdminClsEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsXzAdminClsEN> arrObjLst = new List<clsXzAdminClsEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsXzAdminClsEN objXzAdminClsEN = new clsXzAdminClsEN();
try
{
objXzAdminClsEN.IdAdminCls = objRow[conXzAdminCls.IdAdminCls].ToString().Trim(); //行政班流水号
objXzAdminClsEN.AdminClsName = objRow[conXzAdminCls.AdminClsName] == DBNull.Value ? null : objRow[conXzAdminCls.AdminClsName].ToString().Trim(); //行政班名称
objXzAdminClsEN.IdXzMajor = objRow[conXzAdminCls.IdXzMajor].ToString().Trim(); //专业流水号
objXzAdminClsEN.IdXzCollege = objRow[conXzAdminCls.IdXzCollege].ToString().Trim(); //学院流水号
objXzAdminClsEN.IdUniZone = objRow[conXzAdminCls.IdUniZone] == DBNull.Value ? null : objRow[conXzAdminCls.IdUniZone].ToString().Trim(); //校区流水号
objXzAdminClsEN.CurrentStuQty = objRow[conXzAdminCls.CurrentStuQty] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conXzAdminCls.CurrentStuQty].ToString().Trim()); //当前学生数
objXzAdminClsEN.IdGradeBase = objRow[conXzAdminCls.IdGradeBase].ToString().Trim(); //年级流水号
objXzAdminClsEN.AdminClsId = objRow[conXzAdminCls.AdminClsId] == DBNull.Value ? null : objRow[conXzAdminCls.AdminClsId].ToString().Trim(); //行政班代号
objXzAdminClsEN.IdAdminClsType = objRow[conXzAdminCls.IdAdminClsType] == DBNull.Value ? null : objRow[conXzAdminCls.IdAdminClsType].ToString().Trim(); //行政班级类型流水号
objXzAdminClsEN.AdminClsIndex = objRow[conXzAdminCls.AdminClsIndex] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conXzAdminCls.AdminClsIndex].ToString().Trim()); //AdminClsIndex
objXzAdminClsEN.Memo = objRow[conXzAdminCls.Memo] == DBNull.Value ? null : objRow[conXzAdminCls.Memo].ToString().Trim(); //备注
objXzAdminClsEN.ModifyUserId = objRow[conXzAdminCls.ModifyUserId] == DBNull.Value ? null : objRow[conXzAdminCls.ModifyUserId].ToString().Trim(); //修改人
objXzAdminClsEN.ModifyDate = objRow[conXzAdminCls.ModifyDate] == DBNull.Value ? null : objRow[conXzAdminCls.ModifyDate].ToString().Trim(); //修改日期
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objXzAdminClsEN.IdAdminCls, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objXzAdminClsEN);
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
public static List<clsXzAdminClsEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsXzAdminClsEN> arrObjLst = new List<clsXzAdminClsEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsXzAdminClsEN objXzAdminClsEN = new clsXzAdminClsEN();
try
{
objXzAdminClsEN.IdAdminCls = objRow[conXzAdminCls.IdAdminCls].ToString().Trim(); //行政班流水号
objXzAdminClsEN.AdminClsName = objRow[conXzAdminCls.AdminClsName] == DBNull.Value ? null : objRow[conXzAdminCls.AdminClsName].ToString().Trim(); //行政班名称
objXzAdminClsEN.IdXzMajor = objRow[conXzAdminCls.IdXzMajor].ToString().Trim(); //专业流水号
objXzAdminClsEN.IdXzCollege = objRow[conXzAdminCls.IdXzCollege].ToString().Trim(); //学院流水号
objXzAdminClsEN.IdUniZone = objRow[conXzAdminCls.IdUniZone] == DBNull.Value ? null : objRow[conXzAdminCls.IdUniZone].ToString().Trim(); //校区流水号
objXzAdminClsEN.CurrentStuQty = objRow[conXzAdminCls.CurrentStuQty] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conXzAdminCls.CurrentStuQty].ToString().Trim()); //当前学生数
objXzAdminClsEN.IdGradeBase = objRow[conXzAdminCls.IdGradeBase].ToString().Trim(); //年级流水号
objXzAdminClsEN.AdminClsId = objRow[conXzAdminCls.AdminClsId] == DBNull.Value ? null : objRow[conXzAdminCls.AdminClsId].ToString().Trim(); //行政班代号
objXzAdminClsEN.IdAdminClsType = objRow[conXzAdminCls.IdAdminClsType] == DBNull.Value ? null : objRow[conXzAdminCls.IdAdminClsType].ToString().Trim(); //行政班级类型流水号
objXzAdminClsEN.AdminClsIndex = objRow[conXzAdminCls.AdminClsIndex] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conXzAdminCls.AdminClsIndex].ToString().Trim()); //AdminClsIndex
objXzAdminClsEN.Memo = objRow[conXzAdminCls.Memo] == DBNull.Value ? null : objRow[conXzAdminCls.Memo].ToString().Trim(); //备注
objXzAdminClsEN.ModifyUserId = objRow[conXzAdminCls.ModifyUserId] == DBNull.Value ? null : objRow[conXzAdminCls.ModifyUserId].ToString().Trim(); //修改人
objXzAdminClsEN.ModifyDate = objRow[conXzAdminCls.ModifyDate] == DBNull.Value ? null : objRow[conXzAdminCls.ModifyDate].ToString().Trim(); //修改日期
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objXzAdminClsEN.IdAdminCls, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objXzAdminClsEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsXzAdminClsEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsXzAdminClsEN> arrObjLst = new List<clsXzAdminClsEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsXzAdminClsEN objXzAdminClsEN = new clsXzAdminClsEN();
try
{
objXzAdminClsEN.IdAdminCls = objRow[conXzAdminCls.IdAdminCls].ToString().Trim(); //行政班流水号
objXzAdminClsEN.AdminClsName = objRow[conXzAdminCls.AdminClsName] == DBNull.Value ? null : objRow[conXzAdminCls.AdminClsName].ToString().Trim(); //行政班名称
objXzAdminClsEN.IdXzMajor = objRow[conXzAdminCls.IdXzMajor].ToString().Trim(); //专业流水号
objXzAdminClsEN.IdXzCollege = objRow[conXzAdminCls.IdXzCollege].ToString().Trim(); //学院流水号
objXzAdminClsEN.IdUniZone = objRow[conXzAdminCls.IdUniZone] == DBNull.Value ? null : objRow[conXzAdminCls.IdUniZone].ToString().Trim(); //校区流水号
objXzAdminClsEN.CurrentStuQty = objRow[conXzAdminCls.CurrentStuQty] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conXzAdminCls.CurrentStuQty].ToString().Trim()); //当前学生数
objXzAdminClsEN.IdGradeBase = objRow[conXzAdminCls.IdGradeBase].ToString().Trim(); //年级流水号
objXzAdminClsEN.AdminClsId = objRow[conXzAdminCls.AdminClsId] == DBNull.Value ? null : objRow[conXzAdminCls.AdminClsId].ToString().Trim(); //行政班代号
objXzAdminClsEN.IdAdminClsType = objRow[conXzAdminCls.IdAdminClsType] == DBNull.Value ? null : objRow[conXzAdminCls.IdAdminClsType].ToString().Trim(); //行政班级类型流水号
objXzAdminClsEN.AdminClsIndex = objRow[conXzAdminCls.AdminClsIndex] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conXzAdminCls.AdminClsIndex].ToString().Trim()); //AdminClsIndex
objXzAdminClsEN.Memo = objRow[conXzAdminCls.Memo] == DBNull.Value ? null : objRow[conXzAdminCls.Memo].ToString().Trim(); //备注
objXzAdminClsEN.ModifyUserId = objRow[conXzAdminCls.ModifyUserId] == DBNull.Value ? null : objRow[conXzAdminCls.ModifyUserId].ToString().Trim(); //修改人
objXzAdminClsEN.ModifyDate = objRow[conXzAdminCls.ModifyDate] == DBNull.Value ? null : objRow[conXzAdminCls.ModifyDate].ToString().Trim(); //修改日期
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objXzAdminClsEN.IdAdminCls, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objXzAdminClsEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objXzAdminClsEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetXzAdminCls(ref clsXzAdminClsEN objXzAdminClsEN)
{
bool bolResult = XzAdminClsDA.GetXzAdminCls(ref objXzAdminClsEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "strIdAdminCls">表关键字</param>
 /// <returns>表对象</returns>
public static clsXzAdminClsEN GetObjByIdAdminCls(string strIdAdminCls)
{
if (strIdAdminCls.IndexOf(' ') >=0)
{
var strMsg = string.Format("(errid:Busi000079)在表中,关键字[strIdAdminCls]中不能有空格!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
if (string.IsNullOrEmpty(strIdAdminCls) == true)
{
var strMsg = string.Format("(errid:Busi000020)在表中,关键字[strIdAdminCls]不能为空!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
clsXzAdminClsEN objXzAdminClsEN = XzAdminClsDA.GetObjByIdAdminCls(strIdAdminCls);
return objXzAdminClsEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsXzAdminClsEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsXzAdminClsEN objXzAdminClsEN = XzAdminClsDA.GetFirstObj(strWhereCond);
 return objXzAdminClsEN;
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
public static clsXzAdminClsEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsXzAdminClsEN objXzAdminClsEN = XzAdminClsDA.GetObjByDataRow(objRow);
 return objXzAdminClsEN;
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
public static clsXzAdminClsEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsXzAdminClsEN objXzAdminClsEN = XzAdminClsDA.GetObjByDataRow(objRow);
 return objXzAdminClsEN;
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
 /// <param name = "strIdAdminCls">所给的关键字</param>
 /// <param name = "lstXzAdminClsObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsXzAdminClsEN GetObjByIdAdminClsFromList(string strIdAdminCls, List<clsXzAdminClsEN> lstXzAdminClsObjLst)
{
foreach (clsXzAdminClsEN objXzAdminClsEN in lstXzAdminClsObjLst)
{
if (objXzAdminClsEN.IdAdminCls == strIdAdminCls)
{
return objXzAdminClsEN;
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
 string strMaxIdAdminCls;
 try
 {
 strMaxIdAdminCls = clsXzAdminClsDA.GetMaxStrId();
 return strMaxIdAdminCls;
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
 string strIdAdminCls;
 try
 {
 strIdAdminCls = new clsXzAdminClsDA().GetFirstID(strWhereCond);
 return strIdAdminCls;
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
 arrList = XzAdminClsDA.GetID(strWhereCond);
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
bool bolIsExist = XzAdminClsDA.IsExistCondRec(strWhereCond);
return bolIsExist;
}

 /// <summary>
 /// 判断当前表中是否存在给定关键字值的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExist)
 /// </summary>
 /// <param name = "strIdAdminCls">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public static bool IsExist(string strIdAdminCls)
{
if (string.IsNullOrEmpty(strIdAdminCls) == true)
{
var strMsg = string.Format("(errid:Busi000027)在表中,关键字[strIdAdminCls]不能为空!!(from {0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
//检测记录是否存在
bool bolIsExist = XzAdminClsDA.IsExist(strIdAdminCls);
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
 bolIsExist = clsXzAdminClsDA.IsExistTable();
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
 bolIsExist = XzAdminClsDA.IsExistTable(strTabName);
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
 /// <param name = "objXzAdminClsEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecordBySql2(clsXzAdminClsEN objXzAdminClsEN, bool bolIsNeedCheckUniqueness=true)
{
if (bolIsNeedCheckUniqueness == true && objXzAdminClsEN.CheckUniqueness() == false)
{
var strMsg = string.Format("记录已经存在!行政班名称 = [{0}]的数据已经存在!(in clsXzAdminClsBL.AddNewRecordBySql2)", objXzAdminClsEN.AdminClsName);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objXzAdminClsEN.IdAdminCls) == true || clsXzAdminClsBL.IsExist(objXzAdminClsEN.IdAdminCls) == true)
 {
     objXzAdminClsEN.IdAdminCls = clsXzAdminClsBL.GetMaxStrId_S();
 }
bool bolResult = XzAdminClsDA.AddNewRecordBySQL2(objXzAdminClsEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsXzAdminClsBL.ReFreshCache();

if (clsXzAdminClsBL.relatedActions != null)
{
clsXzAdminClsBL.relatedActions.UpdRelaTabDate(objXzAdminClsEN.IdAdminCls, "SetUpdDate");
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
 /// <param name = "objXzAdminClsEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordBySql2WithReturnKey(clsXzAdminClsEN objXzAdminClsEN, bool bolIsNeedCheckUniqueness=true)
{
if (bolIsNeedCheckUniqueness == true && objXzAdminClsEN.CheckUniqueness() == false)
{
var strMsg = string.Format("记录已经存在!行政班名称 = [{0}]的数据已经存在!(in clsXzAdminClsBL.AddNewRecordBySql2WithReturnKey)", objXzAdminClsEN.AdminClsName);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objXzAdminClsEN.IdAdminCls) == true || clsXzAdminClsBL.IsExist(objXzAdminClsEN.IdAdminCls) == true)
 {
     objXzAdminClsEN.IdAdminCls = clsXzAdminClsBL.GetMaxStrId_S();
 }
string strKey = XzAdminClsDA.AddNewRecordBySQL2WithReturnKey(objXzAdminClsEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsXzAdminClsBL.ReFreshCache();

if (clsXzAdminClsBL.relatedActions != null)
{
clsXzAdminClsBL.relatedActions.UpdRelaTabDate(objXzAdminClsEN.IdAdminCls, "SetUpdDate");
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
 /// <param name = "objXzAdminClsEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(clsXzAdminClsEN objXzAdminClsEN)
{
try
{
bool bolResult = XzAdminClsDA.Update(objXzAdminClsEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsXzAdminClsBL.ReFreshCache();

if (clsXzAdminClsBL.relatedActions != null)
{
clsXzAdminClsBL.relatedActions.UpdRelaTabDate(objXzAdminClsEN.IdAdminCls, "SetUpdDate");
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
 /// <param name = "objXzAdminClsEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateBySql2(clsXzAdminClsEN objXzAdminClsEN)
{
 if (string.IsNullOrEmpty(objXzAdminClsEN.IdAdminCls) == true)
 {
var strMsg = string.Format("(errid:Busi000065)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = XzAdminClsDA.UpdateBySql2(objXzAdminClsEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsXzAdminClsBL.ReFreshCache();

if (clsXzAdminClsBL.relatedActions != null)
{
clsXzAdminClsBL.relatedActions.UpdRelaTabDate(objXzAdminClsEN.IdAdminCls, "SetUpdDate");
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
 /// <param name = "strIdAdminCls">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int DelRecord(string strIdAdminCls)
{
try
{
 clsXzAdminClsEN objXzAdminClsEN = clsXzAdminClsBL.GetObjByIdAdminCls(strIdAdminCls);

if (clsXzAdminClsBL.relatedActions != null)
{
clsXzAdminClsBL.relatedActions.UpdRelaTabDate(objXzAdminClsEN.IdAdminCls, "SetUpdDate");
}
if (objXzAdminClsEN != null)
{
int intRecNum = XzAdminClsDA.DelRecord(strIdAdminCls);
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
/// <param name="strIdAdminCls">表关键字</param>
/// <returns></returns>
public static bool DelRecordEx(string strIdAdminCls )
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsXzAdminClsDA.GetSpecSQLObj();
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
//删除与表:[XzAdminCls]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conXzAdminCls.IdAdminCls,
//strIdAdminCls);
//        clsXzAdminClsBL.DelXzAdminClssByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsXzAdminClsBL.DelRecord(strIdAdminCls, objConnection, objSqlTransaction);
objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsXzAdminClsBLEx", "DelRecordEx", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("扩展删除记录出错:{0}!keyId = {1}.({2})",
objException.Message,
strIdAdminCls, clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "strIdAdminCls">给定的关键字值</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回删除是否成功?</returns>
public static bool DelRecord(string strIdAdminCls, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
if (clsXzAdminClsBL.relatedActions != null)
{
clsXzAdminClsBL.relatedActions.UpdRelaTabDate(strIdAdminCls, "UpdRelaTabDate");
}
bool bolResult = XzAdminClsDA.DelRecord(strIdAdminCls,objSqlConnection,objSqlTransaction);
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
 /// <param name = "arrIdAdminClsLst">给定的关键字值列表</param>
 /// <returns>返回删除的记录数</returns>
public static int DelXzAdminClss(List<string> arrIdAdminClsLst)
{
if (arrIdAdminClsLst.Count == 0) return 0;
try
{
if (clsXzAdminClsBL.relatedActions != null)
{
foreach (var strIdAdminCls in arrIdAdminClsLst)
{
clsXzAdminClsBL.relatedActions.UpdRelaTabDate(strIdAdminCls, "UpdRelaTabDate");
}
}
int intDelRecNum = XzAdminClsDA.DelXzAdminCls(arrIdAdminClsLst);
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
public static int DelXzAdminClssByCond(string strWhereCond)
{
try
{
if (clsXzAdminClsBL.relatedActions != null)
{
List<string> arrIdAdminCls = GetPrimaryKeyID_S(strWhereCond);
foreach (var strIdAdminCls in arrIdAdminCls)
{
clsXzAdminClsBL.relatedActions.UpdRelaTabDate(strIdAdminCls, "UpdRelaTabDate");
}
}
int intRecNum = XzAdminClsDA.DelXzAdminCls(strWhereCond);
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
/// 这里仅仅是演示函数,使用时请复制到扩展类:[XzAdminCls]中改名为:[DelRecord4MultiTabEx]使用
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DelRecord4MultiTab)
/// </summary>
/// <param name="strIdAdminCls">表关键字</param>
/// <returns></returns>
public static bool DelRecord4MultiTab(string strIdAdminCls)
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsXzAdminClsDA.GetSpecSQLObj();
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
//删除与表:[XzAdminCls]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conStudent.id_College,
//strid_College);
//        clsStudentBL.DelStudentsByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsXzAdminClsBL.DelRecord(strIdAdminCls, objConnection, objSqlTransaction);
                objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsXzAdminClsBL", "DelRecord4MultiTab", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("删除多表记录出错:{0}!keyId = {1}.({2})",
objException.Message,
strIdAdminCls, clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "objXzAdminClsENS">源对象</param>
 /// <param name = "objXzAdminClsENT">目标对象</param>
 public static void CopyTo(clsXzAdminClsEN objXzAdminClsENS, clsXzAdminClsEN objXzAdminClsENT)
{
try
{
objXzAdminClsENT.IdAdminCls = objXzAdminClsENS.IdAdminCls; //行政班流水号
objXzAdminClsENT.AdminClsName = objXzAdminClsENS.AdminClsName; //行政班名称
objXzAdminClsENT.IdXzMajor = objXzAdminClsENS.IdXzMajor; //专业流水号
objXzAdminClsENT.IdXzCollege = objXzAdminClsENS.IdXzCollege; //学院流水号
objXzAdminClsENT.IdUniZone = objXzAdminClsENS.IdUniZone; //校区流水号
objXzAdminClsENT.CurrentStuQty = objXzAdminClsENS.CurrentStuQty; //当前学生数
objXzAdminClsENT.IdGradeBase = objXzAdminClsENS.IdGradeBase; //年级流水号
objXzAdminClsENT.AdminClsId = objXzAdminClsENS.AdminClsId; //行政班代号
objXzAdminClsENT.IdAdminClsType = objXzAdminClsENS.IdAdminClsType; //行政班级类型流水号
objXzAdminClsENT.AdminClsIndex = objXzAdminClsENS.AdminClsIndex; //AdminClsIndex
objXzAdminClsENT.Memo = objXzAdminClsENS.Memo; //备注
objXzAdminClsENT.ModifyUserId = objXzAdminClsENS.ModifyUserId; //修改人
objXzAdminClsENT.ModifyDate = objXzAdminClsENS.ModifyDate; //修改日期
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
 /// <param name = "objXzAdminClsEN">源简化对象</param>
 public static void SetUpdFlag(clsXzAdminClsEN objXzAdminClsEN)
{
try
{
objXzAdminClsEN.ClearUpdateState();
   string strsfUpdFldSetStr = objXzAdminClsEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(conXzAdminCls.IdAdminCls, new clsStrCompareIgnoreCase())  ==  true)
{
objXzAdminClsEN.IdAdminCls = objXzAdminClsEN.IdAdminCls; //行政班流水号
}
if (arrFldSet.Contains(conXzAdminCls.AdminClsName, new clsStrCompareIgnoreCase())  ==  true)
{
objXzAdminClsEN.AdminClsName = objXzAdminClsEN.AdminClsName == "[null]" ? null :  objXzAdminClsEN.AdminClsName; //行政班名称
}
if (arrFldSet.Contains(conXzAdminCls.IdXzMajor, new clsStrCompareIgnoreCase())  ==  true)
{
objXzAdminClsEN.IdXzMajor = objXzAdminClsEN.IdXzMajor; //专业流水号
}
if (arrFldSet.Contains(conXzAdminCls.IdXzCollege, new clsStrCompareIgnoreCase())  ==  true)
{
objXzAdminClsEN.IdXzCollege = objXzAdminClsEN.IdXzCollege; //学院流水号
}
if (arrFldSet.Contains(conXzAdminCls.IdUniZone, new clsStrCompareIgnoreCase())  ==  true)
{
objXzAdminClsEN.IdUniZone = objXzAdminClsEN.IdUniZone == "[null]" ? null :  objXzAdminClsEN.IdUniZone; //校区流水号
}
if (arrFldSet.Contains(conXzAdminCls.CurrentStuQty, new clsStrCompareIgnoreCase())  ==  true)
{
objXzAdminClsEN.CurrentStuQty = objXzAdminClsEN.CurrentStuQty; //当前学生数
}
if (arrFldSet.Contains(conXzAdminCls.IdGradeBase, new clsStrCompareIgnoreCase())  ==  true)
{
objXzAdminClsEN.IdGradeBase = objXzAdminClsEN.IdGradeBase; //年级流水号
}
if (arrFldSet.Contains(conXzAdminCls.AdminClsId, new clsStrCompareIgnoreCase())  ==  true)
{
objXzAdminClsEN.AdminClsId = objXzAdminClsEN.AdminClsId == "[null]" ? null :  objXzAdminClsEN.AdminClsId; //行政班代号
}
if (arrFldSet.Contains(conXzAdminCls.IdAdminClsType, new clsStrCompareIgnoreCase())  ==  true)
{
objXzAdminClsEN.IdAdminClsType = objXzAdminClsEN.IdAdminClsType == "[null]" ? null :  objXzAdminClsEN.IdAdminClsType; //行政班级类型流水号
}
if (arrFldSet.Contains(conXzAdminCls.AdminClsIndex, new clsStrCompareIgnoreCase())  ==  true)
{
objXzAdminClsEN.AdminClsIndex = objXzAdminClsEN.AdminClsIndex; //AdminClsIndex
}
if (arrFldSet.Contains(conXzAdminCls.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objXzAdminClsEN.Memo = objXzAdminClsEN.Memo == "[null]" ? null :  objXzAdminClsEN.Memo; //备注
}
if (arrFldSet.Contains(conXzAdminCls.ModifyUserId, new clsStrCompareIgnoreCase())  ==  true)
{
objXzAdminClsEN.ModifyUserId = objXzAdminClsEN.ModifyUserId == "[null]" ? null :  objXzAdminClsEN.ModifyUserId; //修改人
}
if (arrFldSet.Contains(conXzAdminCls.ModifyDate, new clsStrCompareIgnoreCase())  ==  true)
{
objXzAdminClsEN.ModifyDate = objXzAdminClsEN.ModifyDate == "[null]" ? null :  objXzAdminClsEN.ModifyDate; //修改日期
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
 /// <param name = "objXzAdminClsEN">源简化对象</param>
 public static void AccessFldValueNull(clsXzAdminClsEN objXzAdminClsEN)
{
try
{
if (objXzAdminClsEN.AdminClsName == "[null]") objXzAdminClsEN.AdminClsName = null; //行政班名称
if (objXzAdminClsEN.IdUniZone == "[null]") objXzAdminClsEN.IdUniZone = null; //校区流水号
if (objXzAdminClsEN.AdminClsId == "[null]") objXzAdminClsEN.AdminClsId = null; //行政班代号
if (objXzAdminClsEN.IdAdminClsType == "[null]") objXzAdminClsEN.IdAdminClsType = null; //行政班级类型流水号
if (objXzAdminClsEN.Memo == "[null]") objXzAdminClsEN.Memo = null; //备注
if (objXzAdminClsEN.ModifyUserId == "[null]") objXzAdminClsEN.ModifyUserId = null; //修改人
if (objXzAdminClsEN.ModifyDate == "[null]") objXzAdminClsEN.ModifyDate = null; //修改日期
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
public static void CheckPropertyNew(clsXzAdminClsEN objXzAdminClsEN)
{
 XzAdminClsDA.CheckPropertyNew(objXzAdminClsEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(clsXzAdminClsEN objXzAdminClsEN)
{
 XzAdminClsDA.CheckProperty4Condition(objXzAdminClsEN);
 }


 #endregion 检查对象属性


 #region 绑定下拉框

 /// <summary>
 /// 绑定基于Web的下拉框-使用Cache
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DdlBindFunctionCache)
 /// </summary>
 /// <param name = "objDDL">需要绑定当前表的下拉框</param>
public static void BindDdl_IdAdminClsCache(System.Web.UI.WebControls.DropDownList objDDL)
{
//为数据源于表的下拉框设置内容
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[行政班]...","0");
List<clsXzAdminClsEN> arrXzAdminClsObjLst = GetAllXzAdminClsObjLstCache(); 
objDDL.DataValueField = conXzAdminCls.IdAdminCls;
objDDL.DataTextField = conXzAdminCls.AdminClsName;
objDDL.DataSource = arrXzAdminClsObjLst;
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
if (clsXzAdminClsBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsXzAdminClsBL没有刷新缓存机制(clsXzAdminClsBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by IdAdminCls");
//if (arrXzAdminClsObjLstCache == null)
//{
//arrXzAdminClsObjLstCache = XzAdminClsDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "strIdAdminCls">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsXzAdminClsEN GetObjByIdAdminClsCache(string strIdAdminCls)
{
//获取缓存中的对象列表
string strKey = string.Format("{0}", clsXzAdminClsEN._CurrTabName);
List<clsXzAdminClsEN> arrXzAdminClsObjLstCache = GetObjLstCache();
IEnumerable <clsXzAdminClsEN> arrXzAdminClsObjLst_Sel =
arrXzAdminClsObjLstCache
.Where(x=> x.IdAdminCls == strIdAdminCls 
);
if (arrXzAdminClsObjLst_Sel.Count() == 0)
{
   clsXzAdminClsEN obj = clsXzAdminClsBL.GetObjByIdAdminCls(strIdAdminCls);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
 }
return null;
}
return arrXzAdminClsObjLst_Sel.First();
}

 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecNameByKeyCache)
 /// </summary>
 /// <param name = "strIdAdminCls">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetAdminClsNameByIdAdminClsCache(string strIdAdminCls)
{
if (string.IsNullOrEmpty(strIdAdminCls) == true) return "";
//获取缓存中的对象列表
clsXzAdminClsEN objXzAdminCls = GetObjByIdAdminClsCache(strIdAdminCls);
if (objXzAdminCls == null) return "";
return objXzAdminCls.AdminClsName;
}
 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecNameByKeyCache)
 /// </summary>
 /// <param name = "strIdAdminCls">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetNameByIdAdminClsCache(string strIdAdminCls)
{
if (string.IsNullOrEmpty(strIdAdminCls) == true) return "";
//获取缓存中的对象列表
clsXzAdminClsEN objXzAdminCls = GetObjByIdAdminClsCache(strIdAdminCls);
if (objXzAdminCls == null) return "";
return objXzAdminCls.AdminClsName;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsXzAdminClsEN> GetAllXzAdminClsObjLstCache()
{
//获取缓存中的对象列表
List<clsXzAdminClsEN> arrXzAdminClsObjLstCache = GetObjLstCache(); 
return arrXzAdminClsObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsXzAdminClsEN> GetObjLstCache()
{
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}", clsXzAdminClsEN._CurrTabName);
List<clsXzAdminClsEN> arrXzAdminClsObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrXzAdminClsObjLstCache;
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
string strKey = string.Format("{0}", clsXzAdminClsEN._CurrTabName);
CacheHelper.Remove(strKey);
clsXzAdminClsEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
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
if (clsXzAdminClsEN._RefreshTimeLst.Count == 0) return "";
return clsXzAdminClsEN._RefreshTimeLst[clsXzAdminClsEN._RefreshTimeLst.Count - 1];
}

 /// <summary>
 /// 刷新缓存.把当前表的缓存以及该表相关视图的缓存清空.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ReFreshCache)
 /// </summary>
public static void ReFreshCache()
{
if (clsXzAdminClsBL.objCommFun4BL != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}", clsXzAdminClsEN._CurrTabName);
CacheHelper.Remove(strKey);
clsXzAdminClsEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
clsXzAdminClsBL.objCommFun4BL.ReFreshCache();
}
}


 #endregion 缓存操作


 #region 检查唯一性

 /// <summary>
 /// 获取检查唯一性条件串(Uniqueness)--XzAdminCls(行政班)
 /// 唯一性条件:AdminClsName
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetUniquenessConditionString)
 /// </summary>
 /// <param name = "objXzAdminClsEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(clsXzAdminClsEN objXzAdminClsEN)
{
//检测记录是否存在
string strResult = XzAdminClsDA.GetUniCondStr(objXzAdminClsEN);
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
public static string Func(string strInFldName, string strOutFldName, string strIdAdminCls)
{
if (strInFldName != conXzAdminCls.IdAdminCls)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (conXzAdminCls.AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", conXzAdminCls.AttributeName));
throw new Exception(strMsg);
}
var objXzAdminCls = clsXzAdminClsBL.GetObjByIdAdminClsCache(strIdAdminCls);
if (objXzAdminCls == null) return "";
return objXzAdminCls[strOutFldName].ToString();
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
int intRecCount = clsXzAdminClsDA.GetRecCount(strTabName);
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
int intRecCount = clsXzAdminClsDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsXzAdminClsDA.GetRecCount();
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
int intRecCount = clsXzAdminClsDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objXzAdminClsCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsXzAdminClsEN objXzAdminClsCond)
{
List<clsXzAdminClsEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsXzAdminClsEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conXzAdminCls.AttributeName)
{
if (objXzAdminClsCond.IsUpdated(strFldName) == false) continue;
if (objXzAdminClsCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objXzAdminClsCond[strFldName].ToString());
}
else
{
if (objXzAdminClsCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objXzAdminClsCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objXzAdminClsCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objXzAdminClsCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objXzAdminClsCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objXzAdminClsCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objXzAdminClsCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objXzAdminClsCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objXzAdminClsCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objXzAdminClsCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objXzAdminClsCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objXzAdminClsCond[strFldName]));
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
 List<string> arrList = clsXzAdminClsDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = XzAdminClsDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = XzAdminClsDA.GetFldValueNoDistinct(strFldName, strWhereCond);
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
int intRecCount = XzAdminClsDA.SetFldValue(strFldName, strValue, strWhereCond);
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
int intRecCount = clsXzAdminClsDA.SetFldValue(clsXzAdminClsEN._CurrTabName, strFldName, fltValue, strWhereCond);
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
int intRecCount = XzAdminClsDA.SetFldValue( strFldName, intValue, strWhereCond);
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
int intRecCount = clsXzAdminClsDA.SetFldValue(strTabName, strFldName, strValue, strWhereCond);
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
int intRecCount = clsXzAdminClsDA.SetFldValue(strTabName, strFldName, intValue, strWhereCond);
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
int intRecCount = clsXzAdminClsDA.SetFldValue(strTabName, strFldName, fltValue, strWhereCond);
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
  strCreateTabCode.Append("CREATE table [dbo].[XzAdminCls] "); 
 strCreateTabCode.Append(" ( "); 
 // /**行政班流水号*/ 
 strCreateTabCode.Append(" IdAdminCls char(8) primary key, "); 
 // /**行政班名称*/ 
 strCreateTabCode.Append(" AdminClsName varchar(100) Null, "); 
 // /**专业流水号*/ 
 strCreateTabCode.Append(" IdXzMajor char(8) not Null, "); 
 // /**学院流水号*/ 
 strCreateTabCode.Append(" IdXzCollege char(4) not Null, "); 
 // /**校区流水号*/ 
 strCreateTabCode.Append(" IdUniZone char(4) Null, "); 
 // /**当前学生数*/ 
 strCreateTabCode.Append(" CurrentStuQty int Null, "); 
 // /**年级流水号*/ 
 strCreateTabCode.Append(" IdGradeBase char(4) not Null, "); 
 // /**行政班代号*/ 
 strCreateTabCode.Append(" AdminClsId varchar(8) Null, "); 
 // /**行政班级类型流水号*/ 
 strCreateTabCode.Append(" IdAdminClsType char(4) Null, "); 
 // /**AdminClsIndex*/ 
 strCreateTabCode.Append(" AdminClsIndex int Null, "); 
 // /**备注*/ 
 strCreateTabCode.Append(" Memo varchar(1000) Null, "); 
 // /**修改人*/ 
 strCreateTabCode.Append(" ModifyUserId varchar(18) Null, "); 
 // /**修改日期*/ 
 strCreateTabCode.Append(" ModifyDate varchar(20) Null ");
 strCreateTabCode.Append(") "); 
  strCreateTabCode.Append("ON [PRIMARY] ");
  return strCreateTabCode.ToString();
}



 #endregion 表操作
}
 /// <summary>
 /// 行政班(XzAdminCls)
 /// 数据源类型:表
 /// (AutoGCLib.CommFun4BL4CSharp:GeneCode_This)
 /// </summary>
public class  clsCommFun4BL4XzAdminCls : clsCommFun4BL
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
clsXzAdminClsBL.ReFreshThisCache();
}
}

}