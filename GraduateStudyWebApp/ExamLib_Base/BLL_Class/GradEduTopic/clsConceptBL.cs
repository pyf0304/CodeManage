
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsConceptBL
 表名:Concept(01120602)
 * 版本:2024.11.13.1(服务器:WIN-SRV103-116)
 日期:2024/11/13 06:07:16
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:研究生学习游戏化后台(000055, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:研培主题(GradEduTopic)
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
public static class  clsConceptBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "strConceptId">表关键字</param>
 /// <returns>表对象</returns>
public static clsConceptEN GetObj(this K_ConceptId_Concept myKey)
{
clsConceptEN objConceptEN = clsConceptBL.ConceptDA.GetObjByConceptId(myKey.Value);
return objConceptEN;
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_AddNewRecord)
 /// </summary>
 /// <param name = "objConceptEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clsConceptEN objConceptEN, bool bolIsNeedCheckUniqueness = true)
{
if (bolIsNeedCheckUniqueness == true && CheckUniqueness(objConceptEN) == false)
{
var strMsg = string.Format("记录已经存在!教学班流水号 = [{0}],概念名称 = [{1}]的数据已经存在!(in clsConceptBL.AddNewRecord)", objConceptEN.IdCurrEduCls,objConceptEN.ConceptName);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objConceptEN.ConceptId) == true || clsConceptBL.IsExist(objConceptEN.ConceptId) == true)
 {
     objConceptEN.ConceptId = clsConceptBL.GetMaxStrId_S();
 }
bool bolResult = clsConceptBL.ConceptDA.AddNewRecordBySQL2(objConceptEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsConceptBL.ReFreshCache(objConceptEN.IdCurrEduCls);

if (clsConceptBL.relatedActions != null)
{
clsConceptBL.relatedActions.UpdRelaTabDate(objConceptEN.ConceptId, "SetUpdDate");
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
public static bool AddRecordEx(this clsConceptEN objConceptEN, bool bolIsNeedCheckUniqueness = true)
{
//操作步骤:
//1、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在
//2、检查唯一性
//3、检查传进去的对象属性是否合法
//4、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
//1、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在

//因为是字符型自增主键,不需要检查主键是否已经存在,在添加时,再获取 最大值作为主键
//if (clsConceptBL.IsExist(objConceptEN.ConceptId))	//判断是否有相同的关键字
//{
//strMsg = "(errid:Busi000151)关键字字段已有相同的值";
//throw new Exception(strMsg);
//}
try
{
 //2、检查传进去的对象属性是否合法
objConceptEN.CheckPropertyNew();
 ///5.2、检查唯一性
if (bolIsNeedCheckUniqueness == true && objConceptEN.CheckUniqueness() == false)
{
strMsg = string.Format("(教学班流水号(IdCurrEduCls)=[{0}],概念名称(ConceptName)=[{1}])已经存在,不能重复!", objConceptEN.IdCurrEduCls, objConceptEN.ConceptName);
throw new Exception(strMsg);
}
//因为是字符型自增主键,所以在添加时,自动获取主键值。
 if (string.IsNullOrEmpty(objConceptEN.ConceptId) == true || clsConceptBL.IsExist(objConceptEN.ConceptId) == true)
 {
     objConceptEN.ConceptId = clsConceptBL.GetMaxStrId_S();
 }
//6、把数据实体层的数据存贮到数据库中
objConceptEN.AddNewRecord();
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
 /// <param name = "objConceptEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static string AddNewRecordWithMaxId(this clsConceptEN objConceptEN, bool bolIsNeedCheckUniqueness = true)
{
if (bolIsNeedCheckUniqueness == true && CheckUniqueness(objConceptEN) == false)
{
var strMsg = string.Format("记录已经存在!教学班流水号 = [{0}],概念名称 = [{1}]的数据已经存在!(in clsConceptBL.AddNewRecordWithMaxId)", objConceptEN.IdCurrEduCls,objConceptEN.ConceptName);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objConceptEN.ConceptId) == true || clsConceptBL.IsExist(objConceptEN.ConceptId) == true)
 {
     objConceptEN.ConceptId = clsConceptBL.GetMaxStrId_S();
 }
string strConceptId = clsConceptBL.ConceptDA.AddNewRecordBySQL2WithReturnKey(objConceptEN);
     objConceptEN.ConceptId = strConceptId;
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsConceptBL.ReFreshCache(objConceptEN.IdCurrEduCls);

if (clsConceptBL.relatedActions != null)
{
clsConceptBL.relatedActions.UpdRelaTabDate(objConceptEN.ConceptId, "SetUpdDate");
}
return strConceptId;
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
 /// <param name = "objConceptEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordWithReturnKey(this clsConceptEN objConceptEN, bool bolIsNeedCheckUniqueness = true)
{
if (bolIsNeedCheckUniqueness == true && CheckUniqueness(objConceptEN) == false)
{
var strMsg = string.Format("记录已经存在!教学班流水号 = [{0}],概念名称 = [{1}]的数据已经存在!(in clsConceptBL.AddNewRecordWithReturnKey)", objConceptEN.IdCurrEduCls,objConceptEN.ConceptName);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objConceptEN.ConceptId) == true || clsConceptBL.IsExist(objConceptEN.ConceptId) == true)
 {
     objConceptEN.ConceptId = clsConceptBL.GetMaxStrId_S();
 }
string strKey = clsConceptBL.ConceptDA.AddNewRecordBySQL2WithReturnKey(objConceptEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsConceptBL.ReFreshCache(objConceptEN.IdCurrEduCls);

if (clsConceptBL.relatedActions != null)
{
clsConceptBL.relatedActions.UpdRelaTabDate(objConceptEN.ConceptId, "SetUpdDate");
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
 /// <param name = "objConceptEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsConceptEN SetConceptId(this clsConceptEN objConceptEN, string strConceptId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strConceptId, 8, conConcept.ConceptId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strConceptId, 8, conConcept.ConceptId);
}
objConceptEN.ConceptId = strConceptId; //概念Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objConceptEN.dicFldComparisonOp.ContainsKey(conConcept.ConceptId) == false)
{
objConceptEN.dicFldComparisonOp.Add(conConcept.ConceptId, strComparisonOp);
}
else
{
objConceptEN.dicFldComparisonOp[conConcept.ConceptId] = strComparisonOp;
}
}
return objConceptEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objConceptEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsConceptEN SetConceptName(this clsConceptEN objConceptEN, string strConceptName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strConceptName, 500, conConcept.ConceptName);
}
objConceptEN.ConceptName = strConceptName; //概念名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objConceptEN.dicFldComparisonOp.ContainsKey(conConcept.ConceptName) == false)
{
objConceptEN.dicFldComparisonOp.Add(conConcept.ConceptName, strComparisonOp);
}
else
{
objConceptEN.dicFldComparisonOp[conConcept.ConceptName] = strComparisonOp;
}
}
return objConceptEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objConceptEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsConceptEN SetConceptContent(this clsConceptEN objConceptEN, string strConceptContent, string strComparisonOp="")
	{
objConceptEN.ConceptContent = strConceptContent; //概念内容
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objConceptEN.dicFldComparisonOp.ContainsKey(conConcept.ConceptContent) == false)
{
objConceptEN.dicFldComparisonOp.Add(conConcept.ConceptContent, strComparisonOp);
}
else
{
objConceptEN.dicFldComparisonOp[conConcept.ConceptContent] = strComparisonOp;
}
}
return objConceptEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objConceptEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsConceptEN SetIsSubmit(this clsConceptEN objConceptEN, bool bolIsSubmit, string strComparisonOp="")
	{
objConceptEN.IsSubmit = bolIsSubmit; //是否提交
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objConceptEN.dicFldComparisonOp.ContainsKey(conConcept.IsSubmit) == false)
{
objConceptEN.dicFldComparisonOp.Add(conConcept.IsSubmit, strComparisonOp);
}
else
{
objConceptEN.dicFldComparisonOp[conConcept.IsSubmit] = strComparisonOp;
}
}
return objConceptEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objConceptEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsConceptEN SetUpdDate(this clsConceptEN objConceptEN, string strUpdDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdDate, 20, conConcept.UpdDate);
}
objConceptEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objConceptEN.dicFldComparisonOp.ContainsKey(conConcept.UpdDate) == false)
{
objConceptEN.dicFldComparisonOp.Add(conConcept.UpdDate, strComparisonOp);
}
else
{
objConceptEN.dicFldComparisonOp[conConcept.UpdDate] = strComparisonOp;
}
}
return objConceptEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objConceptEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsConceptEN SetMemo(this clsConceptEN objConceptEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, conConcept.Memo);
}
objConceptEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objConceptEN.dicFldComparisonOp.ContainsKey(conConcept.Memo) == false)
{
objConceptEN.dicFldComparisonOp.Add(conConcept.Memo, strComparisonOp);
}
else
{
objConceptEN.dicFldComparisonOp[conConcept.Memo] = strComparisonOp;
}
}
return objConceptEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objConceptEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsConceptEN SetCitationId(this clsConceptEN objConceptEN, string strCitationId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCitationId, 8, conConcept.CitationId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strCitationId, 8, conConcept.CitationId);
}
objConceptEN.CitationId = strCitationId; //引用Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objConceptEN.dicFldComparisonOp.ContainsKey(conConcept.CitationId) == false)
{
objConceptEN.dicFldComparisonOp.Add(conConcept.CitationId, strComparisonOp);
}
else
{
objConceptEN.dicFldComparisonOp[conConcept.CitationId] = strComparisonOp;
}
}
return objConceptEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objConceptEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsConceptEN SetAppraiseCount(this clsConceptEN objConceptEN, int? intAppraiseCount, string strComparisonOp="")
	{
objConceptEN.AppraiseCount = intAppraiseCount; //评论数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objConceptEN.dicFldComparisonOp.ContainsKey(conConcept.AppraiseCount) == false)
{
objConceptEN.dicFldComparisonOp.Add(conConcept.AppraiseCount, strComparisonOp);
}
else
{
objConceptEN.dicFldComparisonOp[conConcept.AppraiseCount] = strComparisonOp;
}
}
return objConceptEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objConceptEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsConceptEN SetOkCount(this clsConceptEN objConceptEN, int? intOkCount, string strComparisonOp="")
	{
objConceptEN.OkCount = intOkCount; //点赞统计
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objConceptEN.dicFldComparisonOp.ContainsKey(conConcept.OkCount) == false)
{
objConceptEN.dicFldComparisonOp.Add(conConcept.OkCount, strComparisonOp);
}
else
{
objConceptEN.dicFldComparisonOp[conConcept.OkCount] = strComparisonOp;
}
}
return objConceptEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objConceptEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsConceptEN SetScore(this clsConceptEN objConceptEN, float? fltScore, string strComparisonOp="")
	{
objConceptEN.Score = fltScore; //评分
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objConceptEN.dicFldComparisonOp.ContainsKey(conConcept.Score) == false)
{
objConceptEN.dicFldComparisonOp.Add(conConcept.Score, strComparisonOp);
}
else
{
objConceptEN.dicFldComparisonOp[conConcept.Score] = strComparisonOp;
}
}
return objConceptEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objConceptEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsConceptEN SetStuScore(this clsConceptEN objConceptEN, float? fltStuScore, string strComparisonOp="")
	{
objConceptEN.StuScore = fltStuScore; //学生平均分
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objConceptEN.dicFldComparisonOp.ContainsKey(conConcept.StuScore) == false)
{
objConceptEN.dicFldComparisonOp.Add(conConcept.StuScore, strComparisonOp);
}
else
{
objConceptEN.dicFldComparisonOp[conConcept.StuScore] = strComparisonOp;
}
}
return objConceptEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objConceptEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsConceptEN SetTeaScore(this clsConceptEN objConceptEN, float? fltTeaScore, string strComparisonOp="")
	{
objConceptEN.TeaScore = fltTeaScore; //教师评分
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objConceptEN.dicFldComparisonOp.ContainsKey(conConcept.TeaScore) == false)
{
objConceptEN.dicFldComparisonOp.Add(conConcept.TeaScore, strComparisonOp);
}
else
{
objConceptEN.dicFldComparisonOp[conConcept.TeaScore] = strComparisonOp;
}
}
return objConceptEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objConceptEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsConceptEN SetIdCurrEduCls(this clsConceptEN objConceptEN, string strIdCurrEduCls, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdCurrEduCls, 8, conConcept.IdCurrEduCls);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdCurrEduCls, 8, conConcept.IdCurrEduCls);
}
objConceptEN.IdCurrEduCls = strIdCurrEduCls; //教学班流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objConceptEN.dicFldComparisonOp.ContainsKey(conConcept.IdCurrEduCls) == false)
{
objConceptEN.dicFldComparisonOp.Add(conConcept.IdCurrEduCls, strComparisonOp);
}
else
{
objConceptEN.dicFldComparisonOp[conConcept.IdCurrEduCls] = strComparisonOp;
}
}
return objConceptEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objConceptEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsConceptEN SetPdfContent(this clsConceptEN objConceptEN, string strPdfContent, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPdfContent, 2000, conConcept.PdfContent);
}
objConceptEN.PdfContent = strPdfContent; //Pdf内容
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objConceptEN.dicFldComparisonOp.ContainsKey(conConcept.PdfContent) == false)
{
objConceptEN.dicFldComparisonOp.Add(conConcept.PdfContent, strComparisonOp);
}
else
{
objConceptEN.dicFldComparisonOp[conConcept.PdfContent] = strComparisonOp;
}
}
return objConceptEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objConceptEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsConceptEN SetPdfPageNum(this clsConceptEN objConceptEN, int? intPdfPageNum, string strComparisonOp="")
	{
objConceptEN.PdfPageNum = intPdfPageNum; //Pdf页码
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objConceptEN.dicFldComparisonOp.ContainsKey(conConcept.PdfPageNum) == false)
{
objConceptEN.dicFldComparisonOp.Add(conConcept.PdfPageNum, strComparisonOp);
}
else
{
objConceptEN.dicFldComparisonOp[conConcept.PdfPageNum] = strComparisonOp;
}
}
return objConceptEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objConceptEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsConceptEN SetCitationCount(this clsConceptEN objConceptEN, int? intCitationCount, string strComparisonOp="")
	{
objConceptEN.CitationCount = intCitationCount; //引用统计
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objConceptEN.dicFldComparisonOp.ContainsKey(conConcept.CitationCount) == false)
{
objConceptEN.dicFldComparisonOp.Add(conConcept.CitationCount, strComparisonOp);
}
else
{
objConceptEN.dicFldComparisonOp[conConcept.CitationCount] = strComparisonOp;
}
}
return objConceptEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objConceptEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsConceptEN SetVersionCount(this clsConceptEN objConceptEN, int? intVersionCount, string strComparisonOp="")
	{
objConceptEN.VersionCount = intVersionCount; //版本统计
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objConceptEN.dicFldComparisonOp.ContainsKey(conConcept.VersionCount) == false)
{
objConceptEN.dicFldComparisonOp.Add(conConcept.VersionCount, strComparisonOp);
}
else
{
objConceptEN.dicFldComparisonOp[conConcept.VersionCount] = strComparisonOp;
}
}
return objConceptEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objConceptEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsConceptEN SetCreateDate(this clsConceptEN objConceptEN, string strCreateDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCreateDate, 20, conConcept.CreateDate);
}
objConceptEN.CreateDate = strCreateDate; //建立日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objConceptEN.dicFldComparisonOp.ContainsKey(conConcept.CreateDate) == false)
{
objConceptEN.dicFldComparisonOp.Add(conConcept.CreateDate, strComparisonOp);
}
else
{
objConceptEN.dicFldComparisonOp[conConcept.CreateDate] = strComparisonOp;
}
}
return objConceptEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objConceptEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsConceptEN SetShareId(this clsConceptEN objConceptEN, string strShareId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strShareId, conConcept.ShareId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strShareId, 2, conConcept.ShareId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strShareId, 2, conConcept.ShareId);
}
objConceptEN.ShareId = strShareId; //分享Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objConceptEN.dicFldComparisonOp.ContainsKey(conConcept.ShareId) == false)
{
objConceptEN.dicFldComparisonOp.Add(conConcept.ShareId, strComparisonOp);
}
else
{
objConceptEN.dicFldComparisonOp[conConcept.ShareId] = strComparisonOp;
}
}
return objConceptEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objConceptEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsConceptEN SetUpdUser(this clsConceptEN objConceptEN, string strUpdUser, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdUser, 20, conConcept.UpdUser);
}
objConceptEN.UpdUser = strUpdUser; //修改人
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objConceptEN.dicFldComparisonOp.ContainsKey(conConcept.UpdUser) == false)
{
objConceptEN.dicFldComparisonOp.Add(conConcept.UpdUser, strComparisonOp);
}
else
{
objConceptEN.dicFldComparisonOp[conConcept.UpdUser] = strComparisonOp;
}
}
return objConceptEN;
	}

 /// <summary>
 /// 修改记录存盘到数据表中
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_UpdateRecordEx)
 /// </summary>
 /// <param name = "objConceptEN">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool UpdateRecordEx(this clsConceptEN objConceptEN)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
try
{
//1、检查传进去的对象属性是否合法
objConceptEN.CheckPropertyNew();
clsConceptEN objConceptCond = new clsConceptEN();
string strCondition = objConceptCond
.SetConceptId(objConceptEN.ConceptId, "<>")
.SetIdCurrEduCls(objConceptEN.IdCurrEduCls, "=")
.SetConceptName(objConceptEN.ConceptName, "=")
.GetCombineCondition();
objConceptEN._IsCheckProperty = true;
bool bolIsExist = clsConceptBL.IsExistRecord(strCondition);
if (bolIsExist)
{
strMsg = "(id_CurrEduCls_ConceptName)不能重复!";
throw new Exception(strMsg);
}
//4、把数据实体层的数据存贮到数据库中
objConceptEN.Update();
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
 /// <param name = "objConcept">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool EditRecordEx(this clsConceptEN objConcept)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
clsConceptEN objConceptCond = new clsConceptEN();
string strCondition = objConceptCond
.SetIdCurrEduCls(objConcept.IdCurrEduCls, "=")
.SetConceptName(objConcept.ConceptName, "=")
.GetCombineCondition();
objConcept._IsCheckProperty = true;
bool bolIsExist = clsConceptBL.IsExistRecord(strCondition);
if (bolIsExist)
{
objConcept.ConceptId = clsConceptBL.GetFirstID_S(strCondition);
objConcept.UpdateWithCondition(strCondition);
}
else
{
objConcept.ConceptId = clsConceptBL.GetMaxStrId_S();
objConcept.AddNewRecord();
}
return true; 
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_Update)
 /// </summary>
 /// <param name = "objConceptEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsConceptEN objConceptEN)
{
 if (string.IsNullOrEmpty(objConceptEN.ConceptId) == true)
 {
string strMsg = string.Format("(errid:Busi000095)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsConceptBL.ConceptDA.UpdateBySql2(objConceptEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsConceptBL.ReFreshCache(objConceptEN.IdCurrEduCls);

if (clsConceptBL.relatedActions != null)
{
clsConceptBL.relatedActions.UpdRelaTabDate(objConceptEN.ConceptId, "SetUpdDate");
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
 /// <param name = "objConceptEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsConceptEN objConceptEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (string.IsNullOrEmpty(objConceptEN.ConceptId) == true)
 {
string strMsg = string.Format("(errid:Busi000087)修改记录时关键字不能为空!(带事务处理)(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsConceptBL.ConceptDA.UpdateBySql2(objConceptEN, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsConceptBL.ReFreshCache(objConceptEN.IdCurrEduCls);

if (clsConceptBL.relatedActions != null)
{
clsConceptBL.relatedActions.UpdRelaTabDate(objConceptEN.ConceptId, "SetUpdDate");
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
 /// <param name = "objConceptEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsConceptEN objConceptEN, string strWhereCond)
{
try
{
bool bolResult = clsConceptBL.ConceptDA.UpdateBySqlWithCondition(objConceptEN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsConceptBL.ReFreshCache(objConceptEN.IdCurrEduCls);

if (clsConceptBL.relatedActions != null)
{
clsConceptBL.relatedActions.UpdRelaTabDate(objConceptEN.ConceptId, "SetUpdDate");
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
 /// <param name = "objConceptEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsConceptEN objConceptEN, string strWhereCond, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
bool bolResult = clsConceptBL.ConceptDA.UpdateBySqlWithConditionTransaction(objConceptEN, strWhereCond, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsConceptBL.ReFreshCache(objConceptEN.IdCurrEduCls);

if (clsConceptBL.relatedActions != null)
{
clsConceptBL.relatedActions.UpdRelaTabDate(objConceptEN.ConceptId, "SetUpdDate");
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
 /// <param name = "strConceptId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int Delete(this clsConceptEN objConceptEN)
{
try
{
int intRecNum = clsConceptBL.ConceptDA.DelRecord(objConceptEN.ConceptId);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsConceptBL.ReFreshCache(objConceptEN.IdCurrEduCls);

if (clsConceptBL.relatedActions != null)
{
clsConceptBL.relatedActions.UpdRelaTabDate(objConceptEN.ConceptId, "SetUpdDate");
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
 /// <param name = "objConceptENS">源对象</param>
 /// <param name = "objConceptENT">目标对象</param>
 public static void CopyTo(this clsConceptEN objConceptENS, clsConceptEN objConceptENT)
{
try
{
objConceptENT.ConceptId = objConceptENS.ConceptId; //概念Id
objConceptENT.ConceptName = objConceptENS.ConceptName; //概念名称
objConceptENT.ConceptContent = objConceptENS.ConceptContent; //概念内容
objConceptENT.IsSubmit = objConceptENS.IsSubmit; //是否提交
objConceptENT.UpdDate = objConceptENS.UpdDate; //修改日期
objConceptENT.Memo = objConceptENS.Memo; //备注
objConceptENT.CitationId = objConceptENS.CitationId; //引用Id
objConceptENT.AppraiseCount = objConceptENS.AppraiseCount; //评论数
objConceptENT.OkCount = objConceptENS.OkCount; //点赞统计
objConceptENT.Score = objConceptENS.Score; //评分
objConceptENT.StuScore = objConceptENS.StuScore; //学生平均分
objConceptENT.TeaScore = objConceptENS.TeaScore; //教师评分
objConceptENT.IdCurrEduCls = objConceptENS.IdCurrEduCls; //教学班流水号
objConceptENT.PdfContent = objConceptENS.PdfContent; //Pdf内容
objConceptENT.PdfPageNum = objConceptENS.PdfPageNum; //Pdf页码
objConceptENT.CitationCount = objConceptENS.CitationCount; //引用统计
objConceptENT.VersionCount = objConceptENS.VersionCount; //版本统计
objConceptENT.CreateDate = objConceptENS.CreateDate; //建立日期
objConceptENT.ShareId = objConceptENS.ShareId; //分享Id
objConceptENT.UpdUser = objConceptENS.UpdUser; //修改人
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
 /// <param name = "objConceptENS">源对象</param>
 /// <returns>目标对象=>clsConceptEN:objConceptENT</returns>
 public static clsConceptEN CopyTo(this clsConceptEN objConceptENS)
{
try
{
 clsConceptEN objConceptENT = new clsConceptEN()
{
ConceptId = objConceptENS.ConceptId, //概念Id
ConceptName = objConceptENS.ConceptName, //概念名称
ConceptContent = objConceptENS.ConceptContent, //概念内容
IsSubmit = objConceptENS.IsSubmit, //是否提交
UpdDate = objConceptENS.UpdDate, //修改日期
Memo = objConceptENS.Memo, //备注
CitationId = objConceptENS.CitationId, //引用Id
AppraiseCount = objConceptENS.AppraiseCount, //评论数
OkCount = objConceptENS.OkCount, //点赞统计
Score = objConceptENS.Score, //评分
StuScore = objConceptENS.StuScore, //学生平均分
TeaScore = objConceptENS.TeaScore, //教师评分
IdCurrEduCls = objConceptENS.IdCurrEduCls, //教学班流水号
PdfContent = objConceptENS.PdfContent, //Pdf内容
PdfPageNum = objConceptENS.PdfPageNum, //Pdf页码
CitationCount = objConceptENS.CitationCount, //引用统计
VersionCount = objConceptENS.VersionCount, //版本统计
CreateDate = objConceptENS.CreateDate, //建立日期
ShareId = objConceptENS.ShareId, //分享Id
UpdUser = objConceptENS.UpdUser, //修改人
};
 return objConceptENT;
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
public static void CheckPropertyNew(this clsConceptEN objConceptEN)
{
 clsConceptBL.ConceptDA.CheckPropertyNew(objConceptEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(this clsConceptEN objConceptEN)
{
 clsConceptBL.ConceptDA.CheckProperty4Condition(objConceptEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsConceptEN objConceptCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objConceptCond.IsUpdated(conConcept.ConceptId) == true)
{
string strComparisonOpConceptId = objConceptCond.dicFldComparisonOp[conConcept.ConceptId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conConcept.ConceptId, objConceptCond.ConceptId, strComparisonOpConceptId);
}
if (objConceptCond.IsUpdated(conConcept.ConceptName) == true)
{
string strComparisonOpConceptName = objConceptCond.dicFldComparisonOp[conConcept.ConceptName];
strWhereCond += string.Format(" And {0} {2} '{1}'", conConcept.ConceptName, objConceptCond.ConceptName, strComparisonOpConceptName);
}
//数据类型string(text)在函数:[AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj]中没有处理!
if (objConceptCond.IsUpdated(conConcept.IsSubmit) == true)
{
if (objConceptCond.IsSubmit == true)
{
strWhereCond += string.Format(" And {0} = '1'", conConcept.IsSubmit);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conConcept.IsSubmit);
}
}
if (objConceptCond.IsUpdated(conConcept.UpdDate) == true)
{
string strComparisonOpUpdDate = objConceptCond.dicFldComparisonOp[conConcept.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conConcept.UpdDate, objConceptCond.UpdDate, strComparisonOpUpdDate);
}
if (objConceptCond.IsUpdated(conConcept.Memo) == true)
{
string strComparisonOpMemo = objConceptCond.dicFldComparisonOp[conConcept.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", conConcept.Memo, objConceptCond.Memo, strComparisonOpMemo);
}
if (objConceptCond.IsUpdated(conConcept.CitationId) == true)
{
string strComparisonOpCitationId = objConceptCond.dicFldComparisonOp[conConcept.CitationId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conConcept.CitationId, objConceptCond.CitationId, strComparisonOpCitationId);
}
if (objConceptCond.IsUpdated(conConcept.AppraiseCount) == true)
{
string strComparisonOpAppraiseCount = objConceptCond.dicFldComparisonOp[conConcept.AppraiseCount];
strWhereCond += string.Format(" And {0} {2} {1}", conConcept.AppraiseCount, objConceptCond.AppraiseCount, strComparisonOpAppraiseCount);
}
if (objConceptCond.IsUpdated(conConcept.OkCount) == true)
{
string strComparisonOpOkCount = objConceptCond.dicFldComparisonOp[conConcept.OkCount];
strWhereCond += string.Format(" And {0} {2} {1}", conConcept.OkCount, objConceptCond.OkCount, strComparisonOpOkCount);
}
if (objConceptCond.IsUpdated(conConcept.Score) == true)
{
string strComparisonOpScore = objConceptCond.dicFldComparisonOp[conConcept.Score];
strWhereCond += string.Format(" And {0} {2} {1}", conConcept.Score, objConceptCond.Score, strComparisonOpScore);
}
if (objConceptCond.IsUpdated(conConcept.StuScore) == true)
{
string strComparisonOpStuScore = objConceptCond.dicFldComparisonOp[conConcept.StuScore];
strWhereCond += string.Format(" And {0} {2} {1}", conConcept.StuScore, objConceptCond.StuScore, strComparisonOpStuScore);
}
if (objConceptCond.IsUpdated(conConcept.TeaScore) == true)
{
string strComparisonOpTeaScore = objConceptCond.dicFldComparisonOp[conConcept.TeaScore];
strWhereCond += string.Format(" And {0} {2} {1}", conConcept.TeaScore, objConceptCond.TeaScore, strComparisonOpTeaScore);
}
if (objConceptCond.IsUpdated(conConcept.IdCurrEduCls) == true)
{
string strComparisonOpIdCurrEduCls = objConceptCond.dicFldComparisonOp[conConcept.IdCurrEduCls];
strWhereCond += string.Format(" And {0} {2} '{1}'", conConcept.IdCurrEduCls, objConceptCond.IdCurrEduCls, strComparisonOpIdCurrEduCls);
}
if (objConceptCond.IsUpdated(conConcept.PdfContent) == true)
{
string strComparisonOpPdfContent = objConceptCond.dicFldComparisonOp[conConcept.PdfContent];
strWhereCond += string.Format(" And {0} {2} '{1}'", conConcept.PdfContent, objConceptCond.PdfContent, strComparisonOpPdfContent);
}
if (objConceptCond.IsUpdated(conConcept.PdfPageNum) == true)
{
string strComparisonOpPdfPageNum = objConceptCond.dicFldComparisonOp[conConcept.PdfPageNum];
strWhereCond += string.Format(" And {0} {2} {1}", conConcept.PdfPageNum, objConceptCond.PdfPageNum, strComparisonOpPdfPageNum);
}
if (objConceptCond.IsUpdated(conConcept.CitationCount) == true)
{
string strComparisonOpCitationCount = objConceptCond.dicFldComparisonOp[conConcept.CitationCount];
strWhereCond += string.Format(" And {0} {2} {1}", conConcept.CitationCount, objConceptCond.CitationCount, strComparisonOpCitationCount);
}
if (objConceptCond.IsUpdated(conConcept.VersionCount) == true)
{
string strComparisonOpVersionCount = objConceptCond.dicFldComparisonOp[conConcept.VersionCount];
strWhereCond += string.Format(" And {0} {2} {1}", conConcept.VersionCount, objConceptCond.VersionCount, strComparisonOpVersionCount);
}
if (objConceptCond.IsUpdated(conConcept.CreateDate) == true)
{
string strComparisonOpCreateDate = objConceptCond.dicFldComparisonOp[conConcept.CreateDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conConcept.CreateDate, objConceptCond.CreateDate, strComparisonOpCreateDate);
}
if (objConceptCond.IsUpdated(conConcept.ShareId) == true)
{
string strComparisonOpShareId = objConceptCond.dicFldComparisonOp[conConcept.ShareId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conConcept.ShareId, objConceptCond.ShareId, strComparisonOpShareId);
}
if (objConceptCond.IsUpdated(conConcept.UpdUser) == true)
{
string strComparisonOpUpdUser = objConceptCond.dicFldComparisonOp[conConcept.UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", conConcept.UpdUser, objConceptCond.UpdUser, strComparisonOpUpdUser);
}
 return strWhereCond;
}

 /// <summary>
 /// 检查唯一性(Uniqueness)--Concept(观点概念), 如果不唯一,即存在相同的记录,就返回False
 /// 唯一性条件:id_CurrEduCls_ConceptName
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckConstraint)
 /// </summary>
 /// <param name = "objConceptEN">要求唯一的对象</param>
 /// <returns></returns>
public static bool CheckUniqueness(this clsConceptEN objConceptEN)
{
//检测记录是否存在
bool bolIsUniqueness;
StringBuilder sbCondition = new StringBuilder();
if (objConceptEN == null) return true;
if (objConceptEN.ConceptId == null || objConceptEN.ConceptId == "")
{
sbCondition.AppendFormat("1 = 1");
 if (objConceptEN.IdCurrEduCls == null)
{
 sbCondition.AppendFormat(" and IdCurrEduCls is null", objConceptEN.IdCurrEduCls);
}
else
{
 sbCondition.AppendFormat(" and IdCurrEduCls = '{0}'", objConceptEN.IdCurrEduCls);
}
 if (objConceptEN.ConceptName == null)
{
 sbCondition.AppendFormat(" and ConceptName is null", objConceptEN.ConceptName);
}
else
{
 sbCondition.AppendFormat(" and ConceptName = '{0}'", objConceptEN.ConceptName);
}
if (clsConceptBL.IsExistRecord(sbCondition.ToString())  ==  true)
{
 bolIsUniqueness = false;
}
else
{
 bolIsUniqueness = true;
}
}
 else {
sbCondition.AppendFormat("ConceptId !=  '{0}'", objConceptEN.ConceptId);
 sbCondition.AppendFormat(" and IdCurrEduCls = '{0}'", objConceptEN.IdCurrEduCls);
 sbCondition.AppendFormat(" and ConceptName = '{0}'", objConceptEN.ConceptName);
if (clsConceptBL.IsExistRecord(sbCondition.ToString())  ==  true)
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
 /// 获取唯一性条件串--Concept(观点概念), 即由对象中唯一性条件字段关键字与值组成的条件串
 /// 唯一性条件:id_CurrEduCls_ConceptName
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetConditionString4Constraint)
 /// </summary>
 /// <param name = "objConceptEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(this clsConceptEN objConceptEN)
{
//检测记录是否存在
StringBuilder sbCondition = new StringBuilder();
if (objConceptEN == null) return "";
if (objConceptEN.ConceptId == null || objConceptEN.ConceptId == "")
{
sbCondition.AppendFormat("1 = 1");
 if (objConceptEN.IdCurrEduCls == null)
{
 sbCondition.AppendFormat(" and IdCurrEduCls is null", objConceptEN.IdCurrEduCls);
}
else
{
 sbCondition.AppendFormat(" and IdCurrEduCls = '{0}'", objConceptEN.IdCurrEduCls);
}
 if (objConceptEN.ConceptName == null)
{
 sbCondition.AppendFormat(" and ConceptName is null", objConceptEN.ConceptName);
}
else
{
 sbCondition.AppendFormat(" and ConceptName = '{0}'", objConceptEN.ConceptName);
}
return sbCondition.ToString();
}
 else {
sbCondition.AppendFormat("ConceptId !=  '{0}'", objConceptEN.ConceptId);
 sbCondition.AppendFormat(" and IdCurrEduCls = '{0}'", objConceptEN.IdCurrEduCls);
 sbCondition.AppendFormat(" and ConceptName = '{0}'", objConceptEN.ConceptName);
 return sbCondition.ToString();
}
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_Concept
{
public virtual bool UpdRelaTabDate(string strConceptId, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// 观点概念(Concept)
 /// 数据源类型:表
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsConceptBL
{
public static RelatedActions_Concept relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsConceptDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsConceptDA ConceptDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsConceptDA();
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
 public clsConceptBL()
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
if (string.IsNullOrEmpty(clsConceptEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsConceptEN._ConnectString);
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
public static DataTable GetDataTable_Concept(string strWhereCond)
{
DataTable objDT;
try
{
objDT = ConceptDA.GetDataTable_Concept(strWhereCond);
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
objDT = ConceptDA.GetDataTable(strWhereCond);
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
objDT = ConceptDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = ConceptDA.GetDataTable(strWhereCond, strTabName);
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
objDT = ConceptDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = ConceptDA.GetDataTable_Top(objTopPara);
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
objDT = ConceptDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = ConceptDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = ConceptDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
 /// <param name = "arrConceptIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static List<clsConceptEN> GetObjLstByConceptIdLst(List<string> arrConceptIdLst)
{
List<clsConceptEN> arrObjLst = new List<clsConceptEN>(); 
System.Data.DataTable objDT; 
 string strSqlConditionStr = clsArray.GetSqlInStrByArray(arrConceptIdLst, true);
 string strWhereCond = string.Format("ConceptId in ({0})", strSqlConditionStr);
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsConceptEN objConceptEN = new clsConceptEN();
try
{
objConceptEN.ConceptId = objRow[conConcept.ConceptId].ToString().Trim(); //概念Id
objConceptEN.ConceptName = objRow[conConcept.ConceptName] == DBNull.Value ? null : objRow[conConcept.ConceptName].ToString().Trim(); //概念名称
objConceptEN.ConceptContent = objRow[conConcept.ConceptContent] == DBNull.Value ? null : objRow[conConcept.ConceptContent].ToString().Trim(); //概念内容
objConceptEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[conConcept.IsSubmit].ToString().Trim()); //是否提交
objConceptEN.UpdDate = objRow[conConcept.UpdDate] == DBNull.Value ? null : objRow[conConcept.UpdDate].ToString().Trim(); //修改日期
objConceptEN.Memo = objRow[conConcept.Memo] == DBNull.Value ? null : objRow[conConcept.Memo].ToString().Trim(); //备注
objConceptEN.CitationId = objRow[conConcept.CitationId] == DBNull.Value ? null : objRow[conConcept.CitationId].ToString().Trim(); //引用Id
objConceptEN.AppraiseCount = objRow[conConcept.AppraiseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conConcept.AppraiseCount].ToString().Trim()); //评论数
objConceptEN.OkCount = objRow[conConcept.OkCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conConcept.OkCount].ToString().Trim()); //点赞统计
objConceptEN.Score = objRow[conConcept.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conConcept.Score].ToString().Trim()); //评分
objConceptEN.StuScore = objRow[conConcept.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conConcept.StuScore].ToString().Trim()); //学生平均分
objConceptEN.TeaScore = objRow[conConcept.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conConcept.TeaScore].ToString().Trim()); //教师评分
objConceptEN.IdCurrEduCls = objRow[conConcept.IdCurrEduCls] == DBNull.Value ? null : objRow[conConcept.IdCurrEduCls].ToString().Trim(); //教学班流水号
objConceptEN.PdfContent = objRow[conConcept.PdfContent] == DBNull.Value ? null : objRow[conConcept.PdfContent].ToString().Trim(); //Pdf内容
objConceptEN.PdfPageNum = objRow[conConcept.PdfPageNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conConcept.PdfPageNum].ToString().Trim()); //Pdf页码
objConceptEN.CitationCount = objRow[conConcept.CitationCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conConcept.CitationCount].ToString().Trim()); //引用统计
objConceptEN.VersionCount = objRow[conConcept.VersionCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conConcept.VersionCount].ToString().Trim()); //版本统计
objConceptEN.CreateDate = objRow[conConcept.CreateDate] == DBNull.Value ? null : objRow[conConcept.CreateDate].ToString().Trim(); //建立日期
objConceptEN.ShareId = objRow[conConcept.ShareId].ToString().Trim(); //分享Id
objConceptEN.UpdUser = objRow[conConcept.UpdUser] == DBNull.Value ? null : objRow[conConcept.UpdUser].ToString().Trim(); //修改人
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objConceptEN.ConceptId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objConceptEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrConceptIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsConceptEN> GetObjLstByConceptIdLstCache(List<string> arrConceptIdLst, string strIdCurrEduCls)
{
string strKey = string.Format("{0}_{1}", clsConceptEN._CurrTabName, strIdCurrEduCls);
List<clsConceptEN> arrConceptObjLstCache = GetObjLstCache(strIdCurrEduCls);
IEnumerable <clsConceptEN> arrConceptObjLst_Sel =
arrConceptObjLstCache
.Where(x => arrConceptIdLst.Contains(x.ConceptId));
return arrConceptObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsConceptEN> GetObjLst(string strWhereCond)
{
List<clsConceptEN> arrObjLst = new List<clsConceptEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsConceptEN objConceptEN = new clsConceptEN();
try
{
objConceptEN.ConceptId = objRow[conConcept.ConceptId].ToString().Trim(); //概念Id
objConceptEN.ConceptName = objRow[conConcept.ConceptName] == DBNull.Value ? null : objRow[conConcept.ConceptName].ToString().Trim(); //概念名称
objConceptEN.ConceptContent = objRow[conConcept.ConceptContent] == DBNull.Value ? null : objRow[conConcept.ConceptContent].ToString().Trim(); //概念内容
objConceptEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[conConcept.IsSubmit].ToString().Trim()); //是否提交
objConceptEN.UpdDate = objRow[conConcept.UpdDate] == DBNull.Value ? null : objRow[conConcept.UpdDate].ToString().Trim(); //修改日期
objConceptEN.Memo = objRow[conConcept.Memo] == DBNull.Value ? null : objRow[conConcept.Memo].ToString().Trim(); //备注
objConceptEN.CitationId = objRow[conConcept.CitationId] == DBNull.Value ? null : objRow[conConcept.CitationId].ToString().Trim(); //引用Id
objConceptEN.AppraiseCount = objRow[conConcept.AppraiseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conConcept.AppraiseCount].ToString().Trim()); //评论数
objConceptEN.OkCount = objRow[conConcept.OkCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conConcept.OkCount].ToString().Trim()); //点赞统计
objConceptEN.Score = objRow[conConcept.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conConcept.Score].ToString().Trim()); //评分
objConceptEN.StuScore = objRow[conConcept.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conConcept.StuScore].ToString().Trim()); //学生平均分
objConceptEN.TeaScore = objRow[conConcept.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conConcept.TeaScore].ToString().Trim()); //教师评分
objConceptEN.IdCurrEduCls = objRow[conConcept.IdCurrEduCls] == DBNull.Value ? null : objRow[conConcept.IdCurrEduCls].ToString().Trim(); //教学班流水号
objConceptEN.PdfContent = objRow[conConcept.PdfContent] == DBNull.Value ? null : objRow[conConcept.PdfContent].ToString().Trim(); //Pdf内容
objConceptEN.PdfPageNum = objRow[conConcept.PdfPageNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conConcept.PdfPageNum].ToString().Trim()); //Pdf页码
objConceptEN.CitationCount = objRow[conConcept.CitationCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conConcept.CitationCount].ToString().Trim()); //引用统计
objConceptEN.VersionCount = objRow[conConcept.VersionCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conConcept.VersionCount].ToString().Trim()); //版本统计
objConceptEN.CreateDate = objRow[conConcept.CreateDate] == DBNull.Value ? null : objRow[conConcept.CreateDate].ToString().Trim(); //建立日期
objConceptEN.ShareId = objRow[conConcept.ShareId].ToString().Trim(); //分享Id
objConceptEN.UpdUser = objRow[conConcept.UpdUser] == DBNull.Value ? null : objRow[conConcept.UpdUser].ToString().Trim(); //修改人
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objConceptEN.ConceptId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objConceptEN);
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
public static List<clsConceptEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsConceptEN> arrObjLst = new List<clsConceptEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsConceptEN objConceptEN = new clsConceptEN();
try
{
objConceptEN.ConceptId = objRow[conConcept.ConceptId].ToString().Trim(); //概念Id
objConceptEN.ConceptName = objRow[conConcept.ConceptName] == DBNull.Value ? null : objRow[conConcept.ConceptName].ToString().Trim(); //概念名称
objConceptEN.ConceptContent = objRow[conConcept.ConceptContent] == DBNull.Value ? null : objRow[conConcept.ConceptContent].ToString().Trim(); //概念内容
objConceptEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[conConcept.IsSubmit].ToString().Trim()); //是否提交
objConceptEN.UpdDate = objRow[conConcept.UpdDate] == DBNull.Value ? null : objRow[conConcept.UpdDate].ToString().Trim(); //修改日期
objConceptEN.Memo = objRow[conConcept.Memo] == DBNull.Value ? null : objRow[conConcept.Memo].ToString().Trim(); //备注
objConceptEN.CitationId = objRow[conConcept.CitationId] == DBNull.Value ? null : objRow[conConcept.CitationId].ToString().Trim(); //引用Id
objConceptEN.AppraiseCount = objRow[conConcept.AppraiseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conConcept.AppraiseCount].ToString().Trim()); //评论数
objConceptEN.OkCount = objRow[conConcept.OkCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conConcept.OkCount].ToString().Trim()); //点赞统计
objConceptEN.Score = objRow[conConcept.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conConcept.Score].ToString().Trim()); //评分
objConceptEN.StuScore = objRow[conConcept.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conConcept.StuScore].ToString().Trim()); //学生平均分
objConceptEN.TeaScore = objRow[conConcept.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conConcept.TeaScore].ToString().Trim()); //教师评分
objConceptEN.IdCurrEduCls = objRow[conConcept.IdCurrEduCls] == DBNull.Value ? null : objRow[conConcept.IdCurrEduCls].ToString().Trim(); //教学班流水号
objConceptEN.PdfContent = objRow[conConcept.PdfContent] == DBNull.Value ? null : objRow[conConcept.PdfContent].ToString().Trim(); //Pdf内容
objConceptEN.PdfPageNum = objRow[conConcept.PdfPageNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conConcept.PdfPageNum].ToString().Trim()); //Pdf页码
objConceptEN.CitationCount = objRow[conConcept.CitationCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conConcept.CitationCount].ToString().Trim()); //引用统计
objConceptEN.VersionCount = objRow[conConcept.VersionCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conConcept.VersionCount].ToString().Trim()); //版本统计
objConceptEN.CreateDate = objRow[conConcept.CreateDate] == DBNull.Value ? null : objRow[conConcept.CreateDate].ToString().Trim(); //建立日期
objConceptEN.ShareId = objRow[conConcept.ShareId].ToString().Trim(); //分享Id
objConceptEN.UpdUser = objRow[conConcept.UpdUser] == DBNull.Value ? null : objRow[conConcept.UpdUser].ToString().Trim(); //修改人
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objConceptEN.ConceptId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objConceptEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objConceptCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsConceptEN> GetSubObjLstCache(clsConceptEN objConceptCond)
{
 string strIdCurrEduCls = objConceptCond.IdCurrEduCls;
 if (string.IsNullOrEmpty(strIdCurrEduCls) == true)
{
string strMsg = string.Format("(errid:Busi000172)在表中,缓存分类字段值不能为空!(clsConceptBL:GetSubObjLstCache)");
throw new Exception(strMsg);
}
List<clsConceptEN> arrObjLstCache = GetObjLstCache(strIdCurrEduCls);
IEnumerable <clsConceptEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conConcept.AttributeName)
{
if (objConceptCond.IsUpdated(strFldName) == false) continue;
if (objConceptCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objConceptCond[strFldName].ToString());
}
else
{
if (objConceptCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objConceptCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objConceptCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objConceptCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objConceptCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objConceptCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objConceptCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objConceptCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objConceptCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objConceptCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objConceptCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objConceptCond[strFldName]));
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
public static List<clsConceptEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsConceptEN> arrObjLst = new List<clsConceptEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsConceptEN objConceptEN = new clsConceptEN();
try
{
objConceptEN.ConceptId = objRow[conConcept.ConceptId].ToString().Trim(); //概念Id
objConceptEN.ConceptName = objRow[conConcept.ConceptName] == DBNull.Value ? null : objRow[conConcept.ConceptName].ToString().Trim(); //概念名称
objConceptEN.ConceptContent = objRow[conConcept.ConceptContent] == DBNull.Value ? null : objRow[conConcept.ConceptContent].ToString().Trim(); //概念内容
objConceptEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[conConcept.IsSubmit].ToString().Trim()); //是否提交
objConceptEN.UpdDate = objRow[conConcept.UpdDate] == DBNull.Value ? null : objRow[conConcept.UpdDate].ToString().Trim(); //修改日期
objConceptEN.Memo = objRow[conConcept.Memo] == DBNull.Value ? null : objRow[conConcept.Memo].ToString().Trim(); //备注
objConceptEN.CitationId = objRow[conConcept.CitationId] == DBNull.Value ? null : objRow[conConcept.CitationId].ToString().Trim(); //引用Id
objConceptEN.AppraiseCount = objRow[conConcept.AppraiseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conConcept.AppraiseCount].ToString().Trim()); //评论数
objConceptEN.OkCount = objRow[conConcept.OkCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conConcept.OkCount].ToString().Trim()); //点赞统计
objConceptEN.Score = objRow[conConcept.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conConcept.Score].ToString().Trim()); //评分
objConceptEN.StuScore = objRow[conConcept.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conConcept.StuScore].ToString().Trim()); //学生平均分
objConceptEN.TeaScore = objRow[conConcept.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conConcept.TeaScore].ToString().Trim()); //教师评分
objConceptEN.IdCurrEduCls = objRow[conConcept.IdCurrEduCls] == DBNull.Value ? null : objRow[conConcept.IdCurrEduCls].ToString().Trim(); //教学班流水号
objConceptEN.PdfContent = objRow[conConcept.PdfContent] == DBNull.Value ? null : objRow[conConcept.PdfContent].ToString().Trim(); //Pdf内容
objConceptEN.PdfPageNum = objRow[conConcept.PdfPageNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conConcept.PdfPageNum].ToString().Trim()); //Pdf页码
objConceptEN.CitationCount = objRow[conConcept.CitationCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conConcept.CitationCount].ToString().Trim()); //引用统计
objConceptEN.VersionCount = objRow[conConcept.VersionCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conConcept.VersionCount].ToString().Trim()); //版本统计
objConceptEN.CreateDate = objRow[conConcept.CreateDate] == DBNull.Value ? null : objRow[conConcept.CreateDate].ToString().Trim(); //建立日期
objConceptEN.ShareId = objRow[conConcept.ShareId].ToString().Trim(); //分享Id
objConceptEN.UpdUser = objRow[conConcept.UpdUser] == DBNull.Value ? null : objRow[conConcept.UpdUser].ToString().Trim(); //修改人
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objConceptEN.ConceptId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objConceptEN);
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
public static List<clsConceptEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsConceptEN> arrObjLst = new List<clsConceptEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsConceptEN objConceptEN = new clsConceptEN();
try
{
objConceptEN.ConceptId = objRow[conConcept.ConceptId].ToString().Trim(); //概念Id
objConceptEN.ConceptName = objRow[conConcept.ConceptName] == DBNull.Value ? null : objRow[conConcept.ConceptName].ToString().Trim(); //概念名称
objConceptEN.ConceptContent = objRow[conConcept.ConceptContent] == DBNull.Value ? null : objRow[conConcept.ConceptContent].ToString().Trim(); //概念内容
objConceptEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[conConcept.IsSubmit].ToString().Trim()); //是否提交
objConceptEN.UpdDate = objRow[conConcept.UpdDate] == DBNull.Value ? null : objRow[conConcept.UpdDate].ToString().Trim(); //修改日期
objConceptEN.Memo = objRow[conConcept.Memo] == DBNull.Value ? null : objRow[conConcept.Memo].ToString().Trim(); //备注
objConceptEN.CitationId = objRow[conConcept.CitationId] == DBNull.Value ? null : objRow[conConcept.CitationId].ToString().Trim(); //引用Id
objConceptEN.AppraiseCount = objRow[conConcept.AppraiseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conConcept.AppraiseCount].ToString().Trim()); //评论数
objConceptEN.OkCount = objRow[conConcept.OkCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conConcept.OkCount].ToString().Trim()); //点赞统计
objConceptEN.Score = objRow[conConcept.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conConcept.Score].ToString().Trim()); //评分
objConceptEN.StuScore = objRow[conConcept.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conConcept.StuScore].ToString().Trim()); //学生平均分
objConceptEN.TeaScore = objRow[conConcept.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conConcept.TeaScore].ToString().Trim()); //教师评分
objConceptEN.IdCurrEduCls = objRow[conConcept.IdCurrEduCls] == DBNull.Value ? null : objRow[conConcept.IdCurrEduCls].ToString().Trim(); //教学班流水号
objConceptEN.PdfContent = objRow[conConcept.PdfContent] == DBNull.Value ? null : objRow[conConcept.PdfContent].ToString().Trim(); //Pdf内容
objConceptEN.PdfPageNum = objRow[conConcept.PdfPageNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conConcept.PdfPageNum].ToString().Trim()); //Pdf页码
objConceptEN.CitationCount = objRow[conConcept.CitationCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conConcept.CitationCount].ToString().Trim()); //引用统计
objConceptEN.VersionCount = objRow[conConcept.VersionCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conConcept.VersionCount].ToString().Trim()); //版本统计
objConceptEN.CreateDate = objRow[conConcept.CreateDate] == DBNull.Value ? null : objRow[conConcept.CreateDate].ToString().Trim(); //建立日期
objConceptEN.ShareId = objRow[conConcept.ShareId].ToString().Trim(); //分享Id
objConceptEN.UpdUser = objRow[conConcept.UpdUser] == DBNull.Value ? null : objRow[conConcept.UpdUser].ToString().Trim(); //修改人
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objConceptEN.ConceptId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objConceptEN);
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
List<clsConceptEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsConceptEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsConceptEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsConceptEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsConceptEN> arrObjLst = new List<clsConceptEN>(); 
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
	clsConceptEN objConceptEN = new clsConceptEN();
try
{
objConceptEN.ConceptId = objRow[conConcept.ConceptId].ToString().Trim(); //概念Id
objConceptEN.ConceptName = objRow[conConcept.ConceptName] == DBNull.Value ? null : objRow[conConcept.ConceptName].ToString().Trim(); //概念名称
objConceptEN.ConceptContent = objRow[conConcept.ConceptContent] == DBNull.Value ? null : objRow[conConcept.ConceptContent].ToString().Trim(); //概念内容
objConceptEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[conConcept.IsSubmit].ToString().Trim()); //是否提交
objConceptEN.UpdDate = objRow[conConcept.UpdDate] == DBNull.Value ? null : objRow[conConcept.UpdDate].ToString().Trim(); //修改日期
objConceptEN.Memo = objRow[conConcept.Memo] == DBNull.Value ? null : objRow[conConcept.Memo].ToString().Trim(); //备注
objConceptEN.CitationId = objRow[conConcept.CitationId] == DBNull.Value ? null : objRow[conConcept.CitationId].ToString().Trim(); //引用Id
objConceptEN.AppraiseCount = objRow[conConcept.AppraiseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conConcept.AppraiseCount].ToString().Trim()); //评论数
objConceptEN.OkCount = objRow[conConcept.OkCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conConcept.OkCount].ToString().Trim()); //点赞统计
objConceptEN.Score = objRow[conConcept.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conConcept.Score].ToString().Trim()); //评分
objConceptEN.StuScore = objRow[conConcept.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conConcept.StuScore].ToString().Trim()); //学生平均分
objConceptEN.TeaScore = objRow[conConcept.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conConcept.TeaScore].ToString().Trim()); //教师评分
objConceptEN.IdCurrEduCls = objRow[conConcept.IdCurrEduCls] == DBNull.Value ? null : objRow[conConcept.IdCurrEduCls].ToString().Trim(); //教学班流水号
objConceptEN.PdfContent = objRow[conConcept.PdfContent] == DBNull.Value ? null : objRow[conConcept.PdfContent].ToString().Trim(); //Pdf内容
objConceptEN.PdfPageNum = objRow[conConcept.PdfPageNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conConcept.PdfPageNum].ToString().Trim()); //Pdf页码
objConceptEN.CitationCount = objRow[conConcept.CitationCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conConcept.CitationCount].ToString().Trim()); //引用统计
objConceptEN.VersionCount = objRow[conConcept.VersionCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conConcept.VersionCount].ToString().Trim()); //版本统计
objConceptEN.CreateDate = objRow[conConcept.CreateDate] == DBNull.Value ? null : objRow[conConcept.CreateDate].ToString().Trim(); //建立日期
objConceptEN.ShareId = objRow[conConcept.ShareId].ToString().Trim(); //分享Id
objConceptEN.UpdUser = objRow[conConcept.UpdUser] == DBNull.Value ? null : objRow[conConcept.UpdUser].ToString().Trim(); //修改人
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objConceptEN.ConceptId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objConceptEN);
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
public static List<clsConceptEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsConceptEN> arrObjLst = new List<clsConceptEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsConceptEN objConceptEN = new clsConceptEN();
try
{
objConceptEN.ConceptId = objRow[conConcept.ConceptId].ToString().Trim(); //概念Id
objConceptEN.ConceptName = objRow[conConcept.ConceptName] == DBNull.Value ? null : objRow[conConcept.ConceptName].ToString().Trim(); //概念名称
objConceptEN.ConceptContent = objRow[conConcept.ConceptContent] == DBNull.Value ? null : objRow[conConcept.ConceptContent].ToString().Trim(); //概念内容
objConceptEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[conConcept.IsSubmit].ToString().Trim()); //是否提交
objConceptEN.UpdDate = objRow[conConcept.UpdDate] == DBNull.Value ? null : objRow[conConcept.UpdDate].ToString().Trim(); //修改日期
objConceptEN.Memo = objRow[conConcept.Memo] == DBNull.Value ? null : objRow[conConcept.Memo].ToString().Trim(); //备注
objConceptEN.CitationId = objRow[conConcept.CitationId] == DBNull.Value ? null : objRow[conConcept.CitationId].ToString().Trim(); //引用Id
objConceptEN.AppraiseCount = objRow[conConcept.AppraiseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conConcept.AppraiseCount].ToString().Trim()); //评论数
objConceptEN.OkCount = objRow[conConcept.OkCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conConcept.OkCount].ToString().Trim()); //点赞统计
objConceptEN.Score = objRow[conConcept.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conConcept.Score].ToString().Trim()); //评分
objConceptEN.StuScore = objRow[conConcept.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conConcept.StuScore].ToString().Trim()); //学生平均分
objConceptEN.TeaScore = objRow[conConcept.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conConcept.TeaScore].ToString().Trim()); //教师评分
objConceptEN.IdCurrEduCls = objRow[conConcept.IdCurrEduCls] == DBNull.Value ? null : objRow[conConcept.IdCurrEduCls].ToString().Trim(); //教学班流水号
objConceptEN.PdfContent = objRow[conConcept.PdfContent] == DBNull.Value ? null : objRow[conConcept.PdfContent].ToString().Trim(); //Pdf内容
objConceptEN.PdfPageNum = objRow[conConcept.PdfPageNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conConcept.PdfPageNum].ToString().Trim()); //Pdf页码
objConceptEN.CitationCount = objRow[conConcept.CitationCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conConcept.CitationCount].ToString().Trim()); //引用统计
objConceptEN.VersionCount = objRow[conConcept.VersionCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conConcept.VersionCount].ToString().Trim()); //版本统计
objConceptEN.CreateDate = objRow[conConcept.CreateDate] == DBNull.Value ? null : objRow[conConcept.CreateDate].ToString().Trim(); //建立日期
objConceptEN.ShareId = objRow[conConcept.ShareId].ToString().Trim(); //分享Id
objConceptEN.UpdUser = objRow[conConcept.UpdUser] == DBNull.Value ? null : objRow[conConcept.UpdUser].ToString().Trim(); //修改人
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objConceptEN.ConceptId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objConceptEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsConceptEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsConceptEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsConceptEN> arrObjLst = new List<clsConceptEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsConceptEN objConceptEN = new clsConceptEN();
try
{
objConceptEN.ConceptId = objRow[conConcept.ConceptId].ToString().Trim(); //概念Id
objConceptEN.ConceptName = objRow[conConcept.ConceptName] == DBNull.Value ? null : objRow[conConcept.ConceptName].ToString().Trim(); //概念名称
objConceptEN.ConceptContent = objRow[conConcept.ConceptContent] == DBNull.Value ? null : objRow[conConcept.ConceptContent].ToString().Trim(); //概念内容
objConceptEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[conConcept.IsSubmit].ToString().Trim()); //是否提交
objConceptEN.UpdDate = objRow[conConcept.UpdDate] == DBNull.Value ? null : objRow[conConcept.UpdDate].ToString().Trim(); //修改日期
objConceptEN.Memo = objRow[conConcept.Memo] == DBNull.Value ? null : objRow[conConcept.Memo].ToString().Trim(); //备注
objConceptEN.CitationId = objRow[conConcept.CitationId] == DBNull.Value ? null : objRow[conConcept.CitationId].ToString().Trim(); //引用Id
objConceptEN.AppraiseCount = objRow[conConcept.AppraiseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conConcept.AppraiseCount].ToString().Trim()); //评论数
objConceptEN.OkCount = objRow[conConcept.OkCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conConcept.OkCount].ToString().Trim()); //点赞统计
objConceptEN.Score = objRow[conConcept.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conConcept.Score].ToString().Trim()); //评分
objConceptEN.StuScore = objRow[conConcept.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conConcept.StuScore].ToString().Trim()); //学生平均分
objConceptEN.TeaScore = objRow[conConcept.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conConcept.TeaScore].ToString().Trim()); //教师评分
objConceptEN.IdCurrEduCls = objRow[conConcept.IdCurrEduCls] == DBNull.Value ? null : objRow[conConcept.IdCurrEduCls].ToString().Trim(); //教学班流水号
objConceptEN.PdfContent = objRow[conConcept.PdfContent] == DBNull.Value ? null : objRow[conConcept.PdfContent].ToString().Trim(); //Pdf内容
objConceptEN.PdfPageNum = objRow[conConcept.PdfPageNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conConcept.PdfPageNum].ToString().Trim()); //Pdf页码
objConceptEN.CitationCount = objRow[conConcept.CitationCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conConcept.CitationCount].ToString().Trim()); //引用统计
objConceptEN.VersionCount = objRow[conConcept.VersionCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conConcept.VersionCount].ToString().Trim()); //版本统计
objConceptEN.CreateDate = objRow[conConcept.CreateDate] == DBNull.Value ? null : objRow[conConcept.CreateDate].ToString().Trim(); //建立日期
objConceptEN.ShareId = objRow[conConcept.ShareId].ToString().Trim(); //分享Id
objConceptEN.UpdUser = objRow[conConcept.UpdUser] == DBNull.Value ? null : objRow[conConcept.UpdUser].ToString().Trim(); //修改人
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objConceptEN.ConceptId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objConceptEN);
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
public static List<clsConceptEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsConceptEN> arrObjLst = new List<clsConceptEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsConceptEN objConceptEN = new clsConceptEN();
try
{
objConceptEN.ConceptId = objRow[conConcept.ConceptId].ToString().Trim(); //概念Id
objConceptEN.ConceptName = objRow[conConcept.ConceptName] == DBNull.Value ? null : objRow[conConcept.ConceptName].ToString().Trim(); //概念名称
objConceptEN.ConceptContent = objRow[conConcept.ConceptContent] == DBNull.Value ? null : objRow[conConcept.ConceptContent].ToString().Trim(); //概念内容
objConceptEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[conConcept.IsSubmit].ToString().Trim()); //是否提交
objConceptEN.UpdDate = objRow[conConcept.UpdDate] == DBNull.Value ? null : objRow[conConcept.UpdDate].ToString().Trim(); //修改日期
objConceptEN.Memo = objRow[conConcept.Memo] == DBNull.Value ? null : objRow[conConcept.Memo].ToString().Trim(); //备注
objConceptEN.CitationId = objRow[conConcept.CitationId] == DBNull.Value ? null : objRow[conConcept.CitationId].ToString().Trim(); //引用Id
objConceptEN.AppraiseCount = objRow[conConcept.AppraiseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conConcept.AppraiseCount].ToString().Trim()); //评论数
objConceptEN.OkCount = objRow[conConcept.OkCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conConcept.OkCount].ToString().Trim()); //点赞统计
objConceptEN.Score = objRow[conConcept.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conConcept.Score].ToString().Trim()); //评分
objConceptEN.StuScore = objRow[conConcept.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conConcept.StuScore].ToString().Trim()); //学生平均分
objConceptEN.TeaScore = objRow[conConcept.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conConcept.TeaScore].ToString().Trim()); //教师评分
objConceptEN.IdCurrEduCls = objRow[conConcept.IdCurrEduCls] == DBNull.Value ? null : objRow[conConcept.IdCurrEduCls].ToString().Trim(); //教学班流水号
objConceptEN.PdfContent = objRow[conConcept.PdfContent] == DBNull.Value ? null : objRow[conConcept.PdfContent].ToString().Trim(); //Pdf内容
objConceptEN.PdfPageNum = objRow[conConcept.PdfPageNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conConcept.PdfPageNum].ToString().Trim()); //Pdf页码
objConceptEN.CitationCount = objRow[conConcept.CitationCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conConcept.CitationCount].ToString().Trim()); //引用统计
objConceptEN.VersionCount = objRow[conConcept.VersionCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conConcept.VersionCount].ToString().Trim()); //版本统计
objConceptEN.CreateDate = objRow[conConcept.CreateDate] == DBNull.Value ? null : objRow[conConcept.CreateDate].ToString().Trim(); //建立日期
objConceptEN.ShareId = objRow[conConcept.ShareId].ToString().Trim(); //分享Id
objConceptEN.UpdUser = objRow[conConcept.UpdUser] == DBNull.Value ? null : objRow[conConcept.UpdUser].ToString().Trim(); //修改人
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objConceptEN.ConceptId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objConceptEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsConceptEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsConceptEN> arrObjLst = new List<clsConceptEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsConceptEN objConceptEN = new clsConceptEN();
try
{
objConceptEN.ConceptId = objRow[conConcept.ConceptId].ToString().Trim(); //概念Id
objConceptEN.ConceptName = objRow[conConcept.ConceptName] == DBNull.Value ? null : objRow[conConcept.ConceptName].ToString().Trim(); //概念名称
objConceptEN.ConceptContent = objRow[conConcept.ConceptContent] == DBNull.Value ? null : objRow[conConcept.ConceptContent].ToString().Trim(); //概念内容
objConceptEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[conConcept.IsSubmit].ToString().Trim()); //是否提交
objConceptEN.UpdDate = objRow[conConcept.UpdDate] == DBNull.Value ? null : objRow[conConcept.UpdDate].ToString().Trim(); //修改日期
objConceptEN.Memo = objRow[conConcept.Memo] == DBNull.Value ? null : objRow[conConcept.Memo].ToString().Trim(); //备注
objConceptEN.CitationId = objRow[conConcept.CitationId] == DBNull.Value ? null : objRow[conConcept.CitationId].ToString().Trim(); //引用Id
objConceptEN.AppraiseCount = objRow[conConcept.AppraiseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conConcept.AppraiseCount].ToString().Trim()); //评论数
objConceptEN.OkCount = objRow[conConcept.OkCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conConcept.OkCount].ToString().Trim()); //点赞统计
objConceptEN.Score = objRow[conConcept.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conConcept.Score].ToString().Trim()); //评分
objConceptEN.StuScore = objRow[conConcept.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conConcept.StuScore].ToString().Trim()); //学生平均分
objConceptEN.TeaScore = objRow[conConcept.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conConcept.TeaScore].ToString().Trim()); //教师评分
objConceptEN.IdCurrEduCls = objRow[conConcept.IdCurrEduCls] == DBNull.Value ? null : objRow[conConcept.IdCurrEduCls].ToString().Trim(); //教学班流水号
objConceptEN.PdfContent = objRow[conConcept.PdfContent] == DBNull.Value ? null : objRow[conConcept.PdfContent].ToString().Trim(); //Pdf内容
objConceptEN.PdfPageNum = objRow[conConcept.PdfPageNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conConcept.PdfPageNum].ToString().Trim()); //Pdf页码
objConceptEN.CitationCount = objRow[conConcept.CitationCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conConcept.CitationCount].ToString().Trim()); //引用统计
objConceptEN.VersionCount = objRow[conConcept.VersionCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conConcept.VersionCount].ToString().Trim()); //版本统计
objConceptEN.CreateDate = objRow[conConcept.CreateDate] == DBNull.Value ? null : objRow[conConcept.CreateDate].ToString().Trim(); //建立日期
objConceptEN.ShareId = objRow[conConcept.ShareId].ToString().Trim(); //分享Id
objConceptEN.UpdUser = objRow[conConcept.UpdUser] == DBNull.Value ? null : objRow[conConcept.UpdUser].ToString().Trim(); //修改人
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objConceptEN.ConceptId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objConceptEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objConceptEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetConcept(ref clsConceptEN objConceptEN)
{
bool bolResult = ConceptDA.GetConcept(ref objConceptEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "strConceptId">表关键字</param>
 /// <returns>表对象</returns>
public static clsConceptEN GetObjByConceptId(string strConceptId)
{
if (strConceptId.IndexOf(' ') >=0)
{
var strMsg = string.Format("(errid:Busi000079)在表中,关键字[strConceptId]中不能有空格!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
if (string.IsNullOrEmpty(strConceptId) == true)
{
var strMsg = string.Format("(errid:Busi000020)在表中,关键字[strConceptId]不能为空!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
clsConceptEN objConceptEN = ConceptDA.GetObjByConceptId(strConceptId);
return objConceptEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsConceptEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsConceptEN objConceptEN = ConceptDA.GetFirstObj(strWhereCond);
 return objConceptEN;
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
public static clsConceptEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsConceptEN objConceptEN = ConceptDA.GetObjByDataRow(objRow);
 return objConceptEN;
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
public static clsConceptEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsConceptEN objConceptEN = ConceptDA.GetObjByDataRow(objRow);
 return objConceptEN;
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
 /// <param name = "strConceptId">所给的关键字</param>
 /// <param name = "lstConceptObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsConceptEN GetObjByConceptIdFromList(string strConceptId, List<clsConceptEN> lstConceptObjLst)
{
foreach (clsConceptEN objConceptEN in lstConceptObjLst)
{
if (objConceptEN.ConceptId == strConceptId)
{
return objConceptEN;
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
 string strMaxConceptId;
 try
 {
 strMaxConceptId = clsConceptDA.GetMaxStrId();
 return strMaxConceptId;
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
 string strConceptId;
 try
 {
 strConceptId = new clsConceptDA().GetFirstID(strWhereCond);
 return strConceptId;
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
 arrList = ConceptDA.GetID(strWhereCond);
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
bool bolIsExist = ConceptDA.IsExistCondRec(strWhereCond);
return bolIsExist;
}

 /// <summary>
 /// 判断当前表中是否存在给定关键字值的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExist)
 /// </summary>
 /// <param name = "strConceptId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public static bool IsExist(string strConceptId)
{
if (string.IsNullOrEmpty(strConceptId) == true)
{
var strMsg = string.Format("(errid:Busi000027)在表中,关键字[strConceptId]不能为空!!(from {0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
//检测记录是否存在
bool bolIsExist = ConceptDA.IsExist(strConceptId);
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
 bolIsExist = clsConceptDA.IsExistTable();
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
 bolIsExist = ConceptDA.IsExistTable(strTabName);
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
 /// <param name = "objConceptEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecordBySql2(clsConceptEN objConceptEN, bool bolIsNeedCheckUniqueness=true)
{
if (bolIsNeedCheckUniqueness == true && objConceptEN.CheckUniqueness() == false)
{
var strMsg = string.Format("记录已经存在!教学班流水号 = [{0}],概念名称 = [{1}]的数据已经存在!(in clsConceptBL.AddNewRecordBySql2)", objConceptEN.IdCurrEduCls,objConceptEN.ConceptName);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objConceptEN.ConceptId) == true || clsConceptBL.IsExist(objConceptEN.ConceptId) == true)
 {
     objConceptEN.ConceptId = clsConceptBL.GetMaxStrId_S();
 }
bool bolResult = ConceptDA.AddNewRecordBySQL2(objConceptEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsConceptBL.ReFreshCache(objConceptEN.IdCurrEduCls);

if (clsConceptBL.relatedActions != null)
{
clsConceptBL.relatedActions.UpdRelaTabDate(objConceptEN.ConceptId, "SetUpdDate");
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
 /// <param name = "objConceptEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordBySql2WithReturnKey(clsConceptEN objConceptEN, bool bolIsNeedCheckUniqueness=true)
{
if (bolIsNeedCheckUniqueness == true && objConceptEN.CheckUniqueness() == false)
{
var strMsg = string.Format("记录已经存在!教学班流水号 = [{0}],概念名称 = [{1}]的数据已经存在!(in clsConceptBL.AddNewRecordBySql2WithReturnKey)", objConceptEN.IdCurrEduCls,objConceptEN.ConceptName);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objConceptEN.ConceptId) == true || clsConceptBL.IsExist(objConceptEN.ConceptId) == true)
 {
     objConceptEN.ConceptId = clsConceptBL.GetMaxStrId_S();
 }
string strKey = ConceptDA.AddNewRecordBySQL2WithReturnKey(objConceptEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsConceptBL.ReFreshCache(objConceptEN.IdCurrEduCls);

if (clsConceptBL.relatedActions != null)
{
clsConceptBL.relatedActions.UpdRelaTabDate(objConceptEN.ConceptId, "SetUpdDate");
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
 /// <param name = "objConceptEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(clsConceptEN objConceptEN)
{
try
{
bool bolResult = ConceptDA.Update(objConceptEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsConceptBL.ReFreshCache(objConceptEN.IdCurrEduCls);

if (clsConceptBL.relatedActions != null)
{
clsConceptBL.relatedActions.UpdRelaTabDate(objConceptEN.ConceptId, "SetUpdDate");
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
 /// <param name = "objConceptEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateBySql2(clsConceptEN objConceptEN)
{
 if (string.IsNullOrEmpty(objConceptEN.ConceptId) == true)
 {
var strMsg = string.Format("(errid:Busi000065)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = ConceptDA.UpdateBySql2(objConceptEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsConceptBL.ReFreshCache(objConceptEN.IdCurrEduCls);

if (clsConceptBL.relatedActions != null)
{
clsConceptBL.relatedActions.UpdRelaTabDate(objConceptEN.ConceptId, "SetUpdDate");
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
 /// <param name = "strConceptId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int DelRecord(string strConceptId)
{
try
{
 clsConceptEN objConceptEN = clsConceptBL.GetObjByConceptId(strConceptId);

if (clsConceptBL.relatedActions != null)
{
clsConceptBL.relatedActions.UpdRelaTabDate(objConceptEN.ConceptId, "SetUpdDate");
}
if (objConceptEN != null)
{
int intRecNum = ConceptDA.DelRecord(strConceptId);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
ReFreshCache(objConceptEN.IdCurrEduCls);
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
/// <param name="strConceptId">表关键字</param>
 /// <param name = "strIdCurrEduCls">缓存的分类字段</param>
/// <returns></returns>
public static bool DelRecordEx(string strConceptId , string strIdCurrEduCls)
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsConceptDA.GetSpecSQLObj();
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
//删除与表:[Concept]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conConcept.ConceptId,
//strConceptId);
//        clsConceptBL.DelConceptsByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsConceptBL.DelRecord(strConceptId, strIdCurrEduCls, objConnection, objSqlTransaction);
objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsConceptBLEx", "DelRecordEx", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("扩展删除记录出错:{0}!keyId = {1}.({2})",
objException.Message,
strConceptId, clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "strConceptId">给定的关键字值</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回删除是否成功?</returns>
public static bool DelRecord(string strConceptId, string strIdCurrEduCls, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
if (clsConceptBL.relatedActions != null)
{
clsConceptBL.relatedActions.UpdRelaTabDate(strConceptId, "UpdRelaTabDate");
}
bool bolResult = ConceptDA.DelRecord(strConceptId,objSqlConnection,objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
ReFreshCache(strIdCurrEduCls);
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
 /// <param name = "arrConceptIdLst">给定的关键字值列表</param>
 /// <returns>返回删除的记录数</returns>
public static int DelConcepts(List<string> arrConceptIdLst)
{
if (arrConceptIdLst.Count == 0) return 0;
try
{
if (clsConceptBL.relatedActions != null)
{
foreach (var strConceptId in arrConceptIdLst)
{
clsConceptBL.relatedActions.UpdRelaTabDate(strConceptId, "UpdRelaTabDate");
}
}
 clsConceptEN objConceptEN = clsConceptBL.GetObjByConceptId(arrConceptIdLst[0]);
int intDelRecNum = ConceptDA.DelConcept(arrConceptIdLst);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
ReFreshCache(objConceptEN.IdCurrEduCls);
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
public static int DelConceptsByCond(string strWhereCond)
{
try
{
if (clsConceptBL.relatedActions != null)
{
List<string> arrConceptId = GetPrimaryKeyID_S(strWhereCond);
foreach (var strConceptId in arrConceptId)
{
clsConceptBL.relatedActions.UpdRelaTabDate(strConceptId, "UpdRelaTabDate");
}
}
List<string> arrIdCurrEduCls = GetFldValue(conConcept.IdCurrEduCls, strWhereCond);
int intRecNum = ConceptDA.DelConcept(strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
arrIdCurrEduCls.ForEach(x => ReFreshCache(x));
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
/// 这里仅仅是演示函数,使用时请复制到扩展类:[Concept]中改名为:[DelRecord4MultiTabEx]使用
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DelRecord4MultiTab)
/// </summary>
/// <param name="strConceptId">表关键字</param>
 /// <param name = "strIdCurrEduCls">缓存的分类字段</param>
/// <returns></returns>
public static bool DelRecord4MultiTab(string strConceptId, string strIdCurrEduCls)
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsConceptDA.GetSpecSQLObj();
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
//删除与表:[Concept]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conStudent.id_College,
//strid_College);
//        clsStudentBL.DelStudentsByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsConceptBL.DelRecord(strConceptId, strIdCurrEduCls, objConnection, objSqlTransaction);
                objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsConceptBL", "DelRecord4MultiTab", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("删除多表记录出错:{0}!keyId = {1}.({2})",
objException.Message,
strConceptId, clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "objConceptENS">源对象</param>
 /// <param name = "objConceptENT">目标对象</param>
 public static void CopyTo(clsConceptEN objConceptENS, clsConceptEN objConceptENT)
{
try
{
objConceptENT.ConceptId = objConceptENS.ConceptId; //概念Id
objConceptENT.ConceptName = objConceptENS.ConceptName; //概念名称
objConceptENT.ConceptContent = objConceptENS.ConceptContent; //概念内容
objConceptENT.IsSubmit = objConceptENS.IsSubmit; //是否提交
objConceptENT.UpdDate = objConceptENS.UpdDate; //修改日期
objConceptENT.Memo = objConceptENS.Memo; //备注
objConceptENT.CitationId = objConceptENS.CitationId; //引用Id
objConceptENT.AppraiseCount = objConceptENS.AppraiseCount; //评论数
objConceptENT.OkCount = objConceptENS.OkCount; //点赞统计
objConceptENT.Score = objConceptENS.Score; //评分
objConceptENT.StuScore = objConceptENS.StuScore; //学生平均分
objConceptENT.TeaScore = objConceptENS.TeaScore; //教师评分
objConceptENT.IdCurrEduCls = objConceptENS.IdCurrEduCls; //教学班流水号
objConceptENT.PdfContent = objConceptENS.PdfContent; //Pdf内容
objConceptENT.PdfPageNum = objConceptENS.PdfPageNum; //Pdf页码
objConceptENT.CitationCount = objConceptENS.CitationCount; //引用统计
objConceptENT.VersionCount = objConceptENS.VersionCount; //版本统计
objConceptENT.CreateDate = objConceptENS.CreateDate; //建立日期
objConceptENT.ShareId = objConceptENS.ShareId; //分享Id
objConceptENT.UpdUser = objConceptENS.UpdUser; //修改人
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
 /// <param name = "objConceptEN">源简化对象</param>
 public static void SetUpdFlag(clsConceptEN objConceptEN)
{
try
{
objConceptEN.ClearUpdateState();
   string strsfUpdFldSetStr = objConceptEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(conConcept.ConceptId, new clsStrCompareIgnoreCase())  ==  true)
{
objConceptEN.ConceptId = objConceptEN.ConceptId; //概念Id
}
if (arrFldSet.Contains(conConcept.ConceptName, new clsStrCompareIgnoreCase())  ==  true)
{
objConceptEN.ConceptName = objConceptEN.ConceptName == "[null]" ? null :  objConceptEN.ConceptName; //概念名称
}
if (arrFldSet.Contains(conConcept.ConceptContent, new clsStrCompareIgnoreCase())  ==  true)
{
objConceptEN.ConceptContent = objConceptEN.ConceptContent == "[null]" ? null :  objConceptEN.ConceptContent; //概念内容
}
if (arrFldSet.Contains(conConcept.IsSubmit, new clsStrCompareIgnoreCase())  ==  true)
{
objConceptEN.IsSubmit = objConceptEN.IsSubmit; //是否提交
}
if (arrFldSet.Contains(conConcept.UpdDate, new clsStrCompareIgnoreCase())  ==  true)
{
objConceptEN.UpdDate = objConceptEN.UpdDate == "[null]" ? null :  objConceptEN.UpdDate; //修改日期
}
if (arrFldSet.Contains(conConcept.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objConceptEN.Memo = objConceptEN.Memo == "[null]" ? null :  objConceptEN.Memo; //备注
}
if (arrFldSet.Contains(conConcept.CitationId, new clsStrCompareIgnoreCase())  ==  true)
{
objConceptEN.CitationId = objConceptEN.CitationId == "[null]" ? null :  objConceptEN.CitationId; //引用Id
}
if (arrFldSet.Contains(conConcept.AppraiseCount, new clsStrCompareIgnoreCase())  ==  true)
{
objConceptEN.AppraiseCount = objConceptEN.AppraiseCount; //评论数
}
if (arrFldSet.Contains(conConcept.OkCount, new clsStrCompareIgnoreCase())  ==  true)
{
objConceptEN.OkCount = objConceptEN.OkCount; //点赞统计
}
if (arrFldSet.Contains(conConcept.Score, new clsStrCompareIgnoreCase())  ==  true)
{
objConceptEN.Score = objConceptEN.Score; //评分
}
if (arrFldSet.Contains(conConcept.StuScore, new clsStrCompareIgnoreCase())  ==  true)
{
objConceptEN.StuScore = objConceptEN.StuScore; //学生平均分
}
if (arrFldSet.Contains(conConcept.TeaScore, new clsStrCompareIgnoreCase())  ==  true)
{
objConceptEN.TeaScore = objConceptEN.TeaScore; //教师评分
}
if (arrFldSet.Contains(conConcept.IdCurrEduCls, new clsStrCompareIgnoreCase())  ==  true)
{
objConceptEN.IdCurrEduCls = objConceptEN.IdCurrEduCls == "[null]" ? null :  objConceptEN.IdCurrEduCls; //教学班流水号
}
if (arrFldSet.Contains(conConcept.PdfContent, new clsStrCompareIgnoreCase())  ==  true)
{
objConceptEN.PdfContent = objConceptEN.PdfContent == "[null]" ? null :  objConceptEN.PdfContent; //Pdf内容
}
if (arrFldSet.Contains(conConcept.PdfPageNum, new clsStrCompareIgnoreCase())  ==  true)
{
objConceptEN.PdfPageNum = objConceptEN.PdfPageNum; //Pdf页码
}
if (arrFldSet.Contains(conConcept.CitationCount, new clsStrCompareIgnoreCase())  ==  true)
{
objConceptEN.CitationCount = objConceptEN.CitationCount; //引用统计
}
if (arrFldSet.Contains(conConcept.VersionCount, new clsStrCompareIgnoreCase())  ==  true)
{
objConceptEN.VersionCount = objConceptEN.VersionCount; //版本统计
}
if (arrFldSet.Contains(conConcept.CreateDate, new clsStrCompareIgnoreCase())  ==  true)
{
objConceptEN.CreateDate = objConceptEN.CreateDate == "[null]" ? null :  objConceptEN.CreateDate; //建立日期
}
if (arrFldSet.Contains(conConcept.ShareId, new clsStrCompareIgnoreCase())  ==  true)
{
objConceptEN.ShareId = objConceptEN.ShareId; //分享Id
}
if (arrFldSet.Contains(conConcept.UpdUser, new clsStrCompareIgnoreCase())  ==  true)
{
objConceptEN.UpdUser = objConceptEN.UpdUser == "[null]" ? null :  objConceptEN.UpdUser; //修改人
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
 /// <param name = "objConceptEN">源简化对象</param>
 public static void AccessFldValueNull(clsConceptEN objConceptEN)
{
try
{
if (objConceptEN.ConceptName == "[null]") objConceptEN.ConceptName = null; //概念名称
if (objConceptEN.ConceptContent == "[null]") objConceptEN.ConceptContent = null; //概念内容
if (objConceptEN.UpdDate == "[null]") objConceptEN.UpdDate = null; //修改日期
if (objConceptEN.Memo == "[null]") objConceptEN.Memo = null; //备注
if (objConceptEN.CitationId == "[null]") objConceptEN.CitationId = null; //引用Id
if (objConceptEN.IdCurrEduCls == "[null]") objConceptEN.IdCurrEduCls = null; //教学班流水号
if (objConceptEN.PdfContent == "[null]") objConceptEN.PdfContent = null; //Pdf内容
if (objConceptEN.CreateDate == "[null]") objConceptEN.CreateDate = null; //建立日期
if (objConceptEN.UpdUser == "[null]") objConceptEN.UpdUser = null; //修改人
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
public static void CheckPropertyNew(clsConceptEN objConceptEN)
{
 ConceptDA.CheckPropertyNew(objConceptEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(clsConceptEN objConceptEN)
{
 ConceptDA.CheckProperty4Condition(objConceptEN);
 }


 #endregion 检查对象属性


 #region 绑定下拉框

 /// <summary>
 /// 绑定基于Web的下拉框-使用Cache
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DdlBindFunctionCache)
 /// </summary>
 /// <param name = "objDDL">需要绑定当前表的下拉框</param>
public static void BindDdl_ConceptIdCache(System.Web.UI.WebControls.DropDownList objDDL, string strIdCurrEduCls)
{
//为数据源于表的下拉框设置内容
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[观点概念]...","0");
List<clsConceptEN> arrConceptObjLst = GetAllConceptObjLstCache(strIdCurrEduCls); 
objDDL.DataValueField = conConcept.ConceptId;
objDDL.DataTextField = conConcept.ConceptName;
objDDL.DataSource = arrConceptObjLst;
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
if (clsConceptBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsConceptBL没有刷新缓存机制(clsConceptBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by ConceptId");
//if (arrConceptObjLstCache == null)
//{
//arrConceptObjLstCache = ConceptDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "strConceptId">所给的关键字</param>
 /// <param name = "strIdCurrEduCls">缓存的分类字段</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsConceptEN GetObjByConceptIdCache(string strConceptId, string strIdCurrEduCls)
{

if (string.IsNullOrEmpty(strIdCurrEduCls) == true)
{
  var strMsg = string.Format("参数:[strIdCurrEduCls]不能为空!(In {0})", clsStackTrace.GetCurrClassFunction());
clsSysParaEN.objLog.WriteDebugLog(strMsg);
 throw new Exception (strMsg);
}
if (strIdCurrEduCls.Length != 8)
{
var strMsg = string.Format("缓存分类变量:[strIdCurrEduCls]的长度:[{0}]不正确!(In {1})", strIdCurrEduCls.Length, clsStackTrace.GetCurrClassFunction());
clsSysParaEN.objLog.WriteDebugLog(strMsg);
 throw new Exception (strMsg);
}
//获取缓存中的对象列表
string strKey = string.Format("{0}_{1}", clsConceptEN._CurrTabName, strIdCurrEduCls);
List<clsConceptEN> arrConceptObjLstCache = GetObjLstCache(strIdCurrEduCls);
IEnumerable <clsConceptEN> arrConceptObjLst_Sel =
arrConceptObjLstCache
.Where(x=> x.ConceptId == strConceptId 
);
if (arrConceptObjLst_Sel.Count() == 0)
{
   clsConceptEN obj = clsConceptBL.GetObjByConceptId(strConceptId);
   if (obj != null)
 {
if (obj.IdCurrEduCls == strIdCurrEduCls)
{
CacheHelper.Remove(strKey);
     return obj;
}
else
{
string strMsg = string.Format("错误: 关键字:{0}不属于分类:{1},请检查!(In {2})", strConceptId, strIdCurrEduCls, clsStackTrace.GetCurrClassFunction());
clsSysParaEN.objLog.WriteDebugLog(strMsg);
throw new Exception(strMsg);
}
 }
return null;
}
return arrConceptObjLst_Sel.First();
}

 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecNameByKeyCache)
 /// </summary>
 /// <param name = "strConceptId">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetConceptNameByConceptIdCache(string strConceptId, string strIdCurrEduCls)
{
if (string.IsNullOrEmpty(strConceptId) == true) return "";
//获取缓存中的对象列表
clsConceptEN objConcept = GetObjByConceptIdCache(strConceptId, strIdCurrEduCls);
if (objConcept == null) return "";
return objConcept.ConceptName;
}
 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecNameByKeyCache)
 /// </summary>
 /// <param name = "strConceptId">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetNameByConceptIdCache(string strConceptId, string strIdCurrEduCls)
{
if (string.IsNullOrEmpty(strConceptId) == true) return "";
//获取缓存中的对象列表
clsConceptEN objConcept = GetObjByConceptIdCache(strConceptId, strIdCurrEduCls);
if (objConcept == null) return "";
return objConcept.ConceptName;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsConceptEN> GetAllConceptObjLstCache(string strIdCurrEduCls)
{
//获取缓存中的对象列表
List<clsConceptEN> arrConceptObjLstCache = GetObjLstCache(strIdCurrEduCls); 
return arrConceptObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsConceptEN> GetObjLstCache(string strIdCurrEduCls)
{

if (string.IsNullOrEmpty(strIdCurrEduCls) == true)
{
  var strMsg = string.Format("参数:[strIdCurrEduCls]不能为空!(In {0})", clsStackTrace.GetCurrClassFunction());
clsSysParaEN.objLog.WriteDebugLog(strMsg);
 throw new Exception (strMsg);
}
if (strIdCurrEduCls.Length != 8)
{
var strMsg = string.Format("缓存分类变量:[strIdCurrEduCls]的长度:[{0}]不正确!(In {1})", strIdCurrEduCls.Length, clsStackTrace.GetCurrClassFunction());
clsSysParaEN.objLog.WriteDebugLog(strMsg);
 throw new Exception (strMsg);
}
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}_{1}", clsConceptEN._CurrTabName, strIdCurrEduCls);
string strCondition = string.Format("IdCurrEduCls='{0}'", strIdCurrEduCls);
List<clsConceptEN> arrConceptObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst(strCondition); });
return arrConceptObjLstCache;
}

 /// <summary>
 /// 刷新本类中的缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ReFreshThisCache)
 /// </summary>
public static void ReFreshThisCache(string strIdCurrEduCls = "")
{
string strMsg;
if (clsSysParaEN.spSetRefreshCacheOn == true)
{
string strKey = string.Format("{0}_{1}", clsConceptEN._CurrTabName, strIdCurrEduCls);
CacheHelper.Remove(strKey);
clsConceptEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
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
if (clsConceptEN._RefreshTimeLst.Count == 0) return "";
return clsConceptEN._RefreshTimeLst[clsConceptEN._RefreshTimeLst.Count - 1];
}

 /// <summary>
 /// 刷新缓存.把当前表的缓存以及该表相关视图的缓存清空.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ReFreshCache)
 /// </summary>
public static void ReFreshCache(string strIdCurrEduCls)
{
if (string.IsNullOrEmpty(strIdCurrEduCls) == true)
{
string strMsg = string.Format("缓存分类字段:[IdCurrEduCls]不能为空!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsConceptBL.objCommFun4BL != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}_{1}", clsConceptEN._CurrTabName, strIdCurrEduCls);
CacheHelper.Remove(strKey);
clsConceptEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
clsConceptBL.objCommFun4BL.ReFreshCache(strIdCurrEduCls);
}
}


 #endregion 缓存操作


 #region 检查唯一性

 /// <summary>
 /// 获取检查唯一性条件串(Uniqueness)--Concept(观点概念)
 /// 唯一性条件:id_CurrEduCls_ConceptName
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetUniquenessConditionString)
 /// </summary>
 /// <param name = "objConceptEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(clsConceptEN objConceptEN)
{
//检测记录是否存在
string strResult = ConceptDA.GetUniCondStr(objConceptEN);
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
 /// <param name = "strIdCurrEduCls">缓存的分类字段</param>
 /// <returns>返回一个输出字段值</returns>
public static string Func(string strInFldName, string strOutFldName, string strConceptId, string strIdCurrEduCls)
{
if (strInFldName != conConcept.ConceptId)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (conConcept.AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", conConcept.AttributeName));
throw new Exception(strMsg);
}
var objConcept = clsConceptBL.GetObjByConceptIdCache(strConceptId, strIdCurrEduCls);
if (objConcept == null) return "";
return objConcept[strOutFldName].ToString();
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
int intRecCount = clsConceptDA.GetRecCount(strTabName);
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
int intRecCount = clsConceptDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsConceptDA.GetRecCount();
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
int intRecCount = clsConceptDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objConceptCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsConceptEN objConceptCond)
{
 string strIdCurrEduCls = objConceptCond.IdCurrEduCls;
 if (string.IsNullOrEmpty(strIdCurrEduCls) == true)
{
string strMsg = string.Format("(errid:Busi000174)在表中,缓存分类字段值不能为空!(clsConceptBL:GetRecCountByCondCache)");
throw new Exception(strMsg);
}
List<clsConceptEN> arrObjLstCache = GetObjLstCache(strIdCurrEduCls);
IEnumerable <clsConceptEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conConcept.AttributeName)
{
if (objConceptCond.IsUpdated(strFldName) == false) continue;
if (objConceptCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objConceptCond[strFldName].ToString());
}
else
{
if (objConceptCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objConceptCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objConceptCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objConceptCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objConceptCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objConceptCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objConceptCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objConceptCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objConceptCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objConceptCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objConceptCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objConceptCond[strFldName]));
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
 List<string> arrList = clsConceptDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = ConceptDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = ConceptDA.GetFldValueNoDistinct(strFldName, strWhereCond);
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
int intRecCount = ConceptDA.SetFldValue(strFldName, strValue, strWhereCond);
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
int intRecCount = clsConceptDA.SetFldValue(clsConceptEN._CurrTabName, strFldName, fltValue, strWhereCond);
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
int intRecCount = ConceptDA.SetFldValue( strFldName, intValue, strWhereCond);
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
int intRecCount = clsConceptDA.SetFldValue(strTabName, strFldName, strValue, strWhereCond);
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
int intRecCount = clsConceptDA.SetFldValue(strTabName, strFldName, intValue, strWhereCond);
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
int intRecCount = clsConceptDA.SetFldValue(strTabName, strFldName, fltValue, strWhereCond);
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
  strCreateTabCode.Append("CREATE table [dbo].[Concept] "); 
 strCreateTabCode.Append(" ( "); 
 // /**概念Id*/ 
 strCreateTabCode.Append(" ConceptId char(8) primary key, "); 
 // /**概念名称*/ 
 strCreateTabCode.Append(" ConceptName varchar(500) Null, "); 
 // /**概念内容*/ 
 strCreateTabCode.Append(" ConceptContent text Null, "); 
 // /**是否提交*/ 
 strCreateTabCode.Append(" IsSubmit bit Null, "); 
 // /**修改日期*/ 
 strCreateTabCode.Append(" UpdDate varchar(20) Null, "); 
 // /**备注*/ 
 strCreateTabCode.Append(" Memo varchar(1000) Null, "); 
 // /**引用Id*/ 
 strCreateTabCode.Append(" CitationId char(8) Null, "); 
 // /**评论数*/ 
 strCreateTabCode.Append(" AppraiseCount int Null, "); 
 // /**点赞统计*/ 
 strCreateTabCode.Append(" OkCount int Null, "); 
 // /**评分*/ 
 strCreateTabCode.Append(" Score float Null, "); 
 // /**学生平均分*/ 
 strCreateTabCode.Append(" StuScore float Null, "); 
 // /**教师评分*/ 
 strCreateTabCode.Append(" TeaScore float Null, "); 
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
 // /**建立日期*/ 
 strCreateTabCode.Append(" CreateDate varchar(20) Null, "); 
 // /**分享Id*/ 
 strCreateTabCode.Append(" ShareId char(2) not Null, "); 
 // /**修改人*/ 
 strCreateTabCode.Append(" UpdUser varchar(20) Null ");
 strCreateTabCode.Append(") "); 
  strCreateTabCode.Append("ON [PRIMARY] ");
  return strCreateTabCode.ToString();
}



 #endregion 表操作
}
 /// <summary>
 /// 观点概念(Concept)
 /// 数据源类型:表
 /// (AutoGCLib.CommFun4BL4CSharp:GeneCode_This)
 /// </summary>
public class  clsCommFun4BL4Concept : clsCommFun4BLV2
{

 /// <summary>
 /// 刷新缓存.把当前表的缓存以及该表相关视图的缓存清空.
 /// (AutoGCLib.CommFun4BL4CSharp:Gen_4CFBL_ReFreshCache)
 /// </summary>
public override void ReFreshCache(string strIdCurrEduCls)
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
clsConceptBL.ReFreshThisCache(strIdCurrEduCls);
}
}

}