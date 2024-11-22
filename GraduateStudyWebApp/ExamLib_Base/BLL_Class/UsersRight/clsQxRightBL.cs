
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsQxRightBL
 表名:QxRight(01120173)
 * 版本:2024.11.13.1(服务器:WIN-SRV103-116)
 日期:2024/11/13 06:19:50
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:研究生学习游戏化后台(000055, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:权限管理(UsersRight)
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
public static class  clsQxRightBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "strRightId">表关键字</param>
 /// <returns>表对象</returns>
public static clsQxRightEN GetObj(this K_RightId_QxRight myKey)
{
clsQxRightEN objQxRightEN = clsQxRightBL.QxRightDA.GetObjByRightId(myKey.Value);
return objQxRightEN;
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_AddNewRecord)
 /// </summary>
 /// <param name = "objQxRightEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clsQxRightEN objQxRightEN, bool bolIsNeedCheckUniqueness = true)
{
if (bolIsNeedCheckUniqueness == true && CheckUniqueness(objQxRightEN) == false)
{
var strMsg = string.Format("记录已经存在!权限名称 = [{0}],权限类型编号 = [{1}]的数据已经存在!(in clsQxRightBL.AddNewRecord)", objQxRightEN.RightName,objQxRightEN.RightTypeId);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objQxRightEN.RightId) == true || clsQxRightBL.IsExist(objQxRightEN.RightId) == true)
 {
     objQxRightEN.RightId = clsQxRightBL.GetMaxStrId_S();
 }
bool bolResult = clsQxRightBL.QxRightDA.AddNewRecordBySQL2(objQxRightEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsQxRightBL.ReFreshCache();

if (clsQxRightBL.relatedActions != null)
{
clsQxRightBL.relatedActions.UpdRelaTabDate(objQxRightEN.RightId, objQxRightEN.UpdUser);
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
public static bool AddRecordEx(this clsQxRightEN objQxRightEN, bool bolIsNeedCheckUniqueness = true)
{
//操作步骤:
//1、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在
//2、检查唯一性
//3、检查传进去的对象属性是否合法
//4、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
//1、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在

//因为是字符型自增主键,不需要检查主键是否已经存在,在添加时,再获取 最大值作为主键
//if (clsQxRightBL.IsExist(objQxRightEN.RightId))	//判断是否有相同的关键字
//{
//strMsg = "(errid:Busi000151)关键字字段已有相同的值";
//throw new Exception(strMsg);
//}
try
{
 //2、检查传进去的对象属性是否合法
objQxRightEN.CheckPropertyNew();
 ///5.2、检查唯一性
if (bolIsNeedCheckUniqueness == true && objQxRightEN.CheckUniqueness() == false)
{
strMsg = string.Format("(权限名称(RightName)=[{0}],权限类型编号(RightTypeId)=[{1}])已经存在,不能重复!", objQxRightEN.RightName, objQxRightEN.RightTypeId);
throw new Exception(strMsg);
}
//因为是字符型自增主键,所以在添加时,自动获取主键值。
 if (string.IsNullOrEmpty(objQxRightEN.RightId) == true || clsQxRightBL.IsExist(objQxRightEN.RightId) == true)
 {
     objQxRightEN.RightId = clsQxRightBL.GetMaxStrId_S();
 }
//6、把数据实体层的数据存贮到数据库中
objQxRightEN.AddNewRecord();
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
 /// <param name = "objQxRightEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static string AddNewRecordWithMaxId(this clsQxRightEN objQxRightEN, bool bolIsNeedCheckUniqueness = true)
{
if (bolIsNeedCheckUniqueness == true && CheckUniqueness(objQxRightEN) == false)
{
var strMsg = string.Format("记录已经存在!权限名称 = [{0}],权限类型编号 = [{1}]的数据已经存在!(in clsQxRightBL.AddNewRecordWithMaxId)", objQxRightEN.RightName,objQxRightEN.RightTypeId);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objQxRightEN.RightId) == true || clsQxRightBL.IsExist(objQxRightEN.RightId) == true)
 {
     objQxRightEN.RightId = clsQxRightBL.GetMaxStrId_S();
 }
string strRightId = clsQxRightBL.QxRightDA.AddNewRecordBySQL2WithReturnKey(objQxRightEN);
     objQxRightEN.RightId = strRightId;
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsQxRightBL.ReFreshCache();

if (clsQxRightBL.relatedActions != null)
{
clsQxRightBL.relatedActions.UpdRelaTabDate(objQxRightEN.RightId, objQxRightEN.UpdUser);
}
return strRightId;
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
 /// <param name = "objQxRightEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordWithReturnKey(this clsQxRightEN objQxRightEN, bool bolIsNeedCheckUniqueness = true)
{
if (bolIsNeedCheckUniqueness == true && CheckUniqueness(objQxRightEN) == false)
{
var strMsg = string.Format("记录已经存在!权限名称 = [{0}],权限类型编号 = [{1}]的数据已经存在!(in clsQxRightBL.AddNewRecordWithReturnKey)", objQxRightEN.RightName,objQxRightEN.RightTypeId);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objQxRightEN.RightId) == true || clsQxRightBL.IsExist(objQxRightEN.RightId) == true)
 {
     objQxRightEN.RightId = clsQxRightBL.GetMaxStrId_S();
 }
string strKey = clsQxRightBL.QxRightDA.AddNewRecordBySQL2WithReturnKey(objQxRightEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsQxRightBL.ReFreshCache();

if (clsQxRightBL.relatedActions != null)
{
clsQxRightBL.relatedActions.UpdRelaTabDate(objQxRightEN.RightId, objQxRightEN.UpdUser);
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
 /// <param name = "objQxRightEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQxRightEN SetRightId(this clsQxRightEN objQxRightEN, string strRightId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strRightId, 8, conQxRight.RightId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strRightId, 8, conQxRight.RightId);
}
objQxRightEN.RightId = strRightId; //权限编号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQxRightEN.dicFldComparisonOp.ContainsKey(conQxRight.RightId) == false)
{
objQxRightEN.dicFldComparisonOp.Add(conQxRight.RightId, strComparisonOp);
}
else
{
objQxRightEN.dicFldComparisonOp[conQxRight.RightId] = strComparisonOp;
}
}
return objQxRightEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQxRightEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQxRightEN SetRightName(this clsQxRightEN objQxRightEN, string strRightName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strRightName, conQxRight.RightName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strRightName, 200, conQxRight.RightName);
}
objQxRightEN.RightName = strRightName; //权限名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQxRightEN.dicFldComparisonOp.ContainsKey(conQxRight.RightName) == false)
{
objQxRightEN.dicFldComparisonOp.Add(conQxRight.RightName, strComparisonOp);
}
else
{
objQxRightEN.dicFldComparisonOp[conQxRight.RightName] = strComparisonOp;
}
}
return objQxRightEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQxRightEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQxRightEN SetRightTypeId(this clsQxRightEN objQxRightEN, string strRightTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strRightTypeId, conQxRight.RightTypeId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strRightTypeId, 4, conQxRight.RightTypeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strRightTypeId, 4, conQxRight.RightTypeId);
}
objQxRightEN.RightTypeId = strRightTypeId; //权限类型编号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQxRightEN.dicFldComparisonOp.ContainsKey(conQxRight.RightTypeId) == false)
{
objQxRightEN.dicFldComparisonOp.Add(conQxRight.RightTypeId, strComparisonOp);
}
else
{
objQxRightEN.dicFldComparisonOp[conQxRight.RightTypeId] = strComparisonOp;
}
}
return objQxRightEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQxRightEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQxRightEN SetFuncModuleId(this clsQxRightEN objQxRightEN, string strFuncModuleId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFuncModuleId, 4, conQxRight.FuncModuleId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strFuncModuleId, 4, conQxRight.FuncModuleId);
}
objQxRightEN.FuncModuleId = strFuncModuleId; //功能模块Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQxRightEN.dicFldComparisonOp.ContainsKey(conQxRight.FuncModuleId) == false)
{
objQxRightEN.dicFldComparisonOp.Add(conQxRight.FuncModuleId, strComparisonOp);
}
else
{
objQxRightEN.dicFldComparisonOp[conQxRight.FuncModuleId] = strComparisonOp;
}
}
return objQxRightEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQxRightEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQxRightEN SetRightRangeLevelId(this clsQxRightEN objQxRightEN, string strRightRangeLevelId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strRightRangeLevelId, conQxRight.RightRangeLevelId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strRightRangeLevelId, 2, conQxRight.RightRangeLevelId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strRightRangeLevelId, 2, conQxRight.RightRangeLevelId);
}
objQxRightEN.RightRangeLevelId = strRightRangeLevelId; //权限范围等级Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQxRightEN.dicFldComparisonOp.ContainsKey(conQxRight.RightRangeLevelId) == false)
{
objQxRightEN.dicFldComparisonOp.Add(conQxRight.RightRangeLevelId, strComparisonOp);
}
else
{
objQxRightEN.dicFldComparisonOp[conQxRight.RightRangeLevelId] = strComparisonOp;
}
}
return objQxRightEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQxRightEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQxRightEN SetUpdDate(this clsQxRightEN objQxRightEN, string strUpdDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdDate, 20, conQxRight.UpdDate);
}
objQxRightEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQxRightEN.dicFldComparisonOp.ContainsKey(conQxRight.UpdDate) == false)
{
objQxRightEN.dicFldComparisonOp.Add(conQxRight.UpdDate, strComparisonOp);
}
else
{
objQxRightEN.dicFldComparisonOp[conQxRight.UpdDate] = strComparisonOp;
}
}
return objQxRightEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQxRightEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQxRightEN SetUpdUser(this clsQxRightEN objQxRightEN, string strUpdUser, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdUser, 20, conQxRight.UpdUser);
}
objQxRightEN.UpdUser = strUpdUser; //修改人
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQxRightEN.dicFldComparisonOp.ContainsKey(conQxRight.UpdUser) == false)
{
objQxRightEN.dicFldComparisonOp.Add(conQxRight.UpdUser, strComparisonOp);
}
else
{
objQxRightEN.dicFldComparisonOp[conQxRight.UpdUser] = strComparisonOp;
}
}
return objQxRightEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQxRightEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQxRightEN SetMemo(this clsQxRightEN objQxRightEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, conQxRight.Memo);
}
objQxRightEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQxRightEN.dicFldComparisonOp.ContainsKey(conQxRight.Memo) == false)
{
objQxRightEN.dicFldComparisonOp.Add(conQxRight.Memo, strComparisonOp);
}
else
{
objQxRightEN.dicFldComparisonOp[conQxRight.Memo] = strComparisonOp;
}
}
return objQxRightEN;
	}

 /// <summary>
 /// 修改记录存盘到数据表中
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_UpdateRecordEx)
 /// </summary>
 /// <param name = "objQxRightEN">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool UpdateRecordEx(this clsQxRightEN objQxRightEN)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
try
{
//1、检查传进去的对象属性是否合法
objQxRightEN.CheckPropertyNew();
clsQxRightEN objQxRightCond = new clsQxRightEN();
string strCondition = objQxRightCond
.SetRightId(objQxRightEN.RightId, "<>")
.SetRightName(objQxRightEN.RightName, "=")
.SetRightTypeId(objQxRightEN.RightTypeId, "=")
.GetCombineCondition();
objQxRightEN._IsCheckProperty = true;
bool bolIsExist = clsQxRightBL.IsExistRecord(strCondition);
if (bolIsExist)
{
strMsg = "(RightName_RightTypeId)不能重复!";
throw new Exception(strMsg);
}
//4、把数据实体层的数据存贮到数据库中
objQxRightEN.Update();
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
 /// <param name = "objQxRight">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool EditRecordEx(this clsQxRightEN objQxRight)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
clsQxRightEN objQxRightCond = new clsQxRightEN();
string strCondition = objQxRightCond
.SetRightName(objQxRight.RightName, "=")
.SetRightTypeId(objQxRight.RightTypeId, "=")
.GetCombineCondition();
objQxRight._IsCheckProperty = true;
bool bolIsExist = clsQxRightBL.IsExistRecord(strCondition);
if (bolIsExist)
{
objQxRight.RightId = clsQxRightBL.GetFirstID_S(strCondition);
objQxRight.UpdateWithCondition(strCondition);
}
else
{
objQxRight.RightId = clsQxRightBL.GetMaxStrId_S();
objQxRight.AddNewRecord();
}
return true; 
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_Update)
 /// </summary>
 /// <param name = "objQxRightEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsQxRightEN objQxRightEN)
{
 if (string.IsNullOrEmpty(objQxRightEN.RightId) == true)
 {
string strMsg = string.Format("(errid:Busi000095)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsQxRightBL.QxRightDA.UpdateBySql2(objQxRightEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsQxRightBL.ReFreshCache();

if (clsQxRightBL.relatedActions != null)
{
clsQxRightBL.relatedActions.UpdRelaTabDate(objQxRightEN.RightId, objQxRightEN.UpdUser);
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
 /// <param name = "objQxRightEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsQxRightEN objQxRightEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (string.IsNullOrEmpty(objQxRightEN.RightId) == true)
 {
string strMsg = string.Format("(errid:Busi000087)修改记录时关键字不能为空!(带事务处理)(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsQxRightBL.QxRightDA.UpdateBySql2(objQxRightEN, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsQxRightBL.ReFreshCache();

if (clsQxRightBL.relatedActions != null)
{
clsQxRightBL.relatedActions.UpdRelaTabDate(objQxRightEN.RightId, objQxRightEN.UpdUser);
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
 /// <param name = "objQxRightEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsQxRightEN objQxRightEN, string strWhereCond)
{
try
{
bool bolResult = clsQxRightBL.QxRightDA.UpdateBySqlWithCondition(objQxRightEN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsQxRightBL.ReFreshCache();

if (clsQxRightBL.relatedActions != null)
{
clsQxRightBL.relatedActions.UpdRelaTabDate(objQxRightEN.RightId, objQxRightEN.UpdUser);
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
 /// <param name = "objQxRightEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsQxRightEN objQxRightEN, string strWhereCond, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
bool bolResult = clsQxRightBL.QxRightDA.UpdateBySqlWithConditionTransaction(objQxRightEN, strWhereCond, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsQxRightBL.ReFreshCache();

if (clsQxRightBL.relatedActions != null)
{
clsQxRightBL.relatedActions.UpdRelaTabDate(objQxRightEN.RightId, objQxRightEN.UpdUser);
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
 /// <param name = "strRightId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int Delete(this clsQxRightEN objQxRightEN)
{
try
{
int intRecNum = clsQxRightBL.QxRightDA.DelRecord(objQxRightEN.RightId);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsQxRightBL.ReFreshCache();

if (clsQxRightBL.relatedActions != null)
{
clsQxRightBL.relatedActions.UpdRelaTabDate(objQxRightEN.RightId, objQxRightEN.UpdUser);
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
 /// <param name = "objQxRightENS">源对象</param>
 /// <param name = "objQxRightENT">目标对象</param>
 public static void CopyTo(this clsQxRightEN objQxRightENS, clsQxRightEN objQxRightENT)
{
try
{
objQxRightENT.RightId = objQxRightENS.RightId; //权限编号
objQxRightENT.RightName = objQxRightENS.RightName; //权限名称
objQxRightENT.RightTypeId = objQxRightENS.RightTypeId; //权限类型编号
objQxRightENT.FuncModuleId = objQxRightENS.FuncModuleId; //功能模块Id
objQxRightENT.RightRangeLevelId = objQxRightENS.RightRangeLevelId; //权限范围等级Id
objQxRightENT.UpdDate = objQxRightENS.UpdDate; //修改日期
objQxRightENT.UpdUser = objQxRightENS.UpdUser; //修改人
objQxRightENT.Memo = objQxRightENS.Memo; //备注
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
 /// <param name = "objQxRightENS">源对象</param>
 /// <returns>目标对象=>clsQxRightEN:objQxRightENT</returns>
 public static clsQxRightEN CopyTo(this clsQxRightEN objQxRightENS)
{
try
{
 clsQxRightEN objQxRightENT = new clsQxRightEN()
{
RightId = objQxRightENS.RightId, //权限编号
RightName = objQxRightENS.RightName, //权限名称
RightTypeId = objQxRightENS.RightTypeId, //权限类型编号
FuncModuleId = objQxRightENS.FuncModuleId, //功能模块Id
RightRangeLevelId = objQxRightENS.RightRangeLevelId, //权限范围等级Id
UpdDate = objQxRightENS.UpdDate, //修改日期
UpdUser = objQxRightENS.UpdUser, //修改人
Memo = objQxRightENS.Memo, //备注
};
 return objQxRightENT;
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
public static void CheckPropertyNew(this clsQxRightEN objQxRightEN)
{
 clsQxRightBL.QxRightDA.CheckPropertyNew(objQxRightEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(this clsQxRightEN objQxRightEN)
{
 clsQxRightBL.QxRightDA.CheckProperty4Condition(objQxRightEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsQxRightEN objQxRightCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objQxRightCond.IsUpdated(conQxRight.RightId) == true)
{
string strComparisonOpRightId = objQxRightCond.dicFldComparisonOp[conQxRight.RightId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conQxRight.RightId, objQxRightCond.RightId, strComparisonOpRightId);
}
if (objQxRightCond.IsUpdated(conQxRight.RightName) == true)
{
string strComparisonOpRightName = objQxRightCond.dicFldComparisonOp[conQxRight.RightName];
strWhereCond += string.Format(" And {0} {2} '{1}'", conQxRight.RightName, objQxRightCond.RightName, strComparisonOpRightName);
}
if (objQxRightCond.IsUpdated(conQxRight.RightTypeId) == true)
{
string strComparisonOpRightTypeId = objQxRightCond.dicFldComparisonOp[conQxRight.RightTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conQxRight.RightTypeId, objQxRightCond.RightTypeId, strComparisonOpRightTypeId);
}
if (objQxRightCond.IsUpdated(conQxRight.FuncModuleId) == true)
{
string strComparisonOpFuncModuleId = objQxRightCond.dicFldComparisonOp[conQxRight.FuncModuleId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conQxRight.FuncModuleId, objQxRightCond.FuncModuleId, strComparisonOpFuncModuleId);
}
if (objQxRightCond.IsUpdated(conQxRight.RightRangeLevelId) == true)
{
string strComparisonOpRightRangeLevelId = objQxRightCond.dicFldComparisonOp[conQxRight.RightRangeLevelId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conQxRight.RightRangeLevelId, objQxRightCond.RightRangeLevelId, strComparisonOpRightRangeLevelId);
}
if (objQxRightCond.IsUpdated(conQxRight.UpdDate) == true)
{
string strComparisonOpUpdDate = objQxRightCond.dicFldComparisonOp[conQxRight.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conQxRight.UpdDate, objQxRightCond.UpdDate, strComparisonOpUpdDate);
}
if (objQxRightCond.IsUpdated(conQxRight.UpdUser) == true)
{
string strComparisonOpUpdUser = objQxRightCond.dicFldComparisonOp[conQxRight.UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", conQxRight.UpdUser, objQxRightCond.UpdUser, strComparisonOpUpdUser);
}
if (objQxRightCond.IsUpdated(conQxRight.Memo) == true)
{
string strComparisonOpMemo = objQxRightCond.dicFldComparisonOp[conQxRight.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", conQxRight.Memo, objQxRightCond.Memo, strComparisonOpMemo);
}
 return strWhereCond;
}

 /// <summary>
 /// 检查唯一性(Uniqueness)--QxRight(用户权限), 如果不唯一,即存在相同的记录,就返回False
 /// 唯一性条件:RightName_RightTypeId
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckConstraint)
 /// </summary>
 /// <param name = "objQxRightEN">要求唯一的对象</param>
 /// <returns></returns>
public static bool CheckUniqueness(this clsQxRightEN objQxRightEN)
{
//检测记录是否存在
bool bolIsUniqueness;
StringBuilder sbCondition = new StringBuilder();
if (objQxRightEN == null) return true;
if (objQxRightEN.RightId == null || objQxRightEN.RightId == "")
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and RightName = '{0}'", objQxRightEN.RightName);
 sbCondition.AppendFormat(" and RightTypeId = '{0}'", objQxRightEN.RightTypeId);
if (clsQxRightBL.IsExistRecord(sbCondition.ToString())  ==  true)
{
 bolIsUniqueness = false;
}
else
{
 bolIsUniqueness = true;
}
}
 else {
sbCondition.AppendFormat("RightId !=  '{0}'", objQxRightEN.RightId);
 sbCondition.AppendFormat(" and RightName = '{0}'", objQxRightEN.RightName);
 sbCondition.AppendFormat(" and RightTypeId = '{0}'", objQxRightEN.RightTypeId);
if (clsQxRightBL.IsExistRecord(sbCondition.ToString())  ==  true)
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
 /// 获取唯一性条件串--QxRight(用户权限), 即由对象中唯一性条件字段关键字与值组成的条件串
 /// 唯一性条件:RightName_RightTypeId
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetConditionString4Constraint)
 /// </summary>
 /// <param name = "objQxRightEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(this clsQxRightEN objQxRightEN)
{
//检测记录是否存在
StringBuilder sbCondition = new StringBuilder();
if (objQxRightEN == null) return "";
if (objQxRightEN.RightId == null || objQxRightEN.RightId == "")
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and RightName = '{0}'", objQxRightEN.RightName);
 sbCondition.AppendFormat(" and RightTypeId = '{0}'", objQxRightEN.RightTypeId);
return sbCondition.ToString();
}
 else {
sbCondition.AppendFormat("RightId !=  '{0}'", objQxRightEN.RightId);
 sbCondition.AppendFormat(" and RightName = '{0}'", objQxRightEN.RightName);
 sbCondition.AppendFormat(" and RightTypeId = '{0}'", objQxRightEN.RightTypeId);
 return sbCondition.ToString();
}
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_QxRight
{
public virtual bool UpdRelaTabDate(string strRightId, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// 用户权限(QxRight)
 /// 数据源类型:表
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsQxRightBL
{
public static RelatedActions_QxRight relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsQxRightDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsQxRightDA QxRightDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsQxRightDA();
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
 public clsQxRightBL()
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
if (string.IsNullOrEmpty(clsQxRightEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsQxRightEN._ConnectString);
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
public static DataTable GetDataTable_QxRight(string strWhereCond)
{
DataTable objDT;
try
{
objDT = QxRightDA.GetDataTable_QxRight(strWhereCond);
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
objDT = QxRightDA.GetDataTable(strWhereCond);
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
objDT = QxRightDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = QxRightDA.GetDataTable(strWhereCond, strTabName);
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
objDT = QxRightDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = QxRightDA.GetDataTable_Top(objTopPara);
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
objDT = QxRightDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = QxRightDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = QxRightDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
 /// <param name = "arrRightIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static List<clsQxRightEN> GetObjLstByRightIdLst(List<string> arrRightIdLst)
{
List<clsQxRightEN> arrObjLst = new List<clsQxRightEN>(); 
System.Data.DataTable objDT; 
 string strSqlConditionStr = clsArray.GetSqlInStrByArray(arrRightIdLst, true);
 string strWhereCond = string.Format("RightId in ({0})", strSqlConditionStr);
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsQxRightEN objQxRightEN = new clsQxRightEN();
try
{
objQxRightEN.RightId = objRow[conQxRight.RightId].ToString().Trim(); //权限编号
objQxRightEN.RightName = objRow[conQxRight.RightName].ToString().Trim(); //权限名称
objQxRightEN.RightTypeId = objRow[conQxRight.RightTypeId].ToString().Trim(); //权限类型编号
objQxRightEN.FuncModuleId = objRow[conQxRight.FuncModuleId] == DBNull.Value ? null : objRow[conQxRight.FuncModuleId].ToString().Trim(); //功能模块Id
objQxRightEN.RightRangeLevelId = objRow[conQxRight.RightRangeLevelId].ToString().Trim(); //权限范围等级Id
objQxRightEN.UpdDate = objRow[conQxRight.UpdDate] == DBNull.Value ? null : objRow[conQxRight.UpdDate].ToString().Trim(); //修改日期
objQxRightEN.UpdUser = objRow[conQxRight.UpdUser] == DBNull.Value ? null : objRow[conQxRight.UpdUser].ToString().Trim(); //修改人
objQxRightEN.Memo = objRow[conQxRight.Memo] == DBNull.Value ? null : objRow[conQxRight.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objQxRightEN.RightId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objQxRightEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrRightIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsQxRightEN> GetObjLstByRightIdLstCache(List<string> arrRightIdLst)
{
string strKey = string.Format("{0}", clsQxRightEN._CurrTabName);
List<clsQxRightEN> arrQxRightObjLstCache = GetObjLstCache();
IEnumerable <clsQxRightEN> arrQxRightObjLst_Sel =
arrQxRightObjLstCache
.Where(x => arrRightIdLst.Contains(x.RightId));
return arrQxRightObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsQxRightEN> GetObjLst(string strWhereCond)
{
List<clsQxRightEN> arrObjLst = new List<clsQxRightEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsQxRightEN objQxRightEN = new clsQxRightEN();
try
{
objQxRightEN.RightId = objRow[conQxRight.RightId].ToString().Trim(); //权限编号
objQxRightEN.RightName = objRow[conQxRight.RightName].ToString().Trim(); //权限名称
objQxRightEN.RightTypeId = objRow[conQxRight.RightTypeId].ToString().Trim(); //权限类型编号
objQxRightEN.FuncModuleId = objRow[conQxRight.FuncModuleId] == DBNull.Value ? null : objRow[conQxRight.FuncModuleId].ToString().Trim(); //功能模块Id
objQxRightEN.RightRangeLevelId = objRow[conQxRight.RightRangeLevelId].ToString().Trim(); //权限范围等级Id
objQxRightEN.UpdDate = objRow[conQxRight.UpdDate] == DBNull.Value ? null : objRow[conQxRight.UpdDate].ToString().Trim(); //修改日期
objQxRightEN.UpdUser = objRow[conQxRight.UpdUser] == DBNull.Value ? null : objRow[conQxRight.UpdUser].ToString().Trim(); //修改人
objQxRightEN.Memo = objRow[conQxRight.Memo] == DBNull.Value ? null : objRow[conQxRight.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objQxRightEN.RightId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objQxRightEN);
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
public static List<clsQxRightEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsQxRightEN> arrObjLst = new List<clsQxRightEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsQxRightEN objQxRightEN = new clsQxRightEN();
try
{
objQxRightEN.RightId = objRow[conQxRight.RightId].ToString().Trim(); //权限编号
objQxRightEN.RightName = objRow[conQxRight.RightName].ToString().Trim(); //权限名称
objQxRightEN.RightTypeId = objRow[conQxRight.RightTypeId].ToString().Trim(); //权限类型编号
objQxRightEN.FuncModuleId = objRow[conQxRight.FuncModuleId] == DBNull.Value ? null : objRow[conQxRight.FuncModuleId].ToString().Trim(); //功能模块Id
objQxRightEN.RightRangeLevelId = objRow[conQxRight.RightRangeLevelId].ToString().Trim(); //权限范围等级Id
objQxRightEN.UpdDate = objRow[conQxRight.UpdDate] == DBNull.Value ? null : objRow[conQxRight.UpdDate].ToString().Trim(); //修改日期
objQxRightEN.UpdUser = objRow[conQxRight.UpdUser] == DBNull.Value ? null : objRow[conQxRight.UpdUser].ToString().Trim(); //修改人
objQxRightEN.Memo = objRow[conQxRight.Memo] == DBNull.Value ? null : objRow[conQxRight.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objQxRightEN.RightId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objQxRightEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objQxRightCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsQxRightEN> GetSubObjLstCache(clsQxRightEN objQxRightCond)
{
List<clsQxRightEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsQxRightEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conQxRight.AttributeName)
{
if (objQxRightCond.IsUpdated(strFldName) == false) continue;
if (objQxRightCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objQxRightCond[strFldName].ToString());
}
else
{
if (objQxRightCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objQxRightCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objQxRightCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objQxRightCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objQxRightCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objQxRightCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objQxRightCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objQxRightCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objQxRightCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objQxRightCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objQxRightCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objQxRightCond[strFldName]));
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
public static List<clsQxRightEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsQxRightEN> arrObjLst = new List<clsQxRightEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsQxRightEN objQxRightEN = new clsQxRightEN();
try
{
objQxRightEN.RightId = objRow[conQxRight.RightId].ToString().Trim(); //权限编号
objQxRightEN.RightName = objRow[conQxRight.RightName].ToString().Trim(); //权限名称
objQxRightEN.RightTypeId = objRow[conQxRight.RightTypeId].ToString().Trim(); //权限类型编号
objQxRightEN.FuncModuleId = objRow[conQxRight.FuncModuleId] == DBNull.Value ? null : objRow[conQxRight.FuncModuleId].ToString().Trim(); //功能模块Id
objQxRightEN.RightRangeLevelId = objRow[conQxRight.RightRangeLevelId].ToString().Trim(); //权限范围等级Id
objQxRightEN.UpdDate = objRow[conQxRight.UpdDate] == DBNull.Value ? null : objRow[conQxRight.UpdDate].ToString().Trim(); //修改日期
objQxRightEN.UpdUser = objRow[conQxRight.UpdUser] == DBNull.Value ? null : objRow[conQxRight.UpdUser].ToString().Trim(); //修改人
objQxRightEN.Memo = objRow[conQxRight.Memo] == DBNull.Value ? null : objRow[conQxRight.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objQxRightEN.RightId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objQxRightEN);
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
public static List<clsQxRightEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsQxRightEN> arrObjLst = new List<clsQxRightEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsQxRightEN objQxRightEN = new clsQxRightEN();
try
{
objQxRightEN.RightId = objRow[conQxRight.RightId].ToString().Trim(); //权限编号
objQxRightEN.RightName = objRow[conQxRight.RightName].ToString().Trim(); //权限名称
objQxRightEN.RightTypeId = objRow[conQxRight.RightTypeId].ToString().Trim(); //权限类型编号
objQxRightEN.FuncModuleId = objRow[conQxRight.FuncModuleId] == DBNull.Value ? null : objRow[conQxRight.FuncModuleId].ToString().Trim(); //功能模块Id
objQxRightEN.RightRangeLevelId = objRow[conQxRight.RightRangeLevelId].ToString().Trim(); //权限范围等级Id
objQxRightEN.UpdDate = objRow[conQxRight.UpdDate] == DBNull.Value ? null : objRow[conQxRight.UpdDate].ToString().Trim(); //修改日期
objQxRightEN.UpdUser = objRow[conQxRight.UpdUser] == DBNull.Value ? null : objRow[conQxRight.UpdUser].ToString().Trim(); //修改人
objQxRightEN.Memo = objRow[conQxRight.Memo] == DBNull.Value ? null : objRow[conQxRight.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objQxRightEN.RightId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objQxRightEN);
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
List<clsQxRightEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsQxRightEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsQxRightEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsQxRightEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsQxRightEN> arrObjLst = new List<clsQxRightEN>(); 
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
	clsQxRightEN objQxRightEN = new clsQxRightEN();
try
{
objQxRightEN.RightId = objRow[conQxRight.RightId].ToString().Trim(); //权限编号
objQxRightEN.RightName = objRow[conQxRight.RightName].ToString().Trim(); //权限名称
objQxRightEN.RightTypeId = objRow[conQxRight.RightTypeId].ToString().Trim(); //权限类型编号
objQxRightEN.FuncModuleId = objRow[conQxRight.FuncModuleId] == DBNull.Value ? null : objRow[conQxRight.FuncModuleId].ToString().Trim(); //功能模块Id
objQxRightEN.RightRangeLevelId = objRow[conQxRight.RightRangeLevelId].ToString().Trim(); //权限范围等级Id
objQxRightEN.UpdDate = objRow[conQxRight.UpdDate] == DBNull.Value ? null : objRow[conQxRight.UpdDate].ToString().Trim(); //修改日期
objQxRightEN.UpdUser = objRow[conQxRight.UpdUser] == DBNull.Value ? null : objRow[conQxRight.UpdUser].ToString().Trim(); //修改人
objQxRightEN.Memo = objRow[conQxRight.Memo] == DBNull.Value ? null : objRow[conQxRight.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objQxRightEN.RightId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objQxRightEN);
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
public static List<clsQxRightEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsQxRightEN> arrObjLst = new List<clsQxRightEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsQxRightEN objQxRightEN = new clsQxRightEN();
try
{
objQxRightEN.RightId = objRow[conQxRight.RightId].ToString().Trim(); //权限编号
objQxRightEN.RightName = objRow[conQxRight.RightName].ToString().Trim(); //权限名称
objQxRightEN.RightTypeId = objRow[conQxRight.RightTypeId].ToString().Trim(); //权限类型编号
objQxRightEN.FuncModuleId = objRow[conQxRight.FuncModuleId] == DBNull.Value ? null : objRow[conQxRight.FuncModuleId].ToString().Trim(); //功能模块Id
objQxRightEN.RightRangeLevelId = objRow[conQxRight.RightRangeLevelId].ToString().Trim(); //权限范围等级Id
objQxRightEN.UpdDate = objRow[conQxRight.UpdDate] == DBNull.Value ? null : objRow[conQxRight.UpdDate].ToString().Trim(); //修改日期
objQxRightEN.UpdUser = objRow[conQxRight.UpdUser] == DBNull.Value ? null : objRow[conQxRight.UpdUser].ToString().Trim(); //修改人
objQxRightEN.Memo = objRow[conQxRight.Memo] == DBNull.Value ? null : objRow[conQxRight.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objQxRightEN.RightId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objQxRightEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsQxRightEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsQxRightEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsQxRightEN> arrObjLst = new List<clsQxRightEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsQxRightEN objQxRightEN = new clsQxRightEN();
try
{
objQxRightEN.RightId = objRow[conQxRight.RightId].ToString().Trim(); //权限编号
objQxRightEN.RightName = objRow[conQxRight.RightName].ToString().Trim(); //权限名称
objQxRightEN.RightTypeId = objRow[conQxRight.RightTypeId].ToString().Trim(); //权限类型编号
objQxRightEN.FuncModuleId = objRow[conQxRight.FuncModuleId] == DBNull.Value ? null : objRow[conQxRight.FuncModuleId].ToString().Trim(); //功能模块Id
objQxRightEN.RightRangeLevelId = objRow[conQxRight.RightRangeLevelId].ToString().Trim(); //权限范围等级Id
objQxRightEN.UpdDate = objRow[conQxRight.UpdDate] == DBNull.Value ? null : objRow[conQxRight.UpdDate].ToString().Trim(); //修改日期
objQxRightEN.UpdUser = objRow[conQxRight.UpdUser] == DBNull.Value ? null : objRow[conQxRight.UpdUser].ToString().Trim(); //修改人
objQxRightEN.Memo = objRow[conQxRight.Memo] == DBNull.Value ? null : objRow[conQxRight.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objQxRightEN.RightId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objQxRightEN);
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
public static List<clsQxRightEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsQxRightEN> arrObjLst = new List<clsQxRightEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsQxRightEN objQxRightEN = new clsQxRightEN();
try
{
objQxRightEN.RightId = objRow[conQxRight.RightId].ToString().Trim(); //权限编号
objQxRightEN.RightName = objRow[conQxRight.RightName].ToString().Trim(); //权限名称
objQxRightEN.RightTypeId = objRow[conQxRight.RightTypeId].ToString().Trim(); //权限类型编号
objQxRightEN.FuncModuleId = objRow[conQxRight.FuncModuleId] == DBNull.Value ? null : objRow[conQxRight.FuncModuleId].ToString().Trim(); //功能模块Id
objQxRightEN.RightRangeLevelId = objRow[conQxRight.RightRangeLevelId].ToString().Trim(); //权限范围等级Id
objQxRightEN.UpdDate = objRow[conQxRight.UpdDate] == DBNull.Value ? null : objRow[conQxRight.UpdDate].ToString().Trim(); //修改日期
objQxRightEN.UpdUser = objRow[conQxRight.UpdUser] == DBNull.Value ? null : objRow[conQxRight.UpdUser].ToString().Trim(); //修改人
objQxRightEN.Memo = objRow[conQxRight.Memo] == DBNull.Value ? null : objRow[conQxRight.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objQxRightEN.RightId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objQxRightEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsQxRightEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsQxRightEN> arrObjLst = new List<clsQxRightEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsQxRightEN objQxRightEN = new clsQxRightEN();
try
{
objQxRightEN.RightId = objRow[conQxRight.RightId].ToString().Trim(); //权限编号
objQxRightEN.RightName = objRow[conQxRight.RightName].ToString().Trim(); //权限名称
objQxRightEN.RightTypeId = objRow[conQxRight.RightTypeId].ToString().Trim(); //权限类型编号
objQxRightEN.FuncModuleId = objRow[conQxRight.FuncModuleId] == DBNull.Value ? null : objRow[conQxRight.FuncModuleId].ToString().Trim(); //功能模块Id
objQxRightEN.RightRangeLevelId = objRow[conQxRight.RightRangeLevelId].ToString().Trim(); //权限范围等级Id
objQxRightEN.UpdDate = objRow[conQxRight.UpdDate] == DBNull.Value ? null : objRow[conQxRight.UpdDate].ToString().Trim(); //修改日期
objQxRightEN.UpdUser = objRow[conQxRight.UpdUser] == DBNull.Value ? null : objRow[conQxRight.UpdUser].ToString().Trim(); //修改人
objQxRightEN.Memo = objRow[conQxRight.Memo] == DBNull.Value ? null : objRow[conQxRight.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objQxRightEN.RightId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objQxRightEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objQxRightEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetQxRight(ref clsQxRightEN objQxRightEN)
{
bool bolResult = QxRightDA.GetQxRight(ref objQxRightEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "strRightId">表关键字</param>
 /// <returns>表对象</returns>
public static clsQxRightEN GetObjByRightId(string strRightId)
{
if (strRightId.IndexOf(' ') >=0)
{
var strMsg = string.Format("(errid:Busi000079)在表中,关键字[strRightId]中不能有空格!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
if (string.IsNullOrEmpty(strRightId) == true)
{
var strMsg = string.Format("(errid:Busi000020)在表中,关键字[strRightId]不能为空!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
clsQxRightEN objQxRightEN = QxRightDA.GetObjByRightId(strRightId);
return objQxRightEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsQxRightEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsQxRightEN objQxRightEN = QxRightDA.GetFirstObj(strWhereCond);
 return objQxRightEN;
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
public static clsQxRightEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsQxRightEN objQxRightEN = QxRightDA.GetObjByDataRow(objRow);
 return objQxRightEN;
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
public static clsQxRightEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsQxRightEN objQxRightEN = QxRightDA.GetObjByDataRow(objRow);
 return objQxRightEN;
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
 /// <param name = "strRightId">所给的关键字</param>
 /// <param name = "lstQxRightObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsQxRightEN GetObjByRightIdFromList(string strRightId, List<clsQxRightEN> lstQxRightObjLst)
{
foreach (clsQxRightEN objQxRightEN in lstQxRightObjLst)
{
if (objQxRightEN.RightId == strRightId)
{
return objQxRightEN;
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
 string strMaxRightId;
 try
 {
 strMaxRightId = clsQxRightDA.GetMaxStrId();
 return strMaxRightId;
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
 string strRightId;
 try
 {
 strRightId = new clsQxRightDA().GetFirstID(strWhereCond);
 return strRightId;
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
 arrList = QxRightDA.GetID(strWhereCond);
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
bool bolIsExist = QxRightDA.IsExistCondRec(strWhereCond);
return bolIsExist;
}

 /// <summary>
 /// 判断当前表中是否存在给定关键字值的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExist)
 /// </summary>
 /// <param name = "strRightId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public static bool IsExist(string strRightId)
{
if (string.IsNullOrEmpty(strRightId) == true)
{
var strMsg = string.Format("(errid:Busi000027)在表中,关键字[strRightId]不能为空!!(from {0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
//检测记录是否存在
bool bolIsExist = QxRightDA.IsExist(strRightId);
return bolIsExist;
}

/// <summary>
/// 设置修改时间
/// </summary>
/// <param name = "strRightId">权限编号</param>
/// <param name = "strOpUser">修改用户</param>
/// <returns>是否成功？</returns>
public static bool SetUpdDate(string strRightId, string strOpUser)
{
clsQxRightEN objQxRightEN = clsQxRightBL.GetObjByRightId(strRightId);
objQxRightEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
objQxRightEN.UpdUser = strOpUser;
return clsQxRightBL.UpdateBySql2(objQxRightEN);
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
 bolIsExist = clsQxRightDA.IsExistTable();
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
 bolIsExist = QxRightDA.IsExistTable(strTabName);
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
 /// <param name = "objQxRightEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecordBySql2(clsQxRightEN objQxRightEN, bool bolIsNeedCheckUniqueness=true)
{
if (bolIsNeedCheckUniqueness == true && objQxRightEN.CheckUniqueness() == false)
{
var strMsg = string.Format("记录已经存在!权限名称 = [{0}],权限类型编号 = [{1}]的数据已经存在!(in clsQxRightBL.AddNewRecordBySql2)", objQxRightEN.RightName,objQxRightEN.RightTypeId);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objQxRightEN.RightId) == true || clsQxRightBL.IsExist(objQxRightEN.RightId) == true)
 {
     objQxRightEN.RightId = clsQxRightBL.GetMaxStrId_S();
 }
bool bolResult = QxRightDA.AddNewRecordBySQL2(objQxRightEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsQxRightBL.ReFreshCache();

if (clsQxRightBL.relatedActions != null)
{
clsQxRightBL.relatedActions.UpdRelaTabDate(objQxRightEN.RightId, objQxRightEN.UpdUser);
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
 /// <param name = "objQxRightEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordBySql2WithReturnKey(clsQxRightEN objQxRightEN, bool bolIsNeedCheckUniqueness=true)
{
if (bolIsNeedCheckUniqueness == true && objQxRightEN.CheckUniqueness() == false)
{
var strMsg = string.Format("记录已经存在!权限名称 = [{0}],权限类型编号 = [{1}]的数据已经存在!(in clsQxRightBL.AddNewRecordBySql2WithReturnKey)", objQxRightEN.RightName,objQxRightEN.RightTypeId);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objQxRightEN.RightId) == true || clsQxRightBL.IsExist(objQxRightEN.RightId) == true)
 {
     objQxRightEN.RightId = clsQxRightBL.GetMaxStrId_S();
 }
string strKey = QxRightDA.AddNewRecordBySQL2WithReturnKey(objQxRightEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsQxRightBL.ReFreshCache();

if (clsQxRightBL.relatedActions != null)
{
clsQxRightBL.relatedActions.UpdRelaTabDate(objQxRightEN.RightId, objQxRightEN.UpdUser);
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
 /// <param name = "objQxRightEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(clsQxRightEN objQxRightEN)
{
try
{
bool bolResult = QxRightDA.Update(objQxRightEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsQxRightBL.ReFreshCache();

if (clsQxRightBL.relatedActions != null)
{
clsQxRightBL.relatedActions.UpdRelaTabDate(objQxRightEN.RightId, objQxRightEN.UpdUser);
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
 /// <param name = "objQxRightEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateBySql2(clsQxRightEN objQxRightEN)
{
 if (string.IsNullOrEmpty(objQxRightEN.RightId) == true)
 {
var strMsg = string.Format("(errid:Busi000065)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = QxRightDA.UpdateBySql2(objQxRightEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsQxRightBL.ReFreshCache();

if (clsQxRightBL.relatedActions != null)
{
clsQxRightBL.relatedActions.UpdRelaTabDate(objQxRightEN.RightId, objQxRightEN.UpdUser);
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
 /// <param name = "strRightId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int DelRecord(string strRightId)
{
try
{
 clsQxRightEN objQxRightEN = clsQxRightBL.GetObjByRightId(strRightId);

if (clsQxRightBL.relatedActions != null)
{
clsQxRightBL.relatedActions.UpdRelaTabDate(objQxRightEN.RightId, objQxRightEN.UpdUser);
}
if (objQxRightEN != null)
{
int intRecNum = QxRightDA.DelRecord(strRightId);
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
/// <param name="strRightId">表关键字</param>
/// <returns></returns>
public static bool DelRecordEx(string strRightId )
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsQxRightDA.GetSpecSQLObj();
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
//删除与表:[QxRight]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conQxRight.RightId,
//strRightId);
//        clsQxRightBL.DelQxRightsByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsQxRightBL.DelRecord(strRightId, objConnection, objSqlTransaction);
objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsQxRightBLEx", "DelRecordEx", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("扩展删除记录出错:{0}!keyId = {1}.({2})",
objException.Message,
strRightId, clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "strRightId">给定的关键字值</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回删除是否成功?</returns>
public static bool DelRecord(string strRightId, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
if (clsQxRightBL.relatedActions != null)
{
clsQxRightBL.relatedActions.UpdRelaTabDate(strRightId, "UpdRelaTabDate");
}
bool bolResult = QxRightDA.DelRecord(strRightId,objSqlConnection,objSqlTransaction);
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
 /// <param name = "arrRightIdLst">给定的关键字值列表</param>
 /// <returns>返回删除的记录数</returns>
public static int DelQxRights(List<string> arrRightIdLst)
{
if (arrRightIdLst.Count == 0) return 0;
try
{
if (clsQxRightBL.relatedActions != null)
{
foreach (var strRightId in arrRightIdLst)
{
clsQxRightBL.relatedActions.UpdRelaTabDate(strRightId, "UpdRelaTabDate");
}
}
int intDelRecNum = QxRightDA.DelQxRight(arrRightIdLst);
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
public static int DelQxRightsByCond(string strWhereCond)
{
try
{
if (clsQxRightBL.relatedActions != null)
{
List<string> arrRightId = GetPrimaryKeyID_S(strWhereCond);
foreach (var strRightId in arrRightId)
{
clsQxRightBL.relatedActions.UpdRelaTabDate(strRightId, "UpdRelaTabDate");
}
}
int intRecNum = QxRightDA.DelQxRight(strWhereCond);
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
/// 这里仅仅是演示函数,使用时请复制到扩展类:[QxRight]中改名为:[DelRecord4MultiTabEx]使用
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DelRecord4MultiTab)
/// </summary>
/// <param name="strRightId">表关键字</param>
/// <returns></returns>
public static bool DelRecord4MultiTab(string strRightId)
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsQxRightDA.GetSpecSQLObj();
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
//删除与表:[QxRight]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conStudent.id_College,
//strid_College);
//        clsStudentBL.DelStudentsByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsQxRightBL.DelRecord(strRightId, objConnection, objSqlTransaction);
                objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsQxRightBL", "DelRecord4MultiTab", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("删除多表记录出错:{0}!keyId = {1}.({2})",
objException.Message,
strRightId, clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "objQxRightENS">源对象</param>
 /// <param name = "objQxRightENT">目标对象</param>
 public static void CopyTo(clsQxRightEN objQxRightENS, clsQxRightEN objQxRightENT)
{
try
{
objQxRightENT.RightId = objQxRightENS.RightId; //权限编号
objQxRightENT.RightName = objQxRightENS.RightName; //权限名称
objQxRightENT.RightTypeId = objQxRightENS.RightTypeId; //权限类型编号
objQxRightENT.FuncModuleId = objQxRightENS.FuncModuleId; //功能模块Id
objQxRightENT.RightRangeLevelId = objQxRightENS.RightRangeLevelId; //权限范围等级Id
objQxRightENT.UpdDate = objQxRightENS.UpdDate; //修改日期
objQxRightENT.UpdUser = objQxRightENS.UpdUser; //修改人
objQxRightENT.Memo = objQxRightENS.Memo; //备注
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
 /// <param name = "objQxRightEN">源简化对象</param>
 public static void SetUpdFlag(clsQxRightEN objQxRightEN)
{
try
{
objQxRightEN.ClearUpdateState();
   string strsfUpdFldSetStr = objQxRightEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(conQxRight.RightId, new clsStrCompareIgnoreCase())  ==  true)
{
objQxRightEN.RightId = objQxRightEN.RightId; //权限编号
}
if (arrFldSet.Contains(conQxRight.RightName, new clsStrCompareIgnoreCase())  ==  true)
{
objQxRightEN.RightName = objQxRightEN.RightName; //权限名称
}
if (arrFldSet.Contains(conQxRight.RightTypeId, new clsStrCompareIgnoreCase())  ==  true)
{
objQxRightEN.RightTypeId = objQxRightEN.RightTypeId; //权限类型编号
}
if (arrFldSet.Contains(conQxRight.FuncModuleId, new clsStrCompareIgnoreCase())  ==  true)
{
objQxRightEN.FuncModuleId = objQxRightEN.FuncModuleId == "[null]" ? null :  objQxRightEN.FuncModuleId; //功能模块Id
}
if (arrFldSet.Contains(conQxRight.RightRangeLevelId, new clsStrCompareIgnoreCase())  ==  true)
{
objQxRightEN.RightRangeLevelId = objQxRightEN.RightRangeLevelId; //权限范围等级Id
}
if (arrFldSet.Contains(conQxRight.UpdDate, new clsStrCompareIgnoreCase())  ==  true)
{
objQxRightEN.UpdDate = objQxRightEN.UpdDate == "[null]" ? null :  objQxRightEN.UpdDate; //修改日期
}
if (arrFldSet.Contains(conQxRight.UpdUser, new clsStrCompareIgnoreCase())  ==  true)
{
objQxRightEN.UpdUser = objQxRightEN.UpdUser == "[null]" ? null :  objQxRightEN.UpdUser; //修改人
}
if (arrFldSet.Contains(conQxRight.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objQxRightEN.Memo = objQxRightEN.Memo == "[null]" ? null :  objQxRightEN.Memo; //备注
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
 /// <param name = "objQxRightEN">源简化对象</param>
 public static void AccessFldValueNull(clsQxRightEN objQxRightEN)
{
try
{
if (objQxRightEN.FuncModuleId == "[null]") objQxRightEN.FuncModuleId = null; //功能模块Id
if (objQxRightEN.UpdDate == "[null]") objQxRightEN.UpdDate = null; //修改日期
if (objQxRightEN.UpdUser == "[null]") objQxRightEN.UpdUser = null; //修改人
if (objQxRightEN.Memo == "[null]") objQxRightEN.Memo = null; //备注
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
public static void CheckPropertyNew(clsQxRightEN objQxRightEN)
{
 QxRightDA.CheckPropertyNew(objQxRightEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(clsQxRightEN objQxRightEN)
{
 QxRightDA.CheckProperty4Condition(objQxRightEN);
 }


 #endregion 检查对象属性


 #region 绑定下拉框

 /// <summary>
 /// 绑定基于Win的下拉框
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_TabFeature_ComboBoxBindFunction)
 /// </summary>
 /// <param name = "objComboBox">需要绑定当前表的下拉框</param>

public static void BindCbo_RightId(System.Windows.Forms.ComboBox objComboBox )
{
//为数据源为表的下拉框设置内容
string strCondition = string.Format("1 =1 Order By {0}", conQxRight.RightId); 
List<clsQxRightEN> arrObjLst = clsQxRightBL.GetObjLst(strCondition);
//初始化一个对象列表
//插入第0项。在第0项中插入“请选择...”,为了方便用户,与WEB方式类似。
clsQxRightEN objQxRightEN = new clsQxRightEN()
{
RightId = "0",
RightName = "选[用户权限]..."
};
arrObjLst.Insert(0, objQxRightEN);
//设置下拉框的数据源、以及设置值项、显示项
objComboBox.ValueMember = conQxRight.RightId;
objComboBox.DisplayMember = conQxRight.RightName;
objComboBox.DataSource = arrObjLst;
objComboBox.SelectedIndex = 0;
}

 /// <summary>
 /// 绑定基于Web的下拉框
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_TabFeature_DdlBindFunction)
 /// </summary>
 /// <param name = "objDDL">需要绑定当前表的下拉框</param>

public static void BindDdl_RightId(System.Web.UI.WebControls.DropDownList objDDL )
{
//为数据源于表的下拉框设置内容
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[用户权限]...","0");
string strCondition = string.Format("1 =1 Order By {0}", conQxRight.RightId); 
IEnumerable<clsQxRightEN> arrObjLst = clsQxRightBL.GetObjLst(strCondition);
objDDL.DataValueField = conQxRight.RightId;
objDDL.DataTextField = conQxRight.RightName;
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
public static void BindDdl_RightIdCache(System.Web.UI.WebControls.DropDownList objDDL)
{
//为数据源于表的下拉框设置内容
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[用户权限]...","0");
List<clsQxRightEN> arrQxRightObjLst = GetAllQxRightObjLstCache(); 
objDDL.DataValueField = conQxRight.RightId;
objDDL.DataTextField = conQxRight.RightName;
objDDL.DataSource = arrQxRightObjLst;
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
if (clsQxRightBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsQxRightBL没有刷新缓存机制(clsQxRightBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by RightId");
//if (arrQxRightObjLstCache == null)
//{
//arrQxRightObjLstCache = QxRightDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "strRightId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsQxRightEN GetObjByRightIdCache(string strRightId)
{
//获取缓存中的对象列表
string strKey = string.Format("{0}", clsQxRightEN._CurrTabName);
List<clsQxRightEN> arrQxRightObjLstCache = GetObjLstCache();
IEnumerable <clsQxRightEN> arrQxRightObjLst_Sel =
arrQxRightObjLstCache
.Where(x=> x.RightId == strRightId 
);
if (arrQxRightObjLst_Sel.Count() == 0)
{
   clsQxRightEN obj = clsQxRightBL.GetObjByRightId(strRightId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
 }
return null;
}
return arrQxRightObjLst_Sel.First();
}

 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecNameByKeyCache)
 /// </summary>
 /// <param name = "strRightId">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetRightNameByRightIdCache(string strRightId)
{
if (string.IsNullOrEmpty(strRightId) == true) return "";
//获取缓存中的对象列表
clsQxRightEN objQxRight = GetObjByRightIdCache(strRightId);
if (objQxRight == null) return "";
return objQxRight.RightName;
}
 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecNameByKeyCache)
 /// </summary>
 /// <param name = "strRightId">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetNameByRightIdCache(string strRightId)
{
if (string.IsNullOrEmpty(strRightId) == true) return "";
//获取缓存中的对象列表
clsQxRightEN objQxRight = GetObjByRightIdCache(strRightId);
if (objQxRight == null) return "";
return objQxRight.RightName;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsQxRightEN> GetAllQxRightObjLstCache()
{
//获取缓存中的对象列表
List<clsQxRightEN> arrQxRightObjLstCache = GetObjLstCache(); 
return arrQxRightObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsQxRightEN> GetObjLstCache()
{
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}", clsQxRightEN._CurrTabName);
List<clsQxRightEN> arrQxRightObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrQxRightObjLstCache;
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
string strKey = string.Format("{0}", clsQxRightEN._CurrTabName);
CacheHelper.Remove(strKey);
clsQxRightEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
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
if (clsQxRightEN._RefreshTimeLst.Count == 0) return "";
return clsQxRightEN._RefreshTimeLst[clsQxRightEN._RefreshTimeLst.Count - 1];
}

 /// <summary>
 /// 刷新缓存.把当前表的缓存以及该表相关视图的缓存清空.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ReFreshCache)
 /// </summary>
public static void ReFreshCache()
{
if (clsQxRightBL.objCommFun4BL != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}", clsQxRightEN._CurrTabName);
CacheHelper.Remove(strKey);
clsQxRightEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
clsQxRightBL.objCommFun4BL.ReFreshCache();
}
}


 #endregion 缓存操作


 #region 检查唯一性

 /// <summary>
 /// 获取检查唯一性条件串(Uniqueness)--QxRight(用户权限)
 /// 唯一性条件:RightName_RightTypeId
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetUniquenessConditionString)
 /// </summary>
 /// <param name = "objQxRightEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(clsQxRightEN objQxRightEN)
{
//检测记录是否存在
string strResult = QxRightDA.GetUniCondStr(objQxRightEN);
return strResult;
}


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
public static string Func(string strInFldName, string strOutFldName, string strRightId)
{
if (strInFldName != conQxRight.RightId)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (conQxRight.AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", conQxRight.AttributeName));
throw new Exception(strMsg);
}
var objQxRight = clsQxRightBL.GetObjByRightIdCache(strRightId);
if (objQxRight == null) return "";
return objQxRight[strOutFldName].ToString();
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
int intRecCount = clsQxRightDA.GetRecCount(strTabName);
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
int intRecCount = clsQxRightDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsQxRightDA.GetRecCount();
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
int intRecCount = clsQxRightDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objQxRightCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsQxRightEN objQxRightCond)
{
List<clsQxRightEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsQxRightEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conQxRight.AttributeName)
{
if (objQxRightCond.IsUpdated(strFldName) == false) continue;
if (objQxRightCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objQxRightCond[strFldName].ToString());
}
else
{
if (objQxRightCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objQxRightCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objQxRightCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objQxRightCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objQxRightCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objQxRightCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objQxRightCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objQxRightCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objQxRightCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objQxRightCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objQxRightCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objQxRightCond[strFldName]));
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
 List<string> arrList = clsQxRightDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = QxRightDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = QxRightDA.GetFldValueNoDistinct(strFldName, strWhereCond);
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
int intRecCount = QxRightDA.SetFldValue(strFldName, strValue, strWhereCond);
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
int intRecCount = clsQxRightDA.SetFldValue(clsQxRightEN._CurrTabName, strFldName, fltValue, strWhereCond);
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
int intRecCount = QxRightDA.SetFldValue( strFldName, intValue, strWhereCond);
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
int intRecCount = clsQxRightDA.SetFldValue(strTabName, strFldName, strValue, strWhereCond);
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
int intRecCount = clsQxRightDA.SetFldValue(strTabName, strFldName, intValue, strWhereCond);
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
int intRecCount = clsQxRightDA.SetFldValue(strTabName, strFldName, fltValue, strWhereCond);
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
  strCreateTabCode.Append("CREATE table [dbo].[QxRight] "); 
 strCreateTabCode.Append(" ( "); 
 // /**权限编号*/ 
 strCreateTabCode.Append(" RightId char(8) primary key, "); 
 // /**权限名称*/ 
 strCreateTabCode.Append(" RightName varchar(200) not Null, "); 
 // /**权限类型编号*/ 
 strCreateTabCode.Append(" RightTypeId char(4) not Null, "); 
 // /**功能模块Id*/ 
 strCreateTabCode.Append(" FuncModuleId char(4) Null, "); 
 // /**权限范围等级Id*/ 
 strCreateTabCode.Append(" RightRangeLevelId char(2) not Null, "); 
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
 /// 用户权限(QxRight)
 /// 数据源类型:表
 /// (AutoGCLib.CommFun4BL4CSharp:GeneCode_This)
 /// </summary>
public class  clsCommFun4BL4QxRight : clsCommFun4BL
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
clsQxRightBL.ReFreshThisCache();
}
}

}