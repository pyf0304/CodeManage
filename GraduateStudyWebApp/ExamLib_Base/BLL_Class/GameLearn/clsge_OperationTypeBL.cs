
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsge_OperationTypeBL
 表名:ge_OperationType(01120911)
 * 版本:2024.11.13.1(服务器:WIN-SRV103-116)
 日期:2024/11/13 06:17:11
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:研究生学习游戏化后台(000055, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:游戏化学习(GameLearn)
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
public static class  clsge_OperationTypeBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "strOperationTypeId">表关键字</param>
 /// <returns>表对象</returns>
public static clsge_OperationTypeEN GetObj(this K_OperationTypeId_ge_OperationType myKey)
{
clsge_OperationTypeEN objge_OperationTypeEN = clsge_OperationTypeBL.ge_OperationTypeDA.GetObjByOperationTypeId(myKey.Value);
return objge_OperationTypeEN;
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_AddNewRecord)
 /// </summary>
 /// <param name = "objge_OperationTypeEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clsge_OperationTypeEN objge_OperationTypeEN, bool bolIsNeedCheckUniqueness = true)
{
 if (string.IsNullOrEmpty(objge_OperationTypeEN.OperationTypeId) == true)
 {
string strMsg = string.Format("添加记录时,关键字不能为空!(from {0})\r\n", 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
 if (clsge_OperationTypeBL.IsExist(objge_OperationTypeEN.OperationTypeId) == true)
 {
string strMsg = string.Format("添加记录时,关键字:[{0}]已经存在!(from {1})\r\n", objge_OperationTypeEN.OperationTypeId, 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
if (bolIsNeedCheckUniqueness == true && CheckUniqueness(objge_OperationTypeEN) == false)
{
var strMsg = string.Format("记录已经存在!操作类型ID = [{0}],操作类型名 = [{1}]的数据已经存在!(in clsge_OperationTypeBL.AddNewRecord)", objge_OperationTypeEN.OperationTypeId,objge_OperationTypeEN.OperationTypeName);
throw new Exception(strMsg);
}
try
{
bool bolResult = clsge_OperationTypeBL.ge_OperationTypeDA.AddNewRecordBySQL2(objge_OperationTypeEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsge_OperationTypeBL.ReFreshCache();

if (clsge_OperationTypeBL.relatedActions != null)
{
clsge_OperationTypeBL.relatedActions.UpdRelaTabDate(objge_OperationTypeEN.OperationTypeId, "SetUpdDate");
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
public static bool AddRecordEx(this clsge_OperationTypeEN objge_OperationTypeEN, bool bolIsNeedCheckUniqueness = true)
{
//操作步骤:
//1、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在
//2、检查唯一性
//3、检查传进去的对象属性是否合法
//4、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
//1、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在
if (clsge_OperationTypeBL.IsExist(objge_OperationTypeEN.OperationTypeId))	//判断是否有相同的关键字
{
strMsg = "(errid:Busi000151)关键字字段已有相同的值";
throw new Exception(strMsg);
}
try
{
 //2、检查传进去的对象属性是否合法
objge_OperationTypeEN.CheckPropertyNew();
 ///5.2、检查唯一性
if (bolIsNeedCheckUniqueness == true && objge_OperationTypeEN.CheckUniqueness() == false)
{
strMsg = string.Format("(操作类型ID(OperationTypeId)=[{0}],操作类型名(OperationTypeName)=[{1}])已经存在,不能重复!", objge_OperationTypeEN.OperationTypeId, objge_OperationTypeEN.OperationTypeName);
throw new Exception(strMsg);
}
//6、把数据实体层的数据存贮到数据库中
objge_OperationTypeEN.AddNewRecord();
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
 /// <param name = "objge_OperationTypeEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordWithReturnKey(this clsge_OperationTypeEN objge_OperationTypeEN, bool bolIsNeedCheckUniqueness = true)
{
 if (string.IsNullOrEmpty(objge_OperationTypeEN.OperationTypeId) == true)
 {
string strMsg = string.Format("添加记录时,关键字不能为空!(from {{0}})", 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
 if (clsge_OperationTypeBL.IsExist(objge_OperationTypeEN.OperationTypeId) == true)
 {
string strMsg = string.Format("添加记录时,关键字:[{0}]已经存在!(from {1})\r\n", objge_OperationTypeEN.OperationTypeId, 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
if (bolIsNeedCheckUniqueness == true && CheckUniqueness(objge_OperationTypeEN) == false)
{
var strMsg = string.Format("记录已经存在!操作类型ID = [{0}],操作类型名 = [{1}]的数据已经存在!(in clsge_OperationTypeBL.AddNewRecordWithReturnKey)", objge_OperationTypeEN.OperationTypeId,objge_OperationTypeEN.OperationTypeName);
throw new Exception(strMsg);
}
try
{
string strKey = clsge_OperationTypeBL.ge_OperationTypeDA.AddNewRecordBySQL2WithReturnKey(objge_OperationTypeEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsge_OperationTypeBL.ReFreshCache();

if (clsge_OperationTypeBL.relatedActions != null)
{
clsge_OperationTypeBL.relatedActions.UpdRelaTabDate(objge_OperationTypeEN.OperationTypeId, "SetUpdDate");
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
 /// <param name = "objge_OperationTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsge_OperationTypeEN SetOperationTypeId(this clsge_OperationTypeEN objge_OperationTypeEN, string strOperationTypeId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strOperationTypeId, 4, conge_OperationType.OperationTypeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strOperationTypeId, 4, conge_OperationType.OperationTypeId);
}
objge_OperationTypeEN.OperationTypeId = strOperationTypeId; //操作类型ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objge_OperationTypeEN.dicFldComparisonOp.ContainsKey(conge_OperationType.OperationTypeId) == false)
{
objge_OperationTypeEN.dicFldComparisonOp.Add(conge_OperationType.OperationTypeId, strComparisonOp);
}
else
{
objge_OperationTypeEN.dicFldComparisonOp[conge_OperationType.OperationTypeId] = strComparisonOp;
}
}
return objge_OperationTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objge_OperationTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsge_OperationTypeEN SetOperationTypeName(this clsge_OperationTypeEN objge_OperationTypeEN, string strOperationTypeName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strOperationTypeName, 50, conge_OperationType.OperationTypeName);
}
objge_OperationTypeEN.OperationTypeName = strOperationTypeName; //操作类型名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objge_OperationTypeEN.dicFldComparisonOp.ContainsKey(conge_OperationType.OperationTypeName) == false)
{
objge_OperationTypeEN.dicFldComparisonOp.Add(conge_OperationType.OperationTypeName, strComparisonOp);
}
else
{
objge_OperationTypeEN.dicFldComparisonOp[conge_OperationType.OperationTypeName] = strComparisonOp;
}
}
return objge_OperationTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objge_OperationTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsge_OperationTypeEN SetOperationTypeEnName(this clsge_OperationTypeEN objge_OperationTypeEN, string strOperationTypeEnName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strOperationTypeEnName, 100, conge_OperationType.OperationTypeEnName);
}
objge_OperationTypeEN.OperationTypeEnName = strOperationTypeEnName; //OperationTypeEnName
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objge_OperationTypeEN.dicFldComparisonOp.ContainsKey(conge_OperationType.OperationTypeEnName) == false)
{
objge_OperationTypeEN.dicFldComparisonOp.Add(conge_OperationType.OperationTypeEnName, strComparisonOp);
}
else
{
objge_OperationTypeEN.dicFldComparisonOp[conge_OperationType.OperationTypeEnName] = strComparisonOp;
}
}
return objge_OperationTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objge_OperationTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsge_OperationTypeEN SetUpdUser(this clsge_OperationTypeEN objge_OperationTypeEN, string strUpdUser, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdUser, 20, conge_OperationType.UpdUser);
}
objge_OperationTypeEN.UpdUser = strUpdUser; //修改人
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objge_OperationTypeEN.dicFldComparisonOp.ContainsKey(conge_OperationType.UpdUser) == false)
{
objge_OperationTypeEN.dicFldComparisonOp.Add(conge_OperationType.UpdUser, strComparisonOp);
}
else
{
objge_OperationTypeEN.dicFldComparisonOp[conge_OperationType.UpdUser] = strComparisonOp;
}
}
return objge_OperationTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objge_OperationTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsge_OperationTypeEN SetUpdDate(this clsge_OperationTypeEN objge_OperationTypeEN, string strUpdDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdDate, 20, conge_OperationType.UpdDate);
}
objge_OperationTypeEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objge_OperationTypeEN.dicFldComparisonOp.ContainsKey(conge_OperationType.UpdDate) == false)
{
objge_OperationTypeEN.dicFldComparisonOp.Add(conge_OperationType.UpdDate, strComparisonOp);
}
else
{
objge_OperationTypeEN.dicFldComparisonOp[conge_OperationType.UpdDate] = strComparisonOp;
}
}
return objge_OperationTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objge_OperationTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsge_OperationTypeEN SetMemo(this clsge_OperationTypeEN objge_OperationTypeEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, conge_OperationType.Memo);
}
objge_OperationTypeEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objge_OperationTypeEN.dicFldComparisonOp.ContainsKey(conge_OperationType.Memo) == false)
{
objge_OperationTypeEN.dicFldComparisonOp.Add(conge_OperationType.Memo, strComparisonOp);
}
else
{
objge_OperationTypeEN.dicFldComparisonOp[conge_OperationType.Memo] = strComparisonOp;
}
}
return objge_OperationTypeEN;
	}

 /// <summary>
 /// 修改记录存盘到数据表中
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_UpdateRecordEx)
 /// </summary>
 /// <param name = "objge_OperationTypeEN">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool UpdateRecordEx(this clsge_OperationTypeEN objge_OperationTypeEN)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
try
{
//1、检查传进去的对象属性是否合法
objge_OperationTypeEN.CheckPropertyNew();
clsge_OperationTypeEN objge_OperationTypeCond = new clsge_OperationTypeEN();
string strCondition = objge_OperationTypeCond
.SetOperationTypeId(objge_OperationTypeEN.OperationTypeId, "<>")
.SetOperationTypeId(objge_OperationTypeEN.OperationTypeId, "=")
.SetOperationTypeName(objge_OperationTypeEN.OperationTypeName, "=")
.GetCombineCondition();
objge_OperationTypeEN._IsCheckProperty = true;
bool bolIsExist = clsge_OperationTypeBL.IsExistRecord(strCondition);
if (bolIsExist)
{
strMsg = "(OperationTypeId_OperationTypeName)不能重复!";
throw new Exception(strMsg);
}
//4、把数据实体层的数据存贮到数据库中
objge_OperationTypeEN.Update();
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
 /// <param name = "objge_OperationType">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool EditRecordEx(this clsge_OperationTypeEN objge_OperationType)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
clsge_OperationTypeEN objge_OperationTypeCond = new clsge_OperationTypeEN();
string strCondition = objge_OperationTypeCond
.SetOperationTypeId(objge_OperationType.OperationTypeId, "=")
.SetOperationTypeName(objge_OperationType.OperationTypeName, "=")
.GetCombineCondition();
objge_OperationType._IsCheckProperty = true;
bool bolIsExist = clsge_OperationTypeBL.IsExistRecord(strCondition);
if (bolIsExist)
{
objge_OperationType.OperationTypeId = clsge_OperationTypeBL.GetFirstID_S(strCondition);
objge_OperationType.UpdateWithCondition(strCondition);
}
else
{
objge_OperationType.AddNewRecord();
}
return true; 
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_Update)
 /// </summary>
 /// <param name = "objge_OperationTypeEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsge_OperationTypeEN objge_OperationTypeEN)
{
 if (string.IsNullOrEmpty(objge_OperationTypeEN.OperationTypeId) == true)
 {
string strMsg = string.Format("(errid:Busi000095)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsge_OperationTypeBL.ge_OperationTypeDA.UpdateBySql2(objge_OperationTypeEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsge_OperationTypeBL.ReFreshCache();

if (clsge_OperationTypeBL.relatedActions != null)
{
clsge_OperationTypeBL.relatedActions.UpdRelaTabDate(objge_OperationTypeEN.OperationTypeId, "SetUpdDate");
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
 /// <param name = "objge_OperationTypeEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsge_OperationTypeEN objge_OperationTypeEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (string.IsNullOrEmpty(objge_OperationTypeEN.OperationTypeId) == true)
 {
string strMsg = string.Format("(errid:Busi000087)修改记录时关键字不能为空!(带事务处理)(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsge_OperationTypeBL.ge_OperationTypeDA.UpdateBySql2(objge_OperationTypeEN, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsge_OperationTypeBL.ReFreshCache();

if (clsge_OperationTypeBL.relatedActions != null)
{
clsge_OperationTypeBL.relatedActions.UpdRelaTabDate(objge_OperationTypeEN.OperationTypeId, "SetUpdDate");
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
 /// <param name = "objge_OperationTypeEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsge_OperationTypeEN objge_OperationTypeEN, string strWhereCond)
{
try
{
bool bolResult = clsge_OperationTypeBL.ge_OperationTypeDA.UpdateBySqlWithCondition(objge_OperationTypeEN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsge_OperationTypeBL.ReFreshCache();

if (clsge_OperationTypeBL.relatedActions != null)
{
clsge_OperationTypeBL.relatedActions.UpdRelaTabDate(objge_OperationTypeEN.OperationTypeId, "SetUpdDate");
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
 /// <param name = "objge_OperationTypeEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsge_OperationTypeEN objge_OperationTypeEN, string strWhereCond, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
bool bolResult = clsge_OperationTypeBL.ge_OperationTypeDA.UpdateBySqlWithConditionTransaction(objge_OperationTypeEN, strWhereCond, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsge_OperationTypeBL.ReFreshCache();

if (clsge_OperationTypeBL.relatedActions != null)
{
clsge_OperationTypeBL.relatedActions.UpdRelaTabDate(objge_OperationTypeEN.OperationTypeId, "SetUpdDate");
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
 /// <param name = "strOperationTypeId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int Delete(this clsge_OperationTypeEN objge_OperationTypeEN)
{
try
{
int intRecNum = clsge_OperationTypeBL.ge_OperationTypeDA.DelRecord(objge_OperationTypeEN.OperationTypeId);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsge_OperationTypeBL.ReFreshCache();

if (clsge_OperationTypeBL.relatedActions != null)
{
clsge_OperationTypeBL.relatedActions.UpdRelaTabDate(objge_OperationTypeEN.OperationTypeId, "SetUpdDate");
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
 /// <param name = "objge_OperationTypeENS">源对象</param>
 /// <param name = "objge_OperationTypeENT">目标对象</param>
 public static void CopyTo(this clsge_OperationTypeEN objge_OperationTypeENS, clsge_OperationTypeEN objge_OperationTypeENT)
{
try
{
objge_OperationTypeENT.OperationTypeId = objge_OperationTypeENS.OperationTypeId; //操作类型ID
objge_OperationTypeENT.OperationTypeName = objge_OperationTypeENS.OperationTypeName; //操作类型名
objge_OperationTypeENT.OperationTypeEnName = objge_OperationTypeENS.OperationTypeEnName; //OperationTypeEnName
objge_OperationTypeENT.UpdUser = objge_OperationTypeENS.UpdUser; //修改人
objge_OperationTypeENT.UpdDate = objge_OperationTypeENS.UpdDate; //修改日期
objge_OperationTypeENT.Memo = objge_OperationTypeENS.Memo; //备注
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
 /// <param name = "objge_OperationTypeENS">源对象</param>
 /// <returns>目标对象=>clsge_OperationTypeEN:objge_OperationTypeENT</returns>
 public static clsge_OperationTypeEN CopyTo(this clsge_OperationTypeEN objge_OperationTypeENS)
{
try
{
 clsge_OperationTypeEN objge_OperationTypeENT = new clsge_OperationTypeEN()
{
OperationTypeId = objge_OperationTypeENS.OperationTypeId, //操作类型ID
OperationTypeName = objge_OperationTypeENS.OperationTypeName, //操作类型名
OperationTypeEnName = objge_OperationTypeENS.OperationTypeEnName, //OperationTypeEnName
UpdUser = objge_OperationTypeENS.UpdUser, //修改人
UpdDate = objge_OperationTypeENS.UpdDate, //修改日期
Memo = objge_OperationTypeENS.Memo, //备注
};
 return objge_OperationTypeENT;
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
public static void CheckPropertyNew(this clsge_OperationTypeEN objge_OperationTypeEN)
{
 clsge_OperationTypeBL.ge_OperationTypeDA.CheckPropertyNew(objge_OperationTypeEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(this clsge_OperationTypeEN objge_OperationTypeEN)
{
 clsge_OperationTypeBL.ge_OperationTypeDA.CheckProperty4Condition(objge_OperationTypeEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsge_OperationTypeEN objge_OperationTypeCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objge_OperationTypeCond.IsUpdated(conge_OperationType.OperationTypeId) == true)
{
string strComparisonOpOperationTypeId = objge_OperationTypeCond.dicFldComparisonOp[conge_OperationType.OperationTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conge_OperationType.OperationTypeId, objge_OperationTypeCond.OperationTypeId, strComparisonOpOperationTypeId);
}
if (objge_OperationTypeCond.IsUpdated(conge_OperationType.OperationTypeName) == true)
{
string strComparisonOpOperationTypeName = objge_OperationTypeCond.dicFldComparisonOp[conge_OperationType.OperationTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", conge_OperationType.OperationTypeName, objge_OperationTypeCond.OperationTypeName, strComparisonOpOperationTypeName);
}
if (objge_OperationTypeCond.IsUpdated(conge_OperationType.OperationTypeEnName) == true)
{
string strComparisonOpOperationTypeEnName = objge_OperationTypeCond.dicFldComparisonOp[conge_OperationType.OperationTypeEnName];
strWhereCond += string.Format(" And {0} {2} '{1}'", conge_OperationType.OperationTypeEnName, objge_OperationTypeCond.OperationTypeEnName, strComparisonOpOperationTypeEnName);
}
if (objge_OperationTypeCond.IsUpdated(conge_OperationType.UpdUser) == true)
{
string strComparisonOpUpdUser = objge_OperationTypeCond.dicFldComparisonOp[conge_OperationType.UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", conge_OperationType.UpdUser, objge_OperationTypeCond.UpdUser, strComparisonOpUpdUser);
}
if (objge_OperationTypeCond.IsUpdated(conge_OperationType.UpdDate) == true)
{
string strComparisonOpUpdDate = objge_OperationTypeCond.dicFldComparisonOp[conge_OperationType.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conge_OperationType.UpdDate, objge_OperationTypeCond.UpdDate, strComparisonOpUpdDate);
}
if (objge_OperationTypeCond.IsUpdated(conge_OperationType.Memo) == true)
{
string strComparisonOpMemo = objge_OperationTypeCond.dicFldComparisonOp[conge_OperationType.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", conge_OperationType.Memo, objge_OperationTypeCond.Memo, strComparisonOpMemo);
}
 return strWhereCond;
}

 /// <summary>
 /// 检查唯一性(Uniqueness)--ge_OperationType(操作类型), 如果不唯一,即存在相同的记录,就返回False
 /// 唯一性条件:OperationTypeId_OperationTypeName
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckConstraint)
 /// </summary>
 /// <param name = "objge_OperationTypeEN">要求唯一的对象</param>
 /// <returns></returns>
public static bool CheckUniqueness(this clsge_OperationTypeEN objge_OperationTypeEN)
{
//检测记录是否存在
bool bolIsUniqueness;
StringBuilder sbCondition = new StringBuilder();
if (objge_OperationTypeEN == null) return true;
if (objge_OperationTypeEN.OperationTypeId == null || objge_OperationTypeEN.OperationTypeId == "")
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and OperationTypeId = '{0}'", objge_OperationTypeEN.OperationTypeId);
 if (objge_OperationTypeEN.OperationTypeName == null)
{
 sbCondition.AppendFormat(" and OperationTypeName is null", objge_OperationTypeEN.OperationTypeName);
}
else
{
 sbCondition.AppendFormat(" and OperationTypeName = '{0}'", objge_OperationTypeEN.OperationTypeName);
}
if (clsge_OperationTypeBL.IsExistRecord(sbCondition.ToString())  ==  true)
{
 bolIsUniqueness = false;
}
else
{
 bolIsUniqueness = true;
}
}
 else {
sbCondition.AppendFormat("OperationTypeId !=  '{0}'", objge_OperationTypeEN.OperationTypeId);
 sbCondition.AppendFormat(" and OperationTypeId = '{0}'", objge_OperationTypeEN.OperationTypeId);
 sbCondition.AppendFormat(" and OperationTypeName = '{0}'", objge_OperationTypeEN.OperationTypeName);
if (clsge_OperationTypeBL.IsExistRecord(sbCondition.ToString())  ==  true)
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
 /// 获取唯一性条件串--ge_OperationType(操作类型), 即由对象中唯一性条件字段关键字与值组成的条件串
 /// 唯一性条件:OperationTypeId_OperationTypeName
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetConditionString4Constraint)
 /// </summary>
 /// <param name = "objge_OperationTypeEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(this clsge_OperationTypeEN objge_OperationTypeEN)
{
//检测记录是否存在
StringBuilder sbCondition = new StringBuilder();
if (objge_OperationTypeEN == null) return "";
if (objge_OperationTypeEN.OperationTypeId == null || objge_OperationTypeEN.OperationTypeId == "")
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and OperationTypeId = '{0}'", objge_OperationTypeEN.OperationTypeId);
 if (objge_OperationTypeEN.OperationTypeName == null)
{
 sbCondition.AppendFormat(" and OperationTypeName is null", objge_OperationTypeEN.OperationTypeName);
}
else
{
 sbCondition.AppendFormat(" and OperationTypeName = '{0}'", objge_OperationTypeEN.OperationTypeName);
}
return sbCondition.ToString();
}
 else {
sbCondition.AppendFormat("OperationTypeId !=  '{0}'", objge_OperationTypeEN.OperationTypeId);
 sbCondition.AppendFormat(" and OperationTypeId = '{0}'", objge_OperationTypeEN.OperationTypeId);
 sbCondition.AppendFormat(" and OperationTypeName = '{0}'", objge_OperationTypeEN.OperationTypeName);
 return sbCondition.ToString();
}
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_ge_OperationType
{
public virtual bool UpdRelaTabDate(string strOperationTypeId, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// 操作类型(ge_OperationType)
 /// 数据源类型:表
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsge_OperationTypeBL
{
public static RelatedActions_ge_OperationType relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsge_OperationTypeDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsge_OperationTypeDA ge_OperationTypeDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsge_OperationTypeDA();
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
 public clsge_OperationTypeBL()
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
if (string.IsNullOrEmpty(clsge_OperationTypeEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsge_OperationTypeEN._ConnectString);
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
public static DataTable GetDataTable_ge_OperationType(string strWhereCond)
{
DataTable objDT;
try
{
objDT = ge_OperationTypeDA.GetDataTable_ge_OperationType(strWhereCond);
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
objDT = ge_OperationTypeDA.GetDataTable(strWhereCond);
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
objDT = ge_OperationTypeDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = ge_OperationTypeDA.GetDataTable(strWhereCond, strTabName);
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
objDT = ge_OperationTypeDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = ge_OperationTypeDA.GetDataTable_Top(objTopPara);
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
objDT = ge_OperationTypeDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = ge_OperationTypeDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = ge_OperationTypeDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
 /// <param name = "arrOperationTypeIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static List<clsge_OperationTypeEN> GetObjLstByOperationTypeIdLst(List<string> arrOperationTypeIdLst)
{
List<clsge_OperationTypeEN> arrObjLst = new List<clsge_OperationTypeEN>(); 
System.Data.DataTable objDT; 
 string strSqlConditionStr = clsArray.GetSqlInStrByArray(arrOperationTypeIdLst, true);
 string strWhereCond = string.Format("OperationTypeId in ({0})", strSqlConditionStr);
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsge_OperationTypeEN objge_OperationTypeEN = new clsge_OperationTypeEN();
try
{
objge_OperationTypeEN.OperationTypeId = objRow[conge_OperationType.OperationTypeId].ToString().Trim(); //操作类型ID
objge_OperationTypeEN.OperationTypeName = objRow[conge_OperationType.OperationTypeName] == DBNull.Value ? null : objRow[conge_OperationType.OperationTypeName].ToString().Trim(); //操作类型名
objge_OperationTypeEN.OperationTypeEnName = objRow[conge_OperationType.OperationTypeEnName] == DBNull.Value ? null : objRow[conge_OperationType.OperationTypeEnName].ToString().Trim(); //OperationTypeEnName
objge_OperationTypeEN.UpdUser = objRow[conge_OperationType.UpdUser] == DBNull.Value ? null : objRow[conge_OperationType.UpdUser].ToString().Trim(); //修改人
objge_OperationTypeEN.UpdDate = objRow[conge_OperationType.UpdDate] == DBNull.Value ? null : objRow[conge_OperationType.UpdDate].ToString().Trim(); //修改日期
objge_OperationTypeEN.Memo = objRow[conge_OperationType.Memo] == DBNull.Value ? null : objRow[conge_OperationType.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objge_OperationTypeEN.OperationTypeId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objge_OperationTypeEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrOperationTypeIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsge_OperationTypeEN> GetObjLstByOperationTypeIdLstCache(List<string> arrOperationTypeIdLst)
{
string strKey = string.Format("{0}", clsge_OperationTypeEN._CurrTabName);
List<clsge_OperationTypeEN> arrge_OperationTypeObjLstCache = GetObjLstCache();
IEnumerable <clsge_OperationTypeEN> arrge_OperationTypeObjLst_Sel =
arrge_OperationTypeObjLstCache
.Where(x => arrOperationTypeIdLst.Contains(x.OperationTypeId));
return arrge_OperationTypeObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsge_OperationTypeEN> GetObjLst(string strWhereCond)
{
List<clsge_OperationTypeEN> arrObjLst = new List<clsge_OperationTypeEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsge_OperationTypeEN objge_OperationTypeEN = new clsge_OperationTypeEN();
try
{
objge_OperationTypeEN.OperationTypeId = objRow[conge_OperationType.OperationTypeId].ToString().Trim(); //操作类型ID
objge_OperationTypeEN.OperationTypeName = objRow[conge_OperationType.OperationTypeName] == DBNull.Value ? null : objRow[conge_OperationType.OperationTypeName].ToString().Trim(); //操作类型名
objge_OperationTypeEN.OperationTypeEnName = objRow[conge_OperationType.OperationTypeEnName] == DBNull.Value ? null : objRow[conge_OperationType.OperationTypeEnName].ToString().Trim(); //OperationTypeEnName
objge_OperationTypeEN.UpdUser = objRow[conge_OperationType.UpdUser] == DBNull.Value ? null : objRow[conge_OperationType.UpdUser].ToString().Trim(); //修改人
objge_OperationTypeEN.UpdDate = objRow[conge_OperationType.UpdDate] == DBNull.Value ? null : objRow[conge_OperationType.UpdDate].ToString().Trim(); //修改日期
objge_OperationTypeEN.Memo = objRow[conge_OperationType.Memo] == DBNull.Value ? null : objRow[conge_OperationType.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objge_OperationTypeEN.OperationTypeId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objge_OperationTypeEN);
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
public static List<clsge_OperationTypeEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsge_OperationTypeEN> arrObjLst = new List<clsge_OperationTypeEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsge_OperationTypeEN objge_OperationTypeEN = new clsge_OperationTypeEN();
try
{
objge_OperationTypeEN.OperationTypeId = objRow[conge_OperationType.OperationTypeId].ToString().Trim(); //操作类型ID
objge_OperationTypeEN.OperationTypeName = objRow[conge_OperationType.OperationTypeName] == DBNull.Value ? null : objRow[conge_OperationType.OperationTypeName].ToString().Trim(); //操作类型名
objge_OperationTypeEN.OperationTypeEnName = objRow[conge_OperationType.OperationTypeEnName] == DBNull.Value ? null : objRow[conge_OperationType.OperationTypeEnName].ToString().Trim(); //OperationTypeEnName
objge_OperationTypeEN.UpdUser = objRow[conge_OperationType.UpdUser] == DBNull.Value ? null : objRow[conge_OperationType.UpdUser].ToString().Trim(); //修改人
objge_OperationTypeEN.UpdDate = objRow[conge_OperationType.UpdDate] == DBNull.Value ? null : objRow[conge_OperationType.UpdDate].ToString().Trim(); //修改日期
objge_OperationTypeEN.Memo = objRow[conge_OperationType.Memo] == DBNull.Value ? null : objRow[conge_OperationType.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objge_OperationTypeEN.OperationTypeId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objge_OperationTypeEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objge_OperationTypeCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsge_OperationTypeEN> GetSubObjLstCache(clsge_OperationTypeEN objge_OperationTypeCond)
{
List<clsge_OperationTypeEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsge_OperationTypeEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conge_OperationType.AttributeName)
{
if (objge_OperationTypeCond.IsUpdated(strFldName) == false) continue;
if (objge_OperationTypeCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objge_OperationTypeCond[strFldName].ToString());
}
else
{
if (objge_OperationTypeCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objge_OperationTypeCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objge_OperationTypeCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objge_OperationTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objge_OperationTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objge_OperationTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objge_OperationTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objge_OperationTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objge_OperationTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objge_OperationTypeCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objge_OperationTypeCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objge_OperationTypeCond[strFldName]));
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
public static List<clsge_OperationTypeEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsge_OperationTypeEN> arrObjLst = new List<clsge_OperationTypeEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsge_OperationTypeEN objge_OperationTypeEN = new clsge_OperationTypeEN();
try
{
objge_OperationTypeEN.OperationTypeId = objRow[conge_OperationType.OperationTypeId].ToString().Trim(); //操作类型ID
objge_OperationTypeEN.OperationTypeName = objRow[conge_OperationType.OperationTypeName] == DBNull.Value ? null : objRow[conge_OperationType.OperationTypeName].ToString().Trim(); //操作类型名
objge_OperationTypeEN.OperationTypeEnName = objRow[conge_OperationType.OperationTypeEnName] == DBNull.Value ? null : objRow[conge_OperationType.OperationTypeEnName].ToString().Trim(); //OperationTypeEnName
objge_OperationTypeEN.UpdUser = objRow[conge_OperationType.UpdUser] == DBNull.Value ? null : objRow[conge_OperationType.UpdUser].ToString().Trim(); //修改人
objge_OperationTypeEN.UpdDate = objRow[conge_OperationType.UpdDate] == DBNull.Value ? null : objRow[conge_OperationType.UpdDate].ToString().Trim(); //修改日期
objge_OperationTypeEN.Memo = objRow[conge_OperationType.Memo] == DBNull.Value ? null : objRow[conge_OperationType.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objge_OperationTypeEN.OperationTypeId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objge_OperationTypeEN);
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
public static List<clsge_OperationTypeEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsge_OperationTypeEN> arrObjLst = new List<clsge_OperationTypeEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsge_OperationTypeEN objge_OperationTypeEN = new clsge_OperationTypeEN();
try
{
objge_OperationTypeEN.OperationTypeId = objRow[conge_OperationType.OperationTypeId].ToString().Trim(); //操作类型ID
objge_OperationTypeEN.OperationTypeName = objRow[conge_OperationType.OperationTypeName] == DBNull.Value ? null : objRow[conge_OperationType.OperationTypeName].ToString().Trim(); //操作类型名
objge_OperationTypeEN.OperationTypeEnName = objRow[conge_OperationType.OperationTypeEnName] == DBNull.Value ? null : objRow[conge_OperationType.OperationTypeEnName].ToString().Trim(); //OperationTypeEnName
objge_OperationTypeEN.UpdUser = objRow[conge_OperationType.UpdUser] == DBNull.Value ? null : objRow[conge_OperationType.UpdUser].ToString().Trim(); //修改人
objge_OperationTypeEN.UpdDate = objRow[conge_OperationType.UpdDate] == DBNull.Value ? null : objRow[conge_OperationType.UpdDate].ToString().Trim(); //修改日期
objge_OperationTypeEN.Memo = objRow[conge_OperationType.Memo] == DBNull.Value ? null : objRow[conge_OperationType.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objge_OperationTypeEN.OperationTypeId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objge_OperationTypeEN);
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
List<clsge_OperationTypeEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsge_OperationTypeEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsge_OperationTypeEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsge_OperationTypeEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsge_OperationTypeEN> arrObjLst = new List<clsge_OperationTypeEN>(); 
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
	clsge_OperationTypeEN objge_OperationTypeEN = new clsge_OperationTypeEN();
try
{
objge_OperationTypeEN.OperationTypeId = objRow[conge_OperationType.OperationTypeId].ToString().Trim(); //操作类型ID
objge_OperationTypeEN.OperationTypeName = objRow[conge_OperationType.OperationTypeName] == DBNull.Value ? null : objRow[conge_OperationType.OperationTypeName].ToString().Trim(); //操作类型名
objge_OperationTypeEN.OperationTypeEnName = objRow[conge_OperationType.OperationTypeEnName] == DBNull.Value ? null : objRow[conge_OperationType.OperationTypeEnName].ToString().Trim(); //OperationTypeEnName
objge_OperationTypeEN.UpdUser = objRow[conge_OperationType.UpdUser] == DBNull.Value ? null : objRow[conge_OperationType.UpdUser].ToString().Trim(); //修改人
objge_OperationTypeEN.UpdDate = objRow[conge_OperationType.UpdDate] == DBNull.Value ? null : objRow[conge_OperationType.UpdDate].ToString().Trim(); //修改日期
objge_OperationTypeEN.Memo = objRow[conge_OperationType.Memo] == DBNull.Value ? null : objRow[conge_OperationType.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objge_OperationTypeEN.OperationTypeId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objge_OperationTypeEN);
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
public static List<clsge_OperationTypeEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsge_OperationTypeEN> arrObjLst = new List<clsge_OperationTypeEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsge_OperationTypeEN objge_OperationTypeEN = new clsge_OperationTypeEN();
try
{
objge_OperationTypeEN.OperationTypeId = objRow[conge_OperationType.OperationTypeId].ToString().Trim(); //操作类型ID
objge_OperationTypeEN.OperationTypeName = objRow[conge_OperationType.OperationTypeName] == DBNull.Value ? null : objRow[conge_OperationType.OperationTypeName].ToString().Trim(); //操作类型名
objge_OperationTypeEN.OperationTypeEnName = objRow[conge_OperationType.OperationTypeEnName] == DBNull.Value ? null : objRow[conge_OperationType.OperationTypeEnName].ToString().Trim(); //OperationTypeEnName
objge_OperationTypeEN.UpdUser = objRow[conge_OperationType.UpdUser] == DBNull.Value ? null : objRow[conge_OperationType.UpdUser].ToString().Trim(); //修改人
objge_OperationTypeEN.UpdDate = objRow[conge_OperationType.UpdDate] == DBNull.Value ? null : objRow[conge_OperationType.UpdDate].ToString().Trim(); //修改日期
objge_OperationTypeEN.Memo = objRow[conge_OperationType.Memo] == DBNull.Value ? null : objRow[conge_OperationType.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objge_OperationTypeEN.OperationTypeId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objge_OperationTypeEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsge_OperationTypeEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsge_OperationTypeEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsge_OperationTypeEN> arrObjLst = new List<clsge_OperationTypeEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsge_OperationTypeEN objge_OperationTypeEN = new clsge_OperationTypeEN();
try
{
objge_OperationTypeEN.OperationTypeId = objRow[conge_OperationType.OperationTypeId].ToString().Trim(); //操作类型ID
objge_OperationTypeEN.OperationTypeName = objRow[conge_OperationType.OperationTypeName] == DBNull.Value ? null : objRow[conge_OperationType.OperationTypeName].ToString().Trim(); //操作类型名
objge_OperationTypeEN.OperationTypeEnName = objRow[conge_OperationType.OperationTypeEnName] == DBNull.Value ? null : objRow[conge_OperationType.OperationTypeEnName].ToString().Trim(); //OperationTypeEnName
objge_OperationTypeEN.UpdUser = objRow[conge_OperationType.UpdUser] == DBNull.Value ? null : objRow[conge_OperationType.UpdUser].ToString().Trim(); //修改人
objge_OperationTypeEN.UpdDate = objRow[conge_OperationType.UpdDate] == DBNull.Value ? null : objRow[conge_OperationType.UpdDate].ToString().Trim(); //修改日期
objge_OperationTypeEN.Memo = objRow[conge_OperationType.Memo] == DBNull.Value ? null : objRow[conge_OperationType.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objge_OperationTypeEN.OperationTypeId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objge_OperationTypeEN);
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
public static List<clsge_OperationTypeEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsge_OperationTypeEN> arrObjLst = new List<clsge_OperationTypeEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsge_OperationTypeEN objge_OperationTypeEN = new clsge_OperationTypeEN();
try
{
objge_OperationTypeEN.OperationTypeId = objRow[conge_OperationType.OperationTypeId].ToString().Trim(); //操作类型ID
objge_OperationTypeEN.OperationTypeName = objRow[conge_OperationType.OperationTypeName] == DBNull.Value ? null : objRow[conge_OperationType.OperationTypeName].ToString().Trim(); //操作类型名
objge_OperationTypeEN.OperationTypeEnName = objRow[conge_OperationType.OperationTypeEnName] == DBNull.Value ? null : objRow[conge_OperationType.OperationTypeEnName].ToString().Trim(); //OperationTypeEnName
objge_OperationTypeEN.UpdUser = objRow[conge_OperationType.UpdUser] == DBNull.Value ? null : objRow[conge_OperationType.UpdUser].ToString().Trim(); //修改人
objge_OperationTypeEN.UpdDate = objRow[conge_OperationType.UpdDate] == DBNull.Value ? null : objRow[conge_OperationType.UpdDate].ToString().Trim(); //修改日期
objge_OperationTypeEN.Memo = objRow[conge_OperationType.Memo] == DBNull.Value ? null : objRow[conge_OperationType.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objge_OperationTypeEN.OperationTypeId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objge_OperationTypeEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsge_OperationTypeEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsge_OperationTypeEN> arrObjLst = new List<clsge_OperationTypeEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsge_OperationTypeEN objge_OperationTypeEN = new clsge_OperationTypeEN();
try
{
objge_OperationTypeEN.OperationTypeId = objRow[conge_OperationType.OperationTypeId].ToString().Trim(); //操作类型ID
objge_OperationTypeEN.OperationTypeName = objRow[conge_OperationType.OperationTypeName] == DBNull.Value ? null : objRow[conge_OperationType.OperationTypeName].ToString().Trim(); //操作类型名
objge_OperationTypeEN.OperationTypeEnName = objRow[conge_OperationType.OperationTypeEnName] == DBNull.Value ? null : objRow[conge_OperationType.OperationTypeEnName].ToString().Trim(); //OperationTypeEnName
objge_OperationTypeEN.UpdUser = objRow[conge_OperationType.UpdUser] == DBNull.Value ? null : objRow[conge_OperationType.UpdUser].ToString().Trim(); //修改人
objge_OperationTypeEN.UpdDate = objRow[conge_OperationType.UpdDate] == DBNull.Value ? null : objRow[conge_OperationType.UpdDate].ToString().Trim(); //修改日期
objge_OperationTypeEN.Memo = objRow[conge_OperationType.Memo] == DBNull.Value ? null : objRow[conge_OperationType.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objge_OperationTypeEN.OperationTypeId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objge_OperationTypeEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objge_OperationTypeEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool Getge_OperationType(ref clsge_OperationTypeEN objge_OperationTypeEN)
{
bool bolResult = ge_OperationTypeDA.Getge_OperationType(ref objge_OperationTypeEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "strOperationTypeId">表关键字</param>
 /// <returns>表对象</returns>
public static clsge_OperationTypeEN GetObjByOperationTypeId(string strOperationTypeId)
{
if (strOperationTypeId.IndexOf(' ') >=0)
{
var strMsg = string.Format("(errid:Busi000079)在表中,关键字[strOperationTypeId]中不能有空格!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
if (string.IsNullOrEmpty(strOperationTypeId) == true)
{
var strMsg = string.Format("(errid:Busi000020)在表中,关键字[strOperationTypeId]不能为空!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
clsge_OperationTypeEN objge_OperationTypeEN = ge_OperationTypeDA.GetObjByOperationTypeId(strOperationTypeId);
return objge_OperationTypeEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsge_OperationTypeEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsge_OperationTypeEN objge_OperationTypeEN = ge_OperationTypeDA.GetFirstObj(strWhereCond);
 return objge_OperationTypeEN;
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
public static clsge_OperationTypeEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsge_OperationTypeEN objge_OperationTypeEN = ge_OperationTypeDA.GetObjByDataRow(objRow);
 return objge_OperationTypeEN;
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
public static clsge_OperationTypeEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsge_OperationTypeEN objge_OperationTypeEN = ge_OperationTypeDA.GetObjByDataRow(objRow);
 return objge_OperationTypeEN;
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
 /// <param name = "strOperationTypeId">所给的关键字</param>
 /// <param name = "lstge_OperationTypeObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsge_OperationTypeEN GetObjByOperationTypeIdFromList(string strOperationTypeId, List<clsge_OperationTypeEN> lstge_OperationTypeObjLst)
{
foreach (clsge_OperationTypeEN objge_OperationTypeEN in lstge_OperationTypeObjLst)
{
if (objge_OperationTypeEN.OperationTypeId == strOperationTypeId)
{
return objge_OperationTypeEN;
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
 string strOperationTypeId;
 try
 {
 strOperationTypeId = new clsge_OperationTypeDA().GetFirstID(strWhereCond);
 return strOperationTypeId;
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
 arrList = ge_OperationTypeDA.GetID(strWhereCond);
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
bool bolIsExist = ge_OperationTypeDA.IsExistCondRec(strWhereCond);
return bolIsExist;
}

 /// <summary>
 /// 判断当前表中是否存在给定关键字值的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExist)
 /// </summary>
 /// <param name = "strOperationTypeId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public static bool IsExist(string strOperationTypeId)
{
if (string.IsNullOrEmpty(strOperationTypeId) == true)
{
var strMsg = string.Format("(errid:Busi000027)在表中,关键字[strOperationTypeId]不能为空!!(from {0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
//检测记录是否存在
bool bolIsExist = ge_OperationTypeDA.IsExist(strOperationTypeId);
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
 bolIsExist = clsge_OperationTypeDA.IsExistTable();
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
 bolIsExist = ge_OperationTypeDA.IsExistTable(strTabName);
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
 /// <param name = "objge_OperationTypeEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecordBySql2(clsge_OperationTypeEN objge_OperationTypeEN, bool bolIsNeedCheckUniqueness=true)
{
 if (string.IsNullOrEmpty(objge_OperationTypeEN.OperationTypeId) == true)
 {
string strMsg = string.Format("添加记录时,关键字不能为空!(from {0})\r\n", 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
 if (clsge_OperationTypeBL.IsExist(objge_OperationTypeEN.OperationTypeId) == true)
 {
string strMsg = string.Format("添加记录时,关键字:[{0}]已经存在!(from {1})\r\n", objge_OperationTypeEN.OperationTypeId, 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
if (bolIsNeedCheckUniqueness == true && objge_OperationTypeEN.CheckUniqueness() == false)
{
var strMsg = string.Format("记录已经存在!操作类型ID = [{0}],操作类型名 = [{1}]的数据已经存在!(in clsge_OperationTypeBL.AddNewRecordBySql2)", objge_OperationTypeEN.OperationTypeId,objge_OperationTypeEN.OperationTypeName);
throw new Exception(strMsg);
}
try
{
bool bolResult = ge_OperationTypeDA.AddNewRecordBySQL2(objge_OperationTypeEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsge_OperationTypeBL.ReFreshCache();

if (clsge_OperationTypeBL.relatedActions != null)
{
clsge_OperationTypeBL.relatedActions.UpdRelaTabDate(objge_OperationTypeEN.OperationTypeId, "SetUpdDate");
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
 /// <param name = "objge_OperationTypeEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordBySql2WithReturnKey(clsge_OperationTypeEN objge_OperationTypeEN, bool bolIsNeedCheckUniqueness=true)
{
 if (string.IsNullOrEmpty(objge_OperationTypeEN.OperationTypeId) == true)
 {
string strMsg = string.Format("添加记录时,关键字不能为空!(from {{0}})", 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
 if (clsge_OperationTypeBL.IsExist(objge_OperationTypeEN.OperationTypeId) == true)
 {
string strMsg = string.Format("添加记录时,关键字:[{0}]已经存在!(from {1})\r\n", objge_OperationTypeEN.OperationTypeId, 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
if (bolIsNeedCheckUniqueness == true && objge_OperationTypeEN.CheckUniqueness() == false)
{
var strMsg = string.Format("记录已经存在!操作类型ID = [{0}],操作类型名 = [{1}]的数据已经存在!(in clsge_OperationTypeBL.AddNewRecordBySql2WithReturnKey)", objge_OperationTypeEN.OperationTypeId,objge_OperationTypeEN.OperationTypeName);
throw new Exception(strMsg);
}
try
{
string strKey = ge_OperationTypeDA.AddNewRecordBySQL2WithReturnKey(objge_OperationTypeEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsge_OperationTypeBL.ReFreshCache();

if (clsge_OperationTypeBL.relatedActions != null)
{
clsge_OperationTypeBL.relatedActions.UpdRelaTabDate(objge_OperationTypeEN.OperationTypeId, "SetUpdDate");
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
 /// <param name = "objge_OperationTypeEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(clsge_OperationTypeEN objge_OperationTypeEN)
{
try
{
bool bolResult = ge_OperationTypeDA.Update(objge_OperationTypeEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsge_OperationTypeBL.ReFreshCache();

if (clsge_OperationTypeBL.relatedActions != null)
{
clsge_OperationTypeBL.relatedActions.UpdRelaTabDate(objge_OperationTypeEN.OperationTypeId, "SetUpdDate");
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
 /// <param name = "objge_OperationTypeEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateBySql2(clsge_OperationTypeEN objge_OperationTypeEN)
{
 if (string.IsNullOrEmpty(objge_OperationTypeEN.OperationTypeId) == true)
 {
var strMsg = string.Format("(errid:Busi000065)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = ge_OperationTypeDA.UpdateBySql2(objge_OperationTypeEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsge_OperationTypeBL.ReFreshCache();

if (clsge_OperationTypeBL.relatedActions != null)
{
clsge_OperationTypeBL.relatedActions.UpdRelaTabDate(objge_OperationTypeEN.OperationTypeId, "SetUpdDate");
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
 /// <param name = "strOperationTypeId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int DelRecord(string strOperationTypeId)
{
try
{
 clsge_OperationTypeEN objge_OperationTypeEN = clsge_OperationTypeBL.GetObjByOperationTypeId(strOperationTypeId);

if (clsge_OperationTypeBL.relatedActions != null)
{
clsge_OperationTypeBL.relatedActions.UpdRelaTabDate(objge_OperationTypeEN.OperationTypeId, "SetUpdDate");
}
if (objge_OperationTypeEN != null)
{
int intRecNum = ge_OperationTypeDA.DelRecord(strOperationTypeId);
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
/// <param name="strOperationTypeId">表关键字</param>
/// <returns></returns>
public static bool DelRecordEx(string strOperationTypeId )
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsge_OperationTypeDA.GetSpecSQLObj();
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
//删除与表:[ge_OperationType]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conge_OperationType.OperationTypeId,
//strOperationTypeId);
//        clsge_OperationTypeBL.Delge_OperationTypesByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsge_OperationTypeBL.DelRecord(strOperationTypeId, objConnection, objSqlTransaction);
objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsge_OperationTypeBLEx", "DelRecordEx", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("扩展删除记录出错:{0}!keyId = {1}.({2})",
objException.Message,
strOperationTypeId, clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "strOperationTypeId">给定的关键字值</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回删除是否成功?</returns>
public static bool DelRecord(string strOperationTypeId, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
if (clsge_OperationTypeBL.relatedActions != null)
{
clsge_OperationTypeBL.relatedActions.UpdRelaTabDate(strOperationTypeId, "UpdRelaTabDate");
}
bool bolResult = ge_OperationTypeDA.DelRecord(strOperationTypeId,objSqlConnection,objSqlTransaction);
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
 /// <param name = "arrOperationTypeIdLst">给定的关键字值列表</param>
 /// <returns>返回删除的记录数</returns>
public static int Delge_OperationTypes(List<string> arrOperationTypeIdLst)
{
if (arrOperationTypeIdLst.Count == 0) return 0;
try
{
if (clsge_OperationTypeBL.relatedActions != null)
{
foreach (var strOperationTypeId in arrOperationTypeIdLst)
{
clsge_OperationTypeBL.relatedActions.UpdRelaTabDate(strOperationTypeId, "UpdRelaTabDate");
}
}
int intDelRecNum = ge_OperationTypeDA.Delge_OperationType(arrOperationTypeIdLst);
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
public static int Delge_OperationTypesByCond(string strWhereCond)
{
try
{
if (clsge_OperationTypeBL.relatedActions != null)
{
List<string> arrOperationTypeId = GetPrimaryKeyID_S(strWhereCond);
foreach (var strOperationTypeId in arrOperationTypeId)
{
clsge_OperationTypeBL.relatedActions.UpdRelaTabDate(strOperationTypeId, "UpdRelaTabDate");
}
}
int intRecNum = ge_OperationTypeDA.Delge_OperationType(strWhereCond);
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
/// 这里仅仅是演示函数,使用时请复制到扩展类:[ge_OperationType]中改名为:[DelRecord4MultiTabEx]使用
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DelRecord4MultiTab)
/// </summary>
/// <param name="strOperationTypeId">表关键字</param>
/// <returns></returns>
public static bool DelRecord4MultiTab(string strOperationTypeId)
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsge_OperationTypeDA.GetSpecSQLObj();
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
//删除与表:[ge_OperationType]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conStudent.id_College,
//strid_College);
//        clsStudentBL.DelStudentsByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsge_OperationTypeBL.DelRecord(strOperationTypeId, objConnection, objSqlTransaction);
                objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsge_OperationTypeBL", "DelRecord4MultiTab", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("删除多表记录出错:{0}!keyId = {1}.({2})",
objException.Message,
strOperationTypeId, clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "objge_OperationTypeENS">源对象</param>
 /// <param name = "objge_OperationTypeENT">目标对象</param>
 public static void CopyTo(clsge_OperationTypeEN objge_OperationTypeENS, clsge_OperationTypeEN objge_OperationTypeENT)
{
try
{
objge_OperationTypeENT.OperationTypeId = objge_OperationTypeENS.OperationTypeId; //操作类型ID
objge_OperationTypeENT.OperationTypeName = objge_OperationTypeENS.OperationTypeName; //操作类型名
objge_OperationTypeENT.OperationTypeEnName = objge_OperationTypeENS.OperationTypeEnName; //OperationTypeEnName
objge_OperationTypeENT.UpdUser = objge_OperationTypeENS.UpdUser; //修改人
objge_OperationTypeENT.UpdDate = objge_OperationTypeENS.UpdDate; //修改日期
objge_OperationTypeENT.Memo = objge_OperationTypeENS.Memo; //备注
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
 /// <param name = "objge_OperationTypeEN">源简化对象</param>
 public static void SetUpdFlag(clsge_OperationTypeEN objge_OperationTypeEN)
{
try
{
objge_OperationTypeEN.ClearUpdateState();
   string strsfUpdFldSetStr = objge_OperationTypeEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(conge_OperationType.OperationTypeId, new clsStrCompareIgnoreCase())  ==  true)
{
objge_OperationTypeEN.OperationTypeId = objge_OperationTypeEN.OperationTypeId; //操作类型ID
}
if (arrFldSet.Contains(conge_OperationType.OperationTypeName, new clsStrCompareIgnoreCase())  ==  true)
{
objge_OperationTypeEN.OperationTypeName = objge_OperationTypeEN.OperationTypeName == "[null]" ? null :  objge_OperationTypeEN.OperationTypeName; //操作类型名
}
if (arrFldSet.Contains(conge_OperationType.OperationTypeEnName, new clsStrCompareIgnoreCase())  ==  true)
{
objge_OperationTypeEN.OperationTypeEnName = objge_OperationTypeEN.OperationTypeEnName == "[null]" ? null :  objge_OperationTypeEN.OperationTypeEnName; //OperationTypeEnName
}
if (arrFldSet.Contains(conge_OperationType.UpdUser, new clsStrCompareIgnoreCase())  ==  true)
{
objge_OperationTypeEN.UpdUser = objge_OperationTypeEN.UpdUser == "[null]" ? null :  objge_OperationTypeEN.UpdUser; //修改人
}
if (arrFldSet.Contains(conge_OperationType.UpdDate, new clsStrCompareIgnoreCase())  ==  true)
{
objge_OperationTypeEN.UpdDate = objge_OperationTypeEN.UpdDate == "[null]" ? null :  objge_OperationTypeEN.UpdDate; //修改日期
}
if (arrFldSet.Contains(conge_OperationType.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objge_OperationTypeEN.Memo = objge_OperationTypeEN.Memo == "[null]" ? null :  objge_OperationTypeEN.Memo; //备注
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
 /// <param name = "objge_OperationTypeEN">源简化对象</param>
 public static void AccessFldValueNull(clsge_OperationTypeEN objge_OperationTypeEN)
{
try
{
if (objge_OperationTypeEN.OperationTypeName == "[null]") objge_OperationTypeEN.OperationTypeName = null; //操作类型名
if (objge_OperationTypeEN.OperationTypeEnName == "[null]") objge_OperationTypeEN.OperationTypeEnName = null; //OperationTypeEnName
if (objge_OperationTypeEN.UpdUser == "[null]") objge_OperationTypeEN.UpdUser = null; //修改人
if (objge_OperationTypeEN.UpdDate == "[null]") objge_OperationTypeEN.UpdDate = null; //修改日期
if (objge_OperationTypeEN.Memo == "[null]") objge_OperationTypeEN.Memo = null; //备注
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
public static void CheckPropertyNew(clsge_OperationTypeEN objge_OperationTypeEN)
{
 ge_OperationTypeDA.CheckPropertyNew(objge_OperationTypeEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(clsge_OperationTypeEN objge_OperationTypeEN)
{
 ge_OperationTypeDA.CheckProperty4Condition(objge_OperationTypeEN);
 }


 #endregion 检查对象属性


 #region 绑定下拉框

 /// <summary>
 /// 绑定基于Web的下拉框-使用Cache
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DdlBindFunctionCache)
 /// </summary>
 /// <param name = "objDDL">需要绑定当前表的下拉框</param>
public static void BindDdl_OperationTypeIdCache(System.Web.UI.WebControls.DropDownList objDDL)
{
//为数据源于表的下拉框设置内容
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[操作类型]...","0");
List<clsge_OperationTypeEN> arrge_OperationTypeObjLst = GetAllge_OperationTypeObjLstCache(); 
objDDL.DataValueField = conge_OperationType.OperationTypeId;
objDDL.DataTextField = conge_OperationType.OperationTypeName;
objDDL.DataSource = arrge_OperationTypeObjLst;
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
if (clsge_OperationTypeBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsge_OperationTypeBL没有刷新缓存机制(clsge_OperationTypeBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by OperationTypeId");
//if (arrge_OperationTypeObjLstCache == null)
//{
//arrge_OperationTypeObjLstCache = ge_OperationTypeDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "strOperationTypeId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsge_OperationTypeEN GetObjByOperationTypeIdCache(string strOperationTypeId)
{
//获取缓存中的对象列表
string strKey = string.Format("{0}", clsge_OperationTypeEN._CurrTabName);
List<clsge_OperationTypeEN> arrge_OperationTypeObjLstCache = GetObjLstCache();
IEnumerable <clsge_OperationTypeEN> arrge_OperationTypeObjLst_Sel =
arrge_OperationTypeObjLstCache
.Where(x=> x.OperationTypeId == strOperationTypeId 
);
if (arrge_OperationTypeObjLst_Sel.Count() == 0)
{
   clsge_OperationTypeEN obj = clsge_OperationTypeBL.GetObjByOperationTypeId(strOperationTypeId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
 }
return null;
}
return arrge_OperationTypeObjLst_Sel.First();
}

 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecNameByKeyCache)
 /// </summary>
 /// <param name = "strOperationTypeId">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetOperationTypeNameByOperationTypeIdCache(string strOperationTypeId)
{
if (string.IsNullOrEmpty(strOperationTypeId) == true) return "";
//获取缓存中的对象列表
clsge_OperationTypeEN objge_OperationType = GetObjByOperationTypeIdCache(strOperationTypeId);
if (objge_OperationType == null) return "";
return objge_OperationType.OperationTypeName;
}
 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecNameByKeyCache)
 /// </summary>
 /// <param name = "strOperationTypeId">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetNameByOperationTypeIdCache(string strOperationTypeId)
{
if (string.IsNullOrEmpty(strOperationTypeId) == true) return "";
//获取缓存中的对象列表
clsge_OperationTypeEN objge_OperationType = GetObjByOperationTypeIdCache(strOperationTypeId);
if (objge_OperationType == null) return "";
return objge_OperationType.OperationTypeName;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsge_OperationTypeEN> GetAllge_OperationTypeObjLstCache()
{
//获取缓存中的对象列表
List<clsge_OperationTypeEN> arrge_OperationTypeObjLstCache = GetObjLstCache(); 
return arrge_OperationTypeObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsge_OperationTypeEN> GetObjLstCache()
{
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}", clsge_OperationTypeEN._CurrTabName);
List<clsge_OperationTypeEN> arrge_OperationTypeObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrge_OperationTypeObjLstCache;
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
string strKey = string.Format("{0}", clsge_OperationTypeEN._CurrTabName);
CacheHelper.Remove(strKey);
clsge_OperationTypeEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
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
if (clsge_OperationTypeEN._RefreshTimeLst.Count == 0) return "";
return clsge_OperationTypeEN._RefreshTimeLst[clsge_OperationTypeEN._RefreshTimeLst.Count - 1];
}

 /// <summary>
 /// 刷新缓存.把当前表的缓存以及该表相关视图的缓存清空.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ReFreshCache)
 /// </summary>
public static void ReFreshCache()
{
if (clsge_OperationTypeBL.objCommFun4BL != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}", clsge_OperationTypeEN._CurrTabName);
CacheHelper.Remove(strKey);
clsge_OperationTypeEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
clsge_OperationTypeBL.objCommFun4BL.ReFreshCache();
}
}


 #endregion 缓存操作


 #region 检查唯一性

 /// <summary>
 /// 获取检查唯一性条件串(Uniqueness)--ge_OperationType(操作类型)
 /// 唯一性条件:OperationTypeId_OperationTypeName
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetUniquenessConditionString)
 /// </summary>
 /// <param name = "objge_OperationTypeEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(clsge_OperationTypeEN objge_OperationTypeEN)
{
//检测记录是否存在
string strResult = ge_OperationTypeDA.GetUniCondStr(objge_OperationTypeEN);
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
public static string Func(string strInFldName, string strOutFldName, string strOperationTypeId)
{
if (strInFldName != conge_OperationType.OperationTypeId)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (conge_OperationType.AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", conge_OperationType.AttributeName));
throw new Exception(strMsg);
}
var objge_OperationType = clsge_OperationTypeBL.GetObjByOperationTypeIdCache(strOperationTypeId);
if (objge_OperationType == null) return "";
return objge_OperationType[strOutFldName].ToString();
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
int intRecCount = clsge_OperationTypeDA.GetRecCount(strTabName);
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
int intRecCount = clsge_OperationTypeDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsge_OperationTypeDA.GetRecCount();
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
int intRecCount = clsge_OperationTypeDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objge_OperationTypeCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsge_OperationTypeEN objge_OperationTypeCond)
{
List<clsge_OperationTypeEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsge_OperationTypeEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conge_OperationType.AttributeName)
{
if (objge_OperationTypeCond.IsUpdated(strFldName) == false) continue;
if (objge_OperationTypeCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objge_OperationTypeCond[strFldName].ToString());
}
else
{
if (objge_OperationTypeCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objge_OperationTypeCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objge_OperationTypeCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objge_OperationTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objge_OperationTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objge_OperationTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objge_OperationTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objge_OperationTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objge_OperationTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objge_OperationTypeCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objge_OperationTypeCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objge_OperationTypeCond[strFldName]));
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
 List<string> arrList = clsge_OperationTypeDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = ge_OperationTypeDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = ge_OperationTypeDA.GetFldValueNoDistinct(strFldName, strWhereCond);
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
int intRecCount = ge_OperationTypeDA.SetFldValue(strFldName, strValue, strWhereCond);
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
int intRecCount = clsge_OperationTypeDA.SetFldValue(clsge_OperationTypeEN._CurrTabName, strFldName, fltValue, strWhereCond);
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
int intRecCount = ge_OperationTypeDA.SetFldValue( strFldName, intValue, strWhereCond);
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
int intRecCount = clsge_OperationTypeDA.SetFldValue(strTabName, strFldName, strValue, strWhereCond);
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
int intRecCount = clsge_OperationTypeDA.SetFldValue(strTabName, strFldName, intValue, strWhereCond);
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
int intRecCount = clsge_OperationTypeDA.SetFldValue(strTabName, strFldName, fltValue, strWhereCond);
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
  strCreateTabCode.Append("CREATE table [dbo].[ge_OperationType] "); 
 strCreateTabCode.Append(" ( "); 
 // /**操作类型ID*/ 
 strCreateTabCode.Append(" OperationTypeId char(4) primary key, "); 
 // /**操作类型名*/ 
 strCreateTabCode.Append(" OperationTypeName varchar(50) Null, "); 
 // /**OperationTypeEnName*/ 
 strCreateTabCode.Append(" OperationTypeEnName varchar(100) Null, "); 
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
 /// 操作类型(ge_OperationType)
 /// 数据源类型:表
 /// (AutoGCLib.CommFun4BL4CSharp:GeneCode_This)
 /// </summary>
public class  clsCommFun4BL4ge_OperationType : clsCommFun4BL
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
clsge_OperationTypeBL.ReFreshThisCache();
}
}

}