﻿
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsFunctionTemplateRelaBL
 表名:FunctionTemplateRela(00050313)
 * 版本:2024.10.15.1(服务器:WIN-SRV103-116)
 日期:2024/10/15 12:05:24
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcSpa后端(000014, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433AGC_CS12
 PrjDataBaseId:0005
 模块中文名:函数管理(PrjFunction)
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
public static class  clsFunctionTemplateRelaBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public static clsFunctionTemplateRelaEN GetObj(this K_mId_FunctionTemplateRela myKey)
{
clsFunctionTemplateRelaEN objFunctionTemplateRelaEN = clsFunctionTemplateRelaBL.FunctionTemplateRelaDA.GetObjBymId(myKey.Value);
return objFunctionTemplateRelaEN;
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_AddNewRecord)
 /// </summary>
 /// <param name = "objFunctionTemplateRelaEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clsFunctionTemplateRelaEN objFunctionTemplateRelaEN, bool bolIsNeedCheckUniqueness = true)
{
if (bolIsNeedCheckUniqueness == true && CheckUniqueness(objFunctionTemplateRelaEN) == false)
{
var strMsg = string.Format("记录已经存在!代码类型Id = [{0}],函数ID = [{1}],函数模板Id = [{2}]的数据已经存在!(in clsFunctionTemplateRelaBL.AddNewRecord)", objFunctionTemplateRelaEN.CodeTypeId,objFunctionTemplateRelaEN.FuncId4GC,objFunctionTemplateRelaEN.FunctionTemplateId);
throw new Exception(strMsg);
}
try
{
bool bolResult = clsFunctionTemplateRelaBL.FunctionTemplateRelaDA.AddNewRecordBySQL2(objFunctionTemplateRelaEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsFunctionTemplateRelaBL.ReFreshCache();

if (clsFunctionTemplateRelaBL.relatedActions != null)
{
clsFunctionTemplateRelaBL.relatedActions.UpdRelaTabDate(objFunctionTemplateRelaEN.mId, objFunctionTemplateRelaEN.UpdUser);
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
public static bool AddRecordEx(this clsFunctionTemplateRelaEN objFunctionTemplateRelaEN, bool bolIsNeedCheckUniqueness = true)
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
objFunctionTemplateRelaEN.CheckPropertyNew();
 ///5.2、检查唯一性
if (bolIsNeedCheckUniqueness == true && objFunctionTemplateRelaEN.CheckUniqueness() == false)
{
strMsg = string.Format("(代码类型Id(CodeTypeId)=[{0}],函数ID(FuncId4GC)=[{1}],函数模板Id(FunctionTemplateId)=[{2}])已经存在,不能重复!", objFunctionTemplateRelaEN.CodeTypeId, objFunctionTemplateRelaEN.FuncId4GC, objFunctionTemplateRelaEN.FunctionTemplateId);
throw new Exception(strMsg);
}
//6、把数据实体层的数据存贮到数据库中
objFunctionTemplateRelaEN.AddNewRecord();
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
 /// <param name = "objFunctionTemplateRelaEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordWithReturnKey(this clsFunctionTemplateRelaEN objFunctionTemplateRelaEN, bool bolIsNeedCheckUniqueness = true)
{
if (bolIsNeedCheckUniqueness == true && CheckUniqueness(objFunctionTemplateRelaEN) == false)
{
var strMsg = string.Format("记录已经存在!代码类型Id = [{0}],函数ID = [{1}],函数模板Id = [{2}]的数据已经存在!(in clsFunctionTemplateRelaBL.AddNewRecordWithReturnKey)", objFunctionTemplateRelaEN.CodeTypeId,objFunctionTemplateRelaEN.FuncId4GC,objFunctionTemplateRelaEN.FunctionTemplateId);
throw new Exception(strMsg);
}
try
{
string strKey = clsFunctionTemplateRelaBL.FunctionTemplateRelaDA.AddNewRecordBySQL2WithReturnKey(objFunctionTemplateRelaEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsFunctionTemplateRelaBL.ReFreshCache();

if (clsFunctionTemplateRelaBL.relatedActions != null)
{
clsFunctionTemplateRelaBL.relatedActions.UpdRelaTabDate(objFunctionTemplateRelaEN.mId, objFunctionTemplateRelaEN.UpdUser);
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
 /// <param name = "objFunctionTemplateRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsFunctionTemplateRelaEN SetmId(this clsFunctionTemplateRelaEN objFunctionTemplateRelaEN, long lngmId, string strComparisonOp="")
	{
objFunctionTemplateRelaEN.mId = lngmId; //mId
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objFunctionTemplateRelaEN.dicFldComparisonOp.ContainsKey(conFunctionTemplateRela.mId) == false)
{
objFunctionTemplateRelaEN.dicFldComparisonOp.Add(conFunctionTemplateRela.mId, strComparisonOp);
}
else
{
objFunctionTemplateRelaEN.dicFldComparisonOp[conFunctionTemplateRela.mId] = strComparisonOp;
}
}
return objFunctionTemplateRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objFunctionTemplateRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsFunctionTemplateRelaEN SetFunctionTemplateId(this clsFunctionTemplateRelaEN objFunctionTemplateRelaEN, string strFunctionTemplateId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strFunctionTemplateId, conFunctionTemplateRela.FunctionTemplateId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFunctionTemplateId, 4, conFunctionTemplateRela.FunctionTemplateId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strFunctionTemplateId, 4, conFunctionTemplateRela.FunctionTemplateId);
}
objFunctionTemplateRelaEN.FunctionTemplateId = strFunctionTemplateId; //函数模板Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objFunctionTemplateRelaEN.dicFldComparisonOp.ContainsKey(conFunctionTemplateRela.FunctionTemplateId) == false)
{
objFunctionTemplateRelaEN.dicFldComparisonOp.Add(conFunctionTemplateRela.FunctionTemplateId, strComparisonOp);
}
else
{
objFunctionTemplateRelaEN.dicFldComparisonOp[conFunctionTemplateRela.FunctionTemplateId] = strComparisonOp;
}
}
return objFunctionTemplateRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objFunctionTemplateRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsFunctionTemplateRelaEN SetCodeTypeId(this clsFunctionTemplateRelaEN objFunctionTemplateRelaEN, string strCodeTypeId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCodeTypeId, 4, conFunctionTemplateRela.CodeTypeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strCodeTypeId, 4, conFunctionTemplateRela.CodeTypeId);
}
objFunctionTemplateRelaEN.CodeTypeId = strCodeTypeId; //代码类型Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objFunctionTemplateRelaEN.dicFldComparisonOp.ContainsKey(conFunctionTemplateRela.CodeTypeId) == false)
{
objFunctionTemplateRelaEN.dicFldComparisonOp.Add(conFunctionTemplateRela.CodeTypeId, strComparisonOp);
}
else
{
objFunctionTemplateRelaEN.dicFldComparisonOp[conFunctionTemplateRela.CodeTypeId] = strComparisonOp;
}
}
return objFunctionTemplateRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objFunctionTemplateRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsFunctionTemplateRelaEN SetRegionTypeId(this clsFunctionTemplateRelaEN objFunctionTemplateRelaEN, string strRegionTypeId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strRegionTypeId, 4, conFunctionTemplateRela.RegionTypeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strRegionTypeId, 4, conFunctionTemplateRela.RegionTypeId);
}
objFunctionTemplateRelaEN.RegionTypeId = strRegionTypeId; //区域类型Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objFunctionTemplateRelaEN.dicFldComparisonOp.ContainsKey(conFunctionTemplateRela.RegionTypeId) == false)
{
objFunctionTemplateRelaEN.dicFldComparisonOp.Add(conFunctionTemplateRela.RegionTypeId, strComparisonOp);
}
else
{
objFunctionTemplateRelaEN.dicFldComparisonOp[conFunctionTemplateRela.RegionTypeId] = strComparisonOp;
}
}
return objFunctionTemplateRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objFunctionTemplateRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsFunctionTemplateRelaEN SetFuncCodeTypeId(this clsFunctionTemplateRelaEN objFunctionTemplateRelaEN, string strFuncCodeTypeId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFuncCodeTypeId, 4, conFunctionTemplateRela.FuncCodeTypeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strFuncCodeTypeId, 4, conFunctionTemplateRela.FuncCodeTypeId);
}
objFunctionTemplateRelaEN.FuncCodeTypeId = strFuncCodeTypeId; //函数代码类型Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objFunctionTemplateRelaEN.dicFldComparisonOp.ContainsKey(conFunctionTemplateRela.FuncCodeTypeId) == false)
{
objFunctionTemplateRelaEN.dicFldComparisonOp.Add(conFunctionTemplateRela.FuncCodeTypeId, strComparisonOp);
}
else
{
objFunctionTemplateRelaEN.dicFldComparisonOp[conFunctionTemplateRela.FuncCodeTypeId] = strComparisonOp;
}
}
return objFunctionTemplateRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objFunctionTemplateRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsFunctionTemplateRelaEN SetFuncId4GC(this clsFunctionTemplateRelaEN objFunctionTemplateRelaEN, string strFuncId4GC, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strFuncId4GC, conFunctionTemplateRela.FuncId4GC);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFuncId4GC, 10, conFunctionTemplateRela.FuncId4GC);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strFuncId4GC, 10, conFunctionTemplateRela.FuncId4GC);
}
objFunctionTemplateRelaEN.FuncId4GC = strFuncId4GC; //函数ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objFunctionTemplateRelaEN.dicFldComparisonOp.ContainsKey(conFunctionTemplateRela.FuncId4GC) == false)
{
objFunctionTemplateRelaEN.dicFldComparisonOp.Add(conFunctionTemplateRela.FuncId4GC, strComparisonOp);
}
else
{
objFunctionTemplateRelaEN.dicFldComparisonOp[conFunctionTemplateRela.FuncId4GC] = strComparisonOp;
}
}
return objFunctionTemplateRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objFunctionTemplateRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsFunctionTemplateRelaEN SetIsGeneCode(this clsFunctionTemplateRelaEN objFunctionTemplateRelaEN, bool bolIsGeneCode, string strComparisonOp="")
	{
objFunctionTemplateRelaEN.IsGeneCode = bolIsGeneCode; //是否生成代码
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objFunctionTemplateRelaEN.dicFldComparisonOp.ContainsKey(conFunctionTemplateRela.IsGeneCode) == false)
{
objFunctionTemplateRelaEN.dicFldComparisonOp.Add(conFunctionTemplateRela.IsGeneCode, strComparisonOp);
}
else
{
objFunctionTemplateRelaEN.dicFldComparisonOp[conFunctionTemplateRela.IsGeneCode] = strComparisonOp;
}
}
return objFunctionTemplateRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objFunctionTemplateRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsFunctionTemplateRelaEN SetOrderNum(this clsFunctionTemplateRelaEN objFunctionTemplateRelaEN, int intOrderNum, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(intOrderNum, conFunctionTemplateRela.OrderNum);
objFunctionTemplateRelaEN.OrderNum = intOrderNum; //序号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objFunctionTemplateRelaEN.dicFldComparisonOp.ContainsKey(conFunctionTemplateRela.OrderNum) == false)
{
objFunctionTemplateRelaEN.dicFldComparisonOp.Add(conFunctionTemplateRela.OrderNum, strComparisonOp);
}
else
{
objFunctionTemplateRelaEN.dicFldComparisonOp[conFunctionTemplateRela.OrderNum] = strComparisonOp;
}
}
return objFunctionTemplateRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objFunctionTemplateRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsFunctionTemplateRelaEN SetUpdDate(this clsFunctionTemplateRelaEN objFunctionTemplateRelaEN, string strUpdDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdDate, 20, conFunctionTemplateRela.UpdDate);
}
objFunctionTemplateRelaEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objFunctionTemplateRelaEN.dicFldComparisonOp.ContainsKey(conFunctionTemplateRela.UpdDate) == false)
{
objFunctionTemplateRelaEN.dicFldComparisonOp.Add(conFunctionTemplateRela.UpdDate, strComparisonOp);
}
else
{
objFunctionTemplateRelaEN.dicFldComparisonOp[conFunctionTemplateRela.UpdDate] = strComparisonOp;
}
}
return objFunctionTemplateRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objFunctionTemplateRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsFunctionTemplateRelaEN SetUpdUser(this clsFunctionTemplateRelaEN objFunctionTemplateRelaEN, string strUpdUser, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdUser, 20, conFunctionTemplateRela.UpdUser);
}
objFunctionTemplateRelaEN.UpdUser = strUpdUser; //修改者
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objFunctionTemplateRelaEN.dicFldComparisonOp.ContainsKey(conFunctionTemplateRela.UpdUser) == false)
{
objFunctionTemplateRelaEN.dicFldComparisonOp.Add(conFunctionTemplateRela.UpdUser, strComparisonOp);
}
else
{
objFunctionTemplateRelaEN.dicFldComparisonOp[conFunctionTemplateRela.UpdUser] = strComparisonOp;
}
}
return objFunctionTemplateRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objFunctionTemplateRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsFunctionTemplateRelaEN SetMemo(this clsFunctionTemplateRelaEN objFunctionTemplateRelaEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, conFunctionTemplateRela.Memo);
}
objFunctionTemplateRelaEN.Memo = strMemo; //说明
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objFunctionTemplateRelaEN.dicFldComparisonOp.ContainsKey(conFunctionTemplateRela.Memo) == false)
{
objFunctionTemplateRelaEN.dicFldComparisonOp.Add(conFunctionTemplateRela.Memo, strComparisonOp);
}
else
{
objFunctionTemplateRelaEN.dicFldComparisonOp[conFunctionTemplateRela.Memo] = strComparisonOp;
}
}
return objFunctionTemplateRelaEN;
	}

 /// <summary>
 /// 修改记录存盘到数据表中
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_UpdateRecordEx)
 /// </summary>
 /// <param name = "objFunctionTemplateRelaEN">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool UpdateRecordEx(this clsFunctionTemplateRelaEN objFunctionTemplateRelaEN)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
try
{
//1、检查传进去的对象属性是否合法
objFunctionTemplateRelaEN.CheckPropertyNew();
clsFunctionTemplateRelaEN objFunctionTemplateRelaCond = new clsFunctionTemplateRelaEN();
string strCondition = objFunctionTemplateRelaCond
.SetmId(objFunctionTemplateRelaEN.mId, "<>")
.SetCodeTypeId(objFunctionTemplateRelaEN.CodeTypeId, "=")
.SetFuncId4GC(objFunctionTemplateRelaEN.FuncId4GC, "=")
.SetFunctionTemplateId(objFunctionTemplateRelaEN.FunctionTemplateId, "=")
.GetCombineCondition();
objFunctionTemplateRelaEN._IsCheckProperty = true;
bool bolIsExist = clsFunctionTemplateRelaBL.IsExistRecord(strCondition);
if (bolIsExist)
{
strMsg = "(CodeTypeId_FuncId4GC_FunctionTemplateId)不能重复!";
throw new Exception(strMsg);
}
//4、把数据实体层的数据存贮到数据库中
objFunctionTemplateRelaEN.Update();
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
 /// <param name = "objFunctionTemplateRela">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool EditRecordEx(this clsFunctionTemplateRelaEN objFunctionTemplateRela)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
clsFunctionTemplateRelaEN objFunctionTemplateRelaCond = new clsFunctionTemplateRelaEN();
string strCondition = objFunctionTemplateRelaCond
.SetCodeTypeId(objFunctionTemplateRela.CodeTypeId, "=")
.SetFuncId4GC(objFunctionTemplateRela.FuncId4GC, "=")
.SetFunctionTemplateId(objFunctionTemplateRela.FunctionTemplateId, "=")
.GetCombineCondition();
objFunctionTemplateRela._IsCheckProperty = true;
bool bolIsExist = clsFunctionTemplateRelaBL.IsExistRecord(strCondition);
if (bolIsExist)
{
objFunctionTemplateRela.mId = clsFunctionTemplateRelaBL.GetFirstID_S(strCondition);
objFunctionTemplateRela.UpdateWithCondition(strCondition);
}
else
{
objFunctionTemplateRela.AddNewRecord();
}
return true; 
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_Update)
 /// </summary>
 /// <param name = "objFunctionTemplateRelaEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsFunctionTemplateRelaEN objFunctionTemplateRelaEN)
{
 if (objFunctionTemplateRelaEN.mId == 0)
 {
string strMsg = string.Format("(errid:Busi000095)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsFunctionTemplateRelaBL.FunctionTemplateRelaDA.UpdateBySql2(objFunctionTemplateRelaEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsFunctionTemplateRelaBL.ReFreshCache();

if (clsFunctionTemplateRelaBL.relatedActions != null)
{
clsFunctionTemplateRelaBL.relatedActions.UpdRelaTabDate(objFunctionTemplateRelaEN.mId, objFunctionTemplateRelaEN.UpdUser);
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
 /// <param name = "objFunctionTemplateRelaEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsFunctionTemplateRelaEN objFunctionTemplateRelaEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (objFunctionTemplateRelaEN.mId == 0)
 {
string strMsg = string.Format("(errid:Busi000087)修改记录时关键字不能为空!(带事务处理)(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsFunctionTemplateRelaBL.FunctionTemplateRelaDA.UpdateBySql2(objFunctionTemplateRelaEN, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsFunctionTemplateRelaBL.ReFreshCache();

if (clsFunctionTemplateRelaBL.relatedActions != null)
{
clsFunctionTemplateRelaBL.relatedActions.UpdRelaTabDate(objFunctionTemplateRelaEN.mId, objFunctionTemplateRelaEN.UpdUser);
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
 /// <param name = "objFunctionTemplateRelaEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsFunctionTemplateRelaEN objFunctionTemplateRelaEN, string strWhereCond)
{
try
{
bool bolResult = clsFunctionTemplateRelaBL.FunctionTemplateRelaDA.UpdateBySqlWithCondition(objFunctionTemplateRelaEN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsFunctionTemplateRelaBL.ReFreshCache();

if (clsFunctionTemplateRelaBL.relatedActions != null)
{
clsFunctionTemplateRelaBL.relatedActions.UpdRelaTabDate(objFunctionTemplateRelaEN.mId, objFunctionTemplateRelaEN.UpdUser);
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
 /// <param name = "objFunctionTemplateRelaEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsFunctionTemplateRelaEN objFunctionTemplateRelaEN, string strWhereCond, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
bool bolResult = clsFunctionTemplateRelaBL.FunctionTemplateRelaDA.UpdateBySqlWithConditionTransaction(objFunctionTemplateRelaEN, strWhereCond, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsFunctionTemplateRelaBL.ReFreshCache();

if (clsFunctionTemplateRelaBL.relatedActions != null)
{
clsFunctionTemplateRelaBL.relatedActions.UpdRelaTabDate(objFunctionTemplateRelaEN.mId, objFunctionTemplateRelaEN.UpdUser);
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
public static int Delete(this clsFunctionTemplateRelaEN objFunctionTemplateRelaEN)
{
try
{
int intRecNum = clsFunctionTemplateRelaBL.FunctionTemplateRelaDA.DelRecord(objFunctionTemplateRelaEN.mId);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsFunctionTemplateRelaBL.ReFreshCache();

if (clsFunctionTemplateRelaBL.relatedActions != null)
{
clsFunctionTemplateRelaBL.relatedActions.UpdRelaTabDate(objFunctionTemplateRelaEN.mId, objFunctionTemplateRelaEN.UpdUser);
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
 /// <param name = "objFunctionTemplateRelaENS">源对象</param>
 /// <param name = "objFunctionTemplateRelaENT">目标对象</param>
 public static void CopyTo(this clsFunctionTemplateRelaEN objFunctionTemplateRelaENS, clsFunctionTemplateRelaEN objFunctionTemplateRelaENT)
{
try
{
objFunctionTemplateRelaENT.mId = objFunctionTemplateRelaENS.mId; //mId
objFunctionTemplateRelaENT.FunctionTemplateId = objFunctionTemplateRelaENS.FunctionTemplateId; //函数模板Id
objFunctionTemplateRelaENT.CodeTypeId = objFunctionTemplateRelaENS.CodeTypeId; //代码类型Id
objFunctionTemplateRelaENT.RegionTypeId = objFunctionTemplateRelaENS.RegionTypeId; //区域类型Id
objFunctionTemplateRelaENT.FuncCodeTypeId = objFunctionTemplateRelaENS.FuncCodeTypeId; //函数代码类型Id
objFunctionTemplateRelaENT.FuncId4GC = objFunctionTemplateRelaENS.FuncId4GC; //函数ID
objFunctionTemplateRelaENT.IsGeneCode = objFunctionTemplateRelaENS.IsGeneCode; //是否生成代码
objFunctionTemplateRelaENT.OrderNum = objFunctionTemplateRelaENS.OrderNum; //序号
objFunctionTemplateRelaENT.UpdDate = objFunctionTemplateRelaENS.UpdDate; //修改日期
objFunctionTemplateRelaENT.UpdUser = objFunctionTemplateRelaENS.UpdUser; //修改者
objFunctionTemplateRelaENT.Memo = objFunctionTemplateRelaENS.Memo; //说明
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
 /// <param name = "objFunctionTemplateRelaENS">源对象</param>
 /// <returns>目标对象=>clsFunctionTemplateRelaEN:objFunctionTemplateRelaENT</returns>
 public static clsFunctionTemplateRelaEN CopyTo(this clsFunctionTemplateRelaEN objFunctionTemplateRelaENS)
{
try
{
 clsFunctionTemplateRelaEN objFunctionTemplateRelaENT = new clsFunctionTemplateRelaEN()
{
mId = objFunctionTemplateRelaENS.mId, //mId
FunctionTemplateId = objFunctionTemplateRelaENS.FunctionTemplateId, //函数模板Id
CodeTypeId = objFunctionTemplateRelaENS.CodeTypeId, //代码类型Id
RegionTypeId = objFunctionTemplateRelaENS.RegionTypeId, //区域类型Id
FuncCodeTypeId = objFunctionTemplateRelaENS.FuncCodeTypeId, //函数代码类型Id
FuncId4GC = objFunctionTemplateRelaENS.FuncId4GC, //函数ID
IsGeneCode = objFunctionTemplateRelaENS.IsGeneCode, //是否生成代码
OrderNum = objFunctionTemplateRelaENS.OrderNum, //序号
UpdDate = objFunctionTemplateRelaENS.UpdDate, //修改日期
UpdUser = objFunctionTemplateRelaENS.UpdUser, //修改者
Memo = objFunctionTemplateRelaENS.Memo, //说明
};
 return objFunctionTemplateRelaENT;
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
public static void CheckPropertyNew(this clsFunctionTemplateRelaEN objFunctionTemplateRelaEN)
{
 clsFunctionTemplateRelaBL.FunctionTemplateRelaDA.CheckPropertyNew(objFunctionTemplateRelaEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(this clsFunctionTemplateRelaEN objFunctionTemplateRelaEN)
{
 clsFunctionTemplateRelaBL.FunctionTemplateRelaDA.CheckProperty4Condition(objFunctionTemplateRelaEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsFunctionTemplateRelaEN objFunctionTemplateRelaCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objFunctionTemplateRelaCond.IsUpdated(conFunctionTemplateRela.mId) == true)
{
string strComparisonOpmId = objFunctionTemplateRelaCond.dicFldComparisonOp[conFunctionTemplateRela.mId];
strWhereCond += string.Format(" And {0} {2} {1}", conFunctionTemplateRela.mId, objFunctionTemplateRelaCond.mId, strComparisonOpmId);
}
if (objFunctionTemplateRelaCond.IsUpdated(conFunctionTemplateRela.FunctionTemplateId) == true)
{
string strComparisonOpFunctionTemplateId = objFunctionTemplateRelaCond.dicFldComparisonOp[conFunctionTemplateRela.FunctionTemplateId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conFunctionTemplateRela.FunctionTemplateId, objFunctionTemplateRelaCond.FunctionTemplateId, strComparisonOpFunctionTemplateId);
}
if (objFunctionTemplateRelaCond.IsUpdated(conFunctionTemplateRela.CodeTypeId) == true)
{
string strComparisonOpCodeTypeId = objFunctionTemplateRelaCond.dicFldComparisonOp[conFunctionTemplateRela.CodeTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conFunctionTemplateRela.CodeTypeId, objFunctionTemplateRelaCond.CodeTypeId, strComparisonOpCodeTypeId);
}
if (objFunctionTemplateRelaCond.IsUpdated(conFunctionTemplateRela.RegionTypeId) == true)
{
string strComparisonOpRegionTypeId = objFunctionTemplateRelaCond.dicFldComparisonOp[conFunctionTemplateRela.RegionTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conFunctionTemplateRela.RegionTypeId, objFunctionTemplateRelaCond.RegionTypeId, strComparisonOpRegionTypeId);
}
if (objFunctionTemplateRelaCond.IsUpdated(conFunctionTemplateRela.FuncCodeTypeId) == true)
{
string strComparisonOpFuncCodeTypeId = objFunctionTemplateRelaCond.dicFldComparisonOp[conFunctionTemplateRela.FuncCodeTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conFunctionTemplateRela.FuncCodeTypeId, objFunctionTemplateRelaCond.FuncCodeTypeId, strComparisonOpFuncCodeTypeId);
}
if (objFunctionTemplateRelaCond.IsUpdated(conFunctionTemplateRela.FuncId4GC) == true)
{
string strComparisonOpFuncId4GC = objFunctionTemplateRelaCond.dicFldComparisonOp[conFunctionTemplateRela.FuncId4GC];
strWhereCond += string.Format(" And {0} {2} '{1}'", conFunctionTemplateRela.FuncId4GC, objFunctionTemplateRelaCond.FuncId4GC, strComparisonOpFuncId4GC);
}
if (objFunctionTemplateRelaCond.IsUpdated(conFunctionTemplateRela.IsGeneCode) == true)
{
if (objFunctionTemplateRelaCond.IsGeneCode == true)
{
strWhereCond += string.Format(" And {0} = '1'", conFunctionTemplateRela.IsGeneCode);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conFunctionTemplateRela.IsGeneCode);
}
}
if (objFunctionTemplateRelaCond.IsUpdated(conFunctionTemplateRela.OrderNum) == true)
{
string strComparisonOpOrderNum = objFunctionTemplateRelaCond.dicFldComparisonOp[conFunctionTemplateRela.OrderNum];
strWhereCond += string.Format(" And {0} {2} {1}", conFunctionTemplateRela.OrderNum, objFunctionTemplateRelaCond.OrderNum, strComparisonOpOrderNum);
}
if (objFunctionTemplateRelaCond.IsUpdated(conFunctionTemplateRela.UpdDate) == true)
{
string strComparisonOpUpdDate = objFunctionTemplateRelaCond.dicFldComparisonOp[conFunctionTemplateRela.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conFunctionTemplateRela.UpdDate, objFunctionTemplateRelaCond.UpdDate, strComparisonOpUpdDate);
}
if (objFunctionTemplateRelaCond.IsUpdated(conFunctionTemplateRela.UpdUser) == true)
{
string strComparisonOpUpdUser = objFunctionTemplateRelaCond.dicFldComparisonOp[conFunctionTemplateRela.UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", conFunctionTemplateRela.UpdUser, objFunctionTemplateRelaCond.UpdUser, strComparisonOpUpdUser);
}
if (objFunctionTemplateRelaCond.IsUpdated(conFunctionTemplateRela.Memo) == true)
{
string strComparisonOpMemo = objFunctionTemplateRelaCond.dicFldComparisonOp[conFunctionTemplateRela.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", conFunctionTemplateRela.Memo, objFunctionTemplateRelaCond.Memo, strComparisonOpMemo);
}
 return strWhereCond;
}

 /// <summary>
 /// 检查唯一性(Uniqueness)--FunctionTemplateRela(函数与模板关系), 如果不唯一,即存在相同的记录,就返回False
 /// 唯一性条件:CodeTypeId_FuncId4GC_FunctionTemplateId
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckConstraint)
 /// </summary>
 /// <param name = "objFunctionTemplateRelaEN">要求唯一的对象</param>
 /// <returns></returns>
public static bool CheckUniqueness(this clsFunctionTemplateRelaEN objFunctionTemplateRelaEN)
{
//检测记录是否存在
bool bolIsUniqueness;
StringBuilder sbCondition = new StringBuilder();
if (objFunctionTemplateRelaEN == null) return true;
if (objFunctionTemplateRelaEN.mId == 0)
{
sbCondition.AppendFormat("1 = 1");
 if (objFunctionTemplateRelaEN.CodeTypeId == null)
{
 sbCondition.AppendFormat(" and CodeTypeId is null", objFunctionTemplateRelaEN.CodeTypeId);
}
else
{
 sbCondition.AppendFormat(" and CodeTypeId = '{0}'", objFunctionTemplateRelaEN.CodeTypeId);
}
 sbCondition.AppendFormat(" and FuncId4GC = '{0}'", objFunctionTemplateRelaEN.FuncId4GC);
 sbCondition.AppendFormat(" and FunctionTemplateId = '{0}'", objFunctionTemplateRelaEN.FunctionTemplateId);
if (clsFunctionTemplateRelaBL.IsExistRecord(sbCondition.ToString())  ==  true)
{
 bolIsUniqueness = false;
}
else
{
 bolIsUniqueness = true;
}
}
 else {
sbCondition.AppendFormat("mId !=  {0}", objFunctionTemplateRelaEN.mId);
 sbCondition.AppendFormat(" and CodeTypeId = '{0}'", objFunctionTemplateRelaEN.CodeTypeId);
 sbCondition.AppendFormat(" and FuncId4GC = '{0}'", objFunctionTemplateRelaEN.FuncId4GC);
 sbCondition.AppendFormat(" and FunctionTemplateId = '{0}'", objFunctionTemplateRelaEN.FunctionTemplateId);
if (clsFunctionTemplateRelaBL.IsExistRecord(sbCondition.ToString())  ==  true)
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
 /// 获取唯一性条件串--FunctionTemplateRela(函数与模板关系), 即由对象中唯一性条件字段关键字与值组成的条件串
 /// 唯一性条件:CodeTypeId_FuncId4GC_FunctionTemplateId
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetConditionString4Constraint)
 /// </summary>
 /// <param name = "objFunctionTemplateRelaEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(this clsFunctionTemplateRelaEN objFunctionTemplateRelaEN)
{
//检测记录是否存在
StringBuilder sbCondition = new StringBuilder();
if (objFunctionTemplateRelaEN == null) return "";
if (objFunctionTemplateRelaEN.mId == 0)
{
sbCondition.AppendFormat("1 = 1");
 if (objFunctionTemplateRelaEN.CodeTypeId == null)
{
 sbCondition.AppendFormat(" and CodeTypeId is null", objFunctionTemplateRelaEN.CodeTypeId);
}
else
{
 sbCondition.AppendFormat(" and CodeTypeId = '{0}'", objFunctionTemplateRelaEN.CodeTypeId);
}
 sbCondition.AppendFormat(" and FuncId4GC = '{0}'", objFunctionTemplateRelaEN.FuncId4GC);
 sbCondition.AppendFormat(" and FunctionTemplateId = '{0}'", objFunctionTemplateRelaEN.FunctionTemplateId);
return sbCondition.ToString();
}
 else {
sbCondition.AppendFormat("mId !=  {0}", objFunctionTemplateRelaEN.mId);
 sbCondition.AppendFormat(" and CodeTypeId = '{0}'", objFunctionTemplateRelaEN.CodeTypeId);
 sbCondition.AppendFormat(" and FuncId4GC = '{0}'", objFunctionTemplateRelaEN.FuncId4GC);
 sbCondition.AppendFormat(" and FunctionTemplateId = '{0}'", objFunctionTemplateRelaEN.FunctionTemplateId);
 return sbCondition.ToString();
}
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_FunctionTemplateRela
{
public virtual bool UpdRelaTabDate(long lngmId, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// 函数与模板关系(FunctionTemplateRela)
 /// 数据源类型:表
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsFunctionTemplateRelaBL
{
public static RelatedActions_FunctionTemplateRela relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsFunctionTemplateRelaDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsFunctionTemplateRelaDA FunctionTemplateRelaDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsFunctionTemplateRelaDA();
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
 public clsFunctionTemplateRelaBL()
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
if (string.IsNullOrEmpty(clsFunctionTemplateRelaEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsFunctionTemplateRelaEN._ConnectString);
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
public static DataTable GetDataTable_FunctionTemplateRela(string strWhereCond)
{
DataTable objDT;
try
{
objDT = FunctionTemplateRelaDA.GetDataTable_FunctionTemplateRela(strWhereCond);
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
objDT = FunctionTemplateRelaDA.GetDataTable(strWhereCond);
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
objDT = FunctionTemplateRelaDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = FunctionTemplateRelaDA.GetDataTable(strWhereCond, strTabName);
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
objDT = FunctionTemplateRelaDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = FunctionTemplateRelaDA.GetDataTable_Top(objTopPara);
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
objDT = FunctionTemplateRelaDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = FunctionTemplateRelaDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = FunctionTemplateRelaDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
public static List<clsFunctionTemplateRelaEN> GetObjLstByMIdLst(List<long> arrMIdLst)
{
List<clsFunctionTemplateRelaEN> arrObjLst = new List<clsFunctionTemplateRelaEN>(); 
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
	clsFunctionTemplateRelaEN objFunctionTemplateRelaEN = new clsFunctionTemplateRelaEN();
try
{
objFunctionTemplateRelaEN.mId = Int32.Parse(objRow[conFunctionTemplateRela.mId].ToString().Trim()); //mId
objFunctionTemplateRelaEN.FunctionTemplateId = objRow[conFunctionTemplateRela.FunctionTemplateId].ToString().Trim(); //函数模板Id
objFunctionTemplateRelaEN.CodeTypeId = objRow[conFunctionTemplateRela.CodeTypeId] == DBNull.Value ? null : objRow[conFunctionTemplateRela.CodeTypeId].ToString().Trim(); //代码类型Id
objFunctionTemplateRelaEN.RegionTypeId = objRow[conFunctionTemplateRela.RegionTypeId] == DBNull.Value ? null : objRow[conFunctionTemplateRela.RegionTypeId].ToString().Trim(); //区域类型Id
objFunctionTemplateRelaEN.FuncCodeTypeId = objRow[conFunctionTemplateRela.FuncCodeTypeId] == DBNull.Value ? null : objRow[conFunctionTemplateRela.FuncCodeTypeId].ToString().Trim(); //函数代码类型Id
objFunctionTemplateRelaEN.FuncId4GC = objRow[conFunctionTemplateRela.FuncId4GC].ToString().Trim(); //函数ID
objFunctionTemplateRelaEN.IsGeneCode = clsEntityBase2.TransNullToBool_S(objRow[conFunctionTemplateRela.IsGeneCode].ToString().Trim()); //是否生成代码
objFunctionTemplateRelaEN.OrderNum = Int32.Parse(objRow[conFunctionTemplateRela.OrderNum].ToString().Trim()); //序号
objFunctionTemplateRelaEN.UpdDate = objRow[conFunctionTemplateRela.UpdDate] == DBNull.Value ? null : objRow[conFunctionTemplateRela.UpdDate].ToString().Trim(); //修改日期
objFunctionTemplateRelaEN.UpdUser = objRow[conFunctionTemplateRela.UpdUser] == DBNull.Value ? null : objRow[conFunctionTemplateRela.UpdUser].ToString().Trim(); //修改者
objFunctionTemplateRelaEN.Memo = objRow[conFunctionTemplateRela.Memo] == DBNull.Value ? null : objRow[conFunctionTemplateRela.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objFunctionTemplateRelaEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objFunctionTemplateRelaEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrMIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsFunctionTemplateRelaEN> GetObjLstByMIdLstCache(List<long> arrMIdLst)
{
string strKey = string.Format("{0}", clsFunctionTemplateRelaEN._CurrTabName);
List<clsFunctionTemplateRelaEN> arrFunctionTemplateRelaObjLstCache = GetObjLstCache();
IEnumerable <clsFunctionTemplateRelaEN> arrFunctionTemplateRelaObjLst_Sel =
arrFunctionTemplateRelaObjLstCache
.Where(x => arrMIdLst.Contains(x.mId));
return arrFunctionTemplateRelaObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsFunctionTemplateRelaEN> GetObjLst(string strWhereCond)
{
List<clsFunctionTemplateRelaEN> arrObjLst = new List<clsFunctionTemplateRelaEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsFunctionTemplateRelaEN objFunctionTemplateRelaEN = new clsFunctionTemplateRelaEN();
try
{
objFunctionTemplateRelaEN.mId = Int32.Parse(objRow[conFunctionTemplateRela.mId].ToString().Trim()); //mId
objFunctionTemplateRelaEN.FunctionTemplateId = objRow[conFunctionTemplateRela.FunctionTemplateId].ToString().Trim(); //函数模板Id
objFunctionTemplateRelaEN.CodeTypeId = objRow[conFunctionTemplateRela.CodeTypeId] == DBNull.Value ? null : objRow[conFunctionTemplateRela.CodeTypeId].ToString().Trim(); //代码类型Id
objFunctionTemplateRelaEN.RegionTypeId = objRow[conFunctionTemplateRela.RegionTypeId] == DBNull.Value ? null : objRow[conFunctionTemplateRela.RegionTypeId].ToString().Trim(); //区域类型Id
objFunctionTemplateRelaEN.FuncCodeTypeId = objRow[conFunctionTemplateRela.FuncCodeTypeId] == DBNull.Value ? null : objRow[conFunctionTemplateRela.FuncCodeTypeId].ToString().Trim(); //函数代码类型Id
objFunctionTemplateRelaEN.FuncId4GC = objRow[conFunctionTemplateRela.FuncId4GC].ToString().Trim(); //函数ID
objFunctionTemplateRelaEN.IsGeneCode = clsEntityBase2.TransNullToBool_S(objRow[conFunctionTemplateRela.IsGeneCode].ToString().Trim()); //是否生成代码
objFunctionTemplateRelaEN.OrderNum = Int32.Parse(objRow[conFunctionTemplateRela.OrderNum].ToString().Trim()); //序号
objFunctionTemplateRelaEN.UpdDate = objRow[conFunctionTemplateRela.UpdDate] == DBNull.Value ? null : objRow[conFunctionTemplateRela.UpdDate].ToString().Trim(); //修改日期
objFunctionTemplateRelaEN.UpdUser = objRow[conFunctionTemplateRela.UpdUser] == DBNull.Value ? null : objRow[conFunctionTemplateRela.UpdUser].ToString().Trim(); //修改者
objFunctionTemplateRelaEN.Memo = objRow[conFunctionTemplateRela.Memo] == DBNull.Value ? null : objRow[conFunctionTemplateRela.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objFunctionTemplateRelaEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objFunctionTemplateRelaEN);
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
public static List<clsFunctionTemplateRelaEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsFunctionTemplateRelaEN> arrObjLst = new List<clsFunctionTemplateRelaEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsFunctionTemplateRelaEN objFunctionTemplateRelaEN = new clsFunctionTemplateRelaEN();
try
{
objFunctionTemplateRelaEN.mId = Int32.Parse(objRow[conFunctionTemplateRela.mId].ToString().Trim()); //mId
objFunctionTemplateRelaEN.FunctionTemplateId = objRow[conFunctionTemplateRela.FunctionTemplateId].ToString().Trim(); //函数模板Id
objFunctionTemplateRelaEN.CodeTypeId = objRow[conFunctionTemplateRela.CodeTypeId] == DBNull.Value ? null : objRow[conFunctionTemplateRela.CodeTypeId].ToString().Trim(); //代码类型Id
objFunctionTemplateRelaEN.RegionTypeId = objRow[conFunctionTemplateRela.RegionTypeId] == DBNull.Value ? null : objRow[conFunctionTemplateRela.RegionTypeId].ToString().Trim(); //区域类型Id
objFunctionTemplateRelaEN.FuncCodeTypeId = objRow[conFunctionTemplateRela.FuncCodeTypeId] == DBNull.Value ? null : objRow[conFunctionTemplateRela.FuncCodeTypeId].ToString().Trim(); //函数代码类型Id
objFunctionTemplateRelaEN.FuncId4GC = objRow[conFunctionTemplateRela.FuncId4GC].ToString().Trim(); //函数ID
objFunctionTemplateRelaEN.IsGeneCode = clsEntityBase2.TransNullToBool_S(objRow[conFunctionTemplateRela.IsGeneCode].ToString().Trim()); //是否生成代码
objFunctionTemplateRelaEN.OrderNum = Int32.Parse(objRow[conFunctionTemplateRela.OrderNum].ToString().Trim()); //序号
objFunctionTemplateRelaEN.UpdDate = objRow[conFunctionTemplateRela.UpdDate] == DBNull.Value ? null : objRow[conFunctionTemplateRela.UpdDate].ToString().Trim(); //修改日期
objFunctionTemplateRelaEN.UpdUser = objRow[conFunctionTemplateRela.UpdUser] == DBNull.Value ? null : objRow[conFunctionTemplateRela.UpdUser].ToString().Trim(); //修改者
objFunctionTemplateRelaEN.Memo = objRow[conFunctionTemplateRela.Memo] == DBNull.Value ? null : objRow[conFunctionTemplateRela.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objFunctionTemplateRelaEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objFunctionTemplateRelaEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objFunctionTemplateRelaCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsFunctionTemplateRelaEN> GetSubObjLstCache(clsFunctionTemplateRelaEN objFunctionTemplateRelaCond)
{
List<clsFunctionTemplateRelaEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsFunctionTemplateRelaEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conFunctionTemplateRela.AttributeName)
{
if (objFunctionTemplateRelaCond.IsUpdated(strFldName) == false) continue;
if (objFunctionTemplateRelaCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objFunctionTemplateRelaCond[strFldName].ToString());
}
else
{
if (objFunctionTemplateRelaCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objFunctionTemplateRelaCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objFunctionTemplateRelaCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objFunctionTemplateRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objFunctionTemplateRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objFunctionTemplateRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objFunctionTemplateRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objFunctionTemplateRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objFunctionTemplateRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objFunctionTemplateRelaCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objFunctionTemplateRelaCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objFunctionTemplateRelaCond[strFldName]));
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
public static List<clsFunctionTemplateRelaEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsFunctionTemplateRelaEN> arrObjLst = new List<clsFunctionTemplateRelaEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsFunctionTemplateRelaEN objFunctionTemplateRelaEN = new clsFunctionTemplateRelaEN();
try
{
objFunctionTemplateRelaEN.mId = Int32.Parse(objRow[conFunctionTemplateRela.mId].ToString().Trim()); //mId
objFunctionTemplateRelaEN.FunctionTemplateId = objRow[conFunctionTemplateRela.FunctionTemplateId].ToString().Trim(); //函数模板Id
objFunctionTemplateRelaEN.CodeTypeId = objRow[conFunctionTemplateRela.CodeTypeId] == DBNull.Value ? null : objRow[conFunctionTemplateRela.CodeTypeId].ToString().Trim(); //代码类型Id
objFunctionTemplateRelaEN.RegionTypeId = objRow[conFunctionTemplateRela.RegionTypeId] == DBNull.Value ? null : objRow[conFunctionTemplateRela.RegionTypeId].ToString().Trim(); //区域类型Id
objFunctionTemplateRelaEN.FuncCodeTypeId = objRow[conFunctionTemplateRela.FuncCodeTypeId] == DBNull.Value ? null : objRow[conFunctionTemplateRela.FuncCodeTypeId].ToString().Trim(); //函数代码类型Id
objFunctionTemplateRelaEN.FuncId4GC = objRow[conFunctionTemplateRela.FuncId4GC].ToString().Trim(); //函数ID
objFunctionTemplateRelaEN.IsGeneCode = clsEntityBase2.TransNullToBool_S(objRow[conFunctionTemplateRela.IsGeneCode].ToString().Trim()); //是否生成代码
objFunctionTemplateRelaEN.OrderNum = Int32.Parse(objRow[conFunctionTemplateRela.OrderNum].ToString().Trim()); //序号
objFunctionTemplateRelaEN.UpdDate = objRow[conFunctionTemplateRela.UpdDate] == DBNull.Value ? null : objRow[conFunctionTemplateRela.UpdDate].ToString().Trim(); //修改日期
objFunctionTemplateRelaEN.UpdUser = objRow[conFunctionTemplateRela.UpdUser] == DBNull.Value ? null : objRow[conFunctionTemplateRela.UpdUser].ToString().Trim(); //修改者
objFunctionTemplateRelaEN.Memo = objRow[conFunctionTemplateRela.Memo] == DBNull.Value ? null : objRow[conFunctionTemplateRela.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objFunctionTemplateRelaEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objFunctionTemplateRelaEN);
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
public static List<clsFunctionTemplateRelaEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsFunctionTemplateRelaEN> arrObjLst = new List<clsFunctionTemplateRelaEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsFunctionTemplateRelaEN objFunctionTemplateRelaEN = new clsFunctionTemplateRelaEN();
try
{
objFunctionTemplateRelaEN.mId = Int32.Parse(objRow[conFunctionTemplateRela.mId].ToString().Trim()); //mId
objFunctionTemplateRelaEN.FunctionTemplateId = objRow[conFunctionTemplateRela.FunctionTemplateId].ToString().Trim(); //函数模板Id
objFunctionTemplateRelaEN.CodeTypeId = objRow[conFunctionTemplateRela.CodeTypeId] == DBNull.Value ? null : objRow[conFunctionTemplateRela.CodeTypeId].ToString().Trim(); //代码类型Id
objFunctionTemplateRelaEN.RegionTypeId = objRow[conFunctionTemplateRela.RegionTypeId] == DBNull.Value ? null : objRow[conFunctionTemplateRela.RegionTypeId].ToString().Trim(); //区域类型Id
objFunctionTemplateRelaEN.FuncCodeTypeId = objRow[conFunctionTemplateRela.FuncCodeTypeId] == DBNull.Value ? null : objRow[conFunctionTemplateRela.FuncCodeTypeId].ToString().Trim(); //函数代码类型Id
objFunctionTemplateRelaEN.FuncId4GC = objRow[conFunctionTemplateRela.FuncId4GC].ToString().Trim(); //函数ID
objFunctionTemplateRelaEN.IsGeneCode = clsEntityBase2.TransNullToBool_S(objRow[conFunctionTemplateRela.IsGeneCode].ToString().Trim()); //是否生成代码
objFunctionTemplateRelaEN.OrderNum = Int32.Parse(objRow[conFunctionTemplateRela.OrderNum].ToString().Trim()); //序号
objFunctionTemplateRelaEN.UpdDate = objRow[conFunctionTemplateRela.UpdDate] == DBNull.Value ? null : objRow[conFunctionTemplateRela.UpdDate].ToString().Trim(); //修改日期
objFunctionTemplateRelaEN.UpdUser = objRow[conFunctionTemplateRela.UpdUser] == DBNull.Value ? null : objRow[conFunctionTemplateRela.UpdUser].ToString().Trim(); //修改者
objFunctionTemplateRelaEN.Memo = objRow[conFunctionTemplateRela.Memo] == DBNull.Value ? null : objRow[conFunctionTemplateRela.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objFunctionTemplateRelaEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objFunctionTemplateRelaEN);
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
List<clsFunctionTemplateRelaEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsFunctionTemplateRelaEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsFunctionTemplateRelaEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsFunctionTemplateRelaEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsFunctionTemplateRelaEN> arrObjLst = new List<clsFunctionTemplateRelaEN>(); 
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
	clsFunctionTemplateRelaEN objFunctionTemplateRelaEN = new clsFunctionTemplateRelaEN();
try
{
objFunctionTemplateRelaEN.mId = Int32.Parse(objRow[conFunctionTemplateRela.mId].ToString().Trim()); //mId
objFunctionTemplateRelaEN.FunctionTemplateId = objRow[conFunctionTemplateRela.FunctionTemplateId].ToString().Trim(); //函数模板Id
objFunctionTemplateRelaEN.CodeTypeId = objRow[conFunctionTemplateRela.CodeTypeId] == DBNull.Value ? null : objRow[conFunctionTemplateRela.CodeTypeId].ToString().Trim(); //代码类型Id
objFunctionTemplateRelaEN.RegionTypeId = objRow[conFunctionTemplateRela.RegionTypeId] == DBNull.Value ? null : objRow[conFunctionTemplateRela.RegionTypeId].ToString().Trim(); //区域类型Id
objFunctionTemplateRelaEN.FuncCodeTypeId = objRow[conFunctionTemplateRela.FuncCodeTypeId] == DBNull.Value ? null : objRow[conFunctionTemplateRela.FuncCodeTypeId].ToString().Trim(); //函数代码类型Id
objFunctionTemplateRelaEN.FuncId4GC = objRow[conFunctionTemplateRela.FuncId4GC].ToString().Trim(); //函数ID
objFunctionTemplateRelaEN.IsGeneCode = clsEntityBase2.TransNullToBool_S(objRow[conFunctionTemplateRela.IsGeneCode].ToString().Trim()); //是否生成代码
objFunctionTemplateRelaEN.OrderNum = Int32.Parse(objRow[conFunctionTemplateRela.OrderNum].ToString().Trim()); //序号
objFunctionTemplateRelaEN.UpdDate = objRow[conFunctionTemplateRela.UpdDate] == DBNull.Value ? null : objRow[conFunctionTemplateRela.UpdDate].ToString().Trim(); //修改日期
objFunctionTemplateRelaEN.UpdUser = objRow[conFunctionTemplateRela.UpdUser] == DBNull.Value ? null : objRow[conFunctionTemplateRela.UpdUser].ToString().Trim(); //修改者
objFunctionTemplateRelaEN.Memo = objRow[conFunctionTemplateRela.Memo] == DBNull.Value ? null : objRow[conFunctionTemplateRela.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objFunctionTemplateRelaEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objFunctionTemplateRelaEN);
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
public static List<clsFunctionTemplateRelaEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsFunctionTemplateRelaEN> arrObjLst = new List<clsFunctionTemplateRelaEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsFunctionTemplateRelaEN objFunctionTemplateRelaEN = new clsFunctionTemplateRelaEN();
try
{
objFunctionTemplateRelaEN.mId = Int32.Parse(objRow[conFunctionTemplateRela.mId].ToString().Trim()); //mId
objFunctionTemplateRelaEN.FunctionTemplateId = objRow[conFunctionTemplateRela.FunctionTemplateId].ToString().Trim(); //函数模板Id
objFunctionTemplateRelaEN.CodeTypeId = objRow[conFunctionTemplateRela.CodeTypeId] == DBNull.Value ? null : objRow[conFunctionTemplateRela.CodeTypeId].ToString().Trim(); //代码类型Id
objFunctionTemplateRelaEN.RegionTypeId = objRow[conFunctionTemplateRela.RegionTypeId] == DBNull.Value ? null : objRow[conFunctionTemplateRela.RegionTypeId].ToString().Trim(); //区域类型Id
objFunctionTemplateRelaEN.FuncCodeTypeId = objRow[conFunctionTemplateRela.FuncCodeTypeId] == DBNull.Value ? null : objRow[conFunctionTemplateRela.FuncCodeTypeId].ToString().Trim(); //函数代码类型Id
objFunctionTemplateRelaEN.FuncId4GC = objRow[conFunctionTemplateRela.FuncId4GC].ToString().Trim(); //函数ID
objFunctionTemplateRelaEN.IsGeneCode = clsEntityBase2.TransNullToBool_S(objRow[conFunctionTemplateRela.IsGeneCode].ToString().Trim()); //是否生成代码
objFunctionTemplateRelaEN.OrderNum = Int32.Parse(objRow[conFunctionTemplateRela.OrderNum].ToString().Trim()); //序号
objFunctionTemplateRelaEN.UpdDate = objRow[conFunctionTemplateRela.UpdDate] == DBNull.Value ? null : objRow[conFunctionTemplateRela.UpdDate].ToString().Trim(); //修改日期
objFunctionTemplateRelaEN.UpdUser = objRow[conFunctionTemplateRela.UpdUser] == DBNull.Value ? null : objRow[conFunctionTemplateRela.UpdUser].ToString().Trim(); //修改者
objFunctionTemplateRelaEN.Memo = objRow[conFunctionTemplateRela.Memo] == DBNull.Value ? null : objRow[conFunctionTemplateRela.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objFunctionTemplateRelaEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objFunctionTemplateRelaEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsFunctionTemplateRelaEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsFunctionTemplateRelaEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsFunctionTemplateRelaEN> arrObjLst = new List<clsFunctionTemplateRelaEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsFunctionTemplateRelaEN objFunctionTemplateRelaEN = new clsFunctionTemplateRelaEN();
try
{
objFunctionTemplateRelaEN.mId = Int32.Parse(objRow[conFunctionTemplateRela.mId].ToString().Trim()); //mId
objFunctionTemplateRelaEN.FunctionTemplateId = objRow[conFunctionTemplateRela.FunctionTemplateId].ToString().Trim(); //函数模板Id
objFunctionTemplateRelaEN.CodeTypeId = objRow[conFunctionTemplateRela.CodeTypeId] == DBNull.Value ? null : objRow[conFunctionTemplateRela.CodeTypeId].ToString().Trim(); //代码类型Id
objFunctionTemplateRelaEN.RegionTypeId = objRow[conFunctionTemplateRela.RegionTypeId] == DBNull.Value ? null : objRow[conFunctionTemplateRela.RegionTypeId].ToString().Trim(); //区域类型Id
objFunctionTemplateRelaEN.FuncCodeTypeId = objRow[conFunctionTemplateRela.FuncCodeTypeId] == DBNull.Value ? null : objRow[conFunctionTemplateRela.FuncCodeTypeId].ToString().Trim(); //函数代码类型Id
objFunctionTemplateRelaEN.FuncId4GC = objRow[conFunctionTemplateRela.FuncId4GC].ToString().Trim(); //函数ID
objFunctionTemplateRelaEN.IsGeneCode = clsEntityBase2.TransNullToBool_S(objRow[conFunctionTemplateRela.IsGeneCode].ToString().Trim()); //是否生成代码
objFunctionTemplateRelaEN.OrderNum = Int32.Parse(objRow[conFunctionTemplateRela.OrderNum].ToString().Trim()); //序号
objFunctionTemplateRelaEN.UpdDate = objRow[conFunctionTemplateRela.UpdDate] == DBNull.Value ? null : objRow[conFunctionTemplateRela.UpdDate].ToString().Trim(); //修改日期
objFunctionTemplateRelaEN.UpdUser = objRow[conFunctionTemplateRela.UpdUser] == DBNull.Value ? null : objRow[conFunctionTemplateRela.UpdUser].ToString().Trim(); //修改者
objFunctionTemplateRelaEN.Memo = objRow[conFunctionTemplateRela.Memo] == DBNull.Value ? null : objRow[conFunctionTemplateRela.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objFunctionTemplateRelaEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objFunctionTemplateRelaEN);
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
public static List<clsFunctionTemplateRelaEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsFunctionTemplateRelaEN> arrObjLst = new List<clsFunctionTemplateRelaEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsFunctionTemplateRelaEN objFunctionTemplateRelaEN = new clsFunctionTemplateRelaEN();
try
{
objFunctionTemplateRelaEN.mId = Int32.Parse(objRow[conFunctionTemplateRela.mId].ToString().Trim()); //mId
objFunctionTemplateRelaEN.FunctionTemplateId = objRow[conFunctionTemplateRela.FunctionTemplateId].ToString().Trim(); //函数模板Id
objFunctionTemplateRelaEN.CodeTypeId = objRow[conFunctionTemplateRela.CodeTypeId] == DBNull.Value ? null : objRow[conFunctionTemplateRela.CodeTypeId].ToString().Trim(); //代码类型Id
objFunctionTemplateRelaEN.RegionTypeId = objRow[conFunctionTemplateRela.RegionTypeId] == DBNull.Value ? null : objRow[conFunctionTemplateRela.RegionTypeId].ToString().Trim(); //区域类型Id
objFunctionTemplateRelaEN.FuncCodeTypeId = objRow[conFunctionTemplateRela.FuncCodeTypeId] == DBNull.Value ? null : objRow[conFunctionTemplateRela.FuncCodeTypeId].ToString().Trim(); //函数代码类型Id
objFunctionTemplateRelaEN.FuncId4GC = objRow[conFunctionTemplateRela.FuncId4GC].ToString().Trim(); //函数ID
objFunctionTemplateRelaEN.IsGeneCode = clsEntityBase2.TransNullToBool_S(objRow[conFunctionTemplateRela.IsGeneCode].ToString().Trim()); //是否生成代码
objFunctionTemplateRelaEN.OrderNum = Int32.Parse(objRow[conFunctionTemplateRela.OrderNum].ToString().Trim()); //序号
objFunctionTemplateRelaEN.UpdDate = objRow[conFunctionTemplateRela.UpdDate] == DBNull.Value ? null : objRow[conFunctionTemplateRela.UpdDate].ToString().Trim(); //修改日期
objFunctionTemplateRelaEN.UpdUser = objRow[conFunctionTemplateRela.UpdUser] == DBNull.Value ? null : objRow[conFunctionTemplateRela.UpdUser].ToString().Trim(); //修改者
objFunctionTemplateRelaEN.Memo = objRow[conFunctionTemplateRela.Memo] == DBNull.Value ? null : objRow[conFunctionTemplateRela.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objFunctionTemplateRelaEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objFunctionTemplateRelaEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsFunctionTemplateRelaEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsFunctionTemplateRelaEN> arrObjLst = new List<clsFunctionTemplateRelaEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsFunctionTemplateRelaEN objFunctionTemplateRelaEN = new clsFunctionTemplateRelaEN();
try
{
objFunctionTemplateRelaEN.mId = Int32.Parse(objRow[conFunctionTemplateRela.mId].ToString().Trim()); //mId
objFunctionTemplateRelaEN.FunctionTemplateId = objRow[conFunctionTemplateRela.FunctionTemplateId].ToString().Trim(); //函数模板Id
objFunctionTemplateRelaEN.CodeTypeId = objRow[conFunctionTemplateRela.CodeTypeId] == DBNull.Value ? null : objRow[conFunctionTemplateRela.CodeTypeId].ToString().Trim(); //代码类型Id
objFunctionTemplateRelaEN.RegionTypeId = objRow[conFunctionTemplateRela.RegionTypeId] == DBNull.Value ? null : objRow[conFunctionTemplateRela.RegionTypeId].ToString().Trim(); //区域类型Id
objFunctionTemplateRelaEN.FuncCodeTypeId = objRow[conFunctionTemplateRela.FuncCodeTypeId] == DBNull.Value ? null : objRow[conFunctionTemplateRela.FuncCodeTypeId].ToString().Trim(); //函数代码类型Id
objFunctionTemplateRelaEN.FuncId4GC = objRow[conFunctionTemplateRela.FuncId4GC].ToString().Trim(); //函数ID
objFunctionTemplateRelaEN.IsGeneCode = clsEntityBase2.TransNullToBool_S(objRow[conFunctionTemplateRela.IsGeneCode].ToString().Trim()); //是否生成代码
objFunctionTemplateRelaEN.OrderNum = Int32.Parse(objRow[conFunctionTemplateRela.OrderNum].ToString().Trim()); //序号
objFunctionTemplateRelaEN.UpdDate = objRow[conFunctionTemplateRela.UpdDate] == DBNull.Value ? null : objRow[conFunctionTemplateRela.UpdDate].ToString().Trim(); //修改日期
objFunctionTemplateRelaEN.UpdUser = objRow[conFunctionTemplateRela.UpdUser] == DBNull.Value ? null : objRow[conFunctionTemplateRela.UpdUser].ToString().Trim(); //修改者
objFunctionTemplateRelaEN.Memo = objRow[conFunctionTemplateRela.Memo] == DBNull.Value ? null : objRow[conFunctionTemplateRela.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objFunctionTemplateRelaEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objFunctionTemplateRelaEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objFunctionTemplateRelaEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetFunctionTemplateRela(ref clsFunctionTemplateRelaEN objFunctionTemplateRelaEN)
{
bool bolResult = FunctionTemplateRelaDA.GetFunctionTemplateRela(ref objFunctionTemplateRelaEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public static clsFunctionTemplateRelaEN GetObjBymId(long lngmId)
{
clsFunctionTemplateRelaEN objFunctionTemplateRelaEN = FunctionTemplateRelaDA.GetObjBymId(lngmId);
return objFunctionTemplateRelaEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsFunctionTemplateRelaEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsFunctionTemplateRelaEN objFunctionTemplateRelaEN = FunctionTemplateRelaDA.GetFirstObj(strWhereCond);
 return objFunctionTemplateRelaEN;
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
public static clsFunctionTemplateRelaEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsFunctionTemplateRelaEN objFunctionTemplateRelaEN = FunctionTemplateRelaDA.GetObjByDataRow(objRow);
 return objFunctionTemplateRelaEN;
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
public static clsFunctionTemplateRelaEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsFunctionTemplateRelaEN objFunctionTemplateRelaEN = FunctionTemplateRelaDA.GetObjByDataRow(objRow);
 return objFunctionTemplateRelaEN;
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
 /// <param name = "lstFunctionTemplateRelaObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsFunctionTemplateRelaEN GetObjBymIdFromList(long lngmId, List<clsFunctionTemplateRelaEN> lstFunctionTemplateRelaObjLst)
{
foreach (clsFunctionTemplateRelaEN objFunctionTemplateRelaEN in lstFunctionTemplateRelaObjLst)
{
if (objFunctionTemplateRelaEN.mId == lngmId)
{
return objFunctionTemplateRelaEN;
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
 lngmId = new clsFunctionTemplateRelaDA().GetFirstID(strWhereCond);
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
 arrList = FunctionTemplateRelaDA.GetID(strWhereCond);
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
bool bolIsExist = FunctionTemplateRelaDA.IsExistCondRec(strWhereCond);
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
bool bolIsExist = FunctionTemplateRelaDA.IsExist(lngmId);
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
clsFunctionTemplateRelaEN objFunctionTemplateRelaEN = clsFunctionTemplateRelaBL.GetObjBymId(lngmId);
objFunctionTemplateRelaEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
objFunctionTemplateRelaEN.UpdUser = strOpUser;
return clsFunctionTemplateRelaBL.UpdateBySql2(objFunctionTemplateRelaEN);
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
 bolIsExist = clsFunctionTemplateRelaDA.IsExistTable();
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
 bolIsExist = FunctionTemplateRelaDA.IsExistTable(strTabName);
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
 /// <param name = "objFunctionTemplateRelaEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecordBySql2(clsFunctionTemplateRelaEN objFunctionTemplateRelaEN, bool bolIsNeedCheckUniqueness=true)
{
if (bolIsNeedCheckUniqueness == true && objFunctionTemplateRelaEN.CheckUniqueness() == false)
{
var strMsg = string.Format("记录已经存在!代码类型Id = [{0}],函数ID = [{1}],函数模板Id = [{2}]的数据已经存在!(in clsFunctionTemplateRelaBL.AddNewRecordBySql2)", objFunctionTemplateRelaEN.CodeTypeId,objFunctionTemplateRelaEN.FuncId4GC,objFunctionTemplateRelaEN.FunctionTemplateId);
throw new Exception(strMsg);
}
try
{
bool bolResult = FunctionTemplateRelaDA.AddNewRecordBySQL2(objFunctionTemplateRelaEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsFunctionTemplateRelaBL.ReFreshCache();

if (clsFunctionTemplateRelaBL.relatedActions != null)
{
clsFunctionTemplateRelaBL.relatedActions.UpdRelaTabDate(objFunctionTemplateRelaEN.mId, objFunctionTemplateRelaEN.UpdUser);
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
 /// <param name = "objFunctionTemplateRelaEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordBySql2WithReturnKey(clsFunctionTemplateRelaEN objFunctionTemplateRelaEN, bool bolIsNeedCheckUniqueness=true)
{
if (bolIsNeedCheckUniqueness == true && objFunctionTemplateRelaEN.CheckUniqueness() == false)
{
var strMsg = string.Format("记录已经存在!代码类型Id = [{0}],函数ID = [{1}],函数模板Id = [{2}]的数据已经存在!(in clsFunctionTemplateRelaBL.AddNewRecordBySql2WithReturnKey)", objFunctionTemplateRelaEN.CodeTypeId,objFunctionTemplateRelaEN.FuncId4GC,objFunctionTemplateRelaEN.FunctionTemplateId);
throw new Exception(strMsg);
}
try
{
string strKey = FunctionTemplateRelaDA.AddNewRecordBySQL2WithReturnKey(objFunctionTemplateRelaEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsFunctionTemplateRelaBL.ReFreshCache();

if (clsFunctionTemplateRelaBL.relatedActions != null)
{
clsFunctionTemplateRelaBL.relatedActions.UpdRelaTabDate(objFunctionTemplateRelaEN.mId, objFunctionTemplateRelaEN.UpdUser);
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
 /// <param name = "objFunctionTemplateRelaEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(clsFunctionTemplateRelaEN objFunctionTemplateRelaEN)
{
try
{
bool bolResult = FunctionTemplateRelaDA.Update(objFunctionTemplateRelaEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsFunctionTemplateRelaBL.ReFreshCache();

if (clsFunctionTemplateRelaBL.relatedActions != null)
{
clsFunctionTemplateRelaBL.relatedActions.UpdRelaTabDate(objFunctionTemplateRelaEN.mId, objFunctionTemplateRelaEN.UpdUser);
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
 /// <param name = "objFunctionTemplateRelaEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateBySql2(clsFunctionTemplateRelaEN objFunctionTemplateRelaEN)
{
 if (objFunctionTemplateRelaEN.mId == 0)
 {
var strMsg = string.Format("(errid:Busi000065)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = FunctionTemplateRelaDA.UpdateBySql2(objFunctionTemplateRelaEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsFunctionTemplateRelaBL.ReFreshCache();

if (clsFunctionTemplateRelaBL.relatedActions != null)
{
clsFunctionTemplateRelaBL.relatedActions.UpdRelaTabDate(objFunctionTemplateRelaEN.mId, objFunctionTemplateRelaEN.UpdUser);
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
 clsFunctionTemplateRelaEN objFunctionTemplateRelaEN = clsFunctionTemplateRelaBL.GetObjBymId(lngmId);

if (clsFunctionTemplateRelaBL.relatedActions != null)
{
clsFunctionTemplateRelaBL.relatedActions.UpdRelaTabDate(objFunctionTemplateRelaEN.mId, objFunctionTemplateRelaEN.UpdUser);
}
if (objFunctionTemplateRelaEN != null)
{
int intRecNum = FunctionTemplateRelaDA.DelRecord(lngmId);
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
objSQL = clsFunctionTemplateRelaDA.GetSpecSQLObj();
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
//删除与表:[FunctionTemplateRela]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conFunctionTemplateRela.mId,
//lngmId);
//        clsFunctionTemplateRelaBL.DelFunctionTemplateRelasByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsFunctionTemplateRelaBL.DelRecord(lngmId, objConnection, objSqlTransaction);
objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsFunctionTemplateRelaBLEx", "DelRecordEx", objException.Message, clsSysParaEN.strUserId);
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
if (clsFunctionTemplateRelaBL.relatedActions != null)
{
clsFunctionTemplateRelaBL.relatedActions.UpdRelaTabDate(lngmId, "UpdRelaTabDate");
}
bool bolResult = FunctionTemplateRelaDA.DelRecord(lngmId,objSqlConnection,objSqlTransaction);
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
public static int DelFunctionTemplateRelas(List<string> arrmIdLst)
{
if (arrmIdLst.Count == 0) return 0;
try
{
if (clsFunctionTemplateRelaBL.relatedActions != null)
{
foreach (var strmId in arrmIdLst)
{
long lngmId = long.Parse(strmId);
clsFunctionTemplateRelaBL.relatedActions.UpdRelaTabDate(lngmId, "UpdRelaTabDate");
}
}
int intDelRecNum = FunctionTemplateRelaDA.DelFunctionTemplateRela(arrmIdLst);
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
public static int DelFunctionTemplateRelasByCond(string strWhereCond)
{
try
{
if (clsFunctionTemplateRelaBL.relatedActions != null)
{
List<string> arrmId = GetPrimaryKeyID_S(strWhereCond);
foreach (var strmId in arrmId)
{
long lngmId = long.Parse(strmId);
clsFunctionTemplateRelaBL.relatedActions.UpdRelaTabDate(lngmId, "UpdRelaTabDate");
}
}
int intRecNum = FunctionTemplateRelaDA.DelFunctionTemplateRela(strWhereCond);
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
/// 这里仅仅是演示函数,使用时请复制到扩展类:[FunctionTemplateRela]中改名为:[DelRecord4MultiTabEx]使用
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DelRecord4MultiTab)
/// </summary>
/// <param name="lngmId">表关键字</param>
/// <returns></returns>
public static bool DelRecord4MultiTab(long lngmId)
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsFunctionTemplateRelaDA.GetSpecSQLObj();
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
//删除与表:[FunctionTemplateRela]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conStudent.id_College,
//strid_College);
//        clsStudentBL.DelStudentsByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsFunctionTemplateRelaBL.DelRecord(lngmId, objConnection, objSqlTransaction);
                objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsFunctionTemplateRelaBL", "DelRecord4MultiTab", objException.Message, clsSysParaEN.strUserId);
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
 /// <param name = "objFunctionTemplateRelaENS">源对象</param>
 /// <param name = "objFunctionTemplateRelaENT">目标对象</param>
 public static void CopyTo(clsFunctionTemplateRelaEN objFunctionTemplateRelaENS, clsFunctionTemplateRelaEN objFunctionTemplateRelaENT)
{
try
{
objFunctionTemplateRelaENT.mId = objFunctionTemplateRelaENS.mId; //mId
objFunctionTemplateRelaENT.FunctionTemplateId = objFunctionTemplateRelaENS.FunctionTemplateId; //函数模板Id
objFunctionTemplateRelaENT.CodeTypeId = objFunctionTemplateRelaENS.CodeTypeId; //代码类型Id
objFunctionTemplateRelaENT.RegionTypeId = objFunctionTemplateRelaENS.RegionTypeId; //区域类型Id
objFunctionTemplateRelaENT.FuncCodeTypeId = objFunctionTemplateRelaENS.FuncCodeTypeId; //函数代码类型Id
objFunctionTemplateRelaENT.FuncId4GC = objFunctionTemplateRelaENS.FuncId4GC; //函数ID
objFunctionTemplateRelaENT.IsGeneCode = objFunctionTemplateRelaENS.IsGeneCode; //是否生成代码
objFunctionTemplateRelaENT.OrderNum = objFunctionTemplateRelaENS.OrderNum; //序号
objFunctionTemplateRelaENT.UpdDate = objFunctionTemplateRelaENS.UpdDate; //修改日期
objFunctionTemplateRelaENT.UpdUser = objFunctionTemplateRelaENS.UpdUser; //修改者
objFunctionTemplateRelaENT.Memo = objFunctionTemplateRelaENS.Memo; //说明
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
 /// <param name = "objFunctionTemplateRelaEN">源简化对象</param>
 public static void SetUpdFlag(clsFunctionTemplateRelaEN objFunctionTemplateRelaEN)
{
try
{
objFunctionTemplateRelaEN.ClearUpdateState();
   string strsfUpdFldSetStr = objFunctionTemplateRelaEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(conFunctionTemplateRela.mId, new clsStrCompareIgnoreCase())  ==  true)
{
objFunctionTemplateRelaEN.mId = objFunctionTemplateRelaEN.mId; //mId
}
if (arrFldSet.Contains(conFunctionTemplateRela.FunctionTemplateId, new clsStrCompareIgnoreCase())  ==  true)
{
objFunctionTemplateRelaEN.FunctionTemplateId = objFunctionTemplateRelaEN.FunctionTemplateId; //函数模板Id
}
if (arrFldSet.Contains(conFunctionTemplateRela.CodeTypeId, new clsStrCompareIgnoreCase())  ==  true)
{
objFunctionTemplateRelaEN.CodeTypeId = objFunctionTemplateRelaEN.CodeTypeId == "[null]" ? null :  objFunctionTemplateRelaEN.CodeTypeId; //代码类型Id
}
if (arrFldSet.Contains(conFunctionTemplateRela.RegionTypeId, new clsStrCompareIgnoreCase())  ==  true)
{
objFunctionTemplateRelaEN.RegionTypeId = objFunctionTemplateRelaEN.RegionTypeId == "[null]" ? null :  objFunctionTemplateRelaEN.RegionTypeId; //区域类型Id
}
if (arrFldSet.Contains(conFunctionTemplateRela.FuncCodeTypeId, new clsStrCompareIgnoreCase())  ==  true)
{
objFunctionTemplateRelaEN.FuncCodeTypeId = objFunctionTemplateRelaEN.FuncCodeTypeId == "[null]" ? null :  objFunctionTemplateRelaEN.FuncCodeTypeId; //函数代码类型Id
}
if (arrFldSet.Contains(conFunctionTemplateRela.FuncId4GC, new clsStrCompareIgnoreCase())  ==  true)
{
objFunctionTemplateRelaEN.FuncId4GC = objFunctionTemplateRelaEN.FuncId4GC; //函数ID
}
if (arrFldSet.Contains(conFunctionTemplateRela.IsGeneCode, new clsStrCompareIgnoreCase())  ==  true)
{
objFunctionTemplateRelaEN.IsGeneCode = objFunctionTemplateRelaEN.IsGeneCode; //是否生成代码
}
if (arrFldSet.Contains(conFunctionTemplateRela.OrderNum, new clsStrCompareIgnoreCase())  ==  true)
{
objFunctionTemplateRelaEN.OrderNum = objFunctionTemplateRelaEN.OrderNum; //序号
}
if (arrFldSet.Contains(conFunctionTemplateRela.UpdDate, new clsStrCompareIgnoreCase())  ==  true)
{
objFunctionTemplateRelaEN.UpdDate = objFunctionTemplateRelaEN.UpdDate == "[null]" ? null :  objFunctionTemplateRelaEN.UpdDate; //修改日期
}
if (arrFldSet.Contains(conFunctionTemplateRela.UpdUser, new clsStrCompareIgnoreCase())  ==  true)
{
objFunctionTemplateRelaEN.UpdUser = objFunctionTemplateRelaEN.UpdUser == "[null]" ? null :  objFunctionTemplateRelaEN.UpdUser; //修改者
}
if (arrFldSet.Contains(conFunctionTemplateRela.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objFunctionTemplateRelaEN.Memo = objFunctionTemplateRelaEN.Memo == "[null]" ? null :  objFunctionTemplateRelaEN.Memo; //说明
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
 /// <param name = "objFunctionTemplateRelaEN">源简化对象</param>
 public static void AccessFldValueNull(clsFunctionTemplateRelaEN objFunctionTemplateRelaEN)
{
try
{
if (objFunctionTemplateRelaEN.CodeTypeId == "[null]") objFunctionTemplateRelaEN.CodeTypeId = null; //代码类型Id
if (objFunctionTemplateRelaEN.RegionTypeId == "[null]") objFunctionTemplateRelaEN.RegionTypeId = null; //区域类型Id
if (objFunctionTemplateRelaEN.FuncCodeTypeId == "[null]") objFunctionTemplateRelaEN.FuncCodeTypeId = null; //函数代码类型Id
if (objFunctionTemplateRelaEN.UpdDate == "[null]") objFunctionTemplateRelaEN.UpdDate = null; //修改日期
if (objFunctionTemplateRelaEN.UpdUser == "[null]") objFunctionTemplateRelaEN.UpdUser = null; //修改者
if (objFunctionTemplateRelaEN.Memo == "[null]") objFunctionTemplateRelaEN.Memo = null; //说明
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
public static void CheckPropertyNew(clsFunctionTemplateRelaEN objFunctionTemplateRelaEN)
{
 FunctionTemplateRelaDA.CheckPropertyNew(objFunctionTemplateRelaEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(clsFunctionTemplateRelaEN objFunctionTemplateRelaEN)
{
 FunctionTemplateRelaDA.CheckProperty4Condition(objFunctionTemplateRelaEN);
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
if (clsFunctionTemplateRelaBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsFunctionTemplateRelaBL没有刷新缓存机制(clsFunctionTemplateRelaBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by mId");
//if (arrFunctionTemplateRelaObjLstCache == null)
//{
//arrFunctionTemplateRelaObjLstCache = FunctionTemplateRelaDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "lngmId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsFunctionTemplateRelaEN GetObjBymIdCache(long lngmId)
{
//获取缓存中的对象列表
string strKey = string.Format("{0}", clsFunctionTemplateRelaEN._CurrTabName);
List<clsFunctionTemplateRelaEN> arrFunctionTemplateRelaObjLstCache = GetObjLstCache();
IEnumerable <clsFunctionTemplateRelaEN> arrFunctionTemplateRelaObjLst_Sel =
arrFunctionTemplateRelaObjLstCache
.Where(x=> x.mId == lngmId 
);
if (arrFunctionTemplateRelaObjLst_Sel.Count() == 0)
{
   clsFunctionTemplateRelaEN obj = clsFunctionTemplateRelaBL.GetObjBymId(lngmId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
 }
return null;
}
return arrFunctionTemplateRelaObjLst_Sel.First();
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsFunctionTemplateRelaEN> GetAllFunctionTemplateRelaObjLstCache()
{
//获取缓存中的对象列表
List<clsFunctionTemplateRelaEN> arrFunctionTemplateRelaObjLstCache = GetObjLstCache(); 
return arrFunctionTemplateRelaObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsFunctionTemplateRelaEN> GetObjLstCache()
{
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}", clsFunctionTemplateRelaEN._CurrTabName);
List<clsFunctionTemplateRelaEN> arrFunctionTemplateRelaObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrFunctionTemplateRelaObjLstCache;
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
string strKey = string.Format("{0}", clsFunctionTemplateRelaEN._CurrTabName);
CacheHelper.Remove(strKey);
clsFunctionTemplateRelaEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
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
if (clsFunctionTemplateRelaEN._RefreshTimeLst.Count == 0) return "";
return clsFunctionTemplateRelaEN._RefreshTimeLst[clsFunctionTemplateRelaEN._RefreshTimeLst.Count - 1];
}

 /// <summary>
 /// 刷新缓存.把当前表的缓存以及该表相关视图的缓存清空.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ReFreshCache)
 /// </summary>
public static void ReFreshCache()
{
if (clsFunctionTemplateRelaBL.objCommFun4BL != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}", clsFunctionTemplateRelaEN._CurrTabName);
CacheHelper.Remove(strKey);
clsFunctionTemplateRelaEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
clsFunctionTemplateRelaBL.objCommFun4BL.ReFreshCache();
}
}


 #endregion 缓存操作


 #region 检查唯一性

 /// <summary>
 /// 获取检查唯一性条件串(Uniqueness)--FunctionTemplateRela(函数与模板关系)
 /// 唯一性条件:CodeTypeId_FuncId4GC_FunctionTemplateId
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetUniquenessConditionString)
 /// </summary>
 /// <param name = "objFunctionTemplateRelaEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(clsFunctionTemplateRelaEN objFunctionTemplateRelaEN)
{
//检测记录是否存在
string strResult = FunctionTemplateRelaDA.GetUniCondStr(objFunctionTemplateRelaEN);
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
public static string Func(string strInFldName, string strOutFldName, long lngmId)
{
if (strInFldName != conFunctionTemplateRela.mId)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (conFunctionTemplateRela.AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", conFunctionTemplateRela.AttributeName));
throw new Exception(strMsg);
}
var objFunctionTemplateRela = clsFunctionTemplateRelaBL.GetObjBymIdCache(lngmId);
if (objFunctionTemplateRela == null) return "";
return objFunctionTemplateRela[strOutFldName].ToString();
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
int intRecCount = clsFunctionTemplateRelaDA.GetRecCount(strTabName);
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
int intRecCount = clsFunctionTemplateRelaDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsFunctionTemplateRelaDA.GetRecCount();
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
int intRecCount = clsFunctionTemplateRelaDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objFunctionTemplateRelaCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsFunctionTemplateRelaEN objFunctionTemplateRelaCond)
{
List<clsFunctionTemplateRelaEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsFunctionTemplateRelaEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conFunctionTemplateRela.AttributeName)
{
if (objFunctionTemplateRelaCond.IsUpdated(strFldName) == false) continue;
if (objFunctionTemplateRelaCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objFunctionTemplateRelaCond[strFldName].ToString());
}
else
{
if (objFunctionTemplateRelaCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objFunctionTemplateRelaCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objFunctionTemplateRelaCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objFunctionTemplateRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objFunctionTemplateRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objFunctionTemplateRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objFunctionTemplateRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objFunctionTemplateRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objFunctionTemplateRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objFunctionTemplateRelaCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objFunctionTemplateRelaCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objFunctionTemplateRelaCond[strFldName]));
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
 List<string> arrList = clsFunctionTemplateRelaDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = FunctionTemplateRelaDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = FunctionTemplateRelaDA.GetFldValueNoDistinct(strFldName, strWhereCond);
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
int intRecCount = FunctionTemplateRelaDA.SetFldValue(strFldName, strValue, strWhereCond);
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
int intRecCount = clsFunctionTemplateRelaDA.SetFldValue(clsFunctionTemplateRelaEN._CurrTabName, strFldName, fltValue, strWhereCond);
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
int intRecCount = FunctionTemplateRelaDA.SetFldValue( strFldName, intValue, strWhereCond);
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
int intRecCount = clsFunctionTemplateRelaDA.SetFldValue(strTabName, strFldName, strValue, strWhereCond);
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
int intRecCount = clsFunctionTemplateRelaDA.SetFldValue(strTabName, strFldName, intValue, strWhereCond);
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
int intRecCount = clsFunctionTemplateRelaDA.SetFldValue(strTabName, strFldName, fltValue, strWhereCond);
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
  strCreateTabCode.Append("CREATE table [dbo].[FunctionTemplateRela] "); 
 strCreateTabCode.Append(" ( "); 
 // /**mId*/ 
 strCreateTabCode.Append(" mId bigint primary key identity, "); 
 // /**函数模板Id*/ 
 strCreateTabCode.Append(" FunctionTemplateId char(4) not Null, "); 
 // /**代码类型Id*/ 
 strCreateTabCode.Append(" CodeTypeId char(4) Null, "); 
 // /**区域类型Id*/ 
 strCreateTabCode.Append(" RegionTypeId char(4) Null, "); 
 // /**函数代码类型Id*/ 
 strCreateTabCode.Append(" FuncCodeTypeId char(4) Null, "); 
 // /**函数ID*/ 
 strCreateTabCode.Append(" FuncId4GC char(10) not Null, "); 
 // /**是否生成代码*/ 
 strCreateTabCode.Append(" IsGeneCode bit Null, "); 
 // /**序号*/ 
 strCreateTabCode.Append(" OrderNum int not Null, "); 
 // /**修改日期*/ 
 strCreateTabCode.Append(" UpdDate varchar(20) Null, "); 
 // /**修改者*/ 
 strCreateTabCode.Append(" UpdUser varchar(20) Null, "); 
 // /**说明*/ 
 strCreateTabCode.Append(" Memo varchar(1000) Null, "); 
 // /**函数模板名*/ 
 strCreateTabCode.Append(" FunctionTemplateName varchar(50) Null, "); 
 // /**区域类型名称*/ 
 strCreateTabCode.Append(" RegionTypeName varchar(30) Null, "); 
 // /**函数名*/ 
 strCreateTabCode.Append(" FuncName varchar(100) Null, "); 
 // /**函数名4Code*/ 
 strCreateTabCode.Append(" FuncName4Code varchar(100) Null, "); 
 // /**编程语言类型简称*/ 
 strCreateTabCode.Append(" ProgLangTypeSimName varchar(30) Null, "); 
 // /**简称*/ 
 strCreateTabCode.Append(" CodeTypeSimName varchar(50) Null, "); 
 // /**代码类型名*/ 
 strCreateTabCode.Append(" CodeTypeName varchar(50) Null, "); 
 // /**FuncCodeTypeName*/ 
 strCreateTabCode.Append(" FuncCodeTypeName varchar(50) not Null ");
 strCreateTabCode.Append(") "); 
  strCreateTabCode.Append("ON [PRIMARY] ");
  return strCreateTabCode.ToString();
}



 #endregion 表操作


 #region 排序相关函数

/// <summary>
/// 重新排序。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_TabFeature_ReOrder)
/// </summary>
/// <returns></returns>
public static bool ReOrder()
{
try
{
string strCondition = string.Format("1 = 1 order by {0} ", conFunctionTemplateRela.OrderNum); 
List<clsFunctionTemplateRelaEN> arrFunctionTemplateRelaObjList = new clsFunctionTemplateRelaDA().GetObjLst(strCondition);
    
int intIndex = 1;
foreach (clsFunctionTemplateRelaEN objFunctionTemplateRela in arrFunctionTemplateRelaObjList)
{
objFunctionTemplateRela.OrderNum = intIndex;
UpdateBySql2(objFunctionTemplateRela);
intIndex++;
}
return true; 
}
catch (Exception objException)
{
string strMsg = string.Format("重序出错, {0}. (from {1})", objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
}

/// <summary>
/// 调整所给关键字记录的序号。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_TabFeature_AdjustOrderNum)
/// </summary>
/// <param name="strDirect">方向：用"Up","Down"表示</param>
/// <param name="lngmId">所给的关键字</param>
/// <returns>是否成绩</returns>
public static bool AdjustOrderNum(string strDirect, long lngmId)
{
try
{
//操作步骤：
//1、根据所给定的关键字[mId],获取相应的序号[OrderNum]；
//2、如果当前序号是否是末端序号；
//3、如果是末端序号,就退出；
//   3.1、如果是向下移动,判断当前序号是否“小于”当前表中的字段数,
//	   即不是最后一个记录,就准备把当前字段项的序号加1,而下一字段的序号减1,
//   3.2、如果是向上移动,就判断当前序号是否“大于”1,
//	   即不是第一条记录,就准备把当前字段项的序号减1,而上一字段的序号加1。
//4、获取下(上)一个序号记录的关键字mId
//5、把当前关键字mId所对应记录的序号加(减)1
//6、把下(上)一个序号关键字mId所对应的记录序号减(加)1
string strMsg;
int intOrderNum;    //当前记录的序号
int intPrevOrderNum, intNextOrderNum;   //上下两条记录的序号
long lngPrevmId = 0;    //上一条序号的关键字mId
long lngNextmId = 0;    //下一条序号的关键字mId
int intTabRecNum;       //当前表中字段的记录数
StringBuilder strCondition = new StringBuilder();
//1、根据所给定的关键字[mId],获取相应的序号[OrderNum]。

clsFunctionTemplateRelaEN objFunctionTemplateRela = clsFunctionTemplateRelaBL.GetObjBymId(lngmId);

intOrderNum = objFunctionTemplateRela.OrderNum;//当前序号
intPrevOrderNum = intOrderNum - 1;//前一条记录的序号
intNextOrderNum = intOrderNum + 1;//后一条记录的序号
//3、如果当前序号是否是末端序号,
//		3.1 如果是末端序号,就退出,

intTabRecNum = clsFunctionTemplateRelaBL.GetRecCountByCond(clsFunctionTemplateRelaEN._CurrTabName, "1 = 1");    //获取当前表的记录数
switch (strDirect)
{
case "UP":
case "Up":
case "up":
//3、如果是末端序号,就退出；
//  3.2、如果是向上移动,就判断当前序号是否“大于”1,
//	     即不是第一条记录,就准备把当前字段项的序号减1,而上一字段的序号加1。
if (intOrderNum <= 1)
{
strMsg = string.Format("已经是第一条记录,不能再上移.(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//		3.2 如果不是,即如果是向下移动,就判断当前序号是否“小于”当前表中的字段数,
//		    即不是最后一个记录,就准备把当前字段项的序号加1,而下一字段的序号减1,
//		    如果是向上移动,就判断当前序号是否“大于”1,
//		    即不是最开始一个记录,就准备把当前字段项的序号减1,而上一字段的序号加1。
strCondition.AppendFormat(" {0} = {1}", conFunctionTemplateRela.OrderNum, intOrderNum - 1);
//4、获取上一个序号字段的关键字mId
lngPrevmId = clsFunctionTemplateRelaBL.GetFirstID_S(strCondition.ToString());
if (lngPrevmId == 0)
{
strMsg = string.Format("获取上一条记录的关键字出错.(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//5、把当前关键字mId所对应记录的序号减1
//6、把下(上)一个序号关键字mId所对应的记录序号加1
clsFunctionTemplateRelaBL.SetFldValue(clsFunctionTemplateRelaEN._CurrTabName, conFunctionTemplateRela.OrderNum,
intOrderNum - 1,
string.Format("{0} = '{1}'", conFunctionTemplateRela.mId, lngmId));
clsFunctionTemplateRelaBL.SetFldValue(clsFunctionTemplateRelaEN._CurrTabName, conFunctionTemplateRela.OrderNum,
intPrevOrderNum + 1,
string.Format("{0} = '{1}'", conFunctionTemplateRela.mId, lngPrevmId));
break;
case "DOWN":
case "Down":
case "down":
//3、如果是末端序号,就退出；
//   3.1、如果是向下移动,判断当前序号是否“小于”当前表中的字段数,
//	   即不是最后一个记录,就准备把当前字段项的序号加1,而下一字段的序号减1,
if (intOrderNum >= intTabRecNum)    //如果当前序号大于表记录数
{
strMsg = string.Format("已经是最后一条记录,不能再下移.(from {0})", clsStackTrace.GetCurrClassFunction());
                            throw new Exception(strMsg);
}

//4、获取下一个序号字段的关键字mId
strCondition.AppendFormat(" {0} = {1}", conFunctionTemplateRela.OrderNum, intOrderNum + 1);

lngNextmId = clsFunctionTemplateRelaBL.GetFirstID_S(strCondition.ToString());
if (lngNextmId == 0)
{
strMsg = string.Format("获取下一条记录的关键字出错.(from {0})", clsStackTrace.GetCurrClassFunction());

throw new Exception(strMsg);
}
//5、把当前关键字mId所对应记录的序号加1
//6、把下(上)一个序号关键字mId所对应的记录序号减1
clsFunctionTemplateRelaBL.SetFldValue(clsFunctionTemplateRelaEN._CurrTabName, conFunctionTemplateRela.OrderNum,
intOrderNum + 1,
string.Format("{0} = '{1}'", conFunctionTemplateRela.mId, lngmId));
clsFunctionTemplateRelaBL.SetFldValue(clsFunctionTemplateRelaEN._CurrTabName, conFunctionTemplateRela.OrderNum,
 	 	intNextOrderNum - 1,
 	 	string.Format("{0} = '{1}'", conFunctionTemplateRela.mId, lngNextmId));
break;
default:
strMsg = string.Format("方向参数出错!strDirect=[{0}]({1})",
strDirect,
clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
clsFunctionTemplateRelaBL.ReFreshCache();
if (clsFunctionTemplateRelaBL.relatedActions != null)
{
clsFunctionTemplateRelaBL.relatedActions.UpdRelaTabDate(objFunctionTemplateRela.mId, "UpdRelaTabDate");
}
return true;
}
catch (Exception objException)
{
string strMsg = string.Format("调整记录次序出错!错误:[{0}]({1})",
objException.Message,
clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
}

/// <summary>
/// 把所给的关键字列表所对应的对象置底。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_TabFeature_GoBottom)
/// </summary>
/// <param name="arrKeyId">所给的关键字列表</param>
/// <returns></returns>
public static bool GoBottom(List<long> arrKeyId)
{
try
{
if (arrKeyId.Count == 0) return true;
string strKeyList = clsArray.GetSqlInStrByArray(arrKeyId);
string strCondition = string.Format("{0} in ({1})", conFunctionTemplateRela.mId, strKeyList);
List<clsFunctionTemplateRelaEN> arrFunctionTemplateRelaLst = GetObjLst(strCondition);
foreach (clsFunctionTemplateRelaEN objFunctionTemplateRela in arrFunctionTemplateRelaLst)
{
objFunctionTemplateRela.OrderNum = objFunctionTemplateRela.OrderNum + 10000;
UpdateBySql2(objFunctionTemplateRela);
}
strCondition = string.Format("1 = 1 order by {0} ", conFunctionTemplateRela.OrderNum); 
List<clsFunctionTemplateRelaEN> arrFunctionTemplateRelaObjList = new clsFunctionTemplateRelaDA().GetObjLst(strCondition);
    
int intIndex = 1;
foreach (clsFunctionTemplateRelaEN objFunctionTemplateRela in arrFunctionTemplateRelaObjList)
{
objFunctionTemplateRela.OrderNum = intIndex;
UpdateBySql2(objFunctionTemplateRela);
intIndex++;
}
return true; 
}
catch (Exception objException)
{
string strMsg = string.Format("置顶出错, {0}. (from {1})", objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
}

/// <summary>
/// 把所给的关键字列表所对应的对象置顶。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_TabFeature_GoTop)
/// </summary>
/// <param name="arrKeyId">所给的关键字列表</param>
/// <returns></returns>
public static bool GoTop(List<long> arrKeyId)
{
try
{
if (arrKeyId.Count == 0) return true;
string strKeyList = clsArray.GetSqlInStrByArray(arrKeyId);
string strCondition = string.Format("{0} in ({1})", conFunctionTemplateRela.mId, strKeyList);
List<clsFunctionTemplateRelaEN> arrFunctionTemplateRelaLst = GetObjLst(strCondition);
foreach (clsFunctionTemplateRelaEN objFunctionTemplateRela in arrFunctionTemplateRelaLst)
{
objFunctionTemplateRela.OrderNum = objFunctionTemplateRela.OrderNum - 10000;
UpdateBySql2(objFunctionTemplateRela);
}
strCondition = string.Format("1 = 1 order by {0} ", conFunctionTemplateRela.OrderNum); 
List<clsFunctionTemplateRelaEN> arrFunctionTemplateRelaObjList = new clsFunctionTemplateRelaDA().GetObjLst(strCondition);
    
int intIndex = 1;
foreach (clsFunctionTemplateRelaEN objFunctionTemplateRela in arrFunctionTemplateRelaObjList)
{
objFunctionTemplateRela.OrderNum = intIndex;
UpdateBySql2(objFunctionTemplateRela);
intIndex++;
}
return true; 
}
catch (Exception objException)
{
string strMsg = string.Format("置顶出错!错误:{0}. (from {1})", objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
}


 #endregion 排序相关函数
}
 /// <summary>
 /// 函数与模板关系(FunctionTemplateRela)
 /// 数据源类型:表
 /// (AutoGCLib.CommFun4BL4CSharp:GeneCode_This)
 /// </summary>
public class  clsCommFun4BL4FunctionTemplateRela : clsCommFun4BL
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
clsFunctionTemplateRelaBL.ReFreshThisCache();
}
}

}