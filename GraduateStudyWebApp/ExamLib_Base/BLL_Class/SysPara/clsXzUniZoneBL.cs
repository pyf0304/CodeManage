
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsXzUniZoneBL
 表名:XzUniZone(01120095)
 * 版本:2024.11.13.1(服务器:WIN-SRV103-116)
 日期:2024/11/13 05:58:51
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:研究生学习游戏化后台(000055, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:系统参数(SysPara)
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
public static class  clsXzUniZoneBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "strIdUniZone">表关键字</param>
 /// <returns>表对象</returns>
public static clsXzUniZoneEN GetObj(this K_IdUniZone_XzUniZone myKey)
{
clsXzUniZoneEN objXzUniZoneEN = clsXzUniZoneBL.XzUniZoneDA.GetObjByIdUniZone(myKey.Value);
return objXzUniZoneEN;
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_AddNewRecord)
 /// </summary>
 /// <param name = "objXzUniZoneEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clsXzUniZoneEN objXzUniZoneEN, bool bolIsNeedCheckUniqueness = true)
{
 if (string.IsNullOrEmpty(objXzUniZoneEN.IdUniZone) == true)
 {
string strMsg = string.Format("添加记录时,关键字不能为空!(from {0})\r\n", 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
 if (clsXzUniZoneBL.IsExist(objXzUniZoneEN.IdUniZone) == true)
 {
string strMsg = string.Format("添加记录时,关键字:[{0}]已经存在!(from {1})\r\n", objXzUniZoneEN.IdUniZone, 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
try
{
bool bolResult = clsXzUniZoneBL.XzUniZoneDA.AddNewRecordBySQL2(objXzUniZoneEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsXzUniZoneBL.ReFreshCache();

if (clsXzUniZoneBL.relatedActions != null)
{
clsXzUniZoneBL.relatedActions.UpdRelaTabDate(objXzUniZoneEN.IdUniZone, "SetUpdDate");
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
public static bool AddRecordEx(this clsXzUniZoneEN objXzUniZoneEN, bool bolIsNeedCheckUniqueness = true)
{
//操作步骤:
//1、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在
//2、检查唯一性
//3、检查传进去的对象属性是否合法
//4、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
//1、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在
if (clsXzUniZoneBL.IsExist(objXzUniZoneEN.IdUniZone))	//判断是否有相同的关键字
{
strMsg = "(errid:Busi000151)关键字字段已有相同的值";
throw new Exception(strMsg);
}
try
{
 //2、检查传进去的对象属性是否合法
objXzUniZoneEN.CheckPropertyNew();
//6、把数据实体层的数据存贮到数据库中
objXzUniZoneEN.AddNewRecord();
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
 /// <param name = "objXzUniZoneEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordWithReturnKey(this clsXzUniZoneEN objXzUniZoneEN, bool bolIsNeedCheckUniqueness = true)
{
 if (string.IsNullOrEmpty(objXzUniZoneEN.IdUniZone) == true)
 {
string strMsg = string.Format("添加记录时,关键字不能为空!(from {{0}})", 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
 if (clsXzUniZoneBL.IsExist(objXzUniZoneEN.IdUniZone) == true)
 {
string strMsg = string.Format("添加记录时,关键字:[{0}]已经存在!(from {1})\r\n", objXzUniZoneEN.IdUniZone, 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
try
{
string strKey = clsXzUniZoneBL.XzUniZoneDA.AddNewRecordBySQL2WithReturnKey(objXzUniZoneEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsXzUniZoneBL.ReFreshCache();

if (clsXzUniZoneBL.relatedActions != null)
{
clsXzUniZoneBL.relatedActions.UpdRelaTabDate(objXzUniZoneEN.IdUniZone, "SetUpdDate");
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
 /// <param name = "objXzUniZoneEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsXzUniZoneEN SetIdUniZone(this clsXzUniZoneEN objXzUniZoneEN, string strIdUniZone, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdUniZone, 4, conXzUniZone.IdUniZone);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdUniZone, 4, conXzUniZone.IdUniZone);
}
objXzUniZoneEN.IdUniZone = strIdUniZone; //校区流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objXzUniZoneEN.dicFldComparisonOp.ContainsKey(conXzUniZone.IdUniZone) == false)
{
objXzUniZoneEN.dicFldComparisonOp.Add(conXzUniZone.IdUniZone, strComparisonOp);
}
else
{
objXzUniZoneEN.dicFldComparisonOp[conXzUniZone.IdUniZone] = strComparisonOp;
}
}
return objXzUniZoneEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objXzUniZoneEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsXzUniZoneEN SetUniZoneID(this clsXzUniZoneEN objXzUniZoneEN, string strUniZoneID, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUniZoneID, 4, conXzUniZone.UniZoneID);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strUniZoneID, 4, conXzUniZone.UniZoneID);
}
objXzUniZoneEN.UniZoneID = strUniZoneID; //校区编号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objXzUniZoneEN.dicFldComparisonOp.ContainsKey(conXzUniZone.UniZoneID) == false)
{
objXzUniZoneEN.dicFldComparisonOp.Add(conXzUniZone.UniZoneID, strComparisonOp);
}
else
{
objXzUniZoneEN.dicFldComparisonOp[conXzUniZone.UniZoneID] = strComparisonOp;
}
}
return objXzUniZoneEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objXzUniZoneEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsXzUniZoneEN SetUniZoneDesc(this clsXzUniZoneEN objXzUniZoneEN, string strUniZoneDesc, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUniZoneDesc, 20, conXzUniZone.UniZoneDesc);
}
objXzUniZoneEN.UniZoneDesc = strUniZoneDesc; //校区名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objXzUniZoneEN.dicFldComparisonOp.ContainsKey(conXzUniZone.UniZoneDesc) == false)
{
objXzUniZoneEN.dicFldComparisonOp.Add(conXzUniZone.UniZoneDesc, strComparisonOp);
}
else
{
objXzUniZoneEN.dicFldComparisonOp[conXzUniZone.UniZoneDesc] = strComparisonOp;
}
}
return objXzUniZoneEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objXzUniZoneEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsXzUniZoneEN SetUniZoneDescA(this clsXzUniZoneEN objXzUniZoneEN, string strUniZoneDescA, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUniZoneDescA, 20, conXzUniZone.UniZoneDescA);
}
objXzUniZoneEN.UniZoneDescA = strUniZoneDescA; //UniZoneDescA
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objXzUniZoneEN.dicFldComparisonOp.ContainsKey(conXzUniZone.UniZoneDescA) == false)
{
objXzUniZoneEN.dicFldComparisonOp.Add(conXzUniZone.UniZoneDescA, strComparisonOp);
}
else
{
objXzUniZoneEN.dicFldComparisonOp[conXzUniZone.UniZoneDescA] = strComparisonOp;
}
}
return objXzUniZoneEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objXzUniZoneEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsXzUniZoneEN SetIdSchool(this clsXzUniZoneEN objXzUniZoneEN, string strIdSchool, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdSchool, 4, conXzUniZone.IdSchool);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdSchool, 4, conXzUniZone.IdSchool);
}
objXzUniZoneEN.IdSchool = strIdSchool; //学校流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objXzUniZoneEN.dicFldComparisonOp.ContainsKey(conXzUniZone.IdSchool) == false)
{
objXzUniZoneEN.dicFldComparisonOp.Add(conXzUniZone.IdSchool, strComparisonOp);
}
else
{
objXzUniZoneEN.dicFldComparisonOp[conXzUniZone.IdSchool] = strComparisonOp;
}
}
return objXzUniZoneEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objXzUniZoneEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsXzUniZoneEN SetIdUni(this clsXzUniZoneEN objXzUniZoneEN, string strIdUni, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdUni, 4, conXzUniZone.IdUni);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdUni, 4, conXzUniZone.IdUni);
}
objXzUniZoneEN.IdUni = strIdUni; //id_Uni
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objXzUniZoneEN.dicFldComparisonOp.ContainsKey(conXzUniZone.IdUni) == false)
{
objXzUniZoneEN.dicFldComparisonOp.Add(conXzUniZone.IdUni, strComparisonOp);
}
else
{
objXzUniZoneEN.dicFldComparisonOp[conXzUniZone.IdUni] = strComparisonOp;
}
}
return objXzUniZoneEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objXzUniZoneEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsXzUniZoneEN SetModifyUserId(this clsXzUniZoneEN objXzUniZoneEN, string strModifyUserId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strModifyUserId, 18, conXzUniZone.ModifyUserId);
}
objXzUniZoneEN.ModifyUserId = strModifyUserId; //修改人
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objXzUniZoneEN.dicFldComparisonOp.ContainsKey(conXzUniZone.ModifyUserId) == false)
{
objXzUniZoneEN.dicFldComparisonOp.Add(conXzUniZone.ModifyUserId, strComparisonOp);
}
else
{
objXzUniZoneEN.dicFldComparisonOp[conXzUniZone.ModifyUserId] = strComparisonOp;
}
}
return objXzUniZoneEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objXzUniZoneEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsXzUniZoneEN SetModifyDate(this clsXzUniZoneEN objXzUniZoneEN, string strModifyDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strModifyDate, 20, conXzUniZone.ModifyDate);
}
objXzUniZoneEN.ModifyDate = strModifyDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objXzUniZoneEN.dicFldComparisonOp.ContainsKey(conXzUniZone.ModifyDate) == false)
{
objXzUniZoneEN.dicFldComparisonOp.Add(conXzUniZone.ModifyDate, strComparisonOp);
}
else
{
objXzUniZoneEN.dicFldComparisonOp[conXzUniZone.ModifyDate] = strComparisonOp;
}
}
return objXzUniZoneEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objXzUniZoneEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsXzUniZoneEN SetMemo(this clsXzUniZoneEN objXzUniZoneEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, conXzUniZone.Memo);
}
objXzUniZoneEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objXzUniZoneEN.dicFldComparisonOp.ContainsKey(conXzUniZone.Memo) == false)
{
objXzUniZoneEN.dicFldComparisonOp.Add(conXzUniZone.Memo, strComparisonOp);
}
else
{
objXzUniZoneEN.dicFldComparisonOp[conXzUniZone.Memo] = strComparisonOp;
}
}
return objXzUniZoneEN;
	}

 /// <summary>
 /// 修改记录存盘到数据表中
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_UpdateRecordEx)
 /// </summary>
 /// <param name = "objXzUniZoneEN">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool UpdateRecordEx(this clsXzUniZoneEN objXzUniZoneEN)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
try
{
//1、检查传进去的对象属性是否合法
objXzUniZoneEN.CheckPropertyNew();
clsXzUniZoneEN objXzUniZoneCond = new clsXzUniZoneEN();
string strCondition = objXzUniZoneCond
.SetIdUniZone(objXzUniZoneEN.IdUniZone, "=")
.GetCombineCondition();
objXzUniZoneEN._IsCheckProperty = true;
bool bolIsExist = clsXzUniZoneBL.IsExistRecord(strCondition);
if (bolIsExist)
{
strMsg = "()不能重复!";
throw new Exception(strMsg);
}
//4、把数据实体层的数据存贮到数据库中
objXzUniZoneEN.Update();
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
 /// <param name = "objXzUniZoneEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsXzUniZoneEN objXzUniZoneEN)
{
 if (string.IsNullOrEmpty(objXzUniZoneEN.IdUniZone) == true)
 {
string strMsg = string.Format("(errid:Busi000095)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsXzUniZoneBL.XzUniZoneDA.UpdateBySql2(objXzUniZoneEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsXzUniZoneBL.ReFreshCache();

if (clsXzUniZoneBL.relatedActions != null)
{
clsXzUniZoneBL.relatedActions.UpdRelaTabDate(objXzUniZoneEN.IdUniZone, "SetUpdDate");
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
 /// <param name = "objXzUniZoneEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsXzUniZoneEN objXzUniZoneEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (string.IsNullOrEmpty(objXzUniZoneEN.IdUniZone) == true)
 {
string strMsg = string.Format("(errid:Busi000087)修改记录时关键字不能为空!(带事务处理)(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsXzUniZoneBL.XzUniZoneDA.UpdateBySql2(objXzUniZoneEN, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsXzUniZoneBL.ReFreshCache();

if (clsXzUniZoneBL.relatedActions != null)
{
clsXzUniZoneBL.relatedActions.UpdRelaTabDate(objXzUniZoneEN.IdUniZone, "SetUpdDate");
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
 /// <param name = "objXzUniZoneEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsXzUniZoneEN objXzUniZoneEN, string strWhereCond)
{
try
{
bool bolResult = clsXzUniZoneBL.XzUniZoneDA.UpdateBySqlWithCondition(objXzUniZoneEN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsXzUniZoneBL.ReFreshCache();

if (clsXzUniZoneBL.relatedActions != null)
{
clsXzUniZoneBL.relatedActions.UpdRelaTabDate(objXzUniZoneEN.IdUniZone, "SetUpdDate");
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
 /// <param name = "objXzUniZoneEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsXzUniZoneEN objXzUniZoneEN, string strWhereCond, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
bool bolResult = clsXzUniZoneBL.XzUniZoneDA.UpdateBySqlWithConditionTransaction(objXzUniZoneEN, strWhereCond, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsXzUniZoneBL.ReFreshCache();

if (clsXzUniZoneBL.relatedActions != null)
{
clsXzUniZoneBL.relatedActions.UpdRelaTabDate(objXzUniZoneEN.IdUniZone, "SetUpdDate");
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
 /// <param name = "strIdUniZone">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int Delete(this clsXzUniZoneEN objXzUniZoneEN)
{
try
{
int intRecNum = clsXzUniZoneBL.XzUniZoneDA.DelRecord(objXzUniZoneEN.IdUniZone);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsXzUniZoneBL.ReFreshCache();

if (clsXzUniZoneBL.relatedActions != null)
{
clsXzUniZoneBL.relatedActions.UpdRelaTabDate(objXzUniZoneEN.IdUniZone, "SetUpdDate");
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
 /// <param name = "objXzUniZoneENS">源对象</param>
 /// <param name = "objXzUniZoneENT">目标对象</param>
 public static void CopyTo(this clsXzUniZoneEN objXzUniZoneENS, clsXzUniZoneEN objXzUniZoneENT)
{
try
{
objXzUniZoneENT.IdUniZone = objXzUniZoneENS.IdUniZone; //校区流水号
objXzUniZoneENT.UniZoneID = objXzUniZoneENS.UniZoneID; //校区编号
objXzUniZoneENT.UniZoneDesc = objXzUniZoneENS.UniZoneDesc; //校区名称
objXzUniZoneENT.UniZoneDescA = objXzUniZoneENS.UniZoneDescA; //UniZoneDescA
objXzUniZoneENT.IdSchool = objXzUniZoneENS.IdSchool; //学校流水号
objXzUniZoneENT.IdUni = objXzUniZoneENS.IdUni; //id_Uni
objXzUniZoneENT.ModifyUserId = objXzUniZoneENS.ModifyUserId; //修改人
objXzUniZoneENT.ModifyDate = objXzUniZoneENS.ModifyDate; //修改日期
objXzUniZoneENT.Memo = objXzUniZoneENS.Memo; //备注
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
 /// <param name = "objXzUniZoneENS">源对象</param>
 /// <returns>目标对象=>clsXzUniZoneEN:objXzUniZoneENT</returns>
 public static clsXzUniZoneEN CopyTo(this clsXzUniZoneEN objXzUniZoneENS)
{
try
{
 clsXzUniZoneEN objXzUniZoneENT = new clsXzUniZoneEN()
{
IdUniZone = objXzUniZoneENS.IdUniZone, //校区流水号
UniZoneID = objXzUniZoneENS.UniZoneID, //校区编号
UniZoneDesc = objXzUniZoneENS.UniZoneDesc, //校区名称
UniZoneDescA = objXzUniZoneENS.UniZoneDescA, //UniZoneDescA
IdSchool = objXzUniZoneENS.IdSchool, //学校流水号
IdUni = objXzUniZoneENS.IdUni, //id_Uni
ModifyUserId = objXzUniZoneENS.ModifyUserId, //修改人
ModifyDate = objXzUniZoneENS.ModifyDate, //修改日期
Memo = objXzUniZoneENS.Memo, //备注
};
 return objXzUniZoneENT;
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
public static void CheckPropertyNew(this clsXzUniZoneEN objXzUniZoneEN)
{
 clsXzUniZoneBL.XzUniZoneDA.CheckPropertyNew(objXzUniZoneEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(this clsXzUniZoneEN objXzUniZoneEN)
{
 clsXzUniZoneBL.XzUniZoneDA.CheckProperty4Condition(objXzUniZoneEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsXzUniZoneEN objXzUniZoneCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objXzUniZoneCond.IsUpdated(conXzUniZone.IdUniZone) == true)
{
string strComparisonOpIdUniZone = objXzUniZoneCond.dicFldComparisonOp[conXzUniZone.IdUniZone];
strWhereCond += string.Format(" And {0} {2} '{1}'", conXzUniZone.IdUniZone, objXzUniZoneCond.IdUniZone, strComparisonOpIdUniZone);
}
if (objXzUniZoneCond.IsUpdated(conXzUniZone.UniZoneID) == true)
{
string strComparisonOpUniZoneID = objXzUniZoneCond.dicFldComparisonOp[conXzUniZone.UniZoneID];
strWhereCond += string.Format(" And {0} {2} '{1}'", conXzUniZone.UniZoneID, objXzUniZoneCond.UniZoneID, strComparisonOpUniZoneID);
}
if (objXzUniZoneCond.IsUpdated(conXzUniZone.UniZoneDesc) == true)
{
string strComparisonOpUniZoneDesc = objXzUniZoneCond.dicFldComparisonOp[conXzUniZone.UniZoneDesc];
strWhereCond += string.Format(" And {0} {2} '{1}'", conXzUniZone.UniZoneDesc, objXzUniZoneCond.UniZoneDesc, strComparisonOpUniZoneDesc);
}
if (objXzUniZoneCond.IsUpdated(conXzUniZone.UniZoneDescA) == true)
{
string strComparisonOpUniZoneDescA = objXzUniZoneCond.dicFldComparisonOp[conXzUniZone.UniZoneDescA];
strWhereCond += string.Format(" And {0} {2} '{1}'", conXzUniZone.UniZoneDescA, objXzUniZoneCond.UniZoneDescA, strComparisonOpUniZoneDescA);
}
if (objXzUniZoneCond.IsUpdated(conXzUniZone.IdSchool) == true)
{
string strComparisonOpIdSchool = objXzUniZoneCond.dicFldComparisonOp[conXzUniZone.IdSchool];
strWhereCond += string.Format(" And {0} {2} '{1}'", conXzUniZone.IdSchool, objXzUniZoneCond.IdSchool, strComparisonOpIdSchool);
}
if (objXzUniZoneCond.IsUpdated(conXzUniZone.IdUni) == true)
{
string strComparisonOpIdUni = objXzUniZoneCond.dicFldComparisonOp[conXzUniZone.IdUni];
strWhereCond += string.Format(" And {0} {2} '{1}'", conXzUniZone.IdUni, objXzUniZoneCond.IdUni, strComparisonOpIdUni);
}
if (objXzUniZoneCond.IsUpdated(conXzUniZone.ModifyUserId) == true)
{
string strComparisonOpModifyUserId = objXzUniZoneCond.dicFldComparisonOp[conXzUniZone.ModifyUserId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conXzUniZone.ModifyUserId, objXzUniZoneCond.ModifyUserId, strComparisonOpModifyUserId);
}
if (objXzUniZoneCond.IsUpdated(conXzUniZone.ModifyDate) == true)
{
string strComparisonOpModifyDate = objXzUniZoneCond.dicFldComparisonOp[conXzUniZone.ModifyDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conXzUniZone.ModifyDate, objXzUniZoneCond.ModifyDate, strComparisonOpModifyDate);
}
if (objXzUniZoneCond.IsUpdated(conXzUniZone.Memo) == true)
{
string strComparisonOpMemo = objXzUniZoneCond.dicFldComparisonOp[conXzUniZone.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", conXzUniZone.Memo, objXzUniZoneCond.Memo, strComparisonOpMemo);
}
 return strWhereCond;
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_XzUniZone
{
public virtual bool UpdRelaTabDate(string strIdUniZone, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// 校区(XzUniZone)
 /// 数据源类型:表
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsXzUniZoneBL
{
public static RelatedActions_XzUniZone relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsXzUniZoneDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsXzUniZoneDA XzUniZoneDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsXzUniZoneDA();
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
 public clsXzUniZoneBL()
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
if (string.IsNullOrEmpty(clsXzUniZoneEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsXzUniZoneEN._ConnectString);
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
public static DataTable GetDataTable_XzUniZone(string strWhereCond)
{
DataTable objDT;
try
{
objDT = XzUniZoneDA.GetDataTable_XzUniZone(strWhereCond);
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
objDT = XzUniZoneDA.GetDataTable(strWhereCond);
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
objDT = XzUniZoneDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = XzUniZoneDA.GetDataTable(strWhereCond, strTabName);
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
objDT = XzUniZoneDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = XzUniZoneDA.GetDataTable_Top(objTopPara);
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
objDT = XzUniZoneDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = XzUniZoneDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = XzUniZoneDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
 /// <param name = "arrIdUniZoneLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static List<clsXzUniZoneEN> GetObjLstByIdUniZoneLst(List<string> arrIdUniZoneLst)
{
List<clsXzUniZoneEN> arrObjLst = new List<clsXzUniZoneEN>(); 
System.Data.DataTable objDT; 
 string strSqlConditionStr = clsArray.GetSqlInStrByArray(arrIdUniZoneLst, true);
 string strWhereCond = string.Format("IdUniZone in ({0})", strSqlConditionStr);
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsXzUniZoneEN objXzUniZoneEN = new clsXzUniZoneEN();
try
{
objXzUniZoneEN.IdUniZone = objRow[conXzUniZone.IdUniZone].ToString().Trim(); //校区流水号
objXzUniZoneEN.UniZoneID = objRow[conXzUniZone.UniZoneID] == DBNull.Value ? null : objRow[conXzUniZone.UniZoneID].ToString().Trim(); //校区编号
objXzUniZoneEN.UniZoneDesc = objRow[conXzUniZone.UniZoneDesc] == DBNull.Value ? null : objRow[conXzUniZone.UniZoneDesc].ToString().Trim(); //校区名称
objXzUniZoneEN.UniZoneDescA = objRow[conXzUniZone.UniZoneDescA] == DBNull.Value ? null : objRow[conXzUniZone.UniZoneDescA].ToString().Trim(); //UniZoneDescA
objXzUniZoneEN.IdSchool = objRow[conXzUniZone.IdSchool] == DBNull.Value ? null : objRow[conXzUniZone.IdSchool].ToString().Trim(); //学校流水号
objXzUniZoneEN.IdUni = objRow[conXzUniZone.IdUni] == DBNull.Value ? null : objRow[conXzUniZone.IdUni].ToString().Trim(); //id_Uni
objXzUniZoneEN.ModifyUserId = objRow[conXzUniZone.ModifyUserId] == DBNull.Value ? null : objRow[conXzUniZone.ModifyUserId].ToString().Trim(); //修改人
objXzUniZoneEN.ModifyDate = objRow[conXzUniZone.ModifyDate] == DBNull.Value ? null : objRow[conXzUniZone.ModifyDate].ToString().Trim(); //修改日期
objXzUniZoneEN.Memo = objRow[conXzUniZone.Memo] == DBNull.Value ? null : objRow[conXzUniZone.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objXzUniZoneEN.IdUniZone, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objXzUniZoneEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrIdUniZoneLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsXzUniZoneEN> GetObjLstByIdUniZoneLstCache(List<string> arrIdUniZoneLst)
{
string strKey = string.Format("{0}", clsXzUniZoneEN._CurrTabName);
List<clsXzUniZoneEN> arrXzUniZoneObjLstCache = GetObjLstCache();
IEnumerable <clsXzUniZoneEN> arrXzUniZoneObjLst_Sel =
arrXzUniZoneObjLstCache
.Where(x => arrIdUniZoneLst.Contains(x.IdUniZone));
return arrXzUniZoneObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsXzUniZoneEN> GetObjLst(string strWhereCond)
{
List<clsXzUniZoneEN> arrObjLst = new List<clsXzUniZoneEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsXzUniZoneEN objXzUniZoneEN = new clsXzUniZoneEN();
try
{
objXzUniZoneEN.IdUniZone = objRow[conXzUniZone.IdUniZone].ToString().Trim(); //校区流水号
objXzUniZoneEN.UniZoneID = objRow[conXzUniZone.UniZoneID] == DBNull.Value ? null : objRow[conXzUniZone.UniZoneID].ToString().Trim(); //校区编号
objXzUniZoneEN.UniZoneDesc = objRow[conXzUniZone.UniZoneDesc] == DBNull.Value ? null : objRow[conXzUniZone.UniZoneDesc].ToString().Trim(); //校区名称
objXzUniZoneEN.UniZoneDescA = objRow[conXzUniZone.UniZoneDescA] == DBNull.Value ? null : objRow[conXzUniZone.UniZoneDescA].ToString().Trim(); //UniZoneDescA
objXzUniZoneEN.IdSchool = objRow[conXzUniZone.IdSchool] == DBNull.Value ? null : objRow[conXzUniZone.IdSchool].ToString().Trim(); //学校流水号
objXzUniZoneEN.IdUni = objRow[conXzUniZone.IdUni] == DBNull.Value ? null : objRow[conXzUniZone.IdUni].ToString().Trim(); //id_Uni
objXzUniZoneEN.ModifyUserId = objRow[conXzUniZone.ModifyUserId] == DBNull.Value ? null : objRow[conXzUniZone.ModifyUserId].ToString().Trim(); //修改人
objXzUniZoneEN.ModifyDate = objRow[conXzUniZone.ModifyDate] == DBNull.Value ? null : objRow[conXzUniZone.ModifyDate].ToString().Trim(); //修改日期
objXzUniZoneEN.Memo = objRow[conXzUniZone.Memo] == DBNull.Value ? null : objRow[conXzUniZone.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objXzUniZoneEN.IdUniZone, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objXzUniZoneEN);
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
public static List<clsXzUniZoneEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsXzUniZoneEN> arrObjLst = new List<clsXzUniZoneEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsXzUniZoneEN objXzUniZoneEN = new clsXzUniZoneEN();
try
{
objXzUniZoneEN.IdUniZone = objRow[conXzUniZone.IdUniZone].ToString().Trim(); //校区流水号
objXzUniZoneEN.UniZoneID = objRow[conXzUniZone.UniZoneID] == DBNull.Value ? null : objRow[conXzUniZone.UniZoneID].ToString().Trim(); //校区编号
objXzUniZoneEN.UniZoneDesc = objRow[conXzUniZone.UniZoneDesc] == DBNull.Value ? null : objRow[conXzUniZone.UniZoneDesc].ToString().Trim(); //校区名称
objXzUniZoneEN.UniZoneDescA = objRow[conXzUniZone.UniZoneDescA] == DBNull.Value ? null : objRow[conXzUniZone.UniZoneDescA].ToString().Trim(); //UniZoneDescA
objXzUniZoneEN.IdSchool = objRow[conXzUniZone.IdSchool] == DBNull.Value ? null : objRow[conXzUniZone.IdSchool].ToString().Trim(); //学校流水号
objXzUniZoneEN.IdUni = objRow[conXzUniZone.IdUni] == DBNull.Value ? null : objRow[conXzUniZone.IdUni].ToString().Trim(); //id_Uni
objXzUniZoneEN.ModifyUserId = objRow[conXzUniZone.ModifyUserId] == DBNull.Value ? null : objRow[conXzUniZone.ModifyUserId].ToString().Trim(); //修改人
objXzUniZoneEN.ModifyDate = objRow[conXzUniZone.ModifyDate] == DBNull.Value ? null : objRow[conXzUniZone.ModifyDate].ToString().Trim(); //修改日期
objXzUniZoneEN.Memo = objRow[conXzUniZone.Memo] == DBNull.Value ? null : objRow[conXzUniZone.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objXzUniZoneEN.IdUniZone, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objXzUniZoneEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objXzUniZoneCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsXzUniZoneEN> GetSubObjLstCache(clsXzUniZoneEN objXzUniZoneCond)
{
List<clsXzUniZoneEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsXzUniZoneEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conXzUniZone.AttributeName)
{
if (objXzUniZoneCond.IsUpdated(strFldName) == false) continue;
if (objXzUniZoneCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objXzUniZoneCond[strFldName].ToString());
}
else
{
if (objXzUniZoneCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objXzUniZoneCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objXzUniZoneCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objXzUniZoneCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objXzUniZoneCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objXzUniZoneCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objXzUniZoneCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objXzUniZoneCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objXzUniZoneCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objXzUniZoneCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objXzUniZoneCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objXzUniZoneCond[strFldName]));
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
public static List<clsXzUniZoneEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsXzUniZoneEN> arrObjLst = new List<clsXzUniZoneEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsXzUniZoneEN objXzUniZoneEN = new clsXzUniZoneEN();
try
{
objXzUniZoneEN.IdUniZone = objRow[conXzUniZone.IdUniZone].ToString().Trim(); //校区流水号
objXzUniZoneEN.UniZoneID = objRow[conXzUniZone.UniZoneID] == DBNull.Value ? null : objRow[conXzUniZone.UniZoneID].ToString().Trim(); //校区编号
objXzUniZoneEN.UniZoneDesc = objRow[conXzUniZone.UniZoneDesc] == DBNull.Value ? null : objRow[conXzUniZone.UniZoneDesc].ToString().Trim(); //校区名称
objXzUniZoneEN.UniZoneDescA = objRow[conXzUniZone.UniZoneDescA] == DBNull.Value ? null : objRow[conXzUniZone.UniZoneDescA].ToString().Trim(); //UniZoneDescA
objXzUniZoneEN.IdSchool = objRow[conXzUniZone.IdSchool] == DBNull.Value ? null : objRow[conXzUniZone.IdSchool].ToString().Trim(); //学校流水号
objXzUniZoneEN.IdUni = objRow[conXzUniZone.IdUni] == DBNull.Value ? null : objRow[conXzUniZone.IdUni].ToString().Trim(); //id_Uni
objXzUniZoneEN.ModifyUserId = objRow[conXzUniZone.ModifyUserId] == DBNull.Value ? null : objRow[conXzUniZone.ModifyUserId].ToString().Trim(); //修改人
objXzUniZoneEN.ModifyDate = objRow[conXzUniZone.ModifyDate] == DBNull.Value ? null : objRow[conXzUniZone.ModifyDate].ToString().Trim(); //修改日期
objXzUniZoneEN.Memo = objRow[conXzUniZone.Memo] == DBNull.Value ? null : objRow[conXzUniZone.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objXzUniZoneEN.IdUniZone, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objXzUniZoneEN);
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
public static List<clsXzUniZoneEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsXzUniZoneEN> arrObjLst = new List<clsXzUniZoneEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsXzUniZoneEN objXzUniZoneEN = new clsXzUniZoneEN();
try
{
objXzUniZoneEN.IdUniZone = objRow[conXzUniZone.IdUniZone].ToString().Trim(); //校区流水号
objXzUniZoneEN.UniZoneID = objRow[conXzUniZone.UniZoneID] == DBNull.Value ? null : objRow[conXzUniZone.UniZoneID].ToString().Trim(); //校区编号
objXzUniZoneEN.UniZoneDesc = objRow[conXzUniZone.UniZoneDesc] == DBNull.Value ? null : objRow[conXzUniZone.UniZoneDesc].ToString().Trim(); //校区名称
objXzUniZoneEN.UniZoneDescA = objRow[conXzUniZone.UniZoneDescA] == DBNull.Value ? null : objRow[conXzUniZone.UniZoneDescA].ToString().Trim(); //UniZoneDescA
objXzUniZoneEN.IdSchool = objRow[conXzUniZone.IdSchool] == DBNull.Value ? null : objRow[conXzUniZone.IdSchool].ToString().Trim(); //学校流水号
objXzUniZoneEN.IdUni = objRow[conXzUniZone.IdUni] == DBNull.Value ? null : objRow[conXzUniZone.IdUni].ToString().Trim(); //id_Uni
objXzUniZoneEN.ModifyUserId = objRow[conXzUniZone.ModifyUserId] == DBNull.Value ? null : objRow[conXzUniZone.ModifyUserId].ToString().Trim(); //修改人
objXzUniZoneEN.ModifyDate = objRow[conXzUniZone.ModifyDate] == DBNull.Value ? null : objRow[conXzUniZone.ModifyDate].ToString().Trim(); //修改日期
objXzUniZoneEN.Memo = objRow[conXzUniZone.Memo] == DBNull.Value ? null : objRow[conXzUniZone.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objXzUniZoneEN.IdUniZone, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objXzUniZoneEN);
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
List<clsXzUniZoneEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsXzUniZoneEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsXzUniZoneEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsXzUniZoneEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsXzUniZoneEN> arrObjLst = new List<clsXzUniZoneEN>(); 
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
	clsXzUniZoneEN objXzUniZoneEN = new clsXzUniZoneEN();
try
{
objXzUniZoneEN.IdUniZone = objRow[conXzUniZone.IdUniZone].ToString().Trim(); //校区流水号
objXzUniZoneEN.UniZoneID = objRow[conXzUniZone.UniZoneID] == DBNull.Value ? null : objRow[conXzUniZone.UniZoneID].ToString().Trim(); //校区编号
objXzUniZoneEN.UniZoneDesc = objRow[conXzUniZone.UniZoneDesc] == DBNull.Value ? null : objRow[conXzUniZone.UniZoneDesc].ToString().Trim(); //校区名称
objXzUniZoneEN.UniZoneDescA = objRow[conXzUniZone.UniZoneDescA] == DBNull.Value ? null : objRow[conXzUniZone.UniZoneDescA].ToString().Trim(); //UniZoneDescA
objXzUniZoneEN.IdSchool = objRow[conXzUniZone.IdSchool] == DBNull.Value ? null : objRow[conXzUniZone.IdSchool].ToString().Trim(); //学校流水号
objXzUniZoneEN.IdUni = objRow[conXzUniZone.IdUni] == DBNull.Value ? null : objRow[conXzUniZone.IdUni].ToString().Trim(); //id_Uni
objXzUniZoneEN.ModifyUserId = objRow[conXzUniZone.ModifyUserId] == DBNull.Value ? null : objRow[conXzUniZone.ModifyUserId].ToString().Trim(); //修改人
objXzUniZoneEN.ModifyDate = objRow[conXzUniZone.ModifyDate] == DBNull.Value ? null : objRow[conXzUniZone.ModifyDate].ToString().Trim(); //修改日期
objXzUniZoneEN.Memo = objRow[conXzUniZone.Memo] == DBNull.Value ? null : objRow[conXzUniZone.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objXzUniZoneEN.IdUniZone, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objXzUniZoneEN);
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
public static List<clsXzUniZoneEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsXzUniZoneEN> arrObjLst = new List<clsXzUniZoneEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsXzUniZoneEN objXzUniZoneEN = new clsXzUniZoneEN();
try
{
objXzUniZoneEN.IdUniZone = objRow[conXzUniZone.IdUniZone].ToString().Trim(); //校区流水号
objXzUniZoneEN.UniZoneID = objRow[conXzUniZone.UniZoneID] == DBNull.Value ? null : objRow[conXzUniZone.UniZoneID].ToString().Trim(); //校区编号
objXzUniZoneEN.UniZoneDesc = objRow[conXzUniZone.UniZoneDesc] == DBNull.Value ? null : objRow[conXzUniZone.UniZoneDesc].ToString().Trim(); //校区名称
objXzUniZoneEN.UniZoneDescA = objRow[conXzUniZone.UniZoneDescA] == DBNull.Value ? null : objRow[conXzUniZone.UniZoneDescA].ToString().Trim(); //UniZoneDescA
objXzUniZoneEN.IdSchool = objRow[conXzUniZone.IdSchool] == DBNull.Value ? null : objRow[conXzUniZone.IdSchool].ToString().Trim(); //学校流水号
objXzUniZoneEN.IdUni = objRow[conXzUniZone.IdUni] == DBNull.Value ? null : objRow[conXzUniZone.IdUni].ToString().Trim(); //id_Uni
objXzUniZoneEN.ModifyUserId = objRow[conXzUniZone.ModifyUserId] == DBNull.Value ? null : objRow[conXzUniZone.ModifyUserId].ToString().Trim(); //修改人
objXzUniZoneEN.ModifyDate = objRow[conXzUniZone.ModifyDate] == DBNull.Value ? null : objRow[conXzUniZone.ModifyDate].ToString().Trim(); //修改日期
objXzUniZoneEN.Memo = objRow[conXzUniZone.Memo] == DBNull.Value ? null : objRow[conXzUniZone.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objXzUniZoneEN.IdUniZone, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objXzUniZoneEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsXzUniZoneEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsXzUniZoneEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsXzUniZoneEN> arrObjLst = new List<clsXzUniZoneEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsXzUniZoneEN objXzUniZoneEN = new clsXzUniZoneEN();
try
{
objXzUniZoneEN.IdUniZone = objRow[conXzUniZone.IdUniZone].ToString().Trim(); //校区流水号
objXzUniZoneEN.UniZoneID = objRow[conXzUniZone.UniZoneID] == DBNull.Value ? null : objRow[conXzUniZone.UniZoneID].ToString().Trim(); //校区编号
objXzUniZoneEN.UniZoneDesc = objRow[conXzUniZone.UniZoneDesc] == DBNull.Value ? null : objRow[conXzUniZone.UniZoneDesc].ToString().Trim(); //校区名称
objXzUniZoneEN.UniZoneDescA = objRow[conXzUniZone.UniZoneDescA] == DBNull.Value ? null : objRow[conXzUniZone.UniZoneDescA].ToString().Trim(); //UniZoneDescA
objXzUniZoneEN.IdSchool = objRow[conXzUniZone.IdSchool] == DBNull.Value ? null : objRow[conXzUniZone.IdSchool].ToString().Trim(); //学校流水号
objXzUniZoneEN.IdUni = objRow[conXzUniZone.IdUni] == DBNull.Value ? null : objRow[conXzUniZone.IdUni].ToString().Trim(); //id_Uni
objXzUniZoneEN.ModifyUserId = objRow[conXzUniZone.ModifyUserId] == DBNull.Value ? null : objRow[conXzUniZone.ModifyUserId].ToString().Trim(); //修改人
objXzUniZoneEN.ModifyDate = objRow[conXzUniZone.ModifyDate] == DBNull.Value ? null : objRow[conXzUniZone.ModifyDate].ToString().Trim(); //修改日期
objXzUniZoneEN.Memo = objRow[conXzUniZone.Memo] == DBNull.Value ? null : objRow[conXzUniZone.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objXzUniZoneEN.IdUniZone, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objXzUniZoneEN);
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
public static List<clsXzUniZoneEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsXzUniZoneEN> arrObjLst = new List<clsXzUniZoneEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsXzUniZoneEN objXzUniZoneEN = new clsXzUniZoneEN();
try
{
objXzUniZoneEN.IdUniZone = objRow[conXzUniZone.IdUniZone].ToString().Trim(); //校区流水号
objXzUniZoneEN.UniZoneID = objRow[conXzUniZone.UniZoneID] == DBNull.Value ? null : objRow[conXzUniZone.UniZoneID].ToString().Trim(); //校区编号
objXzUniZoneEN.UniZoneDesc = objRow[conXzUniZone.UniZoneDesc] == DBNull.Value ? null : objRow[conXzUniZone.UniZoneDesc].ToString().Trim(); //校区名称
objXzUniZoneEN.UniZoneDescA = objRow[conXzUniZone.UniZoneDescA] == DBNull.Value ? null : objRow[conXzUniZone.UniZoneDescA].ToString().Trim(); //UniZoneDescA
objXzUniZoneEN.IdSchool = objRow[conXzUniZone.IdSchool] == DBNull.Value ? null : objRow[conXzUniZone.IdSchool].ToString().Trim(); //学校流水号
objXzUniZoneEN.IdUni = objRow[conXzUniZone.IdUni] == DBNull.Value ? null : objRow[conXzUniZone.IdUni].ToString().Trim(); //id_Uni
objXzUniZoneEN.ModifyUserId = objRow[conXzUniZone.ModifyUserId] == DBNull.Value ? null : objRow[conXzUniZone.ModifyUserId].ToString().Trim(); //修改人
objXzUniZoneEN.ModifyDate = objRow[conXzUniZone.ModifyDate] == DBNull.Value ? null : objRow[conXzUniZone.ModifyDate].ToString().Trim(); //修改日期
objXzUniZoneEN.Memo = objRow[conXzUniZone.Memo] == DBNull.Value ? null : objRow[conXzUniZone.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objXzUniZoneEN.IdUniZone, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objXzUniZoneEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsXzUniZoneEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsXzUniZoneEN> arrObjLst = new List<clsXzUniZoneEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsXzUniZoneEN objXzUniZoneEN = new clsXzUniZoneEN();
try
{
objXzUniZoneEN.IdUniZone = objRow[conXzUniZone.IdUniZone].ToString().Trim(); //校区流水号
objXzUniZoneEN.UniZoneID = objRow[conXzUniZone.UniZoneID] == DBNull.Value ? null : objRow[conXzUniZone.UniZoneID].ToString().Trim(); //校区编号
objXzUniZoneEN.UniZoneDesc = objRow[conXzUniZone.UniZoneDesc] == DBNull.Value ? null : objRow[conXzUniZone.UniZoneDesc].ToString().Trim(); //校区名称
objXzUniZoneEN.UniZoneDescA = objRow[conXzUniZone.UniZoneDescA] == DBNull.Value ? null : objRow[conXzUniZone.UniZoneDescA].ToString().Trim(); //UniZoneDescA
objXzUniZoneEN.IdSchool = objRow[conXzUniZone.IdSchool] == DBNull.Value ? null : objRow[conXzUniZone.IdSchool].ToString().Trim(); //学校流水号
objXzUniZoneEN.IdUni = objRow[conXzUniZone.IdUni] == DBNull.Value ? null : objRow[conXzUniZone.IdUni].ToString().Trim(); //id_Uni
objXzUniZoneEN.ModifyUserId = objRow[conXzUniZone.ModifyUserId] == DBNull.Value ? null : objRow[conXzUniZone.ModifyUserId].ToString().Trim(); //修改人
objXzUniZoneEN.ModifyDate = objRow[conXzUniZone.ModifyDate] == DBNull.Value ? null : objRow[conXzUniZone.ModifyDate].ToString().Trim(); //修改日期
objXzUniZoneEN.Memo = objRow[conXzUniZone.Memo] == DBNull.Value ? null : objRow[conXzUniZone.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objXzUniZoneEN.IdUniZone, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objXzUniZoneEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objXzUniZoneEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetXzUniZone(ref clsXzUniZoneEN objXzUniZoneEN)
{
bool bolResult = XzUniZoneDA.GetXzUniZone(ref objXzUniZoneEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "strIdUniZone">表关键字</param>
 /// <returns>表对象</returns>
public static clsXzUniZoneEN GetObjByIdUniZone(string strIdUniZone)
{
if (strIdUniZone.IndexOf(' ') >=0)
{
var strMsg = string.Format("(errid:Busi000079)在表中,关键字[strIdUniZone]中不能有空格!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
if (string.IsNullOrEmpty(strIdUniZone) == true)
{
var strMsg = string.Format("(errid:Busi000020)在表中,关键字[strIdUniZone]不能为空!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
clsXzUniZoneEN objXzUniZoneEN = XzUniZoneDA.GetObjByIdUniZone(strIdUniZone);
return objXzUniZoneEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsXzUniZoneEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsXzUniZoneEN objXzUniZoneEN = XzUniZoneDA.GetFirstObj(strWhereCond);
 return objXzUniZoneEN;
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
public static clsXzUniZoneEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsXzUniZoneEN objXzUniZoneEN = XzUniZoneDA.GetObjByDataRow(objRow);
 return objXzUniZoneEN;
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
public static clsXzUniZoneEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsXzUniZoneEN objXzUniZoneEN = XzUniZoneDA.GetObjByDataRow(objRow);
 return objXzUniZoneEN;
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
 /// <param name = "strIdUniZone">所给的关键字</param>
 /// <param name = "lstXzUniZoneObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsXzUniZoneEN GetObjByIdUniZoneFromList(string strIdUniZone, List<clsXzUniZoneEN> lstXzUniZoneObjLst)
{
foreach (clsXzUniZoneEN objXzUniZoneEN in lstXzUniZoneObjLst)
{
if (objXzUniZoneEN.IdUniZone == strIdUniZone)
{
return objXzUniZoneEN;
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
 string strIdUniZone;
 try
 {
 strIdUniZone = new clsXzUniZoneDA().GetFirstID(strWhereCond);
 return strIdUniZone;
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
 arrList = XzUniZoneDA.GetID(strWhereCond);
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
bool bolIsExist = XzUniZoneDA.IsExistCondRec(strWhereCond);
return bolIsExist;
}

 /// <summary>
 /// 判断当前表中是否存在给定关键字值的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExist)
 /// </summary>
 /// <param name = "strIdUniZone">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public static bool IsExist(string strIdUniZone)
{
if (string.IsNullOrEmpty(strIdUniZone) == true)
{
var strMsg = string.Format("(errid:Busi000027)在表中,关键字[strIdUniZone]不能为空!!(from {0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
//检测记录是否存在
bool bolIsExist = XzUniZoneDA.IsExist(strIdUniZone);
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
 bolIsExist = clsXzUniZoneDA.IsExistTable();
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
 bolIsExist = XzUniZoneDA.IsExistTable(strTabName);
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
 /// <param name = "objXzUniZoneEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecordBySql2(clsXzUniZoneEN objXzUniZoneEN, bool bolIsNeedCheckUniqueness=true)
{
 if (string.IsNullOrEmpty(objXzUniZoneEN.IdUniZone) == true)
 {
string strMsg = string.Format("添加记录时,关键字不能为空!(from {0})\r\n", 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
 if (clsXzUniZoneBL.IsExist(objXzUniZoneEN.IdUniZone) == true)
 {
string strMsg = string.Format("添加记录时,关键字:[{0}]已经存在!(from {1})\r\n", objXzUniZoneEN.IdUniZone, 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
try
{
bool bolResult = XzUniZoneDA.AddNewRecordBySQL2(objXzUniZoneEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsXzUniZoneBL.ReFreshCache();

if (clsXzUniZoneBL.relatedActions != null)
{
clsXzUniZoneBL.relatedActions.UpdRelaTabDate(objXzUniZoneEN.IdUniZone, "SetUpdDate");
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
 /// <param name = "objXzUniZoneEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordBySql2WithReturnKey(clsXzUniZoneEN objXzUniZoneEN, bool bolIsNeedCheckUniqueness=true)
{
 if (string.IsNullOrEmpty(objXzUniZoneEN.IdUniZone) == true)
 {
string strMsg = string.Format("添加记录时,关键字不能为空!(from {{0}})", 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
 if (clsXzUniZoneBL.IsExist(objXzUniZoneEN.IdUniZone) == true)
 {
string strMsg = string.Format("添加记录时,关键字:[{0}]已经存在!(from {1})\r\n", objXzUniZoneEN.IdUniZone, 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
try
{
string strKey = XzUniZoneDA.AddNewRecordBySQL2WithReturnKey(objXzUniZoneEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsXzUniZoneBL.ReFreshCache();

if (clsXzUniZoneBL.relatedActions != null)
{
clsXzUniZoneBL.relatedActions.UpdRelaTabDate(objXzUniZoneEN.IdUniZone, "SetUpdDate");
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
 /// <param name = "objXzUniZoneEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(clsXzUniZoneEN objXzUniZoneEN)
{
try
{
bool bolResult = XzUniZoneDA.Update(objXzUniZoneEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsXzUniZoneBL.ReFreshCache();

if (clsXzUniZoneBL.relatedActions != null)
{
clsXzUniZoneBL.relatedActions.UpdRelaTabDate(objXzUniZoneEN.IdUniZone, "SetUpdDate");
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
 /// <param name = "objXzUniZoneEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateBySql2(clsXzUniZoneEN objXzUniZoneEN)
{
 if (string.IsNullOrEmpty(objXzUniZoneEN.IdUniZone) == true)
 {
var strMsg = string.Format("(errid:Busi000065)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = XzUniZoneDA.UpdateBySql2(objXzUniZoneEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsXzUniZoneBL.ReFreshCache();

if (clsXzUniZoneBL.relatedActions != null)
{
clsXzUniZoneBL.relatedActions.UpdRelaTabDate(objXzUniZoneEN.IdUniZone, "SetUpdDate");
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
 /// <param name = "strIdUniZone">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int DelRecord(string strIdUniZone)
{
try
{
 clsXzUniZoneEN objXzUniZoneEN = clsXzUniZoneBL.GetObjByIdUniZone(strIdUniZone);

if (clsXzUniZoneBL.relatedActions != null)
{
clsXzUniZoneBL.relatedActions.UpdRelaTabDate(objXzUniZoneEN.IdUniZone, "SetUpdDate");
}
if (objXzUniZoneEN != null)
{
int intRecNum = XzUniZoneDA.DelRecord(strIdUniZone);
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
/// <param name="strIdUniZone">表关键字</param>
/// <returns></returns>
public static bool DelRecordEx(string strIdUniZone )
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsXzUniZoneDA.GetSpecSQLObj();
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
//删除与表:[XzUniZone]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conXzUniZone.IdUniZone,
//strIdUniZone);
//        clsXzUniZoneBL.DelXzUniZonesByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsXzUniZoneBL.DelRecord(strIdUniZone, objConnection, objSqlTransaction);
objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsXzUniZoneBLEx", "DelRecordEx", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("扩展删除记录出错:{0}!keyId = {1}.({2})",
objException.Message,
strIdUniZone, clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "strIdUniZone">给定的关键字值</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回删除是否成功?</returns>
public static bool DelRecord(string strIdUniZone, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
if (clsXzUniZoneBL.relatedActions != null)
{
clsXzUniZoneBL.relatedActions.UpdRelaTabDate(strIdUniZone, "UpdRelaTabDate");
}
bool bolResult = XzUniZoneDA.DelRecord(strIdUniZone,objSqlConnection,objSqlTransaction);
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
 /// <param name = "arrIdUniZoneLst">给定的关键字值列表</param>
 /// <returns>返回删除的记录数</returns>
public static int DelXzUniZones(List<string> arrIdUniZoneLst)
{
if (arrIdUniZoneLst.Count == 0) return 0;
try
{
if (clsXzUniZoneBL.relatedActions != null)
{
foreach (var strIdUniZone in arrIdUniZoneLst)
{
clsXzUniZoneBL.relatedActions.UpdRelaTabDate(strIdUniZone, "UpdRelaTabDate");
}
}
int intDelRecNum = XzUniZoneDA.DelXzUniZone(arrIdUniZoneLst);
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
public static int DelXzUniZonesByCond(string strWhereCond)
{
try
{
if (clsXzUniZoneBL.relatedActions != null)
{
List<string> arrIdUniZone = GetPrimaryKeyID_S(strWhereCond);
foreach (var strIdUniZone in arrIdUniZone)
{
clsXzUniZoneBL.relatedActions.UpdRelaTabDate(strIdUniZone, "UpdRelaTabDate");
}
}
int intRecNum = XzUniZoneDA.DelXzUniZone(strWhereCond);
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
/// 这里仅仅是演示函数,使用时请复制到扩展类:[XzUniZone]中改名为:[DelRecord4MultiTabEx]使用
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DelRecord4MultiTab)
/// </summary>
/// <param name="strIdUniZone">表关键字</param>
/// <returns></returns>
public static bool DelRecord4MultiTab(string strIdUniZone)
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsXzUniZoneDA.GetSpecSQLObj();
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
//删除与表:[XzUniZone]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conStudent.id_College,
//strid_College);
//        clsStudentBL.DelStudentsByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsXzUniZoneBL.DelRecord(strIdUniZone, objConnection, objSqlTransaction);
                objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsXzUniZoneBL", "DelRecord4MultiTab", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("删除多表记录出错:{0}!keyId = {1}.({2})",
objException.Message,
strIdUniZone, clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "objXzUniZoneENS">源对象</param>
 /// <param name = "objXzUniZoneENT">目标对象</param>
 public static void CopyTo(clsXzUniZoneEN objXzUniZoneENS, clsXzUniZoneEN objXzUniZoneENT)
{
try
{
objXzUniZoneENT.IdUniZone = objXzUniZoneENS.IdUniZone; //校区流水号
objXzUniZoneENT.UniZoneID = objXzUniZoneENS.UniZoneID; //校区编号
objXzUniZoneENT.UniZoneDesc = objXzUniZoneENS.UniZoneDesc; //校区名称
objXzUniZoneENT.UniZoneDescA = objXzUniZoneENS.UniZoneDescA; //UniZoneDescA
objXzUniZoneENT.IdSchool = objXzUniZoneENS.IdSchool; //学校流水号
objXzUniZoneENT.IdUni = objXzUniZoneENS.IdUni; //id_Uni
objXzUniZoneENT.ModifyUserId = objXzUniZoneENS.ModifyUserId; //修改人
objXzUniZoneENT.ModifyDate = objXzUniZoneENS.ModifyDate; //修改日期
objXzUniZoneENT.Memo = objXzUniZoneENS.Memo; //备注
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
 /// <param name = "objXzUniZoneEN">源简化对象</param>
 public static void SetUpdFlag(clsXzUniZoneEN objXzUniZoneEN)
{
try
{
objXzUniZoneEN.ClearUpdateState();
   string strsfUpdFldSetStr = objXzUniZoneEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(conXzUniZone.IdUniZone, new clsStrCompareIgnoreCase())  ==  true)
{
objXzUniZoneEN.IdUniZone = objXzUniZoneEN.IdUniZone; //校区流水号
}
if (arrFldSet.Contains(conXzUniZone.UniZoneID, new clsStrCompareIgnoreCase())  ==  true)
{
objXzUniZoneEN.UniZoneID = objXzUniZoneEN.UniZoneID == "[null]" ? null :  objXzUniZoneEN.UniZoneID; //校区编号
}
if (arrFldSet.Contains(conXzUniZone.UniZoneDesc, new clsStrCompareIgnoreCase())  ==  true)
{
objXzUniZoneEN.UniZoneDesc = objXzUniZoneEN.UniZoneDesc == "[null]" ? null :  objXzUniZoneEN.UniZoneDesc; //校区名称
}
if (arrFldSet.Contains(conXzUniZone.UniZoneDescA, new clsStrCompareIgnoreCase())  ==  true)
{
objXzUniZoneEN.UniZoneDescA = objXzUniZoneEN.UniZoneDescA == "[null]" ? null :  objXzUniZoneEN.UniZoneDescA; //UniZoneDescA
}
if (arrFldSet.Contains(conXzUniZone.IdSchool, new clsStrCompareIgnoreCase())  ==  true)
{
objXzUniZoneEN.IdSchool = objXzUniZoneEN.IdSchool == "[null]" ? null :  objXzUniZoneEN.IdSchool; //学校流水号
}
if (arrFldSet.Contains(conXzUniZone.IdUni, new clsStrCompareIgnoreCase())  ==  true)
{
objXzUniZoneEN.IdUni = objXzUniZoneEN.IdUni == "[null]" ? null :  objXzUniZoneEN.IdUni; //id_Uni
}
if (arrFldSet.Contains(conXzUniZone.ModifyUserId, new clsStrCompareIgnoreCase())  ==  true)
{
objXzUniZoneEN.ModifyUserId = objXzUniZoneEN.ModifyUserId == "[null]" ? null :  objXzUniZoneEN.ModifyUserId; //修改人
}
if (arrFldSet.Contains(conXzUniZone.ModifyDate, new clsStrCompareIgnoreCase())  ==  true)
{
objXzUniZoneEN.ModifyDate = objXzUniZoneEN.ModifyDate == "[null]" ? null :  objXzUniZoneEN.ModifyDate; //修改日期
}
if (arrFldSet.Contains(conXzUniZone.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objXzUniZoneEN.Memo = objXzUniZoneEN.Memo == "[null]" ? null :  objXzUniZoneEN.Memo; //备注
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
 /// <param name = "objXzUniZoneEN">源简化对象</param>
 public static void AccessFldValueNull(clsXzUniZoneEN objXzUniZoneEN)
{
try
{
if (objXzUniZoneEN.UniZoneID == "[null]") objXzUniZoneEN.UniZoneID = null; //校区编号
if (objXzUniZoneEN.UniZoneDesc == "[null]") objXzUniZoneEN.UniZoneDesc = null; //校区名称
if (objXzUniZoneEN.UniZoneDescA == "[null]") objXzUniZoneEN.UniZoneDescA = null; //UniZoneDescA
if (objXzUniZoneEN.IdSchool == "[null]") objXzUniZoneEN.IdSchool = null; //学校流水号
if (objXzUniZoneEN.IdUni == "[null]") objXzUniZoneEN.IdUni = null; //id_Uni
if (objXzUniZoneEN.ModifyUserId == "[null]") objXzUniZoneEN.ModifyUserId = null; //修改人
if (objXzUniZoneEN.ModifyDate == "[null]") objXzUniZoneEN.ModifyDate = null; //修改日期
if (objXzUniZoneEN.Memo == "[null]") objXzUniZoneEN.Memo = null; //备注
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
public static void CheckPropertyNew(clsXzUniZoneEN objXzUniZoneEN)
{
 XzUniZoneDA.CheckPropertyNew(objXzUniZoneEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(clsXzUniZoneEN objXzUniZoneEN)
{
 XzUniZoneDA.CheckProperty4Condition(objXzUniZoneEN);
 }


 #endregion 检查对象属性


 #region 绑定下拉框

 /// <summary>
 /// 绑定基于Win的下拉框
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_TabFeature_ComboBoxBindFunction)
 /// </summary>
 /// <param name = "objComboBox">需要绑定当前表的下拉框</param>

public static void BindCbo_IdUniZone(System.Windows.Forms.ComboBox objComboBox )
{
//为数据源为表的下拉框设置内容
string strCondition = string.Format("1 =1 Order By {0}", conXzUniZone.IdUniZone); 
List<clsXzUniZoneEN> arrObjLst = clsXzUniZoneBL.GetObjLst(strCondition);
//初始化一个对象列表
//插入第0项。在第0项中插入“请选择...”,为了方便用户,与WEB方式类似。
clsXzUniZoneEN objXzUniZoneEN = new clsXzUniZoneEN()
{
IdUniZone = "0",
UniZoneDesc = "选[校区]..."
};
arrObjLst.Insert(0, objXzUniZoneEN);
//设置下拉框的数据源、以及设置值项、显示项
objComboBox.ValueMember = conXzUniZone.IdUniZone;
objComboBox.DisplayMember = conXzUniZone.UniZoneDesc;
objComboBox.DataSource = arrObjLst;
objComboBox.SelectedIndex = 0;
}

 /// <summary>
 /// 绑定基于Web的下拉框
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_TabFeature_DdlBindFunction)
 /// </summary>
 /// <param name = "objDDL">需要绑定当前表的下拉框</param>

public static void BindDdl_IdUniZone(System.Web.UI.WebControls.DropDownList objDDL )
{
//为数据源于表的下拉框设置内容
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[校区]...","0");
string strCondition = string.Format("1 =1 Order By {0}", conXzUniZone.IdUniZone); 
IEnumerable<clsXzUniZoneEN> arrObjLst = clsXzUniZoneBL.GetObjLst(strCondition);
objDDL.DataValueField = conXzUniZone.IdUniZone;
objDDL.DataTextField = conXzUniZone.UniZoneDesc;
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
public static void BindDdl_IdUniZoneCache(System.Web.UI.WebControls.DropDownList objDDL)
{
//为数据源于表的下拉框设置内容
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[校区]...","0");
List<clsXzUniZoneEN> arrXzUniZoneObjLst = GetAllXzUniZoneObjLstCache(); 
objDDL.DataValueField = conXzUniZone.IdUniZone;
objDDL.DataTextField = conXzUniZone.UniZoneDesc;
objDDL.DataSource = arrXzUniZoneObjLst;
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
if (clsXzUniZoneBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsXzUniZoneBL没有刷新缓存机制(clsXzUniZoneBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by IdUniZone");
//if (arrXzUniZoneObjLstCache == null)
//{
//arrXzUniZoneObjLstCache = XzUniZoneDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "strIdUniZone">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsXzUniZoneEN GetObjByIdUniZoneCache(string strIdUniZone)
{
//获取缓存中的对象列表
string strKey = string.Format("{0}", clsXzUniZoneEN._CurrTabName);
List<clsXzUniZoneEN> arrXzUniZoneObjLstCache = GetObjLstCache();
IEnumerable <clsXzUniZoneEN> arrXzUniZoneObjLst_Sel =
arrXzUniZoneObjLstCache
.Where(x=> x.IdUniZone == strIdUniZone 
);
if (arrXzUniZoneObjLst_Sel.Count() == 0)
{
   clsXzUniZoneEN obj = clsXzUniZoneBL.GetObjByIdUniZone(strIdUniZone);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
 }
return null;
}
return arrXzUniZoneObjLst_Sel.First();
}

 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecNameByKeyCache)
 /// </summary>
 /// <param name = "strIdUniZone">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetUniZoneDescByIdUniZoneCache(string strIdUniZone)
{
if (string.IsNullOrEmpty(strIdUniZone) == true) return "";
//获取缓存中的对象列表
clsXzUniZoneEN objXzUniZone = GetObjByIdUniZoneCache(strIdUniZone);
if (objXzUniZone == null) return "";
return objXzUniZone.UniZoneDesc;
}
 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecNameByKeyCache)
 /// </summary>
 /// <param name = "strIdUniZone">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetNameByIdUniZoneCache(string strIdUniZone)
{
if (string.IsNullOrEmpty(strIdUniZone) == true) return "";
//获取缓存中的对象列表
clsXzUniZoneEN objXzUniZone = GetObjByIdUniZoneCache(strIdUniZone);
if (objXzUniZone == null) return "";
return objXzUniZone.UniZoneDesc;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsXzUniZoneEN> GetAllXzUniZoneObjLstCache()
{
//获取缓存中的对象列表
List<clsXzUniZoneEN> arrXzUniZoneObjLstCache = GetObjLstCache(); 
return arrXzUniZoneObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsXzUniZoneEN> GetObjLstCache()
{
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}", clsXzUniZoneEN._CurrTabName);
List<clsXzUniZoneEN> arrXzUniZoneObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrXzUniZoneObjLstCache;
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
string strKey = string.Format("{0}", clsXzUniZoneEN._CurrTabName);
CacheHelper.Remove(strKey);
clsXzUniZoneEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
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
if (clsXzUniZoneEN._RefreshTimeLst.Count == 0) return "";
return clsXzUniZoneEN._RefreshTimeLst[clsXzUniZoneEN._RefreshTimeLst.Count - 1];
}

 /// <summary>
 /// 刷新缓存.把当前表的缓存以及该表相关视图的缓存清空.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ReFreshCache)
 /// </summary>
public static void ReFreshCache()
{
if (clsXzUniZoneBL.objCommFun4BL != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}", clsXzUniZoneEN._CurrTabName);
CacheHelper.Remove(strKey);
clsXzUniZoneEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
clsXzUniZoneBL.objCommFun4BL.ReFreshCache();
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
public static string Func(string strInFldName, string strOutFldName, string strIdUniZone)
{
if (strInFldName != conXzUniZone.IdUniZone)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (conXzUniZone.AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", conXzUniZone.AttributeName));
throw new Exception(strMsg);
}
var objXzUniZone = clsXzUniZoneBL.GetObjByIdUniZoneCache(strIdUniZone);
if (objXzUniZone == null) return "";
return objXzUniZone[strOutFldName].ToString();
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
int intRecCount = clsXzUniZoneDA.GetRecCount(strTabName);
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
int intRecCount = clsXzUniZoneDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsXzUniZoneDA.GetRecCount();
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
int intRecCount = clsXzUniZoneDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objXzUniZoneCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsXzUniZoneEN objXzUniZoneCond)
{
List<clsXzUniZoneEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsXzUniZoneEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conXzUniZone.AttributeName)
{
if (objXzUniZoneCond.IsUpdated(strFldName) == false) continue;
if (objXzUniZoneCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objXzUniZoneCond[strFldName].ToString());
}
else
{
if (objXzUniZoneCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objXzUniZoneCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objXzUniZoneCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objXzUniZoneCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objXzUniZoneCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objXzUniZoneCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objXzUniZoneCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objXzUniZoneCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objXzUniZoneCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objXzUniZoneCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objXzUniZoneCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objXzUniZoneCond[strFldName]));
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
 List<string> arrList = clsXzUniZoneDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = XzUniZoneDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = XzUniZoneDA.GetFldValueNoDistinct(strFldName, strWhereCond);
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
int intRecCount = XzUniZoneDA.SetFldValue(strFldName, strValue, strWhereCond);
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
int intRecCount = clsXzUniZoneDA.SetFldValue(clsXzUniZoneEN._CurrTabName, strFldName, fltValue, strWhereCond);
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
int intRecCount = XzUniZoneDA.SetFldValue( strFldName, intValue, strWhereCond);
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
int intRecCount = clsXzUniZoneDA.SetFldValue(strTabName, strFldName, strValue, strWhereCond);
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
int intRecCount = clsXzUniZoneDA.SetFldValue(strTabName, strFldName, intValue, strWhereCond);
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
int intRecCount = clsXzUniZoneDA.SetFldValue(strTabName, strFldName, fltValue, strWhereCond);
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
  strCreateTabCode.Append("CREATE table [dbo].[XzUniZone] "); 
 strCreateTabCode.Append(" ( "); 
 // /**校区流水号*/ 
 strCreateTabCode.Append(" IdUniZone char(4) primary key, "); 
 // /**校区编号*/ 
 strCreateTabCode.Append(" UniZoneID char(4) Null, "); 
 // /**校区名称*/ 
 strCreateTabCode.Append(" UniZoneDesc varchar(20) Null, "); 
 // /**UniZoneDescA*/ 
 strCreateTabCode.Append(" UniZoneDescA varchar(20) Null, "); 
 // /**学校流水号*/ 
 strCreateTabCode.Append(" IdSchool char(4) Null, "); 
 // /**id_Uni*/ 
 strCreateTabCode.Append(" IdUni char(4) Null, "); 
 // /**修改人*/ 
 strCreateTabCode.Append(" ModifyUserId varchar(18) Null, "); 
 // /**修改日期*/ 
 strCreateTabCode.Append(" ModifyDate varchar(20) Null, "); 
 // /**备注*/ 
 strCreateTabCode.Append(" Memo varchar(1000) Null ");
 strCreateTabCode.Append(") "); 
  strCreateTabCode.Append("ON [PRIMARY] ");
  return strCreateTabCode.ToString();
}



 #endregion 表操作
}
 /// <summary>
 /// 校区(XzUniZone)
 /// 数据源类型:表
 /// (AutoGCLib.CommFun4BL4CSharp:GeneCode_This)
 /// </summary>
public class  clsCommFun4BL4XzUniZone : clsCommFun4BL
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
clsXzUniZoneBL.ReFreshThisCache();
}
}

}