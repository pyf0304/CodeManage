
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsMicroteachCaseTypeBL
 表名:MicroteachCaseType(01120323)
 * 版本:2023.08.23.1(服务器:WIN-SRV103-116)
 日期:2023/08/24 14:17:07
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:公共后台所有表(变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:微格教学评议(MicroTeachSenate)
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
public static class  clsMicroteachCaseTypeBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "strIdMicroteachCaseType">表关键字</param>
 /// <returns>表对象</returns>
public static clsMicroteachCaseTypeEN GetObj(this K_IdMicroteachCaseType_MicroteachCaseType myKey)
{
clsMicroteachCaseTypeEN objMicroteachCaseTypeEN = clsMicroteachCaseTypeBL.MicroteachCaseTypeDA.GetObjByIdMicroteachCaseType(myKey.Value);
return objMicroteachCaseTypeEN;
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_AddNewRecord)
 /// </summary>
 /// <param name = "objMicroteachCaseTypeEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clsMicroteachCaseTypeEN objMicroteachCaseTypeEN)
{
 if (string.IsNullOrEmpty(objMicroteachCaseTypeEN.IdMicroteachCaseType) == true)
 {
string strMsg = string.Format("添加记录时,关键字不能为空!(from {0})\r\n", 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
 if (clsMicroteachCaseTypeBL.IsExist(objMicroteachCaseTypeEN.IdMicroteachCaseType) == true)
 {
string strMsg = string.Format("添加记录时,关键字:[{0}]已经存在!(from {1})\r\n", objMicroteachCaseTypeEN.IdMicroteachCaseType, 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
try
{
bool bolResult = clsMicroteachCaseTypeBL.MicroteachCaseTypeDA.AddNewRecordBySQL2(objMicroteachCaseTypeEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsMicroteachCaseTypeBL.ReFreshCache();

if (clsMicroteachCaseTypeBL.relatedActions != null)
{
clsMicroteachCaseTypeBL.relatedActions.UpdRelaTabDate(objMicroteachCaseTypeEN.IdMicroteachCaseType, "SetUpdDate");
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
public static bool AddRecordEx(this clsMicroteachCaseTypeEN objMicroteachCaseTypeEN)
{
//操作步骤:
//1、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在
//2、检查唯一性
//3、检查传进去的对象属性是否合法
//4、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
//1、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在
if (clsMicroteachCaseTypeBL.IsExist(objMicroteachCaseTypeEN.IdMicroteachCaseType))	//判断是否有相同的关键字
{
strMsg = "(errid:Busi000151)关键字字段已有相同的值";
throw new Exception(strMsg);
}
try
{
 //2、检查传进去的对象属性是否合法
objMicroteachCaseTypeEN.CheckPropertyNew();
//6、把数据实体层的数据存贮到数据库中
objMicroteachCaseTypeEN.AddNewRecord();
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
 /// <param name = "objMicroteachCaseTypeEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordWithReturnKey(this clsMicroteachCaseTypeEN objMicroteachCaseTypeEN)
{
 if (string.IsNullOrEmpty(objMicroteachCaseTypeEN.IdMicroteachCaseType) == true)
 {
string strMsg = string.Format("添加记录时,关键字不能为空!(from {{0}})", 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
 if (clsMicroteachCaseTypeBL.IsExist(objMicroteachCaseTypeEN.IdMicroteachCaseType) == true)
 {
string strMsg = string.Format("添加记录时,关键字:[{0}]已经存在!(from {1})\r\n", objMicroteachCaseTypeEN.IdMicroteachCaseType, 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
try
{
string strKey = clsMicroteachCaseTypeBL.MicroteachCaseTypeDA.AddNewRecordBySQL2WithReturnKey(objMicroteachCaseTypeEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsMicroteachCaseTypeBL.ReFreshCache();

if (clsMicroteachCaseTypeBL.relatedActions != null)
{
clsMicroteachCaseTypeBL.relatedActions.UpdRelaTabDate(objMicroteachCaseTypeEN.IdMicroteachCaseType, "SetUpdDate");
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
 /// <param name = "objMicroteachCaseTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsMicroteachCaseTypeEN SetIdMicroteachCaseType(this clsMicroteachCaseTypeEN objMicroteachCaseTypeEN, string strIdMicroteachCaseType, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdMicroteachCaseType, 4, conMicroteachCaseType.IdMicroteachCaseType);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdMicroteachCaseType, 4, conMicroteachCaseType.IdMicroteachCaseType);
}
objMicroteachCaseTypeEN.IdMicroteachCaseType = strIdMicroteachCaseType; //微格案例类型流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objMicroteachCaseTypeEN.dicFldComparisonOp.ContainsKey(conMicroteachCaseType.IdMicroteachCaseType) == false)
{
objMicroteachCaseTypeEN.dicFldComparisonOp.Add(conMicroteachCaseType.IdMicroteachCaseType, strComparisonOp);
}
else
{
objMicroteachCaseTypeEN.dicFldComparisonOp[conMicroteachCaseType.IdMicroteachCaseType] = strComparisonOp;
}
}
return objMicroteachCaseTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objMicroteachCaseTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsMicroteachCaseTypeEN SetMicroteachCaseTypeID(this clsMicroteachCaseTypeEN objMicroteachCaseTypeEN, string strMicroteachCaseTypeID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strMicroteachCaseTypeID, conMicroteachCaseType.MicroteachCaseTypeID);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMicroteachCaseTypeID, 4, conMicroteachCaseType.MicroteachCaseTypeID);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strMicroteachCaseTypeID, 4, conMicroteachCaseType.MicroteachCaseTypeID);
}
objMicroteachCaseTypeEN.MicroteachCaseTypeID = strMicroteachCaseTypeID; //微格案例类型ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objMicroteachCaseTypeEN.dicFldComparisonOp.ContainsKey(conMicroteachCaseType.MicroteachCaseTypeID) == false)
{
objMicroteachCaseTypeEN.dicFldComparisonOp.Add(conMicroteachCaseType.MicroteachCaseTypeID, strComparisonOp);
}
else
{
objMicroteachCaseTypeEN.dicFldComparisonOp[conMicroteachCaseType.MicroteachCaseTypeID] = strComparisonOp;
}
}
return objMicroteachCaseTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objMicroteachCaseTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsMicroteachCaseTypeEN SetMicroteachCaseTypeName(this clsMicroteachCaseTypeEN objMicroteachCaseTypeEN, string strMicroteachCaseTypeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strMicroteachCaseTypeName, conMicroteachCaseType.MicroteachCaseTypeName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMicroteachCaseTypeName, 50, conMicroteachCaseType.MicroteachCaseTypeName);
}
objMicroteachCaseTypeEN.MicroteachCaseTypeName = strMicroteachCaseTypeName; //微格案例类型名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objMicroteachCaseTypeEN.dicFldComparisonOp.ContainsKey(conMicroteachCaseType.MicroteachCaseTypeName) == false)
{
objMicroteachCaseTypeEN.dicFldComparisonOp.Add(conMicroteachCaseType.MicroteachCaseTypeName, strComparisonOp);
}
else
{
objMicroteachCaseTypeEN.dicFldComparisonOp[conMicroteachCaseType.MicroteachCaseTypeName] = strComparisonOp;
}
}
return objMicroteachCaseTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objMicroteachCaseTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsMicroteachCaseTypeEN SetMemo(this clsMicroteachCaseTypeEN objMicroteachCaseTypeEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, conMicroteachCaseType.Memo);
}
objMicroteachCaseTypeEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objMicroteachCaseTypeEN.dicFldComparisonOp.ContainsKey(conMicroteachCaseType.Memo) == false)
{
objMicroteachCaseTypeEN.dicFldComparisonOp.Add(conMicroteachCaseType.Memo, strComparisonOp);
}
else
{
objMicroteachCaseTypeEN.dicFldComparisonOp[conMicroteachCaseType.Memo] = strComparisonOp;
}
}
return objMicroteachCaseTypeEN;
	}

 /// <summary>
 /// 修改记录存盘到数据表中
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_UpdateRecordEx)
 /// </summary>
 /// <param name = "objMicroteachCaseTypeEN">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool UpdateRecordEx(this clsMicroteachCaseTypeEN objMicroteachCaseTypeEN)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
try
{
//1、检查传进去的对象属性是否合法
objMicroteachCaseTypeEN.CheckPropertyNew();
clsMicroteachCaseTypeEN objMicroteachCaseTypeCond = new clsMicroteachCaseTypeEN();
string strCondition = objMicroteachCaseTypeCond
.SetIdMicroteachCaseType(objMicroteachCaseTypeEN.IdMicroteachCaseType, "=")
.GetCombineCondition();
objMicroteachCaseTypeEN._IsCheckProperty = true;
bool bolIsExist = clsMicroteachCaseTypeBL.IsExistRecord(strCondition);
if (bolIsExist)
{
strMsg = "()不能重复!";
throw new Exception(strMsg);
}
//4、把数据实体层的数据存贮到数据库中
objMicroteachCaseTypeEN.Update();
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
 /// <param name = "objMicroteachCaseTypeEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsMicroteachCaseTypeEN objMicroteachCaseTypeEN)
{
 if (string.IsNullOrEmpty(objMicroteachCaseTypeEN.IdMicroteachCaseType) == true)
 {
string strMsg = string.Format("(errid:Busi000095)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsMicroteachCaseTypeBL.MicroteachCaseTypeDA.UpdateBySql2(objMicroteachCaseTypeEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsMicroteachCaseTypeBL.ReFreshCache();

if (clsMicroteachCaseTypeBL.relatedActions != null)
{
clsMicroteachCaseTypeBL.relatedActions.UpdRelaTabDate(objMicroteachCaseTypeEN.IdMicroteachCaseType, "SetUpdDate");
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
 /// <param name = "objMicroteachCaseTypeEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsMicroteachCaseTypeEN objMicroteachCaseTypeEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (string.IsNullOrEmpty(objMicroteachCaseTypeEN.IdMicroteachCaseType) == true)
 {
string strMsg = string.Format("(errid:Busi000087)修改记录时关键字不能为空!(带事务处理)(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsMicroteachCaseTypeBL.MicroteachCaseTypeDA.UpdateBySql2(objMicroteachCaseTypeEN, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsMicroteachCaseTypeBL.ReFreshCache();

if (clsMicroteachCaseTypeBL.relatedActions != null)
{
clsMicroteachCaseTypeBL.relatedActions.UpdRelaTabDate(objMicroteachCaseTypeEN.IdMicroteachCaseType, "SetUpdDate");
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
 /// <param name = "objMicroteachCaseTypeEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsMicroteachCaseTypeEN objMicroteachCaseTypeEN, string strWhereCond)
{
try
{
bool bolResult = clsMicroteachCaseTypeBL.MicroteachCaseTypeDA.UpdateBySqlWithCondition(objMicroteachCaseTypeEN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsMicroteachCaseTypeBL.ReFreshCache();

if (clsMicroteachCaseTypeBL.relatedActions != null)
{
clsMicroteachCaseTypeBL.relatedActions.UpdRelaTabDate(objMicroteachCaseTypeEN.IdMicroteachCaseType, "SetUpdDate");
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
 /// <param name = "objMicroteachCaseTypeEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsMicroteachCaseTypeEN objMicroteachCaseTypeEN, string strWhereCond, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
bool bolResult = clsMicroteachCaseTypeBL.MicroteachCaseTypeDA.UpdateBySqlWithConditionTransaction(objMicroteachCaseTypeEN, strWhereCond, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsMicroteachCaseTypeBL.ReFreshCache();

if (clsMicroteachCaseTypeBL.relatedActions != null)
{
clsMicroteachCaseTypeBL.relatedActions.UpdRelaTabDate(objMicroteachCaseTypeEN.IdMicroteachCaseType, "SetUpdDate");
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
 /// <param name = "strIdMicroteachCaseType">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int Delete(this clsMicroteachCaseTypeEN objMicroteachCaseTypeEN)
{
try
{
int intRecNum = clsMicroteachCaseTypeBL.MicroteachCaseTypeDA.DelRecord(objMicroteachCaseTypeEN.IdMicroteachCaseType);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsMicroteachCaseTypeBL.ReFreshCache();

if (clsMicroteachCaseTypeBL.relatedActions != null)
{
clsMicroteachCaseTypeBL.relatedActions.UpdRelaTabDate(objMicroteachCaseTypeEN.IdMicroteachCaseType, "SetUpdDate");
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
 /// <param name = "objMicroteachCaseTypeENS">源对象</param>
 /// <param name = "objMicroteachCaseTypeENT">目标对象</param>
 public static void CopyTo(this clsMicroteachCaseTypeEN objMicroteachCaseTypeENS, clsMicroteachCaseTypeEN objMicroteachCaseTypeENT)
{
try
{
objMicroteachCaseTypeENT.IdMicroteachCaseType = objMicroteachCaseTypeENS.IdMicroteachCaseType; //微格案例类型流水号
objMicroteachCaseTypeENT.MicroteachCaseTypeID = objMicroteachCaseTypeENS.MicroteachCaseTypeID; //微格案例类型ID
objMicroteachCaseTypeENT.MicroteachCaseTypeName = objMicroteachCaseTypeENS.MicroteachCaseTypeName; //微格案例类型名称
objMicroteachCaseTypeENT.Memo = objMicroteachCaseTypeENS.Memo; //备注
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
 /// <param name = "objMicroteachCaseTypeENS">源对象</param>
 /// <returns>目标对象=>clsMicroteachCaseTypeEN:objMicroteachCaseTypeENT</returns>
 public static clsMicroteachCaseTypeEN CopyTo(this clsMicroteachCaseTypeEN objMicroteachCaseTypeENS)
{
try
{
 clsMicroteachCaseTypeEN objMicroteachCaseTypeENT = new clsMicroteachCaseTypeEN()
{
IdMicroteachCaseType = objMicroteachCaseTypeENS.IdMicroteachCaseType, //微格案例类型流水号
MicroteachCaseTypeID = objMicroteachCaseTypeENS.MicroteachCaseTypeID, //微格案例类型ID
MicroteachCaseTypeName = objMicroteachCaseTypeENS.MicroteachCaseTypeName, //微格案例类型名称
Memo = objMicroteachCaseTypeENS.Memo, //备注
};
 return objMicroteachCaseTypeENT;
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
public static void CheckPropertyNew(this clsMicroteachCaseTypeEN objMicroteachCaseTypeEN)
{
 clsMicroteachCaseTypeBL.MicroteachCaseTypeDA.CheckPropertyNew(objMicroteachCaseTypeEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(this clsMicroteachCaseTypeEN objMicroteachCaseTypeEN)
{
 clsMicroteachCaseTypeBL.MicroteachCaseTypeDA.CheckProperty4Condition(objMicroteachCaseTypeEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsMicroteachCaseTypeEN objMicroteachCaseTypeCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objMicroteachCaseTypeCond.IsUpdated(conMicroteachCaseType.IdMicroteachCaseType) == true)
{
string strComparisonOpIdMicroteachCaseType = objMicroteachCaseTypeCond.dicFldComparisonOp[conMicroteachCaseType.IdMicroteachCaseType];
strWhereCond += string.Format(" And {0} {2} '{1}'", conMicroteachCaseType.IdMicroteachCaseType, objMicroteachCaseTypeCond.IdMicroteachCaseType, strComparisonOpIdMicroteachCaseType);
}
if (objMicroteachCaseTypeCond.IsUpdated(conMicroteachCaseType.MicroteachCaseTypeID) == true)
{
string strComparisonOpMicroteachCaseTypeID = objMicroteachCaseTypeCond.dicFldComparisonOp[conMicroteachCaseType.MicroteachCaseTypeID];
strWhereCond += string.Format(" And {0} {2} '{1}'", conMicroteachCaseType.MicroteachCaseTypeID, objMicroteachCaseTypeCond.MicroteachCaseTypeID, strComparisonOpMicroteachCaseTypeID);
}
if (objMicroteachCaseTypeCond.IsUpdated(conMicroteachCaseType.MicroteachCaseTypeName) == true)
{
string strComparisonOpMicroteachCaseTypeName = objMicroteachCaseTypeCond.dicFldComparisonOp[conMicroteachCaseType.MicroteachCaseTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", conMicroteachCaseType.MicroteachCaseTypeName, objMicroteachCaseTypeCond.MicroteachCaseTypeName, strComparisonOpMicroteachCaseTypeName);
}
if (objMicroteachCaseTypeCond.IsUpdated(conMicroteachCaseType.Memo) == true)
{
string strComparisonOpMemo = objMicroteachCaseTypeCond.dicFldComparisonOp[conMicroteachCaseType.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", conMicroteachCaseType.Memo, objMicroteachCaseTypeCond.Memo, strComparisonOpMemo);
}
 return strWhereCond;
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_MicroteachCaseType
{
public virtual bool UpdRelaTabDate(string strIdMicroteachCaseType, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// 微格案例类型(MicroteachCaseType)
 /// 数据源类型:表
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsMicroteachCaseTypeBL
{
public static RelatedActions_MicroteachCaseType relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsMicroteachCaseTypeDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsMicroteachCaseTypeDA MicroteachCaseTypeDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsMicroteachCaseTypeDA();
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
 public clsMicroteachCaseTypeBL()
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
if (string.IsNullOrEmpty(clsMicroteachCaseTypeEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsMicroteachCaseTypeEN._ConnectString);
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
public static DataTable GetDataTable_MicroteachCaseType(string strWhereCond)
{
DataTable objDT;
try
{
objDT = MicroteachCaseTypeDA.GetDataTable_MicroteachCaseType(strWhereCond);
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
objDT = MicroteachCaseTypeDA.GetDataTable(strWhereCond);
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
objDT = MicroteachCaseTypeDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = MicroteachCaseTypeDA.GetDataTable(strWhereCond, strTabName);
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
objDT = MicroteachCaseTypeDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = MicroteachCaseTypeDA.GetDataTable_Top(objTopPara);
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
objDT = MicroteachCaseTypeDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = MicroteachCaseTypeDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = MicroteachCaseTypeDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
 /// <param name = "arrIdMicroteachCaseTypeLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static List<clsMicroteachCaseTypeEN> GetObjLstByIdMicroteachCaseTypeLst(List<string> arrIdMicroteachCaseTypeLst)
{
List<clsMicroteachCaseTypeEN> arrObjLst = new List<clsMicroteachCaseTypeEN>(); 
System.Data.DataTable objDT; 
 string strSqlConditionStr = clsArray.GetSqlInStrByArray(arrIdMicroteachCaseTypeLst, true);
 string strWhereCond = string.Format("IdMicroteachCaseType in ({0})", strSqlConditionStr);
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsMicroteachCaseTypeEN objMicroteachCaseTypeEN = new clsMicroteachCaseTypeEN();
try
{
objMicroteachCaseTypeEN.IdMicroteachCaseType = objRow[conMicroteachCaseType.IdMicroteachCaseType].ToString().Trim(); //微格案例类型流水号
objMicroteachCaseTypeEN.MicroteachCaseTypeID = objRow[conMicroteachCaseType.MicroteachCaseTypeID].ToString().Trim(); //微格案例类型ID
objMicroteachCaseTypeEN.MicroteachCaseTypeName = objRow[conMicroteachCaseType.MicroteachCaseTypeName].ToString().Trim(); //微格案例类型名称
objMicroteachCaseTypeEN.Memo = objRow[conMicroteachCaseType.Memo] == DBNull.Value ? null : objRow[conMicroteachCaseType.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objMicroteachCaseTypeEN.IdMicroteachCaseType, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objMicroteachCaseTypeEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrIdMicroteachCaseTypeLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsMicroteachCaseTypeEN> GetObjLstByIdMicroteachCaseTypeLstCache(List<string> arrIdMicroteachCaseTypeLst)
{
string strKey = string.Format("{0}", clsMicroteachCaseTypeEN._CurrTabName);
List<clsMicroteachCaseTypeEN> arrMicroteachCaseTypeObjLstCache = GetObjLstCache();
IEnumerable <clsMicroteachCaseTypeEN> arrMicroteachCaseTypeObjLst_Sel =
arrMicroteachCaseTypeObjLstCache
.Where(x => arrIdMicroteachCaseTypeLst.Contains(x.IdMicroteachCaseType));
return arrMicroteachCaseTypeObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsMicroteachCaseTypeEN> GetObjLst(string strWhereCond)
{
List<clsMicroteachCaseTypeEN> arrObjLst = new List<clsMicroteachCaseTypeEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsMicroteachCaseTypeEN objMicroteachCaseTypeEN = new clsMicroteachCaseTypeEN();
try
{
objMicroteachCaseTypeEN.IdMicroteachCaseType = objRow[conMicroteachCaseType.IdMicroteachCaseType].ToString().Trim(); //微格案例类型流水号
objMicroteachCaseTypeEN.MicroteachCaseTypeID = objRow[conMicroteachCaseType.MicroteachCaseTypeID].ToString().Trim(); //微格案例类型ID
objMicroteachCaseTypeEN.MicroteachCaseTypeName = objRow[conMicroteachCaseType.MicroteachCaseTypeName].ToString().Trim(); //微格案例类型名称
objMicroteachCaseTypeEN.Memo = objRow[conMicroteachCaseType.Memo] == DBNull.Value ? null : objRow[conMicroteachCaseType.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objMicroteachCaseTypeEN.IdMicroteachCaseType, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objMicroteachCaseTypeEN);
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
public static List<clsMicroteachCaseTypeEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsMicroteachCaseTypeEN> arrObjLst = new List<clsMicroteachCaseTypeEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsMicroteachCaseTypeEN objMicroteachCaseTypeEN = new clsMicroteachCaseTypeEN();
try
{
objMicroteachCaseTypeEN.IdMicroteachCaseType = objRow[conMicroteachCaseType.IdMicroteachCaseType].ToString().Trim(); //微格案例类型流水号
objMicroteachCaseTypeEN.MicroteachCaseTypeID = objRow[conMicroteachCaseType.MicroteachCaseTypeID].ToString().Trim(); //微格案例类型ID
objMicroteachCaseTypeEN.MicroteachCaseTypeName = objRow[conMicroteachCaseType.MicroteachCaseTypeName].ToString().Trim(); //微格案例类型名称
objMicroteachCaseTypeEN.Memo = objRow[conMicroteachCaseType.Memo] == DBNull.Value ? null : objRow[conMicroteachCaseType.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objMicroteachCaseTypeEN.IdMicroteachCaseType, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objMicroteachCaseTypeEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objMicroteachCaseTypeCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsMicroteachCaseTypeEN> GetSubObjLstCache(clsMicroteachCaseTypeEN objMicroteachCaseTypeCond)
{
List<clsMicroteachCaseTypeEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsMicroteachCaseTypeEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conMicroteachCaseType.AttributeName)
{
if (objMicroteachCaseTypeCond.IsUpdated(strFldName) == false) continue;
if (objMicroteachCaseTypeCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objMicroteachCaseTypeCond[strFldName].ToString());
}
else
{
if (objMicroteachCaseTypeCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objMicroteachCaseTypeCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objMicroteachCaseTypeCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objMicroteachCaseTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objMicroteachCaseTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objMicroteachCaseTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objMicroteachCaseTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objMicroteachCaseTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objMicroteachCaseTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objMicroteachCaseTypeCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objMicroteachCaseTypeCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objMicroteachCaseTypeCond[strFldName]));
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
public static List<clsMicroteachCaseTypeEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsMicroteachCaseTypeEN> arrObjLst = new List<clsMicroteachCaseTypeEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsMicroteachCaseTypeEN objMicroteachCaseTypeEN = new clsMicroteachCaseTypeEN();
try
{
objMicroteachCaseTypeEN.IdMicroteachCaseType = objRow[conMicroteachCaseType.IdMicroteachCaseType].ToString().Trim(); //微格案例类型流水号
objMicroteachCaseTypeEN.MicroteachCaseTypeID = objRow[conMicroteachCaseType.MicroteachCaseTypeID].ToString().Trim(); //微格案例类型ID
objMicroteachCaseTypeEN.MicroteachCaseTypeName = objRow[conMicroteachCaseType.MicroteachCaseTypeName].ToString().Trim(); //微格案例类型名称
objMicroteachCaseTypeEN.Memo = objRow[conMicroteachCaseType.Memo] == DBNull.Value ? null : objRow[conMicroteachCaseType.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objMicroteachCaseTypeEN.IdMicroteachCaseType, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objMicroteachCaseTypeEN);
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
public static List<clsMicroteachCaseTypeEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsMicroteachCaseTypeEN> arrObjLst = new List<clsMicroteachCaseTypeEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsMicroteachCaseTypeEN objMicroteachCaseTypeEN = new clsMicroteachCaseTypeEN();
try
{
objMicroteachCaseTypeEN.IdMicroteachCaseType = objRow[conMicroteachCaseType.IdMicroteachCaseType].ToString().Trim(); //微格案例类型流水号
objMicroteachCaseTypeEN.MicroteachCaseTypeID = objRow[conMicroteachCaseType.MicroteachCaseTypeID].ToString().Trim(); //微格案例类型ID
objMicroteachCaseTypeEN.MicroteachCaseTypeName = objRow[conMicroteachCaseType.MicroteachCaseTypeName].ToString().Trim(); //微格案例类型名称
objMicroteachCaseTypeEN.Memo = objRow[conMicroteachCaseType.Memo] == DBNull.Value ? null : objRow[conMicroteachCaseType.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objMicroteachCaseTypeEN.IdMicroteachCaseType, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objMicroteachCaseTypeEN);
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
List<clsMicroteachCaseTypeEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsMicroteachCaseTypeEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsMicroteachCaseTypeEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsMicroteachCaseTypeEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsMicroteachCaseTypeEN> arrObjLst = new List<clsMicroteachCaseTypeEN>(); 
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
	clsMicroteachCaseTypeEN objMicroteachCaseTypeEN = new clsMicroteachCaseTypeEN();
try
{
objMicroteachCaseTypeEN.IdMicroteachCaseType = objRow[conMicroteachCaseType.IdMicroteachCaseType].ToString().Trim(); //微格案例类型流水号
objMicroteachCaseTypeEN.MicroteachCaseTypeID = objRow[conMicroteachCaseType.MicroteachCaseTypeID].ToString().Trim(); //微格案例类型ID
objMicroteachCaseTypeEN.MicroteachCaseTypeName = objRow[conMicroteachCaseType.MicroteachCaseTypeName].ToString().Trim(); //微格案例类型名称
objMicroteachCaseTypeEN.Memo = objRow[conMicroteachCaseType.Memo] == DBNull.Value ? null : objRow[conMicroteachCaseType.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objMicroteachCaseTypeEN.IdMicroteachCaseType, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objMicroteachCaseTypeEN);
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
public static List<clsMicroteachCaseTypeEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsMicroteachCaseTypeEN> arrObjLst = new List<clsMicroteachCaseTypeEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsMicroteachCaseTypeEN objMicroteachCaseTypeEN = new clsMicroteachCaseTypeEN();
try
{
objMicroteachCaseTypeEN.IdMicroteachCaseType = objRow[conMicroteachCaseType.IdMicroteachCaseType].ToString().Trim(); //微格案例类型流水号
objMicroteachCaseTypeEN.MicroteachCaseTypeID = objRow[conMicroteachCaseType.MicroteachCaseTypeID].ToString().Trim(); //微格案例类型ID
objMicroteachCaseTypeEN.MicroteachCaseTypeName = objRow[conMicroteachCaseType.MicroteachCaseTypeName].ToString().Trim(); //微格案例类型名称
objMicroteachCaseTypeEN.Memo = objRow[conMicroteachCaseType.Memo] == DBNull.Value ? null : objRow[conMicroteachCaseType.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objMicroteachCaseTypeEN.IdMicroteachCaseType, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objMicroteachCaseTypeEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsMicroteachCaseTypeEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsMicroteachCaseTypeEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsMicroteachCaseTypeEN> arrObjLst = new List<clsMicroteachCaseTypeEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsMicroteachCaseTypeEN objMicroteachCaseTypeEN = new clsMicroteachCaseTypeEN();
try
{
objMicroteachCaseTypeEN.IdMicroteachCaseType = objRow[conMicroteachCaseType.IdMicroteachCaseType].ToString().Trim(); //微格案例类型流水号
objMicroteachCaseTypeEN.MicroteachCaseTypeID = objRow[conMicroteachCaseType.MicroteachCaseTypeID].ToString().Trim(); //微格案例类型ID
objMicroteachCaseTypeEN.MicroteachCaseTypeName = objRow[conMicroteachCaseType.MicroteachCaseTypeName].ToString().Trim(); //微格案例类型名称
objMicroteachCaseTypeEN.Memo = objRow[conMicroteachCaseType.Memo] == DBNull.Value ? null : objRow[conMicroteachCaseType.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objMicroteachCaseTypeEN.IdMicroteachCaseType, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objMicroteachCaseTypeEN);
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
public static List<clsMicroteachCaseTypeEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsMicroteachCaseTypeEN> arrObjLst = new List<clsMicroteachCaseTypeEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsMicroteachCaseTypeEN objMicroteachCaseTypeEN = new clsMicroteachCaseTypeEN();
try
{
objMicroteachCaseTypeEN.IdMicroteachCaseType = objRow[conMicroteachCaseType.IdMicroteachCaseType].ToString().Trim(); //微格案例类型流水号
objMicroteachCaseTypeEN.MicroteachCaseTypeID = objRow[conMicroteachCaseType.MicroteachCaseTypeID].ToString().Trim(); //微格案例类型ID
objMicroteachCaseTypeEN.MicroteachCaseTypeName = objRow[conMicroteachCaseType.MicroteachCaseTypeName].ToString().Trim(); //微格案例类型名称
objMicroteachCaseTypeEN.Memo = objRow[conMicroteachCaseType.Memo] == DBNull.Value ? null : objRow[conMicroteachCaseType.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objMicroteachCaseTypeEN.IdMicroteachCaseType, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objMicroteachCaseTypeEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsMicroteachCaseTypeEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsMicroteachCaseTypeEN> arrObjLst = new List<clsMicroteachCaseTypeEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsMicroteachCaseTypeEN objMicroteachCaseTypeEN = new clsMicroteachCaseTypeEN();
try
{
objMicroteachCaseTypeEN.IdMicroteachCaseType = objRow[conMicroteachCaseType.IdMicroteachCaseType].ToString().Trim(); //微格案例类型流水号
objMicroteachCaseTypeEN.MicroteachCaseTypeID = objRow[conMicroteachCaseType.MicroteachCaseTypeID].ToString().Trim(); //微格案例类型ID
objMicroteachCaseTypeEN.MicroteachCaseTypeName = objRow[conMicroteachCaseType.MicroteachCaseTypeName].ToString().Trim(); //微格案例类型名称
objMicroteachCaseTypeEN.Memo = objRow[conMicroteachCaseType.Memo] == DBNull.Value ? null : objRow[conMicroteachCaseType.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objMicroteachCaseTypeEN.IdMicroteachCaseType, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objMicroteachCaseTypeEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objMicroteachCaseTypeEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetMicroteachCaseType(ref clsMicroteachCaseTypeEN objMicroteachCaseTypeEN)
{
bool bolResult = MicroteachCaseTypeDA.GetMicroteachCaseType(ref objMicroteachCaseTypeEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "strIdMicroteachCaseType">表关键字</param>
 /// <returns>表对象</returns>
public static clsMicroteachCaseTypeEN GetObjByIdMicroteachCaseType(string strIdMicroteachCaseType)
{
if (strIdMicroteachCaseType.IndexOf(' ') >=0)
{
var strMsg = string.Format("(errid:Busi000079)在表中,关键字[strIdMicroteachCaseType]中不能有空格!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
if (string.IsNullOrEmpty(strIdMicroteachCaseType) == true)
{
var strMsg = string.Format("(errid:Busi000020)在表中,关键字[strIdMicroteachCaseType]不能为空!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
clsMicroteachCaseTypeEN objMicroteachCaseTypeEN = MicroteachCaseTypeDA.GetObjByIdMicroteachCaseType(strIdMicroteachCaseType);
return objMicroteachCaseTypeEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsMicroteachCaseTypeEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsMicroteachCaseTypeEN objMicroteachCaseTypeEN = MicroteachCaseTypeDA.GetFirstObj(strWhereCond);
 return objMicroteachCaseTypeEN;
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
public static clsMicroteachCaseTypeEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsMicroteachCaseTypeEN objMicroteachCaseTypeEN = MicroteachCaseTypeDA.GetObjByDataRow(objRow);
 return objMicroteachCaseTypeEN;
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
public static clsMicroteachCaseTypeEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsMicroteachCaseTypeEN objMicroteachCaseTypeEN = MicroteachCaseTypeDA.GetObjByDataRow(objRow);
 return objMicroteachCaseTypeEN;
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
 /// <param name = "strIdMicroteachCaseType">所给的关键字</param>
 /// <param name = "lstMicroteachCaseTypeObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsMicroteachCaseTypeEN GetObjByIdMicroteachCaseTypeFromList(string strIdMicroteachCaseType, List<clsMicroteachCaseTypeEN> lstMicroteachCaseTypeObjLst)
{
foreach (clsMicroteachCaseTypeEN objMicroteachCaseTypeEN in lstMicroteachCaseTypeObjLst)
{
if (objMicroteachCaseTypeEN.IdMicroteachCaseType == strIdMicroteachCaseType)
{
return objMicroteachCaseTypeEN;
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
 string strIdMicroteachCaseType;
 try
 {
 strIdMicroteachCaseType = new clsMicroteachCaseTypeDA().GetFirstID(strWhereCond);
 return strIdMicroteachCaseType;
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
 arrList = MicroteachCaseTypeDA.GetID(strWhereCond);
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
bool bolIsExist = MicroteachCaseTypeDA.IsExistCondRec(strWhereCond);
return bolIsExist;
}

 /// <summary>
 /// 判断当前表中是否存在给定关键字值的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExist)
 /// </summary>
 /// <param name = "strIdMicroteachCaseType">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public static bool IsExist(string strIdMicroteachCaseType)
{
if (string.IsNullOrEmpty(strIdMicroteachCaseType) == true)
{
var strMsg = string.Format("(errid:Busi000027)在表中,关键字[strIdMicroteachCaseType]不能为空!!(from {0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
//检测记录是否存在
bool bolIsExist = MicroteachCaseTypeDA.IsExist(strIdMicroteachCaseType);
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
 bolIsExist = clsMicroteachCaseTypeDA.IsExistTable();
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
 bolIsExist = MicroteachCaseTypeDA.IsExistTable(strTabName);
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
 /// <param name = "objMicroteachCaseTypeEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecordBySql2(clsMicroteachCaseTypeEN objMicroteachCaseTypeEN)
{
 if (string.IsNullOrEmpty(objMicroteachCaseTypeEN.IdMicroteachCaseType) == true)
 {
string strMsg = string.Format("添加记录时,关键字不能为空!(from {0})\r\n", 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
 if (clsMicroteachCaseTypeBL.IsExist(objMicroteachCaseTypeEN.IdMicroteachCaseType) == true)
 {
string strMsg = string.Format("添加记录时,关键字:[{0}]已经存在!(from {1})\r\n", objMicroteachCaseTypeEN.IdMicroteachCaseType, 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
try
{
bool bolResult = MicroteachCaseTypeDA.AddNewRecordBySQL2(objMicroteachCaseTypeEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsMicroteachCaseTypeBL.ReFreshCache();

if (clsMicroteachCaseTypeBL.relatedActions != null)
{
clsMicroteachCaseTypeBL.relatedActions.UpdRelaTabDate(objMicroteachCaseTypeEN.IdMicroteachCaseType, "SetUpdDate");
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
 /// <param name = "objMicroteachCaseTypeEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordBySql2WithReturnKey(clsMicroteachCaseTypeEN objMicroteachCaseTypeEN)
{
 if (string.IsNullOrEmpty(objMicroteachCaseTypeEN.IdMicroteachCaseType) == true)
 {
string strMsg = string.Format("添加记录时,关键字不能为空!(from {{0}})", 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
 if (clsMicroteachCaseTypeBL.IsExist(objMicroteachCaseTypeEN.IdMicroteachCaseType) == true)
 {
string strMsg = string.Format("添加记录时,关键字:[{0}]已经存在!(from {1})\r\n", objMicroteachCaseTypeEN.IdMicroteachCaseType, 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
try
{
string strKey = MicroteachCaseTypeDA.AddNewRecordBySQL2WithReturnKey(objMicroteachCaseTypeEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsMicroteachCaseTypeBL.ReFreshCache();

if (clsMicroteachCaseTypeBL.relatedActions != null)
{
clsMicroteachCaseTypeBL.relatedActions.UpdRelaTabDate(objMicroteachCaseTypeEN.IdMicroteachCaseType, "SetUpdDate");
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
 /// <param name = "objMicroteachCaseTypeEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(clsMicroteachCaseTypeEN objMicroteachCaseTypeEN)
{
try
{
bool bolResult = MicroteachCaseTypeDA.Update(objMicroteachCaseTypeEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsMicroteachCaseTypeBL.ReFreshCache();

if (clsMicroteachCaseTypeBL.relatedActions != null)
{
clsMicroteachCaseTypeBL.relatedActions.UpdRelaTabDate(objMicroteachCaseTypeEN.IdMicroteachCaseType, "SetUpdDate");
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
 /// <param name = "objMicroteachCaseTypeEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateBySql2(clsMicroteachCaseTypeEN objMicroteachCaseTypeEN)
{
 if (string.IsNullOrEmpty(objMicroteachCaseTypeEN.IdMicroteachCaseType) == true)
 {
var strMsg = string.Format("(errid:Busi000065)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = MicroteachCaseTypeDA.UpdateBySql2(objMicroteachCaseTypeEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsMicroteachCaseTypeBL.ReFreshCache();

if (clsMicroteachCaseTypeBL.relatedActions != null)
{
clsMicroteachCaseTypeBL.relatedActions.UpdRelaTabDate(objMicroteachCaseTypeEN.IdMicroteachCaseType, "SetUpdDate");
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
 /// <param name = "strIdMicroteachCaseType">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int DelRecord(string strIdMicroteachCaseType)
{
try
{
 clsMicroteachCaseTypeEN objMicroteachCaseTypeEN = clsMicroteachCaseTypeBL.GetObjByIdMicroteachCaseType(strIdMicroteachCaseType);

if (clsMicroteachCaseTypeBL.relatedActions != null)
{
clsMicroteachCaseTypeBL.relatedActions.UpdRelaTabDate(objMicroteachCaseTypeEN.IdMicroteachCaseType, "SetUpdDate");
}
if (objMicroteachCaseTypeEN != null)
{
int intRecNum = MicroteachCaseTypeDA.DelRecord(strIdMicroteachCaseType);
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
/// <param name="strIdMicroteachCaseType">表关键字</param>
/// <returns></returns>
public static bool DelRecordEx(string strIdMicroteachCaseType )
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsMicroteachCaseTypeDA.GetSpecSQLObj();
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
//删除与表:[MicroteachCaseType]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conMicroteachCaseType.IdMicroteachCaseType,
//strIdMicroteachCaseType);
//        clsMicroteachCaseTypeBL.DelMicroteachCaseTypesByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsMicroteachCaseTypeBL.DelRecord(strIdMicroteachCaseType, objConnection, objSqlTransaction);
objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsMicroteachCaseTypeBLEx", "DelRecordEx", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("扩展删除记录出错:{0}!keyId = {1}.({2})",
objException.Message,
strIdMicroteachCaseType, clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "strIdMicroteachCaseType">给定的关键字值</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回删除是否成功?</returns>
public static bool DelRecord(string strIdMicroteachCaseType, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
if (clsMicroteachCaseTypeBL.relatedActions != null)
{
clsMicroteachCaseTypeBL.relatedActions.UpdRelaTabDate(strIdMicroteachCaseType, "UpdRelaTabDate");
}
bool bolResult = MicroteachCaseTypeDA.DelRecord(strIdMicroteachCaseType,objSqlConnection,objSqlTransaction);
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
 /// <param name = "arrIdMicroteachCaseTypeLst">给定的关键字值列表</param>
 /// <returns>返回删除的记录数</returns>
public static int DelMicroteachCaseTypes(List<string> arrIdMicroteachCaseTypeLst)
{
if (arrIdMicroteachCaseTypeLst.Count == 0) return 0;
try
{
if (clsMicroteachCaseTypeBL.relatedActions != null)
{
foreach (var strIdMicroteachCaseType in arrIdMicroteachCaseTypeLst)
{
clsMicroteachCaseTypeBL.relatedActions.UpdRelaTabDate(strIdMicroteachCaseType, "UpdRelaTabDate");
}
}
int intDelRecNum = MicroteachCaseTypeDA.DelMicroteachCaseType(arrIdMicroteachCaseTypeLst);
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
public static int DelMicroteachCaseTypesByCond(string strWhereCond)
{
try
{
if (clsMicroteachCaseTypeBL.relatedActions != null)
{
List<string> arrIdMicroteachCaseType = GetPrimaryKeyID_S(strWhereCond);
foreach (var strIdMicroteachCaseType in arrIdMicroteachCaseType)
{
clsMicroteachCaseTypeBL.relatedActions.UpdRelaTabDate(strIdMicroteachCaseType, "UpdRelaTabDate");
}
}
int intRecNum = MicroteachCaseTypeDA.DelMicroteachCaseType(strWhereCond);
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
/// 这里仅仅是演示函数,使用时请复制到扩展类:[MicroteachCaseType]中改名为:[DelRecord4MultiTabEx]使用
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DelRecord4MultiTab)
/// </summary>
/// <param name="strIdMicroteachCaseType">表关键字</param>
/// <returns></returns>
public static bool DelRecord4MultiTab(string strIdMicroteachCaseType)
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsMicroteachCaseTypeDA.GetSpecSQLObj();
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
//删除与表:[MicroteachCaseType]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conStudent.id_College,
//strid_College);
//        clsStudentBL.DelStudentsByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsMicroteachCaseTypeBL.DelRecord(strIdMicroteachCaseType, objConnection, objSqlTransaction);
                objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsMicroteachCaseTypeBL", "DelRecord4MultiTab", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("删除多表记录出错:{0}!keyId = {1}.({2})",
objException.Message,
strIdMicroteachCaseType, clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "objMicroteachCaseTypeENS">源对象</param>
 /// <param name = "objMicroteachCaseTypeENT">目标对象</param>
 public static void CopyTo(clsMicroteachCaseTypeEN objMicroteachCaseTypeENS, clsMicroteachCaseTypeEN objMicroteachCaseTypeENT)
{
try
{
objMicroteachCaseTypeENT.IdMicroteachCaseType = objMicroteachCaseTypeENS.IdMicroteachCaseType; //微格案例类型流水号
objMicroteachCaseTypeENT.MicroteachCaseTypeID = objMicroteachCaseTypeENS.MicroteachCaseTypeID; //微格案例类型ID
objMicroteachCaseTypeENT.MicroteachCaseTypeName = objMicroteachCaseTypeENS.MicroteachCaseTypeName; //微格案例类型名称
objMicroteachCaseTypeENT.Memo = objMicroteachCaseTypeENS.Memo; //备注
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
 /// <param name = "objMicroteachCaseTypeEN">源简化对象</param>
 public static void SetUpdFlag(clsMicroteachCaseTypeEN objMicroteachCaseTypeEN)
{
try
{
objMicroteachCaseTypeEN.ClearUpdateState();
   string strsfUpdFldSetStr = objMicroteachCaseTypeEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(conMicroteachCaseType.IdMicroteachCaseType, new clsStrCompareIgnoreCase())  ==  true)
{
objMicroteachCaseTypeEN.IdMicroteachCaseType = objMicroteachCaseTypeEN.IdMicroteachCaseType; //微格案例类型流水号
}
if (arrFldSet.Contains(conMicroteachCaseType.MicroteachCaseTypeID, new clsStrCompareIgnoreCase())  ==  true)
{
objMicroteachCaseTypeEN.MicroteachCaseTypeID = objMicroteachCaseTypeEN.MicroteachCaseTypeID; //微格案例类型ID
}
if (arrFldSet.Contains(conMicroteachCaseType.MicroteachCaseTypeName, new clsStrCompareIgnoreCase())  ==  true)
{
objMicroteachCaseTypeEN.MicroteachCaseTypeName = objMicroteachCaseTypeEN.MicroteachCaseTypeName; //微格案例类型名称
}
if (arrFldSet.Contains(conMicroteachCaseType.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objMicroteachCaseTypeEN.Memo = objMicroteachCaseTypeEN.Memo == "[null]" ? null :  objMicroteachCaseTypeEN.Memo; //备注
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
 /// <param name = "objMicroteachCaseTypeEN">源简化对象</param>
 public static void AccessFldValueNull(clsMicroteachCaseTypeEN objMicroteachCaseTypeEN)
{
try
{
if (objMicroteachCaseTypeEN.Memo == "[null]") objMicroteachCaseTypeEN.Memo = null; //备注
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
public static void CheckPropertyNew(clsMicroteachCaseTypeEN objMicroteachCaseTypeEN)
{
 MicroteachCaseTypeDA.CheckPropertyNew(objMicroteachCaseTypeEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(clsMicroteachCaseTypeEN objMicroteachCaseTypeEN)
{
 MicroteachCaseTypeDA.CheckProperty4Condition(objMicroteachCaseTypeEN);
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
if (clsMicroteachCaseTypeBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsMicroteachCaseTypeBL没有刷新缓存机制(clsMicroteachCaseTypeBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by IdMicroteachCaseType");
//if (arrMicroteachCaseTypeObjLstCache == null)
//{
//arrMicroteachCaseTypeObjLstCache = MicroteachCaseTypeDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "strIdMicroteachCaseType">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsMicroteachCaseTypeEN GetObjByIdMicroteachCaseTypeCache(string strIdMicroteachCaseType)
{
//获取缓存中的对象列表
string strKey = string.Format("{0}", clsMicroteachCaseTypeEN._CurrTabName);
List<clsMicroteachCaseTypeEN> arrMicroteachCaseTypeObjLstCache = GetObjLstCache();
IEnumerable <clsMicroteachCaseTypeEN> arrMicroteachCaseTypeObjLst_Sel =
arrMicroteachCaseTypeObjLstCache
.Where(x=> x.IdMicroteachCaseType == strIdMicroteachCaseType 
);
if (arrMicroteachCaseTypeObjLst_Sel.Count() == 0)
{
   clsMicroteachCaseTypeEN obj = clsMicroteachCaseTypeBL.GetObjByIdMicroteachCaseType(strIdMicroteachCaseType);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
 }
return null;
}
return arrMicroteachCaseTypeObjLst_Sel.First();
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsMicroteachCaseTypeEN> GetAllMicroteachCaseTypeObjLstCache()
{
//获取缓存中的对象列表
List<clsMicroteachCaseTypeEN> arrMicroteachCaseTypeObjLstCache = GetObjLstCache(); 
return arrMicroteachCaseTypeObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsMicroteachCaseTypeEN> GetObjLstCache()
{
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}", clsMicroteachCaseTypeEN._CurrTabName);
List<clsMicroteachCaseTypeEN> arrMicroteachCaseTypeObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrMicroteachCaseTypeObjLstCache;
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
string strKey = string.Format("{0}", clsMicroteachCaseTypeEN._CurrTabName);
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
if (clsMicroteachCaseTypeBL.objCommFun4BL != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}", clsMicroteachCaseTypeEN._CurrTabName);
CacheHelper.Remove(strKey);
clsMicroteachCaseTypeBL.objCommFun4BL.ReFreshCache();
}
}


 #endregion 缓存操作


 #region 检查唯一性


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
public static string Func(string strInFldName, string strOutFldName, string strIdMicroteachCaseType)
{
if (strInFldName != conMicroteachCaseType.IdMicroteachCaseType)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (conMicroteachCaseType.AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", conMicroteachCaseType.AttributeName));
throw new Exception(strMsg);
}
var objMicroteachCaseType = clsMicroteachCaseTypeBL.GetObjByIdMicroteachCaseTypeCache(strIdMicroteachCaseType);
if (objMicroteachCaseType == null) return "";
return objMicroteachCaseType[strOutFldName].ToString();
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
int intRecCount = clsMicroteachCaseTypeDA.GetRecCount(strTabName);
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
int intRecCount = clsMicroteachCaseTypeDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsMicroteachCaseTypeDA.GetRecCount();
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
int intRecCount = clsMicroteachCaseTypeDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objMicroteachCaseTypeCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsMicroteachCaseTypeEN objMicroteachCaseTypeCond)
{
List<clsMicroteachCaseTypeEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsMicroteachCaseTypeEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conMicroteachCaseType.AttributeName)
{
if (objMicroteachCaseTypeCond.IsUpdated(strFldName) == false) continue;
if (objMicroteachCaseTypeCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objMicroteachCaseTypeCond[strFldName].ToString());
}
else
{
if (objMicroteachCaseTypeCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objMicroteachCaseTypeCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objMicroteachCaseTypeCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objMicroteachCaseTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objMicroteachCaseTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objMicroteachCaseTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objMicroteachCaseTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objMicroteachCaseTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objMicroteachCaseTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objMicroteachCaseTypeCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objMicroteachCaseTypeCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objMicroteachCaseTypeCond[strFldName]));
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
 List<string> arrList = clsMicroteachCaseTypeDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = MicroteachCaseTypeDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = MicroteachCaseTypeDA.GetFldValueNoDistinct(strFldName, strWhereCond);
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
int intRecCount = MicroteachCaseTypeDA.SetFldValue(strFldName, strValue, strWhereCond);
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
int intRecCount = clsMicroteachCaseTypeDA.SetFldValue(clsMicroteachCaseTypeEN._CurrTabName, strFldName, fltValue, strWhereCond);
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
int intRecCount = MicroteachCaseTypeDA.SetFldValue( strFldName, intValue, strWhereCond);
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
int intRecCount = clsMicroteachCaseTypeDA.SetFldValue(strTabName, strFldName, strValue, strWhereCond);
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
int intRecCount = clsMicroteachCaseTypeDA.SetFldValue(strTabName, strFldName, intValue, strWhereCond);
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
int intRecCount = clsMicroteachCaseTypeDA.SetFldValue(strTabName, strFldName, fltValue, strWhereCond);
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
  strCreateTabCode.Append("CREATE table [dbo].[MicroteachCaseType] "); 
 strCreateTabCode.Append(" ( "); 
 // /**微格案例类型流水号*/ 
 strCreateTabCode.Append(" IdMicroteachCaseType char(4) primary key, "); 
 // /**微格案例类型ID*/ 
 strCreateTabCode.Append(" MicroteachCaseTypeID char(4) not Null, "); 
 // /**微格案例类型名称*/ 
 strCreateTabCode.Append(" MicroteachCaseTypeName varchar(50) not Null, "); 
 // /**备注*/ 
 strCreateTabCode.Append(" Memo varchar(1000) Null ");
 strCreateTabCode.Append(") "); 
  strCreateTabCode.Append("ON [PRIMARY] ");
  return strCreateTabCode.ToString();
}



 #endregion 表操作
}
 /// <summary>
 /// 微格案例类型(MicroteachCaseType)
 /// 数据源类型:表
 /// (AutoGCLib.CommFun4BL4CSharp:GeneCode_This)
 /// </summary>
public class  clsCommFun4BL4MicroteachCaseType : clsCommFun4BL
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
clsMicroteachCaseTypeBL.ReFreshThisCache();
}
}

}