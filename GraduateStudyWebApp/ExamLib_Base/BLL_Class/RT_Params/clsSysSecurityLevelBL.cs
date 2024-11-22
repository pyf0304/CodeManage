
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsSysSecurityLevelBL
 表名:SysSecurityLevel(01120651)
 * 版本:2024.11.13.1(服务器:WIN-SRV103-116)
 日期:2024/11/13 06:14:14
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
public static class  clsSysSecurityLevelBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "strLevelId">表关键字</param>
 /// <returns>表对象</returns>
public static clsSysSecurityLevelEN GetObj(this K_LevelId_SysSecurityLevel myKey)
{
clsSysSecurityLevelEN objSysSecurityLevelEN = clsSysSecurityLevelBL.SysSecurityLevelDA.GetObjByLevelId(myKey.Value);
return objSysSecurityLevelEN;
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_AddNewRecord)
 /// </summary>
 /// <param name = "objSysSecurityLevelEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clsSysSecurityLevelEN objSysSecurityLevelEN, bool bolIsNeedCheckUniqueness = true)
{
if (bolIsNeedCheckUniqueness == true && CheckUniqueness(objSysSecurityLevelEN) == false)
{
var strMsg = string.Format("记录已经存在!级别Id = [{0}]的数据已经存在!(in clsSysSecurityLevelBL.AddNewRecord)", objSysSecurityLevelEN.LevelId);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objSysSecurityLevelEN.LevelId) == true || clsSysSecurityLevelBL.IsExist(objSysSecurityLevelEN.LevelId) == true)
 {
     objSysSecurityLevelEN.LevelId = clsSysSecurityLevelBL.GetMaxStrId_S();
 }
bool bolResult = clsSysSecurityLevelBL.SysSecurityLevelDA.AddNewRecordBySQL2(objSysSecurityLevelEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsSysSecurityLevelBL.ReFreshCache();

if (clsSysSecurityLevelBL.relatedActions != null)
{
clsSysSecurityLevelBL.relatedActions.UpdRelaTabDate(objSysSecurityLevelEN.LevelId, "SetUpdDate");
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
public static bool AddRecordEx(this clsSysSecurityLevelEN objSysSecurityLevelEN, bool bolIsNeedCheckUniqueness = true)
{
//操作步骤:
//1、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在
//2、检查唯一性
//3、检查传进去的对象属性是否合法
//4、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
//1、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在

//因为是字符型自增主键,不需要检查主键是否已经存在,在添加时,再获取 最大值作为主键
//if (clsSysSecurityLevelBL.IsExist(objSysSecurityLevelEN.LevelId))	//判断是否有相同的关键字
//{
//strMsg = "(errid:Busi000151)关键字字段已有相同的值";
//throw new Exception(strMsg);
//}
try
{
 //2、检查传进去的对象属性是否合法
objSysSecurityLevelEN.CheckPropertyNew();
 ///5.2、检查唯一性
if (bolIsNeedCheckUniqueness == true && objSysSecurityLevelEN.CheckUniqueness() == false)
{
strMsg = string.Format("(级别Id(LevelId)=[{0}])已经存在,不能重复!", objSysSecurityLevelEN.LevelId);
throw new Exception(strMsg);
}
//因为是字符型自增主键,所以在添加时,自动获取主键值。
 if (string.IsNullOrEmpty(objSysSecurityLevelEN.LevelId) == true || clsSysSecurityLevelBL.IsExist(objSysSecurityLevelEN.LevelId) == true)
 {
     objSysSecurityLevelEN.LevelId = clsSysSecurityLevelBL.GetMaxStrId_S();
 }
//6、把数据实体层的数据存贮到数据库中
objSysSecurityLevelEN.AddNewRecord();
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
 /// <param name = "objSysSecurityLevelEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static string AddNewRecordWithMaxId(this clsSysSecurityLevelEN objSysSecurityLevelEN, bool bolIsNeedCheckUniqueness = true)
{
if (bolIsNeedCheckUniqueness == true && CheckUniqueness(objSysSecurityLevelEN) == false)
{
var strMsg = string.Format("记录已经存在!级别Id = [{0}]的数据已经存在!(in clsSysSecurityLevelBL.AddNewRecordWithMaxId)", objSysSecurityLevelEN.LevelId);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objSysSecurityLevelEN.LevelId) == true || clsSysSecurityLevelBL.IsExist(objSysSecurityLevelEN.LevelId) == true)
 {
     objSysSecurityLevelEN.LevelId = clsSysSecurityLevelBL.GetMaxStrId_S();
 }
string strLevelId = clsSysSecurityLevelBL.SysSecurityLevelDA.AddNewRecordBySQL2WithReturnKey(objSysSecurityLevelEN);
     objSysSecurityLevelEN.LevelId = strLevelId;
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsSysSecurityLevelBL.ReFreshCache();

if (clsSysSecurityLevelBL.relatedActions != null)
{
clsSysSecurityLevelBL.relatedActions.UpdRelaTabDate(objSysSecurityLevelEN.LevelId, "SetUpdDate");
}
return strLevelId;
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
 /// <param name = "objSysSecurityLevelEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordWithReturnKey(this clsSysSecurityLevelEN objSysSecurityLevelEN, bool bolIsNeedCheckUniqueness = true)
{
if (bolIsNeedCheckUniqueness == true && CheckUniqueness(objSysSecurityLevelEN) == false)
{
var strMsg = string.Format("记录已经存在!级别Id = [{0}]的数据已经存在!(in clsSysSecurityLevelBL.AddNewRecordWithReturnKey)", objSysSecurityLevelEN.LevelId);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objSysSecurityLevelEN.LevelId) == true || clsSysSecurityLevelBL.IsExist(objSysSecurityLevelEN.LevelId) == true)
 {
     objSysSecurityLevelEN.LevelId = clsSysSecurityLevelBL.GetMaxStrId_S();
 }
string strKey = clsSysSecurityLevelBL.SysSecurityLevelDA.AddNewRecordBySQL2WithReturnKey(objSysSecurityLevelEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsSysSecurityLevelBL.ReFreshCache();

if (clsSysSecurityLevelBL.relatedActions != null)
{
clsSysSecurityLevelBL.relatedActions.UpdRelaTabDate(objSysSecurityLevelEN.LevelId, "SetUpdDate");
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
 /// <param name = "objSysSecurityLevelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsSysSecurityLevelEN SetLevelId(this clsSysSecurityLevelEN objSysSecurityLevelEN, string strLevelId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strLevelId, 2, conSysSecurityLevel.LevelId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strLevelId, 2, conSysSecurityLevel.LevelId);
}
objSysSecurityLevelEN.LevelId = strLevelId; //级别Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objSysSecurityLevelEN.dicFldComparisonOp.ContainsKey(conSysSecurityLevel.LevelId) == false)
{
objSysSecurityLevelEN.dicFldComparisonOp.Add(conSysSecurityLevel.LevelId, strComparisonOp);
}
else
{
objSysSecurityLevelEN.dicFldComparisonOp[conSysSecurityLevel.LevelId] = strComparisonOp;
}
}
return objSysSecurityLevelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objSysSecurityLevelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsSysSecurityLevelEN SetLevelName(this clsSysSecurityLevelEN objSysSecurityLevelEN, string strLevelName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strLevelName, 50, conSysSecurityLevel.LevelName);
}
objSysSecurityLevelEN.LevelName = strLevelName; //级别名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objSysSecurityLevelEN.dicFldComparisonOp.ContainsKey(conSysSecurityLevel.LevelName) == false)
{
objSysSecurityLevelEN.dicFldComparisonOp.Add(conSysSecurityLevel.LevelName, strComparisonOp);
}
else
{
objSysSecurityLevelEN.dicFldComparisonOp[conSysSecurityLevel.LevelName] = strComparisonOp;
}
}
return objSysSecurityLevelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objSysSecurityLevelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsSysSecurityLevelEN SetMemo(this clsSysSecurityLevelEN objSysSecurityLevelEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, conSysSecurityLevel.Memo);
}
objSysSecurityLevelEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objSysSecurityLevelEN.dicFldComparisonOp.ContainsKey(conSysSecurityLevel.Memo) == false)
{
objSysSecurityLevelEN.dicFldComparisonOp.Add(conSysSecurityLevel.Memo, strComparisonOp);
}
else
{
objSysSecurityLevelEN.dicFldComparisonOp[conSysSecurityLevel.Memo] = strComparisonOp;
}
}
return objSysSecurityLevelEN;
	}

 /// <summary>
 /// 修改记录存盘到数据表中
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_UpdateRecordEx)
 /// </summary>
 /// <param name = "objSysSecurityLevelEN">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool UpdateRecordEx(this clsSysSecurityLevelEN objSysSecurityLevelEN)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
try
{
//1、检查传进去的对象属性是否合法
objSysSecurityLevelEN.CheckPropertyNew();
clsSysSecurityLevelEN objSysSecurityLevelCond = new clsSysSecurityLevelEN();
string strCondition = objSysSecurityLevelCond
.SetLevelId(objSysSecurityLevelEN.LevelId, "<>")
.SetLevelId(objSysSecurityLevelEN.LevelId, "=")
.GetCombineCondition();
objSysSecurityLevelEN._IsCheckProperty = true;
bool bolIsExist = clsSysSecurityLevelBL.IsExistRecord(strCondition);
if (bolIsExist)
{
strMsg = "(LevelId)不能重复!";
throw new Exception(strMsg);
}
//4、把数据实体层的数据存贮到数据库中
objSysSecurityLevelEN.Update();
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
 /// <param name = "objSysSecurityLevel">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool EditRecordEx(this clsSysSecurityLevelEN objSysSecurityLevel)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
clsSysSecurityLevelEN objSysSecurityLevelCond = new clsSysSecurityLevelEN();
string strCondition = objSysSecurityLevelCond
.SetLevelId(objSysSecurityLevel.LevelId, "=")
.GetCombineCondition();
objSysSecurityLevel._IsCheckProperty = true;
bool bolIsExist = clsSysSecurityLevelBL.IsExistRecord(strCondition);
if (bolIsExist)
{
objSysSecurityLevel.LevelId = clsSysSecurityLevelBL.GetFirstID_S(strCondition);
objSysSecurityLevel.UpdateWithCondition(strCondition);
}
else
{
objSysSecurityLevel.LevelId = clsSysSecurityLevelBL.GetMaxStrId_S();
objSysSecurityLevel.AddNewRecord();
}
return true; 
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_Update)
 /// </summary>
 /// <param name = "objSysSecurityLevelEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsSysSecurityLevelEN objSysSecurityLevelEN)
{
 if (string.IsNullOrEmpty(objSysSecurityLevelEN.LevelId) == true)
 {
string strMsg = string.Format("(errid:Busi000095)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsSysSecurityLevelBL.SysSecurityLevelDA.UpdateBySql2(objSysSecurityLevelEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsSysSecurityLevelBL.ReFreshCache();

if (clsSysSecurityLevelBL.relatedActions != null)
{
clsSysSecurityLevelBL.relatedActions.UpdRelaTabDate(objSysSecurityLevelEN.LevelId, "SetUpdDate");
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
 /// <param name = "objSysSecurityLevelEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsSysSecurityLevelEN objSysSecurityLevelEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (string.IsNullOrEmpty(objSysSecurityLevelEN.LevelId) == true)
 {
string strMsg = string.Format("(errid:Busi000087)修改记录时关键字不能为空!(带事务处理)(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsSysSecurityLevelBL.SysSecurityLevelDA.UpdateBySql2(objSysSecurityLevelEN, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsSysSecurityLevelBL.ReFreshCache();

if (clsSysSecurityLevelBL.relatedActions != null)
{
clsSysSecurityLevelBL.relatedActions.UpdRelaTabDate(objSysSecurityLevelEN.LevelId, "SetUpdDate");
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
 /// <param name = "objSysSecurityLevelEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsSysSecurityLevelEN objSysSecurityLevelEN, string strWhereCond)
{
try
{
bool bolResult = clsSysSecurityLevelBL.SysSecurityLevelDA.UpdateBySqlWithCondition(objSysSecurityLevelEN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsSysSecurityLevelBL.ReFreshCache();

if (clsSysSecurityLevelBL.relatedActions != null)
{
clsSysSecurityLevelBL.relatedActions.UpdRelaTabDate(objSysSecurityLevelEN.LevelId, "SetUpdDate");
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
 /// <param name = "objSysSecurityLevelEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsSysSecurityLevelEN objSysSecurityLevelEN, string strWhereCond, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
bool bolResult = clsSysSecurityLevelBL.SysSecurityLevelDA.UpdateBySqlWithConditionTransaction(objSysSecurityLevelEN, strWhereCond, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsSysSecurityLevelBL.ReFreshCache();

if (clsSysSecurityLevelBL.relatedActions != null)
{
clsSysSecurityLevelBL.relatedActions.UpdRelaTabDate(objSysSecurityLevelEN.LevelId, "SetUpdDate");
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
 /// <param name = "strLevelId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int Delete(this clsSysSecurityLevelEN objSysSecurityLevelEN)
{
try
{
int intRecNum = clsSysSecurityLevelBL.SysSecurityLevelDA.DelRecord(objSysSecurityLevelEN.LevelId);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsSysSecurityLevelBL.ReFreshCache();

if (clsSysSecurityLevelBL.relatedActions != null)
{
clsSysSecurityLevelBL.relatedActions.UpdRelaTabDate(objSysSecurityLevelEN.LevelId, "SetUpdDate");
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
 /// <param name = "objSysSecurityLevelENS">源对象</param>
 /// <param name = "objSysSecurityLevelENT">目标对象</param>
 public static void CopyTo(this clsSysSecurityLevelEN objSysSecurityLevelENS, clsSysSecurityLevelEN objSysSecurityLevelENT)
{
try
{
objSysSecurityLevelENT.LevelId = objSysSecurityLevelENS.LevelId; //级别Id
objSysSecurityLevelENT.LevelName = objSysSecurityLevelENS.LevelName; //级别名称
objSysSecurityLevelENT.Memo = objSysSecurityLevelENS.Memo; //备注
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
 /// <param name = "objSysSecurityLevelENS">源对象</param>
 /// <returns>目标对象=>clsSysSecurityLevelEN:objSysSecurityLevelENT</returns>
 public static clsSysSecurityLevelEN CopyTo(this clsSysSecurityLevelEN objSysSecurityLevelENS)
{
try
{
 clsSysSecurityLevelEN objSysSecurityLevelENT = new clsSysSecurityLevelEN()
{
LevelId = objSysSecurityLevelENS.LevelId, //级别Id
LevelName = objSysSecurityLevelENS.LevelName, //级别名称
Memo = objSysSecurityLevelENS.Memo, //备注
};
 return objSysSecurityLevelENT;
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
public static void CheckPropertyNew(this clsSysSecurityLevelEN objSysSecurityLevelEN)
{
 clsSysSecurityLevelBL.SysSecurityLevelDA.CheckPropertyNew(objSysSecurityLevelEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(this clsSysSecurityLevelEN objSysSecurityLevelEN)
{
 clsSysSecurityLevelBL.SysSecurityLevelDA.CheckProperty4Condition(objSysSecurityLevelEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsSysSecurityLevelEN objSysSecurityLevelCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objSysSecurityLevelCond.IsUpdated(conSysSecurityLevel.LevelId) == true)
{
string strComparisonOpLevelId = objSysSecurityLevelCond.dicFldComparisonOp[conSysSecurityLevel.LevelId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conSysSecurityLevel.LevelId, objSysSecurityLevelCond.LevelId, strComparisonOpLevelId);
}
if (objSysSecurityLevelCond.IsUpdated(conSysSecurityLevel.LevelName) == true)
{
string strComparisonOpLevelName = objSysSecurityLevelCond.dicFldComparisonOp[conSysSecurityLevel.LevelName];
strWhereCond += string.Format(" And {0} {2} '{1}'", conSysSecurityLevel.LevelName, objSysSecurityLevelCond.LevelName, strComparisonOpLevelName);
}
if (objSysSecurityLevelCond.IsUpdated(conSysSecurityLevel.Memo) == true)
{
string strComparisonOpMemo = objSysSecurityLevelCond.dicFldComparisonOp[conSysSecurityLevel.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", conSysSecurityLevel.Memo, objSysSecurityLevelCond.Memo, strComparisonOpMemo);
}
 return strWhereCond;
}

 /// <summary>
 /// 检查唯一性(Uniqueness)--SysSecurityLevel(保密级别表), 如果不唯一,即存在相同的记录,就返回False
 /// 唯一性条件:LevelId
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckConstraint)
 /// </summary>
 /// <param name = "objSysSecurityLevelEN">要求唯一的对象</param>
 /// <returns></returns>
public static bool CheckUniqueness(this clsSysSecurityLevelEN objSysSecurityLevelEN)
{
//检测记录是否存在
bool bolIsUniqueness;
StringBuilder sbCondition = new StringBuilder();
if (objSysSecurityLevelEN == null) return true;
if (objSysSecurityLevelEN.LevelId == null || objSysSecurityLevelEN.LevelId == "")
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and LevelId = '{0}'", objSysSecurityLevelEN.LevelId);
if (clsSysSecurityLevelBL.IsExistRecord(sbCondition.ToString())  ==  true)
{
 bolIsUniqueness = false;
}
else
{
 bolIsUniqueness = true;
}
}
 else {
sbCondition.AppendFormat("LevelId !=  '{0}'", objSysSecurityLevelEN.LevelId);
 sbCondition.AppendFormat(" and LevelId = '{0}'", objSysSecurityLevelEN.LevelId);
if (clsSysSecurityLevelBL.IsExistRecord(sbCondition.ToString())  ==  true)
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
 /// 获取唯一性条件串--SysSecurityLevel(保密级别表), 即由对象中唯一性条件字段关键字与值组成的条件串
 /// 唯一性条件:LevelId
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetConditionString4Constraint)
 /// </summary>
 /// <param name = "objSysSecurityLevelEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(this clsSysSecurityLevelEN objSysSecurityLevelEN)
{
//检测记录是否存在
StringBuilder sbCondition = new StringBuilder();
if (objSysSecurityLevelEN == null) return "";
if (objSysSecurityLevelEN.LevelId == null || objSysSecurityLevelEN.LevelId == "")
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and LevelId = '{0}'", objSysSecurityLevelEN.LevelId);
return sbCondition.ToString();
}
 else {
sbCondition.AppendFormat("LevelId !=  '{0}'", objSysSecurityLevelEN.LevelId);
 sbCondition.AppendFormat(" and LevelId = '{0}'", objSysSecurityLevelEN.LevelId);
 return sbCondition.ToString();
}
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_SysSecurityLevel
{
public virtual bool UpdRelaTabDate(string strLevelId, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// 保密级别表(SysSecurityLevel)
 /// 数据源类型:表
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsSysSecurityLevelBL
{
public static RelatedActions_SysSecurityLevel relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsSysSecurityLevelDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsSysSecurityLevelDA SysSecurityLevelDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsSysSecurityLevelDA();
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
 public clsSysSecurityLevelBL()
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
if (string.IsNullOrEmpty(clsSysSecurityLevelEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsSysSecurityLevelEN._ConnectString);
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
public static DataTable GetDataTable_SysSecurityLevel(string strWhereCond)
{
DataTable objDT;
try
{
objDT = SysSecurityLevelDA.GetDataTable_SysSecurityLevel(strWhereCond);
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
objDT = SysSecurityLevelDA.GetDataTable(strWhereCond);
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
objDT = SysSecurityLevelDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = SysSecurityLevelDA.GetDataTable(strWhereCond, strTabName);
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
objDT = SysSecurityLevelDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = SysSecurityLevelDA.GetDataTable_Top(objTopPara);
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
objDT = SysSecurityLevelDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = SysSecurityLevelDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = SysSecurityLevelDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
 /// <param name = "arrLevelIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static List<clsSysSecurityLevelEN> GetObjLstByLevelIdLst(List<string> arrLevelIdLst)
{
List<clsSysSecurityLevelEN> arrObjLst = new List<clsSysSecurityLevelEN>(); 
System.Data.DataTable objDT; 
 string strSqlConditionStr = clsArray.GetSqlInStrByArray(arrLevelIdLst, true);
 string strWhereCond = string.Format("LevelId in ({0})", strSqlConditionStr);
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsSysSecurityLevelEN objSysSecurityLevelEN = new clsSysSecurityLevelEN();
try
{
objSysSecurityLevelEN.LevelId = objRow[conSysSecurityLevel.LevelId].ToString().Trim(); //级别Id
objSysSecurityLevelEN.LevelName = objRow[conSysSecurityLevel.LevelName] == DBNull.Value ? null : objRow[conSysSecurityLevel.LevelName].ToString().Trim(); //级别名称
objSysSecurityLevelEN.Memo = objRow[conSysSecurityLevel.Memo] == DBNull.Value ? null : objRow[conSysSecurityLevel.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objSysSecurityLevelEN.LevelId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objSysSecurityLevelEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrLevelIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsSysSecurityLevelEN> GetObjLstByLevelIdLstCache(List<string> arrLevelIdLst)
{
string strKey = string.Format("{0}", clsSysSecurityLevelEN._CurrTabName);
List<clsSysSecurityLevelEN> arrSysSecurityLevelObjLstCache = GetObjLstCache();
IEnumerable <clsSysSecurityLevelEN> arrSysSecurityLevelObjLst_Sel =
arrSysSecurityLevelObjLstCache
.Where(x => arrLevelIdLst.Contains(x.LevelId));
return arrSysSecurityLevelObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsSysSecurityLevelEN> GetObjLst(string strWhereCond)
{
List<clsSysSecurityLevelEN> arrObjLst = new List<clsSysSecurityLevelEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsSysSecurityLevelEN objSysSecurityLevelEN = new clsSysSecurityLevelEN();
try
{
objSysSecurityLevelEN.LevelId = objRow[conSysSecurityLevel.LevelId].ToString().Trim(); //级别Id
objSysSecurityLevelEN.LevelName = objRow[conSysSecurityLevel.LevelName] == DBNull.Value ? null : objRow[conSysSecurityLevel.LevelName].ToString().Trim(); //级别名称
objSysSecurityLevelEN.Memo = objRow[conSysSecurityLevel.Memo] == DBNull.Value ? null : objRow[conSysSecurityLevel.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objSysSecurityLevelEN.LevelId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objSysSecurityLevelEN);
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
public static List<clsSysSecurityLevelEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsSysSecurityLevelEN> arrObjLst = new List<clsSysSecurityLevelEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsSysSecurityLevelEN objSysSecurityLevelEN = new clsSysSecurityLevelEN();
try
{
objSysSecurityLevelEN.LevelId = objRow[conSysSecurityLevel.LevelId].ToString().Trim(); //级别Id
objSysSecurityLevelEN.LevelName = objRow[conSysSecurityLevel.LevelName] == DBNull.Value ? null : objRow[conSysSecurityLevel.LevelName].ToString().Trim(); //级别名称
objSysSecurityLevelEN.Memo = objRow[conSysSecurityLevel.Memo] == DBNull.Value ? null : objRow[conSysSecurityLevel.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objSysSecurityLevelEN.LevelId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objSysSecurityLevelEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objSysSecurityLevelCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsSysSecurityLevelEN> GetSubObjLstCache(clsSysSecurityLevelEN objSysSecurityLevelCond)
{
List<clsSysSecurityLevelEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsSysSecurityLevelEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conSysSecurityLevel.AttributeName)
{
if (objSysSecurityLevelCond.IsUpdated(strFldName) == false) continue;
if (objSysSecurityLevelCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objSysSecurityLevelCond[strFldName].ToString());
}
else
{
if (objSysSecurityLevelCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objSysSecurityLevelCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objSysSecurityLevelCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objSysSecurityLevelCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objSysSecurityLevelCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objSysSecurityLevelCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objSysSecurityLevelCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objSysSecurityLevelCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objSysSecurityLevelCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objSysSecurityLevelCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objSysSecurityLevelCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objSysSecurityLevelCond[strFldName]));
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
public static List<clsSysSecurityLevelEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsSysSecurityLevelEN> arrObjLst = new List<clsSysSecurityLevelEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsSysSecurityLevelEN objSysSecurityLevelEN = new clsSysSecurityLevelEN();
try
{
objSysSecurityLevelEN.LevelId = objRow[conSysSecurityLevel.LevelId].ToString().Trim(); //级别Id
objSysSecurityLevelEN.LevelName = objRow[conSysSecurityLevel.LevelName] == DBNull.Value ? null : objRow[conSysSecurityLevel.LevelName].ToString().Trim(); //级别名称
objSysSecurityLevelEN.Memo = objRow[conSysSecurityLevel.Memo] == DBNull.Value ? null : objRow[conSysSecurityLevel.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objSysSecurityLevelEN.LevelId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objSysSecurityLevelEN);
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
public static List<clsSysSecurityLevelEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsSysSecurityLevelEN> arrObjLst = new List<clsSysSecurityLevelEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsSysSecurityLevelEN objSysSecurityLevelEN = new clsSysSecurityLevelEN();
try
{
objSysSecurityLevelEN.LevelId = objRow[conSysSecurityLevel.LevelId].ToString().Trim(); //级别Id
objSysSecurityLevelEN.LevelName = objRow[conSysSecurityLevel.LevelName] == DBNull.Value ? null : objRow[conSysSecurityLevel.LevelName].ToString().Trim(); //级别名称
objSysSecurityLevelEN.Memo = objRow[conSysSecurityLevel.Memo] == DBNull.Value ? null : objRow[conSysSecurityLevel.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objSysSecurityLevelEN.LevelId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objSysSecurityLevelEN);
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
List<clsSysSecurityLevelEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsSysSecurityLevelEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsSysSecurityLevelEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsSysSecurityLevelEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsSysSecurityLevelEN> arrObjLst = new List<clsSysSecurityLevelEN>(); 
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
	clsSysSecurityLevelEN objSysSecurityLevelEN = new clsSysSecurityLevelEN();
try
{
objSysSecurityLevelEN.LevelId = objRow[conSysSecurityLevel.LevelId].ToString().Trim(); //级别Id
objSysSecurityLevelEN.LevelName = objRow[conSysSecurityLevel.LevelName] == DBNull.Value ? null : objRow[conSysSecurityLevel.LevelName].ToString().Trim(); //级别名称
objSysSecurityLevelEN.Memo = objRow[conSysSecurityLevel.Memo] == DBNull.Value ? null : objRow[conSysSecurityLevel.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objSysSecurityLevelEN.LevelId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objSysSecurityLevelEN);
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
public static List<clsSysSecurityLevelEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsSysSecurityLevelEN> arrObjLst = new List<clsSysSecurityLevelEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsSysSecurityLevelEN objSysSecurityLevelEN = new clsSysSecurityLevelEN();
try
{
objSysSecurityLevelEN.LevelId = objRow[conSysSecurityLevel.LevelId].ToString().Trim(); //级别Id
objSysSecurityLevelEN.LevelName = objRow[conSysSecurityLevel.LevelName] == DBNull.Value ? null : objRow[conSysSecurityLevel.LevelName].ToString().Trim(); //级别名称
objSysSecurityLevelEN.Memo = objRow[conSysSecurityLevel.Memo] == DBNull.Value ? null : objRow[conSysSecurityLevel.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objSysSecurityLevelEN.LevelId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objSysSecurityLevelEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsSysSecurityLevelEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsSysSecurityLevelEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsSysSecurityLevelEN> arrObjLst = new List<clsSysSecurityLevelEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsSysSecurityLevelEN objSysSecurityLevelEN = new clsSysSecurityLevelEN();
try
{
objSysSecurityLevelEN.LevelId = objRow[conSysSecurityLevel.LevelId].ToString().Trim(); //级别Id
objSysSecurityLevelEN.LevelName = objRow[conSysSecurityLevel.LevelName] == DBNull.Value ? null : objRow[conSysSecurityLevel.LevelName].ToString().Trim(); //级别名称
objSysSecurityLevelEN.Memo = objRow[conSysSecurityLevel.Memo] == DBNull.Value ? null : objRow[conSysSecurityLevel.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objSysSecurityLevelEN.LevelId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objSysSecurityLevelEN);
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
public static List<clsSysSecurityLevelEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsSysSecurityLevelEN> arrObjLst = new List<clsSysSecurityLevelEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsSysSecurityLevelEN objSysSecurityLevelEN = new clsSysSecurityLevelEN();
try
{
objSysSecurityLevelEN.LevelId = objRow[conSysSecurityLevel.LevelId].ToString().Trim(); //级别Id
objSysSecurityLevelEN.LevelName = objRow[conSysSecurityLevel.LevelName] == DBNull.Value ? null : objRow[conSysSecurityLevel.LevelName].ToString().Trim(); //级别名称
objSysSecurityLevelEN.Memo = objRow[conSysSecurityLevel.Memo] == DBNull.Value ? null : objRow[conSysSecurityLevel.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objSysSecurityLevelEN.LevelId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objSysSecurityLevelEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsSysSecurityLevelEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsSysSecurityLevelEN> arrObjLst = new List<clsSysSecurityLevelEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsSysSecurityLevelEN objSysSecurityLevelEN = new clsSysSecurityLevelEN();
try
{
objSysSecurityLevelEN.LevelId = objRow[conSysSecurityLevel.LevelId].ToString().Trim(); //级别Id
objSysSecurityLevelEN.LevelName = objRow[conSysSecurityLevel.LevelName] == DBNull.Value ? null : objRow[conSysSecurityLevel.LevelName].ToString().Trim(); //级别名称
objSysSecurityLevelEN.Memo = objRow[conSysSecurityLevel.Memo] == DBNull.Value ? null : objRow[conSysSecurityLevel.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objSysSecurityLevelEN.LevelId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objSysSecurityLevelEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objSysSecurityLevelEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetSysSecurityLevel(ref clsSysSecurityLevelEN objSysSecurityLevelEN)
{
bool bolResult = SysSecurityLevelDA.GetSysSecurityLevel(ref objSysSecurityLevelEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "strLevelId">表关键字</param>
 /// <returns>表对象</returns>
public static clsSysSecurityLevelEN GetObjByLevelId(string strLevelId)
{
if (strLevelId.IndexOf(' ') >=0)
{
var strMsg = string.Format("(errid:Busi000079)在表中,关键字[strLevelId]中不能有空格!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
if (string.IsNullOrEmpty(strLevelId) == true)
{
var strMsg = string.Format("(errid:Busi000020)在表中,关键字[strLevelId]不能为空!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
clsSysSecurityLevelEN objSysSecurityLevelEN = SysSecurityLevelDA.GetObjByLevelId(strLevelId);
return objSysSecurityLevelEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsSysSecurityLevelEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsSysSecurityLevelEN objSysSecurityLevelEN = SysSecurityLevelDA.GetFirstObj(strWhereCond);
 return objSysSecurityLevelEN;
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
public static clsSysSecurityLevelEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsSysSecurityLevelEN objSysSecurityLevelEN = SysSecurityLevelDA.GetObjByDataRow(objRow);
 return objSysSecurityLevelEN;
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
public static clsSysSecurityLevelEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsSysSecurityLevelEN objSysSecurityLevelEN = SysSecurityLevelDA.GetObjByDataRow(objRow);
 return objSysSecurityLevelEN;
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
 /// <param name = "strLevelId">所给的关键字</param>
 /// <param name = "lstSysSecurityLevelObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsSysSecurityLevelEN GetObjByLevelIdFromList(string strLevelId, List<clsSysSecurityLevelEN> lstSysSecurityLevelObjLst)
{
foreach (clsSysSecurityLevelEN objSysSecurityLevelEN in lstSysSecurityLevelObjLst)
{
if (objSysSecurityLevelEN.LevelId == strLevelId)
{
return objSysSecurityLevelEN;
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
 string strMaxLevelId;
 try
 {
 strMaxLevelId = clsSysSecurityLevelDA.GetMaxStrId();
 return strMaxLevelId;
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
 string strLevelId;
 try
 {
 strLevelId = new clsSysSecurityLevelDA().GetFirstID(strWhereCond);
 return strLevelId;
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
 arrList = SysSecurityLevelDA.GetID(strWhereCond);
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
bool bolIsExist = SysSecurityLevelDA.IsExistCondRec(strWhereCond);
return bolIsExist;
}

 /// <summary>
 /// 判断当前表中是否存在给定关键字值的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExist)
 /// </summary>
 /// <param name = "strLevelId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public static bool IsExist(string strLevelId)
{
if (string.IsNullOrEmpty(strLevelId) == true)
{
var strMsg = string.Format("(errid:Busi000027)在表中,关键字[strLevelId]不能为空!!(from {0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
//检测记录是否存在
bool bolIsExist = SysSecurityLevelDA.IsExist(strLevelId);
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
 bolIsExist = clsSysSecurityLevelDA.IsExistTable();
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
 bolIsExist = SysSecurityLevelDA.IsExistTable(strTabName);
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
 /// <param name = "objSysSecurityLevelEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecordBySql2(clsSysSecurityLevelEN objSysSecurityLevelEN, bool bolIsNeedCheckUniqueness=true)
{
if (bolIsNeedCheckUniqueness == true && objSysSecurityLevelEN.CheckUniqueness() == false)
{
var strMsg = string.Format("记录已经存在!级别Id = [{0}]的数据已经存在!(in clsSysSecurityLevelBL.AddNewRecordBySql2)", objSysSecurityLevelEN.LevelId);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objSysSecurityLevelEN.LevelId) == true || clsSysSecurityLevelBL.IsExist(objSysSecurityLevelEN.LevelId) == true)
 {
     objSysSecurityLevelEN.LevelId = clsSysSecurityLevelBL.GetMaxStrId_S();
 }
bool bolResult = SysSecurityLevelDA.AddNewRecordBySQL2(objSysSecurityLevelEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsSysSecurityLevelBL.ReFreshCache();

if (clsSysSecurityLevelBL.relatedActions != null)
{
clsSysSecurityLevelBL.relatedActions.UpdRelaTabDate(objSysSecurityLevelEN.LevelId, "SetUpdDate");
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
 /// <param name = "objSysSecurityLevelEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordBySql2WithReturnKey(clsSysSecurityLevelEN objSysSecurityLevelEN, bool bolIsNeedCheckUniqueness=true)
{
if (bolIsNeedCheckUniqueness == true && objSysSecurityLevelEN.CheckUniqueness() == false)
{
var strMsg = string.Format("记录已经存在!级别Id = [{0}]的数据已经存在!(in clsSysSecurityLevelBL.AddNewRecordBySql2WithReturnKey)", objSysSecurityLevelEN.LevelId);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objSysSecurityLevelEN.LevelId) == true || clsSysSecurityLevelBL.IsExist(objSysSecurityLevelEN.LevelId) == true)
 {
     objSysSecurityLevelEN.LevelId = clsSysSecurityLevelBL.GetMaxStrId_S();
 }
string strKey = SysSecurityLevelDA.AddNewRecordBySQL2WithReturnKey(objSysSecurityLevelEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsSysSecurityLevelBL.ReFreshCache();

if (clsSysSecurityLevelBL.relatedActions != null)
{
clsSysSecurityLevelBL.relatedActions.UpdRelaTabDate(objSysSecurityLevelEN.LevelId, "SetUpdDate");
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
 /// <param name = "objSysSecurityLevelEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(clsSysSecurityLevelEN objSysSecurityLevelEN)
{
try
{
bool bolResult = SysSecurityLevelDA.Update(objSysSecurityLevelEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsSysSecurityLevelBL.ReFreshCache();

if (clsSysSecurityLevelBL.relatedActions != null)
{
clsSysSecurityLevelBL.relatedActions.UpdRelaTabDate(objSysSecurityLevelEN.LevelId, "SetUpdDate");
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
 /// <param name = "objSysSecurityLevelEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateBySql2(clsSysSecurityLevelEN objSysSecurityLevelEN)
{
 if (string.IsNullOrEmpty(objSysSecurityLevelEN.LevelId) == true)
 {
var strMsg = string.Format("(errid:Busi000065)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = SysSecurityLevelDA.UpdateBySql2(objSysSecurityLevelEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsSysSecurityLevelBL.ReFreshCache();

if (clsSysSecurityLevelBL.relatedActions != null)
{
clsSysSecurityLevelBL.relatedActions.UpdRelaTabDate(objSysSecurityLevelEN.LevelId, "SetUpdDate");
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
 /// <param name = "strLevelId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int DelRecord(string strLevelId)
{
try
{
 clsSysSecurityLevelEN objSysSecurityLevelEN = clsSysSecurityLevelBL.GetObjByLevelId(strLevelId);

if (clsSysSecurityLevelBL.relatedActions != null)
{
clsSysSecurityLevelBL.relatedActions.UpdRelaTabDate(objSysSecurityLevelEN.LevelId, "SetUpdDate");
}
if (objSysSecurityLevelEN != null)
{
int intRecNum = SysSecurityLevelDA.DelRecord(strLevelId);
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
/// <param name="strLevelId">表关键字</param>
/// <returns></returns>
public static bool DelRecordEx(string strLevelId )
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsSysSecurityLevelDA.GetSpecSQLObj();
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
//删除与表:[SysSecurityLevel]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conSysSecurityLevel.LevelId,
//strLevelId);
//        clsSysSecurityLevelBL.DelSysSecurityLevelsByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsSysSecurityLevelBL.DelRecord(strLevelId, objConnection, objSqlTransaction);
objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsSysSecurityLevelBLEx", "DelRecordEx", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("扩展删除记录出错:{0}!keyId = {1}.({2})",
objException.Message,
strLevelId, clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "strLevelId">给定的关键字值</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回删除是否成功?</returns>
public static bool DelRecord(string strLevelId, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
if (clsSysSecurityLevelBL.relatedActions != null)
{
clsSysSecurityLevelBL.relatedActions.UpdRelaTabDate(strLevelId, "UpdRelaTabDate");
}
bool bolResult = SysSecurityLevelDA.DelRecord(strLevelId,objSqlConnection,objSqlTransaction);
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
 /// <param name = "arrLevelIdLst">给定的关键字值列表</param>
 /// <returns>返回删除的记录数</returns>
public static int DelSysSecurityLevels(List<string> arrLevelIdLst)
{
if (arrLevelIdLst.Count == 0) return 0;
try
{
if (clsSysSecurityLevelBL.relatedActions != null)
{
foreach (var strLevelId in arrLevelIdLst)
{
clsSysSecurityLevelBL.relatedActions.UpdRelaTabDate(strLevelId, "UpdRelaTabDate");
}
}
int intDelRecNum = SysSecurityLevelDA.DelSysSecurityLevel(arrLevelIdLst);
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
public static int DelSysSecurityLevelsByCond(string strWhereCond)
{
try
{
if (clsSysSecurityLevelBL.relatedActions != null)
{
List<string> arrLevelId = GetPrimaryKeyID_S(strWhereCond);
foreach (var strLevelId in arrLevelId)
{
clsSysSecurityLevelBL.relatedActions.UpdRelaTabDate(strLevelId, "UpdRelaTabDate");
}
}
int intRecNum = SysSecurityLevelDA.DelSysSecurityLevel(strWhereCond);
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
/// 这里仅仅是演示函数,使用时请复制到扩展类:[SysSecurityLevel]中改名为:[DelRecord4MultiTabEx]使用
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DelRecord4MultiTab)
/// </summary>
/// <param name="strLevelId">表关键字</param>
/// <returns></returns>
public static bool DelRecord4MultiTab(string strLevelId)
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsSysSecurityLevelDA.GetSpecSQLObj();
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
//删除与表:[SysSecurityLevel]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conStudent.id_College,
//strid_College);
//        clsStudentBL.DelStudentsByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsSysSecurityLevelBL.DelRecord(strLevelId, objConnection, objSqlTransaction);
                objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsSysSecurityLevelBL", "DelRecord4MultiTab", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("删除多表记录出错:{0}!keyId = {1}.({2})",
objException.Message,
strLevelId, clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "objSysSecurityLevelENS">源对象</param>
 /// <param name = "objSysSecurityLevelENT">目标对象</param>
 public static void CopyTo(clsSysSecurityLevelEN objSysSecurityLevelENS, clsSysSecurityLevelEN objSysSecurityLevelENT)
{
try
{
objSysSecurityLevelENT.LevelId = objSysSecurityLevelENS.LevelId; //级别Id
objSysSecurityLevelENT.LevelName = objSysSecurityLevelENS.LevelName; //级别名称
objSysSecurityLevelENT.Memo = objSysSecurityLevelENS.Memo; //备注
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
 /// <param name = "objSysSecurityLevelEN">源简化对象</param>
 public static void SetUpdFlag(clsSysSecurityLevelEN objSysSecurityLevelEN)
{
try
{
objSysSecurityLevelEN.ClearUpdateState();
   string strsfUpdFldSetStr = objSysSecurityLevelEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(conSysSecurityLevel.LevelId, new clsStrCompareIgnoreCase())  ==  true)
{
objSysSecurityLevelEN.LevelId = objSysSecurityLevelEN.LevelId; //级别Id
}
if (arrFldSet.Contains(conSysSecurityLevel.LevelName, new clsStrCompareIgnoreCase())  ==  true)
{
objSysSecurityLevelEN.LevelName = objSysSecurityLevelEN.LevelName == "[null]" ? null :  objSysSecurityLevelEN.LevelName; //级别名称
}
if (arrFldSet.Contains(conSysSecurityLevel.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objSysSecurityLevelEN.Memo = objSysSecurityLevelEN.Memo == "[null]" ? null :  objSysSecurityLevelEN.Memo; //备注
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
 /// <param name = "objSysSecurityLevelEN">源简化对象</param>
 public static void AccessFldValueNull(clsSysSecurityLevelEN objSysSecurityLevelEN)
{
try
{
if (objSysSecurityLevelEN.LevelName == "[null]") objSysSecurityLevelEN.LevelName = null; //级别名称
if (objSysSecurityLevelEN.Memo == "[null]") objSysSecurityLevelEN.Memo = null; //备注
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
public static void CheckPropertyNew(clsSysSecurityLevelEN objSysSecurityLevelEN)
{
 SysSecurityLevelDA.CheckPropertyNew(objSysSecurityLevelEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(clsSysSecurityLevelEN objSysSecurityLevelEN)
{
 SysSecurityLevelDA.CheckProperty4Condition(objSysSecurityLevelEN);
 }


 #endregion 检查对象属性


 #region 绑定下拉框

 /// <summary>
 /// 绑定基于Win的下拉框
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_TabFeature_ComboBoxBindFunction)
 /// </summary>
 /// <param name = "objComboBox">需要绑定当前表的下拉框</param>

public static void BindCbo_LevelId(System.Windows.Forms.ComboBox objComboBox )
{
//为数据源为表的下拉框设置内容
string strCondition = string.Format("1 =1 Order By {0}", conSysSecurityLevel.LevelId); 
List<clsSysSecurityLevelEN> arrObjLst = clsSysSecurityLevelBL.GetObjLst(strCondition);
//初始化一个对象列表
//插入第0项。在第0项中插入“请选择...”,为了方便用户,与WEB方式类似。
clsSysSecurityLevelEN objSysSecurityLevelEN = new clsSysSecurityLevelEN()
{
LevelId = "0",
LevelName = "选[保密级别表]..."
};
arrObjLst.Insert(0, objSysSecurityLevelEN);
//设置下拉框的数据源、以及设置值项、显示项
objComboBox.ValueMember = conSysSecurityLevel.LevelId;
objComboBox.DisplayMember = conSysSecurityLevel.LevelName;
objComboBox.DataSource = arrObjLst;
objComboBox.SelectedIndex = 0;
}

 /// <summary>
 /// 绑定基于Web的下拉框
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_TabFeature_DdlBindFunction)
 /// </summary>
 /// <param name = "objDDL">需要绑定当前表的下拉框</param>

public static void BindDdl_LevelId(System.Web.UI.WebControls.DropDownList objDDL )
{
//为数据源于表的下拉框设置内容
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[保密级别表]...","0");
string strCondition = string.Format("1 =1 Order By {0}", conSysSecurityLevel.LevelId); 
IEnumerable<clsSysSecurityLevelEN> arrObjLst = clsSysSecurityLevelBL.GetObjLst(strCondition);
objDDL.DataValueField = conSysSecurityLevel.LevelId;
objDDL.DataTextField = conSysSecurityLevel.LevelName;
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
public static void BindDdl_LevelIdCache(System.Web.UI.WebControls.DropDownList objDDL)
{
//为数据源于表的下拉框设置内容
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[保密级别表]...","0");
List<clsSysSecurityLevelEN> arrSysSecurityLevelObjLst = GetAllSysSecurityLevelObjLstCache(); 
objDDL.DataValueField = conSysSecurityLevel.LevelId;
objDDL.DataTextField = conSysSecurityLevel.LevelName;
objDDL.DataSource = arrSysSecurityLevelObjLst;
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
if (clsSysSecurityLevelBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsSysSecurityLevelBL没有刷新缓存机制(clsSysSecurityLevelBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by LevelId");
//if (arrSysSecurityLevelObjLstCache == null)
//{
//arrSysSecurityLevelObjLstCache = SysSecurityLevelDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "strLevelId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsSysSecurityLevelEN GetObjByLevelIdCache(string strLevelId)
{
//获取缓存中的对象列表
string strKey = string.Format("{0}", clsSysSecurityLevelEN._CurrTabName);
List<clsSysSecurityLevelEN> arrSysSecurityLevelObjLstCache = GetObjLstCache();
IEnumerable <clsSysSecurityLevelEN> arrSysSecurityLevelObjLst_Sel =
arrSysSecurityLevelObjLstCache
.Where(x=> x.LevelId == strLevelId 
);
if (arrSysSecurityLevelObjLst_Sel.Count() == 0)
{
   clsSysSecurityLevelEN obj = clsSysSecurityLevelBL.GetObjByLevelId(strLevelId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
 }
return null;
}
return arrSysSecurityLevelObjLst_Sel.First();
}

 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecNameByKeyCache)
 /// </summary>
 /// <param name = "strLevelId">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetLevelNameByLevelIdCache(string strLevelId)
{
if (string.IsNullOrEmpty(strLevelId) == true) return "";
//获取缓存中的对象列表
clsSysSecurityLevelEN objSysSecurityLevel = GetObjByLevelIdCache(strLevelId);
if (objSysSecurityLevel == null) return "";
return objSysSecurityLevel.LevelName;
}
 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecNameByKeyCache)
 /// </summary>
 /// <param name = "strLevelId">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetNameByLevelIdCache(string strLevelId)
{
if (string.IsNullOrEmpty(strLevelId) == true) return "";
//获取缓存中的对象列表
clsSysSecurityLevelEN objSysSecurityLevel = GetObjByLevelIdCache(strLevelId);
if (objSysSecurityLevel == null) return "";
return objSysSecurityLevel.LevelName;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsSysSecurityLevelEN> GetAllSysSecurityLevelObjLstCache()
{
//获取缓存中的对象列表
List<clsSysSecurityLevelEN> arrSysSecurityLevelObjLstCache = GetObjLstCache(); 
return arrSysSecurityLevelObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsSysSecurityLevelEN> GetObjLstCache()
{
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}", clsSysSecurityLevelEN._CurrTabName);
List<clsSysSecurityLevelEN> arrSysSecurityLevelObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrSysSecurityLevelObjLstCache;
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
string strKey = string.Format("{0}", clsSysSecurityLevelEN._CurrTabName);
CacheHelper.Remove(strKey);
clsSysSecurityLevelEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
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
if (clsSysSecurityLevelEN._RefreshTimeLst.Count == 0) return "";
return clsSysSecurityLevelEN._RefreshTimeLst[clsSysSecurityLevelEN._RefreshTimeLst.Count - 1];
}

 /// <summary>
 /// 刷新缓存.把当前表的缓存以及该表相关视图的缓存清空.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ReFreshCache)
 /// </summary>
public static void ReFreshCache()
{
if (clsSysSecurityLevelBL.objCommFun4BL != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}", clsSysSecurityLevelEN._CurrTabName);
CacheHelper.Remove(strKey);
clsSysSecurityLevelEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
clsSysSecurityLevelBL.objCommFun4BL.ReFreshCache();
}
}


 #endregion 缓存操作


 #region 检查唯一性

 /// <summary>
 /// 获取检查唯一性条件串(Uniqueness)--SysSecurityLevel(保密级别表)
 /// 唯一性条件:LevelId
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetUniquenessConditionString)
 /// </summary>
 /// <param name = "objSysSecurityLevelEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(clsSysSecurityLevelEN objSysSecurityLevelEN)
{
//检测记录是否存在
string strResult = SysSecurityLevelDA.GetUniCondStr(objSysSecurityLevelEN);
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
public static string Func(string strInFldName, string strOutFldName, string strLevelId)
{
if (strInFldName != conSysSecurityLevel.LevelId)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (conSysSecurityLevel.AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", conSysSecurityLevel.AttributeName));
throw new Exception(strMsg);
}
var objSysSecurityLevel = clsSysSecurityLevelBL.GetObjByLevelIdCache(strLevelId);
if (objSysSecurityLevel == null) return "";
return objSysSecurityLevel[strOutFldName].ToString();
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
int intRecCount = clsSysSecurityLevelDA.GetRecCount(strTabName);
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
int intRecCount = clsSysSecurityLevelDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsSysSecurityLevelDA.GetRecCount();
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
int intRecCount = clsSysSecurityLevelDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objSysSecurityLevelCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsSysSecurityLevelEN objSysSecurityLevelCond)
{
List<clsSysSecurityLevelEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsSysSecurityLevelEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conSysSecurityLevel.AttributeName)
{
if (objSysSecurityLevelCond.IsUpdated(strFldName) == false) continue;
if (objSysSecurityLevelCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objSysSecurityLevelCond[strFldName].ToString());
}
else
{
if (objSysSecurityLevelCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objSysSecurityLevelCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objSysSecurityLevelCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objSysSecurityLevelCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objSysSecurityLevelCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objSysSecurityLevelCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objSysSecurityLevelCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objSysSecurityLevelCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objSysSecurityLevelCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objSysSecurityLevelCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objSysSecurityLevelCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objSysSecurityLevelCond[strFldName]));
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
 List<string> arrList = clsSysSecurityLevelDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = SysSecurityLevelDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = SysSecurityLevelDA.GetFldValueNoDistinct(strFldName, strWhereCond);
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
int intRecCount = SysSecurityLevelDA.SetFldValue(strFldName, strValue, strWhereCond);
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
int intRecCount = clsSysSecurityLevelDA.SetFldValue(clsSysSecurityLevelEN._CurrTabName, strFldName, fltValue, strWhereCond);
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
int intRecCount = SysSecurityLevelDA.SetFldValue( strFldName, intValue, strWhereCond);
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
int intRecCount = clsSysSecurityLevelDA.SetFldValue(strTabName, strFldName, strValue, strWhereCond);
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
int intRecCount = clsSysSecurityLevelDA.SetFldValue(strTabName, strFldName, intValue, strWhereCond);
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
int intRecCount = clsSysSecurityLevelDA.SetFldValue(strTabName, strFldName, fltValue, strWhereCond);
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
  strCreateTabCode.Append("CREATE table [dbo].[SysSecurityLevel] "); 
 strCreateTabCode.Append(" ( "); 
 // /**级别Id*/ 
 strCreateTabCode.Append(" LevelId char(2) primary key, "); 
 // /**级别名称*/ 
 strCreateTabCode.Append(" LevelName varchar(50) Null, "); 
 // /**备注*/ 
 strCreateTabCode.Append(" Memo varchar(1000) Null ");
 strCreateTabCode.Append(") "); 
  strCreateTabCode.Append("ON [PRIMARY] ");
  return strCreateTabCode.ToString();
}



 #endregion 表操作
}
 /// <summary>
 /// 保密级别表(SysSecurityLevel)
 /// 数据源类型:表
 /// (AutoGCLib.CommFun4BL4CSharp:GeneCode_This)
 /// </summary>
public class  clsCommFun4BL4SysSecurityLevel : clsCommFun4BL
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
clsSysSecurityLevelBL.ReFreshThisCache();
}
}

}