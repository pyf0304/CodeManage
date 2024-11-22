
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clszx_ConceptBL
 表名:zx_Concept(01120709)
 * 版本:2023.11.15.1(服务器:WIN-SRV103-116)
 日期:2023/11/15 22:59:40
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:研究生学习游戏化后台(变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:中学生课件管理(ZXCourseware)
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
public static class  clszx_ConceptBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "strzxConceptId">表关键字</param>
 /// <returns>表对象</returns>
public static clszx_ConceptEN GetObj(this K_zxConceptId_zx_Concept myKey)
{
clszx_ConceptEN objzx_ConceptEN = clszx_ConceptBL.zx_ConceptDA.GetObjByzxConceptId(myKey.Value);
return objzx_ConceptEN;
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_AddNewRecord)
 /// </summary>
 /// <param name = "objzx_ConceptEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clszx_ConceptEN objzx_ConceptEN)
{
if (CheckUniqueness(objzx_ConceptEN) == false)
{
var strMsg = string.Format("记录已经存在!课件Id = [{0}]的数据已经存在!(in clszx_ConceptBL.AddNewRecord)", objzx_ConceptEN.TextId);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objzx_ConceptEN.zxConceptId) == true || clszx_ConceptBL.IsExist(objzx_ConceptEN.zxConceptId) == true)
 {
     objzx_ConceptEN.zxConceptId = clszx_ConceptBL.GetMaxStrId_S();
 }
bool bolResult = clszx_ConceptBL.zx_ConceptDA.AddNewRecordBySQL2(objzx_ConceptEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clszx_ConceptBL.ReFreshCache(objzx_ConceptEN.IdCurrEduCls);

if (clszx_ConceptBL.relatedActions != null)
{
clszx_ConceptBL.relatedActions.UpdRelaTabDate(objzx_ConceptEN.zxConceptId, "SetUpdDate");
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
public static bool AddRecordEx(this clszx_ConceptEN objzx_ConceptEN)
{
//操作步骤:
//1、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在
//2、检查唯一性
//3、检查传进去的对象属性是否合法
//4、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
//1、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在

//因为是字符型自增主键,不需要检查主键是否已经存在,在添加时,再获取 最大值作为主键
//if (clszx_ConceptBL.IsExist(objzx_ConceptEN.zxConceptId))	//判断是否有相同的关键字
//{
//strMsg = "(errid:Busi000151)关键字字段已有相同的值";
//throw new Exception(strMsg);
//}
try
{
 //2、检查传进去的对象属性是否合法
objzx_ConceptEN.CheckPropertyNew();
 ///5.2、检查唯一性
if (objzx_ConceptEN.CheckUniqueness() == false)
{
strMsg = string.Format("(课件Id(TextId)=[{0}])已经存在,不能重复!", objzx_ConceptEN.TextId);
throw new Exception(strMsg);
}
//因为是字符型自增主键,所以在添加时,自动获取主键值。
 if (string.IsNullOrEmpty(objzx_ConceptEN.zxConceptId) == true || clszx_ConceptBL.IsExist(objzx_ConceptEN.zxConceptId) == true)
 {
     objzx_ConceptEN.zxConceptId = clszx_ConceptBL.GetMaxStrId_S();
 }
//6、把数据实体层的数据存贮到数据库中
objzx_ConceptEN.AddNewRecord();
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
 /// <param name = "objzx_ConceptEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static string AddNewRecordWithMaxId(this clszx_ConceptEN objzx_ConceptEN)
{
if (CheckUniqueness(objzx_ConceptEN) == false)
{
var strMsg = string.Format("记录已经存在!课件Id = [{0}]的数据已经存在!(in clszx_ConceptBL.AddNewRecordWithMaxId)", objzx_ConceptEN.TextId);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objzx_ConceptEN.zxConceptId) == true || clszx_ConceptBL.IsExist(objzx_ConceptEN.zxConceptId) == true)
 {
     objzx_ConceptEN.zxConceptId = clszx_ConceptBL.GetMaxStrId_S();
 }
string strzxConceptId = clszx_ConceptBL.zx_ConceptDA.AddNewRecordBySQL2WithReturnKey(objzx_ConceptEN);
     objzx_ConceptEN.zxConceptId = strzxConceptId;
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clszx_ConceptBL.ReFreshCache(objzx_ConceptEN.IdCurrEduCls);

if (clszx_ConceptBL.relatedActions != null)
{
clszx_ConceptBL.relatedActions.UpdRelaTabDate(objzx_ConceptEN.zxConceptId, "SetUpdDate");
}
return strzxConceptId;
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
 /// <param name = "objzx_ConceptEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordWithReturnKey(this clszx_ConceptEN objzx_ConceptEN)
{
if (CheckUniqueness(objzx_ConceptEN) == false)
{
var strMsg = string.Format("记录已经存在!课件Id = [{0}]的数据已经存在!(in clszx_ConceptBL.AddNewRecordWithReturnKey)", objzx_ConceptEN.TextId);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objzx_ConceptEN.zxConceptId) == true || clszx_ConceptBL.IsExist(objzx_ConceptEN.zxConceptId) == true)
 {
     objzx_ConceptEN.zxConceptId = clszx_ConceptBL.GetMaxStrId_S();
 }
string strKey = clszx_ConceptBL.zx_ConceptDA.AddNewRecordBySQL2WithReturnKey(objzx_ConceptEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clszx_ConceptBL.ReFreshCache(objzx_ConceptEN.IdCurrEduCls);

if (clszx_ConceptBL.relatedActions != null)
{
clszx_ConceptBL.relatedActions.UpdRelaTabDate(objzx_ConceptEN.zxConceptId, "SetUpdDate");
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
 /// <param name = "objzx_ConceptEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clszx_ConceptEN SetzxConceptId(this clszx_ConceptEN objzx_ConceptEN, string strzxConceptId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strzxConceptId, 8, conzx_Concept.zxConceptId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strzxConceptId, 8, conzx_Concept.zxConceptId);
}
objzx_ConceptEN.zxConceptId = strzxConceptId; //概念Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objzx_ConceptEN.dicFldComparisonOp.ContainsKey(conzx_Concept.zxConceptId) == false)
{
objzx_ConceptEN.dicFldComparisonOp.Add(conzx_Concept.zxConceptId, strComparisonOp);
}
else
{
objzx_ConceptEN.dicFldComparisonOp[conzx_Concept.zxConceptId] = strComparisonOp;
}
}
return objzx_ConceptEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objzx_ConceptEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clszx_ConceptEN SetConceptName(this clszx_ConceptEN objzx_ConceptEN, string strConceptName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strConceptName, 500, conzx_Concept.ConceptName);
}
objzx_ConceptEN.ConceptName = strConceptName; //概念名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objzx_ConceptEN.dicFldComparisonOp.ContainsKey(conzx_Concept.ConceptName) == false)
{
objzx_ConceptEN.dicFldComparisonOp.Add(conzx_Concept.ConceptName, strComparisonOp);
}
else
{
objzx_ConceptEN.dicFldComparisonOp[conzx_Concept.ConceptName] = strComparisonOp;
}
}
return objzx_ConceptEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objzx_ConceptEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clszx_ConceptEN SetConceptContent(this clszx_ConceptEN objzx_ConceptEN, string strConceptContent, string strComparisonOp="")
	{
objzx_ConceptEN.ConceptContent = strConceptContent; //概念内容
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objzx_ConceptEN.dicFldComparisonOp.ContainsKey(conzx_Concept.ConceptContent) == false)
{
objzx_ConceptEN.dicFldComparisonOp.Add(conzx_Concept.ConceptContent, strComparisonOp);
}
else
{
objzx_ConceptEN.dicFldComparisonOp[conzx_Concept.ConceptContent] = strComparisonOp;
}
}
return objzx_ConceptEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objzx_ConceptEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clszx_ConceptEN SetTextId(this clszx_ConceptEN objzx_ConceptEN, string strTextId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTextId, 8, conzx_Concept.TextId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strTextId, 8, conzx_Concept.TextId);
}
objzx_ConceptEN.TextId = strTextId; //课件Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objzx_ConceptEN.dicFldComparisonOp.ContainsKey(conzx_Concept.TextId) == false)
{
objzx_ConceptEN.dicFldComparisonOp.Add(conzx_Concept.TextId, strComparisonOp);
}
else
{
objzx_ConceptEN.dicFldComparisonOp[conzx_Concept.TextId] = strComparisonOp;
}
}
return objzx_ConceptEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objzx_ConceptEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clszx_ConceptEN SetIsSubmit(this clszx_ConceptEN objzx_ConceptEN, bool bolIsSubmit, string strComparisonOp="")
	{
objzx_ConceptEN.IsSubmit = bolIsSubmit; //是否提交
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objzx_ConceptEN.dicFldComparisonOp.ContainsKey(conzx_Concept.IsSubmit) == false)
{
objzx_ConceptEN.dicFldComparisonOp.Add(conzx_Concept.IsSubmit, strComparisonOp);
}
else
{
objzx_ConceptEN.dicFldComparisonOp[conzx_Concept.IsSubmit] = strComparisonOp;
}
}
return objzx_ConceptEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objzx_ConceptEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clszx_ConceptEN SetVoteCount(this clszx_ConceptEN objzx_ConceptEN, int? intVoteCount, string strComparisonOp="")
	{
objzx_ConceptEN.VoteCount = intVoteCount; //点赞计数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objzx_ConceptEN.dicFldComparisonOp.ContainsKey(conzx_Concept.VoteCount) == false)
{
objzx_ConceptEN.dicFldComparisonOp.Add(conzx_Concept.VoteCount, strComparisonOp);
}
else
{
objzx_ConceptEN.dicFldComparisonOp[conzx_Concept.VoteCount] = strComparisonOp;
}
}
return objzx_ConceptEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objzx_ConceptEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clszx_ConceptEN SetAppraiseCount(this clszx_ConceptEN objzx_ConceptEN, int? intAppraiseCount, string strComparisonOp="")
	{
objzx_ConceptEN.AppraiseCount = intAppraiseCount; //评论数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objzx_ConceptEN.dicFldComparisonOp.ContainsKey(conzx_Concept.AppraiseCount) == false)
{
objzx_ConceptEN.dicFldComparisonOp.Add(conzx_Concept.AppraiseCount, strComparisonOp);
}
else
{
objzx_ConceptEN.dicFldComparisonOp[conzx_Concept.AppraiseCount] = strComparisonOp;
}
}
return objzx_ConceptEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objzx_ConceptEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clszx_ConceptEN SetScore(this clszx_ConceptEN objzx_ConceptEN, float? fltScore, string strComparisonOp="")
	{
objzx_ConceptEN.Score = fltScore; //评分
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objzx_ConceptEN.dicFldComparisonOp.ContainsKey(conzx_Concept.Score) == false)
{
objzx_ConceptEN.dicFldComparisonOp.Add(conzx_Concept.Score, strComparisonOp);
}
else
{
objzx_ConceptEN.dicFldComparisonOp[conzx_Concept.Score] = strComparisonOp;
}
}
return objzx_ConceptEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objzx_ConceptEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clszx_ConceptEN SetStuScore(this clszx_ConceptEN objzx_ConceptEN, float? fltStuScore, string strComparisonOp="")
	{
objzx_ConceptEN.StuScore = fltStuScore; //学生平均分
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objzx_ConceptEN.dicFldComparisonOp.ContainsKey(conzx_Concept.StuScore) == false)
{
objzx_ConceptEN.dicFldComparisonOp.Add(conzx_Concept.StuScore, strComparisonOp);
}
else
{
objzx_ConceptEN.dicFldComparisonOp[conzx_Concept.StuScore] = strComparisonOp;
}
}
return objzx_ConceptEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objzx_ConceptEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clszx_ConceptEN SetTeaScore(this clszx_ConceptEN objzx_ConceptEN, float? fltTeaScore, string strComparisonOp="")
	{
objzx_ConceptEN.TeaScore = fltTeaScore; //教师评分
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objzx_ConceptEN.dicFldComparisonOp.ContainsKey(conzx_Concept.TeaScore) == false)
{
objzx_ConceptEN.dicFldComparisonOp.Add(conzx_Concept.TeaScore, strComparisonOp);
}
else
{
objzx_ConceptEN.dicFldComparisonOp[conzx_Concept.TeaScore] = strComparisonOp;
}
}
return objzx_ConceptEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objzx_ConceptEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clszx_ConceptEN SetIdCurrEduCls(this clszx_ConceptEN objzx_ConceptEN, string strIdCurrEduCls, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdCurrEduCls, 8, conzx_Concept.IdCurrEduCls);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdCurrEduCls, 8, conzx_Concept.IdCurrEduCls);
}
objzx_ConceptEN.IdCurrEduCls = strIdCurrEduCls; //教学班流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objzx_ConceptEN.dicFldComparisonOp.ContainsKey(conzx_Concept.IdCurrEduCls) == false)
{
objzx_ConceptEN.dicFldComparisonOp.Add(conzx_Concept.IdCurrEduCls, strComparisonOp);
}
else
{
objzx_ConceptEN.dicFldComparisonOp[conzx_Concept.IdCurrEduCls] = strComparisonOp;
}
}
return objzx_ConceptEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objzx_ConceptEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clszx_ConceptEN SetPdfContent(this clszx_ConceptEN objzx_ConceptEN, string strPdfContent, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPdfContent, 2000, conzx_Concept.PdfContent);
}
objzx_ConceptEN.PdfContent = strPdfContent; //Pdf内容
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objzx_ConceptEN.dicFldComparisonOp.ContainsKey(conzx_Concept.PdfContent) == false)
{
objzx_ConceptEN.dicFldComparisonOp.Add(conzx_Concept.PdfContent, strComparisonOp);
}
else
{
objzx_ConceptEN.dicFldComparisonOp[conzx_Concept.PdfContent] = strComparisonOp;
}
}
return objzx_ConceptEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objzx_ConceptEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clszx_ConceptEN SetPdfPageNum(this clszx_ConceptEN objzx_ConceptEN, int? intPdfPageNum, string strComparisonOp="")
	{
objzx_ConceptEN.PdfPageNum = intPdfPageNum; //Pdf页码
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objzx_ConceptEN.dicFldComparisonOp.ContainsKey(conzx_Concept.PdfPageNum) == false)
{
objzx_ConceptEN.dicFldComparisonOp.Add(conzx_Concept.PdfPageNum, strComparisonOp);
}
else
{
objzx_ConceptEN.dicFldComparisonOp[conzx_Concept.PdfPageNum] = strComparisonOp;
}
}
return objzx_ConceptEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objzx_ConceptEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clszx_ConceptEN SetCitationCount(this clszx_ConceptEN objzx_ConceptEN, int? intCitationCount, string strComparisonOp="")
	{
objzx_ConceptEN.CitationCount = intCitationCount; //引用统计
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objzx_ConceptEN.dicFldComparisonOp.ContainsKey(conzx_Concept.CitationCount) == false)
{
objzx_ConceptEN.dicFldComparisonOp.Add(conzx_Concept.CitationCount, strComparisonOp);
}
else
{
objzx_ConceptEN.dicFldComparisonOp[conzx_Concept.CitationCount] = strComparisonOp;
}
}
return objzx_ConceptEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objzx_ConceptEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clszx_ConceptEN SetVersionCount(this clszx_ConceptEN objzx_ConceptEN, int? intVersionCount, string strComparisonOp="")
	{
objzx_ConceptEN.VersionCount = intVersionCount; //版本统计
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objzx_ConceptEN.dicFldComparisonOp.ContainsKey(conzx_Concept.VersionCount) == false)
{
objzx_ConceptEN.dicFldComparisonOp.Add(conzx_Concept.VersionCount, strComparisonOp);
}
else
{
objzx_ConceptEN.dicFldComparisonOp[conzx_Concept.VersionCount] = strComparisonOp;
}
}
return objzx_ConceptEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objzx_ConceptEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clszx_ConceptEN SetzxShareId(this clszx_ConceptEN objzx_ConceptEN, string strzxShareId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strzxShareId, conzx_Concept.zxShareId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strzxShareId, 2, conzx_Concept.zxShareId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strzxShareId, 2, conzx_Concept.zxShareId);
}
objzx_ConceptEN.zxShareId = strzxShareId; //分享Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objzx_ConceptEN.dicFldComparisonOp.ContainsKey(conzx_Concept.zxShareId) == false)
{
objzx_ConceptEN.dicFldComparisonOp.Add(conzx_Concept.zxShareId, strComparisonOp);
}
else
{
objzx_ConceptEN.dicFldComparisonOp[conzx_Concept.zxShareId] = strComparisonOp;
}
}
return objzx_ConceptEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objzx_ConceptEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clszx_ConceptEN SetCreateDate(this clszx_ConceptEN objzx_ConceptEN, string strCreateDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCreateDate, 20, conzx_Concept.CreateDate);
}
objzx_ConceptEN.CreateDate = strCreateDate; //建立日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objzx_ConceptEN.dicFldComparisonOp.ContainsKey(conzx_Concept.CreateDate) == false)
{
objzx_ConceptEN.dicFldComparisonOp.Add(conzx_Concept.CreateDate, strComparisonOp);
}
else
{
objzx_ConceptEN.dicFldComparisonOp[conzx_Concept.CreateDate] = strComparisonOp;
}
}
return objzx_ConceptEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objzx_ConceptEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clszx_ConceptEN SetUpdDate(this clszx_ConceptEN objzx_ConceptEN, string strUpdDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdDate, 20, conzx_Concept.UpdDate);
}
objzx_ConceptEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objzx_ConceptEN.dicFldComparisonOp.ContainsKey(conzx_Concept.UpdDate) == false)
{
objzx_ConceptEN.dicFldComparisonOp.Add(conzx_Concept.UpdDate, strComparisonOp);
}
else
{
objzx_ConceptEN.dicFldComparisonOp[conzx_Concept.UpdDate] = strComparisonOp;
}
}
return objzx_ConceptEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objzx_ConceptEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clszx_ConceptEN SetUpdUser(this clszx_ConceptEN objzx_ConceptEN, string strUpdUser, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdUser, 20, conzx_Concept.UpdUser);
}
objzx_ConceptEN.UpdUser = strUpdUser; //修改人
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objzx_ConceptEN.dicFldComparisonOp.ContainsKey(conzx_Concept.UpdUser) == false)
{
objzx_ConceptEN.dicFldComparisonOp.Add(conzx_Concept.UpdUser, strComparisonOp);
}
else
{
objzx_ConceptEN.dicFldComparisonOp[conzx_Concept.UpdUser] = strComparisonOp;
}
}
return objzx_ConceptEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objzx_ConceptEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clszx_ConceptEN SetMemo(this clszx_ConceptEN objzx_ConceptEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, conzx_Concept.Memo);
}
objzx_ConceptEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objzx_ConceptEN.dicFldComparisonOp.ContainsKey(conzx_Concept.Memo) == false)
{
objzx_ConceptEN.dicFldComparisonOp.Add(conzx_Concept.Memo, strComparisonOp);
}
else
{
objzx_ConceptEN.dicFldComparisonOp[conzx_Concept.Memo] = strComparisonOp;
}
}
return objzx_ConceptEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objzx_ConceptEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clszx_ConceptEN SetPdfDivLet(this clszx_ConceptEN objzx_ConceptEN, string strPdfDivLet, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPdfDivLet, 50, conzx_Concept.PdfDivLet);
}
objzx_ConceptEN.PdfDivLet = strPdfDivLet; //PdfDivLet
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objzx_ConceptEN.dicFldComparisonOp.ContainsKey(conzx_Concept.PdfDivLet) == false)
{
objzx_ConceptEN.dicFldComparisonOp.Add(conzx_Concept.PdfDivLet, strComparisonOp);
}
else
{
objzx_ConceptEN.dicFldComparisonOp[conzx_Concept.PdfDivLet] = strComparisonOp;
}
}
return objzx_ConceptEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objzx_ConceptEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clszx_ConceptEN SetPdfDivTop(this clszx_ConceptEN objzx_ConceptEN, string strPdfDivTop, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPdfDivTop, 50, conzx_Concept.PdfDivTop);
}
objzx_ConceptEN.PdfDivTop = strPdfDivTop; //PdfDivTop
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objzx_ConceptEN.dicFldComparisonOp.ContainsKey(conzx_Concept.PdfDivTop) == false)
{
objzx_ConceptEN.dicFldComparisonOp.Add(conzx_Concept.PdfDivTop, strComparisonOp);
}
else
{
objzx_ConceptEN.dicFldComparisonOp[conzx_Concept.PdfDivTop] = strComparisonOp;
}
}
return objzx_ConceptEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objzx_ConceptEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clszx_ConceptEN SetPdfPageNumIn(this clszx_ConceptEN objzx_ConceptEN, string strPdfPageNumIn, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPdfPageNumIn, 50, conzx_Concept.PdfPageNumIn);
}
objzx_ConceptEN.PdfPageNumIn = strPdfPageNumIn; //PdfPageNumIn
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objzx_ConceptEN.dicFldComparisonOp.ContainsKey(conzx_Concept.PdfPageNumIn) == false)
{
objzx_ConceptEN.dicFldComparisonOp.Add(conzx_Concept.PdfPageNumIn, strComparisonOp);
}
else
{
objzx_ConceptEN.dicFldComparisonOp[conzx_Concept.PdfPageNumIn] = strComparisonOp;
}
}
return objzx_ConceptEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objzx_ConceptEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clszx_ConceptEN SetPdfPageTop(this clszx_ConceptEN objzx_ConceptEN, int? intPdfPageTop, string strComparisonOp="")
	{
objzx_ConceptEN.PdfPageTop = intPdfPageTop; //pdf页面顶部位置
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objzx_ConceptEN.dicFldComparisonOp.ContainsKey(conzx_Concept.PdfPageTop) == false)
{
objzx_ConceptEN.dicFldComparisonOp.Add(conzx_Concept.PdfPageTop, strComparisonOp);
}
else
{
objzx_ConceptEN.dicFldComparisonOp[conzx_Concept.PdfPageTop] = strComparisonOp;
}
}
return objzx_ConceptEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objzx_ConceptEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clszx_ConceptEN SetPdfZoom(this clszx_ConceptEN objzx_ConceptEN, string strPdfZoom, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPdfZoom, 50, conzx_Concept.PdfZoom);
}
objzx_ConceptEN.PdfZoom = strPdfZoom; //PdfZoom
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objzx_ConceptEN.dicFldComparisonOp.ContainsKey(conzx_Concept.PdfZoom) == false)
{
objzx_ConceptEN.dicFldComparisonOp.Add(conzx_Concept.PdfZoom, strComparisonOp);
}
else
{
objzx_ConceptEN.dicFldComparisonOp[conzx_Concept.PdfZoom] = strComparisonOp;
}
}
return objzx_ConceptEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objzx_ConceptEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clszx_ConceptEN SetGroupTextId(this clszx_ConceptEN objzx_ConceptEN, string strGroupTextId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strGroupTextId, 8, conzx_Concept.GroupTextId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strGroupTextId, 8, conzx_Concept.GroupTextId);
}
objzx_ConceptEN.GroupTextId = strGroupTextId; //小组Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objzx_ConceptEN.dicFldComparisonOp.ContainsKey(conzx_Concept.GroupTextId) == false)
{
objzx_ConceptEN.dicFldComparisonOp.Add(conzx_Concept.GroupTextId, strComparisonOp);
}
else
{
objzx_ConceptEN.dicFldComparisonOp[conzx_Concept.GroupTextId] = strComparisonOp;
}
}
return objzx_ConceptEN;
	}

 /// <summary>
 /// 修改记录存盘到数据表中
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_UpdateRecordEx)
 /// </summary>
 /// <param name = "objzx_ConceptEN">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool UpdateRecordEx(this clszx_ConceptEN objzx_ConceptEN)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
try
{
//1、检查传进去的对象属性是否合法
objzx_ConceptEN.CheckPropertyNew();
clszx_ConceptEN objzx_ConceptCond = new clszx_ConceptEN();
string strCondition = objzx_ConceptCond
.SetzxConceptId(objzx_ConceptEN.zxConceptId, "<>")
.SetTextId(objzx_ConceptEN.TextId, "=")
.GetCombineCondition();
objzx_ConceptEN._IsCheckProperty = true;
bool bolIsExist = clszx_ConceptBL.IsExistRecord(strCondition);
if (bolIsExist)
{
strMsg = "(TextId)不能重复!";
throw new Exception(strMsg);
}
//4、把数据实体层的数据存贮到数据库中
objzx_ConceptEN.Update();
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
 /// <param name = "objzx_Concept">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool EditRecordEx(this clszx_ConceptEN objzx_Concept)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
clszx_ConceptEN objzx_ConceptCond = new clszx_ConceptEN();
string strCondition = objzx_ConceptCond
.SetTextId(objzx_Concept.TextId, "=")
.GetCombineCondition();
objzx_Concept._IsCheckProperty = true;
bool bolIsExist = clszx_ConceptBL.IsExistRecord(strCondition);
if (bolIsExist)
{
objzx_Concept.zxConceptId = clszx_ConceptBL.GetFirstID_S(strCondition);
objzx_Concept.UpdateWithCondition(strCondition);
}
else
{
objzx_Concept.zxConceptId = clszx_ConceptBL.GetMaxStrId_S();
objzx_Concept.AddNewRecord();
}
return true; 
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_Update)
 /// </summary>
 /// <param name = "objzx_ConceptEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clszx_ConceptEN objzx_ConceptEN)
{
 if (string.IsNullOrEmpty(objzx_ConceptEN.zxConceptId) == true)
 {
string strMsg = string.Format("(errid:Busi000095)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clszx_ConceptBL.zx_ConceptDA.UpdateBySql2(objzx_ConceptEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clszx_ConceptBL.ReFreshCache(objzx_ConceptEN.IdCurrEduCls);

if (clszx_ConceptBL.relatedActions != null)
{
clszx_ConceptBL.relatedActions.UpdRelaTabDate(objzx_ConceptEN.zxConceptId, "SetUpdDate");
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
 /// <param name = "objzx_ConceptEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clszx_ConceptEN objzx_ConceptEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (string.IsNullOrEmpty(objzx_ConceptEN.zxConceptId) == true)
 {
string strMsg = string.Format("(errid:Busi000087)修改记录时关键字不能为空!(带事务处理)(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clszx_ConceptBL.zx_ConceptDA.UpdateBySql2(objzx_ConceptEN, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clszx_ConceptBL.ReFreshCache(objzx_ConceptEN.IdCurrEduCls);

if (clszx_ConceptBL.relatedActions != null)
{
clszx_ConceptBL.relatedActions.UpdRelaTabDate(objzx_ConceptEN.zxConceptId, "SetUpdDate");
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
 /// <param name = "objzx_ConceptEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clszx_ConceptEN objzx_ConceptEN, string strWhereCond)
{
try
{
bool bolResult = clszx_ConceptBL.zx_ConceptDA.UpdateBySqlWithCondition(objzx_ConceptEN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clszx_ConceptBL.ReFreshCache(objzx_ConceptEN.IdCurrEduCls);

if (clszx_ConceptBL.relatedActions != null)
{
clszx_ConceptBL.relatedActions.UpdRelaTabDate(objzx_ConceptEN.zxConceptId, "SetUpdDate");
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
 /// <param name = "objzx_ConceptEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clszx_ConceptEN objzx_ConceptEN, string strWhereCond, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
bool bolResult = clszx_ConceptBL.zx_ConceptDA.UpdateBySqlWithConditionTransaction(objzx_ConceptEN, strWhereCond, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clszx_ConceptBL.ReFreshCache(objzx_ConceptEN.IdCurrEduCls);

if (clszx_ConceptBL.relatedActions != null)
{
clszx_ConceptBL.relatedActions.UpdRelaTabDate(objzx_ConceptEN.zxConceptId, "SetUpdDate");
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
 /// <param name = "strzxConceptId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int Delete(this clszx_ConceptEN objzx_ConceptEN)
{
try
{
int intRecNum = clszx_ConceptBL.zx_ConceptDA.DelRecord(objzx_ConceptEN.zxConceptId);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clszx_ConceptBL.ReFreshCache(objzx_ConceptEN.IdCurrEduCls);

if (clszx_ConceptBL.relatedActions != null)
{
clszx_ConceptBL.relatedActions.UpdRelaTabDate(objzx_ConceptEN.zxConceptId, "SetUpdDate");
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
 /// <param name = "objzx_ConceptENS">源对象</param>
 /// <param name = "objzx_ConceptENT">目标对象</param>
 public static void CopyTo(this clszx_ConceptEN objzx_ConceptENS, clszx_ConceptEN objzx_ConceptENT)
{
try
{
objzx_ConceptENT.zxConceptId = objzx_ConceptENS.zxConceptId; //概念Id
objzx_ConceptENT.ConceptName = objzx_ConceptENS.ConceptName; //概念名称
objzx_ConceptENT.ConceptContent = objzx_ConceptENS.ConceptContent; //概念内容
objzx_ConceptENT.TextId = objzx_ConceptENS.TextId; //课件Id
objzx_ConceptENT.IsSubmit = objzx_ConceptENS.IsSubmit; //是否提交
objzx_ConceptENT.VoteCount = objzx_ConceptENS.VoteCount; //点赞计数
objzx_ConceptENT.AppraiseCount = objzx_ConceptENS.AppraiseCount; //评论数
objzx_ConceptENT.Score = objzx_ConceptENS.Score; //评分
objzx_ConceptENT.StuScore = objzx_ConceptENS.StuScore; //学生平均分
objzx_ConceptENT.TeaScore = objzx_ConceptENS.TeaScore; //教师评分
objzx_ConceptENT.IdCurrEduCls = objzx_ConceptENS.IdCurrEduCls; //教学班流水号
objzx_ConceptENT.PdfContent = objzx_ConceptENS.PdfContent; //Pdf内容
objzx_ConceptENT.PdfPageNum = objzx_ConceptENS.PdfPageNum; //Pdf页码
objzx_ConceptENT.CitationCount = objzx_ConceptENS.CitationCount; //引用统计
objzx_ConceptENT.VersionCount = objzx_ConceptENS.VersionCount; //版本统计
objzx_ConceptENT.zxShareId = objzx_ConceptENS.zxShareId; //分享Id
objzx_ConceptENT.CreateDate = objzx_ConceptENS.CreateDate; //建立日期
objzx_ConceptENT.UpdDate = objzx_ConceptENS.UpdDate; //修改日期
objzx_ConceptENT.UpdUser = objzx_ConceptENS.UpdUser; //修改人
objzx_ConceptENT.Memo = objzx_ConceptENS.Memo; //备注
objzx_ConceptENT.PdfDivLet = objzx_ConceptENS.PdfDivLet; //PdfDivLet
objzx_ConceptENT.PdfDivTop = objzx_ConceptENS.PdfDivTop; //PdfDivTop
objzx_ConceptENT.PdfPageNumIn = objzx_ConceptENS.PdfPageNumIn; //PdfPageNumIn
objzx_ConceptENT.PdfPageTop = objzx_ConceptENS.PdfPageTop; //pdf页面顶部位置
objzx_ConceptENT.PdfZoom = objzx_ConceptENS.PdfZoom; //PdfZoom
objzx_ConceptENT.GroupTextId = objzx_ConceptENS.GroupTextId; //小组Id
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
 /// <param name = "objzx_ConceptENS">源对象</param>
 /// <returns>目标对象=>clszx_ConceptEN:objzx_ConceptENT</returns>
 public static clszx_ConceptEN CopyTo(this clszx_ConceptEN objzx_ConceptENS)
{
try
{
 clszx_ConceptEN objzx_ConceptENT = new clszx_ConceptEN()
{
zxConceptId = objzx_ConceptENS.zxConceptId, //概念Id
ConceptName = objzx_ConceptENS.ConceptName, //概念名称
ConceptContent = objzx_ConceptENS.ConceptContent, //概念内容
TextId = objzx_ConceptENS.TextId, //课件Id
IsSubmit = objzx_ConceptENS.IsSubmit, //是否提交
VoteCount = objzx_ConceptENS.VoteCount, //点赞计数
AppraiseCount = objzx_ConceptENS.AppraiseCount, //评论数
Score = objzx_ConceptENS.Score, //评分
StuScore = objzx_ConceptENS.StuScore, //学生平均分
TeaScore = objzx_ConceptENS.TeaScore, //教师评分
IdCurrEduCls = objzx_ConceptENS.IdCurrEduCls, //教学班流水号
PdfContent = objzx_ConceptENS.PdfContent, //Pdf内容
PdfPageNum = objzx_ConceptENS.PdfPageNum, //Pdf页码
CitationCount = objzx_ConceptENS.CitationCount, //引用统计
VersionCount = objzx_ConceptENS.VersionCount, //版本统计
zxShareId = objzx_ConceptENS.zxShareId, //分享Id
CreateDate = objzx_ConceptENS.CreateDate, //建立日期
UpdDate = objzx_ConceptENS.UpdDate, //修改日期
UpdUser = objzx_ConceptENS.UpdUser, //修改人
Memo = objzx_ConceptENS.Memo, //备注
PdfDivLet = objzx_ConceptENS.PdfDivLet, //PdfDivLet
PdfDivTop = objzx_ConceptENS.PdfDivTop, //PdfDivTop
PdfPageNumIn = objzx_ConceptENS.PdfPageNumIn, //PdfPageNumIn
PdfPageTop = objzx_ConceptENS.PdfPageTop, //pdf页面顶部位置
PdfZoom = objzx_ConceptENS.PdfZoom, //PdfZoom
GroupTextId = objzx_ConceptENS.GroupTextId, //小组Id
};
 return objzx_ConceptENT;
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
public static void CheckPropertyNew(this clszx_ConceptEN objzx_ConceptEN)
{
 clszx_ConceptBL.zx_ConceptDA.CheckPropertyNew(objzx_ConceptEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(this clszx_ConceptEN objzx_ConceptEN)
{
 clszx_ConceptBL.zx_ConceptDA.CheckProperty4Condition(objzx_ConceptEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clszx_ConceptEN objzx_ConceptCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objzx_ConceptCond.IsUpdated(conzx_Concept.zxConceptId) == true)
{
string strComparisonOpzxConceptId = objzx_ConceptCond.dicFldComparisonOp[conzx_Concept.zxConceptId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conzx_Concept.zxConceptId, objzx_ConceptCond.zxConceptId, strComparisonOpzxConceptId);
}
if (objzx_ConceptCond.IsUpdated(conzx_Concept.ConceptName) == true)
{
string strComparisonOpConceptName = objzx_ConceptCond.dicFldComparisonOp[conzx_Concept.ConceptName];
strWhereCond += string.Format(" And {0} {2} '{1}'", conzx_Concept.ConceptName, objzx_ConceptCond.ConceptName, strComparisonOpConceptName);
}
//数据类型string(text)在函数:[AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj]中没有处理!
if (objzx_ConceptCond.IsUpdated(conzx_Concept.TextId) == true)
{
string strComparisonOpTextId = objzx_ConceptCond.dicFldComparisonOp[conzx_Concept.TextId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conzx_Concept.TextId, objzx_ConceptCond.TextId, strComparisonOpTextId);
}
if (objzx_ConceptCond.IsUpdated(conzx_Concept.IsSubmit) == true)
{
if (objzx_ConceptCond.IsSubmit == true)
{
strWhereCond += string.Format(" And {0} = '1'", conzx_Concept.IsSubmit);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conzx_Concept.IsSubmit);
}
}
if (objzx_ConceptCond.IsUpdated(conzx_Concept.VoteCount) == true)
{
string strComparisonOpVoteCount = objzx_ConceptCond.dicFldComparisonOp[conzx_Concept.VoteCount];
strWhereCond += string.Format(" And {0} {2} {1}", conzx_Concept.VoteCount, objzx_ConceptCond.VoteCount, strComparisonOpVoteCount);
}
if (objzx_ConceptCond.IsUpdated(conzx_Concept.AppraiseCount) == true)
{
string strComparisonOpAppraiseCount = objzx_ConceptCond.dicFldComparisonOp[conzx_Concept.AppraiseCount];
strWhereCond += string.Format(" And {0} {2} {1}", conzx_Concept.AppraiseCount, objzx_ConceptCond.AppraiseCount, strComparisonOpAppraiseCount);
}
if (objzx_ConceptCond.IsUpdated(conzx_Concept.Score) == true)
{
string strComparisonOpScore = objzx_ConceptCond.dicFldComparisonOp[conzx_Concept.Score];
strWhereCond += string.Format(" And {0} {2} {1}", conzx_Concept.Score, objzx_ConceptCond.Score, strComparisonOpScore);
}
if (objzx_ConceptCond.IsUpdated(conzx_Concept.StuScore) == true)
{
string strComparisonOpStuScore = objzx_ConceptCond.dicFldComparisonOp[conzx_Concept.StuScore];
strWhereCond += string.Format(" And {0} {2} {1}", conzx_Concept.StuScore, objzx_ConceptCond.StuScore, strComparisonOpStuScore);
}
if (objzx_ConceptCond.IsUpdated(conzx_Concept.TeaScore) == true)
{
string strComparisonOpTeaScore = objzx_ConceptCond.dicFldComparisonOp[conzx_Concept.TeaScore];
strWhereCond += string.Format(" And {0} {2} {1}", conzx_Concept.TeaScore, objzx_ConceptCond.TeaScore, strComparisonOpTeaScore);
}
if (objzx_ConceptCond.IsUpdated(conzx_Concept.IdCurrEduCls) == true)
{
string strComparisonOpIdCurrEduCls = objzx_ConceptCond.dicFldComparisonOp[conzx_Concept.IdCurrEduCls];
strWhereCond += string.Format(" And {0} {2} '{1}'", conzx_Concept.IdCurrEduCls, objzx_ConceptCond.IdCurrEduCls, strComparisonOpIdCurrEduCls);
}
if (objzx_ConceptCond.IsUpdated(conzx_Concept.PdfContent) == true)
{
string strComparisonOpPdfContent = objzx_ConceptCond.dicFldComparisonOp[conzx_Concept.PdfContent];
strWhereCond += string.Format(" And {0} {2} '{1}'", conzx_Concept.PdfContent, objzx_ConceptCond.PdfContent, strComparisonOpPdfContent);
}
if (objzx_ConceptCond.IsUpdated(conzx_Concept.PdfPageNum) == true)
{
string strComparisonOpPdfPageNum = objzx_ConceptCond.dicFldComparisonOp[conzx_Concept.PdfPageNum];
strWhereCond += string.Format(" And {0} {2} {1}", conzx_Concept.PdfPageNum, objzx_ConceptCond.PdfPageNum, strComparisonOpPdfPageNum);
}
if (objzx_ConceptCond.IsUpdated(conzx_Concept.CitationCount) == true)
{
string strComparisonOpCitationCount = objzx_ConceptCond.dicFldComparisonOp[conzx_Concept.CitationCount];
strWhereCond += string.Format(" And {0} {2} {1}", conzx_Concept.CitationCount, objzx_ConceptCond.CitationCount, strComparisonOpCitationCount);
}
if (objzx_ConceptCond.IsUpdated(conzx_Concept.VersionCount) == true)
{
string strComparisonOpVersionCount = objzx_ConceptCond.dicFldComparisonOp[conzx_Concept.VersionCount];
strWhereCond += string.Format(" And {0} {2} {1}", conzx_Concept.VersionCount, objzx_ConceptCond.VersionCount, strComparisonOpVersionCount);
}
if (objzx_ConceptCond.IsUpdated(conzx_Concept.zxShareId) == true)
{
string strComparisonOpzxShareId = objzx_ConceptCond.dicFldComparisonOp[conzx_Concept.zxShareId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conzx_Concept.zxShareId, objzx_ConceptCond.zxShareId, strComparisonOpzxShareId);
}
if (objzx_ConceptCond.IsUpdated(conzx_Concept.CreateDate) == true)
{
string strComparisonOpCreateDate = objzx_ConceptCond.dicFldComparisonOp[conzx_Concept.CreateDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conzx_Concept.CreateDate, objzx_ConceptCond.CreateDate, strComparisonOpCreateDate);
}
if (objzx_ConceptCond.IsUpdated(conzx_Concept.UpdDate) == true)
{
string strComparisonOpUpdDate = objzx_ConceptCond.dicFldComparisonOp[conzx_Concept.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conzx_Concept.UpdDate, objzx_ConceptCond.UpdDate, strComparisonOpUpdDate);
}
if (objzx_ConceptCond.IsUpdated(conzx_Concept.UpdUser) == true)
{
string strComparisonOpUpdUser = objzx_ConceptCond.dicFldComparisonOp[conzx_Concept.UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", conzx_Concept.UpdUser, objzx_ConceptCond.UpdUser, strComparisonOpUpdUser);
}
if (objzx_ConceptCond.IsUpdated(conzx_Concept.Memo) == true)
{
string strComparisonOpMemo = objzx_ConceptCond.dicFldComparisonOp[conzx_Concept.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", conzx_Concept.Memo, objzx_ConceptCond.Memo, strComparisonOpMemo);
}
if (objzx_ConceptCond.IsUpdated(conzx_Concept.PdfDivLet) == true)
{
string strComparisonOpPdfDivLet = objzx_ConceptCond.dicFldComparisonOp[conzx_Concept.PdfDivLet];
strWhereCond += string.Format(" And {0} {2} '{1}'", conzx_Concept.PdfDivLet, objzx_ConceptCond.PdfDivLet, strComparisonOpPdfDivLet);
}
if (objzx_ConceptCond.IsUpdated(conzx_Concept.PdfDivTop) == true)
{
string strComparisonOpPdfDivTop = objzx_ConceptCond.dicFldComparisonOp[conzx_Concept.PdfDivTop];
strWhereCond += string.Format(" And {0} {2} '{1}'", conzx_Concept.PdfDivTop, objzx_ConceptCond.PdfDivTop, strComparisonOpPdfDivTop);
}
if (objzx_ConceptCond.IsUpdated(conzx_Concept.PdfPageNumIn) == true)
{
string strComparisonOpPdfPageNumIn = objzx_ConceptCond.dicFldComparisonOp[conzx_Concept.PdfPageNumIn];
strWhereCond += string.Format(" And {0} {2} '{1}'", conzx_Concept.PdfPageNumIn, objzx_ConceptCond.PdfPageNumIn, strComparisonOpPdfPageNumIn);
}
if (objzx_ConceptCond.IsUpdated(conzx_Concept.PdfPageTop) == true)
{
string strComparisonOpPdfPageTop = objzx_ConceptCond.dicFldComparisonOp[conzx_Concept.PdfPageTop];
strWhereCond += string.Format(" And {0} {2} {1}", conzx_Concept.PdfPageTop, objzx_ConceptCond.PdfPageTop, strComparisonOpPdfPageTop);
}
if (objzx_ConceptCond.IsUpdated(conzx_Concept.PdfZoom) == true)
{
string strComparisonOpPdfZoom = objzx_ConceptCond.dicFldComparisonOp[conzx_Concept.PdfZoom];
strWhereCond += string.Format(" And {0} {2} '{1}'", conzx_Concept.PdfZoom, objzx_ConceptCond.PdfZoom, strComparisonOpPdfZoom);
}
if (objzx_ConceptCond.IsUpdated(conzx_Concept.GroupTextId) == true)
{
string strComparisonOpGroupTextId = objzx_ConceptCond.dicFldComparisonOp[conzx_Concept.GroupTextId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conzx_Concept.GroupTextId, objzx_ConceptCond.GroupTextId, strComparisonOpGroupTextId);
}
 return strWhereCond;
}

 /// <summary>
 /// 检查唯一性(Uniqueness)--zx_Concept(中学概念表), 如果不唯一,即存在相同的记录,就返回False
 /// 唯一性条件:TextId
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckConstraint)
 /// </summary>
 /// <param name = "objzx_ConceptEN">要求唯一的对象</param>
 /// <returns></returns>
public static bool CheckUniqueness(this clszx_ConceptEN objzx_ConceptEN)
{
//检测记录是否存在
bool bolIsUniqueness;
StringBuilder sbCondition = new StringBuilder();
if (objzx_ConceptEN == null) return true;
if (objzx_ConceptEN.zxConceptId == null || objzx_ConceptEN.zxConceptId == "")
{
sbCondition.AppendFormat("1 = 1");
 if (objzx_ConceptEN.TextId == null)
{
 sbCondition.AppendFormat(" and TextId is null", objzx_ConceptEN.TextId);
}
else
{
 sbCondition.AppendFormat(" and TextId = '{0}'", objzx_ConceptEN.TextId);
}
if (clszx_ConceptBL.IsExistRecord(sbCondition.ToString())  ==  true)
{
 bolIsUniqueness = false;
}
else
{
 bolIsUniqueness = true;
}
}
 else {
sbCondition.AppendFormat("zxConceptId !=  '{0}'", objzx_ConceptEN.zxConceptId);
 sbCondition.AppendFormat(" and TextId = '{0}'", objzx_ConceptEN.TextId);
if (clszx_ConceptBL.IsExistRecord(sbCondition.ToString())  ==  true)
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
 /// 获取唯一性条件串--zx_Concept(中学概念表), 即由对象中唯一性条件字段关键字与值组成的条件串
 /// 唯一性条件:TextId
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetConditionString4Constraint)
 /// </summary>
 /// <param name = "objzx_ConceptEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(this clszx_ConceptEN objzx_ConceptEN)
{
//检测记录是否存在
StringBuilder sbCondition = new StringBuilder();
if (objzx_ConceptEN == null) return "";
if (objzx_ConceptEN.zxConceptId == null || objzx_ConceptEN.zxConceptId == "")
{
sbCondition.AppendFormat("1 = 1");
 if (objzx_ConceptEN.TextId == null)
{
 sbCondition.AppendFormat(" and TextId is null", objzx_ConceptEN.TextId);
}
else
{
 sbCondition.AppendFormat(" and TextId = '{0}'", objzx_ConceptEN.TextId);
}
return sbCondition.ToString();
}
 else {
sbCondition.AppendFormat("zxConceptId !=  '{0}'", objzx_ConceptEN.zxConceptId);
 sbCondition.AppendFormat(" and TextId = '{0}'", objzx_ConceptEN.TextId);
 return sbCondition.ToString();
}
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_zx_Concept
{
public virtual bool UpdRelaTabDate(string strzxConceptId, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// 中学概念表(zx_Concept)
 /// 数据源类型:表
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clszx_ConceptBL
{
public static RelatedActions_zx_Concept relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clszx_ConceptDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clszx_ConceptDA zx_ConceptDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clszx_ConceptDA();
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
 public clszx_ConceptBL()
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
if (string.IsNullOrEmpty(clszx_ConceptEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clszx_ConceptEN._ConnectString);
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
public static DataTable GetDataTable_zx_Concept(string strWhereCond)
{
DataTable objDT;
try
{
objDT = zx_ConceptDA.GetDataTable_zx_Concept(strWhereCond);
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
objDT = zx_ConceptDA.GetDataTable(strWhereCond);
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
objDT = zx_ConceptDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = zx_ConceptDA.GetDataTable(strWhereCond, strTabName);
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
objDT = zx_ConceptDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = zx_ConceptDA.GetDataTable_Top(objTopPara);
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
objDT = zx_ConceptDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = zx_ConceptDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = zx_ConceptDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
 /// <param name = "arrZxConceptIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static List<clszx_ConceptEN> GetObjLstByZxConceptIdLst(List<string> arrZxConceptIdLst)
{
List<clszx_ConceptEN> arrObjLst = new List<clszx_ConceptEN>(); 
System.Data.DataTable objDT; 
 string strSqlConditionStr = clsArray.GetSqlInStrByArray(arrZxConceptIdLst, true);
 string strWhereCond = string.Format("zxConceptId in ({0})", strSqlConditionStr);
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clszx_ConceptEN objzx_ConceptEN = new clszx_ConceptEN();
try
{
objzx_ConceptEN.zxConceptId = objRow[conzx_Concept.zxConceptId].ToString().Trim(); //概念Id
objzx_ConceptEN.ConceptName = objRow[conzx_Concept.ConceptName] == DBNull.Value ? null : objRow[conzx_Concept.ConceptName].ToString().Trim(); //概念名称
objzx_ConceptEN.ConceptContent = objRow[conzx_Concept.ConceptContent] == DBNull.Value ? null : objRow[conzx_Concept.ConceptContent].ToString().Trim(); //概念内容
objzx_ConceptEN.TextId = objRow[conzx_Concept.TextId] == DBNull.Value ? null : objRow[conzx_Concept.TextId].ToString().Trim(); //课件Id
objzx_ConceptEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[conzx_Concept.IsSubmit].ToString().Trim()); //是否提交
objzx_ConceptEN.VoteCount = objRow[conzx_Concept.VoteCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_Concept.VoteCount].ToString().Trim()); //点赞计数
objzx_ConceptEN.AppraiseCount = objRow[conzx_Concept.AppraiseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_Concept.AppraiseCount].ToString().Trim()); //评论数
objzx_ConceptEN.Score = objRow[conzx_Concept.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conzx_Concept.Score].ToString().Trim()); //评分
objzx_ConceptEN.StuScore = objRow[conzx_Concept.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conzx_Concept.StuScore].ToString().Trim()); //学生平均分
objzx_ConceptEN.TeaScore = objRow[conzx_Concept.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conzx_Concept.TeaScore].ToString().Trim()); //教师评分
objzx_ConceptEN.IdCurrEduCls = objRow[conzx_Concept.IdCurrEduCls] == DBNull.Value ? null : objRow[conzx_Concept.IdCurrEduCls].ToString().Trim(); //教学班流水号
objzx_ConceptEN.PdfContent = objRow[conzx_Concept.PdfContent] == DBNull.Value ? null : objRow[conzx_Concept.PdfContent].ToString().Trim(); //Pdf内容
objzx_ConceptEN.PdfPageNum = objRow[conzx_Concept.PdfPageNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_Concept.PdfPageNum].ToString().Trim()); //Pdf页码
objzx_ConceptEN.CitationCount = objRow[conzx_Concept.CitationCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_Concept.CitationCount].ToString().Trim()); //引用统计
objzx_ConceptEN.VersionCount = objRow[conzx_Concept.VersionCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_Concept.VersionCount].ToString().Trim()); //版本统计
objzx_ConceptEN.zxShareId = objRow[conzx_Concept.zxShareId].ToString().Trim(); //分享Id
objzx_ConceptEN.CreateDate = objRow[conzx_Concept.CreateDate] == DBNull.Value ? null : objRow[conzx_Concept.CreateDate].ToString().Trim(); //建立日期
objzx_ConceptEN.UpdDate = objRow[conzx_Concept.UpdDate] == DBNull.Value ? null : objRow[conzx_Concept.UpdDate].ToString().Trim(); //修改日期
objzx_ConceptEN.UpdUser = objRow[conzx_Concept.UpdUser] == DBNull.Value ? null : objRow[conzx_Concept.UpdUser].ToString().Trim(); //修改人
objzx_ConceptEN.Memo = objRow[conzx_Concept.Memo] == DBNull.Value ? null : objRow[conzx_Concept.Memo].ToString().Trim(); //备注
objzx_ConceptEN.PdfDivLet = objRow[conzx_Concept.PdfDivLet] == DBNull.Value ? null : objRow[conzx_Concept.PdfDivLet].ToString().Trim(); //PdfDivLet
objzx_ConceptEN.PdfDivTop = objRow[conzx_Concept.PdfDivTop] == DBNull.Value ? null : objRow[conzx_Concept.PdfDivTop].ToString().Trim(); //PdfDivTop
objzx_ConceptEN.PdfPageNumIn = objRow[conzx_Concept.PdfPageNumIn] == DBNull.Value ? null : objRow[conzx_Concept.PdfPageNumIn].ToString().Trim(); //PdfPageNumIn
objzx_ConceptEN.PdfPageTop = objRow[conzx_Concept.PdfPageTop] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_Concept.PdfPageTop].ToString().Trim()); //pdf页面顶部位置
objzx_ConceptEN.PdfZoom = objRow[conzx_Concept.PdfZoom] == DBNull.Value ? null : objRow[conzx_Concept.PdfZoom].ToString().Trim(); //PdfZoom
objzx_ConceptEN.GroupTextId = objRow[conzx_Concept.GroupTextId] == DBNull.Value ? null : objRow[conzx_Concept.GroupTextId].ToString().Trim(); //小组Id
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objzx_ConceptEN.zxConceptId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objzx_ConceptEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrZxConceptIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clszx_ConceptEN> GetObjLstByZxConceptIdLstCache(List<string> arrZxConceptIdLst, string strIdCurrEduCls)
{
string strKey = string.Format("{0}_{1}", clszx_ConceptEN._CurrTabName, strIdCurrEduCls);
List<clszx_ConceptEN> arrzx_ConceptObjLstCache = GetObjLstCache(strIdCurrEduCls);
IEnumerable <clszx_ConceptEN> arrzx_ConceptObjLst_Sel =
arrzx_ConceptObjLstCache
.Where(x => arrZxConceptIdLst.Contains(x.zxConceptId));
return arrzx_ConceptObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clszx_ConceptEN> GetObjLst(string strWhereCond)
{
List<clszx_ConceptEN> arrObjLst = new List<clszx_ConceptEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clszx_ConceptEN objzx_ConceptEN = new clszx_ConceptEN();
try
{
objzx_ConceptEN.zxConceptId = objRow[conzx_Concept.zxConceptId].ToString().Trim(); //概念Id
objzx_ConceptEN.ConceptName = objRow[conzx_Concept.ConceptName] == DBNull.Value ? null : objRow[conzx_Concept.ConceptName].ToString().Trim(); //概念名称
objzx_ConceptEN.ConceptContent = objRow[conzx_Concept.ConceptContent] == DBNull.Value ? null : objRow[conzx_Concept.ConceptContent].ToString().Trim(); //概念内容
objzx_ConceptEN.TextId = objRow[conzx_Concept.TextId] == DBNull.Value ? null : objRow[conzx_Concept.TextId].ToString().Trim(); //课件Id
objzx_ConceptEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[conzx_Concept.IsSubmit].ToString().Trim()); //是否提交
objzx_ConceptEN.VoteCount = objRow[conzx_Concept.VoteCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_Concept.VoteCount].ToString().Trim()); //点赞计数
objzx_ConceptEN.AppraiseCount = objRow[conzx_Concept.AppraiseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_Concept.AppraiseCount].ToString().Trim()); //评论数
objzx_ConceptEN.Score = objRow[conzx_Concept.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conzx_Concept.Score].ToString().Trim()); //评分
objzx_ConceptEN.StuScore = objRow[conzx_Concept.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conzx_Concept.StuScore].ToString().Trim()); //学生平均分
objzx_ConceptEN.TeaScore = objRow[conzx_Concept.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conzx_Concept.TeaScore].ToString().Trim()); //教师评分
objzx_ConceptEN.IdCurrEduCls = objRow[conzx_Concept.IdCurrEduCls] == DBNull.Value ? null : objRow[conzx_Concept.IdCurrEduCls].ToString().Trim(); //教学班流水号
objzx_ConceptEN.PdfContent = objRow[conzx_Concept.PdfContent] == DBNull.Value ? null : objRow[conzx_Concept.PdfContent].ToString().Trim(); //Pdf内容
objzx_ConceptEN.PdfPageNum = objRow[conzx_Concept.PdfPageNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_Concept.PdfPageNum].ToString().Trim()); //Pdf页码
objzx_ConceptEN.CitationCount = objRow[conzx_Concept.CitationCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_Concept.CitationCount].ToString().Trim()); //引用统计
objzx_ConceptEN.VersionCount = objRow[conzx_Concept.VersionCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_Concept.VersionCount].ToString().Trim()); //版本统计
objzx_ConceptEN.zxShareId = objRow[conzx_Concept.zxShareId].ToString().Trim(); //分享Id
objzx_ConceptEN.CreateDate = objRow[conzx_Concept.CreateDate] == DBNull.Value ? null : objRow[conzx_Concept.CreateDate].ToString().Trim(); //建立日期
objzx_ConceptEN.UpdDate = objRow[conzx_Concept.UpdDate] == DBNull.Value ? null : objRow[conzx_Concept.UpdDate].ToString().Trim(); //修改日期
objzx_ConceptEN.UpdUser = objRow[conzx_Concept.UpdUser] == DBNull.Value ? null : objRow[conzx_Concept.UpdUser].ToString().Trim(); //修改人
objzx_ConceptEN.Memo = objRow[conzx_Concept.Memo] == DBNull.Value ? null : objRow[conzx_Concept.Memo].ToString().Trim(); //备注
objzx_ConceptEN.PdfDivLet = objRow[conzx_Concept.PdfDivLet] == DBNull.Value ? null : objRow[conzx_Concept.PdfDivLet].ToString().Trim(); //PdfDivLet
objzx_ConceptEN.PdfDivTop = objRow[conzx_Concept.PdfDivTop] == DBNull.Value ? null : objRow[conzx_Concept.PdfDivTop].ToString().Trim(); //PdfDivTop
objzx_ConceptEN.PdfPageNumIn = objRow[conzx_Concept.PdfPageNumIn] == DBNull.Value ? null : objRow[conzx_Concept.PdfPageNumIn].ToString().Trim(); //PdfPageNumIn
objzx_ConceptEN.PdfPageTop = objRow[conzx_Concept.PdfPageTop] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_Concept.PdfPageTop].ToString().Trim()); //pdf页面顶部位置
objzx_ConceptEN.PdfZoom = objRow[conzx_Concept.PdfZoom] == DBNull.Value ? null : objRow[conzx_Concept.PdfZoom].ToString().Trim(); //PdfZoom
objzx_ConceptEN.GroupTextId = objRow[conzx_Concept.GroupTextId] == DBNull.Value ? null : objRow[conzx_Concept.GroupTextId].ToString().Trim(); //小组Id
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objzx_ConceptEN.zxConceptId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objzx_ConceptEN);
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
public static List<clszx_ConceptEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clszx_ConceptEN> arrObjLst = new List<clszx_ConceptEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clszx_ConceptEN objzx_ConceptEN = new clszx_ConceptEN();
try
{
objzx_ConceptEN.zxConceptId = objRow[conzx_Concept.zxConceptId].ToString().Trim(); //概念Id
objzx_ConceptEN.ConceptName = objRow[conzx_Concept.ConceptName] == DBNull.Value ? null : objRow[conzx_Concept.ConceptName].ToString().Trim(); //概念名称
objzx_ConceptEN.ConceptContent = objRow[conzx_Concept.ConceptContent] == DBNull.Value ? null : objRow[conzx_Concept.ConceptContent].ToString().Trim(); //概念内容
objzx_ConceptEN.TextId = objRow[conzx_Concept.TextId] == DBNull.Value ? null : objRow[conzx_Concept.TextId].ToString().Trim(); //课件Id
objzx_ConceptEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[conzx_Concept.IsSubmit].ToString().Trim()); //是否提交
objzx_ConceptEN.VoteCount = objRow[conzx_Concept.VoteCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_Concept.VoteCount].ToString().Trim()); //点赞计数
objzx_ConceptEN.AppraiseCount = objRow[conzx_Concept.AppraiseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_Concept.AppraiseCount].ToString().Trim()); //评论数
objzx_ConceptEN.Score = objRow[conzx_Concept.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conzx_Concept.Score].ToString().Trim()); //评分
objzx_ConceptEN.StuScore = objRow[conzx_Concept.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conzx_Concept.StuScore].ToString().Trim()); //学生平均分
objzx_ConceptEN.TeaScore = objRow[conzx_Concept.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conzx_Concept.TeaScore].ToString().Trim()); //教师评分
objzx_ConceptEN.IdCurrEduCls = objRow[conzx_Concept.IdCurrEduCls] == DBNull.Value ? null : objRow[conzx_Concept.IdCurrEduCls].ToString().Trim(); //教学班流水号
objzx_ConceptEN.PdfContent = objRow[conzx_Concept.PdfContent] == DBNull.Value ? null : objRow[conzx_Concept.PdfContent].ToString().Trim(); //Pdf内容
objzx_ConceptEN.PdfPageNum = objRow[conzx_Concept.PdfPageNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_Concept.PdfPageNum].ToString().Trim()); //Pdf页码
objzx_ConceptEN.CitationCount = objRow[conzx_Concept.CitationCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_Concept.CitationCount].ToString().Trim()); //引用统计
objzx_ConceptEN.VersionCount = objRow[conzx_Concept.VersionCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_Concept.VersionCount].ToString().Trim()); //版本统计
objzx_ConceptEN.zxShareId = objRow[conzx_Concept.zxShareId].ToString().Trim(); //分享Id
objzx_ConceptEN.CreateDate = objRow[conzx_Concept.CreateDate] == DBNull.Value ? null : objRow[conzx_Concept.CreateDate].ToString().Trim(); //建立日期
objzx_ConceptEN.UpdDate = objRow[conzx_Concept.UpdDate] == DBNull.Value ? null : objRow[conzx_Concept.UpdDate].ToString().Trim(); //修改日期
objzx_ConceptEN.UpdUser = objRow[conzx_Concept.UpdUser] == DBNull.Value ? null : objRow[conzx_Concept.UpdUser].ToString().Trim(); //修改人
objzx_ConceptEN.Memo = objRow[conzx_Concept.Memo] == DBNull.Value ? null : objRow[conzx_Concept.Memo].ToString().Trim(); //备注
objzx_ConceptEN.PdfDivLet = objRow[conzx_Concept.PdfDivLet] == DBNull.Value ? null : objRow[conzx_Concept.PdfDivLet].ToString().Trim(); //PdfDivLet
objzx_ConceptEN.PdfDivTop = objRow[conzx_Concept.PdfDivTop] == DBNull.Value ? null : objRow[conzx_Concept.PdfDivTop].ToString().Trim(); //PdfDivTop
objzx_ConceptEN.PdfPageNumIn = objRow[conzx_Concept.PdfPageNumIn] == DBNull.Value ? null : objRow[conzx_Concept.PdfPageNumIn].ToString().Trim(); //PdfPageNumIn
objzx_ConceptEN.PdfPageTop = objRow[conzx_Concept.PdfPageTop] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_Concept.PdfPageTop].ToString().Trim()); //pdf页面顶部位置
objzx_ConceptEN.PdfZoom = objRow[conzx_Concept.PdfZoom] == DBNull.Value ? null : objRow[conzx_Concept.PdfZoom].ToString().Trim(); //PdfZoom
objzx_ConceptEN.GroupTextId = objRow[conzx_Concept.GroupTextId] == DBNull.Value ? null : objRow[conzx_Concept.GroupTextId].ToString().Trim(); //小组Id
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objzx_ConceptEN.zxConceptId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objzx_ConceptEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objzx_ConceptCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clszx_ConceptEN> GetSubObjLstCache(clszx_ConceptEN objzx_ConceptCond)
{
 string strIdCurrEduCls = objzx_ConceptCond.IdCurrEduCls;
 if (string.IsNullOrEmpty(strIdCurrEduCls) == true)
{
string strMsg = string.Format("(errid:Busi000172)在表中,缓存分类字段值不能为空!(clszx_ConceptBL:GetSubObjLstCache)");
throw new Exception(strMsg);
}
List<clszx_ConceptEN> arrObjLstCache = GetObjLstCache(strIdCurrEduCls);
IEnumerable <clszx_ConceptEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conzx_Concept.AttributeName)
{
if (objzx_ConceptCond.IsUpdated(strFldName) == false) continue;
if (objzx_ConceptCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objzx_ConceptCond[strFldName].ToString());
}
else
{
if (objzx_ConceptCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objzx_ConceptCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objzx_ConceptCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objzx_ConceptCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objzx_ConceptCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objzx_ConceptCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objzx_ConceptCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objzx_ConceptCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objzx_ConceptCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objzx_ConceptCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objzx_ConceptCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objzx_ConceptCond[strFldName]));
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
public static List<clszx_ConceptEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clszx_ConceptEN> arrObjLst = new List<clszx_ConceptEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clszx_ConceptEN objzx_ConceptEN = new clszx_ConceptEN();
try
{
objzx_ConceptEN.zxConceptId = objRow[conzx_Concept.zxConceptId].ToString().Trim(); //概念Id
objzx_ConceptEN.ConceptName = objRow[conzx_Concept.ConceptName] == DBNull.Value ? null : objRow[conzx_Concept.ConceptName].ToString().Trim(); //概念名称
objzx_ConceptEN.ConceptContent = objRow[conzx_Concept.ConceptContent] == DBNull.Value ? null : objRow[conzx_Concept.ConceptContent].ToString().Trim(); //概念内容
objzx_ConceptEN.TextId = objRow[conzx_Concept.TextId] == DBNull.Value ? null : objRow[conzx_Concept.TextId].ToString().Trim(); //课件Id
objzx_ConceptEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[conzx_Concept.IsSubmit].ToString().Trim()); //是否提交
objzx_ConceptEN.VoteCount = objRow[conzx_Concept.VoteCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_Concept.VoteCount].ToString().Trim()); //点赞计数
objzx_ConceptEN.AppraiseCount = objRow[conzx_Concept.AppraiseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_Concept.AppraiseCount].ToString().Trim()); //评论数
objzx_ConceptEN.Score = objRow[conzx_Concept.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conzx_Concept.Score].ToString().Trim()); //评分
objzx_ConceptEN.StuScore = objRow[conzx_Concept.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conzx_Concept.StuScore].ToString().Trim()); //学生平均分
objzx_ConceptEN.TeaScore = objRow[conzx_Concept.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conzx_Concept.TeaScore].ToString().Trim()); //教师评分
objzx_ConceptEN.IdCurrEduCls = objRow[conzx_Concept.IdCurrEduCls] == DBNull.Value ? null : objRow[conzx_Concept.IdCurrEduCls].ToString().Trim(); //教学班流水号
objzx_ConceptEN.PdfContent = objRow[conzx_Concept.PdfContent] == DBNull.Value ? null : objRow[conzx_Concept.PdfContent].ToString().Trim(); //Pdf内容
objzx_ConceptEN.PdfPageNum = objRow[conzx_Concept.PdfPageNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_Concept.PdfPageNum].ToString().Trim()); //Pdf页码
objzx_ConceptEN.CitationCount = objRow[conzx_Concept.CitationCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_Concept.CitationCount].ToString().Trim()); //引用统计
objzx_ConceptEN.VersionCount = objRow[conzx_Concept.VersionCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_Concept.VersionCount].ToString().Trim()); //版本统计
objzx_ConceptEN.zxShareId = objRow[conzx_Concept.zxShareId].ToString().Trim(); //分享Id
objzx_ConceptEN.CreateDate = objRow[conzx_Concept.CreateDate] == DBNull.Value ? null : objRow[conzx_Concept.CreateDate].ToString().Trim(); //建立日期
objzx_ConceptEN.UpdDate = objRow[conzx_Concept.UpdDate] == DBNull.Value ? null : objRow[conzx_Concept.UpdDate].ToString().Trim(); //修改日期
objzx_ConceptEN.UpdUser = objRow[conzx_Concept.UpdUser] == DBNull.Value ? null : objRow[conzx_Concept.UpdUser].ToString().Trim(); //修改人
objzx_ConceptEN.Memo = objRow[conzx_Concept.Memo] == DBNull.Value ? null : objRow[conzx_Concept.Memo].ToString().Trim(); //备注
objzx_ConceptEN.PdfDivLet = objRow[conzx_Concept.PdfDivLet] == DBNull.Value ? null : objRow[conzx_Concept.PdfDivLet].ToString().Trim(); //PdfDivLet
objzx_ConceptEN.PdfDivTop = objRow[conzx_Concept.PdfDivTop] == DBNull.Value ? null : objRow[conzx_Concept.PdfDivTop].ToString().Trim(); //PdfDivTop
objzx_ConceptEN.PdfPageNumIn = objRow[conzx_Concept.PdfPageNumIn] == DBNull.Value ? null : objRow[conzx_Concept.PdfPageNumIn].ToString().Trim(); //PdfPageNumIn
objzx_ConceptEN.PdfPageTop = objRow[conzx_Concept.PdfPageTop] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_Concept.PdfPageTop].ToString().Trim()); //pdf页面顶部位置
objzx_ConceptEN.PdfZoom = objRow[conzx_Concept.PdfZoom] == DBNull.Value ? null : objRow[conzx_Concept.PdfZoom].ToString().Trim(); //PdfZoom
objzx_ConceptEN.GroupTextId = objRow[conzx_Concept.GroupTextId] == DBNull.Value ? null : objRow[conzx_Concept.GroupTextId].ToString().Trim(); //小组Id
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objzx_ConceptEN.zxConceptId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objzx_ConceptEN);
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
public static List<clszx_ConceptEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clszx_ConceptEN> arrObjLst = new List<clszx_ConceptEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clszx_ConceptEN objzx_ConceptEN = new clszx_ConceptEN();
try
{
objzx_ConceptEN.zxConceptId = objRow[conzx_Concept.zxConceptId].ToString().Trim(); //概念Id
objzx_ConceptEN.ConceptName = objRow[conzx_Concept.ConceptName] == DBNull.Value ? null : objRow[conzx_Concept.ConceptName].ToString().Trim(); //概念名称
objzx_ConceptEN.ConceptContent = objRow[conzx_Concept.ConceptContent] == DBNull.Value ? null : objRow[conzx_Concept.ConceptContent].ToString().Trim(); //概念内容
objzx_ConceptEN.TextId = objRow[conzx_Concept.TextId] == DBNull.Value ? null : objRow[conzx_Concept.TextId].ToString().Trim(); //课件Id
objzx_ConceptEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[conzx_Concept.IsSubmit].ToString().Trim()); //是否提交
objzx_ConceptEN.VoteCount = objRow[conzx_Concept.VoteCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_Concept.VoteCount].ToString().Trim()); //点赞计数
objzx_ConceptEN.AppraiseCount = objRow[conzx_Concept.AppraiseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_Concept.AppraiseCount].ToString().Trim()); //评论数
objzx_ConceptEN.Score = objRow[conzx_Concept.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conzx_Concept.Score].ToString().Trim()); //评分
objzx_ConceptEN.StuScore = objRow[conzx_Concept.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conzx_Concept.StuScore].ToString().Trim()); //学生平均分
objzx_ConceptEN.TeaScore = objRow[conzx_Concept.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conzx_Concept.TeaScore].ToString().Trim()); //教师评分
objzx_ConceptEN.IdCurrEduCls = objRow[conzx_Concept.IdCurrEduCls] == DBNull.Value ? null : objRow[conzx_Concept.IdCurrEduCls].ToString().Trim(); //教学班流水号
objzx_ConceptEN.PdfContent = objRow[conzx_Concept.PdfContent] == DBNull.Value ? null : objRow[conzx_Concept.PdfContent].ToString().Trim(); //Pdf内容
objzx_ConceptEN.PdfPageNum = objRow[conzx_Concept.PdfPageNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_Concept.PdfPageNum].ToString().Trim()); //Pdf页码
objzx_ConceptEN.CitationCount = objRow[conzx_Concept.CitationCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_Concept.CitationCount].ToString().Trim()); //引用统计
objzx_ConceptEN.VersionCount = objRow[conzx_Concept.VersionCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_Concept.VersionCount].ToString().Trim()); //版本统计
objzx_ConceptEN.zxShareId = objRow[conzx_Concept.zxShareId].ToString().Trim(); //分享Id
objzx_ConceptEN.CreateDate = objRow[conzx_Concept.CreateDate] == DBNull.Value ? null : objRow[conzx_Concept.CreateDate].ToString().Trim(); //建立日期
objzx_ConceptEN.UpdDate = objRow[conzx_Concept.UpdDate] == DBNull.Value ? null : objRow[conzx_Concept.UpdDate].ToString().Trim(); //修改日期
objzx_ConceptEN.UpdUser = objRow[conzx_Concept.UpdUser] == DBNull.Value ? null : objRow[conzx_Concept.UpdUser].ToString().Trim(); //修改人
objzx_ConceptEN.Memo = objRow[conzx_Concept.Memo] == DBNull.Value ? null : objRow[conzx_Concept.Memo].ToString().Trim(); //备注
objzx_ConceptEN.PdfDivLet = objRow[conzx_Concept.PdfDivLet] == DBNull.Value ? null : objRow[conzx_Concept.PdfDivLet].ToString().Trim(); //PdfDivLet
objzx_ConceptEN.PdfDivTop = objRow[conzx_Concept.PdfDivTop] == DBNull.Value ? null : objRow[conzx_Concept.PdfDivTop].ToString().Trim(); //PdfDivTop
objzx_ConceptEN.PdfPageNumIn = objRow[conzx_Concept.PdfPageNumIn] == DBNull.Value ? null : objRow[conzx_Concept.PdfPageNumIn].ToString().Trim(); //PdfPageNumIn
objzx_ConceptEN.PdfPageTop = objRow[conzx_Concept.PdfPageTop] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_Concept.PdfPageTop].ToString().Trim()); //pdf页面顶部位置
objzx_ConceptEN.PdfZoom = objRow[conzx_Concept.PdfZoom] == DBNull.Value ? null : objRow[conzx_Concept.PdfZoom].ToString().Trim(); //PdfZoom
objzx_ConceptEN.GroupTextId = objRow[conzx_Concept.GroupTextId] == DBNull.Value ? null : objRow[conzx_Concept.GroupTextId].ToString().Trim(); //小组Id
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objzx_ConceptEN.zxConceptId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objzx_ConceptEN);
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
List<clszx_ConceptEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clszx_ConceptEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clszx_ConceptEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clszx_ConceptEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clszx_ConceptEN> arrObjLst = new List<clszx_ConceptEN>(); 
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
	clszx_ConceptEN objzx_ConceptEN = new clszx_ConceptEN();
try
{
objzx_ConceptEN.zxConceptId = objRow[conzx_Concept.zxConceptId].ToString().Trim(); //概念Id
objzx_ConceptEN.ConceptName = objRow[conzx_Concept.ConceptName] == DBNull.Value ? null : objRow[conzx_Concept.ConceptName].ToString().Trim(); //概念名称
objzx_ConceptEN.ConceptContent = objRow[conzx_Concept.ConceptContent] == DBNull.Value ? null : objRow[conzx_Concept.ConceptContent].ToString().Trim(); //概念内容
objzx_ConceptEN.TextId = objRow[conzx_Concept.TextId] == DBNull.Value ? null : objRow[conzx_Concept.TextId].ToString().Trim(); //课件Id
objzx_ConceptEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[conzx_Concept.IsSubmit].ToString().Trim()); //是否提交
objzx_ConceptEN.VoteCount = objRow[conzx_Concept.VoteCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_Concept.VoteCount].ToString().Trim()); //点赞计数
objzx_ConceptEN.AppraiseCount = objRow[conzx_Concept.AppraiseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_Concept.AppraiseCount].ToString().Trim()); //评论数
objzx_ConceptEN.Score = objRow[conzx_Concept.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conzx_Concept.Score].ToString().Trim()); //评分
objzx_ConceptEN.StuScore = objRow[conzx_Concept.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conzx_Concept.StuScore].ToString().Trim()); //学生平均分
objzx_ConceptEN.TeaScore = objRow[conzx_Concept.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conzx_Concept.TeaScore].ToString().Trim()); //教师评分
objzx_ConceptEN.IdCurrEduCls = objRow[conzx_Concept.IdCurrEduCls] == DBNull.Value ? null : objRow[conzx_Concept.IdCurrEduCls].ToString().Trim(); //教学班流水号
objzx_ConceptEN.PdfContent = objRow[conzx_Concept.PdfContent] == DBNull.Value ? null : objRow[conzx_Concept.PdfContent].ToString().Trim(); //Pdf内容
objzx_ConceptEN.PdfPageNum = objRow[conzx_Concept.PdfPageNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_Concept.PdfPageNum].ToString().Trim()); //Pdf页码
objzx_ConceptEN.CitationCount = objRow[conzx_Concept.CitationCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_Concept.CitationCount].ToString().Trim()); //引用统计
objzx_ConceptEN.VersionCount = objRow[conzx_Concept.VersionCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_Concept.VersionCount].ToString().Trim()); //版本统计
objzx_ConceptEN.zxShareId = objRow[conzx_Concept.zxShareId].ToString().Trim(); //分享Id
objzx_ConceptEN.CreateDate = objRow[conzx_Concept.CreateDate] == DBNull.Value ? null : objRow[conzx_Concept.CreateDate].ToString().Trim(); //建立日期
objzx_ConceptEN.UpdDate = objRow[conzx_Concept.UpdDate] == DBNull.Value ? null : objRow[conzx_Concept.UpdDate].ToString().Trim(); //修改日期
objzx_ConceptEN.UpdUser = objRow[conzx_Concept.UpdUser] == DBNull.Value ? null : objRow[conzx_Concept.UpdUser].ToString().Trim(); //修改人
objzx_ConceptEN.Memo = objRow[conzx_Concept.Memo] == DBNull.Value ? null : objRow[conzx_Concept.Memo].ToString().Trim(); //备注
objzx_ConceptEN.PdfDivLet = objRow[conzx_Concept.PdfDivLet] == DBNull.Value ? null : objRow[conzx_Concept.PdfDivLet].ToString().Trim(); //PdfDivLet
objzx_ConceptEN.PdfDivTop = objRow[conzx_Concept.PdfDivTop] == DBNull.Value ? null : objRow[conzx_Concept.PdfDivTop].ToString().Trim(); //PdfDivTop
objzx_ConceptEN.PdfPageNumIn = objRow[conzx_Concept.PdfPageNumIn] == DBNull.Value ? null : objRow[conzx_Concept.PdfPageNumIn].ToString().Trim(); //PdfPageNumIn
objzx_ConceptEN.PdfPageTop = objRow[conzx_Concept.PdfPageTop] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_Concept.PdfPageTop].ToString().Trim()); //pdf页面顶部位置
objzx_ConceptEN.PdfZoom = objRow[conzx_Concept.PdfZoom] == DBNull.Value ? null : objRow[conzx_Concept.PdfZoom].ToString().Trim(); //PdfZoom
objzx_ConceptEN.GroupTextId = objRow[conzx_Concept.GroupTextId] == DBNull.Value ? null : objRow[conzx_Concept.GroupTextId].ToString().Trim(); //小组Id
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objzx_ConceptEN.zxConceptId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objzx_ConceptEN);
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
public static List<clszx_ConceptEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clszx_ConceptEN> arrObjLst = new List<clszx_ConceptEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clszx_ConceptEN objzx_ConceptEN = new clszx_ConceptEN();
try
{
objzx_ConceptEN.zxConceptId = objRow[conzx_Concept.zxConceptId].ToString().Trim(); //概念Id
objzx_ConceptEN.ConceptName = objRow[conzx_Concept.ConceptName] == DBNull.Value ? null : objRow[conzx_Concept.ConceptName].ToString().Trim(); //概念名称
objzx_ConceptEN.ConceptContent = objRow[conzx_Concept.ConceptContent] == DBNull.Value ? null : objRow[conzx_Concept.ConceptContent].ToString().Trim(); //概念内容
objzx_ConceptEN.TextId = objRow[conzx_Concept.TextId] == DBNull.Value ? null : objRow[conzx_Concept.TextId].ToString().Trim(); //课件Id
objzx_ConceptEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[conzx_Concept.IsSubmit].ToString().Trim()); //是否提交
objzx_ConceptEN.VoteCount = objRow[conzx_Concept.VoteCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_Concept.VoteCount].ToString().Trim()); //点赞计数
objzx_ConceptEN.AppraiseCount = objRow[conzx_Concept.AppraiseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_Concept.AppraiseCount].ToString().Trim()); //评论数
objzx_ConceptEN.Score = objRow[conzx_Concept.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conzx_Concept.Score].ToString().Trim()); //评分
objzx_ConceptEN.StuScore = objRow[conzx_Concept.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conzx_Concept.StuScore].ToString().Trim()); //学生平均分
objzx_ConceptEN.TeaScore = objRow[conzx_Concept.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conzx_Concept.TeaScore].ToString().Trim()); //教师评分
objzx_ConceptEN.IdCurrEduCls = objRow[conzx_Concept.IdCurrEduCls] == DBNull.Value ? null : objRow[conzx_Concept.IdCurrEduCls].ToString().Trim(); //教学班流水号
objzx_ConceptEN.PdfContent = objRow[conzx_Concept.PdfContent] == DBNull.Value ? null : objRow[conzx_Concept.PdfContent].ToString().Trim(); //Pdf内容
objzx_ConceptEN.PdfPageNum = objRow[conzx_Concept.PdfPageNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_Concept.PdfPageNum].ToString().Trim()); //Pdf页码
objzx_ConceptEN.CitationCount = objRow[conzx_Concept.CitationCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_Concept.CitationCount].ToString().Trim()); //引用统计
objzx_ConceptEN.VersionCount = objRow[conzx_Concept.VersionCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_Concept.VersionCount].ToString().Trim()); //版本统计
objzx_ConceptEN.zxShareId = objRow[conzx_Concept.zxShareId].ToString().Trim(); //分享Id
objzx_ConceptEN.CreateDate = objRow[conzx_Concept.CreateDate] == DBNull.Value ? null : objRow[conzx_Concept.CreateDate].ToString().Trim(); //建立日期
objzx_ConceptEN.UpdDate = objRow[conzx_Concept.UpdDate] == DBNull.Value ? null : objRow[conzx_Concept.UpdDate].ToString().Trim(); //修改日期
objzx_ConceptEN.UpdUser = objRow[conzx_Concept.UpdUser] == DBNull.Value ? null : objRow[conzx_Concept.UpdUser].ToString().Trim(); //修改人
objzx_ConceptEN.Memo = objRow[conzx_Concept.Memo] == DBNull.Value ? null : objRow[conzx_Concept.Memo].ToString().Trim(); //备注
objzx_ConceptEN.PdfDivLet = objRow[conzx_Concept.PdfDivLet] == DBNull.Value ? null : objRow[conzx_Concept.PdfDivLet].ToString().Trim(); //PdfDivLet
objzx_ConceptEN.PdfDivTop = objRow[conzx_Concept.PdfDivTop] == DBNull.Value ? null : objRow[conzx_Concept.PdfDivTop].ToString().Trim(); //PdfDivTop
objzx_ConceptEN.PdfPageNumIn = objRow[conzx_Concept.PdfPageNumIn] == DBNull.Value ? null : objRow[conzx_Concept.PdfPageNumIn].ToString().Trim(); //PdfPageNumIn
objzx_ConceptEN.PdfPageTop = objRow[conzx_Concept.PdfPageTop] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_Concept.PdfPageTop].ToString().Trim()); //pdf页面顶部位置
objzx_ConceptEN.PdfZoom = objRow[conzx_Concept.PdfZoom] == DBNull.Value ? null : objRow[conzx_Concept.PdfZoom].ToString().Trim(); //PdfZoom
objzx_ConceptEN.GroupTextId = objRow[conzx_Concept.GroupTextId] == DBNull.Value ? null : objRow[conzx_Concept.GroupTextId].ToString().Trim(); //小组Id
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objzx_ConceptEN.zxConceptId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objzx_ConceptEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clszx_ConceptEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clszx_ConceptEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clszx_ConceptEN> arrObjLst = new List<clszx_ConceptEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clszx_ConceptEN objzx_ConceptEN = new clszx_ConceptEN();
try
{
objzx_ConceptEN.zxConceptId = objRow[conzx_Concept.zxConceptId].ToString().Trim(); //概念Id
objzx_ConceptEN.ConceptName = objRow[conzx_Concept.ConceptName] == DBNull.Value ? null : objRow[conzx_Concept.ConceptName].ToString().Trim(); //概念名称
objzx_ConceptEN.ConceptContent = objRow[conzx_Concept.ConceptContent] == DBNull.Value ? null : objRow[conzx_Concept.ConceptContent].ToString().Trim(); //概念内容
objzx_ConceptEN.TextId = objRow[conzx_Concept.TextId] == DBNull.Value ? null : objRow[conzx_Concept.TextId].ToString().Trim(); //课件Id
objzx_ConceptEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[conzx_Concept.IsSubmit].ToString().Trim()); //是否提交
objzx_ConceptEN.VoteCount = objRow[conzx_Concept.VoteCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_Concept.VoteCount].ToString().Trim()); //点赞计数
objzx_ConceptEN.AppraiseCount = objRow[conzx_Concept.AppraiseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_Concept.AppraiseCount].ToString().Trim()); //评论数
objzx_ConceptEN.Score = objRow[conzx_Concept.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conzx_Concept.Score].ToString().Trim()); //评分
objzx_ConceptEN.StuScore = objRow[conzx_Concept.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conzx_Concept.StuScore].ToString().Trim()); //学生平均分
objzx_ConceptEN.TeaScore = objRow[conzx_Concept.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conzx_Concept.TeaScore].ToString().Trim()); //教师评分
objzx_ConceptEN.IdCurrEduCls = objRow[conzx_Concept.IdCurrEduCls] == DBNull.Value ? null : objRow[conzx_Concept.IdCurrEduCls].ToString().Trim(); //教学班流水号
objzx_ConceptEN.PdfContent = objRow[conzx_Concept.PdfContent] == DBNull.Value ? null : objRow[conzx_Concept.PdfContent].ToString().Trim(); //Pdf内容
objzx_ConceptEN.PdfPageNum = objRow[conzx_Concept.PdfPageNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_Concept.PdfPageNum].ToString().Trim()); //Pdf页码
objzx_ConceptEN.CitationCount = objRow[conzx_Concept.CitationCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_Concept.CitationCount].ToString().Trim()); //引用统计
objzx_ConceptEN.VersionCount = objRow[conzx_Concept.VersionCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_Concept.VersionCount].ToString().Trim()); //版本统计
objzx_ConceptEN.zxShareId = objRow[conzx_Concept.zxShareId].ToString().Trim(); //分享Id
objzx_ConceptEN.CreateDate = objRow[conzx_Concept.CreateDate] == DBNull.Value ? null : objRow[conzx_Concept.CreateDate].ToString().Trim(); //建立日期
objzx_ConceptEN.UpdDate = objRow[conzx_Concept.UpdDate] == DBNull.Value ? null : objRow[conzx_Concept.UpdDate].ToString().Trim(); //修改日期
objzx_ConceptEN.UpdUser = objRow[conzx_Concept.UpdUser] == DBNull.Value ? null : objRow[conzx_Concept.UpdUser].ToString().Trim(); //修改人
objzx_ConceptEN.Memo = objRow[conzx_Concept.Memo] == DBNull.Value ? null : objRow[conzx_Concept.Memo].ToString().Trim(); //备注
objzx_ConceptEN.PdfDivLet = objRow[conzx_Concept.PdfDivLet] == DBNull.Value ? null : objRow[conzx_Concept.PdfDivLet].ToString().Trim(); //PdfDivLet
objzx_ConceptEN.PdfDivTop = objRow[conzx_Concept.PdfDivTop] == DBNull.Value ? null : objRow[conzx_Concept.PdfDivTop].ToString().Trim(); //PdfDivTop
objzx_ConceptEN.PdfPageNumIn = objRow[conzx_Concept.PdfPageNumIn] == DBNull.Value ? null : objRow[conzx_Concept.PdfPageNumIn].ToString().Trim(); //PdfPageNumIn
objzx_ConceptEN.PdfPageTop = objRow[conzx_Concept.PdfPageTop] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_Concept.PdfPageTop].ToString().Trim()); //pdf页面顶部位置
objzx_ConceptEN.PdfZoom = objRow[conzx_Concept.PdfZoom] == DBNull.Value ? null : objRow[conzx_Concept.PdfZoom].ToString().Trim(); //PdfZoom
objzx_ConceptEN.GroupTextId = objRow[conzx_Concept.GroupTextId] == DBNull.Value ? null : objRow[conzx_Concept.GroupTextId].ToString().Trim(); //小组Id
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objzx_ConceptEN.zxConceptId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objzx_ConceptEN);
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
public static List<clszx_ConceptEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clszx_ConceptEN> arrObjLst = new List<clszx_ConceptEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clszx_ConceptEN objzx_ConceptEN = new clszx_ConceptEN();
try
{
objzx_ConceptEN.zxConceptId = objRow[conzx_Concept.zxConceptId].ToString().Trim(); //概念Id
objzx_ConceptEN.ConceptName = objRow[conzx_Concept.ConceptName] == DBNull.Value ? null : objRow[conzx_Concept.ConceptName].ToString().Trim(); //概念名称
objzx_ConceptEN.ConceptContent = objRow[conzx_Concept.ConceptContent] == DBNull.Value ? null : objRow[conzx_Concept.ConceptContent].ToString().Trim(); //概念内容
objzx_ConceptEN.TextId = objRow[conzx_Concept.TextId] == DBNull.Value ? null : objRow[conzx_Concept.TextId].ToString().Trim(); //课件Id
objzx_ConceptEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[conzx_Concept.IsSubmit].ToString().Trim()); //是否提交
objzx_ConceptEN.VoteCount = objRow[conzx_Concept.VoteCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_Concept.VoteCount].ToString().Trim()); //点赞计数
objzx_ConceptEN.AppraiseCount = objRow[conzx_Concept.AppraiseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_Concept.AppraiseCount].ToString().Trim()); //评论数
objzx_ConceptEN.Score = objRow[conzx_Concept.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conzx_Concept.Score].ToString().Trim()); //评分
objzx_ConceptEN.StuScore = objRow[conzx_Concept.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conzx_Concept.StuScore].ToString().Trim()); //学生平均分
objzx_ConceptEN.TeaScore = objRow[conzx_Concept.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conzx_Concept.TeaScore].ToString().Trim()); //教师评分
objzx_ConceptEN.IdCurrEduCls = objRow[conzx_Concept.IdCurrEduCls] == DBNull.Value ? null : objRow[conzx_Concept.IdCurrEduCls].ToString().Trim(); //教学班流水号
objzx_ConceptEN.PdfContent = objRow[conzx_Concept.PdfContent] == DBNull.Value ? null : objRow[conzx_Concept.PdfContent].ToString().Trim(); //Pdf内容
objzx_ConceptEN.PdfPageNum = objRow[conzx_Concept.PdfPageNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_Concept.PdfPageNum].ToString().Trim()); //Pdf页码
objzx_ConceptEN.CitationCount = objRow[conzx_Concept.CitationCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_Concept.CitationCount].ToString().Trim()); //引用统计
objzx_ConceptEN.VersionCount = objRow[conzx_Concept.VersionCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_Concept.VersionCount].ToString().Trim()); //版本统计
objzx_ConceptEN.zxShareId = objRow[conzx_Concept.zxShareId].ToString().Trim(); //分享Id
objzx_ConceptEN.CreateDate = objRow[conzx_Concept.CreateDate] == DBNull.Value ? null : objRow[conzx_Concept.CreateDate].ToString().Trim(); //建立日期
objzx_ConceptEN.UpdDate = objRow[conzx_Concept.UpdDate] == DBNull.Value ? null : objRow[conzx_Concept.UpdDate].ToString().Trim(); //修改日期
objzx_ConceptEN.UpdUser = objRow[conzx_Concept.UpdUser] == DBNull.Value ? null : objRow[conzx_Concept.UpdUser].ToString().Trim(); //修改人
objzx_ConceptEN.Memo = objRow[conzx_Concept.Memo] == DBNull.Value ? null : objRow[conzx_Concept.Memo].ToString().Trim(); //备注
objzx_ConceptEN.PdfDivLet = objRow[conzx_Concept.PdfDivLet] == DBNull.Value ? null : objRow[conzx_Concept.PdfDivLet].ToString().Trim(); //PdfDivLet
objzx_ConceptEN.PdfDivTop = objRow[conzx_Concept.PdfDivTop] == DBNull.Value ? null : objRow[conzx_Concept.PdfDivTop].ToString().Trim(); //PdfDivTop
objzx_ConceptEN.PdfPageNumIn = objRow[conzx_Concept.PdfPageNumIn] == DBNull.Value ? null : objRow[conzx_Concept.PdfPageNumIn].ToString().Trim(); //PdfPageNumIn
objzx_ConceptEN.PdfPageTop = objRow[conzx_Concept.PdfPageTop] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_Concept.PdfPageTop].ToString().Trim()); //pdf页面顶部位置
objzx_ConceptEN.PdfZoom = objRow[conzx_Concept.PdfZoom] == DBNull.Value ? null : objRow[conzx_Concept.PdfZoom].ToString().Trim(); //PdfZoom
objzx_ConceptEN.GroupTextId = objRow[conzx_Concept.GroupTextId] == DBNull.Value ? null : objRow[conzx_Concept.GroupTextId].ToString().Trim(); //小组Id
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objzx_ConceptEN.zxConceptId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objzx_ConceptEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clszx_ConceptEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clszx_ConceptEN> arrObjLst = new List<clszx_ConceptEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clszx_ConceptEN objzx_ConceptEN = new clszx_ConceptEN();
try
{
objzx_ConceptEN.zxConceptId = objRow[conzx_Concept.zxConceptId].ToString().Trim(); //概念Id
objzx_ConceptEN.ConceptName = objRow[conzx_Concept.ConceptName] == DBNull.Value ? null : objRow[conzx_Concept.ConceptName].ToString().Trim(); //概念名称
objzx_ConceptEN.ConceptContent = objRow[conzx_Concept.ConceptContent] == DBNull.Value ? null : objRow[conzx_Concept.ConceptContent].ToString().Trim(); //概念内容
objzx_ConceptEN.TextId = objRow[conzx_Concept.TextId] == DBNull.Value ? null : objRow[conzx_Concept.TextId].ToString().Trim(); //课件Id
objzx_ConceptEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[conzx_Concept.IsSubmit].ToString().Trim()); //是否提交
objzx_ConceptEN.VoteCount = objRow[conzx_Concept.VoteCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_Concept.VoteCount].ToString().Trim()); //点赞计数
objzx_ConceptEN.AppraiseCount = objRow[conzx_Concept.AppraiseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_Concept.AppraiseCount].ToString().Trim()); //评论数
objzx_ConceptEN.Score = objRow[conzx_Concept.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conzx_Concept.Score].ToString().Trim()); //评分
objzx_ConceptEN.StuScore = objRow[conzx_Concept.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conzx_Concept.StuScore].ToString().Trim()); //学生平均分
objzx_ConceptEN.TeaScore = objRow[conzx_Concept.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conzx_Concept.TeaScore].ToString().Trim()); //教师评分
objzx_ConceptEN.IdCurrEduCls = objRow[conzx_Concept.IdCurrEduCls] == DBNull.Value ? null : objRow[conzx_Concept.IdCurrEduCls].ToString().Trim(); //教学班流水号
objzx_ConceptEN.PdfContent = objRow[conzx_Concept.PdfContent] == DBNull.Value ? null : objRow[conzx_Concept.PdfContent].ToString().Trim(); //Pdf内容
objzx_ConceptEN.PdfPageNum = objRow[conzx_Concept.PdfPageNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_Concept.PdfPageNum].ToString().Trim()); //Pdf页码
objzx_ConceptEN.CitationCount = objRow[conzx_Concept.CitationCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_Concept.CitationCount].ToString().Trim()); //引用统计
objzx_ConceptEN.VersionCount = objRow[conzx_Concept.VersionCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_Concept.VersionCount].ToString().Trim()); //版本统计
objzx_ConceptEN.zxShareId = objRow[conzx_Concept.zxShareId].ToString().Trim(); //分享Id
objzx_ConceptEN.CreateDate = objRow[conzx_Concept.CreateDate] == DBNull.Value ? null : objRow[conzx_Concept.CreateDate].ToString().Trim(); //建立日期
objzx_ConceptEN.UpdDate = objRow[conzx_Concept.UpdDate] == DBNull.Value ? null : objRow[conzx_Concept.UpdDate].ToString().Trim(); //修改日期
objzx_ConceptEN.UpdUser = objRow[conzx_Concept.UpdUser] == DBNull.Value ? null : objRow[conzx_Concept.UpdUser].ToString().Trim(); //修改人
objzx_ConceptEN.Memo = objRow[conzx_Concept.Memo] == DBNull.Value ? null : objRow[conzx_Concept.Memo].ToString().Trim(); //备注
objzx_ConceptEN.PdfDivLet = objRow[conzx_Concept.PdfDivLet] == DBNull.Value ? null : objRow[conzx_Concept.PdfDivLet].ToString().Trim(); //PdfDivLet
objzx_ConceptEN.PdfDivTop = objRow[conzx_Concept.PdfDivTop] == DBNull.Value ? null : objRow[conzx_Concept.PdfDivTop].ToString().Trim(); //PdfDivTop
objzx_ConceptEN.PdfPageNumIn = objRow[conzx_Concept.PdfPageNumIn] == DBNull.Value ? null : objRow[conzx_Concept.PdfPageNumIn].ToString().Trim(); //PdfPageNumIn
objzx_ConceptEN.PdfPageTop = objRow[conzx_Concept.PdfPageTop] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_Concept.PdfPageTop].ToString().Trim()); //pdf页面顶部位置
objzx_ConceptEN.PdfZoom = objRow[conzx_Concept.PdfZoom] == DBNull.Value ? null : objRow[conzx_Concept.PdfZoom].ToString().Trim(); //PdfZoom
objzx_ConceptEN.GroupTextId = objRow[conzx_Concept.GroupTextId] == DBNull.Value ? null : objRow[conzx_Concept.GroupTextId].ToString().Trim(); //小组Id
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objzx_ConceptEN.zxConceptId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objzx_ConceptEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objzx_ConceptEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool Getzx_Concept(ref clszx_ConceptEN objzx_ConceptEN)
{
bool bolResult = zx_ConceptDA.Getzx_Concept(ref objzx_ConceptEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "strzxConceptId">表关键字</param>
 /// <returns>表对象</returns>
public static clszx_ConceptEN GetObjByzxConceptId(string strzxConceptId)
{
if (strzxConceptId.IndexOf(' ') >=0)
{
var strMsg = string.Format("(errid:Busi000079)在表中,关键字[strzxConceptId]中不能有空格!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
if (string.IsNullOrEmpty(strzxConceptId) == true)
{
var strMsg = string.Format("(errid:Busi000020)在表中,关键字[strzxConceptId]不能为空!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
clszx_ConceptEN objzx_ConceptEN = zx_ConceptDA.GetObjByzxConceptId(strzxConceptId);
return objzx_ConceptEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clszx_ConceptEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clszx_ConceptEN objzx_ConceptEN = zx_ConceptDA.GetFirstObj(strWhereCond);
 return objzx_ConceptEN;
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
public static clszx_ConceptEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clszx_ConceptEN objzx_ConceptEN = zx_ConceptDA.GetObjByDataRow(objRow);
 return objzx_ConceptEN;
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
public static clszx_ConceptEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clszx_ConceptEN objzx_ConceptEN = zx_ConceptDA.GetObjByDataRow(objRow);
 return objzx_ConceptEN;
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
 /// <param name = "strzxConceptId">所给的关键字</param>
 /// <param name = "lstzx_ConceptObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clszx_ConceptEN GetObjByzxConceptIdFromList(string strzxConceptId, List<clszx_ConceptEN> lstzx_ConceptObjLst)
{
foreach (clszx_ConceptEN objzx_ConceptEN in lstzx_ConceptObjLst)
{
if (objzx_ConceptEN.zxConceptId == strzxConceptId)
{
return objzx_ConceptEN;
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
 string strMaxZxConceptId;
 try
 {
 strMaxZxConceptId = clszx_ConceptDA.GetMaxStrId();
 return strMaxZxConceptId;
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
 string strzxConceptId;
 try
 {
 strzxConceptId = new clszx_ConceptDA().GetFirstID(strWhereCond);
 return strzxConceptId;
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
 arrList = zx_ConceptDA.GetID(strWhereCond);
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
bool bolIsExist = zx_ConceptDA.IsExistCondRec(strWhereCond);
return bolIsExist;
}

 /// <summary>
 /// 判断当前表中是否存在给定关键字值的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExist)
 /// </summary>
 /// <param name = "strzxConceptId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public static bool IsExist(string strzxConceptId)
{
if (string.IsNullOrEmpty(strzxConceptId) == true)
{
var strMsg = string.Format("(errid:Busi000027)在表中,关键字[strzxConceptId]不能为空!!(from {0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
//检测记录是否存在
bool bolIsExist = zx_ConceptDA.IsExist(strzxConceptId);
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
 bolIsExist = clszx_ConceptDA.IsExistTable();
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
 bolIsExist = zx_ConceptDA.IsExistTable(strTabName);
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
 /// <param name = "objzx_ConceptEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecordBySql2(clszx_ConceptEN objzx_ConceptEN)
{
if (objzx_ConceptEN.CheckUniqueness() == false)
{
var strMsg = string.Format("记录已经存在!课件Id = [{0}]的数据已经存在!(in clszx_ConceptBL.AddNewRecordBySql2)", objzx_ConceptEN.TextId);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objzx_ConceptEN.zxConceptId) == true || clszx_ConceptBL.IsExist(objzx_ConceptEN.zxConceptId) == true)
 {
     objzx_ConceptEN.zxConceptId = clszx_ConceptBL.GetMaxStrId_S();
 }
bool bolResult = zx_ConceptDA.AddNewRecordBySQL2(objzx_ConceptEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clszx_ConceptBL.ReFreshCache(objzx_ConceptEN.IdCurrEduCls);

if (clszx_ConceptBL.relatedActions != null)
{
clszx_ConceptBL.relatedActions.UpdRelaTabDate(objzx_ConceptEN.zxConceptId, "SetUpdDate");
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
 /// <param name = "objzx_ConceptEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordBySql2WithReturnKey(clszx_ConceptEN objzx_ConceptEN)
{
if (objzx_ConceptEN.CheckUniqueness() == false)
{
var strMsg = string.Format("记录已经存在!课件Id = [{0}]的数据已经存在!(in clszx_ConceptBL.AddNewRecordBySql2WithReturnKey)", objzx_ConceptEN.TextId);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objzx_ConceptEN.zxConceptId) == true || clszx_ConceptBL.IsExist(objzx_ConceptEN.zxConceptId) == true)
 {
     objzx_ConceptEN.zxConceptId = clszx_ConceptBL.GetMaxStrId_S();
 }
string strKey = zx_ConceptDA.AddNewRecordBySQL2WithReturnKey(objzx_ConceptEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clszx_ConceptBL.ReFreshCache(objzx_ConceptEN.IdCurrEduCls);

if (clszx_ConceptBL.relatedActions != null)
{
clszx_ConceptBL.relatedActions.UpdRelaTabDate(objzx_ConceptEN.zxConceptId, "SetUpdDate");
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
 /// <param name = "objzx_ConceptEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(clszx_ConceptEN objzx_ConceptEN)
{
try
{
bool bolResult = zx_ConceptDA.Update(objzx_ConceptEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clszx_ConceptBL.ReFreshCache(objzx_ConceptEN.IdCurrEduCls);

if (clszx_ConceptBL.relatedActions != null)
{
clszx_ConceptBL.relatedActions.UpdRelaTabDate(objzx_ConceptEN.zxConceptId, "SetUpdDate");
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
 /// <param name = "objzx_ConceptEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateBySql2(clszx_ConceptEN objzx_ConceptEN)
{
 if (string.IsNullOrEmpty(objzx_ConceptEN.zxConceptId) == true)
 {
var strMsg = string.Format("(errid:Busi000065)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = zx_ConceptDA.UpdateBySql2(objzx_ConceptEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clszx_ConceptBL.ReFreshCache(objzx_ConceptEN.IdCurrEduCls);

if (clszx_ConceptBL.relatedActions != null)
{
clszx_ConceptBL.relatedActions.UpdRelaTabDate(objzx_ConceptEN.zxConceptId, "SetUpdDate");
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
 /// <param name = "strzxConceptId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int DelRecord(string strzxConceptId)
{
try
{
 clszx_ConceptEN objzx_ConceptEN = clszx_ConceptBL.GetObjByzxConceptId(strzxConceptId);

if (clszx_ConceptBL.relatedActions != null)
{
clszx_ConceptBL.relatedActions.UpdRelaTabDate(objzx_ConceptEN.zxConceptId, "SetUpdDate");
}
if (objzx_ConceptEN != null)
{
int intRecNum = zx_ConceptDA.DelRecord(strzxConceptId);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
ReFreshCache(objzx_ConceptEN.IdCurrEduCls);
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
/// <param name="strzxConceptId">表关键字</param>
 /// <param name = "strIdCurrEduCls">缓存的分类字段</param>
/// <returns></returns>
public static bool DelRecordEx(string strzxConceptId , string strIdCurrEduCls)
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clszx_ConceptDA.GetSpecSQLObj();
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
//删除与表:[zx_Concept]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conzx_Concept.zxConceptId,
//strzxConceptId);
//        clszx_ConceptBL.Delzx_ConceptsByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clszx_ConceptBL.DelRecord(strzxConceptId, strIdCurrEduCls, objConnection, objSqlTransaction);
objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clszx_ConceptBLEx", "DelRecordEx", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("扩展删除记录出错:{0}!keyId = {1}.({2})",
objException.Message,
strzxConceptId, clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "strzxConceptId">给定的关键字值</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回删除是否成功?</returns>
public static bool DelRecord(string strzxConceptId, string strIdCurrEduCls, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
if (clszx_ConceptBL.relatedActions != null)
{
clszx_ConceptBL.relatedActions.UpdRelaTabDate(strzxConceptId, "UpdRelaTabDate");
}
bool bolResult = zx_ConceptDA.DelRecord(strzxConceptId,objSqlConnection,objSqlTransaction);
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
 /// <param name = "arrzxConceptIdLst">给定的关键字值列表</param>
 /// <returns>返回删除的记录数</returns>
public static int Delzx_Concepts(List<string> arrzxConceptIdLst)
{
if (arrzxConceptIdLst.Count == 0) return 0;
try
{
if (clszx_ConceptBL.relatedActions != null)
{
foreach (var strzxConceptId in arrzxConceptIdLst)
{
clszx_ConceptBL.relatedActions.UpdRelaTabDate(strzxConceptId, "UpdRelaTabDate");
}
}
 clszx_ConceptEN objzx_ConceptEN = clszx_ConceptBL.GetObjByzxConceptId(arrzxConceptIdLst[0]);
int intDelRecNum = zx_ConceptDA.Delzx_Concept(arrzxConceptIdLst);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
ReFreshCache(objzx_ConceptEN.IdCurrEduCls);
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
public static int Delzx_ConceptsByCond(string strWhereCond)
{
try
{
if (clszx_ConceptBL.relatedActions != null)
{
List<string> arrzxConceptId = GetPrimaryKeyID_S(strWhereCond);
foreach (var strzxConceptId in arrzxConceptId)
{
clszx_ConceptBL.relatedActions.UpdRelaTabDate(strzxConceptId, "UpdRelaTabDate");
}
}
List<string> arrIdCurrEduCls = GetFldValue(conzx_Concept.IdCurrEduCls, strWhereCond);
int intRecNum = zx_ConceptDA.Delzx_Concept(strWhereCond);
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
/// 这里仅仅是演示函数,使用时请复制到扩展类:[zx_Concept]中改名为:[DelRecord4MultiTabEx]使用
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DelRecord4MultiTab)
/// </summary>
/// <param name="strzxConceptId">表关键字</param>
 /// <param name = "strIdCurrEduCls">缓存的分类字段</param>
/// <returns></returns>
public static bool DelRecord4MultiTab(string strzxConceptId, string strIdCurrEduCls)
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clszx_ConceptDA.GetSpecSQLObj();
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
//删除与表:[zx_Concept]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conStudent.id_College,
//strid_College);
//        clsStudentBL.DelStudentsByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clszx_ConceptBL.DelRecord(strzxConceptId, strIdCurrEduCls, objConnection, objSqlTransaction);
                objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clszx_ConceptBL", "DelRecord4MultiTab", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("删除多表记录出错:{0}!keyId = {1}.({2})",
objException.Message,
strzxConceptId, clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "objzx_ConceptENS">源对象</param>
 /// <param name = "objzx_ConceptENT">目标对象</param>
 public static void CopyTo(clszx_ConceptEN objzx_ConceptENS, clszx_ConceptEN objzx_ConceptENT)
{
try
{
objzx_ConceptENT.zxConceptId = objzx_ConceptENS.zxConceptId; //概念Id
objzx_ConceptENT.ConceptName = objzx_ConceptENS.ConceptName; //概念名称
objzx_ConceptENT.ConceptContent = objzx_ConceptENS.ConceptContent; //概念内容
objzx_ConceptENT.TextId = objzx_ConceptENS.TextId; //课件Id
objzx_ConceptENT.IsSubmit = objzx_ConceptENS.IsSubmit; //是否提交
objzx_ConceptENT.VoteCount = objzx_ConceptENS.VoteCount; //点赞计数
objzx_ConceptENT.AppraiseCount = objzx_ConceptENS.AppraiseCount; //评论数
objzx_ConceptENT.Score = objzx_ConceptENS.Score; //评分
objzx_ConceptENT.StuScore = objzx_ConceptENS.StuScore; //学生平均分
objzx_ConceptENT.TeaScore = objzx_ConceptENS.TeaScore; //教师评分
objzx_ConceptENT.IdCurrEduCls = objzx_ConceptENS.IdCurrEduCls; //教学班流水号
objzx_ConceptENT.PdfContent = objzx_ConceptENS.PdfContent; //Pdf内容
objzx_ConceptENT.PdfPageNum = objzx_ConceptENS.PdfPageNum; //Pdf页码
objzx_ConceptENT.CitationCount = objzx_ConceptENS.CitationCount; //引用统计
objzx_ConceptENT.VersionCount = objzx_ConceptENS.VersionCount; //版本统计
objzx_ConceptENT.zxShareId = objzx_ConceptENS.zxShareId; //分享Id
objzx_ConceptENT.CreateDate = objzx_ConceptENS.CreateDate; //建立日期
objzx_ConceptENT.UpdDate = objzx_ConceptENS.UpdDate; //修改日期
objzx_ConceptENT.UpdUser = objzx_ConceptENS.UpdUser; //修改人
objzx_ConceptENT.Memo = objzx_ConceptENS.Memo; //备注
objzx_ConceptENT.PdfDivLet = objzx_ConceptENS.PdfDivLet; //PdfDivLet
objzx_ConceptENT.PdfDivTop = objzx_ConceptENS.PdfDivTop; //PdfDivTop
objzx_ConceptENT.PdfPageNumIn = objzx_ConceptENS.PdfPageNumIn; //PdfPageNumIn
objzx_ConceptENT.PdfPageTop = objzx_ConceptENS.PdfPageTop; //pdf页面顶部位置
objzx_ConceptENT.PdfZoom = objzx_ConceptENS.PdfZoom; //PdfZoom
objzx_ConceptENT.GroupTextId = objzx_ConceptENS.GroupTextId; //小组Id
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
 /// <param name = "objzx_ConceptEN">源简化对象</param>
 public static void SetUpdFlag(clszx_ConceptEN objzx_ConceptEN)
{
try
{
objzx_ConceptEN.ClearUpdateState();
   string strsfUpdFldSetStr = objzx_ConceptEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(conzx_Concept.zxConceptId, new clsStrCompareIgnoreCase())  ==  true)
{
objzx_ConceptEN.zxConceptId = objzx_ConceptEN.zxConceptId; //概念Id
}
if (arrFldSet.Contains(conzx_Concept.ConceptName, new clsStrCompareIgnoreCase())  ==  true)
{
objzx_ConceptEN.ConceptName = objzx_ConceptEN.ConceptName == "[null]" ? null :  objzx_ConceptEN.ConceptName; //概念名称
}
if (arrFldSet.Contains(conzx_Concept.ConceptContent, new clsStrCompareIgnoreCase())  ==  true)
{
objzx_ConceptEN.ConceptContent = objzx_ConceptEN.ConceptContent == "[null]" ? null :  objzx_ConceptEN.ConceptContent; //概念内容
}
if (arrFldSet.Contains(conzx_Concept.TextId, new clsStrCompareIgnoreCase())  ==  true)
{
objzx_ConceptEN.TextId = objzx_ConceptEN.TextId == "[null]" ? null :  objzx_ConceptEN.TextId; //课件Id
}
if (arrFldSet.Contains(conzx_Concept.IsSubmit, new clsStrCompareIgnoreCase())  ==  true)
{
objzx_ConceptEN.IsSubmit = objzx_ConceptEN.IsSubmit; //是否提交
}
if (arrFldSet.Contains(conzx_Concept.VoteCount, new clsStrCompareIgnoreCase())  ==  true)
{
objzx_ConceptEN.VoteCount = objzx_ConceptEN.VoteCount; //点赞计数
}
if (arrFldSet.Contains(conzx_Concept.AppraiseCount, new clsStrCompareIgnoreCase())  ==  true)
{
objzx_ConceptEN.AppraiseCount = objzx_ConceptEN.AppraiseCount; //评论数
}
if (arrFldSet.Contains(conzx_Concept.Score, new clsStrCompareIgnoreCase())  ==  true)
{
objzx_ConceptEN.Score = objzx_ConceptEN.Score; //评分
}
if (arrFldSet.Contains(conzx_Concept.StuScore, new clsStrCompareIgnoreCase())  ==  true)
{
objzx_ConceptEN.StuScore = objzx_ConceptEN.StuScore; //学生平均分
}
if (arrFldSet.Contains(conzx_Concept.TeaScore, new clsStrCompareIgnoreCase())  ==  true)
{
objzx_ConceptEN.TeaScore = objzx_ConceptEN.TeaScore; //教师评分
}
if (arrFldSet.Contains(conzx_Concept.IdCurrEduCls, new clsStrCompareIgnoreCase())  ==  true)
{
objzx_ConceptEN.IdCurrEduCls = objzx_ConceptEN.IdCurrEduCls == "[null]" ? null :  objzx_ConceptEN.IdCurrEduCls; //教学班流水号
}
if (arrFldSet.Contains(conzx_Concept.PdfContent, new clsStrCompareIgnoreCase())  ==  true)
{
objzx_ConceptEN.PdfContent = objzx_ConceptEN.PdfContent == "[null]" ? null :  objzx_ConceptEN.PdfContent; //Pdf内容
}
if (arrFldSet.Contains(conzx_Concept.PdfPageNum, new clsStrCompareIgnoreCase())  ==  true)
{
objzx_ConceptEN.PdfPageNum = objzx_ConceptEN.PdfPageNum; //Pdf页码
}
if (arrFldSet.Contains(conzx_Concept.CitationCount, new clsStrCompareIgnoreCase())  ==  true)
{
objzx_ConceptEN.CitationCount = objzx_ConceptEN.CitationCount; //引用统计
}
if (arrFldSet.Contains(conzx_Concept.VersionCount, new clsStrCompareIgnoreCase())  ==  true)
{
objzx_ConceptEN.VersionCount = objzx_ConceptEN.VersionCount; //版本统计
}
if (arrFldSet.Contains(conzx_Concept.zxShareId, new clsStrCompareIgnoreCase())  ==  true)
{
objzx_ConceptEN.zxShareId = objzx_ConceptEN.zxShareId; //分享Id
}
if (arrFldSet.Contains(conzx_Concept.CreateDate, new clsStrCompareIgnoreCase())  ==  true)
{
objzx_ConceptEN.CreateDate = objzx_ConceptEN.CreateDate == "[null]" ? null :  objzx_ConceptEN.CreateDate; //建立日期
}
if (arrFldSet.Contains(conzx_Concept.UpdDate, new clsStrCompareIgnoreCase())  ==  true)
{
objzx_ConceptEN.UpdDate = objzx_ConceptEN.UpdDate == "[null]" ? null :  objzx_ConceptEN.UpdDate; //修改日期
}
if (arrFldSet.Contains(conzx_Concept.UpdUser, new clsStrCompareIgnoreCase())  ==  true)
{
objzx_ConceptEN.UpdUser = objzx_ConceptEN.UpdUser == "[null]" ? null :  objzx_ConceptEN.UpdUser; //修改人
}
if (arrFldSet.Contains(conzx_Concept.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objzx_ConceptEN.Memo = objzx_ConceptEN.Memo == "[null]" ? null :  objzx_ConceptEN.Memo; //备注
}
if (arrFldSet.Contains(conzx_Concept.PdfDivLet, new clsStrCompareIgnoreCase())  ==  true)
{
objzx_ConceptEN.PdfDivLet = objzx_ConceptEN.PdfDivLet == "[null]" ? null :  objzx_ConceptEN.PdfDivLet; //PdfDivLet
}
if (arrFldSet.Contains(conzx_Concept.PdfDivTop, new clsStrCompareIgnoreCase())  ==  true)
{
objzx_ConceptEN.PdfDivTop = objzx_ConceptEN.PdfDivTop == "[null]" ? null :  objzx_ConceptEN.PdfDivTop; //PdfDivTop
}
if (arrFldSet.Contains(conzx_Concept.PdfPageNumIn, new clsStrCompareIgnoreCase())  ==  true)
{
objzx_ConceptEN.PdfPageNumIn = objzx_ConceptEN.PdfPageNumIn == "[null]" ? null :  objzx_ConceptEN.PdfPageNumIn; //PdfPageNumIn
}
if (arrFldSet.Contains(conzx_Concept.PdfPageTop, new clsStrCompareIgnoreCase())  ==  true)
{
objzx_ConceptEN.PdfPageTop = objzx_ConceptEN.PdfPageTop; //pdf页面顶部位置
}
if (arrFldSet.Contains(conzx_Concept.PdfZoom, new clsStrCompareIgnoreCase())  ==  true)
{
objzx_ConceptEN.PdfZoom = objzx_ConceptEN.PdfZoom == "[null]" ? null :  objzx_ConceptEN.PdfZoom; //PdfZoom
}
if (arrFldSet.Contains(conzx_Concept.GroupTextId, new clsStrCompareIgnoreCase())  ==  true)
{
objzx_ConceptEN.GroupTextId = objzx_ConceptEN.GroupTextId == "[null]" ? null :  objzx_ConceptEN.GroupTextId; //小组Id
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
 /// <param name = "objzx_ConceptEN">源简化对象</param>
 public static void AccessFldValueNull(clszx_ConceptEN objzx_ConceptEN)
{
try
{
if (objzx_ConceptEN.ConceptName == "[null]") objzx_ConceptEN.ConceptName = null; //概念名称
if (objzx_ConceptEN.ConceptContent == "[null]") objzx_ConceptEN.ConceptContent = null; //概念内容
if (objzx_ConceptEN.TextId == "[null]") objzx_ConceptEN.TextId = null; //课件Id
if (objzx_ConceptEN.IdCurrEduCls == "[null]") objzx_ConceptEN.IdCurrEduCls = null; //教学班流水号
if (objzx_ConceptEN.PdfContent == "[null]") objzx_ConceptEN.PdfContent = null; //Pdf内容
if (objzx_ConceptEN.CreateDate == "[null]") objzx_ConceptEN.CreateDate = null; //建立日期
if (objzx_ConceptEN.UpdDate == "[null]") objzx_ConceptEN.UpdDate = null; //修改日期
if (objzx_ConceptEN.UpdUser == "[null]") objzx_ConceptEN.UpdUser = null; //修改人
if (objzx_ConceptEN.Memo == "[null]") objzx_ConceptEN.Memo = null; //备注
if (objzx_ConceptEN.PdfDivLet == "[null]") objzx_ConceptEN.PdfDivLet = null; //PdfDivLet
if (objzx_ConceptEN.PdfDivTop == "[null]") objzx_ConceptEN.PdfDivTop = null; //PdfDivTop
if (objzx_ConceptEN.PdfPageNumIn == "[null]") objzx_ConceptEN.PdfPageNumIn = null; //PdfPageNumIn
if (objzx_ConceptEN.PdfZoom == "[null]") objzx_ConceptEN.PdfZoom = null; //PdfZoom
if (objzx_ConceptEN.GroupTextId == "[null]") objzx_ConceptEN.GroupTextId = null; //小组Id
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
public static void CheckPropertyNew(clszx_ConceptEN objzx_ConceptEN)
{
 zx_ConceptDA.CheckPropertyNew(objzx_ConceptEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(clszx_ConceptEN objzx_ConceptEN)
{
 zx_ConceptDA.CheckProperty4Condition(objzx_ConceptEN);
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
if (clszx_ConceptBL.objCommFun4BL == null)
{
strMsg = string.Format("类clszx_ConceptBL没有刷新缓存机制(clszx_ConceptBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by zxConceptId");
//if (arrzx_ConceptObjLstCache == null)
//{
//arrzx_ConceptObjLstCache = zx_ConceptDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "strzxConceptId">所给的关键字</param>
 /// <param name = "strIdCurrEduCls">缓存的分类字段</param>
 /// <returns>根据关键字获取的对象</returns>
public static clszx_ConceptEN GetObjByzxConceptIdCache(string strzxConceptId, string strIdCurrEduCls)
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
string strKey = string.Format("{0}_{1}", clszx_ConceptEN._CurrTabName, strIdCurrEduCls);
List<clszx_ConceptEN> arrzx_ConceptObjLstCache = GetObjLstCache(strIdCurrEduCls);
IEnumerable <clszx_ConceptEN> arrzx_ConceptObjLst_Sel =
arrzx_ConceptObjLstCache
.Where(x=> x.zxConceptId == strzxConceptId 
);
if (arrzx_ConceptObjLst_Sel.Count() == 0)
{
   clszx_ConceptEN obj = clszx_ConceptBL.GetObjByzxConceptId(strzxConceptId);
   if (obj != null)
 {
if (obj.IdCurrEduCls == strIdCurrEduCls)
{
CacheHelper.Remove(strKey);
     return obj;
}
else
{
string strMsg = string.Format("错误: 关键字:{0}不属于分类:{1},请检查!(In {2})", strzxConceptId, strIdCurrEduCls, clsStackTrace.GetCurrClassFunction());
clsSysParaEN.objLog.WriteDebugLog(strMsg);
throw new Exception(strMsg);
}
 }
return null;
}
return arrzx_ConceptObjLst_Sel.First();
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clszx_ConceptEN> GetAllzx_ConceptObjLstCache(string strIdCurrEduCls)
{
//获取缓存中的对象列表
List<clszx_ConceptEN> arrzx_ConceptObjLstCache = GetObjLstCache(strIdCurrEduCls); 
return arrzx_ConceptObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clszx_ConceptEN> GetObjLstCache(string strIdCurrEduCls)
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
string strKey = string.Format("{0}_{1}", clszx_ConceptEN._CurrTabName, strIdCurrEduCls);
string strCondition = string.Format("IdCurrEduCls='{0}'", strIdCurrEduCls);
List<clszx_ConceptEN> arrzx_ConceptObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst(strCondition); });
return arrzx_ConceptObjLstCache;
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
string strKey = string.Format("{0}_{1}", clszx_ConceptEN._CurrTabName, strIdCurrEduCls);
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
public static void ReFreshCache(string strIdCurrEduCls)
{
if (string.IsNullOrEmpty(strIdCurrEduCls) == true)
{
string strMsg = string.Format("缓存分类字段:[IdCurrEduCls]不能为空!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clszx_ConceptBL.objCommFun4BL != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}_{1}", clszx_ConceptEN._CurrTabName, strIdCurrEduCls);
CacheHelper.Remove(strKey);
clszx_ConceptBL.objCommFun4BL.ReFreshCache(strIdCurrEduCls);
}
}


 #endregion 缓存操作


 #region 检查唯一性

 /// <summary>
 /// 获取检查唯一性条件串(Uniqueness)--zx_Concept(中学概念表)
 /// 唯一性条件:TextId
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetUniquenessConditionString)
 /// </summary>
 /// <param name = "objzx_ConceptEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(clszx_ConceptEN objzx_ConceptEN)
{
//检测记录是否存在
string strResult = zx_ConceptDA.GetUniCondStr(objzx_ConceptEN);
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
 /// <param name = "strIdCurrEduCls">缓存的分类字段</param>
 /// <returns>返回一个输出字段值</returns>
public static string Func(string strInFldName, string strOutFldName, string strzxConceptId, string strIdCurrEduCls)
{
if (strInFldName != conzx_Concept.zxConceptId)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (conzx_Concept.AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", conzx_Concept.AttributeName));
throw new Exception(strMsg);
}
var objzx_Concept = clszx_ConceptBL.GetObjByzxConceptIdCache(strzxConceptId, strIdCurrEduCls);
if (objzx_Concept == null) return "";
return objzx_Concept[strOutFldName].ToString();
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
int intRecCount = clszx_ConceptDA.GetRecCount(strTabName);
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
int intRecCount = clszx_ConceptDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clszx_ConceptDA.GetRecCount();
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
int intRecCount = clszx_ConceptDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objzx_ConceptCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clszx_ConceptEN objzx_ConceptCond)
{
 string strIdCurrEduCls = objzx_ConceptCond.IdCurrEduCls;
 if (string.IsNullOrEmpty(strIdCurrEduCls) == true)
{
string strMsg = string.Format("(errid:Busi000174)在表中,缓存分类字段值不能为空!(clszx_ConceptBL:GetRecCountByCondCache)");
throw new Exception(strMsg);
}
List<clszx_ConceptEN> arrObjLstCache = GetObjLstCache(strIdCurrEduCls);
IEnumerable <clszx_ConceptEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conzx_Concept.AttributeName)
{
if (objzx_ConceptCond.IsUpdated(strFldName) == false) continue;
if (objzx_ConceptCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objzx_ConceptCond[strFldName].ToString());
}
else
{
if (objzx_ConceptCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objzx_ConceptCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objzx_ConceptCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objzx_ConceptCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objzx_ConceptCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objzx_ConceptCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objzx_ConceptCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objzx_ConceptCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objzx_ConceptCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objzx_ConceptCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objzx_ConceptCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objzx_ConceptCond[strFldName]));
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
 List<string> arrList = clszx_ConceptDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = zx_ConceptDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = zx_ConceptDA.GetFldValueNoDistinct(strFldName, strWhereCond);
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
int intRecCount = zx_ConceptDA.SetFldValue(strFldName, strValue, strWhereCond);
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
int intRecCount = clszx_ConceptDA.SetFldValue(clszx_ConceptEN._CurrTabName, strFldName, fltValue, strWhereCond);
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
int intRecCount = zx_ConceptDA.SetFldValue( strFldName, intValue, strWhereCond);
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
int intRecCount = clszx_ConceptDA.SetFldValue(strTabName, strFldName, strValue, strWhereCond);
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
int intRecCount = clszx_ConceptDA.SetFldValue(strTabName, strFldName, intValue, strWhereCond);
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
int intRecCount = clszx_ConceptDA.SetFldValue(strTabName, strFldName, fltValue, strWhereCond);
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
  strCreateTabCode.Append("CREATE table [dbo].[zx_Concept] "); 
 strCreateTabCode.Append(" ( "); 
 // /**概念Id*/ 
 strCreateTabCode.Append(" zxConceptId char(8) primary key, "); 
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
 // /**建立日期*/ 
 strCreateTabCode.Append(" CreateDate varchar(20) Null, "); 
 // /**修改日期*/ 
 strCreateTabCode.Append(" UpdDate varchar(20) Null, "); 
 // /**修改人*/ 
 strCreateTabCode.Append(" UpdUser varchar(20) Null, "); 
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
 /// 中学概念表(zx_Concept)
 /// 数据源类型:表
 /// (AutoGCLib.CommFun4BL4CSharp:GeneCode_This)
 /// </summary>
public class  clsCommFun4BL4zx_Concept : clsCommFun4BLV2
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
clszx_ConceptBL.ReFreshThisCache(strIdCurrEduCls);
}
}

}