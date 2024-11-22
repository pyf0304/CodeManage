
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsQuestionnaireSetBL
 表名:QuestionnaireSet(01120007)
 * 版本:2024.11.13.1(服务器:WIN-SRV103-116)
 日期:2024/11/13 06:02:07
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:研究生学习游戏化后台(000055, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:问卷维护(QuestionaireEdit)
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
public static class  clsQuestionnaireSetBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "strQuestionnaireSetId">表关键字</param>
 /// <returns>表对象</returns>
public static clsQuestionnaireSetEN GetObj(this K_QuestionnaireSetId_QuestionnaireSet myKey)
{
clsQuestionnaireSetEN objQuestionnaireSetEN = clsQuestionnaireSetBL.QuestionnaireSetDA.GetObjByQuestionnaireSetId(myKey.Value);
return objQuestionnaireSetEN;
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_AddNewRecord)
 /// </summary>
 /// <param name = "objQuestionnaireSetEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clsQuestionnaireSetEN objQuestionnaireSetEN, bool bolIsNeedCheckUniqueness = true)
{
if (bolIsNeedCheckUniqueness == true && CheckUniqueness(objQuestionnaireSetEN) == false)
{
var strMsg = string.Format("记录已经存在!问卷集名 = [{0}]的数据已经存在!(in clsQuestionnaireSetBL.AddNewRecord)", objQuestionnaireSetEN.QuestionnaireSetName);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objQuestionnaireSetEN.QuestionnaireSetId) == true || clsQuestionnaireSetBL.IsExist(objQuestionnaireSetEN.QuestionnaireSetId) == true)
 {
     objQuestionnaireSetEN.QuestionnaireSetId = clsQuestionnaireSetBL.GetMaxStrId_S();
 }
bool bolResult = clsQuestionnaireSetBL.QuestionnaireSetDA.AddNewRecordBySQL2(objQuestionnaireSetEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsQuestionnaireSetBL.ReFreshCache();

if (clsQuestionnaireSetBL.relatedActions != null)
{
clsQuestionnaireSetBL.relatedActions.UpdRelaTabDate(objQuestionnaireSetEN.QuestionnaireSetId, objQuestionnaireSetEN.UpdUser);
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
public static bool AddRecordEx(this clsQuestionnaireSetEN objQuestionnaireSetEN, bool bolIsNeedCheckUniqueness = true)
{
//操作步骤:
//1、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在
//2、检查唯一性
//3、检查传进去的对象属性是否合法
//4、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
//1、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在

//因为是字符型自增主键,不需要检查主键是否已经存在,在添加时,再获取 最大值作为主键
//if (clsQuestionnaireSetBL.IsExist(objQuestionnaireSetEN.QuestionnaireSetId))	//判断是否有相同的关键字
//{
//strMsg = "(errid:Busi000151)关键字字段已有相同的值";
//throw new Exception(strMsg);
//}
try
{
 //2、检查传进去的对象属性是否合法
objQuestionnaireSetEN.CheckPropertyNew();
 ///5.2、检查唯一性
if (bolIsNeedCheckUniqueness == true && objQuestionnaireSetEN.CheckUniqueness() == false)
{
strMsg = string.Format("(问卷集名(QuestionnaireSetName)=[{0}])已经存在,不能重复!", objQuestionnaireSetEN.QuestionnaireSetName);
throw new Exception(strMsg);
}
//因为是字符型自增主键,所以在添加时,自动获取主键值。
 if (string.IsNullOrEmpty(objQuestionnaireSetEN.QuestionnaireSetId) == true || clsQuestionnaireSetBL.IsExist(objQuestionnaireSetEN.QuestionnaireSetId) == true)
 {
     objQuestionnaireSetEN.QuestionnaireSetId = clsQuestionnaireSetBL.GetMaxStrId_S();
 }
//6、把数据实体层的数据存贮到数据库中
objQuestionnaireSetEN.AddNewRecord();
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
 /// <param name = "objQuestionnaireSetEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static string AddNewRecordWithMaxId(this clsQuestionnaireSetEN objQuestionnaireSetEN, bool bolIsNeedCheckUniqueness = true)
{
if (bolIsNeedCheckUniqueness == true && CheckUniqueness(objQuestionnaireSetEN) == false)
{
var strMsg = string.Format("记录已经存在!问卷集名 = [{0}]的数据已经存在!(in clsQuestionnaireSetBL.AddNewRecordWithMaxId)", objQuestionnaireSetEN.QuestionnaireSetName);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objQuestionnaireSetEN.QuestionnaireSetId) == true || clsQuestionnaireSetBL.IsExist(objQuestionnaireSetEN.QuestionnaireSetId) == true)
 {
     objQuestionnaireSetEN.QuestionnaireSetId = clsQuestionnaireSetBL.GetMaxStrId_S();
 }
string strQuestionnaireSetId = clsQuestionnaireSetBL.QuestionnaireSetDA.AddNewRecordBySQL2WithReturnKey(objQuestionnaireSetEN);
     objQuestionnaireSetEN.QuestionnaireSetId = strQuestionnaireSetId;
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsQuestionnaireSetBL.ReFreshCache();

if (clsQuestionnaireSetBL.relatedActions != null)
{
clsQuestionnaireSetBL.relatedActions.UpdRelaTabDate(objQuestionnaireSetEN.QuestionnaireSetId, objQuestionnaireSetEN.UpdUser);
}
return strQuestionnaireSetId;
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
 /// <param name = "objQuestionnaireSetEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordWithReturnKey(this clsQuestionnaireSetEN objQuestionnaireSetEN, bool bolIsNeedCheckUniqueness = true)
{
if (bolIsNeedCheckUniqueness == true && CheckUniqueness(objQuestionnaireSetEN) == false)
{
var strMsg = string.Format("记录已经存在!问卷集名 = [{0}]的数据已经存在!(in clsQuestionnaireSetBL.AddNewRecordWithReturnKey)", objQuestionnaireSetEN.QuestionnaireSetName);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objQuestionnaireSetEN.QuestionnaireSetId) == true || clsQuestionnaireSetBL.IsExist(objQuestionnaireSetEN.QuestionnaireSetId) == true)
 {
     objQuestionnaireSetEN.QuestionnaireSetId = clsQuestionnaireSetBL.GetMaxStrId_S();
 }
string strKey = clsQuestionnaireSetBL.QuestionnaireSetDA.AddNewRecordBySQL2WithReturnKey(objQuestionnaireSetEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsQuestionnaireSetBL.ReFreshCache();

if (clsQuestionnaireSetBL.relatedActions != null)
{
clsQuestionnaireSetBL.relatedActions.UpdRelaTabDate(objQuestionnaireSetEN.QuestionnaireSetId, objQuestionnaireSetEN.UpdUser);
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
 /// <param name = "objQuestionnaireSetEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQuestionnaireSetEN SetQuestionnaireSetId(this clsQuestionnaireSetEN objQuestionnaireSetEN, string strQuestionnaireSetId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strQuestionnaireSetId, 4, conQuestionnaireSet.QuestionnaireSetId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strQuestionnaireSetId, 4, conQuestionnaireSet.QuestionnaireSetId);
}
objQuestionnaireSetEN.QuestionnaireSetId = strQuestionnaireSetId; //问卷集ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQuestionnaireSetEN.dicFldComparisonOp.ContainsKey(conQuestionnaireSet.QuestionnaireSetId) == false)
{
objQuestionnaireSetEN.dicFldComparisonOp.Add(conQuestionnaireSet.QuestionnaireSetId, strComparisonOp);
}
else
{
objQuestionnaireSetEN.dicFldComparisonOp[conQuestionnaireSet.QuestionnaireSetId] = strComparisonOp;
}
}
return objQuestionnaireSetEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQuestionnaireSetEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQuestionnaireSetEN SetQuestionnaireSetName(this clsQuestionnaireSetEN objQuestionnaireSetEN, string strQuestionnaireSetName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strQuestionnaireSetName, conQuestionnaireSet.QuestionnaireSetName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strQuestionnaireSetName, 50, conQuestionnaireSet.QuestionnaireSetName);
}
objQuestionnaireSetEN.QuestionnaireSetName = strQuestionnaireSetName; //问卷集名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQuestionnaireSetEN.dicFldComparisonOp.ContainsKey(conQuestionnaireSet.QuestionnaireSetName) == false)
{
objQuestionnaireSetEN.dicFldComparisonOp.Add(conQuestionnaireSet.QuestionnaireSetName, strComparisonOp);
}
else
{
objQuestionnaireSetEN.dicFldComparisonOp[conQuestionnaireSet.QuestionnaireSetName] = strComparisonOp;
}
}
return objQuestionnaireSetEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQuestionnaireSetEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQuestionnaireSetEN SetOrderFieldInExport(this clsQuestionnaireSetEN objQuestionnaireSetEN, string strOrderFieldInExport, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strOrderFieldInExport, 200, conQuestionnaireSet.OrderFieldInExport);
}
objQuestionnaireSetEN.OrderFieldInExport = strOrderFieldInExport; //导出排序字段
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQuestionnaireSetEN.dicFldComparisonOp.ContainsKey(conQuestionnaireSet.OrderFieldInExport) == false)
{
objQuestionnaireSetEN.dicFldComparisonOp.Add(conQuestionnaireSet.OrderFieldInExport, strComparisonOp);
}
else
{
objQuestionnaireSetEN.dicFldComparisonOp[conQuestionnaireSet.OrderFieldInExport] = strComparisonOp;
}
}
return objQuestionnaireSetEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQuestionnaireSetEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQuestionnaireSetEN SetClassNo(this clsQuestionnaireSetEN objQuestionnaireSetEN, int? intClassNo, string strComparisonOp="")
	{
objQuestionnaireSetEN.ClassNo = intClassNo; //分类号1
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQuestionnaireSetEN.dicFldComparisonOp.ContainsKey(conQuestionnaireSet.ClassNo) == false)
{
objQuestionnaireSetEN.dicFldComparisonOp.Add(conQuestionnaireSet.ClassNo, strComparisonOp);
}
else
{
objQuestionnaireSetEN.dicFldComparisonOp[conQuestionnaireSet.ClassNo] = strComparisonOp;
}
}
return objQuestionnaireSetEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQuestionnaireSetEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQuestionnaireSetEN SetClassNo2(this clsQuestionnaireSetEN objQuestionnaireSetEN, int? intClassNo2, string strComparisonOp="")
	{
objQuestionnaireSetEN.ClassNo2 = intClassNo2; //分类号2
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQuestionnaireSetEN.dicFldComparisonOp.ContainsKey(conQuestionnaireSet.ClassNo2) == false)
{
objQuestionnaireSetEN.dicFldComparisonOp.Add(conQuestionnaireSet.ClassNo2, strComparisonOp);
}
else
{
objQuestionnaireSetEN.dicFldComparisonOp[conQuestionnaireSet.ClassNo2] = strComparisonOp;
}
}
return objQuestionnaireSetEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQuestionnaireSetEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQuestionnaireSetEN SetIsShowQuestionNo(this clsQuestionnaireSetEN objQuestionnaireSetEN, bool bolIsShowQuestionNo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(bolIsShowQuestionNo, conQuestionnaireSet.IsShowQuestionNo);
objQuestionnaireSetEN.IsShowQuestionNo = bolIsShowQuestionNo; //是否显示问题编号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQuestionnaireSetEN.dicFldComparisonOp.ContainsKey(conQuestionnaireSet.IsShowQuestionNo) == false)
{
objQuestionnaireSetEN.dicFldComparisonOp.Add(conQuestionnaireSet.IsShowQuestionNo, strComparisonOp);
}
else
{
objQuestionnaireSetEN.dicFldComparisonOp[conQuestionnaireSet.IsShowQuestionNo] = strComparisonOp;
}
}
return objQuestionnaireSetEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQuestionnaireSetEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQuestionnaireSetEN SetLogoFileName(this clsQuestionnaireSetEN objQuestionnaireSetEN, string strLogoFileName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strLogoFileName, 50, conQuestionnaireSet.LogoFileName);
}
objQuestionnaireSetEN.LogoFileName = strLogoFileName; //Logo文件名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQuestionnaireSetEN.dicFldComparisonOp.ContainsKey(conQuestionnaireSet.LogoFileName) == false)
{
objQuestionnaireSetEN.dicFldComparisonOp.Add(conQuestionnaireSet.LogoFileName, strComparisonOp);
}
else
{
objQuestionnaireSetEN.dicFldComparisonOp[conQuestionnaireSet.LogoFileName] = strComparisonOp;
}
}
return objQuestionnaireSetEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQuestionnaireSetEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQuestionnaireSetEN SetUpdDate(this clsQuestionnaireSetEN objQuestionnaireSetEN, string strUpdDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strUpdDate, conQuestionnaireSet.UpdDate);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdDate, 20, conQuestionnaireSet.UpdDate);
}
objQuestionnaireSetEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQuestionnaireSetEN.dicFldComparisonOp.ContainsKey(conQuestionnaireSet.UpdDate) == false)
{
objQuestionnaireSetEN.dicFldComparisonOp.Add(conQuestionnaireSet.UpdDate, strComparisonOp);
}
else
{
objQuestionnaireSetEN.dicFldComparisonOp[conQuestionnaireSet.UpdDate] = strComparisonOp;
}
}
return objQuestionnaireSetEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQuestionnaireSetEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQuestionnaireSetEN SetUpdUser(this clsQuestionnaireSetEN objQuestionnaireSetEN, string strUpdUser, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strUpdUser, conQuestionnaireSet.UpdUser);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdUser, 20, conQuestionnaireSet.UpdUser);
}
objQuestionnaireSetEN.UpdUser = strUpdUser; //修改人
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQuestionnaireSetEN.dicFldComparisonOp.ContainsKey(conQuestionnaireSet.UpdUser) == false)
{
objQuestionnaireSetEN.dicFldComparisonOp.Add(conQuestionnaireSet.UpdUser, strComparisonOp);
}
else
{
objQuestionnaireSetEN.dicFldComparisonOp[conQuestionnaireSet.UpdUser] = strComparisonOp;
}
}
return objQuestionnaireSetEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQuestionnaireSetEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQuestionnaireSetEN SetMemo(this clsQuestionnaireSetEN objQuestionnaireSetEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, conQuestionnaireSet.Memo);
}
objQuestionnaireSetEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQuestionnaireSetEN.dicFldComparisonOp.ContainsKey(conQuestionnaireSet.Memo) == false)
{
objQuestionnaireSetEN.dicFldComparisonOp.Add(conQuestionnaireSet.Memo, strComparisonOp);
}
else
{
objQuestionnaireSetEN.dicFldComparisonOp[conQuestionnaireSet.Memo] = strComparisonOp;
}
}
return objQuestionnaireSetEN;
	}

 /// <summary>
 /// 修改记录存盘到数据表中
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_UpdateRecordEx)
 /// </summary>
 /// <param name = "objQuestionnaireSetEN">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool UpdateRecordEx(this clsQuestionnaireSetEN objQuestionnaireSetEN)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
try
{
//1、检查传进去的对象属性是否合法
objQuestionnaireSetEN.CheckPropertyNew();
clsQuestionnaireSetEN objQuestionnaireSetCond = new clsQuestionnaireSetEN();
string strCondition = objQuestionnaireSetCond
.SetQuestionnaireSetId(objQuestionnaireSetEN.QuestionnaireSetId, "<>")
.SetQuestionnaireSetName(objQuestionnaireSetEN.QuestionnaireSetName, "=")
.GetCombineCondition();
objQuestionnaireSetEN._IsCheckProperty = true;
bool bolIsExist = clsQuestionnaireSetBL.IsExistRecord(strCondition);
if (bolIsExist)
{
strMsg = "(QuestionnaireSetName)不能重复!";
throw new Exception(strMsg);
}
//4、把数据实体层的数据存贮到数据库中
objQuestionnaireSetEN.Update();
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
 /// <param name = "objQuestionnaireSet">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool EditRecordEx(this clsQuestionnaireSetEN objQuestionnaireSet)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
clsQuestionnaireSetEN objQuestionnaireSetCond = new clsQuestionnaireSetEN();
string strCondition = objQuestionnaireSetCond
.SetQuestionnaireSetName(objQuestionnaireSet.QuestionnaireSetName, "=")
.GetCombineCondition();
objQuestionnaireSet._IsCheckProperty = true;
bool bolIsExist = clsQuestionnaireSetBL.IsExistRecord(strCondition);
if (bolIsExist)
{
objQuestionnaireSet.QuestionnaireSetId = clsQuestionnaireSetBL.GetFirstID_S(strCondition);
objQuestionnaireSet.UpdateWithCondition(strCondition);
}
else
{
objQuestionnaireSet.QuestionnaireSetId = clsQuestionnaireSetBL.GetMaxStrId_S();
objQuestionnaireSet.AddNewRecord();
}
return true; 
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_Update)
 /// </summary>
 /// <param name = "objQuestionnaireSetEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsQuestionnaireSetEN objQuestionnaireSetEN)
{
 if (string.IsNullOrEmpty(objQuestionnaireSetEN.QuestionnaireSetId) == true)
 {
string strMsg = string.Format("(errid:Busi000095)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsQuestionnaireSetBL.QuestionnaireSetDA.UpdateBySql2(objQuestionnaireSetEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsQuestionnaireSetBL.ReFreshCache();

if (clsQuestionnaireSetBL.relatedActions != null)
{
clsQuestionnaireSetBL.relatedActions.UpdRelaTabDate(objQuestionnaireSetEN.QuestionnaireSetId, objQuestionnaireSetEN.UpdUser);
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
 /// <param name = "objQuestionnaireSetEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsQuestionnaireSetEN objQuestionnaireSetEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (string.IsNullOrEmpty(objQuestionnaireSetEN.QuestionnaireSetId) == true)
 {
string strMsg = string.Format("(errid:Busi000087)修改记录时关键字不能为空!(带事务处理)(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsQuestionnaireSetBL.QuestionnaireSetDA.UpdateBySql2(objQuestionnaireSetEN, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsQuestionnaireSetBL.ReFreshCache();

if (clsQuestionnaireSetBL.relatedActions != null)
{
clsQuestionnaireSetBL.relatedActions.UpdRelaTabDate(objQuestionnaireSetEN.QuestionnaireSetId, objQuestionnaireSetEN.UpdUser);
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
 /// <param name = "objQuestionnaireSetEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsQuestionnaireSetEN objQuestionnaireSetEN, string strWhereCond)
{
try
{
bool bolResult = clsQuestionnaireSetBL.QuestionnaireSetDA.UpdateBySqlWithCondition(objQuestionnaireSetEN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsQuestionnaireSetBL.ReFreshCache();

if (clsQuestionnaireSetBL.relatedActions != null)
{
clsQuestionnaireSetBL.relatedActions.UpdRelaTabDate(objQuestionnaireSetEN.QuestionnaireSetId, objQuestionnaireSetEN.UpdUser);
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
 /// <param name = "objQuestionnaireSetEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsQuestionnaireSetEN objQuestionnaireSetEN, string strWhereCond, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
bool bolResult = clsQuestionnaireSetBL.QuestionnaireSetDA.UpdateBySqlWithConditionTransaction(objQuestionnaireSetEN, strWhereCond, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsQuestionnaireSetBL.ReFreshCache();

if (clsQuestionnaireSetBL.relatedActions != null)
{
clsQuestionnaireSetBL.relatedActions.UpdRelaTabDate(objQuestionnaireSetEN.QuestionnaireSetId, objQuestionnaireSetEN.UpdUser);
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
 /// <param name = "strQuestionnaireSetId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int Delete(this clsQuestionnaireSetEN objQuestionnaireSetEN)
{
try
{
int intRecNum = clsQuestionnaireSetBL.QuestionnaireSetDA.DelRecord(objQuestionnaireSetEN.QuestionnaireSetId);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsQuestionnaireSetBL.ReFreshCache();

if (clsQuestionnaireSetBL.relatedActions != null)
{
clsQuestionnaireSetBL.relatedActions.UpdRelaTabDate(objQuestionnaireSetEN.QuestionnaireSetId, objQuestionnaireSetEN.UpdUser);
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
 /// <param name = "objQuestionnaireSetENS">源对象</param>
 /// <param name = "objQuestionnaireSetENT">目标对象</param>
 public static void CopyTo(this clsQuestionnaireSetEN objQuestionnaireSetENS, clsQuestionnaireSetEN objQuestionnaireSetENT)
{
try
{
objQuestionnaireSetENT.QuestionnaireSetId = objQuestionnaireSetENS.QuestionnaireSetId; //问卷集ID
objQuestionnaireSetENT.QuestionnaireSetName = objQuestionnaireSetENS.QuestionnaireSetName; //问卷集名
objQuestionnaireSetENT.OrderFieldInExport = objQuestionnaireSetENS.OrderFieldInExport; //导出排序字段
objQuestionnaireSetENT.ClassNo = objQuestionnaireSetENS.ClassNo; //分类号1
objQuestionnaireSetENT.ClassNo2 = objQuestionnaireSetENS.ClassNo2; //分类号2
objQuestionnaireSetENT.IsShowQuestionNo = objQuestionnaireSetENS.IsShowQuestionNo; //是否显示问题编号
objQuestionnaireSetENT.LogoFileName = objQuestionnaireSetENS.LogoFileName; //Logo文件名
objQuestionnaireSetENT.UpdDate = objQuestionnaireSetENS.UpdDate; //修改日期
objQuestionnaireSetENT.UpdUser = objQuestionnaireSetENS.UpdUser; //修改人
objQuestionnaireSetENT.Memo = objQuestionnaireSetENS.Memo; //备注
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
 /// <param name = "objQuestionnaireSetENS">源对象</param>
 /// <returns>目标对象=>clsQuestionnaireSetEN:objQuestionnaireSetENT</returns>
 public static clsQuestionnaireSetEN CopyTo(this clsQuestionnaireSetEN objQuestionnaireSetENS)
{
try
{
 clsQuestionnaireSetEN objQuestionnaireSetENT = new clsQuestionnaireSetEN()
{
QuestionnaireSetId = objQuestionnaireSetENS.QuestionnaireSetId, //问卷集ID
QuestionnaireSetName = objQuestionnaireSetENS.QuestionnaireSetName, //问卷集名
OrderFieldInExport = objQuestionnaireSetENS.OrderFieldInExport, //导出排序字段
ClassNo = objQuestionnaireSetENS.ClassNo, //分类号1
ClassNo2 = objQuestionnaireSetENS.ClassNo2, //分类号2
IsShowQuestionNo = objQuestionnaireSetENS.IsShowQuestionNo, //是否显示问题编号
LogoFileName = objQuestionnaireSetENS.LogoFileName, //Logo文件名
UpdDate = objQuestionnaireSetENS.UpdDate, //修改日期
UpdUser = objQuestionnaireSetENS.UpdUser, //修改人
Memo = objQuestionnaireSetENS.Memo, //备注
};
 return objQuestionnaireSetENT;
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
public static void CheckPropertyNew(this clsQuestionnaireSetEN objQuestionnaireSetEN)
{
 clsQuestionnaireSetBL.QuestionnaireSetDA.CheckPropertyNew(objQuestionnaireSetEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(this clsQuestionnaireSetEN objQuestionnaireSetEN)
{
 clsQuestionnaireSetBL.QuestionnaireSetDA.CheckProperty4Condition(objQuestionnaireSetEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsQuestionnaireSetEN objQuestionnaireSetCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objQuestionnaireSetCond.IsUpdated(conQuestionnaireSet.QuestionnaireSetId) == true)
{
string strComparisonOpQuestionnaireSetId = objQuestionnaireSetCond.dicFldComparisonOp[conQuestionnaireSet.QuestionnaireSetId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conQuestionnaireSet.QuestionnaireSetId, objQuestionnaireSetCond.QuestionnaireSetId, strComparisonOpQuestionnaireSetId);
}
if (objQuestionnaireSetCond.IsUpdated(conQuestionnaireSet.QuestionnaireSetName) == true)
{
string strComparisonOpQuestionnaireSetName = objQuestionnaireSetCond.dicFldComparisonOp[conQuestionnaireSet.QuestionnaireSetName];
strWhereCond += string.Format(" And {0} {2} '{1}'", conQuestionnaireSet.QuestionnaireSetName, objQuestionnaireSetCond.QuestionnaireSetName, strComparisonOpQuestionnaireSetName);
}
if (objQuestionnaireSetCond.IsUpdated(conQuestionnaireSet.OrderFieldInExport) == true)
{
string strComparisonOpOrderFieldInExport = objQuestionnaireSetCond.dicFldComparisonOp[conQuestionnaireSet.OrderFieldInExport];
strWhereCond += string.Format(" And {0} {2} '{1}'", conQuestionnaireSet.OrderFieldInExport, objQuestionnaireSetCond.OrderFieldInExport, strComparisonOpOrderFieldInExport);
}
if (objQuestionnaireSetCond.IsUpdated(conQuestionnaireSet.ClassNo) == true)
{
string strComparisonOpClassNo = objQuestionnaireSetCond.dicFldComparisonOp[conQuestionnaireSet.ClassNo];
strWhereCond += string.Format(" And {0} {2} {1}", conQuestionnaireSet.ClassNo, objQuestionnaireSetCond.ClassNo, strComparisonOpClassNo);
}
if (objQuestionnaireSetCond.IsUpdated(conQuestionnaireSet.ClassNo2) == true)
{
string strComparisonOpClassNo2 = objQuestionnaireSetCond.dicFldComparisonOp[conQuestionnaireSet.ClassNo2];
strWhereCond += string.Format(" And {0} {2} {1}", conQuestionnaireSet.ClassNo2, objQuestionnaireSetCond.ClassNo2, strComparisonOpClassNo2);
}
if (objQuestionnaireSetCond.IsUpdated(conQuestionnaireSet.IsShowQuestionNo) == true)
{
if (objQuestionnaireSetCond.IsShowQuestionNo == true)
{
strWhereCond += string.Format(" And {0} = '1'", conQuestionnaireSet.IsShowQuestionNo);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conQuestionnaireSet.IsShowQuestionNo);
}
}
if (objQuestionnaireSetCond.IsUpdated(conQuestionnaireSet.LogoFileName) == true)
{
string strComparisonOpLogoFileName = objQuestionnaireSetCond.dicFldComparisonOp[conQuestionnaireSet.LogoFileName];
strWhereCond += string.Format(" And {0} {2} '{1}'", conQuestionnaireSet.LogoFileName, objQuestionnaireSetCond.LogoFileName, strComparisonOpLogoFileName);
}
if (objQuestionnaireSetCond.IsUpdated(conQuestionnaireSet.UpdDate) == true)
{
string strComparisonOpUpdDate = objQuestionnaireSetCond.dicFldComparisonOp[conQuestionnaireSet.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conQuestionnaireSet.UpdDate, objQuestionnaireSetCond.UpdDate, strComparisonOpUpdDate);
}
if (objQuestionnaireSetCond.IsUpdated(conQuestionnaireSet.UpdUser) == true)
{
string strComparisonOpUpdUser = objQuestionnaireSetCond.dicFldComparisonOp[conQuestionnaireSet.UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", conQuestionnaireSet.UpdUser, objQuestionnaireSetCond.UpdUser, strComparisonOpUpdUser);
}
if (objQuestionnaireSetCond.IsUpdated(conQuestionnaireSet.Memo) == true)
{
string strComparisonOpMemo = objQuestionnaireSetCond.dicFldComparisonOp[conQuestionnaireSet.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", conQuestionnaireSet.Memo, objQuestionnaireSetCond.Memo, strComparisonOpMemo);
}
 return strWhereCond;
}

 /// <summary>
 /// 检查唯一性(Uniqueness)--QuestionnaireSet(问卷集), 如果不唯一,即存在相同的记录,就返回False
 /// 唯一性条件:QuestionnaireSetName
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckConstraint)
 /// </summary>
 /// <param name = "objQuestionnaireSetEN">要求唯一的对象</param>
 /// <returns></returns>
public static bool CheckUniqueness(this clsQuestionnaireSetEN objQuestionnaireSetEN)
{
//检测记录是否存在
bool bolIsUniqueness;
StringBuilder sbCondition = new StringBuilder();
if (objQuestionnaireSetEN == null) return true;
if (objQuestionnaireSetEN.QuestionnaireSetId == null || objQuestionnaireSetEN.QuestionnaireSetId == "")
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and QuestionnaireSetName = '{0}'", objQuestionnaireSetEN.QuestionnaireSetName);
if (clsQuestionnaireSetBL.IsExistRecord(sbCondition.ToString())  ==  true)
{
 bolIsUniqueness = false;
}
else
{
 bolIsUniqueness = true;
}
}
 else {
sbCondition.AppendFormat("QuestionnaireSetId !=  '{0}'", objQuestionnaireSetEN.QuestionnaireSetId);
 sbCondition.AppendFormat(" and QuestionnaireSetName = '{0}'", objQuestionnaireSetEN.QuestionnaireSetName);
if (clsQuestionnaireSetBL.IsExistRecord(sbCondition.ToString())  ==  true)
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
 /// 获取唯一性条件串--QuestionnaireSet(问卷集), 即由对象中唯一性条件字段关键字与值组成的条件串
 /// 唯一性条件:QuestionnaireSetName
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetConditionString4Constraint)
 /// </summary>
 /// <param name = "objQuestionnaireSetEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(this clsQuestionnaireSetEN objQuestionnaireSetEN)
{
//检测记录是否存在
StringBuilder sbCondition = new StringBuilder();
if (objQuestionnaireSetEN == null) return "";
if (objQuestionnaireSetEN.QuestionnaireSetId == null || objQuestionnaireSetEN.QuestionnaireSetId == "")
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and QuestionnaireSetName = '{0}'", objQuestionnaireSetEN.QuestionnaireSetName);
return sbCondition.ToString();
}
 else {
sbCondition.AppendFormat("QuestionnaireSetId !=  '{0}'", objQuestionnaireSetEN.QuestionnaireSetId);
 sbCondition.AppendFormat(" and QuestionnaireSetName = '{0}'", objQuestionnaireSetEN.QuestionnaireSetName);
 return sbCondition.ToString();
}
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_QuestionnaireSet
{
public virtual bool UpdRelaTabDate(string strQuestionnaireSetId, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// 问卷集(QuestionnaireSet)
 /// 数据源类型:表
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsQuestionnaireSetBL
{
public static RelatedActions_QuestionnaireSet relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsQuestionnaireSetDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsQuestionnaireSetDA QuestionnaireSetDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsQuestionnaireSetDA();
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
 public clsQuestionnaireSetBL()
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
if (string.IsNullOrEmpty(clsQuestionnaireSetEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsQuestionnaireSetEN._ConnectString);
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
public static DataTable GetDataTable_QuestionnaireSet(string strWhereCond)
{
DataTable objDT;
try
{
objDT = QuestionnaireSetDA.GetDataTable_QuestionnaireSet(strWhereCond);
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
objDT = QuestionnaireSetDA.GetDataTable(strWhereCond);
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
objDT = QuestionnaireSetDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = QuestionnaireSetDA.GetDataTable(strWhereCond, strTabName);
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
objDT = QuestionnaireSetDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = QuestionnaireSetDA.GetDataTable_Top(objTopPara);
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
objDT = QuestionnaireSetDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = QuestionnaireSetDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = QuestionnaireSetDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
 /// <param name = "arrQuestionnaireSetIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static List<clsQuestionnaireSetEN> GetObjLstByQuestionnaireSetIdLst(List<string> arrQuestionnaireSetIdLst)
{
List<clsQuestionnaireSetEN> arrObjLst = new List<clsQuestionnaireSetEN>(); 
System.Data.DataTable objDT; 
 string strSqlConditionStr = clsArray.GetSqlInStrByArray(arrQuestionnaireSetIdLst, true);
 string strWhereCond = string.Format("QuestionnaireSetId in ({0})", strSqlConditionStr);
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsQuestionnaireSetEN objQuestionnaireSetEN = new clsQuestionnaireSetEN();
try
{
objQuestionnaireSetEN.QuestionnaireSetId = objRow[conQuestionnaireSet.QuestionnaireSetId].ToString().Trim(); //问卷集ID
objQuestionnaireSetEN.QuestionnaireSetName = objRow[conQuestionnaireSet.QuestionnaireSetName].ToString().Trim(); //问卷集名
objQuestionnaireSetEN.OrderFieldInExport = objRow[conQuestionnaireSet.OrderFieldInExport] == DBNull.Value ? null : objRow[conQuestionnaireSet.OrderFieldInExport].ToString().Trim(); //导出排序字段
objQuestionnaireSetEN.ClassNo = objRow[conQuestionnaireSet.ClassNo] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conQuestionnaireSet.ClassNo].ToString().Trim()); //分类号1
objQuestionnaireSetEN.ClassNo2 = objRow[conQuestionnaireSet.ClassNo2] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conQuestionnaireSet.ClassNo2].ToString().Trim()); //分类号2
objQuestionnaireSetEN.IsShowQuestionNo = clsEntityBase2.TransNullToBool_S(objRow[conQuestionnaireSet.IsShowQuestionNo].ToString().Trim()); //是否显示问题编号
objQuestionnaireSetEN.LogoFileName = objRow[conQuestionnaireSet.LogoFileName] == DBNull.Value ? null : objRow[conQuestionnaireSet.LogoFileName].ToString().Trim(); //Logo文件名
objQuestionnaireSetEN.UpdDate = objRow[conQuestionnaireSet.UpdDate].ToString().Trim(); //修改日期
objQuestionnaireSetEN.UpdUser = objRow[conQuestionnaireSet.UpdUser].ToString().Trim(); //修改人
objQuestionnaireSetEN.Memo = objRow[conQuestionnaireSet.Memo] == DBNull.Value ? null : objRow[conQuestionnaireSet.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objQuestionnaireSetEN.QuestionnaireSetId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objQuestionnaireSetEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrQuestionnaireSetIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsQuestionnaireSetEN> GetObjLstByQuestionnaireSetIdLstCache(List<string> arrQuestionnaireSetIdLst)
{
string strKey = string.Format("{0}", clsQuestionnaireSetEN._CurrTabName);
List<clsQuestionnaireSetEN> arrQuestionnaireSetObjLstCache = GetObjLstCache();
IEnumerable <clsQuestionnaireSetEN> arrQuestionnaireSetObjLst_Sel =
arrQuestionnaireSetObjLstCache
.Where(x => arrQuestionnaireSetIdLst.Contains(x.QuestionnaireSetId));
return arrQuestionnaireSetObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsQuestionnaireSetEN> GetObjLst(string strWhereCond)
{
List<clsQuestionnaireSetEN> arrObjLst = new List<clsQuestionnaireSetEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsQuestionnaireSetEN objQuestionnaireSetEN = new clsQuestionnaireSetEN();
try
{
objQuestionnaireSetEN.QuestionnaireSetId = objRow[conQuestionnaireSet.QuestionnaireSetId].ToString().Trim(); //问卷集ID
objQuestionnaireSetEN.QuestionnaireSetName = objRow[conQuestionnaireSet.QuestionnaireSetName].ToString().Trim(); //问卷集名
objQuestionnaireSetEN.OrderFieldInExport = objRow[conQuestionnaireSet.OrderFieldInExport] == DBNull.Value ? null : objRow[conQuestionnaireSet.OrderFieldInExport].ToString().Trim(); //导出排序字段
objQuestionnaireSetEN.ClassNo = objRow[conQuestionnaireSet.ClassNo] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conQuestionnaireSet.ClassNo].ToString().Trim()); //分类号1
objQuestionnaireSetEN.ClassNo2 = objRow[conQuestionnaireSet.ClassNo2] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conQuestionnaireSet.ClassNo2].ToString().Trim()); //分类号2
objQuestionnaireSetEN.IsShowQuestionNo = clsEntityBase2.TransNullToBool_S(objRow[conQuestionnaireSet.IsShowQuestionNo].ToString().Trim()); //是否显示问题编号
objQuestionnaireSetEN.LogoFileName = objRow[conQuestionnaireSet.LogoFileName] == DBNull.Value ? null : objRow[conQuestionnaireSet.LogoFileName].ToString().Trim(); //Logo文件名
objQuestionnaireSetEN.UpdDate = objRow[conQuestionnaireSet.UpdDate].ToString().Trim(); //修改日期
objQuestionnaireSetEN.UpdUser = objRow[conQuestionnaireSet.UpdUser].ToString().Trim(); //修改人
objQuestionnaireSetEN.Memo = objRow[conQuestionnaireSet.Memo] == DBNull.Value ? null : objRow[conQuestionnaireSet.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objQuestionnaireSetEN.QuestionnaireSetId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objQuestionnaireSetEN);
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
public static List<clsQuestionnaireSetEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsQuestionnaireSetEN> arrObjLst = new List<clsQuestionnaireSetEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsQuestionnaireSetEN objQuestionnaireSetEN = new clsQuestionnaireSetEN();
try
{
objQuestionnaireSetEN.QuestionnaireSetId = objRow[conQuestionnaireSet.QuestionnaireSetId].ToString().Trim(); //问卷集ID
objQuestionnaireSetEN.QuestionnaireSetName = objRow[conQuestionnaireSet.QuestionnaireSetName].ToString().Trim(); //问卷集名
objQuestionnaireSetEN.OrderFieldInExport = objRow[conQuestionnaireSet.OrderFieldInExport] == DBNull.Value ? null : objRow[conQuestionnaireSet.OrderFieldInExport].ToString().Trim(); //导出排序字段
objQuestionnaireSetEN.ClassNo = objRow[conQuestionnaireSet.ClassNo] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conQuestionnaireSet.ClassNo].ToString().Trim()); //分类号1
objQuestionnaireSetEN.ClassNo2 = objRow[conQuestionnaireSet.ClassNo2] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conQuestionnaireSet.ClassNo2].ToString().Trim()); //分类号2
objQuestionnaireSetEN.IsShowQuestionNo = clsEntityBase2.TransNullToBool_S(objRow[conQuestionnaireSet.IsShowQuestionNo].ToString().Trim()); //是否显示问题编号
objQuestionnaireSetEN.LogoFileName = objRow[conQuestionnaireSet.LogoFileName] == DBNull.Value ? null : objRow[conQuestionnaireSet.LogoFileName].ToString().Trim(); //Logo文件名
objQuestionnaireSetEN.UpdDate = objRow[conQuestionnaireSet.UpdDate].ToString().Trim(); //修改日期
objQuestionnaireSetEN.UpdUser = objRow[conQuestionnaireSet.UpdUser].ToString().Trim(); //修改人
objQuestionnaireSetEN.Memo = objRow[conQuestionnaireSet.Memo] == DBNull.Value ? null : objRow[conQuestionnaireSet.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objQuestionnaireSetEN.QuestionnaireSetId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objQuestionnaireSetEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objQuestionnaireSetCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsQuestionnaireSetEN> GetSubObjLstCache(clsQuestionnaireSetEN objQuestionnaireSetCond)
{
List<clsQuestionnaireSetEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsQuestionnaireSetEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conQuestionnaireSet.AttributeName)
{
if (objQuestionnaireSetCond.IsUpdated(strFldName) == false) continue;
if (objQuestionnaireSetCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objQuestionnaireSetCond[strFldName].ToString());
}
else
{
if (objQuestionnaireSetCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objQuestionnaireSetCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objQuestionnaireSetCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objQuestionnaireSetCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objQuestionnaireSetCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objQuestionnaireSetCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objQuestionnaireSetCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objQuestionnaireSetCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objQuestionnaireSetCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objQuestionnaireSetCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objQuestionnaireSetCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objQuestionnaireSetCond[strFldName]));
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
public static List<clsQuestionnaireSetEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsQuestionnaireSetEN> arrObjLst = new List<clsQuestionnaireSetEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsQuestionnaireSetEN objQuestionnaireSetEN = new clsQuestionnaireSetEN();
try
{
objQuestionnaireSetEN.QuestionnaireSetId = objRow[conQuestionnaireSet.QuestionnaireSetId].ToString().Trim(); //问卷集ID
objQuestionnaireSetEN.QuestionnaireSetName = objRow[conQuestionnaireSet.QuestionnaireSetName].ToString().Trim(); //问卷集名
objQuestionnaireSetEN.OrderFieldInExport = objRow[conQuestionnaireSet.OrderFieldInExport] == DBNull.Value ? null : objRow[conQuestionnaireSet.OrderFieldInExport].ToString().Trim(); //导出排序字段
objQuestionnaireSetEN.ClassNo = objRow[conQuestionnaireSet.ClassNo] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conQuestionnaireSet.ClassNo].ToString().Trim()); //分类号1
objQuestionnaireSetEN.ClassNo2 = objRow[conQuestionnaireSet.ClassNo2] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conQuestionnaireSet.ClassNo2].ToString().Trim()); //分类号2
objQuestionnaireSetEN.IsShowQuestionNo = clsEntityBase2.TransNullToBool_S(objRow[conQuestionnaireSet.IsShowQuestionNo].ToString().Trim()); //是否显示问题编号
objQuestionnaireSetEN.LogoFileName = objRow[conQuestionnaireSet.LogoFileName] == DBNull.Value ? null : objRow[conQuestionnaireSet.LogoFileName].ToString().Trim(); //Logo文件名
objQuestionnaireSetEN.UpdDate = objRow[conQuestionnaireSet.UpdDate].ToString().Trim(); //修改日期
objQuestionnaireSetEN.UpdUser = objRow[conQuestionnaireSet.UpdUser].ToString().Trim(); //修改人
objQuestionnaireSetEN.Memo = objRow[conQuestionnaireSet.Memo] == DBNull.Value ? null : objRow[conQuestionnaireSet.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objQuestionnaireSetEN.QuestionnaireSetId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objQuestionnaireSetEN);
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
public static List<clsQuestionnaireSetEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsQuestionnaireSetEN> arrObjLst = new List<clsQuestionnaireSetEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsQuestionnaireSetEN objQuestionnaireSetEN = new clsQuestionnaireSetEN();
try
{
objQuestionnaireSetEN.QuestionnaireSetId = objRow[conQuestionnaireSet.QuestionnaireSetId].ToString().Trim(); //问卷集ID
objQuestionnaireSetEN.QuestionnaireSetName = objRow[conQuestionnaireSet.QuestionnaireSetName].ToString().Trim(); //问卷集名
objQuestionnaireSetEN.OrderFieldInExport = objRow[conQuestionnaireSet.OrderFieldInExport] == DBNull.Value ? null : objRow[conQuestionnaireSet.OrderFieldInExport].ToString().Trim(); //导出排序字段
objQuestionnaireSetEN.ClassNo = objRow[conQuestionnaireSet.ClassNo] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conQuestionnaireSet.ClassNo].ToString().Trim()); //分类号1
objQuestionnaireSetEN.ClassNo2 = objRow[conQuestionnaireSet.ClassNo2] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conQuestionnaireSet.ClassNo2].ToString().Trim()); //分类号2
objQuestionnaireSetEN.IsShowQuestionNo = clsEntityBase2.TransNullToBool_S(objRow[conQuestionnaireSet.IsShowQuestionNo].ToString().Trim()); //是否显示问题编号
objQuestionnaireSetEN.LogoFileName = objRow[conQuestionnaireSet.LogoFileName] == DBNull.Value ? null : objRow[conQuestionnaireSet.LogoFileName].ToString().Trim(); //Logo文件名
objQuestionnaireSetEN.UpdDate = objRow[conQuestionnaireSet.UpdDate].ToString().Trim(); //修改日期
objQuestionnaireSetEN.UpdUser = objRow[conQuestionnaireSet.UpdUser].ToString().Trim(); //修改人
objQuestionnaireSetEN.Memo = objRow[conQuestionnaireSet.Memo] == DBNull.Value ? null : objRow[conQuestionnaireSet.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objQuestionnaireSetEN.QuestionnaireSetId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objQuestionnaireSetEN);
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
List<clsQuestionnaireSetEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsQuestionnaireSetEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsQuestionnaireSetEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsQuestionnaireSetEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsQuestionnaireSetEN> arrObjLst = new List<clsQuestionnaireSetEN>(); 
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
	clsQuestionnaireSetEN objQuestionnaireSetEN = new clsQuestionnaireSetEN();
try
{
objQuestionnaireSetEN.QuestionnaireSetId = objRow[conQuestionnaireSet.QuestionnaireSetId].ToString().Trim(); //问卷集ID
objQuestionnaireSetEN.QuestionnaireSetName = objRow[conQuestionnaireSet.QuestionnaireSetName].ToString().Trim(); //问卷集名
objQuestionnaireSetEN.OrderFieldInExport = objRow[conQuestionnaireSet.OrderFieldInExport] == DBNull.Value ? null : objRow[conQuestionnaireSet.OrderFieldInExport].ToString().Trim(); //导出排序字段
objQuestionnaireSetEN.ClassNo = objRow[conQuestionnaireSet.ClassNo] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conQuestionnaireSet.ClassNo].ToString().Trim()); //分类号1
objQuestionnaireSetEN.ClassNo2 = objRow[conQuestionnaireSet.ClassNo2] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conQuestionnaireSet.ClassNo2].ToString().Trim()); //分类号2
objQuestionnaireSetEN.IsShowQuestionNo = clsEntityBase2.TransNullToBool_S(objRow[conQuestionnaireSet.IsShowQuestionNo].ToString().Trim()); //是否显示问题编号
objQuestionnaireSetEN.LogoFileName = objRow[conQuestionnaireSet.LogoFileName] == DBNull.Value ? null : objRow[conQuestionnaireSet.LogoFileName].ToString().Trim(); //Logo文件名
objQuestionnaireSetEN.UpdDate = objRow[conQuestionnaireSet.UpdDate].ToString().Trim(); //修改日期
objQuestionnaireSetEN.UpdUser = objRow[conQuestionnaireSet.UpdUser].ToString().Trim(); //修改人
objQuestionnaireSetEN.Memo = objRow[conQuestionnaireSet.Memo] == DBNull.Value ? null : objRow[conQuestionnaireSet.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objQuestionnaireSetEN.QuestionnaireSetId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objQuestionnaireSetEN);
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
public static List<clsQuestionnaireSetEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsQuestionnaireSetEN> arrObjLst = new List<clsQuestionnaireSetEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsQuestionnaireSetEN objQuestionnaireSetEN = new clsQuestionnaireSetEN();
try
{
objQuestionnaireSetEN.QuestionnaireSetId = objRow[conQuestionnaireSet.QuestionnaireSetId].ToString().Trim(); //问卷集ID
objQuestionnaireSetEN.QuestionnaireSetName = objRow[conQuestionnaireSet.QuestionnaireSetName].ToString().Trim(); //问卷集名
objQuestionnaireSetEN.OrderFieldInExport = objRow[conQuestionnaireSet.OrderFieldInExport] == DBNull.Value ? null : objRow[conQuestionnaireSet.OrderFieldInExport].ToString().Trim(); //导出排序字段
objQuestionnaireSetEN.ClassNo = objRow[conQuestionnaireSet.ClassNo] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conQuestionnaireSet.ClassNo].ToString().Trim()); //分类号1
objQuestionnaireSetEN.ClassNo2 = objRow[conQuestionnaireSet.ClassNo2] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conQuestionnaireSet.ClassNo2].ToString().Trim()); //分类号2
objQuestionnaireSetEN.IsShowQuestionNo = clsEntityBase2.TransNullToBool_S(objRow[conQuestionnaireSet.IsShowQuestionNo].ToString().Trim()); //是否显示问题编号
objQuestionnaireSetEN.LogoFileName = objRow[conQuestionnaireSet.LogoFileName] == DBNull.Value ? null : objRow[conQuestionnaireSet.LogoFileName].ToString().Trim(); //Logo文件名
objQuestionnaireSetEN.UpdDate = objRow[conQuestionnaireSet.UpdDate].ToString().Trim(); //修改日期
objQuestionnaireSetEN.UpdUser = objRow[conQuestionnaireSet.UpdUser].ToString().Trim(); //修改人
objQuestionnaireSetEN.Memo = objRow[conQuestionnaireSet.Memo] == DBNull.Value ? null : objRow[conQuestionnaireSet.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objQuestionnaireSetEN.QuestionnaireSetId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objQuestionnaireSetEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsQuestionnaireSetEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsQuestionnaireSetEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsQuestionnaireSetEN> arrObjLst = new List<clsQuestionnaireSetEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsQuestionnaireSetEN objQuestionnaireSetEN = new clsQuestionnaireSetEN();
try
{
objQuestionnaireSetEN.QuestionnaireSetId = objRow[conQuestionnaireSet.QuestionnaireSetId].ToString().Trim(); //问卷集ID
objQuestionnaireSetEN.QuestionnaireSetName = objRow[conQuestionnaireSet.QuestionnaireSetName].ToString().Trim(); //问卷集名
objQuestionnaireSetEN.OrderFieldInExport = objRow[conQuestionnaireSet.OrderFieldInExport] == DBNull.Value ? null : objRow[conQuestionnaireSet.OrderFieldInExport].ToString().Trim(); //导出排序字段
objQuestionnaireSetEN.ClassNo = objRow[conQuestionnaireSet.ClassNo] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conQuestionnaireSet.ClassNo].ToString().Trim()); //分类号1
objQuestionnaireSetEN.ClassNo2 = objRow[conQuestionnaireSet.ClassNo2] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conQuestionnaireSet.ClassNo2].ToString().Trim()); //分类号2
objQuestionnaireSetEN.IsShowQuestionNo = clsEntityBase2.TransNullToBool_S(objRow[conQuestionnaireSet.IsShowQuestionNo].ToString().Trim()); //是否显示问题编号
objQuestionnaireSetEN.LogoFileName = objRow[conQuestionnaireSet.LogoFileName] == DBNull.Value ? null : objRow[conQuestionnaireSet.LogoFileName].ToString().Trim(); //Logo文件名
objQuestionnaireSetEN.UpdDate = objRow[conQuestionnaireSet.UpdDate].ToString().Trim(); //修改日期
objQuestionnaireSetEN.UpdUser = objRow[conQuestionnaireSet.UpdUser].ToString().Trim(); //修改人
objQuestionnaireSetEN.Memo = objRow[conQuestionnaireSet.Memo] == DBNull.Value ? null : objRow[conQuestionnaireSet.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objQuestionnaireSetEN.QuestionnaireSetId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objQuestionnaireSetEN);
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
public static List<clsQuestionnaireSetEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsQuestionnaireSetEN> arrObjLst = new List<clsQuestionnaireSetEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsQuestionnaireSetEN objQuestionnaireSetEN = new clsQuestionnaireSetEN();
try
{
objQuestionnaireSetEN.QuestionnaireSetId = objRow[conQuestionnaireSet.QuestionnaireSetId].ToString().Trim(); //问卷集ID
objQuestionnaireSetEN.QuestionnaireSetName = objRow[conQuestionnaireSet.QuestionnaireSetName].ToString().Trim(); //问卷集名
objQuestionnaireSetEN.OrderFieldInExport = objRow[conQuestionnaireSet.OrderFieldInExport] == DBNull.Value ? null : objRow[conQuestionnaireSet.OrderFieldInExport].ToString().Trim(); //导出排序字段
objQuestionnaireSetEN.ClassNo = objRow[conQuestionnaireSet.ClassNo] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conQuestionnaireSet.ClassNo].ToString().Trim()); //分类号1
objQuestionnaireSetEN.ClassNo2 = objRow[conQuestionnaireSet.ClassNo2] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conQuestionnaireSet.ClassNo2].ToString().Trim()); //分类号2
objQuestionnaireSetEN.IsShowQuestionNo = clsEntityBase2.TransNullToBool_S(objRow[conQuestionnaireSet.IsShowQuestionNo].ToString().Trim()); //是否显示问题编号
objQuestionnaireSetEN.LogoFileName = objRow[conQuestionnaireSet.LogoFileName] == DBNull.Value ? null : objRow[conQuestionnaireSet.LogoFileName].ToString().Trim(); //Logo文件名
objQuestionnaireSetEN.UpdDate = objRow[conQuestionnaireSet.UpdDate].ToString().Trim(); //修改日期
objQuestionnaireSetEN.UpdUser = objRow[conQuestionnaireSet.UpdUser].ToString().Trim(); //修改人
objQuestionnaireSetEN.Memo = objRow[conQuestionnaireSet.Memo] == DBNull.Value ? null : objRow[conQuestionnaireSet.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objQuestionnaireSetEN.QuestionnaireSetId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objQuestionnaireSetEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsQuestionnaireSetEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsQuestionnaireSetEN> arrObjLst = new List<clsQuestionnaireSetEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsQuestionnaireSetEN objQuestionnaireSetEN = new clsQuestionnaireSetEN();
try
{
objQuestionnaireSetEN.QuestionnaireSetId = objRow[conQuestionnaireSet.QuestionnaireSetId].ToString().Trim(); //问卷集ID
objQuestionnaireSetEN.QuestionnaireSetName = objRow[conQuestionnaireSet.QuestionnaireSetName].ToString().Trim(); //问卷集名
objQuestionnaireSetEN.OrderFieldInExport = objRow[conQuestionnaireSet.OrderFieldInExport] == DBNull.Value ? null : objRow[conQuestionnaireSet.OrderFieldInExport].ToString().Trim(); //导出排序字段
objQuestionnaireSetEN.ClassNo = objRow[conQuestionnaireSet.ClassNo] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conQuestionnaireSet.ClassNo].ToString().Trim()); //分类号1
objQuestionnaireSetEN.ClassNo2 = objRow[conQuestionnaireSet.ClassNo2] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conQuestionnaireSet.ClassNo2].ToString().Trim()); //分类号2
objQuestionnaireSetEN.IsShowQuestionNo = clsEntityBase2.TransNullToBool_S(objRow[conQuestionnaireSet.IsShowQuestionNo].ToString().Trim()); //是否显示问题编号
objQuestionnaireSetEN.LogoFileName = objRow[conQuestionnaireSet.LogoFileName] == DBNull.Value ? null : objRow[conQuestionnaireSet.LogoFileName].ToString().Trim(); //Logo文件名
objQuestionnaireSetEN.UpdDate = objRow[conQuestionnaireSet.UpdDate].ToString().Trim(); //修改日期
objQuestionnaireSetEN.UpdUser = objRow[conQuestionnaireSet.UpdUser].ToString().Trim(); //修改人
objQuestionnaireSetEN.Memo = objRow[conQuestionnaireSet.Memo] == DBNull.Value ? null : objRow[conQuestionnaireSet.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objQuestionnaireSetEN.QuestionnaireSetId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objQuestionnaireSetEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objQuestionnaireSetEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetQuestionnaireSet(ref clsQuestionnaireSetEN objQuestionnaireSetEN)
{
bool bolResult = QuestionnaireSetDA.GetQuestionnaireSet(ref objQuestionnaireSetEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "strQuestionnaireSetId">表关键字</param>
 /// <returns>表对象</returns>
public static clsQuestionnaireSetEN GetObjByQuestionnaireSetId(string strQuestionnaireSetId)
{
if (strQuestionnaireSetId.IndexOf(' ') >=0)
{
var strMsg = string.Format("(errid:Busi000079)在表中,关键字[strQuestionnaireSetId]中不能有空格!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
if (string.IsNullOrEmpty(strQuestionnaireSetId) == true)
{
var strMsg = string.Format("(errid:Busi000020)在表中,关键字[strQuestionnaireSetId]不能为空!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
clsQuestionnaireSetEN objQuestionnaireSetEN = QuestionnaireSetDA.GetObjByQuestionnaireSetId(strQuestionnaireSetId);
return objQuestionnaireSetEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsQuestionnaireSetEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsQuestionnaireSetEN objQuestionnaireSetEN = QuestionnaireSetDA.GetFirstObj(strWhereCond);
 return objQuestionnaireSetEN;
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
public static clsQuestionnaireSetEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsQuestionnaireSetEN objQuestionnaireSetEN = QuestionnaireSetDA.GetObjByDataRow(objRow);
 return objQuestionnaireSetEN;
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
public static clsQuestionnaireSetEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsQuestionnaireSetEN objQuestionnaireSetEN = QuestionnaireSetDA.GetObjByDataRow(objRow);
 return objQuestionnaireSetEN;
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
 /// <param name = "strQuestionnaireSetId">所给的关键字</param>
 /// <param name = "lstQuestionnaireSetObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsQuestionnaireSetEN GetObjByQuestionnaireSetIdFromList(string strQuestionnaireSetId, List<clsQuestionnaireSetEN> lstQuestionnaireSetObjLst)
{
foreach (clsQuestionnaireSetEN objQuestionnaireSetEN in lstQuestionnaireSetObjLst)
{
if (objQuestionnaireSetEN.QuestionnaireSetId == strQuestionnaireSetId)
{
return objQuestionnaireSetEN;
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
 string strMaxQuestionnaireSetId;
 try
 {
 strMaxQuestionnaireSetId = clsQuestionnaireSetDA.GetMaxStrId();
 return strMaxQuestionnaireSetId;
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
 string strQuestionnaireSetId;
 try
 {
 strQuestionnaireSetId = new clsQuestionnaireSetDA().GetFirstID(strWhereCond);
 return strQuestionnaireSetId;
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
 arrList = QuestionnaireSetDA.GetID(strWhereCond);
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
bool bolIsExist = QuestionnaireSetDA.IsExistCondRec(strWhereCond);
return bolIsExist;
}

 /// <summary>
 /// 判断当前表中是否存在给定关键字值的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExist)
 /// </summary>
 /// <param name = "strQuestionnaireSetId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public static bool IsExist(string strQuestionnaireSetId)
{
if (string.IsNullOrEmpty(strQuestionnaireSetId) == true)
{
var strMsg = string.Format("(errid:Busi000027)在表中,关键字[strQuestionnaireSetId]不能为空!!(from {0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
//检测记录是否存在
bool bolIsExist = QuestionnaireSetDA.IsExist(strQuestionnaireSetId);
return bolIsExist;
}

/// <summary>
/// 设置修改时间
/// </summary>
/// <param name = "strQuestionnaireSetId">问卷集ID</param>
/// <param name = "strOpUser">修改用户</param>
/// <returns>是否成功？</returns>
public static bool SetUpdDate(string strQuestionnaireSetId, string strOpUser)
{
clsQuestionnaireSetEN objQuestionnaireSetEN = clsQuestionnaireSetBL.GetObjByQuestionnaireSetId(strQuestionnaireSetId);
objQuestionnaireSetEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
objQuestionnaireSetEN.UpdUser = strOpUser;
return clsQuestionnaireSetBL.UpdateBySql2(objQuestionnaireSetEN);
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
 bolIsExist = clsQuestionnaireSetDA.IsExistTable();
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
 bolIsExist = QuestionnaireSetDA.IsExistTable(strTabName);
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
 /// <param name = "objQuestionnaireSetEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecordBySql2(clsQuestionnaireSetEN objQuestionnaireSetEN, bool bolIsNeedCheckUniqueness=true)
{
if (bolIsNeedCheckUniqueness == true && objQuestionnaireSetEN.CheckUniqueness() == false)
{
var strMsg = string.Format("记录已经存在!问卷集名 = [{0}]的数据已经存在!(in clsQuestionnaireSetBL.AddNewRecordBySql2)", objQuestionnaireSetEN.QuestionnaireSetName);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objQuestionnaireSetEN.QuestionnaireSetId) == true || clsQuestionnaireSetBL.IsExist(objQuestionnaireSetEN.QuestionnaireSetId) == true)
 {
     objQuestionnaireSetEN.QuestionnaireSetId = clsQuestionnaireSetBL.GetMaxStrId_S();
 }
bool bolResult = QuestionnaireSetDA.AddNewRecordBySQL2(objQuestionnaireSetEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsQuestionnaireSetBL.ReFreshCache();

if (clsQuestionnaireSetBL.relatedActions != null)
{
clsQuestionnaireSetBL.relatedActions.UpdRelaTabDate(objQuestionnaireSetEN.QuestionnaireSetId, objQuestionnaireSetEN.UpdUser);
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
 /// <param name = "objQuestionnaireSetEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordBySql2WithReturnKey(clsQuestionnaireSetEN objQuestionnaireSetEN, bool bolIsNeedCheckUniqueness=true)
{
if (bolIsNeedCheckUniqueness == true && objQuestionnaireSetEN.CheckUniqueness() == false)
{
var strMsg = string.Format("记录已经存在!问卷集名 = [{0}]的数据已经存在!(in clsQuestionnaireSetBL.AddNewRecordBySql2WithReturnKey)", objQuestionnaireSetEN.QuestionnaireSetName);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objQuestionnaireSetEN.QuestionnaireSetId) == true || clsQuestionnaireSetBL.IsExist(objQuestionnaireSetEN.QuestionnaireSetId) == true)
 {
     objQuestionnaireSetEN.QuestionnaireSetId = clsQuestionnaireSetBL.GetMaxStrId_S();
 }
string strKey = QuestionnaireSetDA.AddNewRecordBySQL2WithReturnKey(objQuestionnaireSetEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsQuestionnaireSetBL.ReFreshCache();

if (clsQuestionnaireSetBL.relatedActions != null)
{
clsQuestionnaireSetBL.relatedActions.UpdRelaTabDate(objQuestionnaireSetEN.QuestionnaireSetId, objQuestionnaireSetEN.UpdUser);
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
 /// <param name = "objQuestionnaireSetEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(clsQuestionnaireSetEN objQuestionnaireSetEN)
{
try
{
bool bolResult = QuestionnaireSetDA.Update(objQuestionnaireSetEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsQuestionnaireSetBL.ReFreshCache();

if (clsQuestionnaireSetBL.relatedActions != null)
{
clsQuestionnaireSetBL.relatedActions.UpdRelaTabDate(objQuestionnaireSetEN.QuestionnaireSetId, objQuestionnaireSetEN.UpdUser);
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
 /// <param name = "objQuestionnaireSetEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateBySql2(clsQuestionnaireSetEN objQuestionnaireSetEN)
{
 if (string.IsNullOrEmpty(objQuestionnaireSetEN.QuestionnaireSetId) == true)
 {
var strMsg = string.Format("(errid:Busi000065)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = QuestionnaireSetDA.UpdateBySql2(objQuestionnaireSetEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsQuestionnaireSetBL.ReFreshCache();

if (clsQuestionnaireSetBL.relatedActions != null)
{
clsQuestionnaireSetBL.relatedActions.UpdRelaTabDate(objQuestionnaireSetEN.QuestionnaireSetId, objQuestionnaireSetEN.UpdUser);
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
 /// <param name = "strQuestionnaireSetId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int DelRecord(string strQuestionnaireSetId)
{
try
{
 clsQuestionnaireSetEN objQuestionnaireSetEN = clsQuestionnaireSetBL.GetObjByQuestionnaireSetId(strQuestionnaireSetId);

if (clsQuestionnaireSetBL.relatedActions != null)
{
clsQuestionnaireSetBL.relatedActions.UpdRelaTabDate(objQuestionnaireSetEN.QuestionnaireSetId, objQuestionnaireSetEN.UpdUser);
}
if (objQuestionnaireSetEN != null)
{
int intRecNum = QuestionnaireSetDA.DelRecord(strQuestionnaireSetId);
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
/// <param name="strQuestionnaireSetId">表关键字</param>
/// <returns></returns>
public static bool DelRecordEx(string strQuestionnaireSetId )
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsQuestionnaireSetDA.GetSpecSQLObj();
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
//删除与表:[QuestionnaireSet]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conQuestionnaireSet.QuestionnaireSetId,
//strQuestionnaireSetId);
//        clsQuestionnaireSetBL.DelQuestionnaireSetsByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsQuestionnaireSetBL.DelRecord(strQuestionnaireSetId, objConnection, objSqlTransaction);
objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsQuestionnaireSetBLEx", "DelRecordEx", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("扩展删除记录出错:{0}!keyId = {1}.({2})",
objException.Message,
strQuestionnaireSetId, clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "strQuestionnaireSetId">给定的关键字值</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回删除是否成功?</returns>
public static bool DelRecord(string strQuestionnaireSetId, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
if (clsQuestionnaireSetBL.relatedActions != null)
{
clsQuestionnaireSetBL.relatedActions.UpdRelaTabDate(strQuestionnaireSetId, "UpdRelaTabDate");
}
bool bolResult = QuestionnaireSetDA.DelRecord(strQuestionnaireSetId,objSqlConnection,objSqlTransaction);
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
 /// <param name = "arrQuestionnaireSetIdLst">给定的关键字值列表</param>
 /// <returns>返回删除的记录数</returns>
public static int DelQuestionnaireSets(List<string> arrQuestionnaireSetIdLst)
{
if (arrQuestionnaireSetIdLst.Count == 0) return 0;
try
{
if (clsQuestionnaireSetBL.relatedActions != null)
{
foreach (var strQuestionnaireSetId in arrQuestionnaireSetIdLst)
{
clsQuestionnaireSetBL.relatedActions.UpdRelaTabDate(strQuestionnaireSetId, "UpdRelaTabDate");
}
}
int intDelRecNum = QuestionnaireSetDA.DelQuestionnaireSet(arrQuestionnaireSetIdLst);
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
public static int DelQuestionnaireSetsByCond(string strWhereCond)
{
try
{
if (clsQuestionnaireSetBL.relatedActions != null)
{
List<string> arrQuestionnaireSetId = GetPrimaryKeyID_S(strWhereCond);
foreach (var strQuestionnaireSetId in arrQuestionnaireSetId)
{
clsQuestionnaireSetBL.relatedActions.UpdRelaTabDate(strQuestionnaireSetId, "UpdRelaTabDate");
}
}
int intRecNum = QuestionnaireSetDA.DelQuestionnaireSet(strWhereCond);
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
/// 这里仅仅是演示函数,使用时请复制到扩展类:[QuestionnaireSet]中改名为:[DelRecord4MultiTabEx]使用
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DelRecord4MultiTab)
/// </summary>
/// <param name="strQuestionnaireSetId">表关键字</param>
/// <returns></returns>
public static bool DelRecord4MultiTab(string strQuestionnaireSetId)
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsQuestionnaireSetDA.GetSpecSQLObj();
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
//删除与表:[QuestionnaireSet]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conStudent.id_College,
//strid_College);
//        clsStudentBL.DelStudentsByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsQuestionnaireSetBL.DelRecord(strQuestionnaireSetId, objConnection, objSqlTransaction);
                objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsQuestionnaireSetBL", "DelRecord4MultiTab", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("删除多表记录出错:{0}!keyId = {1}.({2})",
objException.Message,
strQuestionnaireSetId, clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "objQuestionnaireSetENS">源对象</param>
 /// <param name = "objQuestionnaireSetENT">目标对象</param>
 public static void CopyTo(clsQuestionnaireSetEN objQuestionnaireSetENS, clsQuestionnaireSetEN objQuestionnaireSetENT)
{
try
{
objQuestionnaireSetENT.QuestionnaireSetId = objQuestionnaireSetENS.QuestionnaireSetId; //问卷集ID
objQuestionnaireSetENT.QuestionnaireSetName = objQuestionnaireSetENS.QuestionnaireSetName; //问卷集名
objQuestionnaireSetENT.OrderFieldInExport = objQuestionnaireSetENS.OrderFieldInExport; //导出排序字段
objQuestionnaireSetENT.ClassNo = objQuestionnaireSetENS.ClassNo; //分类号1
objQuestionnaireSetENT.ClassNo2 = objQuestionnaireSetENS.ClassNo2; //分类号2
objQuestionnaireSetENT.IsShowQuestionNo = objQuestionnaireSetENS.IsShowQuestionNo; //是否显示问题编号
objQuestionnaireSetENT.LogoFileName = objQuestionnaireSetENS.LogoFileName; //Logo文件名
objQuestionnaireSetENT.UpdDate = objQuestionnaireSetENS.UpdDate; //修改日期
objQuestionnaireSetENT.UpdUser = objQuestionnaireSetENS.UpdUser; //修改人
objQuestionnaireSetENT.Memo = objQuestionnaireSetENS.Memo; //备注
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
 /// <param name = "objQuestionnaireSetEN">源简化对象</param>
 public static void SetUpdFlag(clsQuestionnaireSetEN objQuestionnaireSetEN)
{
try
{
objQuestionnaireSetEN.ClearUpdateState();
   string strsfUpdFldSetStr = objQuestionnaireSetEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(conQuestionnaireSet.QuestionnaireSetId, new clsStrCompareIgnoreCase())  ==  true)
{
objQuestionnaireSetEN.QuestionnaireSetId = objQuestionnaireSetEN.QuestionnaireSetId; //问卷集ID
}
if (arrFldSet.Contains(conQuestionnaireSet.QuestionnaireSetName, new clsStrCompareIgnoreCase())  ==  true)
{
objQuestionnaireSetEN.QuestionnaireSetName = objQuestionnaireSetEN.QuestionnaireSetName; //问卷集名
}
if (arrFldSet.Contains(conQuestionnaireSet.OrderFieldInExport, new clsStrCompareIgnoreCase())  ==  true)
{
objQuestionnaireSetEN.OrderFieldInExport = objQuestionnaireSetEN.OrderFieldInExport == "[null]" ? null :  objQuestionnaireSetEN.OrderFieldInExport; //导出排序字段
}
if (arrFldSet.Contains(conQuestionnaireSet.ClassNo, new clsStrCompareIgnoreCase())  ==  true)
{
objQuestionnaireSetEN.ClassNo = objQuestionnaireSetEN.ClassNo; //分类号1
}
if (arrFldSet.Contains(conQuestionnaireSet.ClassNo2, new clsStrCompareIgnoreCase())  ==  true)
{
objQuestionnaireSetEN.ClassNo2 = objQuestionnaireSetEN.ClassNo2; //分类号2
}
if (arrFldSet.Contains(conQuestionnaireSet.IsShowQuestionNo, new clsStrCompareIgnoreCase())  ==  true)
{
objQuestionnaireSetEN.IsShowQuestionNo = objQuestionnaireSetEN.IsShowQuestionNo; //是否显示问题编号
}
if (arrFldSet.Contains(conQuestionnaireSet.LogoFileName, new clsStrCompareIgnoreCase())  ==  true)
{
objQuestionnaireSetEN.LogoFileName = objQuestionnaireSetEN.LogoFileName == "[null]" ? null :  objQuestionnaireSetEN.LogoFileName; //Logo文件名
}
if (arrFldSet.Contains(conQuestionnaireSet.UpdDate, new clsStrCompareIgnoreCase())  ==  true)
{
objQuestionnaireSetEN.UpdDate = objQuestionnaireSetEN.UpdDate; //修改日期
}
if (arrFldSet.Contains(conQuestionnaireSet.UpdUser, new clsStrCompareIgnoreCase())  ==  true)
{
objQuestionnaireSetEN.UpdUser = objQuestionnaireSetEN.UpdUser; //修改人
}
if (arrFldSet.Contains(conQuestionnaireSet.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objQuestionnaireSetEN.Memo = objQuestionnaireSetEN.Memo == "[null]" ? null :  objQuestionnaireSetEN.Memo; //备注
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
 /// <param name = "objQuestionnaireSetEN">源简化对象</param>
 public static void AccessFldValueNull(clsQuestionnaireSetEN objQuestionnaireSetEN)
{
try
{
if (objQuestionnaireSetEN.OrderFieldInExport == "[null]") objQuestionnaireSetEN.OrderFieldInExport = null; //导出排序字段
if (objQuestionnaireSetEN.LogoFileName == "[null]") objQuestionnaireSetEN.LogoFileName = null; //Logo文件名
if (objQuestionnaireSetEN.Memo == "[null]") objQuestionnaireSetEN.Memo = null; //备注
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
public static void CheckPropertyNew(clsQuestionnaireSetEN objQuestionnaireSetEN)
{
 QuestionnaireSetDA.CheckPropertyNew(objQuestionnaireSetEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(clsQuestionnaireSetEN objQuestionnaireSetEN)
{
 QuestionnaireSetDA.CheckProperty4Condition(objQuestionnaireSetEN);
 }


 #endregion 检查对象属性


 #region 绑定下拉框

 /// <summary>
 /// 绑定基于Web的下拉框-使用Cache
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DdlBindFunctionCache)
 /// </summary>
 /// <param name = "objDDL">需要绑定当前表的下拉框</param>
public static void BindDdl_QuestionnaireSetIdCache(System.Web.UI.WebControls.DropDownList objDDL)
{
//为数据源于表的下拉框设置内容
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[问卷集]...","0");
List<clsQuestionnaireSetEN> arrQuestionnaireSetObjLst = GetAllQuestionnaireSetObjLstCache(); 
objDDL.DataValueField = conQuestionnaireSet.QuestionnaireSetId;
objDDL.DataTextField = conQuestionnaireSet.QuestionnaireSetName;
objDDL.DataSource = arrQuestionnaireSetObjLst;
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
if (clsQuestionnaireSetBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsQuestionnaireSetBL没有刷新缓存机制(clsQuestionnaireSetBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by QuestionnaireSetId");
//if (arrQuestionnaireSetObjLstCache == null)
//{
//arrQuestionnaireSetObjLstCache = QuestionnaireSetDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "strQuestionnaireSetId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsQuestionnaireSetEN GetObjByQuestionnaireSetIdCache(string strQuestionnaireSetId)
{
//获取缓存中的对象列表
string strKey = string.Format("{0}", clsQuestionnaireSetEN._CurrTabName);
List<clsQuestionnaireSetEN> arrQuestionnaireSetObjLstCache = GetObjLstCache();
IEnumerable <clsQuestionnaireSetEN> arrQuestionnaireSetObjLst_Sel =
arrQuestionnaireSetObjLstCache
.Where(x=> x.QuestionnaireSetId == strQuestionnaireSetId 
);
if (arrQuestionnaireSetObjLst_Sel.Count() == 0)
{
   clsQuestionnaireSetEN obj = clsQuestionnaireSetBL.GetObjByQuestionnaireSetId(strQuestionnaireSetId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
 }
return null;
}
return arrQuestionnaireSetObjLst_Sel.First();
}

 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecNameByKeyCache)
 /// </summary>
 /// <param name = "strQuestionnaireSetId">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetQuestionnaireSetNameByQuestionnaireSetIdCache(string strQuestionnaireSetId)
{
if (string.IsNullOrEmpty(strQuestionnaireSetId) == true) return "";
//获取缓存中的对象列表
clsQuestionnaireSetEN objQuestionnaireSet = GetObjByQuestionnaireSetIdCache(strQuestionnaireSetId);
if (objQuestionnaireSet == null) return "";
return objQuestionnaireSet.QuestionnaireSetName;
}
 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecNameByKeyCache)
 /// </summary>
 /// <param name = "strQuestionnaireSetId">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetNameByQuestionnaireSetIdCache(string strQuestionnaireSetId)
{
if (string.IsNullOrEmpty(strQuestionnaireSetId) == true) return "";
//获取缓存中的对象列表
clsQuestionnaireSetEN objQuestionnaireSet = GetObjByQuestionnaireSetIdCache(strQuestionnaireSetId);
if (objQuestionnaireSet == null) return "";
return objQuestionnaireSet.QuestionnaireSetName;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsQuestionnaireSetEN> GetAllQuestionnaireSetObjLstCache()
{
//获取缓存中的对象列表
List<clsQuestionnaireSetEN> arrQuestionnaireSetObjLstCache = GetObjLstCache(); 
return arrQuestionnaireSetObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsQuestionnaireSetEN> GetObjLstCache()
{
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}", clsQuestionnaireSetEN._CurrTabName);
List<clsQuestionnaireSetEN> arrQuestionnaireSetObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrQuestionnaireSetObjLstCache;
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
string strKey = string.Format("{0}", clsQuestionnaireSetEN._CurrTabName);
CacheHelper.Remove(strKey);
clsQuestionnaireSetEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
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
if (clsQuestionnaireSetEN._RefreshTimeLst.Count == 0) return "";
return clsQuestionnaireSetEN._RefreshTimeLst[clsQuestionnaireSetEN._RefreshTimeLst.Count - 1];
}

 /// <summary>
 /// 刷新缓存.把当前表的缓存以及该表相关视图的缓存清空.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ReFreshCache)
 /// </summary>
public static void ReFreshCache()
{
if (clsQuestionnaireSetBL.objCommFun4BL != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}", clsQuestionnaireSetEN._CurrTabName);
CacheHelper.Remove(strKey);
clsQuestionnaireSetEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
clsQuestionnaireSetBL.objCommFun4BL.ReFreshCache();
}
}


 #endregion 缓存操作


 #region 检查唯一性

 /// <summary>
 /// 获取检查唯一性条件串(Uniqueness)--QuestionnaireSet(问卷集)
 /// 唯一性条件:QuestionnaireSetName
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetUniquenessConditionString)
 /// </summary>
 /// <param name = "objQuestionnaireSetEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(clsQuestionnaireSetEN objQuestionnaireSetEN)
{
//检测记录是否存在
string strResult = QuestionnaireSetDA.GetUniCondStr(objQuestionnaireSetEN);
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
public static string Func(string strInFldName, string strOutFldName, string strQuestionnaireSetId)
{
if (strInFldName != conQuestionnaireSet.QuestionnaireSetId)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (conQuestionnaireSet.AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", conQuestionnaireSet.AttributeName));
throw new Exception(strMsg);
}
var objQuestionnaireSet = clsQuestionnaireSetBL.GetObjByQuestionnaireSetIdCache(strQuestionnaireSetId);
if (objQuestionnaireSet == null) return "";
return objQuestionnaireSet[strOutFldName].ToString();
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
int intRecCount = clsQuestionnaireSetDA.GetRecCount(strTabName);
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
int intRecCount = clsQuestionnaireSetDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsQuestionnaireSetDA.GetRecCount();
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
int intRecCount = clsQuestionnaireSetDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objQuestionnaireSetCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsQuestionnaireSetEN objQuestionnaireSetCond)
{
List<clsQuestionnaireSetEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsQuestionnaireSetEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conQuestionnaireSet.AttributeName)
{
if (objQuestionnaireSetCond.IsUpdated(strFldName) == false) continue;
if (objQuestionnaireSetCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objQuestionnaireSetCond[strFldName].ToString());
}
else
{
if (objQuestionnaireSetCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objQuestionnaireSetCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objQuestionnaireSetCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objQuestionnaireSetCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objQuestionnaireSetCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objQuestionnaireSetCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objQuestionnaireSetCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objQuestionnaireSetCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objQuestionnaireSetCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objQuestionnaireSetCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objQuestionnaireSetCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objQuestionnaireSetCond[strFldName]));
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
 List<string> arrList = clsQuestionnaireSetDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = QuestionnaireSetDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = QuestionnaireSetDA.GetFldValueNoDistinct(strFldName, strWhereCond);
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
int intRecCount = QuestionnaireSetDA.SetFldValue(strFldName, strValue, strWhereCond);
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
int intRecCount = clsQuestionnaireSetDA.SetFldValue(clsQuestionnaireSetEN._CurrTabName, strFldName, fltValue, strWhereCond);
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
int intRecCount = QuestionnaireSetDA.SetFldValue( strFldName, intValue, strWhereCond);
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
int intRecCount = clsQuestionnaireSetDA.SetFldValue(strTabName, strFldName, strValue, strWhereCond);
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
int intRecCount = clsQuestionnaireSetDA.SetFldValue(strTabName, strFldName, intValue, strWhereCond);
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
int intRecCount = clsQuestionnaireSetDA.SetFldValue(strTabName, strFldName, fltValue, strWhereCond);
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
  strCreateTabCode.Append("CREATE table [dbo].[QuestionnaireSet] "); 
 strCreateTabCode.Append(" ( "); 
 // /**问卷集ID*/ 
 strCreateTabCode.Append(" QuestionnaireSetId char(4) primary key, "); 
 // /**问卷集名*/ 
 strCreateTabCode.Append(" QuestionnaireSetName varchar(50) not Null, "); 
 // /**导出排序字段*/ 
 strCreateTabCode.Append(" OrderFieldInExport varchar(200) Null, "); 
 // /**分类号1*/ 
 strCreateTabCode.Append(" ClassNo int Null, "); 
 // /**分类号2*/ 
 strCreateTabCode.Append(" ClassNo2 int Null, "); 
 // /**是否显示问题编号*/ 
 strCreateTabCode.Append(" IsShowQuestionNo bit not Null, "); 
 // /**Logo文件名*/ 
 strCreateTabCode.Append(" LogoFileName varchar(50) Null, "); 
 // /**修改日期*/ 
 strCreateTabCode.Append(" UpdDate varchar(20) not Null, "); 
 // /**修改人*/ 
 strCreateTabCode.Append(" UpdUser varchar(20) not Null, "); 
 // /**备注*/ 
 strCreateTabCode.Append(" Memo varchar(1000) Null ");
 strCreateTabCode.Append(") "); 
  strCreateTabCode.Append("ON [PRIMARY] ");
  return strCreateTabCode.ToString();
}



 #endregion 表操作
}
 /// <summary>
 /// 问卷集(QuestionnaireSet)
 /// 数据源类型:表
 /// (AutoGCLib.CommFun4BL4CSharp:GeneCode_This)
 /// </summary>
public class  clsCommFun4BL4QuestionnaireSet : clsCommFun4BL
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
clsQuestionnaireSetBL.ReFreshThisCache();
}
}

}