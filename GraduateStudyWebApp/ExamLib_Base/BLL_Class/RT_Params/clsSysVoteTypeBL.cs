
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsSysVoteTypeBL
 表名:SysVoteType(01120638)
 * 版本:2024.11.13.1(服务器:WIN-SRV103-116)
 日期:2024/11/13 06:14:06
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
public static class  clsSysVoteTypeBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "strVoteTypeId">表关键字</param>
 /// <returns>表对象</returns>
public static clsSysVoteTypeEN GetObj(this K_VoteTypeId_SysVoteType myKey)
{
clsSysVoteTypeEN objSysVoteTypeEN = clsSysVoteTypeBL.SysVoteTypeDA.GetObjByVoteTypeId(myKey.Value);
return objSysVoteTypeEN;
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_AddNewRecord)
 /// </summary>
 /// <param name = "objSysVoteTypeEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clsSysVoteTypeEN objSysVoteTypeEN, bool bolIsNeedCheckUniqueness = true)
{
 if (string.IsNullOrEmpty(objSysVoteTypeEN.VoteTypeId) == true)
 {
string strMsg = string.Format("添加记录时,关键字不能为空!(from {0})\r\n", 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
 if (clsSysVoteTypeBL.IsExist(objSysVoteTypeEN.VoteTypeId) == true)
 {
string strMsg = string.Format("添加记录时,关键字:[{0}]已经存在!(from {1})\r\n", objSysVoteTypeEN.VoteTypeId, 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
try
{
bool bolResult = clsSysVoteTypeBL.SysVoteTypeDA.AddNewRecordBySQL2(objSysVoteTypeEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsSysVoteTypeBL.ReFreshCache();

if (clsSysVoteTypeBL.relatedActions != null)
{
clsSysVoteTypeBL.relatedActions.UpdRelaTabDate(objSysVoteTypeEN.VoteTypeId, "SetUpdDate");
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
public static bool AddRecordEx(this clsSysVoteTypeEN objSysVoteTypeEN, bool bolIsNeedCheckUniqueness = true)
{
//操作步骤:
//1、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在
//2、检查唯一性
//3、检查传进去的对象属性是否合法
//4、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
//1、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在
if (clsSysVoteTypeBL.IsExist(objSysVoteTypeEN.VoteTypeId))	//判断是否有相同的关键字
{
strMsg = "(errid:Busi000151)关键字字段已有相同的值";
throw new Exception(strMsg);
}
try
{
 //2、检查传进去的对象属性是否合法
objSysVoteTypeEN.CheckPropertyNew();
//6、把数据实体层的数据存贮到数据库中
objSysVoteTypeEN.AddNewRecord();
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
 /// <param name = "objSysVoteTypeEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordWithReturnKey(this clsSysVoteTypeEN objSysVoteTypeEN, bool bolIsNeedCheckUniqueness = true)
{
 if (string.IsNullOrEmpty(objSysVoteTypeEN.VoteTypeId) == true)
 {
string strMsg = string.Format("添加记录时,关键字不能为空!(from {{0}})", 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
 if (clsSysVoteTypeBL.IsExist(objSysVoteTypeEN.VoteTypeId) == true)
 {
string strMsg = string.Format("添加记录时,关键字:[{0}]已经存在!(from {1})\r\n", objSysVoteTypeEN.VoteTypeId, 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
try
{
string strKey = clsSysVoteTypeBL.SysVoteTypeDA.AddNewRecordBySQL2WithReturnKey(objSysVoteTypeEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsSysVoteTypeBL.ReFreshCache();

if (clsSysVoteTypeBL.relatedActions != null)
{
clsSysVoteTypeBL.relatedActions.UpdRelaTabDate(objSysVoteTypeEN.VoteTypeId, "SetUpdDate");
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
 /// <param name = "objSysVoteTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsSysVoteTypeEN SetVoteTypeId(this clsSysVoteTypeEN objSysVoteTypeEN, string strVoteTypeId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strVoteTypeId, 2, conSysVoteType.VoteTypeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strVoteTypeId, 2, conSysVoteType.VoteTypeId);
}
objSysVoteTypeEN.VoteTypeId = strVoteTypeId; //点赞类型Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objSysVoteTypeEN.dicFldComparisonOp.ContainsKey(conSysVoteType.VoteTypeId) == false)
{
objSysVoteTypeEN.dicFldComparisonOp.Add(conSysVoteType.VoteTypeId, strComparisonOp);
}
else
{
objSysVoteTypeEN.dicFldComparisonOp[conSysVoteType.VoteTypeId] = strComparisonOp;
}
}
return objSysVoteTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objSysVoteTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsSysVoteTypeEN SetVoteTypeName(this clsSysVoteTypeEN objSysVoteTypeEN, string strVoteTypeName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strVoteTypeName, 100, conSysVoteType.VoteTypeName);
}
objSysVoteTypeEN.VoteTypeName = strVoteTypeName; //点赞类型名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objSysVoteTypeEN.dicFldComparisonOp.ContainsKey(conSysVoteType.VoteTypeName) == false)
{
objSysVoteTypeEN.dicFldComparisonOp.Add(conSysVoteType.VoteTypeName, strComparisonOp);
}
else
{
objSysVoteTypeEN.dicFldComparisonOp[conSysVoteType.VoteTypeName] = strComparisonOp;
}
}
return objSysVoteTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objSysVoteTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsSysVoteTypeEN SetVoteTable(this clsSysVoteTypeEN objSysVoteTypeEN, string strVoteTable, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strVoteTable, 100, conSysVoteType.VoteTable);
}
objSysVoteTypeEN.VoteTable = strVoteTable; //点赞表
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objSysVoteTypeEN.dicFldComparisonOp.ContainsKey(conSysVoteType.VoteTable) == false)
{
objSysVoteTypeEN.dicFldComparisonOp.Add(conSysVoteType.VoteTable, strComparisonOp);
}
else
{
objSysVoteTypeEN.dicFldComparisonOp[conSysVoteType.VoteTable] = strComparisonOp;
}
}
return objSysVoteTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objSysVoteTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsSysVoteTypeEN SetVoteTableId(this clsSysVoteTypeEN objSysVoteTypeEN, string strVoteTableId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strVoteTableId, 50, conSysVoteType.VoteTableId);
}
objSysVoteTypeEN.VoteTableId = strVoteTableId; //点赞表Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objSysVoteTypeEN.dicFldComparisonOp.ContainsKey(conSysVoteType.VoteTableId) == false)
{
objSysVoteTypeEN.dicFldComparisonOp.Add(conSysVoteType.VoteTableId, strComparisonOp);
}
else
{
objSysVoteTypeEN.dicFldComparisonOp[conSysVoteType.VoteTableId] = strComparisonOp;
}
}
return objSysVoteTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objSysVoteTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsSysVoteTypeEN SetMemo(this clsSysVoteTypeEN objSysVoteTypeEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, conSysVoteType.Memo);
}
objSysVoteTypeEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objSysVoteTypeEN.dicFldComparisonOp.ContainsKey(conSysVoteType.Memo) == false)
{
objSysVoteTypeEN.dicFldComparisonOp.Add(conSysVoteType.Memo, strComparisonOp);
}
else
{
objSysVoteTypeEN.dicFldComparisonOp[conSysVoteType.Memo] = strComparisonOp;
}
}
return objSysVoteTypeEN;
	}

 /// <summary>
 /// 修改记录存盘到数据表中
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_UpdateRecordEx)
 /// </summary>
 /// <param name = "objSysVoteTypeEN">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool UpdateRecordEx(this clsSysVoteTypeEN objSysVoteTypeEN)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
try
{
//1、检查传进去的对象属性是否合法
objSysVoteTypeEN.CheckPropertyNew();
clsSysVoteTypeEN objSysVoteTypeCond = new clsSysVoteTypeEN();
string strCondition = objSysVoteTypeCond
.SetVoteTypeId(objSysVoteTypeEN.VoteTypeId, "=")
.GetCombineCondition();
objSysVoteTypeEN._IsCheckProperty = true;
bool bolIsExist = clsSysVoteTypeBL.IsExistRecord(strCondition);
if (bolIsExist)
{
strMsg = "()不能重复!";
throw new Exception(strMsg);
}
//4、把数据实体层的数据存贮到数据库中
objSysVoteTypeEN.Update();
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
 /// <param name = "objSysVoteTypeEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsSysVoteTypeEN objSysVoteTypeEN)
{
 if (string.IsNullOrEmpty(objSysVoteTypeEN.VoteTypeId) == true)
 {
string strMsg = string.Format("(errid:Busi000095)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsSysVoteTypeBL.SysVoteTypeDA.UpdateBySql2(objSysVoteTypeEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsSysVoteTypeBL.ReFreshCache();

if (clsSysVoteTypeBL.relatedActions != null)
{
clsSysVoteTypeBL.relatedActions.UpdRelaTabDate(objSysVoteTypeEN.VoteTypeId, "SetUpdDate");
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
 /// <param name = "objSysVoteTypeEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsSysVoteTypeEN objSysVoteTypeEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (string.IsNullOrEmpty(objSysVoteTypeEN.VoteTypeId) == true)
 {
string strMsg = string.Format("(errid:Busi000087)修改记录时关键字不能为空!(带事务处理)(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsSysVoteTypeBL.SysVoteTypeDA.UpdateBySql2(objSysVoteTypeEN, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsSysVoteTypeBL.ReFreshCache();

if (clsSysVoteTypeBL.relatedActions != null)
{
clsSysVoteTypeBL.relatedActions.UpdRelaTabDate(objSysVoteTypeEN.VoteTypeId, "SetUpdDate");
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
 /// <param name = "objSysVoteTypeEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsSysVoteTypeEN objSysVoteTypeEN, string strWhereCond)
{
try
{
bool bolResult = clsSysVoteTypeBL.SysVoteTypeDA.UpdateBySqlWithCondition(objSysVoteTypeEN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsSysVoteTypeBL.ReFreshCache();

if (clsSysVoteTypeBL.relatedActions != null)
{
clsSysVoteTypeBL.relatedActions.UpdRelaTabDate(objSysVoteTypeEN.VoteTypeId, "SetUpdDate");
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
 /// <param name = "objSysVoteTypeEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsSysVoteTypeEN objSysVoteTypeEN, string strWhereCond, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
bool bolResult = clsSysVoteTypeBL.SysVoteTypeDA.UpdateBySqlWithConditionTransaction(objSysVoteTypeEN, strWhereCond, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsSysVoteTypeBL.ReFreshCache();

if (clsSysVoteTypeBL.relatedActions != null)
{
clsSysVoteTypeBL.relatedActions.UpdRelaTabDate(objSysVoteTypeEN.VoteTypeId, "SetUpdDate");
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
 /// <param name = "strVoteTypeId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int Delete(this clsSysVoteTypeEN objSysVoteTypeEN)
{
try
{
int intRecNum = clsSysVoteTypeBL.SysVoteTypeDA.DelRecord(objSysVoteTypeEN.VoteTypeId);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsSysVoteTypeBL.ReFreshCache();

if (clsSysVoteTypeBL.relatedActions != null)
{
clsSysVoteTypeBL.relatedActions.UpdRelaTabDate(objSysVoteTypeEN.VoteTypeId, "SetUpdDate");
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
 /// <param name = "objSysVoteTypeENS">源对象</param>
 /// <param name = "objSysVoteTypeENT">目标对象</param>
 public static void CopyTo(this clsSysVoteTypeEN objSysVoteTypeENS, clsSysVoteTypeEN objSysVoteTypeENT)
{
try
{
objSysVoteTypeENT.VoteTypeId = objSysVoteTypeENS.VoteTypeId; //点赞类型Id
objSysVoteTypeENT.VoteTypeName = objSysVoteTypeENS.VoteTypeName; //点赞类型名称
objSysVoteTypeENT.VoteTable = objSysVoteTypeENS.VoteTable; //点赞表
objSysVoteTypeENT.VoteTableId = objSysVoteTypeENS.VoteTableId; //点赞表Id
objSysVoteTypeENT.Memo = objSysVoteTypeENS.Memo; //备注
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
 /// <param name = "objSysVoteTypeENS">源对象</param>
 /// <returns>目标对象=>clsSysVoteTypeEN:objSysVoteTypeENT</returns>
 public static clsSysVoteTypeEN CopyTo(this clsSysVoteTypeEN objSysVoteTypeENS)
{
try
{
 clsSysVoteTypeEN objSysVoteTypeENT = new clsSysVoteTypeEN()
{
VoteTypeId = objSysVoteTypeENS.VoteTypeId, //点赞类型Id
VoteTypeName = objSysVoteTypeENS.VoteTypeName, //点赞类型名称
VoteTable = objSysVoteTypeENS.VoteTable, //点赞表
VoteTableId = objSysVoteTypeENS.VoteTableId, //点赞表Id
Memo = objSysVoteTypeENS.Memo, //备注
};
 return objSysVoteTypeENT;
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
public static void CheckPropertyNew(this clsSysVoteTypeEN objSysVoteTypeEN)
{
 clsSysVoteTypeBL.SysVoteTypeDA.CheckPropertyNew(objSysVoteTypeEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(this clsSysVoteTypeEN objSysVoteTypeEN)
{
 clsSysVoteTypeBL.SysVoteTypeDA.CheckProperty4Condition(objSysVoteTypeEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsSysVoteTypeEN objSysVoteTypeCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objSysVoteTypeCond.IsUpdated(conSysVoteType.VoteTypeId) == true)
{
string strComparisonOpVoteTypeId = objSysVoteTypeCond.dicFldComparisonOp[conSysVoteType.VoteTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conSysVoteType.VoteTypeId, objSysVoteTypeCond.VoteTypeId, strComparisonOpVoteTypeId);
}
if (objSysVoteTypeCond.IsUpdated(conSysVoteType.VoteTypeName) == true)
{
string strComparisonOpVoteTypeName = objSysVoteTypeCond.dicFldComparisonOp[conSysVoteType.VoteTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", conSysVoteType.VoteTypeName, objSysVoteTypeCond.VoteTypeName, strComparisonOpVoteTypeName);
}
if (objSysVoteTypeCond.IsUpdated(conSysVoteType.VoteTable) == true)
{
string strComparisonOpVoteTable = objSysVoteTypeCond.dicFldComparisonOp[conSysVoteType.VoteTable];
strWhereCond += string.Format(" And {0} {2} '{1}'", conSysVoteType.VoteTable, objSysVoteTypeCond.VoteTable, strComparisonOpVoteTable);
}
if (objSysVoteTypeCond.IsUpdated(conSysVoteType.VoteTableId) == true)
{
string strComparisonOpVoteTableId = objSysVoteTypeCond.dicFldComparisonOp[conSysVoteType.VoteTableId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conSysVoteType.VoteTableId, objSysVoteTypeCond.VoteTableId, strComparisonOpVoteTableId);
}
if (objSysVoteTypeCond.IsUpdated(conSysVoteType.Memo) == true)
{
string strComparisonOpMemo = objSysVoteTypeCond.dicFldComparisonOp[conSysVoteType.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", conSysVoteType.Memo, objSysVoteTypeCond.Memo, strComparisonOpMemo);
}
 return strWhereCond;
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_SysVoteType
{
public virtual bool UpdRelaTabDate(string strVoteTypeId, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// 根据表内容设置enum列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GeneEnumConstList)
 /// </summary>
public class enumSysVoteType
{
 /// <summary>
 /// 论文
 /// </summary>
public const string Paper_01 = "01";
 /// <summary>
 /// 论文子观点
 /// </summary>
public const string PaperSubViewpoint_02 = "02";
 /// <summary>
 /// 个人观点
 /// </summary>
public const string Viewpoint_03 = "03";
 /// <summary>
 /// 专家观点
 /// </summary>
public const string Viewpoint_04 = "04";
 /// <summary>
 /// 主题概念
 /// </summary>
public const string Concept_05 = "05";
 /// <summary>
 /// 客观事实
 /// </summary>
public const string TopicObjective_06 = "06";
 /// <summary>
 /// 客观数据
 /// </summary>
public const string TopicObjective_07 = "07";
 /// <summary>
 /// 人员
 /// </summary>
public const string User_08 = "08";
 /// <summary>
 /// 技能
 /// </summary>
public const string SysSkill_09 = "09";
 /// <summary>
 /// 社会关系
 /// </summary>
public const string SysSocialRelations_10 = "10";
 /// <summary>
 /// 答疑提问
 /// </summary>
public const string qa_Questions_11 = "11";
 /// <summary>
 /// 答疑回答
 /// </summary>
public const string qa_Answer_12 = "12";
 /// <summary>
 /// 中学课件
 /// </summary>
public const string zx_Text_21 = "21";
 /// <summary>
 /// 中学个人观点
 /// </summary>
public const string zx_Viewpoint_22 = "22";
 /// <summary>
 /// 中学专家观点
 /// </summary>
public const string zx_Viewpoint_23 = "23";
 /// <summary>
 /// 中学概念
 /// </summary>
public const string zx_Concept_24 = "24";
 /// <summary>
 /// 中学客观事实
 /// </summary>
public const string zx_TopicObjective_25 = "25";
 /// <summary>
 /// 中学客观数据
 /// </summary>
public const string zx_TopicObjective_26 = "26";
 /// <summary>
 /// 中学技能
 /// </summary>
public const string zx_Skill_27 = "27";
 /// <summary>
 /// 中学社会关系
 /// </summary>
public const string zx_SocialRelations_28 = "28";
}
 /// <summary>
 /// 系统点赞类型(SysVoteType)
 /// 数据源类型:表
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsSysVoteTypeBL
{
public static RelatedActions_SysVoteType relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsSysVoteTypeDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsSysVoteTypeDA SysVoteTypeDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsSysVoteTypeDA();
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
 public clsSysVoteTypeBL()
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
if (string.IsNullOrEmpty(clsSysVoteTypeEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsSysVoteTypeEN._ConnectString);
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
public static DataTable GetDataTable_SysVoteType(string strWhereCond)
{
DataTable objDT;
try
{
objDT = SysVoteTypeDA.GetDataTable_SysVoteType(strWhereCond);
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
objDT = SysVoteTypeDA.GetDataTable(strWhereCond);
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
objDT = SysVoteTypeDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = SysVoteTypeDA.GetDataTable(strWhereCond, strTabName);
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
objDT = SysVoteTypeDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = SysVoteTypeDA.GetDataTable_Top(objTopPara);
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
objDT = SysVoteTypeDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = SysVoteTypeDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = SysVoteTypeDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
 /// <param name = "arrVoteTypeIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static List<clsSysVoteTypeEN> GetObjLstByVoteTypeIdLst(List<string> arrVoteTypeIdLst)
{
List<clsSysVoteTypeEN> arrObjLst = new List<clsSysVoteTypeEN>(); 
System.Data.DataTable objDT; 
 string strSqlConditionStr = clsArray.GetSqlInStrByArray(arrVoteTypeIdLst, true);
 string strWhereCond = string.Format("VoteTypeId in ({0})", strSqlConditionStr);
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsSysVoteTypeEN objSysVoteTypeEN = new clsSysVoteTypeEN();
try
{
objSysVoteTypeEN.VoteTypeId = objRow[conSysVoteType.VoteTypeId].ToString().Trim(); //点赞类型Id
objSysVoteTypeEN.VoteTypeName = objRow[conSysVoteType.VoteTypeName] == DBNull.Value ? null : objRow[conSysVoteType.VoteTypeName].ToString().Trim(); //点赞类型名称
objSysVoteTypeEN.VoteTable = objRow[conSysVoteType.VoteTable] == DBNull.Value ? null : objRow[conSysVoteType.VoteTable].ToString().Trim(); //点赞表
objSysVoteTypeEN.VoteTableId = objRow[conSysVoteType.VoteTableId] == DBNull.Value ? null : objRow[conSysVoteType.VoteTableId].ToString().Trim(); //点赞表Id
objSysVoteTypeEN.Memo = objRow[conSysVoteType.Memo] == DBNull.Value ? null : objRow[conSysVoteType.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objSysVoteTypeEN.VoteTypeId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objSysVoteTypeEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrVoteTypeIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsSysVoteTypeEN> GetObjLstByVoteTypeIdLstCache(List<string> arrVoteTypeIdLst)
{
string strKey = string.Format("{0}", clsSysVoteTypeEN._CurrTabName);
List<clsSysVoteTypeEN> arrSysVoteTypeObjLstCache = GetObjLstCache();
IEnumerable <clsSysVoteTypeEN> arrSysVoteTypeObjLst_Sel =
arrSysVoteTypeObjLstCache
.Where(x => arrVoteTypeIdLst.Contains(x.VoteTypeId));
return arrSysVoteTypeObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsSysVoteTypeEN> GetObjLst(string strWhereCond)
{
List<clsSysVoteTypeEN> arrObjLst = new List<clsSysVoteTypeEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsSysVoteTypeEN objSysVoteTypeEN = new clsSysVoteTypeEN();
try
{
objSysVoteTypeEN.VoteTypeId = objRow[conSysVoteType.VoteTypeId].ToString().Trim(); //点赞类型Id
objSysVoteTypeEN.VoteTypeName = objRow[conSysVoteType.VoteTypeName] == DBNull.Value ? null : objRow[conSysVoteType.VoteTypeName].ToString().Trim(); //点赞类型名称
objSysVoteTypeEN.VoteTable = objRow[conSysVoteType.VoteTable] == DBNull.Value ? null : objRow[conSysVoteType.VoteTable].ToString().Trim(); //点赞表
objSysVoteTypeEN.VoteTableId = objRow[conSysVoteType.VoteTableId] == DBNull.Value ? null : objRow[conSysVoteType.VoteTableId].ToString().Trim(); //点赞表Id
objSysVoteTypeEN.Memo = objRow[conSysVoteType.Memo] == DBNull.Value ? null : objRow[conSysVoteType.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objSysVoteTypeEN.VoteTypeId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objSysVoteTypeEN);
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
public static List<clsSysVoteTypeEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsSysVoteTypeEN> arrObjLst = new List<clsSysVoteTypeEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsSysVoteTypeEN objSysVoteTypeEN = new clsSysVoteTypeEN();
try
{
objSysVoteTypeEN.VoteTypeId = objRow[conSysVoteType.VoteTypeId].ToString().Trim(); //点赞类型Id
objSysVoteTypeEN.VoteTypeName = objRow[conSysVoteType.VoteTypeName] == DBNull.Value ? null : objRow[conSysVoteType.VoteTypeName].ToString().Trim(); //点赞类型名称
objSysVoteTypeEN.VoteTable = objRow[conSysVoteType.VoteTable] == DBNull.Value ? null : objRow[conSysVoteType.VoteTable].ToString().Trim(); //点赞表
objSysVoteTypeEN.VoteTableId = objRow[conSysVoteType.VoteTableId] == DBNull.Value ? null : objRow[conSysVoteType.VoteTableId].ToString().Trim(); //点赞表Id
objSysVoteTypeEN.Memo = objRow[conSysVoteType.Memo] == DBNull.Value ? null : objRow[conSysVoteType.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objSysVoteTypeEN.VoteTypeId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objSysVoteTypeEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objSysVoteTypeCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsSysVoteTypeEN> GetSubObjLstCache(clsSysVoteTypeEN objSysVoteTypeCond)
{
List<clsSysVoteTypeEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsSysVoteTypeEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conSysVoteType.AttributeName)
{
if (objSysVoteTypeCond.IsUpdated(strFldName) == false) continue;
if (objSysVoteTypeCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objSysVoteTypeCond[strFldName].ToString());
}
else
{
if (objSysVoteTypeCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objSysVoteTypeCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objSysVoteTypeCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objSysVoteTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objSysVoteTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objSysVoteTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objSysVoteTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objSysVoteTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objSysVoteTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objSysVoteTypeCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objSysVoteTypeCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objSysVoteTypeCond[strFldName]));
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
public static List<clsSysVoteTypeEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsSysVoteTypeEN> arrObjLst = new List<clsSysVoteTypeEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsSysVoteTypeEN objSysVoteTypeEN = new clsSysVoteTypeEN();
try
{
objSysVoteTypeEN.VoteTypeId = objRow[conSysVoteType.VoteTypeId].ToString().Trim(); //点赞类型Id
objSysVoteTypeEN.VoteTypeName = objRow[conSysVoteType.VoteTypeName] == DBNull.Value ? null : objRow[conSysVoteType.VoteTypeName].ToString().Trim(); //点赞类型名称
objSysVoteTypeEN.VoteTable = objRow[conSysVoteType.VoteTable] == DBNull.Value ? null : objRow[conSysVoteType.VoteTable].ToString().Trim(); //点赞表
objSysVoteTypeEN.VoteTableId = objRow[conSysVoteType.VoteTableId] == DBNull.Value ? null : objRow[conSysVoteType.VoteTableId].ToString().Trim(); //点赞表Id
objSysVoteTypeEN.Memo = objRow[conSysVoteType.Memo] == DBNull.Value ? null : objRow[conSysVoteType.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objSysVoteTypeEN.VoteTypeId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objSysVoteTypeEN);
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
public static List<clsSysVoteTypeEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsSysVoteTypeEN> arrObjLst = new List<clsSysVoteTypeEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsSysVoteTypeEN objSysVoteTypeEN = new clsSysVoteTypeEN();
try
{
objSysVoteTypeEN.VoteTypeId = objRow[conSysVoteType.VoteTypeId].ToString().Trim(); //点赞类型Id
objSysVoteTypeEN.VoteTypeName = objRow[conSysVoteType.VoteTypeName] == DBNull.Value ? null : objRow[conSysVoteType.VoteTypeName].ToString().Trim(); //点赞类型名称
objSysVoteTypeEN.VoteTable = objRow[conSysVoteType.VoteTable] == DBNull.Value ? null : objRow[conSysVoteType.VoteTable].ToString().Trim(); //点赞表
objSysVoteTypeEN.VoteTableId = objRow[conSysVoteType.VoteTableId] == DBNull.Value ? null : objRow[conSysVoteType.VoteTableId].ToString().Trim(); //点赞表Id
objSysVoteTypeEN.Memo = objRow[conSysVoteType.Memo] == DBNull.Value ? null : objRow[conSysVoteType.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objSysVoteTypeEN.VoteTypeId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objSysVoteTypeEN);
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
List<clsSysVoteTypeEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsSysVoteTypeEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsSysVoteTypeEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsSysVoteTypeEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsSysVoteTypeEN> arrObjLst = new List<clsSysVoteTypeEN>(); 
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
	clsSysVoteTypeEN objSysVoteTypeEN = new clsSysVoteTypeEN();
try
{
objSysVoteTypeEN.VoteTypeId = objRow[conSysVoteType.VoteTypeId].ToString().Trim(); //点赞类型Id
objSysVoteTypeEN.VoteTypeName = objRow[conSysVoteType.VoteTypeName] == DBNull.Value ? null : objRow[conSysVoteType.VoteTypeName].ToString().Trim(); //点赞类型名称
objSysVoteTypeEN.VoteTable = objRow[conSysVoteType.VoteTable] == DBNull.Value ? null : objRow[conSysVoteType.VoteTable].ToString().Trim(); //点赞表
objSysVoteTypeEN.VoteTableId = objRow[conSysVoteType.VoteTableId] == DBNull.Value ? null : objRow[conSysVoteType.VoteTableId].ToString().Trim(); //点赞表Id
objSysVoteTypeEN.Memo = objRow[conSysVoteType.Memo] == DBNull.Value ? null : objRow[conSysVoteType.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objSysVoteTypeEN.VoteTypeId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objSysVoteTypeEN);
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
public static List<clsSysVoteTypeEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsSysVoteTypeEN> arrObjLst = new List<clsSysVoteTypeEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsSysVoteTypeEN objSysVoteTypeEN = new clsSysVoteTypeEN();
try
{
objSysVoteTypeEN.VoteTypeId = objRow[conSysVoteType.VoteTypeId].ToString().Trim(); //点赞类型Id
objSysVoteTypeEN.VoteTypeName = objRow[conSysVoteType.VoteTypeName] == DBNull.Value ? null : objRow[conSysVoteType.VoteTypeName].ToString().Trim(); //点赞类型名称
objSysVoteTypeEN.VoteTable = objRow[conSysVoteType.VoteTable] == DBNull.Value ? null : objRow[conSysVoteType.VoteTable].ToString().Trim(); //点赞表
objSysVoteTypeEN.VoteTableId = objRow[conSysVoteType.VoteTableId] == DBNull.Value ? null : objRow[conSysVoteType.VoteTableId].ToString().Trim(); //点赞表Id
objSysVoteTypeEN.Memo = objRow[conSysVoteType.Memo] == DBNull.Value ? null : objRow[conSysVoteType.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objSysVoteTypeEN.VoteTypeId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objSysVoteTypeEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsSysVoteTypeEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsSysVoteTypeEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsSysVoteTypeEN> arrObjLst = new List<clsSysVoteTypeEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsSysVoteTypeEN objSysVoteTypeEN = new clsSysVoteTypeEN();
try
{
objSysVoteTypeEN.VoteTypeId = objRow[conSysVoteType.VoteTypeId].ToString().Trim(); //点赞类型Id
objSysVoteTypeEN.VoteTypeName = objRow[conSysVoteType.VoteTypeName] == DBNull.Value ? null : objRow[conSysVoteType.VoteTypeName].ToString().Trim(); //点赞类型名称
objSysVoteTypeEN.VoteTable = objRow[conSysVoteType.VoteTable] == DBNull.Value ? null : objRow[conSysVoteType.VoteTable].ToString().Trim(); //点赞表
objSysVoteTypeEN.VoteTableId = objRow[conSysVoteType.VoteTableId] == DBNull.Value ? null : objRow[conSysVoteType.VoteTableId].ToString().Trim(); //点赞表Id
objSysVoteTypeEN.Memo = objRow[conSysVoteType.Memo] == DBNull.Value ? null : objRow[conSysVoteType.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objSysVoteTypeEN.VoteTypeId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objSysVoteTypeEN);
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
public static List<clsSysVoteTypeEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsSysVoteTypeEN> arrObjLst = new List<clsSysVoteTypeEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsSysVoteTypeEN objSysVoteTypeEN = new clsSysVoteTypeEN();
try
{
objSysVoteTypeEN.VoteTypeId = objRow[conSysVoteType.VoteTypeId].ToString().Trim(); //点赞类型Id
objSysVoteTypeEN.VoteTypeName = objRow[conSysVoteType.VoteTypeName] == DBNull.Value ? null : objRow[conSysVoteType.VoteTypeName].ToString().Trim(); //点赞类型名称
objSysVoteTypeEN.VoteTable = objRow[conSysVoteType.VoteTable] == DBNull.Value ? null : objRow[conSysVoteType.VoteTable].ToString().Trim(); //点赞表
objSysVoteTypeEN.VoteTableId = objRow[conSysVoteType.VoteTableId] == DBNull.Value ? null : objRow[conSysVoteType.VoteTableId].ToString().Trim(); //点赞表Id
objSysVoteTypeEN.Memo = objRow[conSysVoteType.Memo] == DBNull.Value ? null : objRow[conSysVoteType.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objSysVoteTypeEN.VoteTypeId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objSysVoteTypeEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsSysVoteTypeEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsSysVoteTypeEN> arrObjLst = new List<clsSysVoteTypeEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsSysVoteTypeEN objSysVoteTypeEN = new clsSysVoteTypeEN();
try
{
objSysVoteTypeEN.VoteTypeId = objRow[conSysVoteType.VoteTypeId].ToString().Trim(); //点赞类型Id
objSysVoteTypeEN.VoteTypeName = objRow[conSysVoteType.VoteTypeName] == DBNull.Value ? null : objRow[conSysVoteType.VoteTypeName].ToString().Trim(); //点赞类型名称
objSysVoteTypeEN.VoteTable = objRow[conSysVoteType.VoteTable] == DBNull.Value ? null : objRow[conSysVoteType.VoteTable].ToString().Trim(); //点赞表
objSysVoteTypeEN.VoteTableId = objRow[conSysVoteType.VoteTableId] == DBNull.Value ? null : objRow[conSysVoteType.VoteTableId].ToString().Trim(); //点赞表Id
objSysVoteTypeEN.Memo = objRow[conSysVoteType.Memo] == DBNull.Value ? null : objRow[conSysVoteType.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objSysVoteTypeEN.VoteTypeId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objSysVoteTypeEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objSysVoteTypeEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetSysVoteType(ref clsSysVoteTypeEN objSysVoteTypeEN)
{
bool bolResult = SysVoteTypeDA.GetSysVoteType(ref objSysVoteTypeEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "strVoteTypeId">表关键字</param>
 /// <returns>表对象</returns>
public static clsSysVoteTypeEN GetObjByVoteTypeId(string strVoteTypeId)
{
if (strVoteTypeId.IndexOf(' ') >=0)
{
var strMsg = string.Format("(errid:Busi000079)在表中,关键字[strVoteTypeId]中不能有空格!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
if (string.IsNullOrEmpty(strVoteTypeId) == true)
{
var strMsg = string.Format("(errid:Busi000020)在表中,关键字[strVoteTypeId]不能为空!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
clsSysVoteTypeEN objSysVoteTypeEN = SysVoteTypeDA.GetObjByVoteTypeId(strVoteTypeId);
return objSysVoteTypeEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsSysVoteTypeEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsSysVoteTypeEN objSysVoteTypeEN = SysVoteTypeDA.GetFirstObj(strWhereCond);
 return objSysVoteTypeEN;
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
public static clsSysVoteTypeEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsSysVoteTypeEN objSysVoteTypeEN = SysVoteTypeDA.GetObjByDataRow(objRow);
 return objSysVoteTypeEN;
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
public static clsSysVoteTypeEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsSysVoteTypeEN objSysVoteTypeEN = SysVoteTypeDA.GetObjByDataRow(objRow);
 return objSysVoteTypeEN;
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
 /// <param name = "strVoteTypeId">所给的关键字</param>
 /// <param name = "lstSysVoteTypeObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsSysVoteTypeEN GetObjByVoteTypeIdFromList(string strVoteTypeId, List<clsSysVoteTypeEN> lstSysVoteTypeObjLst)
{
foreach (clsSysVoteTypeEN objSysVoteTypeEN in lstSysVoteTypeObjLst)
{
if (objSysVoteTypeEN.VoteTypeId == strVoteTypeId)
{
return objSysVoteTypeEN;
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
 string strVoteTypeId;
 try
 {
 strVoteTypeId = new clsSysVoteTypeDA().GetFirstID(strWhereCond);
 return strVoteTypeId;
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
 arrList = SysVoteTypeDA.GetID(strWhereCond);
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
bool bolIsExist = SysVoteTypeDA.IsExistCondRec(strWhereCond);
return bolIsExist;
}

 /// <summary>
 /// 判断当前表中是否存在给定关键字值的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExist)
 /// </summary>
 /// <param name = "strVoteTypeId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public static bool IsExist(string strVoteTypeId)
{
if (string.IsNullOrEmpty(strVoteTypeId) == true)
{
var strMsg = string.Format("(errid:Busi000027)在表中,关键字[strVoteTypeId]不能为空!!(from {0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
//检测记录是否存在
bool bolIsExist = SysVoteTypeDA.IsExist(strVoteTypeId);
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
 bolIsExist = clsSysVoteTypeDA.IsExistTable();
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
 bolIsExist = SysVoteTypeDA.IsExistTable(strTabName);
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
 /// <param name = "objSysVoteTypeEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecordBySql2(clsSysVoteTypeEN objSysVoteTypeEN, bool bolIsNeedCheckUniqueness=true)
{
 if (string.IsNullOrEmpty(objSysVoteTypeEN.VoteTypeId) == true)
 {
string strMsg = string.Format("添加记录时,关键字不能为空!(from {0})\r\n", 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
 if (clsSysVoteTypeBL.IsExist(objSysVoteTypeEN.VoteTypeId) == true)
 {
string strMsg = string.Format("添加记录时,关键字:[{0}]已经存在!(from {1})\r\n", objSysVoteTypeEN.VoteTypeId, 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
try
{
bool bolResult = SysVoteTypeDA.AddNewRecordBySQL2(objSysVoteTypeEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsSysVoteTypeBL.ReFreshCache();

if (clsSysVoteTypeBL.relatedActions != null)
{
clsSysVoteTypeBL.relatedActions.UpdRelaTabDate(objSysVoteTypeEN.VoteTypeId, "SetUpdDate");
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
 /// <param name = "objSysVoteTypeEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordBySql2WithReturnKey(clsSysVoteTypeEN objSysVoteTypeEN, bool bolIsNeedCheckUniqueness=true)
{
 if (string.IsNullOrEmpty(objSysVoteTypeEN.VoteTypeId) == true)
 {
string strMsg = string.Format("添加记录时,关键字不能为空!(from {{0}})", 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
 if (clsSysVoteTypeBL.IsExist(objSysVoteTypeEN.VoteTypeId) == true)
 {
string strMsg = string.Format("添加记录时,关键字:[{0}]已经存在!(from {1})\r\n", objSysVoteTypeEN.VoteTypeId, 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
try
{
string strKey = SysVoteTypeDA.AddNewRecordBySQL2WithReturnKey(objSysVoteTypeEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsSysVoteTypeBL.ReFreshCache();

if (clsSysVoteTypeBL.relatedActions != null)
{
clsSysVoteTypeBL.relatedActions.UpdRelaTabDate(objSysVoteTypeEN.VoteTypeId, "SetUpdDate");
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
 /// <param name = "objSysVoteTypeEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(clsSysVoteTypeEN objSysVoteTypeEN)
{
try
{
bool bolResult = SysVoteTypeDA.Update(objSysVoteTypeEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsSysVoteTypeBL.ReFreshCache();

if (clsSysVoteTypeBL.relatedActions != null)
{
clsSysVoteTypeBL.relatedActions.UpdRelaTabDate(objSysVoteTypeEN.VoteTypeId, "SetUpdDate");
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
 /// <param name = "objSysVoteTypeEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateBySql2(clsSysVoteTypeEN objSysVoteTypeEN)
{
 if (string.IsNullOrEmpty(objSysVoteTypeEN.VoteTypeId) == true)
 {
var strMsg = string.Format("(errid:Busi000065)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = SysVoteTypeDA.UpdateBySql2(objSysVoteTypeEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsSysVoteTypeBL.ReFreshCache();

if (clsSysVoteTypeBL.relatedActions != null)
{
clsSysVoteTypeBL.relatedActions.UpdRelaTabDate(objSysVoteTypeEN.VoteTypeId, "SetUpdDate");
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
 /// <param name = "strVoteTypeId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int DelRecord(string strVoteTypeId)
{
try
{
 clsSysVoteTypeEN objSysVoteTypeEN = clsSysVoteTypeBL.GetObjByVoteTypeId(strVoteTypeId);

if (clsSysVoteTypeBL.relatedActions != null)
{
clsSysVoteTypeBL.relatedActions.UpdRelaTabDate(objSysVoteTypeEN.VoteTypeId, "SetUpdDate");
}
if (objSysVoteTypeEN != null)
{
int intRecNum = SysVoteTypeDA.DelRecord(strVoteTypeId);
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
/// <param name="strVoteTypeId">表关键字</param>
/// <returns></returns>
public static bool DelRecordEx(string strVoteTypeId )
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsSysVoteTypeDA.GetSpecSQLObj();
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
//删除与表:[SysVoteType]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conSysVoteType.VoteTypeId,
//strVoteTypeId);
//        clsSysVoteTypeBL.DelSysVoteTypesByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsSysVoteTypeBL.DelRecord(strVoteTypeId, objConnection, objSqlTransaction);
objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsSysVoteTypeBLEx", "DelRecordEx", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("扩展删除记录出错:{0}!keyId = {1}.({2})",
objException.Message,
strVoteTypeId, clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "strVoteTypeId">给定的关键字值</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回删除是否成功?</returns>
public static bool DelRecord(string strVoteTypeId, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
if (clsSysVoteTypeBL.relatedActions != null)
{
clsSysVoteTypeBL.relatedActions.UpdRelaTabDate(strVoteTypeId, "UpdRelaTabDate");
}
bool bolResult = SysVoteTypeDA.DelRecord(strVoteTypeId,objSqlConnection,objSqlTransaction);
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
 /// <param name = "arrVoteTypeIdLst">给定的关键字值列表</param>
 /// <returns>返回删除的记录数</returns>
public static int DelSysVoteTypes(List<string> arrVoteTypeIdLst)
{
if (arrVoteTypeIdLst.Count == 0) return 0;
try
{
if (clsSysVoteTypeBL.relatedActions != null)
{
foreach (var strVoteTypeId in arrVoteTypeIdLst)
{
clsSysVoteTypeBL.relatedActions.UpdRelaTabDate(strVoteTypeId, "UpdRelaTabDate");
}
}
int intDelRecNum = SysVoteTypeDA.DelSysVoteType(arrVoteTypeIdLst);
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
public static int DelSysVoteTypesByCond(string strWhereCond)
{
try
{
if (clsSysVoteTypeBL.relatedActions != null)
{
List<string> arrVoteTypeId = GetPrimaryKeyID_S(strWhereCond);
foreach (var strVoteTypeId in arrVoteTypeId)
{
clsSysVoteTypeBL.relatedActions.UpdRelaTabDate(strVoteTypeId, "UpdRelaTabDate");
}
}
int intRecNum = SysVoteTypeDA.DelSysVoteType(strWhereCond);
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
/// 这里仅仅是演示函数,使用时请复制到扩展类:[SysVoteType]中改名为:[DelRecord4MultiTabEx]使用
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DelRecord4MultiTab)
/// </summary>
/// <param name="strVoteTypeId">表关键字</param>
/// <returns></returns>
public static bool DelRecord4MultiTab(string strVoteTypeId)
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsSysVoteTypeDA.GetSpecSQLObj();
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
//删除与表:[SysVoteType]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conStudent.id_College,
//strid_College);
//        clsStudentBL.DelStudentsByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsSysVoteTypeBL.DelRecord(strVoteTypeId, objConnection, objSqlTransaction);
                objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsSysVoteTypeBL", "DelRecord4MultiTab", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("删除多表记录出错:{0}!keyId = {1}.({2})",
objException.Message,
strVoteTypeId, clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "objSysVoteTypeENS">源对象</param>
 /// <param name = "objSysVoteTypeENT">目标对象</param>
 public static void CopyTo(clsSysVoteTypeEN objSysVoteTypeENS, clsSysVoteTypeEN objSysVoteTypeENT)
{
try
{
objSysVoteTypeENT.VoteTypeId = objSysVoteTypeENS.VoteTypeId; //点赞类型Id
objSysVoteTypeENT.VoteTypeName = objSysVoteTypeENS.VoteTypeName; //点赞类型名称
objSysVoteTypeENT.VoteTable = objSysVoteTypeENS.VoteTable; //点赞表
objSysVoteTypeENT.VoteTableId = objSysVoteTypeENS.VoteTableId; //点赞表Id
objSysVoteTypeENT.Memo = objSysVoteTypeENS.Memo; //备注
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
 /// <param name = "objSysVoteTypeEN">源简化对象</param>
 public static void SetUpdFlag(clsSysVoteTypeEN objSysVoteTypeEN)
{
try
{
objSysVoteTypeEN.ClearUpdateState();
   string strsfUpdFldSetStr = objSysVoteTypeEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(conSysVoteType.VoteTypeId, new clsStrCompareIgnoreCase())  ==  true)
{
objSysVoteTypeEN.VoteTypeId = objSysVoteTypeEN.VoteTypeId; //点赞类型Id
}
if (arrFldSet.Contains(conSysVoteType.VoteTypeName, new clsStrCompareIgnoreCase())  ==  true)
{
objSysVoteTypeEN.VoteTypeName = objSysVoteTypeEN.VoteTypeName == "[null]" ? null :  objSysVoteTypeEN.VoteTypeName; //点赞类型名称
}
if (arrFldSet.Contains(conSysVoteType.VoteTable, new clsStrCompareIgnoreCase())  ==  true)
{
objSysVoteTypeEN.VoteTable = objSysVoteTypeEN.VoteTable == "[null]" ? null :  objSysVoteTypeEN.VoteTable; //点赞表
}
if (arrFldSet.Contains(conSysVoteType.VoteTableId, new clsStrCompareIgnoreCase())  ==  true)
{
objSysVoteTypeEN.VoteTableId = objSysVoteTypeEN.VoteTableId == "[null]" ? null :  objSysVoteTypeEN.VoteTableId; //点赞表Id
}
if (arrFldSet.Contains(conSysVoteType.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objSysVoteTypeEN.Memo = objSysVoteTypeEN.Memo == "[null]" ? null :  objSysVoteTypeEN.Memo; //备注
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
 /// <param name = "objSysVoteTypeEN">源简化对象</param>
 public static void AccessFldValueNull(clsSysVoteTypeEN objSysVoteTypeEN)
{
try
{
if (objSysVoteTypeEN.VoteTypeName == "[null]") objSysVoteTypeEN.VoteTypeName = null; //点赞类型名称
if (objSysVoteTypeEN.VoteTable == "[null]") objSysVoteTypeEN.VoteTable = null; //点赞表
if (objSysVoteTypeEN.VoteTableId == "[null]") objSysVoteTypeEN.VoteTableId = null; //点赞表Id
if (objSysVoteTypeEN.Memo == "[null]") objSysVoteTypeEN.Memo = null; //备注
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
public static void CheckPropertyNew(clsSysVoteTypeEN objSysVoteTypeEN)
{
 SysVoteTypeDA.CheckPropertyNew(objSysVoteTypeEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(clsSysVoteTypeEN objSysVoteTypeEN)
{
 SysVoteTypeDA.CheckProperty4Condition(objSysVoteTypeEN);
 }


 #endregion 检查对象属性


 #region 绑定下拉框

 /// <summary>
 /// 绑定基于Web的下拉框-使用Cache
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DdlBindFunctionCache)
 /// </summary>
 /// <param name = "objDDL">需要绑定当前表的下拉框</param>
public static void BindDdl_VoteTypeIdCache(System.Web.UI.WebControls.DropDownList objDDL)
{
//为数据源于表的下拉框设置内容
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[系统点赞类型]...","0");
List<clsSysVoteTypeEN> arrSysVoteTypeObjLst = GetAllSysVoteTypeObjLstCache(); 
objDDL.DataValueField = conSysVoteType.VoteTypeId;
objDDL.DataTextField = conSysVoteType.VoteTypeName;
objDDL.DataSource = arrSysVoteTypeObjLst;
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
if (clsSysVoteTypeBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsSysVoteTypeBL没有刷新缓存机制(clsSysVoteTypeBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by VoteTypeId");
//if (arrSysVoteTypeObjLstCache == null)
//{
//arrSysVoteTypeObjLstCache = SysVoteTypeDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "strVoteTypeId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsSysVoteTypeEN GetObjByVoteTypeIdCache(string strVoteTypeId)
{
//获取缓存中的对象列表
string strKey = string.Format("{0}", clsSysVoteTypeEN._CurrTabName);
List<clsSysVoteTypeEN> arrSysVoteTypeObjLstCache = GetObjLstCache();
IEnumerable <clsSysVoteTypeEN> arrSysVoteTypeObjLst_Sel =
arrSysVoteTypeObjLstCache
.Where(x=> x.VoteTypeId == strVoteTypeId 
);
if (arrSysVoteTypeObjLst_Sel.Count() == 0)
{
   clsSysVoteTypeEN obj = clsSysVoteTypeBL.GetObjByVoteTypeId(strVoteTypeId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
 }
return null;
}
return arrSysVoteTypeObjLst_Sel.First();
}

 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecNameByKeyCache)
 /// </summary>
 /// <param name = "strVoteTypeId">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetVoteTypeNameByVoteTypeIdCache(string strVoteTypeId)
{
if (string.IsNullOrEmpty(strVoteTypeId) == true) return "";
//获取缓存中的对象列表
clsSysVoteTypeEN objSysVoteType = GetObjByVoteTypeIdCache(strVoteTypeId);
if (objSysVoteType == null) return "";
return objSysVoteType.VoteTypeName;
}
 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecNameByKeyCache)
 /// </summary>
 /// <param name = "strVoteTypeId">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetNameByVoteTypeIdCache(string strVoteTypeId)
{
if (string.IsNullOrEmpty(strVoteTypeId) == true) return "";
//获取缓存中的对象列表
clsSysVoteTypeEN objSysVoteType = GetObjByVoteTypeIdCache(strVoteTypeId);
if (objSysVoteType == null) return "";
return objSysVoteType.VoteTypeName;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsSysVoteTypeEN> GetAllSysVoteTypeObjLstCache()
{
//获取缓存中的对象列表
List<clsSysVoteTypeEN> arrSysVoteTypeObjLstCache = GetObjLstCache(); 
return arrSysVoteTypeObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsSysVoteTypeEN> GetObjLstCache()
{
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}", clsSysVoteTypeEN._CurrTabName);
List<clsSysVoteTypeEN> arrSysVoteTypeObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrSysVoteTypeObjLstCache;
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
string strKey = string.Format("{0}", clsSysVoteTypeEN._CurrTabName);
CacheHelper.Remove(strKey);
clsSysVoteTypeEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
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
if (clsSysVoteTypeEN._RefreshTimeLst.Count == 0) return "";
return clsSysVoteTypeEN._RefreshTimeLst[clsSysVoteTypeEN._RefreshTimeLst.Count - 1];
}

 /// <summary>
 /// 刷新缓存.把当前表的缓存以及该表相关视图的缓存清空.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ReFreshCache)
 /// </summary>
public static void ReFreshCache()
{
if (clsSysVoteTypeBL.objCommFun4BL != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}", clsSysVoteTypeEN._CurrTabName);
CacheHelper.Remove(strKey);
clsSysVoteTypeEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
clsSysVoteTypeBL.objCommFun4BL.ReFreshCache();
}
}


 #endregion 缓存操作


 #region 检查唯一性


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
public static string Func(string strInFldName, string strOutFldName, string strVoteTypeId)
{
if (strInFldName != conSysVoteType.VoteTypeId)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (conSysVoteType.AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", conSysVoteType.AttributeName));
throw new Exception(strMsg);
}
var objSysVoteType = clsSysVoteTypeBL.GetObjByVoteTypeIdCache(strVoteTypeId);
if (objSysVoteType == null) return "";
return objSysVoteType[strOutFldName].ToString();
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
int intRecCount = clsSysVoteTypeDA.GetRecCount(strTabName);
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
int intRecCount = clsSysVoteTypeDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsSysVoteTypeDA.GetRecCount();
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
int intRecCount = clsSysVoteTypeDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objSysVoteTypeCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsSysVoteTypeEN objSysVoteTypeCond)
{
List<clsSysVoteTypeEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsSysVoteTypeEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conSysVoteType.AttributeName)
{
if (objSysVoteTypeCond.IsUpdated(strFldName) == false) continue;
if (objSysVoteTypeCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objSysVoteTypeCond[strFldName].ToString());
}
else
{
if (objSysVoteTypeCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objSysVoteTypeCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objSysVoteTypeCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objSysVoteTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objSysVoteTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objSysVoteTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objSysVoteTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objSysVoteTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objSysVoteTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objSysVoteTypeCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objSysVoteTypeCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objSysVoteTypeCond[strFldName]));
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
 List<string> arrList = clsSysVoteTypeDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = SysVoteTypeDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = SysVoteTypeDA.GetFldValueNoDistinct(strFldName, strWhereCond);
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
int intRecCount = SysVoteTypeDA.SetFldValue(strFldName, strValue, strWhereCond);
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
int intRecCount = clsSysVoteTypeDA.SetFldValue(clsSysVoteTypeEN._CurrTabName, strFldName, fltValue, strWhereCond);
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
int intRecCount = SysVoteTypeDA.SetFldValue( strFldName, intValue, strWhereCond);
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
int intRecCount = clsSysVoteTypeDA.SetFldValue(strTabName, strFldName, strValue, strWhereCond);
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
int intRecCount = clsSysVoteTypeDA.SetFldValue(strTabName, strFldName, intValue, strWhereCond);
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
int intRecCount = clsSysVoteTypeDA.SetFldValue(strTabName, strFldName, fltValue, strWhereCond);
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
  strCreateTabCode.Append("CREATE table [dbo].[SysVoteType] "); 
 strCreateTabCode.Append(" ( "); 
 // /**点赞类型Id*/ 
 strCreateTabCode.Append(" VoteTypeId char(2) primary key, "); 
 // /**点赞类型名称*/ 
 strCreateTabCode.Append(" VoteTypeName varchar(100) Null, "); 
 // /**点赞表*/ 
 strCreateTabCode.Append(" VoteTable varchar(100) Null, "); 
 // /**点赞表Id*/ 
 strCreateTabCode.Append(" VoteTableId varchar(50) Null, "); 
 // /**备注*/ 
 strCreateTabCode.Append(" Memo varchar(1000) Null ");
 strCreateTabCode.Append(") "); 
  strCreateTabCode.Append("ON [PRIMARY] ");
  return strCreateTabCode.ToString();
}



 #endregion 表操作
}
 /// <summary>
 /// 系统点赞类型(SysVoteType)
 /// 数据源类型:表
 /// (AutoGCLib.CommFun4BL4CSharp:GeneCode_This)
 /// </summary>
public class  clsCommFun4BL4SysVoteType : clsCommFun4BL
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
clsSysVoteTypeBL.ReFreshThisCache();
}
}

}