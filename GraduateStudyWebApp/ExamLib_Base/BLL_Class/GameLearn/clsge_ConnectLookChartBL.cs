
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsge_ConnectLookChartBL
 表名:ge_ConnectLookChart(01120916)
 * 版本:2024.11.13.1(服务器:WIN-SRV103-116)
 日期:2024/11/13 06:17:21
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:研究生学习游戏化后台(000055, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:游戏化学习(GameLearn)
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
public static class  clsge_ConnectLookChartBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "strConnectLookChartId">表关键字</param>
 /// <returns>表对象</returns>
public static clsge_ConnectLookChartEN GetObj(this K_ConnectLookChartId_ge_ConnectLookChart myKey)
{
clsge_ConnectLookChartEN objge_ConnectLookChartEN = clsge_ConnectLookChartBL.ge_ConnectLookChartDA.GetObjByConnectLookChartId(myKey.Value);
return objge_ConnectLookChartEN;
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_AddNewRecord)
 /// </summary>
 /// <param name = "objge_ConnectLookChartEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clsge_ConnectLookChartEN objge_ConnectLookChartEN, bool bolIsNeedCheckUniqueness = true)
{
if (bolIsNeedCheckUniqueness == true && CheckUniqueness(objge_ConnectLookChartEN) == false)
{
var strMsg = string.Format("记录已经存在!连连看图Id = [{0}]的数据已经存在!(in clsge_ConnectLookChartBL.AddNewRecord)", objge_ConnectLookChartEN.ConnectLookChartId);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objge_ConnectLookChartEN.ConnectLookChartId) == true || clsge_ConnectLookChartBL.IsExist(objge_ConnectLookChartEN.ConnectLookChartId) == true)
 {
     objge_ConnectLookChartEN.ConnectLookChartId = clsge_ConnectLookChartBL.GetMaxStrId_S();
 }
bool bolResult = clsge_ConnectLookChartBL.ge_ConnectLookChartDA.AddNewRecordBySQL2(objge_ConnectLookChartEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsge_ConnectLookChartBL.ReFreshCache(objge_ConnectLookChartEN.CourseId);

if (clsge_ConnectLookChartBL.relatedActions != null)
{
clsge_ConnectLookChartBL.relatedActions.UpdRelaTabDate(objge_ConnectLookChartEN.ConnectLookChartId, "SetUpdDate");
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
public static bool AddRecordEx(this clsge_ConnectLookChartEN objge_ConnectLookChartEN, bool bolIsNeedCheckUniqueness = true)
{
//操作步骤:
//1、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在
//2、检查唯一性
//3、检查传进去的对象属性是否合法
//4、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
//1、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在

//因为是字符型自增主键,不需要检查主键是否已经存在,在添加时,再获取 最大值作为主键
//if (clsge_ConnectLookChartBL.IsExist(objge_ConnectLookChartEN.ConnectLookChartId))	//判断是否有相同的关键字
//{
//strMsg = "(errid:Busi000151)关键字字段已有相同的值";
//throw new Exception(strMsg);
//}
try
{
 //2、检查传进去的对象属性是否合法
objge_ConnectLookChartEN.CheckPropertyNew();
 ///5.2、检查唯一性
if (bolIsNeedCheckUniqueness == true && objge_ConnectLookChartEN.CheckUniqueness() == false)
{
strMsg = string.Format("(连连看图Id(ConnectLookChartId)=[{0}])已经存在,不能重复!", objge_ConnectLookChartEN.ConnectLookChartId);
throw new Exception(strMsg);
}
//因为是字符型自增主键,所以在添加时,自动获取主键值。
 if (string.IsNullOrEmpty(objge_ConnectLookChartEN.ConnectLookChartId) == true || clsge_ConnectLookChartBL.IsExist(objge_ConnectLookChartEN.ConnectLookChartId) == true)
 {
     objge_ConnectLookChartEN.ConnectLookChartId = clsge_ConnectLookChartBL.GetMaxStrId_S();
 }
//6、把数据实体层的数据存贮到数据库中
objge_ConnectLookChartEN.AddNewRecord();
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
 /// <param name = "objge_ConnectLookChartEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static string AddNewRecordWithMaxId(this clsge_ConnectLookChartEN objge_ConnectLookChartEN, bool bolIsNeedCheckUniqueness = true)
{
if (bolIsNeedCheckUniqueness == true && CheckUniqueness(objge_ConnectLookChartEN) == false)
{
var strMsg = string.Format("记录已经存在!连连看图Id = [{0}]的数据已经存在!(in clsge_ConnectLookChartBL.AddNewRecordWithMaxId)", objge_ConnectLookChartEN.ConnectLookChartId);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objge_ConnectLookChartEN.ConnectLookChartId) == true || clsge_ConnectLookChartBL.IsExist(objge_ConnectLookChartEN.ConnectLookChartId) == true)
 {
     objge_ConnectLookChartEN.ConnectLookChartId = clsge_ConnectLookChartBL.GetMaxStrId_S();
 }
string strConnectLookChartId = clsge_ConnectLookChartBL.ge_ConnectLookChartDA.AddNewRecordBySQL2WithReturnKey(objge_ConnectLookChartEN);
     objge_ConnectLookChartEN.ConnectLookChartId = strConnectLookChartId;
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsge_ConnectLookChartBL.ReFreshCache(objge_ConnectLookChartEN.CourseId);

if (clsge_ConnectLookChartBL.relatedActions != null)
{
clsge_ConnectLookChartBL.relatedActions.UpdRelaTabDate(objge_ConnectLookChartEN.ConnectLookChartId, "SetUpdDate");
}
return strConnectLookChartId;
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
 /// <param name = "objge_ConnectLookChartEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordWithReturnKey(this clsge_ConnectLookChartEN objge_ConnectLookChartEN, bool bolIsNeedCheckUniqueness = true)
{
if (bolIsNeedCheckUniqueness == true && CheckUniqueness(objge_ConnectLookChartEN) == false)
{
var strMsg = string.Format("记录已经存在!连连看图Id = [{0}]的数据已经存在!(in clsge_ConnectLookChartBL.AddNewRecordWithReturnKey)", objge_ConnectLookChartEN.ConnectLookChartId);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objge_ConnectLookChartEN.ConnectLookChartId) == true || clsge_ConnectLookChartBL.IsExist(objge_ConnectLookChartEN.ConnectLookChartId) == true)
 {
     objge_ConnectLookChartEN.ConnectLookChartId = clsge_ConnectLookChartBL.GetMaxStrId_S();
 }
string strKey = clsge_ConnectLookChartBL.ge_ConnectLookChartDA.AddNewRecordBySQL2WithReturnKey(objge_ConnectLookChartEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsge_ConnectLookChartBL.ReFreshCache(objge_ConnectLookChartEN.CourseId);

if (clsge_ConnectLookChartBL.relatedActions != null)
{
clsge_ConnectLookChartBL.relatedActions.UpdRelaTabDate(objge_ConnectLookChartEN.ConnectLookChartId, "SetUpdDate");
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
 /// <param name = "objge_ConnectLookChartEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsge_ConnectLookChartEN SetConnectLookChartId(this clsge_ConnectLookChartEN objge_ConnectLookChartEN, string strConnectLookChartId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strConnectLookChartId, 10, conge_ConnectLookChart.ConnectLookChartId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strConnectLookChartId, 10, conge_ConnectLookChart.ConnectLookChartId);
}
objge_ConnectLookChartEN.ConnectLookChartId = strConnectLookChartId; //连连看图Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objge_ConnectLookChartEN.dicFldComparisonOp.ContainsKey(conge_ConnectLookChart.ConnectLookChartId) == false)
{
objge_ConnectLookChartEN.dicFldComparisonOp.Add(conge_ConnectLookChart.ConnectLookChartId, strComparisonOp);
}
else
{
objge_ConnectLookChartEN.dicFldComparisonOp[conge_ConnectLookChart.ConnectLookChartId] = strComparisonOp;
}
}
return objge_ConnectLookChartEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objge_ConnectLookChartEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsge_ConnectLookChartEN SetConnectLookChartName(this clsge_ConnectLookChartEN objge_ConnectLookChartEN, string strConnectLookChartName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strConnectLookChartName, 100, conge_ConnectLookChart.ConnectLookChartName);
}
objge_ConnectLookChartEN.ConnectLookChartName = strConnectLookChartName; //连连看图名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objge_ConnectLookChartEN.dicFldComparisonOp.ContainsKey(conge_ConnectLookChart.ConnectLookChartName) == false)
{
objge_ConnectLookChartEN.dicFldComparisonOp.Add(conge_ConnectLookChart.ConnectLookChartName, strComparisonOp);
}
else
{
objge_ConnectLookChartEN.dicFldComparisonOp[conge_ConnectLookChart.ConnectLookChartName] = strComparisonOp;
}
}
return objge_ConnectLookChartEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objge_ConnectLookChartEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsge_ConnectLookChartEN SetCourseId(this clsge_ConnectLookChartEN objge_ConnectLookChartEN, string strCourseId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCourseId, 8, conge_ConnectLookChart.CourseId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strCourseId, 8, conge_ConnectLookChart.CourseId);
}
objge_ConnectLookChartEN.CourseId = strCourseId; //课程Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objge_ConnectLookChartEN.dicFldComparisonOp.ContainsKey(conge_ConnectLookChart.CourseId) == false)
{
objge_ConnectLookChartEN.dicFldComparisonOp.Add(conge_ConnectLookChart.CourseId, strComparisonOp);
}
else
{
objge_ConnectLookChartEN.dicFldComparisonOp[conge_ConnectLookChart.CourseId] = strComparisonOp;
}
}
return objge_ConnectLookChartEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objge_ConnectLookChartEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsge_ConnectLookChartEN SetCreateUser(this clsge_ConnectLookChartEN objge_ConnectLookChartEN, string strCreateUser, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCreateUser, 50, conge_ConnectLookChart.CreateUser);
}
objge_ConnectLookChartEN.CreateUser = strCreateUser; //建立用户
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objge_ConnectLookChartEN.dicFldComparisonOp.ContainsKey(conge_ConnectLookChart.CreateUser) == false)
{
objge_ConnectLookChartEN.dicFldComparisonOp.Add(conge_ConnectLookChart.CreateUser, strComparisonOp);
}
else
{
objge_ConnectLookChartEN.dicFldComparisonOp[conge_ConnectLookChart.CreateUser] = strComparisonOp;
}
}
return objge_ConnectLookChartEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objge_ConnectLookChartEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsge_ConnectLookChartEN SetIsDisplay(this clsge_ConnectLookChartEN objge_ConnectLookChartEN, bool bolIsDisplay, string strComparisonOp="")
	{
objge_ConnectLookChartEN.IsDisplay = bolIsDisplay; //是否显示
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objge_ConnectLookChartEN.dicFldComparisonOp.ContainsKey(conge_ConnectLookChart.IsDisplay) == false)
{
objge_ConnectLookChartEN.dicFldComparisonOp.Add(conge_ConnectLookChart.IsDisplay, strComparisonOp);
}
else
{
objge_ConnectLookChartEN.dicFldComparisonOp[conge_ConnectLookChart.IsDisplay] = strComparisonOp;
}
}
return objge_ConnectLookChartEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objge_ConnectLookChartEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsge_ConnectLookChartEN SetIsAnswer(this clsge_ConnectLookChartEN objge_ConnectLookChartEN, bool bolIsAnswer, string strComparisonOp="")
	{
objge_ConnectLookChartEN.IsAnswer = bolIsAnswer; //是否回答
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objge_ConnectLookChartEN.dicFldComparisonOp.ContainsKey(conge_ConnectLookChart.IsAnswer) == false)
{
objge_ConnectLookChartEN.dicFldComparisonOp.Add(conge_ConnectLookChart.IsAnswer, strComparisonOp);
}
else
{
objge_ConnectLookChartEN.dicFldComparisonOp[conge_ConnectLookChart.IsAnswer] = strComparisonOp;
}
}
return objge_ConnectLookChartEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objge_ConnectLookChartEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsge_ConnectLookChartEN SetIsSubmit(this clsge_ConnectLookChartEN objge_ConnectLookChartEN, bool bolIsSubmit, string strComparisonOp="")
	{
objge_ConnectLookChartEN.IsSubmit = bolIsSubmit; //是否提交
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objge_ConnectLookChartEN.dicFldComparisonOp.ContainsKey(conge_ConnectLookChart.IsSubmit) == false)
{
objge_ConnectLookChartEN.dicFldComparisonOp.Add(conge_ConnectLookChart.IsSubmit, strComparisonOp);
}
else
{
objge_ConnectLookChartEN.dicFldComparisonOp[conge_ConnectLookChart.IsSubmit] = strComparisonOp;
}
}
return objge_ConnectLookChartEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objge_ConnectLookChartEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsge_ConnectLookChartEN SetStartTime(this clsge_ConnectLookChartEN objge_ConnectLookChartEN, string strStartTime, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strStartTime, 20, conge_ConnectLookChart.StartTime);
}
objge_ConnectLookChartEN.StartTime = strStartTime; //开始时间
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objge_ConnectLookChartEN.dicFldComparisonOp.ContainsKey(conge_ConnectLookChart.StartTime) == false)
{
objge_ConnectLookChartEN.dicFldComparisonOp.Add(conge_ConnectLookChart.StartTime, strComparisonOp);
}
else
{
objge_ConnectLookChartEN.dicFldComparisonOp[conge_ConnectLookChart.StartTime] = strComparisonOp;
}
}
return objge_ConnectLookChartEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objge_ConnectLookChartEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsge_ConnectLookChartEN SetSubmitTime(this clsge_ConnectLookChartEN objge_ConnectLookChartEN, string strSubmitTime, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strSubmitTime, 20, conge_ConnectLookChart.SubmitTime);
}
objge_ConnectLookChartEN.SubmitTime = strSubmitTime; //提交时间
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objge_ConnectLookChartEN.dicFldComparisonOp.ContainsKey(conge_ConnectLookChart.SubmitTime) == false)
{
objge_ConnectLookChartEN.dicFldComparisonOp.Add(conge_ConnectLookChart.SubmitTime, strComparisonOp);
}
else
{
objge_ConnectLookChartEN.dicFldComparisonOp[conge_ConnectLookChart.SubmitTime] = strComparisonOp;
}
}
return objge_ConnectLookChartEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objge_ConnectLookChartEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsge_ConnectLookChartEN SetUpdUser(this clsge_ConnectLookChartEN objge_ConnectLookChartEN, string strUpdUser, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdUser, 20, conge_ConnectLookChart.UpdUser);
}
objge_ConnectLookChartEN.UpdUser = strUpdUser; //修改人
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objge_ConnectLookChartEN.dicFldComparisonOp.ContainsKey(conge_ConnectLookChart.UpdUser) == false)
{
objge_ConnectLookChartEN.dicFldComparisonOp.Add(conge_ConnectLookChart.UpdUser, strComparisonOp);
}
else
{
objge_ConnectLookChartEN.dicFldComparisonOp[conge_ConnectLookChart.UpdUser] = strComparisonOp;
}
}
return objge_ConnectLookChartEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objge_ConnectLookChartEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsge_ConnectLookChartEN SetUpdDate(this clsge_ConnectLookChartEN objge_ConnectLookChartEN, string strUpdDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdDate, 20, conge_ConnectLookChart.UpdDate);
}
objge_ConnectLookChartEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objge_ConnectLookChartEN.dicFldComparisonOp.ContainsKey(conge_ConnectLookChart.UpdDate) == false)
{
objge_ConnectLookChartEN.dicFldComparisonOp.Add(conge_ConnectLookChart.UpdDate, strComparisonOp);
}
else
{
objge_ConnectLookChartEN.dicFldComparisonOp[conge_ConnectLookChart.UpdDate] = strComparisonOp;
}
}
return objge_ConnectLookChartEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objge_ConnectLookChartEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsge_ConnectLookChartEN SetMemo(this clsge_ConnectLookChartEN objge_ConnectLookChartEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, conge_ConnectLookChart.Memo);
}
objge_ConnectLookChartEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objge_ConnectLookChartEN.dicFldComparisonOp.ContainsKey(conge_ConnectLookChart.Memo) == false)
{
objge_ConnectLookChartEN.dicFldComparisonOp.Add(conge_ConnectLookChart.Memo, strComparisonOp);
}
else
{
objge_ConnectLookChartEN.dicFldComparisonOp[conge_ConnectLookChart.Memo] = strComparisonOp;
}
}
return objge_ConnectLookChartEN;
	}

 /// <summary>
 /// 修改记录存盘到数据表中
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_UpdateRecordEx)
 /// </summary>
 /// <param name = "objge_ConnectLookChartEN">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool UpdateRecordEx(this clsge_ConnectLookChartEN objge_ConnectLookChartEN)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
try
{
//1、检查传进去的对象属性是否合法
objge_ConnectLookChartEN.CheckPropertyNew();
clsge_ConnectLookChartEN objge_ConnectLookChartCond = new clsge_ConnectLookChartEN();
string strCondition = objge_ConnectLookChartCond
.SetConnectLookChartId(objge_ConnectLookChartEN.ConnectLookChartId, "<>")
.SetConnectLookChartId(objge_ConnectLookChartEN.ConnectLookChartId, "=")
.GetCombineCondition();
objge_ConnectLookChartEN._IsCheckProperty = true;
bool bolIsExist = clsge_ConnectLookChartBL.IsExistRecord(strCondition);
if (bolIsExist)
{
strMsg = "(ConnectLookChartId)不能重复!";
throw new Exception(strMsg);
}
//4、把数据实体层的数据存贮到数据库中
objge_ConnectLookChartEN.Update();
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
 /// <param name = "objge_ConnectLookChart">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool EditRecordEx(this clsge_ConnectLookChartEN objge_ConnectLookChart)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
clsge_ConnectLookChartEN objge_ConnectLookChartCond = new clsge_ConnectLookChartEN();
string strCondition = objge_ConnectLookChartCond
.SetConnectLookChartId(objge_ConnectLookChart.ConnectLookChartId, "=")
.GetCombineCondition();
objge_ConnectLookChart._IsCheckProperty = true;
bool bolIsExist = clsge_ConnectLookChartBL.IsExistRecord(strCondition);
if (bolIsExist)
{
objge_ConnectLookChart.ConnectLookChartId = clsge_ConnectLookChartBL.GetFirstID_S(strCondition);
objge_ConnectLookChart.UpdateWithCondition(strCondition);
}
else
{
objge_ConnectLookChart.ConnectLookChartId = clsge_ConnectLookChartBL.GetMaxStrId_S();
objge_ConnectLookChart.AddNewRecord();
}
return true; 
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_Update)
 /// </summary>
 /// <param name = "objge_ConnectLookChartEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsge_ConnectLookChartEN objge_ConnectLookChartEN)
{
 if (string.IsNullOrEmpty(objge_ConnectLookChartEN.ConnectLookChartId) == true)
 {
string strMsg = string.Format("(errid:Busi000095)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsge_ConnectLookChartBL.ge_ConnectLookChartDA.UpdateBySql2(objge_ConnectLookChartEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsge_ConnectLookChartBL.ReFreshCache(objge_ConnectLookChartEN.CourseId);

if (clsge_ConnectLookChartBL.relatedActions != null)
{
clsge_ConnectLookChartBL.relatedActions.UpdRelaTabDate(objge_ConnectLookChartEN.ConnectLookChartId, "SetUpdDate");
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
 /// <param name = "objge_ConnectLookChartEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsge_ConnectLookChartEN objge_ConnectLookChartEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (string.IsNullOrEmpty(objge_ConnectLookChartEN.ConnectLookChartId) == true)
 {
string strMsg = string.Format("(errid:Busi000087)修改记录时关键字不能为空!(带事务处理)(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsge_ConnectLookChartBL.ge_ConnectLookChartDA.UpdateBySql2(objge_ConnectLookChartEN, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsge_ConnectLookChartBL.ReFreshCache(objge_ConnectLookChartEN.CourseId);

if (clsge_ConnectLookChartBL.relatedActions != null)
{
clsge_ConnectLookChartBL.relatedActions.UpdRelaTabDate(objge_ConnectLookChartEN.ConnectLookChartId, "SetUpdDate");
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
 /// <param name = "objge_ConnectLookChartEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsge_ConnectLookChartEN objge_ConnectLookChartEN, string strWhereCond)
{
try
{
bool bolResult = clsge_ConnectLookChartBL.ge_ConnectLookChartDA.UpdateBySqlWithCondition(objge_ConnectLookChartEN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsge_ConnectLookChartBL.ReFreshCache(objge_ConnectLookChartEN.CourseId);

if (clsge_ConnectLookChartBL.relatedActions != null)
{
clsge_ConnectLookChartBL.relatedActions.UpdRelaTabDate(objge_ConnectLookChartEN.ConnectLookChartId, "SetUpdDate");
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
 /// <param name = "objge_ConnectLookChartEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsge_ConnectLookChartEN objge_ConnectLookChartEN, string strWhereCond, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
bool bolResult = clsge_ConnectLookChartBL.ge_ConnectLookChartDA.UpdateBySqlWithConditionTransaction(objge_ConnectLookChartEN, strWhereCond, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsge_ConnectLookChartBL.ReFreshCache(objge_ConnectLookChartEN.CourseId);

if (clsge_ConnectLookChartBL.relatedActions != null)
{
clsge_ConnectLookChartBL.relatedActions.UpdRelaTabDate(objge_ConnectLookChartEN.ConnectLookChartId, "SetUpdDate");
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
 /// <param name = "strConnectLookChartId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int Delete(this clsge_ConnectLookChartEN objge_ConnectLookChartEN)
{
try
{
int intRecNum = clsge_ConnectLookChartBL.ge_ConnectLookChartDA.DelRecord(objge_ConnectLookChartEN.ConnectLookChartId);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsge_ConnectLookChartBL.ReFreshCache(objge_ConnectLookChartEN.CourseId);

if (clsge_ConnectLookChartBL.relatedActions != null)
{
clsge_ConnectLookChartBL.relatedActions.UpdRelaTabDate(objge_ConnectLookChartEN.ConnectLookChartId, "SetUpdDate");
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
 /// <param name = "objge_ConnectLookChartENS">源对象</param>
 /// <param name = "objge_ConnectLookChartENT">目标对象</param>
 public static void CopyTo(this clsge_ConnectLookChartEN objge_ConnectLookChartENS, clsge_ConnectLookChartEN objge_ConnectLookChartENT)
{
try
{
objge_ConnectLookChartENT.ConnectLookChartId = objge_ConnectLookChartENS.ConnectLookChartId; //连连看图Id
objge_ConnectLookChartENT.ConnectLookChartName = objge_ConnectLookChartENS.ConnectLookChartName; //连连看图名
objge_ConnectLookChartENT.CourseId = objge_ConnectLookChartENS.CourseId; //课程Id
objge_ConnectLookChartENT.CreateUser = objge_ConnectLookChartENS.CreateUser; //建立用户
objge_ConnectLookChartENT.IsDisplay = objge_ConnectLookChartENS.IsDisplay; //是否显示
objge_ConnectLookChartENT.IsAnswer = objge_ConnectLookChartENS.IsAnswer; //是否回答
objge_ConnectLookChartENT.IsSubmit = objge_ConnectLookChartENS.IsSubmit; //是否提交
objge_ConnectLookChartENT.StartTime = objge_ConnectLookChartENS.StartTime; //开始时间
objge_ConnectLookChartENT.SubmitTime = objge_ConnectLookChartENS.SubmitTime; //提交时间
objge_ConnectLookChartENT.UpdUser = objge_ConnectLookChartENS.UpdUser; //修改人
objge_ConnectLookChartENT.UpdDate = objge_ConnectLookChartENS.UpdDate; //修改日期
objge_ConnectLookChartENT.Memo = objge_ConnectLookChartENS.Memo; //备注
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
 /// <param name = "objge_ConnectLookChartENS">源对象</param>
 /// <returns>目标对象=>clsge_ConnectLookChartEN:objge_ConnectLookChartENT</returns>
 public static clsge_ConnectLookChartEN CopyTo(this clsge_ConnectLookChartEN objge_ConnectLookChartENS)
{
try
{
 clsge_ConnectLookChartEN objge_ConnectLookChartENT = new clsge_ConnectLookChartEN()
{
ConnectLookChartId = objge_ConnectLookChartENS.ConnectLookChartId, //连连看图Id
ConnectLookChartName = objge_ConnectLookChartENS.ConnectLookChartName, //连连看图名
CourseId = objge_ConnectLookChartENS.CourseId, //课程Id
CreateUser = objge_ConnectLookChartENS.CreateUser, //建立用户
IsDisplay = objge_ConnectLookChartENS.IsDisplay, //是否显示
IsAnswer = objge_ConnectLookChartENS.IsAnswer, //是否回答
IsSubmit = objge_ConnectLookChartENS.IsSubmit, //是否提交
StartTime = objge_ConnectLookChartENS.StartTime, //开始时间
SubmitTime = objge_ConnectLookChartENS.SubmitTime, //提交时间
UpdUser = objge_ConnectLookChartENS.UpdUser, //修改人
UpdDate = objge_ConnectLookChartENS.UpdDate, //修改日期
Memo = objge_ConnectLookChartENS.Memo, //备注
};
 return objge_ConnectLookChartENT;
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
public static void CheckPropertyNew(this clsge_ConnectLookChartEN objge_ConnectLookChartEN)
{
 clsge_ConnectLookChartBL.ge_ConnectLookChartDA.CheckPropertyNew(objge_ConnectLookChartEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(this clsge_ConnectLookChartEN objge_ConnectLookChartEN)
{
 clsge_ConnectLookChartBL.ge_ConnectLookChartDA.CheckProperty4Condition(objge_ConnectLookChartEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsge_ConnectLookChartEN objge_ConnectLookChartCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objge_ConnectLookChartCond.IsUpdated(conge_ConnectLookChart.ConnectLookChartId) == true)
{
string strComparisonOpConnectLookChartId = objge_ConnectLookChartCond.dicFldComparisonOp[conge_ConnectLookChart.ConnectLookChartId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conge_ConnectLookChart.ConnectLookChartId, objge_ConnectLookChartCond.ConnectLookChartId, strComparisonOpConnectLookChartId);
}
if (objge_ConnectLookChartCond.IsUpdated(conge_ConnectLookChart.ConnectLookChartName) == true)
{
string strComparisonOpConnectLookChartName = objge_ConnectLookChartCond.dicFldComparisonOp[conge_ConnectLookChart.ConnectLookChartName];
strWhereCond += string.Format(" And {0} {2} '{1}'", conge_ConnectLookChart.ConnectLookChartName, objge_ConnectLookChartCond.ConnectLookChartName, strComparisonOpConnectLookChartName);
}
if (objge_ConnectLookChartCond.IsUpdated(conge_ConnectLookChart.CourseId) == true)
{
string strComparisonOpCourseId = objge_ConnectLookChartCond.dicFldComparisonOp[conge_ConnectLookChart.CourseId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conge_ConnectLookChart.CourseId, objge_ConnectLookChartCond.CourseId, strComparisonOpCourseId);
}
if (objge_ConnectLookChartCond.IsUpdated(conge_ConnectLookChart.CreateUser) == true)
{
string strComparisonOpCreateUser = objge_ConnectLookChartCond.dicFldComparisonOp[conge_ConnectLookChart.CreateUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", conge_ConnectLookChart.CreateUser, objge_ConnectLookChartCond.CreateUser, strComparisonOpCreateUser);
}
if (objge_ConnectLookChartCond.IsUpdated(conge_ConnectLookChart.IsDisplay) == true)
{
if (objge_ConnectLookChartCond.IsDisplay == true)
{
strWhereCond += string.Format(" And {0} = '1'", conge_ConnectLookChart.IsDisplay);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conge_ConnectLookChart.IsDisplay);
}
}
if (objge_ConnectLookChartCond.IsUpdated(conge_ConnectLookChart.IsAnswer) == true)
{
if (objge_ConnectLookChartCond.IsAnswer == true)
{
strWhereCond += string.Format(" And {0} = '1'", conge_ConnectLookChart.IsAnswer);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conge_ConnectLookChart.IsAnswer);
}
}
if (objge_ConnectLookChartCond.IsUpdated(conge_ConnectLookChart.IsSubmit) == true)
{
if (objge_ConnectLookChartCond.IsSubmit == true)
{
strWhereCond += string.Format(" And {0} = '1'", conge_ConnectLookChart.IsSubmit);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conge_ConnectLookChart.IsSubmit);
}
}
if (objge_ConnectLookChartCond.IsUpdated(conge_ConnectLookChart.StartTime) == true)
{
string strComparisonOpStartTime = objge_ConnectLookChartCond.dicFldComparisonOp[conge_ConnectLookChart.StartTime];
strWhereCond += string.Format(" And {0} {2} '{1}'", conge_ConnectLookChart.StartTime, objge_ConnectLookChartCond.StartTime, strComparisonOpStartTime);
}
if (objge_ConnectLookChartCond.IsUpdated(conge_ConnectLookChart.SubmitTime) == true)
{
string strComparisonOpSubmitTime = objge_ConnectLookChartCond.dicFldComparisonOp[conge_ConnectLookChart.SubmitTime];
strWhereCond += string.Format(" And {0} {2} '{1}'", conge_ConnectLookChart.SubmitTime, objge_ConnectLookChartCond.SubmitTime, strComparisonOpSubmitTime);
}
if (objge_ConnectLookChartCond.IsUpdated(conge_ConnectLookChart.UpdUser) == true)
{
string strComparisonOpUpdUser = objge_ConnectLookChartCond.dicFldComparisonOp[conge_ConnectLookChart.UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", conge_ConnectLookChart.UpdUser, objge_ConnectLookChartCond.UpdUser, strComparisonOpUpdUser);
}
if (objge_ConnectLookChartCond.IsUpdated(conge_ConnectLookChart.UpdDate) == true)
{
string strComparisonOpUpdDate = objge_ConnectLookChartCond.dicFldComparisonOp[conge_ConnectLookChart.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conge_ConnectLookChart.UpdDate, objge_ConnectLookChartCond.UpdDate, strComparisonOpUpdDate);
}
if (objge_ConnectLookChartCond.IsUpdated(conge_ConnectLookChart.Memo) == true)
{
string strComparisonOpMemo = objge_ConnectLookChartCond.dicFldComparisonOp[conge_ConnectLookChart.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", conge_ConnectLookChart.Memo, objge_ConnectLookChartCond.Memo, strComparisonOpMemo);
}
 return strWhereCond;
}

 /// <summary>
 /// 检查唯一性(Uniqueness)--ge_ConnectLookChart(连连看图表), 如果不唯一,即存在相同的记录,就返回False
 /// 唯一性条件:ConnectLookChartId
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckConstraint)
 /// </summary>
 /// <param name = "objge_ConnectLookChartEN">要求唯一的对象</param>
 /// <returns></returns>
public static bool CheckUniqueness(this clsge_ConnectLookChartEN objge_ConnectLookChartEN)
{
//检测记录是否存在
bool bolIsUniqueness;
StringBuilder sbCondition = new StringBuilder();
if (objge_ConnectLookChartEN == null) return true;
if (objge_ConnectLookChartEN.ConnectLookChartId == null || objge_ConnectLookChartEN.ConnectLookChartId == "")
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and ConnectLookChartId = '{0}'", objge_ConnectLookChartEN.ConnectLookChartId);
if (clsge_ConnectLookChartBL.IsExistRecord(sbCondition.ToString())  ==  true)
{
 bolIsUniqueness = false;
}
else
{
 bolIsUniqueness = true;
}
}
 else {
sbCondition.AppendFormat("ConnectLookChartId !=  '{0}'", objge_ConnectLookChartEN.ConnectLookChartId);
 sbCondition.AppendFormat(" and ConnectLookChartId = '{0}'", objge_ConnectLookChartEN.ConnectLookChartId);
if (clsge_ConnectLookChartBL.IsExistRecord(sbCondition.ToString())  ==  true)
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
 /// 获取唯一性条件串--ge_ConnectLookChart(连连看图表), 即由对象中唯一性条件字段关键字与值组成的条件串
 /// 唯一性条件:ConnectLookChartId
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetConditionString4Constraint)
 /// </summary>
 /// <param name = "objge_ConnectLookChartEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(this clsge_ConnectLookChartEN objge_ConnectLookChartEN)
{
//检测记录是否存在
StringBuilder sbCondition = new StringBuilder();
if (objge_ConnectLookChartEN == null) return "";
if (objge_ConnectLookChartEN.ConnectLookChartId == null || objge_ConnectLookChartEN.ConnectLookChartId == "")
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and ConnectLookChartId = '{0}'", objge_ConnectLookChartEN.ConnectLookChartId);
return sbCondition.ToString();
}
 else {
sbCondition.AppendFormat("ConnectLookChartId !=  '{0}'", objge_ConnectLookChartEN.ConnectLookChartId);
 sbCondition.AppendFormat(" and ConnectLookChartId = '{0}'", objge_ConnectLookChartEN.ConnectLookChartId);
 return sbCondition.ToString();
}
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_ge_ConnectLookChart
{
public virtual bool UpdRelaTabDate(string strConnectLookChartId, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// 连连看图表(ge_ConnectLookChart)
 /// 数据源类型:表
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsge_ConnectLookChartBL
{
public static RelatedActions_ge_ConnectLookChart relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsge_ConnectLookChartDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsge_ConnectLookChartDA ge_ConnectLookChartDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsge_ConnectLookChartDA();
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
 public clsge_ConnectLookChartBL()
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
if (string.IsNullOrEmpty(clsge_ConnectLookChartEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsge_ConnectLookChartEN._ConnectString);
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
public static DataTable GetDataTable_ge_ConnectLookChart(string strWhereCond)
{
DataTable objDT;
try
{
objDT = ge_ConnectLookChartDA.GetDataTable_ge_ConnectLookChart(strWhereCond);
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
objDT = ge_ConnectLookChartDA.GetDataTable(strWhereCond);
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
objDT = ge_ConnectLookChartDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = ge_ConnectLookChartDA.GetDataTable(strWhereCond, strTabName);
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
objDT = ge_ConnectLookChartDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = ge_ConnectLookChartDA.GetDataTable_Top(objTopPara);
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
objDT = ge_ConnectLookChartDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = ge_ConnectLookChartDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = ge_ConnectLookChartDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
 /// <param name = "arrConnectLookChartIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static List<clsge_ConnectLookChartEN> GetObjLstByConnectLookChartIdLst(List<string> arrConnectLookChartIdLst)
{
List<clsge_ConnectLookChartEN> arrObjLst = new List<clsge_ConnectLookChartEN>(); 
System.Data.DataTable objDT; 
 string strSqlConditionStr = clsArray.GetSqlInStrByArray(arrConnectLookChartIdLst, true);
 string strWhereCond = string.Format("ConnectLookChartId in ({0})", strSqlConditionStr);
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsge_ConnectLookChartEN objge_ConnectLookChartEN = new clsge_ConnectLookChartEN();
try
{
objge_ConnectLookChartEN.ConnectLookChartId = objRow[conge_ConnectLookChart.ConnectLookChartId].ToString().Trim(); //连连看图Id
objge_ConnectLookChartEN.ConnectLookChartName = objRow[conge_ConnectLookChart.ConnectLookChartName] == DBNull.Value ? null : objRow[conge_ConnectLookChart.ConnectLookChartName].ToString().Trim(); //连连看图名
objge_ConnectLookChartEN.CourseId = objRow[conge_ConnectLookChart.CourseId] == DBNull.Value ? null : objRow[conge_ConnectLookChart.CourseId].ToString().Trim(); //课程Id
objge_ConnectLookChartEN.CreateUser = objRow[conge_ConnectLookChart.CreateUser] == DBNull.Value ? null : objRow[conge_ConnectLookChart.CreateUser].ToString().Trim(); //建立用户
objge_ConnectLookChartEN.IsDisplay = clsEntityBase2.TransNullToBool_S(objRow[conge_ConnectLookChart.IsDisplay].ToString().Trim()); //是否显示
objge_ConnectLookChartEN.IsAnswer = clsEntityBase2.TransNullToBool_S(objRow[conge_ConnectLookChart.IsAnswer].ToString().Trim()); //是否回答
objge_ConnectLookChartEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[conge_ConnectLookChart.IsSubmit].ToString().Trim()); //是否提交
objge_ConnectLookChartEN.StartTime = objRow[conge_ConnectLookChart.StartTime] == DBNull.Value ? null : objRow[conge_ConnectLookChart.StartTime].ToString().Trim(); //开始时间
objge_ConnectLookChartEN.SubmitTime = objRow[conge_ConnectLookChart.SubmitTime] == DBNull.Value ? null : objRow[conge_ConnectLookChart.SubmitTime].ToString().Trim(); //提交时间
objge_ConnectLookChartEN.UpdUser = objRow[conge_ConnectLookChart.UpdUser] == DBNull.Value ? null : objRow[conge_ConnectLookChart.UpdUser].ToString().Trim(); //修改人
objge_ConnectLookChartEN.UpdDate = objRow[conge_ConnectLookChart.UpdDate] == DBNull.Value ? null : objRow[conge_ConnectLookChart.UpdDate].ToString().Trim(); //修改日期
objge_ConnectLookChartEN.Memo = objRow[conge_ConnectLookChart.Memo] == DBNull.Value ? null : objRow[conge_ConnectLookChart.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objge_ConnectLookChartEN.ConnectLookChartId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objge_ConnectLookChartEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrConnectLookChartIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsge_ConnectLookChartEN> GetObjLstByConnectLookChartIdLstCache(List<string> arrConnectLookChartIdLst, string strCourseId)
{
string strKey = string.Format("{0}_{1}", clsge_ConnectLookChartEN._CurrTabName, strCourseId);
List<clsge_ConnectLookChartEN> arrge_ConnectLookChartObjLstCache = GetObjLstCache(strCourseId);
IEnumerable <clsge_ConnectLookChartEN> arrge_ConnectLookChartObjLst_Sel =
arrge_ConnectLookChartObjLstCache
.Where(x => arrConnectLookChartIdLst.Contains(x.ConnectLookChartId));
return arrge_ConnectLookChartObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsge_ConnectLookChartEN> GetObjLst(string strWhereCond)
{
List<clsge_ConnectLookChartEN> arrObjLst = new List<clsge_ConnectLookChartEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsge_ConnectLookChartEN objge_ConnectLookChartEN = new clsge_ConnectLookChartEN();
try
{
objge_ConnectLookChartEN.ConnectLookChartId = objRow[conge_ConnectLookChart.ConnectLookChartId].ToString().Trim(); //连连看图Id
objge_ConnectLookChartEN.ConnectLookChartName = objRow[conge_ConnectLookChart.ConnectLookChartName] == DBNull.Value ? null : objRow[conge_ConnectLookChart.ConnectLookChartName].ToString().Trim(); //连连看图名
objge_ConnectLookChartEN.CourseId = objRow[conge_ConnectLookChart.CourseId] == DBNull.Value ? null : objRow[conge_ConnectLookChart.CourseId].ToString().Trim(); //课程Id
objge_ConnectLookChartEN.CreateUser = objRow[conge_ConnectLookChart.CreateUser] == DBNull.Value ? null : objRow[conge_ConnectLookChart.CreateUser].ToString().Trim(); //建立用户
objge_ConnectLookChartEN.IsDisplay = clsEntityBase2.TransNullToBool_S(objRow[conge_ConnectLookChart.IsDisplay].ToString().Trim()); //是否显示
objge_ConnectLookChartEN.IsAnswer = clsEntityBase2.TransNullToBool_S(objRow[conge_ConnectLookChart.IsAnswer].ToString().Trim()); //是否回答
objge_ConnectLookChartEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[conge_ConnectLookChart.IsSubmit].ToString().Trim()); //是否提交
objge_ConnectLookChartEN.StartTime = objRow[conge_ConnectLookChart.StartTime] == DBNull.Value ? null : objRow[conge_ConnectLookChart.StartTime].ToString().Trim(); //开始时间
objge_ConnectLookChartEN.SubmitTime = objRow[conge_ConnectLookChart.SubmitTime] == DBNull.Value ? null : objRow[conge_ConnectLookChart.SubmitTime].ToString().Trim(); //提交时间
objge_ConnectLookChartEN.UpdUser = objRow[conge_ConnectLookChart.UpdUser] == DBNull.Value ? null : objRow[conge_ConnectLookChart.UpdUser].ToString().Trim(); //修改人
objge_ConnectLookChartEN.UpdDate = objRow[conge_ConnectLookChart.UpdDate] == DBNull.Value ? null : objRow[conge_ConnectLookChart.UpdDate].ToString().Trim(); //修改日期
objge_ConnectLookChartEN.Memo = objRow[conge_ConnectLookChart.Memo] == DBNull.Value ? null : objRow[conge_ConnectLookChart.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objge_ConnectLookChartEN.ConnectLookChartId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objge_ConnectLookChartEN);
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
public static List<clsge_ConnectLookChartEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsge_ConnectLookChartEN> arrObjLst = new List<clsge_ConnectLookChartEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsge_ConnectLookChartEN objge_ConnectLookChartEN = new clsge_ConnectLookChartEN();
try
{
objge_ConnectLookChartEN.ConnectLookChartId = objRow[conge_ConnectLookChart.ConnectLookChartId].ToString().Trim(); //连连看图Id
objge_ConnectLookChartEN.ConnectLookChartName = objRow[conge_ConnectLookChart.ConnectLookChartName] == DBNull.Value ? null : objRow[conge_ConnectLookChart.ConnectLookChartName].ToString().Trim(); //连连看图名
objge_ConnectLookChartEN.CourseId = objRow[conge_ConnectLookChart.CourseId] == DBNull.Value ? null : objRow[conge_ConnectLookChart.CourseId].ToString().Trim(); //课程Id
objge_ConnectLookChartEN.CreateUser = objRow[conge_ConnectLookChart.CreateUser] == DBNull.Value ? null : objRow[conge_ConnectLookChart.CreateUser].ToString().Trim(); //建立用户
objge_ConnectLookChartEN.IsDisplay = clsEntityBase2.TransNullToBool_S(objRow[conge_ConnectLookChart.IsDisplay].ToString().Trim()); //是否显示
objge_ConnectLookChartEN.IsAnswer = clsEntityBase2.TransNullToBool_S(objRow[conge_ConnectLookChart.IsAnswer].ToString().Trim()); //是否回答
objge_ConnectLookChartEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[conge_ConnectLookChart.IsSubmit].ToString().Trim()); //是否提交
objge_ConnectLookChartEN.StartTime = objRow[conge_ConnectLookChart.StartTime] == DBNull.Value ? null : objRow[conge_ConnectLookChart.StartTime].ToString().Trim(); //开始时间
objge_ConnectLookChartEN.SubmitTime = objRow[conge_ConnectLookChart.SubmitTime] == DBNull.Value ? null : objRow[conge_ConnectLookChart.SubmitTime].ToString().Trim(); //提交时间
objge_ConnectLookChartEN.UpdUser = objRow[conge_ConnectLookChart.UpdUser] == DBNull.Value ? null : objRow[conge_ConnectLookChart.UpdUser].ToString().Trim(); //修改人
objge_ConnectLookChartEN.UpdDate = objRow[conge_ConnectLookChart.UpdDate] == DBNull.Value ? null : objRow[conge_ConnectLookChart.UpdDate].ToString().Trim(); //修改日期
objge_ConnectLookChartEN.Memo = objRow[conge_ConnectLookChart.Memo] == DBNull.Value ? null : objRow[conge_ConnectLookChart.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objge_ConnectLookChartEN.ConnectLookChartId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objge_ConnectLookChartEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objge_ConnectLookChartCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsge_ConnectLookChartEN> GetSubObjLstCache(clsge_ConnectLookChartEN objge_ConnectLookChartCond)
{
 string strCourseId = objge_ConnectLookChartCond.CourseId;
 if (string.IsNullOrEmpty(strCourseId) == true)
{
string strMsg = string.Format("(errid:Busi000172)在表中,缓存分类字段值不能为空!(clsge_ConnectLookChartBL:GetSubObjLstCache)");
throw new Exception(strMsg);
}
List<clsge_ConnectLookChartEN> arrObjLstCache = GetObjLstCache(strCourseId);
IEnumerable <clsge_ConnectLookChartEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conge_ConnectLookChart.AttributeName)
{
if (objge_ConnectLookChartCond.IsUpdated(strFldName) == false) continue;
if (objge_ConnectLookChartCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objge_ConnectLookChartCond[strFldName].ToString());
}
else
{
if (objge_ConnectLookChartCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objge_ConnectLookChartCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objge_ConnectLookChartCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objge_ConnectLookChartCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objge_ConnectLookChartCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objge_ConnectLookChartCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objge_ConnectLookChartCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objge_ConnectLookChartCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objge_ConnectLookChartCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objge_ConnectLookChartCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objge_ConnectLookChartCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objge_ConnectLookChartCond[strFldName]));
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
public static List<clsge_ConnectLookChartEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsge_ConnectLookChartEN> arrObjLst = new List<clsge_ConnectLookChartEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsge_ConnectLookChartEN objge_ConnectLookChartEN = new clsge_ConnectLookChartEN();
try
{
objge_ConnectLookChartEN.ConnectLookChartId = objRow[conge_ConnectLookChart.ConnectLookChartId].ToString().Trim(); //连连看图Id
objge_ConnectLookChartEN.ConnectLookChartName = objRow[conge_ConnectLookChart.ConnectLookChartName] == DBNull.Value ? null : objRow[conge_ConnectLookChart.ConnectLookChartName].ToString().Trim(); //连连看图名
objge_ConnectLookChartEN.CourseId = objRow[conge_ConnectLookChart.CourseId] == DBNull.Value ? null : objRow[conge_ConnectLookChart.CourseId].ToString().Trim(); //课程Id
objge_ConnectLookChartEN.CreateUser = objRow[conge_ConnectLookChart.CreateUser] == DBNull.Value ? null : objRow[conge_ConnectLookChart.CreateUser].ToString().Trim(); //建立用户
objge_ConnectLookChartEN.IsDisplay = clsEntityBase2.TransNullToBool_S(objRow[conge_ConnectLookChart.IsDisplay].ToString().Trim()); //是否显示
objge_ConnectLookChartEN.IsAnswer = clsEntityBase2.TransNullToBool_S(objRow[conge_ConnectLookChart.IsAnswer].ToString().Trim()); //是否回答
objge_ConnectLookChartEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[conge_ConnectLookChart.IsSubmit].ToString().Trim()); //是否提交
objge_ConnectLookChartEN.StartTime = objRow[conge_ConnectLookChart.StartTime] == DBNull.Value ? null : objRow[conge_ConnectLookChart.StartTime].ToString().Trim(); //开始时间
objge_ConnectLookChartEN.SubmitTime = objRow[conge_ConnectLookChart.SubmitTime] == DBNull.Value ? null : objRow[conge_ConnectLookChart.SubmitTime].ToString().Trim(); //提交时间
objge_ConnectLookChartEN.UpdUser = objRow[conge_ConnectLookChart.UpdUser] == DBNull.Value ? null : objRow[conge_ConnectLookChart.UpdUser].ToString().Trim(); //修改人
objge_ConnectLookChartEN.UpdDate = objRow[conge_ConnectLookChart.UpdDate] == DBNull.Value ? null : objRow[conge_ConnectLookChart.UpdDate].ToString().Trim(); //修改日期
objge_ConnectLookChartEN.Memo = objRow[conge_ConnectLookChart.Memo] == DBNull.Value ? null : objRow[conge_ConnectLookChart.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objge_ConnectLookChartEN.ConnectLookChartId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objge_ConnectLookChartEN);
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
public static List<clsge_ConnectLookChartEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsge_ConnectLookChartEN> arrObjLst = new List<clsge_ConnectLookChartEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsge_ConnectLookChartEN objge_ConnectLookChartEN = new clsge_ConnectLookChartEN();
try
{
objge_ConnectLookChartEN.ConnectLookChartId = objRow[conge_ConnectLookChart.ConnectLookChartId].ToString().Trim(); //连连看图Id
objge_ConnectLookChartEN.ConnectLookChartName = objRow[conge_ConnectLookChart.ConnectLookChartName] == DBNull.Value ? null : objRow[conge_ConnectLookChart.ConnectLookChartName].ToString().Trim(); //连连看图名
objge_ConnectLookChartEN.CourseId = objRow[conge_ConnectLookChart.CourseId] == DBNull.Value ? null : objRow[conge_ConnectLookChart.CourseId].ToString().Trim(); //课程Id
objge_ConnectLookChartEN.CreateUser = objRow[conge_ConnectLookChart.CreateUser] == DBNull.Value ? null : objRow[conge_ConnectLookChart.CreateUser].ToString().Trim(); //建立用户
objge_ConnectLookChartEN.IsDisplay = clsEntityBase2.TransNullToBool_S(objRow[conge_ConnectLookChart.IsDisplay].ToString().Trim()); //是否显示
objge_ConnectLookChartEN.IsAnswer = clsEntityBase2.TransNullToBool_S(objRow[conge_ConnectLookChart.IsAnswer].ToString().Trim()); //是否回答
objge_ConnectLookChartEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[conge_ConnectLookChart.IsSubmit].ToString().Trim()); //是否提交
objge_ConnectLookChartEN.StartTime = objRow[conge_ConnectLookChart.StartTime] == DBNull.Value ? null : objRow[conge_ConnectLookChart.StartTime].ToString().Trim(); //开始时间
objge_ConnectLookChartEN.SubmitTime = objRow[conge_ConnectLookChart.SubmitTime] == DBNull.Value ? null : objRow[conge_ConnectLookChart.SubmitTime].ToString().Trim(); //提交时间
objge_ConnectLookChartEN.UpdUser = objRow[conge_ConnectLookChart.UpdUser] == DBNull.Value ? null : objRow[conge_ConnectLookChart.UpdUser].ToString().Trim(); //修改人
objge_ConnectLookChartEN.UpdDate = objRow[conge_ConnectLookChart.UpdDate] == DBNull.Value ? null : objRow[conge_ConnectLookChart.UpdDate].ToString().Trim(); //修改日期
objge_ConnectLookChartEN.Memo = objRow[conge_ConnectLookChart.Memo] == DBNull.Value ? null : objRow[conge_ConnectLookChart.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objge_ConnectLookChartEN.ConnectLookChartId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objge_ConnectLookChartEN);
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
List<clsge_ConnectLookChartEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsge_ConnectLookChartEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsge_ConnectLookChartEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsge_ConnectLookChartEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsge_ConnectLookChartEN> arrObjLst = new List<clsge_ConnectLookChartEN>(); 
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
	clsge_ConnectLookChartEN objge_ConnectLookChartEN = new clsge_ConnectLookChartEN();
try
{
objge_ConnectLookChartEN.ConnectLookChartId = objRow[conge_ConnectLookChart.ConnectLookChartId].ToString().Trim(); //连连看图Id
objge_ConnectLookChartEN.ConnectLookChartName = objRow[conge_ConnectLookChart.ConnectLookChartName] == DBNull.Value ? null : objRow[conge_ConnectLookChart.ConnectLookChartName].ToString().Trim(); //连连看图名
objge_ConnectLookChartEN.CourseId = objRow[conge_ConnectLookChart.CourseId] == DBNull.Value ? null : objRow[conge_ConnectLookChart.CourseId].ToString().Trim(); //课程Id
objge_ConnectLookChartEN.CreateUser = objRow[conge_ConnectLookChart.CreateUser] == DBNull.Value ? null : objRow[conge_ConnectLookChart.CreateUser].ToString().Trim(); //建立用户
objge_ConnectLookChartEN.IsDisplay = clsEntityBase2.TransNullToBool_S(objRow[conge_ConnectLookChart.IsDisplay].ToString().Trim()); //是否显示
objge_ConnectLookChartEN.IsAnswer = clsEntityBase2.TransNullToBool_S(objRow[conge_ConnectLookChart.IsAnswer].ToString().Trim()); //是否回答
objge_ConnectLookChartEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[conge_ConnectLookChart.IsSubmit].ToString().Trim()); //是否提交
objge_ConnectLookChartEN.StartTime = objRow[conge_ConnectLookChart.StartTime] == DBNull.Value ? null : objRow[conge_ConnectLookChart.StartTime].ToString().Trim(); //开始时间
objge_ConnectLookChartEN.SubmitTime = objRow[conge_ConnectLookChart.SubmitTime] == DBNull.Value ? null : objRow[conge_ConnectLookChart.SubmitTime].ToString().Trim(); //提交时间
objge_ConnectLookChartEN.UpdUser = objRow[conge_ConnectLookChart.UpdUser] == DBNull.Value ? null : objRow[conge_ConnectLookChart.UpdUser].ToString().Trim(); //修改人
objge_ConnectLookChartEN.UpdDate = objRow[conge_ConnectLookChart.UpdDate] == DBNull.Value ? null : objRow[conge_ConnectLookChart.UpdDate].ToString().Trim(); //修改日期
objge_ConnectLookChartEN.Memo = objRow[conge_ConnectLookChart.Memo] == DBNull.Value ? null : objRow[conge_ConnectLookChart.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objge_ConnectLookChartEN.ConnectLookChartId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objge_ConnectLookChartEN);
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
public static List<clsge_ConnectLookChartEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsge_ConnectLookChartEN> arrObjLst = new List<clsge_ConnectLookChartEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsge_ConnectLookChartEN objge_ConnectLookChartEN = new clsge_ConnectLookChartEN();
try
{
objge_ConnectLookChartEN.ConnectLookChartId = objRow[conge_ConnectLookChart.ConnectLookChartId].ToString().Trim(); //连连看图Id
objge_ConnectLookChartEN.ConnectLookChartName = objRow[conge_ConnectLookChart.ConnectLookChartName] == DBNull.Value ? null : objRow[conge_ConnectLookChart.ConnectLookChartName].ToString().Trim(); //连连看图名
objge_ConnectLookChartEN.CourseId = objRow[conge_ConnectLookChart.CourseId] == DBNull.Value ? null : objRow[conge_ConnectLookChart.CourseId].ToString().Trim(); //课程Id
objge_ConnectLookChartEN.CreateUser = objRow[conge_ConnectLookChart.CreateUser] == DBNull.Value ? null : objRow[conge_ConnectLookChart.CreateUser].ToString().Trim(); //建立用户
objge_ConnectLookChartEN.IsDisplay = clsEntityBase2.TransNullToBool_S(objRow[conge_ConnectLookChart.IsDisplay].ToString().Trim()); //是否显示
objge_ConnectLookChartEN.IsAnswer = clsEntityBase2.TransNullToBool_S(objRow[conge_ConnectLookChart.IsAnswer].ToString().Trim()); //是否回答
objge_ConnectLookChartEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[conge_ConnectLookChart.IsSubmit].ToString().Trim()); //是否提交
objge_ConnectLookChartEN.StartTime = objRow[conge_ConnectLookChart.StartTime] == DBNull.Value ? null : objRow[conge_ConnectLookChart.StartTime].ToString().Trim(); //开始时间
objge_ConnectLookChartEN.SubmitTime = objRow[conge_ConnectLookChart.SubmitTime] == DBNull.Value ? null : objRow[conge_ConnectLookChart.SubmitTime].ToString().Trim(); //提交时间
objge_ConnectLookChartEN.UpdUser = objRow[conge_ConnectLookChart.UpdUser] == DBNull.Value ? null : objRow[conge_ConnectLookChart.UpdUser].ToString().Trim(); //修改人
objge_ConnectLookChartEN.UpdDate = objRow[conge_ConnectLookChart.UpdDate] == DBNull.Value ? null : objRow[conge_ConnectLookChart.UpdDate].ToString().Trim(); //修改日期
objge_ConnectLookChartEN.Memo = objRow[conge_ConnectLookChart.Memo] == DBNull.Value ? null : objRow[conge_ConnectLookChart.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objge_ConnectLookChartEN.ConnectLookChartId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objge_ConnectLookChartEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsge_ConnectLookChartEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsge_ConnectLookChartEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsge_ConnectLookChartEN> arrObjLst = new List<clsge_ConnectLookChartEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsge_ConnectLookChartEN objge_ConnectLookChartEN = new clsge_ConnectLookChartEN();
try
{
objge_ConnectLookChartEN.ConnectLookChartId = objRow[conge_ConnectLookChart.ConnectLookChartId].ToString().Trim(); //连连看图Id
objge_ConnectLookChartEN.ConnectLookChartName = objRow[conge_ConnectLookChart.ConnectLookChartName] == DBNull.Value ? null : objRow[conge_ConnectLookChart.ConnectLookChartName].ToString().Trim(); //连连看图名
objge_ConnectLookChartEN.CourseId = objRow[conge_ConnectLookChart.CourseId] == DBNull.Value ? null : objRow[conge_ConnectLookChart.CourseId].ToString().Trim(); //课程Id
objge_ConnectLookChartEN.CreateUser = objRow[conge_ConnectLookChart.CreateUser] == DBNull.Value ? null : objRow[conge_ConnectLookChart.CreateUser].ToString().Trim(); //建立用户
objge_ConnectLookChartEN.IsDisplay = clsEntityBase2.TransNullToBool_S(objRow[conge_ConnectLookChart.IsDisplay].ToString().Trim()); //是否显示
objge_ConnectLookChartEN.IsAnswer = clsEntityBase2.TransNullToBool_S(objRow[conge_ConnectLookChart.IsAnswer].ToString().Trim()); //是否回答
objge_ConnectLookChartEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[conge_ConnectLookChart.IsSubmit].ToString().Trim()); //是否提交
objge_ConnectLookChartEN.StartTime = objRow[conge_ConnectLookChart.StartTime] == DBNull.Value ? null : objRow[conge_ConnectLookChart.StartTime].ToString().Trim(); //开始时间
objge_ConnectLookChartEN.SubmitTime = objRow[conge_ConnectLookChart.SubmitTime] == DBNull.Value ? null : objRow[conge_ConnectLookChart.SubmitTime].ToString().Trim(); //提交时间
objge_ConnectLookChartEN.UpdUser = objRow[conge_ConnectLookChart.UpdUser] == DBNull.Value ? null : objRow[conge_ConnectLookChart.UpdUser].ToString().Trim(); //修改人
objge_ConnectLookChartEN.UpdDate = objRow[conge_ConnectLookChart.UpdDate] == DBNull.Value ? null : objRow[conge_ConnectLookChart.UpdDate].ToString().Trim(); //修改日期
objge_ConnectLookChartEN.Memo = objRow[conge_ConnectLookChart.Memo] == DBNull.Value ? null : objRow[conge_ConnectLookChart.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objge_ConnectLookChartEN.ConnectLookChartId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objge_ConnectLookChartEN);
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
public static List<clsge_ConnectLookChartEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsge_ConnectLookChartEN> arrObjLst = new List<clsge_ConnectLookChartEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsge_ConnectLookChartEN objge_ConnectLookChartEN = new clsge_ConnectLookChartEN();
try
{
objge_ConnectLookChartEN.ConnectLookChartId = objRow[conge_ConnectLookChart.ConnectLookChartId].ToString().Trim(); //连连看图Id
objge_ConnectLookChartEN.ConnectLookChartName = objRow[conge_ConnectLookChart.ConnectLookChartName] == DBNull.Value ? null : objRow[conge_ConnectLookChart.ConnectLookChartName].ToString().Trim(); //连连看图名
objge_ConnectLookChartEN.CourseId = objRow[conge_ConnectLookChart.CourseId] == DBNull.Value ? null : objRow[conge_ConnectLookChart.CourseId].ToString().Trim(); //课程Id
objge_ConnectLookChartEN.CreateUser = objRow[conge_ConnectLookChart.CreateUser] == DBNull.Value ? null : objRow[conge_ConnectLookChart.CreateUser].ToString().Trim(); //建立用户
objge_ConnectLookChartEN.IsDisplay = clsEntityBase2.TransNullToBool_S(objRow[conge_ConnectLookChart.IsDisplay].ToString().Trim()); //是否显示
objge_ConnectLookChartEN.IsAnswer = clsEntityBase2.TransNullToBool_S(objRow[conge_ConnectLookChart.IsAnswer].ToString().Trim()); //是否回答
objge_ConnectLookChartEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[conge_ConnectLookChart.IsSubmit].ToString().Trim()); //是否提交
objge_ConnectLookChartEN.StartTime = objRow[conge_ConnectLookChart.StartTime] == DBNull.Value ? null : objRow[conge_ConnectLookChart.StartTime].ToString().Trim(); //开始时间
objge_ConnectLookChartEN.SubmitTime = objRow[conge_ConnectLookChart.SubmitTime] == DBNull.Value ? null : objRow[conge_ConnectLookChart.SubmitTime].ToString().Trim(); //提交时间
objge_ConnectLookChartEN.UpdUser = objRow[conge_ConnectLookChart.UpdUser] == DBNull.Value ? null : objRow[conge_ConnectLookChart.UpdUser].ToString().Trim(); //修改人
objge_ConnectLookChartEN.UpdDate = objRow[conge_ConnectLookChart.UpdDate] == DBNull.Value ? null : objRow[conge_ConnectLookChart.UpdDate].ToString().Trim(); //修改日期
objge_ConnectLookChartEN.Memo = objRow[conge_ConnectLookChart.Memo] == DBNull.Value ? null : objRow[conge_ConnectLookChart.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objge_ConnectLookChartEN.ConnectLookChartId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objge_ConnectLookChartEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsge_ConnectLookChartEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsge_ConnectLookChartEN> arrObjLst = new List<clsge_ConnectLookChartEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsge_ConnectLookChartEN objge_ConnectLookChartEN = new clsge_ConnectLookChartEN();
try
{
objge_ConnectLookChartEN.ConnectLookChartId = objRow[conge_ConnectLookChart.ConnectLookChartId].ToString().Trim(); //连连看图Id
objge_ConnectLookChartEN.ConnectLookChartName = objRow[conge_ConnectLookChart.ConnectLookChartName] == DBNull.Value ? null : objRow[conge_ConnectLookChart.ConnectLookChartName].ToString().Trim(); //连连看图名
objge_ConnectLookChartEN.CourseId = objRow[conge_ConnectLookChart.CourseId] == DBNull.Value ? null : objRow[conge_ConnectLookChart.CourseId].ToString().Trim(); //课程Id
objge_ConnectLookChartEN.CreateUser = objRow[conge_ConnectLookChart.CreateUser] == DBNull.Value ? null : objRow[conge_ConnectLookChart.CreateUser].ToString().Trim(); //建立用户
objge_ConnectLookChartEN.IsDisplay = clsEntityBase2.TransNullToBool_S(objRow[conge_ConnectLookChart.IsDisplay].ToString().Trim()); //是否显示
objge_ConnectLookChartEN.IsAnswer = clsEntityBase2.TransNullToBool_S(objRow[conge_ConnectLookChart.IsAnswer].ToString().Trim()); //是否回答
objge_ConnectLookChartEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[conge_ConnectLookChart.IsSubmit].ToString().Trim()); //是否提交
objge_ConnectLookChartEN.StartTime = objRow[conge_ConnectLookChart.StartTime] == DBNull.Value ? null : objRow[conge_ConnectLookChart.StartTime].ToString().Trim(); //开始时间
objge_ConnectLookChartEN.SubmitTime = objRow[conge_ConnectLookChart.SubmitTime] == DBNull.Value ? null : objRow[conge_ConnectLookChart.SubmitTime].ToString().Trim(); //提交时间
objge_ConnectLookChartEN.UpdUser = objRow[conge_ConnectLookChart.UpdUser] == DBNull.Value ? null : objRow[conge_ConnectLookChart.UpdUser].ToString().Trim(); //修改人
objge_ConnectLookChartEN.UpdDate = objRow[conge_ConnectLookChart.UpdDate] == DBNull.Value ? null : objRow[conge_ConnectLookChart.UpdDate].ToString().Trim(); //修改日期
objge_ConnectLookChartEN.Memo = objRow[conge_ConnectLookChart.Memo] == DBNull.Value ? null : objRow[conge_ConnectLookChart.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objge_ConnectLookChartEN.ConnectLookChartId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objge_ConnectLookChartEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objge_ConnectLookChartEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool Getge_ConnectLookChart(ref clsge_ConnectLookChartEN objge_ConnectLookChartEN)
{
bool bolResult = ge_ConnectLookChartDA.Getge_ConnectLookChart(ref objge_ConnectLookChartEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "strConnectLookChartId">表关键字</param>
 /// <returns>表对象</returns>
public static clsge_ConnectLookChartEN GetObjByConnectLookChartId(string strConnectLookChartId)
{
if (strConnectLookChartId.IndexOf(' ') >=0)
{
var strMsg = string.Format("(errid:Busi000079)在表中,关键字[strConnectLookChartId]中不能有空格!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
if (string.IsNullOrEmpty(strConnectLookChartId) == true)
{
var strMsg = string.Format("(errid:Busi000020)在表中,关键字[strConnectLookChartId]不能为空!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
clsge_ConnectLookChartEN objge_ConnectLookChartEN = ge_ConnectLookChartDA.GetObjByConnectLookChartId(strConnectLookChartId);
return objge_ConnectLookChartEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsge_ConnectLookChartEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsge_ConnectLookChartEN objge_ConnectLookChartEN = ge_ConnectLookChartDA.GetFirstObj(strWhereCond);
 return objge_ConnectLookChartEN;
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
public static clsge_ConnectLookChartEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsge_ConnectLookChartEN objge_ConnectLookChartEN = ge_ConnectLookChartDA.GetObjByDataRow(objRow);
 return objge_ConnectLookChartEN;
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
public static clsge_ConnectLookChartEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsge_ConnectLookChartEN objge_ConnectLookChartEN = ge_ConnectLookChartDA.GetObjByDataRow(objRow);
 return objge_ConnectLookChartEN;
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
 /// <param name = "strConnectLookChartId">所给的关键字</param>
 /// <param name = "lstge_ConnectLookChartObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsge_ConnectLookChartEN GetObjByConnectLookChartIdFromList(string strConnectLookChartId, List<clsge_ConnectLookChartEN> lstge_ConnectLookChartObjLst)
{
foreach (clsge_ConnectLookChartEN objge_ConnectLookChartEN in lstge_ConnectLookChartObjLst)
{
if (objge_ConnectLookChartEN.ConnectLookChartId == strConnectLookChartId)
{
return objge_ConnectLookChartEN;
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
 string strMaxConnectLookChartId;
 try
 {
 strMaxConnectLookChartId = clsge_ConnectLookChartDA.GetMaxStrId();
 return strMaxConnectLookChartId;
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
 string strConnectLookChartId;
 try
 {
 strConnectLookChartId = new clsge_ConnectLookChartDA().GetFirstID(strWhereCond);
 return strConnectLookChartId;
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
 arrList = ge_ConnectLookChartDA.GetID(strWhereCond);
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
bool bolIsExist = ge_ConnectLookChartDA.IsExistCondRec(strWhereCond);
return bolIsExist;
}

 /// <summary>
 /// 判断当前表中是否存在给定关键字值的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExist)
 /// </summary>
 /// <param name = "strConnectLookChartId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public static bool IsExist(string strConnectLookChartId)
{
if (string.IsNullOrEmpty(strConnectLookChartId) == true)
{
var strMsg = string.Format("(errid:Busi000027)在表中,关键字[strConnectLookChartId]不能为空!!(from {0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
//检测记录是否存在
bool bolIsExist = ge_ConnectLookChartDA.IsExist(strConnectLookChartId);
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
 bolIsExist = clsge_ConnectLookChartDA.IsExistTable();
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
 bolIsExist = ge_ConnectLookChartDA.IsExistTable(strTabName);
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
 /// <param name = "objge_ConnectLookChartEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecordBySql2(clsge_ConnectLookChartEN objge_ConnectLookChartEN, bool bolIsNeedCheckUniqueness=true)
{
if (bolIsNeedCheckUniqueness == true && objge_ConnectLookChartEN.CheckUniqueness() == false)
{
var strMsg = string.Format("记录已经存在!连连看图Id = [{0}]的数据已经存在!(in clsge_ConnectLookChartBL.AddNewRecordBySql2)", objge_ConnectLookChartEN.ConnectLookChartId);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objge_ConnectLookChartEN.ConnectLookChartId) == true || clsge_ConnectLookChartBL.IsExist(objge_ConnectLookChartEN.ConnectLookChartId) == true)
 {
     objge_ConnectLookChartEN.ConnectLookChartId = clsge_ConnectLookChartBL.GetMaxStrId_S();
 }
bool bolResult = ge_ConnectLookChartDA.AddNewRecordBySQL2(objge_ConnectLookChartEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsge_ConnectLookChartBL.ReFreshCache(objge_ConnectLookChartEN.CourseId);

if (clsge_ConnectLookChartBL.relatedActions != null)
{
clsge_ConnectLookChartBL.relatedActions.UpdRelaTabDate(objge_ConnectLookChartEN.ConnectLookChartId, "SetUpdDate");
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
 /// <param name = "objge_ConnectLookChartEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordBySql2WithReturnKey(clsge_ConnectLookChartEN objge_ConnectLookChartEN, bool bolIsNeedCheckUniqueness=true)
{
if (bolIsNeedCheckUniqueness == true && objge_ConnectLookChartEN.CheckUniqueness() == false)
{
var strMsg = string.Format("记录已经存在!连连看图Id = [{0}]的数据已经存在!(in clsge_ConnectLookChartBL.AddNewRecordBySql2WithReturnKey)", objge_ConnectLookChartEN.ConnectLookChartId);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objge_ConnectLookChartEN.ConnectLookChartId) == true || clsge_ConnectLookChartBL.IsExist(objge_ConnectLookChartEN.ConnectLookChartId) == true)
 {
     objge_ConnectLookChartEN.ConnectLookChartId = clsge_ConnectLookChartBL.GetMaxStrId_S();
 }
string strKey = ge_ConnectLookChartDA.AddNewRecordBySQL2WithReturnKey(objge_ConnectLookChartEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsge_ConnectLookChartBL.ReFreshCache(objge_ConnectLookChartEN.CourseId);

if (clsge_ConnectLookChartBL.relatedActions != null)
{
clsge_ConnectLookChartBL.relatedActions.UpdRelaTabDate(objge_ConnectLookChartEN.ConnectLookChartId, "SetUpdDate");
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
 /// <param name = "objge_ConnectLookChartEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(clsge_ConnectLookChartEN objge_ConnectLookChartEN)
{
try
{
bool bolResult = ge_ConnectLookChartDA.Update(objge_ConnectLookChartEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsge_ConnectLookChartBL.ReFreshCache(objge_ConnectLookChartEN.CourseId);

if (clsge_ConnectLookChartBL.relatedActions != null)
{
clsge_ConnectLookChartBL.relatedActions.UpdRelaTabDate(objge_ConnectLookChartEN.ConnectLookChartId, "SetUpdDate");
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
 /// <param name = "objge_ConnectLookChartEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateBySql2(clsge_ConnectLookChartEN objge_ConnectLookChartEN)
{
 if (string.IsNullOrEmpty(objge_ConnectLookChartEN.ConnectLookChartId) == true)
 {
var strMsg = string.Format("(errid:Busi000065)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = ge_ConnectLookChartDA.UpdateBySql2(objge_ConnectLookChartEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsge_ConnectLookChartBL.ReFreshCache(objge_ConnectLookChartEN.CourseId);

if (clsge_ConnectLookChartBL.relatedActions != null)
{
clsge_ConnectLookChartBL.relatedActions.UpdRelaTabDate(objge_ConnectLookChartEN.ConnectLookChartId, "SetUpdDate");
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
 /// <param name = "strConnectLookChartId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int DelRecord(string strConnectLookChartId)
{
try
{
 clsge_ConnectLookChartEN objge_ConnectLookChartEN = clsge_ConnectLookChartBL.GetObjByConnectLookChartId(strConnectLookChartId);

if (clsge_ConnectLookChartBL.relatedActions != null)
{
clsge_ConnectLookChartBL.relatedActions.UpdRelaTabDate(objge_ConnectLookChartEN.ConnectLookChartId, "SetUpdDate");
}
if (objge_ConnectLookChartEN != null)
{
int intRecNum = ge_ConnectLookChartDA.DelRecord(strConnectLookChartId);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
ReFreshCache(objge_ConnectLookChartEN.CourseId);
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
/// <param name="strConnectLookChartId">表关键字</param>
 /// <param name = "strCourseId">缓存的分类字段</param>
/// <returns></returns>
public static bool DelRecordEx(string strConnectLookChartId , string strCourseId)
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsge_ConnectLookChartDA.GetSpecSQLObj();
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
//删除与表:[ge_ConnectLookChart]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conge_ConnectLookChart.ConnectLookChartId,
//strConnectLookChartId);
//        clsge_ConnectLookChartBL.Delge_ConnectLookChartsByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsge_ConnectLookChartBL.DelRecord(strConnectLookChartId, strCourseId, objConnection, objSqlTransaction);
objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsge_ConnectLookChartBLEx", "DelRecordEx", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("扩展删除记录出错:{0}!keyId = {1}.({2})",
objException.Message,
strConnectLookChartId, clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "strConnectLookChartId">给定的关键字值</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回删除是否成功?</returns>
public static bool DelRecord(string strConnectLookChartId, string strCourseId, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
if (clsge_ConnectLookChartBL.relatedActions != null)
{
clsge_ConnectLookChartBL.relatedActions.UpdRelaTabDate(strConnectLookChartId, "UpdRelaTabDate");
}
bool bolResult = ge_ConnectLookChartDA.DelRecord(strConnectLookChartId,objSqlConnection,objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
ReFreshCache(strCourseId);
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
 /// <param name = "arrConnectLookChartIdLst">给定的关键字值列表</param>
 /// <returns>返回删除的记录数</returns>
public static int Delge_ConnectLookCharts(List<string> arrConnectLookChartIdLst)
{
if (arrConnectLookChartIdLst.Count == 0) return 0;
try
{
if (clsge_ConnectLookChartBL.relatedActions != null)
{
foreach (var strConnectLookChartId in arrConnectLookChartIdLst)
{
clsge_ConnectLookChartBL.relatedActions.UpdRelaTabDate(strConnectLookChartId, "UpdRelaTabDate");
}
}
 clsge_ConnectLookChartEN objge_ConnectLookChartEN = clsge_ConnectLookChartBL.GetObjByConnectLookChartId(arrConnectLookChartIdLst[0]);
int intDelRecNum = ge_ConnectLookChartDA.Delge_ConnectLookChart(arrConnectLookChartIdLst);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
ReFreshCache(objge_ConnectLookChartEN.CourseId);
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
public static int Delge_ConnectLookChartsByCond(string strWhereCond)
{
try
{
if (clsge_ConnectLookChartBL.relatedActions != null)
{
List<string> arrConnectLookChartId = GetPrimaryKeyID_S(strWhereCond);
foreach (var strConnectLookChartId in arrConnectLookChartId)
{
clsge_ConnectLookChartBL.relatedActions.UpdRelaTabDate(strConnectLookChartId, "UpdRelaTabDate");
}
}
List<string> arrCourseId = GetFldValue(conge_ConnectLookChart.CourseId, strWhereCond);
int intRecNum = ge_ConnectLookChartDA.Delge_ConnectLookChart(strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
arrCourseId.ForEach(x => ReFreshCache(x));
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
/// 这里仅仅是演示函数,使用时请复制到扩展类:[ge_ConnectLookChart]中改名为:[DelRecord4MultiTabEx]使用
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DelRecord4MultiTab)
/// </summary>
/// <param name="strConnectLookChartId">表关键字</param>
 /// <param name = "strCourseId">缓存的分类字段</param>
/// <returns></returns>
public static bool DelRecord4MultiTab(string strConnectLookChartId, string strCourseId)
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsge_ConnectLookChartDA.GetSpecSQLObj();
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
//删除与表:[ge_ConnectLookChart]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conStudent.id_College,
//strid_College);
//        clsStudentBL.DelStudentsByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsge_ConnectLookChartBL.DelRecord(strConnectLookChartId, strCourseId, objConnection, objSqlTransaction);
                objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsge_ConnectLookChartBL", "DelRecord4MultiTab", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("删除多表记录出错:{0}!keyId = {1}.({2})",
objException.Message,
strConnectLookChartId, clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "objge_ConnectLookChartENS">源对象</param>
 /// <param name = "objge_ConnectLookChartENT">目标对象</param>
 public static void CopyTo(clsge_ConnectLookChartEN objge_ConnectLookChartENS, clsge_ConnectLookChartEN objge_ConnectLookChartENT)
{
try
{
objge_ConnectLookChartENT.ConnectLookChartId = objge_ConnectLookChartENS.ConnectLookChartId; //连连看图Id
objge_ConnectLookChartENT.ConnectLookChartName = objge_ConnectLookChartENS.ConnectLookChartName; //连连看图名
objge_ConnectLookChartENT.CourseId = objge_ConnectLookChartENS.CourseId; //课程Id
objge_ConnectLookChartENT.CreateUser = objge_ConnectLookChartENS.CreateUser; //建立用户
objge_ConnectLookChartENT.IsDisplay = objge_ConnectLookChartENS.IsDisplay; //是否显示
objge_ConnectLookChartENT.IsAnswer = objge_ConnectLookChartENS.IsAnswer; //是否回答
objge_ConnectLookChartENT.IsSubmit = objge_ConnectLookChartENS.IsSubmit; //是否提交
objge_ConnectLookChartENT.StartTime = objge_ConnectLookChartENS.StartTime; //开始时间
objge_ConnectLookChartENT.SubmitTime = objge_ConnectLookChartENS.SubmitTime; //提交时间
objge_ConnectLookChartENT.UpdUser = objge_ConnectLookChartENS.UpdUser; //修改人
objge_ConnectLookChartENT.UpdDate = objge_ConnectLookChartENS.UpdDate; //修改日期
objge_ConnectLookChartENT.Memo = objge_ConnectLookChartENS.Memo; //备注
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
 /// <param name = "objge_ConnectLookChartEN">源简化对象</param>
 public static void SetUpdFlag(clsge_ConnectLookChartEN objge_ConnectLookChartEN)
{
try
{
objge_ConnectLookChartEN.ClearUpdateState();
   string strsfUpdFldSetStr = objge_ConnectLookChartEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(conge_ConnectLookChart.ConnectLookChartId, new clsStrCompareIgnoreCase())  ==  true)
{
objge_ConnectLookChartEN.ConnectLookChartId = objge_ConnectLookChartEN.ConnectLookChartId; //连连看图Id
}
if (arrFldSet.Contains(conge_ConnectLookChart.ConnectLookChartName, new clsStrCompareIgnoreCase())  ==  true)
{
objge_ConnectLookChartEN.ConnectLookChartName = objge_ConnectLookChartEN.ConnectLookChartName == "[null]" ? null :  objge_ConnectLookChartEN.ConnectLookChartName; //连连看图名
}
if (arrFldSet.Contains(conge_ConnectLookChart.CourseId, new clsStrCompareIgnoreCase())  ==  true)
{
objge_ConnectLookChartEN.CourseId = objge_ConnectLookChartEN.CourseId == "[null]" ? null :  objge_ConnectLookChartEN.CourseId; //课程Id
}
if (arrFldSet.Contains(conge_ConnectLookChart.CreateUser, new clsStrCompareIgnoreCase())  ==  true)
{
objge_ConnectLookChartEN.CreateUser = objge_ConnectLookChartEN.CreateUser == "[null]" ? null :  objge_ConnectLookChartEN.CreateUser; //建立用户
}
if (arrFldSet.Contains(conge_ConnectLookChart.IsDisplay, new clsStrCompareIgnoreCase())  ==  true)
{
objge_ConnectLookChartEN.IsDisplay = objge_ConnectLookChartEN.IsDisplay; //是否显示
}
if (arrFldSet.Contains(conge_ConnectLookChart.IsAnswer, new clsStrCompareIgnoreCase())  ==  true)
{
objge_ConnectLookChartEN.IsAnswer = objge_ConnectLookChartEN.IsAnswer; //是否回答
}
if (arrFldSet.Contains(conge_ConnectLookChart.IsSubmit, new clsStrCompareIgnoreCase())  ==  true)
{
objge_ConnectLookChartEN.IsSubmit = objge_ConnectLookChartEN.IsSubmit; //是否提交
}
if (arrFldSet.Contains(conge_ConnectLookChart.StartTime, new clsStrCompareIgnoreCase())  ==  true)
{
objge_ConnectLookChartEN.StartTime = objge_ConnectLookChartEN.StartTime == "[null]" ? null :  objge_ConnectLookChartEN.StartTime; //开始时间
}
if (arrFldSet.Contains(conge_ConnectLookChart.SubmitTime, new clsStrCompareIgnoreCase())  ==  true)
{
objge_ConnectLookChartEN.SubmitTime = objge_ConnectLookChartEN.SubmitTime == "[null]" ? null :  objge_ConnectLookChartEN.SubmitTime; //提交时间
}
if (arrFldSet.Contains(conge_ConnectLookChart.UpdUser, new clsStrCompareIgnoreCase())  ==  true)
{
objge_ConnectLookChartEN.UpdUser = objge_ConnectLookChartEN.UpdUser == "[null]" ? null :  objge_ConnectLookChartEN.UpdUser; //修改人
}
if (arrFldSet.Contains(conge_ConnectLookChart.UpdDate, new clsStrCompareIgnoreCase())  ==  true)
{
objge_ConnectLookChartEN.UpdDate = objge_ConnectLookChartEN.UpdDate == "[null]" ? null :  objge_ConnectLookChartEN.UpdDate; //修改日期
}
if (arrFldSet.Contains(conge_ConnectLookChart.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objge_ConnectLookChartEN.Memo = objge_ConnectLookChartEN.Memo == "[null]" ? null :  objge_ConnectLookChartEN.Memo; //备注
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
 /// <param name = "objge_ConnectLookChartEN">源简化对象</param>
 public static void AccessFldValueNull(clsge_ConnectLookChartEN objge_ConnectLookChartEN)
{
try
{
if (objge_ConnectLookChartEN.ConnectLookChartName == "[null]") objge_ConnectLookChartEN.ConnectLookChartName = null; //连连看图名
if (objge_ConnectLookChartEN.CourseId == "[null]") objge_ConnectLookChartEN.CourseId = null; //课程Id
if (objge_ConnectLookChartEN.CreateUser == "[null]") objge_ConnectLookChartEN.CreateUser = null; //建立用户
if (objge_ConnectLookChartEN.StartTime == "[null]") objge_ConnectLookChartEN.StartTime = null; //开始时间
if (objge_ConnectLookChartEN.SubmitTime == "[null]") objge_ConnectLookChartEN.SubmitTime = null; //提交时间
if (objge_ConnectLookChartEN.UpdUser == "[null]") objge_ConnectLookChartEN.UpdUser = null; //修改人
if (objge_ConnectLookChartEN.UpdDate == "[null]") objge_ConnectLookChartEN.UpdDate = null; //修改日期
if (objge_ConnectLookChartEN.Memo == "[null]") objge_ConnectLookChartEN.Memo = null; //备注
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
public static void CheckPropertyNew(clsge_ConnectLookChartEN objge_ConnectLookChartEN)
{
 ge_ConnectLookChartDA.CheckPropertyNew(objge_ConnectLookChartEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(clsge_ConnectLookChartEN objge_ConnectLookChartEN)
{
 ge_ConnectLookChartDA.CheckProperty4Condition(objge_ConnectLookChartEN);
 }


 #endregion 检查对象属性


 #region 绑定下拉框

 /// <summary>
 /// 绑定基于Win的下拉框
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_TabFeature_ComboBoxBindFunction)
 /// </summary>
 /// <param name = "objComboBox">需要绑定当前表的下拉框</param>

 /// <param name = "strCourseId"></param>
public static void BindCbo_ConnectLookChartId(System.Windows.Forms.ComboBox objComboBox , string strCourseId)
{
//为数据源为表的下拉框设置内容
string strCondition = string.Format("1 =1 Order By {0}", conge_ConnectLookChart.ConnectLookChartId); 
List<clsge_ConnectLookChartEN> arrObjLst = clsge_ConnectLookChartBL.GetObjLst(strCondition);
var arrObjLstSel = arrObjLst.Where(x=>x.CourseId == strCourseId).ToList();
//初始化一个对象列表
//插入第0项。在第0项中插入“请选择...”,为了方便用户,与WEB方式类似。
clsge_ConnectLookChartEN objge_ConnectLookChartEN = new clsge_ConnectLookChartEN()
{
ConnectLookChartId = "0",
ConnectLookChartName = "选[连连看图表]..."
};
arrObjLstSel.Insert(0, objge_ConnectLookChartEN);
//设置下拉框的数据源、以及设置值项、显示项
objComboBox.ValueMember = conge_ConnectLookChart.ConnectLookChartId;
objComboBox.DisplayMember = conge_ConnectLookChart.ConnectLookChartName;
objComboBox.DataSource = arrObjLstSel;
objComboBox.SelectedIndex = 0;
}

 /// <summary>
 /// 绑定基于Web的下拉框
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_TabFeature_DdlBindFunction)
 /// </summary>
 /// <param name = "objDDL">需要绑定当前表的下拉框</param>

 /// <param name = "strCourseId"></param>
public static void BindDdl_ConnectLookChartId(System.Web.UI.WebControls.DropDownList objDDL , string strCourseId)
{
//为数据源于表的下拉框设置内容
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[连连看图表]...","0");
string strCondition = string.Format("1 =1 Order By {0}", conge_ConnectLookChart.ConnectLookChartId); 
IEnumerable<clsge_ConnectLookChartEN> arrObjLst = clsge_ConnectLookChartBL.GetObjLst(strCondition);
var arrObjLstSel = arrObjLst.Where(x=>x.CourseId == strCourseId).ToList();
objDDL.DataValueField = conge_ConnectLookChart.ConnectLookChartId;
objDDL.DataTextField = conge_ConnectLookChart.ConnectLookChartName;
objDDL.DataSource = arrObjLstSel;
objDDL.DataBind();
objDDL.Items.Insert(0, li);
objDDL.SelectedIndex = 0;
}

 /// <summary>
 /// 绑定基于Web的下拉框-使用Cache
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DdlBindFunctionCache)
 /// </summary>
 /// <param name = "objDDL">需要绑定当前表的下拉框</param>
public static void BindDdl_ConnectLookChartIdCache(System.Web.UI.WebControls.DropDownList objDDL, string strCourseId)
{
//为数据源于表的下拉框设置内容
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[连连看图表]...","0");
List<clsge_ConnectLookChartEN> arrge_ConnectLookChartObjLst = GetAllge_ConnectLookChartObjLstCache(strCourseId); 
objDDL.DataValueField = conge_ConnectLookChart.ConnectLookChartId;
objDDL.DataTextField = conge_ConnectLookChart.ConnectLookChartName;
objDDL.DataSource = arrge_ConnectLookChartObjLst;
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
if (clsge_ConnectLookChartBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsge_ConnectLookChartBL没有刷新缓存机制(clsge_ConnectLookChartBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by ConnectLookChartId");
//if (arrge_ConnectLookChartObjLstCache == null)
//{
//arrge_ConnectLookChartObjLstCache = ge_ConnectLookChartDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "strConnectLookChartId">所给的关键字</param>
 /// <param name = "strCourseId">缓存的分类字段</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsge_ConnectLookChartEN GetObjByConnectLookChartIdCache(string strConnectLookChartId, string strCourseId)
{

if (string.IsNullOrEmpty(strCourseId) == true)
{
  var strMsg = string.Format("参数:[strCourseId]不能为空!(In {0})", clsStackTrace.GetCurrClassFunction());
clsSysParaEN.objLog.WriteDebugLog(strMsg);
 throw new Exception (strMsg);
}
if (strCourseId.Length != 8)
{
var strMsg = string.Format("缓存分类变量:[strCourseId]的长度:[{0}]不正确!(In {1})", strCourseId.Length, clsStackTrace.GetCurrClassFunction());
clsSysParaEN.objLog.WriteDebugLog(strMsg);
 throw new Exception (strMsg);
}
//获取缓存中的对象列表
string strKey = string.Format("{0}_{1}", clsge_ConnectLookChartEN._CurrTabName, strCourseId);
List<clsge_ConnectLookChartEN> arrge_ConnectLookChartObjLstCache = GetObjLstCache(strCourseId);
IEnumerable <clsge_ConnectLookChartEN> arrge_ConnectLookChartObjLst_Sel =
arrge_ConnectLookChartObjLstCache
.Where(x=> x.ConnectLookChartId == strConnectLookChartId 
);
if (arrge_ConnectLookChartObjLst_Sel.Count() == 0)
{
   clsge_ConnectLookChartEN obj = clsge_ConnectLookChartBL.GetObjByConnectLookChartId(strConnectLookChartId);
   if (obj != null)
 {
if (obj.CourseId == strCourseId)
{
CacheHelper.Remove(strKey);
     return obj;
}
else
{
string strMsg = string.Format("错误: 关键字:{0}不属于分类:{1},请检查!(In {2})", strConnectLookChartId, strCourseId, clsStackTrace.GetCurrClassFunction());
clsSysParaEN.objLog.WriteDebugLog(strMsg);
throw new Exception(strMsg);
}
 }
return null;
}
return arrge_ConnectLookChartObjLst_Sel.First();
}

 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecNameByKeyCache)
 /// </summary>
 /// <param name = "strConnectLookChartId">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetConnectLookChartNameByConnectLookChartIdCache(string strConnectLookChartId, string strCourseId)
{
if (string.IsNullOrEmpty(strConnectLookChartId) == true) return "";
//获取缓存中的对象列表
clsge_ConnectLookChartEN objge_ConnectLookChart = GetObjByConnectLookChartIdCache(strConnectLookChartId, strCourseId);
if (objge_ConnectLookChart == null) return "";
return objge_ConnectLookChart.ConnectLookChartName;
}
 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecNameByKeyCache)
 /// </summary>
 /// <param name = "strConnectLookChartId">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetNameByConnectLookChartIdCache(string strConnectLookChartId, string strCourseId)
{
if (string.IsNullOrEmpty(strConnectLookChartId) == true) return "";
//获取缓存中的对象列表
clsge_ConnectLookChartEN objge_ConnectLookChart = GetObjByConnectLookChartIdCache(strConnectLookChartId, strCourseId);
if (objge_ConnectLookChart == null) return "";
return objge_ConnectLookChart.ConnectLookChartName;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsge_ConnectLookChartEN> GetAllge_ConnectLookChartObjLstCache(string strCourseId)
{
//获取缓存中的对象列表
List<clsge_ConnectLookChartEN> arrge_ConnectLookChartObjLstCache = GetObjLstCache(strCourseId); 
return arrge_ConnectLookChartObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsge_ConnectLookChartEN> GetObjLstCache(string strCourseId)
{

if (string.IsNullOrEmpty(strCourseId) == true)
{
  var strMsg = string.Format("参数:[strCourseId]不能为空!(In {0})", clsStackTrace.GetCurrClassFunction());
clsSysParaEN.objLog.WriteDebugLog(strMsg);
 throw new Exception (strMsg);
}
if (strCourseId.Length != 8)
{
var strMsg = string.Format("缓存分类变量:[strCourseId]的长度:[{0}]不正确!(In {1})", strCourseId.Length, clsStackTrace.GetCurrClassFunction());
clsSysParaEN.objLog.WriteDebugLog(strMsg);
 throw new Exception (strMsg);
}
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}_{1}", clsge_ConnectLookChartEN._CurrTabName, strCourseId);
string strCondition = string.Format("CourseId='{0}'", strCourseId);
List<clsge_ConnectLookChartEN> arrge_ConnectLookChartObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst(strCondition); });
return arrge_ConnectLookChartObjLstCache;
}

 /// <summary>
 /// 刷新本类中的缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ReFreshThisCache)
 /// </summary>
public static void ReFreshThisCache(string strCourseId = "")
{
string strMsg;
if (clsSysParaEN.spSetRefreshCacheOn == true)
{
string strKey = string.Format("{0}_{1}", clsge_ConnectLookChartEN._CurrTabName, strCourseId);
CacheHelper.Remove(strKey);
clsge_ConnectLookChartEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
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
if (clsge_ConnectLookChartEN._RefreshTimeLst.Count == 0) return "";
return clsge_ConnectLookChartEN._RefreshTimeLst[clsge_ConnectLookChartEN._RefreshTimeLst.Count - 1];
}

 /// <summary>
 /// 刷新缓存.把当前表的缓存以及该表相关视图的缓存清空.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ReFreshCache)
 /// </summary>
public static void ReFreshCache(string strCourseId)
{
if (string.IsNullOrEmpty(strCourseId) == true)
{
string strMsg = string.Format("缓存分类字段:[CourseId]不能为空!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsge_ConnectLookChartBL.objCommFun4BL != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}_{1}", clsge_ConnectLookChartEN._CurrTabName, strCourseId);
CacheHelper.Remove(strKey);
clsge_ConnectLookChartEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
clsge_ConnectLookChartBL.objCommFun4BL.ReFreshCache(strCourseId);
}
}


 #endregion 缓存操作


 #region 检查唯一性

 /// <summary>
 /// 获取检查唯一性条件串(Uniqueness)--ge_ConnectLookChart(连连看图表)
 /// 唯一性条件:ConnectLookChartId
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetUniquenessConditionString)
 /// </summary>
 /// <param name = "objge_ConnectLookChartEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(clsge_ConnectLookChartEN objge_ConnectLookChartEN)
{
//检测记录是否存在
string strResult = ge_ConnectLookChartDA.GetUniCondStr(objge_ConnectLookChartEN);
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
 /// <param name = "strCourseId">缓存的分类字段</param>
 /// <returns>返回一个输出字段值</returns>
public static string Func(string strInFldName, string strOutFldName, string strConnectLookChartId, string strCourseId)
{
if (strInFldName != conge_ConnectLookChart.ConnectLookChartId)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (conge_ConnectLookChart.AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", conge_ConnectLookChart.AttributeName));
throw new Exception(strMsg);
}
var objge_ConnectLookChart = clsge_ConnectLookChartBL.GetObjByConnectLookChartIdCache(strConnectLookChartId, strCourseId);
if (objge_ConnectLookChart == null) return "";
return objge_ConnectLookChart[strOutFldName].ToString();
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
int intRecCount = clsge_ConnectLookChartDA.GetRecCount(strTabName);
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
int intRecCount = clsge_ConnectLookChartDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsge_ConnectLookChartDA.GetRecCount();
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
int intRecCount = clsge_ConnectLookChartDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objge_ConnectLookChartCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsge_ConnectLookChartEN objge_ConnectLookChartCond)
{
 string strCourseId = objge_ConnectLookChartCond.CourseId;
 if (string.IsNullOrEmpty(strCourseId) == true)
{
string strMsg = string.Format("(errid:Busi000174)在表中,缓存分类字段值不能为空!(clsge_ConnectLookChartBL:GetRecCountByCondCache)");
throw new Exception(strMsg);
}
List<clsge_ConnectLookChartEN> arrObjLstCache = GetObjLstCache(strCourseId);
IEnumerable <clsge_ConnectLookChartEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conge_ConnectLookChart.AttributeName)
{
if (objge_ConnectLookChartCond.IsUpdated(strFldName) == false) continue;
if (objge_ConnectLookChartCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objge_ConnectLookChartCond[strFldName].ToString());
}
else
{
if (objge_ConnectLookChartCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objge_ConnectLookChartCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objge_ConnectLookChartCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objge_ConnectLookChartCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objge_ConnectLookChartCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objge_ConnectLookChartCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objge_ConnectLookChartCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objge_ConnectLookChartCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objge_ConnectLookChartCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objge_ConnectLookChartCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objge_ConnectLookChartCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objge_ConnectLookChartCond[strFldName]));
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
 List<string> arrList = clsge_ConnectLookChartDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = ge_ConnectLookChartDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = ge_ConnectLookChartDA.GetFldValueNoDistinct(strFldName, strWhereCond);
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
int intRecCount = ge_ConnectLookChartDA.SetFldValue(strFldName, strValue, strWhereCond);
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
int intRecCount = clsge_ConnectLookChartDA.SetFldValue(clsge_ConnectLookChartEN._CurrTabName, strFldName, fltValue, strWhereCond);
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
int intRecCount = ge_ConnectLookChartDA.SetFldValue( strFldName, intValue, strWhereCond);
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
int intRecCount = clsge_ConnectLookChartDA.SetFldValue(strTabName, strFldName, strValue, strWhereCond);
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
int intRecCount = clsge_ConnectLookChartDA.SetFldValue(strTabName, strFldName, intValue, strWhereCond);
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
int intRecCount = clsge_ConnectLookChartDA.SetFldValue(strTabName, strFldName, fltValue, strWhereCond);
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
  strCreateTabCode.Append("CREATE table [dbo].[ge_ConnectLookChart] "); 
 strCreateTabCode.Append(" ( "); 
 // /**连连看图Id*/ 
 strCreateTabCode.Append(" ConnectLookChartId char(10) primary key, "); 
 // /**连连看图名*/ 
 strCreateTabCode.Append(" ConnectLookChartName varchar(100) Null, "); 
 // /**课程Id*/ 
 strCreateTabCode.Append(" CourseId char(8) Null, "); 
 // /**建立用户*/ 
 strCreateTabCode.Append(" CreateUser varchar(50) Null, "); 
 // /**是否显示*/ 
 strCreateTabCode.Append(" IsDisplay bit Null, "); 
 // /**是否回答*/ 
 strCreateTabCode.Append(" IsAnswer bit Null, "); 
 // /**是否提交*/ 
 strCreateTabCode.Append(" IsSubmit bit Null, "); 
 // /**开始时间*/ 
 strCreateTabCode.Append(" StartTime varchar(20) Null, "); 
 // /**提交时间*/ 
 strCreateTabCode.Append(" SubmitTime varchar(20) Null, "); 
 // /**修改人*/ 
 strCreateTabCode.Append(" UpdUser varchar(20) Null, "); 
 // /**修改日期*/ 
 strCreateTabCode.Append(" UpdDate varchar(20) Null, "); 
 // /**备注*/ 
 strCreateTabCode.Append(" Memo varchar(1000) Null ");
 strCreateTabCode.Append(") "); 
  strCreateTabCode.Append("ON [PRIMARY] ");
  return strCreateTabCode.ToString();
}



 #endregion 表操作
}
 /// <summary>
 /// 连连看图表(ge_ConnectLookChart)
 /// 数据源类型:表
 /// (AutoGCLib.CommFun4BL4CSharp:GeneCode_This)
 /// </summary>
public class  clsCommFun4BL4ge_ConnectLookChart : clsCommFun4BLV2
{

 /// <summary>
 /// 刷新缓存.把当前表的缓存以及该表相关视图的缓存清空.
 /// (AutoGCLib.CommFun4BL4CSharp:Gen_4CFBL_ReFreshCache)
 /// </summary>
public override void ReFreshCache(string strCourseId)
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
clsge_ConnectLookChartBL.ReFreshThisCache(strCourseId);
}
}

}