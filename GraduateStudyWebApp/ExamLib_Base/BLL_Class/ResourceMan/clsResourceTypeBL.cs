
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsResourceTypeBL
 表名:ResourceType(01120089)
 * 版本:2024.11.13.1(服务器:WIN-SRV103-116)
 日期:2024/11/13 06:04:09
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:研究生学习游戏化后台(000055, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:资源管理(ResourceMan)
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
public static class  clsResourceTypeBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "strIdResourceType">表关键字</param>
 /// <returns>表对象</returns>
public static clsResourceTypeEN GetObj(this K_IdResourceType_ResourceType myKey)
{
clsResourceTypeEN objResourceTypeEN = clsResourceTypeBL.ResourceTypeDA.GetObjByIdResourceType(myKey.Value);
return objResourceTypeEN;
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_AddNewRecord)
 /// </summary>
 /// <param name = "objResourceTypeEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clsResourceTypeEN objResourceTypeEN, bool bolIsNeedCheckUniqueness = true)
{
 if (string.IsNullOrEmpty(objResourceTypeEN.IdResourceType) == true)
 {
string strMsg = string.Format("添加记录时,关键字不能为空!(from {0})\r\n", 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
 if (clsResourceTypeBL.IsExist(objResourceTypeEN.IdResourceType) == true)
 {
string strMsg = string.Format("添加记录时,关键字:[{0}]已经存在!(from {1})\r\n", objResourceTypeEN.IdResourceType, 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
try
{
bool bolResult = clsResourceTypeBL.ResourceTypeDA.AddNewRecordBySQL2(objResourceTypeEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsResourceTypeBL.ReFreshCache();

if (clsResourceTypeBL.relatedActions != null)
{
clsResourceTypeBL.relatedActions.UpdRelaTabDate(objResourceTypeEN.IdResourceType, "SetUpdDate");
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
public static bool AddRecordEx(this clsResourceTypeEN objResourceTypeEN, bool bolIsNeedCheckUniqueness = true)
{
//操作步骤:
//1、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在
//2、检查唯一性
//3、检查传进去的对象属性是否合法
//4、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
//1、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在
if (clsResourceTypeBL.IsExist(objResourceTypeEN.IdResourceType))	//判断是否有相同的关键字
{
strMsg = "(errid:Busi000151)关键字字段已有相同的值";
throw new Exception(strMsg);
}
try
{
 //2、检查传进去的对象属性是否合法
objResourceTypeEN.CheckPropertyNew();
//6、把数据实体层的数据存贮到数据库中
objResourceTypeEN.AddNewRecord();
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
 /// <param name = "objResourceTypeEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordWithReturnKey(this clsResourceTypeEN objResourceTypeEN, bool bolIsNeedCheckUniqueness = true)
{
 if (string.IsNullOrEmpty(objResourceTypeEN.IdResourceType) == true)
 {
string strMsg = string.Format("添加记录时,关键字不能为空!(from {{0}})", 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
 if (clsResourceTypeBL.IsExist(objResourceTypeEN.IdResourceType) == true)
 {
string strMsg = string.Format("添加记录时,关键字:[{0}]已经存在!(from {1})\r\n", objResourceTypeEN.IdResourceType, 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
try
{
string strKey = clsResourceTypeBL.ResourceTypeDA.AddNewRecordBySQL2WithReturnKey(objResourceTypeEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsResourceTypeBL.ReFreshCache();

if (clsResourceTypeBL.relatedActions != null)
{
clsResourceTypeBL.relatedActions.UpdRelaTabDate(objResourceTypeEN.IdResourceType, "SetUpdDate");
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
 /// <param name = "objResourceTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsResourceTypeEN SetIdResourceType(this clsResourceTypeEN objResourceTypeEN, string strIdResourceType, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdResourceType, 4, conResourceType.IdResourceType);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdResourceType, 4, conResourceType.IdResourceType);
}
objResourceTypeEN.IdResourceType = strIdResourceType; //资源类型流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objResourceTypeEN.dicFldComparisonOp.ContainsKey(conResourceType.IdResourceType) == false)
{
objResourceTypeEN.dicFldComparisonOp.Add(conResourceType.IdResourceType, strComparisonOp);
}
else
{
objResourceTypeEN.dicFldComparisonOp[conResourceType.IdResourceType] = strComparisonOp;
}
}
return objResourceTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objResourceTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsResourceTypeEN SetResourceTypeID(this clsResourceTypeEN objResourceTypeEN, string strResourceTypeID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strResourceTypeID, conResourceType.ResourceTypeID);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strResourceTypeID, 4, conResourceType.ResourceTypeID);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strResourceTypeID, 4, conResourceType.ResourceTypeID);
}
objResourceTypeEN.ResourceTypeID = strResourceTypeID; //资源类型ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objResourceTypeEN.dicFldComparisonOp.ContainsKey(conResourceType.ResourceTypeID) == false)
{
objResourceTypeEN.dicFldComparisonOp.Add(conResourceType.ResourceTypeID, strComparisonOp);
}
else
{
objResourceTypeEN.dicFldComparisonOp[conResourceType.ResourceTypeID] = strComparisonOp;
}
}
return objResourceTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objResourceTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsResourceTypeEN SetResourceTypeName(this clsResourceTypeEN objResourceTypeEN, string strResourceTypeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strResourceTypeName, conResourceType.ResourceTypeName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strResourceTypeName, 50, conResourceType.ResourceTypeName);
}
objResourceTypeEN.ResourceTypeName = strResourceTypeName; //资源类型名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objResourceTypeEN.dicFldComparisonOp.ContainsKey(conResourceType.ResourceTypeName) == false)
{
objResourceTypeEN.dicFldComparisonOp.Add(conResourceType.ResourceTypeName, strComparisonOp);
}
else
{
objResourceTypeEN.dicFldComparisonOp[conResourceType.ResourceTypeName] = strComparisonOp;
}
}
return objResourceTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objResourceTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsResourceTypeEN SetResourceTypeENName(this clsResourceTypeEN objResourceTypeEN, string strResourceTypeENName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strResourceTypeENName, 50, conResourceType.ResourceTypeENName);
}
objResourceTypeEN.ResourceTypeENName = strResourceTypeENName; //ResourceTypeENName
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objResourceTypeEN.dicFldComparisonOp.ContainsKey(conResourceType.ResourceTypeENName) == false)
{
objResourceTypeEN.dicFldComparisonOp.Add(conResourceType.ResourceTypeENName, strComparisonOp);
}
else
{
objResourceTypeEN.dicFldComparisonOp[conResourceType.ResourceTypeENName] = strComparisonOp;
}
}
return objResourceTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objResourceTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsResourceTypeEN SetFileExtentNameLst(this clsResourceTypeEN objResourceTypeEN, string strFileExtentNameLst, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFileExtentNameLst, 200, conResourceType.FileExtentNameLst);
}
objResourceTypeEN.FileExtentNameLst = strFileExtentNameLst; //文件扩展名列表
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objResourceTypeEN.dicFldComparisonOp.ContainsKey(conResourceType.FileExtentNameLst) == false)
{
objResourceTypeEN.dicFldComparisonOp.Add(conResourceType.FileExtentNameLst, strComparisonOp);
}
else
{
objResourceTypeEN.dicFldComparisonOp[conResourceType.FileExtentNameLst] = strComparisonOp;
}
}
return objResourceTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objResourceTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsResourceTypeEN SetFileExtentNameLst2(this clsResourceTypeEN objResourceTypeEN, string strFileExtentNameLst2, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFileExtentNameLst2, 200, conResourceType.FileExtentNameLst2);
}
objResourceTypeEN.FileExtentNameLst2 = strFileExtentNameLst2; //文件扩展名列表2
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objResourceTypeEN.dicFldComparisonOp.ContainsKey(conResourceType.FileExtentNameLst2) == false)
{
objResourceTypeEN.dicFldComparisonOp.Add(conResourceType.FileExtentNameLst2, strComparisonOp);
}
else
{
objResourceTypeEN.dicFldComparisonOp[conResourceType.FileExtentNameLst2] = strComparisonOp;
}
}
return objResourceTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objResourceTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsResourceTypeEN SetOrderNum(this clsResourceTypeEN objResourceTypeEN, int? intOrderNum, string strComparisonOp="")
	{
objResourceTypeEN.OrderNum = intOrderNum; //序号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objResourceTypeEN.dicFldComparisonOp.ContainsKey(conResourceType.OrderNum) == false)
{
objResourceTypeEN.dicFldComparisonOp.Add(conResourceType.OrderNum, strComparisonOp);
}
else
{
objResourceTypeEN.dicFldComparisonOp[conResourceType.OrderNum] = strComparisonOp;
}
}
return objResourceTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objResourceTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsResourceTypeEN SetIsUse(this clsResourceTypeEN objResourceTypeEN, bool bolIsUse, string strComparisonOp="")
	{
objResourceTypeEN.IsUse = bolIsUse; //是否使用
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objResourceTypeEN.dicFldComparisonOp.ContainsKey(conResourceType.IsUse) == false)
{
objResourceTypeEN.dicFldComparisonOp.Add(conResourceType.IsUse, strComparisonOp);
}
else
{
objResourceTypeEN.dicFldComparisonOp[conResourceType.IsUse] = strComparisonOp;
}
}
return objResourceTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objResourceTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsResourceTypeEN SetMemo(this clsResourceTypeEN objResourceTypeEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, conResourceType.Memo);
}
objResourceTypeEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objResourceTypeEN.dicFldComparisonOp.ContainsKey(conResourceType.Memo) == false)
{
objResourceTypeEN.dicFldComparisonOp.Add(conResourceType.Memo, strComparisonOp);
}
else
{
objResourceTypeEN.dicFldComparisonOp[conResourceType.Memo] = strComparisonOp;
}
}
return objResourceTypeEN;
	}

 /// <summary>
 /// 修改记录存盘到数据表中
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_UpdateRecordEx)
 /// </summary>
 /// <param name = "objResourceTypeEN">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool UpdateRecordEx(this clsResourceTypeEN objResourceTypeEN)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
try
{
//1、检查传进去的对象属性是否合法
objResourceTypeEN.CheckPropertyNew();
clsResourceTypeEN objResourceTypeCond = new clsResourceTypeEN();
string strCondition = objResourceTypeCond
.SetIdResourceType(objResourceTypeEN.IdResourceType, "=")
.GetCombineCondition();
objResourceTypeEN._IsCheckProperty = true;
bool bolIsExist = clsResourceTypeBL.IsExistRecord(strCondition);
if (bolIsExist)
{
strMsg = "()不能重复!";
throw new Exception(strMsg);
}
//4、把数据实体层的数据存贮到数据库中
objResourceTypeEN.Update();
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
 /// <param name = "objResourceTypeEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsResourceTypeEN objResourceTypeEN)
{
 if (string.IsNullOrEmpty(objResourceTypeEN.IdResourceType) == true)
 {
string strMsg = string.Format("(errid:Busi000095)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsResourceTypeBL.ResourceTypeDA.UpdateBySql2(objResourceTypeEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsResourceTypeBL.ReFreshCache();

if (clsResourceTypeBL.relatedActions != null)
{
clsResourceTypeBL.relatedActions.UpdRelaTabDate(objResourceTypeEN.IdResourceType, "SetUpdDate");
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
 /// <param name = "objResourceTypeEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsResourceTypeEN objResourceTypeEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (string.IsNullOrEmpty(objResourceTypeEN.IdResourceType) == true)
 {
string strMsg = string.Format("(errid:Busi000087)修改记录时关键字不能为空!(带事务处理)(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsResourceTypeBL.ResourceTypeDA.UpdateBySql2(objResourceTypeEN, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsResourceTypeBL.ReFreshCache();

if (clsResourceTypeBL.relatedActions != null)
{
clsResourceTypeBL.relatedActions.UpdRelaTabDate(objResourceTypeEN.IdResourceType, "SetUpdDate");
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
 /// <param name = "objResourceTypeEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsResourceTypeEN objResourceTypeEN, string strWhereCond)
{
try
{
bool bolResult = clsResourceTypeBL.ResourceTypeDA.UpdateBySqlWithCondition(objResourceTypeEN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsResourceTypeBL.ReFreshCache();

if (clsResourceTypeBL.relatedActions != null)
{
clsResourceTypeBL.relatedActions.UpdRelaTabDate(objResourceTypeEN.IdResourceType, "SetUpdDate");
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
 /// <param name = "objResourceTypeEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsResourceTypeEN objResourceTypeEN, string strWhereCond, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
bool bolResult = clsResourceTypeBL.ResourceTypeDA.UpdateBySqlWithConditionTransaction(objResourceTypeEN, strWhereCond, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsResourceTypeBL.ReFreshCache();

if (clsResourceTypeBL.relatedActions != null)
{
clsResourceTypeBL.relatedActions.UpdRelaTabDate(objResourceTypeEN.IdResourceType, "SetUpdDate");
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
 /// <param name = "strIdResourceType">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int Delete(this clsResourceTypeEN objResourceTypeEN)
{
try
{
int intRecNum = clsResourceTypeBL.ResourceTypeDA.DelRecord(objResourceTypeEN.IdResourceType);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsResourceTypeBL.ReFreshCache();

if (clsResourceTypeBL.relatedActions != null)
{
clsResourceTypeBL.relatedActions.UpdRelaTabDate(objResourceTypeEN.IdResourceType, "SetUpdDate");
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
 /// <param name = "objResourceTypeENS">源对象</param>
 /// <param name = "objResourceTypeENT">目标对象</param>
 public static void CopyTo(this clsResourceTypeEN objResourceTypeENS, clsResourceTypeEN objResourceTypeENT)
{
try
{
objResourceTypeENT.IdResourceType = objResourceTypeENS.IdResourceType; //资源类型流水号
objResourceTypeENT.ResourceTypeID = objResourceTypeENS.ResourceTypeID; //资源类型ID
objResourceTypeENT.ResourceTypeName = objResourceTypeENS.ResourceTypeName; //资源类型名称
objResourceTypeENT.ResourceTypeENName = objResourceTypeENS.ResourceTypeENName; //ResourceTypeENName
objResourceTypeENT.FileExtentNameLst = objResourceTypeENS.FileExtentNameLst; //文件扩展名列表
objResourceTypeENT.FileExtentNameLst2 = objResourceTypeENS.FileExtentNameLst2; //文件扩展名列表2
objResourceTypeENT.OrderNum = objResourceTypeENS.OrderNum; //序号
objResourceTypeENT.IsUse = objResourceTypeENS.IsUse; //是否使用
objResourceTypeENT.Memo = objResourceTypeENS.Memo; //备注
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
 /// <param name = "objResourceTypeENS">源对象</param>
 /// <returns>目标对象=>clsResourceTypeEN:objResourceTypeENT</returns>
 public static clsResourceTypeEN CopyTo(this clsResourceTypeEN objResourceTypeENS)
{
try
{
 clsResourceTypeEN objResourceTypeENT = new clsResourceTypeEN()
{
IdResourceType = objResourceTypeENS.IdResourceType, //资源类型流水号
ResourceTypeID = objResourceTypeENS.ResourceTypeID, //资源类型ID
ResourceTypeName = objResourceTypeENS.ResourceTypeName, //资源类型名称
ResourceTypeENName = objResourceTypeENS.ResourceTypeENName, //ResourceTypeENName
FileExtentNameLst = objResourceTypeENS.FileExtentNameLst, //文件扩展名列表
FileExtentNameLst2 = objResourceTypeENS.FileExtentNameLst2, //文件扩展名列表2
OrderNum = objResourceTypeENS.OrderNum, //序号
IsUse = objResourceTypeENS.IsUse, //是否使用
Memo = objResourceTypeENS.Memo, //备注
};
 return objResourceTypeENT;
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
public static void CheckPropertyNew(this clsResourceTypeEN objResourceTypeEN)
{
 clsResourceTypeBL.ResourceTypeDA.CheckPropertyNew(objResourceTypeEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(this clsResourceTypeEN objResourceTypeEN)
{
 clsResourceTypeBL.ResourceTypeDA.CheckProperty4Condition(objResourceTypeEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsResourceTypeEN objResourceTypeCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objResourceTypeCond.IsUpdated(conResourceType.IdResourceType) == true)
{
string strComparisonOpIdResourceType = objResourceTypeCond.dicFldComparisonOp[conResourceType.IdResourceType];
strWhereCond += string.Format(" And {0} {2} '{1}'", conResourceType.IdResourceType, objResourceTypeCond.IdResourceType, strComparisonOpIdResourceType);
}
if (objResourceTypeCond.IsUpdated(conResourceType.ResourceTypeID) == true)
{
string strComparisonOpResourceTypeID = objResourceTypeCond.dicFldComparisonOp[conResourceType.ResourceTypeID];
strWhereCond += string.Format(" And {0} {2} '{1}'", conResourceType.ResourceTypeID, objResourceTypeCond.ResourceTypeID, strComparisonOpResourceTypeID);
}
if (objResourceTypeCond.IsUpdated(conResourceType.ResourceTypeName) == true)
{
string strComparisonOpResourceTypeName = objResourceTypeCond.dicFldComparisonOp[conResourceType.ResourceTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", conResourceType.ResourceTypeName, objResourceTypeCond.ResourceTypeName, strComparisonOpResourceTypeName);
}
if (objResourceTypeCond.IsUpdated(conResourceType.ResourceTypeENName) == true)
{
string strComparisonOpResourceTypeENName = objResourceTypeCond.dicFldComparisonOp[conResourceType.ResourceTypeENName];
strWhereCond += string.Format(" And {0} {2} '{1}'", conResourceType.ResourceTypeENName, objResourceTypeCond.ResourceTypeENName, strComparisonOpResourceTypeENName);
}
if (objResourceTypeCond.IsUpdated(conResourceType.FileExtentNameLst) == true)
{
string strComparisonOpFileExtentNameLst = objResourceTypeCond.dicFldComparisonOp[conResourceType.FileExtentNameLst];
strWhereCond += string.Format(" And {0} {2} '{1}'", conResourceType.FileExtentNameLst, objResourceTypeCond.FileExtentNameLst, strComparisonOpFileExtentNameLst);
}
if (objResourceTypeCond.IsUpdated(conResourceType.FileExtentNameLst2) == true)
{
string strComparisonOpFileExtentNameLst2 = objResourceTypeCond.dicFldComparisonOp[conResourceType.FileExtentNameLst2];
strWhereCond += string.Format(" And {0} {2} '{1}'", conResourceType.FileExtentNameLst2, objResourceTypeCond.FileExtentNameLst2, strComparisonOpFileExtentNameLst2);
}
if (objResourceTypeCond.IsUpdated(conResourceType.OrderNum) == true)
{
string strComparisonOpOrderNum = objResourceTypeCond.dicFldComparisonOp[conResourceType.OrderNum];
strWhereCond += string.Format(" And {0} {2} {1}", conResourceType.OrderNum, objResourceTypeCond.OrderNum, strComparisonOpOrderNum);
}
if (objResourceTypeCond.IsUpdated(conResourceType.IsUse) == true)
{
if (objResourceTypeCond.IsUse == true)
{
strWhereCond += string.Format(" And {0} = '1'", conResourceType.IsUse);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conResourceType.IsUse);
}
}
if (objResourceTypeCond.IsUpdated(conResourceType.Memo) == true)
{
string strComparisonOpMemo = objResourceTypeCond.dicFldComparisonOp[conResourceType.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", conResourceType.Memo, objResourceTypeCond.Memo, strComparisonOpMemo);
}
 return strWhereCond;
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_ResourceType
{
public virtual bool UpdRelaTabDate(string strIdResourceType, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// 根据表内容设置enum列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GeneEnumConstList)
 /// </summary>
public class enumResourceType
{
 /// <summary>
 /// 视频
 /// </summary>
public const string Video_0001 = "0001";
 /// <summary>
 /// 音频
 /// </summary>
public const string Audio_0002 = "0002";
 /// <summary>
 /// 动画
 /// </summary>
public const string Animation_0003 = "0003";
 /// <summary>
 /// 图片
 /// </summary>
public const string Picture_0004 = "0004";
 /// <summary>
 /// 其它
 /// </summary>
public const string Other_0005 = "0005";
 /// <summary>
 /// PPT
 /// </summary>
public const string PPT_0006 = "0006";
 /// <summary>
 /// Word文档
 /// </summary>
public const string Word_0007 = "0007";
 /// <summary>
 /// Access文档
 /// </summary>
public const string Access_0008 = "0008";
 /// <summary>
 /// XPS文档
 /// </summary>
public const string XPS_0009 = "0009";
 /// <summary>
 /// 纯文本
 /// </summary>
public const string Text_0010 = "0010";
 /// <summary>
 /// Html文本
 /// </summary>
public const string Html_0011 = "0011";
 /// <summary>
 /// 压缩文件
 /// </summary>
public const string CompressedFile_0012 = "0012";
 /// <summary>
 /// Pdf文件
 /// </summary>
public const string Pdf_0013 = "0013";
 /// <summary>
 /// Excel文件
 /// </summary>
public const string Excel_0014 = "0014";
 /// <summary>
 /// 源代码
 /// </summary>
public const string SourceCode_0015 = "0015";
}
 /// <summary>
 /// 资源类型(ResourceType)
 /// 数据源类型:表
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsResourceTypeBL
{
public static RelatedActions_ResourceType relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsResourceTypeDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsResourceTypeDA ResourceTypeDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsResourceTypeDA();
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
 public clsResourceTypeBL()
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
if (string.IsNullOrEmpty(clsResourceTypeEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsResourceTypeEN._ConnectString);
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
public static DataTable GetDataTable_ResourceType(string strWhereCond)
{
DataTable objDT;
try
{
objDT = ResourceTypeDA.GetDataTable_ResourceType(strWhereCond);
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
objDT = ResourceTypeDA.GetDataTable(strWhereCond);
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
objDT = ResourceTypeDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = ResourceTypeDA.GetDataTable(strWhereCond, strTabName);
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
objDT = ResourceTypeDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = ResourceTypeDA.GetDataTable_Top(objTopPara);
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
objDT = ResourceTypeDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = ResourceTypeDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = ResourceTypeDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
 /// <param name = "arrIdResourceTypeLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static List<clsResourceTypeEN> GetObjLstByIdResourceTypeLst(List<string> arrIdResourceTypeLst)
{
List<clsResourceTypeEN> arrObjLst = new List<clsResourceTypeEN>(); 
System.Data.DataTable objDT; 
 string strSqlConditionStr = clsArray.GetSqlInStrByArray(arrIdResourceTypeLst, true);
 string strWhereCond = string.Format("IdResourceType in ({0})", strSqlConditionStr);
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsResourceTypeEN objResourceTypeEN = new clsResourceTypeEN();
try
{
objResourceTypeEN.IdResourceType = objRow[conResourceType.IdResourceType].ToString().Trim(); //资源类型流水号
objResourceTypeEN.ResourceTypeID = objRow[conResourceType.ResourceTypeID].ToString().Trim(); //资源类型ID
objResourceTypeEN.ResourceTypeName = objRow[conResourceType.ResourceTypeName].ToString().Trim(); //资源类型名称
objResourceTypeEN.ResourceTypeENName = objRow[conResourceType.ResourceTypeENName] == DBNull.Value ? null : objRow[conResourceType.ResourceTypeENName].ToString().Trim(); //ResourceTypeENName
objResourceTypeEN.FileExtentNameLst = objRow[conResourceType.FileExtentNameLst] == DBNull.Value ? null : objRow[conResourceType.FileExtentNameLst].ToString().Trim(); //文件扩展名列表
objResourceTypeEN.FileExtentNameLst2 = objRow[conResourceType.FileExtentNameLst2] == DBNull.Value ? null : objRow[conResourceType.FileExtentNameLst2].ToString().Trim(); //文件扩展名列表2
objResourceTypeEN.OrderNum = objRow[conResourceType.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conResourceType.OrderNum].ToString().Trim()); //序号
objResourceTypeEN.IsUse = clsEntityBase2.TransNullToBool_S(objRow[conResourceType.IsUse].ToString().Trim()); //是否使用
objResourceTypeEN.Memo = objRow[conResourceType.Memo] == DBNull.Value ? null : objRow[conResourceType.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objResourceTypeEN.IdResourceType, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objResourceTypeEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrIdResourceTypeLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsResourceTypeEN> GetObjLstByIdResourceTypeLstCache(List<string> arrIdResourceTypeLst)
{
string strKey = string.Format("{0}", clsResourceTypeEN._CurrTabName);
List<clsResourceTypeEN> arrResourceTypeObjLstCache = GetObjLstCache();
IEnumerable <clsResourceTypeEN> arrResourceTypeObjLst_Sel =
arrResourceTypeObjLstCache
.Where(x => arrIdResourceTypeLst.Contains(x.IdResourceType));
return arrResourceTypeObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsResourceTypeEN> GetObjLst(string strWhereCond)
{
List<clsResourceTypeEN> arrObjLst = new List<clsResourceTypeEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsResourceTypeEN objResourceTypeEN = new clsResourceTypeEN();
try
{
objResourceTypeEN.IdResourceType = objRow[conResourceType.IdResourceType].ToString().Trim(); //资源类型流水号
objResourceTypeEN.ResourceTypeID = objRow[conResourceType.ResourceTypeID].ToString().Trim(); //资源类型ID
objResourceTypeEN.ResourceTypeName = objRow[conResourceType.ResourceTypeName].ToString().Trim(); //资源类型名称
objResourceTypeEN.ResourceTypeENName = objRow[conResourceType.ResourceTypeENName] == DBNull.Value ? null : objRow[conResourceType.ResourceTypeENName].ToString().Trim(); //ResourceTypeENName
objResourceTypeEN.FileExtentNameLst = objRow[conResourceType.FileExtentNameLst] == DBNull.Value ? null : objRow[conResourceType.FileExtentNameLst].ToString().Trim(); //文件扩展名列表
objResourceTypeEN.FileExtentNameLst2 = objRow[conResourceType.FileExtentNameLst2] == DBNull.Value ? null : objRow[conResourceType.FileExtentNameLst2].ToString().Trim(); //文件扩展名列表2
objResourceTypeEN.OrderNum = objRow[conResourceType.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conResourceType.OrderNum].ToString().Trim()); //序号
objResourceTypeEN.IsUse = clsEntityBase2.TransNullToBool_S(objRow[conResourceType.IsUse].ToString().Trim()); //是否使用
objResourceTypeEN.Memo = objRow[conResourceType.Memo] == DBNull.Value ? null : objRow[conResourceType.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objResourceTypeEN.IdResourceType, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objResourceTypeEN);
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
public static List<clsResourceTypeEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsResourceTypeEN> arrObjLst = new List<clsResourceTypeEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsResourceTypeEN objResourceTypeEN = new clsResourceTypeEN();
try
{
objResourceTypeEN.IdResourceType = objRow[conResourceType.IdResourceType].ToString().Trim(); //资源类型流水号
objResourceTypeEN.ResourceTypeID = objRow[conResourceType.ResourceTypeID].ToString().Trim(); //资源类型ID
objResourceTypeEN.ResourceTypeName = objRow[conResourceType.ResourceTypeName].ToString().Trim(); //资源类型名称
objResourceTypeEN.ResourceTypeENName = objRow[conResourceType.ResourceTypeENName] == DBNull.Value ? null : objRow[conResourceType.ResourceTypeENName].ToString().Trim(); //ResourceTypeENName
objResourceTypeEN.FileExtentNameLst = objRow[conResourceType.FileExtentNameLst] == DBNull.Value ? null : objRow[conResourceType.FileExtentNameLst].ToString().Trim(); //文件扩展名列表
objResourceTypeEN.FileExtentNameLst2 = objRow[conResourceType.FileExtentNameLst2] == DBNull.Value ? null : objRow[conResourceType.FileExtentNameLst2].ToString().Trim(); //文件扩展名列表2
objResourceTypeEN.OrderNum = objRow[conResourceType.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conResourceType.OrderNum].ToString().Trim()); //序号
objResourceTypeEN.IsUse = clsEntityBase2.TransNullToBool_S(objRow[conResourceType.IsUse].ToString().Trim()); //是否使用
objResourceTypeEN.Memo = objRow[conResourceType.Memo] == DBNull.Value ? null : objRow[conResourceType.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objResourceTypeEN.IdResourceType, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objResourceTypeEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objResourceTypeCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsResourceTypeEN> GetSubObjLstCache(clsResourceTypeEN objResourceTypeCond)
{
List<clsResourceTypeEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsResourceTypeEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conResourceType.AttributeName)
{
if (objResourceTypeCond.IsUpdated(strFldName) == false) continue;
if (objResourceTypeCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objResourceTypeCond[strFldName].ToString());
}
else
{
if (objResourceTypeCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objResourceTypeCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objResourceTypeCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objResourceTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objResourceTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objResourceTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objResourceTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objResourceTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objResourceTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objResourceTypeCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objResourceTypeCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objResourceTypeCond[strFldName]));
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
public static List<clsResourceTypeEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsResourceTypeEN> arrObjLst = new List<clsResourceTypeEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsResourceTypeEN objResourceTypeEN = new clsResourceTypeEN();
try
{
objResourceTypeEN.IdResourceType = objRow[conResourceType.IdResourceType].ToString().Trim(); //资源类型流水号
objResourceTypeEN.ResourceTypeID = objRow[conResourceType.ResourceTypeID].ToString().Trim(); //资源类型ID
objResourceTypeEN.ResourceTypeName = objRow[conResourceType.ResourceTypeName].ToString().Trim(); //资源类型名称
objResourceTypeEN.ResourceTypeENName = objRow[conResourceType.ResourceTypeENName] == DBNull.Value ? null : objRow[conResourceType.ResourceTypeENName].ToString().Trim(); //ResourceTypeENName
objResourceTypeEN.FileExtentNameLst = objRow[conResourceType.FileExtentNameLst] == DBNull.Value ? null : objRow[conResourceType.FileExtentNameLst].ToString().Trim(); //文件扩展名列表
objResourceTypeEN.FileExtentNameLst2 = objRow[conResourceType.FileExtentNameLst2] == DBNull.Value ? null : objRow[conResourceType.FileExtentNameLst2].ToString().Trim(); //文件扩展名列表2
objResourceTypeEN.OrderNum = objRow[conResourceType.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conResourceType.OrderNum].ToString().Trim()); //序号
objResourceTypeEN.IsUse = clsEntityBase2.TransNullToBool_S(objRow[conResourceType.IsUse].ToString().Trim()); //是否使用
objResourceTypeEN.Memo = objRow[conResourceType.Memo] == DBNull.Value ? null : objRow[conResourceType.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objResourceTypeEN.IdResourceType, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objResourceTypeEN);
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
public static List<clsResourceTypeEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsResourceTypeEN> arrObjLst = new List<clsResourceTypeEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsResourceTypeEN objResourceTypeEN = new clsResourceTypeEN();
try
{
objResourceTypeEN.IdResourceType = objRow[conResourceType.IdResourceType].ToString().Trim(); //资源类型流水号
objResourceTypeEN.ResourceTypeID = objRow[conResourceType.ResourceTypeID].ToString().Trim(); //资源类型ID
objResourceTypeEN.ResourceTypeName = objRow[conResourceType.ResourceTypeName].ToString().Trim(); //资源类型名称
objResourceTypeEN.ResourceTypeENName = objRow[conResourceType.ResourceTypeENName] == DBNull.Value ? null : objRow[conResourceType.ResourceTypeENName].ToString().Trim(); //ResourceTypeENName
objResourceTypeEN.FileExtentNameLst = objRow[conResourceType.FileExtentNameLst] == DBNull.Value ? null : objRow[conResourceType.FileExtentNameLst].ToString().Trim(); //文件扩展名列表
objResourceTypeEN.FileExtentNameLst2 = objRow[conResourceType.FileExtentNameLst2] == DBNull.Value ? null : objRow[conResourceType.FileExtentNameLst2].ToString().Trim(); //文件扩展名列表2
objResourceTypeEN.OrderNum = objRow[conResourceType.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conResourceType.OrderNum].ToString().Trim()); //序号
objResourceTypeEN.IsUse = clsEntityBase2.TransNullToBool_S(objRow[conResourceType.IsUse].ToString().Trim()); //是否使用
objResourceTypeEN.Memo = objRow[conResourceType.Memo] == DBNull.Value ? null : objRow[conResourceType.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objResourceTypeEN.IdResourceType, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objResourceTypeEN);
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
List<clsResourceTypeEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsResourceTypeEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsResourceTypeEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsResourceTypeEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsResourceTypeEN> arrObjLst = new List<clsResourceTypeEN>(); 
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
	clsResourceTypeEN objResourceTypeEN = new clsResourceTypeEN();
try
{
objResourceTypeEN.IdResourceType = objRow[conResourceType.IdResourceType].ToString().Trim(); //资源类型流水号
objResourceTypeEN.ResourceTypeID = objRow[conResourceType.ResourceTypeID].ToString().Trim(); //资源类型ID
objResourceTypeEN.ResourceTypeName = objRow[conResourceType.ResourceTypeName].ToString().Trim(); //资源类型名称
objResourceTypeEN.ResourceTypeENName = objRow[conResourceType.ResourceTypeENName] == DBNull.Value ? null : objRow[conResourceType.ResourceTypeENName].ToString().Trim(); //ResourceTypeENName
objResourceTypeEN.FileExtentNameLst = objRow[conResourceType.FileExtentNameLst] == DBNull.Value ? null : objRow[conResourceType.FileExtentNameLst].ToString().Trim(); //文件扩展名列表
objResourceTypeEN.FileExtentNameLst2 = objRow[conResourceType.FileExtentNameLst2] == DBNull.Value ? null : objRow[conResourceType.FileExtentNameLst2].ToString().Trim(); //文件扩展名列表2
objResourceTypeEN.OrderNum = objRow[conResourceType.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conResourceType.OrderNum].ToString().Trim()); //序号
objResourceTypeEN.IsUse = clsEntityBase2.TransNullToBool_S(objRow[conResourceType.IsUse].ToString().Trim()); //是否使用
objResourceTypeEN.Memo = objRow[conResourceType.Memo] == DBNull.Value ? null : objRow[conResourceType.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objResourceTypeEN.IdResourceType, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objResourceTypeEN);
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
public static List<clsResourceTypeEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsResourceTypeEN> arrObjLst = new List<clsResourceTypeEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsResourceTypeEN objResourceTypeEN = new clsResourceTypeEN();
try
{
objResourceTypeEN.IdResourceType = objRow[conResourceType.IdResourceType].ToString().Trim(); //资源类型流水号
objResourceTypeEN.ResourceTypeID = objRow[conResourceType.ResourceTypeID].ToString().Trim(); //资源类型ID
objResourceTypeEN.ResourceTypeName = objRow[conResourceType.ResourceTypeName].ToString().Trim(); //资源类型名称
objResourceTypeEN.ResourceTypeENName = objRow[conResourceType.ResourceTypeENName] == DBNull.Value ? null : objRow[conResourceType.ResourceTypeENName].ToString().Trim(); //ResourceTypeENName
objResourceTypeEN.FileExtentNameLst = objRow[conResourceType.FileExtentNameLst] == DBNull.Value ? null : objRow[conResourceType.FileExtentNameLst].ToString().Trim(); //文件扩展名列表
objResourceTypeEN.FileExtentNameLst2 = objRow[conResourceType.FileExtentNameLst2] == DBNull.Value ? null : objRow[conResourceType.FileExtentNameLst2].ToString().Trim(); //文件扩展名列表2
objResourceTypeEN.OrderNum = objRow[conResourceType.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conResourceType.OrderNum].ToString().Trim()); //序号
objResourceTypeEN.IsUse = clsEntityBase2.TransNullToBool_S(objRow[conResourceType.IsUse].ToString().Trim()); //是否使用
objResourceTypeEN.Memo = objRow[conResourceType.Memo] == DBNull.Value ? null : objRow[conResourceType.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objResourceTypeEN.IdResourceType, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objResourceTypeEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsResourceTypeEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsResourceTypeEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsResourceTypeEN> arrObjLst = new List<clsResourceTypeEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsResourceTypeEN objResourceTypeEN = new clsResourceTypeEN();
try
{
objResourceTypeEN.IdResourceType = objRow[conResourceType.IdResourceType].ToString().Trim(); //资源类型流水号
objResourceTypeEN.ResourceTypeID = objRow[conResourceType.ResourceTypeID].ToString().Trim(); //资源类型ID
objResourceTypeEN.ResourceTypeName = objRow[conResourceType.ResourceTypeName].ToString().Trim(); //资源类型名称
objResourceTypeEN.ResourceTypeENName = objRow[conResourceType.ResourceTypeENName] == DBNull.Value ? null : objRow[conResourceType.ResourceTypeENName].ToString().Trim(); //ResourceTypeENName
objResourceTypeEN.FileExtentNameLst = objRow[conResourceType.FileExtentNameLst] == DBNull.Value ? null : objRow[conResourceType.FileExtentNameLst].ToString().Trim(); //文件扩展名列表
objResourceTypeEN.FileExtentNameLst2 = objRow[conResourceType.FileExtentNameLst2] == DBNull.Value ? null : objRow[conResourceType.FileExtentNameLst2].ToString().Trim(); //文件扩展名列表2
objResourceTypeEN.OrderNum = objRow[conResourceType.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conResourceType.OrderNum].ToString().Trim()); //序号
objResourceTypeEN.IsUse = clsEntityBase2.TransNullToBool_S(objRow[conResourceType.IsUse].ToString().Trim()); //是否使用
objResourceTypeEN.Memo = objRow[conResourceType.Memo] == DBNull.Value ? null : objRow[conResourceType.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objResourceTypeEN.IdResourceType, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objResourceTypeEN);
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
public static List<clsResourceTypeEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsResourceTypeEN> arrObjLst = new List<clsResourceTypeEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsResourceTypeEN objResourceTypeEN = new clsResourceTypeEN();
try
{
objResourceTypeEN.IdResourceType = objRow[conResourceType.IdResourceType].ToString().Trim(); //资源类型流水号
objResourceTypeEN.ResourceTypeID = objRow[conResourceType.ResourceTypeID].ToString().Trim(); //资源类型ID
objResourceTypeEN.ResourceTypeName = objRow[conResourceType.ResourceTypeName].ToString().Trim(); //资源类型名称
objResourceTypeEN.ResourceTypeENName = objRow[conResourceType.ResourceTypeENName] == DBNull.Value ? null : objRow[conResourceType.ResourceTypeENName].ToString().Trim(); //ResourceTypeENName
objResourceTypeEN.FileExtentNameLst = objRow[conResourceType.FileExtentNameLst] == DBNull.Value ? null : objRow[conResourceType.FileExtentNameLst].ToString().Trim(); //文件扩展名列表
objResourceTypeEN.FileExtentNameLst2 = objRow[conResourceType.FileExtentNameLst2] == DBNull.Value ? null : objRow[conResourceType.FileExtentNameLst2].ToString().Trim(); //文件扩展名列表2
objResourceTypeEN.OrderNum = objRow[conResourceType.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conResourceType.OrderNum].ToString().Trim()); //序号
objResourceTypeEN.IsUse = clsEntityBase2.TransNullToBool_S(objRow[conResourceType.IsUse].ToString().Trim()); //是否使用
objResourceTypeEN.Memo = objRow[conResourceType.Memo] == DBNull.Value ? null : objRow[conResourceType.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objResourceTypeEN.IdResourceType, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objResourceTypeEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsResourceTypeEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsResourceTypeEN> arrObjLst = new List<clsResourceTypeEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsResourceTypeEN objResourceTypeEN = new clsResourceTypeEN();
try
{
objResourceTypeEN.IdResourceType = objRow[conResourceType.IdResourceType].ToString().Trim(); //资源类型流水号
objResourceTypeEN.ResourceTypeID = objRow[conResourceType.ResourceTypeID].ToString().Trim(); //资源类型ID
objResourceTypeEN.ResourceTypeName = objRow[conResourceType.ResourceTypeName].ToString().Trim(); //资源类型名称
objResourceTypeEN.ResourceTypeENName = objRow[conResourceType.ResourceTypeENName] == DBNull.Value ? null : objRow[conResourceType.ResourceTypeENName].ToString().Trim(); //ResourceTypeENName
objResourceTypeEN.FileExtentNameLst = objRow[conResourceType.FileExtentNameLst] == DBNull.Value ? null : objRow[conResourceType.FileExtentNameLst].ToString().Trim(); //文件扩展名列表
objResourceTypeEN.FileExtentNameLst2 = objRow[conResourceType.FileExtentNameLst2] == DBNull.Value ? null : objRow[conResourceType.FileExtentNameLst2].ToString().Trim(); //文件扩展名列表2
objResourceTypeEN.OrderNum = objRow[conResourceType.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conResourceType.OrderNum].ToString().Trim()); //序号
objResourceTypeEN.IsUse = clsEntityBase2.TransNullToBool_S(objRow[conResourceType.IsUse].ToString().Trim()); //是否使用
objResourceTypeEN.Memo = objRow[conResourceType.Memo] == DBNull.Value ? null : objRow[conResourceType.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objResourceTypeEN.IdResourceType, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objResourceTypeEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objResourceTypeEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetResourceType(ref clsResourceTypeEN objResourceTypeEN)
{
bool bolResult = ResourceTypeDA.GetResourceType(ref objResourceTypeEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "strIdResourceType">表关键字</param>
 /// <returns>表对象</returns>
public static clsResourceTypeEN GetObjByIdResourceType(string strIdResourceType)
{
if (strIdResourceType.IndexOf(' ') >=0)
{
var strMsg = string.Format("(errid:Busi000079)在表中,关键字[strIdResourceType]中不能有空格!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
if (string.IsNullOrEmpty(strIdResourceType) == true)
{
var strMsg = string.Format("(errid:Busi000020)在表中,关键字[strIdResourceType]不能为空!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
clsResourceTypeEN objResourceTypeEN = ResourceTypeDA.GetObjByIdResourceType(strIdResourceType);
return objResourceTypeEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsResourceTypeEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsResourceTypeEN objResourceTypeEN = ResourceTypeDA.GetFirstObj(strWhereCond);
 return objResourceTypeEN;
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
public static clsResourceTypeEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsResourceTypeEN objResourceTypeEN = ResourceTypeDA.GetObjByDataRow(objRow);
 return objResourceTypeEN;
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
public static clsResourceTypeEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsResourceTypeEN objResourceTypeEN = ResourceTypeDA.GetObjByDataRow(objRow);
 return objResourceTypeEN;
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
 /// <param name = "strIdResourceType">所给的关键字</param>
 /// <param name = "lstResourceTypeObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsResourceTypeEN GetObjByIdResourceTypeFromList(string strIdResourceType, List<clsResourceTypeEN> lstResourceTypeObjLst)
{
foreach (clsResourceTypeEN objResourceTypeEN in lstResourceTypeObjLst)
{
if (objResourceTypeEN.IdResourceType == strIdResourceType)
{
return objResourceTypeEN;
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
 string strIdResourceType;
 try
 {
 strIdResourceType = new clsResourceTypeDA().GetFirstID(strWhereCond);
 return strIdResourceType;
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
 arrList = ResourceTypeDA.GetID(strWhereCond);
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
bool bolIsExist = ResourceTypeDA.IsExistCondRec(strWhereCond);
return bolIsExist;
}

 /// <summary>
 /// 判断当前表中是否存在给定关键字值的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExist)
 /// </summary>
 /// <param name = "strIdResourceType">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public static bool IsExist(string strIdResourceType)
{
if (string.IsNullOrEmpty(strIdResourceType) == true)
{
var strMsg = string.Format("(errid:Busi000027)在表中,关键字[strIdResourceType]不能为空!!(from {0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
//检测记录是否存在
bool bolIsExist = ResourceTypeDA.IsExist(strIdResourceType);
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
 bolIsExist = clsResourceTypeDA.IsExistTable();
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
 bolIsExist = ResourceTypeDA.IsExistTable(strTabName);
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
 /// <param name = "objResourceTypeEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecordBySql2(clsResourceTypeEN objResourceTypeEN, bool bolIsNeedCheckUniqueness=true)
{
 if (string.IsNullOrEmpty(objResourceTypeEN.IdResourceType) == true)
 {
string strMsg = string.Format("添加记录时,关键字不能为空!(from {0})\r\n", 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
 if (clsResourceTypeBL.IsExist(objResourceTypeEN.IdResourceType) == true)
 {
string strMsg = string.Format("添加记录时,关键字:[{0}]已经存在!(from {1})\r\n", objResourceTypeEN.IdResourceType, 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
try
{
bool bolResult = ResourceTypeDA.AddNewRecordBySQL2(objResourceTypeEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsResourceTypeBL.ReFreshCache();

if (clsResourceTypeBL.relatedActions != null)
{
clsResourceTypeBL.relatedActions.UpdRelaTabDate(objResourceTypeEN.IdResourceType, "SetUpdDate");
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
 /// <param name = "objResourceTypeEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordBySql2WithReturnKey(clsResourceTypeEN objResourceTypeEN, bool bolIsNeedCheckUniqueness=true)
{
 if (string.IsNullOrEmpty(objResourceTypeEN.IdResourceType) == true)
 {
string strMsg = string.Format("添加记录时,关键字不能为空!(from {{0}})", 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
 if (clsResourceTypeBL.IsExist(objResourceTypeEN.IdResourceType) == true)
 {
string strMsg = string.Format("添加记录时,关键字:[{0}]已经存在!(from {1})\r\n", objResourceTypeEN.IdResourceType, 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
try
{
string strKey = ResourceTypeDA.AddNewRecordBySQL2WithReturnKey(objResourceTypeEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsResourceTypeBL.ReFreshCache();

if (clsResourceTypeBL.relatedActions != null)
{
clsResourceTypeBL.relatedActions.UpdRelaTabDate(objResourceTypeEN.IdResourceType, "SetUpdDate");
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
 /// <param name = "objResourceTypeEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(clsResourceTypeEN objResourceTypeEN)
{
try
{
bool bolResult = ResourceTypeDA.Update(objResourceTypeEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsResourceTypeBL.ReFreshCache();

if (clsResourceTypeBL.relatedActions != null)
{
clsResourceTypeBL.relatedActions.UpdRelaTabDate(objResourceTypeEN.IdResourceType, "SetUpdDate");
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
 /// <param name = "objResourceTypeEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateBySql2(clsResourceTypeEN objResourceTypeEN)
{
 if (string.IsNullOrEmpty(objResourceTypeEN.IdResourceType) == true)
 {
var strMsg = string.Format("(errid:Busi000065)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = ResourceTypeDA.UpdateBySql2(objResourceTypeEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsResourceTypeBL.ReFreshCache();

if (clsResourceTypeBL.relatedActions != null)
{
clsResourceTypeBL.relatedActions.UpdRelaTabDate(objResourceTypeEN.IdResourceType, "SetUpdDate");
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
 /// <param name = "strIdResourceType">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int DelRecord(string strIdResourceType)
{
try
{
 clsResourceTypeEN objResourceTypeEN = clsResourceTypeBL.GetObjByIdResourceType(strIdResourceType);

if (clsResourceTypeBL.relatedActions != null)
{
clsResourceTypeBL.relatedActions.UpdRelaTabDate(objResourceTypeEN.IdResourceType, "SetUpdDate");
}
if (objResourceTypeEN != null)
{
int intRecNum = ResourceTypeDA.DelRecord(strIdResourceType);
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
/// <param name="strIdResourceType">表关键字</param>
/// <returns></returns>
public static bool DelRecordEx(string strIdResourceType )
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsResourceTypeDA.GetSpecSQLObj();
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
//删除与表:[ResourceType]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conResourceType.IdResourceType,
//strIdResourceType);
//        clsResourceTypeBL.DelResourceTypesByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsResourceTypeBL.DelRecord(strIdResourceType, objConnection, objSqlTransaction);
objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsResourceTypeBLEx", "DelRecordEx", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("扩展删除记录出错:{0}!keyId = {1}.({2})",
objException.Message,
strIdResourceType, clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "strIdResourceType">给定的关键字值</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回删除是否成功?</returns>
public static bool DelRecord(string strIdResourceType, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
if (clsResourceTypeBL.relatedActions != null)
{
clsResourceTypeBL.relatedActions.UpdRelaTabDate(strIdResourceType, "UpdRelaTabDate");
}
bool bolResult = ResourceTypeDA.DelRecord(strIdResourceType,objSqlConnection,objSqlTransaction);
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
 /// <param name = "arrIdResourceTypeLst">给定的关键字值列表</param>
 /// <returns>返回删除的记录数</returns>
public static int DelResourceTypes(List<string> arrIdResourceTypeLst)
{
if (arrIdResourceTypeLst.Count == 0) return 0;
try
{
if (clsResourceTypeBL.relatedActions != null)
{
foreach (var strIdResourceType in arrIdResourceTypeLst)
{
clsResourceTypeBL.relatedActions.UpdRelaTabDate(strIdResourceType, "UpdRelaTabDate");
}
}
int intDelRecNum = ResourceTypeDA.DelResourceType(arrIdResourceTypeLst);
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
public static int DelResourceTypesByCond(string strWhereCond)
{
try
{
if (clsResourceTypeBL.relatedActions != null)
{
List<string> arrIdResourceType = GetPrimaryKeyID_S(strWhereCond);
foreach (var strIdResourceType in arrIdResourceType)
{
clsResourceTypeBL.relatedActions.UpdRelaTabDate(strIdResourceType, "UpdRelaTabDate");
}
}
int intRecNum = ResourceTypeDA.DelResourceType(strWhereCond);
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
/// 这里仅仅是演示函数,使用时请复制到扩展类:[ResourceType]中改名为:[DelRecord4MultiTabEx]使用
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DelRecord4MultiTab)
/// </summary>
/// <param name="strIdResourceType">表关键字</param>
/// <returns></returns>
public static bool DelRecord4MultiTab(string strIdResourceType)
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsResourceTypeDA.GetSpecSQLObj();
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
//删除与表:[ResourceType]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conStudent.id_College,
//strid_College);
//        clsStudentBL.DelStudentsByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsResourceTypeBL.DelRecord(strIdResourceType, objConnection, objSqlTransaction);
                objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsResourceTypeBL", "DelRecord4MultiTab", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("删除多表记录出错:{0}!keyId = {1}.({2})",
objException.Message,
strIdResourceType, clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "objResourceTypeENS">源对象</param>
 /// <param name = "objResourceTypeENT">目标对象</param>
 public static void CopyTo(clsResourceTypeEN objResourceTypeENS, clsResourceTypeEN objResourceTypeENT)
{
try
{
objResourceTypeENT.IdResourceType = objResourceTypeENS.IdResourceType; //资源类型流水号
objResourceTypeENT.ResourceTypeID = objResourceTypeENS.ResourceTypeID; //资源类型ID
objResourceTypeENT.ResourceTypeName = objResourceTypeENS.ResourceTypeName; //资源类型名称
objResourceTypeENT.ResourceTypeENName = objResourceTypeENS.ResourceTypeENName; //ResourceTypeENName
objResourceTypeENT.FileExtentNameLst = objResourceTypeENS.FileExtentNameLst; //文件扩展名列表
objResourceTypeENT.FileExtentNameLst2 = objResourceTypeENS.FileExtentNameLst2; //文件扩展名列表2
objResourceTypeENT.OrderNum = objResourceTypeENS.OrderNum; //序号
objResourceTypeENT.IsUse = objResourceTypeENS.IsUse; //是否使用
objResourceTypeENT.Memo = objResourceTypeENS.Memo; //备注
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
 /// <param name = "objResourceTypeEN">源简化对象</param>
 public static void SetUpdFlag(clsResourceTypeEN objResourceTypeEN)
{
try
{
objResourceTypeEN.ClearUpdateState();
   string strsfUpdFldSetStr = objResourceTypeEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(conResourceType.IdResourceType, new clsStrCompareIgnoreCase())  ==  true)
{
objResourceTypeEN.IdResourceType = objResourceTypeEN.IdResourceType; //资源类型流水号
}
if (arrFldSet.Contains(conResourceType.ResourceTypeID, new clsStrCompareIgnoreCase())  ==  true)
{
objResourceTypeEN.ResourceTypeID = objResourceTypeEN.ResourceTypeID; //资源类型ID
}
if (arrFldSet.Contains(conResourceType.ResourceTypeName, new clsStrCompareIgnoreCase())  ==  true)
{
objResourceTypeEN.ResourceTypeName = objResourceTypeEN.ResourceTypeName; //资源类型名称
}
if (arrFldSet.Contains(conResourceType.ResourceTypeENName, new clsStrCompareIgnoreCase())  ==  true)
{
objResourceTypeEN.ResourceTypeENName = objResourceTypeEN.ResourceTypeENName == "[null]" ? null :  objResourceTypeEN.ResourceTypeENName; //ResourceTypeENName
}
if (arrFldSet.Contains(conResourceType.FileExtentNameLst, new clsStrCompareIgnoreCase())  ==  true)
{
objResourceTypeEN.FileExtentNameLst = objResourceTypeEN.FileExtentNameLst == "[null]" ? null :  objResourceTypeEN.FileExtentNameLst; //文件扩展名列表
}
if (arrFldSet.Contains(conResourceType.FileExtentNameLst2, new clsStrCompareIgnoreCase())  ==  true)
{
objResourceTypeEN.FileExtentNameLst2 = objResourceTypeEN.FileExtentNameLst2 == "[null]" ? null :  objResourceTypeEN.FileExtentNameLst2; //文件扩展名列表2
}
if (arrFldSet.Contains(conResourceType.OrderNum, new clsStrCompareIgnoreCase())  ==  true)
{
objResourceTypeEN.OrderNum = objResourceTypeEN.OrderNum; //序号
}
if (arrFldSet.Contains(conResourceType.IsUse, new clsStrCompareIgnoreCase())  ==  true)
{
objResourceTypeEN.IsUse = objResourceTypeEN.IsUse; //是否使用
}
if (arrFldSet.Contains(conResourceType.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objResourceTypeEN.Memo = objResourceTypeEN.Memo == "[null]" ? null :  objResourceTypeEN.Memo; //备注
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
 /// <param name = "objResourceTypeEN">源简化对象</param>
 public static void AccessFldValueNull(clsResourceTypeEN objResourceTypeEN)
{
try
{
if (objResourceTypeEN.ResourceTypeENName == "[null]") objResourceTypeEN.ResourceTypeENName = null; //ResourceTypeENName
if (objResourceTypeEN.FileExtentNameLst == "[null]") objResourceTypeEN.FileExtentNameLst = null; //文件扩展名列表
if (objResourceTypeEN.FileExtentNameLst2 == "[null]") objResourceTypeEN.FileExtentNameLst2 = null; //文件扩展名列表2
if (objResourceTypeEN.Memo == "[null]") objResourceTypeEN.Memo = null; //备注
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
public static void CheckPropertyNew(clsResourceTypeEN objResourceTypeEN)
{
 ResourceTypeDA.CheckPropertyNew(objResourceTypeEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(clsResourceTypeEN objResourceTypeEN)
{
 ResourceTypeDA.CheckProperty4Condition(objResourceTypeEN);
 }


 #endregion 检查对象属性


 #region 绑定下拉框

 /// <summary>
 /// 绑定基于Web的下拉框-使用Cache
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DdlBindFunctionCache)
 /// </summary>
 /// <param name = "objDDL">需要绑定当前表的下拉框</param>
public static void BindDdl_IdResourceTypeCache(System.Web.UI.WebControls.DropDownList objDDL)
{
//为数据源于表的下拉框设置内容
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[资源类型]...","0");
List<clsResourceTypeEN> arrResourceTypeObjLst = GetAllResourceTypeObjLstCache(); 
objDDL.DataValueField = conResourceType.IdResourceType;
objDDL.DataTextField = conResourceType.ResourceTypeName;
objDDL.DataSource = arrResourceTypeObjLst;
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
if (clsResourceTypeBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsResourceTypeBL没有刷新缓存机制(clsResourceTypeBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by IdResourceType");
//if (arrResourceTypeObjLstCache == null)
//{
//arrResourceTypeObjLstCache = ResourceTypeDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "strIdResourceType">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsResourceTypeEN GetObjByIdResourceTypeCache(string strIdResourceType)
{
//获取缓存中的对象列表
string strKey = string.Format("{0}", clsResourceTypeEN._CurrTabName);
List<clsResourceTypeEN> arrResourceTypeObjLstCache = GetObjLstCache();
IEnumerable <clsResourceTypeEN> arrResourceTypeObjLst_Sel =
arrResourceTypeObjLstCache
.Where(x=> x.IdResourceType == strIdResourceType 
);
if (arrResourceTypeObjLst_Sel.Count() == 0)
{
   clsResourceTypeEN obj = clsResourceTypeBL.GetObjByIdResourceType(strIdResourceType);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
 }
return null;
}
return arrResourceTypeObjLst_Sel.First();
}

 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecNameByKeyCache)
 /// </summary>
 /// <param name = "strIdResourceType">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetResourceTypeNameByIdResourceTypeCache(string strIdResourceType)
{
if (string.IsNullOrEmpty(strIdResourceType) == true) return "";
//获取缓存中的对象列表
clsResourceTypeEN objResourceType = GetObjByIdResourceTypeCache(strIdResourceType);
if (objResourceType == null) return "";
return objResourceType.ResourceTypeName;
}
 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecNameByKeyCache)
 /// </summary>
 /// <param name = "strIdResourceType">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetNameByIdResourceTypeCache(string strIdResourceType)
{
if (string.IsNullOrEmpty(strIdResourceType) == true) return "";
//获取缓存中的对象列表
clsResourceTypeEN objResourceType = GetObjByIdResourceTypeCache(strIdResourceType);
if (objResourceType == null) return "";
return objResourceType.ResourceTypeName;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsResourceTypeEN> GetAllResourceTypeObjLstCache()
{
//获取缓存中的对象列表
List<clsResourceTypeEN> arrResourceTypeObjLstCache = GetObjLstCache(); 
return arrResourceTypeObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsResourceTypeEN> GetObjLstCache()
{
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}", clsResourceTypeEN._CurrTabName);
List<clsResourceTypeEN> arrResourceTypeObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrResourceTypeObjLstCache;
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
string strKey = string.Format("{0}", clsResourceTypeEN._CurrTabName);
CacheHelper.Remove(strKey);
clsResourceTypeEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
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
if (clsResourceTypeEN._RefreshTimeLst.Count == 0) return "";
return clsResourceTypeEN._RefreshTimeLst[clsResourceTypeEN._RefreshTimeLst.Count - 1];
}

 /// <summary>
 /// 刷新缓存.把当前表的缓存以及该表相关视图的缓存清空.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ReFreshCache)
 /// </summary>
public static void ReFreshCache()
{
if (clsResourceTypeBL.objCommFun4BL != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}", clsResourceTypeEN._CurrTabName);
CacheHelper.Remove(strKey);
clsResourceTypeEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
clsResourceTypeBL.objCommFun4BL.ReFreshCache();
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
public static string Func(string strInFldName, string strOutFldName, string strIdResourceType)
{
if (strInFldName != conResourceType.IdResourceType)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (conResourceType.AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", conResourceType.AttributeName));
throw new Exception(strMsg);
}
var objResourceType = clsResourceTypeBL.GetObjByIdResourceTypeCache(strIdResourceType);
if (objResourceType == null) return "";
return objResourceType[strOutFldName].ToString();
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
int intRecCount = clsResourceTypeDA.GetRecCount(strTabName);
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
int intRecCount = clsResourceTypeDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsResourceTypeDA.GetRecCount();
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
int intRecCount = clsResourceTypeDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objResourceTypeCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsResourceTypeEN objResourceTypeCond)
{
List<clsResourceTypeEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsResourceTypeEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conResourceType.AttributeName)
{
if (objResourceTypeCond.IsUpdated(strFldName) == false) continue;
if (objResourceTypeCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objResourceTypeCond[strFldName].ToString());
}
else
{
if (objResourceTypeCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objResourceTypeCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objResourceTypeCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objResourceTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objResourceTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objResourceTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objResourceTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objResourceTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objResourceTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objResourceTypeCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objResourceTypeCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objResourceTypeCond[strFldName]));
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
 List<string> arrList = clsResourceTypeDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = ResourceTypeDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = ResourceTypeDA.GetFldValueNoDistinct(strFldName, strWhereCond);
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
int intRecCount = ResourceTypeDA.SetFldValue(strFldName, strValue, strWhereCond);
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
int intRecCount = clsResourceTypeDA.SetFldValue(clsResourceTypeEN._CurrTabName, strFldName, fltValue, strWhereCond);
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
int intRecCount = ResourceTypeDA.SetFldValue( strFldName, intValue, strWhereCond);
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
int intRecCount = clsResourceTypeDA.SetFldValue(strTabName, strFldName, strValue, strWhereCond);
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
int intRecCount = clsResourceTypeDA.SetFldValue(strTabName, strFldName, intValue, strWhereCond);
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
int intRecCount = clsResourceTypeDA.SetFldValue(strTabName, strFldName, fltValue, strWhereCond);
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
  strCreateTabCode.Append("CREATE table [dbo].[ResourceType] "); 
 strCreateTabCode.Append(" ( "); 
 // /**资源类型流水号*/ 
 strCreateTabCode.Append(" IdResourceType char(4) primary key, "); 
 // /**资源类型ID*/ 
 strCreateTabCode.Append(" ResourceTypeID char(4) not Null, "); 
 // /**资源类型名称*/ 
 strCreateTabCode.Append(" ResourceTypeName varchar(50) not Null, "); 
 // /**ResourceTypeENName*/ 
 strCreateTabCode.Append(" ResourceTypeENName varchar(50) Null, "); 
 // /**文件扩展名列表*/ 
 strCreateTabCode.Append(" FileExtentNameLst varchar(200) Null, "); 
 // /**文件扩展名列表2*/ 
 strCreateTabCode.Append(" FileExtentNameLst2 varchar(200) Null, "); 
 // /**序号*/ 
 strCreateTabCode.Append(" OrderNum int Null, "); 
 // /**是否使用*/ 
 strCreateTabCode.Append(" IsUse bit Null, "); 
 // /**备注*/ 
 strCreateTabCode.Append(" Memo varchar(1000) Null ");
 strCreateTabCode.Append(") "); 
  strCreateTabCode.Append("ON [PRIMARY] ");
  return strCreateTabCode.ToString();
}



 #endregion 表操作
}
 /// <summary>
 /// 资源类型(ResourceType)
 /// 数据源类型:表
 /// (AutoGCLib.CommFun4BL4CSharp:GeneCode_This)
 /// </summary>
public class  clsCommFun4BL4ResourceType : clsCommFun4BL
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
clsResourceTypeBL.ReFreshThisCache();
}
}

}