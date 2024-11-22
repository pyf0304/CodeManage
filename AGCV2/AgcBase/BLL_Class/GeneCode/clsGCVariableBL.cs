﻿
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsGCVariableBL
 表名:GCVariable(00050559)
 * 版本:2024.10.15.1(服务器:WIN-SRV103-116)
 日期:2024/10/15 16:37:38
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcSpa后端(000014, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433AGC_CS12
 PrjDataBaseId:0005
 模块中文名:生成代码(GeneCode)
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
using AGC.Entity;
using System.Data; 
using System.Data.SqlClient; 
using AGC.DAL;

namespace AGC.BusinessLogic
{
public static class  clsGCVariableBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "strVarId">表关键字</param>
 /// <returns>表对象</returns>
public static clsGCVariableEN GetObj(this K_VarId_GCVariable myKey)
{
clsGCVariableEN objGCVariableEN = clsGCVariableBL.GCVariableDA.GetObjByVarId(myKey.Value);
return objGCVariableEN;
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_AddNewRecord)
 /// </summary>
 /// <param name = "objGCVariableEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clsGCVariableEN objGCVariableEN, bool bolIsNeedCheckUniqueness = true)
{
if (bolIsNeedCheckUniqueness == true && CheckUniqueness(objGCVariableEN) == false)
{
var strMsg = string.Format("记录已经存在!变量名 = [{0}],变量类型Id = [{1}]的数据已经存在!(in clsGCVariableBL.AddNewRecord)", objGCVariableEN.VarName,objGCVariableEN.VarTypeId);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objGCVariableEN.VarId) == true || clsGCVariableBL.IsExist(objGCVariableEN.VarId) == true)
 {
     objGCVariableEN.VarId = clsGCVariableBL.GetMaxStrId_S();
 }
bool bolResult = clsGCVariableBL.GCVariableDA.AddNewRecordBySQL2(objGCVariableEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsGCVariableBL.ReFreshCache();

if (clsGCVariableBL.relatedActions != null)
{
clsGCVariableBL.relatedActions.UpdRelaTabDate(objGCVariableEN.VarId, objGCVariableEN.UpdUser);
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
public static bool AddRecordEx(this clsGCVariableEN objGCVariableEN, bool bolIsNeedCheckUniqueness = true)
{
//操作步骤:
//1、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在
//2、检查唯一性
//3、检查传进去的对象属性是否合法
//4、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
//1、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在

//因为是字符型自增主键,不需要检查主键是否已经存在,在添加时,再获取 最大值作为主键
//if (clsGCVariableBL.IsExist(objGCVariableEN.VarId))	//判断是否有相同的关键字
//{
//strMsg = "(errid:Busi000151)关键字字段已有相同的值";
//throw new Exception(strMsg);
//}
try
{
 //2、检查传进去的对象属性是否合法
objGCVariableEN.CheckPropertyNew();
 ///5.2、检查唯一性
if (bolIsNeedCheckUniqueness == true && objGCVariableEN.CheckUniqueness() == false)
{
strMsg = string.Format("(变量名(VarName)=[{0}],变量类型Id(VarTypeId)=[{1}])已经存在,不能重复!", objGCVariableEN.VarName, objGCVariableEN.VarTypeId);
throw new Exception(strMsg);
}
//因为是字符型自增主键,所以在添加时,自动获取主键值。
 if (string.IsNullOrEmpty(objGCVariableEN.VarId) == true || clsGCVariableBL.IsExist(objGCVariableEN.VarId) == true)
 {
     objGCVariableEN.VarId = clsGCVariableBL.GetMaxStrId_S();
 }
//6、把数据实体层的数据存贮到数据库中
objGCVariableEN.AddNewRecord();
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
 /// <param name = "objGCVariableEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static string AddNewRecordWithMaxId(this clsGCVariableEN objGCVariableEN, bool bolIsNeedCheckUniqueness = true)
{
if (bolIsNeedCheckUniqueness == true && CheckUniqueness(objGCVariableEN) == false)
{
var strMsg = string.Format("记录已经存在!变量名 = [{0}],变量类型Id = [{1}]的数据已经存在!(in clsGCVariableBL.AddNewRecordWithMaxId)", objGCVariableEN.VarName,objGCVariableEN.VarTypeId);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objGCVariableEN.VarId) == true || clsGCVariableBL.IsExist(objGCVariableEN.VarId) == true)
 {
     objGCVariableEN.VarId = clsGCVariableBL.GetMaxStrId_S();
 }
string strVarId = clsGCVariableBL.GCVariableDA.AddNewRecordBySQL2WithReturnKey(objGCVariableEN);
     objGCVariableEN.VarId = strVarId;
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsGCVariableBL.ReFreshCache();

if (clsGCVariableBL.relatedActions != null)
{
clsGCVariableBL.relatedActions.UpdRelaTabDate(objGCVariableEN.VarId, objGCVariableEN.UpdUser);
}
return strVarId;
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
 /// <param name = "objGCVariableEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordWithReturnKey(this clsGCVariableEN objGCVariableEN, bool bolIsNeedCheckUniqueness = true)
{
if (bolIsNeedCheckUniqueness == true && CheckUniqueness(objGCVariableEN) == false)
{
var strMsg = string.Format("记录已经存在!变量名 = [{0}],变量类型Id = [{1}]的数据已经存在!(in clsGCVariableBL.AddNewRecordWithReturnKey)", objGCVariableEN.VarName,objGCVariableEN.VarTypeId);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objGCVariableEN.VarId) == true || clsGCVariableBL.IsExist(objGCVariableEN.VarId) == true)
 {
     objGCVariableEN.VarId = clsGCVariableBL.GetMaxStrId_S();
 }
string strKey = clsGCVariableBL.GCVariableDA.AddNewRecordBySQL2WithReturnKey(objGCVariableEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsGCVariableBL.ReFreshCache();

if (clsGCVariableBL.relatedActions != null)
{
clsGCVariableBL.relatedActions.UpdRelaTabDate(objGCVariableEN.VarId, objGCVariableEN.UpdUser);
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
 /// <param name = "objGCVariableEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsGCVariableEN SetVarId(this clsGCVariableEN objGCVariableEN, string strVarId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strVarId, 8, conGCVariable.VarId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strVarId, 8, conGCVariable.VarId);
}
objGCVariableEN.VarId = strVarId; //变量Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objGCVariableEN.dicFldComparisonOp.ContainsKey(conGCVariable.VarId) == false)
{
objGCVariableEN.dicFldComparisonOp.Add(conGCVariable.VarId, strComparisonOp);
}
else
{
objGCVariableEN.dicFldComparisonOp[conGCVariable.VarId] = strComparisonOp;
}
}
return objGCVariableEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objGCVariableEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsGCVariableEN SetVarName(this clsGCVariableEN objGCVariableEN, string strVarName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strVarName, conGCVariable.VarName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strVarName, 50, conGCVariable.VarName);
}
objGCVariableEN.VarName = strVarName; //变量名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objGCVariableEN.dicFldComparisonOp.ContainsKey(conGCVariable.VarName) == false)
{
objGCVariableEN.dicFldComparisonOp.Add(conGCVariable.VarName, strComparisonOp);
}
else
{
objGCVariableEN.dicFldComparisonOp[conGCVariable.VarName] = strComparisonOp;
}
}
return objGCVariableEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objGCVariableEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsGCVariableEN SetVarExpression(this clsGCVariableEN objGCVariableEN, string strVarExpression, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strVarExpression, conGCVariable.VarExpression);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strVarExpression, 150, conGCVariable.VarExpression);
}
objGCVariableEN.VarExpression = strVarExpression; //变量表达式
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objGCVariableEN.dicFldComparisonOp.ContainsKey(conGCVariable.VarExpression) == false)
{
objGCVariableEN.dicFldComparisonOp.Add(conGCVariable.VarExpression, strComparisonOp);
}
else
{
objGCVariableEN.dicFldComparisonOp[conGCVariable.VarExpression] = strComparisonOp;
}
}
return objGCVariableEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objGCVariableEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsGCVariableEN SetFldId(this clsGCVariableEN objGCVariableEN, string strFldId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFldId, 8, conGCVariable.FldId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strFldId, 8, conGCVariable.FldId);
}
objGCVariableEN.FldId = strFldId; //字段Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objGCVariableEN.dicFldComparisonOp.ContainsKey(conGCVariable.FldId) == false)
{
objGCVariableEN.dicFldComparisonOp.Add(conGCVariable.FldId, strComparisonOp);
}
else
{
objGCVariableEN.dicFldComparisonOp[conGCVariable.FldId] = strComparisonOp;
}
}
return objGCVariableEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objGCVariableEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsGCVariableEN SetFilePath(this clsGCVariableEN objGCVariableEN, string strFilePath, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFilePath, 500, conGCVariable.FilePath);
}
objGCVariableEN.FilePath = strFilePath; //文件路径
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objGCVariableEN.dicFldComparisonOp.ContainsKey(conGCVariable.FilePath) == false)
{
objGCVariableEN.dicFldComparisonOp.Add(conGCVariable.FilePath, strComparisonOp);
}
else
{
objGCVariableEN.dicFldComparisonOp[conGCVariable.FilePath] = strComparisonOp;
}
}
return objGCVariableEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objGCVariableEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsGCVariableEN SetInitValue(this clsGCVariableEN objGCVariableEN, string strInitValue, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strInitValue, 1000, conGCVariable.InitValue);
}
objGCVariableEN.InitValue = strInitValue; //初始值
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objGCVariableEN.dicFldComparisonOp.ContainsKey(conGCVariable.InitValue) == false)
{
objGCVariableEN.dicFldComparisonOp.Add(conGCVariable.InitValue, strComparisonOp);
}
else
{
objGCVariableEN.dicFldComparisonOp[conGCVariable.InitValue] = strComparisonOp;
}
}
return objGCVariableEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objGCVariableEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsGCVariableEN SetVarTypeId(this clsGCVariableEN objGCVariableEN, string strVarTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strVarTypeId, conGCVariable.VarTypeId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strVarTypeId, 4, conGCVariable.VarTypeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strVarTypeId, 4, conGCVariable.VarTypeId);
}
objGCVariableEN.VarTypeId = strVarTypeId; //变量类型Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objGCVariableEN.dicFldComparisonOp.ContainsKey(conGCVariable.VarTypeId) == false)
{
objGCVariableEN.dicFldComparisonOp.Add(conGCVariable.VarTypeId, strComparisonOp);
}
else
{
objGCVariableEN.dicFldComparisonOp[conGCVariable.VarTypeId] = strComparisonOp;
}
}
return objGCVariableEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objGCVariableEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsGCVariableEN SetDataTypeId(this clsGCVariableEN objGCVariableEN, string strDataTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strDataTypeId, conGCVariable.DataTypeId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strDataTypeId, 2, conGCVariable.DataTypeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strDataTypeId, 2, conGCVariable.DataTypeId);
}
objGCVariableEN.DataTypeId = strDataTypeId; //数据类型Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objGCVariableEN.dicFldComparisonOp.ContainsKey(conGCVariable.DataTypeId) == false)
{
objGCVariableEN.dicFldComparisonOp.Add(conGCVariable.DataTypeId, strComparisonOp);
}
else
{
objGCVariableEN.dicFldComparisonOp[conGCVariable.DataTypeId] = strComparisonOp;
}
}
return objGCVariableEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objGCVariableEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsGCVariableEN SetVariableType(this clsGCVariableEN objGCVariableEN, string strVariableType, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strVariableType, 100, conGCVariable.VariableType);
}
objGCVariableEN.VariableType = strVariableType; //变量类型
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objGCVariableEN.dicFldComparisonOp.ContainsKey(conGCVariable.VariableType) == false)
{
objGCVariableEN.dicFldComparisonOp.Add(conGCVariable.VariableType, strComparisonOp);
}
else
{
objGCVariableEN.dicFldComparisonOp[conGCVariable.VariableType] = strComparisonOp;
}
}
return objGCVariableEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objGCVariableEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsGCVariableEN SetVariableTypeFullName(this clsGCVariableEN objGCVariableEN, string strVariableTypeFullName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strVariableTypeFullName, 500, conGCVariable.VariableTypeFullName);
}
objGCVariableEN.VariableTypeFullName = strVariableTypeFullName; //变量类型全名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objGCVariableEN.dicFldComparisonOp.ContainsKey(conGCVariable.VariableTypeFullName) == false)
{
objGCVariableEN.dicFldComparisonOp.Add(conGCVariable.VariableTypeFullName, strComparisonOp);
}
else
{
objGCVariableEN.dicFldComparisonOp[conGCVariable.VariableTypeFullName] = strComparisonOp;
}
}
return objGCVariableEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objGCVariableEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsGCVariableEN SetClsName(this clsGCVariableEN objGCVariableEN, string strClsName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strClsName, 100, conGCVariable.ClsName);
}
objGCVariableEN.ClsName = strClsName; //类名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objGCVariableEN.dicFldComparisonOp.ContainsKey(conGCVariable.ClsName) == false)
{
objGCVariableEN.dicFldComparisonOp.Add(conGCVariable.ClsName, strComparisonOp);
}
else
{
objGCVariableEN.dicFldComparisonOp[conGCVariable.ClsName] = strComparisonOp;
}
}
return objGCVariableEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objGCVariableEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsGCVariableEN SetUpdDate(this clsGCVariableEN objGCVariableEN, string strUpdDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdDate, 20, conGCVariable.UpdDate);
}
objGCVariableEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objGCVariableEN.dicFldComparisonOp.ContainsKey(conGCVariable.UpdDate) == false)
{
objGCVariableEN.dicFldComparisonOp.Add(conGCVariable.UpdDate, strComparisonOp);
}
else
{
objGCVariableEN.dicFldComparisonOp[conGCVariable.UpdDate] = strComparisonOp;
}
}
return objGCVariableEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objGCVariableEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsGCVariableEN SetUpdUser(this clsGCVariableEN objGCVariableEN, string strUpdUser, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdUser, 20, conGCVariable.UpdUser);
}
objGCVariableEN.UpdUser = strUpdUser; //修改者
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objGCVariableEN.dicFldComparisonOp.ContainsKey(conGCVariable.UpdUser) == false)
{
objGCVariableEN.dicFldComparisonOp.Add(conGCVariable.UpdUser, strComparisonOp);
}
else
{
objGCVariableEN.dicFldComparisonOp[conGCVariable.UpdUser] = strComparisonOp;
}
}
return objGCVariableEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objGCVariableEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsGCVariableEN SetMemo(this clsGCVariableEN objGCVariableEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, conGCVariable.Memo);
}
objGCVariableEN.Memo = strMemo; //说明
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objGCVariableEN.dicFldComparisonOp.ContainsKey(conGCVariable.Memo) == false)
{
objGCVariableEN.dicFldComparisonOp.Add(conGCVariable.Memo, strComparisonOp);
}
else
{
objGCVariableEN.dicFldComparisonOp[conGCVariable.Memo] = strComparisonOp;
}
}
return objGCVariableEN;
	}

 /// <summary>
 /// 修改记录存盘到数据表中
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_UpdateRecordEx)
 /// </summary>
 /// <param name = "objGCVariableEN">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool UpdateRecordEx(this clsGCVariableEN objGCVariableEN)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
try
{
//1、检查传进去的对象属性是否合法
objGCVariableEN.CheckPropertyNew();
clsGCVariableEN objGCVariableCond = new clsGCVariableEN();
string strCondition = objGCVariableCond
.SetVarId(objGCVariableEN.VarId, "<>")
.SetVarName(objGCVariableEN.VarName, "=")
.SetVarTypeId(objGCVariableEN.VarTypeId, "=")
.GetCombineCondition();
objGCVariableEN._IsCheckProperty = true;
bool bolIsExist = clsGCVariableBL.IsExistRecord(strCondition);
if (bolIsExist)
{
strMsg = "(VarName_VarTypeId)不能重复!";
throw new Exception(strMsg);
}
//4、把数据实体层的数据存贮到数据库中
objGCVariableEN.Update();
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
 /// <param name = "objGCVariable">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool EditRecordEx(this clsGCVariableEN objGCVariable)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
clsGCVariableEN objGCVariableCond = new clsGCVariableEN();
string strCondition = objGCVariableCond
.SetVarName(objGCVariable.VarName, "=")
.SetVarTypeId(objGCVariable.VarTypeId, "=")
.GetCombineCondition();
objGCVariable._IsCheckProperty = true;
bool bolIsExist = clsGCVariableBL.IsExistRecord(strCondition);
if (bolIsExist)
{
objGCVariable.VarId = clsGCVariableBL.GetFirstID_S(strCondition);
objGCVariable.UpdateWithCondition(strCondition);
}
else
{
objGCVariable.VarId = clsGCVariableBL.GetMaxStrId_S();
objGCVariable.AddNewRecord();
}
return true; 
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_Update)
 /// </summary>
 /// <param name = "objGCVariableEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsGCVariableEN objGCVariableEN)
{
 if (string.IsNullOrEmpty(objGCVariableEN.VarId) == true)
 {
string strMsg = string.Format("(errid:Busi000095)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsGCVariableBL.GCVariableDA.UpdateBySql2(objGCVariableEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsGCVariableBL.ReFreshCache();

if (clsGCVariableBL.relatedActions != null)
{
clsGCVariableBL.relatedActions.UpdRelaTabDate(objGCVariableEN.VarId, objGCVariableEN.UpdUser);
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
 /// <param name = "objGCVariableEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsGCVariableEN objGCVariableEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (string.IsNullOrEmpty(objGCVariableEN.VarId) == true)
 {
string strMsg = string.Format("(errid:Busi000087)修改记录时关键字不能为空!(带事务处理)(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsGCVariableBL.GCVariableDA.UpdateBySql2(objGCVariableEN, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsGCVariableBL.ReFreshCache();

if (clsGCVariableBL.relatedActions != null)
{
clsGCVariableBL.relatedActions.UpdRelaTabDate(objGCVariableEN.VarId, objGCVariableEN.UpdUser);
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
 /// <param name = "objGCVariableEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsGCVariableEN objGCVariableEN, string strWhereCond)
{
try
{
bool bolResult = clsGCVariableBL.GCVariableDA.UpdateBySqlWithCondition(objGCVariableEN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsGCVariableBL.ReFreshCache();

if (clsGCVariableBL.relatedActions != null)
{
clsGCVariableBL.relatedActions.UpdRelaTabDate(objGCVariableEN.VarId, objGCVariableEN.UpdUser);
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
 /// <param name = "objGCVariableEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsGCVariableEN objGCVariableEN, string strWhereCond, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
bool bolResult = clsGCVariableBL.GCVariableDA.UpdateBySqlWithConditionTransaction(objGCVariableEN, strWhereCond, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsGCVariableBL.ReFreshCache();

if (clsGCVariableBL.relatedActions != null)
{
clsGCVariableBL.relatedActions.UpdRelaTabDate(objGCVariableEN.VarId, objGCVariableEN.UpdUser);
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
 /// <param name = "strVarId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int Delete(this clsGCVariableEN objGCVariableEN)
{
try
{
int intRecNum = clsGCVariableBL.GCVariableDA.DelRecord(objGCVariableEN.VarId);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsGCVariableBL.ReFreshCache();

if (clsGCVariableBL.relatedActions != null)
{
clsGCVariableBL.relatedActions.UpdRelaTabDate(objGCVariableEN.VarId, objGCVariableEN.UpdUser);
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
 /// <param name = "objGCVariableENS">源对象</param>
 /// <param name = "objGCVariableENT">目标对象</param>
 public static void CopyTo(this clsGCVariableEN objGCVariableENS, clsGCVariableEN objGCVariableENT)
{
try
{
objGCVariableENT.VarId = objGCVariableENS.VarId; //变量Id
objGCVariableENT.VarName = objGCVariableENS.VarName; //变量名
objGCVariableENT.VarExpression = objGCVariableENS.VarExpression; //变量表达式
objGCVariableENT.FldId = objGCVariableENS.FldId; //字段Id
objGCVariableENT.FilePath = objGCVariableENS.FilePath; //文件路径
objGCVariableENT.InitValue = objGCVariableENS.InitValue; //初始值
objGCVariableENT.VarTypeId = objGCVariableENS.VarTypeId; //变量类型Id
objGCVariableENT.DataTypeId = objGCVariableENS.DataTypeId; //数据类型Id
objGCVariableENT.VariableType = objGCVariableENS.VariableType; //变量类型
objGCVariableENT.VariableTypeFullName = objGCVariableENS.VariableTypeFullName; //变量类型全名
objGCVariableENT.ClsName = objGCVariableENS.ClsName; //类名
objGCVariableENT.UpdDate = objGCVariableENS.UpdDate; //修改日期
objGCVariableENT.UpdUser = objGCVariableENS.UpdUser; //修改者
objGCVariableENT.Memo = objGCVariableENS.Memo; //说明
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
 /// <param name = "objGCVariableENS">源对象</param>
 /// <returns>目标对象=>clsGCVariableEN:objGCVariableENT</returns>
 public static clsGCVariableEN CopyTo(this clsGCVariableEN objGCVariableENS)
{
try
{
 clsGCVariableEN objGCVariableENT = new clsGCVariableEN()
{
VarId = objGCVariableENS.VarId, //变量Id
VarName = objGCVariableENS.VarName, //变量名
VarExpression = objGCVariableENS.VarExpression, //变量表达式
FldId = objGCVariableENS.FldId, //字段Id
FilePath = objGCVariableENS.FilePath, //文件路径
InitValue = objGCVariableENS.InitValue, //初始值
VarTypeId = objGCVariableENS.VarTypeId, //变量类型Id
DataTypeId = objGCVariableENS.DataTypeId, //数据类型Id
VariableType = objGCVariableENS.VariableType, //变量类型
VariableTypeFullName = objGCVariableENS.VariableTypeFullName, //变量类型全名
ClsName = objGCVariableENS.ClsName, //类名
UpdDate = objGCVariableENS.UpdDate, //修改日期
UpdUser = objGCVariableENS.UpdUser, //修改者
Memo = objGCVariableENS.Memo, //说明
};
 return objGCVariableENT;
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
public static void CheckPropertyNew(this clsGCVariableEN objGCVariableEN)
{
 clsGCVariableBL.GCVariableDA.CheckPropertyNew(objGCVariableEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(this clsGCVariableEN objGCVariableEN)
{
 clsGCVariableBL.GCVariableDA.CheckProperty4Condition(objGCVariableEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsGCVariableEN objGCVariableCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objGCVariableCond.IsUpdated(conGCVariable.VarId) == true)
{
string strComparisonOpVarId = objGCVariableCond.dicFldComparisonOp[conGCVariable.VarId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conGCVariable.VarId, objGCVariableCond.VarId, strComparisonOpVarId);
}
if (objGCVariableCond.IsUpdated(conGCVariable.VarName) == true)
{
string strComparisonOpVarName = objGCVariableCond.dicFldComparisonOp[conGCVariable.VarName];
strWhereCond += string.Format(" And {0} {2} '{1}'", conGCVariable.VarName, objGCVariableCond.VarName, strComparisonOpVarName);
}
if (objGCVariableCond.IsUpdated(conGCVariable.VarExpression) == true)
{
string strComparisonOpVarExpression = objGCVariableCond.dicFldComparisonOp[conGCVariable.VarExpression];
strWhereCond += string.Format(" And {0} {2} '{1}'", conGCVariable.VarExpression, objGCVariableCond.VarExpression, strComparisonOpVarExpression);
}
if (objGCVariableCond.IsUpdated(conGCVariable.FldId) == true)
{
string strComparisonOpFldId = objGCVariableCond.dicFldComparisonOp[conGCVariable.FldId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conGCVariable.FldId, objGCVariableCond.FldId, strComparisonOpFldId);
}
if (objGCVariableCond.IsUpdated(conGCVariable.FilePath) == true)
{
string strComparisonOpFilePath = objGCVariableCond.dicFldComparisonOp[conGCVariable.FilePath];
strWhereCond += string.Format(" And {0} {2} '{1}'", conGCVariable.FilePath, objGCVariableCond.FilePath, strComparisonOpFilePath);
}
if (objGCVariableCond.IsUpdated(conGCVariable.InitValue) == true)
{
string strComparisonOpInitValue = objGCVariableCond.dicFldComparisonOp[conGCVariable.InitValue];
strWhereCond += string.Format(" And {0} {2} '{1}'", conGCVariable.InitValue, objGCVariableCond.InitValue, strComparisonOpInitValue);
}
if (objGCVariableCond.IsUpdated(conGCVariable.VarTypeId) == true)
{
string strComparisonOpVarTypeId = objGCVariableCond.dicFldComparisonOp[conGCVariable.VarTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conGCVariable.VarTypeId, objGCVariableCond.VarTypeId, strComparisonOpVarTypeId);
}
if (objGCVariableCond.IsUpdated(conGCVariable.DataTypeId) == true)
{
string strComparisonOpDataTypeId = objGCVariableCond.dicFldComparisonOp[conGCVariable.DataTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conGCVariable.DataTypeId, objGCVariableCond.DataTypeId, strComparisonOpDataTypeId);
}
if (objGCVariableCond.IsUpdated(conGCVariable.VariableType) == true)
{
string strComparisonOpVariableType = objGCVariableCond.dicFldComparisonOp[conGCVariable.VariableType];
strWhereCond += string.Format(" And {0} {2} '{1}'", conGCVariable.VariableType, objGCVariableCond.VariableType, strComparisonOpVariableType);
}
if (objGCVariableCond.IsUpdated(conGCVariable.VariableTypeFullName) == true)
{
string strComparisonOpVariableTypeFullName = objGCVariableCond.dicFldComparisonOp[conGCVariable.VariableTypeFullName];
strWhereCond += string.Format(" And {0} {2} '{1}'", conGCVariable.VariableTypeFullName, objGCVariableCond.VariableTypeFullName, strComparisonOpVariableTypeFullName);
}
if (objGCVariableCond.IsUpdated(conGCVariable.ClsName) == true)
{
string strComparisonOpClsName = objGCVariableCond.dicFldComparisonOp[conGCVariable.ClsName];
strWhereCond += string.Format(" And {0} {2} '{1}'", conGCVariable.ClsName, objGCVariableCond.ClsName, strComparisonOpClsName);
}
if (objGCVariableCond.IsUpdated(conGCVariable.UpdDate) == true)
{
string strComparisonOpUpdDate = objGCVariableCond.dicFldComparisonOp[conGCVariable.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conGCVariable.UpdDate, objGCVariableCond.UpdDate, strComparisonOpUpdDate);
}
if (objGCVariableCond.IsUpdated(conGCVariable.UpdUser) == true)
{
string strComparisonOpUpdUser = objGCVariableCond.dicFldComparisonOp[conGCVariable.UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", conGCVariable.UpdUser, objGCVariableCond.UpdUser, strComparisonOpUpdUser);
}
if (objGCVariableCond.IsUpdated(conGCVariable.Memo) == true)
{
string strComparisonOpMemo = objGCVariableCond.dicFldComparisonOp[conGCVariable.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", conGCVariable.Memo, objGCVariableCond.Memo, strComparisonOpMemo);
}
 return strWhereCond;
}

 /// <summary>
 /// 检查唯一性(Uniqueness)--GCVariable(GC变量), 如果不唯一,即存在相同的记录,就返回False
 /// 唯一性条件:VarName_VarTypeId
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckConstraint)
 /// </summary>
 /// <param name = "objGCVariableEN">要求唯一的对象</param>
 /// <returns></returns>
public static bool CheckUniqueness(this clsGCVariableEN objGCVariableEN)
{
//检测记录是否存在
bool bolIsUniqueness;
StringBuilder sbCondition = new StringBuilder();
if (objGCVariableEN == null) return true;
if (objGCVariableEN.VarId == null || objGCVariableEN.VarId == "")
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and VarName = '{0}'", objGCVariableEN.VarName);
 sbCondition.AppendFormat(" and VarTypeId = '{0}'", objGCVariableEN.VarTypeId);
if (clsGCVariableBL.IsExistRecord(sbCondition.ToString())  ==  true)
{
 bolIsUniqueness = false;
}
else
{
 bolIsUniqueness = true;
}
}
 else {
sbCondition.AppendFormat("VarId !=  '{0}'", objGCVariableEN.VarId);
 sbCondition.AppendFormat(" and VarName = '{0}'", objGCVariableEN.VarName);
 sbCondition.AppendFormat(" and VarTypeId = '{0}'", objGCVariableEN.VarTypeId);
if (clsGCVariableBL.IsExistRecord(sbCondition.ToString())  ==  true)
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
 /// 获取唯一性条件串--GCVariable(GC变量), 即由对象中唯一性条件字段关键字与值组成的条件串
 /// 唯一性条件:VarName_VarTypeId
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetConditionString4Constraint)
 /// </summary>
 /// <param name = "objGCVariableEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(this clsGCVariableEN objGCVariableEN)
{
//检测记录是否存在
StringBuilder sbCondition = new StringBuilder();
if (objGCVariableEN == null) return "";
if (objGCVariableEN.VarId == null || objGCVariableEN.VarId == "")
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and VarName = '{0}'", objGCVariableEN.VarName);
 sbCondition.AppendFormat(" and VarTypeId = '{0}'", objGCVariableEN.VarTypeId);
return sbCondition.ToString();
}
 else {
sbCondition.AppendFormat("VarId !=  '{0}'", objGCVariableEN.VarId);
 sbCondition.AppendFormat(" and VarName = '{0}'", objGCVariableEN.VarName);
 sbCondition.AppendFormat(" and VarTypeId = '{0}'", objGCVariableEN.VarTypeId);
 return sbCondition.ToString();
}
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_GCVariable
{
public virtual bool UpdRelaTabDate(string strVarId, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// GC变量(GCVariable)
 /// 数据源类型:表
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsGCVariableBL
{
public static RelatedActions_GCVariable relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsGCVariableDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsGCVariableDA GCVariableDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsGCVariableDA();
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
 public clsGCVariableBL()
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
if (string.IsNullOrEmpty(clsGCVariableEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsGCVariableEN._ConnectString);
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
public static DataTable GetDataTable_GCVariable(string strWhereCond)
{
DataTable objDT;
try
{
objDT = GCVariableDA.GetDataTable_GCVariable(strWhereCond);
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
objDT = GCVariableDA.GetDataTable(strWhereCond);
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
objDT = GCVariableDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = GCVariableDA.GetDataTable(strWhereCond, strTabName);
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
objDT = GCVariableDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = GCVariableDA.GetDataTable_Top(objTopPara);
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
objDT = GCVariableDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = GCVariableDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = GCVariableDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
 /// <param name = "arrVarIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static List<clsGCVariableEN> GetObjLstByVarIdLst(List<string> arrVarIdLst)
{
List<clsGCVariableEN> arrObjLst = new List<clsGCVariableEN>(); 
System.Data.DataTable objDT; 
 string strSqlConditionStr = clsArray.GetSqlInStrByArray(arrVarIdLst, true);
 string strWhereCond = string.Format("VarId in ({0})", strSqlConditionStr);
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsGCVariableEN objGCVariableEN = new clsGCVariableEN();
try
{
objGCVariableEN.VarId = objRow[conGCVariable.VarId].ToString().Trim(); //变量Id
objGCVariableEN.VarName = objRow[conGCVariable.VarName].ToString().Trim(); //变量名
objGCVariableEN.VarExpression = objRow[conGCVariable.VarExpression].ToString().Trim(); //变量表达式
objGCVariableEN.FldId = objRow[conGCVariable.FldId] == DBNull.Value ? null : objRow[conGCVariable.FldId].ToString().Trim(); //字段Id
objGCVariableEN.FilePath = objRow[conGCVariable.FilePath] == DBNull.Value ? null : objRow[conGCVariable.FilePath].ToString().Trim(); //文件路径
objGCVariableEN.InitValue = objRow[conGCVariable.InitValue] == DBNull.Value ? null : objRow[conGCVariable.InitValue].ToString().Trim(); //初始值
objGCVariableEN.VarTypeId = objRow[conGCVariable.VarTypeId].ToString().Trim(); //变量类型Id
objGCVariableEN.DataTypeId = objRow[conGCVariable.DataTypeId].ToString().Trim(); //数据类型Id
objGCVariableEN.VariableType = objRow[conGCVariable.VariableType] == DBNull.Value ? null : objRow[conGCVariable.VariableType].ToString().Trim(); //变量类型
objGCVariableEN.VariableTypeFullName = objRow[conGCVariable.VariableTypeFullName] == DBNull.Value ? null : objRow[conGCVariable.VariableTypeFullName].ToString().Trim(); //变量类型全名
objGCVariableEN.ClsName = objRow[conGCVariable.ClsName] == DBNull.Value ? null : objRow[conGCVariable.ClsName].ToString().Trim(); //类名
objGCVariableEN.UpdDate = objRow[conGCVariable.UpdDate] == DBNull.Value ? null : objRow[conGCVariable.UpdDate].ToString().Trim(); //修改日期
objGCVariableEN.UpdUser = objRow[conGCVariable.UpdUser] == DBNull.Value ? null : objRow[conGCVariable.UpdUser].ToString().Trim(); //修改者
objGCVariableEN.Memo = objRow[conGCVariable.Memo] == DBNull.Value ? null : objRow[conGCVariable.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objGCVariableEN.VarId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objGCVariableEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrVarIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsGCVariableEN> GetObjLstByVarIdLstCache(List<string> arrVarIdLst)
{
string strKey = string.Format("{0}", clsGCVariableEN._CurrTabName);
List<clsGCVariableEN> arrGCVariableObjLstCache = GetObjLstCache();
IEnumerable <clsGCVariableEN> arrGCVariableObjLst_Sel =
arrGCVariableObjLstCache
.Where(x => arrVarIdLst.Contains(x.VarId));
return arrGCVariableObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsGCVariableEN> GetObjLst(string strWhereCond)
{
List<clsGCVariableEN> arrObjLst = new List<clsGCVariableEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsGCVariableEN objGCVariableEN = new clsGCVariableEN();
try
{
objGCVariableEN.VarId = objRow[conGCVariable.VarId].ToString().Trim(); //变量Id
objGCVariableEN.VarName = objRow[conGCVariable.VarName].ToString().Trim(); //变量名
objGCVariableEN.VarExpression = objRow[conGCVariable.VarExpression].ToString().Trim(); //变量表达式
objGCVariableEN.FldId = objRow[conGCVariable.FldId] == DBNull.Value ? null : objRow[conGCVariable.FldId].ToString().Trim(); //字段Id
objGCVariableEN.FilePath = objRow[conGCVariable.FilePath] == DBNull.Value ? null : objRow[conGCVariable.FilePath].ToString().Trim(); //文件路径
objGCVariableEN.InitValue = objRow[conGCVariable.InitValue] == DBNull.Value ? null : objRow[conGCVariable.InitValue].ToString().Trim(); //初始值
objGCVariableEN.VarTypeId = objRow[conGCVariable.VarTypeId].ToString().Trim(); //变量类型Id
objGCVariableEN.DataTypeId = objRow[conGCVariable.DataTypeId].ToString().Trim(); //数据类型Id
objGCVariableEN.VariableType = objRow[conGCVariable.VariableType] == DBNull.Value ? null : objRow[conGCVariable.VariableType].ToString().Trim(); //变量类型
objGCVariableEN.VariableTypeFullName = objRow[conGCVariable.VariableTypeFullName] == DBNull.Value ? null : objRow[conGCVariable.VariableTypeFullName].ToString().Trim(); //变量类型全名
objGCVariableEN.ClsName = objRow[conGCVariable.ClsName] == DBNull.Value ? null : objRow[conGCVariable.ClsName].ToString().Trim(); //类名
objGCVariableEN.UpdDate = objRow[conGCVariable.UpdDate] == DBNull.Value ? null : objRow[conGCVariable.UpdDate].ToString().Trim(); //修改日期
objGCVariableEN.UpdUser = objRow[conGCVariable.UpdUser] == DBNull.Value ? null : objRow[conGCVariable.UpdUser].ToString().Trim(); //修改者
objGCVariableEN.Memo = objRow[conGCVariable.Memo] == DBNull.Value ? null : objRow[conGCVariable.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objGCVariableEN.VarId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objGCVariableEN);
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
public static List<clsGCVariableEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsGCVariableEN> arrObjLst = new List<clsGCVariableEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsGCVariableEN objGCVariableEN = new clsGCVariableEN();
try
{
objGCVariableEN.VarId = objRow[conGCVariable.VarId].ToString().Trim(); //变量Id
objGCVariableEN.VarName = objRow[conGCVariable.VarName].ToString().Trim(); //变量名
objGCVariableEN.VarExpression = objRow[conGCVariable.VarExpression].ToString().Trim(); //变量表达式
objGCVariableEN.FldId = objRow[conGCVariable.FldId] == DBNull.Value ? null : objRow[conGCVariable.FldId].ToString().Trim(); //字段Id
objGCVariableEN.FilePath = objRow[conGCVariable.FilePath] == DBNull.Value ? null : objRow[conGCVariable.FilePath].ToString().Trim(); //文件路径
objGCVariableEN.InitValue = objRow[conGCVariable.InitValue] == DBNull.Value ? null : objRow[conGCVariable.InitValue].ToString().Trim(); //初始值
objGCVariableEN.VarTypeId = objRow[conGCVariable.VarTypeId].ToString().Trim(); //变量类型Id
objGCVariableEN.DataTypeId = objRow[conGCVariable.DataTypeId].ToString().Trim(); //数据类型Id
objGCVariableEN.VariableType = objRow[conGCVariable.VariableType] == DBNull.Value ? null : objRow[conGCVariable.VariableType].ToString().Trim(); //变量类型
objGCVariableEN.VariableTypeFullName = objRow[conGCVariable.VariableTypeFullName] == DBNull.Value ? null : objRow[conGCVariable.VariableTypeFullName].ToString().Trim(); //变量类型全名
objGCVariableEN.ClsName = objRow[conGCVariable.ClsName] == DBNull.Value ? null : objRow[conGCVariable.ClsName].ToString().Trim(); //类名
objGCVariableEN.UpdDate = objRow[conGCVariable.UpdDate] == DBNull.Value ? null : objRow[conGCVariable.UpdDate].ToString().Trim(); //修改日期
objGCVariableEN.UpdUser = objRow[conGCVariable.UpdUser] == DBNull.Value ? null : objRow[conGCVariable.UpdUser].ToString().Trim(); //修改者
objGCVariableEN.Memo = objRow[conGCVariable.Memo] == DBNull.Value ? null : objRow[conGCVariable.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objGCVariableEN.VarId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objGCVariableEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objGCVariableCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsGCVariableEN> GetSubObjLstCache(clsGCVariableEN objGCVariableCond)
{
List<clsGCVariableEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsGCVariableEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conGCVariable.AttributeName)
{
if (objGCVariableCond.IsUpdated(strFldName) == false) continue;
if (objGCVariableCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objGCVariableCond[strFldName].ToString());
}
else
{
if (objGCVariableCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objGCVariableCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objGCVariableCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objGCVariableCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objGCVariableCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objGCVariableCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objGCVariableCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objGCVariableCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objGCVariableCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objGCVariableCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objGCVariableCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objGCVariableCond[strFldName]));
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
public static List<clsGCVariableEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsGCVariableEN> arrObjLst = new List<clsGCVariableEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsGCVariableEN objGCVariableEN = new clsGCVariableEN();
try
{
objGCVariableEN.VarId = objRow[conGCVariable.VarId].ToString().Trim(); //变量Id
objGCVariableEN.VarName = objRow[conGCVariable.VarName].ToString().Trim(); //变量名
objGCVariableEN.VarExpression = objRow[conGCVariable.VarExpression].ToString().Trim(); //变量表达式
objGCVariableEN.FldId = objRow[conGCVariable.FldId] == DBNull.Value ? null : objRow[conGCVariable.FldId].ToString().Trim(); //字段Id
objGCVariableEN.FilePath = objRow[conGCVariable.FilePath] == DBNull.Value ? null : objRow[conGCVariable.FilePath].ToString().Trim(); //文件路径
objGCVariableEN.InitValue = objRow[conGCVariable.InitValue] == DBNull.Value ? null : objRow[conGCVariable.InitValue].ToString().Trim(); //初始值
objGCVariableEN.VarTypeId = objRow[conGCVariable.VarTypeId].ToString().Trim(); //变量类型Id
objGCVariableEN.DataTypeId = objRow[conGCVariable.DataTypeId].ToString().Trim(); //数据类型Id
objGCVariableEN.VariableType = objRow[conGCVariable.VariableType] == DBNull.Value ? null : objRow[conGCVariable.VariableType].ToString().Trim(); //变量类型
objGCVariableEN.VariableTypeFullName = objRow[conGCVariable.VariableTypeFullName] == DBNull.Value ? null : objRow[conGCVariable.VariableTypeFullName].ToString().Trim(); //变量类型全名
objGCVariableEN.ClsName = objRow[conGCVariable.ClsName] == DBNull.Value ? null : objRow[conGCVariable.ClsName].ToString().Trim(); //类名
objGCVariableEN.UpdDate = objRow[conGCVariable.UpdDate] == DBNull.Value ? null : objRow[conGCVariable.UpdDate].ToString().Trim(); //修改日期
objGCVariableEN.UpdUser = objRow[conGCVariable.UpdUser] == DBNull.Value ? null : objRow[conGCVariable.UpdUser].ToString().Trim(); //修改者
objGCVariableEN.Memo = objRow[conGCVariable.Memo] == DBNull.Value ? null : objRow[conGCVariable.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objGCVariableEN.VarId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objGCVariableEN);
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
public static List<clsGCVariableEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsGCVariableEN> arrObjLst = new List<clsGCVariableEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsGCVariableEN objGCVariableEN = new clsGCVariableEN();
try
{
objGCVariableEN.VarId = objRow[conGCVariable.VarId].ToString().Trim(); //变量Id
objGCVariableEN.VarName = objRow[conGCVariable.VarName].ToString().Trim(); //变量名
objGCVariableEN.VarExpression = objRow[conGCVariable.VarExpression].ToString().Trim(); //变量表达式
objGCVariableEN.FldId = objRow[conGCVariable.FldId] == DBNull.Value ? null : objRow[conGCVariable.FldId].ToString().Trim(); //字段Id
objGCVariableEN.FilePath = objRow[conGCVariable.FilePath] == DBNull.Value ? null : objRow[conGCVariable.FilePath].ToString().Trim(); //文件路径
objGCVariableEN.InitValue = objRow[conGCVariable.InitValue] == DBNull.Value ? null : objRow[conGCVariable.InitValue].ToString().Trim(); //初始值
objGCVariableEN.VarTypeId = objRow[conGCVariable.VarTypeId].ToString().Trim(); //变量类型Id
objGCVariableEN.DataTypeId = objRow[conGCVariable.DataTypeId].ToString().Trim(); //数据类型Id
objGCVariableEN.VariableType = objRow[conGCVariable.VariableType] == DBNull.Value ? null : objRow[conGCVariable.VariableType].ToString().Trim(); //变量类型
objGCVariableEN.VariableTypeFullName = objRow[conGCVariable.VariableTypeFullName] == DBNull.Value ? null : objRow[conGCVariable.VariableTypeFullName].ToString().Trim(); //变量类型全名
objGCVariableEN.ClsName = objRow[conGCVariable.ClsName] == DBNull.Value ? null : objRow[conGCVariable.ClsName].ToString().Trim(); //类名
objGCVariableEN.UpdDate = objRow[conGCVariable.UpdDate] == DBNull.Value ? null : objRow[conGCVariable.UpdDate].ToString().Trim(); //修改日期
objGCVariableEN.UpdUser = objRow[conGCVariable.UpdUser] == DBNull.Value ? null : objRow[conGCVariable.UpdUser].ToString().Trim(); //修改者
objGCVariableEN.Memo = objRow[conGCVariable.Memo] == DBNull.Value ? null : objRow[conGCVariable.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objGCVariableEN.VarId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objGCVariableEN);
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
List<clsGCVariableEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsGCVariableEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsGCVariableEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsGCVariableEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsGCVariableEN> arrObjLst = new List<clsGCVariableEN>(); 
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
	clsGCVariableEN objGCVariableEN = new clsGCVariableEN();
try
{
objGCVariableEN.VarId = objRow[conGCVariable.VarId].ToString().Trim(); //变量Id
objGCVariableEN.VarName = objRow[conGCVariable.VarName].ToString().Trim(); //变量名
objGCVariableEN.VarExpression = objRow[conGCVariable.VarExpression].ToString().Trim(); //变量表达式
objGCVariableEN.FldId = objRow[conGCVariable.FldId] == DBNull.Value ? null : objRow[conGCVariable.FldId].ToString().Trim(); //字段Id
objGCVariableEN.FilePath = objRow[conGCVariable.FilePath] == DBNull.Value ? null : objRow[conGCVariable.FilePath].ToString().Trim(); //文件路径
objGCVariableEN.InitValue = objRow[conGCVariable.InitValue] == DBNull.Value ? null : objRow[conGCVariable.InitValue].ToString().Trim(); //初始值
objGCVariableEN.VarTypeId = objRow[conGCVariable.VarTypeId].ToString().Trim(); //变量类型Id
objGCVariableEN.DataTypeId = objRow[conGCVariable.DataTypeId].ToString().Trim(); //数据类型Id
objGCVariableEN.VariableType = objRow[conGCVariable.VariableType] == DBNull.Value ? null : objRow[conGCVariable.VariableType].ToString().Trim(); //变量类型
objGCVariableEN.VariableTypeFullName = objRow[conGCVariable.VariableTypeFullName] == DBNull.Value ? null : objRow[conGCVariable.VariableTypeFullName].ToString().Trim(); //变量类型全名
objGCVariableEN.ClsName = objRow[conGCVariable.ClsName] == DBNull.Value ? null : objRow[conGCVariable.ClsName].ToString().Trim(); //类名
objGCVariableEN.UpdDate = objRow[conGCVariable.UpdDate] == DBNull.Value ? null : objRow[conGCVariable.UpdDate].ToString().Trim(); //修改日期
objGCVariableEN.UpdUser = objRow[conGCVariable.UpdUser] == DBNull.Value ? null : objRow[conGCVariable.UpdUser].ToString().Trim(); //修改者
objGCVariableEN.Memo = objRow[conGCVariable.Memo] == DBNull.Value ? null : objRow[conGCVariable.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objGCVariableEN.VarId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objGCVariableEN);
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
public static List<clsGCVariableEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsGCVariableEN> arrObjLst = new List<clsGCVariableEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsGCVariableEN objGCVariableEN = new clsGCVariableEN();
try
{
objGCVariableEN.VarId = objRow[conGCVariable.VarId].ToString().Trim(); //变量Id
objGCVariableEN.VarName = objRow[conGCVariable.VarName].ToString().Trim(); //变量名
objGCVariableEN.VarExpression = objRow[conGCVariable.VarExpression].ToString().Trim(); //变量表达式
objGCVariableEN.FldId = objRow[conGCVariable.FldId] == DBNull.Value ? null : objRow[conGCVariable.FldId].ToString().Trim(); //字段Id
objGCVariableEN.FilePath = objRow[conGCVariable.FilePath] == DBNull.Value ? null : objRow[conGCVariable.FilePath].ToString().Trim(); //文件路径
objGCVariableEN.InitValue = objRow[conGCVariable.InitValue] == DBNull.Value ? null : objRow[conGCVariable.InitValue].ToString().Trim(); //初始值
objGCVariableEN.VarTypeId = objRow[conGCVariable.VarTypeId].ToString().Trim(); //变量类型Id
objGCVariableEN.DataTypeId = objRow[conGCVariable.DataTypeId].ToString().Trim(); //数据类型Id
objGCVariableEN.VariableType = objRow[conGCVariable.VariableType] == DBNull.Value ? null : objRow[conGCVariable.VariableType].ToString().Trim(); //变量类型
objGCVariableEN.VariableTypeFullName = objRow[conGCVariable.VariableTypeFullName] == DBNull.Value ? null : objRow[conGCVariable.VariableTypeFullName].ToString().Trim(); //变量类型全名
objGCVariableEN.ClsName = objRow[conGCVariable.ClsName] == DBNull.Value ? null : objRow[conGCVariable.ClsName].ToString().Trim(); //类名
objGCVariableEN.UpdDate = objRow[conGCVariable.UpdDate] == DBNull.Value ? null : objRow[conGCVariable.UpdDate].ToString().Trim(); //修改日期
objGCVariableEN.UpdUser = objRow[conGCVariable.UpdUser] == DBNull.Value ? null : objRow[conGCVariable.UpdUser].ToString().Trim(); //修改者
objGCVariableEN.Memo = objRow[conGCVariable.Memo] == DBNull.Value ? null : objRow[conGCVariable.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objGCVariableEN.VarId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objGCVariableEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsGCVariableEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsGCVariableEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsGCVariableEN> arrObjLst = new List<clsGCVariableEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsGCVariableEN objGCVariableEN = new clsGCVariableEN();
try
{
objGCVariableEN.VarId = objRow[conGCVariable.VarId].ToString().Trim(); //变量Id
objGCVariableEN.VarName = objRow[conGCVariable.VarName].ToString().Trim(); //变量名
objGCVariableEN.VarExpression = objRow[conGCVariable.VarExpression].ToString().Trim(); //变量表达式
objGCVariableEN.FldId = objRow[conGCVariable.FldId] == DBNull.Value ? null : objRow[conGCVariable.FldId].ToString().Trim(); //字段Id
objGCVariableEN.FilePath = objRow[conGCVariable.FilePath] == DBNull.Value ? null : objRow[conGCVariable.FilePath].ToString().Trim(); //文件路径
objGCVariableEN.InitValue = objRow[conGCVariable.InitValue] == DBNull.Value ? null : objRow[conGCVariable.InitValue].ToString().Trim(); //初始值
objGCVariableEN.VarTypeId = objRow[conGCVariable.VarTypeId].ToString().Trim(); //变量类型Id
objGCVariableEN.DataTypeId = objRow[conGCVariable.DataTypeId].ToString().Trim(); //数据类型Id
objGCVariableEN.VariableType = objRow[conGCVariable.VariableType] == DBNull.Value ? null : objRow[conGCVariable.VariableType].ToString().Trim(); //变量类型
objGCVariableEN.VariableTypeFullName = objRow[conGCVariable.VariableTypeFullName] == DBNull.Value ? null : objRow[conGCVariable.VariableTypeFullName].ToString().Trim(); //变量类型全名
objGCVariableEN.ClsName = objRow[conGCVariable.ClsName] == DBNull.Value ? null : objRow[conGCVariable.ClsName].ToString().Trim(); //类名
objGCVariableEN.UpdDate = objRow[conGCVariable.UpdDate] == DBNull.Value ? null : objRow[conGCVariable.UpdDate].ToString().Trim(); //修改日期
objGCVariableEN.UpdUser = objRow[conGCVariable.UpdUser] == DBNull.Value ? null : objRow[conGCVariable.UpdUser].ToString().Trim(); //修改者
objGCVariableEN.Memo = objRow[conGCVariable.Memo] == DBNull.Value ? null : objRow[conGCVariable.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objGCVariableEN.VarId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objGCVariableEN);
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
public static List<clsGCVariableEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsGCVariableEN> arrObjLst = new List<clsGCVariableEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsGCVariableEN objGCVariableEN = new clsGCVariableEN();
try
{
objGCVariableEN.VarId = objRow[conGCVariable.VarId].ToString().Trim(); //变量Id
objGCVariableEN.VarName = objRow[conGCVariable.VarName].ToString().Trim(); //变量名
objGCVariableEN.VarExpression = objRow[conGCVariable.VarExpression].ToString().Trim(); //变量表达式
objGCVariableEN.FldId = objRow[conGCVariable.FldId] == DBNull.Value ? null : objRow[conGCVariable.FldId].ToString().Trim(); //字段Id
objGCVariableEN.FilePath = objRow[conGCVariable.FilePath] == DBNull.Value ? null : objRow[conGCVariable.FilePath].ToString().Trim(); //文件路径
objGCVariableEN.InitValue = objRow[conGCVariable.InitValue] == DBNull.Value ? null : objRow[conGCVariable.InitValue].ToString().Trim(); //初始值
objGCVariableEN.VarTypeId = objRow[conGCVariable.VarTypeId].ToString().Trim(); //变量类型Id
objGCVariableEN.DataTypeId = objRow[conGCVariable.DataTypeId].ToString().Trim(); //数据类型Id
objGCVariableEN.VariableType = objRow[conGCVariable.VariableType] == DBNull.Value ? null : objRow[conGCVariable.VariableType].ToString().Trim(); //变量类型
objGCVariableEN.VariableTypeFullName = objRow[conGCVariable.VariableTypeFullName] == DBNull.Value ? null : objRow[conGCVariable.VariableTypeFullName].ToString().Trim(); //变量类型全名
objGCVariableEN.ClsName = objRow[conGCVariable.ClsName] == DBNull.Value ? null : objRow[conGCVariable.ClsName].ToString().Trim(); //类名
objGCVariableEN.UpdDate = objRow[conGCVariable.UpdDate] == DBNull.Value ? null : objRow[conGCVariable.UpdDate].ToString().Trim(); //修改日期
objGCVariableEN.UpdUser = objRow[conGCVariable.UpdUser] == DBNull.Value ? null : objRow[conGCVariable.UpdUser].ToString().Trim(); //修改者
objGCVariableEN.Memo = objRow[conGCVariable.Memo] == DBNull.Value ? null : objRow[conGCVariable.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objGCVariableEN.VarId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objGCVariableEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsGCVariableEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsGCVariableEN> arrObjLst = new List<clsGCVariableEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsGCVariableEN objGCVariableEN = new clsGCVariableEN();
try
{
objGCVariableEN.VarId = objRow[conGCVariable.VarId].ToString().Trim(); //变量Id
objGCVariableEN.VarName = objRow[conGCVariable.VarName].ToString().Trim(); //变量名
objGCVariableEN.VarExpression = objRow[conGCVariable.VarExpression].ToString().Trim(); //变量表达式
objGCVariableEN.FldId = objRow[conGCVariable.FldId] == DBNull.Value ? null : objRow[conGCVariable.FldId].ToString().Trim(); //字段Id
objGCVariableEN.FilePath = objRow[conGCVariable.FilePath] == DBNull.Value ? null : objRow[conGCVariable.FilePath].ToString().Trim(); //文件路径
objGCVariableEN.InitValue = objRow[conGCVariable.InitValue] == DBNull.Value ? null : objRow[conGCVariable.InitValue].ToString().Trim(); //初始值
objGCVariableEN.VarTypeId = objRow[conGCVariable.VarTypeId].ToString().Trim(); //变量类型Id
objGCVariableEN.DataTypeId = objRow[conGCVariable.DataTypeId].ToString().Trim(); //数据类型Id
objGCVariableEN.VariableType = objRow[conGCVariable.VariableType] == DBNull.Value ? null : objRow[conGCVariable.VariableType].ToString().Trim(); //变量类型
objGCVariableEN.VariableTypeFullName = objRow[conGCVariable.VariableTypeFullName] == DBNull.Value ? null : objRow[conGCVariable.VariableTypeFullName].ToString().Trim(); //变量类型全名
objGCVariableEN.ClsName = objRow[conGCVariable.ClsName] == DBNull.Value ? null : objRow[conGCVariable.ClsName].ToString().Trim(); //类名
objGCVariableEN.UpdDate = objRow[conGCVariable.UpdDate] == DBNull.Value ? null : objRow[conGCVariable.UpdDate].ToString().Trim(); //修改日期
objGCVariableEN.UpdUser = objRow[conGCVariable.UpdUser] == DBNull.Value ? null : objRow[conGCVariable.UpdUser].ToString().Trim(); //修改者
objGCVariableEN.Memo = objRow[conGCVariable.Memo] == DBNull.Value ? null : objRow[conGCVariable.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objGCVariableEN.VarId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objGCVariableEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objGCVariableEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetGCVariable(ref clsGCVariableEN objGCVariableEN)
{
bool bolResult = GCVariableDA.GetGCVariable(ref objGCVariableEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "strVarId">表关键字</param>
 /// <returns>表对象</returns>
public static clsGCVariableEN GetObjByVarId(string strVarId)
{
if (strVarId.IndexOf(' ') >=0)
{
var strMsg = string.Format("(errid:Busi000079)在表中,关键字[strVarId]中不能有空格!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
if (string.IsNullOrEmpty(strVarId) == true)
{
var strMsg = string.Format("(errid:Busi000020)在表中,关键字[strVarId]不能为空!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
clsGCVariableEN objGCVariableEN = GCVariableDA.GetObjByVarId(strVarId);
return objGCVariableEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsGCVariableEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsGCVariableEN objGCVariableEN = GCVariableDA.GetFirstObj(strWhereCond);
 return objGCVariableEN;
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
public static clsGCVariableEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsGCVariableEN objGCVariableEN = GCVariableDA.GetObjByDataRow(objRow);
 return objGCVariableEN;
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
public static clsGCVariableEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsGCVariableEN objGCVariableEN = GCVariableDA.GetObjByDataRow(objRow);
 return objGCVariableEN;
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
 /// <param name = "strVarId">所给的关键字</param>
 /// <param name = "lstGCVariableObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsGCVariableEN GetObjByVarIdFromList(string strVarId, List<clsGCVariableEN> lstGCVariableObjLst)
{
foreach (clsGCVariableEN objGCVariableEN in lstGCVariableObjLst)
{
if (objGCVariableEN.VarId == strVarId)
{
return objGCVariableEN;
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
 string strMaxVarId;
 try
 {
 strMaxVarId = clsGCVariableDA.GetMaxStrId();
 return strMaxVarId;
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
 string strVarId;
 try
 {
 strVarId = new clsGCVariableDA().GetFirstID(strWhereCond);
 return strVarId;
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
 arrList = GCVariableDA.GetID(strWhereCond);
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
bool bolIsExist = GCVariableDA.IsExistCondRec(strWhereCond);
return bolIsExist;
}

 /// <summary>
 /// 判断当前表中是否存在给定关键字值的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExist)
 /// </summary>
 /// <param name = "strVarId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public static bool IsExist(string strVarId)
{
if (string.IsNullOrEmpty(strVarId) == true)
{
var strMsg = string.Format("(errid:Busi000027)在表中,关键字[strVarId]不能为空!!(from {0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
//检测记录是否存在
bool bolIsExist = GCVariableDA.IsExist(strVarId);
return bolIsExist;
}

/// <summary>
/// 设置修改时间
/// </summary>
/// <param name = "strVarId">变量Id</param>
/// <param name = "strOpUser">修改用户</param>
/// <returns>是否成功？</returns>
public static bool SetUpdDate(string strVarId, string strOpUser)
{
clsGCVariableEN objGCVariableEN = clsGCVariableBL.GetObjByVarId(strVarId);
objGCVariableEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
objGCVariableEN.UpdUser = strOpUser;
return clsGCVariableBL.UpdateBySql2(objGCVariableEN);
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
 bolIsExist = clsGCVariableDA.IsExistTable();
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
 bolIsExist = GCVariableDA.IsExistTable(strTabName);
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
 /// <param name = "objGCVariableEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecordBySql2(clsGCVariableEN objGCVariableEN, bool bolIsNeedCheckUniqueness=true)
{
if (bolIsNeedCheckUniqueness == true && objGCVariableEN.CheckUniqueness() == false)
{
var strMsg = string.Format("记录已经存在!变量名 = [{0}],变量类型Id = [{1}]的数据已经存在!(in clsGCVariableBL.AddNewRecordBySql2)", objGCVariableEN.VarName,objGCVariableEN.VarTypeId);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objGCVariableEN.VarId) == true || clsGCVariableBL.IsExist(objGCVariableEN.VarId) == true)
 {
     objGCVariableEN.VarId = clsGCVariableBL.GetMaxStrId_S();
 }
bool bolResult = GCVariableDA.AddNewRecordBySQL2(objGCVariableEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsGCVariableBL.ReFreshCache();

if (clsGCVariableBL.relatedActions != null)
{
clsGCVariableBL.relatedActions.UpdRelaTabDate(objGCVariableEN.VarId, objGCVariableEN.UpdUser);
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
 /// <param name = "objGCVariableEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordBySql2WithReturnKey(clsGCVariableEN objGCVariableEN, bool bolIsNeedCheckUniqueness=true)
{
if (bolIsNeedCheckUniqueness == true && objGCVariableEN.CheckUniqueness() == false)
{
var strMsg = string.Format("记录已经存在!变量名 = [{0}],变量类型Id = [{1}]的数据已经存在!(in clsGCVariableBL.AddNewRecordBySql2WithReturnKey)", objGCVariableEN.VarName,objGCVariableEN.VarTypeId);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objGCVariableEN.VarId) == true || clsGCVariableBL.IsExist(objGCVariableEN.VarId) == true)
 {
     objGCVariableEN.VarId = clsGCVariableBL.GetMaxStrId_S();
 }
string strKey = GCVariableDA.AddNewRecordBySQL2WithReturnKey(objGCVariableEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsGCVariableBL.ReFreshCache();

if (clsGCVariableBL.relatedActions != null)
{
clsGCVariableBL.relatedActions.UpdRelaTabDate(objGCVariableEN.VarId, objGCVariableEN.UpdUser);
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
 /// <param name = "objGCVariableEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(clsGCVariableEN objGCVariableEN)
{
try
{
bool bolResult = GCVariableDA.Update(objGCVariableEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsGCVariableBL.ReFreshCache();

if (clsGCVariableBL.relatedActions != null)
{
clsGCVariableBL.relatedActions.UpdRelaTabDate(objGCVariableEN.VarId, objGCVariableEN.UpdUser);
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
 /// <param name = "objGCVariableEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateBySql2(clsGCVariableEN objGCVariableEN)
{
 if (string.IsNullOrEmpty(objGCVariableEN.VarId) == true)
 {
var strMsg = string.Format("(errid:Busi000065)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = GCVariableDA.UpdateBySql2(objGCVariableEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsGCVariableBL.ReFreshCache();

if (clsGCVariableBL.relatedActions != null)
{
clsGCVariableBL.relatedActions.UpdRelaTabDate(objGCVariableEN.VarId, objGCVariableEN.UpdUser);
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
 /// <param name = "strVarId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int DelRecord(string strVarId)
{
try
{
 clsGCVariableEN objGCVariableEN = clsGCVariableBL.GetObjByVarId(strVarId);

if (clsGCVariableBL.relatedActions != null)
{
clsGCVariableBL.relatedActions.UpdRelaTabDate(objGCVariableEN.VarId, objGCVariableEN.UpdUser);
}
if (objGCVariableEN != null)
{
int intRecNum = GCVariableDA.DelRecord(strVarId);
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
/// <param name="strVarId">表关键字</param>
/// <returns></returns>
public static bool DelRecordEx(string strVarId )
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsGCVariableDA.GetSpecSQLObj();
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
//删除与表:[GCVariable]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conGCVariable.VarId,
//strVarId);
//        clsGCVariableBL.DelGCVariablesByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsGCVariableBL.DelRecord(strVarId, objConnection, objSqlTransaction);
objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsGCVariableBLEx", "DelRecordEx", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("扩展删除记录出错:{0}!keyId = {1}.({2})",
objException.Message,
strVarId, clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "strVarId">给定的关键字值</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回删除是否成功?</returns>
public static bool DelRecord(string strVarId, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
if (clsGCVariableBL.relatedActions != null)
{
clsGCVariableBL.relatedActions.UpdRelaTabDate(strVarId, "UpdRelaTabDate");
}
bool bolResult = GCVariableDA.DelRecord(strVarId,objSqlConnection,objSqlTransaction);
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
 /// <param name = "arrVarIdLst">给定的关键字值列表</param>
 /// <returns>返回删除的记录数</returns>
public static int DelGCVariables(List<string> arrVarIdLst)
{
if (arrVarIdLst.Count == 0) return 0;
try
{
if (clsGCVariableBL.relatedActions != null)
{
foreach (var strVarId in arrVarIdLst)
{
clsGCVariableBL.relatedActions.UpdRelaTabDate(strVarId, "UpdRelaTabDate");
}
}
int intDelRecNum = GCVariableDA.DelGCVariable(arrVarIdLst);
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
public static int DelGCVariablesByCond(string strWhereCond)
{
try
{
if (clsGCVariableBL.relatedActions != null)
{
List<string> arrVarId = GetPrimaryKeyID_S(strWhereCond);
foreach (var strVarId in arrVarId)
{
clsGCVariableBL.relatedActions.UpdRelaTabDate(strVarId, "UpdRelaTabDate");
}
}
int intRecNum = GCVariableDA.DelGCVariable(strWhereCond);
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
/// 这里仅仅是演示函数,使用时请复制到扩展类:[GCVariable]中改名为:[DelRecord4MultiTabEx]使用
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DelRecord4MultiTab)
/// </summary>
/// <param name="strVarId">表关键字</param>
/// <returns></returns>
public static bool DelRecord4MultiTab(string strVarId)
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsGCVariableDA.GetSpecSQLObj();
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
//删除与表:[GCVariable]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conStudent.id_College,
//strid_College);
//        clsStudentBL.DelStudentsByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsGCVariableBL.DelRecord(strVarId, objConnection, objSqlTransaction);
                objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsGCVariableBL", "DelRecord4MultiTab", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("删除多表记录出错:{0}!keyId = {1}.({2})",
objException.Message,
strVarId, clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "objGCVariableENS">源对象</param>
 /// <param name = "objGCVariableENT">目标对象</param>
 public static void CopyTo(clsGCVariableEN objGCVariableENS, clsGCVariableEN objGCVariableENT)
{
try
{
objGCVariableENT.VarId = objGCVariableENS.VarId; //变量Id
objGCVariableENT.VarName = objGCVariableENS.VarName; //变量名
objGCVariableENT.VarExpression = objGCVariableENS.VarExpression; //变量表达式
objGCVariableENT.FldId = objGCVariableENS.FldId; //字段Id
objGCVariableENT.FilePath = objGCVariableENS.FilePath; //文件路径
objGCVariableENT.InitValue = objGCVariableENS.InitValue; //初始值
objGCVariableENT.VarTypeId = objGCVariableENS.VarTypeId; //变量类型Id
objGCVariableENT.DataTypeId = objGCVariableENS.DataTypeId; //数据类型Id
objGCVariableENT.VariableType = objGCVariableENS.VariableType; //变量类型
objGCVariableENT.VariableTypeFullName = objGCVariableENS.VariableTypeFullName; //变量类型全名
objGCVariableENT.ClsName = objGCVariableENS.ClsName; //类名
objGCVariableENT.UpdDate = objGCVariableENS.UpdDate; //修改日期
objGCVariableENT.UpdUser = objGCVariableENS.UpdUser; //修改者
objGCVariableENT.Memo = objGCVariableENS.Memo; //说明
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
 /// <param name = "objGCVariableEN">源简化对象</param>
 public static void SetUpdFlag(clsGCVariableEN objGCVariableEN)
{
try
{
objGCVariableEN.ClearUpdateState();
   string strsfUpdFldSetStr = objGCVariableEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(conGCVariable.VarId, new clsStrCompareIgnoreCase())  ==  true)
{
objGCVariableEN.VarId = objGCVariableEN.VarId; //变量Id
}
if (arrFldSet.Contains(conGCVariable.VarName, new clsStrCompareIgnoreCase())  ==  true)
{
objGCVariableEN.VarName = objGCVariableEN.VarName; //变量名
}
if (arrFldSet.Contains(conGCVariable.VarExpression, new clsStrCompareIgnoreCase())  ==  true)
{
objGCVariableEN.VarExpression = objGCVariableEN.VarExpression; //变量表达式
}
if (arrFldSet.Contains(conGCVariable.FldId, new clsStrCompareIgnoreCase())  ==  true)
{
objGCVariableEN.FldId = objGCVariableEN.FldId == "[null]" ? null :  objGCVariableEN.FldId; //字段Id
}
if (arrFldSet.Contains(conGCVariable.FilePath, new clsStrCompareIgnoreCase())  ==  true)
{
objGCVariableEN.FilePath = objGCVariableEN.FilePath == "[null]" ? null :  objGCVariableEN.FilePath; //文件路径
}
if (arrFldSet.Contains(conGCVariable.InitValue, new clsStrCompareIgnoreCase())  ==  true)
{
objGCVariableEN.InitValue = objGCVariableEN.InitValue == "[null]" ? null :  objGCVariableEN.InitValue; //初始值
}
if (arrFldSet.Contains(conGCVariable.VarTypeId, new clsStrCompareIgnoreCase())  ==  true)
{
objGCVariableEN.VarTypeId = objGCVariableEN.VarTypeId; //变量类型Id
}
if (arrFldSet.Contains(conGCVariable.DataTypeId, new clsStrCompareIgnoreCase())  ==  true)
{
objGCVariableEN.DataTypeId = objGCVariableEN.DataTypeId; //数据类型Id
}
if (arrFldSet.Contains(conGCVariable.VariableType, new clsStrCompareIgnoreCase())  ==  true)
{
objGCVariableEN.VariableType = objGCVariableEN.VariableType == "[null]" ? null :  objGCVariableEN.VariableType; //变量类型
}
if (arrFldSet.Contains(conGCVariable.VariableTypeFullName, new clsStrCompareIgnoreCase())  ==  true)
{
objGCVariableEN.VariableTypeFullName = objGCVariableEN.VariableTypeFullName == "[null]" ? null :  objGCVariableEN.VariableTypeFullName; //变量类型全名
}
if (arrFldSet.Contains(conGCVariable.ClsName, new clsStrCompareIgnoreCase())  ==  true)
{
objGCVariableEN.ClsName = objGCVariableEN.ClsName == "[null]" ? null :  objGCVariableEN.ClsName; //类名
}
if (arrFldSet.Contains(conGCVariable.UpdDate, new clsStrCompareIgnoreCase())  ==  true)
{
objGCVariableEN.UpdDate = objGCVariableEN.UpdDate == "[null]" ? null :  objGCVariableEN.UpdDate; //修改日期
}
if (arrFldSet.Contains(conGCVariable.UpdUser, new clsStrCompareIgnoreCase())  ==  true)
{
objGCVariableEN.UpdUser = objGCVariableEN.UpdUser == "[null]" ? null :  objGCVariableEN.UpdUser; //修改者
}
if (arrFldSet.Contains(conGCVariable.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objGCVariableEN.Memo = objGCVariableEN.Memo == "[null]" ? null :  objGCVariableEN.Memo; //说明
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
 /// <param name = "objGCVariableEN">源简化对象</param>
 public static void AccessFldValueNull(clsGCVariableEN objGCVariableEN)
{
try
{
if (objGCVariableEN.FldId == "[null]") objGCVariableEN.FldId = null; //字段Id
if (objGCVariableEN.FilePath == "[null]") objGCVariableEN.FilePath = null; //文件路径
if (objGCVariableEN.InitValue == "[null]") objGCVariableEN.InitValue = null; //初始值
if (objGCVariableEN.VariableType == "[null]") objGCVariableEN.VariableType = null; //变量类型
if (objGCVariableEN.VariableTypeFullName == "[null]") objGCVariableEN.VariableTypeFullName = null; //变量类型全名
if (objGCVariableEN.ClsName == "[null]") objGCVariableEN.ClsName = null; //类名
if (objGCVariableEN.UpdDate == "[null]") objGCVariableEN.UpdDate = null; //修改日期
if (objGCVariableEN.UpdUser == "[null]") objGCVariableEN.UpdUser = null; //修改者
if (objGCVariableEN.Memo == "[null]") objGCVariableEN.Memo = null; //说明
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
public static void CheckPropertyNew(clsGCVariableEN objGCVariableEN)
{
 GCVariableDA.CheckPropertyNew(objGCVariableEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(clsGCVariableEN objGCVariableEN)
{
 GCVariableDA.CheckProperty4Condition(objGCVariableEN);
 }


 #endregion 检查对象属性


 #region 绑定下拉框

 /// <summary>
 /// 绑定基于Web的下拉框-使用Cache
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DdlBindFunctionCache)
 /// </summary>
 /// <param name = "objDDL">需要绑定当前表的下拉框</param>
public static void BindDdl_VarIdCache(System.Web.UI.WebControls.DropDownList objDDL)
{
//为数据源于表的下拉框设置内容
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[GC变量]...","0");
List<clsGCVariableEN> arrGCVariableObjLst = GetAllGCVariableObjLstCache(); 
objDDL.DataValueField = conGCVariable.VarId;
objDDL.DataTextField = conGCVariable.VarName;
objDDL.DataSource = arrGCVariableObjLst;
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
if (clsGCVariableBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsGCVariableBL没有刷新缓存机制(clsGCVariableBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by VarId");
//if (arrGCVariableObjLstCache == null)
//{
//arrGCVariableObjLstCache = GCVariableDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "strVarId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsGCVariableEN GetObjByVarIdCache(string strVarId)
{
//获取缓存中的对象列表
string strKey = string.Format("{0}", clsGCVariableEN._CurrTabName);
List<clsGCVariableEN> arrGCVariableObjLstCache = GetObjLstCache();
IEnumerable <clsGCVariableEN> arrGCVariableObjLst_Sel =
arrGCVariableObjLstCache
.Where(x=> x.VarId == strVarId 
);
if (arrGCVariableObjLst_Sel.Count() == 0)
{
   clsGCVariableEN obj = clsGCVariableBL.GetObjByVarId(strVarId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
 }
return null;
}
return arrGCVariableObjLst_Sel.First();
}

 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecNameByKeyCache)
 /// </summary>
 /// <param name = "strVarId">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetVarNameByVarIdCache(string strVarId)
{
if (string.IsNullOrEmpty(strVarId) == true) return "";
//获取缓存中的对象列表
clsGCVariableEN objGCVariable = GetObjByVarIdCache(strVarId);
if (objGCVariable == null) return "";
return objGCVariable.VarName;
}
 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecNameByKeyCache)
 /// </summary>
 /// <param name = "strVarId">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetNameByVarIdCache(string strVarId)
{
if (string.IsNullOrEmpty(strVarId) == true) return "";
//获取缓存中的对象列表
clsGCVariableEN objGCVariable = GetObjByVarIdCache(strVarId);
if (objGCVariable == null) return "";
return objGCVariable.VarName;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsGCVariableEN> GetAllGCVariableObjLstCache()
{
//获取缓存中的对象列表
List<clsGCVariableEN> arrGCVariableObjLstCache = GetObjLstCache(); 
return arrGCVariableObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsGCVariableEN> GetObjLstCache()
{
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}", clsGCVariableEN._CurrTabName);
List<clsGCVariableEN> arrGCVariableObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrGCVariableObjLstCache;
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
string strKey = string.Format("{0}", clsGCVariableEN._CurrTabName);
CacheHelper.Remove(strKey);
clsGCVariableEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
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
if (clsGCVariableEN._RefreshTimeLst.Count == 0) return "";
return clsGCVariableEN._RefreshTimeLst[clsGCVariableEN._RefreshTimeLst.Count - 1];
}

 /// <summary>
 /// 刷新缓存.把当前表的缓存以及该表相关视图的缓存清空.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ReFreshCache)
 /// </summary>
public static void ReFreshCache()
{
if (clsGCVariableBL.objCommFun4BL != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}", clsGCVariableEN._CurrTabName);
CacheHelper.Remove(strKey);
clsGCVariableEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
clsGCVariableBL.objCommFun4BL.ReFreshCache();
}
}


 #endregion 缓存操作


 #region 检查唯一性

 /// <summary>
 /// 获取检查唯一性条件串(Uniqueness)--GCVariable(GC变量)
 /// 唯一性条件:VarName_VarTypeId
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetUniquenessConditionString)
 /// </summary>
 /// <param name = "objGCVariableEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(clsGCVariableEN objGCVariableEN)
{
//检测记录是否存在
string strResult = GCVariableDA.GetUniCondStr(objGCVariableEN);
return strResult;
}


 #endregion 检查唯一性

 /// <summary>
 /// 映射函数。根据表映射把输入字段值,映射成输出字段值
 /// 作者:pyf
 /// 日期:2024-10-15
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_func)
 /// </summary>
 /// <param name = "strInFldName">输入字段名</param>
 /// <param name = "strOutFldName">输出字段名</param>
 /// <param name = "strInValue">输入字段值</param>
 /// <returns>返回一个输出字段值</returns>
public static string Func(string strInFldName, string strOutFldName, string strVarId)
{
if (strInFldName != conGCVariable.VarId)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (conGCVariable.AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", conGCVariable.AttributeName));
throw new Exception(strMsg);
}
var objGCVariable = clsGCVariableBL.GetObjByVarIdCache(strVarId);
if (objGCVariable == null) return "";
return objGCVariable[strOutFldName].ToString();
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
int intRecCount = clsGCVariableDA.GetRecCount(strTabName);
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
int intRecCount = clsGCVariableDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsGCVariableDA.GetRecCount();
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
int intRecCount = clsGCVariableDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objGCVariableCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsGCVariableEN objGCVariableCond)
{
List<clsGCVariableEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsGCVariableEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conGCVariable.AttributeName)
{
if (objGCVariableCond.IsUpdated(strFldName) == false) continue;
if (objGCVariableCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objGCVariableCond[strFldName].ToString());
}
else
{
if (objGCVariableCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objGCVariableCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objGCVariableCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objGCVariableCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objGCVariableCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objGCVariableCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objGCVariableCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objGCVariableCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objGCVariableCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objGCVariableCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objGCVariableCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objGCVariableCond[strFldName]));
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
 List<string> arrList = clsGCVariableDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = GCVariableDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = GCVariableDA.GetFldValueNoDistinct(strFldName, strWhereCond);
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
int intRecCount = GCVariableDA.SetFldValue(strFldName, strValue, strWhereCond);
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
int intRecCount = clsGCVariableDA.SetFldValue(clsGCVariableEN._CurrTabName, strFldName, fltValue, strWhereCond);
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
int intRecCount = GCVariableDA.SetFldValue( strFldName, intValue, strWhereCond);
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
int intRecCount = clsGCVariableDA.SetFldValue(strTabName, strFldName, strValue, strWhereCond);
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
int intRecCount = clsGCVariableDA.SetFldValue(strTabName, strFldName, intValue, strWhereCond);
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
int intRecCount = clsGCVariableDA.SetFldValue(strTabName, strFldName, fltValue, strWhereCond);
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
  strCreateTabCode.Append("CREATE table [dbo].[GCVariable] "); 
 strCreateTabCode.Append(" ( "); 
 // /**变量Id*/ 
 strCreateTabCode.Append(" VarId char(8) primary key, "); 
 // /**变量名*/ 
 strCreateTabCode.Append(" VarName varchar(50) not Null, "); 
 // /**变量表达式*/ 
 strCreateTabCode.Append(" VarExpression varchar(150) not Null, "); 
 // /**字段Id*/ 
 strCreateTabCode.Append(" FldId char(8) Null, "); 
 // /**文件路径*/ 
 strCreateTabCode.Append(" FilePath varchar(500) Null, "); 
 // /**初始值*/ 
 strCreateTabCode.Append(" InitValue varchar(1000) Null, "); 
 // /**变量类型Id*/ 
 strCreateTabCode.Append(" VarTypeId char(4) not Null, "); 
 // /**数据类型Id*/ 
 strCreateTabCode.Append(" DataTypeId char(2) not Null, "); 
 // /**变量类型*/ 
 strCreateTabCode.Append(" VariableType varchar(100) Null, "); 
 // /**变量类型全名*/ 
 strCreateTabCode.Append(" VariableTypeFullName varchar(500) Null, "); 
 // /**类名*/ 
 strCreateTabCode.Append(" ClsName varchar(100) Null, "); 
 // /**修改日期*/ 
 strCreateTabCode.Append(" UpdDate varchar(20) Null, "); 
 // /**修改者*/ 
 strCreateTabCode.Append(" UpdUser varchar(20) Null, "); 
 // /**说明*/ 
 strCreateTabCode.Append(" Memo varchar(1000) Null, "); 
 // /**变量类型名*/ 
 strCreateTabCode.Append(" VarTypeName varchar(50) Null, "); 
 // /**变量名Ex*/ 
 strCreateTabCode.Append(" VarNameEx varchar(50) Null, "); 
 // /**变量表达式Ex*/ 
 strCreateTabCode.Append(" VarExpressionEx varchar(50) Null, "); 
 // /**工程名称*/ 
 strCreateTabCode.Append(" PrjName varchar(30) Null, "); 
 // /**数据类型名称*/ 
 strCreateTabCode.Append(" DataTypeName varchar(100) Null, "); 
 // /**文件路径*/ 
 strCreateTabCode.Append(" DuFilePath varchar(500) Null, "); 
 // /**类名*/ 
 strCreateTabCode.Append(" DuClassName varchar(100) Null, "); 
 // /**数据类型名称*/ 
 strCreateTabCode.Append(" DuDataTypeName varchar(100) Null, "); 
 // /**工程ID*/ 
 strCreateTabCode.Append(" PrjId char(4) not Null, "); 
 // /**字段名*/ 
 strCreateTabCode.Append(" FldName varchar(50) Null, "); 
 // /**工程ID*/ 
 strCreateTabCode.Append(" PrjIdBak char(4) not Null ");
 strCreateTabCode.Append(") "); 
  strCreateTabCode.Append("ON [PRIMARY] ");
  return strCreateTabCode.ToString();
}



 #endregion 表操作
}
 /// <summary>
 /// GC变量(GCVariable)
 /// 数据源类型:表
 /// (AutoGCLib.CommFun4BL4CSharp:GeneCode_This)
 /// </summary>
public class  clsCommFun4BL4GCVariable : clsCommFun4BL
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
clsGCVariableBL.ReFreshThisCache();
}
}

}