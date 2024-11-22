
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clszx_ConceptVerBL
 表名:zx_ConceptVer(01120740)
 * 版本:2023.11.15.1(服务器:WIN-SRV103-116)
 日期:2023/11/15 23:08:11
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:研究生学习游戏化后台(变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:中学历史版本(zxHistoricalVersion)
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
using ExamLib.Entity;
using System.Data; 
using System.Data.SqlClient; 
using ExamLib.DAL;

namespace ExamLib.BusinessLogic
{
public static class  clszx_ConceptVerBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "lngConceptVId">表关键字</param>
 /// <returns>表对象</returns>
public static clszx_ConceptVerEN GetObj(this K_ConceptVId_zx_ConceptVer myKey)
{
clszx_ConceptVerEN objzx_ConceptVerEN = clszx_ConceptVerBL.zx_ConceptVerDA.GetObjByConceptVId(myKey.Value);
return objzx_ConceptVerEN;
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_AddNewRecord)
 /// </summary>
 /// <param name = "objzx_ConceptVerEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clszx_ConceptVerEN objzx_ConceptVerEN)
{
if (CheckUniqueness(objzx_ConceptVerEN) == false)
{
var strMsg = string.Format("记录已经存在!概念Id = [{0}],小组Id = [{1}]的数据已经存在!(in clszx_ConceptVerBL.AddNewRecord)", objzx_ConceptVerEN.zxConceptId,objzx_ConceptVerEN.GroupTextId);
throw new Exception(strMsg);
}
try
{
bool bolResult = clszx_ConceptVerBL.zx_ConceptVerDA.AddNewRecordBySQL2(objzx_ConceptVerEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clszx_ConceptVerBL.ReFreshCache();

if (clszx_ConceptVerBL.relatedActions != null)
{
clszx_ConceptVerBL.relatedActions.UpdRelaTabDate(objzx_ConceptVerEN.ConceptVId, "SetUpdDate");
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
public static bool AddRecordEx(this clszx_ConceptVerEN objzx_ConceptVerEN)
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
objzx_ConceptVerEN.CheckPropertyNew();
 ///5.2、检查唯一性
if (objzx_ConceptVerEN.CheckUniqueness() == false)
{
strMsg = string.Format("(概念Id(zxConceptId)=[{0}],小组Id(GroupTextId)=[{1}])已经存在,不能重复!", objzx_ConceptVerEN.zxConceptId, objzx_ConceptVerEN.GroupTextId);
throw new Exception(strMsg);
}
//6、把数据实体层的数据存贮到数据库中
objzx_ConceptVerEN.AddNewRecord();
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
 /// <param name = "objzx_ConceptVerEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordWithReturnKey(this clszx_ConceptVerEN objzx_ConceptVerEN)
{
if (CheckUniqueness(objzx_ConceptVerEN) == false)
{
var strMsg = string.Format("记录已经存在!概念Id = [{0}],小组Id = [{1}]的数据已经存在!(in clszx_ConceptVerBL.AddNewRecordWithReturnKey)", objzx_ConceptVerEN.zxConceptId,objzx_ConceptVerEN.GroupTextId);
throw new Exception(strMsg);
}
try
{
string strKey = clszx_ConceptVerBL.zx_ConceptVerDA.AddNewRecordBySQL2WithReturnKey(objzx_ConceptVerEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clszx_ConceptVerBL.ReFreshCache();

if (clszx_ConceptVerBL.relatedActions != null)
{
clszx_ConceptVerBL.relatedActions.UpdRelaTabDate(objzx_ConceptVerEN.ConceptVId, "SetUpdDate");
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
 /// <param name = "objzx_ConceptVerEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clszx_ConceptVerEN SetConceptVId(this clszx_ConceptVerEN objzx_ConceptVerEN, long lngConceptVId, string strComparisonOp="")
	{
objzx_ConceptVerEN.ConceptVId = lngConceptVId; //ConceptVId
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objzx_ConceptVerEN.dicFldComparisonOp.ContainsKey(conzx_ConceptVer.ConceptVId) == false)
{
objzx_ConceptVerEN.dicFldComparisonOp.Add(conzx_ConceptVer.ConceptVId, strComparisonOp);
}
else
{
objzx_ConceptVerEN.dicFldComparisonOp[conzx_ConceptVer.ConceptVId] = strComparisonOp;
}
}
return objzx_ConceptVerEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objzx_ConceptVerEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clszx_ConceptVerEN SetzxConceptId(this clszx_ConceptVerEN objzx_ConceptVerEN, string strzxConceptId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strzxConceptId, conzx_ConceptVer.zxConceptId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strzxConceptId, 8, conzx_ConceptVer.zxConceptId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strzxConceptId, 8, conzx_ConceptVer.zxConceptId);
}
objzx_ConceptVerEN.zxConceptId = strzxConceptId; //概念Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objzx_ConceptVerEN.dicFldComparisonOp.ContainsKey(conzx_ConceptVer.zxConceptId) == false)
{
objzx_ConceptVerEN.dicFldComparisonOp.Add(conzx_ConceptVer.zxConceptId, strComparisonOp);
}
else
{
objzx_ConceptVerEN.dicFldComparisonOp[conzx_ConceptVer.zxConceptId] = strComparisonOp;
}
}
return objzx_ConceptVerEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objzx_ConceptVerEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clszx_ConceptVerEN SetConceptName(this clszx_ConceptVerEN objzx_ConceptVerEN, string strConceptName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strConceptName, 500, conzx_ConceptVer.ConceptName);
}
objzx_ConceptVerEN.ConceptName = strConceptName; //概念名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objzx_ConceptVerEN.dicFldComparisonOp.ContainsKey(conzx_ConceptVer.ConceptName) == false)
{
objzx_ConceptVerEN.dicFldComparisonOp.Add(conzx_ConceptVer.ConceptName, strComparisonOp);
}
else
{
objzx_ConceptVerEN.dicFldComparisonOp[conzx_ConceptVer.ConceptName] = strComparisonOp;
}
}
return objzx_ConceptVerEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objzx_ConceptVerEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clszx_ConceptVerEN SetConceptContent(this clszx_ConceptVerEN objzx_ConceptVerEN, string strConceptContent, string strComparisonOp="")
	{
objzx_ConceptVerEN.ConceptContent = strConceptContent; //概念内容
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objzx_ConceptVerEN.dicFldComparisonOp.ContainsKey(conzx_ConceptVer.ConceptContent) == false)
{
objzx_ConceptVerEN.dicFldComparisonOp.Add(conzx_ConceptVer.ConceptContent, strComparisonOp);
}
else
{
objzx_ConceptVerEN.dicFldComparisonOp[conzx_ConceptVer.ConceptContent] = strComparisonOp;
}
}
return objzx_ConceptVerEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objzx_ConceptVerEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clszx_ConceptVerEN SetTextId(this clszx_ConceptVerEN objzx_ConceptVerEN, string strTextId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTextId, 8, conzx_ConceptVer.TextId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strTextId, 8, conzx_ConceptVer.TextId);
}
objzx_ConceptVerEN.TextId = strTextId; //课件Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objzx_ConceptVerEN.dicFldComparisonOp.ContainsKey(conzx_ConceptVer.TextId) == false)
{
objzx_ConceptVerEN.dicFldComparisonOp.Add(conzx_ConceptVer.TextId, strComparisonOp);
}
else
{
objzx_ConceptVerEN.dicFldComparisonOp[conzx_ConceptVer.TextId] = strComparisonOp;
}
}
return objzx_ConceptVerEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objzx_ConceptVerEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clszx_ConceptVerEN SetIsSubmit(this clszx_ConceptVerEN objzx_ConceptVerEN, bool bolIsSubmit, string strComparisonOp="")
	{
objzx_ConceptVerEN.IsSubmit = bolIsSubmit; //是否提交
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objzx_ConceptVerEN.dicFldComparisonOp.ContainsKey(conzx_ConceptVer.IsSubmit) == false)
{
objzx_ConceptVerEN.dicFldComparisonOp.Add(conzx_ConceptVer.IsSubmit, strComparisonOp);
}
else
{
objzx_ConceptVerEN.dicFldComparisonOp[conzx_ConceptVer.IsSubmit] = strComparisonOp;
}
}
return objzx_ConceptVerEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objzx_ConceptVerEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clszx_ConceptVerEN SetVoteCount(this clszx_ConceptVerEN objzx_ConceptVerEN, int? intVoteCount, string strComparisonOp="")
	{
objzx_ConceptVerEN.VoteCount = intVoteCount; //点赞计数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objzx_ConceptVerEN.dicFldComparisonOp.ContainsKey(conzx_ConceptVer.VoteCount) == false)
{
objzx_ConceptVerEN.dicFldComparisonOp.Add(conzx_ConceptVer.VoteCount, strComparisonOp);
}
else
{
objzx_ConceptVerEN.dicFldComparisonOp[conzx_ConceptVer.VoteCount] = strComparisonOp;
}
}
return objzx_ConceptVerEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objzx_ConceptVerEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clszx_ConceptVerEN SetAppraiseCount(this clszx_ConceptVerEN objzx_ConceptVerEN, int? intAppraiseCount, string strComparisonOp="")
	{
objzx_ConceptVerEN.AppraiseCount = intAppraiseCount; //评论数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objzx_ConceptVerEN.dicFldComparisonOp.ContainsKey(conzx_ConceptVer.AppraiseCount) == false)
{
objzx_ConceptVerEN.dicFldComparisonOp.Add(conzx_ConceptVer.AppraiseCount, strComparisonOp);
}
else
{
objzx_ConceptVerEN.dicFldComparisonOp[conzx_ConceptVer.AppraiseCount] = strComparisonOp;
}
}
return objzx_ConceptVerEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objzx_ConceptVerEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clszx_ConceptVerEN SetScore(this clszx_ConceptVerEN objzx_ConceptVerEN, float? fltScore, string strComparisonOp="")
	{
objzx_ConceptVerEN.Score = fltScore; //评分
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objzx_ConceptVerEN.dicFldComparisonOp.ContainsKey(conzx_ConceptVer.Score) == false)
{
objzx_ConceptVerEN.dicFldComparisonOp.Add(conzx_ConceptVer.Score, strComparisonOp);
}
else
{
objzx_ConceptVerEN.dicFldComparisonOp[conzx_ConceptVer.Score] = strComparisonOp;
}
}
return objzx_ConceptVerEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objzx_ConceptVerEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clszx_ConceptVerEN SetStuScore(this clszx_ConceptVerEN objzx_ConceptVerEN, float? fltStuScore, string strComparisonOp="")
	{
objzx_ConceptVerEN.StuScore = fltStuScore; //学生平均分
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objzx_ConceptVerEN.dicFldComparisonOp.ContainsKey(conzx_ConceptVer.StuScore) == false)
{
objzx_ConceptVerEN.dicFldComparisonOp.Add(conzx_ConceptVer.StuScore, strComparisonOp);
}
else
{
objzx_ConceptVerEN.dicFldComparisonOp[conzx_ConceptVer.StuScore] = strComparisonOp;
}
}
return objzx_ConceptVerEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objzx_ConceptVerEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clszx_ConceptVerEN SetTeaScore(this clszx_ConceptVerEN objzx_ConceptVerEN, float? fltTeaScore, string strComparisonOp="")
	{
objzx_ConceptVerEN.TeaScore = fltTeaScore; //教师评分
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objzx_ConceptVerEN.dicFldComparisonOp.ContainsKey(conzx_ConceptVer.TeaScore) == false)
{
objzx_ConceptVerEN.dicFldComparisonOp.Add(conzx_ConceptVer.TeaScore, strComparisonOp);
}
else
{
objzx_ConceptVerEN.dicFldComparisonOp[conzx_ConceptVer.TeaScore] = strComparisonOp;
}
}
return objzx_ConceptVerEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objzx_ConceptVerEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clszx_ConceptVerEN SetCreateDate(this clszx_ConceptVerEN objzx_ConceptVerEN, string strCreateDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCreateDate, 20, conzx_ConceptVer.CreateDate);
}
objzx_ConceptVerEN.CreateDate = strCreateDate; //建立日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objzx_ConceptVerEN.dicFldComparisonOp.ContainsKey(conzx_ConceptVer.CreateDate) == false)
{
objzx_ConceptVerEN.dicFldComparisonOp.Add(conzx_ConceptVer.CreateDate, strComparisonOp);
}
else
{
objzx_ConceptVerEN.dicFldComparisonOp[conzx_ConceptVer.CreateDate] = strComparisonOp;
}
}
return objzx_ConceptVerEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objzx_ConceptVerEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clszx_ConceptVerEN SetUpdDate(this clszx_ConceptVerEN objzx_ConceptVerEN, string strUpdDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdDate, 20, conzx_ConceptVer.UpdDate);
}
objzx_ConceptVerEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objzx_ConceptVerEN.dicFldComparisonOp.ContainsKey(conzx_ConceptVer.UpdDate) == false)
{
objzx_ConceptVerEN.dicFldComparisonOp.Add(conzx_ConceptVer.UpdDate, strComparisonOp);
}
else
{
objzx_ConceptVerEN.dicFldComparisonOp[conzx_ConceptVer.UpdDate] = strComparisonOp;
}
}
return objzx_ConceptVerEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objzx_ConceptVerEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clszx_ConceptVerEN SetUpdUser(this clszx_ConceptVerEN objzx_ConceptVerEN, string strUpdUser, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdUser, 20, conzx_ConceptVer.UpdUser);
}
objzx_ConceptVerEN.UpdUser = strUpdUser; //修改人
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objzx_ConceptVerEN.dicFldComparisonOp.ContainsKey(conzx_ConceptVer.UpdUser) == false)
{
objzx_ConceptVerEN.dicFldComparisonOp.Add(conzx_ConceptVer.UpdUser, strComparisonOp);
}
else
{
objzx_ConceptVerEN.dicFldComparisonOp[conzx_ConceptVer.UpdUser] = strComparisonOp;
}
}
return objzx_ConceptVerEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objzx_ConceptVerEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clszx_ConceptVerEN SetIdCurrEduCls(this clszx_ConceptVerEN objzx_ConceptVerEN, string strIdCurrEduCls, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdCurrEduCls, 8, conzx_ConceptVer.IdCurrEduCls);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdCurrEduCls, 8, conzx_ConceptVer.IdCurrEduCls);
}
objzx_ConceptVerEN.IdCurrEduCls = strIdCurrEduCls; //教学班流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objzx_ConceptVerEN.dicFldComparisonOp.ContainsKey(conzx_ConceptVer.IdCurrEduCls) == false)
{
objzx_ConceptVerEN.dicFldComparisonOp.Add(conzx_ConceptVer.IdCurrEduCls, strComparisonOp);
}
else
{
objzx_ConceptVerEN.dicFldComparisonOp[conzx_ConceptVer.IdCurrEduCls] = strComparisonOp;
}
}
return objzx_ConceptVerEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objzx_ConceptVerEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clszx_ConceptVerEN SetPdfContent(this clszx_ConceptVerEN objzx_ConceptVerEN, string strPdfContent, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPdfContent, 2000, conzx_ConceptVer.PdfContent);
}
objzx_ConceptVerEN.PdfContent = strPdfContent; //Pdf内容
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objzx_ConceptVerEN.dicFldComparisonOp.ContainsKey(conzx_ConceptVer.PdfContent) == false)
{
objzx_ConceptVerEN.dicFldComparisonOp.Add(conzx_ConceptVer.PdfContent, strComparisonOp);
}
else
{
objzx_ConceptVerEN.dicFldComparisonOp[conzx_ConceptVer.PdfContent] = strComparisonOp;
}
}
return objzx_ConceptVerEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objzx_ConceptVerEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clszx_ConceptVerEN SetPdfPageNum(this clszx_ConceptVerEN objzx_ConceptVerEN, int? intPdfPageNum, string strComparisonOp="")
	{
objzx_ConceptVerEN.PdfPageNum = intPdfPageNum; //Pdf页码
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objzx_ConceptVerEN.dicFldComparisonOp.ContainsKey(conzx_ConceptVer.PdfPageNum) == false)
{
objzx_ConceptVerEN.dicFldComparisonOp.Add(conzx_ConceptVer.PdfPageNum, strComparisonOp);
}
else
{
objzx_ConceptVerEN.dicFldComparisonOp[conzx_ConceptVer.PdfPageNum] = strComparisonOp;
}
}
return objzx_ConceptVerEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objzx_ConceptVerEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clszx_ConceptVerEN SetCitationCount(this clszx_ConceptVerEN objzx_ConceptVerEN, int? intCitationCount, string strComparisonOp="")
	{
objzx_ConceptVerEN.CitationCount = intCitationCount; //引用统计
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objzx_ConceptVerEN.dicFldComparisonOp.ContainsKey(conzx_ConceptVer.CitationCount) == false)
{
objzx_ConceptVerEN.dicFldComparisonOp.Add(conzx_ConceptVer.CitationCount, strComparisonOp);
}
else
{
objzx_ConceptVerEN.dicFldComparisonOp[conzx_ConceptVer.CitationCount] = strComparisonOp;
}
}
return objzx_ConceptVerEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objzx_ConceptVerEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clszx_ConceptVerEN SetVersionCount(this clszx_ConceptVerEN objzx_ConceptVerEN, int? intVersionCount, string strComparisonOp="")
	{
objzx_ConceptVerEN.VersionCount = intVersionCount; //版本统计
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objzx_ConceptVerEN.dicFldComparisonOp.ContainsKey(conzx_ConceptVer.VersionCount) == false)
{
objzx_ConceptVerEN.dicFldComparisonOp.Add(conzx_ConceptVer.VersionCount, strComparisonOp);
}
else
{
objzx_ConceptVerEN.dicFldComparisonOp[conzx_ConceptVer.VersionCount] = strComparisonOp;
}
}
return objzx_ConceptVerEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objzx_ConceptVerEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clszx_ConceptVerEN SetzxShareId(this clszx_ConceptVerEN objzx_ConceptVerEN, string strzxShareId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strzxShareId, conzx_ConceptVer.zxShareId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strzxShareId, 2, conzx_ConceptVer.zxShareId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strzxShareId, 2, conzx_ConceptVer.zxShareId);
}
objzx_ConceptVerEN.zxShareId = strzxShareId; //分享Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objzx_ConceptVerEN.dicFldComparisonOp.ContainsKey(conzx_ConceptVer.zxShareId) == false)
{
objzx_ConceptVerEN.dicFldComparisonOp.Add(conzx_ConceptVer.zxShareId, strComparisonOp);
}
else
{
objzx_ConceptVerEN.dicFldComparisonOp[conzx_ConceptVer.zxShareId] = strComparisonOp;
}
}
return objzx_ConceptVerEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objzx_ConceptVerEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clszx_ConceptVerEN SetMemo(this clszx_ConceptVerEN objzx_ConceptVerEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, conzx_ConceptVer.Memo);
}
objzx_ConceptVerEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objzx_ConceptVerEN.dicFldComparisonOp.ContainsKey(conzx_ConceptVer.Memo) == false)
{
objzx_ConceptVerEN.dicFldComparisonOp.Add(conzx_ConceptVer.Memo, strComparisonOp);
}
else
{
objzx_ConceptVerEN.dicFldComparisonOp[conzx_ConceptVer.Memo] = strComparisonOp;
}
}
return objzx_ConceptVerEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objzx_ConceptVerEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clszx_ConceptVerEN SetPdfDivLet(this clszx_ConceptVerEN objzx_ConceptVerEN, string strPdfDivLet, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPdfDivLet, 50, conzx_ConceptVer.PdfDivLet);
}
objzx_ConceptVerEN.PdfDivLet = strPdfDivLet; //PdfDivLet
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objzx_ConceptVerEN.dicFldComparisonOp.ContainsKey(conzx_ConceptVer.PdfDivLet) == false)
{
objzx_ConceptVerEN.dicFldComparisonOp.Add(conzx_ConceptVer.PdfDivLet, strComparisonOp);
}
else
{
objzx_ConceptVerEN.dicFldComparisonOp[conzx_ConceptVer.PdfDivLet] = strComparisonOp;
}
}
return objzx_ConceptVerEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objzx_ConceptVerEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clszx_ConceptVerEN SetPdfDivTop(this clszx_ConceptVerEN objzx_ConceptVerEN, string strPdfDivTop, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPdfDivTop, 50, conzx_ConceptVer.PdfDivTop);
}
objzx_ConceptVerEN.PdfDivTop = strPdfDivTop; //PdfDivTop
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objzx_ConceptVerEN.dicFldComparisonOp.ContainsKey(conzx_ConceptVer.PdfDivTop) == false)
{
objzx_ConceptVerEN.dicFldComparisonOp.Add(conzx_ConceptVer.PdfDivTop, strComparisonOp);
}
else
{
objzx_ConceptVerEN.dicFldComparisonOp[conzx_ConceptVer.PdfDivTop] = strComparisonOp;
}
}
return objzx_ConceptVerEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objzx_ConceptVerEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clszx_ConceptVerEN SetPdfPageNumIn(this clszx_ConceptVerEN objzx_ConceptVerEN, string strPdfPageNumIn, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPdfPageNumIn, 50, conzx_ConceptVer.PdfPageNumIn);
}
objzx_ConceptVerEN.PdfPageNumIn = strPdfPageNumIn; //PdfPageNumIn
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objzx_ConceptVerEN.dicFldComparisonOp.ContainsKey(conzx_ConceptVer.PdfPageNumIn) == false)
{
objzx_ConceptVerEN.dicFldComparisonOp.Add(conzx_ConceptVer.PdfPageNumIn, strComparisonOp);
}
else
{
objzx_ConceptVerEN.dicFldComparisonOp[conzx_ConceptVer.PdfPageNumIn] = strComparisonOp;
}
}
return objzx_ConceptVerEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objzx_ConceptVerEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clszx_ConceptVerEN SetPdfPageTop(this clszx_ConceptVerEN objzx_ConceptVerEN, int? intPdfPageTop, string strComparisonOp="")
	{
objzx_ConceptVerEN.PdfPageTop = intPdfPageTop; //pdf页面顶部位置
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objzx_ConceptVerEN.dicFldComparisonOp.ContainsKey(conzx_ConceptVer.PdfPageTop) == false)
{
objzx_ConceptVerEN.dicFldComparisonOp.Add(conzx_ConceptVer.PdfPageTop, strComparisonOp);
}
else
{
objzx_ConceptVerEN.dicFldComparisonOp[conzx_ConceptVer.PdfPageTop] = strComparisonOp;
}
}
return objzx_ConceptVerEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objzx_ConceptVerEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clszx_ConceptVerEN SetPdfZoom(this clszx_ConceptVerEN objzx_ConceptVerEN, string strPdfZoom, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPdfZoom, 50, conzx_ConceptVer.PdfZoom);
}
objzx_ConceptVerEN.PdfZoom = strPdfZoom; //PdfZoom
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objzx_ConceptVerEN.dicFldComparisonOp.ContainsKey(conzx_ConceptVer.PdfZoom) == false)
{
objzx_ConceptVerEN.dicFldComparisonOp.Add(conzx_ConceptVer.PdfZoom, strComparisonOp);
}
else
{
objzx_ConceptVerEN.dicFldComparisonOp[conzx_ConceptVer.PdfZoom] = strComparisonOp;
}
}
return objzx_ConceptVerEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objzx_ConceptVerEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clszx_ConceptVerEN SetGroupTextId(this clszx_ConceptVerEN objzx_ConceptVerEN, string strGroupTextId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strGroupTextId, 8, conzx_ConceptVer.GroupTextId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strGroupTextId, 8, conzx_ConceptVer.GroupTextId);
}
objzx_ConceptVerEN.GroupTextId = strGroupTextId; //小组Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objzx_ConceptVerEN.dicFldComparisonOp.ContainsKey(conzx_ConceptVer.GroupTextId) == false)
{
objzx_ConceptVerEN.dicFldComparisonOp.Add(conzx_ConceptVer.GroupTextId, strComparisonOp);
}
else
{
objzx_ConceptVerEN.dicFldComparisonOp[conzx_ConceptVer.GroupTextId] = strComparisonOp;
}
}
return objzx_ConceptVerEN;
	}

 /// <summary>
 /// 修改记录存盘到数据表中
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_UpdateRecordEx)
 /// </summary>
 /// <param name = "objzx_ConceptVerEN">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool UpdateRecordEx(this clszx_ConceptVerEN objzx_ConceptVerEN)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
try
{
//1、检查传进去的对象属性是否合法
objzx_ConceptVerEN.CheckPropertyNew();
clszx_ConceptVerEN objzx_ConceptVerCond = new clszx_ConceptVerEN();
string strCondition = objzx_ConceptVerCond
.SetConceptVId(objzx_ConceptVerEN.ConceptVId, "<>")
.SetzxConceptId(objzx_ConceptVerEN.zxConceptId, "=")
.SetGroupTextId(objzx_ConceptVerEN.GroupTextId, "=")
.GetCombineCondition();
objzx_ConceptVerEN._IsCheckProperty = true;
bool bolIsExist = clszx_ConceptVerBL.IsExistRecord(strCondition);
if (bolIsExist)
{
strMsg = "(zxConceptId_GroupTextId)不能重复!";
throw new Exception(strMsg);
}
//4、把数据实体层的数据存贮到数据库中
objzx_ConceptVerEN.Update();
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
 /// <param name = "objzx_ConceptVer">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool EditRecordEx(this clszx_ConceptVerEN objzx_ConceptVer)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
clszx_ConceptVerEN objzx_ConceptVerCond = new clszx_ConceptVerEN();
string strCondition = objzx_ConceptVerCond
.SetzxConceptId(objzx_ConceptVer.zxConceptId, "=")
.SetGroupTextId(objzx_ConceptVer.GroupTextId, "=")
.GetCombineCondition();
objzx_ConceptVer._IsCheckProperty = true;
bool bolIsExist = clszx_ConceptVerBL.IsExistRecord(strCondition);
if (bolIsExist)
{
objzx_ConceptVer.ConceptVId = clszx_ConceptVerBL.GetFirstID_S(strCondition);
objzx_ConceptVer.UpdateWithCondition(strCondition);
}
else
{
objzx_ConceptVer.AddNewRecord();
}
return true; 
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_Update)
 /// </summary>
 /// <param name = "objzx_ConceptVerEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clszx_ConceptVerEN objzx_ConceptVerEN)
{
 if (objzx_ConceptVerEN.ConceptVId == 0)
 {
string strMsg = string.Format("(errid:Busi000095)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clszx_ConceptVerBL.zx_ConceptVerDA.UpdateBySql2(objzx_ConceptVerEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clszx_ConceptVerBL.ReFreshCache();

if (clszx_ConceptVerBL.relatedActions != null)
{
clszx_ConceptVerBL.relatedActions.UpdRelaTabDate(objzx_ConceptVerEN.ConceptVId, "SetUpdDate");
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
 /// <param name = "objzx_ConceptVerEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clszx_ConceptVerEN objzx_ConceptVerEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (objzx_ConceptVerEN.ConceptVId == 0)
 {
string strMsg = string.Format("(errid:Busi000087)修改记录时关键字不能为空!(带事务处理)(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clszx_ConceptVerBL.zx_ConceptVerDA.UpdateBySql2(objzx_ConceptVerEN, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clszx_ConceptVerBL.ReFreshCache();

if (clszx_ConceptVerBL.relatedActions != null)
{
clszx_ConceptVerBL.relatedActions.UpdRelaTabDate(objzx_ConceptVerEN.ConceptVId, "SetUpdDate");
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
 /// <param name = "objzx_ConceptVerEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clszx_ConceptVerEN objzx_ConceptVerEN, string strWhereCond)
{
try
{
bool bolResult = clszx_ConceptVerBL.zx_ConceptVerDA.UpdateBySqlWithCondition(objzx_ConceptVerEN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clszx_ConceptVerBL.ReFreshCache();

if (clszx_ConceptVerBL.relatedActions != null)
{
clszx_ConceptVerBL.relatedActions.UpdRelaTabDate(objzx_ConceptVerEN.ConceptVId, "SetUpdDate");
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
 /// <param name = "objzx_ConceptVerEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clszx_ConceptVerEN objzx_ConceptVerEN, string strWhereCond, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
bool bolResult = clszx_ConceptVerBL.zx_ConceptVerDA.UpdateBySqlWithConditionTransaction(objzx_ConceptVerEN, strWhereCond, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clszx_ConceptVerBL.ReFreshCache();

if (clszx_ConceptVerBL.relatedActions != null)
{
clszx_ConceptVerBL.relatedActions.UpdRelaTabDate(objzx_ConceptVerEN.ConceptVId, "SetUpdDate");
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
 /// <param name = "lngConceptVId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int Delete(this clszx_ConceptVerEN objzx_ConceptVerEN)
{
try
{
int intRecNum = clszx_ConceptVerBL.zx_ConceptVerDA.DelRecord(objzx_ConceptVerEN.ConceptVId);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clszx_ConceptVerBL.ReFreshCache();

if (clszx_ConceptVerBL.relatedActions != null)
{
clszx_ConceptVerBL.relatedActions.UpdRelaTabDate(objzx_ConceptVerEN.ConceptVId, "SetUpdDate");
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
 /// <param name = "objzx_ConceptVerENS">源对象</param>
 /// <param name = "objzx_ConceptVerENT">目标对象</param>
 public static void CopyTo(this clszx_ConceptVerEN objzx_ConceptVerENS, clszx_ConceptVerEN objzx_ConceptVerENT)
{
try
{
objzx_ConceptVerENT.ConceptVId = objzx_ConceptVerENS.ConceptVId; //ConceptVId
objzx_ConceptVerENT.zxConceptId = objzx_ConceptVerENS.zxConceptId; //概念Id
objzx_ConceptVerENT.ConceptName = objzx_ConceptVerENS.ConceptName; //概念名称
objzx_ConceptVerENT.ConceptContent = objzx_ConceptVerENS.ConceptContent; //概念内容
objzx_ConceptVerENT.TextId = objzx_ConceptVerENS.TextId; //课件Id
objzx_ConceptVerENT.IsSubmit = objzx_ConceptVerENS.IsSubmit; //是否提交
objzx_ConceptVerENT.VoteCount = objzx_ConceptVerENS.VoteCount; //点赞计数
objzx_ConceptVerENT.AppraiseCount = objzx_ConceptVerENS.AppraiseCount; //评论数
objzx_ConceptVerENT.Score = objzx_ConceptVerENS.Score; //评分
objzx_ConceptVerENT.StuScore = objzx_ConceptVerENS.StuScore; //学生平均分
objzx_ConceptVerENT.TeaScore = objzx_ConceptVerENS.TeaScore; //教师评分
objzx_ConceptVerENT.CreateDate = objzx_ConceptVerENS.CreateDate; //建立日期
objzx_ConceptVerENT.UpdDate = objzx_ConceptVerENS.UpdDate; //修改日期
objzx_ConceptVerENT.UpdUser = objzx_ConceptVerENS.UpdUser; //修改人
objzx_ConceptVerENT.IdCurrEduCls = objzx_ConceptVerENS.IdCurrEduCls; //教学班流水号
objzx_ConceptVerENT.PdfContent = objzx_ConceptVerENS.PdfContent; //Pdf内容
objzx_ConceptVerENT.PdfPageNum = objzx_ConceptVerENS.PdfPageNum; //Pdf页码
objzx_ConceptVerENT.CitationCount = objzx_ConceptVerENS.CitationCount; //引用统计
objzx_ConceptVerENT.VersionCount = objzx_ConceptVerENS.VersionCount; //版本统计
objzx_ConceptVerENT.zxShareId = objzx_ConceptVerENS.zxShareId; //分享Id
objzx_ConceptVerENT.Memo = objzx_ConceptVerENS.Memo; //备注
objzx_ConceptVerENT.PdfDivLet = objzx_ConceptVerENS.PdfDivLet; //PdfDivLet
objzx_ConceptVerENT.PdfDivTop = objzx_ConceptVerENS.PdfDivTop; //PdfDivTop
objzx_ConceptVerENT.PdfPageNumIn = objzx_ConceptVerENS.PdfPageNumIn; //PdfPageNumIn
objzx_ConceptVerENT.PdfPageTop = objzx_ConceptVerENS.PdfPageTop; //pdf页面顶部位置
objzx_ConceptVerENT.PdfZoom = objzx_ConceptVerENS.PdfZoom; //PdfZoom
objzx_ConceptVerENT.GroupTextId = objzx_ConceptVerENS.GroupTextId; //小组Id
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
 /// <param name = "objzx_ConceptVerENS">源对象</param>
 /// <returns>目标对象=>clszx_ConceptVerEN:objzx_ConceptVerENT</returns>
 public static clszx_ConceptVerEN CopyTo(this clszx_ConceptVerEN objzx_ConceptVerENS)
{
try
{
 clszx_ConceptVerEN objzx_ConceptVerENT = new clszx_ConceptVerEN()
{
ConceptVId = objzx_ConceptVerENS.ConceptVId, //ConceptVId
zxConceptId = objzx_ConceptVerENS.zxConceptId, //概念Id
ConceptName = objzx_ConceptVerENS.ConceptName, //概念名称
ConceptContent = objzx_ConceptVerENS.ConceptContent, //概念内容
TextId = objzx_ConceptVerENS.TextId, //课件Id
IsSubmit = objzx_ConceptVerENS.IsSubmit, //是否提交
VoteCount = objzx_ConceptVerENS.VoteCount, //点赞计数
AppraiseCount = objzx_ConceptVerENS.AppraiseCount, //评论数
Score = objzx_ConceptVerENS.Score, //评分
StuScore = objzx_ConceptVerENS.StuScore, //学生平均分
TeaScore = objzx_ConceptVerENS.TeaScore, //教师评分
CreateDate = objzx_ConceptVerENS.CreateDate, //建立日期
UpdDate = objzx_ConceptVerENS.UpdDate, //修改日期
UpdUser = objzx_ConceptVerENS.UpdUser, //修改人
IdCurrEduCls = objzx_ConceptVerENS.IdCurrEduCls, //教学班流水号
PdfContent = objzx_ConceptVerENS.PdfContent, //Pdf内容
PdfPageNum = objzx_ConceptVerENS.PdfPageNum, //Pdf页码
CitationCount = objzx_ConceptVerENS.CitationCount, //引用统计
VersionCount = objzx_ConceptVerENS.VersionCount, //版本统计
zxShareId = objzx_ConceptVerENS.zxShareId, //分享Id
Memo = objzx_ConceptVerENS.Memo, //备注
PdfDivLet = objzx_ConceptVerENS.PdfDivLet, //PdfDivLet
PdfDivTop = objzx_ConceptVerENS.PdfDivTop, //PdfDivTop
PdfPageNumIn = objzx_ConceptVerENS.PdfPageNumIn, //PdfPageNumIn
PdfPageTop = objzx_ConceptVerENS.PdfPageTop, //pdf页面顶部位置
PdfZoom = objzx_ConceptVerENS.PdfZoom, //PdfZoom
GroupTextId = objzx_ConceptVerENS.GroupTextId, //小组Id
};
 return objzx_ConceptVerENT;
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
public static void CheckPropertyNew(this clszx_ConceptVerEN objzx_ConceptVerEN)
{
 clszx_ConceptVerBL.zx_ConceptVerDA.CheckPropertyNew(objzx_ConceptVerEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(this clszx_ConceptVerEN objzx_ConceptVerEN)
{
 clszx_ConceptVerBL.zx_ConceptVerDA.CheckProperty4Condition(objzx_ConceptVerEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clszx_ConceptVerEN objzx_ConceptVerCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objzx_ConceptVerCond.IsUpdated(conzx_ConceptVer.ConceptVId) == true)
{
string strComparisonOpConceptVId = objzx_ConceptVerCond.dicFldComparisonOp[conzx_ConceptVer.ConceptVId];
strWhereCond += string.Format(" And {0} {2} {1}", conzx_ConceptVer.ConceptVId, objzx_ConceptVerCond.ConceptVId, strComparisonOpConceptVId);
}
if (objzx_ConceptVerCond.IsUpdated(conzx_ConceptVer.zxConceptId) == true)
{
string strComparisonOpzxConceptId = objzx_ConceptVerCond.dicFldComparisonOp[conzx_ConceptVer.zxConceptId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conzx_ConceptVer.zxConceptId, objzx_ConceptVerCond.zxConceptId, strComparisonOpzxConceptId);
}
if (objzx_ConceptVerCond.IsUpdated(conzx_ConceptVer.ConceptName) == true)
{
string strComparisonOpConceptName = objzx_ConceptVerCond.dicFldComparisonOp[conzx_ConceptVer.ConceptName];
strWhereCond += string.Format(" And {0} {2} '{1}'", conzx_ConceptVer.ConceptName, objzx_ConceptVerCond.ConceptName, strComparisonOpConceptName);
}
//数据类型string(text)在函数:[AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj]中没有处理!
if (objzx_ConceptVerCond.IsUpdated(conzx_ConceptVer.TextId) == true)
{
string strComparisonOpTextId = objzx_ConceptVerCond.dicFldComparisonOp[conzx_ConceptVer.TextId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conzx_ConceptVer.TextId, objzx_ConceptVerCond.TextId, strComparisonOpTextId);
}
if (objzx_ConceptVerCond.IsUpdated(conzx_ConceptVer.IsSubmit) == true)
{
if (objzx_ConceptVerCond.IsSubmit == true)
{
strWhereCond += string.Format(" And {0} = '1'", conzx_ConceptVer.IsSubmit);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conzx_ConceptVer.IsSubmit);
}
}
if (objzx_ConceptVerCond.IsUpdated(conzx_ConceptVer.VoteCount) == true)
{
string strComparisonOpVoteCount = objzx_ConceptVerCond.dicFldComparisonOp[conzx_ConceptVer.VoteCount];
strWhereCond += string.Format(" And {0} {2} {1}", conzx_ConceptVer.VoteCount, objzx_ConceptVerCond.VoteCount, strComparisonOpVoteCount);
}
if (objzx_ConceptVerCond.IsUpdated(conzx_ConceptVer.AppraiseCount) == true)
{
string strComparisonOpAppraiseCount = objzx_ConceptVerCond.dicFldComparisonOp[conzx_ConceptVer.AppraiseCount];
strWhereCond += string.Format(" And {0} {2} {1}", conzx_ConceptVer.AppraiseCount, objzx_ConceptVerCond.AppraiseCount, strComparisonOpAppraiseCount);
}
if (objzx_ConceptVerCond.IsUpdated(conzx_ConceptVer.Score) == true)
{
string strComparisonOpScore = objzx_ConceptVerCond.dicFldComparisonOp[conzx_ConceptVer.Score];
strWhereCond += string.Format(" And {0} {2} {1}", conzx_ConceptVer.Score, objzx_ConceptVerCond.Score, strComparisonOpScore);
}
if (objzx_ConceptVerCond.IsUpdated(conzx_ConceptVer.StuScore) == true)
{
string strComparisonOpStuScore = objzx_ConceptVerCond.dicFldComparisonOp[conzx_ConceptVer.StuScore];
strWhereCond += string.Format(" And {0} {2} {1}", conzx_ConceptVer.StuScore, objzx_ConceptVerCond.StuScore, strComparisonOpStuScore);
}
if (objzx_ConceptVerCond.IsUpdated(conzx_ConceptVer.TeaScore) == true)
{
string strComparisonOpTeaScore = objzx_ConceptVerCond.dicFldComparisonOp[conzx_ConceptVer.TeaScore];
strWhereCond += string.Format(" And {0} {2} {1}", conzx_ConceptVer.TeaScore, objzx_ConceptVerCond.TeaScore, strComparisonOpTeaScore);
}
if (objzx_ConceptVerCond.IsUpdated(conzx_ConceptVer.CreateDate) == true)
{
string strComparisonOpCreateDate = objzx_ConceptVerCond.dicFldComparisonOp[conzx_ConceptVer.CreateDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conzx_ConceptVer.CreateDate, objzx_ConceptVerCond.CreateDate, strComparisonOpCreateDate);
}
if (objzx_ConceptVerCond.IsUpdated(conzx_ConceptVer.UpdDate) == true)
{
string strComparisonOpUpdDate = objzx_ConceptVerCond.dicFldComparisonOp[conzx_ConceptVer.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conzx_ConceptVer.UpdDate, objzx_ConceptVerCond.UpdDate, strComparisonOpUpdDate);
}
if (objzx_ConceptVerCond.IsUpdated(conzx_ConceptVer.UpdUser) == true)
{
string strComparisonOpUpdUser = objzx_ConceptVerCond.dicFldComparisonOp[conzx_ConceptVer.UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", conzx_ConceptVer.UpdUser, objzx_ConceptVerCond.UpdUser, strComparisonOpUpdUser);
}
if (objzx_ConceptVerCond.IsUpdated(conzx_ConceptVer.IdCurrEduCls) == true)
{
string strComparisonOpIdCurrEduCls = objzx_ConceptVerCond.dicFldComparisonOp[conzx_ConceptVer.IdCurrEduCls];
strWhereCond += string.Format(" And {0} {2} '{1}'", conzx_ConceptVer.IdCurrEduCls, objzx_ConceptVerCond.IdCurrEduCls, strComparisonOpIdCurrEduCls);
}
if (objzx_ConceptVerCond.IsUpdated(conzx_ConceptVer.PdfContent) == true)
{
string strComparisonOpPdfContent = objzx_ConceptVerCond.dicFldComparisonOp[conzx_ConceptVer.PdfContent];
strWhereCond += string.Format(" And {0} {2} '{1}'", conzx_ConceptVer.PdfContent, objzx_ConceptVerCond.PdfContent, strComparisonOpPdfContent);
}
if (objzx_ConceptVerCond.IsUpdated(conzx_ConceptVer.PdfPageNum) == true)
{
string strComparisonOpPdfPageNum = objzx_ConceptVerCond.dicFldComparisonOp[conzx_ConceptVer.PdfPageNum];
strWhereCond += string.Format(" And {0} {2} {1}", conzx_ConceptVer.PdfPageNum, objzx_ConceptVerCond.PdfPageNum, strComparisonOpPdfPageNum);
}
if (objzx_ConceptVerCond.IsUpdated(conzx_ConceptVer.CitationCount) == true)
{
string strComparisonOpCitationCount = objzx_ConceptVerCond.dicFldComparisonOp[conzx_ConceptVer.CitationCount];
strWhereCond += string.Format(" And {0} {2} {1}", conzx_ConceptVer.CitationCount, objzx_ConceptVerCond.CitationCount, strComparisonOpCitationCount);
}
if (objzx_ConceptVerCond.IsUpdated(conzx_ConceptVer.VersionCount) == true)
{
string strComparisonOpVersionCount = objzx_ConceptVerCond.dicFldComparisonOp[conzx_ConceptVer.VersionCount];
strWhereCond += string.Format(" And {0} {2} {1}", conzx_ConceptVer.VersionCount, objzx_ConceptVerCond.VersionCount, strComparisonOpVersionCount);
}
if (objzx_ConceptVerCond.IsUpdated(conzx_ConceptVer.zxShareId) == true)
{
string strComparisonOpzxShareId = objzx_ConceptVerCond.dicFldComparisonOp[conzx_ConceptVer.zxShareId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conzx_ConceptVer.zxShareId, objzx_ConceptVerCond.zxShareId, strComparisonOpzxShareId);
}
if (objzx_ConceptVerCond.IsUpdated(conzx_ConceptVer.Memo) == true)
{
string strComparisonOpMemo = objzx_ConceptVerCond.dicFldComparisonOp[conzx_ConceptVer.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", conzx_ConceptVer.Memo, objzx_ConceptVerCond.Memo, strComparisonOpMemo);
}
if (objzx_ConceptVerCond.IsUpdated(conzx_ConceptVer.PdfDivLet) == true)
{
string strComparisonOpPdfDivLet = objzx_ConceptVerCond.dicFldComparisonOp[conzx_ConceptVer.PdfDivLet];
strWhereCond += string.Format(" And {0} {2} '{1}'", conzx_ConceptVer.PdfDivLet, objzx_ConceptVerCond.PdfDivLet, strComparisonOpPdfDivLet);
}
if (objzx_ConceptVerCond.IsUpdated(conzx_ConceptVer.PdfDivTop) == true)
{
string strComparisonOpPdfDivTop = objzx_ConceptVerCond.dicFldComparisonOp[conzx_ConceptVer.PdfDivTop];
strWhereCond += string.Format(" And {0} {2} '{1}'", conzx_ConceptVer.PdfDivTop, objzx_ConceptVerCond.PdfDivTop, strComparisonOpPdfDivTop);
}
if (objzx_ConceptVerCond.IsUpdated(conzx_ConceptVer.PdfPageNumIn) == true)
{
string strComparisonOpPdfPageNumIn = objzx_ConceptVerCond.dicFldComparisonOp[conzx_ConceptVer.PdfPageNumIn];
strWhereCond += string.Format(" And {0} {2} '{1}'", conzx_ConceptVer.PdfPageNumIn, objzx_ConceptVerCond.PdfPageNumIn, strComparisonOpPdfPageNumIn);
}
if (objzx_ConceptVerCond.IsUpdated(conzx_ConceptVer.PdfPageTop) == true)
{
string strComparisonOpPdfPageTop = objzx_ConceptVerCond.dicFldComparisonOp[conzx_ConceptVer.PdfPageTop];
strWhereCond += string.Format(" And {0} {2} {1}", conzx_ConceptVer.PdfPageTop, objzx_ConceptVerCond.PdfPageTop, strComparisonOpPdfPageTop);
}
if (objzx_ConceptVerCond.IsUpdated(conzx_ConceptVer.PdfZoom) == true)
{
string strComparisonOpPdfZoom = objzx_ConceptVerCond.dicFldComparisonOp[conzx_ConceptVer.PdfZoom];
strWhereCond += string.Format(" And {0} {2} '{1}'", conzx_ConceptVer.PdfZoom, objzx_ConceptVerCond.PdfZoom, strComparisonOpPdfZoom);
}
if (objzx_ConceptVerCond.IsUpdated(conzx_ConceptVer.GroupTextId) == true)
{
string strComparisonOpGroupTextId = objzx_ConceptVerCond.dicFldComparisonOp[conzx_ConceptVer.GroupTextId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conzx_ConceptVer.GroupTextId, objzx_ConceptVerCond.GroupTextId, strComparisonOpGroupTextId);
}
 return strWhereCond;
}

 /// <summary>
 /// 检查唯一性(Uniqueness)--zx_ConceptVer(概念版本), 如果不唯一,即存在相同的记录,就返回False
 /// 唯一性条件:zxConceptId_GroupTextId
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckConstraint)
 /// </summary>
 /// <param name = "objzx_ConceptVerEN">要求唯一的对象</param>
 /// <returns></returns>
public static bool CheckUniqueness(this clszx_ConceptVerEN objzx_ConceptVerEN)
{
//检测记录是否存在
bool bolIsUniqueness;
StringBuilder sbCondition = new StringBuilder();
if (objzx_ConceptVerEN == null) return true;
if (objzx_ConceptVerEN.ConceptVId == 0)
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and zxConceptId = '{0}'", objzx_ConceptVerEN.zxConceptId);
 if (objzx_ConceptVerEN.GroupTextId == null)
{
 sbCondition.AppendFormat(" and GroupTextId is null", objzx_ConceptVerEN.GroupTextId);
}
else
{
 sbCondition.AppendFormat(" and GroupTextId = '{0}'", objzx_ConceptVerEN.GroupTextId);
}
if (clszx_ConceptVerBL.IsExistRecord(sbCondition.ToString())  ==  true)
{
 bolIsUniqueness = false;
}
else
{
 bolIsUniqueness = true;
}
}
 else {
sbCondition.AppendFormat("ConceptVId !=  {0}", objzx_ConceptVerEN.ConceptVId);
 sbCondition.AppendFormat(" and zxConceptId = '{0}'", objzx_ConceptVerEN.zxConceptId);
 sbCondition.AppendFormat(" and GroupTextId = '{0}'", objzx_ConceptVerEN.GroupTextId);
if (clszx_ConceptVerBL.IsExistRecord(sbCondition.ToString())  ==  true)
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
 /// 获取唯一性条件串--zx_ConceptVer(概念版本), 即由对象中唯一性条件字段关键字与值组成的条件串
 /// 唯一性条件:zxConceptId_GroupTextId
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetConditionString4Constraint)
 /// </summary>
 /// <param name = "objzx_ConceptVerEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(this clszx_ConceptVerEN objzx_ConceptVerEN)
{
//检测记录是否存在
StringBuilder sbCondition = new StringBuilder();
if (objzx_ConceptVerEN == null) return "";
if (objzx_ConceptVerEN.ConceptVId == 0)
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and zxConceptId = '{0}'", objzx_ConceptVerEN.zxConceptId);
 if (objzx_ConceptVerEN.GroupTextId == null)
{
 sbCondition.AppendFormat(" and GroupTextId is null", objzx_ConceptVerEN.GroupTextId);
}
else
{
 sbCondition.AppendFormat(" and GroupTextId = '{0}'", objzx_ConceptVerEN.GroupTextId);
}
return sbCondition.ToString();
}
 else {
sbCondition.AppendFormat("ConceptVId !=  {0}", objzx_ConceptVerEN.ConceptVId);
 sbCondition.AppendFormat(" and zxConceptId = '{0}'", objzx_ConceptVerEN.zxConceptId);
 sbCondition.AppendFormat(" and GroupTextId = '{0}'", objzx_ConceptVerEN.GroupTextId);
 return sbCondition.ToString();
}
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_zx_ConceptVer
{
public virtual bool UpdRelaTabDate(long lngConceptVId, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// 概念版本(zx_ConceptVer)
 /// 数据源类型:表
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clszx_ConceptVerBL
{
public static RelatedActions_zx_ConceptVer relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clszx_ConceptVerDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clszx_ConceptVerDA zx_ConceptVerDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clszx_ConceptVerDA();
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
 public clszx_ConceptVerBL()
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
if (string.IsNullOrEmpty(clszx_ConceptVerEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clszx_ConceptVerEN._ConnectString);
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
public static DataTable GetDataTable_zx_ConceptVer(string strWhereCond)
{
DataTable objDT;
try
{
objDT = zx_ConceptVerDA.GetDataTable_zx_ConceptVer(strWhereCond);
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
objDT = zx_ConceptVerDA.GetDataTable(strWhereCond);
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
objDT = zx_ConceptVerDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = zx_ConceptVerDA.GetDataTable(strWhereCond, strTabName);
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
objDT = zx_ConceptVerDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = zx_ConceptVerDA.GetDataTable_Top(objTopPara);
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
objDT = zx_ConceptVerDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = zx_ConceptVerDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = zx_ConceptVerDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
 /// <param name = "arrConceptVIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static List<clszx_ConceptVerEN> GetObjLstByConceptVIdLst(List<long> arrConceptVIdLst)
{
List<clszx_ConceptVerEN> arrObjLst = new List<clszx_ConceptVerEN>(); 
System.Data.DataTable objDT; 
 string strSqlConditionStr = clsArray.GetSqlInStrByArray(arrConceptVIdLst);
 string strWhereCond = string.Format("ConceptVId in ({0})", strSqlConditionStr);
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clszx_ConceptVerEN objzx_ConceptVerEN = new clszx_ConceptVerEN();
try
{
objzx_ConceptVerEN.ConceptVId = Int32.Parse(objRow[conzx_ConceptVer.ConceptVId].ToString().Trim()); //ConceptVId
objzx_ConceptVerEN.zxConceptId = objRow[conzx_ConceptVer.zxConceptId].ToString().Trim(); //概念Id
objzx_ConceptVerEN.ConceptName = objRow[conzx_ConceptVer.ConceptName] == DBNull.Value ? null : objRow[conzx_ConceptVer.ConceptName].ToString().Trim(); //概念名称
objzx_ConceptVerEN.ConceptContent = objRow[conzx_ConceptVer.ConceptContent] == DBNull.Value ? null : objRow[conzx_ConceptVer.ConceptContent].ToString().Trim(); //概念内容
objzx_ConceptVerEN.TextId = objRow[conzx_ConceptVer.TextId] == DBNull.Value ? null : objRow[conzx_ConceptVer.TextId].ToString().Trim(); //课件Id
objzx_ConceptVerEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[conzx_ConceptVer.IsSubmit].ToString().Trim()); //是否提交
objzx_ConceptVerEN.VoteCount = objRow[conzx_ConceptVer.VoteCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_ConceptVer.VoteCount].ToString().Trim()); //点赞计数
objzx_ConceptVerEN.AppraiseCount = objRow[conzx_ConceptVer.AppraiseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_ConceptVer.AppraiseCount].ToString().Trim()); //评论数
objzx_ConceptVerEN.Score = objRow[conzx_ConceptVer.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conzx_ConceptVer.Score].ToString().Trim()); //评分
objzx_ConceptVerEN.StuScore = objRow[conzx_ConceptVer.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conzx_ConceptVer.StuScore].ToString().Trim()); //学生平均分
objzx_ConceptVerEN.TeaScore = objRow[conzx_ConceptVer.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conzx_ConceptVer.TeaScore].ToString().Trim()); //教师评分
objzx_ConceptVerEN.CreateDate = objRow[conzx_ConceptVer.CreateDate] == DBNull.Value ? null : objRow[conzx_ConceptVer.CreateDate].ToString().Trim(); //建立日期
objzx_ConceptVerEN.UpdDate = objRow[conzx_ConceptVer.UpdDate] == DBNull.Value ? null : objRow[conzx_ConceptVer.UpdDate].ToString().Trim(); //修改日期
objzx_ConceptVerEN.UpdUser = objRow[conzx_ConceptVer.UpdUser] == DBNull.Value ? null : objRow[conzx_ConceptVer.UpdUser].ToString().Trim(); //修改人
objzx_ConceptVerEN.IdCurrEduCls = objRow[conzx_ConceptVer.IdCurrEduCls] == DBNull.Value ? null : objRow[conzx_ConceptVer.IdCurrEduCls].ToString().Trim(); //教学班流水号
objzx_ConceptVerEN.PdfContent = objRow[conzx_ConceptVer.PdfContent] == DBNull.Value ? null : objRow[conzx_ConceptVer.PdfContent].ToString().Trim(); //Pdf内容
objzx_ConceptVerEN.PdfPageNum = objRow[conzx_ConceptVer.PdfPageNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_ConceptVer.PdfPageNum].ToString().Trim()); //Pdf页码
objzx_ConceptVerEN.CitationCount = objRow[conzx_ConceptVer.CitationCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_ConceptVer.CitationCount].ToString().Trim()); //引用统计
objzx_ConceptVerEN.VersionCount = objRow[conzx_ConceptVer.VersionCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_ConceptVer.VersionCount].ToString().Trim()); //版本统计
objzx_ConceptVerEN.zxShareId = objRow[conzx_ConceptVer.zxShareId].ToString().Trim(); //分享Id
objzx_ConceptVerEN.Memo = objRow[conzx_ConceptVer.Memo] == DBNull.Value ? null : objRow[conzx_ConceptVer.Memo].ToString().Trim(); //备注
objzx_ConceptVerEN.PdfDivLet = objRow[conzx_ConceptVer.PdfDivLet] == DBNull.Value ? null : objRow[conzx_ConceptVer.PdfDivLet].ToString().Trim(); //PdfDivLet
objzx_ConceptVerEN.PdfDivTop = objRow[conzx_ConceptVer.PdfDivTop] == DBNull.Value ? null : objRow[conzx_ConceptVer.PdfDivTop].ToString().Trim(); //PdfDivTop
objzx_ConceptVerEN.PdfPageNumIn = objRow[conzx_ConceptVer.PdfPageNumIn] == DBNull.Value ? null : objRow[conzx_ConceptVer.PdfPageNumIn].ToString().Trim(); //PdfPageNumIn
objzx_ConceptVerEN.PdfPageTop = objRow[conzx_ConceptVer.PdfPageTop] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_ConceptVer.PdfPageTop].ToString().Trim()); //pdf页面顶部位置
objzx_ConceptVerEN.PdfZoom = objRow[conzx_ConceptVer.PdfZoom] == DBNull.Value ? null : objRow[conzx_ConceptVer.PdfZoom].ToString().Trim(); //PdfZoom
objzx_ConceptVerEN.GroupTextId = objRow[conzx_ConceptVer.GroupTextId] == DBNull.Value ? null : objRow[conzx_ConceptVer.GroupTextId].ToString().Trim(); //小组Id
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objzx_ConceptVerEN.ConceptVId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objzx_ConceptVerEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrConceptVIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clszx_ConceptVerEN> GetObjLstByConceptVIdLstCache(List<long> arrConceptVIdLst)
{
string strKey = string.Format("{0}", clszx_ConceptVerEN._CurrTabName);
List<clszx_ConceptVerEN> arrzx_ConceptVerObjLstCache = GetObjLstCache();
IEnumerable <clszx_ConceptVerEN> arrzx_ConceptVerObjLst_Sel =
arrzx_ConceptVerObjLstCache
.Where(x => arrConceptVIdLst.Contains(x.ConceptVId));
return arrzx_ConceptVerObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clszx_ConceptVerEN> GetObjLst(string strWhereCond)
{
List<clszx_ConceptVerEN> arrObjLst = new List<clszx_ConceptVerEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clszx_ConceptVerEN objzx_ConceptVerEN = new clszx_ConceptVerEN();
try
{
objzx_ConceptVerEN.ConceptVId = Int32.Parse(objRow[conzx_ConceptVer.ConceptVId].ToString().Trim()); //ConceptVId
objzx_ConceptVerEN.zxConceptId = objRow[conzx_ConceptVer.zxConceptId].ToString().Trim(); //概念Id
objzx_ConceptVerEN.ConceptName = objRow[conzx_ConceptVer.ConceptName] == DBNull.Value ? null : objRow[conzx_ConceptVer.ConceptName].ToString().Trim(); //概念名称
objzx_ConceptVerEN.ConceptContent = objRow[conzx_ConceptVer.ConceptContent] == DBNull.Value ? null : objRow[conzx_ConceptVer.ConceptContent].ToString().Trim(); //概念内容
objzx_ConceptVerEN.TextId = objRow[conzx_ConceptVer.TextId] == DBNull.Value ? null : objRow[conzx_ConceptVer.TextId].ToString().Trim(); //课件Id
objzx_ConceptVerEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[conzx_ConceptVer.IsSubmit].ToString().Trim()); //是否提交
objzx_ConceptVerEN.VoteCount = objRow[conzx_ConceptVer.VoteCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_ConceptVer.VoteCount].ToString().Trim()); //点赞计数
objzx_ConceptVerEN.AppraiseCount = objRow[conzx_ConceptVer.AppraiseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_ConceptVer.AppraiseCount].ToString().Trim()); //评论数
objzx_ConceptVerEN.Score = objRow[conzx_ConceptVer.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conzx_ConceptVer.Score].ToString().Trim()); //评分
objzx_ConceptVerEN.StuScore = objRow[conzx_ConceptVer.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conzx_ConceptVer.StuScore].ToString().Trim()); //学生平均分
objzx_ConceptVerEN.TeaScore = objRow[conzx_ConceptVer.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conzx_ConceptVer.TeaScore].ToString().Trim()); //教师评分
objzx_ConceptVerEN.CreateDate = objRow[conzx_ConceptVer.CreateDate] == DBNull.Value ? null : objRow[conzx_ConceptVer.CreateDate].ToString().Trim(); //建立日期
objzx_ConceptVerEN.UpdDate = objRow[conzx_ConceptVer.UpdDate] == DBNull.Value ? null : objRow[conzx_ConceptVer.UpdDate].ToString().Trim(); //修改日期
objzx_ConceptVerEN.UpdUser = objRow[conzx_ConceptVer.UpdUser] == DBNull.Value ? null : objRow[conzx_ConceptVer.UpdUser].ToString().Trim(); //修改人
objzx_ConceptVerEN.IdCurrEduCls = objRow[conzx_ConceptVer.IdCurrEduCls] == DBNull.Value ? null : objRow[conzx_ConceptVer.IdCurrEduCls].ToString().Trim(); //教学班流水号
objzx_ConceptVerEN.PdfContent = objRow[conzx_ConceptVer.PdfContent] == DBNull.Value ? null : objRow[conzx_ConceptVer.PdfContent].ToString().Trim(); //Pdf内容
objzx_ConceptVerEN.PdfPageNum = objRow[conzx_ConceptVer.PdfPageNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_ConceptVer.PdfPageNum].ToString().Trim()); //Pdf页码
objzx_ConceptVerEN.CitationCount = objRow[conzx_ConceptVer.CitationCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_ConceptVer.CitationCount].ToString().Trim()); //引用统计
objzx_ConceptVerEN.VersionCount = objRow[conzx_ConceptVer.VersionCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_ConceptVer.VersionCount].ToString().Trim()); //版本统计
objzx_ConceptVerEN.zxShareId = objRow[conzx_ConceptVer.zxShareId].ToString().Trim(); //分享Id
objzx_ConceptVerEN.Memo = objRow[conzx_ConceptVer.Memo] == DBNull.Value ? null : objRow[conzx_ConceptVer.Memo].ToString().Trim(); //备注
objzx_ConceptVerEN.PdfDivLet = objRow[conzx_ConceptVer.PdfDivLet] == DBNull.Value ? null : objRow[conzx_ConceptVer.PdfDivLet].ToString().Trim(); //PdfDivLet
objzx_ConceptVerEN.PdfDivTop = objRow[conzx_ConceptVer.PdfDivTop] == DBNull.Value ? null : objRow[conzx_ConceptVer.PdfDivTop].ToString().Trim(); //PdfDivTop
objzx_ConceptVerEN.PdfPageNumIn = objRow[conzx_ConceptVer.PdfPageNumIn] == DBNull.Value ? null : objRow[conzx_ConceptVer.PdfPageNumIn].ToString().Trim(); //PdfPageNumIn
objzx_ConceptVerEN.PdfPageTop = objRow[conzx_ConceptVer.PdfPageTop] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_ConceptVer.PdfPageTop].ToString().Trim()); //pdf页面顶部位置
objzx_ConceptVerEN.PdfZoom = objRow[conzx_ConceptVer.PdfZoom] == DBNull.Value ? null : objRow[conzx_ConceptVer.PdfZoom].ToString().Trim(); //PdfZoom
objzx_ConceptVerEN.GroupTextId = objRow[conzx_ConceptVer.GroupTextId] == DBNull.Value ? null : objRow[conzx_ConceptVer.GroupTextId].ToString().Trim(); //小组Id
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objzx_ConceptVerEN.ConceptVId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objzx_ConceptVerEN);
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
public static List<clszx_ConceptVerEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clszx_ConceptVerEN> arrObjLst = new List<clszx_ConceptVerEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clszx_ConceptVerEN objzx_ConceptVerEN = new clszx_ConceptVerEN();
try
{
objzx_ConceptVerEN.ConceptVId = Int32.Parse(objRow[conzx_ConceptVer.ConceptVId].ToString().Trim()); //ConceptVId
objzx_ConceptVerEN.zxConceptId = objRow[conzx_ConceptVer.zxConceptId].ToString().Trim(); //概念Id
objzx_ConceptVerEN.ConceptName = objRow[conzx_ConceptVer.ConceptName] == DBNull.Value ? null : objRow[conzx_ConceptVer.ConceptName].ToString().Trim(); //概念名称
objzx_ConceptVerEN.ConceptContent = objRow[conzx_ConceptVer.ConceptContent] == DBNull.Value ? null : objRow[conzx_ConceptVer.ConceptContent].ToString().Trim(); //概念内容
objzx_ConceptVerEN.TextId = objRow[conzx_ConceptVer.TextId] == DBNull.Value ? null : objRow[conzx_ConceptVer.TextId].ToString().Trim(); //课件Id
objzx_ConceptVerEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[conzx_ConceptVer.IsSubmit].ToString().Trim()); //是否提交
objzx_ConceptVerEN.VoteCount = objRow[conzx_ConceptVer.VoteCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_ConceptVer.VoteCount].ToString().Trim()); //点赞计数
objzx_ConceptVerEN.AppraiseCount = objRow[conzx_ConceptVer.AppraiseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_ConceptVer.AppraiseCount].ToString().Trim()); //评论数
objzx_ConceptVerEN.Score = objRow[conzx_ConceptVer.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conzx_ConceptVer.Score].ToString().Trim()); //评分
objzx_ConceptVerEN.StuScore = objRow[conzx_ConceptVer.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conzx_ConceptVer.StuScore].ToString().Trim()); //学生平均分
objzx_ConceptVerEN.TeaScore = objRow[conzx_ConceptVer.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conzx_ConceptVer.TeaScore].ToString().Trim()); //教师评分
objzx_ConceptVerEN.CreateDate = objRow[conzx_ConceptVer.CreateDate] == DBNull.Value ? null : objRow[conzx_ConceptVer.CreateDate].ToString().Trim(); //建立日期
objzx_ConceptVerEN.UpdDate = objRow[conzx_ConceptVer.UpdDate] == DBNull.Value ? null : objRow[conzx_ConceptVer.UpdDate].ToString().Trim(); //修改日期
objzx_ConceptVerEN.UpdUser = objRow[conzx_ConceptVer.UpdUser] == DBNull.Value ? null : objRow[conzx_ConceptVer.UpdUser].ToString().Trim(); //修改人
objzx_ConceptVerEN.IdCurrEduCls = objRow[conzx_ConceptVer.IdCurrEduCls] == DBNull.Value ? null : objRow[conzx_ConceptVer.IdCurrEduCls].ToString().Trim(); //教学班流水号
objzx_ConceptVerEN.PdfContent = objRow[conzx_ConceptVer.PdfContent] == DBNull.Value ? null : objRow[conzx_ConceptVer.PdfContent].ToString().Trim(); //Pdf内容
objzx_ConceptVerEN.PdfPageNum = objRow[conzx_ConceptVer.PdfPageNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_ConceptVer.PdfPageNum].ToString().Trim()); //Pdf页码
objzx_ConceptVerEN.CitationCount = objRow[conzx_ConceptVer.CitationCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_ConceptVer.CitationCount].ToString().Trim()); //引用统计
objzx_ConceptVerEN.VersionCount = objRow[conzx_ConceptVer.VersionCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_ConceptVer.VersionCount].ToString().Trim()); //版本统计
objzx_ConceptVerEN.zxShareId = objRow[conzx_ConceptVer.zxShareId].ToString().Trim(); //分享Id
objzx_ConceptVerEN.Memo = objRow[conzx_ConceptVer.Memo] == DBNull.Value ? null : objRow[conzx_ConceptVer.Memo].ToString().Trim(); //备注
objzx_ConceptVerEN.PdfDivLet = objRow[conzx_ConceptVer.PdfDivLet] == DBNull.Value ? null : objRow[conzx_ConceptVer.PdfDivLet].ToString().Trim(); //PdfDivLet
objzx_ConceptVerEN.PdfDivTop = objRow[conzx_ConceptVer.PdfDivTop] == DBNull.Value ? null : objRow[conzx_ConceptVer.PdfDivTop].ToString().Trim(); //PdfDivTop
objzx_ConceptVerEN.PdfPageNumIn = objRow[conzx_ConceptVer.PdfPageNumIn] == DBNull.Value ? null : objRow[conzx_ConceptVer.PdfPageNumIn].ToString().Trim(); //PdfPageNumIn
objzx_ConceptVerEN.PdfPageTop = objRow[conzx_ConceptVer.PdfPageTop] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_ConceptVer.PdfPageTop].ToString().Trim()); //pdf页面顶部位置
objzx_ConceptVerEN.PdfZoom = objRow[conzx_ConceptVer.PdfZoom] == DBNull.Value ? null : objRow[conzx_ConceptVer.PdfZoom].ToString().Trim(); //PdfZoom
objzx_ConceptVerEN.GroupTextId = objRow[conzx_ConceptVer.GroupTextId] == DBNull.Value ? null : objRow[conzx_ConceptVer.GroupTextId].ToString().Trim(); //小组Id
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objzx_ConceptVerEN.ConceptVId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objzx_ConceptVerEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objzx_ConceptVerCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clszx_ConceptVerEN> GetSubObjLstCache(clszx_ConceptVerEN objzx_ConceptVerCond)
{
List<clszx_ConceptVerEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clszx_ConceptVerEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conzx_ConceptVer.AttributeName)
{
if (objzx_ConceptVerCond.IsUpdated(strFldName) == false) continue;
if (objzx_ConceptVerCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objzx_ConceptVerCond[strFldName].ToString());
}
else
{
if (objzx_ConceptVerCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objzx_ConceptVerCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objzx_ConceptVerCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objzx_ConceptVerCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objzx_ConceptVerCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objzx_ConceptVerCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objzx_ConceptVerCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objzx_ConceptVerCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objzx_ConceptVerCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objzx_ConceptVerCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objzx_ConceptVerCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objzx_ConceptVerCond[strFldName]));
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
public static List<clszx_ConceptVerEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clszx_ConceptVerEN> arrObjLst = new List<clszx_ConceptVerEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clszx_ConceptVerEN objzx_ConceptVerEN = new clszx_ConceptVerEN();
try
{
objzx_ConceptVerEN.ConceptVId = Int32.Parse(objRow[conzx_ConceptVer.ConceptVId].ToString().Trim()); //ConceptVId
objzx_ConceptVerEN.zxConceptId = objRow[conzx_ConceptVer.zxConceptId].ToString().Trim(); //概念Id
objzx_ConceptVerEN.ConceptName = objRow[conzx_ConceptVer.ConceptName] == DBNull.Value ? null : objRow[conzx_ConceptVer.ConceptName].ToString().Trim(); //概念名称
objzx_ConceptVerEN.ConceptContent = objRow[conzx_ConceptVer.ConceptContent] == DBNull.Value ? null : objRow[conzx_ConceptVer.ConceptContent].ToString().Trim(); //概念内容
objzx_ConceptVerEN.TextId = objRow[conzx_ConceptVer.TextId] == DBNull.Value ? null : objRow[conzx_ConceptVer.TextId].ToString().Trim(); //课件Id
objzx_ConceptVerEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[conzx_ConceptVer.IsSubmit].ToString().Trim()); //是否提交
objzx_ConceptVerEN.VoteCount = objRow[conzx_ConceptVer.VoteCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_ConceptVer.VoteCount].ToString().Trim()); //点赞计数
objzx_ConceptVerEN.AppraiseCount = objRow[conzx_ConceptVer.AppraiseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_ConceptVer.AppraiseCount].ToString().Trim()); //评论数
objzx_ConceptVerEN.Score = objRow[conzx_ConceptVer.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conzx_ConceptVer.Score].ToString().Trim()); //评分
objzx_ConceptVerEN.StuScore = objRow[conzx_ConceptVer.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conzx_ConceptVer.StuScore].ToString().Trim()); //学生平均分
objzx_ConceptVerEN.TeaScore = objRow[conzx_ConceptVer.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conzx_ConceptVer.TeaScore].ToString().Trim()); //教师评分
objzx_ConceptVerEN.CreateDate = objRow[conzx_ConceptVer.CreateDate] == DBNull.Value ? null : objRow[conzx_ConceptVer.CreateDate].ToString().Trim(); //建立日期
objzx_ConceptVerEN.UpdDate = objRow[conzx_ConceptVer.UpdDate] == DBNull.Value ? null : objRow[conzx_ConceptVer.UpdDate].ToString().Trim(); //修改日期
objzx_ConceptVerEN.UpdUser = objRow[conzx_ConceptVer.UpdUser] == DBNull.Value ? null : objRow[conzx_ConceptVer.UpdUser].ToString().Trim(); //修改人
objzx_ConceptVerEN.IdCurrEduCls = objRow[conzx_ConceptVer.IdCurrEduCls] == DBNull.Value ? null : objRow[conzx_ConceptVer.IdCurrEduCls].ToString().Trim(); //教学班流水号
objzx_ConceptVerEN.PdfContent = objRow[conzx_ConceptVer.PdfContent] == DBNull.Value ? null : objRow[conzx_ConceptVer.PdfContent].ToString().Trim(); //Pdf内容
objzx_ConceptVerEN.PdfPageNum = objRow[conzx_ConceptVer.PdfPageNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_ConceptVer.PdfPageNum].ToString().Trim()); //Pdf页码
objzx_ConceptVerEN.CitationCount = objRow[conzx_ConceptVer.CitationCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_ConceptVer.CitationCount].ToString().Trim()); //引用统计
objzx_ConceptVerEN.VersionCount = objRow[conzx_ConceptVer.VersionCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_ConceptVer.VersionCount].ToString().Trim()); //版本统计
objzx_ConceptVerEN.zxShareId = objRow[conzx_ConceptVer.zxShareId].ToString().Trim(); //分享Id
objzx_ConceptVerEN.Memo = objRow[conzx_ConceptVer.Memo] == DBNull.Value ? null : objRow[conzx_ConceptVer.Memo].ToString().Trim(); //备注
objzx_ConceptVerEN.PdfDivLet = objRow[conzx_ConceptVer.PdfDivLet] == DBNull.Value ? null : objRow[conzx_ConceptVer.PdfDivLet].ToString().Trim(); //PdfDivLet
objzx_ConceptVerEN.PdfDivTop = objRow[conzx_ConceptVer.PdfDivTop] == DBNull.Value ? null : objRow[conzx_ConceptVer.PdfDivTop].ToString().Trim(); //PdfDivTop
objzx_ConceptVerEN.PdfPageNumIn = objRow[conzx_ConceptVer.PdfPageNumIn] == DBNull.Value ? null : objRow[conzx_ConceptVer.PdfPageNumIn].ToString().Trim(); //PdfPageNumIn
objzx_ConceptVerEN.PdfPageTop = objRow[conzx_ConceptVer.PdfPageTop] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_ConceptVer.PdfPageTop].ToString().Trim()); //pdf页面顶部位置
objzx_ConceptVerEN.PdfZoom = objRow[conzx_ConceptVer.PdfZoom] == DBNull.Value ? null : objRow[conzx_ConceptVer.PdfZoom].ToString().Trim(); //PdfZoom
objzx_ConceptVerEN.GroupTextId = objRow[conzx_ConceptVer.GroupTextId] == DBNull.Value ? null : objRow[conzx_ConceptVer.GroupTextId].ToString().Trim(); //小组Id
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objzx_ConceptVerEN.ConceptVId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objzx_ConceptVerEN);
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
public static List<clszx_ConceptVerEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clszx_ConceptVerEN> arrObjLst = new List<clszx_ConceptVerEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clszx_ConceptVerEN objzx_ConceptVerEN = new clszx_ConceptVerEN();
try
{
objzx_ConceptVerEN.ConceptVId = Int32.Parse(objRow[conzx_ConceptVer.ConceptVId].ToString().Trim()); //ConceptVId
objzx_ConceptVerEN.zxConceptId = objRow[conzx_ConceptVer.zxConceptId].ToString().Trim(); //概念Id
objzx_ConceptVerEN.ConceptName = objRow[conzx_ConceptVer.ConceptName] == DBNull.Value ? null : objRow[conzx_ConceptVer.ConceptName].ToString().Trim(); //概念名称
objzx_ConceptVerEN.ConceptContent = objRow[conzx_ConceptVer.ConceptContent] == DBNull.Value ? null : objRow[conzx_ConceptVer.ConceptContent].ToString().Trim(); //概念内容
objzx_ConceptVerEN.TextId = objRow[conzx_ConceptVer.TextId] == DBNull.Value ? null : objRow[conzx_ConceptVer.TextId].ToString().Trim(); //课件Id
objzx_ConceptVerEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[conzx_ConceptVer.IsSubmit].ToString().Trim()); //是否提交
objzx_ConceptVerEN.VoteCount = objRow[conzx_ConceptVer.VoteCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_ConceptVer.VoteCount].ToString().Trim()); //点赞计数
objzx_ConceptVerEN.AppraiseCount = objRow[conzx_ConceptVer.AppraiseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_ConceptVer.AppraiseCount].ToString().Trim()); //评论数
objzx_ConceptVerEN.Score = objRow[conzx_ConceptVer.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conzx_ConceptVer.Score].ToString().Trim()); //评分
objzx_ConceptVerEN.StuScore = objRow[conzx_ConceptVer.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conzx_ConceptVer.StuScore].ToString().Trim()); //学生平均分
objzx_ConceptVerEN.TeaScore = objRow[conzx_ConceptVer.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conzx_ConceptVer.TeaScore].ToString().Trim()); //教师评分
objzx_ConceptVerEN.CreateDate = objRow[conzx_ConceptVer.CreateDate] == DBNull.Value ? null : objRow[conzx_ConceptVer.CreateDate].ToString().Trim(); //建立日期
objzx_ConceptVerEN.UpdDate = objRow[conzx_ConceptVer.UpdDate] == DBNull.Value ? null : objRow[conzx_ConceptVer.UpdDate].ToString().Trim(); //修改日期
objzx_ConceptVerEN.UpdUser = objRow[conzx_ConceptVer.UpdUser] == DBNull.Value ? null : objRow[conzx_ConceptVer.UpdUser].ToString().Trim(); //修改人
objzx_ConceptVerEN.IdCurrEduCls = objRow[conzx_ConceptVer.IdCurrEduCls] == DBNull.Value ? null : objRow[conzx_ConceptVer.IdCurrEduCls].ToString().Trim(); //教学班流水号
objzx_ConceptVerEN.PdfContent = objRow[conzx_ConceptVer.PdfContent] == DBNull.Value ? null : objRow[conzx_ConceptVer.PdfContent].ToString().Trim(); //Pdf内容
objzx_ConceptVerEN.PdfPageNum = objRow[conzx_ConceptVer.PdfPageNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_ConceptVer.PdfPageNum].ToString().Trim()); //Pdf页码
objzx_ConceptVerEN.CitationCount = objRow[conzx_ConceptVer.CitationCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_ConceptVer.CitationCount].ToString().Trim()); //引用统计
objzx_ConceptVerEN.VersionCount = objRow[conzx_ConceptVer.VersionCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_ConceptVer.VersionCount].ToString().Trim()); //版本统计
objzx_ConceptVerEN.zxShareId = objRow[conzx_ConceptVer.zxShareId].ToString().Trim(); //分享Id
objzx_ConceptVerEN.Memo = objRow[conzx_ConceptVer.Memo] == DBNull.Value ? null : objRow[conzx_ConceptVer.Memo].ToString().Trim(); //备注
objzx_ConceptVerEN.PdfDivLet = objRow[conzx_ConceptVer.PdfDivLet] == DBNull.Value ? null : objRow[conzx_ConceptVer.PdfDivLet].ToString().Trim(); //PdfDivLet
objzx_ConceptVerEN.PdfDivTop = objRow[conzx_ConceptVer.PdfDivTop] == DBNull.Value ? null : objRow[conzx_ConceptVer.PdfDivTop].ToString().Trim(); //PdfDivTop
objzx_ConceptVerEN.PdfPageNumIn = objRow[conzx_ConceptVer.PdfPageNumIn] == DBNull.Value ? null : objRow[conzx_ConceptVer.PdfPageNumIn].ToString().Trim(); //PdfPageNumIn
objzx_ConceptVerEN.PdfPageTop = objRow[conzx_ConceptVer.PdfPageTop] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_ConceptVer.PdfPageTop].ToString().Trim()); //pdf页面顶部位置
objzx_ConceptVerEN.PdfZoom = objRow[conzx_ConceptVer.PdfZoom] == DBNull.Value ? null : objRow[conzx_ConceptVer.PdfZoom].ToString().Trim(); //PdfZoom
objzx_ConceptVerEN.GroupTextId = objRow[conzx_ConceptVer.GroupTextId] == DBNull.Value ? null : objRow[conzx_ConceptVer.GroupTextId].ToString().Trim(); //小组Id
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objzx_ConceptVerEN.ConceptVId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objzx_ConceptVerEN);
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
List<clszx_ConceptVerEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clszx_ConceptVerEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clszx_ConceptVerEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clszx_ConceptVerEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clszx_ConceptVerEN> arrObjLst = new List<clszx_ConceptVerEN>(); 
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
	clszx_ConceptVerEN objzx_ConceptVerEN = new clszx_ConceptVerEN();
try
{
objzx_ConceptVerEN.ConceptVId = Int32.Parse(objRow[conzx_ConceptVer.ConceptVId].ToString().Trim()); //ConceptVId
objzx_ConceptVerEN.zxConceptId = objRow[conzx_ConceptVer.zxConceptId].ToString().Trim(); //概念Id
objzx_ConceptVerEN.ConceptName = objRow[conzx_ConceptVer.ConceptName] == DBNull.Value ? null : objRow[conzx_ConceptVer.ConceptName].ToString().Trim(); //概念名称
objzx_ConceptVerEN.ConceptContent = objRow[conzx_ConceptVer.ConceptContent] == DBNull.Value ? null : objRow[conzx_ConceptVer.ConceptContent].ToString().Trim(); //概念内容
objzx_ConceptVerEN.TextId = objRow[conzx_ConceptVer.TextId] == DBNull.Value ? null : objRow[conzx_ConceptVer.TextId].ToString().Trim(); //课件Id
objzx_ConceptVerEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[conzx_ConceptVer.IsSubmit].ToString().Trim()); //是否提交
objzx_ConceptVerEN.VoteCount = objRow[conzx_ConceptVer.VoteCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_ConceptVer.VoteCount].ToString().Trim()); //点赞计数
objzx_ConceptVerEN.AppraiseCount = objRow[conzx_ConceptVer.AppraiseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_ConceptVer.AppraiseCount].ToString().Trim()); //评论数
objzx_ConceptVerEN.Score = objRow[conzx_ConceptVer.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conzx_ConceptVer.Score].ToString().Trim()); //评分
objzx_ConceptVerEN.StuScore = objRow[conzx_ConceptVer.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conzx_ConceptVer.StuScore].ToString().Trim()); //学生平均分
objzx_ConceptVerEN.TeaScore = objRow[conzx_ConceptVer.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conzx_ConceptVer.TeaScore].ToString().Trim()); //教师评分
objzx_ConceptVerEN.CreateDate = objRow[conzx_ConceptVer.CreateDate] == DBNull.Value ? null : objRow[conzx_ConceptVer.CreateDate].ToString().Trim(); //建立日期
objzx_ConceptVerEN.UpdDate = objRow[conzx_ConceptVer.UpdDate] == DBNull.Value ? null : objRow[conzx_ConceptVer.UpdDate].ToString().Trim(); //修改日期
objzx_ConceptVerEN.UpdUser = objRow[conzx_ConceptVer.UpdUser] == DBNull.Value ? null : objRow[conzx_ConceptVer.UpdUser].ToString().Trim(); //修改人
objzx_ConceptVerEN.IdCurrEduCls = objRow[conzx_ConceptVer.IdCurrEduCls] == DBNull.Value ? null : objRow[conzx_ConceptVer.IdCurrEduCls].ToString().Trim(); //教学班流水号
objzx_ConceptVerEN.PdfContent = objRow[conzx_ConceptVer.PdfContent] == DBNull.Value ? null : objRow[conzx_ConceptVer.PdfContent].ToString().Trim(); //Pdf内容
objzx_ConceptVerEN.PdfPageNum = objRow[conzx_ConceptVer.PdfPageNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_ConceptVer.PdfPageNum].ToString().Trim()); //Pdf页码
objzx_ConceptVerEN.CitationCount = objRow[conzx_ConceptVer.CitationCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_ConceptVer.CitationCount].ToString().Trim()); //引用统计
objzx_ConceptVerEN.VersionCount = objRow[conzx_ConceptVer.VersionCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_ConceptVer.VersionCount].ToString().Trim()); //版本统计
objzx_ConceptVerEN.zxShareId = objRow[conzx_ConceptVer.zxShareId].ToString().Trim(); //分享Id
objzx_ConceptVerEN.Memo = objRow[conzx_ConceptVer.Memo] == DBNull.Value ? null : objRow[conzx_ConceptVer.Memo].ToString().Trim(); //备注
objzx_ConceptVerEN.PdfDivLet = objRow[conzx_ConceptVer.PdfDivLet] == DBNull.Value ? null : objRow[conzx_ConceptVer.PdfDivLet].ToString().Trim(); //PdfDivLet
objzx_ConceptVerEN.PdfDivTop = objRow[conzx_ConceptVer.PdfDivTop] == DBNull.Value ? null : objRow[conzx_ConceptVer.PdfDivTop].ToString().Trim(); //PdfDivTop
objzx_ConceptVerEN.PdfPageNumIn = objRow[conzx_ConceptVer.PdfPageNumIn] == DBNull.Value ? null : objRow[conzx_ConceptVer.PdfPageNumIn].ToString().Trim(); //PdfPageNumIn
objzx_ConceptVerEN.PdfPageTop = objRow[conzx_ConceptVer.PdfPageTop] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_ConceptVer.PdfPageTop].ToString().Trim()); //pdf页面顶部位置
objzx_ConceptVerEN.PdfZoom = objRow[conzx_ConceptVer.PdfZoom] == DBNull.Value ? null : objRow[conzx_ConceptVer.PdfZoom].ToString().Trim(); //PdfZoom
objzx_ConceptVerEN.GroupTextId = objRow[conzx_ConceptVer.GroupTextId] == DBNull.Value ? null : objRow[conzx_ConceptVer.GroupTextId].ToString().Trim(); //小组Id
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objzx_ConceptVerEN.ConceptVId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objzx_ConceptVerEN);
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
public static List<clszx_ConceptVerEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clszx_ConceptVerEN> arrObjLst = new List<clszx_ConceptVerEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clszx_ConceptVerEN objzx_ConceptVerEN = new clszx_ConceptVerEN();
try
{
objzx_ConceptVerEN.ConceptVId = Int32.Parse(objRow[conzx_ConceptVer.ConceptVId].ToString().Trim()); //ConceptVId
objzx_ConceptVerEN.zxConceptId = objRow[conzx_ConceptVer.zxConceptId].ToString().Trim(); //概念Id
objzx_ConceptVerEN.ConceptName = objRow[conzx_ConceptVer.ConceptName] == DBNull.Value ? null : objRow[conzx_ConceptVer.ConceptName].ToString().Trim(); //概念名称
objzx_ConceptVerEN.ConceptContent = objRow[conzx_ConceptVer.ConceptContent] == DBNull.Value ? null : objRow[conzx_ConceptVer.ConceptContent].ToString().Trim(); //概念内容
objzx_ConceptVerEN.TextId = objRow[conzx_ConceptVer.TextId] == DBNull.Value ? null : objRow[conzx_ConceptVer.TextId].ToString().Trim(); //课件Id
objzx_ConceptVerEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[conzx_ConceptVer.IsSubmit].ToString().Trim()); //是否提交
objzx_ConceptVerEN.VoteCount = objRow[conzx_ConceptVer.VoteCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_ConceptVer.VoteCount].ToString().Trim()); //点赞计数
objzx_ConceptVerEN.AppraiseCount = objRow[conzx_ConceptVer.AppraiseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_ConceptVer.AppraiseCount].ToString().Trim()); //评论数
objzx_ConceptVerEN.Score = objRow[conzx_ConceptVer.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conzx_ConceptVer.Score].ToString().Trim()); //评分
objzx_ConceptVerEN.StuScore = objRow[conzx_ConceptVer.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conzx_ConceptVer.StuScore].ToString().Trim()); //学生平均分
objzx_ConceptVerEN.TeaScore = objRow[conzx_ConceptVer.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conzx_ConceptVer.TeaScore].ToString().Trim()); //教师评分
objzx_ConceptVerEN.CreateDate = objRow[conzx_ConceptVer.CreateDate] == DBNull.Value ? null : objRow[conzx_ConceptVer.CreateDate].ToString().Trim(); //建立日期
objzx_ConceptVerEN.UpdDate = objRow[conzx_ConceptVer.UpdDate] == DBNull.Value ? null : objRow[conzx_ConceptVer.UpdDate].ToString().Trim(); //修改日期
objzx_ConceptVerEN.UpdUser = objRow[conzx_ConceptVer.UpdUser] == DBNull.Value ? null : objRow[conzx_ConceptVer.UpdUser].ToString().Trim(); //修改人
objzx_ConceptVerEN.IdCurrEduCls = objRow[conzx_ConceptVer.IdCurrEduCls] == DBNull.Value ? null : objRow[conzx_ConceptVer.IdCurrEduCls].ToString().Trim(); //教学班流水号
objzx_ConceptVerEN.PdfContent = objRow[conzx_ConceptVer.PdfContent] == DBNull.Value ? null : objRow[conzx_ConceptVer.PdfContent].ToString().Trim(); //Pdf内容
objzx_ConceptVerEN.PdfPageNum = objRow[conzx_ConceptVer.PdfPageNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_ConceptVer.PdfPageNum].ToString().Trim()); //Pdf页码
objzx_ConceptVerEN.CitationCount = objRow[conzx_ConceptVer.CitationCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_ConceptVer.CitationCount].ToString().Trim()); //引用统计
objzx_ConceptVerEN.VersionCount = objRow[conzx_ConceptVer.VersionCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_ConceptVer.VersionCount].ToString().Trim()); //版本统计
objzx_ConceptVerEN.zxShareId = objRow[conzx_ConceptVer.zxShareId].ToString().Trim(); //分享Id
objzx_ConceptVerEN.Memo = objRow[conzx_ConceptVer.Memo] == DBNull.Value ? null : objRow[conzx_ConceptVer.Memo].ToString().Trim(); //备注
objzx_ConceptVerEN.PdfDivLet = objRow[conzx_ConceptVer.PdfDivLet] == DBNull.Value ? null : objRow[conzx_ConceptVer.PdfDivLet].ToString().Trim(); //PdfDivLet
objzx_ConceptVerEN.PdfDivTop = objRow[conzx_ConceptVer.PdfDivTop] == DBNull.Value ? null : objRow[conzx_ConceptVer.PdfDivTop].ToString().Trim(); //PdfDivTop
objzx_ConceptVerEN.PdfPageNumIn = objRow[conzx_ConceptVer.PdfPageNumIn] == DBNull.Value ? null : objRow[conzx_ConceptVer.PdfPageNumIn].ToString().Trim(); //PdfPageNumIn
objzx_ConceptVerEN.PdfPageTop = objRow[conzx_ConceptVer.PdfPageTop] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_ConceptVer.PdfPageTop].ToString().Trim()); //pdf页面顶部位置
objzx_ConceptVerEN.PdfZoom = objRow[conzx_ConceptVer.PdfZoom] == DBNull.Value ? null : objRow[conzx_ConceptVer.PdfZoom].ToString().Trim(); //PdfZoom
objzx_ConceptVerEN.GroupTextId = objRow[conzx_ConceptVer.GroupTextId] == DBNull.Value ? null : objRow[conzx_ConceptVer.GroupTextId].ToString().Trim(); //小组Id
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objzx_ConceptVerEN.ConceptVId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objzx_ConceptVerEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clszx_ConceptVerEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clszx_ConceptVerEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clszx_ConceptVerEN> arrObjLst = new List<clszx_ConceptVerEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clszx_ConceptVerEN objzx_ConceptVerEN = new clszx_ConceptVerEN();
try
{
objzx_ConceptVerEN.ConceptVId = Int32.Parse(objRow[conzx_ConceptVer.ConceptVId].ToString().Trim()); //ConceptVId
objzx_ConceptVerEN.zxConceptId = objRow[conzx_ConceptVer.zxConceptId].ToString().Trim(); //概念Id
objzx_ConceptVerEN.ConceptName = objRow[conzx_ConceptVer.ConceptName] == DBNull.Value ? null : objRow[conzx_ConceptVer.ConceptName].ToString().Trim(); //概念名称
objzx_ConceptVerEN.ConceptContent = objRow[conzx_ConceptVer.ConceptContent] == DBNull.Value ? null : objRow[conzx_ConceptVer.ConceptContent].ToString().Trim(); //概念内容
objzx_ConceptVerEN.TextId = objRow[conzx_ConceptVer.TextId] == DBNull.Value ? null : objRow[conzx_ConceptVer.TextId].ToString().Trim(); //课件Id
objzx_ConceptVerEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[conzx_ConceptVer.IsSubmit].ToString().Trim()); //是否提交
objzx_ConceptVerEN.VoteCount = objRow[conzx_ConceptVer.VoteCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_ConceptVer.VoteCount].ToString().Trim()); //点赞计数
objzx_ConceptVerEN.AppraiseCount = objRow[conzx_ConceptVer.AppraiseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_ConceptVer.AppraiseCount].ToString().Trim()); //评论数
objzx_ConceptVerEN.Score = objRow[conzx_ConceptVer.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conzx_ConceptVer.Score].ToString().Trim()); //评分
objzx_ConceptVerEN.StuScore = objRow[conzx_ConceptVer.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conzx_ConceptVer.StuScore].ToString().Trim()); //学生平均分
objzx_ConceptVerEN.TeaScore = objRow[conzx_ConceptVer.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conzx_ConceptVer.TeaScore].ToString().Trim()); //教师评分
objzx_ConceptVerEN.CreateDate = objRow[conzx_ConceptVer.CreateDate] == DBNull.Value ? null : objRow[conzx_ConceptVer.CreateDate].ToString().Trim(); //建立日期
objzx_ConceptVerEN.UpdDate = objRow[conzx_ConceptVer.UpdDate] == DBNull.Value ? null : objRow[conzx_ConceptVer.UpdDate].ToString().Trim(); //修改日期
objzx_ConceptVerEN.UpdUser = objRow[conzx_ConceptVer.UpdUser] == DBNull.Value ? null : objRow[conzx_ConceptVer.UpdUser].ToString().Trim(); //修改人
objzx_ConceptVerEN.IdCurrEduCls = objRow[conzx_ConceptVer.IdCurrEduCls] == DBNull.Value ? null : objRow[conzx_ConceptVer.IdCurrEduCls].ToString().Trim(); //教学班流水号
objzx_ConceptVerEN.PdfContent = objRow[conzx_ConceptVer.PdfContent] == DBNull.Value ? null : objRow[conzx_ConceptVer.PdfContent].ToString().Trim(); //Pdf内容
objzx_ConceptVerEN.PdfPageNum = objRow[conzx_ConceptVer.PdfPageNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_ConceptVer.PdfPageNum].ToString().Trim()); //Pdf页码
objzx_ConceptVerEN.CitationCount = objRow[conzx_ConceptVer.CitationCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_ConceptVer.CitationCount].ToString().Trim()); //引用统计
objzx_ConceptVerEN.VersionCount = objRow[conzx_ConceptVer.VersionCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_ConceptVer.VersionCount].ToString().Trim()); //版本统计
objzx_ConceptVerEN.zxShareId = objRow[conzx_ConceptVer.zxShareId].ToString().Trim(); //分享Id
objzx_ConceptVerEN.Memo = objRow[conzx_ConceptVer.Memo] == DBNull.Value ? null : objRow[conzx_ConceptVer.Memo].ToString().Trim(); //备注
objzx_ConceptVerEN.PdfDivLet = objRow[conzx_ConceptVer.PdfDivLet] == DBNull.Value ? null : objRow[conzx_ConceptVer.PdfDivLet].ToString().Trim(); //PdfDivLet
objzx_ConceptVerEN.PdfDivTop = objRow[conzx_ConceptVer.PdfDivTop] == DBNull.Value ? null : objRow[conzx_ConceptVer.PdfDivTop].ToString().Trim(); //PdfDivTop
objzx_ConceptVerEN.PdfPageNumIn = objRow[conzx_ConceptVer.PdfPageNumIn] == DBNull.Value ? null : objRow[conzx_ConceptVer.PdfPageNumIn].ToString().Trim(); //PdfPageNumIn
objzx_ConceptVerEN.PdfPageTop = objRow[conzx_ConceptVer.PdfPageTop] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_ConceptVer.PdfPageTop].ToString().Trim()); //pdf页面顶部位置
objzx_ConceptVerEN.PdfZoom = objRow[conzx_ConceptVer.PdfZoom] == DBNull.Value ? null : objRow[conzx_ConceptVer.PdfZoom].ToString().Trim(); //PdfZoom
objzx_ConceptVerEN.GroupTextId = objRow[conzx_ConceptVer.GroupTextId] == DBNull.Value ? null : objRow[conzx_ConceptVer.GroupTextId].ToString().Trim(); //小组Id
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objzx_ConceptVerEN.ConceptVId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objzx_ConceptVerEN);
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
public static List<clszx_ConceptVerEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clszx_ConceptVerEN> arrObjLst = new List<clszx_ConceptVerEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clszx_ConceptVerEN objzx_ConceptVerEN = new clszx_ConceptVerEN();
try
{
objzx_ConceptVerEN.ConceptVId = Int32.Parse(objRow[conzx_ConceptVer.ConceptVId].ToString().Trim()); //ConceptVId
objzx_ConceptVerEN.zxConceptId = objRow[conzx_ConceptVer.zxConceptId].ToString().Trim(); //概念Id
objzx_ConceptVerEN.ConceptName = objRow[conzx_ConceptVer.ConceptName] == DBNull.Value ? null : objRow[conzx_ConceptVer.ConceptName].ToString().Trim(); //概念名称
objzx_ConceptVerEN.ConceptContent = objRow[conzx_ConceptVer.ConceptContent] == DBNull.Value ? null : objRow[conzx_ConceptVer.ConceptContent].ToString().Trim(); //概念内容
objzx_ConceptVerEN.TextId = objRow[conzx_ConceptVer.TextId] == DBNull.Value ? null : objRow[conzx_ConceptVer.TextId].ToString().Trim(); //课件Id
objzx_ConceptVerEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[conzx_ConceptVer.IsSubmit].ToString().Trim()); //是否提交
objzx_ConceptVerEN.VoteCount = objRow[conzx_ConceptVer.VoteCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_ConceptVer.VoteCount].ToString().Trim()); //点赞计数
objzx_ConceptVerEN.AppraiseCount = objRow[conzx_ConceptVer.AppraiseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_ConceptVer.AppraiseCount].ToString().Trim()); //评论数
objzx_ConceptVerEN.Score = objRow[conzx_ConceptVer.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conzx_ConceptVer.Score].ToString().Trim()); //评分
objzx_ConceptVerEN.StuScore = objRow[conzx_ConceptVer.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conzx_ConceptVer.StuScore].ToString().Trim()); //学生平均分
objzx_ConceptVerEN.TeaScore = objRow[conzx_ConceptVer.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conzx_ConceptVer.TeaScore].ToString().Trim()); //教师评分
objzx_ConceptVerEN.CreateDate = objRow[conzx_ConceptVer.CreateDate] == DBNull.Value ? null : objRow[conzx_ConceptVer.CreateDate].ToString().Trim(); //建立日期
objzx_ConceptVerEN.UpdDate = objRow[conzx_ConceptVer.UpdDate] == DBNull.Value ? null : objRow[conzx_ConceptVer.UpdDate].ToString().Trim(); //修改日期
objzx_ConceptVerEN.UpdUser = objRow[conzx_ConceptVer.UpdUser] == DBNull.Value ? null : objRow[conzx_ConceptVer.UpdUser].ToString().Trim(); //修改人
objzx_ConceptVerEN.IdCurrEduCls = objRow[conzx_ConceptVer.IdCurrEduCls] == DBNull.Value ? null : objRow[conzx_ConceptVer.IdCurrEduCls].ToString().Trim(); //教学班流水号
objzx_ConceptVerEN.PdfContent = objRow[conzx_ConceptVer.PdfContent] == DBNull.Value ? null : objRow[conzx_ConceptVer.PdfContent].ToString().Trim(); //Pdf内容
objzx_ConceptVerEN.PdfPageNum = objRow[conzx_ConceptVer.PdfPageNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_ConceptVer.PdfPageNum].ToString().Trim()); //Pdf页码
objzx_ConceptVerEN.CitationCount = objRow[conzx_ConceptVer.CitationCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_ConceptVer.CitationCount].ToString().Trim()); //引用统计
objzx_ConceptVerEN.VersionCount = objRow[conzx_ConceptVer.VersionCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_ConceptVer.VersionCount].ToString().Trim()); //版本统计
objzx_ConceptVerEN.zxShareId = objRow[conzx_ConceptVer.zxShareId].ToString().Trim(); //分享Id
objzx_ConceptVerEN.Memo = objRow[conzx_ConceptVer.Memo] == DBNull.Value ? null : objRow[conzx_ConceptVer.Memo].ToString().Trim(); //备注
objzx_ConceptVerEN.PdfDivLet = objRow[conzx_ConceptVer.PdfDivLet] == DBNull.Value ? null : objRow[conzx_ConceptVer.PdfDivLet].ToString().Trim(); //PdfDivLet
objzx_ConceptVerEN.PdfDivTop = objRow[conzx_ConceptVer.PdfDivTop] == DBNull.Value ? null : objRow[conzx_ConceptVer.PdfDivTop].ToString().Trim(); //PdfDivTop
objzx_ConceptVerEN.PdfPageNumIn = objRow[conzx_ConceptVer.PdfPageNumIn] == DBNull.Value ? null : objRow[conzx_ConceptVer.PdfPageNumIn].ToString().Trim(); //PdfPageNumIn
objzx_ConceptVerEN.PdfPageTop = objRow[conzx_ConceptVer.PdfPageTop] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_ConceptVer.PdfPageTop].ToString().Trim()); //pdf页面顶部位置
objzx_ConceptVerEN.PdfZoom = objRow[conzx_ConceptVer.PdfZoom] == DBNull.Value ? null : objRow[conzx_ConceptVer.PdfZoom].ToString().Trim(); //PdfZoom
objzx_ConceptVerEN.GroupTextId = objRow[conzx_ConceptVer.GroupTextId] == DBNull.Value ? null : objRow[conzx_ConceptVer.GroupTextId].ToString().Trim(); //小组Id
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objzx_ConceptVerEN.ConceptVId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objzx_ConceptVerEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clszx_ConceptVerEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clszx_ConceptVerEN> arrObjLst = new List<clszx_ConceptVerEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clszx_ConceptVerEN objzx_ConceptVerEN = new clszx_ConceptVerEN();
try
{
objzx_ConceptVerEN.ConceptVId = Int32.Parse(objRow[conzx_ConceptVer.ConceptVId].ToString().Trim()); //ConceptVId
objzx_ConceptVerEN.zxConceptId = objRow[conzx_ConceptVer.zxConceptId].ToString().Trim(); //概念Id
objzx_ConceptVerEN.ConceptName = objRow[conzx_ConceptVer.ConceptName] == DBNull.Value ? null : objRow[conzx_ConceptVer.ConceptName].ToString().Trim(); //概念名称
objzx_ConceptVerEN.ConceptContent = objRow[conzx_ConceptVer.ConceptContent] == DBNull.Value ? null : objRow[conzx_ConceptVer.ConceptContent].ToString().Trim(); //概念内容
objzx_ConceptVerEN.TextId = objRow[conzx_ConceptVer.TextId] == DBNull.Value ? null : objRow[conzx_ConceptVer.TextId].ToString().Trim(); //课件Id
objzx_ConceptVerEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[conzx_ConceptVer.IsSubmit].ToString().Trim()); //是否提交
objzx_ConceptVerEN.VoteCount = objRow[conzx_ConceptVer.VoteCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_ConceptVer.VoteCount].ToString().Trim()); //点赞计数
objzx_ConceptVerEN.AppraiseCount = objRow[conzx_ConceptVer.AppraiseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_ConceptVer.AppraiseCount].ToString().Trim()); //评论数
objzx_ConceptVerEN.Score = objRow[conzx_ConceptVer.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conzx_ConceptVer.Score].ToString().Trim()); //评分
objzx_ConceptVerEN.StuScore = objRow[conzx_ConceptVer.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conzx_ConceptVer.StuScore].ToString().Trim()); //学生平均分
objzx_ConceptVerEN.TeaScore = objRow[conzx_ConceptVer.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conzx_ConceptVer.TeaScore].ToString().Trim()); //教师评分
objzx_ConceptVerEN.CreateDate = objRow[conzx_ConceptVer.CreateDate] == DBNull.Value ? null : objRow[conzx_ConceptVer.CreateDate].ToString().Trim(); //建立日期
objzx_ConceptVerEN.UpdDate = objRow[conzx_ConceptVer.UpdDate] == DBNull.Value ? null : objRow[conzx_ConceptVer.UpdDate].ToString().Trim(); //修改日期
objzx_ConceptVerEN.UpdUser = objRow[conzx_ConceptVer.UpdUser] == DBNull.Value ? null : objRow[conzx_ConceptVer.UpdUser].ToString().Trim(); //修改人
objzx_ConceptVerEN.IdCurrEduCls = objRow[conzx_ConceptVer.IdCurrEduCls] == DBNull.Value ? null : objRow[conzx_ConceptVer.IdCurrEduCls].ToString().Trim(); //教学班流水号
objzx_ConceptVerEN.PdfContent = objRow[conzx_ConceptVer.PdfContent] == DBNull.Value ? null : objRow[conzx_ConceptVer.PdfContent].ToString().Trim(); //Pdf内容
objzx_ConceptVerEN.PdfPageNum = objRow[conzx_ConceptVer.PdfPageNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_ConceptVer.PdfPageNum].ToString().Trim()); //Pdf页码
objzx_ConceptVerEN.CitationCount = objRow[conzx_ConceptVer.CitationCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_ConceptVer.CitationCount].ToString().Trim()); //引用统计
objzx_ConceptVerEN.VersionCount = objRow[conzx_ConceptVer.VersionCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_ConceptVer.VersionCount].ToString().Trim()); //版本统计
objzx_ConceptVerEN.zxShareId = objRow[conzx_ConceptVer.zxShareId].ToString().Trim(); //分享Id
objzx_ConceptVerEN.Memo = objRow[conzx_ConceptVer.Memo] == DBNull.Value ? null : objRow[conzx_ConceptVer.Memo].ToString().Trim(); //备注
objzx_ConceptVerEN.PdfDivLet = objRow[conzx_ConceptVer.PdfDivLet] == DBNull.Value ? null : objRow[conzx_ConceptVer.PdfDivLet].ToString().Trim(); //PdfDivLet
objzx_ConceptVerEN.PdfDivTop = objRow[conzx_ConceptVer.PdfDivTop] == DBNull.Value ? null : objRow[conzx_ConceptVer.PdfDivTop].ToString().Trim(); //PdfDivTop
objzx_ConceptVerEN.PdfPageNumIn = objRow[conzx_ConceptVer.PdfPageNumIn] == DBNull.Value ? null : objRow[conzx_ConceptVer.PdfPageNumIn].ToString().Trim(); //PdfPageNumIn
objzx_ConceptVerEN.PdfPageTop = objRow[conzx_ConceptVer.PdfPageTop] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_ConceptVer.PdfPageTop].ToString().Trim()); //pdf页面顶部位置
objzx_ConceptVerEN.PdfZoom = objRow[conzx_ConceptVer.PdfZoom] == DBNull.Value ? null : objRow[conzx_ConceptVer.PdfZoom].ToString().Trim(); //PdfZoom
objzx_ConceptVerEN.GroupTextId = objRow[conzx_ConceptVer.GroupTextId] == DBNull.Value ? null : objRow[conzx_ConceptVer.GroupTextId].ToString().Trim(); //小组Id
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objzx_ConceptVerEN.ConceptVId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objzx_ConceptVerEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objzx_ConceptVerEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool Getzx_ConceptVer(ref clszx_ConceptVerEN objzx_ConceptVerEN)
{
bool bolResult = zx_ConceptVerDA.Getzx_ConceptVer(ref objzx_ConceptVerEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "lngConceptVId">表关键字</param>
 /// <returns>表对象</returns>
public static clszx_ConceptVerEN GetObjByConceptVId(long lngConceptVId)
{
clszx_ConceptVerEN objzx_ConceptVerEN = zx_ConceptVerDA.GetObjByConceptVId(lngConceptVId);
return objzx_ConceptVerEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clszx_ConceptVerEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clszx_ConceptVerEN objzx_ConceptVerEN = zx_ConceptVerDA.GetFirstObj(strWhereCond);
 return objzx_ConceptVerEN;
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
public static clszx_ConceptVerEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clszx_ConceptVerEN objzx_ConceptVerEN = zx_ConceptVerDA.GetObjByDataRow(objRow);
 return objzx_ConceptVerEN;
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
public static clszx_ConceptVerEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clszx_ConceptVerEN objzx_ConceptVerEN = zx_ConceptVerDA.GetObjByDataRow(objRow);
 return objzx_ConceptVerEN;
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
 /// <param name = "lngConceptVId">所给的关键字</param>
 /// <param name = "lstzx_ConceptVerObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clszx_ConceptVerEN GetObjByConceptVIdFromList(long lngConceptVId, List<clszx_ConceptVerEN> lstzx_ConceptVerObjLst)
{
foreach (clszx_ConceptVerEN objzx_ConceptVerEN in lstzx_ConceptVerObjLst)
{
if (objzx_ConceptVerEN.ConceptVId == lngConceptVId)
{
return objzx_ConceptVerEN;
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
 long lngConceptVId;
 try
 {
 lngConceptVId = new clszx_ConceptVerDA().GetFirstID(strWhereCond);
 return lngConceptVId;
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
 arrList = zx_ConceptVerDA.GetID(strWhereCond);
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
bool bolIsExist = zx_ConceptVerDA.IsExistCondRec(strWhereCond);
return bolIsExist;
}

 /// <summary>
 /// 判断当前表中是否存在给定关键字值的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExist)
 /// </summary>
 /// <param name = "lngConceptVId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public static bool IsExist(long lngConceptVId)
{
//检测记录是否存在
bool bolIsExist = zx_ConceptVerDA.IsExist(lngConceptVId);
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
 bolIsExist = clszx_ConceptVerDA.IsExistTable();
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
 bolIsExist = zx_ConceptVerDA.IsExistTable(strTabName);
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
 /// <param name = "objzx_ConceptVerEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecordBySql2(clszx_ConceptVerEN objzx_ConceptVerEN)
{
if (objzx_ConceptVerEN.CheckUniqueness() == false)
{
var strMsg = string.Format("记录已经存在!概念Id = [{0}],小组Id = [{1}]的数据已经存在!(in clszx_ConceptVerBL.AddNewRecordBySql2)", objzx_ConceptVerEN.zxConceptId,objzx_ConceptVerEN.GroupTextId);
throw new Exception(strMsg);
}
try
{
bool bolResult = zx_ConceptVerDA.AddNewRecordBySQL2(objzx_ConceptVerEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clszx_ConceptVerBL.ReFreshCache();

if (clszx_ConceptVerBL.relatedActions != null)
{
clszx_ConceptVerBL.relatedActions.UpdRelaTabDate(objzx_ConceptVerEN.ConceptVId, "SetUpdDate");
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
 /// <param name = "objzx_ConceptVerEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordBySql2WithReturnKey(clszx_ConceptVerEN objzx_ConceptVerEN)
{
if (objzx_ConceptVerEN.CheckUniqueness() == false)
{
var strMsg = string.Format("记录已经存在!概念Id = [{0}],小组Id = [{1}]的数据已经存在!(in clszx_ConceptVerBL.AddNewRecordBySql2WithReturnKey)", objzx_ConceptVerEN.zxConceptId,objzx_ConceptVerEN.GroupTextId);
throw new Exception(strMsg);
}
try
{
string strKey = zx_ConceptVerDA.AddNewRecordBySQL2WithReturnKey(objzx_ConceptVerEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clszx_ConceptVerBL.ReFreshCache();

if (clszx_ConceptVerBL.relatedActions != null)
{
clszx_ConceptVerBL.relatedActions.UpdRelaTabDate(objzx_ConceptVerEN.ConceptVId, "SetUpdDate");
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
 /// <param name = "objzx_ConceptVerEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(clszx_ConceptVerEN objzx_ConceptVerEN)
{
try
{
bool bolResult = zx_ConceptVerDA.Update(objzx_ConceptVerEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clszx_ConceptVerBL.ReFreshCache();

if (clszx_ConceptVerBL.relatedActions != null)
{
clszx_ConceptVerBL.relatedActions.UpdRelaTabDate(objzx_ConceptVerEN.ConceptVId, "SetUpdDate");
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
 /// <param name = "objzx_ConceptVerEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateBySql2(clszx_ConceptVerEN objzx_ConceptVerEN)
{
 if (objzx_ConceptVerEN.ConceptVId == 0)
 {
var strMsg = string.Format("(errid:Busi000065)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = zx_ConceptVerDA.UpdateBySql2(objzx_ConceptVerEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clszx_ConceptVerBL.ReFreshCache();

if (clszx_ConceptVerBL.relatedActions != null)
{
clszx_ConceptVerBL.relatedActions.UpdRelaTabDate(objzx_ConceptVerEN.ConceptVId, "SetUpdDate");
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
 /// <param name = "lngConceptVId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int DelRecord(long lngConceptVId)
{
try
{
 clszx_ConceptVerEN objzx_ConceptVerEN = clszx_ConceptVerBL.GetObjByConceptVId(lngConceptVId);

if (clszx_ConceptVerBL.relatedActions != null)
{
clszx_ConceptVerBL.relatedActions.UpdRelaTabDate(objzx_ConceptVerEN.ConceptVId, "SetUpdDate");
}
if (objzx_ConceptVerEN != null)
{
int intRecNum = zx_ConceptVerDA.DelRecord(lngConceptVId);
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
/// <param name="lngConceptVId">表关键字</param>
/// <returns></returns>
public static bool DelRecordEx(long lngConceptVId )
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clszx_ConceptVerDA.GetSpecSQLObj();
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
//删除与表:[zx_ConceptVer]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conzx_ConceptVer.ConceptVId,
//lngConceptVId);
//        clszx_ConceptVerBL.Delzx_ConceptVersByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clszx_ConceptVerBL.DelRecord(lngConceptVId, objConnection, objSqlTransaction);
objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clszx_ConceptVerBLEx", "DelRecordEx", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("扩展删除记录出错:{0}!keyId = {1}.({2})",
objException.Message,
lngConceptVId, clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "lngConceptVId">给定的关键字值</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回删除是否成功?</returns>
public static bool DelRecord(long lngConceptVId, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
if (clszx_ConceptVerBL.relatedActions != null)
{
clszx_ConceptVerBL.relatedActions.UpdRelaTabDate(lngConceptVId, "UpdRelaTabDate");
}
bool bolResult = zx_ConceptVerDA.DelRecord(lngConceptVId,objSqlConnection,objSqlTransaction);
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
 /// <param name = "arrConceptVIdLst">给定的关键字值列表</param>
 /// <returns>返回删除的记录数</returns>
public static int Delzx_ConceptVers(List<string> arrConceptVIdLst)
{
if (arrConceptVIdLst.Count == 0) return 0;
try
{
if (clszx_ConceptVerBL.relatedActions != null)
{
foreach (var strConceptVId in arrConceptVIdLst)
{
long lngConceptVId = long.Parse(strConceptVId);
clszx_ConceptVerBL.relatedActions.UpdRelaTabDate(lngConceptVId, "UpdRelaTabDate");
}
}
int intDelRecNum = zx_ConceptVerDA.Delzx_ConceptVer(arrConceptVIdLst);
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
public static int Delzx_ConceptVersByCond(string strWhereCond)
{
try
{
if (clszx_ConceptVerBL.relatedActions != null)
{
List<string> arrConceptVId = GetPrimaryKeyID_S(strWhereCond);
foreach (var strConceptVId in arrConceptVId)
{
long lngConceptVId = long.Parse(strConceptVId);
clszx_ConceptVerBL.relatedActions.UpdRelaTabDate(lngConceptVId, "UpdRelaTabDate");
}
}
int intRecNum = zx_ConceptVerDA.Delzx_ConceptVer(strWhereCond);
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
/// 这里仅仅是演示函数,使用时请复制到扩展类:[zx_ConceptVer]中改名为:[DelRecord4MultiTabEx]使用
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DelRecord4MultiTab)
/// </summary>
/// <param name="lngConceptVId">表关键字</param>
/// <returns></returns>
public static bool DelRecord4MultiTab(long lngConceptVId)
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clszx_ConceptVerDA.GetSpecSQLObj();
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
//删除与表:[zx_ConceptVer]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conStudent.id_College,
//strid_College);
//        clsStudentBL.DelStudentsByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clszx_ConceptVerBL.DelRecord(lngConceptVId, objConnection, objSqlTransaction);
                objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clszx_ConceptVerBL", "DelRecord4MultiTab", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("删除多表记录出错:{0}!keyId = {1}.({2})",
objException.Message,
lngConceptVId, clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "objzx_ConceptVerENS">源对象</param>
 /// <param name = "objzx_ConceptVerENT">目标对象</param>
 public static void CopyTo(clszx_ConceptVerEN objzx_ConceptVerENS, clszx_ConceptVerEN objzx_ConceptVerENT)
{
try
{
objzx_ConceptVerENT.ConceptVId = objzx_ConceptVerENS.ConceptVId; //ConceptVId
objzx_ConceptVerENT.zxConceptId = objzx_ConceptVerENS.zxConceptId; //概念Id
objzx_ConceptVerENT.ConceptName = objzx_ConceptVerENS.ConceptName; //概念名称
objzx_ConceptVerENT.ConceptContent = objzx_ConceptVerENS.ConceptContent; //概念内容
objzx_ConceptVerENT.TextId = objzx_ConceptVerENS.TextId; //课件Id
objzx_ConceptVerENT.IsSubmit = objzx_ConceptVerENS.IsSubmit; //是否提交
objzx_ConceptVerENT.VoteCount = objzx_ConceptVerENS.VoteCount; //点赞计数
objzx_ConceptVerENT.AppraiseCount = objzx_ConceptVerENS.AppraiseCount; //评论数
objzx_ConceptVerENT.Score = objzx_ConceptVerENS.Score; //评分
objzx_ConceptVerENT.StuScore = objzx_ConceptVerENS.StuScore; //学生平均分
objzx_ConceptVerENT.TeaScore = objzx_ConceptVerENS.TeaScore; //教师评分
objzx_ConceptVerENT.CreateDate = objzx_ConceptVerENS.CreateDate; //建立日期
objzx_ConceptVerENT.UpdDate = objzx_ConceptVerENS.UpdDate; //修改日期
objzx_ConceptVerENT.UpdUser = objzx_ConceptVerENS.UpdUser; //修改人
objzx_ConceptVerENT.IdCurrEduCls = objzx_ConceptVerENS.IdCurrEduCls; //教学班流水号
objzx_ConceptVerENT.PdfContent = objzx_ConceptVerENS.PdfContent; //Pdf内容
objzx_ConceptVerENT.PdfPageNum = objzx_ConceptVerENS.PdfPageNum; //Pdf页码
objzx_ConceptVerENT.CitationCount = objzx_ConceptVerENS.CitationCount; //引用统计
objzx_ConceptVerENT.VersionCount = objzx_ConceptVerENS.VersionCount; //版本统计
objzx_ConceptVerENT.zxShareId = objzx_ConceptVerENS.zxShareId; //分享Id
objzx_ConceptVerENT.Memo = objzx_ConceptVerENS.Memo; //备注
objzx_ConceptVerENT.PdfDivLet = objzx_ConceptVerENS.PdfDivLet; //PdfDivLet
objzx_ConceptVerENT.PdfDivTop = objzx_ConceptVerENS.PdfDivTop; //PdfDivTop
objzx_ConceptVerENT.PdfPageNumIn = objzx_ConceptVerENS.PdfPageNumIn; //PdfPageNumIn
objzx_ConceptVerENT.PdfPageTop = objzx_ConceptVerENS.PdfPageTop; //pdf页面顶部位置
objzx_ConceptVerENT.PdfZoom = objzx_ConceptVerENS.PdfZoom; //PdfZoom
objzx_ConceptVerENT.GroupTextId = objzx_ConceptVerENS.GroupTextId; //小组Id
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
 /// <param name = "objzx_ConceptVerEN">源简化对象</param>
 public static void SetUpdFlag(clszx_ConceptVerEN objzx_ConceptVerEN)
{
try
{
objzx_ConceptVerEN.ClearUpdateState();
   string strsfUpdFldSetStr = objzx_ConceptVerEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(conzx_ConceptVer.ConceptVId, new clsStrCompareIgnoreCase())  ==  true)
{
objzx_ConceptVerEN.ConceptVId = objzx_ConceptVerEN.ConceptVId; //ConceptVId
}
if (arrFldSet.Contains(conzx_ConceptVer.zxConceptId, new clsStrCompareIgnoreCase())  ==  true)
{
objzx_ConceptVerEN.zxConceptId = objzx_ConceptVerEN.zxConceptId; //概念Id
}
if (arrFldSet.Contains(conzx_ConceptVer.ConceptName, new clsStrCompareIgnoreCase())  ==  true)
{
objzx_ConceptVerEN.ConceptName = objzx_ConceptVerEN.ConceptName == "[null]" ? null :  objzx_ConceptVerEN.ConceptName; //概念名称
}
if (arrFldSet.Contains(conzx_ConceptVer.ConceptContent, new clsStrCompareIgnoreCase())  ==  true)
{
objzx_ConceptVerEN.ConceptContent = objzx_ConceptVerEN.ConceptContent == "[null]" ? null :  objzx_ConceptVerEN.ConceptContent; //概念内容
}
if (arrFldSet.Contains(conzx_ConceptVer.TextId, new clsStrCompareIgnoreCase())  ==  true)
{
objzx_ConceptVerEN.TextId = objzx_ConceptVerEN.TextId == "[null]" ? null :  objzx_ConceptVerEN.TextId; //课件Id
}
if (arrFldSet.Contains(conzx_ConceptVer.IsSubmit, new clsStrCompareIgnoreCase())  ==  true)
{
objzx_ConceptVerEN.IsSubmit = objzx_ConceptVerEN.IsSubmit; //是否提交
}
if (arrFldSet.Contains(conzx_ConceptVer.VoteCount, new clsStrCompareIgnoreCase())  ==  true)
{
objzx_ConceptVerEN.VoteCount = objzx_ConceptVerEN.VoteCount; //点赞计数
}
if (arrFldSet.Contains(conzx_ConceptVer.AppraiseCount, new clsStrCompareIgnoreCase())  ==  true)
{
objzx_ConceptVerEN.AppraiseCount = objzx_ConceptVerEN.AppraiseCount; //评论数
}
if (arrFldSet.Contains(conzx_ConceptVer.Score, new clsStrCompareIgnoreCase())  ==  true)
{
objzx_ConceptVerEN.Score = objzx_ConceptVerEN.Score; //评分
}
if (arrFldSet.Contains(conzx_ConceptVer.StuScore, new clsStrCompareIgnoreCase())  ==  true)
{
objzx_ConceptVerEN.StuScore = objzx_ConceptVerEN.StuScore; //学生平均分
}
if (arrFldSet.Contains(conzx_ConceptVer.TeaScore, new clsStrCompareIgnoreCase())  ==  true)
{
objzx_ConceptVerEN.TeaScore = objzx_ConceptVerEN.TeaScore; //教师评分
}
if (arrFldSet.Contains(conzx_ConceptVer.CreateDate, new clsStrCompareIgnoreCase())  ==  true)
{
objzx_ConceptVerEN.CreateDate = objzx_ConceptVerEN.CreateDate == "[null]" ? null :  objzx_ConceptVerEN.CreateDate; //建立日期
}
if (arrFldSet.Contains(conzx_ConceptVer.UpdDate, new clsStrCompareIgnoreCase())  ==  true)
{
objzx_ConceptVerEN.UpdDate = objzx_ConceptVerEN.UpdDate == "[null]" ? null :  objzx_ConceptVerEN.UpdDate; //修改日期
}
if (arrFldSet.Contains(conzx_ConceptVer.UpdUser, new clsStrCompareIgnoreCase())  ==  true)
{
objzx_ConceptVerEN.UpdUser = objzx_ConceptVerEN.UpdUser == "[null]" ? null :  objzx_ConceptVerEN.UpdUser; //修改人
}
if (arrFldSet.Contains(conzx_ConceptVer.IdCurrEduCls, new clsStrCompareIgnoreCase())  ==  true)
{
objzx_ConceptVerEN.IdCurrEduCls = objzx_ConceptVerEN.IdCurrEduCls == "[null]" ? null :  objzx_ConceptVerEN.IdCurrEduCls; //教学班流水号
}
if (arrFldSet.Contains(conzx_ConceptVer.PdfContent, new clsStrCompareIgnoreCase())  ==  true)
{
objzx_ConceptVerEN.PdfContent = objzx_ConceptVerEN.PdfContent == "[null]" ? null :  objzx_ConceptVerEN.PdfContent; //Pdf内容
}
if (arrFldSet.Contains(conzx_ConceptVer.PdfPageNum, new clsStrCompareIgnoreCase())  ==  true)
{
objzx_ConceptVerEN.PdfPageNum = objzx_ConceptVerEN.PdfPageNum; //Pdf页码
}
if (arrFldSet.Contains(conzx_ConceptVer.CitationCount, new clsStrCompareIgnoreCase())  ==  true)
{
objzx_ConceptVerEN.CitationCount = objzx_ConceptVerEN.CitationCount; //引用统计
}
if (arrFldSet.Contains(conzx_ConceptVer.VersionCount, new clsStrCompareIgnoreCase())  ==  true)
{
objzx_ConceptVerEN.VersionCount = objzx_ConceptVerEN.VersionCount; //版本统计
}
if (arrFldSet.Contains(conzx_ConceptVer.zxShareId, new clsStrCompareIgnoreCase())  ==  true)
{
objzx_ConceptVerEN.zxShareId = objzx_ConceptVerEN.zxShareId; //分享Id
}
if (arrFldSet.Contains(conzx_ConceptVer.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objzx_ConceptVerEN.Memo = objzx_ConceptVerEN.Memo == "[null]" ? null :  objzx_ConceptVerEN.Memo; //备注
}
if (arrFldSet.Contains(conzx_ConceptVer.PdfDivLet, new clsStrCompareIgnoreCase())  ==  true)
{
objzx_ConceptVerEN.PdfDivLet = objzx_ConceptVerEN.PdfDivLet == "[null]" ? null :  objzx_ConceptVerEN.PdfDivLet; //PdfDivLet
}
if (arrFldSet.Contains(conzx_ConceptVer.PdfDivTop, new clsStrCompareIgnoreCase())  ==  true)
{
objzx_ConceptVerEN.PdfDivTop = objzx_ConceptVerEN.PdfDivTop == "[null]" ? null :  objzx_ConceptVerEN.PdfDivTop; //PdfDivTop
}
if (arrFldSet.Contains(conzx_ConceptVer.PdfPageNumIn, new clsStrCompareIgnoreCase())  ==  true)
{
objzx_ConceptVerEN.PdfPageNumIn = objzx_ConceptVerEN.PdfPageNumIn == "[null]" ? null :  objzx_ConceptVerEN.PdfPageNumIn; //PdfPageNumIn
}
if (arrFldSet.Contains(conzx_ConceptVer.PdfPageTop, new clsStrCompareIgnoreCase())  ==  true)
{
objzx_ConceptVerEN.PdfPageTop = objzx_ConceptVerEN.PdfPageTop; //pdf页面顶部位置
}
if (arrFldSet.Contains(conzx_ConceptVer.PdfZoom, new clsStrCompareIgnoreCase())  ==  true)
{
objzx_ConceptVerEN.PdfZoom = objzx_ConceptVerEN.PdfZoom == "[null]" ? null :  objzx_ConceptVerEN.PdfZoom; //PdfZoom
}
if (arrFldSet.Contains(conzx_ConceptVer.GroupTextId, new clsStrCompareIgnoreCase())  ==  true)
{
objzx_ConceptVerEN.GroupTextId = objzx_ConceptVerEN.GroupTextId == "[null]" ? null :  objzx_ConceptVerEN.GroupTextId; //小组Id
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
 /// <param name = "objzx_ConceptVerEN">源简化对象</param>
 public static void AccessFldValueNull(clszx_ConceptVerEN objzx_ConceptVerEN)
{
try
{
if (objzx_ConceptVerEN.ConceptName == "[null]") objzx_ConceptVerEN.ConceptName = null; //概念名称
if (objzx_ConceptVerEN.ConceptContent == "[null]") objzx_ConceptVerEN.ConceptContent = null; //概念内容
if (objzx_ConceptVerEN.TextId == "[null]") objzx_ConceptVerEN.TextId = null; //课件Id
if (objzx_ConceptVerEN.CreateDate == "[null]") objzx_ConceptVerEN.CreateDate = null; //建立日期
if (objzx_ConceptVerEN.UpdDate == "[null]") objzx_ConceptVerEN.UpdDate = null; //修改日期
if (objzx_ConceptVerEN.UpdUser == "[null]") objzx_ConceptVerEN.UpdUser = null; //修改人
if (objzx_ConceptVerEN.IdCurrEduCls == "[null]") objzx_ConceptVerEN.IdCurrEduCls = null; //教学班流水号
if (objzx_ConceptVerEN.PdfContent == "[null]") objzx_ConceptVerEN.PdfContent = null; //Pdf内容
if (objzx_ConceptVerEN.Memo == "[null]") objzx_ConceptVerEN.Memo = null; //备注
if (objzx_ConceptVerEN.PdfDivLet == "[null]") objzx_ConceptVerEN.PdfDivLet = null; //PdfDivLet
if (objzx_ConceptVerEN.PdfDivTop == "[null]") objzx_ConceptVerEN.PdfDivTop = null; //PdfDivTop
if (objzx_ConceptVerEN.PdfPageNumIn == "[null]") objzx_ConceptVerEN.PdfPageNumIn = null; //PdfPageNumIn
if (objzx_ConceptVerEN.PdfZoom == "[null]") objzx_ConceptVerEN.PdfZoom = null; //PdfZoom
if (objzx_ConceptVerEN.GroupTextId == "[null]") objzx_ConceptVerEN.GroupTextId = null; //小组Id
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
public static void CheckPropertyNew(clszx_ConceptVerEN objzx_ConceptVerEN)
{
 zx_ConceptVerDA.CheckPropertyNew(objzx_ConceptVerEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(clszx_ConceptVerEN objzx_ConceptVerEN)
{
 zx_ConceptVerDA.CheckProperty4Condition(objzx_ConceptVerEN);
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
if (clszx_ConceptVerBL.objCommFun4BL == null)
{
strMsg = string.Format("类clszx_ConceptVerBL没有刷新缓存机制(clszx_ConceptVerBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by ConceptVId");
//if (arrzx_ConceptVerObjLstCache == null)
//{
//arrzx_ConceptVerObjLstCache = zx_ConceptVerDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "lngConceptVId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clszx_ConceptVerEN GetObjByConceptVIdCache(long lngConceptVId)
{
//获取缓存中的对象列表
string strKey = string.Format("{0}", clszx_ConceptVerEN._CurrTabName);
List<clszx_ConceptVerEN> arrzx_ConceptVerObjLstCache = GetObjLstCache();
IEnumerable <clszx_ConceptVerEN> arrzx_ConceptVerObjLst_Sel =
arrzx_ConceptVerObjLstCache
.Where(x=> x.ConceptVId == lngConceptVId 
);
if (arrzx_ConceptVerObjLst_Sel.Count() == 0)
{
   clszx_ConceptVerEN obj = clszx_ConceptVerBL.GetObjByConceptVId(lngConceptVId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
 }
return null;
}
return arrzx_ConceptVerObjLst_Sel.First();
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clszx_ConceptVerEN> GetAllzx_ConceptVerObjLstCache()
{
//获取缓存中的对象列表
List<clszx_ConceptVerEN> arrzx_ConceptVerObjLstCache = GetObjLstCache(); 
return arrzx_ConceptVerObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clszx_ConceptVerEN> GetObjLstCache()
{
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}", clszx_ConceptVerEN._CurrTabName);
List<clszx_ConceptVerEN> arrzx_ConceptVerObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrzx_ConceptVerObjLstCache;
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
string strKey = string.Format("{0}", clszx_ConceptVerEN._CurrTabName);
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
if (clszx_ConceptVerBL.objCommFun4BL != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}", clszx_ConceptVerEN._CurrTabName);
CacheHelper.Remove(strKey);
clszx_ConceptVerBL.objCommFun4BL.ReFreshCache();
}
}


 #endregion 缓存操作


 #region 检查唯一性

 /// <summary>
 /// 获取检查唯一性条件串(Uniqueness)--zx_ConceptVer(概念版本)
 /// 唯一性条件:zxConceptId_GroupTextId
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetUniquenessConditionString)
 /// </summary>
 /// <param name = "objzx_ConceptVerEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(clszx_ConceptVerEN objzx_ConceptVerEN)
{
//检测记录是否存在
string strResult = zx_ConceptVerDA.GetUniCondStr(objzx_ConceptVerEN);
return strResult;
}


 #endregion 检查唯一性

 /// <summary>
 /// 映射函数。根据表映射把输入字段值,映射成输出字段值
 /// 作者:pyf
 /// 日期:2023-11-15
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_func)
 /// </summary>
 /// <param name = "strInFldName">输入字段名</param>
 /// <param name = "strOutFldName">输出字段名</param>
 /// <param name = "strInValue">输入字段值</param>
 /// <returns>返回一个输出字段值</returns>
public static string Func(string strInFldName, string strOutFldName, long lngConceptVId)
{
if (strInFldName != conzx_ConceptVer.ConceptVId)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (conzx_ConceptVer.AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", conzx_ConceptVer.AttributeName));
throw new Exception(strMsg);
}
var objzx_ConceptVer = clszx_ConceptVerBL.GetObjByConceptVIdCache(lngConceptVId);
if (objzx_ConceptVer == null) return "";
return objzx_ConceptVer[strOutFldName].ToString();
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
int intRecCount = clszx_ConceptVerDA.GetRecCount(strTabName);
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
int intRecCount = clszx_ConceptVerDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clszx_ConceptVerDA.GetRecCount();
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
int intRecCount = clszx_ConceptVerDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objzx_ConceptVerCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clszx_ConceptVerEN objzx_ConceptVerCond)
{
List<clszx_ConceptVerEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clszx_ConceptVerEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conzx_ConceptVer.AttributeName)
{
if (objzx_ConceptVerCond.IsUpdated(strFldName) == false) continue;
if (objzx_ConceptVerCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objzx_ConceptVerCond[strFldName].ToString());
}
else
{
if (objzx_ConceptVerCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objzx_ConceptVerCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objzx_ConceptVerCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objzx_ConceptVerCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objzx_ConceptVerCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objzx_ConceptVerCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objzx_ConceptVerCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objzx_ConceptVerCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objzx_ConceptVerCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objzx_ConceptVerCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objzx_ConceptVerCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objzx_ConceptVerCond[strFldName]));
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
 List<string> arrList = clszx_ConceptVerDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = zx_ConceptVerDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = zx_ConceptVerDA.GetFldValueNoDistinct(strFldName, strWhereCond);
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
int intRecCount = zx_ConceptVerDA.SetFldValue(strFldName, strValue, strWhereCond);
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
int intRecCount = clszx_ConceptVerDA.SetFldValue(clszx_ConceptVerEN._CurrTabName, strFldName, fltValue, strWhereCond);
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
int intRecCount = zx_ConceptVerDA.SetFldValue( strFldName, intValue, strWhereCond);
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
int intRecCount = clszx_ConceptVerDA.SetFldValue(strTabName, strFldName, strValue, strWhereCond);
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
int intRecCount = clszx_ConceptVerDA.SetFldValue(strTabName, strFldName, intValue, strWhereCond);
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
int intRecCount = clszx_ConceptVerDA.SetFldValue(strTabName, strFldName, fltValue, strWhereCond);
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
  strCreateTabCode.Append("CREATE table [dbo].[zx_ConceptVer] "); 
 strCreateTabCode.Append(" ( "); 
 // /**ConceptVId*/ 
 strCreateTabCode.Append(" ConceptVId bigint primary key identity, "); 
 // /**概念Id*/ 
 strCreateTabCode.Append(" zxConceptId char(8) not Null, "); 
 // /**概念名称*/ 
 strCreateTabCode.Append(" ConceptName varchar(500) Null, "); 
 // /**概念内容*/ 
 strCreateTabCode.Append(" ConceptContent text Null, "); 
 // /**课件Id*/ 
 strCreateTabCode.Append(" TextId char(8) Null, "); 
 // /**是否提交*/ 
 strCreateTabCode.Append(" IsSubmit bit Null, "); 
 // /**点赞计数*/ 
 strCreateTabCode.Append(" VoteCount int Null, "); 
 // /**评论数*/ 
 strCreateTabCode.Append(" AppraiseCount int Null, "); 
 // /**评分*/ 
 strCreateTabCode.Append(" Score float Null, "); 
 // /**学生平均分*/ 
 strCreateTabCode.Append(" StuScore float Null, "); 
 // /**教师评分*/ 
 strCreateTabCode.Append(" TeaScore float Null, "); 
 // /**建立日期*/ 
 strCreateTabCode.Append(" CreateDate varchar(20) Null, "); 
 // /**修改日期*/ 
 strCreateTabCode.Append(" UpdDate varchar(20) Null, "); 
 // /**修改人*/ 
 strCreateTabCode.Append(" UpdUser varchar(20) Null, "); 
 // /**教学班流水号*/ 
 strCreateTabCode.Append(" IdCurrEduCls char(8) Null, "); 
 // /**Pdf内容*/ 
 strCreateTabCode.Append(" PdfContent varchar(2000) Null, "); 
 // /**Pdf页码*/ 
 strCreateTabCode.Append(" PdfPageNum int Null, "); 
 // /**引用统计*/ 
 strCreateTabCode.Append(" CitationCount int Null, "); 
 // /**版本统计*/ 
 strCreateTabCode.Append(" VersionCount int Null, "); 
 // /**分享Id*/ 
 strCreateTabCode.Append(" zxShareId char(2) not Null, "); 
 // /**备注*/ 
 strCreateTabCode.Append(" Memo varchar(1000) Null, "); 
 // /**PdfDivLet*/ 
 strCreateTabCode.Append(" PdfDivLet varchar(50) Null, "); 
 // /**PdfDivTop*/ 
 strCreateTabCode.Append(" PdfDivTop varchar(50) Null, "); 
 // /**PdfPageNumIn*/ 
 strCreateTabCode.Append(" PdfPageNumIn varchar(50) Null, "); 
 // /**pdf页面顶部位置*/ 
 strCreateTabCode.Append(" PdfPageTop int Null, "); 
 // /**PdfZoom*/ 
 strCreateTabCode.Append(" PdfZoom varchar(50) Null, "); 
 // /**小组Id*/ 
 strCreateTabCode.Append(" GroupTextId char(8) Null ");
 strCreateTabCode.Append(") "); 
  strCreateTabCode.Append("ON [PRIMARY] ");
  return strCreateTabCode.ToString();
}



 #endregion 表操作
}
 /// <summary>
 /// 概念版本(zx_ConceptVer)
 /// 数据源类型:表
 /// (AutoGCLib.CommFun4BL4CSharp:GeneCode_This)
 /// </summary>
public class  clsCommFun4BL4zx_ConceptVer : clsCommFun4BL
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
clszx_ConceptVerBL.ReFreshThisCache();
}
}

}