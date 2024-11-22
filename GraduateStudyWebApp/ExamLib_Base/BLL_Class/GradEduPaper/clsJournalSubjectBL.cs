
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsJournalSubjectBL
 表名:JournalSubject(01120930)
 * 版本:2024.11.13.1(服务器:WIN-SRV103-116)
 日期:2024/11/13 06:14:42
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:研究生学习游戏化后台(000055, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:研培论文(GradEduPaper)
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
public static class  clsJournalSubjectBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "strJournalSubjectId">表关键字</param>
 /// <returns>表对象</returns>
public static clsJournalSubjectEN GetObj(this K_JournalSubjectId_JournalSubject myKey)
{
clsJournalSubjectEN objJournalSubjectEN = clsJournalSubjectBL.JournalSubjectDA.GetObjByJournalSubjectId(myKey.Value);
return objJournalSubjectEN;
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_AddNewRecord)
 /// </summary>
 /// <param name = "objJournalSubjectEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clsJournalSubjectEN objJournalSubjectEN, bool bolIsNeedCheckUniqueness = true)
{
if (bolIsNeedCheckUniqueness == true && CheckUniqueness(objJournalSubjectEN) == false)
{
var strMsg = string.Format("记录已经存在!期刊学科门类Id = [{0}],期刊学科名称 = [{1}]的数据已经存在!(in clsJournalSubjectBL.AddNewRecord)", objJournalSubjectEN.JournalSubjectCategoryId,objJournalSubjectEN.JournalSubjectName);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objJournalSubjectEN.JournalSubjectId) == true || clsJournalSubjectBL.IsExist(objJournalSubjectEN.JournalSubjectId) == true)
 {
     objJournalSubjectEN.JournalSubjectId = clsJournalSubjectBL.GetMaxStrId_S();
 }
bool bolResult = clsJournalSubjectBL.JournalSubjectDA.AddNewRecordBySQL2(objJournalSubjectEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsJournalSubjectBL.ReFreshCache();

if (clsJournalSubjectBL.relatedActions != null)
{
clsJournalSubjectBL.relatedActions.UpdRelaTabDate(objJournalSubjectEN.JournalSubjectId, "SetUpdDate");
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
public static bool AddRecordEx(this clsJournalSubjectEN objJournalSubjectEN, bool bolIsNeedCheckUniqueness = true)
{
//操作步骤:
//1、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在
//2、检查唯一性
//3、检查传进去的对象属性是否合法
//4、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
//1、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在

//因为是字符型自增主键,不需要检查主键是否已经存在,在添加时,再获取 最大值作为主键
//if (clsJournalSubjectBL.IsExist(objJournalSubjectEN.JournalSubjectId))	//判断是否有相同的关键字
//{
//strMsg = "(errid:Busi000151)关键字字段已有相同的值";
//throw new Exception(strMsg);
//}
try
{
 //2、检查传进去的对象属性是否合法
objJournalSubjectEN.CheckPropertyNew();
 ///5.2、检查唯一性
if (bolIsNeedCheckUniqueness == true && objJournalSubjectEN.CheckUniqueness() == false)
{
strMsg = string.Format("(期刊学科门类Id(JournalSubjectCategoryId)=[{0}],期刊学科名称(JournalSubjectName)=[{1}])已经存在,不能重复!", objJournalSubjectEN.JournalSubjectCategoryId, objJournalSubjectEN.JournalSubjectName);
throw new Exception(strMsg);
}
//因为是字符型自增主键,所以在添加时,自动获取主键值。
 if (string.IsNullOrEmpty(objJournalSubjectEN.JournalSubjectId) == true || clsJournalSubjectBL.IsExist(objJournalSubjectEN.JournalSubjectId) == true)
 {
     objJournalSubjectEN.JournalSubjectId = clsJournalSubjectBL.GetMaxStrId_S();
 }
//6、把数据实体层的数据存贮到数据库中
objJournalSubjectEN.AddNewRecord();
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
 /// <param name = "objJournalSubjectEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static string AddNewRecordWithMaxId(this clsJournalSubjectEN objJournalSubjectEN, bool bolIsNeedCheckUniqueness = true)
{
if (bolIsNeedCheckUniqueness == true && CheckUniqueness(objJournalSubjectEN) == false)
{
var strMsg = string.Format("记录已经存在!期刊学科门类Id = [{0}],期刊学科名称 = [{1}]的数据已经存在!(in clsJournalSubjectBL.AddNewRecordWithMaxId)", objJournalSubjectEN.JournalSubjectCategoryId,objJournalSubjectEN.JournalSubjectName);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objJournalSubjectEN.JournalSubjectId) == true || clsJournalSubjectBL.IsExist(objJournalSubjectEN.JournalSubjectId) == true)
 {
     objJournalSubjectEN.JournalSubjectId = clsJournalSubjectBL.GetMaxStrId_S();
 }
string strJournalSubjectId = clsJournalSubjectBL.JournalSubjectDA.AddNewRecordBySQL2WithReturnKey(objJournalSubjectEN);
     objJournalSubjectEN.JournalSubjectId = strJournalSubjectId;
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsJournalSubjectBL.ReFreshCache();

if (clsJournalSubjectBL.relatedActions != null)
{
clsJournalSubjectBL.relatedActions.UpdRelaTabDate(objJournalSubjectEN.JournalSubjectId, "SetUpdDate");
}
return strJournalSubjectId;
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
 /// <param name = "objJournalSubjectEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordWithReturnKey(this clsJournalSubjectEN objJournalSubjectEN, bool bolIsNeedCheckUniqueness = true)
{
if (bolIsNeedCheckUniqueness == true && CheckUniqueness(objJournalSubjectEN) == false)
{
var strMsg = string.Format("记录已经存在!期刊学科门类Id = [{0}],期刊学科名称 = [{1}]的数据已经存在!(in clsJournalSubjectBL.AddNewRecordWithReturnKey)", objJournalSubjectEN.JournalSubjectCategoryId,objJournalSubjectEN.JournalSubjectName);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objJournalSubjectEN.JournalSubjectId) == true || clsJournalSubjectBL.IsExist(objJournalSubjectEN.JournalSubjectId) == true)
 {
     objJournalSubjectEN.JournalSubjectId = clsJournalSubjectBL.GetMaxStrId_S();
 }
string strKey = clsJournalSubjectBL.JournalSubjectDA.AddNewRecordBySQL2WithReturnKey(objJournalSubjectEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsJournalSubjectBL.ReFreshCache();

if (clsJournalSubjectBL.relatedActions != null)
{
clsJournalSubjectBL.relatedActions.UpdRelaTabDate(objJournalSubjectEN.JournalSubjectId, "SetUpdDate");
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
 /// <param name = "objJournalSubjectEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsJournalSubjectEN SetJournalSubjectId(this clsJournalSubjectEN objJournalSubjectEN, string strJournalSubjectId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strJournalSubjectId, 4, conJournalSubject.JournalSubjectId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strJournalSubjectId, 4, conJournalSubject.JournalSubjectId);
}
objJournalSubjectEN.JournalSubjectId = strJournalSubjectId; //期刊学科Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objJournalSubjectEN.dicFldComparisonOp.ContainsKey(conJournalSubject.JournalSubjectId) == false)
{
objJournalSubjectEN.dicFldComparisonOp.Add(conJournalSubject.JournalSubjectId, strComparisonOp);
}
else
{
objJournalSubjectEN.dicFldComparisonOp[conJournalSubject.JournalSubjectId] = strComparisonOp;
}
}
return objJournalSubjectEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objJournalSubjectEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsJournalSubjectEN SetJournalSubjectCode(this clsJournalSubjectEN objJournalSubjectEN, string strJournalSubjectCode, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strJournalSubjectCode, conJournalSubject.JournalSubjectCode);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strJournalSubjectCode, 100, conJournalSubject.JournalSubjectCode);
}
objJournalSubjectEN.JournalSubjectCode = strJournalSubjectCode; //期刊学科代码
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objJournalSubjectEN.dicFldComparisonOp.ContainsKey(conJournalSubject.JournalSubjectCode) == false)
{
objJournalSubjectEN.dicFldComparisonOp.Add(conJournalSubject.JournalSubjectCode, strComparisonOp);
}
else
{
objJournalSubjectEN.dicFldComparisonOp[conJournalSubject.JournalSubjectCode] = strComparisonOp;
}
}
return objJournalSubjectEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objJournalSubjectEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsJournalSubjectEN SetJournalSubjectName(this clsJournalSubjectEN objJournalSubjectEN, string strJournalSubjectName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strJournalSubjectName, conJournalSubject.JournalSubjectName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strJournalSubjectName, 100, conJournalSubject.JournalSubjectName);
}
objJournalSubjectEN.JournalSubjectName = strJournalSubjectName; //期刊学科名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objJournalSubjectEN.dicFldComparisonOp.ContainsKey(conJournalSubject.JournalSubjectName) == false)
{
objJournalSubjectEN.dicFldComparisonOp.Add(conJournalSubject.JournalSubjectName, strComparisonOp);
}
else
{
objJournalSubjectEN.dicFldComparisonOp[conJournalSubject.JournalSubjectName] = strComparisonOp;
}
}
return objJournalSubjectEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objJournalSubjectEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsJournalSubjectEN SetJournalSubjectCategoryId(this clsJournalSubjectEN objJournalSubjectEN, string strJournalSubjectCategoryId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strJournalSubjectCategoryId, conJournalSubject.JournalSubjectCategoryId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strJournalSubjectCategoryId, 4, conJournalSubject.JournalSubjectCategoryId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strJournalSubjectCategoryId, 4, conJournalSubject.JournalSubjectCategoryId);
}
objJournalSubjectEN.JournalSubjectCategoryId = strJournalSubjectCategoryId; //期刊学科门类Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objJournalSubjectEN.dicFldComparisonOp.ContainsKey(conJournalSubject.JournalSubjectCategoryId) == false)
{
objJournalSubjectEN.dicFldComparisonOp.Add(conJournalSubject.JournalSubjectCategoryId, strComparisonOp);
}
else
{
objJournalSubjectEN.dicFldComparisonOp[conJournalSubject.JournalSubjectCategoryId] = strComparisonOp;
}
}
return objJournalSubjectEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objJournalSubjectEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsJournalSubjectEN SetUpdDate(this clsJournalSubjectEN objJournalSubjectEN, string strUpdDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdDate, 20, conJournalSubject.UpdDate);
}
objJournalSubjectEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objJournalSubjectEN.dicFldComparisonOp.ContainsKey(conJournalSubject.UpdDate) == false)
{
objJournalSubjectEN.dicFldComparisonOp.Add(conJournalSubject.UpdDate, strComparisonOp);
}
else
{
objJournalSubjectEN.dicFldComparisonOp[conJournalSubject.UpdDate] = strComparisonOp;
}
}
return objJournalSubjectEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objJournalSubjectEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsJournalSubjectEN SetUpdUser(this clsJournalSubjectEN objJournalSubjectEN, string strUpdUser, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdUser, 20, conJournalSubject.UpdUser);
}
objJournalSubjectEN.UpdUser = strUpdUser; //修改人
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objJournalSubjectEN.dicFldComparisonOp.ContainsKey(conJournalSubject.UpdUser) == false)
{
objJournalSubjectEN.dicFldComparisonOp.Add(conJournalSubject.UpdUser, strComparisonOp);
}
else
{
objJournalSubjectEN.dicFldComparisonOp[conJournalSubject.UpdUser] = strComparisonOp;
}
}
return objJournalSubjectEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objJournalSubjectEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsJournalSubjectEN SetMemo(this clsJournalSubjectEN objJournalSubjectEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, conJournalSubject.Memo);
}
objJournalSubjectEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objJournalSubjectEN.dicFldComparisonOp.ContainsKey(conJournalSubject.Memo) == false)
{
objJournalSubjectEN.dicFldComparisonOp.Add(conJournalSubject.Memo, strComparisonOp);
}
else
{
objJournalSubjectEN.dicFldComparisonOp[conJournalSubject.Memo] = strComparisonOp;
}
}
return objJournalSubjectEN;
	}

 /// <summary>
 /// 修改记录存盘到数据表中
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_UpdateRecordEx)
 /// </summary>
 /// <param name = "objJournalSubjectEN">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool UpdateRecordEx(this clsJournalSubjectEN objJournalSubjectEN)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
try
{
//1、检查传进去的对象属性是否合法
objJournalSubjectEN.CheckPropertyNew();
clsJournalSubjectEN objJournalSubjectCond = new clsJournalSubjectEN();
string strCondition = objJournalSubjectCond
.SetJournalSubjectId(objJournalSubjectEN.JournalSubjectId, "<>")
.SetJournalSubjectCategoryId(objJournalSubjectEN.JournalSubjectCategoryId, "=")
.SetJournalSubjectName(objJournalSubjectEN.JournalSubjectName, "=")
.GetCombineCondition();
objJournalSubjectEN._IsCheckProperty = true;
bool bolIsExist = clsJournalSubjectBL.IsExistRecord(strCondition);
if (bolIsExist)
{
strMsg = "(JournalSubjectCategoryId_JournalSubjectName)不能重复!";
throw new Exception(strMsg);
}
//4、把数据实体层的数据存贮到数据库中
objJournalSubjectEN.Update();
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
 /// <param name = "objJournalSubject">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool EditRecordEx(this clsJournalSubjectEN objJournalSubject)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
clsJournalSubjectEN objJournalSubjectCond = new clsJournalSubjectEN();
string strCondition = objJournalSubjectCond
.SetJournalSubjectCategoryId(objJournalSubject.JournalSubjectCategoryId, "=")
.SetJournalSubjectName(objJournalSubject.JournalSubjectName, "=")
.GetCombineCondition();
objJournalSubject._IsCheckProperty = true;
bool bolIsExist = clsJournalSubjectBL.IsExistRecord(strCondition);
if (bolIsExist)
{
objJournalSubject.JournalSubjectId = clsJournalSubjectBL.GetFirstID_S(strCondition);
objJournalSubject.UpdateWithCondition(strCondition);
}
else
{
objJournalSubject.JournalSubjectId = clsJournalSubjectBL.GetMaxStrId_S();
objJournalSubject.AddNewRecord();
}
return true; 
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_Update)
 /// </summary>
 /// <param name = "objJournalSubjectEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsJournalSubjectEN objJournalSubjectEN)
{
 if (string.IsNullOrEmpty(objJournalSubjectEN.JournalSubjectId) == true)
 {
string strMsg = string.Format("(errid:Busi000095)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsJournalSubjectBL.JournalSubjectDA.UpdateBySql2(objJournalSubjectEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsJournalSubjectBL.ReFreshCache();

if (clsJournalSubjectBL.relatedActions != null)
{
clsJournalSubjectBL.relatedActions.UpdRelaTabDate(objJournalSubjectEN.JournalSubjectId, "SetUpdDate");
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
 /// <param name = "objJournalSubjectEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsJournalSubjectEN objJournalSubjectEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (string.IsNullOrEmpty(objJournalSubjectEN.JournalSubjectId) == true)
 {
string strMsg = string.Format("(errid:Busi000087)修改记录时关键字不能为空!(带事务处理)(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsJournalSubjectBL.JournalSubjectDA.UpdateBySql2(objJournalSubjectEN, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsJournalSubjectBL.ReFreshCache();

if (clsJournalSubjectBL.relatedActions != null)
{
clsJournalSubjectBL.relatedActions.UpdRelaTabDate(objJournalSubjectEN.JournalSubjectId, "SetUpdDate");
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
 /// <param name = "objJournalSubjectEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsJournalSubjectEN objJournalSubjectEN, string strWhereCond)
{
try
{
bool bolResult = clsJournalSubjectBL.JournalSubjectDA.UpdateBySqlWithCondition(objJournalSubjectEN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsJournalSubjectBL.ReFreshCache();

if (clsJournalSubjectBL.relatedActions != null)
{
clsJournalSubjectBL.relatedActions.UpdRelaTabDate(objJournalSubjectEN.JournalSubjectId, "SetUpdDate");
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
 /// <param name = "objJournalSubjectEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsJournalSubjectEN objJournalSubjectEN, string strWhereCond, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
bool bolResult = clsJournalSubjectBL.JournalSubjectDA.UpdateBySqlWithConditionTransaction(objJournalSubjectEN, strWhereCond, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsJournalSubjectBL.ReFreshCache();

if (clsJournalSubjectBL.relatedActions != null)
{
clsJournalSubjectBL.relatedActions.UpdRelaTabDate(objJournalSubjectEN.JournalSubjectId, "SetUpdDate");
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
 /// <param name = "strJournalSubjectId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int Delete(this clsJournalSubjectEN objJournalSubjectEN)
{
try
{
int intRecNum = clsJournalSubjectBL.JournalSubjectDA.DelRecord(objJournalSubjectEN.JournalSubjectId);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsJournalSubjectBL.ReFreshCache();

if (clsJournalSubjectBL.relatedActions != null)
{
clsJournalSubjectBL.relatedActions.UpdRelaTabDate(objJournalSubjectEN.JournalSubjectId, "SetUpdDate");
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
 /// <param name = "objJournalSubjectENS">源对象</param>
 /// <param name = "objJournalSubjectENT">目标对象</param>
 public static void CopyTo(this clsJournalSubjectEN objJournalSubjectENS, clsJournalSubjectEN objJournalSubjectENT)
{
try
{
objJournalSubjectENT.JournalSubjectId = objJournalSubjectENS.JournalSubjectId; //期刊学科Id
objJournalSubjectENT.JournalSubjectCode = objJournalSubjectENS.JournalSubjectCode; //期刊学科代码
objJournalSubjectENT.JournalSubjectName = objJournalSubjectENS.JournalSubjectName; //期刊学科名称
objJournalSubjectENT.JournalSubjectCategoryId = objJournalSubjectENS.JournalSubjectCategoryId; //期刊学科门类Id
objJournalSubjectENT.UpdDate = objJournalSubjectENS.UpdDate; //修改日期
objJournalSubjectENT.UpdUser = objJournalSubjectENS.UpdUser; //修改人
objJournalSubjectENT.Memo = objJournalSubjectENS.Memo; //备注
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
 /// <param name = "objJournalSubjectENS">源对象</param>
 /// <returns>目标对象=>clsJournalSubjectEN:objJournalSubjectENT</returns>
 public static clsJournalSubjectEN CopyTo(this clsJournalSubjectEN objJournalSubjectENS)
{
try
{
 clsJournalSubjectEN objJournalSubjectENT = new clsJournalSubjectEN()
{
JournalSubjectId = objJournalSubjectENS.JournalSubjectId, //期刊学科Id
JournalSubjectCode = objJournalSubjectENS.JournalSubjectCode, //期刊学科代码
JournalSubjectName = objJournalSubjectENS.JournalSubjectName, //期刊学科名称
JournalSubjectCategoryId = objJournalSubjectENS.JournalSubjectCategoryId, //期刊学科门类Id
UpdDate = objJournalSubjectENS.UpdDate, //修改日期
UpdUser = objJournalSubjectENS.UpdUser, //修改人
Memo = objJournalSubjectENS.Memo, //备注
};
 return objJournalSubjectENT;
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
public static void CheckPropertyNew(this clsJournalSubjectEN objJournalSubjectEN)
{
 clsJournalSubjectBL.JournalSubjectDA.CheckPropertyNew(objJournalSubjectEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(this clsJournalSubjectEN objJournalSubjectEN)
{
 clsJournalSubjectBL.JournalSubjectDA.CheckProperty4Condition(objJournalSubjectEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsJournalSubjectEN objJournalSubjectCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objJournalSubjectCond.IsUpdated(conJournalSubject.JournalSubjectId) == true)
{
string strComparisonOpJournalSubjectId = objJournalSubjectCond.dicFldComparisonOp[conJournalSubject.JournalSubjectId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conJournalSubject.JournalSubjectId, objJournalSubjectCond.JournalSubjectId, strComparisonOpJournalSubjectId);
}
if (objJournalSubjectCond.IsUpdated(conJournalSubject.JournalSubjectCode) == true)
{
string strComparisonOpJournalSubjectCode = objJournalSubjectCond.dicFldComparisonOp[conJournalSubject.JournalSubjectCode];
strWhereCond += string.Format(" And {0} {2} '{1}'", conJournalSubject.JournalSubjectCode, objJournalSubjectCond.JournalSubjectCode, strComparisonOpJournalSubjectCode);
}
if (objJournalSubjectCond.IsUpdated(conJournalSubject.JournalSubjectName) == true)
{
string strComparisonOpJournalSubjectName = objJournalSubjectCond.dicFldComparisonOp[conJournalSubject.JournalSubjectName];
strWhereCond += string.Format(" And {0} {2} '{1}'", conJournalSubject.JournalSubjectName, objJournalSubjectCond.JournalSubjectName, strComparisonOpJournalSubjectName);
}
if (objJournalSubjectCond.IsUpdated(conJournalSubject.JournalSubjectCategoryId) == true)
{
string strComparisonOpJournalSubjectCategoryId = objJournalSubjectCond.dicFldComparisonOp[conJournalSubject.JournalSubjectCategoryId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conJournalSubject.JournalSubjectCategoryId, objJournalSubjectCond.JournalSubjectCategoryId, strComparisonOpJournalSubjectCategoryId);
}
if (objJournalSubjectCond.IsUpdated(conJournalSubject.UpdDate) == true)
{
string strComparisonOpUpdDate = objJournalSubjectCond.dicFldComparisonOp[conJournalSubject.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conJournalSubject.UpdDate, objJournalSubjectCond.UpdDate, strComparisonOpUpdDate);
}
if (objJournalSubjectCond.IsUpdated(conJournalSubject.UpdUser) == true)
{
string strComparisonOpUpdUser = objJournalSubjectCond.dicFldComparisonOp[conJournalSubject.UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", conJournalSubject.UpdUser, objJournalSubjectCond.UpdUser, strComparisonOpUpdUser);
}
if (objJournalSubjectCond.IsUpdated(conJournalSubject.Memo) == true)
{
string strComparisonOpMemo = objJournalSubjectCond.dicFldComparisonOp[conJournalSubject.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", conJournalSubject.Memo, objJournalSubjectCond.Memo, strComparisonOpMemo);
}
 return strWhereCond;
}

 /// <summary>
 /// 检查唯一性(Uniqueness)--JournalSubject(期刊学科), 如果不唯一,即存在相同的记录,就返回False
 /// 唯一性条件:JournalSubjectCategoryId_JournalSubjectName
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckConstraint)
 /// </summary>
 /// <param name = "objJournalSubjectEN">要求唯一的对象</param>
 /// <returns></returns>
public static bool CheckUniqueness(this clsJournalSubjectEN objJournalSubjectEN)
{
//检测记录是否存在
bool bolIsUniqueness;
StringBuilder sbCondition = new StringBuilder();
if (objJournalSubjectEN == null) return true;
if (objJournalSubjectEN.JournalSubjectId == null || objJournalSubjectEN.JournalSubjectId == "")
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and JournalSubjectCategoryId = '{0}'", objJournalSubjectEN.JournalSubjectCategoryId);
 sbCondition.AppendFormat(" and JournalSubjectName = '{0}'", objJournalSubjectEN.JournalSubjectName);
if (clsJournalSubjectBL.IsExistRecord(sbCondition.ToString())  ==  true)
{
 bolIsUniqueness = false;
}
else
{
 bolIsUniqueness = true;
}
}
 else {
sbCondition.AppendFormat("JournalSubjectId !=  '{0}'", objJournalSubjectEN.JournalSubjectId);
 sbCondition.AppendFormat(" and JournalSubjectCategoryId = '{0}'", objJournalSubjectEN.JournalSubjectCategoryId);
 sbCondition.AppendFormat(" and JournalSubjectName = '{0}'", objJournalSubjectEN.JournalSubjectName);
if (clsJournalSubjectBL.IsExistRecord(sbCondition.ToString())  ==  true)
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
 /// 获取唯一性条件串--JournalSubject(期刊学科), 即由对象中唯一性条件字段关键字与值组成的条件串
 /// 唯一性条件:JournalSubjectCategoryId_JournalSubjectName
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetConditionString4Constraint)
 /// </summary>
 /// <param name = "objJournalSubjectEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(this clsJournalSubjectEN objJournalSubjectEN)
{
//检测记录是否存在
StringBuilder sbCondition = new StringBuilder();
if (objJournalSubjectEN == null) return "";
if (objJournalSubjectEN.JournalSubjectId == null || objJournalSubjectEN.JournalSubjectId == "")
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and JournalSubjectCategoryId = '{0}'", objJournalSubjectEN.JournalSubjectCategoryId);
 sbCondition.AppendFormat(" and JournalSubjectName = '{0}'", objJournalSubjectEN.JournalSubjectName);
return sbCondition.ToString();
}
 else {
sbCondition.AppendFormat("JournalSubjectId !=  '{0}'", objJournalSubjectEN.JournalSubjectId);
 sbCondition.AppendFormat(" and JournalSubjectCategoryId = '{0}'", objJournalSubjectEN.JournalSubjectCategoryId);
 sbCondition.AppendFormat(" and JournalSubjectName = '{0}'", objJournalSubjectEN.JournalSubjectName);
 return sbCondition.ToString();
}
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_JournalSubject
{
public virtual bool UpdRelaTabDate(string strJournalSubjectId, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// 期刊学科(JournalSubject)
 /// 数据源类型:表
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsJournalSubjectBL
{
public static RelatedActions_JournalSubject relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsJournalSubjectDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsJournalSubjectDA JournalSubjectDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsJournalSubjectDA();
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
 public clsJournalSubjectBL()
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
if (string.IsNullOrEmpty(clsJournalSubjectEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsJournalSubjectEN._ConnectString);
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
public static DataTable GetDataTable_JournalSubject(string strWhereCond)
{
DataTable objDT;
try
{
objDT = JournalSubjectDA.GetDataTable_JournalSubject(strWhereCond);
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
objDT = JournalSubjectDA.GetDataTable(strWhereCond);
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
objDT = JournalSubjectDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = JournalSubjectDA.GetDataTable(strWhereCond, strTabName);
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
objDT = JournalSubjectDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = JournalSubjectDA.GetDataTable_Top(objTopPara);
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
objDT = JournalSubjectDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = JournalSubjectDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = JournalSubjectDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
 /// <param name = "arrJournalSubjectIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static List<clsJournalSubjectEN> GetObjLstByJournalSubjectIdLst(List<string> arrJournalSubjectIdLst)
{
List<clsJournalSubjectEN> arrObjLst = new List<clsJournalSubjectEN>(); 
System.Data.DataTable objDT; 
 string strSqlConditionStr = clsArray.GetSqlInStrByArray(arrJournalSubjectIdLst, true);
 string strWhereCond = string.Format("JournalSubjectId in ({0})", strSqlConditionStr);
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsJournalSubjectEN objJournalSubjectEN = new clsJournalSubjectEN();
try
{
objJournalSubjectEN.JournalSubjectId = objRow[conJournalSubject.JournalSubjectId].ToString().Trim(); //期刊学科Id
objJournalSubjectEN.JournalSubjectCode = objRow[conJournalSubject.JournalSubjectCode].ToString().Trim(); //期刊学科代码
objJournalSubjectEN.JournalSubjectName = objRow[conJournalSubject.JournalSubjectName].ToString().Trim(); //期刊学科名称
objJournalSubjectEN.JournalSubjectCategoryId = objRow[conJournalSubject.JournalSubjectCategoryId].ToString().Trim(); //期刊学科门类Id
objJournalSubjectEN.UpdDate = objRow[conJournalSubject.UpdDate] == DBNull.Value ? null : objRow[conJournalSubject.UpdDate].ToString().Trim(); //修改日期
objJournalSubjectEN.UpdUser = objRow[conJournalSubject.UpdUser] == DBNull.Value ? null : objRow[conJournalSubject.UpdUser].ToString().Trim(); //修改人
objJournalSubjectEN.Memo = objRow[conJournalSubject.Memo] == DBNull.Value ? null : objRow[conJournalSubject.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objJournalSubjectEN.JournalSubjectId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objJournalSubjectEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrJournalSubjectIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsJournalSubjectEN> GetObjLstByJournalSubjectIdLstCache(List<string> arrJournalSubjectIdLst)
{
string strKey = string.Format("{0}", clsJournalSubjectEN._CurrTabName);
List<clsJournalSubjectEN> arrJournalSubjectObjLstCache = GetObjLstCache();
IEnumerable <clsJournalSubjectEN> arrJournalSubjectObjLst_Sel =
arrJournalSubjectObjLstCache
.Where(x => arrJournalSubjectIdLst.Contains(x.JournalSubjectId));
return arrJournalSubjectObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsJournalSubjectEN> GetObjLst(string strWhereCond)
{
List<clsJournalSubjectEN> arrObjLst = new List<clsJournalSubjectEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsJournalSubjectEN objJournalSubjectEN = new clsJournalSubjectEN();
try
{
objJournalSubjectEN.JournalSubjectId = objRow[conJournalSubject.JournalSubjectId].ToString().Trim(); //期刊学科Id
objJournalSubjectEN.JournalSubjectCode = objRow[conJournalSubject.JournalSubjectCode].ToString().Trim(); //期刊学科代码
objJournalSubjectEN.JournalSubjectName = objRow[conJournalSubject.JournalSubjectName].ToString().Trim(); //期刊学科名称
objJournalSubjectEN.JournalSubjectCategoryId = objRow[conJournalSubject.JournalSubjectCategoryId].ToString().Trim(); //期刊学科门类Id
objJournalSubjectEN.UpdDate = objRow[conJournalSubject.UpdDate] == DBNull.Value ? null : objRow[conJournalSubject.UpdDate].ToString().Trim(); //修改日期
objJournalSubjectEN.UpdUser = objRow[conJournalSubject.UpdUser] == DBNull.Value ? null : objRow[conJournalSubject.UpdUser].ToString().Trim(); //修改人
objJournalSubjectEN.Memo = objRow[conJournalSubject.Memo] == DBNull.Value ? null : objRow[conJournalSubject.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objJournalSubjectEN.JournalSubjectId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objJournalSubjectEN);
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
public static List<clsJournalSubjectEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsJournalSubjectEN> arrObjLst = new List<clsJournalSubjectEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsJournalSubjectEN objJournalSubjectEN = new clsJournalSubjectEN();
try
{
objJournalSubjectEN.JournalSubjectId = objRow[conJournalSubject.JournalSubjectId].ToString().Trim(); //期刊学科Id
objJournalSubjectEN.JournalSubjectCode = objRow[conJournalSubject.JournalSubjectCode].ToString().Trim(); //期刊学科代码
objJournalSubjectEN.JournalSubjectName = objRow[conJournalSubject.JournalSubjectName].ToString().Trim(); //期刊学科名称
objJournalSubjectEN.JournalSubjectCategoryId = objRow[conJournalSubject.JournalSubjectCategoryId].ToString().Trim(); //期刊学科门类Id
objJournalSubjectEN.UpdDate = objRow[conJournalSubject.UpdDate] == DBNull.Value ? null : objRow[conJournalSubject.UpdDate].ToString().Trim(); //修改日期
objJournalSubjectEN.UpdUser = objRow[conJournalSubject.UpdUser] == DBNull.Value ? null : objRow[conJournalSubject.UpdUser].ToString().Trim(); //修改人
objJournalSubjectEN.Memo = objRow[conJournalSubject.Memo] == DBNull.Value ? null : objRow[conJournalSubject.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objJournalSubjectEN.JournalSubjectId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objJournalSubjectEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objJournalSubjectCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsJournalSubjectEN> GetSubObjLstCache(clsJournalSubjectEN objJournalSubjectCond)
{
List<clsJournalSubjectEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsJournalSubjectEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conJournalSubject.AttributeName)
{
if (objJournalSubjectCond.IsUpdated(strFldName) == false) continue;
if (objJournalSubjectCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objJournalSubjectCond[strFldName].ToString());
}
else
{
if (objJournalSubjectCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objJournalSubjectCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objJournalSubjectCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objJournalSubjectCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objJournalSubjectCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objJournalSubjectCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objJournalSubjectCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objJournalSubjectCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objJournalSubjectCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objJournalSubjectCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objJournalSubjectCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objJournalSubjectCond[strFldName]));
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
public static List<clsJournalSubjectEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsJournalSubjectEN> arrObjLst = new List<clsJournalSubjectEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsJournalSubjectEN objJournalSubjectEN = new clsJournalSubjectEN();
try
{
objJournalSubjectEN.JournalSubjectId = objRow[conJournalSubject.JournalSubjectId].ToString().Trim(); //期刊学科Id
objJournalSubjectEN.JournalSubjectCode = objRow[conJournalSubject.JournalSubjectCode].ToString().Trim(); //期刊学科代码
objJournalSubjectEN.JournalSubjectName = objRow[conJournalSubject.JournalSubjectName].ToString().Trim(); //期刊学科名称
objJournalSubjectEN.JournalSubjectCategoryId = objRow[conJournalSubject.JournalSubjectCategoryId].ToString().Trim(); //期刊学科门类Id
objJournalSubjectEN.UpdDate = objRow[conJournalSubject.UpdDate] == DBNull.Value ? null : objRow[conJournalSubject.UpdDate].ToString().Trim(); //修改日期
objJournalSubjectEN.UpdUser = objRow[conJournalSubject.UpdUser] == DBNull.Value ? null : objRow[conJournalSubject.UpdUser].ToString().Trim(); //修改人
objJournalSubjectEN.Memo = objRow[conJournalSubject.Memo] == DBNull.Value ? null : objRow[conJournalSubject.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objJournalSubjectEN.JournalSubjectId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objJournalSubjectEN);
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
public static List<clsJournalSubjectEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsJournalSubjectEN> arrObjLst = new List<clsJournalSubjectEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsJournalSubjectEN objJournalSubjectEN = new clsJournalSubjectEN();
try
{
objJournalSubjectEN.JournalSubjectId = objRow[conJournalSubject.JournalSubjectId].ToString().Trim(); //期刊学科Id
objJournalSubjectEN.JournalSubjectCode = objRow[conJournalSubject.JournalSubjectCode].ToString().Trim(); //期刊学科代码
objJournalSubjectEN.JournalSubjectName = objRow[conJournalSubject.JournalSubjectName].ToString().Trim(); //期刊学科名称
objJournalSubjectEN.JournalSubjectCategoryId = objRow[conJournalSubject.JournalSubjectCategoryId].ToString().Trim(); //期刊学科门类Id
objJournalSubjectEN.UpdDate = objRow[conJournalSubject.UpdDate] == DBNull.Value ? null : objRow[conJournalSubject.UpdDate].ToString().Trim(); //修改日期
objJournalSubjectEN.UpdUser = objRow[conJournalSubject.UpdUser] == DBNull.Value ? null : objRow[conJournalSubject.UpdUser].ToString().Trim(); //修改人
objJournalSubjectEN.Memo = objRow[conJournalSubject.Memo] == DBNull.Value ? null : objRow[conJournalSubject.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objJournalSubjectEN.JournalSubjectId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objJournalSubjectEN);
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
List<clsJournalSubjectEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsJournalSubjectEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsJournalSubjectEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsJournalSubjectEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsJournalSubjectEN> arrObjLst = new List<clsJournalSubjectEN>(); 
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
	clsJournalSubjectEN objJournalSubjectEN = new clsJournalSubjectEN();
try
{
objJournalSubjectEN.JournalSubjectId = objRow[conJournalSubject.JournalSubjectId].ToString().Trim(); //期刊学科Id
objJournalSubjectEN.JournalSubjectCode = objRow[conJournalSubject.JournalSubjectCode].ToString().Trim(); //期刊学科代码
objJournalSubjectEN.JournalSubjectName = objRow[conJournalSubject.JournalSubjectName].ToString().Trim(); //期刊学科名称
objJournalSubjectEN.JournalSubjectCategoryId = objRow[conJournalSubject.JournalSubjectCategoryId].ToString().Trim(); //期刊学科门类Id
objJournalSubjectEN.UpdDate = objRow[conJournalSubject.UpdDate] == DBNull.Value ? null : objRow[conJournalSubject.UpdDate].ToString().Trim(); //修改日期
objJournalSubjectEN.UpdUser = objRow[conJournalSubject.UpdUser] == DBNull.Value ? null : objRow[conJournalSubject.UpdUser].ToString().Trim(); //修改人
objJournalSubjectEN.Memo = objRow[conJournalSubject.Memo] == DBNull.Value ? null : objRow[conJournalSubject.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objJournalSubjectEN.JournalSubjectId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objJournalSubjectEN);
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
public static List<clsJournalSubjectEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsJournalSubjectEN> arrObjLst = new List<clsJournalSubjectEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsJournalSubjectEN objJournalSubjectEN = new clsJournalSubjectEN();
try
{
objJournalSubjectEN.JournalSubjectId = objRow[conJournalSubject.JournalSubjectId].ToString().Trim(); //期刊学科Id
objJournalSubjectEN.JournalSubjectCode = objRow[conJournalSubject.JournalSubjectCode].ToString().Trim(); //期刊学科代码
objJournalSubjectEN.JournalSubjectName = objRow[conJournalSubject.JournalSubjectName].ToString().Trim(); //期刊学科名称
objJournalSubjectEN.JournalSubjectCategoryId = objRow[conJournalSubject.JournalSubjectCategoryId].ToString().Trim(); //期刊学科门类Id
objJournalSubjectEN.UpdDate = objRow[conJournalSubject.UpdDate] == DBNull.Value ? null : objRow[conJournalSubject.UpdDate].ToString().Trim(); //修改日期
objJournalSubjectEN.UpdUser = objRow[conJournalSubject.UpdUser] == DBNull.Value ? null : objRow[conJournalSubject.UpdUser].ToString().Trim(); //修改人
objJournalSubjectEN.Memo = objRow[conJournalSubject.Memo] == DBNull.Value ? null : objRow[conJournalSubject.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objJournalSubjectEN.JournalSubjectId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objJournalSubjectEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsJournalSubjectEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsJournalSubjectEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsJournalSubjectEN> arrObjLst = new List<clsJournalSubjectEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsJournalSubjectEN objJournalSubjectEN = new clsJournalSubjectEN();
try
{
objJournalSubjectEN.JournalSubjectId = objRow[conJournalSubject.JournalSubjectId].ToString().Trim(); //期刊学科Id
objJournalSubjectEN.JournalSubjectCode = objRow[conJournalSubject.JournalSubjectCode].ToString().Trim(); //期刊学科代码
objJournalSubjectEN.JournalSubjectName = objRow[conJournalSubject.JournalSubjectName].ToString().Trim(); //期刊学科名称
objJournalSubjectEN.JournalSubjectCategoryId = objRow[conJournalSubject.JournalSubjectCategoryId].ToString().Trim(); //期刊学科门类Id
objJournalSubjectEN.UpdDate = objRow[conJournalSubject.UpdDate] == DBNull.Value ? null : objRow[conJournalSubject.UpdDate].ToString().Trim(); //修改日期
objJournalSubjectEN.UpdUser = objRow[conJournalSubject.UpdUser] == DBNull.Value ? null : objRow[conJournalSubject.UpdUser].ToString().Trim(); //修改人
objJournalSubjectEN.Memo = objRow[conJournalSubject.Memo] == DBNull.Value ? null : objRow[conJournalSubject.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objJournalSubjectEN.JournalSubjectId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objJournalSubjectEN);
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
public static List<clsJournalSubjectEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsJournalSubjectEN> arrObjLst = new List<clsJournalSubjectEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsJournalSubjectEN objJournalSubjectEN = new clsJournalSubjectEN();
try
{
objJournalSubjectEN.JournalSubjectId = objRow[conJournalSubject.JournalSubjectId].ToString().Trim(); //期刊学科Id
objJournalSubjectEN.JournalSubjectCode = objRow[conJournalSubject.JournalSubjectCode].ToString().Trim(); //期刊学科代码
objJournalSubjectEN.JournalSubjectName = objRow[conJournalSubject.JournalSubjectName].ToString().Trim(); //期刊学科名称
objJournalSubjectEN.JournalSubjectCategoryId = objRow[conJournalSubject.JournalSubjectCategoryId].ToString().Trim(); //期刊学科门类Id
objJournalSubjectEN.UpdDate = objRow[conJournalSubject.UpdDate] == DBNull.Value ? null : objRow[conJournalSubject.UpdDate].ToString().Trim(); //修改日期
objJournalSubjectEN.UpdUser = objRow[conJournalSubject.UpdUser] == DBNull.Value ? null : objRow[conJournalSubject.UpdUser].ToString().Trim(); //修改人
objJournalSubjectEN.Memo = objRow[conJournalSubject.Memo] == DBNull.Value ? null : objRow[conJournalSubject.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objJournalSubjectEN.JournalSubjectId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objJournalSubjectEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsJournalSubjectEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsJournalSubjectEN> arrObjLst = new List<clsJournalSubjectEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsJournalSubjectEN objJournalSubjectEN = new clsJournalSubjectEN();
try
{
objJournalSubjectEN.JournalSubjectId = objRow[conJournalSubject.JournalSubjectId].ToString().Trim(); //期刊学科Id
objJournalSubjectEN.JournalSubjectCode = objRow[conJournalSubject.JournalSubjectCode].ToString().Trim(); //期刊学科代码
objJournalSubjectEN.JournalSubjectName = objRow[conJournalSubject.JournalSubjectName].ToString().Trim(); //期刊学科名称
objJournalSubjectEN.JournalSubjectCategoryId = objRow[conJournalSubject.JournalSubjectCategoryId].ToString().Trim(); //期刊学科门类Id
objJournalSubjectEN.UpdDate = objRow[conJournalSubject.UpdDate] == DBNull.Value ? null : objRow[conJournalSubject.UpdDate].ToString().Trim(); //修改日期
objJournalSubjectEN.UpdUser = objRow[conJournalSubject.UpdUser] == DBNull.Value ? null : objRow[conJournalSubject.UpdUser].ToString().Trim(); //修改人
objJournalSubjectEN.Memo = objRow[conJournalSubject.Memo] == DBNull.Value ? null : objRow[conJournalSubject.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objJournalSubjectEN.JournalSubjectId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objJournalSubjectEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objJournalSubjectEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetJournalSubject(ref clsJournalSubjectEN objJournalSubjectEN)
{
bool bolResult = JournalSubjectDA.GetJournalSubject(ref objJournalSubjectEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "strJournalSubjectId">表关键字</param>
 /// <returns>表对象</returns>
public static clsJournalSubjectEN GetObjByJournalSubjectId(string strJournalSubjectId)
{
if (strJournalSubjectId.IndexOf(' ') >=0)
{
var strMsg = string.Format("(errid:Busi000079)在表中,关键字[strJournalSubjectId]中不能有空格!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
if (string.IsNullOrEmpty(strJournalSubjectId) == true)
{
var strMsg = string.Format("(errid:Busi000020)在表中,关键字[strJournalSubjectId]不能为空!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
clsJournalSubjectEN objJournalSubjectEN = JournalSubjectDA.GetObjByJournalSubjectId(strJournalSubjectId);
return objJournalSubjectEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsJournalSubjectEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsJournalSubjectEN objJournalSubjectEN = JournalSubjectDA.GetFirstObj(strWhereCond);
 return objJournalSubjectEN;
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
public static clsJournalSubjectEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsJournalSubjectEN objJournalSubjectEN = JournalSubjectDA.GetObjByDataRow(objRow);
 return objJournalSubjectEN;
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
public static clsJournalSubjectEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsJournalSubjectEN objJournalSubjectEN = JournalSubjectDA.GetObjByDataRow(objRow);
 return objJournalSubjectEN;
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
 /// <param name = "strJournalSubjectId">所给的关键字</param>
 /// <param name = "lstJournalSubjectObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsJournalSubjectEN GetObjByJournalSubjectIdFromList(string strJournalSubjectId, List<clsJournalSubjectEN> lstJournalSubjectObjLst)
{
foreach (clsJournalSubjectEN objJournalSubjectEN in lstJournalSubjectObjLst)
{
if (objJournalSubjectEN.JournalSubjectId == strJournalSubjectId)
{
return objJournalSubjectEN;
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
 string strMaxJournalSubjectId;
 try
 {
 strMaxJournalSubjectId = clsJournalSubjectDA.GetMaxStrId();
 return strMaxJournalSubjectId;
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
 string strJournalSubjectId;
 try
 {
 strJournalSubjectId = new clsJournalSubjectDA().GetFirstID(strWhereCond);
 return strJournalSubjectId;
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
 arrList = JournalSubjectDA.GetID(strWhereCond);
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
bool bolIsExist = JournalSubjectDA.IsExistCondRec(strWhereCond);
return bolIsExist;
}

 /// <summary>
 /// 判断当前表中是否存在给定关键字值的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExist)
 /// </summary>
 /// <param name = "strJournalSubjectId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public static bool IsExist(string strJournalSubjectId)
{
if (string.IsNullOrEmpty(strJournalSubjectId) == true)
{
var strMsg = string.Format("(errid:Busi000027)在表中,关键字[strJournalSubjectId]不能为空!!(from {0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
//检测记录是否存在
bool bolIsExist = JournalSubjectDA.IsExist(strJournalSubjectId);
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
 bolIsExist = clsJournalSubjectDA.IsExistTable();
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
 bolIsExist = JournalSubjectDA.IsExistTable(strTabName);
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
 /// <param name = "objJournalSubjectEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecordBySql2(clsJournalSubjectEN objJournalSubjectEN, bool bolIsNeedCheckUniqueness=true)
{
if (bolIsNeedCheckUniqueness == true && objJournalSubjectEN.CheckUniqueness() == false)
{
var strMsg = string.Format("记录已经存在!期刊学科门类Id = [{0}],期刊学科名称 = [{1}]的数据已经存在!(in clsJournalSubjectBL.AddNewRecordBySql2)", objJournalSubjectEN.JournalSubjectCategoryId,objJournalSubjectEN.JournalSubjectName);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objJournalSubjectEN.JournalSubjectId) == true || clsJournalSubjectBL.IsExist(objJournalSubjectEN.JournalSubjectId) == true)
 {
     objJournalSubjectEN.JournalSubjectId = clsJournalSubjectBL.GetMaxStrId_S();
 }
bool bolResult = JournalSubjectDA.AddNewRecordBySQL2(objJournalSubjectEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsJournalSubjectBL.ReFreshCache();

if (clsJournalSubjectBL.relatedActions != null)
{
clsJournalSubjectBL.relatedActions.UpdRelaTabDate(objJournalSubjectEN.JournalSubjectId, "SetUpdDate");
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
 /// <param name = "objJournalSubjectEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordBySql2WithReturnKey(clsJournalSubjectEN objJournalSubjectEN, bool bolIsNeedCheckUniqueness=true)
{
if (bolIsNeedCheckUniqueness == true && objJournalSubjectEN.CheckUniqueness() == false)
{
var strMsg = string.Format("记录已经存在!期刊学科门类Id = [{0}],期刊学科名称 = [{1}]的数据已经存在!(in clsJournalSubjectBL.AddNewRecordBySql2WithReturnKey)", objJournalSubjectEN.JournalSubjectCategoryId,objJournalSubjectEN.JournalSubjectName);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objJournalSubjectEN.JournalSubjectId) == true || clsJournalSubjectBL.IsExist(objJournalSubjectEN.JournalSubjectId) == true)
 {
     objJournalSubjectEN.JournalSubjectId = clsJournalSubjectBL.GetMaxStrId_S();
 }
string strKey = JournalSubjectDA.AddNewRecordBySQL2WithReturnKey(objJournalSubjectEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsJournalSubjectBL.ReFreshCache();

if (clsJournalSubjectBL.relatedActions != null)
{
clsJournalSubjectBL.relatedActions.UpdRelaTabDate(objJournalSubjectEN.JournalSubjectId, "SetUpdDate");
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
 /// <param name = "objJournalSubjectEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(clsJournalSubjectEN objJournalSubjectEN)
{
try
{
bool bolResult = JournalSubjectDA.Update(objJournalSubjectEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsJournalSubjectBL.ReFreshCache();

if (clsJournalSubjectBL.relatedActions != null)
{
clsJournalSubjectBL.relatedActions.UpdRelaTabDate(objJournalSubjectEN.JournalSubjectId, "SetUpdDate");
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
 /// <param name = "objJournalSubjectEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateBySql2(clsJournalSubjectEN objJournalSubjectEN)
{
 if (string.IsNullOrEmpty(objJournalSubjectEN.JournalSubjectId) == true)
 {
var strMsg = string.Format("(errid:Busi000065)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = JournalSubjectDA.UpdateBySql2(objJournalSubjectEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsJournalSubjectBL.ReFreshCache();

if (clsJournalSubjectBL.relatedActions != null)
{
clsJournalSubjectBL.relatedActions.UpdRelaTabDate(objJournalSubjectEN.JournalSubjectId, "SetUpdDate");
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
 /// <param name = "strJournalSubjectId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int DelRecord(string strJournalSubjectId)
{
try
{
 clsJournalSubjectEN objJournalSubjectEN = clsJournalSubjectBL.GetObjByJournalSubjectId(strJournalSubjectId);

if (clsJournalSubjectBL.relatedActions != null)
{
clsJournalSubjectBL.relatedActions.UpdRelaTabDate(objJournalSubjectEN.JournalSubjectId, "SetUpdDate");
}
if (objJournalSubjectEN != null)
{
int intRecNum = JournalSubjectDA.DelRecord(strJournalSubjectId);
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
/// <param name="strJournalSubjectId">表关键字</param>
/// <returns></returns>
public static bool DelRecordEx(string strJournalSubjectId )
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsJournalSubjectDA.GetSpecSQLObj();
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
//删除与表:[JournalSubject]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conJournalSubject.JournalSubjectId,
//strJournalSubjectId);
//        clsJournalSubjectBL.DelJournalSubjectsByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsJournalSubjectBL.DelRecord(strJournalSubjectId, objConnection, objSqlTransaction);
objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsJournalSubjectBLEx", "DelRecordEx", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("扩展删除记录出错:{0}!keyId = {1}.({2})",
objException.Message,
strJournalSubjectId, clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "strJournalSubjectId">给定的关键字值</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回删除是否成功?</returns>
public static bool DelRecord(string strJournalSubjectId, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
if (clsJournalSubjectBL.relatedActions != null)
{
clsJournalSubjectBL.relatedActions.UpdRelaTabDate(strJournalSubjectId, "UpdRelaTabDate");
}
bool bolResult = JournalSubjectDA.DelRecord(strJournalSubjectId,objSqlConnection,objSqlTransaction);
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
 /// <param name = "arrJournalSubjectIdLst">给定的关键字值列表</param>
 /// <returns>返回删除的记录数</returns>
public static int DelJournalSubjects(List<string> arrJournalSubjectIdLst)
{
if (arrJournalSubjectIdLst.Count == 0) return 0;
try
{
if (clsJournalSubjectBL.relatedActions != null)
{
foreach (var strJournalSubjectId in arrJournalSubjectIdLst)
{
clsJournalSubjectBL.relatedActions.UpdRelaTabDate(strJournalSubjectId, "UpdRelaTabDate");
}
}
int intDelRecNum = JournalSubjectDA.DelJournalSubject(arrJournalSubjectIdLst);
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
public static int DelJournalSubjectsByCond(string strWhereCond)
{
try
{
if (clsJournalSubjectBL.relatedActions != null)
{
List<string> arrJournalSubjectId = GetPrimaryKeyID_S(strWhereCond);
foreach (var strJournalSubjectId in arrJournalSubjectId)
{
clsJournalSubjectBL.relatedActions.UpdRelaTabDate(strJournalSubjectId, "UpdRelaTabDate");
}
}
int intRecNum = JournalSubjectDA.DelJournalSubject(strWhereCond);
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
/// 这里仅仅是演示函数,使用时请复制到扩展类:[JournalSubject]中改名为:[DelRecord4MultiTabEx]使用
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DelRecord4MultiTab)
/// </summary>
/// <param name="strJournalSubjectId">表关键字</param>
/// <returns></returns>
public static bool DelRecord4MultiTab(string strJournalSubjectId)
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsJournalSubjectDA.GetSpecSQLObj();
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
//删除与表:[JournalSubject]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conStudent.id_College,
//strid_College);
//        clsStudentBL.DelStudentsByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsJournalSubjectBL.DelRecord(strJournalSubjectId, objConnection, objSqlTransaction);
                objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsJournalSubjectBL", "DelRecord4MultiTab", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("删除多表记录出错:{0}!keyId = {1}.({2})",
objException.Message,
strJournalSubjectId, clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "objJournalSubjectENS">源对象</param>
 /// <param name = "objJournalSubjectENT">目标对象</param>
 public static void CopyTo(clsJournalSubjectEN objJournalSubjectENS, clsJournalSubjectEN objJournalSubjectENT)
{
try
{
objJournalSubjectENT.JournalSubjectId = objJournalSubjectENS.JournalSubjectId; //期刊学科Id
objJournalSubjectENT.JournalSubjectCode = objJournalSubjectENS.JournalSubjectCode; //期刊学科代码
objJournalSubjectENT.JournalSubjectName = objJournalSubjectENS.JournalSubjectName; //期刊学科名称
objJournalSubjectENT.JournalSubjectCategoryId = objJournalSubjectENS.JournalSubjectCategoryId; //期刊学科门类Id
objJournalSubjectENT.UpdDate = objJournalSubjectENS.UpdDate; //修改日期
objJournalSubjectENT.UpdUser = objJournalSubjectENS.UpdUser; //修改人
objJournalSubjectENT.Memo = objJournalSubjectENS.Memo; //备注
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
 /// <param name = "objJournalSubjectEN">源简化对象</param>
 public static void SetUpdFlag(clsJournalSubjectEN objJournalSubjectEN)
{
try
{
objJournalSubjectEN.ClearUpdateState();
   string strsfUpdFldSetStr = objJournalSubjectEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(conJournalSubject.JournalSubjectId, new clsStrCompareIgnoreCase())  ==  true)
{
objJournalSubjectEN.JournalSubjectId = objJournalSubjectEN.JournalSubjectId; //期刊学科Id
}
if (arrFldSet.Contains(conJournalSubject.JournalSubjectCode, new clsStrCompareIgnoreCase())  ==  true)
{
objJournalSubjectEN.JournalSubjectCode = objJournalSubjectEN.JournalSubjectCode; //期刊学科代码
}
if (arrFldSet.Contains(conJournalSubject.JournalSubjectName, new clsStrCompareIgnoreCase())  ==  true)
{
objJournalSubjectEN.JournalSubjectName = objJournalSubjectEN.JournalSubjectName; //期刊学科名称
}
if (arrFldSet.Contains(conJournalSubject.JournalSubjectCategoryId, new clsStrCompareIgnoreCase())  ==  true)
{
objJournalSubjectEN.JournalSubjectCategoryId = objJournalSubjectEN.JournalSubjectCategoryId; //期刊学科门类Id
}
if (arrFldSet.Contains(conJournalSubject.UpdDate, new clsStrCompareIgnoreCase())  ==  true)
{
objJournalSubjectEN.UpdDate = objJournalSubjectEN.UpdDate == "[null]" ? null :  objJournalSubjectEN.UpdDate; //修改日期
}
if (arrFldSet.Contains(conJournalSubject.UpdUser, new clsStrCompareIgnoreCase())  ==  true)
{
objJournalSubjectEN.UpdUser = objJournalSubjectEN.UpdUser == "[null]" ? null :  objJournalSubjectEN.UpdUser; //修改人
}
if (arrFldSet.Contains(conJournalSubject.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objJournalSubjectEN.Memo = objJournalSubjectEN.Memo == "[null]" ? null :  objJournalSubjectEN.Memo; //备注
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
 /// <param name = "objJournalSubjectEN">源简化对象</param>
 public static void AccessFldValueNull(clsJournalSubjectEN objJournalSubjectEN)
{
try
{
if (objJournalSubjectEN.UpdDate == "[null]") objJournalSubjectEN.UpdDate = null; //修改日期
if (objJournalSubjectEN.UpdUser == "[null]") objJournalSubjectEN.UpdUser = null; //修改人
if (objJournalSubjectEN.Memo == "[null]") objJournalSubjectEN.Memo = null; //备注
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
public static void CheckPropertyNew(clsJournalSubjectEN objJournalSubjectEN)
{
 JournalSubjectDA.CheckPropertyNew(objJournalSubjectEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(clsJournalSubjectEN objJournalSubjectEN)
{
 JournalSubjectDA.CheckProperty4Condition(objJournalSubjectEN);
 }


 #endregion 检查对象属性


 #region 绑定下拉框

 /// <summary>
 /// 绑定基于Win的下拉框
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_TabFeature_ComboBoxBindFunction)
 /// </summary>
 /// <param name = "objComboBox">需要绑定当前表的下拉框</param>

public static void BindCbo_JournalSubjectId(System.Windows.Forms.ComboBox objComboBox )
{
//为数据源为表的下拉框设置内容
string strCondition = string.Format("1 =1 Order By {0}", conJournalSubject.JournalSubjectId); 
List<clsJournalSubjectEN> arrObjLst = clsJournalSubjectBL.GetObjLst(strCondition);
//初始化一个对象列表
//插入第0项。在第0项中插入“请选择...”,为了方便用户,与WEB方式类似。
clsJournalSubjectEN objJournalSubjectEN = new clsJournalSubjectEN()
{
JournalSubjectId = "0",
JournalSubjectName = "选[期刊学科]..."
};
arrObjLst.Insert(0, objJournalSubjectEN);
//设置下拉框的数据源、以及设置值项、显示项
objComboBox.ValueMember = conJournalSubject.JournalSubjectId;
objComboBox.DisplayMember = conJournalSubject.JournalSubjectName;
objComboBox.DataSource = arrObjLst;
objComboBox.SelectedIndex = 0;
}

 /// <summary>
 /// 绑定基于Web的下拉框
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_TabFeature_DdlBindFunction)
 /// </summary>
 /// <param name = "objDDL">需要绑定当前表的下拉框</param>

public static void BindDdl_JournalSubjectId(System.Web.UI.WebControls.DropDownList objDDL )
{
//为数据源于表的下拉框设置内容
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[期刊学科]...","0");
string strCondition = string.Format("1 =1 Order By {0}", conJournalSubject.JournalSubjectId); 
IEnumerable<clsJournalSubjectEN> arrObjLst = clsJournalSubjectBL.GetObjLst(strCondition);
objDDL.DataValueField = conJournalSubject.JournalSubjectId;
objDDL.DataTextField = conJournalSubject.JournalSubjectName;
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
public static void BindDdl_JournalSubjectIdCache(System.Web.UI.WebControls.DropDownList objDDL)
{
//为数据源于表的下拉框设置内容
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[期刊学科]...","0");
List<clsJournalSubjectEN> arrJournalSubjectObjLst = GetAllJournalSubjectObjLstCache(); 
objDDL.DataValueField = conJournalSubject.JournalSubjectId;
objDDL.DataTextField = conJournalSubject.JournalSubjectName;
objDDL.DataSource = arrJournalSubjectObjLst;
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
if (clsJournalSubjectBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsJournalSubjectBL没有刷新缓存机制(clsJournalSubjectBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by JournalSubjectId");
//if (arrJournalSubjectObjLstCache == null)
//{
//arrJournalSubjectObjLstCache = JournalSubjectDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "strJournalSubjectId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsJournalSubjectEN GetObjByJournalSubjectIdCache(string strJournalSubjectId)
{
//获取缓存中的对象列表
string strKey = string.Format("{0}", clsJournalSubjectEN._CurrTabName);
List<clsJournalSubjectEN> arrJournalSubjectObjLstCache = GetObjLstCache();
IEnumerable <clsJournalSubjectEN> arrJournalSubjectObjLst_Sel =
arrJournalSubjectObjLstCache
.Where(x=> x.JournalSubjectId == strJournalSubjectId 
);
if (arrJournalSubjectObjLst_Sel.Count() == 0)
{
   clsJournalSubjectEN obj = clsJournalSubjectBL.GetObjByJournalSubjectId(strJournalSubjectId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
 }
return null;
}
return arrJournalSubjectObjLst_Sel.First();
}

 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecNameByKeyCache)
 /// </summary>
 /// <param name = "strJournalSubjectId">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetJournalSubjectNameByJournalSubjectIdCache(string strJournalSubjectId)
{
if (string.IsNullOrEmpty(strJournalSubjectId) == true) return "";
//获取缓存中的对象列表
clsJournalSubjectEN objJournalSubject = GetObjByJournalSubjectIdCache(strJournalSubjectId);
if (objJournalSubject == null) return "";
return objJournalSubject.JournalSubjectName;
}
 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecNameByKeyCache)
 /// </summary>
 /// <param name = "strJournalSubjectId">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetNameByJournalSubjectIdCache(string strJournalSubjectId)
{
if (string.IsNullOrEmpty(strJournalSubjectId) == true) return "";
//获取缓存中的对象列表
clsJournalSubjectEN objJournalSubject = GetObjByJournalSubjectIdCache(strJournalSubjectId);
if (objJournalSubject == null) return "";
return objJournalSubject.JournalSubjectName;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsJournalSubjectEN> GetAllJournalSubjectObjLstCache()
{
//获取缓存中的对象列表
List<clsJournalSubjectEN> arrJournalSubjectObjLstCache = GetObjLstCache(); 
return arrJournalSubjectObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsJournalSubjectEN> GetObjLstCache()
{
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}", clsJournalSubjectEN._CurrTabName);
List<clsJournalSubjectEN> arrJournalSubjectObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrJournalSubjectObjLstCache;
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
string strKey = string.Format("{0}", clsJournalSubjectEN._CurrTabName);
CacheHelper.Remove(strKey);
clsJournalSubjectEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
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
if (clsJournalSubjectEN._RefreshTimeLst.Count == 0) return "";
return clsJournalSubjectEN._RefreshTimeLst[clsJournalSubjectEN._RefreshTimeLst.Count - 1];
}

 /// <summary>
 /// 刷新缓存.把当前表的缓存以及该表相关视图的缓存清空.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ReFreshCache)
 /// </summary>
public static void ReFreshCache()
{
if (clsJournalSubjectBL.objCommFun4BL != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}", clsJournalSubjectEN._CurrTabName);
CacheHelper.Remove(strKey);
clsJournalSubjectEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
clsJournalSubjectBL.objCommFun4BL.ReFreshCache();
}
}


 #endregion 缓存操作


 #region 检查唯一性

 /// <summary>
 /// 获取检查唯一性条件串(Uniqueness)--JournalSubject(期刊学科)
 /// 唯一性条件:JournalSubjectCategoryId_JournalSubjectName
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetUniquenessConditionString)
 /// </summary>
 /// <param name = "objJournalSubjectEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(clsJournalSubjectEN objJournalSubjectEN)
{
//检测记录是否存在
string strResult = JournalSubjectDA.GetUniCondStr(objJournalSubjectEN);
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
public static string Func(string strInFldName, string strOutFldName, string strJournalSubjectId)
{
if (strInFldName != conJournalSubject.JournalSubjectId)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (conJournalSubject.AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", conJournalSubject.AttributeName));
throw new Exception(strMsg);
}
var objJournalSubject = clsJournalSubjectBL.GetObjByJournalSubjectIdCache(strJournalSubjectId);
if (objJournalSubject == null) return "";
return objJournalSubject[strOutFldName].ToString();
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
int intRecCount = clsJournalSubjectDA.GetRecCount(strTabName);
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
int intRecCount = clsJournalSubjectDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsJournalSubjectDA.GetRecCount();
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
int intRecCount = clsJournalSubjectDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objJournalSubjectCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsJournalSubjectEN objJournalSubjectCond)
{
List<clsJournalSubjectEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsJournalSubjectEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conJournalSubject.AttributeName)
{
if (objJournalSubjectCond.IsUpdated(strFldName) == false) continue;
if (objJournalSubjectCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objJournalSubjectCond[strFldName].ToString());
}
else
{
if (objJournalSubjectCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objJournalSubjectCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objJournalSubjectCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objJournalSubjectCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objJournalSubjectCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objJournalSubjectCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objJournalSubjectCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objJournalSubjectCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objJournalSubjectCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objJournalSubjectCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objJournalSubjectCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objJournalSubjectCond[strFldName]));
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
 List<string> arrList = clsJournalSubjectDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = JournalSubjectDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = JournalSubjectDA.GetFldValueNoDistinct(strFldName, strWhereCond);
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
int intRecCount = JournalSubjectDA.SetFldValue(strFldName, strValue, strWhereCond);
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
int intRecCount = clsJournalSubjectDA.SetFldValue(clsJournalSubjectEN._CurrTabName, strFldName, fltValue, strWhereCond);
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
int intRecCount = JournalSubjectDA.SetFldValue( strFldName, intValue, strWhereCond);
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
int intRecCount = clsJournalSubjectDA.SetFldValue(strTabName, strFldName, strValue, strWhereCond);
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
int intRecCount = clsJournalSubjectDA.SetFldValue(strTabName, strFldName, intValue, strWhereCond);
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
int intRecCount = clsJournalSubjectDA.SetFldValue(strTabName, strFldName, fltValue, strWhereCond);
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
  strCreateTabCode.Append("CREATE table [dbo].[JournalSubject] "); 
 strCreateTabCode.Append(" ( "); 
 // /**期刊学科Id*/ 
 strCreateTabCode.Append(" JournalSubjectId char(4) primary key, "); 
 // /**期刊学科代码*/ 
 strCreateTabCode.Append(" JournalSubjectCode varchar(100) not Null, "); 
 // /**期刊学科名称*/ 
 strCreateTabCode.Append(" JournalSubjectName varchar(100) not Null, "); 
 // /**期刊学科门类Id*/ 
 strCreateTabCode.Append(" JournalSubjectCategoryId char(4) not Null, "); 
 // /**修改日期*/ 
 strCreateTabCode.Append(" UpdDate varchar(20) Null, "); 
 // /**修改人*/ 
 strCreateTabCode.Append(" UpdUser varchar(20) Null, "); 
 // /**备注*/ 
 strCreateTabCode.Append(" Memo varchar(1000) Null, "); 
 // /**期刊学科门类名称*/ 
 strCreateTabCode.Append(" JournalSubjectCategoryName varchar(100) Null ");
 strCreateTabCode.Append(") "); 
  strCreateTabCode.Append("ON [PRIMARY] ");
  return strCreateTabCode.ToString();
}



 #endregion 表操作
}
 /// <summary>
 /// 期刊学科(JournalSubject)
 /// 数据源类型:表
 /// (AutoGCLib.CommFun4BL4CSharp:GeneCode_This)
 /// </summary>
public class  clsCommFun4BL4JournalSubject : clsCommFun4BL
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
clsJournalSubjectBL.ReFreshThisCache();
}
}

}