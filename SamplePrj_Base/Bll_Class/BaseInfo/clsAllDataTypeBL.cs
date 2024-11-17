
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsAllDataTypeBL
 表名:AllDataType(01160063)
 * 版本:2023.03.10.1(服务器:WIN-SRV103-116)
 日期:2023/03/11 03:03:04
 生成者:pyf
 生成服务器IP:
 工程名称:简单工程样例(0116)
 CM工程:简单样例后端(变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433SimplePrj
 PrjDataBaseId:0111
 模块中文名:基本信息(BaseInfo)
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
using SimplePrj.Entity;
using System.Data; 
using System.Data.SqlClient; 
using SimplePrj.DAL;

namespace SimplePrj.BusinessLogic
{
public static class clsAllDataTypeBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public static clsAllDataTypeEN GetObj(this K_mId_AllDataType myKey)
{
clsAllDataTypeEN objAllDataTypeEN = clsAllDataTypeBL.AllDataTypeDA.GetObjBymId(myKey.Value);
return objAllDataTypeEN;
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_AddNewRecord)
 /// </summary>
 /// <param name = "objAllDataTypeEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clsAllDataTypeEN objAllDataTypeEN)
{
if (CheckUniqueness_mString_mInt(objAllDataTypeEN) == false)
{
var strMsg = string.Format("记录已经存在!字符串 = [{0}],整型 = [{1}]的数据已经存在!(in clsAllDataTypeBL.AddNewRecord)", objAllDataTypeEN.mString,objAllDataTypeEN.mInt);
throw new Exception(strMsg);
}
try
{
bool bolResult = clsAllDataTypeBL.AllDataTypeDA.AddNewRecordBySQL2(objAllDataTypeEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsAllDataTypeBL.ReFreshCache();

if (clsAllDataTypeBL.relatedActions != null)
{
clsAllDataTypeBL.relatedActions.UpdRelaTabDate(objAllDataTypeEN.mId, "SetUpdDate");
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
public static bool AddRecordEx(this clsAllDataTypeEN objAllDataTypeEN)
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
objAllDataTypeEN.CheckPropertyNew();
//6、把数据实体层的数据存贮到数据库中
objAllDataTypeEN.AddNewRecord();
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
 /// <param name = "objAllDataTypeEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordWithReturnKey(this clsAllDataTypeEN objAllDataTypeEN)
{
if (CheckUniqueness_mString_mInt(objAllDataTypeEN) == false)
{
var strMsg = string.Format("记录已经存在!字符串 = [{0}],整型 = [{1}]的数据已经存在!(in clsAllDataTypeBL.AddNewRecordWithReturnKey)", objAllDataTypeEN.mString,objAllDataTypeEN.mInt);
throw new Exception(strMsg);
}
try
{
string strKey = clsAllDataTypeBL.AllDataTypeDA.AddNewRecordBySQL2WithReturnKey(objAllDataTypeEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsAllDataTypeBL.ReFreshCache();

if (clsAllDataTypeBL.relatedActions != null)
{
clsAllDataTypeBL.relatedActions.UpdRelaTabDate(objAllDataTypeEN.mId, "SetUpdDate");
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objAllDataTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsAllDataTypeEN SetmId(this clsAllDataTypeEN objAllDataTypeEN, long lngmId, string strComparisonOp="")
	{
objAllDataTypeEN.mId = lngmId; //mId
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objAllDataTypeEN.dicFldComparisonOp.ContainsKey(conAllDataType.mId) == false)
{
objAllDataTypeEN.dicFldComparisonOp.Add(conAllDataType.mId, strComparisonOp);
}
else
{
objAllDataTypeEN.dicFldComparisonOp[conAllDataType.mId] = strComparisonOp;
}
}
return objAllDataTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objAllDataTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsAllDataTypeEN SetmString(this clsAllDataTypeEN objAllDataTypeEN, string strmString, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strmString, 50, conAllDataType.mString);
}
objAllDataTypeEN.mString = strmString; //字符串
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objAllDataTypeEN.dicFldComparisonOp.ContainsKey(conAllDataType.mString) == false)
{
objAllDataTypeEN.dicFldComparisonOp.Add(conAllDataType.mString, strComparisonOp);
}
else
{
objAllDataTypeEN.dicFldComparisonOp[conAllDataType.mString] = strComparisonOp;
}
}
return objAllDataTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objAllDataTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsAllDataTypeEN SetmInt(this clsAllDataTypeEN objAllDataTypeEN, int intmInt, string strComparisonOp="")
	{
objAllDataTypeEN.mInt = intmInt; //整型
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objAllDataTypeEN.dicFldComparisonOp.ContainsKey(conAllDataType.mInt) == false)
{
objAllDataTypeEN.dicFldComparisonOp.Add(conAllDataType.mInt, strComparisonOp);
}
else
{
objAllDataTypeEN.dicFldComparisonOp[conAllDataType.mInt] = strComparisonOp;
}
}
return objAllDataTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objAllDataTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsAllDataTypeEN SetmLong(this clsAllDataTypeEN objAllDataTypeEN, long lngmLong, string strComparisonOp="")
	{
objAllDataTypeEN.mLong = lngmLong; //长整型
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objAllDataTypeEN.dicFldComparisonOp.ContainsKey(conAllDataType.mLong) == false)
{
objAllDataTypeEN.dicFldComparisonOp.Add(conAllDataType.mLong, strComparisonOp);
}
else
{
objAllDataTypeEN.dicFldComparisonOp[conAllDataType.mLong] = strComparisonOp;
}
}
return objAllDataTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objAllDataTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsAllDataTypeEN SetmBool(this clsAllDataTypeEN objAllDataTypeEN, bool bolmBool, string strComparisonOp="")
	{
objAllDataTypeEN.mBool = bolmBool; //布尔型
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objAllDataTypeEN.dicFldComparisonOp.ContainsKey(conAllDataType.mBool) == false)
{
objAllDataTypeEN.dicFldComparisonOp.Add(conAllDataType.mBool, strComparisonOp);
}
else
{
objAllDataTypeEN.dicFldComparisonOp[conAllDataType.mBool] = strComparisonOp;
}
}
return objAllDataTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objAllDataTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsAllDataTypeEN SetmDouble(this clsAllDataTypeEN objAllDataTypeEN, double dblmDouble, string strComparisonOp="")
	{
objAllDataTypeEN.mDouble = dblmDouble; //双精度
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objAllDataTypeEN.dicFldComparisonOp.ContainsKey(conAllDataType.mDouble) == false)
{
objAllDataTypeEN.dicFldComparisonOp.Add(conAllDataType.mDouble, strComparisonOp);
}
else
{
objAllDataTypeEN.dicFldComparisonOp[conAllDataType.mDouble] = strComparisonOp;
}
}
return objAllDataTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objAllDataTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsAllDataTypeEN SetmFloat(this clsAllDataTypeEN objAllDataTypeEN, float fltmFloat, string strComparisonOp="")
	{
objAllDataTypeEN.mFloat = fltmFloat; //浮点型
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objAllDataTypeEN.dicFldComparisonOp.ContainsKey(conAllDataType.mFloat) == false)
{
objAllDataTypeEN.dicFldComparisonOp.Add(conAllDataType.mFloat, strComparisonOp);
}
else
{
objAllDataTypeEN.dicFldComparisonOp[conAllDataType.mFloat] = strComparisonOp;
}
}
return objAllDataTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objAllDataTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsAllDataTypeEN SetmDate(this clsAllDataTypeEN objAllDataTypeEN, string strmDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strmDate, 20, conAllDataType.mDate);
}
objAllDataTypeEN.mDate = strmDate; //日期型
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objAllDataTypeEN.dicFldComparisonOp.ContainsKey(conAllDataType.mDate) == false)
{
objAllDataTypeEN.dicFldComparisonOp.Add(conAllDataType.mDate, strComparisonOp);
}
else
{
objAllDataTypeEN.dicFldComparisonOp[conAllDataType.mDate] = strComparisonOp;
}
}
return objAllDataTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objAllDataTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsAllDataTypeEN SetOrderNum(this clsAllDataTypeEN objAllDataTypeEN, int intOrderNum, string strComparisonOp="")
	{
objAllDataTypeEN.OrderNum = intOrderNum; //排序
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objAllDataTypeEN.dicFldComparisonOp.ContainsKey(conAllDataType.OrderNum) == false)
{
objAllDataTypeEN.dicFldComparisonOp.Add(conAllDataType.OrderNum, strComparisonOp);
}
else
{
objAllDataTypeEN.dicFldComparisonOp[conAllDataType.OrderNum] = strComparisonOp;
}
}
return objAllDataTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objAllDataTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsAllDataTypeEN Set_IsDeleted(this clsAllDataTypeEN objAllDataTypeEN, bool bol_IsDeleted, string strComparisonOp="")
	{
objAllDataTypeEN._IsDeleted = bol_IsDeleted; //是否删除
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objAllDataTypeEN.dicFldComparisonOp.ContainsKey(conAllDataType._IsDeleted) == false)
{
objAllDataTypeEN.dicFldComparisonOp.Add(conAllDataType._IsDeleted, strComparisonOp);
}
else
{
objAllDataTypeEN.dicFldComparisonOp[conAllDataType._IsDeleted] = strComparisonOp;
}
}
return objAllDataTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objAllDataTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsAllDataTypeEN Set_DeletedDate(this clsAllDataTypeEN objAllDataTypeEN, string str_DeletedDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(str_DeletedDate, 50, conAllDataType._DeletedDate);
}
objAllDataTypeEN._DeletedDate = str_DeletedDate; //删除日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objAllDataTypeEN.dicFldComparisonOp.ContainsKey(conAllDataType._DeletedDate) == false)
{
objAllDataTypeEN.dicFldComparisonOp.Add(conAllDataType._DeletedDate, strComparisonOp);
}
else
{
objAllDataTypeEN.dicFldComparisonOp[conAllDataType._DeletedDate] = strComparisonOp;
}
}
return objAllDataTypeEN;
	}

 /// <summary>
 /// 修改记录存盘到数据表中
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_UpdateRecordEx)
 /// </summary>
 /// <param name = "objAllDataTypeEN">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool UpdateRecordEx(this clsAllDataTypeEN objAllDataTypeEN)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
try
{
//1、检查传进去的对象属性是否合法
objAllDataTypeEN.CheckPropertyNew();
clsAllDataTypeEN objAllDataType_Cond = new clsAllDataTypeEN();
string strCondition = objAllDataType_Cond
.SetmId(objAllDataTypeEN.mId, "<>")
.SetmString(objAllDataTypeEN.mString, "=")
.SetmInt(objAllDataTypeEN.mInt, "=")
.GetCombineCondition();
objAllDataTypeEN._IsCheckProperty = true;
bool bolIsExist = clsAllDataTypeBL.IsExistRecord(strCondition);
if (bolIsExist)
{
strMsg = "(mString_mInt)不能重复!";
throw new Exception(strMsg);
}
//4、把数据实体层的数据存贮到数据库中
objAllDataTypeEN.Update();
}
catch(Exception objException)
{
strMsg = "修改记录不成功!" + objException.Message;
throw new Exception(strMsg);
}
return true; 
}

 /// <summary>
 /// 编辑记录存盘到数据表中。如果存在相关记录就修改，不存在就添加
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_EditRecordEx)
 /// </summary>
 /// <param name = "objAllDataType">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool EditRecordEx(this clsAllDataTypeEN objAllDataType)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
clsAllDataTypeEN objAllDataType_Cond = new clsAllDataTypeEN();
string strCondition = objAllDataType_Cond
.SetmString(objAllDataType.mString, "=")
.SetmInt(objAllDataType.mInt, "=")
.GetCombineCondition();
objAllDataType._IsCheckProperty = true;
bool bolIsExist = clsAllDataTypeBL.IsExistRecord(strCondition);
if (bolIsExist)
{
objAllDataType.mId = clsAllDataTypeBL.GetFirstID_S(strCondition);
objAllDataType.UpdateWithCondition(strCondition);
}
else
{
objAllDataType.AddNewRecord();
}
return true; 
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_Update)
 /// </summary>
 /// <param name = "objAllDataTypeEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsAllDataTypeEN objAllDataTypeEN)
{
 if (objAllDataTypeEN.mId == 0)
 {
string strMsg = string.Format("(errid:Busi000095)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsAllDataTypeBL.AllDataTypeDA.UpdateBySql2(objAllDataTypeEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsAllDataTypeBL.ReFreshCache();

if (clsAllDataTypeBL.relatedActions != null)
{
clsAllDataTypeBL.relatedActions.UpdRelaTabDate(objAllDataTypeEN.mId, "SetUpdDate");
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
 /// <param name = "objAllDataTypeEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsAllDataTypeEN objAllDataTypeEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (objAllDataTypeEN.mId == 0)
 {
string strMsg = string.Format("(errid:Busi000087)修改记录时关键字不能为空!(带事务处理)(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsAllDataTypeBL.AllDataTypeDA.UpdateBySql2(objAllDataTypeEN, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsAllDataTypeBL.ReFreshCache();

if (clsAllDataTypeBL.relatedActions != null)
{
clsAllDataTypeBL.relatedActions.UpdRelaTabDate(objAllDataTypeEN.mId, "SetUpdDate");
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
 /// <param name = "objAllDataTypeEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsAllDataTypeEN objAllDataTypeEN, string strWhereCond)
{
try
{
bool bolResult = clsAllDataTypeBL.AllDataTypeDA.UpdateBySqlWithCondition(objAllDataTypeEN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsAllDataTypeBL.ReFreshCache();

if (clsAllDataTypeBL.relatedActions != null)
{
clsAllDataTypeBL.relatedActions.UpdRelaTabDate(objAllDataTypeEN.mId, "SetUpdDate");
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
 /// <param name = "objAllDataTypeEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsAllDataTypeEN objAllDataTypeEN, string strWhereCond, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
bool bolResult = clsAllDataTypeBL.AllDataTypeDA.UpdateBySqlWithConditionTransaction(objAllDataTypeEN, strWhereCond, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsAllDataTypeBL.ReFreshCache();

if (clsAllDataTypeBL.relatedActions != null)
{
clsAllDataTypeBL.relatedActions.UpdRelaTabDate(objAllDataTypeEN.mId, "SetUpdDate");
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
public static int Delete(this clsAllDataTypeEN objAllDataTypeEN)
{
try
{
int intRecNum = clsAllDataTypeBL.AllDataTypeDA.DelRecord(objAllDataTypeEN.mId);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsAllDataTypeBL.ReFreshCache();

if (clsAllDataTypeBL.relatedActions != null)
{
clsAllDataTypeBL.relatedActions.UpdRelaTabDate(objAllDataTypeEN.mId, "SetUpdDate");
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
 /// <param name = "objAllDataTypeENS">源对象</param>
 /// <param name = "objAllDataTypeENT">目标对象</param>
 public static void CopyTo(this clsAllDataTypeEN objAllDataTypeENS, clsAllDataTypeEN objAllDataTypeENT)
{
try
{
objAllDataTypeENT.mId = objAllDataTypeENS.mId; //mId
objAllDataTypeENT.mString = objAllDataTypeENS.mString; //字符串
objAllDataTypeENT.mInt = objAllDataTypeENS.mInt; //整型
objAllDataTypeENT.mLong = objAllDataTypeENS.mLong; //长整型
objAllDataTypeENT.mBool = objAllDataTypeENS.mBool; //布尔型
objAllDataTypeENT.mDouble = objAllDataTypeENS.mDouble; //双精度
objAllDataTypeENT.mFloat = objAllDataTypeENS.mFloat; //浮点型
objAllDataTypeENT.mDate = objAllDataTypeENS.mDate; //日期型
objAllDataTypeENT.OrderNum = objAllDataTypeENS.OrderNum; //排序
objAllDataTypeENT._IsDeleted = objAllDataTypeENS._IsDeleted; //是否删除
objAllDataTypeENT._DeletedDate = objAllDataTypeENS._DeletedDate; //删除日期
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
 /// <param name = "objAllDataTypeENS">源对象</param>
 /// <returns>目标对象=>clsAllDataTypeEN:objAllDataTypeENT</returns>
 public static clsAllDataTypeEN CopyTo(this clsAllDataTypeEN objAllDataTypeENS)
{
try
{
 clsAllDataTypeEN objAllDataTypeENT = new clsAllDataTypeEN()
{
mId = objAllDataTypeENS.mId, //mId
mString = objAllDataTypeENS.mString, //字符串
mInt = objAllDataTypeENS.mInt, //整型
mLong = objAllDataTypeENS.mLong, //长整型
mBool = objAllDataTypeENS.mBool, //布尔型
mDouble = objAllDataTypeENS.mDouble, //双精度
mFloat = objAllDataTypeENS.mFloat, //浮点型
mDate = objAllDataTypeENS.mDate, //日期型
OrderNum = objAllDataTypeENS.OrderNum, //排序
_IsDeleted = objAllDataTypeENS._IsDeleted, //是否删除
_DeletedDate = objAllDataTypeENS._DeletedDate, //删除日期
};
 return objAllDataTypeENT;
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
public static void CheckPropertyNew(this clsAllDataTypeEN objAllDataTypeEN)
{
 clsAllDataTypeBL.AllDataTypeDA.CheckPropertyNew(objAllDataTypeEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(this clsAllDataTypeEN objAllDataTypeEN)
{
 clsAllDataTypeBL.AllDataTypeDA.CheckProperty4Condition(objAllDataTypeEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsAllDataTypeEN objAllDataType_Cond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objAllDataType_Cond.IsUpdated(conAllDataType.mId) == true)
{
string strComparisonOp_mId = objAllDataType_Cond.dicFldComparisonOp[conAllDataType.mId];
strWhereCond += string.Format(" And {0} {2} {1}", conAllDataType.mId, objAllDataType_Cond.mId, strComparisonOp_mId);
}
if (objAllDataType_Cond.IsUpdated(conAllDataType.mString) == true)
{
string strComparisonOp_mString = objAllDataType_Cond.dicFldComparisonOp[conAllDataType.mString];
strWhereCond += string.Format(" And {0} {2} '{1}'", conAllDataType.mString, objAllDataType_Cond.mString, strComparisonOp_mString);
}
if (objAllDataType_Cond.IsUpdated(conAllDataType.mInt) == true)
{
string strComparisonOp_mInt = objAllDataType_Cond.dicFldComparisonOp[conAllDataType.mInt];
strWhereCond += string.Format(" And {0} {2} {1}", conAllDataType.mInt, objAllDataType_Cond.mInt, strComparisonOp_mInt);
}
if (objAllDataType_Cond.IsUpdated(conAllDataType.mLong) == true)
{
string strComparisonOp_mLong = objAllDataType_Cond.dicFldComparisonOp[conAllDataType.mLong];
strWhereCond += string.Format(" And {0} {2} {1}", conAllDataType.mLong, objAllDataType_Cond.mLong, strComparisonOp_mLong);
}
if (objAllDataType_Cond.IsUpdated(conAllDataType.mBool) == true)
{
if (objAllDataType_Cond.mBool == true)
{
strWhereCond += string.Format(" And {0} = '1'", conAllDataType.mBool);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conAllDataType.mBool);
}
}
if (objAllDataType_Cond.IsUpdated(conAllDataType.mDouble) == true)
{
string strComparisonOp_mDouble = objAllDataType_Cond.dicFldComparisonOp[conAllDataType.mDouble];
strWhereCond += string.Format(" And {0} {2} {1}", conAllDataType.mDouble, objAllDataType_Cond.mDouble, strComparisonOp_mDouble);
}
if (objAllDataType_Cond.IsUpdated(conAllDataType.mFloat) == true)
{
string strComparisonOp_mFloat = objAllDataType_Cond.dicFldComparisonOp[conAllDataType.mFloat];
strWhereCond += string.Format(" And {0} {2} {1}", conAllDataType.mFloat, objAllDataType_Cond.mFloat, strComparisonOp_mFloat);
}
if (objAllDataType_Cond.IsUpdated(conAllDataType.mDate) == true)
{
string strComparisonOp_mDate = objAllDataType_Cond.dicFldComparisonOp[conAllDataType.mDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conAllDataType.mDate, objAllDataType_Cond.mDate, strComparisonOp_mDate);
}
if (objAllDataType_Cond.IsUpdated(conAllDataType.OrderNum) == true)
{
string strComparisonOp_OrderNum = objAllDataType_Cond.dicFldComparisonOp[conAllDataType.OrderNum];
strWhereCond += string.Format(" And {0} {2} {1}", conAllDataType.OrderNum, objAllDataType_Cond.OrderNum, strComparisonOp_OrderNum);
}
if (objAllDataType_Cond.IsUpdated(conAllDataType._IsDeleted) == true)
{
if (objAllDataType_Cond._IsDeleted == true)
{
strWhereCond += string.Format(" And {0} = '1'", conAllDataType._IsDeleted);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conAllDataType._IsDeleted);
}
}
if (objAllDataType_Cond.IsUpdated(conAllDataType._DeletedDate) == true)
{
string strComparisonOp__DeletedDate = objAllDataType_Cond.dicFldComparisonOp[conAllDataType._DeletedDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conAllDataType._DeletedDate, objAllDataType_Cond._DeletedDate, strComparisonOp__DeletedDate);
}
 return strWhereCond;
}

 /// <summary>
 /// 检查唯一性(Uniqueness)--AllDataType(各种数据类型), 如果不唯一,即存在相同的记录,就返回False
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckUniquenessV3)
 /// </summary>
 /// <param name = "objAllDataTypeEN">要求唯一的对象</param>
 /// <returns></returns>
public static bool CheckAllDataTypeUniqueness(this clsAllDataTypeEN objAllDataTypeEN)
{
//检测记录是否存在
bool bolIsUniqueness;
if (objAllDataTypeEN == null) return true;
if (objAllDataTypeEN.mId == 0)
{
bolIsUniqueness = clsAllDataTypeBL.AllDataTypeDA.CheckAllDataTypeUniqueness();
}
else
{
bolIsUniqueness = clsAllDataTypeBL.AllDataTypeDA.CheckAllDataTypeUniqueness(objAllDataTypeEN.mId);
}
return bolIsUniqueness;
}

 /// <summary>
 /// 检查唯一性(Uniqueness)--AllDataType(各种数据类型), 如果不唯一,即存在相同的记录,就返回False
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckConstraint)
 /// </summary>
 /// <param name = "objAllDataTypeEN">要求唯一的对象</param>
 /// <returns></returns>
public static bool CheckUniqueness_mString_mInt(this clsAllDataTypeEN objAllDataTypeEN)
{
//检测记录是否存在
bool bolIsUniqueness;
StringBuilder sbCondition = new StringBuilder();
if (objAllDataTypeEN == null) return true;
if (objAllDataTypeEN.mId == 0)
{
sbCondition.AppendFormat("1 = 1");
 if (objAllDataTypeEN.mString == null)
{
 sbCondition.AppendFormat(" and mString is null", objAllDataTypeEN.mString);
}
else
{
 sbCondition.AppendFormat(" and mString = '{0}'", objAllDataTypeEN.mString);
}
 if (objAllDataTypeEN.mInt == null)
{
 sbCondition.AppendFormat(" and mInt is null", objAllDataTypeEN.mInt);
}
else
{
 sbCondition.AppendFormat(" and mInt = '{0}'", objAllDataTypeEN.mInt);
}
if (clsAllDataTypeBL.IsExistRecord(sbCondition.ToString())  ==  true)
{
 bolIsUniqueness = false;
}
else
{
 bolIsUniqueness = true;
}
}
 else {
sbCondition.AppendFormat("mId !=  {0}", objAllDataTypeEN.mId);
 sbCondition.AppendFormat(" and mString = '{0}'", objAllDataTypeEN.mString);
 sbCondition.AppendFormat(" and mInt = '{0}'", objAllDataTypeEN.mInt);
if (clsAllDataTypeBL.IsExistRecord(sbCondition.ToString())  ==  true)
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
 /// 检查唯一性(Uniqueness)--AllDataType(各种数据类型), 如果不唯一,即存在相同的记录,就返回False
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetConditionString4Constraint)
 /// </summary>
 /// <param name = "objAllDataTypeEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr_mString_mInt(this clsAllDataTypeEN objAllDataTypeEN)
{
//检测记录是否存在
StringBuilder sbCondition = new StringBuilder();
if (objAllDataTypeEN == null) return "";
if (objAllDataTypeEN.mId == 0)
{
sbCondition.AppendFormat("1 = 1");
 if (objAllDataTypeEN.mString == null)
{
 sbCondition.AppendFormat(" and mString is null", objAllDataTypeEN.mString);
}
else
{
 sbCondition.AppendFormat(" and mString = '{0}'", objAllDataTypeEN.mString);
}
 if (objAllDataTypeEN.mInt == null)
{
 sbCondition.AppendFormat(" and mInt is null", objAllDataTypeEN.mInt);
}
else
{
 sbCondition.AppendFormat(" and mInt = '{0}'", objAllDataTypeEN.mInt);
}
return sbCondition.ToString();
}
 else {
sbCondition.AppendFormat("mId !=  {0}", objAllDataTypeEN.mId);
 sbCondition.AppendFormat(" and mString = '{0}'", objAllDataTypeEN.mString);
 sbCondition.AppendFormat(" and mInt = '{0}'", objAllDataTypeEN.mInt);
 return sbCondition.ToString();
}
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时，对相关表执行相应的操作，此处定义一个类，在外面可以扩展该类的相关函数，达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_AllDataType
{
public virtual bool UpdRelaTabDate(long lngmId, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// 各种数据类型(AllDataType)
 /// 数据源类型:表
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsAllDataTypeBL
{
public static RelatedActions_AllDataType relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsAllDataTypeDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式，使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsAllDataTypeDA AllDataTypeDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsAllDataTypeDA();
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
 public clsAllDataTypeBL()
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
throw new Exception("请初始化用于记录日志的clsSysParaEN.objLog对象！");
}
if (clsSysParaEN.objErrorLog == null)
{
throw new Exception("请初始化用于记录错误日志的clsSysParaEN.objErrorLog对象！");
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
if (string.IsNullOrEmpty(clsAllDataTypeEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsAllDataTypeEN._ConnectString);
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
public static DataTable GetDataTable_AllDataType(string strWhereCond)
{
DataTable objDT;
try
{
objDT = AllDataTypeDA.GetDataTable_AllDataType(strWhereCond);
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
objDT = AllDataTypeDA.GetDataTable(strWhereCond);
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
objDT = AllDataTypeDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = AllDataTypeDA.GetDataTable(strWhereCond, strTabName);
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
objDT = AllDataTypeDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = AllDataTypeDA.GetDataTable_Top(objTopPara);
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
objDT = AllDataTypeDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = AllDataTypeDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = AllDataTypeDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
public static List<clsAllDataTypeEN> GetObjLstByMIdLst(List<long> arrMIdLst)
{
List<clsAllDataTypeEN> arrObjLst = new List<clsAllDataTypeEN>(); 
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
	clsAllDataTypeEN objAllDataTypeEN = new clsAllDataTypeEN();
try
{
objAllDataTypeEN.mId = Int32.Parse(objRow[conAllDataType.mId].ToString().Trim()); //mId
objAllDataTypeEN.mString = objRow[conAllDataType.mString] == DBNull.Value ? null : objRow[conAllDataType.mString].ToString().Trim(); //字符串
objAllDataTypeEN.mInt = clsEntityBase2.TransNullToInt_S(objRow[conAllDataType.mInt] == DBNull.Value ? null : objRow[conAllDataType.mInt].ToString().Trim()); //整型
objAllDataTypeEN.mLong = clsEntityBase2.TransNullToInt_S(objRow[conAllDataType.mLong] == DBNull.Value ? null : objRow[conAllDataType.mLong].ToString().Trim()); //长整型
objAllDataTypeEN.mBool = clsEntityBase2.TransNullToBool_S(objRow[conAllDataType.mBool] == DBNull.Value ? null : objRow[conAllDataType.mBool].ToString().Trim()); //布尔型
objAllDataTypeEN.mDouble = clsEntityBase2.TransNullToDouble_S(objRow[conAllDataType.mDouble] == DBNull.Value ? null : objRow[conAllDataType.mDouble].ToString().Trim()); //双精度
objAllDataTypeEN.mFloat = clsEntityBase2.TransNullToFloat_S(objRow[conAllDataType.mFloat] == DBNull.Value ? null : objRow[conAllDataType.mFloat].ToString().Trim()); //浮点型
objAllDataTypeEN.mDate = objRow[conAllDataType.mDate] == DBNull.Value ? null : objRow[conAllDataType.mDate].ToString().Trim(); //日期型
objAllDataTypeEN.OrderNum = clsEntityBase2.TransNullToInt_S(objRow[conAllDataType.OrderNum] == DBNull.Value ? null : objRow[conAllDataType.OrderNum].ToString().Trim()); //排序
objAllDataTypeEN._IsDeleted = clsEntityBase2.TransNullToBool_S(objRow[conAllDataType._IsDeleted] == DBNull.Value ? null : objRow[conAllDataType._IsDeleted].ToString().Trim()); //是否删除
objAllDataTypeEN._DeletedDate = objRow[conAllDataType._DeletedDate] == DBNull.Value ? null : objRow[conAllDataType._DeletedDate].ToString().Trim(); //删除日期
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objAllDataTypeEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objAllDataTypeEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLst_Cache)
 /// </summary>
 /// <param name = "arrMIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsAllDataTypeEN> GetObjLstByMIdLst_Cache(List<long> arrMIdLst)
{
string strKey = string.Format("{0}", clsAllDataTypeEN._CurrTabName_S);
List<clsAllDataTypeEN> arrAllDataTypeObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsAllDataTypeEN> arrAllDataTypeObjLst_Sel =
arrAllDataTypeObjLst_Cache
.Where(x => arrMIdLst.Contains(x.mId));
return arrAllDataTypeObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsAllDataTypeEN> GetObjLst(string strWhereCond)
{
List<clsAllDataTypeEN> arrObjLst = new List<clsAllDataTypeEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsAllDataTypeEN objAllDataTypeEN = new clsAllDataTypeEN();
try
{
objAllDataTypeEN.mId = Int32.Parse(objRow[conAllDataType.mId].ToString().Trim()); //mId
objAllDataTypeEN.mString = objRow[conAllDataType.mString] == DBNull.Value ? null : objRow[conAllDataType.mString].ToString().Trim(); //字符串
objAllDataTypeEN.mInt = clsEntityBase2.TransNullToInt_S(objRow[conAllDataType.mInt] == DBNull.Value ? null : objRow[conAllDataType.mInt].ToString().Trim()); //整型
objAllDataTypeEN.mLong = clsEntityBase2.TransNullToInt_S(objRow[conAllDataType.mLong] == DBNull.Value ? null : objRow[conAllDataType.mLong].ToString().Trim()); //长整型
objAllDataTypeEN.mBool = clsEntityBase2.TransNullToBool_S(objRow[conAllDataType.mBool] == DBNull.Value ? null : objRow[conAllDataType.mBool].ToString().Trim()); //布尔型
objAllDataTypeEN.mDouble = clsEntityBase2.TransNullToDouble_S(objRow[conAllDataType.mDouble] == DBNull.Value ? null : objRow[conAllDataType.mDouble].ToString().Trim()); //双精度
objAllDataTypeEN.mFloat = clsEntityBase2.TransNullToFloat_S(objRow[conAllDataType.mFloat] == DBNull.Value ? null : objRow[conAllDataType.mFloat].ToString().Trim()); //浮点型
objAllDataTypeEN.mDate = objRow[conAllDataType.mDate] == DBNull.Value ? null : objRow[conAllDataType.mDate].ToString().Trim(); //日期型
objAllDataTypeEN.OrderNum = clsEntityBase2.TransNullToInt_S(objRow[conAllDataType.OrderNum] == DBNull.Value ? null : objRow[conAllDataType.OrderNum].ToString().Trim()); //排序
objAllDataTypeEN._IsDeleted = clsEntityBase2.TransNullToBool_S(objRow[conAllDataType._IsDeleted] == DBNull.Value ? null : objRow[conAllDataType._IsDeleted].ToString().Trim()); //是否删除
objAllDataTypeEN._DeletedDate = objRow[conAllDataType._DeletedDate] == DBNull.Value ? null : objRow[conAllDataType._DeletedDate].ToString().Trim(); //删除日期
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objAllDataTypeEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objAllDataTypeEN);
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
public static List<clsAllDataTypeEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsAllDataTypeEN> arrObjLst = new List<clsAllDataTypeEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsAllDataTypeEN objAllDataTypeEN = new clsAllDataTypeEN();
try
{
objAllDataTypeEN.mId = Int32.Parse(objRow[conAllDataType.mId].ToString().Trim()); //mId
objAllDataTypeEN.mString = objRow[conAllDataType.mString] == DBNull.Value ? null : objRow[conAllDataType.mString].ToString().Trim(); //字符串
objAllDataTypeEN.mInt = clsEntityBase2.TransNullToInt_S(objRow[conAllDataType.mInt] == DBNull.Value ? null : objRow[conAllDataType.mInt].ToString().Trim()); //整型
objAllDataTypeEN.mLong = clsEntityBase2.TransNullToInt_S(objRow[conAllDataType.mLong] == DBNull.Value ? null : objRow[conAllDataType.mLong].ToString().Trim()); //长整型
objAllDataTypeEN.mBool = clsEntityBase2.TransNullToBool_S(objRow[conAllDataType.mBool] == DBNull.Value ? null : objRow[conAllDataType.mBool].ToString().Trim()); //布尔型
objAllDataTypeEN.mDouble = clsEntityBase2.TransNullToDouble_S(objRow[conAllDataType.mDouble] == DBNull.Value ? null : objRow[conAllDataType.mDouble].ToString().Trim()); //双精度
objAllDataTypeEN.mFloat = clsEntityBase2.TransNullToFloat_S(objRow[conAllDataType.mFloat] == DBNull.Value ? null : objRow[conAllDataType.mFloat].ToString().Trim()); //浮点型
objAllDataTypeEN.mDate = objRow[conAllDataType.mDate] == DBNull.Value ? null : objRow[conAllDataType.mDate].ToString().Trim(); //日期型
objAllDataTypeEN.OrderNum = clsEntityBase2.TransNullToInt_S(objRow[conAllDataType.OrderNum] == DBNull.Value ? null : objRow[conAllDataType.OrderNum].ToString().Trim()); //排序
objAllDataTypeEN._IsDeleted = clsEntityBase2.TransNullToBool_S(objRow[conAllDataType._IsDeleted] == DBNull.Value ? null : objRow[conAllDataType._IsDeleted].ToString().Trim()); //是否删除
objAllDataTypeEN._DeletedDate = objRow[conAllDataType._DeletedDate] == DBNull.Value ? null : objRow[conAllDataType._DeletedDate].ToString().Trim(); //删除日期
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objAllDataTypeEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objAllDataTypeEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLst_Cache)
 /// </summary>
 /// <param name = "objAllDataType_Cond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsAllDataTypeEN> GetSubObjLst_Cache(clsAllDataTypeEN objAllDataType_Cond)
{
List<clsAllDataTypeEN> arrObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsAllDataTypeEN> arrObjLst_Sel = arrObjLst_Cache;
foreach (string strFldName in conAllDataType.AttributeName)
{
if (objAllDataType_Cond.IsUpdated(strFldName) == false) continue;
if (objAllDataType_Cond.dicFldComparisonOp == null)
{
arrObjLst_Sel = arrObjLst_Sel.Where(x => x[strFldName].ToString() == objAllDataType_Cond[strFldName].ToString());
}
else
{
if (objAllDataType_Cond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objAllDataType_Cond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLst_Sel = arrObjLst_Sel.Where(x => x[strFldName].ToString() == objAllDataType_Cond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLst_Sel = arrObjLst_Sel.Where(x => x[strFldName].ToString().Contains(objAllDataType_Cond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLst_Sel = arrObjLst_Sel.Where(x => x[strFldName].ToString().Length > int.Parse(objAllDataType_Cond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLst_Sel = arrObjLst_Sel.Where(x => x[strFldName].ToString().Length <= int.Parse(objAllDataType_Cond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLst_Sel = arrObjLst_Sel.Where(x => x[strFldName].ToString().Length >= int.Parse(objAllDataType_Cond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLst_Sel = arrObjLst_Sel.Where(x => x[strFldName].ToString().Length < int.Parse(objAllDataType_Cond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLst_Sel = arrObjLst_Sel.Where(x => x[strFldName].ToString().Length == int.Parse(objAllDataType_Cond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objAllDataType_Cond[strFldName].ToString().Split(",".ToCharArray());
arrObjLst_Sel = arrObjLst_Sel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLst_Sel = arrObjLst_Sel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objAllDataType_Cond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLst_Sel = arrObjLst_Sel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objAllDataType_Cond[strFldName]));
}
}
}
return arrObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByTabName)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsAllDataTypeEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsAllDataTypeEN> arrObjLst = new List<clsAllDataTypeEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsAllDataTypeEN objAllDataTypeEN = new clsAllDataTypeEN();
try
{
objAllDataTypeEN.mId = Int32.Parse(objRow[conAllDataType.mId].ToString().Trim()); //mId
objAllDataTypeEN.mString = objRow[conAllDataType.mString] == DBNull.Value ? null : objRow[conAllDataType.mString].ToString().Trim(); //字符串
objAllDataTypeEN.mInt = clsEntityBase2.TransNullToInt_S(objRow[conAllDataType.mInt] == DBNull.Value ? null : objRow[conAllDataType.mInt].ToString().Trim()); //整型
objAllDataTypeEN.mLong = clsEntityBase2.TransNullToInt_S(objRow[conAllDataType.mLong] == DBNull.Value ? null : objRow[conAllDataType.mLong].ToString().Trim()); //长整型
objAllDataTypeEN.mBool = clsEntityBase2.TransNullToBool_S(objRow[conAllDataType.mBool] == DBNull.Value ? null : objRow[conAllDataType.mBool].ToString().Trim()); //布尔型
objAllDataTypeEN.mDouble = clsEntityBase2.TransNullToDouble_S(objRow[conAllDataType.mDouble] == DBNull.Value ? null : objRow[conAllDataType.mDouble].ToString().Trim()); //双精度
objAllDataTypeEN.mFloat = clsEntityBase2.TransNullToFloat_S(objRow[conAllDataType.mFloat] == DBNull.Value ? null : objRow[conAllDataType.mFloat].ToString().Trim()); //浮点型
objAllDataTypeEN.mDate = objRow[conAllDataType.mDate] == DBNull.Value ? null : objRow[conAllDataType.mDate].ToString().Trim(); //日期型
objAllDataTypeEN.OrderNum = clsEntityBase2.TransNullToInt_S(objRow[conAllDataType.OrderNum] == DBNull.Value ? null : objRow[conAllDataType.OrderNum].ToString().Trim()); //排序
objAllDataTypeEN._IsDeleted = clsEntityBase2.TransNullToBool_S(objRow[conAllDataType._IsDeleted] == DBNull.Value ? null : objRow[conAllDataType._IsDeleted].ToString().Trim()); //是否删除
objAllDataTypeEN._DeletedDate = objRow[conAllDataType._DeletedDate] == DBNull.Value ? null : objRow[conAllDataType._DeletedDate].ToString().Trim(); //删除日期
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objAllDataTypeEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objAllDataTypeEN);
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
public static List<clsAllDataTypeEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsAllDataTypeEN> arrObjLst = new List<clsAllDataTypeEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsAllDataTypeEN objAllDataTypeEN = new clsAllDataTypeEN();
try
{
objAllDataTypeEN.mId = Int32.Parse(objRow[conAllDataType.mId].ToString().Trim()); //mId
objAllDataTypeEN.mString = objRow[conAllDataType.mString] == DBNull.Value ? null : objRow[conAllDataType.mString].ToString().Trim(); //字符串
objAllDataTypeEN.mInt = clsEntityBase2.TransNullToInt_S(objRow[conAllDataType.mInt] == DBNull.Value ? null : objRow[conAllDataType.mInt].ToString().Trim()); //整型
objAllDataTypeEN.mLong = clsEntityBase2.TransNullToInt_S(objRow[conAllDataType.mLong] == DBNull.Value ? null : objRow[conAllDataType.mLong].ToString().Trim()); //长整型
objAllDataTypeEN.mBool = clsEntityBase2.TransNullToBool_S(objRow[conAllDataType.mBool] == DBNull.Value ? null : objRow[conAllDataType.mBool].ToString().Trim()); //布尔型
objAllDataTypeEN.mDouble = clsEntityBase2.TransNullToDouble_S(objRow[conAllDataType.mDouble] == DBNull.Value ? null : objRow[conAllDataType.mDouble].ToString().Trim()); //双精度
objAllDataTypeEN.mFloat = clsEntityBase2.TransNullToFloat_S(objRow[conAllDataType.mFloat] == DBNull.Value ? null : objRow[conAllDataType.mFloat].ToString().Trim()); //浮点型
objAllDataTypeEN.mDate = objRow[conAllDataType.mDate] == DBNull.Value ? null : objRow[conAllDataType.mDate].ToString().Trim(); //日期型
objAllDataTypeEN.OrderNum = clsEntityBase2.TransNullToInt_S(objRow[conAllDataType.OrderNum] == DBNull.Value ? null : objRow[conAllDataType.OrderNum].ToString().Trim()); //排序
objAllDataTypeEN._IsDeleted = clsEntityBase2.TransNullToBool_S(objRow[conAllDataType._IsDeleted] == DBNull.Value ? null : objRow[conAllDataType._IsDeleted].ToString().Trim()); //是否删除
objAllDataTypeEN._DeletedDate = objRow[conAllDataType._DeletedDate] == DBNull.Value ? null : objRow[conAllDataType._DeletedDate].ToString().Trim(); //删除日期
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objAllDataTypeEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objAllDataTypeEN);
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
List<clsAllDataTypeEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsAllDataTypeEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsAllDataTypeEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsAllDataTypeEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsAllDataTypeEN> arrObjLst = new List<clsAllDataTypeEN>(); 
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
	clsAllDataTypeEN objAllDataTypeEN = new clsAllDataTypeEN();
try
{
objAllDataTypeEN.mId = Int32.Parse(objRow[conAllDataType.mId].ToString().Trim()); //mId
objAllDataTypeEN.mString = objRow[conAllDataType.mString] == DBNull.Value ? null : objRow[conAllDataType.mString].ToString().Trim(); //字符串
objAllDataTypeEN.mInt = clsEntityBase2.TransNullToInt_S(objRow[conAllDataType.mInt] == DBNull.Value ? null : objRow[conAllDataType.mInt].ToString().Trim()); //整型
objAllDataTypeEN.mLong = clsEntityBase2.TransNullToInt_S(objRow[conAllDataType.mLong] == DBNull.Value ? null : objRow[conAllDataType.mLong].ToString().Trim()); //长整型
objAllDataTypeEN.mBool = clsEntityBase2.TransNullToBool_S(objRow[conAllDataType.mBool] == DBNull.Value ? null : objRow[conAllDataType.mBool].ToString().Trim()); //布尔型
objAllDataTypeEN.mDouble = clsEntityBase2.TransNullToDouble_S(objRow[conAllDataType.mDouble] == DBNull.Value ? null : objRow[conAllDataType.mDouble].ToString().Trim()); //双精度
objAllDataTypeEN.mFloat = clsEntityBase2.TransNullToFloat_S(objRow[conAllDataType.mFloat] == DBNull.Value ? null : objRow[conAllDataType.mFloat].ToString().Trim()); //浮点型
objAllDataTypeEN.mDate = objRow[conAllDataType.mDate] == DBNull.Value ? null : objRow[conAllDataType.mDate].ToString().Trim(); //日期型
objAllDataTypeEN.OrderNum = clsEntityBase2.TransNullToInt_S(objRow[conAllDataType.OrderNum] == DBNull.Value ? null : objRow[conAllDataType.OrderNum].ToString().Trim()); //排序
objAllDataTypeEN._IsDeleted = clsEntityBase2.TransNullToBool_S(objRow[conAllDataType._IsDeleted] == DBNull.Value ? null : objRow[conAllDataType._IsDeleted].ToString().Trim()); //是否删除
objAllDataTypeEN._DeletedDate = objRow[conAllDataType._DeletedDate] == DBNull.Value ? null : objRow[conAllDataType._DeletedDate].ToString().Trim(); //删除日期
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objAllDataTypeEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objAllDataTypeEN);
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
public static List<clsAllDataTypeEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsAllDataTypeEN> arrObjLst = new List<clsAllDataTypeEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsAllDataTypeEN objAllDataTypeEN = new clsAllDataTypeEN();
try
{
objAllDataTypeEN.mId = Int32.Parse(objRow[conAllDataType.mId].ToString().Trim()); //mId
objAllDataTypeEN.mString = objRow[conAllDataType.mString] == DBNull.Value ? null : objRow[conAllDataType.mString].ToString().Trim(); //字符串
objAllDataTypeEN.mInt = clsEntityBase2.TransNullToInt_S(objRow[conAllDataType.mInt] == DBNull.Value ? null : objRow[conAllDataType.mInt].ToString().Trim()); //整型
objAllDataTypeEN.mLong = clsEntityBase2.TransNullToInt_S(objRow[conAllDataType.mLong] == DBNull.Value ? null : objRow[conAllDataType.mLong].ToString().Trim()); //长整型
objAllDataTypeEN.mBool = clsEntityBase2.TransNullToBool_S(objRow[conAllDataType.mBool] == DBNull.Value ? null : objRow[conAllDataType.mBool].ToString().Trim()); //布尔型
objAllDataTypeEN.mDouble = clsEntityBase2.TransNullToDouble_S(objRow[conAllDataType.mDouble] == DBNull.Value ? null : objRow[conAllDataType.mDouble].ToString().Trim()); //双精度
objAllDataTypeEN.mFloat = clsEntityBase2.TransNullToFloat_S(objRow[conAllDataType.mFloat] == DBNull.Value ? null : objRow[conAllDataType.mFloat].ToString().Trim()); //浮点型
objAllDataTypeEN.mDate = objRow[conAllDataType.mDate] == DBNull.Value ? null : objRow[conAllDataType.mDate].ToString().Trim(); //日期型
objAllDataTypeEN.OrderNum = clsEntityBase2.TransNullToInt_S(objRow[conAllDataType.OrderNum] == DBNull.Value ? null : objRow[conAllDataType.OrderNum].ToString().Trim()); //排序
objAllDataTypeEN._IsDeleted = clsEntityBase2.TransNullToBool_S(objRow[conAllDataType._IsDeleted] == DBNull.Value ? null : objRow[conAllDataType._IsDeleted].ToString().Trim()); //是否删除
objAllDataTypeEN._DeletedDate = objRow[conAllDataType._DeletedDate] == DBNull.Value ? null : objRow[conAllDataType._DeletedDate].ToString().Trim(); //删除日期
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objAllDataTypeEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objAllDataTypeEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsAllDataTypeEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsAllDataTypeEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsAllDataTypeEN> arrObjLst = new List<clsAllDataTypeEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsAllDataTypeEN objAllDataTypeEN = new clsAllDataTypeEN();
try
{
objAllDataTypeEN.mId = Int32.Parse(objRow[conAllDataType.mId].ToString().Trim()); //mId
objAllDataTypeEN.mString = objRow[conAllDataType.mString] == DBNull.Value ? null : objRow[conAllDataType.mString].ToString().Trim(); //字符串
objAllDataTypeEN.mInt = clsEntityBase2.TransNullToInt_S(objRow[conAllDataType.mInt] == DBNull.Value ? null : objRow[conAllDataType.mInt].ToString().Trim()); //整型
objAllDataTypeEN.mLong = clsEntityBase2.TransNullToInt_S(objRow[conAllDataType.mLong] == DBNull.Value ? null : objRow[conAllDataType.mLong].ToString().Trim()); //长整型
objAllDataTypeEN.mBool = clsEntityBase2.TransNullToBool_S(objRow[conAllDataType.mBool] == DBNull.Value ? null : objRow[conAllDataType.mBool].ToString().Trim()); //布尔型
objAllDataTypeEN.mDouble = clsEntityBase2.TransNullToDouble_S(objRow[conAllDataType.mDouble] == DBNull.Value ? null : objRow[conAllDataType.mDouble].ToString().Trim()); //双精度
objAllDataTypeEN.mFloat = clsEntityBase2.TransNullToFloat_S(objRow[conAllDataType.mFloat] == DBNull.Value ? null : objRow[conAllDataType.mFloat].ToString().Trim()); //浮点型
objAllDataTypeEN.mDate = objRow[conAllDataType.mDate] == DBNull.Value ? null : objRow[conAllDataType.mDate].ToString().Trim(); //日期型
objAllDataTypeEN.OrderNum = clsEntityBase2.TransNullToInt_S(objRow[conAllDataType.OrderNum] == DBNull.Value ? null : objRow[conAllDataType.OrderNum].ToString().Trim()); //排序
objAllDataTypeEN._IsDeleted = clsEntityBase2.TransNullToBool_S(objRow[conAllDataType._IsDeleted] == DBNull.Value ? null : objRow[conAllDataType._IsDeleted].ToString().Trim()); //是否删除
objAllDataTypeEN._DeletedDate = objRow[conAllDataType._DeletedDate] == DBNull.Value ? null : objRow[conAllDataType._DeletedDate].ToString().Trim(); //删除日期
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objAllDataTypeEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objAllDataTypeEN);
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
public static List<clsAllDataTypeEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsAllDataTypeEN> arrObjLst = new List<clsAllDataTypeEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsAllDataTypeEN objAllDataTypeEN = new clsAllDataTypeEN();
try
{
objAllDataTypeEN.mId = Int32.Parse(objRow[conAllDataType.mId].ToString().Trim()); //mId
objAllDataTypeEN.mString = objRow[conAllDataType.mString] == DBNull.Value ? null : objRow[conAllDataType.mString].ToString().Trim(); //字符串
objAllDataTypeEN.mInt = clsEntityBase2.TransNullToInt_S(objRow[conAllDataType.mInt] == DBNull.Value ? null : objRow[conAllDataType.mInt].ToString().Trim()); //整型
objAllDataTypeEN.mLong = clsEntityBase2.TransNullToInt_S(objRow[conAllDataType.mLong] == DBNull.Value ? null : objRow[conAllDataType.mLong].ToString().Trim()); //长整型
objAllDataTypeEN.mBool = clsEntityBase2.TransNullToBool_S(objRow[conAllDataType.mBool] == DBNull.Value ? null : objRow[conAllDataType.mBool].ToString().Trim()); //布尔型
objAllDataTypeEN.mDouble = clsEntityBase2.TransNullToDouble_S(objRow[conAllDataType.mDouble] == DBNull.Value ? null : objRow[conAllDataType.mDouble].ToString().Trim()); //双精度
objAllDataTypeEN.mFloat = clsEntityBase2.TransNullToFloat_S(objRow[conAllDataType.mFloat] == DBNull.Value ? null : objRow[conAllDataType.mFloat].ToString().Trim()); //浮点型
objAllDataTypeEN.mDate = objRow[conAllDataType.mDate] == DBNull.Value ? null : objRow[conAllDataType.mDate].ToString().Trim(); //日期型
objAllDataTypeEN.OrderNum = clsEntityBase2.TransNullToInt_S(objRow[conAllDataType.OrderNum] == DBNull.Value ? null : objRow[conAllDataType.OrderNum].ToString().Trim()); //排序
objAllDataTypeEN._IsDeleted = clsEntityBase2.TransNullToBool_S(objRow[conAllDataType._IsDeleted] == DBNull.Value ? null : objRow[conAllDataType._IsDeleted].ToString().Trim()); //是否删除
objAllDataTypeEN._DeletedDate = objRow[conAllDataType._DeletedDate] == DBNull.Value ? null : objRow[conAllDataType._DeletedDate].ToString().Trim(); //删除日期
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objAllDataTypeEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objAllDataTypeEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsAllDataTypeEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsAllDataTypeEN> arrObjLst = new List<clsAllDataTypeEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsAllDataTypeEN objAllDataTypeEN = new clsAllDataTypeEN();
try
{
objAllDataTypeEN.mId = Int32.Parse(objRow[conAllDataType.mId].ToString().Trim()); //mId
objAllDataTypeEN.mString = objRow[conAllDataType.mString] == DBNull.Value ? null : objRow[conAllDataType.mString].ToString().Trim(); //字符串
objAllDataTypeEN.mInt = clsEntityBase2.TransNullToInt_S(objRow[conAllDataType.mInt] == DBNull.Value ? null : objRow[conAllDataType.mInt].ToString().Trim()); //整型
objAllDataTypeEN.mLong = clsEntityBase2.TransNullToInt_S(objRow[conAllDataType.mLong] == DBNull.Value ? null : objRow[conAllDataType.mLong].ToString().Trim()); //长整型
objAllDataTypeEN.mBool = clsEntityBase2.TransNullToBool_S(objRow[conAllDataType.mBool] == DBNull.Value ? null : objRow[conAllDataType.mBool].ToString().Trim()); //布尔型
objAllDataTypeEN.mDouble = clsEntityBase2.TransNullToDouble_S(objRow[conAllDataType.mDouble] == DBNull.Value ? null : objRow[conAllDataType.mDouble].ToString().Trim()); //双精度
objAllDataTypeEN.mFloat = clsEntityBase2.TransNullToFloat_S(objRow[conAllDataType.mFloat] == DBNull.Value ? null : objRow[conAllDataType.mFloat].ToString().Trim()); //浮点型
objAllDataTypeEN.mDate = objRow[conAllDataType.mDate] == DBNull.Value ? null : objRow[conAllDataType.mDate].ToString().Trim(); //日期型
objAllDataTypeEN.OrderNum = clsEntityBase2.TransNullToInt_S(objRow[conAllDataType.OrderNum] == DBNull.Value ? null : objRow[conAllDataType.OrderNum].ToString().Trim()); //排序
objAllDataTypeEN._IsDeleted = clsEntityBase2.TransNullToBool_S(objRow[conAllDataType._IsDeleted] == DBNull.Value ? null : objRow[conAllDataType._IsDeleted].ToString().Trim()); //是否删除
objAllDataTypeEN._DeletedDate = objRow[conAllDataType._DeletedDate] == DBNull.Value ? null : objRow[conAllDataType._DeletedDate].ToString().Trim(); //删除日期
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objAllDataTypeEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objAllDataTypeEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objAllDataTypeEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetAllDataType(ref clsAllDataTypeEN objAllDataTypeEN)
{
bool bolResult = AllDataTypeDA.GetAllDataType(ref objAllDataTypeEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public static clsAllDataTypeEN GetObjBymId(long lngmId)
{
clsAllDataTypeEN objAllDataTypeEN = AllDataTypeDA.GetObjBymId(lngmId);
return objAllDataTypeEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsAllDataTypeEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsAllDataTypeEN objAllDataTypeEN = AllDataTypeDA.GetFirstObj(strWhereCond);
 return objAllDataTypeEN;
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
public static clsAllDataTypeEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsAllDataTypeEN objAllDataTypeEN = AllDataTypeDA.GetObjByDataRow(objRow);
 return objAllDataTypeEN;
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
public static clsAllDataTypeEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsAllDataTypeEN objAllDataTypeEN = AllDataTypeDA.GetObjByDataRow(objRow);
 return objAllDataTypeEN;
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
 /// <param name = "lstAllDataTypeObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsAllDataTypeEN GetObjBymIdFromList(long lngmId, List<clsAllDataTypeEN> lstAllDataTypeObjLst)
{
foreach (clsAllDataTypeEN objAllDataTypeEN in lstAllDataTypeObjLst)
{
if (objAllDataTypeEN.mId == lngmId)
{
return objAllDataTypeEN;
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
 lngmId = new clsAllDataTypeDA().GetFirstID(strWhereCond);
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
 arrList = AllDataTypeDA.GetID(strWhereCond);
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
bool bolIsExist = AllDataTypeDA.IsExistCondRec(strWhereCond);
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
bool bolIsExist = AllDataTypeDA.IsExist(lngmId);
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
 bolIsExist = clsAllDataTypeDA.IsExistTable();
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
 bolIsExist = AllDataTypeDA.IsExistTable(strTabName);
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
 /// <param name = "objAllDataTypeEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecordBySql2(clsAllDataTypeEN objAllDataTypeEN)
{
if (objAllDataTypeEN.CheckUniqueness_mString_mInt() == false)
{
var strMsg = string.Format("记录已经存在!字符串 = [{0}],整型 = [{1}]的数据已经存在!(in clsAllDataTypeBL.AddNewRecordBySql2)", objAllDataTypeEN.mString,objAllDataTypeEN.mInt);
throw new Exception(strMsg);
}
try
{
bool bolResult = AllDataTypeDA.AddNewRecordBySQL2(objAllDataTypeEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsAllDataTypeBL.ReFreshCache();

if (clsAllDataTypeBL.relatedActions != null)
{
clsAllDataTypeBL.relatedActions.UpdRelaTabDate(objAllDataTypeEN.mId, "SetUpdDate");
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
 /// <param name = "objAllDataTypeEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordBySql2WithReturnKey(clsAllDataTypeEN objAllDataTypeEN)
{
if (objAllDataTypeEN.CheckUniqueness_mString_mInt() == false)
{
var strMsg = string.Format("记录已经存在!字符串 = [{0}],整型 = [{1}]的数据已经存在!(in clsAllDataTypeBL.AddNewRecordBySql2WithReturnKey)", objAllDataTypeEN.mString,objAllDataTypeEN.mInt);
throw new Exception(strMsg);
}
try
{
string strKey = AllDataTypeDA.AddNewRecordBySQL2WithReturnKey(objAllDataTypeEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsAllDataTypeBL.ReFreshCache();

if (clsAllDataTypeBL.relatedActions != null)
{
clsAllDataTypeBL.relatedActions.UpdRelaTabDate(objAllDataTypeEN.mId, "SetUpdDate");
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
 /// <param name = "objAllDataTypeEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(clsAllDataTypeEN objAllDataTypeEN)
{
try
{
bool bolResult = AllDataTypeDA.Update(objAllDataTypeEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsAllDataTypeBL.ReFreshCache();

if (clsAllDataTypeBL.relatedActions != null)
{
clsAllDataTypeBL.relatedActions.UpdRelaTabDate(objAllDataTypeEN.mId, "SetUpdDate");
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
 /// <param name = "objAllDataTypeEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateBySql2(clsAllDataTypeEN objAllDataTypeEN)
{
 if (objAllDataTypeEN.mId == 0)
 {
var strMsg = string.Format("(errid:Busi000065)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = AllDataTypeDA.UpdateBySql2(objAllDataTypeEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsAllDataTypeBL.ReFreshCache();

if (clsAllDataTypeBL.relatedActions != null)
{
clsAllDataTypeBL.relatedActions.UpdRelaTabDate(objAllDataTypeEN.mId, "SetUpdDate");
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
 clsAllDataTypeEN objAllDataTypeEN = clsAllDataTypeBL.GetObjBymId(lngmId);

if (clsAllDataTypeBL.relatedActions != null)
{
clsAllDataTypeBL.relatedActions.UpdRelaTabDate(objAllDataTypeEN.mId, "SetUpdDate");
}
if (objAllDataTypeEN != null)
{
int intRecNum = AllDataTypeDA.DelRecord(lngmId);
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
/// 扩展删除记录，即同时删除多个表的记录，需要基于原子性的事务处理
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DelRecordEx)
/// </summary>
/// <param name="lngmId">表关键字</param>
/// <returns></returns>
public static bool DelRecordEx(long lngmId )
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsAllDataTypeDA.GetSpecSQLObj();
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
//删除与表:[AllDataType]相关的表的代码，需要时去除注释，编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conAllDataType.mId,
//lngmId);
//        clsAllDataTypeBL.DelAllDataTypesByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsAllDataTypeBL.DelRecord(lngmId, objConnection, objSqlTransaction);
objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsAllDataTypeBLEx", "DelRecordEx", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("扩展删除记录出错:{0}！keyId = {1}.({2})",
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
 /// 功能:根据标志删除关键字所指定的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_TabFeature_DelRecordBySign)
 /// </summary>
 /// <param name = "arrMId">给定的关键字列表</param>
 /// <returns>返回删除的记录数</returns>
public static int DelRecordBySign(List<long> arrMId)
{
try
{
if (clsAllDataTypeBL.relatedActions != null)
{
foreach (var lngmId in arrMId)
{
clsAllDataTypeBL.relatedActions.UpdRelaTabDate(lngmId, "UpdRelaTabDate");
}
}
int intRecNum_Total = 0;
arrMId.ForEach((x) =>
{
int intRecNum = AllDataTypeDA.DelRecordBySign(x);
            intRecNum_Total += intRecNum;
        });
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
ReFreshCache();
return intRecNum_Total;
}
catch (Exception objException)
{
var strMsg = string.Format("(errid:Busi000077)根据标志删除记录出错,{1}.({0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
}
}

 /// <summary>
 /// 功能:恢复被删除的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_TabFeature_UnDelRecordBySign)
 /// </summary>
 /// <param name = "arrMId">给定的关键字列表</param>
 /// <returns>返回恢复删除的记录数</returns>
public static int UnDelRecordBySign(List<long> arrMId)
{
try
{
int intRecNum_Total = 0;
arrMId.ForEach((x) =>
{
int intRecNum = AllDataTypeDA.UnDelRecordBySign(x);
            intRecNum_Total += intRecNum;
        });
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
ReFreshCache();
if (clsAllDataTypeBL.relatedActions != null)
{
foreach (var lngmId in arrMId)
{
clsAllDataTypeBL.relatedActions.UpdRelaTabDate(lngmId, "UpdRelaTabDate");
}
}
return intRecNum_Total;
}
catch (Exception objException)
{
var strMsg = string.Format("(errid:Busi000078)恢复被删除记录出错,{1}.({0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
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
if (clsAllDataTypeBL.relatedActions != null)
{
clsAllDataTypeBL.relatedActions.UpdRelaTabDate(lngmId, "UpdRelaTabDate");
}
bool bolResult = AllDataTypeDA.DelRecord(lngmId,objSqlConnection,objSqlTransaction);
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
public static int DelAllDataTypes(List<string> arrmIdLst)
{
if (arrmIdLst.Count == 0) return 0;
try
{
if (clsAllDataTypeBL.relatedActions != null)
{
foreach (var strmId in arrmIdLst)
{
long lngmId = long.Parse(strmId);
clsAllDataTypeBL.relatedActions.UpdRelaTabDate(lngmId, "UpdRelaTabDate");
}
}
int intDelRecNum = AllDataTypeDA.DelAllDataType(arrmIdLst);
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
public static int DelAllDataTypesByCond(string strWhereCond)
{
try
{
if (clsAllDataTypeBL.relatedActions != null)
{
List<string> arrmId = GetPrimaryKeyID_S(strWhereCond);
foreach (var strmId in arrmId)
{
long lngmId = long.Parse(strmId);
clsAllDataTypeBL.relatedActions.UpdRelaTabDate(lngmId, "UpdRelaTabDate");
}
}
int intRecNum = AllDataTypeDA.DelAllDataType(strWhereCond);
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
/// 扩展删除记录，即同时删除多个表的记录，需要基于原子性的事务处理
/// 这里仅仅是演示函数，使用时请复制到扩展类:[AllDataType]中改名为:[DelRecord4MultiTabEx]使用
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DelRecord4MultiTab)
/// </summary>
/// <param name="lngmId">表关键字</param>
/// <returns></returns>
public static bool DelRecord4MultiTab(long lngmId)
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsAllDataTypeDA.GetSpecSQLObj();
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
//删除与表:[AllDataType]相关的表的代码，需要时去除注释，编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conStudent.id_College,
//strid_College);
//        clsStudentBL.DelStudentsByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsAllDataTypeBL.DelRecord(lngmId, objConnection, objSqlTransaction);
                objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsAllDataTypeBL", "DelRecord4MultiTab", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("删除多表记录出错:{0}！keyId = {1}.({2})",
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
 /// <param name = "objAllDataTypeENS">源对象</param>
 /// <param name = "objAllDataTypeENT">目标对象</param>
 public static void CopyTo(clsAllDataTypeEN objAllDataTypeENS, clsAllDataTypeEN objAllDataTypeENT)
{
try
{
objAllDataTypeENT.mId = objAllDataTypeENS.mId; //mId
objAllDataTypeENT.mString = objAllDataTypeENS.mString; //字符串
objAllDataTypeENT.mInt = objAllDataTypeENS.mInt; //整型
objAllDataTypeENT.mLong = objAllDataTypeENS.mLong; //长整型
objAllDataTypeENT.mBool = objAllDataTypeENS.mBool; //布尔型
objAllDataTypeENT.mDouble = objAllDataTypeENS.mDouble; //双精度
objAllDataTypeENT.mFloat = objAllDataTypeENS.mFloat; //浮点型
objAllDataTypeENT.mDate = objAllDataTypeENS.mDate; //日期型
objAllDataTypeENT.OrderNum = objAllDataTypeENS.OrderNum; //排序
objAllDataTypeENT._IsDeleted = objAllDataTypeENS._IsDeleted; //是否删除
objAllDataTypeENT._DeletedDate = objAllDataTypeENS._DeletedDate; //删除日期
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
 /// <param name = "objAllDataTypeEN">源简化对象</param>
 public static void SetUpdFlag(clsAllDataTypeEN objAllDataTypeEN)
{
try
{
objAllDataTypeEN.ClearUpdateState();
   string strsf_UpdFldSetStr = objAllDataTypeEN.sf_UpdFldSetStr;
    string[] sstrFldSet = strsf_UpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(conAllDataType.mId, new clsStrCompareIgnoreCase())  ==  true)
{
objAllDataTypeEN.mId = objAllDataTypeEN.mId; //mId
}
if (arrFldSet.Contains(conAllDataType.mString, new clsStrCompareIgnoreCase())  ==  true)
{
objAllDataTypeEN.mString = objAllDataTypeEN.mString == "[null]" ? null :  objAllDataTypeEN.mString; //字符串
}
if (arrFldSet.Contains(conAllDataType.mInt, new clsStrCompareIgnoreCase())  ==  true)
{
objAllDataTypeEN.mInt = objAllDataTypeEN.mInt; //整型
}
if (arrFldSet.Contains(conAllDataType.mLong, new clsStrCompareIgnoreCase())  ==  true)
{
objAllDataTypeEN.mLong = objAllDataTypeEN.mLong; //长整型
}
if (arrFldSet.Contains(conAllDataType.mBool, new clsStrCompareIgnoreCase())  ==  true)
{
objAllDataTypeEN.mBool = objAllDataTypeEN.mBool; //布尔型
}
if (arrFldSet.Contains(conAllDataType.mDouble, new clsStrCompareIgnoreCase())  ==  true)
{
objAllDataTypeEN.mDouble = objAllDataTypeEN.mDouble; //双精度
}
if (arrFldSet.Contains(conAllDataType.mFloat, new clsStrCompareIgnoreCase())  ==  true)
{
objAllDataTypeEN.mFloat = objAllDataTypeEN.mFloat; //浮点型
}
if (arrFldSet.Contains(conAllDataType.mDate, new clsStrCompareIgnoreCase())  ==  true)
{
objAllDataTypeEN.mDate = objAllDataTypeEN.mDate == "[null]" ? null :  objAllDataTypeEN.mDate; //日期型
}
if (arrFldSet.Contains(conAllDataType.OrderNum, new clsStrCompareIgnoreCase())  ==  true)
{
objAllDataTypeEN.OrderNum = objAllDataTypeEN.OrderNum; //排序
}
if (arrFldSet.Contains(conAllDataType._IsDeleted, new clsStrCompareIgnoreCase())  ==  true)
{
objAllDataTypeEN._IsDeleted = objAllDataTypeEN._IsDeleted; //是否删除
}
if (arrFldSet.Contains(conAllDataType._DeletedDate, new clsStrCompareIgnoreCase())  ==  true)
{
objAllDataTypeEN._DeletedDate = objAllDataTypeEN._DeletedDate == "[null]" ? null :  objAllDataTypeEN._DeletedDate; //删除日期
}
}
catch (Exception objException)
{
var strMsg = string.Format("(errid:Busi000064)设置表的修改标志出错,{1}.({0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
}
}

 /// <summary>
 /// 处理从Web端传来的[null]的字段值，在WebApi端设置成null
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_AccessFldValueNull)
 /// </summary>
 /// <param name = "objAllDataTypeEN">源简化对象</param>
 public static void AccessFldValueNull(clsAllDataTypeEN objAllDataTypeEN)
{
try
{
if (objAllDataTypeEN.mString == "[null]") objAllDataTypeEN.mString = null; //字符串
if (objAllDataTypeEN.mDate == "[null]") objAllDataTypeEN.mDate = null; //日期型
if (objAllDataTypeEN._DeletedDate == "[null]") objAllDataTypeEN._DeletedDate = null; //删除日期
}
catch (Exception objException)
{
var strMsg = string.Format("(errid:Busi000170)处理从Web端传来的[null]的字段值出错,{1}.({0})",
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
public static void CheckPropertyNew(clsAllDataTypeEN objAllDataTypeEN)
{
 AllDataTypeDA.CheckPropertyNew(objAllDataTypeEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(clsAllDataTypeEN objAllDataTypeEN)
{
 AllDataTypeDA.CheckProperty4Condition(objAllDataTypeEN);
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
if (clsAllDataTypeBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsAllDataTypeBL没有刷新缓存机制(clsAllDataTypeBL.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by mId");
//if (arrAllDataTypeObjLst_Cache == null)
//{
//arrAllDataTypeObjLst_Cache = AllDataTypeDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey_Cache)
 /// </summary>
 /// <param name = "lngmId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsAllDataTypeEN GetObjBymId_Cache(long lngmId)
{
//获取缓存中的对象列表
string strKey = string.Format("{0}", clsAllDataTypeEN._CurrTabName_S);
List<clsAllDataTypeEN> arrAllDataTypeObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsAllDataTypeEN> arrAllDataTypeObjLst_Sel =
arrAllDataTypeObjLst_Cache
.Where(x=> x.mId == lngmId 
);
if (arrAllDataTypeObjLst_Sel.Count() == 0)
{
   clsAllDataTypeEN obj = clsAllDataTypeBL.GetObjBymId(lngmId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
 }
return null;
}
return arrAllDataTypeObjLst_Sel.First();
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLst_Cache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsAllDataTypeEN> GetAllAllDataTypeObjLst_Cache()
{
//获取缓存中的对象列表
List<clsAllDataTypeEN> arrAllDataTypeObjLst_Cache = GetObjLst_Cache(); 
return arrAllDataTypeObjLst_Cache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst_Cache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsAllDataTypeEN> GetObjLst_Cache()
{
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}", clsAllDataTypeEN._CurrTabName_S);
List<clsAllDataTypeEN> arrAllDataTypeObjLst_Cache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrAllDataTypeObjLst_Cache;
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
string strKey = string.Format("{0}", clsAllDataTypeEN._CurrTabName_S);
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
if (clsAllDataTypeBL.objCommFun4BL != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}", clsAllDataTypeEN._CurrTabName_S);
CacheHelper.Remove(strKey);
clsAllDataTypeBL.objCommFun4BL.ReFreshCache();
}
}


 #endregion 缓存操作


 #region 检查唯一性

 /// <summary>
 /// 检查唯一性(Uniqueness)--AllDataType(各种数据类型), 如果不唯一,即存在相同的记录,就返回False
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_CheckUniquenessV3)
 /// </summary>
 /// <param name = "objAllDataTypeEN">要求唯一的对象</param>
 /// <returns></returns>
public static bool CheckAllDataTypeUniqueness(clsAllDataTypeEN objAllDataTypeEN)
{
//检测记录是否存在
bool bolIsUniqueness;
if (objAllDataTypeEN == null) return true;
if (objAllDataTypeEN.mId == 0)
{
bolIsUniqueness = AllDataTypeDA.CheckAllDataTypeUniqueness();
}
else
{
bolIsUniqueness = AllDataTypeDA.CheckAllDataTypeUniqueness(objAllDataTypeEN.mId);
}
return bolIsUniqueness;
}

 /// <summary>
 /// 获取检查唯一性条件串(Uniqueness)--AllDataType(各种数据类型)
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetUniquenessConditionString)
 /// </summary>
 /// <param name = "objAllDataTypeEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr_mString_mInt(clsAllDataTypeEN objAllDataTypeEN)
{
//检测记录是否存在
string strResult = AllDataTypeDA.GetUniCondStr_mString_mInt(objAllDataTypeEN);
return strResult;
}


 #endregion 检查唯一性

 /// <summary>
 /// 映射函数。根据表映射把输入字段值，映射成输出字段值
 /// 作者:pyf
 /// 日期:2023-03-11
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_func)
 /// </summary>
 /// <param name = "strInFldName">输入字段名</param>
 /// <param name = "strOutFldName">输出字段名</param>
 /// <param name = "strInValue">输入字段值</param>
 /// <returns>返回一个输出字段值</returns>
public static string Func(string strInFldName, string strOutFldName, long lngmId)
{
if (strInFldName != conAllDataType.mId)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (conAllDataType.AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确，不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", conAllDataType.AttributeName));
throw new Exception(strMsg);
}
var objAllDataType = clsAllDataTypeBL.GetObjBymId_Cache(lngmId);
if (objAllDataType == null) return "";
return objAllDataType[strOutFldName].ToString();
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
int intRecCount = clsAllDataTypeDA.GetRecCount(strTabName);
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
int intRecCount = clsAllDataTypeDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsAllDataTypeDA.GetRecCount();
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
int intRecCount = clsAllDataTypeDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObj_Cache)
 /// </summary>
 /// <param name = "objAllDataType_Cond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCond_Cache(clsAllDataTypeEN objAllDataType_Cond)
{
List<clsAllDataTypeEN> arrObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsAllDataTypeEN> arrObjLst_Sel = arrObjLst_Cache;
foreach (string strFldName in conAllDataType.AttributeName)
{
if (objAllDataType_Cond.IsUpdated(strFldName) == false) continue;
if (objAllDataType_Cond.dicFldComparisonOp == null)
{
arrObjLst_Sel = arrObjLst_Sel.Where(x => x[strFldName].ToString() == objAllDataType_Cond[strFldName].ToString());
}
else
{
if (objAllDataType_Cond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objAllDataType_Cond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLst_Sel = arrObjLst_Sel.Where(x => x[strFldName].ToString() == objAllDataType_Cond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLst_Sel = arrObjLst_Sel.Where(x => x[strFldName].ToString().Contains(objAllDataType_Cond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLst_Sel = arrObjLst_Sel.Where(x => x[strFldName].ToString().Length > int.Parse(objAllDataType_Cond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLst_Sel = arrObjLst_Sel.Where(x => x[strFldName].ToString().Length <= int.Parse(objAllDataType_Cond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLst_Sel = arrObjLst_Sel.Where(x => x[strFldName].ToString().Length >= int.Parse(objAllDataType_Cond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLst_Sel = arrObjLst_Sel.Where(x => x[strFldName].ToString().Length < int.Parse(objAllDataType_Cond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLst_Sel = arrObjLst_Sel.Where(x => x[strFldName].ToString().Length == int.Parse(objAllDataType_Cond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objAllDataType_Cond[strFldName].ToString().Split(",".ToCharArray());
arrObjLst_Sel = arrObjLst_Sel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLst_Sel = arrObjLst_Sel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objAllDataType_Cond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLst_Sel = arrObjLst_Sel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objAllDataType_Cond[strFldName]));
}
}
}
return arrObjLst_Sel.Count();
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
 List<string> arrList = clsAllDataTypeDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = AllDataTypeDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = AllDataTypeDA.GetFldValueNoDistinct(strFldName, strWhereCond);
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
int intRecCount = AllDataTypeDA.SetFldValue(strFldName, strValue, strWhereCond);
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
int intRecCount = clsAllDataTypeDA.SetFldValue(clsAllDataTypeEN._CurrTabName_S, strFldName, fltValue, strWhereCond);
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
int intRecCount = AllDataTypeDA.SetFldValue( strFldName, intValue, strWhereCond);
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
int intRecCount = clsAllDataTypeDA.SetFldValue(strTabName, strFldName, strValue, strWhereCond);
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
int intRecCount = clsAllDataTypeDA.SetFldValue(strTabName, strFldName, intValue, strWhereCond);
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
int intRecCount = clsAllDataTypeDA.SetFldValue(strTabName, strFldName, fltValue, strWhereCond);
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
  strCreateTabCode.Append("CREATE table [dbo].[AllDataType] "); 
 strCreateTabCode.Append(" ( "); 
 // /**mId*/ 
 strCreateTabCode.Append(" mId bigint primary key identity, "); 
 // /**字符串*/ 
 strCreateTabCode.Append(" mString varchar(50) Null, "); 
 // /**整型*/ 
 strCreateTabCode.Append(" mInt int Null, "); 
 // /**长整型*/ 
 strCreateTabCode.Append(" mLong bigint Null, "); 
 // /**布尔型*/ 
 strCreateTabCode.Append(" mBool bit Null, "); 
 // /**双精度*/ 
 strCreateTabCode.Append(" mDouble decimal(8,1) Null, "); 
 // /**浮点型*/ 
 strCreateTabCode.Append(" mFloat float Null, "); 
 // /**日期型*/ 
 strCreateTabCode.Append(" mDate varchar(20) Null, "); 
 // /**排序*/ 
 strCreateTabCode.Append(" OrderNum int Null, "); 
 // /**是否删除*/ 
 strCreateTabCode.Append(" _IsDeleted bit Null, "); 
 // /**删除日期*/ 
 strCreateTabCode.Append(" _DeletedDate varchar(50) Null ");
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
string strCondition = string.Format("1 = 1 order by {0} ", conAllDataType.OrderNum); 
List<clsAllDataTypeEN> arrAllDataTypeObjList = new clsAllDataTypeDA().GetObjLst(strCondition);
    
int intIndex = 1;
foreach (clsAllDataTypeEN objAllDataType in arrAllDataTypeObjList)
{
objAllDataType.OrderNum = intIndex;
UpdateBySql2(objAllDataType);
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
//1、根据所给定的关键字[mId]，获取相应的序号[OrderNum]；
//2、如果当前序号是否是末端序号；
//3、如果是末端序号，就退出；
//   3.1、如果是向下移动，判断当前序号是否“小于”当前表中的字段数，
//	   即不是最后一个记录，就准备把当前字段项的序号加1，而下一字段的序号减1，
//   3.2、如果是向上移动，就判断当前序号是否“大于”1，
//	   即不是第一条记录，就准备把当前字段项的序号减1，而上一字段的序号加1。
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
//1、根据所给定的关键字[mId]，获取相应的序号[OrderNum]。

clsAllDataTypeEN objAllDataType = clsAllDataTypeBL.GetObjBymId(lngmId);

intOrderNum = objAllDataType.OrderNum;//当前序号
intPrevOrderNum = intOrderNum - 1;//前一条记录的序号
intNextOrderNum = intOrderNum + 1;//后一条记录的序号
//3、如果当前序号是否是末端序号，
//		3.1 如果是末端序号，就退出，

intTabRecNum = clsAllDataTypeBL.GetRecCountByCond(clsAllDataTypeEN._CurrTabName_S, "1 = 1");    //获取当前表的记录数
switch (strDirect)
{
case "UP":
case "Up":
case "up":
//3、如果是末端序号，就退出；
//  3.2、如果是向上移动，就判断当前序号是否“大于”1，
//	     即不是第一条记录，就准备把当前字段项的序号减1，而上一字段的序号加1。
if (intOrderNum <= 1)
{
strMsg = string.Format("已经是第一条记录，不能再上移.(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//		3.2 如果不是，即如果是向下移动，就判断当前序号是否“小于”当前表中的字段数，
//		    即不是最后一个记录，就准备把当前字段项的序号加1，而下一字段的序号减1，
//		    如果是向上移动，就判断当前序号是否“大于”1，
//		    即不是最开始一个记录，就准备把当前字段项的序号减1，而上一字段的序号加1。
strCondition.AppendFormat(" {0} = {1}", conAllDataType.OrderNum, intOrderNum - 1);
//4、获取上一个序号字段的关键字mId
lngPrevmId = clsAllDataTypeBL.GetFirstID_S(strCondition.ToString());
if (lngPrevmId == 0)
{
strMsg = string.Format("获取上一条记录的关键字出错.(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//5、把当前关键字mId所对应记录的序号减1
//6、把下(上)一个序号关键字mId所对应的记录序号加1
clsAllDataTypeBL.SetFldValue(clsAllDataTypeEN._CurrTabName_S, conAllDataType.OrderNum,
intOrderNum - 1,
string.Format("{0} = '{1}'", conAllDataType.mId, lngmId));
clsAllDataTypeBL.SetFldValue(clsAllDataTypeEN._CurrTabName_S, conAllDataType.OrderNum,
intPrevOrderNum + 1,
string.Format("{0} = '{1}'", conAllDataType.mId, lngPrevmId));
break;
case "DOWN":
case "Down":
case "down":
//3、如果是末端序号，就退出；
//   3.1、如果是向下移动，判断当前序号是否“小于”当前表中的字段数，
//	   即不是最后一个记录，就准备把当前字段项的序号加1，而下一字段的序号减1，
if (intOrderNum >= intTabRecNum)    //如果当前序号大于表记录数
{
strMsg = string.Format("已经是最后一条记录，不能再下移.(from {0})", clsStackTrace.GetCurrClassFunction());
                            throw new Exception(strMsg);
}

//4、获取下一个序号字段的关键字mId
strCondition.AppendFormat(" {0} = {1}", conAllDataType.OrderNum, intOrderNum + 1);

lngNextmId = clsAllDataTypeBL.GetFirstID_S(strCondition.ToString());
if (lngNextmId == 0)
{
strMsg = string.Format("获取下一条记录的关键字出错.(from {0})", clsStackTrace.GetCurrClassFunction());

throw new Exception(strMsg);
}
//5、把当前关键字mId所对应记录的序号加1
//6、把下(上)一个序号关键字mId所对应的记录序号减1
clsAllDataTypeBL.SetFldValue(clsAllDataTypeEN._CurrTabName_S, conAllDataType.OrderNum,
intOrderNum + 1,
string.Format("{0} = '{1}'", conAllDataType.mId, lngmId));
clsAllDataTypeBL.SetFldValue(clsAllDataTypeEN._CurrTabName_S, conAllDataType.OrderNum,
 	 	intNextOrderNum - 1,
 	 	string.Format("{0} = '{1}'", conAllDataType.mId, lngNextmId));
break;
default:
strMsg = string.Format("方向参数出错!strDirect=[{0}]({1})",
strDirect,
clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
clsAllDataTypeBL.ReFreshCache();
if (clsAllDataTypeBL.relatedActions != null)
{
clsAllDataTypeBL.relatedActions.UpdRelaTabDate(objAllDataType.mId, "UpdRelaTabDate");
}
return true;
}
catch (Exception objException)
{
string strMsg = string.Format("调整记录次序出错！错误:[{0}]({1})",
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
string strCondition = string.Format("{0} in ({1})", conAllDataType.mId, strKeyList);
List<clsAllDataTypeEN> arrAllDataTypeLst = GetObjLst(strCondition);
foreach (clsAllDataTypeEN objAllDataType in arrAllDataTypeLst)
{
objAllDataType.OrderNum = objAllDataType.OrderNum + 10000;
UpdateBySql2(objAllDataType);
}
strCondition = string.Format("1 = 1 order by {0} ", conAllDataType.OrderNum); 
List<clsAllDataTypeEN> arrAllDataTypeObjList = new clsAllDataTypeDA().GetObjLst(strCondition);
    
int intIndex = 1;
foreach (clsAllDataTypeEN objAllDataType in arrAllDataTypeObjList)
{
objAllDataType.OrderNum = intIndex;
UpdateBySql2(objAllDataType);
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
string strCondition = string.Format("{0} in ({1})", conAllDataType.mId, strKeyList);
List<clsAllDataTypeEN> arrAllDataTypeLst = GetObjLst(strCondition);
foreach (clsAllDataTypeEN objAllDataType in arrAllDataTypeLst)
{
objAllDataType.OrderNum = objAllDataType.OrderNum - 10000;
UpdateBySql2(objAllDataType);
}
strCondition = string.Format("1 = 1 order by {0} ", conAllDataType.OrderNum); 
List<clsAllDataTypeEN> arrAllDataTypeObjList = new clsAllDataTypeDA().GetObjLst(strCondition);
    
int intIndex = 1;
foreach (clsAllDataTypeEN objAllDataType in arrAllDataTypeObjList)
{
objAllDataType.OrderNum = intIndex;
UpdateBySql2(objAllDataType);
intIndex++;
}
return true; 
}
catch (Exception objException)
{
string strMsg = string.Format("置顶出错！错误:{0}. (from {1})", objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
}


 #endregion 排序相关函数
}
 /// <summary>
 /// 各种数据类型(AllDataType)
 /// 数据源类型:表
 /// (AutoGCLib.CommFun4BL4CSharp:GeneCode_This)
 /// </summary>
public class clsCommFun4BL4AllDataType : clsCommFun4BL
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
clsAllDataTypeBL.ReFreshThisCache();
}
}

}