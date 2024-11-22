
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clssys_RequestTypeBL
 表名:sys_RequestType(01120727)
 * 版本:2024.11.13.1(服务器:WIN-SRV103-116)
 日期:2024/11/13 06:16:26
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:研究生学习游戏化后台(000055, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:研培设置(GradEduTools)
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
public static class  clssys_RequestTypeBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "strRequestTypeId">表关键字</param>
 /// <returns>表对象</returns>
public static clssys_RequestTypeEN GetObj(this K_RequestTypeId_sys_RequestType myKey)
{
clssys_RequestTypeEN objsys_RequestTypeEN = clssys_RequestTypeBL.sys_RequestTypeDA.GetObjByRequestTypeId(myKey.Value);
return objsys_RequestTypeEN;
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_AddNewRecord)
 /// </summary>
 /// <param name = "objsys_RequestTypeEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clssys_RequestTypeEN objsys_RequestTypeEN, bool bolIsNeedCheckUniqueness = true)
{
if (bolIsNeedCheckUniqueness == true && CheckUniqueness(objsys_RequestTypeEN) == false)
{
var strMsg = string.Format("记录已经存在!RequestTableId = [{0}],RequestTypeId = [{1}]的数据已经存在!(in clssys_RequestTypeBL.AddNewRecord)", objsys_RequestTypeEN.RequestTableId,objsys_RequestTypeEN.RequestTypeId);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objsys_RequestTypeEN.RequestTypeId) == true || clssys_RequestTypeBL.IsExist(objsys_RequestTypeEN.RequestTypeId) == true)
 {
     objsys_RequestTypeEN.RequestTypeId = clssys_RequestTypeBL.GetMaxStrId_S();
 }
bool bolResult = clssys_RequestTypeBL.sys_RequestTypeDA.AddNewRecordBySQL2(objsys_RequestTypeEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clssys_RequestTypeBL.ReFreshCache();

if (clssys_RequestTypeBL.relatedActions != null)
{
clssys_RequestTypeBL.relatedActions.UpdRelaTabDate(objsys_RequestTypeEN.RequestTypeId, "SetUpdDate");
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
public static bool AddRecordEx(this clssys_RequestTypeEN objsys_RequestTypeEN, bool bolIsNeedCheckUniqueness = true)
{
//操作步骤:
//1、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在
//2、检查唯一性
//3、检查传进去的对象属性是否合法
//4、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
//1、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在

//因为是字符型自增主键,不需要检查主键是否已经存在,在添加时,再获取 最大值作为主键
//if (clssys_RequestTypeBL.IsExist(objsys_RequestTypeEN.RequestTypeId))	//判断是否有相同的关键字
//{
//strMsg = "(errid:Busi000151)关键字字段已有相同的值";
//throw new Exception(strMsg);
//}
try
{
 //2、检查传进去的对象属性是否合法
objsys_RequestTypeEN.CheckPropertyNew();
 ///5.2、检查唯一性
if (bolIsNeedCheckUniqueness == true && objsys_RequestTypeEN.CheckUniqueness() == false)
{
strMsg = string.Format("(RequestTableId(RequestTableId)=[{0}],RequestTypeId(RequestTypeId)=[{1}])已经存在,不能重复!", objsys_RequestTypeEN.RequestTableId, objsys_RequestTypeEN.RequestTypeId);
throw new Exception(strMsg);
}
//因为是字符型自增主键,所以在添加时,自动获取主键值。
 if (string.IsNullOrEmpty(objsys_RequestTypeEN.RequestTypeId) == true || clssys_RequestTypeBL.IsExist(objsys_RequestTypeEN.RequestTypeId) == true)
 {
     objsys_RequestTypeEN.RequestTypeId = clssys_RequestTypeBL.GetMaxStrId_S();
 }
//6、把数据实体层的数据存贮到数据库中
objsys_RequestTypeEN.AddNewRecord();
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
 /// <param name = "objsys_RequestTypeEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static string AddNewRecordWithMaxId(this clssys_RequestTypeEN objsys_RequestTypeEN, bool bolIsNeedCheckUniqueness = true)
{
if (bolIsNeedCheckUniqueness == true && CheckUniqueness(objsys_RequestTypeEN) == false)
{
var strMsg = string.Format("记录已经存在!RequestTableId = [{0}],RequestTypeId = [{1}]的数据已经存在!(in clssys_RequestTypeBL.AddNewRecordWithMaxId)", objsys_RequestTypeEN.RequestTableId,objsys_RequestTypeEN.RequestTypeId);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objsys_RequestTypeEN.RequestTypeId) == true || clssys_RequestTypeBL.IsExist(objsys_RequestTypeEN.RequestTypeId) == true)
 {
     objsys_RequestTypeEN.RequestTypeId = clssys_RequestTypeBL.GetMaxStrId_S();
 }
string strRequestTypeId = clssys_RequestTypeBL.sys_RequestTypeDA.AddNewRecordBySQL2WithReturnKey(objsys_RequestTypeEN);
     objsys_RequestTypeEN.RequestTypeId = strRequestTypeId;
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clssys_RequestTypeBL.ReFreshCache();

if (clssys_RequestTypeBL.relatedActions != null)
{
clssys_RequestTypeBL.relatedActions.UpdRelaTabDate(objsys_RequestTypeEN.RequestTypeId, "SetUpdDate");
}
return strRequestTypeId;
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
 /// <param name = "objsys_RequestTypeEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordWithReturnKey(this clssys_RequestTypeEN objsys_RequestTypeEN, bool bolIsNeedCheckUniqueness = true)
{
if (bolIsNeedCheckUniqueness == true && CheckUniqueness(objsys_RequestTypeEN) == false)
{
var strMsg = string.Format("记录已经存在!RequestTableId = [{0}],RequestTypeId = [{1}]的数据已经存在!(in clssys_RequestTypeBL.AddNewRecordWithReturnKey)", objsys_RequestTypeEN.RequestTableId,objsys_RequestTypeEN.RequestTypeId);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objsys_RequestTypeEN.RequestTypeId) == true || clssys_RequestTypeBL.IsExist(objsys_RequestTypeEN.RequestTypeId) == true)
 {
     objsys_RequestTypeEN.RequestTypeId = clssys_RequestTypeBL.GetMaxStrId_S();
 }
string strKey = clssys_RequestTypeBL.sys_RequestTypeDA.AddNewRecordBySQL2WithReturnKey(objsys_RequestTypeEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clssys_RequestTypeBL.ReFreshCache();

if (clssys_RequestTypeBL.relatedActions != null)
{
clssys_RequestTypeBL.relatedActions.UpdRelaTabDate(objsys_RequestTypeEN.RequestTypeId, "SetUpdDate");
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
 /// <param name = "objsys_RequestTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clssys_RequestTypeEN SetRequestTypeId(this clssys_RequestTypeEN objsys_RequestTypeEN, string strRequestTypeId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strRequestTypeId, 2, consys_RequestType.RequestTypeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strRequestTypeId, 2, consys_RequestType.RequestTypeId);
}
objsys_RequestTypeEN.RequestTypeId = strRequestTypeId; //RequestTypeId
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objsys_RequestTypeEN.dicFldComparisonOp.ContainsKey(consys_RequestType.RequestTypeId) == false)
{
objsys_RequestTypeEN.dicFldComparisonOp.Add(consys_RequestType.RequestTypeId, strComparisonOp);
}
else
{
objsys_RequestTypeEN.dicFldComparisonOp[consys_RequestType.RequestTypeId] = strComparisonOp;
}
}
return objsys_RequestTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objsys_RequestTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clssys_RequestTypeEN SetRequestTypeName(this clssys_RequestTypeEN objsys_RequestTypeEN, string strRequestTypeName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strRequestTypeName, 50, consys_RequestType.RequestTypeName);
}
objsys_RequestTypeEN.RequestTypeName = strRequestTypeName; //RequestTypeName
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objsys_RequestTypeEN.dicFldComparisonOp.ContainsKey(consys_RequestType.RequestTypeName) == false)
{
objsys_RequestTypeEN.dicFldComparisonOp.Add(consys_RequestType.RequestTypeName, strComparisonOp);
}
else
{
objsys_RequestTypeEN.dicFldComparisonOp[consys_RequestType.RequestTypeName] = strComparisonOp;
}
}
return objsys_RequestTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objsys_RequestTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clssys_RequestTypeEN SetRequestTable(this clssys_RequestTypeEN objsys_RequestTypeEN, string strRequestTable, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strRequestTable, 50, consys_RequestType.RequestTable);
}
objsys_RequestTypeEN.RequestTable = strRequestTable; //RequestTable
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objsys_RequestTypeEN.dicFldComparisonOp.ContainsKey(consys_RequestType.RequestTable) == false)
{
objsys_RequestTypeEN.dicFldComparisonOp.Add(consys_RequestType.RequestTable, strComparisonOp);
}
else
{
objsys_RequestTypeEN.dicFldComparisonOp[consys_RequestType.RequestTable] = strComparisonOp;
}
}
return objsys_RequestTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objsys_RequestTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clssys_RequestTypeEN SetRequestTableId(this clssys_RequestTypeEN objsys_RequestTypeEN, string strRequestTableId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strRequestTableId, 50, consys_RequestType.RequestTableId);
}
objsys_RequestTypeEN.RequestTableId = strRequestTableId; //RequestTableId
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objsys_RequestTypeEN.dicFldComparisonOp.ContainsKey(consys_RequestType.RequestTableId) == false)
{
objsys_RequestTypeEN.dicFldComparisonOp.Add(consys_RequestType.RequestTableId, strComparisonOp);
}
else
{
objsys_RequestTypeEN.dicFldComparisonOp[consys_RequestType.RequestTableId] = strComparisonOp;
}
}
return objsys_RequestTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objsys_RequestTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clssys_RequestTypeEN SetMemo(this clssys_RequestTypeEN objsys_RequestTypeEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, consys_RequestType.Memo);
}
objsys_RequestTypeEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objsys_RequestTypeEN.dicFldComparisonOp.ContainsKey(consys_RequestType.Memo) == false)
{
objsys_RequestTypeEN.dicFldComparisonOp.Add(consys_RequestType.Memo, strComparisonOp);
}
else
{
objsys_RequestTypeEN.dicFldComparisonOp[consys_RequestType.Memo] = strComparisonOp;
}
}
return objsys_RequestTypeEN;
	}

 /// <summary>
 /// 修改记录存盘到数据表中
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_UpdateRecordEx)
 /// </summary>
 /// <param name = "objsys_RequestTypeEN">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool UpdateRecordEx(this clssys_RequestTypeEN objsys_RequestTypeEN)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
try
{
//1、检查传进去的对象属性是否合法
objsys_RequestTypeEN.CheckPropertyNew();
clssys_RequestTypeEN objsys_RequestTypeCond = new clssys_RequestTypeEN();
string strCondition = objsys_RequestTypeCond
.SetRequestTypeId(objsys_RequestTypeEN.RequestTypeId, "<>")
.SetRequestTableId(objsys_RequestTypeEN.RequestTableId, "=")
.SetRequestTypeId(objsys_RequestTypeEN.RequestTypeId, "=")
.GetCombineCondition();
objsys_RequestTypeEN._IsCheckProperty = true;
bool bolIsExist = clssys_RequestTypeBL.IsExistRecord(strCondition);
if (bolIsExist)
{
strMsg = "(RequestTableId_RequestTypeId)不能重复!";
throw new Exception(strMsg);
}
//4、把数据实体层的数据存贮到数据库中
objsys_RequestTypeEN.Update();
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
 /// <param name = "objsys_RequestType">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool EditRecordEx(this clssys_RequestTypeEN objsys_RequestType)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
clssys_RequestTypeEN objsys_RequestTypeCond = new clssys_RequestTypeEN();
string strCondition = objsys_RequestTypeCond
.SetRequestTableId(objsys_RequestType.RequestTableId, "=")
.SetRequestTypeId(objsys_RequestType.RequestTypeId, "=")
.GetCombineCondition();
objsys_RequestType._IsCheckProperty = true;
bool bolIsExist = clssys_RequestTypeBL.IsExistRecord(strCondition);
if (bolIsExist)
{
objsys_RequestType.RequestTypeId = clssys_RequestTypeBL.GetFirstID_S(strCondition);
objsys_RequestType.UpdateWithCondition(strCondition);
}
else
{
objsys_RequestType.RequestTypeId = clssys_RequestTypeBL.GetMaxStrId_S();
objsys_RequestType.AddNewRecord();
}
return true; 
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_Update)
 /// </summary>
 /// <param name = "objsys_RequestTypeEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clssys_RequestTypeEN objsys_RequestTypeEN)
{
 if (string.IsNullOrEmpty(objsys_RequestTypeEN.RequestTypeId) == true)
 {
string strMsg = string.Format("(errid:Busi000095)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clssys_RequestTypeBL.sys_RequestTypeDA.UpdateBySql2(objsys_RequestTypeEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clssys_RequestTypeBL.ReFreshCache();

if (clssys_RequestTypeBL.relatedActions != null)
{
clssys_RequestTypeBL.relatedActions.UpdRelaTabDate(objsys_RequestTypeEN.RequestTypeId, "SetUpdDate");
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
 /// <param name = "objsys_RequestTypeEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clssys_RequestTypeEN objsys_RequestTypeEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (string.IsNullOrEmpty(objsys_RequestTypeEN.RequestTypeId) == true)
 {
string strMsg = string.Format("(errid:Busi000087)修改记录时关键字不能为空!(带事务处理)(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clssys_RequestTypeBL.sys_RequestTypeDA.UpdateBySql2(objsys_RequestTypeEN, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clssys_RequestTypeBL.ReFreshCache();

if (clssys_RequestTypeBL.relatedActions != null)
{
clssys_RequestTypeBL.relatedActions.UpdRelaTabDate(objsys_RequestTypeEN.RequestTypeId, "SetUpdDate");
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
 /// <param name = "objsys_RequestTypeEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clssys_RequestTypeEN objsys_RequestTypeEN, string strWhereCond)
{
try
{
bool bolResult = clssys_RequestTypeBL.sys_RequestTypeDA.UpdateBySqlWithCondition(objsys_RequestTypeEN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clssys_RequestTypeBL.ReFreshCache();

if (clssys_RequestTypeBL.relatedActions != null)
{
clssys_RequestTypeBL.relatedActions.UpdRelaTabDate(objsys_RequestTypeEN.RequestTypeId, "SetUpdDate");
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
 /// <param name = "objsys_RequestTypeEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clssys_RequestTypeEN objsys_RequestTypeEN, string strWhereCond, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
bool bolResult = clssys_RequestTypeBL.sys_RequestTypeDA.UpdateBySqlWithConditionTransaction(objsys_RequestTypeEN, strWhereCond, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clssys_RequestTypeBL.ReFreshCache();

if (clssys_RequestTypeBL.relatedActions != null)
{
clssys_RequestTypeBL.relatedActions.UpdRelaTabDate(objsys_RequestTypeEN.RequestTypeId, "SetUpdDate");
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
 /// <param name = "strRequestTypeId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int Delete(this clssys_RequestTypeEN objsys_RequestTypeEN)
{
try
{
int intRecNum = clssys_RequestTypeBL.sys_RequestTypeDA.DelRecord(objsys_RequestTypeEN.RequestTypeId);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clssys_RequestTypeBL.ReFreshCache();

if (clssys_RequestTypeBL.relatedActions != null)
{
clssys_RequestTypeBL.relatedActions.UpdRelaTabDate(objsys_RequestTypeEN.RequestTypeId, "SetUpdDate");
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
 /// <param name = "objsys_RequestTypeENS">源对象</param>
 /// <param name = "objsys_RequestTypeENT">目标对象</param>
 public static void CopyTo(this clssys_RequestTypeEN objsys_RequestTypeENS, clssys_RequestTypeEN objsys_RequestTypeENT)
{
try
{
objsys_RequestTypeENT.RequestTypeId = objsys_RequestTypeENS.RequestTypeId; //RequestTypeId
objsys_RequestTypeENT.RequestTypeName = objsys_RequestTypeENS.RequestTypeName; //RequestTypeName
objsys_RequestTypeENT.RequestTable = objsys_RequestTypeENS.RequestTable; //RequestTable
objsys_RequestTypeENT.RequestTableId = objsys_RequestTypeENS.RequestTableId; //RequestTableId
objsys_RequestTypeENT.Memo = objsys_RequestTypeENS.Memo; //备注
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
 /// <param name = "objsys_RequestTypeENS">源对象</param>
 /// <returns>目标对象=>clssys_RequestTypeEN:objsys_RequestTypeENT</returns>
 public static clssys_RequestTypeEN CopyTo(this clssys_RequestTypeEN objsys_RequestTypeENS)
{
try
{
 clssys_RequestTypeEN objsys_RequestTypeENT = new clssys_RequestTypeEN()
{
RequestTypeId = objsys_RequestTypeENS.RequestTypeId, //RequestTypeId
RequestTypeName = objsys_RequestTypeENS.RequestTypeName, //RequestTypeName
RequestTable = objsys_RequestTypeENS.RequestTable, //RequestTable
RequestTableId = objsys_RequestTypeENS.RequestTableId, //RequestTableId
Memo = objsys_RequestTypeENS.Memo, //备注
};
 return objsys_RequestTypeENT;
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
public static void CheckPropertyNew(this clssys_RequestTypeEN objsys_RequestTypeEN)
{
 clssys_RequestTypeBL.sys_RequestTypeDA.CheckPropertyNew(objsys_RequestTypeEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(this clssys_RequestTypeEN objsys_RequestTypeEN)
{
 clssys_RequestTypeBL.sys_RequestTypeDA.CheckProperty4Condition(objsys_RequestTypeEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clssys_RequestTypeEN objsys_RequestTypeCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objsys_RequestTypeCond.IsUpdated(consys_RequestType.RequestTypeId) == true)
{
string strComparisonOpRequestTypeId = objsys_RequestTypeCond.dicFldComparisonOp[consys_RequestType.RequestTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", consys_RequestType.RequestTypeId, objsys_RequestTypeCond.RequestTypeId, strComparisonOpRequestTypeId);
}
if (objsys_RequestTypeCond.IsUpdated(consys_RequestType.RequestTypeName) == true)
{
string strComparisonOpRequestTypeName = objsys_RequestTypeCond.dicFldComparisonOp[consys_RequestType.RequestTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", consys_RequestType.RequestTypeName, objsys_RequestTypeCond.RequestTypeName, strComparisonOpRequestTypeName);
}
if (objsys_RequestTypeCond.IsUpdated(consys_RequestType.RequestTable) == true)
{
string strComparisonOpRequestTable = objsys_RequestTypeCond.dicFldComparisonOp[consys_RequestType.RequestTable];
strWhereCond += string.Format(" And {0} {2} '{1}'", consys_RequestType.RequestTable, objsys_RequestTypeCond.RequestTable, strComparisonOpRequestTable);
}
if (objsys_RequestTypeCond.IsUpdated(consys_RequestType.RequestTableId) == true)
{
string strComparisonOpRequestTableId = objsys_RequestTypeCond.dicFldComparisonOp[consys_RequestType.RequestTableId];
strWhereCond += string.Format(" And {0} {2} '{1}'", consys_RequestType.RequestTableId, objsys_RequestTypeCond.RequestTableId, strComparisonOpRequestTableId);
}
if (objsys_RequestTypeCond.IsUpdated(consys_RequestType.Memo) == true)
{
string strComparisonOpMemo = objsys_RequestTypeCond.dicFldComparisonOp[consys_RequestType.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", consys_RequestType.Memo, objsys_RequestTypeCond.Memo, strComparisonOpMemo);
}
 return strWhereCond;
}

 /// <summary>
 /// 检查唯一性(Uniqueness)--sys_RequestType(请求类型表), 如果不唯一,即存在相同的记录,就返回False
 /// 唯一性条件:RequestTableId_RequestTypeId
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckConstraint)
 /// </summary>
 /// <param name = "objsys_RequestTypeEN">要求唯一的对象</param>
 /// <returns></returns>
public static bool CheckUniqueness(this clssys_RequestTypeEN objsys_RequestTypeEN)
{
//检测记录是否存在
bool bolIsUniqueness;
StringBuilder sbCondition = new StringBuilder();
if (objsys_RequestTypeEN == null) return true;
if (objsys_RequestTypeEN.RequestTypeId == null || objsys_RequestTypeEN.RequestTypeId == "")
{
sbCondition.AppendFormat("1 = 1");
 if (objsys_RequestTypeEN.RequestTableId == null)
{
 sbCondition.AppendFormat(" and RequestTableId is null", objsys_RequestTypeEN.RequestTableId);
}
else
{
 sbCondition.AppendFormat(" and RequestTableId = '{0}'", objsys_RequestTypeEN.RequestTableId);
}
 sbCondition.AppendFormat(" and RequestTypeId = '{0}'", objsys_RequestTypeEN.RequestTypeId);
if (clssys_RequestTypeBL.IsExistRecord(sbCondition.ToString())  ==  true)
{
 bolIsUniqueness = false;
}
else
{
 bolIsUniqueness = true;
}
}
 else {
sbCondition.AppendFormat("RequestTypeId !=  '{0}'", objsys_RequestTypeEN.RequestTypeId);
 sbCondition.AppendFormat(" and RequestTableId = '{0}'", objsys_RequestTypeEN.RequestTableId);
 sbCondition.AppendFormat(" and RequestTypeId = '{0}'", objsys_RequestTypeEN.RequestTypeId);
if (clssys_RequestTypeBL.IsExistRecord(sbCondition.ToString())  ==  true)
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
 /// 获取唯一性条件串--sys_RequestType(请求类型表), 即由对象中唯一性条件字段关键字与值组成的条件串
 /// 唯一性条件:RequestTableId_RequestTypeId
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetConditionString4Constraint)
 /// </summary>
 /// <param name = "objsys_RequestTypeEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(this clssys_RequestTypeEN objsys_RequestTypeEN)
{
//检测记录是否存在
StringBuilder sbCondition = new StringBuilder();
if (objsys_RequestTypeEN == null) return "";
if (objsys_RequestTypeEN.RequestTypeId == null || objsys_RequestTypeEN.RequestTypeId == "")
{
sbCondition.AppendFormat("1 = 1");
 if (objsys_RequestTypeEN.RequestTableId == null)
{
 sbCondition.AppendFormat(" and RequestTableId is null", objsys_RequestTypeEN.RequestTableId);
}
else
{
 sbCondition.AppendFormat(" and RequestTableId = '{0}'", objsys_RequestTypeEN.RequestTableId);
}
 sbCondition.AppendFormat(" and RequestTypeId = '{0}'", objsys_RequestTypeEN.RequestTypeId);
return sbCondition.ToString();
}
 else {
sbCondition.AppendFormat("RequestTypeId !=  '{0}'", objsys_RequestTypeEN.RequestTypeId);
 sbCondition.AppendFormat(" and RequestTableId = '{0}'", objsys_RequestTypeEN.RequestTableId);
 sbCondition.AppendFormat(" and RequestTypeId = '{0}'", objsys_RequestTypeEN.RequestTypeId);
 return sbCondition.ToString();
}
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_sys_RequestType
{
public virtual bool UpdRelaTabDate(string strRequestTypeId, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// 请求类型表(sys_RequestType)
 /// 数据源类型:表
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clssys_RequestTypeBL
{
public static RelatedActions_sys_RequestType relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clssys_RequestTypeDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clssys_RequestTypeDA sys_RequestTypeDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clssys_RequestTypeDA();
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
 public clssys_RequestTypeBL()
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
if (string.IsNullOrEmpty(clssys_RequestTypeEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clssys_RequestTypeEN._ConnectString);
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
public static DataTable GetDataTable_sys_RequestType(string strWhereCond)
{
DataTable objDT;
try
{
objDT = sys_RequestTypeDA.GetDataTable_sys_RequestType(strWhereCond);
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
objDT = sys_RequestTypeDA.GetDataTable(strWhereCond);
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
objDT = sys_RequestTypeDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = sys_RequestTypeDA.GetDataTable(strWhereCond, strTabName);
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
objDT = sys_RequestTypeDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = sys_RequestTypeDA.GetDataTable_Top(objTopPara);
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
objDT = sys_RequestTypeDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = sys_RequestTypeDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = sys_RequestTypeDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
 /// <param name = "arrRequestTypeIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static List<clssys_RequestTypeEN> GetObjLstByRequestTypeIdLst(List<string> arrRequestTypeIdLst)
{
List<clssys_RequestTypeEN> arrObjLst = new List<clssys_RequestTypeEN>(); 
System.Data.DataTable objDT; 
 string strSqlConditionStr = clsArray.GetSqlInStrByArray(arrRequestTypeIdLst, true);
 string strWhereCond = string.Format("RequestTypeId in ({0})", strSqlConditionStr);
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clssys_RequestTypeEN objsys_RequestTypeEN = new clssys_RequestTypeEN();
try
{
objsys_RequestTypeEN.RequestTypeId = objRow[consys_RequestType.RequestTypeId].ToString().Trim(); //RequestTypeId
objsys_RequestTypeEN.RequestTypeName = objRow[consys_RequestType.RequestTypeName] == DBNull.Value ? null : objRow[consys_RequestType.RequestTypeName].ToString().Trim(); //RequestTypeName
objsys_RequestTypeEN.RequestTable = objRow[consys_RequestType.RequestTable] == DBNull.Value ? null : objRow[consys_RequestType.RequestTable].ToString().Trim(); //RequestTable
objsys_RequestTypeEN.RequestTableId = objRow[consys_RequestType.RequestTableId] == DBNull.Value ? null : objRow[consys_RequestType.RequestTableId].ToString().Trim(); //RequestTableId
objsys_RequestTypeEN.Memo = objRow[consys_RequestType.Memo] == DBNull.Value ? null : objRow[consys_RequestType.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objsys_RequestTypeEN.RequestTypeId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objsys_RequestTypeEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrRequestTypeIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clssys_RequestTypeEN> GetObjLstByRequestTypeIdLstCache(List<string> arrRequestTypeIdLst)
{
string strKey = string.Format("{0}", clssys_RequestTypeEN._CurrTabName);
List<clssys_RequestTypeEN> arrsys_RequestTypeObjLstCache = GetObjLstCache();
IEnumerable <clssys_RequestTypeEN> arrsys_RequestTypeObjLst_Sel =
arrsys_RequestTypeObjLstCache
.Where(x => arrRequestTypeIdLst.Contains(x.RequestTypeId));
return arrsys_RequestTypeObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clssys_RequestTypeEN> GetObjLst(string strWhereCond)
{
List<clssys_RequestTypeEN> arrObjLst = new List<clssys_RequestTypeEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clssys_RequestTypeEN objsys_RequestTypeEN = new clssys_RequestTypeEN();
try
{
objsys_RequestTypeEN.RequestTypeId = objRow[consys_RequestType.RequestTypeId].ToString().Trim(); //RequestTypeId
objsys_RequestTypeEN.RequestTypeName = objRow[consys_RequestType.RequestTypeName] == DBNull.Value ? null : objRow[consys_RequestType.RequestTypeName].ToString().Trim(); //RequestTypeName
objsys_RequestTypeEN.RequestTable = objRow[consys_RequestType.RequestTable] == DBNull.Value ? null : objRow[consys_RequestType.RequestTable].ToString().Trim(); //RequestTable
objsys_RequestTypeEN.RequestTableId = objRow[consys_RequestType.RequestTableId] == DBNull.Value ? null : objRow[consys_RequestType.RequestTableId].ToString().Trim(); //RequestTableId
objsys_RequestTypeEN.Memo = objRow[consys_RequestType.Memo] == DBNull.Value ? null : objRow[consys_RequestType.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objsys_RequestTypeEN.RequestTypeId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objsys_RequestTypeEN);
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
public static List<clssys_RequestTypeEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clssys_RequestTypeEN> arrObjLst = new List<clssys_RequestTypeEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clssys_RequestTypeEN objsys_RequestTypeEN = new clssys_RequestTypeEN();
try
{
objsys_RequestTypeEN.RequestTypeId = objRow[consys_RequestType.RequestTypeId].ToString().Trim(); //RequestTypeId
objsys_RequestTypeEN.RequestTypeName = objRow[consys_RequestType.RequestTypeName] == DBNull.Value ? null : objRow[consys_RequestType.RequestTypeName].ToString().Trim(); //RequestTypeName
objsys_RequestTypeEN.RequestTable = objRow[consys_RequestType.RequestTable] == DBNull.Value ? null : objRow[consys_RequestType.RequestTable].ToString().Trim(); //RequestTable
objsys_RequestTypeEN.RequestTableId = objRow[consys_RequestType.RequestTableId] == DBNull.Value ? null : objRow[consys_RequestType.RequestTableId].ToString().Trim(); //RequestTableId
objsys_RequestTypeEN.Memo = objRow[consys_RequestType.Memo] == DBNull.Value ? null : objRow[consys_RequestType.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objsys_RequestTypeEN.RequestTypeId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objsys_RequestTypeEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objsys_RequestTypeCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clssys_RequestTypeEN> GetSubObjLstCache(clssys_RequestTypeEN objsys_RequestTypeCond)
{
List<clssys_RequestTypeEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clssys_RequestTypeEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in consys_RequestType.AttributeName)
{
if (objsys_RequestTypeCond.IsUpdated(strFldName) == false) continue;
if (objsys_RequestTypeCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objsys_RequestTypeCond[strFldName].ToString());
}
else
{
if (objsys_RequestTypeCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objsys_RequestTypeCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objsys_RequestTypeCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objsys_RequestTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objsys_RequestTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objsys_RequestTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objsys_RequestTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objsys_RequestTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objsys_RequestTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objsys_RequestTypeCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objsys_RequestTypeCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objsys_RequestTypeCond[strFldName]));
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
public static List<clssys_RequestTypeEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clssys_RequestTypeEN> arrObjLst = new List<clssys_RequestTypeEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clssys_RequestTypeEN objsys_RequestTypeEN = new clssys_RequestTypeEN();
try
{
objsys_RequestTypeEN.RequestTypeId = objRow[consys_RequestType.RequestTypeId].ToString().Trim(); //RequestTypeId
objsys_RequestTypeEN.RequestTypeName = objRow[consys_RequestType.RequestTypeName] == DBNull.Value ? null : objRow[consys_RequestType.RequestTypeName].ToString().Trim(); //RequestTypeName
objsys_RequestTypeEN.RequestTable = objRow[consys_RequestType.RequestTable] == DBNull.Value ? null : objRow[consys_RequestType.RequestTable].ToString().Trim(); //RequestTable
objsys_RequestTypeEN.RequestTableId = objRow[consys_RequestType.RequestTableId] == DBNull.Value ? null : objRow[consys_RequestType.RequestTableId].ToString().Trim(); //RequestTableId
objsys_RequestTypeEN.Memo = objRow[consys_RequestType.Memo] == DBNull.Value ? null : objRow[consys_RequestType.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objsys_RequestTypeEN.RequestTypeId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objsys_RequestTypeEN);
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
public static List<clssys_RequestTypeEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clssys_RequestTypeEN> arrObjLst = new List<clssys_RequestTypeEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clssys_RequestTypeEN objsys_RequestTypeEN = new clssys_RequestTypeEN();
try
{
objsys_RequestTypeEN.RequestTypeId = objRow[consys_RequestType.RequestTypeId].ToString().Trim(); //RequestTypeId
objsys_RequestTypeEN.RequestTypeName = objRow[consys_RequestType.RequestTypeName] == DBNull.Value ? null : objRow[consys_RequestType.RequestTypeName].ToString().Trim(); //RequestTypeName
objsys_RequestTypeEN.RequestTable = objRow[consys_RequestType.RequestTable] == DBNull.Value ? null : objRow[consys_RequestType.RequestTable].ToString().Trim(); //RequestTable
objsys_RequestTypeEN.RequestTableId = objRow[consys_RequestType.RequestTableId] == DBNull.Value ? null : objRow[consys_RequestType.RequestTableId].ToString().Trim(); //RequestTableId
objsys_RequestTypeEN.Memo = objRow[consys_RequestType.Memo] == DBNull.Value ? null : objRow[consys_RequestType.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objsys_RequestTypeEN.RequestTypeId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objsys_RequestTypeEN);
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
List<clssys_RequestTypeEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clssys_RequestTypeEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clssys_RequestTypeEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clssys_RequestTypeEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clssys_RequestTypeEN> arrObjLst = new List<clssys_RequestTypeEN>(); 
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
	clssys_RequestTypeEN objsys_RequestTypeEN = new clssys_RequestTypeEN();
try
{
objsys_RequestTypeEN.RequestTypeId = objRow[consys_RequestType.RequestTypeId].ToString().Trim(); //RequestTypeId
objsys_RequestTypeEN.RequestTypeName = objRow[consys_RequestType.RequestTypeName] == DBNull.Value ? null : objRow[consys_RequestType.RequestTypeName].ToString().Trim(); //RequestTypeName
objsys_RequestTypeEN.RequestTable = objRow[consys_RequestType.RequestTable] == DBNull.Value ? null : objRow[consys_RequestType.RequestTable].ToString().Trim(); //RequestTable
objsys_RequestTypeEN.RequestTableId = objRow[consys_RequestType.RequestTableId] == DBNull.Value ? null : objRow[consys_RequestType.RequestTableId].ToString().Trim(); //RequestTableId
objsys_RequestTypeEN.Memo = objRow[consys_RequestType.Memo] == DBNull.Value ? null : objRow[consys_RequestType.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objsys_RequestTypeEN.RequestTypeId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objsys_RequestTypeEN);
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
public static List<clssys_RequestTypeEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clssys_RequestTypeEN> arrObjLst = new List<clssys_RequestTypeEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clssys_RequestTypeEN objsys_RequestTypeEN = new clssys_RequestTypeEN();
try
{
objsys_RequestTypeEN.RequestTypeId = objRow[consys_RequestType.RequestTypeId].ToString().Trim(); //RequestTypeId
objsys_RequestTypeEN.RequestTypeName = objRow[consys_RequestType.RequestTypeName] == DBNull.Value ? null : objRow[consys_RequestType.RequestTypeName].ToString().Trim(); //RequestTypeName
objsys_RequestTypeEN.RequestTable = objRow[consys_RequestType.RequestTable] == DBNull.Value ? null : objRow[consys_RequestType.RequestTable].ToString().Trim(); //RequestTable
objsys_RequestTypeEN.RequestTableId = objRow[consys_RequestType.RequestTableId] == DBNull.Value ? null : objRow[consys_RequestType.RequestTableId].ToString().Trim(); //RequestTableId
objsys_RequestTypeEN.Memo = objRow[consys_RequestType.Memo] == DBNull.Value ? null : objRow[consys_RequestType.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objsys_RequestTypeEN.RequestTypeId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objsys_RequestTypeEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clssys_RequestTypeEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clssys_RequestTypeEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clssys_RequestTypeEN> arrObjLst = new List<clssys_RequestTypeEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clssys_RequestTypeEN objsys_RequestTypeEN = new clssys_RequestTypeEN();
try
{
objsys_RequestTypeEN.RequestTypeId = objRow[consys_RequestType.RequestTypeId].ToString().Trim(); //RequestTypeId
objsys_RequestTypeEN.RequestTypeName = objRow[consys_RequestType.RequestTypeName] == DBNull.Value ? null : objRow[consys_RequestType.RequestTypeName].ToString().Trim(); //RequestTypeName
objsys_RequestTypeEN.RequestTable = objRow[consys_RequestType.RequestTable] == DBNull.Value ? null : objRow[consys_RequestType.RequestTable].ToString().Trim(); //RequestTable
objsys_RequestTypeEN.RequestTableId = objRow[consys_RequestType.RequestTableId] == DBNull.Value ? null : objRow[consys_RequestType.RequestTableId].ToString().Trim(); //RequestTableId
objsys_RequestTypeEN.Memo = objRow[consys_RequestType.Memo] == DBNull.Value ? null : objRow[consys_RequestType.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objsys_RequestTypeEN.RequestTypeId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objsys_RequestTypeEN);
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
public static List<clssys_RequestTypeEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clssys_RequestTypeEN> arrObjLst = new List<clssys_RequestTypeEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clssys_RequestTypeEN objsys_RequestTypeEN = new clssys_RequestTypeEN();
try
{
objsys_RequestTypeEN.RequestTypeId = objRow[consys_RequestType.RequestTypeId].ToString().Trim(); //RequestTypeId
objsys_RequestTypeEN.RequestTypeName = objRow[consys_RequestType.RequestTypeName] == DBNull.Value ? null : objRow[consys_RequestType.RequestTypeName].ToString().Trim(); //RequestTypeName
objsys_RequestTypeEN.RequestTable = objRow[consys_RequestType.RequestTable] == DBNull.Value ? null : objRow[consys_RequestType.RequestTable].ToString().Trim(); //RequestTable
objsys_RequestTypeEN.RequestTableId = objRow[consys_RequestType.RequestTableId] == DBNull.Value ? null : objRow[consys_RequestType.RequestTableId].ToString().Trim(); //RequestTableId
objsys_RequestTypeEN.Memo = objRow[consys_RequestType.Memo] == DBNull.Value ? null : objRow[consys_RequestType.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objsys_RequestTypeEN.RequestTypeId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objsys_RequestTypeEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clssys_RequestTypeEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clssys_RequestTypeEN> arrObjLst = new List<clssys_RequestTypeEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clssys_RequestTypeEN objsys_RequestTypeEN = new clssys_RequestTypeEN();
try
{
objsys_RequestTypeEN.RequestTypeId = objRow[consys_RequestType.RequestTypeId].ToString().Trim(); //RequestTypeId
objsys_RequestTypeEN.RequestTypeName = objRow[consys_RequestType.RequestTypeName] == DBNull.Value ? null : objRow[consys_RequestType.RequestTypeName].ToString().Trim(); //RequestTypeName
objsys_RequestTypeEN.RequestTable = objRow[consys_RequestType.RequestTable] == DBNull.Value ? null : objRow[consys_RequestType.RequestTable].ToString().Trim(); //RequestTable
objsys_RequestTypeEN.RequestTableId = objRow[consys_RequestType.RequestTableId] == DBNull.Value ? null : objRow[consys_RequestType.RequestTableId].ToString().Trim(); //RequestTableId
objsys_RequestTypeEN.Memo = objRow[consys_RequestType.Memo] == DBNull.Value ? null : objRow[consys_RequestType.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objsys_RequestTypeEN.RequestTypeId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objsys_RequestTypeEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objsys_RequestTypeEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool Getsys_RequestType(ref clssys_RequestTypeEN objsys_RequestTypeEN)
{
bool bolResult = sys_RequestTypeDA.Getsys_RequestType(ref objsys_RequestTypeEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "strRequestTypeId">表关键字</param>
 /// <returns>表对象</returns>
public static clssys_RequestTypeEN GetObjByRequestTypeId(string strRequestTypeId)
{
if (strRequestTypeId.IndexOf(' ') >=0)
{
var strMsg = string.Format("(errid:Busi000079)在表中,关键字[strRequestTypeId]中不能有空格!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
if (string.IsNullOrEmpty(strRequestTypeId) == true)
{
var strMsg = string.Format("(errid:Busi000020)在表中,关键字[strRequestTypeId]不能为空!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
clssys_RequestTypeEN objsys_RequestTypeEN = sys_RequestTypeDA.GetObjByRequestTypeId(strRequestTypeId);
return objsys_RequestTypeEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clssys_RequestTypeEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clssys_RequestTypeEN objsys_RequestTypeEN = sys_RequestTypeDA.GetFirstObj(strWhereCond);
 return objsys_RequestTypeEN;
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
public static clssys_RequestTypeEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clssys_RequestTypeEN objsys_RequestTypeEN = sys_RequestTypeDA.GetObjByDataRow(objRow);
 return objsys_RequestTypeEN;
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
public static clssys_RequestTypeEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clssys_RequestTypeEN objsys_RequestTypeEN = sys_RequestTypeDA.GetObjByDataRow(objRow);
 return objsys_RequestTypeEN;
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
 /// <param name = "strRequestTypeId">所给的关键字</param>
 /// <param name = "lstsys_RequestTypeObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clssys_RequestTypeEN GetObjByRequestTypeIdFromList(string strRequestTypeId, List<clssys_RequestTypeEN> lstsys_RequestTypeObjLst)
{
foreach (clssys_RequestTypeEN objsys_RequestTypeEN in lstsys_RequestTypeObjLst)
{
if (objsys_RequestTypeEN.RequestTypeId == strRequestTypeId)
{
return objsys_RequestTypeEN;
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
 string strMaxRequestTypeId;
 try
 {
 strMaxRequestTypeId = clssys_RequestTypeDA.GetMaxStrId();
 return strMaxRequestTypeId;
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
 string strRequestTypeId;
 try
 {
 strRequestTypeId = new clssys_RequestTypeDA().GetFirstID(strWhereCond);
 return strRequestTypeId;
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
 arrList = sys_RequestTypeDA.GetID(strWhereCond);
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
bool bolIsExist = sys_RequestTypeDA.IsExistCondRec(strWhereCond);
return bolIsExist;
}

 /// <summary>
 /// 判断当前表中是否存在给定关键字值的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExist)
 /// </summary>
 /// <param name = "strRequestTypeId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public static bool IsExist(string strRequestTypeId)
{
if (string.IsNullOrEmpty(strRequestTypeId) == true)
{
var strMsg = string.Format("(errid:Busi000027)在表中,关键字[strRequestTypeId]不能为空!!(from {0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
//检测记录是否存在
bool bolIsExist = sys_RequestTypeDA.IsExist(strRequestTypeId);
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
 bolIsExist = clssys_RequestTypeDA.IsExistTable();
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
 bolIsExist = sys_RequestTypeDA.IsExistTable(strTabName);
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
 /// <param name = "objsys_RequestTypeEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecordBySql2(clssys_RequestTypeEN objsys_RequestTypeEN, bool bolIsNeedCheckUniqueness=true)
{
if (bolIsNeedCheckUniqueness == true && objsys_RequestTypeEN.CheckUniqueness() == false)
{
var strMsg = string.Format("记录已经存在!RequestTableId = [{0}],RequestTypeId = [{1}]的数据已经存在!(in clssys_RequestTypeBL.AddNewRecordBySql2)", objsys_RequestTypeEN.RequestTableId,objsys_RequestTypeEN.RequestTypeId);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objsys_RequestTypeEN.RequestTypeId) == true || clssys_RequestTypeBL.IsExist(objsys_RequestTypeEN.RequestTypeId) == true)
 {
     objsys_RequestTypeEN.RequestTypeId = clssys_RequestTypeBL.GetMaxStrId_S();
 }
bool bolResult = sys_RequestTypeDA.AddNewRecordBySQL2(objsys_RequestTypeEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clssys_RequestTypeBL.ReFreshCache();

if (clssys_RequestTypeBL.relatedActions != null)
{
clssys_RequestTypeBL.relatedActions.UpdRelaTabDate(objsys_RequestTypeEN.RequestTypeId, "SetUpdDate");
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
 /// <param name = "objsys_RequestTypeEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordBySql2WithReturnKey(clssys_RequestTypeEN objsys_RequestTypeEN, bool bolIsNeedCheckUniqueness=true)
{
if (bolIsNeedCheckUniqueness == true && objsys_RequestTypeEN.CheckUniqueness() == false)
{
var strMsg = string.Format("记录已经存在!RequestTableId = [{0}],RequestTypeId = [{1}]的数据已经存在!(in clssys_RequestTypeBL.AddNewRecordBySql2WithReturnKey)", objsys_RequestTypeEN.RequestTableId,objsys_RequestTypeEN.RequestTypeId);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objsys_RequestTypeEN.RequestTypeId) == true || clssys_RequestTypeBL.IsExist(objsys_RequestTypeEN.RequestTypeId) == true)
 {
     objsys_RequestTypeEN.RequestTypeId = clssys_RequestTypeBL.GetMaxStrId_S();
 }
string strKey = sys_RequestTypeDA.AddNewRecordBySQL2WithReturnKey(objsys_RequestTypeEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clssys_RequestTypeBL.ReFreshCache();

if (clssys_RequestTypeBL.relatedActions != null)
{
clssys_RequestTypeBL.relatedActions.UpdRelaTabDate(objsys_RequestTypeEN.RequestTypeId, "SetUpdDate");
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
 /// <param name = "objsys_RequestTypeEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(clssys_RequestTypeEN objsys_RequestTypeEN)
{
try
{
bool bolResult = sys_RequestTypeDA.Update(objsys_RequestTypeEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clssys_RequestTypeBL.ReFreshCache();

if (clssys_RequestTypeBL.relatedActions != null)
{
clssys_RequestTypeBL.relatedActions.UpdRelaTabDate(objsys_RequestTypeEN.RequestTypeId, "SetUpdDate");
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
 /// <param name = "objsys_RequestTypeEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateBySql2(clssys_RequestTypeEN objsys_RequestTypeEN)
{
 if (string.IsNullOrEmpty(objsys_RequestTypeEN.RequestTypeId) == true)
 {
var strMsg = string.Format("(errid:Busi000065)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = sys_RequestTypeDA.UpdateBySql2(objsys_RequestTypeEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clssys_RequestTypeBL.ReFreshCache();

if (clssys_RequestTypeBL.relatedActions != null)
{
clssys_RequestTypeBL.relatedActions.UpdRelaTabDate(objsys_RequestTypeEN.RequestTypeId, "SetUpdDate");
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
 /// <param name = "strRequestTypeId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int DelRecord(string strRequestTypeId)
{
try
{
 clssys_RequestTypeEN objsys_RequestTypeEN = clssys_RequestTypeBL.GetObjByRequestTypeId(strRequestTypeId);

if (clssys_RequestTypeBL.relatedActions != null)
{
clssys_RequestTypeBL.relatedActions.UpdRelaTabDate(objsys_RequestTypeEN.RequestTypeId, "SetUpdDate");
}
if (objsys_RequestTypeEN != null)
{
int intRecNum = sys_RequestTypeDA.DelRecord(strRequestTypeId);
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
/// <param name="strRequestTypeId">表关键字</param>
/// <returns></returns>
public static bool DelRecordEx(string strRequestTypeId )
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clssys_RequestTypeDA.GetSpecSQLObj();
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
//删除与表:[sys_RequestType]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//consys_RequestType.RequestTypeId,
//strRequestTypeId);
//        clssys_RequestTypeBL.Delsys_RequestTypesByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clssys_RequestTypeBL.DelRecord(strRequestTypeId, objConnection, objSqlTransaction);
objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clssys_RequestTypeBLEx", "DelRecordEx", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("扩展删除记录出错:{0}!keyId = {1}.({2})",
objException.Message,
strRequestTypeId, clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "strRequestTypeId">给定的关键字值</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回删除是否成功?</returns>
public static bool DelRecord(string strRequestTypeId, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
if (clssys_RequestTypeBL.relatedActions != null)
{
clssys_RequestTypeBL.relatedActions.UpdRelaTabDate(strRequestTypeId, "UpdRelaTabDate");
}
bool bolResult = sys_RequestTypeDA.DelRecord(strRequestTypeId,objSqlConnection,objSqlTransaction);
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
 /// <param name = "arrRequestTypeIdLst">给定的关键字值列表</param>
 /// <returns>返回删除的记录数</returns>
public static int Delsys_RequestTypes(List<string> arrRequestTypeIdLst)
{
if (arrRequestTypeIdLst.Count == 0) return 0;
try
{
if (clssys_RequestTypeBL.relatedActions != null)
{
foreach (var strRequestTypeId in arrRequestTypeIdLst)
{
clssys_RequestTypeBL.relatedActions.UpdRelaTabDate(strRequestTypeId, "UpdRelaTabDate");
}
}
int intDelRecNum = sys_RequestTypeDA.Delsys_RequestType(arrRequestTypeIdLst);
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
public static int Delsys_RequestTypesByCond(string strWhereCond)
{
try
{
if (clssys_RequestTypeBL.relatedActions != null)
{
List<string> arrRequestTypeId = GetPrimaryKeyID_S(strWhereCond);
foreach (var strRequestTypeId in arrRequestTypeId)
{
clssys_RequestTypeBL.relatedActions.UpdRelaTabDate(strRequestTypeId, "UpdRelaTabDate");
}
}
int intRecNum = sys_RequestTypeDA.Delsys_RequestType(strWhereCond);
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
/// 这里仅仅是演示函数,使用时请复制到扩展类:[sys_RequestType]中改名为:[DelRecord4MultiTabEx]使用
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DelRecord4MultiTab)
/// </summary>
/// <param name="strRequestTypeId">表关键字</param>
/// <returns></returns>
public static bool DelRecord4MultiTab(string strRequestTypeId)
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clssys_RequestTypeDA.GetSpecSQLObj();
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
//删除与表:[sys_RequestType]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conStudent.id_College,
//strid_College);
//        clsStudentBL.DelStudentsByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clssys_RequestTypeBL.DelRecord(strRequestTypeId, objConnection, objSqlTransaction);
                objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clssys_RequestTypeBL", "DelRecord4MultiTab", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("删除多表记录出错:{0}!keyId = {1}.({2})",
objException.Message,
strRequestTypeId, clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "objsys_RequestTypeENS">源对象</param>
 /// <param name = "objsys_RequestTypeENT">目标对象</param>
 public static void CopyTo(clssys_RequestTypeEN objsys_RequestTypeENS, clssys_RequestTypeEN objsys_RequestTypeENT)
{
try
{
objsys_RequestTypeENT.RequestTypeId = objsys_RequestTypeENS.RequestTypeId; //RequestTypeId
objsys_RequestTypeENT.RequestTypeName = objsys_RequestTypeENS.RequestTypeName; //RequestTypeName
objsys_RequestTypeENT.RequestTable = objsys_RequestTypeENS.RequestTable; //RequestTable
objsys_RequestTypeENT.RequestTableId = objsys_RequestTypeENS.RequestTableId; //RequestTableId
objsys_RequestTypeENT.Memo = objsys_RequestTypeENS.Memo; //备注
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
 /// <param name = "objsys_RequestTypeEN">源简化对象</param>
 public static void SetUpdFlag(clssys_RequestTypeEN objsys_RequestTypeEN)
{
try
{
objsys_RequestTypeEN.ClearUpdateState();
   string strsfUpdFldSetStr = objsys_RequestTypeEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(consys_RequestType.RequestTypeId, new clsStrCompareIgnoreCase())  ==  true)
{
objsys_RequestTypeEN.RequestTypeId = objsys_RequestTypeEN.RequestTypeId; //RequestTypeId
}
if (arrFldSet.Contains(consys_RequestType.RequestTypeName, new clsStrCompareIgnoreCase())  ==  true)
{
objsys_RequestTypeEN.RequestTypeName = objsys_RequestTypeEN.RequestTypeName == "[null]" ? null :  objsys_RequestTypeEN.RequestTypeName; //RequestTypeName
}
if (arrFldSet.Contains(consys_RequestType.RequestTable, new clsStrCompareIgnoreCase())  ==  true)
{
objsys_RequestTypeEN.RequestTable = objsys_RequestTypeEN.RequestTable == "[null]" ? null :  objsys_RequestTypeEN.RequestTable; //RequestTable
}
if (arrFldSet.Contains(consys_RequestType.RequestTableId, new clsStrCompareIgnoreCase())  ==  true)
{
objsys_RequestTypeEN.RequestTableId = objsys_RequestTypeEN.RequestTableId == "[null]" ? null :  objsys_RequestTypeEN.RequestTableId; //RequestTableId
}
if (arrFldSet.Contains(consys_RequestType.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objsys_RequestTypeEN.Memo = objsys_RequestTypeEN.Memo == "[null]" ? null :  objsys_RequestTypeEN.Memo; //备注
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
 /// <param name = "objsys_RequestTypeEN">源简化对象</param>
 public static void AccessFldValueNull(clssys_RequestTypeEN objsys_RequestTypeEN)
{
try
{
if (objsys_RequestTypeEN.RequestTypeName == "[null]") objsys_RequestTypeEN.RequestTypeName = null; //RequestTypeName
if (objsys_RequestTypeEN.RequestTable == "[null]") objsys_RequestTypeEN.RequestTable = null; //RequestTable
if (objsys_RequestTypeEN.RequestTableId == "[null]") objsys_RequestTypeEN.RequestTableId = null; //RequestTableId
if (objsys_RequestTypeEN.Memo == "[null]") objsys_RequestTypeEN.Memo = null; //备注
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
public static void CheckPropertyNew(clssys_RequestTypeEN objsys_RequestTypeEN)
{
 sys_RequestTypeDA.CheckPropertyNew(objsys_RequestTypeEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(clssys_RequestTypeEN objsys_RequestTypeEN)
{
 sys_RequestTypeDA.CheckProperty4Condition(objsys_RequestTypeEN);
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
if (clssys_RequestTypeBL.objCommFun4BL == null)
{
strMsg = string.Format("类clssys_RequestTypeBL没有刷新缓存机制(clssys_RequestTypeBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by RequestTypeId");
//if (arrsys_RequestTypeObjLstCache == null)
//{
//arrsys_RequestTypeObjLstCache = sys_RequestTypeDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "strRequestTypeId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clssys_RequestTypeEN GetObjByRequestTypeIdCache(string strRequestTypeId)
{
//获取缓存中的对象列表
string strKey = string.Format("{0}", clssys_RequestTypeEN._CurrTabName);
List<clssys_RequestTypeEN> arrsys_RequestTypeObjLstCache = GetObjLstCache();
IEnumerable <clssys_RequestTypeEN> arrsys_RequestTypeObjLst_Sel =
arrsys_RequestTypeObjLstCache
.Where(x=> x.RequestTypeId == strRequestTypeId 
);
if (arrsys_RequestTypeObjLst_Sel.Count() == 0)
{
   clssys_RequestTypeEN obj = clssys_RequestTypeBL.GetObjByRequestTypeId(strRequestTypeId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
 }
return null;
}
return arrsys_RequestTypeObjLst_Sel.First();
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clssys_RequestTypeEN> GetAllsys_RequestTypeObjLstCache()
{
//获取缓存中的对象列表
List<clssys_RequestTypeEN> arrsys_RequestTypeObjLstCache = GetObjLstCache(); 
return arrsys_RequestTypeObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clssys_RequestTypeEN> GetObjLstCache()
{
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}", clssys_RequestTypeEN._CurrTabName);
List<clssys_RequestTypeEN> arrsys_RequestTypeObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrsys_RequestTypeObjLstCache;
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
string strKey = string.Format("{0}", clssys_RequestTypeEN._CurrTabName);
CacheHelper.Remove(strKey);
clssys_RequestTypeEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
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
if (clssys_RequestTypeEN._RefreshTimeLst.Count == 0) return "";
return clssys_RequestTypeEN._RefreshTimeLst[clssys_RequestTypeEN._RefreshTimeLst.Count - 1];
}

 /// <summary>
 /// 刷新缓存.把当前表的缓存以及该表相关视图的缓存清空.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ReFreshCache)
 /// </summary>
public static void ReFreshCache()
{
if (clssys_RequestTypeBL.objCommFun4BL != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}", clssys_RequestTypeEN._CurrTabName);
CacheHelper.Remove(strKey);
clssys_RequestTypeEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
clssys_RequestTypeBL.objCommFun4BL.ReFreshCache();
}
}


 #endregion 缓存操作


 #region 检查唯一性

 /// <summary>
 /// 获取检查唯一性条件串(Uniqueness)--sys_RequestType(请求类型表)
 /// 唯一性条件:RequestTableId_RequestTypeId
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetUniquenessConditionString)
 /// </summary>
 /// <param name = "objsys_RequestTypeEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(clssys_RequestTypeEN objsys_RequestTypeEN)
{
//检测记录是否存在
string strResult = sys_RequestTypeDA.GetUniCondStr(objsys_RequestTypeEN);
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
public static string Func(string strInFldName, string strOutFldName, string strRequestTypeId)
{
if (strInFldName != consys_RequestType.RequestTypeId)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (consys_RequestType.AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", consys_RequestType.AttributeName));
throw new Exception(strMsg);
}
var objsys_RequestType = clssys_RequestTypeBL.GetObjByRequestTypeIdCache(strRequestTypeId);
if (objsys_RequestType == null) return "";
return objsys_RequestType[strOutFldName].ToString();
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
int intRecCount = clssys_RequestTypeDA.GetRecCount(strTabName);
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
int intRecCount = clssys_RequestTypeDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clssys_RequestTypeDA.GetRecCount();
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
int intRecCount = clssys_RequestTypeDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objsys_RequestTypeCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clssys_RequestTypeEN objsys_RequestTypeCond)
{
List<clssys_RequestTypeEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clssys_RequestTypeEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in consys_RequestType.AttributeName)
{
if (objsys_RequestTypeCond.IsUpdated(strFldName) == false) continue;
if (objsys_RequestTypeCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objsys_RequestTypeCond[strFldName].ToString());
}
else
{
if (objsys_RequestTypeCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objsys_RequestTypeCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objsys_RequestTypeCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objsys_RequestTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objsys_RequestTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objsys_RequestTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objsys_RequestTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objsys_RequestTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objsys_RequestTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objsys_RequestTypeCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objsys_RequestTypeCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objsys_RequestTypeCond[strFldName]));
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
 List<string> arrList = clssys_RequestTypeDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = sys_RequestTypeDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = sys_RequestTypeDA.GetFldValueNoDistinct(strFldName, strWhereCond);
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
int intRecCount = sys_RequestTypeDA.SetFldValue(strFldName, strValue, strWhereCond);
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
int intRecCount = clssys_RequestTypeDA.SetFldValue(clssys_RequestTypeEN._CurrTabName, strFldName, fltValue, strWhereCond);
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
int intRecCount = sys_RequestTypeDA.SetFldValue( strFldName, intValue, strWhereCond);
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
int intRecCount = clssys_RequestTypeDA.SetFldValue(strTabName, strFldName, strValue, strWhereCond);
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
int intRecCount = clssys_RequestTypeDA.SetFldValue(strTabName, strFldName, intValue, strWhereCond);
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
int intRecCount = clssys_RequestTypeDA.SetFldValue(strTabName, strFldName, fltValue, strWhereCond);
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
  strCreateTabCode.Append("CREATE table [dbo].[sys_RequestType] "); 
 strCreateTabCode.Append(" ( "); 
 // /**RequestTypeId*/ 
 strCreateTabCode.Append(" RequestTypeId char(2) primary key, "); 
 // /**RequestTypeName*/ 
 strCreateTabCode.Append(" RequestTypeName varchar(50) Null, "); 
 // /**RequestTable*/ 
 strCreateTabCode.Append(" RequestTable varchar(50) Null, "); 
 // /**RequestTableId*/ 
 strCreateTabCode.Append(" RequestTableId varchar(50) Null, "); 
 // /**备注*/ 
 strCreateTabCode.Append(" Memo varchar(1000) Null ");
 strCreateTabCode.Append(") "); 
  strCreateTabCode.Append("ON [PRIMARY] ");
  return strCreateTabCode.ToString();
}



 #endregion 表操作
}
 /// <summary>
 /// 请求类型表(sys_RequestType)
 /// 数据源类型:表
 /// (AutoGCLib.CommFun4BL4CSharp:GeneCode_This)
 /// </summary>
public class  clsCommFun4BL4sys_RequestType : clsCommFun4BL
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
clssys_RequestTypeBL.ReFreshThisCache();
}
}

}