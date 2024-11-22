
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clszx_TextBL
 表名:zx_Text(01120704)
 * 版本:2023.11.15.1(服务器:WIN-SRV103-116)
 日期:2023/11/15 22:53:31
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
public static class  clszx_TextBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "strTextId">表关键字</param>
 /// <returns>表对象</returns>
public static clszx_TextEN GetObj(this K_TextId_zx_Text myKey)
{
clszx_TextEN objzx_TextEN = clszx_TextBL.zx_TextDA.GetObjByTextId(myKey.Value);
return objzx_TextEN;
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_AddNewRecord)
 /// </summary>
 /// <param name = "objzx_TextEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clszx_TextEN objzx_TextEN)
{
if (CheckUniqueness(objzx_TextEN) == false)
{
var strMsg = string.Format("记录已经存在!教学班流水号 = [{0}]的数据已经存在!(in clszx_TextBL.AddNewRecord)", objzx_TextEN.IdCurrEduCls);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objzx_TextEN.TextId) == true || clszx_TextBL.IsExist(objzx_TextEN.TextId) == true)
 {
     objzx_TextEN.TextId = clszx_TextBL.GetMaxStrId_S();
 }
bool bolResult = clszx_TextBL.zx_TextDA.AddNewRecordBySQL2(objzx_TextEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clszx_TextBL.ReFreshCache(objzx_TextEN.IdCurrEduCls);

if (clszx_TextBL.relatedActions != null)
{
clszx_TextBL.relatedActions.UpdRelaTabDate(objzx_TextEN.TextId, "SetUpdDate");
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
public static bool AddRecordEx(this clszx_TextEN objzx_TextEN)
{
//操作步骤:
//1、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在
//2、检查唯一性
//3、检查传进去的对象属性是否合法
//4、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
//1、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在

//因为是字符型自增主键,不需要检查主键是否已经存在,在添加时,再获取 最大值作为主键
//if (clszx_TextBL.IsExist(objzx_TextEN.TextId))	//判断是否有相同的关键字
//{
//strMsg = "(errid:Busi000151)关键字字段已有相同的值";
//throw new Exception(strMsg);
//}
try
{
 //2、检查传进去的对象属性是否合法
objzx_TextEN.CheckPropertyNew();
 ///5.2、检查唯一性
if (objzx_TextEN.CheckUniqueness() == false)
{
strMsg = string.Format("(教学班流水号(IdCurrEduCls)=[{0}])已经存在,不能重复!", objzx_TextEN.IdCurrEduCls);
throw new Exception(strMsg);
}
//因为是字符型自增主键,所以在添加时,自动获取主键值。
 if (string.IsNullOrEmpty(objzx_TextEN.TextId) == true || clszx_TextBL.IsExist(objzx_TextEN.TextId) == true)
 {
     objzx_TextEN.TextId = clszx_TextBL.GetMaxStrId_S();
 }
//6、把数据实体层的数据存贮到数据库中
objzx_TextEN.AddNewRecord();
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
 /// <param name = "objzx_TextEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static string AddNewRecordWithMaxId(this clszx_TextEN objzx_TextEN)
{
if (CheckUniqueness(objzx_TextEN) == false)
{
var strMsg = string.Format("记录已经存在!教学班流水号 = [{0}]的数据已经存在!(in clszx_TextBL.AddNewRecordWithMaxId)", objzx_TextEN.IdCurrEduCls);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objzx_TextEN.TextId) == true || clszx_TextBL.IsExist(objzx_TextEN.TextId) == true)
 {
     objzx_TextEN.TextId = clszx_TextBL.GetMaxStrId_S();
 }
string strTextId = clszx_TextBL.zx_TextDA.AddNewRecordBySQL2WithReturnKey(objzx_TextEN);
     objzx_TextEN.TextId = strTextId;
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clszx_TextBL.ReFreshCache(objzx_TextEN.IdCurrEduCls);

if (clszx_TextBL.relatedActions != null)
{
clszx_TextBL.relatedActions.UpdRelaTabDate(objzx_TextEN.TextId, "SetUpdDate");
}
return strTextId;
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
 /// <param name = "objzx_TextEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordWithReturnKey(this clszx_TextEN objzx_TextEN)
{
if (CheckUniqueness(objzx_TextEN) == false)
{
var strMsg = string.Format("记录已经存在!教学班流水号 = [{0}]的数据已经存在!(in clszx_TextBL.AddNewRecordWithReturnKey)", objzx_TextEN.IdCurrEduCls);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objzx_TextEN.TextId) == true || clszx_TextBL.IsExist(objzx_TextEN.TextId) == true)
 {
     objzx_TextEN.TextId = clszx_TextBL.GetMaxStrId_S();
 }
string strKey = clszx_TextBL.zx_TextDA.AddNewRecordBySQL2WithReturnKey(objzx_TextEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clszx_TextBL.ReFreshCache(objzx_TextEN.IdCurrEduCls);

if (clszx_TextBL.relatedActions != null)
{
clszx_TextBL.relatedActions.UpdRelaTabDate(objzx_TextEN.TextId, "SetUpdDate");
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
 /// <param name = "objzx_TextEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clszx_TextEN SetTextId(this clszx_TextEN objzx_TextEN, string strTextId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTextId, 8, conzx_Text.TextId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strTextId, 8, conzx_Text.TextId);
}
objzx_TextEN.TextId = strTextId; //课件Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objzx_TextEN.dicFldComparisonOp.ContainsKey(conzx_Text.TextId) == false)
{
objzx_TextEN.dicFldComparisonOp.Add(conzx_Text.TextId, strComparisonOp);
}
else
{
objzx_TextEN.dicFldComparisonOp[conzx_Text.TextId] = strComparisonOp;
}
}
return objzx_TextEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objzx_TextEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clszx_TextEN SetTextTitle(this clszx_TextEN objzx_TextEN, string strTextTitle, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strTextTitle, conzx_Text.TextTitle);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTextTitle, 500, conzx_Text.TextTitle);
}
objzx_TextEN.TextTitle = strTextTitle; //TextTitle
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objzx_TextEN.dicFldComparisonOp.ContainsKey(conzx_Text.TextTitle) == false)
{
objzx_TextEN.dicFldComparisonOp.Add(conzx_Text.TextTitle, strComparisonOp);
}
else
{
objzx_TextEN.dicFldComparisonOp[conzx_Text.TextTitle] = strComparisonOp;
}
}
return objzx_TextEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objzx_TextEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clszx_TextEN SetTextContent(this clszx_TextEN objzx_TextEN, string strTextContent, string strComparisonOp="")
	{
objzx_TextEN.TextContent = strTextContent; //TextContent
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objzx_TextEN.dicFldComparisonOp.ContainsKey(conzx_Text.TextContent) == false)
{
objzx_TextEN.dicFldComparisonOp.Add(conzx_Text.TextContent, strComparisonOp);
}
else
{
objzx_TextEN.dicFldComparisonOp[conzx_Text.TextContent] = strComparisonOp;
}
}
return objzx_TextEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objzx_TextEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clszx_TextEN SetEdition(this clszx_TextEN objzx_TextEN, string strEdition, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strEdition, 100, conzx_Text.Edition);
}
objzx_TextEN.Edition = strEdition; //Edition
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objzx_TextEN.dicFldComparisonOp.ContainsKey(conzx_Text.Edition) == false)
{
objzx_TextEN.dicFldComparisonOp.Add(conzx_Text.Edition, strComparisonOp);
}
else
{
objzx_TextEN.dicFldComparisonOp[conzx_Text.Edition] = strComparisonOp;
}
}
return objzx_TextEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objzx_TextEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clszx_TextEN SetAuthor(this clszx_TextEN objzx_TextEN, string strAuthor, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strAuthor, 200, conzx_Text.Author);
}
objzx_TextEN.Author = strAuthor; //作者
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objzx_TextEN.dicFldComparisonOp.ContainsKey(conzx_Text.Author) == false)
{
objzx_TextEN.dicFldComparisonOp.Add(conzx_Text.Author, strComparisonOp);
}
else
{
objzx_TextEN.dicFldComparisonOp[conzx_Text.Author] = strComparisonOp;
}
}
return objzx_TextEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objzx_TextEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clszx_TextEN SetResearchQuestion(this clszx_TextEN objzx_TextEN, string strResearchQuestion, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strResearchQuestion, 2000, conzx_Text.ResearchQuestion);
}
objzx_TextEN.ResearchQuestion = strResearchQuestion; //研究问题
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objzx_TextEN.dicFldComparisonOp.ContainsKey(conzx_Text.ResearchQuestion) == false)
{
objzx_TextEN.dicFldComparisonOp.Add(conzx_Text.ResearchQuestion, strComparisonOp);
}
else
{
objzx_TextEN.dicFldComparisonOp[conzx_Text.ResearchQuestion] = strComparisonOp;
}
}
return objzx_TextEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objzx_TextEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clszx_TextEN SetUpdDate(this clszx_TextEN objzx_TextEN, string strUpdDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdDate, 20, conzx_Text.UpdDate);
}
objzx_TextEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objzx_TextEN.dicFldComparisonOp.ContainsKey(conzx_Text.UpdDate) == false)
{
objzx_TextEN.dicFldComparisonOp.Add(conzx_Text.UpdDate, strComparisonOp);
}
else
{
objzx_TextEN.dicFldComparisonOp[conzx_Text.UpdDate] = strComparisonOp;
}
}
return objzx_TextEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objzx_TextEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clszx_TextEN SetUpdUser(this clszx_TextEN objzx_TextEN, string strUpdUser, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdUser, 20, conzx_Text.UpdUser);
}
objzx_TextEN.UpdUser = strUpdUser; //修改人
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objzx_TextEN.dicFldComparisonOp.ContainsKey(conzx_Text.UpdUser) == false)
{
objzx_TextEN.dicFldComparisonOp.Add(conzx_Text.UpdUser, strComparisonOp);
}
else
{
objzx_TextEN.dicFldComparisonOp[conzx_Text.UpdUser] = strComparisonOp;
}
}
return objzx_TextEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objzx_TextEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clszx_TextEN SetCreateDate(this clszx_TextEN objzx_TextEN, string strCreateDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCreateDate, 20, conzx_Text.CreateDate);
}
objzx_TextEN.CreateDate = strCreateDate; //建立日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objzx_TextEN.dicFldComparisonOp.ContainsKey(conzx_Text.CreateDate) == false)
{
objzx_TextEN.dicFldComparisonOp.Add(conzx_Text.CreateDate, strComparisonOp);
}
else
{
objzx_TextEN.dicFldComparisonOp[conzx_Text.CreateDate] = strComparisonOp;
}
}
return objzx_TextEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objzx_TextEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clszx_TextEN SetChecker(this clszx_TextEN objzx_TextEN, string strChecker, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strChecker, 20, conzx_Text.Checker);
}
objzx_TextEN.Checker = strChecker; //审核人
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objzx_TextEN.dicFldComparisonOp.ContainsKey(conzx_Text.Checker) == false)
{
objzx_TextEN.dicFldComparisonOp.Add(conzx_Text.Checker, strComparisonOp);
}
else
{
objzx_TextEN.dicFldComparisonOp[conzx_Text.Checker] = strComparisonOp;
}
}
return objzx_TextEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objzx_TextEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clszx_TextEN SetIdCurrEduCls(this clszx_TextEN objzx_TextEN, string strIdCurrEduCls, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdCurrEduCls, 8, conzx_Text.IdCurrEduCls);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdCurrEduCls, 8, conzx_Text.IdCurrEduCls);
}
objzx_TextEN.IdCurrEduCls = strIdCurrEduCls; //教学班流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objzx_TextEN.dicFldComparisonOp.ContainsKey(conzx_Text.IdCurrEduCls) == false)
{
objzx_TextEN.dicFldComparisonOp.Add(conzx_Text.IdCurrEduCls, strComparisonOp);
}
else
{
objzx_TextEN.dicFldComparisonOp[conzx_Text.IdCurrEduCls] = strComparisonOp;
}
}
return objzx_TextEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objzx_TextEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clszx_TextEN SetKeyword(this clszx_TextEN objzx_TextEN, string strKeyword, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strKeyword, 1000, conzx_Text.Keyword);
}
objzx_TextEN.Keyword = strKeyword; //关键字
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objzx_TextEN.dicFldComparisonOp.ContainsKey(conzx_Text.Keyword) == false)
{
objzx_TextEN.dicFldComparisonOp.Add(conzx_Text.Keyword, strComparisonOp);
}
else
{
objzx_TextEN.dicFldComparisonOp[conzx_Text.Keyword] = strComparisonOp;
}
}
return objzx_TextEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objzx_TextEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clszx_TextEN SetLiteratureSources(this clszx_TextEN objzx_TextEN, string strLiteratureSources, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strLiteratureSources, 1000, conzx_Text.LiteratureSources);
}
objzx_TextEN.LiteratureSources = strLiteratureSources; //文献来源
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objzx_TextEN.dicFldComparisonOp.ContainsKey(conzx_Text.LiteratureSources) == false)
{
objzx_TextEN.dicFldComparisonOp.Add(conzx_Text.LiteratureSources, strComparisonOp);
}
else
{
objzx_TextEN.dicFldComparisonOp[conzx_Text.LiteratureSources] = strComparisonOp;
}
}
return objzx_TextEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objzx_TextEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clszx_TextEN SetLiteratureLink(this clszx_TextEN objzx_TextEN, string strLiteratureLink, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strLiteratureLink, 1000, conzx_Text.LiteratureLink);
}
objzx_TextEN.LiteratureLink = strLiteratureLink; //文献链接
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objzx_TextEN.dicFldComparisonOp.ContainsKey(conzx_Text.LiteratureLink) == false)
{
objzx_TextEN.dicFldComparisonOp.Add(conzx_Text.LiteratureLink, strComparisonOp);
}
else
{
objzx_TextEN.dicFldComparisonOp[conzx_Text.LiteratureLink] = strComparisonOp;
}
}
return objzx_TextEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objzx_TextEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clszx_TextEN SetUploadfileUrl(this clszx_TextEN objzx_TextEN, string strUploadfileUrl, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUploadfileUrl, 1000, conzx_Text.UploadfileUrl);
}
objzx_TextEN.UploadfileUrl = strUploadfileUrl; //文件地址
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objzx_TextEN.dicFldComparisonOp.ContainsKey(conzx_Text.UploadfileUrl) == false)
{
objzx_TextEN.dicFldComparisonOp.Add(conzx_Text.UploadfileUrl, strComparisonOp);
}
else
{
objzx_TextEN.dicFldComparisonOp[conzx_Text.UploadfileUrl] = strComparisonOp;
}
}
return objzx_TextEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objzx_TextEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clszx_TextEN SetIsSubmit(this clszx_TextEN objzx_TextEN, bool bolIsSubmit, string strComparisonOp="")
	{
objzx_TextEN.IsSubmit = bolIsSubmit; //是否提交
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objzx_TextEN.dicFldComparisonOp.ContainsKey(conzx_Text.IsSubmit) == false)
{
objzx_TextEN.dicFldComparisonOp.Add(conzx_Text.IsSubmit, strComparisonOp);
}
else
{
objzx_TextEN.dicFldComparisonOp[conzx_Text.IsSubmit] = strComparisonOp;
}
}
return objzx_TextEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objzx_TextEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clszx_TextEN SetIsChecked(this clszx_TextEN objzx_TextEN, bool bolIsChecked, string strComparisonOp="")
	{
objzx_TextEN.IsChecked = bolIsChecked; //是否检查
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objzx_TextEN.dicFldComparisonOp.ContainsKey(conzx_Text.IsChecked) == false)
{
objzx_TextEN.dicFldComparisonOp.Add(conzx_Text.IsChecked, strComparisonOp);
}
else
{
objzx_TextEN.dicFldComparisonOp[conzx_Text.IsChecked] = strComparisonOp;
}
}
return objzx_TextEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objzx_TextEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clszx_TextEN SetBrowseNumber(this clszx_TextEN objzx_TextEN, int? intBrowseNumber, string strComparisonOp="")
	{
objzx_TextEN.BrowseNumber = intBrowseNumber; //浏览量
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objzx_TextEN.dicFldComparisonOp.ContainsKey(conzx_Text.BrowseNumber) == false)
{
objzx_TextEN.dicFldComparisonOp.Add(conzx_Text.BrowseNumber, strComparisonOp);
}
else
{
objzx_TextEN.dicFldComparisonOp[conzx_Text.BrowseNumber] = strComparisonOp;
}
}
return objzx_TextEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objzx_TextEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clszx_TextEN SetVCount(this clszx_TextEN objzx_TextEN, int? intVCount, string strComparisonOp="")
	{
objzx_TextEN.VCount = intVCount; //VCount
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objzx_TextEN.dicFldComparisonOp.ContainsKey(conzx_Text.VCount) == false)
{
objzx_TextEN.dicFldComparisonOp.Add(conzx_Text.VCount, strComparisonOp);
}
else
{
objzx_TextEN.dicFldComparisonOp[conzx_Text.VCount] = strComparisonOp;
}
}
return objzx_TextEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objzx_TextEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clszx_TextEN SetVoteCount(this clszx_TextEN objzx_TextEN, int? intVoteCount, string strComparisonOp="")
	{
objzx_TextEN.VoteCount = intVoteCount; //点赞计数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objzx_TextEN.dicFldComparisonOp.ContainsKey(conzx_Text.VoteCount) == false)
{
objzx_TextEN.dicFldComparisonOp.Add(conzx_Text.VoteCount, strComparisonOp);
}
else
{
objzx_TextEN.dicFldComparisonOp[conzx_Text.VoteCount] = strComparisonOp;
}
}
return objzx_TextEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objzx_TextEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clszx_TextEN SetCollectionCount(this clszx_TextEN objzx_TextEN, long? lngCollectionCount, string strComparisonOp="")
	{
objzx_TextEN.CollectionCount = lngCollectionCount; //收藏数量
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objzx_TextEN.dicFldComparisonOp.ContainsKey(conzx_Text.CollectionCount) == false)
{
objzx_TextEN.dicFldComparisonOp.Add(conzx_Text.CollectionCount, strComparisonOp);
}
else
{
objzx_TextEN.dicFldComparisonOp[conzx_Text.CollectionCount] = strComparisonOp;
}
}
return objzx_TextEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objzx_TextEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clszx_TextEN SetDownloadCount(this clszx_TextEN objzx_TextEN, int? intDownloadCount, string strComparisonOp="")
	{
objzx_TextEN.DownloadCount = intDownloadCount; //下载数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objzx_TextEN.dicFldComparisonOp.ContainsKey(conzx_Text.DownloadCount) == false)
{
objzx_TextEN.dicFldComparisonOp.Add(conzx_Text.DownloadCount, strComparisonOp);
}
else
{
objzx_TextEN.dicFldComparisonOp[conzx_Text.DownloadCount] = strComparisonOp;
}
}
return objzx_TextEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objzx_TextEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clszx_TextEN SetAttachmentCount(this clszx_TextEN objzx_TextEN, int? intAttachmentCount, string strComparisonOp="")
	{
objzx_TextEN.AttachmentCount = intAttachmentCount; //附件计数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objzx_TextEN.dicFldComparisonOp.ContainsKey(conzx_Text.AttachmentCount) == false)
{
objzx_TextEN.dicFldComparisonOp.Add(conzx_Text.AttachmentCount, strComparisonOp);
}
else
{
objzx_TextEN.dicFldComparisonOp[conzx_Text.AttachmentCount] = strComparisonOp;
}
}
return objzx_TextEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objzx_TextEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clszx_TextEN SetAppraiseCount(this clszx_TextEN objzx_TextEN, int? intAppraiseCount, string strComparisonOp="")
	{
objzx_TextEN.AppraiseCount = intAppraiseCount; //评论数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objzx_TextEN.dicFldComparisonOp.ContainsKey(conzx_Text.AppraiseCount) == false)
{
objzx_TextEN.dicFldComparisonOp.Add(conzx_Text.AppraiseCount, strComparisonOp);
}
else
{
objzx_TextEN.dicFldComparisonOp[conzx_Text.AppraiseCount] = strComparisonOp;
}
}
return objzx_TextEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objzx_TextEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clszx_TextEN SetScore(this clszx_TextEN objzx_TextEN, float? fltScore, string strComparisonOp="")
	{
objzx_TextEN.Score = fltScore; //评分
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objzx_TextEN.dicFldComparisonOp.ContainsKey(conzx_Text.Score) == false)
{
objzx_TextEN.dicFldComparisonOp.Add(conzx_Text.Score, strComparisonOp);
}
else
{
objzx_TextEN.dicFldComparisonOp[conzx_Text.Score] = strComparisonOp;
}
}
return objzx_TextEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objzx_TextEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clszx_TextEN SetStuScore(this clszx_TextEN objzx_TextEN, float? fltStuScore, string strComparisonOp="")
	{
objzx_TextEN.StuScore = fltStuScore; //学生平均分
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objzx_TextEN.dicFldComparisonOp.ContainsKey(conzx_Text.StuScore) == false)
{
objzx_TextEN.dicFldComparisonOp.Add(conzx_Text.StuScore, strComparisonOp);
}
else
{
objzx_TextEN.dicFldComparisonOp[conzx_Text.StuScore] = strComparisonOp;
}
}
return objzx_TextEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objzx_TextEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clszx_TextEN SetTeaScore(this clszx_TextEN objzx_TextEN, float? fltTeaScore, string strComparisonOp="")
	{
objzx_TextEN.TeaScore = fltTeaScore; //教师评分
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objzx_TextEN.dicFldComparisonOp.ContainsKey(conzx_Text.TeaScore) == false)
{
objzx_TextEN.dicFldComparisonOp.Add(conzx_Text.TeaScore, strComparisonOp);
}
else
{
objzx_TextEN.dicFldComparisonOp[conzx_Text.TeaScore] = strComparisonOp;
}
}
return objzx_TextEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objzx_TextEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clszx_TextEN SetTextTypeId(this clszx_TextEN objzx_TextEN, string strTextTypeId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTextTypeId, 2, conzx_Text.TextTypeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strTextTypeId, 2, conzx_Text.TextTypeId);
}
objzx_TextEN.TextTypeId = strTextTypeId; //TextTypeId
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objzx_TextEN.dicFldComparisonOp.ContainsKey(conzx_Text.TextTypeId) == false)
{
objzx_TextEN.dicFldComparisonOp.Add(conzx_Text.TextTypeId, strComparisonOp);
}
else
{
objzx_TextEN.dicFldComparisonOp[conzx_Text.TextTypeId] = strComparisonOp;
}
}
return objzx_TextEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objzx_TextEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clszx_TextEN SetTextStatusId(this clszx_TextEN objzx_TextEN, string strTextStatusId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTextStatusId, 2, conzx_Text.TextStatusId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strTextStatusId, 2, conzx_Text.TextStatusId);
}
objzx_TextEN.TextStatusId = strTextStatusId; //TextStatusId
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objzx_TextEN.dicFldComparisonOp.ContainsKey(conzx_Text.TextStatusId) == false)
{
objzx_TextEN.dicFldComparisonOp.Add(conzx_Text.TextStatusId, strComparisonOp);
}
else
{
objzx_TextEN.dicFldComparisonOp[conzx_Text.TextStatusId] = strComparisonOp;
}
}
return objzx_TextEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objzx_TextEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clszx_TextEN SetVersionCount(this clszx_TextEN objzx_TextEN, int? intVersionCount, string strComparisonOp="")
	{
objzx_TextEN.VersionCount = intVersionCount; //版本统计
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objzx_TextEN.dicFldComparisonOp.ContainsKey(conzx_Text.VersionCount) == false)
{
objzx_TextEN.dicFldComparisonOp.Add(conzx_Text.VersionCount, strComparisonOp);
}
else
{
objzx_TextEN.dicFldComparisonOp[conzx_Text.VersionCount] = strComparisonOp;
}
}
return objzx_TextEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objzx_TextEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clszx_TextEN SetIsPublic(this clszx_TextEN objzx_TextEN, bool bolIsPublic, string strComparisonOp="")
	{
objzx_TextEN.IsPublic = bolIsPublic; //是否公开
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objzx_TextEN.dicFldComparisonOp.ContainsKey(conzx_Text.IsPublic) == false)
{
objzx_TextEN.dicFldComparisonOp.Add(conzx_Text.IsPublic, strComparisonOp);
}
else
{
objzx_TextEN.dicFldComparisonOp[conzx_Text.IsPublic] = strComparisonOp;
}
}
return objzx_TextEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objzx_TextEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clszx_TextEN SetzxShareId(this clszx_TextEN objzx_TextEN, string strzxShareId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strzxShareId, 2, conzx_Text.zxShareId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strzxShareId, 2, conzx_Text.zxShareId);
}
objzx_TextEN.zxShareId = strzxShareId; //分享Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objzx_TextEN.dicFldComparisonOp.ContainsKey(conzx_Text.zxShareId) == false)
{
objzx_TextEN.dicFldComparisonOp.Add(conzx_Text.zxShareId, strComparisonOp);
}
else
{
objzx_TextEN.dicFldComparisonOp[conzx_Text.zxShareId] = strComparisonOp;
}
}
return objzx_TextEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objzx_TextEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clszx_TextEN SetSchoolTerm(this clszx_TextEN objzx_TextEN, string strSchoolTerm, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strSchoolTerm, 1, conzx_Text.SchoolTerm);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strSchoolTerm, 1, conzx_Text.SchoolTerm);
}
objzx_TextEN.SchoolTerm = strSchoolTerm; //学期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objzx_TextEN.dicFldComparisonOp.ContainsKey(conzx_Text.SchoolTerm) == false)
{
objzx_TextEN.dicFldComparisonOp.Add(conzx_Text.SchoolTerm, strComparisonOp);
}
else
{
objzx_TextEN.dicFldComparisonOp[conzx_Text.SchoolTerm] = strComparisonOp;
}
}
return objzx_TextEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objzx_TextEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clszx_TextEN SetGradeId(this clszx_TextEN objzx_TextEN, string strGradeId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strGradeId, 4, conzx_Text.GradeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strGradeId, 4, conzx_Text.GradeId);
}
objzx_TextEN.GradeId = strGradeId; //年级代号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objzx_TextEN.dicFldComparisonOp.ContainsKey(conzx_Text.GradeId) == false)
{
objzx_TextEN.dicFldComparisonOp.Add(conzx_Text.GradeId, strComparisonOp);
}
else
{
objzx_TextEN.dicFldComparisonOp[conzx_Text.GradeId] = strComparisonOp;
}
}
return objzx_TextEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objzx_TextEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clszx_TextEN SetMemo(this clszx_TextEN objzx_TextEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, conzx_Text.Memo);
}
objzx_TextEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objzx_TextEN.dicFldComparisonOp.ContainsKey(conzx_Text.Memo) == false)
{
objzx_TextEN.dicFldComparisonOp.Add(conzx_Text.Memo, strComparisonOp);
}
else
{
objzx_TextEN.dicFldComparisonOp[conzx_Text.Memo] = strComparisonOp;
}
}
return objzx_TextEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objzx_TextEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clszx_TextEN SetUnitId(this clszx_TextEN objzx_TextEN, string strUnitId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUnitId, 4, conzx_Text.UnitId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strUnitId, 4, conzx_Text.UnitId);
}
objzx_TextEN.UnitId = strUnitId; //UnitId
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objzx_TextEN.dicFldComparisonOp.ContainsKey(conzx_Text.UnitId) == false)
{
objzx_TextEN.dicFldComparisonOp.Add(conzx_Text.UnitId, strComparisonOp);
}
else
{
objzx_TextEN.dicFldComparisonOp[conzx_Text.UnitId] = strComparisonOp;
}
}
return objzx_TextEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objzx_TextEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clszx_TextEN SetPaperQCount(this clszx_TextEN objzx_TextEN, int? intPaperQCount, string strComparisonOp="")
	{
objzx_TextEN.PaperQCount = intPaperQCount; //论文答疑数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objzx_TextEN.dicFldComparisonOp.ContainsKey(conzx_Text.PaperQCount) == false)
{
objzx_TextEN.dicFldComparisonOp.Add(conzx_Text.PaperQCount, strComparisonOp);
}
else
{
objzx_TextEN.dicFldComparisonOp[conzx_Text.PaperQCount] = strComparisonOp;
}
}
return objzx_TextEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objzx_TextEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clszx_TextEN SetSubVCount(this clszx_TextEN objzx_TextEN, int? intSubVCount, string strComparisonOp="")
	{
objzx_TextEN.SubVCount = intSubVCount; //论文子观点数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objzx_TextEN.dicFldComparisonOp.ContainsKey(conzx_Text.SubVCount) == false)
{
objzx_TextEN.dicFldComparisonOp.Add(conzx_Text.SubVCount, strComparisonOp);
}
else
{
objzx_TextEN.dicFldComparisonOp[conzx_Text.SubVCount] = strComparisonOp;
}
}
return objzx_TextEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objzx_TextEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clszx_TextEN SetTagsCount(this clszx_TextEN objzx_TextEN, int? intTagsCount, string strComparisonOp="")
	{
objzx_TextEN.TagsCount = intTagsCount; //论文标注数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objzx_TextEN.dicFldComparisonOp.ContainsKey(conzx_Text.TagsCount) == false)
{
objzx_TextEN.dicFldComparisonOp.Add(conzx_Text.TagsCount, strComparisonOp);
}
else
{
objzx_TextEN.dicFldComparisonOp[conzx_Text.TagsCount] = strComparisonOp;
}
}
return objzx_TextEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objzx_TextEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clszx_TextEN SetTeaQCount(this clszx_TextEN objzx_TextEN, int? intTeaQCount, string strComparisonOp="")
	{
objzx_TextEN.TeaQCount = intTeaQCount; //教师提问数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objzx_TextEN.dicFldComparisonOp.ContainsKey(conzx_Text.TeaQCount) == false)
{
objzx_TextEN.dicFldComparisonOp.Add(conzx_Text.TeaQCount, strComparisonOp);
}
else
{
objzx_TextEN.dicFldComparisonOp[conzx_Text.TeaQCount] = strComparisonOp;
}
}
return objzx_TextEN;
	}

 /// <summary>
 /// 修改记录存盘到数据表中
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_UpdateRecordEx)
 /// </summary>
 /// <param name = "objzx_TextEN">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool UpdateRecordEx(this clszx_TextEN objzx_TextEN)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
try
{
//1、检查传进去的对象属性是否合法
objzx_TextEN.CheckPropertyNew();
clszx_TextEN objzx_TextCond = new clszx_TextEN();
string strCondition = objzx_TextCond
.SetTextId(objzx_TextEN.TextId, "<>")
.SetIdCurrEduCls(objzx_TextEN.IdCurrEduCls, "=")
.GetCombineCondition();
objzx_TextEN._IsCheckProperty = true;
bool bolIsExist = clszx_TextBL.IsExistRecord(strCondition);
if (bolIsExist)
{
strMsg = "(id_CurrEduCls)不能重复!";
throw new Exception(strMsg);
}
//4、把数据实体层的数据存贮到数据库中
objzx_TextEN.Update();
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
 /// <param name = "objzx_Text">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool EditRecordEx(this clszx_TextEN objzx_Text)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
clszx_TextEN objzx_TextCond = new clszx_TextEN();
string strCondition = objzx_TextCond
.SetIdCurrEduCls(objzx_Text.IdCurrEduCls, "=")
.GetCombineCondition();
objzx_Text._IsCheckProperty = true;
bool bolIsExist = clszx_TextBL.IsExistRecord(strCondition);
if (bolIsExist)
{
objzx_Text.TextId = clszx_TextBL.GetFirstID_S(strCondition);
objzx_Text.UpdateWithCondition(strCondition);
}
else
{
objzx_Text.TextId = clszx_TextBL.GetMaxStrId_S();
objzx_Text.AddNewRecord();
}
return true; 
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_Update)
 /// </summary>
 /// <param name = "objzx_TextEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clszx_TextEN objzx_TextEN)
{
 if (string.IsNullOrEmpty(objzx_TextEN.TextId) == true)
 {
string strMsg = string.Format("(errid:Busi000095)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clszx_TextBL.zx_TextDA.UpdateBySql2(objzx_TextEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clszx_TextBL.ReFreshCache(objzx_TextEN.IdCurrEduCls);

if (clszx_TextBL.relatedActions != null)
{
clszx_TextBL.relatedActions.UpdRelaTabDate(objzx_TextEN.TextId, "SetUpdDate");
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
 /// <param name = "objzx_TextEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clszx_TextEN objzx_TextEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (string.IsNullOrEmpty(objzx_TextEN.TextId) == true)
 {
string strMsg = string.Format("(errid:Busi000087)修改记录时关键字不能为空!(带事务处理)(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clszx_TextBL.zx_TextDA.UpdateBySql2(objzx_TextEN, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clszx_TextBL.ReFreshCache(objzx_TextEN.IdCurrEduCls);

if (clszx_TextBL.relatedActions != null)
{
clszx_TextBL.relatedActions.UpdRelaTabDate(objzx_TextEN.TextId, "SetUpdDate");
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
 /// <param name = "objzx_TextEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clszx_TextEN objzx_TextEN, string strWhereCond)
{
try
{
bool bolResult = clszx_TextBL.zx_TextDA.UpdateBySqlWithCondition(objzx_TextEN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clszx_TextBL.ReFreshCache(objzx_TextEN.IdCurrEduCls);

if (clszx_TextBL.relatedActions != null)
{
clszx_TextBL.relatedActions.UpdRelaTabDate(objzx_TextEN.TextId, "SetUpdDate");
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
 /// <param name = "objzx_TextEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clszx_TextEN objzx_TextEN, string strWhereCond, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
bool bolResult = clszx_TextBL.zx_TextDA.UpdateBySqlWithConditionTransaction(objzx_TextEN, strWhereCond, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clszx_TextBL.ReFreshCache(objzx_TextEN.IdCurrEduCls);

if (clszx_TextBL.relatedActions != null)
{
clszx_TextBL.relatedActions.UpdRelaTabDate(objzx_TextEN.TextId, "SetUpdDate");
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
 /// <param name = "strTextId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int Delete(this clszx_TextEN objzx_TextEN)
{
try
{
int intRecNum = clszx_TextBL.zx_TextDA.DelRecord(objzx_TextEN.TextId);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clszx_TextBL.ReFreshCache(objzx_TextEN.IdCurrEduCls);

if (clszx_TextBL.relatedActions != null)
{
clszx_TextBL.relatedActions.UpdRelaTabDate(objzx_TextEN.TextId, "SetUpdDate");
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
 /// <param name = "objzx_TextENS">源对象</param>
 /// <param name = "objzx_TextENT">目标对象</param>
 public static void CopyTo(this clszx_TextEN objzx_TextENS, clszx_TextEN objzx_TextENT)
{
try
{
objzx_TextENT.TextId = objzx_TextENS.TextId; //课件Id
objzx_TextENT.TextTitle = objzx_TextENS.TextTitle; //TextTitle
objzx_TextENT.TextContent = objzx_TextENS.TextContent; //TextContent
objzx_TextENT.Edition = objzx_TextENS.Edition; //Edition
objzx_TextENT.Author = objzx_TextENS.Author; //作者
objzx_TextENT.ResearchQuestion = objzx_TextENS.ResearchQuestion; //研究问题
objzx_TextENT.UpdDate = objzx_TextENS.UpdDate; //修改日期
objzx_TextENT.UpdUser = objzx_TextENS.UpdUser; //修改人
objzx_TextENT.CreateDate = objzx_TextENS.CreateDate; //建立日期
objzx_TextENT.Checker = objzx_TextENS.Checker; //审核人
objzx_TextENT.IdCurrEduCls = objzx_TextENS.IdCurrEduCls; //教学班流水号
objzx_TextENT.Keyword = objzx_TextENS.Keyword; //关键字
objzx_TextENT.LiteratureSources = objzx_TextENS.LiteratureSources; //文献来源
objzx_TextENT.LiteratureLink = objzx_TextENS.LiteratureLink; //文献链接
objzx_TextENT.UploadfileUrl = objzx_TextENS.UploadfileUrl; //文件地址
objzx_TextENT.IsSubmit = objzx_TextENS.IsSubmit; //是否提交
objzx_TextENT.IsChecked = objzx_TextENS.IsChecked; //是否检查
objzx_TextENT.BrowseNumber = objzx_TextENS.BrowseNumber; //浏览量
objzx_TextENT.VCount = objzx_TextENS.VCount; //VCount
objzx_TextENT.VoteCount = objzx_TextENS.VoteCount; //点赞计数
objzx_TextENT.CollectionCount = objzx_TextENS.CollectionCount; //收藏数量
objzx_TextENT.DownloadCount = objzx_TextENS.DownloadCount; //下载数
objzx_TextENT.AttachmentCount = objzx_TextENS.AttachmentCount; //附件计数
objzx_TextENT.AppraiseCount = objzx_TextENS.AppraiseCount; //评论数
objzx_TextENT.Score = objzx_TextENS.Score; //评分
objzx_TextENT.StuScore = objzx_TextENS.StuScore; //学生平均分
objzx_TextENT.TeaScore = objzx_TextENS.TeaScore; //教师评分
objzx_TextENT.TextTypeId = objzx_TextENS.TextTypeId; //TextTypeId
objzx_TextENT.TextStatusId = objzx_TextENS.TextStatusId; //TextStatusId
objzx_TextENT.VersionCount = objzx_TextENS.VersionCount; //版本统计
objzx_TextENT.IsPublic = objzx_TextENS.IsPublic; //是否公开
objzx_TextENT.zxShareId = objzx_TextENS.zxShareId; //分享Id
objzx_TextENT.SchoolTerm = objzx_TextENS.SchoolTerm; //学期
objzx_TextENT.GradeId = objzx_TextENS.GradeId; //年级代号
objzx_TextENT.Memo = objzx_TextENS.Memo; //备注
objzx_TextENT.UnitId = objzx_TextENS.UnitId; //UnitId
objzx_TextENT.PaperQCount = objzx_TextENS.PaperQCount; //论文答疑数
objzx_TextENT.SubVCount = objzx_TextENS.SubVCount; //论文子观点数
objzx_TextENT.TagsCount = objzx_TextENS.TagsCount; //论文标注数
objzx_TextENT.TeaQCount = objzx_TextENS.TeaQCount; //教师提问数
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
 /// <param name = "objzx_TextENS">源对象</param>
 /// <returns>目标对象=>clszx_TextEN:objzx_TextENT</returns>
 public static clszx_TextEN CopyTo(this clszx_TextEN objzx_TextENS)
{
try
{
 clszx_TextEN objzx_TextENT = new clszx_TextEN()
{
TextId = objzx_TextENS.TextId, //课件Id
TextTitle = objzx_TextENS.TextTitle, //TextTitle
TextContent = objzx_TextENS.TextContent, //TextContent
Edition = objzx_TextENS.Edition, //Edition
Author = objzx_TextENS.Author, //作者
ResearchQuestion = objzx_TextENS.ResearchQuestion, //研究问题
UpdDate = objzx_TextENS.UpdDate, //修改日期
UpdUser = objzx_TextENS.UpdUser, //修改人
CreateDate = objzx_TextENS.CreateDate, //建立日期
Checker = objzx_TextENS.Checker, //审核人
IdCurrEduCls = objzx_TextENS.IdCurrEduCls, //教学班流水号
Keyword = objzx_TextENS.Keyword, //关键字
LiteratureSources = objzx_TextENS.LiteratureSources, //文献来源
LiteratureLink = objzx_TextENS.LiteratureLink, //文献链接
UploadfileUrl = objzx_TextENS.UploadfileUrl, //文件地址
IsSubmit = objzx_TextENS.IsSubmit, //是否提交
IsChecked = objzx_TextENS.IsChecked, //是否检查
BrowseNumber = objzx_TextENS.BrowseNumber, //浏览量
VCount = objzx_TextENS.VCount, //VCount
VoteCount = objzx_TextENS.VoteCount, //点赞计数
CollectionCount = objzx_TextENS.CollectionCount, //收藏数量
DownloadCount = objzx_TextENS.DownloadCount, //下载数
AttachmentCount = objzx_TextENS.AttachmentCount, //附件计数
AppraiseCount = objzx_TextENS.AppraiseCount, //评论数
Score = objzx_TextENS.Score, //评分
StuScore = objzx_TextENS.StuScore, //学生平均分
TeaScore = objzx_TextENS.TeaScore, //教师评分
TextTypeId = objzx_TextENS.TextTypeId, //TextTypeId
TextStatusId = objzx_TextENS.TextStatusId, //TextStatusId
VersionCount = objzx_TextENS.VersionCount, //版本统计
IsPublic = objzx_TextENS.IsPublic, //是否公开
zxShareId = objzx_TextENS.zxShareId, //分享Id
SchoolTerm = objzx_TextENS.SchoolTerm, //学期
GradeId = objzx_TextENS.GradeId, //年级代号
Memo = objzx_TextENS.Memo, //备注
UnitId = objzx_TextENS.UnitId, //UnitId
PaperQCount = objzx_TextENS.PaperQCount, //论文答疑数
SubVCount = objzx_TextENS.SubVCount, //论文子观点数
TagsCount = objzx_TextENS.TagsCount, //论文标注数
TeaQCount = objzx_TextENS.TeaQCount, //教师提问数
};
 return objzx_TextENT;
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
public static void CheckPropertyNew(this clszx_TextEN objzx_TextEN)
{
 clszx_TextBL.zx_TextDA.CheckPropertyNew(objzx_TextEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(this clszx_TextEN objzx_TextEN)
{
 clszx_TextBL.zx_TextDA.CheckProperty4Condition(objzx_TextEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clszx_TextEN objzx_TextCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objzx_TextCond.IsUpdated(conzx_Text.TextId) == true)
{
string strComparisonOpTextId = objzx_TextCond.dicFldComparisonOp[conzx_Text.TextId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conzx_Text.TextId, objzx_TextCond.TextId, strComparisonOpTextId);
}
if (objzx_TextCond.IsUpdated(conzx_Text.TextTitle) == true)
{
string strComparisonOpTextTitle = objzx_TextCond.dicFldComparisonOp[conzx_Text.TextTitle];
strWhereCond += string.Format(" And {0} {2} '{1}'", conzx_Text.TextTitle, objzx_TextCond.TextTitle, strComparisonOpTextTitle);
}
//数据类型string(text)在函数:[AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj]中没有处理!
if (objzx_TextCond.IsUpdated(conzx_Text.Edition) == true)
{
string strComparisonOpEdition = objzx_TextCond.dicFldComparisonOp[conzx_Text.Edition];
strWhereCond += string.Format(" And {0} {2} '{1}'", conzx_Text.Edition, objzx_TextCond.Edition, strComparisonOpEdition);
}
if (objzx_TextCond.IsUpdated(conzx_Text.Author) == true)
{
string strComparisonOpAuthor = objzx_TextCond.dicFldComparisonOp[conzx_Text.Author];
strWhereCond += string.Format(" And {0} {2} '{1}'", conzx_Text.Author, objzx_TextCond.Author, strComparisonOpAuthor);
}
if (objzx_TextCond.IsUpdated(conzx_Text.ResearchQuestion) == true)
{
string strComparisonOpResearchQuestion = objzx_TextCond.dicFldComparisonOp[conzx_Text.ResearchQuestion];
strWhereCond += string.Format(" And {0} {2} '{1}'", conzx_Text.ResearchQuestion, objzx_TextCond.ResearchQuestion, strComparisonOpResearchQuestion);
}
if (objzx_TextCond.IsUpdated(conzx_Text.UpdDate) == true)
{
string strComparisonOpUpdDate = objzx_TextCond.dicFldComparisonOp[conzx_Text.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conzx_Text.UpdDate, objzx_TextCond.UpdDate, strComparisonOpUpdDate);
}
if (objzx_TextCond.IsUpdated(conzx_Text.UpdUser) == true)
{
string strComparisonOpUpdUser = objzx_TextCond.dicFldComparisonOp[conzx_Text.UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", conzx_Text.UpdUser, objzx_TextCond.UpdUser, strComparisonOpUpdUser);
}
if (objzx_TextCond.IsUpdated(conzx_Text.CreateDate) == true)
{
string strComparisonOpCreateDate = objzx_TextCond.dicFldComparisonOp[conzx_Text.CreateDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conzx_Text.CreateDate, objzx_TextCond.CreateDate, strComparisonOpCreateDate);
}
if (objzx_TextCond.IsUpdated(conzx_Text.Checker) == true)
{
string strComparisonOpChecker = objzx_TextCond.dicFldComparisonOp[conzx_Text.Checker];
strWhereCond += string.Format(" And {0} {2} '{1}'", conzx_Text.Checker, objzx_TextCond.Checker, strComparisonOpChecker);
}
if (objzx_TextCond.IsUpdated(conzx_Text.IdCurrEduCls) == true)
{
string strComparisonOpIdCurrEduCls = objzx_TextCond.dicFldComparisonOp[conzx_Text.IdCurrEduCls];
strWhereCond += string.Format(" And {0} {2} '{1}'", conzx_Text.IdCurrEduCls, objzx_TextCond.IdCurrEduCls, strComparisonOpIdCurrEduCls);
}
if (objzx_TextCond.IsUpdated(conzx_Text.Keyword) == true)
{
string strComparisonOpKeyword = objzx_TextCond.dicFldComparisonOp[conzx_Text.Keyword];
strWhereCond += string.Format(" And {0} {2} '{1}'", conzx_Text.Keyword, objzx_TextCond.Keyword, strComparisonOpKeyword);
}
if (objzx_TextCond.IsUpdated(conzx_Text.LiteratureSources) == true)
{
string strComparisonOpLiteratureSources = objzx_TextCond.dicFldComparisonOp[conzx_Text.LiteratureSources];
strWhereCond += string.Format(" And {0} {2} '{1}'", conzx_Text.LiteratureSources, objzx_TextCond.LiteratureSources, strComparisonOpLiteratureSources);
}
if (objzx_TextCond.IsUpdated(conzx_Text.LiteratureLink) == true)
{
string strComparisonOpLiteratureLink = objzx_TextCond.dicFldComparisonOp[conzx_Text.LiteratureLink];
strWhereCond += string.Format(" And {0} {2} '{1}'", conzx_Text.LiteratureLink, objzx_TextCond.LiteratureLink, strComparisonOpLiteratureLink);
}
if (objzx_TextCond.IsUpdated(conzx_Text.UploadfileUrl) == true)
{
string strComparisonOpUploadfileUrl = objzx_TextCond.dicFldComparisonOp[conzx_Text.UploadfileUrl];
strWhereCond += string.Format(" And {0} {2} '{1}'", conzx_Text.UploadfileUrl, objzx_TextCond.UploadfileUrl, strComparisonOpUploadfileUrl);
}
if (objzx_TextCond.IsUpdated(conzx_Text.IsSubmit) == true)
{
if (objzx_TextCond.IsSubmit == true)
{
strWhereCond += string.Format(" And {0} = '1'", conzx_Text.IsSubmit);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conzx_Text.IsSubmit);
}
}
if (objzx_TextCond.IsUpdated(conzx_Text.IsChecked) == true)
{
if (objzx_TextCond.IsChecked == true)
{
strWhereCond += string.Format(" And {0} = '1'", conzx_Text.IsChecked);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conzx_Text.IsChecked);
}
}
if (objzx_TextCond.IsUpdated(conzx_Text.BrowseNumber) == true)
{
string strComparisonOpBrowseNumber = objzx_TextCond.dicFldComparisonOp[conzx_Text.BrowseNumber];
strWhereCond += string.Format(" And {0} {2} {1}", conzx_Text.BrowseNumber, objzx_TextCond.BrowseNumber, strComparisonOpBrowseNumber);
}
if (objzx_TextCond.IsUpdated(conzx_Text.VCount) == true)
{
string strComparisonOpVCount = objzx_TextCond.dicFldComparisonOp[conzx_Text.VCount];
strWhereCond += string.Format(" And {0} {2} {1}", conzx_Text.VCount, objzx_TextCond.VCount, strComparisonOpVCount);
}
if (objzx_TextCond.IsUpdated(conzx_Text.VoteCount) == true)
{
string strComparisonOpVoteCount = objzx_TextCond.dicFldComparisonOp[conzx_Text.VoteCount];
strWhereCond += string.Format(" And {0} {2} {1}", conzx_Text.VoteCount, objzx_TextCond.VoteCount, strComparisonOpVoteCount);
}
if (objzx_TextCond.IsUpdated(conzx_Text.CollectionCount) == true)
{
string strComparisonOpCollectionCount = objzx_TextCond.dicFldComparisonOp[conzx_Text.CollectionCount];
strWhereCond += string.Format(" And {0} {2} {1}", conzx_Text.CollectionCount, objzx_TextCond.CollectionCount, strComparisonOpCollectionCount);
}
if (objzx_TextCond.IsUpdated(conzx_Text.DownloadCount) == true)
{
string strComparisonOpDownloadCount = objzx_TextCond.dicFldComparisonOp[conzx_Text.DownloadCount];
strWhereCond += string.Format(" And {0} {2} {1}", conzx_Text.DownloadCount, objzx_TextCond.DownloadCount, strComparisonOpDownloadCount);
}
if (objzx_TextCond.IsUpdated(conzx_Text.AttachmentCount) == true)
{
string strComparisonOpAttachmentCount = objzx_TextCond.dicFldComparisonOp[conzx_Text.AttachmentCount];
strWhereCond += string.Format(" And {0} {2} {1}", conzx_Text.AttachmentCount, objzx_TextCond.AttachmentCount, strComparisonOpAttachmentCount);
}
if (objzx_TextCond.IsUpdated(conzx_Text.AppraiseCount) == true)
{
string strComparisonOpAppraiseCount = objzx_TextCond.dicFldComparisonOp[conzx_Text.AppraiseCount];
strWhereCond += string.Format(" And {0} {2} {1}", conzx_Text.AppraiseCount, objzx_TextCond.AppraiseCount, strComparisonOpAppraiseCount);
}
if (objzx_TextCond.IsUpdated(conzx_Text.Score) == true)
{
string strComparisonOpScore = objzx_TextCond.dicFldComparisonOp[conzx_Text.Score];
strWhereCond += string.Format(" And {0} {2} {1}", conzx_Text.Score, objzx_TextCond.Score, strComparisonOpScore);
}
if (objzx_TextCond.IsUpdated(conzx_Text.StuScore) == true)
{
string strComparisonOpStuScore = objzx_TextCond.dicFldComparisonOp[conzx_Text.StuScore];
strWhereCond += string.Format(" And {0} {2} {1}", conzx_Text.StuScore, objzx_TextCond.StuScore, strComparisonOpStuScore);
}
if (objzx_TextCond.IsUpdated(conzx_Text.TeaScore) == true)
{
string strComparisonOpTeaScore = objzx_TextCond.dicFldComparisonOp[conzx_Text.TeaScore];
strWhereCond += string.Format(" And {0} {2} {1}", conzx_Text.TeaScore, objzx_TextCond.TeaScore, strComparisonOpTeaScore);
}
if (objzx_TextCond.IsUpdated(conzx_Text.TextTypeId) == true)
{
string strComparisonOpTextTypeId = objzx_TextCond.dicFldComparisonOp[conzx_Text.TextTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conzx_Text.TextTypeId, objzx_TextCond.TextTypeId, strComparisonOpTextTypeId);
}
if (objzx_TextCond.IsUpdated(conzx_Text.TextStatusId) == true)
{
string strComparisonOpTextStatusId = objzx_TextCond.dicFldComparisonOp[conzx_Text.TextStatusId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conzx_Text.TextStatusId, objzx_TextCond.TextStatusId, strComparisonOpTextStatusId);
}
if (objzx_TextCond.IsUpdated(conzx_Text.VersionCount) == true)
{
string strComparisonOpVersionCount = objzx_TextCond.dicFldComparisonOp[conzx_Text.VersionCount];
strWhereCond += string.Format(" And {0} {2} {1}", conzx_Text.VersionCount, objzx_TextCond.VersionCount, strComparisonOpVersionCount);
}
if (objzx_TextCond.IsUpdated(conzx_Text.IsPublic) == true)
{
if (objzx_TextCond.IsPublic == true)
{
strWhereCond += string.Format(" And {0} = '1'", conzx_Text.IsPublic);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conzx_Text.IsPublic);
}
}
if (objzx_TextCond.IsUpdated(conzx_Text.zxShareId) == true)
{
string strComparisonOpzxShareId = objzx_TextCond.dicFldComparisonOp[conzx_Text.zxShareId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conzx_Text.zxShareId, objzx_TextCond.zxShareId, strComparisonOpzxShareId);
}
if (objzx_TextCond.IsUpdated(conzx_Text.SchoolTerm) == true)
{
string strComparisonOpSchoolTerm = objzx_TextCond.dicFldComparisonOp[conzx_Text.SchoolTerm];
strWhereCond += string.Format(" And {0} {2} '{1}'", conzx_Text.SchoolTerm, objzx_TextCond.SchoolTerm, strComparisonOpSchoolTerm);
}
if (objzx_TextCond.IsUpdated(conzx_Text.GradeId) == true)
{
string strComparisonOpGradeId = objzx_TextCond.dicFldComparisonOp[conzx_Text.GradeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conzx_Text.GradeId, objzx_TextCond.GradeId, strComparisonOpGradeId);
}
if (objzx_TextCond.IsUpdated(conzx_Text.Memo) == true)
{
string strComparisonOpMemo = objzx_TextCond.dicFldComparisonOp[conzx_Text.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", conzx_Text.Memo, objzx_TextCond.Memo, strComparisonOpMemo);
}
if (objzx_TextCond.IsUpdated(conzx_Text.UnitId) == true)
{
string strComparisonOpUnitId = objzx_TextCond.dicFldComparisonOp[conzx_Text.UnitId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conzx_Text.UnitId, objzx_TextCond.UnitId, strComparisonOpUnitId);
}
if (objzx_TextCond.IsUpdated(conzx_Text.PaperQCount) == true)
{
string strComparisonOpPaperQCount = objzx_TextCond.dicFldComparisonOp[conzx_Text.PaperQCount];
strWhereCond += string.Format(" And {0} {2} {1}", conzx_Text.PaperQCount, objzx_TextCond.PaperQCount, strComparisonOpPaperQCount);
}
if (objzx_TextCond.IsUpdated(conzx_Text.SubVCount) == true)
{
string strComparisonOpSubVCount = objzx_TextCond.dicFldComparisonOp[conzx_Text.SubVCount];
strWhereCond += string.Format(" And {0} {2} {1}", conzx_Text.SubVCount, objzx_TextCond.SubVCount, strComparisonOpSubVCount);
}
if (objzx_TextCond.IsUpdated(conzx_Text.TagsCount) == true)
{
string strComparisonOpTagsCount = objzx_TextCond.dicFldComparisonOp[conzx_Text.TagsCount];
strWhereCond += string.Format(" And {0} {2} {1}", conzx_Text.TagsCount, objzx_TextCond.TagsCount, strComparisonOpTagsCount);
}
if (objzx_TextCond.IsUpdated(conzx_Text.TeaQCount) == true)
{
string strComparisonOpTeaQCount = objzx_TextCond.dicFldComparisonOp[conzx_Text.TeaQCount];
strWhereCond += string.Format(" And {0} {2} {1}", conzx_Text.TeaQCount, objzx_TextCond.TeaQCount, strComparisonOpTeaQCount);
}
 return strWhereCond;
}

 /// <summary>
 /// 检查唯一性(Uniqueness)--zx_Text(中学课件表), 如果不唯一,即存在相同的记录,就返回False
 /// 唯一性条件:id_CurrEduCls
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckConstraint)
 /// </summary>
 /// <param name = "objzx_TextEN">要求唯一的对象</param>
 /// <returns></returns>
public static bool CheckUniqueness(this clszx_TextEN objzx_TextEN)
{
//检测记录是否存在
bool bolIsUniqueness;
StringBuilder sbCondition = new StringBuilder();
if (objzx_TextEN == null) return true;
if (objzx_TextEN.TextId == null || objzx_TextEN.TextId == "")
{
sbCondition.AppendFormat("1 = 1");
 if (objzx_TextEN.IdCurrEduCls == null)
{
 sbCondition.AppendFormat(" and IdCurrEduCls is null", objzx_TextEN.IdCurrEduCls);
}
else
{
 sbCondition.AppendFormat(" and IdCurrEduCls = '{0}'", objzx_TextEN.IdCurrEduCls);
}
if (clszx_TextBL.IsExistRecord(sbCondition.ToString())  ==  true)
{
 bolIsUniqueness = false;
}
else
{
 bolIsUniqueness = true;
}
}
 else {
sbCondition.AppendFormat("TextId !=  '{0}'", objzx_TextEN.TextId);
 sbCondition.AppendFormat(" and IdCurrEduCls = '{0}'", objzx_TextEN.IdCurrEduCls);
if (clszx_TextBL.IsExistRecord(sbCondition.ToString())  ==  true)
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
 /// 获取唯一性条件串--zx_Text(中学课件表), 即由对象中唯一性条件字段关键字与值组成的条件串
 /// 唯一性条件:id_CurrEduCls
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetConditionString4Constraint)
 /// </summary>
 /// <param name = "objzx_TextEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(this clszx_TextEN objzx_TextEN)
{
//检测记录是否存在
StringBuilder sbCondition = new StringBuilder();
if (objzx_TextEN == null) return "";
if (objzx_TextEN.TextId == null || objzx_TextEN.TextId == "")
{
sbCondition.AppendFormat("1 = 1");
 if (objzx_TextEN.IdCurrEduCls == null)
{
 sbCondition.AppendFormat(" and IdCurrEduCls is null", objzx_TextEN.IdCurrEduCls);
}
else
{
 sbCondition.AppendFormat(" and IdCurrEduCls = '{0}'", objzx_TextEN.IdCurrEduCls);
}
return sbCondition.ToString();
}
 else {
sbCondition.AppendFormat("TextId !=  '{0}'", objzx_TextEN.TextId);
 sbCondition.AppendFormat(" and IdCurrEduCls = '{0}'", objzx_TextEN.IdCurrEduCls);
 return sbCondition.ToString();
}
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_zx_Text
{
public virtual bool UpdRelaTabDate(string strTextId, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// 中学课件表(zx_Text)
 /// 数据源类型:表
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clszx_TextBL
{
public static RelatedActions_zx_Text relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clszx_TextDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clszx_TextDA zx_TextDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clszx_TextDA();
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
 public clszx_TextBL()
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
if (string.IsNullOrEmpty(clszx_TextEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clszx_TextEN._ConnectString);
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
public static DataTable GetDataTable_zx_Text(string strWhereCond)
{
DataTable objDT;
try
{
objDT = zx_TextDA.GetDataTable_zx_Text(strWhereCond);
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
objDT = zx_TextDA.GetDataTable(strWhereCond);
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
objDT = zx_TextDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = zx_TextDA.GetDataTable(strWhereCond, strTabName);
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
objDT = zx_TextDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = zx_TextDA.GetDataTable_Top(objTopPara);
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
objDT = zx_TextDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = zx_TextDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = zx_TextDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
 /// <param name = "arrTextIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static List<clszx_TextEN> GetObjLstByTextIdLst(List<string> arrTextIdLst)
{
List<clszx_TextEN> arrObjLst = new List<clszx_TextEN>(); 
System.Data.DataTable objDT; 
 string strSqlConditionStr = clsArray.GetSqlInStrByArray(arrTextIdLst, true);
 string strWhereCond = string.Format("TextId in ({0})", strSqlConditionStr);
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clszx_TextEN objzx_TextEN = new clszx_TextEN();
try
{
objzx_TextEN.TextId = objRow[conzx_Text.TextId].ToString().Trim(); //课件Id
objzx_TextEN.TextTitle = objRow[conzx_Text.TextTitle].ToString().Trim(); //TextTitle
objzx_TextEN.TextContent = objRow[conzx_Text.TextContent] == DBNull.Value ? null : objRow[conzx_Text.TextContent].ToString().Trim(); //TextContent
objzx_TextEN.Edition = objRow[conzx_Text.Edition] == DBNull.Value ? null : objRow[conzx_Text.Edition].ToString().Trim(); //Edition
objzx_TextEN.Author = objRow[conzx_Text.Author] == DBNull.Value ? null : objRow[conzx_Text.Author].ToString().Trim(); //作者
objzx_TextEN.ResearchQuestion = objRow[conzx_Text.ResearchQuestion] == DBNull.Value ? null : objRow[conzx_Text.ResearchQuestion].ToString().Trim(); //研究问题
objzx_TextEN.UpdDate = objRow[conzx_Text.UpdDate] == DBNull.Value ? null : objRow[conzx_Text.UpdDate].ToString().Trim(); //修改日期
objzx_TextEN.UpdUser = objRow[conzx_Text.UpdUser] == DBNull.Value ? null : objRow[conzx_Text.UpdUser].ToString().Trim(); //修改人
objzx_TextEN.CreateDate = objRow[conzx_Text.CreateDate] == DBNull.Value ? null : objRow[conzx_Text.CreateDate].ToString().Trim(); //建立日期
objzx_TextEN.Checker = objRow[conzx_Text.Checker] == DBNull.Value ? null : objRow[conzx_Text.Checker].ToString().Trim(); //审核人
objzx_TextEN.IdCurrEduCls = objRow[conzx_Text.IdCurrEduCls] == DBNull.Value ? null : objRow[conzx_Text.IdCurrEduCls].ToString().Trim(); //教学班流水号
objzx_TextEN.Keyword = objRow[conzx_Text.Keyword] == DBNull.Value ? null : objRow[conzx_Text.Keyword].ToString().Trim(); //关键字
objzx_TextEN.LiteratureSources = objRow[conzx_Text.LiteratureSources] == DBNull.Value ? null : objRow[conzx_Text.LiteratureSources].ToString().Trim(); //文献来源
objzx_TextEN.LiteratureLink = objRow[conzx_Text.LiteratureLink] == DBNull.Value ? null : objRow[conzx_Text.LiteratureLink].ToString().Trim(); //文献链接
objzx_TextEN.UploadfileUrl = objRow[conzx_Text.UploadfileUrl] == DBNull.Value ? null : objRow[conzx_Text.UploadfileUrl].ToString().Trim(); //文件地址
objzx_TextEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[conzx_Text.IsSubmit].ToString().Trim()); //是否提交
objzx_TextEN.IsChecked = clsEntityBase2.TransNullToBool_S(objRow[conzx_Text.IsChecked].ToString().Trim()); //是否检查
objzx_TextEN.BrowseNumber = objRow[conzx_Text.BrowseNumber] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_Text.BrowseNumber].ToString().Trim()); //浏览量
objzx_TextEN.VCount = objRow[conzx_Text.VCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_Text.VCount].ToString().Trim()); //VCount
objzx_TextEN.VoteCount = objRow[conzx_Text.VoteCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_Text.VoteCount].ToString().Trim()); //点赞计数
objzx_TextEN.CollectionCount = objRow[conzx_Text.CollectionCount] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_Text.CollectionCount].ToString().Trim()); //收藏数量
objzx_TextEN.DownloadCount = objRow[conzx_Text.DownloadCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_Text.DownloadCount].ToString().Trim()); //下载数
objzx_TextEN.AttachmentCount = objRow[conzx_Text.AttachmentCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_Text.AttachmentCount].ToString().Trim()); //附件计数
objzx_TextEN.AppraiseCount = objRow[conzx_Text.AppraiseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_Text.AppraiseCount].ToString().Trim()); //评论数
objzx_TextEN.Score = objRow[conzx_Text.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conzx_Text.Score].ToString().Trim()); //评分
objzx_TextEN.StuScore = objRow[conzx_Text.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conzx_Text.StuScore].ToString().Trim()); //学生平均分
objzx_TextEN.TeaScore = objRow[conzx_Text.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conzx_Text.TeaScore].ToString().Trim()); //教师评分
objzx_TextEN.TextTypeId = objRow[conzx_Text.TextTypeId] == DBNull.Value ? null : objRow[conzx_Text.TextTypeId].ToString().Trim(); //TextTypeId
objzx_TextEN.TextStatusId = objRow[conzx_Text.TextStatusId] == DBNull.Value ? null : objRow[conzx_Text.TextStatusId].ToString().Trim(); //TextStatusId
objzx_TextEN.VersionCount = objRow[conzx_Text.VersionCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_Text.VersionCount].ToString().Trim()); //版本统计
objzx_TextEN.IsPublic = clsEntityBase2.TransNullToBool_S(objRow[conzx_Text.IsPublic].ToString().Trim()); //是否公开
objzx_TextEN.zxShareId = objRow[conzx_Text.zxShareId] == DBNull.Value ? null : objRow[conzx_Text.zxShareId].ToString().Trim(); //分享Id
objzx_TextEN.SchoolTerm = objRow[conzx_Text.SchoolTerm] == DBNull.Value ? null : objRow[conzx_Text.SchoolTerm].ToString().Trim(); //学期
objzx_TextEN.GradeId = objRow[conzx_Text.GradeId] == DBNull.Value ? null : objRow[conzx_Text.GradeId].ToString().Trim(); //年级代号
objzx_TextEN.Memo = objRow[conzx_Text.Memo] == DBNull.Value ? null : objRow[conzx_Text.Memo].ToString().Trim(); //备注
objzx_TextEN.UnitId = objRow[conzx_Text.UnitId] == DBNull.Value ? null : objRow[conzx_Text.UnitId].ToString().Trim(); //UnitId
objzx_TextEN.PaperQCount = objRow[conzx_Text.PaperQCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_Text.PaperQCount].ToString().Trim()); //论文答疑数
objzx_TextEN.SubVCount = objRow[conzx_Text.SubVCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_Text.SubVCount].ToString().Trim()); //论文子观点数
objzx_TextEN.TagsCount = objRow[conzx_Text.TagsCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_Text.TagsCount].ToString().Trim()); //论文标注数
objzx_TextEN.TeaQCount = objRow[conzx_Text.TeaQCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_Text.TeaQCount].ToString().Trim()); //教师提问数
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objzx_TextEN.TextId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objzx_TextEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrTextIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clszx_TextEN> GetObjLstByTextIdLstCache(List<string> arrTextIdLst, string strIdCurrEduCls)
{
string strKey = string.Format("{0}_{1}", clszx_TextEN._CurrTabName, strIdCurrEduCls);
List<clszx_TextEN> arrzx_TextObjLstCache = GetObjLstCache(strIdCurrEduCls);
IEnumerable <clszx_TextEN> arrzx_TextObjLst_Sel =
arrzx_TextObjLstCache
.Where(x => arrTextIdLst.Contains(x.TextId));
return arrzx_TextObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clszx_TextEN> GetObjLst(string strWhereCond)
{
List<clszx_TextEN> arrObjLst = new List<clszx_TextEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clszx_TextEN objzx_TextEN = new clszx_TextEN();
try
{
objzx_TextEN.TextId = objRow[conzx_Text.TextId].ToString().Trim(); //课件Id
objzx_TextEN.TextTitle = objRow[conzx_Text.TextTitle].ToString().Trim(); //TextTitle
objzx_TextEN.TextContent = objRow[conzx_Text.TextContent] == DBNull.Value ? null : objRow[conzx_Text.TextContent].ToString().Trim(); //TextContent
objzx_TextEN.Edition = objRow[conzx_Text.Edition] == DBNull.Value ? null : objRow[conzx_Text.Edition].ToString().Trim(); //Edition
objzx_TextEN.Author = objRow[conzx_Text.Author] == DBNull.Value ? null : objRow[conzx_Text.Author].ToString().Trim(); //作者
objzx_TextEN.ResearchQuestion = objRow[conzx_Text.ResearchQuestion] == DBNull.Value ? null : objRow[conzx_Text.ResearchQuestion].ToString().Trim(); //研究问题
objzx_TextEN.UpdDate = objRow[conzx_Text.UpdDate] == DBNull.Value ? null : objRow[conzx_Text.UpdDate].ToString().Trim(); //修改日期
objzx_TextEN.UpdUser = objRow[conzx_Text.UpdUser] == DBNull.Value ? null : objRow[conzx_Text.UpdUser].ToString().Trim(); //修改人
objzx_TextEN.CreateDate = objRow[conzx_Text.CreateDate] == DBNull.Value ? null : objRow[conzx_Text.CreateDate].ToString().Trim(); //建立日期
objzx_TextEN.Checker = objRow[conzx_Text.Checker] == DBNull.Value ? null : objRow[conzx_Text.Checker].ToString().Trim(); //审核人
objzx_TextEN.IdCurrEduCls = objRow[conzx_Text.IdCurrEduCls] == DBNull.Value ? null : objRow[conzx_Text.IdCurrEduCls].ToString().Trim(); //教学班流水号
objzx_TextEN.Keyword = objRow[conzx_Text.Keyword] == DBNull.Value ? null : objRow[conzx_Text.Keyword].ToString().Trim(); //关键字
objzx_TextEN.LiteratureSources = objRow[conzx_Text.LiteratureSources] == DBNull.Value ? null : objRow[conzx_Text.LiteratureSources].ToString().Trim(); //文献来源
objzx_TextEN.LiteratureLink = objRow[conzx_Text.LiteratureLink] == DBNull.Value ? null : objRow[conzx_Text.LiteratureLink].ToString().Trim(); //文献链接
objzx_TextEN.UploadfileUrl = objRow[conzx_Text.UploadfileUrl] == DBNull.Value ? null : objRow[conzx_Text.UploadfileUrl].ToString().Trim(); //文件地址
objzx_TextEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[conzx_Text.IsSubmit].ToString().Trim()); //是否提交
objzx_TextEN.IsChecked = clsEntityBase2.TransNullToBool_S(objRow[conzx_Text.IsChecked].ToString().Trim()); //是否检查
objzx_TextEN.BrowseNumber = objRow[conzx_Text.BrowseNumber] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_Text.BrowseNumber].ToString().Trim()); //浏览量
objzx_TextEN.VCount = objRow[conzx_Text.VCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_Text.VCount].ToString().Trim()); //VCount
objzx_TextEN.VoteCount = objRow[conzx_Text.VoteCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_Text.VoteCount].ToString().Trim()); //点赞计数
objzx_TextEN.CollectionCount = objRow[conzx_Text.CollectionCount] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_Text.CollectionCount].ToString().Trim()); //收藏数量
objzx_TextEN.DownloadCount = objRow[conzx_Text.DownloadCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_Text.DownloadCount].ToString().Trim()); //下载数
objzx_TextEN.AttachmentCount = objRow[conzx_Text.AttachmentCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_Text.AttachmentCount].ToString().Trim()); //附件计数
objzx_TextEN.AppraiseCount = objRow[conzx_Text.AppraiseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_Text.AppraiseCount].ToString().Trim()); //评论数
objzx_TextEN.Score = objRow[conzx_Text.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conzx_Text.Score].ToString().Trim()); //评分
objzx_TextEN.StuScore = objRow[conzx_Text.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conzx_Text.StuScore].ToString().Trim()); //学生平均分
objzx_TextEN.TeaScore = objRow[conzx_Text.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conzx_Text.TeaScore].ToString().Trim()); //教师评分
objzx_TextEN.TextTypeId = objRow[conzx_Text.TextTypeId] == DBNull.Value ? null : objRow[conzx_Text.TextTypeId].ToString().Trim(); //TextTypeId
objzx_TextEN.TextStatusId = objRow[conzx_Text.TextStatusId] == DBNull.Value ? null : objRow[conzx_Text.TextStatusId].ToString().Trim(); //TextStatusId
objzx_TextEN.VersionCount = objRow[conzx_Text.VersionCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_Text.VersionCount].ToString().Trim()); //版本统计
objzx_TextEN.IsPublic = clsEntityBase2.TransNullToBool_S(objRow[conzx_Text.IsPublic].ToString().Trim()); //是否公开
objzx_TextEN.zxShareId = objRow[conzx_Text.zxShareId] == DBNull.Value ? null : objRow[conzx_Text.zxShareId].ToString().Trim(); //分享Id
objzx_TextEN.SchoolTerm = objRow[conzx_Text.SchoolTerm] == DBNull.Value ? null : objRow[conzx_Text.SchoolTerm].ToString().Trim(); //学期
objzx_TextEN.GradeId = objRow[conzx_Text.GradeId] == DBNull.Value ? null : objRow[conzx_Text.GradeId].ToString().Trim(); //年级代号
objzx_TextEN.Memo = objRow[conzx_Text.Memo] == DBNull.Value ? null : objRow[conzx_Text.Memo].ToString().Trim(); //备注
objzx_TextEN.UnitId = objRow[conzx_Text.UnitId] == DBNull.Value ? null : objRow[conzx_Text.UnitId].ToString().Trim(); //UnitId
objzx_TextEN.PaperQCount = objRow[conzx_Text.PaperQCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_Text.PaperQCount].ToString().Trim()); //论文答疑数
objzx_TextEN.SubVCount = objRow[conzx_Text.SubVCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_Text.SubVCount].ToString().Trim()); //论文子观点数
objzx_TextEN.TagsCount = objRow[conzx_Text.TagsCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_Text.TagsCount].ToString().Trim()); //论文标注数
objzx_TextEN.TeaQCount = objRow[conzx_Text.TeaQCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_Text.TeaQCount].ToString().Trim()); //教师提问数
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objzx_TextEN.TextId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objzx_TextEN);
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
public static List<clszx_TextEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clszx_TextEN> arrObjLst = new List<clszx_TextEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clszx_TextEN objzx_TextEN = new clszx_TextEN();
try
{
objzx_TextEN.TextId = objRow[conzx_Text.TextId].ToString().Trim(); //课件Id
objzx_TextEN.TextTitle = objRow[conzx_Text.TextTitle].ToString().Trim(); //TextTitle
objzx_TextEN.TextContent = objRow[conzx_Text.TextContent] == DBNull.Value ? null : objRow[conzx_Text.TextContent].ToString().Trim(); //TextContent
objzx_TextEN.Edition = objRow[conzx_Text.Edition] == DBNull.Value ? null : objRow[conzx_Text.Edition].ToString().Trim(); //Edition
objzx_TextEN.Author = objRow[conzx_Text.Author] == DBNull.Value ? null : objRow[conzx_Text.Author].ToString().Trim(); //作者
objzx_TextEN.ResearchQuestion = objRow[conzx_Text.ResearchQuestion] == DBNull.Value ? null : objRow[conzx_Text.ResearchQuestion].ToString().Trim(); //研究问题
objzx_TextEN.UpdDate = objRow[conzx_Text.UpdDate] == DBNull.Value ? null : objRow[conzx_Text.UpdDate].ToString().Trim(); //修改日期
objzx_TextEN.UpdUser = objRow[conzx_Text.UpdUser] == DBNull.Value ? null : objRow[conzx_Text.UpdUser].ToString().Trim(); //修改人
objzx_TextEN.CreateDate = objRow[conzx_Text.CreateDate] == DBNull.Value ? null : objRow[conzx_Text.CreateDate].ToString().Trim(); //建立日期
objzx_TextEN.Checker = objRow[conzx_Text.Checker] == DBNull.Value ? null : objRow[conzx_Text.Checker].ToString().Trim(); //审核人
objzx_TextEN.IdCurrEduCls = objRow[conzx_Text.IdCurrEduCls] == DBNull.Value ? null : objRow[conzx_Text.IdCurrEduCls].ToString().Trim(); //教学班流水号
objzx_TextEN.Keyword = objRow[conzx_Text.Keyword] == DBNull.Value ? null : objRow[conzx_Text.Keyword].ToString().Trim(); //关键字
objzx_TextEN.LiteratureSources = objRow[conzx_Text.LiteratureSources] == DBNull.Value ? null : objRow[conzx_Text.LiteratureSources].ToString().Trim(); //文献来源
objzx_TextEN.LiteratureLink = objRow[conzx_Text.LiteratureLink] == DBNull.Value ? null : objRow[conzx_Text.LiteratureLink].ToString().Trim(); //文献链接
objzx_TextEN.UploadfileUrl = objRow[conzx_Text.UploadfileUrl] == DBNull.Value ? null : objRow[conzx_Text.UploadfileUrl].ToString().Trim(); //文件地址
objzx_TextEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[conzx_Text.IsSubmit].ToString().Trim()); //是否提交
objzx_TextEN.IsChecked = clsEntityBase2.TransNullToBool_S(objRow[conzx_Text.IsChecked].ToString().Trim()); //是否检查
objzx_TextEN.BrowseNumber = objRow[conzx_Text.BrowseNumber] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_Text.BrowseNumber].ToString().Trim()); //浏览量
objzx_TextEN.VCount = objRow[conzx_Text.VCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_Text.VCount].ToString().Trim()); //VCount
objzx_TextEN.VoteCount = objRow[conzx_Text.VoteCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_Text.VoteCount].ToString().Trim()); //点赞计数
objzx_TextEN.CollectionCount = objRow[conzx_Text.CollectionCount] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_Text.CollectionCount].ToString().Trim()); //收藏数量
objzx_TextEN.DownloadCount = objRow[conzx_Text.DownloadCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_Text.DownloadCount].ToString().Trim()); //下载数
objzx_TextEN.AttachmentCount = objRow[conzx_Text.AttachmentCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_Text.AttachmentCount].ToString().Trim()); //附件计数
objzx_TextEN.AppraiseCount = objRow[conzx_Text.AppraiseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_Text.AppraiseCount].ToString().Trim()); //评论数
objzx_TextEN.Score = objRow[conzx_Text.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conzx_Text.Score].ToString().Trim()); //评分
objzx_TextEN.StuScore = objRow[conzx_Text.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conzx_Text.StuScore].ToString().Trim()); //学生平均分
objzx_TextEN.TeaScore = objRow[conzx_Text.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conzx_Text.TeaScore].ToString().Trim()); //教师评分
objzx_TextEN.TextTypeId = objRow[conzx_Text.TextTypeId] == DBNull.Value ? null : objRow[conzx_Text.TextTypeId].ToString().Trim(); //TextTypeId
objzx_TextEN.TextStatusId = objRow[conzx_Text.TextStatusId] == DBNull.Value ? null : objRow[conzx_Text.TextStatusId].ToString().Trim(); //TextStatusId
objzx_TextEN.VersionCount = objRow[conzx_Text.VersionCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_Text.VersionCount].ToString().Trim()); //版本统计
objzx_TextEN.IsPublic = clsEntityBase2.TransNullToBool_S(objRow[conzx_Text.IsPublic].ToString().Trim()); //是否公开
objzx_TextEN.zxShareId = objRow[conzx_Text.zxShareId] == DBNull.Value ? null : objRow[conzx_Text.zxShareId].ToString().Trim(); //分享Id
objzx_TextEN.SchoolTerm = objRow[conzx_Text.SchoolTerm] == DBNull.Value ? null : objRow[conzx_Text.SchoolTerm].ToString().Trim(); //学期
objzx_TextEN.GradeId = objRow[conzx_Text.GradeId] == DBNull.Value ? null : objRow[conzx_Text.GradeId].ToString().Trim(); //年级代号
objzx_TextEN.Memo = objRow[conzx_Text.Memo] == DBNull.Value ? null : objRow[conzx_Text.Memo].ToString().Trim(); //备注
objzx_TextEN.UnitId = objRow[conzx_Text.UnitId] == DBNull.Value ? null : objRow[conzx_Text.UnitId].ToString().Trim(); //UnitId
objzx_TextEN.PaperQCount = objRow[conzx_Text.PaperQCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_Text.PaperQCount].ToString().Trim()); //论文答疑数
objzx_TextEN.SubVCount = objRow[conzx_Text.SubVCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_Text.SubVCount].ToString().Trim()); //论文子观点数
objzx_TextEN.TagsCount = objRow[conzx_Text.TagsCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_Text.TagsCount].ToString().Trim()); //论文标注数
objzx_TextEN.TeaQCount = objRow[conzx_Text.TeaQCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_Text.TeaQCount].ToString().Trim()); //教师提问数
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objzx_TextEN.TextId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objzx_TextEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objzx_TextCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clszx_TextEN> GetSubObjLstCache(clszx_TextEN objzx_TextCond)
{
 string strIdCurrEduCls = objzx_TextCond.IdCurrEduCls;
 if (string.IsNullOrEmpty(strIdCurrEduCls) == true)
{
string strMsg = string.Format("(errid:Busi000172)在表中,缓存分类字段值不能为空!(clszx_TextBL:GetSubObjLstCache)");
throw new Exception(strMsg);
}
List<clszx_TextEN> arrObjLstCache = GetObjLstCache(strIdCurrEduCls);
IEnumerable <clszx_TextEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conzx_Text.AttributeName)
{
if (objzx_TextCond.IsUpdated(strFldName) == false) continue;
if (objzx_TextCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objzx_TextCond[strFldName].ToString());
}
else
{
if (objzx_TextCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objzx_TextCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objzx_TextCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objzx_TextCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objzx_TextCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objzx_TextCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objzx_TextCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objzx_TextCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objzx_TextCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objzx_TextCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objzx_TextCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objzx_TextCond[strFldName]));
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
public static List<clszx_TextEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clszx_TextEN> arrObjLst = new List<clszx_TextEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clszx_TextEN objzx_TextEN = new clszx_TextEN();
try
{
objzx_TextEN.TextId = objRow[conzx_Text.TextId].ToString().Trim(); //课件Id
objzx_TextEN.TextTitle = objRow[conzx_Text.TextTitle].ToString().Trim(); //TextTitle
objzx_TextEN.TextContent = objRow[conzx_Text.TextContent] == DBNull.Value ? null : objRow[conzx_Text.TextContent].ToString().Trim(); //TextContent
objzx_TextEN.Edition = objRow[conzx_Text.Edition] == DBNull.Value ? null : objRow[conzx_Text.Edition].ToString().Trim(); //Edition
objzx_TextEN.Author = objRow[conzx_Text.Author] == DBNull.Value ? null : objRow[conzx_Text.Author].ToString().Trim(); //作者
objzx_TextEN.ResearchQuestion = objRow[conzx_Text.ResearchQuestion] == DBNull.Value ? null : objRow[conzx_Text.ResearchQuestion].ToString().Trim(); //研究问题
objzx_TextEN.UpdDate = objRow[conzx_Text.UpdDate] == DBNull.Value ? null : objRow[conzx_Text.UpdDate].ToString().Trim(); //修改日期
objzx_TextEN.UpdUser = objRow[conzx_Text.UpdUser] == DBNull.Value ? null : objRow[conzx_Text.UpdUser].ToString().Trim(); //修改人
objzx_TextEN.CreateDate = objRow[conzx_Text.CreateDate] == DBNull.Value ? null : objRow[conzx_Text.CreateDate].ToString().Trim(); //建立日期
objzx_TextEN.Checker = objRow[conzx_Text.Checker] == DBNull.Value ? null : objRow[conzx_Text.Checker].ToString().Trim(); //审核人
objzx_TextEN.IdCurrEduCls = objRow[conzx_Text.IdCurrEduCls] == DBNull.Value ? null : objRow[conzx_Text.IdCurrEduCls].ToString().Trim(); //教学班流水号
objzx_TextEN.Keyword = objRow[conzx_Text.Keyword] == DBNull.Value ? null : objRow[conzx_Text.Keyword].ToString().Trim(); //关键字
objzx_TextEN.LiteratureSources = objRow[conzx_Text.LiteratureSources] == DBNull.Value ? null : objRow[conzx_Text.LiteratureSources].ToString().Trim(); //文献来源
objzx_TextEN.LiteratureLink = objRow[conzx_Text.LiteratureLink] == DBNull.Value ? null : objRow[conzx_Text.LiteratureLink].ToString().Trim(); //文献链接
objzx_TextEN.UploadfileUrl = objRow[conzx_Text.UploadfileUrl] == DBNull.Value ? null : objRow[conzx_Text.UploadfileUrl].ToString().Trim(); //文件地址
objzx_TextEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[conzx_Text.IsSubmit].ToString().Trim()); //是否提交
objzx_TextEN.IsChecked = clsEntityBase2.TransNullToBool_S(objRow[conzx_Text.IsChecked].ToString().Trim()); //是否检查
objzx_TextEN.BrowseNumber = objRow[conzx_Text.BrowseNumber] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_Text.BrowseNumber].ToString().Trim()); //浏览量
objzx_TextEN.VCount = objRow[conzx_Text.VCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_Text.VCount].ToString().Trim()); //VCount
objzx_TextEN.VoteCount = objRow[conzx_Text.VoteCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_Text.VoteCount].ToString().Trim()); //点赞计数
objzx_TextEN.CollectionCount = objRow[conzx_Text.CollectionCount] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_Text.CollectionCount].ToString().Trim()); //收藏数量
objzx_TextEN.DownloadCount = objRow[conzx_Text.DownloadCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_Text.DownloadCount].ToString().Trim()); //下载数
objzx_TextEN.AttachmentCount = objRow[conzx_Text.AttachmentCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_Text.AttachmentCount].ToString().Trim()); //附件计数
objzx_TextEN.AppraiseCount = objRow[conzx_Text.AppraiseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_Text.AppraiseCount].ToString().Trim()); //评论数
objzx_TextEN.Score = objRow[conzx_Text.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conzx_Text.Score].ToString().Trim()); //评分
objzx_TextEN.StuScore = objRow[conzx_Text.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conzx_Text.StuScore].ToString().Trim()); //学生平均分
objzx_TextEN.TeaScore = objRow[conzx_Text.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conzx_Text.TeaScore].ToString().Trim()); //教师评分
objzx_TextEN.TextTypeId = objRow[conzx_Text.TextTypeId] == DBNull.Value ? null : objRow[conzx_Text.TextTypeId].ToString().Trim(); //TextTypeId
objzx_TextEN.TextStatusId = objRow[conzx_Text.TextStatusId] == DBNull.Value ? null : objRow[conzx_Text.TextStatusId].ToString().Trim(); //TextStatusId
objzx_TextEN.VersionCount = objRow[conzx_Text.VersionCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_Text.VersionCount].ToString().Trim()); //版本统计
objzx_TextEN.IsPublic = clsEntityBase2.TransNullToBool_S(objRow[conzx_Text.IsPublic].ToString().Trim()); //是否公开
objzx_TextEN.zxShareId = objRow[conzx_Text.zxShareId] == DBNull.Value ? null : objRow[conzx_Text.zxShareId].ToString().Trim(); //分享Id
objzx_TextEN.SchoolTerm = objRow[conzx_Text.SchoolTerm] == DBNull.Value ? null : objRow[conzx_Text.SchoolTerm].ToString().Trim(); //学期
objzx_TextEN.GradeId = objRow[conzx_Text.GradeId] == DBNull.Value ? null : objRow[conzx_Text.GradeId].ToString().Trim(); //年级代号
objzx_TextEN.Memo = objRow[conzx_Text.Memo] == DBNull.Value ? null : objRow[conzx_Text.Memo].ToString().Trim(); //备注
objzx_TextEN.UnitId = objRow[conzx_Text.UnitId] == DBNull.Value ? null : objRow[conzx_Text.UnitId].ToString().Trim(); //UnitId
objzx_TextEN.PaperQCount = objRow[conzx_Text.PaperQCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_Text.PaperQCount].ToString().Trim()); //论文答疑数
objzx_TextEN.SubVCount = objRow[conzx_Text.SubVCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_Text.SubVCount].ToString().Trim()); //论文子观点数
objzx_TextEN.TagsCount = objRow[conzx_Text.TagsCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_Text.TagsCount].ToString().Trim()); //论文标注数
objzx_TextEN.TeaQCount = objRow[conzx_Text.TeaQCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_Text.TeaQCount].ToString().Trim()); //教师提问数
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objzx_TextEN.TextId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objzx_TextEN);
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
public static List<clszx_TextEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clszx_TextEN> arrObjLst = new List<clszx_TextEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clszx_TextEN objzx_TextEN = new clszx_TextEN();
try
{
objzx_TextEN.TextId = objRow[conzx_Text.TextId].ToString().Trim(); //课件Id
objzx_TextEN.TextTitle = objRow[conzx_Text.TextTitle].ToString().Trim(); //TextTitle
objzx_TextEN.TextContent = objRow[conzx_Text.TextContent] == DBNull.Value ? null : objRow[conzx_Text.TextContent].ToString().Trim(); //TextContent
objzx_TextEN.Edition = objRow[conzx_Text.Edition] == DBNull.Value ? null : objRow[conzx_Text.Edition].ToString().Trim(); //Edition
objzx_TextEN.Author = objRow[conzx_Text.Author] == DBNull.Value ? null : objRow[conzx_Text.Author].ToString().Trim(); //作者
objzx_TextEN.ResearchQuestion = objRow[conzx_Text.ResearchQuestion] == DBNull.Value ? null : objRow[conzx_Text.ResearchQuestion].ToString().Trim(); //研究问题
objzx_TextEN.UpdDate = objRow[conzx_Text.UpdDate] == DBNull.Value ? null : objRow[conzx_Text.UpdDate].ToString().Trim(); //修改日期
objzx_TextEN.UpdUser = objRow[conzx_Text.UpdUser] == DBNull.Value ? null : objRow[conzx_Text.UpdUser].ToString().Trim(); //修改人
objzx_TextEN.CreateDate = objRow[conzx_Text.CreateDate] == DBNull.Value ? null : objRow[conzx_Text.CreateDate].ToString().Trim(); //建立日期
objzx_TextEN.Checker = objRow[conzx_Text.Checker] == DBNull.Value ? null : objRow[conzx_Text.Checker].ToString().Trim(); //审核人
objzx_TextEN.IdCurrEduCls = objRow[conzx_Text.IdCurrEduCls] == DBNull.Value ? null : objRow[conzx_Text.IdCurrEduCls].ToString().Trim(); //教学班流水号
objzx_TextEN.Keyword = objRow[conzx_Text.Keyword] == DBNull.Value ? null : objRow[conzx_Text.Keyword].ToString().Trim(); //关键字
objzx_TextEN.LiteratureSources = objRow[conzx_Text.LiteratureSources] == DBNull.Value ? null : objRow[conzx_Text.LiteratureSources].ToString().Trim(); //文献来源
objzx_TextEN.LiteratureLink = objRow[conzx_Text.LiteratureLink] == DBNull.Value ? null : objRow[conzx_Text.LiteratureLink].ToString().Trim(); //文献链接
objzx_TextEN.UploadfileUrl = objRow[conzx_Text.UploadfileUrl] == DBNull.Value ? null : objRow[conzx_Text.UploadfileUrl].ToString().Trim(); //文件地址
objzx_TextEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[conzx_Text.IsSubmit].ToString().Trim()); //是否提交
objzx_TextEN.IsChecked = clsEntityBase2.TransNullToBool_S(objRow[conzx_Text.IsChecked].ToString().Trim()); //是否检查
objzx_TextEN.BrowseNumber = objRow[conzx_Text.BrowseNumber] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_Text.BrowseNumber].ToString().Trim()); //浏览量
objzx_TextEN.VCount = objRow[conzx_Text.VCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_Text.VCount].ToString().Trim()); //VCount
objzx_TextEN.VoteCount = objRow[conzx_Text.VoteCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_Text.VoteCount].ToString().Trim()); //点赞计数
objzx_TextEN.CollectionCount = objRow[conzx_Text.CollectionCount] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_Text.CollectionCount].ToString().Trim()); //收藏数量
objzx_TextEN.DownloadCount = objRow[conzx_Text.DownloadCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_Text.DownloadCount].ToString().Trim()); //下载数
objzx_TextEN.AttachmentCount = objRow[conzx_Text.AttachmentCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_Text.AttachmentCount].ToString().Trim()); //附件计数
objzx_TextEN.AppraiseCount = objRow[conzx_Text.AppraiseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_Text.AppraiseCount].ToString().Trim()); //评论数
objzx_TextEN.Score = objRow[conzx_Text.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conzx_Text.Score].ToString().Trim()); //评分
objzx_TextEN.StuScore = objRow[conzx_Text.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conzx_Text.StuScore].ToString().Trim()); //学生平均分
objzx_TextEN.TeaScore = objRow[conzx_Text.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conzx_Text.TeaScore].ToString().Trim()); //教师评分
objzx_TextEN.TextTypeId = objRow[conzx_Text.TextTypeId] == DBNull.Value ? null : objRow[conzx_Text.TextTypeId].ToString().Trim(); //TextTypeId
objzx_TextEN.TextStatusId = objRow[conzx_Text.TextStatusId] == DBNull.Value ? null : objRow[conzx_Text.TextStatusId].ToString().Trim(); //TextStatusId
objzx_TextEN.VersionCount = objRow[conzx_Text.VersionCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_Text.VersionCount].ToString().Trim()); //版本统计
objzx_TextEN.IsPublic = clsEntityBase2.TransNullToBool_S(objRow[conzx_Text.IsPublic].ToString().Trim()); //是否公开
objzx_TextEN.zxShareId = objRow[conzx_Text.zxShareId] == DBNull.Value ? null : objRow[conzx_Text.zxShareId].ToString().Trim(); //分享Id
objzx_TextEN.SchoolTerm = objRow[conzx_Text.SchoolTerm] == DBNull.Value ? null : objRow[conzx_Text.SchoolTerm].ToString().Trim(); //学期
objzx_TextEN.GradeId = objRow[conzx_Text.GradeId] == DBNull.Value ? null : objRow[conzx_Text.GradeId].ToString().Trim(); //年级代号
objzx_TextEN.Memo = objRow[conzx_Text.Memo] == DBNull.Value ? null : objRow[conzx_Text.Memo].ToString().Trim(); //备注
objzx_TextEN.UnitId = objRow[conzx_Text.UnitId] == DBNull.Value ? null : objRow[conzx_Text.UnitId].ToString().Trim(); //UnitId
objzx_TextEN.PaperQCount = objRow[conzx_Text.PaperQCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_Text.PaperQCount].ToString().Trim()); //论文答疑数
objzx_TextEN.SubVCount = objRow[conzx_Text.SubVCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_Text.SubVCount].ToString().Trim()); //论文子观点数
objzx_TextEN.TagsCount = objRow[conzx_Text.TagsCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_Text.TagsCount].ToString().Trim()); //论文标注数
objzx_TextEN.TeaQCount = objRow[conzx_Text.TeaQCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_Text.TeaQCount].ToString().Trim()); //教师提问数
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objzx_TextEN.TextId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objzx_TextEN);
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
List<clszx_TextEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clszx_TextEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clszx_TextEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clszx_TextEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clszx_TextEN> arrObjLst = new List<clszx_TextEN>(); 
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
	clszx_TextEN objzx_TextEN = new clszx_TextEN();
try
{
objzx_TextEN.TextId = objRow[conzx_Text.TextId].ToString().Trim(); //课件Id
objzx_TextEN.TextTitle = objRow[conzx_Text.TextTitle].ToString().Trim(); //TextTitle
objzx_TextEN.TextContent = objRow[conzx_Text.TextContent] == DBNull.Value ? null : objRow[conzx_Text.TextContent].ToString().Trim(); //TextContent
objzx_TextEN.Edition = objRow[conzx_Text.Edition] == DBNull.Value ? null : objRow[conzx_Text.Edition].ToString().Trim(); //Edition
objzx_TextEN.Author = objRow[conzx_Text.Author] == DBNull.Value ? null : objRow[conzx_Text.Author].ToString().Trim(); //作者
objzx_TextEN.ResearchQuestion = objRow[conzx_Text.ResearchQuestion] == DBNull.Value ? null : objRow[conzx_Text.ResearchQuestion].ToString().Trim(); //研究问题
objzx_TextEN.UpdDate = objRow[conzx_Text.UpdDate] == DBNull.Value ? null : objRow[conzx_Text.UpdDate].ToString().Trim(); //修改日期
objzx_TextEN.UpdUser = objRow[conzx_Text.UpdUser] == DBNull.Value ? null : objRow[conzx_Text.UpdUser].ToString().Trim(); //修改人
objzx_TextEN.CreateDate = objRow[conzx_Text.CreateDate] == DBNull.Value ? null : objRow[conzx_Text.CreateDate].ToString().Trim(); //建立日期
objzx_TextEN.Checker = objRow[conzx_Text.Checker] == DBNull.Value ? null : objRow[conzx_Text.Checker].ToString().Trim(); //审核人
objzx_TextEN.IdCurrEduCls = objRow[conzx_Text.IdCurrEduCls] == DBNull.Value ? null : objRow[conzx_Text.IdCurrEduCls].ToString().Trim(); //教学班流水号
objzx_TextEN.Keyword = objRow[conzx_Text.Keyword] == DBNull.Value ? null : objRow[conzx_Text.Keyword].ToString().Trim(); //关键字
objzx_TextEN.LiteratureSources = objRow[conzx_Text.LiteratureSources] == DBNull.Value ? null : objRow[conzx_Text.LiteratureSources].ToString().Trim(); //文献来源
objzx_TextEN.LiteratureLink = objRow[conzx_Text.LiteratureLink] == DBNull.Value ? null : objRow[conzx_Text.LiteratureLink].ToString().Trim(); //文献链接
objzx_TextEN.UploadfileUrl = objRow[conzx_Text.UploadfileUrl] == DBNull.Value ? null : objRow[conzx_Text.UploadfileUrl].ToString().Trim(); //文件地址
objzx_TextEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[conzx_Text.IsSubmit].ToString().Trim()); //是否提交
objzx_TextEN.IsChecked = clsEntityBase2.TransNullToBool_S(objRow[conzx_Text.IsChecked].ToString().Trim()); //是否检查
objzx_TextEN.BrowseNumber = objRow[conzx_Text.BrowseNumber] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_Text.BrowseNumber].ToString().Trim()); //浏览量
objzx_TextEN.VCount = objRow[conzx_Text.VCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_Text.VCount].ToString().Trim()); //VCount
objzx_TextEN.VoteCount = objRow[conzx_Text.VoteCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_Text.VoteCount].ToString().Trim()); //点赞计数
objzx_TextEN.CollectionCount = objRow[conzx_Text.CollectionCount] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_Text.CollectionCount].ToString().Trim()); //收藏数量
objzx_TextEN.DownloadCount = objRow[conzx_Text.DownloadCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_Text.DownloadCount].ToString().Trim()); //下载数
objzx_TextEN.AttachmentCount = objRow[conzx_Text.AttachmentCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_Text.AttachmentCount].ToString().Trim()); //附件计数
objzx_TextEN.AppraiseCount = objRow[conzx_Text.AppraiseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_Text.AppraiseCount].ToString().Trim()); //评论数
objzx_TextEN.Score = objRow[conzx_Text.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conzx_Text.Score].ToString().Trim()); //评分
objzx_TextEN.StuScore = objRow[conzx_Text.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conzx_Text.StuScore].ToString().Trim()); //学生平均分
objzx_TextEN.TeaScore = objRow[conzx_Text.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conzx_Text.TeaScore].ToString().Trim()); //教师评分
objzx_TextEN.TextTypeId = objRow[conzx_Text.TextTypeId] == DBNull.Value ? null : objRow[conzx_Text.TextTypeId].ToString().Trim(); //TextTypeId
objzx_TextEN.TextStatusId = objRow[conzx_Text.TextStatusId] == DBNull.Value ? null : objRow[conzx_Text.TextStatusId].ToString().Trim(); //TextStatusId
objzx_TextEN.VersionCount = objRow[conzx_Text.VersionCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_Text.VersionCount].ToString().Trim()); //版本统计
objzx_TextEN.IsPublic = clsEntityBase2.TransNullToBool_S(objRow[conzx_Text.IsPublic].ToString().Trim()); //是否公开
objzx_TextEN.zxShareId = objRow[conzx_Text.zxShareId] == DBNull.Value ? null : objRow[conzx_Text.zxShareId].ToString().Trim(); //分享Id
objzx_TextEN.SchoolTerm = objRow[conzx_Text.SchoolTerm] == DBNull.Value ? null : objRow[conzx_Text.SchoolTerm].ToString().Trim(); //学期
objzx_TextEN.GradeId = objRow[conzx_Text.GradeId] == DBNull.Value ? null : objRow[conzx_Text.GradeId].ToString().Trim(); //年级代号
objzx_TextEN.Memo = objRow[conzx_Text.Memo] == DBNull.Value ? null : objRow[conzx_Text.Memo].ToString().Trim(); //备注
objzx_TextEN.UnitId = objRow[conzx_Text.UnitId] == DBNull.Value ? null : objRow[conzx_Text.UnitId].ToString().Trim(); //UnitId
objzx_TextEN.PaperQCount = objRow[conzx_Text.PaperQCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_Text.PaperQCount].ToString().Trim()); //论文答疑数
objzx_TextEN.SubVCount = objRow[conzx_Text.SubVCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_Text.SubVCount].ToString().Trim()); //论文子观点数
objzx_TextEN.TagsCount = objRow[conzx_Text.TagsCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_Text.TagsCount].ToString().Trim()); //论文标注数
objzx_TextEN.TeaQCount = objRow[conzx_Text.TeaQCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_Text.TeaQCount].ToString().Trim()); //教师提问数
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objzx_TextEN.TextId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objzx_TextEN);
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
public static List<clszx_TextEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clszx_TextEN> arrObjLst = new List<clszx_TextEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clszx_TextEN objzx_TextEN = new clszx_TextEN();
try
{
objzx_TextEN.TextId = objRow[conzx_Text.TextId].ToString().Trim(); //课件Id
objzx_TextEN.TextTitle = objRow[conzx_Text.TextTitle].ToString().Trim(); //TextTitle
objzx_TextEN.TextContent = objRow[conzx_Text.TextContent] == DBNull.Value ? null : objRow[conzx_Text.TextContent].ToString().Trim(); //TextContent
objzx_TextEN.Edition = objRow[conzx_Text.Edition] == DBNull.Value ? null : objRow[conzx_Text.Edition].ToString().Trim(); //Edition
objzx_TextEN.Author = objRow[conzx_Text.Author] == DBNull.Value ? null : objRow[conzx_Text.Author].ToString().Trim(); //作者
objzx_TextEN.ResearchQuestion = objRow[conzx_Text.ResearchQuestion] == DBNull.Value ? null : objRow[conzx_Text.ResearchQuestion].ToString().Trim(); //研究问题
objzx_TextEN.UpdDate = objRow[conzx_Text.UpdDate] == DBNull.Value ? null : objRow[conzx_Text.UpdDate].ToString().Trim(); //修改日期
objzx_TextEN.UpdUser = objRow[conzx_Text.UpdUser] == DBNull.Value ? null : objRow[conzx_Text.UpdUser].ToString().Trim(); //修改人
objzx_TextEN.CreateDate = objRow[conzx_Text.CreateDate] == DBNull.Value ? null : objRow[conzx_Text.CreateDate].ToString().Trim(); //建立日期
objzx_TextEN.Checker = objRow[conzx_Text.Checker] == DBNull.Value ? null : objRow[conzx_Text.Checker].ToString().Trim(); //审核人
objzx_TextEN.IdCurrEduCls = objRow[conzx_Text.IdCurrEduCls] == DBNull.Value ? null : objRow[conzx_Text.IdCurrEduCls].ToString().Trim(); //教学班流水号
objzx_TextEN.Keyword = objRow[conzx_Text.Keyword] == DBNull.Value ? null : objRow[conzx_Text.Keyword].ToString().Trim(); //关键字
objzx_TextEN.LiteratureSources = objRow[conzx_Text.LiteratureSources] == DBNull.Value ? null : objRow[conzx_Text.LiteratureSources].ToString().Trim(); //文献来源
objzx_TextEN.LiteratureLink = objRow[conzx_Text.LiteratureLink] == DBNull.Value ? null : objRow[conzx_Text.LiteratureLink].ToString().Trim(); //文献链接
objzx_TextEN.UploadfileUrl = objRow[conzx_Text.UploadfileUrl] == DBNull.Value ? null : objRow[conzx_Text.UploadfileUrl].ToString().Trim(); //文件地址
objzx_TextEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[conzx_Text.IsSubmit].ToString().Trim()); //是否提交
objzx_TextEN.IsChecked = clsEntityBase2.TransNullToBool_S(objRow[conzx_Text.IsChecked].ToString().Trim()); //是否检查
objzx_TextEN.BrowseNumber = objRow[conzx_Text.BrowseNumber] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_Text.BrowseNumber].ToString().Trim()); //浏览量
objzx_TextEN.VCount = objRow[conzx_Text.VCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_Text.VCount].ToString().Trim()); //VCount
objzx_TextEN.VoteCount = objRow[conzx_Text.VoteCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_Text.VoteCount].ToString().Trim()); //点赞计数
objzx_TextEN.CollectionCount = objRow[conzx_Text.CollectionCount] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_Text.CollectionCount].ToString().Trim()); //收藏数量
objzx_TextEN.DownloadCount = objRow[conzx_Text.DownloadCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_Text.DownloadCount].ToString().Trim()); //下载数
objzx_TextEN.AttachmentCount = objRow[conzx_Text.AttachmentCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_Text.AttachmentCount].ToString().Trim()); //附件计数
objzx_TextEN.AppraiseCount = objRow[conzx_Text.AppraiseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_Text.AppraiseCount].ToString().Trim()); //评论数
objzx_TextEN.Score = objRow[conzx_Text.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conzx_Text.Score].ToString().Trim()); //评分
objzx_TextEN.StuScore = objRow[conzx_Text.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conzx_Text.StuScore].ToString().Trim()); //学生平均分
objzx_TextEN.TeaScore = objRow[conzx_Text.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conzx_Text.TeaScore].ToString().Trim()); //教师评分
objzx_TextEN.TextTypeId = objRow[conzx_Text.TextTypeId] == DBNull.Value ? null : objRow[conzx_Text.TextTypeId].ToString().Trim(); //TextTypeId
objzx_TextEN.TextStatusId = objRow[conzx_Text.TextStatusId] == DBNull.Value ? null : objRow[conzx_Text.TextStatusId].ToString().Trim(); //TextStatusId
objzx_TextEN.VersionCount = objRow[conzx_Text.VersionCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_Text.VersionCount].ToString().Trim()); //版本统计
objzx_TextEN.IsPublic = clsEntityBase2.TransNullToBool_S(objRow[conzx_Text.IsPublic].ToString().Trim()); //是否公开
objzx_TextEN.zxShareId = objRow[conzx_Text.zxShareId] == DBNull.Value ? null : objRow[conzx_Text.zxShareId].ToString().Trim(); //分享Id
objzx_TextEN.SchoolTerm = objRow[conzx_Text.SchoolTerm] == DBNull.Value ? null : objRow[conzx_Text.SchoolTerm].ToString().Trim(); //学期
objzx_TextEN.GradeId = objRow[conzx_Text.GradeId] == DBNull.Value ? null : objRow[conzx_Text.GradeId].ToString().Trim(); //年级代号
objzx_TextEN.Memo = objRow[conzx_Text.Memo] == DBNull.Value ? null : objRow[conzx_Text.Memo].ToString().Trim(); //备注
objzx_TextEN.UnitId = objRow[conzx_Text.UnitId] == DBNull.Value ? null : objRow[conzx_Text.UnitId].ToString().Trim(); //UnitId
objzx_TextEN.PaperQCount = objRow[conzx_Text.PaperQCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_Text.PaperQCount].ToString().Trim()); //论文答疑数
objzx_TextEN.SubVCount = objRow[conzx_Text.SubVCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_Text.SubVCount].ToString().Trim()); //论文子观点数
objzx_TextEN.TagsCount = objRow[conzx_Text.TagsCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_Text.TagsCount].ToString().Trim()); //论文标注数
objzx_TextEN.TeaQCount = objRow[conzx_Text.TeaQCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_Text.TeaQCount].ToString().Trim()); //教师提问数
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objzx_TextEN.TextId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objzx_TextEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clszx_TextEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clszx_TextEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clszx_TextEN> arrObjLst = new List<clszx_TextEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clszx_TextEN objzx_TextEN = new clszx_TextEN();
try
{
objzx_TextEN.TextId = objRow[conzx_Text.TextId].ToString().Trim(); //课件Id
objzx_TextEN.TextTitle = objRow[conzx_Text.TextTitle].ToString().Trim(); //TextTitle
objzx_TextEN.TextContent = objRow[conzx_Text.TextContent] == DBNull.Value ? null : objRow[conzx_Text.TextContent].ToString().Trim(); //TextContent
objzx_TextEN.Edition = objRow[conzx_Text.Edition] == DBNull.Value ? null : objRow[conzx_Text.Edition].ToString().Trim(); //Edition
objzx_TextEN.Author = objRow[conzx_Text.Author] == DBNull.Value ? null : objRow[conzx_Text.Author].ToString().Trim(); //作者
objzx_TextEN.ResearchQuestion = objRow[conzx_Text.ResearchQuestion] == DBNull.Value ? null : objRow[conzx_Text.ResearchQuestion].ToString().Trim(); //研究问题
objzx_TextEN.UpdDate = objRow[conzx_Text.UpdDate] == DBNull.Value ? null : objRow[conzx_Text.UpdDate].ToString().Trim(); //修改日期
objzx_TextEN.UpdUser = objRow[conzx_Text.UpdUser] == DBNull.Value ? null : objRow[conzx_Text.UpdUser].ToString().Trim(); //修改人
objzx_TextEN.CreateDate = objRow[conzx_Text.CreateDate] == DBNull.Value ? null : objRow[conzx_Text.CreateDate].ToString().Trim(); //建立日期
objzx_TextEN.Checker = objRow[conzx_Text.Checker] == DBNull.Value ? null : objRow[conzx_Text.Checker].ToString().Trim(); //审核人
objzx_TextEN.IdCurrEduCls = objRow[conzx_Text.IdCurrEduCls] == DBNull.Value ? null : objRow[conzx_Text.IdCurrEduCls].ToString().Trim(); //教学班流水号
objzx_TextEN.Keyword = objRow[conzx_Text.Keyword] == DBNull.Value ? null : objRow[conzx_Text.Keyword].ToString().Trim(); //关键字
objzx_TextEN.LiteratureSources = objRow[conzx_Text.LiteratureSources] == DBNull.Value ? null : objRow[conzx_Text.LiteratureSources].ToString().Trim(); //文献来源
objzx_TextEN.LiteratureLink = objRow[conzx_Text.LiteratureLink] == DBNull.Value ? null : objRow[conzx_Text.LiteratureLink].ToString().Trim(); //文献链接
objzx_TextEN.UploadfileUrl = objRow[conzx_Text.UploadfileUrl] == DBNull.Value ? null : objRow[conzx_Text.UploadfileUrl].ToString().Trim(); //文件地址
objzx_TextEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[conzx_Text.IsSubmit].ToString().Trim()); //是否提交
objzx_TextEN.IsChecked = clsEntityBase2.TransNullToBool_S(objRow[conzx_Text.IsChecked].ToString().Trim()); //是否检查
objzx_TextEN.BrowseNumber = objRow[conzx_Text.BrowseNumber] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_Text.BrowseNumber].ToString().Trim()); //浏览量
objzx_TextEN.VCount = objRow[conzx_Text.VCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_Text.VCount].ToString().Trim()); //VCount
objzx_TextEN.VoteCount = objRow[conzx_Text.VoteCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_Text.VoteCount].ToString().Trim()); //点赞计数
objzx_TextEN.CollectionCount = objRow[conzx_Text.CollectionCount] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_Text.CollectionCount].ToString().Trim()); //收藏数量
objzx_TextEN.DownloadCount = objRow[conzx_Text.DownloadCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_Text.DownloadCount].ToString().Trim()); //下载数
objzx_TextEN.AttachmentCount = objRow[conzx_Text.AttachmentCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_Text.AttachmentCount].ToString().Trim()); //附件计数
objzx_TextEN.AppraiseCount = objRow[conzx_Text.AppraiseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_Text.AppraiseCount].ToString().Trim()); //评论数
objzx_TextEN.Score = objRow[conzx_Text.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conzx_Text.Score].ToString().Trim()); //评分
objzx_TextEN.StuScore = objRow[conzx_Text.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conzx_Text.StuScore].ToString().Trim()); //学生平均分
objzx_TextEN.TeaScore = objRow[conzx_Text.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conzx_Text.TeaScore].ToString().Trim()); //教师评分
objzx_TextEN.TextTypeId = objRow[conzx_Text.TextTypeId] == DBNull.Value ? null : objRow[conzx_Text.TextTypeId].ToString().Trim(); //TextTypeId
objzx_TextEN.TextStatusId = objRow[conzx_Text.TextStatusId] == DBNull.Value ? null : objRow[conzx_Text.TextStatusId].ToString().Trim(); //TextStatusId
objzx_TextEN.VersionCount = objRow[conzx_Text.VersionCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_Text.VersionCount].ToString().Trim()); //版本统计
objzx_TextEN.IsPublic = clsEntityBase2.TransNullToBool_S(objRow[conzx_Text.IsPublic].ToString().Trim()); //是否公开
objzx_TextEN.zxShareId = objRow[conzx_Text.zxShareId] == DBNull.Value ? null : objRow[conzx_Text.zxShareId].ToString().Trim(); //分享Id
objzx_TextEN.SchoolTerm = objRow[conzx_Text.SchoolTerm] == DBNull.Value ? null : objRow[conzx_Text.SchoolTerm].ToString().Trim(); //学期
objzx_TextEN.GradeId = objRow[conzx_Text.GradeId] == DBNull.Value ? null : objRow[conzx_Text.GradeId].ToString().Trim(); //年级代号
objzx_TextEN.Memo = objRow[conzx_Text.Memo] == DBNull.Value ? null : objRow[conzx_Text.Memo].ToString().Trim(); //备注
objzx_TextEN.UnitId = objRow[conzx_Text.UnitId] == DBNull.Value ? null : objRow[conzx_Text.UnitId].ToString().Trim(); //UnitId
objzx_TextEN.PaperQCount = objRow[conzx_Text.PaperQCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_Text.PaperQCount].ToString().Trim()); //论文答疑数
objzx_TextEN.SubVCount = objRow[conzx_Text.SubVCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_Text.SubVCount].ToString().Trim()); //论文子观点数
objzx_TextEN.TagsCount = objRow[conzx_Text.TagsCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_Text.TagsCount].ToString().Trim()); //论文标注数
objzx_TextEN.TeaQCount = objRow[conzx_Text.TeaQCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_Text.TeaQCount].ToString().Trim()); //教师提问数
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objzx_TextEN.TextId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objzx_TextEN);
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
public static List<clszx_TextEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clszx_TextEN> arrObjLst = new List<clszx_TextEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clszx_TextEN objzx_TextEN = new clszx_TextEN();
try
{
objzx_TextEN.TextId = objRow[conzx_Text.TextId].ToString().Trim(); //课件Id
objzx_TextEN.TextTitle = objRow[conzx_Text.TextTitle].ToString().Trim(); //TextTitle
objzx_TextEN.TextContent = objRow[conzx_Text.TextContent] == DBNull.Value ? null : objRow[conzx_Text.TextContent].ToString().Trim(); //TextContent
objzx_TextEN.Edition = objRow[conzx_Text.Edition] == DBNull.Value ? null : objRow[conzx_Text.Edition].ToString().Trim(); //Edition
objzx_TextEN.Author = objRow[conzx_Text.Author] == DBNull.Value ? null : objRow[conzx_Text.Author].ToString().Trim(); //作者
objzx_TextEN.ResearchQuestion = objRow[conzx_Text.ResearchQuestion] == DBNull.Value ? null : objRow[conzx_Text.ResearchQuestion].ToString().Trim(); //研究问题
objzx_TextEN.UpdDate = objRow[conzx_Text.UpdDate] == DBNull.Value ? null : objRow[conzx_Text.UpdDate].ToString().Trim(); //修改日期
objzx_TextEN.UpdUser = objRow[conzx_Text.UpdUser] == DBNull.Value ? null : objRow[conzx_Text.UpdUser].ToString().Trim(); //修改人
objzx_TextEN.CreateDate = objRow[conzx_Text.CreateDate] == DBNull.Value ? null : objRow[conzx_Text.CreateDate].ToString().Trim(); //建立日期
objzx_TextEN.Checker = objRow[conzx_Text.Checker] == DBNull.Value ? null : objRow[conzx_Text.Checker].ToString().Trim(); //审核人
objzx_TextEN.IdCurrEduCls = objRow[conzx_Text.IdCurrEduCls] == DBNull.Value ? null : objRow[conzx_Text.IdCurrEduCls].ToString().Trim(); //教学班流水号
objzx_TextEN.Keyword = objRow[conzx_Text.Keyword] == DBNull.Value ? null : objRow[conzx_Text.Keyword].ToString().Trim(); //关键字
objzx_TextEN.LiteratureSources = objRow[conzx_Text.LiteratureSources] == DBNull.Value ? null : objRow[conzx_Text.LiteratureSources].ToString().Trim(); //文献来源
objzx_TextEN.LiteratureLink = objRow[conzx_Text.LiteratureLink] == DBNull.Value ? null : objRow[conzx_Text.LiteratureLink].ToString().Trim(); //文献链接
objzx_TextEN.UploadfileUrl = objRow[conzx_Text.UploadfileUrl] == DBNull.Value ? null : objRow[conzx_Text.UploadfileUrl].ToString().Trim(); //文件地址
objzx_TextEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[conzx_Text.IsSubmit].ToString().Trim()); //是否提交
objzx_TextEN.IsChecked = clsEntityBase2.TransNullToBool_S(objRow[conzx_Text.IsChecked].ToString().Trim()); //是否检查
objzx_TextEN.BrowseNumber = objRow[conzx_Text.BrowseNumber] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_Text.BrowseNumber].ToString().Trim()); //浏览量
objzx_TextEN.VCount = objRow[conzx_Text.VCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_Text.VCount].ToString().Trim()); //VCount
objzx_TextEN.VoteCount = objRow[conzx_Text.VoteCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_Text.VoteCount].ToString().Trim()); //点赞计数
objzx_TextEN.CollectionCount = objRow[conzx_Text.CollectionCount] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_Text.CollectionCount].ToString().Trim()); //收藏数量
objzx_TextEN.DownloadCount = objRow[conzx_Text.DownloadCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_Text.DownloadCount].ToString().Trim()); //下载数
objzx_TextEN.AttachmentCount = objRow[conzx_Text.AttachmentCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_Text.AttachmentCount].ToString().Trim()); //附件计数
objzx_TextEN.AppraiseCount = objRow[conzx_Text.AppraiseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_Text.AppraiseCount].ToString().Trim()); //评论数
objzx_TextEN.Score = objRow[conzx_Text.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conzx_Text.Score].ToString().Trim()); //评分
objzx_TextEN.StuScore = objRow[conzx_Text.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conzx_Text.StuScore].ToString().Trim()); //学生平均分
objzx_TextEN.TeaScore = objRow[conzx_Text.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conzx_Text.TeaScore].ToString().Trim()); //教师评分
objzx_TextEN.TextTypeId = objRow[conzx_Text.TextTypeId] == DBNull.Value ? null : objRow[conzx_Text.TextTypeId].ToString().Trim(); //TextTypeId
objzx_TextEN.TextStatusId = objRow[conzx_Text.TextStatusId] == DBNull.Value ? null : objRow[conzx_Text.TextStatusId].ToString().Trim(); //TextStatusId
objzx_TextEN.VersionCount = objRow[conzx_Text.VersionCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_Text.VersionCount].ToString().Trim()); //版本统计
objzx_TextEN.IsPublic = clsEntityBase2.TransNullToBool_S(objRow[conzx_Text.IsPublic].ToString().Trim()); //是否公开
objzx_TextEN.zxShareId = objRow[conzx_Text.zxShareId] == DBNull.Value ? null : objRow[conzx_Text.zxShareId].ToString().Trim(); //分享Id
objzx_TextEN.SchoolTerm = objRow[conzx_Text.SchoolTerm] == DBNull.Value ? null : objRow[conzx_Text.SchoolTerm].ToString().Trim(); //学期
objzx_TextEN.GradeId = objRow[conzx_Text.GradeId] == DBNull.Value ? null : objRow[conzx_Text.GradeId].ToString().Trim(); //年级代号
objzx_TextEN.Memo = objRow[conzx_Text.Memo] == DBNull.Value ? null : objRow[conzx_Text.Memo].ToString().Trim(); //备注
objzx_TextEN.UnitId = objRow[conzx_Text.UnitId] == DBNull.Value ? null : objRow[conzx_Text.UnitId].ToString().Trim(); //UnitId
objzx_TextEN.PaperQCount = objRow[conzx_Text.PaperQCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_Text.PaperQCount].ToString().Trim()); //论文答疑数
objzx_TextEN.SubVCount = objRow[conzx_Text.SubVCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_Text.SubVCount].ToString().Trim()); //论文子观点数
objzx_TextEN.TagsCount = objRow[conzx_Text.TagsCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_Text.TagsCount].ToString().Trim()); //论文标注数
objzx_TextEN.TeaQCount = objRow[conzx_Text.TeaQCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_Text.TeaQCount].ToString().Trim()); //教师提问数
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objzx_TextEN.TextId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objzx_TextEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clszx_TextEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clszx_TextEN> arrObjLst = new List<clszx_TextEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clszx_TextEN objzx_TextEN = new clszx_TextEN();
try
{
objzx_TextEN.TextId = objRow[conzx_Text.TextId].ToString().Trim(); //课件Id
objzx_TextEN.TextTitle = objRow[conzx_Text.TextTitle].ToString().Trim(); //TextTitle
objzx_TextEN.TextContent = objRow[conzx_Text.TextContent] == DBNull.Value ? null : objRow[conzx_Text.TextContent].ToString().Trim(); //TextContent
objzx_TextEN.Edition = objRow[conzx_Text.Edition] == DBNull.Value ? null : objRow[conzx_Text.Edition].ToString().Trim(); //Edition
objzx_TextEN.Author = objRow[conzx_Text.Author] == DBNull.Value ? null : objRow[conzx_Text.Author].ToString().Trim(); //作者
objzx_TextEN.ResearchQuestion = objRow[conzx_Text.ResearchQuestion] == DBNull.Value ? null : objRow[conzx_Text.ResearchQuestion].ToString().Trim(); //研究问题
objzx_TextEN.UpdDate = objRow[conzx_Text.UpdDate] == DBNull.Value ? null : objRow[conzx_Text.UpdDate].ToString().Trim(); //修改日期
objzx_TextEN.UpdUser = objRow[conzx_Text.UpdUser] == DBNull.Value ? null : objRow[conzx_Text.UpdUser].ToString().Trim(); //修改人
objzx_TextEN.CreateDate = objRow[conzx_Text.CreateDate] == DBNull.Value ? null : objRow[conzx_Text.CreateDate].ToString().Trim(); //建立日期
objzx_TextEN.Checker = objRow[conzx_Text.Checker] == DBNull.Value ? null : objRow[conzx_Text.Checker].ToString().Trim(); //审核人
objzx_TextEN.IdCurrEduCls = objRow[conzx_Text.IdCurrEduCls] == DBNull.Value ? null : objRow[conzx_Text.IdCurrEduCls].ToString().Trim(); //教学班流水号
objzx_TextEN.Keyword = objRow[conzx_Text.Keyword] == DBNull.Value ? null : objRow[conzx_Text.Keyword].ToString().Trim(); //关键字
objzx_TextEN.LiteratureSources = objRow[conzx_Text.LiteratureSources] == DBNull.Value ? null : objRow[conzx_Text.LiteratureSources].ToString().Trim(); //文献来源
objzx_TextEN.LiteratureLink = objRow[conzx_Text.LiteratureLink] == DBNull.Value ? null : objRow[conzx_Text.LiteratureLink].ToString().Trim(); //文献链接
objzx_TextEN.UploadfileUrl = objRow[conzx_Text.UploadfileUrl] == DBNull.Value ? null : objRow[conzx_Text.UploadfileUrl].ToString().Trim(); //文件地址
objzx_TextEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[conzx_Text.IsSubmit].ToString().Trim()); //是否提交
objzx_TextEN.IsChecked = clsEntityBase2.TransNullToBool_S(objRow[conzx_Text.IsChecked].ToString().Trim()); //是否检查
objzx_TextEN.BrowseNumber = objRow[conzx_Text.BrowseNumber] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_Text.BrowseNumber].ToString().Trim()); //浏览量
objzx_TextEN.VCount = objRow[conzx_Text.VCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_Text.VCount].ToString().Trim()); //VCount
objzx_TextEN.VoteCount = objRow[conzx_Text.VoteCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_Text.VoteCount].ToString().Trim()); //点赞计数
objzx_TextEN.CollectionCount = objRow[conzx_Text.CollectionCount] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_Text.CollectionCount].ToString().Trim()); //收藏数量
objzx_TextEN.DownloadCount = objRow[conzx_Text.DownloadCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_Text.DownloadCount].ToString().Trim()); //下载数
objzx_TextEN.AttachmentCount = objRow[conzx_Text.AttachmentCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_Text.AttachmentCount].ToString().Trim()); //附件计数
objzx_TextEN.AppraiseCount = objRow[conzx_Text.AppraiseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_Text.AppraiseCount].ToString().Trim()); //评论数
objzx_TextEN.Score = objRow[conzx_Text.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conzx_Text.Score].ToString().Trim()); //评分
objzx_TextEN.StuScore = objRow[conzx_Text.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conzx_Text.StuScore].ToString().Trim()); //学生平均分
objzx_TextEN.TeaScore = objRow[conzx_Text.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conzx_Text.TeaScore].ToString().Trim()); //教师评分
objzx_TextEN.TextTypeId = objRow[conzx_Text.TextTypeId] == DBNull.Value ? null : objRow[conzx_Text.TextTypeId].ToString().Trim(); //TextTypeId
objzx_TextEN.TextStatusId = objRow[conzx_Text.TextStatusId] == DBNull.Value ? null : objRow[conzx_Text.TextStatusId].ToString().Trim(); //TextStatusId
objzx_TextEN.VersionCount = objRow[conzx_Text.VersionCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_Text.VersionCount].ToString().Trim()); //版本统计
objzx_TextEN.IsPublic = clsEntityBase2.TransNullToBool_S(objRow[conzx_Text.IsPublic].ToString().Trim()); //是否公开
objzx_TextEN.zxShareId = objRow[conzx_Text.zxShareId] == DBNull.Value ? null : objRow[conzx_Text.zxShareId].ToString().Trim(); //分享Id
objzx_TextEN.SchoolTerm = objRow[conzx_Text.SchoolTerm] == DBNull.Value ? null : objRow[conzx_Text.SchoolTerm].ToString().Trim(); //学期
objzx_TextEN.GradeId = objRow[conzx_Text.GradeId] == DBNull.Value ? null : objRow[conzx_Text.GradeId].ToString().Trim(); //年级代号
objzx_TextEN.Memo = objRow[conzx_Text.Memo] == DBNull.Value ? null : objRow[conzx_Text.Memo].ToString().Trim(); //备注
objzx_TextEN.UnitId = objRow[conzx_Text.UnitId] == DBNull.Value ? null : objRow[conzx_Text.UnitId].ToString().Trim(); //UnitId
objzx_TextEN.PaperQCount = objRow[conzx_Text.PaperQCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_Text.PaperQCount].ToString().Trim()); //论文答疑数
objzx_TextEN.SubVCount = objRow[conzx_Text.SubVCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_Text.SubVCount].ToString().Trim()); //论文子观点数
objzx_TextEN.TagsCount = objRow[conzx_Text.TagsCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_Text.TagsCount].ToString().Trim()); //论文标注数
objzx_TextEN.TeaQCount = objRow[conzx_Text.TeaQCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_Text.TeaQCount].ToString().Trim()); //教师提问数
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objzx_TextEN.TextId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objzx_TextEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objzx_TextEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool Getzx_Text(ref clszx_TextEN objzx_TextEN)
{
bool bolResult = zx_TextDA.Getzx_Text(ref objzx_TextEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "strTextId">表关键字</param>
 /// <returns>表对象</returns>
public static clszx_TextEN GetObjByTextId(string strTextId)
{
if (strTextId.IndexOf(' ') >=0)
{
var strMsg = string.Format("(errid:Busi000079)在表中,关键字[strTextId]中不能有空格!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
if (string.IsNullOrEmpty(strTextId) == true)
{
var strMsg = string.Format("(errid:Busi000020)在表中,关键字[strTextId]不能为空!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
clszx_TextEN objzx_TextEN = zx_TextDA.GetObjByTextId(strTextId);
return objzx_TextEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clszx_TextEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clszx_TextEN objzx_TextEN = zx_TextDA.GetFirstObj(strWhereCond);
 return objzx_TextEN;
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
public static clszx_TextEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clszx_TextEN objzx_TextEN = zx_TextDA.GetObjByDataRow(objRow);
 return objzx_TextEN;
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
public static clszx_TextEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clszx_TextEN objzx_TextEN = zx_TextDA.GetObjByDataRow(objRow);
 return objzx_TextEN;
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
 /// <param name = "strTextId">所给的关键字</param>
 /// <param name = "lstzx_TextObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clszx_TextEN GetObjByTextIdFromList(string strTextId, List<clszx_TextEN> lstzx_TextObjLst)
{
foreach (clszx_TextEN objzx_TextEN in lstzx_TextObjLst)
{
if (objzx_TextEN.TextId == strTextId)
{
return objzx_TextEN;
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
 string strMaxTextId;
 try
 {
 strMaxTextId = clszx_TextDA.GetMaxStrId();
 return strMaxTextId;
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
 string strTextId;
 try
 {
 strTextId = new clszx_TextDA().GetFirstID(strWhereCond);
 return strTextId;
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
 arrList = zx_TextDA.GetID(strWhereCond);
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
bool bolIsExist = zx_TextDA.IsExistCondRec(strWhereCond);
return bolIsExist;
}

 /// <summary>
 /// 判断当前表中是否存在给定关键字值的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExist)
 /// </summary>
 /// <param name = "strTextId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public static bool IsExist(string strTextId)
{
if (string.IsNullOrEmpty(strTextId) == true)
{
var strMsg = string.Format("(errid:Busi000027)在表中,关键字[strTextId]不能为空!!(from {0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
//检测记录是否存在
bool bolIsExist = zx_TextDA.IsExist(strTextId);
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
 bolIsExist = clszx_TextDA.IsExistTable();
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
 bolIsExist = zx_TextDA.IsExistTable(strTabName);
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
 /// <param name = "objzx_TextEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecordBySql2(clszx_TextEN objzx_TextEN)
{
if (objzx_TextEN.CheckUniqueness() == false)
{
var strMsg = string.Format("记录已经存在!教学班流水号 = [{0}]的数据已经存在!(in clszx_TextBL.AddNewRecordBySql2)", objzx_TextEN.IdCurrEduCls);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objzx_TextEN.TextId) == true || clszx_TextBL.IsExist(objzx_TextEN.TextId) == true)
 {
     objzx_TextEN.TextId = clszx_TextBL.GetMaxStrId_S();
 }
bool bolResult = zx_TextDA.AddNewRecordBySQL2(objzx_TextEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clszx_TextBL.ReFreshCache(objzx_TextEN.IdCurrEduCls);

if (clszx_TextBL.relatedActions != null)
{
clszx_TextBL.relatedActions.UpdRelaTabDate(objzx_TextEN.TextId, "SetUpdDate");
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
 /// <param name = "objzx_TextEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordBySql2WithReturnKey(clszx_TextEN objzx_TextEN)
{
if (objzx_TextEN.CheckUniqueness() == false)
{
var strMsg = string.Format("记录已经存在!教学班流水号 = [{0}]的数据已经存在!(in clszx_TextBL.AddNewRecordBySql2WithReturnKey)", objzx_TextEN.IdCurrEduCls);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objzx_TextEN.TextId) == true || clszx_TextBL.IsExist(objzx_TextEN.TextId) == true)
 {
     objzx_TextEN.TextId = clszx_TextBL.GetMaxStrId_S();
 }
string strKey = zx_TextDA.AddNewRecordBySQL2WithReturnKey(objzx_TextEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clszx_TextBL.ReFreshCache(objzx_TextEN.IdCurrEduCls);

if (clszx_TextBL.relatedActions != null)
{
clszx_TextBL.relatedActions.UpdRelaTabDate(objzx_TextEN.TextId, "SetUpdDate");
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
 /// <param name = "objzx_TextEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(clszx_TextEN objzx_TextEN)
{
try
{
bool bolResult = zx_TextDA.Update(objzx_TextEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clszx_TextBL.ReFreshCache(objzx_TextEN.IdCurrEduCls);

if (clszx_TextBL.relatedActions != null)
{
clszx_TextBL.relatedActions.UpdRelaTabDate(objzx_TextEN.TextId, "SetUpdDate");
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
 /// <param name = "objzx_TextEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateBySql2(clszx_TextEN objzx_TextEN)
{
 if (string.IsNullOrEmpty(objzx_TextEN.TextId) == true)
 {
var strMsg = string.Format("(errid:Busi000065)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = zx_TextDA.UpdateBySql2(objzx_TextEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clszx_TextBL.ReFreshCache(objzx_TextEN.IdCurrEduCls);

if (clszx_TextBL.relatedActions != null)
{
clszx_TextBL.relatedActions.UpdRelaTabDate(objzx_TextEN.TextId, "SetUpdDate");
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
 /// <param name = "strTextId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int DelRecord(string strTextId)
{
try
{
 clszx_TextEN objzx_TextEN = clszx_TextBL.GetObjByTextId(strTextId);

if (clszx_TextBL.relatedActions != null)
{
clszx_TextBL.relatedActions.UpdRelaTabDate(objzx_TextEN.TextId, "SetUpdDate");
}
if (objzx_TextEN != null)
{
int intRecNum = zx_TextDA.DelRecord(strTextId);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
ReFreshCache(objzx_TextEN.IdCurrEduCls);
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
/// <param name="strTextId">表关键字</param>
 /// <param name = "strIdCurrEduCls">缓存的分类字段</param>
/// <returns></returns>
public static bool DelRecordEx(string strTextId , string strIdCurrEduCls)
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clszx_TextDA.GetSpecSQLObj();
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
//删除与表:[zx_Text]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conzx_Text.TextId,
//strTextId);
//        clszx_TextBL.Delzx_TextsByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clszx_TextBL.DelRecord(strTextId, strIdCurrEduCls, objConnection, objSqlTransaction);
objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clszx_TextBLEx", "DelRecordEx", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("扩展删除记录出错:{0}!keyId = {1}.({2})",
objException.Message,
strTextId, clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "strTextId">给定的关键字值</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回删除是否成功?</returns>
public static bool DelRecord(string strTextId, string strIdCurrEduCls, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
if (clszx_TextBL.relatedActions != null)
{
clszx_TextBL.relatedActions.UpdRelaTabDate(strTextId, "UpdRelaTabDate");
}
bool bolResult = zx_TextDA.DelRecord(strTextId,objSqlConnection,objSqlTransaction);
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
 /// <param name = "arrTextIdLst">给定的关键字值列表</param>
 /// <returns>返回删除的记录数</returns>
public static int Delzx_Texts(List<string> arrTextIdLst)
{
if (arrTextIdLst.Count == 0) return 0;
try
{
if (clszx_TextBL.relatedActions != null)
{
foreach (var strTextId in arrTextIdLst)
{
clszx_TextBL.relatedActions.UpdRelaTabDate(strTextId, "UpdRelaTabDate");
}
}
 clszx_TextEN objzx_TextEN = clszx_TextBL.GetObjByTextId(arrTextIdLst[0]);
int intDelRecNum = zx_TextDA.Delzx_Text(arrTextIdLst);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
ReFreshCache(objzx_TextEN.IdCurrEduCls);
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
public static int Delzx_TextsByCond(string strWhereCond)
{
try
{
if (clszx_TextBL.relatedActions != null)
{
List<string> arrTextId = GetPrimaryKeyID_S(strWhereCond);
foreach (var strTextId in arrTextId)
{
clszx_TextBL.relatedActions.UpdRelaTabDate(strTextId, "UpdRelaTabDate");
}
}
List<string> arrIdCurrEduCls = GetFldValue(conzx_Text.IdCurrEduCls, strWhereCond);
int intRecNum = zx_TextDA.Delzx_Text(strWhereCond);
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
/// 这里仅仅是演示函数,使用时请复制到扩展类:[zx_Text]中改名为:[DelRecord4MultiTabEx]使用
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DelRecord4MultiTab)
/// </summary>
/// <param name="strTextId">表关键字</param>
 /// <param name = "strIdCurrEduCls">缓存的分类字段</param>
/// <returns></returns>
public static bool DelRecord4MultiTab(string strTextId, string strIdCurrEduCls)
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clszx_TextDA.GetSpecSQLObj();
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
//删除与表:[zx_Text]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conStudent.id_College,
//strid_College);
//        clsStudentBL.DelStudentsByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clszx_TextBL.DelRecord(strTextId, strIdCurrEduCls, objConnection, objSqlTransaction);
                objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clszx_TextBL", "DelRecord4MultiTab", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("删除多表记录出错:{0}!keyId = {1}.({2})",
objException.Message,
strTextId, clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "objzx_TextENS">源对象</param>
 /// <param name = "objzx_TextENT">目标对象</param>
 public static void CopyTo(clszx_TextEN objzx_TextENS, clszx_TextEN objzx_TextENT)
{
try
{
objzx_TextENT.TextId = objzx_TextENS.TextId; //课件Id
objzx_TextENT.TextTitle = objzx_TextENS.TextTitle; //TextTitle
objzx_TextENT.TextContent = objzx_TextENS.TextContent; //TextContent
objzx_TextENT.Edition = objzx_TextENS.Edition; //Edition
objzx_TextENT.Author = objzx_TextENS.Author; //作者
objzx_TextENT.ResearchQuestion = objzx_TextENS.ResearchQuestion; //研究问题
objzx_TextENT.UpdDate = objzx_TextENS.UpdDate; //修改日期
objzx_TextENT.UpdUser = objzx_TextENS.UpdUser; //修改人
objzx_TextENT.CreateDate = objzx_TextENS.CreateDate; //建立日期
objzx_TextENT.Checker = objzx_TextENS.Checker; //审核人
objzx_TextENT.IdCurrEduCls = objzx_TextENS.IdCurrEduCls; //教学班流水号
objzx_TextENT.Keyword = objzx_TextENS.Keyword; //关键字
objzx_TextENT.LiteratureSources = objzx_TextENS.LiteratureSources; //文献来源
objzx_TextENT.LiteratureLink = objzx_TextENS.LiteratureLink; //文献链接
objzx_TextENT.UploadfileUrl = objzx_TextENS.UploadfileUrl; //文件地址
objzx_TextENT.IsSubmit = objzx_TextENS.IsSubmit; //是否提交
objzx_TextENT.IsChecked = objzx_TextENS.IsChecked; //是否检查
objzx_TextENT.BrowseNumber = objzx_TextENS.BrowseNumber; //浏览量
objzx_TextENT.VCount = objzx_TextENS.VCount; //VCount
objzx_TextENT.VoteCount = objzx_TextENS.VoteCount; //点赞计数
objzx_TextENT.CollectionCount = objzx_TextENS.CollectionCount; //收藏数量
objzx_TextENT.DownloadCount = objzx_TextENS.DownloadCount; //下载数
objzx_TextENT.AttachmentCount = objzx_TextENS.AttachmentCount; //附件计数
objzx_TextENT.AppraiseCount = objzx_TextENS.AppraiseCount; //评论数
objzx_TextENT.Score = objzx_TextENS.Score; //评分
objzx_TextENT.StuScore = objzx_TextENS.StuScore; //学生平均分
objzx_TextENT.TeaScore = objzx_TextENS.TeaScore; //教师评分
objzx_TextENT.TextTypeId = objzx_TextENS.TextTypeId; //TextTypeId
objzx_TextENT.TextStatusId = objzx_TextENS.TextStatusId; //TextStatusId
objzx_TextENT.VersionCount = objzx_TextENS.VersionCount; //版本统计
objzx_TextENT.IsPublic = objzx_TextENS.IsPublic; //是否公开
objzx_TextENT.zxShareId = objzx_TextENS.zxShareId; //分享Id
objzx_TextENT.SchoolTerm = objzx_TextENS.SchoolTerm; //学期
objzx_TextENT.GradeId = objzx_TextENS.GradeId; //年级代号
objzx_TextENT.Memo = objzx_TextENS.Memo; //备注
objzx_TextENT.UnitId = objzx_TextENS.UnitId; //UnitId
objzx_TextENT.PaperQCount = objzx_TextENS.PaperQCount; //论文答疑数
objzx_TextENT.SubVCount = objzx_TextENS.SubVCount; //论文子观点数
objzx_TextENT.TagsCount = objzx_TextENS.TagsCount; //论文标注数
objzx_TextENT.TeaQCount = objzx_TextENS.TeaQCount; //教师提问数
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
 /// <param name = "objzx_TextEN">源简化对象</param>
 public static void SetUpdFlag(clszx_TextEN objzx_TextEN)
{
try
{
objzx_TextEN.ClearUpdateState();
   string strsfUpdFldSetStr = objzx_TextEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(conzx_Text.TextId, new clsStrCompareIgnoreCase())  ==  true)
{
objzx_TextEN.TextId = objzx_TextEN.TextId; //课件Id
}
if (arrFldSet.Contains(conzx_Text.TextTitle, new clsStrCompareIgnoreCase())  ==  true)
{
objzx_TextEN.TextTitle = objzx_TextEN.TextTitle; //TextTitle
}
if (arrFldSet.Contains(conzx_Text.TextContent, new clsStrCompareIgnoreCase())  ==  true)
{
objzx_TextEN.TextContent = objzx_TextEN.TextContent == "[null]" ? null :  objzx_TextEN.TextContent; //TextContent
}
if (arrFldSet.Contains(conzx_Text.Edition, new clsStrCompareIgnoreCase())  ==  true)
{
objzx_TextEN.Edition = objzx_TextEN.Edition == "[null]" ? null :  objzx_TextEN.Edition; //Edition
}
if (arrFldSet.Contains(conzx_Text.Author, new clsStrCompareIgnoreCase())  ==  true)
{
objzx_TextEN.Author = objzx_TextEN.Author == "[null]" ? null :  objzx_TextEN.Author; //作者
}
if (arrFldSet.Contains(conzx_Text.ResearchQuestion, new clsStrCompareIgnoreCase())  ==  true)
{
objzx_TextEN.ResearchQuestion = objzx_TextEN.ResearchQuestion == "[null]" ? null :  objzx_TextEN.ResearchQuestion; //研究问题
}
if (arrFldSet.Contains(conzx_Text.UpdDate, new clsStrCompareIgnoreCase())  ==  true)
{
objzx_TextEN.UpdDate = objzx_TextEN.UpdDate == "[null]" ? null :  objzx_TextEN.UpdDate; //修改日期
}
if (arrFldSet.Contains(conzx_Text.UpdUser, new clsStrCompareIgnoreCase())  ==  true)
{
objzx_TextEN.UpdUser = objzx_TextEN.UpdUser == "[null]" ? null :  objzx_TextEN.UpdUser; //修改人
}
if (arrFldSet.Contains(conzx_Text.CreateDate, new clsStrCompareIgnoreCase())  ==  true)
{
objzx_TextEN.CreateDate = objzx_TextEN.CreateDate == "[null]" ? null :  objzx_TextEN.CreateDate; //建立日期
}
if (arrFldSet.Contains(conzx_Text.Checker, new clsStrCompareIgnoreCase())  ==  true)
{
objzx_TextEN.Checker = objzx_TextEN.Checker == "[null]" ? null :  objzx_TextEN.Checker; //审核人
}
if (arrFldSet.Contains(conzx_Text.IdCurrEduCls, new clsStrCompareIgnoreCase())  ==  true)
{
objzx_TextEN.IdCurrEduCls = objzx_TextEN.IdCurrEduCls == "[null]" ? null :  objzx_TextEN.IdCurrEduCls; //教学班流水号
}
if (arrFldSet.Contains(conzx_Text.Keyword, new clsStrCompareIgnoreCase())  ==  true)
{
objzx_TextEN.Keyword = objzx_TextEN.Keyword == "[null]" ? null :  objzx_TextEN.Keyword; //关键字
}
if (arrFldSet.Contains(conzx_Text.LiteratureSources, new clsStrCompareIgnoreCase())  ==  true)
{
objzx_TextEN.LiteratureSources = objzx_TextEN.LiteratureSources == "[null]" ? null :  objzx_TextEN.LiteratureSources; //文献来源
}
if (arrFldSet.Contains(conzx_Text.LiteratureLink, new clsStrCompareIgnoreCase())  ==  true)
{
objzx_TextEN.LiteratureLink = objzx_TextEN.LiteratureLink == "[null]" ? null :  objzx_TextEN.LiteratureLink; //文献链接
}
if (arrFldSet.Contains(conzx_Text.UploadfileUrl, new clsStrCompareIgnoreCase())  ==  true)
{
objzx_TextEN.UploadfileUrl = objzx_TextEN.UploadfileUrl == "[null]" ? null :  objzx_TextEN.UploadfileUrl; //文件地址
}
if (arrFldSet.Contains(conzx_Text.IsSubmit, new clsStrCompareIgnoreCase())  ==  true)
{
objzx_TextEN.IsSubmit = objzx_TextEN.IsSubmit; //是否提交
}
if (arrFldSet.Contains(conzx_Text.IsChecked, new clsStrCompareIgnoreCase())  ==  true)
{
objzx_TextEN.IsChecked = objzx_TextEN.IsChecked; //是否检查
}
if (arrFldSet.Contains(conzx_Text.BrowseNumber, new clsStrCompareIgnoreCase())  ==  true)
{
objzx_TextEN.BrowseNumber = objzx_TextEN.BrowseNumber; //浏览量
}
if (arrFldSet.Contains(conzx_Text.VCount, new clsStrCompareIgnoreCase())  ==  true)
{
objzx_TextEN.VCount = objzx_TextEN.VCount; //VCount
}
if (arrFldSet.Contains(conzx_Text.VoteCount, new clsStrCompareIgnoreCase())  ==  true)
{
objzx_TextEN.VoteCount = objzx_TextEN.VoteCount; //点赞计数
}
if (arrFldSet.Contains(conzx_Text.CollectionCount, new clsStrCompareIgnoreCase())  ==  true)
{
objzx_TextEN.CollectionCount = objzx_TextEN.CollectionCount; //收藏数量
}
if (arrFldSet.Contains(conzx_Text.DownloadCount, new clsStrCompareIgnoreCase())  ==  true)
{
objzx_TextEN.DownloadCount = objzx_TextEN.DownloadCount; //下载数
}
if (arrFldSet.Contains(conzx_Text.AttachmentCount, new clsStrCompareIgnoreCase())  ==  true)
{
objzx_TextEN.AttachmentCount = objzx_TextEN.AttachmentCount; //附件计数
}
if (arrFldSet.Contains(conzx_Text.AppraiseCount, new clsStrCompareIgnoreCase())  ==  true)
{
objzx_TextEN.AppraiseCount = objzx_TextEN.AppraiseCount; //评论数
}
if (arrFldSet.Contains(conzx_Text.Score, new clsStrCompareIgnoreCase())  ==  true)
{
objzx_TextEN.Score = objzx_TextEN.Score; //评分
}
if (arrFldSet.Contains(conzx_Text.StuScore, new clsStrCompareIgnoreCase())  ==  true)
{
objzx_TextEN.StuScore = objzx_TextEN.StuScore; //学生平均分
}
if (arrFldSet.Contains(conzx_Text.TeaScore, new clsStrCompareIgnoreCase())  ==  true)
{
objzx_TextEN.TeaScore = objzx_TextEN.TeaScore; //教师评分
}
if (arrFldSet.Contains(conzx_Text.TextTypeId, new clsStrCompareIgnoreCase())  ==  true)
{
objzx_TextEN.TextTypeId = objzx_TextEN.TextTypeId == "[null]" ? null :  objzx_TextEN.TextTypeId; //TextTypeId
}
if (arrFldSet.Contains(conzx_Text.TextStatusId, new clsStrCompareIgnoreCase())  ==  true)
{
objzx_TextEN.TextStatusId = objzx_TextEN.TextStatusId == "[null]" ? null :  objzx_TextEN.TextStatusId; //TextStatusId
}
if (arrFldSet.Contains(conzx_Text.VersionCount, new clsStrCompareIgnoreCase())  ==  true)
{
objzx_TextEN.VersionCount = objzx_TextEN.VersionCount; //版本统计
}
if (arrFldSet.Contains(conzx_Text.IsPublic, new clsStrCompareIgnoreCase())  ==  true)
{
objzx_TextEN.IsPublic = objzx_TextEN.IsPublic; //是否公开
}
if (arrFldSet.Contains(conzx_Text.zxShareId, new clsStrCompareIgnoreCase())  ==  true)
{
objzx_TextEN.zxShareId = objzx_TextEN.zxShareId == "[null]" ? null :  objzx_TextEN.zxShareId; //分享Id
}
if (arrFldSet.Contains(conzx_Text.SchoolTerm, new clsStrCompareIgnoreCase())  ==  true)
{
objzx_TextEN.SchoolTerm = objzx_TextEN.SchoolTerm == "[null]" ? null :  objzx_TextEN.SchoolTerm; //学期
}
if (arrFldSet.Contains(conzx_Text.GradeId, new clsStrCompareIgnoreCase())  ==  true)
{
objzx_TextEN.GradeId = objzx_TextEN.GradeId == "[null]" ? null :  objzx_TextEN.GradeId; //年级代号
}
if (arrFldSet.Contains(conzx_Text.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objzx_TextEN.Memo = objzx_TextEN.Memo == "[null]" ? null :  objzx_TextEN.Memo; //备注
}
if (arrFldSet.Contains(conzx_Text.UnitId, new clsStrCompareIgnoreCase())  ==  true)
{
objzx_TextEN.UnitId = objzx_TextEN.UnitId == "[null]" ? null :  objzx_TextEN.UnitId; //UnitId
}
if (arrFldSet.Contains(conzx_Text.PaperQCount, new clsStrCompareIgnoreCase())  ==  true)
{
objzx_TextEN.PaperQCount = objzx_TextEN.PaperQCount; //论文答疑数
}
if (arrFldSet.Contains(conzx_Text.SubVCount, new clsStrCompareIgnoreCase())  ==  true)
{
objzx_TextEN.SubVCount = objzx_TextEN.SubVCount; //论文子观点数
}
if (arrFldSet.Contains(conzx_Text.TagsCount, new clsStrCompareIgnoreCase())  ==  true)
{
objzx_TextEN.TagsCount = objzx_TextEN.TagsCount; //论文标注数
}
if (arrFldSet.Contains(conzx_Text.TeaQCount, new clsStrCompareIgnoreCase())  ==  true)
{
objzx_TextEN.TeaQCount = objzx_TextEN.TeaQCount; //教师提问数
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
 /// <param name = "objzx_TextEN">源简化对象</param>
 public static void AccessFldValueNull(clszx_TextEN objzx_TextEN)
{
try
{
if (objzx_TextEN.TextContent == "[null]") objzx_TextEN.TextContent = null; //TextContent
if (objzx_TextEN.Edition == "[null]") objzx_TextEN.Edition = null; //Edition
if (objzx_TextEN.Author == "[null]") objzx_TextEN.Author = null; //作者
if (objzx_TextEN.ResearchQuestion == "[null]") objzx_TextEN.ResearchQuestion = null; //研究问题
if (objzx_TextEN.UpdDate == "[null]") objzx_TextEN.UpdDate = null; //修改日期
if (objzx_TextEN.UpdUser == "[null]") objzx_TextEN.UpdUser = null; //修改人
if (objzx_TextEN.CreateDate == "[null]") objzx_TextEN.CreateDate = null; //建立日期
if (objzx_TextEN.Checker == "[null]") objzx_TextEN.Checker = null; //审核人
if (objzx_TextEN.IdCurrEduCls == "[null]") objzx_TextEN.IdCurrEduCls = null; //教学班流水号
if (objzx_TextEN.Keyword == "[null]") objzx_TextEN.Keyword = null; //关键字
if (objzx_TextEN.LiteratureSources == "[null]") objzx_TextEN.LiteratureSources = null; //文献来源
if (objzx_TextEN.LiteratureLink == "[null]") objzx_TextEN.LiteratureLink = null; //文献链接
if (objzx_TextEN.UploadfileUrl == "[null]") objzx_TextEN.UploadfileUrl = null; //文件地址
if (objzx_TextEN.TextTypeId == "[null]") objzx_TextEN.TextTypeId = null; //TextTypeId
if (objzx_TextEN.TextStatusId == "[null]") objzx_TextEN.TextStatusId = null; //TextStatusId
if (objzx_TextEN.zxShareId == "[null]") objzx_TextEN.zxShareId = null; //分享Id
if (objzx_TextEN.SchoolTerm == "[null]") objzx_TextEN.SchoolTerm = null; //学期
if (objzx_TextEN.GradeId == "[null]") objzx_TextEN.GradeId = null; //年级代号
if (objzx_TextEN.Memo == "[null]") objzx_TextEN.Memo = null; //备注
if (objzx_TextEN.UnitId == "[null]") objzx_TextEN.UnitId = null; //UnitId
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
public static void CheckPropertyNew(clszx_TextEN objzx_TextEN)
{
 zx_TextDA.CheckPropertyNew(objzx_TextEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(clszx_TextEN objzx_TextEN)
{
 zx_TextDA.CheckProperty4Condition(objzx_TextEN);
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
if (clszx_TextBL.objCommFun4BL == null)
{
strMsg = string.Format("类clszx_TextBL没有刷新缓存机制(clszx_TextBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by TextId");
//if (arrzx_TextObjLstCache == null)
//{
//arrzx_TextObjLstCache = zx_TextDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "strTextId">所给的关键字</param>
 /// <param name = "strIdCurrEduCls">缓存的分类字段</param>
 /// <returns>根据关键字获取的对象</returns>
public static clszx_TextEN GetObjByTextIdCache(string strTextId, string strIdCurrEduCls)
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
string strKey = string.Format("{0}_{1}", clszx_TextEN._CurrTabName, strIdCurrEduCls);
List<clszx_TextEN> arrzx_TextObjLstCache = GetObjLstCache(strIdCurrEduCls);
IEnumerable <clszx_TextEN> arrzx_TextObjLst_Sel =
arrzx_TextObjLstCache
.Where(x=> x.TextId == strTextId 
);
if (arrzx_TextObjLst_Sel.Count() == 0)
{
   clszx_TextEN obj = clszx_TextBL.GetObjByTextId(strTextId);
   if (obj != null)
 {
if (obj.IdCurrEduCls == strIdCurrEduCls)
{
CacheHelper.Remove(strKey);
     return obj;
}
else
{
string strMsg = string.Format("错误: 关键字:{0}不属于分类:{1},请检查!(In {2})", strTextId, strIdCurrEduCls, clsStackTrace.GetCurrClassFunction());
clsSysParaEN.objLog.WriteDebugLog(strMsg);
throw new Exception(strMsg);
}
 }
return null;
}
return arrzx_TextObjLst_Sel.First();
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clszx_TextEN> GetAllzx_TextObjLstCache(string strIdCurrEduCls)
{
//获取缓存中的对象列表
List<clszx_TextEN> arrzx_TextObjLstCache = GetObjLstCache(strIdCurrEduCls); 
return arrzx_TextObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clszx_TextEN> GetObjLstCache(string strIdCurrEduCls)
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
string strKey = string.Format("{0}_{1}", clszx_TextEN._CurrTabName, strIdCurrEduCls);
string strCondition = string.Format("IdCurrEduCls='{0}'", strIdCurrEduCls);
List<clszx_TextEN> arrzx_TextObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst(strCondition); });
return arrzx_TextObjLstCache;
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
string strKey = string.Format("{0}_{1}", clszx_TextEN._CurrTabName, strIdCurrEduCls);
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
if (clszx_TextBL.objCommFun4BL != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}_{1}", clszx_TextEN._CurrTabName, strIdCurrEduCls);
CacheHelper.Remove(strKey);
clszx_TextBL.objCommFun4BL.ReFreshCache(strIdCurrEduCls);
}
}


 #endregion 缓存操作


 #region 检查唯一性

 /// <summary>
 /// 获取检查唯一性条件串(Uniqueness)--zx_Text(中学课件表)
 /// 唯一性条件:id_CurrEduCls
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetUniquenessConditionString)
 /// </summary>
 /// <param name = "objzx_TextEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(clszx_TextEN objzx_TextEN)
{
//检测记录是否存在
string strResult = zx_TextDA.GetUniCondStr(objzx_TextEN);
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
public static string Func(string strInFldName, string strOutFldName, string strTextId, string strIdCurrEduCls)
{
if (strInFldName != conzx_Text.TextId)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (conzx_Text.AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", conzx_Text.AttributeName));
throw new Exception(strMsg);
}
var objzx_Text = clszx_TextBL.GetObjByTextIdCache(strTextId, strIdCurrEduCls);
if (objzx_Text == null) return "";
return objzx_Text[strOutFldName].ToString();
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
int intRecCount = clszx_TextDA.GetRecCount(strTabName);
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
int intRecCount = clszx_TextDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clszx_TextDA.GetRecCount();
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
int intRecCount = clszx_TextDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objzx_TextCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clszx_TextEN objzx_TextCond)
{
 string strIdCurrEduCls = objzx_TextCond.IdCurrEduCls;
 if (string.IsNullOrEmpty(strIdCurrEduCls) == true)
{
string strMsg = string.Format("(errid:Busi000174)在表中,缓存分类字段值不能为空!(clszx_TextBL:GetRecCountByCondCache)");
throw new Exception(strMsg);
}
List<clszx_TextEN> arrObjLstCache = GetObjLstCache(strIdCurrEduCls);
IEnumerable <clszx_TextEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conzx_Text.AttributeName)
{
if (objzx_TextCond.IsUpdated(strFldName) == false) continue;
if (objzx_TextCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objzx_TextCond[strFldName].ToString());
}
else
{
if (objzx_TextCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objzx_TextCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objzx_TextCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objzx_TextCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objzx_TextCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objzx_TextCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objzx_TextCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objzx_TextCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objzx_TextCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objzx_TextCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objzx_TextCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objzx_TextCond[strFldName]));
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
 List<string> arrList = clszx_TextDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = zx_TextDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = zx_TextDA.GetFldValueNoDistinct(strFldName, strWhereCond);
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
int intRecCount = zx_TextDA.SetFldValue(strFldName, strValue, strWhereCond);
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
int intRecCount = clszx_TextDA.SetFldValue(clszx_TextEN._CurrTabName, strFldName, fltValue, strWhereCond);
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
int intRecCount = zx_TextDA.SetFldValue( strFldName, intValue, strWhereCond);
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
int intRecCount = clszx_TextDA.SetFldValue(strTabName, strFldName, strValue, strWhereCond);
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
int intRecCount = clszx_TextDA.SetFldValue(strTabName, strFldName, intValue, strWhereCond);
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
int intRecCount = clszx_TextDA.SetFldValue(strTabName, strFldName, fltValue, strWhereCond);
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
  strCreateTabCode.Append("CREATE table [dbo].[zx_Text] "); 
 strCreateTabCode.Append(" ( "); 
 // /**课件Id*/ 
 strCreateTabCode.Append(" TextId char(8) primary key, "); 
 // /**TextTitle*/ 
 strCreateTabCode.Append(" TextTitle varchar(500) not Null, "); 
 // /**TextContent*/ 
 strCreateTabCode.Append(" TextContent text Null, "); 
 // /**Edition*/ 
 strCreateTabCode.Append(" Edition varchar(100) Null, "); 
 // /**作者*/ 
 strCreateTabCode.Append(" Author varchar(200) Null, "); 
 // /**研究问题*/ 
 strCreateTabCode.Append(" ResearchQuestion varchar(2000) Null, "); 
 // /**修改日期*/ 
 strCreateTabCode.Append(" UpdDate varchar(20) Null, "); 
 // /**修改人*/ 
 strCreateTabCode.Append(" UpdUser varchar(20) Null, "); 
 // /**建立日期*/ 
 strCreateTabCode.Append(" CreateDate varchar(20) Null, "); 
 // /**审核人*/ 
 strCreateTabCode.Append(" Checker varchar(20) Null, "); 
 // /**教学班流水号*/ 
 strCreateTabCode.Append(" IdCurrEduCls char(8) Null, "); 
 // /**关键字*/ 
 strCreateTabCode.Append(" Keyword varchar(1000) Null, "); 
 // /**文献来源*/ 
 strCreateTabCode.Append(" LiteratureSources varchar(1000) Null, "); 
 // /**文献链接*/ 
 strCreateTabCode.Append(" LiteratureLink varchar(1000) Null, "); 
 // /**文件地址*/ 
 strCreateTabCode.Append(" UploadfileUrl varchar(1000) Null, "); 
 // /**是否提交*/ 
 strCreateTabCode.Append(" IsSubmit bit Null, "); 
 // /**是否检查*/ 
 strCreateTabCode.Append(" IsChecked bit Null, "); 
 // /**浏览量*/ 
 strCreateTabCode.Append(" BrowseNumber int Null, "); 
 // /**VCount*/ 
 strCreateTabCode.Append(" VCount int Null, "); 
 // /**点赞计数*/ 
 strCreateTabCode.Append(" VoteCount int Null, "); 
 // /**收藏数量*/ 
 strCreateTabCode.Append(" CollectionCount bigint Null, "); 
 // /**下载数*/ 
 strCreateTabCode.Append(" DownloadCount int Null, "); 
 // /**附件计数*/ 
 strCreateTabCode.Append(" AttachmentCount int Null, "); 
 // /**评论数*/ 
 strCreateTabCode.Append(" AppraiseCount int Null, "); 
 // /**评分*/ 
 strCreateTabCode.Append(" Score float Null, "); 
 // /**学生平均分*/ 
 strCreateTabCode.Append(" StuScore float Null, "); 
 // /**教师评分*/ 
 strCreateTabCode.Append(" TeaScore float Null, "); 
 // /**TextTypeId*/ 
 strCreateTabCode.Append(" TextTypeId char(2) Null, "); 
 // /**TextStatusId*/ 
 strCreateTabCode.Append(" TextStatusId char(2) Null, "); 
 // /**版本统计*/ 
 strCreateTabCode.Append(" VersionCount int Null, "); 
 // /**是否公开*/ 
 strCreateTabCode.Append(" IsPublic bit Null, "); 
 // /**分享Id*/ 
 strCreateTabCode.Append(" zxShareId char(2) Null, "); 
 // /**学期*/ 
 strCreateTabCode.Append(" SchoolTerm char(1) Null, "); 
 // /**年级代号*/ 
 strCreateTabCode.Append(" GradeId char(4) Null, "); 
 // /**备注*/ 
 strCreateTabCode.Append(" Memo varchar(1000) Null, "); 
 // /**UnitId*/ 
 strCreateTabCode.Append(" UnitId char(4) Null, "); 
 // /**论文答疑数*/ 
 strCreateTabCode.Append(" PaperQCount int Null, "); 
 // /**论文子观点数*/ 
 strCreateTabCode.Append(" SubVCount int Null, "); 
 // /**论文标注数*/ 
 strCreateTabCode.Append(" TagsCount int Null, "); 
 // /**教师提问数*/ 
 strCreateTabCode.Append(" TeaQCount int Null ");
 strCreateTabCode.Append(") "); 
  strCreateTabCode.Append("ON [PRIMARY] ");
  return strCreateTabCode.ToString();
}



 #endregion 表操作
}
 /// <summary>
 /// 中学课件表(zx_Text)
 /// 数据源类型:表
 /// (AutoGCLib.CommFun4BL4CSharp:GeneCode_This)
 /// </summary>
public class  clsCommFun4BL4zx_Text : clsCommFun4BLV2
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
clszx_TextBL.ReFreshThisCache(strIdCurrEduCls);
}
}

}