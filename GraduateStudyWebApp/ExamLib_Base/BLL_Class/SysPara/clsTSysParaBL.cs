
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsTSysParaBL
 表名:TSysPara(01120753)
 * 版本:2023.11.15.1(服务器:WIN-SRV103-116)
 日期:2023/11/15 23:09:48
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:研究生学习游戏化后台(变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:系统参数(SysPara)
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
public static class  clsTSysParaBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public static clsTSysParaEN GetObj(this K_mId_TSysPara myKey)
{
clsTSysParaEN objTSysParaEN = clsTSysParaBL.TSysParaDA.GetObjBymId(myKey.Value);
return objTSysParaEN;
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_AddNewRecord)
 /// </summary>
 /// <param name = "objTSysParaEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clsTSysParaEN objTSysParaEN)
{
try
{
bool bolResult = clsTSysParaBL.TSysParaDA.AddNewRecordBySQL2(objTSysParaEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsTSysParaBL.ReFreshCache();

if (clsTSysParaBL.relatedActions != null)
{
clsTSysParaBL.relatedActions.UpdRelaTabDate(objTSysParaEN.mId, "SetUpdDate");
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
public static bool AddRecordEx(this clsTSysParaEN objTSysParaEN)
{
//操作步骤:
//1、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在
//2、检查唯一性
//3、检查传进去的对象属性是否合法
//4、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
//1、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在
try
{
 //2、检查传进去的对象属性是否合法
objTSysParaEN.CheckPropertyNew();
//6、把数据实体层的数据存贮到数据库中
objTSysParaEN.AddNewRecord();
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
 /// <param name = "objTSysParaEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordWithReturnKey(this clsTSysParaEN objTSysParaEN)
{
try
{
string strKey = clsTSysParaBL.TSysParaDA.AddNewRecordBySQL2WithReturnKey(objTSysParaEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsTSysParaBL.ReFreshCache();

if (clsTSysParaBL.relatedActions != null)
{
clsTSysParaBL.relatedActions.UpdRelaTabDate(objTSysParaEN.mId, "SetUpdDate");
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
 /// <param name = "objTSysParaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsTSysParaEN SetmId(this clsTSysParaEN objTSysParaEN, long lngmId, string strComparisonOp="")
	{
objTSysParaEN.mId = lngmId; //mId
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objTSysParaEN.dicFldComparisonOp.ContainsKey(conTSysPara.mId) == false)
{
objTSysParaEN.dicFldComparisonOp.Add(conTSysPara.mId, strComparisonOp);
}
else
{
objTSysParaEN.dicFldComparisonOp[conTSysPara.mId] = strComparisonOp;
}
}
return objTSysParaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objTSysParaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsTSysParaEN SetSysParaName(this clsTSysParaEN objTSysParaEN, string strSysParaName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strSysParaName, conTSysPara.SysParaName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strSysParaName, 50, conTSysPara.SysParaName);
}
objTSysParaEN.SysParaName = strSysParaName; //SysParaName
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objTSysParaEN.dicFldComparisonOp.ContainsKey(conTSysPara.SysParaName) == false)
{
objTSysParaEN.dicFldComparisonOp.Add(conTSysPara.SysParaName, strComparisonOp);
}
else
{
objTSysParaEN.dicFldComparisonOp[conTSysPara.SysParaName] = strComparisonOp;
}
}
return objTSysParaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objTSysParaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsTSysParaEN SetSysParaValue(this clsTSysParaEN objTSysParaEN, string strSysParaValue, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strSysParaValue, conTSysPara.SysParaValue);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strSysParaValue, 200, conTSysPara.SysParaValue);
}
objTSysParaEN.SysParaValue = strSysParaValue; //SysParaValue
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objTSysParaEN.dicFldComparisonOp.ContainsKey(conTSysPara.SysParaValue) == false)
{
objTSysParaEN.dicFldComparisonOp.Add(conTSysPara.SysParaValue, strComparisonOp);
}
else
{
objTSysParaEN.dicFldComparisonOp[conTSysPara.SysParaValue] = strComparisonOp;
}
}
return objTSysParaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objTSysParaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsTSysParaEN SetIdSchool(this clsTSysParaEN objTSysParaEN, string strIdSchool, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdSchool, 4, conTSysPara.IdSchool);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdSchool, 4, conTSysPara.IdSchool);
}
objTSysParaEN.IdSchool = strIdSchool; //学校流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objTSysParaEN.dicFldComparisonOp.ContainsKey(conTSysPara.IdSchool) == false)
{
objTSysParaEN.dicFldComparisonOp.Add(conTSysPara.IdSchool, strComparisonOp);
}
else
{
objTSysParaEN.dicFldComparisonOp[conTSysPara.IdSchool] = strComparisonOp;
}
}
return objTSysParaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objTSysParaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsTSysParaEN SetSchoolId(this clsTSysParaEN objTSysParaEN, string strSchoolId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strSchoolId, 10, conTSysPara.SchoolId);
}
objTSysParaEN.SchoolId = strSchoolId; //学校编号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objTSysParaEN.dicFldComparisonOp.ContainsKey(conTSysPara.SchoolId) == false)
{
objTSysParaEN.dicFldComparisonOp.Add(conTSysPara.SchoolId, strComparisonOp);
}
else
{
objTSysParaEN.dicFldComparisonOp[conTSysPara.SchoolId] = strComparisonOp;
}
}
return objTSysParaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objTSysParaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsTSysParaEN SetModifyDate(this clsTSysParaEN objTSysParaEN, string strModifyDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strModifyDate, 20, conTSysPara.ModifyDate);
}
objTSysParaEN.ModifyDate = strModifyDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objTSysParaEN.dicFldComparisonOp.ContainsKey(conTSysPara.ModifyDate) == false)
{
objTSysParaEN.dicFldComparisonOp.Add(conTSysPara.ModifyDate, strComparisonOp);
}
else
{
objTSysParaEN.dicFldComparisonOp[conTSysPara.ModifyDate] = strComparisonOp;
}
}
return objTSysParaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objTSysParaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsTSysParaEN SetModifyUser(this clsTSysParaEN objTSysParaEN, string strModifyUser, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strModifyUser, 30, conTSysPara.ModifyUser);
}
objTSysParaEN.ModifyUser = strModifyUser; //ModifyUser
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objTSysParaEN.dicFldComparisonOp.ContainsKey(conTSysPara.ModifyUser) == false)
{
objTSysParaEN.dicFldComparisonOp.Add(conTSysPara.ModifyUser, strComparisonOp);
}
else
{
objTSysParaEN.dicFldComparisonOp[conTSysPara.ModifyUser] = strComparisonOp;
}
}
return objTSysParaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objTSysParaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsTSysParaEN SetMemo(this clsTSysParaEN objTSysParaEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, conTSysPara.Memo);
}
objTSysParaEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objTSysParaEN.dicFldComparisonOp.ContainsKey(conTSysPara.Memo) == false)
{
objTSysParaEN.dicFldComparisonOp.Add(conTSysPara.Memo, strComparisonOp);
}
else
{
objTSysParaEN.dicFldComparisonOp[conTSysPara.Memo] = strComparisonOp;
}
}
return objTSysParaEN;
	}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_Update)
 /// </summary>
 /// <param name = "objTSysParaEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsTSysParaEN objTSysParaEN)
{
 if (objTSysParaEN.mId == 0)
 {
string strMsg = string.Format("(errid:Busi000095)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsTSysParaBL.TSysParaDA.UpdateBySql2(objTSysParaEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsTSysParaBL.ReFreshCache();

if (clsTSysParaBL.relatedActions != null)
{
clsTSysParaBL.relatedActions.UpdRelaTabDate(objTSysParaEN.mId, "SetUpdDate");
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
 /// <param name = "objTSysParaEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsTSysParaEN objTSysParaEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (objTSysParaEN.mId == 0)
 {
string strMsg = string.Format("(errid:Busi000087)修改记录时关键字不能为空!(带事务处理)(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsTSysParaBL.TSysParaDA.UpdateBySql2(objTSysParaEN, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsTSysParaBL.ReFreshCache();

if (clsTSysParaBL.relatedActions != null)
{
clsTSysParaBL.relatedActions.UpdRelaTabDate(objTSysParaEN.mId, "SetUpdDate");
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
 /// <param name = "objTSysParaEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsTSysParaEN objTSysParaEN, string strWhereCond)
{
try
{
bool bolResult = clsTSysParaBL.TSysParaDA.UpdateBySqlWithCondition(objTSysParaEN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsTSysParaBL.ReFreshCache();

if (clsTSysParaBL.relatedActions != null)
{
clsTSysParaBL.relatedActions.UpdRelaTabDate(objTSysParaEN.mId, "SetUpdDate");
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
 /// <param name = "objTSysParaEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsTSysParaEN objTSysParaEN, string strWhereCond, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
bool bolResult = clsTSysParaBL.TSysParaDA.UpdateBySqlWithConditionTransaction(objTSysParaEN, strWhereCond, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsTSysParaBL.ReFreshCache();

if (clsTSysParaBL.relatedActions != null)
{
clsTSysParaBL.relatedActions.UpdRelaTabDate(objTSysParaEN.mId, "SetUpdDate");
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
 /// <param name = "lngmId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int Delete(this clsTSysParaEN objTSysParaEN)
{
try
{
int intRecNum = clsTSysParaBL.TSysParaDA.DelRecord(objTSysParaEN.mId);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsTSysParaBL.ReFreshCache();

if (clsTSysParaBL.relatedActions != null)
{
clsTSysParaBL.relatedActions.UpdRelaTabDate(objTSysParaEN.mId, "SetUpdDate");
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
 /// <param name = "objTSysParaENS">源对象</param>
 /// <param name = "objTSysParaENT">目标对象</param>
 public static void CopyTo(this clsTSysParaEN objTSysParaENS, clsTSysParaEN objTSysParaENT)
{
try
{
objTSysParaENT.mId = objTSysParaENS.mId; //mId
objTSysParaENT.SysParaName = objTSysParaENS.SysParaName; //SysParaName
objTSysParaENT.SysParaValue = objTSysParaENS.SysParaValue; //SysParaValue
objTSysParaENT.IdSchool = objTSysParaENS.IdSchool; //学校流水号
objTSysParaENT.SchoolId = objTSysParaENS.SchoolId; //学校编号
objTSysParaENT.ModifyDate = objTSysParaENS.ModifyDate; //修改日期
objTSysParaENT.ModifyUser = objTSysParaENS.ModifyUser; //ModifyUser
objTSysParaENT.Memo = objTSysParaENS.Memo; //备注
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
 /// <param name = "objTSysParaENS">源对象</param>
 /// <returns>目标对象=>clsTSysParaEN:objTSysParaENT</returns>
 public static clsTSysParaEN CopyTo(this clsTSysParaEN objTSysParaENS)
{
try
{
 clsTSysParaEN objTSysParaENT = new clsTSysParaEN()
{
mId = objTSysParaENS.mId, //mId
SysParaName = objTSysParaENS.SysParaName, //SysParaName
SysParaValue = objTSysParaENS.SysParaValue, //SysParaValue
IdSchool = objTSysParaENS.IdSchool, //学校流水号
SchoolId = objTSysParaENS.SchoolId, //学校编号
ModifyDate = objTSysParaENS.ModifyDate, //修改日期
ModifyUser = objTSysParaENS.ModifyUser, //ModifyUser
Memo = objTSysParaENS.Memo, //备注
};
 return objTSysParaENT;
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
public static void CheckPropertyNew(this clsTSysParaEN objTSysParaEN)
{
 clsTSysParaBL.TSysParaDA.CheckPropertyNew(objTSysParaEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(this clsTSysParaEN objTSysParaEN)
{
 clsTSysParaBL.TSysParaDA.CheckProperty4Condition(objTSysParaEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsTSysParaEN objTSysParaCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objTSysParaCond.IsUpdated(conTSysPara.mId) == true)
{
string strComparisonOpmId = objTSysParaCond.dicFldComparisonOp[conTSysPara.mId];
strWhereCond += string.Format(" And {0} {2} {1}", conTSysPara.mId, objTSysParaCond.mId, strComparisonOpmId);
}
if (objTSysParaCond.IsUpdated(conTSysPara.SysParaName) == true)
{
string strComparisonOpSysParaName = objTSysParaCond.dicFldComparisonOp[conTSysPara.SysParaName];
strWhereCond += string.Format(" And {0} {2} '{1}'", conTSysPara.SysParaName, objTSysParaCond.SysParaName, strComparisonOpSysParaName);
}
if (objTSysParaCond.IsUpdated(conTSysPara.SysParaValue) == true)
{
string strComparisonOpSysParaValue = objTSysParaCond.dicFldComparisonOp[conTSysPara.SysParaValue];
strWhereCond += string.Format(" And {0} {2} '{1}'", conTSysPara.SysParaValue, objTSysParaCond.SysParaValue, strComparisonOpSysParaValue);
}
if (objTSysParaCond.IsUpdated(conTSysPara.IdSchool) == true)
{
string strComparisonOpIdSchool = objTSysParaCond.dicFldComparisonOp[conTSysPara.IdSchool];
strWhereCond += string.Format(" And {0} {2} '{1}'", conTSysPara.IdSchool, objTSysParaCond.IdSchool, strComparisonOpIdSchool);
}
if (objTSysParaCond.IsUpdated(conTSysPara.SchoolId) == true)
{
string strComparisonOpSchoolId = objTSysParaCond.dicFldComparisonOp[conTSysPara.SchoolId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conTSysPara.SchoolId, objTSysParaCond.SchoolId, strComparisonOpSchoolId);
}
if (objTSysParaCond.IsUpdated(conTSysPara.ModifyDate) == true)
{
string strComparisonOpModifyDate = objTSysParaCond.dicFldComparisonOp[conTSysPara.ModifyDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conTSysPara.ModifyDate, objTSysParaCond.ModifyDate, strComparisonOpModifyDate);
}
if (objTSysParaCond.IsUpdated(conTSysPara.ModifyUser) == true)
{
string strComparisonOpModifyUser = objTSysParaCond.dicFldComparisonOp[conTSysPara.ModifyUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", conTSysPara.ModifyUser, objTSysParaCond.ModifyUser, strComparisonOpModifyUser);
}
if (objTSysParaCond.IsUpdated(conTSysPara.Memo) == true)
{
string strComparisonOpMemo = objTSysParaCond.dicFldComparisonOp[conTSysPara.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", conTSysPara.Memo, objTSysParaCond.Memo, strComparisonOpMemo);
}
 return strWhereCond;
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_TSysPara
{
public virtual bool UpdRelaTabDate(long lngmId, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// TSysPara(TSysPara)
 /// 数据源类型:表
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsTSysParaBL
{
public static RelatedActions_TSysPara relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsTSysParaDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsTSysParaDA TSysParaDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsTSysParaDA();
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
 public clsTSysParaBL()
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
if (string.IsNullOrEmpty(clsTSysParaEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsTSysParaEN._ConnectString);
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
public static DataTable GetDataTable_TSysPara(string strWhereCond)
{
DataTable objDT;
try
{
objDT = TSysParaDA.GetDataTable_TSysPara(strWhereCond);
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
objDT = TSysParaDA.GetDataTable(strWhereCond);
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
objDT = TSysParaDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = TSysParaDA.GetDataTable(strWhereCond, strTabName);
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
objDT = TSysParaDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = TSysParaDA.GetDataTable_Top(objTopPara);
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
objDT = TSysParaDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = TSysParaDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = TSysParaDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
 /// <param name = "arrMIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static List<clsTSysParaEN> GetObjLstByMIdLst(List<long> arrMIdLst)
{
List<clsTSysParaEN> arrObjLst = new List<clsTSysParaEN>(); 
System.Data.DataTable objDT; 
 string strSqlConditionStr = clsArray.GetSqlInStrByArray(arrMIdLst);
 string strWhereCond = string.Format("mId in ({0})", strSqlConditionStr);
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsTSysParaEN objTSysParaEN = new clsTSysParaEN();
try
{
objTSysParaEN.mId = Int32.Parse(objRow[conTSysPara.mId].ToString().Trim()); //mId
objTSysParaEN.SysParaName = objRow[conTSysPara.SysParaName].ToString().Trim(); //SysParaName
objTSysParaEN.SysParaValue = objRow[conTSysPara.SysParaValue].ToString().Trim(); //SysParaValue
objTSysParaEN.IdSchool = objRow[conTSysPara.IdSchool] == DBNull.Value ? null : objRow[conTSysPara.IdSchool].ToString().Trim(); //学校流水号
objTSysParaEN.SchoolId = objRow[conTSysPara.SchoolId] == DBNull.Value ? null : objRow[conTSysPara.SchoolId].ToString().Trim(); //学校编号
objTSysParaEN.ModifyDate = objRow[conTSysPara.ModifyDate] == DBNull.Value ? null : objRow[conTSysPara.ModifyDate].ToString().Trim(); //修改日期
objTSysParaEN.ModifyUser = objRow[conTSysPara.ModifyUser] == DBNull.Value ? null : objRow[conTSysPara.ModifyUser].ToString().Trim(); //ModifyUser
objTSysParaEN.Memo = objRow[conTSysPara.Memo] == DBNull.Value ? null : objRow[conTSysPara.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objTSysParaEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objTSysParaEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrMIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsTSysParaEN> GetObjLstByMIdLstCache(List<long> arrMIdLst)
{
string strKey = string.Format("{0}", clsTSysParaEN._CurrTabName);
List<clsTSysParaEN> arrTSysParaObjLstCache = GetObjLstCache();
IEnumerable <clsTSysParaEN> arrTSysParaObjLst_Sel =
arrTSysParaObjLstCache
.Where(x => arrMIdLst.Contains(x.mId));
return arrTSysParaObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsTSysParaEN> GetObjLst(string strWhereCond)
{
List<clsTSysParaEN> arrObjLst = new List<clsTSysParaEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsTSysParaEN objTSysParaEN = new clsTSysParaEN();
try
{
objTSysParaEN.mId = Int32.Parse(objRow[conTSysPara.mId].ToString().Trim()); //mId
objTSysParaEN.SysParaName = objRow[conTSysPara.SysParaName].ToString().Trim(); //SysParaName
objTSysParaEN.SysParaValue = objRow[conTSysPara.SysParaValue].ToString().Trim(); //SysParaValue
objTSysParaEN.IdSchool = objRow[conTSysPara.IdSchool] == DBNull.Value ? null : objRow[conTSysPara.IdSchool].ToString().Trim(); //学校流水号
objTSysParaEN.SchoolId = objRow[conTSysPara.SchoolId] == DBNull.Value ? null : objRow[conTSysPara.SchoolId].ToString().Trim(); //学校编号
objTSysParaEN.ModifyDate = objRow[conTSysPara.ModifyDate] == DBNull.Value ? null : objRow[conTSysPara.ModifyDate].ToString().Trim(); //修改日期
objTSysParaEN.ModifyUser = objRow[conTSysPara.ModifyUser] == DBNull.Value ? null : objRow[conTSysPara.ModifyUser].ToString().Trim(); //ModifyUser
objTSysParaEN.Memo = objRow[conTSysPara.Memo] == DBNull.Value ? null : objRow[conTSysPara.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objTSysParaEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objTSysParaEN);
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
public static List<clsTSysParaEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsTSysParaEN> arrObjLst = new List<clsTSysParaEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsTSysParaEN objTSysParaEN = new clsTSysParaEN();
try
{
objTSysParaEN.mId = Int32.Parse(objRow[conTSysPara.mId].ToString().Trim()); //mId
objTSysParaEN.SysParaName = objRow[conTSysPara.SysParaName].ToString().Trim(); //SysParaName
objTSysParaEN.SysParaValue = objRow[conTSysPara.SysParaValue].ToString().Trim(); //SysParaValue
objTSysParaEN.IdSchool = objRow[conTSysPara.IdSchool] == DBNull.Value ? null : objRow[conTSysPara.IdSchool].ToString().Trim(); //学校流水号
objTSysParaEN.SchoolId = objRow[conTSysPara.SchoolId] == DBNull.Value ? null : objRow[conTSysPara.SchoolId].ToString().Trim(); //学校编号
objTSysParaEN.ModifyDate = objRow[conTSysPara.ModifyDate] == DBNull.Value ? null : objRow[conTSysPara.ModifyDate].ToString().Trim(); //修改日期
objTSysParaEN.ModifyUser = objRow[conTSysPara.ModifyUser] == DBNull.Value ? null : objRow[conTSysPara.ModifyUser].ToString().Trim(); //ModifyUser
objTSysParaEN.Memo = objRow[conTSysPara.Memo] == DBNull.Value ? null : objRow[conTSysPara.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objTSysParaEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objTSysParaEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objTSysParaCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsTSysParaEN> GetSubObjLstCache(clsTSysParaEN objTSysParaCond)
{
List<clsTSysParaEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsTSysParaEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conTSysPara.AttributeName)
{
if (objTSysParaCond.IsUpdated(strFldName) == false) continue;
if (objTSysParaCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objTSysParaCond[strFldName].ToString());
}
else
{
if (objTSysParaCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objTSysParaCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objTSysParaCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objTSysParaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objTSysParaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objTSysParaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objTSysParaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objTSysParaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objTSysParaCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objTSysParaCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objTSysParaCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objTSysParaCond[strFldName]));
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
public static List<clsTSysParaEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsTSysParaEN> arrObjLst = new List<clsTSysParaEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsTSysParaEN objTSysParaEN = new clsTSysParaEN();
try
{
objTSysParaEN.mId = Int32.Parse(objRow[conTSysPara.mId].ToString().Trim()); //mId
objTSysParaEN.SysParaName = objRow[conTSysPara.SysParaName].ToString().Trim(); //SysParaName
objTSysParaEN.SysParaValue = objRow[conTSysPara.SysParaValue].ToString().Trim(); //SysParaValue
objTSysParaEN.IdSchool = objRow[conTSysPara.IdSchool] == DBNull.Value ? null : objRow[conTSysPara.IdSchool].ToString().Trim(); //学校流水号
objTSysParaEN.SchoolId = objRow[conTSysPara.SchoolId] == DBNull.Value ? null : objRow[conTSysPara.SchoolId].ToString().Trim(); //学校编号
objTSysParaEN.ModifyDate = objRow[conTSysPara.ModifyDate] == DBNull.Value ? null : objRow[conTSysPara.ModifyDate].ToString().Trim(); //修改日期
objTSysParaEN.ModifyUser = objRow[conTSysPara.ModifyUser] == DBNull.Value ? null : objRow[conTSysPara.ModifyUser].ToString().Trim(); //ModifyUser
objTSysParaEN.Memo = objRow[conTSysPara.Memo] == DBNull.Value ? null : objRow[conTSysPara.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objTSysParaEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objTSysParaEN);
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
public static List<clsTSysParaEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsTSysParaEN> arrObjLst = new List<clsTSysParaEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsTSysParaEN objTSysParaEN = new clsTSysParaEN();
try
{
objTSysParaEN.mId = Int32.Parse(objRow[conTSysPara.mId].ToString().Trim()); //mId
objTSysParaEN.SysParaName = objRow[conTSysPara.SysParaName].ToString().Trim(); //SysParaName
objTSysParaEN.SysParaValue = objRow[conTSysPara.SysParaValue].ToString().Trim(); //SysParaValue
objTSysParaEN.IdSchool = objRow[conTSysPara.IdSchool] == DBNull.Value ? null : objRow[conTSysPara.IdSchool].ToString().Trim(); //学校流水号
objTSysParaEN.SchoolId = objRow[conTSysPara.SchoolId] == DBNull.Value ? null : objRow[conTSysPara.SchoolId].ToString().Trim(); //学校编号
objTSysParaEN.ModifyDate = objRow[conTSysPara.ModifyDate] == DBNull.Value ? null : objRow[conTSysPara.ModifyDate].ToString().Trim(); //修改日期
objTSysParaEN.ModifyUser = objRow[conTSysPara.ModifyUser] == DBNull.Value ? null : objRow[conTSysPara.ModifyUser].ToString().Trim(); //ModifyUser
objTSysParaEN.Memo = objRow[conTSysPara.Memo] == DBNull.Value ? null : objRow[conTSysPara.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objTSysParaEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objTSysParaEN);
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
List<clsTSysParaEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsTSysParaEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsTSysParaEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsTSysParaEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsTSysParaEN> arrObjLst = new List<clsTSysParaEN>(); 
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
	clsTSysParaEN objTSysParaEN = new clsTSysParaEN();
try
{
objTSysParaEN.mId = Int32.Parse(objRow[conTSysPara.mId].ToString().Trim()); //mId
objTSysParaEN.SysParaName = objRow[conTSysPara.SysParaName].ToString().Trim(); //SysParaName
objTSysParaEN.SysParaValue = objRow[conTSysPara.SysParaValue].ToString().Trim(); //SysParaValue
objTSysParaEN.IdSchool = objRow[conTSysPara.IdSchool] == DBNull.Value ? null : objRow[conTSysPara.IdSchool].ToString().Trim(); //学校流水号
objTSysParaEN.SchoolId = objRow[conTSysPara.SchoolId] == DBNull.Value ? null : objRow[conTSysPara.SchoolId].ToString().Trim(); //学校编号
objTSysParaEN.ModifyDate = objRow[conTSysPara.ModifyDate] == DBNull.Value ? null : objRow[conTSysPara.ModifyDate].ToString().Trim(); //修改日期
objTSysParaEN.ModifyUser = objRow[conTSysPara.ModifyUser] == DBNull.Value ? null : objRow[conTSysPara.ModifyUser].ToString().Trim(); //ModifyUser
objTSysParaEN.Memo = objRow[conTSysPara.Memo] == DBNull.Value ? null : objRow[conTSysPara.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objTSysParaEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objTSysParaEN);
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
public static List<clsTSysParaEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsTSysParaEN> arrObjLst = new List<clsTSysParaEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsTSysParaEN objTSysParaEN = new clsTSysParaEN();
try
{
objTSysParaEN.mId = Int32.Parse(objRow[conTSysPara.mId].ToString().Trim()); //mId
objTSysParaEN.SysParaName = objRow[conTSysPara.SysParaName].ToString().Trim(); //SysParaName
objTSysParaEN.SysParaValue = objRow[conTSysPara.SysParaValue].ToString().Trim(); //SysParaValue
objTSysParaEN.IdSchool = objRow[conTSysPara.IdSchool] == DBNull.Value ? null : objRow[conTSysPara.IdSchool].ToString().Trim(); //学校流水号
objTSysParaEN.SchoolId = objRow[conTSysPara.SchoolId] == DBNull.Value ? null : objRow[conTSysPara.SchoolId].ToString().Trim(); //学校编号
objTSysParaEN.ModifyDate = objRow[conTSysPara.ModifyDate] == DBNull.Value ? null : objRow[conTSysPara.ModifyDate].ToString().Trim(); //修改日期
objTSysParaEN.ModifyUser = objRow[conTSysPara.ModifyUser] == DBNull.Value ? null : objRow[conTSysPara.ModifyUser].ToString().Trim(); //ModifyUser
objTSysParaEN.Memo = objRow[conTSysPara.Memo] == DBNull.Value ? null : objRow[conTSysPara.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objTSysParaEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objTSysParaEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsTSysParaEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsTSysParaEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsTSysParaEN> arrObjLst = new List<clsTSysParaEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsTSysParaEN objTSysParaEN = new clsTSysParaEN();
try
{
objTSysParaEN.mId = Int32.Parse(objRow[conTSysPara.mId].ToString().Trim()); //mId
objTSysParaEN.SysParaName = objRow[conTSysPara.SysParaName].ToString().Trim(); //SysParaName
objTSysParaEN.SysParaValue = objRow[conTSysPara.SysParaValue].ToString().Trim(); //SysParaValue
objTSysParaEN.IdSchool = objRow[conTSysPara.IdSchool] == DBNull.Value ? null : objRow[conTSysPara.IdSchool].ToString().Trim(); //学校流水号
objTSysParaEN.SchoolId = objRow[conTSysPara.SchoolId] == DBNull.Value ? null : objRow[conTSysPara.SchoolId].ToString().Trim(); //学校编号
objTSysParaEN.ModifyDate = objRow[conTSysPara.ModifyDate] == DBNull.Value ? null : objRow[conTSysPara.ModifyDate].ToString().Trim(); //修改日期
objTSysParaEN.ModifyUser = objRow[conTSysPara.ModifyUser] == DBNull.Value ? null : objRow[conTSysPara.ModifyUser].ToString().Trim(); //ModifyUser
objTSysParaEN.Memo = objRow[conTSysPara.Memo] == DBNull.Value ? null : objRow[conTSysPara.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objTSysParaEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objTSysParaEN);
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
public static List<clsTSysParaEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsTSysParaEN> arrObjLst = new List<clsTSysParaEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsTSysParaEN objTSysParaEN = new clsTSysParaEN();
try
{
objTSysParaEN.mId = Int32.Parse(objRow[conTSysPara.mId].ToString().Trim()); //mId
objTSysParaEN.SysParaName = objRow[conTSysPara.SysParaName].ToString().Trim(); //SysParaName
objTSysParaEN.SysParaValue = objRow[conTSysPara.SysParaValue].ToString().Trim(); //SysParaValue
objTSysParaEN.IdSchool = objRow[conTSysPara.IdSchool] == DBNull.Value ? null : objRow[conTSysPara.IdSchool].ToString().Trim(); //学校流水号
objTSysParaEN.SchoolId = objRow[conTSysPara.SchoolId] == DBNull.Value ? null : objRow[conTSysPara.SchoolId].ToString().Trim(); //学校编号
objTSysParaEN.ModifyDate = objRow[conTSysPara.ModifyDate] == DBNull.Value ? null : objRow[conTSysPara.ModifyDate].ToString().Trim(); //修改日期
objTSysParaEN.ModifyUser = objRow[conTSysPara.ModifyUser] == DBNull.Value ? null : objRow[conTSysPara.ModifyUser].ToString().Trim(); //ModifyUser
objTSysParaEN.Memo = objRow[conTSysPara.Memo] == DBNull.Value ? null : objRow[conTSysPara.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objTSysParaEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objTSysParaEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsTSysParaEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsTSysParaEN> arrObjLst = new List<clsTSysParaEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsTSysParaEN objTSysParaEN = new clsTSysParaEN();
try
{
objTSysParaEN.mId = Int32.Parse(objRow[conTSysPara.mId].ToString().Trim()); //mId
objTSysParaEN.SysParaName = objRow[conTSysPara.SysParaName].ToString().Trim(); //SysParaName
objTSysParaEN.SysParaValue = objRow[conTSysPara.SysParaValue].ToString().Trim(); //SysParaValue
objTSysParaEN.IdSchool = objRow[conTSysPara.IdSchool] == DBNull.Value ? null : objRow[conTSysPara.IdSchool].ToString().Trim(); //学校流水号
objTSysParaEN.SchoolId = objRow[conTSysPara.SchoolId] == DBNull.Value ? null : objRow[conTSysPara.SchoolId].ToString().Trim(); //学校编号
objTSysParaEN.ModifyDate = objRow[conTSysPara.ModifyDate] == DBNull.Value ? null : objRow[conTSysPara.ModifyDate].ToString().Trim(); //修改日期
objTSysParaEN.ModifyUser = objRow[conTSysPara.ModifyUser] == DBNull.Value ? null : objRow[conTSysPara.ModifyUser].ToString().Trim(); //ModifyUser
objTSysParaEN.Memo = objRow[conTSysPara.Memo] == DBNull.Value ? null : objRow[conTSysPara.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objTSysParaEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objTSysParaEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objTSysParaEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetTSysPara(ref clsTSysParaEN objTSysParaEN)
{
bool bolResult = TSysParaDA.GetTSysPara(ref objTSysParaEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public static clsTSysParaEN GetObjBymId(long lngmId)
{
clsTSysParaEN objTSysParaEN = TSysParaDA.GetObjBymId(lngmId);
return objTSysParaEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsTSysParaEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsTSysParaEN objTSysParaEN = TSysParaDA.GetFirstObj(strWhereCond);
 return objTSysParaEN;
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
public static clsTSysParaEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsTSysParaEN objTSysParaEN = TSysParaDA.GetObjByDataRow(objRow);
 return objTSysParaEN;
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
public static clsTSysParaEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsTSysParaEN objTSysParaEN = TSysParaDA.GetObjByDataRow(objRow);
 return objTSysParaEN;
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
 /// <param name = "lngmId">所给的关键字</param>
 /// <param name = "lstTSysParaObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsTSysParaEN GetObjBymIdFromList(long lngmId, List<clsTSysParaEN> lstTSysParaObjLst)
{
foreach (clsTSysParaEN objTSysParaEN in lstTSysParaObjLst)
{
if (objTSysParaEN.mId == lngmId)
{
return objTSysParaEN;
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
public static long GetFirstID_S(string strWhereCond) 
{
 long lngmId;
 try
 {
 lngmId = new clsTSysParaDA().GetFirstID(strWhereCond);
 return lngmId;
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
 arrList = TSysParaDA.GetID(strWhereCond);
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
bool bolIsExist = TSysParaDA.IsExistCondRec(strWhereCond);
return bolIsExist;
}

 /// <summary>
 /// 判断当前表中是否存在给定关键字值的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExist)
 /// </summary>
 /// <param name = "lngmId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public static bool IsExist(long lngmId)
{
//检测记录是否存在
bool bolIsExist = TSysParaDA.IsExist(lngmId);
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
 bolIsExist = clsTSysParaDA.IsExistTable();
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
 bolIsExist = TSysParaDA.IsExistTable(strTabName);
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
 /// <param name = "objTSysParaEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecordBySql2(clsTSysParaEN objTSysParaEN)
{
try
{
bool bolResult = TSysParaDA.AddNewRecordBySQL2(objTSysParaEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsTSysParaBL.ReFreshCache();

if (clsTSysParaBL.relatedActions != null)
{
clsTSysParaBL.relatedActions.UpdRelaTabDate(objTSysParaEN.mId, "SetUpdDate");
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
 /// <param name = "objTSysParaEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordBySql2WithReturnKey(clsTSysParaEN objTSysParaEN)
{
try
{
string strKey = TSysParaDA.AddNewRecordBySQL2WithReturnKey(objTSysParaEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsTSysParaBL.ReFreshCache();

if (clsTSysParaBL.relatedActions != null)
{
clsTSysParaBL.relatedActions.UpdRelaTabDate(objTSysParaEN.mId, "SetUpdDate");
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
 /// <param name = "objTSysParaEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(clsTSysParaEN objTSysParaEN)
{
try
{
bool bolResult = TSysParaDA.Update(objTSysParaEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsTSysParaBL.ReFreshCache();

if (clsTSysParaBL.relatedActions != null)
{
clsTSysParaBL.relatedActions.UpdRelaTabDate(objTSysParaEN.mId, "SetUpdDate");
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
 /// <param name = "objTSysParaEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateBySql2(clsTSysParaEN objTSysParaEN)
{
 if (objTSysParaEN.mId == 0)
 {
var strMsg = string.Format("(errid:Busi000065)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = TSysParaDA.UpdateBySql2(objTSysParaEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsTSysParaBL.ReFreshCache();

if (clsTSysParaBL.relatedActions != null)
{
clsTSysParaBL.relatedActions.UpdRelaTabDate(objTSysParaEN.mId, "SetUpdDate");
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
 /// <param name = "lngmId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int DelRecord(long lngmId)
{
try
{
 clsTSysParaEN objTSysParaEN = clsTSysParaBL.GetObjBymId(lngmId);

if (clsTSysParaBL.relatedActions != null)
{
clsTSysParaBL.relatedActions.UpdRelaTabDate(objTSysParaEN.mId, "SetUpdDate");
}
if (objTSysParaEN != null)
{
int intRecNum = TSysParaDA.DelRecord(lngmId);
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
/// <param name="lngmId">表关键字</param>
/// <returns></returns>
public static bool DelRecordEx(long lngmId )
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsTSysParaDA.GetSpecSQLObj();
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
//删除与表:[TSysPara]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conTSysPara.mId,
//lngmId);
//        clsTSysParaBL.DelTSysParasByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsTSysParaBL.DelRecord(lngmId, objConnection, objSqlTransaction);
objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsTSysParaBLEx", "DelRecordEx", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("扩展删除记录出错:{0}!keyId = {1}.({2})",
objException.Message,
lngmId, clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "lngmId">给定的关键字值</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回删除是否成功?</returns>
public static bool DelRecord(long lngmId, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
if (clsTSysParaBL.relatedActions != null)
{
clsTSysParaBL.relatedActions.UpdRelaTabDate(lngmId, "UpdRelaTabDate");
}
bool bolResult = TSysParaDA.DelRecord(lngmId,objSqlConnection,objSqlTransaction);
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
 /// <param name = "arrmIdLst">给定的关键字值列表</param>
 /// <returns>返回删除的记录数</returns>
public static int DelTSysParas(List<string> arrmIdLst)
{
if (arrmIdLst.Count == 0) return 0;
try
{
if (clsTSysParaBL.relatedActions != null)
{
foreach (var strmId in arrmIdLst)
{
long lngmId = long.Parse(strmId);
clsTSysParaBL.relatedActions.UpdRelaTabDate(lngmId, "UpdRelaTabDate");
}
}
int intDelRecNum = TSysParaDA.DelTSysPara(arrmIdLst);
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
public static int DelTSysParasByCond(string strWhereCond)
{
try
{
if (clsTSysParaBL.relatedActions != null)
{
List<string> arrmId = GetPrimaryKeyID_S(strWhereCond);
foreach (var strmId in arrmId)
{
long lngmId = long.Parse(strmId);
clsTSysParaBL.relatedActions.UpdRelaTabDate(lngmId, "UpdRelaTabDate");
}
}
int intRecNum = TSysParaDA.DelTSysPara(strWhereCond);
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
/// 这里仅仅是演示函数,使用时请复制到扩展类:[TSysPara]中改名为:[DelRecord4MultiTabEx]使用
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DelRecord4MultiTab)
/// </summary>
/// <param name="lngmId">表关键字</param>
/// <returns></returns>
public static bool DelRecord4MultiTab(long lngmId)
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsTSysParaDA.GetSpecSQLObj();
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
//删除与表:[TSysPara]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conStudent.id_College,
//strid_College);
//        clsStudentBL.DelStudentsByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsTSysParaBL.DelRecord(lngmId, objConnection, objSqlTransaction);
                objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsTSysParaBL", "DelRecord4MultiTab", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("删除多表记录出错:{0}!keyId = {1}.({2})",
objException.Message,
lngmId, clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "objTSysParaENS">源对象</param>
 /// <param name = "objTSysParaENT">目标对象</param>
 public static void CopyTo(clsTSysParaEN objTSysParaENS, clsTSysParaEN objTSysParaENT)
{
try
{
objTSysParaENT.mId = objTSysParaENS.mId; //mId
objTSysParaENT.SysParaName = objTSysParaENS.SysParaName; //SysParaName
objTSysParaENT.SysParaValue = objTSysParaENS.SysParaValue; //SysParaValue
objTSysParaENT.IdSchool = objTSysParaENS.IdSchool; //学校流水号
objTSysParaENT.SchoolId = objTSysParaENS.SchoolId; //学校编号
objTSysParaENT.ModifyDate = objTSysParaENS.ModifyDate; //修改日期
objTSysParaENT.ModifyUser = objTSysParaENS.ModifyUser; //ModifyUser
objTSysParaENT.Memo = objTSysParaENS.Memo; //备注
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
 /// <param name = "objTSysParaEN">源简化对象</param>
 public static void SetUpdFlag(clsTSysParaEN objTSysParaEN)
{
try
{
objTSysParaEN.ClearUpdateState();
   string strsfUpdFldSetStr = objTSysParaEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(conTSysPara.mId, new clsStrCompareIgnoreCase())  ==  true)
{
objTSysParaEN.mId = objTSysParaEN.mId; //mId
}
if (arrFldSet.Contains(conTSysPara.SysParaName, new clsStrCompareIgnoreCase())  ==  true)
{
objTSysParaEN.SysParaName = objTSysParaEN.SysParaName; //SysParaName
}
if (arrFldSet.Contains(conTSysPara.SysParaValue, new clsStrCompareIgnoreCase())  ==  true)
{
objTSysParaEN.SysParaValue = objTSysParaEN.SysParaValue; //SysParaValue
}
if (arrFldSet.Contains(conTSysPara.IdSchool, new clsStrCompareIgnoreCase())  ==  true)
{
objTSysParaEN.IdSchool = objTSysParaEN.IdSchool == "[null]" ? null :  objTSysParaEN.IdSchool; //学校流水号
}
if (arrFldSet.Contains(conTSysPara.SchoolId, new clsStrCompareIgnoreCase())  ==  true)
{
objTSysParaEN.SchoolId = objTSysParaEN.SchoolId == "[null]" ? null :  objTSysParaEN.SchoolId; //学校编号
}
if (arrFldSet.Contains(conTSysPara.ModifyDate, new clsStrCompareIgnoreCase())  ==  true)
{
objTSysParaEN.ModifyDate = objTSysParaEN.ModifyDate == "[null]" ? null :  objTSysParaEN.ModifyDate; //修改日期
}
if (arrFldSet.Contains(conTSysPara.ModifyUser, new clsStrCompareIgnoreCase())  ==  true)
{
objTSysParaEN.ModifyUser = objTSysParaEN.ModifyUser == "[null]" ? null :  objTSysParaEN.ModifyUser; //ModifyUser
}
if (arrFldSet.Contains(conTSysPara.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objTSysParaEN.Memo = objTSysParaEN.Memo == "[null]" ? null :  objTSysParaEN.Memo; //备注
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
 /// <param name = "objTSysParaEN">源简化对象</param>
 public static void AccessFldValueNull(clsTSysParaEN objTSysParaEN)
{
try
{
if (objTSysParaEN.IdSchool == "[null]") objTSysParaEN.IdSchool = null; //学校流水号
if (objTSysParaEN.SchoolId == "[null]") objTSysParaEN.SchoolId = null; //学校编号
if (objTSysParaEN.ModifyDate == "[null]") objTSysParaEN.ModifyDate = null; //修改日期
if (objTSysParaEN.ModifyUser == "[null]") objTSysParaEN.ModifyUser = null; //ModifyUser
if (objTSysParaEN.Memo == "[null]") objTSysParaEN.Memo = null; //备注
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
public static void CheckPropertyNew(clsTSysParaEN objTSysParaEN)
{
 TSysParaDA.CheckPropertyNew(objTSysParaEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(clsTSysParaEN objTSysParaEN)
{
 TSysParaDA.CheckProperty4Condition(objTSysParaEN);
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
if (clsTSysParaBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsTSysParaBL没有刷新缓存机制(clsTSysParaBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by mId");
//if (arrTSysParaObjLstCache == null)
//{
//arrTSysParaObjLstCache = TSysParaDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "lngmId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsTSysParaEN GetObjBymIdCache(long lngmId)
{
//获取缓存中的对象列表
string strKey = string.Format("{0}", clsTSysParaEN._CurrTabName);
List<clsTSysParaEN> arrTSysParaObjLstCache = GetObjLstCache();
IEnumerable <clsTSysParaEN> arrTSysParaObjLst_Sel =
arrTSysParaObjLstCache
.Where(x=> x.mId == lngmId 
);
if (arrTSysParaObjLst_Sel.Count() == 0)
{
   clsTSysParaEN obj = clsTSysParaBL.GetObjBymId(lngmId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
 }
return null;
}
return arrTSysParaObjLst_Sel.First();
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsTSysParaEN> GetAllTSysParaObjLstCache()
{
//获取缓存中的对象列表
List<clsTSysParaEN> arrTSysParaObjLstCache = GetObjLstCache(); 
return arrTSysParaObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsTSysParaEN> GetObjLstCache()
{
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}", clsTSysParaEN._CurrTabName);
List<clsTSysParaEN> arrTSysParaObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrTSysParaObjLstCache;
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
string strKey = string.Format("{0}", clsTSysParaEN._CurrTabName);
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
if (clsTSysParaBL.objCommFun4BL != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}", clsTSysParaEN._CurrTabName);
CacheHelper.Remove(strKey);
clsTSysParaBL.objCommFun4BL.ReFreshCache();
}
}


 #endregion 缓存操作


 #region 检查唯一性


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
 /// <returns>返回一个输出字段值</returns>
public static string Func(string strInFldName, string strOutFldName, long lngmId)
{
if (strInFldName != conTSysPara.mId)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (conTSysPara.AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", conTSysPara.AttributeName));
throw new Exception(strMsg);
}
var objTSysPara = clsTSysParaBL.GetObjBymIdCache(lngmId);
if (objTSysPara == null) return "";
return objTSysPara[strOutFldName].ToString();
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
int intRecCount = clsTSysParaDA.GetRecCount(strTabName);
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
int intRecCount = clsTSysParaDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsTSysParaDA.GetRecCount();
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
int intRecCount = clsTSysParaDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objTSysParaCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsTSysParaEN objTSysParaCond)
{
List<clsTSysParaEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsTSysParaEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conTSysPara.AttributeName)
{
if (objTSysParaCond.IsUpdated(strFldName) == false) continue;
if (objTSysParaCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objTSysParaCond[strFldName].ToString());
}
else
{
if (objTSysParaCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objTSysParaCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objTSysParaCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objTSysParaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objTSysParaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objTSysParaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objTSysParaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objTSysParaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objTSysParaCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objTSysParaCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objTSysParaCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objTSysParaCond[strFldName]));
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
 List<string> arrList = clsTSysParaDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = TSysParaDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = TSysParaDA.GetFldValueNoDistinct(strFldName, strWhereCond);
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
int intRecCount = TSysParaDA.SetFldValue(strFldName, strValue, strWhereCond);
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
int intRecCount = clsTSysParaDA.SetFldValue(clsTSysParaEN._CurrTabName, strFldName, fltValue, strWhereCond);
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
int intRecCount = TSysParaDA.SetFldValue( strFldName, intValue, strWhereCond);
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
int intRecCount = clsTSysParaDA.SetFldValue(strTabName, strFldName, strValue, strWhereCond);
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
int intRecCount = clsTSysParaDA.SetFldValue(strTabName, strFldName, intValue, strWhereCond);
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
int intRecCount = clsTSysParaDA.SetFldValue(strTabName, strFldName, fltValue, strWhereCond);
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
  strCreateTabCode.Append("CREATE table [dbo].[TSysPara] "); 
 strCreateTabCode.Append(" ( "); 
 // /**mId*/ 
 strCreateTabCode.Append(" mId bigint primary key identity, "); 
 // /**SysParaName*/ 
 strCreateTabCode.Append(" SysParaName varchar(50) not Null, "); 
 // /**SysParaValue*/ 
 strCreateTabCode.Append(" SysParaValue varchar(200) not Null, "); 
 // /**学校流水号*/ 
 strCreateTabCode.Append(" IdSchool char(4) Null, "); 
 // /**学校编号*/ 
 strCreateTabCode.Append(" SchoolId varchar(10) Null, "); 
 // /**修改日期*/ 
 strCreateTabCode.Append(" ModifyDate varchar(20) Null, "); 
 // /**ModifyUser*/ 
 strCreateTabCode.Append(" ModifyUser varchar(30) Null, "); 
 // /**备注*/ 
 strCreateTabCode.Append(" Memo varchar(1000) Null ");
 strCreateTabCode.Append(") "); 
  strCreateTabCode.Append("ON [PRIMARY] ");
  return strCreateTabCode.ToString();
}



 #endregion 表操作
}
 /// <summary>
 /// TSysPara(TSysPara)
 /// 数据源类型:表
 /// (AutoGCLib.CommFun4BL4CSharp:GeneCode_This)
 /// </summary>
public class  clsCommFun4BL4TSysPara : clsCommFun4BL
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
clsTSysParaBL.ReFreshThisCache();
}
}

}