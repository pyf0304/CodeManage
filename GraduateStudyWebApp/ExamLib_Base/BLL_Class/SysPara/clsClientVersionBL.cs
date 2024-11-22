
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsClientVersionBL
 表名:ClientVersion(01120276)
 * 版本:2023.08.23.1(服务器:WIN-SRV103-116)
 日期:2023/08/24 13:08:23
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:公共后台所有表(变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:系统参数(SysPara)
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
public static class  clsClientVersionBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "strClientVersionId">表关键字</param>
 /// <returns>表对象</returns>
public static clsClientVersionEN GetObj(this K_ClientVersionId_ClientVersion myKey)
{
clsClientVersionEN objClientVersionEN = clsClientVersionBL.ClientVersionDA.GetObjByClientVersionId(myKey.Value);
return objClientVersionEN;
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_AddNewRecord)
 /// </summary>
 /// <param name = "objClientVersionEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clsClientVersionEN objClientVersionEN)
{
 if (string.IsNullOrEmpty(objClientVersionEN.ClientVersionId) == true)
 {
string strMsg = string.Format("添加记录时,关键字不能为空!(from {0})\r\n", 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
 if (clsClientVersionBL.IsExist(objClientVersionEN.ClientVersionId) == true)
 {
string strMsg = string.Format("添加记录时,关键字:[{0}]已经存在!(from {1})\r\n", objClientVersionEN.ClientVersionId, 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
try
{
bool bolResult = clsClientVersionBL.ClientVersionDA.AddNewRecordBySQL2(objClientVersionEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsClientVersionBL.ReFreshCache();

if (clsClientVersionBL.relatedActions != null)
{
clsClientVersionBL.relatedActions.UpdRelaTabDate(objClientVersionEN.ClientVersionId, objClientVersionEN.UpdUser);
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
public static bool AddRecordEx(this clsClientVersionEN objClientVersionEN)
{
//操作步骤:
//1、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在
//2、检查唯一性
//3、检查传进去的对象属性是否合法
//4、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
//1、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在
if (clsClientVersionBL.IsExist(objClientVersionEN.ClientVersionId))	//判断是否有相同的关键字
{
strMsg = "(errid:Busi000151)关键字字段已有相同的值";
throw new Exception(strMsg);
}
try
{
 //2、检查传进去的对象属性是否合法
objClientVersionEN.CheckPropertyNew();
//6、把数据实体层的数据存贮到数据库中
objClientVersionEN.AddNewRecord();
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
 /// <param name = "objClientVersionEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordWithReturnKey(this clsClientVersionEN objClientVersionEN)
{
 if (string.IsNullOrEmpty(objClientVersionEN.ClientVersionId) == true)
 {
string strMsg = string.Format("添加记录时,关键字不能为空!(from {{0}})", 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
 if (clsClientVersionBL.IsExist(objClientVersionEN.ClientVersionId) == true)
 {
string strMsg = string.Format("添加记录时,关键字:[{0}]已经存在!(from {1})\r\n", objClientVersionEN.ClientVersionId, 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
try
{
string strKey = clsClientVersionBL.ClientVersionDA.AddNewRecordBySQL2WithReturnKey(objClientVersionEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsClientVersionBL.ReFreshCache();

if (clsClientVersionBL.relatedActions != null)
{
clsClientVersionBL.relatedActions.UpdRelaTabDate(objClientVersionEN.ClientVersionId, objClientVersionEN.UpdUser);
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
 /// <param name = "objClientVersionEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsClientVersionEN SetClientVersionId(this clsClientVersionEN objClientVersionEN, string strClientVersionId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strClientVersionId, 8, conClientVersion.ClientVersionId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strClientVersionId, 8, conClientVersion.ClientVersionId);
}
objClientVersionEN.ClientVersionId = strClientVersionId; //客户端版本Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objClientVersionEN.dicFldComparisonOp.ContainsKey(conClientVersion.ClientVersionId) == false)
{
objClientVersionEN.dicFldComparisonOp.Add(conClientVersion.ClientVersionId, strComparisonOp);
}
else
{
objClientVersionEN.dicFldComparisonOp[conClientVersion.ClientVersionId] = strComparisonOp;
}
}
return objClientVersionEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objClientVersionEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsClientVersionEN SetClientVersionTypeId(this clsClientVersionEN objClientVersionEN, string strClientVersionTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strClientVersionTypeId, conClientVersion.ClientVersionTypeId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strClientVersionTypeId, 8, conClientVersion.ClientVersionTypeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strClientVersionTypeId, 8, conClientVersion.ClientVersionTypeId);
}
objClientVersionEN.ClientVersionTypeId = strClientVersionTypeId; //客户端版本类型Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objClientVersionEN.dicFldComparisonOp.ContainsKey(conClientVersion.ClientVersionTypeId) == false)
{
objClientVersionEN.dicFldComparisonOp.Add(conClientVersion.ClientVersionTypeId, strComparisonOp);
}
else
{
objClientVersionEN.dicFldComparisonOp[conClientVersion.ClientVersionTypeId] = strComparisonOp;
}
}
return objClientVersionEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objClientVersionEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsClientVersionEN SetVersionDescription(this clsClientVersionEN objClientVersionEN, string strVersionDescription, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strVersionDescription, 1000, conClientVersion.VersionDescription);
}
objClientVersionEN.VersionDescription = strVersionDescription; //版本说明
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objClientVersionEN.dicFldComparisonOp.ContainsKey(conClientVersion.VersionDescription) == false)
{
objClientVersionEN.dicFldComparisonOp.Add(conClientVersion.VersionDescription, strComparisonOp);
}
else
{
objClientVersionEN.dicFldComparisonOp[conClientVersion.VersionDescription] = strComparisonOp;
}
}
return objClientVersionEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objClientVersionEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsClientVersionEN SetVersionNumber(this clsClientVersionEN objClientVersionEN, string strVersionNumber, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strVersionNumber, conClientVersion.VersionNumber);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strVersionNumber, 50, conClientVersion.VersionNumber);
}
objClientVersionEN.VersionNumber = strVersionNumber; //版本号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objClientVersionEN.dicFldComparisonOp.ContainsKey(conClientVersion.VersionNumber) == false)
{
objClientVersionEN.dicFldComparisonOp.Add(conClientVersion.VersionNumber, strComparisonOp);
}
else
{
objClientVersionEN.dicFldComparisonOp[conClientVersion.VersionNumber] = strComparisonOp;
}
}
return objClientVersionEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objClientVersionEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsClientVersionEN SetVersionState(this clsClientVersionEN objClientVersionEN, bool bolVersionState, string strComparisonOp="")
	{
objClientVersionEN.VersionState = bolVersionState; //版本状态
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objClientVersionEN.dicFldComparisonOp.ContainsKey(conClientVersion.VersionState) == false)
{
objClientVersionEN.dicFldComparisonOp.Add(conClientVersion.VersionState, strComparisonOp);
}
else
{
objClientVersionEN.dicFldComparisonOp[conClientVersion.VersionState] = strComparisonOp;
}
}
return objClientVersionEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objClientVersionEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsClientVersionEN SetVersionUrl(this clsClientVersionEN objClientVersionEN, string strVersionUrl, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strVersionUrl, conClientVersion.VersionUrl);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strVersionUrl, 500, conClientVersion.VersionUrl);
}
objClientVersionEN.VersionUrl = strVersionUrl; //版本文件
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objClientVersionEN.dicFldComparisonOp.ContainsKey(conClientVersion.VersionUrl) == false)
{
objClientVersionEN.dicFldComparisonOp.Add(conClientVersion.VersionUrl, strComparisonOp);
}
else
{
objClientVersionEN.dicFldComparisonOp[conClientVersion.VersionUrl] = strComparisonOp;
}
}
return objClientVersionEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objClientVersionEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsClientVersionEN SetVersionCode(this clsClientVersionEN objClientVersionEN, string strVersionCode, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strVersionCode, conClientVersion.VersionCode);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strVersionCode, 50, conClientVersion.VersionCode);
}
objClientVersionEN.VersionCode = strVersionCode; //VersionCode
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objClientVersionEN.dicFldComparisonOp.ContainsKey(conClientVersion.VersionCode) == false)
{
objClientVersionEN.dicFldComparisonOp.Add(conClientVersion.VersionCode, strComparisonOp);
}
else
{
objClientVersionEN.dicFldComparisonOp[conClientVersion.VersionCode] = strComparisonOp;
}
}
return objClientVersionEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objClientVersionEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsClientVersionEN SetPrjId(this clsClientVersionEN objClientVersionEN, string strPrjId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPrjId, 4, conClientVersion.PrjId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strPrjId, 4, conClientVersion.PrjId);
}
objClientVersionEN.PrjId = strPrjId; //PrjId
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objClientVersionEN.dicFldComparisonOp.ContainsKey(conClientVersion.PrjId) == false)
{
objClientVersionEN.dicFldComparisonOp.Add(conClientVersion.PrjId, strComparisonOp);
}
else
{
objClientVersionEN.dicFldComparisonOp[conClientVersion.PrjId] = strComparisonOp;
}
}
return objClientVersionEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objClientVersionEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsClientVersionEN SetUpdDate(this clsClientVersionEN objClientVersionEN, string strUpdDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdDate, 20, conClientVersion.UpdDate);
}
objClientVersionEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objClientVersionEN.dicFldComparisonOp.ContainsKey(conClientVersion.UpdDate) == false)
{
objClientVersionEN.dicFldComparisonOp.Add(conClientVersion.UpdDate, strComparisonOp);
}
else
{
objClientVersionEN.dicFldComparisonOp[conClientVersion.UpdDate] = strComparisonOp;
}
}
return objClientVersionEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objClientVersionEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsClientVersionEN SetUpdUser(this clsClientVersionEN objClientVersionEN, string strUpdUser, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdUser, 20, conClientVersion.UpdUser);
}
objClientVersionEN.UpdUser = strUpdUser; //修改人
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objClientVersionEN.dicFldComparisonOp.ContainsKey(conClientVersion.UpdUser) == false)
{
objClientVersionEN.dicFldComparisonOp.Add(conClientVersion.UpdUser, strComparisonOp);
}
else
{
objClientVersionEN.dicFldComparisonOp[conClientVersion.UpdUser] = strComparisonOp;
}
}
return objClientVersionEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objClientVersionEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsClientVersionEN SetMemo(this clsClientVersionEN objClientVersionEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, conClientVersion.Memo);
}
objClientVersionEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objClientVersionEN.dicFldComparisonOp.ContainsKey(conClientVersion.Memo) == false)
{
objClientVersionEN.dicFldComparisonOp.Add(conClientVersion.Memo, strComparisonOp);
}
else
{
objClientVersionEN.dicFldComparisonOp[conClientVersion.Memo] = strComparisonOp;
}
}
return objClientVersionEN;
	}

 /// <summary>
 /// 修改记录存盘到数据表中
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_UpdateRecordEx)
 /// </summary>
 /// <param name = "objClientVersionEN">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool UpdateRecordEx(this clsClientVersionEN objClientVersionEN)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
try
{
//1、检查传进去的对象属性是否合法
objClientVersionEN.CheckPropertyNew();
clsClientVersionEN objClientVersionCond = new clsClientVersionEN();
string strCondition = objClientVersionCond
.SetClientVersionId(objClientVersionEN.ClientVersionId, "=")
.GetCombineCondition();
objClientVersionEN._IsCheckProperty = true;
bool bolIsExist = clsClientVersionBL.IsExistRecord(strCondition);
if (bolIsExist)
{
strMsg = "()不能重复!";
throw new Exception(strMsg);
}
//4、把数据实体层的数据存贮到数据库中
objClientVersionEN.Update();
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
 /// <param name = "objClientVersionEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsClientVersionEN objClientVersionEN)
{
 if (string.IsNullOrEmpty(objClientVersionEN.ClientVersionId) == true)
 {
string strMsg = string.Format("(errid:Busi000095)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsClientVersionBL.ClientVersionDA.UpdateBySql2(objClientVersionEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsClientVersionBL.ReFreshCache();

if (clsClientVersionBL.relatedActions != null)
{
clsClientVersionBL.relatedActions.UpdRelaTabDate(objClientVersionEN.ClientVersionId, objClientVersionEN.UpdUser);
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
 /// <param name = "objClientVersionEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsClientVersionEN objClientVersionEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (string.IsNullOrEmpty(objClientVersionEN.ClientVersionId) == true)
 {
string strMsg = string.Format("(errid:Busi000087)修改记录时关键字不能为空!(带事务处理)(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsClientVersionBL.ClientVersionDA.UpdateBySql2(objClientVersionEN, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsClientVersionBL.ReFreshCache();

if (clsClientVersionBL.relatedActions != null)
{
clsClientVersionBL.relatedActions.UpdRelaTabDate(objClientVersionEN.ClientVersionId, objClientVersionEN.UpdUser);
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
 /// <param name = "objClientVersionEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsClientVersionEN objClientVersionEN, string strWhereCond)
{
try
{
bool bolResult = clsClientVersionBL.ClientVersionDA.UpdateBySqlWithCondition(objClientVersionEN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsClientVersionBL.ReFreshCache();

if (clsClientVersionBL.relatedActions != null)
{
clsClientVersionBL.relatedActions.UpdRelaTabDate(objClientVersionEN.ClientVersionId, objClientVersionEN.UpdUser);
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
 /// <param name = "objClientVersionEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsClientVersionEN objClientVersionEN, string strWhereCond, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
bool bolResult = clsClientVersionBL.ClientVersionDA.UpdateBySqlWithConditionTransaction(objClientVersionEN, strWhereCond, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsClientVersionBL.ReFreshCache();

if (clsClientVersionBL.relatedActions != null)
{
clsClientVersionBL.relatedActions.UpdRelaTabDate(objClientVersionEN.ClientVersionId, objClientVersionEN.UpdUser);
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
 /// <param name = "strClientVersionId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int Delete(this clsClientVersionEN objClientVersionEN)
{
try
{
int intRecNum = clsClientVersionBL.ClientVersionDA.DelRecord(objClientVersionEN.ClientVersionId);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsClientVersionBL.ReFreshCache();

if (clsClientVersionBL.relatedActions != null)
{
clsClientVersionBL.relatedActions.UpdRelaTabDate(objClientVersionEN.ClientVersionId, objClientVersionEN.UpdUser);
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
 /// <param name = "objClientVersionENS">源对象</param>
 /// <param name = "objClientVersionENT">目标对象</param>
 public static void CopyTo(this clsClientVersionEN objClientVersionENS, clsClientVersionEN objClientVersionENT)
{
try
{
objClientVersionENT.ClientVersionId = objClientVersionENS.ClientVersionId; //客户端版本Id
objClientVersionENT.ClientVersionTypeId = objClientVersionENS.ClientVersionTypeId; //客户端版本类型Id
objClientVersionENT.VersionDescription = objClientVersionENS.VersionDescription; //版本说明
objClientVersionENT.VersionNumber = objClientVersionENS.VersionNumber; //版本号
objClientVersionENT.VersionState = objClientVersionENS.VersionState; //版本状态
objClientVersionENT.VersionUrl = objClientVersionENS.VersionUrl; //版本文件
objClientVersionENT.VersionCode = objClientVersionENS.VersionCode; //VersionCode
objClientVersionENT.PrjId = objClientVersionENS.PrjId; //PrjId
objClientVersionENT.UpdDate = objClientVersionENS.UpdDate; //修改日期
objClientVersionENT.UpdUser = objClientVersionENS.UpdUser; //修改人
objClientVersionENT.Memo = objClientVersionENS.Memo; //备注
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
 /// <param name = "objClientVersionENS">源对象</param>
 /// <returns>目标对象=>clsClientVersionEN:objClientVersionENT</returns>
 public static clsClientVersionEN CopyTo(this clsClientVersionEN objClientVersionENS)
{
try
{
 clsClientVersionEN objClientVersionENT = new clsClientVersionEN()
{
ClientVersionId = objClientVersionENS.ClientVersionId, //客户端版本Id
ClientVersionTypeId = objClientVersionENS.ClientVersionTypeId, //客户端版本类型Id
VersionDescription = objClientVersionENS.VersionDescription, //版本说明
VersionNumber = objClientVersionENS.VersionNumber, //版本号
VersionState = objClientVersionENS.VersionState, //版本状态
VersionUrl = objClientVersionENS.VersionUrl, //版本文件
VersionCode = objClientVersionENS.VersionCode, //VersionCode
PrjId = objClientVersionENS.PrjId, //PrjId
UpdDate = objClientVersionENS.UpdDate, //修改日期
UpdUser = objClientVersionENS.UpdUser, //修改人
Memo = objClientVersionENS.Memo, //备注
};
 return objClientVersionENT;
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
public static void CheckPropertyNew(this clsClientVersionEN objClientVersionEN)
{
 clsClientVersionBL.ClientVersionDA.CheckPropertyNew(objClientVersionEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(this clsClientVersionEN objClientVersionEN)
{
 clsClientVersionBL.ClientVersionDA.CheckProperty4Condition(objClientVersionEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsClientVersionEN objClientVersionCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objClientVersionCond.IsUpdated(conClientVersion.ClientVersionId) == true)
{
string strComparisonOpClientVersionId = objClientVersionCond.dicFldComparisonOp[conClientVersion.ClientVersionId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conClientVersion.ClientVersionId, objClientVersionCond.ClientVersionId, strComparisonOpClientVersionId);
}
if (objClientVersionCond.IsUpdated(conClientVersion.ClientVersionTypeId) == true)
{
string strComparisonOpClientVersionTypeId = objClientVersionCond.dicFldComparisonOp[conClientVersion.ClientVersionTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conClientVersion.ClientVersionTypeId, objClientVersionCond.ClientVersionTypeId, strComparisonOpClientVersionTypeId);
}
if (objClientVersionCond.IsUpdated(conClientVersion.VersionDescription) == true)
{
string strComparisonOpVersionDescription = objClientVersionCond.dicFldComparisonOp[conClientVersion.VersionDescription];
strWhereCond += string.Format(" And {0} {2} '{1}'", conClientVersion.VersionDescription, objClientVersionCond.VersionDescription, strComparisonOpVersionDescription);
}
if (objClientVersionCond.IsUpdated(conClientVersion.VersionNumber) == true)
{
string strComparisonOpVersionNumber = objClientVersionCond.dicFldComparisonOp[conClientVersion.VersionNumber];
strWhereCond += string.Format(" And {0} {2} '{1}'", conClientVersion.VersionNumber, objClientVersionCond.VersionNumber, strComparisonOpVersionNumber);
}
if (objClientVersionCond.IsUpdated(conClientVersion.VersionState) == true)
{
if (objClientVersionCond.VersionState == true)
{
strWhereCond += string.Format(" And {0} = '1'", conClientVersion.VersionState);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conClientVersion.VersionState);
}
}
if (objClientVersionCond.IsUpdated(conClientVersion.VersionUrl) == true)
{
string strComparisonOpVersionUrl = objClientVersionCond.dicFldComparisonOp[conClientVersion.VersionUrl];
strWhereCond += string.Format(" And {0} {2} '{1}'", conClientVersion.VersionUrl, objClientVersionCond.VersionUrl, strComparisonOpVersionUrl);
}
if (objClientVersionCond.IsUpdated(conClientVersion.VersionCode) == true)
{
string strComparisonOpVersionCode = objClientVersionCond.dicFldComparisonOp[conClientVersion.VersionCode];
strWhereCond += string.Format(" And {0} {2} '{1}'", conClientVersion.VersionCode, objClientVersionCond.VersionCode, strComparisonOpVersionCode);
}
if (objClientVersionCond.IsUpdated(conClientVersion.PrjId) == true)
{
string strComparisonOpPrjId = objClientVersionCond.dicFldComparisonOp[conClientVersion.PrjId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conClientVersion.PrjId, objClientVersionCond.PrjId, strComparisonOpPrjId);
}
if (objClientVersionCond.IsUpdated(conClientVersion.UpdDate) == true)
{
string strComparisonOpUpdDate = objClientVersionCond.dicFldComparisonOp[conClientVersion.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conClientVersion.UpdDate, objClientVersionCond.UpdDate, strComparisonOpUpdDate);
}
if (objClientVersionCond.IsUpdated(conClientVersion.UpdUser) == true)
{
string strComparisonOpUpdUser = objClientVersionCond.dicFldComparisonOp[conClientVersion.UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", conClientVersion.UpdUser, objClientVersionCond.UpdUser, strComparisonOpUpdUser);
}
if (objClientVersionCond.IsUpdated(conClientVersion.Memo) == true)
{
string strComparisonOpMemo = objClientVersionCond.dicFldComparisonOp[conClientVersion.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", conClientVersion.Memo, objClientVersionCond.Memo, strComparisonOpMemo);
}
 return strWhereCond;
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_ClientVersion
{
public virtual bool UpdRelaTabDate(string strClientVersionId, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// 客户端版本(ClientVersion)
 /// 数据源类型:表
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsClientVersionBL
{
public static RelatedActions_ClientVersion relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsClientVersionDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsClientVersionDA ClientVersionDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsClientVersionDA();
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
 public clsClientVersionBL()
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
if (string.IsNullOrEmpty(clsClientVersionEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsClientVersionEN._ConnectString);
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
public static DataTable GetDataTable_ClientVersion(string strWhereCond)
{
DataTable objDT;
try
{
objDT = ClientVersionDA.GetDataTable_ClientVersion(strWhereCond);
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
objDT = ClientVersionDA.GetDataTable(strWhereCond);
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
objDT = ClientVersionDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = ClientVersionDA.GetDataTable(strWhereCond, strTabName);
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
objDT = ClientVersionDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = ClientVersionDA.GetDataTable_Top(objTopPara);
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
objDT = ClientVersionDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = ClientVersionDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = ClientVersionDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
 /// <param name = "arrClientVersionIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static List<clsClientVersionEN> GetObjLstByClientVersionIdLst(List<string> arrClientVersionIdLst)
{
List<clsClientVersionEN> arrObjLst = new List<clsClientVersionEN>(); 
System.Data.DataTable objDT; 
 string strSqlConditionStr = clsArray.GetSqlInStrByArray(arrClientVersionIdLst, true);
 string strWhereCond = string.Format("ClientVersionId in ({0})", strSqlConditionStr);
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsClientVersionEN objClientVersionEN = new clsClientVersionEN();
try
{
objClientVersionEN.ClientVersionId = objRow[conClientVersion.ClientVersionId].ToString().Trim(); //客户端版本Id
objClientVersionEN.ClientVersionTypeId = objRow[conClientVersion.ClientVersionTypeId].ToString().Trim(); //客户端版本类型Id
objClientVersionEN.VersionDescription = objRow[conClientVersion.VersionDescription] == DBNull.Value ? null : objRow[conClientVersion.VersionDescription].ToString().Trim(); //版本说明
objClientVersionEN.VersionNumber = objRow[conClientVersion.VersionNumber].ToString().Trim(); //版本号
objClientVersionEN.VersionState = clsEntityBase2.TransNullToBool_S(objRow[conClientVersion.VersionState].ToString().Trim()); //版本状态
objClientVersionEN.VersionUrl = objRow[conClientVersion.VersionUrl].ToString().Trim(); //版本文件
objClientVersionEN.VersionCode = objRow[conClientVersion.VersionCode].ToString().Trim(); //VersionCode
objClientVersionEN.PrjId = objRow[conClientVersion.PrjId] == DBNull.Value ? null : objRow[conClientVersion.PrjId].ToString().Trim(); //PrjId
objClientVersionEN.UpdDate = objRow[conClientVersion.UpdDate] == DBNull.Value ? null : objRow[conClientVersion.UpdDate].ToString().Trim(); //修改日期
objClientVersionEN.UpdUser = objRow[conClientVersion.UpdUser] == DBNull.Value ? null : objRow[conClientVersion.UpdUser].ToString().Trim(); //修改人
objClientVersionEN.Memo = objRow[conClientVersion.Memo] == DBNull.Value ? null : objRow[conClientVersion.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objClientVersionEN.ClientVersionId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objClientVersionEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrClientVersionIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsClientVersionEN> GetObjLstByClientVersionIdLstCache(List<string> arrClientVersionIdLst)
{
string strKey = string.Format("{0}", clsClientVersionEN._CurrTabName);
List<clsClientVersionEN> arrClientVersionObjLstCache = GetObjLstCache();
IEnumerable <clsClientVersionEN> arrClientVersionObjLst_Sel =
arrClientVersionObjLstCache
.Where(x => arrClientVersionIdLst.Contains(x.ClientVersionId));
return arrClientVersionObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsClientVersionEN> GetObjLst(string strWhereCond)
{
List<clsClientVersionEN> arrObjLst = new List<clsClientVersionEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsClientVersionEN objClientVersionEN = new clsClientVersionEN();
try
{
objClientVersionEN.ClientVersionId = objRow[conClientVersion.ClientVersionId].ToString().Trim(); //客户端版本Id
objClientVersionEN.ClientVersionTypeId = objRow[conClientVersion.ClientVersionTypeId].ToString().Trim(); //客户端版本类型Id
objClientVersionEN.VersionDescription = objRow[conClientVersion.VersionDescription] == DBNull.Value ? null : objRow[conClientVersion.VersionDescription].ToString().Trim(); //版本说明
objClientVersionEN.VersionNumber = objRow[conClientVersion.VersionNumber].ToString().Trim(); //版本号
objClientVersionEN.VersionState = clsEntityBase2.TransNullToBool_S(objRow[conClientVersion.VersionState].ToString().Trim()); //版本状态
objClientVersionEN.VersionUrl = objRow[conClientVersion.VersionUrl].ToString().Trim(); //版本文件
objClientVersionEN.VersionCode = objRow[conClientVersion.VersionCode].ToString().Trim(); //VersionCode
objClientVersionEN.PrjId = objRow[conClientVersion.PrjId] == DBNull.Value ? null : objRow[conClientVersion.PrjId].ToString().Trim(); //PrjId
objClientVersionEN.UpdDate = objRow[conClientVersion.UpdDate] == DBNull.Value ? null : objRow[conClientVersion.UpdDate].ToString().Trim(); //修改日期
objClientVersionEN.UpdUser = objRow[conClientVersion.UpdUser] == DBNull.Value ? null : objRow[conClientVersion.UpdUser].ToString().Trim(); //修改人
objClientVersionEN.Memo = objRow[conClientVersion.Memo] == DBNull.Value ? null : objRow[conClientVersion.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objClientVersionEN.ClientVersionId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objClientVersionEN);
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
public static List<clsClientVersionEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsClientVersionEN> arrObjLst = new List<clsClientVersionEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsClientVersionEN objClientVersionEN = new clsClientVersionEN();
try
{
objClientVersionEN.ClientVersionId = objRow[conClientVersion.ClientVersionId].ToString().Trim(); //客户端版本Id
objClientVersionEN.ClientVersionTypeId = objRow[conClientVersion.ClientVersionTypeId].ToString().Trim(); //客户端版本类型Id
objClientVersionEN.VersionDescription = objRow[conClientVersion.VersionDescription] == DBNull.Value ? null : objRow[conClientVersion.VersionDescription].ToString().Trim(); //版本说明
objClientVersionEN.VersionNumber = objRow[conClientVersion.VersionNumber].ToString().Trim(); //版本号
objClientVersionEN.VersionState = clsEntityBase2.TransNullToBool_S(objRow[conClientVersion.VersionState].ToString().Trim()); //版本状态
objClientVersionEN.VersionUrl = objRow[conClientVersion.VersionUrl].ToString().Trim(); //版本文件
objClientVersionEN.VersionCode = objRow[conClientVersion.VersionCode].ToString().Trim(); //VersionCode
objClientVersionEN.PrjId = objRow[conClientVersion.PrjId] == DBNull.Value ? null : objRow[conClientVersion.PrjId].ToString().Trim(); //PrjId
objClientVersionEN.UpdDate = objRow[conClientVersion.UpdDate] == DBNull.Value ? null : objRow[conClientVersion.UpdDate].ToString().Trim(); //修改日期
objClientVersionEN.UpdUser = objRow[conClientVersion.UpdUser] == DBNull.Value ? null : objRow[conClientVersion.UpdUser].ToString().Trim(); //修改人
objClientVersionEN.Memo = objRow[conClientVersion.Memo] == DBNull.Value ? null : objRow[conClientVersion.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objClientVersionEN.ClientVersionId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objClientVersionEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objClientVersionCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsClientVersionEN> GetSubObjLstCache(clsClientVersionEN objClientVersionCond)
{
List<clsClientVersionEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsClientVersionEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conClientVersion.AttributeName)
{
if (objClientVersionCond.IsUpdated(strFldName) == false) continue;
if (objClientVersionCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objClientVersionCond[strFldName].ToString());
}
else
{
if (objClientVersionCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objClientVersionCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objClientVersionCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objClientVersionCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objClientVersionCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objClientVersionCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objClientVersionCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objClientVersionCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objClientVersionCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objClientVersionCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objClientVersionCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objClientVersionCond[strFldName]));
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
public static List<clsClientVersionEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsClientVersionEN> arrObjLst = new List<clsClientVersionEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsClientVersionEN objClientVersionEN = new clsClientVersionEN();
try
{
objClientVersionEN.ClientVersionId = objRow[conClientVersion.ClientVersionId].ToString().Trim(); //客户端版本Id
objClientVersionEN.ClientVersionTypeId = objRow[conClientVersion.ClientVersionTypeId].ToString().Trim(); //客户端版本类型Id
objClientVersionEN.VersionDescription = objRow[conClientVersion.VersionDescription] == DBNull.Value ? null : objRow[conClientVersion.VersionDescription].ToString().Trim(); //版本说明
objClientVersionEN.VersionNumber = objRow[conClientVersion.VersionNumber].ToString().Trim(); //版本号
objClientVersionEN.VersionState = clsEntityBase2.TransNullToBool_S(objRow[conClientVersion.VersionState].ToString().Trim()); //版本状态
objClientVersionEN.VersionUrl = objRow[conClientVersion.VersionUrl].ToString().Trim(); //版本文件
objClientVersionEN.VersionCode = objRow[conClientVersion.VersionCode].ToString().Trim(); //VersionCode
objClientVersionEN.PrjId = objRow[conClientVersion.PrjId] == DBNull.Value ? null : objRow[conClientVersion.PrjId].ToString().Trim(); //PrjId
objClientVersionEN.UpdDate = objRow[conClientVersion.UpdDate] == DBNull.Value ? null : objRow[conClientVersion.UpdDate].ToString().Trim(); //修改日期
objClientVersionEN.UpdUser = objRow[conClientVersion.UpdUser] == DBNull.Value ? null : objRow[conClientVersion.UpdUser].ToString().Trim(); //修改人
objClientVersionEN.Memo = objRow[conClientVersion.Memo] == DBNull.Value ? null : objRow[conClientVersion.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objClientVersionEN.ClientVersionId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objClientVersionEN);
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
public static List<clsClientVersionEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsClientVersionEN> arrObjLst = new List<clsClientVersionEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsClientVersionEN objClientVersionEN = new clsClientVersionEN();
try
{
objClientVersionEN.ClientVersionId = objRow[conClientVersion.ClientVersionId].ToString().Trim(); //客户端版本Id
objClientVersionEN.ClientVersionTypeId = objRow[conClientVersion.ClientVersionTypeId].ToString().Trim(); //客户端版本类型Id
objClientVersionEN.VersionDescription = objRow[conClientVersion.VersionDescription] == DBNull.Value ? null : objRow[conClientVersion.VersionDescription].ToString().Trim(); //版本说明
objClientVersionEN.VersionNumber = objRow[conClientVersion.VersionNumber].ToString().Trim(); //版本号
objClientVersionEN.VersionState = clsEntityBase2.TransNullToBool_S(objRow[conClientVersion.VersionState].ToString().Trim()); //版本状态
objClientVersionEN.VersionUrl = objRow[conClientVersion.VersionUrl].ToString().Trim(); //版本文件
objClientVersionEN.VersionCode = objRow[conClientVersion.VersionCode].ToString().Trim(); //VersionCode
objClientVersionEN.PrjId = objRow[conClientVersion.PrjId] == DBNull.Value ? null : objRow[conClientVersion.PrjId].ToString().Trim(); //PrjId
objClientVersionEN.UpdDate = objRow[conClientVersion.UpdDate] == DBNull.Value ? null : objRow[conClientVersion.UpdDate].ToString().Trim(); //修改日期
objClientVersionEN.UpdUser = objRow[conClientVersion.UpdUser] == DBNull.Value ? null : objRow[conClientVersion.UpdUser].ToString().Trim(); //修改人
objClientVersionEN.Memo = objRow[conClientVersion.Memo] == DBNull.Value ? null : objRow[conClientVersion.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objClientVersionEN.ClientVersionId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objClientVersionEN);
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
List<clsClientVersionEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsClientVersionEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsClientVersionEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsClientVersionEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsClientVersionEN> arrObjLst = new List<clsClientVersionEN>(); 
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
	clsClientVersionEN objClientVersionEN = new clsClientVersionEN();
try
{
objClientVersionEN.ClientVersionId = objRow[conClientVersion.ClientVersionId].ToString().Trim(); //客户端版本Id
objClientVersionEN.ClientVersionTypeId = objRow[conClientVersion.ClientVersionTypeId].ToString().Trim(); //客户端版本类型Id
objClientVersionEN.VersionDescription = objRow[conClientVersion.VersionDescription] == DBNull.Value ? null : objRow[conClientVersion.VersionDescription].ToString().Trim(); //版本说明
objClientVersionEN.VersionNumber = objRow[conClientVersion.VersionNumber].ToString().Trim(); //版本号
objClientVersionEN.VersionState = clsEntityBase2.TransNullToBool_S(objRow[conClientVersion.VersionState].ToString().Trim()); //版本状态
objClientVersionEN.VersionUrl = objRow[conClientVersion.VersionUrl].ToString().Trim(); //版本文件
objClientVersionEN.VersionCode = objRow[conClientVersion.VersionCode].ToString().Trim(); //VersionCode
objClientVersionEN.PrjId = objRow[conClientVersion.PrjId] == DBNull.Value ? null : objRow[conClientVersion.PrjId].ToString().Trim(); //PrjId
objClientVersionEN.UpdDate = objRow[conClientVersion.UpdDate] == DBNull.Value ? null : objRow[conClientVersion.UpdDate].ToString().Trim(); //修改日期
objClientVersionEN.UpdUser = objRow[conClientVersion.UpdUser] == DBNull.Value ? null : objRow[conClientVersion.UpdUser].ToString().Trim(); //修改人
objClientVersionEN.Memo = objRow[conClientVersion.Memo] == DBNull.Value ? null : objRow[conClientVersion.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objClientVersionEN.ClientVersionId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objClientVersionEN);
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
public static List<clsClientVersionEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsClientVersionEN> arrObjLst = new List<clsClientVersionEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsClientVersionEN objClientVersionEN = new clsClientVersionEN();
try
{
objClientVersionEN.ClientVersionId = objRow[conClientVersion.ClientVersionId].ToString().Trim(); //客户端版本Id
objClientVersionEN.ClientVersionTypeId = objRow[conClientVersion.ClientVersionTypeId].ToString().Trim(); //客户端版本类型Id
objClientVersionEN.VersionDescription = objRow[conClientVersion.VersionDescription] == DBNull.Value ? null : objRow[conClientVersion.VersionDescription].ToString().Trim(); //版本说明
objClientVersionEN.VersionNumber = objRow[conClientVersion.VersionNumber].ToString().Trim(); //版本号
objClientVersionEN.VersionState = clsEntityBase2.TransNullToBool_S(objRow[conClientVersion.VersionState].ToString().Trim()); //版本状态
objClientVersionEN.VersionUrl = objRow[conClientVersion.VersionUrl].ToString().Trim(); //版本文件
objClientVersionEN.VersionCode = objRow[conClientVersion.VersionCode].ToString().Trim(); //VersionCode
objClientVersionEN.PrjId = objRow[conClientVersion.PrjId] == DBNull.Value ? null : objRow[conClientVersion.PrjId].ToString().Trim(); //PrjId
objClientVersionEN.UpdDate = objRow[conClientVersion.UpdDate] == DBNull.Value ? null : objRow[conClientVersion.UpdDate].ToString().Trim(); //修改日期
objClientVersionEN.UpdUser = objRow[conClientVersion.UpdUser] == DBNull.Value ? null : objRow[conClientVersion.UpdUser].ToString().Trim(); //修改人
objClientVersionEN.Memo = objRow[conClientVersion.Memo] == DBNull.Value ? null : objRow[conClientVersion.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objClientVersionEN.ClientVersionId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objClientVersionEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsClientVersionEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsClientVersionEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsClientVersionEN> arrObjLst = new List<clsClientVersionEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsClientVersionEN objClientVersionEN = new clsClientVersionEN();
try
{
objClientVersionEN.ClientVersionId = objRow[conClientVersion.ClientVersionId].ToString().Trim(); //客户端版本Id
objClientVersionEN.ClientVersionTypeId = objRow[conClientVersion.ClientVersionTypeId].ToString().Trim(); //客户端版本类型Id
objClientVersionEN.VersionDescription = objRow[conClientVersion.VersionDescription] == DBNull.Value ? null : objRow[conClientVersion.VersionDescription].ToString().Trim(); //版本说明
objClientVersionEN.VersionNumber = objRow[conClientVersion.VersionNumber].ToString().Trim(); //版本号
objClientVersionEN.VersionState = clsEntityBase2.TransNullToBool_S(objRow[conClientVersion.VersionState].ToString().Trim()); //版本状态
objClientVersionEN.VersionUrl = objRow[conClientVersion.VersionUrl].ToString().Trim(); //版本文件
objClientVersionEN.VersionCode = objRow[conClientVersion.VersionCode].ToString().Trim(); //VersionCode
objClientVersionEN.PrjId = objRow[conClientVersion.PrjId] == DBNull.Value ? null : objRow[conClientVersion.PrjId].ToString().Trim(); //PrjId
objClientVersionEN.UpdDate = objRow[conClientVersion.UpdDate] == DBNull.Value ? null : objRow[conClientVersion.UpdDate].ToString().Trim(); //修改日期
objClientVersionEN.UpdUser = objRow[conClientVersion.UpdUser] == DBNull.Value ? null : objRow[conClientVersion.UpdUser].ToString().Trim(); //修改人
objClientVersionEN.Memo = objRow[conClientVersion.Memo] == DBNull.Value ? null : objRow[conClientVersion.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objClientVersionEN.ClientVersionId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objClientVersionEN);
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
public static List<clsClientVersionEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsClientVersionEN> arrObjLst = new List<clsClientVersionEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsClientVersionEN objClientVersionEN = new clsClientVersionEN();
try
{
objClientVersionEN.ClientVersionId = objRow[conClientVersion.ClientVersionId].ToString().Trim(); //客户端版本Id
objClientVersionEN.ClientVersionTypeId = objRow[conClientVersion.ClientVersionTypeId].ToString().Trim(); //客户端版本类型Id
objClientVersionEN.VersionDescription = objRow[conClientVersion.VersionDescription] == DBNull.Value ? null : objRow[conClientVersion.VersionDescription].ToString().Trim(); //版本说明
objClientVersionEN.VersionNumber = objRow[conClientVersion.VersionNumber].ToString().Trim(); //版本号
objClientVersionEN.VersionState = clsEntityBase2.TransNullToBool_S(objRow[conClientVersion.VersionState].ToString().Trim()); //版本状态
objClientVersionEN.VersionUrl = objRow[conClientVersion.VersionUrl].ToString().Trim(); //版本文件
objClientVersionEN.VersionCode = objRow[conClientVersion.VersionCode].ToString().Trim(); //VersionCode
objClientVersionEN.PrjId = objRow[conClientVersion.PrjId] == DBNull.Value ? null : objRow[conClientVersion.PrjId].ToString().Trim(); //PrjId
objClientVersionEN.UpdDate = objRow[conClientVersion.UpdDate] == DBNull.Value ? null : objRow[conClientVersion.UpdDate].ToString().Trim(); //修改日期
objClientVersionEN.UpdUser = objRow[conClientVersion.UpdUser] == DBNull.Value ? null : objRow[conClientVersion.UpdUser].ToString().Trim(); //修改人
objClientVersionEN.Memo = objRow[conClientVersion.Memo] == DBNull.Value ? null : objRow[conClientVersion.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objClientVersionEN.ClientVersionId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objClientVersionEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsClientVersionEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsClientVersionEN> arrObjLst = new List<clsClientVersionEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsClientVersionEN objClientVersionEN = new clsClientVersionEN();
try
{
objClientVersionEN.ClientVersionId = objRow[conClientVersion.ClientVersionId].ToString().Trim(); //客户端版本Id
objClientVersionEN.ClientVersionTypeId = objRow[conClientVersion.ClientVersionTypeId].ToString().Trim(); //客户端版本类型Id
objClientVersionEN.VersionDescription = objRow[conClientVersion.VersionDescription] == DBNull.Value ? null : objRow[conClientVersion.VersionDescription].ToString().Trim(); //版本说明
objClientVersionEN.VersionNumber = objRow[conClientVersion.VersionNumber].ToString().Trim(); //版本号
objClientVersionEN.VersionState = clsEntityBase2.TransNullToBool_S(objRow[conClientVersion.VersionState].ToString().Trim()); //版本状态
objClientVersionEN.VersionUrl = objRow[conClientVersion.VersionUrl].ToString().Trim(); //版本文件
objClientVersionEN.VersionCode = objRow[conClientVersion.VersionCode].ToString().Trim(); //VersionCode
objClientVersionEN.PrjId = objRow[conClientVersion.PrjId] == DBNull.Value ? null : objRow[conClientVersion.PrjId].ToString().Trim(); //PrjId
objClientVersionEN.UpdDate = objRow[conClientVersion.UpdDate] == DBNull.Value ? null : objRow[conClientVersion.UpdDate].ToString().Trim(); //修改日期
objClientVersionEN.UpdUser = objRow[conClientVersion.UpdUser] == DBNull.Value ? null : objRow[conClientVersion.UpdUser].ToString().Trim(); //修改人
objClientVersionEN.Memo = objRow[conClientVersion.Memo] == DBNull.Value ? null : objRow[conClientVersion.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objClientVersionEN.ClientVersionId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objClientVersionEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objClientVersionEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetClientVersion(ref clsClientVersionEN objClientVersionEN)
{
bool bolResult = ClientVersionDA.GetClientVersion(ref objClientVersionEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "strClientVersionId">表关键字</param>
 /// <returns>表对象</returns>
public static clsClientVersionEN GetObjByClientVersionId(string strClientVersionId)
{
if (strClientVersionId.IndexOf(' ') >=0)
{
var strMsg = string.Format("(errid:Busi000079)在表中,关键字[strClientVersionId]中不能有空格!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
if (string.IsNullOrEmpty(strClientVersionId) == true)
{
var strMsg = string.Format("(errid:Busi000020)在表中,关键字[strClientVersionId]不能为空!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
clsClientVersionEN objClientVersionEN = ClientVersionDA.GetObjByClientVersionId(strClientVersionId);
return objClientVersionEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsClientVersionEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsClientVersionEN objClientVersionEN = ClientVersionDA.GetFirstObj(strWhereCond);
 return objClientVersionEN;
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
public static clsClientVersionEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsClientVersionEN objClientVersionEN = ClientVersionDA.GetObjByDataRow(objRow);
 return objClientVersionEN;
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
public static clsClientVersionEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsClientVersionEN objClientVersionEN = ClientVersionDA.GetObjByDataRow(objRow);
 return objClientVersionEN;
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
 /// <param name = "strClientVersionId">所给的关键字</param>
 /// <param name = "lstClientVersionObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsClientVersionEN GetObjByClientVersionIdFromList(string strClientVersionId, List<clsClientVersionEN> lstClientVersionObjLst)
{
foreach (clsClientVersionEN objClientVersionEN in lstClientVersionObjLst)
{
if (objClientVersionEN.ClientVersionId == strClientVersionId)
{
return objClientVersionEN;
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
 string strClientVersionId;
 try
 {
 strClientVersionId = new clsClientVersionDA().GetFirstID(strWhereCond);
 return strClientVersionId;
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
 arrList = ClientVersionDA.GetID(strWhereCond);
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
bool bolIsExist = ClientVersionDA.IsExistCondRec(strWhereCond);
return bolIsExist;
}

 /// <summary>
 /// 判断当前表中是否存在给定关键字值的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExist)
 /// </summary>
 /// <param name = "strClientVersionId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public static bool IsExist(string strClientVersionId)
{
if (string.IsNullOrEmpty(strClientVersionId) == true)
{
var strMsg = string.Format("(errid:Busi000027)在表中,关键字[strClientVersionId]不能为空!!(from {0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
//检测记录是否存在
bool bolIsExist = ClientVersionDA.IsExist(strClientVersionId);
return bolIsExist;
}

/// <summary>
/// 设置修改时间
/// </summary>
/// <param name = "strClientVersionId">客户端版本Id</param>
/// <param name = "strOpUser">修改用户</param>
/// <returns>是否成功？</returns>
public static bool SetUpdDate(string strClientVersionId, string strOpUser)
{
clsClientVersionEN objClientVersionEN = clsClientVersionBL.GetObjByClientVersionId(strClientVersionId);
objClientVersionEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
objClientVersionEN.UpdUser = strOpUser;
return clsClientVersionBL.UpdateBySql2(objClientVersionEN);
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
 bolIsExist = clsClientVersionDA.IsExistTable();
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
 bolIsExist = ClientVersionDA.IsExistTable(strTabName);
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
 /// <param name = "objClientVersionEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecordBySql2(clsClientVersionEN objClientVersionEN)
{
 if (string.IsNullOrEmpty(objClientVersionEN.ClientVersionId) == true)
 {
string strMsg = string.Format("添加记录时,关键字不能为空!(from {0})\r\n", 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
 if (clsClientVersionBL.IsExist(objClientVersionEN.ClientVersionId) == true)
 {
string strMsg = string.Format("添加记录时,关键字:[{0}]已经存在!(from {1})\r\n", objClientVersionEN.ClientVersionId, 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
try
{
bool bolResult = ClientVersionDA.AddNewRecordBySQL2(objClientVersionEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsClientVersionBL.ReFreshCache();

if (clsClientVersionBL.relatedActions != null)
{
clsClientVersionBL.relatedActions.UpdRelaTabDate(objClientVersionEN.ClientVersionId, objClientVersionEN.UpdUser);
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
 /// <param name = "objClientVersionEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordBySql2WithReturnKey(clsClientVersionEN objClientVersionEN)
{
 if (string.IsNullOrEmpty(objClientVersionEN.ClientVersionId) == true)
 {
string strMsg = string.Format("添加记录时,关键字不能为空!(from {{0}})", 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
 if (clsClientVersionBL.IsExist(objClientVersionEN.ClientVersionId) == true)
 {
string strMsg = string.Format("添加记录时,关键字:[{0}]已经存在!(from {1})\r\n", objClientVersionEN.ClientVersionId, 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
try
{
string strKey = ClientVersionDA.AddNewRecordBySQL2WithReturnKey(objClientVersionEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsClientVersionBL.ReFreshCache();

if (clsClientVersionBL.relatedActions != null)
{
clsClientVersionBL.relatedActions.UpdRelaTabDate(objClientVersionEN.ClientVersionId, objClientVersionEN.UpdUser);
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
 /// <param name = "objClientVersionEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(clsClientVersionEN objClientVersionEN)
{
try
{
bool bolResult = ClientVersionDA.Update(objClientVersionEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsClientVersionBL.ReFreshCache();

if (clsClientVersionBL.relatedActions != null)
{
clsClientVersionBL.relatedActions.UpdRelaTabDate(objClientVersionEN.ClientVersionId, objClientVersionEN.UpdUser);
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
 /// <param name = "objClientVersionEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateBySql2(clsClientVersionEN objClientVersionEN)
{
 if (string.IsNullOrEmpty(objClientVersionEN.ClientVersionId) == true)
 {
var strMsg = string.Format("(errid:Busi000065)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = ClientVersionDA.UpdateBySql2(objClientVersionEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsClientVersionBL.ReFreshCache();

if (clsClientVersionBL.relatedActions != null)
{
clsClientVersionBL.relatedActions.UpdRelaTabDate(objClientVersionEN.ClientVersionId, objClientVersionEN.UpdUser);
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
 /// <param name = "strClientVersionId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int DelRecord(string strClientVersionId)
{
try
{
 clsClientVersionEN objClientVersionEN = clsClientVersionBL.GetObjByClientVersionId(strClientVersionId);

if (clsClientVersionBL.relatedActions != null)
{
clsClientVersionBL.relatedActions.UpdRelaTabDate(objClientVersionEN.ClientVersionId, objClientVersionEN.UpdUser);
}
if (objClientVersionEN != null)
{
int intRecNum = ClientVersionDA.DelRecord(strClientVersionId);
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
/// <param name="strClientVersionId">表关键字</param>
/// <returns></returns>
public static bool DelRecordEx(string strClientVersionId )
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsClientVersionDA.GetSpecSQLObj();
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
//删除与表:[ClientVersion]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conClientVersion.ClientVersionId,
//strClientVersionId);
//        clsClientVersionBL.DelClientVersionsByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsClientVersionBL.DelRecord(strClientVersionId, objConnection, objSqlTransaction);
objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsClientVersionBLEx", "DelRecordEx", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("扩展删除记录出错:{0}!keyId = {1}.({2})",
objException.Message,
strClientVersionId, clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "strClientVersionId">给定的关键字值</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回删除是否成功?</returns>
public static bool DelRecord(string strClientVersionId, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
if (clsClientVersionBL.relatedActions != null)
{
clsClientVersionBL.relatedActions.UpdRelaTabDate(strClientVersionId, "UpdRelaTabDate");
}
bool bolResult = ClientVersionDA.DelRecord(strClientVersionId,objSqlConnection,objSqlTransaction);
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
 /// <param name = "arrClientVersionIdLst">给定的关键字值列表</param>
 /// <returns>返回删除的记录数</returns>
public static int DelClientVersions(List<string> arrClientVersionIdLst)
{
if (arrClientVersionIdLst.Count == 0) return 0;
try
{
if (clsClientVersionBL.relatedActions != null)
{
foreach (var strClientVersionId in arrClientVersionIdLst)
{
clsClientVersionBL.relatedActions.UpdRelaTabDate(strClientVersionId, "UpdRelaTabDate");
}
}
int intDelRecNum = ClientVersionDA.DelClientVersion(arrClientVersionIdLst);
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
public static int DelClientVersionsByCond(string strWhereCond)
{
try
{
if (clsClientVersionBL.relatedActions != null)
{
List<string> arrClientVersionId = GetPrimaryKeyID_S(strWhereCond);
foreach (var strClientVersionId in arrClientVersionId)
{
clsClientVersionBL.relatedActions.UpdRelaTabDate(strClientVersionId, "UpdRelaTabDate");
}
}
int intRecNum = ClientVersionDA.DelClientVersion(strWhereCond);
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
/// 这里仅仅是演示函数,使用时请复制到扩展类:[ClientVersion]中改名为:[DelRecord4MultiTabEx]使用
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DelRecord4MultiTab)
/// </summary>
/// <param name="strClientVersionId">表关键字</param>
/// <returns></returns>
public static bool DelRecord4MultiTab(string strClientVersionId)
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsClientVersionDA.GetSpecSQLObj();
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
//删除与表:[ClientVersion]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conStudent.id_College,
//strid_College);
//        clsStudentBL.DelStudentsByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsClientVersionBL.DelRecord(strClientVersionId, objConnection, objSqlTransaction);
                objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsClientVersionBL", "DelRecord4MultiTab", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("删除多表记录出错:{0}!keyId = {1}.({2})",
objException.Message,
strClientVersionId, clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "objClientVersionENS">源对象</param>
 /// <param name = "objClientVersionENT">目标对象</param>
 public static void CopyTo(clsClientVersionEN objClientVersionENS, clsClientVersionEN objClientVersionENT)
{
try
{
objClientVersionENT.ClientVersionId = objClientVersionENS.ClientVersionId; //客户端版本Id
objClientVersionENT.ClientVersionTypeId = objClientVersionENS.ClientVersionTypeId; //客户端版本类型Id
objClientVersionENT.VersionDescription = objClientVersionENS.VersionDescription; //版本说明
objClientVersionENT.VersionNumber = objClientVersionENS.VersionNumber; //版本号
objClientVersionENT.VersionState = objClientVersionENS.VersionState; //版本状态
objClientVersionENT.VersionUrl = objClientVersionENS.VersionUrl; //版本文件
objClientVersionENT.VersionCode = objClientVersionENS.VersionCode; //VersionCode
objClientVersionENT.PrjId = objClientVersionENS.PrjId; //PrjId
objClientVersionENT.UpdDate = objClientVersionENS.UpdDate; //修改日期
objClientVersionENT.UpdUser = objClientVersionENS.UpdUser; //修改人
objClientVersionENT.Memo = objClientVersionENS.Memo; //备注
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
 /// <param name = "objClientVersionEN">源简化对象</param>
 public static void SetUpdFlag(clsClientVersionEN objClientVersionEN)
{
try
{
objClientVersionEN.ClearUpdateState();
   string strsfUpdFldSetStr = objClientVersionEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(conClientVersion.ClientVersionId, new clsStrCompareIgnoreCase())  ==  true)
{
objClientVersionEN.ClientVersionId = objClientVersionEN.ClientVersionId; //客户端版本Id
}
if (arrFldSet.Contains(conClientVersion.ClientVersionTypeId, new clsStrCompareIgnoreCase())  ==  true)
{
objClientVersionEN.ClientVersionTypeId = objClientVersionEN.ClientVersionTypeId; //客户端版本类型Id
}
if (arrFldSet.Contains(conClientVersion.VersionDescription, new clsStrCompareIgnoreCase())  ==  true)
{
objClientVersionEN.VersionDescription = objClientVersionEN.VersionDescription == "[null]" ? null :  objClientVersionEN.VersionDescription; //版本说明
}
if (arrFldSet.Contains(conClientVersion.VersionNumber, new clsStrCompareIgnoreCase())  ==  true)
{
objClientVersionEN.VersionNumber = objClientVersionEN.VersionNumber; //版本号
}
if (arrFldSet.Contains(conClientVersion.VersionState, new clsStrCompareIgnoreCase())  ==  true)
{
objClientVersionEN.VersionState = objClientVersionEN.VersionState; //版本状态
}
if (arrFldSet.Contains(conClientVersion.VersionUrl, new clsStrCompareIgnoreCase())  ==  true)
{
objClientVersionEN.VersionUrl = objClientVersionEN.VersionUrl; //版本文件
}
if (arrFldSet.Contains(conClientVersion.VersionCode, new clsStrCompareIgnoreCase())  ==  true)
{
objClientVersionEN.VersionCode = objClientVersionEN.VersionCode; //VersionCode
}
if (arrFldSet.Contains(conClientVersion.PrjId, new clsStrCompareIgnoreCase())  ==  true)
{
objClientVersionEN.PrjId = objClientVersionEN.PrjId == "[null]" ? null :  objClientVersionEN.PrjId; //PrjId
}
if (arrFldSet.Contains(conClientVersion.UpdDate, new clsStrCompareIgnoreCase())  ==  true)
{
objClientVersionEN.UpdDate = objClientVersionEN.UpdDate == "[null]" ? null :  objClientVersionEN.UpdDate; //修改日期
}
if (arrFldSet.Contains(conClientVersion.UpdUser, new clsStrCompareIgnoreCase())  ==  true)
{
objClientVersionEN.UpdUser = objClientVersionEN.UpdUser == "[null]" ? null :  objClientVersionEN.UpdUser; //修改人
}
if (arrFldSet.Contains(conClientVersion.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objClientVersionEN.Memo = objClientVersionEN.Memo == "[null]" ? null :  objClientVersionEN.Memo; //备注
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
 /// <param name = "objClientVersionEN">源简化对象</param>
 public static void AccessFldValueNull(clsClientVersionEN objClientVersionEN)
{
try
{
if (objClientVersionEN.VersionDescription == "[null]") objClientVersionEN.VersionDescription = null; //版本说明
if (objClientVersionEN.PrjId == "[null]") objClientVersionEN.PrjId = null; //PrjId
if (objClientVersionEN.UpdDate == "[null]") objClientVersionEN.UpdDate = null; //修改日期
if (objClientVersionEN.UpdUser == "[null]") objClientVersionEN.UpdUser = null; //修改人
if (objClientVersionEN.Memo == "[null]") objClientVersionEN.Memo = null; //备注
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
public static void CheckPropertyNew(clsClientVersionEN objClientVersionEN)
{
 ClientVersionDA.CheckPropertyNew(objClientVersionEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(clsClientVersionEN objClientVersionEN)
{
 ClientVersionDA.CheckProperty4Condition(objClientVersionEN);
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
if (clsClientVersionBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsClientVersionBL没有刷新缓存机制(clsClientVersionBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by ClientVersionId");
//if (arrClientVersionObjLstCache == null)
//{
//arrClientVersionObjLstCache = ClientVersionDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "strClientVersionId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsClientVersionEN GetObjByClientVersionIdCache(string strClientVersionId)
{
//获取缓存中的对象列表
string strKey = string.Format("{0}", clsClientVersionEN._CurrTabName);
List<clsClientVersionEN> arrClientVersionObjLstCache = GetObjLstCache();
IEnumerable <clsClientVersionEN> arrClientVersionObjLst_Sel =
arrClientVersionObjLstCache
.Where(x=> x.ClientVersionId == strClientVersionId 
);
if (arrClientVersionObjLst_Sel.Count() == 0)
{
   clsClientVersionEN obj = clsClientVersionBL.GetObjByClientVersionId(strClientVersionId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
 }
return null;
}
return arrClientVersionObjLst_Sel.First();
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsClientVersionEN> GetAllClientVersionObjLstCache()
{
//获取缓存中的对象列表
List<clsClientVersionEN> arrClientVersionObjLstCache = GetObjLstCache(); 
return arrClientVersionObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsClientVersionEN> GetObjLstCache()
{
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}", clsClientVersionEN._CurrTabName);
List<clsClientVersionEN> arrClientVersionObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrClientVersionObjLstCache;
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
string strKey = string.Format("{0}", clsClientVersionEN._CurrTabName);
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
if (clsClientVersionBL.objCommFun4BL != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}", clsClientVersionEN._CurrTabName);
CacheHelper.Remove(strKey);
clsClientVersionBL.objCommFun4BL.ReFreshCache();
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
public static string Func(string strInFldName, string strOutFldName, string strClientVersionId)
{
if (strInFldName != conClientVersion.ClientVersionId)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (conClientVersion.AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", conClientVersion.AttributeName));
throw new Exception(strMsg);
}
var objClientVersion = clsClientVersionBL.GetObjByClientVersionIdCache(strClientVersionId);
if (objClientVersion == null) return "";
return objClientVersion[strOutFldName].ToString();
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
int intRecCount = clsClientVersionDA.GetRecCount(strTabName);
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
int intRecCount = clsClientVersionDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsClientVersionDA.GetRecCount();
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
int intRecCount = clsClientVersionDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objClientVersionCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsClientVersionEN objClientVersionCond)
{
List<clsClientVersionEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsClientVersionEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conClientVersion.AttributeName)
{
if (objClientVersionCond.IsUpdated(strFldName) == false) continue;
if (objClientVersionCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objClientVersionCond[strFldName].ToString());
}
else
{
if (objClientVersionCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objClientVersionCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objClientVersionCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objClientVersionCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objClientVersionCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objClientVersionCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objClientVersionCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objClientVersionCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objClientVersionCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objClientVersionCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objClientVersionCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objClientVersionCond[strFldName]));
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
 List<string> arrList = clsClientVersionDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = ClientVersionDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = ClientVersionDA.GetFldValueNoDistinct(strFldName, strWhereCond);
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
int intRecCount = ClientVersionDA.SetFldValue(strFldName, strValue, strWhereCond);
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
int intRecCount = clsClientVersionDA.SetFldValue(clsClientVersionEN._CurrTabName, strFldName, fltValue, strWhereCond);
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
int intRecCount = ClientVersionDA.SetFldValue( strFldName, intValue, strWhereCond);
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
int intRecCount = clsClientVersionDA.SetFldValue(strTabName, strFldName, strValue, strWhereCond);
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
int intRecCount = clsClientVersionDA.SetFldValue(strTabName, strFldName, intValue, strWhereCond);
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
int intRecCount = clsClientVersionDA.SetFldValue(strTabName, strFldName, fltValue, strWhereCond);
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
  strCreateTabCode.Append("CREATE table [dbo].[ClientVersion] "); 
 strCreateTabCode.Append(" ( "); 
 // /**客户端版本Id*/ 
 strCreateTabCode.Append(" ClientVersionId char(8) primary key, "); 
 // /**客户端版本类型Id*/ 
 strCreateTabCode.Append(" ClientVersionTypeId char(8) not Null, "); 
 // /**版本说明*/ 
 strCreateTabCode.Append(" VersionDescription varchar(1000) Null, "); 
 // /**版本号*/ 
 strCreateTabCode.Append(" VersionNumber varchar(50) not Null, "); 
 // /**版本状态*/ 
 strCreateTabCode.Append(" VersionState bit Null, "); 
 // /**版本文件*/ 
 strCreateTabCode.Append(" VersionUrl varchar(500) not Null, "); 
 // /**VersionCode*/ 
 strCreateTabCode.Append(" VersionCode varchar(50) not Null, "); 
 // /**PrjId*/ 
 strCreateTabCode.Append(" PrjId char(4) Null, "); 
 // /**修改日期*/ 
 strCreateTabCode.Append(" UpdDate varchar(20) Null, "); 
 // /**修改人*/ 
 strCreateTabCode.Append(" UpdUser varchar(20) Null, "); 
 // /**备注*/ 
 strCreateTabCode.Append(" Memo varchar(1000) Null ");
 strCreateTabCode.Append(") "); 
  strCreateTabCode.Append("ON [PRIMARY] ");
  return strCreateTabCode.ToString();
}



 #endregion 表操作
}
 /// <summary>
 /// 客户端版本(ClientVersion)
 /// 数据源类型:表
 /// (AutoGCLib.CommFun4BL4CSharp:GeneCode_This)
 /// </summary>
public class  clsCommFun4BL4ClientVersion : clsCommFun4BL
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
clsClientVersionBL.ReFreshThisCache();
}
}

}