
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsgs_OriginalPaperLogTypeBL
 表名:gs_OriginalPaperLogType(01120679)
 * 版本:2024.11.13.1(服务器:WIN-SRV103-116)
 日期:2024/11/13 06:10:30
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:研究生学习游戏化后台(000055, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:研培参数(RT_Params)
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
public static class  clsgs_OriginalPaperLogTypeBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "strLogTypeId">表关键字</param>
 /// <returns>表对象</returns>
public static clsgs_OriginalPaperLogTypeEN GetObj(this K_LogTypeId_gs_OriginalPaperLogType myKey)
{
clsgs_OriginalPaperLogTypeEN objgs_OriginalPaperLogTypeEN = clsgs_OriginalPaperLogTypeBL.gs_OriginalPaperLogTypeDA.GetObjByLogTypeId(myKey.Value);
return objgs_OriginalPaperLogTypeEN;
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_AddNewRecord)
 /// </summary>
 /// <param name = "objgs_OriginalPaperLogTypeEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clsgs_OriginalPaperLogTypeEN objgs_OriginalPaperLogTypeEN, bool bolIsNeedCheckUniqueness = true)
{
if (bolIsNeedCheckUniqueness == true && CheckUniqueness(objgs_OriginalPaperLogTypeEN) == false)
{
var strMsg = string.Format("记录已经存在!日志类型Id = [{0}]的数据已经存在!(in clsgs_OriginalPaperLogTypeBL.AddNewRecord)", objgs_OriginalPaperLogTypeEN.LogTypeId);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objgs_OriginalPaperLogTypeEN.LogTypeId) == true || clsgs_OriginalPaperLogTypeBL.IsExist(objgs_OriginalPaperLogTypeEN.LogTypeId) == true)
 {
     objgs_OriginalPaperLogTypeEN.LogTypeId = clsgs_OriginalPaperLogTypeBL.GetMaxStrId_S();
 }
bool bolResult = clsgs_OriginalPaperLogTypeBL.gs_OriginalPaperLogTypeDA.AddNewRecordBySQL2(objgs_OriginalPaperLogTypeEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsgs_OriginalPaperLogTypeBL.ReFreshCache();

if (clsgs_OriginalPaperLogTypeBL.relatedActions != null)
{
clsgs_OriginalPaperLogTypeBL.relatedActions.UpdRelaTabDate(objgs_OriginalPaperLogTypeEN.LogTypeId, "SetUpdDate");
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
public static bool AddRecordEx(this clsgs_OriginalPaperLogTypeEN objgs_OriginalPaperLogTypeEN, bool bolIsNeedCheckUniqueness = true)
{
//操作步骤:
//1、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在
//2、检查唯一性
//3、检查传进去的对象属性是否合法
//4、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
//1、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在

//因为是字符型自增主键,不需要检查主键是否已经存在,在添加时,再获取 最大值作为主键
//if (clsgs_OriginalPaperLogTypeBL.IsExist(objgs_OriginalPaperLogTypeEN.LogTypeId))	//判断是否有相同的关键字
//{
//strMsg = "(errid:Busi000151)关键字字段已有相同的值";
//throw new Exception(strMsg);
//}
try
{
 //2、检查传进去的对象属性是否合法
objgs_OriginalPaperLogTypeEN.CheckPropertyNew();
 ///5.2、检查唯一性
if (bolIsNeedCheckUniqueness == true && objgs_OriginalPaperLogTypeEN.CheckUniqueness() == false)
{
strMsg = string.Format("(日志类型Id(LogTypeId)=[{0}])已经存在,不能重复!", objgs_OriginalPaperLogTypeEN.LogTypeId);
throw new Exception(strMsg);
}
//因为是字符型自增主键,所以在添加时,自动获取主键值。
 if (string.IsNullOrEmpty(objgs_OriginalPaperLogTypeEN.LogTypeId) == true || clsgs_OriginalPaperLogTypeBL.IsExist(objgs_OriginalPaperLogTypeEN.LogTypeId) == true)
 {
     objgs_OriginalPaperLogTypeEN.LogTypeId = clsgs_OriginalPaperLogTypeBL.GetMaxStrId_S();
 }
//6、把数据实体层的数据存贮到数据库中
objgs_OriginalPaperLogTypeEN.AddNewRecord();
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
 /// <param name = "objgs_OriginalPaperLogTypeEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static string AddNewRecordWithMaxId(this clsgs_OriginalPaperLogTypeEN objgs_OriginalPaperLogTypeEN, bool bolIsNeedCheckUniqueness = true)
{
if (bolIsNeedCheckUniqueness == true && CheckUniqueness(objgs_OriginalPaperLogTypeEN) == false)
{
var strMsg = string.Format("记录已经存在!日志类型Id = [{0}]的数据已经存在!(in clsgs_OriginalPaperLogTypeBL.AddNewRecordWithMaxId)", objgs_OriginalPaperLogTypeEN.LogTypeId);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objgs_OriginalPaperLogTypeEN.LogTypeId) == true || clsgs_OriginalPaperLogTypeBL.IsExist(objgs_OriginalPaperLogTypeEN.LogTypeId) == true)
 {
     objgs_OriginalPaperLogTypeEN.LogTypeId = clsgs_OriginalPaperLogTypeBL.GetMaxStrId_S();
 }
string strLogTypeId = clsgs_OriginalPaperLogTypeBL.gs_OriginalPaperLogTypeDA.AddNewRecordBySQL2WithReturnKey(objgs_OriginalPaperLogTypeEN);
     objgs_OriginalPaperLogTypeEN.LogTypeId = strLogTypeId;
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsgs_OriginalPaperLogTypeBL.ReFreshCache();

if (clsgs_OriginalPaperLogTypeBL.relatedActions != null)
{
clsgs_OriginalPaperLogTypeBL.relatedActions.UpdRelaTabDate(objgs_OriginalPaperLogTypeEN.LogTypeId, "SetUpdDate");
}
return strLogTypeId;
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
 /// <param name = "objgs_OriginalPaperLogTypeEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordWithReturnKey(this clsgs_OriginalPaperLogTypeEN objgs_OriginalPaperLogTypeEN, bool bolIsNeedCheckUniqueness = true)
{
if (bolIsNeedCheckUniqueness == true && CheckUniqueness(objgs_OriginalPaperLogTypeEN) == false)
{
var strMsg = string.Format("记录已经存在!日志类型Id = [{0}]的数据已经存在!(in clsgs_OriginalPaperLogTypeBL.AddNewRecordWithReturnKey)", objgs_OriginalPaperLogTypeEN.LogTypeId);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objgs_OriginalPaperLogTypeEN.LogTypeId) == true || clsgs_OriginalPaperLogTypeBL.IsExist(objgs_OriginalPaperLogTypeEN.LogTypeId) == true)
 {
     objgs_OriginalPaperLogTypeEN.LogTypeId = clsgs_OriginalPaperLogTypeBL.GetMaxStrId_S();
 }
string strKey = clsgs_OriginalPaperLogTypeBL.gs_OriginalPaperLogTypeDA.AddNewRecordBySQL2WithReturnKey(objgs_OriginalPaperLogTypeEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsgs_OriginalPaperLogTypeBL.ReFreshCache();

if (clsgs_OriginalPaperLogTypeBL.relatedActions != null)
{
clsgs_OriginalPaperLogTypeBL.relatedActions.UpdRelaTabDate(objgs_OriginalPaperLogTypeEN.LogTypeId, "SetUpdDate");
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
 /// <param name = "objgs_OriginalPaperLogTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsgs_OriginalPaperLogTypeEN SetLogTypeId(this clsgs_OriginalPaperLogTypeEN objgs_OriginalPaperLogTypeEN, string strLogTypeId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strLogTypeId, 2, congs_OriginalPaperLogType.LogTypeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strLogTypeId, 2, congs_OriginalPaperLogType.LogTypeId);
}
objgs_OriginalPaperLogTypeEN.LogTypeId = strLogTypeId; //日志类型Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objgs_OriginalPaperLogTypeEN.dicFldComparisonOp.ContainsKey(congs_OriginalPaperLogType.LogTypeId) == false)
{
objgs_OriginalPaperLogTypeEN.dicFldComparisonOp.Add(congs_OriginalPaperLogType.LogTypeId, strComparisonOp);
}
else
{
objgs_OriginalPaperLogTypeEN.dicFldComparisonOp[congs_OriginalPaperLogType.LogTypeId] = strComparisonOp;
}
}
return objgs_OriginalPaperLogTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objgs_OriginalPaperLogTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsgs_OriginalPaperLogTypeEN SetLogTypeName(this clsgs_OriginalPaperLogTypeEN objgs_OriginalPaperLogTypeEN, string strLogTypeName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strLogTypeName, 200, congs_OriginalPaperLogType.LogTypeName);
}
objgs_OriginalPaperLogTypeEN.LogTypeName = strLogTypeName; //日志类型名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objgs_OriginalPaperLogTypeEN.dicFldComparisonOp.ContainsKey(congs_OriginalPaperLogType.LogTypeName) == false)
{
objgs_OriginalPaperLogTypeEN.dicFldComparisonOp.Add(congs_OriginalPaperLogType.LogTypeName, strComparisonOp);
}
else
{
objgs_OriginalPaperLogTypeEN.dicFldComparisonOp[congs_OriginalPaperLogType.LogTypeName] = strComparisonOp;
}
}
return objgs_OriginalPaperLogTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objgs_OriginalPaperLogTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsgs_OriginalPaperLogTypeEN SetUpdUser(this clsgs_OriginalPaperLogTypeEN objgs_OriginalPaperLogTypeEN, string strUpdUser, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdUser, 20, congs_OriginalPaperLogType.UpdUser);
}
objgs_OriginalPaperLogTypeEN.UpdUser = strUpdUser; //修改人
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objgs_OriginalPaperLogTypeEN.dicFldComparisonOp.ContainsKey(congs_OriginalPaperLogType.UpdUser) == false)
{
objgs_OriginalPaperLogTypeEN.dicFldComparisonOp.Add(congs_OriginalPaperLogType.UpdUser, strComparisonOp);
}
else
{
objgs_OriginalPaperLogTypeEN.dicFldComparisonOp[congs_OriginalPaperLogType.UpdUser] = strComparisonOp;
}
}
return objgs_OriginalPaperLogTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objgs_OriginalPaperLogTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsgs_OriginalPaperLogTypeEN SetUpdDate(this clsgs_OriginalPaperLogTypeEN objgs_OriginalPaperLogTypeEN, string strUpdDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdDate, 20, congs_OriginalPaperLogType.UpdDate);
}
objgs_OriginalPaperLogTypeEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objgs_OriginalPaperLogTypeEN.dicFldComparisonOp.ContainsKey(congs_OriginalPaperLogType.UpdDate) == false)
{
objgs_OriginalPaperLogTypeEN.dicFldComparisonOp.Add(congs_OriginalPaperLogType.UpdDate, strComparisonOp);
}
else
{
objgs_OriginalPaperLogTypeEN.dicFldComparisonOp[congs_OriginalPaperLogType.UpdDate] = strComparisonOp;
}
}
return objgs_OriginalPaperLogTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objgs_OriginalPaperLogTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsgs_OriginalPaperLogTypeEN SetMemo(this clsgs_OriginalPaperLogTypeEN objgs_OriginalPaperLogTypeEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, congs_OriginalPaperLogType.Memo);
}
objgs_OriginalPaperLogTypeEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objgs_OriginalPaperLogTypeEN.dicFldComparisonOp.ContainsKey(congs_OriginalPaperLogType.Memo) == false)
{
objgs_OriginalPaperLogTypeEN.dicFldComparisonOp.Add(congs_OriginalPaperLogType.Memo, strComparisonOp);
}
else
{
objgs_OriginalPaperLogTypeEN.dicFldComparisonOp[congs_OriginalPaperLogType.Memo] = strComparisonOp;
}
}
return objgs_OriginalPaperLogTypeEN;
	}

 /// <summary>
 /// 修改记录存盘到数据表中
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_UpdateRecordEx)
 /// </summary>
 /// <param name = "objgs_OriginalPaperLogTypeEN">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool UpdateRecordEx(this clsgs_OriginalPaperLogTypeEN objgs_OriginalPaperLogTypeEN)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
try
{
//1、检查传进去的对象属性是否合法
objgs_OriginalPaperLogTypeEN.CheckPropertyNew();
clsgs_OriginalPaperLogTypeEN objgs_OriginalPaperLogTypeCond = new clsgs_OriginalPaperLogTypeEN();
string strCondition = objgs_OriginalPaperLogTypeCond
.SetLogTypeId(objgs_OriginalPaperLogTypeEN.LogTypeId, "<>")
.SetLogTypeId(objgs_OriginalPaperLogTypeEN.LogTypeId, "=")
.GetCombineCondition();
objgs_OriginalPaperLogTypeEN._IsCheckProperty = true;
bool bolIsExist = clsgs_OriginalPaperLogTypeBL.IsExistRecord(strCondition);
if (bolIsExist)
{
strMsg = "(LogTypeId)不能重复!";
throw new Exception(strMsg);
}
//4、把数据实体层的数据存贮到数据库中
objgs_OriginalPaperLogTypeEN.Update();
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
 /// <param name = "objgs_OriginalPaperLogType">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool EditRecordEx(this clsgs_OriginalPaperLogTypeEN objgs_OriginalPaperLogType)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
clsgs_OriginalPaperLogTypeEN objgs_OriginalPaperLogTypeCond = new clsgs_OriginalPaperLogTypeEN();
string strCondition = objgs_OriginalPaperLogTypeCond
.SetLogTypeId(objgs_OriginalPaperLogType.LogTypeId, "=")
.GetCombineCondition();
objgs_OriginalPaperLogType._IsCheckProperty = true;
bool bolIsExist = clsgs_OriginalPaperLogTypeBL.IsExistRecord(strCondition);
if (bolIsExist)
{
objgs_OriginalPaperLogType.LogTypeId = clsgs_OriginalPaperLogTypeBL.GetFirstID_S(strCondition);
objgs_OriginalPaperLogType.UpdateWithCondition(strCondition);
}
else
{
objgs_OriginalPaperLogType.LogTypeId = clsgs_OriginalPaperLogTypeBL.GetMaxStrId_S();
objgs_OriginalPaperLogType.AddNewRecord();
}
return true; 
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_Update)
 /// </summary>
 /// <param name = "objgs_OriginalPaperLogTypeEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsgs_OriginalPaperLogTypeEN objgs_OriginalPaperLogTypeEN)
{
 if (string.IsNullOrEmpty(objgs_OriginalPaperLogTypeEN.LogTypeId) == true)
 {
string strMsg = string.Format("(errid:Busi000095)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsgs_OriginalPaperLogTypeBL.gs_OriginalPaperLogTypeDA.UpdateBySql2(objgs_OriginalPaperLogTypeEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsgs_OriginalPaperLogTypeBL.ReFreshCache();

if (clsgs_OriginalPaperLogTypeBL.relatedActions != null)
{
clsgs_OriginalPaperLogTypeBL.relatedActions.UpdRelaTabDate(objgs_OriginalPaperLogTypeEN.LogTypeId, "SetUpdDate");
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
 /// <param name = "objgs_OriginalPaperLogTypeEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsgs_OriginalPaperLogTypeEN objgs_OriginalPaperLogTypeEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (string.IsNullOrEmpty(objgs_OriginalPaperLogTypeEN.LogTypeId) == true)
 {
string strMsg = string.Format("(errid:Busi000087)修改记录时关键字不能为空!(带事务处理)(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsgs_OriginalPaperLogTypeBL.gs_OriginalPaperLogTypeDA.UpdateBySql2(objgs_OriginalPaperLogTypeEN, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsgs_OriginalPaperLogTypeBL.ReFreshCache();

if (clsgs_OriginalPaperLogTypeBL.relatedActions != null)
{
clsgs_OriginalPaperLogTypeBL.relatedActions.UpdRelaTabDate(objgs_OriginalPaperLogTypeEN.LogTypeId, "SetUpdDate");
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
 /// <param name = "objgs_OriginalPaperLogTypeEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsgs_OriginalPaperLogTypeEN objgs_OriginalPaperLogTypeEN, string strWhereCond)
{
try
{
bool bolResult = clsgs_OriginalPaperLogTypeBL.gs_OriginalPaperLogTypeDA.UpdateBySqlWithCondition(objgs_OriginalPaperLogTypeEN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsgs_OriginalPaperLogTypeBL.ReFreshCache();

if (clsgs_OriginalPaperLogTypeBL.relatedActions != null)
{
clsgs_OriginalPaperLogTypeBL.relatedActions.UpdRelaTabDate(objgs_OriginalPaperLogTypeEN.LogTypeId, "SetUpdDate");
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
 /// <param name = "objgs_OriginalPaperLogTypeEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsgs_OriginalPaperLogTypeEN objgs_OriginalPaperLogTypeEN, string strWhereCond, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
bool bolResult = clsgs_OriginalPaperLogTypeBL.gs_OriginalPaperLogTypeDA.UpdateBySqlWithConditionTransaction(objgs_OriginalPaperLogTypeEN, strWhereCond, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsgs_OriginalPaperLogTypeBL.ReFreshCache();

if (clsgs_OriginalPaperLogTypeBL.relatedActions != null)
{
clsgs_OriginalPaperLogTypeBL.relatedActions.UpdRelaTabDate(objgs_OriginalPaperLogTypeEN.LogTypeId, "SetUpdDate");
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
 /// <param name = "strLogTypeId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int Delete(this clsgs_OriginalPaperLogTypeEN objgs_OriginalPaperLogTypeEN)
{
try
{
int intRecNum = clsgs_OriginalPaperLogTypeBL.gs_OriginalPaperLogTypeDA.DelRecord(objgs_OriginalPaperLogTypeEN.LogTypeId);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsgs_OriginalPaperLogTypeBL.ReFreshCache();

if (clsgs_OriginalPaperLogTypeBL.relatedActions != null)
{
clsgs_OriginalPaperLogTypeBL.relatedActions.UpdRelaTabDate(objgs_OriginalPaperLogTypeEN.LogTypeId, "SetUpdDate");
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
 /// <param name = "objgs_OriginalPaperLogTypeENS">源对象</param>
 /// <param name = "objgs_OriginalPaperLogTypeENT">目标对象</param>
 public static void CopyTo(this clsgs_OriginalPaperLogTypeEN objgs_OriginalPaperLogTypeENS, clsgs_OriginalPaperLogTypeEN objgs_OriginalPaperLogTypeENT)
{
try
{
objgs_OriginalPaperLogTypeENT.LogTypeId = objgs_OriginalPaperLogTypeENS.LogTypeId; //日志类型Id
objgs_OriginalPaperLogTypeENT.LogTypeName = objgs_OriginalPaperLogTypeENS.LogTypeName; //日志类型名
objgs_OriginalPaperLogTypeENT.UpdUser = objgs_OriginalPaperLogTypeENS.UpdUser; //修改人
objgs_OriginalPaperLogTypeENT.UpdDate = objgs_OriginalPaperLogTypeENS.UpdDate; //修改日期
objgs_OriginalPaperLogTypeENT.Memo = objgs_OriginalPaperLogTypeENS.Memo; //备注
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
 /// <param name = "objgs_OriginalPaperLogTypeENS">源对象</param>
 /// <returns>目标对象=>clsgs_OriginalPaperLogTypeEN:objgs_OriginalPaperLogTypeENT</returns>
 public static clsgs_OriginalPaperLogTypeEN CopyTo(this clsgs_OriginalPaperLogTypeEN objgs_OriginalPaperLogTypeENS)
{
try
{
 clsgs_OriginalPaperLogTypeEN objgs_OriginalPaperLogTypeENT = new clsgs_OriginalPaperLogTypeEN()
{
LogTypeId = objgs_OriginalPaperLogTypeENS.LogTypeId, //日志类型Id
LogTypeName = objgs_OriginalPaperLogTypeENS.LogTypeName, //日志类型名
UpdUser = objgs_OriginalPaperLogTypeENS.UpdUser, //修改人
UpdDate = objgs_OriginalPaperLogTypeENS.UpdDate, //修改日期
Memo = objgs_OriginalPaperLogTypeENS.Memo, //备注
};
 return objgs_OriginalPaperLogTypeENT;
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
public static void CheckPropertyNew(this clsgs_OriginalPaperLogTypeEN objgs_OriginalPaperLogTypeEN)
{
 clsgs_OriginalPaperLogTypeBL.gs_OriginalPaperLogTypeDA.CheckPropertyNew(objgs_OriginalPaperLogTypeEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(this clsgs_OriginalPaperLogTypeEN objgs_OriginalPaperLogTypeEN)
{
 clsgs_OriginalPaperLogTypeBL.gs_OriginalPaperLogTypeDA.CheckProperty4Condition(objgs_OriginalPaperLogTypeEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsgs_OriginalPaperLogTypeEN objgs_OriginalPaperLogTypeCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objgs_OriginalPaperLogTypeCond.IsUpdated(congs_OriginalPaperLogType.LogTypeId) == true)
{
string strComparisonOpLogTypeId = objgs_OriginalPaperLogTypeCond.dicFldComparisonOp[congs_OriginalPaperLogType.LogTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", congs_OriginalPaperLogType.LogTypeId, objgs_OriginalPaperLogTypeCond.LogTypeId, strComparisonOpLogTypeId);
}
if (objgs_OriginalPaperLogTypeCond.IsUpdated(congs_OriginalPaperLogType.LogTypeName) == true)
{
string strComparisonOpLogTypeName = objgs_OriginalPaperLogTypeCond.dicFldComparisonOp[congs_OriginalPaperLogType.LogTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", congs_OriginalPaperLogType.LogTypeName, objgs_OriginalPaperLogTypeCond.LogTypeName, strComparisonOpLogTypeName);
}
if (objgs_OriginalPaperLogTypeCond.IsUpdated(congs_OriginalPaperLogType.UpdUser) == true)
{
string strComparisonOpUpdUser = objgs_OriginalPaperLogTypeCond.dicFldComparisonOp[congs_OriginalPaperLogType.UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", congs_OriginalPaperLogType.UpdUser, objgs_OriginalPaperLogTypeCond.UpdUser, strComparisonOpUpdUser);
}
if (objgs_OriginalPaperLogTypeCond.IsUpdated(congs_OriginalPaperLogType.UpdDate) == true)
{
string strComparisonOpUpdDate = objgs_OriginalPaperLogTypeCond.dicFldComparisonOp[congs_OriginalPaperLogType.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", congs_OriginalPaperLogType.UpdDate, objgs_OriginalPaperLogTypeCond.UpdDate, strComparisonOpUpdDate);
}
if (objgs_OriginalPaperLogTypeCond.IsUpdated(congs_OriginalPaperLogType.Memo) == true)
{
string strComparisonOpMemo = objgs_OriginalPaperLogTypeCond.dicFldComparisonOp[congs_OriginalPaperLogType.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", congs_OriginalPaperLogType.Memo, objgs_OriginalPaperLogTypeCond.Memo, strComparisonOpMemo);
}
 return strWhereCond;
}

 /// <summary>
 /// 检查唯一性(Uniqueness)--gs_OriginalPaperLogType(论文日志类型), 如果不唯一,即存在相同的记录,就返回False
 /// 唯一性条件:LogTypeId
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckConstraint)
 /// </summary>
 /// <param name = "objgs_OriginalPaperLogTypeEN">要求唯一的对象</param>
 /// <returns></returns>
public static bool CheckUniqueness(this clsgs_OriginalPaperLogTypeEN objgs_OriginalPaperLogTypeEN)
{
//检测记录是否存在
bool bolIsUniqueness;
StringBuilder sbCondition = new StringBuilder();
if (objgs_OriginalPaperLogTypeEN == null) return true;
if (objgs_OriginalPaperLogTypeEN.LogTypeId == null || objgs_OriginalPaperLogTypeEN.LogTypeId == "")
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and LogTypeId = '{0}'", objgs_OriginalPaperLogTypeEN.LogTypeId);
if (clsgs_OriginalPaperLogTypeBL.IsExistRecord(sbCondition.ToString())  ==  true)
{
 bolIsUniqueness = false;
}
else
{
 bolIsUniqueness = true;
}
}
 else {
sbCondition.AppendFormat("LogTypeId !=  '{0}'", objgs_OriginalPaperLogTypeEN.LogTypeId);
 sbCondition.AppendFormat(" and LogTypeId = '{0}'", objgs_OriginalPaperLogTypeEN.LogTypeId);
if (clsgs_OriginalPaperLogTypeBL.IsExistRecord(sbCondition.ToString())  ==  true)
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
 /// 获取唯一性条件串--gs_OriginalPaperLogType(论文日志类型), 即由对象中唯一性条件字段关键字与值组成的条件串
 /// 唯一性条件:LogTypeId
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetConditionString4Constraint)
 /// </summary>
 /// <param name = "objgs_OriginalPaperLogTypeEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(this clsgs_OriginalPaperLogTypeEN objgs_OriginalPaperLogTypeEN)
{
//检测记录是否存在
StringBuilder sbCondition = new StringBuilder();
if (objgs_OriginalPaperLogTypeEN == null) return "";
if (objgs_OriginalPaperLogTypeEN.LogTypeId == null || objgs_OriginalPaperLogTypeEN.LogTypeId == "")
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and LogTypeId = '{0}'", objgs_OriginalPaperLogTypeEN.LogTypeId);
return sbCondition.ToString();
}
 else {
sbCondition.AppendFormat("LogTypeId !=  '{0}'", objgs_OriginalPaperLogTypeEN.LogTypeId);
 sbCondition.AppendFormat(" and LogTypeId = '{0}'", objgs_OriginalPaperLogTypeEN.LogTypeId);
 return sbCondition.ToString();
}
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_gs_OriginalPaperLogType
{
public virtual bool UpdRelaTabDate(string strLogTypeId, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// 论文日志类型(gs_OriginalPaperLogType)
 /// 数据源类型:表
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsgs_OriginalPaperLogTypeBL
{
public static RelatedActions_gs_OriginalPaperLogType relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsgs_OriginalPaperLogTypeDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsgs_OriginalPaperLogTypeDA gs_OriginalPaperLogTypeDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsgs_OriginalPaperLogTypeDA();
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
 public clsgs_OriginalPaperLogTypeBL()
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
if (string.IsNullOrEmpty(clsgs_OriginalPaperLogTypeEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsgs_OriginalPaperLogTypeEN._ConnectString);
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
public static DataTable GetDataTable_gs_OriginalPaperLogType(string strWhereCond)
{
DataTable objDT;
try
{
objDT = gs_OriginalPaperLogTypeDA.GetDataTable_gs_OriginalPaperLogType(strWhereCond);
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
objDT = gs_OriginalPaperLogTypeDA.GetDataTable(strWhereCond);
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
objDT = gs_OriginalPaperLogTypeDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = gs_OriginalPaperLogTypeDA.GetDataTable(strWhereCond, strTabName);
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
objDT = gs_OriginalPaperLogTypeDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = gs_OriginalPaperLogTypeDA.GetDataTable_Top(objTopPara);
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
objDT = gs_OriginalPaperLogTypeDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = gs_OriginalPaperLogTypeDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = gs_OriginalPaperLogTypeDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
 /// <param name = "arrLogTypeIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static List<clsgs_OriginalPaperLogTypeEN> GetObjLstByLogTypeIdLst(List<string> arrLogTypeIdLst)
{
List<clsgs_OriginalPaperLogTypeEN> arrObjLst = new List<clsgs_OriginalPaperLogTypeEN>(); 
System.Data.DataTable objDT; 
 string strSqlConditionStr = clsArray.GetSqlInStrByArray(arrLogTypeIdLst, true);
 string strWhereCond = string.Format("LogTypeId in ({0})", strSqlConditionStr);
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsgs_OriginalPaperLogTypeEN objgs_OriginalPaperLogTypeEN = new clsgs_OriginalPaperLogTypeEN();
try
{
objgs_OriginalPaperLogTypeEN.LogTypeId = objRow[congs_OriginalPaperLogType.LogTypeId].ToString().Trim(); //日志类型Id
objgs_OriginalPaperLogTypeEN.LogTypeName = objRow[congs_OriginalPaperLogType.LogTypeName] == DBNull.Value ? null : objRow[congs_OriginalPaperLogType.LogTypeName].ToString().Trim(); //日志类型名
objgs_OriginalPaperLogTypeEN.UpdUser = objRow[congs_OriginalPaperLogType.UpdUser] == DBNull.Value ? null : objRow[congs_OriginalPaperLogType.UpdUser].ToString().Trim(); //修改人
objgs_OriginalPaperLogTypeEN.UpdDate = objRow[congs_OriginalPaperLogType.UpdDate] == DBNull.Value ? null : objRow[congs_OriginalPaperLogType.UpdDate].ToString().Trim(); //修改日期
objgs_OriginalPaperLogTypeEN.Memo = objRow[congs_OriginalPaperLogType.Memo] == DBNull.Value ? null : objRow[congs_OriginalPaperLogType.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objgs_OriginalPaperLogTypeEN.LogTypeId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objgs_OriginalPaperLogTypeEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrLogTypeIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsgs_OriginalPaperLogTypeEN> GetObjLstByLogTypeIdLstCache(List<string> arrLogTypeIdLst)
{
string strKey = string.Format("{0}", clsgs_OriginalPaperLogTypeEN._CurrTabName);
List<clsgs_OriginalPaperLogTypeEN> arrgs_OriginalPaperLogTypeObjLstCache = GetObjLstCache();
IEnumerable <clsgs_OriginalPaperLogTypeEN> arrgs_OriginalPaperLogTypeObjLst_Sel =
arrgs_OriginalPaperLogTypeObjLstCache
.Where(x => arrLogTypeIdLst.Contains(x.LogTypeId));
return arrgs_OriginalPaperLogTypeObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsgs_OriginalPaperLogTypeEN> GetObjLst(string strWhereCond)
{
List<clsgs_OriginalPaperLogTypeEN> arrObjLst = new List<clsgs_OriginalPaperLogTypeEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsgs_OriginalPaperLogTypeEN objgs_OriginalPaperLogTypeEN = new clsgs_OriginalPaperLogTypeEN();
try
{
objgs_OriginalPaperLogTypeEN.LogTypeId = objRow[congs_OriginalPaperLogType.LogTypeId].ToString().Trim(); //日志类型Id
objgs_OriginalPaperLogTypeEN.LogTypeName = objRow[congs_OriginalPaperLogType.LogTypeName] == DBNull.Value ? null : objRow[congs_OriginalPaperLogType.LogTypeName].ToString().Trim(); //日志类型名
objgs_OriginalPaperLogTypeEN.UpdUser = objRow[congs_OriginalPaperLogType.UpdUser] == DBNull.Value ? null : objRow[congs_OriginalPaperLogType.UpdUser].ToString().Trim(); //修改人
objgs_OriginalPaperLogTypeEN.UpdDate = objRow[congs_OriginalPaperLogType.UpdDate] == DBNull.Value ? null : objRow[congs_OriginalPaperLogType.UpdDate].ToString().Trim(); //修改日期
objgs_OriginalPaperLogTypeEN.Memo = objRow[congs_OriginalPaperLogType.Memo] == DBNull.Value ? null : objRow[congs_OriginalPaperLogType.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objgs_OriginalPaperLogTypeEN.LogTypeId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objgs_OriginalPaperLogTypeEN);
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
public static List<clsgs_OriginalPaperLogTypeEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsgs_OriginalPaperLogTypeEN> arrObjLst = new List<clsgs_OriginalPaperLogTypeEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsgs_OriginalPaperLogTypeEN objgs_OriginalPaperLogTypeEN = new clsgs_OriginalPaperLogTypeEN();
try
{
objgs_OriginalPaperLogTypeEN.LogTypeId = objRow[congs_OriginalPaperLogType.LogTypeId].ToString().Trim(); //日志类型Id
objgs_OriginalPaperLogTypeEN.LogTypeName = objRow[congs_OriginalPaperLogType.LogTypeName] == DBNull.Value ? null : objRow[congs_OriginalPaperLogType.LogTypeName].ToString().Trim(); //日志类型名
objgs_OriginalPaperLogTypeEN.UpdUser = objRow[congs_OriginalPaperLogType.UpdUser] == DBNull.Value ? null : objRow[congs_OriginalPaperLogType.UpdUser].ToString().Trim(); //修改人
objgs_OriginalPaperLogTypeEN.UpdDate = objRow[congs_OriginalPaperLogType.UpdDate] == DBNull.Value ? null : objRow[congs_OriginalPaperLogType.UpdDate].ToString().Trim(); //修改日期
objgs_OriginalPaperLogTypeEN.Memo = objRow[congs_OriginalPaperLogType.Memo] == DBNull.Value ? null : objRow[congs_OriginalPaperLogType.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objgs_OriginalPaperLogTypeEN.LogTypeId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objgs_OriginalPaperLogTypeEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objgs_OriginalPaperLogTypeCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsgs_OriginalPaperLogTypeEN> GetSubObjLstCache(clsgs_OriginalPaperLogTypeEN objgs_OriginalPaperLogTypeCond)
{
List<clsgs_OriginalPaperLogTypeEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsgs_OriginalPaperLogTypeEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in congs_OriginalPaperLogType.AttributeName)
{
if (objgs_OriginalPaperLogTypeCond.IsUpdated(strFldName) == false) continue;
if (objgs_OriginalPaperLogTypeCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objgs_OriginalPaperLogTypeCond[strFldName].ToString());
}
else
{
if (objgs_OriginalPaperLogTypeCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objgs_OriginalPaperLogTypeCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objgs_OriginalPaperLogTypeCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objgs_OriginalPaperLogTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objgs_OriginalPaperLogTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objgs_OriginalPaperLogTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objgs_OriginalPaperLogTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objgs_OriginalPaperLogTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objgs_OriginalPaperLogTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objgs_OriginalPaperLogTypeCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objgs_OriginalPaperLogTypeCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objgs_OriginalPaperLogTypeCond[strFldName]));
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
public static List<clsgs_OriginalPaperLogTypeEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsgs_OriginalPaperLogTypeEN> arrObjLst = new List<clsgs_OriginalPaperLogTypeEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsgs_OriginalPaperLogTypeEN objgs_OriginalPaperLogTypeEN = new clsgs_OriginalPaperLogTypeEN();
try
{
objgs_OriginalPaperLogTypeEN.LogTypeId = objRow[congs_OriginalPaperLogType.LogTypeId].ToString().Trim(); //日志类型Id
objgs_OriginalPaperLogTypeEN.LogTypeName = objRow[congs_OriginalPaperLogType.LogTypeName] == DBNull.Value ? null : objRow[congs_OriginalPaperLogType.LogTypeName].ToString().Trim(); //日志类型名
objgs_OriginalPaperLogTypeEN.UpdUser = objRow[congs_OriginalPaperLogType.UpdUser] == DBNull.Value ? null : objRow[congs_OriginalPaperLogType.UpdUser].ToString().Trim(); //修改人
objgs_OriginalPaperLogTypeEN.UpdDate = objRow[congs_OriginalPaperLogType.UpdDate] == DBNull.Value ? null : objRow[congs_OriginalPaperLogType.UpdDate].ToString().Trim(); //修改日期
objgs_OriginalPaperLogTypeEN.Memo = objRow[congs_OriginalPaperLogType.Memo] == DBNull.Value ? null : objRow[congs_OriginalPaperLogType.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objgs_OriginalPaperLogTypeEN.LogTypeId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objgs_OriginalPaperLogTypeEN);
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
public static List<clsgs_OriginalPaperLogTypeEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsgs_OriginalPaperLogTypeEN> arrObjLst = new List<clsgs_OriginalPaperLogTypeEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsgs_OriginalPaperLogTypeEN objgs_OriginalPaperLogTypeEN = new clsgs_OriginalPaperLogTypeEN();
try
{
objgs_OriginalPaperLogTypeEN.LogTypeId = objRow[congs_OriginalPaperLogType.LogTypeId].ToString().Trim(); //日志类型Id
objgs_OriginalPaperLogTypeEN.LogTypeName = objRow[congs_OriginalPaperLogType.LogTypeName] == DBNull.Value ? null : objRow[congs_OriginalPaperLogType.LogTypeName].ToString().Trim(); //日志类型名
objgs_OriginalPaperLogTypeEN.UpdUser = objRow[congs_OriginalPaperLogType.UpdUser] == DBNull.Value ? null : objRow[congs_OriginalPaperLogType.UpdUser].ToString().Trim(); //修改人
objgs_OriginalPaperLogTypeEN.UpdDate = objRow[congs_OriginalPaperLogType.UpdDate] == DBNull.Value ? null : objRow[congs_OriginalPaperLogType.UpdDate].ToString().Trim(); //修改日期
objgs_OriginalPaperLogTypeEN.Memo = objRow[congs_OriginalPaperLogType.Memo] == DBNull.Value ? null : objRow[congs_OriginalPaperLogType.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objgs_OriginalPaperLogTypeEN.LogTypeId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objgs_OriginalPaperLogTypeEN);
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
List<clsgs_OriginalPaperLogTypeEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsgs_OriginalPaperLogTypeEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsgs_OriginalPaperLogTypeEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsgs_OriginalPaperLogTypeEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsgs_OriginalPaperLogTypeEN> arrObjLst = new List<clsgs_OriginalPaperLogTypeEN>(); 
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
	clsgs_OriginalPaperLogTypeEN objgs_OriginalPaperLogTypeEN = new clsgs_OriginalPaperLogTypeEN();
try
{
objgs_OriginalPaperLogTypeEN.LogTypeId = objRow[congs_OriginalPaperLogType.LogTypeId].ToString().Trim(); //日志类型Id
objgs_OriginalPaperLogTypeEN.LogTypeName = objRow[congs_OriginalPaperLogType.LogTypeName] == DBNull.Value ? null : objRow[congs_OriginalPaperLogType.LogTypeName].ToString().Trim(); //日志类型名
objgs_OriginalPaperLogTypeEN.UpdUser = objRow[congs_OriginalPaperLogType.UpdUser] == DBNull.Value ? null : objRow[congs_OriginalPaperLogType.UpdUser].ToString().Trim(); //修改人
objgs_OriginalPaperLogTypeEN.UpdDate = objRow[congs_OriginalPaperLogType.UpdDate] == DBNull.Value ? null : objRow[congs_OriginalPaperLogType.UpdDate].ToString().Trim(); //修改日期
objgs_OriginalPaperLogTypeEN.Memo = objRow[congs_OriginalPaperLogType.Memo] == DBNull.Value ? null : objRow[congs_OriginalPaperLogType.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objgs_OriginalPaperLogTypeEN.LogTypeId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objgs_OriginalPaperLogTypeEN);
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
public static List<clsgs_OriginalPaperLogTypeEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsgs_OriginalPaperLogTypeEN> arrObjLst = new List<clsgs_OriginalPaperLogTypeEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsgs_OriginalPaperLogTypeEN objgs_OriginalPaperLogTypeEN = new clsgs_OriginalPaperLogTypeEN();
try
{
objgs_OriginalPaperLogTypeEN.LogTypeId = objRow[congs_OriginalPaperLogType.LogTypeId].ToString().Trim(); //日志类型Id
objgs_OriginalPaperLogTypeEN.LogTypeName = objRow[congs_OriginalPaperLogType.LogTypeName] == DBNull.Value ? null : objRow[congs_OriginalPaperLogType.LogTypeName].ToString().Trim(); //日志类型名
objgs_OriginalPaperLogTypeEN.UpdUser = objRow[congs_OriginalPaperLogType.UpdUser] == DBNull.Value ? null : objRow[congs_OriginalPaperLogType.UpdUser].ToString().Trim(); //修改人
objgs_OriginalPaperLogTypeEN.UpdDate = objRow[congs_OriginalPaperLogType.UpdDate] == DBNull.Value ? null : objRow[congs_OriginalPaperLogType.UpdDate].ToString().Trim(); //修改日期
objgs_OriginalPaperLogTypeEN.Memo = objRow[congs_OriginalPaperLogType.Memo] == DBNull.Value ? null : objRow[congs_OriginalPaperLogType.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objgs_OriginalPaperLogTypeEN.LogTypeId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objgs_OriginalPaperLogTypeEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsgs_OriginalPaperLogTypeEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsgs_OriginalPaperLogTypeEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsgs_OriginalPaperLogTypeEN> arrObjLst = new List<clsgs_OriginalPaperLogTypeEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsgs_OriginalPaperLogTypeEN objgs_OriginalPaperLogTypeEN = new clsgs_OriginalPaperLogTypeEN();
try
{
objgs_OriginalPaperLogTypeEN.LogTypeId = objRow[congs_OriginalPaperLogType.LogTypeId].ToString().Trim(); //日志类型Id
objgs_OriginalPaperLogTypeEN.LogTypeName = objRow[congs_OriginalPaperLogType.LogTypeName] == DBNull.Value ? null : objRow[congs_OriginalPaperLogType.LogTypeName].ToString().Trim(); //日志类型名
objgs_OriginalPaperLogTypeEN.UpdUser = objRow[congs_OriginalPaperLogType.UpdUser] == DBNull.Value ? null : objRow[congs_OriginalPaperLogType.UpdUser].ToString().Trim(); //修改人
objgs_OriginalPaperLogTypeEN.UpdDate = objRow[congs_OriginalPaperLogType.UpdDate] == DBNull.Value ? null : objRow[congs_OriginalPaperLogType.UpdDate].ToString().Trim(); //修改日期
objgs_OriginalPaperLogTypeEN.Memo = objRow[congs_OriginalPaperLogType.Memo] == DBNull.Value ? null : objRow[congs_OriginalPaperLogType.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objgs_OriginalPaperLogTypeEN.LogTypeId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objgs_OriginalPaperLogTypeEN);
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
public static List<clsgs_OriginalPaperLogTypeEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsgs_OriginalPaperLogTypeEN> arrObjLst = new List<clsgs_OriginalPaperLogTypeEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsgs_OriginalPaperLogTypeEN objgs_OriginalPaperLogTypeEN = new clsgs_OriginalPaperLogTypeEN();
try
{
objgs_OriginalPaperLogTypeEN.LogTypeId = objRow[congs_OriginalPaperLogType.LogTypeId].ToString().Trim(); //日志类型Id
objgs_OriginalPaperLogTypeEN.LogTypeName = objRow[congs_OriginalPaperLogType.LogTypeName] == DBNull.Value ? null : objRow[congs_OriginalPaperLogType.LogTypeName].ToString().Trim(); //日志类型名
objgs_OriginalPaperLogTypeEN.UpdUser = objRow[congs_OriginalPaperLogType.UpdUser] == DBNull.Value ? null : objRow[congs_OriginalPaperLogType.UpdUser].ToString().Trim(); //修改人
objgs_OriginalPaperLogTypeEN.UpdDate = objRow[congs_OriginalPaperLogType.UpdDate] == DBNull.Value ? null : objRow[congs_OriginalPaperLogType.UpdDate].ToString().Trim(); //修改日期
objgs_OriginalPaperLogTypeEN.Memo = objRow[congs_OriginalPaperLogType.Memo] == DBNull.Value ? null : objRow[congs_OriginalPaperLogType.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objgs_OriginalPaperLogTypeEN.LogTypeId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objgs_OriginalPaperLogTypeEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsgs_OriginalPaperLogTypeEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsgs_OriginalPaperLogTypeEN> arrObjLst = new List<clsgs_OriginalPaperLogTypeEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsgs_OriginalPaperLogTypeEN objgs_OriginalPaperLogTypeEN = new clsgs_OriginalPaperLogTypeEN();
try
{
objgs_OriginalPaperLogTypeEN.LogTypeId = objRow[congs_OriginalPaperLogType.LogTypeId].ToString().Trim(); //日志类型Id
objgs_OriginalPaperLogTypeEN.LogTypeName = objRow[congs_OriginalPaperLogType.LogTypeName] == DBNull.Value ? null : objRow[congs_OriginalPaperLogType.LogTypeName].ToString().Trim(); //日志类型名
objgs_OriginalPaperLogTypeEN.UpdUser = objRow[congs_OriginalPaperLogType.UpdUser] == DBNull.Value ? null : objRow[congs_OriginalPaperLogType.UpdUser].ToString().Trim(); //修改人
objgs_OriginalPaperLogTypeEN.UpdDate = objRow[congs_OriginalPaperLogType.UpdDate] == DBNull.Value ? null : objRow[congs_OriginalPaperLogType.UpdDate].ToString().Trim(); //修改日期
objgs_OriginalPaperLogTypeEN.Memo = objRow[congs_OriginalPaperLogType.Memo] == DBNull.Value ? null : objRow[congs_OriginalPaperLogType.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objgs_OriginalPaperLogTypeEN.LogTypeId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objgs_OriginalPaperLogTypeEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objgs_OriginalPaperLogTypeEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool Getgs_OriginalPaperLogType(ref clsgs_OriginalPaperLogTypeEN objgs_OriginalPaperLogTypeEN)
{
bool bolResult = gs_OriginalPaperLogTypeDA.Getgs_OriginalPaperLogType(ref objgs_OriginalPaperLogTypeEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "strLogTypeId">表关键字</param>
 /// <returns>表对象</returns>
public static clsgs_OriginalPaperLogTypeEN GetObjByLogTypeId(string strLogTypeId)
{
if (strLogTypeId.IndexOf(' ') >=0)
{
var strMsg = string.Format("(errid:Busi000079)在表中,关键字[strLogTypeId]中不能有空格!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
if (string.IsNullOrEmpty(strLogTypeId) == true)
{
var strMsg = string.Format("(errid:Busi000020)在表中,关键字[strLogTypeId]不能为空!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
clsgs_OriginalPaperLogTypeEN objgs_OriginalPaperLogTypeEN = gs_OriginalPaperLogTypeDA.GetObjByLogTypeId(strLogTypeId);
return objgs_OriginalPaperLogTypeEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsgs_OriginalPaperLogTypeEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsgs_OriginalPaperLogTypeEN objgs_OriginalPaperLogTypeEN = gs_OriginalPaperLogTypeDA.GetFirstObj(strWhereCond);
 return objgs_OriginalPaperLogTypeEN;
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
public static clsgs_OriginalPaperLogTypeEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsgs_OriginalPaperLogTypeEN objgs_OriginalPaperLogTypeEN = gs_OriginalPaperLogTypeDA.GetObjByDataRow(objRow);
 return objgs_OriginalPaperLogTypeEN;
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
public static clsgs_OriginalPaperLogTypeEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsgs_OriginalPaperLogTypeEN objgs_OriginalPaperLogTypeEN = gs_OriginalPaperLogTypeDA.GetObjByDataRow(objRow);
 return objgs_OriginalPaperLogTypeEN;
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
 /// <param name = "strLogTypeId">所给的关键字</param>
 /// <param name = "lstgs_OriginalPaperLogTypeObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsgs_OriginalPaperLogTypeEN GetObjByLogTypeIdFromList(string strLogTypeId, List<clsgs_OriginalPaperLogTypeEN> lstgs_OriginalPaperLogTypeObjLst)
{
foreach (clsgs_OriginalPaperLogTypeEN objgs_OriginalPaperLogTypeEN in lstgs_OriginalPaperLogTypeObjLst)
{
if (objgs_OriginalPaperLogTypeEN.LogTypeId == strLogTypeId)
{
return objgs_OriginalPaperLogTypeEN;
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
 string strMaxLogTypeId;
 try
 {
 strMaxLogTypeId = clsgs_OriginalPaperLogTypeDA.GetMaxStrId();
 return strMaxLogTypeId;
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
 string strLogTypeId;
 try
 {
 strLogTypeId = new clsgs_OriginalPaperLogTypeDA().GetFirstID(strWhereCond);
 return strLogTypeId;
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
 arrList = gs_OriginalPaperLogTypeDA.GetID(strWhereCond);
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
bool bolIsExist = gs_OriginalPaperLogTypeDA.IsExistCondRec(strWhereCond);
return bolIsExist;
}

 /// <summary>
 /// 判断当前表中是否存在给定关键字值的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExist)
 /// </summary>
 /// <param name = "strLogTypeId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public static bool IsExist(string strLogTypeId)
{
if (string.IsNullOrEmpty(strLogTypeId) == true)
{
var strMsg = string.Format("(errid:Busi000027)在表中,关键字[strLogTypeId]不能为空!!(from {0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
//检测记录是否存在
bool bolIsExist = gs_OriginalPaperLogTypeDA.IsExist(strLogTypeId);
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
 bolIsExist = clsgs_OriginalPaperLogTypeDA.IsExistTable();
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
 bolIsExist = gs_OriginalPaperLogTypeDA.IsExistTable(strTabName);
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
 /// <param name = "objgs_OriginalPaperLogTypeEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecordBySql2(clsgs_OriginalPaperLogTypeEN objgs_OriginalPaperLogTypeEN, bool bolIsNeedCheckUniqueness=true)
{
if (bolIsNeedCheckUniqueness == true && objgs_OriginalPaperLogTypeEN.CheckUniqueness() == false)
{
var strMsg = string.Format("记录已经存在!日志类型Id = [{0}]的数据已经存在!(in clsgs_OriginalPaperLogTypeBL.AddNewRecordBySql2)", objgs_OriginalPaperLogTypeEN.LogTypeId);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objgs_OriginalPaperLogTypeEN.LogTypeId) == true || clsgs_OriginalPaperLogTypeBL.IsExist(objgs_OriginalPaperLogTypeEN.LogTypeId) == true)
 {
     objgs_OriginalPaperLogTypeEN.LogTypeId = clsgs_OriginalPaperLogTypeBL.GetMaxStrId_S();
 }
bool bolResult = gs_OriginalPaperLogTypeDA.AddNewRecordBySQL2(objgs_OriginalPaperLogTypeEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsgs_OriginalPaperLogTypeBL.ReFreshCache();

if (clsgs_OriginalPaperLogTypeBL.relatedActions != null)
{
clsgs_OriginalPaperLogTypeBL.relatedActions.UpdRelaTabDate(objgs_OriginalPaperLogTypeEN.LogTypeId, "SetUpdDate");
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
 /// <param name = "objgs_OriginalPaperLogTypeEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordBySql2WithReturnKey(clsgs_OriginalPaperLogTypeEN objgs_OriginalPaperLogTypeEN, bool bolIsNeedCheckUniqueness=true)
{
if (bolIsNeedCheckUniqueness == true && objgs_OriginalPaperLogTypeEN.CheckUniqueness() == false)
{
var strMsg = string.Format("记录已经存在!日志类型Id = [{0}]的数据已经存在!(in clsgs_OriginalPaperLogTypeBL.AddNewRecordBySql2WithReturnKey)", objgs_OriginalPaperLogTypeEN.LogTypeId);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objgs_OriginalPaperLogTypeEN.LogTypeId) == true || clsgs_OriginalPaperLogTypeBL.IsExist(objgs_OriginalPaperLogTypeEN.LogTypeId) == true)
 {
     objgs_OriginalPaperLogTypeEN.LogTypeId = clsgs_OriginalPaperLogTypeBL.GetMaxStrId_S();
 }
string strKey = gs_OriginalPaperLogTypeDA.AddNewRecordBySQL2WithReturnKey(objgs_OriginalPaperLogTypeEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsgs_OriginalPaperLogTypeBL.ReFreshCache();

if (clsgs_OriginalPaperLogTypeBL.relatedActions != null)
{
clsgs_OriginalPaperLogTypeBL.relatedActions.UpdRelaTabDate(objgs_OriginalPaperLogTypeEN.LogTypeId, "SetUpdDate");
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
 /// <param name = "objgs_OriginalPaperLogTypeEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(clsgs_OriginalPaperLogTypeEN objgs_OriginalPaperLogTypeEN)
{
try
{
bool bolResult = gs_OriginalPaperLogTypeDA.Update(objgs_OriginalPaperLogTypeEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsgs_OriginalPaperLogTypeBL.ReFreshCache();

if (clsgs_OriginalPaperLogTypeBL.relatedActions != null)
{
clsgs_OriginalPaperLogTypeBL.relatedActions.UpdRelaTabDate(objgs_OriginalPaperLogTypeEN.LogTypeId, "SetUpdDate");
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
 /// <param name = "objgs_OriginalPaperLogTypeEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateBySql2(clsgs_OriginalPaperLogTypeEN objgs_OriginalPaperLogTypeEN)
{
 if (string.IsNullOrEmpty(objgs_OriginalPaperLogTypeEN.LogTypeId) == true)
 {
var strMsg = string.Format("(errid:Busi000065)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = gs_OriginalPaperLogTypeDA.UpdateBySql2(objgs_OriginalPaperLogTypeEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsgs_OriginalPaperLogTypeBL.ReFreshCache();

if (clsgs_OriginalPaperLogTypeBL.relatedActions != null)
{
clsgs_OriginalPaperLogTypeBL.relatedActions.UpdRelaTabDate(objgs_OriginalPaperLogTypeEN.LogTypeId, "SetUpdDate");
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
 /// <param name = "strLogTypeId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int DelRecord(string strLogTypeId)
{
try
{
 clsgs_OriginalPaperLogTypeEN objgs_OriginalPaperLogTypeEN = clsgs_OriginalPaperLogTypeBL.GetObjByLogTypeId(strLogTypeId);

if (clsgs_OriginalPaperLogTypeBL.relatedActions != null)
{
clsgs_OriginalPaperLogTypeBL.relatedActions.UpdRelaTabDate(objgs_OriginalPaperLogTypeEN.LogTypeId, "SetUpdDate");
}
if (objgs_OriginalPaperLogTypeEN != null)
{
int intRecNum = gs_OriginalPaperLogTypeDA.DelRecord(strLogTypeId);
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
/// <param name="strLogTypeId">表关键字</param>
/// <returns></returns>
public static bool DelRecordEx(string strLogTypeId )
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsgs_OriginalPaperLogTypeDA.GetSpecSQLObj();
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
//删除与表:[gs_OriginalPaperLogType]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//congs_OriginalPaperLogType.LogTypeId,
//strLogTypeId);
//        clsgs_OriginalPaperLogTypeBL.Delgs_OriginalPaperLogTypesByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsgs_OriginalPaperLogTypeBL.DelRecord(strLogTypeId, objConnection, objSqlTransaction);
objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsgs_OriginalPaperLogTypeBLEx", "DelRecordEx", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("扩展删除记录出错:{0}!keyId = {1}.({2})",
objException.Message,
strLogTypeId, clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "strLogTypeId">给定的关键字值</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回删除是否成功?</returns>
public static bool DelRecord(string strLogTypeId, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
if (clsgs_OriginalPaperLogTypeBL.relatedActions != null)
{
clsgs_OriginalPaperLogTypeBL.relatedActions.UpdRelaTabDate(strLogTypeId, "UpdRelaTabDate");
}
bool bolResult = gs_OriginalPaperLogTypeDA.DelRecord(strLogTypeId,objSqlConnection,objSqlTransaction);
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
 /// <param name = "arrLogTypeIdLst">给定的关键字值列表</param>
 /// <returns>返回删除的记录数</returns>
public static int Delgs_OriginalPaperLogTypes(List<string> arrLogTypeIdLst)
{
if (arrLogTypeIdLst.Count == 0) return 0;
try
{
if (clsgs_OriginalPaperLogTypeBL.relatedActions != null)
{
foreach (var strLogTypeId in arrLogTypeIdLst)
{
clsgs_OriginalPaperLogTypeBL.relatedActions.UpdRelaTabDate(strLogTypeId, "UpdRelaTabDate");
}
}
int intDelRecNum = gs_OriginalPaperLogTypeDA.Delgs_OriginalPaperLogType(arrLogTypeIdLst);
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
public static int Delgs_OriginalPaperLogTypesByCond(string strWhereCond)
{
try
{
if (clsgs_OriginalPaperLogTypeBL.relatedActions != null)
{
List<string> arrLogTypeId = GetPrimaryKeyID_S(strWhereCond);
foreach (var strLogTypeId in arrLogTypeId)
{
clsgs_OriginalPaperLogTypeBL.relatedActions.UpdRelaTabDate(strLogTypeId, "UpdRelaTabDate");
}
}
int intRecNum = gs_OriginalPaperLogTypeDA.Delgs_OriginalPaperLogType(strWhereCond);
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
/// 这里仅仅是演示函数,使用时请复制到扩展类:[gs_OriginalPaperLogType]中改名为:[DelRecord4MultiTabEx]使用
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DelRecord4MultiTab)
/// </summary>
/// <param name="strLogTypeId">表关键字</param>
/// <returns></returns>
public static bool DelRecord4MultiTab(string strLogTypeId)
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsgs_OriginalPaperLogTypeDA.GetSpecSQLObj();
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
//删除与表:[gs_OriginalPaperLogType]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conStudent.id_College,
//strid_College);
//        clsStudentBL.DelStudentsByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsgs_OriginalPaperLogTypeBL.DelRecord(strLogTypeId, objConnection, objSqlTransaction);
                objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsgs_OriginalPaperLogTypeBL", "DelRecord4MultiTab", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("删除多表记录出错:{0}!keyId = {1}.({2})",
objException.Message,
strLogTypeId, clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "objgs_OriginalPaperLogTypeENS">源对象</param>
 /// <param name = "objgs_OriginalPaperLogTypeENT">目标对象</param>
 public static void CopyTo(clsgs_OriginalPaperLogTypeEN objgs_OriginalPaperLogTypeENS, clsgs_OriginalPaperLogTypeEN objgs_OriginalPaperLogTypeENT)
{
try
{
objgs_OriginalPaperLogTypeENT.LogTypeId = objgs_OriginalPaperLogTypeENS.LogTypeId; //日志类型Id
objgs_OriginalPaperLogTypeENT.LogTypeName = objgs_OriginalPaperLogTypeENS.LogTypeName; //日志类型名
objgs_OriginalPaperLogTypeENT.UpdUser = objgs_OriginalPaperLogTypeENS.UpdUser; //修改人
objgs_OriginalPaperLogTypeENT.UpdDate = objgs_OriginalPaperLogTypeENS.UpdDate; //修改日期
objgs_OriginalPaperLogTypeENT.Memo = objgs_OriginalPaperLogTypeENS.Memo; //备注
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
 /// <param name = "objgs_OriginalPaperLogTypeEN">源简化对象</param>
 public static void SetUpdFlag(clsgs_OriginalPaperLogTypeEN objgs_OriginalPaperLogTypeEN)
{
try
{
objgs_OriginalPaperLogTypeEN.ClearUpdateState();
   string strsfUpdFldSetStr = objgs_OriginalPaperLogTypeEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(congs_OriginalPaperLogType.LogTypeId, new clsStrCompareIgnoreCase())  ==  true)
{
objgs_OriginalPaperLogTypeEN.LogTypeId = objgs_OriginalPaperLogTypeEN.LogTypeId; //日志类型Id
}
if (arrFldSet.Contains(congs_OriginalPaperLogType.LogTypeName, new clsStrCompareIgnoreCase())  ==  true)
{
objgs_OriginalPaperLogTypeEN.LogTypeName = objgs_OriginalPaperLogTypeEN.LogTypeName == "[null]" ? null :  objgs_OriginalPaperLogTypeEN.LogTypeName; //日志类型名
}
if (arrFldSet.Contains(congs_OriginalPaperLogType.UpdUser, new clsStrCompareIgnoreCase())  ==  true)
{
objgs_OriginalPaperLogTypeEN.UpdUser = objgs_OriginalPaperLogTypeEN.UpdUser == "[null]" ? null :  objgs_OriginalPaperLogTypeEN.UpdUser; //修改人
}
if (arrFldSet.Contains(congs_OriginalPaperLogType.UpdDate, new clsStrCompareIgnoreCase())  ==  true)
{
objgs_OriginalPaperLogTypeEN.UpdDate = objgs_OriginalPaperLogTypeEN.UpdDate == "[null]" ? null :  objgs_OriginalPaperLogTypeEN.UpdDate; //修改日期
}
if (arrFldSet.Contains(congs_OriginalPaperLogType.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objgs_OriginalPaperLogTypeEN.Memo = objgs_OriginalPaperLogTypeEN.Memo == "[null]" ? null :  objgs_OriginalPaperLogTypeEN.Memo; //备注
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
 /// <param name = "objgs_OriginalPaperLogTypeEN">源简化对象</param>
 public static void AccessFldValueNull(clsgs_OriginalPaperLogTypeEN objgs_OriginalPaperLogTypeEN)
{
try
{
if (objgs_OriginalPaperLogTypeEN.LogTypeName == "[null]") objgs_OriginalPaperLogTypeEN.LogTypeName = null; //日志类型名
if (objgs_OriginalPaperLogTypeEN.UpdUser == "[null]") objgs_OriginalPaperLogTypeEN.UpdUser = null; //修改人
if (objgs_OriginalPaperLogTypeEN.UpdDate == "[null]") objgs_OriginalPaperLogTypeEN.UpdDate = null; //修改日期
if (objgs_OriginalPaperLogTypeEN.Memo == "[null]") objgs_OriginalPaperLogTypeEN.Memo = null; //备注
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
public static void CheckPropertyNew(clsgs_OriginalPaperLogTypeEN objgs_OriginalPaperLogTypeEN)
{
 gs_OriginalPaperLogTypeDA.CheckPropertyNew(objgs_OriginalPaperLogTypeEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(clsgs_OriginalPaperLogTypeEN objgs_OriginalPaperLogTypeEN)
{
 gs_OriginalPaperLogTypeDA.CheckProperty4Condition(objgs_OriginalPaperLogTypeEN);
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
if (clsgs_OriginalPaperLogTypeBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsgs_OriginalPaperLogTypeBL没有刷新缓存机制(clsgs_OriginalPaperLogTypeBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by LogTypeId");
//if (arrgs_OriginalPaperLogTypeObjLstCache == null)
//{
//arrgs_OriginalPaperLogTypeObjLstCache = gs_OriginalPaperLogTypeDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "strLogTypeId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsgs_OriginalPaperLogTypeEN GetObjByLogTypeIdCache(string strLogTypeId)
{
//获取缓存中的对象列表
string strKey = string.Format("{0}", clsgs_OriginalPaperLogTypeEN._CurrTabName);
List<clsgs_OriginalPaperLogTypeEN> arrgs_OriginalPaperLogTypeObjLstCache = GetObjLstCache();
IEnumerable <clsgs_OriginalPaperLogTypeEN> arrgs_OriginalPaperLogTypeObjLst_Sel =
arrgs_OriginalPaperLogTypeObjLstCache
.Where(x=> x.LogTypeId == strLogTypeId 
);
if (arrgs_OriginalPaperLogTypeObjLst_Sel.Count() == 0)
{
   clsgs_OriginalPaperLogTypeEN obj = clsgs_OriginalPaperLogTypeBL.GetObjByLogTypeId(strLogTypeId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
 }
return null;
}
return arrgs_OriginalPaperLogTypeObjLst_Sel.First();
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsgs_OriginalPaperLogTypeEN> GetAllgs_OriginalPaperLogTypeObjLstCache()
{
//获取缓存中的对象列表
List<clsgs_OriginalPaperLogTypeEN> arrgs_OriginalPaperLogTypeObjLstCache = GetObjLstCache(); 
return arrgs_OriginalPaperLogTypeObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsgs_OriginalPaperLogTypeEN> GetObjLstCache()
{
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}", clsgs_OriginalPaperLogTypeEN._CurrTabName);
List<clsgs_OriginalPaperLogTypeEN> arrgs_OriginalPaperLogTypeObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrgs_OriginalPaperLogTypeObjLstCache;
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
string strKey = string.Format("{0}", clsgs_OriginalPaperLogTypeEN._CurrTabName);
CacheHelper.Remove(strKey);
clsgs_OriginalPaperLogTypeEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
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
if (clsgs_OriginalPaperLogTypeEN._RefreshTimeLst.Count == 0) return "";
return clsgs_OriginalPaperLogTypeEN._RefreshTimeLst[clsgs_OriginalPaperLogTypeEN._RefreshTimeLst.Count - 1];
}

 /// <summary>
 /// 刷新缓存.把当前表的缓存以及该表相关视图的缓存清空.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ReFreshCache)
 /// </summary>
public static void ReFreshCache()
{
if (clsgs_OriginalPaperLogTypeBL.objCommFun4BL != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}", clsgs_OriginalPaperLogTypeEN._CurrTabName);
CacheHelper.Remove(strKey);
clsgs_OriginalPaperLogTypeEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
clsgs_OriginalPaperLogTypeBL.objCommFun4BL.ReFreshCache();
}
}


 #endregion 缓存操作


 #region 检查唯一性

 /// <summary>
 /// 获取检查唯一性条件串(Uniqueness)--gs_OriginalPaperLogType(论文日志类型)
 /// 唯一性条件:LogTypeId
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetUniquenessConditionString)
 /// </summary>
 /// <param name = "objgs_OriginalPaperLogTypeEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(clsgs_OriginalPaperLogTypeEN objgs_OriginalPaperLogTypeEN)
{
//检测记录是否存在
string strResult = gs_OriginalPaperLogTypeDA.GetUniCondStr(objgs_OriginalPaperLogTypeEN);
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
public static string Func(string strInFldName, string strOutFldName, string strLogTypeId)
{
if (strInFldName != congs_OriginalPaperLogType.LogTypeId)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (congs_OriginalPaperLogType.AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", congs_OriginalPaperLogType.AttributeName));
throw new Exception(strMsg);
}
var objgs_OriginalPaperLogType = clsgs_OriginalPaperLogTypeBL.GetObjByLogTypeIdCache(strLogTypeId);
if (objgs_OriginalPaperLogType == null) return "";
return objgs_OriginalPaperLogType[strOutFldName].ToString();
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
int intRecCount = clsgs_OriginalPaperLogTypeDA.GetRecCount(strTabName);
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
int intRecCount = clsgs_OriginalPaperLogTypeDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsgs_OriginalPaperLogTypeDA.GetRecCount();
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
int intRecCount = clsgs_OriginalPaperLogTypeDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objgs_OriginalPaperLogTypeCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsgs_OriginalPaperLogTypeEN objgs_OriginalPaperLogTypeCond)
{
List<clsgs_OriginalPaperLogTypeEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsgs_OriginalPaperLogTypeEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in congs_OriginalPaperLogType.AttributeName)
{
if (objgs_OriginalPaperLogTypeCond.IsUpdated(strFldName) == false) continue;
if (objgs_OriginalPaperLogTypeCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objgs_OriginalPaperLogTypeCond[strFldName].ToString());
}
else
{
if (objgs_OriginalPaperLogTypeCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objgs_OriginalPaperLogTypeCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objgs_OriginalPaperLogTypeCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objgs_OriginalPaperLogTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objgs_OriginalPaperLogTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objgs_OriginalPaperLogTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objgs_OriginalPaperLogTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objgs_OriginalPaperLogTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objgs_OriginalPaperLogTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objgs_OriginalPaperLogTypeCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objgs_OriginalPaperLogTypeCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objgs_OriginalPaperLogTypeCond[strFldName]));
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
 List<string> arrList = clsgs_OriginalPaperLogTypeDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = gs_OriginalPaperLogTypeDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = gs_OriginalPaperLogTypeDA.GetFldValueNoDistinct(strFldName, strWhereCond);
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
int intRecCount = gs_OriginalPaperLogTypeDA.SetFldValue(strFldName, strValue, strWhereCond);
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
int intRecCount = clsgs_OriginalPaperLogTypeDA.SetFldValue(clsgs_OriginalPaperLogTypeEN._CurrTabName, strFldName, fltValue, strWhereCond);
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
int intRecCount = gs_OriginalPaperLogTypeDA.SetFldValue( strFldName, intValue, strWhereCond);
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
int intRecCount = clsgs_OriginalPaperLogTypeDA.SetFldValue(strTabName, strFldName, strValue, strWhereCond);
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
int intRecCount = clsgs_OriginalPaperLogTypeDA.SetFldValue(strTabName, strFldName, intValue, strWhereCond);
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
int intRecCount = clsgs_OriginalPaperLogTypeDA.SetFldValue(strTabName, strFldName, fltValue, strWhereCond);
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
  strCreateTabCode.Append("CREATE table [dbo].[gs_OriginalPaperLogType] "); 
 strCreateTabCode.Append(" ( "); 
 // /**日志类型Id*/ 
 strCreateTabCode.Append(" LogTypeId char(2) primary key, "); 
 // /**日志类型名*/ 
 strCreateTabCode.Append(" LogTypeName varchar(200) Null, "); 
 // /**修改人*/ 
 strCreateTabCode.Append(" UpdUser varchar(20) Null, "); 
 // /**修改日期*/ 
 strCreateTabCode.Append(" UpdDate varchar(20) Null, "); 
 // /**备注*/ 
 strCreateTabCode.Append(" Memo varchar(1000) Null ");
 strCreateTabCode.Append(") "); 
  strCreateTabCode.Append("ON [PRIMARY] ");
  return strCreateTabCode.ToString();
}



 #endregion 表操作
}
 /// <summary>
 /// 论文日志类型(gs_OriginalPaperLogType)
 /// 数据源类型:表
 /// (AutoGCLib.CommFun4BL4CSharp:GeneCode_This)
 /// </summary>
public class  clsCommFun4BL4gs_OriginalPaperLogType : clsCommFun4BL
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
clsgs_OriginalPaperLogTypeBL.ReFreshThisCache();
}
}

}