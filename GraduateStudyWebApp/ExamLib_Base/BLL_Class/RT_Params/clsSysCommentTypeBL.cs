
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsSysCommentTypeBL
 表名:SysCommentType(01120623)
 * 版本:2024.11.13.1(服务器:WIN-SRV103-116)
 日期:2024/11/13 06:05:33
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
public static class  clsSysCommentTypeBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "strCommentTypeId">表关键字</param>
 /// <returns>表对象</returns>
public static clsSysCommentTypeEN GetObj(this K_CommentTypeId_SysCommentType myKey)
{
clsSysCommentTypeEN objSysCommentTypeEN = clsSysCommentTypeBL.SysCommentTypeDA.GetObjByCommentTypeId(myKey.Value);
return objSysCommentTypeEN;
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_AddNewRecord)
 /// </summary>
 /// <param name = "objSysCommentTypeEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clsSysCommentTypeEN objSysCommentTypeEN, bool bolIsNeedCheckUniqueness = true)
{
 if (string.IsNullOrEmpty(objSysCommentTypeEN.CommentTypeId) == true)
 {
string strMsg = string.Format("添加记录时,关键字不能为空!(from {0})\r\n", 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
 if (clsSysCommentTypeBL.IsExist(objSysCommentTypeEN.CommentTypeId) == true)
 {
string strMsg = string.Format("添加记录时,关键字:[{0}]已经存在!(from {1})\r\n", objSysCommentTypeEN.CommentTypeId, 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
try
{
bool bolResult = clsSysCommentTypeBL.SysCommentTypeDA.AddNewRecordBySQL2(objSysCommentTypeEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsSysCommentTypeBL.ReFreshCache();

if (clsSysCommentTypeBL.relatedActions != null)
{
clsSysCommentTypeBL.relatedActions.UpdRelaTabDate(objSysCommentTypeEN.CommentTypeId, "SetUpdDate");
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
public static bool AddRecordEx(this clsSysCommentTypeEN objSysCommentTypeEN, bool bolIsNeedCheckUniqueness = true)
{
//操作步骤:
//1、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在
//2、检查唯一性
//3、检查传进去的对象属性是否合法
//4、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
//1、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在
if (clsSysCommentTypeBL.IsExist(objSysCommentTypeEN.CommentTypeId))	//判断是否有相同的关键字
{
strMsg = "(errid:Busi000151)关键字字段已有相同的值";
throw new Exception(strMsg);
}
try
{
 //2、检查传进去的对象属性是否合法
objSysCommentTypeEN.CheckPropertyNew();
//6、把数据实体层的数据存贮到数据库中
objSysCommentTypeEN.AddNewRecord();
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
 /// <param name = "objSysCommentTypeEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordWithReturnKey(this clsSysCommentTypeEN objSysCommentTypeEN, bool bolIsNeedCheckUniqueness = true)
{
 if (string.IsNullOrEmpty(objSysCommentTypeEN.CommentTypeId) == true)
 {
string strMsg = string.Format("添加记录时,关键字不能为空!(from {{0}})", 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
 if (clsSysCommentTypeBL.IsExist(objSysCommentTypeEN.CommentTypeId) == true)
 {
string strMsg = string.Format("添加记录时,关键字:[{0}]已经存在!(from {1})\r\n", objSysCommentTypeEN.CommentTypeId, 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
try
{
string strKey = clsSysCommentTypeBL.SysCommentTypeDA.AddNewRecordBySQL2WithReturnKey(objSysCommentTypeEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsSysCommentTypeBL.ReFreshCache();

if (clsSysCommentTypeBL.relatedActions != null)
{
clsSysCommentTypeBL.relatedActions.UpdRelaTabDate(objSysCommentTypeEN.CommentTypeId, "SetUpdDate");
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
 /// <param name = "objSysCommentTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsSysCommentTypeEN SetCommentTypeId(this clsSysCommentTypeEN objSysCommentTypeEN, string strCommentTypeId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCommentTypeId, 2, conSysCommentType.CommentTypeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strCommentTypeId, 2, conSysCommentType.CommentTypeId);
}
objSysCommentTypeEN.CommentTypeId = strCommentTypeId; //评论类型Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objSysCommentTypeEN.dicFldComparisonOp.ContainsKey(conSysCommentType.CommentTypeId) == false)
{
objSysCommentTypeEN.dicFldComparisonOp.Add(conSysCommentType.CommentTypeId, strComparisonOp);
}
else
{
objSysCommentTypeEN.dicFldComparisonOp[conSysCommentType.CommentTypeId] = strComparisonOp;
}
}
return objSysCommentTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objSysCommentTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsSysCommentTypeEN SetCommentTypeName(this clsSysCommentTypeEN objSysCommentTypeEN, string strCommentTypeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strCommentTypeName, conSysCommentType.CommentTypeName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCommentTypeName, 50, conSysCommentType.CommentTypeName);
}
objSysCommentTypeEN.CommentTypeName = strCommentTypeName; //评论类型名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objSysCommentTypeEN.dicFldComparisonOp.ContainsKey(conSysCommentType.CommentTypeName) == false)
{
objSysCommentTypeEN.dicFldComparisonOp.Add(conSysCommentType.CommentTypeName, strComparisonOp);
}
else
{
objSysCommentTypeEN.dicFldComparisonOp[conSysCommentType.CommentTypeName] = strComparisonOp;
}
}
return objSysCommentTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objSysCommentTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsSysCommentTypeEN SetCommentTable(this clsSysCommentTypeEN objSysCommentTypeEN, string strCommentTable, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCommentTable, 50, conSysCommentType.CommentTable);
}
objSysCommentTypeEN.CommentTable = strCommentTable; //评论表
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objSysCommentTypeEN.dicFldComparisonOp.ContainsKey(conSysCommentType.CommentTable) == false)
{
objSysCommentTypeEN.dicFldComparisonOp.Add(conSysCommentType.CommentTable, strComparisonOp);
}
else
{
objSysCommentTypeEN.dicFldComparisonOp[conSysCommentType.CommentTable] = strComparisonOp;
}
}
return objSysCommentTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objSysCommentTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsSysCommentTypeEN SetCommentTableId(this clsSysCommentTypeEN objSysCommentTypeEN, string strCommentTableId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCommentTableId, 50, conSysCommentType.CommentTableId);
}
objSysCommentTypeEN.CommentTableId = strCommentTableId; //评论表Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objSysCommentTypeEN.dicFldComparisonOp.ContainsKey(conSysCommentType.CommentTableId) == false)
{
objSysCommentTypeEN.dicFldComparisonOp.Add(conSysCommentType.CommentTableId, strComparisonOp);
}
else
{
objSysCommentTypeEN.dicFldComparisonOp[conSysCommentType.CommentTableId] = strComparisonOp;
}
}
return objSysCommentTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objSysCommentTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsSysCommentTypeEN SetMemo(this clsSysCommentTypeEN objSysCommentTypeEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, conSysCommentType.Memo);
}
objSysCommentTypeEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objSysCommentTypeEN.dicFldComparisonOp.ContainsKey(conSysCommentType.Memo) == false)
{
objSysCommentTypeEN.dicFldComparisonOp.Add(conSysCommentType.Memo, strComparisonOp);
}
else
{
objSysCommentTypeEN.dicFldComparisonOp[conSysCommentType.Memo] = strComparisonOp;
}
}
return objSysCommentTypeEN;
	}

 /// <summary>
 /// 修改记录存盘到数据表中
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_UpdateRecordEx)
 /// </summary>
 /// <param name = "objSysCommentTypeEN">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool UpdateRecordEx(this clsSysCommentTypeEN objSysCommentTypeEN)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
try
{
//1、检查传进去的对象属性是否合法
objSysCommentTypeEN.CheckPropertyNew();
clsSysCommentTypeEN objSysCommentTypeCond = new clsSysCommentTypeEN();
string strCondition = objSysCommentTypeCond
.SetCommentTypeId(objSysCommentTypeEN.CommentTypeId, "=")
.GetCombineCondition();
objSysCommentTypeEN._IsCheckProperty = true;
bool bolIsExist = clsSysCommentTypeBL.IsExistRecord(strCondition);
if (bolIsExist)
{
strMsg = "()不能重复!";
throw new Exception(strMsg);
}
//4、把数据实体层的数据存贮到数据库中
objSysCommentTypeEN.Update();
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
 /// <param name = "objSysCommentTypeEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsSysCommentTypeEN objSysCommentTypeEN)
{
 if (string.IsNullOrEmpty(objSysCommentTypeEN.CommentTypeId) == true)
 {
string strMsg = string.Format("(errid:Busi000095)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsSysCommentTypeBL.SysCommentTypeDA.UpdateBySql2(objSysCommentTypeEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsSysCommentTypeBL.ReFreshCache();

if (clsSysCommentTypeBL.relatedActions != null)
{
clsSysCommentTypeBL.relatedActions.UpdRelaTabDate(objSysCommentTypeEN.CommentTypeId, "SetUpdDate");
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
 /// <param name = "objSysCommentTypeEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsSysCommentTypeEN objSysCommentTypeEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (string.IsNullOrEmpty(objSysCommentTypeEN.CommentTypeId) == true)
 {
string strMsg = string.Format("(errid:Busi000087)修改记录时关键字不能为空!(带事务处理)(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsSysCommentTypeBL.SysCommentTypeDA.UpdateBySql2(objSysCommentTypeEN, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsSysCommentTypeBL.ReFreshCache();

if (clsSysCommentTypeBL.relatedActions != null)
{
clsSysCommentTypeBL.relatedActions.UpdRelaTabDate(objSysCommentTypeEN.CommentTypeId, "SetUpdDate");
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
 /// <param name = "objSysCommentTypeEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsSysCommentTypeEN objSysCommentTypeEN, string strWhereCond)
{
try
{
bool bolResult = clsSysCommentTypeBL.SysCommentTypeDA.UpdateBySqlWithCondition(objSysCommentTypeEN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsSysCommentTypeBL.ReFreshCache();

if (clsSysCommentTypeBL.relatedActions != null)
{
clsSysCommentTypeBL.relatedActions.UpdRelaTabDate(objSysCommentTypeEN.CommentTypeId, "SetUpdDate");
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
 /// <param name = "objSysCommentTypeEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsSysCommentTypeEN objSysCommentTypeEN, string strWhereCond, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
bool bolResult = clsSysCommentTypeBL.SysCommentTypeDA.UpdateBySqlWithConditionTransaction(objSysCommentTypeEN, strWhereCond, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsSysCommentTypeBL.ReFreshCache();

if (clsSysCommentTypeBL.relatedActions != null)
{
clsSysCommentTypeBL.relatedActions.UpdRelaTabDate(objSysCommentTypeEN.CommentTypeId, "SetUpdDate");
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
 /// <param name = "strCommentTypeId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int Delete(this clsSysCommentTypeEN objSysCommentTypeEN)
{
try
{
int intRecNum = clsSysCommentTypeBL.SysCommentTypeDA.DelRecord(objSysCommentTypeEN.CommentTypeId);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsSysCommentTypeBL.ReFreshCache();

if (clsSysCommentTypeBL.relatedActions != null)
{
clsSysCommentTypeBL.relatedActions.UpdRelaTabDate(objSysCommentTypeEN.CommentTypeId, "SetUpdDate");
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
 /// <param name = "objSysCommentTypeENS">源对象</param>
 /// <param name = "objSysCommentTypeENT">目标对象</param>
 public static void CopyTo(this clsSysCommentTypeEN objSysCommentTypeENS, clsSysCommentTypeEN objSysCommentTypeENT)
{
try
{
objSysCommentTypeENT.CommentTypeId = objSysCommentTypeENS.CommentTypeId; //评论类型Id
objSysCommentTypeENT.CommentTypeName = objSysCommentTypeENS.CommentTypeName; //评论类型名
objSysCommentTypeENT.CommentTable = objSysCommentTypeENS.CommentTable; //评论表
objSysCommentTypeENT.CommentTableId = objSysCommentTypeENS.CommentTableId; //评论表Id
objSysCommentTypeENT.Memo = objSysCommentTypeENS.Memo; //备注
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
 /// <param name = "objSysCommentTypeENS">源对象</param>
 /// <returns>目标对象=>clsSysCommentTypeEN:objSysCommentTypeENT</returns>
 public static clsSysCommentTypeEN CopyTo(this clsSysCommentTypeEN objSysCommentTypeENS)
{
try
{
 clsSysCommentTypeEN objSysCommentTypeENT = new clsSysCommentTypeEN()
{
CommentTypeId = objSysCommentTypeENS.CommentTypeId, //评论类型Id
CommentTypeName = objSysCommentTypeENS.CommentTypeName, //评论类型名
CommentTable = objSysCommentTypeENS.CommentTable, //评论表
CommentTableId = objSysCommentTypeENS.CommentTableId, //评论表Id
Memo = objSysCommentTypeENS.Memo, //备注
};
 return objSysCommentTypeENT;
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
public static void CheckPropertyNew(this clsSysCommentTypeEN objSysCommentTypeEN)
{
 clsSysCommentTypeBL.SysCommentTypeDA.CheckPropertyNew(objSysCommentTypeEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(this clsSysCommentTypeEN objSysCommentTypeEN)
{
 clsSysCommentTypeBL.SysCommentTypeDA.CheckProperty4Condition(objSysCommentTypeEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsSysCommentTypeEN objSysCommentTypeCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objSysCommentTypeCond.IsUpdated(conSysCommentType.CommentTypeId) == true)
{
string strComparisonOpCommentTypeId = objSysCommentTypeCond.dicFldComparisonOp[conSysCommentType.CommentTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conSysCommentType.CommentTypeId, objSysCommentTypeCond.CommentTypeId, strComparisonOpCommentTypeId);
}
if (objSysCommentTypeCond.IsUpdated(conSysCommentType.CommentTypeName) == true)
{
string strComparisonOpCommentTypeName = objSysCommentTypeCond.dicFldComparisonOp[conSysCommentType.CommentTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", conSysCommentType.CommentTypeName, objSysCommentTypeCond.CommentTypeName, strComparisonOpCommentTypeName);
}
if (objSysCommentTypeCond.IsUpdated(conSysCommentType.CommentTable) == true)
{
string strComparisonOpCommentTable = objSysCommentTypeCond.dicFldComparisonOp[conSysCommentType.CommentTable];
strWhereCond += string.Format(" And {0} {2} '{1}'", conSysCommentType.CommentTable, objSysCommentTypeCond.CommentTable, strComparisonOpCommentTable);
}
if (objSysCommentTypeCond.IsUpdated(conSysCommentType.CommentTableId) == true)
{
string strComparisonOpCommentTableId = objSysCommentTypeCond.dicFldComparisonOp[conSysCommentType.CommentTableId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conSysCommentType.CommentTableId, objSysCommentTypeCond.CommentTableId, strComparisonOpCommentTableId);
}
if (objSysCommentTypeCond.IsUpdated(conSysCommentType.Memo) == true)
{
string strComparisonOpMemo = objSysCommentTypeCond.dicFldComparisonOp[conSysCommentType.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", conSysCommentType.Memo, objSysCommentTypeCond.Memo, strComparisonOpMemo);
}
 return strWhereCond;
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_SysCommentType
{
public virtual bool UpdRelaTabDate(string strCommentTypeId, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// 根据表内容设置enum列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GeneEnumConstList)
 /// </summary>
public class enumSysCommentType
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
 /// 教师问题回答
 /// </summary>
public const string qa_Answer_11 = "11";
 /// <summary>
 /// 论文汇报
 /// </summary>
public const string gs_PaperReport_12 = "12";
 /// <summary>
 /// 研究成果
 /// </summary>
public const string gs_ResearchResult_13 = "13";
 /// <summary>
 /// 主题人员
 /// </summary>
public const string RTUserRela_14 = "14";
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
 /// 评论类型表(SysCommentType)
 /// 数据源类型:表
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsSysCommentTypeBL
{
public static RelatedActions_SysCommentType relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsSysCommentTypeDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsSysCommentTypeDA SysCommentTypeDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsSysCommentTypeDA();
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
 public clsSysCommentTypeBL()
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
if (string.IsNullOrEmpty(clsSysCommentTypeEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsSysCommentTypeEN._ConnectString);
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
public static DataTable GetDataTable_SysCommentType(string strWhereCond)
{
DataTable objDT;
try
{
objDT = SysCommentTypeDA.GetDataTable_SysCommentType(strWhereCond);
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
objDT = SysCommentTypeDA.GetDataTable(strWhereCond);
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
objDT = SysCommentTypeDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = SysCommentTypeDA.GetDataTable(strWhereCond, strTabName);
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
objDT = SysCommentTypeDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = SysCommentTypeDA.GetDataTable_Top(objTopPara);
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
objDT = SysCommentTypeDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = SysCommentTypeDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = SysCommentTypeDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
 /// <param name = "arrCommentTypeIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static List<clsSysCommentTypeEN> GetObjLstByCommentTypeIdLst(List<string> arrCommentTypeIdLst)
{
List<clsSysCommentTypeEN> arrObjLst = new List<clsSysCommentTypeEN>(); 
System.Data.DataTable objDT; 
 string strSqlConditionStr = clsArray.GetSqlInStrByArray(arrCommentTypeIdLst, true);
 string strWhereCond = string.Format("CommentTypeId in ({0})", strSqlConditionStr);
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsSysCommentTypeEN objSysCommentTypeEN = new clsSysCommentTypeEN();
try
{
objSysCommentTypeEN.CommentTypeId = objRow[conSysCommentType.CommentTypeId].ToString().Trim(); //评论类型Id
objSysCommentTypeEN.CommentTypeName = objRow[conSysCommentType.CommentTypeName].ToString().Trim(); //评论类型名
objSysCommentTypeEN.CommentTable = objRow[conSysCommentType.CommentTable] == DBNull.Value ? null : objRow[conSysCommentType.CommentTable].ToString().Trim(); //评论表
objSysCommentTypeEN.CommentTableId = objRow[conSysCommentType.CommentTableId] == DBNull.Value ? null : objRow[conSysCommentType.CommentTableId].ToString().Trim(); //评论表Id
objSysCommentTypeEN.Memo = objRow[conSysCommentType.Memo] == DBNull.Value ? null : objRow[conSysCommentType.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objSysCommentTypeEN.CommentTypeId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objSysCommentTypeEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrCommentTypeIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsSysCommentTypeEN> GetObjLstByCommentTypeIdLstCache(List<string> arrCommentTypeIdLst)
{
string strKey = string.Format("{0}", clsSysCommentTypeEN._CurrTabName);
List<clsSysCommentTypeEN> arrSysCommentTypeObjLstCache = GetObjLstCache();
IEnumerable <clsSysCommentTypeEN> arrSysCommentTypeObjLst_Sel =
arrSysCommentTypeObjLstCache
.Where(x => arrCommentTypeIdLst.Contains(x.CommentTypeId));
return arrSysCommentTypeObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsSysCommentTypeEN> GetObjLst(string strWhereCond)
{
List<clsSysCommentTypeEN> arrObjLst = new List<clsSysCommentTypeEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsSysCommentTypeEN objSysCommentTypeEN = new clsSysCommentTypeEN();
try
{
objSysCommentTypeEN.CommentTypeId = objRow[conSysCommentType.CommentTypeId].ToString().Trim(); //评论类型Id
objSysCommentTypeEN.CommentTypeName = objRow[conSysCommentType.CommentTypeName].ToString().Trim(); //评论类型名
objSysCommentTypeEN.CommentTable = objRow[conSysCommentType.CommentTable] == DBNull.Value ? null : objRow[conSysCommentType.CommentTable].ToString().Trim(); //评论表
objSysCommentTypeEN.CommentTableId = objRow[conSysCommentType.CommentTableId] == DBNull.Value ? null : objRow[conSysCommentType.CommentTableId].ToString().Trim(); //评论表Id
objSysCommentTypeEN.Memo = objRow[conSysCommentType.Memo] == DBNull.Value ? null : objRow[conSysCommentType.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objSysCommentTypeEN.CommentTypeId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objSysCommentTypeEN);
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
public static List<clsSysCommentTypeEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsSysCommentTypeEN> arrObjLst = new List<clsSysCommentTypeEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsSysCommentTypeEN objSysCommentTypeEN = new clsSysCommentTypeEN();
try
{
objSysCommentTypeEN.CommentTypeId = objRow[conSysCommentType.CommentTypeId].ToString().Trim(); //评论类型Id
objSysCommentTypeEN.CommentTypeName = objRow[conSysCommentType.CommentTypeName].ToString().Trim(); //评论类型名
objSysCommentTypeEN.CommentTable = objRow[conSysCommentType.CommentTable] == DBNull.Value ? null : objRow[conSysCommentType.CommentTable].ToString().Trim(); //评论表
objSysCommentTypeEN.CommentTableId = objRow[conSysCommentType.CommentTableId] == DBNull.Value ? null : objRow[conSysCommentType.CommentTableId].ToString().Trim(); //评论表Id
objSysCommentTypeEN.Memo = objRow[conSysCommentType.Memo] == DBNull.Value ? null : objRow[conSysCommentType.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objSysCommentTypeEN.CommentTypeId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objSysCommentTypeEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objSysCommentTypeCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsSysCommentTypeEN> GetSubObjLstCache(clsSysCommentTypeEN objSysCommentTypeCond)
{
List<clsSysCommentTypeEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsSysCommentTypeEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conSysCommentType.AttributeName)
{
if (objSysCommentTypeCond.IsUpdated(strFldName) == false) continue;
if (objSysCommentTypeCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objSysCommentTypeCond[strFldName].ToString());
}
else
{
if (objSysCommentTypeCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objSysCommentTypeCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objSysCommentTypeCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objSysCommentTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objSysCommentTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objSysCommentTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objSysCommentTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objSysCommentTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objSysCommentTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objSysCommentTypeCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objSysCommentTypeCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objSysCommentTypeCond[strFldName]));
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
public static List<clsSysCommentTypeEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsSysCommentTypeEN> arrObjLst = new List<clsSysCommentTypeEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsSysCommentTypeEN objSysCommentTypeEN = new clsSysCommentTypeEN();
try
{
objSysCommentTypeEN.CommentTypeId = objRow[conSysCommentType.CommentTypeId].ToString().Trim(); //评论类型Id
objSysCommentTypeEN.CommentTypeName = objRow[conSysCommentType.CommentTypeName].ToString().Trim(); //评论类型名
objSysCommentTypeEN.CommentTable = objRow[conSysCommentType.CommentTable] == DBNull.Value ? null : objRow[conSysCommentType.CommentTable].ToString().Trim(); //评论表
objSysCommentTypeEN.CommentTableId = objRow[conSysCommentType.CommentTableId] == DBNull.Value ? null : objRow[conSysCommentType.CommentTableId].ToString().Trim(); //评论表Id
objSysCommentTypeEN.Memo = objRow[conSysCommentType.Memo] == DBNull.Value ? null : objRow[conSysCommentType.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objSysCommentTypeEN.CommentTypeId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objSysCommentTypeEN);
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
public static List<clsSysCommentTypeEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsSysCommentTypeEN> arrObjLst = new List<clsSysCommentTypeEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsSysCommentTypeEN objSysCommentTypeEN = new clsSysCommentTypeEN();
try
{
objSysCommentTypeEN.CommentTypeId = objRow[conSysCommentType.CommentTypeId].ToString().Trim(); //评论类型Id
objSysCommentTypeEN.CommentTypeName = objRow[conSysCommentType.CommentTypeName].ToString().Trim(); //评论类型名
objSysCommentTypeEN.CommentTable = objRow[conSysCommentType.CommentTable] == DBNull.Value ? null : objRow[conSysCommentType.CommentTable].ToString().Trim(); //评论表
objSysCommentTypeEN.CommentTableId = objRow[conSysCommentType.CommentTableId] == DBNull.Value ? null : objRow[conSysCommentType.CommentTableId].ToString().Trim(); //评论表Id
objSysCommentTypeEN.Memo = objRow[conSysCommentType.Memo] == DBNull.Value ? null : objRow[conSysCommentType.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objSysCommentTypeEN.CommentTypeId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objSysCommentTypeEN);
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
List<clsSysCommentTypeEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsSysCommentTypeEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsSysCommentTypeEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsSysCommentTypeEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsSysCommentTypeEN> arrObjLst = new List<clsSysCommentTypeEN>(); 
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
	clsSysCommentTypeEN objSysCommentTypeEN = new clsSysCommentTypeEN();
try
{
objSysCommentTypeEN.CommentTypeId = objRow[conSysCommentType.CommentTypeId].ToString().Trim(); //评论类型Id
objSysCommentTypeEN.CommentTypeName = objRow[conSysCommentType.CommentTypeName].ToString().Trim(); //评论类型名
objSysCommentTypeEN.CommentTable = objRow[conSysCommentType.CommentTable] == DBNull.Value ? null : objRow[conSysCommentType.CommentTable].ToString().Trim(); //评论表
objSysCommentTypeEN.CommentTableId = objRow[conSysCommentType.CommentTableId] == DBNull.Value ? null : objRow[conSysCommentType.CommentTableId].ToString().Trim(); //评论表Id
objSysCommentTypeEN.Memo = objRow[conSysCommentType.Memo] == DBNull.Value ? null : objRow[conSysCommentType.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objSysCommentTypeEN.CommentTypeId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objSysCommentTypeEN);
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
public static List<clsSysCommentTypeEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsSysCommentTypeEN> arrObjLst = new List<clsSysCommentTypeEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsSysCommentTypeEN objSysCommentTypeEN = new clsSysCommentTypeEN();
try
{
objSysCommentTypeEN.CommentTypeId = objRow[conSysCommentType.CommentTypeId].ToString().Trim(); //评论类型Id
objSysCommentTypeEN.CommentTypeName = objRow[conSysCommentType.CommentTypeName].ToString().Trim(); //评论类型名
objSysCommentTypeEN.CommentTable = objRow[conSysCommentType.CommentTable] == DBNull.Value ? null : objRow[conSysCommentType.CommentTable].ToString().Trim(); //评论表
objSysCommentTypeEN.CommentTableId = objRow[conSysCommentType.CommentTableId] == DBNull.Value ? null : objRow[conSysCommentType.CommentTableId].ToString().Trim(); //评论表Id
objSysCommentTypeEN.Memo = objRow[conSysCommentType.Memo] == DBNull.Value ? null : objRow[conSysCommentType.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objSysCommentTypeEN.CommentTypeId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objSysCommentTypeEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsSysCommentTypeEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsSysCommentTypeEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsSysCommentTypeEN> arrObjLst = new List<clsSysCommentTypeEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsSysCommentTypeEN objSysCommentTypeEN = new clsSysCommentTypeEN();
try
{
objSysCommentTypeEN.CommentTypeId = objRow[conSysCommentType.CommentTypeId].ToString().Trim(); //评论类型Id
objSysCommentTypeEN.CommentTypeName = objRow[conSysCommentType.CommentTypeName].ToString().Trim(); //评论类型名
objSysCommentTypeEN.CommentTable = objRow[conSysCommentType.CommentTable] == DBNull.Value ? null : objRow[conSysCommentType.CommentTable].ToString().Trim(); //评论表
objSysCommentTypeEN.CommentTableId = objRow[conSysCommentType.CommentTableId] == DBNull.Value ? null : objRow[conSysCommentType.CommentTableId].ToString().Trim(); //评论表Id
objSysCommentTypeEN.Memo = objRow[conSysCommentType.Memo] == DBNull.Value ? null : objRow[conSysCommentType.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objSysCommentTypeEN.CommentTypeId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objSysCommentTypeEN);
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
public static List<clsSysCommentTypeEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsSysCommentTypeEN> arrObjLst = new List<clsSysCommentTypeEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsSysCommentTypeEN objSysCommentTypeEN = new clsSysCommentTypeEN();
try
{
objSysCommentTypeEN.CommentTypeId = objRow[conSysCommentType.CommentTypeId].ToString().Trim(); //评论类型Id
objSysCommentTypeEN.CommentTypeName = objRow[conSysCommentType.CommentTypeName].ToString().Trim(); //评论类型名
objSysCommentTypeEN.CommentTable = objRow[conSysCommentType.CommentTable] == DBNull.Value ? null : objRow[conSysCommentType.CommentTable].ToString().Trim(); //评论表
objSysCommentTypeEN.CommentTableId = objRow[conSysCommentType.CommentTableId] == DBNull.Value ? null : objRow[conSysCommentType.CommentTableId].ToString().Trim(); //评论表Id
objSysCommentTypeEN.Memo = objRow[conSysCommentType.Memo] == DBNull.Value ? null : objRow[conSysCommentType.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objSysCommentTypeEN.CommentTypeId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objSysCommentTypeEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsSysCommentTypeEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsSysCommentTypeEN> arrObjLst = new List<clsSysCommentTypeEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsSysCommentTypeEN objSysCommentTypeEN = new clsSysCommentTypeEN();
try
{
objSysCommentTypeEN.CommentTypeId = objRow[conSysCommentType.CommentTypeId].ToString().Trim(); //评论类型Id
objSysCommentTypeEN.CommentTypeName = objRow[conSysCommentType.CommentTypeName].ToString().Trim(); //评论类型名
objSysCommentTypeEN.CommentTable = objRow[conSysCommentType.CommentTable] == DBNull.Value ? null : objRow[conSysCommentType.CommentTable].ToString().Trim(); //评论表
objSysCommentTypeEN.CommentTableId = objRow[conSysCommentType.CommentTableId] == DBNull.Value ? null : objRow[conSysCommentType.CommentTableId].ToString().Trim(); //评论表Id
objSysCommentTypeEN.Memo = objRow[conSysCommentType.Memo] == DBNull.Value ? null : objRow[conSysCommentType.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objSysCommentTypeEN.CommentTypeId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objSysCommentTypeEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objSysCommentTypeEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetSysCommentType(ref clsSysCommentTypeEN objSysCommentTypeEN)
{
bool bolResult = SysCommentTypeDA.GetSysCommentType(ref objSysCommentTypeEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "strCommentTypeId">表关键字</param>
 /// <returns>表对象</returns>
public static clsSysCommentTypeEN GetObjByCommentTypeId(string strCommentTypeId)
{
if (strCommentTypeId.IndexOf(' ') >=0)
{
var strMsg = string.Format("(errid:Busi000079)在表中,关键字[strCommentTypeId]中不能有空格!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
if (string.IsNullOrEmpty(strCommentTypeId) == true)
{
var strMsg = string.Format("(errid:Busi000020)在表中,关键字[strCommentTypeId]不能为空!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
clsSysCommentTypeEN objSysCommentTypeEN = SysCommentTypeDA.GetObjByCommentTypeId(strCommentTypeId);
return objSysCommentTypeEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsSysCommentTypeEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsSysCommentTypeEN objSysCommentTypeEN = SysCommentTypeDA.GetFirstObj(strWhereCond);
 return objSysCommentTypeEN;
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
public static clsSysCommentTypeEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsSysCommentTypeEN objSysCommentTypeEN = SysCommentTypeDA.GetObjByDataRow(objRow);
 return objSysCommentTypeEN;
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
public static clsSysCommentTypeEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsSysCommentTypeEN objSysCommentTypeEN = SysCommentTypeDA.GetObjByDataRow(objRow);
 return objSysCommentTypeEN;
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
 /// <param name = "strCommentTypeId">所给的关键字</param>
 /// <param name = "lstSysCommentTypeObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsSysCommentTypeEN GetObjByCommentTypeIdFromList(string strCommentTypeId, List<clsSysCommentTypeEN> lstSysCommentTypeObjLst)
{
foreach (clsSysCommentTypeEN objSysCommentTypeEN in lstSysCommentTypeObjLst)
{
if (objSysCommentTypeEN.CommentTypeId == strCommentTypeId)
{
return objSysCommentTypeEN;
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
 string strCommentTypeId;
 try
 {
 strCommentTypeId = new clsSysCommentTypeDA().GetFirstID(strWhereCond);
 return strCommentTypeId;
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
 arrList = SysCommentTypeDA.GetID(strWhereCond);
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
bool bolIsExist = SysCommentTypeDA.IsExistCondRec(strWhereCond);
return bolIsExist;
}

 /// <summary>
 /// 判断当前表中是否存在给定关键字值的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExist)
 /// </summary>
 /// <param name = "strCommentTypeId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public static bool IsExist(string strCommentTypeId)
{
if (string.IsNullOrEmpty(strCommentTypeId) == true)
{
var strMsg = string.Format("(errid:Busi000027)在表中,关键字[strCommentTypeId]不能为空!!(from {0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
//检测记录是否存在
bool bolIsExist = SysCommentTypeDA.IsExist(strCommentTypeId);
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
 bolIsExist = clsSysCommentTypeDA.IsExistTable();
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
 bolIsExist = SysCommentTypeDA.IsExistTable(strTabName);
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
 /// <param name = "objSysCommentTypeEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecordBySql2(clsSysCommentTypeEN objSysCommentTypeEN, bool bolIsNeedCheckUniqueness=true)
{
 if (string.IsNullOrEmpty(objSysCommentTypeEN.CommentTypeId) == true)
 {
string strMsg = string.Format("添加记录时,关键字不能为空!(from {0})\r\n", 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
 if (clsSysCommentTypeBL.IsExist(objSysCommentTypeEN.CommentTypeId) == true)
 {
string strMsg = string.Format("添加记录时,关键字:[{0}]已经存在!(from {1})\r\n", objSysCommentTypeEN.CommentTypeId, 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
try
{
bool bolResult = SysCommentTypeDA.AddNewRecordBySQL2(objSysCommentTypeEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsSysCommentTypeBL.ReFreshCache();

if (clsSysCommentTypeBL.relatedActions != null)
{
clsSysCommentTypeBL.relatedActions.UpdRelaTabDate(objSysCommentTypeEN.CommentTypeId, "SetUpdDate");
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
 /// <param name = "objSysCommentTypeEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordBySql2WithReturnKey(clsSysCommentTypeEN objSysCommentTypeEN, bool bolIsNeedCheckUniqueness=true)
{
 if (string.IsNullOrEmpty(objSysCommentTypeEN.CommentTypeId) == true)
 {
string strMsg = string.Format("添加记录时,关键字不能为空!(from {{0}})", 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
 if (clsSysCommentTypeBL.IsExist(objSysCommentTypeEN.CommentTypeId) == true)
 {
string strMsg = string.Format("添加记录时,关键字:[{0}]已经存在!(from {1})\r\n", objSysCommentTypeEN.CommentTypeId, 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
try
{
string strKey = SysCommentTypeDA.AddNewRecordBySQL2WithReturnKey(objSysCommentTypeEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsSysCommentTypeBL.ReFreshCache();

if (clsSysCommentTypeBL.relatedActions != null)
{
clsSysCommentTypeBL.relatedActions.UpdRelaTabDate(objSysCommentTypeEN.CommentTypeId, "SetUpdDate");
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
 /// <param name = "objSysCommentTypeEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(clsSysCommentTypeEN objSysCommentTypeEN)
{
try
{
bool bolResult = SysCommentTypeDA.Update(objSysCommentTypeEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsSysCommentTypeBL.ReFreshCache();

if (clsSysCommentTypeBL.relatedActions != null)
{
clsSysCommentTypeBL.relatedActions.UpdRelaTabDate(objSysCommentTypeEN.CommentTypeId, "SetUpdDate");
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
 /// <param name = "objSysCommentTypeEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateBySql2(clsSysCommentTypeEN objSysCommentTypeEN)
{
 if (string.IsNullOrEmpty(objSysCommentTypeEN.CommentTypeId) == true)
 {
var strMsg = string.Format("(errid:Busi000065)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = SysCommentTypeDA.UpdateBySql2(objSysCommentTypeEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsSysCommentTypeBL.ReFreshCache();

if (clsSysCommentTypeBL.relatedActions != null)
{
clsSysCommentTypeBL.relatedActions.UpdRelaTabDate(objSysCommentTypeEN.CommentTypeId, "SetUpdDate");
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
 /// <param name = "strCommentTypeId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int DelRecord(string strCommentTypeId)
{
try
{
 clsSysCommentTypeEN objSysCommentTypeEN = clsSysCommentTypeBL.GetObjByCommentTypeId(strCommentTypeId);

if (clsSysCommentTypeBL.relatedActions != null)
{
clsSysCommentTypeBL.relatedActions.UpdRelaTabDate(objSysCommentTypeEN.CommentTypeId, "SetUpdDate");
}
if (objSysCommentTypeEN != null)
{
int intRecNum = SysCommentTypeDA.DelRecord(strCommentTypeId);
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
/// <param name="strCommentTypeId">表关键字</param>
/// <returns></returns>
public static bool DelRecordEx(string strCommentTypeId )
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsSysCommentTypeDA.GetSpecSQLObj();
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
//删除与表:[SysCommentType]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conSysCommentType.CommentTypeId,
//strCommentTypeId);
//        clsSysCommentTypeBL.DelSysCommentTypesByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsSysCommentTypeBL.DelRecord(strCommentTypeId, objConnection, objSqlTransaction);
objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsSysCommentTypeBLEx", "DelRecordEx", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("扩展删除记录出错:{0}!keyId = {1}.({2})",
objException.Message,
strCommentTypeId, clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "strCommentTypeId">给定的关键字值</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回删除是否成功?</returns>
public static bool DelRecord(string strCommentTypeId, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
if (clsSysCommentTypeBL.relatedActions != null)
{
clsSysCommentTypeBL.relatedActions.UpdRelaTabDate(strCommentTypeId, "UpdRelaTabDate");
}
bool bolResult = SysCommentTypeDA.DelRecord(strCommentTypeId,objSqlConnection,objSqlTransaction);
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
 /// <param name = "arrCommentTypeIdLst">给定的关键字值列表</param>
 /// <returns>返回删除的记录数</returns>
public static int DelSysCommentTypes(List<string> arrCommentTypeIdLst)
{
if (arrCommentTypeIdLst.Count == 0) return 0;
try
{
if (clsSysCommentTypeBL.relatedActions != null)
{
foreach (var strCommentTypeId in arrCommentTypeIdLst)
{
clsSysCommentTypeBL.relatedActions.UpdRelaTabDate(strCommentTypeId, "UpdRelaTabDate");
}
}
int intDelRecNum = SysCommentTypeDA.DelSysCommentType(arrCommentTypeIdLst);
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
public static int DelSysCommentTypesByCond(string strWhereCond)
{
try
{
if (clsSysCommentTypeBL.relatedActions != null)
{
List<string> arrCommentTypeId = GetPrimaryKeyID_S(strWhereCond);
foreach (var strCommentTypeId in arrCommentTypeId)
{
clsSysCommentTypeBL.relatedActions.UpdRelaTabDate(strCommentTypeId, "UpdRelaTabDate");
}
}
int intRecNum = SysCommentTypeDA.DelSysCommentType(strWhereCond);
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
/// 这里仅仅是演示函数,使用时请复制到扩展类:[SysCommentType]中改名为:[DelRecord4MultiTabEx]使用
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DelRecord4MultiTab)
/// </summary>
/// <param name="strCommentTypeId">表关键字</param>
/// <returns></returns>
public static bool DelRecord4MultiTab(string strCommentTypeId)
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsSysCommentTypeDA.GetSpecSQLObj();
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
//删除与表:[SysCommentType]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conStudent.id_College,
//strid_College);
//        clsStudentBL.DelStudentsByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsSysCommentTypeBL.DelRecord(strCommentTypeId, objConnection, objSqlTransaction);
                objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsSysCommentTypeBL", "DelRecord4MultiTab", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("删除多表记录出错:{0}!keyId = {1}.({2})",
objException.Message,
strCommentTypeId, clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "objSysCommentTypeENS">源对象</param>
 /// <param name = "objSysCommentTypeENT">目标对象</param>
 public static void CopyTo(clsSysCommentTypeEN objSysCommentTypeENS, clsSysCommentTypeEN objSysCommentTypeENT)
{
try
{
objSysCommentTypeENT.CommentTypeId = objSysCommentTypeENS.CommentTypeId; //评论类型Id
objSysCommentTypeENT.CommentTypeName = objSysCommentTypeENS.CommentTypeName; //评论类型名
objSysCommentTypeENT.CommentTable = objSysCommentTypeENS.CommentTable; //评论表
objSysCommentTypeENT.CommentTableId = objSysCommentTypeENS.CommentTableId; //评论表Id
objSysCommentTypeENT.Memo = objSysCommentTypeENS.Memo; //备注
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
 /// <param name = "objSysCommentTypeEN">源简化对象</param>
 public static void SetUpdFlag(clsSysCommentTypeEN objSysCommentTypeEN)
{
try
{
objSysCommentTypeEN.ClearUpdateState();
   string strsfUpdFldSetStr = objSysCommentTypeEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(conSysCommentType.CommentTypeId, new clsStrCompareIgnoreCase())  ==  true)
{
objSysCommentTypeEN.CommentTypeId = objSysCommentTypeEN.CommentTypeId; //评论类型Id
}
if (arrFldSet.Contains(conSysCommentType.CommentTypeName, new clsStrCompareIgnoreCase())  ==  true)
{
objSysCommentTypeEN.CommentTypeName = objSysCommentTypeEN.CommentTypeName; //评论类型名
}
if (arrFldSet.Contains(conSysCommentType.CommentTable, new clsStrCompareIgnoreCase())  ==  true)
{
objSysCommentTypeEN.CommentTable = objSysCommentTypeEN.CommentTable == "[null]" ? null :  objSysCommentTypeEN.CommentTable; //评论表
}
if (arrFldSet.Contains(conSysCommentType.CommentTableId, new clsStrCompareIgnoreCase())  ==  true)
{
objSysCommentTypeEN.CommentTableId = objSysCommentTypeEN.CommentTableId == "[null]" ? null :  objSysCommentTypeEN.CommentTableId; //评论表Id
}
if (arrFldSet.Contains(conSysCommentType.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objSysCommentTypeEN.Memo = objSysCommentTypeEN.Memo == "[null]" ? null :  objSysCommentTypeEN.Memo; //备注
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
 /// <param name = "objSysCommentTypeEN">源简化对象</param>
 public static void AccessFldValueNull(clsSysCommentTypeEN objSysCommentTypeEN)
{
try
{
if (objSysCommentTypeEN.CommentTable == "[null]") objSysCommentTypeEN.CommentTable = null; //评论表
if (objSysCommentTypeEN.CommentTableId == "[null]") objSysCommentTypeEN.CommentTableId = null; //评论表Id
if (objSysCommentTypeEN.Memo == "[null]") objSysCommentTypeEN.Memo = null; //备注
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
public static void CheckPropertyNew(clsSysCommentTypeEN objSysCommentTypeEN)
{
 SysCommentTypeDA.CheckPropertyNew(objSysCommentTypeEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(clsSysCommentTypeEN objSysCommentTypeEN)
{
 SysCommentTypeDA.CheckProperty4Condition(objSysCommentTypeEN);
 }


 #endregion 检查对象属性


 #region 绑定下拉框

 /// <summary>
 /// 绑定基于Win的下拉框
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_TabFeature_ComboBoxBindFunction)
 /// </summary>
 /// <param name = "objComboBox">需要绑定当前表的下拉框</param>

public static void BindCbo_CommentTypeId(System.Windows.Forms.ComboBox objComboBox )
{
//为数据源为表的下拉框设置内容
string strCondition = string.Format("1 =1 Order By {0}", conSysCommentType.CommentTypeId); 
List<clsSysCommentTypeEN> arrObjLst = clsSysCommentTypeBL.GetObjLst(strCondition);
//初始化一个对象列表
//插入第0项。在第0项中插入“请选择...”,为了方便用户,与WEB方式类似。
clsSysCommentTypeEN objSysCommentTypeEN = new clsSysCommentTypeEN()
{
CommentTypeId = "0",
CommentTypeName = "选[评论类型表]..."
};
arrObjLst.Insert(0, objSysCommentTypeEN);
//设置下拉框的数据源、以及设置值项、显示项
objComboBox.ValueMember = conSysCommentType.CommentTypeId;
objComboBox.DisplayMember = conSysCommentType.CommentTypeName;
objComboBox.DataSource = arrObjLst;
objComboBox.SelectedIndex = 0;
}

 /// <summary>
 /// 绑定基于Web的下拉框
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_TabFeature_DdlBindFunction)
 /// </summary>
 /// <param name = "objDDL">需要绑定当前表的下拉框</param>

public static void BindDdl_CommentTypeId(System.Web.UI.WebControls.DropDownList objDDL )
{
//为数据源于表的下拉框设置内容
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[评论类型表]...","0");
string strCondition = string.Format("1 =1 Order By {0}", conSysCommentType.CommentTypeId); 
IEnumerable<clsSysCommentTypeEN> arrObjLst = clsSysCommentTypeBL.GetObjLst(strCondition);
objDDL.DataValueField = conSysCommentType.CommentTypeId;
objDDL.DataTextField = conSysCommentType.CommentTypeName;
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
public static void BindDdl_CommentTypeIdCache(System.Web.UI.WebControls.DropDownList objDDL)
{
//为数据源于表的下拉框设置内容
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[评论类型表]...","0");
List<clsSysCommentTypeEN> arrSysCommentTypeObjLst = GetAllSysCommentTypeObjLstCache(); 
objDDL.DataValueField = conSysCommentType.CommentTypeId;
objDDL.DataTextField = conSysCommentType.CommentTypeName;
objDDL.DataSource = arrSysCommentTypeObjLst;
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
if (clsSysCommentTypeBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsSysCommentTypeBL没有刷新缓存机制(clsSysCommentTypeBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by CommentTypeId");
//if (arrSysCommentTypeObjLstCache == null)
//{
//arrSysCommentTypeObjLstCache = SysCommentTypeDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "strCommentTypeId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsSysCommentTypeEN GetObjByCommentTypeIdCache(string strCommentTypeId)
{
//获取缓存中的对象列表
string strKey = string.Format("{0}", clsSysCommentTypeEN._CurrTabName);
List<clsSysCommentTypeEN> arrSysCommentTypeObjLstCache = GetObjLstCache();
IEnumerable <clsSysCommentTypeEN> arrSysCommentTypeObjLst_Sel =
arrSysCommentTypeObjLstCache
.Where(x=> x.CommentTypeId == strCommentTypeId 
);
if (arrSysCommentTypeObjLst_Sel.Count() == 0)
{
   clsSysCommentTypeEN obj = clsSysCommentTypeBL.GetObjByCommentTypeId(strCommentTypeId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
 }
return null;
}
return arrSysCommentTypeObjLst_Sel.First();
}

 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecNameByKeyCache)
 /// </summary>
 /// <param name = "strCommentTypeId">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetCommentTypeNameByCommentTypeIdCache(string strCommentTypeId)
{
if (string.IsNullOrEmpty(strCommentTypeId) == true) return "";
//获取缓存中的对象列表
clsSysCommentTypeEN objSysCommentType = GetObjByCommentTypeIdCache(strCommentTypeId);
if (objSysCommentType == null) return "";
return objSysCommentType.CommentTypeName;
}
 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecNameByKeyCache)
 /// </summary>
 /// <param name = "strCommentTypeId">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetNameByCommentTypeIdCache(string strCommentTypeId)
{
if (string.IsNullOrEmpty(strCommentTypeId) == true) return "";
//获取缓存中的对象列表
clsSysCommentTypeEN objSysCommentType = GetObjByCommentTypeIdCache(strCommentTypeId);
if (objSysCommentType == null) return "";
return objSysCommentType.CommentTypeName;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsSysCommentTypeEN> GetAllSysCommentTypeObjLstCache()
{
//获取缓存中的对象列表
List<clsSysCommentTypeEN> arrSysCommentTypeObjLstCache = GetObjLstCache(); 
return arrSysCommentTypeObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsSysCommentTypeEN> GetObjLstCache()
{
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}", clsSysCommentTypeEN._CurrTabName);
List<clsSysCommentTypeEN> arrSysCommentTypeObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrSysCommentTypeObjLstCache;
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
string strKey = string.Format("{0}", clsSysCommentTypeEN._CurrTabName);
CacheHelper.Remove(strKey);
clsSysCommentTypeEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
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
if (clsSysCommentTypeEN._RefreshTimeLst.Count == 0) return "";
return clsSysCommentTypeEN._RefreshTimeLst[clsSysCommentTypeEN._RefreshTimeLst.Count - 1];
}

 /// <summary>
 /// 刷新缓存.把当前表的缓存以及该表相关视图的缓存清空.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ReFreshCache)
 /// </summary>
public static void ReFreshCache()
{
if (clsSysCommentTypeBL.objCommFun4BL != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}", clsSysCommentTypeEN._CurrTabName);
CacheHelper.Remove(strKey);
clsSysCommentTypeEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
clsSysCommentTypeBL.objCommFun4BL.ReFreshCache();
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
public static string Func(string strInFldName, string strOutFldName, string strCommentTypeId)
{
if (strInFldName != conSysCommentType.CommentTypeId)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (conSysCommentType.AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", conSysCommentType.AttributeName));
throw new Exception(strMsg);
}
var objSysCommentType = clsSysCommentTypeBL.GetObjByCommentTypeIdCache(strCommentTypeId);
if (objSysCommentType == null) return "";
return objSysCommentType[strOutFldName].ToString();
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
int intRecCount = clsSysCommentTypeDA.GetRecCount(strTabName);
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
int intRecCount = clsSysCommentTypeDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsSysCommentTypeDA.GetRecCount();
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
int intRecCount = clsSysCommentTypeDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objSysCommentTypeCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsSysCommentTypeEN objSysCommentTypeCond)
{
List<clsSysCommentTypeEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsSysCommentTypeEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conSysCommentType.AttributeName)
{
if (objSysCommentTypeCond.IsUpdated(strFldName) == false) continue;
if (objSysCommentTypeCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objSysCommentTypeCond[strFldName].ToString());
}
else
{
if (objSysCommentTypeCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objSysCommentTypeCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objSysCommentTypeCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objSysCommentTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objSysCommentTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objSysCommentTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objSysCommentTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objSysCommentTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objSysCommentTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objSysCommentTypeCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objSysCommentTypeCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objSysCommentTypeCond[strFldName]));
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
 List<string> arrList = clsSysCommentTypeDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = SysCommentTypeDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = SysCommentTypeDA.GetFldValueNoDistinct(strFldName, strWhereCond);
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
int intRecCount = SysCommentTypeDA.SetFldValue(strFldName, strValue, strWhereCond);
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
int intRecCount = clsSysCommentTypeDA.SetFldValue(clsSysCommentTypeEN._CurrTabName, strFldName, fltValue, strWhereCond);
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
int intRecCount = SysCommentTypeDA.SetFldValue( strFldName, intValue, strWhereCond);
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
int intRecCount = clsSysCommentTypeDA.SetFldValue(strTabName, strFldName, strValue, strWhereCond);
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
int intRecCount = clsSysCommentTypeDA.SetFldValue(strTabName, strFldName, intValue, strWhereCond);
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
int intRecCount = clsSysCommentTypeDA.SetFldValue(strTabName, strFldName, fltValue, strWhereCond);
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
  strCreateTabCode.Append("CREATE table [dbo].[SysCommentType] "); 
 strCreateTabCode.Append(" ( "); 
 // /**评论类型Id*/ 
 strCreateTabCode.Append(" CommentTypeId char(2) primary key, "); 
 // /**评论类型名*/ 
 strCreateTabCode.Append(" CommentTypeName varchar(50) not Null, "); 
 // /**评论表*/ 
 strCreateTabCode.Append(" CommentTable varchar(50) Null, "); 
 // /**评论表Id*/ 
 strCreateTabCode.Append(" CommentTableId varchar(50) Null, "); 
 // /**备注*/ 
 strCreateTabCode.Append(" Memo varchar(1000) Null ");
 strCreateTabCode.Append(") "); 
  strCreateTabCode.Append("ON [PRIMARY] ");
  return strCreateTabCode.ToString();
}



 #endregion 表操作
}
 /// <summary>
 /// 评论类型表(SysCommentType)
 /// 数据源类型:表
 /// (AutoGCLib.CommFun4BL4CSharp:GeneCode_This)
 /// </summary>
public class  clsCommFun4BL4SysCommentType : clsCommFun4BL
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
clsSysCommentTypeBL.ReFreshThisCache();
}
}

}