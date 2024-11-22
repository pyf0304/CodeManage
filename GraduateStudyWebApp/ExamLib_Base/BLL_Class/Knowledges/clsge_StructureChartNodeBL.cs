
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsge_StructureChartNodeBL
 表名:ge_StructureChartNode(01120894)
 * 版本:2024.11.13.1(服务器:WIN-SRV103-116)
 日期:2024/11/13 06:12:53
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:研究生学习游戏化后台(000055, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:知识点相关(Knowledges)
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
public static class  clsge_StructureChartNodeBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "strStructureNodeId">表关键字</param>
 /// <returns>表对象</returns>
public static clsge_StructureChartNodeEN GetObj(this K_StructureNodeId_ge_StructureChartNode myKey)
{
clsge_StructureChartNodeEN objge_StructureChartNodeEN = clsge_StructureChartNodeBL.ge_StructureChartNodeDA.GetObjByStructureNodeId(myKey.Value);
return objge_StructureChartNodeEN;
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_AddNewRecord)
 /// </summary>
 /// <param name = "objge_StructureChartNodeEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clsge_StructureChartNodeEN objge_StructureChartNodeEN, bool bolIsNeedCheckUniqueness = true)
{
if (bolIsNeedCheckUniqueness == true && CheckUniqueness(objge_StructureChartNodeEN) == false)
{
var strMsg = string.Format("记录已经存在!结构名称 = [{0}]的数据已经存在!(in clsge_StructureChartNodeBL.AddNewRecord)", objge_StructureChartNodeEN.StructureNodeName);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objge_StructureChartNodeEN.StructureNodeId) == true || clsge_StructureChartNodeBL.IsExist(objge_StructureChartNodeEN.StructureNodeId) == true)
 {
     objge_StructureChartNodeEN.StructureNodeId = clsge_StructureChartNodeBL.GetMaxStrId_S();
 }
bool bolResult = clsge_StructureChartNodeBL.ge_StructureChartNodeDA.AddNewRecordBySQL2(objge_StructureChartNodeEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsge_StructureChartNodeBL.ReFreshCache(objge_StructureChartNodeEN.StructureGraphId);

if (clsge_StructureChartNodeBL.relatedActions != null)
{
clsge_StructureChartNodeBL.relatedActions.UpdRelaTabDate(objge_StructureChartNodeEN.StructureNodeId, objge_StructureChartNodeEN.UpdUser);
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
public static bool AddRecordEx(this clsge_StructureChartNodeEN objge_StructureChartNodeEN, bool bolIsNeedCheckUniqueness = true)
{
//操作步骤:
//1、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在
//2、检查唯一性
//3、检查传进去的对象属性是否合法
//4、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
//1、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在

//因为是字符型自增主键,不需要检查主键是否已经存在,在添加时,再获取 最大值作为主键
//if (clsge_StructureChartNodeBL.IsExist(objge_StructureChartNodeEN.StructureNodeId))	//判断是否有相同的关键字
//{
//strMsg = "(errid:Busi000151)关键字字段已有相同的值";
//throw new Exception(strMsg);
//}
try
{
 //2、检查传进去的对象属性是否合法
objge_StructureChartNodeEN.CheckPropertyNew();
 ///5.2、检查唯一性
if (bolIsNeedCheckUniqueness == true && objge_StructureChartNodeEN.CheckUniqueness() == false)
{
strMsg = string.Format("(结构名称(StructureNodeName)=[{0}])已经存在,不能重复!", objge_StructureChartNodeEN.StructureNodeName);
throw new Exception(strMsg);
}
//因为是字符型自增主键,所以在添加时,自动获取主键值。
 if (string.IsNullOrEmpty(objge_StructureChartNodeEN.StructureNodeId) == true || clsge_StructureChartNodeBL.IsExist(objge_StructureChartNodeEN.StructureNodeId) == true)
 {
     objge_StructureChartNodeEN.StructureNodeId = clsge_StructureChartNodeBL.GetMaxStrId_S();
 }
//6、把数据实体层的数据存贮到数据库中
objge_StructureChartNodeEN.AddNewRecord();
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
 /// <param name = "objge_StructureChartNodeEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static string AddNewRecordWithMaxId(this clsge_StructureChartNodeEN objge_StructureChartNodeEN, bool bolIsNeedCheckUniqueness = true)
{
if (bolIsNeedCheckUniqueness == true && CheckUniqueness(objge_StructureChartNodeEN) == false)
{
var strMsg = string.Format("记录已经存在!结构名称 = [{0}]的数据已经存在!(in clsge_StructureChartNodeBL.AddNewRecordWithMaxId)", objge_StructureChartNodeEN.StructureNodeName);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objge_StructureChartNodeEN.StructureNodeId) == true || clsge_StructureChartNodeBL.IsExist(objge_StructureChartNodeEN.StructureNodeId) == true)
 {
     objge_StructureChartNodeEN.StructureNodeId = clsge_StructureChartNodeBL.GetMaxStrId_S();
 }
string strStructureNodeId = clsge_StructureChartNodeBL.ge_StructureChartNodeDA.AddNewRecordBySQL2WithReturnKey(objge_StructureChartNodeEN);
     objge_StructureChartNodeEN.StructureNodeId = strStructureNodeId;
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsge_StructureChartNodeBL.ReFreshCache(objge_StructureChartNodeEN.StructureGraphId);

if (clsge_StructureChartNodeBL.relatedActions != null)
{
clsge_StructureChartNodeBL.relatedActions.UpdRelaTabDate(objge_StructureChartNodeEN.StructureNodeId, objge_StructureChartNodeEN.UpdUser);
}
return strStructureNodeId;
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
 /// <param name = "objge_StructureChartNodeEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordWithReturnKey(this clsge_StructureChartNodeEN objge_StructureChartNodeEN, bool bolIsNeedCheckUniqueness = true)
{
if (bolIsNeedCheckUniqueness == true && CheckUniqueness(objge_StructureChartNodeEN) == false)
{
var strMsg = string.Format("记录已经存在!结构名称 = [{0}]的数据已经存在!(in clsge_StructureChartNodeBL.AddNewRecordWithReturnKey)", objge_StructureChartNodeEN.StructureNodeName);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objge_StructureChartNodeEN.StructureNodeId) == true || clsge_StructureChartNodeBL.IsExist(objge_StructureChartNodeEN.StructureNodeId) == true)
 {
     objge_StructureChartNodeEN.StructureNodeId = clsge_StructureChartNodeBL.GetMaxStrId_S();
 }
string strKey = clsge_StructureChartNodeBL.ge_StructureChartNodeDA.AddNewRecordBySQL2WithReturnKey(objge_StructureChartNodeEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsge_StructureChartNodeBL.ReFreshCache(objge_StructureChartNodeEN.StructureGraphId);

if (clsge_StructureChartNodeBL.relatedActions != null)
{
clsge_StructureChartNodeBL.relatedActions.UpdRelaTabDate(objge_StructureChartNodeEN.StructureNodeId, objge_StructureChartNodeEN.UpdUser);
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
 /// <param name = "objge_StructureChartNodeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsge_StructureChartNodeEN SetStructureNodeId(this clsge_StructureChartNodeEN objge_StructureChartNodeEN, string strStructureNodeId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strStructureNodeId, 10, conge_StructureChartNode.StructureNodeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strStructureNodeId, 10, conge_StructureChartNode.StructureNodeId);
}
objge_StructureChartNodeEN.StructureNodeId = strStructureNodeId; //结构Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objge_StructureChartNodeEN.dicFldComparisonOp.ContainsKey(conge_StructureChartNode.StructureNodeId) == false)
{
objge_StructureChartNodeEN.dicFldComparisonOp.Add(conge_StructureChartNode.StructureNodeId, strComparisonOp);
}
else
{
objge_StructureChartNodeEN.dicFldComparisonOp[conge_StructureChartNode.StructureNodeId] = strComparisonOp;
}
}
return objge_StructureChartNodeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objge_StructureChartNodeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsge_StructureChartNodeEN SetStructureNodeName(this clsge_StructureChartNodeEN objge_StructureChartNodeEN, string strStructureNodeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strStructureNodeName, conge_StructureChartNode.StructureNodeName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strStructureNodeName, 50, conge_StructureChartNode.StructureNodeName);
}
objge_StructureChartNodeEN.StructureNodeName = strStructureNodeName; //结构名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objge_StructureChartNodeEN.dicFldComparisonOp.ContainsKey(conge_StructureChartNode.StructureNodeName) == false)
{
objge_StructureChartNodeEN.dicFldComparisonOp.Add(conge_StructureChartNode.StructureNodeName, strComparisonOp);
}
else
{
objge_StructureChartNodeEN.dicFldComparisonOp[conge_StructureChartNode.StructureNodeName] = strComparisonOp;
}
}
return objge_StructureChartNodeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objge_StructureChartNodeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsge_StructureChartNodeEN SetUpdDate(this clsge_StructureChartNodeEN objge_StructureChartNodeEN, string strUpdDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdDate, 20, conge_StructureChartNode.UpdDate);
}
objge_StructureChartNodeEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objge_StructureChartNodeEN.dicFldComparisonOp.ContainsKey(conge_StructureChartNode.UpdDate) == false)
{
objge_StructureChartNodeEN.dicFldComparisonOp.Add(conge_StructureChartNode.UpdDate, strComparisonOp);
}
else
{
objge_StructureChartNodeEN.dicFldComparisonOp[conge_StructureChartNode.UpdDate] = strComparisonOp;
}
}
return objge_StructureChartNodeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objge_StructureChartNodeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsge_StructureChartNodeEN SetUpdUser(this clsge_StructureChartNodeEN objge_StructureChartNodeEN, string strUpdUser, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdUser, 20, conge_StructureChartNode.UpdUser);
}
objge_StructureChartNodeEN.UpdUser = strUpdUser; //修改人
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objge_StructureChartNodeEN.dicFldComparisonOp.ContainsKey(conge_StructureChartNode.UpdUser) == false)
{
objge_StructureChartNodeEN.dicFldComparisonOp.Add(conge_StructureChartNode.UpdUser, strComparisonOp);
}
else
{
objge_StructureChartNodeEN.dicFldComparisonOp[conge_StructureChartNode.UpdUser] = strComparisonOp;
}
}
return objge_StructureChartNodeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objge_StructureChartNodeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsge_StructureChartNodeEN SetMemo(this clsge_StructureChartNodeEN objge_StructureChartNodeEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, conge_StructureChartNode.Memo);
}
objge_StructureChartNodeEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objge_StructureChartNodeEN.dicFldComparisonOp.ContainsKey(conge_StructureChartNode.Memo) == false)
{
objge_StructureChartNodeEN.dicFldComparisonOp.Add(conge_StructureChartNode.Memo, strComparisonOp);
}
else
{
objge_StructureChartNodeEN.dicFldComparisonOp[conge_StructureChartNode.Memo] = strComparisonOp;
}
}
return objge_StructureChartNodeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objge_StructureChartNodeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsge_StructureChartNodeEN SetParentId(this clsge_StructureChartNodeEN objge_StructureChartNodeEN, string strParentId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strParentId, conge_StructureChartNode.ParentId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strParentId, 10, conge_StructureChartNode.ParentId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strParentId, 10, conge_StructureChartNode.ParentId);
}
objge_StructureChartNodeEN.ParentId = strParentId; //父节点Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objge_StructureChartNodeEN.dicFldComparisonOp.ContainsKey(conge_StructureChartNode.ParentId) == false)
{
objge_StructureChartNodeEN.dicFldComparisonOp.Add(conge_StructureChartNode.ParentId, strComparisonOp);
}
else
{
objge_StructureChartNodeEN.dicFldComparisonOp[conge_StructureChartNode.ParentId] = strComparisonOp;
}
}
return objge_StructureChartNodeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objge_StructureChartNodeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsge_StructureChartNodeEN SetIsRoot(this clsge_StructureChartNodeEN objge_StructureChartNodeEN, bool bolIsRoot, string strComparisonOp="")
	{
objge_StructureChartNodeEN.IsRoot = bolIsRoot; //IsRoot
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objge_StructureChartNodeEN.dicFldComparisonOp.ContainsKey(conge_StructureChartNode.IsRoot) == false)
{
objge_StructureChartNodeEN.dicFldComparisonOp.Add(conge_StructureChartNode.IsRoot, strComparisonOp);
}
else
{
objge_StructureChartNodeEN.dicFldComparisonOp[conge_StructureChartNode.IsRoot] = strComparisonOp;
}
}
return objge_StructureChartNodeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objge_StructureChartNodeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsge_StructureChartNodeEN Setbackground(this clsge_StructureChartNodeEN objge_StructureChartNodeEN, string strbackground, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strbackground, 50, conge_StructureChartNode.background);
}
objge_StructureChartNodeEN.background = strbackground; //背景色
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objge_StructureChartNodeEN.dicFldComparisonOp.ContainsKey(conge_StructureChartNode.background) == false)
{
objge_StructureChartNodeEN.dicFldComparisonOp.Add(conge_StructureChartNode.background, strComparisonOp);
}
else
{
objge_StructureChartNodeEN.dicFldComparisonOp[conge_StructureChartNode.background] = strComparisonOp;
}
}
return objge_StructureChartNodeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objge_StructureChartNodeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsge_StructureChartNodeEN Setforeground(this clsge_StructureChartNodeEN objge_StructureChartNodeEN, string strforeground, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strforeground, 50, conge_StructureChartNode.foreground);
}
objge_StructureChartNodeEN.foreground = strforeground; //背景字颜色
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objge_StructureChartNodeEN.dicFldComparisonOp.ContainsKey(conge_StructureChartNode.foreground) == false)
{
objge_StructureChartNodeEN.dicFldComparisonOp.Add(conge_StructureChartNode.foreground, strComparisonOp);
}
else
{
objge_StructureChartNodeEN.dicFldComparisonOp[conge_StructureChartNode.foreground] = strComparisonOp;
}
}
return objge_StructureChartNodeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objge_StructureChartNodeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsge_StructureChartNodeEN SetStructureGraphId(this clsge_StructureChartNodeEN objge_StructureChartNodeEN, string strStructureGraphId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strStructureGraphId, conge_StructureChartNode.StructureGraphId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strStructureGraphId, 10, conge_StructureChartNode.StructureGraphId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strStructureGraphId, 10, conge_StructureChartNode.StructureGraphId);
}
objge_StructureChartNodeEN.StructureGraphId = strStructureGraphId; //知识图谱Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objge_StructureChartNodeEN.dicFldComparisonOp.ContainsKey(conge_StructureChartNode.StructureGraphId) == false)
{
objge_StructureChartNodeEN.dicFldComparisonOp.Add(conge_StructureChartNode.StructureGraphId, strComparisonOp);
}
else
{
objge_StructureChartNodeEN.dicFldComparisonOp[conge_StructureChartNode.StructureGraphId] = strComparisonOp;
}
}
return objge_StructureChartNodeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objge_StructureChartNodeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsge_StructureChartNodeEN SetDirection(this clsge_StructureChartNodeEN objge_StructureChartNodeEN, string strDirection, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strDirection, 50, conge_StructureChartNode.Direction);
}
objge_StructureChartNodeEN.Direction = strDirection; //方向
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objge_StructureChartNodeEN.dicFldComparisonOp.ContainsKey(conge_StructureChartNode.Direction) == false)
{
objge_StructureChartNodeEN.dicFldComparisonOp.Add(conge_StructureChartNode.Direction, strComparisonOp);
}
else
{
objge_StructureChartNodeEN.dicFldComparisonOp[conge_StructureChartNode.Direction] = strComparisonOp;
}
}
return objge_StructureChartNodeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objge_StructureChartNodeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsge_StructureChartNodeEN SetIsExpanded(this clsge_StructureChartNodeEN objge_StructureChartNodeEN, bool bolIsExpanded, string strComparisonOp="")
	{
objge_StructureChartNodeEN.IsExpanded = bolIsExpanded; //是否扩展
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objge_StructureChartNodeEN.dicFldComparisonOp.ContainsKey(conge_StructureChartNode.IsExpanded) == false)
{
objge_StructureChartNodeEN.dicFldComparisonOp.Add(conge_StructureChartNode.IsExpanded, strComparisonOp);
}
else
{
objge_StructureChartNodeEN.dicFldComparisonOp[conge_StructureChartNode.IsExpanded] = strComparisonOp;
}
}
return objge_StructureChartNodeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objge_StructureChartNodeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsge_StructureChartNodeEN SetStructureSectionId(this clsge_StructureChartNodeEN objge_StructureChartNodeEN, string strStructureSectionId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strStructureSectionId, 10, conge_StructureChartNode.StructureSectionId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strStructureSectionId, 10, conge_StructureChartNode.StructureSectionId);
}
objge_StructureChartNodeEN.StructureSectionId = strStructureSectionId; //结构章节Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objge_StructureChartNodeEN.dicFldComparisonOp.ContainsKey(conge_StructureChartNode.StructureSectionId) == false)
{
objge_StructureChartNodeEN.dicFldComparisonOp.Add(conge_StructureChartNode.StructureSectionId, strComparisonOp);
}
else
{
objge_StructureChartNodeEN.dicFldComparisonOp[conge_StructureChartNode.StructureSectionId] = strComparisonOp;
}
}
return objge_StructureChartNodeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objge_StructureChartNodeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsge_StructureChartNodeEN SetOrderNum(this clsge_StructureChartNodeEN objge_StructureChartNodeEN, int? intOrderNum, string strComparisonOp="")
	{
objge_StructureChartNodeEN.OrderNum = intOrderNum; //序号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objge_StructureChartNodeEN.dicFldComparisonOp.ContainsKey(conge_StructureChartNode.OrderNum) == false)
{
objge_StructureChartNodeEN.dicFldComparisonOp.Add(conge_StructureChartNode.OrderNum, strComparisonOp);
}
else
{
objge_StructureChartNodeEN.dicFldComparisonOp[conge_StructureChartNode.OrderNum] = strComparisonOp;
}
}
return objge_StructureChartNodeEN;
	}

 /// <summary>
 /// 修改记录存盘到数据表中
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_UpdateRecordEx)
 /// </summary>
 /// <param name = "objge_StructureChartNodeEN">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool UpdateRecordEx(this clsge_StructureChartNodeEN objge_StructureChartNodeEN)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
try
{
//1、检查传进去的对象属性是否合法
objge_StructureChartNodeEN.CheckPropertyNew();
clsge_StructureChartNodeEN objge_StructureChartNodeCond = new clsge_StructureChartNodeEN();
string strCondition = objge_StructureChartNodeCond
.SetStructureNodeId(objge_StructureChartNodeEN.StructureNodeId, "<>")
.SetStructureNodeName(objge_StructureChartNodeEN.StructureNodeName, "=")
.GetCombineCondition();
objge_StructureChartNodeEN._IsCheckProperty = true;
bool bolIsExist = clsge_StructureChartNodeBL.IsExistRecord(strCondition);
if (bolIsExist)
{
strMsg = "(StructureNodeName)不能重复!";
throw new Exception(strMsg);
}
//4、把数据实体层的数据存贮到数据库中
objge_StructureChartNodeEN.Update();
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
 /// <param name = "objge_StructureChartNode">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool EditRecordEx(this clsge_StructureChartNodeEN objge_StructureChartNode)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
clsge_StructureChartNodeEN objge_StructureChartNodeCond = new clsge_StructureChartNodeEN();
string strCondition = objge_StructureChartNodeCond
.SetStructureNodeName(objge_StructureChartNode.StructureNodeName, "=")
.GetCombineCondition();
objge_StructureChartNode._IsCheckProperty = true;
bool bolIsExist = clsge_StructureChartNodeBL.IsExistRecord(strCondition);
if (bolIsExist)
{
objge_StructureChartNode.StructureNodeId = clsge_StructureChartNodeBL.GetFirstID_S(strCondition);
objge_StructureChartNode.UpdateWithCondition(strCondition);
}
else
{
objge_StructureChartNode.StructureNodeId = clsge_StructureChartNodeBL.GetMaxStrId_S();
objge_StructureChartNode.AddNewRecord();
}
return true; 
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_Update)
 /// </summary>
 /// <param name = "objge_StructureChartNodeEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsge_StructureChartNodeEN objge_StructureChartNodeEN)
{
 if (string.IsNullOrEmpty(objge_StructureChartNodeEN.StructureNodeId) == true)
 {
string strMsg = string.Format("(errid:Busi000095)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsge_StructureChartNodeBL.ge_StructureChartNodeDA.UpdateBySql2(objge_StructureChartNodeEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsge_StructureChartNodeBL.ReFreshCache(objge_StructureChartNodeEN.StructureGraphId);

if (clsge_StructureChartNodeBL.relatedActions != null)
{
clsge_StructureChartNodeBL.relatedActions.UpdRelaTabDate(objge_StructureChartNodeEN.StructureNodeId, objge_StructureChartNodeEN.UpdUser);
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
 /// <param name = "objge_StructureChartNodeEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsge_StructureChartNodeEN objge_StructureChartNodeEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (string.IsNullOrEmpty(objge_StructureChartNodeEN.StructureNodeId) == true)
 {
string strMsg = string.Format("(errid:Busi000087)修改记录时关键字不能为空!(带事务处理)(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsge_StructureChartNodeBL.ge_StructureChartNodeDA.UpdateBySql2(objge_StructureChartNodeEN, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsge_StructureChartNodeBL.ReFreshCache(objge_StructureChartNodeEN.StructureGraphId);

if (clsge_StructureChartNodeBL.relatedActions != null)
{
clsge_StructureChartNodeBL.relatedActions.UpdRelaTabDate(objge_StructureChartNodeEN.StructureNodeId, objge_StructureChartNodeEN.UpdUser);
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
 /// <param name = "objge_StructureChartNodeEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsge_StructureChartNodeEN objge_StructureChartNodeEN, string strWhereCond)
{
try
{
bool bolResult = clsge_StructureChartNodeBL.ge_StructureChartNodeDA.UpdateBySqlWithCondition(objge_StructureChartNodeEN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsge_StructureChartNodeBL.ReFreshCache(objge_StructureChartNodeEN.StructureGraphId);

if (clsge_StructureChartNodeBL.relatedActions != null)
{
clsge_StructureChartNodeBL.relatedActions.UpdRelaTabDate(objge_StructureChartNodeEN.StructureNodeId, objge_StructureChartNodeEN.UpdUser);
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
 /// <param name = "objge_StructureChartNodeEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsge_StructureChartNodeEN objge_StructureChartNodeEN, string strWhereCond, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
bool bolResult = clsge_StructureChartNodeBL.ge_StructureChartNodeDA.UpdateBySqlWithConditionTransaction(objge_StructureChartNodeEN, strWhereCond, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsge_StructureChartNodeBL.ReFreshCache(objge_StructureChartNodeEN.StructureGraphId);

if (clsge_StructureChartNodeBL.relatedActions != null)
{
clsge_StructureChartNodeBL.relatedActions.UpdRelaTabDate(objge_StructureChartNodeEN.StructureNodeId, objge_StructureChartNodeEN.UpdUser);
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
 /// <param name = "strStructureNodeId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int Delete(this clsge_StructureChartNodeEN objge_StructureChartNodeEN)
{
try
{
int intRecNum = clsge_StructureChartNodeBL.ge_StructureChartNodeDA.DelRecord(objge_StructureChartNodeEN.StructureNodeId);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsge_StructureChartNodeBL.ReFreshCache(objge_StructureChartNodeEN.StructureGraphId);

if (clsge_StructureChartNodeBL.relatedActions != null)
{
clsge_StructureChartNodeBL.relatedActions.UpdRelaTabDate(objge_StructureChartNodeEN.StructureNodeId, objge_StructureChartNodeEN.UpdUser);
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
 /// <param name = "objge_StructureChartNodeENS">源对象</param>
 /// <param name = "objge_StructureChartNodeENT">目标对象</param>
 public static void CopyTo(this clsge_StructureChartNodeEN objge_StructureChartNodeENS, clsge_StructureChartNodeEN objge_StructureChartNodeENT)
{
try
{
objge_StructureChartNodeENT.StructureNodeId = objge_StructureChartNodeENS.StructureNodeId; //结构Id
objge_StructureChartNodeENT.StructureNodeName = objge_StructureChartNodeENS.StructureNodeName; //结构名称
objge_StructureChartNodeENT.UpdDate = objge_StructureChartNodeENS.UpdDate; //修改日期
objge_StructureChartNodeENT.UpdUser = objge_StructureChartNodeENS.UpdUser; //修改人
objge_StructureChartNodeENT.Memo = objge_StructureChartNodeENS.Memo; //备注
objge_StructureChartNodeENT.ParentId = objge_StructureChartNodeENS.ParentId; //父节点Id
objge_StructureChartNodeENT.IsRoot = objge_StructureChartNodeENS.IsRoot; //IsRoot
objge_StructureChartNodeENT.background = objge_StructureChartNodeENS.background; //背景色
objge_StructureChartNodeENT.foreground = objge_StructureChartNodeENS.foreground; //背景字颜色
objge_StructureChartNodeENT.StructureGraphId = objge_StructureChartNodeENS.StructureGraphId; //知识图谱Id
objge_StructureChartNodeENT.Direction = objge_StructureChartNodeENS.Direction; //方向
objge_StructureChartNodeENT.IsExpanded = objge_StructureChartNodeENS.IsExpanded; //是否扩展
objge_StructureChartNodeENT.StructureSectionId = objge_StructureChartNodeENS.StructureSectionId; //结构章节Id
objge_StructureChartNodeENT.OrderNum = objge_StructureChartNodeENS.OrderNum; //序号
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
 /// <param name = "objge_StructureChartNodeENS">源对象</param>
 /// <returns>目标对象=>clsge_StructureChartNodeEN:objge_StructureChartNodeENT</returns>
 public static clsge_StructureChartNodeEN CopyTo(this clsge_StructureChartNodeEN objge_StructureChartNodeENS)
{
try
{
 clsge_StructureChartNodeEN objge_StructureChartNodeENT = new clsge_StructureChartNodeEN()
{
StructureNodeId = objge_StructureChartNodeENS.StructureNodeId, //结构Id
StructureNodeName = objge_StructureChartNodeENS.StructureNodeName, //结构名称
UpdDate = objge_StructureChartNodeENS.UpdDate, //修改日期
UpdUser = objge_StructureChartNodeENS.UpdUser, //修改人
Memo = objge_StructureChartNodeENS.Memo, //备注
ParentId = objge_StructureChartNodeENS.ParentId, //父节点Id
IsRoot = objge_StructureChartNodeENS.IsRoot, //IsRoot
background = objge_StructureChartNodeENS.background, //背景色
foreground = objge_StructureChartNodeENS.foreground, //背景字颜色
StructureGraphId = objge_StructureChartNodeENS.StructureGraphId, //知识图谱Id
Direction = objge_StructureChartNodeENS.Direction, //方向
IsExpanded = objge_StructureChartNodeENS.IsExpanded, //是否扩展
StructureSectionId = objge_StructureChartNodeENS.StructureSectionId, //结构章节Id
OrderNum = objge_StructureChartNodeENS.OrderNum, //序号
};
 return objge_StructureChartNodeENT;
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
public static void CheckPropertyNew(this clsge_StructureChartNodeEN objge_StructureChartNodeEN)
{
 clsge_StructureChartNodeBL.ge_StructureChartNodeDA.CheckPropertyNew(objge_StructureChartNodeEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(this clsge_StructureChartNodeEN objge_StructureChartNodeEN)
{
 clsge_StructureChartNodeBL.ge_StructureChartNodeDA.CheckProperty4Condition(objge_StructureChartNodeEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsge_StructureChartNodeEN objge_StructureChartNodeCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objge_StructureChartNodeCond.IsUpdated(conge_StructureChartNode.StructureNodeId) == true)
{
string strComparisonOpStructureNodeId = objge_StructureChartNodeCond.dicFldComparisonOp[conge_StructureChartNode.StructureNodeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conge_StructureChartNode.StructureNodeId, objge_StructureChartNodeCond.StructureNodeId, strComparisonOpStructureNodeId);
}
if (objge_StructureChartNodeCond.IsUpdated(conge_StructureChartNode.StructureNodeName) == true)
{
string strComparisonOpStructureNodeName = objge_StructureChartNodeCond.dicFldComparisonOp[conge_StructureChartNode.StructureNodeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", conge_StructureChartNode.StructureNodeName, objge_StructureChartNodeCond.StructureNodeName, strComparisonOpStructureNodeName);
}
if (objge_StructureChartNodeCond.IsUpdated(conge_StructureChartNode.UpdDate) == true)
{
string strComparisonOpUpdDate = objge_StructureChartNodeCond.dicFldComparisonOp[conge_StructureChartNode.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conge_StructureChartNode.UpdDate, objge_StructureChartNodeCond.UpdDate, strComparisonOpUpdDate);
}
if (objge_StructureChartNodeCond.IsUpdated(conge_StructureChartNode.UpdUser) == true)
{
string strComparisonOpUpdUser = objge_StructureChartNodeCond.dicFldComparisonOp[conge_StructureChartNode.UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", conge_StructureChartNode.UpdUser, objge_StructureChartNodeCond.UpdUser, strComparisonOpUpdUser);
}
if (objge_StructureChartNodeCond.IsUpdated(conge_StructureChartNode.Memo) == true)
{
string strComparisonOpMemo = objge_StructureChartNodeCond.dicFldComparisonOp[conge_StructureChartNode.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", conge_StructureChartNode.Memo, objge_StructureChartNodeCond.Memo, strComparisonOpMemo);
}
if (objge_StructureChartNodeCond.IsUpdated(conge_StructureChartNode.ParentId) == true)
{
string strComparisonOpParentId = objge_StructureChartNodeCond.dicFldComparisonOp[conge_StructureChartNode.ParentId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conge_StructureChartNode.ParentId, objge_StructureChartNodeCond.ParentId, strComparisonOpParentId);
}
if (objge_StructureChartNodeCond.IsUpdated(conge_StructureChartNode.IsRoot) == true)
{
if (objge_StructureChartNodeCond.IsRoot == true)
{
strWhereCond += string.Format(" And {0} = '1'", conge_StructureChartNode.IsRoot);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conge_StructureChartNode.IsRoot);
}
}
if (objge_StructureChartNodeCond.IsUpdated(conge_StructureChartNode.background) == true)
{
string strComparisonOpbackground = objge_StructureChartNodeCond.dicFldComparisonOp[conge_StructureChartNode.background];
strWhereCond += string.Format(" And {0} {2} '{1}'", conge_StructureChartNode.background, objge_StructureChartNodeCond.background, strComparisonOpbackground);
}
if (objge_StructureChartNodeCond.IsUpdated(conge_StructureChartNode.foreground) == true)
{
string strComparisonOpforeground = objge_StructureChartNodeCond.dicFldComparisonOp[conge_StructureChartNode.foreground];
strWhereCond += string.Format(" And {0} {2} '{1}'", conge_StructureChartNode.foreground, objge_StructureChartNodeCond.foreground, strComparisonOpforeground);
}
if (objge_StructureChartNodeCond.IsUpdated(conge_StructureChartNode.StructureGraphId) == true)
{
string strComparisonOpStructureGraphId = objge_StructureChartNodeCond.dicFldComparisonOp[conge_StructureChartNode.StructureGraphId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conge_StructureChartNode.StructureGraphId, objge_StructureChartNodeCond.StructureGraphId, strComparisonOpStructureGraphId);
}
if (objge_StructureChartNodeCond.IsUpdated(conge_StructureChartNode.Direction) == true)
{
string strComparisonOpDirection = objge_StructureChartNodeCond.dicFldComparisonOp[conge_StructureChartNode.Direction];
strWhereCond += string.Format(" And {0} {2} '{1}'", conge_StructureChartNode.Direction, objge_StructureChartNodeCond.Direction, strComparisonOpDirection);
}
if (objge_StructureChartNodeCond.IsUpdated(conge_StructureChartNode.IsExpanded) == true)
{
if (objge_StructureChartNodeCond.IsExpanded == true)
{
strWhereCond += string.Format(" And {0} = '1'", conge_StructureChartNode.IsExpanded);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conge_StructureChartNode.IsExpanded);
}
}
if (objge_StructureChartNodeCond.IsUpdated(conge_StructureChartNode.StructureSectionId) == true)
{
string strComparisonOpStructureSectionId = objge_StructureChartNodeCond.dicFldComparisonOp[conge_StructureChartNode.StructureSectionId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conge_StructureChartNode.StructureSectionId, objge_StructureChartNodeCond.StructureSectionId, strComparisonOpStructureSectionId);
}
if (objge_StructureChartNodeCond.IsUpdated(conge_StructureChartNode.OrderNum) == true)
{
string strComparisonOpOrderNum = objge_StructureChartNodeCond.dicFldComparisonOp[conge_StructureChartNode.OrderNum];
strWhereCond += string.Format(" And {0} {2} {1}", conge_StructureChartNode.OrderNum, objge_StructureChartNodeCond.OrderNum, strComparisonOpOrderNum);
}
 return strWhereCond;
}

 /// <summary>
 /// 检查唯一性(Uniqueness)--ge_StructureChartNode(知识点结构图), 如果不唯一,即存在相同的记录,就返回False
 /// 唯一性条件:StructureNodeName
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckConstraint)
 /// </summary>
 /// <param name = "objge_StructureChartNodeEN">要求唯一的对象</param>
 /// <returns></returns>
public static bool CheckUniqueness(this clsge_StructureChartNodeEN objge_StructureChartNodeEN)
{
//检测记录是否存在
bool bolIsUniqueness;
StringBuilder sbCondition = new StringBuilder();
if (objge_StructureChartNodeEN == null) return true;
if (objge_StructureChartNodeEN.StructureNodeId == null || objge_StructureChartNodeEN.StructureNodeId == "")
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and StructureNodeName = '{0}'", objge_StructureChartNodeEN.StructureNodeName);
if (clsge_StructureChartNodeBL.IsExistRecord(sbCondition.ToString())  ==  true)
{
 bolIsUniqueness = false;
}
else
{
 bolIsUniqueness = true;
}
}
 else {
sbCondition.AppendFormat("StructureNodeId !=  '{0}'", objge_StructureChartNodeEN.StructureNodeId);
 sbCondition.AppendFormat(" and StructureNodeName = '{0}'", objge_StructureChartNodeEN.StructureNodeName);
if (clsge_StructureChartNodeBL.IsExistRecord(sbCondition.ToString())  ==  true)
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
 /// 获取唯一性条件串--ge_StructureChartNode(知识点结构图), 即由对象中唯一性条件字段关键字与值组成的条件串
 /// 唯一性条件:StructureNodeName
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetConditionString4Constraint)
 /// </summary>
 /// <param name = "objge_StructureChartNodeEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(this clsge_StructureChartNodeEN objge_StructureChartNodeEN)
{
//检测记录是否存在
StringBuilder sbCondition = new StringBuilder();
if (objge_StructureChartNodeEN == null) return "";
if (objge_StructureChartNodeEN.StructureNodeId == null || objge_StructureChartNodeEN.StructureNodeId == "")
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and StructureNodeName = '{0}'", objge_StructureChartNodeEN.StructureNodeName);
return sbCondition.ToString();
}
 else {
sbCondition.AppendFormat("StructureNodeId !=  '{0}'", objge_StructureChartNodeEN.StructureNodeId);
 sbCondition.AppendFormat(" and StructureNodeName = '{0}'", objge_StructureChartNodeEN.StructureNodeName);
 return sbCondition.ToString();
}
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_ge_StructureChartNode
{
public virtual bool UpdRelaTabDate(string strStructureNodeId, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// 知识点结构图(ge_StructureChartNode)
 /// 数据源类型:表
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsge_StructureChartNodeBL
{
public static RelatedActions_ge_StructureChartNode relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsge_StructureChartNodeDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsge_StructureChartNodeDA ge_StructureChartNodeDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsge_StructureChartNodeDA();
}
return uniqueInstance;
}
}

 /// <summary>
/// 专门在逻辑层用于处理缓存等公共函数的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineObjCommFun4BL)
/// </summary>
public static clsCommFun4BLV2 objCommFun4BL = null;

 /// <summary>
 /// 类的构造函数
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ClassConstructor1)
 /// </summary>
 public clsge_StructureChartNodeBL()
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
if (string.IsNullOrEmpty(clsge_StructureChartNodeEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsge_StructureChartNodeEN._ConnectString);
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
public static DataTable GetDataTable_ge_StructureChartNode(string strWhereCond)
{
DataTable objDT;
try
{
objDT = ge_StructureChartNodeDA.GetDataTable_ge_StructureChartNode(strWhereCond);
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
objDT = ge_StructureChartNodeDA.GetDataTable(strWhereCond);
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
objDT = ge_StructureChartNodeDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = ge_StructureChartNodeDA.GetDataTable(strWhereCond, strTabName);
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
objDT = ge_StructureChartNodeDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = ge_StructureChartNodeDA.GetDataTable_Top(objTopPara);
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
objDT = ge_StructureChartNodeDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = ge_StructureChartNodeDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = ge_StructureChartNodeDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
 /// <param name = "arrStructureNodeIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static List<clsge_StructureChartNodeEN> GetObjLstByStructureNodeIdLst(List<string> arrStructureNodeIdLst)
{
List<clsge_StructureChartNodeEN> arrObjLst = new List<clsge_StructureChartNodeEN>(); 
System.Data.DataTable objDT; 
 string strSqlConditionStr = clsArray.GetSqlInStrByArray(arrStructureNodeIdLst, true);
 string strWhereCond = string.Format("StructureNodeId in ({0})", strSqlConditionStr);
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsge_StructureChartNodeEN objge_StructureChartNodeEN = new clsge_StructureChartNodeEN();
try
{
objge_StructureChartNodeEN.StructureNodeId = objRow[conge_StructureChartNode.StructureNodeId].ToString().Trim(); //结构Id
objge_StructureChartNodeEN.StructureNodeName = objRow[conge_StructureChartNode.StructureNodeName].ToString().Trim(); //结构名称
objge_StructureChartNodeEN.UpdDate = objRow[conge_StructureChartNode.UpdDate] == DBNull.Value ? null : objRow[conge_StructureChartNode.UpdDate].ToString().Trim(); //修改日期
objge_StructureChartNodeEN.UpdUser = objRow[conge_StructureChartNode.UpdUser] == DBNull.Value ? null : objRow[conge_StructureChartNode.UpdUser].ToString().Trim(); //修改人
objge_StructureChartNodeEN.Memo = objRow[conge_StructureChartNode.Memo] == DBNull.Value ? null : objRow[conge_StructureChartNode.Memo].ToString().Trim(); //备注
objge_StructureChartNodeEN.ParentId = objRow[conge_StructureChartNode.ParentId].ToString().Trim(); //父节点Id
objge_StructureChartNodeEN.IsRoot = clsEntityBase2.TransNullToBool_S(objRow[conge_StructureChartNode.IsRoot].ToString().Trim()); //IsRoot
objge_StructureChartNodeEN.background = objRow[conge_StructureChartNode.background] == DBNull.Value ? null : objRow[conge_StructureChartNode.background].ToString().Trim(); //背景色
objge_StructureChartNodeEN.foreground = objRow[conge_StructureChartNode.foreground] == DBNull.Value ? null : objRow[conge_StructureChartNode.foreground].ToString().Trim(); //背景字颜色
objge_StructureChartNodeEN.StructureGraphId = objRow[conge_StructureChartNode.StructureGraphId].ToString().Trim(); //知识图谱Id
objge_StructureChartNodeEN.Direction = objRow[conge_StructureChartNode.Direction] == DBNull.Value ? null : objRow[conge_StructureChartNode.Direction].ToString().Trim(); //方向
objge_StructureChartNodeEN.IsExpanded = clsEntityBase2.TransNullToBool_S(objRow[conge_StructureChartNode.IsExpanded].ToString().Trim()); //是否扩展
objge_StructureChartNodeEN.StructureSectionId = objRow[conge_StructureChartNode.StructureSectionId] == DBNull.Value ? null : objRow[conge_StructureChartNode.StructureSectionId].ToString().Trim(); //结构章节Id
objge_StructureChartNodeEN.OrderNum = objRow[conge_StructureChartNode.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conge_StructureChartNode.OrderNum].ToString().Trim()); //序号
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objge_StructureChartNodeEN.StructureNodeId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objge_StructureChartNodeEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrStructureNodeIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsge_StructureChartNodeEN> GetObjLstByStructureNodeIdLstCache(List<string> arrStructureNodeIdLst, string strStructureGraphId)
{
string strKey = string.Format("{0}_{1}", clsge_StructureChartNodeEN._CurrTabName, strStructureGraphId);
List<clsge_StructureChartNodeEN> arrge_StructureChartNodeObjLstCache = GetObjLstCache(strStructureGraphId);
IEnumerable <clsge_StructureChartNodeEN> arrge_StructureChartNodeObjLst_Sel =
arrge_StructureChartNodeObjLstCache
.Where(x => arrStructureNodeIdLst.Contains(x.StructureNodeId));
return arrge_StructureChartNodeObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsge_StructureChartNodeEN> GetObjLst(string strWhereCond)
{
List<clsge_StructureChartNodeEN> arrObjLst = new List<clsge_StructureChartNodeEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsge_StructureChartNodeEN objge_StructureChartNodeEN = new clsge_StructureChartNodeEN();
try
{
objge_StructureChartNodeEN.StructureNodeId = objRow[conge_StructureChartNode.StructureNodeId].ToString().Trim(); //结构Id
objge_StructureChartNodeEN.StructureNodeName = objRow[conge_StructureChartNode.StructureNodeName].ToString().Trim(); //结构名称
objge_StructureChartNodeEN.UpdDate = objRow[conge_StructureChartNode.UpdDate] == DBNull.Value ? null : objRow[conge_StructureChartNode.UpdDate].ToString().Trim(); //修改日期
objge_StructureChartNodeEN.UpdUser = objRow[conge_StructureChartNode.UpdUser] == DBNull.Value ? null : objRow[conge_StructureChartNode.UpdUser].ToString().Trim(); //修改人
objge_StructureChartNodeEN.Memo = objRow[conge_StructureChartNode.Memo] == DBNull.Value ? null : objRow[conge_StructureChartNode.Memo].ToString().Trim(); //备注
objge_StructureChartNodeEN.ParentId = objRow[conge_StructureChartNode.ParentId].ToString().Trim(); //父节点Id
objge_StructureChartNodeEN.IsRoot = clsEntityBase2.TransNullToBool_S(objRow[conge_StructureChartNode.IsRoot].ToString().Trim()); //IsRoot
objge_StructureChartNodeEN.background = objRow[conge_StructureChartNode.background] == DBNull.Value ? null : objRow[conge_StructureChartNode.background].ToString().Trim(); //背景色
objge_StructureChartNodeEN.foreground = objRow[conge_StructureChartNode.foreground] == DBNull.Value ? null : objRow[conge_StructureChartNode.foreground].ToString().Trim(); //背景字颜色
objge_StructureChartNodeEN.StructureGraphId = objRow[conge_StructureChartNode.StructureGraphId].ToString().Trim(); //知识图谱Id
objge_StructureChartNodeEN.Direction = objRow[conge_StructureChartNode.Direction] == DBNull.Value ? null : objRow[conge_StructureChartNode.Direction].ToString().Trim(); //方向
objge_StructureChartNodeEN.IsExpanded = clsEntityBase2.TransNullToBool_S(objRow[conge_StructureChartNode.IsExpanded].ToString().Trim()); //是否扩展
objge_StructureChartNodeEN.StructureSectionId = objRow[conge_StructureChartNode.StructureSectionId] == DBNull.Value ? null : objRow[conge_StructureChartNode.StructureSectionId].ToString().Trim(); //结构章节Id
objge_StructureChartNodeEN.OrderNum = objRow[conge_StructureChartNode.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conge_StructureChartNode.OrderNum].ToString().Trim()); //序号
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objge_StructureChartNodeEN.StructureNodeId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objge_StructureChartNodeEN);
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
public static List<clsge_StructureChartNodeEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsge_StructureChartNodeEN> arrObjLst = new List<clsge_StructureChartNodeEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsge_StructureChartNodeEN objge_StructureChartNodeEN = new clsge_StructureChartNodeEN();
try
{
objge_StructureChartNodeEN.StructureNodeId = objRow[conge_StructureChartNode.StructureNodeId].ToString().Trim(); //结构Id
objge_StructureChartNodeEN.StructureNodeName = objRow[conge_StructureChartNode.StructureNodeName].ToString().Trim(); //结构名称
objge_StructureChartNodeEN.UpdDate = objRow[conge_StructureChartNode.UpdDate] == DBNull.Value ? null : objRow[conge_StructureChartNode.UpdDate].ToString().Trim(); //修改日期
objge_StructureChartNodeEN.UpdUser = objRow[conge_StructureChartNode.UpdUser] == DBNull.Value ? null : objRow[conge_StructureChartNode.UpdUser].ToString().Trim(); //修改人
objge_StructureChartNodeEN.Memo = objRow[conge_StructureChartNode.Memo] == DBNull.Value ? null : objRow[conge_StructureChartNode.Memo].ToString().Trim(); //备注
objge_StructureChartNodeEN.ParentId = objRow[conge_StructureChartNode.ParentId].ToString().Trim(); //父节点Id
objge_StructureChartNodeEN.IsRoot = clsEntityBase2.TransNullToBool_S(objRow[conge_StructureChartNode.IsRoot].ToString().Trim()); //IsRoot
objge_StructureChartNodeEN.background = objRow[conge_StructureChartNode.background] == DBNull.Value ? null : objRow[conge_StructureChartNode.background].ToString().Trim(); //背景色
objge_StructureChartNodeEN.foreground = objRow[conge_StructureChartNode.foreground] == DBNull.Value ? null : objRow[conge_StructureChartNode.foreground].ToString().Trim(); //背景字颜色
objge_StructureChartNodeEN.StructureGraphId = objRow[conge_StructureChartNode.StructureGraphId].ToString().Trim(); //知识图谱Id
objge_StructureChartNodeEN.Direction = objRow[conge_StructureChartNode.Direction] == DBNull.Value ? null : objRow[conge_StructureChartNode.Direction].ToString().Trim(); //方向
objge_StructureChartNodeEN.IsExpanded = clsEntityBase2.TransNullToBool_S(objRow[conge_StructureChartNode.IsExpanded].ToString().Trim()); //是否扩展
objge_StructureChartNodeEN.StructureSectionId = objRow[conge_StructureChartNode.StructureSectionId] == DBNull.Value ? null : objRow[conge_StructureChartNode.StructureSectionId].ToString().Trim(); //结构章节Id
objge_StructureChartNodeEN.OrderNum = objRow[conge_StructureChartNode.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conge_StructureChartNode.OrderNum].ToString().Trim()); //序号
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objge_StructureChartNodeEN.StructureNodeId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objge_StructureChartNodeEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objge_StructureChartNodeCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsge_StructureChartNodeEN> GetSubObjLstCache(clsge_StructureChartNodeEN objge_StructureChartNodeCond)
{
 string strStructureGraphId = objge_StructureChartNodeCond.StructureGraphId;
 if (string.IsNullOrEmpty(strStructureGraphId) == true)
{
string strMsg = string.Format("(errid:Busi000172)在表中,缓存分类字段值不能为空!(clsge_StructureChartNodeBL:GetSubObjLstCache)");
throw new Exception(strMsg);
}
List<clsge_StructureChartNodeEN> arrObjLstCache = GetObjLstCache(strStructureGraphId);
IEnumerable <clsge_StructureChartNodeEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conge_StructureChartNode.AttributeName)
{
if (objge_StructureChartNodeCond.IsUpdated(strFldName) == false) continue;
if (objge_StructureChartNodeCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objge_StructureChartNodeCond[strFldName].ToString());
}
else
{
if (objge_StructureChartNodeCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objge_StructureChartNodeCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objge_StructureChartNodeCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objge_StructureChartNodeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objge_StructureChartNodeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objge_StructureChartNodeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objge_StructureChartNodeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objge_StructureChartNodeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objge_StructureChartNodeCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objge_StructureChartNodeCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objge_StructureChartNodeCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objge_StructureChartNodeCond[strFldName]));
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
public static List<clsge_StructureChartNodeEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsge_StructureChartNodeEN> arrObjLst = new List<clsge_StructureChartNodeEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsge_StructureChartNodeEN objge_StructureChartNodeEN = new clsge_StructureChartNodeEN();
try
{
objge_StructureChartNodeEN.StructureNodeId = objRow[conge_StructureChartNode.StructureNodeId].ToString().Trim(); //结构Id
objge_StructureChartNodeEN.StructureNodeName = objRow[conge_StructureChartNode.StructureNodeName].ToString().Trim(); //结构名称
objge_StructureChartNodeEN.UpdDate = objRow[conge_StructureChartNode.UpdDate] == DBNull.Value ? null : objRow[conge_StructureChartNode.UpdDate].ToString().Trim(); //修改日期
objge_StructureChartNodeEN.UpdUser = objRow[conge_StructureChartNode.UpdUser] == DBNull.Value ? null : objRow[conge_StructureChartNode.UpdUser].ToString().Trim(); //修改人
objge_StructureChartNodeEN.Memo = objRow[conge_StructureChartNode.Memo] == DBNull.Value ? null : objRow[conge_StructureChartNode.Memo].ToString().Trim(); //备注
objge_StructureChartNodeEN.ParentId = objRow[conge_StructureChartNode.ParentId].ToString().Trim(); //父节点Id
objge_StructureChartNodeEN.IsRoot = clsEntityBase2.TransNullToBool_S(objRow[conge_StructureChartNode.IsRoot].ToString().Trim()); //IsRoot
objge_StructureChartNodeEN.background = objRow[conge_StructureChartNode.background] == DBNull.Value ? null : objRow[conge_StructureChartNode.background].ToString().Trim(); //背景色
objge_StructureChartNodeEN.foreground = objRow[conge_StructureChartNode.foreground] == DBNull.Value ? null : objRow[conge_StructureChartNode.foreground].ToString().Trim(); //背景字颜色
objge_StructureChartNodeEN.StructureGraphId = objRow[conge_StructureChartNode.StructureGraphId].ToString().Trim(); //知识图谱Id
objge_StructureChartNodeEN.Direction = objRow[conge_StructureChartNode.Direction] == DBNull.Value ? null : objRow[conge_StructureChartNode.Direction].ToString().Trim(); //方向
objge_StructureChartNodeEN.IsExpanded = clsEntityBase2.TransNullToBool_S(objRow[conge_StructureChartNode.IsExpanded].ToString().Trim()); //是否扩展
objge_StructureChartNodeEN.StructureSectionId = objRow[conge_StructureChartNode.StructureSectionId] == DBNull.Value ? null : objRow[conge_StructureChartNode.StructureSectionId].ToString().Trim(); //结构章节Id
objge_StructureChartNodeEN.OrderNum = objRow[conge_StructureChartNode.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conge_StructureChartNode.OrderNum].ToString().Trim()); //序号
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objge_StructureChartNodeEN.StructureNodeId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objge_StructureChartNodeEN);
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
public static List<clsge_StructureChartNodeEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsge_StructureChartNodeEN> arrObjLst = new List<clsge_StructureChartNodeEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsge_StructureChartNodeEN objge_StructureChartNodeEN = new clsge_StructureChartNodeEN();
try
{
objge_StructureChartNodeEN.StructureNodeId = objRow[conge_StructureChartNode.StructureNodeId].ToString().Trim(); //结构Id
objge_StructureChartNodeEN.StructureNodeName = objRow[conge_StructureChartNode.StructureNodeName].ToString().Trim(); //结构名称
objge_StructureChartNodeEN.UpdDate = objRow[conge_StructureChartNode.UpdDate] == DBNull.Value ? null : objRow[conge_StructureChartNode.UpdDate].ToString().Trim(); //修改日期
objge_StructureChartNodeEN.UpdUser = objRow[conge_StructureChartNode.UpdUser] == DBNull.Value ? null : objRow[conge_StructureChartNode.UpdUser].ToString().Trim(); //修改人
objge_StructureChartNodeEN.Memo = objRow[conge_StructureChartNode.Memo] == DBNull.Value ? null : objRow[conge_StructureChartNode.Memo].ToString().Trim(); //备注
objge_StructureChartNodeEN.ParentId = objRow[conge_StructureChartNode.ParentId].ToString().Trim(); //父节点Id
objge_StructureChartNodeEN.IsRoot = clsEntityBase2.TransNullToBool_S(objRow[conge_StructureChartNode.IsRoot].ToString().Trim()); //IsRoot
objge_StructureChartNodeEN.background = objRow[conge_StructureChartNode.background] == DBNull.Value ? null : objRow[conge_StructureChartNode.background].ToString().Trim(); //背景色
objge_StructureChartNodeEN.foreground = objRow[conge_StructureChartNode.foreground] == DBNull.Value ? null : objRow[conge_StructureChartNode.foreground].ToString().Trim(); //背景字颜色
objge_StructureChartNodeEN.StructureGraphId = objRow[conge_StructureChartNode.StructureGraphId].ToString().Trim(); //知识图谱Id
objge_StructureChartNodeEN.Direction = objRow[conge_StructureChartNode.Direction] == DBNull.Value ? null : objRow[conge_StructureChartNode.Direction].ToString().Trim(); //方向
objge_StructureChartNodeEN.IsExpanded = clsEntityBase2.TransNullToBool_S(objRow[conge_StructureChartNode.IsExpanded].ToString().Trim()); //是否扩展
objge_StructureChartNodeEN.StructureSectionId = objRow[conge_StructureChartNode.StructureSectionId] == DBNull.Value ? null : objRow[conge_StructureChartNode.StructureSectionId].ToString().Trim(); //结构章节Id
objge_StructureChartNodeEN.OrderNum = objRow[conge_StructureChartNode.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conge_StructureChartNode.OrderNum].ToString().Trim()); //序号
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objge_StructureChartNodeEN.StructureNodeId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objge_StructureChartNodeEN);
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
List<clsge_StructureChartNodeEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsge_StructureChartNodeEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsge_StructureChartNodeEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsge_StructureChartNodeEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsge_StructureChartNodeEN> arrObjLst = new List<clsge_StructureChartNodeEN>(); 
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
	clsge_StructureChartNodeEN objge_StructureChartNodeEN = new clsge_StructureChartNodeEN();
try
{
objge_StructureChartNodeEN.StructureNodeId = objRow[conge_StructureChartNode.StructureNodeId].ToString().Trim(); //结构Id
objge_StructureChartNodeEN.StructureNodeName = objRow[conge_StructureChartNode.StructureNodeName].ToString().Trim(); //结构名称
objge_StructureChartNodeEN.UpdDate = objRow[conge_StructureChartNode.UpdDate] == DBNull.Value ? null : objRow[conge_StructureChartNode.UpdDate].ToString().Trim(); //修改日期
objge_StructureChartNodeEN.UpdUser = objRow[conge_StructureChartNode.UpdUser] == DBNull.Value ? null : objRow[conge_StructureChartNode.UpdUser].ToString().Trim(); //修改人
objge_StructureChartNodeEN.Memo = objRow[conge_StructureChartNode.Memo] == DBNull.Value ? null : objRow[conge_StructureChartNode.Memo].ToString().Trim(); //备注
objge_StructureChartNodeEN.ParentId = objRow[conge_StructureChartNode.ParentId].ToString().Trim(); //父节点Id
objge_StructureChartNodeEN.IsRoot = clsEntityBase2.TransNullToBool_S(objRow[conge_StructureChartNode.IsRoot].ToString().Trim()); //IsRoot
objge_StructureChartNodeEN.background = objRow[conge_StructureChartNode.background] == DBNull.Value ? null : objRow[conge_StructureChartNode.background].ToString().Trim(); //背景色
objge_StructureChartNodeEN.foreground = objRow[conge_StructureChartNode.foreground] == DBNull.Value ? null : objRow[conge_StructureChartNode.foreground].ToString().Trim(); //背景字颜色
objge_StructureChartNodeEN.StructureGraphId = objRow[conge_StructureChartNode.StructureGraphId].ToString().Trim(); //知识图谱Id
objge_StructureChartNodeEN.Direction = objRow[conge_StructureChartNode.Direction] == DBNull.Value ? null : objRow[conge_StructureChartNode.Direction].ToString().Trim(); //方向
objge_StructureChartNodeEN.IsExpanded = clsEntityBase2.TransNullToBool_S(objRow[conge_StructureChartNode.IsExpanded].ToString().Trim()); //是否扩展
objge_StructureChartNodeEN.StructureSectionId = objRow[conge_StructureChartNode.StructureSectionId] == DBNull.Value ? null : objRow[conge_StructureChartNode.StructureSectionId].ToString().Trim(); //结构章节Id
objge_StructureChartNodeEN.OrderNum = objRow[conge_StructureChartNode.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conge_StructureChartNode.OrderNum].ToString().Trim()); //序号
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objge_StructureChartNodeEN.StructureNodeId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objge_StructureChartNodeEN);
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
public static List<clsge_StructureChartNodeEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsge_StructureChartNodeEN> arrObjLst = new List<clsge_StructureChartNodeEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsge_StructureChartNodeEN objge_StructureChartNodeEN = new clsge_StructureChartNodeEN();
try
{
objge_StructureChartNodeEN.StructureNodeId = objRow[conge_StructureChartNode.StructureNodeId].ToString().Trim(); //结构Id
objge_StructureChartNodeEN.StructureNodeName = objRow[conge_StructureChartNode.StructureNodeName].ToString().Trim(); //结构名称
objge_StructureChartNodeEN.UpdDate = objRow[conge_StructureChartNode.UpdDate] == DBNull.Value ? null : objRow[conge_StructureChartNode.UpdDate].ToString().Trim(); //修改日期
objge_StructureChartNodeEN.UpdUser = objRow[conge_StructureChartNode.UpdUser] == DBNull.Value ? null : objRow[conge_StructureChartNode.UpdUser].ToString().Trim(); //修改人
objge_StructureChartNodeEN.Memo = objRow[conge_StructureChartNode.Memo] == DBNull.Value ? null : objRow[conge_StructureChartNode.Memo].ToString().Trim(); //备注
objge_StructureChartNodeEN.ParentId = objRow[conge_StructureChartNode.ParentId].ToString().Trim(); //父节点Id
objge_StructureChartNodeEN.IsRoot = clsEntityBase2.TransNullToBool_S(objRow[conge_StructureChartNode.IsRoot].ToString().Trim()); //IsRoot
objge_StructureChartNodeEN.background = objRow[conge_StructureChartNode.background] == DBNull.Value ? null : objRow[conge_StructureChartNode.background].ToString().Trim(); //背景色
objge_StructureChartNodeEN.foreground = objRow[conge_StructureChartNode.foreground] == DBNull.Value ? null : objRow[conge_StructureChartNode.foreground].ToString().Trim(); //背景字颜色
objge_StructureChartNodeEN.StructureGraphId = objRow[conge_StructureChartNode.StructureGraphId].ToString().Trim(); //知识图谱Id
objge_StructureChartNodeEN.Direction = objRow[conge_StructureChartNode.Direction] == DBNull.Value ? null : objRow[conge_StructureChartNode.Direction].ToString().Trim(); //方向
objge_StructureChartNodeEN.IsExpanded = clsEntityBase2.TransNullToBool_S(objRow[conge_StructureChartNode.IsExpanded].ToString().Trim()); //是否扩展
objge_StructureChartNodeEN.StructureSectionId = objRow[conge_StructureChartNode.StructureSectionId] == DBNull.Value ? null : objRow[conge_StructureChartNode.StructureSectionId].ToString().Trim(); //结构章节Id
objge_StructureChartNodeEN.OrderNum = objRow[conge_StructureChartNode.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conge_StructureChartNode.OrderNum].ToString().Trim()); //序号
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objge_StructureChartNodeEN.StructureNodeId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objge_StructureChartNodeEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsge_StructureChartNodeEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsge_StructureChartNodeEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsge_StructureChartNodeEN> arrObjLst = new List<clsge_StructureChartNodeEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsge_StructureChartNodeEN objge_StructureChartNodeEN = new clsge_StructureChartNodeEN();
try
{
objge_StructureChartNodeEN.StructureNodeId = objRow[conge_StructureChartNode.StructureNodeId].ToString().Trim(); //结构Id
objge_StructureChartNodeEN.StructureNodeName = objRow[conge_StructureChartNode.StructureNodeName].ToString().Trim(); //结构名称
objge_StructureChartNodeEN.UpdDate = objRow[conge_StructureChartNode.UpdDate] == DBNull.Value ? null : objRow[conge_StructureChartNode.UpdDate].ToString().Trim(); //修改日期
objge_StructureChartNodeEN.UpdUser = objRow[conge_StructureChartNode.UpdUser] == DBNull.Value ? null : objRow[conge_StructureChartNode.UpdUser].ToString().Trim(); //修改人
objge_StructureChartNodeEN.Memo = objRow[conge_StructureChartNode.Memo] == DBNull.Value ? null : objRow[conge_StructureChartNode.Memo].ToString().Trim(); //备注
objge_StructureChartNodeEN.ParentId = objRow[conge_StructureChartNode.ParentId].ToString().Trim(); //父节点Id
objge_StructureChartNodeEN.IsRoot = clsEntityBase2.TransNullToBool_S(objRow[conge_StructureChartNode.IsRoot].ToString().Trim()); //IsRoot
objge_StructureChartNodeEN.background = objRow[conge_StructureChartNode.background] == DBNull.Value ? null : objRow[conge_StructureChartNode.background].ToString().Trim(); //背景色
objge_StructureChartNodeEN.foreground = objRow[conge_StructureChartNode.foreground] == DBNull.Value ? null : objRow[conge_StructureChartNode.foreground].ToString().Trim(); //背景字颜色
objge_StructureChartNodeEN.StructureGraphId = objRow[conge_StructureChartNode.StructureGraphId].ToString().Trim(); //知识图谱Id
objge_StructureChartNodeEN.Direction = objRow[conge_StructureChartNode.Direction] == DBNull.Value ? null : objRow[conge_StructureChartNode.Direction].ToString().Trim(); //方向
objge_StructureChartNodeEN.IsExpanded = clsEntityBase2.TransNullToBool_S(objRow[conge_StructureChartNode.IsExpanded].ToString().Trim()); //是否扩展
objge_StructureChartNodeEN.StructureSectionId = objRow[conge_StructureChartNode.StructureSectionId] == DBNull.Value ? null : objRow[conge_StructureChartNode.StructureSectionId].ToString().Trim(); //结构章节Id
objge_StructureChartNodeEN.OrderNum = objRow[conge_StructureChartNode.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conge_StructureChartNode.OrderNum].ToString().Trim()); //序号
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objge_StructureChartNodeEN.StructureNodeId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objge_StructureChartNodeEN);
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
public static List<clsge_StructureChartNodeEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsge_StructureChartNodeEN> arrObjLst = new List<clsge_StructureChartNodeEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsge_StructureChartNodeEN objge_StructureChartNodeEN = new clsge_StructureChartNodeEN();
try
{
objge_StructureChartNodeEN.StructureNodeId = objRow[conge_StructureChartNode.StructureNodeId].ToString().Trim(); //结构Id
objge_StructureChartNodeEN.StructureNodeName = objRow[conge_StructureChartNode.StructureNodeName].ToString().Trim(); //结构名称
objge_StructureChartNodeEN.UpdDate = objRow[conge_StructureChartNode.UpdDate] == DBNull.Value ? null : objRow[conge_StructureChartNode.UpdDate].ToString().Trim(); //修改日期
objge_StructureChartNodeEN.UpdUser = objRow[conge_StructureChartNode.UpdUser] == DBNull.Value ? null : objRow[conge_StructureChartNode.UpdUser].ToString().Trim(); //修改人
objge_StructureChartNodeEN.Memo = objRow[conge_StructureChartNode.Memo] == DBNull.Value ? null : objRow[conge_StructureChartNode.Memo].ToString().Trim(); //备注
objge_StructureChartNodeEN.ParentId = objRow[conge_StructureChartNode.ParentId].ToString().Trim(); //父节点Id
objge_StructureChartNodeEN.IsRoot = clsEntityBase2.TransNullToBool_S(objRow[conge_StructureChartNode.IsRoot].ToString().Trim()); //IsRoot
objge_StructureChartNodeEN.background = objRow[conge_StructureChartNode.background] == DBNull.Value ? null : objRow[conge_StructureChartNode.background].ToString().Trim(); //背景色
objge_StructureChartNodeEN.foreground = objRow[conge_StructureChartNode.foreground] == DBNull.Value ? null : objRow[conge_StructureChartNode.foreground].ToString().Trim(); //背景字颜色
objge_StructureChartNodeEN.StructureGraphId = objRow[conge_StructureChartNode.StructureGraphId].ToString().Trim(); //知识图谱Id
objge_StructureChartNodeEN.Direction = objRow[conge_StructureChartNode.Direction] == DBNull.Value ? null : objRow[conge_StructureChartNode.Direction].ToString().Trim(); //方向
objge_StructureChartNodeEN.IsExpanded = clsEntityBase2.TransNullToBool_S(objRow[conge_StructureChartNode.IsExpanded].ToString().Trim()); //是否扩展
objge_StructureChartNodeEN.StructureSectionId = objRow[conge_StructureChartNode.StructureSectionId] == DBNull.Value ? null : objRow[conge_StructureChartNode.StructureSectionId].ToString().Trim(); //结构章节Id
objge_StructureChartNodeEN.OrderNum = objRow[conge_StructureChartNode.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conge_StructureChartNode.OrderNum].ToString().Trim()); //序号
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objge_StructureChartNodeEN.StructureNodeId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objge_StructureChartNodeEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsge_StructureChartNodeEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsge_StructureChartNodeEN> arrObjLst = new List<clsge_StructureChartNodeEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsge_StructureChartNodeEN objge_StructureChartNodeEN = new clsge_StructureChartNodeEN();
try
{
objge_StructureChartNodeEN.StructureNodeId = objRow[conge_StructureChartNode.StructureNodeId].ToString().Trim(); //结构Id
objge_StructureChartNodeEN.StructureNodeName = objRow[conge_StructureChartNode.StructureNodeName].ToString().Trim(); //结构名称
objge_StructureChartNodeEN.UpdDate = objRow[conge_StructureChartNode.UpdDate] == DBNull.Value ? null : objRow[conge_StructureChartNode.UpdDate].ToString().Trim(); //修改日期
objge_StructureChartNodeEN.UpdUser = objRow[conge_StructureChartNode.UpdUser] == DBNull.Value ? null : objRow[conge_StructureChartNode.UpdUser].ToString().Trim(); //修改人
objge_StructureChartNodeEN.Memo = objRow[conge_StructureChartNode.Memo] == DBNull.Value ? null : objRow[conge_StructureChartNode.Memo].ToString().Trim(); //备注
objge_StructureChartNodeEN.ParentId = objRow[conge_StructureChartNode.ParentId].ToString().Trim(); //父节点Id
objge_StructureChartNodeEN.IsRoot = clsEntityBase2.TransNullToBool_S(objRow[conge_StructureChartNode.IsRoot].ToString().Trim()); //IsRoot
objge_StructureChartNodeEN.background = objRow[conge_StructureChartNode.background] == DBNull.Value ? null : objRow[conge_StructureChartNode.background].ToString().Trim(); //背景色
objge_StructureChartNodeEN.foreground = objRow[conge_StructureChartNode.foreground] == DBNull.Value ? null : objRow[conge_StructureChartNode.foreground].ToString().Trim(); //背景字颜色
objge_StructureChartNodeEN.StructureGraphId = objRow[conge_StructureChartNode.StructureGraphId].ToString().Trim(); //知识图谱Id
objge_StructureChartNodeEN.Direction = objRow[conge_StructureChartNode.Direction] == DBNull.Value ? null : objRow[conge_StructureChartNode.Direction].ToString().Trim(); //方向
objge_StructureChartNodeEN.IsExpanded = clsEntityBase2.TransNullToBool_S(objRow[conge_StructureChartNode.IsExpanded].ToString().Trim()); //是否扩展
objge_StructureChartNodeEN.StructureSectionId = objRow[conge_StructureChartNode.StructureSectionId] == DBNull.Value ? null : objRow[conge_StructureChartNode.StructureSectionId].ToString().Trim(); //结构章节Id
objge_StructureChartNodeEN.OrderNum = objRow[conge_StructureChartNode.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conge_StructureChartNode.OrderNum].ToString().Trim()); //序号
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objge_StructureChartNodeEN.StructureNodeId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objge_StructureChartNodeEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objge_StructureChartNodeEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool Getge_StructureChartNode(ref clsge_StructureChartNodeEN objge_StructureChartNodeEN)
{
bool bolResult = ge_StructureChartNodeDA.Getge_StructureChartNode(ref objge_StructureChartNodeEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "strStructureNodeId">表关键字</param>
 /// <returns>表对象</returns>
public static clsge_StructureChartNodeEN GetObjByStructureNodeId(string strStructureNodeId)
{
if (strStructureNodeId.IndexOf(' ') >=0)
{
var strMsg = string.Format("(errid:Busi000079)在表中,关键字[strStructureNodeId]中不能有空格!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
if (string.IsNullOrEmpty(strStructureNodeId) == true)
{
var strMsg = string.Format("(errid:Busi000020)在表中,关键字[strStructureNodeId]不能为空!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
clsge_StructureChartNodeEN objge_StructureChartNodeEN = ge_StructureChartNodeDA.GetObjByStructureNodeId(strStructureNodeId);
return objge_StructureChartNodeEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsge_StructureChartNodeEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsge_StructureChartNodeEN objge_StructureChartNodeEN = ge_StructureChartNodeDA.GetFirstObj(strWhereCond);
 return objge_StructureChartNodeEN;
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
public static clsge_StructureChartNodeEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsge_StructureChartNodeEN objge_StructureChartNodeEN = ge_StructureChartNodeDA.GetObjByDataRow(objRow);
 return objge_StructureChartNodeEN;
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
public static clsge_StructureChartNodeEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsge_StructureChartNodeEN objge_StructureChartNodeEN = ge_StructureChartNodeDA.GetObjByDataRow(objRow);
 return objge_StructureChartNodeEN;
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
 /// <param name = "strStructureNodeId">所给的关键字</param>
 /// <param name = "lstge_StructureChartNodeObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsge_StructureChartNodeEN GetObjByStructureNodeIdFromList(string strStructureNodeId, List<clsge_StructureChartNodeEN> lstge_StructureChartNodeObjLst)
{
foreach (clsge_StructureChartNodeEN objge_StructureChartNodeEN in lstge_StructureChartNodeObjLst)
{
if (objge_StructureChartNodeEN.StructureNodeId == strStructureNodeId)
{
return objge_StructureChartNodeEN;
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
 string strMaxStructureNodeId;
 try
 {
 strMaxStructureNodeId = clsge_StructureChartNodeDA.GetMaxStrId();
 return strMaxStructureNodeId;
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
 string strStructureNodeId;
 try
 {
 strStructureNodeId = new clsge_StructureChartNodeDA().GetFirstID(strWhereCond);
 return strStructureNodeId;
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
 arrList = ge_StructureChartNodeDA.GetID(strWhereCond);
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
bool bolIsExist = ge_StructureChartNodeDA.IsExistCondRec(strWhereCond);
return bolIsExist;
}

 /// <summary>
 /// 判断当前表中是否存在给定关键字值的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExist)
 /// </summary>
 /// <param name = "strStructureNodeId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public static bool IsExist(string strStructureNodeId)
{
if (string.IsNullOrEmpty(strStructureNodeId) == true)
{
var strMsg = string.Format("(errid:Busi000027)在表中,关键字[strStructureNodeId]不能为空!!(from {0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
//检测记录是否存在
bool bolIsExist = ge_StructureChartNodeDA.IsExist(strStructureNodeId);
return bolIsExist;
}

/// <summary>
/// 设置修改时间
/// </summary>
/// <param name = "strStructureNodeId">结构Id</param>
/// <param name = "strOpUser">修改用户</param>
/// <returns>是否成功？</returns>
public static bool SetUpdDate(string strStructureNodeId, string strOpUser)
{
clsge_StructureChartNodeEN objge_StructureChartNodeEN = clsge_StructureChartNodeBL.GetObjByStructureNodeId(strStructureNodeId);
objge_StructureChartNodeEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
objge_StructureChartNodeEN.UpdUser = strOpUser;
return clsge_StructureChartNodeBL.UpdateBySql2(objge_StructureChartNodeEN);
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
 bolIsExist = clsge_StructureChartNodeDA.IsExistTable();
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
 bolIsExist = ge_StructureChartNodeDA.IsExistTable(strTabName);
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
 /// <param name = "objge_StructureChartNodeEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecordBySql2(clsge_StructureChartNodeEN objge_StructureChartNodeEN, bool bolIsNeedCheckUniqueness=true)
{
if (bolIsNeedCheckUniqueness == true && objge_StructureChartNodeEN.CheckUniqueness() == false)
{
var strMsg = string.Format("记录已经存在!结构名称 = [{0}]的数据已经存在!(in clsge_StructureChartNodeBL.AddNewRecordBySql2)", objge_StructureChartNodeEN.StructureNodeName);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objge_StructureChartNodeEN.StructureNodeId) == true || clsge_StructureChartNodeBL.IsExist(objge_StructureChartNodeEN.StructureNodeId) == true)
 {
     objge_StructureChartNodeEN.StructureNodeId = clsge_StructureChartNodeBL.GetMaxStrId_S();
 }
bool bolResult = ge_StructureChartNodeDA.AddNewRecordBySQL2(objge_StructureChartNodeEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsge_StructureChartNodeBL.ReFreshCache(objge_StructureChartNodeEN.StructureGraphId);

if (clsge_StructureChartNodeBL.relatedActions != null)
{
clsge_StructureChartNodeBL.relatedActions.UpdRelaTabDate(objge_StructureChartNodeEN.StructureNodeId, objge_StructureChartNodeEN.UpdUser);
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
 /// <param name = "objge_StructureChartNodeEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordBySql2WithReturnKey(clsge_StructureChartNodeEN objge_StructureChartNodeEN, bool bolIsNeedCheckUniqueness=true)
{
if (bolIsNeedCheckUniqueness == true && objge_StructureChartNodeEN.CheckUniqueness() == false)
{
var strMsg = string.Format("记录已经存在!结构名称 = [{0}]的数据已经存在!(in clsge_StructureChartNodeBL.AddNewRecordBySql2WithReturnKey)", objge_StructureChartNodeEN.StructureNodeName);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objge_StructureChartNodeEN.StructureNodeId) == true || clsge_StructureChartNodeBL.IsExist(objge_StructureChartNodeEN.StructureNodeId) == true)
 {
     objge_StructureChartNodeEN.StructureNodeId = clsge_StructureChartNodeBL.GetMaxStrId_S();
 }
string strKey = ge_StructureChartNodeDA.AddNewRecordBySQL2WithReturnKey(objge_StructureChartNodeEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsge_StructureChartNodeBL.ReFreshCache(objge_StructureChartNodeEN.StructureGraphId);

if (clsge_StructureChartNodeBL.relatedActions != null)
{
clsge_StructureChartNodeBL.relatedActions.UpdRelaTabDate(objge_StructureChartNodeEN.StructureNodeId, objge_StructureChartNodeEN.UpdUser);
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
 /// <param name = "objge_StructureChartNodeEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(clsge_StructureChartNodeEN objge_StructureChartNodeEN)
{
try
{
bool bolResult = ge_StructureChartNodeDA.Update(objge_StructureChartNodeEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsge_StructureChartNodeBL.ReFreshCache(objge_StructureChartNodeEN.StructureGraphId);

if (clsge_StructureChartNodeBL.relatedActions != null)
{
clsge_StructureChartNodeBL.relatedActions.UpdRelaTabDate(objge_StructureChartNodeEN.StructureNodeId, objge_StructureChartNodeEN.UpdUser);
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
 /// <param name = "objge_StructureChartNodeEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateBySql2(clsge_StructureChartNodeEN objge_StructureChartNodeEN)
{
 if (string.IsNullOrEmpty(objge_StructureChartNodeEN.StructureNodeId) == true)
 {
var strMsg = string.Format("(errid:Busi000065)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = ge_StructureChartNodeDA.UpdateBySql2(objge_StructureChartNodeEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsge_StructureChartNodeBL.ReFreshCache(objge_StructureChartNodeEN.StructureGraphId);

if (clsge_StructureChartNodeBL.relatedActions != null)
{
clsge_StructureChartNodeBL.relatedActions.UpdRelaTabDate(objge_StructureChartNodeEN.StructureNodeId, objge_StructureChartNodeEN.UpdUser);
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
 /// <param name = "strStructureNodeId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int DelRecord(string strStructureNodeId)
{
try
{
 clsge_StructureChartNodeEN objge_StructureChartNodeEN = clsge_StructureChartNodeBL.GetObjByStructureNodeId(strStructureNodeId);

if (clsge_StructureChartNodeBL.relatedActions != null)
{
clsge_StructureChartNodeBL.relatedActions.UpdRelaTabDate(objge_StructureChartNodeEN.StructureNodeId, objge_StructureChartNodeEN.UpdUser);
}
if (objge_StructureChartNodeEN != null)
{
int intRecNum = ge_StructureChartNodeDA.DelRecord(strStructureNodeId);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
ReFreshCache(objge_StructureChartNodeEN.StructureGraphId);
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
/// <param name="strStructureNodeId">表关键字</param>
 /// <param name = "strStructureGraphId">缓存的分类字段</param>
/// <returns></returns>
public static bool DelRecordEx(string strStructureNodeId , string strStructureGraphId)
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsge_StructureChartNodeDA.GetSpecSQLObj();
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
//删除与表:[ge_StructureChartNode]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conge_StructureChartNode.StructureNodeId,
//strStructureNodeId);
//        clsge_StructureChartNodeBL.Delge_StructureChartNodesByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsge_StructureChartNodeBL.DelRecord(strStructureNodeId, strStructureGraphId, objConnection, objSqlTransaction);
objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsge_StructureChartNodeBLEx", "DelRecordEx", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("扩展删除记录出错:{0}!keyId = {1}.({2})",
objException.Message,
strStructureNodeId, clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "strStructureNodeId">给定的关键字值</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回删除是否成功?</returns>
public static bool DelRecord(string strStructureNodeId, string strStructureGraphId, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
if (clsge_StructureChartNodeBL.relatedActions != null)
{
clsge_StructureChartNodeBL.relatedActions.UpdRelaTabDate(strStructureNodeId, "UpdRelaTabDate");
}
bool bolResult = ge_StructureChartNodeDA.DelRecord(strStructureNodeId,objSqlConnection,objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
ReFreshCache(strStructureGraphId);
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
 /// <param name = "arrStructureNodeIdLst">给定的关键字值列表</param>
 /// <returns>返回删除的记录数</returns>
public static int Delge_StructureChartNodes(List<string> arrStructureNodeIdLst)
{
if (arrStructureNodeIdLst.Count == 0) return 0;
try
{
if (clsge_StructureChartNodeBL.relatedActions != null)
{
foreach (var strStructureNodeId in arrStructureNodeIdLst)
{
clsge_StructureChartNodeBL.relatedActions.UpdRelaTabDate(strStructureNodeId, "UpdRelaTabDate");
}
}
 clsge_StructureChartNodeEN objge_StructureChartNodeEN = clsge_StructureChartNodeBL.GetObjByStructureNodeId(arrStructureNodeIdLst[0]);
int intDelRecNum = ge_StructureChartNodeDA.Delge_StructureChartNode(arrStructureNodeIdLst);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
ReFreshCache(objge_StructureChartNodeEN.StructureGraphId);
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
public static int Delge_StructureChartNodesByCond(string strWhereCond)
{
try
{
if (clsge_StructureChartNodeBL.relatedActions != null)
{
List<string> arrStructureNodeId = GetPrimaryKeyID_S(strWhereCond);
foreach (var strStructureNodeId in arrStructureNodeId)
{
clsge_StructureChartNodeBL.relatedActions.UpdRelaTabDate(strStructureNodeId, "UpdRelaTabDate");
}
}
List<string> arrStructureGraphId = GetFldValue(conge_StructureChartNode.StructureGraphId, strWhereCond);
int intRecNum = ge_StructureChartNodeDA.Delge_StructureChartNode(strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
arrStructureGraphId.ForEach(x => ReFreshCache(x));
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
/// 这里仅仅是演示函数,使用时请复制到扩展类:[ge_StructureChartNode]中改名为:[DelRecord4MultiTabEx]使用
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DelRecord4MultiTab)
/// </summary>
/// <param name="strStructureNodeId">表关键字</param>
 /// <param name = "strStructureGraphId">缓存的分类字段</param>
/// <returns></returns>
public static bool DelRecord4MultiTab(string strStructureNodeId, string strStructureGraphId)
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsge_StructureChartNodeDA.GetSpecSQLObj();
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
//删除与表:[ge_StructureChartNode]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conStudent.id_College,
//strid_College);
//        clsStudentBL.DelStudentsByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsge_StructureChartNodeBL.DelRecord(strStructureNodeId, strStructureGraphId, objConnection, objSqlTransaction);
                objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsge_StructureChartNodeBL", "DelRecord4MultiTab", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("删除多表记录出错:{0}!keyId = {1}.({2})",
objException.Message,
strStructureNodeId, clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "objge_StructureChartNodeENS">源对象</param>
 /// <param name = "objge_StructureChartNodeENT">目标对象</param>
 public static void CopyTo(clsge_StructureChartNodeEN objge_StructureChartNodeENS, clsge_StructureChartNodeEN objge_StructureChartNodeENT)
{
try
{
objge_StructureChartNodeENT.StructureNodeId = objge_StructureChartNodeENS.StructureNodeId; //结构Id
objge_StructureChartNodeENT.StructureNodeName = objge_StructureChartNodeENS.StructureNodeName; //结构名称
objge_StructureChartNodeENT.UpdDate = objge_StructureChartNodeENS.UpdDate; //修改日期
objge_StructureChartNodeENT.UpdUser = objge_StructureChartNodeENS.UpdUser; //修改人
objge_StructureChartNodeENT.Memo = objge_StructureChartNodeENS.Memo; //备注
objge_StructureChartNodeENT.ParentId = objge_StructureChartNodeENS.ParentId; //父节点Id
objge_StructureChartNodeENT.IsRoot = objge_StructureChartNodeENS.IsRoot; //IsRoot
objge_StructureChartNodeENT.background = objge_StructureChartNodeENS.background; //背景色
objge_StructureChartNodeENT.foreground = objge_StructureChartNodeENS.foreground; //背景字颜色
objge_StructureChartNodeENT.StructureGraphId = objge_StructureChartNodeENS.StructureGraphId; //知识图谱Id
objge_StructureChartNodeENT.Direction = objge_StructureChartNodeENS.Direction; //方向
objge_StructureChartNodeENT.IsExpanded = objge_StructureChartNodeENS.IsExpanded; //是否扩展
objge_StructureChartNodeENT.StructureSectionId = objge_StructureChartNodeENS.StructureSectionId; //结构章节Id
objge_StructureChartNodeENT.OrderNum = objge_StructureChartNodeENS.OrderNum; //序号
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
 /// <param name = "objge_StructureChartNodeEN">源简化对象</param>
 public static void SetUpdFlag(clsge_StructureChartNodeEN objge_StructureChartNodeEN)
{
try
{
objge_StructureChartNodeEN.ClearUpdateState();
   string strsfUpdFldSetStr = objge_StructureChartNodeEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(conge_StructureChartNode.StructureNodeId, new clsStrCompareIgnoreCase())  ==  true)
{
objge_StructureChartNodeEN.StructureNodeId = objge_StructureChartNodeEN.StructureNodeId; //结构Id
}
if (arrFldSet.Contains(conge_StructureChartNode.StructureNodeName, new clsStrCompareIgnoreCase())  ==  true)
{
objge_StructureChartNodeEN.StructureNodeName = objge_StructureChartNodeEN.StructureNodeName; //结构名称
}
if (arrFldSet.Contains(conge_StructureChartNode.UpdDate, new clsStrCompareIgnoreCase())  ==  true)
{
objge_StructureChartNodeEN.UpdDate = objge_StructureChartNodeEN.UpdDate == "[null]" ? null :  objge_StructureChartNodeEN.UpdDate; //修改日期
}
if (arrFldSet.Contains(conge_StructureChartNode.UpdUser, new clsStrCompareIgnoreCase())  ==  true)
{
objge_StructureChartNodeEN.UpdUser = objge_StructureChartNodeEN.UpdUser == "[null]" ? null :  objge_StructureChartNodeEN.UpdUser; //修改人
}
if (arrFldSet.Contains(conge_StructureChartNode.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objge_StructureChartNodeEN.Memo = objge_StructureChartNodeEN.Memo == "[null]" ? null :  objge_StructureChartNodeEN.Memo; //备注
}
if (arrFldSet.Contains(conge_StructureChartNode.ParentId, new clsStrCompareIgnoreCase())  ==  true)
{
objge_StructureChartNodeEN.ParentId = objge_StructureChartNodeEN.ParentId; //父节点Id
}
if (arrFldSet.Contains(conge_StructureChartNode.IsRoot, new clsStrCompareIgnoreCase())  ==  true)
{
objge_StructureChartNodeEN.IsRoot = objge_StructureChartNodeEN.IsRoot; //IsRoot
}
if (arrFldSet.Contains(conge_StructureChartNode.background, new clsStrCompareIgnoreCase())  ==  true)
{
objge_StructureChartNodeEN.background = objge_StructureChartNodeEN.background == "[null]" ? null :  objge_StructureChartNodeEN.background; //背景色
}
if (arrFldSet.Contains(conge_StructureChartNode.foreground, new clsStrCompareIgnoreCase())  ==  true)
{
objge_StructureChartNodeEN.foreground = objge_StructureChartNodeEN.foreground == "[null]" ? null :  objge_StructureChartNodeEN.foreground; //背景字颜色
}
if (arrFldSet.Contains(conge_StructureChartNode.StructureGraphId, new clsStrCompareIgnoreCase())  ==  true)
{
objge_StructureChartNodeEN.StructureGraphId = objge_StructureChartNodeEN.StructureGraphId; //知识图谱Id
}
if (arrFldSet.Contains(conge_StructureChartNode.Direction, new clsStrCompareIgnoreCase())  ==  true)
{
objge_StructureChartNodeEN.Direction = objge_StructureChartNodeEN.Direction == "[null]" ? null :  objge_StructureChartNodeEN.Direction; //方向
}
if (arrFldSet.Contains(conge_StructureChartNode.IsExpanded, new clsStrCompareIgnoreCase())  ==  true)
{
objge_StructureChartNodeEN.IsExpanded = objge_StructureChartNodeEN.IsExpanded; //是否扩展
}
if (arrFldSet.Contains(conge_StructureChartNode.StructureSectionId, new clsStrCompareIgnoreCase())  ==  true)
{
objge_StructureChartNodeEN.StructureSectionId = objge_StructureChartNodeEN.StructureSectionId == "[null]" ? null :  objge_StructureChartNodeEN.StructureSectionId; //结构章节Id
}
if (arrFldSet.Contains(conge_StructureChartNode.OrderNum, new clsStrCompareIgnoreCase())  ==  true)
{
objge_StructureChartNodeEN.OrderNum = objge_StructureChartNodeEN.OrderNum; //序号
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
 /// <param name = "objge_StructureChartNodeEN">源简化对象</param>
 public static void AccessFldValueNull(clsge_StructureChartNodeEN objge_StructureChartNodeEN)
{
try
{
if (objge_StructureChartNodeEN.UpdDate == "[null]") objge_StructureChartNodeEN.UpdDate = null; //修改日期
if (objge_StructureChartNodeEN.UpdUser == "[null]") objge_StructureChartNodeEN.UpdUser = null; //修改人
if (objge_StructureChartNodeEN.Memo == "[null]") objge_StructureChartNodeEN.Memo = null; //备注
if (objge_StructureChartNodeEN.background == "[null]") objge_StructureChartNodeEN.background = null; //背景色
if (objge_StructureChartNodeEN.foreground == "[null]") objge_StructureChartNodeEN.foreground = null; //背景字颜色
if (objge_StructureChartNodeEN.Direction == "[null]") objge_StructureChartNodeEN.Direction = null; //方向
if (objge_StructureChartNodeEN.StructureSectionId == "[null]") objge_StructureChartNodeEN.StructureSectionId = null; //结构章节Id
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
public static void CheckPropertyNew(clsge_StructureChartNodeEN objge_StructureChartNodeEN)
{
 ge_StructureChartNodeDA.CheckPropertyNew(objge_StructureChartNodeEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(clsge_StructureChartNodeEN objge_StructureChartNodeEN)
{
 ge_StructureChartNodeDA.CheckProperty4Condition(objge_StructureChartNodeEN);
 }


 #endregion 检查对象属性


 #region 绑定下拉框

 /// <summary>
 /// 绑定基于Win的下拉框
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_TabFeature_ComboBoxBindFunction)
 /// </summary>
 /// <param name = "objComboBox">需要绑定当前表的下拉框</param>

 /// <param name = "strStructureGraphId"></param>
public static void BindCbo_StructureNodeId(System.Windows.Forms.ComboBox objComboBox , string strStructureGraphId)
{
//为数据源为表的下拉框设置内容
string strCondition = string.Format("1 =1 Order By {0}", conge_StructureChartNode.StructureNodeId); 
List<clsge_StructureChartNodeEN> arrObjLst = clsge_StructureChartNodeBL.GetObjLst(strCondition);
//初始化一个对象列表
//插入第0项。在第0项中插入“请选择...”,为了方便用户,与WEB方式类似。
clsge_StructureChartNodeEN objge_StructureChartNodeEN = new clsge_StructureChartNodeEN()
{
StructureNodeId = "0",
StructureNodeName = "选[知识点结构图]..."
};
arrObjLst.Insert(0, objge_StructureChartNodeEN);
//设置下拉框的数据源、以及设置值项、显示项
objComboBox.ValueMember = conge_StructureChartNode.StructureNodeId;
objComboBox.DisplayMember = conge_StructureChartNode.StructureNodeName;
objComboBox.DataSource = arrObjLst;
objComboBox.SelectedIndex = 0;
}

 /// <summary>
 /// 绑定基于Web的下拉框
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_TabFeature_DdlBindFunction)
 /// </summary>
 /// <param name = "objDDL">需要绑定当前表的下拉框</param>

 /// <param name = "strStructureGraphId"></param>
public static void BindDdl_StructureNodeId(System.Web.UI.WebControls.DropDownList objDDL , string strStructureGraphId)
{
//为数据源于表的下拉框设置内容
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[知识点结构图]...","0");
string strCondition = string.Format("1 =1 Order By {0}", conge_StructureChartNode.StructureNodeId); 
IEnumerable<clsge_StructureChartNodeEN> arrObjLst = clsge_StructureChartNodeBL.GetObjLst(strCondition);
objDDL.DataValueField = conge_StructureChartNode.StructureNodeId;
objDDL.DataTextField = conge_StructureChartNode.StructureNodeName;
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
public static void BindDdl_StructureNodeIdCache(System.Web.UI.WebControls.DropDownList objDDL, string strStructureGraphId)
{
//为数据源于表的下拉框设置内容
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[知识点结构图]...","0");
List<clsge_StructureChartNodeEN> arrge_StructureChartNodeObjLst = GetAllge_StructureChartNodeObjLstCache(strStructureGraphId); 
arrge_StructureChartNodeObjLst = arrge_StructureChartNodeObjLst.OrderBy(x=>x.OrderNum).ToList(); 
objDDL.DataValueField = conge_StructureChartNode.StructureNodeId;
objDDL.DataTextField = conge_StructureChartNode.StructureNodeName;
objDDL.DataSource = arrge_StructureChartNodeObjLst;
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
if (clsge_StructureChartNodeBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsge_StructureChartNodeBL没有刷新缓存机制(clsge_StructureChartNodeBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by StructureNodeId");
//if (arrge_StructureChartNodeObjLstCache == null)
//{
//arrge_StructureChartNodeObjLstCache = ge_StructureChartNodeDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "strStructureNodeId">所给的关键字</param>
 /// <param name = "strStructureGraphId">缓存的分类字段</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsge_StructureChartNodeEN GetObjByStructureNodeIdCache(string strStructureNodeId, string strStructureGraphId)
{

if (string.IsNullOrEmpty(strStructureGraphId) == true)
{
  var strMsg = string.Format("参数:[strStructureGraphId]不能为空!(In {0})", clsStackTrace.GetCurrClassFunction());
clsSysParaEN.objLog.WriteDebugLog(strMsg);
 throw new Exception (strMsg);
}
if (strStructureGraphId.Length != 10)
{
var strMsg = string.Format("缓存分类变量:[strStructureGraphId]的长度:[{0}]不正确!(In {1})", strStructureGraphId.Length, clsStackTrace.GetCurrClassFunction());
clsSysParaEN.objLog.WriteDebugLog(strMsg);
 throw new Exception (strMsg);
}
//获取缓存中的对象列表
string strKey = string.Format("{0}_{1}", clsge_StructureChartNodeEN._CurrTabName, strStructureGraphId);
List<clsge_StructureChartNodeEN> arrge_StructureChartNodeObjLstCache = GetObjLstCache(strStructureGraphId);
IEnumerable <clsge_StructureChartNodeEN> arrge_StructureChartNodeObjLst_Sel =
arrge_StructureChartNodeObjLstCache
.Where(x=> x.StructureNodeId == strStructureNodeId 
);
if (arrge_StructureChartNodeObjLst_Sel.Count() == 0)
{
   clsge_StructureChartNodeEN obj = clsge_StructureChartNodeBL.GetObjByStructureNodeId(strStructureNodeId);
   if (obj != null)
 {
if (obj.StructureGraphId == strStructureGraphId)
{
CacheHelper.Remove(strKey);
     return obj;
}
else
{
string strMsg = string.Format("错误: 关键字:{0}不属于分类:{1},请检查!(In {2})", strStructureNodeId, strStructureGraphId, clsStackTrace.GetCurrClassFunction());
clsSysParaEN.objLog.WriteDebugLog(strMsg);
throw new Exception(strMsg);
}
 }
return null;
}
return arrge_StructureChartNodeObjLst_Sel.First();
}

 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecNameByKeyCache)
 /// </summary>
 /// <param name = "strStructureNodeId">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetStructureNodeNameByStructureNodeIdCache(string strStructureNodeId, string strStructureGraphId)
{
if (string.IsNullOrEmpty(strStructureNodeId) == true) return "";
//获取缓存中的对象列表
clsge_StructureChartNodeEN objge_StructureChartNode = GetObjByStructureNodeIdCache(strStructureNodeId, strStructureGraphId);
if (objge_StructureChartNode == null) return "";
return objge_StructureChartNode.StructureNodeName;
}
 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecNameByKeyCache)
 /// </summary>
 /// <param name = "strStructureNodeId">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetNameByStructureNodeIdCache(string strStructureNodeId, string strStructureGraphId)
{
if (string.IsNullOrEmpty(strStructureNodeId) == true) return "";
//获取缓存中的对象列表
clsge_StructureChartNodeEN objge_StructureChartNode = GetObjByStructureNodeIdCache(strStructureNodeId, strStructureGraphId);
if (objge_StructureChartNode == null) return "";
return objge_StructureChartNode.StructureNodeName;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsge_StructureChartNodeEN> GetAllge_StructureChartNodeObjLstCache(string strStructureGraphId)
{
//获取缓存中的对象列表
List<clsge_StructureChartNodeEN> arrge_StructureChartNodeObjLstCache = GetObjLstCache(strStructureGraphId); 
return arrge_StructureChartNodeObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsge_StructureChartNodeEN> GetObjLstCache(string strStructureGraphId)
{

if (string.IsNullOrEmpty(strStructureGraphId) == true)
{
  var strMsg = string.Format("参数:[strStructureGraphId]不能为空!(In {0})", clsStackTrace.GetCurrClassFunction());
clsSysParaEN.objLog.WriteDebugLog(strMsg);
 throw new Exception (strMsg);
}
if (strStructureGraphId.Length != 10)
{
var strMsg = string.Format("缓存分类变量:[strStructureGraphId]的长度:[{0}]不正确!(In {1})", strStructureGraphId.Length, clsStackTrace.GetCurrClassFunction());
clsSysParaEN.objLog.WriteDebugLog(strMsg);
 throw new Exception (strMsg);
}
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}_{1}", clsge_StructureChartNodeEN._CurrTabName, strStructureGraphId);
string strCondition = string.Format("StructureGraphId='{0}'", strStructureGraphId);
List<clsge_StructureChartNodeEN> arrge_StructureChartNodeObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst(strCondition); });
return arrge_StructureChartNodeObjLstCache;
}

 /// <summary>
 /// 刷新本类中的缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ReFreshThisCache)
 /// </summary>
public static void ReFreshThisCache(string strStructureGraphId = "")
{
string strMsg;
if (clsSysParaEN.spSetRefreshCacheOn == true)
{
string strKey = string.Format("{0}_{1}", clsge_StructureChartNodeEN._CurrTabName, strStructureGraphId);
CacheHelper.Remove(strKey);
clsge_StructureChartNodeEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
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
if (clsge_StructureChartNodeEN._RefreshTimeLst.Count == 0) return "";
return clsge_StructureChartNodeEN._RefreshTimeLst[clsge_StructureChartNodeEN._RefreshTimeLst.Count - 1];
}

 /// <summary>
 /// 刷新缓存.把当前表的缓存以及该表相关视图的缓存清空.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ReFreshCache)
 /// </summary>
public static void ReFreshCache(string strStructureGraphId)
{
if (string.IsNullOrEmpty(strStructureGraphId) == true)
{
string strMsg = string.Format("缓存分类字段:[StructureGraphId]不能为空!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsge_StructureChartNodeBL.objCommFun4BL != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}_{1}", clsge_StructureChartNodeEN._CurrTabName, strStructureGraphId);
CacheHelper.Remove(strKey);
clsge_StructureChartNodeEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
clsge_StructureChartNodeBL.objCommFun4BL.ReFreshCache(strStructureGraphId);
}
}


 #endregion 缓存操作


 #region 检查唯一性

 /// <summary>
 /// 获取检查唯一性条件串(Uniqueness)--ge_StructureChartNode(知识点结构图)
 /// 唯一性条件:StructureNodeName
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetUniquenessConditionString)
 /// </summary>
 /// <param name = "objge_StructureChartNodeEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(clsge_StructureChartNodeEN objge_StructureChartNodeEN)
{
//检测记录是否存在
string strResult = ge_StructureChartNodeDA.GetUniCondStr(objge_StructureChartNodeEN);
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
 /// <param name = "strStructureGraphId">缓存的分类字段</param>
 /// <returns>返回一个输出字段值</returns>
public static string Func(string strInFldName, string strOutFldName, string strStructureNodeId, string strStructureGraphId)
{
if (strInFldName != conge_StructureChartNode.StructureNodeId)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (conge_StructureChartNode.AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", conge_StructureChartNode.AttributeName));
throw new Exception(strMsg);
}
var objge_StructureChartNode = clsge_StructureChartNodeBL.GetObjByStructureNodeIdCache(strStructureNodeId, strStructureGraphId);
if (objge_StructureChartNode == null) return "";
return objge_StructureChartNode[strOutFldName].ToString();
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
int intRecCount = clsge_StructureChartNodeDA.GetRecCount(strTabName);
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
int intRecCount = clsge_StructureChartNodeDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsge_StructureChartNodeDA.GetRecCount();
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
int intRecCount = clsge_StructureChartNodeDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objge_StructureChartNodeCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsge_StructureChartNodeEN objge_StructureChartNodeCond)
{
 string strStructureGraphId = objge_StructureChartNodeCond.StructureGraphId;
 if (string.IsNullOrEmpty(strStructureGraphId) == true)
{
string strMsg = string.Format("(errid:Busi000174)在表中,缓存分类字段值不能为空!(clsge_StructureChartNodeBL:GetRecCountByCondCache)");
throw new Exception(strMsg);
}
List<clsge_StructureChartNodeEN> arrObjLstCache = GetObjLstCache(strStructureGraphId);
IEnumerable <clsge_StructureChartNodeEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conge_StructureChartNode.AttributeName)
{
if (objge_StructureChartNodeCond.IsUpdated(strFldName) == false) continue;
if (objge_StructureChartNodeCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objge_StructureChartNodeCond[strFldName].ToString());
}
else
{
if (objge_StructureChartNodeCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objge_StructureChartNodeCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objge_StructureChartNodeCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objge_StructureChartNodeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objge_StructureChartNodeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objge_StructureChartNodeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objge_StructureChartNodeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objge_StructureChartNodeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objge_StructureChartNodeCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objge_StructureChartNodeCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objge_StructureChartNodeCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objge_StructureChartNodeCond[strFldName]));
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
 List<string> arrList = clsge_StructureChartNodeDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = ge_StructureChartNodeDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = ge_StructureChartNodeDA.GetFldValueNoDistinct(strFldName, strWhereCond);
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
int intRecCount = ge_StructureChartNodeDA.SetFldValue(strFldName, strValue, strWhereCond);
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
int intRecCount = clsge_StructureChartNodeDA.SetFldValue(clsge_StructureChartNodeEN._CurrTabName, strFldName, fltValue, strWhereCond);
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
int intRecCount = ge_StructureChartNodeDA.SetFldValue( strFldName, intValue, strWhereCond);
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
int intRecCount = clsge_StructureChartNodeDA.SetFldValue(strTabName, strFldName, strValue, strWhereCond);
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
int intRecCount = clsge_StructureChartNodeDA.SetFldValue(strTabName, strFldName, intValue, strWhereCond);
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
int intRecCount = clsge_StructureChartNodeDA.SetFldValue(strTabName, strFldName, fltValue, strWhereCond);
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
  strCreateTabCode.Append("CREATE table [dbo].[ge_StructureChartNode] "); 
 strCreateTabCode.Append(" ( "); 
 // /**结构Id*/ 
 strCreateTabCode.Append(" StructureNodeId char(10) primary key, "); 
 // /**结构名称*/ 
 strCreateTabCode.Append(" StructureNodeName varchar(50) not Null, "); 
 // /**修改日期*/ 
 strCreateTabCode.Append(" UpdDate varchar(20) Null, "); 
 // /**修改人*/ 
 strCreateTabCode.Append(" UpdUser varchar(20) Null, "); 
 // /**备注*/ 
 strCreateTabCode.Append(" Memo varchar(1000) Null, "); 
 // /**父节点Id*/ 
 strCreateTabCode.Append(" ParentId char(10) not Null, "); 
 // /**IsRoot*/ 
 strCreateTabCode.Append(" IsRoot bit Null, "); 
 // /**背景色*/ 
 strCreateTabCode.Append(" background varchar(50) Null, "); 
 // /**背景字颜色*/ 
 strCreateTabCode.Append(" foreground varchar(50) Null, "); 
 // /**知识图谱Id*/ 
 strCreateTabCode.Append(" StructureGraphId char(10) not Null, "); 
 // /**方向*/ 
 strCreateTabCode.Append(" Direction varchar(50) Null, "); 
 // /**是否扩展*/ 
 strCreateTabCode.Append(" IsExpanded bit Null, "); 
 // /**结构章节Id*/ 
 strCreateTabCode.Append(" StructureSectionId char(10) Null, "); 
 // /**序号*/ 
 strCreateTabCode.Append(" OrderNum int Null ");
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
string strCondition = string.Format("1 = 1 order by {0} ", conge_StructureChartNode.OrderNum); 
List<clsge_StructureChartNodeEN> arrge_StructureChartNodeObjList = new clsge_StructureChartNodeDA().GetObjLst(strCondition);
    
int intIndex = 1;
foreach (clsge_StructureChartNodeEN objge_StructureChartNode in arrge_StructureChartNodeObjList)
{
objge_StructureChartNode.OrderNum = intIndex;
UpdateBySql2(objge_StructureChartNode);
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
/// <param name="strStructureNodeId">所给的关键字</param>
/// <returns>是否成绩</returns>
public static bool AdjustOrderNum(string strDirect, string strStructureNodeId)
{
try
{
//操作步骤：
//1、根据所给定的关键字[StructureNodeId],获取相应的序号[OrderNum]；
//2、如果当前序号是否是末端序号；
//3、如果是末端序号,就退出；
//   3.1、如果是向下移动,判断当前序号是否“小于”当前表中的字段数,
//	   即不是最后一个记录,就准备把当前字段项的序号加1,而下一字段的序号减1,
//   3.2、如果是向上移动,就判断当前序号是否“大于”1,
//	   即不是第一条记录,就准备把当前字段项的序号减1,而上一字段的序号加1。
//4、获取下(上)一个序号记录的关键字StructureNodeId
//5、把当前关键字StructureNodeId所对应记录的序号加(减)1
//6、把下(上)一个序号关键字StructureNodeId所对应的记录序号减(加)1
string strMsg;
int intOrderNum;    //当前记录的序号
int intPrevOrderNum, intNextOrderNum;   //上下两条记录的序号
string strPrevStructureNodeId = "";    //上一条序号的关键字StructureNodeId
string strNextStructureNodeId = "";    //下一条序号的关键字StructureNodeId
int intTabRecNum;       //当前表中字段的记录数
StringBuilder strCondition = new StringBuilder();
//1、根据所给定的关键字[StructureNodeId],获取相应的序号[OrderNum]。

clsge_StructureChartNodeEN objge_StructureChartNode = clsge_StructureChartNodeBL.GetObjByStructureNodeId(strStructureNodeId);

intOrderNum = objge_StructureChartNode.OrderNum ?? 0;//当前序号
intPrevOrderNum = intOrderNum - 1;//前一条记录的序号
intNextOrderNum = intOrderNum + 1;//后一条记录的序号
//3、如果当前序号是否是末端序号,
//		3.1 如果是末端序号,就退出,

intTabRecNum = clsge_StructureChartNodeBL.GetRecCountByCond(clsge_StructureChartNodeEN._CurrTabName, "1 = 1");    //获取当前表的记录数
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
strCondition.AppendFormat(" {0} = {1}", conge_StructureChartNode.OrderNum, intOrderNum - 1);
//4、获取上一个序号字段的关键字StructureNodeId
strPrevStructureNodeId = clsge_StructureChartNodeBL.GetFirstID_S(strCondition.ToString());
if (string.IsNullOrEmpty(strPrevStructureNodeId) == true)
{
strMsg = string.Format("获取上一条记录的关键字出错.(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//5、把当前关键字StructureNodeId所对应记录的序号减1
//6、把下(上)一个序号关键字StructureNodeId所对应的记录序号加1
clsge_StructureChartNodeBL.SetFldValue(clsge_StructureChartNodeEN._CurrTabName, conge_StructureChartNode.OrderNum,
intOrderNum - 1,
string.Format("{0} = '{1}'", conge_StructureChartNode.StructureNodeId, strStructureNodeId));
clsge_StructureChartNodeBL.SetFldValue(clsge_StructureChartNodeEN._CurrTabName, conge_StructureChartNode.OrderNum,
intPrevOrderNum + 1,
string.Format("{0} = '{1}'", conge_StructureChartNode.StructureNodeId, strPrevStructureNodeId));
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

//4、获取下一个序号字段的关键字StructureNodeId
strCondition.AppendFormat(" {0} = {1}", conge_StructureChartNode.OrderNum, intOrderNum + 1);

strNextStructureNodeId = clsge_StructureChartNodeBL.GetFirstID_S(strCondition.ToString());
if (string.IsNullOrEmpty(strNextStructureNodeId) == true)
{
strMsg = string.Format("获取下一条记录的关键字出错.(from {0})", clsStackTrace.GetCurrClassFunction());

throw new Exception(strMsg);
}
//5、把当前关键字StructureNodeId所对应记录的序号加1
//6、把下(上)一个序号关键字StructureNodeId所对应的记录序号减1
clsge_StructureChartNodeBL.SetFldValue(clsge_StructureChartNodeEN._CurrTabName, conge_StructureChartNode.OrderNum,
intOrderNum + 1,
string.Format("{0} = '{1}'", conge_StructureChartNode.StructureNodeId, strStructureNodeId));
clsge_StructureChartNodeBL.SetFldValue(clsge_StructureChartNodeEN._CurrTabName, conge_StructureChartNode.OrderNum,
 	 	intNextOrderNum - 1,
 	 	string.Format("{0} = '{1}'", conge_StructureChartNode.StructureNodeId, strNextStructureNodeId));
break;
default:
strMsg = string.Format("方向参数出错!strDirect=[{0}]({1})",
strDirect,
clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
clsge_StructureChartNodeBL.ReFreshCache(objge_StructureChartNode.StructureGraphId);
if (clsge_StructureChartNodeBL.relatedActions != null)
{
clsge_StructureChartNodeBL.relatedActions.UpdRelaTabDate(objge_StructureChartNode.StructureNodeId, "UpdRelaTabDate");
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
string strCondition = string.Format("{0} in ({1})", conge_StructureChartNode.StructureNodeId, strKeyList);
List<clsge_StructureChartNodeEN> arrge_StructureChartNodeLst = GetObjLst(strCondition);
foreach (clsge_StructureChartNodeEN objge_StructureChartNode in arrge_StructureChartNodeLst)
{
objge_StructureChartNode.OrderNum = objge_StructureChartNode.OrderNum + 10000;
UpdateBySql2(objge_StructureChartNode);
}
strCondition = string.Format("1 = 1 order by {0} ", conge_StructureChartNode.OrderNum); 
List<clsge_StructureChartNodeEN> arrge_StructureChartNodeObjList = new clsge_StructureChartNodeDA().GetObjLst(strCondition);
    
int intIndex = 1;
foreach (clsge_StructureChartNodeEN objge_StructureChartNode in arrge_StructureChartNodeObjList)
{
objge_StructureChartNode.OrderNum = intIndex;
UpdateBySql2(objge_StructureChartNode);
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
string strCondition = string.Format("{0} in ({1})", conge_StructureChartNode.StructureNodeId, strKeyList);
List<clsge_StructureChartNodeEN> arrge_StructureChartNodeLst = GetObjLst(strCondition);
foreach (clsge_StructureChartNodeEN objge_StructureChartNode in arrge_StructureChartNodeLst)
{
objge_StructureChartNode.OrderNum = objge_StructureChartNode.OrderNum - 10000;
UpdateBySql2(objge_StructureChartNode);
}
strCondition = string.Format("1 = 1 order by {0} ", conge_StructureChartNode.OrderNum); 
List<clsge_StructureChartNodeEN> arrge_StructureChartNodeObjList = new clsge_StructureChartNodeDA().GetObjLst(strCondition);
    
int intIndex = 1;
foreach (clsge_StructureChartNodeEN objge_StructureChartNode in arrge_StructureChartNodeObjList)
{
objge_StructureChartNode.OrderNum = intIndex;
UpdateBySql2(objge_StructureChartNode);
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
 /// 知识点结构图(ge_StructureChartNode)
 /// 数据源类型:表
 /// (AutoGCLib.CommFun4BL4CSharp:GeneCode_This)
 /// </summary>
public class  clsCommFun4BL4ge_StructureChartNode : clsCommFun4BLV2
{

 /// <summary>
 /// 刷新缓存.把当前表的缓存以及该表相关视图的缓存清空.
 /// (AutoGCLib.CommFun4BL4CSharp:Gen_4CFBL_ReFreshCache)
 /// </summary>
public override void ReFreshCache(string strStructureGraphId)
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
clsge_StructureChartNodeBL.ReFreshThisCache(strStructureGraphId);
}
}

}