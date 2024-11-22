
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clszx_TextReadBL
 表名:zx_TextRead(01120716)
 * 版本:2023.11.15.1(服务器:WIN-SRV103-116)
 日期:2023/11/15 22:59:51
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
public static class  clszx_TextReadBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "strTextRId">表关键字</param>
 /// <returns>表对象</returns>
public static clszx_TextReadEN GetObj(this K_TextRId_zx_TextRead myKey)
{
clszx_TextReadEN objzx_TextReadEN = clszx_TextReadBL.zx_TextReadDA.GetObjByTextRId(myKey.Value);
return objzx_TextReadEN;
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_AddNewRecord)
 /// </summary>
 /// <param name = "objzx_TextReadEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clszx_TextReadEN objzx_TextReadEN)
{
if (CheckUniqueness(objzx_TextReadEN) == false)
{
var strMsg = string.Format("记录已经存在!课件Id = [{0}],阅读类型 = [{1}]的数据已经存在!(in clszx_TextReadBL.AddNewRecord)", objzx_TextReadEN.TextId,objzx_TextReadEN.ReadTypeId);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objzx_TextReadEN.TextRId) == true || clszx_TextReadBL.IsExist(objzx_TextReadEN.TextRId) == true)
 {
     objzx_TextReadEN.TextRId = clszx_TextReadBL.GetMaxStrId_S();
 }
bool bolResult = clszx_TextReadBL.zx_TextReadDA.AddNewRecordBySQL2(objzx_TextReadEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clszx_TextReadBL.ReFreshCache(objzx_TextReadEN.IdCurrEduCls);

if (clszx_TextReadBL.relatedActions != null)
{
clszx_TextReadBL.relatedActions.UpdRelaTabDate(objzx_TextReadEN.TextRId, "SetUpdDate");
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
public static bool AddRecordEx(this clszx_TextReadEN objzx_TextReadEN)
{
//操作步骤:
//1、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在
//2、检查唯一性
//3、检查传进去的对象属性是否合法
//4、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
//1、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在

//因为是字符型自增主键,不需要检查主键是否已经存在,在添加时,再获取 最大值作为主键
//if (clszx_TextReadBL.IsExist(objzx_TextReadEN.TextRId))	//判断是否有相同的关键字
//{
//strMsg = "(errid:Busi000151)关键字字段已有相同的值";
//throw new Exception(strMsg);
//}
try
{
 //2、检查传进去的对象属性是否合法
objzx_TextReadEN.CheckPropertyNew();
 ///5.2、检查唯一性
if (objzx_TextReadEN.CheckUniqueness() == false)
{
strMsg = string.Format("(课件Id(TextId)=[{0}],阅读类型(ReadTypeId)=[{1}])已经存在,不能重复!", objzx_TextReadEN.TextId, objzx_TextReadEN.ReadTypeId);
throw new Exception(strMsg);
}
//因为是字符型自增主键,所以在添加时,自动获取主键值。
 if (string.IsNullOrEmpty(objzx_TextReadEN.TextRId) == true || clszx_TextReadBL.IsExist(objzx_TextReadEN.TextRId) == true)
 {
     objzx_TextReadEN.TextRId = clszx_TextReadBL.GetMaxStrId_S();
 }
//6、把数据实体层的数据存贮到数据库中
objzx_TextReadEN.AddNewRecord();
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
 /// <param name = "objzx_TextReadEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static string AddNewRecordWithMaxId(this clszx_TextReadEN objzx_TextReadEN)
{
if (CheckUniqueness(objzx_TextReadEN) == false)
{
var strMsg = string.Format("记录已经存在!课件Id = [{0}],阅读类型 = [{1}]的数据已经存在!(in clszx_TextReadBL.AddNewRecordWithMaxId)", objzx_TextReadEN.TextId,objzx_TextReadEN.ReadTypeId);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objzx_TextReadEN.TextRId) == true || clszx_TextReadBL.IsExist(objzx_TextReadEN.TextRId) == true)
 {
     objzx_TextReadEN.TextRId = clszx_TextReadBL.GetMaxStrId_S();
 }
string strTextRId = clszx_TextReadBL.zx_TextReadDA.AddNewRecordBySQL2WithReturnKey(objzx_TextReadEN);
     objzx_TextReadEN.TextRId = strTextRId;
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clszx_TextReadBL.ReFreshCache(objzx_TextReadEN.IdCurrEduCls);

if (clszx_TextReadBL.relatedActions != null)
{
clszx_TextReadBL.relatedActions.UpdRelaTabDate(objzx_TextReadEN.TextRId, "SetUpdDate");
}
return strTextRId;
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
 /// <param name = "objzx_TextReadEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordWithReturnKey(this clszx_TextReadEN objzx_TextReadEN)
{
if (CheckUniqueness(objzx_TextReadEN) == false)
{
var strMsg = string.Format("记录已经存在!课件Id = [{0}],阅读类型 = [{1}]的数据已经存在!(in clszx_TextReadBL.AddNewRecordWithReturnKey)", objzx_TextReadEN.TextId,objzx_TextReadEN.ReadTypeId);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objzx_TextReadEN.TextRId) == true || clszx_TextReadBL.IsExist(objzx_TextReadEN.TextRId) == true)
 {
     objzx_TextReadEN.TextRId = clszx_TextReadBL.GetMaxStrId_S();
 }
string strKey = clszx_TextReadBL.zx_TextReadDA.AddNewRecordBySQL2WithReturnKey(objzx_TextReadEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clszx_TextReadBL.ReFreshCache(objzx_TextReadEN.IdCurrEduCls);

if (clszx_TextReadBL.relatedActions != null)
{
clszx_TextReadBL.relatedActions.UpdRelaTabDate(objzx_TextReadEN.TextRId, "SetUpdDate");
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
 /// <param name = "objzx_TextReadEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clszx_TextReadEN SetTextId(this clszx_TextReadEN objzx_TextReadEN, string strTextId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTextId, 8, conzx_TextRead.TextId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strTextId, 8, conzx_TextRead.TextId);
}
objzx_TextReadEN.TextId = strTextId; //课件Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objzx_TextReadEN.dicFldComparisonOp.ContainsKey(conzx_TextRead.TextId) == false)
{
objzx_TextReadEN.dicFldComparisonOp.Add(conzx_TextRead.TextId, strComparisonOp);
}
else
{
objzx_TextReadEN.dicFldComparisonOp[conzx_TextRead.TextId] = strComparisonOp;
}
}
return objzx_TextReadEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objzx_TextReadEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clszx_TextReadEN SetReadTypeId(this clszx_TextReadEN objzx_TextReadEN, string strReadTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strReadTypeId, conzx_TextRead.ReadTypeId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strReadTypeId, 2, conzx_TextRead.ReadTypeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strReadTypeId, 2, conzx_TextRead.ReadTypeId);
}
objzx_TextReadEN.ReadTypeId = strReadTypeId; //阅读类型
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objzx_TextReadEN.dicFldComparisonOp.ContainsKey(conzx_TextRead.ReadTypeId) == false)
{
objzx_TextReadEN.dicFldComparisonOp.Add(conzx_TextRead.ReadTypeId, strComparisonOp);
}
else
{
objzx_TextReadEN.dicFldComparisonOp[conzx_TextRead.ReadTypeId] = strComparisonOp;
}
}
return objzx_TextReadEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objzx_TextReadEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clszx_TextReadEN SetIsSubmit(this clszx_TextReadEN objzx_TextReadEN, bool bolIsSubmit, string strComparisonOp="")
	{
objzx_TextReadEN.IsSubmit = bolIsSubmit; //是否提交
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objzx_TextReadEN.dicFldComparisonOp.ContainsKey(conzx_TextRead.IsSubmit) == false)
{
objzx_TextReadEN.dicFldComparisonOp.Add(conzx_TextRead.IsSubmit, strComparisonOp);
}
else
{
objzx_TextReadEN.dicFldComparisonOp[conzx_TextRead.IsSubmit] = strComparisonOp;
}
}
return objzx_TextReadEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objzx_TextReadEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clszx_TextReadEN SetIsPublic(this clszx_TextReadEN objzx_TextReadEN, bool bolIsPublic, string strComparisonOp="")
	{
objzx_TextReadEN.IsPublic = bolIsPublic; //是否公开
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objzx_TextReadEN.dicFldComparisonOp.ContainsKey(conzx_TextRead.IsPublic) == false)
{
objzx_TextReadEN.dicFldComparisonOp.Add(conzx_TextRead.IsPublic, strComparisonOp);
}
else
{
objzx_TextReadEN.dicFldComparisonOp[conzx_TextRead.IsPublic] = strComparisonOp;
}
}
return objzx_TextReadEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objzx_TextReadEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clszx_TextReadEN SetSubmitter(this clszx_TextReadEN objzx_TextReadEN, string strSubmitter, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strSubmitter, 50, conzx_TextRead.Submitter);
}
objzx_TextReadEN.Submitter = strSubmitter; //提交人
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objzx_TextReadEN.dicFldComparisonOp.ContainsKey(conzx_TextRead.Submitter) == false)
{
objzx_TextReadEN.dicFldComparisonOp.Add(conzx_TextRead.Submitter, strComparisonOp);
}
else
{
objzx_TextReadEN.dicFldComparisonOp[conzx_TextRead.Submitter] = strComparisonOp;
}
}
return objzx_TextReadEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objzx_TextReadEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clszx_TextReadEN SetIdCurrEduCls(this clszx_TextReadEN objzx_TextReadEN, string strIdCurrEduCls, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdCurrEduCls, 8, conzx_TextRead.IdCurrEduCls);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdCurrEduCls, 8, conzx_TextRead.IdCurrEduCls);
}
objzx_TextReadEN.IdCurrEduCls = strIdCurrEduCls; //教学班流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objzx_TextReadEN.dicFldComparisonOp.ContainsKey(conzx_TextRead.IdCurrEduCls) == false)
{
objzx_TextReadEN.dicFldComparisonOp.Add(conzx_TextRead.IdCurrEduCls, strComparisonOp);
}
else
{
objzx_TextReadEN.dicFldComparisonOp[conzx_TextRead.IdCurrEduCls] = strComparisonOp;
}
}
return objzx_TextReadEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objzx_TextReadEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clszx_TextReadEN SetQuestionCount(this clszx_TextReadEN objzx_TextReadEN, int? intQuestionCount, string strComparisonOp="")
	{
objzx_TextReadEN.QuestionCount = intQuestionCount; //问题数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objzx_TextReadEN.dicFldComparisonOp.ContainsKey(conzx_TextRead.QuestionCount) == false)
{
objzx_TextReadEN.dicFldComparisonOp.Add(conzx_TextRead.QuestionCount, strComparisonOp);
}
else
{
objzx_TextReadEN.dicFldComparisonOp[conzx_TextRead.QuestionCount] = strComparisonOp;
}
}
return objzx_TextReadEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objzx_TextReadEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clszx_TextReadEN SetCreateDate(this clszx_TextReadEN objzx_TextReadEN, string strCreateDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCreateDate, 20, conzx_TextRead.CreateDate);
}
objzx_TextReadEN.CreateDate = strCreateDate; //建立日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objzx_TextReadEN.dicFldComparisonOp.ContainsKey(conzx_TextRead.CreateDate) == false)
{
objzx_TextReadEN.dicFldComparisonOp.Add(conzx_TextRead.CreateDate, strComparisonOp);
}
else
{
objzx_TextReadEN.dicFldComparisonOp[conzx_TextRead.CreateDate] = strComparisonOp;
}
}
return objzx_TextReadEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objzx_TextReadEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clszx_TextReadEN SetUpdUser(this clszx_TextReadEN objzx_TextReadEN, string strUpdUser, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdUser, 20, conzx_TextRead.UpdUser);
}
objzx_TextReadEN.UpdUser = strUpdUser; //修改人
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objzx_TextReadEN.dicFldComparisonOp.ContainsKey(conzx_TextRead.UpdUser) == false)
{
objzx_TextReadEN.dicFldComparisonOp.Add(conzx_TextRead.UpdUser, strComparisonOp);
}
else
{
objzx_TextReadEN.dicFldComparisonOp[conzx_TextRead.UpdUser] = strComparisonOp;
}
}
return objzx_TextReadEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objzx_TextReadEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clszx_TextReadEN SetUpdDate(this clszx_TextReadEN objzx_TextReadEN, string strUpdDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strUpdDate, conzx_TextRead.UpdDate);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdDate, 20, conzx_TextRead.UpdDate);
}
objzx_TextReadEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objzx_TextReadEN.dicFldComparisonOp.ContainsKey(conzx_TextRead.UpdDate) == false)
{
objzx_TextReadEN.dicFldComparisonOp.Add(conzx_TextRead.UpdDate, strComparisonOp);
}
else
{
objzx_TextReadEN.dicFldComparisonOp[conzx_TextRead.UpdDate] = strComparisonOp;
}
}
return objzx_TextReadEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objzx_TextReadEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clszx_TextReadEN SetMemo(this clszx_TextReadEN objzx_TextReadEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, conzx_TextRead.Memo);
}
objzx_TextReadEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objzx_TextReadEN.dicFldComparisonOp.ContainsKey(conzx_TextRead.Memo) == false)
{
objzx_TextReadEN.dicFldComparisonOp.Add(conzx_TextRead.Memo, strComparisonOp);
}
else
{
objzx_TextReadEN.dicFldComparisonOp[conzx_TextRead.Memo] = strComparisonOp;
}
}
return objzx_TextReadEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objzx_TextReadEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clszx_TextReadEN SetTextRId(this clszx_TextReadEN objzx_TextReadEN, string strTextRId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTextRId, 10, conzx_TextRead.TextRId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strTextRId, 10, conzx_TextRead.TextRId);
}
objzx_TextReadEN.TextRId = strTextRId; //TextRId
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objzx_TextReadEN.dicFldComparisonOp.ContainsKey(conzx_TextRead.TextRId) == false)
{
objzx_TextReadEN.dicFldComparisonOp.Add(conzx_TextRead.TextRId, strComparisonOp);
}
else
{
objzx_TextReadEN.dicFldComparisonOp[conzx_TextRead.TextRId] = strComparisonOp;
}
}
return objzx_TextReadEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objzx_TextReadEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clszx_TextReadEN SetReaderUserId(this clszx_TextReadEN objzx_TextReadEN, string strReaderUserId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strReaderUserId, 20, conzx_TextRead.ReaderUserId);
}
objzx_TextReadEN.ReaderUserId = strReaderUserId; //ReaderUserId
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objzx_TextReadEN.dicFldComparisonOp.ContainsKey(conzx_TextRead.ReaderUserId) == false)
{
objzx_TextReadEN.dicFldComparisonOp.Add(conzx_TextRead.ReaderUserId, strComparisonOp);
}
else
{
objzx_TextReadEN.dicFldComparisonOp[conzx_TextRead.ReaderUserId] = strComparisonOp;
}
}
return objzx_TextReadEN;
	}

 /// <summary>
 /// 修改记录存盘到数据表中
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_UpdateRecordEx)
 /// </summary>
 /// <param name = "objzx_TextReadEN">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool UpdateRecordEx(this clszx_TextReadEN objzx_TextReadEN)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
try
{
//1、检查传进去的对象属性是否合法
objzx_TextReadEN.CheckPropertyNew();
clszx_TextReadEN objzx_TextReadCond = new clszx_TextReadEN();
string strCondition = objzx_TextReadCond
.SetTextRId(objzx_TextReadEN.TextRId, "<>")
.SetTextId(objzx_TextReadEN.TextId, "=")
.SetReadTypeId(objzx_TextReadEN.ReadTypeId, "=")
.GetCombineCondition();
objzx_TextReadEN._IsCheckProperty = true;
bool bolIsExist = clszx_TextReadBL.IsExistRecord(strCondition);
if (bolIsExist)
{
strMsg = "(TextId_ReadTypeId)不能重复!";
throw new Exception(strMsg);
}
//4、把数据实体层的数据存贮到数据库中
objzx_TextReadEN.Update();
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
 /// <param name = "objzx_TextRead">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool EditRecordEx(this clszx_TextReadEN objzx_TextRead)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
clszx_TextReadEN objzx_TextReadCond = new clszx_TextReadEN();
string strCondition = objzx_TextReadCond
.SetTextId(objzx_TextRead.TextId, "=")
.SetReadTypeId(objzx_TextRead.ReadTypeId, "=")
.GetCombineCondition();
objzx_TextRead._IsCheckProperty = true;
bool bolIsExist = clszx_TextReadBL.IsExistRecord(strCondition);
if (bolIsExist)
{
objzx_TextRead.TextRId = clszx_TextReadBL.GetFirstID_S(strCondition);
objzx_TextRead.UpdateWithCondition(strCondition);
}
else
{
objzx_TextRead.TextRId = clszx_TextReadBL.GetMaxStrId_S();
objzx_TextRead.AddNewRecord();
}
return true; 
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_Update)
 /// </summary>
 /// <param name = "objzx_TextReadEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clszx_TextReadEN objzx_TextReadEN)
{
 if (string.IsNullOrEmpty(objzx_TextReadEN.TextRId) == true)
 {
string strMsg = string.Format("(errid:Busi000095)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clszx_TextReadBL.zx_TextReadDA.UpdateBySql2(objzx_TextReadEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clszx_TextReadBL.ReFreshCache(objzx_TextReadEN.IdCurrEduCls);

if (clszx_TextReadBL.relatedActions != null)
{
clszx_TextReadBL.relatedActions.UpdRelaTabDate(objzx_TextReadEN.TextRId, "SetUpdDate");
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
 /// <param name = "objzx_TextReadEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clszx_TextReadEN objzx_TextReadEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (string.IsNullOrEmpty(objzx_TextReadEN.TextRId) == true)
 {
string strMsg = string.Format("(errid:Busi000087)修改记录时关键字不能为空!(带事务处理)(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clszx_TextReadBL.zx_TextReadDA.UpdateBySql2(objzx_TextReadEN, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clszx_TextReadBL.ReFreshCache(objzx_TextReadEN.IdCurrEduCls);

if (clszx_TextReadBL.relatedActions != null)
{
clszx_TextReadBL.relatedActions.UpdRelaTabDate(objzx_TextReadEN.TextRId, "SetUpdDate");
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
 /// <param name = "objzx_TextReadEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clszx_TextReadEN objzx_TextReadEN, string strWhereCond)
{
try
{
bool bolResult = clszx_TextReadBL.zx_TextReadDA.UpdateBySqlWithCondition(objzx_TextReadEN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clszx_TextReadBL.ReFreshCache(objzx_TextReadEN.IdCurrEduCls);

if (clszx_TextReadBL.relatedActions != null)
{
clszx_TextReadBL.relatedActions.UpdRelaTabDate(objzx_TextReadEN.TextRId, "SetUpdDate");
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
 /// <param name = "objzx_TextReadEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clszx_TextReadEN objzx_TextReadEN, string strWhereCond, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
bool bolResult = clszx_TextReadBL.zx_TextReadDA.UpdateBySqlWithConditionTransaction(objzx_TextReadEN, strWhereCond, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clszx_TextReadBL.ReFreshCache(objzx_TextReadEN.IdCurrEduCls);

if (clszx_TextReadBL.relatedActions != null)
{
clszx_TextReadBL.relatedActions.UpdRelaTabDate(objzx_TextReadEN.TextRId, "SetUpdDate");
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
 /// <param name = "strTextRId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int Delete(this clszx_TextReadEN objzx_TextReadEN)
{
try
{
int intRecNum = clszx_TextReadBL.zx_TextReadDA.DelRecord(objzx_TextReadEN.TextRId);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clszx_TextReadBL.ReFreshCache(objzx_TextReadEN.IdCurrEduCls);

if (clszx_TextReadBL.relatedActions != null)
{
clszx_TextReadBL.relatedActions.UpdRelaTabDate(objzx_TextReadEN.TextRId, "SetUpdDate");
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
 /// <param name = "objzx_TextReadENS">源对象</param>
 /// <param name = "objzx_TextReadENT">目标对象</param>
 public static void CopyTo(this clszx_TextReadEN objzx_TextReadENS, clszx_TextReadEN objzx_TextReadENT)
{
try
{
objzx_TextReadENT.TextId = objzx_TextReadENS.TextId; //课件Id
objzx_TextReadENT.ReadTypeId = objzx_TextReadENS.ReadTypeId; //阅读类型
objzx_TextReadENT.IsSubmit = objzx_TextReadENS.IsSubmit; //是否提交
objzx_TextReadENT.IsPublic = objzx_TextReadENS.IsPublic; //是否公开
objzx_TextReadENT.Submitter = objzx_TextReadENS.Submitter; //提交人
objzx_TextReadENT.IdCurrEduCls = objzx_TextReadENS.IdCurrEduCls; //教学班流水号
objzx_TextReadENT.QuestionCount = objzx_TextReadENS.QuestionCount; //问题数
objzx_TextReadENT.CreateDate = objzx_TextReadENS.CreateDate; //建立日期
objzx_TextReadENT.UpdUser = objzx_TextReadENS.UpdUser; //修改人
objzx_TextReadENT.UpdDate = objzx_TextReadENS.UpdDate; //修改日期
objzx_TextReadENT.Memo = objzx_TextReadENS.Memo; //备注
objzx_TextReadENT.TextRId = objzx_TextReadENS.TextRId; //TextRId
objzx_TextReadENT.ReaderUserId = objzx_TextReadENS.ReaderUserId; //ReaderUserId
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
 /// <param name = "objzx_TextReadENS">源对象</param>
 /// <returns>目标对象=>clszx_TextReadEN:objzx_TextReadENT</returns>
 public static clszx_TextReadEN CopyTo(this clszx_TextReadEN objzx_TextReadENS)
{
try
{
 clszx_TextReadEN objzx_TextReadENT = new clszx_TextReadEN()
{
TextId = objzx_TextReadENS.TextId, //课件Id
ReadTypeId = objzx_TextReadENS.ReadTypeId, //阅读类型
IsSubmit = objzx_TextReadENS.IsSubmit, //是否提交
IsPublic = objzx_TextReadENS.IsPublic, //是否公开
Submitter = objzx_TextReadENS.Submitter, //提交人
IdCurrEduCls = objzx_TextReadENS.IdCurrEduCls, //教学班流水号
QuestionCount = objzx_TextReadENS.QuestionCount, //问题数
CreateDate = objzx_TextReadENS.CreateDate, //建立日期
UpdUser = objzx_TextReadENS.UpdUser, //修改人
UpdDate = objzx_TextReadENS.UpdDate, //修改日期
Memo = objzx_TextReadENS.Memo, //备注
TextRId = objzx_TextReadENS.TextRId, //TextRId
ReaderUserId = objzx_TextReadENS.ReaderUserId, //ReaderUserId
};
 return objzx_TextReadENT;
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
public static void CheckPropertyNew(this clszx_TextReadEN objzx_TextReadEN)
{
 clszx_TextReadBL.zx_TextReadDA.CheckPropertyNew(objzx_TextReadEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(this clszx_TextReadEN objzx_TextReadEN)
{
 clszx_TextReadBL.zx_TextReadDA.CheckProperty4Condition(objzx_TextReadEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clszx_TextReadEN objzx_TextReadCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objzx_TextReadCond.IsUpdated(conzx_TextRead.TextId) == true)
{
string strComparisonOpTextId = objzx_TextReadCond.dicFldComparisonOp[conzx_TextRead.TextId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conzx_TextRead.TextId, objzx_TextReadCond.TextId, strComparisonOpTextId);
}
if (objzx_TextReadCond.IsUpdated(conzx_TextRead.ReadTypeId) == true)
{
string strComparisonOpReadTypeId = objzx_TextReadCond.dicFldComparisonOp[conzx_TextRead.ReadTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conzx_TextRead.ReadTypeId, objzx_TextReadCond.ReadTypeId, strComparisonOpReadTypeId);
}
if (objzx_TextReadCond.IsUpdated(conzx_TextRead.IsSubmit) == true)
{
if (objzx_TextReadCond.IsSubmit == true)
{
strWhereCond += string.Format(" And {0} = '1'", conzx_TextRead.IsSubmit);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conzx_TextRead.IsSubmit);
}
}
if (objzx_TextReadCond.IsUpdated(conzx_TextRead.IsPublic) == true)
{
if (objzx_TextReadCond.IsPublic == true)
{
strWhereCond += string.Format(" And {0} = '1'", conzx_TextRead.IsPublic);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conzx_TextRead.IsPublic);
}
}
if (objzx_TextReadCond.IsUpdated(conzx_TextRead.Submitter) == true)
{
string strComparisonOpSubmitter = objzx_TextReadCond.dicFldComparisonOp[conzx_TextRead.Submitter];
strWhereCond += string.Format(" And {0} {2} '{1}'", conzx_TextRead.Submitter, objzx_TextReadCond.Submitter, strComparisonOpSubmitter);
}
if (objzx_TextReadCond.IsUpdated(conzx_TextRead.IdCurrEduCls) == true)
{
string strComparisonOpIdCurrEduCls = objzx_TextReadCond.dicFldComparisonOp[conzx_TextRead.IdCurrEduCls];
strWhereCond += string.Format(" And {0} {2} '{1}'", conzx_TextRead.IdCurrEduCls, objzx_TextReadCond.IdCurrEduCls, strComparisonOpIdCurrEduCls);
}
if (objzx_TextReadCond.IsUpdated(conzx_TextRead.QuestionCount) == true)
{
string strComparisonOpQuestionCount = objzx_TextReadCond.dicFldComparisonOp[conzx_TextRead.QuestionCount];
strWhereCond += string.Format(" And {0} {2} {1}", conzx_TextRead.QuestionCount, objzx_TextReadCond.QuestionCount, strComparisonOpQuestionCount);
}
if (objzx_TextReadCond.IsUpdated(conzx_TextRead.CreateDate) == true)
{
string strComparisonOpCreateDate = objzx_TextReadCond.dicFldComparisonOp[conzx_TextRead.CreateDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conzx_TextRead.CreateDate, objzx_TextReadCond.CreateDate, strComparisonOpCreateDate);
}
if (objzx_TextReadCond.IsUpdated(conzx_TextRead.UpdUser) == true)
{
string strComparisonOpUpdUser = objzx_TextReadCond.dicFldComparisonOp[conzx_TextRead.UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", conzx_TextRead.UpdUser, objzx_TextReadCond.UpdUser, strComparisonOpUpdUser);
}
if (objzx_TextReadCond.IsUpdated(conzx_TextRead.UpdDate) == true)
{
string strComparisonOpUpdDate = objzx_TextReadCond.dicFldComparisonOp[conzx_TextRead.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conzx_TextRead.UpdDate, objzx_TextReadCond.UpdDate, strComparisonOpUpdDate);
}
if (objzx_TextReadCond.IsUpdated(conzx_TextRead.Memo) == true)
{
string strComparisonOpMemo = objzx_TextReadCond.dicFldComparisonOp[conzx_TextRead.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", conzx_TextRead.Memo, objzx_TextReadCond.Memo, strComparisonOpMemo);
}
if (objzx_TextReadCond.IsUpdated(conzx_TextRead.TextRId) == true)
{
string strComparisonOpTextRId = objzx_TextReadCond.dicFldComparisonOp[conzx_TextRead.TextRId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conzx_TextRead.TextRId, objzx_TextReadCond.TextRId, strComparisonOpTextRId);
}
if (objzx_TextReadCond.IsUpdated(conzx_TextRead.ReaderUserId) == true)
{
string strComparisonOpReaderUserId = objzx_TextReadCond.dicFldComparisonOp[conzx_TextRead.ReaderUserId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conzx_TextRead.ReaderUserId, objzx_TextReadCond.ReaderUserId, strComparisonOpReaderUserId);
}
 return strWhereCond;
}

 /// <summary>
 /// 检查唯一性(Uniqueness)--zx_TextRead(课文阅读), 如果不唯一,即存在相同的记录,就返回False
 /// 唯一性条件:TextId_ReadTypeId
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckConstraint)
 /// </summary>
 /// <param name = "objzx_TextReadEN">要求唯一的对象</param>
 /// <returns></returns>
public static bool CheckUniqueness(this clszx_TextReadEN objzx_TextReadEN)
{
//检测记录是否存在
bool bolIsUniqueness;
StringBuilder sbCondition = new StringBuilder();
if (objzx_TextReadEN == null) return true;
if (objzx_TextReadEN.TextRId == null || objzx_TextReadEN.TextRId == "")
{
sbCondition.AppendFormat("1 = 1");
 if (objzx_TextReadEN.TextId == null)
{
 sbCondition.AppendFormat(" and TextId is null", objzx_TextReadEN.TextId);
}
else
{
 sbCondition.AppendFormat(" and TextId = '{0}'", objzx_TextReadEN.TextId);
}
 sbCondition.AppendFormat(" and ReadTypeId = '{0}'", objzx_TextReadEN.ReadTypeId);
if (clszx_TextReadBL.IsExistRecord(sbCondition.ToString())  ==  true)
{
 bolIsUniqueness = false;
}
else
{
 bolIsUniqueness = true;
}
}
 else {
sbCondition.AppendFormat("TextRId !=  '{0}'", objzx_TextReadEN.TextRId);
 sbCondition.AppendFormat(" and TextId = '{0}'", objzx_TextReadEN.TextId);
 sbCondition.AppendFormat(" and ReadTypeId = '{0}'", objzx_TextReadEN.ReadTypeId);
if (clszx_TextReadBL.IsExistRecord(sbCondition.ToString())  ==  true)
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
 /// 获取唯一性条件串--zx_TextRead(课文阅读), 即由对象中唯一性条件字段关键字与值组成的条件串
 /// 唯一性条件:TextId_ReadTypeId
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetConditionString4Constraint)
 /// </summary>
 /// <param name = "objzx_TextReadEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(this clszx_TextReadEN objzx_TextReadEN)
{
//检测记录是否存在
StringBuilder sbCondition = new StringBuilder();
if (objzx_TextReadEN == null) return "";
if (objzx_TextReadEN.TextRId == null || objzx_TextReadEN.TextRId == "")
{
sbCondition.AppendFormat("1 = 1");
 if (objzx_TextReadEN.TextId == null)
{
 sbCondition.AppendFormat(" and TextId is null", objzx_TextReadEN.TextId);
}
else
{
 sbCondition.AppendFormat(" and TextId = '{0}'", objzx_TextReadEN.TextId);
}
 sbCondition.AppendFormat(" and ReadTypeId = '{0}'", objzx_TextReadEN.ReadTypeId);
return sbCondition.ToString();
}
 else {
sbCondition.AppendFormat("TextRId !=  '{0}'", objzx_TextReadEN.TextRId);
 sbCondition.AppendFormat(" and TextId = '{0}'", objzx_TextReadEN.TextId);
 sbCondition.AppendFormat(" and ReadTypeId = '{0}'", objzx_TextReadEN.ReadTypeId);
 return sbCondition.ToString();
}
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_zx_TextRead
{
public virtual bool UpdRelaTabDate(string strTextRId, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// 课文阅读(zx_TextRead)
 /// 数据源类型:表
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clszx_TextReadBL
{
public static RelatedActions_zx_TextRead relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clszx_TextReadDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clszx_TextReadDA zx_TextReadDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clszx_TextReadDA();
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
 public clszx_TextReadBL()
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
if (string.IsNullOrEmpty(clszx_TextReadEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clszx_TextReadEN._ConnectString);
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
public static DataTable GetDataTable_zx_TextRead(string strWhereCond)
{
DataTable objDT;
try
{
objDT = zx_TextReadDA.GetDataTable_zx_TextRead(strWhereCond);
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
objDT = zx_TextReadDA.GetDataTable(strWhereCond);
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
objDT = zx_TextReadDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = zx_TextReadDA.GetDataTable(strWhereCond, strTabName);
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
objDT = zx_TextReadDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = zx_TextReadDA.GetDataTable_Top(objTopPara);
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
objDT = zx_TextReadDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = zx_TextReadDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = zx_TextReadDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
 /// <param name = "arrTextRIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static List<clszx_TextReadEN> GetObjLstByTextRIdLst(List<string> arrTextRIdLst)
{
List<clszx_TextReadEN> arrObjLst = new List<clszx_TextReadEN>(); 
System.Data.DataTable objDT; 
 string strSqlConditionStr = clsArray.GetSqlInStrByArray(arrTextRIdLst, true);
 string strWhereCond = string.Format("TextRId in ({0})", strSqlConditionStr);
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clszx_TextReadEN objzx_TextReadEN = new clszx_TextReadEN();
try
{
objzx_TextReadEN.TextId = objRow[conzx_TextRead.TextId] == DBNull.Value ? null : objRow[conzx_TextRead.TextId].ToString().Trim(); //课件Id
objzx_TextReadEN.ReadTypeId = objRow[conzx_TextRead.ReadTypeId].ToString().Trim(); //阅读类型
objzx_TextReadEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[conzx_TextRead.IsSubmit].ToString().Trim()); //是否提交
objzx_TextReadEN.IsPublic = clsEntityBase2.TransNullToBool_S(objRow[conzx_TextRead.IsPublic].ToString().Trim()); //是否公开
objzx_TextReadEN.Submitter = objRow[conzx_TextRead.Submitter] == DBNull.Value ? null : objRow[conzx_TextRead.Submitter].ToString().Trim(); //提交人
objzx_TextReadEN.IdCurrEduCls = objRow[conzx_TextRead.IdCurrEduCls] == DBNull.Value ? null : objRow[conzx_TextRead.IdCurrEduCls].ToString().Trim(); //教学班流水号
objzx_TextReadEN.QuestionCount = objRow[conzx_TextRead.QuestionCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_TextRead.QuestionCount].ToString().Trim()); //问题数
objzx_TextReadEN.CreateDate = objRow[conzx_TextRead.CreateDate] == DBNull.Value ? null : objRow[conzx_TextRead.CreateDate].ToString().Trim(); //建立日期
objzx_TextReadEN.UpdUser = objRow[conzx_TextRead.UpdUser] == DBNull.Value ? null : objRow[conzx_TextRead.UpdUser].ToString().Trim(); //修改人
objzx_TextReadEN.UpdDate = objRow[conzx_TextRead.UpdDate].ToString().Trim(); //修改日期
objzx_TextReadEN.Memo = objRow[conzx_TextRead.Memo] == DBNull.Value ? null : objRow[conzx_TextRead.Memo].ToString().Trim(); //备注
objzx_TextReadEN.TextRId = objRow[conzx_TextRead.TextRId].ToString().Trim(); //TextRId
objzx_TextReadEN.ReaderUserId = objRow[conzx_TextRead.ReaderUserId] == DBNull.Value ? null : objRow[conzx_TextRead.ReaderUserId].ToString().Trim(); //ReaderUserId
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objzx_TextReadEN.TextRId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objzx_TextReadEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrTextRIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clszx_TextReadEN> GetObjLstByTextRIdLstCache(List<string> arrTextRIdLst, string strIdCurrEduCls)
{
string strKey = string.Format("{0}_{1}", clszx_TextReadEN._CurrTabName, strIdCurrEduCls);
List<clszx_TextReadEN> arrzx_TextReadObjLstCache = GetObjLstCache(strIdCurrEduCls);
IEnumerable <clszx_TextReadEN> arrzx_TextReadObjLst_Sel =
arrzx_TextReadObjLstCache
.Where(x => arrTextRIdLst.Contains(x.TextRId));
return arrzx_TextReadObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clszx_TextReadEN> GetObjLst(string strWhereCond)
{
List<clszx_TextReadEN> arrObjLst = new List<clszx_TextReadEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clszx_TextReadEN objzx_TextReadEN = new clszx_TextReadEN();
try
{
objzx_TextReadEN.TextId = objRow[conzx_TextRead.TextId] == DBNull.Value ? null : objRow[conzx_TextRead.TextId].ToString().Trim(); //课件Id
objzx_TextReadEN.ReadTypeId = objRow[conzx_TextRead.ReadTypeId].ToString().Trim(); //阅读类型
objzx_TextReadEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[conzx_TextRead.IsSubmit].ToString().Trim()); //是否提交
objzx_TextReadEN.IsPublic = clsEntityBase2.TransNullToBool_S(objRow[conzx_TextRead.IsPublic].ToString().Trim()); //是否公开
objzx_TextReadEN.Submitter = objRow[conzx_TextRead.Submitter] == DBNull.Value ? null : objRow[conzx_TextRead.Submitter].ToString().Trim(); //提交人
objzx_TextReadEN.IdCurrEduCls = objRow[conzx_TextRead.IdCurrEduCls] == DBNull.Value ? null : objRow[conzx_TextRead.IdCurrEduCls].ToString().Trim(); //教学班流水号
objzx_TextReadEN.QuestionCount = objRow[conzx_TextRead.QuestionCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_TextRead.QuestionCount].ToString().Trim()); //问题数
objzx_TextReadEN.CreateDate = objRow[conzx_TextRead.CreateDate] == DBNull.Value ? null : objRow[conzx_TextRead.CreateDate].ToString().Trim(); //建立日期
objzx_TextReadEN.UpdUser = objRow[conzx_TextRead.UpdUser] == DBNull.Value ? null : objRow[conzx_TextRead.UpdUser].ToString().Trim(); //修改人
objzx_TextReadEN.UpdDate = objRow[conzx_TextRead.UpdDate].ToString().Trim(); //修改日期
objzx_TextReadEN.Memo = objRow[conzx_TextRead.Memo] == DBNull.Value ? null : objRow[conzx_TextRead.Memo].ToString().Trim(); //备注
objzx_TextReadEN.TextRId = objRow[conzx_TextRead.TextRId].ToString().Trim(); //TextRId
objzx_TextReadEN.ReaderUserId = objRow[conzx_TextRead.ReaderUserId] == DBNull.Value ? null : objRow[conzx_TextRead.ReaderUserId].ToString().Trim(); //ReaderUserId
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objzx_TextReadEN.TextRId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objzx_TextReadEN);
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
public static List<clszx_TextReadEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clszx_TextReadEN> arrObjLst = new List<clszx_TextReadEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clszx_TextReadEN objzx_TextReadEN = new clszx_TextReadEN();
try
{
objzx_TextReadEN.TextId = objRow[conzx_TextRead.TextId] == DBNull.Value ? null : objRow[conzx_TextRead.TextId].ToString().Trim(); //课件Id
objzx_TextReadEN.ReadTypeId = objRow[conzx_TextRead.ReadTypeId].ToString().Trim(); //阅读类型
objzx_TextReadEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[conzx_TextRead.IsSubmit].ToString().Trim()); //是否提交
objzx_TextReadEN.IsPublic = clsEntityBase2.TransNullToBool_S(objRow[conzx_TextRead.IsPublic].ToString().Trim()); //是否公开
objzx_TextReadEN.Submitter = objRow[conzx_TextRead.Submitter] == DBNull.Value ? null : objRow[conzx_TextRead.Submitter].ToString().Trim(); //提交人
objzx_TextReadEN.IdCurrEduCls = objRow[conzx_TextRead.IdCurrEduCls] == DBNull.Value ? null : objRow[conzx_TextRead.IdCurrEduCls].ToString().Trim(); //教学班流水号
objzx_TextReadEN.QuestionCount = objRow[conzx_TextRead.QuestionCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_TextRead.QuestionCount].ToString().Trim()); //问题数
objzx_TextReadEN.CreateDate = objRow[conzx_TextRead.CreateDate] == DBNull.Value ? null : objRow[conzx_TextRead.CreateDate].ToString().Trim(); //建立日期
objzx_TextReadEN.UpdUser = objRow[conzx_TextRead.UpdUser] == DBNull.Value ? null : objRow[conzx_TextRead.UpdUser].ToString().Trim(); //修改人
objzx_TextReadEN.UpdDate = objRow[conzx_TextRead.UpdDate].ToString().Trim(); //修改日期
objzx_TextReadEN.Memo = objRow[conzx_TextRead.Memo] == DBNull.Value ? null : objRow[conzx_TextRead.Memo].ToString().Trim(); //备注
objzx_TextReadEN.TextRId = objRow[conzx_TextRead.TextRId].ToString().Trim(); //TextRId
objzx_TextReadEN.ReaderUserId = objRow[conzx_TextRead.ReaderUserId] == DBNull.Value ? null : objRow[conzx_TextRead.ReaderUserId].ToString().Trim(); //ReaderUserId
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objzx_TextReadEN.TextRId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objzx_TextReadEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objzx_TextReadCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clszx_TextReadEN> GetSubObjLstCache(clszx_TextReadEN objzx_TextReadCond)
{
 string strIdCurrEduCls = objzx_TextReadCond.IdCurrEduCls;
 if (string.IsNullOrEmpty(strIdCurrEduCls) == true)
{
string strMsg = string.Format("(errid:Busi000172)在表中,缓存分类字段值不能为空!(clszx_TextReadBL:GetSubObjLstCache)");
throw new Exception(strMsg);
}
List<clszx_TextReadEN> arrObjLstCache = GetObjLstCache(strIdCurrEduCls);
IEnumerable <clszx_TextReadEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conzx_TextRead.AttributeName)
{
if (objzx_TextReadCond.IsUpdated(strFldName) == false) continue;
if (objzx_TextReadCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objzx_TextReadCond[strFldName].ToString());
}
else
{
if (objzx_TextReadCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objzx_TextReadCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objzx_TextReadCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objzx_TextReadCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objzx_TextReadCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objzx_TextReadCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objzx_TextReadCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objzx_TextReadCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objzx_TextReadCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objzx_TextReadCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objzx_TextReadCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objzx_TextReadCond[strFldName]));
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
public static List<clszx_TextReadEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clszx_TextReadEN> arrObjLst = new List<clszx_TextReadEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clszx_TextReadEN objzx_TextReadEN = new clszx_TextReadEN();
try
{
objzx_TextReadEN.TextId = objRow[conzx_TextRead.TextId] == DBNull.Value ? null : objRow[conzx_TextRead.TextId].ToString().Trim(); //课件Id
objzx_TextReadEN.ReadTypeId = objRow[conzx_TextRead.ReadTypeId].ToString().Trim(); //阅读类型
objzx_TextReadEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[conzx_TextRead.IsSubmit].ToString().Trim()); //是否提交
objzx_TextReadEN.IsPublic = clsEntityBase2.TransNullToBool_S(objRow[conzx_TextRead.IsPublic].ToString().Trim()); //是否公开
objzx_TextReadEN.Submitter = objRow[conzx_TextRead.Submitter] == DBNull.Value ? null : objRow[conzx_TextRead.Submitter].ToString().Trim(); //提交人
objzx_TextReadEN.IdCurrEduCls = objRow[conzx_TextRead.IdCurrEduCls] == DBNull.Value ? null : objRow[conzx_TextRead.IdCurrEduCls].ToString().Trim(); //教学班流水号
objzx_TextReadEN.QuestionCount = objRow[conzx_TextRead.QuestionCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_TextRead.QuestionCount].ToString().Trim()); //问题数
objzx_TextReadEN.CreateDate = objRow[conzx_TextRead.CreateDate] == DBNull.Value ? null : objRow[conzx_TextRead.CreateDate].ToString().Trim(); //建立日期
objzx_TextReadEN.UpdUser = objRow[conzx_TextRead.UpdUser] == DBNull.Value ? null : objRow[conzx_TextRead.UpdUser].ToString().Trim(); //修改人
objzx_TextReadEN.UpdDate = objRow[conzx_TextRead.UpdDate].ToString().Trim(); //修改日期
objzx_TextReadEN.Memo = objRow[conzx_TextRead.Memo] == DBNull.Value ? null : objRow[conzx_TextRead.Memo].ToString().Trim(); //备注
objzx_TextReadEN.TextRId = objRow[conzx_TextRead.TextRId].ToString().Trim(); //TextRId
objzx_TextReadEN.ReaderUserId = objRow[conzx_TextRead.ReaderUserId] == DBNull.Value ? null : objRow[conzx_TextRead.ReaderUserId].ToString().Trim(); //ReaderUserId
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objzx_TextReadEN.TextRId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objzx_TextReadEN);
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
public static List<clszx_TextReadEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clszx_TextReadEN> arrObjLst = new List<clszx_TextReadEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clszx_TextReadEN objzx_TextReadEN = new clszx_TextReadEN();
try
{
objzx_TextReadEN.TextId = objRow[conzx_TextRead.TextId] == DBNull.Value ? null : objRow[conzx_TextRead.TextId].ToString().Trim(); //课件Id
objzx_TextReadEN.ReadTypeId = objRow[conzx_TextRead.ReadTypeId].ToString().Trim(); //阅读类型
objzx_TextReadEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[conzx_TextRead.IsSubmit].ToString().Trim()); //是否提交
objzx_TextReadEN.IsPublic = clsEntityBase2.TransNullToBool_S(objRow[conzx_TextRead.IsPublic].ToString().Trim()); //是否公开
objzx_TextReadEN.Submitter = objRow[conzx_TextRead.Submitter] == DBNull.Value ? null : objRow[conzx_TextRead.Submitter].ToString().Trim(); //提交人
objzx_TextReadEN.IdCurrEduCls = objRow[conzx_TextRead.IdCurrEduCls] == DBNull.Value ? null : objRow[conzx_TextRead.IdCurrEduCls].ToString().Trim(); //教学班流水号
objzx_TextReadEN.QuestionCount = objRow[conzx_TextRead.QuestionCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_TextRead.QuestionCount].ToString().Trim()); //问题数
objzx_TextReadEN.CreateDate = objRow[conzx_TextRead.CreateDate] == DBNull.Value ? null : objRow[conzx_TextRead.CreateDate].ToString().Trim(); //建立日期
objzx_TextReadEN.UpdUser = objRow[conzx_TextRead.UpdUser] == DBNull.Value ? null : objRow[conzx_TextRead.UpdUser].ToString().Trim(); //修改人
objzx_TextReadEN.UpdDate = objRow[conzx_TextRead.UpdDate].ToString().Trim(); //修改日期
objzx_TextReadEN.Memo = objRow[conzx_TextRead.Memo] == DBNull.Value ? null : objRow[conzx_TextRead.Memo].ToString().Trim(); //备注
objzx_TextReadEN.TextRId = objRow[conzx_TextRead.TextRId].ToString().Trim(); //TextRId
objzx_TextReadEN.ReaderUserId = objRow[conzx_TextRead.ReaderUserId] == DBNull.Value ? null : objRow[conzx_TextRead.ReaderUserId].ToString().Trim(); //ReaderUserId
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objzx_TextReadEN.TextRId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objzx_TextReadEN);
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
List<clszx_TextReadEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clszx_TextReadEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clszx_TextReadEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clszx_TextReadEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clszx_TextReadEN> arrObjLst = new List<clszx_TextReadEN>(); 
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
	clszx_TextReadEN objzx_TextReadEN = new clszx_TextReadEN();
try
{
objzx_TextReadEN.TextId = objRow[conzx_TextRead.TextId] == DBNull.Value ? null : objRow[conzx_TextRead.TextId].ToString().Trim(); //课件Id
objzx_TextReadEN.ReadTypeId = objRow[conzx_TextRead.ReadTypeId].ToString().Trim(); //阅读类型
objzx_TextReadEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[conzx_TextRead.IsSubmit].ToString().Trim()); //是否提交
objzx_TextReadEN.IsPublic = clsEntityBase2.TransNullToBool_S(objRow[conzx_TextRead.IsPublic].ToString().Trim()); //是否公开
objzx_TextReadEN.Submitter = objRow[conzx_TextRead.Submitter] == DBNull.Value ? null : objRow[conzx_TextRead.Submitter].ToString().Trim(); //提交人
objzx_TextReadEN.IdCurrEduCls = objRow[conzx_TextRead.IdCurrEduCls] == DBNull.Value ? null : objRow[conzx_TextRead.IdCurrEduCls].ToString().Trim(); //教学班流水号
objzx_TextReadEN.QuestionCount = objRow[conzx_TextRead.QuestionCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_TextRead.QuestionCount].ToString().Trim()); //问题数
objzx_TextReadEN.CreateDate = objRow[conzx_TextRead.CreateDate] == DBNull.Value ? null : objRow[conzx_TextRead.CreateDate].ToString().Trim(); //建立日期
objzx_TextReadEN.UpdUser = objRow[conzx_TextRead.UpdUser] == DBNull.Value ? null : objRow[conzx_TextRead.UpdUser].ToString().Trim(); //修改人
objzx_TextReadEN.UpdDate = objRow[conzx_TextRead.UpdDate].ToString().Trim(); //修改日期
objzx_TextReadEN.Memo = objRow[conzx_TextRead.Memo] == DBNull.Value ? null : objRow[conzx_TextRead.Memo].ToString().Trim(); //备注
objzx_TextReadEN.TextRId = objRow[conzx_TextRead.TextRId].ToString().Trim(); //TextRId
objzx_TextReadEN.ReaderUserId = objRow[conzx_TextRead.ReaderUserId] == DBNull.Value ? null : objRow[conzx_TextRead.ReaderUserId].ToString().Trim(); //ReaderUserId
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objzx_TextReadEN.TextRId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objzx_TextReadEN);
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
public static List<clszx_TextReadEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clszx_TextReadEN> arrObjLst = new List<clszx_TextReadEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clszx_TextReadEN objzx_TextReadEN = new clszx_TextReadEN();
try
{
objzx_TextReadEN.TextId = objRow[conzx_TextRead.TextId] == DBNull.Value ? null : objRow[conzx_TextRead.TextId].ToString().Trim(); //课件Id
objzx_TextReadEN.ReadTypeId = objRow[conzx_TextRead.ReadTypeId].ToString().Trim(); //阅读类型
objzx_TextReadEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[conzx_TextRead.IsSubmit].ToString().Trim()); //是否提交
objzx_TextReadEN.IsPublic = clsEntityBase2.TransNullToBool_S(objRow[conzx_TextRead.IsPublic].ToString().Trim()); //是否公开
objzx_TextReadEN.Submitter = objRow[conzx_TextRead.Submitter] == DBNull.Value ? null : objRow[conzx_TextRead.Submitter].ToString().Trim(); //提交人
objzx_TextReadEN.IdCurrEduCls = objRow[conzx_TextRead.IdCurrEduCls] == DBNull.Value ? null : objRow[conzx_TextRead.IdCurrEduCls].ToString().Trim(); //教学班流水号
objzx_TextReadEN.QuestionCount = objRow[conzx_TextRead.QuestionCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_TextRead.QuestionCount].ToString().Trim()); //问题数
objzx_TextReadEN.CreateDate = objRow[conzx_TextRead.CreateDate] == DBNull.Value ? null : objRow[conzx_TextRead.CreateDate].ToString().Trim(); //建立日期
objzx_TextReadEN.UpdUser = objRow[conzx_TextRead.UpdUser] == DBNull.Value ? null : objRow[conzx_TextRead.UpdUser].ToString().Trim(); //修改人
objzx_TextReadEN.UpdDate = objRow[conzx_TextRead.UpdDate].ToString().Trim(); //修改日期
objzx_TextReadEN.Memo = objRow[conzx_TextRead.Memo] == DBNull.Value ? null : objRow[conzx_TextRead.Memo].ToString().Trim(); //备注
objzx_TextReadEN.TextRId = objRow[conzx_TextRead.TextRId].ToString().Trim(); //TextRId
objzx_TextReadEN.ReaderUserId = objRow[conzx_TextRead.ReaderUserId] == DBNull.Value ? null : objRow[conzx_TextRead.ReaderUserId].ToString().Trim(); //ReaderUserId
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objzx_TextReadEN.TextRId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objzx_TextReadEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clszx_TextReadEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clszx_TextReadEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clszx_TextReadEN> arrObjLst = new List<clszx_TextReadEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clszx_TextReadEN objzx_TextReadEN = new clszx_TextReadEN();
try
{
objzx_TextReadEN.TextId = objRow[conzx_TextRead.TextId] == DBNull.Value ? null : objRow[conzx_TextRead.TextId].ToString().Trim(); //课件Id
objzx_TextReadEN.ReadTypeId = objRow[conzx_TextRead.ReadTypeId].ToString().Trim(); //阅读类型
objzx_TextReadEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[conzx_TextRead.IsSubmit].ToString().Trim()); //是否提交
objzx_TextReadEN.IsPublic = clsEntityBase2.TransNullToBool_S(objRow[conzx_TextRead.IsPublic].ToString().Trim()); //是否公开
objzx_TextReadEN.Submitter = objRow[conzx_TextRead.Submitter] == DBNull.Value ? null : objRow[conzx_TextRead.Submitter].ToString().Trim(); //提交人
objzx_TextReadEN.IdCurrEduCls = objRow[conzx_TextRead.IdCurrEduCls] == DBNull.Value ? null : objRow[conzx_TextRead.IdCurrEduCls].ToString().Trim(); //教学班流水号
objzx_TextReadEN.QuestionCount = objRow[conzx_TextRead.QuestionCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_TextRead.QuestionCount].ToString().Trim()); //问题数
objzx_TextReadEN.CreateDate = objRow[conzx_TextRead.CreateDate] == DBNull.Value ? null : objRow[conzx_TextRead.CreateDate].ToString().Trim(); //建立日期
objzx_TextReadEN.UpdUser = objRow[conzx_TextRead.UpdUser] == DBNull.Value ? null : objRow[conzx_TextRead.UpdUser].ToString().Trim(); //修改人
objzx_TextReadEN.UpdDate = objRow[conzx_TextRead.UpdDate].ToString().Trim(); //修改日期
objzx_TextReadEN.Memo = objRow[conzx_TextRead.Memo] == DBNull.Value ? null : objRow[conzx_TextRead.Memo].ToString().Trim(); //备注
objzx_TextReadEN.TextRId = objRow[conzx_TextRead.TextRId].ToString().Trim(); //TextRId
objzx_TextReadEN.ReaderUserId = objRow[conzx_TextRead.ReaderUserId] == DBNull.Value ? null : objRow[conzx_TextRead.ReaderUserId].ToString().Trim(); //ReaderUserId
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objzx_TextReadEN.TextRId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objzx_TextReadEN);
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
public static List<clszx_TextReadEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clszx_TextReadEN> arrObjLst = new List<clszx_TextReadEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clszx_TextReadEN objzx_TextReadEN = new clszx_TextReadEN();
try
{
objzx_TextReadEN.TextId = objRow[conzx_TextRead.TextId] == DBNull.Value ? null : objRow[conzx_TextRead.TextId].ToString().Trim(); //课件Id
objzx_TextReadEN.ReadTypeId = objRow[conzx_TextRead.ReadTypeId].ToString().Trim(); //阅读类型
objzx_TextReadEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[conzx_TextRead.IsSubmit].ToString().Trim()); //是否提交
objzx_TextReadEN.IsPublic = clsEntityBase2.TransNullToBool_S(objRow[conzx_TextRead.IsPublic].ToString().Trim()); //是否公开
objzx_TextReadEN.Submitter = objRow[conzx_TextRead.Submitter] == DBNull.Value ? null : objRow[conzx_TextRead.Submitter].ToString().Trim(); //提交人
objzx_TextReadEN.IdCurrEduCls = objRow[conzx_TextRead.IdCurrEduCls] == DBNull.Value ? null : objRow[conzx_TextRead.IdCurrEduCls].ToString().Trim(); //教学班流水号
objzx_TextReadEN.QuestionCount = objRow[conzx_TextRead.QuestionCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_TextRead.QuestionCount].ToString().Trim()); //问题数
objzx_TextReadEN.CreateDate = objRow[conzx_TextRead.CreateDate] == DBNull.Value ? null : objRow[conzx_TextRead.CreateDate].ToString().Trim(); //建立日期
objzx_TextReadEN.UpdUser = objRow[conzx_TextRead.UpdUser] == DBNull.Value ? null : objRow[conzx_TextRead.UpdUser].ToString().Trim(); //修改人
objzx_TextReadEN.UpdDate = objRow[conzx_TextRead.UpdDate].ToString().Trim(); //修改日期
objzx_TextReadEN.Memo = objRow[conzx_TextRead.Memo] == DBNull.Value ? null : objRow[conzx_TextRead.Memo].ToString().Trim(); //备注
objzx_TextReadEN.TextRId = objRow[conzx_TextRead.TextRId].ToString().Trim(); //TextRId
objzx_TextReadEN.ReaderUserId = objRow[conzx_TextRead.ReaderUserId] == DBNull.Value ? null : objRow[conzx_TextRead.ReaderUserId].ToString().Trim(); //ReaderUserId
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objzx_TextReadEN.TextRId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objzx_TextReadEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clszx_TextReadEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clszx_TextReadEN> arrObjLst = new List<clszx_TextReadEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clszx_TextReadEN objzx_TextReadEN = new clszx_TextReadEN();
try
{
objzx_TextReadEN.TextId = objRow[conzx_TextRead.TextId] == DBNull.Value ? null : objRow[conzx_TextRead.TextId].ToString().Trim(); //课件Id
objzx_TextReadEN.ReadTypeId = objRow[conzx_TextRead.ReadTypeId].ToString().Trim(); //阅读类型
objzx_TextReadEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[conzx_TextRead.IsSubmit].ToString().Trim()); //是否提交
objzx_TextReadEN.IsPublic = clsEntityBase2.TransNullToBool_S(objRow[conzx_TextRead.IsPublic].ToString().Trim()); //是否公开
objzx_TextReadEN.Submitter = objRow[conzx_TextRead.Submitter] == DBNull.Value ? null : objRow[conzx_TextRead.Submitter].ToString().Trim(); //提交人
objzx_TextReadEN.IdCurrEduCls = objRow[conzx_TextRead.IdCurrEduCls] == DBNull.Value ? null : objRow[conzx_TextRead.IdCurrEduCls].ToString().Trim(); //教学班流水号
objzx_TextReadEN.QuestionCount = objRow[conzx_TextRead.QuestionCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_TextRead.QuestionCount].ToString().Trim()); //问题数
objzx_TextReadEN.CreateDate = objRow[conzx_TextRead.CreateDate] == DBNull.Value ? null : objRow[conzx_TextRead.CreateDate].ToString().Trim(); //建立日期
objzx_TextReadEN.UpdUser = objRow[conzx_TextRead.UpdUser] == DBNull.Value ? null : objRow[conzx_TextRead.UpdUser].ToString().Trim(); //修改人
objzx_TextReadEN.UpdDate = objRow[conzx_TextRead.UpdDate].ToString().Trim(); //修改日期
objzx_TextReadEN.Memo = objRow[conzx_TextRead.Memo] == DBNull.Value ? null : objRow[conzx_TextRead.Memo].ToString().Trim(); //备注
objzx_TextReadEN.TextRId = objRow[conzx_TextRead.TextRId].ToString().Trim(); //TextRId
objzx_TextReadEN.ReaderUserId = objRow[conzx_TextRead.ReaderUserId] == DBNull.Value ? null : objRow[conzx_TextRead.ReaderUserId].ToString().Trim(); //ReaderUserId
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objzx_TextReadEN.TextRId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objzx_TextReadEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objzx_TextReadEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool Getzx_TextRead(ref clszx_TextReadEN objzx_TextReadEN)
{
bool bolResult = zx_TextReadDA.Getzx_TextRead(ref objzx_TextReadEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "strTextRId">表关键字</param>
 /// <returns>表对象</returns>
public static clszx_TextReadEN GetObjByTextRId(string strTextRId)
{
if (strTextRId.IndexOf(' ') >=0)
{
var strMsg = string.Format("(errid:Busi000079)在表中,关键字[strTextRId]中不能有空格!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
if (string.IsNullOrEmpty(strTextRId) == true)
{
var strMsg = string.Format("(errid:Busi000020)在表中,关键字[strTextRId]不能为空!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
clszx_TextReadEN objzx_TextReadEN = zx_TextReadDA.GetObjByTextRId(strTextRId);
return objzx_TextReadEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clszx_TextReadEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clszx_TextReadEN objzx_TextReadEN = zx_TextReadDA.GetFirstObj(strWhereCond);
 return objzx_TextReadEN;
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
public static clszx_TextReadEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clszx_TextReadEN objzx_TextReadEN = zx_TextReadDA.GetObjByDataRow(objRow);
 return objzx_TextReadEN;
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
public static clszx_TextReadEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clszx_TextReadEN objzx_TextReadEN = zx_TextReadDA.GetObjByDataRow(objRow);
 return objzx_TextReadEN;
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
 /// <param name = "strTextRId">所给的关键字</param>
 /// <param name = "lstzx_TextReadObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clszx_TextReadEN GetObjByTextRIdFromList(string strTextRId, List<clszx_TextReadEN> lstzx_TextReadObjLst)
{
foreach (clszx_TextReadEN objzx_TextReadEN in lstzx_TextReadObjLst)
{
if (objzx_TextReadEN.TextRId == strTextRId)
{
return objzx_TextReadEN;
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
 string strMaxTextRId;
 try
 {
 strMaxTextRId = clszx_TextReadDA.GetMaxStrId();
 return strMaxTextRId;
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
 string strTextRId;
 try
 {
 strTextRId = new clszx_TextReadDA().GetFirstID(strWhereCond);
 return strTextRId;
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
 arrList = zx_TextReadDA.GetID(strWhereCond);
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
bool bolIsExist = zx_TextReadDA.IsExistCondRec(strWhereCond);
return bolIsExist;
}

 /// <summary>
 /// 判断当前表中是否存在给定关键字值的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExist)
 /// </summary>
 /// <param name = "strTextRId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public static bool IsExist(string strTextRId)
{
if (string.IsNullOrEmpty(strTextRId) == true)
{
var strMsg = string.Format("(errid:Busi000027)在表中,关键字[strTextRId]不能为空!!(from {0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
//检测记录是否存在
bool bolIsExist = zx_TextReadDA.IsExist(strTextRId);
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
 bolIsExist = clszx_TextReadDA.IsExistTable();
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
 bolIsExist = zx_TextReadDA.IsExistTable(strTabName);
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
 /// <param name = "objzx_TextReadEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecordBySql2(clszx_TextReadEN objzx_TextReadEN)
{
if (objzx_TextReadEN.CheckUniqueness() == false)
{
var strMsg = string.Format("记录已经存在!课件Id = [{0}],阅读类型 = [{1}]的数据已经存在!(in clszx_TextReadBL.AddNewRecordBySql2)", objzx_TextReadEN.TextId,objzx_TextReadEN.ReadTypeId);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objzx_TextReadEN.TextRId) == true || clszx_TextReadBL.IsExist(objzx_TextReadEN.TextRId) == true)
 {
     objzx_TextReadEN.TextRId = clszx_TextReadBL.GetMaxStrId_S();
 }
bool bolResult = zx_TextReadDA.AddNewRecordBySQL2(objzx_TextReadEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clszx_TextReadBL.ReFreshCache(objzx_TextReadEN.IdCurrEduCls);

if (clszx_TextReadBL.relatedActions != null)
{
clszx_TextReadBL.relatedActions.UpdRelaTabDate(objzx_TextReadEN.TextRId, "SetUpdDate");
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
 /// <param name = "objzx_TextReadEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordBySql2WithReturnKey(clszx_TextReadEN objzx_TextReadEN)
{
if (objzx_TextReadEN.CheckUniqueness() == false)
{
var strMsg = string.Format("记录已经存在!课件Id = [{0}],阅读类型 = [{1}]的数据已经存在!(in clszx_TextReadBL.AddNewRecordBySql2WithReturnKey)", objzx_TextReadEN.TextId,objzx_TextReadEN.ReadTypeId);
throw new Exception(strMsg);
}
try
{
 if (string.IsNullOrEmpty(objzx_TextReadEN.TextRId) == true || clszx_TextReadBL.IsExist(objzx_TextReadEN.TextRId) == true)
 {
     objzx_TextReadEN.TextRId = clszx_TextReadBL.GetMaxStrId_S();
 }
string strKey = zx_TextReadDA.AddNewRecordBySQL2WithReturnKey(objzx_TextReadEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clszx_TextReadBL.ReFreshCache(objzx_TextReadEN.IdCurrEduCls);

if (clszx_TextReadBL.relatedActions != null)
{
clszx_TextReadBL.relatedActions.UpdRelaTabDate(objzx_TextReadEN.TextRId, "SetUpdDate");
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
 /// <param name = "objzx_TextReadEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(clszx_TextReadEN objzx_TextReadEN)
{
try
{
bool bolResult = zx_TextReadDA.Update(objzx_TextReadEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clszx_TextReadBL.ReFreshCache(objzx_TextReadEN.IdCurrEduCls);

if (clszx_TextReadBL.relatedActions != null)
{
clszx_TextReadBL.relatedActions.UpdRelaTabDate(objzx_TextReadEN.TextRId, "SetUpdDate");
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
 /// <param name = "objzx_TextReadEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateBySql2(clszx_TextReadEN objzx_TextReadEN)
{
 if (string.IsNullOrEmpty(objzx_TextReadEN.TextRId) == true)
 {
var strMsg = string.Format("(errid:Busi000065)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = zx_TextReadDA.UpdateBySql2(objzx_TextReadEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clszx_TextReadBL.ReFreshCache(objzx_TextReadEN.IdCurrEduCls);

if (clszx_TextReadBL.relatedActions != null)
{
clszx_TextReadBL.relatedActions.UpdRelaTabDate(objzx_TextReadEN.TextRId, "SetUpdDate");
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
 /// <param name = "strTextRId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int DelRecord(string strTextRId)
{
try
{
 clszx_TextReadEN objzx_TextReadEN = clszx_TextReadBL.GetObjByTextRId(strTextRId);

if (clszx_TextReadBL.relatedActions != null)
{
clszx_TextReadBL.relatedActions.UpdRelaTabDate(objzx_TextReadEN.TextRId, "SetUpdDate");
}
if (objzx_TextReadEN != null)
{
int intRecNum = zx_TextReadDA.DelRecord(strTextRId);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
ReFreshCache(objzx_TextReadEN.IdCurrEduCls);
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
/// <param name="strTextRId">表关键字</param>
 /// <param name = "strIdCurrEduCls">缓存的分类字段</param>
/// <returns></returns>
public static bool DelRecordEx(string strTextRId , string strIdCurrEduCls)
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clszx_TextReadDA.GetSpecSQLObj();
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
//删除与表:[zx_TextRead]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conzx_TextRead.TextRId,
//strTextRId);
//        clszx_TextReadBL.Delzx_TextReadsByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clszx_TextReadBL.DelRecord(strTextRId, strIdCurrEduCls, objConnection, objSqlTransaction);
objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clszx_TextReadBLEx", "DelRecordEx", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("扩展删除记录出错:{0}!keyId = {1}.({2})",
objException.Message,
strTextRId, clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "strTextRId">给定的关键字值</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回删除是否成功?</returns>
public static bool DelRecord(string strTextRId, string strIdCurrEduCls, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
if (clszx_TextReadBL.relatedActions != null)
{
clszx_TextReadBL.relatedActions.UpdRelaTabDate(strTextRId, "UpdRelaTabDate");
}
bool bolResult = zx_TextReadDA.DelRecord(strTextRId,objSqlConnection,objSqlTransaction);
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
 /// <param name = "arrTextRIdLst">给定的关键字值列表</param>
 /// <returns>返回删除的记录数</returns>
public static int Delzx_TextReads(List<string> arrTextRIdLst)
{
if (arrTextRIdLst.Count == 0) return 0;
try
{
if (clszx_TextReadBL.relatedActions != null)
{
foreach (var strTextRId in arrTextRIdLst)
{
clszx_TextReadBL.relatedActions.UpdRelaTabDate(strTextRId, "UpdRelaTabDate");
}
}
 clszx_TextReadEN objzx_TextReadEN = clszx_TextReadBL.GetObjByTextRId(arrTextRIdLst[0]);
int intDelRecNum = zx_TextReadDA.Delzx_TextRead(arrTextRIdLst);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
ReFreshCache(objzx_TextReadEN.IdCurrEduCls);
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
public static int Delzx_TextReadsByCond(string strWhereCond)
{
try
{
if (clszx_TextReadBL.relatedActions != null)
{
List<string> arrTextRId = GetPrimaryKeyID_S(strWhereCond);
foreach (var strTextRId in arrTextRId)
{
clszx_TextReadBL.relatedActions.UpdRelaTabDate(strTextRId, "UpdRelaTabDate");
}
}
List<string> arrIdCurrEduCls = GetFldValue(conzx_TextRead.IdCurrEduCls, strWhereCond);
int intRecNum = zx_TextReadDA.Delzx_TextRead(strWhereCond);
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
/// 这里仅仅是演示函数,使用时请复制到扩展类:[zx_TextRead]中改名为:[DelRecord4MultiTabEx]使用
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DelRecord4MultiTab)
/// </summary>
/// <param name="strTextRId">表关键字</param>
 /// <param name = "strIdCurrEduCls">缓存的分类字段</param>
/// <returns></returns>
public static bool DelRecord4MultiTab(string strTextRId, string strIdCurrEduCls)
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clszx_TextReadDA.GetSpecSQLObj();
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
//删除与表:[zx_TextRead]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conStudent.id_College,
//strid_College);
//        clsStudentBL.DelStudentsByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clszx_TextReadBL.DelRecord(strTextRId, strIdCurrEduCls, objConnection, objSqlTransaction);
                objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clszx_TextReadBL", "DelRecord4MultiTab", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("删除多表记录出错:{0}!keyId = {1}.({2})",
objException.Message,
strTextRId, clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "objzx_TextReadENS">源对象</param>
 /// <param name = "objzx_TextReadENT">目标对象</param>
 public static void CopyTo(clszx_TextReadEN objzx_TextReadENS, clszx_TextReadEN objzx_TextReadENT)
{
try
{
objzx_TextReadENT.TextId = objzx_TextReadENS.TextId; //课件Id
objzx_TextReadENT.ReadTypeId = objzx_TextReadENS.ReadTypeId; //阅读类型
objzx_TextReadENT.IsSubmit = objzx_TextReadENS.IsSubmit; //是否提交
objzx_TextReadENT.IsPublic = objzx_TextReadENS.IsPublic; //是否公开
objzx_TextReadENT.Submitter = objzx_TextReadENS.Submitter; //提交人
objzx_TextReadENT.IdCurrEduCls = objzx_TextReadENS.IdCurrEduCls; //教学班流水号
objzx_TextReadENT.QuestionCount = objzx_TextReadENS.QuestionCount; //问题数
objzx_TextReadENT.CreateDate = objzx_TextReadENS.CreateDate; //建立日期
objzx_TextReadENT.UpdUser = objzx_TextReadENS.UpdUser; //修改人
objzx_TextReadENT.UpdDate = objzx_TextReadENS.UpdDate; //修改日期
objzx_TextReadENT.Memo = objzx_TextReadENS.Memo; //备注
objzx_TextReadENT.TextRId = objzx_TextReadENS.TextRId; //TextRId
objzx_TextReadENT.ReaderUserId = objzx_TextReadENS.ReaderUserId; //ReaderUserId
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
 /// <param name = "objzx_TextReadEN">源简化对象</param>
 public static void SetUpdFlag(clszx_TextReadEN objzx_TextReadEN)
{
try
{
objzx_TextReadEN.ClearUpdateState();
   string strsfUpdFldSetStr = objzx_TextReadEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(conzx_TextRead.TextId, new clsStrCompareIgnoreCase())  ==  true)
{
objzx_TextReadEN.TextId = objzx_TextReadEN.TextId == "[null]" ? null :  objzx_TextReadEN.TextId; //课件Id
}
if (arrFldSet.Contains(conzx_TextRead.ReadTypeId, new clsStrCompareIgnoreCase())  ==  true)
{
objzx_TextReadEN.ReadTypeId = objzx_TextReadEN.ReadTypeId; //阅读类型
}
if (arrFldSet.Contains(conzx_TextRead.IsSubmit, new clsStrCompareIgnoreCase())  ==  true)
{
objzx_TextReadEN.IsSubmit = objzx_TextReadEN.IsSubmit; //是否提交
}
if (arrFldSet.Contains(conzx_TextRead.IsPublic, new clsStrCompareIgnoreCase())  ==  true)
{
objzx_TextReadEN.IsPublic = objzx_TextReadEN.IsPublic; //是否公开
}
if (arrFldSet.Contains(conzx_TextRead.Submitter, new clsStrCompareIgnoreCase())  ==  true)
{
objzx_TextReadEN.Submitter = objzx_TextReadEN.Submitter == "[null]" ? null :  objzx_TextReadEN.Submitter; //提交人
}
if (arrFldSet.Contains(conzx_TextRead.IdCurrEduCls, new clsStrCompareIgnoreCase())  ==  true)
{
objzx_TextReadEN.IdCurrEduCls = objzx_TextReadEN.IdCurrEduCls == "[null]" ? null :  objzx_TextReadEN.IdCurrEduCls; //教学班流水号
}
if (arrFldSet.Contains(conzx_TextRead.QuestionCount, new clsStrCompareIgnoreCase())  ==  true)
{
objzx_TextReadEN.QuestionCount = objzx_TextReadEN.QuestionCount; //问题数
}
if (arrFldSet.Contains(conzx_TextRead.CreateDate, new clsStrCompareIgnoreCase())  ==  true)
{
objzx_TextReadEN.CreateDate = objzx_TextReadEN.CreateDate == "[null]" ? null :  objzx_TextReadEN.CreateDate; //建立日期
}
if (arrFldSet.Contains(conzx_TextRead.UpdUser, new clsStrCompareIgnoreCase())  ==  true)
{
objzx_TextReadEN.UpdUser = objzx_TextReadEN.UpdUser == "[null]" ? null :  objzx_TextReadEN.UpdUser; //修改人
}
if (arrFldSet.Contains(conzx_TextRead.UpdDate, new clsStrCompareIgnoreCase())  ==  true)
{
objzx_TextReadEN.UpdDate = objzx_TextReadEN.UpdDate; //修改日期
}
if (arrFldSet.Contains(conzx_TextRead.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objzx_TextReadEN.Memo = objzx_TextReadEN.Memo == "[null]" ? null :  objzx_TextReadEN.Memo; //备注
}
if (arrFldSet.Contains(conzx_TextRead.TextRId, new clsStrCompareIgnoreCase())  ==  true)
{
objzx_TextReadEN.TextRId = objzx_TextReadEN.TextRId; //TextRId
}
if (arrFldSet.Contains(conzx_TextRead.ReaderUserId, new clsStrCompareIgnoreCase())  ==  true)
{
objzx_TextReadEN.ReaderUserId = objzx_TextReadEN.ReaderUserId == "[null]" ? null :  objzx_TextReadEN.ReaderUserId; //ReaderUserId
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
 /// <param name = "objzx_TextReadEN">源简化对象</param>
 public static void AccessFldValueNull(clszx_TextReadEN objzx_TextReadEN)
{
try
{
if (objzx_TextReadEN.TextId == "[null]") objzx_TextReadEN.TextId = null; //课件Id
if (objzx_TextReadEN.Submitter == "[null]") objzx_TextReadEN.Submitter = null; //提交人
if (objzx_TextReadEN.IdCurrEduCls == "[null]") objzx_TextReadEN.IdCurrEduCls = null; //教学班流水号
if (objzx_TextReadEN.CreateDate == "[null]") objzx_TextReadEN.CreateDate = null; //建立日期
if (objzx_TextReadEN.UpdUser == "[null]") objzx_TextReadEN.UpdUser = null; //修改人
if (objzx_TextReadEN.Memo == "[null]") objzx_TextReadEN.Memo = null; //备注
if (objzx_TextReadEN.ReaderUserId == "[null]") objzx_TextReadEN.ReaderUserId = null; //ReaderUserId
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
public static void CheckPropertyNew(clszx_TextReadEN objzx_TextReadEN)
{
 zx_TextReadDA.CheckPropertyNew(objzx_TextReadEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(clszx_TextReadEN objzx_TextReadEN)
{
 zx_TextReadDA.CheckProperty4Condition(objzx_TextReadEN);
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
if (clszx_TextReadBL.objCommFun4BL == null)
{
strMsg = string.Format("类clszx_TextReadBL没有刷新缓存机制(clszx_TextReadBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by TextRId");
//if (arrzx_TextReadObjLstCache == null)
//{
//arrzx_TextReadObjLstCache = zx_TextReadDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "strTextRId">所给的关键字</param>
 /// <param name = "strIdCurrEduCls">缓存的分类字段</param>
 /// <returns>根据关键字获取的对象</returns>
public static clszx_TextReadEN GetObjByTextRIdCache(string strTextRId, string strIdCurrEduCls)
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
string strKey = string.Format("{0}_{1}", clszx_TextReadEN._CurrTabName, strIdCurrEduCls);
List<clszx_TextReadEN> arrzx_TextReadObjLstCache = GetObjLstCache(strIdCurrEduCls);
IEnumerable <clszx_TextReadEN> arrzx_TextReadObjLst_Sel =
arrzx_TextReadObjLstCache
.Where(x=> x.TextRId == strTextRId 
);
if (arrzx_TextReadObjLst_Sel.Count() == 0)
{
   clszx_TextReadEN obj = clszx_TextReadBL.GetObjByTextRId(strTextRId);
   if (obj != null)
 {
if (obj.IdCurrEduCls == strIdCurrEduCls)
{
CacheHelper.Remove(strKey);
     return obj;
}
else
{
string strMsg = string.Format("错误: 关键字:{0}不属于分类:{1},请检查!(In {2})", strTextRId, strIdCurrEduCls, clsStackTrace.GetCurrClassFunction());
clsSysParaEN.objLog.WriteDebugLog(strMsg);
throw new Exception(strMsg);
}
 }
return null;
}
return arrzx_TextReadObjLst_Sel.First();
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clszx_TextReadEN> GetAllzx_TextReadObjLstCache(string strIdCurrEduCls)
{
//获取缓存中的对象列表
List<clszx_TextReadEN> arrzx_TextReadObjLstCache = GetObjLstCache(strIdCurrEduCls); 
return arrzx_TextReadObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clszx_TextReadEN> GetObjLstCache(string strIdCurrEduCls)
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
string strKey = string.Format("{0}_{1}", clszx_TextReadEN._CurrTabName, strIdCurrEduCls);
string strCondition = string.Format("IdCurrEduCls='{0}'", strIdCurrEduCls);
List<clszx_TextReadEN> arrzx_TextReadObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst(strCondition); });
return arrzx_TextReadObjLstCache;
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
string strKey = string.Format("{0}_{1}", clszx_TextReadEN._CurrTabName, strIdCurrEduCls);
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
if (clszx_TextReadBL.objCommFun4BL != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}_{1}", clszx_TextReadEN._CurrTabName, strIdCurrEduCls);
CacheHelper.Remove(strKey);
clszx_TextReadBL.objCommFun4BL.ReFreshCache(strIdCurrEduCls);
}
}


 #endregion 缓存操作


 #region 检查唯一性

 /// <summary>
 /// 获取检查唯一性条件串(Uniqueness)--zx_TextRead(课文阅读)
 /// 唯一性条件:TextId_ReadTypeId
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetUniquenessConditionString)
 /// </summary>
 /// <param name = "objzx_TextReadEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(clszx_TextReadEN objzx_TextReadEN)
{
//检测记录是否存在
string strResult = zx_TextReadDA.GetUniCondStr(objzx_TextReadEN);
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
public static string Func(string strInFldName, string strOutFldName, string strTextRId, string strIdCurrEduCls)
{
if (strInFldName != conzx_TextRead.TextRId)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (conzx_TextRead.AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", conzx_TextRead.AttributeName));
throw new Exception(strMsg);
}
var objzx_TextRead = clszx_TextReadBL.GetObjByTextRIdCache(strTextRId, strIdCurrEduCls);
if (objzx_TextRead == null) return "";
return objzx_TextRead[strOutFldName].ToString();
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
int intRecCount = clszx_TextReadDA.GetRecCount(strTabName);
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
int intRecCount = clszx_TextReadDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clszx_TextReadDA.GetRecCount();
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
int intRecCount = clszx_TextReadDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objzx_TextReadCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clszx_TextReadEN objzx_TextReadCond)
{
 string strIdCurrEduCls = objzx_TextReadCond.IdCurrEduCls;
 if (string.IsNullOrEmpty(strIdCurrEduCls) == true)
{
string strMsg = string.Format("(errid:Busi000174)在表中,缓存分类字段值不能为空!(clszx_TextReadBL:GetRecCountByCondCache)");
throw new Exception(strMsg);
}
List<clszx_TextReadEN> arrObjLstCache = GetObjLstCache(strIdCurrEduCls);
IEnumerable <clszx_TextReadEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in conzx_TextRead.AttributeName)
{
if (objzx_TextReadCond.IsUpdated(strFldName) == false) continue;
if (objzx_TextReadCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objzx_TextReadCond[strFldName].ToString());
}
else
{
if (objzx_TextReadCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objzx_TextReadCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objzx_TextReadCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objzx_TextReadCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objzx_TextReadCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objzx_TextReadCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objzx_TextReadCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objzx_TextReadCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objzx_TextReadCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objzx_TextReadCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objzx_TextReadCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objzx_TextReadCond[strFldName]));
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
 List<string> arrList = clszx_TextReadDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = zx_TextReadDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = zx_TextReadDA.GetFldValueNoDistinct(strFldName, strWhereCond);
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
int intRecCount = zx_TextReadDA.SetFldValue(strFldName, strValue, strWhereCond);
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
int intRecCount = clszx_TextReadDA.SetFldValue(clszx_TextReadEN._CurrTabName, strFldName, fltValue, strWhereCond);
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
int intRecCount = zx_TextReadDA.SetFldValue( strFldName, intValue, strWhereCond);
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
int intRecCount = clszx_TextReadDA.SetFldValue(strTabName, strFldName, strValue, strWhereCond);
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
int intRecCount = clszx_TextReadDA.SetFldValue(strTabName, strFldName, intValue, strWhereCond);
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
int intRecCount = clszx_TextReadDA.SetFldValue(strTabName, strFldName, fltValue, strWhereCond);
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
  strCreateTabCode.Append("CREATE table [dbo].[zx_TextRead] "); 
 strCreateTabCode.Append(" ( "); 
 // /**课件Id*/ 
 strCreateTabCode.Append(" TextId char(8) Null, "); 
 // /**阅读类型*/ 
 strCreateTabCode.Append(" ReadTypeId char(2) not Null, "); 
 // /**是否提交*/ 
 strCreateTabCode.Append(" IsSubmit bit Null, "); 
 // /**是否公开*/ 
 strCreateTabCode.Append(" IsPublic bit Null, "); 
 // /**提交人*/ 
 strCreateTabCode.Append(" Submitter varchar(50) Null, "); 
 // /**教学班流水号*/ 
 strCreateTabCode.Append(" IdCurrEduCls char(8) Null, "); 
 // /**问题数*/ 
 strCreateTabCode.Append(" QuestionCount int Null, "); 
 // /**建立日期*/ 
 strCreateTabCode.Append(" CreateDate varchar(20) Null, "); 
 // /**修改人*/ 
 strCreateTabCode.Append(" UpdUser varchar(20) Null, "); 
 // /**修改日期*/ 
 strCreateTabCode.Append(" UpdDate varchar(20) not Null, "); 
 // /**备注*/ 
 strCreateTabCode.Append(" Memo varchar(1000) Null, "); 
 // /**TextRId*/ 
 strCreateTabCode.Append(" TextRId char(10) primary key, "); 
 // /**ReaderUserId*/ 
 strCreateTabCode.Append(" ReaderUserId varchar(20) Null ");
 strCreateTabCode.Append(") "); 
  strCreateTabCode.Append("ON [PRIMARY] ");
  return strCreateTabCode.ToString();
}



 #endregion 表操作
}
 /// <summary>
 /// 课文阅读(zx_TextRead)
 /// 数据源类型:表
 /// (AutoGCLib.CommFun4BL4CSharp:GeneCode_This)
 /// </summary>
public class  clsCommFun4BL4zx_TextRead : clsCommFun4BLV2
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
clszx_TextReadBL.ReFreshThisCache(strIdCurrEduCls);
}
}

}