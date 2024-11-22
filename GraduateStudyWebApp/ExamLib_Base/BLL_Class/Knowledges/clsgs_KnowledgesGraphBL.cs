
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsgs_KnowledgesGraphBL
 表名:gs_KnowledgesGraph(01120873)
 * 版本:2024.11.13.1(服务器:WIN-SRV103-116)
 日期:2024/11/13 06:07:46
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
public static class  clsgs_KnowledgesGraphBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "strKnowledgeGraphId">表关键字</param>
 /// <returns>表对象</returns>
public static clsgs_KnowledgesGraphEN GetObj(this K_KnowledgeGraphId_gs_KnowledgesGraph myKey)
{
clsgs_KnowledgesGraphEN objgs_KnowledgesGraphEN = clsgs_KnowledgesGraphBL.gs_KnowledgesGraphDA.GetObjByKnowledgeGraphId(myKey.Value);
return objgs_KnowledgesGraphEN;
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_AddNewRecord)
 /// </summary>
 /// <param name = "objgs_KnowledgesGraphEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clsgs_KnowledgesGraphEN objgs_KnowledgesGraphEN, bool bolIsNeedCheckUniqueness = true)
{
if (bolIsNeedCheckUniqueness == true && CheckUniqueness(objgs_KnowledgesGraphEN) == false)
{
var strMsg = string.Format("记录已经存在!连连看图名 = [{0}],课程Id = [{1}],建立用户 = [{2}]的数据已经存在!(in clsgs_KnowledgesGraphBL.AddNewRecord)", objgs_KnowledgesGraphEN.KnowledgeGraphName,objgs_KnowledgesGraphEN.CourseId,objgs_KnowledgesGraphEN.CreateUser);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objgs_KnowledgesGraphEN.KnowledgeGraphId) == true || clsgs_KnowledgesGraphBL.IsExist(objgs_KnowledgesGraphEN.KnowledgeGraphId) == true)
 {
     objgs_KnowledgesGraphEN.KnowledgeGraphId = clsgs_KnowledgesGraphBL.GetMaxStrId_S();
 }
bool bolResult = clsgs_KnowledgesGraphBL.gs_KnowledgesGraphDA.AddNewRecordBySQL2(objgs_KnowledgesGraphEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsgs_KnowledgesGraphBL.ReFreshCache(objgs_KnowledgesGraphEN.CourseId);

if (clsgs_KnowledgesGraphBL.relatedActions != null)
{
clsgs_KnowledgesGraphBL.relatedActions.UpdRelaTabDate(objgs_KnowledgesGraphEN.KnowledgeGraphId, "SetUpdDate");
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
public static bool AddRecordEx(this clsgs_KnowledgesGraphEN objgs_KnowledgesGraphEN, bool bolIsNeedCheckUniqueness = true)
{
//操作步骤:
//1、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在
//2、检查唯一性
//3、检查传进去的对象属性是否合法
//4、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
//1、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在

//因为是字符型自增主键,不需要检查主键是否已经存在,在添加时,再获取 最大值作为主键
//if (clsgs_KnowledgesGraphBL.IsExist(objgs_KnowledgesGraphEN.KnowledgeGraphId))	//判断是否有相同的关键字
//{
//strMsg = "(errid:Busi000151)关键字字段已有相同的值";
//throw new Exception(strMsg);
//}
try
{
 //2、检查传进去的对象属性是否合法
objgs_KnowledgesGraphEN.CheckPropertyNew();
 ///5.2、检查唯一性
if (bolIsNeedCheckUniqueness == true && objgs_KnowledgesGraphEN.CheckUniqueness() == false)
{
strMsg = string.Format("(连连看图名(KnowledgeGraphName)=[{0}],课程Id(CourseId)=[{1}],建立用户(CreateUser)=[{2}])已经存在,不能重复!", objgs_KnowledgesGraphEN.KnowledgeGraphName, objgs_KnowledgesGraphEN.CourseId, objgs_KnowledgesGraphEN.CreateUser);
throw new Exception(strMsg);
}
//因为是字符型自增主键,所以在添加时,自动获取主键值。
 if (string.IsNullOrEmpty(objgs_KnowledgesGraphEN.KnowledgeGraphId) == true || clsgs_KnowledgesGraphBL.IsExist(objgs_KnowledgesGraphEN.KnowledgeGraphId) == true)
 {
     objgs_KnowledgesGraphEN.KnowledgeGraphId = clsgs_KnowledgesGraphBL.GetMaxStrId_S();
 }
//6、把数据实体层的数据存贮到数据库中
objgs_KnowledgesGraphEN.AddNewRecord();
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
 /// <param name = "objgs_KnowledgesGraphEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static string AddNewRecordWithMaxId(this clsgs_KnowledgesGraphEN objgs_KnowledgesGraphEN, bool bolIsNeedCheckUniqueness = true)
{
if (bolIsNeedCheckUniqueness == true && CheckUniqueness(objgs_KnowledgesGraphEN) == false)
{
var strMsg = string.Format("记录已经存在!连连看图名 = [{0}],课程Id = [{1}],建立用户 = [{2}]的数据已经存在!(in clsgs_KnowledgesGraphBL.AddNewRecordWithMaxId)", objgs_KnowledgesGraphEN.KnowledgeGraphName,objgs_KnowledgesGraphEN.CourseId,objgs_KnowledgesGraphEN.CreateUser);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objgs_KnowledgesGraphEN.KnowledgeGraphId) == true || clsgs_KnowledgesGraphBL.IsExist(objgs_KnowledgesGraphEN.KnowledgeGraphId) == true)
 {
     objgs_KnowledgesGraphEN.KnowledgeGraphId = clsgs_KnowledgesGraphBL.GetMaxStrId_S();
 }
string strKnowledgeGraphId = clsgs_KnowledgesGraphBL.gs_KnowledgesGraphDA.AddNewRecordBySQL2WithReturnKey(objgs_KnowledgesGraphEN);
     objgs_KnowledgesGraphEN.KnowledgeGraphId = strKnowledgeGraphId;
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsgs_KnowledgesGraphBL.ReFreshCache(objgs_KnowledgesGraphEN.CourseId);

if (clsgs_KnowledgesGraphBL.relatedActions != null)
{
clsgs_KnowledgesGraphBL.relatedActions.UpdRelaTabDate(objgs_KnowledgesGraphEN.KnowledgeGraphId, "SetUpdDate");
}
return strKnowledgeGraphId;
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
 /// <param name = "objgs_KnowledgesGraphEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordWithReturnKey(this clsgs_KnowledgesGraphEN objgs_KnowledgesGraphEN, bool bolIsNeedCheckUniqueness = true)
{
if (bolIsNeedCheckUniqueness == true && CheckUniqueness(objgs_KnowledgesGraphEN) == false)
{
var strMsg = string.Format("记录已经存在!连连看图名 = [{0}],课程Id = [{1}],建立用户 = [{2}]的数据已经存在!(in clsgs_KnowledgesGraphBL.AddNewRecordWithReturnKey)", objgs_KnowledgesGraphEN.KnowledgeGraphName,objgs_KnowledgesGraphEN.CourseId,objgs_KnowledgesGraphEN.CreateUser);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objgs_KnowledgesGraphEN.KnowledgeGraphId) == true || clsgs_KnowledgesGraphBL.IsExist(objgs_KnowledgesGraphEN.KnowledgeGraphId) == true)
 {
     objgs_KnowledgesGraphEN.KnowledgeGraphId = clsgs_KnowledgesGraphBL.GetMaxStrId_S();
 }
string strKey = clsgs_KnowledgesGraphBL.gs_KnowledgesGraphDA.AddNewRecordBySQL2WithReturnKey(objgs_KnowledgesGraphEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsgs_KnowledgesGraphBL.ReFreshCache(objgs_KnowledgesGraphEN.CourseId);

if (clsgs_KnowledgesGraphBL.relatedActions != null)
{
clsgs_KnowledgesGraphBL.relatedActions.UpdRelaTabDate(objgs_KnowledgesGraphEN.KnowledgeGraphId, "SetUpdDate");
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
 /// <param name = "objgs_KnowledgesGraphEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsgs_KnowledgesGraphEN SetKnowledgeGraphId(this clsgs_KnowledgesGraphEN objgs_KnowledgesGraphEN, string strKnowledgeGraphId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strKnowledgeGraphId, 10, congs_KnowledgesGraph.KnowledgeGraphId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strKnowledgeGraphId, 10, congs_KnowledgesGraph.KnowledgeGraphId);
}
objgs_KnowledgesGraphEN.KnowledgeGraphId = strKnowledgeGraphId; //知识点图Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objgs_KnowledgesGraphEN.dicFldComparisonOp.ContainsKey(congs_KnowledgesGraph.KnowledgeGraphId) == false)
{
objgs_KnowledgesGraphEN.dicFldComparisonOp.Add(congs_KnowledgesGraph.KnowledgeGraphId, strComparisonOp);
}
else
{
objgs_KnowledgesGraphEN.dicFldComparisonOp[congs_KnowledgesGraph.KnowledgeGraphId] = strComparisonOp;
}
}
return objgs_KnowledgesGraphEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objgs_KnowledgesGraphEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsgs_KnowledgesGraphEN SetKnowledgeGraphName(this clsgs_KnowledgesGraphEN objgs_KnowledgesGraphEN, string strKnowledgeGraphName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strKnowledgeGraphName, 100, congs_KnowledgesGraph.KnowledgeGraphName);
}
objgs_KnowledgesGraphEN.KnowledgeGraphName = strKnowledgeGraphName; //连连看图名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objgs_KnowledgesGraphEN.dicFldComparisonOp.ContainsKey(congs_KnowledgesGraph.KnowledgeGraphName) == false)
{
objgs_KnowledgesGraphEN.dicFldComparisonOp.Add(congs_KnowledgesGraph.KnowledgeGraphName, strComparisonOp);
}
else
{
objgs_KnowledgesGraphEN.dicFldComparisonOp[congs_KnowledgesGraph.KnowledgeGraphName] = strComparisonOp;
}
}
return objgs_KnowledgesGraphEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objgs_KnowledgesGraphEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsgs_KnowledgesGraphEN SetIdCurrEduCls(this clsgs_KnowledgesGraphEN objgs_KnowledgesGraphEN, string strIdCurrEduCls, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdCurrEduCls, 8, congs_KnowledgesGraph.IdCurrEduCls);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdCurrEduCls, 8, congs_KnowledgesGraph.IdCurrEduCls);
}
objgs_KnowledgesGraphEN.IdCurrEduCls = strIdCurrEduCls; //教学班流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objgs_KnowledgesGraphEN.dicFldComparisonOp.ContainsKey(congs_KnowledgesGraph.IdCurrEduCls) == false)
{
objgs_KnowledgesGraphEN.dicFldComparisonOp.Add(congs_KnowledgesGraph.IdCurrEduCls, strComparisonOp);
}
else
{
objgs_KnowledgesGraphEN.dicFldComparisonOp[congs_KnowledgesGraph.IdCurrEduCls] = strComparisonOp;
}
}
return objgs_KnowledgesGraphEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objgs_KnowledgesGraphEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsgs_KnowledgesGraphEN SetCourseId(this clsgs_KnowledgesGraphEN objgs_KnowledgesGraphEN, string strCourseId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCourseId, 8, congs_KnowledgesGraph.CourseId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strCourseId, 8, congs_KnowledgesGraph.CourseId);
}
objgs_KnowledgesGraphEN.CourseId = strCourseId; //课程Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objgs_KnowledgesGraphEN.dicFldComparisonOp.ContainsKey(congs_KnowledgesGraph.CourseId) == false)
{
objgs_KnowledgesGraphEN.dicFldComparisonOp.Add(congs_KnowledgesGraph.CourseId, strComparisonOp);
}
else
{
objgs_KnowledgesGraphEN.dicFldComparisonOp[congs_KnowledgesGraph.CourseId] = strComparisonOp;
}
}
return objgs_KnowledgesGraphEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objgs_KnowledgesGraphEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsgs_KnowledgesGraphEN SetCreateUser(this clsgs_KnowledgesGraphEN objgs_KnowledgesGraphEN, string strCreateUser, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCreateUser, 50, congs_KnowledgesGraph.CreateUser);
}
objgs_KnowledgesGraphEN.CreateUser = strCreateUser; //建立用户
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objgs_KnowledgesGraphEN.dicFldComparisonOp.ContainsKey(congs_KnowledgesGraph.CreateUser) == false)
{
objgs_KnowledgesGraphEN.dicFldComparisonOp.Add(congs_KnowledgesGraph.CreateUser, strComparisonOp);
}
else
{
objgs_KnowledgesGraphEN.dicFldComparisonOp[congs_KnowledgesGraph.CreateUser] = strComparisonOp;
}
}
return objgs_KnowledgesGraphEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objgs_KnowledgesGraphEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsgs_KnowledgesGraphEN SetUpdDate(this clsgs_KnowledgesGraphEN objgs_KnowledgesGraphEN, string strUpdDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdDate, 20, congs_KnowledgesGraph.UpdDate);
}
objgs_KnowledgesGraphEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objgs_KnowledgesGraphEN.dicFldComparisonOp.ContainsKey(congs_KnowledgesGraph.UpdDate) == false)
{
objgs_KnowledgesGraphEN.dicFldComparisonOp.Add(congs_KnowledgesGraph.UpdDate, strComparisonOp);
}
else
{
objgs_KnowledgesGraphEN.dicFldComparisonOp[congs_KnowledgesGraph.UpdDate] = strComparisonOp;
}
}
return objgs_KnowledgesGraphEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objgs_KnowledgesGraphEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsgs_KnowledgesGraphEN SetUpdUser(this clsgs_KnowledgesGraphEN objgs_KnowledgesGraphEN, string strUpdUser, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdUser, 20, congs_KnowledgesGraph.UpdUser);
}
objgs_KnowledgesGraphEN.UpdUser = strUpdUser; //修改人
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objgs_KnowledgesGraphEN.dicFldComparisonOp.ContainsKey(congs_KnowledgesGraph.UpdUser) == false)
{
objgs_KnowledgesGraphEN.dicFldComparisonOp.Add(congs_KnowledgesGraph.UpdUser, strComparisonOp);
}
else
{
objgs_KnowledgesGraphEN.dicFldComparisonOp[congs_KnowledgesGraph.UpdUser] = strComparisonOp;
}
}
return objgs_KnowledgesGraphEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objgs_KnowledgesGraphEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsgs_KnowledgesGraphEN SetMemo(this clsgs_KnowledgesGraphEN objgs_KnowledgesGraphEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, congs_KnowledgesGraph.Memo);
}
objgs_KnowledgesGraphEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objgs_KnowledgesGraphEN.dicFldComparisonOp.ContainsKey(congs_KnowledgesGraph.Memo) == false)
{
objgs_KnowledgesGraphEN.dicFldComparisonOp.Add(congs_KnowledgesGraph.Memo, strComparisonOp);
}
else
{
objgs_KnowledgesGraphEN.dicFldComparisonOp[congs_KnowledgesGraph.Memo] = strComparisonOp;
}
}
return objgs_KnowledgesGraphEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objgs_KnowledgesGraphEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsgs_KnowledgesGraphEN SetGraphTypeId(this clsgs_KnowledgesGraphEN objgs_KnowledgesGraphEN, string strGraphTypeId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strGraphTypeId, 2, congs_KnowledgesGraph.GraphTypeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strGraphTypeId, 2, congs_KnowledgesGraph.GraphTypeId);
}
objgs_KnowledgesGraphEN.GraphTypeId = strGraphTypeId; //图谱类型Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objgs_KnowledgesGraphEN.dicFldComparisonOp.ContainsKey(congs_KnowledgesGraph.GraphTypeId) == false)
{
objgs_KnowledgesGraphEN.dicFldComparisonOp.Add(congs_KnowledgesGraph.GraphTypeId, strComparisonOp);
}
else
{
objgs_KnowledgesGraphEN.dicFldComparisonOp[congs_KnowledgesGraph.GraphTypeId] = strComparisonOp;
}
}
return objgs_KnowledgesGraphEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objgs_KnowledgesGraphEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsgs_KnowledgesGraphEN SetIsDisplay(this clsgs_KnowledgesGraphEN objgs_KnowledgesGraphEN, bool bolIsDisplay, string strComparisonOp="")
	{
objgs_KnowledgesGraphEN.IsDisplay = bolIsDisplay; //是否显示
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objgs_KnowledgesGraphEN.dicFldComparisonOp.ContainsKey(congs_KnowledgesGraph.IsDisplay) == false)
{
objgs_KnowledgesGraphEN.dicFldComparisonOp.Add(congs_KnowledgesGraph.IsDisplay, strComparisonOp);
}
else
{
objgs_KnowledgesGraphEN.dicFldComparisonOp[congs_KnowledgesGraph.IsDisplay] = strComparisonOp;
}
}
return objgs_KnowledgesGraphEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objgs_KnowledgesGraphEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsgs_KnowledgesGraphEN SetIsExtend(this clsgs_KnowledgesGraphEN objgs_KnowledgesGraphEN, bool bolIsExtend, string strComparisonOp="")
	{
objgs_KnowledgesGraphEN.IsExtend = bolIsExtend; //是否扩展
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objgs_KnowledgesGraphEN.dicFldComparisonOp.ContainsKey(congs_KnowledgesGraph.IsExtend) == false)
{
objgs_KnowledgesGraphEN.dicFldComparisonOp.Add(congs_KnowledgesGraph.IsExtend, strComparisonOp);
}
else
{
objgs_KnowledgesGraphEN.dicFldComparisonOp[congs_KnowledgesGraph.IsExtend] = strComparisonOp;
}
}
return objgs_KnowledgesGraphEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objgs_KnowledgesGraphEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsgs_KnowledgesGraphEN SetIsRecommend(this clsgs_KnowledgesGraphEN objgs_KnowledgesGraphEN, bool bolIsRecommend, string strComparisonOp="")
	{
objgs_KnowledgesGraphEN.IsRecommend = bolIsRecommend; //是否推荐
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objgs_KnowledgesGraphEN.dicFldComparisonOp.ContainsKey(congs_KnowledgesGraph.IsRecommend) == false)
{
objgs_KnowledgesGraphEN.dicFldComparisonOp.Add(congs_KnowledgesGraph.IsRecommend, strComparisonOp);
}
else
{
objgs_KnowledgesGraphEN.dicFldComparisonOp[congs_KnowledgesGraph.IsRecommend] = strComparisonOp;
}
}
return objgs_KnowledgesGraphEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objgs_KnowledgesGraphEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsgs_KnowledgesGraphEN SetIsAnswer(this clsgs_KnowledgesGraphEN objgs_KnowledgesGraphEN, bool bolIsAnswer, string strComparisonOp="")
	{
objgs_KnowledgesGraphEN.IsAnswer = bolIsAnswer; //是否回答
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objgs_KnowledgesGraphEN.dicFldComparisonOp.ContainsKey(congs_KnowledgesGraph.IsAnswer) == false)
{
objgs_KnowledgesGraphEN.dicFldComparisonOp.Add(congs_KnowledgesGraph.IsAnswer, strComparisonOp);
}
else
{
objgs_KnowledgesGraphEN.dicFldComparisonOp[congs_KnowledgesGraph.IsAnswer] = strComparisonOp;
}
}
return objgs_KnowledgesGraphEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objgs_KnowledgesGraphEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsgs_KnowledgesGraphEN SetIsSubmit(this clsgs_KnowledgesGraphEN objgs_KnowledgesGraphEN, bool bolIsSubmit, string strComparisonOp="")
	{
objgs_KnowledgesGraphEN.IsSubmit = bolIsSubmit; //是否提交
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objgs_KnowledgesGraphEN.dicFldComparisonOp.ContainsKey(congs_KnowledgesGraph.IsSubmit) == false)
{
objgs_KnowledgesGraphEN.dicFldComparisonOp.Add(congs_KnowledgesGraph.IsSubmit, strComparisonOp);
}
else
{
objgs_KnowledgesGraphEN.dicFldComparisonOp[congs_KnowledgesGraph.IsSubmit] = strComparisonOp;
}
}
return objgs_KnowledgesGraphEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objgs_KnowledgesGraphEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsgs_KnowledgesGraphEN SetStartTime(this clsgs_KnowledgesGraphEN objgs_KnowledgesGraphEN, string strStartTime, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strStartTime, 20, congs_KnowledgesGraph.StartTime);
}
objgs_KnowledgesGraphEN.StartTime = strStartTime; //开始时间
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objgs_KnowledgesGraphEN.dicFldComparisonOp.ContainsKey(congs_KnowledgesGraph.StartTime) == false)
{
objgs_KnowledgesGraphEN.dicFldComparisonOp.Add(congs_KnowledgesGraph.StartTime, strComparisonOp);
}
else
{
objgs_KnowledgesGraphEN.dicFldComparisonOp[congs_KnowledgesGraph.StartTime] = strComparisonOp;
}
}
return objgs_KnowledgesGraphEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objgs_KnowledgesGraphEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsgs_KnowledgesGraphEN SetSubmitTime(this clsgs_KnowledgesGraphEN objgs_KnowledgesGraphEN, string strSubmitTime, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strSubmitTime, 20, congs_KnowledgesGraph.SubmitTime);
}
objgs_KnowledgesGraphEN.SubmitTime = strSubmitTime; //提交时间
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objgs_KnowledgesGraphEN.dicFldComparisonOp.ContainsKey(congs_KnowledgesGraph.SubmitTime) == false)
{
objgs_KnowledgesGraphEN.dicFldComparisonOp.Add(congs_KnowledgesGraph.SubmitTime, strComparisonOp);
}
else
{
objgs_KnowledgesGraphEN.dicFldComparisonOp[congs_KnowledgesGraph.SubmitTime] = strComparisonOp;
}
}
return objgs_KnowledgesGraphEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objgs_KnowledgesGraphEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsgs_KnowledgesGraphEN SetTakeUpTime(this clsgs_KnowledgesGraphEN objgs_KnowledgesGraphEN, string strTakeUpTime, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTakeUpTime, 50, congs_KnowledgesGraph.TakeUpTime);
}
objgs_KnowledgesGraphEN.TakeUpTime = strTakeUpTime; //耗时
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objgs_KnowledgesGraphEN.dicFldComparisonOp.ContainsKey(congs_KnowledgesGraph.TakeUpTime) == false)
{
objgs_KnowledgesGraphEN.dicFldComparisonOp.Add(congs_KnowledgesGraph.TakeUpTime, strComparisonOp);
}
else
{
objgs_KnowledgesGraphEN.dicFldComparisonOp[congs_KnowledgesGraph.TakeUpTime] = strComparisonOp;
}
}
return objgs_KnowledgesGraphEN;
	}

 /// <summary>
 /// 修改记录存盘到数据表中
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_UpdateRecordEx)
 /// </summary>
 /// <param name = "objgs_KnowledgesGraphEN">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool UpdateRecordEx(this clsgs_KnowledgesGraphEN objgs_KnowledgesGraphEN)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
try
{
//1、检查传进去的对象属性是否合法
objgs_KnowledgesGraphEN.CheckPropertyNew();
clsgs_KnowledgesGraphEN objgs_KnowledgesGraphCond = new clsgs_KnowledgesGraphEN();
string strCondition = objgs_KnowledgesGraphCond
.SetKnowledgeGraphId(objgs_KnowledgesGraphEN.KnowledgeGraphId, "<>")
.SetKnowledgeGraphName(objgs_KnowledgesGraphEN.KnowledgeGraphName, "=")
.SetCourseId(objgs_KnowledgesGraphEN.CourseId, "=")
.SetCreateUser(objgs_KnowledgesGraphEN.CreateUser, "=")
.GetCombineCondition();
objgs_KnowledgesGraphEN._IsCheckProperty = true;
bool bolIsExist = clsgs_KnowledgesGraphBL.IsExistRecord(strCondition);
if (bolIsExist)
{
strMsg = "(KnowledgeGraphName_CourseId_CreateUser)不能重复!";
throw new Exception(strMsg);
}
//4、把数据实体层的数据存贮到数据库中
objgs_KnowledgesGraphEN.Update();
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
 /// <param name = "objgs_KnowledgesGraph">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool EditRecordEx(this clsgs_KnowledgesGraphEN objgs_KnowledgesGraph)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
clsgs_KnowledgesGraphEN objgs_KnowledgesGraphCond = new clsgs_KnowledgesGraphEN();
string strCondition = objgs_KnowledgesGraphCond
.SetKnowledgeGraphName(objgs_KnowledgesGraph.KnowledgeGraphName, "=")
.SetCourseId(objgs_KnowledgesGraph.CourseId, "=")
.SetCreateUser(objgs_KnowledgesGraph.CreateUser, "=")
.GetCombineCondition();
objgs_KnowledgesGraph._IsCheckProperty = true;
bool bolIsExist = clsgs_KnowledgesGraphBL.IsExistRecord(strCondition);
if (bolIsExist)
{
objgs_KnowledgesGraph.KnowledgeGraphId = clsgs_KnowledgesGraphBL.GetFirstID_S(strCondition);
objgs_KnowledgesGraph.UpdateWithCondition(strCondition);
}
else
{
objgs_KnowledgesGraph.KnowledgeGraphId = clsgs_KnowledgesGraphBL.GetMaxStrId_S();
objgs_KnowledgesGraph.AddNewRecord();
}
return true; 
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_Update)
 /// </summary>
 /// <param name = "objgs_KnowledgesGraphEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsgs_KnowledgesGraphEN objgs_KnowledgesGraphEN)
{
 if (string.IsNullOrEmpty(objgs_KnowledgesGraphEN.KnowledgeGraphId) == true)
 {
string strMsg = string.Format("(errid:Busi000095)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsgs_KnowledgesGraphBL.gs_KnowledgesGraphDA.UpdateBySql2(objgs_KnowledgesGraphEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsgs_KnowledgesGraphBL.ReFreshCache(objgs_KnowledgesGraphEN.CourseId);

if (clsgs_KnowledgesGraphBL.relatedActions != null)
{
clsgs_KnowledgesGraphBL.relatedActions.UpdRelaTabDate(objgs_KnowledgesGraphEN.KnowledgeGraphId, "SetUpdDate");
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
 /// <param name = "objgs_KnowledgesGraphEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsgs_KnowledgesGraphEN objgs_KnowledgesGraphEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (string.IsNullOrEmpty(objgs_KnowledgesGraphEN.KnowledgeGraphId) == true)
 {
string strMsg = string.Format("(errid:Busi000087)修改记录时关键字不能为空!(带事务处理)(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsgs_KnowledgesGraphBL.gs_KnowledgesGraphDA.UpdateBySql2(objgs_KnowledgesGraphEN, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsgs_KnowledgesGraphBL.ReFreshCache(objgs_KnowledgesGraphEN.CourseId);

if (clsgs_KnowledgesGraphBL.relatedActions != null)
{
clsgs_KnowledgesGraphBL.relatedActions.UpdRelaTabDate(objgs_KnowledgesGraphEN.KnowledgeGraphId, "SetUpdDate");
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
 /// <param name = "objgs_KnowledgesGraphEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsgs_KnowledgesGraphEN objgs_KnowledgesGraphEN, string strWhereCond)
{
try
{
bool bolResult = clsgs_KnowledgesGraphBL.gs_KnowledgesGraphDA.UpdateBySqlWithCondition(objgs_KnowledgesGraphEN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsgs_KnowledgesGraphBL.ReFreshCache(objgs_KnowledgesGraphEN.CourseId);

if (clsgs_KnowledgesGraphBL.relatedActions != null)
{
clsgs_KnowledgesGraphBL.relatedActions.UpdRelaTabDate(objgs_KnowledgesGraphEN.KnowledgeGraphId, "SetUpdDate");
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
 /// <param name = "objgs_KnowledgesGraphEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsgs_KnowledgesGraphEN objgs_KnowledgesGraphEN, string strWhereCond, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
bool bolResult = clsgs_KnowledgesGraphBL.gs_KnowledgesGraphDA.UpdateBySqlWithConditionTransaction(objgs_KnowledgesGraphEN, strWhereCond, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsgs_KnowledgesGraphBL.ReFreshCache(objgs_KnowledgesGraphEN.CourseId);

if (clsgs_KnowledgesGraphBL.relatedActions != null)
{
clsgs_KnowledgesGraphBL.relatedActions.UpdRelaTabDate(objgs_KnowledgesGraphEN.KnowledgeGraphId, "SetUpdDate");
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
 /// <param name = "strKnowledgeGraphId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int Delete(this clsgs_KnowledgesGraphEN objgs_KnowledgesGraphEN)
{
try
{
int intRecNum = clsgs_KnowledgesGraphBL.gs_KnowledgesGraphDA.DelRecord(objgs_KnowledgesGraphEN.KnowledgeGraphId);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsgs_KnowledgesGraphBL.ReFreshCache(objgs_KnowledgesGraphEN.CourseId);

if (clsgs_KnowledgesGraphBL.relatedActions != null)
{
clsgs_KnowledgesGraphBL.relatedActions.UpdRelaTabDate(objgs_KnowledgesGraphEN.KnowledgeGraphId, "SetUpdDate");
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
 /// <param name = "objgs_KnowledgesGraphENS">源对象</param>
 /// <param name = "objgs_KnowledgesGraphENT">目标对象</param>
 public static void CopyTo(this clsgs_KnowledgesGraphEN objgs_KnowledgesGraphENS, clsgs_KnowledgesGraphEN objgs_KnowledgesGraphENT)
{
try
{
objgs_KnowledgesGraphENT.KnowledgeGraphId = objgs_KnowledgesGraphENS.KnowledgeGraphId; //知识点图Id
objgs_KnowledgesGraphENT.KnowledgeGraphName = objgs_KnowledgesGraphENS.KnowledgeGraphName; //连连看图名
objgs_KnowledgesGraphENT.IdCurrEduCls = objgs_KnowledgesGraphENS.IdCurrEduCls; //教学班流水号
objgs_KnowledgesGraphENT.CourseId = objgs_KnowledgesGraphENS.CourseId; //课程Id
objgs_KnowledgesGraphENT.CreateUser = objgs_KnowledgesGraphENS.CreateUser; //建立用户
objgs_KnowledgesGraphENT.UpdDate = objgs_KnowledgesGraphENS.UpdDate; //修改日期
objgs_KnowledgesGraphENT.UpdUser = objgs_KnowledgesGraphENS.UpdUser; //修改人
objgs_KnowledgesGraphENT.Memo = objgs_KnowledgesGraphENS.Memo; //备注
objgs_KnowledgesGraphENT.GraphTypeId = objgs_KnowledgesGraphENS.GraphTypeId; //图谱类型Id
objgs_KnowledgesGraphENT.IsDisplay = objgs_KnowledgesGraphENS.IsDisplay; //是否显示
objgs_KnowledgesGraphENT.IsExtend = objgs_KnowledgesGraphENS.IsExtend; //是否扩展
objgs_KnowledgesGraphENT.IsRecommend = objgs_KnowledgesGraphENS.IsRecommend; //是否推荐
objgs_KnowledgesGraphENT.IsAnswer = objgs_KnowledgesGraphENS.IsAnswer; //是否回答
objgs_KnowledgesGraphENT.IsSubmit = objgs_KnowledgesGraphENS.IsSubmit; //是否提交
objgs_KnowledgesGraphENT.StartTime = objgs_KnowledgesGraphENS.StartTime; //开始时间
objgs_KnowledgesGraphENT.SubmitTime = objgs_KnowledgesGraphENS.SubmitTime; //提交时间
objgs_KnowledgesGraphENT.TakeUpTime = objgs_KnowledgesGraphENS.TakeUpTime; //耗时
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
 /// <param name = "objgs_KnowledgesGraphENS">源对象</param>
 /// <returns>目标对象=>clsgs_KnowledgesGraphEN:objgs_KnowledgesGraphENT</returns>
 public static clsgs_KnowledgesGraphEN CopyTo(this clsgs_KnowledgesGraphEN objgs_KnowledgesGraphENS)
{
try
{
 clsgs_KnowledgesGraphEN objgs_KnowledgesGraphENT = new clsgs_KnowledgesGraphEN()
{
KnowledgeGraphId = objgs_KnowledgesGraphENS.KnowledgeGraphId, //知识点图Id
KnowledgeGraphName = objgs_KnowledgesGraphENS.KnowledgeGraphName, //连连看图名
IdCurrEduCls = objgs_KnowledgesGraphENS.IdCurrEduCls, //教学班流水号
CourseId = objgs_KnowledgesGraphENS.CourseId, //课程Id
CreateUser = objgs_KnowledgesGraphENS.CreateUser, //建立用户
UpdDate = objgs_KnowledgesGraphENS.UpdDate, //修改日期
UpdUser = objgs_KnowledgesGraphENS.UpdUser, //修改人
Memo = objgs_KnowledgesGraphENS.Memo, //备注
GraphTypeId = objgs_KnowledgesGraphENS.GraphTypeId, //图谱类型Id
IsDisplay = objgs_KnowledgesGraphENS.IsDisplay, //是否显示
IsExtend = objgs_KnowledgesGraphENS.IsExtend, //是否扩展
IsRecommend = objgs_KnowledgesGraphENS.IsRecommend, //是否推荐
IsAnswer = objgs_KnowledgesGraphENS.IsAnswer, //是否回答
IsSubmit = objgs_KnowledgesGraphENS.IsSubmit, //是否提交
StartTime = objgs_KnowledgesGraphENS.StartTime, //开始时间
SubmitTime = objgs_KnowledgesGraphENS.SubmitTime, //提交时间
TakeUpTime = objgs_KnowledgesGraphENS.TakeUpTime, //耗时
};
 return objgs_KnowledgesGraphENT;
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
public static void CheckPropertyNew(this clsgs_KnowledgesGraphEN objgs_KnowledgesGraphEN)
{
 clsgs_KnowledgesGraphBL.gs_KnowledgesGraphDA.CheckPropertyNew(objgs_KnowledgesGraphEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(this clsgs_KnowledgesGraphEN objgs_KnowledgesGraphEN)
{
 clsgs_KnowledgesGraphBL.gs_KnowledgesGraphDA.CheckProperty4Condition(objgs_KnowledgesGraphEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsgs_KnowledgesGraphEN objgs_KnowledgesGraphCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objgs_KnowledgesGraphCond.IsUpdated(congs_KnowledgesGraph.KnowledgeGraphId) == true)
{
string strComparisonOpKnowledgeGraphId = objgs_KnowledgesGraphCond.dicFldComparisonOp[congs_KnowledgesGraph.KnowledgeGraphId];
strWhereCond += string.Format(" And {0} {2} '{1}'", congs_KnowledgesGraph.KnowledgeGraphId, objgs_KnowledgesGraphCond.KnowledgeGraphId, strComparisonOpKnowledgeGraphId);
}
if (objgs_KnowledgesGraphCond.IsUpdated(congs_KnowledgesGraph.KnowledgeGraphName) == true)
{
string strComparisonOpKnowledgeGraphName = objgs_KnowledgesGraphCond.dicFldComparisonOp[congs_KnowledgesGraph.KnowledgeGraphName];
strWhereCond += string.Format(" And {0} {2} '{1}'", congs_KnowledgesGraph.KnowledgeGraphName, objgs_KnowledgesGraphCond.KnowledgeGraphName, strComparisonOpKnowledgeGraphName);
}
if (objgs_KnowledgesGraphCond.IsUpdated(congs_KnowledgesGraph.IdCurrEduCls) == true)
{
string strComparisonOpIdCurrEduCls = objgs_KnowledgesGraphCond.dicFldComparisonOp[congs_KnowledgesGraph.IdCurrEduCls];
strWhereCond += string.Format(" And {0} {2} '{1}'", congs_KnowledgesGraph.IdCurrEduCls, objgs_KnowledgesGraphCond.IdCurrEduCls, strComparisonOpIdCurrEduCls);
}
if (objgs_KnowledgesGraphCond.IsUpdated(congs_KnowledgesGraph.CourseId) == true)
{
string strComparisonOpCourseId = objgs_KnowledgesGraphCond.dicFldComparisonOp[congs_KnowledgesGraph.CourseId];
strWhereCond += string.Format(" And {0} {2} '{1}'", congs_KnowledgesGraph.CourseId, objgs_KnowledgesGraphCond.CourseId, strComparisonOpCourseId);
}
if (objgs_KnowledgesGraphCond.IsUpdated(congs_KnowledgesGraph.CreateUser) == true)
{
string strComparisonOpCreateUser = objgs_KnowledgesGraphCond.dicFldComparisonOp[congs_KnowledgesGraph.CreateUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", congs_KnowledgesGraph.CreateUser, objgs_KnowledgesGraphCond.CreateUser, strComparisonOpCreateUser);
}
if (objgs_KnowledgesGraphCond.IsUpdated(congs_KnowledgesGraph.UpdDate) == true)
{
string strComparisonOpUpdDate = objgs_KnowledgesGraphCond.dicFldComparisonOp[congs_KnowledgesGraph.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", congs_KnowledgesGraph.UpdDate, objgs_KnowledgesGraphCond.UpdDate, strComparisonOpUpdDate);
}
if (objgs_KnowledgesGraphCond.IsUpdated(congs_KnowledgesGraph.UpdUser) == true)
{
string strComparisonOpUpdUser = objgs_KnowledgesGraphCond.dicFldComparisonOp[congs_KnowledgesGraph.UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", congs_KnowledgesGraph.UpdUser, objgs_KnowledgesGraphCond.UpdUser, strComparisonOpUpdUser);
}
if (objgs_KnowledgesGraphCond.IsUpdated(congs_KnowledgesGraph.Memo) == true)
{
string strComparisonOpMemo = objgs_KnowledgesGraphCond.dicFldComparisonOp[congs_KnowledgesGraph.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", congs_KnowledgesGraph.Memo, objgs_KnowledgesGraphCond.Memo, strComparisonOpMemo);
}
if (objgs_KnowledgesGraphCond.IsUpdated(congs_KnowledgesGraph.GraphTypeId) == true)
{
string strComparisonOpGraphTypeId = objgs_KnowledgesGraphCond.dicFldComparisonOp[congs_KnowledgesGraph.GraphTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", congs_KnowledgesGraph.GraphTypeId, objgs_KnowledgesGraphCond.GraphTypeId, strComparisonOpGraphTypeId);
}
if (objgs_KnowledgesGraphCond.IsUpdated(congs_KnowledgesGraph.IsDisplay) == true)
{
if (objgs_KnowledgesGraphCond.IsDisplay == true)
{
strWhereCond += string.Format(" And {0} = '1'", congs_KnowledgesGraph.IsDisplay);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", congs_KnowledgesGraph.IsDisplay);
}
}
if (objgs_KnowledgesGraphCond.IsUpdated(congs_KnowledgesGraph.IsExtend) == true)
{
if (objgs_KnowledgesGraphCond.IsExtend == true)
{
strWhereCond += string.Format(" And {0} = '1'", congs_KnowledgesGraph.IsExtend);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", congs_KnowledgesGraph.IsExtend);
}
}
if (objgs_KnowledgesGraphCond.IsUpdated(congs_KnowledgesGraph.IsRecommend) == true)
{
if (objgs_KnowledgesGraphCond.IsRecommend == true)
{
strWhereCond += string.Format(" And {0} = '1'", congs_KnowledgesGraph.IsRecommend);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", congs_KnowledgesGraph.IsRecommend);
}
}
if (objgs_KnowledgesGraphCond.IsUpdated(congs_KnowledgesGraph.IsAnswer) == true)
{
if (objgs_KnowledgesGraphCond.IsAnswer == true)
{
strWhereCond += string.Format(" And {0} = '1'", congs_KnowledgesGraph.IsAnswer);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", congs_KnowledgesGraph.IsAnswer);
}
}
if (objgs_KnowledgesGraphCond.IsUpdated(congs_KnowledgesGraph.IsSubmit) == true)
{
if (objgs_KnowledgesGraphCond.IsSubmit == true)
{
strWhereCond += string.Format(" And {0} = '1'", congs_KnowledgesGraph.IsSubmit);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", congs_KnowledgesGraph.IsSubmit);
}
}
if (objgs_KnowledgesGraphCond.IsUpdated(congs_KnowledgesGraph.StartTime) == true)
{
string strComparisonOpStartTime = objgs_KnowledgesGraphCond.dicFldComparisonOp[congs_KnowledgesGraph.StartTime];
strWhereCond += string.Format(" And {0} {2} '{1}'", congs_KnowledgesGraph.StartTime, objgs_KnowledgesGraphCond.StartTime, strComparisonOpStartTime);
}
if (objgs_KnowledgesGraphCond.IsUpdated(congs_KnowledgesGraph.SubmitTime) == true)
{
string strComparisonOpSubmitTime = objgs_KnowledgesGraphCond.dicFldComparisonOp[congs_KnowledgesGraph.SubmitTime];
strWhereCond += string.Format(" And {0} {2} '{1}'", congs_KnowledgesGraph.SubmitTime, objgs_KnowledgesGraphCond.SubmitTime, strComparisonOpSubmitTime);
}
if (objgs_KnowledgesGraphCond.IsUpdated(congs_KnowledgesGraph.TakeUpTime) == true)
{
string strComparisonOpTakeUpTime = objgs_KnowledgesGraphCond.dicFldComparisonOp[congs_KnowledgesGraph.TakeUpTime];
strWhereCond += string.Format(" And {0} {2} '{1}'", congs_KnowledgesGraph.TakeUpTime, objgs_KnowledgesGraphCond.TakeUpTime, strComparisonOpTakeUpTime);
}
 return strWhereCond;
}

 /// <summary>
 /// 检查唯一性(Uniqueness)--gs_KnowledgesGraph(知识点逻辑图), 如果不唯一,即存在相同的记录,就返回False
 /// 唯一性条件:KnowledgeGraphName_CourseId_CreateUser
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckConstraint)
 /// </summary>
 /// <param name = "objgs_KnowledgesGraphEN">要求唯一的对象</param>
 /// <returns></returns>
public static bool CheckUniqueness(this clsgs_KnowledgesGraphEN objgs_KnowledgesGraphEN)
{
//检测记录是否存在
bool bolIsUniqueness;
StringBuilder sbCondition = new StringBuilder();
if (objgs_KnowledgesGraphEN == null) return true;
if (objgs_KnowledgesGraphEN.KnowledgeGraphId == null || objgs_KnowledgesGraphEN.KnowledgeGraphId == "")
{
sbCondition.AppendFormat("1 = 1");
 if (objgs_KnowledgesGraphEN.KnowledgeGraphName == null)
{
 sbCondition.AppendFormat(" and KnowledgeGraphName is null", objgs_KnowledgesGraphEN.KnowledgeGraphName);
}
else
{
 sbCondition.AppendFormat(" and KnowledgeGraphName = '{0}'", objgs_KnowledgesGraphEN.KnowledgeGraphName);
}
 if (objgs_KnowledgesGraphEN.CourseId == null)
{
 sbCondition.AppendFormat(" and CourseId is null", objgs_KnowledgesGraphEN.CourseId);
}
else
{
 sbCondition.AppendFormat(" and CourseId = '{0}'", objgs_KnowledgesGraphEN.CourseId);
}
 if (objgs_KnowledgesGraphEN.CreateUser == null)
{
 sbCondition.AppendFormat(" and CreateUser is null", objgs_KnowledgesGraphEN.CreateUser);
}
else
{
 sbCondition.AppendFormat(" and CreateUser = '{0}'", objgs_KnowledgesGraphEN.CreateUser);
}
if (clsgs_KnowledgesGraphBL.IsExistRecord(sbCondition.ToString())  ==  true)
{
 bolIsUniqueness = false;
}
else
{
 bolIsUniqueness = true;
}
}
 else {
sbCondition.AppendFormat("KnowledgeGraphId !=  '{0}'", objgs_KnowledgesGraphEN.KnowledgeGraphId);
 sbCondition.AppendFormat(" and KnowledgeGraphName = '{0}'", objgs_KnowledgesGraphEN.KnowledgeGraphName);
 sbCondition.AppendFormat(" and CourseId = '{0}'", objgs_KnowledgesGraphEN.CourseId);
 sbCondition.AppendFormat(" and CreateUser = '{0}'", objgs_KnowledgesGraphEN.CreateUser);
if (clsgs_KnowledgesGraphBL.IsExistRecord(sbCondition.ToString())  ==  true)
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
 /// 获取唯一性条件串--gs_KnowledgesGraph(知识点逻辑图), 即由对象中唯一性条件字段关键字与值组成的条件串
 /// 唯一性条件:KnowledgeGraphName_CourseId_CreateUser
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetConditionString4Constraint)
 /// </summary>
 /// <param name = "objgs_KnowledgesGraphEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(this clsgs_KnowledgesGraphEN objgs_KnowledgesGraphEN)
{
//检测记录是否存在
StringBuilder sbCondition = new StringBuilder();
if (objgs_KnowledgesGraphEN == null) return "";
if (objgs_KnowledgesGraphEN.KnowledgeGraphId == null || objgs_KnowledgesGraphEN.KnowledgeGraphId == "")
{
sbCondition.AppendFormat("1 = 1");
 if (objgs_KnowledgesGraphEN.KnowledgeGraphName == null)
{
 sbCondition.AppendFormat(" and KnowledgeGraphName is null", objgs_KnowledgesGraphEN.KnowledgeGraphName);
}
else
{
 sbCondition.AppendFormat(" and KnowledgeGraphName = '{0}'", objgs_KnowledgesGraphEN.KnowledgeGraphName);
}
 if (objgs_KnowledgesGraphEN.CourseId == null)
{
 sbCondition.AppendFormat(" and CourseId is null", objgs_KnowledgesGraphEN.CourseId);
}
else
{
 sbCondition.AppendFormat(" and CourseId = '{0}'", objgs_KnowledgesGraphEN.CourseId);
}
 if (objgs_KnowledgesGraphEN.CreateUser == null)
{
 sbCondition.AppendFormat(" and CreateUser is null", objgs_KnowledgesGraphEN.CreateUser);
}
else
{
 sbCondition.AppendFormat(" and CreateUser = '{0}'", objgs_KnowledgesGraphEN.CreateUser);
}
return sbCondition.ToString();
}
 else {
sbCondition.AppendFormat("KnowledgeGraphId !=  '{0}'", objgs_KnowledgesGraphEN.KnowledgeGraphId);
 sbCondition.AppendFormat(" and KnowledgeGraphName = '{0}'", objgs_KnowledgesGraphEN.KnowledgeGraphName);
 sbCondition.AppendFormat(" and CourseId = '{0}'", objgs_KnowledgesGraphEN.CourseId);
 sbCondition.AppendFormat(" and CreateUser = '{0}'", objgs_KnowledgesGraphEN.CreateUser);
 return sbCondition.ToString();
}
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_gs_KnowledgesGraph
{
public virtual bool UpdRelaTabDate(string strKnowledgeGraphId, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// 知识点逻辑图(gs_KnowledgesGraph)
 /// 数据源类型:表
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsgs_KnowledgesGraphBL
{
public static RelatedActions_gs_KnowledgesGraph relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsgs_KnowledgesGraphDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsgs_KnowledgesGraphDA gs_KnowledgesGraphDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsgs_KnowledgesGraphDA();
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
 public clsgs_KnowledgesGraphBL()
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
if (string.IsNullOrEmpty(clsgs_KnowledgesGraphEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsgs_KnowledgesGraphEN._ConnectString);
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
public static DataTable GetDataTable_gs_KnowledgesGraph(string strWhereCond)
{
DataTable objDT;
try
{
objDT = gs_KnowledgesGraphDA.GetDataTable_gs_KnowledgesGraph(strWhereCond);
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
objDT = gs_KnowledgesGraphDA.GetDataTable(strWhereCond);
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
objDT = gs_KnowledgesGraphDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = gs_KnowledgesGraphDA.GetDataTable(strWhereCond, strTabName);
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
objDT = gs_KnowledgesGraphDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = gs_KnowledgesGraphDA.GetDataTable_Top(objTopPara);
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
objDT = gs_KnowledgesGraphDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = gs_KnowledgesGraphDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = gs_KnowledgesGraphDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
 /// <param name = "arrKnowledgeGraphIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static List<clsgs_KnowledgesGraphEN> GetObjLstByKnowledgeGraphIdLst(List<string> arrKnowledgeGraphIdLst)
{
List<clsgs_KnowledgesGraphEN> arrObjLst = new List<clsgs_KnowledgesGraphEN>(); 
System.Data.DataTable objDT; 
 string strSqlConditionStr = clsArray.GetSqlInStrByArray(arrKnowledgeGraphIdLst, true);
 string strWhereCond = string.Format("KnowledgeGraphId in ({0})", strSqlConditionStr);
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsgs_KnowledgesGraphEN objgs_KnowledgesGraphEN = new clsgs_KnowledgesGraphEN();
try
{
objgs_KnowledgesGraphEN.KnowledgeGraphId = objRow[congs_KnowledgesGraph.KnowledgeGraphId].ToString().Trim(); //知识点图Id
objgs_KnowledgesGraphEN.KnowledgeGraphName = objRow[congs_KnowledgesGraph.KnowledgeGraphName] == DBNull.Value ? null : objRow[congs_KnowledgesGraph.KnowledgeGraphName].ToString().Trim(); //连连看图名
objgs_KnowledgesGraphEN.IdCurrEduCls = objRow[congs_KnowledgesGraph.IdCurrEduCls] == DBNull.Value ? null : objRow[congs_KnowledgesGraph.IdCurrEduCls].ToString().Trim(); //教学班流水号
objgs_KnowledgesGraphEN.CourseId = objRow[congs_KnowledgesGraph.CourseId] == DBNull.Value ? null : objRow[congs_KnowledgesGraph.CourseId].ToString().Trim(); //课程Id
objgs_KnowledgesGraphEN.CreateUser = objRow[congs_KnowledgesGraph.CreateUser] == DBNull.Value ? null : objRow[congs_KnowledgesGraph.CreateUser].ToString().Trim(); //建立用户
objgs_KnowledgesGraphEN.UpdDate = objRow[congs_KnowledgesGraph.UpdDate] == DBNull.Value ? null : objRow[congs_KnowledgesGraph.UpdDate].ToString().Trim(); //修改日期
objgs_KnowledgesGraphEN.UpdUser = objRow[congs_KnowledgesGraph.UpdUser] == DBNull.Value ? null : objRow[congs_KnowledgesGraph.UpdUser].ToString().Trim(); //修改人
objgs_KnowledgesGraphEN.Memo = objRow[congs_KnowledgesGraph.Memo] == DBNull.Value ? null : objRow[congs_KnowledgesGraph.Memo].ToString().Trim(); //备注
objgs_KnowledgesGraphEN.GraphTypeId = objRow[congs_KnowledgesGraph.GraphTypeId] == DBNull.Value ? null : objRow[congs_KnowledgesGraph.GraphTypeId].ToString().Trim(); //图谱类型Id
objgs_KnowledgesGraphEN.IsDisplay = clsEntityBase2.TransNullToBool_S(objRow[congs_KnowledgesGraph.IsDisplay].ToString().Trim()); //是否显示
objgs_KnowledgesGraphEN.IsExtend = clsEntityBase2.TransNullToBool_S(objRow[congs_KnowledgesGraph.IsExtend].ToString().Trim()); //是否扩展
objgs_KnowledgesGraphEN.IsRecommend = clsEntityBase2.TransNullToBool_S(objRow[congs_KnowledgesGraph.IsRecommend].ToString().Trim()); //是否推荐
objgs_KnowledgesGraphEN.IsAnswer = clsEntityBase2.TransNullToBool_S(objRow[congs_KnowledgesGraph.IsAnswer].ToString().Trim()); //是否回答
objgs_KnowledgesGraphEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[congs_KnowledgesGraph.IsSubmit].ToString().Trim()); //是否提交
objgs_KnowledgesGraphEN.StartTime = objRow[congs_KnowledgesGraph.StartTime] == DBNull.Value ? null : objRow[congs_KnowledgesGraph.StartTime].ToString().Trim(); //开始时间
objgs_KnowledgesGraphEN.SubmitTime = objRow[congs_KnowledgesGraph.SubmitTime] == DBNull.Value ? null : objRow[congs_KnowledgesGraph.SubmitTime].ToString().Trim(); //提交时间
objgs_KnowledgesGraphEN.TakeUpTime = objRow[congs_KnowledgesGraph.TakeUpTime] == DBNull.Value ? null : objRow[congs_KnowledgesGraph.TakeUpTime].ToString().Trim(); //耗时
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objgs_KnowledgesGraphEN.KnowledgeGraphId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objgs_KnowledgesGraphEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrKnowledgeGraphIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsgs_KnowledgesGraphEN> GetObjLstByKnowledgeGraphIdLstCache(List<string> arrKnowledgeGraphIdLst, string strCourseId)
{
string strKey = string.Format("{0}_{1}", clsgs_KnowledgesGraphEN._CurrTabName, strCourseId);
List<clsgs_KnowledgesGraphEN> arrgs_KnowledgesGraphObjLstCache = GetObjLstCache(strCourseId);
IEnumerable <clsgs_KnowledgesGraphEN> arrgs_KnowledgesGraphObjLst_Sel =
arrgs_KnowledgesGraphObjLstCache
.Where(x => arrKnowledgeGraphIdLst.Contains(x.KnowledgeGraphId));
return arrgs_KnowledgesGraphObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsgs_KnowledgesGraphEN> GetObjLst(string strWhereCond)
{
List<clsgs_KnowledgesGraphEN> arrObjLst = new List<clsgs_KnowledgesGraphEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsgs_KnowledgesGraphEN objgs_KnowledgesGraphEN = new clsgs_KnowledgesGraphEN();
try
{
objgs_KnowledgesGraphEN.KnowledgeGraphId = objRow[congs_KnowledgesGraph.KnowledgeGraphId].ToString().Trim(); //知识点图Id
objgs_KnowledgesGraphEN.KnowledgeGraphName = objRow[congs_KnowledgesGraph.KnowledgeGraphName] == DBNull.Value ? null : objRow[congs_KnowledgesGraph.KnowledgeGraphName].ToString().Trim(); //连连看图名
objgs_KnowledgesGraphEN.IdCurrEduCls = objRow[congs_KnowledgesGraph.IdCurrEduCls] == DBNull.Value ? null : objRow[congs_KnowledgesGraph.IdCurrEduCls].ToString().Trim(); //教学班流水号
objgs_KnowledgesGraphEN.CourseId = objRow[congs_KnowledgesGraph.CourseId] == DBNull.Value ? null : objRow[congs_KnowledgesGraph.CourseId].ToString().Trim(); //课程Id
objgs_KnowledgesGraphEN.CreateUser = objRow[congs_KnowledgesGraph.CreateUser] == DBNull.Value ? null : objRow[congs_KnowledgesGraph.CreateUser].ToString().Trim(); //建立用户
objgs_KnowledgesGraphEN.UpdDate = objRow[congs_KnowledgesGraph.UpdDate] == DBNull.Value ? null : objRow[congs_KnowledgesGraph.UpdDate].ToString().Trim(); //修改日期
objgs_KnowledgesGraphEN.UpdUser = objRow[congs_KnowledgesGraph.UpdUser] == DBNull.Value ? null : objRow[congs_KnowledgesGraph.UpdUser].ToString().Trim(); //修改人
objgs_KnowledgesGraphEN.Memo = objRow[congs_KnowledgesGraph.Memo] == DBNull.Value ? null : objRow[congs_KnowledgesGraph.Memo].ToString().Trim(); //备注
objgs_KnowledgesGraphEN.GraphTypeId = objRow[congs_KnowledgesGraph.GraphTypeId] == DBNull.Value ? null : objRow[congs_KnowledgesGraph.GraphTypeId].ToString().Trim(); //图谱类型Id
objgs_KnowledgesGraphEN.IsDisplay = clsEntityBase2.TransNullToBool_S(objRow[congs_KnowledgesGraph.IsDisplay].ToString().Trim()); //是否显示
objgs_KnowledgesGraphEN.IsExtend = clsEntityBase2.TransNullToBool_S(objRow[congs_KnowledgesGraph.IsExtend].ToString().Trim()); //是否扩展
objgs_KnowledgesGraphEN.IsRecommend = clsEntityBase2.TransNullToBool_S(objRow[congs_KnowledgesGraph.IsRecommend].ToString().Trim()); //是否推荐
objgs_KnowledgesGraphEN.IsAnswer = clsEntityBase2.TransNullToBool_S(objRow[congs_KnowledgesGraph.IsAnswer].ToString().Trim()); //是否回答
objgs_KnowledgesGraphEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[congs_KnowledgesGraph.IsSubmit].ToString().Trim()); //是否提交
objgs_KnowledgesGraphEN.StartTime = objRow[congs_KnowledgesGraph.StartTime] == DBNull.Value ? null : objRow[congs_KnowledgesGraph.StartTime].ToString().Trim(); //开始时间
objgs_KnowledgesGraphEN.SubmitTime = objRow[congs_KnowledgesGraph.SubmitTime] == DBNull.Value ? null : objRow[congs_KnowledgesGraph.SubmitTime].ToString().Trim(); //提交时间
objgs_KnowledgesGraphEN.TakeUpTime = objRow[congs_KnowledgesGraph.TakeUpTime] == DBNull.Value ? null : objRow[congs_KnowledgesGraph.TakeUpTime].ToString().Trim(); //耗时
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objgs_KnowledgesGraphEN.KnowledgeGraphId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objgs_KnowledgesGraphEN);
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
public static List<clsgs_KnowledgesGraphEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsgs_KnowledgesGraphEN> arrObjLst = new List<clsgs_KnowledgesGraphEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsgs_KnowledgesGraphEN objgs_KnowledgesGraphEN = new clsgs_KnowledgesGraphEN();
try
{
objgs_KnowledgesGraphEN.KnowledgeGraphId = objRow[congs_KnowledgesGraph.KnowledgeGraphId].ToString().Trim(); //知识点图Id
objgs_KnowledgesGraphEN.KnowledgeGraphName = objRow[congs_KnowledgesGraph.KnowledgeGraphName] == DBNull.Value ? null : objRow[congs_KnowledgesGraph.KnowledgeGraphName].ToString().Trim(); //连连看图名
objgs_KnowledgesGraphEN.IdCurrEduCls = objRow[congs_KnowledgesGraph.IdCurrEduCls] == DBNull.Value ? null : objRow[congs_KnowledgesGraph.IdCurrEduCls].ToString().Trim(); //教学班流水号
objgs_KnowledgesGraphEN.CourseId = objRow[congs_KnowledgesGraph.CourseId] == DBNull.Value ? null : objRow[congs_KnowledgesGraph.CourseId].ToString().Trim(); //课程Id
objgs_KnowledgesGraphEN.CreateUser = objRow[congs_KnowledgesGraph.CreateUser] == DBNull.Value ? null : objRow[congs_KnowledgesGraph.CreateUser].ToString().Trim(); //建立用户
objgs_KnowledgesGraphEN.UpdDate = objRow[congs_KnowledgesGraph.UpdDate] == DBNull.Value ? null : objRow[congs_KnowledgesGraph.UpdDate].ToString().Trim(); //修改日期
objgs_KnowledgesGraphEN.UpdUser = objRow[congs_KnowledgesGraph.UpdUser] == DBNull.Value ? null : objRow[congs_KnowledgesGraph.UpdUser].ToString().Trim(); //修改人
objgs_KnowledgesGraphEN.Memo = objRow[congs_KnowledgesGraph.Memo] == DBNull.Value ? null : objRow[congs_KnowledgesGraph.Memo].ToString().Trim(); //备注
objgs_KnowledgesGraphEN.GraphTypeId = objRow[congs_KnowledgesGraph.GraphTypeId] == DBNull.Value ? null : objRow[congs_KnowledgesGraph.GraphTypeId].ToString().Trim(); //图谱类型Id
objgs_KnowledgesGraphEN.IsDisplay = clsEntityBase2.TransNullToBool_S(objRow[congs_KnowledgesGraph.IsDisplay].ToString().Trim()); //是否显示
objgs_KnowledgesGraphEN.IsExtend = clsEntityBase2.TransNullToBool_S(objRow[congs_KnowledgesGraph.IsExtend].ToString().Trim()); //是否扩展
objgs_KnowledgesGraphEN.IsRecommend = clsEntityBase2.TransNullToBool_S(objRow[congs_KnowledgesGraph.IsRecommend].ToString().Trim()); //是否推荐
objgs_KnowledgesGraphEN.IsAnswer = clsEntityBase2.TransNullToBool_S(objRow[congs_KnowledgesGraph.IsAnswer].ToString().Trim()); //是否回答
objgs_KnowledgesGraphEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[congs_KnowledgesGraph.IsSubmit].ToString().Trim()); //是否提交
objgs_KnowledgesGraphEN.StartTime = objRow[congs_KnowledgesGraph.StartTime] == DBNull.Value ? null : objRow[congs_KnowledgesGraph.StartTime].ToString().Trim(); //开始时间
objgs_KnowledgesGraphEN.SubmitTime = objRow[congs_KnowledgesGraph.SubmitTime] == DBNull.Value ? null : objRow[congs_KnowledgesGraph.SubmitTime].ToString().Trim(); //提交时间
objgs_KnowledgesGraphEN.TakeUpTime = objRow[congs_KnowledgesGraph.TakeUpTime] == DBNull.Value ? null : objRow[congs_KnowledgesGraph.TakeUpTime].ToString().Trim(); //耗时
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objgs_KnowledgesGraphEN.KnowledgeGraphId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objgs_KnowledgesGraphEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objgs_KnowledgesGraphCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsgs_KnowledgesGraphEN> GetSubObjLstCache(clsgs_KnowledgesGraphEN objgs_KnowledgesGraphCond)
{
 string strCourseId = objgs_KnowledgesGraphCond.CourseId;
 if (string.IsNullOrEmpty(strCourseId) == true)
{
string strMsg = string.Format("(errid:Busi000172)在表中,缓存分类字段值不能为空!(clsgs_KnowledgesGraphBL:GetSubObjLstCache)");
throw new Exception(strMsg);
}
List<clsgs_KnowledgesGraphEN> arrObjLstCache = GetObjLstCache(strCourseId);
IEnumerable <clsgs_KnowledgesGraphEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in congs_KnowledgesGraph.AttributeName)
{
if (objgs_KnowledgesGraphCond.IsUpdated(strFldName) == false) continue;
if (objgs_KnowledgesGraphCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objgs_KnowledgesGraphCond[strFldName].ToString());
}
else
{
if (objgs_KnowledgesGraphCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objgs_KnowledgesGraphCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objgs_KnowledgesGraphCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objgs_KnowledgesGraphCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objgs_KnowledgesGraphCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objgs_KnowledgesGraphCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objgs_KnowledgesGraphCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objgs_KnowledgesGraphCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objgs_KnowledgesGraphCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objgs_KnowledgesGraphCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objgs_KnowledgesGraphCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objgs_KnowledgesGraphCond[strFldName]));
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
public static List<clsgs_KnowledgesGraphEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsgs_KnowledgesGraphEN> arrObjLst = new List<clsgs_KnowledgesGraphEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsgs_KnowledgesGraphEN objgs_KnowledgesGraphEN = new clsgs_KnowledgesGraphEN();
try
{
objgs_KnowledgesGraphEN.KnowledgeGraphId = objRow[congs_KnowledgesGraph.KnowledgeGraphId].ToString().Trim(); //知识点图Id
objgs_KnowledgesGraphEN.KnowledgeGraphName = objRow[congs_KnowledgesGraph.KnowledgeGraphName] == DBNull.Value ? null : objRow[congs_KnowledgesGraph.KnowledgeGraphName].ToString().Trim(); //连连看图名
objgs_KnowledgesGraphEN.IdCurrEduCls = objRow[congs_KnowledgesGraph.IdCurrEduCls] == DBNull.Value ? null : objRow[congs_KnowledgesGraph.IdCurrEduCls].ToString().Trim(); //教学班流水号
objgs_KnowledgesGraphEN.CourseId = objRow[congs_KnowledgesGraph.CourseId] == DBNull.Value ? null : objRow[congs_KnowledgesGraph.CourseId].ToString().Trim(); //课程Id
objgs_KnowledgesGraphEN.CreateUser = objRow[congs_KnowledgesGraph.CreateUser] == DBNull.Value ? null : objRow[congs_KnowledgesGraph.CreateUser].ToString().Trim(); //建立用户
objgs_KnowledgesGraphEN.UpdDate = objRow[congs_KnowledgesGraph.UpdDate] == DBNull.Value ? null : objRow[congs_KnowledgesGraph.UpdDate].ToString().Trim(); //修改日期
objgs_KnowledgesGraphEN.UpdUser = objRow[congs_KnowledgesGraph.UpdUser] == DBNull.Value ? null : objRow[congs_KnowledgesGraph.UpdUser].ToString().Trim(); //修改人
objgs_KnowledgesGraphEN.Memo = objRow[congs_KnowledgesGraph.Memo] == DBNull.Value ? null : objRow[congs_KnowledgesGraph.Memo].ToString().Trim(); //备注
objgs_KnowledgesGraphEN.GraphTypeId = objRow[congs_KnowledgesGraph.GraphTypeId] == DBNull.Value ? null : objRow[congs_KnowledgesGraph.GraphTypeId].ToString().Trim(); //图谱类型Id
objgs_KnowledgesGraphEN.IsDisplay = clsEntityBase2.TransNullToBool_S(objRow[congs_KnowledgesGraph.IsDisplay].ToString().Trim()); //是否显示
objgs_KnowledgesGraphEN.IsExtend = clsEntityBase2.TransNullToBool_S(objRow[congs_KnowledgesGraph.IsExtend].ToString().Trim()); //是否扩展
objgs_KnowledgesGraphEN.IsRecommend = clsEntityBase2.TransNullToBool_S(objRow[congs_KnowledgesGraph.IsRecommend].ToString().Trim()); //是否推荐
objgs_KnowledgesGraphEN.IsAnswer = clsEntityBase2.TransNullToBool_S(objRow[congs_KnowledgesGraph.IsAnswer].ToString().Trim()); //是否回答
objgs_KnowledgesGraphEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[congs_KnowledgesGraph.IsSubmit].ToString().Trim()); //是否提交
objgs_KnowledgesGraphEN.StartTime = objRow[congs_KnowledgesGraph.StartTime] == DBNull.Value ? null : objRow[congs_KnowledgesGraph.StartTime].ToString().Trim(); //开始时间
objgs_KnowledgesGraphEN.SubmitTime = objRow[congs_KnowledgesGraph.SubmitTime] == DBNull.Value ? null : objRow[congs_KnowledgesGraph.SubmitTime].ToString().Trim(); //提交时间
objgs_KnowledgesGraphEN.TakeUpTime = objRow[congs_KnowledgesGraph.TakeUpTime] == DBNull.Value ? null : objRow[congs_KnowledgesGraph.TakeUpTime].ToString().Trim(); //耗时
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objgs_KnowledgesGraphEN.KnowledgeGraphId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objgs_KnowledgesGraphEN);
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
public static List<clsgs_KnowledgesGraphEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsgs_KnowledgesGraphEN> arrObjLst = new List<clsgs_KnowledgesGraphEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsgs_KnowledgesGraphEN objgs_KnowledgesGraphEN = new clsgs_KnowledgesGraphEN();
try
{
objgs_KnowledgesGraphEN.KnowledgeGraphId = objRow[congs_KnowledgesGraph.KnowledgeGraphId].ToString().Trim(); //知识点图Id
objgs_KnowledgesGraphEN.KnowledgeGraphName = objRow[congs_KnowledgesGraph.KnowledgeGraphName] == DBNull.Value ? null : objRow[congs_KnowledgesGraph.KnowledgeGraphName].ToString().Trim(); //连连看图名
objgs_KnowledgesGraphEN.IdCurrEduCls = objRow[congs_KnowledgesGraph.IdCurrEduCls] == DBNull.Value ? null : objRow[congs_KnowledgesGraph.IdCurrEduCls].ToString().Trim(); //教学班流水号
objgs_KnowledgesGraphEN.CourseId = objRow[congs_KnowledgesGraph.CourseId] == DBNull.Value ? null : objRow[congs_KnowledgesGraph.CourseId].ToString().Trim(); //课程Id
objgs_KnowledgesGraphEN.CreateUser = objRow[congs_KnowledgesGraph.CreateUser] == DBNull.Value ? null : objRow[congs_KnowledgesGraph.CreateUser].ToString().Trim(); //建立用户
objgs_KnowledgesGraphEN.UpdDate = objRow[congs_KnowledgesGraph.UpdDate] == DBNull.Value ? null : objRow[congs_KnowledgesGraph.UpdDate].ToString().Trim(); //修改日期
objgs_KnowledgesGraphEN.UpdUser = objRow[congs_KnowledgesGraph.UpdUser] == DBNull.Value ? null : objRow[congs_KnowledgesGraph.UpdUser].ToString().Trim(); //修改人
objgs_KnowledgesGraphEN.Memo = objRow[congs_KnowledgesGraph.Memo] == DBNull.Value ? null : objRow[congs_KnowledgesGraph.Memo].ToString().Trim(); //备注
objgs_KnowledgesGraphEN.GraphTypeId = objRow[congs_KnowledgesGraph.GraphTypeId] == DBNull.Value ? null : objRow[congs_KnowledgesGraph.GraphTypeId].ToString().Trim(); //图谱类型Id
objgs_KnowledgesGraphEN.IsDisplay = clsEntityBase2.TransNullToBool_S(objRow[congs_KnowledgesGraph.IsDisplay].ToString().Trim()); //是否显示
objgs_KnowledgesGraphEN.IsExtend = clsEntityBase2.TransNullToBool_S(objRow[congs_KnowledgesGraph.IsExtend].ToString().Trim()); //是否扩展
objgs_KnowledgesGraphEN.IsRecommend = clsEntityBase2.TransNullToBool_S(objRow[congs_KnowledgesGraph.IsRecommend].ToString().Trim()); //是否推荐
objgs_KnowledgesGraphEN.IsAnswer = clsEntityBase2.TransNullToBool_S(objRow[congs_KnowledgesGraph.IsAnswer].ToString().Trim()); //是否回答
objgs_KnowledgesGraphEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[congs_KnowledgesGraph.IsSubmit].ToString().Trim()); //是否提交
objgs_KnowledgesGraphEN.StartTime = objRow[congs_KnowledgesGraph.StartTime] == DBNull.Value ? null : objRow[congs_KnowledgesGraph.StartTime].ToString().Trim(); //开始时间
objgs_KnowledgesGraphEN.SubmitTime = objRow[congs_KnowledgesGraph.SubmitTime] == DBNull.Value ? null : objRow[congs_KnowledgesGraph.SubmitTime].ToString().Trim(); //提交时间
objgs_KnowledgesGraphEN.TakeUpTime = objRow[congs_KnowledgesGraph.TakeUpTime] == DBNull.Value ? null : objRow[congs_KnowledgesGraph.TakeUpTime].ToString().Trim(); //耗时
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objgs_KnowledgesGraphEN.KnowledgeGraphId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objgs_KnowledgesGraphEN);
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
List<clsgs_KnowledgesGraphEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsgs_KnowledgesGraphEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsgs_KnowledgesGraphEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsgs_KnowledgesGraphEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsgs_KnowledgesGraphEN> arrObjLst = new List<clsgs_KnowledgesGraphEN>(); 
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
	clsgs_KnowledgesGraphEN objgs_KnowledgesGraphEN = new clsgs_KnowledgesGraphEN();
try
{
objgs_KnowledgesGraphEN.KnowledgeGraphId = objRow[congs_KnowledgesGraph.KnowledgeGraphId].ToString().Trim(); //知识点图Id
objgs_KnowledgesGraphEN.KnowledgeGraphName = objRow[congs_KnowledgesGraph.KnowledgeGraphName] == DBNull.Value ? null : objRow[congs_KnowledgesGraph.KnowledgeGraphName].ToString().Trim(); //连连看图名
objgs_KnowledgesGraphEN.IdCurrEduCls = objRow[congs_KnowledgesGraph.IdCurrEduCls] == DBNull.Value ? null : objRow[congs_KnowledgesGraph.IdCurrEduCls].ToString().Trim(); //教学班流水号
objgs_KnowledgesGraphEN.CourseId = objRow[congs_KnowledgesGraph.CourseId] == DBNull.Value ? null : objRow[congs_KnowledgesGraph.CourseId].ToString().Trim(); //课程Id
objgs_KnowledgesGraphEN.CreateUser = objRow[congs_KnowledgesGraph.CreateUser] == DBNull.Value ? null : objRow[congs_KnowledgesGraph.CreateUser].ToString().Trim(); //建立用户
objgs_KnowledgesGraphEN.UpdDate = objRow[congs_KnowledgesGraph.UpdDate] == DBNull.Value ? null : objRow[congs_KnowledgesGraph.UpdDate].ToString().Trim(); //修改日期
objgs_KnowledgesGraphEN.UpdUser = objRow[congs_KnowledgesGraph.UpdUser] == DBNull.Value ? null : objRow[congs_KnowledgesGraph.UpdUser].ToString().Trim(); //修改人
objgs_KnowledgesGraphEN.Memo = objRow[congs_KnowledgesGraph.Memo] == DBNull.Value ? null : objRow[congs_KnowledgesGraph.Memo].ToString().Trim(); //备注
objgs_KnowledgesGraphEN.GraphTypeId = objRow[congs_KnowledgesGraph.GraphTypeId] == DBNull.Value ? null : objRow[congs_KnowledgesGraph.GraphTypeId].ToString().Trim(); //图谱类型Id
objgs_KnowledgesGraphEN.IsDisplay = clsEntityBase2.TransNullToBool_S(objRow[congs_KnowledgesGraph.IsDisplay].ToString().Trim()); //是否显示
objgs_KnowledgesGraphEN.IsExtend = clsEntityBase2.TransNullToBool_S(objRow[congs_KnowledgesGraph.IsExtend].ToString().Trim()); //是否扩展
objgs_KnowledgesGraphEN.IsRecommend = clsEntityBase2.TransNullToBool_S(objRow[congs_KnowledgesGraph.IsRecommend].ToString().Trim()); //是否推荐
objgs_KnowledgesGraphEN.IsAnswer = clsEntityBase2.TransNullToBool_S(objRow[congs_KnowledgesGraph.IsAnswer].ToString().Trim()); //是否回答
objgs_KnowledgesGraphEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[congs_KnowledgesGraph.IsSubmit].ToString().Trim()); //是否提交
objgs_KnowledgesGraphEN.StartTime = objRow[congs_KnowledgesGraph.StartTime] == DBNull.Value ? null : objRow[congs_KnowledgesGraph.StartTime].ToString().Trim(); //开始时间
objgs_KnowledgesGraphEN.SubmitTime = objRow[congs_KnowledgesGraph.SubmitTime] == DBNull.Value ? null : objRow[congs_KnowledgesGraph.SubmitTime].ToString().Trim(); //提交时间
objgs_KnowledgesGraphEN.TakeUpTime = objRow[congs_KnowledgesGraph.TakeUpTime] == DBNull.Value ? null : objRow[congs_KnowledgesGraph.TakeUpTime].ToString().Trim(); //耗时
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objgs_KnowledgesGraphEN.KnowledgeGraphId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objgs_KnowledgesGraphEN);
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
public static List<clsgs_KnowledgesGraphEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsgs_KnowledgesGraphEN> arrObjLst = new List<clsgs_KnowledgesGraphEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsgs_KnowledgesGraphEN objgs_KnowledgesGraphEN = new clsgs_KnowledgesGraphEN();
try
{
objgs_KnowledgesGraphEN.KnowledgeGraphId = objRow[congs_KnowledgesGraph.KnowledgeGraphId].ToString().Trim(); //知识点图Id
objgs_KnowledgesGraphEN.KnowledgeGraphName = objRow[congs_KnowledgesGraph.KnowledgeGraphName] == DBNull.Value ? null : objRow[congs_KnowledgesGraph.KnowledgeGraphName].ToString().Trim(); //连连看图名
objgs_KnowledgesGraphEN.IdCurrEduCls = objRow[congs_KnowledgesGraph.IdCurrEduCls] == DBNull.Value ? null : objRow[congs_KnowledgesGraph.IdCurrEduCls].ToString().Trim(); //教学班流水号
objgs_KnowledgesGraphEN.CourseId = objRow[congs_KnowledgesGraph.CourseId] == DBNull.Value ? null : objRow[congs_KnowledgesGraph.CourseId].ToString().Trim(); //课程Id
objgs_KnowledgesGraphEN.CreateUser = objRow[congs_KnowledgesGraph.CreateUser] == DBNull.Value ? null : objRow[congs_KnowledgesGraph.CreateUser].ToString().Trim(); //建立用户
objgs_KnowledgesGraphEN.UpdDate = objRow[congs_KnowledgesGraph.UpdDate] == DBNull.Value ? null : objRow[congs_KnowledgesGraph.UpdDate].ToString().Trim(); //修改日期
objgs_KnowledgesGraphEN.UpdUser = objRow[congs_KnowledgesGraph.UpdUser] == DBNull.Value ? null : objRow[congs_KnowledgesGraph.UpdUser].ToString().Trim(); //修改人
objgs_KnowledgesGraphEN.Memo = objRow[congs_KnowledgesGraph.Memo] == DBNull.Value ? null : objRow[congs_KnowledgesGraph.Memo].ToString().Trim(); //备注
objgs_KnowledgesGraphEN.GraphTypeId = objRow[congs_KnowledgesGraph.GraphTypeId] == DBNull.Value ? null : objRow[congs_KnowledgesGraph.GraphTypeId].ToString().Trim(); //图谱类型Id
objgs_KnowledgesGraphEN.IsDisplay = clsEntityBase2.TransNullToBool_S(objRow[congs_KnowledgesGraph.IsDisplay].ToString().Trim()); //是否显示
objgs_KnowledgesGraphEN.IsExtend = clsEntityBase2.TransNullToBool_S(objRow[congs_KnowledgesGraph.IsExtend].ToString().Trim()); //是否扩展
objgs_KnowledgesGraphEN.IsRecommend = clsEntityBase2.TransNullToBool_S(objRow[congs_KnowledgesGraph.IsRecommend].ToString().Trim()); //是否推荐
objgs_KnowledgesGraphEN.IsAnswer = clsEntityBase2.TransNullToBool_S(objRow[congs_KnowledgesGraph.IsAnswer].ToString().Trim()); //是否回答
objgs_KnowledgesGraphEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[congs_KnowledgesGraph.IsSubmit].ToString().Trim()); //是否提交
objgs_KnowledgesGraphEN.StartTime = objRow[congs_KnowledgesGraph.StartTime] == DBNull.Value ? null : objRow[congs_KnowledgesGraph.StartTime].ToString().Trim(); //开始时间
objgs_KnowledgesGraphEN.SubmitTime = objRow[congs_KnowledgesGraph.SubmitTime] == DBNull.Value ? null : objRow[congs_KnowledgesGraph.SubmitTime].ToString().Trim(); //提交时间
objgs_KnowledgesGraphEN.TakeUpTime = objRow[congs_KnowledgesGraph.TakeUpTime] == DBNull.Value ? null : objRow[congs_KnowledgesGraph.TakeUpTime].ToString().Trim(); //耗时
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objgs_KnowledgesGraphEN.KnowledgeGraphId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objgs_KnowledgesGraphEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsgs_KnowledgesGraphEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsgs_KnowledgesGraphEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsgs_KnowledgesGraphEN> arrObjLst = new List<clsgs_KnowledgesGraphEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsgs_KnowledgesGraphEN objgs_KnowledgesGraphEN = new clsgs_KnowledgesGraphEN();
try
{
objgs_KnowledgesGraphEN.KnowledgeGraphId = objRow[congs_KnowledgesGraph.KnowledgeGraphId].ToString().Trim(); //知识点图Id
objgs_KnowledgesGraphEN.KnowledgeGraphName = objRow[congs_KnowledgesGraph.KnowledgeGraphName] == DBNull.Value ? null : objRow[congs_KnowledgesGraph.KnowledgeGraphName].ToString().Trim(); //连连看图名
objgs_KnowledgesGraphEN.IdCurrEduCls = objRow[congs_KnowledgesGraph.IdCurrEduCls] == DBNull.Value ? null : objRow[congs_KnowledgesGraph.IdCurrEduCls].ToString().Trim(); //教学班流水号
objgs_KnowledgesGraphEN.CourseId = objRow[congs_KnowledgesGraph.CourseId] == DBNull.Value ? null : objRow[congs_KnowledgesGraph.CourseId].ToString().Trim(); //课程Id
objgs_KnowledgesGraphEN.CreateUser = objRow[congs_KnowledgesGraph.CreateUser] == DBNull.Value ? null : objRow[congs_KnowledgesGraph.CreateUser].ToString().Trim(); //建立用户
objgs_KnowledgesGraphEN.UpdDate = objRow[congs_KnowledgesGraph.UpdDate] == DBNull.Value ? null : objRow[congs_KnowledgesGraph.UpdDate].ToString().Trim(); //修改日期
objgs_KnowledgesGraphEN.UpdUser = objRow[congs_KnowledgesGraph.UpdUser] == DBNull.Value ? null : objRow[congs_KnowledgesGraph.UpdUser].ToString().Trim(); //修改人
objgs_KnowledgesGraphEN.Memo = objRow[congs_KnowledgesGraph.Memo] == DBNull.Value ? null : objRow[congs_KnowledgesGraph.Memo].ToString().Trim(); //备注
objgs_KnowledgesGraphEN.GraphTypeId = objRow[congs_KnowledgesGraph.GraphTypeId] == DBNull.Value ? null : objRow[congs_KnowledgesGraph.GraphTypeId].ToString().Trim(); //图谱类型Id
objgs_KnowledgesGraphEN.IsDisplay = clsEntityBase2.TransNullToBool_S(objRow[congs_KnowledgesGraph.IsDisplay].ToString().Trim()); //是否显示
objgs_KnowledgesGraphEN.IsExtend = clsEntityBase2.TransNullToBool_S(objRow[congs_KnowledgesGraph.IsExtend].ToString().Trim()); //是否扩展
objgs_KnowledgesGraphEN.IsRecommend = clsEntityBase2.TransNullToBool_S(objRow[congs_KnowledgesGraph.IsRecommend].ToString().Trim()); //是否推荐
objgs_KnowledgesGraphEN.IsAnswer = clsEntityBase2.TransNullToBool_S(objRow[congs_KnowledgesGraph.IsAnswer].ToString().Trim()); //是否回答
objgs_KnowledgesGraphEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[congs_KnowledgesGraph.IsSubmit].ToString().Trim()); //是否提交
objgs_KnowledgesGraphEN.StartTime = objRow[congs_KnowledgesGraph.StartTime] == DBNull.Value ? null : objRow[congs_KnowledgesGraph.StartTime].ToString().Trim(); //开始时间
objgs_KnowledgesGraphEN.SubmitTime = objRow[congs_KnowledgesGraph.SubmitTime] == DBNull.Value ? null : objRow[congs_KnowledgesGraph.SubmitTime].ToString().Trim(); //提交时间
objgs_KnowledgesGraphEN.TakeUpTime = objRow[congs_KnowledgesGraph.TakeUpTime] == DBNull.Value ? null : objRow[congs_KnowledgesGraph.TakeUpTime].ToString().Trim(); //耗时
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objgs_KnowledgesGraphEN.KnowledgeGraphId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objgs_KnowledgesGraphEN);
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
public static List<clsgs_KnowledgesGraphEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsgs_KnowledgesGraphEN> arrObjLst = new List<clsgs_KnowledgesGraphEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsgs_KnowledgesGraphEN objgs_KnowledgesGraphEN = new clsgs_KnowledgesGraphEN();
try
{
objgs_KnowledgesGraphEN.KnowledgeGraphId = objRow[congs_KnowledgesGraph.KnowledgeGraphId].ToString().Trim(); //知识点图Id
objgs_KnowledgesGraphEN.KnowledgeGraphName = objRow[congs_KnowledgesGraph.KnowledgeGraphName] == DBNull.Value ? null : objRow[congs_KnowledgesGraph.KnowledgeGraphName].ToString().Trim(); //连连看图名
objgs_KnowledgesGraphEN.IdCurrEduCls = objRow[congs_KnowledgesGraph.IdCurrEduCls] == DBNull.Value ? null : objRow[congs_KnowledgesGraph.IdCurrEduCls].ToString().Trim(); //教学班流水号
objgs_KnowledgesGraphEN.CourseId = objRow[congs_KnowledgesGraph.CourseId] == DBNull.Value ? null : objRow[congs_KnowledgesGraph.CourseId].ToString().Trim(); //课程Id
objgs_KnowledgesGraphEN.CreateUser = objRow[congs_KnowledgesGraph.CreateUser] == DBNull.Value ? null : objRow[congs_KnowledgesGraph.CreateUser].ToString().Trim(); //建立用户
objgs_KnowledgesGraphEN.UpdDate = objRow[congs_KnowledgesGraph.UpdDate] == DBNull.Value ? null : objRow[congs_KnowledgesGraph.UpdDate].ToString().Trim(); //修改日期
objgs_KnowledgesGraphEN.UpdUser = objRow[congs_KnowledgesGraph.UpdUser] == DBNull.Value ? null : objRow[congs_KnowledgesGraph.UpdUser].ToString().Trim(); //修改人
objgs_KnowledgesGraphEN.Memo = objRow[congs_KnowledgesGraph.Memo] == DBNull.Value ? null : objRow[congs_KnowledgesGraph.Memo].ToString().Trim(); //备注
objgs_KnowledgesGraphEN.GraphTypeId = objRow[congs_KnowledgesGraph.GraphTypeId] == DBNull.Value ? null : objRow[congs_KnowledgesGraph.GraphTypeId].ToString().Trim(); //图谱类型Id
objgs_KnowledgesGraphEN.IsDisplay = clsEntityBase2.TransNullToBool_S(objRow[congs_KnowledgesGraph.IsDisplay].ToString().Trim()); //是否显示
objgs_KnowledgesGraphEN.IsExtend = clsEntityBase2.TransNullToBool_S(objRow[congs_KnowledgesGraph.IsExtend].ToString().Trim()); //是否扩展
objgs_KnowledgesGraphEN.IsRecommend = clsEntityBase2.TransNullToBool_S(objRow[congs_KnowledgesGraph.IsRecommend].ToString().Trim()); //是否推荐
objgs_KnowledgesGraphEN.IsAnswer = clsEntityBase2.TransNullToBool_S(objRow[congs_KnowledgesGraph.IsAnswer].ToString().Trim()); //是否回答
objgs_KnowledgesGraphEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[congs_KnowledgesGraph.IsSubmit].ToString().Trim()); //是否提交
objgs_KnowledgesGraphEN.StartTime = objRow[congs_KnowledgesGraph.StartTime] == DBNull.Value ? null : objRow[congs_KnowledgesGraph.StartTime].ToString().Trim(); //开始时间
objgs_KnowledgesGraphEN.SubmitTime = objRow[congs_KnowledgesGraph.SubmitTime] == DBNull.Value ? null : objRow[congs_KnowledgesGraph.SubmitTime].ToString().Trim(); //提交时间
objgs_KnowledgesGraphEN.TakeUpTime = objRow[congs_KnowledgesGraph.TakeUpTime] == DBNull.Value ? null : objRow[congs_KnowledgesGraph.TakeUpTime].ToString().Trim(); //耗时
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objgs_KnowledgesGraphEN.KnowledgeGraphId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objgs_KnowledgesGraphEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsgs_KnowledgesGraphEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsgs_KnowledgesGraphEN> arrObjLst = new List<clsgs_KnowledgesGraphEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsgs_KnowledgesGraphEN objgs_KnowledgesGraphEN = new clsgs_KnowledgesGraphEN();
try
{
objgs_KnowledgesGraphEN.KnowledgeGraphId = objRow[congs_KnowledgesGraph.KnowledgeGraphId].ToString().Trim(); //知识点图Id
objgs_KnowledgesGraphEN.KnowledgeGraphName = objRow[congs_KnowledgesGraph.KnowledgeGraphName] == DBNull.Value ? null : objRow[congs_KnowledgesGraph.KnowledgeGraphName].ToString().Trim(); //连连看图名
objgs_KnowledgesGraphEN.IdCurrEduCls = objRow[congs_KnowledgesGraph.IdCurrEduCls] == DBNull.Value ? null : objRow[congs_KnowledgesGraph.IdCurrEduCls].ToString().Trim(); //教学班流水号
objgs_KnowledgesGraphEN.CourseId = objRow[congs_KnowledgesGraph.CourseId] == DBNull.Value ? null : objRow[congs_KnowledgesGraph.CourseId].ToString().Trim(); //课程Id
objgs_KnowledgesGraphEN.CreateUser = objRow[congs_KnowledgesGraph.CreateUser] == DBNull.Value ? null : objRow[congs_KnowledgesGraph.CreateUser].ToString().Trim(); //建立用户
objgs_KnowledgesGraphEN.UpdDate = objRow[congs_KnowledgesGraph.UpdDate] == DBNull.Value ? null : objRow[congs_KnowledgesGraph.UpdDate].ToString().Trim(); //修改日期
objgs_KnowledgesGraphEN.UpdUser = objRow[congs_KnowledgesGraph.UpdUser] == DBNull.Value ? null : objRow[congs_KnowledgesGraph.UpdUser].ToString().Trim(); //修改人
objgs_KnowledgesGraphEN.Memo = objRow[congs_KnowledgesGraph.Memo] == DBNull.Value ? null : objRow[congs_KnowledgesGraph.Memo].ToString().Trim(); //备注
objgs_KnowledgesGraphEN.GraphTypeId = objRow[congs_KnowledgesGraph.GraphTypeId] == DBNull.Value ? null : objRow[congs_KnowledgesGraph.GraphTypeId].ToString().Trim(); //图谱类型Id
objgs_KnowledgesGraphEN.IsDisplay = clsEntityBase2.TransNullToBool_S(objRow[congs_KnowledgesGraph.IsDisplay].ToString().Trim()); //是否显示
objgs_KnowledgesGraphEN.IsExtend = clsEntityBase2.TransNullToBool_S(objRow[congs_KnowledgesGraph.IsExtend].ToString().Trim()); //是否扩展
objgs_KnowledgesGraphEN.IsRecommend = clsEntityBase2.TransNullToBool_S(objRow[congs_KnowledgesGraph.IsRecommend].ToString().Trim()); //是否推荐
objgs_KnowledgesGraphEN.IsAnswer = clsEntityBase2.TransNullToBool_S(objRow[congs_KnowledgesGraph.IsAnswer].ToString().Trim()); //是否回答
objgs_KnowledgesGraphEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[congs_KnowledgesGraph.IsSubmit].ToString().Trim()); //是否提交
objgs_KnowledgesGraphEN.StartTime = objRow[congs_KnowledgesGraph.StartTime] == DBNull.Value ? null : objRow[congs_KnowledgesGraph.StartTime].ToString().Trim(); //开始时间
objgs_KnowledgesGraphEN.SubmitTime = objRow[congs_KnowledgesGraph.SubmitTime] == DBNull.Value ? null : objRow[congs_KnowledgesGraph.SubmitTime].ToString().Trim(); //提交时间
objgs_KnowledgesGraphEN.TakeUpTime = objRow[congs_KnowledgesGraph.TakeUpTime] == DBNull.Value ? null : objRow[congs_KnowledgesGraph.TakeUpTime].ToString().Trim(); //耗时
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objgs_KnowledgesGraphEN.KnowledgeGraphId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objgs_KnowledgesGraphEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objgs_KnowledgesGraphEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool Getgs_KnowledgesGraph(ref clsgs_KnowledgesGraphEN objgs_KnowledgesGraphEN)
{
bool bolResult = gs_KnowledgesGraphDA.Getgs_KnowledgesGraph(ref objgs_KnowledgesGraphEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "strKnowledgeGraphId">表关键字</param>
 /// <returns>表对象</returns>
public static clsgs_KnowledgesGraphEN GetObjByKnowledgeGraphId(string strKnowledgeGraphId)
{
if (strKnowledgeGraphId.IndexOf(' ') >=0)
{
var strMsg = string.Format("(errid:Busi000079)在表中,关键字[strKnowledgeGraphId]中不能有空格!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
if (string.IsNullOrEmpty(strKnowledgeGraphId) == true)
{
var strMsg = string.Format("(errid:Busi000020)在表中,关键字[strKnowledgeGraphId]不能为空!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
clsgs_KnowledgesGraphEN objgs_KnowledgesGraphEN = gs_KnowledgesGraphDA.GetObjByKnowledgeGraphId(strKnowledgeGraphId);
return objgs_KnowledgesGraphEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsgs_KnowledgesGraphEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsgs_KnowledgesGraphEN objgs_KnowledgesGraphEN = gs_KnowledgesGraphDA.GetFirstObj(strWhereCond);
 return objgs_KnowledgesGraphEN;
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
public static clsgs_KnowledgesGraphEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsgs_KnowledgesGraphEN objgs_KnowledgesGraphEN = gs_KnowledgesGraphDA.GetObjByDataRow(objRow);
 return objgs_KnowledgesGraphEN;
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
public static clsgs_KnowledgesGraphEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsgs_KnowledgesGraphEN objgs_KnowledgesGraphEN = gs_KnowledgesGraphDA.GetObjByDataRow(objRow);
 return objgs_KnowledgesGraphEN;
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
 /// <param name = "strKnowledgeGraphId">所给的关键字</param>
 /// <param name = "lstgs_KnowledgesGraphObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsgs_KnowledgesGraphEN GetObjByKnowledgeGraphIdFromList(string strKnowledgeGraphId, List<clsgs_KnowledgesGraphEN> lstgs_KnowledgesGraphObjLst)
{
foreach (clsgs_KnowledgesGraphEN objgs_KnowledgesGraphEN in lstgs_KnowledgesGraphObjLst)
{
if (objgs_KnowledgesGraphEN.KnowledgeGraphId == strKnowledgeGraphId)
{
return objgs_KnowledgesGraphEN;
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
 string strMaxKnowledgeGraphId;
 try
 {
 strMaxKnowledgeGraphId = clsgs_KnowledgesGraphDA.GetMaxStrId();
 return strMaxKnowledgeGraphId;
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
 string strKnowledgeGraphId;
 try
 {
 strKnowledgeGraphId = new clsgs_KnowledgesGraphDA().GetFirstID(strWhereCond);
 return strKnowledgeGraphId;
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
 arrList = gs_KnowledgesGraphDA.GetID(strWhereCond);
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
bool bolIsExist = gs_KnowledgesGraphDA.IsExistCondRec(strWhereCond);
return bolIsExist;
}

 /// <summary>
 /// 判断当前表中是否存在给定关键字值的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExist)
 /// </summary>
 /// <param name = "strKnowledgeGraphId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public static bool IsExist(string strKnowledgeGraphId)
{
if (string.IsNullOrEmpty(strKnowledgeGraphId) == true)
{
var strMsg = string.Format("(errid:Busi000027)在表中,关键字[strKnowledgeGraphId]不能为空!!(from {0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
//检测记录是否存在
bool bolIsExist = gs_KnowledgesGraphDA.IsExist(strKnowledgeGraphId);
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
 bolIsExist = clsgs_KnowledgesGraphDA.IsExistTable();
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
 bolIsExist = gs_KnowledgesGraphDA.IsExistTable(strTabName);
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
 /// <param name = "objgs_KnowledgesGraphEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecordBySql2(clsgs_KnowledgesGraphEN objgs_KnowledgesGraphEN, bool bolIsNeedCheckUniqueness=true)
{
if (bolIsNeedCheckUniqueness == true && objgs_KnowledgesGraphEN.CheckUniqueness() == false)
{
var strMsg = string.Format("记录已经存在!连连看图名 = [{0}],课程Id = [{1}],建立用户 = [{2}]的数据已经存在!(in clsgs_KnowledgesGraphBL.AddNewRecordBySql2)", objgs_KnowledgesGraphEN.KnowledgeGraphName,objgs_KnowledgesGraphEN.CourseId,objgs_KnowledgesGraphEN.CreateUser);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objgs_KnowledgesGraphEN.KnowledgeGraphId) == true || clsgs_KnowledgesGraphBL.IsExist(objgs_KnowledgesGraphEN.KnowledgeGraphId) == true)
 {
     objgs_KnowledgesGraphEN.KnowledgeGraphId = clsgs_KnowledgesGraphBL.GetMaxStrId_S();
 }
bool bolResult = gs_KnowledgesGraphDA.AddNewRecordBySQL2(objgs_KnowledgesGraphEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsgs_KnowledgesGraphBL.ReFreshCache(objgs_KnowledgesGraphEN.CourseId);

if (clsgs_KnowledgesGraphBL.relatedActions != null)
{
clsgs_KnowledgesGraphBL.relatedActions.UpdRelaTabDate(objgs_KnowledgesGraphEN.KnowledgeGraphId, "SetUpdDate");
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
 /// <param name = "objgs_KnowledgesGraphEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordBySql2WithReturnKey(clsgs_KnowledgesGraphEN objgs_KnowledgesGraphEN, bool bolIsNeedCheckUniqueness=true)
{
if (bolIsNeedCheckUniqueness == true && objgs_KnowledgesGraphEN.CheckUniqueness() == false)
{
var strMsg = string.Format("记录已经存在!连连看图名 = [{0}],课程Id = [{1}],建立用户 = [{2}]的数据已经存在!(in clsgs_KnowledgesGraphBL.AddNewRecordBySql2WithReturnKey)", objgs_KnowledgesGraphEN.KnowledgeGraphName,objgs_KnowledgesGraphEN.CourseId,objgs_KnowledgesGraphEN.CreateUser);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objgs_KnowledgesGraphEN.KnowledgeGraphId) == true || clsgs_KnowledgesGraphBL.IsExist(objgs_KnowledgesGraphEN.KnowledgeGraphId) == true)
 {
     objgs_KnowledgesGraphEN.KnowledgeGraphId = clsgs_KnowledgesGraphBL.GetMaxStrId_S();
 }
string strKey = gs_KnowledgesGraphDA.AddNewRecordBySQL2WithReturnKey(objgs_KnowledgesGraphEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsgs_KnowledgesGraphBL.ReFreshCache(objgs_KnowledgesGraphEN.CourseId);

if (clsgs_KnowledgesGraphBL.relatedActions != null)
{
clsgs_KnowledgesGraphBL.relatedActions.UpdRelaTabDate(objgs_KnowledgesGraphEN.KnowledgeGraphId, "SetUpdDate");
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
 /// <param name = "objgs_KnowledgesGraphEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(clsgs_KnowledgesGraphEN objgs_KnowledgesGraphEN)
{
try
{
bool bolResult = gs_KnowledgesGraphDA.Update(objgs_KnowledgesGraphEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsgs_KnowledgesGraphBL.ReFreshCache(objgs_KnowledgesGraphEN.CourseId);

if (clsgs_KnowledgesGraphBL.relatedActions != null)
{
clsgs_KnowledgesGraphBL.relatedActions.UpdRelaTabDate(objgs_KnowledgesGraphEN.KnowledgeGraphId, "SetUpdDate");
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
 /// <param name = "objgs_KnowledgesGraphEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateBySql2(clsgs_KnowledgesGraphEN objgs_KnowledgesGraphEN)
{
 if (string.IsNullOrEmpty(objgs_KnowledgesGraphEN.KnowledgeGraphId) == true)
 {
var strMsg = string.Format("(errid:Busi000065)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = gs_KnowledgesGraphDA.UpdateBySql2(objgs_KnowledgesGraphEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsgs_KnowledgesGraphBL.ReFreshCache(objgs_KnowledgesGraphEN.CourseId);

if (clsgs_KnowledgesGraphBL.relatedActions != null)
{
clsgs_KnowledgesGraphBL.relatedActions.UpdRelaTabDate(objgs_KnowledgesGraphEN.KnowledgeGraphId, "SetUpdDate");
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
 /// <param name = "strKnowledgeGraphId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int DelRecord(string strKnowledgeGraphId)
{
try
{
 clsgs_KnowledgesGraphEN objgs_KnowledgesGraphEN = clsgs_KnowledgesGraphBL.GetObjByKnowledgeGraphId(strKnowledgeGraphId);

if (clsgs_KnowledgesGraphBL.relatedActions != null)
{
clsgs_KnowledgesGraphBL.relatedActions.UpdRelaTabDate(objgs_KnowledgesGraphEN.KnowledgeGraphId, "SetUpdDate");
}
if (objgs_KnowledgesGraphEN != null)
{
int intRecNum = gs_KnowledgesGraphDA.DelRecord(strKnowledgeGraphId);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
ReFreshCache(objgs_KnowledgesGraphEN.CourseId);
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
/// <param name="strKnowledgeGraphId">表关键字</param>
 /// <param name = "strCourseId">缓存的分类字段</param>
/// <returns></returns>
public static bool DelRecordEx(string strKnowledgeGraphId , string strCourseId)
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsgs_KnowledgesGraphDA.GetSpecSQLObj();
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
//删除与表:[gs_KnowledgesGraph]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//congs_KnowledgesGraph.KnowledgeGraphId,
//strKnowledgeGraphId);
//        clsgs_KnowledgesGraphBL.Delgs_KnowledgesGraphsByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsgs_KnowledgesGraphBL.DelRecord(strKnowledgeGraphId, strCourseId, objConnection, objSqlTransaction);
objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsgs_KnowledgesGraphBLEx", "DelRecordEx", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("扩展删除记录出错:{0}!keyId = {1}.({2})",
objException.Message,
strKnowledgeGraphId, clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "strKnowledgeGraphId">给定的关键字值</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回删除是否成功?</returns>
public static bool DelRecord(string strKnowledgeGraphId, string strCourseId, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
if (clsgs_KnowledgesGraphBL.relatedActions != null)
{
clsgs_KnowledgesGraphBL.relatedActions.UpdRelaTabDate(strKnowledgeGraphId, "UpdRelaTabDate");
}
bool bolResult = gs_KnowledgesGraphDA.DelRecord(strKnowledgeGraphId,objSqlConnection,objSqlTransaction);
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
 /// <param name = "arrKnowledgeGraphIdLst">给定的关键字值列表</param>
 /// <returns>返回删除的记录数</returns>
public static int Delgs_KnowledgesGraphs(List<string> arrKnowledgeGraphIdLst)
{
if (arrKnowledgeGraphIdLst.Count == 0) return 0;
try
{
if (clsgs_KnowledgesGraphBL.relatedActions != null)
{
foreach (var strKnowledgeGraphId in arrKnowledgeGraphIdLst)
{
clsgs_KnowledgesGraphBL.relatedActions.UpdRelaTabDate(strKnowledgeGraphId, "UpdRelaTabDate");
}
}
 clsgs_KnowledgesGraphEN objgs_KnowledgesGraphEN = clsgs_KnowledgesGraphBL.GetObjByKnowledgeGraphId(arrKnowledgeGraphIdLst[0]);
int intDelRecNum = gs_KnowledgesGraphDA.Delgs_KnowledgesGraph(arrKnowledgeGraphIdLst);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
ReFreshCache(objgs_KnowledgesGraphEN.CourseId);
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
public static int Delgs_KnowledgesGraphsByCond(string strWhereCond)
{
try
{
if (clsgs_KnowledgesGraphBL.relatedActions != null)
{
List<string> arrKnowledgeGraphId = GetPrimaryKeyID_S(strWhereCond);
foreach (var strKnowledgeGraphId in arrKnowledgeGraphId)
{
clsgs_KnowledgesGraphBL.relatedActions.UpdRelaTabDate(strKnowledgeGraphId, "UpdRelaTabDate");
}
}
List<string> arrCourseId = GetFldValue(congs_KnowledgesGraph.CourseId, strWhereCond);
int intRecNum = gs_KnowledgesGraphDA.Delgs_KnowledgesGraph(strWhereCond);
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
/// 这里仅仅是演示函数,使用时请复制到扩展类:[gs_KnowledgesGraph]中改名为:[DelRecord4MultiTabEx]使用
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DelRecord4MultiTab)
/// </summary>
/// <param name="strKnowledgeGraphId">表关键字</param>
 /// <param name = "strCourseId">缓存的分类字段</param>
/// <returns></returns>
public static bool DelRecord4MultiTab(string strKnowledgeGraphId, string strCourseId)
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsgs_KnowledgesGraphDA.GetSpecSQLObj();
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
//删除与表:[gs_KnowledgesGraph]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conStudent.id_College,
//strid_College);
//        clsStudentBL.DelStudentsByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsgs_KnowledgesGraphBL.DelRecord(strKnowledgeGraphId, strCourseId, objConnection, objSqlTransaction);
                objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsgs_KnowledgesGraphBL", "DelRecord4MultiTab", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("删除多表记录出错:{0}!keyId = {1}.({2})",
objException.Message,
strKnowledgeGraphId, clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "objgs_KnowledgesGraphENS">源对象</param>
 /// <param name = "objgs_KnowledgesGraphENT">目标对象</param>
 public static void CopyTo(clsgs_KnowledgesGraphEN objgs_KnowledgesGraphENS, clsgs_KnowledgesGraphEN objgs_KnowledgesGraphENT)
{
try
{
objgs_KnowledgesGraphENT.KnowledgeGraphId = objgs_KnowledgesGraphENS.KnowledgeGraphId; //知识点图Id
objgs_KnowledgesGraphENT.KnowledgeGraphName = objgs_KnowledgesGraphENS.KnowledgeGraphName; //连连看图名
objgs_KnowledgesGraphENT.IdCurrEduCls = objgs_KnowledgesGraphENS.IdCurrEduCls; //教学班流水号
objgs_KnowledgesGraphENT.CourseId = objgs_KnowledgesGraphENS.CourseId; //课程Id
objgs_KnowledgesGraphENT.CreateUser = objgs_KnowledgesGraphENS.CreateUser; //建立用户
objgs_KnowledgesGraphENT.UpdDate = objgs_KnowledgesGraphENS.UpdDate; //修改日期
objgs_KnowledgesGraphENT.UpdUser = objgs_KnowledgesGraphENS.UpdUser; //修改人
objgs_KnowledgesGraphENT.Memo = objgs_KnowledgesGraphENS.Memo; //备注
objgs_KnowledgesGraphENT.GraphTypeId = objgs_KnowledgesGraphENS.GraphTypeId; //图谱类型Id
objgs_KnowledgesGraphENT.IsDisplay = objgs_KnowledgesGraphENS.IsDisplay; //是否显示
objgs_KnowledgesGraphENT.IsExtend = objgs_KnowledgesGraphENS.IsExtend; //是否扩展
objgs_KnowledgesGraphENT.IsRecommend = objgs_KnowledgesGraphENS.IsRecommend; //是否推荐
objgs_KnowledgesGraphENT.IsAnswer = objgs_KnowledgesGraphENS.IsAnswer; //是否回答
objgs_KnowledgesGraphENT.IsSubmit = objgs_KnowledgesGraphENS.IsSubmit; //是否提交
objgs_KnowledgesGraphENT.StartTime = objgs_KnowledgesGraphENS.StartTime; //开始时间
objgs_KnowledgesGraphENT.SubmitTime = objgs_KnowledgesGraphENS.SubmitTime; //提交时间
objgs_KnowledgesGraphENT.TakeUpTime = objgs_KnowledgesGraphENS.TakeUpTime; //耗时
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
 /// <param name = "objgs_KnowledgesGraphEN">源简化对象</param>
 public static void SetUpdFlag(clsgs_KnowledgesGraphEN objgs_KnowledgesGraphEN)
{
try
{
objgs_KnowledgesGraphEN.ClearUpdateState();
   string strsfUpdFldSetStr = objgs_KnowledgesGraphEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(congs_KnowledgesGraph.KnowledgeGraphId, new clsStrCompareIgnoreCase())  ==  true)
{
objgs_KnowledgesGraphEN.KnowledgeGraphId = objgs_KnowledgesGraphEN.KnowledgeGraphId; //知识点图Id
}
if (arrFldSet.Contains(congs_KnowledgesGraph.KnowledgeGraphName, new clsStrCompareIgnoreCase())  ==  true)
{
objgs_KnowledgesGraphEN.KnowledgeGraphName = objgs_KnowledgesGraphEN.KnowledgeGraphName == "[null]" ? null :  objgs_KnowledgesGraphEN.KnowledgeGraphName; //连连看图名
}
if (arrFldSet.Contains(congs_KnowledgesGraph.IdCurrEduCls, new clsStrCompareIgnoreCase())  ==  true)
{
objgs_KnowledgesGraphEN.IdCurrEduCls = objgs_KnowledgesGraphEN.IdCurrEduCls == "[null]" ? null :  objgs_KnowledgesGraphEN.IdCurrEduCls; //教学班流水号
}
if (arrFldSet.Contains(congs_KnowledgesGraph.CourseId, new clsStrCompareIgnoreCase())  ==  true)
{
objgs_KnowledgesGraphEN.CourseId = objgs_KnowledgesGraphEN.CourseId == "[null]" ? null :  objgs_KnowledgesGraphEN.CourseId; //课程Id
}
if (arrFldSet.Contains(congs_KnowledgesGraph.CreateUser, new clsStrCompareIgnoreCase())  ==  true)
{
objgs_KnowledgesGraphEN.CreateUser = objgs_KnowledgesGraphEN.CreateUser == "[null]" ? null :  objgs_KnowledgesGraphEN.CreateUser; //建立用户
}
if (arrFldSet.Contains(congs_KnowledgesGraph.UpdDate, new clsStrCompareIgnoreCase())  ==  true)
{
objgs_KnowledgesGraphEN.UpdDate = objgs_KnowledgesGraphEN.UpdDate == "[null]" ? null :  objgs_KnowledgesGraphEN.UpdDate; //修改日期
}
if (arrFldSet.Contains(congs_KnowledgesGraph.UpdUser, new clsStrCompareIgnoreCase())  ==  true)
{
objgs_KnowledgesGraphEN.UpdUser = objgs_KnowledgesGraphEN.UpdUser == "[null]" ? null :  objgs_KnowledgesGraphEN.UpdUser; //修改人
}
if (arrFldSet.Contains(congs_KnowledgesGraph.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objgs_KnowledgesGraphEN.Memo = objgs_KnowledgesGraphEN.Memo == "[null]" ? null :  objgs_KnowledgesGraphEN.Memo; //备注
}
if (arrFldSet.Contains(congs_KnowledgesGraph.GraphTypeId, new clsStrCompareIgnoreCase())  ==  true)
{
objgs_KnowledgesGraphEN.GraphTypeId = objgs_KnowledgesGraphEN.GraphTypeId == "[null]" ? null :  objgs_KnowledgesGraphEN.GraphTypeId; //图谱类型Id
}
if (arrFldSet.Contains(congs_KnowledgesGraph.IsDisplay, new clsStrCompareIgnoreCase())  ==  true)
{
objgs_KnowledgesGraphEN.IsDisplay = objgs_KnowledgesGraphEN.IsDisplay; //是否显示
}
if (arrFldSet.Contains(congs_KnowledgesGraph.IsExtend, new clsStrCompareIgnoreCase())  ==  true)
{
objgs_KnowledgesGraphEN.IsExtend = objgs_KnowledgesGraphEN.IsExtend; //是否扩展
}
if (arrFldSet.Contains(congs_KnowledgesGraph.IsRecommend, new clsStrCompareIgnoreCase())  ==  true)
{
objgs_KnowledgesGraphEN.IsRecommend = objgs_KnowledgesGraphEN.IsRecommend; //是否推荐
}
if (arrFldSet.Contains(congs_KnowledgesGraph.IsAnswer, new clsStrCompareIgnoreCase())  ==  true)
{
objgs_KnowledgesGraphEN.IsAnswer = objgs_KnowledgesGraphEN.IsAnswer; //是否回答
}
if (arrFldSet.Contains(congs_KnowledgesGraph.IsSubmit, new clsStrCompareIgnoreCase())  ==  true)
{
objgs_KnowledgesGraphEN.IsSubmit = objgs_KnowledgesGraphEN.IsSubmit; //是否提交
}
if (arrFldSet.Contains(congs_KnowledgesGraph.StartTime, new clsStrCompareIgnoreCase())  ==  true)
{
objgs_KnowledgesGraphEN.StartTime = objgs_KnowledgesGraphEN.StartTime == "[null]" ? null :  objgs_KnowledgesGraphEN.StartTime; //开始时间
}
if (arrFldSet.Contains(congs_KnowledgesGraph.SubmitTime, new clsStrCompareIgnoreCase())  ==  true)
{
objgs_KnowledgesGraphEN.SubmitTime = objgs_KnowledgesGraphEN.SubmitTime == "[null]" ? null :  objgs_KnowledgesGraphEN.SubmitTime; //提交时间
}
if (arrFldSet.Contains(congs_KnowledgesGraph.TakeUpTime, new clsStrCompareIgnoreCase())  ==  true)
{
objgs_KnowledgesGraphEN.TakeUpTime = objgs_KnowledgesGraphEN.TakeUpTime == "[null]" ? null :  objgs_KnowledgesGraphEN.TakeUpTime; //耗时
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
 /// <param name = "objgs_KnowledgesGraphEN">源简化对象</param>
 public static void AccessFldValueNull(clsgs_KnowledgesGraphEN objgs_KnowledgesGraphEN)
{
try
{
if (objgs_KnowledgesGraphEN.KnowledgeGraphName == "[null]") objgs_KnowledgesGraphEN.KnowledgeGraphName = null; //连连看图名
if (objgs_KnowledgesGraphEN.IdCurrEduCls == "[null]") objgs_KnowledgesGraphEN.IdCurrEduCls = null; //教学班流水号
if (objgs_KnowledgesGraphEN.CourseId == "[null]") objgs_KnowledgesGraphEN.CourseId = null; //课程Id
if (objgs_KnowledgesGraphEN.CreateUser == "[null]") objgs_KnowledgesGraphEN.CreateUser = null; //建立用户
if (objgs_KnowledgesGraphEN.UpdDate == "[null]") objgs_KnowledgesGraphEN.UpdDate = null; //修改日期
if (objgs_KnowledgesGraphEN.UpdUser == "[null]") objgs_KnowledgesGraphEN.UpdUser = null; //修改人
if (objgs_KnowledgesGraphEN.Memo == "[null]") objgs_KnowledgesGraphEN.Memo = null; //备注
if (objgs_KnowledgesGraphEN.GraphTypeId == "[null]") objgs_KnowledgesGraphEN.GraphTypeId = null; //图谱类型Id
if (objgs_KnowledgesGraphEN.StartTime == "[null]") objgs_KnowledgesGraphEN.StartTime = null; //开始时间
if (objgs_KnowledgesGraphEN.SubmitTime == "[null]") objgs_KnowledgesGraphEN.SubmitTime = null; //提交时间
if (objgs_KnowledgesGraphEN.TakeUpTime == "[null]") objgs_KnowledgesGraphEN.TakeUpTime = null; //耗时
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
public static void CheckPropertyNew(clsgs_KnowledgesGraphEN objgs_KnowledgesGraphEN)
{
 gs_KnowledgesGraphDA.CheckPropertyNew(objgs_KnowledgesGraphEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(clsgs_KnowledgesGraphEN objgs_KnowledgesGraphEN)
{
 gs_KnowledgesGraphDA.CheckProperty4Condition(objgs_KnowledgesGraphEN);
 }


 #endregion 检查对象属性


 #region 绑定下拉框

 /// <summary>
 /// 绑定基于Web的下拉框-使用Cache
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DdlBindFunctionCache)
 /// </summary>
 /// <param name = "objDDL">需要绑定当前表的下拉框</param>
public static void BindDdl_KnowledgeGraphIdCache(System.Web.UI.WebControls.DropDownList objDDL, string strCourseId)
{
//为数据源于表的下拉框设置内容
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[知识点逻辑图]...","0");
List<clsgs_KnowledgesGraphEN> arrgs_KnowledgesGraphObjLst = GetAllgs_KnowledgesGraphObjLstCache(strCourseId); 
objDDL.DataValueField = congs_KnowledgesGraph.KnowledgeGraphId;
objDDL.DataTextField = congs_KnowledgesGraph.KnowledgeGraphName;
objDDL.DataSource = arrgs_KnowledgesGraphObjLst;
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
if (clsgs_KnowledgesGraphBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsgs_KnowledgesGraphBL没有刷新缓存机制(clsgs_KnowledgesGraphBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by KnowledgeGraphId");
//if (arrgs_KnowledgesGraphObjLstCache == null)
//{
//arrgs_KnowledgesGraphObjLstCache = gs_KnowledgesGraphDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "strKnowledgeGraphId">所给的关键字</param>
 /// <param name = "strCourseId">缓存的分类字段</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsgs_KnowledgesGraphEN GetObjByKnowledgeGraphIdCache(string strKnowledgeGraphId, string strCourseId)
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
string strKey = string.Format("{0}_{1}", clsgs_KnowledgesGraphEN._CurrTabName, strCourseId);
List<clsgs_KnowledgesGraphEN> arrgs_KnowledgesGraphObjLstCache = GetObjLstCache(strCourseId);
IEnumerable <clsgs_KnowledgesGraphEN> arrgs_KnowledgesGraphObjLst_Sel =
arrgs_KnowledgesGraphObjLstCache
.Where(x=> x.KnowledgeGraphId == strKnowledgeGraphId 
);
if (arrgs_KnowledgesGraphObjLst_Sel.Count() == 0)
{
   clsgs_KnowledgesGraphEN obj = clsgs_KnowledgesGraphBL.GetObjByKnowledgeGraphId(strKnowledgeGraphId);
   if (obj != null)
 {
if (obj.CourseId == strCourseId)
{
CacheHelper.Remove(strKey);
     return obj;
}
else
{
string strMsg = string.Format("错误: 关键字:{0}不属于分类:{1},请检查!(In {2})", strKnowledgeGraphId, strCourseId, clsStackTrace.GetCurrClassFunction());
clsSysParaEN.objLog.WriteDebugLog(strMsg);
throw new Exception(strMsg);
}
 }
return null;
}
return arrgs_KnowledgesGraphObjLst_Sel.First();
}

 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecNameByKeyCache)
 /// </summary>
 /// <param name = "strKnowledgeGraphId">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetKnowledgeGraphNameByKnowledgeGraphIdCache(string strKnowledgeGraphId, string strCourseId)
{
if (string.IsNullOrEmpty(strKnowledgeGraphId) == true) return "";
//获取缓存中的对象列表
clsgs_KnowledgesGraphEN objgs_KnowledgesGraph = GetObjByKnowledgeGraphIdCache(strKnowledgeGraphId, strCourseId);
if (objgs_KnowledgesGraph == null) return "";
return objgs_KnowledgesGraph.KnowledgeGraphName;
}
 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecNameByKeyCache)
 /// </summary>
 /// <param name = "strKnowledgeGraphId">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetNameByKnowledgeGraphIdCache(string strKnowledgeGraphId, string strCourseId)
{
if (string.IsNullOrEmpty(strKnowledgeGraphId) == true) return "";
//获取缓存中的对象列表
clsgs_KnowledgesGraphEN objgs_KnowledgesGraph = GetObjByKnowledgeGraphIdCache(strKnowledgeGraphId, strCourseId);
if (objgs_KnowledgesGraph == null) return "";
return objgs_KnowledgesGraph.KnowledgeGraphName;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsgs_KnowledgesGraphEN> GetAllgs_KnowledgesGraphObjLstCache(string strCourseId)
{
//获取缓存中的对象列表
List<clsgs_KnowledgesGraphEN> arrgs_KnowledgesGraphObjLstCache = GetObjLstCache(strCourseId); 
return arrgs_KnowledgesGraphObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsgs_KnowledgesGraphEN> GetObjLstCache(string strCourseId)
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
string strKey = string.Format("{0}_{1}", clsgs_KnowledgesGraphEN._CurrTabName, strCourseId);
string strCondition = string.Format("CourseId='{0}'", strCourseId);
List<clsgs_KnowledgesGraphEN> arrgs_KnowledgesGraphObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst(strCondition); });
return arrgs_KnowledgesGraphObjLstCache;
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
string strKey = string.Format("{0}_{1}", clsgs_KnowledgesGraphEN._CurrTabName, strCourseId);
CacheHelper.Remove(strKey);
clsgs_KnowledgesGraphEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
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
if (clsgs_KnowledgesGraphEN._RefreshTimeLst.Count == 0) return "";
return clsgs_KnowledgesGraphEN._RefreshTimeLst[clsgs_KnowledgesGraphEN._RefreshTimeLst.Count - 1];
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
if (clsgs_KnowledgesGraphBL.objCommFun4BL != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}_{1}", clsgs_KnowledgesGraphEN._CurrTabName, strCourseId);
CacheHelper.Remove(strKey);
clsgs_KnowledgesGraphEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
clsgs_KnowledgesGraphBL.objCommFun4BL.ReFreshCache(strCourseId);
}
}


 #endregion 缓存操作


 #region 检查唯一性

 /// <summary>
 /// 获取检查唯一性条件串(Uniqueness)--gs_KnowledgesGraph(知识点逻辑图)
 /// 唯一性条件:KnowledgeGraphName_CourseId_CreateUser
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetUniquenessConditionString)
 /// </summary>
 /// <param name = "objgs_KnowledgesGraphEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(clsgs_KnowledgesGraphEN objgs_KnowledgesGraphEN)
{
//检测记录是否存在
string strResult = gs_KnowledgesGraphDA.GetUniCondStr(objgs_KnowledgesGraphEN);
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
public static string Func(string strInFldName, string strOutFldName, string strKnowledgeGraphId, string strCourseId)
{
if (strInFldName != congs_KnowledgesGraph.KnowledgeGraphId)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (congs_KnowledgesGraph.AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", congs_KnowledgesGraph.AttributeName));
throw new Exception(strMsg);
}
var objgs_KnowledgesGraph = clsgs_KnowledgesGraphBL.GetObjByKnowledgeGraphIdCache(strKnowledgeGraphId, strCourseId);
if (objgs_KnowledgesGraph == null) return "";
return objgs_KnowledgesGraph[strOutFldName].ToString();
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
int intRecCount = clsgs_KnowledgesGraphDA.GetRecCount(strTabName);
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
int intRecCount = clsgs_KnowledgesGraphDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsgs_KnowledgesGraphDA.GetRecCount();
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
int intRecCount = clsgs_KnowledgesGraphDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objgs_KnowledgesGraphCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsgs_KnowledgesGraphEN objgs_KnowledgesGraphCond)
{
 string strCourseId = objgs_KnowledgesGraphCond.CourseId;
 if (string.IsNullOrEmpty(strCourseId) == true)
{
string strMsg = string.Format("(errid:Busi000174)在表中,缓存分类字段值不能为空!(clsgs_KnowledgesGraphBL:GetRecCountByCondCache)");
throw new Exception(strMsg);
}
List<clsgs_KnowledgesGraphEN> arrObjLstCache = GetObjLstCache(strCourseId);
IEnumerable <clsgs_KnowledgesGraphEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in congs_KnowledgesGraph.AttributeName)
{
if (objgs_KnowledgesGraphCond.IsUpdated(strFldName) == false) continue;
if (objgs_KnowledgesGraphCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objgs_KnowledgesGraphCond[strFldName].ToString());
}
else
{
if (objgs_KnowledgesGraphCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objgs_KnowledgesGraphCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objgs_KnowledgesGraphCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objgs_KnowledgesGraphCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objgs_KnowledgesGraphCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objgs_KnowledgesGraphCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objgs_KnowledgesGraphCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objgs_KnowledgesGraphCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objgs_KnowledgesGraphCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objgs_KnowledgesGraphCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objgs_KnowledgesGraphCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objgs_KnowledgesGraphCond[strFldName]));
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
 List<string> arrList = clsgs_KnowledgesGraphDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = gs_KnowledgesGraphDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = gs_KnowledgesGraphDA.GetFldValueNoDistinct(strFldName, strWhereCond);
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
int intRecCount = gs_KnowledgesGraphDA.SetFldValue(strFldName, strValue, strWhereCond);
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
int intRecCount = clsgs_KnowledgesGraphDA.SetFldValue(clsgs_KnowledgesGraphEN._CurrTabName, strFldName, fltValue, strWhereCond);
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
int intRecCount = gs_KnowledgesGraphDA.SetFldValue( strFldName, intValue, strWhereCond);
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
int intRecCount = clsgs_KnowledgesGraphDA.SetFldValue(strTabName, strFldName, strValue, strWhereCond);
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
int intRecCount = clsgs_KnowledgesGraphDA.SetFldValue(strTabName, strFldName, intValue, strWhereCond);
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
int intRecCount = clsgs_KnowledgesGraphDA.SetFldValue(strTabName, strFldName, fltValue, strWhereCond);
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
  strCreateTabCode.Append("CREATE table [dbo].[gs_KnowledgesGraph] "); 
 strCreateTabCode.Append(" ( "); 
 // /**知识点图Id*/ 
 strCreateTabCode.Append(" KnowledgeGraphId char(10) primary key, "); 
 // /**连连看图名*/ 
 strCreateTabCode.Append(" KnowledgeGraphName varchar(100) Null, "); 
 // /**教学班流水号*/ 
 strCreateTabCode.Append(" IdCurrEduCls char(8) Null, "); 
 // /**课程Id*/ 
 strCreateTabCode.Append(" CourseId char(8) Null, "); 
 // /**建立用户*/ 
 strCreateTabCode.Append(" CreateUser varchar(50) Null, "); 
 // /**修改日期*/ 
 strCreateTabCode.Append(" UpdDate varchar(20) Null, "); 
 // /**修改人*/ 
 strCreateTabCode.Append(" UpdUser varchar(20) Null, "); 
 // /**备注*/ 
 strCreateTabCode.Append(" Memo varchar(1000) Null, "); 
 // /**图谱类型Id*/ 
 strCreateTabCode.Append(" GraphTypeId char(2) Null, "); 
 // /**是否显示*/ 
 strCreateTabCode.Append(" IsDisplay bit Null, "); 
 // /**是否扩展*/ 
 strCreateTabCode.Append(" IsExtend bit Null, "); 
 // /**是否推荐*/ 
 strCreateTabCode.Append(" IsRecommend bit Null, "); 
 // /**是否回答*/ 
 strCreateTabCode.Append(" IsAnswer bit Null, "); 
 // /**是否提交*/ 
 strCreateTabCode.Append(" IsSubmit bit Null, "); 
 // /**开始时间*/ 
 strCreateTabCode.Append(" StartTime varchar(20) Null, "); 
 // /**提交时间*/ 
 strCreateTabCode.Append(" SubmitTime varchar(20) Null, "); 
 // /**课程名称*/ 
 strCreateTabCode.Append(" CourseName varchar(100) Null, "); 
 // /**教学班名*/ 
 strCreateTabCode.Append(" EduClsName varchar(100) Null, "); 
 // /**耗时*/ 
 strCreateTabCode.Append(" TakeUpTime varchar(50) Null ");
 strCreateTabCode.Append(") "); 
  strCreateTabCode.Append("ON [PRIMARY] ");
  return strCreateTabCode.ToString();
}



 #endregion 表操作
}
 /// <summary>
 /// 知识点逻辑图(gs_KnowledgesGraph)
 /// 数据源类型:表
 /// (AutoGCLib.CommFun4BL4CSharp:GeneCode_This)
 /// </summary>
public class  clsCommFun4BL4gs_KnowledgesGraph : clsCommFun4BLV2
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
clsgs_KnowledgesGraphBL.ReFreshThisCache(strCourseId);
}
}

}