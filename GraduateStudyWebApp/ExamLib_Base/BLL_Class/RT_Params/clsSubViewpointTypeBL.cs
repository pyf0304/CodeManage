
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsSubViewpointTypeBL
 表名:SubViewpointType(01120533)
 * 版本:2024.11.13.1(服务器:WIN-SRV103-116)
 日期:2024/11/13 06:14:34
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:研究生学习游戏化后台(000055, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:研培参数(RT_Params)
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
public static class  clsSubViewpointTypeBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "strSubViewpointTypeId">表关键字</param>
 /// <returns>表对象</returns>
public static clsSubViewpointTypeEN GetObj(this K_SubViewpointTypeId_SubViewpointType myKey)
{
clsSubViewpointTypeEN objSubViewpointTypeEN = clsSubViewpointTypeBL.SubViewpointTypeDA.GetObjBySubViewpointTypeId(myKey.Value);
return objSubViewpointTypeEN;
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_AddNewRecord)
 /// </summary>
 /// <param name = "objSubViewpointTypeEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clsSubViewpointTypeEN objSubViewpointTypeEN, bool bolIsNeedCheckUniqueness = true)
{
if (bolIsNeedCheckUniqueness == true && CheckUniqueness(objSubViewpointTypeEN) == false)
{
var strMsg = string.Format("记录已经存在!类型名称 = [{0}]的数据已经存在!(in clsSubViewpointTypeBL.AddNewRecord)", objSubViewpointTypeEN.SubViewpointTypeName);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objSubViewpointTypeEN.SubViewpointTypeId) == true || clsSubViewpointTypeBL.IsExist(objSubViewpointTypeEN.SubViewpointTypeId) == true)
 {
     objSubViewpointTypeEN.SubViewpointTypeId = clsSubViewpointTypeBL.GetMaxStrId_S();
 }
bool bolResult = clsSubViewpointTypeBL.SubViewpointTypeDA.AddNewRecordBySQL2(objSubViewpointTypeEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsSubViewpointTypeBL.ReFreshCache();

if (clsSubViewpointTypeBL.relatedActions != null)
{
clsSubViewpointTypeBL.relatedActions.UpdRelaTabDate(objSubViewpointTypeEN.SubViewpointTypeId, objSubViewpointTypeEN.UpdUserId);
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
public static bool AddRecordEx(this clsSubViewpointTypeEN objSubViewpointTypeEN, bool bolIsNeedCheckUniqueness = true)
{
//操作步骤:
//1、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在
//2、检查唯一性
//3、检查传进去的对象属性是否合法
//4、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
//1、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在

//因为是字符型自增主键,不需要检查主键是否已经存在,在添加时,再获取 最大值作为主键
//if (clsSubViewpointTypeBL.IsExist(objSubViewpointTypeEN.SubViewpointTypeId))	//判断是否有相同的关键字
//{
//strMsg = "(errid:Busi000151)关键字字段已有相同的值";
//throw new Exception(strMsg);
//}
try
{
 //2、检查传进去的对象属性是否合法
objSubViewpointTypeEN.CheckPropertyNew();
 ///5.2、检查唯一性
if (bolIsNeedCheckUniqueness == true && objSubViewpointTypeEN.CheckUniqueness() == false)
{
strMsg = string.Format("(类型名称(SubViewpointTypeName)=[{0}])已经存在,不能重复!", objSubViewpointTypeEN.SubViewpointTypeName);
throw new Exception(strMsg);
}
//因为是字符型自增主键,所以在添加时,自动获取主键值。
 if (string.IsNullOrEmpty(objSubViewpointTypeEN.SubViewpointTypeId) == true || clsSubViewpointTypeBL.IsExist(objSubViewpointTypeEN.SubViewpointTypeId) == true)
 {
     objSubViewpointTypeEN.SubViewpointTypeId = clsSubViewpointTypeBL.GetMaxStrId_S();
 }
//6、把数据实体层的数据存贮到数据库中
objSubViewpointTypeEN.AddNewRecord();
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
 /// <param name = "objSubViewpointTypeEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static string AddNewRecordWithMaxId(this clsSubViewpointTypeEN objSubViewpointTypeEN, bool bolIsNeedCheckUniqueness = true)
{
if (bolIsNeedCheckUniqueness == true && CheckUniqueness(objSubViewpointTypeEN) == false)
{
var strMsg = string.Format("记录已经存在!类型名称 = [{0}]的数据已经存在!(in clsSubViewpointTypeBL.AddNewRecordWithMaxId)", objSubViewpointTypeEN.SubViewpointTypeName);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objSubViewpointTypeEN.SubViewpointTypeId) == true || clsSubViewpointTypeBL.IsExist(objSubViewpointTypeEN.SubViewpointTypeId) == true)
 {
     objSubViewpointTypeEN.SubViewpointTypeId = clsSubViewpointTypeBL.GetMaxStrId_S();
 }
string strSubViewpointTypeId = clsSubViewpointTypeBL.SubViewpointTypeDA.AddNewRecordBySQL2WithReturnKey(objSubViewpointTypeEN);
     objSubViewpointTypeEN.SubViewpointTypeId = strSubViewpointTypeId;
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsSubViewpointTypeBL.ReFreshCache();

if (clsSubViewpointTypeBL.relatedActions != null)
{
clsSubViewpointTypeBL.relatedActions.UpdRelaTabDate(objSubViewpointTypeEN.SubViewpointTypeId, objSubViewpointTypeEN.UpdUserId);
}
return strSubViewpointTypeId;
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
 /// <param name = "objSubViewpointTypeEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordWithReturnKey(this clsSubViewpointTypeEN objSubViewpointTypeEN, bool bolIsNeedCheckUniqueness = true)
{
if (bolIsNeedCheckUniqueness == true && CheckUniqueness(objSubViewpointTypeEN) == false)
{
var strMsg = string.Format("记录已经存在!类型名称 = [{0}]的数据已经存在!(in clsSubViewpointTypeBL.AddNewRecordWithReturnKey)", objSubViewpointTypeEN.SubViewpointTypeName);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objSubViewpointTypeEN.SubViewpointTypeId) == true || clsSubViewpointTypeBL.IsExist(objSubViewpointTypeEN.SubViewpointTypeId) == true)
 {
     objSubViewpointTypeEN.SubViewpointTypeId = clsSubViewpointTypeBL.GetMaxStrId_S();
 }
string strKey = clsSubViewpointTypeBL.SubViewpointTypeDA.AddNewRecordBySQL2WithReturnKey(objSubViewpointTypeEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsSubViewpointTypeBL.ReFreshCache();

if (clsSubViewpointTypeBL.relatedActions != null)
{
clsSubViewpointTypeBL.relatedActions.UpdRelaTabDate(objSubViewpointTypeEN.SubViewpointTypeId, objSubViewpointTypeEN.UpdUserId);
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
 /// <param name = "objSubViewpointTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsSubViewpointTypeEN SetSubViewpointTypeId(this clsSubViewpointTypeEN objSubViewpointTypeEN, string strSubViewpointTypeId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strSubViewpointTypeId, 8, conSubViewpointType.SubViewpointTypeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strSubViewpointTypeId, 8, conSubViewpointType.SubViewpointTypeId);
}
objSubViewpointTypeEN.SubViewpointTypeId = strSubViewpointTypeId; //类型Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objSubViewpointTypeEN.dicFldComparisonOp.ContainsKey(conSubViewpointType.SubViewpointTypeId) == false)
{
objSubViewpointTypeEN.dicFldComparisonOp.Add(conSubViewpointType.SubViewpointTypeId, strComparisonOp);
}
else
{
objSubViewpointTypeEN.dicFldComparisonOp[conSubViewpointType.SubViewpointTypeId] = strComparisonOp;
}
}
return objSubViewpointTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objSubViewpointTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsSubViewpointTypeEN SetSubViewpointTypeName(this clsSubViewpointTypeEN objSubViewpointTypeEN, string strSubViewpointTypeName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strSubViewpointTypeName, 50, conSubViewpointType.SubViewpointTypeName);
}
objSubViewpointTypeEN.SubViewpointTypeName = strSubViewpointTypeName; //类型名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objSubViewpointTypeEN.dicFldComparisonOp.ContainsKey(conSubViewpointType.SubViewpointTypeName) == false)
{
objSubViewpointTypeEN.dicFldComparisonOp.Add(conSubViewpointType.SubViewpointTypeName, strComparisonOp);
}
else
{
objSubViewpointTypeEN.dicFldComparisonOp[conSubViewpointType.SubViewpointTypeName] = strComparisonOp;
}
}
return objSubViewpointTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objSubViewpointTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsSubViewpointTypeEN SetSubViewpointTypeENName(this clsSubViewpointTypeEN objSubViewpointTypeEN, string strSubViewpointTypeENName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strSubViewpointTypeENName, 100, conSubViewpointType.SubViewpointTypeENName);
}
objSubViewpointTypeEN.SubViewpointTypeENName = strSubViewpointTypeENName; //类型英文名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objSubViewpointTypeEN.dicFldComparisonOp.ContainsKey(conSubViewpointType.SubViewpointTypeENName) == false)
{
objSubViewpointTypeEN.dicFldComparisonOp.Add(conSubViewpointType.SubViewpointTypeENName, strComparisonOp);
}
else
{
objSubViewpointTypeEN.dicFldComparisonOp[conSubViewpointType.SubViewpointTypeENName] = strComparisonOp;
}
}
return objSubViewpointTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objSubViewpointTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsSubViewpointTypeEN SetDefaTitle(this clsSubViewpointTypeEN objSubViewpointTypeEN, string strDefaTitle, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strDefaTitle, 20, conSubViewpointType.DefaTitle);
}
objSubViewpointTypeEN.DefaTitle = strDefaTitle; //默认标题
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objSubViewpointTypeEN.dicFldComparisonOp.ContainsKey(conSubViewpointType.DefaTitle) == false)
{
objSubViewpointTypeEN.dicFldComparisonOp.Add(conSubViewpointType.DefaTitle, strComparisonOp);
}
else
{
objSubViewpointTypeEN.dicFldComparisonOp[conSubViewpointType.DefaTitle] = strComparisonOp;
}
}
return objSubViewpointTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objSubViewpointTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsSubViewpointTypeEN SetOrderNum(this clsSubViewpointTypeEN objSubViewpointTypeEN, int? intOrderNum, string strComparisonOp="")
	{
objSubViewpointTypeEN.OrderNum = intOrderNum; //序号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objSubViewpointTypeEN.dicFldComparisonOp.ContainsKey(conSubViewpointType.OrderNum) == false)
{
objSubViewpointTypeEN.dicFldComparisonOp.Add(conSubViewpointType.OrderNum, strComparisonOp);
}
else
{
objSubViewpointTypeEN.dicFldComparisonOp[conSubViewpointType.OrderNum] = strComparisonOp;
}
}
return objSubViewpointTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objSubViewpointTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsSubViewpointTypeEN SetUpdDate(this clsSubViewpointTypeEN objSubViewpointTypeEN, string strUpdDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdDate, 20, conSubViewpointType.UpdDate);
}
objSubViewpointTypeEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objSubViewpointTypeEN.dicFldComparisonOp.ContainsKey(conSubViewpointType.UpdDate) == false)
{
objSubViewpointTypeEN.dicFldComparisonOp.Add(conSubViewpointType.UpdDate, strComparisonOp);
}
else
{
objSubViewpointTypeEN.dicFldComparisonOp[conSubViewpointType.UpdDate] = strComparisonOp;
}
}
return objSubViewpointTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objSubViewpointTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsSubViewpointTypeEN SetUpdUserId(this clsSubViewpointTypeEN objSubViewpointTypeEN, string strUpdUserId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdUserId, 20, conSubViewpointType.UpdUserId);
}
objSubViewpointTypeEN.UpdUserId = strUpdUserId; //修改用户Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objSubViewpointTypeEN.dicFldComparisonOp.ContainsKey(conSubViewpointType.UpdUserId) == false)
{
objSubViewpointTypeEN.dicFldComparisonOp.Add(conSubViewpointType.UpdUserId, strComparisonOp);
}
else
{
objSubViewpointTypeEN.dicFldComparisonOp[conSubViewpointType.UpdUserId] = strComparisonOp;
}
}
return objSubViewpointTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objSubViewpointTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsSubViewpointTypeEN SetMemo(this clsSubViewpointTypeEN objSubViewpointTypeEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, conSubViewpointType.Memo);
}
objSubViewpointTypeEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objSubViewpointTypeEN.dicFldComparisonOp.ContainsKey(conSubViewpointType.Memo) == false)
{
objSubViewpointTypeEN.dicFldComparisonOp.Add(conSubViewpointType.Memo, strComparisonOp);
}
else
{
objSubViewpointTypeEN.dicFldComparisonOp[conSubViewpointType.Memo] = strComparisonOp;
}
}
return objSubViewpointTypeEN;
	}

 /// <summary>
 /// 修改记录存盘到数据表中
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_UpdateRecordEx)
 /// </summary>
 /// <param name = "objSubViewpointTypeEN">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool UpdateRecordEx(this clsSubViewpointTypeEN objSubViewpointTypeEN)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
try
{
//1、检查传进去的对象属性是否合法
objSubViewpointTypeEN.CheckPropertyNew();
clsSubViewpointTypeEN objSubViewpointTypeCond = new clsSubViewpointTypeEN();
string strCondition = objSubViewpointTypeCond
.SetSubViewpointTypeId(objSubViewpointTypeEN.SubViewpointTypeId, "<>")
.SetSubViewpointTypeName(objSubViewpointTypeEN.SubViewpointTypeName, "=")
.GetCombineCondition();
objSubViewpointTypeEN._IsCheckProperty = true;
bool bolIsExist = clsSubViewpointTypeBL.IsExistRecord(strCondition);
if (bolIsExist)
{
strMsg = "(SubViewpointTypeName)不能重复!";
throw new Exception(strMsg);
}
//4、把数据实体层的数据存贮到数据库中
objSubViewpointTypeEN.Update();
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
 /// <param name = "objSubViewpointType">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool EditRecordEx(this clsSubViewpointTypeEN objSubViewpointType)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
clsSubViewpointTypeEN objSubViewpointTypeCond = new clsSubViewpointTypeEN();
string strCondition = objSubViewpointTypeCond
.SetSubViewpointTypeName(objSubViewpointType.SubViewpointTypeName, "=")
.GetCombineCondition();
objSubViewpointType._IsCheckProperty = true;
bool bolIsExist = clsSubViewpointTypeBL.IsExistRecord(strCondition);
if (bolIsExist)
{
objSubViewpointType.SubViewpointTypeId = clsSubViewpointTypeBL.GetFirstID_S(strCondition);
objSubViewpointType.UpdateWithCondition(strCondition);
}
else
{
objSubViewpointType.SubViewpointTypeId = clsSubViewpointTypeBL.GetMaxStrId_S();
objSubViewpointType.AddNewRecord();
}
return true; 
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_Update)
 /// </summary>
 /// <param name = "objSubViewpointTypeEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsSubViewpointTypeEN objSubViewpointTypeEN)
{
 if (string.IsNullOrEmpty(objSubViewpointTypeEN.SubViewpointTypeId) == true)
 {
string strMsg = string.Format("(errid:Busi000095)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsSubViewpointTypeBL.SubViewpointTypeDA.UpdateBySql2(objSubViewpointTypeEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsSubViewpointTypeBL.ReFreshCache();

if (clsSubViewpointTypeBL.relatedActions != null)
{
clsSubViewpointTypeBL.relatedActions.UpdRelaTabDate(objSubViewpointTypeEN.SubViewpointTypeId, objSubViewpointTypeEN.UpdUserId);
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
 /// <param name = "objSubViewpointTypeEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsSubViewpointTypeEN objSubViewpointTypeEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (string.IsNullOrEmpty(objSubViewpointTypeEN.SubViewpointTypeId) == true)
 {
string strMsg = string.Format("(errid:Busi000087)修改记录时关键字不能为空!(带事务处理)(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsSubViewpointTypeBL.SubViewpointTypeDA.UpdateBySql2(objSubViewpointTypeEN, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsSubViewpointTypeBL.ReFreshCache();

if (clsSubViewpointTypeBL.relatedActions != null)
{
clsSubViewpointTypeBL.relatedActions.UpdRelaTabDate(objSubViewpointTypeEN.SubViewpointTypeId, objSubViewpointTypeEN.UpdUserId);
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
 /// <param name = "objSubViewpointTypeEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsSubViewpointTypeEN objSubViewpointTypeEN, string strWhereCond)
{
try
{
bool bolResult = clsSubViewpointTypeBL.SubViewpointTypeDA.UpdateBySqlWithCondition(objSubViewpointTypeEN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsSubViewpointTypeBL.ReFreshCache();

if (clsSubViewpointTypeBL.relatedActions != null)
{
clsSubViewpointTypeBL.relatedActions.UpdRelaTabDate(objSubViewpointTypeEN.SubViewpointTypeId, objSubViewpointTypeEN.UpdUserId);
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
 /// <param name = "objSubViewpointTypeEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsSubViewpointTypeEN objSubViewpointTypeEN, string strWhereCond, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
bool bolResult = clsSubViewpointTypeBL.SubViewpointTypeDA.UpdateBySqlWithConditionTransaction(objSubViewpointTypeEN, strWhereCond, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsSubViewpointTypeBL.ReFreshCache();

if (clsSubViewpointTypeBL.relatedActions != null)
{
clsSubViewpointTypeBL.relatedActions.UpdRelaTabDate(objSubViewpointTypeEN.SubViewpointTypeId, objSubViewpointTypeEN.UpdUserId);
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
 /// <param name = "strSubViewpointTypeId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int Delete(this clsSubViewpointTypeEN objSubViewpointTypeEN)
{
try
{
int intRecNum = clsSubViewpointTypeBL.SubViewpointTypeDA.DelRecord(objSubViewpointTypeEN.SubViewpointTypeId);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsSubViewpointTypeBL.ReFreshCache();

if (clsSubViewpointTypeBL.relatedActions != null)
{
clsSubViewpointTypeBL.relatedActions.UpdRelaTabDate(objSubViewpointTypeEN.SubViewpointTypeId, objSubViewpointTypeEN.UpdUserId);
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
 /// <param name = "objSubViewpointTypeENS">源对象</param>
 /// <param name = "objSubViewpointTypeENT">目标对象</param>
 public static void CopyTo(this clsSubViewpointTypeEN objSubViewpointTypeENS, clsSubViewpointTypeEN objSubViewpointTypeENT)
{
try
{
objSubViewpointTypeENT.SubViewpointTypeId = objSubViewpointTypeENS.SubViewpointTypeId; //类型Id
objSubViewpointTypeENT.SubViewpointTypeName = objSubViewpointTypeENS.SubViewpointTypeName; //类型名称
objSubViewpointTypeENT.SubViewpointTypeENName = objSubViewpointTypeENS.SubViewpointTypeENName; //类型英文名
objSubViewpointTypeENT.DefaTitle = objSubViewpointTypeENS.DefaTitle; //默认标题
objSubViewpointTypeENT.OrderNum = objSubViewpointTypeENS.OrderNum; //序号
objSubViewpointTypeENT.UpdDate = objSubViewpointTypeENS.UpdDate; //修改日期
objSubViewpointTypeENT.UpdUserId = objSubViewpointTypeENS.UpdUserId; //修改用户Id
objSubViewpointTypeENT.Memo = objSubViewpointTypeENS.Memo; //备注
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
 /// <param name = "objSubViewpointTypeENS">源对象</param>
 /// <returns>目标对象=>clsSubViewpointTypeEN:objSubViewpointTypeENT</returns>
 public static clsSubViewpointTypeEN CopyTo(this clsSubViewpointTypeEN objSubViewpointTypeENS)
{
try
{
 clsSubViewpointTypeEN objSubViewpointTypeENT = new clsSubViewpointTypeEN()
{
SubViewpointTypeId = objSubViewpointTypeENS.SubViewpointTypeId, //类型Id
SubViewpointTypeName = objSubViewpointTypeENS.SubViewpointTypeName, //类型名称
SubViewpointTypeENName = objSubViewpointTypeENS.SubViewpointTypeENName, //类型英文名
DefaTitle = objSubViewpointTypeENS.DefaTitle, //默认标题
OrderNum = objSubViewpointTypeENS.OrderNum, //序号
UpdDate = objSubViewpointTypeENS.UpdDate, //修改日期
UpdUserId = objSubViewpointTypeENS.UpdUserId, //修改用户Id
Memo = objSubViewpointTypeENS.Memo, //备注
};
 return objSubViewpointTypeENT;
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
public static void CheckPropertyNew(this clsSubViewpointTypeEN objSubViewpointTypeEN)
{
 clsSubViewpointTypeBL.SubViewpointTypeDA.CheckPropertyNew(objSubViewpointTypeEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(this clsSubViewpointTypeEN objSubViewpointTypeEN)
{
 clsSubViewpointTypeBL.SubViewpointTypeDA.CheckProperty4Condition(objSubViewpointTypeEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsSubViewpointTypeEN objSubViewpointTypeCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objSubViewpointTypeCond.IsUpdated(conSubViewpointType.SubViewpointTypeId) == true)
{
string strComparisonOpSubViewpointTypeId = objSubViewpointTypeCond.dicFldComparisonOp[conSubViewpointType.SubViewpointTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conSubViewpointType.SubViewpointTypeId, objSubViewpointTypeCond.SubViewpointTypeId, strComparisonOpSubViewpointTypeId);
}
if (objSubViewpointTypeCond.IsUpdated(conSubViewpointType.SubViewpointTypeName) == true)
{
string strComparisonOpSubViewpointTypeName = objSubViewpointTypeCond.dicFldComparisonOp[conSubViewpointType.SubViewpointTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", conSubViewpointType.SubViewpointTypeName, objSubViewpointTypeCond.SubViewpointTypeName, strComparisonOpSubViewpointTypeName);
}
if (objSubViewpointTypeCond.IsUpdated(conSubViewpointType.SubViewpointTypeENName) == true)
{
string strComparisonOpSubViewpointTypeENName = objSubViewpointTypeCond.dicFldComparisonOp[conSubViewpointType.SubViewpointTypeENName];
strWhereCond += string.Format(" And {0} {2} '{1}'", conSubViewpointType.SubViewpointTypeENName, objSubViewpointTypeCond.SubViewpointTypeENName, strComparisonOpSubViewpointTypeENName);
}
if (objSubViewpointTypeCond.IsUpdated(conSubViewpointType.DefaTitle) == true)
{
string strComparisonOpDefaTitle = objSubViewpointTypeCond.dicFldComparisonOp[conSubViewpointType.DefaTitle];
strWhereCond += string.Format(" And {0} {2} '{1}'", conSubViewpointType.DefaTitle, objSubViewpointTypeCond.DefaTitle, strComparisonOpDefaTitle);
}
if (objSubViewpointTypeCond.IsUpdated(conSubViewpointType.OrderNum) == true)
{
string strComparisonOpOrderNum = objSubViewpointTypeCond.dicFldComparisonOp[conSubViewpointType.OrderNum];
strWhereCond += string.Format(" And {0} {2} {1}", conSubViewpointType.OrderNum, objSubViewpointTypeCond.OrderNum, strComparisonOpOrderNum);
}
if (objSubViewpointTypeCond.IsUpdated(conSubViewpointType.UpdDate) == true)
{
string strComparisonOpUpdDate = objSubViewpointTypeCond.dicFldComparisonOp[conSubViewpointType.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conSubViewpointType.UpdDate, objSubViewpointTypeCond.UpdDate, strComparisonOpUpdDate);
}
if (objSubViewpointTypeCond.IsUpdated(conSubViewpointType.UpdUserId) == true)
{
string strComparisonOpUpdUserId = objSubViewpointTypeCond.dicFldComparisonOp[conSubViewpointType.UpdUserId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conSubViewpointType.UpdUserId, objSubViewpointTypeCond.UpdUserId, strComparisonOpUpdUserId);
}
if (objSubViewpointTypeCond.IsUpdated(conSubViewpointType.Memo) == true)
{
string strComparisonOpMemo = objSubViewpointTypeCond.dicFldComparisonOp[conSubViewpointType.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", conSubViewpointType.Memo, objSubViewpointTypeCond.Memo, strComparisonOpMemo);
}
 return strWhereCond;
}

 /// <summary>
 /// 检查唯一性(Uniqueness)--SubViewpointType(子观点类型表), 如果不唯一,即存在相同的记录,就返回False
 /// 唯一性条件:SubViewpointTypeName
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckConstraint)
 /// </summary>
 /// <param name = "objSubViewpointTypeEN">要求唯一的对象</param>
 /// <returns></returns>
public static bool CheckUniqueness(this clsSubViewpointTypeEN objSubViewpointTypeEN)
{
//检测记录是否存在
bool bolIsUniqueness;
StringBuilder sbCondition = new StringBuilder();
if (objSubViewpointTypeEN == null) return true;
if (objSubViewpointTypeEN.SubViewpointTypeId == null || objSubViewpointTypeEN.SubViewpointTypeId == "")
{
sbCondition.AppendFormat("1 = 1");
 if (objSubViewpointTypeEN.SubViewpointTypeName == null)
{
 sbCondition.AppendFormat(" and SubViewpointTypeName is null", objSubViewpointTypeEN.SubViewpointTypeName);
}
else
{
 sbCondition.AppendFormat(" and SubViewpointTypeName = '{0}'", objSubViewpointTypeEN.SubViewpointTypeName);
}
if (clsSubViewpointTypeBL.IsExistRecord(sbCondition.ToString())  ==  true)
{
 bolIsUniqueness = false;
}
else
{
 bolIsUniqueness = true;
}
}
 else {
sbCondition.AppendFormat("SubViewpointTypeId !=  '{0}'", objSubViewpointTypeEN.SubViewpointTypeId);
 sbCondition.AppendFormat(" and SubViewpointTypeName = '{0}'", objSubViewpointTypeEN.SubViewpointTypeName);
if (clsSubViewpointTypeBL.IsExistRecord(sbCondition.ToString())  ==  true)
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
 /// 获取唯一性条件串--SubViewpointType(子观点类型表), 即由对象中唯一性条件字段关键字与值组成的条件串
 /// 唯一性条件:SubViewpointTypeName
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetConditionString4Constraint)
 /// </summary>
 /// <param name = "objSubViewpointTypeEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(this clsSubViewpointTypeEN objSubViewpointTypeEN)
{
//检测记录是否存在
StringBuilder sbCondition = new StringBuilder();
if (objSubViewpointTypeEN == null) return "";
if (objSubViewpointTypeEN.SubViewpointTypeId == null || objSubViewpointTypeEN.SubViewpointTypeId == "")
{
sbCondition.AppendFormat("1 = 1");
 if (objSubViewpointTypeEN.SubViewpointTypeName == null)
{
 sbCondition.AppendFormat(" and SubViewpointTypeName is null", objSubViewpointTypeEN.SubViewpointTypeName);
}
else
{
 sbCondition.AppendFormat(" and SubViewpointTypeName = '{0}'", objSubViewpointTypeEN.SubViewpointTypeName);
}
return sbCondition.ToString();
}
 else {
sbCondition.AppendFormat("SubViewpointTypeId !=  '{0}'", objSubViewpointTypeEN.SubViewpointTypeId);
 sbCondition.AppendFormat(" and SubViewpointTypeName = '{0}'", objSubViewpointTypeEN.SubViewpointTypeName);
 return sbCondition.ToString();
}
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_SubViewpointType
{
public virtual bool UpdRelaTabDate(string strSubViewpointTypeId, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// 根据表内容设置enum列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GeneEnumConstList)
 /// </summary>
public class enumSubViewpointType
{
 /// <summary>
 /// 全文
 /// </summary>
public const string AllPaper_00000000 = "00000000";
 /// <summary>
 /// 问题提出过程
 /// </summary>
public const string QuestioningProcess_00000001 = "00000001";
 /// <summary>
 /// 文献综述
 /// </summary>
public const string LiteratureReview_00000002 = "00000002";
 /// <summary>
 /// 研究意义
 /// </summary>
public const string Significance_00000003 = "00000003";
 /// <summary>
 /// 关键概念定义
 /// </summary>
public const string DefinitionOfKeyConcepts_00000004 = "00000004";
 /// <summary>
 /// 研究问题
 /// </summary>
public const string ResearchProblem_00000005 = "00000005";
 /// <summary>
 /// 研究流程
 /// </summary>
public const string ResearchProcess_00000006 = "00000006";
 /// <summary>
 /// 研究工具
 /// </summary>
public const string ResearchTool_00000007 = "00000007";
 /// <summary>
 /// 表格解读
 /// </summary>
public const string TableInterpretation_00000008 = "00000008";
 /// <summary>
 /// 学习预测模型
 /// </summary>
public const string LearningPredictiveModels_00000009 = "00000009";
 /// <summary>
 /// 讨论总结
 /// </summary>
public const string DiscussionSummary_00000010 = "00000010";
}
 /// <summary>
 /// 子观点类型表(SubViewpointType)
 /// 数据源类型:表
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsSubViewpointTypeBL
{
public static RelatedActions_SubViewpointType relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsSubViewpointTypeDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsSubViewpointTypeDA SubViewpointTypeDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsSubViewpointTypeDA();
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
 public clsSubViewpointTypeBL()
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
if (string.IsNullOrEmpty(clsSubViewpointTypeEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsSubViewpointTypeEN._ConnectString);
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
public static DataTable GetDataTable_SubViewpointType(string strWhereCond)
{
DataTable objDT;
try
{
objDT = SubViewpointTypeDA.GetDataTable_SubViewpointType(strWhereCond);
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
objDT = SubViewpointTypeDA.GetDataTable(strWhereCond);
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
objDT = SubViewpointTypeDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = SubViewpointTypeDA.GetDataTable(strWhereCond, strTabName);
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
objDT = SubViewpointTypeDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = SubViewpointTypeDA.GetDataTable_Top(objTopPara);
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
objDT = SubViewpointTypeDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = SubViewpointTypeDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = SubViewpointTypeDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
 /// <param name = "arrSubViewpointTypeIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static List<clsSubViewpointTypeEN> GetObjLstBySubViewpointTypeIdLst(List<string> arrSubViewpointTypeIdLst)
{
List<clsSubViewpointTypeEN> arrObjLst = new List<clsSubViewpointTypeEN>(); 
System.Data.DataTable objDT; 
 string strSqlConditionStr = clsArray.GetSqlInStrByArray(arrSubViewpointTypeIdLst, true);
 string strWhereCond = string.Format("SubViewpointTypeId in ({0})", strSqlConditionStr);
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsSubViewpointTypeEN objSubViewpointTypeEN = new clsSubViewpointTypeEN();
try
{
objSubViewpointTypeEN.SubViewpointTypeId = objRow[conSubViewpointType.SubViewpointTypeId].ToString().Trim(); //类型Id
objSubViewpointTypeEN.SubViewpointTypeName = objRow[conSubViewpointType.SubViewpointTypeName] == DBNull.Value ? null : objRow[conSubViewpointType.SubViewpointTypeName].ToString().Trim(); //类型名称
objSubViewpointTypeEN.SubViewpointTypeENName = objRow[conSubViewpointType.SubViewpointTypeENName] == DBNull.Value ? null : objRow[conSubViewpointType.SubViewpointTypeENName].ToString().Trim(); //类型英文名
objSubViewpointTypeEN.DefaTitle = objRow[conSubViewpointType.DefaTitle] == DBNull.Value ? null : objRow[conSubViewpointType.DefaTitle].ToString().Trim(); //默认标题
objSubViewpointTypeEN.OrderNum = objRow[conSubViewpointType.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conSubViewpointType.OrderNum].ToString().Trim()); //序号
objSubViewpointTypeEN.UpdDate = objRow[conSubViewpointType.UpdDate] == DBNull.Value ? null : objRow[conSubViewpointType.UpdDate].ToString().Trim(); //修改日期
objSubViewpointTypeEN.UpdUserId = objRow[conSubViewpointType.UpdUserId] == DBNull.Value ? null : objRow[conSubViewpointType.UpdUserId].ToString().Trim(); //修改用户Id
objSubViewpointTypeEN.Memo = objRow[conSubViewpointType.Memo] == DBNull.Value ? null : objRow[conSubViewpointType.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objSubViewpointTypeEN.SubViewpointTypeId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objSubViewpointTypeEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrSubViewpointTypeIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsSubViewpointTypeEN> GetObjLstBySubViewpointTypeIdLstCache(List<string> arrSubViewpointTypeIdLst)
{
string strKey = string.Format("{0}", clsSubViewpointTypeEN._CurrTabName);
List<clsSubViewpointTypeEN> arrSubViewpointTypeObjLstCache = GetObjLstCache();
IEnumerable <clsSubViewpointTypeEN> arrSubViewpointTypeObjLst_Sel =
arrSubViewpointTypeObjLstCache
.Where(x => arrSubViewpointTypeIdLst.Contains(x.SubViewpointTypeId));
return arrSubViewpointTypeObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsSubViewpointTypeEN> GetObjLst(string strWhereCond)
{
List<clsSubViewpointTypeEN> arrObjLst = new List<clsSubViewpointTypeEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsSubViewpointTypeEN objSubViewpointTypeEN = new clsSubViewpointTypeEN();
try
{
objSubViewpointTypeEN.SubViewpointTypeId = objRow[conSubViewpointType.SubViewpointTypeId].ToString().Trim(); //类型Id
objSubViewpointTypeEN.SubViewpointTypeName = objRow[conSubViewpointType.SubViewpointTypeName] == DBNull.Value ? null : objRow[conSubViewpointType.SubViewpointTypeName].ToString().Trim(); //类型名称
objSubViewpointTypeEN.SubViewpointTypeENName = objRow[conSubViewpointType.SubViewpointTypeENName] == DBNull.Value ? null : objRow[conSubViewpointType.SubViewpointTypeENName].ToString().Trim(); //类型英文名
objSubViewpointTypeEN.DefaTitle = objRow[conSubViewpointType.DefaTitle] == DBNull.Value ? null : objRow[conSubViewpointType.DefaTitle].ToString().Trim(); //默认标题
objSubViewpointTypeEN.OrderNum = objRow[conSubViewpointType.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conSubViewpointType.OrderNum].ToString().Trim()); //序号
objSubViewpointTypeEN.UpdDate = objRow[conSubViewpointType.UpdDate] == DBNull.Value ? null : objRow[conSubViewpointType.UpdDate].ToString().Trim(); //修改日期
objSubViewpointTypeEN.UpdUserId = objRow[conSubViewpointType.UpdUserId] == DBNull.Value ? null : objRow[conSubViewpointType.UpdUserId].ToString().Trim(); //修改用户Id
objSubViewpointTypeEN.Memo = objRow[conSubViewpointType.Memo] == DBNull.Value ? null : objRow[conSubViewpointType.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objSubViewpointTypeEN.SubViewpointTypeId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objSubViewpointTypeEN);
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
public static List<clsSubViewpointTypeEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsSubViewpointTypeEN> arrObjLst = new List<clsSubViewpointTypeEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsSubViewpointTypeEN objSubViewpointTypeEN = new clsSubViewpointTypeEN();
try
{
objSubViewpointTypeEN.SubViewpointTypeId = objRow[conSubViewpointType.SubViewpointTypeId].ToString().Trim(); //类型Id
objSubViewpointTypeEN.SubViewpointTypeName = objRow[conSubViewpointType.SubViewpointTypeName] == DBNull.Value ? null : objRow[conSubViewpointType.SubViewpointTypeName].ToString().Trim(); //类型名称
objSubViewpointTypeEN.SubViewpointTypeENName = objRow[conSubViewpointType.SubViewpointTypeENName] == DBNull.Value ? null : objRow[conSubViewpointType.SubViewpointTypeENName].ToString().Trim(); //类型英文名
objSubViewpointTypeEN.DefaTitle = objRow[conSubViewpointType.DefaTitle] == DBNull.Value ? null : objRow[conSubViewpointType.DefaTitle].ToString().Trim(); //默认标题
objSubViewpointTypeEN.OrderNum = objRow[conSubViewpointType.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conSubViewpointType.OrderNum].ToString().Trim()); //序号
objSubViewpointTypeEN.UpdDate = objRow[conSubViewpointType.UpdDate] == DBNull.Value ? null : objRow[conSubViewpointType.UpdDate].ToString().Trim(); //修改日期
objSubViewpointTypeEN.UpdUserId = objRow[conSubViewpointType.UpdUserId] == DBNull.Value ? null : objRow[conSubViewpointType.UpdUserId].ToString().Trim(); //修改用户Id
objSubViewpointTypeEN.Memo = objRow[conSubViewpointType.Memo] == DBNull.Value ? null : objRow[conSubViewpointType.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objSubViewpointTypeEN.SubViewpointTypeId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objSubViewpointTypeEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objSubViewpointTypeCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsSubViewpointTypeEN> GetSubObjLstCache(clsSubViewpointTypeEN objSubViewpointTypeCond)
{
List<clsSubViewpointTypeEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsSubViewpointTypeEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conSubViewpointType.AttributeName)
{
if (objSubViewpointTypeCond.IsUpdated(strFldName) == false) continue;
if (objSubViewpointTypeCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objSubViewpointTypeCond[strFldName].ToString());
}
else
{
if (objSubViewpointTypeCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objSubViewpointTypeCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objSubViewpointTypeCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objSubViewpointTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objSubViewpointTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objSubViewpointTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objSubViewpointTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objSubViewpointTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objSubViewpointTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objSubViewpointTypeCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objSubViewpointTypeCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objSubViewpointTypeCond[strFldName]));
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
public static List<clsSubViewpointTypeEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsSubViewpointTypeEN> arrObjLst = new List<clsSubViewpointTypeEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsSubViewpointTypeEN objSubViewpointTypeEN = new clsSubViewpointTypeEN();
try
{
objSubViewpointTypeEN.SubViewpointTypeId = objRow[conSubViewpointType.SubViewpointTypeId].ToString().Trim(); //类型Id
objSubViewpointTypeEN.SubViewpointTypeName = objRow[conSubViewpointType.SubViewpointTypeName] == DBNull.Value ? null : objRow[conSubViewpointType.SubViewpointTypeName].ToString().Trim(); //类型名称
objSubViewpointTypeEN.SubViewpointTypeENName = objRow[conSubViewpointType.SubViewpointTypeENName] == DBNull.Value ? null : objRow[conSubViewpointType.SubViewpointTypeENName].ToString().Trim(); //类型英文名
objSubViewpointTypeEN.DefaTitle = objRow[conSubViewpointType.DefaTitle] == DBNull.Value ? null : objRow[conSubViewpointType.DefaTitle].ToString().Trim(); //默认标题
objSubViewpointTypeEN.OrderNum = objRow[conSubViewpointType.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conSubViewpointType.OrderNum].ToString().Trim()); //序号
objSubViewpointTypeEN.UpdDate = objRow[conSubViewpointType.UpdDate] == DBNull.Value ? null : objRow[conSubViewpointType.UpdDate].ToString().Trim(); //修改日期
objSubViewpointTypeEN.UpdUserId = objRow[conSubViewpointType.UpdUserId] == DBNull.Value ? null : objRow[conSubViewpointType.UpdUserId].ToString().Trim(); //修改用户Id
objSubViewpointTypeEN.Memo = objRow[conSubViewpointType.Memo] == DBNull.Value ? null : objRow[conSubViewpointType.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objSubViewpointTypeEN.SubViewpointTypeId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objSubViewpointTypeEN);
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
public static List<clsSubViewpointTypeEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsSubViewpointTypeEN> arrObjLst = new List<clsSubViewpointTypeEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsSubViewpointTypeEN objSubViewpointTypeEN = new clsSubViewpointTypeEN();
try
{
objSubViewpointTypeEN.SubViewpointTypeId = objRow[conSubViewpointType.SubViewpointTypeId].ToString().Trim(); //类型Id
objSubViewpointTypeEN.SubViewpointTypeName = objRow[conSubViewpointType.SubViewpointTypeName] == DBNull.Value ? null : objRow[conSubViewpointType.SubViewpointTypeName].ToString().Trim(); //类型名称
objSubViewpointTypeEN.SubViewpointTypeENName = objRow[conSubViewpointType.SubViewpointTypeENName] == DBNull.Value ? null : objRow[conSubViewpointType.SubViewpointTypeENName].ToString().Trim(); //类型英文名
objSubViewpointTypeEN.DefaTitle = objRow[conSubViewpointType.DefaTitle] == DBNull.Value ? null : objRow[conSubViewpointType.DefaTitle].ToString().Trim(); //默认标题
objSubViewpointTypeEN.OrderNum = objRow[conSubViewpointType.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conSubViewpointType.OrderNum].ToString().Trim()); //序号
objSubViewpointTypeEN.UpdDate = objRow[conSubViewpointType.UpdDate] == DBNull.Value ? null : objRow[conSubViewpointType.UpdDate].ToString().Trim(); //修改日期
objSubViewpointTypeEN.UpdUserId = objRow[conSubViewpointType.UpdUserId] == DBNull.Value ? null : objRow[conSubViewpointType.UpdUserId].ToString().Trim(); //修改用户Id
objSubViewpointTypeEN.Memo = objRow[conSubViewpointType.Memo] == DBNull.Value ? null : objRow[conSubViewpointType.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objSubViewpointTypeEN.SubViewpointTypeId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objSubViewpointTypeEN);
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
List<clsSubViewpointTypeEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsSubViewpointTypeEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsSubViewpointTypeEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsSubViewpointTypeEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsSubViewpointTypeEN> arrObjLst = new List<clsSubViewpointTypeEN>(); 
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
	clsSubViewpointTypeEN objSubViewpointTypeEN = new clsSubViewpointTypeEN();
try
{
objSubViewpointTypeEN.SubViewpointTypeId = objRow[conSubViewpointType.SubViewpointTypeId].ToString().Trim(); //类型Id
objSubViewpointTypeEN.SubViewpointTypeName = objRow[conSubViewpointType.SubViewpointTypeName] == DBNull.Value ? null : objRow[conSubViewpointType.SubViewpointTypeName].ToString().Trim(); //类型名称
objSubViewpointTypeEN.SubViewpointTypeENName = objRow[conSubViewpointType.SubViewpointTypeENName] == DBNull.Value ? null : objRow[conSubViewpointType.SubViewpointTypeENName].ToString().Trim(); //类型英文名
objSubViewpointTypeEN.DefaTitle = objRow[conSubViewpointType.DefaTitle] == DBNull.Value ? null : objRow[conSubViewpointType.DefaTitle].ToString().Trim(); //默认标题
objSubViewpointTypeEN.OrderNum = objRow[conSubViewpointType.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conSubViewpointType.OrderNum].ToString().Trim()); //序号
objSubViewpointTypeEN.UpdDate = objRow[conSubViewpointType.UpdDate] == DBNull.Value ? null : objRow[conSubViewpointType.UpdDate].ToString().Trim(); //修改日期
objSubViewpointTypeEN.UpdUserId = objRow[conSubViewpointType.UpdUserId] == DBNull.Value ? null : objRow[conSubViewpointType.UpdUserId].ToString().Trim(); //修改用户Id
objSubViewpointTypeEN.Memo = objRow[conSubViewpointType.Memo] == DBNull.Value ? null : objRow[conSubViewpointType.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objSubViewpointTypeEN.SubViewpointTypeId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objSubViewpointTypeEN);
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
public static List<clsSubViewpointTypeEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsSubViewpointTypeEN> arrObjLst = new List<clsSubViewpointTypeEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsSubViewpointTypeEN objSubViewpointTypeEN = new clsSubViewpointTypeEN();
try
{
objSubViewpointTypeEN.SubViewpointTypeId = objRow[conSubViewpointType.SubViewpointTypeId].ToString().Trim(); //类型Id
objSubViewpointTypeEN.SubViewpointTypeName = objRow[conSubViewpointType.SubViewpointTypeName] == DBNull.Value ? null : objRow[conSubViewpointType.SubViewpointTypeName].ToString().Trim(); //类型名称
objSubViewpointTypeEN.SubViewpointTypeENName = objRow[conSubViewpointType.SubViewpointTypeENName] == DBNull.Value ? null : objRow[conSubViewpointType.SubViewpointTypeENName].ToString().Trim(); //类型英文名
objSubViewpointTypeEN.DefaTitle = objRow[conSubViewpointType.DefaTitle] == DBNull.Value ? null : objRow[conSubViewpointType.DefaTitle].ToString().Trim(); //默认标题
objSubViewpointTypeEN.OrderNum = objRow[conSubViewpointType.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conSubViewpointType.OrderNum].ToString().Trim()); //序号
objSubViewpointTypeEN.UpdDate = objRow[conSubViewpointType.UpdDate] == DBNull.Value ? null : objRow[conSubViewpointType.UpdDate].ToString().Trim(); //修改日期
objSubViewpointTypeEN.UpdUserId = objRow[conSubViewpointType.UpdUserId] == DBNull.Value ? null : objRow[conSubViewpointType.UpdUserId].ToString().Trim(); //修改用户Id
objSubViewpointTypeEN.Memo = objRow[conSubViewpointType.Memo] == DBNull.Value ? null : objRow[conSubViewpointType.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objSubViewpointTypeEN.SubViewpointTypeId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objSubViewpointTypeEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsSubViewpointTypeEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsSubViewpointTypeEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsSubViewpointTypeEN> arrObjLst = new List<clsSubViewpointTypeEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsSubViewpointTypeEN objSubViewpointTypeEN = new clsSubViewpointTypeEN();
try
{
objSubViewpointTypeEN.SubViewpointTypeId = objRow[conSubViewpointType.SubViewpointTypeId].ToString().Trim(); //类型Id
objSubViewpointTypeEN.SubViewpointTypeName = objRow[conSubViewpointType.SubViewpointTypeName] == DBNull.Value ? null : objRow[conSubViewpointType.SubViewpointTypeName].ToString().Trim(); //类型名称
objSubViewpointTypeEN.SubViewpointTypeENName = objRow[conSubViewpointType.SubViewpointTypeENName] == DBNull.Value ? null : objRow[conSubViewpointType.SubViewpointTypeENName].ToString().Trim(); //类型英文名
objSubViewpointTypeEN.DefaTitle = objRow[conSubViewpointType.DefaTitle] == DBNull.Value ? null : objRow[conSubViewpointType.DefaTitle].ToString().Trim(); //默认标题
objSubViewpointTypeEN.OrderNum = objRow[conSubViewpointType.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conSubViewpointType.OrderNum].ToString().Trim()); //序号
objSubViewpointTypeEN.UpdDate = objRow[conSubViewpointType.UpdDate] == DBNull.Value ? null : objRow[conSubViewpointType.UpdDate].ToString().Trim(); //修改日期
objSubViewpointTypeEN.UpdUserId = objRow[conSubViewpointType.UpdUserId] == DBNull.Value ? null : objRow[conSubViewpointType.UpdUserId].ToString().Trim(); //修改用户Id
objSubViewpointTypeEN.Memo = objRow[conSubViewpointType.Memo] == DBNull.Value ? null : objRow[conSubViewpointType.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objSubViewpointTypeEN.SubViewpointTypeId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objSubViewpointTypeEN);
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
public static List<clsSubViewpointTypeEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsSubViewpointTypeEN> arrObjLst = new List<clsSubViewpointTypeEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsSubViewpointTypeEN objSubViewpointTypeEN = new clsSubViewpointTypeEN();
try
{
objSubViewpointTypeEN.SubViewpointTypeId = objRow[conSubViewpointType.SubViewpointTypeId].ToString().Trim(); //类型Id
objSubViewpointTypeEN.SubViewpointTypeName = objRow[conSubViewpointType.SubViewpointTypeName] == DBNull.Value ? null : objRow[conSubViewpointType.SubViewpointTypeName].ToString().Trim(); //类型名称
objSubViewpointTypeEN.SubViewpointTypeENName = objRow[conSubViewpointType.SubViewpointTypeENName] == DBNull.Value ? null : objRow[conSubViewpointType.SubViewpointTypeENName].ToString().Trim(); //类型英文名
objSubViewpointTypeEN.DefaTitle = objRow[conSubViewpointType.DefaTitle] == DBNull.Value ? null : objRow[conSubViewpointType.DefaTitle].ToString().Trim(); //默认标题
objSubViewpointTypeEN.OrderNum = objRow[conSubViewpointType.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conSubViewpointType.OrderNum].ToString().Trim()); //序号
objSubViewpointTypeEN.UpdDate = objRow[conSubViewpointType.UpdDate] == DBNull.Value ? null : objRow[conSubViewpointType.UpdDate].ToString().Trim(); //修改日期
objSubViewpointTypeEN.UpdUserId = objRow[conSubViewpointType.UpdUserId] == DBNull.Value ? null : objRow[conSubViewpointType.UpdUserId].ToString().Trim(); //修改用户Id
objSubViewpointTypeEN.Memo = objRow[conSubViewpointType.Memo] == DBNull.Value ? null : objRow[conSubViewpointType.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objSubViewpointTypeEN.SubViewpointTypeId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objSubViewpointTypeEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsSubViewpointTypeEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsSubViewpointTypeEN> arrObjLst = new List<clsSubViewpointTypeEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsSubViewpointTypeEN objSubViewpointTypeEN = new clsSubViewpointTypeEN();
try
{
objSubViewpointTypeEN.SubViewpointTypeId = objRow[conSubViewpointType.SubViewpointTypeId].ToString().Trim(); //类型Id
objSubViewpointTypeEN.SubViewpointTypeName = objRow[conSubViewpointType.SubViewpointTypeName] == DBNull.Value ? null : objRow[conSubViewpointType.SubViewpointTypeName].ToString().Trim(); //类型名称
objSubViewpointTypeEN.SubViewpointTypeENName = objRow[conSubViewpointType.SubViewpointTypeENName] == DBNull.Value ? null : objRow[conSubViewpointType.SubViewpointTypeENName].ToString().Trim(); //类型英文名
objSubViewpointTypeEN.DefaTitle = objRow[conSubViewpointType.DefaTitle] == DBNull.Value ? null : objRow[conSubViewpointType.DefaTitle].ToString().Trim(); //默认标题
objSubViewpointTypeEN.OrderNum = objRow[conSubViewpointType.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conSubViewpointType.OrderNum].ToString().Trim()); //序号
objSubViewpointTypeEN.UpdDate = objRow[conSubViewpointType.UpdDate] == DBNull.Value ? null : objRow[conSubViewpointType.UpdDate].ToString().Trim(); //修改日期
objSubViewpointTypeEN.UpdUserId = objRow[conSubViewpointType.UpdUserId] == DBNull.Value ? null : objRow[conSubViewpointType.UpdUserId].ToString().Trim(); //修改用户Id
objSubViewpointTypeEN.Memo = objRow[conSubViewpointType.Memo] == DBNull.Value ? null : objRow[conSubViewpointType.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objSubViewpointTypeEN.SubViewpointTypeId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objSubViewpointTypeEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objSubViewpointTypeEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetSubViewpointType(ref clsSubViewpointTypeEN objSubViewpointTypeEN)
{
bool bolResult = SubViewpointTypeDA.GetSubViewpointType(ref objSubViewpointTypeEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "strSubViewpointTypeId">表关键字</param>
 /// <returns>表对象</returns>
public static clsSubViewpointTypeEN GetObjBySubViewpointTypeId(string strSubViewpointTypeId)
{
if (strSubViewpointTypeId.IndexOf(' ') >=0)
{
var strMsg = string.Format("(errid:Busi000079)在表中,关键字[strSubViewpointTypeId]中不能有空格!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
if (string.IsNullOrEmpty(strSubViewpointTypeId) == true)
{
var strMsg = string.Format("(errid:Busi000020)在表中,关键字[strSubViewpointTypeId]不能为空!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
clsSubViewpointTypeEN objSubViewpointTypeEN = SubViewpointTypeDA.GetObjBySubViewpointTypeId(strSubViewpointTypeId);
return objSubViewpointTypeEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsSubViewpointTypeEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsSubViewpointTypeEN objSubViewpointTypeEN = SubViewpointTypeDA.GetFirstObj(strWhereCond);
 return objSubViewpointTypeEN;
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
public static clsSubViewpointTypeEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsSubViewpointTypeEN objSubViewpointTypeEN = SubViewpointTypeDA.GetObjByDataRow(objRow);
 return objSubViewpointTypeEN;
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
public static clsSubViewpointTypeEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsSubViewpointTypeEN objSubViewpointTypeEN = SubViewpointTypeDA.GetObjByDataRow(objRow);
 return objSubViewpointTypeEN;
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
 /// <param name = "strSubViewpointTypeId">所给的关键字</param>
 /// <param name = "lstSubViewpointTypeObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsSubViewpointTypeEN GetObjBySubViewpointTypeIdFromList(string strSubViewpointTypeId, List<clsSubViewpointTypeEN> lstSubViewpointTypeObjLst)
{
foreach (clsSubViewpointTypeEN objSubViewpointTypeEN in lstSubViewpointTypeObjLst)
{
if (objSubViewpointTypeEN.SubViewpointTypeId == strSubViewpointTypeId)
{
return objSubViewpointTypeEN;
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
 string strMaxSubViewpointTypeId;
 try
 {
 strMaxSubViewpointTypeId = clsSubViewpointTypeDA.GetMaxStrId();
 return strMaxSubViewpointTypeId;
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
 string strSubViewpointTypeId;
 try
 {
 strSubViewpointTypeId = new clsSubViewpointTypeDA().GetFirstID(strWhereCond);
 return strSubViewpointTypeId;
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
 arrList = SubViewpointTypeDA.GetID(strWhereCond);
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
bool bolIsExist = SubViewpointTypeDA.IsExistCondRec(strWhereCond);
return bolIsExist;
}

 /// <summary>
 /// 判断当前表中是否存在给定关键字值的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExist)
 /// </summary>
 /// <param name = "strSubViewpointTypeId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public static bool IsExist(string strSubViewpointTypeId)
{
if (string.IsNullOrEmpty(strSubViewpointTypeId) == true)
{
var strMsg = string.Format("(errid:Busi000027)在表中,关键字[strSubViewpointTypeId]不能为空!!(from {0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
//检测记录是否存在
bool bolIsExist = SubViewpointTypeDA.IsExist(strSubViewpointTypeId);
return bolIsExist;
}

/// <summary>
/// 设置修改时间
/// </summary>
/// <param name = "strSubViewpointTypeId">类型Id</param>
/// <param name = "strOpUser">修改用户</param>
/// <returns>是否成功？</returns>
public static bool SetUpdDate(string strSubViewpointTypeId, string strOpUser)
{
clsSubViewpointTypeEN objSubViewpointTypeEN = clsSubViewpointTypeBL.GetObjBySubViewpointTypeId(strSubViewpointTypeId);
objSubViewpointTypeEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
objSubViewpointTypeEN.UpdUserId = strOpUser;
return clsSubViewpointTypeBL.UpdateBySql2(objSubViewpointTypeEN);
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
 bolIsExist = clsSubViewpointTypeDA.IsExistTable();
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
 bolIsExist = SubViewpointTypeDA.IsExistTable(strTabName);
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
 /// <param name = "objSubViewpointTypeEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecordBySql2(clsSubViewpointTypeEN objSubViewpointTypeEN, bool bolIsNeedCheckUniqueness=true)
{
if (bolIsNeedCheckUniqueness == true && objSubViewpointTypeEN.CheckUniqueness() == false)
{
var strMsg = string.Format("记录已经存在!类型名称 = [{0}]的数据已经存在!(in clsSubViewpointTypeBL.AddNewRecordBySql2)", objSubViewpointTypeEN.SubViewpointTypeName);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objSubViewpointTypeEN.SubViewpointTypeId) == true || clsSubViewpointTypeBL.IsExist(objSubViewpointTypeEN.SubViewpointTypeId) == true)
 {
     objSubViewpointTypeEN.SubViewpointTypeId = clsSubViewpointTypeBL.GetMaxStrId_S();
 }
bool bolResult = SubViewpointTypeDA.AddNewRecordBySQL2(objSubViewpointTypeEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsSubViewpointTypeBL.ReFreshCache();

if (clsSubViewpointTypeBL.relatedActions != null)
{
clsSubViewpointTypeBL.relatedActions.UpdRelaTabDate(objSubViewpointTypeEN.SubViewpointTypeId, objSubViewpointTypeEN.UpdUserId);
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
 /// <param name = "objSubViewpointTypeEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordBySql2WithReturnKey(clsSubViewpointTypeEN objSubViewpointTypeEN, bool bolIsNeedCheckUniqueness=true)
{
if (bolIsNeedCheckUniqueness == true && objSubViewpointTypeEN.CheckUniqueness() == false)
{
var strMsg = string.Format("记录已经存在!类型名称 = [{0}]的数据已经存在!(in clsSubViewpointTypeBL.AddNewRecordBySql2WithReturnKey)", objSubViewpointTypeEN.SubViewpointTypeName);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objSubViewpointTypeEN.SubViewpointTypeId) == true || clsSubViewpointTypeBL.IsExist(objSubViewpointTypeEN.SubViewpointTypeId) == true)
 {
     objSubViewpointTypeEN.SubViewpointTypeId = clsSubViewpointTypeBL.GetMaxStrId_S();
 }
string strKey = SubViewpointTypeDA.AddNewRecordBySQL2WithReturnKey(objSubViewpointTypeEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsSubViewpointTypeBL.ReFreshCache();

if (clsSubViewpointTypeBL.relatedActions != null)
{
clsSubViewpointTypeBL.relatedActions.UpdRelaTabDate(objSubViewpointTypeEN.SubViewpointTypeId, objSubViewpointTypeEN.UpdUserId);
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
 /// <param name = "objSubViewpointTypeEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(clsSubViewpointTypeEN objSubViewpointTypeEN)
{
try
{
bool bolResult = SubViewpointTypeDA.Update(objSubViewpointTypeEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsSubViewpointTypeBL.ReFreshCache();

if (clsSubViewpointTypeBL.relatedActions != null)
{
clsSubViewpointTypeBL.relatedActions.UpdRelaTabDate(objSubViewpointTypeEN.SubViewpointTypeId, objSubViewpointTypeEN.UpdUserId);
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
 /// <param name = "objSubViewpointTypeEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateBySql2(clsSubViewpointTypeEN objSubViewpointTypeEN)
{
 if (string.IsNullOrEmpty(objSubViewpointTypeEN.SubViewpointTypeId) == true)
 {
var strMsg = string.Format("(errid:Busi000065)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = SubViewpointTypeDA.UpdateBySql2(objSubViewpointTypeEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsSubViewpointTypeBL.ReFreshCache();

if (clsSubViewpointTypeBL.relatedActions != null)
{
clsSubViewpointTypeBL.relatedActions.UpdRelaTabDate(objSubViewpointTypeEN.SubViewpointTypeId, objSubViewpointTypeEN.UpdUserId);
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
 /// <param name = "strSubViewpointTypeId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int DelRecord(string strSubViewpointTypeId)
{
try
{
 clsSubViewpointTypeEN objSubViewpointTypeEN = clsSubViewpointTypeBL.GetObjBySubViewpointTypeId(strSubViewpointTypeId);

if (clsSubViewpointTypeBL.relatedActions != null)
{
clsSubViewpointTypeBL.relatedActions.UpdRelaTabDate(objSubViewpointTypeEN.SubViewpointTypeId, objSubViewpointTypeEN.UpdUserId);
}
if (objSubViewpointTypeEN != null)
{
int intRecNum = SubViewpointTypeDA.DelRecord(strSubViewpointTypeId);
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
/// <param name="strSubViewpointTypeId">表关键字</param>
/// <returns></returns>
public static bool DelRecordEx(string strSubViewpointTypeId )
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsSubViewpointTypeDA.GetSpecSQLObj();
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
//删除与表:[SubViewpointType]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conSubViewpointType.SubViewpointTypeId,
//strSubViewpointTypeId);
//        clsSubViewpointTypeBL.DelSubViewpointTypesByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsSubViewpointTypeBL.DelRecord(strSubViewpointTypeId, objConnection, objSqlTransaction);
objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsSubViewpointTypeBLEx", "DelRecordEx", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("扩展删除记录出错:{0}!keyId = {1}.({2})",
objException.Message,
strSubViewpointTypeId, clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "strSubViewpointTypeId">给定的关键字值</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回删除是否成功?</returns>
public static bool DelRecord(string strSubViewpointTypeId, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
if (clsSubViewpointTypeBL.relatedActions != null)
{
clsSubViewpointTypeBL.relatedActions.UpdRelaTabDate(strSubViewpointTypeId, "UpdRelaTabDate");
}
bool bolResult = SubViewpointTypeDA.DelRecord(strSubViewpointTypeId,objSqlConnection,objSqlTransaction);
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
 /// <param name = "arrSubViewpointTypeIdLst">给定的关键字值列表</param>
 /// <returns>返回删除的记录数</returns>
public static int DelSubViewpointTypes(List<string> arrSubViewpointTypeIdLst)
{
if (arrSubViewpointTypeIdLst.Count == 0) return 0;
try
{
if (clsSubViewpointTypeBL.relatedActions != null)
{
foreach (var strSubViewpointTypeId in arrSubViewpointTypeIdLst)
{
clsSubViewpointTypeBL.relatedActions.UpdRelaTabDate(strSubViewpointTypeId, "UpdRelaTabDate");
}
}
int intDelRecNum = SubViewpointTypeDA.DelSubViewpointType(arrSubViewpointTypeIdLst);
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
public static int DelSubViewpointTypesByCond(string strWhereCond)
{
try
{
if (clsSubViewpointTypeBL.relatedActions != null)
{
List<string> arrSubViewpointTypeId = GetPrimaryKeyID_S(strWhereCond);
foreach (var strSubViewpointTypeId in arrSubViewpointTypeId)
{
clsSubViewpointTypeBL.relatedActions.UpdRelaTabDate(strSubViewpointTypeId, "UpdRelaTabDate");
}
}
int intRecNum = SubViewpointTypeDA.DelSubViewpointType(strWhereCond);
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
/// 这里仅仅是演示函数,使用时请复制到扩展类:[SubViewpointType]中改名为:[DelRecord4MultiTabEx]使用
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DelRecord4MultiTab)
/// </summary>
/// <param name="strSubViewpointTypeId">表关键字</param>
/// <returns></returns>
public static bool DelRecord4MultiTab(string strSubViewpointTypeId)
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsSubViewpointTypeDA.GetSpecSQLObj();
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
//删除与表:[SubViewpointType]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conStudent.id_College,
//strid_College);
//        clsStudentBL.DelStudentsByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsSubViewpointTypeBL.DelRecord(strSubViewpointTypeId, objConnection, objSqlTransaction);
                objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsSubViewpointTypeBL", "DelRecord4MultiTab", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("删除多表记录出错:{0}!keyId = {1}.({2})",
objException.Message,
strSubViewpointTypeId, clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "objSubViewpointTypeENS">源对象</param>
 /// <param name = "objSubViewpointTypeENT">目标对象</param>
 public static void CopyTo(clsSubViewpointTypeEN objSubViewpointTypeENS, clsSubViewpointTypeEN objSubViewpointTypeENT)
{
try
{
objSubViewpointTypeENT.SubViewpointTypeId = objSubViewpointTypeENS.SubViewpointTypeId; //类型Id
objSubViewpointTypeENT.SubViewpointTypeName = objSubViewpointTypeENS.SubViewpointTypeName; //类型名称
objSubViewpointTypeENT.SubViewpointTypeENName = objSubViewpointTypeENS.SubViewpointTypeENName; //类型英文名
objSubViewpointTypeENT.DefaTitle = objSubViewpointTypeENS.DefaTitle; //默认标题
objSubViewpointTypeENT.OrderNum = objSubViewpointTypeENS.OrderNum; //序号
objSubViewpointTypeENT.UpdDate = objSubViewpointTypeENS.UpdDate; //修改日期
objSubViewpointTypeENT.UpdUserId = objSubViewpointTypeENS.UpdUserId; //修改用户Id
objSubViewpointTypeENT.Memo = objSubViewpointTypeENS.Memo; //备注
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
 /// <param name = "objSubViewpointTypeEN">源简化对象</param>
 public static void SetUpdFlag(clsSubViewpointTypeEN objSubViewpointTypeEN)
{
try
{
objSubViewpointTypeEN.ClearUpdateState();
   string strsfUpdFldSetStr = objSubViewpointTypeEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(conSubViewpointType.SubViewpointTypeId, new clsStrCompareIgnoreCase())  ==  true)
{
objSubViewpointTypeEN.SubViewpointTypeId = objSubViewpointTypeEN.SubViewpointTypeId; //类型Id
}
if (arrFldSet.Contains(conSubViewpointType.SubViewpointTypeName, new clsStrCompareIgnoreCase())  ==  true)
{
objSubViewpointTypeEN.SubViewpointTypeName = objSubViewpointTypeEN.SubViewpointTypeName == "[null]" ? null :  objSubViewpointTypeEN.SubViewpointTypeName; //类型名称
}
if (arrFldSet.Contains(conSubViewpointType.SubViewpointTypeENName, new clsStrCompareIgnoreCase())  ==  true)
{
objSubViewpointTypeEN.SubViewpointTypeENName = objSubViewpointTypeEN.SubViewpointTypeENName == "[null]" ? null :  objSubViewpointTypeEN.SubViewpointTypeENName; //类型英文名
}
if (arrFldSet.Contains(conSubViewpointType.DefaTitle, new clsStrCompareIgnoreCase())  ==  true)
{
objSubViewpointTypeEN.DefaTitle = objSubViewpointTypeEN.DefaTitle == "[null]" ? null :  objSubViewpointTypeEN.DefaTitle; //默认标题
}
if (arrFldSet.Contains(conSubViewpointType.OrderNum, new clsStrCompareIgnoreCase())  ==  true)
{
objSubViewpointTypeEN.OrderNum = objSubViewpointTypeEN.OrderNum; //序号
}
if (arrFldSet.Contains(conSubViewpointType.UpdDate, new clsStrCompareIgnoreCase())  ==  true)
{
objSubViewpointTypeEN.UpdDate = objSubViewpointTypeEN.UpdDate == "[null]" ? null :  objSubViewpointTypeEN.UpdDate; //修改日期
}
if (arrFldSet.Contains(conSubViewpointType.UpdUserId, new clsStrCompareIgnoreCase())  ==  true)
{
objSubViewpointTypeEN.UpdUserId = objSubViewpointTypeEN.UpdUserId == "[null]" ? null :  objSubViewpointTypeEN.UpdUserId; //修改用户Id
}
if (arrFldSet.Contains(conSubViewpointType.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objSubViewpointTypeEN.Memo = objSubViewpointTypeEN.Memo == "[null]" ? null :  objSubViewpointTypeEN.Memo; //备注
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
 /// <param name = "objSubViewpointTypeEN">源简化对象</param>
 public static void AccessFldValueNull(clsSubViewpointTypeEN objSubViewpointTypeEN)
{
try
{
if (objSubViewpointTypeEN.SubViewpointTypeName == "[null]") objSubViewpointTypeEN.SubViewpointTypeName = null; //类型名称
if (objSubViewpointTypeEN.SubViewpointTypeENName == "[null]") objSubViewpointTypeEN.SubViewpointTypeENName = null; //类型英文名
if (objSubViewpointTypeEN.DefaTitle == "[null]") objSubViewpointTypeEN.DefaTitle = null; //默认标题
if (objSubViewpointTypeEN.UpdDate == "[null]") objSubViewpointTypeEN.UpdDate = null; //修改日期
if (objSubViewpointTypeEN.UpdUserId == "[null]") objSubViewpointTypeEN.UpdUserId = null; //修改用户Id
if (objSubViewpointTypeEN.Memo == "[null]") objSubViewpointTypeEN.Memo = null; //备注
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
public static void CheckPropertyNew(clsSubViewpointTypeEN objSubViewpointTypeEN)
{
 SubViewpointTypeDA.CheckPropertyNew(objSubViewpointTypeEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(clsSubViewpointTypeEN objSubViewpointTypeEN)
{
 SubViewpointTypeDA.CheckProperty4Condition(objSubViewpointTypeEN);
 }


 #endregion 检查对象属性


 #region 绑定下拉框

 /// <summary>
 /// 绑定基于Win的下拉框
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_TabFeature_ComboBoxBindFunction)
 /// </summary>
 /// <param name = "objComboBox">需要绑定当前表的下拉框</param>

public static void BindCbo_SubViewpointTypeId(System.Windows.Forms.ComboBox objComboBox )
{
//为数据源为表的下拉框设置内容
string strCondition = string.Format("1 =1 Order By {0}", conSubViewpointType.SubViewpointTypeId); 
List<clsSubViewpointTypeEN> arrObjLst = clsSubViewpointTypeBL.GetObjLst(strCondition);
//初始化一个对象列表
//插入第0项。在第0项中插入“请选择...”,为了方便用户,与WEB方式类似。
clsSubViewpointTypeEN objSubViewpointTypeEN = new clsSubViewpointTypeEN()
{
SubViewpointTypeId = "0",
SubViewpointTypeName = "选[子观点类型表]..."
};
arrObjLst.Insert(0, objSubViewpointTypeEN);
//设置下拉框的数据源、以及设置值项、显示项
objComboBox.ValueMember = conSubViewpointType.SubViewpointTypeId;
objComboBox.DisplayMember = conSubViewpointType.SubViewpointTypeName;
objComboBox.DataSource = arrObjLst;
objComboBox.SelectedIndex = 0;
}

 /// <summary>
 /// 绑定基于Web的下拉框
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_TabFeature_DdlBindFunction)
 /// </summary>
 /// <param name = "objDDL">需要绑定当前表的下拉框</param>

public static void BindDdl_SubViewpointTypeId(System.Web.UI.WebControls.DropDownList objDDL )
{
//为数据源于表的下拉框设置内容
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[子观点类型表]...","0");
string strCondition = string.Format("1 =1 Order By {0}", conSubViewpointType.SubViewpointTypeId); 
IEnumerable<clsSubViewpointTypeEN> arrObjLst = clsSubViewpointTypeBL.GetObjLst(strCondition);
objDDL.DataValueField = conSubViewpointType.SubViewpointTypeId;
objDDL.DataTextField = conSubViewpointType.SubViewpointTypeName;
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
public static void BindDdl_SubViewpointTypeIdCache(System.Web.UI.WebControls.DropDownList objDDL)
{
//为数据源于表的下拉框设置内容
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[子观点类型表]...","0");
List<clsSubViewpointTypeEN> arrSubViewpointTypeObjLst = GetAllSubViewpointTypeObjLstCache(); 
arrSubViewpointTypeObjLst = arrSubViewpointTypeObjLst.OrderBy(x=>x.OrderNum).ToList(); 
objDDL.DataValueField = conSubViewpointType.SubViewpointTypeId;
objDDL.DataTextField = conSubViewpointType.SubViewpointTypeName;
objDDL.DataSource = arrSubViewpointTypeObjLst;
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
if (clsSubViewpointTypeBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsSubViewpointTypeBL没有刷新缓存机制(clsSubViewpointTypeBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by SubViewpointTypeId");
//if (arrSubViewpointTypeObjLstCache == null)
//{
//arrSubViewpointTypeObjLstCache = SubViewpointTypeDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "strSubViewpointTypeId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsSubViewpointTypeEN GetObjBySubViewpointTypeIdCache(string strSubViewpointTypeId)
{
//获取缓存中的对象列表
string strKey = string.Format("{0}", clsSubViewpointTypeEN._CurrTabName);
List<clsSubViewpointTypeEN> arrSubViewpointTypeObjLstCache = GetObjLstCache();
IEnumerable <clsSubViewpointTypeEN> arrSubViewpointTypeObjLst_Sel =
arrSubViewpointTypeObjLstCache
.Where(x=> x.SubViewpointTypeId == strSubViewpointTypeId 
);
if (arrSubViewpointTypeObjLst_Sel.Count() == 0)
{
   clsSubViewpointTypeEN obj = clsSubViewpointTypeBL.GetObjBySubViewpointTypeId(strSubViewpointTypeId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
 }
return null;
}
return arrSubViewpointTypeObjLst_Sel.First();
}

 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecNameByKeyCache)
 /// </summary>
 /// <param name = "strSubViewpointTypeId">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetSubViewpointTypeNameBySubViewpointTypeIdCache(string strSubViewpointTypeId)
{
if (string.IsNullOrEmpty(strSubViewpointTypeId) == true) return "";
//获取缓存中的对象列表
clsSubViewpointTypeEN objSubViewpointType = GetObjBySubViewpointTypeIdCache(strSubViewpointTypeId);
if (objSubViewpointType == null) return "";
return objSubViewpointType.SubViewpointTypeName;
}
 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecNameByKeyCache)
 /// </summary>
 /// <param name = "strSubViewpointTypeId">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetNameBySubViewpointTypeIdCache(string strSubViewpointTypeId)
{
if (string.IsNullOrEmpty(strSubViewpointTypeId) == true) return "";
//获取缓存中的对象列表
clsSubViewpointTypeEN objSubViewpointType = GetObjBySubViewpointTypeIdCache(strSubViewpointTypeId);
if (objSubViewpointType == null) return "";
return objSubViewpointType.SubViewpointTypeName;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsSubViewpointTypeEN> GetAllSubViewpointTypeObjLstCache()
{
//获取缓存中的对象列表
List<clsSubViewpointTypeEN> arrSubViewpointTypeObjLstCache = GetObjLstCache(); 
return arrSubViewpointTypeObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsSubViewpointTypeEN> GetObjLstCache()
{
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}", clsSubViewpointTypeEN._CurrTabName);
List<clsSubViewpointTypeEN> arrSubViewpointTypeObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrSubViewpointTypeObjLstCache;
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
string strKey = string.Format("{0}", clsSubViewpointTypeEN._CurrTabName);
CacheHelper.Remove(strKey);
clsSubViewpointTypeEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
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
if (clsSubViewpointTypeEN._RefreshTimeLst.Count == 0) return "";
return clsSubViewpointTypeEN._RefreshTimeLst[clsSubViewpointTypeEN._RefreshTimeLst.Count - 1];
}

 /// <summary>
 /// 刷新缓存.把当前表的缓存以及该表相关视图的缓存清空.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ReFreshCache)
 /// </summary>
public static void ReFreshCache()
{
if (clsSubViewpointTypeBL.objCommFun4BL != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}", clsSubViewpointTypeEN._CurrTabName);
CacheHelper.Remove(strKey);
clsSubViewpointTypeEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
clsSubViewpointTypeBL.objCommFun4BL.ReFreshCache();
}
}


 #endregion 缓存操作


 #region 检查唯一性

 /// <summary>
 /// 获取检查唯一性条件串(Uniqueness)--SubViewpointType(子观点类型表)
 /// 唯一性条件:SubViewpointTypeName
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetUniquenessConditionString)
 /// </summary>
 /// <param name = "objSubViewpointTypeEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(clsSubViewpointTypeEN objSubViewpointTypeEN)
{
//检测记录是否存在
string strResult = SubViewpointTypeDA.GetUniCondStr(objSubViewpointTypeEN);
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
public static string Func(string strInFldName, string strOutFldName, string strSubViewpointTypeId)
{
if (strInFldName != conSubViewpointType.SubViewpointTypeId)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (conSubViewpointType.AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", conSubViewpointType.AttributeName));
throw new Exception(strMsg);
}
var objSubViewpointType = clsSubViewpointTypeBL.GetObjBySubViewpointTypeIdCache(strSubViewpointTypeId);
if (objSubViewpointType == null) return "";
return objSubViewpointType[strOutFldName].ToString();
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
int intRecCount = clsSubViewpointTypeDA.GetRecCount(strTabName);
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
int intRecCount = clsSubViewpointTypeDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsSubViewpointTypeDA.GetRecCount();
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
int intRecCount = clsSubViewpointTypeDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objSubViewpointTypeCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsSubViewpointTypeEN objSubViewpointTypeCond)
{
List<clsSubViewpointTypeEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsSubViewpointTypeEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conSubViewpointType.AttributeName)
{
if (objSubViewpointTypeCond.IsUpdated(strFldName) == false) continue;
if (objSubViewpointTypeCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objSubViewpointTypeCond[strFldName].ToString());
}
else
{
if (objSubViewpointTypeCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objSubViewpointTypeCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objSubViewpointTypeCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objSubViewpointTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objSubViewpointTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objSubViewpointTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objSubViewpointTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objSubViewpointTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objSubViewpointTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objSubViewpointTypeCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objSubViewpointTypeCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objSubViewpointTypeCond[strFldName]));
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
 List<string> arrList = clsSubViewpointTypeDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = SubViewpointTypeDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = SubViewpointTypeDA.GetFldValueNoDistinct(strFldName, strWhereCond);
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
int intRecCount = SubViewpointTypeDA.SetFldValue(strFldName, strValue, strWhereCond);
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
int intRecCount = clsSubViewpointTypeDA.SetFldValue(clsSubViewpointTypeEN._CurrTabName, strFldName, fltValue, strWhereCond);
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
int intRecCount = SubViewpointTypeDA.SetFldValue( strFldName, intValue, strWhereCond);
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
int intRecCount = clsSubViewpointTypeDA.SetFldValue(strTabName, strFldName, strValue, strWhereCond);
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
int intRecCount = clsSubViewpointTypeDA.SetFldValue(strTabName, strFldName, intValue, strWhereCond);
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
int intRecCount = clsSubViewpointTypeDA.SetFldValue(strTabName, strFldName, fltValue, strWhereCond);
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
  strCreateTabCode.Append("CREATE table [dbo].[SubViewpointType] "); 
 strCreateTabCode.Append(" ( "); 
 // /**类型Id*/ 
 strCreateTabCode.Append(" SubViewpointTypeId char(8) primary key, "); 
 // /**类型名称*/ 
 strCreateTabCode.Append(" SubViewpointTypeName varchar(50) Null, "); 
 // /**类型英文名*/ 
 strCreateTabCode.Append(" SubViewpointTypeENName varchar(100) Null, "); 
 // /**默认标题*/ 
 strCreateTabCode.Append(" DefaTitle varchar(20) Null, "); 
 // /**序号*/ 
 strCreateTabCode.Append(" OrderNum int Null, "); 
 // /**修改日期*/ 
 strCreateTabCode.Append(" UpdDate varchar(20) Null, "); 
 // /**修改用户Id*/ 
 strCreateTabCode.Append(" UpdUserId varchar(20) Null, "); 
 // /**备注*/ 
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
string strCondition = string.Format("1 = 1 order by {0} ", conSubViewpointType.OrderNum); 
List<clsSubViewpointTypeEN> arrSubViewpointTypeObjList = new clsSubViewpointTypeDA().GetObjLst(strCondition);
    
int intIndex = 1;
foreach (clsSubViewpointTypeEN objSubViewpointType in arrSubViewpointTypeObjList)
{
objSubViewpointType.OrderNum = intIndex;
UpdateBySql2(objSubViewpointType);
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
/// <param name="strSubViewpointTypeId">所给的关键字</param>
/// <returns>是否成绩</returns>
public static bool AdjustOrderNum(string strDirect, string strSubViewpointTypeId)
{
try
{
//操作步骤：
//1、根据所给定的关键字[SubViewpointTypeId],获取相应的序号[OrderNum]；
//2、如果当前序号是否是末端序号；
//3、如果是末端序号,就退出；
//   3.1、如果是向下移动,判断当前序号是否“小于”当前表中的字段数,
//	   即不是最后一个记录,就准备把当前字段项的序号加1,而下一字段的序号减1,
//   3.2、如果是向上移动,就判断当前序号是否“大于”1,
//	   即不是第一条记录,就准备把当前字段项的序号减1,而上一字段的序号加1。
//4、获取下(上)一个序号记录的关键字SubViewpointTypeId
//5、把当前关键字SubViewpointTypeId所对应记录的序号加(减)1
//6、把下(上)一个序号关键字SubViewpointTypeId所对应的记录序号减(加)1
string strMsg;
int intOrderNum;    //当前记录的序号
int intPrevOrderNum, intNextOrderNum;   //上下两条记录的序号
string strPrevSubViewpointTypeId = "";    //上一条序号的关键字SubViewpointTypeId
string strNextSubViewpointTypeId = "";    //下一条序号的关键字SubViewpointTypeId
int intTabRecNum;       //当前表中字段的记录数
StringBuilder strCondition = new StringBuilder();
//1、根据所给定的关键字[SubViewpointTypeId],获取相应的序号[OrderNum]。

clsSubViewpointTypeEN objSubViewpointType = clsSubViewpointTypeBL.GetObjBySubViewpointTypeId(strSubViewpointTypeId);

intOrderNum = objSubViewpointType.OrderNum ?? 0;//当前序号
intPrevOrderNum = intOrderNum - 1;//前一条记录的序号
intNextOrderNum = intOrderNum + 1;//后一条记录的序号
//3、如果当前序号是否是末端序号,
//		3.1 如果是末端序号,就退出,

intTabRecNum = clsSubViewpointTypeBL.GetRecCountByCond(clsSubViewpointTypeEN._CurrTabName, "1 = 1");    //获取当前表的记录数
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
strCondition.AppendFormat(" {0} = {1}", conSubViewpointType.OrderNum, intOrderNum - 1);
//4、获取上一个序号字段的关键字SubViewpointTypeId
strPrevSubViewpointTypeId = clsSubViewpointTypeBL.GetFirstID_S(strCondition.ToString());
if (string.IsNullOrEmpty(strPrevSubViewpointTypeId) == true)
{
strMsg = string.Format("获取上一条记录的关键字出错.(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//5、把当前关键字SubViewpointTypeId所对应记录的序号减1
//6、把下(上)一个序号关键字SubViewpointTypeId所对应的记录序号加1
clsSubViewpointTypeBL.SetFldValue(clsSubViewpointTypeEN._CurrTabName, conSubViewpointType.OrderNum,
intOrderNum - 1,
string.Format("{0} = '{1}'", conSubViewpointType.SubViewpointTypeId, strSubViewpointTypeId));
clsSubViewpointTypeBL.SetFldValue(clsSubViewpointTypeEN._CurrTabName, conSubViewpointType.OrderNum,
intPrevOrderNum + 1,
string.Format("{0} = '{1}'", conSubViewpointType.SubViewpointTypeId, strPrevSubViewpointTypeId));
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

//4、获取下一个序号字段的关键字SubViewpointTypeId
strCondition.AppendFormat(" {0} = {1}", conSubViewpointType.OrderNum, intOrderNum + 1);

strNextSubViewpointTypeId = clsSubViewpointTypeBL.GetFirstID_S(strCondition.ToString());
if (string.IsNullOrEmpty(strNextSubViewpointTypeId) == true)
{
strMsg = string.Format("获取下一条记录的关键字出错.(from {0})", clsStackTrace.GetCurrClassFunction());

throw new Exception(strMsg);
}
//5、把当前关键字SubViewpointTypeId所对应记录的序号加1
//6、把下(上)一个序号关键字SubViewpointTypeId所对应的记录序号减1
clsSubViewpointTypeBL.SetFldValue(clsSubViewpointTypeEN._CurrTabName, conSubViewpointType.OrderNum,
intOrderNum + 1,
string.Format("{0} = '{1}'", conSubViewpointType.SubViewpointTypeId, strSubViewpointTypeId));
clsSubViewpointTypeBL.SetFldValue(clsSubViewpointTypeEN._CurrTabName, conSubViewpointType.OrderNum,
 	 	intNextOrderNum - 1,
 	 	string.Format("{0} = '{1}'", conSubViewpointType.SubViewpointTypeId, strNextSubViewpointTypeId));
break;
default:
strMsg = string.Format("方向参数出错!strDirect=[{0}]({1})",
strDirect,
clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
clsSubViewpointTypeBL.ReFreshCache();
if (clsSubViewpointTypeBL.relatedActions != null)
{
clsSubViewpointTypeBL.relatedActions.UpdRelaTabDate(objSubViewpointType.SubViewpointTypeId, "UpdRelaTabDate");
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
public static bool GoBottom(List<string> arrKeyId)
{
try
{
if (arrKeyId.Count == 0) return true;
string strKeyList = clsArray.GetSqlInStrByArray(arrKeyId, true);
string strCondition = string.Format("{0} in ({1})", conSubViewpointType.SubViewpointTypeId, strKeyList);
List<clsSubViewpointTypeEN> arrSubViewpointTypeLst = GetObjLst(strCondition);
foreach (clsSubViewpointTypeEN objSubViewpointType in arrSubViewpointTypeLst)
{
objSubViewpointType.OrderNum = objSubViewpointType.OrderNum + 10000;
UpdateBySql2(objSubViewpointType);
}
strCondition = string.Format("1 = 1 order by {0} ", conSubViewpointType.OrderNum); 
List<clsSubViewpointTypeEN> arrSubViewpointTypeObjList = new clsSubViewpointTypeDA().GetObjLst(strCondition);
    
int intIndex = 1;
foreach (clsSubViewpointTypeEN objSubViewpointType in arrSubViewpointTypeObjList)
{
objSubViewpointType.OrderNum = intIndex;
UpdateBySql2(objSubViewpointType);
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
public static bool GoTop(List<string> arrKeyId)
{
try
{
if (arrKeyId.Count == 0) return true;
string strKeyList = clsArray.GetSqlInStrByArray(arrKeyId, true);
string strCondition = string.Format("{0} in ({1})", conSubViewpointType.SubViewpointTypeId, strKeyList);
List<clsSubViewpointTypeEN> arrSubViewpointTypeLst = GetObjLst(strCondition);
foreach (clsSubViewpointTypeEN objSubViewpointType in arrSubViewpointTypeLst)
{
objSubViewpointType.OrderNum = objSubViewpointType.OrderNum - 10000;
UpdateBySql2(objSubViewpointType);
}
strCondition = string.Format("1 = 1 order by {0} ", conSubViewpointType.OrderNum); 
List<clsSubViewpointTypeEN> arrSubViewpointTypeObjList = new clsSubViewpointTypeDA().GetObjLst(strCondition);
    
int intIndex = 1;
foreach (clsSubViewpointTypeEN objSubViewpointType in arrSubViewpointTypeObjList)
{
objSubViewpointType.OrderNum = intIndex;
UpdateBySql2(objSubViewpointType);
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
 /// 子观点类型表(SubViewpointType)
 /// 数据源类型:表
 /// (AutoGCLib.CommFun4BL4CSharp:GeneCode_This)
 /// </summary>
public class  clsCommFun4BL4SubViewpointType : clsCommFun4BL
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
clsSubViewpointTypeBL.ReFreshThisCache();
}
}

}