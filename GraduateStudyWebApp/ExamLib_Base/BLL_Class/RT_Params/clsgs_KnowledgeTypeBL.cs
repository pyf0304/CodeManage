
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsgs_KnowledgeTypeBL
 表名:gs_KnowledgeType(01120954)
 * 版本:2024.11.13.1(服务器:WIN-SRV103-116)
 日期:2024/11/13 06:06:01
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
public static class  clsgs_KnowledgeTypeBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "strgsKnowledgeTypeId">表关键字</param>
 /// <returns>表对象</returns>
public static clsgs_KnowledgeTypeEN GetObj(this K_gsKnowledgeTypeId_gs_KnowledgeType myKey)
{
clsgs_KnowledgeTypeEN objgs_KnowledgeTypeEN = clsgs_KnowledgeTypeBL.gs_KnowledgeTypeDA.GetObjBygsKnowledgeTypeId(myKey.Value);
return objgs_KnowledgeTypeEN;
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_AddNewRecord)
 /// </summary>
 /// <param name = "objgs_KnowledgeTypeEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clsgs_KnowledgeTypeEN objgs_KnowledgeTypeEN, bool bolIsNeedCheckUniqueness = true)
{
if (bolIsNeedCheckUniqueness == true && CheckUniqueness(objgs_KnowledgeTypeEN) == false)
{
var strMsg = string.Format("记录已经存在!知识类型名 = [{0}]的数据已经存在!(in clsgs_KnowledgeTypeBL.AddNewRecord)", objgs_KnowledgeTypeEN.gsKnowledgeTypeName);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objgs_KnowledgeTypeEN.gsKnowledgeTypeId) == true || clsgs_KnowledgeTypeBL.IsExist(objgs_KnowledgeTypeEN.gsKnowledgeTypeId) == true)
 {
     objgs_KnowledgeTypeEN.gsKnowledgeTypeId = clsgs_KnowledgeTypeBL.GetMaxStrId_S();
 }
bool bolResult = clsgs_KnowledgeTypeBL.gs_KnowledgeTypeDA.AddNewRecordBySQL2(objgs_KnowledgeTypeEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsgs_KnowledgeTypeBL.ReFreshCache();

if (clsgs_KnowledgeTypeBL.relatedActions != null)
{
clsgs_KnowledgeTypeBL.relatedActions.UpdRelaTabDate(objgs_KnowledgeTypeEN.gsKnowledgeTypeId, objgs_KnowledgeTypeEN.UpdUser);
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
public static bool AddRecordEx(this clsgs_KnowledgeTypeEN objgs_KnowledgeTypeEN, bool bolIsNeedCheckUniqueness = true)
{
//操作步骤:
//1、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在
//2、检查唯一性
//3、检查传进去的对象属性是否合法
//4、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
//1、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在

//因为是字符型自增主键,不需要检查主键是否已经存在,在添加时,再获取 最大值作为主键
//if (clsgs_KnowledgeTypeBL.IsExist(objgs_KnowledgeTypeEN.gsKnowledgeTypeId))	//判断是否有相同的关键字
//{
//strMsg = "(errid:Busi000151)关键字字段已有相同的值";
//throw new Exception(strMsg);
//}
try
{
 //2、检查传进去的对象属性是否合法
objgs_KnowledgeTypeEN.CheckPropertyNew();
 ///5.2、检查唯一性
if (bolIsNeedCheckUniqueness == true && objgs_KnowledgeTypeEN.CheckUniqueness() == false)
{
strMsg = string.Format("(知识类型名(gsKnowledgeTypeName)=[{0}])已经存在,不能重复!", objgs_KnowledgeTypeEN.gsKnowledgeTypeName);
throw new Exception(strMsg);
}
//因为是字符型自增主键,所以在添加时,自动获取主键值。
 if (string.IsNullOrEmpty(objgs_KnowledgeTypeEN.gsKnowledgeTypeId) == true || clsgs_KnowledgeTypeBL.IsExist(objgs_KnowledgeTypeEN.gsKnowledgeTypeId) == true)
 {
     objgs_KnowledgeTypeEN.gsKnowledgeTypeId = clsgs_KnowledgeTypeBL.GetMaxStrId_S();
 }
//6、把数据实体层的数据存贮到数据库中
objgs_KnowledgeTypeEN.AddNewRecord();
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
 /// <param name = "objgs_KnowledgeTypeEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static string AddNewRecordWithMaxId(this clsgs_KnowledgeTypeEN objgs_KnowledgeTypeEN, bool bolIsNeedCheckUniqueness = true)
{
if (bolIsNeedCheckUniqueness == true && CheckUniqueness(objgs_KnowledgeTypeEN) == false)
{
var strMsg = string.Format("记录已经存在!知识类型名 = [{0}]的数据已经存在!(in clsgs_KnowledgeTypeBL.AddNewRecordWithMaxId)", objgs_KnowledgeTypeEN.gsKnowledgeTypeName);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objgs_KnowledgeTypeEN.gsKnowledgeTypeId) == true || clsgs_KnowledgeTypeBL.IsExist(objgs_KnowledgeTypeEN.gsKnowledgeTypeId) == true)
 {
     objgs_KnowledgeTypeEN.gsKnowledgeTypeId = clsgs_KnowledgeTypeBL.GetMaxStrId_S();
 }
string strgsKnowledgeTypeId = clsgs_KnowledgeTypeBL.gs_KnowledgeTypeDA.AddNewRecordBySQL2WithReturnKey(objgs_KnowledgeTypeEN);
     objgs_KnowledgeTypeEN.gsKnowledgeTypeId = strgsKnowledgeTypeId;
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsgs_KnowledgeTypeBL.ReFreshCache();

if (clsgs_KnowledgeTypeBL.relatedActions != null)
{
clsgs_KnowledgeTypeBL.relatedActions.UpdRelaTabDate(objgs_KnowledgeTypeEN.gsKnowledgeTypeId, objgs_KnowledgeTypeEN.UpdUser);
}
return strgsKnowledgeTypeId;
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
 /// <param name = "objgs_KnowledgeTypeEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordWithReturnKey(this clsgs_KnowledgeTypeEN objgs_KnowledgeTypeEN, bool bolIsNeedCheckUniqueness = true)
{
if (bolIsNeedCheckUniqueness == true && CheckUniqueness(objgs_KnowledgeTypeEN) == false)
{
var strMsg = string.Format("记录已经存在!知识类型名 = [{0}]的数据已经存在!(in clsgs_KnowledgeTypeBL.AddNewRecordWithReturnKey)", objgs_KnowledgeTypeEN.gsKnowledgeTypeName);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objgs_KnowledgeTypeEN.gsKnowledgeTypeId) == true || clsgs_KnowledgeTypeBL.IsExist(objgs_KnowledgeTypeEN.gsKnowledgeTypeId) == true)
 {
     objgs_KnowledgeTypeEN.gsKnowledgeTypeId = clsgs_KnowledgeTypeBL.GetMaxStrId_S();
 }
string strKey = clsgs_KnowledgeTypeBL.gs_KnowledgeTypeDA.AddNewRecordBySQL2WithReturnKey(objgs_KnowledgeTypeEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsgs_KnowledgeTypeBL.ReFreshCache();

if (clsgs_KnowledgeTypeBL.relatedActions != null)
{
clsgs_KnowledgeTypeBL.relatedActions.UpdRelaTabDate(objgs_KnowledgeTypeEN.gsKnowledgeTypeId, objgs_KnowledgeTypeEN.UpdUser);
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
 /// <param name = "objgs_KnowledgeTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsgs_KnowledgeTypeEN SetgsKnowledgeTypeId(this clsgs_KnowledgeTypeEN objgs_KnowledgeTypeEN, string strgsKnowledgeTypeId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strgsKnowledgeTypeId, 2, congs_KnowledgeType.gsKnowledgeTypeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strgsKnowledgeTypeId, 2, congs_KnowledgeType.gsKnowledgeTypeId);
}
objgs_KnowledgeTypeEN.gsKnowledgeTypeId = strgsKnowledgeTypeId; //知识类型Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objgs_KnowledgeTypeEN.dicFldComparisonOp.ContainsKey(congs_KnowledgeType.gsKnowledgeTypeId) == false)
{
objgs_KnowledgeTypeEN.dicFldComparisonOp.Add(congs_KnowledgeType.gsKnowledgeTypeId, strComparisonOp);
}
else
{
objgs_KnowledgeTypeEN.dicFldComparisonOp[congs_KnowledgeType.gsKnowledgeTypeId] = strComparisonOp;
}
}
return objgs_KnowledgeTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objgs_KnowledgeTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsgs_KnowledgeTypeEN SetgsKnowledgeTypeName(this clsgs_KnowledgeTypeEN objgs_KnowledgeTypeEN, string strgsKnowledgeTypeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strgsKnowledgeTypeName, congs_KnowledgeType.gsKnowledgeTypeName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strgsKnowledgeTypeName, 50, congs_KnowledgeType.gsKnowledgeTypeName);
}
objgs_KnowledgeTypeEN.gsKnowledgeTypeName = strgsKnowledgeTypeName; //知识类型名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objgs_KnowledgeTypeEN.dicFldComparisonOp.ContainsKey(congs_KnowledgeType.gsKnowledgeTypeName) == false)
{
objgs_KnowledgeTypeEN.dicFldComparisonOp.Add(congs_KnowledgeType.gsKnowledgeTypeName, strComparisonOp);
}
else
{
objgs_KnowledgeTypeEN.dicFldComparisonOp[congs_KnowledgeType.gsKnowledgeTypeName] = strComparisonOp;
}
}
return objgs_KnowledgeTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objgs_KnowledgeTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsgs_KnowledgeTypeEN SetKnowledgeTypeENName(this clsgs_KnowledgeTypeEN objgs_KnowledgeTypeEN, string strKnowledgeTypeENName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strKnowledgeTypeENName, congs_KnowledgeType.KnowledgeTypeENName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strKnowledgeTypeENName, 50, congs_KnowledgeType.KnowledgeTypeENName);
}
objgs_KnowledgeTypeEN.KnowledgeTypeENName = strKnowledgeTypeENName; //知识类型英文名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objgs_KnowledgeTypeEN.dicFldComparisonOp.ContainsKey(congs_KnowledgeType.KnowledgeTypeENName) == false)
{
objgs_KnowledgeTypeEN.dicFldComparisonOp.Add(congs_KnowledgeType.KnowledgeTypeENName, strComparisonOp);
}
else
{
objgs_KnowledgeTypeEN.dicFldComparisonOp[congs_KnowledgeType.KnowledgeTypeENName] = strComparisonOp;
}
}
return objgs_KnowledgeTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objgs_KnowledgeTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsgs_KnowledgeTypeEN SetOrderNum(this clsgs_KnowledgeTypeEN objgs_KnowledgeTypeEN, int? intOrderNum, string strComparisonOp="")
	{
objgs_KnowledgeTypeEN.OrderNum = intOrderNum; //序号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objgs_KnowledgeTypeEN.dicFldComparisonOp.ContainsKey(congs_KnowledgeType.OrderNum) == false)
{
objgs_KnowledgeTypeEN.dicFldComparisonOp.Add(congs_KnowledgeType.OrderNum, strComparisonOp);
}
else
{
objgs_KnowledgeTypeEN.dicFldComparisonOp[congs_KnowledgeType.OrderNum] = strComparisonOp;
}
}
return objgs_KnowledgeTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objgs_KnowledgeTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsgs_KnowledgeTypeEN SetUpdDate(this clsgs_KnowledgeTypeEN objgs_KnowledgeTypeEN, string strUpdDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdDate, 20, congs_KnowledgeType.UpdDate);
}
objgs_KnowledgeTypeEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objgs_KnowledgeTypeEN.dicFldComparisonOp.ContainsKey(congs_KnowledgeType.UpdDate) == false)
{
objgs_KnowledgeTypeEN.dicFldComparisonOp.Add(congs_KnowledgeType.UpdDate, strComparisonOp);
}
else
{
objgs_KnowledgeTypeEN.dicFldComparisonOp[congs_KnowledgeType.UpdDate] = strComparisonOp;
}
}
return objgs_KnowledgeTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objgs_KnowledgeTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsgs_KnowledgeTypeEN SetUpdUser(this clsgs_KnowledgeTypeEN objgs_KnowledgeTypeEN, string strUpdUser, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdUser, 20, congs_KnowledgeType.UpdUser);
}
objgs_KnowledgeTypeEN.UpdUser = strUpdUser; //修改人
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objgs_KnowledgeTypeEN.dicFldComparisonOp.ContainsKey(congs_KnowledgeType.UpdUser) == false)
{
objgs_KnowledgeTypeEN.dicFldComparisonOp.Add(congs_KnowledgeType.UpdUser, strComparisonOp);
}
else
{
objgs_KnowledgeTypeEN.dicFldComparisonOp[congs_KnowledgeType.UpdUser] = strComparisonOp;
}
}
return objgs_KnowledgeTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objgs_KnowledgeTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsgs_KnowledgeTypeEN SetMemo(this clsgs_KnowledgeTypeEN objgs_KnowledgeTypeEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, congs_KnowledgeType.Memo);
}
objgs_KnowledgeTypeEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objgs_KnowledgeTypeEN.dicFldComparisonOp.ContainsKey(congs_KnowledgeType.Memo) == false)
{
objgs_KnowledgeTypeEN.dicFldComparisonOp.Add(congs_KnowledgeType.Memo, strComparisonOp);
}
else
{
objgs_KnowledgeTypeEN.dicFldComparisonOp[congs_KnowledgeType.Memo] = strComparisonOp;
}
}
return objgs_KnowledgeTypeEN;
	}

 /// <summary>
 /// 修改记录存盘到数据表中
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_UpdateRecordEx)
 /// </summary>
 /// <param name = "objgs_KnowledgeTypeEN">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool UpdateRecordEx(this clsgs_KnowledgeTypeEN objgs_KnowledgeTypeEN)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
try
{
//1、检查传进去的对象属性是否合法
objgs_KnowledgeTypeEN.CheckPropertyNew();
clsgs_KnowledgeTypeEN objgs_KnowledgeTypeCond = new clsgs_KnowledgeTypeEN();
string strCondition = objgs_KnowledgeTypeCond
.SetgsKnowledgeTypeId(objgs_KnowledgeTypeEN.gsKnowledgeTypeId, "<>")
.SetgsKnowledgeTypeName(objgs_KnowledgeTypeEN.gsKnowledgeTypeName, "=")
.GetCombineCondition();
objgs_KnowledgeTypeEN._IsCheckProperty = true;
bool bolIsExist = clsgs_KnowledgeTypeBL.IsExistRecord(strCondition);
if (bolIsExist)
{
strMsg = "(gsKnowledgeTypeName)不能重复!";
throw new Exception(strMsg);
}
//4、把数据实体层的数据存贮到数据库中
objgs_KnowledgeTypeEN.Update();
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
 /// <param name = "objgs_KnowledgeType">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool EditRecordEx(this clsgs_KnowledgeTypeEN objgs_KnowledgeType)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
clsgs_KnowledgeTypeEN objgs_KnowledgeTypeCond = new clsgs_KnowledgeTypeEN();
string strCondition = objgs_KnowledgeTypeCond
.SetgsKnowledgeTypeName(objgs_KnowledgeType.gsKnowledgeTypeName, "=")
.GetCombineCondition();
objgs_KnowledgeType._IsCheckProperty = true;
bool bolIsExist = clsgs_KnowledgeTypeBL.IsExistRecord(strCondition);
if (bolIsExist)
{
objgs_KnowledgeType.gsKnowledgeTypeId = clsgs_KnowledgeTypeBL.GetFirstID_S(strCondition);
objgs_KnowledgeType.UpdateWithCondition(strCondition);
}
else
{
objgs_KnowledgeType.gsKnowledgeTypeId = clsgs_KnowledgeTypeBL.GetMaxStrId_S();
objgs_KnowledgeType.AddNewRecord();
}
return true; 
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_Update)
 /// </summary>
 /// <param name = "objgs_KnowledgeTypeEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsgs_KnowledgeTypeEN objgs_KnowledgeTypeEN)
{
 if (string.IsNullOrEmpty(objgs_KnowledgeTypeEN.gsKnowledgeTypeId) == true)
 {
string strMsg = string.Format("(errid:Busi000095)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsgs_KnowledgeTypeBL.gs_KnowledgeTypeDA.UpdateBySql2(objgs_KnowledgeTypeEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsgs_KnowledgeTypeBL.ReFreshCache();

if (clsgs_KnowledgeTypeBL.relatedActions != null)
{
clsgs_KnowledgeTypeBL.relatedActions.UpdRelaTabDate(objgs_KnowledgeTypeEN.gsKnowledgeTypeId, objgs_KnowledgeTypeEN.UpdUser);
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
 /// <param name = "objgs_KnowledgeTypeEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsgs_KnowledgeTypeEN objgs_KnowledgeTypeEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (string.IsNullOrEmpty(objgs_KnowledgeTypeEN.gsKnowledgeTypeId) == true)
 {
string strMsg = string.Format("(errid:Busi000087)修改记录时关键字不能为空!(带事务处理)(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsgs_KnowledgeTypeBL.gs_KnowledgeTypeDA.UpdateBySql2(objgs_KnowledgeTypeEN, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsgs_KnowledgeTypeBL.ReFreshCache();

if (clsgs_KnowledgeTypeBL.relatedActions != null)
{
clsgs_KnowledgeTypeBL.relatedActions.UpdRelaTabDate(objgs_KnowledgeTypeEN.gsKnowledgeTypeId, objgs_KnowledgeTypeEN.UpdUser);
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
 /// <param name = "objgs_KnowledgeTypeEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsgs_KnowledgeTypeEN objgs_KnowledgeTypeEN, string strWhereCond)
{
try
{
bool bolResult = clsgs_KnowledgeTypeBL.gs_KnowledgeTypeDA.UpdateBySqlWithCondition(objgs_KnowledgeTypeEN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsgs_KnowledgeTypeBL.ReFreshCache();

if (clsgs_KnowledgeTypeBL.relatedActions != null)
{
clsgs_KnowledgeTypeBL.relatedActions.UpdRelaTabDate(objgs_KnowledgeTypeEN.gsKnowledgeTypeId, objgs_KnowledgeTypeEN.UpdUser);
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
 /// <param name = "objgs_KnowledgeTypeEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsgs_KnowledgeTypeEN objgs_KnowledgeTypeEN, string strWhereCond, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
bool bolResult = clsgs_KnowledgeTypeBL.gs_KnowledgeTypeDA.UpdateBySqlWithConditionTransaction(objgs_KnowledgeTypeEN, strWhereCond, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsgs_KnowledgeTypeBL.ReFreshCache();

if (clsgs_KnowledgeTypeBL.relatedActions != null)
{
clsgs_KnowledgeTypeBL.relatedActions.UpdRelaTabDate(objgs_KnowledgeTypeEN.gsKnowledgeTypeId, objgs_KnowledgeTypeEN.UpdUser);
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
 /// <param name = "strgsKnowledgeTypeId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int Delete(this clsgs_KnowledgeTypeEN objgs_KnowledgeTypeEN)
{
try
{
int intRecNum = clsgs_KnowledgeTypeBL.gs_KnowledgeTypeDA.DelRecord(objgs_KnowledgeTypeEN.gsKnowledgeTypeId);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsgs_KnowledgeTypeBL.ReFreshCache();

if (clsgs_KnowledgeTypeBL.relatedActions != null)
{
clsgs_KnowledgeTypeBL.relatedActions.UpdRelaTabDate(objgs_KnowledgeTypeEN.gsKnowledgeTypeId, objgs_KnowledgeTypeEN.UpdUser);
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
 /// <param name = "objgs_KnowledgeTypeENS">源对象</param>
 /// <param name = "objgs_KnowledgeTypeENT">目标对象</param>
 public static void CopyTo(this clsgs_KnowledgeTypeEN objgs_KnowledgeTypeENS, clsgs_KnowledgeTypeEN objgs_KnowledgeTypeENT)
{
try
{
objgs_KnowledgeTypeENT.gsKnowledgeTypeId = objgs_KnowledgeTypeENS.gsKnowledgeTypeId; //知识类型Id
objgs_KnowledgeTypeENT.gsKnowledgeTypeName = objgs_KnowledgeTypeENS.gsKnowledgeTypeName; //知识类型名
objgs_KnowledgeTypeENT.KnowledgeTypeENName = objgs_KnowledgeTypeENS.KnowledgeTypeENName; //知识类型英文名
objgs_KnowledgeTypeENT.OrderNum = objgs_KnowledgeTypeENS.OrderNum; //序号
objgs_KnowledgeTypeENT.UpdDate = objgs_KnowledgeTypeENS.UpdDate; //修改日期
objgs_KnowledgeTypeENT.UpdUser = objgs_KnowledgeTypeENS.UpdUser; //修改人
objgs_KnowledgeTypeENT.Memo = objgs_KnowledgeTypeENS.Memo; //备注
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
 /// <param name = "objgs_KnowledgeTypeENS">源对象</param>
 /// <returns>目标对象=>clsgs_KnowledgeTypeEN:objgs_KnowledgeTypeENT</returns>
 public static clsgs_KnowledgeTypeEN CopyTo(this clsgs_KnowledgeTypeEN objgs_KnowledgeTypeENS)
{
try
{
 clsgs_KnowledgeTypeEN objgs_KnowledgeTypeENT = new clsgs_KnowledgeTypeEN()
{
gsKnowledgeTypeId = objgs_KnowledgeTypeENS.gsKnowledgeTypeId, //知识类型Id
gsKnowledgeTypeName = objgs_KnowledgeTypeENS.gsKnowledgeTypeName, //知识类型名
KnowledgeTypeENName = objgs_KnowledgeTypeENS.KnowledgeTypeENName, //知识类型英文名
OrderNum = objgs_KnowledgeTypeENS.OrderNum, //序号
UpdDate = objgs_KnowledgeTypeENS.UpdDate, //修改日期
UpdUser = objgs_KnowledgeTypeENS.UpdUser, //修改人
Memo = objgs_KnowledgeTypeENS.Memo, //备注
};
 return objgs_KnowledgeTypeENT;
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
public static void CheckPropertyNew(this clsgs_KnowledgeTypeEN objgs_KnowledgeTypeEN)
{
 clsgs_KnowledgeTypeBL.gs_KnowledgeTypeDA.CheckPropertyNew(objgs_KnowledgeTypeEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(this clsgs_KnowledgeTypeEN objgs_KnowledgeTypeEN)
{
 clsgs_KnowledgeTypeBL.gs_KnowledgeTypeDA.CheckProperty4Condition(objgs_KnowledgeTypeEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsgs_KnowledgeTypeEN objgs_KnowledgeTypeCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objgs_KnowledgeTypeCond.IsUpdated(congs_KnowledgeType.gsKnowledgeTypeId) == true)
{
string strComparisonOpgsKnowledgeTypeId = objgs_KnowledgeTypeCond.dicFldComparisonOp[congs_KnowledgeType.gsKnowledgeTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", congs_KnowledgeType.gsKnowledgeTypeId, objgs_KnowledgeTypeCond.gsKnowledgeTypeId, strComparisonOpgsKnowledgeTypeId);
}
if (objgs_KnowledgeTypeCond.IsUpdated(congs_KnowledgeType.gsKnowledgeTypeName) == true)
{
string strComparisonOpgsKnowledgeTypeName = objgs_KnowledgeTypeCond.dicFldComparisonOp[congs_KnowledgeType.gsKnowledgeTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", congs_KnowledgeType.gsKnowledgeTypeName, objgs_KnowledgeTypeCond.gsKnowledgeTypeName, strComparisonOpgsKnowledgeTypeName);
}
if (objgs_KnowledgeTypeCond.IsUpdated(congs_KnowledgeType.KnowledgeTypeENName) == true)
{
string strComparisonOpKnowledgeTypeENName = objgs_KnowledgeTypeCond.dicFldComparisonOp[congs_KnowledgeType.KnowledgeTypeENName];
strWhereCond += string.Format(" And {0} {2} '{1}'", congs_KnowledgeType.KnowledgeTypeENName, objgs_KnowledgeTypeCond.KnowledgeTypeENName, strComparisonOpKnowledgeTypeENName);
}
if (objgs_KnowledgeTypeCond.IsUpdated(congs_KnowledgeType.OrderNum) == true)
{
string strComparisonOpOrderNum = objgs_KnowledgeTypeCond.dicFldComparisonOp[congs_KnowledgeType.OrderNum];
strWhereCond += string.Format(" And {0} {2} {1}", congs_KnowledgeType.OrderNum, objgs_KnowledgeTypeCond.OrderNum, strComparisonOpOrderNum);
}
if (objgs_KnowledgeTypeCond.IsUpdated(congs_KnowledgeType.UpdDate) == true)
{
string strComparisonOpUpdDate = objgs_KnowledgeTypeCond.dicFldComparisonOp[congs_KnowledgeType.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", congs_KnowledgeType.UpdDate, objgs_KnowledgeTypeCond.UpdDate, strComparisonOpUpdDate);
}
if (objgs_KnowledgeTypeCond.IsUpdated(congs_KnowledgeType.UpdUser) == true)
{
string strComparisonOpUpdUser = objgs_KnowledgeTypeCond.dicFldComparisonOp[congs_KnowledgeType.UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", congs_KnowledgeType.UpdUser, objgs_KnowledgeTypeCond.UpdUser, strComparisonOpUpdUser);
}
if (objgs_KnowledgeTypeCond.IsUpdated(congs_KnowledgeType.Memo) == true)
{
string strComparisonOpMemo = objgs_KnowledgeTypeCond.dicFldComparisonOp[congs_KnowledgeType.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", congs_KnowledgeType.Memo, objgs_KnowledgeTypeCond.Memo, strComparisonOpMemo);
}
 return strWhereCond;
}

 /// <summary>
 /// 检查唯一性(Uniqueness)--gs_KnowledgeType(知识类型), 如果不唯一,即存在相同的记录,就返回False
 /// 唯一性条件:gsKnowledgeTypeName
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckConstraint)
 /// </summary>
 /// <param name = "objgs_KnowledgeTypeEN">要求唯一的对象</param>
 /// <returns></returns>
public static bool CheckUniqueness(this clsgs_KnowledgeTypeEN objgs_KnowledgeTypeEN)
{
//检测记录是否存在
bool bolIsUniqueness;
StringBuilder sbCondition = new StringBuilder();
if (objgs_KnowledgeTypeEN == null) return true;
if (objgs_KnowledgeTypeEN.gsKnowledgeTypeId == null || objgs_KnowledgeTypeEN.gsKnowledgeTypeId == "")
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and gsKnowledgeTypeName = '{0}'", objgs_KnowledgeTypeEN.gsKnowledgeTypeName);
if (clsgs_KnowledgeTypeBL.IsExistRecord(sbCondition.ToString())  ==  true)
{
 bolIsUniqueness = false;
}
else
{
 bolIsUniqueness = true;
}
}
 else {
sbCondition.AppendFormat("gsKnowledgeTypeId !=  '{0}'", objgs_KnowledgeTypeEN.gsKnowledgeTypeId);
 sbCondition.AppendFormat(" and gsKnowledgeTypeName = '{0}'", objgs_KnowledgeTypeEN.gsKnowledgeTypeName);
if (clsgs_KnowledgeTypeBL.IsExistRecord(sbCondition.ToString())  ==  true)
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
 /// 获取唯一性条件串--gs_KnowledgeType(知识类型), 即由对象中唯一性条件字段关键字与值组成的条件串
 /// 唯一性条件:gsKnowledgeTypeName
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetConditionString4Constraint)
 /// </summary>
 /// <param name = "objgs_KnowledgeTypeEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(this clsgs_KnowledgeTypeEN objgs_KnowledgeTypeEN)
{
//检测记录是否存在
StringBuilder sbCondition = new StringBuilder();
if (objgs_KnowledgeTypeEN == null) return "";
if (objgs_KnowledgeTypeEN.gsKnowledgeTypeId == null || objgs_KnowledgeTypeEN.gsKnowledgeTypeId == "")
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and gsKnowledgeTypeName = '{0}'", objgs_KnowledgeTypeEN.gsKnowledgeTypeName);
return sbCondition.ToString();
}
 else {
sbCondition.AppendFormat("gsKnowledgeTypeId !=  '{0}'", objgs_KnowledgeTypeEN.gsKnowledgeTypeId);
 sbCondition.AppendFormat(" and gsKnowledgeTypeName = '{0}'", objgs_KnowledgeTypeEN.gsKnowledgeTypeName);
 return sbCondition.ToString();
}
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_gs_KnowledgeType
{
public virtual bool UpdRelaTabDate(string strgsKnowledgeTypeId, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// 根据表内容设置enum列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GeneEnumConstList)
 /// </summary>
public class enumgs_KnowledgeType
{
 /// <summary>
 /// 未知
 /// </summary>
public const string Unknown_00 = "00";
 /// <summary>
 /// 个人观点
 /// </summary>
public const string PersonalOpinion_01 = "01";
 /// <summary>
 /// 专家观点
 /// </summary>
public const string ExpertOpinion_02 = "02";
 /// <summary>
 /// 概念
 /// </summary>
public const string Concept_03 = "03";
 /// <summary>
 /// 客观事实
 /// </summary>
public const string ObjectiveFact_04 = "04";
 /// <summary>
 /// 客观数据
 /// </summary>
public const string ObjectiveData_05 = "05";
 /// <summary>
 /// 技能
 /// </summary>
public const string Skill_06 = "06";
 /// <summary>
 /// 社会关系
 /// </summary>
public const string SocialRelationships_07 = "07";
}
 /// <summary>
 /// 知识类型(gs_KnowledgeType)
 /// 数据源类型:表
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsgs_KnowledgeTypeBL
{
public static RelatedActions_gs_KnowledgeType relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsgs_KnowledgeTypeDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsgs_KnowledgeTypeDA gs_KnowledgeTypeDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsgs_KnowledgeTypeDA();
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
 public clsgs_KnowledgeTypeBL()
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
if (string.IsNullOrEmpty(clsgs_KnowledgeTypeEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsgs_KnowledgeTypeEN._ConnectString);
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
public static DataTable GetDataTable_gs_KnowledgeType(string strWhereCond)
{
DataTable objDT;
try
{
objDT = gs_KnowledgeTypeDA.GetDataTable_gs_KnowledgeType(strWhereCond);
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
objDT = gs_KnowledgeTypeDA.GetDataTable(strWhereCond);
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
objDT = gs_KnowledgeTypeDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = gs_KnowledgeTypeDA.GetDataTable(strWhereCond, strTabName);
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
objDT = gs_KnowledgeTypeDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = gs_KnowledgeTypeDA.GetDataTable_Top(objTopPara);
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
objDT = gs_KnowledgeTypeDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = gs_KnowledgeTypeDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = gs_KnowledgeTypeDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
 /// <param name = "arrGsKnowledgeTypeIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static List<clsgs_KnowledgeTypeEN> GetObjLstByGsKnowledgeTypeIdLst(List<string> arrGsKnowledgeTypeIdLst)
{
List<clsgs_KnowledgeTypeEN> arrObjLst = new List<clsgs_KnowledgeTypeEN>(); 
System.Data.DataTable objDT; 
 string strSqlConditionStr = clsArray.GetSqlInStrByArray(arrGsKnowledgeTypeIdLst, true);
 string strWhereCond = string.Format("gsKnowledgeTypeId in ({0})", strSqlConditionStr);
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsgs_KnowledgeTypeEN objgs_KnowledgeTypeEN = new clsgs_KnowledgeTypeEN();
try
{
objgs_KnowledgeTypeEN.gsKnowledgeTypeId = objRow[congs_KnowledgeType.gsKnowledgeTypeId].ToString().Trim(); //知识类型Id
objgs_KnowledgeTypeEN.gsKnowledgeTypeName = objRow[congs_KnowledgeType.gsKnowledgeTypeName].ToString().Trim(); //知识类型名
objgs_KnowledgeTypeEN.KnowledgeTypeENName = objRow[congs_KnowledgeType.KnowledgeTypeENName].ToString().Trim(); //知识类型英文名
objgs_KnowledgeTypeEN.OrderNum = objRow[congs_KnowledgeType.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[congs_KnowledgeType.OrderNum].ToString().Trim()); //序号
objgs_KnowledgeTypeEN.UpdDate = objRow[congs_KnowledgeType.UpdDate] == DBNull.Value ? null : objRow[congs_KnowledgeType.UpdDate].ToString().Trim(); //修改日期
objgs_KnowledgeTypeEN.UpdUser = objRow[congs_KnowledgeType.UpdUser] == DBNull.Value ? null : objRow[congs_KnowledgeType.UpdUser].ToString().Trim(); //修改人
objgs_KnowledgeTypeEN.Memo = objRow[congs_KnowledgeType.Memo] == DBNull.Value ? null : objRow[congs_KnowledgeType.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objgs_KnowledgeTypeEN.gsKnowledgeTypeId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objgs_KnowledgeTypeEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrGsKnowledgeTypeIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsgs_KnowledgeTypeEN> GetObjLstByGsKnowledgeTypeIdLstCache(List<string> arrGsKnowledgeTypeIdLst)
{
string strKey = string.Format("{0}", clsgs_KnowledgeTypeEN._CurrTabName);
List<clsgs_KnowledgeTypeEN> arrgs_KnowledgeTypeObjLstCache = GetObjLstCache();
IEnumerable <clsgs_KnowledgeTypeEN> arrgs_KnowledgeTypeObjLst_Sel =
arrgs_KnowledgeTypeObjLstCache
.Where(x => arrGsKnowledgeTypeIdLst.Contains(x.gsKnowledgeTypeId));
return arrgs_KnowledgeTypeObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsgs_KnowledgeTypeEN> GetObjLst(string strWhereCond)
{
List<clsgs_KnowledgeTypeEN> arrObjLst = new List<clsgs_KnowledgeTypeEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsgs_KnowledgeTypeEN objgs_KnowledgeTypeEN = new clsgs_KnowledgeTypeEN();
try
{
objgs_KnowledgeTypeEN.gsKnowledgeTypeId = objRow[congs_KnowledgeType.gsKnowledgeTypeId].ToString().Trim(); //知识类型Id
objgs_KnowledgeTypeEN.gsKnowledgeTypeName = objRow[congs_KnowledgeType.gsKnowledgeTypeName].ToString().Trim(); //知识类型名
objgs_KnowledgeTypeEN.KnowledgeTypeENName = objRow[congs_KnowledgeType.KnowledgeTypeENName].ToString().Trim(); //知识类型英文名
objgs_KnowledgeTypeEN.OrderNum = objRow[congs_KnowledgeType.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[congs_KnowledgeType.OrderNum].ToString().Trim()); //序号
objgs_KnowledgeTypeEN.UpdDate = objRow[congs_KnowledgeType.UpdDate] == DBNull.Value ? null : objRow[congs_KnowledgeType.UpdDate].ToString().Trim(); //修改日期
objgs_KnowledgeTypeEN.UpdUser = objRow[congs_KnowledgeType.UpdUser] == DBNull.Value ? null : objRow[congs_KnowledgeType.UpdUser].ToString().Trim(); //修改人
objgs_KnowledgeTypeEN.Memo = objRow[congs_KnowledgeType.Memo] == DBNull.Value ? null : objRow[congs_KnowledgeType.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objgs_KnowledgeTypeEN.gsKnowledgeTypeId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objgs_KnowledgeTypeEN);
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
public static List<clsgs_KnowledgeTypeEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsgs_KnowledgeTypeEN> arrObjLst = new List<clsgs_KnowledgeTypeEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsgs_KnowledgeTypeEN objgs_KnowledgeTypeEN = new clsgs_KnowledgeTypeEN();
try
{
objgs_KnowledgeTypeEN.gsKnowledgeTypeId = objRow[congs_KnowledgeType.gsKnowledgeTypeId].ToString().Trim(); //知识类型Id
objgs_KnowledgeTypeEN.gsKnowledgeTypeName = objRow[congs_KnowledgeType.gsKnowledgeTypeName].ToString().Trim(); //知识类型名
objgs_KnowledgeTypeEN.KnowledgeTypeENName = objRow[congs_KnowledgeType.KnowledgeTypeENName].ToString().Trim(); //知识类型英文名
objgs_KnowledgeTypeEN.OrderNum = objRow[congs_KnowledgeType.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[congs_KnowledgeType.OrderNum].ToString().Trim()); //序号
objgs_KnowledgeTypeEN.UpdDate = objRow[congs_KnowledgeType.UpdDate] == DBNull.Value ? null : objRow[congs_KnowledgeType.UpdDate].ToString().Trim(); //修改日期
objgs_KnowledgeTypeEN.UpdUser = objRow[congs_KnowledgeType.UpdUser] == DBNull.Value ? null : objRow[congs_KnowledgeType.UpdUser].ToString().Trim(); //修改人
objgs_KnowledgeTypeEN.Memo = objRow[congs_KnowledgeType.Memo] == DBNull.Value ? null : objRow[congs_KnowledgeType.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objgs_KnowledgeTypeEN.gsKnowledgeTypeId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objgs_KnowledgeTypeEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objgs_KnowledgeTypeCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsgs_KnowledgeTypeEN> GetSubObjLstCache(clsgs_KnowledgeTypeEN objgs_KnowledgeTypeCond)
{
List<clsgs_KnowledgeTypeEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsgs_KnowledgeTypeEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in congs_KnowledgeType.AttributeName)
{
if (objgs_KnowledgeTypeCond.IsUpdated(strFldName) == false) continue;
if (objgs_KnowledgeTypeCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objgs_KnowledgeTypeCond[strFldName].ToString());
}
else
{
if (objgs_KnowledgeTypeCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objgs_KnowledgeTypeCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objgs_KnowledgeTypeCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objgs_KnowledgeTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objgs_KnowledgeTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objgs_KnowledgeTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objgs_KnowledgeTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objgs_KnowledgeTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objgs_KnowledgeTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objgs_KnowledgeTypeCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objgs_KnowledgeTypeCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objgs_KnowledgeTypeCond[strFldName]));
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
public static List<clsgs_KnowledgeTypeEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsgs_KnowledgeTypeEN> arrObjLst = new List<clsgs_KnowledgeTypeEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsgs_KnowledgeTypeEN objgs_KnowledgeTypeEN = new clsgs_KnowledgeTypeEN();
try
{
objgs_KnowledgeTypeEN.gsKnowledgeTypeId = objRow[congs_KnowledgeType.gsKnowledgeTypeId].ToString().Trim(); //知识类型Id
objgs_KnowledgeTypeEN.gsKnowledgeTypeName = objRow[congs_KnowledgeType.gsKnowledgeTypeName].ToString().Trim(); //知识类型名
objgs_KnowledgeTypeEN.KnowledgeTypeENName = objRow[congs_KnowledgeType.KnowledgeTypeENName].ToString().Trim(); //知识类型英文名
objgs_KnowledgeTypeEN.OrderNum = objRow[congs_KnowledgeType.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[congs_KnowledgeType.OrderNum].ToString().Trim()); //序号
objgs_KnowledgeTypeEN.UpdDate = objRow[congs_KnowledgeType.UpdDate] == DBNull.Value ? null : objRow[congs_KnowledgeType.UpdDate].ToString().Trim(); //修改日期
objgs_KnowledgeTypeEN.UpdUser = objRow[congs_KnowledgeType.UpdUser] == DBNull.Value ? null : objRow[congs_KnowledgeType.UpdUser].ToString().Trim(); //修改人
objgs_KnowledgeTypeEN.Memo = objRow[congs_KnowledgeType.Memo] == DBNull.Value ? null : objRow[congs_KnowledgeType.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objgs_KnowledgeTypeEN.gsKnowledgeTypeId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objgs_KnowledgeTypeEN);
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
public static List<clsgs_KnowledgeTypeEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsgs_KnowledgeTypeEN> arrObjLst = new List<clsgs_KnowledgeTypeEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsgs_KnowledgeTypeEN objgs_KnowledgeTypeEN = new clsgs_KnowledgeTypeEN();
try
{
objgs_KnowledgeTypeEN.gsKnowledgeTypeId = objRow[congs_KnowledgeType.gsKnowledgeTypeId].ToString().Trim(); //知识类型Id
objgs_KnowledgeTypeEN.gsKnowledgeTypeName = objRow[congs_KnowledgeType.gsKnowledgeTypeName].ToString().Trim(); //知识类型名
objgs_KnowledgeTypeEN.KnowledgeTypeENName = objRow[congs_KnowledgeType.KnowledgeTypeENName].ToString().Trim(); //知识类型英文名
objgs_KnowledgeTypeEN.OrderNum = objRow[congs_KnowledgeType.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[congs_KnowledgeType.OrderNum].ToString().Trim()); //序号
objgs_KnowledgeTypeEN.UpdDate = objRow[congs_KnowledgeType.UpdDate] == DBNull.Value ? null : objRow[congs_KnowledgeType.UpdDate].ToString().Trim(); //修改日期
objgs_KnowledgeTypeEN.UpdUser = objRow[congs_KnowledgeType.UpdUser] == DBNull.Value ? null : objRow[congs_KnowledgeType.UpdUser].ToString().Trim(); //修改人
objgs_KnowledgeTypeEN.Memo = objRow[congs_KnowledgeType.Memo] == DBNull.Value ? null : objRow[congs_KnowledgeType.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objgs_KnowledgeTypeEN.gsKnowledgeTypeId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objgs_KnowledgeTypeEN);
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
List<clsgs_KnowledgeTypeEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsgs_KnowledgeTypeEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsgs_KnowledgeTypeEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsgs_KnowledgeTypeEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsgs_KnowledgeTypeEN> arrObjLst = new List<clsgs_KnowledgeTypeEN>(); 
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
	clsgs_KnowledgeTypeEN objgs_KnowledgeTypeEN = new clsgs_KnowledgeTypeEN();
try
{
objgs_KnowledgeTypeEN.gsKnowledgeTypeId = objRow[congs_KnowledgeType.gsKnowledgeTypeId].ToString().Trim(); //知识类型Id
objgs_KnowledgeTypeEN.gsKnowledgeTypeName = objRow[congs_KnowledgeType.gsKnowledgeTypeName].ToString().Trim(); //知识类型名
objgs_KnowledgeTypeEN.KnowledgeTypeENName = objRow[congs_KnowledgeType.KnowledgeTypeENName].ToString().Trim(); //知识类型英文名
objgs_KnowledgeTypeEN.OrderNum = objRow[congs_KnowledgeType.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[congs_KnowledgeType.OrderNum].ToString().Trim()); //序号
objgs_KnowledgeTypeEN.UpdDate = objRow[congs_KnowledgeType.UpdDate] == DBNull.Value ? null : objRow[congs_KnowledgeType.UpdDate].ToString().Trim(); //修改日期
objgs_KnowledgeTypeEN.UpdUser = objRow[congs_KnowledgeType.UpdUser] == DBNull.Value ? null : objRow[congs_KnowledgeType.UpdUser].ToString().Trim(); //修改人
objgs_KnowledgeTypeEN.Memo = objRow[congs_KnowledgeType.Memo] == DBNull.Value ? null : objRow[congs_KnowledgeType.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objgs_KnowledgeTypeEN.gsKnowledgeTypeId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objgs_KnowledgeTypeEN);
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
public static List<clsgs_KnowledgeTypeEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsgs_KnowledgeTypeEN> arrObjLst = new List<clsgs_KnowledgeTypeEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsgs_KnowledgeTypeEN objgs_KnowledgeTypeEN = new clsgs_KnowledgeTypeEN();
try
{
objgs_KnowledgeTypeEN.gsKnowledgeTypeId = objRow[congs_KnowledgeType.gsKnowledgeTypeId].ToString().Trim(); //知识类型Id
objgs_KnowledgeTypeEN.gsKnowledgeTypeName = objRow[congs_KnowledgeType.gsKnowledgeTypeName].ToString().Trim(); //知识类型名
objgs_KnowledgeTypeEN.KnowledgeTypeENName = objRow[congs_KnowledgeType.KnowledgeTypeENName].ToString().Trim(); //知识类型英文名
objgs_KnowledgeTypeEN.OrderNum = objRow[congs_KnowledgeType.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[congs_KnowledgeType.OrderNum].ToString().Trim()); //序号
objgs_KnowledgeTypeEN.UpdDate = objRow[congs_KnowledgeType.UpdDate] == DBNull.Value ? null : objRow[congs_KnowledgeType.UpdDate].ToString().Trim(); //修改日期
objgs_KnowledgeTypeEN.UpdUser = objRow[congs_KnowledgeType.UpdUser] == DBNull.Value ? null : objRow[congs_KnowledgeType.UpdUser].ToString().Trim(); //修改人
objgs_KnowledgeTypeEN.Memo = objRow[congs_KnowledgeType.Memo] == DBNull.Value ? null : objRow[congs_KnowledgeType.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objgs_KnowledgeTypeEN.gsKnowledgeTypeId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objgs_KnowledgeTypeEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsgs_KnowledgeTypeEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsgs_KnowledgeTypeEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsgs_KnowledgeTypeEN> arrObjLst = new List<clsgs_KnowledgeTypeEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsgs_KnowledgeTypeEN objgs_KnowledgeTypeEN = new clsgs_KnowledgeTypeEN();
try
{
objgs_KnowledgeTypeEN.gsKnowledgeTypeId = objRow[congs_KnowledgeType.gsKnowledgeTypeId].ToString().Trim(); //知识类型Id
objgs_KnowledgeTypeEN.gsKnowledgeTypeName = objRow[congs_KnowledgeType.gsKnowledgeTypeName].ToString().Trim(); //知识类型名
objgs_KnowledgeTypeEN.KnowledgeTypeENName = objRow[congs_KnowledgeType.KnowledgeTypeENName].ToString().Trim(); //知识类型英文名
objgs_KnowledgeTypeEN.OrderNum = objRow[congs_KnowledgeType.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[congs_KnowledgeType.OrderNum].ToString().Trim()); //序号
objgs_KnowledgeTypeEN.UpdDate = objRow[congs_KnowledgeType.UpdDate] == DBNull.Value ? null : objRow[congs_KnowledgeType.UpdDate].ToString().Trim(); //修改日期
objgs_KnowledgeTypeEN.UpdUser = objRow[congs_KnowledgeType.UpdUser] == DBNull.Value ? null : objRow[congs_KnowledgeType.UpdUser].ToString().Trim(); //修改人
objgs_KnowledgeTypeEN.Memo = objRow[congs_KnowledgeType.Memo] == DBNull.Value ? null : objRow[congs_KnowledgeType.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objgs_KnowledgeTypeEN.gsKnowledgeTypeId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objgs_KnowledgeTypeEN);
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
public static List<clsgs_KnowledgeTypeEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsgs_KnowledgeTypeEN> arrObjLst = new List<clsgs_KnowledgeTypeEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsgs_KnowledgeTypeEN objgs_KnowledgeTypeEN = new clsgs_KnowledgeTypeEN();
try
{
objgs_KnowledgeTypeEN.gsKnowledgeTypeId = objRow[congs_KnowledgeType.gsKnowledgeTypeId].ToString().Trim(); //知识类型Id
objgs_KnowledgeTypeEN.gsKnowledgeTypeName = objRow[congs_KnowledgeType.gsKnowledgeTypeName].ToString().Trim(); //知识类型名
objgs_KnowledgeTypeEN.KnowledgeTypeENName = objRow[congs_KnowledgeType.KnowledgeTypeENName].ToString().Trim(); //知识类型英文名
objgs_KnowledgeTypeEN.OrderNum = objRow[congs_KnowledgeType.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[congs_KnowledgeType.OrderNum].ToString().Trim()); //序号
objgs_KnowledgeTypeEN.UpdDate = objRow[congs_KnowledgeType.UpdDate] == DBNull.Value ? null : objRow[congs_KnowledgeType.UpdDate].ToString().Trim(); //修改日期
objgs_KnowledgeTypeEN.UpdUser = objRow[congs_KnowledgeType.UpdUser] == DBNull.Value ? null : objRow[congs_KnowledgeType.UpdUser].ToString().Trim(); //修改人
objgs_KnowledgeTypeEN.Memo = objRow[congs_KnowledgeType.Memo] == DBNull.Value ? null : objRow[congs_KnowledgeType.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objgs_KnowledgeTypeEN.gsKnowledgeTypeId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objgs_KnowledgeTypeEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsgs_KnowledgeTypeEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsgs_KnowledgeTypeEN> arrObjLst = new List<clsgs_KnowledgeTypeEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsgs_KnowledgeTypeEN objgs_KnowledgeTypeEN = new clsgs_KnowledgeTypeEN();
try
{
objgs_KnowledgeTypeEN.gsKnowledgeTypeId = objRow[congs_KnowledgeType.gsKnowledgeTypeId].ToString().Trim(); //知识类型Id
objgs_KnowledgeTypeEN.gsKnowledgeTypeName = objRow[congs_KnowledgeType.gsKnowledgeTypeName].ToString().Trim(); //知识类型名
objgs_KnowledgeTypeEN.KnowledgeTypeENName = objRow[congs_KnowledgeType.KnowledgeTypeENName].ToString().Trim(); //知识类型英文名
objgs_KnowledgeTypeEN.OrderNum = objRow[congs_KnowledgeType.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[congs_KnowledgeType.OrderNum].ToString().Trim()); //序号
objgs_KnowledgeTypeEN.UpdDate = objRow[congs_KnowledgeType.UpdDate] == DBNull.Value ? null : objRow[congs_KnowledgeType.UpdDate].ToString().Trim(); //修改日期
objgs_KnowledgeTypeEN.UpdUser = objRow[congs_KnowledgeType.UpdUser] == DBNull.Value ? null : objRow[congs_KnowledgeType.UpdUser].ToString().Trim(); //修改人
objgs_KnowledgeTypeEN.Memo = objRow[congs_KnowledgeType.Memo] == DBNull.Value ? null : objRow[congs_KnowledgeType.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objgs_KnowledgeTypeEN.gsKnowledgeTypeId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objgs_KnowledgeTypeEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objgs_KnowledgeTypeEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool Getgs_KnowledgeType(ref clsgs_KnowledgeTypeEN objgs_KnowledgeTypeEN)
{
bool bolResult = gs_KnowledgeTypeDA.Getgs_KnowledgeType(ref objgs_KnowledgeTypeEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "strgsKnowledgeTypeId">表关键字</param>
 /// <returns>表对象</returns>
public static clsgs_KnowledgeTypeEN GetObjBygsKnowledgeTypeId(string strgsKnowledgeTypeId)
{
if (strgsKnowledgeTypeId.IndexOf(' ') >=0)
{
var strMsg = string.Format("(errid:Busi000079)在表中,关键字[strgsKnowledgeTypeId]中不能有空格!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
if (string.IsNullOrEmpty(strgsKnowledgeTypeId) == true)
{
var strMsg = string.Format("(errid:Busi000020)在表中,关键字[strgsKnowledgeTypeId]不能为空!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
clsgs_KnowledgeTypeEN objgs_KnowledgeTypeEN = gs_KnowledgeTypeDA.GetObjBygsKnowledgeTypeId(strgsKnowledgeTypeId);
return objgs_KnowledgeTypeEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsgs_KnowledgeTypeEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsgs_KnowledgeTypeEN objgs_KnowledgeTypeEN = gs_KnowledgeTypeDA.GetFirstObj(strWhereCond);
 return objgs_KnowledgeTypeEN;
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
public static clsgs_KnowledgeTypeEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsgs_KnowledgeTypeEN objgs_KnowledgeTypeEN = gs_KnowledgeTypeDA.GetObjByDataRow(objRow);
 return objgs_KnowledgeTypeEN;
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
public static clsgs_KnowledgeTypeEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsgs_KnowledgeTypeEN objgs_KnowledgeTypeEN = gs_KnowledgeTypeDA.GetObjByDataRow(objRow);
 return objgs_KnowledgeTypeEN;
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
 /// <param name = "strgsKnowledgeTypeId">所给的关键字</param>
 /// <param name = "lstgs_KnowledgeTypeObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsgs_KnowledgeTypeEN GetObjBygsKnowledgeTypeIdFromList(string strgsKnowledgeTypeId, List<clsgs_KnowledgeTypeEN> lstgs_KnowledgeTypeObjLst)
{
foreach (clsgs_KnowledgeTypeEN objgs_KnowledgeTypeEN in lstgs_KnowledgeTypeObjLst)
{
if (objgs_KnowledgeTypeEN.gsKnowledgeTypeId == strgsKnowledgeTypeId)
{
return objgs_KnowledgeTypeEN;
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
 string strMaxGsKnowledgeTypeId;
 try
 {
 strMaxGsKnowledgeTypeId = clsgs_KnowledgeTypeDA.GetMaxStrId();
 return strMaxGsKnowledgeTypeId;
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
 string strgsKnowledgeTypeId;
 try
 {
 strgsKnowledgeTypeId = new clsgs_KnowledgeTypeDA().GetFirstID(strWhereCond);
 return strgsKnowledgeTypeId;
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
 arrList = gs_KnowledgeTypeDA.GetID(strWhereCond);
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
bool bolIsExist = gs_KnowledgeTypeDA.IsExistCondRec(strWhereCond);
return bolIsExist;
}

 /// <summary>
 /// 判断当前表中是否存在给定关键字值的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExist)
 /// </summary>
 /// <param name = "strgsKnowledgeTypeId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public static bool IsExist(string strgsKnowledgeTypeId)
{
if (string.IsNullOrEmpty(strgsKnowledgeTypeId) == true)
{
var strMsg = string.Format("(errid:Busi000027)在表中,关键字[strgsKnowledgeTypeId]不能为空!!(from {0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
//检测记录是否存在
bool bolIsExist = gs_KnowledgeTypeDA.IsExist(strgsKnowledgeTypeId);
return bolIsExist;
}

/// <summary>
/// 设置修改时间
/// </summary>
/// <param name = "strgsKnowledgeTypeId">知识类型Id</param>
/// <param name = "strOpUser">修改用户</param>
/// <returns>是否成功？</returns>
public static bool SetUpdDate(string strgsKnowledgeTypeId, string strOpUser)
{
clsgs_KnowledgeTypeEN objgs_KnowledgeTypeEN = clsgs_KnowledgeTypeBL.GetObjBygsKnowledgeTypeId(strgsKnowledgeTypeId);
objgs_KnowledgeTypeEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
objgs_KnowledgeTypeEN.UpdUser = strOpUser;
return clsgs_KnowledgeTypeBL.UpdateBySql2(objgs_KnowledgeTypeEN);
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
 bolIsExist = clsgs_KnowledgeTypeDA.IsExistTable();
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
 bolIsExist = gs_KnowledgeTypeDA.IsExistTable(strTabName);
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
 /// <param name = "objgs_KnowledgeTypeEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecordBySql2(clsgs_KnowledgeTypeEN objgs_KnowledgeTypeEN, bool bolIsNeedCheckUniqueness=true)
{
if (bolIsNeedCheckUniqueness == true && objgs_KnowledgeTypeEN.CheckUniqueness() == false)
{
var strMsg = string.Format("记录已经存在!知识类型名 = [{0}]的数据已经存在!(in clsgs_KnowledgeTypeBL.AddNewRecordBySql2)", objgs_KnowledgeTypeEN.gsKnowledgeTypeName);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objgs_KnowledgeTypeEN.gsKnowledgeTypeId) == true || clsgs_KnowledgeTypeBL.IsExist(objgs_KnowledgeTypeEN.gsKnowledgeTypeId) == true)
 {
     objgs_KnowledgeTypeEN.gsKnowledgeTypeId = clsgs_KnowledgeTypeBL.GetMaxStrId_S();
 }
bool bolResult = gs_KnowledgeTypeDA.AddNewRecordBySQL2(objgs_KnowledgeTypeEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsgs_KnowledgeTypeBL.ReFreshCache();

if (clsgs_KnowledgeTypeBL.relatedActions != null)
{
clsgs_KnowledgeTypeBL.relatedActions.UpdRelaTabDate(objgs_KnowledgeTypeEN.gsKnowledgeTypeId, objgs_KnowledgeTypeEN.UpdUser);
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
 /// <param name = "objgs_KnowledgeTypeEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordBySql2WithReturnKey(clsgs_KnowledgeTypeEN objgs_KnowledgeTypeEN, bool bolIsNeedCheckUniqueness=true)
{
if (bolIsNeedCheckUniqueness == true && objgs_KnowledgeTypeEN.CheckUniqueness() == false)
{
var strMsg = string.Format("记录已经存在!知识类型名 = [{0}]的数据已经存在!(in clsgs_KnowledgeTypeBL.AddNewRecordBySql2WithReturnKey)", objgs_KnowledgeTypeEN.gsKnowledgeTypeName);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objgs_KnowledgeTypeEN.gsKnowledgeTypeId) == true || clsgs_KnowledgeTypeBL.IsExist(objgs_KnowledgeTypeEN.gsKnowledgeTypeId) == true)
 {
     objgs_KnowledgeTypeEN.gsKnowledgeTypeId = clsgs_KnowledgeTypeBL.GetMaxStrId_S();
 }
string strKey = gs_KnowledgeTypeDA.AddNewRecordBySQL2WithReturnKey(objgs_KnowledgeTypeEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsgs_KnowledgeTypeBL.ReFreshCache();

if (clsgs_KnowledgeTypeBL.relatedActions != null)
{
clsgs_KnowledgeTypeBL.relatedActions.UpdRelaTabDate(objgs_KnowledgeTypeEN.gsKnowledgeTypeId, objgs_KnowledgeTypeEN.UpdUser);
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
 /// <param name = "objgs_KnowledgeTypeEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(clsgs_KnowledgeTypeEN objgs_KnowledgeTypeEN)
{
try
{
bool bolResult = gs_KnowledgeTypeDA.Update(objgs_KnowledgeTypeEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsgs_KnowledgeTypeBL.ReFreshCache();

if (clsgs_KnowledgeTypeBL.relatedActions != null)
{
clsgs_KnowledgeTypeBL.relatedActions.UpdRelaTabDate(objgs_KnowledgeTypeEN.gsKnowledgeTypeId, objgs_KnowledgeTypeEN.UpdUser);
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
 /// <param name = "objgs_KnowledgeTypeEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateBySql2(clsgs_KnowledgeTypeEN objgs_KnowledgeTypeEN)
{
 if (string.IsNullOrEmpty(objgs_KnowledgeTypeEN.gsKnowledgeTypeId) == true)
 {
var strMsg = string.Format("(errid:Busi000065)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = gs_KnowledgeTypeDA.UpdateBySql2(objgs_KnowledgeTypeEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsgs_KnowledgeTypeBL.ReFreshCache();

if (clsgs_KnowledgeTypeBL.relatedActions != null)
{
clsgs_KnowledgeTypeBL.relatedActions.UpdRelaTabDate(objgs_KnowledgeTypeEN.gsKnowledgeTypeId, objgs_KnowledgeTypeEN.UpdUser);
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
 /// <param name = "strgsKnowledgeTypeId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int DelRecord(string strgsKnowledgeTypeId)
{
try
{
 clsgs_KnowledgeTypeEN objgs_KnowledgeTypeEN = clsgs_KnowledgeTypeBL.GetObjBygsKnowledgeTypeId(strgsKnowledgeTypeId);

if (clsgs_KnowledgeTypeBL.relatedActions != null)
{
clsgs_KnowledgeTypeBL.relatedActions.UpdRelaTabDate(objgs_KnowledgeTypeEN.gsKnowledgeTypeId, objgs_KnowledgeTypeEN.UpdUser);
}
if (objgs_KnowledgeTypeEN != null)
{
int intRecNum = gs_KnowledgeTypeDA.DelRecord(strgsKnowledgeTypeId);
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
/// <param name="strgsKnowledgeTypeId">表关键字</param>
/// <returns></returns>
public static bool DelRecordEx(string strgsKnowledgeTypeId )
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsgs_KnowledgeTypeDA.GetSpecSQLObj();
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
//删除与表:[gs_KnowledgeType]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//congs_KnowledgeType.gsKnowledgeTypeId,
//strgsKnowledgeTypeId);
//        clsgs_KnowledgeTypeBL.Delgs_KnowledgeTypesByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsgs_KnowledgeTypeBL.DelRecord(strgsKnowledgeTypeId, objConnection, objSqlTransaction);
objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsgs_KnowledgeTypeBLEx", "DelRecordEx", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("扩展删除记录出错:{0}!keyId = {1}.({2})",
objException.Message,
strgsKnowledgeTypeId, clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "strgsKnowledgeTypeId">给定的关键字值</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回删除是否成功?</returns>
public static bool DelRecord(string strgsKnowledgeTypeId, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
if (clsgs_KnowledgeTypeBL.relatedActions != null)
{
clsgs_KnowledgeTypeBL.relatedActions.UpdRelaTabDate(strgsKnowledgeTypeId, "UpdRelaTabDate");
}
bool bolResult = gs_KnowledgeTypeDA.DelRecord(strgsKnowledgeTypeId,objSqlConnection,objSqlTransaction);
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
 /// <param name = "arrgsKnowledgeTypeIdLst">给定的关键字值列表</param>
 /// <returns>返回删除的记录数</returns>
public static int Delgs_KnowledgeTypes(List<string> arrgsKnowledgeTypeIdLst)
{
if (arrgsKnowledgeTypeIdLst.Count == 0) return 0;
try
{
if (clsgs_KnowledgeTypeBL.relatedActions != null)
{
foreach (var strgsKnowledgeTypeId in arrgsKnowledgeTypeIdLst)
{
clsgs_KnowledgeTypeBL.relatedActions.UpdRelaTabDate(strgsKnowledgeTypeId, "UpdRelaTabDate");
}
}
int intDelRecNum = gs_KnowledgeTypeDA.Delgs_KnowledgeType(arrgsKnowledgeTypeIdLst);
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
public static int Delgs_KnowledgeTypesByCond(string strWhereCond)
{
try
{
if (clsgs_KnowledgeTypeBL.relatedActions != null)
{
List<string> arrgsKnowledgeTypeId = GetPrimaryKeyID_S(strWhereCond);
foreach (var strgsKnowledgeTypeId in arrgsKnowledgeTypeId)
{
clsgs_KnowledgeTypeBL.relatedActions.UpdRelaTabDate(strgsKnowledgeTypeId, "UpdRelaTabDate");
}
}
int intRecNum = gs_KnowledgeTypeDA.Delgs_KnowledgeType(strWhereCond);
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
/// 这里仅仅是演示函数,使用时请复制到扩展类:[gs_KnowledgeType]中改名为:[DelRecord4MultiTabEx]使用
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DelRecord4MultiTab)
/// </summary>
/// <param name="strgsKnowledgeTypeId">表关键字</param>
/// <returns></returns>
public static bool DelRecord4MultiTab(string strgsKnowledgeTypeId)
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsgs_KnowledgeTypeDA.GetSpecSQLObj();
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
//删除与表:[gs_KnowledgeType]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conStudent.id_College,
//strid_College);
//        clsStudentBL.DelStudentsByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsgs_KnowledgeTypeBL.DelRecord(strgsKnowledgeTypeId, objConnection, objSqlTransaction);
                objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsgs_KnowledgeTypeBL", "DelRecord4MultiTab", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("删除多表记录出错:{0}!keyId = {1}.({2})",
objException.Message,
strgsKnowledgeTypeId, clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "objgs_KnowledgeTypeENS">源对象</param>
 /// <param name = "objgs_KnowledgeTypeENT">目标对象</param>
 public static void CopyTo(clsgs_KnowledgeTypeEN objgs_KnowledgeTypeENS, clsgs_KnowledgeTypeEN objgs_KnowledgeTypeENT)
{
try
{
objgs_KnowledgeTypeENT.gsKnowledgeTypeId = objgs_KnowledgeTypeENS.gsKnowledgeTypeId; //知识类型Id
objgs_KnowledgeTypeENT.gsKnowledgeTypeName = objgs_KnowledgeTypeENS.gsKnowledgeTypeName; //知识类型名
objgs_KnowledgeTypeENT.KnowledgeTypeENName = objgs_KnowledgeTypeENS.KnowledgeTypeENName; //知识类型英文名
objgs_KnowledgeTypeENT.OrderNum = objgs_KnowledgeTypeENS.OrderNum; //序号
objgs_KnowledgeTypeENT.UpdDate = objgs_KnowledgeTypeENS.UpdDate; //修改日期
objgs_KnowledgeTypeENT.UpdUser = objgs_KnowledgeTypeENS.UpdUser; //修改人
objgs_KnowledgeTypeENT.Memo = objgs_KnowledgeTypeENS.Memo; //备注
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
 /// <param name = "objgs_KnowledgeTypeEN">源简化对象</param>
 public static void SetUpdFlag(clsgs_KnowledgeTypeEN objgs_KnowledgeTypeEN)
{
try
{
objgs_KnowledgeTypeEN.ClearUpdateState();
   string strsfUpdFldSetStr = objgs_KnowledgeTypeEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(congs_KnowledgeType.gsKnowledgeTypeId, new clsStrCompareIgnoreCase())  ==  true)
{
objgs_KnowledgeTypeEN.gsKnowledgeTypeId = objgs_KnowledgeTypeEN.gsKnowledgeTypeId; //知识类型Id
}
if (arrFldSet.Contains(congs_KnowledgeType.gsKnowledgeTypeName, new clsStrCompareIgnoreCase())  ==  true)
{
objgs_KnowledgeTypeEN.gsKnowledgeTypeName = objgs_KnowledgeTypeEN.gsKnowledgeTypeName; //知识类型名
}
if (arrFldSet.Contains(congs_KnowledgeType.KnowledgeTypeENName, new clsStrCompareIgnoreCase())  ==  true)
{
objgs_KnowledgeTypeEN.KnowledgeTypeENName = objgs_KnowledgeTypeEN.KnowledgeTypeENName; //知识类型英文名
}
if (arrFldSet.Contains(congs_KnowledgeType.OrderNum, new clsStrCompareIgnoreCase())  ==  true)
{
objgs_KnowledgeTypeEN.OrderNum = objgs_KnowledgeTypeEN.OrderNum; //序号
}
if (arrFldSet.Contains(congs_KnowledgeType.UpdDate, new clsStrCompareIgnoreCase())  ==  true)
{
objgs_KnowledgeTypeEN.UpdDate = objgs_KnowledgeTypeEN.UpdDate == "[null]" ? null :  objgs_KnowledgeTypeEN.UpdDate; //修改日期
}
if (arrFldSet.Contains(congs_KnowledgeType.UpdUser, new clsStrCompareIgnoreCase())  ==  true)
{
objgs_KnowledgeTypeEN.UpdUser = objgs_KnowledgeTypeEN.UpdUser == "[null]" ? null :  objgs_KnowledgeTypeEN.UpdUser; //修改人
}
if (arrFldSet.Contains(congs_KnowledgeType.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objgs_KnowledgeTypeEN.Memo = objgs_KnowledgeTypeEN.Memo == "[null]" ? null :  objgs_KnowledgeTypeEN.Memo; //备注
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
 /// <param name = "objgs_KnowledgeTypeEN">源简化对象</param>
 public static void AccessFldValueNull(clsgs_KnowledgeTypeEN objgs_KnowledgeTypeEN)
{
try
{
if (objgs_KnowledgeTypeEN.UpdDate == "[null]") objgs_KnowledgeTypeEN.UpdDate = null; //修改日期
if (objgs_KnowledgeTypeEN.UpdUser == "[null]") objgs_KnowledgeTypeEN.UpdUser = null; //修改人
if (objgs_KnowledgeTypeEN.Memo == "[null]") objgs_KnowledgeTypeEN.Memo = null; //备注
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
public static void CheckPropertyNew(clsgs_KnowledgeTypeEN objgs_KnowledgeTypeEN)
{
 gs_KnowledgeTypeDA.CheckPropertyNew(objgs_KnowledgeTypeEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(clsgs_KnowledgeTypeEN objgs_KnowledgeTypeEN)
{
 gs_KnowledgeTypeDA.CheckProperty4Condition(objgs_KnowledgeTypeEN);
 }


 #endregion 检查对象属性


 #region 绑定下拉框

 /// <summary>
 /// 绑定基于Web的下拉框-使用Cache
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DdlBindFunctionCache)
 /// </summary>
 /// <param name = "objDDL">需要绑定当前表的下拉框</param>
public static void BindDdl_gsKnowledgeTypeIdCache(System.Web.UI.WebControls.DropDownList objDDL)
{
//为数据源于表的下拉框设置内容
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[知识类型]...","0");
List<clsgs_KnowledgeTypeEN> arrgs_KnowledgeTypeObjLst = GetAllgs_KnowledgeTypeObjLstCache(); 
objDDL.DataValueField = congs_KnowledgeType.gsKnowledgeTypeId;
objDDL.DataTextField = congs_KnowledgeType.gsKnowledgeTypeName;
objDDL.DataSource = arrgs_KnowledgeTypeObjLst;
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
if (clsgs_KnowledgeTypeBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsgs_KnowledgeTypeBL没有刷新缓存机制(clsgs_KnowledgeTypeBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by gsKnowledgeTypeId");
//if (arrgs_KnowledgeTypeObjLstCache == null)
//{
//arrgs_KnowledgeTypeObjLstCache = gs_KnowledgeTypeDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "strgsKnowledgeTypeId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsgs_KnowledgeTypeEN GetObjBygsKnowledgeTypeIdCache(string strgsKnowledgeTypeId)
{
//获取缓存中的对象列表
string strKey = string.Format("{0}", clsgs_KnowledgeTypeEN._CurrTabName);
List<clsgs_KnowledgeTypeEN> arrgs_KnowledgeTypeObjLstCache = GetObjLstCache();
IEnumerable <clsgs_KnowledgeTypeEN> arrgs_KnowledgeTypeObjLst_Sel =
arrgs_KnowledgeTypeObjLstCache
.Where(x=> x.gsKnowledgeTypeId == strgsKnowledgeTypeId 
);
if (arrgs_KnowledgeTypeObjLst_Sel.Count() == 0)
{
   clsgs_KnowledgeTypeEN obj = clsgs_KnowledgeTypeBL.GetObjBygsKnowledgeTypeId(strgsKnowledgeTypeId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
 }
return null;
}
return arrgs_KnowledgeTypeObjLst_Sel.First();
}

 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecNameByKeyCache)
 /// </summary>
 /// <param name = "strgsKnowledgeTypeId">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetgsKnowledgeTypeNameBygsKnowledgeTypeIdCache(string strgsKnowledgeTypeId)
{
if (string.IsNullOrEmpty(strgsKnowledgeTypeId) == true) return "";
//获取缓存中的对象列表
clsgs_KnowledgeTypeEN objgs_KnowledgeType = GetObjBygsKnowledgeTypeIdCache(strgsKnowledgeTypeId);
if (objgs_KnowledgeType == null) return "";
return objgs_KnowledgeType.gsKnowledgeTypeName;
}
 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecNameByKeyCache)
 /// </summary>
 /// <param name = "strgsKnowledgeTypeId">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetNameBygsKnowledgeTypeIdCache(string strgsKnowledgeTypeId)
{
if (string.IsNullOrEmpty(strgsKnowledgeTypeId) == true) return "";
//获取缓存中的对象列表
clsgs_KnowledgeTypeEN objgs_KnowledgeType = GetObjBygsKnowledgeTypeIdCache(strgsKnowledgeTypeId);
if (objgs_KnowledgeType == null) return "";
return objgs_KnowledgeType.gsKnowledgeTypeName;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsgs_KnowledgeTypeEN> GetAllgs_KnowledgeTypeObjLstCache()
{
//获取缓存中的对象列表
List<clsgs_KnowledgeTypeEN> arrgs_KnowledgeTypeObjLstCache = GetObjLstCache(); 
return arrgs_KnowledgeTypeObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsgs_KnowledgeTypeEN> GetObjLstCache()
{
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}", clsgs_KnowledgeTypeEN._CurrTabName);
List<clsgs_KnowledgeTypeEN> arrgs_KnowledgeTypeObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrgs_KnowledgeTypeObjLstCache;
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
string strKey = string.Format("{0}", clsgs_KnowledgeTypeEN._CurrTabName);
CacheHelper.Remove(strKey);
clsgs_KnowledgeTypeEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
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
if (clsgs_KnowledgeTypeEN._RefreshTimeLst.Count == 0) return "";
return clsgs_KnowledgeTypeEN._RefreshTimeLst[clsgs_KnowledgeTypeEN._RefreshTimeLst.Count - 1];
}

 /// <summary>
 /// 刷新缓存.把当前表的缓存以及该表相关视图的缓存清空.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ReFreshCache)
 /// </summary>
public static void ReFreshCache()
{
if (clsgs_KnowledgeTypeBL.objCommFun4BL != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}", clsgs_KnowledgeTypeEN._CurrTabName);
CacheHelper.Remove(strKey);
clsgs_KnowledgeTypeEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
clsgs_KnowledgeTypeBL.objCommFun4BL.ReFreshCache();
}
}


 #endregion 缓存操作


 #region 检查唯一性

 /// <summary>
 /// 获取检查唯一性条件串(Uniqueness)--gs_KnowledgeType(知识类型)
 /// 唯一性条件:gsKnowledgeTypeName
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetUniquenessConditionString)
 /// </summary>
 /// <param name = "objgs_KnowledgeTypeEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(clsgs_KnowledgeTypeEN objgs_KnowledgeTypeEN)
{
//检测记录是否存在
string strResult = gs_KnowledgeTypeDA.GetUniCondStr(objgs_KnowledgeTypeEN);
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
public static string Func(string strInFldName, string strOutFldName, string strgsKnowledgeTypeId)
{
if (strInFldName != congs_KnowledgeType.gsKnowledgeTypeId)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (congs_KnowledgeType.AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", congs_KnowledgeType.AttributeName));
throw new Exception(strMsg);
}
var objgs_KnowledgeType = clsgs_KnowledgeTypeBL.GetObjBygsKnowledgeTypeIdCache(strgsKnowledgeTypeId);
if (objgs_KnowledgeType == null) return "";
return objgs_KnowledgeType[strOutFldName].ToString();
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
int intRecCount = clsgs_KnowledgeTypeDA.GetRecCount(strTabName);
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
int intRecCount = clsgs_KnowledgeTypeDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsgs_KnowledgeTypeDA.GetRecCount();
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
int intRecCount = clsgs_KnowledgeTypeDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objgs_KnowledgeTypeCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsgs_KnowledgeTypeEN objgs_KnowledgeTypeCond)
{
List<clsgs_KnowledgeTypeEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsgs_KnowledgeTypeEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in congs_KnowledgeType.AttributeName)
{
if (objgs_KnowledgeTypeCond.IsUpdated(strFldName) == false) continue;
if (objgs_KnowledgeTypeCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objgs_KnowledgeTypeCond[strFldName].ToString());
}
else
{
if (objgs_KnowledgeTypeCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objgs_KnowledgeTypeCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objgs_KnowledgeTypeCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objgs_KnowledgeTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objgs_KnowledgeTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objgs_KnowledgeTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objgs_KnowledgeTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objgs_KnowledgeTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objgs_KnowledgeTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objgs_KnowledgeTypeCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objgs_KnowledgeTypeCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objgs_KnowledgeTypeCond[strFldName]));
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
 List<string> arrList = clsgs_KnowledgeTypeDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = gs_KnowledgeTypeDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = gs_KnowledgeTypeDA.GetFldValueNoDistinct(strFldName, strWhereCond);
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
int intRecCount = gs_KnowledgeTypeDA.SetFldValue(strFldName, strValue, strWhereCond);
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
int intRecCount = clsgs_KnowledgeTypeDA.SetFldValue(clsgs_KnowledgeTypeEN._CurrTabName, strFldName, fltValue, strWhereCond);
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
int intRecCount = gs_KnowledgeTypeDA.SetFldValue( strFldName, intValue, strWhereCond);
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
int intRecCount = clsgs_KnowledgeTypeDA.SetFldValue(strTabName, strFldName, strValue, strWhereCond);
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
int intRecCount = clsgs_KnowledgeTypeDA.SetFldValue(strTabName, strFldName, intValue, strWhereCond);
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
int intRecCount = clsgs_KnowledgeTypeDA.SetFldValue(strTabName, strFldName, fltValue, strWhereCond);
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
  strCreateTabCode.Append("CREATE table [dbo].[gs_KnowledgeType] "); 
 strCreateTabCode.Append(" ( "); 
 // /**知识类型Id*/ 
 strCreateTabCode.Append(" gsKnowledgeTypeId char(2) primary key, "); 
 // /**知识类型名*/ 
 strCreateTabCode.Append(" gsKnowledgeTypeName varchar(50) not Null, "); 
 // /**知识类型英文名*/ 
 strCreateTabCode.Append(" KnowledgeTypeENName varchar(50) not Null, "); 
 // /**序号*/ 
 strCreateTabCode.Append(" OrderNum int Null, "); 
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
 /// 知识类型(gs_KnowledgeType)
 /// 数据源类型:表
 /// (AutoGCLib.CommFun4BL4CSharp:GeneCode_This)
 /// </summary>
public class  clsCommFun4BL4gs_KnowledgeType : clsCommFun4BL
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
clsgs_KnowledgeTypeBL.ReFreshThisCache();
}
}

}