
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clszx_SkillBL
 表名:zx_Skill(01120706)
 * 版本:2023.11.15.1(服务器:WIN-SRV103-116)
 日期:2023/11/15 23:07:43
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
public static class  clszx_SkillBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "strzxSkillId">表关键字</param>
 /// <returns>表对象</returns>
public static clszx_SkillEN GetObj(this K_zxSkillId_zx_Skill myKey)
{
clszx_SkillEN objzx_SkillEN = clszx_SkillBL.zx_SkillDA.GetObjByzxSkillId(myKey.Value);
return objzx_SkillEN;
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_AddNewRecord)
 /// </summary>
 /// <param name = "objzx_SkillEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clszx_SkillEN objzx_SkillEN)
{
if (CheckUniqueness(objzx_SkillEN) == false)
{
var strMsg = string.Format("记录已经存在!课件Id = [{0}]的数据已经存在!(in clszx_SkillBL.AddNewRecord)", objzx_SkillEN.TextId);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objzx_SkillEN.zxSkillId) == true || clszx_SkillBL.IsExist(objzx_SkillEN.zxSkillId) == true)
 {
     objzx_SkillEN.zxSkillId = clszx_SkillBL.GetMaxStrId_S();
 }
bool bolResult = clszx_SkillBL.zx_SkillDA.AddNewRecordBySQL2(objzx_SkillEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clszx_SkillBL.ReFreshCache(objzx_SkillEN.IdCurrEduCls);

if (clszx_SkillBL.relatedActions != null)
{
clszx_SkillBL.relatedActions.UpdRelaTabDate(objzx_SkillEN.zxSkillId, "SetUpdDate");
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
public static bool AddRecordEx(this clszx_SkillEN objzx_SkillEN)
{
//操作步骤:
//1、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在
//2、检查唯一性
//3、检查传进去的对象属性是否合法
//4、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
//1、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在

//因为是字符型自增主键,不需要检查主键是否已经存在,在添加时,再获取 最大值作为主键
//if (clszx_SkillBL.IsExist(objzx_SkillEN.zxSkillId))	//判断是否有相同的关键字
//{
//strMsg = "(errid:Busi000151)关键字字段已有相同的值";
//throw new Exception(strMsg);
//}
try
{
 //2、检查传进去的对象属性是否合法
objzx_SkillEN.CheckPropertyNew();
 ///5.2、检查唯一性
if (objzx_SkillEN.CheckUniqueness() == false)
{
strMsg = string.Format("(课件Id(TextId)=[{0}])已经存在,不能重复!", objzx_SkillEN.TextId);
throw new Exception(strMsg);
}
//因为是字符型自增主键,所以在添加时,自动获取主键值。
 if (string.IsNullOrEmpty(objzx_SkillEN.zxSkillId) == true || clszx_SkillBL.IsExist(objzx_SkillEN.zxSkillId) == true)
 {
     objzx_SkillEN.zxSkillId = clszx_SkillBL.GetMaxStrId_S();
 }
//6、把数据实体层的数据存贮到数据库中
objzx_SkillEN.AddNewRecord();
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
 /// <param name = "objzx_SkillEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static string AddNewRecordWithMaxId(this clszx_SkillEN objzx_SkillEN)
{
if (CheckUniqueness(objzx_SkillEN) == false)
{
var strMsg = string.Format("记录已经存在!课件Id = [{0}]的数据已经存在!(in clszx_SkillBL.AddNewRecordWithMaxId)", objzx_SkillEN.TextId);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objzx_SkillEN.zxSkillId) == true || clszx_SkillBL.IsExist(objzx_SkillEN.zxSkillId) == true)
 {
     objzx_SkillEN.zxSkillId = clszx_SkillBL.GetMaxStrId_S();
 }
string strzxSkillId = clszx_SkillBL.zx_SkillDA.AddNewRecordBySQL2WithReturnKey(objzx_SkillEN);
     objzx_SkillEN.zxSkillId = strzxSkillId;
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clszx_SkillBL.ReFreshCache(objzx_SkillEN.IdCurrEduCls);

if (clszx_SkillBL.relatedActions != null)
{
clszx_SkillBL.relatedActions.UpdRelaTabDate(objzx_SkillEN.zxSkillId, "SetUpdDate");
}
return strzxSkillId;
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
 /// <param name = "objzx_SkillEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordWithReturnKey(this clszx_SkillEN objzx_SkillEN)
{
if (CheckUniqueness(objzx_SkillEN) == false)
{
var strMsg = string.Format("记录已经存在!课件Id = [{0}]的数据已经存在!(in clszx_SkillBL.AddNewRecordWithReturnKey)", objzx_SkillEN.TextId);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objzx_SkillEN.zxSkillId) == true || clszx_SkillBL.IsExist(objzx_SkillEN.zxSkillId) == true)
 {
     objzx_SkillEN.zxSkillId = clszx_SkillBL.GetMaxStrId_S();
 }
string strKey = clszx_SkillBL.zx_SkillDA.AddNewRecordBySQL2WithReturnKey(objzx_SkillEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clszx_SkillBL.ReFreshCache(objzx_SkillEN.IdCurrEduCls);

if (clszx_SkillBL.relatedActions != null)
{
clszx_SkillBL.relatedActions.UpdRelaTabDate(objzx_SkillEN.zxSkillId, "SetUpdDate");
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
 /// <param name = "objzx_SkillEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clszx_SkillEN SetzxSkillId(this clszx_SkillEN objzx_SkillEN, string strzxSkillId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strzxSkillId, 10, conzx_Skill.zxSkillId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strzxSkillId, 10, conzx_Skill.zxSkillId);
}
objzx_SkillEN.zxSkillId = strzxSkillId; //技能Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objzx_SkillEN.dicFldComparisonOp.ContainsKey(conzx_Skill.zxSkillId) == false)
{
objzx_SkillEN.dicFldComparisonOp.Add(conzx_Skill.zxSkillId, strComparisonOp);
}
else
{
objzx_SkillEN.dicFldComparisonOp[conzx_Skill.zxSkillId] = strComparisonOp;
}
}
return objzx_SkillEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objzx_SkillEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clszx_SkillEN SetSkillName(this clszx_SkillEN objzx_SkillEN, string strSkillName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strSkillName, 200, conzx_Skill.SkillName);
}
objzx_SkillEN.SkillName = strSkillName; //技能名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objzx_SkillEN.dicFldComparisonOp.ContainsKey(conzx_Skill.SkillName) == false)
{
objzx_SkillEN.dicFldComparisonOp.Add(conzx_Skill.SkillName, strComparisonOp);
}
else
{
objzx_SkillEN.dicFldComparisonOp[conzx_Skill.SkillName] = strComparisonOp;
}
}
return objzx_SkillEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objzx_SkillEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clszx_SkillEN SetzxOperationTypeId(this clszx_SkillEN objzx_SkillEN, string strzxOperationTypeId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strzxOperationTypeId, 2, conzx_Skill.zxOperationTypeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strzxOperationTypeId, 2, conzx_Skill.zxOperationTypeId);
}
objzx_SkillEN.zxOperationTypeId = strzxOperationTypeId; //操作类型ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objzx_SkillEN.dicFldComparisonOp.ContainsKey(conzx_Skill.zxOperationTypeId) == false)
{
objzx_SkillEN.dicFldComparisonOp.Add(conzx_Skill.zxOperationTypeId, strComparisonOp);
}
else
{
objzx_SkillEN.dicFldComparisonOp[conzx_Skill.zxOperationTypeId] = strComparisonOp;
}
}
return objzx_SkillEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objzx_SkillEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clszx_SkillEN SetProcess(this clszx_SkillEN objzx_SkillEN, string strProcess, string strComparisonOp="")
	{
objzx_SkillEN.Process = strProcess; //实施过程
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objzx_SkillEN.dicFldComparisonOp.ContainsKey(conzx_Skill.Process) == false)
{
objzx_SkillEN.dicFldComparisonOp.Add(conzx_Skill.Process, strComparisonOp);
}
else
{
objzx_SkillEN.dicFldComparisonOp[conzx_Skill.Process] = strComparisonOp;
}
}
return objzx_SkillEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objzx_SkillEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clszx_SkillEN SetzxLevelId(this clszx_SkillEN objzx_SkillEN, string strzxLevelId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strzxLevelId, 2, conzx_Skill.zxLevelId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strzxLevelId, 2, conzx_Skill.zxLevelId);
}
objzx_SkillEN.zxLevelId = strzxLevelId; //级别Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objzx_SkillEN.dicFldComparisonOp.ContainsKey(conzx_Skill.zxLevelId) == false)
{
objzx_SkillEN.dicFldComparisonOp.Add(conzx_Skill.zxLevelId, strComparisonOp);
}
else
{
objzx_SkillEN.dicFldComparisonOp[conzx_Skill.zxLevelId] = strComparisonOp;
}
}
return objzx_SkillEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objzx_SkillEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clszx_SkillEN SetIsSubmit(this clszx_SkillEN objzx_SkillEN, bool bolIsSubmit, string strComparisonOp="")
	{
objzx_SkillEN.IsSubmit = bolIsSubmit; //是否提交
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objzx_SkillEN.dicFldComparisonOp.ContainsKey(conzx_Skill.IsSubmit) == false)
{
objzx_SkillEN.dicFldComparisonOp.Add(conzx_Skill.IsSubmit, strComparisonOp);
}
else
{
objzx_SkillEN.dicFldComparisonOp[conzx_Skill.IsSubmit] = strComparisonOp;
}
}
return objzx_SkillEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objzx_SkillEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clszx_SkillEN SetTextId(this clszx_SkillEN objzx_SkillEN, string strTextId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTextId, 8, conzx_Skill.TextId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strTextId, 8, conzx_Skill.TextId);
}
objzx_SkillEN.TextId = strTextId; //课件Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objzx_SkillEN.dicFldComparisonOp.ContainsKey(conzx_Skill.TextId) == false)
{
objzx_SkillEN.dicFldComparisonOp.Add(conzx_Skill.TextId, strComparisonOp);
}
else
{
objzx_SkillEN.dicFldComparisonOp[conzx_Skill.TextId] = strComparisonOp;
}
}
return objzx_SkillEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objzx_SkillEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clszx_SkillEN SetVoteCount(this clszx_SkillEN objzx_SkillEN, int? intVoteCount, string strComparisonOp="")
	{
objzx_SkillEN.VoteCount = intVoteCount; //点赞计数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objzx_SkillEN.dicFldComparisonOp.ContainsKey(conzx_Skill.VoteCount) == false)
{
objzx_SkillEN.dicFldComparisonOp.Add(conzx_Skill.VoteCount, strComparisonOp);
}
else
{
objzx_SkillEN.dicFldComparisonOp[conzx_Skill.VoteCount] = strComparisonOp;
}
}
return objzx_SkillEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objzx_SkillEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clszx_SkillEN SetAppraiseCount(this clszx_SkillEN objzx_SkillEN, int? intAppraiseCount, string strComparisonOp="")
	{
objzx_SkillEN.AppraiseCount = intAppraiseCount; //评论数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objzx_SkillEN.dicFldComparisonOp.ContainsKey(conzx_Skill.AppraiseCount) == false)
{
objzx_SkillEN.dicFldComparisonOp.Add(conzx_Skill.AppraiseCount, strComparisonOp);
}
else
{
objzx_SkillEN.dicFldComparisonOp[conzx_Skill.AppraiseCount] = strComparisonOp;
}
}
return objzx_SkillEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objzx_SkillEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clszx_SkillEN SetScore(this clszx_SkillEN objzx_SkillEN, float? fltScore, string strComparisonOp="")
	{
objzx_SkillEN.Score = fltScore; //评分
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objzx_SkillEN.dicFldComparisonOp.ContainsKey(conzx_Skill.Score) == false)
{
objzx_SkillEN.dicFldComparisonOp.Add(conzx_Skill.Score, strComparisonOp);
}
else
{
objzx_SkillEN.dicFldComparisonOp[conzx_Skill.Score] = strComparisonOp;
}
}
return objzx_SkillEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objzx_SkillEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clszx_SkillEN SetStuScore(this clszx_SkillEN objzx_SkillEN, float? fltStuScore, string strComparisonOp="")
	{
objzx_SkillEN.StuScore = fltStuScore; //学生平均分
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objzx_SkillEN.dicFldComparisonOp.ContainsKey(conzx_Skill.StuScore) == false)
{
objzx_SkillEN.dicFldComparisonOp.Add(conzx_Skill.StuScore, strComparisonOp);
}
else
{
objzx_SkillEN.dicFldComparisonOp[conzx_Skill.StuScore] = strComparisonOp;
}
}
return objzx_SkillEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objzx_SkillEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clszx_SkillEN SetTeaScore(this clszx_SkillEN objzx_SkillEN, float? fltTeaScore, string strComparisonOp="")
	{
objzx_SkillEN.TeaScore = fltTeaScore; //教师评分
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objzx_SkillEN.dicFldComparisonOp.ContainsKey(conzx_Skill.TeaScore) == false)
{
objzx_SkillEN.dicFldComparisonOp.Add(conzx_Skill.TeaScore, strComparisonOp);
}
else
{
objzx_SkillEN.dicFldComparisonOp[conzx_Skill.TeaScore] = strComparisonOp;
}
}
return objzx_SkillEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objzx_SkillEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clszx_SkillEN SetIdCurrEduCls(this clszx_SkillEN objzx_SkillEN, string strIdCurrEduCls, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdCurrEduCls, 8, conzx_Skill.IdCurrEduCls);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdCurrEduCls, 8, conzx_Skill.IdCurrEduCls);
}
objzx_SkillEN.IdCurrEduCls = strIdCurrEduCls; //教学班流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objzx_SkillEN.dicFldComparisonOp.ContainsKey(conzx_Skill.IdCurrEduCls) == false)
{
objzx_SkillEN.dicFldComparisonOp.Add(conzx_Skill.IdCurrEduCls, strComparisonOp);
}
else
{
objzx_SkillEN.dicFldComparisonOp[conzx_Skill.IdCurrEduCls] = strComparisonOp;
}
}
return objzx_SkillEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objzx_SkillEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clszx_SkillEN SetPdfContent(this clszx_SkillEN objzx_SkillEN, string strPdfContent, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPdfContent, 2000, conzx_Skill.PdfContent);
}
objzx_SkillEN.PdfContent = strPdfContent; //Pdf内容
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objzx_SkillEN.dicFldComparisonOp.ContainsKey(conzx_Skill.PdfContent) == false)
{
objzx_SkillEN.dicFldComparisonOp.Add(conzx_Skill.PdfContent, strComparisonOp);
}
else
{
objzx_SkillEN.dicFldComparisonOp[conzx_Skill.PdfContent] = strComparisonOp;
}
}
return objzx_SkillEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objzx_SkillEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clszx_SkillEN SetPdfPageNum(this clszx_SkillEN objzx_SkillEN, int? intPdfPageNum, string strComparisonOp="")
	{
objzx_SkillEN.PdfPageNum = intPdfPageNum; //Pdf页码
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objzx_SkillEN.dicFldComparisonOp.ContainsKey(conzx_Skill.PdfPageNum) == false)
{
objzx_SkillEN.dicFldComparisonOp.Add(conzx_Skill.PdfPageNum, strComparisonOp);
}
else
{
objzx_SkillEN.dicFldComparisonOp[conzx_Skill.PdfPageNum] = strComparisonOp;
}
}
return objzx_SkillEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objzx_SkillEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clszx_SkillEN SetCitationCount(this clszx_SkillEN objzx_SkillEN, int? intCitationCount, string strComparisonOp="")
	{
objzx_SkillEN.CitationCount = intCitationCount; //引用统计
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objzx_SkillEN.dicFldComparisonOp.ContainsKey(conzx_Skill.CitationCount) == false)
{
objzx_SkillEN.dicFldComparisonOp.Add(conzx_Skill.CitationCount, strComparisonOp);
}
else
{
objzx_SkillEN.dicFldComparisonOp[conzx_Skill.CitationCount] = strComparisonOp;
}
}
return objzx_SkillEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objzx_SkillEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clszx_SkillEN SetVersionCount(this clszx_SkillEN objzx_SkillEN, int? intVersionCount, string strComparisonOp="")
	{
objzx_SkillEN.VersionCount = intVersionCount; //版本统计
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objzx_SkillEN.dicFldComparisonOp.ContainsKey(conzx_Skill.VersionCount) == false)
{
objzx_SkillEN.dicFldComparisonOp.Add(conzx_Skill.VersionCount, strComparisonOp);
}
else
{
objzx_SkillEN.dicFldComparisonOp[conzx_Skill.VersionCount] = strComparisonOp;
}
}
return objzx_SkillEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objzx_SkillEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clszx_SkillEN SetzxShareId(this clszx_SkillEN objzx_SkillEN, string strzxShareId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strzxShareId, 2, conzx_Skill.zxShareId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strzxShareId, 2, conzx_Skill.zxShareId);
}
objzx_SkillEN.zxShareId = strzxShareId; //分享Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objzx_SkillEN.dicFldComparisonOp.ContainsKey(conzx_Skill.zxShareId) == false)
{
objzx_SkillEN.dicFldComparisonOp.Add(conzx_Skill.zxShareId, strComparisonOp);
}
else
{
objzx_SkillEN.dicFldComparisonOp[conzx_Skill.zxShareId] = strComparisonOp;
}
}
return objzx_SkillEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objzx_SkillEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clszx_SkillEN SetUpdUser(this clszx_SkillEN objzx_SkillEN, string strUpdUser, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdUser, 20, conzx_Skill.UpdUser);
}
objzx_SkillEN.UpdUser = strUpdUser; //修改人
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objzx_SkillEN.dicFldComparisonOp.ContainsKey(conzx_Skill.UpdUser) == false)
{
objzx_SkillEN.dicFldComparisonOp.Add(conzx_Skill.UpdUser, strComparisonOp);
}
else
{
objzx_SkillEN.dicFldComparisonOp[conzx_Skill.UpdUser] = strComparisonOp;
}
}
return objzx_SkillEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objzx_SkillEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clszx_SkillEN SetCreateDate(this clszx_SkillEN objzx_SkillEN, string strCreateDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCreateDate, 20, conzx_Skill.CreateDate);
}
objzx_SkillEN.CreateDate = strCreateDate; //建立日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objzx_SkillEN.dicFldComparisonOp.ContainsKey(conzx_Skill.CreateDate) == false)
{
objzx_SkillEN.dicFldComparisonOp.Add(conzx_Skill.CreateDate, strComparisonOp);
}
else
{
objzx_SkillEN.dicFldComparisonOp[conzx_Skill.CreateDate] = strComparisonOp;
}
}
return objzx_SkillEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objzx_SkillEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clszx_SkillEN SetUpdDate(this clszx_SkillEN objzx_SkillEN, string strUpdDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdDate, 20, conzx_Skill.UpdDate);
}
objzx_SkillEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objzx_SkillEN.dicFldComparisonOp.ContainsKey(conzx_Skill.UpdDate) == false)
{
objzx_SkillEN.dicFldComparisonOp.Add(conzx_Skill.UpdDate, strComparisonOp);
}
else
{
objzx_SkillEN.dicFldComparisonOp[conzx_Skill.UpdDate] = strComparisonOp;
}
}
return objzx_SkillEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objzx_SkillEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clszx_SkillEN SetMemo(this clszx_SkillEN objzx_SkillEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, conzx_Skill.Memo);
}
objzx_SkillEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objzx_SkillEN.dicFldComparisonOp.ContainsKey(conzx_Skill.Memo) == false)
{
objzx_SkillEN.dicFldComparisonOp.Add(conzx_Skill.Memo, strComparisonOp);
}
else
{
objzx_SkillEN.dicFldComparisonOp[conzx_Skill.Memo] = strComparisonOp;
}
}
return objzx_SkillEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objzx_SkillEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clszx_SkillEN SetPdfDivLet(this clszx_SkillEN objzx_SkillEN, string strPdfDivLet, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPdfDivLet, 50, conzx_Skill.PdfDivLet);
}
objzx_SkillEN.PdfDivLet = strPdfDivLet; //PdfDivLet
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objzx_SkillEN.dicFldComparisonOp.ContainsKey(conzx_Skill.PdfDivLet) == false)
{
objzx_SkillEN.dicFldComparisonOp.Add(conzx_Skill.PdfDivLet, strComparisonOp);
}
else
{
objzx_SkillEN.dicFldComparisonOp[conzx_Skill.PdfDivLet] = strComparisonOp;
}
}
return objzx_SkillEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objzx_SkillEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clszx_SkillEN SetPdfDivTop(this clszx_SkillEN objzx_SkillEN, string strPdfDivTop, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPdfDivTop, 50, conzx_Skill.PdfDivTop);
}
objzx_SkillEN.PdfDivTop = strPdfDivTop; //PdfDivTop
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objzx_SkillEN.dicFldComparisonOp.ContainsKey(conzx_Skill.PdfDivTop) == false)
{
objzx_SkillEN.dicFldComparisonOp.Add(conzx_Skill.PdfDivTop, strComparisonOp);
}
else
{
objzx_SkillEN.dicFldComparisonOp[conzx_Skill.PdfDivTop] = strComparisonOp;
}
}
return objzx_SkillEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objzx_SkillEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clszx_SkillEN SetPdfPageNumIn(this clszx_SkillEN objzx_SkillEN, string strPdfPageNumIn, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPdfPageNumIn, 50, conzx_Skill.PdfPageNumIn);
}
objzx_SkillEN.PdfPageNumIn = strPdfPageNumIn; //PdfPageNumIn
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objzx_SkillEN.dicFldComparisonOp.ContainsKey(conzx_Skill.PdfPageNumIn) == false)
{
objzx_SkillEN.dicFldComparisonOp.Add(conzx_Skill.PdfPageNumIn, strComparisonOp);
}
else
{
objzx_SkillEN.dicFldComparisonOp[conzx_Skill.PdfPageNumIn] = strComparisonOp;
}
}
return objzx_SkillEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objzx_SkillEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clszx_SkillEN SetPdfPageTop(this clszx_SkillEN objzx_SkillEN, int? intPdfPageTop, string strComparisonOp="")
	{
objzx_SkillEN.PdfPageTop = intPdfPageTop; //pdf页面顶部位置
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objzx_SkillEN.dicFldComparisonOp.ContainsKey(conzx_Skill.PdfPageTop) == false)
{
objzx_SkillEN.dicFldComparisonOp.Add(conzx_Skill.PdfPageTop, strComparisonOp);
}
else
{
objzx_SkillEN.dicFldComparisonOp[conzx_Skill.PdfPageTop] = strComparisonOp;
}
}
return objzx_SkillEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objzx_SkillEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clszx_SkillEN SetPdfZoom(this clszx_SkillEN objzx_SkillEN, string strPdfZoom, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPdfZoom, 50, conzx_Skill.PdfZoom);
}
objzx_SkillEN.PdfZoom = strPdfZoom; //PdfZoom
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objzx_SkillEN.dicFldComparisonOp.ContainsKey(conzx_Skill.PdfZoom) == false)
{
objzx_SkillEN.dicFldComparisonOp.Add(conzx_Skill.PdfZoom, strComparisonOp);
}
else
{
objzx_SkillEN.dicFldComparisonOp[conzx_Skill.PdfZoom] = strComparisonOp;
}
}
return objzx_SkillEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objzx_SkillEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clszx_SkillEN SetGroupTextId(this clszx_SkillEN objzx_SkillEN, string strGroupTextId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strGroupTextId, 8, conzx_Skill.GroupTextId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strGroupTextId, 8, conzx_Skill.GroupTextId);
}
objzx_SkillEN.GroupTextId = strGroupTextId; //小组Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objzx_SkillEN.dicFldComparisonOp.ContainsKey(conzx_Skill.GroupTextId) == false)
{
objzx_SkillEN.dicFldComparisonOp.Add(conzx_Skill.GroupTextId, strComparisonOp);
}
else
{
objzx_SkillEN.dicFldComparisonOp[conzx_Skill.GroupTextId] = strComparisonOp;
}
}
return objzx_SkillEN;
	}

 /// <summary>
 /// 修改记录存盘到数据表中
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_UpdateRecordEx)
 /// </summary>
 /// <param name = "objzx_SkillEN">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool UpdateRecordEx(this clszx_SkillEN objzx_SkillEN)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
try
{
//1、检查传进去的对象属性是否合法
objzx_SkillEN.CheckPropertyNew();
clszx_SkillEN objzx_SkillCond = new clszx_SkillEN();
string strCondition = objzx_SkillCond
.SetzxSkillId(objzx_SkillEN.zxSkillId, "<>")
.SetTextId(objzx_SkillEN.TextId, "=")
.GetCombineCondition();
objzx_SkillEN._IsCheckProperty = true;
bool bolIsExist = clszx_SkillBL.IsExistRecord(strCondition);
if (bolIsExist)
{
strMsg = "(TextId)不能重复!";
throw new Exception(strMsg);
}
//4、把数据实体层的数据存贮到数据库中
objzx_SkillEN.Update();
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
 /// <param name = "objzx_Skill">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool EditRecordEx(this clszx_SkillEN objzx_Skill)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
clszx_SkillEN objzx_SkillCond = new clszx_SkillEN();
string strCondition = objzx_SkillCond
.SetTextId(objzx_Skill.TextId, "=")
.GetCombineCondition();
objzx_Skill._IsCheckProperty = true;
bool bolIsExist = clszx_SkillBL.IsExistRecord(strCondition);
if (bolIsExist)
{
objzx_Skill.zxSkillId = clszx_SkillBL.GetFirstID_S(strCondition);
objzx_Skill.UpdateWithCondition(strCondition);
}
else
{
objzx_Skill.zxSkillId = clszx_SkillBL.GetMaxStrId_S();
objzx_Skill.AddNewRecord();
}
return true; 
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_Update)
 /// </summary>
 /// <param name = "objzx_SkillEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clszx_SkillEN objzx_SkillEN)
{
 if (string.IsNullOrEmpty(objzx_SkillEN.zxSkillId) == true)
 {
string strMsg = string.Format("(errid:Busi000095)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clszx_SkillBL.zx_SkillDA.UpdateBySql2(objzx_SkillEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clszx_SkillBL.ReFreshCache(objzx_SkillEN.IdCurrEduCls);

if (clszx_SkillBL.relatedActions != null)
{
clszx_SkillBL.relatedActions.UpdRelaTabDate(objzx_SkillEN.zxSkillId, "SetUpdDate");
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
 /// <param name = "objzx_SkillEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clszx_SkillEN objzx_SkillEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (string.IsNullOrEmpty(objzx_SkillEN.zxSkillId) == true)
 {
string strMsg = string.Format("(errid:Busi000087)修改记录时关键字不能为空!(带事务处理)(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clszx_SkillBL.zx_SkillDA.UpdateBySql2(objzx_SkillEN, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clszx_SkillBL.ReFreshCache(objzx_SkillEN.IdCurrEduCls);

if (clszx_SkillBL.relatedActions != null)
{
clszx_SkillBL.relatedActions.UpdRelaTabDate(objzx_SkillEN.zxSkillId, "SetUpdDate");
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
 /// <param name = "objzx_SkillEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clszx_SkillEN objzx_SkillEN, string strWhereCond)
{
try
{
bool bolResult = clszx_SkillBL.zx_SkillDA.UpdateBySqlWithCondition(objzx_SkillEN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clszx_SkillBL.ReFreshCache(objzx_SkillEN.IdCurrEduCls);

if (clszx_SkillBL.relatedActions != null)
{
clszx_SkillBL.relatedActions.UpdRelaTabDate(objzx_SkillEN.zxSkillId, "SetUpdDate");
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
 /// <param name = "objzx_SkillEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clszx_SkillEN objzx_SkillEN, string strWhereCond, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
bool bolResult = clszx_SkillBL.zx_SkillDA.UpdateBySqlWithConditionTransaction(objzx_SkillEN, strWhereCond, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clszx_SkillBL.ReFreshCache(objzx_SkillEN.IdCurrEduCls);

if (clszx_SkillBL.relatedActions != null)
{
clszx_SkillBL.relatedActions.UpdRelaTabDate(objzx_SkillEN.zxSkillId, "SetUpdDate");
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
 /// <param name = "strzxSkillId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int Delete(this clszx_SkillEN objzx_SkillEN)
{
try
{
int intRecNum = clszx_SkillBL.zx_SkillDA.DelRecord(objzx_SkillEN.zxSkillId);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clszx_SkillBL.ReFreshCache(objzx_SkillEN.IdCurrEduCls);

if (clszx_SkillBL.relatedActions != null)
{
clszx_SkillBL.relatedActions.UpdRelaTabDate(objzx_SkillEN.zxSkillId, "SetUpdDate");
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
 /// <param name = "objzx_SkillENS">源对象</param>
 /// <param name = "objzx_SkillENT">目标对象</param>
 public static void CopyTo(this clszx_SkillEN objzx_SkillENS, clszx_SkillEN objzx_SkillENT)
{
try
{
objzx_SkillENT.zxSkillId = objzx_SkillENS.zxSkillId; //技能Id
objzx_SkillENT.SkillName = objzx_SkillENS.SkillName; //技能名称
objzx_SkillENT.zxOperationTypeId = objzx_SkillENS.zxOperationTypeId; //操作类型ID
objzx_SkillENT.Process = objzx_SkillENS.Process; //实施过程
objzx_SkillENT.zxLevelId = objzx_SkillENS.zxLevelId; //级别Id
objzx_SkillENT.IsSubmit = objzx_SkillENS.IsSubmit; //是否提交
objzx_SkillENT.TextId = objzx_SkillENS.TextId; //课件Id
objzx_SkillENT.VoteCount = objzx_SkillENS.VoteCount; //点赞计数
objzx_SkillENT.AppraiseCount = objzx_SkillENS.AppraiseCount; //评论数
objzx_SkillENT.Score = objzx_SkillENS.Score; //评分
objzx_SkillENT.StuScore = objzx_SkillENS.StuScore; //学生平均分
objzx_SkillENT.TeaScore = objzx_SkillENS.TeaScore; //教师评分
objzx_SkillENT.IdCurrEduCls = objzx_SkillENS.IdCurrEduCls; //教学班流水号
objzx_SkillENT.PdfContent = objzx_SkillENS.PdfContent; //Pdf内容
objzx_SkillENT.PdfPageNum = objzx_SkillENS.PdfPageNum; //Pdf页码
objzx_SkillENT.CitationCount = objzx_SkillENS.CitationCount; //引用统计
objzx_SkillENT.VersionCount = objzx_SkillENS.VersionCount; //版本统计
objzx_SkillENT.zxShareId = objzx_SkillENS.zxShareId; //分享Id
objzx_SkillENT.UpdUser = objzx_SkillENS.UpdUser; //修改人
objzx_SkillENT.CreateDate = objzx_SkillENS.CreateDate; //建立日期
objzx_SkillENT.UpdDate = objzx_SkillENS.UpdDate; //修改日期
objzx_SkillENT.Memo = objzx_SkillENS.Memo; //备注
objzx_SkillENT.PdfDivLet = objzx_SkillENS.PdfDivLet; //PdfDivLet
objzx_SkillENT.PdfDivTop = objzx_SkillENS.PdfDivTop; //PdfDivTop
objzx_SkillENT.PdfPageNumIn = objzx_SkillENS.PdfPageNumIn; //PdfPageNumIn
objzx_SkillENT.PdfPageTop = objzx_SkillENS.PdfPageTop; //pdf页面顶部位置
objzx_SkillENT.PdfZoom = objzx_SkillENS.PdfZoom; //PdfZoom
objzx_SkillENT.GroupTextId = objzx_SkillENS.GroupTextId; //小组Id
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
 /// <param name = "objzx_SkillENS">源对象</param>
 /// <returns>目标对象=>clszx_SkillEN:objzx_SkillENT</returns>
 public static clszx_SkillEN CopyTo(this clszx_SkillEN objzx_SkillENS)
{
try
{
 clszx_SkillEN objzx_SkillENT = new clszx_SkillEN()
{
zxSkillId = objzx_SkillENS.zxSkillId, //技能Id
SkillName = objzx_SkillENS.SkillName, //技能名称
zxOperationTypeId = objzx_SkillENS.zxOperationTypeId, //操作类型ID
Process = objzx_SkillENS.Process, //实施过程
zxLevelId = objzx_SkillENS.zxLevelId, //级别Id
IsSubmit = objzx_SkillENS.IsSubmit, //是否提交
TextId = objzx_SkillENS.TextId, //课件Id
VoteCount = objzx_SkillENS.VoteCount, //点赞计数
AppraiseCount = objzx_SkillENS.AppraiseCount, //评论数
Score = objzx_SkillENS.Score, //评分
StuScore = objzx_SkillENS.StuScore, //学生平均分
TeaScore = objzx_SkillENS.TeaScore, //教师评分
IdCurrEduCls = objzx_SkillENS.IdCurrEduCls, //教学班流水号
PdfContent = objzx_SkillENS.PdfContent, //Pdf内容
PdfPageNum = objzx_SkillENS.PdfPageNum, //Pdf页码
CitationCount = objzx_SkillENS.CitationCount, //引用统计
VersionCount = objzx_SkillENS.VersionCount, //版本统计
zxShareId = objzx_SkillENS.zxShareId, //分享Id
UpdUser = objzx_SkillENS.UpdUser, //修改人
CreateDate = objzx_SkillENS.CreateDate, //建立日期
UpdDate = objzx_SkillENS.UpdDate, //修改日期
Memo = objzx_SkillENS.Memo, //备注
PdfDivLet = objzx_SkillENS.PdfDivLet, //PdfDivLet
PdfDivTop = objzx_SkillENS.PdfDivTop, //PdfDivTop
PdfPageNumIn = objzx_SkillENS.PdfPageNumIn, //PdfPageNumIn
PdfPageTop = objzx_SkillENS.PdfPageTop, //pdf页面顶部位置
PdfZoom = objzx_SkillENS.PdfZoom, //PdfZoom
GroupTextId = objzx_SkillENS.GroupTextId, //小组Id
};
 return objzx_SkillENT;
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
public static void CheckPropertyNew(this clszx_SkillEN objzx_SkillEN)
{
 clszx_SkillBL.zx_SkillDA.CheckPropertyNew(objzx_SkillEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(this clszx_SkillEN objzx_SkillEN)
{
 clszx_SkillBL.zx_SkillDA.CheckProperty4Condition(objzx_SkillEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clszx_SkillEN objzx_SkillCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objzx_SkillCond.IsUpdated(conzx_Skill.zxSkillId) == true)
{
string strComparisonOpzxSkillId = objzx_SkillCond.dicFldComparisonOp[conzx_Skill.zxSkillId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conzx_Skill.zxSkillId, objzx_SkillCond.zxSkillId, strComparisonOpzxSkillId);
}
if (objzx_SkillCond.IsUpdated(conzx_Skill.SkillName) == true)
{
string strComparisonOpSkillName = objzx_SkillCond.dicFldComparisonOp[conzx_Skill.SkillName];
strWhereCond += string.Format(" And {0} {2} '{1}'", conzx_Skill.SkillName, objzx_SkillCond.SkillName, strComparisonOpSkillName);
}
if (objzx_SkillCond.IsUpdated(conzx_Skill.zxOperationTypeId) == true)
{
string strComparisonOpzxOperationTypeId = objzx_SkillCond.dicFldComparisonOp[conzx_Skill.zxOperationTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conzx_Skill.zxOperationTypeId, objzx_SkillCond.zxOperationTypeId, strComparisonOpzxOperationTypeId);
}
//数据类型string(text)在函数:[AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj]中没有处理!
if (objzx_SkillCond.IsUpdated(conzx_Skill.zxLevelId) == true)
{
string strComparisonOpzxLevelId = objzx_SkillCond.dicFldComparisonOp[conzx_Skill.zxLevelId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conzx_Skill.zxLevelId, objzx_SkillCond.zxLevelId, strComparisonOpzxLevelId);
}
if (objzx_SkillCond.IsUpdated(conzx_Skill.IsSubmit) == true)
{
if (objzx_SkillCond.IsSubmit == true)
{
strWhereCond += string.Format(" And {0} = '1'", conzx_Skill.IsSubmit);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conzx_Skill.IsSubmit);
}
}
if (objzx_SkillCond.IsUpdated(conzx_Skill.TextId) == true)
{
string strComparisonOpTextId = objzx_SkillCond.dicFldComparisonOp[conzx_Skill.TextId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conzx_Skill.TextId, objzx_SkillCond.TextId, strComparisonOpTextId);
}
if (objzx_SkillCond.IsUpdated(conzx_Skill.VoteCount) == true)
{
string strComparisonOpVoteCount = objzx_SkillCond.dicFldComparisonOp[conzx_Skill.VoteCount];
strWhereCond += string.Format(" And {0} {2} {1}", conzx_Skill.VoteCount, objzx_SkillCond.VoteCount, strComparisonOpVoteCount);
}
if (objzx_SkillCond.IsUpdated(conzx_Skill.AppraiseCount) == true)
{
string strComparisonOpAppraiseCount = objzx_SkillCond.dicFldComparisonOp[conzx_Skill.AppraiseCount];
strWhereCond += string.Format(" And {0} {2} {1}", conzx_Skill.AppraiseCount, objzx_SkillCond.AppraiseCount, strComparisonOpAppraiseCount);
}
if (objzx_SkillCond.IsUpdated(conzx_Skill.Score) == true)
{
string strComparisonOpScore = objzx_SkillCond.dicFldComparisonOp[conzx_Skill.Score];
strWhereCond += string.Format(" And {0} {2} {1}", conzx_Skill.Score, objzx_SkillCond.Score, strComparisonOpScore);
}
if (objzx_SkillCond.IsUpdated(conzx_Skill.StuScore) == true)
{
string strComparisonOpStuScore = objzx_SkillCond.dicFldComparisonOp[conzx_Skill.StuScore];
strWhereCond += string.Format(" And {0} {2} {1}", conzx_Skill.StuScore, objzx_SkillCond.StuScore, strComparisonOpStuScore);
}
if (objzx_SkillCond.IsUpdated(conzx_Skill.TeaScore) == true)
{
string strComparisonOpTeaScore = objzx_SkillCond.dicFldComparisonOp[conzx_Skill.TeaScore];
strWhereCond += string.Format(" And {0} {2} {1}", conzx_Skill.TeaScore, objzx_SkillCond.TeaScore, strComparisonOpTeaScore);
}
if (objzx_SkillCond.IsUpdated(conzx_Skill.IdCurrEduCls) == true)
{
string strComparisonOpIdCurrEduCls = objzx_SkillCond.dicFldComparisonOp[conzx_Skill.IdCurrEduCls];
strWhereCond += string.Format(" And {0} {2} '{1}'", conzx_Skill.IdCurrEduCls, objzx_SkillCond.IdCurrEduCls, strComparisonOpIdCurrEduCls);
}
if (objzx_SkillCond.IsUpdated(conzx_Skill.PdfContent) == true)
{
string strComparisonOpPdfContent = objzx_SkillCond.dicFldComparisonOp[conzx_Skill.PdfContent];
strWhereCond += string.Format(" And {0} {2} '{1}'", conzx_Skill.PdfContent, objzx_SkillCond.PdfContent, strComparisonOpPdfContent);
}
if (objzx_SkillCond.IsUpdated(conzx_Skill.PdfPageNum) == true)
{
string strComparisonOpPdfPageNum = objzx_SkillCond.dicFldComparisonOp[conzx_Skill.PdfPageNum];
strWhereCond += string.Format(" And {0} {2} {1}", conzx_Skill.PdfPageNum, objzx_SkillCond.PdfPageNum, strComparisonOpPdfPageNum);
}
if (objzx_SkillCond.IsUpdated(conzx_Skill.CitationCount) == true)
{
string strComparisonOpCitationCount = objzx_SkillCond.dicFldComparisonOp[conzx_Skill.CitationCount];
strWhereCond += string.Format(" And {0} {2} {1}", conzx_Skill.CitationCount, objzx_SkillCond.CitationCount, strComparisonOpCitationCount);
}
if (objzx_SkillCond.IsUpdated(conzx_Skill.VersionCount) == true)
{
string strComparisonOpVersionCount = objzx_SkillCond.dicFldComparisonOp[conzx_Skill.VersionCount];
strWhereCond += string.Format(" And {0} {2} {1}", conzx_Skill.VersionCount, objzx_SkillCond.VersionCount, strComparisonOpVersionCount);
}
if (objzx_SkillCond.IsUpdated(conzx_Skill.zxShareId) == true)
{
string strComparisonOpzxShareId = objzx_SkillCond.dicFldComparisonOp[conzx_Skill.zxShareId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conzx_Skill.zxShareId, objzx_SkillCond.zxShareId, strComparisonOpzxShareId);
}
if (objzx_SkillCond.IsUpdated(conzx_Skill.UpdUser) == true)
{
string strComparisonOpUpdUser = objzx_SkillCond.dicFldComparisonOp[conzx_Skill.UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", conzx_Skill.UpdUser, objzx_SkillCond.UpdUser, strComparisonOpUpdUser);
}
if (objzx_SkillCond.IsUpdated(conzx_Skill.CreateDate) == true)
{
string strComparisonOpCreateDate = objzx_SkillCond.dicFldComparisonOp[conzx_Skill.CreateDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conzx_Skill.CreateDate, objzx_SkillCond.CreateDate, strComparisonOpCreateDate);
}
if (objzx_SkillCond.IsUpdated(conzx_Skill.UpdDate) == true)
{
string strComparisonOpUpdDate = objzx_SkillCond.dicFldComparisonOp[conzx_Skill.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conzx_Skill.UpdDate, objzx_SkillCond.UpdDate, strComparisonOpUpdDate);
}
if (objzx_SkillCond.IsUpdated(conzx_Skill.Memo) == true)
{
string strComparisonOpMemo = objzx_SkillCond.dicFldComparisonOp[conzx_Skill.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", conzx_Skill.Memo, objzx_SkillCond.Memo, strComparisonOpMemo);
}
if (objzx_SkillCond.IsUpdated(conzx_Skill.PdfDivLet) == true)
{
string strComparisonOpPdfDivLet = objzx_SkillCond.dicFldComparisonOp[conzx_Skill.PdfDivLet];
strWhereCond += string.Format(" And {0} {2} '{1}'", conzx_Skill.PdfDivLet, objzx_SkillCond.PdfDivLet, strComparisonOpPdfDivLet);
}
if (objzx_SkillCond.IsUpdated(conzx_Skill.PdfDivTop) == true)
{
string strComparisonOpPdfDivTop = objzx_SkillCond.dicFldComparisonOp[conzx_Skill.PdfDivTop];
strWhereCond += string.Format(" And {0} {2} '{1}'", conzx_Skill.PdfDivTop, objzx_SkillCond.PdfDivTop, strComparisonOpPdfDivTop);
}
if (objzx_SkillCond.IsUpdated(conzx_Skill.PdfPageNumIn) == true)
{
string strComparisonOpPdfPageNumIn = objzx_SkillCond.dicFldComparisonOp[conzx_Skill.PdfPageNumIn];
strWhereCond += string.Format(" And {0} {2} '{1}'", conzx_Skill.PdfPageNumIn, objzx_SkillCond.PdfPageNumIn, strComparisonOpPdfPageNumIn);
}
if (objzx_SkillCond.IsUpdated(conzx_Skill.PdfPageTop) == true)
{
string strComparisonOpPdfPageTop = objzx_SkillCond.dicFldComparisonOp[conzx_Skill.PdfPageTop];
strWhereCond += string.Format(" And {0} {2} {1}", conzx_Skill.PdfPageTop, objzx_SkillCond.PdfPageTop, strComparisonOpPdfPageTop);
}
if (objzx_SkillCond.IsUpdated(conzx_Skill.PdfZoom) == true)
{
string strComparisonOpPdfZoom = objzx_SkillCond.dicFldComparisonOp[conzx_Skill.PdfZoom];
strWhereCond += string.Format(" And {0} {2} '{1}'", conzx_Skill.PdfZoom, objzx_SkillCond.PdfZoom, strComparisonOpPdfZoom);
}
if (objzx_SkillCond.IsUpdated(conzx_Skill.GroupTextId) == true)
{
string strComparisonOpGroupTextId = objzx_SkillCond.dicFldComparisonOp[conzx_Skill.GroupTextId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conzx_Skill.GroupTextId, objzx_SkillCond.GroupTextId, strComparisonOpGroupTextId);
}
 return strWhereCond;
}

 /// <summary>
 /// 检查唯一性(Uniqueness)--zx_Skill(中学技能表), 如果不唯一,即存在相同的记录,就返回False
 /// 唯一性条件:TextId
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckConstraint)
 /// </summary>
 /// <param name = "objzx_SkillEN">要求唯一的对象</param>
 /// <returns></returns>
public static bool CheckUniqueness(this clszx_SkillEN objzx_SkillEN)
{
//检测记录是否存在
bool bolIsUniqueness;
StringBuilder sbCondition = new StringBuilder();
if (objzx_SkillEN == null) return true;
if (objzx_SkillEN.zxSkillId == null || objzx_SkillEN.zxSkillId == "")
{
sbCondition.AppendFormat("1 = 1");
 if (objzx_SkillEN.TextId == null)
{
 sbCondition.AppendFormat(" and TextId is null", objzx_SkillEN.TextId);
}
else
{
 sbCondition.AppendFormat(" and TextId = '{0}'", objzx_SkillEN.TextId);
}
if (clszx_SkillBL.IsExistRecord(sbCondition.ToString())  ==  true)
{
 bolIsUniqueness = false;
}
else
{
 bolIsUniqueness = true;
}
}
 else {
sbCondition.AppendFormat("zxSkillId !=  '{0}'", objzx_SkillEN.zxSkillId);
 sbCondition.AppendFormat(" and TextId = '{0}'", objzx_SkillEN.TextId);
if (clszx_SkillBL.IsExistRecord(sbCondition.ToString())  ==  true)
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
 /// 获取唯一性条件串--zx_Skill(中学技能表), 即由对象中唯一性条件字段关键字与值组成的条件串
 /// 唯一性条件:TextId
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetConditionString4Constraint)
 /// </summary>
 /// <param name = "objzx_SkillEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(this clszx_SkillEN objzx_SkillEN)
{
//检测记录是否存在
StringBuilder sbCondition = new StringBuilder();
if (objzx_SkillEN == null) return "";
if (objzx_SkillEN.zxSkillId == null || objzx_SkillEN.zxSkillId == "")
{
sbCondition.AppendFormat("1 = 1");
 if (objzx_SkillEN.TextId == null)
{
 sbCondition.AppendFormat(" and TextId is null", objzx_SkillEN.TextId);
}
else
{
 sbCondition.AppendFormat(" and TextId = '{0}'", objzx_SkillEN.TextId);
}
return sbCondition.ToString();
}
 else {
sbCondition.AppendFormat("zxSkillId !=  '{0}'", objzx_SkillEN.zxSkillId);
 sbCondition.AppendFormat(" and TextId = '{0}'", objzx_SkillEN.TextId);
 return sbCondition.ToString();
}
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_zx_Skill
{
public virtual bool UpdRelaTabDate(string strzxSkillId, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// 中学技能表(zx_Skill)
 /// 数据源类型:表
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clszx_SkillBL
{
public static RelatedActions_zx_Skill relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clszx_SkillDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clszx_SkillDA zx_SkillDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clszx_SkillDA();
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
 public clszx_SkillBL()
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
if (string.IsNullOrEmpty(clszx_SkillEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clszx_SkillEN._ConnectString);
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
public static DataTable GetDataTable_zx_Skill(string strWhereCond)
{
DataTable objDT;
try
{
objDT = zx_SkillDA.GetDataTable_zx_Skill(strWhereCond);
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
objDT = zx_SkillDA.GetDataTable(strWhereCond);
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
objDT = zx_SkillDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = zx_SkillDA.GetDataTable(strWhereCond, strTabName);
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
objDT = zx_SkillDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = zx_SkillDA.GetDataTable_Top(objTopPara);
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
objDT = zx_SkillDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = zx_SkillDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = zx_SkillDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
 /// <param name = "arrZxSkillIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static List<clszx_SkillEN> GetObjLstByZxSkillIdLst(List<string> arrZxSkillIdLst)
{
List<clszx_SkillEN> arrObjLst = new List<clszx_SkillEN>(); 
System.Data.DataTable objDT; 
 string strSqlConditionStr = clsArray.GetSqlInStrByArray(arrZxSkillIdLst, true);
 string strWhereCond = string.Format("zxSkillId in ({0})", strSqlConditionStr);
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clszx_SkillEN objzx_SkillEN = new clszx_SkillEN();
try
{
objzx_SkillEN.zxSkillId = objRow[conzx_Skill.zxSkillId].ToString().Trim(); //技能Id
objzx_SkillEN.SkillName = objRow[conzx_Skill.SkillName] == DBNull.Value ? null : objRow[conzx_Skill.SkillName].ToString().Trim(); //技能名称
objzx_SkillEN.zxOperationTypeId = objRow[conzx_Skill.zxOperationTypeId] == DBNull.Value ? null : objRow[conzx_Skill.zxOperationTypeId].ToString().Trim(); //操作类型ID
objzx_SkillEN.Process = objRow[conzx_Skill.Process] == DBNull.Value ? null : objRow[conzx_Skill.Process].ToString().Trim(); //实施过程
objzx_SkillEN.zxLevelId = objRow[conzx_Skill.zxLevelId] == DBNull.Value ? null : objRow[conzx_Skill.zxLevelId].ToString().Trim(); //级别Id
objzx_SkillEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[conzx_Skill.IsSubmit].ToString().Trim()); //是否提交
objzx_SkillEN.TextId = objRow[conzx_Skill.TextId] == DBNull.Value ? null : objRow[conzx_Skill.TextId].ToString().Trim(); //课件Id
objzx_SkillEN.VoteCount = objRow[conzx_Skill.VoteCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_Skill.VoteCount].ToString().Trim()); //点赞计数
objzx_SkillEN.AppraiseCount = objRow[conzx_Skill.AppraiseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_Skill.AppraiseCount].ToString().Trim()); //评论数
objzx_SkillEN.Score = objRow[conzx_Skill.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conzx_Skill.Score].ToString().Trim()); //评分
objzx_SkillEN.StuScore = objRow[conzx_Skill.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conzx_Skill.StuScore].ToString().Trim()); //学生平均分
objzx_SkillEN.TeaScore = objRow[conzx_Skill.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conzx_Skill.TeaScore].ToString().Trim()); //教师评分
objzx_SkillEN.IdCurrEduCls = objRow[conzx_Skill.IdCurrEduCls] == DBNull.Value ? null : objRow[conzx_Skill.IdCurrEduCls].ToString().Trim(); //教学班流水号
objzx_SkillEN.PdfContent = objRow[conzx_Skill.PdfContent] == DBNull.Value ? null : objRow[conzx_Skill.PdfContent].ToString().Trim(); //Pdf内容
objzx_SkillEN.PdfPageNum = objRow[conzx_Skill.PdfPageNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_Skill.PdfPageNum].ToString().Trim()); //Pdf页码
objzx_SkillEN.CitationCount = objRow[conzx_Skill.CitationCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_Skill.CitationCount].ToString().Trim()); //引用统计
objzx_SkillEN.VersionCount = objRow[conzx_Skill.VersionCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_Skill.VersionCount].ToString().Trim()); //版本统计
objzx_SkillEN.zxShareId = objRow[conzx_Skill.zxShareId] == DBNull.Value ? null : objRow[conzx_Skill.zxShareId].ToString().Trim(); //分享Id
objzx_SkillEN.UpdUser = objRow[conzx_Skill.UpdUser] == DBNull.Value ? null : objRow[conzx_Skill.UpdUser].ToString().Trim(); //修改人
objzx_SkillEN.CreateDate = objRow[conzx_Skill.CreateDate] == DBNull.Value ? null : objRow[conzx_Skill.CreateDate].ToString().Trim(); //建立日期
objzx_SkillEN.UpdDate = objRow[conzx_Skill.UpdDate] == DBNull.Value ? null : objRow[conzx_Skill.UpdDate].ToString().Trim(); //修改日期
objzx_SkillEN.Memo = objRow[conzx_Skill.Memo] == DBNull.Value ? null : objRow[conzx_Skill.Memo].ToString().Trim(); //备注
objzx_SkillEN.PdfDivLet = objRow[conzx_Skill.PdfDivLet] == DBNull.Value ? null : objRow[conzx_Skill.PdfDivLet].ToString().Trim(); //PdfDivLet
objzx_SkillEN.PdfDivTop = objRow[conzx_Skill.PdfDivTop] == DBNull.Value ? null : objRow[conzx_Skill.PdfDivTop].ToString().Trim(); //PdfDivTop
objzx_SkillEN.PdfPageNumIn = objRow[conzx_Skill.PdfPageNumIn] == DBNull.Value ? null : objRow[conzx_Skill.PdfPageNumIn].ToString().Trim(); //PdfPageNumIn
objzx_SkillEN.PdfPageTop = objRow[conzx_Skill.PdfPageTop] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_Skill.PdfPageTop].ToString().Trim()); //pdf页面顶部位置
objzx_SkillEN.PdfZoom = objRow[conzx_Skill.PdfZoom] == DBNull.Value ? null : objRow[conzx_Skill.PdfZoom].ToString().Trim(); //PdfZoom
objzx_SkillEN.GroupTextId = objRow[conzx_Skill.GroupTextId] == DBNull.Value ? null : objRow[conzx_Skill.GroupTextId].ToString().Trim(); //小组Id
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objzx_SkillEN.zxSkillId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objzx_SkillEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrZxSkillIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clszx_SkillEN> GetObjLstByZxSkillIdLstCache(List<string> arrZxSkillIdLst, string strIdCurrEduCls)
{
string strKey = string.Format("{0}_{1}", clszx_SkillEN._CurrTabName, strIdCurrEduCls);
List<clszx_SkillEN> arrzx_SkillObjLstCache = GetObjLstCache(strIdCurrEduCls);
IEnumerable <clszx_SkillEN> arrzx_SkillObjLst_Sel =
arrzx_SkillObjLstCache
.Where(x => arrZxSkillIdLst.Contains(x.zxSkillId));
return arrzx_SkillObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clszx_SkillEN> GetObjLst(string strWhereCond)
{
List<clszx_SkillEN> arrObjLst = new List<clszx_SkillEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clszx_SkillEN objzx_SkillEN = new clszx_SkillEN();
try
{
objzx_SkillEN.zxSkillId = objRow[conzx_Skill.zxSkillId].ToString().Trim(); //技能Id
objzx_SkillEN.SkillName = objRow[conzx_Skill.SkillName] == DBNull.Value ? null : objRow[conzx_Skill.SkillName].ToString().Trim(); //技能名称
objzx_SkillEN.zxOperationTypeId = objRow[conzx_Skill.zxOperationTypeId] == DBNull.Value ? null : objRow[conzx_Skill.zxOperationTypeId].ToString().Trim(); //操作类型ID
objzx_SkillEN.Process = objRow[conzx_Skill.Process] == DBNull.Value ? null : objRow[conzx_Skill.Process].ToString().Trim(); //实施过程
objzx_SkillEN.zxLevelId = objRow[conzx_Skill.zxLevelId] == DBNull.Value ? null : objRow[conzx_Skill.zxLevelId].ToString().Trim(); //级别Id
objzx_SkillEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[conzx_Skill.IsSubmit].ToString().Trim()); //是否提交
objzx_SkillEN.TextId = objRow[conzx_Skill.TextId] == DBNull.Value ? null : objRow[conzx_Skill.TextId].ToString().Trim(); //课件Id
objzx_SkillEN.VoteCount = objRow[conzx_Skill.VoteCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_Skill.VoteCount].ToString().Trim()); //点赞计数
objzx_SkillEN.AppraiseCount = objRow[conzx_Skill.AppraiseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_Skill.AppraiseCount].ToString().Trim()); //评论数
objzx_SkillEN.Score = objRow[conzx_Skill.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conzx_Skill.Score].ToString().Trim()); //评分
objzx_SkillEN.StuScore = objRow[conzx_Skill.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conzx_Skill.StuScore].ToString().Trim()); //学生平均分
objzx_SkillEN.TeaScore = objRow[conzx_Skill.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conzx_Skill.TeaScore].ToString().Trim()); //教师评分
objzx_SkillEN.IdCurrEduCls = objRow[conzx_Skill.IdCurrEduCls] == DBNull.Value ? null : objRow[conzx_Skill.IdCurrEduCls].ToString().Trim(); //教学班流水号
objzx_SkillEN.PdfContent = objRow[conzx_Skill.PdfContent] == DBNull.Value ? null : objRow[conzx_Skill.PdfContent].ToString().Trim(); //Pdf内容
objzx_SkillEN.PdfPageNum = objRow[conzx_Skill.PdfPageNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_Skill.PdfPageNum].ToString().Trim()); //Pdf页码
objzx_SkillEN.CitationCount = objRow[conzx_Skill.CitationCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_Skill.CitationCount].ToString().Trim()); //引用统计
objzx_SkillEN.VersionCount = objRow[conzx_Skill.VersionCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_Skill.VersionCount].ToString().Trim()); //版本统计
objzx_SkillEN.zxShareId = objRow[conzx_Skill.zxShareId] == DBNull.Value ? null : objRow[conzx_Skill.zxShareId].ToString().Trim(); //分享Id
objzx_SkillEN.UpdUser = objRow[conzx_Skill.UpdUser] == DBNull.Value ? null : objRow[conzx_Skill.UpdUser].ToString().Trim(); //修改人
objzx_SkillEN.CreateDate = objRow[conzx_Skill.CreateDate] == DBNull.Value ? null : objRow[conzx_Skill.CreateDate].ToString().Trim(); //建立日期
objzx_SkillEN.UpdDate = objRow[conzx_Skill.UpdDate] == DBNull.Value ? null : objRow[conzx_Skill.UpdDate].ToString().Trim(); //修改日期
objzx_SkillEN.Memo = objRow[conzx_Skill.Memo] == DBNull.Value ? null : objRow[conzx_Skill.Memo].ToString().Trim(); //备注
objzx_SkillEN.PdfDivLet = objRow[conzx_Skill.PdfDivLet] == DBNull.Value ? null : objRow[conzx_Skill.PdfDivLet].ToString().Trim(); //PdfDivLet
objzx_SkillEN.PdfDivTop = objRow[conzx_Skill.PdfDivTop] == DBNull.Value ? null : objRow[conzx_Skill.PdfDivTop].ToString().Trim(); //PdfDivTop
objzx_SkillEN.PdfPageNumIn = objRow[conzx_Skill.PdfPageNumIn] == DBNull.Value ? null : objRow[conzx_Skill.PdfPageNumIn].ToString().Trim(); //PdfPageNumIn
objzx_SkillEN.PdfPageTop = objRow[conzx_Skill.PdfPageTop] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_Skill.PdfPageTop].ToString().Trim()); //pdf页面顶部位置
objzx_SkillEN.PdfZoom = objRow[conzx_Skill.PdfZoom] == DBNull.Value ? null : objRow[conzx_Skill.PdfZoom].ToString().Trim(); //PdfZoom
objzx_SkillEN.GroupTextId = objRow[conzx_Skill.GroupTextId] == DBNull.Value ? null : objRow[conzx_Skill.GroupTextId].ToString().Trim(); //小组Id
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objzx_SkillEN.zxSkillId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objzx_SkillEN);
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
public static List<clszx_SkillEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clszx_SkillEN> arrObjLst = new List<clszx_SkillEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clszx_SkillEN objzx_SkillEN = new clszx_SkillEN();
try
{
objzx_SkillEN.zxSkillId = objRow[conzx_Skill.zxSkillId].ToString().Trim(); //技能Id
objzx_SkillEN.SkillName = objRow[conzx_Skill.SkillName] == DBNull.Value ? null : objRow[conzx_Skill.SkillName].ToString().Trim(); //技能名称
objzx_SkillEN.zxOperationTypeId = objRow[conzx_Skill.zxOperationTypeId] == DBNull.Value ? null : objRow[conzx_Skill.zxOperationTypeId].ToString().Trim(); //操作类型ID
objzx_SkillEN.Process = objRow[conzx_Skill.Process] == DBNull.Value ? null : objRow[conzx_Skill.Process].ToString().Trim(); //实施过程
objzx_SkillEN.zxLevelId = objRow[conzx_Skill.zxLevelId] == DBNull.Value ? null : objRow[conzx_Skill.zxLevelId].ToString().Trim(); //级别Id
objzx_SkillEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[conzx_Skill.IsSubmit].ToString().Trim()); //是否提交
objzx_SkillEN.TextId = objRow[conzx_Skill.TextId] == DBNull.Value ? null : objRow[conzx_Skill.TextId].ToString().Trim(); //课件Id
objzx_SkillEN.VoteCount = objRow[conzx_Skill.VoteCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_Skill.VoteCount].ToString().Trim()); //点赞计数
objzx_SkillEN.AppraiseCount = objRow[conzx_Skill.AppraiseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_Skill.AppraiseCount].ToString().Trim()); //评论数
objzx_SkillEN.Score = objRow[conzx_Skill.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conzx_Skill.Score].ToString().Trim()); //评分
objzx_SkillEN.StuScore = objRow[conzx_Skill.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conzx_Skill.StuScore].ToString().Trim()); //学生平均分
objzx_SkillEN.TeaScore = objRow[conzx_Skill.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conzx_Skill.TeaScore].ToString().Trim()); //教师评分
objzx_SkillEN.IdCurrEduCls = objRow[conzx_Skill.IdCurrEduCls] == DBNull.Value ? null : objRow[conzx_Skill.IdCurrEduCls].ToString().Trim(); //教学班流水号
objzx_SkillEN.PdfContent = objRow[conzx_Skill.PdfContent] == DBNull.Value ? null : objRow[conzx_Skill.PdfContent].ToString().Trim(); //Pdf内容
objzx_SkillEN.PdfPageNum = objRow[conzx_Skill.PdfPageNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_Skill.PdfPageNum].ToString().Trim()); //Pdf页码
objzx_SkillEN.CitationCount = objRow[conzx_Skill.CitationCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_Skill.CitationCount].ToString().Trim()); //引用统计
objzx_SkillEN.VersionCount = objRow[conzx_Skill.VersionCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_Skill.VersionCount].ToString().Trim()); //版本统计
objzx_SkillEN.zxShareId = objRow[conzx_Skill.zxShareId] == DBNull.Value ? null : objRow[conzx_Skill.zxShareId].ToString().Trim(); //分享Id
objzx_SkillEN.UpdUser = objRow[conzx_Skill.UpdUser] == DBNull.Value ? null : objRow[conzx_Skill.UpdUser].ToString().Trim(); //修改人
objzx_SkillEN.CreateDate = objRow[conzx_Skill.CreateDate] == DBNull.Value ? null : objRow[conzx_Skill.CreateDate].ToString().Trim(); //建立日期
objzx_SkillEN.UpdDate = objRow[conzx_Skill.UpdDate] == DBNull.Value ? null : objRow[conzx_Skill.UpdDate].ToString().Trim(); //修改日期
objzx_SkillEN.Memo = objRow[conzx_Skill.Memo] == DBNull.Value ? null : objRow[conzx_Skill.Memo].ToString().Trim(); //备注
objzx_SkillEN.PdfDivLet = objRow[conzx_Skill.PdfDivLet] == DBNull.Value ? null : objRow[conzx_Skill.PdfDivLet].ToString().Trim(); //PdfDivLet
objzx_SkillEN.PdfDivTop = objRow[conzx_Skill.PdfDivTop] == DBNull.Value ? null : objRow[conzx_Skill.PdfDivTop].ToString().Trim(); //PdfDivTop
objzx_SkillEN.PdfPageNumIn = objRow[conzx_Skill.PdfPageNumIn] == DBNull.Value ? null : objRow[conzx_Skill.PdfPageNumIn].ToString().Trim(); //PdfPageNumIn
objzx_SkillEN.PdfPageTop = objRow[conzx_Skill.PdfPageTop] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_Skill.PdfPageTop].ToString().Trim()); //pdf页面顶部位置
objzx_SkillEN.PdfZoom = objRow[conzx_Skill.PdfZoom] == DBNull.Value ? null : objRow[conzx_Skill.PdfZoom].ToString().Trim(); //PdfZoom
objzx_SkillEN.GroupTextId = objRow[conzx_Skill.GroupTextId] == DBNull.Value ? null : objRow[conzx_Skill.GroupTextId].ToString().Trim(); //小组Id
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objzx_SkillEN.zxSkillId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objzx_SkillEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objzx_SkillCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clszx_SkillEN> GetSubObjLstCache(clszx_SkillEN objzx_SkillCond)
{
 string strIdCurrEduCls = objzx_SkillCond.IdCurrEduCls;
 if (string.IsNullOrEmpty(strIdCurrEduCls) == true)
{
string strMsg = string.Format("(errid:Busi000172)在表中,缓存分类字段值不能为空!(clszx_SkillBL:GetSubObjLstCache)");
throw new Exception(strMsg);
}
List<clszx_SkillEN> arrObjLstCache = GetObjLstCache(strIdCurrEduCls);
IEnumerable <clszx_SkillEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conzx_Skill.AttributeName)
{
if (objzx_SkillCond.IsUpdated(strFldName) == false) continue;
if (objzx_SkillCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objzx_SkillCond[strFldName].ToString());
}
else
{
if (objzx_SkillCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objzx_SkillCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objzx_SkillCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objzx_SkillCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objzx_SkillCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objzx_SkillCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objzx_SkillCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objzx_SkillCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objzx_SkillCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objzx_SkillCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objzx_SkillCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objzx_SkillCond[strFldName]));
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
public static List<clszx_SkillEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clszx_SkillEN> arrObjLst = new List<clszx_SkillEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clszx_SkillEN objzx_SkillEN = new clszx_SkillEN();
try
{
objzx_SkillEN.zxSkillId = objRow[conzx_Skill.zxSkillId].ToString().Trim(); //技能Id
objzx_SkillEN.SkillName = objRow[conzx_Skill.SkillName] == DBNull.Value ? null : objRow[conzx_Skill.SkillName].ToString().Trim(); //技能名称
objzx_SkillEN.zxOperationTypeId = objRow[conzx_Skill.zxOperationTypeId] == DBNull.Value ? null : objRow[conzx_Skill.zxOperationTypeId].ToString().Trim(); //操作类型ID
objzx_SkillEN.Process = objRow[conzx_Skill.Process] == DBNull.Value ? null : objRow[conzx_Skill.Process].ToString().Trim(); //实施过程
objzx_SkillEN.zxLevelId = objRow[conzx_Skill.zxLevelId] == DBNull.Value ? null : objRow[conzx_Skill.zxLevelId].ToString().Trim(); //级别Id
objzx_SkillEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[conzx_Skill.IsSubmit].ToString().Trim()); //是否提交
objzx_SkillEN.TextId = objRow[conzx_Skill.TextId] == DBNull.Value ? null : objRow[conzx_Skill.TextId].ToString().Trim(); //课件Id
objzx_SkillEN.VoteCount = objRow[conzx_Skill.VoteCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_Skill.VoteCount].ToString().Trim()); //点赞计数
objzx_SkillEN.AppraiseCount = objRow[conzx_Skill.AppraiseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_Skill.AppraiseCount].ToString().Trim()); //评论数
objzx_SkillEN.Score = objRow[conzx_Skill.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conzx_Skill.Score].ToString().Trim()); //评分
objzx_SkillEN.StuScore = objRow[conzx_Skill.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conzx_Skill.StuScore].ToString().Trim()); //学生平均分
objzx_SkillEN.TeaScore = objRow[conzx_Skill.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conzx_Skill.TeaScore].ToString().Trim()); //教师评分
objzx_SkillEN.IdCurrEduCls = objRow[conzx_Skill.IdCurrEduCls] == DBNull.Value ? null : objRow[conzx_Skill.IdCurrEduCls].ToString().Trim(); //教学班流水号
objzx_SkillEN.PdfContent = objRow[conzx_Skill.PdfContent] == DBNull.Value ? null : objRow[conzx_Skill.PdfContent].ToString().Trim(); //Pdf内容
objzx_SkillEN.PdfPageNum = objRow[conzx_Skill.PdfPageNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_Skill.PdfPageNum].ToString().Trim()); //Pdf页码
objzx_SkillEN.CitationCount = objRow[conzx_Skill.CitationCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_Skill.CitationCount].ToString().Trim()); //引用统计
objzx_SkillEN.VersionCount = objRow[conzx_Skill.VersionCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_Skill.VersionCount].ToString().Trim()); //版本统计
objzx_SkillEN.zxShareId = objRow[conzx_Skill.zxShareId] == DBNull.Value ? null : objRow[conzx_Skill.zxShareId].ToString().Trim(); //分享Id
objzx_SkillEN.UpdUser = objRow[conzx_Skill.UpdUser] == DBNull.Value ? null : objRow[conzx_Skill.UpdUser].ToString().Trim(); //修改人
objzx_SkillEN.CreateDate = objRow[conzx_Skill.CreateDate] == DBNull.Value ? null : objRow[conzx_Skill.CreateDate].ToString().Trim(); //建立日期
objzx_SkillEN.UpdDate = objRow[conzx_Skill.UpdDate] == DBNull.Value ? null : objRow[conzx_Skill.UpdDate].ToString().Trim(); //修改日期
objzx_SkillEN.Memo = objRow[conzx_Skill.Memo] == DBNull.Value ? null : objRow[conzx_Skill.Memo].ToString().Trim(); //备注
objzx_SkillEN.PdfDivLet = objRow[conzx_Skill.PdfDivLet] == DBNull.Value ? null : objRow[conzx_Skill.PdfDivLet].ToString().Trim(); //PdfDivLet
objzx_SkillEN.PdfDivTop = objRow[conzx_Skill.PdfDivTop] == DBNull.Value ? null : objRow[conzx_Skill.PdfDivTop].ToString().Trim(); //PdfDivTop
objzx_SkillEN.PdfPageNumIn = objRow[conzx_Skill.PdfPageNumIn] == DBNull.Value ? null : objRow[conzx_Skill.PdfPageNumIn].ToString().Trim(); //PdfPageNumIn
objzx_SkillEN.PdfPageTop = objRow[conzx_Skill.PdfPageTop] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_Skill.PdfPageTop].ToString().Trim()); //pdf页面顶部位置
objzx_SkillEN.PdfZoom = objRow[conzx_Skill.PdfZoom] == DBNull.Value ? null : objRow[conzx_Skill.PdfZoom].ToString().Trim(); //PdfZoom
objzx_SkillEN.GroupTextId = objRow[conzx_Skill.GroupTextId] == DBNull.Value ? null : objRow[conzx_Skill.GroupTextId].ToString().Trim(); //小组Id
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objzx_SkillEN.zxSkillId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objzx_SkillEN);
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
public static List<clszx_SkillEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clszx_SkillEN> arrObjLst = new List<clszx_SkillEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clszx_SkillEN objzx_SkillEN = new clszx_SkillEN();
try
{
objzx_SkillEN.zxSkillId = objRow[conzx_Skill.zxSkillId].ToString().Trim(); //技能Id
objzx_SkillEN.SkillName = objRow[conzx_Skill.SkillName] == DBNull.Value ? null : objRow[conzx_Skill.SkillName].ToString().Trim(); //技能名称
objzx_SkillEN.zxOperationTypeId = objRow[conzx_Skill.zxOperationTypeId] == DBNull.Value ? null : objRow[conzx_Skill.zxOperationTypeId].ToString().Trim(); //操作类型ID
objzx_SkillEN.Process = objRow[conzx_Skill.Process] == DBNull.Value ? null : objRow[conzx_Skill.Process].ToString().Trim(); //实施过程
objzx_SkillEN.zxLevelId = objRow[conzx_Skill.zxLevelId] == DBNull.Value ? null : objRow[conzx_Skill.zxLevelId].ToString().Trim(); //级别Id
objzx_SkillEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[conzx_Skill.IsSubmit].ToString().Trim()); //是否提交
objzx_SkillEN.TextId = objRow[conzx_Skill.TextId] == DBNull.Value ? null : objRow[conzx_Skill.TextId].ToString().Trim(); //课件Id
objzx_SkillEN.VoteCount = objRow[conzx_Skill.VoteCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_Skill.VoteCount].ToString().Trim()); //点赞计数
objzx_SkillEN.AppraiseCount = objRow[conzx_Skill.AppraiseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_Skill.AppraiseCount].ToString().Trim()); //评论数
objzx_SkillEN.Score = objRow[conzx_Skill.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conzx_Skill.Score].ToString().Trim()); //评分
objzx_SkillEN.StuScore = objRow[conzx_Skill.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conzx_Skill.StuScore].ToString().Trim()); //学生平均分
objzx_SkillEN.TeaScore = objRow[conzx_Skill.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conzx_Skill.TeaScore].ToString().Trim()); //教师评分
objzx_SkillEN.IdCurrEduCls = objRow[conzx_Skill.IdCurrEduCls] == DBNull.Value ? null : objRow[conzx_Skill.IdCurrEduCls].ToString().Trim(); //教学班流水号
objzx_SkillEN.PdfContent = objRow[conzx_Skill.PdfContent] == DBNull.Value ? null : objRow[conzx_Skill.PdfContent].ToString().Trim(); //Pdf内容
objzx_SkillEN.PdfPageNum = objRow[conzx_Skill.PdfPageNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_Skill.PdfPageNum].ToString().Trim()); //Pdf页码
objzx_SkillEN.CitationCount = objRow[conzx_Skill.CitationCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_Skill.CitationCount].ToString().Trim()); //引用统计
objzx_SkillEN.VersionCount = objRow[conzx_Skill.VersionCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_Skill.VersionCount].ToString().Trim()); //版本统计
objzx_SkillEN.zxShareId = objRow[conzx_Skill.zxShareId] == DBNull.Value ? null : objRow[conzx_Skill.zxShareId].ToString().Trim(); //分享Id
objzx_SkillEN.UpdUser = objRow[conzx_Skill.UpdUser] == DBNull.Value ? null : objRow[conzx_Skill.UpdUser].ToString().Trim(); //修改人
objzx_SkillEN.CreateDate = objRow[conzx_Skill.CreateDate] == DBNull.Value ? null : objRow[conzx_Skill.CreateDate].ToString().Trim(); //建立日期
objzx_SkillEN.UpdDate = objRow[conzx_Skill.UpdDate] == DBNull.Value ? null : objRow[conzx_Skill.UpdDate].ToString().Trim(); //修改日期
objzx_SkillEN.Memo = objRow[conzx_Skill.Memo] == DBNull.Value ? null : objRow[conzx_Skill.Memo].ToString().Trim(); //备注
objzx_SkillEN.PdfDivLet = objRow[conzx_Skill.PdfDivLet] == DBNull.Value ? null : objRow[conzx_Skill.PdfDivLet].ToString().Trim(); //PdfDivLet
objzx_SkillEN.PdfDivTop = objRow[conzx_Skill.PdfDivTop] == DBNull.Value ? null : objRow[conzx_Skill.PdfDivTop].ToString().Trim(); //PdfDivTop
objzx_SkillEN.PdfPageNumIn = objRow[conzx_Skill.PdfPageNumIn] == DBNull.Value ? null : objRow[conzx_Skill.PdfPageNumIn].ToString().Trim(); //PdfPageNumIn
objzx_SkillEN.PdfPageTop = objRow[conzx_Skill.PdfPageTop] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_Skill.PdfPageTop].ToString().Trim()); //pdf页面顶部位置
objzx_SkillEN.PdfZoom = objRow[conzx_Skill.PdfZoom] == DBNull.Value ? null : objRow[conzx_Skill.PdfZoom].ToString().Trim(); //PdfZoom
objzx_SkillEN.GroupTextId = objRow[conzx_Skill.GroupTextId] == DBNull.Value ? null : objRow[conzx_Skill.GroupTextId].ToString().Trim(); //小组Id
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objzx_SkillEN.zxSkillId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objzx_SkillEN);
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
List<clszx_SkillEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clszx_SkillEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clszx_SkillEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clszx_SkillEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clszx_SkillEN> arrObjLst = new List<clszx_SkillEN>(); 
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
	clszx_SkillEN objzx_SkillEN = new clszx_SkillEN();
try
{
objzx_SkillEN.zxSkillId = objRow[conzx_Skill.zxSkillId].ToString().Trim(); //技能Id
objzx_SkillEN.SkillName = objRow[conzx_Skill.SkillName] == DBNull.Value ? null : objRow[conzx_Skill.SkillName].ToString().Trim(); //技能名称
objzx_SkillEN.zxOperationTypeId = objRow[conzx_Skill.zxOperationTypeId] == DBNull.Value ? null : objRow[conzx_Skill.zxOperationTypeId].ToString().Trim(); //操作类型ID
objzx_SkillEN.Process = objRow[conzx_Skill.Process] == DBNull.Value ? null : objRow[conzx_Skill.Process].ToString().Trim(); //实施过程
objzx_SkillEN.zxLevelId = objRow[conzx_Skill.zxLevelId] == DBNull.Value ? null : objRow[conzx_Skill.zxLevelId].ToString().Trim(); //级别Id
objzx_SkillEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[conzx_Skill.IsSubmit].ToString().Trim()); //是否提交
objzx_SkillEN.TextId = objRow[conzx_Skill.TextId] == DBNull.Value ? null : objRow[conzx_Skill.TextId].ToString().Trim(); //课件Id
objzx_SkillEN.VoteCount = objRow[conzx_Skill.VoteCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_Skill.VoteCount].ToString().Trim()); //点赞计数
objzx_SkillEN.AppraiseCount = objRow[conzx_Skill.AppraiseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_Skill.AppraiseCount].ToString().Trim()); //评论数
objzx_SkillEN.Score = objRow[conzx_Skill.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conzx_Skill.Score].ToString().Trim()); //评分
objzx_SkillEN.StuScore = objRow[conzx_Skill.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conzx_Skill.StuScore].ToString().Trim()); //学生平均分
objzx_SkillEN.TeaScore = objRow[conzx_Skill.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conzx_Skill.TeaScore].ToString().Trim()); //教师评分
objzx_SkillEN.IdCurrEduCls = objRow[conzx_Skill.IdCurrEduCls] == DBNull.Value ? null : objRow[conzx_Skill.IdCurrEduCls].ToString().Trim(); //教学班流水号
objzx_SkillEN.PdfContent = objRow[conzx_Skill.PdfContent] == DBNull.Value ? null : objRow[conzx_Skill.PdfContent].ToString().Trim(); //Pdf内容
objzx_SkillEN.PdfPageNum = objRow[conzx_Skill.PdfPageNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_Skill.PdfPageNum].ToString().Trim()); //Pdf页码
objzx_SkillEN.CitationCount = objRow[conzx_Skill.CitationCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_Skill.CitationCount].ToString().Trim()); //引用统计
objzx_SkillEN.VersionCount = objRow[conzx_Skill.VersionCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_Skill.VersionCount].ToString().Trim()); //版本统计
objzx_SkillEN.zxShareId = objRow[conzx_Skill.zxShareId] == DBNull.Value ? null : objRow[conzx_Skill.zxShareId].ToString().Trim(); //分享Id
objzx_SkillEN.UpdUser = objRow[conzx_Skill.UpdUser] == DBNull.Value ? null : objRow[conzx_Skill.UpdUser].ToString().Trim(); //修改人
objzx_SkillEN.CreateDate = objRow[conzx_Skill.CreateDate] == DBNull.Value ? null : objRow[conzx_Skill.CreateDate].ToString().Trim(); //建立日期
objzx_SkillEN.UpdDate = objRow[conzx_Skill.UpdDate] == DBNull.Value ? null : objRow[conzx_Skill.UpdDate].ToString().Trim(); //修改日期
objzx_SkillEN.Memo = objRow[conzx_Skill.Memo] == DBNull.Value ? null : objRow[conzx_Skill.Memo].ToString().Trim(); //备注
objzx_SkillEN.PdfDivLet = objRow[conzx_Skill.PdfDivLet] == DBNull.Value ? null : objRow[conzx_Skill.PdfDivLet].ToString().Trim(); //PdfDivLet
objzx_SkillEN.PdfDivTop = objRow[conzx_Skill.PdfDivTop] == DBNull.Value ? null : objRow[conzx_Skill.PdfDivTop].ToString().Trim(); //PdfDivTop
objzx_SkillEN.PdfPageNumIn = objRow[conzx_Skill.PdfPageNumIn] == DBNull.Value ? null : objRow[conzx_Skill.PdfPageNumIn].ToString().Trim(); //PdfPageNumIn
objzx_SkillEN.PdfPageTop = objRow[conzx_Skill.PdfPageTop] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_Skill.PdfPageTop].ToString().Trim()); //pdf页面顶部位置
objzx_SkillEN.PdfZoom = objRow[conzx_Skill.PdfZoom] == DBNull.Value ? null : objRow[conzx_Skill.PdfZoom].ToString().Trim(); //PdfZoom
objzx_SkillEN.GroupTextId = objRow[conzx_Skill.GroupTextId] == DBNull.Value ? null : objRow[conzx_Skill.GroupTextId].ToString().Trim(); //小组Id
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objzx_SkillEN.zxSkillId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objzx_SkillEN);
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
public static List<clszx_SkillEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clszx_SkillEN> arrObjLst = new List<clszx_SkillEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clszx_SkillEN objzx_SkillEN = new clszx_SkillEN();
try
{
objzx_SkillEN.zxSkillId = objRow[conzx_Skill.zxSkillId].ToString().Trim(); //技能Id
objzx_SkillEN.SkillName = objRow[conzx_Skill.SkillName] == DBNull.Value ? null : objRow[conzx_Skill.SkillName].ToString().Trim(); //技能名称
objzx_SkillEN.zxOperationTypeId = objRow[conzx_Skill.zxOperationTypeId] == DBNull.Value ? null : objRow[conzx_Skill.zxOperationTypeId].ToString().Trim(); //操作类型ID
objzx_SkillEN.Process = objRow[conzx_Skill.Process] == DBNull.Value ? null : objRow[conzx_Skill.Process].ToString().Trim(); //实施过程
objzx_SkillEN.zxLevelId = objRow[conzx_Skill.zxLevelId] == DBNull.Value ? null : objRow[conzx_Skill.zxLevelId].ToString().Trim(); //级别Id
objzx_SkillEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[conzx_Skill.IsSubmit].ToString().Trim()); //是否提交
objzx_SkillEN.TextId = objRow[conzx_Skill.TextId] == DBNull.Value ? null : objRow[conzx_Skill.TextId].ToString().Trim(); //课件Id
objzx_SkillEN.VoteCount = objRow[conzx_Skill.VoteCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_Skill.VoteCount].ToString().Trim()); //点赞计数
objzx_SkillEN.AppraiseCount = objRow[conzx_Skill.AppraiseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_Skill.AppraiseCount].ToString().Trim()); //评论数
objzx_SkillEN.Score = objRow[conzx_Skill.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conzx_Skill.Score].ToString().Trim()); //评分
objzx_SkillEN.StuScore = objRow[conzx_Skill.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conzx_Skill.StuScore].ToString().Trim()); //学生平均分
objzx_SkillEN.TeaScore = objRow[conzx_Skill.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conzx_Skill.TeaScore].ToString().Trim()); //教师评分
objzx_SkillEN.IdCurrEduCls = objRow[conzx_Skill.IdCurrEduCls] == DBNull.Value ? null : objRow[conzx_Skill.IdCurrEduCls].ToString().Trim(); //教学班流水号
objzx_SkillEN.PdfContent = objRow[conzx_Skill.PdfContent] == DBNull.Value ? null : objRow[conzx_Skill.PdfContent].ToString().Trim(); //Pdf内容
objzx_SkillEN.PdfPageNum = objRow[conzx_Skill.PdfPageNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_Skill.PdfPageNum].ToString().Trim()); //Pdf页码
objzx_SkillEN.CitationCount = objRow[conzx_Skill.CitationCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_Skill.CitationCount].ToString().Trim()); //引用统计
objzx_SkillEN.VersionCount = objRow[conzx_Skill.VersionCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_Skill.VersionCount].ToString().Trim()); //版本统计
objzx_SkillEN.zxShareId = objRow[conzx_Skill.zxShareId] == DBNull.Value ? null : objRow[conzx_Skill.zxShareId].ToString().Trim(); //分享Id
objzx_SkillEN.UpdUser = objRow[conzx_Skill.UpdUser] == DBNull.Value ? null : objRow[conzx_Skill.UpdUser].ToString().Trim(); //修改人
objzx_SkillEN.CreateDate = objRow[conzx_Skill.CreateDate] == DBNull.Value ? null : objRow[conzx_Skill.CreateDate].ToString().Trim(); //建立日期
objzx_SkillEN.UpdDate = objRow[conzx_Skill.UpdDate] == DBNull.Value ? null : objRow[conzx_Skill.UpdDate].ToString().Trim(); //修改日期
objzx_SkillEN.Memo = objRow[conzx_Skill.Memo] == DBNull.Value ? null : objRow[conzx_Skill.Memo].ToString().Trim(); //备注
objzx_SkillEN.PdfDivLet = objRow[conzx_Skill.PdfDivLet] == DBNull.Value ? null : objRow[conzx_Skill.PdfDivLet].ToString().Trim(); //PdfDivLet
objzx_SkillEN.PdfDivTop = objRow[conzx_Skill.PdfDivTop] == DBNull.Value ? null : objRow[conzx_Skill.PdfDivTop].ToString().Trim(); //PdfDivTop
objzx_SkillEN.PdfPageNumIn = objRow[conzx_Skill.PdfPageNumIn] == DBNull.Value ? null : objRow[conzx_Skill.PdfPageNumIn].ToString().Trim(); //PdfPageNumIn
objzx_SkillEN.PdfPageTop = objRow[conzx_Skill.PdfPageTop] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_Skill.PdfPageTop].ToString().Trim()); //pdf页面顶部位置
objzx_SkillEN.PdfZoom = objRow[conzx_Skill.PdfZoom] == DBNull.Value ? null : objRow[conzx_Skill.PdfZoom].ToString().Trim(); //PdfZoom
objzx_SkillEN.GroupTextId = objRow[conzx_Skill.GroupTextId] == DBNull.Value ? null : objRow[conzx_Skill.GroupTextId].ToString().Trim(); //小组Id
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objzx_SkillEN.zxSkillId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objzx_SkillEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clszx_SkillEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clszx_SkillEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clszx_SkillEN> arrObjLst = new List<clszx_SkillEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clszx_SkillEN objzx_SkillEN = new clszx_SkillEN();
try
{
objzx_SkillEN.zxSkillId = objRow[conzx_Skill.zxSkillId].ToString().Trim(); //技能Id
objzx_SkillEN.SkillName = objRow[conzx_Skill.SkillName] == DBNull.Value ? null : objRow[conzx_Skill.SkillName].ToString().Trim(); //技能名称
objzx_SkillEN.zxOperationTypeId = objRow[conzx_Skill.zxOperationTypeId] == DBNull.Value ? null : objRow[conzx_Skill.zxOperationTypeId].ToString().Trim(); //操作类型ID
objzx_SkillEN.Process = objRow[conzx_Skill.Process] == DBNull.Value ? null : objRow[conzx_Skill.Process].ToString().Trim(); //实施过程
objzx_SkillEN.zxLevelId = objRow[conzx_Skill.zxLevelId] == DBNull.Value ? null : objRow[conzx_Skill.zxLevelId].ToString().Trim(); //级别Id
objzx_SkillEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[conzx_Skill.IsSubmit].ToString().Trim()); //是否提交
objzx_SkillEN.TextId = objRow[conzx_Skill.TextId] == DBNull.Value ? null : objRow[conzx_Skill.TextId].ToString().Trim(); //课件Id
objzx_SkillEN.VoteCount = objRow[conzx_Skill.VoteCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_Skill.VoteCount].ToString().Trim()); //点赞计数
objzx_SkillEN.AppraiseCount = objRow[conzx_Skill.AppraiseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_Skill.AppraiseCount].ToString().Trim()); //评论数
objzx_SkillEN.Score = objRow[conzx_Skill.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conzx_Skill.Score].ToString().Trim()); //评分
objzx_SkillEN.StuScore = objRow[conzx_Skill.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conzx_Skill.StuScore].ToString().Trim()); //学生平均分
objzx_SkillEN.TeaScore = objRow[conzx_Skill.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conzx_Skill.TeaScore].ToString().Trim()); //教师评分
objzx_SkillEN.IdCurrEduCls = objRow[conzx_Skill.IdCurrEduCls] == DBNull.Value ? null : objRow[conzx_Skill.IdCurrEduCls].ToString().Trim(); //教学班流水号
objzx_SkillEN.PdfContent = objRow[conzx_Skill.PdfContent] == DBNull.Value ? null : objRow[conzx_Skill.PdfContent].ToString().Trim(); //Pdf内容
objzx_SkillEN.PdfPageNum = objRow[conzx_Skill.PdfPageNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_Skill.PdfPageNum].ToString().Trim()); //Pdf页码
objzx_SkillEN.CitationCount = objRow[conzx_Skill.CitationCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_Skill.CitationCount].ToString().Trim()); //引用统计
objzx_SkillEN.VersionCount = objRow[conzx_Skill.VersionCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_Skill.VersionCount].ToString().Trim()); //版本统计
objzx_SkillEN.zxShareId = objRow[conzx_Skill.zxShareId] == DBNull.Value ? null : objRow[conzx_Skill.zxShareId].ToString().Trim(); //分享Id
objzx_SkillEN.UpdUser = objRow[conzx_Skill.UpdUser] == DBNull.Value ? null : objRow[conzx_Skill.UpdUser].ToString().Trim(); //修改人
objzx_SkillEN.CreateDate = objRow[conzx_Skill.CreateDate] == DBNull.Value ? null : objRow[conzx_Skill.CreateDate].ToString().Trim(); //建立日期
objzx_SkillEN.UpdDate = objRow[conzx_Skill.UpdDate] == DBNull.Value ? null : objRow[conzx_Skill.UpdDate].ToString().Trim(); //修改日期
objzx_SkillEN.Memo = objRow[conzx_Skill.Memo] == DBNull.Value ? null : objRow[conzx_Skill.Memo].ToString().Trim(); //备注
objzx_SkillEN.PdfDivLet = objRow[conzx_Skill.PdfDivLet] == DBNull.Value ? null : objRow[conzx_Skill.PdfDivLet].ToString().Trim(); //PdfDivLet
objzx_SkillEN.PdfDivTop = objRow[conzx_Skill.PdfDivTop] == DBNull.Value ? null : objRow[conzx_Skill.PdfDivTop].ToString().Trim(); //PdfDivTop
objzx_SkillEN.PdfPageNumIn = objRow[conzx_Skill.PdfPageNumIn] == DBNull.Value ? null : objRow[conzx_Skill.PdfPageNumIn].ToString().Trim(); //PdfPageNumIn
objzx_SkillEN.PdfPageTop = objRow[conzx_Skill.PdfPageTop] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_Skill.PdfPageTop].ToString().Trim()); //pdf页面顶部位置
objzx_SkillEN.PdfZoom = objRow[conzx_Skill.PdfZoom] == DBNull.Value ? null : objRow[conzx_Skill.PdfZoom].ToString().Trim(); //PdfZoom
objzx_SkillEN.GroupTextId = objRow[conzx_Skill.GroupTextId] == DBNull.Value ? null : objRow[conzx_Skill.GroupTextId].ToString().Trim(); //小组Id
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objzx_SkillEN.zxSkillId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objzx_SkillEN);
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
public static List<clszx_SkillEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clszx_SkillEN> arrObjLst = new List<clszx_SkillEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clszx_SkillEN objzx_SkillEN = new clszx_SkillEN();
try
{
objzx_SkillEN.zxSkillId = objRow[conzx_Skill.zxSkillId].ToString().Trim(); //技能Id
objzx_SkillEN.SkillName = objRow[conzx_Skill.SkillName] == DBNull.Value ? null : objRow[conzx_Skill.SkillName].ToString().Trim(); //技能名称
objzx_SkillEN.zxOperationTypeId = objRow[conzx_Skill.zxOperationTypeId] == DBNull.Value ? null : objRow[conzx_Skill.zxOperationTypeId].ToString().Trim(); //操作类型ID
objzx_SkillEN.Process = objRow[conzx_Skill.Process] == DBNull.Value ? null : objRow[conzx_Skill.Process].ToString().Trim(); //实施过程
objzx_SkillEN.zxLevelId = objRow[conzx_Skill.zxLevelId] == DBNull.Value ? null : objRow[conzx_Skill.zxLevelId].ToString().Trim(); //级别Id
objzx_SkillEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[conzx_Skill.IsSubmit].ToString().Trim()); //是否提交
objzx_SkillEN.TextId = objRow[conzx_Skill.TextId] == DBNull.Value ? null : objRow[conzx_Skill.TextId].ToString().Trim(); //课件Id
objzx_SkillEN.VoteCount = objRow[conzx_Skill.VoteCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_Skill.VoteCount].ToString().Trim()); //点赞计数
objzx_SkillEN.AppraiseCount = objRow[conzx_Skill.AppraiseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_Skill.AppraiseCount].ToString().Trim()); //评论数
objzx_SkillEN.Score = objRow[conzx_Skill.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conzx_Skill.Score].ToString().Trim()); //评分
objzx_SkillEN.StuScore = objRow[conzx_Skill.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conzx_Skill.StuScore].ToString().Trim()); //学生平均分
objzx_SkillEN.TeaScore = objRow[conzx_Skill.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conzx_Skill.TeaScore].ToString().Trim()); //教师评分
objzx_SkillEN.IdCurrEduCls = objRow[conzx_Skill.IdCurrEduCls] == DBNull.Value ? null : objRow[conzx_Skill.IdCurrEduCls].ToString().Trim(); //教学班流水号
objzx_SkillEN.PdfContent = objRow[conzx_Skill.PdfContent] == DBNull.Value ? null : objRow[conzx_Skill.PdfContent].ToString().Trim(); //Pdf内容
objzx_SkillEN.PdfPageNum = objRow[conzx_Skill.PdfPageNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_Skill.PdfPageNum].ToString().Trim()); //Pdf页码
objzx_SkillEN.CitationCount = objRow[conzx_Skill.CitationCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_Skill.CitationCount].ToString().Trim()); //引用统计
objzx_SkillEN.VersionCount = objRow[conzx_Skill.VersionCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_Skill.VersionCount].ToString().Trim()); //版本统计
objzx_SkillEN.zxShareId = objRow[conzx_Skill.zxShareId] == DBNull.Value ? null : objRow[conzx_Skill.zxShareId].ToString().Trim(); //分享Id
objzx_SkillEN.UpdUser = objRow[conzx_Skill.UpdUser] == DBNull.Value ? null : objRow[conzx_Skill.UpdUser].ToString().Trim(); //修改人
objzx_SkillEN.CreateDate = objRow[conzx_Skill.CreateDate] == DBNull.Value ? null : objRow[conzx_Skill.CreateDate].ToString().Trim(); //建立日期
objzx_SkillEN.UpdDate = objRow[conzx_Skill.UpdDate] == DBNull.Value ? null : objRow[conzx_Skill.UpdDate].ToString().Trim(); //修改日期
objzx_SkillEN.Memo = objRow[conzx_Skill.Memo] == DBNull.Value ? null : objRow[conzx_Skill.Memo].ToString().Trim(); //备注
objzx_SkillEN.PdfDivLet = objRow[conzx_Skill.PdfDivLet] == DBNull.Value ? null : objRow[conzx_Skill.PdfDivLet].ToString().Trim(); //PdfDivLet
objzx_SkillEN.PdfDivTop = objRow[conzx_Skill.PdfDivTop] == DBNull.Value ? null : objRow[conzx_Skill.PdfDivTop].ToString().Trim(); //PdfDivTop
objzx_SkillEN.PdfPageNumIn = objRow[conzx_Skill.PdfPageNumIn] == DBNull.Value ? null : objRow[conzx_Skill.PdfPageNumIn].ToString().Trim(); //PdfPageNumIn
objzx_SkillEN.PdfPageTop = objRow[conzx_Skill.PdfPageTop] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_Skill.PdfPageTop].ToString().Trim()); //pdf页面顶部位置
objzx_SkillEN.PdfZoom = objRow[conzx_Skill.PdfZoom] == DBNull.Value ? null : objRow[conzx_Skill.PdfZoom].ToString().Trim(); //PdfZoom
objzx_SkillEN.GroupTextId = objRow[conzx_Skill.GroupTextId] == DBNull.Value ? null : objRow[conzx_Skill.GroupTextId].ToString().Trim(); //小组Id
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objzx_SkillEN.zxSkillId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objzx_SkillEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clszx_SkillEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clszx_SkillEN> arrObjLst = new List<clszx_SkillEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clszx_SkillEN objzx_SkillEN = new clszx_SkillEN();
try
{
objzx_SkillEN.zxSkillId = objRow[conzx_Skill.zxSkillId].ToString().Trim(); //技能Id
objzx_SkillEN.SkillName = objRow[conzx_Skill.SkillName] == DBNull.Value ? null : objRow[conzx_Skill.SkillName].ToString().Trim(); //技能名称
objzx_SkillEN.zxOperationTypeId = objRow[conzx_Skill.zxOperationTypeId] == DBNull.Value ? null : objRow[conzx_Skill.zxOperationTypeId].ToString().Trim(); //操作类型ID
objzx_SkillEN.Process = objRow[conzx_Skill.Process] == DBNull.Value ? null : objRow[conzx_Skill.Process].ToString().Trim(); //实施过程
objzx_SkillEN.zxLevelId = objRow[conzx_Skill.zxLevelId] == DBNull.Value ? null : objRow[conzx_Skill.zxLevelId].ToString().Trim(); //级别Id
objzx_SkillEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[conzx_Skill.IsSubmit].ToString().Trim()); //是否提交
objzx_SkillEN.TextId = objRow[conzx_Skill.TextId] == DBNull.Value ? null : objRow[conzx_Skill.TextId].ToString().Trim(); //课件Id
objzx_SkillEN.VoteCount = objRow[conzx_Skill.VoteCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_Skill.VoteCount].ToString().Trim()); //点赞计数
objzx_SkillEN.AppraiseCount = objRow[conzx_Skill.AppraiseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_Skill.AppraiseCount].ToString().Trim()); //评论数
objzx_SkillEN.Score = objRow[conzx_Skill.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conzx_Skill.Score].ToString().Trim()); //评分
objzx_SkillEN.StuScore = objRow[conzx_Skill.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conzx_Skill.StuScore].ToString().Trim()); //学生平均分
objzx_SkillEN.TeaScore = objRow[conzx_Skill.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conzx_Skill.TeaScore].ToString().Trim()); //教师评分
objzx_SkillEN.IdCurrEduCls = objRow[conzx_Skill.IdCurrEduCls] == DBNull.Value ? null : objRow[conzx_Skill.IdCurrEduCls].ToString().Trim(); //教学班流水号
objzx_SkillEN.PdfContent = objRow[conzx_Skill.PdfContent] == DBNull.Value ? null : objRow[conzx_Skill.PdfContent].ToString().Trim(); //Pdf内容
objzx_SkillEN.PdfPageNum = objRow[conzx_Skill.PdfPageNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_Skill.PdfPageNum].ToString().Trim()); //Pdf页码
objzx_SkillEN.CitationCount = objRow[conzx_Skill.CitationCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_Skill.CitationCount].ToString().Trim()); //引用统计
objzx_SkillEN.VersionCount = objRow[conzx_Skill.VersionCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_Skill.VersionCount].ToString().Trim()); //版本统计
objzx_SkillEN.zxShareId = objRow[conzx_Skill.zxShareId] == DBNull.Value ? null : objRow[conzx_Skill.zxShareId].ToString().Trim(); //分享Id
objzx_SkillEN.UpdUser = objRow[conzx_Skill.UpdUser] == DBNull.Value ? null : objRow[conzx_Skill.UpdUser].ToString().Trim(); //修改人
objzx_SkillEN.CreateDate = objRow[conzx_Skill.CreateDate] == DBNull.Value ? null : objRow[conzx_Skill.CreateDate].ToString().Trim(); //建立日期
objzx_SkillEN.UpdDate = objRow[conzx_Skill.UpdDate] == DBNull.Value ? null : objRow[conzx_Skill.UpdDate].ToString().Trim(); //修改日期
objzx_SkillEN.Memo = objRow[conzx_Skill.Memo] == DBNull.Value ? null : objRow[conzx_Skill.Memo].ToString().Trim(); //备注
objzx_SkillEN.PdfDivLet = objRow[conzx_Skill.PdfDivLet] == DBNull.Value ? null : objRow[conzx_Skill.PdfDivLet].ToString().Trim(); //PdfDivLet
objzx_SkillEN.PdfDivTop = objRow[conzx_Skill.PdfDivTop] == DBNull.Value ? null : objRow[conzx_Skill.PdfDivTop].ToString().Trim(); //PdfDivTop
objzx_SkillEN.PdfPageNumIn = objRow[conzx_Skill.PdfPageNumIn] == DBNull.Value ? null : objRow[conzx_Skill.PdfPageNumIn].ToString().Trim(); //PdfPageNumIn
objzx_SkillEN.PdfPageTop = objRow[conzx_Skill.PdfPageTop] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_Skill.PdfPageTop].ToString().Trim()); //pdf页面顶部位置
objzx_SkillEN.PdfZoom = objRow[conzx_Skill.PdfZoom] == DBNull.Value ? null : objRow[conzx_Skill.PdfZoom].ToString().Trim(); //PdfZoom
objzx_SkillEN.GroupTextId = objRow[conzx_Skill.GroupTextId] == DBNull.Value ? null : objRow[conzx_Skill.GroupTextId].ToString().Trim(); //小组Id
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objzx_SkillEN.zxSkillId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objzx_SkillEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objzx_SkillEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool Getzx_Skill(ref clszx_SkillEN objzx_SkillEN)
{
bool bolResult = zx_SkillDA.Getzx_Skill(ref objzx_SkillEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "strzxSkillId">表关键字</param>
 /// <returns>表对象</returns>
public static clszx_SkillEN GetObjByzxSkillId(string strzxSkillId)
{
if (strzxSkillId.IndexOf(' ') >=0)
{
var strMsg = string.Format("(errid:Busi000079)在表中,关键字[strzxSkillId]中不能有空格!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
if (string.IsNullOrEmpty(strzxSkillId) == true)
{
var strMsg = string.Format("(errid:Busi000020)在表中,关键字[strzxSkillId]不能为空!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
clszx_SkillEN objzx_SkillEN = zx_SkillDA.GetObjByzxSkillId(strzxSkillId);
return objzx_SkillEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clszx_SkillEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clszx_SkillEN objzx_SkillEN = zx_SkillDA.GetFirstObj(strWhereCond);
 return objzx_SkillEN;
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
public static clszx_SkillEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clszx_SkillEN objzx_SkillEN = zx_SkillDA.GetObjByDataRow(objRow);
 return objzx_SkillEN;
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
public static clszx_SkillEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clszx_SkillEN objzx_SkillEN = zx_SkillDA.GetObjByDataRow(objRow);
 return objzx_SkillEN;
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
 /// <param name = "strzxSkillId">所给的关键字</param>
 /// <param name = "lstzx_SkillObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clszx_SkillEN GetObjByzxSkillIdFromList(string strzxSkillId, List<clszx_SkillEN> lstzx_SkillObjLst)
{
foreach (clszx_SkillEN objzx_SkillEN in lstzx_SkillObjLst)
{
if (objzx_SkillEN.zxSkillId == strzxSkillId)
{
return objzx_SkillEN;
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
 string strMaxZxSkillId;
 try
 {
 strMaxZxSkillId = clszx_SkillDA.GetMaxStrId();
 return strMaxZxSkillId;
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
 string strzxSkillId;
 try
 {
 strzxSkillId = new clszx_SkillDA().GetFirstID(strWhereCond);
 return strzxSkillId;
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
 arrList = zx_SkillDA.GetID(strWhereCond);
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
bool bolIsExist = zx_SkillDA.IsExistCondRec(strWhereCond);
return bolIsExist;
}

 /// <summary>
 /// 判断当前表中是否存在给定关键字值的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExist)
 /// </summary>
 /// <param name = "strzxSkillId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public static bool IsExist(string strzxSkillId)
{
if (string.IsNullOrEmpty(strzxSkillId) == true)
{
var strMsg = string.Format("(errid:Busi000027)在表中,关键字[strzxSkillId]不能为空!!(from {0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
//检测记录是否存在
bool bolIsExist = zx_SkillDA.IsExist(strzxSkillId);
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
 bolIsExist = clszx_SkillDA.IsExistTable();
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
 bolIsExist = zx_SkillDA.IsExistTable(strTabName);
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
 /// <param name = "objzx_SkillEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecordBySql2(clszx_SkillEN objzx_SkillEN)
{
if (objzx_SkillEN.CheckUniqueness() == false)
{
var strMsg = string.Format("记录已经存在!课件Id = [{0}]的数据已经存在!(in clszx_SkillBL.AddNewRecordBySql2)", objzx_SkillEN.TextId);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objzx_SkillEN.zxSkillId) == true || clszx_SkillBL.IsExist(objzx_SkillEN.zxSkillId) == true)
 {
     objzx_SkillEN.zxSkillId = clszx_SkillBL.GetMaxStrId_S();
 }
bool bolResult = zx_SkillDA.AddNewRecordBySQL2(objzx_SkillEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clszx_SkillBL.ReFreshCache(objzx_SkillEN.IdCurrEduCls);

if (clszx_SkillBL.relatedActions != null)
{
clszx_SkillBL.relatedActions.UpdRelaTabDate(objzx_SkillEN.zxSkillId, "SetUpdDate");
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
 /// <param name = "objzx_SkillEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordBySql2WithReturnKey(clszx_SkillEN objzx_SkillEN)
{
if (objzx_SkillEN.CheckUniqueness() == false)
{
var strMsg = string.Format("记录已经存在!课件Id = [{0}]的数据已经存在!(in clszx_SkillBL.AddNewRecordBySql2WithReturnKey)", objzx_SkillEN.TextId);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objzx_SkillEN.zxSkillId) == true || clszx_SkillBL.IsExist(objzx_SkillEN.zxSkillId) == true)
 {
     objzx_SkillEN.zxSkillId = clszx_SkillBL.GetMaxStrId_S();
 }
string strKey = zx_SkillDA.AddNewRecordBySQL2WithReturnKey(objzx_SkillEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clszx_SkillBL.ReFreshCache(objzx_SkillEN.IdCurrEduCls);

if (clszx_SkillBL.relatedActions != null)
{
clszx_SkillBL.relatedActions.UpdRelaTabDate(objzx_SkillEN.zxSkillId, "SetUpdDate");
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
 /// <param name = "objzx_SkillEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(clszx_SkillEN objzx_SkillEN)
{
try
{
bool bolResult = zx_SkillDA.Update(objzx_SkillEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clszx_SkillBL.ReFreshCache(objzx_SkillEN.IdCurrEduCls);

if (clszx_SkillBL.relatedActions != null)
{
clszx_SkillBL.relatedActions.UpdRelaTabDate(objzx_SkillEN.zxSkillId, "SetUpdDate");
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
 /// <param name = "objzx_SkillEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateBySql2(clszx_SkillEN objzx_SkillEN)
{
 if (string.IsNullOrEmpty(objzx_SkillEN.zxSkillId) == true)
 {
var strMsg = string.Format("(errid:Busi000065)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = zx_SkillDA.UpdateBySql2(objzx_SkillEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clszx_SkillBL.ReFreshCache(objzx_SkillEN.IdCurrEduCls);

if (clszx_SkillBL.relatedActions != null)
{
clszx_SkillBL.relatedActions.UpdRelaTabDate(objzx_SkillEN.zxSkillId, "SetUpdDate");
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
 /// <param name = "strzxSkillId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int DelRecord(string strzxSkillId)
{
try
{
 clszx_SkillEN objzx_SkillEN = clszx_SkillBL.GetObjByzxSkillId(strzxSkillId);

if (clszx_SkillBL.relatedActions != null)
{
clszx_SkillBL.relatedActions.UpdRelaTabDate(objzx_SkillEN.zxSkillId, "SetUpdDate");
}
if (objzx_SkillEN != null)
{
int intRecNum = zx_SkillDA.DelRecord(strzxSkillId);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
ReFreshCache(objzx_SkillEN.IdCurrEduCls);
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
/// <param name="strzxSkillId">表关键字</param>
 /// <param name = "strIdCurrEduCls">缓存的分类字段</param>
/// <returns></returns>
public static bool DelRecordEx(string strzxSkillId , string strIdCurrEduCls)
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clszx_SkillDA.GetSpecSQLObj();
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
//删除与表:[zx_Skill]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conzx_Skill.zxSkillId,
//strzxSkillId);
//        clszx_SkillBL.Delzx_SkillsByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clszx_SkillBL.DelRecord(strzxSkillId, strIdCurrEduCls, objConnection, objSqlTransaction);
objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clszx_SkillBLEx", "DelRecordEx", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("扩展删除记录出错:{0}!keyId = {1}.({2})",
objException.Message,
strzxSkillId, clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "strzxSkillId">给定的关键字值</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回删除是否成功?</returns>
public static bool DelRecord(string strzxSkillId, string strIdCurrEduCls, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
if (clszx_SkillBL.relatedActions != null)
{
clszx_SkillBL.relatedActions.UpdRelaTabDate(strzxSkillId, "UpdRelaTabDate");
}
bool bolResult = zx_SkillDA.DelRecord(strzxSkillId,objSqlConnection,objSqlTransaction);
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
 /// <param name = "arrzxSkillIdLst">给定的关键字值列表</param>
 /// <returns>返回删除的记录数</returns>
public static int Delzx_Skills(List<string> arrzxSkillIdLst)
{
if (arrzxSkillIdLst.Count == 0) return 0;
try
{
if (clszx_SkillBL.relatedActions != null)
{
foreach (var strzxSkillId in arrzxSkillIdLst)
{
clszx_SkillBL.relatedActions.UpdRelaTabDate(strzxSkillId, "UpdRelaTabDate");
}
}
 clszx_SkillEN objzx_SkillEN = clszx_SkillBL.GetObjByzxSkillId(arrzxSkillIdLst[0]);
int intDelRecNum = zx_SkillDA.Delzx_Skill(arrzxSkillIdLst);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
ReFreshCache(objzx_SkillEN.IdCurrEduCls);
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
public static int Delzx_SkillsByCond(string strWhereCond)
{
try
{
if (clszx_SkillBL.relatedActions != null)
{
List<string> arrzxSkillId = GetPrimaryKeyID_S(strWhereCond);
foreach (var strzxSkillId in arrzxSkillId)
{
clszx_SkillBL.relatedActions.UpdRelaTabDate(strzxSkillId, "UpdRelaTabDate");
}
}
List<string> arrIdCurrEduCls = GetFldValue(conzx_Skill.IdCurrEduCls, strWhereCond);
int intRecNum = zx_SkillDA.Delzx_Skill(strWhereCond);
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
/// 这里仅仅是演示函数,使用时请复制到扩展类:[zx_Skill]中改名为:[DelRecord4MultiTabEx]使用
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DelRecord4MultiTab)
/// </summary>
/// <param name="strzxSkillId">表关键字</param>
 /// <param name = "strIdCurrEduCls">缓存的分类字段</param>
/// <returns></returns>
public static bool DelRecord4MultiTab(string strzxSkillId, string strIdCurrEduCls)
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clszx_SkillDA.GetSpecSQLObj();
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
//删除与表:[zx_Skill]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conStudent.id_College,
//strid_College);
//        clsStudentBL.DelStudentsByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clszx_SkillBL.DelRecord(strzxSkillId, strIdCurrEduCls, objConnection, objSqlTransaction);
                objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clszx_SkillBL", "DelRecord4MultiTab", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("删除多表记录出错:{0}!keyId = {1}.({2})",
objException.Message,
strzxSkillId, clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "objzx_SkillENS">源对象</param>
 /// <param name = "objzx_SkillENT">目标对象</param>
 public static void CopyTo(clszx_SkillEN objzx_SkillENS, clszx_SkillEN objzx_SkillENT)
{
try
{
objzx_SkillENT.zxSkillId = objzx_SkillENS.zxSkillId; //技能Id
objzx_SkillENT.SkillName = objzx_SkillENS.SkillName; //技能名称
objzx_SkillENT.zxOperationTypeId = objzx_SkillENS.zxOperationTypeId; //操作类型ID
objzx_SkillENT.Process = objzx_SkillENS.Process; //实施过程
objzx_SkillENT.zxLevelId = objzx_SkillENS.zxLevelId; //级别Id
objzx_SkillENT.IsSubmit = objzx_SkillENS.IsSubmit; //是否提交
objzx_SkillENT.TextId = objzx_SkillENS.TextId; //课件Id
objzx_SkillENT.VoteCount = objzx_SkillENS.VoteCount; //点赞计数
objzx_SkillENT.AppraiseCount = objzx_SkillENS.AppraiseCount; //评论数
objzx_SkillENT.Score = objzx_SkillENS.Score; //评分
objzx_SkillENT.StuScore = objzx_SkillENS.StuScore; //学生平均分
objzx_SkillENT.TeaScore = objzx_SkillENS.TeaScore; //教师评分
objzx_SkillENT.IdCurrEduCls = objzx_SkillENS.IdCurrEduCls; //教学班流水号
objzx_SkillENT.PdfContent = objzx_SkillENS.PdfContent; //Pdf内容
objzx_SkillENT.PdfPageNum = objzx_SkillENS.PdfPageNum; //Pdf页码
objzx_SkillENT.CitationCount = objzx_SkillENS.CitationCount; //引用统计
objzx_SkillENT.VersionCount = objzx_SkillENS.VersionCount; //版本统计
objzx_SkillENT.zxShareId = objzx_SkillENS.zxShareId; //分享Id
objzx_SkillENT.UpdUser = objzx_SkillENS.UpdUser; //修改人
objzx_SkillENT.CreateDate = objzx_SkillENS.CreateDate; //建立日期
objzx_SkillENT.UpdDate = objzx_SkillENS.UpdDate; //修改日期
objzx_SkillENT.Memo = objzx_SkillENS.Memo; //备注
objzx_SkillENT.PdfDivLet = objzx_SkillENS.PdfDivLet; //PdfDivLet
objzx_SkillENT.PdfDivTop = objzx_SkillENS.PdfDivTop; //PdfDivTop
objzx_SkillENT.PdfPageNumIn = objzx_SkillENS.PdfPageNumIn; //PdfPageNumIn
objzx_SkillENT.PdfPageTop = objzx_SkillENS.PdfPageTop; //pdf页面顶部位置
objzx_SkillENT.PdfZoom = objzx_SkillENS.PdfZoom; //PdfZoom
objzx_SkillENT.GroupTextId = objzx_SkillENS.GroupTextId; //小组Id
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
 /// <param name = "objzx_SkillEN">源简化对象</param>
 public static void SetUpdFlag(clszx_SkillEN objzx_SkillEN)
{
try
{
objzx_SkillEN.ClearUpdateState();
   string strsfUpdFldSetStr = objzx_SkillEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(conzx_Skill.zxSkillId, new clsStrCompareIgnoreCase())  ==  true)
{
objzx_SkillEN.zxSkillId = objzx_SkillEN.zxSkillId; //技能Id
}
if (arrFldSet.Contains(conzx_Skill.SkillName, new clsStrCompareIgnoreCase())  ==  true)
{
objzx_SkillEN.SkillName = objzx_SkillEN.SkillName == "[null]" ? null :  objzx_SkillEN.SkillName; //技能名称
}
if (arrFldSet.Contains(conzx_Skill.zxOperationTypeId, new clsStrCompareIgnoreCase())  ==  true)
{
objzx_SkillEN.zxOperationTypeId = objzx_SkillEN.zxOperationTypeId == "[null]" ? null :  objzx_SkillEN.zxOperationTypeId; //操作类型ID
}
if (arrFldSet.Contains(conzx_Skill.Process, new clsStrCompareIgnoreCase())  ==  true)
{
objzx_SkillEN.Process = objzx_SkillEN.Process == "[null]" ? null :  objzx_SkillEN.Process; //实施过程
}
if (arrFldSet.Contains(conzx_Skill.zxLevelId, new clsStrCompareIgnoreCase())  ==  true)
{
objzx_SkillEN.zxLevelId = objzx_SkillEN.zxLevelId == "[null]" ? null :  objzx_SkillEN.zxLevelId; //级别Id
}
if (arrFldSet.Contains(conzx_Skill.IsSubmit, new clsStrCompareIgnoreCase())  ==  true)
{
objzx_SkillEN.IsSubmit = objzx_SkillEN.IsSubmit; //是否提交
}
if (arrFldSet.Contains(conzx_Skill.TextId, new clsStrCompareIgnoreCase())  ==  true)
{
objzx_SkillEN.TextId = objzx_SkillEN.TextId == "[null]" ? null :  objzx_SkillEN.TextId; //课件Id
}
if (arrFldSet.Contains(conzx_Skill.VoteCount, new clsStrCompareIgnoreCase())  ==  true)
{
objzx_SkillEN.VoteCount = objzx_SkillEN.VoteCount; //点赞计数
}
if (arrFldSet.Contains(conzx_Skill.AppraiseCount, new clsStrCompareIgnoreCase())  ==  true)
{
objzx_SkillEN.AppraiseCount = objzx_SkillEN.AppraiseCount; //评论数
}
if (arrFldSet.Contains(conzx_Skill.Score, new clsStrCompareIgnoreCase())  ==  true)
{
objzx_SkillEN.Score = objzx_SkillEN.Score; //评分
}
if (arrFldSet.Contains(conzx_Skill.StuScore, new clsStrCompareIgnoreCase())  ==  true)
{
objzx_SkillEN.StuScore = objzx_SkillEN.StuScore; //学生平均分
}
if (arrFldSet.Contains(conzx_Skill.TeaScore, new clsStrCompareIgnoreCase())  ==  true)
{
objzx_SkillEN.TeaScore = objzx_SkillEN.TeaScore; //教师评分
}
if (arrFldSet.Contains(conzx_Skill.IdCurrEduCls, new clsStrCompareIgnoreCase())  ==  true)
{
objzx_SkillEN.IdCurrEduCls = objzx_SkillEN.IdCurrEduCls == "[null]" ? null :  objzx_SkillEN.IdCurrEduCls; //教学班流水号
}
if (arrFldSet.Contains(conzx_Skill.PdfContent, new clsStrCompareIgnoreCase())  ==  true)
{
objzx_SkillEN.PdfContent = objzx_SkillEN.PdfContent == "[null]" ? null :  objzx_SkillEN.PdfContent; //Pdf内容
}
if (arrFldSet.Contains(conzx_Skill.PdfPageNum, new clsStrCompareIgnoreCase())  ==  true)
{
objzx_SkillEN.PdfPageNum = objzx_SkillEN.PdfPageNum; //Pdf页码
}
if (arrFldSet.Contains(conzx_Skill.CitationCount, new clsStrCompareIgnoreCase())  ==  true)
{
objzx_SkillEN.CitationCount = objzx_SkillEN.CitationCount; //引用统计
}
if (arrFldSet.Contains(conzx_Skill.VersionCount, new clsStrCompareIgnoreCase())  ==  true)
{
objzx_SkillEN.VersionCount = objzx_SkillEN.VersionCount; //版本统计
}
if (arrFldSet.Contains(conzx_Skill.zxShareId, new clsStrCompareIgnoreCase())  ==  true)
{
objzx_SkillEN.zxShareId = objzx_SkillEN.zxShareId == "[null]" ? null :  objzx_SkillEN.zxShareId; //分享Id
}
if (arrFldSet.Contains(conzx_Skill.UpdUser, new clsStrCompareIgnoreCase())  ==  true)
{
objzx_SkillEN.UpdUser = objzx_SkillEN.UpdUser == "[null]" ? null :  objzx_SkillEN.UpdUser; //修改人
}
if (arrFldSet.Contains(conzx_Skill.CreateDate, new clsStrCompareIgnoreCase())  ==  true)
{
objzx_SkillEN.CreateDate = objzx_SkillEN.CreateDate == "[null]" ? null :  objzx_SkillEN.CreateDate; //建立日期
}
if (arrFldSet.Contains(conzx_Skill.UpdDate, new clsStrCompareIgnoreCase())  ==  true)
{
objzx_SkillEN.UpdDate = objzx_SkillEN.UpdDate == "[null]" ? null :  objzx_SkillEN.UpdDate; //修改日期
}
if (arrFldSet.Contains(conzx_Skill.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objzx_SkillEN.Memo = objzx_SkillEN.Memo == "[null]" ? null :  objzx_SkillEN.Memo; //备注
}
if (arrFldSet.Contains(conzx_Skill.PdfDivLet, new clsStrCompareIgnoreCase())  ==  true)
{
objzx_SkillEN.PdfDivLet = objzx_SkillEN.PdfDivLet == "[null]" ? null :  objzx_SkillEN.PdfDivLet; //PdfDivLet
}
if (arrFldSet.Contains(conzx_Skill.PdfDivTop, new clsStrCompareIgnoreCase())  ==  true)
{
objzx_SkillEN.PdfDivTop = objzx_SkillEN.PdfDivTop == "[null]" ? null :  objzx_SkillEN.PdfDivTop; //PdfDivTop
}
if (arrFldSet.Contains(conzx_Skill.PdfPageNumIn, new clsStrCompareIgnoreCase())  ==  true)
{
objzx_SkillEN.PdfPageNumIn = objzx_SkillEN.PdfPageNumIn == "[null]" ? null :  objzx_SkillEN.PdfPageNumIn; //PdfPageNumIn
}
if (arrFldSet.Contains(conzx_Skill.PdfPageTop, new clsStrCompareIgnoreCase())  ==  true)
{
objzx_SkillEN.PdfPageTop = objzx_SkillEN.PdfPageTop; //pdf页面顶部位置
}
if (arrFldSet.Contains(conzx_Skill.PdfZoom, new clsStrCompareIgnoreCase())  ==  true)
{
objzx_SkillEN.PdfZoom = objzx_SkillEN.PdfZoom == "[null]" ? null :  objzx_SkillEN.PdfZoom; //PdfZoom
}
if (arrFldSet.Contains(conzx_Skill.GroupTextId, new clsStrCompareIgnoreCase())  ==  true)
{
objzx_SkillEN.GroupTextId = objzx_SkillEN.GroupTextId == "[null]" ? null :  objzx_SkillEN.GroupTextId; //小组Id
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
 /// <param name = "objzx_SkillEN">源简化对象</param>
 public static void AccessFldValueNull(clszx_SkillEN objzx_SkillEN)
{
try
{
if (objzx_SkillEN.SkillName == "[null]") objzx_SkillEN.SkillName = null; //技能名称
if (objzx_SkillEN.zxOperationTypeId == "[null]") objzx_SkillEN.zxOperationTypeId = null; //操作类型ID
if (objzx_SkillEN.Process == "[null]") objzx_SkillEN.Process = null; //实施过程
if (objzx_SkillEN.zxLevelId == "[null]") objzx_SkillEN.zxLevelId = null; //级别Id
if (objzx_SkillEN.TextId == "[null]") objzx_SkillEN.TextId = null; //课件Id
if (objzx_SkillEN.IdCurrEduCls == "[null]") objzx_SkillEN.IdCurrEduCls = null; //教学班流水号
if (objzx_SkillEN.PdfContent == "[null]") objzx_SkillEN.PdfContent = null; //Pdf内容
if (objzx_SkillEN.zxShareId == "[null]") objzx_SkillEN.zxShareId = null; //分享Id
if (objzx_SkillEN.UpdUser == "[null]") objzx_SkillEN.UpdUser = null; //修改人
if (objzx_SkillEN.CreateDate == "[null]") objzx_SkillEN.CreateDate = null; //建立日期
if (objzx_SkillEN.UpdDate == "[null]") objzx_SkillEN.UpdDate = null; //修改日期
if (objzx_SkillEN.Memo == "[null]") objzx_SkillEN.Memo = null; //备注
if (objzx_SkillEN.PdfDivLet == "[null]") objzx_SkillEN.PdfDivLet = null; //PdfDivLet
if (objzx_SkillEN.PdfDivTop == "[null]") objzx_SkillEN.PdfDivTop = null; //PdfDivTop
if (objzx_SkillEN.PdfPageNumIn == "[null]") objzx_SkillEN.PdfPageNumIn = null; //PdfPageNumIn
if (objzx_SkillEN.PdfZoom == "[null]") objzx_SkillEN.PdfZoom = null; //PdfZoom
if (objzx_SkillEN.GroupTextId == "[null]") objzx_SkillEN.GroupTextId = null; //小组Id
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
public static void CheckPropertyNew(clszx_SkillEN objzx_SkillEN)
{
 zx_SkillDA.CheckPropertyNew(objzx_SkillEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(clszx_SkillEN objzx_SkillEN)
{
 zx_SkillDA.CheckProperty4Condition(objzx_SkillEN);
 }


 #endregion 检查对象属性


 #region 绑定下拉框

 /// <summary>
 /// 绑定基于Win的下拉框
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_TabFeature_ComboBoxBindFunction)
 /// </summary>
 /// <param name = "objComboBox">需要绑定当前表的下拉框</param>

 /// <param name = "strIdCurrEduCls"></param>
public static void BindCbo_zxSkillId(System.Windows.Forms.ComboBox objComboBox , string strIdCurrEduCls)
{
//为数据源为表的下拉框设置内容
string strCondition = string.Format("1 =1 Order By {0}", conzx_Skill.zxSkillId); 
List<clszx_SkillEN> arrObjLst = clszx_SkillBL.GetObjLst(strCondition);
var arrObjLstSel = arrObjLst.Where(x=>x.IdCurrEduCls == strIdCurrEduCls).ToList();
//初始化一个对象列表
//插入第0项。在第0项中插入“请选择...”,为了方便用户,与WEB方式类似。
clszx_SkillEN objzx_SkillEN = new clszx_SkillEN()
{
zxSkillId = "0",
zxOperationTypeId = "选[中学技能表]..."
};
arrObjLstSel.Insert(0, objzx_SkillEN);
//设置下拉框的数据源、以及设置值项、显示项
objComboBox.ValueMember = conzx_Skill.zxSkillId;
objComboBox.DisplayMember = conzx_Skill.zxOperationTypeId;
objComboBox.DataSource = arrObjLstSel;
objComboBox.SelectedIndex = 0;
}

 /// <summary>
 /// 绑定基于Web的下拉框
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_TabFeature_DdlBindFunction)
 /// </summary>
 /// <param name = "objDDL">需要绑定当前表的下拉框</param>

 /// <param name = "strIdCurrEduCls"></param>
public static void BindDdl_zxSkillId(System.Web.UI.WebControls.DropDownList objDDL , string strIdCurrEduCls)
{
//为数据源于表的下拉框设置内容
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[中学技能表]...","0");
string strCondition = string.Format("1 =1 Order By {0}", conzx_Skill.zxSkillId); 
IEnumerable<clszx_SkillEN> arrObjLst = clszx_SkillBL.GetObjLst(strCondition);
var arrObjLstSel = arrObjLst.Where(x=>x.IdCurrEduCls == strIdCurrEduCls).ToList();
objDDL.DataValueField = conzx_Skill.zxSkillId;
objDDL.DataTextField = conzx_Skill.zxOperationTypeId;
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
public static void BindDdl_zxSkillIdCache(System.Web.UI.WebControls.DropDownList objDDL, string strIdCurrEduCls)
{
//为数据源于表的下拉框设置内容
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[中学技能表]...","0");
List<clszx_SkillEN> arrzx_SkillObjLst = GetAllzx_SkillObjLstCache(strIdCurrEduCls); 
objDDL.DataValueField = conzx_Skill.zxSkillId;
objDDL.DataTextField = conzx_Skill.zxOperationTypeId;
objDDL.DataSource = arrzx_SkillObjLst;
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
if (clszx_SkillBL.objCommFun4BL == null)
{
strMsg = string.Format("类clszx_SkillBL没有刷新缓存机制(clszx_SkillBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by zxSkillId");
//if (arrzx_SkillObjLstCache == null)
//{
//arrzx_SkillObjLstCache = zx_SkillDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "strzxSkillId">所给的关键字</param>
 /// <param name = "strIdCurrEduCls">缓存的分类字段</param>
 /// <returns>根据关键字获取的对象</returns>
public static clszx_SkillEN GetObjByzxSkillIdCache(string strzxSkillId, string strIdCurrEduCls)
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
string strKey = string.Format("{0}_{1}", clszx_SkillEN._CurrTabName, strIdCurrEduCls);
List<clszx_SkillEN> arrzx_SkillObjLstCache = GetObjLstCache(strIdCurrEduCls);
IEnumerable <clszx_SkillEN> arrzx_SkillObjLst_Sel =
arrzx_SkillObjLstCache
.Where(x=> x.zxSkillId == strzxSkillId 
);
if (arrzx_SkillObjLst_Sel.Count() == 0)
{
   clszx_SkillEN obj = clszx_SkillBL.GetObjByzxSkillId(strzxSkillId);
   if (obj != null)
 {
if (obj.IdCurrEduCls == strIdCurrEduCls)
{
CacheHelper.Remove(strKey);
     return obj;
}
else
{
string strMsg = string.Format("错误: 关键字:{0}不属于分类:{1},请检查!(In {2})", strzxSkillId, strIdCurrEduCls, clsStackTrace.GetCurrClassFunction());
clsSysParaEN.objLog.WriteDebugLog(strMsg);
throw new Exception(strMsg);
}
 }
return null;
}
return arrzx_SkillObjLst_Sel.First();
}

 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecNameByKeyCache)
 /// </summary>
 /// <param name = "strzxSkillId">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetzxLevelIdByzxSkillIdCache(string strzxSkillId, string strIdCurrEduCls)
{
if (string.IsNullOrEmpty(strzxSkillId) == true) return "";
//获取缓存中的对象列表
clszx_SkillEN objzx_Skill = GetObjByzxSkillIdCache(strzxSkillId, strIdCurrEduCls);
if (objzx_Skill == null) return "";
return objzx_Skill.zxLevelId;
}
 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecNameByKeyCache)
 /// </summary>
 /// <param name = "strzxSkillId">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetNameByzxSkillIdCache(string strzxSkillId, string strIdCurrEduCls)
{
if (string.IsNullOrEmpty(strzxSkillId) == true) return "";
//获取缓存中的对象列表
clszx_SkillEN objzx_Skill = GetObjByzxSkillIdCache(strzxSkillId, strIdCurrEduCls);
if (objzx_Skill == null) return "";
return objzx_Skill.zxLevelId;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clszx_SkillEN> GetAllzx_SkillObjLstCache(string strIdCurrEduCls)
{
//获取缓存中的对象列表
List<clszx_SkillEN> arrzx_SkillObjLstCache = GetObjLstCache(strIdCurrEduCls); 
return arrzx_SkillObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clszx_SkillEN> GetObjLstCache(string strIdCurrEduCls)
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
string strKey = string.Format("{0}_{1}", clszx_SkillEN._CurrTabName, strIdCurrEduCls);
string strCondition = string.Format("IdCurrEduCls='{0}'", strIdCurrEduCls);
List<clszx_SkillEN> arrzx_SkillObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst(strCondition); });
return arrzx_SkillObjLstCache;
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
string strKey = string.Format("{0}_{1}", clszx_SkillEN._CurrTabName, strIdCurrEduCls);
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
if (clszx_SkillBL.objCommFun4BL != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}_{1}", clszx_SkillEN._CurrTabName, strIdCurrEduCls);
CacheHelper.Remove(strKey);
clszx_SkillBL.objCommFun4BL.ReFreshCache(strIdCurrEduCls);
}
}


 #endregion 缓存操作


 #region 检查唯一性

 /// <summary>
 /// 获取检查唯一性条件串(Uniqueness)--zx_Skill(中学技能表)
 /// 唯一性条件:TextId
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetUniquenessConditionString)
 /// </summary>
 /// <param name = "objzx_SkillEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(clszx_SkillEN objzx_SkillEN)
{
//检测记录是否存在
string strResult = zx_SkillDA.GetUniCondStr(objzx_SkillEN);
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
public static string Func(string strInFldName, string strOutFldName, string strzxSkillId, string strIdCurrEduCls)
{
if (strInFldName != conzx_Skill.zxSkillId)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (conzx_Skill.AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", conzx_Skill.AttributeName));
throw new Exception(strMsg);
}
var objzx_Skill = clszx_SkillBL.GetObjByzxSkillIdCache(strzxSkillId, strIdCurrEduCls);
if (objzx_Skill == null) return "";
return objzx_Skill[strOutFldName].ToString();
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
int intRecCount = clszx_SkillDA.GetRecCount(strTabName);
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
int intRecCount = clszx_SkillDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clszx_SkillDA.GetRecCount();
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
int intRecCount = clszx_SkillDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objzx_SkillCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clszx_SkillEN objzx_SkillCond)
{
 string strIdCurrEduCls = objzx_SkillCond.IdCurrEduCls;
 if (string.IsNullOrEmpty(strIdCurrEduCls) == true)
{
string strMsg = string.Format("(errid:Busi000174)在表中,缓存分类字段值不能为空!(clszx_SkillBL:GetRecCountByCondCache)");
throw new Exception(strMsg);
}
List<clszx_SkillEN> arrObjLstCache = GetObjLstCache(strIdCurrEduCls);
IEnumerable <clszx_SkillEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conzx_Skill.AttributeName)
{
if (objzx_SkillCond.IsUpdated(strFldName) == false) continue;
if (objzx_SkillCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objzx_SkillCond[strFldName].ToString());
}
else
{
if (objzx_SkillCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objzx_SkillCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objzx_SkillCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objzx_SkillCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objzx_SkillCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objzx_SkillCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objzx_SkillCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objzx_SkillCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objzx_SkillCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objzx_SkillCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objzx_SkillCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objzx_SkillCond[strFldName]));
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
 List<string> arrList = clszx_SkillDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = zx_SkillDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = zx_SkillDA.GetFldValueNoDistinct(strFldName, strWhereCond);
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
int intRecCount = zx_SkillDA.SetFldValue(strFldName, strValue, strWhereCond);
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
int intRecCount = clszx_SkillDA.SetFldValue(clszx_SkillEN._CurrTabName, strFldName, fltValue, strWhereCond);
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
int intRecCount = zx_SkillDA.SetFldValue( strFldName, intValue, strWhereCond);
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
int intRecCount = clszx_SkillDA.SetFldValue(strTabName, strFldName, strValue, strWhereCond);
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
int intRecCount = clszx_SkillDA.SetFldValue(strTabName, strFldName, intValue, strWhereCond);
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
int intRecCount = clszx_SkillDA.SetFldValue(strTabName, strFldName, fltValue, strWhereCond);
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
  strCreateTabCode.Append("CREATE table [dbo].[zx_Skill] "); 
 strCreateTabCode.Append(" ( "); 
 // /**技能Id*/ 
 strCreateTabCode.Append(" zxSkillId char(10) primary key, "); 
 // /**技能名称*/ 
 strCreateTabCode.Append(" SkillName varchar(200) Null, "); 
 // /**操作类型ID*/ 
 strCreateTabCode.Append(" zxOperationTypeId char(2) Null, "); 
 // /**实施过程*/ 
 strCreateTabCode.Append(" Process text Null, "); 
 // /**级别Id*/ 
 strCreateTabCode.Append(" zxLevelId char(2) Null, "); 
 // /**是否提交*/ 
 strCreateTabCode.Append(" IsSubmit bit Null, "); 
 // /**课件Id*/ 
 strCreateTabCode.Append(" TextId char(8) Null, "); 
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
 strCreateTabCode.Append(" zxShareId char(2) Null, "); 
 // /**修改人*/ 
 strCreateTabCode.Append(" UpdUser varchar(20) Null, "); 
 // /**建立日期*/ 
 strCreateTabCode.Append(" CreateDate varchar(20) Null, "); 
 // /**修改日期*/ 
 strCreateTabCode.Append(" UpdDate varchar(20) Null, "); 
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
 /// 中学技能表(zx_Skill)
 /// 数据源类型:表
 /// (AutoGCLib.CommFun4BL4CSharp:GeneCode_This)
 /// </summary>
public class  clsCommFun4BL4zx_Skill : clsCommFun4BLV2
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
clszx_SkillBL.ReFreshThisCache(strIdCurrEduCls);
}
}

}