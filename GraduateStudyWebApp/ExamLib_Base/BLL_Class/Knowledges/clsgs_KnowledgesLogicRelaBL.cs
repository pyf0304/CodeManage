﻿
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsgs_KnowledgesLogicRelaBL
 表名:gs_KnowledgesLogicRela(01120870)
 * 版本:2024.11.13.1(服务器:WIN-SRV103-116)
 日期:2024/11/13 06:10:15
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
public static class  clsgs_KnowledgesLogicRelaBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public static clsgs_KnowledgesLogicRelaEN GetObj(this K_mId_gs_KnowledgesLogicRela myKey)
{
clsgs_KnowledgesLogicRelaEN objgs_KnowledgesLogicRelaEN = clsgs_KnowledgesLogicRelaBL.gs_KnowledgesLogicRelaDA.GetObjBymId(myKey.Value);
return objgs_KnowledgesLogicRelaEN;
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_AddNewRecord)
 /// </summary>
 /// <param name = "objgs_KnowledgesLogicRelaEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clsgs_KnowledgesLogicRelaEN objgs_KnowledgesLogicRelaEN, bool bolIsNeedCheckUniqueness = true)
{
if (bolIsNeedCheckUniqueness == true && CheckUniqueness(objgs_KnowledgesLogicRelaEN) == false)
{
var strMsg = string.Format("记录已经存在!知识点图Id = [{0}],课程知识点AId = [{1}],课程知识点BId = [{2}]的数据已经存在!(in clsgs_KnowledgesLogicRelaBL.AddNewRecord)", objgs_KnowledgesLogicRelaEN.KnowledgeGraphId,objgs_KnowledgesLogicRelaEN.CourseKnowledgeIdA,objgs_KnowledgesLogicRelaEN.CourseKnowledgeIdB);
throw new Exception(strMsg);
}
try
{
bool bolResult = clsgs_KnowledgesLogicRelaBL.gs_KnowledgesLogicRelaDA.AddNewRecordBySQL2(objgs_KnowledgesLogicRelaEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsgs_KnowledgesLogicRelaBL.ReFreshCache(objgs_KnowledgesLogicRelaEN.CourseId);

if (clsgs_KnowledgesLogicRelaBL.relatedActions != null)
{
clsgs_KnowledgesLogicRelaBL.relatedActions.UpdRelaTabDate(objgs_KnowledgesLogicRelaEN.mId, "SetUpdDate");
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
public static bool AddRecordEx(this clsgs_KnowledgesLogicRelaEN objgs_KnowledgesLogicRelaEN, bool bolIsNeedCheckUniqueness = true)
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
objgs_KnowledgesLogicRelaEN.CheckPropertyNew();
 ///5.2、检查唯一性
if (bolIsNeedCheckUniqueness == true && objgs_KnowledgesLogicRelaEN.CheckUniqueness() == false)
{
strMsg = string.Format("(知识点图Id(KnowledgeGraphId)=[{0}],课程知识点AId(CourseKnowledgeIdA)=[{1}],课程知识点BId(CourseKnowledgeIdB)=[{2}])已经存在,不能重复!", objgs_KnowledgesLogicRelaEN.KnowledgeGraphId, objgs_KnowledgesLogicRelaEN.CourseKnowledgeIdA, objgs_KnowledgesLogicRelaEN.CourseKnowledgeIdB);
throw new Exception(strMsg);
}
//6、把数据实体层的数据存贮到数据库中
objgs_KnowledgesLogicRelaEN.AddNewRecord();
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
 /// <param name = "objgs_KnowledgesLogicRelaEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordWithReturnKey(this clsgs_KnowledgesLogicRelaEN objgs_KnowledgesLogicRelaEN, bool bolIsNeedCheckUniqueness = true)
{
if (bolIsNeedCheckUniqueness == true && CheckUniqueness(objgs_KnowledgesLogicRelaEN) == false)
{
var strMsg = string.Format("记录已经存在!知识点图Id = [{0}],课程知识点AId = [{1}],课程知识点BId = [{2}]的数据已经存在!(in clsgs_KnowledgesLogicRelaBL.AddNewRecordWithReturnKey)", objgs_KnowledgesLogicRelaEN.KnowledgeGraphId,objgs_KnowledgesLogicRelaEN.CourseKnowledgeIdA,objgs_KnowledgesLogicRelaEN.CourseKnowledgeIdB);
throw new Exception(strMsg);
}
try
{
string strKey = clsgs_KnowledgesLogicRelaBL.gs_KnowledgesLogicRelaDA.AddNewRecordBySQL2WithReturnKey(objgs_KnowledgesLogicRelaEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsgs_KnowledgesLogicRelaBL.ReFreshCache(objgs_KnowledgesLogicRelaEN.CourseId);

if (clsgs_KnowledgesLogicRelaBL.relatedActions != null)
{
clsgs_KnowledgesLogicRelaBL.relatedActions.UpdRelaTabDate(objgs_KnowledgesLogicRelaEN.mId, "SetUpdDate");
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
 /// <param name = "objgs_KnowledgesLogicRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsgs_KnowledgesLogicRelaEN SetmId(this clsgs_KnowledgesLogicRelaEN objgs_KnowledgesLogicRelaEN, long lngmId, string strComparisonOp="")
	{
objgs_KnowledgesLogicRelaEN.mId = lngmId; //mId
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objgs_KnowledgesLogicRelaEN.dicFldComparisonOp.ContainsKey(congs_KnowledgesLogicRela.mId) == false)
{
objgs_KnowledgesLogicRelaEN.dicFldComparisonOp.Add(congs_KnowledgesLogicRela.mId, strComparisonOp);
}
else
{
objgs_KnowledgesLogicRelaEN.dicFldComparisonOp[congs_KnowledgesLogicRela.mId] = strComparisonOp;
}
}
return objgs_KnowledgesLogicRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objgs_KnowledgesLogicRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsgs_KnowledgesLogicRelaEN SetCourseKnowledgeIdA(this clsgs_KnowledgesLogicRelaEN objgs_KnowledgesLogicRelaEN, string strCourseKnowledgeIdA, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strCourseKnowledgeIdA, congs_KnowledgesLogicRela.CourseKnowledgeIdA);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCourseKnowledgeIdA, 8, congs_KnowledgesLogicRela.CourseKnowledgeIdA);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strCourseKnowledgeIdA, 8, congs_KnowledgesLogicRela.CourseKnowledgeIdA);
}
objgs_KnowledgesLogicRelaEN.CourseKnowledgeIdA = strCourseKnowledgeIdA; //课程知识点AId
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objgs_KnowledgesLogicRelaEN.dicFldComparisonOp.ContainsKey(congs_KnowledgesLogicRela.CourseKnowledgeIdA) == false)
{
objgs_KnowledgesLogicRelaEN.dicFldComparisonOp.Add(congs_KnowledgesLogicRela.CourseKnowledgeIdA, strComparisonOp);
}
else
{
objgs_KnowledgesLogicRelaEN.dicFldComparisonOp[congs_KnowledgesLogicRela.CourseKnowledgeIdA] = strComparisonOp;
}
}
return objgs_KnowledgesLogicRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objgs_KnowledgesLogicRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsgs_KnowledgesLogicRelaEN SetCourseKnowledgeTitleA(this clsgs_KnowledgesLogicRelaEN objgs_KnowledgesLogicRelaEN, string strCourseKnowledgeTitleA, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCourseKnowledgeTitleA, 100, congs_KnowledgesLogicRela.CourseKnowledgeTitleA);
}
objgs_KnowledgesLogicRelaEN.CourseKnowledgeTitleA = strCourseKnowledgeTitleA; //课程知识点标题A
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objgs_KnowledgesLogicRelaEN.dicFldComparisonOp.ContainsKey(congs_KnowledgesLogicRela.CourseKnowledgeTitleA) == false)
{
objgs_KnowledgesLogicRelaEN.dicFldComparisonOp.Add(congs_KnowledgesLogicRela.CourseKnowledgeTitleA, strComparisonOp);
}
else
{
objgs_KnowledgesLogicRelaEN.dicFldComparisonOp[congs_KnowledgesLogicRela.CourseKnowledgeTitleA] = strComparisonOp;
}
}
return objgs_KnowledgesLogicRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objgs_KnowledgesLogicRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsgs_KnowledgesLogicRelaEN SetCourseKnowledgeIdB(this clsgs_KnowledgesLogicRelaEN objgs_KnowledgesLogicRelaEN, string strCourseKnowledgeIdB, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strCourseKnowledgeIdB, congs_KnowledgesLogicRela.CourseKnowledgeIdB);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCourseKnowledgeIdB, 8, congs_KnowledgesLogicRela.CourseKnowledgeIdB);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strCourseKnowledgeIdB, 8, congs_KnowledgesLogicRela.CourseKnowledgeIdB);
}
objgs_KnowledgesLogicRelaEN.CourseKnowledgeIdB = strCourseKnowledgeIdB; //课程知识点BId
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objgs_KnowledgesLogicRelaEN.dicFldComparisonOp.ContainsKey(congs_KnowledgesLogicRela.CourseKnowledgeIdB) == false)
{
objgs_KnowledgesLogicRelaEN.dicFldComparisonOp.Add(congs_KnowledgesLogicRela.CourseKnowledgeIdB, strComparisonOp);
}
else
{
objgs_KnowledgesLogicRelaEN.dicFldComparisonOp[congs_KnowledgesLogicRela.CourseKnowledgeIdB] = strComparisonOp;
}
}
return objgs_KnowledgesLogicRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objgs_KnowledgesLogicRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsgs_KnowledgesLogicRelaEN SetCourseKnowledgeTitleB(this clsgs_KnowledgesLogicRelaEN objgs_KnowledgesLogicRelaEN, string strCourseKnowledgeTitleB, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCourseKnowledgeTitleB, 100, congs_KnowledgesLogicRela.CourseKnowledgeTitleB);
}
objgs_KnowledgesLogicRelaEN.CourseKnowledgeTitleB = strCourseKnowledgeTitleB; //课程知识点标题B
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objgs_KnowledgesLogicRelaEN.dicFldComparisonOp.ContainsKey(congs_KnowledgesLogicRela.CourseKnowledgeTitleB) == false)
{
objgs_KnowledgesLogicRelaEN.dicFldComparisonOp.Add(congs_KnowledgesLogicRela.CourseKnowledgeTitleB, strComparisonOp);
}
else
{
objgs_KnowledgesLogicRelaEN.dicFldComparisonOp[congs_KnowledgesLogicRela.CourseKnowledgeTitleB] = strComparisonOp;
}
}
return objgs_KnowledgesLogicRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objgs_KnowledgesLogicRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsgs_KnowledgesLogicRelaEN SetKnowledgeGraphId(this clsgs_KnowledgesLogicRelaEN objgs_KnowledgesLogicRelaEN, string strKnowledgeGraphId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strKnowledgeGraphId, 10, congs_KnowledgesLogicRela.KnowledgeGraphId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strKnowledgeGraphId, 10, congs_KnowledgesLogicRela.KnowledgeGraphId);
}
objgs_KnowledgesLogicRelaEN.KnowledgeGraphId = strKnowledgeGraphId; //知识点图Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objgs_KnowledgesLogicRelaEN.dicFldComparisonOp.ContainsKey(congs_KnowledgesLogicRela.KnowledgeGraphId) == false)
{
objgs_KnowledgesLogicRelaEN.dicFldComparisonOp.Add(congs_KnowledgesLogicRela.KnowledgeGraphId, strComparisonOp);
}
else
{
objgs_KnowledgesLogicRelaEN.dicFldComparisonOp[congs_KnowledgesLogicRela.KnowledgeGraphId] = strComparisonOp;
}
}
return objgs_KnowledgesLogicRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objgs_KnowledgesLogicRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsgs_KnowledgesLogicRelaEN SetSourceAnchor(this clsgs_KnowledgesLogicRelaEN objgs_KnowledgesLogicRelaEN, string strSourceAnchor, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strSourceAnchor, 50, congs_KnowledgesLogicRela.SourceAnchor);
}
objgs_KnowledgesLogicRelaEN.SourceAnchor = strSourceAnchor; //源锚点
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objgs_KnowledgesLogicRelaEN.dicFldComparisonOp.ContainsKey(congs_KnowledgesLogicRela.SourceAnchor) == false)
{
objgs_KnowledgesLogicRelaEN.dicFldComparisonOp.Add(congs_KnowledgesLogicRela.SourceAnchor, strComparisonOp);
}
else
{
objgs_KnowledgesLogicRelaEN.dicFldComparisonOp[congs_KnowledgesLogicRela.SourceAnchor] = strComparisonOp;
}
}
return objgs_KnowledgesLogicRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objgs_KnowledgesLogicRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsgs_KnowledgesLogicRelaEN SetTargetAnchor(this clsgs_KnowledgesLogicRelaEN objgs_KnowledgesLogicRelaEN, string strTargetAnchor, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTargetAnchor, 50, congs_KnowledgesLogicRela.TargetAnchor);
}
objgs_KnowledgesLogicRelaEN.TargetAnchor = strTargetAnchor; //目标锚点
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objgs_KnowledgesLogicRelaEN.dicFldComparisonOp.ContainsKey(congs_KnowledgesLogicRela.TargetAnchor) == false)
{
objgs_KnowledgesLogicRelaEN.dicFldComparisonOp.Add(congs_KnowledgesLogicRela.TargetAnchor, strComparisonOp);
}
else
{
objgs_KnowledgesLogicRelaEN.dicFldComparisonOp[congs_KnowledgesLogicRela.TargetAnchor] = strComparisonOp;
}
}
return objgs_KnowledgesLogicRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objgs_KnowledgesLogicRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsgs_KnowledgesLogicRelaEN SetRelaTitle(this clsgs_KnowledgesLogicRelaEN objgs_KnowledgesLogicRelaEN, string strRelaTitle, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strRelaTitle, 100, congs_KnowledgesLogicRela.RelaTitle);
}
objgs_KnowledgesLogicRelaEN.RelaTitle = strRelaTitle; //关系标题
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objgs_KnowledgesLogicRelaEN.dicFldComparisonOp.ContainsKey(congs_KnowledgesLogicRela.RelaTitle) == false)
{
objgs_KnowledgesLogicRelaEN.dicFldComparisonOp.Add(congs_KnowledgesLogicRela.RelaTitle, strComparisonOp);
}
else
{
objgs_KnowledgesLogicRelaEN.dicFldComparisonOp[congs_KnowledgesLogicRela.RelaTitle] = strComparisonOp;
}
}
return objgs_KnowledgesLogicRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objgs_KnowledgesLogicRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsgs_KnowledgesLogicRelaEN SetRelaTypeId(this clsgs_KnowledgesLogicRelaEN objgs_KnowledgesLogicRelaEN, string strRelaTypeId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strRelaTypeId, 2, congs_KnowledgesLogicRela.RelaTypeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strRelaTypeId, 2, congs_KnowledgesLogicRela.RelaTypeId);
}
objgs_KnowledgesLogicRelaEN.RelaTypeId = strRelaTypeId; //关系类型Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objgs_KnowledgesLogicRelaEN.dicFldComparisonOp.ContainsKey(congs_KnowledgesLogicRela.RelaTypeId) == false)
{
objgs_KnowledgesLogicRelaEN.dicFldComparisonOp.Add(congs_KnowledgesLogicRela.RelaTypeId, strComparisonOp);
}
else
{
objgs_KnowledgesLogicRelaEN.dicFldComparisonOp[congs_KnowledgesLogicRela.RelaTypeId] = strComparisonOp;
}
}
return objgs_KnowledgesLogicRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objgs_KnowledgesLogicRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsgs_KnowledgesLogicRelaEN SetCourseId(this clsgs_KnowledgesLogicRelaEN objgs_KnowledgesLogicRelaEN, string strCourseId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strCourseId, congs_KnowledgesLogicRela.CourseId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCourseId, 8, congs_KnowledgesLogicRela.CourseId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strCourseId, 8, congs_KnowledgesLogicRela.CourseId);
}
objgs_KnowledgesLogicRelaEN.CourseId = strCourseId; //课程Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objgs_KnowledgesLogicRelaEN.dicFldComparisonOp.ContainsKey(congs_KnowledgesLogicRela.CourseId) == false)
{
objgs_KnowledgesLogicRelaEN.dicFldComparisonOp.Add(congs_KnowledgesLogicRela.CourseId, strComparisonOp);
}
else
{
objgs_KnowledgesLogicRelaEN.dicFldComparisonOp[congs_KnowledgesLogicRela.CourseId] = strComparisonOp;
}
}
return objgs_KnowledgesLogicRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objgs_KnowledgesLogicRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsgs_KnowledgesLogicRelaEN SetUpdUser(this clsgs_KnowledgesLogicRelaEN objgs_KnowledgesLogicRelaEN, string strUpdUser, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdUser, 20, congs_KnowledgesLogicRela.UpdUser);
}
objgs_KnowledgesLogicRelaEN.UpdUser = strUpdUser; //修改人
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objgs_KnowledgesLogicRelaEN.dicFldComparisonOp.ContainsKey(congs_KnowledgesLogicRela.UpdUser) == false)
{
objgs_KnowledgesLogicRelaEN.dicFldComparisonOp.Add(congs_KnowledgesLogicRela.UpdUser, strComparisonOp);
}
else
{
objgs_KnowledgesLogicRelaEN.dicFldComparisonOp[congs_KnowledgesLogicRela.UpdUser] = strComparisonOp;
}
}
return objgs_KnowledgesLogicRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objgs_KnowledgesLogicRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsgs_KnowledgesLogicRelaEN SetUpdDate(this clsgs_KnowledgesLogicRelaEN objgs_KnowledgesLogicRelaEN, string strUpdDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdDate, 20, congs_KnowledgesLogicRela.UpdDate);
}
objgs_KnowledgesLogicRelaEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objgs_KnowledgesLogicRelaEN.dicFldComparisonOp.ContainsKey(congs_KnowledgesLogicRela.UpdDate) == false)
{
objgs_KnowledgesLogicRelaEN.dicFldComparisonOp.Add(congs_KnowledgesLogicRela.UpdDate, strComparisonOp);
}
else
{
objgs_KnowledgesLogicRelaEN.dicFldComparisonOp[congs_KnowledgesLogicRela.UpdDate] = strComparisonOp;
}
}
return objgs_KnowledgesLogicRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objgs_KnowledgesLogicRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsgs_KnowledgesLogicRelaEN SetMemo(this clsgs_KnowledgesLogicRelaEN objgs_KnowledgesLogicRelaEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, congs_KnowledgesLogicRela.Memo);
}
objgs_KnowledgesLogicRelaEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objgs_KnowledgesLogicRelaEN.dicFldComparisonOp.ContainsKey(congs_KnowledgesLogicRela.Memo) == false)
{
objgs_KnowledgesLogicRelaEN.dicFldComparisonOp.Add(congs_KnowledgesLogicRela.Memo, strComparisonOp);
}
else
{
objgs_KnowledgesLogicRelaEN.dicFldComparisonOp[congs_KnowledgesLogicRela.Memo] = strComparisonOp;
}
}
return objgs_KnowledgesLogicRelaEN;
	}

 /// <summary>
 /// 修改记录存盘到数据表中
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_UpdateRecordEx)
 /// </summary>
 /// <param name = "objgs_KnowledgesLogicRelaEN">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool UpdateRecordEx(this clsgs_KnowledgesLogicRelaEN objgs_KnowledgesLogicRelaEN)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
try
{
//1、检查传进去的对象属性是否合法
objgs_KnowledgesLogicRelaEN.CheckPropertyNew();
clsgs_KnowledgesLogicRelaEN objgs_KnowledgesLogicRelaCond = new clsgs_KnowledgesLogicRelaEN();
string strCondition = objgs_KnowledgesLogicRelaCond
.SetmId(objgs_KnowledgesLogicRelaEN.mId, "<>")
.SetKnowledgeGraphId(objgs_KnowledgesLogicRelaEN.KnowledgeGraphId, "=")
.SetCourseKnowledgeIdA(objgs_KnowledgesLogicRelaEN.CourseKnowledgeIdA, "=")
.SetCourseKnowledgeIdB(objgs_KnowledgesLogicRelaEN.CourseKnowledgeIdB, "=")
.GetCombineCondition();
objgs_KnowledgesLogicRelaEN._IsCheckProperty = true;
bool bolIsExist = clsgs_KnowledgesLogicRelaBL.IsExistRecord(strCondition);
if (bolIsExist)
{
strMsg = "(KnowledgeGraphId_CourseKnowledgeIdA_CourseKnowledgeIdB)不能重复!";
throw new Exception(strMsg);
}
//4、把数据实体层的数据存贮到数据库中
objgs_KnowledgesLogicRelaEN.Update();
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
 /// <param name = "objgs_KnowledgesLogicRela">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool EditRecordEx(this clsgs_KnowledgesLogicRelaEN objgs_KnowledgesLogicRela)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
clsgs_KnowledgesLogicRelaEN objgs_KnowledgesLogicRelaCond = new clsgs_KnowledgesLogicRelaEN();
string strCondition = objgs_KnowledgesLogicRelaCond
.SetKnowledgeGraphId(objgs_KnowledgesLogicRela.KnowledgeGraphId, "=")
.SetCourseKnowledgeIdA(objgs_KnowledgesLogicRela.CourseKnowledgeIdA, "=")
.SetCourseKnowledgeIdB(objgs_KnowledgesLogicRela.CourseKnowledgeIdB, "=")
.GetCombineCondition();
objgs_KnowledgesLogicRela._IsCheckProperty = true;
bool bolIsExist = clsgs_KnowledgesLogicRelaBL.IsExistRecord(strCondition);
if (bolIsExist)
{
objgs_KnowledgesLogicRela.mId = clsgs_KnowledgesLogicRelaBL.GetFirstID_S(strCondition);
objgs_KnowledgesLogicRela.UpdateWithCondition(strCondition);
}
else
{
objgs_KnowledgesLogicRela.AddNewRecord();
}
return true; 
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_Update)
 /// </summary>
 /// <param name = "objgs_KnowledgesLogicRelaEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsgs_KnowledgesLogicRelaEN objgs_KnowledgesLogicRelaEN)
{
 if (objgs_KnowledgesLogicRelaEN.mId == 0)
 {
string strMsg = string.Format("(errid:Busi000095)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsgs_KnowledgesLogicRelaBL.gs_KnowledgesLogicRelaDA.UpdateBySql2(objgs_KnowledgesLogicRelaEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsgs_KnowledgesLogicRelaBL.ReFreshCache(objgs_KnowledgesLogicRelaEN.CourseId);

if (clsgs_KnowledgesLogicRelaBL.relatedActions != null)
{
clsgs_KnowledgesLogicRelaBL.relatedActions.UpdRelaTabDate(objgs_KnowledgesLogicRelaEN.mId, "SetUpdDate");
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
 /// <param name = "objgs_KnowledgesLogicRelaEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsgs_KnowledgesLogicRelaEN objgs_KnowledgesLogicRelaEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (objgs_KnowledgesLogicRelaEN.mId == 0)
 {
string strMsg = string.Format("(errid:Busi000087)修改记录时关键字不能为空!(带事务处理)(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsgs_KnowledgesLogicRelaBL.gs_KnowledgesLogicRelaDA.UpdateBySql2(objgs_KnowledgesLogicRelaEN, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsgs_KnowledgesLogicRelaBL.ReFreshCache(objgs_KnowledgesLogicRelaEN.CourseId);

if (clsgs_KnowledgesLogicRelaBL.relatedActions != null)
{
clsgs_KnowledgesLogicRelaBL.relatedActions.UpdRelaTabDate(objgs_KnowledgesLogicRelaEN.mId, "SetUpdDate");
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
 /// <param name = "objgs_KnowledgesLogicRelaEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsgs_KnowledgesLogicRelaEN objgs_KnowledgesLogicRelaEN, string strWhereCond)
{
try
{
bool bolResult = clsgs_KnowledgesLogicRelaBL.gs_KnowledgesLogicRelaDA.UpdateBySqlWithCondition(objgs_KnowledgesLogicRelaEN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsgs_KnowledgesLogicRelaBL.ReFreshCache(objgs_KnowledgesLogicRelaEN.CourseId);

if (clsgs_KnowledgesLogicRelaBL.relatedActions != null)
{
clsgs_KnowledgesLogicRelaBL.relatedActions.UpdRelaTabDate(objgs_KnowledgesLogicRelaEN.mId, "SetUpdDate");
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
 /// <param name = "objgs_KnowledgesLogicRelaEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsgs_KnowledgesLogicRelaEN objgs_KnowledgesLogicRelaEN, string strWhereCond, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
bool bolResult = clsgs_KnowledgesLogicRelaBL.gs_KnowledgesLogicRelaDA.UpdateBySqlWithConditionTransaction(objgs_KnowledgesLogicRelaEN, strWhereCond, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsgs_KnowledgesLogicRelaBL.ReFreshCache(objgs_KnowledgesLogicRelaEN.CourseId);

if (clsgs_KnowledgesLogicRelaBL.relatedActions != null)
{
clsgs_KnowledgesLogicRelaBL.relatedActions.UpdRelaTabDate(objgs_KnowledgesLogicRelaEN.mId, "SetUpdDate");
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
public static int Delete(this clsgs_KnowledgesLogicRelaEN objgs_KnowledgesLogicRelaEN)
{
try
{
int intRecNum = clsgs_KnowledgesLogicRelaBL.gs_KnowledgesLogicRelaDA.DelRecord(objgs_KnowledgesLogicRelaEN.mId);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsgs_KnowledgesLogicRelaBL.ReFreshCache(objgs_KnowledgesLogicRelaEN.CourseId);

if (clsgs_KnowledgesLogicRelaBL.relatedActions != null)
{
clsgs_KnowledgesLogicRelaBL.relatedActions.UpdRelaTabDate(objgs_KnowledgesLogicRelaEN.mId, "SetUpdDate");
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
 /// <param name = "objgs_KnowledgesLogicRelaENS">源对象</param>
 /// <param name = "objgs_KnowledgesLogicRelaENT">目标对象</param>
 public static void CopyTo(this clsgs_KnowledgesLogicRelaEN objgs_KnowledgesLogicRelaENS, clsgs_KnowledgesLogicRelaEN objgs_KnowledgesLogicRelaENT)
{
try
{
objgs_KnowledgesLogicRelaENT.mId = objgs_KnowledgesLogicRelaENS.mId; //mId
objgs_KnowledgesLogicRelaENT.CourseKnowledgeIdA = objgs_KnowledgesLogicRelaENS.CourseKnowledgeIdA; //课程知识点AId
objgs_KnowledgesLogicRelaENT.CourseKnowledgeTitleA = objgs_KnowledgesLogicRelaENS.CourseKnowledgeTitleA; //课程知识点标题A
objgs_KnowledgesLogicRelaENT.CourseKnowledgeIdB = objgs_KnowledgesLogicRelaENS.CourseKnowledgeIdB; //课程知识点BId
objgs_KnowledgesLogicRelaENT.CourseKnowledgeTitleB = objgs_KnowledgesLogicRelaENS.CourseKnowledgeTitleB; //课程知识点标题B
objgs_KnowledgesLogicRelaENT.KnowledgeGraphId = objgs_KnowledgesLogicRelaENS.KnowledgeGraphId; //知识点图Id
objgs_KnowledgesLogicRelaENT.SourceAnchor = objgs_KnowledgesLogicRelaENS.SourceAnchor; //源锚点
objgs_KnowledgesLogicRelaENT.TargetAnchor = objgs_KnowledgesLogicRelaENS.TargetAnchor; //目标锚点
objgs_KnowledgesLogicRelaENT.RelaTitle = objgs_KnowledgesLogicRelaENS.RelaTitle; //关系标题
objgs_KnowledgesLogicRelaENT.RelaTypeId = objgs_KnowledgesLogicRelaENS.RelaTypeId; //关系类型Id
objgs_KnowledgesLogicRelaENT.CourseId = objgs_KnowledgesLogicRelaENS.CourseId; //课程Id
objgs_KnowledgesLogicRelaENT.UpdUser = objgs_KnowledgesLogicRelaENS.UpdUser; //修改人
objgs_KnowledgesLogicRelaENT.UpdDate = objgs_KnowledgesLogicRelaENS.UpdDate; //修改日期
objgs_KnowledgesLogicRelaENT.Memo = objgs_KnowledgesLogicRelaENS.Memo; //备注
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
 /// <param name = "objgs_KnowledgesLogicRelaENS">源对象</param>
 /// <returns>目标对象=>clsgs_KnowledgesLogicRelaEN:objgs_KnowledgesLogicRelaENT</returns>
 public static clsgs_KnowledgesLogicRelaEN CopyTo(this clsgs_KnowledgesLogicRelaEN objgs_KnowledgesLogicRelaENS)
{
try
{
 clsgs_KnowledgesLogicRelaEN objgs_KnowledgesLogicRelaENT = new clsgs_KnowledgesLogicRelaEN()
{
mId = objgs_KnowledgesLogicRelaENS.mId, //mId
CourseKnowledgeIdA = objgs_KnowledgesLogicRelaENS.CourseKnowledgeIdA, //课程知识点AId
CourseKnowledgeTitleA = objgs_KnowledgesLogicRelaENS.CourseKnowledgeTitleA, //课程知识点标题A
CourseKnowledgeIdB = objgs_KnowledgesLogicRelaENS.CourseKnowledgeIdB, //课程知识点BId
CourseKnowledgeTitleB = objgs_KnowledgesLogicRelaENS.CourseKnowledgeTitleB, //课程知识点标题B
KnowledgeGraphId = objgs_KnowledgesLogicRelaENS.KnowledgeGraphId, //知识点图Id
SourceAnchor = objgs_KnowledgesLogicRelaENS.SourceAnchor, //源锚点
TargetAnchor = objgs_KnowledgesLogicRelaENS.TargetAnchor, //目标锚点
RelaTitle = objgs_KnowledgesLogicRelaENS.RelaTitle, //关系标题
RelaTypeId = objgs_KnowledgesLogicRelaENS.RelaTypeId, //关系类型Id
CourseId = objgs_KnowledgesLogicRelaENS.CourseId, //课程Id
UpdUser = objgs_KnowledgesLogicRelaENS.UpdUser, //修改人
UpdDate = objgs_KnowledgesLogicRelaENS.UpdDate, //修改日期
Memo = objgs_KnowledgesLogicRelaENS.Memo, //备注
};
 return objgs_KnowledgesLogicRelaENT;
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
public static void CheckPropertyNew(this clsgs_KnowledgesLogicRelaEN objgs_KnowledgesLogicRelaEN)
{
 clsgs_KnowledgesLogicRelaBL.gs_KnowledgesLogicRelaDA.CheckPropertyNew(objgs_KnowledgesLogicRelaEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(this clsgs_KnowledgesLogicRelaEN objgs_KnowledgesLogicRelaEN)
{
 clsgs_KnowledgesLogicRelaBL.gs_KnowledgesLogicRelaDA.CheckProperty4Condition(objgs_KnowledgesLogicRelaEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsgs_KnowledgesLogicRelaEN objgs_KnowledgesLogicRelaCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objgs_KnowledgesLogicRelaCond.IsUpdated(congs_KnowledgesLogicRela.mId) == true)
{
string strComparisonOpmId = objgs_KnowledgesLogicRelaCond.dicFldComparisonOp[congs_KnowledgesLogicRela.mId];
strWhereCond += string.Format(" And {0} {2} {1}", congs_KnowledgesLogicRela.mId, objgs_KnowledgesLogicRelaCond.mId, strComparisonOpmId);
}
if (objgs_KnowledgesLogicRelaCond.IsUpdated(congs_KnowledgesLogicRela.CourseKnowledgeIdA) == true)
{
string strComparisonOpCourseKnowledgeIdA = objgs_KnowledgesLogicRelaCond.dicFldComparisonOp[congs_KnowledgesLogicRela.CourseKnowledgeIdA];
strWhereCond += string.Format(" And {0} {2} '{1}'", congs_KnowledgesLogicRela.CourseKnowledgeIdA, objgs_KnowledgesLogicRelaCond.CourseKnowledgeIdA, strComparisonOpCourseKnowledgeIdA);
}
if (objgs_KnowledgesLogicRelaCond.IsUpdated(congs_KnowledgesLogicRela.CourseKnowledgeTitleA) == true)
{
string strComparisonOpCourseKnowledgeTitleA = objgs_KnowledgesLogicRelaCond.dicFldComparisonOp[congs_KnowledgesLogicRela.CourseKnowledgeTitleA];
strWhereCond += string.Format(" And {0} {2} '{1}'", congs_KnowledgesLogicRela.CourseKnowledgeTitleA, objgs_KnowledgesLogicRelaCond.CourseKnowledgeTitleA, strComparisonOpCourseKnowledgeTitleA);
}
if (objgs_KnowledgesLogicRelaCond.IsUpdated(congs_KnowledgesLogicRela.CourseKnowledgeIdB) == true)
{
string strComparisonOpCourseKnowledgeIdB = objgs_KnowledgesLogicRelaCond.dicFldComparisonOp[congs_KnowledgesLogicRela.CourseKnowledgeIdB];
strWhereCond += string.Format(" And {0} {2} '{1}'", congs_KnowledgesLogicRela.CourseKnowledgeIdB, objgs_KnowledgesLogicRelaCond.CourseKnowledgeIdB, strComparisonOpCourseKnowledgeIdB);
}
if (objgs_KnowledgesLogicRelaCond.IsUpdated(congs_KnowledgesLogicRela.CourseKnowledgeTitleB) == true)
{
string strComparisonOpCourseKnowledgeTitleB = objgs_KnowledgesLogicRelaCond.dicFldComparisonOp[congs_KnowledgesLogicRela.CourseKnowledgeTitleB];
strWhereCond += string.Format(" And {0} {2} '{1}'", congs_KnowledgesLogicRela.CourseKnowledgeTitleB, objgs_KnowledgesLogicRelaCond.CourseKnowledgeTitleB, strComparisonOpCourseKnowledgeTitleB);
}
if (objgs_KnowledgesLogicRelaCond.IsUpdated(congs_KnowledgesLogicRela.KnowledgeGraphId) == true)
{
string strComparisonOpKnowledgeGraphId = objgs_KnowledgesLogicRelaCond.dicFldComparisonOp[congs_KnowledgesLogicRela.KnowledgeGraphId];
strWhereCond += string.Format(" And {0} {2} '{1}'", congs_KnowledgesLogicRela.KnowledgeGraphId, objgs_KnowledgesLogicRelaCond.KnowledgeGraphId, strComparisonOpKnowledgeGraphId);
}
if (objgs_KnowledgesLogicRelaCond.IsUpdated(congs_KnowledgesLogicRela.SourceAnchor) == true)
{
string strComparisonOpSourceAnchor = objgs_KnowledgesLogicRelaCond.dicFldComparisonOp[congs_KnowledgesLogicRela.SourceAnchor];
strWhereCond += string.Format(" And {0} {2} '{1}'", congs_KnowledgesLogicRela.SourceAnchor, objgs_KnowledgesLogicRelaCond.SourceAnchor, strComparisonOpSourceAnchor);
}
if (objgs_KnowledgesLogicRelaCond.IsUpdated(congs_KnowledgesLogicRela.TargetAnchor) == true)
{
string strComparisonOpTargetAnchor = objgs_KnowledgesLogicRelaCond.dicFldComparisonOp[congs_KnowledgesLogicRela.TargetAnchor];
strWhereCond += string.Format(" And {0} {2} '{1}'", congs_KnowledgesLogicRela.TargetAnchor, objgs_KnowledgesLogicRelaCond.TargetAnchor, strComparisonOpTargetAnchor);
}
if (objgs_KnowledgesLogicRelaCond.IsUpdated(congs_KnowledgesLogicRela.RelaTitle) == true)
{
string strComparisonOpRelaTitle = objgs_KnowledgesLogicRelaCond.dicFldComparisonOp[congs_KnowledgesLogicRela.RelaTitle];
strWhereCond += string.Format(" And {0} {2} '{1}'", congs_KnowledgesLogicRela.RelaTitle, objgs_KnowledgesLogicRelaCond.RelaTitle, strComparisonOpRelaTitle);
}
if (objgs_KnowledgesLogicRelaCond.IsUpdated(congs_KnowledgesLogicRela.RelaTypeId) == true)
{
string strComparisonOpRelaTypeId = objgs_KnowledgesLogicRelaCond.dicFldComparisonOp[congs_KnowledgesLogicRela.RelaTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", congs_KnowledgesLogicRela.RelaTypeId, objgs_KnowledgesLogicRelaCond.RelaTypeId, strComparisonOpRelaTypeId);
}
if (objgs_KnowledgesLogicRelaCond.IsUpdated(congs_KnowledgesLogicRela.CourseId) == true)
{
string strComparisonOpCourseId = objgs_KnowledgesLogicRelaCond.dicFldComparisonOp[congs_KnowledgesLogicRela.CourseId];
strWhereCond += string.Format(" And {0} {2} '{1}'", congs_KnowledgesLogicRela.CourseId, objgs_KnowledgesLogicRelaCond.CourseId, strComparisonOpCourseId);
}
if (objgs_KnowledgesLogicRelaCond.IsUpdated(congs_KnowledgesLogicRela.UpdUser) == true)
{
string strComparisonOpUpdUser = objgs_KnowledgesLogicRelaCond.dicFldComparisonOp[congs_KnowledgesLogicRela.UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", congs_KnowledgesLogicRela.UpdUser, objgs_KnowledgesLogicRelaCond.UpdUser, strComparisonOpUpdUser);
}
if (objgs_KnowledgesLogicRelaCond.IsUpdated(congs_KnowledgesLogicRela.UpdDate) == true)
{
string strComparisonOpUpdDate = objgs_KnowledgesLogicRelaCond.dicFldComparisonOp[congs_KnowledgesLogicRela.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", congs_KnowledgesLogicRela.UpdDate, objgs_KnowledgesLogicRelaCond.UpdDate, strComparisonOpUpdDate);
}
if (objgs_KnowledgesLogicRelaCond.IsUpdated(congs_KnowledgesLogicRela.Memo) == true)
{
string strComparisonOpMemo = objgs_KnowledgesLogicRelaCond.dicFldComparisonOp[congs_KnowledgesLogicRela.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", congs_KnowledgesLogicRela.Memo, objgs_KnowledgesLogicRelaCond.Memo, strComparisonOpMemo);
}
 return strWhereCond;
}

 /// <summary>
 /// 检查唯一性(Uniqueness)--gs_KnowledgesLogicRela(知识点逻辑关系表), 如果不唯一,即存在相同的记录,就返回False
 /// 唯一性条件:KnowledgeGraphId_CourseKnowledgeIdA_CourseKnowledgeIdB
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckConstraint)
 /// </summary>
 /// <param name = "objgs_KnowledgesLogicRelaEN">要求唯一的对象</param>
 /// <returns></returns>
public static bool CheckUniqueness(this clsgs_KnowledgesLogicRelaEN objgs_KnowledgesLogicRelaEN)
{
//检测记录是否存在
bool bolIsUniqueness;
StringBuilder sbCondition = new StringBuilder();
if (objgs_KnowledgesLogicRelaEN == null) return true;
if (objgs_KnowledgesLogicRelaEN.mId == 0)
{
sbCondition.AppendFormat("1 = 1");
 if (objgs_KnowledgesLogicRelaEN.KnowledgeGraphId == null)
{
 sbCondition.AppendFormat(" and KnowledgeGraphId is null", objgs_KnowledgesLogicRelaEN.KnowledgeGraphId);
}
else
{
 sbCondition.AppendFormat(" and KnowledgeGraphId = '{0}'", objgs_KnowledgesLogicRelaEN.KnowledgeGraphId);
}
 sbCondition.AppendFormat(" and CourseKnowledgeIdA = '{0}'", objgs_KnowledgesLogicRelaEN.CourseKnowledgeIdA);
 sbCondition.AppendFormat(" and CourseKnowledgeIdB = '{0}'", objgs_KnowledgesLogicRelaEN.CourseKnowledgeIdB);
if (clsgs_KnowledgesLogicRelaBL.IsExistRecord(sbCondition.ToString())  ==  true)
{
 bolIsUniqueness = false;
}
else
{
 bolIsUniqueness = true;
}
}
 else {
sbCondition.AppendFormat("mId !=  {0}", objgs_KnowledgesLogicRelaEN.mId);
 sbCondition.AppendFormat(" and KnowledgeGraphId = '{0}'", objgs_KnowledgesLogicRelaEN.KnowledgeGraphId);
 sbCondition.AppendFormat(" and CourseKnowledgeIdA = '{0}'", objgs_KnowledgesLogicRelaEN.CourseKnowledgeIdA);
 sbCondition.AppendFormat(" and CourseKnowledgeIdB = '{0}'", objgs_KnowledgesLogicRelaEN.CourseKnowledgeIdB);
if (clsgs_KnowledgesLogicRelaBL.IsExistRecord(sbCondition.ToString())  ==  true)
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
 /// 获取唯一性条件串--gs_KnowledgesLogicRela(知识点逻辑关系表), 即由对象中唯一性条件字段关键字与值组成的条件串
 /// 唯一性条件:KnowledgeGraphId_CourseKnowledgeIdA_CourseKnowledgeIdB
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetConditionString4Constraint)
 /// </summary>
 /// <param name = "objgs_KnowledgesLogicRelaEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(this clsgs_KnowledgesLogicRelaEN objgs_KnowledgesLogicRelaEN)
{
//检测记录是否存在
StringBuilder sbCondition = new StringBuilder();
if (objgs_KnowledgesLogicRelaEN == null) return "";
if (objgs_KnowledgesLogicRelaEN.mId == 0)
{
sbCondition.AppendFormat("1 = 1");
 if (objgs_KnowledgesLogicRelaEN.KnowledgeGraphId == null)
{
 sbCondition.AppendFormat(" and KnowledgeGraphId is null", objgs_KnowledgesLogicRelaEN.KnowledgeGraphId);
}
else
{
 sbCondition.AppendFormat(" and KnowledgeGraphId = '{0}'", objgs_KnowledgesLogicRelaEN.KnowledgeGraphId);
}
 sbCondition.AppendFormat(" and CourseKnowledgeIdA = '{0}'", objgs_KnowledgesLogicRelaEN.CourseKnowledgeIdA);
 sbCondition.AppendFormat(" and CourseKnowledgeIdB = '{0}'", objgs_KnowledgesLogicRelaEN.CourseKnowledgeIdB);
return sbCondition.ToString();
}
 else {
sbCondition.AppendFormat("mId !=  {0}", objgs_KnowledgesLogicRelaEN.mId);
 sbCondition.AppendFormat(" and KnowledgeGraphId = '{0}'", objgs_KnowledgesLogicRelaEN.KnowledgeGraphId);
 sbCondition.AppendFormat(" and CourseKnowledgeIdA = '{0}'", objgs_KnowledgesLogicRelaEN.CourseKnowledgeIdA);
 sbCondition.AppendFormat(" and CourseKnowledgeIdB = '{0}'", objgs_KnowledgesLogicRelaEN.CourseKnowledgeIdB);
 return sbCondition.ToString();
}
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_gs_KnowledgesLogicRela
{
public virtual bool UpdRelaTabDate(long lngmId, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// 知识点逻辑关系表(gs_KnowledgesLogicRela)
 /// 数据源类型:表
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsgs_KnowledgesLogicRelaBL
{
public static RelatedActions_gs_KnowledgesLogicRela relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsgs_KnowledgesLogicRelaDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsgs_KnowledgesLogicRelaDA gs_KnowledgesLogicRelaDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsgs_KnowledgesLogicRelaDA();
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
 public clsgs_KnowledgesLogicRelaBL()
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
if (string.IsNullOrEmpty(clsgs_KnowledgesLogicRelaEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsgs_KnowledgesLogicRelaEN._ConnectString);
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
public static DataTable GetDataTable_gs_KnowledgesLogicRela(string strWhereCond)
{
DataTable objDT;
try
{
objDT = gs_KnowledgesLogicRelaDA.GetDataTable_gs_KnowledgesLogicRela(strWhereCond);
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
objDT = gs_KnowledgesLogicRelaDA.GetDataTable(strWhereCond);
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
objDT = gs_KnowledgesLogicRelaDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = gs_KnowledgesLogicRelaDA.GetDataTable(strWhereCond, strTabName);
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
objDT = gs_KnowledgesLogicRelaDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = gs_KnowledgesLogicRelaDA.GetDataTable_Top(objTopPara);
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
objDT = gs_KnowledgesLogicRelaDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = gs_KnowledgesLogicRelaDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = gs_KnowledgesLogicRelaDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
public static List<clsgs_KnowledgesLogicRelaEN> GetObjLstByMIdLst(List<long> arrMIdLst)
{
List<clsgs_KnowledgesLogicRelaEN> arrObjLst = new List<clsgs_KnowledgesLogicRelaEN>(); 
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
	clsgs_KnowledgesLogicRelaEN objgs_KnowledgesLogicRelaEN = new clsgs_KnowledgesLogicRelaEN();
try
{
objgs_KnowledgesLogicRelaEN.mId = Int32.Parse(objRow[congs_KnowledgesLogicRela.mId].ToString().Trim()); //mId
objgs_KnowledgesLogicRelaEN.CourseKnowledgeIdA = objRow[congs_KnowledgesLogicRela.CourseKnowledgeIdA].ToString().Trim(); //课程知识点AId
objgs_KnowledgesLogicRelaEN.CourseKnowledgeTitleA = objRow[congs_KnowledgesLogicRela.CourseKnowledgeTitleA] == DBNull.Value ? null : objRow[congs_KnowledgesLogicRela.CourseKnowledgeTitleA].ToString().Trim(); //课程知识点标题A
objgs_KnowledgesLogicRelaEN.CourseKnowledgeIdB = objRow[congs_KnowledgesLogicRela.CourseKnowledgeIdB].ToString().Trim(); //课程知识点BId
objgs_KnowledgesLogicRelaEN.CourseKnowledgeTitleB = objRow[congs_KnowledgesLogicRela.CourseKnowledgeTitleB] == DBNull.Value ? null : objRow[congs_KnowledgesLogicRela.CourseKnowledgeTitleB].ToString().Trim(); //课程知识点标题B
objgs_KnowledgesLogicRelaEN.KnowledgeGraphId = objRow[congs_KnowledgesLogicRela.KnowledgeGraphId] == DBNull.Value ? null : objRow[congs_KnowledgesLogicRela.KnowledgeGraphId].ToString().Trim(); //知识点图Id
objgs_KnowledgesLogicRelaEN.SourceAnchor = objRow[congs_KnowledgesLogicRela.SourceAnchor] == DBNull.Value ? null : objRow[congs_KnowledgesLogicRela.SourceAnchor].ToString().Trim(); //源锚点
objgs_KnowledgesLogicRelaEN.TargetAnchor = objRow[congs_KnowledgesLogicRela.TargetAnchor] == DBNull.Value ? null : objRow[congs_KnowledgesLogicRela.TargetAnchor].ToString().Trim(); //目标锚点
objgs_KnowledgesLogicRelaEN.RelaTitle = objRow[congs_KnowledgesLogicRela.RelaTitle] == DBNull.Value ? null : objRow[congs_KnowledgesLogicRela.RelaTitle].ToString().Trim(); //关系标题
objgs_KnowledgesLogicRelaEN.RelaTypeId = objRow[congs_KnowledgesLogicRela.RelaTypeId] == DBNull.Value ? null : objRow[congs_KnowledgesLogicRela.RelaTypeId].ToString().Trim(); //关系类型Id
objgs_KnowledgesLogicRelaEN.CourseId = objRow[congs_KnowledgesLogicRela.CourseId].ToString().Trim(); //课程Id
objgs_KnowledgesLogicRelaEN.UpdUser = objRow[congs_KnowledgesLogicRela.UpdUser] == DBNull.Value ? null : objRow[congs_KnowledgesLogicRela.UpdUser].ToString().Trim(); //修改人
objgs_KnowledgesLogicRelaEN.UpdDate = objRow[congs_KnowledgesLogicRela.UpdDate] == DBNull.Value ? null : objRow[congs_KnowledgesLogicRela.UpdDate].ToString().Trim(); //修改日期
objgs_KnowledgesLogicRelaEN.Memo = objRow[congs_KnowledgesLogicRela.Memo] == DBNull.Value ? null : objRow[congs_KnowledgesLogicRela.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objgs_KnowledgesLogicRelaEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objgs_KnowledgesLogicRelaEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrMIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsgs_KnowledgesLogicRelaEN> GetObjLstByMIdLstCache(List<long> arrMIdLst, string strCourseId)
{
string strKey = string.Format("{0}_{1}", clsgs_KnowledgesLogicRelaEN._CurrTabName, strCourseId);
List<clsgs_KnowledgesLogicRelaEN> arrgs_KnowledgesLogicRelaObjLstCache = GetObjLstCache(strCourseId);
IEnumerable <clsgs_KnowledgesLogicRelaEN> arrgs_KnowledgesLogicRelaObjLst_Sel =
arrgs_KnowledgesLogicRelaObjLstCache
.Where(x => arrMIdLst.Contains(x.mId));
return arrgs_KnowledgesLogicRelaObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsgs_KnowledgesLogicRelaEN> GetObjLst(string strWhereCond)
{
List<clsgs_KnowledgesLogicRelaEN> arrObjLst = new List<clsgs_KnowledgesLogicRelaEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsgs_KnowledgesLogicRelaEN objgs_KnowledgesLogicRelaEN = new clsgs_KnowledgesLogicRelaEN();
try
{
objgs_KnowledgesLogicRelaEN.mId = Int32.Parse(objRow[congs_KnowledgesLogicRela.mId].ToString().Trim()); //mId
objgs_KnowledgesLogicRelaEN.CourseKnowledgeIdA = objRow[congs_KnowledgesLogicRela.CourseKnowledgeIdA].ToString().Trim(); //课程知识点AId
objgs_KnowledgesLogicRelaEN.CourseKnowledgeTitleA = objRow[congs_KnowledgesLogicRela.CourseKnowledgeTitleA] == DBNull.Value ? null : objRow[congs_KnowledgesLogicRela.CourseKnowledgeTitleA].ToString().Trim(); //课程知识点标题A
objgs_KnowledgesLogicRelaEN.CourseKnowledgeIdB = objRow[congs_KnowledgesLogicRela.CourseKnowledgeIdB].ToString().Trim(); //课程知识点BId
objgs_KnowledgesLogicRelaEN.CourseKnowledgeTitleB = objRow[congs_KnowledgesLogicRela.CourseKnowledgeTitleB] == DBNull.Value ? null : objRow[congs_KnowledgesLogicRela.CourseKnowledgeTitleB].ToString().Trim(); //课程知识点标题B
objgs_KnowledgesLogicRelaEN.KnowledgeGraphId = objRow[congs_KnowledgesLogicRela.KnowledgeGraphId] == DBNull.Value ? null : objRow[congs_KnowledgesLogicRela.KnowledgeGraphId].ToString().Trim(); //知识点图Id
objgs_KnowledgesLogicRelaEN.SourceAnchor = objRow[congs_KnowledgesLogicRela.SourceAnchor] == DBNull.Value ? null : objRow[congs_KnowledgesLogicRela.SourceAnchor].ToString().Trim(); //源锚点
objgs_KnowledgesLogicRelaEN.TargetAnchor = objRow[congs_KnowledgesLogicRela.TargetAnchor] == DBNull.Value ? null : objRow[congs_KnowledgesLogicRela.TargetAnchor].ToString().Trim(); //目标锚点
objgs_KnowledgesLogicRelaEN.RelaTitle = objRow[congs_KnowledgesLogicRela.RelaTitle] == DBNull.Value ? null : objRow[congs_KnowledgesLogicRela.RelaTitle].ToString().Trim(); //关系标题
objgs_KnowledgesLogicRelaEN.RelaTypeId = objRow[congs_KnowledgesLogicRela.RelaTypeId] == DBNull.Value ? null : objRow[congs_KnowledgesLogicRela.RelaTypeId].ToString().Trim(); //关系类型Id
objgs_KnowledgesLogicRelaEN.CourseId = objRow[congs_KnowledgesLogicRela.CourseId].ToString().Trim(); //课程Id
objgs_KnowledgesLogicRelaEN.UpdUser = objRow[congs_KnowledgesLogicRela.UpdUser] == DBNull.Value ? null : objRow[congs_KnowledgesLogicRela.UpdUser].ToString().Trim(); //修改人
objgs_KnowledgesLogicRelaEN.UpdDate = objRow[congs_KnowledgesLogicRela.UpdDate] == DBNull.Value ? null : objRow[congs_KnowledgesLogicRela.UpdDate].ToString().Trim(); //修改日期
objgs_KnowledgesLogicRelaEN.Memo = objRow[congs_KnowledgesLogicRela.Memo] == DBNull.Value ? null : objRow[congs_KnowledgesLogicRela.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objgs_KnowledgesLogicRelaEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objgs_KnowledgesLogicRelaEN);
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
public static List<clsgs_KnowledgesLogicRelaEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsgs_KnowledgesLogicRelaEN> arrObjLst = new List<clsgs_KnowledgesLogicRelaEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsgs_KnowledgesLogicRelaEN objgs_KnowledgesLogicRelaEN = new clsgs_KnowledgesLogicRelaEN();
try
{
objgs_KnowledgesLogicRelaEN.mId = Int32.Parse(objRow[congs_KnowledgesLogicRela.mId].ToString().Trim()); //mId
objgs_KnowledgesLogicRelaEN.CourseKnowledgeIdA = objRow[congs_KnowledgesLogicRela.CourseKnowledgeIdA].ToString().Trim(); //课程知识点AId
objgs_KnowledgesLogicRelaEN.CourseKnowledgeTitleA = objRow[congs_KnowledgesLogicRela.CourseKnowledgeTitleA] == DBNull.Value ? null : objRow[congs_KnowledgesLogicRela.CourseKnowledgeTitleA].ToString().Trim(); //课程知识点标题A
objgs_KnowledgesLogicRelaEN.CourseKnowledgeIdB = objRow[congs_KnowledgesLogicRela.CourseKnowledgeIdB].ToString().Trim(); //课程知识点BId
objgs_KnowledgesLogicRelaEN.CourseKnowledgeTitleB = objRow[congs_KnowledgesLogicRela.CourseKnowledgeTitleB] == DBNull.Value ? null : objRow[congs_KnowledgesLogicRela.CourseKnowledgeTitleB].ToString().Trim(); //课程知识点标题B
objgs_KnowledgesLogicRelaEN.KnowledgeGraphId = objRow[congs_KnowledgesLogicRela.KnowledgeGraphId] == DBNull.Value ? null : objRow[congs_KnowledgesLogicRela.KnowledgeGraphId].ToString().Trim(); //知识点图Id
objgs_KnowledgesLogicRelaEN.SourceAnchor = objRow[congs_KnowledgesLogicRela.SourceAnchor] == DBNull.Value ? null : objRow[congs_KnowledgesLogicRela.SourceAnchor].ToString().Trim(); //源锚点
objgs_KnowledgesLogicRelaEN.TargetAnchor = objRow[congs_KnowledgesLogicRela.TargetAnchor] == DBNull.Value ? null : objRow[congs_KnowledgesLogicRela.TargetAnchor].ToString().Trim(); //目标锚点
objgs_KnowledgesLogicRelaEN.RelaTitle = objRow[congs_KnowledgesLogicRela.RelaTitle] == DBNull.Value ? null : objRow[congs_KnowledgesLogicRela.RelaTitle].ToString().Trim(); //关系标题
objgs_KnowledgesLogicRelaEN.RelaTypeId = objRow[congs_KnowledgesLogicRela.RelaTypeId] == DBNull.Value ? null : objRow[congs_KnowledgesLogicRela.RelaTypeId].ToString().Trim(); //关系类型Id
objgs_KnowledgesLogicRelaEN.CourseId = objRow[congs_KnowledgesLogicRela.CourseId].ToString().Trim(); //课程Id
objgs_KnowledgesLogicRelaEN.UpdUser = objRow[congs_KnowledgesLogicRela.UpdUser] == DBNull.Value ? null : objRow[congs_KnowledgesLogicRela.UpdUser].ToString().Trim(); //修改人
objgs_KnowledgesLogicRelaEN.UpdDate = objRow[congs_KnowledgesLogicRela.UpdDate] == DBNull.Value ? null : objRow[congs_KnowledgesLogicRela.UpdDate].ToString().Trim(); //修改日期
objgs_KnowledgesLogicRelaEN.Memo = objRow[congs_KnowledgesLogicRela.Memo] == DBNull.Value ? null : objRow[congs_KnowledgesLogicRela.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objgs_KnowledgesLogicRelaEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objgs_KnowledgesLogicRelaEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objgs_KnowledgesLogicRelaCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsgs_KnowledgesLogicRelaEN> GetSubObjLstCache(clsgs_KnowledgesLogicRelaEN objgs_KnowledgesLogicRelaCond)
{
 string strCourseId = objgs_KnowledgesLogicRelaCond.CourseId;
 if (string.IsNullOrEmpty(strCourseId) == true)
{
string strMsg = string.Format("(errid:Busi000172)在表中,缓存分类字段值不能为空!(clsgs_KnowledgesLogicRelaBL:GetSubObjLstCache)");
throw new Exception(strMsg);
}
List<clsgs_KnowledgesLogicRelaEN> arrObjLstCache = GetObjLstCache(strCourseId);
IEnumerable <clsgs_KnowledgesLogicRelaEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in congs_KnowledgesLogicRela.AttributeName)
{
if (objgs_KnowledgesLogicRelaCond.IsUpdated(strFldName) == false) continue;
if (objgs_KnowledgesLogicRelaCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objgs_KnowledgesLogicRelaCond[strFldName].ToString());
}
else
{
if (objgs_KnowledgesLogicRelaCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objgs_KnowledgesLogicRelaCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objgs_KnowledgesLogicRelaCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objgs_KnowledgesLogicRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objgs_KnowledgesLogicRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objgs_KnowledgesLogicRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objgs_KnowledgesLogicRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objgs_KnowledgesLogicRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objgs_KnowledgesLogicRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objgs_KnowledgesLogicRelaCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objgs_KnowledgesLogicRelaCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objgs_KnowledgesLogicRelaCond[strFldName]));
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
public static List<clsgs_KnowledgesLogicRelaEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsgs_KnowledgesLogicRelaEN> arrObjLst = new List<clsgs_KnowledgesLogicRelaEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsgs_KnowledgesLogicRelaEN objgs_KnowledgesLogicRelaEN = new clsgs_KnowledgesLogicRelaEN();
try
{
objgs_KnowledgesLogicRelaEN.mId = Int32.Parse(objRow[congs_KnowledgesLogicRela.mId].ToString().Trim()); //mId
objgs_KnowledgesLogicRelaEN.CourseKnowledgeIdA = objRow[congs_KnowledgesLogicRela.CourseKnowledgeIdA].ToString().Trim(); //课程知识点AId
objgs_KnowledgesLogicRelaEN.CourseKnowledgeTitleA = objRow[congs_KnowledgesLogicRela.CourseKnowledgeTitleA] == DBNull.Value ? null : objRow[congs_KnowledgesLogicRela.CourseKnowledgeTitleA].ToString().Trim(); //课程知识点标题A
objgs_KnowledgesLogicRelaEN.CourseKnowledgeIdB = objRow[congs_KnowledgesLogicRela.CourseKnowledgeIdB].ToString().Trim(); //课程知识点BId
objgs_KnowledgesLogicRelaEN.CourseKnowledgeTitleB = objRow[congs_KnowledgesLogicRela.CourseKnowledgeTitleB] == DBNull.Value ? null : objRow[congs_KnowledgesLogicRela.CourseKnowledgeTitleB].ToString().Trim(); //课程知识点标题B
objgs_KnowledgesLogicRelaEN.KnowledgeGraphId = objRow[congs_KnowledgesLogicRela.KnowledgeGraphId] == DBNull.Value ? null : objRow[congs_KnowledgesLogicRela.KnowledgeGraphId].ToString().Trim(); //知识点图Id
objgs_KnowledgesLogicRelaEN.SourceAnchor = objRow[congs_KnowledgesLogicRela.SourceAnchor] == DBNull.Value ? null : objRow[congs_KnowledgesLogicRela.SourceAnchor].ToString().Trim(); //源锚点
objgs_KnowledgesLogicRelaEN.TargetAnchor = objRow[congs_KnowledgesLogicRela.TargetAnchor] == DBNull.Value ? null : objRow[congs_KnowledgesLogicRela.TargetAnchor].ToString().Trim(); //目标锚点
objgs_KnowledgesLogicRelaEN.RelaTitle = objRow[congs_KnowledgesLogicRela.RelaTitle] == DBNull.Value ? null : objRow[congs_KnowledgesLogicRela.RelaTitle].ToString().Trim(); //关系标题
objgs_KnowledgesLogicRelaEN.RelaTypeId = objRow[congs_KnowledgesLogicRela.RelaTypeId] == DBNull.Value ? null : objRow[congs_KnowledgesLogicRela.RelaTypeId].ToString().Trim(); //关系类型Id
objgs_KnowledgesLogicRelaEN.CourseId = objRow[congs_KnowledgesLogicRela.CourseId].ToString().Trim(); //课程Id
objgs_KnowledgesLogicRelaEN.UpdUser = objRow[congs_KnowledgesLogicRela.UpdUser] == DBNull.Value ? null : objRow[congs_KnowledgesLogicRela.UpdUser].ToString().Trim(); //修改人
objgs_KnowledgesLogicRelaEN.UpdDate = objRow[congs_KnowledgesLogicRela.UpdDate] == DBNull.Value ? null : objRow[congs_KnowledgesLogicRela.UpdDate].ToString().Trim(); //修改日期
objgs_KnowledgesLogicRelaEN.Memo = objRow[congs_KnowledgesLogicRela.Memo] == DBNull.Value ? null : objRow[congs_KnowledgesLogicRela.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objgs_KnowledgesLogicRelaEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objgs_KnowledgesLogicRelaEN);
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
public static List<clsgs_KnowledgesLogicRelaEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsgs_KnowledgesLogicRelaEN> arrObjLst = new List<clsgs_KnowledgesLogicRelaEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsgs_KnowledgesLogicRelaEN objgs_KnowledgesLogicRelaEN = new clsgs_KnowledgesLogicRelaEN();
try
{
objgs_KnowledgesLogicRelaEN.mId = Int32.Parse(objRow[congs_KnowledgesLogicRela.mId].ToString().Trim()); //mId
objgs_KnowledgesLogicRelaEN.CourseKnowledgeIdA = objRow[congs_KnowledgesLogicRela.CourseKnowledgeIdA].ToString().Trim(); //课程知识点AId
objgs_KnowledgesLogicRelaEN.CourseKnowledgeTitleA = objRow[congs_KnowledgesLogicRela.CourseKnowledgeTitleA] == DBNull.Value ? null : objRow[congs_KnowledgesLogicRela.CourseKnowledgeTitleA].ToString().Trim(); //课程知识点标题A
objgs_KnowledgesLogicRelaEN.CourseKnowledgeIdB = objRow[congs_KnowledgesLogicRela.CourseKnowledgeIdB].ToString().Trim(); //课程知识点BId
objgs_KnowledgesLogicRelaEN.CourseKnowledgeTitleB = objRow[congs_KnowledgesLogicRela.CourseKnowledgeTitleB] == DBNull.Value ? null : objRow[congs_KnowledgesLogicRela.CourseKnowledgeTitleB].ToString().Trim(); //课程知识点标题B
objgs_KnowledgesLogicRelaEN.KnowledgeGraphId = objRow[congs_KnowledgesLogicRela.KnowledgeGraphId] == DBNull.Value ? null : objRow[congs_KnowledgesLogicRela.KnowledgeGraphId].ToString().Trim(); //知识点图Id
objgs_KnowledgesLogicRelaEN.SourceAnchor = objRow[congs_KnowledgesLogicRela.SourceAnchor] == DBNull.Value ? null : objRow[congs_KnowledgesLogicRela.SourceAnchor].ToString().Trim(); //源锚点
objgs_KnowledgesLogicRelaEN.TargetAnchor = objRow[congs_KnowledgesLogicRela.TargetAnchor] == DBNull.Value ? null : objRow[congs_KnowledgesLogicRela.TargetAnchor].ToString().Trim(); //目标锚点
objgs_KnowledgesLogicRelaEN.RelaTitle = objRow[congs_KnowledgesLogicRela.RelaTitle] == DBNull.Value ? null : objRow[congs_KnowledgesLogicRela.RelaTitle].ToString().Trim(); //关系标题
objgs_KnowledgesLogicRelaEN.RelaTypeId = objRow[congs_KnowledgesLogicRela.RelaTypeId] == DBNull.Value ? null : objRow[congs_KnowledgesLogicRela.RelaTypeId].ToString().Trim(); //关系类型Id
objgs_KnowledgesLogicRelaEN.CourseId = objRow[congs_KnowledgesLogicRela.CourseId].ToString().Trim(); //课程Id
objgs_KnowledgesLogicRelaEN.UpdUser = objRow[congs_KnowledgesLogicRela.UpdUser] == DBNull.Value ? null : objRow[congs_KnowledgesLogicRela.UpdUser].ToString().Trim(); //修改人
objgs_KnowledgesLogicRelaEN.UpdDate = objRow[congs_KnowledgesLogicRela.UpdDate] == DBNull.Value ? null : objRow[congs_KnowledgesLogicRela.UpdDate].ToString().Trim(); //修改日期
objgs_KnowledgesLogicRelaEN.Memo = objRow[congs_KnowledgesLogicRela.Memo] == DBNull.Value ? null : objRow[congs_KnowledgesLogicRela.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objgs_KnowledgesLogicRelaEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objgs_KnowledgesLogicRelaEN);
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
List<clsgs_KnowledgesLogicRelaEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsgs_KnowledgesLogicRelaEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsgs_KnowledgesLogicRelaEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsgs_KnowledgesLogicRelaEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsgs_KnowledgesLogicRelaEN> arrObjLst = new List<clsgs_KnowledgesLogicRelaEN>(); 
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
	clsgs_KnowledgesLogicRelaEN objgs_KnowledgesLogicRelaEN = new clsgs_KnowledgesLogicRelaEN();
try
{
objgs_KnowledgesLogicRelaEN.mId = Int32.Parse(objRow[congs_KnowledgesLogicRela.mId].ToString().Trim()); //mId
objgs_KnowledgesLogicRelaEN.CourseKnowledgeIdA = objRow[congs_KnowledgesLogicRela.CourseKnowledgeIdA].ToString().Trim(); //课程知识点AId
objgs_KnowledgesLogicRelaEN.CourseKnowledgeTitleA = objRow[congs_KnowledgesLogicRela.CourseKnowledgeTitleA] == DBNull.Value ? null : objRow[congs_KnowledgesLogicRela.CourseKnowledgeTitleA].ToString().Trim(); //课程知识点标题A
objgs_KnowledgesLogicRelaEN.CourseKnowledgeIdB = objRow[congs_KnowledgesLogicRela.CourseKnowledgeIdB].ToString().Trim(); //课程知识点BId
objgs_KnowledgesLogicRelaEN.CourseKnowledgeTitleB = objRow[congs_KnowledgesLogicRela.CourseKnowledgeTitleB] == DBNull.Value ? null : objRow[congs_KnowledgesLogicRela.CourseKnowledgeTitleB].ToString().Trim(); //课程知识点标题B
objgs_KnowledgesLogicRelaEN.KnowledgeGraphId = objRow[congs_KnowledgesLogicRela.KnowledgeGraphId] == DBNull.Value ? null : objRow[congs_KnowledgesLogicRela.KnowledgeGraphId].ToString().Trim(); //知识点图Id
objgs_KnowledgesLogicRelaEN.SourceAnchor = objRow[congs_KnowledgesLogicRela.SourceAnchor] == DBNull.Value ? null : objRow[congs_KnowledgesLogicRela.SourceAnchor].ToString().Trim(); //源锚点
objgs_KnowledgesLogicRelaEN.TargetAnchor = objRow[congs_KnowledgesLogicRela.TargetAnchor] == DBNull.Value ? null : objRow[congs_KnowledgesLogicRela.TargetAnchor].ToString().Trim(); //目标锚点
objgs_KnowledgesLogicRelaEN.RelaTitle = objRow[congs_KnowledgesLogicRela.RelaTitle] == DBNull.Value ? null : objRow[congs_KnowledgesLogicRela.RelaTitle].ToString().Trim(); //关系标题
objgs_KnowledgesLogicRelaEN.RelaTypeId = objRow[congs_KnowledgesLogicRela.RelaTypeId] == DBNull.Value ? null : objRow[congs_KnowledgesLogicRela.RelaTypeId].ToString().Trim(); //关系类型Id
objgs_KnowledgesLogicRelaEN.CourseId = objRow[congs_KnowledgesLogicRela.CourseId].ToString().Trim(); //课程Id
objgs_KnowledgesLogicRelaEN.UpdUser = objRow[congs_KnowledgesLogicRela.UpdUser] == DBNull.Value ? null : objRow[congs_KnowledgesLogicRela.UpdUser].ToString().Trim(); //修改人
objgs_KnowledgesLogicRelaEN.UpdDate = objRow[congs_KnowledgesLogicRela.UpdDate] == DBNull.Value ? null : objRow[congs_KnowledgesLogicRela.UpdDate].ToString().Trim(); //修改日期
objgs_KnowledgesLogicRelaEN.Memo = objRow[congs_KnowledgesLogicRela.Memo] == DBNull.Value ? null : objRow[congs_KnowledgesLogicRela.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objgs_KnowledgesLogicRelaEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objgs_KnowledgesLogicRelaEN);
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
public static List<clsgs_KnowledgesLogicRelaEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsgs_KnowledgesLogicRelaEN> arrObjLst = new List<clsgs_KnowledgesLogicRelaEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsgs_KnowledgesLogicRelaEN objgs_KnowledgesLogicRelaEN = new clsgs_KnowledgesLogicRelaEN();
try
{
objgs_KnowledgesLogicRelaEN.mId = Int32.Parse(objRow[congs_KnowledgesLogicRela.mId].ToString().Trim()); //mId
objgs_KnowledgesLogicRelaEN.CourseKnowledgeIdA = objRow[congs_KnowledgesLogicRela.CourseKnowledgeIdA].ToString().Trim(); //课程知识点AId
objgs_KnowledgesLogicRelaEN.CourseKnowledgeTitleA = objRow[congs_KnowledgesLogicRela.CourseKnowledgeTitleA] == DBNull.Value ? null : objRow[congs_KnowledgesLogicRela.CourseKnowledgeTitleA].ToString().Trim(); //课程知识点标题A
objgs_KnowledgesLogicRelaEN.CourseKnowledgeIdB = objRow[congs_KnowledgesLogicRela.CourseKnowledgeIdB].ToString().Trim(); //课程知识点BId
objgs_KnowledgesLogicRelaEN.CourseKnowledgeTitleB = objRow[congs_KnowledgesLogicRela.CourseKnowledgeTitleB] == DBNull.Value ? null : objRow[congs_KnowledgesLogicRela.CourseKnowledgeTitleB].ToString().Trim(); //课程知识点标题B
objgs_KnowledgesLogicRelaEN.KnowledgeGraphId = objRow[congs_KnowledgesLogicRela.KnowledgeGraphId] == DBNull.Value ? null : objRow[congs_KnowledgesLogicRela.KnowledgeGraphId].ToString().Trim(); //知识点图Id
objgs_KnowledgesLogicRelaEN.SourceAnchor = objRow[congs_KnowledgesLogicRela.SourceAnchor] == DBNull.Value ? null : objRow[congs_KnowledgesLogicRela.SourceAnchor].ToString().Trim(); //源锚点
objgs_KnowledgesLogicRelaEN.TargetAnchor = objRow[congs_KnowledgesLogicRela.TargetAnchor] == DBNull.Value ? null : objRow[congs_KnowledgesLogicRela.TargetAnchor].ToString().Trim(); //目标锚点
objgs_KnowledgesLogicRelaEN.RelaTitle = objRow[congs_KnowledgesLogicRela.RelaTitle] == DBNull.Value ? null : objRow[congs_KnowledgesLogicRela.RelaTitle].ToString().Trim(); //关系标题
objgs_KnowledgesLogicRelaEN.RelaTypeId = objRow[congs_KnowledgesLogicRela.RelaTypeId] == DBNull.Value ? null : objRow[congs_KnowledgesLogicRela.RelaTypeId].ToString().Trim(); //关系类型Id
objgs_KnowledgesLogicRelaEN.CourseId = objRow[congs_KnowledgesLogicRela.CourseId].ToString().Trim(); //课程Id
objgs_KnowledgesLogicRelaEN.UpdUser = objRow[congs_KnowledgesLogicRela.UpdUser] == DBNull.Value ? null : objRow[congs_KnowledgesLogicRela.UpdUser].ToString().Trim(); //修改人
objgs_KnowledgesLogicRelaEN.UpdDate = objRow[congs_KnowledgesLogicRela.UpdDate] == DBNull.Value ? null : objRow[congs_KnowledgesLogicRela.UpdDate].ToString().Trim(); //修改日期
objgs_KnowledgesLogicRelaEN.Memo = objRow[congs_KnowledgesLogicRela.Memo] == DBNull.Value ? null : objRow[congs_KnowledgesLogicRela.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objgs_KnowledgesLogicRelaEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objgs_KnowledgesLogicRelaEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsgs_KnowledgesLogicRelaEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsgs_KnowledgesLogicRelaEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsgs_KnowledgesLogicRelaEN> arrObjLst = new List<clsgs_KnowledgesLogicRelaEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsgs_KnowledgesLogicRelaEN objgs_KnowledgesLogicRelaEN = new clsgs_KnowledgesLogicRelaEN();
try
{
objgs_KnowledgesLogicRelaEN.mId = Int32.Parse(objRow[congs_KnowledgesLogicRela.mId].ToString().Trim()); //mId
objgs_KnowledgesLogicRelaEN.CourseKnowledgeIdA = objRow[congs_KnowledgesLogicRela.CourseKnowledgeIdA].ToString().Trim(); //课程知识点AId
objgs_KnowledgesLogicRelaEN.CourseKnowledgeTitleA = objRow[congs_KnowledgesLogicRela.CourseKnowledgeTitleA] == DBNull.Value ? null : objRow[congs_KnowledgesLogicRela.CourseKnowledgeTitleA].ToString().Trim(); //课程知识点标题A
objgs_KnowledgesLogicRelaEN.CourseKnowledgeIdB = objRow[congs_KnowledgesLogicRela.CourseKnowledgeIdB].ToString().Trim(); //课程知识点BId
objgs_KnowledgesLogicRelaEN.CourseKnowledgeTitleB = objRow[congs_KnowledgesLogicRela.CourseKnowledgeTitleB] == DBNull.Value ? null : objRow[congs_KnowledgesLogicRela.CourseKnowledgeTitleB].ToString().Trim(); //课程知识点标题B
objgs_KnowledgesLogicRelaEN.KnowledgeGraphId = objRow[congs_KnowledgesLogicRela.KnowledgeGraphId] == DBNull.Value ? null : objRow[congs_KnowledgesLogicRela.KnowledgeGraphId].ToString().Trim(); //知识点图Id
objgs_KnowledgesLogicRelaEN.SourceAnchor = objRow[congs_KnowledgesLogicRela.SourceAnchor] == DBNull.Value ? null : objRow[congs_KnowledgesLogicRela.SourceAnchor].ToString().Trim(); //源锚点
objgs_KnowledgesLogicRelaEN.TargetAnchor = objRow[congs_KnowledgesLogicRela.TargetAnchor] == DBNull.Value ? null : objRow[congs_KnowledgesLogicRela.TargetAnchor].ToString().Trim(); //目标锚点
objgs_KnowledgesLogicRelaEN.RelaTitle = objRow[congs_KnowledgesLogicRela.RelaTitle] == DBNull.Value ? null : objRow[congs_KnowledgesLogicRela.RelaTitle].ToString().Trim(); //关系标题
objgs_KnowledgesLogicRelaEN.RelaTypeId = objRow[congs_KnowledgesLogicRela.RelaTypeId] == DBNull.Value ? null : objRow[congs_KnowledgesLogicRela.RelaTypeId].ToString().Trim(); //关系类型Id
objgs_KnowledgesLogicRelaEN.CourseId = objRow[congs_KnowledgesLogicRela.CourseId].ToString().Trim(); //课程Id
objgs_KnowledgesLogicRelaEN.UpdUser = objRow[congs_KnowledgesLogicRela.UpdUser] == DBNull.Value ? null : objRow[congs_KnowledgesLogicRela.UpdUser].ToString().Trim(); //修改人
objgs_KnowledgesLogicRelaEN.UpdDate = objRow[congs_KnowledgesLogicRela.UpdDate] == DBNull.Value ? null : objRow[congs_KnowledgesLogicRela.UpdDate].ToString().Trim(); //修改日期
objgs_KnowledgesLogicRelaEN.Memo = objRow[congs_KnowledgesLogicRela.Memo] == DBNull.Value ? null : objRow[congs_KnowledgesLogicRela.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objgs_KnowledgesLogicRelaEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objgs_KnowledgesLogicRelaEN);
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
public static List<clsgs_KnowledgesLogicRelaEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsgs_KnowledgesLogicRelaEN> arrObjLst = new List<clsgs_KnowledgesLogicRelaEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsgs_KnowledgesLogicRelaEN objgs_KnowledgesLogicRelaEN = new clsgs_KnowledgesLogicRelaEN();
try
{
objgs_KnowledgesLogicRelaEN.mId = Int32.Parse(objRow[congs_KnowledgesLogicRela.mId].ToString().Trim()); //mId
objgs_KnowledgesLogicRelaEN.CourseKnowledgeIdA = objRow[congs_KnowledgesLogicRela.CourseKnowledgeIdA].ToString().Trim(); //课程知识点AId
objgs_KnowledgesLogicRelaEN.CourseKnowledgeTitleA = objRow[congs_KnowledgesLogicRela.CourseKnowledgeTitleA] == DBNull.Value ? null : objRow[congs_KnowledgesLogicRela.CourseKnowledgeTitleA].ToString().Trim(); //课程知识点标题A
objgs_KnowledgesLogicRelaEN.CourseKnowledgeIdB = objRow[congs_KnowledgesLogicRela.CourseKnowledgeIdB].ToString().Trim(); //课程知识点BId
objgs_KnowledgesLogicRelaEN.CourseKnowledgeTitleB = objRow[congs_KnowledgesLogicRela.CourseKnowledgeTitleB] == DBNull.Value ? null : objRow[congs_KnowledgesLogicRela.CourseKnowledgeTitleB].ToString().Trim(); //课程知识点标题B
objgs_KnowledgesLogicRelaEN.KnowledgeGraphId = objRow[congs_KnowledgesLogicRela.KnowledgeGraphId] == DBNull.Value ? null : objRow[congs_KnowledgesLogicRela.KnowledgeGraphId].ToString().Trim(); //知识点图Id
objgs_KnowledgesLogicRelaEN.SourceAnchor = objRow[congs_KnowledgesLogicRela.SourceAnchor] == DBNull.Value ? null : objRow[congs_KnowledgesLogicRela.SourceAnchor].ToString().Trim(); //源锚点
objgs_KnowledgesLogicRelaEN.TargetAnchor = objRow[congs_KnowledgesLogicRela.TargetAnchor] == DBNull.Value ? null : objRow[congs_KnowledgesLogicRela.TargetAnchor].ToString().Trim(); //目标锚点
objgs_KnowledgesLogicRelaEN.RelaTitle = objRow[congs_KnowledgesLogicRela.RelaTitle] == DBNull.Value ? null : objRow[congs_KnowledgesLogicRela.RelaTitle].ToString().Trim(); //关系标题
objgs_KnowledgesLogicRelaEN.RelaTypeId = objRow[congs_KnowledgesLogicRela.RelaTypeId] == DBNull.Value ? null : objRow[congs_KnowledgesLogicRela.RelaTypeId].ToString().Trim(); //关系类型Id
objgs_KnowledgesLogicRelaEN.CourseId = objRow[congs_KnowledgesLogicRela.CourseId].ToString().Trim(); //课程Id
objgs_KnowledgesLogicRelaEN.UpdUser = objRow[congs_KnowledgesLogicRela.UpdUser] == DBNull.Value ? null : objRow[congs_KnowledgesLogicRela.UpdUser].ToString().Trim(); //修改人
objgs_KnowledgesLogicRelaEN.UpdDate = objRow[congs_KnowledgesLogicRela.UpdDate] == DBNull.Value ? null : objRow[congs_KnowledgesLogicRela.UpdDate].ToString().Trim(); //修改日期
objgs_KnowledgesLogicRelaEN.Memo = objRow[congs_KnowledgesLogicRela.Memo] == DBNull.Value ? null : objRow[congs_KnowledgesLogicRela.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objgs_KnowledgesLogicRelaEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objgs_KnowledgesLogicRelaEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsgs_KnowledgesLogicRelaEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsgs_KnowledgesLogicRelaEN> arrObjLst = new List<clsgs_KnowledgesLogicRelaEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsgs_KnowledgesLogicRelaEN objgs_KnowledgesLogicRelaEN = new clsgs_KnowledgesLogicRelaEN();
try
{
objgs_KnowledgesLogicRelaEN.mId = Int32.Parse(objRow[congs_KnowledgesLogicRela.mId].ToString().Trim()); //mId
objgs_KnowledgesLogicRelaEN.CourseKnowledgeIdA = objRow[congs_KnowledgesLogicRela.CourseKnowledgeIdA].ToString().Trim(); //课程知识点AId
objgs_KnowledgesLogicRelaEN.CourseKnowledgeTitleA = objRow[congs_KnowledgesLogicRela.CourseKnowledgeTitleA] == DBNull.Value ? null : objRow[congs_KnowledgesLogicRela.CourseKnowledgeTitleA].ToString().Trim(); //课程知识点标题A
objgs_KnowledgesLogicRelaEN.CourseKnowledgeIdB = objRow[congs_KnowledgesLogicRela.CourseKnowledgeIdB].ToString().Trim(); //课程知识点BId
objgs_KnowledgesLogicRelaEN.CourseKnowledgeTitleB = objRow[congs_KnowledgesLogicRela.CourseKnowledgeTitleB] == DBNull.Value ? null : objRow[congs_KnowledgesLogicRela.CourseKnowledgeTitleB].ToString().Trim(); //课程知识点标题B
objgs_KnowledgesLogicRelaEN.KnowledgeGraphId = objRow[congs_KnowledgesLogicRela.KnowledgeGraphId] == DBNull.Value ? null : objRow[congs_KnowledgesLogicRela.KnowledgeGraphId].ToString().Trim(); //知识点图Id
objgs_KnowledgesLogicRelaEN.SourceAnchor = objRow[congs_KnowledgesLogicRela.SourceAnchor] == DBNull.Value ? null : objRow[congs_KnowledgesLogicRela.SourceAnchor].ToString().Trim(); //源锚点
objgs_KnowledgesLogicRelaEN.TargetAnchor = objRow[congs_KnowledgesLogicRela.TargetAnchor] == DBNull.Value ? null : objRow[congs_KnowledgesLogicRela.TargetAnchor].ToString().Trim(); //目标锚点
objgs_KnowledgesLogicRelaEN.RelaTitle = objRow[congs_KnowledgesLogicRela.RelaTitle] == DBNull.Value ? null : objRow[congs_KnowledgesLogicRela.RelaTitle].ToString().Trim(); //关系标题
objgs_KnowledgesLogicRelaEN.RelaTypeId = objRow[congs_KnowledgesLogicRela.RelaTypeId] == DBNull.Value ? null : objRow[congs_KnowledgesLogicRela.RelaTypeId].ToString().Trim(); //关系类型Id
objgs_KnowledgesLogicRelaEN.CourseId = objRow[congs_KnowledgesLogicRela.CourseId].ToString().Trim(); //课程Id
objgs_KnowledgesLogicRelaEN.UpdUser = objRow[congs_KnowledgesLogicRela.UpdUser] == DBNull.Value ? null : objRow[congs_KnowledgesLogicRela.UpdUser].ToString().Trim(); //修改人
objgs_KnowledgesLogicRelaEN.UpdDate = objRow[congs_KnowledgesLogicRela.UpdDate] == DBNull.Value ? null : objRow[congs_KnowledgesLogicRela.UpdDate].ToString().Trim(); //修改日期
objgs_KnowledgesLogicRelaEN.Memo = objRow[congs_KnowledgesLogicRela.Memo] == DBNull.Value ? null : objRow[congs_KnowledgesLogicRela.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objgs_KnowledgesLogicRelaEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objgs_KnowledgesLogicRelaEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objgs_KnowledgesLogicRelaEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool Getgs_KnowledgesLogicRela(ref clsgs_KnowledgesLogicRelaEN objgs_KnowledgesLogicRelaEN)
{
bool bolResult = gs_KnowledgesLogicRelaDA.Getgs_KnowledgesLogicRela(ref objgs_KnowledgesLogicRelaEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public static clsgs_KnowledgesLogicRelaEN GetObjBymId(long lngmId)
{
clsgs_KnowledgesLogicRelaEN objgs_KnowledgesLogicRelaEN = gs_KnowledgesLogicRelaDA.GetObjBymId(lngmId);
return objgs_KnowledgesLogicRelaEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsgs_KnowledgesLogicRelaEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsgs_KnowledgesLogicRelaEN objgs_KnowledgesLogicRelaEN = gs_KnowledgesLogicRelaDA.GetFirstObj(strWhereCond);
 return objgs_KnowledgesLogicRelaEN;
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
public static clsgs_KnowledgesLogicRelaEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsgs_KnowledgesLogicRelaEN objgs_KnowledgesLogicRelaEN = gs_KnowledgesLogicRelaDA.GetObjByDataRow(objRow);
 return objgs_KnowledgesLogicRelaEN;
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
public static clsgs_KnowledgesLogicRelaEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsgs_KnowledgesLogicRelaEN objgs_KnowledgesLogicRelaEN = gs_KnowledgesLogicRelaDA.GetObjByDataRow(objRow);
 return objgs_KnowledgesLogicRelaEN;
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
 /// <param name = "lstgs_KnowledgesLogicRelaObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsgs_KnowledgesLogicRelaEN GetObjBymIdFromList(long lngmId, List<clsgs_KnowledgesLogicRelaEN> lstgs_KnowledgesLogicRelaObjLst)
{
foreach (clsgs_KnowledgesLogicRelaEN objgs_KnowledgesLogicRelaEN in lstgs_KnowledgesLogicRelaObjLst)
{
if (objgs_KnowledgesLogicRelaEN.mId == lngmId)
{
return objgs_KnowledgesLogicRelaEN;
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
 lngmId = new clsgs_KnowledgesLogicRelaDA().GetFirstID(strWhereCond);
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
 arrList = gs_KnowledgesLogicRelaDA.GetID(strWhereCond);
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
bool bolIsExist = gs_KnowledgesLogicRelaDA.IsExistCondRec(strWhereCond);
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
bool bolIsExist = gs_KnowledgesLogicRelaDA.IsExist(lngmId);
return bolIsExist;
}

/// <summary>
/// 设置修改时间
/// </summary>
/// <param name = "lngmId">mId</param>
/// <param name = "strOpUser">修改用户</param>
/// <returns>是否成功？</returns>
public static bool SetUpdDate(long lngmId, string strOpUser)
{
clsgs_KnowledgesLogicRelaEN objgs_KnowledgesLogicRelaEN = clsgs_KnowledgesLogicRelaBL.GetObjBymId(lngmId);
objgs_KnowledgesLogicRelaEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
return clsgs_KnowledgesLogicRelaBL.UpdateBySql2(objgs_KnowledgesLogicRelaEN);
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
 bolIsExist = clsgs_KnowledgesLogicRelaDA.IsExistTable();
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
 bolIsExist = gs_KnowledgesLogicRelaDA.IsExistTable(strTabName);
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
 /// <param name = "objgs_KnowledgesLogicRelaEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecordBySql2(clsgs_KnowledgesLogicRelaEN objgs_KnowledgesLogicRelaEN, bool bolIsNeedCheckUniqueness=true)
{
if (bolIsNeedCheckUniqueness == true && objgs_KnowledgesLogicRelaEN.CheckUniqueness() == false)
{
var strMsg = string.Format("记录已经存在!知识点图Id = [{0}],课程知识点AId = [{1}],课程知识点BId = [{2}]的数据已经存在!(in clsgs_KnowledgesLogicRelaBL.AddNewRecordBySql2)", objgs_KnowledgesLogicRelaEN.KnowledgeGraphId,objgs_KnowledgesLogicRelaEN.CourseKnowledgeIdA,objgs_KnowledgesLogicRelaEN.CourseKnowledgeIdB);
throw new Exception(strMsg);
}
try
{
bool bolResult = gs_KnowledgesLogicRelaDA.AddNewRecordBySQL2(objgs_KnowledgesLogicRelaEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsgs_KnowledgesLogicRelaBL.ReFreshCache(objgs_KnowledgesLogicRelaEN.CourseId);

if (clsgs_KnowledgesLogicRelaBL.relatedActions != null)
{
clsgs_KnowledgesLogicRelaBL.relatedActions.UpdRelaTabDate(objgs_KnowledgesLogicRelaEN.mId, "SetUpdDate");
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
 /// <param name = "objgs_KnowledgesLogicRelaEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordBySql2WithReturnKey(clsgs_KnowledgesLogicRelaEN objgs_KnowledgesLogicRelaEN, bool bolIsNeedCheckUniqueness=true)
{
if (bolIsNeedCheckUniqueness == true && objgs_KnowledgesLogicRelaEN.CheckUniqueness() == false)
{
var strMsg = string.Format("记录已经存在!知识点图Id = [{0}],课程知识点AId = [{1}],课程知识点BId = [{2}]的数据已经存在!(in clsgs_KnowledgesLogicRelaBL.AddNewRecordBySql2WithReturnKey)", objgs_KnowledgesLogicRelaEN.KnowledgeGraphId,objgs_KnowledgesLogicRelaEN.CourseKnowledgeIdA,objgs_KnowledgesLogicRelaEN.CourseKnowledgeIdB);
throw new Exception(strMsg);
}
try
{
string strKey = gs_KnowledgesLogicRelaDA.AddNewRecordBySQL2WithReturnKey(objgs_KnowledgesLogicRelaEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsgs_KnowledgesLogicRelaBL.ReFreshCache(objgs_KnowledgesLogicRelaEN.CourseId);

if (clsgs_KnowledgesLogicRelaBL.relatedActions != null)
{
clsgs_KnowledgesLogicRelaBL.relatedActions.UpdRelaTabDate(objgs_KnowledgesLogicRelaEN.mId, "SetUpdDate");
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
 /// <param name = "objgs_KnowledgesLogicRelaEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(clsgs_KnowledgesLogicRelaEN objgs_KnowledgesLogicRelaEN)
{
try
{
bool bolResult = gs_KnowledgesLogicRelaDA.Update(objgs_KnowledgesLogicRelaEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsgs_KnowledgesLogicRelaBL.ReFreshCache(objgs_KnowledgesLogicRelaEN.CourseId);

if (clsgs_KnowledgesLogicRelaBL.relatedActions != null)
{
clsgs_KnowledgesLogicRelaBL.relatedActions.UpdRelaTabDate(objgs_KnowledgesLogicRelaEN.mId, "SetUpdDate");
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
 /// <param name = "objgs_KnowledgesLogicRelaEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateBySql2(clsgs_KnowledgesLogicRelaEN objgs_KnowledgesLogicRelaEN)
{
 if (objgs_KnowledgesLogicRelaEN.mId == 0)
 {
var strMsg = string.Format("(errid:Busi000065)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = gs_KnowledgesLogicRelaDA.UpdateBySql2(objgs_KnowledgesLogicRelaEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsgs_KnowledgesLogicRelaBL.ReFreshCache(objgs_KnowledgesLogicRelaEN.CourseId);

if (clsgs_KnowledgesLogicRelaBL.relatedActions != null)
{
clsgs_KnowledgesLogicRelaBL.relatedActions.UpdRelaTabDate(objgs_KnowledgesLogicRelaEN.mId, "SetUpdDate");
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
 clsgs_KnowledgesLogicRelaEN objgs_KnowledgesLogicRelaEN = clsgs_KnowledgesLogicRelaBL.GetObjBymId(lngmId);

if (clsgs_KnowledgesLogicRelaBL.relatedActions != null)
{
clsgs_KnowledgesLogicRelaBL.relatedActions.UpdRelaTabDate(objgs_KnowledgesLogicRelaEN.mId, "SetUpdDate");
}
if (objgs_KnowledgesLogicRelaEN != null)
{
int intRecNum = gs_KnowledgesLogicRelaDA.DelRecord(lngmId);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
ReFreshCache(objgs_KnowledgesLogicRelaEN.CourseId);
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
/// <param name="lngmId">表关键字</param>
 /// <param name = "strCourseId">缓存的分类字段</param>
/// <returns></returns>
public static bool DelRecordEx(long lngmId , string strCourseId)
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsgs_KnowledgesLogicRelaDA.GetSpecSQLObj();
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
//删除与表:[gs_KnowledgesLogicRela]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//congs_KnowledgesLogicRela.mId,
//lngmId);
//        clsgs_KnowledgesLogicRelaBL.Delgs_KnowledgesLogicRelasByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsgs_KnowledgesLogicRelaBL.DelRecord(lngmId, strCourseId, objConnection, objSqlTransaction);
objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsgs_KnowledgesLogicRelaBLEx", "DelRecordEx", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("扩展删除记录出错:{0}!keyId = {1}.({2})",
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
 /// 功能:删除关键字所指的记录,使用事务
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DelRecordWithTransaction_S)
 /// </summary>
 /// <param name = "lngmId">给定的关键字值</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回删除是否成功?</returns>
public static bool DelRecord(long lngmId, string strCourseId, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
if (clsgs_KnowledgesLogicRelaBL.relatedActions != null)
{
clsgs_KnowledgesLogicRelaBL.relatedActions.UpdRelaTabDate(lngmId, "UpdRelaTabDate");
}
bool bolResult = gs_KnowledgesLogicRelaDA.DelRecord(lngmId,objSqlConnection,objSqlTransaction);
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
 /// <param name = "arrmIdLst">给定的关键字值列表</param>
 /// <returns>返回删除的记录数</returns>
public static int Delgs_KnowledgesLogicRelas(List<string> arrmIdLst)
{
if (arrmIdLst.Count == 0) return 0;
try
{
if (clsgs_KnowledgesLogicRelaBL.relatedActions != null)
{
foreach (var strmId in arrmIdLst)
{
long lngmId = long.Parse(strmId);
clsgs_KnowledgesLogicRelaBL.relatedActions.UpdRelaTabDate(lngmId, "UpdRelaTabDate");
}
}
 clsgs_KnowledgesLogicRelaEN objgs_KnowledgesLogicRelaEN = clsgs_KnowledgesLogicRelaBL.GetObjBymId(long.Parse(arrmIdLst[0]));
int intDelRecNum = gs_KnowledgesLogicRelaDA.Delgs_KnowledgesLogicRela(arrmIdLst);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
ReFreshCache(objgs_KnowledgesLogicRelaEN.CourseId);
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
public static int Delgs_KnowledgesLogicRelasByCond(string strWhereCond)
{
try
{
if (clsgs_KnowledgesLogicRelaBL.relatedActions != null)
{
List<string> arrmId = GetPrimaryKeyID_S(strWhereCond);
foreach (var strmId in arrmId)
{
long lngmId = long.Parse(strmId);
clsgs_KnowledgesLogicRelaBL.relatedActions.UpdRelaTabDate(lngmId, "UpdRelaTabDate");
}
}
List<string> arrCourseId = GetFldValue(congs_KnowledgesLogicRela.CourseId, strWhereCond);
int intRecNum = gs_KnowledgesLogicRelaDA.Delgs_KnowledgesLogicRela(strWhereCond);
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
/// 这里仅仅是演示函数,使用时请复制到扩展类:[gs_KnowledgesLogicRela]中改名为:[DelRecord4MultiTabEx]使用
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DelRecord4MultiTab)
/// </summary>
/// <param name="lngmId">表关键字</param>
 /// <param name = "strCourseId">缓存的分类字段</param>
/// <returns></returns>
public static bool DelRecord4MultiTab(long lngmId, string strCourseId)
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsgs_KnowledgesLogicRelaDA.GetSpecSQLObj();
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
//删除与表:[gs_KnowledgesLogicRela]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conStudent.id_College,
//strid_College);
//        clsStudentBL.DelStudentsByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsgs_KnowledgesLogicRelaBL.DelRecord(lngmId, strCourseId, objConnection, objSqlTransaction);
                objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsgs_KnowledgesLogicRelaBL", "DelRecord4MultiTab", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("删除多表记录出错:{0}!keyId = {1}.({2})",
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
 /// <param name = "objgs_KnowledgesLogicRelaENS">源对象</param>
 /// <param name = "objgs_KnowledgesLogicRelaENT">目标对象</param>
 public static void CopyTo(clsgs_KnowledgesLogicRelaEN objgs_KnowledgesLogicRelaENS, clsgs_KnowledgesLogicRelaEN objgs_KnowledgesLogicRelaENT)
{
try
{
objgs_KnowledgesLogicRelaENT.mId = objgs_KnowledgesLogicRelaENS.mId; //mId
objgs_KnowledgesLogicRelaENT.CourseKnowledgeIdA = objgs_KnowledgesLogicRelaENS.CourseKnowledgeIdA; //课程知识点AId
objgs_KnowledgesLogicRelaENT.CourseKnowledgeTitleA = objgs_KnowledgesLogicRelaENS.CourseKnowledgeTitleA; //课程知识点标题A
objgs_KnowledgesLogicRelaENT.CourseKnowledgeIdB = objgs_KnowledgesLogicRelaENS.CourseKnowledgeIdB; //课程知识点BId
objgs_KnowledgesLogicRelaENT.CourseKnowledgeTitleB = objgs_KnowledgesLogicRelaENS.CourseKnowledgeTitleB; //课程知识点标题B
objgs_KnowledgesLogicRelaENT.KnowledgeGraphId = objgs_KnowledgesLogicRelaENS.KnowledgeGraphId; //知识点图Id
objgs_KnowledgesLogicRelaENT.SourceAnchor = objgs_KnowledgesLogicRelaENS.SourceAnchor; //源锚点
objgs_KnowledgesLogicRelaENT.TargetAnchor = objgs_KnowledgesLogicRelaENS.TargetAnchor; //目标锚点
objgs_KnowledgesLogicRelaENT.RelaTitle = objgs_KnowledgesLogicRelaENS.RelaTitle; //关系标题
objgs_KnowledgesLogicRelaENT.RelaTypeId = objgs_KnowledgesLogicRelaENS.RelaTypeId; //关系类型Id
objgs_KnowledgesLogicRelaENT.CourseId = objgs_KnowledgesLogicRelaENS.CourseId; //课程Id
objgs_KnowledgesLogicRelaENT.UpdUser = objgs_KnowledgesLogicRelaENS.UpdUser; //修改人
objgs_KnowledgesLogicRelaENT.UpdDate = objgs_KnowledgesLogicRelaENS.UpdDate; //修改日期
objgs_KnowledgesLogicRelaENT.Memo = objgs_KnowledgesLogicRelaENS.Memo; //备注
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
 /// <param name = "objgs_KnowledgesLogicRelaEN">源简化对象</param>
 public static void SetUpdFlag(clsgs_KnowledgesLogicRelaEN objgs_KnowledgesLogicRelaEN)
{
try
{
objgs_KnowledgesLogicRelaEN.ClearUpdateState();
   string strsfUpdFldSetStr = objgs_KnowledgesLogicRelaEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(congs_KnowledgesLogicRela.mId, new clsStrCompareIgnoreCase())  ==  true)
{
objgs_KnowledgesLogicRelaEN.mId = objgs_KnowledgesLogicRelaEN.mId; //mId
}
if (arrFldSet.Contains(congs_KnowledgesLogicRela.CourseKnowledgeIdA, new clsStrCompareIgnoreCase())  ==  true)
{
objgs_KnowledgesLogicRelaEN.CourseKnowledgeIdA = objgs_KnowledgesLogicRelaEN.CourseKnowledgeIdA; //课程知识点AId
}
if (arrFldSet.Contains(congs_KnowledgesLogicRela.CourseKnowledgeTitleA, new clsStrCompareIgnoreCase())  ==  true)
{
objgs_KnowledgesLogicRelaEN.CourseKnowledgeTitleA = objgs_KnowledgesLogicRelaEN.CourseKnowledgeTitleA == "[null]" ? null :  objgs_KnowledgesLogicRelaEN.CourseKnowledgeTitleA; //课程知识点标题A
}
if (arrFldSet.Contains(congs_KnowledgesLogicRela.CourseKnowledgeIdB, new clsStrCompareIgnoreCase())  ==  true)
{
objgs_KnowledgesLogicRelaEN.CourseKnowledgeIdB = objgs_KnowledgesLogicRelaEN.CourseKnowledgeIdB; //课程知识点BId
}
if (arrFldSet.Contains(congs_KnowledgesLogicRela.CourseKnowledgeTitleB, new clsStrCompareIgnoreCase())  ==  true)
{
objgs_KnowledgesLogicRelaEN.CourseKnowledgeTitleB = objgs_KnowledgesLogicRelaEN.CourseKnowledgeTitleB == "[null]" ? null :  objgs_KnowledgesLogicRelaEN.CourseKnowledgeTitleB; //课程知识点标题B
}
if (arrFldSet.Contains(congs_KnowledgesLogicRela.KnowledgeGraphId, new clsStrCompareIgnoreCase())  ==  true)
{
objgs_KnowledgesLogicRelaEN.KnowledgeGraphId = objgs_KnowledgesLogicRelaEN.KnowledgeGraphId == "[null]" ? null :  objgs_KnowledgesLogicRelaEN.KnowledgeGraphId; //知识点图Id
}
if (arrFldSet.Contains(congs_KnowledgesLogicRela.SourceAnchor, new clsStrCompareIgnoreCase())  ==  true)
{
objgs_KnowledgesLogicRelaEN.SourceAnchor = objgs_KnowledgesLogicRelaEN.SourceAnchor == "[null]" ? null :  objgs_KnowledgesLogicRelaEN.SourceAnchor; //源锚点
}
if (arrFldSet.Contains(congs_KnowledgesLogicRela.TargetAnchor, new clsStrCompareIgnoreCase())  ==  true)
{
objgs_KnowledgesLogicRelaEN.TargetAnchor = objgs_KnowledgesLogicRelaEN.TargetAnchor == "[null]" ? null :  objgs_KnowledgesLogicRelaEN.TargetAnchor; //目标锚点
}
if (arrFldSet.Contains(congs_KnowledgesLogicRela.RelaTitle, new clsStrCompareIgnoreCase())  ==  true)
{
objgs_KnowledgesLogicRelaEN.RelaTitle = objgs_KnowledgesLogicRelaEN.RelaTitle == "[null]" ? null :  objgs_KnowledgesLogicRelaEN.RelaTitle; //关系标题
}
if (arrFldSet.Contains(congs_KnowledgesLogicRela.RelaTypeId, new clsStrCompareIgnoreCase())  ==  true)
{
objgs_KnowledgesLogicRelaEN.RelaTypeId = objgs_KnowledgesLogicRelaEN.RelaTypeId == "[null]" ? null :  objgs_KnowledgesLogicRelaEN.RelaTypeId; //关系类型Id
}
if (arrFldSet.Contains(congs_KnowledgesLogicRela.CourseId, new clsStrCompareIgnoreCase())  ==  true)
{
objgs_KnowledgesLogicRelaEN.CourseId = objgs_KnowledgesLogicRelaEN.CourseId; //课程Id
}
if (arrFldSet.Contains(congs_KnowledgesLogicRela.UpdUser, new clsStrCompareIgnoreCase())  ==  true)
{
objgs_KnowledgesLogicRelaEN.UpdUser = objgs_KnowledgesLogicRelaEN.UpdUser == "[null]" ? null :  objgs_KnowledgesLogicRelaEN.UpdUser; //修改人
}
if (arrFldSet.Contains(congs_KnowledgesLogicRela.UpdDate, new clsStrCompareIgnoreCase())  ==  true)
{
objgs_KnowledgesLogicRelaEN.UpdDate = objgs_KnowledgesLogicRelaEN.UpdDate == "[null]" ? null :  objgs_KnowledgesLogicRelaEN.UpdDate; //修改日期
}
if (arrFldSet.Contains(congs_KnowledgesLogicRela.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objgs_KnowledgesLogicRelaEN.Memo = objgs_KnowledgesLogicRelaEN.Memo == "[null]" ? null :  objgs_KnowledgesLogicRelaEN.Memo; //备注
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
 /// <param name = "objgs_KnowledgesLogicRelaEN">源简化对象</param>
 public static void AccessFldValueNull(clsgs_KnowledgesLogicRelaEN objgs_KnowledgesLogicRelaEN)
{
try
{
if (objgs_KnowledgesLogicRelaEN.CourseKnowledgeTitleA == "[null]") objgs_KnowledgesLogicRelaEN.CourseKnowledgeTitleA = null; //课程知识点标题A
if (objgs_KnowledgesLogicRelaEN.CourseKnowledgeTitleB == "[null]") objgs_KnowledgesLogicRelaEN.CourseKnowledgeTitleB = null; //课程知识点标题B
if (objgs_KnowledgesLogicRelaEN.KnowledgeGraphId == "[null]") objgs_KnowledgesLogicRelaEN.KnowledgeGraphId = null; //知识点图Id
if (objgs_KnowledgesLogicRelaEN.SourceAnchor == "[null]") objgs_KnowledgesLogicRelaEN.SourceAnchor = null; //源锚点
if (objgs_KnowledgesLogicRelaEN.TargetAnchor == "[null]") objgs_KnowledgesLogicRelaEN.TargetAnchor = null; //目标锚点
if (objgs_KnowledgesLogicRelaEN.RelaTitle == "[null]") objgs_KnowledgesLogicRelaEN.RelaTitle = null; //关系标题
if (objgs_KnowledgesLogicRelaEN.RelaTypeId == "[null]") objgs_KnowledgesLogicRelaEN.RelaTypeId = null; //关系类型Id
if (objgs_KnowledgesLogicRelaEN.UpdUser == "[null]") objgs_KnowledgesLogicRelaEN.UpdUser = null; //修改人
if (objgs_KnowledgesLogicRelaEN.UpdDate == "[null]") objgs_KnowledgesLogicRelaEN.UpdDate = null; //修改日期
if (objgs_KnowledgesLogicRelaEN.Memo == "[null]") objgs_KnowledgesLogicRelaEN.Memo = null; //备注
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
public static void CheckPropertyNew(clsgs_KnowledgesLogicRelaEN objgs_KnowledgesLogicRelaEN)
{
 gs_KnowledgesLogicRelaDA.CheckPropertyNew(objgs_KnowledgesLogicRelaEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(clsgs_KnowledgesLogicRelaEN objgs_KnowledgesLogicRelaEN)
{
 gs_KnowledgesLogicRelaDA.CheckProperty4Condition(objgs_KnowledgesLogicRelaEN);
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
if (clsgs_KnowledgesLogicRelaBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsgs_KnowledgesLogicRelaBL没有刷新缓存机制(clsgs_KnowledgesLogicRelaBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by mId");
//if (arrgs_KnowledgesLogicRelaObjLstCache == null)
//{
//arrgs_KnowledgesLogicRelaObjLstCache = gs_KnowledgesLogicRelaDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "lngmId">所给的关键字</param>
 /// <param name = "strCourseId">缓存的分类字段</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsgs_KnowledgesLogicRelaEN GetObjBymIdCache(long lngmId, string strCourseId)
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
string strKey = string.Format("{0}_{1}", clsgs_KnowledgesLogicRelaEN._CurrTabName, strCourseId);
List<clsgs_KnowledgesLogicRelaEN> arrgs_KnowledgesLogicRelaObjLstCache = GetObjLstCache(strCourseId);
IEnumerable <clsgs_KnowledgesLogicRelaEN> arrgs_KnowledgesLogicRelaObjLst_Sel =
arrgs_KnowledgesLogicRelaObjLstCache
.Where(x=> x.mId == lngmId 
);
if (arrgs_KnowledgesLogicRelaObjLst_Sel.Count() == 0)
{
   clsgs_KnowledgesLogicRelaEN obj = clsgs_KnowledgesLogicRelaBL.GetObjBymId(lngmId);
   if (obj != null)
 {
if (obj.CourseId == strCourseId)
{
CacheHelper.Remove(strKey);
     return obj;
}
else
{
string strMsg = string.Format("错误: 关键字:{0}不属于分类:{1},请检查!(In {2})", lngmId, strCourseId, clsStackTrace.GetCurrClassFunction());
clsSysParaEN.objLog.WriteDebugLog(strMsg);
throw new Exception(strMsg);
}
 }
return null;
}
return arrgs_KnowledgesLogicRelaObjLst_Sel.First();
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsgs_KnowledgesLogicRelaEN> GetAllgs_KnowledgesLogicRelaObjLstCache(string strCourseId)
{
//获取缓存中的对象列表
List<clsgs_KnowledgesLogicRelaEN> arrgs_KnowledgesLogicRelaObjLstCache = GetObjLstCache(strCourseId); 
return arrgs_KnowledgesLogicRelaObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsgs_KnowledgesLogicRelaEN> GetObjLstCache(string strCourseId)
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
string strKey = string.Format("{0}_{1}", clsgs_KnowledgesLogicRelaEN._CurrTabName, strCourseId);
string strCondition = string.Format("CourseId='{0}'", strCourseId);
List<clsgs_KnowledgesLogicRelaEN> arrgs_KnowledgesLogicRelaObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst(strCondition); });
return arrgs_KnowledgesLogicRelaObjLstCache;
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
string strKey = string.Format("{0}_{1}", clsgs_KnowledgesLogicRelaEN._CurrTabName, strCourseId);
CacheHelper.Remove(strKey);
clsgs_KnowledgesLogicRelaEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
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
if (clsgs_KnowledgesLogicRelaEN._RefreshTimeLst.Count == 0) return "";
return clsgs_KnowledgesLogicRelaEN._RefreshTimeLst[clsgs_KnowledgesLogicRelaEN._RefreshTimeLst.Count - 1];
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
if (clsgs_KnowledgesLogicRelaBL.objCommFun4BL != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}_{1}", clsgs_KnowledgesLogicRelaEN._CurrTabName, strCourseId);
CacheHelper.Remove(strKey);
clsgs_KnowledgesLogicRelaEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
clsgs_KnowledgesLogicRelaBL.objCommFun4BL.ReFreshCache(strCourseId);
}
}


 #endregion 缓存操作


 #region 检查唯一性

 /// <summary>
 /// 获取检查唯一性条件串(Uniqueness)--gs_KnowledgesLogicRela(知识点逻辑关系表)
 /// 唯一性条件:KnowledgeGraphId_CourseKnowledgeIdA_CourseKnowledgeIdB
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetUniquenessConditionString)
 /// </summary>
 /// <param name = "objgs_KnowledgesLogicRelaEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(clsgs_KnowledgesLogicRelaEN objgs_KnowledgesLogicRelaEN)
{
//检测记录是否存在
string strResult = gs_KnowledgesLogicRelaDA.GetUniCondStr(objgs_KnowledgesLogicRelaEN);
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
public static string Func(string strInFldName, string strOutFldName, long lngmId, string strCourseId)
{
if (strInFldName != congs_KnowledgesLogicRela.mId)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (congs_KnowledgesLogicRela.AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", congs_KnowledgesLogicRela.AttributeName));
throw new Exception(strMsg);
}
var objgs_KnowledgesLogicRela = clsgs_KnowledgesLogicRelaBL.GetObjBymIdCache(lngmId, strCourseId);
if (objgs_KnowledgesLogicRela == null) return "";
return objgs_KnowledgesLogicRela[strOutFldName].ToString();
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
int intRecCount = clsgs_KnowledgesLogicRelaDA.GetRecCount(strTabName);
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
int intRecCount = clsgs_KnowledgesLogicRelaDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsgs_KnowledgesLogicRelaDA.GetRecCount();
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
int intRecCount = clsgs_KnowledgesLogicRelaDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objgs_KnowledgesLogicRelaCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsgs_KnowledgesLogicRelaEN objgs_KnowledgesLogicRelaCond)
{
 string strCourseId = objgs_KnowledgesLogicRelaCond.CourseId;
 if (string.IsNullOrEmpty(strCourseId) == true)
{
string strMsg = string.Format("(errid:Busi000174)在表中,缓存分类字段值不能为空!(clsgs_KnowledgesLogicRelaBL:GetRecCountByCondCache)");
throw new Exception(strMsg);
}
List<clsgs_KnowledgesLogicRelaEN> arrObjLstCache = GetObjLstCache(strCourseId);
IEnumerable <clsgs_KnowledgesLogicRelaEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in congs_KnowledgesLogicRela.AttributeName)
{
if (objgs_KnowledgesLogicRelaCond.IsUpdated(strFldName) == false) continue;
if (objgs_KnowledgesLogicRelaCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objgs_KnowledgesLogicRelaCond[strFldName].ToString());
}
else
{
if (objgs_KnowledgesLogicRelaCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objgs_KnowledgesLogicRelaCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objgs_KnowledgesLogicRelaCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objgs_KnowledgesLogicRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objgs_KnowledgesLogicRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objgs_KnowledgesLogicRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objgs_KnowledgesLogicRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objgs_KnowledgesLogicRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objgs_KnowledgesLogicRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objgs_KnowledgesLogicRelaCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objgs_KnowledgesLogicRelaCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objgs_KnowledgesLogicRelaCond[strFldName]));
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
 List<string> arrList = clsgs_KnowledgesLogicRelaDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = gs_KnowledgesLogicRelaDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = gs_KnowledgesLogicRelaDA.GetFldValueNoDistinct(strFldName, strWhereCond);
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
int intRecCount = gs_KnowledgesLogicRelaDA.SetFldValue(strFldName, strValue, strWhereCond);
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
int intRecCount = clsgs_KnowledgesLogicRelaDA.SetFldValue(clsgs_KnowledgesLogicRelaEN._CurrTabName, strFldName, fltValue, strWhereCond);
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
int intRecCount = gs_KnowledgesLogicRelaDA.SetFldValue( strFldName, intValue, strWhereCond);
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
int intRecCount = clsgs_KnowledgesLogicRelaDA.SetFldValue(strTabName, strFldName, strValue, strWhereCond);
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
int intRecCount = clsgs_KnowledgesLogicRelaDA.SetFldValue(strTabName, strFldName, intValue, strWhereCond);
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
int intRecCount = clsgs_KnowledgesLogicRelaDA.SetFldValue(strTabName, strFldName, fltValue, strWhereCond);
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
  strCreateTabCode.Append("CREATE table [dbo].[gs_KnowledgesLogicRela] "); 
 strCreateTabCode.Append(" ( "); 
 // /**mId*/ 
 strCreateTabCode.Append(" mId bigint primary key identity, "); 
 // /**课程知识点AId*/ 
 strCreateTabCode.Append(" CourseKnowledgeIdA char(8) not Null, "); 
 // /**课程知识点标题A*/ 
 strCreateTabCode.Append(" CourseKnowledgeTitleA varchar(100) Null, "); 
 // /**课程知识点BId*/ 
 strCreateTabCode.Append(" CourseKnowledgeIdB char(8) not Null, "); 
 // /**课程知识点标题B*/ 
 strCreateTabCode.Append(" CourseKnowledgeTitleB varchar(100) Null, "); 
 // /**知识点图Id*/ 
 strCreateTabCode.Append(" KnowledgeGraphId char(10) Null, "); 
 // /**源锚点*/ 
 strCreateTabCode.Append(" SourceAnchor varchar(50) Null, "); 
 // /**目标锚点*/ 
 strCreateTabCode.Append(" TargetAnchor varchar(50) Null, "); 
 // /**关系标题*/ 
 strCreateTabCode.Append(" RelaTitle varchar(100) Null, "); 
 // /**关系类型Id*/ 
 strCreateTabCode.Append(" RelaTypeId char(2) Null, "); 
 // /**课程Id*/ 
 strCreateTabCode.Append(" CourseId char(8) not Null, "); 
 // /**修改人*/ 
 strCreateTabCode.Append(" UpdUser varchar(20) Null, "); 
 // /**修改日期*/ 
 strCreateTabCode.Append(" UpdDate varchar(20) Null, "); 
 // /**备注*/ 
 strCreateTabCode.Append(" Memo varchar(1000) Null, "); 
 // /**关系类型名*/ 
 strCreateTabCode.Append(" RelaTypeName varchar(50) Null, "); 
 // /**连连看图名*/ 
 strCreateTabCode.Append(" CourseKnowledgeNameB varchar(100) Null, "); 
 // /**连连看图名*/ 
 strCreateTabCode.Append(" CourseKnowledgeNameA varchar(100) Null, "); 
 // /**连连看图名*/ 
 strCreateTabCode.Append(" KnowledgeGraphName varchar(100) Null, "); 
 // /**知识点名称*/ 
 strCreateTabCode.Append(" KnowledgeName varchar(100) Null, "); 
 // /**知识点名称*/ 
 strCreateTabCode.Append(" KnowledgeNameB varchar(100) Null, "); 
 // /**知识点名称*/ 
 strCreateTabCode.Append(" KnowledgeNameA varchar(100) Null ");
 strCreateTabCode.Append(") "); 
  strCreateTabCode.Append("ON [PRIMARY] ");
  return strCreateTabCode.ToString();
}



 #endregion 表操作
}
 /// <summary>
 /// 知识点逻辑关系表(gs_KnowledgesLogicRela)
 /// 数据源类型:表
 /// (AutoGCLib.CommFun4BL4CSharp:GeneCode_This)
 /// </summary>
public class  clsCommFun4BL4gs_KnowledgesLogicRela : clsCommFun4BLV2
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
clsgs_KnowledgesLogicRelaBL.ReFreshThisCache(strCourseId);
}
}

}