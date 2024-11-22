
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsAppraiseTypeBL
 表名:AppraiseType(01120307)
 * 版本:2024.11.13.1(服务器:WIN-SRV103-116)
 日期:2024/11/13 06:19:23
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:研究生学习游戏化后台(000055, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:微格教学评议(MicroTeachSenate)
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
public static class  clsAppraiseTypeBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "strIdAppraiseType">表关键字</param>
 /// <returns>表对象</returns>
public static clsAppraiseTypeEN GetObj(this K_IdAppraiseType_AppraiseType myKey)
{
clsAppraiseTypeEN objAppraiseTypeEN = clsAppraiseTypeBL.AppraiseTypeDA.GetObjByIdAppraiseType(myKey.Value);
return objAppraiseTypeEN;
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_AddNewRecord)
 /// </summary>
 /// <param name = "objAppraiseTypeEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clsAppraiseTypeEN objAppraiseTypeEN, bool bolIsNeedCheckUniqueness = true)
{
 if (string.IsNullOrEmpty(objAppraiseTypeEN.IdAppraiseType) == true)
 {
string strMsg = string.Format("添加记录时,关键字不能为空!(from {0})\r\n", 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
 if (clsAppraiseTypeBL.IsExist(objAppraiseTypeEN.IdAppraiseType) == true)
 {
string strMsg = string.Format("添加记录时,关键字:[{0}]已经存在!(from {1})\r\n", objAppraiseTypeEN.IdAppraiseType, 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
try
{
bool bolResult = clsAppraiseTypeBL.AppraiseTypeDA.AddNewRecordBySQL2(objAppraiseTypeEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsAppraiseTypeBL.ReFreshCache();

if (clsAppraiseTypeBL.relatedActions != null)
{
clsAppraiseTypeBL.relatedActions.UpdRelaTabDate(objAppraiseTypeEN.IdAppraiseType, "SetUpdDate");
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
public static bool AddRecordEx(this clsAppraiseTypeEN objAppraiseTypeEN, bool bolIsNeedCheckUniqueness = true)
{
//操作步骤:
//1、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在
//2、检查唯一性
//3、检查传进去的对象属性是否合法
//4、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
//1、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在
if (clsAppraiseTypeBL.IsExist(objAppraiseTypeEN.IdAppraiseType))	//判断是否有相同的关键字
{
strMsg = "(errid:Busi000151)关键字字段已有相同的值";
throw new Exception(strMsg);
}
try
{
 //2、检查传进去的对象属性是否合法
objAppraiseTypeEN.CheckPropertyNew();
//6、把数据实体层的数据存贮到数据库中
objAppraiseTypeEN.AddNewRecord();
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
 /// <param name = "objAppraiseTypeEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordWithReturnKey(this clsAppraiseTypeEN objAppraiseTypeEN, bool bolIsNeedCheckUniqueness = true)
{
 if (string.IsNullOrEmpty(objAppraiseTypeEN.IdAppraiseType) == true)
 {
string strMsg = string.Format("添加记录时,关键字不能为空!(from {{0}})", 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
 if (clsAppraiseTypeBL.IsExist(objAppraiseTypeEN.IdAppraiseType) == true)
 {
string strMsg = string.Format("添加记录时,关键字:[{0}]已经存在!(from {1})\r\n", objAppraiseTypeEN.IdAppraiseType, 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
try
{
string strKey = clsAppraiseTypeBL.AppraiseTypeDA.AddNewRecordBySQL2WithReturnKey(objAppraiseTypeEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsAppraiseTypeBL.ReFreshCache();

if (clsAppraiseTypeBL.relatedActions != null)
{
clsAppraiseTypeBL.relatedActions.UpdRelaTabDate(objAppraiseTypeEN.IdAppraiseType, "SetUpdDate");
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
 /// <param name = "objAppraiseTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsAppraiseTypeEN SetIdAppraiseType(this clsAppraiseTypeEN objAppraiseTypeEN, string strIdAppraiseType, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdAppraiseType, 4, conAppraiseType.IdAppraiseType);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdAppraiseType, 4, conAppraiseType.IdAppraiseType);
}
objAppraiseTypeEN.IdAppraiseType = strIdAppraiseType; //评议类型流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objAppraiseTypeEN.dicFldComparisonOp.ContainsKey(conAppraiseType.IdAppraiseType) == false)
{
objAppraiseTypeEN.dicFldComparisonOp.Add(conAppraiseType.IdAppraiseType, strComparisonOp);
}
else
{
objAppraiseTypeEN.dicFldComparisonOp[conAppraiseType.IdAppraiseType] = strComparisonOp;
}
}
return objAppraiseTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objAppraiseTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsAppraiseTypeEN SetAppraiseTypeID(this clsAppraiseTypeEN objAppraiseTypeEN, string strAppraiseTypeID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strAppraiseTypeID, conAppraiseType.AppraiseTypeID);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strAppraiseTypeID, 4, conAppraiseType.AppraiseTypeID);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strAppraiseTypeID, 4, conAppraiseType.AppraiseTypeID);
}
objAppraiseTypeEN.AppraiseTypeID = strAppraiseTypeID; //评议类型ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objAppraiseTypeEN.dicFldComparisonOp.ContainsKey(conAppraiseType.AppraiseTypeID) == false)
{
objAppraiseTypeEN.dicFldComparisonOp.Add(conAppraiseType.AppraiseTypeID, strComparisonOp);
}
else
{
objAppraiseTypeEN.dicFldComparisonOp[conAppraiseType.AppraiseTypeID] = strComparisonOp;
}
}
return objAppraiseTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objAppraiseTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsAppraiseTypeEN SetAppraiseTypeName(this clsAppraiseTypeEN objAppraiseTypeEN, string strAppraiseTypeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strAppraiseTypeName, conAppraiseType.AppraiseTypeName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strAppraiseTypeName, 50, conAppraiseType.AppraiseTypeName);
}
objAppraiseTypeEN.AppraiseTypeName = strAppraiseTypeName; //评议类型名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objAppraiseTypeEN.dicFldComparisonOp.ContainsKey(conAppraiseType.AppraiseTypeName) == false)
{
objAppraiseTypeEN.dicFldComparisonOp.Add(conAppraiseType.AppraiseTypeName, strComparisonOp);
}
else
{
objAppraiseTypeEN.dicFldComparisonOp[conAppraiseType.AppraiseTypeName] = strComparisonOp;
}
}
return objAppraiseTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objAppraiseTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsAppraiseTypeEN SetAppraiseTypeName4CW(this clsAppraiseTypeEN objAppraiseTypeEN, string strAppraiseTypeName4CW, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strAppraiseTypeName4CW, 50, conAppraiseType.AppraiseTypeName4CW);
}
objAppraiseTypeEN.AppraiseTypeName4CW = strAppraiseTypeName4CW; //评议类型名称4课件
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objAppraiseTypeEN.dicFldComparisonOp.ContainsKey(conAppraiseType.AppraiseTypeName4CW) == false)
{
objAppraiseTypeEN.dicFldComparisonOp.Add(conAppraiseType.AppraiseTypeName4CW, strComparisonOp);
}
else
{
objAppraiseTypeEN.dicFldComparisonOp[conAppraiseType.AppraiseTypeName4CW] = strComparisonOp;
}
}
return objAppraiseTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objAppraiseTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsAppraiseTypeEN SetUserTypeId(this clsAppraiseTypeEN objAppraiseTypeEN, string strUserTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strUserTypeId, conAppraiseType.UserTypeId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUserTypeId, 2, conAppraiseType.UserTypeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strUserTypeId, 2, conAppraiseType.UserTypeId);
}
objAppraiseTypeEN.UserTypeId = strUserTypeId; //用户类型Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objAppraiseTypeEN.dicFldComparisonOp.ContainsKey(conAppraiseType.UserTypeId) == false)
{
objAppraiseTypeEN.dicFldComparisonOp.Add(conAppraiseType.UserTypeId, strComparisonOp);
}
else
{
objAppraiseTypeEN.dicFldComparisonOp[conAppraiseType.UserTypeId] = strComparisonOp;
}
}
return objAppraiseTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objAppraiseTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsAppraiseTypeEN SetMemo(this clsAppraiseTypeEN objAppraiseTypeEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, conAppraiseType.Memo);
}
objAppraiseTypeEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objAppraiseTypeEN.dicFldComparisonOp.ContainsKey(conAppraiseType.Memo) == false)
{
objAppraiseTypeEN.dicFldComparisonOp.Add(conAppraiseType.Memo, strComparisonOp);
}
else
{
objAppraiseTypeEN.dicFldComparisonOp[conAppraiseType.Memo] = strComparisonOp;
}
}
return objAppraiseTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objAppraiseTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsAppraiseTypeEN SetAppraiseTypeNameSim(this clsAppraiseTypeEN objAppraiseTypeEN, string strAppraiseTypeNameSim, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strAppraiseTypeNameSim, 20, conAppraiseType.AppraiseTypeNameSim);
}
objAppraiseTypeEN.AppraiseTypeNameSim = strAppraiseTypeNameSim; //评议类型名称_Sim
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objAppraiseTypeEN.dicFldComparisonOp.ContainsKey(conAppraiseType.AppraiseTypeNameSim) == false)
{
objAppraiseTypeEN.dicFldComparisonOp.Add(conAppraiseType.AppraiseTypeNameSim, strComparisonOp);
}
else
{
objAppraiseTypeEN.dicFldComparisonOp[conAppraiseType.AppraiseTypeNameSim] = strComparisonOp;
}
}
return objAppraiseTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objAppraiseTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsAppraiseTypeEN SetOrderNum(this clsAppraiseTypeEN objAppraiseTypeEN, int? intOrderNum, string strComparisonOp="")
	{
objAppraiseTypeEN.OrderNum = intOrderNum; //序号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objAppraiseTypeEN.dicFldComparisonOp.ContainsKey(conAppraiseType.OrderNum) == false)
{
objAppraiseTypeEN.dicFldComparisonOp.Add(conAppraiseType.OrderNum, strComparisonOp);
}
else
{
objAppraiseTypeEN.dicFldComparisonOp[conAppraiseType.OrderNum] = strComparisonOp;
}
}
return objAppraiseTypeEN;
	}

 /// <summary>
 /// 修改记录存盘到数据表中
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_UpdateRecordEx)
 /// </summary>
 /// <param name = "objAppraiseTypeEN">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool UpdateRecordEx(this clsAppraiseTypeEN objAppraiseTypeEN)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
try
{
//1、检查传进去的对象属性是否合法
objAppraiseTypeEN.CheckPropertyNew();
clsAppraiseTypeEN objAppraiseTypeCond = new clsAppraiseTypeEN();
string strCondition = objAppraiseTypeCond
.SetIdAppraiseType(objAppraiseTypeEN.IdAppraiseType, "=")
.GetCombineCondition();
objAppraiseTypeEN._IsCheckProperty = true;
bool bolIsExist = clsAppraiseTypeBL.IsExistRecord(strCondition);
if (bolIsExist)
{
strMsg = "()不能重复!";
throw new Exception(strMsg);
}
//4、把数据实体层的数据存贮到数据库中
objAppraiseTypeEN.Update();
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
 /// <param name = "objAppraiseTypeEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsAppraiseTypeEN objAppraiseTypeEN)
{
 if (string.IsNullOrEmpty(objAppraiseTypeEN.IdAppraiseType) == true)
 {
string strMsg = string.Format("(errid:Busi000095)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsAppraiseTypeBL.AppraiseTypeDA.UpdateBySql2(objAppraiseTypeEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsAppraiseTypeBL.ReFreshCache();

if (clsAppraiseTypeBL.relatedActions != null)
{
clsAppraiseTypeBL.relatedActions.UpdRelaTabDate(objAppraiseTypeEN.IdAppraiseType, "SetUpdDate");
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
 /// <param name = "objAppraiseTypeEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsAppraiseTypeEN objAppraiseTypeEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (string.IsNullOrEmpty(objAppraiseTypeEN.IdAppraiseType) == true)
 {
string strMsg = string.Format("(errid:Busi000087)修改记录时关键字不能为空!(带事务处理)(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsAppraiseTypeBL.AppraiseTypeDA.UpdateBySql2(objAppraiseTypeEN, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsAppraiseTypeBL.ReFreshCache();

if (clsAppraiseTypeBL.relatedActions != null)
{
clsAppraiseTypeBL.relatedActions.UpdRelaTabDate(objAppraiseTypeEN.IdAppraiseType, "SetUpdDate");
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
 /// <param name = "objAppraiseTypeEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsAppraiseTypeEN objAppraiseTypeEN, string strWhereCond)
{
try
{
bool bolResult = clsAppraiseTypeBL.AppraiseTypeDA.UpdateBySqlWithCondition(objAppraiseTypeEN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsAppraiseTypeBL.ReFreshCache();

if (clsAppraiseTypeBL.relatedActions != null)
{
clsAppraiseTypeBL.relatedActions.UpdRelaTabDate(objAppraiseTypeEN.IdAppraiseType, "SetUpdDate");
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
 /// <param name = "objAppraiseTypeEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsAppraiseTypeEN objAppraiseTypeEN, string strWhereCond, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
bool bolResult = clsAppraiseTypeBL.AppraiseTypeDA.UpdateBySqlWithConditionTransaction(objAppraiseTypeEN, strWhereCond, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsAppraiseTypeBL.ReFreshCache();

if (clsAppraiseTypeBL.relatedActions != null)
{
clsAppraiseTypeBL.relatedActions.UpdRelaTabDate(objAppraiseTypeEN.IdAppraiseType, "SetUpdDate");
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
 /// <param name = "strIdAppraiseType">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int Delete(this clsAppraiseTypeEN objAppraiseTypeEN)
{
try
{
int intRecNum = clsAppraiseTypeBL.AppraiseTypeDA.DelRecord(objAppraiseTypeEN.IdAppraiseType);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsAppraiseTypeBL.ReFreshCache();

if (clsAppraiseTypeBL.relatedActions != null)
{
clsAppraiseTypeBL.relatedActions.UpdRelaTabDate(objAppraiseTypeEN.IdAppraiseType, "SetUpdDate");
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
 /// <param name = "objAppraiseTypeENS">源对象</param>
 /// <param name = "objAppraiseTypeENT">目标对象</param>
 public static void CopyTo(this clsAppraiseTypeEN objAppraiseTypeENS, clsAppraiseTypeEN objAppraiseTypeENT)
{
try
{
objAppraiseTypeENT.IdAppraiseType = objAppraiseTypeENS.IdAppraiseType; //评议类型流水号
objAppraiseTypeENT.AppraiseTypeID = objAppraiseTypeENS.AppraiseTypeID; //评议类型ID
objAppraiseTypeENT.AppraiseTypeName = objAppraiseTypeENS.AppraiseTypeName; //评议类型名称
objAppraiseTypeENT.AppraiseTypeName4CW = objAppraiseTypeENS.AppraiseTypeName4CW; //评议类型名称4课件
objAppraiseTypeENT.UserTypeId = objAppraiseTypeENS.UserTypeId; //用户类型Id
objAppraiseTypeENT.Memo = objAppraiseTypeENS.Memo; //备注
objAppraiseTypeENT.AppraiseTypeNameSim = objAppraiseTypeENS.AppraiseTypeNameSim; //评议类型名称_Sim
objAppraiseTypeENT.OrderNum = objAppraiseTypeENS.OrderNum; //序号
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
 /// <param name = "objAppraiseTypeENS">源对象</param>
 /// <returns>目标对象=>clsAppraiseTypeEN:objAppraiseTypeENT</returns>
 public static clsAppraiseTypeEN CopyTo(this clsAppraiseTypeEN objAppraiseTypeENS)
{
try
{
 clsAppraiseTypeEN objAppraiseTypeENT = new clsAppraiseTypeEN()
{
IdAppraiseType = objAppraiseTypeENS.IdAppraiseType, //评议类型流水号
AppraiseTypeID = objAppraiseTypeENS.AppraiseTypeID, //评议类型ID
AppraiseTypeName = objAppraiseTypeENS.AppraiseTypeName, //评议类型名称
AppraiseTypeName4CW = objAppraiseTypeENS.AppraiseTypeName4CW, //评议类型名称4课件
UserTypeId = objAppraiseTypeENS.UserTypeId, //用户类型Id
Memo = objAppraiseTypeENS.Memo, //备注
AppraiseTypeNameSim = objAppraiseTypeENS.AppraiseTypeNameSim, //评议类型名称_Sim
OrderNum = objAppraiseTypeENS.OrderNum, //序号
};
 return objAppraiseTypeENT;
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
public static void CheckPropertyNew(this clsAppraiseTypeEN objAppraiseTypeEN)
{
 clsAppraiseTypeBL.AppraiseTypeDA.CheckPropertyNew(objAppraiseTypeEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(this clsAppraiseTypeEN objAppraiseTypeEN)
{
 clsAppraiseTypeBL.AppraiseTypeDA.CheckProperty4Condition(objAppraiseTypeEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsAppraiseTypeEN objAppraiseTypeCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objAppraiseTypeCond.IsUpdated(conAppraiseType.IdAppraiseType) == true)
{
string strComparisonOpIdAppraiseType = objAppraiseTypeCond.dicFldComparisonOp[conAppraiseType.IdAppraiseType];
strWhereCond += string.Format(" And {0} {2} '{1}'", conAppraiseType.IdAppraiseType, objAppraiseTypeCond.IdAppraiseType, strComparisonOpIdAppraiseType);
}
if (objAppraiseTypeCond.IsUpdated(conAppraiseType.AppraiseTypeID) == true)
{
string strComparisonOpAppraiseTypeID = objAppraiseTypeCond.dicFldComparisonOp[conAppraiseType.AppraiseTypeID];
strWhereCond += string.Format(" And {0} {2} '{1}'", conAppraiseType.AppraiseTypeID, objAppraiseTypeCond.AppraiseTypeID, strComparisonOpAppraiseTypeID);
}
if (objAppraiseTypeCond.IsUpdated(conAppraiseType.AppraiseTypeName) == true)
{
string strComparisonOpAppraiseTypeName = objAppraiseTypeCond.dicFldComparisonOp[conAppraiseType.AppraiseTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", conAppraiseType.AppraiseTypeName, objAppraiseTypeCond.AppraiseTypeName, strComparisonOpAppraiseTypeName);
}
if (objAppraiseTypeCond.IsUpdated(conAppraiseType.AppraiseTypeName4CW) == true)
{
string strComparisonOpAppraiseTypeName4CW = objAppraiseTypeCond.dicFldComparisonOp[conAppraiseType.AppraiseTypeName4CW];
strWhereCond += string.Format(" And {0} {2} '{1}'", conAppraiseType.AppraiseTypeName4CW, objAppraiseTypeCond.AppraiseTypeName4CW, strComparisonOpAppraiseTypeName4CW);
}
if (objAppraiseTypeCond.IsUpdated(conAppraiseType.UserTypeId) == true)
{
string strComparisonOpUserTypeId = objAppraiseTypeCond.dicFldComparisonOp[conAppraiseType.UserTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conAppraiseType.UserTypeId, objAppraiseTypeCond.UserTypeId, strComparisonOpUserTypeId);
}
if (objAppraiseTypeCond.IsUpdated(conAppraiseType.Memo) == true)
{
string strComparisonOpMemo = objAppraiseTypeCond.dicFldComparisonOp[conAppraiseType.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", conAppraiseType.Memo, objAppraiseTypeCond.Memo, strComparisonOpMemo);
}
if (objAppraiseTypeCond.IsUpdated(conAppraiseType.AppraiseTypeNameSim) == true)
{
string strComparisonOpAppraiseTypeNameSim = objAppraiseTypeCond.dicFldComparisonOp[conAppraiseType.AppraiseTypeNameSim];
strWhereCond += string.Format(" And {0} {2} '{1}'", conAppraiseType.AppraiseTypeNameSim, objAppraiseTypeCond.AppraiseTypeNameSim, strComparisonOpAppraiseTypeNameSim);
}
if (objAppraiseTypeCond.IsUpdated(conAppraiseType.OrderNum) == true)
{
string strComparisonOpOrderNum = objAppraiseTypeCond.dicFldComparisonOp[conAppraiseType.OrderNum];
strWhereCond += string.Format(" And {0} {2} {1}", conAppraiseType.OrderNum, objAppraiseTypeCond.OrderNum, strComparisonOpOrderNum);
}
 return strWhereCond;
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_AppraiseType
{
public virtual bool UpdRelaTabDate(string strIdAppraiseType, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// 评价类型(AppraiseType)
 /// 数据源类型:表
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsAppraiseTypeBL
{
public static RelatedActions_AppraiseType relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsAppraiseTypeDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsAppraiseTypeDA AppraiseTypeDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsAppraiseTypeDA();
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
 public clsAppraiseTypeBL()
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
if (string.IsNullOrEmpty(clsAppraiseTypeEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsAppraiseTypeEN._ConnectString);
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
public static DataTable GetDataTable_AppraiseType(string strWhereCond)
{
DataTable objDT;
try
{
objDT = AppraiseTypeDA.GetDataTable_AppraiseType(strWhereCond);
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
objDT = AppraiseTypeDA.GetDataTable(strWhereCond);
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
objDT = AppraiseTypeDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = AppraiseTypeDA.GetDataTable(strWhereCond, strTabName);
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
objDT = AppraiseTypeDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = AppraiseTypeDA.GetDataTable_Top(objTopPara);
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
objDT = AppraiseTypeDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = AppraiseTypeDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = AppraiseTypeDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
 /// <param name = "arrIdAppraiseTypeLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static List<clsAppraiseTypeEN> GetObjLstByIdAppraiseTypeLst(List<string> arrIdAppraiseTypeLst)
{
List<clsAppraiseTypeEN> arrObjLst = new List<clsAppraiseTypeEN>(); 
System.Data.DataTable objDT; 
 string strSqlConditionStr = clsArray.GetSqlInStrByArray(arrIdAppraiseTypeLst, true);
 string strWhereCond = string.Format("IdAppraiseType in ({0})", strSqlConditionStr);
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsAppraiseTypeEN objAppraiseTypeEN = new clsAppraiseTypeEN();
try
{
objAppraiseTypeEN.IdAppraiseType = objRow[conAppraiseType.IdAppraiseType].ToString().Trim(); //评议类型流水号
objAppraiseTypeEN.AppraiseTypeID = objRow[conAppraiseType.AppraiseTypeID].ToString().Trim(); //评议类型ID
objAppraiseTypeEN.AppraiseTypeName = objRow[conAppraiseType.AppraiseTypeName].ToString().Trim(); //评议类型名称
objAppraiseTypeEN.AppraiseTypeName4CW = objRow[conAppraiseType.AppraiseTypeName4CW] == DBNull.Value ? null : objRow[conAppraiseType.AppraiseTypeName4CW].ToString().Trim(); //评议类型名称4课件
objAppraiseTypeEN.UserTypeId = objRow[conAppraiseType.UserTypeId].ToString().Trim(); //用户类型Id
objAppraiseTypeEN.Memo = objRow[conAppraiseType.Memo] == DBNull.Value ? null : objRow[conAppraiseType.Memo].ToString().Trim(); //备注
objAppraiseTypeEN.AppraiseTypeNameSim = objRow[conAppraiseType.AppraiseTypeNameSim] == DBNull.Value ? null : objRow[conAppraiseType.AppraiseTypeNameSim].ToString().Trim(); //评议类型名称_Sim
objAppraiseTypeEN.OrderNum = objRow[conAppraiseType.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conAppraiseType.OrderNum].ToString().Trim()); //序号
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objAppraiseTypeEN.IdAppraiseType, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objAppraiseTypeEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrIdAppraiseTypeLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsAppraiseTypeEN> GetObjLstByIdAppraiseTypeLstCache(List<string> arrIdAppraiseTypeLst)
{
string strKey = string.Format("{0}", clsAppraiseTypeEN._CurrTabName);
List<clsAppraiseTypeEN> arrAppraiseTypeObjLstCache = GetObjLstCache();
IEnumerable <clsAppraiseTypeEN> arrAppraiseTypeObjLst_Sel =
arrAppraiseTypeObjLstCache
.Where(x => arrIdAppraiseTypeLst.Contains(x.IdAppraiseType));
return arrAppraiseTypeObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsAppraiseTypeEN> GetObjLst(string strWhereCond)
{
List<clsAppraiseTypeEN> arrObjLst = new List<clsAppraiseTypeEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsAppraiseTypeEN objAppraiseTypeEN = new clsAppraiseTypeEN();
try
{
objAppraiseTypeEN.IdAppraiseType = objRow[conAppraiseType.IdAppraiseType].ToString().Trim(); //评议类型流水号
objAppraiseTypeEN.AppraiseTypeID = objRow[conAppraiseType.AppraiseTypeID].ToString().Trim(); //评议类型ID
objAppraiseTypeEN.AppraiseTypeName = objRow[conAppraiseType.AppraiseTypeName].ToString().Trim(); //评议类型名称
objAppraiseTypeEN.AppraiseTypeName4CW = objRow[conAppraiseType.AppraiseTypeName4CW] == DBNull.Value ? null : objRow[conAppraiseType.AppraiseTypeName4CW].ToString().Trim(); //评议类型名称4课件
objAppraiseTypeEN.UserTypeId = objRow[conAppraiseType.UserTypeId].ToString().Trim(); //用户类型Id
objAppraiseTypeEN.Memo = objRow[conAppraiseType.Memo] == DBNull.Value ? null : objRow[conAppraiseType.Memo].ToString().Trim(); //备注
objAppraiseTypeEN.AppraiseTypeNameSim = objRow[conAppraiseType.AppraiseTypeNameSim] == DBNull.Value ? null : objRow[conAppraiseType.AppraiseTypeNameSim].ToString().Trim(); //评议类型名称_Sim
objAppraiseTypeEN.OrderNum = objRow[conAppraiseType.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conAppraiseType.OrderNum].ToString().Trim()); //序号
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objAppraiseTypeEN.IdAppraiseType, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objAppraiseTypeEN);
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
public static List<clsAppraiseTypeEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsAppraiseTypeEN> arrObjLst = new List<clsAppraiseTypeEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsAppraiseTypeEN objAppraiseTypeEN = new clsAppraiseTypeEN();
try
{
objAppraiseTypeEN.IdAppraiseType = objRow[conAppraiseType.IdAppraiseType].ToString().Trim(); //评议类型流水号
objAppraiseTypeEN.AppraiseTypeID = objRow[conAppraiseType.AppraiseTypeID].ToString().Trim(); //评议类型ID
objAppraiseTypeEN.AppraiseTypeName = objRow[conAppraiseType.AppraiseTypeName].ToString().Trim(); //评议类型名称
objAppraiseTypeEN.AppraiseTypeName4CW = objRow[conAppraiseType.AppraiseTypeName4CW] == DBNull.Value ? null : objRow[conAppraiseType.AppraiseTypeName4CW].ToString().Trim(); //评议类型名称4课件
objAppraiseTypeEN.UserTypeId = objRow[conAppraiseType.UserTypeId].ToString().Trim(); //用户类型Id
objAppraiseTypeEN.Memo = objRow[conAppraiseType.Memo] == DBNull.Value ? null : objRow[conAppraiseType.Memo].ToString().Trim(); //备注
objAppraiseTypeEN.AppraiseTypeNameSim = objRow[conAppraiseType.AppraiseTypeNameSim] == DBNull.Value ? null : objRow[conAppraiseType.AppraiseTypeNameSim].ToString().Trim(); //评议类型名称_Sim
objAppraiseTypeEN.OrderNum = objRow[conAppraiseType.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conAppraiseType.OrderNum].ToString().Trim()); //序号
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objAppraiseTypeEN.IdAppraiseType, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objAppraiseTypeEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objAppraiseTypeCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsAppraiseTypeEN> GetSubObjLstCache(clsAppraiseTypeEN objAppraiseTypeCond)
{
List<clsAppraiseTypeEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsAppraiseTypeEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conAppraiseType.AttributeName)
{
if (objAppraiseTypeCond.IsUpdated(strFldName) == false) continue;
if (objAppraiseTypeCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objAppraiseTypeCond[strFldName].ToString());
}
else
{
if (objAppraiseTypeCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objAppraiseTypeCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objAppraiseTypeCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objAppraiseTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objAppraiseTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objAppraiseTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objAppraiseTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objAppraiseTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objAppraiseTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objAppraiseTypeCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objAppraiseTypeCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objAppraiseTypeCond[strFldName]));
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
public static List<clsAppraiseTypeEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsAppraiseTypeEN> arrObjLst = new List<clsAppraiseTypeEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsAppraiseTypeEN objAppraiseTypeEN = new clsAppraiseTypeEN();
try
{
objAppraiseTypeEN.IdAppraiseType = objRow[conAppraiseType.IdAppraiseType].ToString().Trim(); //评议类型流水号
objAppraiseTypeEN.AppraiseTypeID = objRow[conAppraiseType.AppraiseTypeID].ToString().Trim(); //评议类型ID
objAppraiseTypeEN.AppraiseTypeName = objRow[conAppraiseType.AppraiseTypeName].ToString().Trim(); //评议类型名称
objAppraiseTypeEN.AppraiseTypeName4CW = objRow[conAppraiseType.AppraiseTypeName4CW] == DBNull.Value ? null : objRow[conAppraiseType.AppraiseTypeName4CW].ToString().Trim(); //评议类型名称4课件
objAppraiseTypeEN.UserTypeId = objRow[conAppraiseType.UserTypeId].ToString().Trim(); //用户类型Id
objAppraiseTypeEN.Memo = objRow[conAppraiseType.Memo] == DBNull.Value ? null : objRow[conAppraiseType.Memo].ToString().Trim(); //备注
objAppraiseTypeEN.AppraiseTypeNameSim = objRow[conAppraiseType.AppraiseTypeNameSim] == DBNull.Value ? null : objRow[conAppraiseType.AppraiseTypeNameSim].ToString().Trim(); //评议类型名称_Sim
objAppraiseTypeEN.OrderNum = objRow[conAppraiseType.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conAppraiseType.OrderNum].ToString().Trim()); //序号
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objAppraiseTypeEN.IdAppraiseType, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objAppraiseTypeEN);
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
public static List<clsAppraiseTypeEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsAppraiseTypeEN> arrObjLst = new List<clsAppraiseTypeEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsAppraiseTypeEN objAppraiseTypeEN = new clsAppraiseTypeEN();
try
{
objAppraiseTypeEN.IdAppraiseType = objRow[conAppraiseType.IdAppraiseType].ToString().Trim(); //评议类型流水号
objAppraiseTypeEN.AppraiseTypeID = objRow[conAppraiseType.AppraiseTypeID].ToString().Trim(); //评议类型ID
objAppraiseTypeEN.AppraiseTypeName = objRow[conAppraiseType.AppraiseTypeName].ToString().Trim(); //评议类型名称
objAppraiseTypeEN.AppraiseTypeName4CW = objRow[conAppraiseType.AppraiseTypeName4CW] == DBNull.Value ? null : objRow[conAppraiseType.AppraiseTypeName4CW].ToString().Trim(); //评议类型名称4课件
objAppraiseTypeEN.UserTypeId = objRow[conAppraiseType.UserTypeId].ToString().Trim(); //用户类型Id
objAppraiseTypeEN.Memo = objRow[conAppraiseType.Memo] == DBNull.Value ? null : objRow[conAppraiseType.Memo].ToString().Trim(); //备注
objAppraiseTypeEN.AppraiseTypeNameSim = objRow[conAppraiseType.AppraiseTypeNameSim] == DBNull.Value ? null : objRow[conAppraiseType.AppraiseTypeNameSim].ToString().Trim(); //评议类型名称_Sim
objAppraiseTypeEN.OrderNum = objRow[conAppraiseType.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conAppraiseType.OrderNum].ToString().Trim()); //序号
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objAppraiseTypeEN.IdAppraiseType, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objAppraiseTypeEN);
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
List<clsAppraiseTypeEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsAppraiseTypeEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsAppraiseTypeEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsAppraiseTypeEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsAppraiseTypeEN> arrObjLst = new List<clsAppraiseTypeEN>(); 
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
	clsAppraiseTypeEN objAppraiseTypeEN = new clsAppraiseTypeEN();
try
{
objAppraiseTypeEN.IdAppraiseType = objRow[conAppraiseType.IdAppraiseType].ToString().Trim(); //评议类型流水号
objAppraiseTypeEN.AppraiseTypeID = objRow[conAppraiseType.AppraiseTypeID].ToString().Trim(); //评议类型ID
objAppraiseTypeEN.AppraiseTypeName = objRow[conAppraiseType.AppraiseTypeName].ToString().Trim(); //评议类型名称
objAppraiseTypeEN.AppraiseTypeName4CW = objRow[conAppraiseType.AppraiseTypeName4CW] == DBNull.Value ? null : objRow[conAppraiseType.AppraiseTypeName4CW].ToString().Trim(); //评议类型名称4课件
objAppraiseTypeEN.UserTypeId = objRow[conAppraiseType.UserTypeId].ToString().Trim(); //用户类型Id
objAppraiseTypeEN.Memo = objRow[conAppraiseType.Memo] == DBNull.Value ? null : objRow[conAppraiseType.Memo].ToString().Trim(); //备注
objAppraiseTypeEN.AppraiseTypeNameSim = objRow[conAppraiseType.AppraiseTypeNameSim] == DBNull.Value ? null : objRow[conAppraiseType.AppraiseTypeNameSim].ToString().Trim(); //评议类型名称_Sim
objAppraiseTypeEN.OrderNum = objRow[conAppraiseType.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conAppraiseType.OrderNum].ToString().Trim()); //序号
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objAppraiseTypeEN.IdAppraiseType, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objAppraiseTypeEN);
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
public static List<clsAppraiseTypeEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsAppraiseTypeEN> arrObjLst = new List<clsAppraiseTypeEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsAppraiseTypeEN objAppraiseTypeEN = new clsAppraiseTypeEN();
try
{
objAppraiseTypeEN.IdAppraiseType = objRow[conAppraiseType.IdAppraiseType].ToString().Trim(); //评议类型流水号
objAppraiseTypeEN.AppraiseTypeID = objRow[conAppraiseType.AppraiseTypeID].ToString().Trim(); //评议类型ID
objAppraiseTypeEN.AppraiseTypeName = objRow[conAppraiseType.AppraiseTypeName].ToString().Trim(); //评议类型名称
objAppraiseTypeEN.AppraiseTypeName4CW = objRow[conAppraiseType.AppraiseTypeName4CW] == DBNull.Value ? null : objRow[conAppraiseType.AppraiseTypeName4CW].ToString().Trim(); //评议类型名称4课件
objAppraiseTypeEN.UserTypeId = objRow[conAppraiseType.UserTypeId].ToString().Trim(); //用户类型Id
objAppraiseTypeEN.Memo = objRow[conAppraiseType.Memo] == DBNull.Value ? null : objRow[conAppraiseType.Memo].ToString().Trim(); //备注
objAppraiseTypeEN.AppraiseTypeNameSim = objRow[conAppraiseType.AppraiseTypeNameSim] == DBNull.Value ? null : objRow[conAppraiseType.AppraiseTypeNameSim].ToString().Trim(); //评议类型名称_Sim
objAppraiseTypeEN.OrderNum = objRow[conAppraiseType.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conAppraiseType.OrderNum].ToString().Trim()); //序号
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objAppraiseTypeEN.IdAppraiseType, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objAppraiseTypeEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsAppraiseTypeEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsAppraiseTypeEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsAppraiseTypeEN> arrObjLst = new List<clsAppraiseTypeEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsAppraiseTypeEN objAppraiseTypeEN = new clsAppraiseTypeEN();
try
{
objAppraiseTypeEN.IdAppraiseType = objRow[conAppraiseType.IdAppraiseType].ToString().Trim(); //评议类型流水号
objAppraiseTypeEN.AppraiseTypeID = objRow[conAppraiseType.AppraiseTypeID].ToString().Trim(); //评议类型ID
objAppraiseTypeEN.AppraiseTypeName = objRow[conAppraiseType.AppraiseTypeName].ToString().Trim(); //评议类型名称
objAppraiseTypeEN.AppraiseTypeName4CW = objRow[conAppraiseType.AppraiseTypeName4CW] == DBNull.Value ? null : objRow[conAppraiseType.AppraiseTypeName4CW].ToString().Trim(); //评议类型名称4课件
objAppraiseTypeEN.UserTypeId = objRow[conAppraiseType.UserTypeId].ToString().Trim(); //用户类型Id
objAppraiseTypeEN.Memo = objRow[conAppraiseType.Memo] == DBNull.Value ? null : objRow[conAppraiseType.Memo].ToString().Trim(); //备注
objAppraiseTypeEN.AppraiseTypeNameSim = objRow[conAppraiseType.AppraiseTypeNameSim] == DBNull.Value ? null : objRow[conAppraiseType.AppraiseTypeNameSim].ToString().Trim(); //评议类型名称_Sim
objAppraiseTypeEN.OrderNum = objRow[conAppraiseType.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conAppraiseType.OrderNum].ToString().Trim()); //序号
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objAppraiseTypeEN.IdAppraiseType, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objAppraiseTypeEN);
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
public static List<clsAppraiseTypeEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsAppraiseTypeEN> arrObjLst = new List<clsAppraiseTypeEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsAppraiseTypeEN objAppraiseTypeEN = new clsAppraiseTypeEN();
try
{
objAppraiseTypeEN.IdAppraiseType = objRow[conAppraiseType.IdAppraiseType].ToString().Trim(); //评议类型流水号
objAppraiseTypeEN.AppraiseTypeID = objRow[conAppraiseType.AppraiseTypeID].ToString().Trim(); //评议类型ID
objAppraiseTypeEN.AppraiseTypeName = objRow[conAppraiseType.AppraiseTypeName].ToString().Trim(); //评议类型名称
objAppraiseTypeEN.AppraiseTypeName4CW = objRow[conAppraiseType.AppraiseTypeName4CW] == DBNull.Value ? null : objRow[conAppraiseType.AppraiseTypeName4CW].ToString().Trim(); //评议类型名称4课件
objAppraiseTypeEN.UserTypeId = objRow[conAppraiseType.UserTypeId].ToString().Trim(); //用户类型Id
objAppraiseTypeEN.Memo = objRow[conAppraiseType.Memo] == DBNull.Value ? null : objRow[conAppraiseType.Memo].ToString().Trim(); //备注
objAppraiseTypeEN.AppraiseTypeNameSim = objRow[conAppraiseType.AppraiseTypeNameSim] == DBNull.Value ? null : objRow[conAppraiseType.AppraiseTypeNameSim].ToString().Trim(); //评议类型名称_Sim
objAppraiseTypeEN.OrderNum = objRow[conAppraiseType.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conAppraiseType.OrderNum].ToString().Trim()); //序号
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objAppraiseTypeEN.IdAppraiseType, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objAppraiseTypeEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsAppraiseTypeEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsAppraiseTypeEN> arrObjLst = new List<clsAppraiseTypeEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsAppraiseTypeEN objAppraiseTypeEN = new clsAppraiseTypeEN();
try
{
objAppraiseTypeEN.IdAppraiseType = objRow[conAppraiseType.IdAppraiseType].ToString().Trim(); //评议类型流水号
objAppraiseTypeEN.AppraiseTypeID = objRow[conAppraiseType.AppraiseTypeID].ToString().Trim(); //评议类型ID
objAppraiseTypeEN.AppraiseTypeName = objRow[conAppraiseType.AppraiseTypeName].ToString().Trim(); //评议类型名称
objAppraiseTypeEN.AppraiseTypeName4CW = objRow[conAppraiseType.AppraiseTypeName4CW] == DBNull.Value ? null : objRow[conAppraiseType.AppraiseTypeName4CW].ToString().Trim(); //评议类型名称4课件
objAppraiseTypeEN.UserTypeId = objRow[conAppraiseType.UserTypeId].ToString().Trim(); //用户类型Id
objAppraiseTypeEN.Memo = objRow[conAppraiseType.Memo] == DBNull.Value ? null : objRow[conAppraiseType.Memo].ToString().Trim(); //备注
objAppraiseTypeEN.AppraiseTypeNameSim = objRow[conAppraiseType.AppraiseTypeNameSim] == DBNull.Value ? null : objRow[conAppraiseType.AppraiseTypeNameSim].ToString().Trim(); //评议类型名称_Sim
objAppraiseTypeEN.OrderNum = objRow[conAppraiseType.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conAppraiseType.OrderNum].ToString().Trim()); //序号
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objAppraiseTypeEN.IdAppraiseType, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objAppraiseTypeEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objAppraiseTypeEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetAppraiseType(ref clsAppraiseTypeEN objAppraiseTypeEN)
{
bool bolResult = AppraiseTypeDA.GetAppraiseType(ref objAppraiseTypeEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "strIdAppraiseType">表关键字</param>
 /// <returns>表对象</returns>
public static clsAppraiseTypeEN GetObjByIdAppraiseType(string strIdAppraiseType)
{
if (strIdAppraiseType.IndexOf(' ') >=0)
{
var strMsg = string.Format("(errid:Busi000079)在表中,关键字[strIdAppraiseType]中不能有空格!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
if (string.IsNullOrEmpty(strIdAppraiseType) == true)
{
var strMsg = string.Format("(errid:Busi000020)在表中,关键字[strIdAppraiseType]不能为空!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
clsAppraiseTypeEN objAppraiseTypeEN = AppraiseTypeDA.GetObjByIdAppraiseType(strIdAppraiseType);
return objAppraiseTypeEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsAppraiseTypeEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsAppraiseTypeEN objAppraiseTypeEN = AppraiseTypeDA.GetFirstObj(strWhereCond);
 return objAppraiseTypeEN;
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
public static clsAppraiseTypeEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsAppraiseTypeEN objAppraiseTypeEN = AppraiseTypeDA.GetObjByDataRow(objRow);
 return objAppraiseTypeEN;
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
public static clsAppraiseTypeEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsAppraiseTypeEN objAppraiseTypeEN = AppraiseTypeDA.GetObjByDataRow(objRow);
 return objAppraiseTypeEN;
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
 /// <param name = "strIdAppraiseType">所给的关键字</param>
 /// <param name = "lstAppraiseTypeObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsAppraiseTypeEN GetObjByIdAppraiseTypeFromList(string strIdAppraiseType, List<clsAppraiseTypeEN> lstAppraiseTypeObjLst)
{
foreach (clsAppraiseTypeEN objAppraiseTypeEN in lstAppraiseTypeObjLst)
{
if (objAppraiseTypeEN.IdAppraiseType == strIdAppraiseType)
{
return objAppraiseTypeEN;
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
 string strIdAppraiseType;
 try
 {
 strIdAppraiseType = new clsAppraiseTypeDA().GetFirstID(strWhereCond);
 return strIdAppraiseType;
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
 arrList = AppraiseTypeDA.GetID(strWhereCond);
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
bool bolIsExist = AppraiseTypeDA.IsExistCondRec(strWhereCond);
return bolIsExist;
}

 /// <summary>
 /// 判断当前表中是否存在给定关键字值的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExist)
 /// </summary>
 /// <param name = "strIdAppraiseType">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public static bool IsExist(string strIdAppraiseType)
{
if (string.IsNullOrEmpty(strIdAppraiseType) == true)
{
var strMsg = string.Format("(errid:Busi000027)在表中,关键字[strIdAppraiseType]不能为空!!(from {0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
//检测记录是否存在
bool bolIsExist = AppraiseTypeDA.IsExist(strIdAppraiseType);
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
 bolIsExist = clsAppraiseTypeDA.IsExistTable();
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
 bolIsExist = AppraiseTypeDA.IsExistTable(strTabName);
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
 /// <param name = "objAppraiseTypeEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecordBySql2(clsAppraiseTypeEN objAppraiseTypeEN, bool bolIsNeedCheckUniqueness=true)
{
 if (string.IsNullOrEmpty(objAppraiseTypeEN.IdAppraiseType) == true)
 {
string strMsg = string.Format("添加记录时,关键字不能为空!(from {0})\r\n", 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
 if (clsAppraiseTypeBL.IsExist(objAppraiseTypeEN.IdAppraiseType) == true)
 {
string strMsg = string.Format("添加记录时,关键字:[{0}]已经存在!(from {1})\r\n", objAppraiseTypeEN.IdAppraiseType, 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
try
{
bool bolResult = AppraiseTypeDA.AddNewRecordBySQL2(objAppraiseTypeEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsAppraiseTypeBL.ReFreshCache();

if (clsAppraiseTypeBL.relatedActions != null)
{
clsAppraiseTypeBL.relatedActions.UpdRelaTabDate(objAppraiseTypeEN.IdAppraiseType, "SetUpdDate");
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
 /// <param name = "objAppraiseTypeEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordBySql2WithReturnKey(clsAppraiseTypeEN objAppraiseTypeEN, bool bolIsNeedCheckUniqueness=true)
{
 if (string.IsNullOrEmpty(objAppraiseTypeEN.IdAppraiseType) == true)
 {
string strMsg = string.Format("添加记录时,关键字不能为空!(from {{0}})", 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
 if (clsAppraiseTypeBL.IsExist(objAppraiseTypeEN.IdAppraiseType) == true)
 {
string strMsg = string.Format("添加记录时,关键字:[{0}]已经存在!(from {1})\r\n", objAppraiseTypeEN.IdAppraiseType, 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
try
{
string strKey = AppraiseTypeDA.AddNewRecordBySQL2WithReturnKey(objAppraiseTypeEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsAppraiseTypeBL.ReFreshCache();

if (clsAppraiseTypeBL.relatedActions != null)
{
clsAppraiseTypeBL.relatedActions.UpdRelaTabDate(objAppraiseTypeEN.IdAppraiseType, "SetUpdDate");
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
 /// <param name = "objAppraiseTypeEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(clsAppraiseTypeEN objAppraiseTypeEN)
{
try
{
bool bolResult = AppraiseTypeDA.Update(objAppraiseTypeEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsAppraiseTypeBL.ReFreshCache();

if (clsAppraiseTypeBL.relatedActions != null)
{
clsAppraiseTypeBL.relatedActions.UpdRelaTabDate(objAppraiseTypeEN.IdAppraiseType, "SetUpdDate");
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
 /// <param name = "objAppraiseTypeEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateBySql2(clsAppraiseTypeEN objAppraiseTypeEN)
{
 if (string.IsNullOrEmpty(objAppraiseTypeEN.IdAppraiseType) == true)
 {
var strMsg = string.Format("(errid:Busi000065)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = AppraiseTypeDA.UpdateBySql2(objAppraiseTypeEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsAppraiseTypeBL.ReFreshCache();

if (clsAppraiseTypeBL.relatedActions != null)
{
clsAppraiseTypeBL.relatedActions.UpdRelaTabDate(objAppraiseTypeEN.IdAppraiseType, "SetUpdDate");
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
 /// <param name = "strIdAppraiseType">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int DelRecord(string strIdAppraiseType)
{
try
{
 clsAppraiseTypeEN objAppraiseTypeEN = clsAppraiseTypeBL.GetObjByIdAppraiseType(strIdAppraiseType);

if (clsAppraiseTypeBL.relatedActions != null)
{
clsAppraiseTypeBL.relatedActions.UpdRelaTabDate(objAppraiseTypeEN.IdAppraiseType, "SetUpdDate");
}
if (objAppraiseTypeEN != null)
{
int intRecNum = AppraiseTypeDA.DelRecord(strIdAppraiseType);
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
/// <param name="strIdAppraiseType">表关键字</param>
/// <returns></returns>
public static bool DelRecordEx(string strIdAppraiseType )
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsAppraiseTypeDA.GetSpecSQLObj();
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
//删除与表:[AppraiseType]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conAppraiseType.IdAppraiseType,
//strIdAppraiseType);
//        clsAppraiseTypeBL.DelAppraiseTypesByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsAppraiseTypeBL.DelRecord(strIdAppraiseType, objConnection, objSqlTransaction);
objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsAppraiseTypeBLEx", "DelRecordEx", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("扩展删除记录出错:{0}!keyId = {1}.({2})",
objException.Message,
strIdAppraiseType, clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "strIdAppraiseType">给定的关键字值</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回删除是否成功?</returns>
public static bool DelRecord(string strIdAppraiseType, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
if (clsAppraiseTypeBL.relatedActions != null)
{
clsAppraiseTypeBL.relatedActions.UpdRelaTabDate(strIdAppraiseType, "UpdRelaTabDate");
}
bool bolResult = AppraiseTypeDA.DelRecord(strIdAppraiseType,objSqlConnection,objSqlTransaction);
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
 /// <param name = "arrIdAppraiseTypeLst">给定的关键字值列表</param>
 /// <returns>返回删除的记录数</returns>
public static int DelAppraiseTypes(List<string> arrIdAppraiseTypeLst)
{
if (arrIdAppraiseTypeLst.Count == 0) return 0;
try
{
if (clsAppraiseTypeBL.relatedActions != null)
{
foreach (var strIdAppraiseType in arrIdAppraiseTypeLst)
{
clsAppraiseTypeBL.relatedActions.UpdRelaTabDate(strIdAppraiseType, "UpdRelaTabDate");
}
}
int intDelRecNum = AppraiseTypeDA.DelAppraiseType(arrIdAppraiseTypeLst);
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
public static int DelAppraiseTypesByCond(string strWhereCond)
{
try
{
if (clsAppraiseTypeBL.relatedActions != null)
{
List<string> arrIdAppraiseType = GetPrimaryKeyID_S(strWhereCond);
foreach (var strIdAppraiseType in arrIdAppraiseType)
{
clsAppraiseTypeBL.relatedActions.UpdRelaTabDate(strIdAppraiseType, "UpdRelaTabDate");
}
}
int intRecNum = AppraiseTypeDA.DelAppraiseType(strWhereCond);
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
/// 这里仅仅是演示函数,使用时请复制到扩展类:[AppraiseType]中改名为:[DelRecord4MultiTabEx]使用
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DelRecord4MultiTab)
/// </summary>
/// <param name="strIdAppraiseType">表关键字</param>
/// <returns></returns>
public static bool DelRecord4MultiTab(string strIdAppraiseType)
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsAppraiseTypeDA.GetSpecSQLObj();
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
//删除与表:[AppraiseType]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conStudent.id_College,
//strid_College);
//        clsStudentBL.DelStudentsByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsAppraiseTypeBL.DelRecord(strIdAppraiseType, objConnection, objSqlTransaction);
                objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsAppraiseTypeBL", "DelRecord4MultiTab", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("删除多表记录出错:{0}!keyId = {1}.({2})",
objException.Message,
strIdAppraiseType, clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "objAppraiseTypeENS">源对象</param>
 /// <param name = "objAppraiseTypeENT">目标对象</param>
 public static void CopyTo(clsAppraiseTypeEN objAppraiseTypeENS, clsAppraiseTypeEN objAppraiseTypeENT)
{
try
{
objAppraiseTypeENT.IdAppraiseType = objAppraiseTypeENS.IdAppraiseType; //评议类型流水号
objAppraiseTypeENT.AppraiseTypeID = objAppraiseTypeENS.AppraiseTypeID; //评议类型ID
objAppraiseTypeENT.AppraiseTypeName = objAppraiseTypeENS.AppraiseTypeName; //评议类型名称
objAppraiseTypeENT.AppraiseTypeName4CW = objAppraiseTypeENS.AppraiseTypeName4CW; //评议类型名称4课件
objAppraiseTypeENT.UserTypeId = objAppraiseTypeENS.UserTypeId; //用户类型Id
objAppraiseTypeENT.Memo = objAppraiseTypeENS.Memo; //备注
objAppraiseTypeENT.AppraiseTypeNameSim = objAppraiseTypeENS.AppraiseTypeNameSim; //评议类型名称_Sim
objAppraiseTypeENT.OrderNum = objAppraiseTypeENS.OrderNum; //序号
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
 /// <param name = "objAppraiseTypeEN">源简化对象</param>
 public static void SetUpdFlag(clsAppraiseTypeEN objAppraiseTypeEN)
{
try
{
objAppraiseTypeEN.ClearUpdateState();
   string strsfUpdFldSetStr = objAppraiseTypeEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(conAppraiseType.IdAppraiseType, new clsStrCompareIgnoreCase())  ==  true)
{
objAppraiseTypeEN.IdAppraiseType = objAppraiseTypeEN.IdAppraiseType; //评议类型流水号
}
if (arrFldSet.Contains(conAppraiseType.AppraiseTypeID, new clsStrCompareIgnoreCase())  ==  true)
{
objAppraiseTypeEN.AppraiseTypeID = objAppraiseTypeEN.AppraiseTypeID; //评议类型ID
}
if (arrFldSet.Contains(conAppraiseType.AppraiseTypeName, new clsStrCompareIgnoreCase())  ==  true)
{
objAppraiseTypeEN.AppraiseTypeName = objAppraiseTypeEN.AppraiseTypeName; //评议类型名称
}
if (arrFldSet.Contains(conAppraiseType.AppraiseTypeName4CW, new clsStrCompareIgnoreCase())  ==  true)
{
objAppraiseTypeEN.AppraiseTypeName4CW = objAppraiseTypeEN.AppraiseTypeName4CW == "[null]" ? null :  objAppraiseTypeEN.AppraiseTypeName4CW; //评议类型名称4课件
}
if (arrFldSet.Contains(conAppraiseType.UserTypeId, new clsStrCompareIgnoreCase())  ==  true)
{
objAppraiseTypeEN.UserTypeId = objAppraiseTypeEN.UserTypeId; //用户类型Id
}
if (arrFldSet.Contains(conAppraiseType.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objAppraiseTypeEN.Memo = objAppraiseTypeEN.Memo == "[null]" ? null :  objAppraiseTypeEN.Memo; //备注
}
if (arrFldSet.Contains(conAppraiseType.AppraiseTypeNameSim, new clsStrCompareIgnoreCase())  ==  true)
{
objAppraiseTypeEN.AppraiseTypeNameSim = objAppraiseTypeEN.AppraiseTypeNameSim == "[null]" ? null :  objAppraiseTypeEN.AppraiseTypeNameSim; //评议类型名称_Sim
}
if (arrFldSet.Contains(conAppraiseType.OrderNum, new clsStrCompareIgnoreCase())  ==  true)
{
objAppraiseTypeEN.OrderNum = objAppraiseTypeEN.OrderNum; //序号
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
 /// <param name = "objAppraiseTypeEN">源简化对象</param>
 public static void AccessFldValueNull(clsAppraiseTypeEN objAppraiseTypeEN)
{
try
{
if (objAppraiseTypeEN.AppraiseTypeName4CW == "[null]") objAppraiseTypeEN.AppraiseTypeName4CW = null; //评议类型名称4课件
if (objAppraiseTypeEN.Memo == "[null]") objAppraiseTypeEN.Memo = null; //备注
if (objAppraiseTypeEN.AppraiseTypeNameSim == "[null]") objAppraiseTypeEN.AppraiseTypeNameSim = null; //评议类型名称_Sim
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
public static void CheckPropertyNew(clsAppraiseTypeEN objAppraiseTypeEN)
{
 AppraiseTypeDA.CheckPropertyNew(objAppraiseTypeEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(clsAppraiseTypeEN objAppraiseTypeEN)
{
 AppraiseTypeDA.CheckProperty4Condition(objAppraiseTypeEN);
 }


 #endregion 检查对象属性


 #region 绑定下拉框

 /// <summary>
 /// 绑定基于Win的下拉框
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_TabFeature_ComboBoxBindFunction)
 /// </summary>
 /// <param name = "objComboBox">需要绑定当前表的下拉框</param>

public static void BindCbo_IdAppraiseType(System.Windows.Forms.ComboBox objComboBox )
{
//为数据源为表的下拉框设置内容
string strCondition = string.Format("1 =1 Order By {0}", conAppraiseType.IdAppraiseType); 
List<clsAppraiseTypeEN> arrObjLst = clsAppraiseTypeBL.GetObjLst(strCondition);
//初始化一个对象列表
//插入第0项。在第0项中插入“请选择...”,为了方便用户,与WEB方式类似。
clsAppraiseTypeEN objAppraiseTypeEN = new clsAppraiseTypeEN()
{
IdAppraiseType = "0",
AppraiseTypeName = "选[评价类型]..."
};
arrObjLst.Insert(0, objAppraiseTypeEN);
//设置下拉框的数据源、以及设置值项、显示项
objComboBox.ValueMember = conAppraiseType.IdAppraiseType;
objComboBox.DisplayMember = conAppraiseType.AppraiseTypeName;
objComboBox.DataSource = arrObjLst;
objComboBox.SelectedIndex = 0;
}

 /// <summary>
 /// 绑定基于Web的下拉框
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_TabFeature_DdlBindFunction)
 /// </summary>
 /// <param name = "objDDL">需要绑定当前表的下拉框</param>

public static void BindDdl_IdAppraiseType(System.Web.UI.WebControls.DropDownList objDDL )
{
//为数据源于表的下拉框设置内容
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[评价类型]...","0");
string strCondition = string.Format("1 =1 Order By {0}", conAppraiseType.IdAppraiseType); 
IEnumerable<clsAppraiseTypeEN> arrObjLst = clsAppraiseTypeBL.GetObjLst(strCondition);
objDDL.DataValueField = conAppraiseType.IdAppraiseType;
objDDL.DataTextField = conAppraiseType.AppraiseTypeName;
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
public static void BindDdl_IdAppraiseTypeCache(System.Web.UI.WebControls.DropDownList objDDL)
{
//为数据源于表的下拉框设置内容
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[评价类型]...","0");
List<clsAppraiseTypeEN> arrAppraiseTypeObjLst = GetAllAppraiseTypeObjLstCache(); 
objDDL.DataValueField = conAppraiseType.IdAppraiseType;
objDDL.DataTextField = conAppraiseType.AppraiseTypeName;
objDDL.DataSource = arrAppraiseTypeObjLst;
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
if (clsAppraiseTypeBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsAppraiseTypeBL没有刷新缓存机制(clsAppraiseTypeBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by IdAppraiseType");
//if (arrAppraiseTypeObjLstCache == null)
//{
//arrAppraiseTypeObjLstCache = AppraiseTypeDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "strIdAppraiseType">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsAppraiseTypeEN GetObjByIdAppraiseTypeCache(string strIdAppraiseType)
{
//获取缓存中的对象列表
string strKey = string.Format("{0}", clsAppraiseTypeEN._CurrTabName);
List<clsAppraiseTypeEN> arrAppraiseTypeObjLstCache = GetObjLstCache();
IEnumerable <clsAppraiseTypeEN> arrAppraiseTypeObjLst_Sel =
arrAppraiseTypeObjLstCache
.Where(x=> x.IdAppraiseType == strIdAppraiseType 
);
if (arrAppraiseTypeObjLst_Sel.Count() == 0)
{
   clsAppraiseTypeEN obj = clsAppraiseTypeBL.GetObjByIdAppraiseType(strIdAppraiseType);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
 }
return null;
}
return arrAppraiseTypeObjLst_Sel.First();
}

 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecNameByKeyCache)
 /// </summary>
 /// <param name = "strIdAppraiseType">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetAppraiseTypeNameByIdAppraiseTypeCache(string strIdAppraiseType)
{
if (string.IsNullOrEmpty(strIdAppraiseType) == true) return "";
//获取缓存中的对象列表
clsAppraiseTypeEN objAppraiseType = GetObjByIdAppraiseTypeCache(strIdAppraiseType);
if (objAppraiseType == null) return "";
return objAppraiseType.AppraiseTypeName;
}
 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecNameByKeyCache)
 /// </summary>
 /// <param name = "strIdAppraiseType">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetNameByIdAppraiseTypeCache(string strIdAppraiseType)
{
if (string.IsNullOrEmpty(strIdAppraiseType) == true) return "";
//获取缓存中的对象列表
clsAppraiseTypeEN objAppraiseType = GetObjByIdAppraiseTypeCache(strIdAppraiseType);
if (objAppraiseType == null) return "";
return objAppraiseType.AppraiseTypeName;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsAppraiseTypeEN> GetAllAppraiseTypeObjLstCache()
{
//获取缓存中的对象列表
List<clsAppraiseTypeEN> arrAppraiseTypeObjLstCache = GetObjLstCache(); 
return arrAppraiseTypeObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsAppraiseTypeEN> GetObjLstCache()
{
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}", clsAppraiseTypeEN._CurrTabName);
List<clsAppraiseTypeEN> arrAppraiseTypeObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrAppraiseTypeObjLstCache;
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
string strKey = string.Format("{0}", clsAppraiseTypeEN._CurrTabName);
CacheHelper.Remove(strKey);
clsAppraiseTypeEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
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
if (clsAppraiseTypeEN._RefreshTimeLst.Count == 0) return "";
return clsAppraiseTypeEN._RefreshTimeLst[clsAppraiseTypeEN._RefreshTimeLst.Count - 1];
}

 /// <summary>
 /// 刷新缓存.把当前表的缓存以及该表相关视图的缓存清空.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ReFreshCache)
 /// </summary>
public static void ReFreshCache()
{
if (clsAppraiseTypeBL.objCommFun4BL != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}", clsAppraiseTypeEN._CurrTabName);
CacheHelper.Remove(strKey);
clsAppraiseTypeEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
clsAppraiseTypeBL.objCommFun4BL.ReFreshCache();
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
public static string Func(string strInFldName, string strOutFldName, string strIdAppraiseType)
{
if (strInFldName != conAppraiseType.IdAppraiseType)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (conAppraiseType.AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", conAppraiseType.AttributeName));
throw new Exception(strMsg);
}
var objAppraiseType = clsAppraiseTypeBL.GetObjByIdAppraiseTypeCache(strIdAppraiseType);
if (objAppraiseType == null) return "";
return objAppraiseType[strOutFldName].ToString();
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
int intRecCount = clsAppraiseTypeDA.GetRecCount(strTabName);
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
int intRecCount = clsAppraiseTypeDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsAppraiseTypeDA.GetRecCount();
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
int intRecCount = clsAppraiseTypeDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objAppraiseTypeCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsAppraiseTypeEN objAppraiseTypeCond)
{
List<clsAppraiseTypeEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsAppraiseTypeEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conAppraiseType.AttributeName)
{
if (objAppraiseTypeCond.IsUpdated(strFldName) == false) continue;
if (objAppraiseTypeCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objAppraiseTypeCond[strFldName].ToString());
}
else
{
if (objAppraiseTypeCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objAppraiseTypeCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objAppraiseTypeCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objAppraiseTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objAppraiseTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objAppraiseTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objAppraiseTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objAppraiseTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objAppraiseTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objAppraiseTypeCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objAppraiseTypeCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objAppraiseTypeCond[strFldName]));
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
 List<string> arrList = clsAppraiseTypeDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = AppraiseTypeDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = AppraiseTypeDA.GetFldValueNoDistinct(strFldName, strWhereCond);
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
int intRecCount = AppraiseTypeDA.SetFldValue(strFldName, strValue, strWhereCond);
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
int intRecCount = clsAppraiseTypeDA.SetFldValue(clsAppraiseTypeEN._CurrTabName, strFldName, fltValue, strWhereCond);
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
int intRecCount = AppraiseTypeDA.SetFldValue( strFldName, intValue, strWhereCond);
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
int intRecCount = clsAppraiseTypeDA.SetFldValue(strTabName, strFldName, strValue, strWhereCond);
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
int intRecCount = clsAppraiseTypeDA.SetFldValue(strTabName, strFldName, intValue, strWhereCond);
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
int intRecCount = clsAppraiseTypeDA.SetFldValue(strTabName, strFldName, fltValue, strWhereCond);
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
  strCreateTabCode.Append("CREATE table [dbo].[AppraiseType] "); 
 strCreateTabCode.Append(" ( "); 
 // /**评议类型流水号*/ 
 strCreateTabCode.Append(" IdAppraiseType char(4) primary key, "); 
 // /**评议类型ID*/ 
 strCreateTabCode.Append(" AppraiseTypeID char(4) not Null, "); 
 // /**评议类型名称*/ 
 strCreateTabCode.Append(" AppraiseTypeName varchar(50) not Null, "); 
 // /**评议类型名称4课件*/ 
 strCreateTabCode.Append(" AppraiseTypeName4CW varchar(50) Null, "); 
 // /**用户类型Id*/ 
 strCreateTabCode.Append(" UserTypeId char(2) not Null, "); 
 // /**备注*/ 
 strCreateTabCode.Append(" Memo varchar(1000) Null, "); 
 // /**评议类型名称_Sim*/ 
 strCreateTabCode.Append(" AppraiseTypeNameSim varchar(20) Null, "); 
 // /**序号*/ 
 strCreateTabCode.Append(" OrderNum int Null ");
 strCreateTabCode.Append(") "); 
  strCreateTabCode.Append("ON [PRIMARY] ");
  return strCreateTabCode.ToString();
}



 #endregion 表操作
}
 /// <summary>
 /// 评价类型(AppraiseType)
 /// 数据源类型:表
 /// (AutoGCLib.CommFun4BL4CSharp:GeneCode_This)
 /// </summary>
public class  clsCommFun4BL4AppraiseType : clsCommFun4BL
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
clsAppraiseTypeBL.ReFreshThisCache();
}
}

}