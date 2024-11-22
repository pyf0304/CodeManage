﻿
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsCMClassFuncRelaBL
 表名:CMClassFuncRela(00050505)
 * 版本:2024.10.15.1(服务器:WIN-SRV103-116)
 日期:2024/10/15 15:27:16
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcSpa后端(000014, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433AGC_CS12
 PrjDataBaseId:0005
 模块中文名:代码管理(CodeMan)
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
public static class  clsCMClassFuncRelaBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public static clsCMClassFuncRelaEN GetObj(this K_mId_CMClassFuncRela myKey)
{
clsCMClassFuncRelaEN objCMClassFuncRelaEN = clsCMClassFuncRelaBL.CMClassFuncRelaDA.GetObjBymId(myKey.Value);
return objCMClassFuncRelaEN;
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_AddNewRecord)
 /// </summary>
 /// <param name = "objCMClassFuncRelaEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clsCMClassFuncRelaEN objCMClassFuncRelaEN, bool bolIsNeedCheckUniqueness = true)
{
if (bolIsNeedCheckUniqueness == true && CheckUniqueness(objCMClassFuncRelaEN) == false)
{
var strMsg = string.Format("记录已经存在!函数Id = [{0}],类Id = [{1}]的数据已经存在!(in clsCMClassFuncRelaBL.AddNewRecord)", objCMClassFuncRelaEN.CmFunctionId,objCMClassFuncRelaEN.CmClassId);
throw new Exception(strMsg);
}
try
{
bool bolResult = clsCMClassFuncRelaBL.CMClassFuncRelaDA.AddNewRecordBySQL2(objCMClassFuncRelaEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsCMClassFuncRelaBL.ReFreshCache();

if (clsCMClassFuncRelaBL.relatedActions != null)
{
clsCMClassFuncRelaBL.relatedActions.UpdRelaTabDate(objCMClassFuncRelaEN.mId, "SetUpdDate");
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
public static bool AddRecordEx(this clsCMClassFuncRelaEN objCMClassFuncRelaEN, bool bolIsNeedCheckUniqueness = true)
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
objCMClassFuncRelaEN.CheckPropertyNew();
 ///5.2、检查唯一性
if (bolIsNeedCheckUniqueness == true && objCMClassFuncRelaEN.CheckUniqueness() == false)
{
strMsg = string.Format("(函数Id(CmFunctionId)=[{0}],类Id(CmClassId)=[{1}])已经存在,不能重复!", objCMClassFuncRelaEN.CmFunctionId, objCMClassFuncRelaEN.CmClassId);
throw new Exception(strMsg);
}
//6、把数据实体层的数据存贮到数据库中
objCMClassFuncRelaEN.AddNewRecord();
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
 /// <param name = "objCMClassFuncRelaEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordWithReturnKey(this clsCMClassFuncRelaEN objCMClassFuncRelaEN, bool bolIsNeedCheckUniqueness = true)
{
if (bolIsNeedCheckUniqueness == true && CheckUniqueness(objCMClassFuncRelaEN) == false)
{
var strMsg = string.Format("记录已经存在!函数Id = [{0}],类Id = [{1}]的数据已经存在!(in clsCMClassFuncRelaBL.AddNewRecordWithReturnKey)", objCMClassFuncRelaEN.CmFunctionId,objCMClassFuncRelaEN.CmClassId);
throw new Exception(strMsg);
}
try
{
string strKey = clsCMClassFuncRelaBL.CMClassFuncRelaDA.AddNewRecordBySQL2WithReturnKey(objCMClassFuncRelaEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsCMClassFuncRelaBL.ReFreshCache();

if (clsCMClassFuncRelaBL.relatedActions != null)
{
clsCMClassFuncRelaBL.relatedActions.UpdRelaTabDate(objCMClassFuncRelaEN.mId, "SetUpdDate");
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
 /// <param name = "objCMClassFuncRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCMClassFuncRelaEN SetmId(this clsCMClassFuncRelaEN objCMClassFuncRelaEN, long lngmId, string strComparisonOp="")
	{
objCMClassFuncRelaEN.mId = lngmId; //mId
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCMClassFuncRelaEN.dicFldComparisonOp.ContainsKey(conCMClassFuncRela.mId) == false)
{
objCMClassFuncRelaEN.dicFldComparisonOp.Add(conCMClassFuncRela.mId, strComparisonOp);
}
else
{
objCMClassFuncRelaEN.dicFldComparisonOp[conCMClassFuncRela.mId] = strComparisonOp;
}
}
return objCMClassFuncRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCMClassFuncRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCMClassFuncRelaEN SetCmClassId(this clsCMClassFuncRelaEN objCMClassFuncRelaEN, string strCmClassId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strCmClassId, conCMClassFuncRela.CmClassId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCmClassId, 8, conCMClassFuncRela.CmClassId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strCmClassId, 8, conCMClassFuncRela.CmClassId);
}
objCMClassFuncRelaEN.CmClassId = strCmClassId; //类Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCMClassFuncRelaEN.dicFldComparisonOp.ContainsKey(conCMClassFuncRela.CmClassId) == false)
{
objCMClassFuncRelaEN.dicFldComparisonOp.Add(conCMClassFuncRela.CmClassId, strComparisonOp);
}
else
{
objCMClassFuncRelaEN.dicFldComparisonOp[conCMClassFuncRela.CmClassId] = strComparisonOp;
}
}
return objCMClassFuncRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCMClassFuncRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCMClassFuncRelaEN SetCmFunctionId(this clsCMClassFuncRelaEN objCMClassFuncRelaEN, string strCmFunctionId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strCmFunctionId, conCMClassFuncRela.CmFunctionId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCmFunctionId, 8, conCMClassFuncRela.CmFunctionId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strCmFunctionId, 8, conCMClassFuncRela.CmFunctionId);
}
objCMClassFuncRelaEN.CmFunctionId = strCmFunctionId; //函数Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCMClassFuncRelaEN.dicFldComparisonOp.ContainsKey(conCMClassFuncRela.CmFunctionId) == false)
{
objCMClassFuncRelaEN.dicFldComparisonOp.Add(conCMClassFuncRela.CmFunctionId, strComparisonOp);
}
else
{
objCMClassFuncRelaEN.dicFldComparisonOp[conCMClassFuncRela.CmFunctionId] = strComparisonOp;
}
}
return objCMClassFuncRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCMClassFuncRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCMClassFuncRelaEN SetOrderNum(this clsCMClassFuncRelaEN objCMClassFuncRelaEN, int? intOrderNum, string strComparisonOp="")
	{
objCMClassFuncRelaEN.OrderNum = intOrderNum; //序号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCMClassFuncRelaEN.dicFldComparisonOp.ContainsKey(conCMClassFuncRela.OrderNum) == false)
{
objCMClassFuncRelaEN.dicFldComparisonOp.Add(conCMClassFuncRela.OrderNum, strComparisonOp);
}
else
{
objCMClassFuncRelaEN.dicFldComparisonOp[conCMClassFuncRela.OrderNum] = strComparisonOp;
}
}
return objCMClassFuncRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCMClassFuncRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCMClassFuncRelaEN SetUpdDate(this clsCMClassFuncRelaEN objCMClassFuncRelaEN, string strUpdDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdDate, 20, conCMClassFuncRela.UpdDate);
}
objCMClassFuncRelaEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCMClassFuncRelaEN.dicFldComparisonOp.ContainsKey(conCMClassFuncRela.UpdDate) == false)
{
objCMClassFuncRelaEN.dicFldComparisonOp.Add(conCMClassFuncRela.UpdDate, strComparisonOp);
}
else
{
objCMClassFuncRelaEN.dicFldComparisonOp[conCMClassFuncRela.UpdDate] = strComparisonOp;
}
}
return objCMClassFuncRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCMClassFuncRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCMClassFuncRelaEN SetUpdUser(this clsCMClassFuncRelaEN objCMClassFuncRelaEN, string strUpdUser, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdUser, 20, conCMClassFuncRela.UpdUser);
}
objCMClassFuncRelaEN.UpdUser = strUpdUser; //修改者
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCMClassFuncRelaEN.dicFldComparisonOp.ContainsKey(conCMClassFuncRela.UpdUser) == false)
{
objCMClassFuncRelaEN.dicFldComparisonOp.Add(conCMClassFuncRela.UpdUser, strComparisonOp);
}
else
{
objCMClassFuncRelaEN.dicFldComparisonOp[conCMClassFuncRela.UpdUser] = strComparisonOp;
}
}
return objCMClassFuncRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCMClassFuncRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsCMClassFuncRelaEN SetMemo(this clsCMClassFuncRelaEN objCMClassFuncRelaEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, conCMClassFuncRela.Memo);
}
objCMClassFuncRelaEN.Memo = strMemo; //说明
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCMClassFuncRelaEN.dicFldComparisonOp.ContainsKey(conCMClassFuncRela.Memo) == false)
{
objCMClassFuncRelaEN.dicFldComparisonOp.Add(conCMClassFuncRela.Memo, strComparisonOp);
}
else
{
objCMClassFuncRelaEN.dicFldComparisonOp[conCMClassFuncRela.Memo] = strComparisonOp;
}
}
return objCMClassFuncRelaEN;
	}

 /// <summary>
 /// 修改记录存盘到数据表中
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_UpdateRecordEx)
 /// </summary>
 /// <param name = "objCMClassFuncRelaEN">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool UpdateRecordEx(this clsCMClassFuncRelaEN objCMClassFuncRelaEN)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
try
{
//1、检查传进去的对象属性是否合法
objCMClassFuncRelaEN.CheckPropertyNew();
clsCMClassFuncRelaEN objCMClassFuncRelaCond = new clsCMClassFuncRelaEN();
string strCondition = objCMClassFuncRelaCond
.SetmId(objCMClassFuncRelaEN.mId, "<>")
.SetCmFunctionId(objCMClassFuncRelaEN.CmFunctionId, "=")
.SetCmClassId(objCMClassFuncRelaEN.CmClassId, "=")
.GetCombineCondition();
objCMClassFuncRelaEN._IsCheckProperty = true;
bool bolIsExist = clsCMClassFuncRelaBL.IsExistRecord(strCondition);
if (bolIsExist)
{
strMsg = "(ClassId_FunctionId)不能重复!";
throw new Exception(strMsg);
}
//4、把数据实体层的数据存贮到数据库中
objCMClassFuncRelaEN.Update();
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
 /// <param name = "objCMClassFuncRela">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool EditRecordEx(this clsCMClassFuncRelaEN objCMClassFuncRela)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
clsCMClassFuncRelaEN objCMClassFuncRelaCond = new clsCMClassFuncRelaEN();
string strCondition = objCMClassFuncRelaCond
.SetCmFunctionId(objCMClassFuncRela.CmFunctionId, "=")
.SetCmClassId(objCMClassFuncRela.CmClassId, "=")
.GetCombineCondition();
objCMClassFuncRela._IsCheckProperty = true;
bool bolIsExist = clsCMClassFuncRelaBL.IsExistRecord(strCondition);
if (bolIsExist)
{
objCMClassFuncRela.mId = clsCMClassFuncRelaBL.GetFirstID_S(strCondition);
objCMClassFuncRela.UpdateWithCondition(strCondition);
}
else
{
objCMClassFuncRela.AddNewRecord();
}
return true; 
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_Update)
 /// </summary>
 /// <param name = "objCMClassFuncRelaEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsCMClassFuncRelaEN objCMClassFuncRelaEN)
{
 if (objCMClassFuncRelaEN.mId == 0)
 {
string strMsg = string.Format("(errid:Busi000095)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsCMClassFuncRelaBL.CMClassFuncRelaDA.UpdateBySql2(objCMClassFuncRelaEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsCMClassFuncRelaBL.ReFreshCache();

if (clsCMClassFuncRelaBL.relatedActions != null)
{
clsCMClassFuncRelaBL.relatedActions.UpdRelaTabDate(objCMClassFuncRelaEN.mId, "SetUpdDate");
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
 /// <param name = "objCMClassFuncRelaEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsCMClassFuncRelaEN objCMClassFuncRelaEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (objCMClassFuncRelaEN.mId == 0)
 {
string strMsg = string.Format("(errid:Busi000087)修改记录时关键字不能为空!(带事务处理)(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsCMClassFuncRelaBL.CMClassFuncRelaDA.UpdateBySql2(objCMClassFuncRelaEN, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsCMClassFuncRelaBL.ReFreshCache();

if (clsCMClassFuncRelaBL.relatedActions != null)
{
clsCMClassFuncRelaBL.relatedActions.UpdRelaTabDate(objCMClassFuncRelaEN.mId, "SetUpdDate");
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
 /// <param name = "objCMClassFuncRelaEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsCMClassFuncRelaEN objCMClassFuncRelaEN, string strWhereCond)
{
try
{
bool bolResult = clsCMClassFuncRelaBL.CMClassFuncRelaDA.UpdateBySqlWithCondition(objCMClassFuncRelaEN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsCMClassFuncRelaBL.ReFreshCache();

if (clsCMClassFuncRelaBL.relatedActions != null)
{
clsCMClassFuncRelaBL.relatedActions.UpdRelaTabDate(objCMClassFuncRelaEN.mId, "SetUpdDate");
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
 /// <param name = "objCMClassFuncRelaEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsCMClassFuncRelaEN objCMClassFuncRelaEN, string strWhereCond, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
bool bolResult = clsCMClassFuncRelaBL.CMClassFuncRelaDA.UpdateBySqlWithConditionTransaction(objCMClassFuncRelaEN, strWhereCond, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsCMClassFuncRelaBL.ReFreshCache();

if (clsCMClassFuncRelaBL.relatedActions != null)
{
clsCMClassFuncRelaBL.relatedActions.UpdRelaTabDate(objCMClassFuncRelaEN.mId, "SetUpdDate");
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
public static int Delete(this clsCMClassFuncRelaEN objCMClassFuncRelaEN)
{
try
{
int intRecNum = clsCMClassFuncRelaBL.CMClassFuncRelaDA.DelRecord(objCMClassFuncRelaEN.mId);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsCMClassFuncRelaBL.ReFreshCache();

if (clsCMClassFuncRelaBL.relatedActions != null)
{
clsCMClassFuncRelaBL.relatedActions.UpdRelaTabDate(objCMClassFuncRelaEN.mId, "SetUpdDate");
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
 /// <param name = "objCMClassFuncRelaENS">源对象</param>
 /// <param name = "objCMClassFuncRelaENT">目标对象</param>
 public static void CopyTo(this clsCMClassFuncRelaEN objCMClassFuncRelaENS, clsCMClassFuncRelaEN objCMClassFuncRelaENT)
{
try
{
objCMClassFuncRelaENT.mId = objCMClassFuncRelaENS.mId; //mId
objCMClassFuncRelaENT.CmClassId = objCMClassFuncRelaENS.CmClassId; //类Id
objCMClassFuncRelaENT.CmFunctionId = objCMClassFuncRelaENS.CmFunctionId; //函数Id
objCMClassFuncRelaENT.OrderNum = objCMClassFuncRelaENS.OrderNum; //序号
objCMClassFuncRelaENT.UpdDate = objCMClassFuncRelaENS.UpdDate; //修改日期
objCMClassFuncRelaENT.UpdUser = objCMClassFuncRelaENS.UpdUser; //修改者
objCMClassFuncRelaENT.Memo = objCMClassFuncRelaENS.Memo; //说明
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
 /// <param name = "objCMClassFuncRelaENS">源对象</param>
 /// <returns>目标对象=>clsCMClassFuncRelaEN:objCMClassFuncRelaENT</returns>
 public static clsCMClassFuncRelaEN CopyTo(this clsCMClassFuncRelaEN objCMClassFuncRelaENS)
{
try
{
 clsCMClassFuncRelaEN objCMClassFuncRelaENT = new clsCMClassFuncRelaEN()
{
mId = objCMClassFuncRelaENS.mId, //mId
CmClassId = objCMClassFuncRelaENS.CmClassId, //类Id
CmFunctionId = objCMClassFuncRelaENS.CmFunctionId, //函数Id
OrderNum = objCMClassFuncRelaENS.OrderNum, //序号
UpdDate = objCMClassFuncRelaENS.UpdDate, //修改日期
UpdUser = objCMClassFuncRelaENS.UpdUser, //修改者
Memo = objCMClassFuncRelaENS.Memo, //说明
};
 return objCMClassFuncRelaENT;
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
public static void CheckPropertyNew(this clsCMClassFuncRelaEN objCMClassFuncRelaEN)
{
 clsCMClassFuncRelaBL.CMClassFuncRelaDA.CheckPropertyNew(objCMClassFuncRelaEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(this clsCMClassFuncRelaEN objCMClassFuncRelaEN)
{
 clsCMClassFuncRelaBL.CMClassFuncRelaDA.CheckProperty4Condition(objCMClassFuncRelaEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsCMClassFuncRelaEN objCMClassFuncRelaCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objCMClassFuncRelaCond.IsUpdated(conCMClassFuncRela.mId) == true)
{
string strComparisonOpmId = objCMClassFuncRelaCond.dicFldComparisonOp[conCMClassFuncRela.mId];
strWhereCond += string.Format(" And {0} {2} {1}", conCMClassFuncRela.mId, objCMClassFuncRelaCond.mId, strComparisonOpmId);
}
if (objCMClassFuncRelaCond.IsUpdated(conCMClassFuncRela.CmClassId) == true)
{
string strComparisonOpCmClassId = objCMClassFuncRelaCond.dicFldComparisonOp[conCMClassFuncRela.CmClassId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCMClassFuncRela.CmClassId, objCMClassFuncRelaCond.CmClassId, strComparisonOpCmClassId);
}
if (objCMClassFuncRelaCond.IsUpdated(conCMClassFuncRela.CmFunctionId) == true)
{
string strComparisonOpCmFunctionId = objCMClassFuncRelaCond.dicFldComparisonOp[conCMClassFuncRela.CmFunctionId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCMClassFuncRela.CmFunctionId, objCMClassFuncRelaCond.CmFunctionId, strComparisonOpCmFunctionId);
}
if (objCMClassFuncRelaCond.IsUpdated(conCMClassFuncRela.OrderNum) == true)
{
string strComparisonOpOrderNum = objCMClassFuncRelaCond.dicFldComparisonOp[conCMClassFuncRela.OrderNum];
strWhereCond += string.Format(" And {0} {2} {1}", conCMClassFuncRela.OrderNum, objCMClassFuncRelaCond.OrderNum, strComparisonOpOrderNum);
}
if (objCMClassFuncRelaCond.IsUpdated(conCMClassFuncRela.UpdDate) == true)
{
string strComparisonOpUpdDate = objCMClassFuncRelaCond.dicFldComparisonOp[conCMClassFuncRela.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCMClassFuncRela.UpdDate, objCMClassFuncRelaCond.UpdDate, strComparisonOpUpdDate);
}
if (objCMClassFuncRelaCond.IsUpdated(conCMClassFuncRela.UpdUser) == true)
{
string strComparisonOpUpdUser = objCMClassFuncRelaCond.dicFldComparisonOp[conCMClassFuncRela.UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCMClassFuncRela.UpdUser, objCMClassFuncRelaCond.UpdUser, strComparisonOpUpdUser);
}
if (objCMClassFuncRelaCond.IsUpdated(conCMClassFuncRela.Memo) == true)
{
string strComparisonOpMemo = objCMClassFuncRelaCond.dicFldComparisonOp[conCMClassFuncRela.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCMClassFuncRela.Memo, objCMClassFuncRelaCond.Memo, strComparisonOpMemo);
}
 return strWhereCond;
}

 /// <summary>
 /// 检查唯一性(Uniqueness)--CMClassFuncRela(CM类函数关系), 如果不唯一,即存在相同的记录,就返回False
 /// 唯一性条件:ClassId_FunctionId
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckConstraint)
 /// </summary>
 /// <param name = "objCMClassFuncRelaEN">要求唯一的对象</param>
 /// <returns></returns>
public static bool CheckUniqueness(this clsCMClassFuncRelaEN objCMClassFuncRelaEN)
{
//检测记录是否存在
bool bolIsUniqueness;
StringBuilder sbCondition = new StringBuilder();
if (objCMClassFuncRelaEN == null) return true;
if (objCMClassFuncRelaEN.mId == 0)
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and CmFunctionId = '{0}'", objCMClassFuncRelaEN.CmFunctionId);
 sbCondition.AppendFormat(" and CmClassId = '{0}'", objCMClassFuncRelaEN.CmClassId);
if (clsCMClassFuncRelaBL.IsExistRecord(sbCondition.ToString())  ==  true)
{
 bolIsUniqueness = false;
}
else
{
 bolIsUniqueness = true;
}
}
 else {
sbCondition.AppendFormat("mId !=  {0}", objCMClassFuncRelaEN.mId);
 sbCondition.AppendFormat(" and CmFunctionId = '{0}'", objCMClassFuncRelaEN.CmFunctionId);
 sbCondition.AppendFormat(" and CmClassId = '{0}'", objCMClassFuncRelaEN.CmClassId);
if (clsCMClassFuncRelaBL.IsExistRecord(sbCondition.ToString())  ==  true)
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
 /// 获取唯一性条件串--CMClassFuncRela(CM类函数关系), 即由对象中唯一性条件字段关键字与值组成的条件串
 /// 唯一性条件:ClassId_FunctionId
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetConditionString4Constraint)
 /// </summary>
 /// <param name = "objCMClassFuncRelaEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(this clsCMClassFuncRelaEN objCMClassFuncRelaEN)
{
//检测记录是否存在
StringBuilder sbCondition = new StringBuilder();
if (objCMClassFuncRelaEN == null) return "";
if (objCMClassFuncRelaEN.mId == 0)
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and CmFunctionId = '{0}'", objCMClassFuncRelaEN.CmFunctionId);
 sbCondition.AppendFormat(" and CmClassId = '{0}'", objCMClassFuncRelaEN.CmClassId);
return sbCondition.ToString();
}
 else {
sbCondition.AppendFormat("mId !=  {0}", objCMClassFuncRelaEN.mId);
 sbCondition.AppendFormat(" and CmFunctionId = '{0}'", objCMClassFuncRelaEN.CmFunctionId);
 sbCondition.AppendFormat(" and CmClassId = '{0}'", objCMClassFuncRelaEN.CmClassId);
 return sbCondition.ToString();
}
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_CMClassFuncRela
{
public virtual bool UpdRelaTabDate(long lngmId, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// CM类函数关系(CMClassFuncRela)
 /// 数据源类型:表
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsCMClassFuncRelaBL
{
public static RelatedActions_CMClassFuncRela relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsCMClassFuncRelaDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsCMClassFuncRelaDA CMClassFuncRelaDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsCMClassFuncRelaDA();
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
 public clsCMClassFuncRelaBL()
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
if (string.IsNullOrEmpty(clsCMClassFuncRelaEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsCMClassFuncRelaEN._ConnectString);
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
public static DataTable GetDataTable_CMClassFuncRela(string strWhereCond)
{
DataTable objDT;
try
{
objDT = CMClassFuncRelaDA.GetDataTable_CMClassFuncRela(strWhereCond);
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
objDT = CMClassFuncRelaDA.GetDataTable(strWhereCond);
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
objDT = CMClassFuncRelaDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = CMClassFuncRelaDA.GetDataTable(strWhereCond, strTabName);
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
objDT = CMClassFuncRelaDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = CMClassFuncRelaDA.GetDataTable_Top(objTopPara);
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
objDT = CMClassFuncRelaDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = CMClassFuncRelaDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = CMClassFuncRelaDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
public static List<clsCMClassFuncRelaEN> GetObjLstByMIdLst(List<long> arrMIdLst)
{
List<clsCMClassFuncRelaEN> arrObjLst = new List<clsCMClassFuncRelaEN>(); 
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
	clsCMClassFuncRelaEN objCMClassFuncRelaEN = new clsCMClassFuncRelaEN();
try
{
objCMClassFuncRelaEN.mId = Int32.Parse(objRow[conCMClassFuncRela.mId].ToString().Trim()); //mId
objCMClassFuncRelaEN.CmClassId = objRow[conCMClassFuncRela.CmClassId].ToString().Trim(); //类Id
objCMClassFuncRelaEN.CmFunctionId = objRow[conCMClassFuncRela.CmFunctionId].ToString().Trim(); //函数Id
objCMClassFuncRelaEN.OrderNum = objRow[conCMClassFuncRela.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conCMClassFuncRela.OrderNum].ToString().Trim()); //序号
objCMClassFuncRelaEN.UpdDate = objRow[conCMClassFuncRela.UpdDate] == DBNull.Value ? null : objRow[conCMClassFuncRela.UpdDate].ToString().Trim(); //修改日期
objCMClassFuncRelaEN.UpdUser = objRow[conCMClassFuncRela.UpdUser] == DBNull.Value ? null : objRow[conCMClassFuncRela.UpdUser].ToString().Trim(); //修改者
objCMClassFuncRelaEN.Memo = objRow[conCMClassFuncRela.Memo] == DBNull.Value ? null : objRow[conCMClassFuncRela.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objCMClassFuncRelaEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objCMClassFuncRelaEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrMIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsCMClassFuncRelaEN> GetObjLstByMIdLstCache(List<long> arrMIdLst)
{
string strKey = string.Format("{0}", clsCMClassFuncRelaEN._CurrTabName);
List<clsCMClassFuncRelaEN> arrCMClassFuncRelaObjLstCache = GetObjLstCache();
IEnumerable <clsCMClassFuncRelaEN> arrCMClassFuncRelaObjLst_Sel =
arrCMClassFuncRelaObjLstCache
.Where(x => arrMIdLst.Contains(x.mId));
return arrCMClassFuncRelaObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsCMClassFuncRelaEN> GetObjLst(string strWhereCond)
{
List<clsCMClassFuncRelaEN> arrObjLst = new List<clsCMClassFuncRelaEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsCMClassFuncRelaEN objCMClassFuncRelaEN = new clsCMClassFuncRelaEN();
try
{
objCMClassFuncRelaEN.mId = Int32.Parse(objRow[conCMClassFuncRela.mId].ToString().Trim()); //mId
objCMClassFuncRelaEN.CmClassId = objRow[conCMClassFuncRela.CmClassId].ToString().Trim(); //类Id
objCMClassFuncRelaEN.CmFunctionId = objRow[conCMClassFuncRela.CmFunctionId].ToString().Trim(); //函数Id
objCMClassFuncRelaEN.OrderNum = objRow[conCMClassFuncRela.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conCMClassFuncRela.OrderNum].ToString().Trim()); //序号
objCMClassFuncRelaEN.UpdDate = objRow[conCMClassFuncRela.UpdDate] == DBNull.Value ? null : objRow[conCMClassFuncRela.UpdDate].ToString().Trim(); //修改日期
objCMClassFuncRelaEN.UpdUser = objRow[conCMClassFuncRela.UpdUser] == DBNull.Value ? null : objRow[conCMClassFuncRela.UpdUser].ToString().Trim(); //修改者
objCMClassFuncRelaEN.Memo = objRow[conCMClassFuncRela.Memo] == DBNull.Value ? null : objRow[conCMClassFuncRela.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objCMClassFuncRelaEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objCMClassFuncRelaEN);
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
public static List<clsCMClassFuncRelaEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsCMClassFuncRelaEN> arrObjLst = new List<clsCMClassFuncRelaEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsCMClassFuncRelaEN objCMClassFuncRelaEN = new clsCMClassFuncRelaEN();
try
{
objCMClassFuncRelaEN.mId = Int32.Parse(objRow[conCMClassFuncRela.mId].ToString().Trim()); //mId
objCMClassFuncRelaEN.CmClassId = objRow[conCMClassFuncRela.CmClassId].ToString().Trim(); //类Id
objCMClassFuncRelaEN.CmFunctionId = objRow[conCMClassFuncRela.CmFunctionId].ToString().Trim(); //函数Id
objCMClassFuncRelaEN.OrderNum = objRow[conCMClassFuncRela.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conCMClassFuncRela.OrderNum].ToString().Trim()); //序号
objCMClassFuncRelaEN.UpdDate = objRow[conCMClassFuncRela.UpdDate] == DBNull.Value ? null : objRow[conCMClassFuncRela.UpdDate].ToString().Trim(); //修改日期
objCMClassFuncRelaEN.UpdUser = objRow[conCMClassFuncRela.UpdUser] == DBNull.Value ? null : objRow[conCMClassFuncRela.UpdUser].ToString().Trim(); //修改者
objCMClassFuncRelaEN.Memo = objRow[conCMClassFuncRela.Memo] == DBNull.Value ? null : objRow[conCMClassFuncRela.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objCMClassFuncRelaEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objCMClassFuncRelaEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objCMClassFuncRelaCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsCMClassFuncRelaEN> GetSubObjLstCache(clsCMClassFuncRelaEN objCMClassFuncRelaCond)
{
List<clsCMClassFuncRelaEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsCMClassFuncRelaEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conCMClassFuncRela.AttributeName)
{
if (objCMClassFuncRelaCond.IsUpdated(strFldName) == false) continue;
if (objCMClassFuncRelaCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objCMClassFuncRelaCond[strFldName].ToString());
}
else
{
if (objCMClassFuncRelaCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objCMClassFuncRelaCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objCMClassFuncRelaCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objCMClassFuncRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objCMClassFuncRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objCMClassFuncRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objCMClassFuncRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objCMClassFuncRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objCMClassFuncRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objCMClassFuncRelaCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objCMClassFuncRelaCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objCMClassFuncRelaCond[strFldName]));
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
public static List<clsCMClassFuncRelaEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsCMClassFuncRelaEN> arrObjLst = new List<clsCMClassFuncRelaEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsCMClassFuncRelaEN objCMClassFuncRelaEN = new clsCMClassFuncRelaEN();
try
{
objCMClassFuncRelaEN.mId = Int32.Parse(objRow[conCMClassFuncRela.mId].ToString().Trim()); //mId
objCMClassFuncRelaEN.CmClassId = objRow[conCMClassFuncRela.CmClassId].ToString().Trim(); //类Id
objCMClassFuncRelaEN.CmFunctionId = objRow[conCMClassFuncRela.CmFunctionId].ToString().Trim(); //函数Id
objCMClassFuncRelaEN.OrderNum = objRow[conCMClassFuncRela.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conCMClassFuncRela.OrderNum].ToString().Trim()); //序号
objCMClassFuncRelaEN.UpdDate = objRow[conCMClassFuncRela.UpdDate] == DBNull.Value ? null : objRow[conCMClassFuncRela.UpdDate].ToString().Trim(); //修改日期
objCMClassFuncRelaEN.UpdUser = objRow[conCMClassFuncRela.UpdUser] == DBNull.Value ? null : objRow[conCMClassFuncRela.UpdUser].ToString().Trim(); //修改者
objCMClassFuncRelaEN.Memo = objRow[conCMClassFuncRela.Memo] == DBNull.Value ? null : objRow[conCMClassFuncRela.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objCMClassFuncRelaEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objCMClassFuncRelaEN);
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
public static List<clsCMClassFuncRelaEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsCMClassFuncRelaEN> arrObjLst = new List<clsCMClassFuncRelaEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsCMClassFuncRelaEN objCMClassFuncRelaEN = new clsCMClassFuncRelaEN();
try
{
objCMClassFuncRelaEN.mId = Int32.Parse(objRow[conCMClassFuncRela.mId].ToString().Trim()); //mId
objCMClassFuncRelaEN.CmClassId = objRow[conCMClassFuncRela.CmClassId].ToString().Trim(); //类Id
objCMClassFuncRelaEN.CmFunctionId = objRow[conCMClassFuncRela.CmFunctionId].ToString().Trim(); //函数Id
objCMClassFuncRelaEN.OrderNum = objRow[conCMClassFuncRela.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conCMClassFuncRela.OrderNum].ToString().Trim()); //序号
objCMClassFuncRelaEN.UpdDate = objRow[conCMClassFuncRela.UpdDate] == DBNull.Value ? null : objRow[conCMClassFuncRela.UpdDate].ToString().Trim(); //修改日期
objCMClassFuncRelaEN.UpdUser = objRow[conCMClassFuncRela.UpdUser] == DBNull.Value ? null : objRow[conCMClassFuncRela.UpdUser].ToString().Trim(); //修改者
objCMClassFuncRelaEN.Memo = objRow[conCMClassFuncRela.Memo] == DBNull.Value ? null : objRow[conCMClassFuncRela.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objCMClassFuncRelaEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objCMClassFuncRelaEN);
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
List<clsCMClassFuncRelaEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsCMClassFuncRelaEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsCMClassFuncRelaEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsCMClassFuncRelaEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsCMClassFuncRelaEN> arrObjLst = new List<clsCMClassFuncRelaEN>(); 
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
	clsCMClassFuncRelaEN objCMClassFuncRelaEN = new clsCMClassFuncRelaEN();
try
{
objCMClassFuncRelaEN.mId = Int32.Parse(objRow[conCMClassFuncRela.mId].ToString().Trim()); //mId
objCMClassFuncRelaEN.CmClassId = objRow[conCMClassFuncRela.CmClassId].ToString().Trim(); //类Id
objCMClassFuncRelaEN.CmFunctionId = objRow[conCMClassFuncRela.CmFunctionId].ToString().Trim(); //函数Id
objCMClassFuncRelaEN.OrderNum = objRow[conCMClassFuncRela.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conCMClassFuncRela.OrderNum].ToString().Trim()); //序号
objCMClassFuncRelaEN.UpdDate = objRow[conCMClassFuncRela.UpdDate] == DBNull.Value ? null : objRow[conCMClassFuncRela.UpdDate].ToString().Trim(); //修改日期
objCMClassFuncRelaEN.UpdUser = objRow[conCMClassFuncRela.UpdUser] == DBNull.Value ? null : objRow[conCMClassFuncRela.UpdUser].ToString().Trim(); //修改者
objCMClassFuncRelaEN.Memo = objRow[conCMClassFuncRela.Memo] == DBNull.Value ? null : objRow[conCMClassFuncRela.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objCMClassFuncRelaEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objCMClassFuncRelaEN);
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
public static List<clsCMClassFuncRelaEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsCMClassFuncRelaEN> arrObjLst = new List<clsCMClassFuncRelaEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsCMClassFuncRelaEN objCMClassFuncRelaEN = new clsCMClassFuncRelaEN();
try
{
objCMClassFuncRelaEN.mId = Int32.Parse(objRow[conCMClassFuncRela.mId].ToString().Trim()); //mId
objCMClassFuncRelaEN.CmClassId = objRow[conCMClassFuncRela.CmClassId].ToString().Trim(); //类Id
objCMClassFuncRelaEN.CmFunctionId = objRow[conCMClassFuncRela.CmFunctionId].ToString().Trim(); //函数Id
objCMClassFuncRelaEN.OrderNum = objRow[conCMClassFuncRela.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conCMClassFuncRela.OrderNum].ToString().Trim()); //序号
objCMClassFuncRelaEN.UpdDate = objRow[conCMClassFuncRela.UpdDate] == DBNull.Value ? null : objRow[conCMClassFuncRela.UpdDate].ToString().Trim(); //修改日期
objCMClassFuncRelaEN.UpdUser = objRow[conCMClassFuncRela.UpdUser] == DBNull.Value ? null : objRow[conCMClassFuncRela.UpdUser].ToString().Trim(); //修改者
objCMClassFuncRelaEN.Memo = objRow[conCMClassFuncRela.Memo] == DBNull.Value ? null : objRow[conCMClassFuncRela.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objCMClassFuncRelaEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objCMClassFuncRelaEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsCMClassFuncRelaEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsCMClassFuncRelaEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsCMClassFuncRelaEN> arrObjLst = new List<clsCMClassFuncRelaEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsCMClassFuncRelaEN objCMClassFuncRelaEN = new clsCMClassFuncRelaEN();
try
{
objCMClassFuncRelaEN.mId = Int32.Parse(objRow[conCMClassFuncRela.mId].ToString().Trim()); //mId
objCMClassFuncRelaEN.CmClassId = objRow[conCMClassFuncRela.CmClassId].ToString().Trim(); //类Id
objCMClassFuncRelaEN.CmFunctionId = objRow[conCMClassFuncRela.CmFunctionId].ToString().Trim(); //函数Id
objCMClassFuncRelaEN.OrderNum = objRow[conCMClassFuncRela.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conCMClassFuncRela.OrderNum].ToString().Trim()); //序号
objCMClassFuncRelaEN.UpdDate = objRow[conCMClassFuncRela.UpdDate] == DBNull.Value ? null : objRow[conCMClassFuncRela.UpdDate].ToString().Trim(); //修改日期
objCMClassFuncRelaEN.UpdUser = objRow[conCMClassFuncRela.UpdUser] == DBNull.Value ? null : objRow[conCMClassFuncRela.UpdUser].ToString().Trim(); //修改者
objCMClassFuncRelaEN.Memo = objRow[conCMClassFuncRela.Memo] == DBNull.Value ? null : objRow[conCMClassFuncRela.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objCMClassFuncRelaEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objCMClassFuncRelaEN);
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
public static List<clsCMClassFuncRelaEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsCMClassFuncRelaEN> arrObjLst = new List<clsCMClassFuncRelaEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsCMClassFuncRelaEN objCMClassFuncRelaEN = new clsCMClassFuncRelaEN();
try
{
objCMClassFuncRelaEN.mId = Int32.Parse(objRow[conCMClassFuncRela.mId].ToString().Trim()); //mId
objCMClassFuncRelaEN.CmClassId = objRow[conCMClassFuncRela.CmClassId].ToString().Trim(); //类Id
objCMClassFuncRelaEN.CmFunctionId = objRow[conCMClassFuncRela.CmFunctionId].ToString().Trim(); //函数Id
objCMClassFuncRelaEN.OrderNum = objRow[conCMClassFuncRela.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conCMClassFuncRela.OrderNum].ToString().Trim()); //序号
objCMClassFuncRelaEN.UpdDate = objRow[conCMClassFuncRela.UpdDate] == DBNull.Value ? null : objRow[conCMClassFuncRela.UpdDate].ToString().Trim(); //修改日期
objCMClassFuncRelaEN.UpdUser = objRow[conCMClassFuncRela.UpdUser] == DBNull.Value ? null : objRow[conCMClassFuncRela.UpdUser].ToString().Trim(); //修改者
objCMClassFuncRelaEN.Memo = objRow[conCMClassFuncRela.Memo] == DBNull.Value ? null : objRow[conCMClassFuncRela.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objCMClassFuncRelaEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objCMClassFuncRelaEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsCMClassFuncRelaEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsCMClassFuncRelaEN> arrObjLst = new List<clsCMClassFuncRelaEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsCMClassFuncRelaEN objCMClassFuncRelaEN = new clsCMClassFuncRelaEN();
try
{
objCMClassFuncRelaEN.mId = Int32.Parse(objRow[conCMClassFuncRela.mId].ToString().Trim()); //mId
objCMClassFuncRelaEN.CmClassId = objRow[conCMClassFuncRela.CmClassId].ToString().Trim(); //类Id
objCMClassFuncRelaEN.CmFunctionId = objRow[conCMClassFuncRela.CmFunctionId].ToString().Trim(); //函数Id
objCMClassFuncRelaEN.OrderNum = objRow[conCMClassFuncRela.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conCMClassFuncRela.OrderNum].ToString().Trim()); //序号
objCMClassFuncRelaEN.UpdDate = objRow[conCMClassFuncRela.UpdDate] == DBNull.Value ? null : objRow[conCMClassFuncRela.UpdDate].ToString().Trim(); //修改日期
objCMClassFuncRelaEN.UpdUser = objRow[conCMClassFuncRela.UpdUser] == DBNull.Value ? null : objRow[conCMClassFuncRela.UpdUser].ToString().Trim(); //修改者
objCMClassFuncRelaEN.Memo = objRow[conCMClassFuncRela.Memo] == DBNull.Value ? null : objRow[conCMClassFuncRela.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objCMClassFuncRelaEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objCMClassFuncRelaEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objCMClassFuncRelaEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetCMClassFuncRela(ref clsCMClassFuncRelaEN objCMClassFuncRelaEN)
{
bool bolResult = CMClassFuncRelaDA.GetCMClassFuncRela(ref objCMClassFuncRelaEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public static clsCMClassFuncRelaEN GetObjBymId(long lngmId)
{
clsCMClassFuncRelaEN objCMClassFuncRelaEN = CMClassFuncRelaDA.GetObjBymId(lngmId);
return objCMClassFuncRelaEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsCMClassFuncRelaEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsCMClassFuncRelaEN objCMClassFuncRelaEN = CMClassFuncRelaDA.GetFirstObj(strWhereCond);
 return objCMClassFuncRelaEN;
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
public static clsCMClassFuncRelaEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsCMClassFuncRelaEN objCMClassFuncRelaEN = CMClassFuncRelaDA.GetObjByDataRow(objRow);
 return objCMClassFuncRelaEN;
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
public static clsCMClassFuncRelaEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsCMClassFuncRelaEN objCMClassFuncRelaEN = CMClassFuncRelaDA.GetObjByDataRow(objRow);
 return objCMClassFuncRelaEN;
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
 /// <param name = "lstCMClassFuncRelaObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsCMClassFuncRelaEN GetObjBymIdFromList(long lngmId, List<clsCMClassFuncRelaEN> lstCMClassFuncRelaObjLst)
{
foreach (clsCMClassFuncRelaEN objCMClassFuncRelaEN in lstCMClassFuncRelaObjLst)
{
if (objCMClassFuncRelaEN.mId == lngmId)
{
return objCMClassFuncRelaEN;
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
 lngmId = new clsCMClassFuncRelaDA().GetFirstID(strWhereCond);
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
 arrList = CMClassFuncRelaDA.GetID(strWhereCond);
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
bool bolIsExist = CMClassFuncRelaDA.IsExistCondRec(strWhereCond);
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
bool bolIsExist = CMClassFuncRelaDA.IsExist(lngmId);
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
 bolIsExist = clsCMClassFuncRelaDA.IsExistTable();
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
 bolIsExist = CMClassFuncRelaDA.IsExistTable(strTabName);
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
 /// <param name = "objCMClassFuncRelaEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecordBySql2(clsCMClassFuncRelaEN objCMClassFuncRelaEN, bool bolIsNeedCheckUniqueness=true)
{
if (bolIsNeedCheckUniqueness == true && objCMClassFuncRelaEN.CheckUniqueness() == false)
{
var strMsg = string.Format("记录已经存在!函数Id = [{0}],类Id = [{1}]的数据已经存在!(in clsCMClassFuncRelaBL.AddNewRecordBySql2)", objCMClassFuncRelaEN.CmFunctionId,objCMClassFuncRelaEN.CmClassId);
throw new Exception(strMsg);
}
try
{
bool bolResult = CMClassFuncRelaDA.AddNewRecordBySQL2(objCMClassFuncRelaEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsCMClassFuncRelaBL.ReFreshCache();

if (clsCMClassFuncRelaBL.relatedActions != null)
{
clsCMClassFuncRelaBL.relatedActions.UpdRelaTabDate(objCMClassFuncRelaEN.mId, "SetUpdDate");
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
 /// <param name = "objCMClassFuncRelaEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordBySql2WithReturnKey(clsCMClassFuncRelaEN objCMClassFuncRelaEN, bool bolIsNeedCheckUniqueness=true)
{
if (bolIsNeedCheckUniqueness == true && objCMClassFuncRelaEN.CheckUniqueness() == false)
{
var strMsg = string.Format("记录已经存在!函数Id = [{0}],类Id = [{1}]的数据已经存在!(in clsCMClassFuncRelaBL.AddNewRecordBySql2WithReturnKey)", objCMClassFuncRelaEN.CmFunctionId,objCMClassFuncRelaEN.CmClassId);
throw new Exception(strMsg);
}
try
{
string strKey = CMClassFuncRelaDA.AddNewRecordBySQL2WithReturnKey(objCMClassFuncRelaEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsCMClassFuncRelaBL.ReFreshCache();

if (clsCMClassFuncRelaBL.relatedActions != null)
{
clsCMClassFuncRelaBL.relatedActions.UpdRelaTabDate(objCMClassFuncRelaEN.mId, "SetUpdDate");
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
 /// <param name = "objCMClassFuncRelaEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(clsCMClassFuncRelaEN objCMClassFuncRelaEN)
{
try
{
bool bolResult = CMClassFuncRelaDA.Update(objCMClassFuncRelaEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsCMClassFuncRelaBL.ReFreshCache();

if (clsCMClassFuncRelaBL.relatedActions != null)
{
clsCMClassFuncRelaBL.relatedActions.UpdRelaTabDate(objCMClassFuncRelaEN.mId, "SetUpdDate");
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
 /// <param name = "objCMClassFuncRelaEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateBySql2(clsCMClassFuncRelaEN objCMClassFuncRelaEN)
{
 if (objCMClassFuncRelaEN.mId == 0)
 {
var strMsg = string.Format("(errid:Busi000065)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = CMClassFuncRelaDA.UpdateBySql2(objCMClassFuncRelaEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsCMClassFuncRelaBL.ReFreshCache();

if (clsCMClassFuncRelaBL.relatedActions != null)
{
clsCMClassFuncRelaBL.relatedActions.UpdRelaTabDate(objCMClassFuncRelaEN.mId, "SetUpdDate");
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
 clsCMClassFuncRelaEN objCMClassFuncRelaEN = clsCMClassFuncRelaBL.GetObjBymId(lngmId);

if (clsCMClassFuncRelaBL.relatedActions != null)
{
clsCMClassFuncRelaBL.relatedActions.UpdRelaTabDate(objCMClassFuncRelaEN.mId, "SetUpdDate");
}
if (objCMClassFuncRelaEN != null)
{
int intRecNum = CMClassFuncRelaDA.DelRecord(lngmId);
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
objSQL = clsCMClassFuncRelaDA.GetSpecSQLObj();
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
//删除与表:[CMClassFuncRela]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conCMClassFuncRela.mId,
//lngmId);
//        clsCMClassFuncRelaBL.DelCMClassFuncRelasByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsCMClassFuncRelaBL.DelRecord(lngmId, objConnection, objSqlTransaction);
objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsCMClassFuncRelaBLEx", "DelRecordEx", objException.Message, clsSysParaEN.strUserId);
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
if (clsCMClassFuncRelaBL.relatedActions != null)
{
clsCMClassFuncRelaBL.relatedActions.UpdRelaTabDate(lngmId, "UpdRelaTabDate");
}
bool bolResult = CMClassFuncRelaDA.DelRecord(lngmId,objSqlConnection,objSqlTransaction);
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
public static int DelCMClassFuncRelas(List<string> arrmIdLst)
{
if (arrmIdLst.Count == 0) return 0;
try
{
if (clsCMClassFuncRelaBL.relatedActions != null)
{
foreach (var strmId in arrmIdLst)
{
long lngmId = long.Parse(strmId);
clsCMClassFuncRelaBL.relatedActions.UpdRelaTabDate(lngmId, "UpdRelaTabDate");
}
}
int intDelRecNum = CMClassFuncRelaDA.DelCMClassFuncRela(arrmIdLst);
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
public static int DelCMClassFuncRelasByCond(string strWhereCond)
{
try
{
if (clsCMClassFuncRelaBL.relatedActions != null)
{
List<string> arrmId = GetPrimaryKeyID_S(strWhereCond);
foreach (var strmId in arrmId)
{
long lngmId = long.Parse(strmId);
clsCMClassFuncRelaBL.relatedActions.UpdRelaTabDate(lngmId, "UpdRelaTabDate");
}
}
int intRecNum = CMClassFuncRelaDA.DelCMClassFuncRela(strWhereCond);
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
/// 这里仅仅是演示函数,使用时请复制到扩展类:[CMClassFuncRela]中改名为:[DelRecord4MultiTabEx]使用
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DelRecord4MultiTab)
/// </summary>
/// <param name="lngmId">表关键字</param>
/// <returns></returns>
public static bool DelRecord4MultiTab(long lngmId)
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsCMClassFuncRelaDA.GetSpecSQLObj();
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
//删除与表:[CMClassFuncRela]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conStudent.id_College,
//strid_College);
//        clsStudentBL.DelStudentsByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsCMClassFuncRelaBL.DelRecord(lngmId, objConnection, objSqlTransaction);
                objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsCMClassFuncRelaBL", "DelRecord4MultiTab", objException.Message, clsSysParaEN.strUserId);
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
 /// <param name = "objCMClassFuncRelaENS">源对象</param>
 /// <param name = "objCMClassFuncRelaENT">目标对象</param>
 public static void CopyTo(clsCMClassFuncRelaEN objCMClassFuncRelaENS, clsCMClassFuncRelaEN objCMClassFuncRelaENT)
{
try
{
objCMClassFuncRelaENT.mId = objCMClassFuncRelaENS.mId; //mId
objCMClassFuncRelaENT.CmClassId = objCMClassFuncRelaENS.CmClassId; //类Id
objCMClassFuncRelaENT.CmFunctionId = objCMClassFuncRelaENS.CmFunctionId; //函数Id
objCMClassFuncRelaENT.OrderNum = objCMClassFuncRelaENS.OrderNum; //序号
objCMClassFuncRelaENT.UpdDate = objCMClassFuncRelaENS.UpdDate; //修改日期
objCMClassFuncRelaENT.UpdUser = objCMClassFuncRelaENS.UpdUser; //修改者
objCMClassFuncRelaENT.Memo = objCMClassFuncRelaENS.Memo; //说明
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
 /// <param name = "objCMClassFuncRelaEN">源简化对象</param>
 public static void SetUpdFlag(clsCMClassFuncRelaEN objCMClassFuncRelaEN)
{
try
{
objCMClassFuncRelaEN.ClearUpdateState();
   string strsfUpdFldSetStr = objCMClassFuncRelaEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(conCMClassFuncRela.mId, new clsStrCompareIgnoreCase())  ==  true)
{
objCMClassFuncRelaEN.mId = objCMClassFuncRelaEN.mId; //mId
}
if (arrFldSet.Contains(conCMClassFuncRela.CmClassId, new clsStrCompareIgnoreCase())  ==  true)
{
objCMClassFuncRelaEN.CmClassId = objCMClassFuncRelaEN.CmClassId; //类Id
}
if (arrFldSet.Contains(conCMClassFuncRela.CmFunctionId, new clsStrCompareIgnoreCase())  ==  true)
{
objCMClassFuncRelaEN.CmFunctionId = objCMClassFuncRelaEN.CmFunctionId; //函数Id
}
if (arrFldSet.Contains(conCMClassFuncRela.OrderNum, new clsStrCompareIgnoreCase())  ==  true)
{
objCMClassFuncRelaEN.OrderNum = objCMClassFuncRelaEN.OrderNum; //序号
}
if (arrFldSet.Contains(conCMClassFuncRela.UpdDate, new clsStrCompareIgnoreCase())  ==  true)
{
objCMClassFuncRelaEN.UpdDate = objCMClassFuncRelaEN.UpdDate == "[null]" ? null :  objCMClassFuncRelaEN.UpdDate; //修改日期
}
if (arrFldSet.Contains(conCMClassFuncRela.UpdUser, new clsStrCompareIgnoreCase())  ==  true)
{
objCMClassFuncRelaEN.UpdUser = objCMClassFuncRelaEN.UpdUser == "[null]" ? null :  objCMClassFuncRelaEN.UpdUser; //修改者
}
if (arrFldSet.Contains(conCMClassFuncRela.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objCMClassFuncRelaEN.Memo = objCMClassFuncRelaEN.Memo == "[null]" ? null :  objCMClassFuncRelaEN.Memo; //说明
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
 /// <param name = "objCMClassFuncRelaEN">源简化对象</param>
 public static void AccessFldValueNull(clsCMClassFuncRelaEN objCMClassFuncRelaEN)
{
try
{
if (objCMClassFuncRelaEN.UpdDate == "[null]") objCMClassFuncRelaEN.UpdDate = null; //修改日期
if (objCMClassFuncRelaEN.UpdUser == "[null]") objCMClassFuncRelaEN.UpdUser = null; //修改者
if (objCMClassFuncRelaEN.Memo == "[null]") objCMClassFuncRelaEN.Memo = null; //说明
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
public static void CheckPropertyNew(clsCMClassFuncRelaEN objCMClassFuncRelaEN)
{
 CMClassFuncRelaDA.CheckPropertyNew(objCMClassFuncRelaEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(clsCMClassFuncRelaEN objCMClassFuncRelaEN)
{
 CMClassFuncRelaDA.CheckProperty4Condition(objCMClassFuncRelaEN);
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
if (clsCMClassFuncRelaBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsCMClassFuncRelaBL没有刷新缓存机制(clsCMClassFuncRelaBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by mId");
//if (arrCMClassFuncRelaObjLstCache == null)
//{
//arrCMClassFuncRelaObjLstCache = CMClassFuncRelaDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "lngmId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsCMClassFuncRelaEN GetObjBymIdCache(long lngmId)
{
//获取缓存中的对象列表
string strKey = string.Format("{0}", clsCMClassFuncRelaEN._CurrTabName);
List<clsCMClassFuncRelaEN> arrCMClassFuncRelaObjLstCache = GetObjLstCache();
IEnumerable <clsCMClassFuncRelaEN> arrCMClassFuncRelaObjLst_Sel =
arrCMClassFuncRelaObjLstCache
.Where(x=> x.mId == lngmId 
);
if (arrCMClassFuncRelaObjLst_Sel.Count() == 0)
{
   clsCMClassFuncRelaEN obj = clsCMClassFuncRelaBL.GetObjBymId(lngmId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
 }
return null;
}
return arrCMClassFuncRelaObjLst_Sel.First();
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsCMClassFuncRelaEN> GetAllCMClassFuncRelaObjLstCache()
{
//获取缓存中的对象列表
List<clsCMClassFuncRelaEN> arrCMClassFuncRelaObjLstCache = GetObjLstCache(); 
return arrCMClassFuncRelaObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsCMClassFuncRelaEN> GetObjLstCache()
{
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}", clsCMClassFuncRelaEN._CurrTabName);
List<clsCMClassFuncRelaEN> arrCMClassFuncRelaObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrCMClassFuncRelaObjLstCache;
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
string strKey = string.Format("{0}", clsCMClassFuncRelaEN._CurrTabName);
CacheHelper.Remove(strKey);
clsCMClassFuncRelaEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
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
if (clsCMClassFuncRelaEN._RefreshTimeLst.Count == 0) return "";
return clsCMClassFuncRelaEN._RefreshTimeLst[clsCMClassFuncRelaEN._RefreshTimeLst.Count - 1];
}

 /// <summary>
 /// 刷新缓存.把当前表的缓存以及该表相关视图的缓存清空.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ReFreshCache)
 /// </summary>
public static void ReFreshCache()
{
if (clsCMClassFuncRelaBL.objCommFun4BL != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}", clsCMClassFuncRelaEN._CurrTabName);
CacheHelper.Remove(strKey);
clsCMClassFuncRelaEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
clsCMClassFuncRelaBL.objCommFun4BL.ReFreshCache();
}
}


 #endregion 缓存操作


 #region 检查唯一性

 /// <summary>
 /// 获取检查唯一性条件串(Uniqueness)--CMClassFuncRela(CM类函数关系)
 /// 唯一性条件:ClassId_FunctionId
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetUniquenessConditionString)
 /// </summary>
 /// <param name = "objCMClassFuncRelaEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(clsCMClassFuncRelaEN objCMClassFuncRelaEN)
{
//检测记录是否存在
string strResult = CMClassFuncRelaDA.GetUniCondStr(objCMClassFuncRelaEN);
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
if (strInFldName != conCMClassFuncRela.mId)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (conCMClassFuncRela.AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", conCMClassFuncRela.AttributeName));
throw new Exception(strMsg);
}
var objCMClassFuncRela = clsCMClassFuncRelaBL.GetObjBymIdCache(lngmId);
if (objCMClassFuncRela == null) return "";
return objCMClassFuncRela[strOutFldName].ToString();
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
int intRecCount = clsCMClassFuncRelaDA.GetRecCount(strTabName);
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
int intRecCount = clsCMClassFuncRelaDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsCMClassFuncRelaDA.GetRecCount();
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
int intRecCount = clsCMClassFuncRelaDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objCMClassFuncRelaCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsCMClassFuncRelaEN objCMClassFuncRelaCond)
{
List<clsCMClassFuncRelaEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsCMClassFuncRelaEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conCMClassFuncRela.AttributeName)
{
if (objCMClassFuncRelaCond.IsUpdated(strFldName) == false) continue;
if (objCMClassFuncRelaCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objCMClassFuncRelaCond[strFldName].ToString());
}
else
{
if (objCMClassFuncRelaCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objCMClassFuncRelaCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objCMClassFuncRelaCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objCMClassFuncRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objCMClassFuncRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objCMClassFuncRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objCMClassFuncRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objCMClassFuncRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objCMClassFuncRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objCMClassFuncRelaCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objCMClassFuncRelaCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objCMClassFuncRelaCond[strFldName]));
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
 List<string> arrList = clsCMClassFuncRelaDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = CMClassFuncRelaDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = CMClassFuncRelaDA.GetFldValueNoDistinct(strFldName, strWhereCond);
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
int intRecCount = CMClassFuncRelaDA.SetFldValue(strFldName, strValue, strWhereCond);
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
int intRecCount = clsCMClassFuncRelaDA.SetFldValue(clsCMClassFuncRelaEN._CurrTabName, strFldName, fltValue, strWhereCond);
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
int intRecCount = CMClassFuncRelaDA.SetFldValue( strFldName, intValue, strWhereCond);
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
int intRecCount = clsCMClassFuncRelaDA.SetFldValue(strTabName, strFldName, strValue, strWhereCond);
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
int intRecCount = clsCMClassFuncRelaDA.SetFldValue(strTabName, strFldName, intValue, strWhereCond);
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
int intRecCount = clsCMClassFuncRelaDA.SetFldValue(strTabName, strFldName, fltValue, strWhereCond);
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
  strCreateTabCode.Append("CREATE table [dbo].[CMClassFuncRela] "); 
 strCreateTabCode.Append(" ( "); 
 // /**mId*/ 
 strCreateTabCode.Append(" mId bigint primary key identity, "); 
 // /**类Id*/ 
 strCreateTabCode.Append(" CmClassId char(8) not Null, "); 
 // /**函数Id*/ 
 strCreateTabCode.Append(" CmFunctionId char(8) not Null, "); 
 // /**序号*/ 
 strCreateTabCode.Append(" OrderNum int Null, "); 
 // /**修改日期*/ 
 strCreateTabCode.Append(" UpdDate varchar(20) Null, "); 
 // /**修改者*/ 
 strCreateTabCode.Append(" UpdUser varchar(20) Null, "); 
 // /**说明*/ 
 strCreateTabCode.Append(" Memo varchar(1000) Null ");
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
string strCondition = string.Format("1 = 1 order by {0} ", conCMClassFuncRela.OrderNum); 
List<clsCMClassFuncRelaEN> arrCMClassFuncRelaObjList = new clsCMClassFuncRelaDA().GetObjLst(strCondition);
    
int intIndex = 1;
foreach (clsCMClassFuncRelaEN objCMClassFuncRela in arrCMClassFuncRelaObjList)
{
objCMClassFuncRela.OrderNum = intIndex;
UpdateBySql2(objCMClassFuncRela);
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

clsCMClassFuncRelaEN objCMClassFuncRela = clsCMClassFuncRelaBL.GetObjBymId(lngmId);

intOrderNum = objCMClassFuncRela.OrderNum ?? 0;//当前序号
intPrevOrderNum = intOrderNum - 1;//前一条记录的序号
intNextOrderNum = intOrderNum + 1;//后一条记录的序号
//3、如果当前序号是否是末端序号,
//		3.1 如果是末端序号,就退出,

intTabRecNum = clsCMClassFuncRelaBL.GetRecCountByCond(clsCMClassFuncRelaEN._CurrTabName, "1 = 1");    //获取当前表的记录数
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
strCondition.AppendFormat(" {0} = {1}", conCMClassFuncRela.OrderNum, intOrderNum - 1);
//4、获取上一个序号字段的关键字mId
lngPrevmId = clsCMClassFuncRelaBL.GetFirstID_S(strCondition.ToString());
if (lngPrevmId == 0)
{
strMsg = string.Format("获取上一条记录的关键字出错.(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//5、把当前关键字mId所对应记录的序号减1
//6、把下(上)一个序号关键字mId所对应的记录序号加1
clsCMClassFuncRelaBL.SetFldValue(clsCMClassFuncRelaEN._CurrTabName, conCMClassFuncRela.OrderNum,
intOrderNum - 1,
string.Format("{0} = '{1}'", conCMClassFuncRela.mId, lngmId));
clsCMClassFuncRelaBL.SetFldValue(clsCMClassFuncRelaEN._CurrTabName, conCMClassFuncRela.OrderNum,
intPrevOrderNum + 1,
string.Format("{0} = '{1}'", conCMClassFuncRela.mId, lngPrevmId));
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
strCondition.AppendFormat(" {0} = {1}", conCMClassFuncRela.OrderNum, intOrderNum + 1);

lngNextmId = clsCMClassFuncRelaBL.GetFirstID_S(strCondition.ToString());
if (lngNextmId == 0)
{
strMsg = string.Format("获取下一条记录的关键字出错.(from {0})", clsStackTrace.GetCurrClassFunction());

throw new Exception(strMsg);
}
//5、把当前关键字mId所对应记录的序号加1
//6、把下(上)一个序号关键字mId所对应的记录序号减1
clsCMClassFuncRelaBL.SetFldValue(clsCMClassFuncRelaEN._CurrTabName, conCMClassFuncRela.OrderNum,
intOrderNum + 1,
string.Format("{0} = '{1}'", conCMClassFuncRela.mId, lngmId));
clsCMClassFuncRelaBL.SetFldValue(clsCMClassFuncRelaEN._CurrTabName, conCMClassFuncRela.OrderNum,
 	 	intNextOrderNum - 1,
 	 	string.Format("{0} = '{1}'", conCMClassFuncRela.mId, lngNextmId));
break;
default:
strMsg = string.Format("方向参数出错!strDirect=[{0}]({1})",
strDirect,
clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
clsCMClassFuncRelaBL.ReFreshCache();
if (clsCMClassFuncRelaBL.relatedActions != null)
{
clsCMClassFuncRelaBL.relatedActions.UpdRelaTabDate(objCMClassFuncRela.mId, "UpdRelaTabDate");
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
string strCondition = string.Format("{0} in ({1})", conCMClassFuncRela.mId, strKeyList);
List<clsCMClassFuncRelaEN> arrCMClassFuncRelaLst = GetObjLst(strCondition);
foreach (clsCMClassFuncRelaEN objCMClassFuncRela in arrCMClassFuncRelaLst)
{
objCMClassFuncRela.OrderNum = objCMClassFuncRela.OrderNum + 10000;
UpdateBySql2(objCMClassFuncRela);
}
strCondition = string.Format("1 = 1 order by {0} ", conCMClassFuncRela.OrderNum); 
List<clsCMClassFuncRelaEN> arrCMClassFuncRelaObjList = new clsCMClassFuncRelaDA().GetObjLst(strCondition);
    
int intIndex = 1;
foreach (clsCMClassFuncRelaEN objCMClassFuncRela in arrCMClassFuncRelaObjList)
{
objCMClassFuncRela.OrderNum = intIndex;
UpdateBySql2(objCMClassFuncRela);
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
string strCondition = string.Format("{0} in ({1})", conCMClassFuncRela.mId, strKeyList);
List<clsCMClassFuncRelaEN> arrCMClassFuncRelaLst = GetObjLst(strCondition);
foreach (clsCMClassFuncRelaEN objCMClassFuncRela in arrCMClassFuncRelaLst)
{
objCMClassFuncRela.OrderNum = objCMClassFuncRela.OrderNum - 10000;
UpdateBySql2(objCMClassFuncRela);
}
strCondition = string.Format("1 = 1 order by {0} ", conCMClassFuncRela.OrderNum); 
List<clsCMClassFuncRelaEN> arrCMClassFuncRelaObjList = new clsCMClassFuncRelaDA().GetObjLst(strCondition);
    
int intIndex = 1;
foreach (clsCMClassFuncRelaEN objCMClassFuncRela in arrCMClassFuncRelaObjList)
{
objCMClassFuncRela.OrderNum = intIndex;
UpdateBySql2(objCMClassFuncRela);
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
 /// CM类函数关系(CMClassFuncRela)
 /// 数据源类型:表
 /// (AutoGCLib.CommFun4BL4CSharp:GeneCode_This)
 /// </summary>
public class  clsCommFun4BL4CMClassFuncRela : clsCommFun4BL
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
clsCMClassFuncRelaBL.ReFreshThisCache();
}
}

}