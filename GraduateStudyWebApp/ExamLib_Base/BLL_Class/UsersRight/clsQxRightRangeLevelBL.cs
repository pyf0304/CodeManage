
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsQxRightRangeLevelBL
 表名:QxRightRangeLevel(01120175)
 * 版本:2024.11.13.1(服务器:WIN-SRV103-116)
 日期:2024/11/13 06:19:54
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
public static class  clsQxRightRangeLevelBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "strRightRangeLevelId">表关键字</param>
 /// <returns>表对象</returns>
public static clsQxRightRangeLevelEN GetObj(this K_RightRangeLevelId_QxRightRangeLevel myKey)
{
clsQxRightRangeLevelEN objQxRightRangeLevelEN = clsQxRightRangeLevelBL.QxRightRangeLevelDA.GetObjByRightRangeLevelId(myKey.Value);
return objQxRightRangeLevelEN;
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_AddNewRecord)
 /// </summary>
 /// <param name = "objQxRightRangeLevelEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clsQxRightRangeLevelEN objQxRightRangeLevelEN, bool bolIsNeedCheckUniqueness = true)
{
if (bolIsNeedCheckUniqueness == true && CheckUniqueness(objQxRightRangeLevelEN) == false)
{
var strMsg = string.Format("记录已经存在!权限范围等级名称 = [{0}]的数据已经存在!(in clsQxRightRangeLevelBL.AddNewRecord)", objQxRightRangeLevelEN.RightRangeLevelName);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objQxRightRangeLevelEN.RightRangeLevelId) == true || clsQxRightRangeLevelBL.IsExist(objQxRightRangeLevelEN.RightRangeLevelId) == true)
 {
     objQxRightRangeLevelEN.RightRangeLevelId = clsQxRightRangeLevelBL.GetMaxStrId_S();
 }
bool bolResult = clsQxRightRangeLevelBL.QxRightRangeLevelDA.AddNewRecordBySQL2(objQxRightRangeLevelEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsQxRightRangeLevelBL.ReFreshCache();

if (clsQxRightRangeLevelBL.relatedActions != null)
{
clsQxRightRangeLevelBL.relatedActions.UpdRelaTabDate(objQxRightRangeLevelEN.RightRangeLevelId, objQxRightRangeLevelEN.UpdUser);
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
public static bool AddRecordEx(this clsQxRightRangeLevelEN objQxRightRangeLevelEN, bool bolIsNeedCheckUniqueness = true)
{
//操作步骤:
//1、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在
//2、检查唯一性
//3、检查传进去的对象属性是否合法
//4、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
//1、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在

//因为是字符型自增主键,不需要检查主键是否已经存在,在添加时,再获取 最大值作为主键
//if (clsQxRightRangeLevelBL.IsExist(objQxRightRangeLevelEN.RightRangeLevelId))	//判断是否有相同的关键字
//{
//strMsg = "(errid:Busi000151)关键字字段已有相同的值";
//throw new Exception(strMsg);
//}
try
{
 //2、检查传进去的对象属性是否合法
objQxRightRangeLevelEN.CheckPropertyNew();
 ///5.2、检查唯一性
if (bolIsNeedCheckUniqueness == true && objQxRightRangeLevelEN.CheckUniqueness() == false)
{
strMsg = string.Format("(权限范围等级名称(RightRangeLevelName)=[{0}])已经存在,不能重复!", objQxRightRangeLevelEN.RightRangeLevelName);
throw new Exception(strMsg);
}
//因为是字符型自增主键,所以在添加时,自动获取主键值。
 if (string.IsNullOrEmpty(objQxRightRangeLevelEN.RightRangeLevelId) == true || clsQxRightRangeLevelBL.IsExist(objQxRightRangeLevelEN.RightRangeLevelId) == true)
 {
     objQxRightRangeLevelEN.RightRangeLevelId = clsQxRightRangeLevelBL.GetMaxStrId_S();
 }
//6、把数据实体层的数据存贮到数据库中
objQxRightRangeLevelEN.AddNewRecord();
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
 /// <param name = "objQxRightRangeLevelEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static string AddNewRecordWithMaxId(this clsQxRightRangeLevelEN objQxRightRangeLevelEN, bool bolIsNeedCheckUniqueness = true)
{
if (bolIsNeedCheckUniqueness == true && CheckUniqueness(objQxRightRangeLevelEN) == false)
{
var strMsg = string.Format("记录已经存在!权限范围等级名称 = [{0}]的数据已经存在!(in clsQxRightRangeLevelBL.AddNewRecordWithMaxId)", objQxRightRangeLevelEN.RightRangeLevelName);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objQxRightRangeLevelEN.RightRangeLevelId) == true || clsQxRightRangeLevelBL.IsExist(objQxRightRangeLevelEN.RightRangeLevelId) == true)
 {
     objQxRightRangeLevelEN.RightRangeLevelId = clsQxRightRangeLevelBL.GetMaxStrId_S();
 }
string strRightRangeLevelId = clsQxRightRangeLevelBL.QxRightRangeLevelDA.AddNewRecordBySQL2WithReturnKey(objQxRightRangeLevelEN);
     objQxRightRangeLevelEN.RightRangeLevelId = strRightRangeLevelId;
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsQxRightRangeLevelBL.ReFreshCache();

if (clsQxRightRangeLevelBL.relatedActions != null)
{
clsQxRightRangeLevelBL.relatedActions.UpdRelaTabDate(objQxRightRangeLevelEN.RightRangeLevelId, objQxRightRangeLevelEN.UpdUser);
}
return strRightRangeLevelId;
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
 /// <param name = "objQxRightRangeLevelEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordWithReturnKey(this clsQxRightRangeLevelEN objQxRightRangeLevelEN, bool bolIsNeedCheckUniqueness = true)
{
if (bolIsNeedCheckUniqueness == true && CheckUniqueness(objQxRightRangeLevelEN) == false)
{
var strMsg = string.Format("记录已经存在!权限范围等级名称 = [{0}]的数据已经存在!(in clsQxRightRangeLevelBL.AddNewRecordWithReturnKey)", objQxRightRangeLevelEN.RightRangeLevelName);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objQxRightRangeLevelEN.RightRangeLevelId) == true || clsQxRightRangeLevelBL.IsExist(objQxRightRangeLevelEN.RightRangeLevelId) == true)
 {
     objQxRightRangeLevelEN.RightRangeLevelId = clsQxRightRangeLevelBL.GetMaxStrId_S();
 }
string strKey = clsQxRightRangeLevelBL.QxRightRangeLevelDA.AddNewRecordBySQL2WithReturnKey(objQxRightRangeLevelEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsQxRightRangeLevelBL.ReFreshCache();

if (clsQxRightRangeLevelBL.relatedActions != null)
{
clsQxRightRangeLevelBL.relatedActions.UpdRelaTabDate(objQxRightRangeLevelEN.RightRangeLevelId, objQxRightRangeLevelEN.UpdUser);
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
 /// <param name = "objQxRightRangeLevelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQxRightRangeLevelEN SetRightRangeLevelId(this clsQxRightRangeLevelEN objQxRightRangeLevelEN, string strRightRangeLevelId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strRightRangeLevelId, 2, conQxRightRangeLevel.RightRangeLevelId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strRightRangeLevelId, 2, conQxRightRangeLevel.RightRangeLevelId);
}
objQxRightRangeLevelEN.RightRangeLevelId = strRightRangeLevelId; //权限范围等级Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQxRightRangeLevelEN.dicFldComparisonOp.ContainsKey(conQxRightRangeLevel.RightRangeLevelId) == false)
{
objQxRightRangeLevelEN.dicFldComparisonOp.Add(conQxRightRangeLevel.RightRangeLevelId, strComparisonOp);
}
else
{
objQxRightRangeLevelEN.dicFldComparisonOp[conQxRightRangeLevel.RightRangeLevelId] = strComparisonOp;
}
}
return objQxRightRangeLevelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQxRightRangeLevelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQxRightRangeLevelEN SetRightRangeLevelName(this clsQxRightRangeLevelEN objQxRightRangeLevelEN, string strRightRangeLevelName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strRightRangeLevelName, conQxRightRangeLevel.RightRangeLevelName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strRightRangeLevelName, 30, conQxRightRangeLevel.RightRangeLevelName);
}
objQxRightRangeLevelEN.RightRangeLevelName = strRightRangeLevelName; //权限范围等级名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQxRightRangeLevelEN.dicFldComparisonOp.ContainsKey(conQxRightRangeLevel.RightRangeLevelName) == false)
{
objQxRightRangeLevelEN.dicFldComparisonOp.Add(conQxRightRangeLevel.RightRangeLevelName, strComparisonOp);
}
else
{
objQxRightRangeLevelEN.dicFldComparisonOp[conQxRightRangeLevel.RightRangeLevelName] = strComparisonOp;
}
}
return objQxRightRangeLevelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQxRightRangeLevelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQxRightRangeLevelEN SetUpdDate(this clsQxRightRangeLevelEN objQxRightRangeLevelEN, string strUpdDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdDate, 20, conQxRightRangeLevel.UpdDate);
}
objQxRightRangeLevelEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQxRightRangeLevelEN.dicFldComparisonOp.ContainsKey(conQxRightRangeLevel.UpdDate) == false)
{
objQxRightRangeLevelEN.dicFldComparisonOp.Add(conQxRightRangeLevel.UpdDate, strComparisonOp);
}
else
{
objQxRightRangeLevelEN.dicFldComparisonOp[conQxRightRangeLevel.UpdDate] = strComparisonOp;
}
}
return objQxRightRangeLevelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQxRightRangeLevelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQxRightRangeLevelEN SetUpdUser(this clsQxRightRangeLevelEN objQxRightRangeLevelEN, string strUpdUser, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdUser, 20, conQxRightRangeLevel.UpdUser);
}
objQxRightRangeLevelEN.UpdUser = strUpdUser; //修改人
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQxRightRangeLevelEN.dicFldComparisonOp.ContainsKey(conQxRightRangeLevel.UpdUser) == false)
{
objQxRightRangeLevelEN.dicFldComparisonOp.Add(conQxRightRangeLevel.UpdUser, strComparisonOp);
}
else
{
objQxRightRangeLevelEN.dicFldComparisonOp[conQxRightRangeLevel.UpdUser] = strComparisonOp;
}
}
return objQxRightRangeLevelEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objQxRightRangeLevelEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsQxRightRangeLevelEN SetMemo(this clsQxRightRangeLevelEN objQxRightRangeLevelEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, conQxRightRangeLevel.Memo);
}
objQxRightRangeLevelEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objQxRightRangeLevelEN.dicFldComparisonOp.ContainsKey(conQxRightRangeLevel.Memo) == false)
{
objQxRightRangeLevelEN.dicFldComparisonOp.Add(conQxRightRangeLevel.Memo, strComparisonOp);
}
else
{
objQxRightRangeLevelEN.dicFldComparisonOp[conQxRightRangeLevel.Memo] = strComparisonOp;
}
}
return objQxRightRangeLevelEN;
	}

 /// <summary>
 /// 修改记录存盘到数据表中
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_UpdateRecordEx)
 /// </summary>
 /// <param name = "objQxRightRangeLevelEN">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool UpdateRecordEx(this clsQxRightRangeLevelEN objQxRightRangeLevelEN)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
try
{
//1、检查传进去的对象属性是否合法
objQxRightRangeLevelEN.CheckPropertyNew();
clsQxRightRangeLevelEN objQxRightRangeLevelCond = new clsQxRightRangeLevelEN();
string strCondition = objQxRightRangeLevelCond
.SetRightRangeLevelId(objQxRightRangeLevelEN.RightRangeLevelId, "<>")
.SetRightRangeLevelName(objQxRightRangeLevelEN.RightRangeLevelName, "=")
.GetCombineCondition();
objQxRightRangeLevelEN._IsCheckProperty = true;
bool bolIsExist = clsQxRightRangeLevelBL.IsExistRecord(strCondition);
if (bolIsExist)
{
strMsg = "(RightRangeLevelName)不能重复!";
throw new Exception(strMsg);
}
//4、把数据实体层的数据存贮到数据库中
objQxRightRangeLevelEN.Update();
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
 /// <param name = "objQxRightRangeLevel">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool EditRecordEx(this clsQxRightRangeLevelEN objQxRightRangeLevel)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
clsQxRightRangeLevelEN objQxRightRangeLevelCond = new clsQxRightRangeLevelEN();
string strCondition = objQxRightRangeLevelCond
.SetRightRangeLevelName(objQxRightRangeLevel.RightRangeLevelName, "=")
.GetCombineCondition();
objQxRightRangeLevel._IsCheckProperty = true;
bool bolIsExist = clsQxRightRangeLevelBL.IsExistRecord(strCondition);
if (bolIsExist)
{
objQxRightRangeLevel.RightRangeLevelId = clsQxRightRangeLevelBL.GetFirstID_S(strCondition);
objQxRightRangeLevel.UpdateWithCondition(strCondition);
}
else
{
objQxRightRangeLevel.RightRangeLevelId = clsQxRightRangeLevelBL.GetMaxStrId_S();
objQxRightRangeLevel.AddNewRecord();
}
return true; 
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_Update)
 /// </summary>
 /// <param name = "objQxRightRangeLevelEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsQxRightRangeLevelEN objQxRightRangeLevelEN)
{
 if (string.IsNullOrEmpty(objQxRightRangeLevelEN.RightRangeLevelId) == true)
 {
string strMsg = string.Format("(errid:Busi000095)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsQxRightRangeLevelBL.QxRightRangeLevelDA.UpdateBySql2(objQxRightRangeLevelEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsQxRightRangeLevelBL.ReFreshCache();

if (clsQxRightRangeLevelBL.relatedActions != null)
{
clsQxRightRangeLevelBL.relatedActions.UpdRelaTabDate(objQxRightRangeLevelEN.RightRangeLevelId, objQxRightRangeLevelEN.UpdUser);
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
 /// <param name = "objQxRightRangeLevelEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsQxRightRangeLevelEN objQxRightRangeLevelEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (string.IsNullOrEmpty(objQxRightRangeLevelEN.RightRangeLevelId) == true)
 {
string strMsg = string.Format("(errid:Busi000087)修改记录时关键字不能为空!(带事务处理)(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsQxRightRangeLevelBL.QxRightRangeLevelDA.UpdateBySql2(objQxRightRangeLevelEN, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsQxRightRangeLevelBL.ReFreshCache();

if (clsQxRightRangeLevelBL.relatedActions != null)
{
clsQxRightRangeLevelBL.relatedActions.UpdRelaTabDate(objQxRightRangeLevelEN.RightRangeLevelId, objQxRightRangeLevelEN.UpdUser);
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
 /// <param name = "objQxRightRangeLevelEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsQxRightRangeLevelEN objQxRightRangeLevelEN, string strWhereCond)
{
try
{
bool bolResult = clsQxRightRangeLevelBL.QxRightRangeLevelDA.UpdateBySqlWithCondition(objQxRightRangeLevelEN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsQxRightRangeLevelBL.ReFreshCache();

if (clsQxRightRangeLevelBL.relatedActions != null)
{
clsQxRightRangeLevelBL.relatedActions.UpdRelaTabDate(objQxRightRangeLevelEN.RightRangeLevelId, objQxRightRangeLevelEN.UpdUser);
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
 /// <param name = "objQxRightRangeLevelEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsQxRightRangeLevelEN objQxRightRangeLevelEN, string strWhereCond, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
bool bolResult = clsQxRightRangeLevelBL.QxRightRangeLevelDA.UpdateBySqlWithConditionTransaction(objQxRightRangeLevelEN, strWhereCond, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsQxRightRangeLevelBL.ReFreshCache();

if (clsQxRightRangeLevelBL.relatedActions != null)
{
clsQxRightRangeLevelBL.relatedActions.UpdRelaTabDate(objQxRightRangeLevelEN.RightRangeLevelId, objQxRightRangeLevelEN.UpdUser);
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
 /// <param name = "strRightRangeLevelId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int Delete(this clsQxRightRangeLevelEN objQxRightRangeLevelEN)
{
try
{
int intRecNum = clsQxRightRangeLevelBL.QxRightRangeLevelDA.DelRecord(objQxRightRangeLevelEN.RightRangeLevelId);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsQxRightRangeLevelBL.ReFreshCache();

if (clsQxRightRangeLevelBL.relatedActions != null)
{
clsQxRightRangeLevelBL.relatedActions.UpdRelaTabDate(objQxRightRangeLevelEN.RightRangeLevelId, objQxRightRangeLevelEN.UpdUser);
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
 /// <param name = "objQxRightRangeLevelENS">源对象</param>
 /// <param name = "objQxRightRangeLevelENT">目标对象</param>
 public static void CopyTo(this clsQxRightRangeLevelEN objQxRightRangeLevelENS, clsQxRightRangeLevelEN objQxRightRangeLevelENT)
{
try
{
objQxRightRangeLevelENT.RightRangeLevelId = objQxRightRangeLevelENS.RightRangeLevelId; //权限范围等级Id
objQxRightRangeLevelENT.RightRangeLevelName = objQxRightRangeLevelENS.RightRangeLevelName; //权限范围等级名称
objQxRightRangeLevelENT.UpdDate = objQxRightRangeLevelENS.UpdDate; //修改日期
objQxRightRangeLevelENT.UpdUser = objQxRightRangeLevelENS.UpdUser; //修改人
objQxRightRangeLevelENT.Memo = objQxRightRangeLevelENS.Memo; //备注
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
 /// <param name = "objQxRightRangeLevelENS">源对象</param>
 /// <returns>目标对象=>clsQxRightRangeLevelEN:objQxRightRangeLevelENT</returns>
 public static clsQxRightRangeLevelEN CopyTo(this clsQxRightRangeLevelEN objQxRightRangeLevelENS)
{
try
{
 clsQxRightRangeLevelEN objQxRightRangeLevelENT = new clsQxRightRangeLevelEN()
{
RightRangeLevelId = objQxRightRangeLevelENS.RightRangeLevelId, //权限范围等级Id
RightRangeLevelName = objQxRightRangeLevelENS.RightRangeLevelName, //权限范围等级名称
UpdDate = objQxRightRangeLevelENS.UpdDate, //修改日期
UpdUser = objQxRightRangeLevelENS.UpdUser, //修改人
Memo = objQxRightRangeLevelENS.Memo, //备注
};
 return objQxRightRangeLevelENT;
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
public static void CheckPropertyNew(this clsQxRightRangeLevelEN objQxRightRangeLevelEN)
{
 clsQxRightRangeLevelBL.QxRightRangeLevelDA.CheckPropertyNew(objQxRightRangeLevelEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(this clsQxRightRangeLevelEN objQxRightRangeLevelEN)
{
 clsQxRightRangeLevelBL.QxRightRangeLevelDA.CheckProperty4Condition(objQxRightRangeLevelEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsQxRightRangeLevelEN objQxRightRangeLevelCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objQxRightRangeLevelCond.IsUpdated(conQxRightRangeLevel.RightRangeLevelId) == true)
{
string strComparisonOpRightRangeLevelId = objQxRightRangeLevelCond.dicFldComparisonOp[conQxRightRangeLevel.RightRangeLevelId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conQxRightRangeLevel.RightRangeLevelId, objQxRightRangeLevelCond.RightRangeLevelId, strComparisonOpRightRangeLevelId);
}
if (objQxRightRangeLevelCond.IsUpdated(conQxRightRangeLevel.RightRangeLevelName) == true)
{
string strComparisonOpRightRangeLevelName = objQxRightRangeLevelCond.dicFldComparisonOp[conQxRightRangeLevel.RightRangeLevelName];
strWhereCond += string.Format(" And {0} {2} '{1}'", conQxRightRangeLevel.RightRangeLevelName, objQxRightRangeLevelCond.RightRangeLevelName, strComparisonOpRightRangeLevelName);
}
if (objQxRightRangeLevelCond.IsUpdated(conQxRightRangeLevel.UpdDate) == true)
{
string strComparisonOpUpdDate = objQxRightRangeLevelCond.dicFldComparisonOp[conQxRightRangeLevel.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conQxRightRangeLevel.UpdDate, objQxRightRangeLevelCond.UpdDate, strComparisonOpUpdDate);
}
if (objQxRightRangeLevelCond.IsUpdated(conQxRightRangeLevel.UpdUser) == true)
{
string strComparisonOpUpdUser = objQxRightRangeLevelCond.dicFldComparisonOp[conQxRightRangeLevel.UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", conQxRightRangeLevel.UpdUser, objQxRightRangeLevelCond.UpdUser, strComparisonOpUpdUser);
}
if (objQxRightRangeLevelCond.IsUpdated(conQxRightRangeLevel.Memo) == true)
{
string strComparisonOpMemo = objQxRightRangeLevelCond.dicFldComparisonOp[conQxRightRangeLevel.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", conQxRightRangeLevel.Memo, objQxRightRangeLevelCond.Memo, strComparisonOpMemo);
}
 return strWhereCond;
}

 /// <summary>
 /// 检查唯一性(Uniqueness)--QxRightRangeLevel(权限范围等级), 如果不唯一,即存在相同的记录,就返回False
 /// 唯一性条件:RightRangeLevelName
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckConstraint)
 /// </summary>
 /// <param name = "objQxRightRangeLevelEN">要求唯一的对象</param>
 /// <returns></returns>
public static bool CheckUniqueness(this clsQxRightRangeLevelEN objQxRightRangeLevelEN)
{
//检测记录是否存在
bool bolIsUniqueness;
StringBuilder sbCondition = new StringBuilder();
if (objQxRightRangeLevelEN == null) return true;
if (objQxRightRangeLevelEN.RightRangeLevelId == null || objQxRightRangeLevelEN.RightRangeLevelId == "")
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and RightRangeLevelName = '{0}'", objQxRightRangeLevelEN.RightRangeLevelName);
if (clsQxRightRangeLevelBL.IsExistRecord(sbCondition.ToString())  ==  true)
{
 bolIsUniqueness = false;
}
else
{
 bolIsUniqueness = true;
}
}
 else {
sbCondition.AppendFormat("RightRangeLevelId !=  '{0}'", objQxRightRangeLevelEN.RightRangeLevelId);
 sbCondition.AppendFormat(" and RightRangeLevelName = '{0}'", objQxRightRangeLevelEN.RightRangeLevelName);
if (clsQxRightRangeLevelBL.IsExistRecord(sbCondition.ToString())  ==  true)
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
 /// 获取唯一性条件串--QxRightRangeLevel(权限范围等级), 即由对象中唯一性条件字段关键字与值组成的条件串
 /// 唯一性条件:RightRangeLevelName
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetConditionString4Constraint)
 /// </summary>
 /// <param name = "objQxRightRangeLevelEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(this clsQxRightRangeLevelEN objQxRightRangeLevelEN)
{
//检测记录是否存在
StringBuilder sbCondition = new StringBuilder();
if (objQxRightRangeLevelEN == null) return "";
if (objQxRightRangeLevelEN.RightRangeLevelId == null || objQxRightRangeLevelEN.RightRangeLevelId == "")
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and RightRangeLevelName = '{0}'", objQxRightRangeLevelEN.RightRangeLevelName);
return sbCondition.ToString();
}
 else {
sbCondition.AppendFormat("RightRangeLevelId !=  '{0}'", objQxRightRangeLevelEN.RightRangeLevelId);
 sbCondition.AppendFormat(" and RightRangeLevelName = '{0}'", objQxRightRangeLevelEN.RightRangeLevelName);
 return sbCondition.ToString();
}
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_QxRightRangeLevel
{
public virtual bool UpdRelaTabDate(string strRightRangeLevelId, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// 权限范围等级(QxRightRangeLevel)
 /// 数据源类型:表
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsQxRightRangeLevelBL
{
public static RelatedActions_QxRightRangeLevel relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsQxRightRangeLevelDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsQxRightRangeLevelDA QxRightRangeLevelDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsQxRightRangeLevelDA();
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
 public clsQxRightRangeLevelBL()
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
if (string.IsNullOrEmpty(clsQxRightRangeLevelEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsQxRightRangeLevelEN._ConnectString);
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
public static DataTable GetDataTable_QxRightRangeLevel(string strWhereCond)
{
DataTable objDT;
try
{
objDT = QxRightRangeLevelDA.GetDataTable_QxRightRangeLevel(strWhereCond);
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
objDT = QxRightRangeLevelDA.GetDataTable(strWhereCond);
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
objDT = QxRightRangeLevelDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = QxRightRangeLevelDA.GetDataTable(strWhereCond, strTabName);
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
objDT = QxRightRangeLevelDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = QxRightRangeLevelDA.GetDataTable_Top(objTopPara);
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
objDT = QxRightRangeLevelDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = QxRightRangeLevelDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = QxRightRangeLevelDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
 /// <param name = "arrRightRangeLevelIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static List<clsQxRightRangeLevelEN> GetObjLstByRightRangeLevelIdLst(List<string> arrRightRangeLevelIdLst)
{
List<clsQxRightRangeLevelEN> arrObjLst = new List<clsQxRightRangeLevelEN>(); 
System.Data.DataTable objDT; 
 string strSqlConditionStr = clsArray.GetSqlInStrByArray(arrRightRangeLevelIdLst, true);
 string strWhereCond = string.Format("RightRangeLevelId in ({0})", strSqlConditionStr);
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsQxRightRangeLevelEN objQxRightRangeLevelEN = new clsQxRightRangeLevelEN();
try
{
objQxRightRangeLevelEN.RightRangeLevelId = objRow[conQxRightRangeLevel.RightRangeLevelId].ToString().Trim(); //权限范围等级Id
objQxRightRangeLevelEN.RightRangeLevelName = objRow[conQxRightRangeLevel.RightRangeLevelName].ToString().Trim(); //权限范围等级名称
objQxRightRangeLevelEN.UpdDate = objRow[conQxRightRangeLevel.UpdDate] == DBNull.Value ? null : objRow[conQxRightRangeLevel.UpdDate].ToString().Trim(); //修改日期
objQxRightRangeLevelEN.UpdUser = objRow[conQxRightRangeLevel.UpdUser] == DBNull.Value ? null : objRow[conQxRightRangeLevel.UpdUser].ToString().Trim(); //修改人
objQxRightRangeLevelEN.Memo = objRow[conQxRightRangeLevel.Memo] == DBNull.Value ? null : objRow[conQxRightRangeLevel.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objQxRightRangeLevelEN.RightRangeLevelId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objQxRightRangeLevelEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrRightRangeLevelIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsQxRightRangeLevelEN> GetObjLstByRightRangeLevelIdLstCache(List<string> arrRightRangeLevelIdLst)
{
string strKey = string.Format("{0}", clsQxRightRangeLevelEN._CurrTabName);
List<clsQxRightRangeLevelEN> arrQxRightRangeLevelObjLstCache = GetObjLstCache();
IEnumerable <clsQxRightRangeLevelEN> arrQxRightRangeLevelObjLst_Sel =
arrQxRightRangeLevelObjLstCache
.Where(x => arrRightRangeLevelIdLst.Contains(x.RightRangeLevelId));
return arrQxRightRangeLevelObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsQxRightRangeLevelEN> GetObjLst(string strWhereCond)
{
List<clsQxRightRangeLevelEN> arrObjLst = new List<clsQxRightRangeLevelEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsQxRightRangeLevelEN objQxRightRangeLevelEN = new clsQxRightRangeLevelEN();
try
{
objQxRightRangeLevelEN.RightRangeLevelId = objRow[conQxRightRangeLevel.RightRangeLevelId].ToString().Trim(); //权限范围等级Id
objQxRightRangeLevelEN.RightRangeLevelName = objRow[conQxRightRangeLevel.RightRangeLevelName].ToString().Trim(); //权限范围等级名称
objQxRightRangeLevelEN.UpdDate = objRow[conQxRightRangeLevel.UpdDate] == DBNull.Value ? null : objRow[conQxRightRangeLevel.UpdDate].ToString().Trim(); //修改日期
objQxRightRangeLevelEN.UpdUser = objRow[conQxRightRangeLevel.UpdUser] == DBNull.Value ? null : objRow[conQxRightRangeLevel.UpdUser].ToString().Trim(); //修改人
objQxRightRangeLevelEN.Memo = objRow[conQxRightRangeLevel.Memo] == DBNull.Value ? null : objRow[conQxRightRangeLevel.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objQxRightRangeLevelEN.RightRangeLevelId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objQxRightRangeLevelEN);
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
public static List<clsQxRightRangeLevelEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsQxRightRangeLevelEN> arrObjLst = new List<clsQxRightRangeLevelEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsQxRightRangeLevelEN objQxRightRangeLevelEN = new clsQxRightRangeLevelEN();
try
{
objQxRightRangeLevelEN.RightRangeLevelId = objRow[conQxRightRangeLevel.RightRangeLevelId].ToString().Trim(); //权限范围等级Id
objQxRightRangeLevelEN.RightRangeLevelName = objRow[conQxRightRangeLevel.RightRangeLevelName].ToString().Trim(); //权限范围等级名称
objQxRightRangeLevelEN.UpdDate = objRow[conQxRightRangeLevel.UpdDate] == DBNull.Value ? null : objRow[conQxRightRangeLevel.UpdDate].ToString().Trim(); //修改日期
objQxRightRangeLevelEN.UpdUser = objRow[conQxRightRangeLevel.UpdUser] == DBNull.Value ? null : objRow[conQxRightRangeLevel.UpdUser].ToString().Trim(); //修改人
objQxRightRangeLevelEN.Memo = objRow[conQxRightRangeLevel.Memo] == DBNull.Value ? null : objRow[conQxRightRangeLevel.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objQxRightRangeLevelEN.RightRangeLevelId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objQxRightRangeLevelEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objQxRightRangeLevelCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsQxRightRangeLevelEN> GetSubObjLstCache(clsQxRightRangeLevelEN objQxRightRangeLevelCond)
{
List<clsQxRightRangeLevelEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsQxRightRangeLevelEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conQxRightRangeLevel.AttributeName)
{
if (objQxRightRangeLevelCond.IsUpdated(strFldName) == false) continue;
if (objQxRightRangeLevelCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objQxRightRangeLevelCond[strFldName].ToString());
}
else
{
if (objQxRightRangeLevelCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objQxRightRangeLevelCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objQxRightRangeLevelCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objQxRightRangeLevelCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objQxRightRangeLevelCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objQxRightRangeLevelCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objQxRightRangeLevelCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objQxRightRangeLevelCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objQxRightRangeLevelCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objQxRightRangeLevelCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objQxRightRangeLevelCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objQxRightRangeLevelCond[strFldName]));
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
public static List<clsQxRightRangeLevelEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsQxRightRangeLevelEN> arrObjLst = new List<clsQxRightRangeLevelEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsQxRightRangeLevelEN objQxRightRangeLevelEN = new clsQxRightRangeLevelEN();
try
{
objQxRightRangeLevelEN.RightRangeLevelId = objRow[conQxRightRangeLevel.RightRangeLevelId].ToString().Trim(); //权限范围等级Id
objQxRightRangeLevelEN.RightRangeLevelName = objRow[conQxRightRangeLevel.RightRangeLevelName].ToString().Trim(); //权限范围等级名称
objQxRightRangeLevelEN.UpdDate = objRow[conQxRightRangeLevel.UpdDate] == DBNull.Value ? null : objRow[conQxRightRangeLevel.UpdDate].ToString().Trim(); //修改日期
objQxRightRangeLevelEN.UpdUser = objRow[conQxRightRangeLevel.UpdUser] == DBNull.Value ? null : objRow[conQxRightRangeLevel.UpdUser].ToString().Trim(); //修改人
objQxRightRangeLevelEN.Memo = objRow[conQxRightRangeLevel.Memo] == DBNull.Value ? null : objRow[conQxRightRangeLevel.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objQxRightRangeLevelEN.RightRangeLevelId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objQxRightRangeLevelEN);
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
public static List<clsQxRightRangeLevelEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsQxRightRangeLevelEN> arrObjLst = new List<clsQxRightRangeLevelEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsQxRightRangeLevelEN objQxRightRangeLevelEN = new clsQxRightRangeLevelEN();
try
{
objQxRightRangeLevelEN.RightRangeLevelId = objRow[conQxRightRangeLevel.RightRangeLevelId].ToString().Trim(); //权限范围等级Id
objQxRightRangeLevelEN.RightRangeLevelName = objRow[conQxRightRangeLevel.RightRangeLevelName].ToString().Trim(); //权限范围等级名称
objQxRightRangeLevelEN.UpdDate = objRow[conQxRightRangeLevel.UpdDate] == DBNull.Value ? null : objRow[conQxRightRangeLevel.UpdDate].ToString().Trim(); //修改日期
objQxRightRangeLevelEN.UpdUser = objRow[conQxRightRangeLevel.UpdUser] == DBNull.Value ? null : objRow[conQxRightRangeLevel.UpdUser].ToString().Trim(); //修改人
objQxRightRangeLevelEN.Memo = objRow[conQxRightRangeLevel.Memo] == DBNull.Value ? null : objRow[conQxRightRangeLevel.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objQxRightRangeLevelEN.RightRangeLevelId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objQxRightRangeLevelEN);
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
List<clsQxRightRangeLevelEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsQxRightRangeLevelEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsQxRightRangeLevelEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsQxRightRangeLevelEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsQxRightRangeLevelEN> arrObjLst = new List<clsQxRightRangeLevelEN>(); 
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
	clsQxRightRangeLevelEN objQxRightRangeLevelEN = new clsQxRightRangeLevelEN();
try
{
objQxRightRangeLevelEN.RightRangeLevelId = objRow[conQxRightRangeLevel.RightRangeLevelId].ToString().Trim(); //权限范围等级Id
objQxRightRangeLevelEN.RightRangeLevelName = objRow[conQxRightRangeLevel.RightRangeLevelName].ToString().Trim(); //权限范围等级名称
objQxRightRangeLevelEN.UpdDate = objRow[conQxRightRangeLevel.UpdDate] == DBNull.Value ? null : objRow[conQxRightRangeLevel.UpdDate].ToString().Trim(); //修改日期
objQxRightRangeLevelEN.UpdUser = objRow[conQxRightRangeLevel.UpdUser] == DBNull.Value ? null : objRow[conQxRightRangeLevel.UpdUser].ToString().Trim(); //修改人
objQxRightRangeLevelEN.Memo = objRow[conQxRightRangeLevel.Memo] == DBNull.Value ? null : objRow[conQxRightRangeLevel.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objQxRightRangeLevelEN.RightRangeLevelId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objQxRightRangeLevelEN);
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
public static List<clsQxRightRangeLevelEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsQxRightRangeLevelEN> arrObjLst = new List<clsQxRightRangeLevelEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsQxRightRangeLevelEN objQxRightRangeLevelEN = new clsQxRightRangeLevelEN();
try
{
objQxRightRangeLevelEN.RightRangeLevelId = objRow[conQxRightRangeLevel.RightRangeLevelId].ToString().Trim(); //权限范围等级Id
objQxRightRangeLevelEN.RightRangeLevelName = objRow[conQxRightRangeLevel.RightRangeLevelName].ToString().Trim(); //权限范围等级名称
objQxRightRangeLevelEN.UpdDate = objRow[conQxRightRangeLevel.UpdDate] == DBNull.Value ? null : objRow[conQxRightRangeLevel.UpdDate].ToString().Trim(); //修改日期
objQxRightRangeLevelEN.UpdUser = objRow[conQxRightRangeLevel.UpdUser] == DBNull.Value ? null : objRow[conQxRightRangeLevel.UpdUser].ToString().Trim(); //修改人
objQxRightRangeLevelEN.Memo = objRow[conQxRightRangeLevel.Memo] == DBNull.Value ? null : objRow[conQxRightRangeLevel.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objQxRightRangeLevelEN.RightRangeLevelId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objQxRightRangeLevelEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsQxRightRangeLevelEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsQxRightRangeLevelEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsQxRightRangeLevelEN> arrObjLst = new List<clsQxRightRangeLevelEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsQxRightRangeLevelEN objQxRightRangeLevelEN = new clsQxRightRangeLevelEN();
try
{
objQxRightRangeLevelEN.RightRangeLevelId = objRow[conQxRightRangeLevel.RightRangeLevelId].ToString().Trim(); //权限范围等级Id
objQxRightRangeLevelEN.RightRangeLevelName = objRow[conQxRightRangeLevel.RightRangeLevelName].ToString().Trim(); //权限范围等级名称
objQxRightRangeLevelEN.UpdDate = objRow[conQxRightRangeLevel.UpdDate] == DBNull.Value ? null : objRow[conQxRightRangeLevel.UpdDate].ToString().Trim(); //修改日期
objQxRightRangeLevelEN.UpdUser = objRow[conQxRightRangeLevel.UpdUser] == DBNull.Value ? null : objRow[conQxRightRangeLevel.UpdUser].ToString().Trim(); //修改人
objQxRightRangeLevelEN.Memo = objRow[conQxRightRangeLevel.Memo] == DBNull.Value ? null : objRow[conQxRightRangeLevel.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objQxRightRangeLevelEN.RightRangeLevelId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objQxRightRangeLevelEN);
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
public static List<clsQxRightRangeLevelEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsQxRightRangeLevelEN> arrObjLst = new List<clsQxRightRangeLevelEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsQxRightRangeLevelEN objQxRightRangeLevelEN = new clsQxRightRangeLevelEN();
try
{
objQxRightRangeLevelEN.RightRangeLevelId = objRow[conQxRightRangeLevel.RightRangeLevelId].ToString().Trim(); //权限范围等级Id
objQxRightRangeLevelEN.RightRangeLevelName = objRow[conQxRightRangeLevel.RightRangeLevelName].ToString().Trim(); //权限范围等级名称
objQxRightRangeLevelEN.UpdDate = objRow[conQxRightRangeLevel.UpdDate] == DBNull.Value ? null : objRow[conQxRightRangeLevel.UpdDate].ToString().Trim(); //修改日期
objQxRightRangeLevelEN.UpdUser = objRow[conQxRightRangeLevel.UpdUser] == DBNull.Value ? null : objRow[conQxRightRangeLevel.UpdUser].ToString().Trim(); //修改人
objQxRightRangeLevelEN.Memo = objRow[conQxRightRangeLevel.Memo] == DBNull.Value ? null : objRow[conQxRightRangeLevel.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objQxRightRangeLevelEN.RightRangeLevelId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objQxRightRangeLevelEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsQxRightRangeLevelEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsQxRightRangeLevelEN> arrObjLst = new List<clsQxRightRangeLevelEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsQxRightRangeLevelEN objQxRightRangeLevelEN = new clsQxRightRangeLevelEN();
try
{
objQxRightRangeLevelEN.RightRangeLevelId = objRow[conQxRightRangeLevel.RightRangeLevelId].ToString().Trim(); //权限范围等级Id
objQxRightRangeLevelEN.RightRangeLevelName = objRow[conQxRightRangeLevel.RightRangeLevelName].ToString().Trim(); //权限范围等级名称
objQxRightRangeLevelEN.UpdDate = objRow[conQxRightRangeLevel.UpdDate] == DBNull.Value ? null : objRow[conQxRightRangeLevel.UpdDate].ToString().Trim(); //修改日期
objQxRightRangeLevelEN.UpdUser = objRow[conQxRightRangeLevel.UpdUser] == DBNull.Value ? null : objRow[conQxRightRangeLevel.UpdUser].ToString().Trim(); //修改人
objQxRightRangeLevelEN.Memo = objRow[conQxRightRangeLevel.Memo] == DBNull.Value ? null : objRow[conQxRightRangeLevel.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objQxRightRangeLevelEN.RightRangeLevelId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objQxRightRangeLevelEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objQxRightRangeLevelEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetQxRightRangeLevel(ref clsQxRightRangeLevelEN objQxRightRangeLevelEN)
{
bool bolResult = QxRightRangeLevelDA.GetQxRightRangeLevel(ref objQxRightRangeLevelEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "strRightRangeLevelId">表关键字</param>
 /// <returns>表对象</returns>
public static clsQxRightRangeLevelEN GetObjByRightRangeLevelId(string strRightRangeLevelId)
{
if (strRightRangeLevelId.IndexOf(' ') >=0)
{
var strMsg = string.Format("(errid:Busi000079)在表中,关键字[strRightRangeLevelId]中不能有空格!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
if (string.IsNullOrEmpty(strRightRangeLevelId) == true)
{
var strMsg = string.Format("(errid:Busi000020)在表中,关键字[strRightRangeLevelId]不能为空!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
clsQxRightRangeLevelEN objQxRightRangeLevelEN = QxRightRangeLevelDA.GetObjByRightRangeLevelId(strRightRangeLevelId);
return objQxRightRangeLevelEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsQxRightRangeLevelEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsQxRightRangeLevelEN objQxRightRangeLevelEN = QxRightRangeLevelDA.GetFirstObj(strWhereCond);
 return objQxRightRangeLevelEN;
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
public static clsQxRightRangeLevelEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsQxRightRangeLevelEN objQxRightRangeLevelEN = QxRightRangeLevelDA.GetObjByDataRow(objRow);
 return objQxRightRangeLevelEN;
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
public static clsQxRightRangeLevelEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsQxRightRangeLevelEN objQxRightRangeLevelEN = QxRightRangeLevelDA.GetObjByDataRow(objRow);
 return objQxRightRangeLevelEN;
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
 /// <param name = "strRightRangeLevelId">所给的关键字</param>
 /// <param name = "lstQxRightRangeLevelObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsQxRightRangeLevelEN GetObjByRightRangeLevelIdFromList(string strRightRangeLevelId, List<clsQxRightRangeLevelEN> lstQxRightRangeLevelObjLst)
{
foreach (clsQxRightRangeLevelEN objQxRightRangeLevelEN in lstQxRightRangeLevelObjLst)
{
if (objQxRightRangeLevelEN.RightRangeLevelId == strRightRangeLevelId)
{
return objQxRightRangeLevelEN;
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
 string strMaxRightRangeLevelId;
 try
 {
 strMaxRightRangeLevelId = clsQxRightRangeLevelDA.GetMaxStrId();
 return strMaxRightRangeLevelId;
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
 string strRightRangeLevelId;
 try
 {
 strRightRangeLevelId = new clsQxRightRangeLevelDA().GetFirstID(strWhereCond);
 return strRightRangeLevelId;
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
 arrList = QxRightRangeLevelDA.GetID(strWhereCond);
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
bool bolIsExist = QxRightRangeLevelDA.IsExistCondRec(strWhereCond);
return bolIsExist;
}

 /// <summary>
 /// 判断当前表中是否存在给定关键字值的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExist)
 /// </summary>
 /// <param name = "strRightRangeLevelId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public static bool IsExist(string strRightRangeLevelId)
{
if (string.IsNullOrEmpty(strRightRangeLevelId) == true)
{
var strMsg = string.Format("(errid:Busi000027)在表中,关键字[strRightRangeLevelId]不能为空!!(from {0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
//检测记录是否存在
bool bolIsExist = QxRightRangeLevelDA.IsExist(strRightRangeLevelId);
return bolIsExist;
}

/// <summary>
/// 设置修改时间
/// </summary>
/// <param name = "strRightRangeLevelId">权限范围等级Id</param>
/// <param name = "strOpUser">修改用户</param>
/// <returns>是否成功？</returns>
public static bool SetUpdDate(string strRightRangeLevelId, string strOpUser)
{
clsQxRightRangeLevelEN objQxRightRangeLevelEN = clsQxRightRangeLevelBL.GetObjByRightRangeLevelId(strRightRangeLevelId);
objQxRightRangeLevelEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
objQxRightRangeLevelEN.UpdUser = strOpUser;
return clsQxRightRangeLevelBL.UpdateBySql2(objQxRightRangeLevelEN);
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
 bolIsExist = clsQxRightRangeLevelDA.IsExistTable();
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
 bolIsExist = QxRightRangeLevelDA.IsExistTable(strTabName);
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
 /// <param name = "objQxRightRangeLevelEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecordBySql2(clsQxRightRangeLevelEN objQxRightRangeLevelEN, bool bolIsNeedCheckUniqueness=true)
{
if (bolIsNeedCheckUniqueness == true && objQxRightRangeLevelEN.CheckUniqueness() == false)
{
var strMsg = string.Format("记录已经存在!权限范围等级名称 = [{0}]的数据已经存在!(in clsQxRightRangeLevelBL.AddNewRecordBySql2)", objQxRightRangeLevelEN.RightRangeLevelName);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objQxRightRangeLevelEN.RightRangeLevelId) == true || clsQxRightRangeLevelBL.IsExist(objQxRightRangeLevelEN.RightRangeLevelId) == true)
 {
     objQxRightRangeLevelEN.RightRangeLevelId = clsQxRightRangeLevelBL.GetMaxStrId_S();
 }
bool bolResult = QxRightRangeLevelDA.AddNewRecordBySQL2(objQxRightRangeLevelEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsQxRightRangeLevelBL.ReFreshCache();

if (clsQxRightRangeLevelBL.relatedActions != null)
{
clsQxRightRangeLevelBL.relatedActions.UpdRelaTabDate(objQxRightRangeLevelEN.RightRangeLevelId, objQxRightRangeLevelEN.UpdUser);
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
 /// <param name = "objQxRightRangeLevelEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordBySql2WithReturnKey(clsQxRightRangeLevelEN objQxRightRangeLevelEN, bool bolIsNeedCheckUniqueness=true)
{
if (bolIsNeedCheckUniqueness == true && objQxRightRangeLevelEN.CheckUniqueness() == false)
{
var strMsg = string.Format("记录已经存在!权限范围等级名称 = [{0}]的数据已经存在!(in clsQxRightRangeLevelBL.AddNewRecordBySql2WithReturnKey)", objQxRightRangeLevelEN.RightRangeLevelName);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objQxRightRangeLevelEN.RightRangeLevelId) == true || clsQxRightRangeLevelBL.IsExist(objQxRightRangeLevelEN.RightRangeLevelId) == true)
 {
     objQxRightRangeLevelEN.RightRangeLevelId = clsQxRightRangeLevelBL.GetMaxStrId_S();
 }
string strKey = QxRightRangeLevelDA.AddNewRecordBySQL2WithReturnKey(objQxRightRangeLevelEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsQxRightRangeLevelBL.ReFreshCache();

if (clsQxRightRangeLevelBL.relatedActions != null)
{
clsQxRightRangeLevelBL.relatedActions.UpdRelaTabDate(objQxRightRangeLevelEN.RightRangeLevelId, objQxRightRangeLevelEN.UpdUser);
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
 /// <param name = "objQxRightRangeLevelEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(clsQxRightRangeLevelEN objQxRightRangeLevelEN)
{
try
{
bool bolResult = QxRightRangeLevelDA.Update(objQxRightRangeLevelEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsQxRightRangeLevelBL.ReFreshCache();

if (clsQxRightRangeLevelBL.relatedActions != null)
{
clsQxRightRangeLevelBL.relatedActions.UpdRelaTabDate(objQxRightRangeLevelEN.RightRangeLevelId, objQxRightRangeLevelEN.UpdUser);
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
 /// <param name = "objQxRightRangeLevelEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateBySql2(clsQxRightRangeLevelEN objQxRightRangeLevelEN)
{
 if (string.IsNullOrEmpty(objQxRightRangeLevelEN.RightRangeLevelId) == true)
 {
var strMsg = string.Format("(errid:Busi000065)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = QxRightRangeLevelDA.UpdateBySql2(objQxRightRangeLevelEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsQxRightRangeLevelBL.ReFreshCache();

if (clsQxRightRangeLevelBL.relatedActions != null)
{
clsQxRightRangeLevelBL.relatedActions.UpdRelaTabDate(objQxRightRangeLevelEN.RightRangeLevelId, objQxRightRangeLevelEN.UpdUser);
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
 /// <param name = "strRightRangeLevelId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int DelRecord(string strRightRangeLevelId)
{
try
{
 clsQxRightRangeLevelEN objQxRightRangeLevelEN = clsQxRightRangeLevelBL.GetObjByRightRangeLevelId(strRightRangeLevelId);

if (clsQxRightRangeLevelBL.relatedActions != null)
{
clsQxRightRangeLevelBL.relatedActions.UpdRelaTabDate(objQxRightRangeLevelEN.RightRangeLevelId, objQxRightRangeLevelEN.UpdUser);
}
if (objQxRightRangeLevelEN != null)
{
int intRecNum = QxRightRangeLevelDA.DelRecord(strRightRangeLevelId);
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
/// <param name="strRightRangeLevelId">表关键字</param>
/// <returns></returns>
public static bool DelRecordEx(string strRightRangeLevelId )
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsQxRightRangeLevelDA.GetSpecSQLObj();
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
//删除与表:[QxRightRangeLevel]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conQxRightRangeLevel.RightRangeLevelId,
//strRightRangeLevelId);
//        clsQxRightRangeLevelBL.DelQxRightRangeLevelsByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsQxRightRangeLevelBL.DelRecord(strRightRangeLevelId, objConnection, objSqlTransaction);
objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsQxRightRangeLevelBLEx", "DelRecordEx", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("扩展删除记录出错:{0}!keyId = {1}.({2})",
objException.Message,
strRightRangeLevelId, clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "strRightRangeLevelId">给定的关键字值</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回删除是否成功?</returns>
public static bool DelRecord(string strRightRangeLevelId, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
if (clsQxRightRangeLevelBL.relatedActions != null)
{
clsQxRightRangeLevelBL.relatedActions.UpdRelaTabDate(strRightRangeLevelId, "UpdRelaTabDate");
}
bool bolResult = QxRightRangeLevelDA.DelRecord(strRightRangeLevelId,objSqlConnection,objSqlTransaction);
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
 /// <param name = "arrRightRangeLevelIdLst">给定的关键字值列表</param>
 /// <returns>返回删除的记录数</returns>
public static int DelQxRightRangeLevels(List<string> arrRightRangeLevelIdLst)
{
if (arrRightRangeLevelIdLst.Count == 0) return 0;
try
{
if (clsQxRightRangeLevelBL.relatedActions != null)
{
foreach (var strRightRangeLevelId in arrRightRangeLevelIdLst)
{
clsQxRightRangeLevelBL.relatedActions.UpdRelaTabDate(strRightRangeLevelId, "UpdRelaTabDate");
}
}
int intDelRecNum = QxRightRangeLevelDA.DelQxRightRangeLevel(arrRightRangeLevelIdLst);
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
public static int DelQxRightRangeLevelsByCond(string strWhereCond)
{
try
{
if (clsQxRightRangeLevelBL.relatedActions != null)
{
List<string> arrRightRangeLevelId = GetPrimaryKeyID_S(strWhereCond);
foreach (var strRightRangeLevelId in arrRightRangeLevelId)
{
clsQxRightRangeLevelBL.relatedActions.UpdRelaTabDate(strRightRangeLevelId, "UpdRelaTabDate");
}
}
int intRecNum = QxRightRangeLevelDA.DelQxRightRangeLevel(strWhereCond);
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
/// 这里仅仅是演示函数,使用时请复制到扩展类:[QxRightRangeLevel]中改名为:[DelRecord4MultiTabEx]使用
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DelRecord4MultiTab)
/// </summary>
/// <param name="strRightRangeLevelId">表关键字</param>
/// <returns></returns>
public static bool DelRecord4MultiTab(string strRightRangeLevelId)
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsQxRightRangeLevelDA.GetSpecSQLObj();
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
//删除与表:[QxRightRangeLevel]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conStudent.id_College,
//strid_College);
//        clsStudentBL.DelStudentsByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsQxRightRangeLevelBL.DelRecord(strRightRangeLevelId, objConnection, objSqlTransaction);
                objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsQxRightRangeLevelBL", "DelRecord4MultiTab", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("删除多表记录出错:{0}!keyId = {1}.({2})",
objException.Message,
strRightRangeLevelId, clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "objQxRightRangeLevelENS">源对象</param>
 /// <param name = "objQxRightRangeLevelENT">目标对象</param>
 public static void CopyTo(clsQxRightRangeLevelEN objQxRightRangeLevelENS, clsQxRightRangeLevelEN objQxRightRangeLevelENT)
{
try
{
objQxRightRangeLevelENT.RightRangeLevelId = objQxRightRangeLevelENS.RightRangeLevelId; //权限范围等级Id
objQxRightRangeLevelENT.RightRangeLevelName = objQxRightRangeLevelENS.RightRangeLevelName; //权限范围等级名称
objQxRightRangeLevelENT.UpdDate = objQxRightRangeLevelENS.UpdDate; //修改日期
objQxRightRangeLevelENT.UpdUser = objQxRightRangeLevelENS.UpdUser; //修改人
objQxRightRangeLevelENT.Memo = objQxRightRangeLevelENS.Memo; //备注
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
 /// <param name = "objQxRightRangeLevelEN">源简化对象</param>
 public static void SetUpdFlag(clsQxRightRangeLevelEN objQxRightRangeLevelEN)
{
try
{
objQxRightRangeLevelEN.ClearUpdateState();
   string strsfUpdFldSetStr = objQxRightRangeLevelEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(conQxRightRangeLevel.RightRangeLevelId, new clsStrCompareIgnoreCase())  ==  true)
{
objQxRightRangeLevelEN.RightRangeLevelId = objQxRightRangeLevelEN.RightRangeLevelId; //权限范围等级Id
}
if (arrFldSet.Contains(conQxRightRangeLevel.RightRangeLevelName, new clsStrCompareIgnoreCase())  ==  true)
{
objQxRightRangeLevelEN.RightRangeLevelName = objQxRightRangeLevelEN.RightRangeLevelName; //权限范围等级名称
}
if (arrFldSet.Contains(conQxRightRangeLevel.UpdDate, new clsStrCompareIgnoreCase())  ==  true)
{
objQxRightRangeLevelEN.UpdDate = objQxRightRangeLevelEN.UpdDate == "[null]" ? null :  objQxRightRangeLevelEN.UpdDate; //修改日期
}
if (arrFldSet.Contains(conQxRightRangeLevel.UpdUser, new clsStrCompareIgnoreCase())  ==  true)
{
objQxRightRangeLevelEN.UpdUser = objQxRightRangeLevelEN.UpdUser == "[null]" ? null :  objQxRightRangeLevelEN.UpdUser; //修改人
}
if (arrFldSet.Contains(conQxRightRangeLevel.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objQxRightRangeLevelEN.Memo = objQxRightRangeLevelEN.Memo == "[null]" ? null :  objQxRightRangeLevelEN.Memo; //备注
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
 /// <param name = "objQxRightRangeLevelEN">源简化对象</param>
 public static void AccessFldValueNull(clsQxRightRangeLevelEN objQxRightRangeLevelEN)
{
try
{
if (objQxRightRangeLevelEN.UpdDate == "[null]") objQxRightRangeLevelEN.UpdDate = null; //修改日期
if (objQxRightRangeLevelEN.UpdUser == "[null]") objQxRightRangeLevelEN.UpdUser = null; //修改人
if (objQxRightRangeLevelEN.Memo == "[null]") objQxRightRangeLevelEN.Memo = null; //备注
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
public static void CheckPropertyNew(clsQxRightRangeLevelEN objQxRightRangeLevelEN)
{
 QxRightRangeLevelDA.CheckPropertyNew(objQxRightRangeLevelEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(clsQxRightRangeLevelEN objQxRightRangeLevelEN)
{
 QxRightRangeLevelDA.CheckProperty4Condition(objQxRightRangeLevelEN);
 }


 #endregion 检查对象属性


 #region 绑定下拉框

 /// <summary>
 /// 绑定基于Win的下拉框
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_TabFeature_ComboBoxBindFunction)
 /// </summary>
 /// <param name = "objComboBox">需要绑定当前表的下拉框</param>

public static void BindCbo_RightRangeLevelId(System.Windows.Forms.ComboBox objComboBox )
{
//为数据源为表的下拉框设置内容
string strCondition = string.Format("1 =1 Order By {0}", conQxRightRangeLevel.RightRangeLevelId); 
List<clsQxRightRangeLevelEN> arrObjLst = clsQxRightRangeLevelBL.GetObjLst(strCondition);
//初始化一个对象列表
//插入第0项。在第0项中插入“请选择...”,为了方便用户,与WEB方式类似。
clsQxRightRangeLevelEN objQxRightRangeLevelEN = new clsQxRightRangeLevelEN()
{
RightRangeLevelId = "0",
RightRangeLevelName = "选[权限范围等级]..."
};
arrObjLst.Insert(0, objQxRightRangeLevelEN);
//设置下拉框的数据源、以及设置值项、显示项
objComboBox.ValueMember = conQxRightRangeLevel.RightRangeLevelId;
objComboBox.DisplayMember = conQxRightRangeLevel.RightRangeLevelName;
objComboBox.DataSource = arrObjLst;
objComboBox.SelectedIndex = 0;
}

 /// <summary>
 /// 绑定基于Web的下拉框
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_TabFeature_DdlBindFunction)
 /// </summary>
 /// <param name = "objDDL">需要绑定当前表的下拉框</param>

public static void BindDdl_RightRangeLevelId(System.Web.UI.WebControls.DropDownList objDDL )
{
//为数据源于表的下拉框设置内容
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[权限范围等级]...","0");
string strCondition = string.Format("1 =1 Order By {0}", conQxRightRangeLevel.RightRangeLevelId); 
IEnumerable<clsQxRightRangeLevelEN> arrObjLst = clsQxRightRangeLevelBL.GetObjLst(strCondition);
objDDL.DataValueField = conQxRightRangeLevel.RightRangeLevelId;
objDDL.DataTextField = conQxRightRangeLevel.RightRangeLevelName;
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
public static void BindDdl_RightRangeLevelIdCache(System.Web.UI.WebControls.DropDownList objDDL)
{
//为数据源于表的下拉框设置内容
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[权限范围等级]...","0");
List<clsQxRightRangeLevelEN> arrQxRightRangeLevelObjLst = GetAllQxRightRangeLevelObjLstCache(); 
objDDL.DataValueField = conQxRightRangeLevel.RightRangeLevelId;
objDDL.DataTextField = conQxRightRangeLevel.RightRangeLevelName;
objDDL.DataSource = arrQxRightRangeLevelObjLst;
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
if (clsQxRightRangeLevelBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsQxRightRangeLevelBL没有刷新缓存机制(clsQxRightRangeLevelBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by RightRangeLevelId");
//if (arrQxRightRangeLevelObjLstCache == null)
//{
//arrQxRightRangeLevelObjLstCache = QxRightRangeLevelDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "strRightRangeLevelId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsQxRightRangeLevelEN GetObjByRightRangeLevelIdCache(string strRightRangeLevelId)
{
//获取缓存中的对象列表
string strKey = string.Format("{0}", clsQxRightRangeLevelEN._CurrTabName);
List<clsQxRightRangeLevelEN> arrQxRightRangeLevelObjLstCache = GetObjLstCache();
IEnumerable <clsQxRightRangeLevelEN> arrQxRightRangeLevelObjLst_Sel =
arrQxRightRangeLevelObjLstCache
.Where(x=> x.RightRangeLevelId == strRightRangeLevelId 
);
if (arrQxRightRangeLevelObjLst_Sel.Count() == 0)
{
   clsQxRightRangeLevelEN obj = clsQxRightRangeLevelBL.GetObjByRightRangeLevelId(strRightRangeLevelId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
 }
return null;
}
return arrQxRightRangeLevelObjLst_Sel.First();
}

 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecNameByKeyCache)
 /// </summary>
 /// <param name = "strRightRangeLevelId">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetRightRangeLevelNameByRightRangeLevelIdCache(string strRightRangeLevelId)
{
if (string.IsNullOrEmpty(strRightRangeLevelId) == true) return "";
//获取缓存中的对象列表
clsQxRightRangeLevelEN objQxRightRangeLevel = GetObjByRightRangeLevelIdCache(strRightRangeLevelId);
if (objQxRightRangeLevel == null) return "";
return objQxRightRangeLevel.RightRangeLevelName;
}
 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecNameByKeyCache)
 /// </summary>
 /// <param name = "strRightRangeLevelId">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetNameByRightRangeLevelIdCache(string strRightRangeLevelId)
{
if (string.IsNullOrEmpty(strRightRangeLevelId) == true) return "";
//获取缓存中的对象列表
clsQxRightRangeLevelEN objQxRightRangeLevel = GetObjByRightRangeLevelIdCache(strRightRangeLevelId);
if (objQxRightRangeLevel == null) return "";
return objQxRightRangeLevel.RightRangeLevelName;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsQxRightRangeLevelEN> GetAllQxRightRangeLevelObjLstCache()
{
//获取缓存中的对象列表
List<clsQxRightRangeLevelEN> arrQxRightRangeLevelObjLstCache = GetObjLstCache(); 
return arrQxRightRangeLevelObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsQxRightRangeLevelEN> GetObjLstCache()
{
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}", clsQxRightRangeLevelEN._CurrTabName);
List<clsQxRightRangeLevelEN> arrQxRightRangeLevelObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrQxRightRangeLevelObjLstCache;
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
string strKey = string.Format("{0}", clsQxRightRangeLevelEN._CurrTabName);
CacheHelper.Remove(strKey);
clsQxRightRangeLevelEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
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
if (clsQxRightRangeLevelEN._RefreshTimeLst.Count == 0) return "";
return clsQxRightRangeLevelEN._RefreshTimeLst[clsQxRightRangeLevelEN._RefreshTimeLst.Count - 1];
}

 /// <summary>
 /// 刷新缓存.把当前表的缓存以及该表相关视图的缓存清空.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ReFreshCache)
 /// </summary>
public static void ReFreshCache()
{
if (clsQxRightRangeLevelBL.objCommFun4BL != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}", clsQxRightRangeLevelEN._CurrTabName);
CacheHelper.Remove(strKey);
clsQxRightRangeLevelEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
clsQxRightRangeLevelBL.objCommFun4BL.ReFreshCache();
}
}


 #endregion 缓存操作


 #region 检查唯一性

 /// <summary>
 /// 获取检查唯一性条件串(Uniqueness)--QxRightRangeLevel(权限范围等级)
 /// 唯一性条件:RightRangeLevelName
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetUniquenessConditionString)
 /// </summary>
 /// <param name = "objQxRightRangeLevelEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(clsQxRightRangeLevelEN objQxRightRangeLevelEN)
{
//检测记录是否存在
string strResult = QxRightRangeLevelDA.GetUniCondStr(objQxRightRangeLevelEN);
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
public static string Func(string strInFldName, string strOutFldName, string strRightRangeLevelId)
{
if (strInFldName != conQxRightRangeLevel.RightRangeLevelId)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (conQxRightRangeLevel.AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", conQxRightRangeLevel.AttributeName));
throw new Exception(strMsg);
}
var objQxRightRangeLevel = clsQxRightRangeLevelBL.GetObjByRightRangeLevelIdCache(strRightRangeLevelId);
if (objQxRightRangeLevel == null) return "";
return objQxRightRangeLevel[strOutFldName].ToString();
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
int intRecCount = clsQxRightRangeLevelDA.GetRecCount(strTabName);
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
int intRecCount = clsQxRightRangeLevelDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsQxRightRangeLevelDA.GetRecCount();
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
int intRecCount = clsQxRightRangeLevelDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objQxRightRangeLevelCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsQxRightRangeLevelEN objQxRightRangeLevelCond)
{
List<clsQxRightRangeLevelEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsQxRightRangeLevelEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conQxRightRangeLevel.AttributeName)
{
if (objQxRightRangeLevelCond.IsUpdated(strFldName) == false) continue;
if (objQxRightRangeLevelCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objQxRightRangeLevelCond[strFldName].ToString());
}
else
{
if (objQxRightRangeLevelCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objQxRightRangeLevelCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objQxRightRangeLevelCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objQxRightRangeLevelCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objQxRightRangeLevelCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objQxRightRangeLevelCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objQxRightRangeLevelCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objQxRightRangeLevelCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objQxRightRangeLevelCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objQxRightRangeLevelCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objQxRightRangeLevelCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objQxRightRangeLevelCond[strFldName]));
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
 List<string> arrList = clsQxRightRangeLevelDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = QxRightRangeLevelDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = QxRightRangeLevelDA.GetFldValueNoDistinct(strFldName, strWhereCond);
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
int intRecCount = QxRightRangeLevelDA.SetFldValue(strFldName, strValue, strWhereCond);
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
int intRecCount = clsQxRightRangeLevelDA.SetFldValue(clsQxRightRangeLevelEN._CurrTabName, strFldName, fltValue, strWhereCond);
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
int intRecCount = QxRightRangeLevelDA.SetFldValue( strFldName, intValue, strWhereCond);
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
int intRecCount = clsQxRightRangeLevelDA.SetFldValue(strTabName, strFldName, strValue, strWhereCond);
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
int intRecCount = clsQxRightRangeLevelDA.SetFldValue(strTabName, strFldName, intValue, strWhereCond);
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
int intRecCount = clsQxRightRangeLevelDA.SetFldValue(strTabName, strFldName, fltValue, strWhereCond);
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
  strCreateTabCode.Append("CREATE table [dbo].[QxRightRangeLevel] "); 
 strCreateTabCode.Append(" ( "); 
 // /**权限范围等级Id*/ 
 strCreateTabCode.Append(" RightRangeLevelId char(2) primary key, "); 
 // /**权限范围等级名称*/ 
 strCreateTabCode.Append(" RightRangeLevelName varchar(30) not Null, "); 
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
 /// 权限范围等级(QxRightRangeLevel)
 /// 数据源类型:表
 /// (AutoGCLib.CommFun4BL4CSharp:GeneCode_This)
 /// </summary>
public class  clsCommFun4BL4QxRightRangeLevel : clsCommFun4BL
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
clsQxRightRangeLevelBL.ReFreshThisCache();
}
}

}