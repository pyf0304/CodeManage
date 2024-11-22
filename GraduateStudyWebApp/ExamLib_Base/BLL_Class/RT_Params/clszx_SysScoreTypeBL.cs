
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clszx_SysScoreTypeBL
 表名:zx_SysScoreType(01120825)
 * 版本:2023.11.15.1(服务器:WIN-SRV103-116)
 日期:2023/11/15 22:55:00
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:研究生学习游戏化后台(变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:研培参数(RT_Params)
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
public static class  clszx_SysScoreTypeBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "strzxScoreTypeId">表关键字</param>
 /// <returns>表对象</returns>
public static clszx_SysScoreTypeEN GetObj(this K_zxScoreTypeId_zx_SysScoreType myKey)
{
clszx_SysScoreTypeEN objzx_SysScoreTypeEN = clszx_SysScoreTypeBL.zx_SysScoreTypeDA.GetObjByzxScoreTypeId(myKey.Value);
return objzx_SysScoreTypeEN;
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_AddNewRecord)
 /// </summary>
 /// <param name = "objzx_SysScoreTypeEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clszx_SysScoreTypeEN objzx_SysScoreTypeEN)
{
 if (string.IsNullOrEmpty(objzx_SysScoreTypeEN.zxScoreTypeId) == true)
 {
string strMsg = string.Format("添加记录时,关键字不能为空!(from {0})\r\n", 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
 if (clszx_SysScoreTypeBL.IsExist(objzx_SysScoreTypeEN.zxScoreTypeId) == true)
 {
string strMsg = string.Format("添加记录时,关键字:[{0}]已经存在!(from {1})\r\n", objzx_SysScoreTypeEN.zxScoreTypeId, 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
try
{
bool bolResult = clszx_SysScoreTypeBL.zx_SysScoreTypeDA.AddNewRecordBySQL2(objzx_SysScoreTypeEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clszx_SysScoreTypeBL.ReFreshCache();

if (clszx_SysScoreTypeBL.relatedActions != null)
{
clszx_SysScoreTypeBL.relatedActions.UpdRelaTabDate(objzx_SysScoreTypeEN.zxScoreTypeId, "SetUpdDate");
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
public static bool AddRecordEx(this clszx_SysScoreTypeEN objzx_SysScoreTypeEN)
{
//操作步骤:
//1、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在
//2、检查唯一性
//3、检查传进去的对象属性是否合法
//4、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
//1、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在
if (clszx_SysScoreTypeBL.IsExist(objzx_SysScoreTypeEN.zxScoreTypeId))	//判断是否有相同的关键字
{
strMsg = "(errid:Busi000151)关键字字段已有相同的值";
throw new Exception(strMsg);
}
try
{
 //2、检查传进去的对象属性是否合法
objzx_SysScoreTypeEN.CheckPropertyNew();
//6、把数据实体层的数据存贮到数据库中
objzx_SysScoreTypeEN.AddNewRecord();
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
 /// <param name = "objzx_SysScoreTypeEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordWithReturnKey(this clszx_SysScoreTypeEN objzx_SysScoreTypeEN)
{
 if (string.IsNullOrEmpty(objzx_SysScoreTypeEN.zxScoreTypeId) == true)
 {
string strMsg = string.Format("添加记录时,关键字不能为空!(from {{0}})", 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
 if (clszx_SysScoreTypeBL.IsExist(objzx_SysScoreTypeEN.zxScoreTypeId) == true)
 {
string strMsg = string.Format("添加记录时,关键字:[{0}]已经存在!(from {1})\r\n", objzx_SysScoreTypeEN.zxScoreTypeId, 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
try
{
string strKey = clszx_SysScoreTypeBL.zx_SysScoreTypeDA.AddNewRecordBySQL2WithReturnKey(objzx_SysScoreTypeEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clszx_SysScoreTypeBL.ReFreshCache();

if (clszx_SysScoreTypeBL.relatedActions != null)
{
clszx_SysScoreTypeBL.relatedActions.UpdRelaTabDate(objzx_SysScoreTypeEN.zxScoreTypeId, "SetUpdDate");
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
 /// <param name = "objzx_SysScoreTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clszx_SysScoreTypeEN SetzxScoreTypeId(this clszx_SysScoreTypeEN objzx_SysScoreTypeEN, string strzxScoreTypeId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strzxScoreTypeId, 4, conzx_SysScoreType.zxScoreTypeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strzxScoreTypeId, 4, conzx_SysScoreType.zxScoreTypeId);
}
objzx_SysScoreTypeEN.zxScoreTypeId = strzxScoreTypeId; //分数类型Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objzx_SysScoreTypeEN.dicFldComparisonOp.ContainsKey(conzx_SysScoreType.zxScoreTypeId) == false)
{
objzx_SysScoreTypeEN.dicFldComparisonOp.Add(conzx_SysScoreType.zxScoreTypeId, strComparisonOp);
}
else
{
objzx_SysScoreTypeEN.dicFldComparisonOp[conzx_SysScoreType.zxScoreTypeId] = strComparisonOp;
}
}
return objzx_SysScoreTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objzx_SysScoreTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clszx_SysScoreTypeEN SetScoreTypeName(this clszx_SysScoreTypeEN objzx_SysScoreTypeEN, string strScoreTypeName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strScoreTypeName, 10, conzx_SysScoreType.ScoreTypeName);
}
objzx_SysScoreTypeEN.ScoreTypeName = strScoreTypeName; //分数类型名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objzx_SysScoreTypeEN.dicFldComparisonOp.ContainsKey(conzx_SysScoreType.ScoreTypeName) == false)
{
objzx_SysScoreTypeEN.dicFldComparisonOp.Add(conzx_SysScoreType.ScoreTypeName, strComparisonOp);
}
else
{
objzx_SysScoreTypeEN.dicFldComparisonOp[conzx_SysScoreType.ScoreTypeName] = strComparisonOp;
}
}
return objzx_SysScoreTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objzx_SysScoreTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clszx_SysScoreTypeEN SetOnlyId(this clszx_SysScoreTypeEN objzx_SysScoreTypeEN, string strOnlyId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strOnlyId, 20, conzx_SysScoreType.OnlyId);
}
objzx_SysScoreTypeEN.OnlyId = strOnlyId; //OnlyId
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objzx_SysScoreTypeEN.dicFldComparisonOp.ContainsKey(conzx_SysScoreType.OnlyId) == false)
{
objzx_SysScoreTypeEN.dicFldComparisonOp.Add(conzx_SysScoreType.OnlyId, strComparisonOp);
}
else
{
objzx_SysScoreTypeEN.dicFldComparisonOp[conzx_SysScoreType.OnlyId] = strComparisonOp;
}
}
return objzx_SysScoreTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objzx_SysScoreTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clszx_SysScoreTypeEN SetUpdUser(this clszx_SysScoreTypeEN objzx_SysScoreTypeEN, string strUpdUser, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdUser, 20, conzx_SysScoreType.UpdUser);
}
objzx_SysScoreTypeEN.UpdUser = strUpdUser; //修改人
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objzx_SysScoreTypeEN.dicFldComparisonOp.ContainsKey(conzx_SysScoreType.UpdUser) == false)
{
objzx_SysScoreTypeEN.dicFldComparisonOp.Add(conzx_SysScoreType.UpdUser, strComparisonOp);
}
else
{
objzx_SysScoreTypeEN.dicFldComparisonOp[conzx_SysScoreType.UpdUser] = strComparisonOp;
}
}
return objzx_SysScoreTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objzx_SysScoreTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clszx_SysScoreTypeEN SetUpdDate(this clszx_SysScoreTypeEN objzx_SysScoreTypeEN, string strUpdDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdDate, 20, conzx_SysScoreType.UpdDate);
}
objzx_SysScoreTypeEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objzx_SysScoreTypeEN.dicFldComparisonOp.ContainsKey(conzx_SysScoreType.UpdDate) == false)
{
objzx_SysScoreTypeEN.dicFldComparisonOp.Add(conzx_SysScoreType.UpdDate, strComparisonOp);
}
else
{
objzx_SysScoreTypeEN.dicFldComparisonOp[conzx_SysScoreType.UpdDate] = strComparisonOp;
}
}
return objzx_SysScoreTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objzx_SysScoreTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clszx_SysScoreTypeEN SetMemo(this clszx_SysScoreTypeEN objzx_SysScoreTypeEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, conzx_SysScoreType.Memo);
}
objzx_SysScoreTypeEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objzx_SysScoreTypeEN.dicFldComparisonOp.ContainsKey(conzx_SysScoreType.Memo) == false)
{
objzx_SysScoreTypeEN.dicFldComparisonOp.Add(conzx_SysScoreType.Memo, strComparisonOp);
}
else
{
objzx_SysScoreTypeEN.dicFldComparisonOp[conzx_SysScoreType.Memo] = strComparisonOp;
}
}
return objzx_SysScoreTypeEN;
	}

 /// <summary>
 /// 修改记录存盘到数据表中
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_UpdateRecordEx)
 /// </summary>
 /// <param name = "objzx_SysScoreTypeEN">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool UpdateRecordEx(this clszx_SysScoreTypeEN objzx_SysScoreTypeEN)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
try
{
//1、检查传进去的对象属性是否合法
objzx_SysScoreTypeEN.CheckPropertyNew();
clszx_SysScoreTypeEN objzx_SysScoreTypeCond = new clszx_SysScoreTypeEN();
string strCondition = objzx_SysScoreTypeCond
.SetzxScoreTypeId(objzx_SysScoreTypeEN.zxScoreTypeId, "=")
.GetCombineCondition();
objzx_SysScoreTypeEN._IsCheckProperty = true;
bool bolIsExist = clszx_SysScoreTypeBL.IsExistRecord(strCondition);
if (bolIsExist)
{
strMsg = "()不能重复!";
throw new Exception(strMsg);
}
//4、把数据实体层的数据存贮到数据库中
objzx_SysScoreTypeEN.Update();
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
 /// <param name = "objzx_SysScoreTypeEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clszx_SysScoreTypeEN objzx_SysScoreTypeEN)
{
 if (string.IsNullOrEmpty(objzx_SysScoreTypeEN.zxScoreTypeId) == true)
 {
string strMsg = string.Format("(errid:Busi000095)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clszx_SysScoreTypeBL.zx_SysScoreTypeDA.UpdateBySql2(objzx_SysScoreTypeEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clszx_SysScoreTypeBL.ReFreshCache();

if (clszx_SysScoreTypeBL.relatedActions != null)
{
clszx_SysScoreTypeBL.relatedActions.UpdRelaTabDate(objzx_SysScoreTypeEN.zxScoreTypeId, "SetUpdDate");
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
 /// <param name = "objzx_SysScoreTypeEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clszx_SysScoreTypeEN objzx_SysScoreTypeEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (string.IsNullOrEmpty(objzx_SysScoreTypeEN.zxScoreTypeId) == true)
 {
string strMsg = string.Format("(errid:Busi000087)修改记录时关键字不能为空!(带事务处理)(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clszx_SysScoreTypeBL.zx_SysScoreTypeDA.UpdateBySql2(objzx_SysScoreTypeEN, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clszx_SysScoreTypeBL.ReFreshCache();

if (clszx_SysScoreTypeBL.relatedActions != null)
{
clszx_SysScoreTypeBL.relatedActions.UpdRelaTabDate(objzx_SysScoreTypeEN.zxScoreTypeId, "SetUpdDate");
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
 /// <param name = "objzx_SysScoreTypeEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clszx_SysScoreTypeEN objzx_SysScoreTypeEN, string strWhereCond)
{
try
{
bool bolResult = clszx_SysScoreTypeBL.zx_SysScoreTypeDA.UpdateBySqlWithCondition(objzx_SysScoreTypeEN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clszx_SysScoreTypeBL.ReFreshCache();

if (clszx_SysScoreTypeBL.relatedActions != null)
{
clszx_SysScoreTypeBL.relatedActions.UpdRelaTabDate(objzx_SysScoreTypeEN.zxScoreTypeId, "SetUpdDate");
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
 /// <param name = "objzx_SysScoreTypeEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clszx_SysScoreTypeEN objzx_SysScoreTypeEN, string strWhereCond, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
bool bolResult = clszx_SysScoreTypeBL.zx_SysScoreTypeDA.UpdateBySqlWithConditionTransaction(objzx_SysScoreTypeEN, strWhereCond, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clszx_SysScoreTypeBL.ReFreshCache();

if (clszx_SysScoreTypeBL.relatedActions != null)
{
clszx_SysScoreTypeBL.relatedActions.UpdRelaTabDate(objzx_SysScoreTypeEN.zxScoreTypeId, "SetUpdDate");
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
 /// <param name = "strzxScoreTypeId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int Delete(this clszx_SysScoreTypeEN objzx_SysScoreTypeEN)
{
try
{
int intRecNum = clszx_SysScoreTypeBL.zx_SysScoreTypeDA.DelRecord(objzx_SysScoreTypeEN.zxScoreTypeId);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clszx_SysScoreTypeBL.ReFreshCache();

if (clszx_SysScoreTypeBL.relatedActions != null)
{
clszx_SysScoreTypeBL.relatedActions.UpdRelaTabDate(objzx_SysScoreTypeEN.zxScoreTypeId, "SetUpdDate");
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
 /// <param name = "objzx_SysScoreTypeENS">源对象</param>
 /// <param name = "objzx_SysScoreTypeENT">目标对象</param>
 public static void CopyTo(this clszx_SysScoreTypeEN objzx_SysScoreTypeENS, clszx_SysScoreTypeEN objzx_SysScoreTypeENT)
{
try
{
objzx_SysScoreTypeENT.zxScoreTypeId = objzx_SysScoreTypeENS.zxScoreTypeId; //分数类型Id
objzx_SysScoreTypeENT.ScoreTypeName = objzx_SysScoreTypeENS.ScoreTypeName; //分数类型名称
objzx_SysScoreTypeENT.OnlyId = objzx_SysScoreTypeENS.OnlyId; //OnlyId
objzx_SysScoreTypeENT.UpdUser = objzx_SysScoreTypeENS.UpdUser; //修改人
objzx_SysScoreTypeENT.UpdDate = objzx_SysScoreTypeENS.UpdDate; //修改日期
objzx_SysScoreTypeENT.Memo = objzx_SysScoreTypeENS.Memo; //备注
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
 /// <param name = "objzx_SysScoreTypeENS">源对象</param>
 /// <returns>目标对象=>clszx_SysScoreTypeEN:objzx_SysScoreTypeENT</returns>
 public static clszx_SysScoreTypeEN CopyTo(this clszx_SysScoreTypeEN objzx_SysScoreTypeENS)
{
try
{
 clszx_SysScoreTypeEN objzx_SysScoreTypeENT = new clszx_SysScoreTypeEN()
{
zxScoreTypeId = objzx_SysScoreTypeENS.zxScoreTypeId, //分数类型Id
ScoreTypeName = objzx_SysScoreTypeENS.ScoreTypeName, //分数类型名称
OnlyId = objzx_SysScoreTypeENS.OnlyId, //OnlyId
UpdUser = objzx_SysScoreTypeENS.UpdUser, //修改人
UpdDate = objzx_SysScoreTypeENS.UpdDate, //修改日期
Memo = objzx_SysScoreTypeENS.Memo, //备注
};
 return objzx_SysScoreTypeENT;
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
public static void CheckPropertyNew(this clszx_SysScoreTypeEN objzx_SysScoreTypeEN)
{
 clszx_SysScoreTypeBL.zx_SysScoreTypeDA.CheckPropertyNew(objzx_SysScoreTypeEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(this clszx_SysScoreTypeEN objzx_SysScoreTypeEN)
{
 clszx_SysScoreTypeBL.zx_SysScoreTypeDA.CheckProperty4Condition(objzx_SysScoreTypeEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clszx_SysScoreTypeEN objzx_SysScoreTypeCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objzx_SysScoreTypeCond.IsUpdated(conzx_SysScoreType.zxScoreTypeId) == true)
{
string strComparisonOpzxScoreTypeId = objzx_SysScoreTypeCond.dicFldComparisonOp[conzx_SysScoreType.zxScoreTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conzx_SysScoreType.zxScoreTypeId, objzx_SysScoreTypeCond.zxScoreTypeId, strComparisonOpzxScoreTypeId);
}
if (objzx_SysScoreTypeCond.IsUpdated(conzx_SysScoreType.ScoreTypeName) == true)
{
string strComparisonOpScoreTypeName = objzx_SysScoreTypeCond.dicFldComparisonOp[conzx_SysScoreType.ScoreTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", conzx_SysScoreType.ScoreTypeName, objzx_SysScoreTypeCond.ScoreTypeName, strComparisonOpScoreTypeName);
}
if (objzx_SysScoreTypeCond.IsUpdated(conzx_SysScoreType.OnlyId) == true)
{
string strComparisonOpOnlyId = objzx_SysScoreTypeCond.dicFldComparisonOp[conzx_SysScoreType.OnlyId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conzx_SysScoreType.OnlyId, objzx_SysScoreTypeCond.OnlyId, strComparisonOpOnlyId);
}
if (objzx_SysScoreTypeCond.IsUpdated(conzx_SysScoreType.UpdUser) == true)
{
string strComparisonOpUpdUser = objzx_SysScoreTypeCond.dicFldComparisonOp[conzx_SysScoreType.UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", conzx_SysScoreType.UpdUser, objzx_SysScoreTypeCond.UpdUser, strComparisonOpUpdUser);
}
if (objzx_SysScoreTypeCond.IsUpdated(conzx_SysScoreType.UpdDate) == true)
{
string strComparisonOpUpdDate = objzx_SysScoreTypeCond.dicFldComparisonOp[conzx_SysScoreType.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conzx_SysScoreType.UpdDate, objzx_SysScoreTypeCond.UpdDate, strComparisonOpUpdDate);
}
if (objzx_SysScoreTypeCond.IsUpdated(conzx_SysScoreType.Memo) == true)
{
string strComparisonOpMemo = objzx_SysScoreTypeCond.dicFldComparisonOp[conzx_SysScoreType.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", conzx_SysScoreType.Memo, objzx_SysScoreTypeCond.Memo, strComparisonOpMemo);
}
 return strWhereCond;
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_zx_SysScoreType
{
public virtual bool UpdRelaTabDate(string strzxScoreTypeId, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// 中学评分类型表(zx_SysScoreType)
 /// 数据源类型:表
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clszx_SysScoreTypeBL
{
public static RelatedActions_zx_SysScoreType relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clszx_SysScoreTypeDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clszx_SysScoreTypeDA zx_SysScoreTypeDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clszx_SysScoreTypeDA();
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
 public clszx_SysScoreTypeBL()
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
if (string.IsNullOrEmpty(clszx_SysScoreTypeEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clszx_SysScoreTypeEN._ConnectString);
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
public static DataTable GetDataTable_zx_SysScoreType(string strWhereCond)
{
DataTable objDT;
try
{
objDT = zx_SysScoreTypeDA.GetDataTable_zx_SysScoreType(strWhereCond);
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
objDT = zx_SysScoreTypeDA.GetDataTable(strWhereCond);
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
objDT = zx_SysScoreTypeDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = zx_SysScoreTypeDA.GetDataTable(strWhereCond, strTabName);
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
objDT = zx_SysScoreTypeDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = zx_SysScoreTypeDA.GetDataTable_Top(objTopPara);
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
objDT = zx_SysScoreTypeDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = zx_SysScoreTypeDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = zx_SysScoreTypeDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
 /// <param name = "arrZxScoreTypeIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static List<clszx_SysScoreTypeEN> GetObjLstByZxScoreTypeIdLst(List<string> arrZxScoreTypeIdLst)
{
List<clszx_SysScoreTypeEN> arrObjLst = new List<clszx_SysScoreTypeEN>(); 
System.Data.DataTable objDT; 
 string strSqlConditionStr = clsArray.GetSqlInStrByArray(arrZxScoreTypeIdLst, true);
 string strWhereCond = string.Format("zxScoreTypeId in ({0})", strSqlConditionStr);
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clszx_SysScoreTypeEN objzx_SysScoreTypeEN = new clszx_SysScoreTypeEN();
try
{
objzx_SysScoreTypeEN.zxScoreTypeId = objRow[conzx_SysScoreType.zxScoreTypeId].ToString().Trim(); //分数类型Id
objzx_SysScoreTypeEN.ScoreTypeName = objRow[conzx_SysScoreType.ScoreTypeName] == DBNull.Value ? null : objRow[conzx_SysScoreType.ScoreTypeName].ToString().Trim(); //分数类型名称
objzx_SysScoreTypeEN.OnlyId = objRow[conzx_SysScoreType.OnlyId] == DBNull.Value ? null : objRow[conzx_SysScoreType.OnlyId].ToString().Trim(); //OnlyId
objzx_SysScoreTypeEN.UpdUser = objRow[conzx_SysScoreType.UpdUser] == DBNull.Value ? null : objRow[conzx_SysScoreType.UpdUser].ToString().Trim(); //修改人
objzx_SysScoreTypeEN.UpdDate = objRow[conzx_SysScoreType.UpdDate] == DBNull.Value ? null : objRow[conzx_SysScoreType.UpdDate].ToString().Trim(); //修改日期
objzx_SysScoreTypeEN.Memo = objRow[conzx_SysScoreType.Memo] == DBNull.Value ? null : objRow[conzx_SysScoreType.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objzx_SysScoreTypeEN.zxScoreTypeId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objzx_SysScoreTypeEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrZxScoreTypeIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clszx_SysScoreTypeEN> GetObjLstByZxScoreTypeIdLstCache(List<string> arrZxScoreTypeIdLst)
{
string strKey = string.Format("{0}", clszx_SysScoreTypeEN._CurrTabName);
List<clszx_SysScoreTypeEN> arrzx_SysScoreTypeObjLstCache = GetObjLstCache();
IEnumerable <clszx_SysScoreTypeEN> arrzx_SysScoreTypeObjLst_Sel =
arrzx_SysScoreTypeObjLstCache
.Where(x => arrZxScoreTypeIdLst.Contains(x.zxScoreTypeId));
return arrzx_SysScoreTypeObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clszx_SysScoreTypeEN> GetObjLst(string strWhereCond)
{
List<clszx_SysScoreTypeEN> arrObjLst = new List<clszx_SysScoreTypeEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clszx_SysScoreTypeEN objzx_SysScoreTypeEN = new clszx_SysScoreTypeEN();
try
{
objzx_SysScoreTypeEN.zxScoreTypeId = objRow[conzx_SysScoreType.zxScoreTypeId].ToString().Trim(); //分数类型Id
objzx_SysScoreTypeEN.ScoreTypeName = objRow[conzx_SysScoreType.ScoreTypeName] == DBNull.Value ? null : objRow[conzx_SysScoreType.ScoreTypeName].ToString().Trim(); //分数类型名称
objzx_SysScoreTypeEN.OnlyId = objRow[conzx_SysScoreType.OnlyId] == DBNull.Value ? null : objRow[conzx_SysScoreType.OnlyId].ToString().Trim(); //OnlyId
objzx_SysScoreTypeEN.UpdUser = objRow[conzx_SysScoreType.UpdUser] == DBNull.Value ? null : objRow[conzx_SysScoreType.UpdUser].ToString().Trim(); //修改人
objzx_SysScoreTypeEN.UpdDate = objRow[conzx_SysScoreType.UpdDate] == DBNull.Value ? null : objRow[conzx_SysScoreType.UpdDate].ToString().Trim(); //修改日期
objzx_SysScoreTypeEN.Memo = objRow[conzx_SysScoreType.Memo] == DBNull.Value ? null : objRow[conzx_SysScoreType.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objzx_SysScoreTypeEN.zxScoreTypeId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objzx_SysScoreTypeEN);
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
public static List<clszx_SysScoreTypeEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clszx_SysScoreTypeEN> arrObjLst = new List<clszx_SysScoreTypeEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clszx_SysScoreTypeEN objzx_SysScoreTypeEN = new clszx_SysScoreTypeEN();
try
{
objzx_SysScoreTypeEN.zxScoreTypeId = objRow[conzx_SysScoreType.zxScoreTypeId].ToString().Trim(); //分数类型Id
objzx_SysScoreTypeEN.ScoreTypeName = objRow[conzx_SysScoreType.ScoreTypeName] == DBNull.Value ? null : objRow[conzx_SysScoreType.ScoreTypeName].ToString().Trim(); //分数类型名称
objzx_SysScoreTypeEN.OnlyId = objRow[conzx_SysScoreType.OnlyId] == DBNull.Value ? null : objRow[conzx_SysScoreType.OnlyId].ToString().Trim(); //OnlyId
objzx_SysScoreTypeEN.UpdUser = objRow[conzx_SysScoreType.UpdUser] == DBNull.Value ? null : objRow[conzx_SysScoreType.UpdUser].ToString().Trim(); //修改人
objzx_SysScoreTypeEN.UpdDate = objRow[conzx_SysScoreType.UpdDate] == DBNull.Value ? null : objRow[conzx_SysScoreType.UpdDate].ToString().Trim(); //修改日期
objzx_SysScoreTypeEN.Memo = objRow[conzx_SysScoreType.Memo] == DBNull.Value ? null : objRow[conzx_SysScoreType.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objzx_SysScoreTypeEN.zxScoreTypeId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objzx_SysScoreTypeEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objzx_SysScoreTypeCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clszx_SysScoreTypeEN> GetSubObjLstCache(clszx_SysScoreTypeEN objzx_SysScoreTypeCond)
{
List<clszx_SysScoreTypeEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clszx_SysScoreTypeEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conzx_SysScoreType.AttributeName)
{
if (objzx_SysScoreTypeCond.IsUpdated(strFldName) == false) continue;
if (objzx_SysScoreTypeCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objzx_SysScoreTypeCond[strFldName].ToString());
}
else
{
if (objzx_SysScoreTypeCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objzx_SysScoreTypeCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objzx_SysScoreTypeCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objzx_SysScoreTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objzx_SysScoreTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objzx_SysScoreTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objzx_SysScoreTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objzx_SysScoreTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objzx_SysScoreTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objzx_SysScoreTypeCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objzx_SysScoreTypeCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objzx_SysScoreTypeCond[strFldName]));
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
public static List<clszx_SysScoreTypeEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clszx_SysScoreTypeEN> arrObjLst = new List<clszx_SysScoreTypeEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clszx_SysScoreTypeEN objzx_SysScoreTypeEN = new clszx_SysScoreTypeEN();
try
{
objzx_SysScoreTypeEN.zxScoreTypeId = objRow[conzx_SysScoreType.zxScoreTypeId].ToString().Trim(); //分数类型Id
objzx_SysScoreTypeEN.ScoreTypeName = objRow[conzx_SysScoreType.ScoreTypeName] == DBNull.Value ? null : objRow[conzx_SysScoreType.ScoreTypeName].ToString().Trim(); //分数类型名称
objzx_SysScoreTypeEN.OnlyId = objRow[conzx_SysScoreType.OnlyId] == DBNull.Value ? null : objRow[conzx_SysScoreType.OnlyId].ToString().Trim(); //OnlyId
objzx_SysScoreTypeEN.UpdUser = objRow[conzx_SysScoreType.UpdUser] == DBNull.Value ? null : objRow[conzx_SysScoreType.UpdUser].ToString().Trim(); //修改人
objzx_SysScoreTypeEN.UpdDate = objRow[conzx_SysScoreType.UpdDate] == DBNull.Value ? null : objRow[conzx_SysScoreType.UpdDate].ToString().Trim(); //修改日期
objzx_SysScoreTypeEN.Memo = objRow[conzx_SysScoreType.Memo] == DBNull.Value ? null : objRow[conzx_SysScoreType.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objzx_SysScoreTypeEN.zxScoreTypeId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objzx_SysScoreTypeEN);
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
public static List<clszx_SysScoreTypeEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clszx_SysScoreTypeEN> arrObjLst = new List<clszx_SysScoreTypeEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clszx_SysScoreTypeEN objzx_SysScoreTypeEN = new clszx_SysScoreTypeEN();
try
{
objzx_SysScoreTypeEN.zxScoreTypeId = objRow[conzx_SysScoreType.zxScoreTypeId].ToString().Trim(); //分数类型Id
objzx_SysScoreTypeEN.ScoreTypeName = objRow[conzx_SysScoreType.ScoreTypeName] == DBNull.Value ? null : objRow[conzx_SysScoreType.ScoreTypeName].ToString().Trim(); //分数类型名称
objzx_SysScoreTypeEN.OnlyId = objRow[conzx_SysScoreType.OnlyId] == DBNull.Value ? null : objRow[conzx_SysScoreType.OnlyId].ToString().Trim(); //OnlyId
objzx_SysScoreTypeEN.UpdUser = objRow[conzx_SysScoreType.UpdUser] == DBNull.Value ? null : objRow[conzx_SysScoreType.UpdUser].ToString().Trim(); //修改人
objzx_SysScoreTypeEN.UpdDate = objRow[conzx_SysScoreType.UpdDate] == DBNull.Value ? null : objRow[conzx_SysScoreType.UpdDate].ToString().Trim(); //修改日期
objzx_SysScoreTypeEN.Memo = objRow[conzx_SysScoreType.Memo] == DBNull.Value ? null : objRow[conzx_SysScoreType.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objzx_SysScoreTypeEN.zxScoreTypeId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objzx_SysScoreTypeEN);
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
List<clszx_SysScoreTypeEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clszx_SysScoreTypeEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clszx_SysScoreTypeEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clszx_SysScoreTypeEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clszx_SysScoreTypeEN> arrObjLst = new List<clszx_SysScoreTypeEN>(); 
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
	clszx_SysScoreTypeEN objzx_SysScoreTypeEN = new clszx_SysScoreTypeEN();
try
{
objzx_SysScoreTypeEN.zxScoreTypeId = objRow[conzx_SysScoreType.zxScoreTypeId].ToString().Trim(); //分数类型Id
objzx_SysScoreTypeEN.ScoreTypeName = objRow[conzx_SysScoreType.ScoreTypeName] == DBNull.Value ? null : objRow[conzx_SysScoreType.ScoreTypeName].ToString().Trim(); //分数类型名称
objzx_SysScoreTypeEN.OnlyId = objRow[conzx_SysScoreType.OnlyId] == DBNull.Value ? null : objRow[conzx_SysScoreType.OnlyId].ToString().Trim(); //OnlyId
objzx_SysScoreTypeEN.UpdUser = objRow[conzx_SysScoreType.UpdUser] == DBNull.Value ? null : objRow[conzx_SysScoreType.UpdUser].ToString().Trim(); //修改人
objzx_SysScoreTypeEN.UpdDate = objRow[conzx_SysScoreType.UpdDate] == DBNull.Value ? null : objRow[conzx_SysScoreType.UpdDate].ToString().Trim(); //修改日期
objzx_SysScoreTypeEN.Memo = objRow[conzx_SysScoreType.Memo] == DBNull.Value ? null : objRow[conzx_SysScoreType.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objzx_SysScoreTypeEN.zxScoreTypeId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objzx_SysScoreTypeEN);
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
public static List<clszx_SysScoreTypeEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clszx_SysScoreTypeEN> arrObjLst = new List<clszx_SysScoreTypeEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clszx_SysScoreTypeEN objzx_SysScoreTypeEN = new clszx_SysScoreTypeEN();
try
{
objzx_SysScoreTypeEN.zxScoreTypeId = objRow[conzx_SysScoreType.zxScoreTypeId].ToString().Trim(); //分数类型Id
objzx_SysScoreTypeEN.ScoreTypeName = objRow[conzx_SysScoreType.ScoreTypeName] == DBNull.Value ? null : objRow[conzx_SysScoreType.ScoreTypeName].ToString().Trim(); //分数类型名称
objzx_SysScoreTypeEN.OnlyId = objRow[conzx_SysScoreType.OnlyId] == DBNull.Value ? null : objRow[conzx_SysScoreType.OnlyId].ToString().Trim(); //OnlyId
objzx_SysScoreTypeEN.UpdUser = objRow[conzx_SysScoreType.UpdUser] == DBNull.Value ? null : objRow[conzx_SysScoreType.UpdUser].ToString().Trim(); //修改人
objzx_SysScoreTypeEN.UpdDate = objRow[conzx_SysScoreType.UpdDate] == DBNull.Value ? null : objRow[conzx_SysScoreType.UpdDate].ToString().Trim(); //修改日期
objzx_SysScoreTypeEN.Memo = objRow[conzx_SysScoreType.Memo] == DBNull.Value ? null : objRow[conzx_SysScoreType.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objzx_SysScoreTypeEN.zxScoreTypeId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objzx_SysScoreTypeEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clszx_SysScoreTypeEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clszx_SysScoreTypeEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clszx_SysScoreTypeEN> arrObjLst = new List<clszx_SysScoreTypeEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clszx_SysScoreTypeEN objzx_SysScoreTypeEN = new clszx_SysScoreTypeEN();
try
{
objzx_SysScoreTypeEN.zxScoreTypeId = objRow[conzx_SysScoreType.zxScoreTypeId].ToString().Trim(); //分数类型Id
objzx_SysScoreTypeEN.ScoreTypeName = objRow[conzx_SysScoreType.ScoreTypeName] == DBNull.Value ? null : objRow[conzx_SysScoreType.ScoreTypeName].ToString().Trim(); //分数类型名称
objzx_SysScoreTypeEN.OnlyId = objRow[conzx_SysScoreType.OnlyId] == DBNull.Value ? null : objRow[conzx_SysScoreType.OnlyId].ToString().Trim(); //OnlyId
objzx_SysScoreTypeEN.UpdUser = objRow[conzx_SysScoreType.UpdUser] == DBNull.Value ? null : objRow[conzx_SysScoreType.UpdUser].ToString().Trim(); //修改人
objzx_SysScoreTypeEN.UpdDate = objRow[conzx_SysScoreType.UpdDate] == DBNull.Value ? null : objRow[conzx_SysScoreType.UpdDate].ToString().Trim(); //修改日期
objzx_SysScoreTypeEN.Memo = objRow[conzx_SysScoreType.Memo] == DBNull.Value ? null : objRow[conzx_SysScoreType.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objzx_SysScoreTypeEN.zxScoreTypeId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objzx_SysScoreTypeEN);
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
public static List<clszx_SysScoreTypeEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clszx_SysScoreTypeEN> arrObjLst = new List<clszx_SysScoreTypeEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clszx_SysScoreTypeEN objzx_SysScoreTypeEN = new clszx_SysScoreTypeEN();
try
{
objzx_SysScoreTypeEN.zxScoreTypeId = objRow[conzx_SysScoreType.zxScoreTypeId].ToString().Trim(); //分数类型Id
objzx_SysScoreTypeEN.ScoreTypeName = objRow[conzx_SysScoreType.ScoreTypeName] == DBNull.Value ? null : objRow[conzx_SysScoreType.ScoreTypeName].ToString().Trim(); //分数类型名称
objzx_SysScoreTypeEN.OnlyId = objRow[conzx_SysScoreType.OnlyId] == DBNull.Value ? null : objRow[conzx_SysScoreType.OnlyId].ToString().Trim(); //OnlyId
objzx_SysScoreTypeEN.UpdUser = objRow[conzx_SysScoreType.UpdUser] == DBNull.Value ? null : objRow[conzx_SysScoreType.UpdUser].ToString().Trim(); //修改人
objzx_SysScoreTypeEN.UpdDate = objRow[conzx_SysScoreType.UpdDate] == DBNull.Value ? null : objRow[conzx_SysScoreType.UpdDate].ToString().Trim(); //修改日期
objzx_SysScoreTypeEN.Memo = objRow[conzx_SysScoreType.Memo] == DBNull.Value ? null : objRow[conzx_SysScoreType.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objzx_SysScoreTypeEN.zxScoreTypeId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objzx_SysScoreTypeEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clszx_SysScoreTypeEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clszx_SysScoreTypeEN> arrObjLst = new List<clszx_SysScoreTypeEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clszx_SysScoreTypeEN objzx_SysScoreTypeEN = new clszx_SysScoreTypeEN();
try
{
objzx_SysScoreTypeEN.zxScoreTypeId = objRow[conzx_SysScoreType.zxScoreTypeId].ToString().Trim(); //分数类型Id
objzx_SysScoreTypeEN.ScoreTypeName = objRow[conzx_SysScoreType.ScoreTypeName] == DBNull.Value ? null : objRow[conzx_SysScoreType.ScoreTypeName].ToString().Trim(); //分数类型名称
objzx_SysScoreTypeEN.OnlyId = objRow[conzx_SysScoreType.OnlyId] == DBNull.Value ? null : objRow[conzx_SysScoreType.OnlyId].ToString().Trim(); //OnlyId
objzx_SysScoreTypeEN.UpdUser = objRow[conzx_SysScoreType.UpdUser] == DBNull.Value ? null : objRow[conzx_SysScoreType.UpdUser].ToString().Trim(); //修改人
objzx_SysScoreTypeEN.UpdDate = objRow[conzx_SysScoreType.UpdDate] == DBNull.Value ? null : objRow[conzx_SysScoreType.UpdDate].ToString().Trim(); //修改日期
objzx_SysScoreTypeEN.Memo = objRow[conzx_SysScoreType.Memo] == DBNull.Value ? null : objRow[conzx_SysScoreType.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objzx_SysScoreTypeEN.zxScoreTypeId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objzx_SysScoreTypeEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objzx_SysScoreTypeEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool Getzx_SysScoreType(ref clszx_SysScoreTypeEN objzx_SysScoreTypeEN)
{
bool bolResult = zx_SysScoreTypeDA.Getzx_SysScoreType(ref objzx_SysScoreTypeEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "strzxScoreTypeId">表关键字</param>
 /// <returns>表对象</returns>
public static clszx_SysScoreTypeEN GetObjByzxScoreTypeId(string strzxScoreTypeId)
{
if (strzxScoreTypeId.IndexOf(' ') >=0)
{
var strMsg = string.Format("(errid:Busi000079)在表中,关键字[strzxScoreTypeId]中不能有空格!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
if (string.IsNullOrEmpty(strzxScoreTypeId) == true)
{
var strMsg = string.Format("(errid:Busi000020)在表中,关键字[strzxScoreTypeId]不能为空!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
clszx_SysScoreTypeEN objzx_SysScoreTypeEN = zx_SysScoreTypeDA.GetObjByzxScoreTypeId(strzxScoreTypeId);
return objzx_SysScoreTypeEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clszx_SysScoreTypeEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clszx_SysScoreTypeEN objzx_SysScoreTypeEN = zx_SysScoreTypeDA.GetFirstObj(strWhereCond);
 return objzx_SysScoreTypeEN;
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
public static clszx_SysScoreTypeEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clszx_SysScoreTypeEN objzx_SysScoreTypeEN = zx_SysScoreTypeDA.GetObjByDataRow(objRow);
 return objzx_SysScoreTypeEN;
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
public static clszx_SysScoreTypeEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clszx_SysScoreTypeEN objzx_SysScoreTypeEN = zx_SysScoreTypeDA.GetObjByDataRow(objRow);
 return objzx_SysScoreTypeEN;
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
 /// <param name = "strzxScoreTypeId">所给的关键字</param>
 /// <param name = "lstzx_SysScoreTypeObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clszx_SysScoreTypeEN GetObjByzxScoreTypeIdFromList(string strzxScoreTypeId, List<clszx_SysScoreTypeEN> lstzx_SysScoreTypeObjLst)
{
foreach (clszx_SysScoreTypeEN objzx_SysScoreTypeEN in lstzx_SysScoreTypeObjLst)
{
if (objzx_SysScoreTypeEN.zxScoreTypeId == strzxScoreTypeId)
{
return objzx_SysScoreTypeEN;
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
 string strzxScoreTypeId;
 try
 {
 strzxScoreTypeId = new clszx_SysScoreTypeDA().GetFirstID(strWhereCond);
 return strzxScoreTypeId;
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
 arrList = zx_SysScoreTypeDA.GetID(strWhereCond);
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
bool bolIsExist = zx_SysScoreTypeDA.IsExistCondRec(strWhereCond);
return bolIsExist;
}

 /// <summary>
 /// 判断当前表中是否存在给定关键字值的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExist)
 /// </summary>
 /// <param name = "strzxScoreTypeId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public static bool IsExist(string strzxScoreTypeId)
{
if (string.IsNullOrEmpty(strzxScoreTypeId) == true)
{
var strMsg = string.Format("(errid:Busi000027)在表中,关键字[strzxScoreTypeId]不能为空!!(from {0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
//检测记录是否存在
bool bolIsExist = zx_SysScoreTypeDA.IsExist(strzxScoreTypeId);
return bolIsExist;
}

/// <summary>
/// 设置修改时间
/// </summary>
/// <param name = "strzxScoreTypeId">分数类型Id</param>
/// <param name = "strOpUser">修改用户</param>
/// <returns>是否成功？</returns>
public static bool SetUpdDate(string strzxScoreTypeId, string strOpUser)
{
clszx_SysScoreTypeEN objzx_SysScoreTypeEN = clszx_SysScoreTypeBL.GetObjByzxScoreTypeId(strzxScoreTypeId);
objzx_SysScoreTypeEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
return clszx_SysScoreTypeBL.UpdateBySql2(objzx_SysScoreTypeEN);
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
 bolIsExist = clszx_SysScoreTypeDA.IsExistTable();
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
 bolIsExist = zx_SysScoreTypeDA.IsExistTable(strTabName);
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
 /// <param name = "objzx_SysScoreTypeEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecordBySql2(clszx_SysScoreTypeEN objzx_SysScoreTypeEN)
{
 if (string.IsNullOrEmpty(objzx_SysScoreTypeEN.zxScoreTypeId) == true)
 {
string strMsg = string.Format("添加记录时,关键字不能为空!(from {0})\r\n", 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
 if (clszx_SysScoreTypeBL.IsExist(objzx_SysScoreTypeEN.zxScoreTypeId) == true)
 {
string strMsg = string.Format("添加记录时,关键字:[{0}]已经存在!(from {1})\r\n", objzx_SysScoreTypeEN.zxScoreTypeId, 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
try
{
bool bolResult = zx_SysScoreTypeDA.AddNewRecordBySQL2(objzx_SysScoreTypeEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clszx_SysScoreTypeBL.ReFreshCache();

if (clszx_SysScoreTypeBL.relatedActions != null)
{
clszx_SysScoreTypeBL.relatedActions.UpdRelaTabDate(objzx_SysScoreTypeEN.zxScoreTypeId, "SetUpdDate");
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
 /// <param name = "objzx_SysScoreTypeEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordBySql2WithReturnKey(clszx_SysScoreTypeEN objzx_SysScoreTypeEN)
{
 if (string.IsNullOrEmpty(objzx_SysScoreTypeEN.zxScoreTypeId) == true)
 {
string strMsg = string.Format("添加记录时,关键字不能为空!(from {{0}})", 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
 if (clszx_SysScoreTypeBL.IsExist(objzx_SysScoreTypeEN.zxScoreTypeId) == true)
 {
string strMsg = string.Format("添加记录时,关键字:[{0}]已经存在!(from {1})\r\n", objzx_SysScoreTypeEN.zxScoreTypeId, 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
try
{
string strKey = zx_SysScoreTypeDA.AddNewRecordBySQL2WithReturnKey(objzx_SysScoreTypeEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clszx_SysScoreTypeBL.ReFreshCache();

if (clszx_SysScoreTypeBL.relatedActions != null)
{
clszx_SysScoreTypeBL.relatedActions.UpdRelaTabDate(objzx_SysScoreTypeEN.zxScoreTypeId, "SetUpdDate");
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
 /// <param name = "objzx_SysScoreTypeEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(clszx_SysScoreTypeEN objzx_SysScoreTypeEN)
{
try
{
bool bolResult = zx_SysScoreTypeDA.Update(objzx_SysScoreTypeEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clszx_SysScoreTypeBL.ReFreshCache();

if (clszx_SysScoreTypeBL.relatedActions != null)
{
clszx_SysScoreTypeBL.relatedActions.UpdRelaTabDate(objzx_SysScoreTypeEN.zxScoreTypeId, "SetUpdDate");
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
 /// <param name = "objzx_SysScoreTypeEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateBySql2(clszx_SysScoreTypeEN objzx_SysScoreTypeEN)
{
 if (string.IsNullOrEmpty(objzx_SysScoreTypeEN.zxScoreTypeId) == true)
 {
var strMsg = string.Format("(errid:Busi000065)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = zx_SysScoreTypeDA.UpdateBySql2(objzx_SysScoreTypeEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clszx_SysScoreTypeBL.ReFreshCache();

if (clszx_SysScoreTypeBL.relatedActions != null)
{
clszx_SysScoreTypeBL.relatedActions.UpdRelaTabDate(objzx_SysScoreTypeEN.zxScoreTypeId, "SetUpdDate");
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
 /// <param name = "strzxScoreTypeId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int DelRecord(string strzxScoreTypeId)
{
try
{
 clszx_SysScoreTypeEN objzx_SysScoreTypeEN = clszx_SysScoreTypeBL.GetObjByzxScoreTypeId(strzxScoreTypeId);

if (clszx_SysScoreTypeBL.relatedActions != null)
{
clszx_SysScoreTypeBL.relatedActions.UpdRelaTabDate(objzx_SysScoreTypeEN.zxScoreTypeId, "SetUpdDate");
}
if (objzx_SysScoreTypeEN != null)
{
int intRecNum = zx_SysScoreTypeDA.DelRecord(strzxScoreTypeId);
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
/// <param name="strzxScoreTypeId">表关键字</param>
/// <returns></returns>
public static bool DelRecordEx(string strzxScoreTypeId )
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clszx_SysScoreTypeDA.GetSpecSQLObj();
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
//删除与表:[zx_SysScoreType]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conzx_SysScoreType.zxScoreTypeId,
//strzxScoreTypeId);
//        clszx_SysScoreTypeBL.Delzx_SysScoreTypesByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clszx_SysScoreTypeBL.DelRecord(strzxScoreTypeId, objConnection, objSqlTransaction);
objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clszx_SysScoreTypeBLEx", "DelRecordEx", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("扩展删除记录出错:{0}!keyId = {1}.({2})",
objException.Message,
strzxScoreTypeId, clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "strzxScoreTypeId">给定的关键字值</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回删除是否成功?</returns>
public static bool DelRecord(string strzxScoreTypeId, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
if (clszx_SysScoreTypeBL.relatedActions != null)
{
clszx_SysScoreTypeBL.relatedActions.UpdRelaTabDate(strzxScoreTypeId, "UpdRelaTabDate");
}
bool bolResult = zx_SysScoreTypeDA.DelRecord(strzxScoreTypeId,objSqlConnection,objSqlTransaction);
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
 /// <param name = "arrzxScoreTypeIdLst">给定的关键字值列表</param>
 /// <returns>返回删除的记录数</returns>
public static int Delzx_SysScoreTypes(List<string> arrzxScoreTypeIdLst)
{
if (arrzxScoreTypeIdLst.Count == 0) return 0;
try
{
if (clszx_SysScoreTypeBL.relatedActions != null)
{
foreach (var strzxScoreTypeId in arrzxScoreTypeIdLst)
{
clszx_SysScoreTypeBL.relatedActions.UpdRelaTabDate(strzxScoreTypeId, "UpdRelaTabDate");
}
}
int intDelRecNum = zx_SysScoreTypeDA.Delzx_SysScoreType(arrzxScoreTypeIdLst);
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
public static int Delzx_SysScoreTypesByCond(string strWhereCond)
{
try
{
if (clszx_SysScoreTypeBL.relatedActions != null)
{
List<string> arrzxScoreTypeId = GetPrimaryKeyID_S(strWhereCond);
foreach (var strzxScoreTypeId in arrzxScoreTypeId)
{
clszx_SysScoreTypeBL.relatedActions.UpdRelaTabDate(strzxScoreTypeId, "UpdRelaTabDate");
}
}
int intRecNum = zx_SysScoreTypeDA.Delzx_SysScoreType(strWhereCond);
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
/// 这里仅仅是演示函数,使用时请复制到扩展类:[zx_SysScoreType]中改名为:[DelRecord4MultiTabEx]使用
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DelRecord4MultiTab)
/// </summary>
/// <param name="strzxScoreTypeId">表关键字</param>
/// <returns></returns>
public static bool DelRecord4MultiTab(string strzxScoreTypeId)
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clszx_SysScoreTypeDA.GetSpecSQLObj();
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
//删除与表:[zx_SysScoreType]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conStudent.id_College,
//strid_College);
//        clsStudentBL.DelStudentsByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clszx_SysScoreTypeBL.DelRecord(strzxScoreTypeId, objConnection, objSqlTransaction);
                objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clszx_SysScoreTypeBL", "DelRecord4MultiTab", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("删除多表记录出错:{0}!keyId = {1}.({2})",
objException.Message,
strzxScoreTypeId, clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "objzx_SysScoreTypeENS">源对象</param>
 /// <param name = "objzx_SysScoreTypeENT">目标对象</param>
 public static void CopyTo(clszx_SysScoreTypeEN objzx_SysScoreTypeENS, clszx_SysScoreTypeEN objzx_SysScoreTypeENT)
{
try
{
objzx_SysScoreTypeENT.zxScoreTypeId = objzx_SysScoreTypeENS.zxScoreTypeId; //分数类型Id
objzx_SysScoreTypeENT.ScoreTypeName = objzx_SysScoreTypeENS.ScoreTypeName; //分数类型名称
objzx_SysScoreTypeENT.OnlyId = objzx_SysScoreTypeENS.OnlyId; //OnlyId
objzx_SysScoreTypeENT.UpdUser = objzx_SysScoreTypeENS.UpdUser; //修改人
objzx_SysScoreTypeENT.UpdDate = objzx_SysScoreTypeENS.UpdDate; //修改日期
objzx_SysScoreTypeENT.Memo = objzx_SysScoreTypeENS.Memo; //备注
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
 /// <param name = "objzx_SysScoreTypeEN">源简化对象</param>
 public static void SetUpdFlag(clszx_SysScoreTypeEN objzx_SysScoreTypeEN)
{
try
{
objzx_SysScoreTypeEN.ClearUpdateState();
   string strsfUpdFldSetStr = objzx_SysScoreTypeEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(conzx_SysScoreType.zxScoreTypeId, new clsStrCompareIgnoreCase())  ==  true)
{
objzx_SysScoreTypeEN.zxScoreTypeId = objzx_SysScoreTypeEN.zxScoreTypeId; //分数类型Id
}
if (arrFldSet.Contains(conzx_SysScoreType.ScoreTypeName, new clsStrCompareIgnoreCase())  ==  true)
{
objzx_SysScoreTypeEN.ScoreTypeName = objzx_SysScoreTypeEN.ScoreTypeName == "[null]" ? null :  objzx_SysScoreTypeEN.ScoreTypeName; //分数类型名称
}
if (arrFldSet.Contains(conzx_SysScoreType.OnlyId, new clsStrCompareIgnoreCase())  ==  true)
{
objzx_SysScoreTypeEN.OnlyId = objzx_SysScoreTypeEN.OnlyId == "[null]" ? null :  objzx_SysScoreTypeEN.OnlyId; //OnlyId
}
if (arrFldSet.Contains(conzx_SysScoreType.UpdUser, new clsStrCompareIgnoreCase())  ==  true)
{
objzx_SysScoreTypeEN.UpdUser = objzx_SysScoreTypeEN.UpdUser == "[null]" ? null :  objzx_SysScoreTypeEN.UpdUser; //修改人
}
if (arrFldSet.Contains(conzx_SysScoreType.UpdDate, new clsStrCompareIgnoreCase())  ==  true)
{
objzx_SysScoreTypeEN.UpdDate = objzx_SysScoreTypeEN.UpdDate == "[null]" ? null :  objzx_SysScoreTypeEN.UpdDate; //修改日期
}
if (arrFldSet.Contains(conzx_SysScoreType.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objzx_SysScoreTypeEN.Memo = objzx_SysScoreTypeEN.Memo == "[null]" ? null :  objzx_SysScoreTypeEN.Memo; //备注
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
 /// <param name = "objzx_SysScoreTypeEN">源简化对象</param>
 public static void AccessFldValueNull(clszx_SysScoreTypeEN objzx_SysScoreTypeEN)
{
try
{
if (objzx_SysScoreTypeEN.ScoreTypeName == "[null]") objzx_SysScoreTypeEN.ScoreTypeName = null; //分数类型名称
if (objzx_SysScoreTypeEN.OnlyId == "[null]") objzx_SysScoreTypeEN.OnlyId = null; //OnlyId
if (objzx_SysScoreTypeEN.UpdUser == "[null]") objzx_SysScoreTypeEN.UpdUser = null; //修改人
if (objzx_SysScoreTypeEN.UpdDate == "[null]") objzx_SysScoreTypeEN.UpdDate = null; //修改日期
if (objzx_SysScoreTypeEN.Memo == "[null]") objzx_SysScoreTypeEN.Memo = null; //备注
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
public static void CheckPropertyNew(clszx_SysScoreTypeEN objzx_SysScoreTypeEN)
{
 zx_SysScoreTypeDA.CheckPropertyNew(objzx_SysScoreTypeEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(clszx_SysScoreTypeEN objzx_SysScoreTypeEN)
{
 zx_SysScoreTypeDA.CheckProperty4Condition(objzx_SysScoreTypeEN);
 }


 #endregion 检查对象属性


 #region 绑定下拉框

 /// <summary>
 /// 绑定基于Win的下拉框
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_TabFeature_ComboBoxBindFunction)
 /// </summary>
 /// <param name = "objComboBox">需要绑定当前表的下拉框</param>

public static void BindCbo_zxScoreTypeId(System.Windows.Forms.ComboBox objComboBox )
{
//为数据源为表的下拉框设置内容
string strCondition = string.Format("1 =1 Order By {0}", conzx_SysScoreType.zxScoreTypeId); 
List<clszx_SysScoreTypeEN> arrObjLst = clszx_SysScoreTypeBL.GetObjLst(strCondition);
//初始化一个对象列表
//插入第0项。在第0项中插入“请选择...”,为了方便用户,与WEB方式类似。
clszx_SysScoreTypeEN objzx_SysScoreTypeEN = new clszx_SysScoreTypeEN()
{
zxScoreTypeId = "0",
ScoreTypeName = "选[中学评分类型表]..."
};
arrObjLst.Insert(0, objzx_SysScoreTypeEN);
//设置下拉框的数据源、以及设置值项、显示项
objComboBox.ValueMember = conzx_SysScoreType.zxScoreTypeId;
objComboBox.DisplayMember = conzx_SysScoreType.ScoreTypeName;
objComboBox.DataSource = arrObjLst;
objComboBox.SelectedIndex = 0;
}

 /// <summary>
 /// 绑定基于Web的下拉框
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_TabFeature_DdlBindFunction)
 /// </summary>
 /// <param name = "objDDL">需要绑定当前表的下拉框</param>

public static void BindDdl_zxScoreTypeId(System.Web.UI.WebControls.DropDownList objDDL )
{
//为数据源于表的下拉框设置内容
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[中学评分类型表]...","0");
string strCondition = string.Format("1 =1 Order By {0}", conzx_SysScoreType.zxScoreTypeId); 
IEnumerable<clszx_SysScoreTypeEN> arrObjLst = clszx_SysScoreTypeBL.GetObjLst(strCondition);
objDDL.DataValueField = conzx_SysScoreType.zxScoreTypeId;
objDDL.DataTextField = conzx_SysScoreType.ScoreTypeName;
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
public static void BindDdl_zxScoreTypeIdCache(System.Web.UI.WebControls.DropDownList objDDL)
{
//为数据源于表的下拉框设置内容
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[中学评分类型表]...","0");
List<clszx_SysScoreTypeEN> arrzx_SysScoreTypeObjLst = GetAllzx_SysScoreTypeObjLstCache(); 
objDDL.DataValueField = conzx_SysScoreType.zxScoreTypeId;
objDDL.DataTextField = conzx_SysScoreType.ScoreTypeName;
objDDL.DataSource = arrzx_SysScoreTypeObjLst;
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
if (clszx_SysScoreTypeBL.objCommFun4BL == null)
{
strMsg = string.Format("类clszx_SysScoreTypeBL没有刷新缓存机制(clszx_SysScoreTypeBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by zxScoreTypeId");
//if (arrzx_SysScoreTypeObjLstCache == null)
//{
//arrzx_SysScoreTypeObjLstCache = zx_SysScoreTypeDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "strzxScoreTypeId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clszx_SysScoreTypeEN GetObjByzxScoreTypeIdCache(string strzxScoreTypeId)
{
//获取缓存中的对象列表
string strKey = string.Format("{0}", clszx_SysScoreTypeEN._CurrTabName);
List<clszx_SysScoreTypeEN> arrzx_SysScoreTypeObjLstCache = GetObjLstCache();
IEnumerable <clszx_SysScoreTypeEN> arrzx_SysScoreTypeObjLst_Sel =
arrzx_SysScoreTypeObjLstCache
.Where(x=> x.zxScoreTypeId == strzxScoreTypeId 
);
if (arrzx_SysScoreTypeObjLst_Sel.Count() == 0)
{
   clszx_SysScoreTypeEN obj = clszx_SysScoreTypeBL.GetObjByzxScoreTypeId(strzxScoreTypeId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
 }
return null;
}
return arrzx_SysScoreTypeObjLst_Sel.First();
}

 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecNameByKeyCache)
 /// </summary>
 /// <param name = "strzxScoreTypeId">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetScoreTypeNameByzxScoreTypeIdCache(string strzxScoreTypeId)
{
if (string.IsNullOrEmpty(strzxScoreTypeId) == true) return "";
//获取缓存中的对象列表
clszx_SysScoreTypeEN objzx_SysScoreType = GetObjByzxScoreTypeIdCache(strzxScoreTypeId);
if (objzx_SysScoreType == null) return "";
return objzx_SysScoreType.ScoreTypeName;
}
 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecNameByKeyCache)
 /// </summary>
 /// <param name = "strzxScoreTypeId">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetNameByzxScoreTypeIdCache(string strzxScoreTypeId)
{
if (string.IsNullOrEmpty(strzxScoreTypeId) == true) return "";
//获取缓存中的对象列表
clszx_SysScoreTypeEN objzx_SysScoreType = GetObjByzxScoreTypeIdCache(strzxScoreTypeId);
if (objzx_SysScoreType == null) return "";
return objzx_SysScoreType.ScoreTypeName;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clszx_SysScoreTypeEN> GetAllzx_SysScoreTypeObjLstCache()
{
//获取缓存中的对象列表
List<clszx_SysScoreTypeEN> arrzx_SysScoreTypeObjLstCache = GetObjLstCache(); 
return arrzx_SysScoreTypeObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clszx_SysScoreTypeEN> GetObjLstCache()
{
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}", clszx_SysScoreTypeEN._CurrTabName);
List<clszx_SysScoreTypeEN> arrzx_SysScoreTypeObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrzx_SysScoreTypeObjLstCache;
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
string strKey = string.Format("{0}", clszx_SysScoreTypeEN._CurrTabName);
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
if (clszx_SysScoreTypeBL.objCommFun4BL != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}", clszx_SysScoreTypeEN._CurrTabName);
CacheHelper.Remove(strKey);
clszx_SysScoreTypeBL.objCommFun4BL.ReFreshCache();
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
public static string Func(string strInFldName, string strOutFldName, string strzxScoreTypeId)
{
if (strInFldName != conzx_SysScoreType.zxScoreTypeId)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (conzx_SysScoreType.AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", conzx_SysScoreType.AttributeName));
throw new Exception(strMsg);
}
var objzx_SysScoreType = clszx_SysScoreTypeBL.GetObjByzxScoreTypeIdCache(strzxScoreTypeId);
if (objzx_SysScoreType == null) return "";
return objzx_SysScoreType[strOutFldName].ToString();
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
int intRecCount = clszx_SysScoreTypeDA.GetRecCount(strTabName);
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
int intRecCount = clszx_SysScoreTypeDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clszx_SysScoreTypeDA.GetRecCount();
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
int intRecCount = clszx_SysScoreTypeDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objzx_SysScoreTypeCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clszx_SysScoreTypeEN objzx_SysScoreTypeCond)
{
List<clszx_SysScoreTypeEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clszx_SysScoreTypeEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conzx_SysScoreType.AttributeName)
{
if (objzx_SysScoreTypeCond.IsUpdated(strFldName) == false) continue;
if (objzx_SysScoreTypeCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objzx_SysScoreTypeCond[strFldName].ToString());
}
else
{
if (objzx_SysScoreTypeCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objzx_SysScoreTypeCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objzx_SysScoreTypeCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objzx_SysScoreTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objzx_SysScoreTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objzx_SysScoreTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objzx_SysScoreTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objzx_SysScoreTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objzx_SysScoreTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objzx_SysScoreTypeCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objzx_SysScoreTypeCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objzx_SysScoreTypeCond[strFldName]));
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
 List<string> arrList = clszx_SysScoreTypeDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = zx_SysScoreTypeDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = zx_SysScoreTypeDA.GetFldValueNoDistinct(strFldName, strWhereCond);
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
int intRecCount = zx_SysScoreTypeDA.SetFldValue(strFldName, strValue, strWhereCond);
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
int intRecCount = clszx_SysScoreTypeDA.SetFldValue(clszx_SysScoreTypeEN._CurrTabName, strFldName, fltValue, strWhereCond);
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
int intRecCount = zx_SysScoreTypeDA.SetFldValue( strFldName, intValue, strWhereCond);
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
int intRecCount = clszx_SysScoreTypeDA.SetFldValue(strTabName, strFldName, strValue, strWhereCond);
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
int intRecCount = clszx_SysScoreTypeDA.SetFldValue(strTabName, strFldName, intValue, strWhereCond);
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
int intRecCount = clszx_SysScoreTypeDA.SetFldValue(strTabName, strFldName, fltValue, strWhereCond);
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
  strCreateTabCode.Append("CREATE table [dbo].[zx_SysScoreType] "); 
 strCreateTabCode.Append(" ( "); 
 // /**分数类型Id*/ 
 strCreateTabCode.Append(" zxScoreTypeId char(4) primary key, "); 
 // /**分数类型名称*/ 
 strCreateTabCode.Append(" ScoreTypeName varchar(10) Null, "); 
 // /**OnlyId*/ 
 strCreateTabCode.Append(" OnlyId varchar(20) Null, "); 
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
 /// 中学评分类型表(zx_SysScoreType)
 /// 数据源类型:表
 /// (AutoGCLib.CommFun4BL4CSharp:GeneCode_This)
 /// </summary>
public class  clsCommFun4BL4zx_SysScoreType : clsCommFun4BL
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
clszx_SysScoreTypeBL.ReFreshThisCache();
}
}

}