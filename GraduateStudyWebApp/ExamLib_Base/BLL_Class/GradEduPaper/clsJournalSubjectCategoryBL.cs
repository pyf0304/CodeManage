
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsJournalSubjectCategoryBL
 表名:JournalSubjectCategory(01120931)
 * 版本:2024.11.13.1(服务器:WIN-SRV103-116)
 日期:2024/11/13 06:10:45
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
public static class  clsJournalSubjectCategoryBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "strJournalSubjectCategoryId">表关键字</param>
 /// <returns>表对象</returns>
public static clsJournalSubjectCategoryEN GetObj(this K_JournalSubjectCategoryId_JournalSubjectCategory myKey)
{
clsJournalSubjectCategoryEN objJournalSubjectCategoryEN = clsJournalSubjectCategoryBL.JournalSubjectCategoryDA.GetObjByJournalSubjectCategoryId(myKey.Value);
return objJournalSubjectCategoryEN;
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_AddNewRecord)
 /// </summary>
 /// <param name = "objJournalSubjectCategoryEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clsJournalSubjectCategoryEN objJournalSubjectCategoryEN, bool bolIsNeedCheckUniqueness = true)
{
if (bolIsNeedCheckUniqueness == true && CheckUniqueness(objJournalSubjectCategoryEN) == false)
{
var strMsg = string.Format("记录已经存在!期刊学科门类名称 = [{0}]的数据已经存在!(in clsJournalSubjectCategoryBL.AddNewRecord)", objJournalSubjectCategoryEN.JournalSubjectCategoryName);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objJournalSubjectCategoryEN.JournalSubjectCategoryId) == true || clsJournalSubjectCategoryBL.IsExist(objJournalSubjectCategoryEN.JournalSubjectCategoryId) == true)
 {
     objJournalSubjectCategoryEN.JournalSubjectCategoryId = clsJournalSubjectCategoryBL.GetMaxStrId_S();
 }
bool bolResult = clsJournalSubjectCategoryBL.JournalSubjectCategoryDA.AddNewRecordBySQL2(objJournalSubjectCategoryEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsJournalSubjectCategoryBL.ReFreshCache();

if (clsJournalSubjectCategoryBL.relatedActions != null)
{
clsJournalSubjectCategoryBL.relatedActions.UpdRelaTabDate(objJournalSubjectCategoryEN.JournalSubjectCategoryId, objJournalSubjectCategoryEN.UpdUser);
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
public static bool AddRecordEx(this clsJournalSubjectCategoryEN objJournalSubjectCategoryEN, bool bolIsNeedCheckUniqueness = true)
{
//操作步骤:
//1、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在
//2、检查唯一性
//3、检查传进去的对象属性是否合法
//4、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
//1、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在

//因为是字符型自增主键,不需要检查主键是否已经存在,在添加时,再获取 最大值作为主键
//if (clsJournalSubjectCategoryBL.IsExist(objJournalSubjectCategoryEN.JournalSubjectCategoryId))	//判断是否有相同的关键字
//{
//strMsg = "(errid:Busi000151)关键字字段已有相同的值";
//throw new Exception(strMsg);
//}
try
{
 //2、检查传进去的对象属性是否合法
objJournalSubjectCategoryEN.CheckPropertyNew();
 ///5.2、检查唯一性
if (bolIsNeedCheckUniqueness == true && objJournalSubjectCategoryEN.CheckUniqueness() == false)
{
strMsg = string.Format("(期刊学科门类名称(JournalSubjectCategoryName)=[{0}])已经存在,不能重复!", objJournalSubjectCategoryEN.JournalSubjectCategoryName);
throw new Exception(strMsg);
}
//因为是字符型自增主键,所以在添加时,自动获取主键值。
 if (string.IsNullOrEmpty(objJournalSubjectCategoryEN.JournalSubjectCategoryId) == true || clsJournalSubjectCategoryBL.IsExist(objJournalSubjectCategoryEN.JournalSubjectCategoryId) == true)
 {
     objJournalSubjectCategoryEN.JournalSubjectCategoryId = clsJournalSubjectCategoryBL.GetMaxStrId_S();
 }
//6、把数据实体层的数据存贮到数据库中
objJournalSubjectCategoryEN.AddNewRecord();
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
 /// <param name = "objJournalSubjectCategoryEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static string AddNewRecordWithMaxId(this clsJournalSubjectCategoryEN objJournalSubjectCategoryEN, bool bolIsNeedCheckUniqueness = true)
{
if (bolIsNeedCheckUniqueness == true && CheckUniqueness(objJournalSubjectCategoryEN) == false)
{
var strMsg = string.Format("记录已经存在!期刊学科门类名称 = [{0}]的数据已经存在!(in clsJournalSubjectCategoryBL.AddNewRecordWithMaxId)", objJournalSubjectCategoryEN.JournalSubjectCategoryName);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objJournalSubjectCategoryEN.JournalSubjectCategoryId) == true || clsJournalSubjectCategoryBL.IsExist(objJournalSubjectCategoryEN.JournalSubjectCategoryId) == true)
 {
     objJournalSubjectCategoryEN.JournalSubjectCategoryId = clsJournalSubjectCategoryBL.GetMaxStrId_S();
 }
string strJournalSubjectCategoryId = clsJournalSubjectCategoryBL.JournalSubjectCategoryDA.AddNewRecordBySQL2WithReturnKey(objJournalSubjectCategoryEN);
     objJournalSubjectCategoryEN.JournalSubjectCategoryId = strJournalSubjectCategoryId;
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsJournalSubjectCategoryBL.ReFreshCache();

if (clsJournalSubjectCategoryBL.relatedActions != null)
{
clsJournalSubjectCategoryBL.relatedActions.UpdRelaTabDate(objJournalSubjectCategoryEN.JournalSubjectCategoryId, objJournalSubjectCategoryEN.UpdUser);
}
return strJournalSubjectCategoryId;
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
 /// <param name = "objJournalSubjectCategoryEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordWithReturnKey(this clsJournalSubjectCategoryEN objJournalSubjectCategoryEN, bool bolIsNeedCheckUniqueness = true)
{
if (bolIsNeedCheckUniqueness == true && CheckUniqueness(objJournalSubjectCategoryEN) == false)
{
var strMsg = string.Format("记录已经存在!期刊学科门类名称 = [{0}]的数据已经存在!(in clsJournalSubjectCategoryBL.AddNewRecordWithReturnKey)", objJournalSubjectCategoryEN.JournalSubjectCategoryName);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objJournalSubjectCategoryEN.JournalSubjectCategoryId) == true || clsJournalSubjectCategoryBL.IsExist(objJournalSubjectCategoryEN.JournalSubjectCategoryId) == true)
 {
     objJournalSubjectCategoryEN.JournalSubjectCategoryId = clsJournalSubjectCategoryBL.GetMaxStrId_S();
 }
string strKey = clsJournalSubjectCategoryBL.JournalSubjectCategoryDA.AddNewRecordBySQL2WithReturnKey(objJournalSubjectCategoryEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsJournalSubjectCategoryBL.ReFreshCache();

if (clsJournalSubjectCategoryBL.relatedActions != null)
{
clsJournalSubjectCategoryBL.relatedActions.UpdRelaTabDate(objJournalSubjectCategoryEN.JournalSubjectCategoryId, objJournalSubjectCategoryEN.UpdUser);
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
 /// <param name = "objJournalSubjectCategoryEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsJournalSubjectCategoryEN SetJournalSubjectCategoryId(this clsJournalSubjectCategoryEN objJournalSubjectCategoryEN, string strJournalSubjectCategoryId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strJournalSubjectCategoryId, 4, conJournalSubjectCategory.JournalSubjectCategoryId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strJournalSubjectCategoryId, 4, conJournalSubjectCategory.JournalSubjectCategoryId);
}
objJournalSubjectCategoryEN.JournalSubjectCategoryId = strJournalSubjectCategoryId; //期刊学科门类Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objJournalSubjectCategoryEN.dicFldComparisonOp.ContainsKey(conJournalSubjectCategory.JournalSubjectCategoryId) == false)
{
objJournalSubjectCategoryEN.dicFldComparisonOp.Add(conJournalSubjectCategory.JournalSubjectCategoryId, strComparisonOp);
}
else
{
objJournalSubjectCategoryEN.dicFldComparisonOp[conJournalSubjectCategory.JournalSubjectCategoryId] = strComparisonOp;
}
}
return objJournalSubjectCategoryEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objJournalSubjectCategoryEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsJournalSubjectCategoryEN SetJournalSubjectCategoryName(this clsJournalSubjectCategoryEN objJournalSubjectCategoryEN, string strJournalSubjectCategoryName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strJournalSubjectCategoryName, conJournalSubjectCategory.JournalSubjectCategoryName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strJournalSubjectCategoryName, 100, conJournalSubjectCategory.JournalSubjectCategoryName);
}
objJournalSubjectCategoryEN.JournalSubjectCategoryName = strJournalSubjectCategoryName; //期刊学科门类名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objJournalSubjectCategoryEN.dicFldComparisonOp.ContainsKey(conJournalSubjectCategory.JournalSubjectCategoryName) == false)
{
objJournalSubjectCategoryEN.dicFldComparisonOp.Add(conJournalSubjectCategory.JournalSubjectCategoryName, strComparisonOp);
}
else
{
objJournalSubjectCategoryEN.dicFldComparisonOp[conJournalSubjectCategory.JournalSubjectCategoryName] = strComparisonOp;
}
}
return objJournalSubjectCategoryEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objJournalSubjectCategoryEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsJournalSubjectCategoryEN SetUpdDate(this clsJournalSubjectCategoryEN objJournalSubjectCategoryEN, string strUpdDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdDate, 20, conJournalSubjectCategory.UpdDate);
}
objJournalSubjectCategoryEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objJournalSubjectCategoryEN.dicFldComparisonOp.ContainsKey(conJournalSubjectCategory.UpdDate) == false)
{
objJournalSubjectCategoryEN.dicFldComparisonOp.Add(conJournalSubjectCategory.UpdDate, strComparisonOp);
}
else
{
objJournalSubjectCategoryEN.dicFldComparisonOp[conJournalSubjectCategory.UpdDate] = strComparisonOp;
}
}
return objJournalSubjectCategoryEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objJournalSubjectCategoryEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsJournalSubjectCategoryEN SetUpdUser(this clsJournalSubjectCategoryEN objJournalSubjectCategoryEN, string strUpdUser, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdUser, 20, conJournalSubjectCategory.UpdUser);
}
objJournalSubjectCategoryEN.UpdUser = strUpdUser; //修改人
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objJournalSubjectCategoryEN.dicFldComparisonOp.ContainsKey(conJournalSubjectCategory.UpdUser) == false)
{
objJournalSubjectCategoryEN.dicFldComparisonOp.Add(conJournalSubjectCategory.UpdUser, strComparisonOp);
}
else
{
objJournalSubjectCategoryEN.dicFldComparisonOp[conJournalSubjectCategory.UpdUser] = strComparisonOp;
}
}
return objJournalSubjectCategoryEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objJournalSubjectCategoryEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsJournalSubjectCategoryEN SetMemo(this clsJournalSubjectCategoryEN objJournalSubjectCategoryEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, conJournalSubjectCategory.Memo);
}
objJournalSubjectCategoryEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objJournalSubjectCategoryEN.dicFldComparisonOp.ContainsKey(conJournalSubjectCategory.Memo) == false)
{
objJournalSubjectCategoryEN.dicFldComparisonOp.Add(conJournalSubjectCategory.Memo, strComparisonOp);
}
else
{
objJournalSubjectCategoryEN.dicFldComparisonOp[conJournalSubjectCategory.Memo] = strComparisonOp;
}
}
return objJournalSubjectCategoryEN;
	}

 /// <summary>
 /// 修改记录存盘到数据表中
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_UpdateRecordEx)
 /// </summary>
 /// <param name = "objJournalSubjectCategoryEN">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool UpdateRecordEx(this clsJournalSubjectCategoryEN objJournalSubjectCategoryEN)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
try
{
//1、检查传进去的对象属性是否合法
objJournalSubjectCategoryEN.CheckPropertyNew();
clsJournalSubjectCategoryEN objJournalSubjectCategoryCond = new clsJournalSubjectCategoryEN();
string strCondition = objJournalSubjectCategoryCond
.SetJournalSubjectCategoryId(objJournalSubjectCategoryEN.JournalSubjectCategoryId, "<>")
.SetJournalSubjectCategoryName(objJournalSubjectCategoryEN.JournalSubjectCategoryName, "=")
.GetCombineCondition();
objJournalSubjectCategoryEN._IsCheckProperty = true;
bool bolIsExist = clsJournalSubjectCategoryBL.IsExistRecord(strCondition);
if (bolIsExist)
{
strMsg = "(JournalSubjectCategoryName)不能重复!";
throw new Exception(strMsg);
}
//4、把数据实体层的数据存贮到数据库中
objJournalSubjectCategoryEN.Update();
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
 /// <param name = "objJournalSubjectCategory">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool EditRecordEx(this clsJournalSubjectCategoryEN objJournalSubjectCategory)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
clsJournalSubjectCategoryEN objJournalSubjectCategoryCond = new clsJournalSubjectCategoryEN();
string strCondition = objJournalSubjectCategoryCond
.SetJournalSubjectCategoryName(objJournalSubjectCategory.JournalSubjectCategoryName, "=")
.GetCombineCondition();
objJournalSubjectCategory._IsCheckProperty = true;
bool bolIsExist = clsJournalSubjectCategoryBL.IsExistRecord(strCondition);
if (bolIsExist)
{
objJournalSubjectCategory.JournalSubjectCategoryId = clsJournalSubjectCategoryBL.GetFirstID_S(strCondition);
objJournalSubjectCategory.UpdateWithCondition(strCondition);
}
else
{
objJournalSubjectCategory.JournalSubjectCategoryId = clsJournalSubjectCategoryBL.GetMaxStrId_S();
objJournalSubjectCategory.AddNewRecord();
}
return true; 
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_Update)
 /// </summary>
 /// <param name = "objJournalSubjectCategoryEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsJournalSubjectCategoryEN objJournalSubjectCategoryEN)
{
 if (string.IsNullOrEmpty(objJournalSubjectCategoryEN.JournalSubjectCategoryId) == true)
 {
string strMsg = string.Format("(errid:Busi000095)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsJournalSubjectCategoryBL.JournalSubjectCategoryDA.UpdateBySql2(objJournalSubjectCategoryEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsJournalSubjectCategoryBL.ReFreshCache();

if (clsJournalSubjectCategoryBL.relatedActions != null)
{
clsJournalSubjectCategoryBL.relatedActions.UpdRelaTabDate(objJournalSubjectCategoryEN.JournalSubjectCategoryId, objJournalSubjectCategoryEN.UpdUser);
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
 /// <param name = "objJournalSubjectCategoryEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsJournalSubjectCategoryEN objJournalSubjectCategoryEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (string.IsNullOrEmpty(objJournalSubjectCategoryEN.JournalSubjectCategoryId) == true)
 {
string strMsg = string.Format("(errid:Busi000087)修改记录时关键字不能为空!(带事务处理)(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsJournalSubjectCategoryBL.JournalSubjectCategoryDA.UpdateBySql2(objJournalSubjectCategoryEN, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsJournalSubjectCategoryBL.ReFreshCache();

if (clsJournalSubjectCategoryBL.relatedActions != null)
{
clsJournalSubjectCategoryBL.relatedActions.UpdRelaTabDate(objJournalSubjectCategoryEN.JournalSubjectCategoryId, objJournalSubjectCategoryEN.UpdUser);
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
 /// <param name = "objJournalSubjectCategoryEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsJournalSubjectCategoryEN objJournalSubjectCategoryEN, string strWhereCond)
{
try
{
bool bolResult = clsJournalSubjectCategoryBL.JournalSubjectCategoryDA.UpdateBySqlWithCondition(objJournalSubjectCategoryEN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsJournalSubjectCategoryBL.ReFreshCache();

if (clsJournalSubjectCategoryBL.relatedActions != null)
{
clsJournalSubjectCategoryBL.relatedActions.UpdRelaTabDate(objJournalSubjectCategoryEN.JournalSubjectCategoryId, objJournalSubjectCategoryEN.UpdUser);
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
 /// <param name = "objJournalSubjectCategoryEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsJournalSubjectCategoryEN objJournalSubjectCategoryEN, string strWhereCond, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
bool bolResult = clsJournalSubjectCategoryBL.JournalSubjectCategoryDA.UpdateBySqlWithConditionTransaction(objJournalSubjectCategoryEN, strWhereCond, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsJournalSubjectCategoryBL.ReFreshCache();

if (clsJournalSubjectCategoryBL.relatedActions != null)
{
clsJournalSubjectCategoryBL.relatedActions.UpdRelaTabDate(objJournalSubjectCategoryEN.JournalSubjectCategoryId, objJournalSubjectCategoryEN.UpdUser);
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
 /// <param name = "strJournalSubjectCategoryId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int Delete(this clsJournalSubjectCategoryEN objJournalSubjectCategoryEN)
{
try
{
int intRecNum = clsJournalSubjectCategoryBL.JournalSubjectCategoryDA.DelRecord(objJournalSubjectCategoryEN.JournalSubjectCategoryId);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsJournalSubjectCategoryBL.ReFreshCache();

if (clsJournalSubjectCategoryBL.relatedActions != null)
{
clsJournalSubjectCategoryBL.relatedActions.UpdRelaTabDate(objJournalSubjectCategoryEN.JournalSubjectCategoryId, objJournalSubjectCategoryEN.UpdUser);
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
 /// <param name = "objJournalSubjectCategoryENS">源对象</param>
 /// <param name = "objJournalSubjectCategoryENT">目标对象</param>
 public static void CopyTo(this clsJournalSubjectCategoryEN objJournalSubjectCategoryENS, clsJournalSubjectCategoryEN objJournalSubjectCategoryENT)
{
try
{
objJournalSubjectCategoryENT.JournalSubjectCategoryId = objJournalSubjectCategoryENS.JournalSubjectCategoryId; //期刊学科门类Id
objJournalSubjectCategoryENT.JournalSubjectCategoryName = objJournalSubjectCategoryENS.JournalSubjectCategoryName; //期刊学科门类名称
objJournalSubjectCategoryENT.UpdDate = objJournalSubjectCategoryENS.UpdDate; //修改日期
objJournalSubjectCategoryENT.UpdUser = objJournalSubjectCategoryENS.UpdUser; //修改人
objJournalSubjectCategoryENT.Memo = objJournalSubjectCategoryENS.Memo; //备注
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
 /// <param name = "objJournalSubjectCategoryENS">源对象</param>
 /// <returns>目标对象=>clsJournalSubjectCategoryEN:objJournalSubjectCategoryENT</returns>
 public static clsJournalSubjectCategoryEN CopyTo(this clsJournalSubjectCategoryEN objJournalSubjectCategoryENS)
{
try
{
 clsJournalSubjectCategoryEN objJournalSubjectCategoryENT = new clsJournalSubjectCategoryEN()
{
JournalSubjectCategoryId = objJournalSubjectCategoryENS.JournalSubjectCategoryId, //期刊学科门类Id
JournalSubjectCategoryName = objJournalSubjectCategoryENS.JournalSubjectCategoryName, //期刊学科门类名称
UpdDate = objJournalSubjectCategoryENS.UpdDate, //修改日期
UpdUser = objJournalSubjectCategoryENS.UpdUser, //修改人
Memo = objJournalSubjectCategoryENS.Memo, //备注
};
 return objJournalSubjectCategoryENT;
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
public static void CheckPropertyNew(this clsJournalSubjectCategoryEN objJournalSubjectCategoryEN)
{
 clsJournalSubjectCategoryBL.JournalSubjectCategoryDA.CheckPropertyNew(objJournalSubjectCategoryEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(this clsJournalSubjectCategoryEN objJournalSubjectCategoryEN)
{
 clsJournalSubjectCategoryBL.JournalSubjectCategoryDA.CheckProperty4Condition(objJournalSubjectCategoryEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsJournalSubjectCategoryEN objJournalSubjectCategoryCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objJournalSubjectCategoryCond.IsUpdated(conJournalSubjectCategory.JournalSubjectCategoryId) == true)
{
string strComparisonOpJournalSubjectCategoryId = objJournalSubjectCategoryCond.dicFldComparisonOp[conJournalSubjectCategory.JournalSubjectCategoryId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conJournalSubjectCategory.JournalSubjectCategoryId, objJournalSubjectCategoryCond.JournalSubjectCategoryId, strComparisonOpJournalSubjectCategoryId);
}
if (objJournalSubjectCategoryCond.IsUpdated(conJournalSubjectCategory.JournalSubjectCategoryName) == true)
{
string strComparisonOpJournalSubjectCategoryName = objJournalSubjectCategoryCond.dicFldComparisonOp[conJournalSubjectCategory.JournalSubjectCategoryName];
strWhereCond += string.Format(" And {0} {2} '{1}'", conJournalSubjectCategory.JournalSubjectCategoryName, objJournalSubjectCategoryCond.JournalSubjectCategoryName, strComparisonOpJournalSubjectCategoryName);
}
if (objJournalSubjectCategoryCond.IsUpdated(conJournalSubjectCategory.UpdDate) == true)
{
string strComparisonOpUpdDate = objJournalSubjectCategoryCond.dicFldComparisonOp[conJournalSubjectCategory.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conJournalSubjectCategory.UpdDate, objJournalSubjectCategoryCond.UpdDate, strComparisonOpUpdDate);
}
if (objJournalSubjectCategoryCond.IsUpdated(conJournalSubjectCategory.UpdUser) == true)
{
string strComparisonOpUpdUser = objJournalSubjectCategoryCond.dicFldComparisonOp[conJournalSubjectCategory.UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", conJournalSubjectCategory.UpdUser, objJournalSubjectCategoryCond.UpdUser, strComparisonOpUpdUser);
}
if (objJournalSubjectCategoryCond.IsUpdated(conJournalSubjectCategory.Memo) == true)
{
string strComparisonOpMemo = objJournalSubjectCategoryCond.dicFldComparisonOp[conJournalSubjectCategory.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", conJournalSubjectCategory.Memo, objJournalSubjectCategoryCond.Memo, strComparisonOpMemo);
}
 return strWhereCond;
}

 /// <summary>
 /// 检查唯一性(Uniqueness)--JournalSubjectCategory(期刊学科门类), 如果不唯一,即存在相同的记录,就返回False
 /// 唯一性条件:JournalSubjectCategoryName
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckConstraint)
 /// </summary>
 /// <param name = "objJournalSubjectCategoryEN">要求唯一的对象</param>
 /// <returns></returns>
public static bool CheckUniqueness(this clsJournalSubjectCategoryEN objJournalSubjectCategoryEN)
{
//检测记录是否存在
bool bolIsUniqueness;
StringBuilder sbCondition = new StringBuilder();
if (objJournalSubjectCategoryEN == null) return true;
if (objJournalSubjectCategoryEN.JournalSubjectCategoryId == null || objJournalSubjectCategoryEN.JournalSubjectCategoryId == "")
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and JournalSubjectCategoryName = '{0}'", objJournalSubjectCategoryEN.JournalSubjectCategoryName);
if (clsJournalSubjectCategoryBL.IsExistRecord(sbCondition.ToString())  ==  true)
{
 bolIsUniqueness = false;
}
else
{
 bolIsUniqueness = true;
}
}
 else {
sbCondition.AppendFormat("JournalSubjectCategoryId !=  '{0}'", objJournalSubjectCategoryEN.JournalSubjectCategoryId);
 sbCondition.AppendFormat(" and JournalSubjectCategoryName = '{0}'", objJournalSubjectCategoryEN.JournalSubjectCategoryName);
if (clsJournalSubjectCategoryBL.IsExistRecord(sbCondition.ToString())  ==  true)
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
 /// 获取唯一性条件串--JournalSubjectCategory(期刊学科门类), 即由对象中唯一性条件字段关键字与值组成的条件串
 /// 唯一性条件:JournalSubjectCategoryName
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetConditionString4Constraint)
 /// </summary>
 /// <param name = "objJournalSubjectCategoryEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(this clsJournalSubjectCategoryEN objJournalSubjectCategoryEN)
{
//检测记录是否存在
StringBuilder sbCondition = new StringBuilder();
if (objJournalSubjectCategoryEN == null) return "";
if (objJournalSubjectCategoryEN.JournalSubjectCategoryId == null || objJournalSubjectCategoryEN.JournalSubjectCategoryId == "")
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and JournalSubjectCategoryName = '{0}'", objJournalSubjectCategoryEN.JournalSubjectCategoryName);
return sbCondition.ToString();
}
 else {
sbCondition.AppendFormat("JournalSubjectCategoryId !=  '{0}'", objJournalSubjectCategoryEN.JournalSubjectCategoryId);
 sbCondition.AppendFormat(" and JournalSubjectCategoryName = '{0}'", objJournalSubjectCategoryEN.JournalSubjectCategoryName);
 return sbCondition.ToString();
}
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_JournalSubjectCategory
{
public virtual bool UpdRelaTabDate(string strJournalSubjectCategoryId, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// 期刊学科门类(JournalSubjectCategory)
 /// 数据源类型:表
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsJournalSubjectCategoryBL
{
public static RelatedActions_JournalSubjectCategory relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsJournalSubjectCategoryDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsJournalSubjectCategoryDA JournalSubjectCategoryDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsJournalSubjectCategoryDA();
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
 public clsJournalSubjectCategoryBL()
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
if (string.IsNullOrEmpty(clsJournalSubjectCategoryEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsJournalSubjectCategoryEN._ConnectString);
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
public static DataTable GetDataTable_JournalSubjectCategory(string strWhereCond)
{
DataTable objDT;
try
{
objDT = JournalSubjectCategoryDA.GetDataTable_JournalSubjectCategory(strWhereCond);
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
objDT = JournalSubjectCategoryDA.GetDataTable(strWhereCond);
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
objDT = JournalSubjectCategoryDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = JournalSubjectCategoryDA.GetDataTable(strWhereCond, strTabName);
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
objDT = JournalSubjectCategoryDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = JournalSubjectCategoryDA.GetDataTable_Top(objTopPara);
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
objDT = JournalSubjectCategoryDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = JournalSubjectCategoryDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = JournalSubjectCategoryDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
 /// <param name = "arrJournalSubjectCategoryIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static List<clsJournalSubjectCategoryEN> GetObjLstByJournalSubjectCategoryIdLst(List<string> arrJournalSubjectCategoryIdLst)
{
List<clsJournalSubjectCategoryEN> arrObjLst = new List<clsJournalSubjectCategoryEN>(); 
System.Data.DataTable objDT; 
 string strSqlConditionStr = clsArray.GetSqlInStrByArray(arrJournalSubjectCategoryIdLst, true);
 string strWhereCond = string.Format("JournalSubjectCategoryId in ({0})", strSqlConditionStr);
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsJournalSubjectCategoryEN objJournalSubjectCategoryEN = new clsJournalSubjectCategoryEN();
try
{
objJournalSubjectCategoryEN.JournalSubjectCategoryId = objRow[conJournalSubjectCategory.JournalSubjectCategoryId].ToString().Trim(); //期刊学科门类Id
objJournalSubjectCategoryEN.JournalSubjectCategoryName = objRow[conJournalSubjectCategory.JournalSubjectCategoryName].ToString().Trim(); //期刊学科门类名称
objJournalSubjectCategoryEN.UpdDate = objRow[conJournalSubjectCategory.UpdDate] == DBNull.Value ? null : objRow[conJournalSubjectCategory.UpdDate].ToString().Trim(); //修改日期
objJournalSubjectCategoryEN.UpdUser = objRow[conJournalSubjectCategory.UpdUser] == DBNull.Value ? null : objRow[conJournalSubjectCategory.UpdUser].ToString().Trim(); //修改人
objJournalSubjectCategoryEN.Memo = objRow[conJournalSubjectCategory.Memo] == DBNull.Value ? null : objRow[conJournalSubjectCategory.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objJournalSubjectCategoryEN.JournalSubjectCategoryId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objJournalSubjectCategoryEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrJournalSubjectCategoryIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsJournalSubjectCategoryEN> GetObjLstByJournalSubjectCategoryIdLstCache(List<string> arrJournalSubjectCategoryIdLst)
{
string strKey = string.Format("{0}", clsJournalSubjectCategoryEN._CurrTabName);
List<clsJournalSubjectCategoryEN> arrJournalSubjectCategoryObjLstCache = GetObjLstCache();
IEnumerable <clsJournalSubjectCategoryEN> arrJournalSubjectCategoryObjLst_Sel =
arrJournalSubjectCategoryObjLstCache
.Where(x => arrJournalSubjectCategoryIdLst.Contains(x.JournalSubjectCategoryId));
return arrJournalSubjectCategoryObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsJournalSubjectCategoryEN> GetObjLst(string strWhereCond)
{
List<clsJournalSubjectCategoryEN> arrObjLst = new List<clsJournalSubjectCategoryEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsJournalSubjectCategoryEN objJournalSubjectCategoryEN = new clsJournalSubjectCategoryEN();
try
{
objJournalSubjectCategoryEN.JournalSubjectCategoryId = objRow[conJournalSubjectCategory.JournalSubjectCategoryId].ToString().Trim(); //期刊学科门类Id
objJournalSubjectCategoryEN.JournalSubjectCategoryName = objRow[conJournalSubjectCategory.JournalSubjectCategoryName].ToString().Trim(); //期刊学科门类名称
objJournalSubjectCategoryEN.UpdDate = objRow[conJournalSubjectCategory.UpdDate] == DBNull.Value ? null : objRow[conJournalSubjectCategory.UpdDate].ToString().Trim(); //修改日期
objJournalSubjectCategoryEN.UpdUser = objRow[conJournalSubjectCategory.UpdUser] == DBNull.Value ? null : objRow[conJournalSubjectCategory.UpdUser].ToString().Trim(); //修改人
objJournalSubjectCategoryEN.Memo = objRow[conJournalSubjectCategory.Memo] == DBNull.Value ? null : objRow[conJournalSubjectCategory.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objJournalSubjectCategoryEN.JournalSubjectCategoryId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objJournalSubjectCategoryEN);
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
public static List<clsJournalSubjectCategoryEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsJournalSubjectCategoryEN> arrObjLst = new List<clsJournalSubjectCategoryEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsJournalSubjectCategoryEN objJournalSubjectCategoryEN = new clsJournalSubjectCategoryEN();
try
{
objJournalSubjectCategoryEN.JournalSubjectCategoryId = objRow[conJournalSubjectCategory.JournalSubjectCategoryId].ToString().Trim(); //期刊学科门类Id
objJournalSubjectCategoryEN.JournalSubjectCategoryName = objRow[conJournalSubjectCategory.JournalSubjectCategoryName].ToString().Trim(); //期刊学科门类名称
objJournalSubjectCategoryEN.UpdDate = objRow[conJournalSubjectCategory.UpdDate] == DBNull.Value ? null : objRow[conJournalSubjectCategory.UpdDate].ToString().Trim(); //修改日期
objJournalSubjectCategoryEN.UpdUser = objRow[conJournalSubjectCategory.UpdUser] == DBNull.Value ? null : objRow[conJournalSubjectCategory.UpdUser].ToString().Trim(); //修改人
objJournalSubjectCategoryEN.Memo = objRow[conJournalSubjectCategory.Memo] == DBNull.Value ? null : objRow[conJournalSubjectCategory.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objJournalSubjectCategoryEN.JournalSubjectCategoryId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objJournalSubjectCategoryEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objJournalSubjectCategoryCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsJournalSubjectCategoryEN> GetSubObjLstCache(clsJournalSubjectCategoryEN objJournalSubjectCategoryCond)
{
List<clsJournalSubjectCategoryEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsJournalSubjectCategoryEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conJournalSubjectCategory.AttributeName)
{
if (objJournalSubjectCategoryCond.IsUpdated(strFldName) == false) continue;
if (objJournalSubjectCategoryCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objJournalSubjectCategoryCond[strFldName].ToString());
}
else
{
if (objJournalSubjectCategoryCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objJournalSubjectCategoryCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objJournalSubjectCategoryCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objJournalSubjectCategoryCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objJournalSubjectCategoryCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objJournalSubjectCategoryCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objJournalSubjectCategoryCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objJournalSubjectCategoryCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objJournalSubjectCategoryCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objJournalSubjectCategoryCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objJournalSubjectCategoryCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objJournalSubjectCategoryCond[strFldName]));
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
public static List<clsJournalSubjectCategoryEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsJournalSubjectCategoryEN> arrObjLst = new List<clsJournalSubjectCategoryEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsJournalSubjectCategoryEN objJournalSubjectCategoryEN = new clsJournalSubjectCategoryEN();
try
{
objJournalSubjectCategoryEN.JournalSubjectCategoryId = objRow[conJournalSubjectCategory.JournalSubjectCategoryId].ToString().Trim(); //期刊学科门类Id
objJournalSubjectCategoryEN.JournalSubjectCategoryName = objRow[conJournalSubjectCategory.JournalSubjectCategoryName].ToString().Trim(); //期刊学科门类名称
objJournalSubjectCategoryEN.UpdDate = objRow[conJournalSubjectCategory.UpdDate] == DBNull.Value ? null : objRow[conJournalSubjectCategory.UpdDate].ToString().Trim(); //修改日期
objJournalSubjectCategoryEN.UpdUser = objRow[conJournalSubjectCategory.UpdUser] == DBNull.Value ? null : objRow[conJournalSubjectCategory.UpdUser].ToString().Trim(); //修改人
objJournalSubjectCategoryEN.Memo = objRow[conJournalSubjectCategory.Memo] == DBNull.Value ? null : objRow[conJournalSubjectCategory.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objJournalSubjectCategoryEN.JournalSubjectCategoryId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objJournalSubjectCategoryEN);
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
public static List<clsJournalSubjectCategoryEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsJournalSubjectCategoryEN> arrObjLst = new List<clsJournalSubjectCategoryEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsJournalSubjectCategoryEN objJournalSubjectCategoryEN = new clsJournalSubjectCategoryEN();
try
{
objJournalSubjectCategoryEN.JournalSubjectCategoryId = objRow[conJournalSubjectCategory.JournalSubjectCategoryId].ToString().Trim(); //期刊学科门类Id
objJournalSubjectCategoryEN.JournalSubjectCategoryName = objRow[conJournalSubjectCategory.JournalSubjectCategoryName].ToString().Trim(); //期刊学科门类名称
objJournalSubjectCategoryEN.UpdDate = objRow[conJournalSubjectCategory.UpdDate] == DBNull.Value ? null : objRow[conJournalSubjectCategory.UpdDate].ToString().Trim(); //修改日期
objJournalSubjectCategoryEN.UpdUser = objRow[conJournalSubjectCategory.UpdUser] == DBNull.Value ? null : objRow[conJournalSubjectCategory.UpdUser].ToString().Trim(); //修改人
objJournalSubjectCategoryEN.Memo = objRow[conJournalSubjectCategory.Memo] == DBNull.Value ? null : objRow[conJournalSubjectCategory.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objJournalSubjectCategoryEN.JournalSubjectCategoryId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objJournalSubjectCategoryEN);
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
List<clsJournalSubjectCategoryEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsJournalSubjectCategoryEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsJournalSubjectCategoryEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsJournalSubjectCategoryEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsJournalSubjectCategoryEN> arrObjLst = new List<clsJournalSubjectCategoryEN>(); 
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
	clsJournalSubjectCategoryEN objJournalSubjectCategoryEN = new clsJournalSubjectCategoryEN();
try
{
objJournalSubjectCategoryEN.JournalSubjectCategoryId = objRow[conJournalSubjectCategory.JournalSubjectCategoryId].ToString().Trim(); //期刊学科门类Id
objJournalSubjectCategoryEN.JournalSubjectCategoryName = objRow[conJournalSubjectCategory.JournalSubjectCategoryName].ToString().Trim(); //期刊学科门类名称
objJournalSubjectCategoryEN.UpdDate = objRow[conJournalSubjectCategory.UpdDate] == DBNull.Value ? null : objRow[conJournalSubjectCategory.UpdDate].ToString().Trim(); //修改日期
objJournalSubjectCategoryEN.UpdUser = objRow[conJournalSubjectCategory.UpdUser] == DBNull.Value ? null : objRow[conJournalSubjectCategory.UpdUser].ToString().Trim(); //修改人
objJournalSubjectCategoryEN.Memo = objRow[conJournalSubjectCategory.Memo] == DBNull.Value ? null : objRow[conJournalSubjectCategory.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objJournalSubjectCategoryEN.JournalSubjectCategoryId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objJournalSubjectCategoryEN);
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
public static List<clsJournalSubjectCategoryEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsJournalSubjectCategoryEN> arrObjLst = new List<clsJournalSubjectCategoryEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsJournalSubjectCategoryEN objJournalSubjectCategoryEN = new clsJournalSubjectCategoryEN();
try
{
objJournalSubjectCategoryEN.JournalSubjectCategoryId = objRow[conJournalSubjectCategory.JournalSubjectCategoryId].ToString().Trim(); //期刊学科门类Id
objJournalSubjectCategoryEN.JournalSubjectCategoryName = objRow[conJournalSubjectCategory.JournalSubjectCategoryName].ToString().Trim(); //期刊学科门类名称
objJournalSubjectCategoryEN.UpdDate = objRow[conJournalSubjectCategory.UpdDate] == DBNull.Value ? null : objRow[conJournalSubjectCategory.UpdDate].ToString().Trim(); //修改日期
objJournalSubjectCategoryEN.UpdUser = objRow[conJournalSubjectCategory.UpdUser] == DBNull.Value ? null : objRow[conJournalSubjectCategory.UpdUser].ToString().Trim(); //修改人
objJournalSubjectCategoryEN.Memo = objRow[conJournalSubjectCategory.Memo] == DBNull.Value ? null : objRow[conJournalSubjectCategory.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objJournalSubjectCategoryEN.JournalSubjectCategoryId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objJournalSubjectCategoryEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsJournalSubjectCategoryEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsJournalSubjectCategoryEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsJournalSubjectCategoryEN> arrObjLst = new List<clsJournalSubjectCategoryEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsJournalSubjectCategoryEN objJournalSubjectCategoryEN = new clsJournalSubjectCategoryEN();
try
{
objJournalSubjectCategoryEN.JournalSubjectCategoryId = objRow[conJournalSubjectCategory.JournalSubjectCategoryId].ToString().Trim(); //期刊学科门类Id
objJournalSubjectCategoryEN.JournalSubjectCategoryName = objRow[conJournalSubjectCategory.JournalSubjectCategoryName].ToString().Trim(); //期刊学科门类名称
objJournalSubjectCategoryEN.UpdDate = objRow[conJournalSubjectCategory.UpdDate] == DBNull.Value ? null : objRow[conJournalSubjectCategory.UpdDate].ToString().Trim(); //修改日期
objJournalSubjectCategoryEN.UpdUser = objRow[conJournalSubjectCategory.UpdUser] == DBNull.Value ? null : objRow[conJournalSubjectCategory.UpdUser].ToString().Trim(); //修改人
objJournalSubjectCategoryEN.Memo = objRow[conJournalSubjectCategory.Memo] == DBNull.Value ? null : objRow[conJournalSubjectCategory.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objJournalSubjectCategoryEN.JournalSubjectCategoryId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objJournalSubjectCategoryEN);
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
public static List<clsJournalSubjectCategoryEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsJournalSubjectCategoryEN> arrObjLst = new List<clsJournalSubjectCategoryEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsJournalSubjectCategoryEN objJournalSubjectCategoryEN = new clsJournalSubjectCategoryEN();
try
{
objJournalSubjectCategoryEN.JournalSubjectCategoryId = objRow[conJournalSubjectCategory.JournalSubjectCategoryId].ToString().Trim(); //期刊学科门类Id
objJournalSubjectCategoryEN.JournalSubjectCategoryName = objRow[conJournalSubjectCategory.JournalSubjectCategoryName].ToString().Trim(); //期刊学科门类名称
objJournalSubjectCategoryEN.UpdDate = objRow[conJournalSubjectCategory.UpdDate] == DBNull.Value ? null : objRow[conJournalSubjectCategory.UpdDate].ToString().Trim(); //修改日期
objJournalSubjectCategoryEN.UpdUser = objRow[conJournalSubjectCategory.UpdUser] == DBNull.Value ? null : objRow[conJournalSubjectCategory.UpdUser].ToString().Trim(); //修改人
objJournalSubjectCategoryEN.Memo = objRow[conJournalSubjectCategory.Memo] == DBNull.Value ? null : objRow[conJournalSubjectCategory.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objJournalSubjectCategoryEN.JournalSubjectCategoryId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objJournalSubjectCategoryEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsJournalSubjectCategoryEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsJournalSubjectCategoryEN> arrObjLst = new List<clsJournalSubjectCategoryEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsJournalSubjectCategoryEN objJournalSubjectCategoryEN = new clsJournalSubjectCategoryEN();
try
{
objJournalSubjectCategoryEN.JournalSubjectCategoryId = objRow[conJournalSubjectCategory.JournalSubjectCategoryId].ToString().Trim(); //期刊学科门类Id
objJournalSubjectCategoryEN.JournalSubjectCategoryName = objRow[conJournalSubjectCategory.JournalSubjectCategoryName].ToString().Trim(); //期刊学科门类名称
objJournalSubjectCategoryEN.UpdDate = objRow[conJournalSubjectCategory.UpdDate] == DBNull.Value ? null : objRow[conJournalSubjectCategory.UpdDate].ToString().Trim(); //修改日期
objJournalSubjectCategoryEN.UpdUser = objRow[conJournalSubjectCategory.UpdUser] == DBNull.Value ? null : objRow[conJournalSubjectCategory.UpdUser].ToString().Trim(); //修改人
objJournalSubjectCategoryEN.Memo = objRow[conJournalSubjectCategory.Memo] == DBNull.Value ? null : objRow[conJournalSubjectCategory.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objJournalSubjectCategoryEN.JournalSubjectCategoryId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objJournalSubjectCategoryEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objJournalSubjectCategoryEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetJournalSubjectCategory(ref clsJournalSubjectCategoryEN objJournalSubjectCategoryEN)
{
bool bolResult = JournalSubjectCategoryDA.GetJournalSubjectCategory(ref objJournalSubjectCategoryEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "strJournalSubjectCategoryId">表关键字</param>
 /// <returns>表对象</returns>
public static clsJournalSubjectCategoryEN GetObjByJournalSubjectCategoryId(string strJournalSubjectCategoryId)
{
if (strJournalSubjectCategoryId.IndexOf(' ') >=0)
{
var strMsg = string.Format("(errid:Busi000079)在表中,关键字[strJournalSubjectCategoryId]中不能有空格!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
if (string.IsNullOrEmpty(strJournalSubjectCategoryId) == true)
{
var strMsg = string.Format("(errid:Busi000020)在表中,关键字[strJournalSubjectCategoryId]不能为空!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
clsJournalSubjectCategoryEN objJournalSubjectCategoryEN = JournalSubjectCategoryDA.GetObjByJournalSubjectCategoryId(strJournalSubjectCategoryId);
return objJournalSubjectCategoryEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsJournalSubjectCategoryEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsJournalSubjectCategoryEN objJournalSubjectCategoryEN = JournalSubjectCategoryDA.GetFirstObj(strWhereCond);
 return objJournalSubjectCategoryEN;
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
public static clsJournalSubjectCategoryEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsJournalSubjectCategoryEN objJournalSubjectCategoryEN = JournalSubjectCategoryDA.GetObjByDataRow(objRow);
 return objJournalSubjectCategoryEN;
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
public static clsJournalSubjectCategoryEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsJournalSubjectCategoryEN objJournalSubjectCategoryEN = JournalSubjectCategoryDA.GetObjByDataRow(objRow);
 return objJournalSubjectCategoryEN;
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
 /// <param name = "strJournalSubjectCategoryId">所给的关键字</param>
 /// <param name = "lstJournalSubjectCategoryObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsJournalSubjectCategoryEN GetObjByJournalSubjectCategoryIdFromList(string strJournalSubjectCategoryId, List<clsJournalSubjectCategoryEN> lstJournalSubjectCategoryObjLst)
{
foreach (clsJournalSubjectCategoryEN objJournalSubjectCategoryEN in lstJournalSubjectCategoryObjLst)
{
if (objJournalSubjectCategoryEN.JournalSubjectCategoryId == strJournalSubjectCategoryId)
{
return objJournalSubjectCategoryEN;
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
 string strMaxJournalSubjectCategoryId;
 try
 {
 strMaxJournalSubjectCategoryId = clsJournalSubjectCategoryDA.GetMaxStrId();
 return strMaxJournalSubjectCategoryId;
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
 string strJournalSubjectCategoryId;
 try
 {
 strJournalSubjectCategoryId = new clsJournalSubjectCategoryDA().GetFirstID(strWhereCond);
 return strJournalSubjectCategoryId;
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
 arrList = JournalSubjectCategoryDA.GetID(strWhereCond);
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
bool bolIsExist = JournalSubjectCategoryDA.IsExistCondRec(strWhereCond);
return bolIsExist;
}

 /// <summary>
 /// 判断当前表中是否存在给定关键字值的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExist)
 /// </summary>
 /// <param name = "strJournalSubjectCategoryId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public static bool IsExist(string strJournalSubjectCategoryId)
{
if (string.IsNullOrEmpty(strJournalSubjectCategoryId) == true)
{
var strMsg = string.Format("(errid:Busi000027)在表中,关键字[strJournalSubjectCategoryId]不能为空!!(from {0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
//检测记录是否存在
bool bolIsExist = JournalSubjectCategoryDA.IsExist(strJournalSubjectCategoryId);
return bolIsExist;
}

/// <summary>
/// 设置修改时间
/// </summary>
/// <param name = "strJournalSubjectCategoryId">期刊学科门类Id</param>
/// <param name = "strOpUser">修改用户</param>
/// <returns>是否成功？</returns>
public static bool SetUpdDate(string strJournalSubjectCategoryId, string strOpUser)
{
clsJournalSubjectCategoryEN objJournalSubjectCategoryEN = clsJournalSubjectCategoryBL.GetObjByJournalSubjectCategoryId(strJournalSubjectCategoryId);
objJournalSubjectCategoryEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
objJournalSubjectCategoryEN.UpdUser = strOpUser;
return clsJournalSubjectCategoryBL.UpdateBySql2(objJournalSubjectCategoryEN);
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
 bolIsExist = clsJournalSubjectCategoryDA.IsExistTable();
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
 bolIsExist = JournalSubjectCategoryDA.IsExistTable(strTabName);
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
 /// <param name = "objJournalSubjectCategoryEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecordBySql2(clsJournalSubjectCategoryEN objJournalSubjectCategoryEN, bool bolIsNeedCheckUniqueness=true)
{
if (bolIsNeedCheckUniqueness == true && objJournalSubjectCategoryEN.CheckUniqueness() == false)
{
var strMsg = string.Format("记录已经存在!期刊学科门类名称 = [{0}]的数据已经存在!(in clsJournalSubjectCategoryBL.AddNewRecordBySql2)", objJournalSubjectCategoryEN.JournalSubjectCategoryName);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objJournalSubjectCategoryEN.JournalSubjectCategoryId) == true || clsJournalSubjectCategoryBL.IsExist(objJournalSubjectCategoryEN.JournalSubjectCategoryId) == true)
 {
     objJournalSubjectCategoryEN.JournalSubjectCategoryId = clsJournalSubjectCategoryBL.GetMaxStrId_S();
 }
bool bolResult = JournalSubjectCategoryDA.AddNewRecordBySQL2(objJournalSubjectCategoryEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsJournalSubjectCategoryBL.ReFreshCache();

if (clsJournalSubjectCategoryBL.relatedActions != null)
{
clsJournalSubjectCategoryBL.relatedActions.UpdRelaTabDate(objJournalSubjectCategoryEN.JournalSubjectCategoryId, objJournalSubjectCategoryEN.UpdUser);
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
 /// <param name = "objJournalSubjectCategoryEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordBySql2WithReturnKey(clsJournalSubjectCategoryEN objJournalSubjectCategoryEN, bool bolIsNeedCheckUniqueness=true)
{
if (bolIsNeedCheckUniqueness == true && objJournalSubjectCategoryEN.CheckUniqueness() == false)
{
var strMsg = string.Format("记录已经存在!期刊学科门类名称 = [{0}]的数据已经存在!(in clsJournalSubjectCategoryBL.AddNewRecordBySql2WithReturnKey)", objJournalSubjectCategoryEN.JournalSubjectCategoryName);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objJournalSubjectCategoryEN.JournalSubjectCategoryId) == true || clsJournalSubjectCategoryBL.IsExist(objJournalSubjectCategoryEN.JournalSubjectCategoryId) == true)
 {
     objJournalSubjectCategoryEN.JournalSubjectCategoryId = clsJournalSubjectCategoryBL.GetMaxStrId_S();
 }
string strKey = JournalSubjectCategoryDA.AddNewRecordBySQL2WithReturnKey(objJournalSubjectCategoryEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsJournalSubjectCategoryBL.ReFreshCache();

if (clsJournalSubjectCategoryBL.relatedActions != null)
{
clsJournalSubjectCategoryBL.relatedActions.UpdRelaTabDate(objJournalSubjectCategoryEN.JournalSubjectCategoryId, objJournalSubjectCategoryEN.UpdUser);
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
 /// <param name = "objJournalSubjectCategoryEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(clsJournalSubjectCategoryEN objJournalSubjectCategoryEN)
{
try
{
bool bolResult = JournalSubjectCategoryDA.Update(objJournalSubjectCategoryEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsJournalSubjectCategoryBL.ReFreshCache();

if (clsJournalSubjectCategoryBL.relatedActions != null)
{
clsJournalSubjectCategoryBL.relatedActions.UpdRelaTabDate(objJournalSubjectCategoryEN.JournalSubjectCategoryId, objJournalSubjectCategoryEN.UpdUser);
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
 /// <param name = "objJournalSubjectCategoryEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateBySql2(clsJournalSubjectCategoryEN objJournalSubjectCategoryEN)
{
 if (string.IsNullOrEmpty(objJournalSubjectCategoryEN.JournalSubjectCategoryId) == true)
 {
var strMsg = string.Format("(errid:Busi000065)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = JournalSubjectCategoryDA.UpdateBySql2(objJournalSubjectCategoryEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsJournalSubjectCategoryBL.ReFreshCache();

if (clsJournalSubjectCategoryBL.relatedActions != null)
{
clsJournalSubjectCategoryBL.relatedActions.UpdRelaTabDate(objJournalSubjectCategoryEN.JournalSubjectCategoryId, objJournalSubjectCategoryEN.UpdUser);
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
 /// <param name = "strJournalSubjectCategoryId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int DelRecord(string strJournalSubjectCategoryId)
{
try
{
 clsJournalSubjectCategoryEN objJournalSubjectCategoryEN = clsJournalSubjectCategoryBL.GetObjByJournalSubjectCategoryId(strJournalSubjectCategoryId);

if (clsJournalSubjectCategoryBL.relatedActions != null)
{
clsJournalSubjectCategoryBL.relatedActions.UpdRelaTabDate(objJournalSubjectCategoryEN.JournalSubjectCategoryId, objJournalSubjectCategoryEN.UpdUser);
}
if (objJournalSubjectCategoryEN != null)
{
int intRecNum = JournalSubjectCategoryDA.DelRecord(strJournalSubjectCategoryId);
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
/// <param name="strJournalSubjectCategoryId">表关键字</param>
/// <returns></returns>
public static bool DelRecordEx(string strJournalSubjectCategoryId )
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsJournalSubjectCategoryDA.GetSpecSQLObj();
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
//删除与表:[JournalSubjectCategory]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conJournalSubjectCategory.JournalSubjectCategoryId,
//strJournalSubjectCategoryId);
//        clsJournalSubjectCategoryBL.DelJournalSubjectCategorysByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsJournalSubjectCategoryBL.DelRecord(strJournalSubjectCategoryId, objConnection, objSqlTransaction);
objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsJournalSubjectCategoryBLEx", "DelRecordEx", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("扩展删除记录出错:{0}!keyId = {1}.({2})",
objException.Message,
strJournalSubjectCategoryId, clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "strJournalSubjectCategoryId">给定的关键字值</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回删除是否成功?</returns>
public static bool DelRecord(string strJournalSubjectCategoryId, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
if (clsJournalSubjectCategoryBL.relatedActions != null)
{
clsJournalSubjectCategoryBL.relatedActions.UpdRelaTabDate(strJournalSubjectCategoryId, "UpdRelaTabDate");
}
bool bolResult = JournalSubjectCategoryDA.DelRecord(strJournalSubjectCategoryId,objSqlConnection,objSqlTransaction);
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
 /// <param name = "arrJournalSubjectCategoryIdLst">给定的关键字值列表</param>
 /// <returns>返回删除的记录数</returns>
public static int DelJournalSubjectCategorys(List<string> arrJournalSubjectCategoryIdLst)
{
if (arrJournalSubjectCategoryIdLst.Count == 0) return 0;
try
{
if (clsJournalSubjectCategoryBL.relatedActions != null)
{
foreach (var strJournalSubjectCategoryId in arrJournalSubjectCategoryIdLst)
{
clsJournalSubjectCategoryBL.relatedActions.UpdRelaTabDate(strJournalSubjectCategoryId, "UpdRelaTabDate");
}
}
int intDelRecNum = JournalSubjectCategoryDA.DelJournalSubjectCategory(arrJournalSubjectCategoryIdLst);
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
public static int DelJournalSubjectCategorysByCond(string strWhereCond)
{
try
{
if (clsJournalSubjectCategoryBL.relatedActions != null)
{
List<string> arrJournalSubjectCategoryId = GetPrimaryKeyID_S(strWhereCond);
foreach (var strJournalSubjectCategoryId in arrJournalSubjectCategoryId)
{
clsJournalSubjectCategoryBL.relatedActions.UpdRelaTabDate(strJournalSubjectCategoryId, "UpdRelaTabDate");
}
}
int intRecNum = JournalSubjectCategoryDA.DelJournalSubjectCategory(strWhereCond);
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
/// 这里仅仅是演示函数,使用时请复制到扩展类:[JournalSubjectCategory]中改名为:[DelRecord4MultiTabEx]使用
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DelRecord4MultiTab)
/// </summary>
/// <param name="strJournalSubjectCategoryId">表关键字</param>
/// <returns></returns>
public static bool DelRecord4MultiTab(string strJournalSubjectCategoryId)
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsJournalSubjectCategoryDA.GetSpecSQLObj();
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
//删除与表:[JournalSubjectCategory]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conStudent.id_College,
//strid_College);
//        clsStudentBL.DelStudentsByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsJournalSubjectCategoryBL.DelRecord(strJournalSubjectCategoryId, objConnection, objSqlTransaction);
                objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsJournalSubjectCategoryBL", "DelRecord4MultiTab", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("删除多表记录出错:{0}!keyId = {1}.({2})",
objException.Message,
strJournalSubjectCategoryId, clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "objJournalSubjectCategoryENS">源对象</param>
 /// <param name = "objJournalSubjectCategoryENT">目标对象</param>
 public static void CopyTo(clsJournalSubjectCategoryEN objJournalSubjectCategoryENS, clsJournalSubjectCategoryEN objJournalSubjectCategoryENT)
{
try
{
objJournalSubjectCategoryENT.JournalSubjectCategoryId = objJournalSubjectCategoryENS.JournalSubjectCategoryId; //期刊学科门类Id
objJournalSubjectCategoryENT.JournalSubjectCategoryName = objJournalSubjectCategoryENS.JournalSubjectCategoryName; //期刊学科门类名称
objJournalSubjectCategoryENT.UpdDate = objJournalSubjectCategoryENS.UpdDate; //修改日期
objJournalSubjectCategoryENT.UpdUser = objJournalSubjectCategoryENS.UpdUser; //修改人
objJournalSubjectCategoryENT.Memo = objJournalSubjectCategoryENS.Memo; //备注
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
 /// <param name = "objJournalSubjectCategoryEN">源简化对象</param>
 public static void SetUpdFlag(clsJournalSubjectCategoryEN objJournalSubjectCategoryEN)
{
try
{
objJournalSubjectCategoryEN.ClearUpdateState();
   string strsfUpdFldSetStr = objJournalSubjectCategoryEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(conJournalSubjectCategory.JournalSubjectCategoryId, new clsStrCompareIgnoreCase())  ==  true)
{
objJournalSubjectCategoryEN.JournalSubjectCategoryId = objJournalSubjectCategoryEN.JournalSubjectCategoryId; //期刊学科门类Id
}
if (arrFldSet.Contains(conJournalSubjectCategory.JournalSubjectCategoryName, new clsStrCompareIgnoreCase())  ==  true)
{
objJournalSubjectCategoryEN.JournalSubjectCategoryName = objJournalSubjectCategoryEN.JournalSubjectCategoryName; //期刊学科门类名称
}
if (arrFldSet.Contains(conJournalSubjectCategory.UpdDate, new clsStrCompareIgnoreCase())  ==  true)
{
objJournalSubjectCategoryEN.UpdDate = objJournalSubjectCategoryEN.UpdDate == "[null]" ? null :  objJournalSubjectCategoryEN.UpdDate; //修改日期
}
if (arrFldSet.Contains(conJournalSubjectCategory.UpdUser, new clsStrCompareIgnoreCase())  ==  true)
{
objJournalSubjectCategoryEN.UpdUser = objJournalSubjectCategoryEN.UpdUser == "[null]" ? null :  objJournalSubjectCategoryEN.UpdUser; //修改人
}
if (arrFldSet.Contains(conJournalSubjectCategory.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objJournalSubjectCategoryEN.Memo = objJournalSubjectCategoryEN.Memo == "[null]" ? null :  objJournalSubjectCategoryEN.Memo; //备注
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
 /// <param name = "objJournalSubjectCategoryEN">源简化对象</param>
 public static void AccessFldValueNull(clsJournalSubjectCategoryEN objJournalSubjectCategoryEN)
{
try
{
if (objJournalSubjectCategoryEN.UpdDate == "[null]") objJournalSubjectCategoryEN.UpdDate = null; //修改日期
if (objJournalSubjectCategoryEN.UpdUser == "[null]") objJournalSubjectCategoryEN.UpdUser = null; //修改人
if (objJournalSubjectCategoryEN.Memo == "[null]") objJournalSubjectCategoryEN.Memo = null; //备注
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
public static void CheckPropertyNew(clsJournalSubjectCategoryEN objJournalSubjectCategoryEN)
{
 JournalSubjectCategoryDA.CheckPropertyNew(objJournalSubjectCategoryEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(clsJournalSubjectCategoryEN objJournalSubjectCategoryEN)
{
 JournalSubjectCategoryDA.CheckProperty4Condition(objJournalSubjectCategoryEN);
 }


 #endregion 检查对象属性


 #region 绑定下拉框

 /// <summary>
 /// 绑定基于Win的下拉框
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_TabFeature_ComboBoxBindFunction)
 /// </summary>
 /// <param name = "objComboBox">需要绑定当前表的下拉框</param>

public static void BindCbo_JournalSubjectCategoryId(System.Windows.Forms.ComboBox objComboBox )
{
//为数据源为表的下拉框设置内容
string strCondition = string.Format("1 =1 Order By {0}", conJournalSubjectCategory.JournalSubjectCategoryId); 
List<clsJournalSubjectCategoryEN> arrObjLst = clsJournalSubjectCategoryBL.GetObjLst(strCondition);
//初始化一个对象列表
//插入第0项。在第0项中插入“请选择...”,为了方便用户,与WEB方式类似。
clsJournalSubjectCategoryEN objJournalSubjectCategoryEN = new clsJournalSubjectCategoryEN()
{
JournalSubjectCategoryId = "0",
JournalSubjectCategoryName = "选[期刊学科门类]..."
};
arrObjLst.Insert(0, objJournalSubjectCategoryEN);
//设置下拉框的数据源、以及设置值项、显示项
objComboBox.ValueMember = conJournalSubjectCategory.JournalSubjectCategoryId;
objComboBox.DisplayMember = conJournalSubjectCategory.JournalSubjectCategoryName;
objComboBox.DataSource = arrObjLst;
objComboBox.SelectedIndex = 0;
}

 /// <summary>
 /// 绑定基于Web的下拉框
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_TabFeature_DdlBindFunction)
 /// </summary>
 /// <param name = "objDDL">需要绑定当前表的下拉框</param>

public static void BindDdl_JournalSubjectCategoryId(System.Web.UI.WebControls.DropDownList objDDL )
{
//为数据源于表的下拉框设置内容
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[期刊学科门类]...","0");
string strCondition = string.Format("1 =1 Order By {0}", conJournalSubjectCategory.JournalSubjectCategoryId); 
IEnumerable<clsJournalSubjectCategoryEN> arrObjLst = clsJournalSubjectCategoryBL.GetObjLst(strCondition);
objDDL.DataValueField = conJournalSubjectCategory.JournalSubjectCategoryId;
objDDL.DataTextField = conJournalSubjectCategory.JournalSubjectCategoryName;
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
public static void BindDdl_JournalSubjectCategoryIdCache(System.Web.UI.WebControls.DropDownList objDDL)
{
//为数据源于表的下拉框设置内容
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[期刊学科门类]...","0");
List<clsJournalSubjectCategoryEN> arrJournalSubjectCategoryObjLst = GetAllJournalSubjectCategoryObjLstCache(); 
objDDL.DataValueField = conJournalSubjectCategory.JournalSubjectCategoryId;
objDDL.DataTextField = conJournalSubjectCategory.JournalSubjectCategoryName;
objDDL.DataSource = arrJournalSubjectCategoryObjLst;
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
if (clsJournalSubjectCategoryBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsJournalSubjectCategoryBL没有刷新缓存机制(clsJournalSubjectCategoryBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by JournalSubjectCategoryId");
//if (arrJournalSubjectCategoryObjLstCache == null)
//{
//arrJournalSubjectCategoryObjLstCache = JournalSubjectCategoryDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "strJournalSubjectCategoryId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsJournalSubjectCategoryEN GetObjByJournalSubjectCategoryIdCache(string strJournalSubjectCategoryId)
{
//获取缓存中的对象列表
string strKey = string.Format("{0}", clsJournalSubjectCategoryEN._CurrTabName);
List<clsJournalSubjectCategoryEN> arrJournalSubjectCategoryObjLstCache = GetObjLstCache();
IEnumerable <clsJournalSubjectCategoryEN> arrJournalSubjectCategoryObjLst_Sel =
arrJournalSubjectCategoryObjLstCache
.Where(x=> x.JournalSubjectCategoryId == strJournalSubjectCategoryId 
);
if (arrJournalSubjectCategoryObjLst_Sel.Count() == 0)
{
   clsJournalSubjectCategoryEN obj = clsJournalSubjectCategoryBL.GetObjByJournalSubjectCategoryId(strJournalSubjectCategoryId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
 }
return null;
}
return arrJournalSubjectCategoryObjLst_Sel.First();
}

 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecNameByKeyCache)
 /// </summary>
 /// <param name = "strJournalSubjectCategoryId">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetJournalSubjectCategoryNameByJournalSubjectCategoryIdCache(string strJournalSubjectCategoryId)
{
if (string.IsNullOrEmpty(strJournalSubjectCategoryId) == true) return "";
//获取缓存中的对象列表
clsJournalSubjectCategoryEN objJournalSubjectCategory = GetObjByJournalSubjectCategoryIdCache(strJournalSubjectCategoryId);
if (objJournalSubjectCategory == null) return "";
return objJournalSubjectCategory.JournalSubjectCategoryName;
}
 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecNameByKeyCache)
 /// </summary>
 /// <param name = "strJournalSubjectCategoryId">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetNameByJournalSubjectCategoryIdCache(string strJournalSubjectCategoryId)
{
if (string.IsNullOrEmpty(strJournalSubjectCategoryId) == true) return "";
//获取缓存中的对象列表
clsJournalSubjectCategoryEN objJournalSubjectCategory = GetObjByJournalSubjectCategoryIdCache(strJournalSubjectCategoryId);
if (objJournalSubjectCategory == null) return "";
return objJournalSubjectCategory.JournalSubjectCategoryName;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsJournalSubjectCategoryEN> GetAllJournalSubjectCategoryObjLstCache()
{
//获取缓存中的对象列表
List<clsJournalSubjectCategoryEN> arrJournalSubjectCategoryObjLstCache = GetObjLstCache(); 
return arrJournalSubjectCategoryObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsJournalSubjectCategoryEN> GetObjLstCache()
{
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}", clsJournalSubjectCategoryEN._CurrTabName);
List<clsJournalSubjectCategoryEN> arrJournalSubjectCategoryObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrJournalSubjectCategoryObjLstCache;
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
string strKey = string.Format("{0}", clsJournalSubjectCategoryEN._CurrTabName);
CacheHelper.Remove(strKey);
clsJournalSubjectCategoryEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
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
if (clsJournalSubjectCategoryEN._RefreshTimeLst.Count == 0) return "";
return clsJournalSubjectCategoryEN._RefreshTimeLst[clsJournalSubjectCategoryEN._RefreshTimeLst.Count - 1];
}

 /// <summary>
 /// 刷新缓存.把当前表的缓存以及该表相关视图的缓存清空.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ReFreshCache)
 /// </summary>
public static void ReFreshCache()
{
if (clsJournalSubjectCategoryBL.objCommFun4BL != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}", clsJournalSubjectCategoryEN._CurrTabName);
CacheHelper.Remove(strKey);
clsJournalSubjectCategoryEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
clsJournalSubjectCategoryBL.objCommFun4BL.ReFreshCache();
}
}


 #endregion 缓存操作


 #region 检查唯一性

 /// <summary>
 /// 获取检查唯一性条件串(Uniqueness)--JournalSubjectCategory(期刊学科门类)
 /// 唯一性条件:JournalSubjectCategoryName
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetUniquenessConditionString)
 /// </summary>
 /// <param name = "objJournalSubjectCategoryEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(clsJournalSubjectCategoryEN objJournalSubjectCategoryEN)
{
//检测记录是否存在
string strResult = JournalSubjectCategoryDA.GetUniCondStr(objJournalSubjectCategoryEN);
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
public static string Func(string strInFldName, string strOutFldName, string strJournalSubjectCategoryId)
{
if (strInFldName != conJournalSubjectCategory.JournalSubjectCategoryId)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (conJournalSubjectCategory.AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", conJournalSubjectCategory.AttributeName));
throw new Exception(strMsg);
}
var objJournalSubjectCategory = clsJournalSubjectCategoryBL.GetObjByJournalSubjectCategoryIdCache(strJournalSubjectCategoryId);
if (objJournalSubjectCategory == null) return "";
return objJournalSubjectCategory[strOutFldName].ToString();
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
int intRecCount = clsJournalSubjectCategoryDA.GetRecCount(strTabName);
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
int intRecCount = clsJournalSubjectCategoryDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsJournalSubjectCategoryDA.GetRecCount();
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
int intRecCount = clsJournalSubjectCategoryDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objJournalSubjectCategoryCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsJournalSubjectCategoryEN objJournalSubjectCategoryCond)
{
List<clsJournalSubjectCategoryEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsJournalSubjectCategoryEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conJournalSubjectCategory.AttributeName)
{
if (objJournalSubjectCategoryCond.IsUpdated(strFldName) == false) continue;
if (objJournalSubjectCategoryCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objJournalSubjectCategoryCond[strFldName].ToString());
}
else
{
if (objJournalSubjectCategoryCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objJournalSubjectCategoryCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objJournalSubjectCategoryCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objJournalSubjectCategoryCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objJournalSubjectCategoryCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objJournalSubjectCategoryCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objJournalSubjectCategoryCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objJournalSubjectCategoryCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objJournalSubjectCategoryCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objJournalSubjectCategoryCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objJournalSubjectCategoryCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objJournalSubjectCategoryCond[strFldName]));
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
 List<string> arrList = clsJournalSubjectCategoryDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = JournalSubjectCategoryDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = JournalSubjectCategoryDA.GetFldValueNoDistinct(strFldName, strWhereCond);
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
int intRecCount = JournalSubjectCategoryDA.SetFldValue(strFldName, strValue, strWhereCond);
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
int intRecCount = clsJournalSubjectCategoryDA.SetFldValue(clsJournalSubjectCategoryEN._CurrTabName, strFldName, fltValue, strWhereCond);
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
int intRecCount = JournalSubjectCategoryDA.SetFldValue( strFldName, intValue, strWhereCond);
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
int intRecCount = clsJournalSubjectCategoryDA.SetFldValue(strTabName, strFldName, strValue, strWhereCond);
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
int intRecCount = clsJournalSubjectCategoryDA.SetFldValue(strTabName, strFldName, intValue, strWhereCond);
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
int intRecCount = clsJournalSubjectCategoryDA.SetFldValue(strTabName, strFldName, fltValue, strWhereCond);
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
  strCreateTabCode.Append("CREATE table [dbo].[JournalSubjectCategory] "); 
 strCreateTabCode.Append(" ( "); 
 // /**期刊学科门类Id*/ 
 strCreateTabCode.Append(" JournalSubjectCategoryId char(4) primary key, "); 
 // /**期刊学科门类名称*/ 
 strCreateTabCode.Append(" JournalSubjectCategoryName varchar(100) not Null, "); 
 // /**修改日期*/ 
 strCreateTabCode.Append(" UpdDate varchar(20) Null, "); 
 // /**修改人*/ 
 strCreateTabCode.Append(" UpdUser varchar(20) Null, "); 
 // /**备注*/ 
 strCreateTabCode.Append(" Memo varchar(1000) Null ");
 strCreateTabCode.Append(") "); 
  strCreateTabCode.Append("ON [PRIMARY] ");
  return strCreateTabCode.ToString();
}



 #endregion 表操作
}
 /// <summary>
 /// 期刊学科门类(JournalSubjectCategory)
 /// 数据源类型:表
 /// (AutoGCLib.CommFun4BL4CSharp:GeneCode_This)
 /// </summary>
public class  clsCommFun4BL4JournalSubjectCategory : clsCommFun4BL
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
clsJournalSubjectCategoryBL.ReFreshThisCache();
}
}

}