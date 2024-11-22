
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsge_ConnectLookChartNodeBL
 表名:ge_ConnectLookChartNode(01120917)
 * 版本:2024.11.13.1(服务器:WIN-SRV103-116)
 日期:2024/11/13 06:12:40
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
public static class  clsge_ConnectLookChartNodeBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "strConnectLookNodeId">表关键字</param>
 /// <returns>表对象</returns>
public static clsge_ConnectLookChartNodeEN GetObj(this K_ConnectLookNodeId_ge_ConnectLookChartNode myKey)
{
clsge_ConnectLookChartNodeEN objge_ConnectLookChartNodeEN = clsge_ConnectLookChartNodeBL.ge_ConnectLookChartNodeDA.GetObjByConnectLookNodeId(myKey.Value);
return objge_ConnectLookChartNodeEN;
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_AddNewRecord)
 /// </summary>
 /// <param name = "objge_ConnectLookChartNodeEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clsge_ConnectLookChartNodeEN objge_ConnectLookChartNodeEN, bool bolIsNeedCheckUniqueness = true)
{
 if (string.IsNullOrEmpty(objge_ConnectLookChartNodeEN.ConnectLookNodeId) == true)
 {
string strMsg = string.Format("添加记录时,关键字不能为空!(from {0})\r\n", 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
 if (clsge_ConnectLookChartNodeBL.IsExist(objge_ConnectLookChartNodeEN.ConnectLookNodeId) == true)
 {
string strMsg = string.Format("添加记录时,关键字:[{0}]已经存在!(from {1})\r\n", objge_ConnectLookChartNodeEN.ConnectLookNodeId, 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
if (bolIsNeedCheckUniqueness == true && CheckUniqueness(objge_ConnectLookChartNodeEN) == false)
{
var strMsg = string.Format("记录已经存在!连连看节点Id = [{0}]的数据已经存在!(in clsge_ConnectLookChartNodeBL.AddNewRecord)", objge_ConnectLookChartNodeEN.ConnectLookNodeId);
throw new Exception(strMsg);
}
try
{
bool bolResult = clsge_ConnectLookChartNodeBL.ge_ConnectLookChartNodeDA.AddNewRecordBySQL2(objge_ConnectLookChartNodeEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsge_ConnectLookChartNodeBL.ReFreshCache(objge_ConnectLookChartNodeEN.ConnectLookChartId);

if (clsge_ConnectLookChartNodeBL.relatedActions != null)
{
clsge_ConnectLookChartNodeBL.relatedActions.UpdRelaTabDate(objge_ConnectLookChartNodeEN.ConnectLookNodeId, "SetUpdDate");
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
public static bool AddRecordEx(this clsge_ConnectLookChartNodeEN objge_ConnectLookChartNodeEN, bool bolIsNeedCheckUniqueness = true)
{
//操作步骤:
//1、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在
//2、检查唯一性
//3、检查传进去的对象属性是否合法
//4、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
//1、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在
if (clsge_ConnectLookChartNodeBL.IsExist(objge_ConnectLookChartNodeEN.ConnectLookNodeId))	//判断是否有相同的关键字
{
strMsg = "(errid:Busi000151)关键字字段已有相同的值";
throw new Exception(strMsg);
}
try
{
 //2、检查传进去的对象属性是否合法
objge_ConnectLookChartNodeEN.CheckPropertyNew();
 ///5.2、检查唯一性
if (bolIsNeedCheckUniqueness == true && objge_ConnectLookChartNodeEN.CheckUniqueness() == false)
{
strMsg = string.Format("(连连看节点Id(ConnectLookNodeId)=[{0}])已经存在,不能重复!", objge_ConnectLookChartNodeEN.ConnectLookNodeId);
throw new Exception(strMsg);
}
//6、把数据实体层的数据存贮到数据库中
objge_ConnectLookChartNodeEN.AddNewRecord();
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
 /// <param name = "objge_ConnectLookChartNodeEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordWithReturnKey(this clsge_ConnectLookChartNodeEN objge_ConnectLookChartNodeEN, bool bolIsNeedCheckUniqueness = true)
{
 if (string.IsNullOrEmpty(objge_ConnectLookChartNodeEN.ConnectLookNodeId) == true)
 {
string strMsg = string.Format("添加记录时,关键字不能为空!(from {{0}})", 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
 if (clsge_ConnectLookChartNodeBL.IsExist(objge_ConnectLookChartNodeEN.ConnectLookNodeId) == true)
 {
string strMsg = string.Format("添加记录时,关键字:[{0}]已经存在!(from {1})\r\n", objge_ConnectLookChartNodeEN.ConnectLookNodeId, 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
if (bolIsNeedCheckUniqueness == true && CheckUniqueness(objge_ConnectLookChartNodeEN) == false)
{
var strMsg = string.Format("记录已经存在!连连看节点Id = [{0}]的数据已经存在!(in clsge_ConnectLookChartNodeBL.AddNewRecordWithReturnKey)", objge_ConnectLookChartNodeEN.ConnectLookNodeId);
throw new Exception(strMsg);
}
try
{
string strKey = clsge_ConnectLookChartNodeBL.ge_ConnectLookChartNodeDA.AddNewRecordBySQL2WithReturnKey(objge_ConnectLookChartNodeEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsge_ConnectLookChartNodeBL.ReFreshCache(objge_ConnectLookChartNodeEN.ConnectLookChartId);

if (clsge_ConnectLookChartNodeBL.relatedActions != null)
{
clsge_ConnectLookChartNodeBL.relatedActions.UpdRelaTabDate(objge_ConnectLookChartNodeEN.ConnectLookNodeId, "SetUpdDate");
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
 /// <param name = "objge_ConnectLookChartNodeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsge_ConnectLookChartNodeEN SetConnectLookNodeId(this clsge_ConnectLookChartNodeEN objge_ConnectLookChartNodeEN, string strConnectLookNodeId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strConnectLookNodeId, 10, conge_ConnectLookChartNode.ConnectLookNodeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strConnectLookNodeId, 10, conge_ConnectLookChartNode.ConnectLookNodeId);
}
objge_ConnectLookChartNodeEN.ConnectLookNodeId = strConnectLookNodeId; //连连看节点Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objge_ConnectLookChartNodeEN.dicFldComparisonOp.ContainsKey(conge_ConnectLookChartNode.ConnectLookNodeId) == false)
{
objge_ConnectLookChartNodeEN.dicFldComparisonOp.Add(conge_ConnectLookChartNode.ConnectLookNodeId, strComparisonOp);
}
else
{
objge_ConnectLookChartNodeEN.dicFldComparisonOp[conge_ConnectLookChartNode.ConnectLookNodeId] = strComparisonOp;
}
}
return objge_ConnectLookChartNodeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objge_ConnectLookChartNodeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsge_ConnectLookChartNodeEN SetConnectLookNodeName(this clsge_ConnectLookChartNodeEN objge_ConnectLookChartNodeEN, string strConnectLookNodeName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strConnectLookNodeName, 100, conge_ConnectLookChartNode.ConnectLookNodeName);
}
objge_ConnectLookChartNodeEN.ConnectLookNodeName = strConnectLookNodeName; //连连看节点名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objge_ConnectLookChartNodeEN.dicFldComparisonOp.ContainsKey(conge_ConnectLookChartNode.ConnectLookNodeName) == false)
{
objge_ConnectLookChartNodeEN.dicFldComparisonOp.Add(conge_ConnectLookChartNode.ConnectLookNodeName, strComparisonOp);
}
else
{
objge_ConnectLookChartNodeEN.dicFldComparisonOp[conge_ConnectLookChartNode.ConnectLookNodeName] = strComparisonOp;
}
}
return objge_ConnectLookChartNodeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objge_ConnectLookChartNodeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsge_ConnectLookChartNodeEN SetConnectLookChartId(this clsge_ConnectLookChartNodeEN objge_ConnectLookChartNodeEN, string strConnectLookChartId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strConnectLookChartId, conge_ConnectLookChartNode.ConnectLookChartId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strConnectLookChartId, 10, conge_ConnectLookChartNode.ConnectLookChartId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strConnectLookChartId, 10, conge_ConnectLookChartNode.ConnectLookChartId);
}
objge_ConnectLookChartNodeEN.ConnectLookChartId = strConnectLookChartId; //连连看图Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objge_ConnectLookChartNodeEN.dicFldComparisonOp.ContainsKey(conge_ConnectLookChartNode.ConnectLookChartId) == false)
{
objge_ConnectLookChartNodeEN.dicFldComparisonOp.Add(conge_ConnectLookChartNode.ConnectLookChartId, strComparisonOp);
}
else
{
objge_ConnectLookChartNodeEN.dicFldComparisonOp[conge_ConnectLookChartNode.ConnectLookChartId] = strComparisonOp;
}
}
return objge_ConnectLookChartNodeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objge_ConnectLookChartNodeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsge_ConnectLookChartNodeEN SetXPosition(this clsge_ConnectLookChartNodeEN objge_ConnectLookChartNodeEN, float? fltXPosition, string strComparisonOp="")
	{
objge_ConnectLookChartNodeEN.XPosition = fltXPosition; //X_坐标
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objge_ConnectLookChartNodeEN.dicFldComparisonOp.ContainsKey(conge_ConnectLookChartNode.XPosition) == false)
{
objge_ConnectLookChartNodeEN.dicFldComparisonOp.Add(conge_ConnectLookChartNode.XPosition, strComparisonOp);
}
else
{
objge_ConnectLookChartNodeEN.dicFldComparisonOp[conge_ConnectLookChartNode.XPosition] = strComparisonOp;
}
}
return objge_ConnectLookChartNodeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objge_ConnectLookChartNodeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsge_ConnectLookChartNodeEN SetYPosition(this clsge_ConnectLookChartNodeEN objge_ConnectLookChartNodeEN, float? fltYPosition, string strComparisonOp="")
	{
objge_ConnectLookChartNodeEN.YPosition = fltYPosition; //Y_坐标
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objge_ConnectLookChartNodeEN.dicFldComparisonOp.ContainsKey(conge_ConnectLookChartNode.YPosition) == false)
{
objge_ConnectLookChartNodeEN.dicFldComparisonOp.Add(conge_ConnectLookChartNode.YPosition, strComparisonOp);
}
else
{
objge_ConnectLookChartNodeEN.dicFldComparisonOp[conge_ConnectLookChartNode.YPosition] = strComparisonOp;
}
}
return objge_ConnectLookChartNodeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objge_ConnectLookChartNodeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsge_ConnectLookChartNodeEN SetLogicNodeId(this clsge_ConnectLookChartNodeEN objge_ConnectLookChartNodeEN, string strLogicNodeId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strLogicNodeId, 20, conge_ConnectLookChartNode.LogicNodeId);
}
objge_ConnectLookChartNodeEN.LogicNodeId = strLogicNodeId; //逻辑节点Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objge_ConnectLookChartNodeEN.dicFldComparisonOp.ContainsKey(conge_ConnectLookChartNode.LogicNodeId) == false)
{
objge_ConnectLookChartNodeEN.dicFldComparisonOp.Add(conge_ConnectLookChartNode.LogicNodeId, strComparisonOp);
}
else
{
objge_ConnectLookChartNodeEN.dicFldComparisonOp[conge_ConnectLookChartNode.LogicNodeId] = strComparisonOp;
}
}
return objge_ConnectLookChartNodeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objge_ConnectLookChartNodeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsge_ConnectLookChartNodeEN SetClassName(this clsge_ConnectLookChartNodeEN objge_ConnectLookChartNodeEN, string strClassName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strClassName, 100, conge_ConnectLookChartNode.ClassName);
}
objge_ConnectLookChartNodeEN.ClassName = strClassName; //样式名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objge_ConnectLookChartNodeEN.dicFldComparisonOp.ContainsKey(conge_ConnectLookChartNode.ClassName) == false)
{
objge_ConnectLookChartNodeEN.dicFldComparisonOp.Add(conge_ConnectLookChartNode.ClassName, strComparisonOp);
}
else
{
objge_ConnectLookChartNodeEN.dicFldComparisonOp[conge_ConnectLookChartNode.ClassName] = strComparisonOp;
}
}
return objge_ConnectLookChartNodeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objge_ConnectLookChartNodeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsge_ConnectLookChartNodeEN SetUpdDate(this clsge_ConnectLookChartNodeEN objge_ConnectLookChartNodeEN, string strUpdDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdDate, 20, conge_ConnectLookChartNode.UpdDate);
}
objge_ConnectLookChartNodeEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objge_ConnectLookChartNodeEN.dicFldComparisonOp.ContainsKey(conge_ConnectLookChartNode.UpdDate) == false)
{
objge_ConnectLookChartNodeEN.dicFldComparisonOp.Add(conge_ConnectLookChartNode.UpdDate, strComparisonOp);
}
else
{
objge_ConnectLookChartNodeEN.dicFldComparisonOp[conge_ConnectLookChartNode.UpdDate] = strComparisonOp;
}
}
return objge_ConnectLookChartNodeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objge_ConnectLookChartNodeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsge_ConnectLookChartNodeEN SetUpdUser(this clsge_ConnectLookChartNodeEN objge_ConnectLookChartNodeEN, string strUpdUser, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdUser, 20, conge_ConnectLookChartNode.UpdUser);
}
objge_ConnectLookChartNodeEN.UpdUser = strUpdUser; //修改人
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objge_ConnectLookChartNodeEN.dicFldComparisonOp.ContainsKey(conge_ConnectLookChartNode.UpdUser) == false)
{
objge_ConnectLookChartNodeEN.dicFldComparisonOp.Add(conge_ConnectLookChartNode.UpdUser, strComparisonOp);
}
else
{
objge_ConnectLookChartNodeEN.dicFldComparisonOp[conge_ConnectLookChartNode.UpdUser] = strComparisonOp;
}
}
return objge_ConnectLookChartNodeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objge_ConnectLookChartNodeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsge_ConnectLookChartNodeEN SetMemo(this clsge_ConnectLookChartNodeEN objge_ConnectLookChartNodeEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, conge_ConnectLookChartNode.Memo);
}
objge_ConnectLookChartNodeEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objge_ConnectLookChartNodeEN.dicFldComparisonOp.ContainsKey(conge_ConnectLookChartNode.Memo) == false)
{
objge_ConnectLookChartNodeEN.dicFldComparisonOp.Add(conge_ConnectLookChartNode.Memo, strComparisonOp);
}
else
{
objge_ConnectLookChartNodeEN.dicFldComparisonOp[conge_ConnectLookChartNode.Memo] = strComparisonOp;
}
}
return objge_ConnectLookChartNodeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objge_ConnectLookChartNodeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsge_ConnectLookChartNodeEN SetConnectLookNodeTypeId(this clsge_ConnectLookChartNodeEN objge_ConnectLookChartNodeEN, string strConnectLookNodeTypeId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strConnectLookNodeTypeId, 2, conge_ConnectLookChartNode.ConnectLookNodeTypeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strConnectLookNodeTypeId, 2, conge_ConnectLookChartNode.ConnectLookNodeTypeId);
}
objge_ConnectLookChartNodeEN.ConnectLookNodeTypeId = strConnectLookNodeTypeId; //连连看节点类型
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objge_ConnectLookChartNodeEN.dicFldComparisonOp.ContainsKey(conge_ConnectLookChartNode.ConnectLookNodeTypeId) == false)
{
objge_ConnectLookChartNodeEN.dicFldComparisonOp.Add(conge_ConnectLookChartNode.ConnectLookNodeTypeId, strComparisonOp);
}
else
{
objge_ConnectLookChartNodeEN.dicFldComparisonOp[conge_ConnectLookChartNode.ConnectLookNodeTypeId] = strComparisonOp;
}
}
return objge_ConnectLookChartNodeEN;
	}

 /// <summary>
 /// 修改记录存盘到数据表中
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_UpdateRecordEx)
 /// </summary>
 /// <param name = "objge_ConnectLookChartNodeEN">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool UpdateRecordEx(this clsge_ConnectLookChartNodeEN objge_ConnectLookChartNodeEN)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
try
{
//1、检查传进去的对象属性是否合法
objge_ConnectLookChartNodeEN.CheckPropertyNew();
clsge_ConnectLookChartNodeEN objge_ConnectLookChartNodeCond = new clsge_ConnectLookChartNodeEN();
string strCondition = objge_ConnectLookChartNodeCond
.SetConnectLookNodeId(objge_ConnectLookChartNodeEN.ConnectLookNodeId, "<>")
.SetConnectLookNodeId(objge_ConnectLookChartNodeEN.ConnectLookNodeId, "=")
.GetCombineCondition();
objge_ConnectLookChartNodeEN._IsCheckProperty = true;
bool bolIsExist = clsge_ConnectLookChartNodeBL.IsExistRecord(strCondition);
if (bolIsExist)
{
strMsg = "(ConnectLookNodeId)不能重复!";
throw new Exception(strMsg);
}
//4、把数据实体层的数据存贮到数据库中
objge_ConnectLookChartNodeEN.Update();
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
 /// <param name = "objge_ConnectLookChartNode">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool EditRecordEx(this clsge_ConnectLookChartNodeEN objge_ConnectLookChartNode)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
clsge_ConnectLookChartNodeEN objge_ConnectLookChartNodeCond = new clsge_ConnectLookChartNodeEN();
string strCondition = objge_ConnectLookChartNodeCond
.SetConnectLookNodeId(objge_ConnectLookChartNode.ConnectLookNodeId, "=")
.GetCombineCondition();
objge_ConnectLookChartNode._IsCheckProperty = true;
bool bolIsExist = clsge_ConnectLookChartNodeBL.IsExistRecord(strCondition);
if (bolIsExist)
{
objge_ConnectLookChartNode.ConnectLookNodeId = clsge_ConnectLookChartNodeBL.GetFirstID_S(strCondition);
objge_ConnectLookChartNode.UpdateWithCondition(strCondition);
}
else
{
objge_ConnectLookChartNode.AddNewRecord();
}
return true; 
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_Update)
 /// </summary>
 /// <param name = "objge_ConnectLookChartNodeEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsge_ConnectLookChartNodeEN objge_ConnectLookChartNodeEN)
{
 if (string.IsNullOrEmpty(objge_ConnectLookChartNodeEN.ConnectLookNodeId) == true)
 {
string strMsg = string.Format("(errid:Busi000095)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsge_ConnectLookChartNodeBL.ge_ConnectLookChartNodeDA.UpdateBySql2(objge_ConnectLookChartNodeEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsge_ConnectLookChartNodeBL.ReFreshCache(objge_ConnectLookChartNodeEN.ConnectLookChartId);

if (clsge_ConnectLookChartNodeBL.relatedActions != null)
{
clsge_ConnectLookChartNodeBL.relatedActions.UpdRelaTabDate(objge_ConnectLookChartNodeEN.ConnectLookNodeId, "SetUpdDate");
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
 /// <param name = "objge_ConnectLookChartNodeEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsge_ConnectLookChartNodeEN objge_ConnectLookChartNodeEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (string.IsNullOrEmpty(objge_ConnectLookChartNodeEN.ConnectLookNodeId) == true)
 {
string strMsg = string.Format("(errid:Busi000087)修改记录时关键字不能为空!(带事务处理)(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsge_ConnectLookChartNodeBL.ge_ConnectLookChartNodeDA.UpdateBySql2(objge_ConnectLookChartNodeEN, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsge_ConnectLookChartNodeBL.ReFreshCache(objge_ConnectLookChartNodeEN.ConnectLookChartId);

if (clsge_ConnectLookChartNodeBL.relatedActions != null)
{
clsge_ConnectLookChartNodeBL.relatedActions.UpdRelaTabDate(objge_ConnectLookChartNodeEN.ConnectLookNodeId, "SetUpdDate");
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
 /// <param name = "objge_ConnectLookChartNodeEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsge_ConnectLookChartNodeEN objge_ConnectLookChartNodeEN, string strWhereCond)
{
try
{
bool bolResult = clsge_ConnectLookChartNodeBL.ge_ConnectLookChartNodeDA.UpdateBySqlWithCondition(objge_ConnectLookChartNodeEN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsge_ConnectLookChartNodeBL.ReFreshCache(objge_ConnectLookChartNodeEN.ConnectLookChartId);

if (clsge_ConnectLookChartNodeBL.relatedActions != null)
{
clsge_ConnectLookChartNodeBL.relatedActions.UpdRelaTabDate(objge_ConnectLookChartNodeEN.ConnectLookNodeId, "SetUpdDate");
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
 /// <param name = "objge_ConnectLookChartNodeEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsge_ConnectLookChartNodeEN objge_ConnectLookChartNodeEN, string strWhereCond, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
bool bolResult = clsge_ConnectLookChartNodeBL.ge_ConnectLookChartNodeDA.UpdateBySqlWithConditionTransaction(objge_ConnectLookChartNodeEN, strWhereCond, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsge_ConnectLookChartNodeBL.ReFreshCache(objge_ConnectLookChartNodeEN.ConnectLookChartId);

if (clsge_ConnectLookChartNodeBL.relatedActions != null)
{
clsge_ConnectLookChartNodeBL.relatedActions.UpdRelaTabDate(objge_ConnectLookChartNodeEN.ConnectLookNodeId, "SetUpdDate");
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
 /// <param name = "strConnectLookNodeId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int Delete(this clsge_ConnectLookChartNodeEN objge_ConnectLookChartNodeEN)
{
try
{
int intRecNum = clsge_ConnectLookChartNodeBL.ge_ConnectLookChartNodeDA.DelRecord(objge_ConnectLookChartNodeEN.ConnectLookNodeId);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsge_ConnectLookChartNodeBL.ReFreshCache(objge_ConnectLookChartNodeEN.ConnectLookChartId);

if (clsge_ConnectLookChartNodeBL.relatedActions != null)
{
clsge_ConnectLookChartNodeBL.relatedActions.UpdRelaTabDate(objge_ConnectLookChartNodeEN.ConnectLookNodeId, "SetUpdDate");
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
 /// <param name = "objge_ConnectLookChartNodeENS">源对象</param>
 /// <param name = "objge_ConnectLookChartNodeENT">目标对象</param>
 public static void CopyTo(this clsge_ConnectLookChartNodeEN objge_ConnectLookChartNodeENS, clsge_ConnectLookChartNodeEN objge_ConnectLookChartNodeENT)
{
try
{
objge_ConnectLookChartNodeENT.ConnectLookNodeId = objge_ConnectLookChartNodeENS.ConnectLookNodeId; //连连看节点Id
objge_ConnectLookChartNodeENT.ConnectLookNodeName = objge_ConnectLookChartNodeENS.ConnectLookNodeName; //连连看节点名称
objge_ConnectLookChartNodeENT.ConnectLookChartId = objge_ConnectLookChartNodeENS.ConnectLookChartId; //连连看图Id
objge_ConnectLookChartNodeENT.XPosition = objge_ConnectLookChartNodeENS.XPosition; //X_坐标
objge_ConnectLookChartNodeENT.YPosition = objge_ConnectLookChartNodeENS.YPosition; //Y_坐标
objge_ConnectLookChartNodeENT.LogicNodeId = objge_ConnectLookChartNodeENS.LogicNodeId; //逻辑节点Id
objge_ConnectLookChartNodeENT.ClassName = objge_ConnectLookChartNodeENS.ClassName; //样式名称
objge_ConnectLookChartNodeENT.UpdDate = objge_ConnectLookChartNodeENS.UpdDate; //修改日期
objge_ConnectLookChartNodeENT.UpdUser = objge_ConnectLookChartNodeENS.UpdUser; //修改人
objge_ConnectLookChartNodeENT.Memo = objge_ConnectLookChartNodeENS.Memo; //备注
objge_ConnectLookChartNodeENT.ConnectLookNodeTypeId = objge_ConnectLookChartNodeENS.ConnectLookNodeTypeId; //连连看节点类型
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
 /// <param name = "objge_ConnectLookChartNodeENS">源对象</param>
 /// <returns>目标对象=>clsge_ConnectLookChartNodeEN:objge_ConnectLookChartNodeENT</returns>
 public static clsge_ConnectLookChartNodeEN CopyTo(this clsge_ConnectLookChartNodeEN objge_ConnectLookChartNodeENS)
{
try
{
 clsge_ConnectLookChartNodeEN objge_ConnectLookChartNodeENT = new clsge_ConnectLookChartNodeEN()
{
ConnectLookNodeId = objge_ConnectLookChartNodeENS.ConnectLookNodeId, //连连看节点Id
ConnectLookNodeName = objge_ConnectLookChartNodeENS.ConnectLookNodeName, //连连看节点名称
ConnectLookChartId = objge_ConnectLookChartNodeENS.ConnectLookChartId, //连连看图Id
XPosition = objge_ConnectLookChartNodeENS.XPosition, //X_坐标
YPosition = objge_ConnectLookChartNodeENS.YPosition, //Y_坐标
LogicNodeId = objge_ConnectLookChartNodeENS.LogicNodeId, //逻辑节点Id
ClassName = objge_ConnectLookChartNodeENS.ClassName, //样式名称
UpdDate = objge_ConnectLookChartNodeENS.UpdDate, //修改日期
UpdUser = objge_ConnectLookChartNodeENS.UpdUser, //修改人
Memo = objge_ConnectLookChartNodeENS.Memo, //备注
ConnectLookNodeTypeId = objge_ConnectLookChartNodeENS.ConnectLookNodeTypeId, //连连看节点类型
};
 return objge_ConnectLookChartNodeENT;
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
public static void CheckPropertyNew(this clsge_ConnectLookChartNodeEN objge_ConnectLookChartNodeEN)
{
 clsge_ConnectLookChartNodeBL.ge_ConnectLookChartNodeDA.CheckPropertyNew(objge_ConnectLookChartNodeEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(this clsge_ConnectLookChartNodeEN objge_ConnectLookChartNodeEN)
{
 clsge_ConnectLookChartNodeBL.ge_ConnectLookChartNodeDA.CheckProperty4Condition(objge_ConnectLookChartNodeEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsge_ConnectLookChartNodeEN objge_ConnectLookChartNodeCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objge_ConnectLookChartNodeCond.IsUpdated(conge_ConnectLookChartNode.ConnectLookNodeId) == true)
{
string strComparisonOpConnectLookNodeId = objge_ConnectLookChartNodeCond.dicFldComparisonOp[conge_ConnectLookChartNode.ConnectLookNodeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conge_ConnectLookChartNode.ConnectLookNodeId, objge_ConnectLookChartNodeCond.ConnectLookNodeId, strComparisonOpConnectLookNodeId);
}
if (objge_ConnectLookChartNodeCond.IsUpdated(conge_ConnectLookChartNode.ConnectLookNodeName) == true)
{
string strComparisonOpConnectLookNodeName = objge_ConnectLookChartNodeCond.dicFldComparisonOp[conge_ConnectLookChartNode.ConnectLookNodeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", conge_ConnectLookChartNode.ConnectLookNodeName, objge_ConnectLookChartNodeCond.ConnectLookNodeName, strComparisonOpConnectLookNodeName);
}
if (objge_ConnectLookChartNodeCond.IsUpdated(conge_ConnectLookChartNode.ConnectLookChartId) == true)
{
string strComparisonOpConnectLookChartId = objge_ConnectLookChartNodeCond.dicFldComparisonOp[conge_ConnectLookChartNode.ConnectLookChartId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conge_ConnectLookChartNode.ConnectLookChartId, objge_ConnectLookChartNodeCond.ConnectLookChartId, strComparisonOpConnectLookChartId);
}
if (objge_ConnectLookChartNodeCond.IsUpdated(conge_ConnectLookChartNode.XPosition) == true)
{
string strComparisonOpXPosition = objge_ConnectLookChartNodeCond.dicFldComparisonOp[conge_ConnectLookChartNode.XPosition];
strWhereCond += string.Format(" And {0} {2} {1}", conge_ConnectLookChartNode.XPosition, objge_ConnectLookChartNodeCond.XPosition, strComparisonOpXPosition);
}
if (objge_ConnectLookChartNodeCond.IsUpdated(conge_ConnectLookChartNode.YPosition) == true)
{
string strComparisonOpYPosition = objge_ConnectLookChartNodeCond.dicFldComparisonOp[conge_ConnectLookChartNode.YPosition];
strWhereCond += string.Format(" And {0} {2} {1}", conge_ConnectLookChartNode.YPosition, objge_ConnectLookChartNodeCond.YPosition, strComparisonOpYPosition);
}
if (objge_ConnectLookChartNodeCond.IsUpdated(conge_ConnectLookChartNode.LogicNodeId) == true)
{
string strComparisonOpLogicNodeId = objge_ConnectLookChartNodeCond.dicFldComparisonOp[conge_ConnectLookChartNode.LogicNodeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conge_ConnectLookChartNode.LogicNodeId, objge_ConnectLookChartNodeCond.LogicNodeId, strComparisonOpLogicNodeId);
}
if (objge_ConnectLookChartNodeCond.IsUpdated(conge_ConnectLookChartNode.ClassName) == true)
{
string strComparisonOpClassName = objge_ConnectLookChartNodeCond.dicFldComparisonOp[conge_ConnectLookChartNode.ClassName];
strWhereCond += string.Format(" And {0} {2} '{1}'", conge_ConnectLookChartNode.ClassName, objge_ConnectLookChartNodeCond.ClassName, strComparisonOpClassName);
}
if (objge_ConnectLookChartNodeCond.IsUpdated(conge_ConnectLookChartNode.UpdDate) == true)
{
string strComparisonOpUpdDate = objge_ConnectLookChartNodeCond.dicFldComparisonOp[conge_ConnectLookChartNode.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conge_ConnectLookChartNode.UpdDate, objge_ConnectLookChartNodeCond.UpdDate, strComparisonOpUpdDate);
}
if (objge_ConnectLookChartNodeCond.IsUpdated(conge_ConnectLookChartNode.UpdUser) == true)
{
string strComparisonOpUpdUser = objge_ConnectLookChartNodeCond.dicFldComparisonOp[conge_ConnectLookChartNode.UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", conge_ConnectLookChartNode.UpdUser, objge_ConnectLookChartNodeCond.UpdUser, strComparisonOpUpdUser);
}
if (objge_ConnectLookChartNodeCond.IsUpdated(conge_ConnectLookChartNode.Memo) == true)
{
string strComparisonOpMemo = objge_ConnectLookChartNodeCond.dicFldComparisonOp[conge_ConnectLookChartNode.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", conge_ConnectLookChartNode.Memo, objge_ConnectLookChartNodeCond.Memo, strComparisonOpMemo);
}
if (objge_ConnectLookChartNodeCond.IsUpdated(conge_ConnectLookChartNode.ConnectLookNodeTypeId) == true)
{
string strComparisonOpConnectLookNodeTypeId = objge_ConnectLookChartNodeCond.dicFldComparisonOp[conge_ConnectLookChartNode.ConnectLookNodeTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conge_ConnectLookChartNode.ConnectLookNodeTypeId, objge_ConnectLookChartNodeCond.ConnectLookNodeTypeId, strComparisonOpConnectLookNodeTypeId);
}
 return strWhereCond;
}

 /// <summary>
 /// 检查唯一性(Uniqueness)--ge_ConnectLookChartNode(连连看图节点), 如果不唯一,即存在相同的记录,就返回False
 /// 唯一性条件:ConnectLookNodeId
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckConstraint)
 /// </summary>
 /// <param name = "objge_ConnectLookChartNodeEN">要求唯一的对象</param>
 /// <returns></returns>
public static bool CheckUniqueness(this clsge_ConnectLookChartNodeEN objge_ConnectLookChartNodeEN)
{
//检测记录是否存在
bool bolIsUniqueness;
StringBuilder sbCondition = new StringBuilder();
if (objge_ConnectLookChartNodeEN == null) return true;
if (objge_ConnectLookChartNodeEN.ConnectLookNodeId == null || objge_ConnectLookChartNodeEN.ConnectLookNodeId == "")
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and ConnectLookNodeId = '{0}'", objge_ConnectLookChartNodeEN.ConnectLookNodeId);
if (clsge_ConnectLookChartNodeBL.IsExistRecord(sbCondition.ToString())  ==  true)
{
 bolIsUniqueness = false;
}
else
{
 bolIsUniqueness = true;
}
}
 else {
sbCondition.AppendFormat("ConnectLookNodeId !=  '{0}'", objge_ConnectLookChartNodeEN.ConnectLookNodeId);
 sbCondition.AppendFormat(" and ConnectLookNodeId = '{0}'", objge_ConnectLookChartNodeEN.ConnectLookNodeId);
if (clsge_ConnectLookChartNodeBL.IsExistRecord(sbCondition.ToString())  ==  true)
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
 /// 获取唯一性条件串--ge_ConnectLookChartNode(连连看图节点), 即由对象中唯一性条件字段关键字与值组成的条件串
 /// 唯一性条件:ConnectLookNodeId
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetConditionString4Constraint)
 /// </summary>
 /// <param name = "objge_ConnectLookChartNodeEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(this clsge_ConnectLookChartNodeEN objge_ConnectLookChartNodeEN)
{
//检测记录是否存在
StringBuilder sbCondition = new StringBuilder();
if (objge_ConnectLookChartNodeEN == null) return "";
if (objge_ConnectLookChartNodeEN.ConnectLookNodeId == null || objge_ConnectLookChartNodeEN.ConnectLookNodeId == "")
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and ConnectLookNodeId = '{0}'", objge_ConnectLookChartNodeEN.ConnectLookNodeId);
return sbCondition.ToString();
}
 else {
sbCondition.AppendFormat("ConnectLookNodeId !=  '{0}'", objge_ConnectLookChartNodeEN.ConnectLookNodeId);
 sbCondition.AppendFormat(" and ConnectLookNodeId = '{0}'", objge_ConnectLookChartNodeEN.ConnectLookNodeId);
 return sbCondition.ToString();
}
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_ge_ConnectLookChartNode
{
public virtual bool UpdRelaTabDate(string strConnectLookNodeId, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// 连连看图节点(ge_ConnectLookChartNode)
 /// 数据源类型:表
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsge_ConnectLookChartNodeBL
{
public static RelatedActions_ge_ConnectLookChartNode relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsge_ConnectLookChartNodeDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsge_ConnectLookChartNodeDA ge_ConnectLookChartNodeDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsge_ConnectLookChartNodeDA();
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
 public clsge_ConnectLookChartNodeBL()
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
if (string.IsNullOrEmpty(clsge_ConnectLookChartNodeEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsge_ConnectLookChartNodeEN._ConnectString);
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
public static DataTable GetDataTable_ge_ConnectLookChartNode(string strWhereCond)
{
DataTable objDT;
try
{
objDT = ge_ConnectLookChartNodeDA.GetDataTable_ge_ConnectLookChartNode(strWhereCond);
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
objDT = ge_ConnectLookChartNodeDA.GetDataTable(strWhereCond);
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
objDT = ge_ConnectLookChartNodeDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = ge_ConnectLookChartNodeDA.GetDataTable(strWhereCond, strTabName);
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
objDT = ge_ConnectLookChartNodeDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = ge_ConnectLookChartNodeDA.GetDataTable_Top(objTopPara);
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
objDT = ge_ConnectLookChartNodeDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = ge_ConnectLookChartNodeDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = ge_ConnectLookChartNodeDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
 /// <param name = "arrConnectLookNodeIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static List<clsge_ConnectLookChartNodeEN> GetObjLstByConnectLookNodeIdLst(List<string> arrConnectLookNodeIdLst)
{
List<clsge_ConnectLookChartNodeEN> arrObjLst = new List<clsge_ConnectLookChartNodeEN>(); 
System.Data.DataTable objDT; 
 string strSqlConditionStr = clsArray.GetSqlInStrByArray(arrConnectLookNodeIdLst, true);
 string strWhereCond = string.Format("ConnectLookNodeId in ({0})", strSqlConditionStr);
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsge_ConnectLookChartNodeEN objge_ConnectLookChartNodeEN = new clsge_ConnectLookChartNodeEN();
try
{
objge_ConnectLookChartNodeEN.ConnectLookNodeId = objRow[conge_ConnectLookChartNode.ConnectLookNodeId].ToString().Trim(); //连连看节点Id
objge_ConnectLookChartNodeEN.ConnectLookNodeName = objRow[conge_ConnectLookChartNode.ConnectLookNodeName] == DBNull.Value ? null : objRow[conge_ConnectLookChartNode.ConnectLookNodeName].ToString().Trim(); //连连看节点名称
objge_ConnectLookChartNodeEN.ConnectLookChartId = objRow[conge_ConnectLookChartNode.ConnectLookChartId].ToString().Trim(); //连连看图Id
objge_ConnectLookChartNodeEN.XPosition = objRow[conge_ConnectLookChartNode.XPosition] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conge_ConnectLookChartNode.XPosition].ToString().Trim()); //X_坐标
objge_ConnectLookChartNodeEN.YPosition = objRow[conge_ConnectLookChartNode.YPosition] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conge_ConnectLookChartNode.YPosition].ToString().Trim()); //Y_坐标
objge_ConnectLookChartNodeEN.LogicNodeId = objRow[conge_ConnectLookChartNode.LogicNodeId] == DBNull.Value ? null : objRow[conge_ConnectLookChartNode.LogicNodeId].ToString().Trim(); //逻辑节点Id
objge_ConnectLookChartNodeEN.ClassName = objRow[conge_ConnectLookChartNode.ClassName] == DBNull.Value ? null : objRow[conge_ConnectLookChartNode.ClassName].ToString().Trim(); //样式名称
objge_ConnectLookChartNodeEN.UpdDate = objRow[conge_ConnectLookChartNode.UpdDate] == DBNull.Value ? null : objRow[conge_ConnectLookChartNode.UpdDate].ToString().Trim(); //修改日期
objge_ConnectLookChartNodeEN.UpdUser = objRow[conge_ConnectLookChartNode.UpdUser] == DBNull.Value ? null : objRow[conge_ConnectLookChartNode.UpdUser].ToString().Trim(); //修改人
objge_ConnectLookChartNodeEN.Memo = objRow[conge_ConnectLookChartNode.Memo] == DBNull.Value ? null : objRow[conge_ConnectLookChartNode.Memo].ToString().Trim(); //备注
objge_ConnectLookChartNodeEN.ConnectLookNodeTypeId = objRow[conge_ConnectLookChartNode.ConnectLookNodeTypeId] == DBNull.Value ? null : objRow[conge_ConnectLookChartNode.ConnectLookNodeTypeId].ToString().Trim(); //连连看节点类型
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objge_ConnectLookChartNodeEN.ConnectLookNodeId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objge_ConnectLookChartNodeEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrConnectLookNodeIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsge_ConnectLookChartNodeEN> GetObjLstByConnectLookNodeIdLstCache(List<string> arrConnectLookNodeIdLst, string strConnectLookChartId)
{
string strKey = string.Format("{0}_{1}", clsge_ConnectLookChartNodeEN._CurrTabName, strConnectLookChartId);
List<clsge_ConnectLookChartNodeEN> arrge_ConnectLookChartNodeObjLstCache = GetObjLstCache(strConnectLookChartId);
IEnumerable <clsge_ConnectLookChartNodeEN> arrge_ConnectLookChartNodeObjLst_Sel =
arrge_ConnectLookChartNodeObjLstCache
.Where(x => arrConnectLookNodeIdLst.Contains(x.ConnectLookNodeId));
return arrge_ConnectLookChartNodeObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsge_ConnectLookChartNodeEN> GetObjLst(string strWhereCond)
{
List<clsge_ConnectLookChartNodeEN> arrObjLst = new List<clsge_ConnectLookChartNodeEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsge_ConnectLookChartNodeEN objge_ConnectLookChartNodeEN = new clsge_ConnectLookChartNodeEN();
try
{
objge_ConnectLookChartNodeEN.ConnectLookNodeId = objRow[conge_ConnectLookChartNode.ConnectLookNodeId].ToString().Trim(); //连连看节点Id
objge_ConnectLookChartNodeEN.ConnectLookNodeName = objRow[conge_ConnectLookChartNode.ConnectLookNodeName] == DBNull.Value ? null : objRow[conge_ConnectLookChartNode.ConnectLookNodeName].ToString().Trim(); //连连看节点名称
objge_ConnectLookChartNodeEN.ConnectLookChartId = objRow[conge_ConnectLookChartNode.ConnectLookChartId].ToString().Trim(); //连连看图Id
objge_ConnectLookChartNodeEN.XPosition = objRow[conge_ConnectLookChartNode.XPosition] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conge_ConnectLookChartNode.XPosition].ToString().Trim()); //X_坐标
objge_ConnectLookChartNodeEN.YPosition = objRow[conge_ConnectLookChartNode.YPosition] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conge_ConnectLookChartNode.YPosition].ToString().Trim()); //Y_坐标
objge_ConnectLookChartNodeEN.LogicNodeId = objRow[conge_ConnectLookChartNode.LogicNodeId] == DBNull.Value ? null : objRow[conge_ConnectLookChartNode.LogicNodeId].ToString().Trim(); //逻辑节点Id
objge_ConnectLookChartNodeEN.ClassName = objRow[conge_ConnectLookChartNode.ClassName] == DBNull.Value ? null : objRow[conge_ConnectLookChartNode.ClassName].ToString().Trim(); //样式名称
objge_ConnectLookChartNodeEN.UpdDate = objRow[conge_ConnectLookChartNode.UpdDate] == DBNull.Value ? null : objRow[conge_ConnectLookChartNode.UpdDate].ToString().Trim(); //修改日期
objge_ConnectLookChartNodeEN.UpdUser = objRow[conge_ConnectLookChartNode.UpdUser] == DBNull.Value ? null : objRow[conge_ConnectLookChartNode.UpdUser].ToString().Trim(); //修改人
objge_ConnectLookChartNodeEN.Memo = objRow[conge_ConnectLookChartNode.Memo] == DBNull.Value ? null : objRow[conge_ConnectLookChartNode.Memo].ToString().Trim(); //备注
objge_ConnectLookChartNodeEN.ConnectLookNodeTypeId = objRow[conge_ConnectLookChartNode.ConnectLookNodeTypeId] == DBNull.Value ? null : objRow[conge_ConnectLookChartNode.ConnectLookNodeTypeId].ToString().Trim(); //连连看节点类型
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objge_ConnectLookChartNodeEN.ConnectLookNodeId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objge_ConnectLookChartNodeEN);
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
public static List<clsge_ConnectLookChartNodeEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsge_ConnectLookChartNodeEN> arrObjLst = new List<clsge_ConnectLookChartNodeEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsge_ConnectLookChartNodeEN objge_ConnectLookChartNodeEN = new clsge_ConnectLookChartNodeEN();
try
{
objge_ConnectLookChartNodeEN.ConnectLookNodeId = objRow[conge_ConnectLookChartNode.ConnectLookNodeId].ToString().Trim(); //连连看节点Id
objge_ConnectLookChartNodeEN.ConnectLookNodeName = objRow[conge_ConnectLookChartNode.ConnectLookNodeName] == DBNull.Value ? null : objRow[conge_ConnectLookChartNode.ConnectLookNodeName].ToString().Trim(); //连连看节点名称
objge_ConnectLookChartNodeEN.ConnectLookChartId = objRow[conge_ConnectLookChartNode.ConnectLookChartId].ToString().Trim(); //连连看图Id
objge_ConnectLookChartNodeEN.XPosition = objRow[conge_ConnectLookChartNode.XPosition] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conge_ConnectLookChartNode.XPosition].ToString().Trim()); //X_坐标
objge_ConnectLookChartNodeEN.YPosition = objRow[conge_ConnectLookChartNode.YPosition] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conge_ConnectLookChartNode.YPosition].ToString().Trim()); //Y_坐标
objge_ConnectLookChartNodeEN.LogicNodeId = objRow[conge_ConnectLookChartNode.LogicNodeId] == DBNull.Value ? null : objRow[conge_ConnectLookChartNode.LogicNodeId].ToString().Trim(); //逻辑节点Id
objge_ConnectLookChartNodeEN.ClassName = objRow[conge_ConnectLookChartNode.ClassName] == DBNull.Value ? null : objRow[conge_ConnectLookChartNode.ClassName].ToString().Trim(); //样式名称
objge_ConnectLookChartNodeEN.UpdDate = objRow[conge_ConnectLookChartNode.UpdDate] == DBNull.Value ? null : objRow[conge_ConnectLookChartNode.UpdDate].ToString().Trim(); //修改日期
objge_ConnectLookChartNodeEN.UpdUser = objRow[conge_ConnectLookChartNode.UpdUser] == DBNull.Value ? null : objRow[conge_ConnectLookChartNode.UpdUser].ToString().Trim(); //修改人
objge_ConnectLookChartNodeEN.Memo = objRow[conge_ConnectLookChartNode.Memo] == DBNull.Value ? null : objRow[conge_ConnectLookChartNode.Memo].ToString().Trim(); //备注
objge_ConnectLookChartNodeEN.ConnectLookNodeTypeId = objRow[conge_ConnectLookChartNode.ConnectLookNodeTypeId] == DBNull.Value ? null : objRow[conge_ConnectLookChartNode.ConnectLookNodeTypeId].ToString().Trim(); //连连看节点类型
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objge_ConnectLookChartNodeEN.ConnectLookNodeId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objge_ConnectLookChartNodeEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objge_ConnectLookChartNodeCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsge_ConnectLookChartNodeEN> GetSubObjLstCache(clsge_ConnectLookChartNodeEN objge_ConnectLookChartNodeCond)
{
 string strConnectLookChartId = objge_ConnectLookChartNodeCond.ConnectLookChartId;
 if (string.IsNullOrEmpty(strConnectLookChartId) == true)
{
string strMsg = string.Format("(errid:Busi000172)在表中,缓存分类字段值不能为空!(clsge_ConnectLookChartNodeBL:GetSubObjLstCache)");
throw new Exception(strMsg);
}
List<clsge_ConnectLookChartNodeEN> arrObjLstCache = GetObjLstCache(strConnectLookChartId);
IEnumerable <clsge_ConnectLookChartNodeEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conge_ConnectLookChartNode.AttributeName)
{
if (objge_ConnectLookChartNodeCond.IsUpdated(strFldName) == false) continue;
if (objge_ConnectLookChartNodeCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objge_ConnectLookChartNodeCond[strFldName].ToString());
}
else
{
if (objge_ConnectLookChartNodeCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objge_ConnectLookChartNodeCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objge_ConnectLookChartNodeCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objge_ConnectLookChartNodeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objge_ConnectLookChartNodeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objge_ConnectLookChartNodeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objge_ConnectLookChartNodeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objge_ConnectLookChartNodeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objge_ConnectLookChartNodeCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objge_ConnectLookChartNodeCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objge_ConnectLookChartNodeCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objge_ConnectLookChartNodeCond[strFldName]));
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
public static List<clsge_ConnectLookChartNodeEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsge_ConnectLookChartNodeEN> arrObjLst = new List<clsge_ConnectLookChartNodeEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsge_ConnectLookChartNodeEN objge_ConnectLookChartNodeEN = new clsge_ConnectLookChartNodeEN();
try
{
objge_ConnectLookChartNodeEN.ConnectLookNodeId = objRow[conge_ConnectLookChartNode.ConnectLookNodeId].ToString().Trim(); //连连看节点Id
objge_ConnectLookChartNodeEN.ConnectLookNodeName = objRow[conge_ConnectLookChartNode.ConnectLookNodeName] == DBNull.Value ? null : objRow[conge_ConnectLookChartNode.ConnectLookNodeName].ToString().Trim(); //连连看节点名称
objge_ConnectLookChartNodeEN.ConnectLookChartId = objRow[conge_ConnectLookChartNode.ConnectLookChartId].ToString().Trim(); //连连看图Id
objge_ConnectLookChartNodeEN.XPosition = objRow[conge_ConnectLookChartNode.XPosition] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conge_ConnectLookChartNode.XPosition].ToString().Trim()); //X_坐标
objge_ConnectLookChartNodeEN.YPosition = objRow[conge_ConnectLookChartNode.YPosition] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conge_ConnectLookChartNode.YPosition].ToString().Trim()); //Y_坐标
objge_ConnectLookChartNodeEN.LogicNodeId = objRow[conge_ConnectLookChartNode.LogicNodeId] == DBNull.Value ? null : objRow[conge_ConnectLookChartNode.LogicNodeId].ToString().Trim(); //逻辑节点Id
objge_ConnectLookChartNodeEN.ClassName = objRow[conge_ConnectLookChartNode.ClassName] == DBNull.Value ? null : objRow[conge_ConnectLookChartNode.ClassName].ToString().Trim(); //样式名称
objge_ConnectLookChartNodeEN.UpdDate = objRow[conge_ConnectLookChartNode.UpdDate] == DBNull.Value ? null : objRow[conge_ConnectLookChartNode.UpdDate].ToString().Trim(); //修改日期
objge_ConnectLookChartNodeEN.UpdUser = objRow[conge_ConnectLookChartNode.UpdUser] == DBNull.Value ? null : objRow[conge_ConnectLookChartNode.UpdUser].ToString().Trim(); //修改人
objge_ConnectLookChartNodeEN.Memo = objRow[conge_ConnectLookChartNode.Memo] == DBNull.Value ? null : objRow[conge_ConnectLookChartNode.Memo].ToString().Trim(); //备注
objge_ConnectLookChartNodeEN.ConnectLookNodeTypeId = objRow[conge_ConnectLookChartNode.ConnectLookNodeTypeId] == DBNull.Value ? null : objRow[conge_ConnectLookChartNode.ConnectLookNodeTypeId].ToString().Trim(); //连连看节点类型
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objge_ConnectLookChartNodeEN.ConnectLookNodeId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objge_ConnectLookChartNodeEN);
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
public static List<clsge_ConnectLookChartNodeEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsge_ConnectLookChartNodeEN> arrObjLst = new List<clsge_ConnectLookChartNodeEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsge_ConnectLookChartNodeEN objge_ConnectLookChartNodeEN = new clsge_ConnectLookChartNodeEN();
try
{
objge_ConnectLookChartNodeEN.ConnectLookNodeId = objRow[conge_ConnectLookChartNode.ConnectLookNodeId].ToString().Trim(); //连连看节点Id
objge_ConnectLookChartNodeEN.ConnectLookNodeName = objRow[conge_ConnectLookChartNode.ConnectLookNodeName] == DBNull.Value ? null : objRow[conge_ConnectLookChartNode.ConnectLookNodeName].ToString().Trim(); //连连看节点名称
objge_ConnectLookChartNodeEN.ConnectLookChartId = objRow[conge_ConnectLookChartNode.ConnectLookChartId].ToString().Trim(); //连连看图Id
objge_ConnectLookChartNodeEN.XPosition = objRow[conge_ConnectLookChartNode.XPosition] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conge_ConnectLookChartNode.XPosition].ToString().Trim()); //X_坐标
objge_ConnectLookChartNodeEN.YPosition = objRow[conge_ConnectLookChartNode.YPosition] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conge_ConnectLookChartNode.YPosition].ToString().Trim()); //Y_坐标
objge_ConnectLookChartNodeEN.LogicNodeId = objRow[conge_ConnectLookChartNode.LogicNodeId] == DBNull.Value ? null : objRow[conge_ConnectLookChartNode.LogicNodeId].ToString().Trim(); //逻辑节点Id
objge_ConnectLookChartNodeEN.ClassName = objRow[conge_ConnectLookChartNode.ClassName] == DBNull.Value ? null : objRow[conge_ConnectLookChartNode.ClassName].ToString().Trim(); //样式名称
objge_ConnectLookChartNodeEN.UpdDate = objRow[conge_ConnectLookChartNode.UpdDate] == DBNull.Value ? null : objRow[conge_ConnectLookChartNode.UpdDate].ToString().Trim(); //修改日期
objge_ConnectLookChartNodeEN.UpdUser = objRow[conge_ConnectLookChartNode.UpdUser] == DBNull.Value ? null : objRow[conge_ConnectLookChartNode.UpdUser].ToString().Trim(); //修改人
objge_ConnectLookChartNodeEN.Memo = objRow[conge_ConnectLookChartNode.Memo] == DBNull.Value ? null : objRow[conge_ConnectLookChartNode.Memo].ToString().Trim(); //备注
objge_ConnectLookChartNodeEN.ConnectLookNodeTypeId = objRow[conge_ConnectLookChartNode.ConnectLookNodeTypeId] == DBNull.Value ? null : objRow[conge_ConnectLookChartNode.ConnectLookNodeTypeId].ToString().Trim(); //连连看节点类型
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objge_ConnectLookChartNodeEN.ConnectLookNodeId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objge_ConnectLookChartNodeEN);
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
List<clsge_ConnectLookChartNodeEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsge_ConnectLookChartNodeEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsge_ConnectLookChartNodeEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsge_ConnectLookChartNodeEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsge_ConnectLookChartNodeEN> arrObjLst = new List<clsge_ConnectLookChartNodeEN>(); 
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
	clsge_ConnectLookChartNodeEN objge_ConnectLookChartNodeEN = new clsge_ConnectLookChartNodeEN();
try
{
objge_ConnectLookChartNodeEN.ConnectLookNodeId = objRow[conge_ConnectLookChartNode.ConnectLookNodeId].ToString().Trim(); //连连看节点Id
objge_ConnectLookChartNodeEN.ConnectLookNodeName = objRow[conge_ConnectLookChartNode.ConnectLookNodeName] == DBNull.Value ? null : objRow[conge_ConnectLookChartNode.ConnectLookNodeName].ToString().Trim(); //连连看节点名称
objge_ConnectLookChartNodeEN.ConnectLookChartId = objRow[conge_ConnectLookChartNode.ConnectLookChartId].ToString().Trim(); //连连看图Id
objge_ConnectLookChartNodeEN.XPosition = objRow[conge_ConnectLookChartNode.XPosition] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conge_ConnectLookChartNode.XPosition].ToString().Trim()); //X_坐标
objge_ConnectLookChartNodeEN.YPosition = objRow[conge_ConnectLookChartNode.YPosition] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conge_ConnectLookChartNode.YPosition].ToString().Trim()); //Y_坐标
objge_ConnectLookChartNodeEN.LogicNodeId = objRow[conge_ConnectLookChartNode.LogicNodeId] == DBNull.Value ? null : objRow[conge_ConnectLookChartNode.LogicNodeId].ToString().Trim(); //逻辑节点Id
objge_ConnectLookChartNodeEN.ClassName = objRow[conge_ConnectLookChartNode.ClassName] == DBNull.Value ? null : objRow[conge_ConnectLookChartNode.ClassName].ToString().Trim(); //样式名称
objge_ConnectLookChartNodeEN.UpdDate = objRow[conge_ConnectLookChartNode.UpdDate] == DBNull.Value ? null : objRow[conge_ConnectLookChartNode.UpdDate].ToString().Trim(); //修改日期
objge_ConnectLookChartNodeEN.UpdUser = objRow[conge_ConnectLookChartNode.UpdUser] == DBNull.Value ? null : objRow[conge_ConnectLookChartNode.UpdUser].ToString().Trim(); //修改人
objge_ConnectLookChartNodeEN.Memo = objRow[conge_ConnectLookChartNode.Memo] == DBNull.Value ? null : objRow[conge_ConnectLookChartNode.Memo].ToString().Trim(); //备注
objge_ConnectLookChartNodeEN.ConnectLookNodeTypeId = objRow[conge_ConnectLookChartNode.ConnectLookNodeTypeId] == DBNull.Value ? null : objRow[conge_ConnectLookChartNode.ConnectLookNodeTypeId].ToString().Trim(); //连连看节点类型
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objge_ConnectLookChartNodeEN.ConnectLookNodeId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objge_ConnectLookChartNodeEN);
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
public static List<clsge_ConnectLookChartNodeEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsge_ConnectLookChartNodeEN> arrObjLst = new List<clsge_ConnectLookChartNodeEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsge_ConnectLookChartNodeEN objge_ConnectLookChartNodeEN = new clsge_ConnectLookChartNodeEN();
try
{
objge_ConnectLookChartNodeEN.ConnectLookNodeId = objRow[conge_ConnectLookChartNode.ConnectLookNodeId].ToString().Trim(); //连连看节点Id
objge_ConnectLookChartNodeEN.ConnectLookNodeName = objRow[conge_ConnectLookChartNode.ConnectLookNodeName] == DBNull.Value ? null : objRow[conge_ConnectLookChartNode.ConnectLookNodeName].ToString().Trim(); //连连看节点名称
objge_ConnectLookChartNodeEN.ConnectLookChartId = objRow[conge_ConnectLookChartNode.ConnectLookChartId].ToString().Trim(); //连连看图Id
objge_ConnectLookChartNodeEN.XPosition = objRow[conge_ConnectLookChartNode.XPosition] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conge_ConnectLookChartNode.XPosition].ToString().Trim()); //X_坐标
objge_ConnectLookChartNodeEN.YPosition = objRow[conge_ConnectLookChartNode.YPosition] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conge_ConnectLookChartNode.YPosition].ToString().Trim()); //Y_坐标
objge_ConnectLookChartNodeEN.LogicNodeId = objRow[conge_ConnectLookChartNode.LogicNodeId] == DBNull.Value ? null : objRow[conge_ConnectLookChartNode.LogicNodeId].ToString().Trim(); //逻辑节点Id
objge_ConnectLookChartNodeEN.ClassName = objRow[conge_ConnectLookChartNode.ClassName] == DBNull.Value ? null : objRow[conge_ConnectLookChartNode.ClassName].ToString().Trim(); //样式名称
objge_ConnectLookChartNodeEN.UpdDate = objRow[conge_ConnectLookChartNode.UpdDate] == DBNull.Value ? null : objRow[conge_ConnectLookChartNode.UpdDate].ToString().Trim(); //修改日期
objge_ConnectLookChartNodeEN.UpdUser = objRow[conge_ConnectLookChartNode.UpdUser] == DBNull.Value ? null : objRow[conge_ConnectLookChartNode.UpdUser].ToString().Trim(); //修改人
objge_ConnectLookChartNodeEN.Memo = objRow[conge_ConnectLookChartNode.Memo] == DBNull.Value ? null : objRow[conge_ConnectLookChartNode.Memo].ToString().Trim(); //备注
objge_ConnectLookChartNodeEN.ConnectLookNodeTypeId = objRow[conge_ConnectLookChartNode.ConnectLookNodeTypeId] == DBNull.Value ? null : objRow[conge_ConnectLookChartNode.ConnectLookNodeTypeId].ToString().Trim(); //连连看节点类型
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objge_ConnectLookChartNodeEN.ConnectLookNodeId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objge_ConnectLookChartNodeEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsge_ConnectLookChartNodeEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsge_ConnectLookChartNodeEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsge_ConnectLookChartNodeEN> arrObjLst = new List<clsge_ConnectLookChartNodeEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsge_ConnectLookChartNodeEN objge_ConnectLookChartNodeEN = new clsge_ConnectLookChartNodeEN();
try
{
objge_ConnectLookChartNodeEN.ConnectLookNodeId = objRow[conge_ConnectLookChartNode.ConnectLookNodeId].ToString().Trim(); //连连看节点Id
objge_ConnectLookChartNodeEN.ConnectLookNodeName = objRow[conge_ConnectLookChartNode.ConnectLookNodeName] == DBNull.Value ? null : objRow[conge_ConnectLookChartNode.ConnectLookNodeName].ToString().Trim(); //连连看节点名称
objge_ConnectLookChartNodeEN.ConnectLookChartId = objRow[conge_ConnectLookChartNode.ConnectLookChartId].ToString().Trim(); //连连看图Id
objge_ConnectLookChartNodeEN.XPosition = objRow[conge_ConnectLookChartNode.XPosition] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conge_ConnectLookChartNode.XPosition].ToString().Trim()); //X_坐标
objge_ConnectLookChartNodeEN.YPosition = objRow[conge_ConnectLookChartNode.YPosition] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conge_ConnectLookChartNode.YPosition].ToString().Trim()); //Y_坐标
objge_ConnectLookChartNodeEN.LogicNodeId = objRow[conge_ConnectLookChartNode.LogicNodeId] == DBNull.Value ? null : objRow[conge_ConnectLookChartNode.LogicNodeId].ToString().Trim(); //逻辑节点Id
objge_ConnectLookChartNodeEN.ClassName = objRow[conge_ConnectLookChartNode.ClassName] == DBNull.Value ? null : objRow[conge_ConnectLookChartNode.ClassName].ToString().Trim(); //样式名称
objge_ConnectLookChartNodeEN.UpdDate = objRow[conge_ConnectLookChartNode.UpdDate] == DBNull.Value ? null : objRow[conge_ConnectLookChartNode.UpdDate].ToString().Trim(); //修改日期
objge_ConnectLookChartNodeEN.UpdUser = objRow[conge_ConnectLookChartNode.UpdUser] == DBNull.Value ? null : objRow[conge_ConnectLookChartNode.UpdUser].ToString().Trim(); //修改人
objge_ConnectLookChartNodeEN.Memo = objRow[conge_ConnectLookChartNode.Memo] == DBNull.Value ? null : objRow[conge_ConnectLookChartNode.Memo].ToString().Trim(); //备注
objge_ConnectLookChartNodeEN.ConnectLookNodeTypeId = objRow[conge_ConnectLookChartNode.ConnectLookNodeTypeId] == DBNull.Value ? null : objRow[conge_ConnectLookChartNode.ConnectLookNodeTypeId].ToString().Trim(); //连连看节点类型
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objge_ConnectLookChartNodeEN.ConnectLookNodeId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objge_ConnectLookChartNodeEN);
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
public static List<clsge_ConnectLookChartNodeEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsge_ConnectLookChartNodeEN> arrObjLst = new List<clsge_ConnectLookChartNodeEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsge_ConnectLookChartNodeEN objge_ConnectLookChartNodeEN = new clsge_ConnectLookChartNodeEN();
try
{
objge_ConnectLookChartNodeEN.ConnectLookNodeId = objRow[conge_ConnectLookChartNode.ConnectLookNodeId].ToString().Trim(); //连连看节点Id
objge_ConnectLookChartNodeEN.ConnectLookNodeName = objRow[conge_ConnectLookChartNode.ConnectLookNodeName] == DBNull.Value ? null : objRow[conge_ConnectLookChartNode.ConnectLookNodeName].ToString().Trim(); //连连看节点名称
objge_ConnectLookChartNodeEN.ConnectLookChartId = objRow[conge_ConnectLookChartNode.ConnectLookChartId].ToString().Trim(); //连连看图Id
objge_ConnectLookChartNodeEN.XPosition = objRow[conge_ConnectLookChartNode.XPosition] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conge_ConnectLookChartNode.XPosition].ToString().Trim()); //X_坐标
objge_ConnectLookChartNodeEN.YPosition = objRow[conge_ConnectLookChartNode.YPosition] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conge_ConnectLookChartNode.YPosition].ToString().Trim()); //Y_坐标
objge_ConnectLookChartNodeEN.LogicNodeId = objRow[conge_ConnectLookChartNode.LogicNodeId] == DBNull.Value ? null : objRow[conge_ConnectLookChartNode.LogicNodeId].ToString().Trim(); //逻辑节点Id
objge_ConnectLookChartNodeEN.ClassName = objRow[conge_ConnectLookChartNode.ClassName] == DBNull.Value ? null : objRow[conge_ConnectLookChartNode.ClassName].ToString().Trim(); //样式名称
objge_ConnectLookChartNodeEN.UpdDate = objRow[conge_ConnectLookChartNode.UpdDate] == DBNull.Value ? null : objRow[conge_ConnectLookChartNode.UpdDate].ToString().Trim(); //修改日期
objge_ConnectLookChartNodeEN.UpdUser = objRow[conge_ConnectLookChartNode.UpdUser] == DBNull.Value ? null : objRow[conge_ConnectLookChartNode.UpdUser].ToString().Trim(); //修改人
objge_ConnectLookChartNodeEN.Memo = objRow[conge_ConnectLookChartNode.Memo] == DBNull.Value ? null : objRow[conge_ConnectLookChartNode.Memo].ToString().Trim(); //备注
objge_ConnectLookChartNodeEN.ConnectLookNodeTypeId = objRow[conge_ConnectLookChartNode.ConnectLookNodeTypeId] == DBNull.Value ? null : objRow[conge_ConnectLookChartNode.ConnectLookNodeTypeId].ToString().Trim(); //连连看节点类型
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objge_ConnectLookChartNodeEN.ConnectLookNodeId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objge_ConnectLookChartNodeEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsge_ConnectLookChartNodeEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsge_ConnectLookChartNodeEN> arrObjLst = new List<clsge_ConnectLookChartNodeEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsge_ConnectLookChartNodeEN objge_ConnectLookChartNodeEN = new clsge_ConnectLookChartNodeEN();
try
{
objge_ConnectLookChartNodeEN.ConnectLookNodeId = objRow[conge_ConnectLookChartNode.ConnectLookNodeId].ToString().Trim(); //连连看节点Id
objge_ConnectLookChartNodeEN.ConnectLookNodeName = objRow[conge_ConnectLookChartNode.ConnectLookNodeName] == DBNull.Value ? null : objRow[conge_ConnectLookChartNode.ConnectLookNodeName].ToString().Trim(); //连连看节点名称
objge_ConnectLookChartNodeEN.ConnectLookChartId = objRow[conge_ConnectLookChartNode.ConnectLookChartId].ToString().Trim(); //连连看图Id
objge_ConnectLookChartNodeEN.XPosition = objRow[conge_ConnectLookChartNode.XPosition] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conge_ConnectLookChartNode.XPosition].ToString().Trim()); //X_坐标
objge_ConnectLookChartNodeEN.YPosition = objRow[conge_ConnectLookChartNode.YPosition] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conge_ConnectLookChartNode.YPosition].ToString().Trim()); //Y_坐标
objge_ConnectLookChartNodeEN.LogicNodeId = objRow[conge_ConnectLookChartNode.LogicNodeId] == DBNull.Value ? null : objRow[conge_ConnectLookChartNode.LogicNodeId].ToString().Trim(); //逻辑节点Id
objge_ConnectLookChartNodeEN.ClassName = objRow[conge_ConnectLookChartNode.ClassName] == DBNull.Value ? null : objRow[conge_ConnectLookChartNode.ClassName].ToString().Trim(); //样式名称
objge_ConnectLookChartNodeEN.UpdDate = objRow[conge_ConnectLookChartNode.UpdDate] == DBNull.Value ? null : objRow[conge_ConnectLookChartNode.UpdDate].ToString().Trim(); //修改日期
objge_ConnectLookChartNodeEN.UpdUser = objRow[conge_ConnectLookChartNode.UpdUser] == DBNull.Value ? null : objRow[conge_ConnectLookChartNode.UpdUser].ToString().Trim(); //修改人
objge_ConnectLookChartNodeEN.Memo = objRow[conge_ConnectLookChartNode.Memo] == DBNull.Value ? null : objRow[conge_ConnectLookChartNode.Memo].ToString().Trim(); //备注
objge_ConnectLookChartNodeEN.ConnectLookNodeTypeId = objRow[conge_ConnectLookChartNode.ConnectLookNodeTypeId] == DBNull.Value ? null : objRow[conge_ConnectLookChartNode.ConnectLookNodeTypeId].ToString().Trim(); //连连看节点类型
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objge_ConnectLookChartNodeEN.ConnectLookNodeId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objge_ConnectLookChartNodeEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objge_ConnectLookChartNodeEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool Getge_ConnectLookChartNode(ref clsge_ConnectLookChartNodeEN objge_ConnectLookChartNodeEN)
{
bool bolResult = ge_ConnectLookChartNodeDA.Getge_ConnectLookChartNode(ref objge_ConnectLookChartNodeEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "strConnectLookNodeId">表关键字</param>
 /// <returns>表对象</returns>
public static clsge_ConnectLookChartNodeEN GetObjByConnectLookNodeId(string strConnectLookNodeId)
{
if (strConnectLookNodeId.IndexOf(' ') >=0)
{
var strMsg = string.Format("(errid:Busi000079)在表中,关键字[strConnectLookNodeId]中不能有空格!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
if (string.IsNullOrEmpty(strConnectLookNodeId) == true)
{
var strMsg = string.Format("(errid:Busi000020)在表中,关键字[strConnectLookNodeId]不能为空!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
clsge_ConnectLookChartNodeEN objge_ConnectLookChartNodeEN = ge_ConnectLookChartNodeDA.GetObjByConnectLookNodeId(strConnectLookNodeId);
return objge_ConnectLookChartNodeEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsge_ConnectLookChartNodeEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsge_ConnectLookChartNodeEN objge_ConnectLookChartNodeEN = ge_ConnectLookChartNodeDA.GetFirstObj(strWhereCond);
 return objge_ConnectLookChartNodeEN;
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
public static clsge_ConnectLookChartNodeEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsge_ConnectLookChartNodeEN objge_ConnectLookChartNodeEN = ge_ConnectLookChartNodeDA.GetObjByDataRow(objRow);
 return objge_ConnectLookChartNodeEN;
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
public static clsge_ConnectLookChartNodeEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsge_ConnectLookChartNodeEN objge_ConnectLookChartNodeEN = ge_ConnectLookChartNodeDA.GetObjByDataRow(objRow);
 return objge_ConnectLookChartNodeEN;
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
 /// <param name = "strConnectLookNodeId">所给的关键字</param>
 /// <param name = "lstge_ConnectLookChartNodeObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsge_ConnectLookChartNodeEN GetObjByConnectLookNodeIdFromList(string strConnectLookNodeId, List<clsge_ConnectLookChartNodeEN> lstge_ConnectLookChartNodeObjLst)
{
foreach (clsge_ConnectLookChartNodeEN objge_ConnectLookChartNodeEN in lstge_ConnectLookChartNodeObjLst)
{
if (objge_ConnectLookChartNodeEN.ConnectLookNodeId == strConnectLookNodeId)
{
return objge_ConnectLookChartNodeEN;
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
 string strConnectLookNodeId;
 try
 {
 strConnectLookNodeId = new clsge_ConnectLookChartNodeDA().GetFirstID(strWhereCond);
 return strConnectLookNodeId;
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
 arrList = ge_ConnectLookChartNodeDA.GetID(strWhereCond);
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
bool bolIsExist = ge_ConnectLookChartNodeDA.IsExistCondRec(strWhereCond);
return bolIsExist;
}

 /// <summary>
 /// 判断当前表中是否存在给定关键字值的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExist)
 /// </summary>
 /// <param name = "strConnectLookNodeId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public static bool IsExist(string strConnectLookNodeId)
{
if (string.IsNullOrEmpty(strConnectLookNodeId) == true)
{
var strMsg = string.Format("(errid:Busi000027)在表中,关键字[strConnectLookNodeId]不能为空!!(from {0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
//检测记录是否存在
bool bolIsExist = ge_ConnectLookChartNodeDA.IsExist(strConnectLookNodeId);
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
 bolIsExist = clsge_ConnectLookChartNodeDA.IsExistTable();
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
 bolIsExist = ge_ConnectLookChartNodeDA.IsExistTable(strTabName);
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
 /// <param name = "objge_ConnectLookChartNodeEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecordBySql2(clsge_ConnectLookChartNodeEN objge_ConnectLookChartNodeEN, bool bolIsNeedCheckUniqueness=true)
{
 if (string.IsNullOrEmpty(objge_ConnectLookChartNodeEN.ConnectLookNodeId) == true)
 {
string strMsg = string.Format("添加记录时,关键字不能为空!(from {0})\r\n", 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
 if (clsge_ConnectLookChartNodeBL.IsExist(objge_ConnectLookChartNodeEN.ConnectLookNodeId) == true)
 {
string strMsg = string.Format("添加记录时,关键字:[{0}]已经存在!(from {1})\r\n", objge_ConnectLookChartNodeEN.ConnectLookNodeId, 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
if (bolIsNeedCheckUniqueness == true && objge_ConnectLookChartNodeEN.CheckUniqueness() == false)
{
var strMsg = string.Format("记录已经存在!连连看节点Id = [{0}]的数据已经存在!(in clsge_ConnectLookChartNodeBL.AddNewRecordBySql2)", objge_ConnectLookChartNodeEN.ConnectLookNodeId);
throw new Exception(strMsg);
}
try
{
bool bolResult = ge_ConnectLookChartNodeDA.AddNewRecordBySQL2(objge_ConnectLookChartNodeEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsge_ConnectLookChartNodeBL.ReFreshCache(objge_ConnectLookChartNodeEN.ConnectLookChartId);

if (clsge_ConnectLookChartNodeBL.relatedActions != null)
{
clsge_ConnectLookChartNodeBL.relatedActions.UpdRelaTabDate(objge_ConnectLookChartNodeEN.ConnectLookNodeId, "SetUpdDate");
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
 /// <param name = "objge_ConnectLookChartNodeEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordBySql2WithReturnKey(clsge_ConnectLookChartNodeEN objge_ConnectLookChartNodeEN, bool bolIsNeedCheckUniqueness=true)
{
 if (string.IsNullOrEmpty(objge_ConnectLookChartNodeEN.ConnectLookNodeId) == true)
 {
string strMsg = string.Format("添加记录时,关键字不能为空!(from {{0}})", 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
 if (clsge_ConnectLookChartNodeBL.IsExist(objge_ConnectLookChartNodeEN.ConnectLookNodeId) == true)
 {
string strMsg = string.Format("添加记录时,关键字:[{0}]已经存在!(from {1})\r\n", objge_ConnectLookChartNodeEN.ConnectLookNodeId, 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
if (bolIsNeedCheckUniqueness == true && objge_ConnectLookChartNodeEN.CheckUniqueness() == false)
{
var strMsg = string.Format("记录已经存在!连连看节点Id = [{0}]的数据已经存在!(in clsge_ConnectLookChartNodeBL.AddNewRecordBySql2WithReturnKey)", objge_ConnectLookChartNodeEN.ConnectLookNodeId);
throw new Exception(strMsg);
}
try
{
string strKey = ge_ConnectLookChartNodeDA.AddNewRecordBySQL2WithReturnKey(objge_ConnectLookChartNodeEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsge_ConnectLookChartNodeBL.ReFreshCache(objge_ConnectLookChartNodeEN.ConnectLookChartId);

if (clsge_ConnectLookChartNodeBL.relatedActions != null)
{
clsge_ConnectLookChartNodeBL.relatedActions.UpdRelaTabDate(objge_ConnectLookChartNodeEN.ConnectLookNodeId, "SetUpdDate");
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
 /// <param name = "objge_ConnectLookChartNodeEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(clsge_ConnectLookChartNodeEN objge_ConnectLookChartNodeEN)
{
try
{
bool bolResult = ge_ConnectLookChartNodeDA.Update(objge_ConnectLookChartNodeEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsge_ConnectLookChartNodeBL.ReFreshCache(objge_ConnectLookChartNodeEN.ConnectLookChartId);

if (clsge_ConnectLookChartNodeBL.relatedActions != null)
{
clsge_ConnectLookChartNodeBL.relatedActions.UpdRelaTabDate(objge_ConnectLookChartNodeEN.ConnectLookNodeId, "SetUpdDate");
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
 /// <param name = "objge_ConnectLookChartNodeEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateBySql2(clsge_ConnectLookChartNodeEN objge_ConnectLookChartNodeEN)
{
 if (string.IsNullOrEmpty(objge_ConnectLookChartNodeEN.ConnectLookNodeId) == true)
 {
var strMsg = string.Format("(errid:Busi000065)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = ge_ConnectLookChartNodeDA.UpdateBySql2(objge_ConnectLookChartNodeEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsge_ConnectLookChartNodeBL.ReFreshCache(objge_ConnectLookChartNodeEN.ConnectLookChartId);

if (clsge_ConnectLookChartNodeBL.relatedActions != null)
{
clsge_ConnectLookChartNodeBL.relatedActions.UpdRelaTabDate(objge_ConnectLookChartNodeEN.ConnectLookNodeId, "SetUpdDate");
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
 /// <param name = "strConnectLookNodeId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int DelRecord(string strConnectLookNodeId)
{
try
{
 clsge_ConnectLookChartNodeEN objge_ConnectLookChartNodeEN = clsge_ConnectLookChartNodeBL.GetObjByConnectLookNodeId(strConnectLookNodeId);

if (clsge_ConnectLookChartNodeBL.relatedActions != null)
{
clsge_ConnectLookChartNodeBL.relatedActions.UpdRelaTabDate(objge_ConnectLookChartNodeEN.ConnectLookNodeId, "SetUpdDate");
}
if (objge_ConnectLookChartNodeEN != null)
{
int intRecNum = ge_ConnectLookChartNodeDA.DelRecord(strConnectLookNodeId);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
ReFreshCache(objge_ConnectLookChartNodeEN.ConnectLookChartId);
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
/// <param name="strConnectLookNodeId">表关键字</param>
 /// <param name = "strConnectLookChartId">缓存的分类字段</param>
/// <returns></returns>
public static bool DelRecordEx(string strConnectLookNodeId , string strConnectLookChartId)
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsge_ConnectLookChartNodeDA.GetSpecSQLObj();
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
//删除与表:[ge_ConnectLookChartNode]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conge_ConnectLookChartNode.ConnectLookNodeId,
//strConnectLookNodeId);
//        clsge_ConnectLookChartNodeBL.Delge_ConnectLookChartNodesByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsge_ConnectLookChartNodeBL.DelRecord(strConnectLookNodeId, strConnectLookChartId, objConnection, objSqlTransaction);
objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsge_ConnectLookChartNodeBLEx", "DelRecordEx", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("扩展删除记录出错:{0}!keyId = {1}.({2})",
objException.Message,
strConnectLookNodeId, clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "strConnectLookNodeId">给定的关键字值</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回删除是否成功?</returns>
public static bool DelRecord(string strConnectLookNodeId, string strConnectLookChartId, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
if (clsge_ConnectLookChartNodeBL.relatedActions != null)
{
clsge_ConnectLookChartNodeBL.relatedActions.UpdRelaTabDate(strConnectLookNodeId, "UpdRelaTabDate");
}
bool bolResult = ge_ConnectLookChartNodeDA.DelRecord(strConnectLookNodeId,objSqlConnection,objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
ReFreshCache(strConnectLookChartId);
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
 /// <param name = "arrConnectLookNodeIdLst">给定的关键字值列表</param>
 /// <returns>返回删除的记录数</returns>
public static int Delge_ConnectLookChartNodes(List<string> arrConnectLookNodeIdLst)
{
if (arrConnectLookNodeIdLst.Count == 0) return 0;
try
{
if (clsge_ConnectLookChartNodeBL.relatedActions != null)
{
foreach (var strConnectLookNodeId in arrConnectLookNodeIdLst)
{
clsge_ConnectLookChartNodeBL.relatedActions.UpdRelaTabDate(strConnectLookNodeId, "UpdRelaTabDate");
}
}
 clsge_ConnectLookChartNodeEN objge_ConnectLookChartNodeEN = clsge_ConnectLookChartNodeBL.GetObjByConnectLookNodeId(arrConnectLookNodeIdLst[0]);
int intDelRecNum = ge_ConnectLookChartNodeDA.Delge_ConnectLookChartNode(arrConnectLookNodeIdLst);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
ReFreshCache(objge_ConnectLookChartNodeEN.ConnectLookChartId);
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
public static int Delge_ConnectLookChartNodesByCond(string strWhereCond)
{
try
{
if (clsge_ConnectLookChartNodeBL.relatedActions != null)
{
List<string> arrConnectLookNodeId = GetPrimaryKeyID_S(strWhereCond);
foreach (var strConnectLookNodeId in arrConnectLookNodeId)
{
clsge_ConnectLookChartNodeBL.relatedActions.UpdRelaTabDate(strConnectLookNodeId, "UpdRelaTabDate");
}
}
List<string> arrConnectLookChartId = GetFldValue(conge_ConnectLookChartNode.ConnectLookChartId, strWhereCond);
int intRecNum = ge_ConnectLookChartNodeDA.Delge_ConnectLookChartNode(strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
arrConnectLookChartId.ForEach(x => ReFreshCache(x));
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
/// 这里仅仅是演示函数,使用时请复制到扩展类:[ge_ConnectLookChartNode]中改名为:[DelRecord4MultiTabEx]使用
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DelRecord4MultiTab)
/// </summary>
/// <param name="strConnectLookNodeId">表关键字</param>
 /// <param name = "strConnectLookChartId">缓存的分类字段</param>
/// <returns></returns>
public static bool DelRecord4MultiTab(string strConnectLookNodeId, string strConnectLookChartId)
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsge_ConnectLookChartNodeDA.GetSpecSQLObj();
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
//删除与表:[ge_ConnectLookChartNode]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conStudent.id_College,
//strid_College);
//        clsStudentBL.DelStudentsByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsge_ConnectLookChartNodeBL.DelRecord(strConnectLookNodeId, strConnectLookChartId, objConnection, objSqlTransaction);
                objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsge_ConnectLookChartNodeBL", "DelRecord4MultiTab", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("删除多表记录出错:{0}!keyId = {1}.({2})",
objException.Message,
strConnectLookNodeId, clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "objge_ConnectLookChartNodeENS">源对象</param>
 /// <param name = "objge_ConnectLookChartNodeENT">目标对象</param>
 public static void CopyTo(clsge_ConnectLookChartNodeEN objge_ConnectLookChartNodeENS, clsge_ConnectLookChartNodeEN objge_ConnectLookChartNodeENT)
{
try
{
objge_ConnectLookChartNodeENT.ConnectLookNodeId = objge_ConnectLookChartNodeENS.ConnectLookNodeId; //连连看节点Id
objge_ConnectLookChartNodeENT.ConnectLookNodeName = objge_ConnectLookChartNodeENS.ConnectLookNodeName; //连连看节点名称
objge_ConnectLookChartNodeENT.ConnectLookChartId = objge_ConnectLookChartNodeENS.ConnectLookChartId; //连连看图Id
objge_ConnectLookChartNodeENT.XPosition = objge_ConnectLookChartNodeENS.XPosition; //X_坐标
objge_ConnectLookChartNodeENT.YPosition = objge_ConnectLookChartNodeENS.YPosition; //Y_坐标
objge_ConnectLookChartNodeENT.LogicNodeId = objge_ConnectLookChartNodeENS.LogicNodeId; //逻辑节点Id
objge_ConnectLookChartNodeENT.ClassName = objge_ConnectLookChartNodeENS.ClassName; //样式名称
objge_ConnectLookChartNodeENT.UpdDate = objge_ConnectLookChartNodeENS.UpdDate; //修改日期
objge_ConnectLookChartNodeENT.UpdUser = objge_ConnectLookChartNodeENS.UpdUser; //修改人
objge_ConnectLookChartNodeENT.Memo = objge_ConnectLookChartNodeENS.Memo; //备注
objge_ConnectLookChartNodeENT.ConnectLookNodeTypeId = objge_ConnectLookChartNodeENS.ConnectLookNodeTypeId; //连连看节点类型
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
 /// <param name = "objge_ConnectLookChartNodeEN">源简化对象</param>
 public static void SetUpdFlag(clsge_ConnectLookChartNodeEN objge_ConnectLookChartNodeEN)
{
try
{
objge_ConnectLookChartNodeEN.ClearUpdateState();
   string strsfUpdFldSetStr = objge_ConnectLookChartNodeEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(conge_ConnectLookChartNode.ConnectLookNodeId, new clsStrCompareIgnoreCase())  ==  true)
{
objge_ConnectLookChartNodeEN.ConnectLookNodeId = objge_ConnectLookChartNodeEN.ConnectLookNodeId; //连连看节点Id
}
if (arrFldSet.Contains(conge_ConnectLookChartNode.ConnectLookNodeName, new clsStrCompareIgnoreCase())  ==  true)
{
objge_ConnectLookChartNodeEN.ConnectLookNodeName = objge_ConnectLookChartNodeEN.ConnectLookNodeName == "[null]" ? null :  objge_ConnectLookChartNodeEN.ConnectLookNodeName; //连连看节点名称
}
if (arrFldSet.Contains(conge_ConnectLookChartNode.ConnectLookChartId, new clsStrCompareIgnoreCase())  ==  true)
{
objge_ConnectLookChartNodeEN.ConnectLookChartId = objge_ConnectLookChartNodeEN.ConnectLookChartId; //连连看图Id
}
if (arrFldSet.Contains(conge_ConnectLookChartNode.XPosition, new clsStrCompareIgnoreCase())  ==  true)
{
objge_ConnectLookChartNodeEN.XPosition = objge_ConnectLookChartNodeEN.XPosition; //X_坐标
}
if (arrFldSet.Contains(conge_ConnectLookChartNode.YPosition, new clsStrCompareIgnoreCase())  ==  true)
{
objge_ConnectLookChartNodeEN.YPosition = objge_ConnectLookChartNodeEN.YPosition; //Y_坐标
}
if (arrFldSet.Contains(conge_ConnectLookChartNode.LogicNodeId, new clsStrCompareIgnoreCase())  ==  true)
{
objge_ConnectLookChartNodeEN.LogicNodeId = objge_ConnectLookChartNodeEN.LogicNodeId == "[null]" ? null :  objge_ConnectLookChartNodeEN.LogicNodeId; //逻辑节点Id
}
if (arrFldSet.Contains(conge_ConnectLookChartNode.ClassName, new clsStrCompareIgnoreCase())  ==  true)
{
objge_ConnectLookChartNodeEN.ClassName = objge_ConnectLookChartNodeEN.ClassName == "[null]" ? null :  objge_ConnectLookChartNodeEN.ClassName; //样式名称
}
if (arrFldSet.Contains(conge_ConnectLookChartNode.UpdDate, new clsStrCompareIgnoreCase())  ==  true)
{
objge_ConnectLookChartNodeEN.UpdDate = objge_ConnectLookChartNodeEN.UpdDate == "[null]" ? null :  objge_ConnectLookChartNodeEN.UpdDate; //修改日期
}
if (arrFldSet.Contains(conge_ConnectLookChartNode.UpdUser, new clsStrCompareIgnoreCase())  ==  true)
{
objge_ConnectLookChartNodeEN.UpdUser = objge_ConnectLookChartNodeEN.UpdUser == "[null]" ? null :  objge_ConnectLookChartNodeEN.UpdUser; //修改人
}
if (arrFldSet.Contains(conge_ConnectLookChartNode.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objge_ConnectLookChartNodeEN.Memo = objge_ConnectLookChartNodeEN.Memo == "[null]" ? null :  objge_ConnectLookChartNodeEN.Memo; //备注
}
if (arrFldSet.Contains(conge_ConnectLookChartNode.ConnectLookNodeTypeId, new clsStrCompareIgnoreCase())  ==  true)
{
objge_ConnectLookChartNodeEN.ConnectLookNodeTypeId = objge_ConnectLookChartNodeEN.ConnectLookNodeTypeId == "[null]" ? null :  objge_ConnectLookChartNodeEN.ConnectLookNodeTypeId; //连连看节点类型
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
 /// <param name = "objge_ConnectLookChartNodeEN">源简化对象</param>
 public static void AccessFldValueNull(clsge_ConnectLookChartNodeEN objge_ConnectLookChartNodeEN)
{
try
{
if (objge_ConnectLookChartNodeEN.ConnectLookNodeName == "[null]") objge_ConnectLookChartNodeEN.ConnectLookNodeName = null; //连连看节点名称
if (objge_ConnectLookChartNodeEN.LogicNodeId == "[null]") objge_ConnectLookChartNodeEN.LogicNodeId = null; //逻辑节点Id
if (objge_ConnectLookChartNodeEN.ClassName == "[null]") objge_ConnectLookChartNodeEN.ClassName = null; //样式名称
if (objge_ConnectLookChartNodeEN.UpdDate == "[null]") objge_ConnectLookChartNodeEN.UpdDate = null; //修改日期
if (objge_ConnectLookChartNodeEN.UpdUser == "[null]") objge_ConnectLookChartNodeEN.UpdUser = null; //修改人
if (objge_ConnectLookChartNodeEN.Memo == "[null]") objge_ConnectLookChartNodeEN.Memo = null; //备注
if (objge_ConnectLookChartNodeEN.ConnectLookNodeTypeId == "[null]") objge_ConnectLookChartNodeEN.ConnectLookNodeTypeId = null; //连连看节点类型
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
public static void CheckPropertyNew(clsge_ConnectLookChartNodeEN objge_ConnectLookChartNodeEN)
{
 ge_ConnectLookChartNodeDA.CheckPropertyNew(objge_ConnectLookChartNodeEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(clsge_ConnectLookChartNodeEN objge_ConnectLookChartNodeEN)
{
 ge_ConnectLookChartNodeDA.CheckProperty4Condition(objge_ConnectLookChartNodeEN);
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
if (clsge_ConnectLookChartNodeBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsge_ConnectLookChartNodeBL没有刷新缓存机制(clsge_ConnectLookChartNodeBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by ConnectLookNodeId");
//if (arrge_ConnectLookChartNodeObjLstCache == null)
//{
//arrge_ConnectLookChartNodeObjLstCache = ge_ConnectLookChartNodeDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "strConnectLookNodeId">所给的关键字</param>
 /// <param name = "strConnectLookChartId">缓存的分类字段</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsge_ConnectLookChartNodeEN GetObjByConnectLookNodeIdCache(string strConnectLookNodeId, string strConnectLookChartId)
{

if (string.IsNullOrEmpty(strConnectLookChartId) == true)
{
  var strMsg = string.Format("参数:[strConnectLookChartId]不能为空!(In {0})", clsStackTrace.GetCurrClassFunction());
clsSysParaEN.objLog.WriteDebugLog(strMsg);
 throw new Exception (strMsg);
}
if (strConnectLookChartId.Length != 10)
{
var strMsg = string.Format("缓存分类变量:[strConnectLookChartId]的长度:[{0}]不正确!(In {1})", strConnectLookChartId.Length, clsStackTrace.GetCurrClassFunction());
clsSysParaEN.objLog.WriteDebugLog(strMsg);
 throw new Exception (strMsg);
}
//获取缓存中的对象列表
string strKey = string.Format("{0}_{1}", clsge_ConnectLookChartNodeEN._CurrTabName, strConnectLookChartId);
List<clsge_ConnectLookChartNodeEN> arrge_ConnectLookChartNodeObjLstCache = GetObjLstCache(strConnectLookChartId);
IEnumerable <clsge_ConnectLookChartNodeEN> arrge_ConnectLookChartNodeObjLst_Sel =
arrge_ConnectLookChartNodeObjLstCache
.Where(x=> x.ConnectLookNodeId == strConnectLookNodeId 
);
if (arrge_ConnectLookChartNodeObjLst_Sel.Count() == 0)
{
   clsge_ConnectLookChartNodeEN obj = clsge_ConnectLookChartNodeBL.GetObjByConnectLookNodeId(strConnectLookNodeId);
   if (obj != null)
 {
if (obj.ConnectLookChartId == strConnectLookChartId)
{
CacheHelper.Remove(strKey);
     return obj;
}
else
{
string strMsg = string.Format("错误: 关键字:{0}不属于分类:{1},请检查!(In {2})", strConnectLookNodeId, strConnectLookChartId, clsStackTrace.GetCurrClassFunction());
clsSysParaEN.objLog.WriteDebugLog(strMsg);
throw new Exception(strMsg);
}
 }
return null;
}
return arrge_ConnectLookChartNodeObjLst_Sel.First();
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsge_ConnectLookChartNodeEN> GetAllge_ConnectLookChartNodeObjLstCache(string strConnectLookChartId)
{
//获取缓存中的对象列表
List<clsge_ConnectLookChartNodeEN> arrge_ConnectLookChartNodeObjLstCache = GetObjLstCache(strConnectLookChartId); 
return arrge_ConnectLookChartNodeObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsge_ConnectLookChartNodeEN> GetObjLstCache(string strConnectLookChartId)
{

if (string.IsNullOrEmpty(strConnectLookChartId) == true)
{
  var strMsg = string.Format("参数:[strConnectLookChartId]不能为空!(In {0})", clsStackTrace.GetCurrClassFunction());
clsSysParaEN.objLog.WriteDebugLog(strMsg);
 throw new Exception (strMsg);
}
if (strConnectLookChartId.Length != 10)
{
var strMsg = string.Format("缓存分类变量:[strConnectLookChartId]的长度:[{0}]不正确!(In {1})", strConnectLookChartId.Length, clsStackTrace.GetCurrClassFunction());
clsSysParaEN.objLog.WriteDebugLog(strMsg);
 throw new Exception (strMsg);
}
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}_{1}", clsge_ConnectLookChartNodeEN._CurrTabName, strConnectLookChartId);
string strCondition = string.Format("ConnectLookChartId='{0}'", strConnectLookChartId);
List<clsge_ConnectLookChartNodeEN> arrge_ConnectLookChartNodeObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst(strCondition); });
return arrge_ConnectLookChartNodeObjLstCache;
}

 /// <summary>
 /// 刷新本类中的缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ReFreshThisCache)
 /// </summary>
public static void ReFreshThisCache(string strConnectLookChartId = "")
{
string strMsg;
if (clsSysParaEN.spSetRefreshCacheOn == true)
{
string strKey = string.Format("{0}_{1}", clsge_ConnectLookChartNodeEN._CurrTabName, strConnectLookChartId);
CacheHelper.Remove(strKey);
clsge_ConnectLookChartNodeEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
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
if (clsge_ConnectLookChartNodeEN._RefreshTimeLst.Count == 0) return "";
return clsge_ConnectLookChartNodeEN._RefreshTimeLst[clsge_ConnectLookChartNodeEN._RefreshTimeLst.Count - 1];
}

 /// <summary>
 /// 刷新缓存.把当前表的缓存以及该表相关视图的缓存清空.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ReFreshCache)
 /// </summary>
public static void ReFreshCache(string strConnectLookChartId)
{
if (string.IsNullOrEmpty(strConnectLookChartId) == true)
{
string strMsg = string.Format("缓存分类字段:[ConnectLookChartId]不能为空!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsge_ConnectLookChartNodeBL.objCommFun4BL != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}_{1}", clsge_ConnectLookChartNodeEN._CurrTabName, strConnectLookChartId);
CacheHelper.Remove(strKey);
clsge_ConnectLookChartNodeEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
clsge_ConnectLookChartNodeBL.objCommFun4BL.ReFreshCache(strConnectLookChartId);
}
}


 #endregion 缓存操作


 #region 检查唯一性

 /// <summary>
 /// 获取检查唯一性条件串(Uniqueness)--ge_ConnectLookChartNode(连连看图节点)
 /// 唯一性条件:ConnectLookNodeId
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetUniquenessConditionString)
 /// </summary>
 /// <param name = "objge_ConnectLookChartNodeEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(clsge_ConnectLookChartNodeEN objge_ConnectLookChartNodeEN)
{
//检测记录是否存在
string strResult = ge_ConnectLookChartNodeDA.GetUniCondStr(objge_ConnectLookChartNodeEN);
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
 /// <param name = "strConnectLookChartId">缓存的分类字段</param>
 /// <returns>返回一个输出字段值</returns>
public static string Func(string strInFldName, string strOutFldName, string strConnectLookNodeId, string strConnectLookChartId)
{
if (strInFldName != conge_ConnectLookChartNode.ConnectLookNodeId)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (conge_ConnectLookChartNode.AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", conge_ConnectLookChartNode.AttributeName));
throw new Exception(strMsg);
}
var objge_ConnectLookChartNode = clsge_ConnectLookChartNodeBL.GetObjByConnectLookNodeIdCache(strConnectLookNodeId, strConnectLookChartId);
if (objge_ConnectLookChartNode == null) return "";
return objge_ConnectLookChartNode[strOutFldName].ToString();
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
int intRecCount = clsge_ConnectLookChartNodeDA.GetRecCount(strTabName);
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
int intRecCount = clsge_ConnectLookChartNodeDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsge_ConnectLookChartNodeDA.GetRecCount();
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
int intRecCount = clsge_ConnectLookChartNodeDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objge_ConnectLookChartNodeCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsge_ConnectLookChartNodeEN objge_ConnectLookChartNodeCond)
{
 string strConnectLookChartId = objge_ConnectLookChartNodeCond.ConnectLookChartId;
 if (string.IsNullOrEmpty(strConnectLookChartId) == true)
{
string strMsg = string.Format("(errid:Busi000174)在表中,缓存分类字段值不能为空!(clsge_ConnectLookChartNodeBL:GetRecCountByCondCache)");
throw new Exception(strMsg);
}
List<clsge_ConnectLookChartNodeEN> arrObjLstCache = GetObjLstCache(strConnectLookChartId);
IEnumerable <clsge_ConnectLookChartNodeEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conge_ConnectLookChartNode.AttributeName)
{
if (objge_ConnectLookChartNodeCond.IsUpdated(strFldName) == false) continue;
if (objge_ConnectLookChartNodeCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objge_ConnectLookChartNodeCond[strFldName].ToString());
}
else
{
if (objge_ConnectLookChartNodeCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objge_ConnectLookChartNodeCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objge_ConnectLookChartNodeCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objge_ConnectLookChartNodeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objge_ConnectLookChartNodeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objge_ConnectLookChartNodeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objge_ConnectLookChartNodeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objge_ConnectLookChartNodeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objge_ConnectLookChartNodeCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objge_ConnectLookChartNodeCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objge_ConnectLookChartNodeCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objge_ConnectLookChartNodeCond[strFldName]));
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
 List<string> arrList = clsge_ConnectLookChartNodeDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = ge_ConnectLookChartNodeDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = ge_ConnectLookChartNodeDA.GetFldValueNoDistinct(strFldName, strWhereCond);
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
int intRecCount = ge_ConnectLookChartNodeDA.SetFldValue(strFldName, strValue, strWhereCond);
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
int intRecCount = clsge_ConnectLookChartNodeDA.SetFldValue(clsge_ConnectLookChartNodeEN._CurrTabName, strFldName, fltValue, strWhereCond);
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
int intRecCount = ge_ConnectLookChartNodeDA.SetFldValue( strFldName, intValue, strWhereCond);
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
int intRecCount = clsge_ConnectLookChartNodeDA.SetFldValue(strTabName, strFldName, strValue, strWhereCond);
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
int intRecCount = clsge_ConnectLookChartNodeDA.SetFldValue(strTabName, strFldName, intValue, strWhereCond);
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
int intRecCount = clsge_ConnectLookChartNodeDA.SetFldValue(strTabName, strFldName, fltValue, strWhereCond);
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
  strCreateTabCode.Append("CREATE table [dbo].[ge_ConnectLookChartNode] "); 
 strCreateTabCode.Append(" ( "); 
 // /**连连看节点Id*/ 
 strCreateTabCode.Append(" ConnectLookNodeId char(10) primary key, "); 
 // /**连连看节点名称*/ 
 strCreateTabCode.Append(" ConnectLookNodeName varchar(100) Null, "); 
 // /**连连看图Id*/ 
 strCreateTabCode.Append(" ConnectLookChartId char(10) not Null, "); 
 // /**X_坐标*/ 
 strCreateTabCode.Append(" XPosition float Null, "); 
 // /**Y_坐标*/ 
 strCreateTabCode.Append(" YPosition float Null, "); 
 // /**逻辑节点Id*/ 
 strCreateTabCode.Append(" LogicNodeId varchar(20) Null, "); 
 // /**样式名称*/ 
 strCreateTabCode.Append(" ClassName varchar(100) Null, "); 
 // /**修改日期*/ 
 strCreateTabCode.Append(" UpdDate varchar(20) Null, "); 
 // /**修改人*/ 
 strCreateTabCode.Append(" UpdUser varchar(20) Null, "); 
 // /**备注*/ 
 strCreateTabCode.Append(" Memo varchar(1000) Null, "); 
 // /**连连看节点类型*/ 
 strCreateTabCode.Append(" ConnectLookNodeTypeId char(2) Null ");
 strCreateTabCode.Append(") "); 
  strCreateTabCode.Append("ON [PRIMARY] ");
  return strCreateTabCode.ToString();
}



 #endregion 表操作
}
 /// <summary>
 /// 连连看图节点(ge_ConnectLookChartNode)
 /// 数据源类型:表
 /// (AutoGCLib.CommFun4BL4CSharp:GeneCode_This)
 /// </summary>
public class  clsCommFun4BL4ge_ConnectLookChartNode : clsCommFun4BLV2
{

 /// <summary>
 /// 刷新缓存.把当前表的缓存以及该表相关视图的缓存清空.
 /// (AutoGCLib.CommFun4BL4CSharp:Gen_4CFBL_ReFreshCache)
 /// </summary>
public override void ReFreshCache(string strConnectLookChartId)
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
clsge_ConnectLookChartNodeBL.ReFreshThisCache(strConnectLookChartId);
}
}

}