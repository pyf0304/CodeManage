
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsgs_PaperParagraphVerBL
 表名:gs_PaperParagraphVer(01120743)
 * 版本:2024.11.13.1(服务器:WIN-SRV103-116)
 日期:2024/11/13 06:10:51
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:研究生学习游戏化后台(000055, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:研培论文(GradEduPaper)
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
public static class  clsgs_PaperParagraphVerBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "lngParagraphVId">表关键字</param>
 /// <returns>表对象</returns>
public static clsgs_PaperParagraphVerEN GetObj(this K_ParagraphVId_gs_PaperParagraphVer myKey)
{
clsgs_PaperParagraphVerEN objgs_PaperParagraphVerEN = clsgs_PaperParagraphVerBL.gs_PaperParagraphVerDA.GetObjByParagraphVId(myKey.Value);
return objgs_PaperParagraphVerEN;
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_AddNewRecord)
 /// </summary>
 /// <param name = "objgs_PaperParagraphVerEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clsgs_PaperParagraphVerEN objgs_PaperParagraphVerEN, bool bolIsNeedCheckUniqueness = true)
{
if (bolIsNeedCheckUniqueness == true && CheckUniqueness(objgs_PaperParagraphVerEN) == false)
{
var strMsg = string.Format("记录已经存在!段落版本Id = [{0}]的数据已经存在!(in clsgs_PaperParagraphVerBL.AddNewRecord)", objgs_PaperParagraphVerEN.ParagraphVId);
throw new Exception(strMsg);
}
try
{
bool bolResult = clsgs_PaperParagraphVerBL.gs_PaperParagraphVerDA.AddNewRecordBySQL2(objgs_PaperParagraphVerEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsgs_PaperParagraphVerBL.ReFreshCache();

if (clsgs_PaperParagraphVerBL.relatedActions != null)
{
clsgs_PaperParagraphVerBL.relatedActions.UpdRelaTabDate(objgs_PaperParagraphVerEN.ParagraphVId, "SetUpdDate");
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
public static bool AddRecordEx(this clsgs_PaperParagraphVerEN objgs_PaperParagraphVerEN, bool bolIsNeedCheckUniqueness = true)
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
objgs_PaperParagraphVerEN.CheckPropertyNew();
 ///5.2、检查唯一性
if (bolIsNeedCheckUniqueness == true && objgs_PaperParagraphVerEN.CheckUniqueness() == false)
{
strMsg = string.Format("(段落版本Id(ParagraphVId)=[{0}])已经存在,不能重复!", objgs_PaperParagraphVerEN.ParagraphVId);
throw new Exception(strMsg);
}
//6、把数据实体层的数据存贮到数据库中
objgs_PaperParagraphVerEN.AddNewRecord();
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
 /// <param name = "objgs_PaperParagraphVerEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordWithReturnKey(this clsgs_PaperParagraphVerEN objgs_PaperParagraphVerEN, bool bolIsNeedCheckUniqueness = true)
{
if (bolIsNeedCheckUniqueness == true && CheckUniqueness(objgs_PaperParagraphVerEN) == false)
{
var strMsg = string.Format("记录已经存在!段落版本Id = [{0}]的数据已经存在!(in clsgs_PaperParagraphVerBL.AddNewRecordWithReturnKey)", objgs_PaperParagraphVerEN.ParagraphVId);
throw new Exception(strMsg);
}
try
{
string strKey = clsgs_PaperParagraphVerBL.gs_PaperParagraphVerDA.AddNewRecordBySQL2WithReturnKey(objgs_PaperParagraphVerEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsgs_PaperParagraphVerBL.ReFreshCache();

if (clsgs_PaperParagraphVerBL.relatedActions != null)
{
clsgs_PaperParagraphVerBL.relatedActions.UpdRelaTabDate(objgs_PaperParagraphVerEN.ParagraphVId, "SetUpdDate");
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
 /// <param name = "objgs_PaperParagraphVerEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsgs_PaperParagraphVerEN SetParagraphVId(this clsgs_PaperParagraphVerEN objgs_PaperParagraphVerEN, long lngParagraphVId, string strComparisonOp="")
	{
objgs_PaperParagraphVerEN.ParagraphVId = lngParagraphVId; //段落版本Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objgs_PaperParagraphVerEN.dicFldComparisonOp.ContainsKey(congs_PaperParagraphVer.ParagraphVId) == false)
{
objgs_PaperParagraphVerEN.dicFldComparisonOp.Add(congs_PaperParagraphVer.ParagraphVId, strComparisonOp);
}
else
{
objgs_PaperParagraphVerEN.dicFldComparisonOp[congs_PaperParagraphVer.ParagraphVId] = strComparisonOp;
}
}
return objgs_PaperParagraphVerEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objgs_PaperParagraphVerEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsgs_PaperParagraphVerEN SetParagraphId(this clsgs_PaperParagraphVerEN objgs_PaperParagraphVerEN, string strParagraphId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strParagraphId, congs_PaperParagraphVer.ParagraphId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strParagraphId, 10, congs_PaperParagraphVer.ParagraphId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strParagraphId, 10, congs_PaperParagraphVer.ParagraphId);
}
objgs_PaperParagraphVerEN.ParagraphId = strParagraphId; //段落Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objgs_PaperParagraphVerEN.dicFldComparisonOp.ContainsKey(congs_PaperParagraphVer.ParagraphId) == false)
{
objgs_PaperParagraphVerEN.dicFldComparisonOp.Add(congs_PaperParagraphVer.ParagraphId, strComparisonOp);
}
else
{
objgs_PaperParagraphVerEN.dicFldComparisonOp[congs_PaperParagraphVer.ParagraphId] = strComparisonOp;
}
}
return objgs_PaperParagraphVerEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objgs_PaperParagraphVerEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsgs_PaperParagraphVerEN SetSectionId(this clsgs_PaperParagraphVerEN objgs_PaperParagraphVerEN, string strSectionId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strSectionId, congs_PaperParagraphVer.SectionId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strSectionId, 8, congs_PaperParagraphVer.SectionId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strSectionId, 8, congs_PaperParagraphVer.SectionId);
}
objgs_PaperParagraphVerEN.SectionId = strSectionId; //节Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objgs_PaperParagraphVerEN.dicFldComparisonOp.ContainsKey(congs_PaperParagraphVer.SectionId) == false)
{
objgs_PaperParagraphVerEN.dicFldComparisonOp.Add(congs_PaperParagraphVer.SectionId, strComparisonOp);
}
else
{
objgs_PaperParagraphVerEN.dicFldComparisonOp[congs_PaperParagraphVer.SectionId] = strComparisonOp;
}
}
return objgs_PaperParagraphVerEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objgs_PaperParagraphVerEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsgs_PaperParagraphVerEN SetParagraphTypeId(this clsgs_PaperParagraphVerEN objgs_PaperParagraphVerEN, string strParagraphTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strParagraphTypeId, congs_PaperParagraphVer.ParagraphTypeId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strParagraphTypeId, 2, congs_PaperParagraphVer.ParagraphTypeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strParagraphTypeId, 2, congs_PaperParagraphVer.ParagraphTypeId);
}
objgs_PaperParagraphVerEN.ParagraphTypeId = strParagraphTypeId; //段落类型Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objgs_PaperParagraphVerEN.dicFldComparisonOp.ContainsKey(congs_PaperParagraphVer.ParagraphTypeId) == false)
{
objgs_PaperParagraphVerEN.dicFldComparisonOp.Add(congs_PaperParagraphVer.ParagraphTypeId, strComparisonOp);
}
else
{
objgs_PaperParagraphVerEN.dicFldComparisonOp[congs_PaperParagraphVer.ParagraphTypeId] = strComparisonOp;
}
}
return objgs_PaperParagraphVerEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objgs_PaperParagraphVerEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsgs_PaperParagraphVerEN SetParagraphContent(this clsgs_PaperParagraphVerEN objgs_PaperParagraphVerEN, string strParagraphContent, string strComparisonOp="")
	{
objgs_PaperParagraphVerEN.ParagraphContent = strParagraphContent; //段落内容
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objgs_PaperParagraphVerEN.dicFldComparisonOp.ContainsKey(congs_PaperParagraphVer.ParagraphContent) == false)
{
objgs_PaperParagraphVerEN.dicFldComparisonOp.Add(congs_PaperParagraphVer.ParagraphContent, strComparisonOp);
}
else
{
objgs_PaperParagraphVerEN.dicFldComparisonOp[congs_PaperParagraphVer.ParagraphContent] = strComparisonOp;
}
}
return objgs_PaperParagraphVerEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objgs_PaperParagraphVerEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsgs_PaperParagraphVerEN SetUpdDate(this clsgs_PaperParagraphVerEN objgs_PaperParagraphVerEN, string strUpdDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdDate, 20, congs_PaperParagraphVer.UpdDate);
}
objgs_PaperParagraphVerEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objgs_PaperParagraphVerEN.dicFldComparisonOp.ContainsKey(congs_PaperParagraphVer.UpdDate) == false)
{
objgs_PaperParagraphVerEN.dicFldComparisonOp.Add(congs_PaperParagraphVer.UpdDate, strComparisonOp);
}
else
{
objgs_PaperParagraphVerEN.dicFldComparisonOp[congs_PaperParagraphVer.UpdDate] = strComparisonOp;
}
}
return objgs_PaperParagraphVerEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objgs_PaperParagraphVerEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsgs_PaperParagraphVerEN SetUpdUser(this clsgs_PaperParagraphVerEN objgs_PaperParagraphVerEN, string strUpdUser, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdUser, 20, congs_PaperParagraphVer.UpdUser);
}
objgs_PaperParagraphVerEN.UpdUser = strUpdUser; //修改人
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objgs_PaperParagraphVerEN.dicFldComparisonOp.ContainsKey(congs_PaperParagraphVer.UpdUser) == false)
{
objgs_PaperParagraphVerEN.dicFldComparisonOp.Add(congs_PaperParagraphVer.UpdUser, strComparisonOp);
}
else
{
objgs_PaperParagraphVerEN.dicFldComparisonOp[congs_PaperParagraphVer.UpdUser] = strComparisonOp;
}
}
return objgs_PaperParagraphVerEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objgs_PaperParagraphVerEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsgs_PaperParagraphVerEN SetMemo(this clsgs_PaperParagraphVerEN objgs_PaperParagraphVerEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, congs_PaperParagraphVer.Memo);
}
objgs_PaperParagraphVerEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objgs_PaperParagraphVerEN.dicFldComparisonOp.ContainsKey(congs_PaperParagraphVer.Memo) == false)
{
objgs_PaperParagraphVerEN.dicFldComparisonOp.Add(congs_PaperParagraphVer.Memo, strComparisonOp);
}
else
{
objgs_PaperParagraphVerEN.dicFldComparisonOp[congs_PaperParagraphVer.Memo] = strComparisonOp;
}
}
return objgs_PaperParagraphVerEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objgs_PaperParagraphVerEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsgs_PaperParagraphVerEN SetPaperId(this clsgs_PaperParagraphVerEN objgs_PaperParagraphVerEN, string strPaperId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPaperId, 8, congs_PaperParagraphVer.PaperId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strPaperId, 8, congs_PaperParagraphVer.PaperId);
}
objgs_PaperParagraphVerEN.PaperId = strPaperId; //论文Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objgs_PaperParagraphVerEN.dicFldComparisonOp.ContainsKey(congs_PaperParagraphVer.PaperId) == false)
{
objgs_PaperParagraphVerEN.dicFldComparisonOp.Add(congs_PaperParagraphVer.PaperId, strComparisonOp);
}
else
{
objgs_PaperParagraphVerEN.dicFldComparisonOp[congs_PaperParagraphVer.PaperId] = strComparisonOp;
}
}
return objgs_PaperParagraphVerEN;
	}

 /// <summary>
 /// 修改记录存盘到数据表中
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_UpdateRecordEx)
 /// </summary>
 /// <param name = "objgs_PaperParagraphVerEN">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool UpdateRecordEx(this clsgs_PaperParagraphVerEN objgs_PaperParagraphVerEN)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
string strMsg;	//专门用于传递信息的变量
try
{
//1、检查传进去的对象属性是否合法
objgs_PaperParagraphVerEN.CheckPropertyNew();
clsgs_PaperParagraphVerEN objgs_PaperParagraphVerCond = new clsgs_PaperParagraphVerEN();
string strCondition = objgs_PaperParagraphVerCond
.SetParagraphVId(objgs_PaperParagraphVerEN.ParagraphVId, "<>")
.SetParagraphVId(objgs_PaperParagraphVerEN.ParagraphVId, "=")
.GetCombineCondition();
objgs_PaperParagraphVerEN._IsCheckProperty = true;
bool bolIsExist = clsgs_PaperParagraphVerBL.IsExistRecord(strCondition);
if (bolIsExist)
{
strMsg = "(ParagraphVId)不能重复!";
throw new Exception(strMsg);
}
//4、把数据实体层的数据存贮到数据库中
objgs_PaperParagraphVerEN.Update();
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
 /// <param name = "objgs_PaperParagraphVer">需要修改的实体对象</param>
 /// <returns>修改是否成功？</returns>
public static bool EditRecordEx(this clsgs_PaperParagraphVerEN objgs_PaperParagraphVer)
{
//操作步骤:
//1、检查传进去的对象属性是否合法
//2、检查唯一性
//3、把数据实体层的数据存贮到数据库中
clsgs_PaperParagraphVerEN objgs_PaperParagraphVerCond = new clsgs_PaperParagraphVerEN();
string strCondition = objgs_PaperParagraphVerCond
.SetParagraphVId(objgs_PaperParagraphVer.ParagraphVId, "=")
.GetCombineCondition();
objgs_PaperParagraphVer._IsCheckProperty = true;
bool bolIsExist = clsgs_PaperParagraphVerBL.IsExistRecord(strCondition);
if (bolIsExist)
{
objgs_PaperParagraphVer.ParagraphVId = clsgs_PaperParagraphVerBL.GetFirstID_S(strCondition);
objgs_PaperParagraphVer.UpdateWithCondition(strCondition);
}
else
{
objgs_PaperParagraphVer.AddNewRecord();
}
return true; 
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_Update)
 /// </summary>
 /// <param name = "objgs_PaperParagraphVerEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsgs_PaperParagraphVerEN objgs_PaperParagraphVerEN)
{
 if (objgs_PaperParagraphVerEN.ParagraphVId == 0)
 {
string strMsg = string.Format("(errid:Busi000095)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsgs_PaperParagraphVerBL.gs_PaperParagraphVerDA.UpdateBySql2(objgs_PaperParagraphVerEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsgs_PaperParagraphVerBL.ReFreshCache();

if (clsgs_PaperParagraphVerBL.relatedActions != null)
{
clsgs_PaperParagraphVerBL.relatedActions.UpdRelaTabDate(objgs_PaperParagraphVerEN.ParagraphVId, "SetUpdDate");
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
 /// <param name = "objgs_PaperParagraphVerEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsgs_PaperParagraphVerEN objgs_PaperParagraphVerEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (objgs_PaperParagraphVerEN.ParagraphVId == 0)
 {
string strMsg = string.Format("(errid:Busi000087)修改记录时关键字不能为空!(带事务处理)(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = clsgs_PaperParagraphVerBL.gs_PaperParagraphVerDA.UpdateBySql2(objgs_PaperParagraphVerEN, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsgs_PaperParagraphVerBL.ReFreshCache();

if (clsgs_PaperParagraphVerBL.relatedActions != null)
{
clsgs_PaperParagraphVerBL.relatedActions.UpdRelaTabDate(objgs_PaperParagraphVerEN.ParagraphVId, "SetUpdDate");
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
 /// <param name = "objgs_PaperParagraphVerEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsgs_PaperParagraphVerEN objgs_PaperParagraphVerEN, string strWhereCond)
{
try
{
bool bolResult = clsgs_PaperParagraphVerBL.gs_PaperParagraphVerDA.UpdateBySqlWithCondition(objgs_PaperParagraphVerEN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsgs_PaperParagraphVerBL.ReFreshCache();

if (clsgs_PaperParagraphVerBL.relatedActions != null)
{
clsgs_PaperParagraphVerBL.relatedActions.UpdRelaTabDate(objgs_PaperParagraphVerEN.ParagraphVId, "SetUpdDate");
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
 /// <param name = "objgs_PaperParagraphVerEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsgs_PaperParagraphVerEN objgs_PaperParagraphVerEN, string strWhereCond, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
bool bolResult = clsgs_PaperParagraphVerBL.gs_PaperParagraphVerDA.UpdateBySqlWithConditionTransaction(objgs_PaperParagraphVerEN, strWhereCond, objSqlConnection, objSqlTransaction);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsgs_PaperParagraphVerBL.ReFreshCache();

if (clsgs_PaperParagraphVerBL.relatedActions != null)
{
clsgs_PaperParagraphVerBL.relatedActions.UpdRelaTabDate(objgs_PaperParagraphVerEN.ParagraphVId, "SetUpdDate");
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
 /// <param name = "lngParagraphVId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int Delete(this clsgs_PaperParagraphVerEN objgs_PaperParagraphVerEN)
{
try
{
int intRecNum = clsgs_PaperParagraphVerBL.gs_PaperParagraphVerDA.DelRecord(objgs_PaperParagraphVerEN.ParagraphVId);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsgs_PaperParagraphVerBL.ReFreshCache();

if (clsgs_PaperParagraphVerBL.relatedActions != null)
{
clsgs_PaperParagraphVerBL.relatedActions.UpdRelaTabDate(objgs_PaperParagraphVerEN.ParagraphVId, "SetUpdDate");
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
 /// <param name = "objgs_PaperParagraphVerENS">源对象</param>
 /// <param name = "objgs_PaperParagraphVerENT">目标对象</param>
 public static void CopyTo(this clsgs_PaperParagraphVerEN objgs_PaperParagraphVerENS, clsgs_PaperParagraphVerEN objgs_PaperParagraphVerENT)
{
try
{
objgs_PaperParagraphVerENT.ParagraphVId = objgs_PaperParagraphVerENS.ParagraphVId; //段落版本Id
objgs_PaperParagraphVerENT.ParagraphId = objgs_PaperParagraphVerENS.ParagraphId; //段落Id
objgs_PaperParagraphVerENT.SectionId = objgs_PaperParagraphVerENS.SectionId; //节Id
objgs_PaperParagraphVerENT.ParagraphTypeId = objgs_PaperParagraphVerENS.ParagraphTypeId; //段落类型Id
objgs_PaperParagraphVerENT.ParagraphContent = objgs_PaperParagraphVerENS.ParagraphContent; //段落内容
objgs_PaperParagraphVerENT.UpdDate = objgs_PaperParagraphVerENS.UpdDate; //修改日期
objgs_PaperParagraphVerENT.UpdUser = objgs_PaperParagraphVerENS.UpdUser; //修改人
objgs_PaperParagraphVerENT.Memo = objgs_PaperParagraphVerENS.Memo; //备注
objgs_PaperParagraphVerENT.PaperId = objgs_PaperParagraphVerENS.PaperId; //论文Id
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
 /// <param name = "objgs_PaperParagraphVerENS">源对象</param>
 /// <returns>目标对象=>clsgs_PaperParagraphVerEN:objgs_PaperParagraphVerENT</returns>
 public static clsgs_PaperParagraphVerEN CopyTo(this clsgs_PaperParagraphVerEN objgs_PaperParagraphVerENS)
{
try
{
 clsgs_PaperParagraphVerEN objgs_PaperParagraphVerENT = new clsgs_PaperParagraphVerEN()
{
ParagraphVId = objgs_PaperParagraphVerENS.ParagraphVId, //段落版本Id
ParagraphId = objgs_PaperParagraphVerENS.ParagraphId, //段落Id
SectionId = objgs_PaperParagraphVerENS.SectionId, //节Id
ParagraphTypeId = objgs_PaperParagraphVerENS.ParagraphTypeId, //段落类型Id
ParagraphContent = objgs_PaperParagraphVerENS.ParagraphContent, //段落内容
UpdDate = objgs_PaperParagraphVerENS.UpdDate, //修改日期
UpdUser = objgs_PaperParagraphVerENS.UpdUser, //修改人
Memo = objgs_PaperParagraphVerENS.Memo, //备注
PaperId = objgs_PaperParagraphVerENS.PaperId, //论文Id
};
 return objgs_PaperParagraphVerENT;
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
public static void CheckPropertyNew(this clsgs_PaperParagraphVerEN objgs_PaperParagraphVerEN)
{
 clsgs_PaperParagraphVerBL.gs_PaperParagraphVerDA.CheckPropertyNew(objgs_PaperParagraphVerEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(this clsgs_PaperParagraphVerEN objgs_PaperParagraphVerEN)
{
 clsgs_PaperParagraphVerBL.gs_PaperParagraphVerDA.CheckProperty4Condition(objgs_PaperParagraphVerEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsgs_PaperParagraphVerEN objgs_PaperParagraphVerCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objgs_PaperParagraphVerCond.IsUpdated(congs_PaperParagraphVer.ParagraphVId) == true)
{
string strComparisonOpParagraphVId = objgs_PaperParagraphVerCond.dicFldComparisonOp[congs_PaperParagraphVer.ParagraphVId];
strWhereCond += string.Format(" And {0} {2} {1}", congs_PaperParagraphVer.ParagraphVId, objgs_PaperParagraphVerCond.ParagraphVId, strComparisonOpParagraphVId);
}
if (objgs_PaperParagraphVerCond.IsUpdated(congs_PaperParagraphVer.ParagraphId) == true)
{
string strComparisonOpParagraphId = objgs_PaperParagraphVerCond.dicFldComparisonOp[congs_PaperParagraphVer.ParagraphId];
strWhereCond += string.Format(" And {0} {2} '{1}'", congs_PaperParagraphVer.ParagraphId, objgs_PaperParagraphVerCond.ParagraphId, strComparisonOpParagraphId);
}
if (objgs_PaperParagraphVerCond.IsUpdated(congs_PaperParagraphVer.SectionId) == true)
{
string strComparisonOpSectionId = objgs_PaperParagraphVerCond.dicFldComparisonOp[congs_PaperParagraphVer.SectionId];
strWhereCond += string.Format(" And {0} {2} '{1}'", congs_PaperParagraphVer.SectionId, objgs_PaperParagraphVerCond.SectionId, strComparisonOpSectionId);
}
if (objgs_PaperParagraphVerCond.IsUpdated(congs_PaperParagraphVer.ParagraphTypeId) == true)
{
string strComparisonOpParagraphTypeId = objgs_PaperParagraphVerCond.dicFldComparisonOp[congs_PaperParagraphVer.ParagraphTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", congs_PaperParagraphVer.ParagraphTypeId, objgs_PaperParagraphVerCond.ParagraphTypeId, strComparisonOpParagraphTypeId);
}
//数据类型string(text)在函数:[AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj]中没有处理!
if (objgs_PaperParagraphVerCond.IsUpdated(congs_PaperParagraphVer.UpdDate) == true)
{
string strComparisonOpUpdDate = objgs_PaperParagraphVerCond.dicFldComparisonOp[congs_PaperParagraphVer.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", congs_PaperParagraphVer.UpdDate, objgs_PaperParagraphVerCond.UpdDate, strComparisonOpUpdDate);
}
if (objgs_PaperParagraphVerCond.IsUpdated(congs_PaperParagraphVer.UpdUser) == true)
{
string strComparisonOpUpdUser = objgs_PaperParagraphVerCond.dicFldComparisonOp[congs_PaperParagraphVer.UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", congs_PaperParagraphVer.UpdUser, objgs_PaperParagraphVerCond.UpdUser, strComparisonOpUpdUser);
}
if (objgs_PaperParagraphVerCond.IsUpdated(congs_PaperParagraphVer.Memo) == true)
{
string strComparisonOpMemo = objgs_PaperParagraphVerCond.dicFldComparisonOp[congs_PaperParagraphVer.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", congs_PaperParagraphVer.Memo, objgs_PaperParagraphVerCond.Memo, strComparisonOpMemo);
}
if (objgs_PaperParagraphVerCond.IsUpdated(congs_PaperParagraphVer.PaperId) == true)
{
string strComparisonOpPaperId = objgs_PaperParagraphVerCond.dicFldComparisonOp[congs_PaperParagraphVer.PaperId];
strWhereCond += string.Format(" And {0} {2} '{1}'", congs_PaperParagraphVer.PaperId, objgs_PaperParagraphVerCond.PaperId, strComparisonOpPaperId);
}
 return strWhereCond;
}

 /// <summary>
 /// 检查唯一性(Uniqueness)--gs_PaperParagraphVer(论文段落版本), 如果不唯一,即存在相同的记录,就返回False
 /// 唯一性条件:ParagraphVId
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckConstraint)
 /// </summary>
 /// <param name = "objgs_PaperParagraphVerEN">要求唯一的对象</param>
 /// <returns></returns>
public static bool CheckUniqueness(this clsgs_PaperParagraphVerEN objgs_PaperParagraphVerEN)
{
//检测记录是否存在
bool bolIsUniqueness;
StringBuilder sbCondition = new StringBuilder();
if (objgs_PaperParagraphVerEN == null) return true;
if (objgs_PaperParagraphVerEN.ParagraphVId == 0)
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and ParagraphVId = '{0}'", objgs_PaperParagraphVerEN.ParagraphVId);
if (clsgs_PaperParagraphVerBL.IsExistRecord(sbCondition.ToString())  ==  true)
{
 bolIsUniqueness = false;
}
else
{
 bolIsUniqueness = true;
}
}
 else {
sbCondition.AppendFormat("ParagraphVId !=  {0}", objgs_PaperParagraphVerEN.ParagraphVId);
 sbCondition.AppendFormat(" and ParagraphVId = '{0}'", objgs_PaperParagraphVerEN.ParagraphVId);
if (clsgs_PaperParagraphVerBL.IsExistRecord(sbCondition.ToString())  ==  true)
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
 /// 获取唯一性条件串--gs_PaperParagraphVer(论文段落版本), 即由对象中唯一性条件字段关键字与值组成的条件串
 /// 唯一性条件:ParagraphVId
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetConditionString4Constraint)
 /// </summary>
 /// <param name = "objgs_PaperParagraphVerEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(this clsgs_PaperParagraphVerEN objgs_PaperParagraphVerEN)
{
//检测记录是否存在
StringBuilder sbCondition = new StringBuilder();
if (objgs_PaperParagraphVerEN == null) return "";
if (objgs_PaperParagraphVerEN.ParagraphVId == 0)
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and ParagraphVId = '{0}'", objgs_PaperParagraphVerEN.ParagraphVId);
return sbCondition.ToString();
}
 else {
sbCondition.AppendFormat("ParagraphVId !=  {0}", objgs_PaperParagraphVerEN.ParagraphVId);
 sbCondition.AppendFormat(" and ParagraphVId = '{0}'", objgs_PaperParagraphVerEN.ParagraphVId);
 return sbCondition.ToString();
}
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_gs_PaperParagraphVer
{
public virtual bool UpdRelaTabDate(long lngParagraphVId, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// 论文段落版本(gs_PaperParagraphVer)
 /// 数据源类型:表
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsgs_PaperParagraphVerBL
{
public static RelatedActions_gs_PaperParagraphVer relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsgs_PaperParagraphVerDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsgs_PaperParagraphVerDA gs_PaperParagraphVerDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsgs_PaperParagraphVerDA();
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
 public clsgs_PaperParagraphVerBL()
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
if (string.IsNullOrEmpty(clsgs_PaperParagraphVerEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsgs_PaperParagraphVerEN._ConnectString);
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
public static DataTable GetDataTable_gs_PaperParagraphVer(string strWhereCond)
{
DataTable objDT;
try
{
objDT = gs_PaperParagraphVerDA.GetDataTable_gs_PaperParagraphVer(strWhereCond);
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
objDT = gs_PaperParagraphVerDA.GetDataTable(strWhereCond);
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
objDT = gs_PaperParagraphVerDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = gs_PaperParagraphVerDA.GetDataTable(strWhereCond, strTabName);
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
objDT = gs_PaperParagraphVerDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = gs_PaperParagraphVerDA.GetDataTable_Top(objTopPara);
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
objDT = gs_PaperParagraphVerDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = gs_PaperParagraphVerDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = gs_PaperParagraphVerDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
 /// <param name = "arrParagraphVIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static List<clsgs_PaperParagraphVerEN> GetObjLstByParagraphVIdLst(List<long> arrParagraphVIdLst)
{
List<clsgs_PaperParagraphVerEN> arrObjLst = new List<clsgs_PaperParagraphVerEN>(); 
System.Data.DataTable objDT; 
 string strSqlConditionStr = clsArray.GetSqlInStrByArray(arrParagraphVIdLst);
 string strWhereCond = string.Format("ParagraphVId in ({0})", strSqlConditionStr);
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsgs_PaperParagraphVerEN objgs_PaperParagraphVerEN = new clsgs_PaperParagraphVerEN();
try
{
objgs_PaperParagraphVerEN.ParagraphVId = Int32.Parse(objRow[congs_PaperParagraphVer.ParagraphVId].ToString().Trim()); //段落版本Id
objgs_PaperParagraphVerEN.ParagraphId = objRow[congs_PaperParagraphVer.ParagraphId].ToString().Trim(); //段落Id
objgs_PaperParagraphVerEN.SectionId = objRow[congs_PaperParagraphVer.SectionId].ToString().Trim(); //节Id
objgs_PaperParagraphVerEN.ParagraphTypeId = objRow[congs_PaperParagraphVer.ParagraphTypeId].ToString().Trim(); //段落类型Id
objgs_PaperParagraphVerEN.ParagraphContent = objRow[congs_PaperParagraphVer.ParagraphContent] == DBNull.Value ? null : objRow[congs_PaperParagraphVer.ParagraphContent].ToString().Trim(); //段落内容
objgs_PaperParagraphVerEN.UpdDate = objRow[congs_PaperParagraphVer.UpdDate] == DBNull.Value ? null : objRow[congs_PaperParagraphVer.UpdDate].ToString().Trim(); //修改日期
objgs_PaperParagraphVerEN.UpdUser = objRow[congs_PaperParagraphVer.UpdUser] == DBNull.Value ? null : objRow[congs_PaperParagraphVer.UpdUser].ToString().Trim(); //修改人
objgs_PaperParagraphVerEN.Memo = objRow[congs_PaperParagraphVer.Memo] == DBNull.Value ? null : objRow[congs_PaperParagraphVer.Memo].ToString().Trim(); //备注
objgs_PaperParagraphVerEN.PaperId = objRow[congs_PaperParagraphVer.PaperId] == DBNull.Value ? null : objRow[congs_PaperParagraphVer.PaperId].ToString().Trim(); //论文Id
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objgs_PaperParagraphVerEN.ParagraphVId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objgs_PaperParagraphVerEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrParagraphVIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsgs_PaperParagraphVerEN> GetObjLstByParagraphVIdLstCache(List<long> arrParagraphVIdLst)
{
string strKey = string.Format("{0}", clsgs_PaperParagraphVerEN._CurrTabName);
List<clsgs_PaperParagraphVerEN> arrgs_PaperParagraphVerObjLstCache = GetObjLstCache();
IEnumerable <clsgs_PaperParagraphVerEN> arrgs_PaperParagraphVerObjLst_Sel =
arrgs_PaperParagraphVerObjLstCache
.Where(x => arrParagraphVIdLst.Contains(x.ParagraphVId));
return arrgs_PaperParagraphVerObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsgs_PaperParagraphVerEN> GetObjLst(string strWhereCond)
{
List<clsgs_PaperParagraphVerEN> arrObjLst = new List<clsgs_PaperParagraphVerEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsgs_PaperParagraphVerEN objgs_PaperParagraphVerEN = new clsgs_PaperParagraphVerEN();
try
{
objgs_PaperParagraphVerEN.ParagraphVId = Int32.Parse(objRow[congs_PaperParagraphVer.ParagraphVId].ToString().Trim()); //段落版本Id
objgs_PaperParagraphVerEN.ParagraphId = objRow[congs_PaperParagraphVer.ParagraphId].ToString().Trim(); //段落Id
objgs_PaperParagraphVerEN.SectionId = objRow[congs_PaperParagraphVer.SectionId].ToString().Trim(); //节Id
objgs_PaperParagraphVerEN.ParagraphTypeId = objRow[congs_PaperParagraphVer.ParagraphTypeId].ToString().Trim(); //段落类型Id
objgs_PaperParagraphVerEN.ParagraphContent = objRow[congs_PaperParagraphVer.ParagraphContent] == DBNull.Value ? null : objRow[congs_PaperParagraphVer.ParagraphContent].ToString().Trim(); //段落内容
objgs_PaperParagraphVerEN.UpdDate = objRow[congs_PaperParagraphVer.UpdDate] == DBNull.Value ? null : objRow[congs_PaperParagraphVer.UpdDate].ToString().Trim(); //修改日期
objgs_PaperParagraphVerEN.UpdUser = objRow[congs_PaperParagraphVer.UpdUser] == DBNull.Value ? null : objRow[congs_PaperParagraphVer.UpdUser].ToString().Trim(); //修改人
objgs_PaperParagraphVerEN.Memo = objRow[congs_PaperParagraphVer.Memo] == DBNull.Value ? null : objRow[congs_PaperParagraphVer.Memo].ToString().Trim(); //备注
objgs_PaperParagraphVerEN.PaperId = objRow[congs_PaperParagraphVer.PaperId] == DBNull.Value ? null : objRow[congs_PaperParagraphVer.PaperId].ToString().Trim(); //论文Id
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objgs_PaperParagraphVerEN.ParagraphVId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objgs_PaperParagraphVerEN);
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
public static List<clsgs_PaperParagraphVerEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsgs_PaperParagraphVerEN> arrObjLst = new List<clsgs_PaperParagraphVerEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsgs_PaperParagraphVerEN objgs_PaperParagraphVerEN = new clsgs_PaperParagraphVerEN();
try
{
objgs_PaperParagraphVerEN.ParagraphVId = Int32.Parse(objRow[congs_PaperParagraphVer.ParagraphVId].ToString().Trim()); //段落版本Id
objgs_PaperParagraphVerEN.ParagraphId = objRow[congs_PaperParagraphVer.ParagraphId].ToString().Trim(); //段落Id
objgs_PaperParagraphVerEN.SectionId = objRow[congs_PaperParagraphVer.SectionId].ToString().Trim(); //节Id
objgs_PaperParagraphVerEN.ParagraphTypeId = objRow[congs_PaperParagraphVer.ParagraphTypeId].ToString().Trim(); //段落类型Id
objgs_PaperParagraphVerEN.ParagraphContent = objRow[congs_PaperParagraphVer.ParagraphContent] == DBNull.Value ? null : objRow[congs_PaperParagraphVer.ParagraphContent].ToString().Trim(); //段落内容
objgs_PaperParagraphVerEN.UpdDate = objRow[congs_PaperParagraphVer.UpdDate] == DBNull.Value ? null : objRow[congs_PaperParagraphVer.UpdDate].ToString().Trim(); //修改日期
objgs_PaperParagraphVerEN.UpdUser = objRow[congs_PaperParagraphVer.UpdUser] == DBNull.Value ? null : objRow[congs_PaperParagraphVer.UpdUser].ToString().Trim(); //修改人
objgs_PaperParagraphVerEN.Memo = objRow[congs_PaperParagraphVer.Memo] == DBNull.Value ? null : objRow[congs_PaperParagraphVer.Memo].ToString().Trim(); //备注
objgs_PaperParagraphVerEN.PaperId = objRow[congs_PaperParagraphVer.PaperId] == DBNull.Value ? null : objRow[congs_PaperParagraphVer.PaperId].ToString().Trim(); //论文Id
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objgs_PaperParagraphVerEN.ParagraphVId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objgs_PaperParagraphVerEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objgs_PaperParagraphVerCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsgs_PaperParagraphVerEN> GetSubObjLstCache(clsgs_PaperParagraphVerEN objgs_PaperParagraphVerCond)
{
List<clsgs_PaperParagraphVerEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsgs_PaperParagraphVerEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in congs_PaperParagraphVer.AttributeName)
{
if (objgs_PaperParagraphVerCond.IsUpdated(strFldName) == false) continue;
if (objgs_PaperParagraphVerCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objgs_PaperParagraphVerCond[strFldName].ToString());
}
else
{
if (objgs_PaperParagraphVerCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objgs_PaperParagraphVerCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objgs_PaperParagraphVerCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objgs_PaperParagraphVerCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objgs_PaperParagraphVerCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objgs_PaperParagraphVerCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objgs_PaperParagraphVerCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objgs_PaperParagraphVerCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objgs_PaperParagraphVerCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objgs_PaperParagraphVerCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objgs_PaperParagraphVerCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objgs_PaperParagraphVerCond[strFldName]));
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
public static List<clsgs_PaperParagraphVerEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsgs_PaperParagraphVerEN> arrObjLst = new List<clsgs_PaperParagraphVerEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsgs_PaperParagraphVerEN objgs_PaperParagraphVerEN = new clsgs_PaperParagraphVerEN();
try
{
objgs_PaperParagraphVerEN.ParagraphVId = Int32.Parse(objRow[congs_PaperParagraphVer.ParagraphVId].ToString().Trim()); //段落版本Id
objgs_PaperParagraphVerEN.ParagraphId = objRow[congs_PaperParagraphVer.ParagraphId].ToString().Trim(); //段落Id
objgs_PaperParagraphVerEN.SectionId = objRow[congs_PaperParagraphVer.SectionId].ToString().Trim(); //节Id
objgs_PaperParagraphVerEN.ParagraphTypeId = objRow[congs_PaperParagraphVer.ParagraphTypeId].ToString().Trim(); //段落类型Id
objgs_PaperParagraphVerEN.ParagraphContent = objRow[congs_PaperParagraphVer.ParagraphContent] == DBNull.Value ? null : objRow[congs_PaperParagraphVer.ParagraphContent].ToString().Trim(); //段落内容
objgs_PaperParagraphVerEN.UpdDate = objRow[congs_PaperParagraphVer.UpdDate] == DBNull.Value ? null : objRow[congs_PaperParagraphVer.UpdDate].ToString().Trim(); //修改日期
objgs_PaperParagraphVerEN.UpdUser = objRow[congs_PaperParagraphVer.UpdUser] == DBNull.Value ? null : objRow[congs_PaperParagraphVer.UpdUser].ToString().Trim(); //修改人
objgs_PaperParagraphVerEN.Memo = objRow[congs_PaperParagraphVer.Memo] == DBNull.Value ? null : objRow[congs_PaperParagraphVer.Memo].ToString().Trim(); //备注
objgs_PaperParagraphVerEN.PaperId = objRow[congs_PaperParagraphVer.PaperId] == DBNull.Value ? null : objRow[congs_PaperParagraphVer.PaperId].ToString().Trim(); //论文Id
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objgs_PaperParagraphVerEN.ParagraphVId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objgs_PaperParagraphVerEN);
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
public static List<clsgs_PaperParagraphVerEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsgs_PaperParagraphVerEN> arrObjLst = new List<clsgs_PaperParagraphVerEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsgs_PaperParagraphVerEN objgs_PaperParagraphVerEN = new clsgs_PaperParagraphVerEN();
try
{
objgs_PaperParagraphVerEN.ParagraphVId = Int32.Parse(objRow[congs_PaperParagraphVer.ParagraphVId].ToString().Trim()); //段落版本Id
objgs_PaperParagraphVerEN.ParagraphId = objRow[congs_PaperParagraphVer.ParagraphId].ToString().Trim(); //段落Id
objgs_PaperParagraphVerEN.SectionId = objRow[congs_PaperParagraphVer.SectionId].ToString().Trim(); //节Id
objgs_PaperParagraphVerEN.ParagraphTypeId = objRow[congs_PaperParagraphVer.ParagraphTypeId].ToString().Trim(); //段落类型Id
objgs_PaperParagraphVerEN.ParagraphContent = objRow[congs_PaperParagraphVer.ParagraphContent] == DBNull.Value ? null : objRow[congs_PaperParagraphVer.ParagraphContent].ToString().Trim(); //段落内容
objgs_PaperParagraphVerEN.UpdDate = objRow[congs_PaperParagraphVer.UpdDate] == DBNull.Value ? null : objRow[congs_PaperParagraphVer.UpdDate].ToString().Trim(); //修改日期
objgs_PaperParagraphVerEN.UpdUser = objRow[congs_PaperParagraphVer.UpdUser] == DBNull.Value ? null : objRow[congs_PaperParagraphVer.UpdUser].ToString().Trim(); //修改人
objgs_PaperParagraphVerEN.Memo = objRow[congs_PaperParagraphVer.Memo] == DBNull.Value ? null : objRow[congs_PaperParagraphVer.Memo].ToString().Trim(); //备注
objgs_PaperParagraphVerEN.PaperId = objRow[congs_PaperParagraphVer.PaperId] == DBNull.Value ? null : objRow[congs_PaperParagraphVer.PaperId].ToString().Trim(); //论文Id
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objgs_PaperParagraphVerEN.ParagraphVId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objgs_PaperParagraphVerEN);
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
List<clsgs_PaperParagraphVerEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsgs_PaperParagraphVerEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsgs_PaperParagraphVerEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsgs_PaperParagraphVerEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsgs_PaperParagraphVerEN> arrObjLst = new List<clsgs_PaperParagraphVerEN>(); 
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
	clsgs_PaperParagraphVerEN objgs_PaperParagraphVerEN = new clsgs_PaperParagraphVerEN();
try
{
objgs_PaperParagraphVerEN.ParagraphVId = Int32.Parse(objRow[congs_PaperParagraphVer.ParagraphVId].ToString().Trim()); //段落版本Id
objgs_PaperParagraphVerEN.ParagraphId = objRow[congs_PaperParagraphVer.ParagraphId].ToString().Trim(); //段落Id
objgs_PaperParagraphVerEN.SectionId = objRow[congs_PaperParagraphVer.SectionId].ToString().Trim(); //节Id
objgs_PaperParagraphVerEN.ParagraphTypeId = objRow[congs_PaperParagraphVer.ParagraphTypeId].ToString().Trim(); //段落类型Id
objgs_PaperParagraphVerEN.ParagraphContent = objRow[congs_PaperParagraphVer.ParagraphContent] == DBNull.Value ? null : objRow[congs_PaperParagraphVer.ParagraphContent].ToString().Trim(); //段落内容
objgs_PaperParagraphVerEN.UpdDate = objRow[congs_PaperParagraphVer.UpdDate] == DBNull.Value ? null : objRow[congs_PaperParagraphVer.UpdDate].ToString().Trim(); //修改日期
objgs_PaperParagraphVerEN.UpdUser = objRow[congs_PaperParagraphVer.UpdUser] == DBNull.Value ? null : objRow[congs_PaperParagraphVer.UpdUser].ToString().Trim(); //修改人
objgs_PaperParagraphVerEN.Memo = objRow[congs_PaperParagraphVer.Memo] == DBNull.Value ? null : objRow[congs_PaperParagraphVer.Memo].ToString().Trim(); //备注
objgs_PaperParagraphVerEN.PaperId = objRow[congs_PaperParagraphVer.PaperId] == DBNull.Value ? null : objRow[congs_PaperParagraphVer.PaperId].ToString().Trim(); //论文Id
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objgs_PaperParagraphVerEN.ParagraphVId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objgs_PaperParagraphVerEN);
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
public static List<clsgs_PaperParagraphVerEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsgs_PaperParagraphVerEN> arrObjLst = new List<clsgs_PaperParagraphVerEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsgs_PaperParagraphVerEN objgs_PaperParagraphVerEN = new clsgs_PaperParagraphVerEN();
try
{
objgs_PaperParagraphVerEN.ParagraphVId = Int32.Parse(objRow[congs_PaperParagraphVer.ParagraphVId].ToString().Trim()); //段落版本Id
objgs_PaperParagraphVerEN.ParagraphId = objRow[congs_PaperParagraphVer.ParagraphId].ToString().Trim(); //段落Id
objgs_PaperParagraphVerEN.SectionId = objRow[congs_PaperParagraphVer.SectionId].ToString().Trim(); //节Id
objgs_PaperParagraphVerEN.ParagraphTypeId = objRow[congs_PaperParagraphVer.ParagraphTypeId].ToString().Trim(); //段落类型Id
objgs_PaperParagraphVerEN.ParagraphContent = objRow[congs_PaperParagraphVer.ParagraphContent] == DBNull.Value ? null : objRow[congs_PaperParagraphVer.ParagraphContent].ToString().Trim(); //段落内容
objgs_PaperParagraphVerEN.UpdDate = objRow[congs_PaperParagraphVer.UpdDate] == DBNull.Value ? null : objRow[congs_PaperParagraphVer.UpdDate].ToString().Trim(); //修改日期
objgs_PaperParagraphVerEN.UpdUser = objRow[congs_PaperParagraphVer.UpdUser] == DBNull.Value ? null : objRow[congs_PaperParagraphVer.UpdUser].ToString().Trim(); //修改人
objgs_PaperParagraphVerEN.Memo = objRow[congs_PaperParagraphVer.Memo] == DBNull.Value ? null : objRow[congs_PaperParagraphVer.Memo].ToString().Trim(); //备注
objgs_PaperParagraphVerEN.PaperId = objRow[congs_PaperParagraphVer.PaperId] == DBNull.Value ? null : objRow[congs_PaperParagraphVer.PaperId].ToString().Trim(); //论文Id
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objgs_PaperParagraphVerEN.ParagraphVId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objgs_PaperParagraphVerEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsgs_PaperParagraphVerEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsgs_PaperParagraphVerEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsgs_PaperParagraphVerEN> arrObjLst = new List<clsgs_PaperParagraphVerEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsgs_PaperParagraphVerEN objgs_PaperParagraphVerEN = new clsgs_PaperParagraphVerEN();
try
{
objgs_PaperParagraphVerEN.ParagraphVId = Int32.Parse(objRow[congs_PaperParagraphVer.ParagraphVId].ToString().Trim()); //段落版本Id
objgs_PaperParagraphVerEN.ParagraphId = objRow[congs_PaperParagraphVer.ParagraphId].ToString().Trim(); //段落Id
objgs_PaperParagraphVerEN.SectionId = objRow[congs_PaperParagraphVer.SectionId].ToString().Trim(); //节Id
objgs_PaperParagraphVerEN.ParagraphTypeId = objRow[congs_PaperParagraphVer.ParagraphTypeId].ToString().Trim(); //段落类型Id
objgs_PaperParagraphVerEN.ParagraphContent = objRow[congs_PaperParagraphVer.ParagraphContent] == DBNull.Value ? null : objRow[congs_PaperParagraphVer.ParagraphContent].ToString().Trim(); //段落内容
objgs_PaperParagraphVerEN.UpdDate = objRow[congs_PaperParagraphVer.UpdDate] == DBNull.Value ? null : objRow[congs_PaperParagraphVer.UpdDate].ToString().Trim(); //修改日期
objgs_PaperParagraphVerEN.UpdUser = objRow[congs_PaperParagraphVer.UpdUser] == DBNull.Value ? null : objRow[congs_PaperParagraphVer.UpdUser].ToString().Trim(); //修改人
objgs_PaperParagraphVerEN.Memo = objRow[congs_PaperParagraphVer.Memo] == DBNull.Value ? null : objRow[congs_PaperParagraphVer.Memo].ToString().Trim(); //备注
objgs_PaperParagraphVerEN.PaperId = objRow[congs_PaperParagraphVer.PaperId] == DBNull.Value ? null : objRow[congs_PaperParagraphVer.PaperId].ToString().Trim(); //论文Id
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objgs_PaperParagraphVerEN.ParagraphVId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objgs_PaperParagraphVerEN);
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
public static List<clsgs_PaperParagraphVerEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsgs_PaperParagraphVerEN> arrObjLst = new List<clsgs_PaperParagraphVerEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsgs_PaperParagraphVerEN objgs_PaperParagraphVerEN = new clsgs_PaperParagraphVerEN();
try
{
objgs_PaperParagraphVerEN.ParagraphVId = Int32.Parse(objRow[congs_PaperParagraphVer.ParagraphVId].ToString().Trim()); //段落版本Id
objgs_PaperParagraphVerEN.ParagraphId = objRow[congs_PaperParagraphVer.ParagraphId].ToString().Trim(); //段落Id
objgs_PaperParagraphVerEN.SectionId = objRow[congs_PaperParagraphVer.SectionId].ToString().Trim(); //节Id
objgs_PaperParagraphVerEN.ParagraphTypeId = objRow[congs_PaperParagraphVer.ParagraphTypeId].ToString().Trim(); //段落类型Id
objgs_PaperParagraphVerEN.ParagraphContent = objRow[congs_PaperParagraphVer.ParagraphContent] == DBNull.Value ? null : objRow[congs_PaperParagraphVer.ParagraphContent].ToString().Trim(); //段落内容
objgs_PaperParagraphVerEN.UpdDate = objRow[congs_PaperParagraphVer.UpdDate] == DBNull.Value ? null : objRow[congs_PaperParagraphVer.UpdDate].ToString().Trim(); //修改日期
objgs_PaperParagraphVerEN.UpdUser = objRow[congs_PaperParagraphVer.UpdUser] == DBNull.Value ? null : objRow[congs_PaperParagraphVer.UpdUser].ToString().Trim(); //修改人
objgs_PaperParagraphVerEN.Memo = objRow[congs_PaperParagraphVer.Memo] == DBNull.Value ? null : objRow[congs_PaperParagraphVer.Memo].ToString().Trim(); //备注
objgs_PaperParagraphVerEN.PaperId = objRow[congs_PaperParagraphVer.PaperId] == DBNull.Value ? null : objRow[congs_PaperParagraphVer.PaperId].ToString().Trim(); //论文Id
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objgs_PaperParagraphVerEN.ParagraphVId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objgs_PaperParagraphVerEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsgs_PaperParagraphVerEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsgs_PaperParagraphVerEN> arrObjLst = new List<clsgs_PaperParagraphVerEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsgs_PaperParagraphVerEN objgs_PaperParagraphVerEN = new clsgs_PaperParagraphVerEN();
try
{
objgs_PaperParagraphVerEN.ParagraphVId = Int32.Parse(objRow[congs_PaperParagraphVer.ParagraphVId].ToString().Trim()); //段落版本Id
objgs_PaperParagraphVerEN.ParagraphId = objRow[congs_PaperParagraphVer.ParagraphId].ToString().Trim(); //段落Id
objgs_PaperParagraphVerEN.SectionId = objRow[congs_PaperParagraphVer.SectionId].ToString().Trim(); //节Id
objgs_PaperParagraphVerEN.ParagraphTypeId = objRow[congs_PaperParagraphVer.ParagraphTypeId].ToString().Trim(); //段落类型Id
objgs_PaperParagraphVerEN.ParagraphContent = objRow[congs_PaperParagraphVer.ParagraphContent] == DBNull.Value ? null : objRow[congs_PaperParagraphVer.ParagraphContent].ToString().Trim(); //段落内容
objgs_PaperParagraphVerEN.UpdDate = objRow[congs_PaperParagraphVer.UpdDate] == DBNull.Value ? null : objRow[congs_PaperParagraphVer.UpdDate].ToString().Trim(); //修改日期
objgs_PaperParagraphVerEN.UpdUser = objRow[congs_PaperParagraphVer.UpdUser] == DBNull.Value ? null : objRow[congs_PaperParagraphVer.UpdUser].ToString().Trim(); //修改人
objgs_PaperParagraphVerEN.Memo = objRow[congs_PaperParagraphVer.Memo] == DBNull.Value ? null : objRow[congs_PaperParagraphVer.Memo].ToString().Trim(); //备注
objgs_PaperParagraphVerEN.PaperId = objRow[congs_PaperParagraphVer.PaperId] == DBNull.Value ? null : objRow[congs_PaperParagraphVer.PaperId].ToString().Trim(); //论文Id
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objgs_PaperParagraphVerEN.ParagraphVId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objgs_PaperParagraphVerEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objgs_PaperParagraphVerEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool Getgs_PaperParagraphVer(ref clsgs_PaperParagraphVerEN objgs_PaperParagraphVerEN)
{
bool bolResult = gs_PaperParagraphVerDA.Getgs_PaperParagraphVer(ref objgs_PaperParagraphVerEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "lngParagraphVId">表关键字</param>
 /// <returns>表对象</returns>
public static clsgs_PaperParagraphVerEN GetObjByParagraphVId(long lngParagraphVId)
{
clsgs_PaperParagraphVerEN objgs_PaperParagraphVerEN = gs_PaperParagraphVerDA.GetObjByParagraphVId(lngParagraphVId);
return objgs_PaperParagraphVerEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsgs_PaperParagraphVerEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsgs_PaperParagraphVerEN objgs_PaperParagraphVerEN = gs_PaperParagraphVerDA.GetFirstObj(strWhereCond);
 return objgs_PaperParagraphVerEN;
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
public static clsgs_PaperParagraphVerEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsgs_PaperParagraphVerEN objgs_PaperParagraphVerEN = gs_PaperParagraphVerDA.GetObjByDataRow(objRow);
 return objgs_PaperParagraphVerEN;
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
public static clsgs_PaperParagraphVerEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsgs_PaperParagraphVerEN objgs_PaperParagraphVerEN = gs_PaperParagraphVerDA.GetObjByDataRow(objRow);
 return objgs_PaperParagraphVerEN;
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
 /// <param name = "lngParagraphVId">所给的关键字</param>
 /// <param name = "lstgs_PaperParagraphVerObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsgs_PaperParagraphVerEN GetObjByParagraphVIdFromList(long lngParagraphVId, List<clsgs_PaperParagraphVerEN> lstgs_PaperParagraphVerObjLst)
{
foreach (clsgs_PaperParagraphVerEN objgs_PaperParagraphVerEN in lstgs_PaperParagraphVerObjLst)
{
if (objgs_PaperParagraphVerEN.ParagraphVId == lngParagraphVId)
{
return objgs_PaperParagraphVerEN;
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
 long lngParagraphVId;
 try
 {
 lngParagraphVId = new clsgs_PaperParagraphVerDA().GetFirstID(strWhereCond);
 return lngParagraphVId;
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
 arrList = gs_PaperParagraphVerDA.GetID(strWhereCond);
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
bool bolIsExist = gs_PaperParagraphVerDA.IsExistCondRec(strWhereCond);
return bolIsExist;
}

 /// <summary>
 /// 判断当前表中是否存在给定关键字值的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExist)
 /// </summary>
 /// <param name = "lngParagraphVId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public static bool IsExist(long lngParagraphVId)
{
//检测记录是否存在
bool bolIsExist = gs_PaperParagraphVerDA.IsExist(lngParagraphVId);
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
 bolIsExist = clsgs_PaperParagraphVerDA.IsExistTable();
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
 bolIsExist = gs_PaperParagraphVerDA.IsExistTable(strTabName);
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
 /// <param name = "objgs_PaperParagraphVerEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecordBySql2(clsgs_PaperParagraphVerEN objgs_PaperParagraphVerEN, bool bolIsNeedCheckUniqueness=true)
{
if (bolIsNeedCheckUniqueness == true && objgs_PaperParagraphVerEN.CheckUniqueness() == false)
{
var strMsg = string.Format("记录已经存在!段落版本Id = [{0}]的数据已经存在!(in clsgs_PaperParagraphVerBL.AddNewRecordBySql2)", objgs_PaperParagraphVerEN.ParagraphVId);
throw new Exception(strMsg);
}
try
{
bool bolResult = gs_PaperParagraphVerDA.AddNewRecordBySQL2(objgs_PaperParagraphVerEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsgs_PaperParagraphVerBL.ReFreshCache();

if (clsgs_PaperParagraphVerBL.relatedActions != null)
{
clsgs_PaperParagraphVerBL.relatedActions.UpdRelaTabDate(objgs_PaperParagraphVerEN.ParagraphVId, "SetUpdDate");
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
 /// <param name = "objgs_PaperParagraphVerEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public static string AddNewRecordBySql2WithReturnKey(clsgs_PaperParagraphVerEN objgs_PaperParagraphVerEN, bool bolIsNeedCheckUniqueness=true)
{
if (bolIsNeedCheckUniqueness == true && objgs_PaperParagraphVerEN.CheckUniqueness() == false)
{
var strMsg = string.Format("记录已经存在!段落版本Id = [{0}]的数据已经存在!(in clsgs_PaperParagraphVerBL.AddNewRecordBySql2WithReturnKey)", objgs_PaperParagraphVerEN.ParagraphVId);
throw new Exception(strMsg);
}
try
{
string strKey = gs_PaperParagraphVerDA.AddNewRecordBySQL2WithReturnKey(objgs_PaperParagraphVerEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsgs_PaperParagraphVerBL.ReFreshCache();

if (clsgs_PaperParagraphVerBL.relatedActions != null)
{
clsgs_PaperParagraphVerBL.relatedActions.UpdRelaTabDate(objgs_PaperParagraphVerEN.ParagraphVId, "SetUpdDate");
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
 /// <param name = "objgs_PaperParagraphVerEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(clsgs_PaperParagraphVerEN objgs_PaperParagraphVerEN)
{
try
{
bool bolResult = gs_PaperParagraphVerDA.Update(objgs_PaperParagraphVerEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsgs_PaperParagraphVerBL.ReFreshCache();

if (clsgs_PaperParagraphVerBL.relatedActions != null)
{
clsgs_PaperParagraphVerBL.relatedActions.UpdRelaTabDate(objgs_PaperParagraphVerEN.ParagraphVId, "SetUpdDate");
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
 /// <param name = "objgs_PaperParagraphVerEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateBySql2(clsgs_PaperParagraphVerEN objgs_PaperParagraphVerEN)
{
 if (objgs_PaperParagraphVerEN.ParagraphVId == 0)
 {
var strMsg = string.Format("(errid:Busi000065)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
bool bolResult = gs_PaperParagraphVerDA.UpdateBySql2(objgs_PaperParagraphVerEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsgs_PaperParagraphVerBL.ReFreshCache();

if (clsgs_PaperParagraphVerBL.relatedActions != null)
{
clsgs_PaperParagraphVerBL.relatedActions.UpdRelaTabDate(objgs_PaperParagraphVerEN.ParagraphVId, "SetUpdDate");
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
 /// <param name = "lngParagraphVId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public static int DelRecord(long lngParagraphVId)
{
try
{
 clsgs_PaperParagraphVerEN objgs_PaperParagraphVerEN = clsgs_PaperParagraphVerBL.GetObjByParagraphVId(lngParagraphVId);

if (clsgs_PaperParagraphVerBL.relatedActions != null)
{
clsgs_PaperParagraphVerBL.relatedActions.UpdRelaTabDate(objgs_PaperParagraphVerEN.ParagraphVId, "SetUpdDate");
}
if (objgs_PaperParagraphVerEN != null)
{
int intRecNum = gs_PaperParagraphVerDA.DelRecord(lngParagraphVId);
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
/// <param name="lngParagraphVId">表关键字</param>
/// <returns></returns>
public static bool DelRecordEx(long lngParagraphVId )
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsgs_PaperParagraphVerDA.GetSpecSQLObj();
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
//删除与表:[gs_PaperParagraphVer]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//congs_PaperParagraphVer.ParagraphVId,
//lngParagraphVId);
//        clsgs_PaperParagraphVerBL.Delgs_PaperParagraphVersByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsgs_PaperParagraphVerBL.DelRecord(lngParagraphVId, objConnection, objSqlTransaction);
objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsgs_PaperParagraphVerBLEx", "DelRecordEx", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("扩展删除记录出错:{0}!keyId = {1}.({2})",
objException.Message,
lngParagraphVId, clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "lngParagraphVId">给定的关键字值</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回删除是否成功?</returns>
public static bool DelRecord(long lngParagraphVId, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
if (clsgs_PaperParagraphVerBL.relatedActions != null)
{
clsgs_PaperParagraphVerBL.relatedActions.UpdRelaTabDate(lngParagraphVId, "UpdRelaTabDate");
}
bool bolResult = gs_PaperParagraphVerDA.DelRecord(lngParagraphVId,objSqlConnection,objSqlTransaction);
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
 /// <param name = "arrParagraphVIdLst">给定的关键字值列表</param>
 /// <returns>返回删除的记录数</returns>
public static int Delgs_PaperParagraphVers(List<string> arrParagraphVIdLst)
{
if (arrParagraphVIdLst.Count == 0) return 0;
try
{
if (clsgs_PaperParagraphVerBL.relatedActions != null)
{
foreach (var strParagraphVId in arrParagraphVIdLst)
{
long lngParagraphVId = long.Parse(strParagraphVId);
clsgs_PaperParagraphVerBL.relatedActions.UpdRelaTabDate(lngParagraphVId, "UpdRelaTabDate");
}
}
int intDelRecNum = gs_PaperParagraphVerDA.Delgs_PaperParagraphVer(arrParagraphVIdLst);
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
public static int Delgs_PaperParagraphVersByCond(string strWhereCond)
{
try
{
if (clsgs_PaperParagraphVerBL.relatedActions != null)
{
List<string> arrParagraphVId = GetPrimaryKeyID_S(strWhereCond);
foreach (var strParagraphVId in arrParagraphVId)
{
long lngParagraphVId = long.Parse(strParagraphVId);
clsgs_PaperParagraphVerBL.relatedActions.UpdRelaTabDate(lngParagraphVId, "UpdRelaTabDate");
}
}
int intRecNum = gs_PaperParagraphVerDA.Delgs_PaperParagraphVer(strWhereCond);
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
/// 这里仅仅是演示函数,使用时请复制到扩展类:[gs_PaperParagraphVer]中改名为:[DelRecord4MultiTabEx]使用
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DelRecord4MultiTab)
/// </summary>
/// <param name="lngParagraphVId">表关键字</param>
/// <returns></returns>
public static bool DelRecord4MultiTab(long lngParagraphVId)
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsgs_PaperParagraphVerDA.GetSpecSQLObj();
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
//删除与表:[gs_PaperParagraphVer]相关的表的代码,需要时去除注释,编写相关的代码
//string strCondition = string.Format("{0} = '{1}'",
//conStudent.id_College,
//strid_College);
//        clsStudentBL.DelStudentsByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
//
clsgs_PaperParagraphVerBL.DelRecord(lngParagraphVId, objConnection, objSqlTransaction);
                objSqlTransaction.Commit();
return true;
}
catch (Exception objException)
{
ErrorInformationBL.AddInformation("clsgs_PaperParagraphVerBL", "DelRecord4MultiTab", objException.Message, clsSysParaEN.strUserId);
string strMsg = string.Format("删除多表记录出错:{0}!keyId = {1}.({2})",
objException.Message,
lngParagraphVId, clsStackTrace.GetCurrClassFunction());
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
 /// <param name = "objgs_PaperParagraphVerENS">源对象</param>
 /// <param name = "objgs_PaperParagraphVerENT">目标对象</param>
 public static void CopyTo(clsgs_PaperParagraphVerEN objgs_PaperParagraphVerENS, clsgs_PaperParagraphVerEN objgs_PaperParagraphVerENT)
{
try
{
objgs_PaperParagraphVerENT.ParagraphVId = objgs_PaperParagraphVerENS.ParagraphVId; //段落版本Id
objgs_PaperParagraphVerENT.ParagraphId = objgs_PaperParagraphVerENS.ParagraphId; //段落Id
objgs_PaperParagraphVerENT.SectionId = objgs_PaperParagraphVerENS.SectionId; //节Id
objgs_PaperParagraphVerENT.ParagraphTypeId = objgs_PaperParagraphVerENS.ParagraphTypeId; //段落类型Id
objgs_PaperParagraphVerENT.ParagraphContent = objgs_PaperParagraphVerENS.ParagraphContent; //段落内容
objgs_PaperParagraphVerENT.UpdDate = objgs_PaperParagraphVerENS.UpdDate; //修改日期
objgs_PaperParagraphVerENT.UpdUser = objgs_PaperParagraphVerENS.UpdUser; //修改人
objgs_PaperParagraphVerENT.Memo = objgs_PaperParagraphVerENS.Memo; //备注
objgs_PaperParagraphVerENT.PaperId = objgs_PaperParagraphVerENS.PaperId; //论文Id
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
 /// <param name = "objgs_PaperParagraphVerEN">源简化对象</param>
 public static void SetUpdFlag(clsgs_PaperParagraphVerEN objgs_PaperParagraphVerEN)
{
try
{
objgs_PaperParagraphVerEN.ClearUpdateState();
   string strsfUpdFldSetStr = objgs_PaperParagraphVerEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(congs_PaperParagraphVer.ParagraphVId, new clsStrCompareIgnoreCase())  ==  true)
{
objgs_PaperParagraphVerEN.ParagraphVId = objgs_PaperParagraphVerEN.ParagraphVId; //段落版本Id
}
if (arrFldSet.Contains(congs_PaperParagraphVer.ParagraphId, new clsStrCompareIgnoreCase())  ==  true)
{
objgs_PaperParagraphVerEN.ParagraphId = objgs_PaperParagraphVerEN.ParagraphId; //段落Id
}
if (arrFldSet.Contains(congs_PaperParagraphVer.SectionId, new clsStrCompareIgnoreCase())  ==  true)
{
objgs_PaperParagraphVerEN.SectionId = objgs_PaperParagraphVerEN.SectionId; //节Id
}
if (arrFldSet.Contains(congs_PaperParagraphVer.ParagraphTypeId, new clsStrCompareIgnoreCase())  ==  true)
{
objgs_PaperParagraphVerEN.ParagraphTypeId = objgs_PaperParagraphVerEN.ParagraphTypeId; //段落类型Id
}
if (arrFldSet.Contains(congs_PaperParagraphVer.ParagraphContent, new clsStrCompareIgnoreCase())  ==  true)
{
objgs_PaperParagraphVerEN.ParagraphContent = objgs_PaperParagraphVerEN.ParagraphContent == "[null]" ? null :  objgs_PaperParagraphVerEN.ParagraphContent; //段落内容
}
if (arrFldSet.Contains(congs_PaperParagraphVer.UpdDate, new clsStrCompareIgnoreCase())  ==  true)
{
objgs_PaperParagraphVerEN.UpdDate = objgs_PaperParagraphVerEN.UpdDate == "[null]" ? null :  objgs_PaperParagraphVerEN.UpdDate; //修改日期
}
if (arrFldSet.Contains(congs_PaperParagraphVer.UpdUser, new clsStrCompareIgnoreCase())  ==  true)
{
objgs_PaperParagraphVerEN.UpdUser = objgs_PaperParagraphVerEN.UpdUser == "[null]" ? null :  objgs_PaperParagraphVerEN.UpdUser; //修改人
}
if (arrFldSet.Contains(congs_PaperParagraphVer.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objgs_PaperParagraphVerEN.Memo = objgs_PaperParagraphVerEN.Memo == "[null]" ? null :  objgs_PaperParagraphVerEN.Memo; //备注
}
if (arrFldSet.Contains(congs_PaperParagraphVer.PaperId, new clsStrCompareIgnoreCase())  ==  true)
{
objgs_PaperParagraphVerEN.PaperId = objgs_PaperParagraphVerEN.PaperId == "[null]" ? null :  objgs_PaperParagraphVerEN.PaperId; //论文Id
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
 /// <param name = "objgs_PaperParagraphVerEN">源简化对象</param>
 public static void AccessFldValueNull(clsgs_PaperParagraphVerEN objgs_PaperParagraphVerEN)
{
try
{
if (objgs_PaperParagraphVerEN.ParagraphContent == "[null]") objgs_PaperParagraphVerEN.ParagraphContent = null; //段落内容
if (objgs_PaperParagraphVerEN.UpdDate == "[null]") objgs_PaperParagraphVerEN.UpdDate = null; //修改日期
if (objgs_PaperParagraphVerEN.UpdUser == "[null]") objgs_PaperParagraphVerEN.UpdUser = null; //修改人
if (objgs_PaperParagraphVerEN.Memo == "[null]") objgs_PaperParagraphVerEN.Memo = null; //备注
if (objgs_PaperParagraphVerEN.PaperId == "[null]") objgs_PaperParagraphVerEN.PaperId = null; //论文Id
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
public static void CheckPropertyNew(clsgs_PaperParagraphVerEN objgs_PaperParagraphVerEN)
{
 gs_PaperParagraphVerDA.CheckPropertyNew(objgs_PaperParagraphVerEN);
 }

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(clsgs_PaperParagraphVerEN objgs_PaperParagraphVerEN)
{
 gs_PaperParagraphVerDA.CheckProperty4Condition(objgs_PaperParagraphVerEN);
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
if (clsgs_PaperParagraphVerBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsgs_PaperParagraphVerBL没有刷新缓存机制(clsgs_PaperParagraphVerBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by ParagraphVId");
//if (arrgs_PaperParagraphVerObjLstCache == null)
//{
//arrgs_PaperParagraphVerObjLstCache = gs_PaperParagraphVerDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "lngParagraphVId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsgs_PaperParagraphVerEN GetObjByParagraphVIdCache(long lngParagraphVId)
{
//获取缓存中的对象列表
string strKey = string.Format("{0}", clsgs_PaperParagraphVerEN._CurrTabName);
List<clsgs_PaperParagraphVerEN> arrgs_PaperParagraphVerObjLstCache = GetObjLstCache();
IEnumerable <clsgs_PaperParagraphVerEN> arrgs_PaperParagraphVerObjLst_Sel =
arrgs_PaperParagraphVerObjLstCache
.Where(x=> x.ParagraphVId == lngParagraphVId 
);
if (arrgs_PaperParagraphVerObjLst_Sel.Count() == 0)
{
   clsgs_PaperParagraphVerEN obj = clsgs_PaperParagraphVerBL.GetObjByParagraphVId(lngParagraphVId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
 }
return null;
}
return arrgs_PaperParagraphVerObjLst_Sel.First();
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsgs_PaperParagraphVerEN> GetAllgs_PaperParagraphVerObjLstCache()
{
//获取缓存中的对象列表
List<clsgs_PaperParagraphVerEN> arrgs_PaperParagraphVerObjLstCache = GetObjLstCache(); 
return arrgs_PaperParagraphVerObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsgs_PaperParagraphVerEN> GetObjLstCache()
{
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}", clsgs_PaperParagraphVerEN._CurrTabName);
List<clsgs_PaperParagraphVerEN> arrgs_PaperParagraphVerObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrgs_PaperParagraphVerObjLstCache;
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
string strKey = string.Format("{0}", clsgs_PaperParagraphVerEN._CurrTabName);
CacheHelper.Remove(strKey);
clsgs_PaperParagraphVerEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
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
if (clsgs_PaperParagraphVerEN._RefreshTimeLst.Count == 0) return "";
return clsgs_PaperParagraphVerEN._RefreshTimeLst[clsgs_PaperParagraphVerEN._RefreshTimeLst.Count - 1];
}

 /// <summary>
 /// 刷新缓存.把当前表的缓存以及该表相关视图的缓存清空.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ReFreshCache)
 /// </summary>
public static void ReFreshCache()
{
if (clsgs_PaperParagraphVerBL.objCommFun4BL != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}", clsgs_PaperParagraphVerEN._CurrTabName);
CacheHelper.Remove(strKey);
clsgs_PaperParagraphVerEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
clsgs_PaperParagraphVerBL.objCommFun4BL.ReFreshCache();
}
}


 #endregion 缓存操作


 #region 检查唯一性

 /// <summary>
 /// 获取检查唯一性条件串(Uniqueness)--gs_PaperParagraphVer(论文段落版本)
 /// 唯一性条件:ParagraphVId
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetUniquenessConditionString)
 /// </summary>
 /// <param name = "objgs_PaperParagraphVerEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniCondStr(clsgs_PaperParagraphVerEN objgs_PaperParagraphVerEN)
{
//检测记录是否存在
string strResult = gs_PaperParagraphVerDA.GetUniCondStr(objgs_PaperParagraphVerEN);
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
 /// <returns>返回一个输出字段值</returns>
public static string Func(string strInFldName, string strOutFldName, long lngParagraphVId)
{
if (strInFldName != congs_PaperParagraphVer.ParagraphVId)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (congs_PaperParagraphVer.AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", congs_PaperParagraphVer.AttributeName));
throw new Exception(strMsg);
}
var objgs_PaperParagraphVer = clsgs_PaperParagraphVerBL.GetObjByParagraphVIdCache(lngParagraphVId);
if (objgs_PaperParagraphVer == null) return "";
return objgs_PaperParagraphVer[strOutFldName].ToString();
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
int intRecCount = clsgs_PaperParagraphVerDA.GetRecCount(strTabName);
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
int intRecCount = clsgs_PaperParagraphVerDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsgs_PaperParagraphVerDA.GetRecCount();
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
int intRecCount = clsgs_PaperParagraphVerDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objgs_PaperParagraphVerCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsgs_PaperParagraphVerEN objgs_PaperParagraphVerCond)
{
List<clsgs_PaperParagraphVerEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsgs_PaperParagraphVerEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in congs_PaperParagraphVer.AttributeName)
{
if (objgs_PaperParagraphVerCond.IsUpdated(strFldName) == false) continue;
if (objgs_PaperParagraphVerCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objgs_PaperParagraphVerCond[strFldName].ToString());
}
else
{
if (objgs_PaperParagraphVerCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objgs_PaperParagraphVerCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objgs_PaperParagraphVerCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objgs_PaperParagraphVerCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objgs_PaperParagraphVerCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objgs_PaperParagraphVerCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objgs_PaperParagraphVerCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objgs_PaperParagraphVerCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objgs_PaperParagraphVerCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objgs_PaperParagraphVerCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objgs_PaperParagraphVerCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objgs_PaperParagraphVerCond[strFldName]));
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
 List<string> arrList = clsgs_PaperParagraphVerDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = gs_PaperParagraphVerDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = gs_PaperParagraphVerDA.GetFldValueNoDistinct(strFldName, strWhereCond);
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
int intRecCount = gs_PaperParagraphVerDA.SetFldValue(strFldName, strValue, strWhereCond);
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
int intRecCount = clsgs_PaperParagraphVerDA.SetFldValue(clsgs_PaperParagraphVerEN._CurrTabName, strFldName, fltValue, strWhereCond);
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
int intRecCount = gs_PaperParagraphVerDA.SetFldValue( strFldName, intValue, strWhereCond);
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
int intRecCount = clsgs_PaperParagraphVerDA.SetFldValue(strTabName, strFldName, strValue, strWhereCond);
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
int intRecCount = clsgs_PaperParagraphVerDA.SetFldValue(strTabName, strFldName, intValue, strWhereCond);
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
int intRecCount = clsgs_PaperParagraphVerDA.SetFldValue(strTabName, strFldName, fltValue, strWhereCond);
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
  strCreateTabCode.Append("CREATE table [dbo].[gs_PaperParagraphVer] "); 
 strCreateTabCode.Append(" ( "); 
 // /**段落版本Id*/ 
 strCreateTabCode.Append(" ParagraphVId bigint primary key identity, "); 
 // /**段落Id*/ 
 strCreateTabCode.Append(" ParagraphId char(10) not Null, "); 
 // /**节Id*/ 
 strCreateTabCode.Append(" SectionId char(8) not Null, "); 
 // /**段落类型Id*/ 
 strCreateTabCode.Append(" ParagraphTypeId char(2) not Null, "); 
 // /**段落内容*/ 
 strCreateTabCode.Append(" ParagraphContent text Null, "); 
 // /**修改日期*/ 
 strCreateTabCode.Append(" UpdDate varchar(20) Null, "); 
 // /**修改人*/ 
 strCreateTabCode.Append(" UpdUser varchar(20) Null, "); 
 // /**备注*/ 
 strCreateTabCode.Append(" Memo varchar(1000) Null, "); 
 // /**论文Id*/ 
 strCreateTabCode.Append(" PaperId char(8) Null ");
 strCreateTabCode.Append(") "); 
  strCreateTabCode.Append("ON [PRIMARY] ");
  return strCreateTabCode.ToString();
}



 #endregion 表操作
}
 /// <summary>
 /// 论文段落版本(gs_PaperParagraphVer)
 /// 数据源类型:表
 /// (AutoGCLib.CommFun4BL4CSharp:GeneCode_This)
 /// </summary>
public class  clsCommFun4BL4gs_PaperParagraphVer : clsCommFun4BL
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
clsgs_PaperParagraphVerBL.ReFreshThisCache();
}
}

}