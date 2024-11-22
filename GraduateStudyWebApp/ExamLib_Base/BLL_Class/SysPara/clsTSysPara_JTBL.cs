
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsTSysPara_JTBL
 表名:TSysPara_JT(01120754)
 * 版本:2023.11.15.1(服务器:WIN-SRV103-116)
 日期:2023/11/15 22:54:03
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
public static class  clsTSysPara_JTBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public static clsTSysPara_JTEN GetObj(this K_mId_TSysPara_JT myKey)
{
clsTSysPara_JTEN objTSysPara_JTEN = clsTSysPara_JTBL.TSysPara_JTDA.GetObjBymId(myKey.Value);
return objTSysPara_JTEN;
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_AddNewRecord)
 /// </summary>
 /// <param name = "objTSysPara_JTEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clsTSysPara_JTEN objTSysPara_JTEN)
{
try
{
bool bolResult = clsTSysPara_JTBL.TSysPara_JTDA.AddNewRecordBySQL2(objTSysPara_JTEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsTSysPara_JTBL.ReFreshCache();

if (clsTSysPara_JTBL.relatedActions != null)
{
clsTSysPara_JTBL.relatedActions.UpdRelaTabDate(objTSysPara_JTEN.mId, "SetUpdDate");
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
public static bool AddRecordEx(this clsTSysPara_JTEN objTSysPara_JTEN)
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
objTSysPara_JTEN.CheckPropertyNew();
//6、把数据实体层的数据存贮到数据库中
objTSysPara_JTEN.AddNewRecord();
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
 /// <param name = "objTSysPara_JTEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordWithReturnKey(this clsTSysPara_JTEN objTSysPara_JTEN)
{
try
{
string strKey = clsTSysPara_JTBL.TSysPara_JTDA.AddNewRecordBySQL2WithReturnKey(objTSysPara_JTEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsTSysPara_JTBL.ReFreshCache();

if (clsTSysPara_JTBL.relatedActions != null)
{
clsTSysPara_JTBL.relatedActions.UpdRelaTabDate(objTSysPara_JTEN.mId, "SetUpdDate");
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
 /// <param name = "objTSysPara_JTEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsTSysPara_JTEN SetmId(this clsTSysPara_JTEN objTSysPara_JTEN, long lngmId, string strComparisonOp="")
	{
objTSysPara_JTEN.mId = lngmId; //mId
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objTSysPara_JTEN.dicFldComparisonOp.ContainsKey(conTSysPara_JT.mId) == false)
{
objTSysPara_JTEN.dicFldComparisonOp.Add(conTSysPara_JT.mId, strComparisonOp);
}
else
{
objTSysPara_JTEN.dicFldComparisonOp[conTSysPara_JT.mId] = strComparisonOp;
}
}
return objTSysPara_JTEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objTSysPara_JTEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsTSysPara_JTEN SetSysParaName(this clsTSysPara_JTEN objTSysPara_JTEN, string strSysParaName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strSysParaName, conTSysPara_JT.SysParaName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strSysParaName, 50, conTSysPara_JT.SysParaName);
}
objTSysPara_JTEN.SysParaName = strSysParaName; //SysParaName
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objTSysPara_JTEN.dicFldComparisonOp.ContainsKey(conTSysPara_JT.SysParaName) == false)
{
objTSysPara_JTEN.dicFldComparisonOp.Add(conTSysPara_JT.SysParaName, strComparisonOp);
}
else
{
objTSysPara_JTEN.dicFldComparisonOp[conTSysPara_JT.SysParaName] = strComparisonOp;
}
}
return objTSysPara_JTEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objTSysPara_JTEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsTSysPara_JTEN SetSysParaValue(this clsTSysPara_JTEN objTSysPara_JTEN, string strSysParaValue, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strSysParaValue, conTSysPara_JT.SysParaValue);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strSysParaValue, 200, conTSysPara_JT.SysParaValue);
}
objTSysPara_JTEN.SysParaValue = strSysParaValue; //SysParaValue
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objTSysPara_JTEN.dicFldComparisonOp.ContainsKey(conTSysPara_JT.SysParaValue) == false)
{
objTSysPara_JTEN.dicFldComparisonOp.Add(conTSysPara_JT.SysParaValue, strComparisonOp);
}
else
{
objTSysPara_JTEN.dicFldComparisonOp[conTSysPara_JT.SysParaValue] = strComparisonOp;
}
}
return objTSysPara_JTEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objTSysPara_JTEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsTSysPara_JTEN SetIdSchool(this clsTSysPara_JTEN objTSysPara_JTEN, string strIdSchool, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdSchool, 4, conTSysPara_JT.IdSchool);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdSchool, 4, conTSysPara_JT.IdSchool);
}
objTSysPara_JTEN.IdSchool = strIdSchool; //学校流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objTSysPara_JTEN.dicFldComparisonOp.ContainsKey(conTSysPara_JT.IdSchool) == false)
{
objTSysPara_JTEN.dicFldComparisonOp.Add(conTSysPara_JT.IdSchool, strComparisonOp);
}
else
{
objTSysPara_JTEN.dicFldComparisonOp[conTSysPara_JT.IdSchool] = strComparisonOp;
}
}
return objTSysPara_JTEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objTSysPara_JTEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsTSysPara_JTEN SetSchoolId(this clsTSysPara_JTEN objTSysPara_JTEN, string strSchoolId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strSchoolId, 10, conTSysPara_JT.SchoolId);
}
objTSysPara_JTEN.SchoolId = strSchoolId; //学校编号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objTSysPara_JTEN.dicFldComparisonOp.ContainsKey(conTSysPara_JT.SchoolId) == false)
{
objTSysPara_JTEN.dicFldComparisonOp.Add(conTSysPara_JT.SchoolId, strComparisonOp);
}
else
{
objTSysPara_JTEN.dicFldComparisonOp[conTSysPara_JT.SchoolId] = strComparisonOp;
}
}
return objTSysPara_JTEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objTSysPara_JTEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsTSysPara_JTEN SetModifyDate(this clsTSysPara_JTEN objTSysPara_JTEN, string strModifyDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strModifyDate, 20, conTSysPara_JT.ModifyDate);
}
objTSysPara_JTEN.ModifyDate = strModifyDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objTSysPara_JTEN.dicFldComparisonOp.ContainsKey(conTSysPara_JT.ModifyDate) == false)
{
objTSysPara_JTEN.dicFldComparisonOp.Add(conTSysPara_JT.ModifyDate, strComparisonOp);
}
else
{
objTSysPara_JTEN.dicFldComparisonOp[conTSysPara_JT.ModifyDate] = strComparisonOp;
}
}
return objTSysPara_JTEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objTSysPara_JTEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsTSysPara_JTEN SetModifyUser(this clsTSysPara_JTEN objTSysPara_JTEN, string strModifyUser, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strModifyUser, 30, conTSysPara_JT.ModifyUser);
}
objTSysPara_JTEN.ModifyUser = strModifyUser; //ModifyUser
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objTSysPara_JTEN.dicFldComparisonOp.ContainsKey(conTSysPara_JT.ModifyUser) == false)
{
objTSysPara_JTEN.dicFldComparisonOp.Add(conTSysPara_JT.ModifyUser, strComparisonOp);
}
else
{
objTSysPara_JTEN.dicFldComparisonOp[conTSysPara_JT.ModifyUser] = strComparisonOp;
}
}
return objTSysPara_JTEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objTSysPara_JTEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsTSysPara_JTEN SetMemo(this clsTSysPara_JTEN objTSysPara_JTEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, conTSysPara_JT.Memo);
}
objTSysPara_JTEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objTSysPara_JTEN.dicFldComparisonOp.ContainsKey(conTSysPara_JT.Memo) == false)
{
objTSysPara_JTEN.dicFldComparisonOp.Add(conTSysPara_JT.Memo, strComparisonOp);
}
else
{
objTSysPara_JTEN.dicFldComparisonOp[conTSysPara_JT.Memo] = strComparisonOp;
}
}
return objTSysPara_JTEN;
	}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_Update)
 /// </summary>
 /// <param name = "objTSysPara_JTEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsTSysPara_JTEN objTSysPara_JTEN)
{
 if (objTSysPara_JTEN.mId == 0)
 {
string strMsg = string.Format("(errid:Busi000095)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsTSysPara_JTBL.TSysPara_JTDA.UpdateBySql2(objTSysPara_JTEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsTSysPara_JTBL.ReFreshCache();

if (clsTSysPara_JTBL.relatedActions != null)
{
clsTSysPara_JTBL.relatedActions.UpdRelaTabDate(objTSysPara_JTEN.mId, "SetUpdDate");
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
 /// <param name = "objTSysPara_JTEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsTSysPara_JTEN objTSysPara_JTEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (objTSysPara_JTEN.mId == 0)
 {
string strMsg = string.Format("(errid:Busi000087)修改记录时关键字不能为空!(带事务处理)(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsTSysPara_JTBL.TSysPara_JTDA.UpdateBySql2(objTSysPara_JTEN, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsTSysPara_JTBL.ReFreshCache();

if (clsTSysPara_JTBL.relatedActions != null)
{
clsTSysPara_JTBL.relatedActions.UpdRelaTabDate(objTSysPara_JTEN.mId, "SetUpdDate");
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
 /// <param name = "objTSysPara_JTEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsTSysPara_JTEN objTSysPara_JTEN, string strWhereCond)
{
try
{
bool bolResult = clsTSysPara_JTBL.TSysPara_JTDA.UpdateBySqlWithCondition(objTSysPara_JTEN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsTSysPara_JTBL.ReFreshCache();

if (clsTSysPara_JTBL.relatedActions != null)
{
clsTSysPara_JTBL.relatedActions.UpdRelaTabDate(objTSysPara_JTEN.mId, "SetUpdDate");
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
 /// <param name = "objTSysPara_JTEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsTSysPara_JTEN objTSysPara_JTEN, string strWhereCond, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
bool bolResult = clsTSysPara_JTBL.TSysPara_JTDA.UpdateBySqlWithConditionTransaction(objTSysPara_JTEN, strWhereCond, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsTSysPara_JTBL.ReFreshCache();

if (clsTSysPara_JTBL.relatedActions != null)
{
clsTSysPara_JTBL.relatedActions.UpdRelaTabDate(objTSysPara_JTEN.mId, "SetUpdDate");
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
public static int Delete(this clsTSysPara_JTEN objTSysPara_JTEN)
{
try
{
int intRecNum = clsTSysPara_JTBL.TSysPara_JTDA.DelRecord(objTSysPara_JTEN.mId);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsTSysPara_JTBL.ReFreshCache();

if (clsTSysPara_JTBL.relatedActions != null)
{
clsTSysPara_JTBL.relatedActions.UpdRelaTabDate(objTSysPara_JTEN.mId, "SetUpdDate");
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
 /// <param name = "objTSysPara_JTENS">源对象</param>
 /// <param name = "objTSysPara_JTENT">目标对象</param>
 public static void CopyTo(this clsTSysPara_JTEN objTSysPara_JTENS, clsTSysPara_JTEN objTSysPara_JTENT)
{
try
{
objTSysPara_JTENT.mId = objTSysPara_JTENS.mId; //mId
objTSysPara_JTENT.SysParaName = objTSysPara_JTENS.SysParaName; //SysParaName
objTSysPara_JTENT.SysParaValue = objTSysPara_JTENS.SysParaValue; //SysParaValue
objTSysPara_JTENT.IdSchool = objTSysPara_JTENS.IdSchool; //学校流水号
objTSysPara_JTENT.SchoolId = objTSysPara_JTENS.SchoolId; //学校编号
objTSysPara_JTENT.ModifyDate = objTSysPara_JTENS.ModifyDate; //修改日期
objTSysPara_JTENT.ModifyUser = objTSysPara_JTENS.ModifyUser; //ModifyUser
objTSysPara_JTENT.Memo = objTSysPara_JTENS.Memo; //备注
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
 /// <param name = "objTSysPara_JTENS">源对象</param>
 /// <returns>目标对象=>clsTSysPara_JTEN:objTSysPara_JTENT</returns>
 public static clsTSysPara_JTEN CopyTo(this clsTSysPara_JTEN objTSysPara_JTENS)
{
try
{
 clsTSysPara_JTEN objTSysPara_JTENT = new clsTSysPara_JTEN()
{
mId = objTSysPara_JTENS.mId, //mId
SysParaName = objTSysPara_JTENS.SysParaName, //SysParaName
SysParaValue = objTSysPara_JTENS.SysParaValue, //SysParaValue
IdSchool = objTSysPara_JTENS.IdSchool, //学校流水号
SchoolId = objTSysPara_JTENS.SchoolId, //学校编号
ModifyDate = objTSysPara_JTENS.ModifyDate, //修改日期
ModifyUser = objTSysPara_JTENS.ModifyUser, //ModifyUser
Memo = objTSysPara_JTENS.Memo, //备注
};
 return objTSysPara_JTENT;
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
public static void CheckPropertyNew(this clsTSysPara_JTEN objTSysPara_JTEN)
{
 clsTSysPara_JTBL.TSysPara_JTDA.CheckPropertyNew(objTSysPara_JTEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(this clsTSysPara_JTEN objTSysPara_JTEN)
{
 clsTSysPara_JTBL.TSysPara_JTDA.CheckProperty4Condition(objTSysPara_JTEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsTSysPara_JTEN objTSysPara_JTCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objTSysPara_JTCond.IsUpdated(conTSysPara_JT.mId) == true)
{
string strComparisonOpmId = objTSysPara_JTCond.dicFldComparisonOp[conTSysPara_JT.mId];
strWhereCond += string.Format(" And {0} {2} {1}", conTSysPara_JT.mId, objTSysPara_JTCond.mId, strComparisonOpmId);
}
if (objTSysPara_JTCond.IsUpdated(conTSysPara_JT.SysParaName) == true)
{
string strComparisonOpSysParaName = objTSysPara_JTCond.dicFldComparisonOp[conTSysPara_JT.SysParaName];
strWhereCond += string.Format(" And {0} {2} '{1}'", conTSysPara_JT.SysParaName, objTSysPara_JTCond.SysParaName, strComparisonOpSysParaName);
}
if (objTSysPara_JTCond.IsUpdated(conTSysPara_JT.SysParaValue) == true)
{
string strComparisonOpSysParaValue = objTSysPara_JTCond.dicFldComparisonOp[conTSysPara_JT.SysParaValue];
strWhereCond += string.Format(" And {0} {2} '{1}'", conTSysPara_JT.SysParaValue, objTSysPara_JTCond.SysParaValue, strComparisonOpSysParaValue);
}
if (objTSysPara_JTCond.IsUpdated(conTSysPara_JT.IdSchool) == true)
{
string strComparisonOpIdSchool = objTSysPara_JTCond.dicFldComparisonOp[conTSysPara_JT.IdSchool];
strWhereCond += string.Format(" And {0} {2} '{1}'", conTSysPara_JT.IdSchool, objTSysPara_JTCond.IdSchool, strComparisonOpIdSchool);
}
if (objTSysPara_JTCond.IsUpdated(conTSysPara_JT.SchoolId) == true)
{
string strComparisonOpSchoolId = objTSysPara_JTCond.dicFldComparisonOp[conTSysPara_JT.SchoolId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conTSysPara_JT.SchoolId, objTSysPara_JTCond.SchoolId, strComparisonOpSchoolId);
}
if (objTSysPara_JTCond.IsUpdated(conTSysPara_JT.ModifyDate) == true)
{
string strComparisonOpModifyDate = objTSysPara_JTCond.dicFldComparisonOp[conTSysPara_JT.ModifyDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conTSysPara_JT.ModifyDate, objTSysPara_JTCond.ModifyDate, strComparisonOpModifyDate);
}
if (objTSysPara_JTCond.IsUpdated(conTSysPara_JT.ModifyUser) == true)
{
string strComparisonOpModifyUser = objTSysPara_JTCond.dicFldComparisonOp[conTSysPara_JT.ModifyUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", conTSysPara_JT.ModifyUser, objTSysPara_JTCond.ModifyUser, strComparisonOpModifyUser);
}
if (objTSysPara_JTCond.IsUpdated(conTSysPara_JT.Memo) == true)
{
string strComparisonOpMemo = objTSysPara_JTCond.dicFldComparisonOp[conTSysPara_JT.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", conTSysPara_JT.Memo, objTSysPara_JTCond.Memo, strComparisonOpMemo);
}
 return strWhereCond;
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_TSysPara_JT
{
public virtual bool UpdRelaTabDate(long lngmId, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// TSysPara_JT(TSysPara_JT)
 /// 数据源类型:表
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsTSysPara_JTBL
{
public static RelatedActions_TSysPara_JT relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsTSysPara_JTDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsTSysPara_JTDA TSysPara_JTDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsTSysPara_JTDA();
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
 public clsTSysPara_JTBL()
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
if (string.IsNullOrEmpty(clsTSysPara_JTEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsTSysPara_JTEN._ConnectString);
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
public static DataTable GetDataTable_TSysPara_JT(string strWhereCond)
{
DataTable objDT;
try
{
objDT = TSysPara_JTDA.GetDataTable_TSysPara_JT(strWhereCond);
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
objDT = TSysPara_JTDA.GetDataTable(strWhereCond);
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
objDT = TSysPara_JTDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = TSysPara_JTDA.GetDataTable(strWhereCond, strTabName);
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
objDT = TSysPara_JTDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = TSysPara_JTDA.GetDataTable_Top(objTopPara);
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
objDT = TSysPara_JTDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = TSysPara_JTDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = TSysPara_JTDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
public static List<clsTSysPara_JTEN> GetObjLstByMIdLst(List<long> arrMIdLst)
{
List<clsTSysPara_JTEN> arrObjLst = new List<clsTSysPara_JTEN>(); 
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
	clsTSysPara_JTEN objTSysPara_JTEN = new clsTSysPara_JTEN();
try
{
objTSysPara_JTEN.mId = Int32.Parse(objRow[conTSysPara_JT.mId].ToString().Trim()); //mId
objTSysPara_JTEN.SysParaName = objRow[conTSysPara_JT.SysParaName].ToString().Trim(); //SysParaName
objTSysPara_JTEN.SysParaValue = objRow[conTSysPara_JT.SysParaValue].ToString().Trim(); //SysParaValue
objTSysPara_JTEN.IdSchool = objRow[conTSysPara_JT.IdSchool] == DBNull.Value ? null : objRow[conTSysPara_JT.IdSchool].ToString().Trim(); //学校流水号
objTSysPara_JTEN.SchoolId = objRow[conTSysPara_JT.SchoolId] == DBNull.Value ? null : objRow[conTSysPara_JT.SchoolId].ToString().Trim(); //学校编号
objTSysPara_JTEN.ModifyDate = objRow[conTSysPara_JT.ModifyDate] == DBNull.Value ? null : objRow[conTSysPara_JT.ModifyDate].ToString().Trim(); //修改日期
objTSysPara_JTEN.ModifyUser = objRow[conTSysPara_JT.ModifyUser] == DBNull.Value ? null : objRow[conTSysPara_JT.ModifyUser].ToString().Trim(); //ModifyUser
objTSysPara_JTEN.Memo = objRow[conTSysPara_JT.Memo] == DBNull.Value ? null : objRow[conTSysPara_JT.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objTSysPara_JTEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objTSysPara_JTEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrMIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsTSysPara_JTEN> GetObjLstByMIdLstCache(List<long> arrMIdLst)
{
string strKey = string.Format("{0}", clsTSysPara_JTEN._CurrTabName);
List<clsTSysPara_JTEN> arrTSysPara_JTObjLstCache = GetObjLstCache();
IEnumerable <clsTSysPara_JTEN> arrTSysPara_JTObjLst_Sel =
arrTSysPara_JTObjLstCache
.Where(x => arrMIdLst.Contains(x.mId));
return arrTSysPara_JTObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsTSysPara_JTEN> GetObjLst(string strWhereCond)
{
List<clsTSysPara_JTEN> arrObjLst = new List<clsTSysPara_JTEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsTSysPara_JTEN objTSysPara_JTEN = new clsTSysPara_JTEN();
try
{
objTSysPara_JTEN.mId = Int32.Parse(objRow[conTSysPara_JT.mId].ToString().Trim()); //mId
objTSysPara_JTEN.SysParaName = objRow[conTSysPara_JT.SysParaName].ToString().Trim(); //SysParaName
objTSysPara_JTEN.SysParaValue = objRow[conTSysPara_JT.SysParaValue].ToString().Trim(); //SysParaValue
objTSysPara_JTEN.IdSchool = objRow[conTSysPara_JT.IdSchool] == DBNull.Value ? null : objRow[conTSysPara_JT.IdSchool].ToString().Trim(); //学校流水号
objTSysPara_JTEN.SchoolId = objRow[conTSysPara_JT.SchoolId] == DBNull.Value ? null : objRow[conTSysPara_JT.SchoolId].ToString().Trim(); //学校编号
objTSysPara_JTEN.ModifyDate = objRow[conTSysPara_JT.ModifyDate] == DBNull.Value ? null : objRow[conTSysPara_JT.ModifyDate].ToString().Trim(); //修改日期
objTSysPara_JTEN.ModifyUser = objRow[conTSysPara_JT.ModifyUser] == DBNull.Value ? null : objRow[conTSysPara_JT.ModifyUser].ToString().Trim(); //ModifyUser
objTSysPara_JTEN.Memo = objRow[conTSysPara_JT.Memo] == DBNull.Value ? null : objRow[conTSysPara_JT.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objTSysPara_JTEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objTSysPara_JTEN);
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
public static List<clsTSysPara_JTEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsTSysPara_JTEN> arrObjLst = new List<clsTSysPara_JTEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsTSysPara_JTEN objTSysPara_JTEN = new clsTSysPara_JTEN();
try
{
objTSysPara_JTEN.mId = Int32.Parse(objRow[conTSysPara_JT.mId].ToString().Trim()); //mId
objTSysPara_JTEN.SysParaName = objRow[conTSysPara_JT.SysParaName].ToString().Trim(); //SysParaName
objTSysPara_JTEN.SysParaValue = objRow[conTSysPara_JT.SysParaValue].ToString().Trim(); //SysParaValue
objTSysPara_JTEN.IdSchool = objRow[conTSysPara_JT.IdSchool] == DBNull.Value ? null : objRow[conTSysPara_JT.IdSchool].ToString().Trim(); //学校流水号
objTSysPara_JTEN.SchoolId = objRow[conTSysPara_JT.SchoolId] == DBNull.Value ? null : objRow[conTSysPara_JT.SchoolId].ToString().Trim(); //学校编号
objTSysPara_JTEN.ModifyDate = objRow[conTSysPara_JT.ModifyDate] == DBNull.Value ? null : objRow[conTSysPara_JT.ModifyDate].ToString().Trim(); //修改日期
objTSysPara_JTEN.ModifyUser = objRow[conTSysPara_JT.ModifyUser] == DBNull.Value ? null : objRow[conTSysPara_JT.ModifyUser].ToString().Trim(); //ModifyUser
objTSysPara_JTEN.Memo = objRow[conTSysPara_JT.Memo] == DBNull.Value ? null : objRow[conTSysPara_JT.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objTSysPara_JTEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objTSysPara_JTEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objTSysPara_JTCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsTSysPara_JTEN> GetSubObjLstCache(clsTSysPara_JTEN objTSysPara_JTCond)
{
List<clsTSysPara_JTEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsTSysPara_JTEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conTSysPara_JT.AttributeName)
{
if (objTSysPara_JTCond.IsUpdated(strFldName) == false) continue;
if (objTSysPara_JTCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objTSysPara_JTCond[strFldName].ToString());
}
else
{
if (objTSysPara_JTCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objTSysPara_JTCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objTSysPara_JTCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objTSysPara_JTCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objTSysPara_JTCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objTSysPara_JTCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objTSysPara_JTCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objTSysPara_JTCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objTSysPara_JTCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objTSysPara_JTCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objTSysPara_JTCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objTSysPara_JTCond[strFldName]));
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
public static List<clsTSysPara_JTEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsTSysPara_JTEN> arrObjLst = new List<clsTSysPara_JTEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsTSysPara_JTEN objTSysPara_JTEN = new clsTSysPara_JTEN();
try
{
objTSysPara_JTEN.mId = Int32.Parse(objRow[conTSysPara_JT.mId].ToString().Trim()); //mId
objTSysPara_JTEN.SysParaName = objRow[conTSysPara_JT.SysParaName].ToString().Trim(); //SysParaName
objTSysPara_JTEN.SysParaValue = objRow[conTSysPara_JT.SysParaValue].ToString().Trim(); //SysParaValue
objTSysPara_JTEN.IdSchool = objRow[conTSysPara_JT.IdSchool] == DBNull.Value ? null : objRow[conTSysPara_JT.IdSchool].ToString().Trim(); //学校流水号
objTSysPara_JTEN.SchoolId = objRow[conTSysPara_JT.SchoolId] == DBNull.Value ? null : objRow[conTSysPara_JT.SchoolId].ToString().Trim(); //学校编号
objTSysPara_JTEN.ModifyDate = objRow[conTSysPara_JT.ModifyDate] == DBNull.Value ? null : objRow[conTSysPara_JT.ModifyDate].ToString().Trim(); //修改日期
objTSysPara_JTEN.ModifyUser = objRow[conTSysPara_JT.ModifyUser] == DBNull.Value ? null : objRow[conTSysPara_JT.ModifyUser].ToString().Trim(); //ModifyUser
objTSysPara_JTEN.Memo = objRow[conTSysPara_JT.Memo] == DBNull.Value ? null : objRow[conTSysPara_JT.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objTSysPara_JTEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objTSysPara_JTEN);
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
public static List<clsTSysPara_JTEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsTSysPara_JTEN> arrObjLst = new List<clsTSysPara_JTEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsTSysPara_JTEN objTSysPara_JTEN = new clsTSysPara_JTEN();
try
{
objTSysPara_JTEN.mId = Int32.Parse(objRow[conTSysPara_JT.mId].ToString().Trim()); //mId
objTSysPara_JTEN.SysParaName = objRow[conTSysPara_JT.SysParaName].ToString().Trim(); //SysParaName
objTSysPara_JTEN.SysParaValue = objRow[conTSysPara_JT.SysParaValue].ToString().Trim(); //SysParaValue
objTSysPara_JTEN.IdSchool = objRow[conTSysPara_JT.IdSchool] == DBNull.Value ? null : objRow[conTSysPara_JT.IdSchool].ToString().Trim(); //学校流水号
objTSysPara_JTEN.SchoolId = objRow[conTSysPara_JT.SchoolId] == DBNull.Value ? null : objRow[conTSysPara_JT.SchoolId].ToString().Trim(); //学校编号
objTSysPara_JTEN.ModifyDate = objRow[conTSysPara_JT.ModifyDate] == DBNull.Value ? null : objRow[conTSysPara_JT.ModifyDate].ToString().Trim(); //修改日期
objTSysPara_JTEN.ModifyUser = objRow[conTSysPara_JT.ModifyUser] == DBNull.Value ? null : objRow[conTSysPara_JT.ModifyUser].ToString().Trim(); //ModifyUser
objTSysPara_JTEN.Memo = objRow[conTSysPara_JT.Memo] == DBNull.Value ? null : objRow[conTSysPara_JT.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objTSysPara_JTEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objTSysPara_JTEN);
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
List<clsTSysPara_JTEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsTSysPara_JTEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsTSysPara_JTEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsTSysPara_JTEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsTSysPara_JTEN> arrObjLst = new List<clsTSysPara_JTEN>(); 
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
	clsTSysPara_JTEN objTSysPara_JTEN = new clsTSysPara_JTEN();
try
{
objTSysPara_JTEN.mId = Int32.Parse(objRow[conTSysPara_JT.mId].ToString().Trim()); //mId
objTSysPara_JTEN.SysParaName = objRow[conTSysPara_JT.SysParaName].ToString().Trim(); //SysParaName
objTSysPara_JTEN.SysParaValue = objRow[conTSysPara_JT.SysParaValue].ToString().Trim(); //SysParaValue
objTSysPara_JTEN.IdSchool = objRow[conTSysPara_JT.IdSchool] == DBNull.Value ? null : objRow[conTSysPara_JT.IdSchool].ToString().Trim(); //学校流水号
objTSysPara_JTEN.SchoolId = objRow[conTSysPara_JT.SchoolId] == DBNull.Value ? null : objRow[conTSysPara_JT.SchoolId].ToString().Trim(); //学校编号
objTSysPara_JTEN.ModifyDate = objRow[conTSysPara_JT.ModifyDate] == DBNull.Value ? null : objRow[conTSysPara_JT.ModifyDate].ToString().Trim(); //修改日期
objTSysPara_JTEN.ModifyUser = objRow[conTSysPara_JT.ModifyUser] == DBNull.Value ? null : objRow[conTSysPara_JT.ModifyUser].ToString().Trim(); //ModifyUser
objTSysPara_JTEN.Memo = objRow[conTSysPara_JT.Memo] == DBNull.Value ? null : objRow[conTSysPara_JT.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objTSysPara_JTEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objTSysPara_JTEN);
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
public static List<clsTSysPara_JTEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsTSysPara_JTEN> arrObjLst = new List<clsTSysPara_JTEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsTSysPara_JTEN objTSysPara_JTEN = new clsTSysPara_JTEN();
try
{
objTSysPara_JTEN.mId = Int32.Parse(objRow[conTSysPara_JT.mId].ToString().Trim()); //mId
objTSysPara_JTEN.SysParaName = objRow[conTSysPara_JT.SysParaName].ToString().Trim(); //SysParaName
objTSysPara_JTEN.SysParaValue = objRow[conTSysPara_JT.SysParaValue].ToString().Trim(); //SysParaValue
objTSysPara_JTEN.IdSchool = objRow[conTSysPara_JT.IdSchool] == DBNull.Value ? null : objRow[conTSysPara_JT.IdSchool].ToString().Trim(); //学校流水号
objTSysPara_JTEN.SchoolId = objRow[conTSysPara_JT.SchoolId] == DBNull.Value ? null : objRow[conTSysPara_JT.SchoolId].ToString().Trim(); //学校编号
objTSysPara_JTEN.ModifyDate = objRow[conTSysPara_JT.ModifyDate] == DBNull.Value ? null : objRow[conTSysPara_JT.ModifyDate].ToString().Trim(); //修改日期
objTSysPara_JTEN.ModifyUser = objRow[conTSysPara_JT.ModifyUser] == DBNull.Value ? null : objRow[conTSysPara_JT.ModifyUser].ToString().Trim(); //ModifyUser
objTSysPara_JTEN.Memo = objRow[conTSysPara_JT.Memo] == DBNull.Value ? null : objRow[conTSysPara_JT.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objTSysPara_JTEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objTSysPara_JTEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsTSysPara_JTEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsTSysPara_JTEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsTSysPara_JTEN> arrObjLst = new List<clsTSysPara_JTEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsTSysPara_JTEN objTSysPara_JTEN = new clsTSysPara_JTEN();
try
{
objTSysPara_JTEN.mId = Int32.Parse(objRow[conTSysPara_JT.mId].ToString().Trim()); //mId
objTSysPara_JTEN.SysParaName = objRow[conTSysPara_JT.SysParaName].ToString().Trim(); //SysParaName
objTSysPara_JTEN.SysParaValue = objRow[conTSysPara_JT.SysParaValue].ToString().Trim(); //SysParaValue
objTSysPara_JTEN.IdSchool = objRow[conTSysPara_JT.IdSchool] == DBNull.Value ? null : objRow[conTSysPara_JT.IdSchool].ToString().Trim(); //学校流水号
objTSysPara_JTEN.SchoolId = objRow[conTSysPara_JT.SchoolId] == DBNull.Value ? null : objRow[conTSysPara_JT.SchoolId].ToString().Trim(); //学校编号
objTSysPara_JTEN.ModifyDate = objRow[conTSysPara_JT.ModifyDate] == DBNull.Value ? null : objRow[conTSysPara_JT.ModifyDate].ToString().Trim(); //修改日期
objTSysPara_JTEN.ModifyUser = objRow[conTSysPara_JT.ModifyUser] == DBNull.Value ? null : objRow[conTSysPara_JT.ModifyUser].ToString().Trim(); //ModifyUser
objTSysPara_JTEN.Memo = objRow[conTSysPara_JT.Memo] == DBNull.Value ? null : objRow[conTSysPara_JT.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objTSysPara_JTEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objTSysPara_JTEN);
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
public static List<clsTSysPara_JTEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsTSysPara_JTEN> arrObjLst = new List<clsTSysPara_JTEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsTSysPara_JTEN objTSysPara_JTEN = new clsTSysPara_JTEN();
try
{
objTSysPara_JTEN.mId = Int32.Parse(objRow[conTSysPara_JT.mId].ToString().Trim()); //mId
objTSysPara_JTEN.SysParaName = objRow[conTSysPara_JT.SysParaName].ToString().Trim(); //SysParaName
objTSysPara_JTEN.SysParaValue = objRow[conTSysPara_JT.SysParaValue].ToString().Trim(); //SysParaValue
objTSysPara_JTEN.IdSchool = objRow[conTSysPara_JT.IdSchool] == DBNull.Value ? null : objRow[conTSysPara_JT.IdSchool].ToString().Trim(); //学校流水号
objTSysPara_JTEN.SchoolId = objRow[conTSysPara_JT.SchoolId] == DBNull.Value ? null : objRow[conTSysPara_JT.SchoolId].ToString().Trim(); //学校编号
objTSysPara_JTEN.ModifyDate = objRow[conTSysPara_JT.ModifyDate] == DBNull.Value ? null : objRow[conTSysPara_JT.ModifyDate].ToString().Trim(); //修改日期
objTSysPara_JTEN.ModifyUser = objRow[conTSysPara_JT.ModifyUser] == DBNull.Value ? null : objRow[conTSysPara_JT.ModifyUser].ToString().Trim(); //ModifyUser
objTSysPara_JTEN.Memo = objRow[conTSysPara_JT.Memo] == DBNull.Value ? null : objRow[conTSysPara_JT.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objTSysPara_JTEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objTSysPara_JTEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsTSysPara_JTEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsTSysPara_JTEN> arrObjLst = new List<clsTSysPara_JTEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsTSysPara_JTEN objTSysPara_JTEN = new clsTSysPara_JTEN();
try
{
objTSysPara_JTEN.mId = Int32.Parse(objRow[conTSysPara_JT.mId].ToString().Trim()); //mId
objTSysPara_JTEN.SysParaName = objRow[conTSysPara_JT.SysParaName].ToString().Trim(); //SysParaName
objTSysPara_JTEN.SysParaValue = objRow[conTSysPara_JT.SysParaValue].ToString().Trim(); //SysParaValue
objTSysPara_JTEN.IdSchool = objRow[conTSysPara_JT.IdSchool] == DBNull.Value ? null : objRow[conTSysPara_JT.IdSchool].ToString().Trim(); //学校流水号
objTSysPara_JTEN.SchoolId = objRow[conTSysPara_JT.SchoolId] == DBNull.Value ? null : objRow[conTSysPara_JT.SchoolId].ToString().Trim(); //学校编号
objTSysPara_JTEN.ModifyDate = objRow[conTSysPara_JT.ModifyDate] == DBNull.Value ? null : objRow[conTSysPara_JT.ModifyDate].ToString().Trim(); //修改日期
objTSysPara_JTEN.ModifyUser = objRow[conTSysPara_JT.ModifyUser] == DBNull.Value ? null : objRow[conTSysPara_JT.ModifyUser].ToString().Trim(); //ModifyUser
objTSysPara_JTEN.Memo = objRow[conTSysPara_JT.Memo] == DBNull.Value ? null : objRow[conTSysPara_JT.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objTSysPara_JTEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objTSysPara_JTEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objTSysPara_JTEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetTSysPara_JT(ref clsTSysPara_JTEN objTSysPara_JTEN)
{
bool bolResult = TSysPara_JTDA.GetTSysPara_JT(ref objTSysPara_JTEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public static clsTSysPara_JTEN GetObjBymId(long lngmId)
{
clsTSysPara_JTEN objTSysPara_JTEN = TSysPara_JTDA.GetObjBymId(lngmId);
return objTSysPara_JTEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsTSysPara_JTEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsTSysPara_JTEN objTSysPara_JTEN = TSysPara_JTDA.GetFirstObj(strWhereCond);
 return objTSysPara_JTEN;
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
public static clsTSysPara_JTEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsTSysPara_JTEN objTSysPara_JTEN = TSysPara_JTDA.GetObjByDataRow(objRow);
 return objTSysPara_JTEN;
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
public static clsTSysPara_JTEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsTSysPara_JTEN objTSysPara_JTEN = TSysPara_JTDA.GetObjByDataRow(objRow);
 return objTSysPara_JTEN;
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
 /// <param name = "lstTSysPara_JTObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsTSysPara_JTEN GetObjBymIdFromList(long lngmId, List<clsTSysPara_JTEN> lstTSysPara_JTObjLst)
{
foreach (clsTSysPara_JTEN objTSysPara_JTEN in lstTSysPara_JTObjLst)
{
if (objTSysPara_JTEN.mId == lngmId)
{
return objTSysPara_JTEN;
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
 lngmId = new clsTSysPara_JTDA().GetFirstID(strWhereCond);
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
 arrList = TSysPara_JTDA.GetID(strWhereCond);
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
bool bolIsExist = TSysPara_JTDA.IsExistCondRec(strWhereCond);
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
bool bolIsExist = TSysPara_JTDA.IsExist(lngmId);
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
 bolIsExist = clsTSysPara_JTDA.IsExistTable();
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
 bolIsExist = TSysPara_JTDA.IsExistTable(strTabName);
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
 /// <param name = "objTSysPara_JTEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecordBySql2(clsTSysPara_JTEN objTSysPara_JTEN)
{
try
{
bool bolResult = TSysPara_JTDA.AddNewRecordBySQL2(objTSysPara_JTEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsTSysPara_JTBL.ReFreshCache();

if (clsTSysPara_JTBL.relatedActions != null)
{
clsTSysPara_JTBL.relatedActions.UpdRelaTabDate(objTSysPara_JTEN.mId, "SetUpdDate");
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
 /// <param name = "objTSysPara_JTEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordBySql2WithReturnKey(clsTSysPara_JTEN objTSysPara_JTEN)
{
try
{
string strKey = TSysPara_JTDA.AddNewRecordBySQL2WithReturnKey(objTSysPara_JTEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsTSysPara_JTBL.ReFreshCache();

if (clsTSysPara_JTBL.relatedActions != null)
{
clsTSysPara_JTBL.relatedActions.UpdRelaTabDate(objTSysPara_JTEN.mId, "SetUpdDate");
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
 /// <param name = "objTSysPara_JTEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(clsTSysPara_JTEN objTSysPara_JTEN)
{
try
{
bool bolResult = TSysPara_JTDA.Update(objTSysPara_JTEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsTSysPara_JTBL.ReFreshCache();

if (clsTSysPara_JTBL.relatedActions != null)
{
clsTSysPara_JTBL.relatedActions.UpdRelaTabDate(objTSysPara_JTEN.mId, "SetUpdDate");
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
 /// <param name = "objTSysPara_JTEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateBySql2(clsTSysPara_JTEN objTSysPara_JTEN)
{
 if (objTSysPara_JTEN.mId == 0)
 {
var strMsg = string.Format("(errid:Busi000065)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = TSysPara_JTDA.UpdateBySql2(objTSysPara_JTEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsTSysPara_JTBL.ReFreshCache();

if (clsTSysPara_JTBL.relatedActions != null)
{
clsTSysPara_JTBL.relatedActions.UpdRelaTabDate(objTSysPara_JTEN.mId, "SetUpdDate");
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
 clsTSysPara_JTEN objTSysPara_JTEN = clsTSysPara_JTBL.GetObjBymId(lngmId);

if (clsTSysPara_JTBL.relatedActions != null)
{
clsTSysPara_JTBL.relatedActions.UpdRelaTabDate(objTSysPara_JTEN.mId, "SetUpdDate");
}
if (objTSysPara_JTEN != null)
{
int intRecNum = TSysPara_JTDA.DelRecord(lngmId);
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
objSQL = clsTSysPara_JTDA.GetSpecSQLObj();
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
//删除与表:[TSysPara_JT]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conTSysPara_JT.mId,
//lngmId);
//        clsTSysPara_JTBL.DelTSysPara_JTsByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsTSysPara_JTBL.DelRecord(lngmId, objConnection, objSqlTransaction);
objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsTSysPara_JTBLEx", "DelRecordEx", objException.Message, clsSysParaEN.strUserId);
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
if (clsTSysPara_JTBL.relatedActions != null)
{
clsTSysPara_JTBL.relatedActions.UpdRelaTabDate(lngmId, "UpdRelaTabDate");
}
bool bolResult = TSysPara_JTDA.DelRecord(lngmId,objSqlConnection,objSqlTransaction);
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
public static int DelTSysPara_JTs(List<string> arrmIdLst)
{
if (arrmIdLst.Count == 0) return 0;
try
{
if (clsTSysPara_JTBL.relatedActions != null)
{
foreach (var strmId in arrmIdLst)
{
long lngmId = long.Parse(strmId);
clsTSysPara_JTBL.relatedActions.UpdRelaTabDate(lngmId, "UpdRelaTabDate");
}
}
int intDelRecNum = TSysPara_JTDA.DelTSysPara_JT(arrmIdLst);
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
public static int DelTSysPara_JTsByCond(string strWhereCond)
{
try
{
if (clsTSysPara_JTBL.relatedActions != null)
{
List<string> arrmId = GetPrimaryKeyID_S(strWhereCond);
foreach (var strmId in arrmId)
{
long lngmId = long.Parse(strmId);
clsTSysPara_JTBL.relatedActions.UpdRelaTabDate(lngmId, "UpdRelaTabDate");
}
}
int intRecNum = TSysPara_JTDA.DelTSysPara_JT(strWhereCond);
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
/// 这里仅仅是演示函数,使用时请复制到扩展类:[TSysPara_JT]中改名为:[DelRecord4MultiTabEx]使用
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DelRecord4MultiTab)
/// </summary>
/// <param name="lngmId">表关键字</param>
/// <returns></returns>
public static bool DelRecord4MultiTab(long lngmId)
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsTSysPara_JTDA.GetSpecSQLObj();
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
//删除与表:[TSysPara_JT]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conStudent.id_College,
//strid_College);
//        clsStudentBL.DelStudentsByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsTSysPara_JTBL.DelRecord(lngmId, objConnection, objSqlTransaction);
                objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsTSysPara_JTBL", "DelRecord4MultiTab", objException.Message, clsSysParaEN.strUserId);
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
 /// <param name = "objTSysPara_JTENS">源对象</param>
 /// <param name = "objTSysPara_JTENT">目标对象</param>
 public static void CopyTo(clsTSysPara_JTEN objTSysPara_JTENS, clsTSysPara_JTEN objTSysPara_JTENT)
{
try
{
objTSysPara_JTENT.mId = objTSysPara_JTENS.mId; //mId
objTSysPara_JTENT.SysParaName = objTSysPara_JTENS.SysParaName; //SysParaName
objTSysPara_JTENT.SysParaValue = objTSysPara_JTENS.SysParaValue; //SysParaValue
objTSysPara_JTENT.IdSchool = objTSysPara_JTENS.IdSchool; //学校流水号
objTSysPara_JTENT.SchoolId = objTSysPara_JTENS.SchoolId; //学校编号
objTSysPara_JTENT.ModifyDate = objTSysPara_JTENS.ModifyDate; //修改日期
objTSysPara_JTENT.ModifyUser = objTSysPara_JTENS.ModifyUser; //ModifyUser
objTSysPara_JTENT.Memo = objTSysPara_JTENS.Memo; //备注
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
 /// <param name = "objTSysPara_JTEN">源简化对象</param>
 public static void SetUpdFlag(clsTSysPara_JTEN objTSysPara_JTEN)
{
try
{
objTSysPara_JTEN.ClearUpdateState();
   string strsfUpdFldSetStr = objTSysPara_JTEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(conTSysPara_JT.mId, new clsStrCompareIgnoreCase())  ==  true)
{
objTSysPara_JTEN.mId = objTSysPara_JTEN.mId; //mId
}
if (arrFldSet.Contains(conTSysPara_JT.SysParaName, new clsStrCompareIgnoreCase())  ==  true)
{
objTSysPara_JTEN.SysParaName = objTSysPara_JTEN.SysParaName; //SysParaName
}
if (arrFldSet.Contains(conTSysPara_JT.SysParaValue, new clsStrCompareIgnoreCase())  ==  true)
{
objTSysPara_JTEN.SysParaValue = objTSysPara_JTEN.SysParaValue; //SysParaValue
}
if (arrFldSet.Contains(conTSysPara_JT.IdSchool, new clsStrCompareIgnoreCase())  ==  true)
{
objTSysPara_JTEN.IdSchool = objTSysPara_JTEN.IdSchool == "[null]" ? null :  objTSysPara_JTEN.IdSchool; //学校流水号
}
if (arrFldSet.Contains(conTSysPara_JT.SchoolId, new clsStrCompareIgnoreCase())  ==  true)
{
objTSysPara_JTEN.SchoolId = objTSysPara_JTEN.SchoolId == "[null]" ? null :  objTSysPara_JTEN.SchoolId; //学校编号
}
if (arrFldSet.Contains(conTSysPara_JT.ModifyDate, new clsStrCompareIgnoreCase())  ==  true)
{
objTSysPara_JTEN.ModifyDate = objTSysPara_JTEN.ModifyDate == "[null]" ? null :  objTSysPara_JTEN.ModifyDate; //修改日期
}
if (arrFldSet.Contains(conTSysPara_JT.ModifyUser, new clsStrCompareIgnoreCase())  ==  true)
{
objTSysPara_JTEN.ModifyUser = objTSysPara_JTEN.ModifyUser == "[null]" ? null :  objTSysPara_JTEN.ModifyUser; //ModifyUser
}
if (arrFldSet.Contains(conTSysPara_JT.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objTSysPara_JTEN.Memo = objTSysPara_JTEN.Memo == "[null]" ? null :  objTSysPara_JTEN.Memo; //备注
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
 /// <param name = "objTSysPara_JTEN">源简化对象</param>
 public static void AccessFldValueNull(clsTSysPara_JTEN objTSysPara_JTEN)
{
try
{
if (objTSysPara_JTEN.IdSchool == "[null]") objTSysPara_JTEN.IdSchool = null; //学校流水号
if (objTSysPara_JTEN.SchoolId == "[null]") objTSysPara_JTEN.SchoolId = null; //学校编号
if (objTSysPara_JTEN.ModifyDate == "[null]") objTSysPara_JTEN.ModifyDate = null; //修改日期
if (objTSysPara_JTEN.ModifyUser == "[null]") objTSysPara_JTEN.ModifyUser = null; //ModifyUser
if (objTSysPara_JTEN.Memo == "[null]") objTSysPara_JTEN.Memo = null; //备注
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
public static void CheckPropertyNew(clsTSysPara_JTEN objTSysPara_JTEN)
{
 TSysPara_JTDA.CheckPropertyNew(objTSysPara_JTEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(clsTSysPara_JTEN objTSysPara_JTEN)
{
 TSysPara_JTDA.CheckProperty4Condition(objTSysPara_JTEN);
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
if (clsTSysPara_JTBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsTSysPara_JTBL没有刷新缓存机制(clsTSysPara_JTBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by mId");
//if (arrTSysPara_JTObjLstCache == null)
//{
//arrTSysPara_JTObjLstCache = TSysPara_JTDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "lngmId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsTSysPara_JTEN GetObjBymIdCache(long lngmId)
{
//获取缓存中的对象列表
string strKey = string.Format("{0}", clsTSysPara_JTEN._CurrTabName);
List<clsTSysPara_JTEN> arrTSysPara_JTObjLstCache = GetObjLstCache();
IEnumerable <clsTSysPara_JTEN> arrTSysPara_JTObjLst_Sel =
arrTSysPara_JTObjLstCache
.Where(x=> x.mId == lngmId 
);
if (arrTSysPara_JTObjLst_Sel.Count() == 0)
{
   clsTSysPara_JTEN obj = clsTSysPara_JTBL.GetObjBymId(lngmId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
 }
return null;
}
return arrTSysPara_JTObjLst_Sel.First();
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsTSysPara_JTEN> GetAllTSysPara_JTObjLstCache()
{
//获取缓存中的对象列表
List<clsTSysPara_JTEN> arrTSysPara_JTObjLstCache = GetObjLstCache(); 
return arrTSysPara_JTObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsTSysPara_JTEN> GetObjLstCache()
{
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}", clsTSysPara_JTEN._CurrTabName);
List<clsTSysPara_JTEN> arrTSysPara_JTObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrTSysPara_JTObjLstCache;
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
string strKey = string.Format("{0}", clsTSysPara_JTEN._CurrTabName);
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
if (clsTSysPara_JTBL.objCommFun4BL != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}", clsTSysPara_JTEN._CurrTabName);
CacheHelper.Remove(strKey);
clsTSysPara_JTBL.objCommFun4BL.ReFreshCache();
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
if (strInFldName != conTSysPara_JT.mId)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (conTSysPara_JT.AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", conTSysPara_JT.AttributeName));
throw new Exception(strMsg);
}
var objTSysPara_JT = clsTSysPara_JTBL.GetObjBymIdCache(lngmId);
if (objTSysPara_JT == null) return "";
return objTSysPara_JT[strOutFldName].ToString();
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
int intRecCount = clsTSysPara_JTDA.GetRecCount(strTabName);
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
int intRecCount = clsTSysPara_JTDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsTSysPara_JTDA.GetRecCount();
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
int intRecCount = clsTSysPara_JTDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objTSysPara_JTCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsTSysPara_JTEN objTSysPara_JTCond)
{
List<clsTSysPara_JTEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsTSysPara_JTEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conTSysPara_JT.AttributeName)
{
if (objTSysPara_JTCond.IsUpdated(strFldName) == false) continue;
if (objTSysPara_JTCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objTSysPara_JTCond[strFldName].ToString());
}
else
{
if (objTSysPara_JTCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objTSysPara_JTCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objTSysPara_JTCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objTSysPara_JTCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objTSysPara_JTCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objTSysPara_JTCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objTSysPara_JTCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objTSysPara_JTCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objTSysPara_JTCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objTSysPara_JTCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objTSysPara_JTCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objTSysPara_JTCond[strFldName]));
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
 List<string> arrList = clsTSysPara_JTDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = TSysPara_JTDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = TSysPara_JTDA.GetFldValueNoDistinct(strFldName, strWhereCond);
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
int intRecCount = TSysPara_JTDA.SetFldValue(strFldName, strValue, strWhereCond);
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
int intRecCount = clsTSysPara_JTDA.SetFldValue(clsTSysPara_JTEN._CurrTabName, strFldName, fltValue, strWhereCond);
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
int intRecCount = TSysPara_JTDA.SetFldValue( strFldName, intValue, strWhereCond);
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
int intRecCount = clsTSysPara_JTDA.SetFldValue(strTabName, strFldName, strValue, strWhereCond);
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
int intRecCount = clsTSysPara_JTDA.SetFldValue(strTabName, strFldName, intValue, strWhereCond);
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
int intRecCount = clsTSysPara_JTDA.SetFldValue(strTabName, strFldName, fltValue, strWhereCond);
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
  strCreateTabCode.Append("CREATE table [dbo].[TSysPara_JT] "); 
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
 /// TSysPara_JT(TSysPara_JT)
 /// 数据源类型:表
 /// (AutoGCLib.CommFun4BL4CSharp:GeneCode_This)
 /// </summary>
public class  clsCommFun4BL4TSysPara_JT : clsCommFun4BL
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
clsTSysPara_JTBL.ReFreshThisCache();
}
}

}