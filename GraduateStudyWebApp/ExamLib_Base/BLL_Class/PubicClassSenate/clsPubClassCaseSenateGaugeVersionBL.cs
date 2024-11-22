
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsPubClassCaseSenateGaugeVersionBL
 表名:PubClassCaseSenateGaugeVersion(01120504)
 * 版本:2024.11.13.1(服务器:WIN-SRV103-116)
 日期:2024/11/13 06:21:24
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:研究生学习游戏化后台(000055, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:课例观摩(PubicClassSenate)
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
public static class  clsPubClassCaseSenateGaugeVersionBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "strIdPubClassCaseSenateGaugeVersion">表关键字</param>
 /// <returns>表对象</returns>
public static clsPubClassCaseSenateGaugeVersionEN GetObj(this K_IdPubClassCaseSenateGaugeVersion_PubClassCaseSenateGaugeVersion myKey)
{
clsPubClassCaseSenateGaugeVersionEN objPubClassCaseSenateGaugeVersionEN = clsPubClassCaseSenateGaugeVersionBL.PubClassCaseSenateGaugeVersionDA.GetObjByIdPubClassCaseSenateGaugeVersion(myKey.Value);
return objPubClassCaseSenateGaugeVersionEN;
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_AddNewRecord)
 /// </summary>
 /// <param name = "objPubClassCaseSenateGaugeVersionEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clsPubClassCaseSenateGaugeVersionEN objPubClassCaseSenateGaugeVersionEN, bool bolIsNeedCheckUniqueness = true)
{
 if (string.IsNullOrEmpty(objPubClassCaseSenateGaugeVersionEN.IdPubClassCaseSenateGaugeVersion) == true)
 {
string strMsg = string.Format("添加记录时,关键字不能为空!(from {0})\r\n", 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
 if (clsPubClassCaseSenateGaugeVersionBL.IsExist(objPubClassCaseSenateGaugeVersionEN.IdPubClassCaseSenateGaugeVersion) == true)
 {
string strMsg = string.Format("添加记录时,关键字:[{0}]已经存在!(from {1})\r\n", objPubClassCaseSenateGaugeVersionEN.IdPubClassCaseSenateGaugeVersion, 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
try
{
bool bolResult = clsPubClassCaseSenateGaugeVersionBL.PubClassCaseSenateGaugeVersionDA.AddNewRecordBySQL2(objPubClassCaseSenateGaugeVersionEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsPubClassCaseSenateGaugeVersionBL.ReFreshCache();

if (clsPubClassCaseSenateGaugeVersionBL.relatedActions != null)
{
clsPubClassCaseSenateGaugeVersionBL.relatedActions.UpdRelaTabDate(objPubClassCaseSenateGaugeVersionEN.IdPubClassCaseSenateGaugeVersion, "SetUpdDate");
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
public static bool AddRecordEx(this clsPubClassCaseSenateGaugeVersionEN objPubClassCaseSenateGaugeVersionEN, bool bolIsNeedCheckUniqueness = true)
{
//操作步骤:
//1、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在
//2、检查唯一性
//3、检查传进去的对象属性是否合法
//4、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
//1、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在
if (clsPubClassCaseSenateGaugeVersionBL.IsExist(objPubClassCaseSenateGaugeVersionEN.IdPubClassCaseSenateGaugeVersion))	//判断是否有相同的关键字
{
strMsg = "(errid:Busi000151)关键字字段已有相同的值";
throw new Exception(strMsg);
}
try
{
 //2、检查传进去的对象属性是否合法
objPubClassCaseSenateGaugeVersionEN.CheckPropertyNew();
//6、把数据实体层的数据存贮到数据库中
objPubClassCaseSenateGaugeVersionEN.AddNewRecord();
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
 /// <param name = "objPubClassCaseSenateGaugeVersionEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordWithReturnKey(this clsPubClassCaseSenateGaugeVersionEN objPubClassCaseSenateGaugeVersionEN, bool bolIsNeedCheckUniqueness = true)
{
 if (string.IsNullOrEmpty(objPubClassCaseSenateGaugeVersionEN.IdPubClassCaseSenateGaugeVersion) == true)
 {
string strMsg = string.Format("添加记录时,关键字不能为空!(from {{0}})", 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
 if (clsPubClassCaseSenateGaugeVersionBL.IsExist(objPubClassCaseSenateGaugeVersionEN.IdPubClassCaseSenateGaugeVersion) == true)
 {
string strMsg = string.Format("添加记录时,关键字:[{0}]已经存在!(from {1})\r\n", objPubClassCaseSenateGaugeVersionEN.IdPubClassCaseSenateGaugeVersion, 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
try
{
string strKey = clsPubClassCaseSenateGaugeVersionBL.PubClassCaseSenateGaugeVersionDA.AddNewRecordBySQL2WithReturnKey(objPubClassCaseSenateGaugeVersionEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsPubClassCaseSenateGaugeVersionBL.ReFreshCache();

if (clsPubClassCaseSenateGaugeVersionBL.relatedActions != null)
{
clsPubClassCaseSenateGaugeVersionBL.relatedActions.UpdRelaTabDate(objPubClassCaseSenateGaugeVersionEN.IdPubClassCaseSenateGaugeVersion, "SetUpdDate");
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
 /// <param name = "objPubClassCaseSenateGaugeVersionEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsPubClassCaseSenateGaugeVersionEN SetIdPubClassCaseSenateGaugeVersion(this clsPubClassCaseSenateGaugeVersionEN objPubClassCaseSenateGaugeVersionEN, string strIdPubClassCaseSenateGaugeVersion, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdPubClassCaseSenateGaugeVersion, 4, conPubClassCaseSenateGaugeVersion.IdPubClassCaseSenateGaugeVersion);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdPubClassCaseSenateGaugeVersion, 4, conPubClassCaseSenateGaugeVersion.IdPubClassCaseSenateGaugeVersion);
}
objPubClassCaseSenateGaugeVersionEN.IdPubClassCaseSenateGaugeVersion = strIdPubClassCaseSenateGaugeVersion; //公开课量表版本流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objPubClassCaseSenateGaugeVersionEN.dicFldComparisonOp.ContainsKey(conPubClassCaseSenateGaugeVersion.IdPubClassCaseSenateGaugeVersion) == false)
{
objPubClassCaseSenateGaugeVersionEN.dicFldComparisonOp.Add(conPubClassCaseSenateGaugeVersion.IdPubClassCaseSenateGaugeVersion, strComparisonOp);
}
else
{
objPubClassCaseSenateGaugeVersionEN.dicFldComparisonOp[conPubClassCaseSenateGaugeVersion.IdPubClassCaseSenateGaugeVersion] = strComparisonOp;
}
}
return objPubClassCaseSenateGaugeVersionEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objPubClassCaseSenateGaugeVersionEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsPubClassCaseSenateGaugeVersionEN SetsenateGaugeVersionID(this clsPubClassCaseSenateGaugeVersionEN objPubClassCaseSenateGaugeVersionEN, string strsenateGaugeVersionID, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strsenateGaugeVersionID, 4, conPubClassCaseSenateGaugeVersion.senateGaugeVersionID);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strsenateGaugeVersionID, 4, conPubClassCaseSenateGaugeVersion.senateGaugeVersionID);
}
objPubClassCaseSenateGaugeVersionEN.senateGaugeVersionID = strsenateGaugeVersionID; //评价量表版本ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objPubClassCaseSenateGaugeVersionEN.dicFldComparisonOp.ContainsKey(conPubClassCaseSenateGaugeVersion.senateGaugeVersionID) == false)
{
objPubClassCaseSenateGaugeVersionEN.dicFldComparisonOp.Add(conPubClassCaseSenateGaugeVersion.senateGaugeVersionID, strComparisonOp);
}
else
{
objPubClassCaseSenateGaugeVersionEN.dicFldComparisonOp[conPubClassCaseSenateGaugeVersion.senateGaugeVersionID] = strComparisonOp;
}
}
return objPubClassCaseSenateGaugeVersionEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objPubClassCaseSenateGaugeVersionEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsPubClassCaseSenateGaugeVersionEN SetsenateGaugeVersionName(this clsPubClassCaseSenateGaugeVersionEN objPubClassCaseSenateGaugeVersionEN, string strsenateGaugeVersionName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strsenateGaugeVersionName, 200, conPubClassCaseSenateGaugeVersion.senateGaugeVersionName);
}
objPubClassCaseSenateGaugeVersionEN.senateGaugeVersionName = strsenateGaugeVersionName; //评价量表版本名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objPubClassCaseSenateGaugeVersionEN.dicFldComparisonOp.ContainsKey(conPubClassCaseSenateGaugeVersion.senateGaugeVersionName) == false)
{
objPubClassCaseSenateGaugeVersionEN.dicFldComparisonOp.Add(conPubClassCaseSenateGaugeVersion.senateGaugeVersionName, strComparisonOp);
}
else
{
objPubClassCaseSenateGaugeVersionEN.dicFldComparisonOp[conPubClassCaseSenateGaugeVersion.senateGaugeVersionName] = strComparisonOp;
}
}
return objPubClassCaseSenateGaugeVersionEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objPubClassCaseSenateGaugeVersionEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsPubClassCaseSenateGaugeVersionEN SetsenateGaugeVersionTtlScore(this clsPubClassCaseSenateGaugeVersionEN objPubClassCaseSenateGaugeVersionEN, float? fltsenateGaugeVersionTtlScore, string strComparisonOp="")
	{
objPubClassCaseSenateGaugeVersionEN.senateGaugeVersionTtlScore = fltsenateGaugeVersionTtlScore; //评价量表版本总分
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objPubClassCaseSenateGaugeVersionEN.dicFldComparisonOp.ContainsKey(conPubClassCaseSenateGaugeVersion.senateGaugeVersionTtlScore) == false)
{
objPubClassCaseSenateGaugeVersionEN.dicFldComparisonOp.Add(conPubClassCaseSenateGaugeVersion.senateGaugeVersionTtlScore, strComparisonOp);
}
else
{
objPubClassCaseSenateGaugeVersionEN.dicFldComparisonOp[conPubClassCaseSenateGaugeVersion.senateGaugeVersionTtlScore] = strComparisonOp;
}
}
return objPubClassCaseSenateGaugeVersionEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objPubClassCaseSenateGaugeVersionEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsPubClassCaseSenateGaugeVersionEN SetIsUse(this clsPubClassCaseSenateGaugeVersionEN objPubClassCaseSenateGaugeVersionEN, bool bolIsUse, string strComparisonOp="")
	{
objPubClassCaseSenateGaugeVersionEN.IsUse = bolIsUse; //是否使用
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objPubClassCaseSenateGaugeVersionEN.dicFldComparisonOp.ContainsKey(conPubClassCaseSenateGaugeVersion.IsUse) == false)
{
objPubClassCaseSenateGaugeVersionEN.dicFldComparisonOp.Add(conPubClassCaseSenateGaugeVersion.IsUse, strComparisonOp);
}
else
{
objPubClassCaseSenateGaugeVersionEN.dicFldComparisonOp[conPubClassCaseSenateGaugeVersion.IsUse] = strComparisonOp;
}
}
return objPubClassCaseSenateGaugeVersionEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objPubClassCaseSenateGaugeVersionEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsPubClassCaseSenateGaugeVersionEN SetVersionNo(this clsPubClassCaseSenateGaugeVersionEN objPubClassCaseSenateGaugeVersionEN, int? intVersionNo, string strComparisonOp="")
	{
objPubClassCaseSenateGaugeVersionEN.VersionNo = intVersionNo; //版本号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objPubClassCaseSenateGaugeVersionEN.dicFldComparisonOp.ContainsKey(conPubClassCaseSenateGaugeVersion.VersionNo) == false)
{
objPubClassCaseSenateGaugeVersionEN.dicFldComparisonOp.Add(conPubClassCaseSenateGaugeVersion.VersionNo, strComparisonOp);
}
else
{
objPubClassCaseSenateGaugeVersionEN.dicFldComparisonOp[conPubClassCaseSenateGaugeVersion.VersionNo] = strComparisonOp;
}
}
return objPubClassCaseSenateGaugeVersionEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objPubClassCaseSenateGaugeVersionEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsPubClassCaseSenateGaugeVersionEN SetsenateGaugeVersionMemo(this clsPubClassCaseSenateGaugeVersionEN objPubClassCaseSenateGaugeVersionEN, string strsenateGaugeVersionMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strsenateGaugeVersionMemo, 1000, conPubClassCaseSenateGaugeVersion.senateGaugeVersionMemo);
}
objPubClassCaseSenateGaugeVersionEN.senateGaugeVersionMemo = strsenateGaugeVersionMemo; //评价量表版本说明
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objPubClassCaseSenateGaugeVersionEN.dicFldComparisonOp.ContainsKey(conPubClassCaseSenateGaugeVersion.senateGaugeVersionMemo) == false)
{
objPubClassCaseSenateGaugeVersionEN.dicFldComparisonOp.Add(conPubClassCaseSenateGaugeVersion.senateGaugeVersionMemo, strComparisonOp);
}
else
{
objPubClassCaseSenateGaugeVersionEN.dicFldComparisonOp[conPubClassCaseSenateGaugeVersion.senateGaugeVersionMemo] = strComparisonOp;
}
}
return objPubClassCaseSenateGaugeVersionEN;
	}

 /// <summary>
 /// 修改记录存盘到数据表中
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_UpdateRecordEx)
 /// </summary>
 /// <param name = "objPubClassCaseSenateGaugeVersionEN">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool UpdateRecordEx(this clsPubClassCaseSenateGaugeVersionEN objPubClassCaseSenateGaugeVersionEN)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
try
{
//1、检查传进去的对象属性是否合法
objPubClassCaseSenateGaugeVersionEN.CheckPropertyNew();
clsPubClassCaseSenateGaugeVersionEN objPubClassCaseSenateGaugeVersionCond = new clsPubClassCaseSenateGaugeVersionEN();
string strCondition = objPubClassCaseSenateGaugeVersionCond
.SetIdPubClassCaseSenateGaugeVersion(objPubClassCaseSenateGaugeVersionEN.IdPubClassCaseSenateGaugeVersion, "=")
.GetCombineCondition();
objPubClassCaseSenateGaugeVersionEN._IsCheckProperty = true;
bool bolIsExist = clsPubClassCaseSenateGaugeVersionBL.IsExistRecord(strCondition);
if (bolIsExist)
{
strMsg = "()不能重复!";
throw new Exception(strMsg);
}
//4、把数据实体层的数据存贮到数据库中
objPubClassCaseSenateGaugeVersionEN.Update();
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
 /// <param name = "objPubClassCaseSenateGaugeVersionEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsPubClassCaseSenateGaugeVersionEN objPubClassCaseSenateGaugeVersionEN)
{
 if (string.IsNullOrEmpty(objPubClassCaseSenateGaugeVersionEN.IdPubClassCaseSenateGaugeVersion) == true)
 {
string strMsg = string.Format("(errid:Busi000095)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsPubClassCaseSenateGaugeVersionBL.PubClassCaseSenateGaugeVersionDA.UpdateBySql2(objPubClassCaseSenateGaugeVersionEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsPubClassCaseSenateGaugeVersionBL.ReFreshCache();

if (clsPubClassCaseSenateGaugeVersionBL.relatedActions != null)
{
clsPubClassCaseSenateGaugeVersionBL.relatedActions.UpdRelaTabDate(objPubClassCaseSenateGaugeVersionEN.IdPubClassCaseSenateGaugeVersion, "SetUpdDate");
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
 /// <param name = "objPubClassCaseSenateGaugeVersionEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsPubClassCaseSenateGaugeVersionEN objPubClassCaseSenateGaugeVersionEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (string.IsNullOrEmpty(objPubClassCaseSenateGaugeVersionEN.IdPubClassCaseSenateGaugeVersion) == true)
 {
string strMsg = string.Format("(errid:Busi000087)修改记录时关键字不能为空!(带事务处理)(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsPubClassCaseSenateGaugeVersionBL.PubClassCaseSenateGaugeVersionDA.UpdateBySql2(objPubClassCaseSenateGaugeVersionEN, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsPubClassCaseSenateGaugeVersionBL.ReFreshCache();

if (clsPubClassCaseSenateGaugeVersionBL.relatedActions != null)
{
clsPubClassCaseSenateGaugeVersionBL.relatedActions.UpdRelaTabDate(objPubClassCaseSenateGaugeVersionEN.IdPubClassCaseSenateGaugeVersion, "SetUpdDate");
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
 /// <param name = "objPubClassCaseSenateGaugeVersionEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsPubClassCaseSenateGaugeVersionEN objPubClassCaseSenateGaugeVersionEN, string strWhereCond)
{
try
{
bool bolResult = clsPubClassCaseSenateGaugeVersionBL.PubClassCaseSenateGaugeVersionDA.UpdateBySqlWithCondition(objPubClassCaseSenateGaugeVersionEN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsPubClassCaseSenateGaugeVersionBL.ReFreshCache();

if (clsPubClassCaseSenateGaugeVersionBL.relatedActions != null)
{
clsPubClassCaseSenateGaugeVersionBL.relatedActions.UpdRelaTabDate(objPubClassCaseSenateGaugeVersionEN.IdPubClassCaseSenateGaugeVersion, "SetUpdDate");
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
 /// <param name = "objPubClassCaseSenateGaugeVersionEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsPubClassCaseSenateGaugeVersionEN objPubClassCaseSenateGaugeVersionEN, string strWhereCond, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
bool bolResult = clsPubClassCaseSenateGaugeVersionBL.PubClassCaseSenateGaugeVersionDA.UpdateBySqlWithConditionTransaction(objPubClassCaseSenateGaugeVersionEN, strWhereCond, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsPubClassCaseSenateGaugeVersionBL.ReFreshCache();

if (clsPubClassCaseSenateGaugeVersionBL.relatedActions != null)
{
clsPubClassCaseSenateGaugeVersionBL.relatedActions.UpdRelaTabDate(objPubClassCaseSenateGaugeVersionEN.IdPubClassCaseSenateGaugeVersion, "SetUpdDate");
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
 /// <param name = "strIdPubClassCaseSenateGaugeVersion">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int Delete(this clsPubClassCaseSenateGaugeVersionEN objPubClassCaseSenateGaugeVersionEN)
{
try
{
int intRecNum = clsPubClassCaseSenateGaugeVersionBL.PubClassCaseSenateGaugeVersionDA.DelRecord(objPubClassCaseSenateGaugeVersionEN.IdPubClassCaseSenateGaugeVersion);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsPubClassCaseSenateGaugeVersionBL.ReFreshCache();

if (clsPubClassCaseSenateGaugeVersionBL.relatedActions != null)
{
clsPubClassCaseSenateGaugeVersionBL.relatedActions.UpdRelaTabDate(objPubClassCaseSenateGaugeVersionEN.IdPubClassCaseSenateGaugeVersion, "SetUpdDate");
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
 /// <param name = "objPubClassCaseSenateGaugeVersionENS">源对象</param>
 /// <param name = "objPubClassCaseSenateGaugeVersionENT">目标对象</param>
 public static void CopyTo(this clsPubClassCaseSenateGaugeVersionEN objPubClassCaseSenateGaugeVersionENS, clsPubClassCaseSenateGaugeVersionEN objPubClassCaseSenateGaugeVersionENT)
{
try
{
objPubClassCaseSenateGaugeVersionENT.IdPubClassCaseSenateGaugeVersion = objPubClassCaseSenateGaugeVersionENS.IdPubClassCaseSenateGaugeVersion; //公开课量表版本流水号
objPubClassCaseSenateGaugeVersionENT.senateGaugeVersionID = objPubClassCaseSenateGaugeVersionENS.senateGaugeVersionID; //评价量表版本ID
objPubClassCaseSenateGaugeVersionENT.senateGaugeVersionName = objPubClassCaseSenateGaugeVersionENS.senateGaugeVersionName; //评价量表版本名称
objPubClassCaseSenateGaugeVersionENT.senateGaugeVersionTtlScore = objPubClassCaseSenateGaugeVersionENS.senateGaugeVersionTtlScore; //评价量表版本总分
objPubClassCaseSenateGaugeVersionENT.IsUse = objPubClassCaseSenateGaugeVersionENS.IsUse; //是否使用
objPubClassCaseSenateGaugeVersionENT.VersionNo = objPubClassCaseSenateGaugeVersionENS.VersionNo; //版本号
objPubClassCaseSenateGaugeVersionENT.senateGaugeVersionMemo = objPubClassCaseSenateGaugeVersionENS.senateGaugeVersionMemo; //评价量表版本说明
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
 /// <param name = "objPubClassCaseSenateGaugeVersionENS">源对象</param>
 /// <returns>目标对象=>clsPubClassCaseSenateGaugeVersionEN:objPubClassCaseSenateGaugeVersionENT</returns>
 public static clsPubClassCaseSenateGaugeVersionEN CopyTo(this clsPubClassCaseSenateGaugeVersionEN objPubClassCaseSenateGaugeVersionENS)
{
try
{
 clsPubClassCaseSenateGaugeVersionEN objPubClassCaseSenateGaugeVersionENT = new clsPubClassCaseSenateGaugeVersionEN()
{
IdPubClassCaseSenateGaugeVersion = objPubClassCaseSenateGaugeVersionENS.IdPubClassCaseSenateGaugeVersion, //公开课量表版本流水号
senateGaugeVersionID = objPubClassCaseSenateGaugeVersionENS.senateGaugeVersionID, //评价量表版本ID
senateGaugeVersionName = objPubClassCaseSenateGaugeVersionENS.senateGaugeVersionName, //评价量表版本名称
senateGaugeVersionTtlScore = objPubClassCaseSenateGaugeVersionENS.senateGaugeVersionTtlScore, //评价量表版本总分
IsUse = objPubClassCaseSenateGaugeVersionENS.IsUse, //是否使用
VersionNo = objPubClassCaseSenateGaugeVersionENS.VersionNo, //版本号
senateGaugeVersionMemo = objPubClassCaseSenateGaugeVersionENS.senateGaugeVersionMemo, //评价量表版本说明
};
 return objPubClassCaseSenateGaugeVersionENT;
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
public static void CheckPropertyNew(this clsPubClassCaseSenateGaugeVersionEN objPubClassCaseSenateGaugeVersionEN)
{
 clsPubClassCaseSenateGaugeVersionBL.PubClassCaseSenateGaugeVersionDA.CheckPropertyNew(objPubClassCaseSenateGaugeVersionEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(this clsPubClassCaseSenateGaugeVersionEN objPubClassCaseSenateGaugeVersionEN)
{
 clsPubClassCaseSenateGaugeVersionBL.PubClassCaseSenateGaugeVersionDA.CheckProperty4Condition(objPubClassCaseSenateGaugeVersionEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsPubClassCaseSenateGaugeVersionEN objPubClassCaseSenateGaugeVersionCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objPubClassCaseSenateGaugeVersionCond.IsUpdated(conPubClassCaseSenateGaugeVersion.IdPubClassCaseSenateGaugeVersion) == true)
{
string strComparisonOpIdPubClassCaseSenateGaugeVersion = objPubClassCaseSenateGaugeVersionCond.dicFldComparisonOp[conPubClassCaseSenateGaugeVersion.IdPubClassCaseSenateGaugeVersion];
strWhereCond += string.Format(" And {0} {2} '{1}'", conPubClassCaseSenateGaugeVersion.IdPubClassCaseSenateGaugeVersion, objPubClassCaseSenateGaugeVersionCond.IdPubClassCaseSenateGaugeVersion, strComparisonOpIdPubClassCaseSenateGaugeVersion);
}
if (objPubClassCaseSenateGaugeVersionCond.IsUpdated(conPubClassCaseSenateGaugeVersion.senateGaugeVersionID) == true)
{
string strComparisonOpsenateGaugeVersionID = objPubClassCaseSenateGaugeVersionCond.dicFldComparisonOp[conPubClassCaseSenateGaugeVersion.senateGaugeVersionID];
strWhereCond += string.Format(" And {0} {2} '{1}'", conPubClassCaseSenateGaugeVersion.senateGaugeVersionID, objPubClassCaseSenateGaugeVersionCond.senateGaugeVersionID, strComparisonOpsenateGaugeVersionID);
}
if (objPubClassCaseSenateGaugeVersionCond.IsUpdated(conPubClassCaseSenateGaugeVersion.senateGaugeVersionName) == true)
{
string strComparisonOpsenateGaugeVersionName = objPubClassCaseSenateGaugeVersionCond.dicFldComparisonOp[conPubClassCaseSenateGaugeVersion.senateGaugeVersionName];
strWhereCond += string.Format(" And {0} {2} '{1}'", conPubClassCaseSenateGaugeVersion.senateGaugeVersionName, objPubClassCaseSenateGaugeVersionCond.senateGaugeVersionName, strComparisonOpsenateGaugeVersionName);
}
if (objPubClassCaseSenateGaugeVersionCond.IsUpdated(conPubClassCaseSenateGaugeVersion.senateGaugeVersionTtlScore) == true)
{
string strComparisonOpsenateGaugeVersionTtlScore = objPubClassCaseSenateGaugeVersionCond.dicFldComparisonOp[conPubClassCaseSenateGaugeVersion.senateGaugeVersionTtlScore];
strWhereCond += string.Format(" And {0} {2} {1}", conPubClassCaseSenateGaugeVersion.senateGaugeVersionTtlScore, objPubClassCaseSenateGaugeVersionCond.senateGaugeVersionTtlScore, strComparisonOpsenateGaugeVersionTtlScore);
}
if (objPubClassCaseSenateGaugeVersionCond.IsUpdated(conPubClassCaseSenateGaugeVersion.IsUse) == true)
{
if (objPubClassCaseSenateGaugeVersionCond.IsUse == true)
{
strWhereCond += string.Format(" And {0} = '1'", conPubClassCaseSenateGaugeVersion.IsUse);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conPubClassCaseSenateGaugeVersion.IsUse);
}
}
if (objPubClassCaseSenateGaugeVersionCond.IsUpdated(conPubClassCaseSenateGaugeVersion.VersionNo) == true)
{
string strComparisonOpVersionNo = objPubClassCaseSenateGaugeVersionCond.dicFldComparisonOp[conPubClassCaseSenateGaugeVersion.VersionNo];
strWhereCond += string.Format(" And {0} {2} {1}", conPubClassCaseSenateGaugeVersion.VersionNo, objPubClassCaseSenateGaugeVersionCond.VersionNo, strComparisonOpVersionNo);
}
if (objPubClassCaseSenateGaugeVersionCond.IsUpdated(conPubClassCaseSenateGaugeVersion.senateGaugeVersionMemo) == true)
{
string strComparisonOpsenateGaugeVersionMemo = objPubClassCaseSenateGaugeVersionCond.dicFldComparisonOp[conPubClassCaseSenateGaugeVersion.senateGaugeVersionMemo];
strWhereCond += string.Format(" And {0} {2} '{1}'", conPubClassCaseSenateGaugeVersion.senateGaugeVersionMemo, objPubClassCaseSenateGaugeVersionCond.senateGaugeVersionMemo, strComparisonOpsenateGaugeVersionMemo);
}
 return strWhereCond;
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_PubClassCaseSenateGaugeVersion
{
public virtual bool UpdRelaTabDate(string strIdPubClassCaseSenateGaugeVersion, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// 公开课评价量规版本(PubClassCaseSenateGaugeVersion)
 /// 数据源类型:表
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsPubClassCaseSenateGaugeVersionBL
{
public static RelatedActions_PubClassCaseSenateGaugeVersion relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsPubClassCaseSenateGaugeVersionDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsPubClassCaseSenateGaugeVersionDA PubClassCaseSenateGaugeVersionDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsPubClassCaseSenateGaugeVersionDA();
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
 public clsPubClassCaseSenateGaugeVersionBL()
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
if (string.IsNullOrEmpty(clsPubClassCaseSenateGaugeVersionEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsPubClassCaseSenateGaugeVersionEN._ConnectString);
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
public static DataTable GetDataTable_PubClassCaseSenateGaugeVersion(string strWhereCond)
{
DataTable objDT;
try
{
objDT = PubClassCaseSenateGaugeVersionDA.GetDataTable_PubClassCaseSenateGaugeVersion(strWhereCond);
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
objDT = PubClassCaseSenateGaugeVersionDA.GetDataTable(strWhereCond);
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
objDT = PubClassCaseSenateGaugeVersionDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = PubClassCaseSenateGaugeVersionDA.GetDataTable(strWhereCond, strTabName);
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
objDT = PubClassCaseSenateGaugeVersionDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = PubClassCaseSenateGaugeVersionDA.GetDataTable_Top(objTopPara);
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
objDT = PubClassCaseSenateGaugeVersionDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = PubClassCaseSenateGaugeVersionDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = PubClassCaseSenateGaugeVersionDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
 /// <param name = "arrIdPubClassCaseSenateGaugeVersionLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static List<clsPubClassCaseSenateGaugeVersionEN> GetObjLstByIdPubClassCaseSenateGaugeVersionLst(List<string> arrIdPubClassCaseSenateGaugeVersionLst)
{
List<clsPubClassCaseSenateGaugeVersionEN> arrObjLst = new List<clsPubClassCaseSenateGaugeVersionEN>(); 
System.Data.DataTable objDT; 
 string strSqlConditionStr = clsArray.GetSqlInStrByArray(arrIdPubClassCaseSenateGaugeVersionLst, true);
 string strWhereCond = string.Format("IdPubClassCaseSenateGaugeVersion in ({0})", strSqlConditionStr);
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsPubClassCaseSenateGaugeVersionEN objPubClassCaseSenateGaugeVersionEN = new clsPubClassCaseSenateGaugeVersionEN();
try
{
objPubClassCaseSenateGaugeVersionEN.IdPubClassCaseSenateGaugeVersion = objRow[conPubClassCaseSenateGaugeVersion.IdPubClassCaseSenateGaugeVersion].ToString().Trim(); //公开课量表版本流水号
objPubClassCaseSenateGaugeVersionEN.senateGaugeVersionID = objRow[conPubClassCaseSenateGaugeVersion.senateGaugeVersionID] == DBNull.Value ? null : objRow[conPubClassCaseSenateGaugeVersion.senateGaugeVersionID].ToString().Trim(); //评价量表版本ID
objPubClassCaseSenateGaugeVersionEN.senateGaugeVersionName = objRow[conPubClassCaseSenateGaugeVersion.senateGaugeVersionName] == DBNull.Value ? null : objRow[conPubClassCaseSenateGaugeVersion.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称
objPubClassCaseSenateGaugeVersionEN.senateGaugeVersionTtlScore = objRow[conPubClassCaseSenateGaugeVersion.senateGaugeVersionTtlScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conPubClassCaseSenateGaugeVersion.senateGaugeVersionTtlScore].ToString().Trim()); //评价量表版本总分
objPubClassCaseSenateGaugeVersionEN.IsUse = clsEntityBase2.TransNullToBool_S(objRow[conPubClassCaseSenateGaugeVersion.IsUse].ToString().Trim()); //是否使用
objPubClassCaseSenateGaugeVersionEN.VersionNo = objRow[conPubClassCaseSenateGaugeVersion.VersionNo] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conPubClassCaseSenateGaugeVersion.VersionNo].ToString().Trim()); //版本号
objPubClassCaseSenateGaugeVersionEN.senateGaugeVersionMemo = objRow[conPubClassCaseSenateGaugeVersion.senateGaugeVersionMemo] == DBNull.Value ? null : objRow[conPubClassCaseSenateGaugeVersion.senateGaugeVersionMemo].ToString().Trim(); //评价量表版本说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objPubClassCaseSenateGaugeVersionEN.IdPubClassCaseSenateGaugeVersion, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objPubClassCaseSenateGaugeVersionEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrIdPubClassCaseSenateGaugeVersionLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsPubClassCaseSenateGaugeVersionEN> GetObjLstByIdPubClassCaseSenateGaugeVersionLstCache(List<string> arrIdPubClassCaseSenateGaugeVersionLst)
{
string strKey = string.Format("{0}", clsPubClassCaseSenateGaugeVersionEN._CurrTabName);
List<clsPubClassCaseSenateGaugeVersionEN> arrPubClassCaseSenateGaugeVersionObjLstCache = GetObjLstCache();
IEnumerable <clsPubClassCaseSenateGaugeVersionEN> arrPubClassCaseSenateGaugeVersionObjLst_Sel =
arrPubClassCaseSenateGaugeVersionObjLstCache
.Where(x => arrIdPubClassCaseSenateGaugeVersionLst.Contains(x.IdPubClassCaseSenateGaugeVersion));
return arrPubClassCaseSenateGaugeVersionObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsPubClassCaseSenateGaugeVersionEN> GetObjLst(string strWhereCond)
{
List<clsPubClassCaseSenateGaugeVersionEN> arrObjLst = new List<clsPubClassCaseSenateGaugeVersionEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsPubClassCaseSenateGaugeVersionEN objPubClassCaseSenateGaugeVersionEN = new clsPubClassCaseSenateGaugeVersionEN();
try
{
objPubClassCaseSenateGaugeVersionEN.IdPubClassCaseSenateGaugeVersion = objRow[conPubClassCaseSenateGaugeVersion.IdPubClassCaseSenateGaugeVersion].ToString().Trim(); //公开课量表版本流水号
objPubClassCaseSenateGaugeVersionEN.senateGaugeVersionID = objRow[conPubClassCaseSenateGaugeVersion.senateGaugeVersionID] == DBNull.Value ? null : objRow[conPubClassCaseSenateGaugeVersion.senateGaugeVersionID].ToString().Trim(); //评价量表版本ID
objPubClassCaseSenateGaugeVersionEN.senateGaugeVersionName = objRow[conPubClassCaseSenateGaugeVersion.senateGaugeVersionName] == DBNull.Value ? null : objRow[conPubClassCaseSenateGaugeVersion.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称
objPubClassCaseSenateGaugeVersionEN.senateGaugeVersionTtlScore = objRow[conPubClassCaseSenateGaugeVersion.senateGaugeVersionTtlScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conPubClassCaseSenateGaugeVersion.senateGaugeVersionTtlScore].ToString().Trim()); //评价量表版本总分
objPubClassCaseSenateGaugeVersionEN.IsUse = clsEntityBase2.TransNullToBool_S(objRow[conPubClassCaseSenateGaugeVersion.IsUse].ToString().Trim()); //是否使用
objPubClassCaseSenateGaugeVersionEN.VersionNo = objRow[conPubClassCaseSenateGaugeVersion.VersionNo] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conPubClassCaseSenateGaugeVersion.VersionNo].ToString().Trim()); //版本号
objPubClassCaseSenateGaugeVersionEN.senateGaugeVersionMemo = objRow[conPubClassCaseSenateGaugeVersion.senateGaugeVersionMemo] == DBNull.Value ? null : objRow[conPubClassCaseSenateGaugeVersion.senateGaugeVersionMemo].ToString().Trim(); //评价量表版本说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objPubClassCaseSenateGaugeVersionEN.IdPubClassCaseSenateGaugeVersion, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objPubClassCaseSenateGaugeVersionEN);
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
public static List<clsPubClassCaseSenateGaugeVersionEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsPubClassCaseSenateGaugeVersionEN> arrObjLst = new List<clsPubClassCaseSenateGaugeVersionEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsPubClassCaseSenateGaugeVersionEN objPubClassCaseSenateGaugeVersionEN = new clsPubClassCaseSenateGaugeVersionEN();
try
{
objPubClassCaseSenateGaugeVersionEN.IdPubClassCaseSenateGaugeVersion = objRow[conPubClassCaseSenateGaugeVersion.IdPubClassCaseSenateGaugeVersion].ToString().Trim(); //公开课量表版本流水号
objPubClassCaseSenateGaugeVersionEN.senateGaugeVersionID = objRow[conPubClassCaseSenateGaugeVersion.senateGaugeVersionID] == DBNull.Value ? null : objRow[conPubClassCaseSenateGaugeVersion.senateGaugeVersionID].ToString().Trim(); //评价量表版本ID
objPubClassCaseSenateGaugeVersionEN.senateGaugeVersionName = objRow[conPubClassCaseSenateGaugeVersion.senateGaugeVersionName] == DBNull.Value ? null : objRow[conPubClassCaseSenateGaugeVersion.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称
objPubClassCaseSenateGaugeVersionEN.senateGaugeVersionTtlScore = objRow[conPubClassCaseSenateGaugeVersion.senateGaugeVersionTtlScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conPubClassCaseSenateGaugeVersion.senateGaugeVersionTtlScore].ToString().Trim()); //评价量表版本总分
objPubClassCaseSenateGaugeVersionEN.IsUse = clsEntityBase2.TransNullToBool_S(objRow[conPubClassCaseSenateGaugeVersion.IsUse].ToString().Trim()); //是否使用
objPubClassCaseSenateGaugeVersionEN.VersionNo = objRow[conPubClassCaseSenateGaugeVersion.VersionNo] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conPubClassCaseSenateGaugeVersion.VersionNo].ToString().Trim()); //版本号
objPubClassCaseSenateGaugeVersionEN.senateGaugeVersionMemo = objRow[conPubClassCaseSenateGaugeVersion.senateGaugeVersionMemo] == DBNull.Value ? null : objRow[conPubClassCaseSenateGaugeVersion.senateGaugeVersionMemo].ToString().Trim(); //评价量表版本说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objPubClassCaseSenateGaugeVersionEN.IdPubClassCaseSenateGaugeVersion, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objPubClassCaseSenateGaugeVersionEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objPubClassCaseSenateGaugeVersionCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsPubClassCaseSenateGaugeVersionEN> GetSubObjLstCache(clsPubClassCaseSenateGaugeVersionEN objPubClassCaseSenateGaugeVersionCond)
{
List<clsPubClassCaseSenateGaugeVersionEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsPubClassCaseSenateGaugeVersionEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conPubClassCaseSenateGaugeVersion.AttributeName)
{
if (objPubClassCaseSenateGaugeVersionCond.IsUpdated(strFldName) == false) continue;
if (objPubClassCaseSenateGaugeVersionCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objPubClassCaseSenateGaugeVersionCond[strFldName].ToString());
}
else
{
if (objPubClassCaseSenateGaugeVersionCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objPubClassCaseSenateGaugeVersionCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objPubClassCaseSenateGaugeVersionCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objPubClassCaseSenateGaugeVersionCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objPubClassCaseSenateGaugeVersionCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objPubClassCaseSenateGaugeVersionCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objPubClassCaseSenateGaugeVersionCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objPubClassCaseSenateGaugeVersionCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objPubClassCaseSenateGaugeVersionCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objPubClassCaseSenateGaugeVersionCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objPubClassCaseSenateGaugeVersionCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objPubClassCaseSenateGaugeVersionCond[strFldName]));
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
public static List<clsPubClassCaseSenateGaugeVersionEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsPubClassCaseSenateGaugeVersionEN> arrObjLst = new List<clsPubClassCaseSenateGaugeVersionEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsPubClassCaseSenateGaugeVersionEN objPubClassCaseSenateGaugeVersionEN = new clsPubClassCaseSenateGaugeVersionEN();
try
{
objPubClassCaseSenateGaugeVersionEN.IdPubClassCaseSenateGaugeVersion = objRow[conPubClassCaseSenateGaugeVersion.IdPubClassCaseSenateGaugeVersion].ToString().Trim(); //公开课量表版本流水号
objPubClassCaseSenateGaugeVersionEN.senateGaugeVersionID = objRow[conPubClassCaseSenateGaugeVersion.senateGaugeVersionID] == DBNull.Value ? null : objRow[conPubClassCaseSenateGaugeVersion.senateGaugeVersionID].ToString().Trim(); //评价量表版本ID
objPubClassCaseSenateGaugeVersionEN.senateGaugeVersionName = objRow[conPubClassCaseSenateGaugeVersion.senateGaugeVersionName] == DBNull.Value ? null : objRow[conPubClassCaseSenateGaugeVersion.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称
objPubClassCaseSenateGaugeVersionEN.senateGaugeVersionTtlScore = objRow[conPubClassCaseSenateGaugeVersion.senateGaugeVersionTtlScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conPubClassCaseSenateGaugeVersion.senateGaugeVersionTtlScore].ToString().Trim()); //评价量表版本总分
objPubClassCaseSenateGaugeVersionEN.IsUse = clsEntityBase2.TransNullToBool_S(objRow[conPubClassCaseSenateGaugeVersion.IsUse].ToString().Trim()); //是否使用
objPubClassCaseSenateGaugeVersionEN.VersionNo = objRow[conPubClassCaseSenateGaugeVersion.VersionNo] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conPubClassCaseSenateGaugeVersion.VersionNo].ToString().Trim()); //版本号
objPubClassCaseSenateGaugeVersionEN.senateGaugeVersionMemo = objRow[conPubClassCaseSenateGaugeVersion.senateGaugeVersionMemo] == DBNull.Value ? null : objRow[conPubClassCaseSenateGaugeVersion.senateGaugeVersionMemo].ToString().Trim(); //评价量表版本说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objPubClassCaseSenateGaugeVersionEN.IdPubClassCaseSenateGaugeVersion, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objPubClassCaseSenateGaugeVersionEN);
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
public static List<clsPubClassCaseSenateGaugeVersionEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsPubClassCaseSenateGaugeVersionEN> arrObjLst = new List<clsPubClassCaseSenateGaugeVersionEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsPubClassCaseSenateGaugeVersionEN objPubClassCaseSenateGaugeVersionEN = new clsPubClassCaseSenateGaugeVersionEN();
try
{
objPubClassCaseSenateGaugeVersionEN.IdPubClassCaseSenateGaugeVersion = objRow[conPubClassCaseSenateGaugeVersion.IdPubClassCaseSenateGaugeVersion].ToString().Trim(); //公开课量表版本流水号
objPubClassCaseSenateGaugeVersionEN.senateGaugeVersionID = objRow[conPubClassCaseSenateGaugeVersion.senateGaugeVersionID] == DBNull.Value ? null : objRow[conPubClassCaseSenateGaugeVersion.senateGaugeVersionID].ToString().Trim(); //评价量表版本ID
objPubClassCaseSenateGaugeVersionEN.senateGaugeVersionName = objRow[conPubClassCaseSenateGaugeVersion.senateGaugeVersionName] == DBNull.Value ? null : objRow[conPubClassCaseSenateGaugeVersion.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称
objPubClassCaseSenateGaugeVersionEN.senateGaugeVersionTtlScore = objRow[conPubClassCaseSenateGaugeVersion.senateGaugeVersionTtlScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conPubClassCaseSenateGaugeVersion.senateGaugeVersionTtlScore].ToString().Trim()); //评价量表版本总分
objPubClassCaseSenateGaugeVersionEN.IsUse = clsEntityBase2.TransNullToBool_S(objRow[conPubClassCaseSenateGaugeVersion.IsUse].ToString().Trim()); //是否使用
objPubClassCaseSenateGaugeVersionEN.VersionNo = objRow[conPubClassCaseSenateGaugeVersion.VersionNo] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conPubClassCaseSenateGaugeVersion.VersionNo].ToString().Trim()); //版本号
objPubClassCaseSenateGaugeVersionEN.senateGaugeVersionMemo = objRow[conPubClassCaseSenateGaugeVersion.senateGaugeVersionMemo] == DBNull.Value ? null : objRow[conPubClassCaseSenateGaugeVersion.senateGaugeVersionMemo].ToString().Trim(); //评价量表版本说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objPubClassCaseSenateGaugeVersionEN.IdPubClassCaseSenateGaugeVersion, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objPubClassCaseSenateGaugeVersionEN);
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
List<clsPubClassCaseSenateGaugeVersionEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsPubClassCaseSenateGaugeVersionEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsPubClassCaseSenateGaugeVersionEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsPubClassCaseSenateGaugeVersionEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsPubClassCaseSenateGaugeVersionEN> arrObjLst = new List<clsPubClassCaseSenateGaugeVersionEN>(); 
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
	clsPubClassCaseSenateGaugeVersionEN objPubClassCaseSenateGaugeVersionEN = new clsPubClassCaseSenateGaugeVersionEN();
try
{
objPubClassCaseSenateGaugeVersionEN.IdPubClassCaseSenateGaugeVersion = objRow[conPubClassCaseSenateGaugeVersion.IdPubClassCaseSenateGaugeVersion].ToString().Trim(); //公开课量表版本流水号
objPubClassCaseSenateGaugeVersionEN.senateGaugeVersionID = objRow[conPubClassCaseSenateGaugeVersion.senateGaugeVersionID] == DBNull.Value ? null : objRow[conPubClassCaseSenateGaugeVersion.senateGaugeVersionID].ToString().Trim(); //评价量表版本ID
objPubClassCaseSenateGaugeVersionEN.senateGaugeVersionName = objRow[conPubClassCaseSenateGaugeVersion.senateGaugeVersionName] == DBNull.Value ? null : objRow[conPubClassCaseSenateGaugeVersion.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称
objPubClassCaseSenateGaugeVersionEN.senateGaugeVersionTtlScore = objRow[conPubClassCaseSenateGaugeVersion.senateGaugeVersionTtlScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conPubClassCaseSenateGaugeVersion.senateGaugeVersionTtlScore].ToString().Trim()); //评价量表版本总分
objPubClassCaseSenateGaugeVersionEN.IsUse = clsEntityBase2.TransNullToBool_S(objRow[conPubClassCaseSenateGaugeVersion.IsUse].ToString().Trim()); //是否使用
objPubClassCaseSenateGaugeVersionEN.VersionNo = objRow[conPubClassCaseSenateGaugeVersion.VersionNo] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conPubClassCaseSenateGaugeVersion.VersionNo].ToString().Trim()); //版本号
objPubClassCaseSenateGaugeVersionEN.senateGaugeVersionMemo = objRow[conPubClassCaseSenateGaugeVersion.senateGaugeVersionMemo] == DBNull.Value ? null : objRow[conPubClassCaseSenateGaugeVersion.senateGaugeVersionMemo].ToString().Trim(); //评价量表版本说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objPubClassCaseSenateGaugeVersionEN.IdPubClassCaseSenateGaugeVersion, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objPubClassCaseSenateGaugeVersionEN);
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
public static List<clsPubClassCaseSenateGaugeVersionEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsPubClassCaseSenateGaugeVersionEN> arrObjLst = new List<clsPubClassCaseSenateGaugeVersionEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsPubClassCaseSenateGaugeVersionEN objPubClassCaseSenateGaugeVersionEN = new clsPubClassCaseSenateGaugeVersionEN();
try
{
objPubClassCaseSenateGaugeVersionEN.IdPubClassCaseSenateGaugeVersion = objRow[conPubClassCaseSenateGaugeVersion.IdPubClassCaseSenateGaugeVersion].ToString().Trim(); //公开课量表版本流水号
objPubClassCaseSenateGaugeVersionEN.senateGaugeVersionID = objRow[conPubClassCaseSenateGaugeVersion.senateGaugeVersionID] == DBNull.Value ? null : objRow[conPubClassCaseSenateGaugeVersion.senateGaugeVersionID].ToString().Trim(); //评价量表版本ID
objPubClassCaseSenateGaugeVersionEN.senateGaugeVersionName = objRow[conPubClassCaseSenateGaugeVersion.senateGaugeVersionName] == DBNull.Value ? null : objRow[conPubClassCaseSenateGaugeVersion.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称
objPubClassCaseSenateGaugeVersionEN.senateGaugeVersionTtlScore = objRow[conPubClassCaseSenateGaugeVersion.senateGaugeVersionTtlScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conPubClassCaseSenateGaugeVersion.senateGaugeVersionTtlScore].ToString().Trim()); //评价量表版本总分
objPubClassCaseSenateGaugeVersionEN.IsUse = clsEntityBase2.TransNullToBool_S(objRow[conPubClassCaseSenateGaugeVersion.IsUse].ToString().Trim()); //是否使用
objPubClassCaseSenateGaugeVersionEN.VersionNo = objRow[conPubClassCaseSenateGaugeVersion.VersionNo] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conPubClassCaseSenateGaugeVersion.VersionNo].ToString().Trim()); //版本号
objPubClassCaseSenateGaugeVersionEN.senateGaugeVersionMemo = objRow[conPubClassCaseSenateGaugeVersion.senateGaugeVersionMemo] == DBNull.Value ? null : objRow[conPubClassCaseSenateGaugeVersion.senateGaugeVersionMemo].ToString().Trim(); //评价量表版本说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objPubClassCaseSenateGaugeVersionEN.IdPubClassCaseSenateGaugeVersion, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objPubClassCaseSenateGaugeVersionEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsPubClassCaseSenateGaugeVersionEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsPubClassCaseSenateGaugeVersionEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsPubClassCaseSenateGaugeVersionEN> arrObjLst = new List<clsPubClassCaseSenateGaugeVersionEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsPubClassCaseSenateGaugeVersionEN objPubClassCaseSenateGaugeVersionEN = new clsPubClassCaseSenateGaugeVersionEN();
try
{
objPubClassCaseSenateGaugeVersionEN.IdPubClassCaseSenateGaugeVersion = objRow[conPubClassCaseSenateGaugeVersion.IdPubClassCaseSenateGaugeVersion].ToString().Trim(); //公开课量表版本流水号
objPubClassCaseSenateGaugeVersionEN.senateGaugeVersionID = objRow[conPubClassCaseSenateGaugeVersion.senateGaugeVersionID] == DBNull.Value ? null : objRow[conPubClassCaseSenateGaugeVersion.senateGaugeVersionID].ToString().Trim(); //评价量表版本ID
objPubClassCaseSenateGaugeVersionEN.senateGaugeVersionName = objRow[conPubClassCaseSenateGaugeVersion.senateGaugeVersionName] == DBNull.Value ? null : objRow[conPubClassCaseSenateGaugeVersion.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称
objPubClassCaseSenateGaugeVersionEN.senateGaugeVersionTtlScore = objRow[conPubClassCaseSenateGaugeVersion.senateGaugeVersionTtlScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conPubClassCaseSenateGaugeVersion.senateGaugeVersionTtlScore].ToString().Trim()); //评价量表版本总分
objPubClassCaseSenateGaugeVersionEN.IsUse = clsEntityBase2.TransNullToBool_S(objRow[conPubClassCaseSenateGaugeVersion.IsUse].ToString().Trim()); //是否使用
objPubClassCaseSenateGaugeVersionEN.VersionNo = objRow[conPubClassCaseSenateGaugeVersion.VersionNo] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conPubClassCaseSenateGaugeVersion.VersionNo].ToString().Trim()); //版本号
objPubClassCaseSenateGaugeVersionEN.senateGaugeVersionMemo = objRow[conPubClassCaseSenateGaugeVersion.senateGaugeVersionMemo] == DBNull.Value ? null : objRow[conPubClassCaseSenateGaugeVersion.senateGaugeVersionMemo].ToString().Trim(); //评价量表版本说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objPubClassCaseSenateGaugeVersionEN.IdPubClassCaseSenateGaugeVersion, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objPubClassCaseSenateGaugeVersionEN);
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
public static List<clsPubClassCaseSenateGaugeVersionEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsPubClassCaseSenateGaugeVersionEN> arrObjLst = new List<clsPubClassCaseSenateGaugeVersionEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsPubClassCaseSenateGaugeVersionEN objPubClassCaseSenateGaugeVersionEN = new clsPubClassCaseSenateGaugeVersionEN();
try
{
objPubClassCaseSenateGaugeVersionEN.IdPubClassCaseSenateGaugeVersion = objRow[conPubClassCaseSenateGaugeVersion.IdPubClassCaseSenateGaugeVersion].ToString().Trim(); //公开课量表版本流水号
objPubClassCaseSenateGaugeVersionEN.senateGaugeVersionID = objRow[conPubClassCaseSenateGaugeVersion.senateGaugeVersionID] == DBNull.Value ? null : objRow[conPubClassCaseSenateGaugeVersion.senateGaugeVersionID].ToString().Trim(); //评价量表版本ID
objPubClassCaseSenateGaugeVersionEN.senateGaugeVersionName = objRow[conPubClassCaseSenateGaugeVersion.senateGaugeVersionName] == DBNull.Value ? null : objRow[conPubClassCaseSenateGaugeVersion.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称
objPubClassCaseSenateGaugeVersionEN.senateGaugeVersionTtlScore = objRow[conPubClassCaseSenateGaugeVersion.senateGaugeVersionTtlScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conPubClassCaseSenateGaugeVersion.senateGaugeVersionTtlScore].ToString().Trim()); //评价量表版本总分
objPubClassCaseSenateGaugeVersionEN.IsUse = clsEntityBase2.TransNullToBool_S(objRow[conPubClassCaseSenateGaugeVersion.IsUse].ToString().Trim()); //是否使用
objPubClassCaseSenateGaugeVersionEN.VersionNo = objRow[conPubClassCaseSenateGaugeVersion.VersionNo] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conPubClassCaseSenateGaugeVersion.VersionNo].ToString().Trim()); //版本号
objPubClassCaseSenateGaugeVersionEN.senateGaugeVersionMemo = objRow[conPubClassCaseSenateGaugeVersion.senateGaugeVersionMemo] == DBNull.Value ? null : objRow[conPubClassCaseSenateGaugeVersion.senateGaugeVersionMemo].ToString().Trim(); //评价量表版本说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objPubClassCaseSenateGaugeVersionEN.IdPubClassCaseSenateGaugeVersion, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objPubClassCaseSenateGaugeVersionEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsPubClassCaseSenateGaugeVersionEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsPubClassCaseSenateGaugeVersionEN> arrObjLst = new List<clsPubClassCaseSenateGaugeVersionEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsPubClassCaseSenateGaugeVersionEN objPubClassCaseSenateGaugeVersionEN = new clsPubClassCaseSenateGaugeVersionEN();
try
{
objPubClassCaseSenateGaugeVersionEN.IdPubClassCaseSenateGaugeVersion = objRow[conPubClassCaseSenateGaugeVersion.IdPubClassCaseSenateGaugeVersion].ToString().Trim(); //公开课量表版本流水号
objPubClassCaseSenateGaugeVersionEN.senateGaugeVersionID = objRow[conPubClassCaseSenateGaugeVersion.senateGaugeVersionID] == DBNull.Value ? null : objRow[conPubClassCaseSenateGaugeVersion.senateGaugeVersionID].ToString().Trim(); //评价量表版本ID
objPubClassCaseSenateGaugeVersionEN.senateGaugeVersionName = objRow[conPubClassCaseSenateGaugeVersion.senateGaugeVersionName] == DBNull.Value ? null : objRow[conPubClassCaseSenateGaugeVersion.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称
objPubClassCaseSenateGaugeVersionEN.senateGaugeVersionTtlScore = objRow[conPubClassCaseSenateGaugeVersion.senateGaugeVersionTtlScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conPubClassCaseSenateGaugeVersion.senateGaugeVersionTtlScore].ToString().Trim()); //评价量表版本总分
objPubClassCaseSenateGaugeVersionEN.IsUse = clsEntityBase2.TransNullToBool_S(objRow[conPubClassCaseSenateGaugeVersion.IsUse].ToString().Trim()); //是否使用
objPubClassCaseSenateGaugeVersionEN.VersionNo = objRow[conPubClassCaseSenateGaugeVersion.VersionNo] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conPubClassCaseSenateGaugeVersion.VersionNo].ToString().Trim()); //版本号
objPubClassCaseSenateGaugeVersionEN.senateGaugeVersionMemo = objRow[conPubClassCaseSenateGaugeVersion.senateGaugeVersionMemo] == DBNull.Value ? null : objRow[conPubClassCaseSenateGaugeVersion.senateGaugeVersionMemo].ToString().Trim(); //评价量表版本说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objPubClassCaseSenateGaugeVersionEN.IdPubClassCaseSenateGaugeVersion, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objPubClassCaseSenateGaugeVersionEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objPubClassCaseSenateGaugeVersionEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetPubClassCaseSenateGaugeVersion(ref clsPubClassCaseSenateGaugeVersionEN objPubClassCaseSenateGaugeVersionEN)
{
bool bolResult = PubClassCaseSenateGaugeVersionDA.GetPubClassCaseSenateGaugeVersion(ref objPubClassCaseSenateGaugeVersionEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "strIdPubClassCaseSenateGaugeVersion">表关键字</param>
 /// <returns>表对象</returns>
public static clsPubClassCaseSenateGaugeVersionEN GetObjByIdPubClassCaseSenateGaugeVersion(string strIdPubClassCaseSenateGaugeVersion)
{
if (strIdPubClassCaseSenateGaugeVersion.IndexOf(' ') >=0)
{
var strMsg = string.Format("(errid:Busi000079)在表中,关键字[strIdPubClassCaseSenateGaugeVersion]中不能有空格!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
if (string.IsNullOrEmpty(strIdPubClassCaseSenateGaugeVersion) == true)
{
var strMsg = string.Format("(errid:Busi000020)在表中,关键字[strIdPubClassCaseSenateGaugeVersion]不能为空!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
clsPubClassCaseSenateGaugeVersionEN objPubClassCaseSenateGaugeVersionEN = PubClassCaseSenateGaugeVersionDA.GetObjByIdPubClassCaseSenateGaugeVersion(strIdPubClassCaseSenateGaugeVersion);
return objPubClassCaseSenateGaugeVersionEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsPubClassCaseSenateGaugeVersionEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsPubClassCaseSenateGaugeVersionEN objPubClassCaseSenateGaugeVersionEN = PubClassCaseSenateGaugeVersionDA.GetFirstObj(strWhereCond);
 return objPubClassCaseSenateGaugeVersionEN;
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
public static clsPubClassCaseSenateGaugeVersionEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsPubClassCaseSenateGaugeVersionEN objPubClassCaseSenateGaugeVersionEN = PubClassCaseSenateGaugeVersionDA.GetObjByDataRow(objRow);
 return objPubClassCaseSenateGaugeVersionEN;
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
public static clsPubClassCaseSenateGaugeVersionEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsPubClassCaseSenateGaugeVersionEN objPubClassCaseSenateGaugeVersionEN = PubClassCaseSenateGaugeVersionDA.GetObjByDataRow(objRow);
 return objPubClassCaseSenateGaugeVersionEN;
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
 /// <param name = "strIdPubClassCaseSenateGaugeVersion">所给的关键字</param>
 /// <param name = "lstPubClassCaseSenateGaugeVersionObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsPubClassCaseSenateGaugeVersionEN GetObjByIdPubClassCaseSenateGaugeVersionFromList(string strIdPubClassCaseSenateGaugeVersion, List<clsPubClassCaseSenateGaugeVersionEN> lstPubClassCaseSenateGaugeVersionObjLst)
{
foreach (clsPubClassCaseSenateGaugeVersionEN objPubClassCaseSenateGaugeVersionEN in lstPubClassCaseSenateGaugeVersionObjLst)
{
if (objPubClassCaseSenateGaugeVersionEN.IdPubClassCaseSenateGaugeVersion == strIdPubClassCaseSenateGaugeVersion)
{
return objPubClassCaseSenateGaugeVersionEN;
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
 string strIdPubClassCaseSenateGaugeVersion;
 try
 {
 strIdPubClassCaseSenateGaugeVersion = new clsPubClassCaseSenateGaugeVersionDA().GetFirstID(strWhereCond);
 return strIdPubClassCaseSenateGaugeVersion;
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
 arrList = PubClassCaseSenateGaugeVersionDA.GetID(strWhereCond);
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
bool bolIsExist = PubClassCaseSenateGaugeVersionDA.IsExistCondRec(strWhereCond);
return bolIsExist;
}

 /// <summary>
 /// 判断当前表中是否存在给定关键字值的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExist)
 /// </summary>
 /// <param name = "strIdPubClassCaseSenateGaugeVersion">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public static bool IsExist(string strIdPubClassCaseSenateGaugeVersion)
{
if (string.IsNullOrEmpty(strIdPubClassCaseSenateGaugeVersion) == true)
{
var strMsg = string.Format("(errid:Busi000027)在表中,关键字[strIdPubClassCaseSenateGaugeVersion]不能为空!!(from {0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
//检测记录是否存在
bool bolIsExist = PubClassCaseSenateGaugeVersionDA.IsExist(strIdPubClassCaseSenateGaugeVersion);
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
 bolIsExist = clsPubClassCaseSenateGaugeVersionDA.IsExistTable();
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
 bolIsExist = PubClassCaseSenateGaugeVersionDA.IsExistTable(strTabName);
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
 /// <param name = "objPubClassCaseSenateGaugeVersionEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecordBySql2(clsPubClassCaseSenateGaugeVersionEN objPubClassCaseSenateGaugeVersionEN, bool bolIsNeedCheckUniqueness=true)
{
 if (string.IsNullOrEmpty(objPubClassCaseSenateGaugeVersionEN.IdPubClassCaseSenateGaugeVersion) == true)
 {
string strMsg = string.Format("添加记录时,关键字不能为空!(from {0})\r\n", 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
 if (clsPubClassCaseSenateGaugeVersionBL.IsExist(objPubClassCaseSenateGaugeVersionEN.IdPubClassCaseSenateGaugeVersion) == true)
 {
string strMsg = string.Format("添加记录时,关键字:[{0}]已经存在!(from {1})\r\n", objPubClassCaseSenateGaugeVersionEN.IdPubClassCaseSenateGaugeVersion, 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
try
{
bool bolResult = PubClassCaseSenateGaugeVersionDA.AddNewRecordBySQL2(objPubClassCaseSenateGaugeVersionEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsPubClassCaseSenateGaugeVersionBL.ReFreshCache();

if (clsPubClassCaseSenateGaugeVersionBL.relatedActions != null)
{
clsPubClassCaseSenateGaugeVersionBL.relatedActions.UpdRelaTabDate(objPubClassCaseSenateGaugeVersionEN.IdPubClassCaseSenateGaugeVersion, "SetUpdDate");
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
 /// <param name = "objPubClassCaseSenateGaugeVersionEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordBySql2WithReturnKey(clsPubClassCaseSenateGaugeVersionEN objPubClassCaseSenateGaugeVersionEN, bool bolIsNeedCheckUniqueness=true)
{
 if (string.IsNullOrEmpty(objPubClassCaseSenateGaugeVersionEN.IdPubClassCaseSenateGaugeVersion) == true)
 {
string strMsg = string.Format("添加记录时,关键字不能为空!(from {{0}})", 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
 if (clsPubClassCaseSenateGaugeVersionBL.IsExist(objPubClassCaseSenateGaugeVersionEN.IdPubClassCaseSenateGaugeVersion) == true)
 {
string strMsg = string.Format("添加记录时,关键字:[{0}]已经存在!(from {1})\r\n", objPubClassCaseSenateGaugeVersionEN.IdPubClassCaseSenateGaugeVersion, 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
try
{
string strKey = PubClassCaseSenateGaugeVersionDA.AddNewRecordBySQL2WithReturnKey(objPubClassCaseSenateGaugeVersionEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsPubClassCaseSenateGaugeVersionBL.ReFreshCache();

if (clsPubClassCaseSenateGaugeVersionBL.relatedActions != null)
{
clsPubClassCaseSenateGaugeVersionBL.relatedActions.UpdRelaTabDate(objPubClassCaseSenateGaugeVersionEN.IdPubClassCaseSenateGaugeVersion, "SetUpdDate");
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
 /// <param name = "objPubClassCaseSenateGaugeVersionEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(clsPubClassCaseSenateGaugeVersionEN objPubClassCaseSenateGaugeVersionEN)
{
try
{
bool bolResult = PubClassCaseSenateGaugeVersionDA.Update(objPubClassCaseSenateGaugeVersionEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsPubClassCaseSenateGaugeVersionBL.ReFreshCache();

if (clsPubClassCaseSenateGaugeVersionBL.relatedActions != null)
{
clsPubClassCaseSenateGaugeVersionBL.relatedActions.UpdRelaTabDate(objPubClassCaseSenateGaugeVersionEN.IdPubClassCaseSenateGaugeVersion, "SetUpdDate");
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
 /// <param name = "objPubClassCaseSenateGaugeVersionEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateBySql2(clsPubClassCaseSenateGaugeVersionEN objPubClassCaseSenateGaugeVersionEN)
{
 if (string.IsNullOrEmpty(objPubClassCaseSenateGaugeVersionEN.IdPubClassCaseSenateGaugeVersion) == true)
 {
var strMsg = string.Format("(errid:Busi000065)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = PubClassCaseSenateGaugeVersionDA.UpdateBySql2(objPubClassCaseSenateGaugeVersionEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsPubClassCaseSenateGaugeVersionBL.ReFreshCache();

if (clsPubClassCaseSenateGaugeVersionBL.relatedActions != null)
{
clsPubClassCaseSenateGaugeVersionBL.relatedActions.UpdRelaTabDate(objPubClassCaseSenateGaugeVersionEN.IdPubClassCaseSenateGaugeVersion, "SetUpdDate");
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
 /// <param name = "strIdPubClassCaseSenateGaugeVersion">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int DelRecord(string strIdPubClassCaseSenateGaugeVersion)
{
try
{
 clsPubClassCaseSenateGaugeVersionEN objPubClassCaseSenateGaugeVersionEN = clsPubClassCaseSenateGaugeVersionBL.GetObjByIdPubClassCaseSenateGaugeVersion(strIdPubClassCaseSenateGaugeVersion);

if (clsPubClassCaseSenateGaugeVersionBL.relatedActions != null)
{
clsPubClassCaseSenateGaugeVersionBL.relatedActions.UpdRelaTabDate(objPubClassCaseSenateGaugeVersionEN.IdPubClassCaseSenateGaugeVersion, "SetUpdDate");
}
if (objPubClassCaseSenateGaugeVersionEN != null)
{
int intRecNum = PubClassCaseSenateGaugeVersionDA.DelRecord(strIdPubClassCaseSenateGaugeVersion);
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
/// <param name="strIdPubClassCaseSenateGaugeVersion">表关键字</param>
/// <returns></returns>
public static bool DelRecordEx(string strIdPubClassCaseSenateGaugeVersion )
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsPubClassCaseSenateGaugeVersionDA.GetSpecSQLObj();
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
//删除与表:[PubClassCaseSenateGaugeVersion]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conPubClassCaseSenateGaugeVersion.IdPubClassCaseSenateGaugeVersion,
//strIdPubClassCaseSenateGaugeVersion);
//        clsPubClassCaseSenateGaugeVersionBL.DelPubClassCaseSenateGaugeVersionsByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsPubClassCaseSenateGaugeVersionBL.DelRecord(strIdPubClassCaseSenateGaugeVersion, objConnection, objSqlTransaction);
objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsPubClassCaseSenateGaugeVersionBLEx", "DelRecordEx", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("扩展删除记录出错:{0}!keyId = {1}.({2})",
objException.Message,
strIdPubClassCaseSenateGaugeVersion, clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "strIdPubClassCaseSenateGaugeVersion">给定的关键字值</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回删除是否成功?</returns>
public static bool DelRecord(string strIdPubClassCaseSenateGaugeVersion, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
if (clsPubClassCaseSenateGaugeVersionBL.relatedActions != null)
{
clsPubClassCaseSenateGaugeVersionBL.relatedActions.UpdRelaTabDate(strIdPubClassCaseSenateGaugeVersion, "UpdRelaTabDate");
}
bool bolResult = PubClassCaseSenateGaugeVersionDA.DelRecord(strIdPubClassCaseSenateGaugeVersion,objSqlConnection,objSqlTransaction);
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
 /// <param name = "arrIdPubClassCaseSenateGaugeVersionLst">给定的关键字值列表</param>
 /// <returns>返回删除的记录数</returns>
public static int DelPubClassCaseSenateGaugeVersions(List<string> arrIdPubClassCaseSenateGaugeVersionLst)
{
if (arrIdPubClassCaseSenateGaugeVersionLst.Count == 0) return 0;
try
{
if (clsPubClassCaseSenateGaugeVersionBL.relatedActions != null)
{
foreach (var strIdPubClassCaseSenateGaugeVersion in arrIdPubClassCaseSenateGaugeVersionLst)
{
clsPubClassCaseSenateGaugeVersionBL.relatedActions.UpdRelaTabDate(strIdPubClassCaseSenateGaugeVersion, "UpdRelaTabDate");
}
}
int intDelRecNum = PubClassCaseSenateGaugeVersionDA.DelPubClassCaseSenateGaugeVersion(arrIdPubClassCaseSenateGaugeVersionLst);
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
public static int DelPubClassCaseSenateGaugeVersionsByCond(string strWhereCond)
{
try
{
if (clsPubClassCaseSenateGaugeVersionBL.relatedActions != null)
{
List<string> arrIdPubClassCaseSenateGaugeVersion = GetPrimaryKeyID_S(strWhereCond);
foreach (var strIdPubClassCaseSenateGaugeVersion in arrIdPubClassCaseSenateGaugeVersion)
{
clsPubClassCaseSenateGaugeVersionBL.relatedActions.UpdRelaTabDate(strIdPubClassCaseSenateGaugeVersion, "UpdRelaTabDate");
}
}
int intRecNum = PubClassCaseSenateGaugeVersionDA.DelPubClassCaseSenateGaugeVersion(strWhereCond);
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
/// 这里仅仅是演示函数,使用时请复制到扩展类:[PubClassCaseSenateGaugeVersion]中改名为:[DelRecord4MultiTabEx]使用
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DelRecord4MultiTab)
/// </summary>
/// <param name="strIdPubClassCaseSenateGaugeVersion">表关键字</param>
/// <returns></returns>
public static bool DelRecord4MultiTab(string strIdPubClassCaseSenateGaugeVersion)
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsPubClassCaseSenateGaugeVersionDA.GetSpecSQLObj();
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
//删除与表:[PubClassCaseSenateGaugeVersion]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conStudent.id_College,
//strid_College);
//        clsStudentBL.DelStudentsByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsPubClassCaseSenateGaugeVersionBL.DelRecord(strIdPubClassCaseSenateGaugeVersion, objConnection, objSqlTransaction);
                objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsPubClassCaseSenateGaugeVersionBL", "DelRecord4MultiTab", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("删除多表记录出错:{0}!keyId = {1}.({2})",
objException.Message,
strIdPubClassCaseSenateGaugeVersion, clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "objPubClassCaseSenateGaugeVersionENS">源对象</param>
 /// <param name = "objPubClassCaseSenateGaugeVersionENT">目标对象</param>
 public static void CopyTo(clsPubClassCaseSenateGaugeVersionEN objPubClassCaseSenateGaugeVersionENS, clsPubClassCaseSenateGaugeVersionEN objPubClassCaseSenateGaugeVersionENT)
{
try
{
objPubClassCaseSenateGaugeVersionENT.IdPubClassCaseSenateGaugeVersion = objPubClassCaseSenateGaugeVersionENS.IdPubClassCaseSenateGaugeVersion; //公开课量表版本流水号
objPubClassCaseSenateGaugeVersionENT.senateGaugeVersionID = objPubClassCaseSenateGaugeVersionENS.senateGaugeVersionID; //评价量表版本ID
objPubClassCaseSenateGaugeVersionENT.senateGaugeVersionName = objPubClassCaseSenateGaugeVersionENS.senateGaugeVersionName; //评价量表版本名称
objPubClassCaseSenateGaugeVersionENT.senateGaugeVersionTtlScore = objPubClassCaseSenateGaugeVersionENS.senateGaugeVersionTtlScore; //评价量表版本总分
objPubClassCaseSenateGaugeVersionENT.IsUse = objPubClassCaseSenateGaugeVersionENS.IsUse; //是否使用
objPubClassCaseSenateGaugeVersionENT.VersionNo = objPubClassCaseSenateGaugeVersionENS.VersionNo; //版本号
objPubClassCaseSenateGaugeVersionENT.senateGaugeVersionMemo = objPubClassCaseSenateGaugeVersionENS.senateGaugeVersionMemo; //评价量表版本说明
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
 /// <param name = "objPubClassCaseSenateGaugeVersionEN">源简化对象</param>
 public static void SetUpdFlag(clsPubClassCaseSenateGaugeVersionEN objPubClassCaseSenateGaugeVersionEN)
{
try
{
objPubClassCaseSenateGaugeVersionEN.ClearUpdateState();
   string strsfUpdFldSetStr = objPubClassCaseSenateGaugeVersionEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(conPubClassCaseSenateGaugeVersion.IdPubClassCaseSenateGaugeVersion, new clsStrCompareIgnoreCase())  ==  true)
{
objPubClassCaseSenateGaugeVersionEN.IdPubClassCaseSenateGaugeVersion = objPubClassCaseSenateGaugeVersionEN.IdPubClassCaseSenateGaugeVersion; //公开课量表版本流水号
}
if (arrFldSet.Contains(conPubClassCaseSenateGaugeVersion.senateGaugeVersionID, new clsStrCompareIgnoreCase())  ==  true)
{
objPubClassCaseSenateGaugeVersionEN.senateGaugeVersionID = objPubClassCaseSenateGaugeVersionEN.senateGaugeVersionID == "[null]" ? null :  objPubClassCaseSenateGaugeVersionEN.senateGaugeVersionID; //评价量表版本ID
}
if (arrFldSet.Contains(conPubClassCaseSenateGaugeVersion.senateGaugeVersionName, new clsStrCompareIgnoreCase())  ==  true)
{
objPubClassCaseSenateGaugeVersionEN.senateGaugeVersionName = objPubClassCaseSenateGaugeVersionEN.senateGaugeVersionName == "[null]" ? null :  objPubClassCaseSenateGaugeVersionEN.senateGaugeVersionName; //评价量表版本名称
}
if (arrFldSet.Contains(conPubClassCaseSenateGaugeVersion.senateGaugeVersionTtlScore, new clsStrCompareIgnoreCase())  ==  true)
{
objPubClassCaseSenateGaugeVersionEN.senateGaugeVersionTtlScore = objPubClassCaseSenateGaugeVersionEN.senateGaugeVersionTtlScore; //评价量表版本总分
}
if (arrFldSet.Contains(conPubClassCaseSenateGaugeVersion.IsUse, new clsStrCompareIgnoreCase())  ==  true)
{
objPubClassCaseSenateGaugeVersionEN.IsUse = objPubClassCaseSenateGaugeVersionEN.IsUse; //是否使用
}
if (arrFldSet.Contains(conPubClassCaseSenateGaugeVersion.VersionNo, new clsStrCompareIgnoreCase())  ==  true)
{
objPubClassCaseSenateGaugeVersionEN.VersionNo = objPubClassCaseSenateGaugeVersionEN.VersionNo; //版本号
}
if (arrFldSet.Contains(conPubClassCaseSenateGaugeVersion.senateGaugeVersionMemo, new clsStrCompareIgnoreCase())  ==  true)
{
objPubClassCaseSenateGaugeVersionEN.senateGaugeVersionMemo = objPubClassCaseSenateGaugeVersionEN.senateGaugeVersionMemo == "[null]" ? null :  objPubClassCaseSenateGaugeVersionEN.senateGaugeVersionMemo; //评价量表版本说明
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
 /// <param name = "objPubClassCaseSenateGaugeVersionEN">源简化对象</param>
 public static void AccessFldValueNull(clsPubClassCaseSenateGaugeVersionEN objPubClassCaseSenateGaugeVersionEN)
{
try
{
if (objPubClassCaseSenateGaugeVersionEN.senateGaugeVersionID == "[null]") objPubClassCaseSenateGaugeVersionEN.senateGaugeVersionID = null; //评价量表版本ID
if (objPubClassCaseSenateGaugeVersionEN.senateGaugeVersionName == "[null]") objPubClassCaseSenateGaugeVersionEN.senateGaugeVersionName = null; //评价量表版本名称
if (objPubClassCaseSenateGaugeVersionEN.senateGaugeVersionMemo == "[null]") objPubClassCaseSenateGaugeVersionEN.senateGaugeVersionMemo = null; //评价量表版本说明
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
public static void CheckPropertyNew(clsPubClassCaseSenateGaugeVersionEN objPubClassCaseSenateGaugeVersionEN)
{
 PubClassCaseSenateGaugeVersionDA.CheckPropertyNew(objPubClassCaseSenateGaugeVersionEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(clsPubClassCaseSenateGaugeVersionEN objPubClassCaseSenateGaugeVersionEN)
{
 PubClassCaseSenateGaugeVersionDA.CheckProperty4Condition(objPubClassCaseSenateGaugeVersionEN);
 }


 #endregion 检查对象属性


 #region 绑定下拉框

 /// <summary>
 /// 绑定基于Win的下拉框
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_TabFeature_ComboBoxBindFunction)
 /// </summary>
 /// <param name = "objComboBox">需要绑定当前表的下拉框</param>

public static void BindCbo_IdPubClassCaseSenateGaugeVersion(System.Windows.Forms.ComboBox objComboBox )
{
//为数据源为表的下拉框设置内容
string strCondition = string.Format("1 =1 Order By {0}", conPubClassCaseSenateGaugeVersion.IdPubClassCaseSenateGaugeVersion); 
List<clsPubClassCaseSenateGaugeVersionEN> arrObjLst = clsPubClassCaseSenateGaugeVersionBL.GetObjLst(strCondition);
//初始化一个对象列表
//插入第0项。在第0项中插入“请选择...”,为了方便用户,与WEB方式类似。
clsPubClassCaseSenateGaugeVersionEN objPubClassCaseSenateGaugeVersionEN = new clsPubClassCaseSenateGaugeVersionEN()
{
IdPubClassCaseSenateGaugeVersion = "0",
senateGaugeVersionName = "选[公开课评价量规版本]..."
};
arrObjLst.Insert(0, objPubClassCaseSenateGaugeVersionEN);
//设置下拉框的数据源、以及设置值项、显示项
objComboBox.ValueMember = conPubClassCaseSenateGaugeVersion.IdPubClassCaseSenateGaugeVersion;
objComboBox.DisplayMember = conPubClassCaseSenateGaugeVersion.senateGaugeVersionName;
objComboBox.DataSource = arrObjLst;
objComboBox.SelectedIndex = 0;
}

 /// <summary>
 /// 绑定基于Web的下拉框
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_TabFeature_DdlBindFunction)
 /// </summary>
 /// <param name = "objDDL">需要绑定当前表的下拉框</param>

public static void BindDdl_IdPubClassCaseSenateGaugeVersion(System.Web.UI.WebControls.DropDownList objDDL )
{
//为数据源于表的下拉框设置内容
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[公开课评价量规版本]...","0");
string strCondition = string.Format("1 =1 Order By {0}", conPubClassCaseSenateGaugeVersion.IdPubClassCaseSenateGaugeVersion); 
IEnumerable<clsPubClassCaseSenateGaugeVersionEN> arrObjLst = clsPubClassCaseSenateGaugeVersionBL.GetObjLst(strCondition);
objDDL.DataValueField = conPubClassCaseSenateGaugeVersion.IdPubClassCaseSenateGaugeVersion;
objDDL.DataTextField = conPubClassCaseSenateGaugeVersion.senateGaugeVersionName;
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
public static void BindDdl_IdPubClassCaseSenateGaugeVersionCache(System.Web.UI.WebControls.DropDownList objDDL)
{
//为数据源于表的下拉框设置内容
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[公开课评价量规版本]...","0");
List<clsPubClassCaseSenateGaugeVersionEN> arrPubClassCaseSenateGaugeVersionObjLst = GetAllPubClassCaseSenateGaugeVersionObjLstCache(); 
objDDL.DataValueField = conPubClassCaseSenateGaugeVersion.IdPubClassCaseSenateGaugeVersion;
objDDL.DataTextField = conPubClassCaseSenateGaugeVersion.senateGaugeVersionName;
objDDL.DataSource = arrPubClassCaseSenateGaugeVersionObjLst;
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
if (clsPubClassCaseSenateGaugeVersionBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsPubClassCaseSenateGaugeVersionBL没有刷新缓存机制(clsPubClassCaseSenateGaugeVersionBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by IdPubClassCaseSenateGaugeVersion");
//if (arrPubClassCaseSenateGaugeVersionObjLstCache == null)
//{
//arrPubClassCaseSenateGaugeVersionObjLstCache = PubClassCaseSenateGaugeVersionDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "strIdPubClassCaseSenateGaugeVersion">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsPubClassCaseSenateGaugeVersionEN GetObjByIdPubClassCaseSenateGaugeVersionCache(string strIdPubClassCaseSenateGaugeVersion)
{
//获取缓存中的对象列表
string strKey = string.Format("{0}", clsPubClassCaseSenateGaugeVersionEN._CurrTabName);
List<clsPubClassCaseSenateGaugeVersionEN> arrPubClassCaseSenateGaugeVersionObjLstCache = GetObjLstCache();
IEnumerable <clsPubClassCaseSenateGaugeVersionEN> arrPubClassCaseSenateGaugeVersionObjLst_Sel =
arrPubClassCaseSenateGaugeVersionObjLstCache
.Where(x=> x.IdPubClassCaseSenateGaugeVersion == strIdPubClassCaseSenateGaugeVersion 
);
if (arrPubClassCaseSenateGaugeVersionObjLst_Sel.Count() == 0)
{
   clsPubClassCaseSenateGaugeVersionEN obj = clsPubClassCaseSenateGaugeVersionBL.GetObjByIdPubClassCaseSenateGaugeVersion(strIdPubClassCaseSenateGaugeVersion);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
 }
return null;
}
return arrPubClassCaseSenateGaugeVersionObjLst_Sel.First();
}

 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecNameByKeyCache)
 /// </summary>
 /// <param name = "strIdPubClassCaseSenateGaugeVersion">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetsenateGaugeVersionNameByIdPubClassCaseSenateGaugeVersionCache(string strIdPubClassCaseSenateGaugeVersion)
{
if (string.IsNullOrEmpty(strIdPubClassCaseSenateGaugeVersion) == true) return "";
//获取缓存中的对象列表
clsPubClassCaseSenateGaugeVersionEN objPubClassCaseSenateGaugeVersion = GetObjByIdPubClassCaseSenateGaugeVersionCache(strIdPubClassCaseSenateGaugeVersion);
if (objPubClassCaseSenateGaugeVersion == null) return "";
return objPubClassCaseSenateGaugeVersion.senateGaugeVersionName;
}
 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecNameByKeyCache)
 /// </summary>
 /// <param name = "strIdPubClassCaseSenateGaugeVersion">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetNameByIdPubClassCaseSenateGaugeVersionCache(string strIdPubClassCaseSenateGaugeVersion)
{
if (string.IsNullOrEmpty(strIdPubClassCaseSenateGaugeVersion) == true) return "";
//获取缓存中的对象列表
clsPubClassCaseSenateGaugeVersionEN objPubClassCaseSenateGaugeVersion = GetObjByIdPubClassCaseSenateGaugeVersionCache(strIdPubClassCaseSenateGaugeVersion);
if (objPubClassCaseSenateGaugeVersion == null) return "";
return objPubClassCaseSenateGaugeVersion.senateGaugeVersionName;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsPubClassCaseSenateGaugeVersionEN> GetAllPubClassCaseSenateGaugeVersionObjLstCache()
{
//获取缓存中的对象列表
List<clsPubClassCaseSenateGaugeVersionEN> arrPubClassCaseSenateGaugeVersionObjLstCache = GetObjLstCache(); 
return arrPubClassCaseSenateGaugeVersionObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsPubClassCaseSenateGaugeVersionEN> GetObjLstCache()
{
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}", clsPubClassCaseSenateGaugeVersionEN._CurrTabName);
List<clsPubClassCaseSenateGaugeVersionEN> arrPubClassCaseSenateGaugeVersionObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrPubClassCaseSenateGaugeVersionObjLstCache;
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
string strKey = string.Format("{0}", clsPubClassCaseSenateGaugeVersionEN._CurrTabName);
CacheHelper.Remove(strKey);
clsPubClassCaseSenateGaugeVersionEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
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
if (clsPubClassCaseSenateGaugeVersionEN._RefreshTimeLst.Count == 0) return "";
return clsPubClassCaseSenateGaugeVersionEN._RefreshTimeLst[clsPubClassCaseSenateGaugeVersionEN._RefreshTimeLst.Count - 1];
}

 /// <summary>
 /// 刷新缓存.把当前表的缓存以及该表相关视图的缓存清空.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ReFreshCache)
 /// </summary>
public static void ReFreshCache()
{
if (clsPubClassCaseSenateGaugeVersionBL.objCommFun4BL != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}", clsPubClassCaseSenateGaugeVersionEN._CurrTabName);
CacheHelper.Remove(strKey);
clsPubClassCaseSenateGaugeVersionEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
clsPubClassCaseSenateGaugeVersionBL.objCommFun4BL.ReFreshCache();
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
public static string Func(string strInFldName, string strOutFldName, string strIdPubClassCaseSenateGaugeVersion)
{
if (strInFldName != conPubClassCaseSenateGaugeVersion.IdPubClassCaseSenateGaugeVersion)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (conPubClassCaseSenateGaugeVersion.AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", conPubClassCaseSenateGaugeVersion.AttributeName));
throw new Exception(strMsg);
}
var objPubClassCaseSenateGaugeVersion = clsPubClassCaseSenateGaugeVersionBL.GetObjByIdPubClassCaseSenateGaugeVersionCache(strIdPubClassCaseSenateGaugeVersion);
if (objPubClassCaseSenateGaugeVersion == null) return "";
return objPubClassCaseSenateGaugeVersion[strOutFldName].ToString();
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
int intRecCount = clsPubClassCaseSenateGaugeVersionDA.GetRecCount(strTabName);
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
int intRecCount = clsPubClassCaseSenateGaugeVersionDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsPubClassCaseSenateGaugeVersionDA.GetRecCount();
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
int intRecCount = clsPubClassCaseSenateGaugeVersionDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objPubClassCaseSenateGaugeVersionCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsPubClassCaseSenateGaugeVersionEN objPubClassCaseSenateGaugeVersionCond)
{
List<clsPubClassCaseSenateGaugeVersionEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsPubClassCaseSenateGaugeVersionEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conPubClassCaseSenateGaugeVersion.AttributeName)
{
if (objPubClassCaseSenateGaugeVersionCond.IsUpdated(strFldName) == false) continue;
if (objPubClassCaseSenateGaugeVersionCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objPubClassCaseSenateGaugeVersionCond[strFldName].ToString());
}
else
{
if (objPubClassCaseSenateGaugeVersionCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objPubClassCaseSenateGaugeVersionCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objPubClassCaseSenateGaugeVersionCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objPubClassCaseSenateGaugeVersionCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objPubClassCaseSenateGaugeVersionCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objPubClassCaseSenateGaugeVersionCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objPubClassCaseSenateGaugeVersionCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objPubClassCaseSenateGaugeVersionCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objPubClassCaseSenateGaugeVersionCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objPubClassCaseSenateGaugeVersionCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objPubClassCaseSenateGaugeVersionCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objPubClassCaseSenateGaugeVersionCond[strFldName]));
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
 List<string> arrList = clsPubClassCaseSenateGaugeVersionDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = PubClassCaseSenateGaugeVersionDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = PubClassCaseSenateGaugeVersionDA.GetFldValueNoDistinct(strFldName, strWhereCond);
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
int intRecCount = PubClassCaseSenateGaugeVersionDA.SetFldValue(strFldName, strValue, strWhereCond);
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
int intRecCount = clsPubClassCaseSenateGaugeVersionDA.SetFldValue(clsPubClassCaseSenateGaugeVersionEN._CurrTabName, strFldName, fltValue, strWhereCond);
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
int intRecCount = PubClassCaseSenateGaugeVersionDA.SetFldValue( strFldName, intValue, strWhereCond);
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
int intRecCount = clsPubClassCaseSenateGaugeVersionDA.SetFldValue(strTabName, strFldName, strValue, strWhereCond);
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
int intRecCount = clsPubClassCaseSenateGaugeVersionDA.SetFldValue(strTabName, strFldName, intValue, strWhereCond);
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
int intRecCount = clsPubClassCaseSenateGaugeVersionDA.SetFldValue(strTabName, strFldName, fltValue, strWhereCond);
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
  strCreateTabCode.Append("CREATE table [dbo].[PubClassCaseSenateGaugeVersion] "); 
 strCreateTabCode.Append(" ( "); 
 // /**公开课量表版本流水号*/ 
 strCreateTabCode.Append(" IdPubClassCaseSenateGaugeVersion char(4) primary key, "); 
 // /**评价量表版本ID*/ 
 strCreateTabCode.Append(" senateGaugeVersionID char(4) Null, "); 
 // /**评价量表版本名称*/ 
 strCreateTabCode.Append(" senateGaugeVersionName varchar(200) Null, "); 
 // /**评价量表版本总分*/ 
 strCreateTabCode.Append(" senateGaugeVersionTtlScore float Null, "); 
 // /**是否使用*/ 
 strCreateTabCode.Append(" IsUse bit Null, "); 
 // /**版本号*/ 
 strCreateTabCode.Append(" VersionNo int Null, "); 
 // /**评价量表版本说明*/ 
 strCreateTabCode.Append(" senateGaugeVersionMemo varchar(1000) Null ");
 strCreateTabCode.Append(") "); 
  strCreateTabCode.Append("ON [PRIMARY] ");
  return strCreateTabCode.ToString();
}



 #endregion 表操作
}
 /// <summary>
 /// 公开课评价量规版本(PubClassCaseSenateGaugeVersion)
 /// 数据源类型:表
 /// (AutoGCLib.CommFun4BL4CSharp:GeneCode_This)
 /// </summary>
public class  clsCommFun4BL4PubClassCaseSenateGaugeVersion : clsCommFun4BL
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
clsPubClassCaseSenateGaugeVersionBL.ReFreshThisCache();
}
}

}