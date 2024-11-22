
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsDDLTabUserRelaBL
 表名:DDLTabUserRela(01120052)
 * 版本:2023.08.23.1(服务器:WIN-SRV103-116)
 日期:2023/08/24 13:08:46
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:公共后台所有表(变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:用户管理(UserManage)
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
public static class  clsDDLTabUserRelaBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public static clsDDLTabUserRelaEN GetObj(this K_mId_DDLTabUserRela myKey)
{
clsDDLTabUserRelaEN objDDLTabUserRelaEN = clsDDLTabUserRelaBL.DDLTabUserRelaDA.GetObjBymId(myKey.Value);
return objDDLTabUserRelaEN;
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_AddNewRecord)
 /// </summary>
 /// <param name = "objDDLTabUserRelaEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clsDDLTabUserRelaEN objDDLTabUserRelaEN)
{
if (CheckUniqueness(objDDLTabUserRelaEN) == false)
{
var strMsg = string.Format("记录已经存在!下拉框表Id = [{0}],用户ID = [{1}]的数据已经存在!(in clsDDLTabUserRelaBL.AddNewRecord)", objDDLTabUserRelaEN.DDLTabId,objDDLTabUserRelaEN.UserId);
throw new Exception(strMsg);
}
try
{
bool bolResult = clsDDLTabUserRelaBL.DDLTabUserRelaDA.AddNewRecordBySQL2(objDDLTabUserRelaEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsDDLTabUserRelaBL.ReFreshCache();

if (clsDDLTabUserRelaBL.relatedActions != null)
{
clsDDLTabUserRelaBL.relatedActions.UpdRelaTabDate(objDDLTabUserRelaEN.mId, objDDLTabUserRelaEN.UpdUser);
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
public static bool AddRecordEx(this clsDDLTabUserRelaEN objDDLTabUserRelaEN)
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
objDDLTabUserRelaEN.CheckPropertyNew();
 ///5.2、检查唯一性
if (objDDLTabUserRelaEN.CheckUniqueness() == false)
{
strMsg = string.Format("(下拉框表Id(DDLTabId)=[{0}],用户ID(UserId)=[{1}])已经存在,不能重复!", objDDLTabUserRelaEN.DDLTabId, objDDLTabUserRelaEN.UserId);
throw new Exception(strMsg);
}
//6、把数据实体层的数据存贮到数据库中
objDDLTabUserRelaEN.AddNewRecord();
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
 /// <param name = "objDDLTabUserRelaEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordWithReturnKey(this clsDDLTabUserRelaEN objDDLTabUserRelaEN)
{
if (CheckUniqueness(objDDLTabUserRelaEN) == false)
{
var strMsg = string.Format("记录已经存在!下拉框表Id = [{0}],用户ID = [{1}]的数据已经存在!(in clsDDLTabUserRelaBL.AddNewRecordWithReturnKey)", objDDLTabUserRelaEN.DDLTabId,objDDLTabUserRelaEN.UserId);
throw new Exception(strMsg);
}
try
{
string strKey = clsDDLTabUserRelaBL.DDLTabUserRelaDA.AddNewRecordBySQL2WithReturnKey(objDDLTabUserRelaEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsDDLTabUserRelaBL.ReFreshCache();

if (clsDDLTabUserRelaBL.relatedActions != null)
{
clsDDLTabUserRelaBL.relatedActions.UpdRelaTabDate(objDDLTabUserRelaEN.mId, objDDLTabUserRelaEN.UpdUser);
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
 /// <param name = "objDDLTabUserRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsDDLTabUserRelaEN SetmId(this clsDDLTabUserRelaEN objDDLTabUserRelaEN, long lngmId, string strComparisonOp="")
	{
objDDLTabUserRelaEN.mId = lngmId; //mId
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objDDLTabUserRelaEN.dicFldComparisonOp.ContainsKey(conDDLTabUserRela.mId) == false)
{
objDDLTabUserRelaEN.dicFldComparisonOp.Add(conDDLTabUserRela.mId, strComparisonOp);
}
else
{
objDDLTabUserRelaEN.dicFldComparisonOp[conDDLTabUserRela.mId] = strComparisonOp;
}
}
return objDDLTabUserRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objDDLTabUserRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsDDLTabUserRelaEN SetUserId(this clsDDLTabUserRelaEN objDDLTabUserRelaEN, string strUserId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUserId, 18, conDDLTabUserRela.UserId);
}
objDDLTabUserRelaEN.UserId = strUserId; //用户ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objDDLTabUserRelaEN.dicFldComparisonOp.ContainsKey(conDDLTabUserRela.UserId) == false)
{
objDDLTabUserRelaEN.dicFldComparisonOp.Add(conDDLTabUserRela.UserId, strComparisonOp);
}
else
{
objDDLTabUserRelaEN.dicFldComparisonOp[conDDLTabUserRela.UserId] = strComparisonOp;
}
}
return objDDLTabUserRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objDDLTabUserRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsDDLTabUserRelaEN SetDDLTabId(this clsDDLTabUserRelaEN objDDLTabUserRelaEN, string strDDLTabId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strDDLTabId, conDDLTabUserRela.DDLTabId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strDDLTabId, 4, conDDLTabUserRela.DDLTabId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strDDLTabId, 4, conDDLTabUserRela.DDLTabId);
}
objDDLTabUserRelaEN.DDLTabId = strDDLTabId; //下拉框表Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objDDLTabUserRelaEN.dicFldComparisonOp.ContainsKey(conDDLTabUserRela.DDLTabId) == false)
{
objDDLTabUserRelaEN.dicFldComparisonOp.Add(conDDLTabUserRela.DDLTabId, strComparisonOp);
}
else
{
objDDLTabUserRelaEN.dicFldComparisonOp[conDDLTabUserRela.DDLTabId] = strComparisonOp;
}
}
return objDDLTabUserRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objDDLTabUserRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsDDLTabUserRelaEN SetUpdDate(this clsDDLTabUserRelaEN objDDLTabUserRelaEN, string strUpdDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strUpdDate, conDDLTabUserRela.UpdDate);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdDate, 20, conDDLTabUserRela.UpdDate);
}
objDDLTabUserRelaEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objDDLTabUserRelaEN.dicFldComparisonOp.ContainsKey(conDDLTabUserRela.UpdDate) == false)
{
objDDLTabUserRelaEN.dicFldComparisonOp.Add(conDDLTabUserRela.UpdDate, strComparisonOp);
}
else
{
objDDLTabUserRelaEN.dicFldComparisonOp[conDDLTabUserRela.UpdDate] = strComparisonOp;
}
}
return objDDLTabUserRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objDDLTabUserRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsDDLTabUserRelaEN SetUpdUser(this clsDDLTabUserRelaEN objDDLTabUserRelaEN, string strUpdUser, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strUpdUser, conDDLTabUserRela.UpdUser);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdUser, 20, conDDLTabUserRela.UpdUser);
}
objDDLTabUserRelaEN.UpdUser = strUpdUser; //修改人
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objDDLTabUserRelaEN.dicFldComparisonOp.ContainsKey(conDDLTabUserRela.UpdUser) == false)
{
objDDLTabUserRelaEN.dicFldComparisonOp.Add(conDDLTabUserRela.UpdUser, strComparisonOp);
}
else
{
objDDLTabUserRelaEN.dicFldComparisonOp[conDDLTabUserRela.UpdUser] = strComparisonOp;
}
}
return objDDLTabUserRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objDDLTabUserRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsDDLTabUserRelaEN SetMemo(this clsDDLTabUserRelaEN objDDLTabUserRelaEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, conDDLTabUserRela.Memo);
}
objDDLTabUserRelaEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objDDLTabUserRelaEN.dicFldComparisonOp.ContainsKey(conDDLTabUserRela.Memo) == false)
{
objDDLTabUserRelaEN.dicFldComparisonOp.Add(conDDLTabUserRela.Memo, strComparisonOp);
}
else
{
objDDLTabUserRelaEN.dicFldComparisonOp[conDDLTabUserRela.Memo] = strComparisonOp;
}
}
return objDDLTabUserRelaEN;
	}

 /// <summary>
 /// 修改记录存盘到数据表中
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_UpdateRecordEx)
 /// </summary>
 /// <param name = "objDDLTabUserRelaEN">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool UpdateRecordEx(this clsDDLTabUserRelaEN objDDLTabUserRelaEN)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
try
{
//1、检查传进去的对象属性是否合法
objDDLTabUserRelaEN.CheckPropertyNew();
clsDDLTabUserRelaEN objDDLTabUserRelaCond = new clsDDLTabUserRelaEN();
string strCondition = objDDLTabUserRelaCond
.SetmId(objDDLTabUserRelaEN.mId, "<>")
.SetDDLTabId(objDDLTabUserRelaEN.DDLTabId, "=")
.SetUserId(objDDLTabUserRelaEN.UserId, "=")
.GetCombineCondition();
objDDLTabUserRelaEN._IsCheckProperty = true;
bool bolIsExist = clsDDLTabUserRelaBL.IsExistRecord(strCondition);
if (bolIsExist)
{
strMsg = "(DDLTabId_UserId)不能重复!";
throw new Exception(strMsg);
}
//4、把数据实体层的数据存贮到数据库中
objDDLTabUserRelaEN.Update();
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
 /// <param name = "objDDLTabUserRela">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool EditRecordEx(this clsDDLTabUserRelaEN objDDLTabUserRela)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
clsDDLTabUserRelaEN objDDLTabUserRelaCond = new clsDDLTabUserRelaEN();
string strCondition = objDDLTabUserRelaCond
.SetDDLTabId(objDDLTabUserRela.DDLTabId, "=")
.SetUserId(objDDLTabUserRela.UserId, "=")
.GetCombineCondition();
objDDLTabUserRela._IsCheckProperty = true;
bool bolIsExist = clsDDLTabUserRelaBL.IsExistRecord(strCondition);
if (bolIsExist)
{
objDDLTabUserRela.mId = clsDDLTabUserRelaBL.GetFirstID_S(strCondition);
objDDLTabUserRela.UpdateWithCondition(strCondition);
}
else
{
objDDLTabUserRela.AddNewRecord();
}
return true; 
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_Update)
 /// </summary>
 /// <param name = "objDDLTabUserRelaEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsDDLTabUserRelaEN objDDLTabUserRelaEN)
{
 if (objDDLTabUserRelaEN.mId == 0)
 {
string strMsg = string.Format("(errid:Busi000095)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsDDLTabUserRelaBL.DDLTabUserRelaDA.UpdateBySql2(objDDLTabUserRelaEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsDDLTabUserRelaBL.ReFreshCache();

if (clsDDLTabUserRelaBL.relatedActions != null)
{
clsDDLTabUserRelaBL.relatedActions.UpdRelaTabDate(objDDLTabUserRelaEN.mId, objDDLTabUserRelaEN.UpdUser);
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
 /// <param name = "objDDLTabUserRelaEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsDDLTabUserRelaEN objDDLTabUserRelaEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (objDDLTabUserRelaEN.mId == 0)
 {
string strMsg = string.Format("(errid:Busi000087)修改记录时关键字不能为空!(带事务处理)(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsDDLTabUserRelaBL.DDLTabUserRelaDA.UpdateBySql2(objDDLTabUserRelaEN, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsDDLTabUserRelaBL.ReFreshCache();

if (clsDDLTabUserRelaBL.relatedActions != null)
{
clsDDLTabUserRelaBL.relatedActions.UpdRelaTabDate(objDDLTabUserRelaEN.mId, objDDLTabUserRelaEN.UpdUser);
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
 /// <param name = "objDDLTabUserRelaEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsDDLTabUserRelaEN objDDLTabUserRelaEN, string strWhereCond)
{
try
{
bool bolResult = clsDDLTabUserRelaBL.DDLTabUserRelaDA.UpdateBySqlWithCondition(objDDLTabUserRelaEN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsDDLTabUserRelaBL.ReFreshCache();

if (clsDDLTabUserRelaBL.relatedActions != null)
{
clsDDLTabUserRelaBL.relatedActions.UpdRelaTabDate(objDDLTabUserRelaEN.mId, objDDLTabUserRelaEN.UpdUser);
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
 /// <param name = "objDDLTabUserRelaEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsDDLTabUserRelaEN objDDLTabUserRelaEN, string strWhereCond, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
bool bolResult = clsDDLTabUserRelaBL.DDLTabUserRelaDA.UpdateBySqlWithConditionTransaction(objDDLTabUserRelaEN, strWhereCond, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsDDLTabUserRelaBL.ReFreshCache();

if (clsDDLTabUserRelaBL.relatedActions != null)
{
clsDDLTabUserRelaBL.relatedActions.UpdRelaTabDate(objDDLTabUserRelaEN.mId, objDDLTabUserRelaEN.UpdUser);
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
public static int Delete(this clsDDLTabUserRelaEN objDDLTabUserRelaEN)
{
try
{
int intRecNum = clsDDLTabUserRelaBL.DDLTabUserRelaDA.DelRecord(objDDLTabUserRelaEN.mId);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsDDLTabUserRelaBL.ReFreshCache();

if (clsDDLTabUserRelaBL.relatedActions != null)
{
clsDDLTabUserRelaBL.relatedActions.UpdRelaTabDate(objDDLTabUserRelaEN.mId, objDDLTabUserRelaEN.UpdUser);
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
 /// <param name = "objDDLTabUserRelaENS">源对象</param>
 /// <param name = "objDDLTabUserRelaENT">目标对象</param>
 public static void CopyTo(this clsDDLTabUserRelaEN objDDLTabUserRelaENS, clsDDLTabUserRelaEN objDDLTabUserRelaENT)
{
try
{
objDDLTabUserRelaENT.mId = objDDLTabUserRelaENS.mId; //mId
objDDLTabUserRelaENT.UserId = objDDLTabUserRelaENS.UserId; //用户ID
objDDLTabUserRelaENT.DDLTabId = objDDLTabUserRelaENS.DDLTabId; //下拉框表Id
objDDLTabUserRelaENT.UpdDate = objDDLTabUserRelaENS.UpdDate; //修改日期
objDDLTabUserRelaENT.UpdUser = objDDLTabUserRelaENS.UpdUser; //修改人
objDDLTabUserRelaENT.Memo = objDDLTabUserRelaENS.Memo; //备注
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
 /// <param name = "objDDLTabUserRelaENS">源对象</param>
 /// <returns>目标对象=>clsDDLTabUserRelaEN:objDDLTabUserRelaENT</returns>
 public static clsDDLTabUserRelaEN CopyTo(this clsDDLTabUserRelaEN objDDLTabUserRelaENS)
{
try
{
 clsDDLTabUserRelaEN objDDLTabUserRelaENT = new clsDDLTabUserRelaEN()
{
mId = objDDLTabUserRelaENS.mId, //mId
UserId = objDDLTabUserRelaENS.UserId, //用户ID
DDLTabId = objDDLTabUserRelaENS.DDLTabId, //下拉框表Id
UpdDate = objDDLTabUserRelaENS.UpdDate, //修改日期
UpdUser = objDDLTabUserRelaENS.UpdUser, //修改人
Memo = objDDLTabUserRelaENS.Memo, //备注
};
 return objDDLTabUserRelaENT;
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
public static void CheckPropertyNew(this clsDDLTabUserRelaEN objDDLTabUserRelaEN)
{
 clsDDLTabUserRelaBL.DDLTabUserRelaDA.CheckPropertyNew(objDDLTabUserRelaEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(this clsDDLTabUserRelaEN objDDLTabUserRelaEN)
{
 clsDDLTabUserRelaBL.DDLTabUserRelaDA.CheckProperty4Condition(objDDLTabUserRelaEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsDDLTabUserRelaEN objDDLTabUserRelaCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objDDLTabUserRelaCond.IsUpdated(conDDLTabUserRela.mId) == true)
{
string strComparisonOpmId = objDDLTabUserRelaCond.dicFldComparisonOp[conDDLTabUserRela.mId];
strWhereCond += string.Format(" And {0} {2} {1}", conDDLTabUserRela.mId, objDDLTabUserRelaCond.mId, strComparisonOpmId);
}
if (objDDLTabUserRelaCond.IsUpdated(conDDLTabUserRela.UserId) == true)
{
string strComparisonOpUserId = objDDLTabUserRelaCond.dicFldComparisonOp[conDDLTabUserRela.UserId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conDDLTabUserRela.UserId, objDDLTabUserRelaCond.UserId, strComparisonOpUserId);
}
if (objDDLTabUserRelaCond.IsUpdated(conDDLTabUserRela.DDLTabId) == true)
{
string strComparisonOpDDLTabId = objDDLTabUserRelaCond.dicFldComparisonOp[conDDLTabUserRela.DDLTabId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conDDLTabUserRela.DDLTabId, objDDLTabUserRelaCond.DDLTabId, strComparisonOpDDLTabId);
}
if (objDDLTabUserRelaCond.IsUpdated(conDDLTabUserRela.UpdDate) == true)
{
string strComparisonOpUpdDate = objDDLTabUserRelaCond.dicFldComparisonOp[conDDLTabUserRela.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conDDLTabUserRela.UpdDate, objDDLTabUserRelaCond.UpdDate, strComparisonOpUpdDate);
}
if (objDDLTabUserRelaCond.IsUpdated(conDDLTabUserRela.UpdUser) == true)
{
string strComparisonOpUpdUser = objDDLTabUserRelaCond.dicFldComparisonOp[conDDLTabUserRela.UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", conDDLTabUserRela.UpdUser, objDDLTabUserRelaCond.UpdUser, strComparisonOpUpdUser);
}
if (objDDLTabUserRelaCond.IsUpdated(conDDLTabUserRela.Memo) == true)
{
string strComparisonOpMemo = objDDLTabUserRelaCond.dicFldComparisonOp[conDDLTabUserRela.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", conDDLTabUserRela.Memo, objDDLTabUserRelaCond.Memo, strComparisonOpMemo);
}
 return strWhereCond;
}

 /// <summary>
 /// 检查唯一性(Uniqueness)--DDLTabUserRela(下拉框表名用户关系), 如果不唯一,即存在相同的记录,就返回False
 /// 唯一性条件:DDLTabId_UserId
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckConstraint)
 /// </summary>
 /// <param name = "objDDLTabUserRelaEN">要求唯一的对象</param>
 /// <returns></returns>
public static bool CheckUniqueness(this clsDDLTabUserRelaEN objDDLTabUserRelaEN)
{
//检测记录是否存在
bool bolIsUniqueness;
StringBuilder sbCondition = new StringBuilder();
if (objDDLTabUserRelaEN == null) return true;
if (objDDLTabUserRelaEN.mId == 0)
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and DDLTabId = '{0}'", objDDLTabUserRelaEN.DDLTabId);
 if (objDDLTabUserRelaEN.UserId == null)
{
 sbCondition.AppendFormat(" and UserId is null", objDDLTabUserRelaEN.UserId);
}
else
{
 sbCondition.AppendFormat(" and UserId = '{0}'", objDDLTabUserRelaEN.UserId);
}
if (clsDDLTabUserRelaBL.IsExistRecord(sbCondition.ToString())  ==  true)
{
 bolIsUniqueness = false;
}
else
{
 bolIsUniqueness = true;
}
}
 else {
sbCondition.AppendFormat("mId !=  {0}", objDDLTabUserRelaEN.mId);
 sbCondition.AppendFormat(" and DDLTabId = '{0}'", objDDLTabUserRelaEN.DDLTabId);
 sbCondition.AppendFormat(" and UserId = '{0}'", objDDLTabUserRelaEN.UserId);
if (clsDDLTabUserRelaBL.IsExistRecord(sbCondition.ToString())  ==  true)
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
 /// 获取唯一性条件串--DDLTabUserRela(下拉框表名用户关系), 即由对象中唯一性条件字段关键字与值组成的条件串
 /// 唯一性条件:DDLTabId_UserId
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetConditionString4Constraint)
 /// </summary>
 /// <param name = "objDDLTabUserRelaEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(this clsDDLTabUserRelaEN objDDLTabUserRelaEN)
{
//检测记录是否存在
StringBuilder sbCondition = new StringBuilder();
if (objDDLTabUserRelaEN == null) return "";
if (objDDLTabUserRelaEN.mId == 0)
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and DDLTabId = '{0}'", objDDLTabUserRelaEN.DDLTabId);
 if (objDDLTabUserRelaEN.UserId == null)
{
 sbCondition.AppendFormat(" and UserId is null", objDDLTabUserRelaEN.UserId);
}
else
{
 sbCondition.AppendFormat(" and UserId = '{0}'", objDDLTabUserRelaEN.UserId);
}
return sbCondition.ToString();
}
 else {
sbCondition.AppendFormat("mId !=  {0}", objDDLTabUserRelaEN.mId);
 sbCondition.AppendFormat(" and DDLTabId = '{0}'", objDDLTabUserRelaEN.DDLTabId);
 sbCondition.AppendFormat(" and UserId = '{0}'", objDDLTabUserRelaEN.UserId);
 return sbCondition.ToString();
}
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_DDLTabUserRela
{
public virtual bool UpdRelaTabDate(long lngmId, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// 下拉框表名用户关系(DDLTabUserRela)
 /// 数据源类型:表
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsDDLTabUserRelaBL
{
public static RelatedActions_DDLTabUserRela relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsDDLTabUserRelaDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsDDLTabUserRelaDA DDLTabUserRelaDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsDDLTabUserRelaDA();
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
 public clsDDLTabUserRelaBL()
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
if (string.IsNullOrEmpty(clsDDLTabUserRelaEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsDDLTabUserRelaEN._ConnectString);
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
public static DataTable GetDataTable_DDLTabUserRela(string strWhereCond)
{
DataTable objDT;
try
{
objDT = DDLTabUserRelaDA.GetDataTable_DDLTabUserRela(strWhereCond);
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
objDT = DDLTabUserRelaDA.GetDataTable(strWhereCond);
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
objDT = DDLTabUserRelaDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = DDLTabUserRelaDA.GetDataTable(strWhereCond, strTabName);
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
objDT = DDLTabUserRelaDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = DDLTabUserRelaDA.GetDataTable_Top(objTopPara);
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
objDT = DDLTabUserRelaDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = DDLTabUserRelaDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = DDLTabUserRelaDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
public static List<clsDDLTabUserRelaEN> GetObjLstByMIdLst(List<long> arrMIdLst)
{
List<clsDDLTabUserRelaEN> arrObjLst = new List<clsDDLTabUserRelaEN>(); 
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
	clsDDLTabUserRelaEN objDDLTabUserRelaEN = new clsDDLTabUserRelaEN();
try
{
objDDLTabUserRelaEN.mId = Int32.Parse(objRow[conDDLTabUserRela.mId].ToString().Trim()); //mId
objDDLTabUserRelaEN.UserId = objRow[conDDLTabUserRela.UserId] == DBNull.Value ? null : objRow[conDDLTabUserRela.UserId].ToString().Trim(); //用户ID
objDDLTabUserRelaEN.DDLTabId = objRow[conDDLTabUserRela.DDLTabId].ToString().Trim(); //下拉框表Id
objDDLTabUserRelaEN.UpdDate = objRow[conDDLTabUserRela.UpdDate].ToString().Trim(); //修改日期
objDDLTabUserRelaEN.UpdUser = objRow[conDDLTabUserRela.UpdUser].ToString().Trim(); //修改人
objDDLTabUserRelaEN.Memo = objRow[conDDLTabUserRela.Memo] == DBNull.Value ? null : objRow[conDDLTabUserRela.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objDDLTabUserRelaEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objDDLTabUserRelaEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrMIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsDDLTabUserRelaEN> GetObjLstByMIdLstCache(List<long> arrMIdLst)
{
string strKey = string.Format("{0}", clsDDLTabUserRelaEN._CurrTabName);
List<clsDDLTabUserRelaEN> arrDDLTabUserRelaObjLstCache = GetObjLstCache();
IEnumerable <clsDDLTabUserRelaEN> arrDDLTabUserRelaObjLst_Sel =
arrDDLTabUserRelaObjLstCache
.Where(x => arrMIdLst.Contains(x.mId));
return arrDDLTabUserRelaObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsDDLTabUserRelaEN> GetObjLst(string strWhereCond)
{
List<clsDDLTabUserRelaEN> arrObjLst = new List<clsDDLTabUserRelaEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsDDLTabUserRelaEN objDDLTabUserRelaEN = new clsDDLTabUserRelaEN();
try
{
objDDLTabUserRelaEN.mId = Int32.Parse(objRow[conDDLTabUserRela.mId].ToString().Trim()); //mId
objDDLTabUserRelaEN.UserId = objRow[conDDLTabUserRela.UserId] == DBNull.Value ? null : objRow[conDDLTabUserRela.UserId].ToString().Trim(); //用户ID
objDDLTabUserRelaEN.DDLTabId = objRow[conDDLTabUserRela.DDLTabId].ToString().Trim(); //下拉框表Id
objDDLTabUserRelaEN.UpdDate = objRow[conDDLTabUserRela.UpdDate].ToString().Trim(); //修改日期
objDDLTabUserRelaEN.UpdUser = objRow[conDDLTabUserRela.UpdUser].ToString().Trim(); //修改人
objDDLTabUserRelaEN.Memo = objRow[conDDLTabUserRela.Memo] == DBNull.Value ? null : objRow[conDDLTabUserRela.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objDDLTabUserRelaEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objDDLTabUserRelaEN);
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
public static List<clsDDLTabUserRelaEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsDDLTabUserRelaEN> arrObjLst = new List<clsDDLTabUserRelaEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsDDLTabUserRelaEN objDDLTabUserRelaEN = new clsDDLTabUserRelaEN();
try
{
objDDLTabUserRelaEN.mId = Int32.Parse(objRow[conDDLTabUserRela.mId].ToString().Trim()); //mId
objDDLTabUserRelaEN.UserId = objRow[conDDLTabUserRela.UserId] == DBNull.Value ? null : objRow[conDDLTabUserRela.UserId].ToString().Trim(); //用户ID
objDDLTabUserRelaEN.DDLTabId = objRow[conDDLTabUserRela.DDLTabId].ToString().Trim(); //下拉框表Id
objDDLTabUserRelaEN.UpdDate = objRow[conDDLTabUserRela.UpdDate].ToString().Trim(); //修改日期
objDDLTabUserRelaEN.UpdUser = objRow[conDDLTabUserRela.UpdUser].ToString().Trim(); //修改人
objDDLTabUserRelaEN.Memo = objRow[conDDLTabUserRela.Memo] == DBNull.Value ? null : objRow[conDDLTabUserRela.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objDDLTabUserRelaEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objDDLTabUserRelaEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objDDLTabUserRelaCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsDDLTabUserRelaEN> GetSubObjLstCache(clsDDLTabUserRelaEN objDDLTabUserRelaCond)
{
List<clsDDLTabUserRelaEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsDDLTabUserRelaEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conDDLTabUserRela.AttributeName)
{
if (objDDLTabUserRelaCond.IsUpdated(strFldName) == false) continue;
if (objDDLTabUserRelaCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objDDLTabUserRelaCond[strFldName].ToString());
}
else
{
if (objDDLTabUserRelaCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objDDLTabUserRelaCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objDDLTabUserRelaCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objDDLTabUserRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objDDLTabUserRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objDDLTabUserRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objDDLTabUserRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objDDLTabUserRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objDDLTabUserRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objDDLTabUserRelaCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objDDLTabUserRelaCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objDDLTabUserRelaCond[strFldName]));
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
public static List<clsDDLTabUserRelaEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsDDLTabUserRelaEN> arrObjLst = new List<clsDDLTabUserRelaEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsDDLTabUserRelaEN objDDLTabUserRelaEN = new clsDDLTabUserRelaEN();
try
{
objDDLTabUserRelaEN.mId = Int32.Parse(objRow[conDDLTabUserRela.mId].ToString().Trim()); //mId
objDDLTabUserRelaEN.UserId = objRow[conDDLTabUserRela.UserId] == DBNull.Value ? null : objRow[conDDLTabUserRela.UserId].ToString().Trim(); //用户ID
objDDLTabUserRelaEN.DDLTabId = objRow[conDDLTabUserRela.DDLTabId].ToString().Trim(); //下拉框表Id
objDDLTabUserRelaEN.UpdDate = objRow[conDDLTabUserRela.UpdDate].ToString().Trim(); //修改日期
objDDLTabUserRelaEN.UpdUser = objRow[conDDLTabUserRela.UpdUser].ToString().Trim(); //修改人
objDDLTabUserRelaEN.Memo = objRow[conDDLTabUserRela.Memo] == DBNull.Value ? null : objRow[conDDLTabUserRela.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objDDLTabUserRelaEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objDDLTabUserRelaEN);
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
public static List<clsDDLTabUserRelaEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsDDLTabUserRelaEN> arrObjLst = new List<clsDDLTabUserRelaEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsDDLTabUserRelaEN objDDLTabUserRelaEN = new clsDDLTabUserRelaEN();
try
{
objDDLTabUserRelaEN.mId = Int32.Parse(objRow[conDDLTabUserRela.mId].ToString().Trim()); //mId
objDDLTabUserRelaEN.UserId = objRow[conDDLTabUserRela.UserId] == DBNull.Value ? null : objRow[conDDLTabUserRela.UserId].ToString().Trim(); //用户ID
objDDLTabUserRelaEN.DDLTabId = objRow[conDDLTabUserRela.DDLTabId].ToString().Trim(); //下拉框表Id
objDDLTabUserRelaEN.UpdDate = objRow[conDDLTabUserRela.UpdDate].ToString().Trim(); //修改日期
objDDLTabUserRelaEN.UpdUser = objRow[conDDLTabUserRela.UpdUser].ToString().Trim(); //修改人
objDDLTabUserRelaEN.Memo = objRow[conDDLTabUserRela.Memo] == DBNull.Value ? null : objRow[conDDLTabUserRela.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objDDLTabUserRelaEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objDDLTabUserRelaEN);
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
List<clsDDLTabUserRelaEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsDDLTabUserRelaEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsDDLTabUserRelaEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsDDLTabUserRelaEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsDDLTabUserRelaEN> arrObjLst = new List<clsDDLTabUserRelaEN>(); 
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
	clsDDLTabUserRelaEN objDDLTabUserRelaEN = new clsDDLTabUserRelaEN();
try
{
objDDLTabUserRelaEN.mId = Int32.Parse(objRow[conDDLTabUserRela.mId].ToString().Trim()); //mId
objDDLTabUserRelaEN.UserId = objRow[conDDLTabUserRela.UserId] == DBNull.Value ? null : objRow[conDDLTabUserRela.UserId].ToString().Trim(); //用户ID
objDDLTabUserRelaEN.DDLTabId = objRow[conDDLTabUserRela.DDLTabId].ToString().Trim(); //下拉框表Id
objDDLTabUserRelaEN.UpdDate = objRow[conDDLTabUserRela.UpdDate].ToString().Trim(); //修改日期
objDDLTabUserRelaEN.UpdUser = objRow[conDDLTabUserRela.UpdUser].ToString().Trim(); //修改人
objDDLTabUserRelaEN.Memo = objRow[conDDLTabUserRela.Memo] == DBNull.Value ? null : objRow[conDDLTabUserRela.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objDDLTabUserRelaEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objDDLTabUserRelaEN);
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
public static List<clsDDLTabUserRelaEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsDDLTabUserRelaEN> arrObjLst = new List<clsDDLTabUserRelaEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsDDLTabUserRelaEN objDDLTabUserRelaEN = new clsDDLTabUserRelaEN();
try
{
objDDLTabUserRelaEN.mId = Int32.Parse(objRow[conDDLTabUserRela.mId].ToString().Trim()); //mId
objDDLTabUserRelaEN.UserId = objRow[conDDLTabUserRela.UserId] == DBNull.Value ? null : objRow[conDDLTabUserRela.UserId].ToString().Trim(); //用户ID
objDDLTabUserRelaEN.DDLTabId = objRow[conDDLTabUserRela.DDLTabId].ToString().Trim(); //下拉框表Id
objDDLTabUserRelaEN.UpdDate = objRow[conDDLTabUserRela.UpdDate].ToString().Trim(); //修改日期
objDDLTabUserRelaEN.UpdUser = objRow[conDDLTabUserRela.UpdUser].ToString().Trim(); //修改人
objDDLTabUserRelaEN.Memo = objRow[conDDLTabUserRela.Memo] == DBNull.Value ? null : objRow[conDDLTabUserRela.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objDDLTabUserRelaEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objDDLTabUserRelaEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsDDLTabUserRelaEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsDDLTabUserRelaEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsDDLTabUserRelaEN> arrObjLst = new List<clsDDLTabUserRelaEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsDDLTabUserRelaEN objDDLTabUserRelaEN = new clsDDLTabUserRelaEN();
try
{
objDDLTabUserRelaEN.mId = Int32.Parse(objRow[conDDLTabUserRela.mId].ToString().Trim()); //mId
objDDLTabUserRelaEN.UserId = objRow[conDDLTabUserRela.UserId] == DBNull.Value ? null : objRow[conDDLTabUserRela.UserId].ToString().Trim(); //用户ID
objDDLTabUserRelaEN.DDLTabId = objRow[conDDLTabUserRela.DDLTabId].ToString().Trim(); //下拉框表Id
objDDLTabUserRelaEN.UpdDate = objRow[conDDLTabUserRela.UpdDate].ToString().Trim(); //修改日期
objDDLTabUserRelaEN.UpdUser = objRow[conDDLTabUserRela.UpdUser].ToString().Trim(); //修改人
objDDLTabUserRelaEN.Memo = objRow[conDDLTabUserRela.Memo] == DBNull.Value ? null : objRow[conDDLTabUserRela.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objDDLTabUserRelaEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objDDLTabUserRelaEN);
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
public static List<clsDDLTabUserRelaEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsDDLTabUserRelaEN> arrObjLst = new List<clsDDLTabUserRelaEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsDDLTabUserRelaEN objDDLTabUserRelaEN = new clsDDLTabUserRelaEN();
try
{
objDDLTabUserRelaEN.mId = Int32.Parse(objRow[conDDLTabUserRela.mId].ToString().Trim()); //mId
objDDLTabUserRelaEN.UserId = objRow[conDDLTabUserRela.UserId] == DBNull.Value ? null : objRow[conDDLTabUserRela.UserId].ToString().Trim(); //用户ID
objDDLTabUserRelaEN.DDLTabId = objRow[conDDLTabUserRela.DDLTabId].ToString().Trim(); //下拉框表Id
objDDLTabUserRelaEN.UpdDate = objRow[conDDLTabUserRela.UpdDate].ToString().Trim(); //修改日期
objDDLTabUserRelaEN.UpdUser = objRow[conDDLTabUserRela.UpdUser].ToString().Trim(); //修改人
objDDLTabUserRelaEN.Memo = objRow[conDDLTabUserRela.Memo] == DBNull.Value ? null : objRow[conDDLTabUserRela.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objDDLTabUserRelaEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objDDLTabUserRelaEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsDDLTabUserRelaEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsDDLTabUserRelaEN> arrObjLst = new List<clsDDLTabUserRelaEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsDDLTabUserRelaEN objDDLTabUserRelaEN = new clsDDLTabUserRelaEN();
try
{
objDDLTabUserRelaEN.mId = Int32.Parse(objRow[conDDLTabUserRela.mId].ToString().Trim()); //mId
objDDLTabUserRelaEN.UserId = objRow[conDDLTabUserRela.UserId] == DBNull.Value ? null : objRow[conDDLTabUserRela.UserId].ToString().Trim(); //用户ID
objDDLTabUserRelaEN.DDLTabId = objRow[conDDLTabUserRela.DDLTabId].ToString().Trim(); //下拉框表Id
objDDLTabUserRelaEN.UpdDate = objRow[conDDLTabUserRela.UpdDate].ToString().Trim(); //修改日期
objDDLTabUserRelaEN.UpdUser = objRow[conDDLTabUserRela.UpdUser].ToString().Trim(); //修改人
objDDLTabUserRelaEN.Memo = objRow[conDDLTabUserRela.Memo] == DBNull.Value ? null : objRow[conDDLTabUserRela.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objDDLTabUserRelaEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objDDLTabUserRelaEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objDDLTabUserRelaEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetDDLTabUserRela(ref clsDDLTabUserRelaEN objDDLTabUserRelaEN)
{
bool bolResult = DDLTabUserRelaDA.GetDDLTabUserRela(ref objDDLTabUserRelaEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public static clsDDLTabUserRelaEN GetObjBymId(long lngmId)
{
clsDDLTabUserRelaEN objDDLTabUserRelaEN = DDLTabUserRelaDA.GetObjBymId(lngmId);
return objDDLTabUserRelaEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsDDLTabUserRelaEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsDDLTabUserRelaEN objDDLTabUserRelaEN = DDLTabUserRelaDA.GetFirstObj(strWhereCond);
 return objDDLTabUserRelaEN;
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
public static clsDDLTabUserRelaEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsDDLTabUserRelaEN objDDLTabUserRelaEN = DDLTabUserRelaDA.GetObjByDataRow(objRow);
 return objDDLTabUserRelaEN;
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
public static clsDDLTabUserRelaEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsDDLTabUserRelaEN objDDLTabUserRelaEN = DDLTabUserRelaDA.GetObjByDataRow(objRow);
 return objDDLTabUserRelaEN;
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
 /// <param name = "lstDDLTabUserRelaObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsDDLTabUserRelaEN GetObjBymIdFromList(long lngmId, List<clsDDLTabUserRelaEN> lstDDLTabUserRelaObjLst)
{
foreach (clsDDLTabUserRelaEN objDDLTabUserRelaEN in lstDDLTabUserRelaObjLst)
{
if (objDDLTabUserRelaEN.mId == lngmId)
{
return objDDLTabUserRelaEN;
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
 lngmId = new clsDDLTabUserRelaDA().GetFirstID(strWhereCond);
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
 arrList = DDLTabUserRelaDA.GetID(strWhereCond);
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
bool bolIsExist = DDLTabUserRelaDA.IsExistCondRec(strWhereCond);
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
bool bolIsExist = DDLTabUserRelaDA.IsExist(lngmId);
return bolIsExist;
}

/// <summary>
/// 设置修改时间
/// </summary>
/// <param name = "lngmId">mId</param>
/// <param name = "strOpUser">修改用户</param>
/// <returns>是否成功？</returns>
public static bool SetUpdDate(long lngmId, string strOpUser)
{
clsDDLTabUserRelaEN objDDLTabUserRelaEN = clsDDLTabUserRelaBL.GetObjBymId(lngmId);
objDDLTabUserRelaEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
objDDLTabUserRelaEN.UpdUser = strOpUser;
return clsDDLTabUserRelaBL.UpdateBySql2(objDDLTabUserRelaEN);
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
 bolIsExist = clsDDLTabUserRelaDA.IsExistTable();
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
 bolIsExist = DDLTabUserRelaDA.IsExistTable(strTabName);
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
 /// <param name = "objDDLTabUserRelaEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecordBySql2(clsDDLTabUserRelaEN objDDLTabUserRelaEN)
{
if (objDDLTabUserRelaEN.CheckUniqueness() == false)
{
var strMsg = string.Format("记录已经存在!下拉框表Id = [{0}],用户ID = [{1}]的数据已经存在!(in clsDDLTabUserRelaBL.AddNewRecordBySql2)", objDDLTabUserRelaEN.DDLTabId,objDDLTabUserRelaEN.UserId);
throw new Exception(strMsg);
}
try
{
bool bolResult = DDLTabUserRelaDA.AddNewRecordBySQL2(objDDLTabUserRelaEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsDDLTabUserRelaBL.ReFreshCache();

if (clsDDLTabUserRelaBL.relatedActions != null)
{
clsDDLTabUserRelaBL.relatedActions.UpdRelaTabDate(objDDLTabUserRelaEN.mId, objDDLTabUserRelaEN.UpdUser);
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
 /// <param name = "objDDLTabUserRelaEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordBySql2WithReturnKey(clsDDLTabUserRelaEN objDDLTabUserRelaEN)
{
if (objDDLTabUserRelaEN.CheckUniqueness() == false)
{
var strMsg = string.Format("记录已经存在!下拉框表Id = [{0}],用户ID = [{1}]的数据已经存在!(in clsDDLTabUserRelaBL.AddNewRecordBySql2WithReturnKey)", objDDLTabUserRelaEN.DDLTabId,objDDLTabUserRelaEN.UserId);
throw new Exception(strMsg);
}
try
{
string strKey = DDLTabUserRelaDA.AddNewRecordBySQL2WithReturnKey(objDDLTabUserRelaEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsDDLTabUserRelaBL.ReFreshCache();

if (clsDDLTabUserRelaBL.relatedActions != null)
{
clsDDLTabUserRelaBL.relatedActions.UpdRelaTabDate(objDDLTabUserRelaEN.mId, objDDLTabUserRelaEN.UpdUser);
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
 /// <param name = "objDDLTabUserRelaEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(clsDDLTabUserRelaEN objDDLTabUserRelaEN)
{
try
{
bool bolResult = DDLTabUserRelaDA.Update(objDDLTabUserRelaEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsDDLTabUserRelaBL.ReFreshCache();

if (clsDDLTabUserRelaBL.relatedActions != null)
{
clsDDLTabUserRelaBL.relatedActions.UpdRelaTabDate(objDDLTabUserRelaEN.mId, objDDLTabUserRelaEN.UpdUser);
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
 /// <param name = "objDDLTabUserRelaEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateBySql2(clsDDLTabUserRelaEN objDDLTabUserRelaEN)
{
 if (objDDLTabUserRelaEN.mId == 0)
 {
var strMsg = string.Format("(errid:Busi000065)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = DDLTabUserRelaDA.UpdateBySql2(objDDLTabUserRelaEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsDDLTabUserRelaBL.ReFreshCache();

if (clsDDLTabUserRelaBL.relatedActions != null)
{
clsDDLTabUserRelaBL.relatedActions.UpdRelaTabDate(objDDLTabUserRelaEN.mId, objDDLTabUserRelaEN.UpdUser);
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
 clsDDLTabUserRelaEN objDDLTabUserRelaEN = clsDDLTabUserRelaBL.GetObjBymId(lngmId);

if (clsDDLTabUserRelaBL.relatedActions != null)
{
clsDDLTabUserRelaBL.relatedActions.UpdRelaTabDate(objDDLTabUserRelaEN.mId, objDDLTabUserRelaEN.UpdUser);
}
if (objDDLTabUserRelaEN != null)
{
int intRecNum = DDLTabUserRelaDA.DelRecord(lngmId);
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
objSQL = clsDDLTabUserRelaDA.GetSpecSQLObj();
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
//删除与表:[DDLTabUserRela]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conDDLTabUserRela.mId,
//lngmId);
//        clsDDLTabUserRelaBL.DelDDLTabUserRelasByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsDDLTabUserRelaBL.DelRecord(lngmId, objConnection, objSqlTransaction);
objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsDDLTabUserRelaBLEx", "DelRecordEx", objException.Message, clsSysParaEN.strUserId);
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
if (clsDDLTabUserRelaBL.relatedActions != null)
{
clsDDLTabUserRelaBL.relatedActions.UpdRelaTabDate(lngmId, "UpdRelaTabDate");
}
bool bolResult = DDLTabUserRelaDA.DelRecord(lngmId,objSqlConnection,objSqlTransaction);
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
public static int DelDDLTabUserRelas(List<string> arrmIdLst)
{
if (arrmIdLst.Count == 0) return 0;
try
{
if (clsDDLTabUserRelaBL.relatedActions != null)
{
foreach (var strmId in arrmIdLst)
{
long lngmId = long.Parse(strmId);
clsDDLTabUserRelaBL.relatedActions.UpdRelaTabDate(lngmId, "UpdRelaTabDate");
}
}
int intDelRecNum = DDLTabUserRelaDA.DelDDLTabUserRela(arrmIdLst);
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
public static int DelDDLTabUserRelasByCond(string strWhereCond)
{
try
{
if (clsDDLTabUserRelaBL.relatedActions != null)
{
List<string> arrmId = GetPrimaryKeyID_S(strWhereCond);
foreach (var strmId in arrmId)
{
long lngmId = long.Parse(strmId);
clsDDLTabUserRelaBL.relatedActions.UpdRelaTabDate(lngmId, "UpdRelaTabDate");
}
}
int intRecNum = DDLTabUserRelaDA.DelDDLTabUserRela(strWhereCond);
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
/// 这里仅仅是演示函数,使用时请复制到扩展类:[DDLTabUserRela]中改名为:[DelRecord4MultiTabEx]使用
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DelRecord4MultiTab)
/// </summary>
/// <param name="lngmId">表关键字</param>
/// <returns></returns>
public static bool DelRecord4MultiTab(long lngmId)
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsDDLTabUserRelaDA.GetSpecSQLObj();
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
//删除与表:[DDLTabUserRela]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conStudent.id_College,
//strid_College);
//        clsStudentBL.DelStudentsByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsDDLTabUserRelaBL.DelRecord(lngmId, objConnection, objSqlTransaction);
                objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsDDLTabUserRelaBL", "DelRecord4MultiTab", objException.Message, clsSysParaEN.strUserId);
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
 /// <param name = "objDDLTabUserRelaENS">源对象</param>
 /// <param name = "objDDLTabUserRelaENT">目标对象</param>
 public static void CopyTo(clsDDLTabUserRelaEN objDDLTabUserRelaENS, clsDDLTabUserRelaEN objDDLTabUserRelaENT)
{
try
{
objDDLTabUserRelaENT.mId = objDDLTabUserRelaENS.mId; //mId
objDDLTabUserRelaENT.UserId = objDDLTabUserRelaENS.UserId; //用户ID
objDDLTabUserRelaENT.DDLTabId = objDDLTabUserRelaENS.DDLTabId; //下拉框表Id
objDDLTabUserRelaENT.UpdDate = objDDLTabUserRelaENS.UpdDate; //修改日期
objDDLTabUserRelaENT.UpdUser = objDDLTabUserRelaENS.UpdUser; //修改人
objDDLTabUserRelaENT.Memo = objDDLTabUserRelaENS.Memo; //备注
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
 /// <param name = "objDDLTabUserRelaEN">源简化对象</param>
 public static void SetUpdFlag(clsDDLTabUserRelaEN objDDLTabUserRelaEN)
{
try
{
objDDLTabUserRelaEN.ClearUpdateState();
   string strsfUpdFldSetStr = objDDLTabUserRelaEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(conDDLTabUserRela.mId, new clsStrCompareIgnoreCase())  ==  true)
{
objDDLTabUserRelaEN.mId = objDDLTabUserRelaEN.mId; //mId
}
if (arrFldSet.Contains(conDDLTabUserRela.UserId, new clsStrCompareIgnoreCase())  ==  true)
{
objDDLTabUserRelaEN.UserId = objDDLTabUserRelaEN.UserId == "[null]" ? null :  objDDLTabUserRelaEN.UserId; //用户ID
}
if (arrFldSet.Contains(conDDLTabUserRela.DDLTabId, new clsStrCompareIgnoreCase())  ==  true)
{
objDDLTabUserRelaEN.DDLTabId = objDDLTabUserRelaEN.DDLTabId; //下拉框表Id
}
if (arrFldSet.Contains(conDDLTabUserRela.UpdDate, new clsStrCompareIgnoreCase())  ==  true)
{
objDDLTabUserRelaEN.UpdDate = objDDLTabUserRelaEN.UpdDate; //修改日期
}
if (arrFldSet.Contains(conDDLTabUserRela.UpdUser, new clsStrCompareIgnoreCase())  ==  true)
{
objDDLTabUserRelaEN.UpdUser = objDDLTabUserRelaEN.UpdUser; //修改人
}
if (arrFldSet.Contains(conDDLTabUserRela.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objDDLTabUserRelaEN.Memo = objDDLTabUserRelaEN.Memo == "[null]" ? null :  objDDLTabUserRelaEN.Memo; //备注
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
 /// <param name = "objDDLTabUserRelaEN">源简化对象</param>
 public static void AccessFldValueNull(clsDDLTabUserRelaEN objDDLTabUserRelaEN)
{
try
{
if (objDDLTabUserRelaEN.UserId == "[null]") objDDLTabUserRelaEN.UserId = null; //用户ID
if (objDDLTabUserRelaEN.Memo == "[null]") objDDLTabUserRelaEN.Memo = null; //备注
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
public static void CheckPropertyNew(clsDDLTabUserRelaEN objDDLTabUserRelaEN)
{
 DDLTabUserRelaDA.CheckPropertyNew(objDDLTabUserRelaEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(clsDDLTabUserRelaEN objDDLTabUserRelaEN)
{
 DDLTabUserRelaDA.CheckProperty4Condition(objDDLTabUserRelaEN);
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
if (clsDDLTabUserRelaBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsDDLTabUserRelaBL没有刷新缓存机制(clsDDLTabUserRelaBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by mId");
//if (arrDDLTabUserRelaObjLstCache == null)
//{
//arrDDLTabUserRelaObjLstCache = DDLTabUserRelaDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "lngmId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsDDLTabUserRelaEN GetObjBymIdCache(long lngmId)
{
//获取缓存中的对象列表
string strKey = string.Format("{0}", clsDDLTabUserRelaEN._CurrTabName);
List<clsDDLTabUserRelaEN> arrDDLTabUserRelaObjLstCache = GetObjLstCache();
IEnumerable <clsDDLTabUserRelaEN> arrDDLTabUserRelaObjLst_Sel =
arrDDLTabUserRelaObjLstCache
.Where(x=> x.mId == lngmId 
);
if (arrDDLTabUserRelaObjLst_Sel.Count() == 0)
{
   clsDDLTabUserRelaEN obj = clsDDLTabUserRelaBL.GetObjBymId(lngmId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
 }
return null;
}
return arrDDLTabUserRelaObjLst_Sel.First();
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsDDLTabUserRelaEN> GetAllDDLTabUserRelaObjLstCache()
{
//获取缓存中的对象列表
List<clsDDLTabUserRelaEN> arrDDLTabUserRelaObjLstCache = GetObjLstCache(); 
return arrDDLTabUserRelaObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsDDLTabUserRelaEN> GetObjLstCache()
{
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}", clsDDLTabUserRelaEN._CurrTabName);
List<clsDDLTabUserRelaEN> arrDDLTabUserRelaObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrDDLTabUserRelaObjLstCache;
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
string strKey = string.Format("{0}", clsDDLTabUserRelaEN._CurrTabName);
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
if (clsDDLTabUserRelaBL.objCommFun4BL != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}", clsDDLTabUserRelaEN._CurrTabName);
CacheHelper.Remove(strKey);
clsDDLTabUserRelaBL.objCommFun4BL.ReFreshCache();
}
}


 #endregion 缓存操作


 #region 检查唯一性

 /// <summary>
 /// 获取检查唯一性条件串(Uniqueness)--DDLTabUserRela(下拉框表名用户关系)
 /// 唯一性条件:DDLTabId_UserId
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetUniquenessConditionString)
 /// </summary>
 /// <param name = "objDDLTabUserRelaEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(clsDDLTabUserRelaEN objDDLTabUserRelaEN)
{
//检测记录是否存在
string strResult = DDLTabUserRelaDA.GetUniCondStr(objDDLTabUserRelaEN);
return strResult;
}


 #endregion 检查唯一性

 /// <summary>
 /// 映射函数。根据表映射把输入字段值,映射成输出字段值
 /// 作者:pyf
 /// 日期:2023-08-24
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_func)
 /// </summary>
 /// <param name = "strInFldName">输入字段名</param>
 /// <param name = "strOutFldName">输出字段名</param>
 /// <param name = "strInValue">输入字段值</param>
 /// <returns>返回一个输出字段值</returns>
public static string Func(string strInFldName, string strOutFldName, long lngmId)
{
if (strInFldName != conDDLTabUserRela.mId)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (conDDLTabUserRela.AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", conDDLTabUserRela.AttributeName));
throw new Exception(strMsg);
}
var objDDLTabUserRela = clsDDLTabUserRelaBL.GetObjBymIdCache(lngmId);
if (objDDLTabUserRela == null) return "";
return objDDLTabUserRela[strOutFldName].ToString();
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
int intRecCount = clsDDLTabUserRelaDA.GetRecCount(strTabName);
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
int intRecCount = clsDDLTabUserRelaDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsDDLTabUserRelaDA.GetRecCount();
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
int intRecCount = clsDDLTabUserRelaDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objDDLTabUserRelaCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsDDLTabUserRelaEN objDDLTabUserRelaCond)
{
List<clsDDLTabUserRelaEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsDDLTabUserRelaEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conDDLTabUserRela.AttributeName)
{
if (objDDLTabUserRelaCond.IsUpdated(strFldName) == false) continue;
if (objDDLTabUserRelaCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objDDLTabUserRelaCond[strFldName].ToString());
}
else
{
if (objDDLTabUserRelaCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objDDLTabUserRelaCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objDDLTabUserRelaCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objDDLTabUserRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objDDLTabUserRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objDDLTabUserRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objDDLTabUserRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objDDLTabUserRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objDDLTabUserRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objDDLTabUserRelaCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objDDLTabUserRelaCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objDDLTabUserRelaCond[strFldName]));
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
 List<string> arrList = clsDDLTabUserRelaDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = DDLTabUserRelaDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = DDLTabUserRelaDA.GetFldValueNoDistinct(strFldName, strWhereCond);
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
int intRecCount = DDLTabUserRelaDA.SetFldValue(strFldName, strValue, strWhereCond);
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
int intRecCount = clsDDLTabUserRelaDA.SetFldValue(clsDDLTabUserRelaEN._CurrTabName, strFldName, fltValue, strWhereCond);
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
int intRecCount = DDLTabUserRelaDA.SetFldValue( strFldName, intValue, strWhereCond);
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
int intRecCount = clsDDLTabUserRelaDA.SetFldValue(strTabName, strFldName, strValue, strWhereCond);
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
int intRecCount = clsDDLTabUserRelaDA.SetFldValue(strTabName, strFldName, intValue, strWhereCond);
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
int intRecCount = clsDDLTabUserRelaDA.SetFldValue(strTabName, strFldName, fltValue, strWhereCond);
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
  strCreateTabCode.Append("CREATE table [dbo].[DDLTabUserRela] "); 
 strCreateTabCode.Append(" ( "); 
 // /**mId*/ 
 strCreateTabCode.Append(" mId bigint primary key identity, "); 
 // /**用户ID*/ 
 strCreateTabCode.Append(" UserId varchar(18) Null, "); 
 // /**下拉框表Id*/ 
 strCreateTabCode.Append(" DDLTabId char(4) not Null, "); 
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
 /// 下拉框表名用户关系(DDLTabUserRela)
 /// 数据源类型:表
 /// (AutoGCLib.CommFun4BL4CSharp:GeneCode_This)
 /// </summary>
public class  clsCommFun4BL4DDLTabUserRela : clsCommFun4BL
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
clsDDLTabUserRelaBL.ReFreshThisCache();
}
}

}